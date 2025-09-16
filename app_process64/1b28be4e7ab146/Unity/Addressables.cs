class <Module>
{
}

class PackedPlayModeBuildLogs
{
    /*0x10*/ System.Collections.Generic.List<PackedPlayModeBuildLogs.RuntimeBuildLog> m_RuntimeBuildLogs;

    /*0x793db98*/ PackedPlayModeBuildLogs();
    /*0x793db88*/ System.Collections.Generic.List<PackedPlayModeBuildLogs.RuntimeBuildLog> get_RuntimeBuildLogs();
    /*0x793db90*/ void set_RuntimeBuildLogs(System.Collections.Generic.List<PackedPlayModeBuildLogs.RuntimeBuildLog> value);

    struct RuntimeBuildLog
    {
        /*0x10*/ UnityEngine.LogType Type;
        /*0x18*/ string Message;

        /*0x793dc20*/ RuntimeBuildLog(UnityEngine.LogType type, string message);
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x793dc30*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x793dd24*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
        /*0x793dd3c*/ AssetReferenceUIRestriction();
        /*0x793dd2c*/ bool ValidateAsset(UnityEngine.Object obj);
        /*0x793dd34*/ bool ValidateAsset(string path);
    }

    class AssetReferenceUILabelRestriction : UnityEngine.AssetReferenceUIRestriction
    {
        /*0x10*/ string[] m_AllowedLabels;
        /*0x18*/ string m_CachedToString;

        /*0x793dd44*/ AssetReferenceUILabelRestriction(string[] allowedLabels);
        /*0x793dd74*/ bool ValidateAsset(UnityEngine.Object obj);
        /*0x793dd7c*/ bool ValidateAsset(string path);
        /*0x793dd84*/ string ToString();
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

                /*0x793eb38*/ InitalizationObjectsOperation();
                /*0x793de98*/ void Init(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData> rtdOp, UnityEngine.AddressableAssets.AddressablesImpl addressables);
                /*0x793def8*/ string get_DebugName();
                /*0x793df38*/ bool LogRuntimeWarnings(string pathToBuildLogs);
                /*0x793e26c*/ bool InvokeWaitForCompletion();
                /*0x793e40c*/ void Execute();
                /*0x793eb80*/ void <Execute>b__8_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> obj);
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

            /*0x793ed50*/ ResourceLocatorInfo(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator loc, string localHash, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteCatalogLocation);
            /*0x793ed0c*/ UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator get_Locator();
            /*0x793ed14*/ void set_Locator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator value);
            /*0x793ed1c*/ string get_LocalHash();
            /*0x793ed24*/ void set_LocalHash(string value);
            /*0x793ed2c*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_CatalogLocation();
            /*0x793ed34*/ void set_CatalogLocation(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation value);
            /*0x793ed3c*/ bool get_ContentUpdateAvailable();
            /*0x793ed44*/ void set_ContentUpdateAvailable(bool value);
            /*0x793edb0*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_HashLocation();
            /*0x793eecc*/ bool get_CanUpdateContent();
            /*0x793f070*/ void UpdateContent(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator, string hash, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc);
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

            static /*0x79409d8*/ string GetCSVString(System.Collections.IEnumerable enumerator, string prefixSingle, string prefixPlural);
            /*0x793f0e0*/ InvalidKeyException(object key);
            /*0x793f134*/ InvalidKeyException(object key, System.Type type);
            /*0x793f1bc*/ InvalidKeyException(object key, System.Type type, UnityEngine.AddressableAssets.AddressablesImpl addr);
            /*0x793f260*/ InvalidKeyException(object key, System.Type type, UnityEngine.AddressableAssets.Addressables.MergeMode mergeMode);
            /*0x793f328*/ InvalidKeyException(object key, System.Type type, UnityEngine.AddressableAssets.Addressables.MergeMode mergeMode, UnityEngine.AddressableAssets.AddressablesImpl addr);
            /*0x793f40c*/ InvalidKeyException();
            /*0x793f464*/ InvalidKeyException(string message);
            /*0x793f4cc*/ InvalidKeyException(string message, System.Exception innerException);
            /*0x793f53c*/ InvalidKeyException(System.Runtime.Serialization.SerializationInfo message, System.Runtime.Serialization.StreamingContext context);
            /*0x793f0b8*/ object get_Key();
            /*0x793f0c0*/ void set_Key(object value);
            /*0x793f0c8*/ System.Type get_Type();
            /*0x793f0d0*/ void set_Type(System.Type value);
            /*0x793f0d8*/ System.Nullable<UnityEngine.AddressableAssets.Addressables.MergeMode> get_MergeMode();
            /*0x793f5bc*/ string FormatMessage(UnityEngine.AddressableAssets.InvalidKeyException.Format format, string foundWithTypeString);
            /*0x793fdbc*/ string FormatMergeModeMessage(UnityEngine.AddressableAssets.InvalidKeyException.Format format, string keysAvailable, string keysUnavailable, string typeString);
            /*0x794029c*/ string get_Message();
            /*0x7940948*/ string GetMessageForSingleKey(string keyString);
            /*0x7942180*/ string FormatNotFoundMessage(string keyString);
            /*0x794218c*/ string FormatTypeNotAssignableMessage(string keyString, System.Collections.Generic.HashSet<System.Type> typesAvailableForKey);
            /*0x7942330*/ string FormatMultipleAssignableTypesMessage(string keyString, System.Collections.Generic.HashSet<System.Type> typesAvailableForKey);
            /*0x7940dc0*/ string GetMessageforMergeKeys(System.Collections.Generic.List<string> keys);
            /*0x7941a68*/ System.Collections.Generic.HashSet<System.Type> GetTypesForKey(string keyString);
            /*0x7942544*/ bool GetTypeToKeys(string key, System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<string>> typeToKeys);
            /*0x79401b4*/ string GetKeyString();

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

            static /*0x794acc0*/ Addressables();
            static /*0x7942968*/ UnityEngine.AddressableAssets.AddressablesImpl get_m_Addressables();
            static /*0x79429c0*/ string get_Version();
            static /*0x7942a00*/ UnityEngine.ResourceManagement.ResourceManager get_ResourceManager();
            static /*0x7942a94*/ UnityEngine.AddressableAssets.AddressablesImpl get_Instance();
            static /*0x7942b1c*/ UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider get_InstanceProvider();
            static /*0x7942bb0*/ string ResolveInternalId(string id);
            static /*0x7942c9c*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> get_InternalIdTransformFunc();
            static /*0x7942d54*/ void set_InternalIdTransformFunc(System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> value);
            static /*0x7942e14*/ System.Action<UnityEngine.Networking.UnityWebRequest> get_WebRequestOverride();
            static /*0x7942ecc*/ void set_WebRequestOverride(System.Action<UnityEngine.Networking.UnityWebRequest> value);
            static /*0x7942f8c*/ string get_StreamingAssetsSubFolder();
            static /*0x7943088*/ string get_BuildPath();
            static /*0x79431f4*/ string get_PlayerBuildDataPath();
            static /*0x7943330*/ string get_RuntimePath();
            static /*0x79433c4*/ System.Collections.Generic.IEnumerable<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> get_ResourceLocators();
            static /*0x7943454*/ void InternalSafeSerializationLog(string msg, UnityEngine.LogType logType);
            static /*0x7943670*/ void InternalSafeSerializationLogFormat(string format, UnityEngine.LogType logType, object[] args);
            static /*0x79438cc*/ void Log(string msg);
            static /*0x7943964*/ void LogFormat(string format, object[] args);
            static /*0x793e13c*/ void LogWarning(string msg);
            static /*0x7943a0c*/ void LogWarningFormat(string format, object[] args);
            static /*0x793e1d4*/ void LogError(string msg);
            static /*0x7943ab4*/ void LogException(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op, System.Exception ex);
            static /*0x7943c24*/ void LogException(System.Exception ex);
            static /*0x793ea90*/ void LogErrorFormat(string format, object[] args);
            static /*0x7943cb8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> InitializeAsync();
            static /*0x7943dfc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> InitializeAsync(bool autoReleaseHandle);
            static /*0x7943f54*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalogAsync(string catalogPath, string providerSuffix);
            static /*0x794422c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix);
            static /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            static /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key);
            static /*0x7944304*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsAsync(System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, System.Type type);
            static /*0x7944568*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsAsync(object key, System.Type type);
            static /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<TObject> callback);
            static /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            static /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.IEnumerable keys, System.Action<TObject> callback, UnityEngine.AddressableAssets.Addressables.MergeMode mode);
            static /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(string key, System.Action<TObject> callback);
            static /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.IEnumerable keys, System.Action<TObject> callback, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool releaseDependenciesOnFailure);
            static /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(string key, bool releaseDependenciesOnFailure, System.Action<TObject> callback);
            static /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(object key, System.Action<TObject> callback);
            static /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(object key, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            static /*0x3910ae8*/ void Release<TObject>(TObject obj);
            static /*0x3910ae8*/ void Release<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> handle);
            static /*0x79447b4*/ void Release(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            static /*0x79447bc*/ bool ReleaseInstance(UnityEngine.GameObject instance);
            static /*0x7944940*/ bool ReleaseInstance(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            static /*0x7944958*/ bool ReleaseInstance(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> handle);
            static /*0x79449a8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(object key);
            static /*0x7944b38*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(string key);
            static /*0x7944bf8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(System.Collections.IEnumerable keys);
            static /*0x7945c64*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle);
            static /*0x7945f78*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle);
            static /*0x7946180*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool autoReleaseHandle);
            static /*0x79464bc*/ void ClearDependencyCacheAsync(object key);
            static /*0x79467b8*/ void ClearDependencyCacheAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            static /*0x7946d68*/ void ClearDependencyCacheAsync(System.Collections.IEnumerable keys);
            static /*0x7947328*/ void ClearDependencyCacheAsync(string key);
            static /*0x79473d4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle);
            static /*0x79474a0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle);
            static /*0x794756c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(System.Collections.IEnumerable keys, bool autoReleaseHandle);
            static /*0x7947638*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(string key, bool autoReleaseHandle);
            static /*0x7947704*/ UnityEngine.AddressableAssets.ResourceLocatorInfo GetLocatorInfo(string locatorId);
            static /*0x794798c*/ UnityEngine.AddressableAssets.ResourceLocatorInfo GetLocatorInfo(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator);
            static /*0x7947a98*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.Transform parent, bool instantiateInWorldSpace, bool trackHandle);
            static /*0x7947ce0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool trackHandle);
            static /*0x7947e9c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.Transform parent, bool instantiateInWorldSpace, bool trackHandle);
            static /*0x7948010*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool trackHandle);
            static /*0x79481cc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            static /*0x79486fc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            static /*0x79487f8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(object key, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode);
            static /*0x7948b50*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(object key, UnityEngine.SceneManagement.LoadSceneMode loadMode, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority);
            static /*0x7948c5c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(object key, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority);
            static /*0x7948d48*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(object key, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority);
            static /*0x7948e3c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority);
            static /*0x7949058*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneMode loadMode, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority);
            static /*0x7949164*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority);
            static /*0x7949250*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority);
            static /*0x7949344*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.ResourceProviders.SceneInstance scene, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            static /*0x7949648*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            static /*0x794989c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.ResourceProviders.SceneInstance scene, bool autoReleaseHandle);
            static /*0x7949978*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, bool autoReleaseHandle);
            static /*0x7949a68*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle, bool autoReleaseHandle);
            static /*0x7949c2c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> CheckForCatalogUpdates(bool autoReleaseHandle);
            static /*0x7949e44*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> UpdateCatalogs(System.Collections.Generic.IEnumerable<string> catalogs, bool autoReleaseHandle);
            static /*0x794a16c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> UpdateCatalogs(bool autoCleanBundleCache, System.Collections.Generic.IEnumerable<string> catalogs, bool autoReleaseHandle);
            static /*0x794a244*/ void AddResourceLocator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator, string localCatalogHash, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteCatalogLocation);
            static /*0x794a3f0*/ void RemoveResourceLocator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator);
            static /*0x794a56c*/ void ClearResourceLocators();
            static /*0x794a66c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> CleanBundleCache(System.Collections.Generic.IEnumerable<string> catalogsIds);
            static /*0x38379c4*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath);
            static /*0x38379c4*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteCatalogLocation);
            static /*0x38395d4*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string remoteCatalogPath, string remoteHashPath);

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

            static /*0x794e3bc*/ void WrapAsDownloadLocations(System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            static /*0x794e4ac*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> GatherDependenciesFromLocations(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            /*0x794addc*/ AddressablesImpl(UnityEngine.ResourceManagement.Util.IAllocationStrategy alloc);
            /*0x794afc8*/ UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider get_InstanceProvider();
            /*0x794afd0*/ void set_InstanceProvider(UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider value);
            /*0x794b064*/ UnityEngine.ResourceManagement.ResourceManager get_ResourceManager();
            /*0x794b06c*/ int get_CatalogRequestsTimeout();
            /*0x794b074*/ void set_CatalogRequestsTimeout(int value);
            /*0x794b07c*/ int get_ActiveSceneInstances();
            /*0x794b0c4*/ int get_TrackedHandleCount();
            /*0x794b114*/ void ReleaseSceneManagerOperation();
            /*0x7942d38*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> get_InternalIdTransformFunc();
            /*0x7942df8*/ void set_InternalIdTransformFunc(System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> value);
            /*0x7942eb0*/ System.Action<UnityEngine.Networking.UnityWebRequest> get_WebRequestOverride();
            /*0x7942f70*/ void set_WebRequestOverride(System.Action<UnityEngine.Networking.UnityWebRequest> value);
            /*0x794b1b8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle get_ChainOperation();
            /*0x794b370*/ bool get_ShouldChainRequest();
            /*0x794b450*/ void OnSceneUnloaded(UnityEngine.SceneManagement.Scene scene);
            /*0x7943048*/ string get_StreamingAssetsSubFolder();
            /*0x7943118*/ string get_BuildPath();
            /*0x7943284*/ string get_PlayerBuildDataPath();
            /*0x79433c0*/ string get_RuntimePath();
            /*0x7943618*/ void Log(string msg);
            /*0x7943864*/ void LogFormat(string format, object[] args);
            /*0x7943568*/ void LogWarning(string msg);
            /*0x7943794*/ void LogWarningFormat(string format, object[] args);
            /*0x79435c0*/ void LogError(string msg);
            /*0x7943b88*/ void LogException(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op, System.Exception ex);
            /*0x7943cb4*/ void LogException(System.Exception ex);
            /*0x79437fc*/ void LogErrorFormat(string format, object[] args);
            /*0x7942c48*/ string ResolveInternalId(string id);
            /*0x794286c*/ System.Collections.Generic.IEnumerable<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> get_ResourceLocators();
            /*0x794a2f4*/ void AddResourceLocator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator loc, string localCatalogHash, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteCatalogLocation);
            /*0x794a488*/ void RemoveResourceLocator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator loc);
            /*0x794a5fc*/ void ClearResourceLocators();
            /*0x794b99c*/ bool GetResourceLocations(object key, System.Type type, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            /*0x794c160*/ bool GetResourceLocations(System.Collections.IEnumerable keys, System.Type type, UnityEngine.AddressableAssets.Addressables.MergeMode merge, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            /*0x794c674*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> InitializeAsync(string runtimeDataPath, string providerSuffix, bool autoReleaseHandle);
            /*0x7943d6c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> InitializeAsync();
            /*0x7943ebc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> InitializeAsync(bool autoReleaseHandle);
            /*0x3814a3c*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation catalogLocation);
            /*0x3814a3c*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string catalogLocation);
            /*0x3814b90*/ UnityEngine.ResourceManagement.ResourceLocations.ResourceLocationBase CreateCatalogLocationWithHashDependencies<T>(string catalogPath, string hashFilePath);
            /*0x794caf0*/ void QueueEditorUpdateIfNeeded();
            /*0x7944024*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalogAsync(string catalogPath, bool autoReleaseHandle, string providerSuffix);
            /*0x794cafc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> TrackHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle);
            /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> TrackHandle<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> handle);
            /*0x794cbb8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle TrackHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x794cbf4*/ void ClearTrackHandles();
            /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
            /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc);
            /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetWithChain<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key);
            /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync<TObject>(object key);
            /*0x794cc44*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, System.Type type);
            /*0x79443dc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsAsync(System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, System.Type type);
            /*0x794ce58*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key, System.Type type);
            /*0x7944634*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> LoadResourceLocationsAsync(object key, System.Type type);
            /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsWithChain<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsWithChain<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.IEnumerable keys, System.Action<TObject> callback, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool releaseDependenciesOnFailure);
            /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(System.Collections.IEnumerable keys, System.Action<TObject> callback, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool releaseDependenciesOnFailure);
            /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsWithChain<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> LoadAssetsAsync<TObject>(object key, System.Action<TObject> callback, bool releaseDependenciesOnFailure);
            /*0x794d054*/ void OnHandleDestroyed(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x794d0dc*/ void OnSceneHandleCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x794d1e4*/ void OnHandleCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x3910ae8*/ void Release<TObject>(TObject obj);
            /*0x3910ae8*/ void Release<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> handle);
            /*0x794d2a4*/ void Release(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
            /*0x794d2f0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key);
            /*0x794d440*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> ComputeCatalogSizeWithChain(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation catalogLoc);
            /*0x794d824*/ bool IsCatalogCached(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation catalogLoc, UnityEngine.Hash128 remoteHash);
            /*0x794dc54*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetRemoteCatalogHeaderSize(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation catalogLoc);
            /*0x794e0b0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.IEnumerable keys);
            /*0x7944a68*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(object key);
            /*0x7944cb8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> GetDownloadSizeAsync(System.Collections.IEnumerable keys);
            /*0x794e200*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsyncWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key, bool autoReleaseHandle);
            /*0x7945d30*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(object key, bool autoReleaseHandle);
            /*0x794ed8c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsyncWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle);
            /*0x7946044*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle);
            /*0x794ef48*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsyncWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool autoReleaseHandle);
            /*0x7946258*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadDependenciesAsync(System.Collections.IEnumerable keys, UnityEngine.AddressableAssets.Addressables.MergeMode mode, bool autoReleaseHandle);
            /*0x794f10c*/ bool ClearDependencyCacheForKey(object key);
            /*0x3910ae8*/ void AutoReleaseHandleOnTypelessCompletion<TObject>(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> handle);
            /*0x7946568*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(object key, bool autoReleaseHandle);
            /*0x7946864*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, bool autoReleaseHandle);
            /*0x7946e14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> ClearDependencyCacheAsync(System.Collections.IEnumerable keys, bool autoReleaseHandle);
            /*0x794f8c0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.Transform parent, bool instantiateInWorldSpace, bool trackHandle);
            /*0x7947e14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool trackHandle);
            /*0x7947f80*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.Transform parent, bool instantiateInWorldSpace, bool trackHandle);
            /*0x7948144*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent, bool trackHandle);
            /*0x794f950*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            /*0x79482c8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(object key, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            /*0x794fafc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            /*0x7947bac*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters, bool trackHandle);
            /*0x7944854*/ bool ReleaseInstance(UnityEngine.GameObject instance);
            /*0x794fca8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, object key, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority);
            /*0x794fe4c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle dep, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation key, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority);
            /*0x7948904*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(object key, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority, bool trackHandle);
            /*0x7948f40*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters, UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode, bool activateOnLoad, int priority, bool trackHandle);
            /*0x7949428*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.ResourceProviders.SceneInstance scene, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            /*0x7949744*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            /*0x7949b58*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnloadSceneAsync(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            /*0x794fff0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> CreateUnloadSceneWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            /*0x7950140*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> CreateUnloadSceneWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            /*0x7950290*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> InternalUnloadScene(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> handle, UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions, bool autoReleaseHandle);
            /*0x794c084*/ object EvaluateKey(object obj);
            /*0x7949cec*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> CheckForCatalogUpdates(bool autoReleaseHandle);
            /*0x795036c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> CheckForCatalogUpdatesWithChain(bool autoReleaseHandle);
            /*0x794779c*/ UnityEngine.AddressableAssets.ResourceLocatorInfo GetLocatorInfo(string c);
            /*0x7950b58*/ System.Collections.Generic.IEnumerable<string> get_CatalogsWithAvailableUpdates();
            /*0x7949f14*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> UpdateCatalogs(System.Collections.Generic.IEnumerable<string> catalogIds, bool autoReleaseHandle, bool autoCleanBundleCache);
            /*0x79514bc*/ bool Equals(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation x, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation y);
            /*0x795179c*/ int GetHashCode(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc);
            /*0x794a730*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> CleanBundleCache(System.Collections.Generic.IEnumerable<string> catalogIds, bool forceSingleThreading);
            /*0x7951a18*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> CleanBundleCache(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp, bool forceSingleThreading);
            /*0x7951bc8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> CleanBundleCacheWithChain(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp, bool forceSingleThreading);
            /*0x79518cc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> CleanBundleCacheWithChain(System.Collections.Generic.IEnumerable<string> catalogIds, bool forceSingleThreading);
            /*0x7951f10*/ void <TrackHandle>b__73_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> sceneHandle);
            /*0x7951fcc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> <GetRemoteCatalogHeaderSize>b__102_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.Networking.UnityWebRequest> getOp);

            class LoadResourceLocationKeyOp : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>>
            {
                /*0x98*/ object m_Keys;
                /*0xa0*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> m_locations;
                /*0xa8*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
                /*0xb0*/ System.Type m_ResourceType;

                /*0x794cfc4*/ LoadResourceLocationKeyOp();
                /*0x79520ec*/ string get_DebugName();
                /*0x794d00c*/ void Init(UnityEngine.AddressableAssets.AddressablesImpl aa, System.Type t, object keys);
                /*0x795210c*/ bool InvokeWaitForCompletion();
                /*0x7952180*/ void Execute();
            }

            class LoadResourceLocationKeysOp : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>>
            {
                /*0x98*/ System.Collections.IEnumerable m_Key;
                /*0xa0*/ UnityEngine.AddressableAssets.Addressables.MergeMode m_MergeMode;
                /*0xa8*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> m_locations;
                /*0xb0*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
                /*0xb8*/ System.Type m_ResourceType;

                /*0x794cdb8*/ LoadResourceLocationKeysOp();
                /*0x7952260*/ string get_DebugName();
                /*0x794ce00*/ void Init(UnityEngine.AddressableAssets.AddressablesImpl aa, System.Type t, System.Collections.IEnumerable key, UnityEngine.AddressableAssets.Addressables.MergeMode mergeMode);
                /*0x79522a0*/ void Execute();
                /*0x7952384*/ bool InvokeWaitForCompletion();
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.AddressableAssets.ResourceLocatorInfo, UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> <>9__59_0;
                static /*0x10*/ System.Func<UnityEngine.AddressableAssets.ResourceLocatorInfo, bool> <>9__143_0;
                static /*0x18*/ System.Func<UnityEngine.AddressableAssets.ResourceLocatorInfo, string> <>9__143_1;
                static /*0x20*/ System.Func<UnityEngine.AddressableAssets.ResourceLocatorInfo, string> <>9__147_0;

                static /*0x79523f8*/ <>c();
                /*0x7952460*/ <>c();
                /*0x7952468*/ UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator <get_ResourceLocators>b__59_0(UnityEngine.AddressableAssets.ResourceLocatorInfo l);
                /*0x7952480*/ bool <get_CatalogsWithAvailableUpdates>b__143_0(UnityEngine.AddressableAssets.ResourceLocatorInfo s);
                /*0x7952498*/ string <get_CatalogsWithAvailableUpdates>b__143_1(UnityEngine.AddressableAssets.ResourceLocatorInfo s);
                /*0x795253c*/ string <CleanBundleCache>b__147_0(UnityEngine.AddressableAssets.ResourceLocatorInfo s);
            }

            class <>c__115<TObject>
            {
                static /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl.<>c__115<TObject> <>9;
                static /*0x0*/ System.Action<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> <>9__115_0;

                static /*0x383e7a0*/ <>c__115();
                /*0x38159dc*/ <>c__115();
                void <AutoReleaseHandleOnTypelessCompletion>b__115_0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass100_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation catalogLoc;

                /*0x794d81c*/ <>c__DisplayClass100_0();
                /*0x79525e0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> <ComputeCatalogSizeWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass103_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.IEnumerable keys;

                /*0x794e1f8*/ <>c__DisplayClass103_0();
                /*0x79527dc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> <GetDownloadSizeWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass106_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;

                /*0x794e3b4*/ <>c__DisplayClass106_0();
                /*0x7952820*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass110_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations;

                /*0x794ef40*/ <>c__DisplayClass110_0();
                /*0x79528b0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass112_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.IEnumerable keys;
                /*0x20*/ UnityEngine.AddressableAssets.Addressables.MergeMode mode;

                /*0x794f104*/ <>c__DisplayClass112_0();
                /*0x7952940*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource>> <DownloadDependenciesAsyncWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass116_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;
                /*0x20*/ bool autoReleaseHandle;

                /*0x794f8a8*/ <>c__DisplayClass116_0();
                /*0x79529d4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass117_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations;
                /*0x20*/ bool autoReleaseHandle;

                /*0x794f8b0*/ <>c__DisplayClass117_0();
                /*0x7952a1c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass118_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.IEnumerable keys;
                /*0x20*/ bool autoReleaseHandle;

                /*0x794f8b8*/ <>c__DisplayClass118_0();
                /*0x7952a64*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> <ClearDependencyCacheAsync>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass123_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;
                /*0x20*/ UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters;

                /*0x794faf4*/ <>c__DisplayClass123_0();
                /*0x7952aac*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> <InstantiateWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass125_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location;
                /*0x20*/ UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters;

                /*0x794fca0*/ <>c__DisplayClass125_0();
                /*0x7952b18*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> <InstantiateWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass128_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;
                /*0x20*/ UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters;
                /*0x28*/ UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode;
                /*0x2c*/ bool activateOnLoad;
                /*0x30*/ int priority;

                /*0x794fe44*/ <>c__DisplayClass128_0();
                /*0x7952b84*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> <LoadSceneWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass129_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation key;
                /*0x20*/ UnityEngine.SceneManagement.LoadSceneParameters loadSceneParameters;
                /*0x28*/ UnityEngine.ResourceManagement.ResourceProviders.SceneReleaseMode releaseMode;
                /*0x2c*/ bool activateOnLoad;
                /*0x30*/ int priority;

                /*0x794ffe8*/ <>c__DisplayClass129_0();
                /*0x7952bd8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> <LoadSceneWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass135_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions;
                /*0x1c*/ bool autoReleaseHandle;

                /*0x795035c*/ <>c__DisplayClass135_0();
                /*0x7952c2c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> <CreateUnloadSceneWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle completedHandle);
            }

            class <>c__DisplayClass136_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ UnityEngine.SceneManagement.UnloadSceneOptions unloadOptions;
                /*0x1c*/ bool autoReleaseHandle;

                /*0x7950364*/ <>c__DisplayClass136_0();
                /*0x7952ce8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> <CreateUnloadSceneWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> completedHandle);
            }

            class <>c__DisplayClass140_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ bool autoReleaseHandle;

                /*0x7950b50*/ <>c__DisplayClass140_0();
                /*0x7952d54*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> <CheckForCatalogUpdatesWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass144_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ bool autoReleaseHandle;
                /*0x19*/ bool autoCleanBundleCache;

                /*0x7950d14*/ <>c__DisplayClass144_0();
                /*0x7952d98*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> <UpdateCatalogs>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> depOp);
            }

            class <>c__DisplayClass149_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp;
                /*0x30*/ bool forceSingleThreading;

                /*0x7951f00*/ <>c__DisplayClass149_0();
                /*0x7952df8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> <CleanBundleCacheWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass150_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.Generic.IEnumerable<string> catalogIds;
                /*0x20*/ bool forceSingleThreading;

                /*0x7951f08*/ <>c__DisplayClass150_0();
                /*0x7952e60*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> <CleanBundleCacheWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass61_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator loc;

                /*0x794b994*/ <>c__DisplayClass61_0();
                /*0x7952ea8*/ bool <RemoveResourceLocator>b__0(UnityEngine.AddressableAssets.ResourceLocatorInfo l);
            }

            class <>c__DisplayClass72_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ string catalogPath;
                /*0x20*/ bool autoReleaseHandle;
                /*0x28*/ string providerSuffix;

                /*0x794caf4*/ <>c__DisplayClass72_0();
                /*0x7952ecc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> <LoadContentCatalogAsync>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass78_0<TObject>
            {
                /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x0*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc;

                /*0x38159dc*/ <>c__DisplayClass78_0();
                /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> <LoadAssetWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass79_0<TObject>
            {
                /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x0*/ object key;

                /*0x38159dc*/ <>c__DisplayClass79_0();
                /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> <LoadAssetWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass83_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ System.Collections.IEnumerable keys;
                /*0x20*/ UnityEngine.AddressableAssets.Addressables.MergeMode mode;
                /*0x28*/ System.Type type;

                /*0x794cdb0*/ <>c__DisplayClass83_0();
                /*0x7952f18*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> <LoadResourceLocationsWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass85_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;
                /*0x20*/ System.Type type;

                /*0x794cfbc*/ <>c__DisplayClass85_0();
                /*0x7952f64*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> <LoadResourceLocationsWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass88_0<TObject>
            {
                /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x0*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations;
                /*0x0*/ System.Action<TObject> callback;
                /*0x0*/ bool releaseDependenciesOnFailure;

                /*0x38159dc*/ <>c__DisplayClass88_0();
                /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> <LoadAssetsWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass89_0<TObject>
            {
                /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x0*/ System.Collections.IEnumerable keys;
                /*0x0*/ System.Action<TObject> callback;
                /*0x0*/ UnityEngine.AddressableAssets.Addressables.MergeMode mode;
                /*0x0*/ bool releaseDependenciesOnFailure;

                /*0x38159dc*/ <>c__DisplayClass89_0();
                /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> <LoadAssetsWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }

            class <>c__DisplayClass91_0<TObject>
            {
                /*0x0*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x0*/ object key;
                /*0x0*/ System.Action<TObject> callback;
                /*0x0*/ bool releaseDependenciesOnFailure;

                /*0x38159dc*/ <>c__DisplayClass91_0();
                /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<TObject>> <LoadAssetsWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op2);
            }

            class <>c__DisplayClass99_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl <>4__this;
                /*0x18*/ object key;

                /*0x794d438*/ <>c__DisplayClass99_0();
                /*0x7952fa8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> <GetDownloadSizeWithChain>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
            }
        }

        class AssetLabelReference : UnityEngine.AddressableAssets.IKeyEvaluator
        {
            /*0x10*/ string m_LabelString;

            /*0x79530b8*/ AssetLabelReference();
            /*0x7952fec*/ string get_labelString();
            /*0x7952ff4*/ void set_labelString(string value);
            /*0x7952ffc*/ object get_RuntimeKey();
            /*0x7953038*/ bool RuntimeKeyIsValid();
            /*0x7953098*/ int GetHashCode();
        }

        class AssetReferenceT<TObject> : UnityEngine.AddressableAssets.AssetReference
        {
            /*0x3816710*/ AssetReferenceT(string guid);
            /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync();
            /*0x38141c4*/ bool ValidateAsset(UnityEngine.Object obj);
            /*0x38141c4*/ bool ValidateAsset(string mainAssetPath);
        }

        class AssetReferenceGameObject : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.GameObject>
        {
            /*0x79530c0*/ AssetReferenceGameObject(string guid);
        }

        class AssetReferenceTexture : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.Texture>
        {
            /*0x7953118*/ AssetReferenceTexture(string guid);
        }

        class AssetReferenceTexture2D : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.Texture2D>
        {
            /*0x7953170*/ AssetReferenceTexture2D(string guid);
        }

        class AssetReferenceTexture3D : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.Texture3D>
        {
            /*0x79531c8*/ AssetReferenceTexture3D(string guid);
        }

        class AssetReferenceSprite : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.Sprite>
        {
            /*0x7953220*/ AssetReferenceSprite(string guid);
            /*0x7953278*/ bool ValidateAsset(string path);
        }

        class AssetReferenceAtlasedSprite : UnityEngine.AddressableAssets.AssetReferenceT<UnityEngine.Sprite>
        {
            /*0x7953280*/ AssetReferenceAtlasedSprite(string guid);
            /*0x79532d8*/ bool ValidateAsset(UnityEngine.Object obj);
            /*0x7953350*/ bool ValidateAsset(string path);
        }

        class AssetReference : UnityEngine.AddressableAssets.IKeyEvaluator
        {
            /*0x10*/ string m_AssetGUID;
            /*0x18*/ string m_SubObjectName;
            /*0x20*/ string m_SubObjectType;
            /*0x28*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle m_Operation;

            static /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<T> CreateFailedOperation<T>();
            /*0x79534f4*/ AssetReference();
            /*0x795354c*/ AssetReference(string guid);
            /*0x7953358*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle get_OperationHandle();
            /*0x795336c*/ void set_OperationHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle value);
            /*0x795338c*/ object get_RuntimeKey();
            /*0x7953424*/ string get_AssetGUID();
            /*0x795342c*/ string get_SubObjectName();
            /*0x7953434*/ void set_SubObjectName(string value);
            /*0x795343c*/ System.Type get_SubObjectType();
            /*0x79534dc*/ bool IsValid();
            /*0x79534e8*/ bool get_IsDone();
            /*0x79535c4*/ UnityEngine.Object get_Asset();
            /*0x7953664*/ string ToString();
            /*0x3910ae8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<TObject> LoadAssetAsync<TObject>();
            /*0x79536d0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> LoadSceneAsync(UnityEngine.SceneManagement.LoadSceneMode loadMode, bool activateOnLoad, int priority);
            /*0x7953850*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> UnLoadScene();
            /*0x79538f4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
            /*0x79539f0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> InstantiateAsync(UnityEngine.Transform parent, bool instantiateInWorldSpace);
            /*0x7953aa0*/ bool RuntimeKeyIsValid();
            /*0x7953b20*/ void ReleaseAsset();
            /*0x7953bc0*/ void ReleaseInstance(UnityEngine.GameObject obj);
            /*0x7953c14*/ bool ValidateAsset(UnityEngine.Object obj);
            /*0x7953c1c*/ bool ValidateAsset(string path);
        }

        interface IKeyEvaluator
        {
            /*0x38148bc*/ object get_RuntimeKey();
            /*0x3813ffc*/ bool RuntimeKeyIsValid();
        }

        class CheckCatalogsOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<System.Collections.Generic.List<string>>
        {
            /*0x98*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
            /*0xa0*/ System.Collections.Generic.List<string> m_LocalHashes;
            /*0xa8*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocatorInfo> m_LocatorInfos;
            /*0xb0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> m_DepOp;

            static /*0x7953ed0*/ System.Collections.Generic.List<string> ProcessDependentOpResults(System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> results, System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocatorInfo> locatorInfos, System.Collections.Generic.List<string> localHashes, ref string errorString, ref bool success);
            /*0x79504a4*/ CheckCatalogsOperation(UnityEngine.AddressableAssets.AddressablesImpl aa);
            /*0x7950508*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<string>> Start(System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocatorInfo> locatorInfos);
            /*0x7953c24*/ bool InvokeWaitForCompletion();
            /*0x7953d58*/ void Destroy();
            /*0x7953da0*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> dependencies);
            /*0x795451c*/ void Execute();

            class <>c
            {
                static /*0x0*/ UnityEngine.AddressableAssets.CheckCatalogsOperation.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider, bool> <>9__5_0;

                static /*0x79545bc*/ <>c();
                /*0x7954624*/ <>c();
                /*0x795462c*/ bool <Start>b__5_0(UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider rp);
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

            /*0x7951d20*/ CleanBundleCacheOperation(UnityEngine.AddressableAssets.AddressablesImpl aa, bool forceSingleThreading);
            /*0x7951dd4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> Start(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> depOp);
            /*0x79546bc*/ void CompleteInternal(bool result, bool success, string errorMsg);
            /*0x795474c*/ bool InvokeWaitForCompletion();
            /*0x79549b0*/ void Destroy();
            /*0x7954a2c*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> dependencies);
            /*0x7954b5c*/ void Execute();
            /*0x7955930*/ void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime);
            /*0x795481c*/ void RemoveCacheEntries();
            /*0x795598c*/ void DetermineCacheDirsNotInUse(object data);
            /*0x7955508*/ void DetermineCacheDirsNotInUse(System.Collections.Generic.HashSet<string> cacheDirsInUse);
            /*0x7954d34*/ System.Collections.Generic.HashSet<string> GetCacheDirsInUse(System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> catalogOps);
        }

        class UpdateCatalogsOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>>
        {
            /*0x98*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
            /*0xa0*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocatorInfo> m_LocatorInfos;
            /*0xa8*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> m_DepOp;
            /*0xc0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> m_CleanCacheOp;
            /*0xd8*/ bool m_AutoCleanBundleCache;

            /*0x7950d1c*/ UpdateCatalogsOperation(UnityEngine.AddressableAssets.AddressablesImpl aa);
            /*0x7950d80*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> Start(System.Collections.Generic.IEnumerable<string> catalogIds, bool autoCleanBundleCache);
            /*0x7955aa8*/ bool InvokeWaitForCompletion();
            /*0x7955c54*/ void Destroy();
            /*0x7955c9c*/ void GetDependencies(System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> dependencies);
            /*0x7955dcc*/ void Execute();
            /*0x7956480*/ void OnCleanCacheCompleted(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> handle, System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> catalogs);

            class <>c
            {
                static /*0x0*/ UnityEngine.AddressableAssets.UpdateCatalogsOperation.<> <>9;
                static /*0x8*/ System.Func<UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider, bool> <>9__6_0;

                static /*0x7956580*/ <>c();
                /*0x79565e8*/ <>c();
                /*0x79565f0*/ bool <Start>b__6_0(UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider rp);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.AddressableAssets.UpdateCatalogsOperation <>4__this;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> catalogs;

                /*0x7956578*/ <>c__DisplayClass11_0();
                /*0x7956680*/ void <OnCleanCacheCompleted>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> obj);
            }
        }

        class DynamicResourceLocator : UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator
        {
            /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
            /*0x18*/ string m_AtlasSpriteProviderId;

            /*0x7956d18*/ DynamicResourceLocator(UnityEngine.AddressableAssets.AddressablesImpl addr);
            /*0x79567fc*/ string get_LocatorId();
            /*0x795683c*/ System.Collections.Generic.IEnumerable<object> get_Keys();
            /*0x7956880*/ string get_AtlasSpriteProviderId();
            /*0x7956cd4*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_AllLocations();
            /*0x7956d48*/ bool Locate(object key, System.Type type, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
            /*0x79572a4*/ void CreateDynamicLocations(System.Type type, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, string locName, string subKey, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation mainLoc);
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

            static /*0x7957b30*/ PlatformMappingService();
            static /*0x7957934*/ UnityEngine.AddressableAssets.AddressablesPlatform GetAddressablesPlatformInternal(UnityEngine.RuntimePlatform platform);
            static /*0x7957a08*/ string GetAddressablesPlatformPathInternal(UnityEngine.RuntimePlatform platform);
            static /*0x794b864*/ string GetPlatformPathSubFolder();
            /*0x7957b28*/ PlatformMappingService();
        }

        namespace Utility
        {
            class AssetReferenceUtilities
            {
                static /*0x7957d08*/ string FormatName(string name);
                /*0x7957d9c*/ AssetReferenceUtilities();
            }

            class SerializationUtilities
            {
                static /*0x7957da4*/ int ReadInt32FromByteArray(byte[] data, int offset);
                static /*0x7957e18*/ int WriteInt32ToByteArray(byte[] data, int val, int offset);
                static /*0x7957e9c*/ object ReadObjectFromByteArray(byte[] keyData, int dataIndex);
                static /*0x7958380*/ int WriteObjectToByteList(object obj, System.Collections.Generic.List<byte> buffer);

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

                /*0x7958d94*/ ContentCatalogProvider(UnityEngine.ResourceManagement.ResourceManager resourceManagerInstance);
                /*0x7958e28*/ void Release(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, object obj);
                /*0x7958f34*/ void Provide(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle providerInterface);

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

                    /*0x795908c*/ InternalOp();
                    /*0x7959094*/ void Start(UnityEngine.ResourceManagement.ResourceProviders.ProvideHandle providerInterface, bool disableCatalogUpdateOnStart, bool isLocalCatalogInBundle);
                    /*0x795a35c*/ bool WaitForCompletionCallback();
                    /*0x7958efc*/ void Release();
                    /*0x7959c2c*/ bool CanLoadCatalogFromBundle(string idToLoad, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                    /*0x7959cf0*/ void LoadCatalog(string idToLoad, bool loadCatalogFromLocalBundle);
                    /*0x795aa98*/ void CatalogLoadOpCompleteCallback(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> op);
                    /*0x795a530*/ string GetTransformedInternalId(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc);
                    /*0x7959230*/ string DetermineIdToLoad(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, System.Collections.Generic.IList<object> dependencyObjects, bool disableCatalogUpdateOnStart);
                    /*0x795ab2c*/ void OnCatalogLoaded(UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData ccd);
                    /*0x795b490*/ void <LoadCatalog>b__14_0(UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData ccd);

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

                        /*0x795a5ec*/ BundledCatalog(string bundlePath, int webRequestTimeout);
                        /*0x795a71c*/ void add_OnLoaded(System.Action<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> value);
                        /*0x795b4bc*/ void remove_OnLoaded(System.Action<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> value);
                        /*0x795b56c*/ bool get_OpInProgress();
                        /*0x795b574*/ bool get_OpIsSuccess();
                        /*0x795b594*/ void Finalize();
                        /*0x795b628*/ void Unload();
                        /*0x795a7cc*/ void LoadCatalogFromBundleAsync();
                        /*0x795b658*/ void WebRequestOperationCompleted(UnityEngine.AsyncOperation op);
                        /*0x795b890*/ void LoadTextAssetRequestComplete(UnityEngine.AsyncOperation op);
                        /*0x795a424*/ bool WaitForCompletion();
                        /*0x795ba28*/ void <LoadCatalogFromBundleAsync>b__19_1(UnityEngine.Networking.UnityWebRequestAsyncOperation asyncOp);
                        /*0x795bad0*/ void <LoadCatalogFromBundleAsync>b__19_0(UnityEngine.AsyncOperation loadOp);
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

                /*0x795bd2c*/ ContentCatalogDataEntry(System.Type type, string internalId, string provider, System.Collections.Generic.IEnumerable<object> keys, System.Collections.Generic.IEnumerable<object> dependencies, object extraData);
                /*0x795bccc*/ string get_InternalId();
                /*0x795bcd4*/ void set_InternalId(string value);
                /*0x795bcdc*/ string get_Provider();
                /*0x795bce4*/ void set_Provider(string value);
                /*0x795bcec*/ System.Collections.Generic.List<object> get_Keys();
                /*0x795bcf4*/ void set_Keys(System.Collections.Generic.List<object> value);
                /*0x795bcfc*/ System.Collections.Generic.List<object> get_Dependencies();
                /*0x795bd04*/ void set_Dependencies(System.Collections.Generic.List<object> value);
                /*0x795bd0c*/ object get_Data();
                /*0x795bd14*/ void set_Data(object value);
                /*0x795bd1c*/ System.Type get_ResourceType();
                /*0x795bd24*/ void set_ResourceType(System.Type value);
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

                static /*0x795c458*/ ContentCatalogData();
                static /*0x795c304*/ UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData LoadFromFile(string path, int cacheSize);
                /*0x795bf14*/ ContentCatalogData(string id);
                /*0x795bfb0*/ ContentCatalogData();
                /*0x795c060*/ ContentCatalogData(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader);
                /*0x795be7c*/ string get_BuildResultHash();
                /*0x795be84*/ void set_BuildResultHash(string value);
                /*0x795be8c*/ string get_ProviderId();
                /*0x795be94*/ void set_ProviderId(string value);
                /*0x795be9c*/ UnityEngine.ResourceManagement.Util.ObjectInitializationData get_InstanceProviderData();
                /*0x795beb0*/ void set_InstanceProviderData(UnityEngine.ResourceManagement.Util.ObjectInitializationData value);
                /*0x795bed0*/ UnityEngine.ResourceManagement.Util.ObjectInitializationData get_SceneProviderData();
                /*0x795bee4*/ void set_SceneProviderData(UnityEngine.ResourceManagement.Util.ObjectInitializationData value);
                /*0x795bf04*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.ObjectInitializationData> get_ResourceProviderData();
                /*0x795bf0c*/ void set_ResourceProviderData(System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.ObjectInitializationData> value);
                /*0x795a508*/ void CleanData();
                /*0x795c038*/ void CopyToFile(string path);
                /*0x795b474*/ byte[] GetBytes();
                /*0x7955a10*/ UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator CreateCustomLocator(string overrideId, string providerSuffix, int locatorCacheSize);

                class Serializer : UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData>, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter
                {
                    /*0x795c450*/ Serializer();
                    /*0x795c4cc*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter> get_Dependencies();
                    /*0x795c658*/ object Deserialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader, System.Type t, uint offset);
                    /*0x795c928*/ uint Serialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Writer writer, object val);

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ uint[] locationIds;
                        /*0x18*/ System.Func<int, uint> <>9__0;

                        /*0x795d3e8*/ <>c__DisplayClass3_0();
                        /*0x795d3f8*/ uint <Serialize>b__0(int i);
                    }
                }

                class ResourceLocator : UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator
                {
                    /*0x10*/ UnityEngine.ResourceManagement.Util.LRUCache<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData.ResourceLocator.CacheKey, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> m_Cache;
                    /*0x28*/ System.Collections.Generic.Dictionary<object, uint> keyData;
                    /*0x30*/ UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader;
                    /*0x38*/ string <LocatorId>k__BackingField;
                    /*0x40*/ string providerSuffix;

                    /*0x795c0fc*/ ResourceLocator(string id, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader, int cacheLimit, string providerSuffix);
                    /*0x795d428*/ string get_LocatorId();
                    /*0x795d430*/ void set_LocatorId(string value);
                    /*0x795d438*/ System.Collections.Generic.IEnumerable<object> get_Keys();
                    /*0x795d488*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_AllLocations();
                    /*0x795d94c*/ bool Locate(object key, System.Type type, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);

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

                        /*0x795d3f0*/ ContentCatalogDataEntrySerializationContext();
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

                        /*0x795decc*/ ResourceLocation(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader r, uint id);
                        /*0x795e0b0*/ string ToString();
                        /*0x795e0b8*/ void set_PrimaryKey(string value);
                        /*0x795e0c0*/ string get_PrimaryKey();
                        /*0x795e0c8*/ void set_InternalId(string value);
                        /*0x795e0d0*/ string get_InternalId();
                        /*0x795e0d8*/ void set_Data(object value);
                        /*0x795e0e0*/ object get_Data();
                        /*0x795e0e8*/ void set_ProviderId(string value);
                        /*0x795e0f0*/ string get_ProviderId();
                        /*0x795e0f8*/ void set_Dependencies(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> value);
                        /*0x795e100*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_Dependencies();
                        /*0x795e108*/ void set_DependencyHashCode(int value);
                        /*0x795e110*/ int get_DependencyHashCode();
                        /*0x795e118*/ bool get_HasDependencies();
                        /*0x795e128*/ void set_ResourceType(System.Type value);
                        /*0x795e130*/ System.Type get_ResourceType();
                        /*0x795e138*/ int Hash(System.Type t);

                        class Serializer : UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData.ResourceLocator.ResourceLocation>, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData.ResourceLocator.ContentCatalogDataEntrySerializationContext>
                        {
                            /*0x795c650*/ Serializer();
                            /*0x795e1a0*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter> get_Dependencies();
                            /*0x795e1a8*/ object Deserialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader, System.Type t, uint offset);
                            /*0x795e210*/ uint Serialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Writer writer, object val);

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

                        /*0x795de14*/ CacheKey(object o, System.Type t);
                        /*0x795e81c*/ bool Equals(UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData.ResourceLocator.CacheKey other);
                        /*0x795e8ec*/ int GetHashCode();
                    }
                }

                class AssetBundleRequestOptionsSerializationAdapter : UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter<UnityEngine.ResourceManagement.ResourceProviders.AssetBundleRequestOptions>, UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter
                {
                    /*0x795c648*/ AssetBundleRequestOptionsSerializationAdapter();
                    /*0x795e8f4*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.ISerializationAdapter> get_Dependencies();
                    /*0x795e8fc*/ object Deserialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Reader reader, System.Type type, uint offset);
                    /*0x795eb40*/ uint Serialize(UnityEngine.ResourceManagement.Util.BinaryStorageBuffer.Writer writer, object obj);

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

                            /*0x795eb04*/ UnityEngine.ResourceManagement.ResourceProviders.AssetLoadMode get_assetLoadMode();
                            /*0x795ed28*/ void set_assetLoadMode(UnityEngine.ResourceManagement.ResourceProviders.AssetLoadMode value);
                            /*0x795eb10*/ bool get_chunkedTransfer();
                            /*0x795ed3c*/ void set_chunkedTransfer(bool value);
                            /*0x795eb28*/ bool get_useCrcForCachedBundle();
                            /*0x795ed7c*/ void set_useCrcForCachedBundle(bool value);
                            /*0x795eb1c*/ bool get_useUnityWebRequestForLocalBundles();
                            /*0x795ed9c*/ void set_useUnityWebRequestForLocalBundles(bool value);
                            /*0x795eb34*/ bool get_clearOtherCachedVersionsWhenLoaded();
                            /*0x795ed5c*/ void set_clearOtherCachedVersionsWhenLoaded(bool value);
                        }
                    }
                }
            }

            interface IResourceLocator
            {
                /*0x38148bc*/ string get_LocatorId();
                /*0x38148bc*/ System.Collections.Generic.IEnumerable<object> get_Keys();
                /*0x38148bc*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_AllLocations();
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

                /*0x795eef0*/ ResourceLocationData(string[] keys, string id, System.Type provider, System.Type t, string[] dependencies);
                /*0x795edbc*/ string[] get_Keys();
                /*0x795edc4*/ string get_InternalId();
                /*0x795edcc*/ string get_Provider();
                /*0x795edd4*/ string[] get_Dependencies();
                /*0x795eddc*/ System.Type get_ResourceType();
                /*0x795ede8*/ object get_Data();
                /*0x795ee3c*/ void set_Data(object value);
            }

            class ResourceLocationMap : UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator
            {
                /*0x10*/ string <LocatorId>k__BackingField;
                /*0x18*/ System.Collections.Generic.Dictionary<object, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> locations;

                /*0x795f058*/ ResourceLocationMap(string id, int capacity);
                /*0x795f120*/ ResourceLocationMap(string id, System.Collections.Generic.IList<UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationData> locations);
                /*0x795f110*/ string get_LocatorId();
                /*0x795f118*/ void set_LocatorId(string value);
                /*0x795fc50*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_AllLocations();
                /*0x795fd4c*/ System.Collections.Generic.Dictionary<object, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> get_Locations();
                /*0x795fd54*/ System.Collections.Generic.IEnumerable<object> get_Keys();
                /*0x795fda4*/ bool Locate(object key, System.Type type, ref System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
                /*0x795faf0*/ void Add(object key, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x7960638*/ void Add(object key, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);

                class <>c
                {
                    static /*0x0*/ UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationMap.<> <>9;
                    static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<object, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>>, System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> <>9__8_0;

                    static /*0x79606a0*/ <>c();
                    /*0x7960708*/ <>c();
                    /*0x7960710*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> <get_AllLocations>b__8_0(System.Collections.Generic.KeyValuePair<object, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> k);
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

                static /*0x7961294*/ AddressablesRuntimeProperties();
                static /*0x796074c*/ System.Reflection.Assembly[] GetAssemblies();
                static /*0x796076c*/ int GetCachedValueCount();
                static /*0x79607e4*/ void SetPropertyValue(string name, string val);
                static /*0x7960874*/ void ClearCachedPropertyValues();
                static /*0x79608ec*/ string EvaluateProperty(string name);
                static /*0x794b8e8*/ string EvaluateString(string input);
                static /*0x7960d0c*/ string EvaluateString(string inputString, char startDelimiter, char endDelimiter, System.Func<string, string> varFunc);
            }

            class CacheInitialization : UnityEngine.ResourceManagement.Util.IInitializableObject
            {
                static /*0x796172c*/ string get_RootPath();
                /*0x79617a8*/ CacheInitialization();
                /*0x79613f0*/ bool Initialize(string id, string dataStr);
                /*0x7961544*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> InitializeAsync(UnityEngine.ResourceManagement.ResourceManager rm, string id, string data);

                class CacheInitOp : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<bool>, UnityEngine.ResourceManagement.IUpdateReceiver
                {
                    /*0x98*/ System.Func<bool> m_Callback;
                    /*0xa0*/ bool m_UpdateRequired;

                    /*0x79616dc*/ CacheInitOp();
                    /*0x79617b0*/ void Init(System.Func<bool> callback);
                    /*0x79617b8*/ bool InvokeWaitForCompletion();
                    /*0x796184c*/ void Update(float unscaledDeltaTime);
                    /*0x7961908*/ void Execute();
                }

                class <>c__DisplayClass1_0
                {
                    /*0x10*/ UnityEngine.AddressableAssets.Initialization.CacheInitialization <>4__this;
                    /*0x18*/ string id;
                    /*0x20*/ string data;

                    /*0x79616d4*/ <>c__DisplayClass1_0();
                    /*0x79619a0*/ bool <InitializeAsync>b__0();
                }
            }

            class CacheInitializationData
            {
                /*0x10*/ bool m_CompressionEnabled;
                /*0x18*/ string m_CacheDirectoryOverride;
                /*0x20*/ bool m_LimitCacheSize;
                /*0x28*/ long m_MaximumCacheSize;

                /*0x7961a0c*/ CacheInitializationData();
                /*0x79619c4*/ bool get_CompressionEnabled();
                /*0x79619cc*/ void set_CompressionEnabled(bool value);
                /*0x79619d8*/ string get_CacheDirectoryOverride();
                /*0x79619e0*/ void set_CacheDirectoryOverride(string value);
                /*0x79619e8*/ bool get_LimitCacheSize();
                /*0x79619f0*/ void set_LimitCacheSize(bool value);
                /*0x79619fc*/ long get_MaximumCacheSize();
                /*0x7961a04*/ void set_MaximumCacheSize(long value);
            }

            class InitializationOperation : UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationBase<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>
            {
                /*0x98*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.Initialization.ResourceManagerRuntimeData> m_rtdOp;
                /*0xb0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> m_loadCatalogOp;
                /*0xc8*/ string m_ProviderSuffix;
                /*0xd0*/ UnityEngine.AddressableAssets.AddressablesImpl m_Addressables;
                /*0xd8*/ UnityEngine.ResourceManagement.AsyncOperations.InitalizationObjectsOperation m_InitGroupOps;

                static /*0x7961b98*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> CreateInitializationOperation(UnityEngine.AddressableAssets.AddressablesImpl aa, string playerSettingsLocation, string providerSuffix);
                static /*0x7963268*/ void LoadProvider(UnityEngine.AddressableAssets.AddressablesImpl addressables, UnityEngine.ResourceManagement.Util.ObjectInitializationData providerData, string providerSuffix);
                static /*0x79636f4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> OnCatalogDataLoaded(UnityEngine.AddressableAssets.AddressablesImpl addressables, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> op, string providerSuffix, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteHashLocation);
                static /*0x7963c94*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalog(UnityEngine.AddressableAssets.AddressablesImpl addressables, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc, string providerSuffix, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteHashLocation);
                /*0x7961a74*/ InitializationOperation(UnityEngine.AddressableAssets.AddressablesImpl aa);
                /*0x7961ad8*/ float get_Progress();
                /*0x7961b58*/ string get_DebugName();
                /*0x7962144*/ bool InvokeWaitForCompletion();
                /*0x7962310*/ void Execute();
                /*0x796437c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalog(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation loc, string providerSuffix, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteHashLocation);
                /*0x796302c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> LoadContentCatalogInternal(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> catalogs, int index, UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationMap locMap, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteHashLocation);
                /*0x79643b8*/ void LoadOpComplete(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> op, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> catalogs, UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationMap locMap, int index, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteHashLocation);

                class <>c
                {
                    static /*0x0*/ UnityEngine.AddressableAssets.Initialization.InitializationOperation.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider, bool> <>9__12_0;

                    static /*0x796474c*/ <>c();
                    /*0x79647b4*/ <>c();
                    /*0x79647bc*/ bool <Execute>b__12_0(UnityEngine.ResourceManagement.ResourceProviders.IResourceProvider rp);
                }

                class <>c__DisplayClass15_0
                {
                    /*0x10*/ UnityEngine.AddressableAssets.AddressablesImpl addressables;
                    /*0x18*/ string providerSuffix;
                    /*0x20*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteHashLocation;

                    /*0x7964374*/ <>c__DisplayClass15_0();
                    /*0x796484c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> <LoadContentCatalog>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.ContentCatalogData> res);
                }

                class <>c__DisplayClass17_0
                {
                    /*0x10*/ UnityEngine.AddressableAssets.Initialization.InitializationOperation <>4__this;
                    /*0x18*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> catalogs;
                    /*0x20*/ UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationMap locMap;
                    /*0x28*/ int index;
                    /*0x30*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation remoteHashLocation;

                    /*0x79643b0*/ <>c__DisplayClass17_0();
                    /*0x796489c*/ void <LoadContentCatalogInternal>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> op);
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

                /*0x79649c4*/ ResourceManagerRuntimeData();
                /*0x79648f4*/ string get_BuildTarget();
                /*0x79648fc*/ void set_BuildTarget(string value);
                /*0x7964904*/ string get_SettingsHash();
                /*0x796490c*/ void set_SettingsHash(string value);
                /*0x7964914*/ System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.ResourceLocationData> get_CatalogLocations();
                /*0x796491c*/ bool get_LogResourceManagerExceptions();
                /*0x7964924*/ void set_LogResourceManagerExceptions(bool value);
                /*0x7964930*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.Util.ObjectInitializationData> get_InitializationObjects();
                /*0x7964938*/ bool get_DisableCatalogUpdateOnStartup();
                /*0x7964940*/ void set_DisableCatalogUpdateOnStartup(bool value);
                /*0x796494c*/ bool get_IsLocalCatalogInBundle();
                /*0x7964954*/ void set_IsLocalCatalogInBundle(bool value);
                /*0x7963020*/ System.Type get_CertificateHandlerType();
                /*0x7964960*/ void set_CertificateHandlerType(System.Type value);
                /*0x796496c*/ string get_AddressablesVersion();
                /*0x7964974*/ void set_AddressablesVersion(string value);
                /*0x796497c*/ int get_MaxConcurrentWebRequests();
                /*0x7964984*/ void set_MaxConcurrentWebRequests(int value);
                /*0x79649a0*/ int get_CatalogRequestsTimeout();
                /*0x79649a8*/ void set_CatalogRequestsTimeout(int value);
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
