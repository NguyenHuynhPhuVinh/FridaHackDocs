class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x2bc61b0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x2bc62a4*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace Packages
{
    namespace EA
    {
        namespace PopCap
        {
            namespace AddressablesAssets
            {
                namespace Runtime
                {
                    class ActiveAssetRequest : Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest, Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                        /*0x10*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IActiveRequestProgressHandler _progressHandler;
                        /*0x18*/ bool <Canceled>k__BackingField;
                        /*0x1c*/ UnityEngine.ResourceManagement.EA.ResourcePriority <Priority>k__BackingField;
                        /*0x20*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> <AsyncOpHandles>k__BackingField;
                        /*0x28*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest <AssetRequest>k__BackingField;
                        /*0x30*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest.AssetRequestStatus <Status>k__BackingField;
                        /*0x38*/ long _downloadSizeBytes;
                        /*0x40*/ Packages.EA.PopCap.AddressablesAssets.Runtime.FailedHandleData <MostRecentlyFailedHandle>k__BackingField;
                        /*0x58*/ int <NumRequestsToComplete>k__BackingField;
                        /*0x5c*/ int <CompletedRequestsCount>k__BackingField;

                        /*0x2bc62ac*/ ActiveAssetRequest(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest request, System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> asyncOperationHandles);
                        /*0x2bc6448*/ ActiveAssetRequest(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest request, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
                        /*0x1f2ffc8*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequestType get_RequestType();
                        /*0x2bc656c*/ float get_NormalizedRequestProgress();
                        /*0x2bc667c*/ bool get_Canceled();
                        /*0x2bc6684*/ void set_Canceled(bool value);
                        /*0x2bc668c*/ uint get_Id();
                        /*0x2bc66a4*/ UnityEngine.ResourceManagement.EA.ResourcePriority get_Priority();
                        /*0x2bc66ac*/ void set_Priority(UnityEngine.ResourceManagement.EA.ResourcePriority value);
                        /*0x2bc66b4*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> get_AsyncOpHandles();
                        /*0x2bc66bc*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest get_AssetRequest();
                        /*0x2bc66c4*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_RequestedLocations();
                        /*0x2bc66dc*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest.AssetRequestStatus get_Status();
                        /*0x2bc66e4*/ void set_Status(Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest.AssetRequestStatus value);
                        /*0x2bc66ec*/ long get_DownloadSizeBytes();
                        /*0x2bc6768*/ Packages.EA.PopCap.AddressablesAssets.Runtime.FailedHandleData get_MostRecentlyFailedHandle();
                        /*0x2bc677c*/ void set_MostRecentlyFailedHandle(Packages.EA.PopCap.AddressablesAssets.Runtime.FailedHandleData value);
                        /*0x2bc67a0*/ int get_NumRequestsToComplete();
                        /*0x2bc67a8*/ int get_CompletedRequestsCount();
                        /*0x2bc67b0*/ void set_CompletedRequestsCount(int value);
                        /*0x2bc67b8*/ bool get_AreAllRequestsComplete();
                        /*0x2bc67c8*/ void RegisterForProgressChangesListener(Packages.EA.PopCap.AddressablesAssets.Runtime.IActiveRequestProgressHandler progressHandler);
                        /*0x2bc67d0*/ void Cancel();
                        /*0x2bc6348*/ void AssignAsyncOpCallbacks();
                        /*0x2bc67dc*/ void UpdateProgressForCachedOperations();
                        /*0x2bc68b8*/ void FinalizeRequest();
                        /*0x2bc6970*/ void FailRequest(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                        /*0x2bc6c40*/ void OnRequestCannotBeRecovered();
                        /*0x2bc6d70*/ void OnLoadComplete(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                        /*0x2bc6570*/ float CalculateNormalizedRequestProgress();
                        /*0x2bc6b28*/ void ReleaseAllOps();
                        /*0x2bc6e94*/ void NotifyProgress();
                        /*0x2bc6a78*/ void NotifyError();
                        /*0x2bc68c4*/ void NotifyCompletion();
                        /*0x2bc7080*/ void OnSoftReset();

                        enum AssetRequestStatus
                        {
                            Processing = 0,
                            Complete = 1,
                            Failed = 2,
                        }
                    }

                    class ActiveAssetRequestProcessor : Packages.EA.PopCap.AddressablesAssets.Runtime.IActiveAssetRequestProcessor, Packages.EA.PopCap.AddressablesAssets.Runtime.IObservable, Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener, Packages.EA.PopCap.AddressablesAssets.Runtime.IActiveRequestProgressHandler
                    {
                        /*0x10*/ System.Collections.Generic.Dictionary<uint, Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest> _activeAssetRequests;
                        /*0x18*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemCentralObserver _assetSystemCentralObserver;

                        /*0x2bc78d8*/ ActiveAssetRequestProcessor();
                        /*0x2bc7084*/ void Process(Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest request);
                        /*0x2bc7194*/ void Cancel(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest request);
                        /*0x2bc7220*/ void BroadcastProgress();
                        /*0x2bc73e4*/ void OnProgress(Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest request);
                        /*0x2bc7498*/ void OnError(Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest request);
                        /*0x2bc758c*/ void OnComplete(Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest request);
                        /*0x2bc7680*/ void AttachObserver(Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemCentralObserver obs);
                        /*0x2bc7688*/ void DetachObserver(Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemCentralObserver obs);
                        /*0x2bc7694*/ void OnSoftReset();
                    }

                    class ActiveAssetRequestUtils
                    {
                        static /*0x2bc7960*/ void HideResultIfGameObject(ref UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                        static /*0x2bc7a50*/ void ShowResultIfGameObject(ref UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                    }

                    class ActiveDownloadAssetRequest : Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest
                    {
                        /*0x60*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadCallbackRouter _progressNotifier;

                        /*0x2bc7b30*/ ActiveDownloadAssetRequest(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest request, System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> asyncOperationHandles);
                        /*0x2bc7b34*/ ActiveDownloadAssetRequest(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest request, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadCallbackRouter progressNotifier);
                        /*0x2bc7c40*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequestType get_RequestType();
                        /*0x2bc7c48*/ void FailRequest(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                        /*0x2bc7dd0*/ void FinalizeRequest();
                        /*0x2bc7f34*/ void ReleaseFinishedHandles();
                        /*0x2bc8124*/ void ProgressUpdater();
                    }

                    class ActiveGetAssetRequest : Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest
                    {
                        /*0x2bc8128*/ ActiveGetAssetRequest(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest request, System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> asyncOperationHandles);
                        /*0x2bc812c*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequestType get_RequestType();
                        /*0x2bc8134*/ void FinalizeRequest();
                        /*0x2bc81d0*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollection GenerateResourceCollection();
                        /*0x2bc8790*/ void OnLoadComplete(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                    }

                    class ActivePreloadAssetRequest : Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest
                    {
                        /*0x2bc87ec*/ ActivePreloadAssetRequest(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest request, System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> asyncOperationHandles);
                        /*0x2bc87f0*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequestType get_RequestType();
                        /*0x2bc87f8*/ void FinalizeRequest();
                        /*0x2bc8970*/ void OnLoadComplete(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                        /*0x2bc89cc*/ void FailRequest(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                    }

                    class AddressablesInternalHooks
                    {
                        static /*0x2bc8ad8*/ void ClearCachedPropertyValues();
                    }

                    class AssetCacheController : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetCacheController, Packages.EA.PopCap.AddressablesAssets.Runtime.IWithdrawableAssetCache, Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                        static int DefaultBucketId = 0;
                        /*0x10*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetCacheStore<int> _assetCacheStore;

                        /*0x2bc8b28*/ AssetCacheController();
                        /*0x2bc8c20*/ void WithdrawHandles(System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> remainingLocations, System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> listToAddHandlesTo);
                        /*0x2bc8c88*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle WithdrawHandle(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation requestedAsset, ref bool isFound);
                        /*0x2bc8d14*/ void CacheHandle(Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceHandle handle);
                        /*0x2bc8dfc*/ void CleanupCurrentStateCache();
                        /*0x2bc8e5c*/ void ManualLowMemoryCall();
                        /*0x2bc8eac*/ void OnSoftReset();
                    }

                    class AssetCacheStore<T> : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetCacheStore, Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                        /*0x0*/ System.Collections.Generic.Dictionary<T, System.Collections.Generic.Dictionary<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, System.Collections.Generic.LinkedList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>>> _gameStateCachedResources;
                        /*0x0*/ bool _warnAboutUnusedHandles;
                        /*0x0*/ string _cacheTypeName;
                        /*0x0*/ System.Collections.Generic.List<T> <ActiveStates>k__BackingField;

                        /*0x1f30ac0*/ AssetCacheStore(bool warnAboutUnusedHandles, string cacheTypeName);
                        /*0x1f30214*/ System.Collections.Generic.List<T> get_ActiveStates();
                        /*0x1ffc854*/ void RegisterAssetResource(T id, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
                        /*0x1ffc854*/ void RegisterAssetResources(T id, System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> handles);
                        /*0x1f310fc*/ void AddResourceToList(System.Collections.Generic.Dictionary<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, System.Collections.Generic.LinkedList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle>> cacheMapping, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, ref UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
                        UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle WithdrawHandleForActiveState(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation requestedAssetLocation, ref bool isFound);
                        /*0x1f30ff0*/ void WithdrawHandlesForActiveState(System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> remainingRequests, System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> listToAddHandlesTo);
                        /*0x1f30214*/ System.Collections.Generic.LinkedList<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> FetchStoreContents();
                        /*0x1ffc854*/ void CleanupExistStateCache(T exitState, bool suppressWarning);
                        /*0x1f309e4*/ void ClearCache();
                        /*0x1f309e4*/ void OnLowMemoryEventHandler();
                        /*0x1f309e4*/ void OnSoftReset();
                    }

                    interface ICatalogVersionUpdateCallbackListener
                    {
                        /*0x1f309e4*/ void OnNoCatalogVersionUpdateNeeded();
                        /*0x1f309e4*/ void OnCatalogVersionUpdateComplete();
                        /*0x1f30d9c*/ void OnCatalogVersionUpdateProgress(long downloadedBytes, long totalBytes);
                        /*0x1f30ebc*/ void OnCatalogVersionUpdateFailed(string errorMsg);
                        void RequestBuiltinAssetsUpdatePermission(long bytes, System.Action callback);
                        /*0x1f30d60*/ void OnBuiltinAssetsUpdateStarted(long totalBytes);
                    }

                    struct CatalogVersionUpdateArgs
                    {
                        /*0x10*/ string Hash;
                        /*0x18*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ICatalogVersionUpdateCallbackListener Listener;
                        /*0x20*/ bool IsDebug;

                        /*0x2bc8efc*/ CatalogVersionUpdateArgs(string hash, Packages.EA.PopCap.AddressablesAssets.Runtime.ICatalogVersionUpdateCallbackListener listener, bool isDebug);
                    }

                    class AssetCatalogVersionUpdateModule : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetCatalogVersionUpdateModule, Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemInitializable
                    {
                        /*0x10*/ string _packageInBuildTag;
                        /*0x18*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetCatalogVersionUpdateModule.InternalOp _internalOp;

                        /*0x2bc9234*/ AssetCatalogVersionUpdateModule();
                        /*0x2bc8f38*/ void Initialize(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetManagementContext context);
                        /*0x2bc9044*/ void BroadcastProgress();
                        /*0x2bc9138*/ void CheckForAssetCatalogVersionUpdate(ref Packages.EA.PopCap.AddressablesAssets.Runtime.CatalogVersionUpdateArgs updateArgs);
                        /*0x2bc923c*/ void Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetCatalogVersionUpdateModule.CheckForAssetCatalogVersionUpdate(ref Packages.EA.PopCap.AddressablesAssets.Runtime.CatalogVersionUpdateArgs updateArgs);

                        class InternalOp
                        {
                            /*0x10*/ string _packageInBuildTag;
                            /*0x18*/ Packages.EA.PopCap.AddressablesAssets.Runtime.CatalogVersionUpdateArgs _updateArgs;
                            /*0x30*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IContentUpdate _contentUpdate;
                            /*0x38*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> _asyncHandleCatalogHashCheck;
                            /*0x50*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> _asyncHandlePrepareForContentUpdate;
                            /*0x68*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle _asyncHandleDownloadRequiredPackagedAssets;
                            /*0x80*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle _asyncHandleFinalizeContentUpdate;

                            /*0x2bc8fbc*/ InternalOp(string packageInBuildTag);
                            /*0x2bc9248*/ void CheckForAssetCatalogVersionUpdate(ref Packages.EA.PopCap.AddressablesAssets.Runtime.CatalogVersionUpdateArgs updateArgs);
                            /*0x2bc9058*/ void BroadcastProgress();
                            /*0x2bc93b4*/ void HasCatalogHashInstalled(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> result);
                            /*0x2bc9608*/ void BeginUpdateCatalogContent(string hash);
                            /*0x2bc9758*/ void RetrievedCatalogComplete(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> result);
                            /*0x2bc9aa4*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> GetPackagedInBuildBundles(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator);
                            /*0x2bc9ba0*/ void DownloadRequiredPackagedAssets(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> resourceLocations, long downloadSize);
                            /*0x2bc9e60*/ void FinalizeCatalogUpdate(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle downloadHandle);
                            /*0x2bca07c*/ void CallCatalogVersionUpdateComplete(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);

                            class <>c__DisplayClass12_0
                            {
                                /*0x10*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetCatalogVersionUpdateModule.InternalOp <>4__this;
                                /*0x18*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> packagedInBuildBundles;
                                /*0x20*/ long downloadSize;

                                /*0x2bc9a9c*/ <>c__DisplayClass12_0();
                                /*0x2bca17c*/ void <RetrievedCatalogComplete>b__0();
                            }
                        }

                        class DebugInternalOp : Packages.EA.PopCap.AddressablesAssets.Runtime.AssetCatalogVersionUpdateModule.InternalOp
                        {
                            /*0x2bc91bc*/ DebugInternalOp(string packageInBuildTag);
                            /*0x2bca1a0*/ void CheckForAssetCatalogVersionUpdate(ref Packages.EA.PopCap.AddressablesAssets.Runtime.CatalogVersionUpdateArgs updateArgs);
                        }
                    }

                    class AssetDownloadCallbackRouter
                    {
                        /*0x10*/ System.Action<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource> <AssetSystemProgressCallback>k__BackingField;
                        /*0x18*/ System.Action <ClientProgressCallback>k__BackingField;

                        /*0x2bca1f8*/ AssetDownloadCallbackRouter();
                        /*0x2bca1e0*/ System.Action<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource> get_AssetSystemProgressCallback();
                        /*0x2bca1e8*/ System.Action get_ClientProgressCallback();
                        /*0x2bca1f0*/ void set_ClientProgressCallback(System.Action value);
                        /*0x2bca2e0*/ void CallbackReceiver(UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource resource);
                    }

                    class AssetDownloader : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetDownloader
                    {
                        /*0x2bca47c*/ AssetDownloader();
                        /*0x2bca2fc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadAssetsAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource> progressCallback);
                        /*0x2bca3c0*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadAssetAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                    }

                    class AssetDownloadRouter : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetDownloadRouter
                    {
                        /*0x10*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetDownloader _assetDownloader;

                        /*0x2bca5c8*/ AssetDownloadRouter();
                        /*0x2bca484*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest DownloadAssetsAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest request);
                    }

                    class AssetLoader : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetLoader
                    {
                        /*0x2bcab20*/ AssetLoader();
                        /*0x2bca634*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle InstantiateAssets(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters parameters);
                        /*0x2bca728*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle LoadAssets(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation, System.Action<UnityEngine.Object> individualCallback);
                    }

                    class AssetLoaderProvider : Packages.EA.PopCap.AddressablesAssets.Runtime.IProvider
                    {
                        /*0x10*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetLoader <Loader>k__BackingField;

                        /*0x2bcab30*/ AssetLoaderProvider();
                        /*0x2bcab28*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetLoader get_Loader();
                    }

                    class AssetManagementContext
                    {
                        /*0x10*/ System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceLocationPreparerStep> CustomResourceLocatationPreparers;
                        /*0x18*/ System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemObserver> CustomAssetSystemObservers;
                        /*0x20*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetPreloadController AssetPreloader;
                        /*0x28*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetCacheController AssetCache;
                        /*0x30*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetCatalogVersionUpdateModule AssetCatalogVersionUpdateModule;
                        /*0x38*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IBackgroundDownloadBatcher BackgroundDownloadBatcher;
                        /*0x40*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemNvsContext NvsContext;
                        /*0x48*/ string PackageInBuildTag;
                        /*0x50*/ string AllAssetsLabel;

                        /*0x2bcab9c*/ AssetManagementContext();
                    }

                    class AssetManager
                    {
                        static /*0x0*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetManagerImpl _assetManager;

                        static /*0x2bcac78*/ Packages.EA.PopCap.AddressablesAssets.Runtime.EventManager get_Events();
                        static /*0x2bcaccc*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemNvsContext get_NvsContext();
                        static /*0x2bcad20*/ void Initialize(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetManagementContext context, System.Action callback);
                        static /*0x2bcb808*/ bool DoesAssetExistInCatalog(string assetName);
                        static /*0x2bcb918*/ bool IsProcessingDownloadsOfPriority(UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                        static /*0x2bcba44*/ void BroadcastProgress();
                        static /*0x2bcbbb0*/ void PreloadAssetsAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest request, object registeredOwnerId, Packages.EA.PopCap.AddressablesAssets.Runtime.AssetPreloadOptions preloadOptions);
                        static /*0x2bcbd18*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ActivePreloadAssetRequest GetAssetsForPreloaderAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.GetAssetRequest request);
                        static /*0x2bcbd7c*/ void DownloadAssetsBlockingAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.DownloadAssetRequest assetRequest);
                        static /*0x2bcbde0*/ void DownloadAssetsAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.DownloadAssetRequest assetRequest);
                        static /*0x2bcbe44*/ void DownloadAssetsBackgroundAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.DownloadAssetRequest assetRequest);
                        static /*0x2bcbf5c*/ void DownloadAssetsBackgroundAsyncInternal(Packages.EA.PopCap.AddressablesAssets.Runtime.DownloadAssetRequest assetRequest);
                        static /*0x2bcbfc0*/ void SetBackgroundDownloadingActive(bool state);
                        static /*0x2bcc118*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest GetAssetsBlockingAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.GetAssetRequest assetRequest);
                        static /*0x2bcc17c*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest GetAssetsAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.GetAssetRequest assetRequest);
                        static /*0x2bcc1e0*/ void ReleaseHandle(Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceHandle resourceHandle);
                        static /*0x2bcc2e0*/ void RetryRequest(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest failedRequest);
                        static /*0x2bcc804*/ void CancelRequest(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest request);
                        static /*0x2bcc908*/ void SoftReset();
                        static /*0x2bccd10*/ void CheckForAssetCatalogVersionUpdate(ref Packages.EA.PopCap.AddressablesAssets.Runtime.CatalogVersionUpdateArgs updateArgs);
                    }

                    class AssetManagerImpl
                    {
                        /*0x10*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IActiveAssetRequestProcessor _activeAssetRequestProcessor;
                        /*0x18*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetRequestRecorder _assetAssetRequestRecorder;
                        /*0x20*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetDownloadRouter _assetDownloadRouter;
                        /*0x28*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetRequestRouter _assetRequestRouter;
                        /*0x30*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceManagerListener _resourceManagerListener;
                        /*0x38*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceReleaseRouter _resourceReleaseRouter;
                        /*0x40*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IBackgroundDownloadBatcher _backgroundDownloadBatcher;
                        /*0x48*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetCatalogVersionUpdateModule _assetCatalogVersionUpdateModule;
                        /*0x50*/ bool _isInitialized;
                        /*0x58*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceLocationPreparer <ResourceLocationPreparer>k__BackingField;
                        /*0x60*/ Packages.EA.PopCap.AddressablesAssets.Runtime.EventManager <EventManager>k__BackingField;
                        /*0x68*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemCentralObserver <AssetSystemCentralObserver>k__BackingField;
                        /*0x70*/ string <AllAssetsLabel>k__BackingField;
                        /*0x78*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemNvsContext <NvsContext>k__BackingField;

                        /*0x2bcadc8*/ AssetManagerImpl();
                        /*0x2bcce10*/ bool get_IsBackgroundDownloadBatcherInstalled();
                        /*0x2bcce20*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceLocationPreparer get_ResourceLocationPreparer();
                        /*0x2bcce28*/ Packages.EA.PopCap.AddressablesAssets.Runtime.EventManager get_EventManager();
                        /*0x2bcce30*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemCentralObserver get_AssetSystemCentralObserver();
                        /*0x2bcce38*/ string get_AllAssetsLabel();
                        /*0x2bcce40*/ void set_AllAssetsLabel(string value);
                        /*0x2bcce48*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemNvsContext get_NvsContext();
                        /*0x2bcce50*/ void set_NvsContext(Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemNvsContext value);
                        /*0x2bcaff8*/ void Initialize(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetManagementContext managementContext, System.Action complete);
                        /*0x2bccf2c*/ void OnNvsValueChanged();
                        /*0x2bcb860*/ bool DoesAssetExistInCatalog(string assetName);
                        /*0x2bcb970*/ bool IsProcessingDownloadsOfPriority(UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                        /*0x2bcba94*/ void BroadcastProgress();
                        /*0x2bcbdd8*/ void DownloadAssetsBlockingAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.DownloadAssetRequest assetRequest);
                        /*0x2bcbe3c*/ void DownloadAssetsAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.DownloadAssetRequest assetRequest);
                        /*0x2bcbfb8*/ void DownloadAssetsBackgroundAsyncInternal(Packages.EA.PopCap.AddressablesAssets.Runtime.DownloadAssetRequest assetRequest);
                        /*0x2bcbe9c*/ void DownloadAssetsBackgroundAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.DownloadAssetRequest assetRequest);
                        /*0x2bcd148*/ void DownloadAssetsInternal(Packages.EA.PopCap.AddressablesAssets.Runtime.DownloadAssetRequest assetRequest, UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                        /*0x2bcc018*/ void SetBackgroundDownloadingActive(bool isActive);
                        /*0x2bcc174*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest GetAssetsBlockingAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.GetAssetRequest assetRequest);
                        /*0x2bcc1d8*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest GetAssetsAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.GetAssetRequest assetRequest);
                        /*0x2bcd62c*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest GetAssetsInternal(Packages.EA.PopCap.AddressablesAssets.Runtime.GetAssetRequest assetRequest, UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                        /*0x2bcbc20*/ void PreloadAssetsAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest assetRequest, object registeredOwnerId, Packages.EA.PopCap.AddressablesAssets.Runtime.AssetPreloadOptions preloadOptions);
                        /*0x2bcbd74*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ActivePreloadAssetRequest GetAssetsForPreloaderAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.GetAssetRequest assetRequest);
                        /*0x2bcd914*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ActivePreloadAssetRequest GetAssetsForPreloaderInternal(Packages.EA.PopCap.AddressablesAssets.Runtime.GetAssetRequest assetRequest, UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                        /*0x2bcd780*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceLocationPreparerData CreatePreparerData(UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                        /*0x2bcd4f8*/ void ProcessActiveRequest(Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest activeAssetRequest, UnityEngine.ResourceManagement.EA.ResourcePriority priority);
                        /*0x2bcc238*/ void ReleaseHandle(Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceHandle handle);
                        /*0x2bcc85c*/ void CancelRequest(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest assetRequest);
                        /*0x2bcc338*/ void RetryRequest(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest failedRequest);
                        /*0x2bcc958*/ void OnSoftReset();
                        /*0x2bcda1c*/ void DetachObservers();
                        /*0x2bccd68*/ void CheckForAssetCatalogVersionUpdate(ref Packages.EA.PopCap.AddressablesAssets.Runtime.CatalogVersionUpdateArgs updateArgs);

                        class <>c__DisplayClass28_0
                        {
                            /*0x10*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetManagerImpl <>4__this;
                            /*0x18*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetManagementContext managementContext;
                            /*0x20*/ System.Action complete;

                            /*0x2bcce58*/ <>c__DisplayClass28_0();
                            /*0x2bcdfa0*/ void <Initialize>g__InitializationComplete|0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> locator);
                        }
                    }

                    class AssetPreloadController<T> : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetPreloadController, Packages.EA.PopCap.AddressablesAssets.Runtime.IWithdrawableAssetCache, Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                        /*0x0*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetCacheStore<T> _assetCacheStore;

                        /*0x1f309e4*/ AssetPreloadController();
                        /*0x1f30ff0*/ void WithdrawHandles(System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> remainingLocations, System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> listToAddHandlesTo);
                        UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle WithdrawHandle(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation requestedLocation, ref bool isFound);
                        void PreCache(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest assetRequest, object registeredOwner, Packages.EA.PopCap.AddressablesAssets.Runtime.AssetPreloadOptions options);
                        /*0x1ffc854*/ void PreCache(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest assetRequest, System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> filteredAssets, T registeredOwner);
                        /*0x1ffc854*/ void StateEntered(T newState);
                        /*0x1ffc854*/ void StateExited(T exitState);
                        /*0x1f309e4*/ void OnSoftReset();

                        class PreCacheSetOperation<T>
                        {
                            /*0x0*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest _assetRequest;
                            /*0x0*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetCacheStore<T> _assetCacheStore;
                            /*0x0*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollection _preloadedResourceCollection;
                            /*0x0*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> _assetsToLoad;
                            /*0x0*/ T _registeredOwner;

                            /*0x1ffc854*/ PreCacheSetOperation(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest assetRequest, Packages.EA.PopCap.AddressablesAssets.Runtime.AssetCacheStore<T> assetCacheStore, System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> assetsToLoad, T registeredOwner);
                            /*0x1f309e4*/ void Execute();
                            /*0x1f30ff0*/ void OnPreloadComplete(Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection collection, object context);
                            /*0x1f30ff0*/ void OnPreloadFailed(Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceError error, object context);
                        }
                    }

                    class AssetPreloadException : System.Exception
                    {
                        /*0x2bce0f4*/ AssetPreloadException(string message);
                    }

                    struct AssetPreloadOptions
                    {
                        /*0x10*/ bool IncludeDownloads;

                        /*0x2bce15c*/ AssetPreloadOptions(bool includeDownloads);
                    }

                    class AssetRequest
                    {
                        /*0x10*/ uint <Id>k__BackingField;
                        /*0x18*/ object <Context>k__BackingField;
                        /*0x20*/ bool <IsComplete>k__BackingField;
                        /*0x28*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> <AssetsToRequest>k__BackingField;
                        /*0x30*/ System.Action<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection, object> <CompleteCallback>k__BackingField;
                        /*0x38*/ System.Action<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceError, object> <ErrorCallback>k__BackingField;
                        /*0x40*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection <ResourceCollection>k__BackingField;

                        /*0x2bce994*/ AssetRequest();
                        /*0x2bce164*/ uint get_Id();
                        /*0x2bce16c*/ void set_Id(uint value);
                        /*0x2bce174*/ object get_Context();
                        /*0x2bce17c*/ void set_Context(object value);
                        /*0x2bcd27c*/ bool get_HasAssetsToRequest();
                        /*0x2bce184*/ bool get_IsComplete();
                        /*0x2bce18c*/ void set_IsComplete(bool value);
                        /*0x2bce194*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_AssetsToRequest();
                        /*0x2bce19c*/ System.Action<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection, object> get_CompleteCallback();
                        /*0x2bce1a4*/ void set_CompleteCallback(System.Action<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection, object> value);
                        /*0x2bce1ac*/ System.Action<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceError, object> get_ErrorCallback();
                        /*0x2bce1b4*/ void set_ErrorCallback(System.Action<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceError, object> value);
                        /*0x2bce1bc*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection get_ResourceCollection();
                        /*0x2bce1c4*/ void set_ResourceCollection(Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection value);
                        /*0x2bce1cc*/ void Initialize(uint id, ref Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequestInitData data);
                        /*0x2bce218*/ void Cancel();
                        /*0x2bce270*/ void RunPreCompleteCallbackFinalizationTasks();
                        /*0x2bce274*/ void RunPostCompleteCallbackFinalizationTasks();
                        /*0x2bc8040*/ void FinalizeRequest(Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollection collection);
                        /*0x2bc6d44*/ void FailRequest(Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceError error);
                        /*0x2bce278*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest AddAsset(object address, System.Type type);
                        /*0x2bce608*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest AddAssets(System.Collections.Generic.List<object> addressList, System.Type type);
                        /*0x2bce8d4*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest AddAsset(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                        /*0x2bce934*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest AddAssets(System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> assetLocationList);
                        /*0x2bce248*/ void ClearCallbacks();
                    }

                    class AssetRequestFactory
                    {
                        static /*0x0*/ uint _assetRequestUniqueId;

                        static /*0x1ffc854*/ T GenerateAssetRequest<T>(string assetAddress, System.Type type, ref Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequestInitData data);
                        static /*0x1ffc854*/ T GenerateAssetRequest<T>(System.Collections.Generic.List<string> assetAddresses, System.Type type, ref Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequestInitData data);
                        static /*0x1ffc854*/ T GenerateAssetRequest<T>(System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> assetAddresses, ref Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequestInitData data);
                        static /*0x1ffc854*/ T GenerateAssetRequest<T>(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequestInitData data);
                    }

                    struct AssetRequestInitData
                    {
                        /*0x10*/ System.Action<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection, object> CompleteCallback;
                        /*0x18*/ System.Action<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceError, object> ErrorCallback;
                        /*0x20*/ System.Nullable<UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters> InstantiationParameters;
                        /*0x58*/ object Context;
                        /*0x60*/ bool ActiveStateForAssetsToSetOnComplete;

                        /*0x2bcea1c*/ AssetRequestInitData(System.Action<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection, object> completeCallback, System.Action<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceError, object> errorCallback, object context);
                        /*0x2bceadc*/ AssetRequestInitData(System.Action<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection, object> completeCallback, System.Action<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceError, object> errorCallback, System.Nullable<UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters> parameters, bool activeStateForAssetsToSetOnComplete, object context);
                    }

                    class AssetRequestRecorder : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetRequestRecorder, Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                        /*0x10*/ System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest> _assetRequests;

                        /*0x2bcdac8*/ AssetRequestRecorder();
                        /*0x2bceb58*/ void Record(Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest assetRequest);
                        /*0x2bcebb0*/ void OnSoftReset();

                        class <>c__DisplayClass2_0
                        {
                            /*0x10*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle asyncOpHandle;

                            /*0x2bcee04*/ <>c__DisplayClass2_0();
                            /*0x2bcee0c*/ void <OnSoftReset>b__0(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                        }
                    }

                    class AssetRequestRouter : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetRequestRouter, Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemInitializable, Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                        /*0x10*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetLoaderProvider _assetLoaderProvider;
                        /*0x18*/ System.Type _gameObjectType;
                        /*0x20*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetPreloadController _preloadController;
                        /*0x28*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IWithdrawableAssetCache _assetCache;
                        /*0x30*/ System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IWithdrawableAssetCache> _installedCaches;

                        /*0x2bcdb50*/ AssetRequestRouter();
                        /*0x2bcee4c*/ bool get_HasPreloaderInstalled();
                        /*0x2bcee5c*/ bool get_HasAssetCacheInstalled();
                        /*0x2bcee6c*/ void Initialize(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetManagementContext context);
                        /*0x2bcef24*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest GetAssetsAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.GetAssetRequest request);
                        /*0x2bcf498*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ActivePreloadAssetRequest GetAssetsForPreloadAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.GetAssetRequest request);
                        /*0x2bcf1ec*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle GetAssetsAsyncInternal(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, ref System.Nullable<UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters> parameters);
                        /*0x2bcf710*/ void PreloadAssetsAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest request, object registeredOwner, Packages.EA.PopCap.AddressablesAssets.Runtime.AssetPreloadOptions preloadOptions);
                        /*0x2bcf810*/ void OnSoftReset();
                    }

                    enum AssetRequestType
                    {
                        Download = 0,
                        Get = 1,
                        Preload = 2,
                    }

                    class ResourceLocationCollection
                    {
                        /*0x10*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> <InstantiateList>k__BackingField;
                        /*0x18*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> <LoadList>k__BackingField;

                        /*0x2bcf918*/ ResourceLocationCollection(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> loadList);
                        /*0x2bcf948*/ ResourceLocationCollection(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> loadList, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> instantiateList);
                        /*0x2bcf98c*/ bool get_HasAssetsToInstantiate();
                        /*0x2bcfa3c*/ bool get_HasAssetsToLoad();
                        /*0x2bcfaec*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_InstantiateList();
                        /*0x2bcfaf4*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_LoadList();
                    }

                    class AssetResourceLocationSynchProvider
                    {
                        static /*0x0*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> _locationMap;
                        static /*0x8*/ string AllAssetsKeyword;

                        static /*0x2bcfafc*/ void UpdateLocationMapToNewCatalog(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator);
                        static /*0x2bce0f0*/ void Initialize(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator, Packages.EA.PopCap.AddressablesAssets.Runtime.AssetManagementContext context);
                        static /*0x2bcfb00*/ void SetupLocationMapForLocator(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator);
                        static /*0x2bcd008*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> ProvideResourceLocationsForKey(object assetToRequest, System.Type type);
                        static /*0x2bce684*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> ProvideResourceLocationsForKeyList(System.Collections.Generic.IList<object> assetsToRequest, System.Type type);
                        static /*0x2bd0090*/ void AddLocationsOfType(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> inputLocations, System.Type type, System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> outputLocations);
                        static /*0x2bd0358*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> GetResourceLocationFromAddressables(object assetToRequest, System.Type type);
                        static /*0x2bd05a4*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> GetResourceLocationsFromAddressables(System.Collections.Generic.IList<object> assetsToRequest, System.Type type);
                        static /*0x2bd03e8*/ System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> WaitAndReturnLocations(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> locationOp);
                    }

                    class BackgroundDownloadBatcher : Packages.EA.PopCap.AddressablesAssets.Runtime.IBackgroundDownloadBatcher, Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemInitializable, Packages.EA.PopCap.AddressablesAssets.Runtime.IObservable, Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                        static /*0x0*/ int <BackgroundDownloadBatchSize>k__BackingField;
                        /*0x10*/ long <RemainingBytesToDownload>k__BackingField;
                        /*0x18*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemCentralObserver _centralObserver;
                        /*0x20*/ System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.BackgroundDownloadBatcher.BackgroundDownloadProcessorTracker> _blockingDownloadExecutor;

                        static /*0x2bd0644*/ int get_BackgroundDownloadBatchSize();
                        static /*0x2bd068c*/ void set_BackgroundDownloadBatchSize(int value);
                        /*0x2bd0b60*/ BackgroundDownloadBatcher();
                        /*0x2bd0634*/ long get_RemainingBytesToDownload();
                        /*0x2bd063c*/ void set_RemainingBytesToDownload(long value);
                        /*0x2bd06d8*/ void Initialize(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetManagementContext context);
                        /*0x2bd07bc*/ void DownloadAssetsInBackground(Packages.EA.PopCap.AddressablesAssets.Runtime.DownloadAssetRequest assetRequest);
                        /*0x2bd09a8*/ void AllBatchesComplete(Packages.EA.PopCap.AddressablesAssets.Runtime.BackgroundDownloadBatcher.BackgroundDownloadProcessorTracker tracker);
                        /*0x2bd0aa4*/ void AttachObserver(Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemCentralObserver obs);
                        /*0x2bd0aac*/ void DetachObserver(Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemCentralObserver obs);
                        /*0x2bd0ab8*/ void OnSoftReset();

                        class BackgroundDownloadProcessorTracker
                        {
                            /*0x10*/ Packages.EA.PopCap.AddressablesAssets.Runtime.DownloadAssetRequest _originalDownloadRequest;
                            /*0x18*/ int _index;
                            /*0x20*/ Packages.EA.PopCap.AddressablesAssets.Runtime.BackgroundDownloadBatcher _owner;
                            /*0x28*/ bool _cancelBatch;

                            /*0x2bd0960*/ BackgroundDownloadProcessorTracker(Packages.EA.PopCap.AddressablesAssets.Runtime.DownloadAssetRequest requestToProcess, Packages.EA.PopCap.AddressablesAssets.Runtime.BackgroundDownloadBatcher owner);
                            /*0x2bd0bec*/ int get_IndexBatchEnd();
                            /*0x2bd0c3c*/ bool get_IsProcessComplete();
                            /*0x2bd09a4*/ void BeginProcessing();
                            /*0x2bd0c98*/ void ProcessNextBatch();
                            /*0x2bd0b54*/ void StopAllBatching();
                            /*0x2bd1074*/ void OnBatchSuccess(Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection collection, object context);
                            /*0x2bd1078*/ void OnBatchFailed(Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceError error, object context);
                            /*0x2bd0f58*/ void OnBatchComplete();
                        }
                    }

                    class CertificateHandlerBypass : UnityEngine.Networking.CertificateHandler
                    {
                        /*0x2bd1084*/ CertificateHandlerBypass();
                        /*0x2bd107c*/ bool ValidateCertificate(byte[] certificateData);
                    }

                    interface IContentUpdate
                    {
                        UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> HasCatalogHashInstalledAsync(string catalogHash);
                        UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> PrepareForContentUpdate(string catalogHash);
                        UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadRequiredPackagedAssets(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
                        UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle FinalizeContentUpdate(string catalogHash);
                    }

                    class ContentUpdate : Packages.EA.PopCap.AddressablesAssets.Runtime.IContentUpdate
                    {
                        /*0x2bc9240*/ ContentUpdate();
                        /*0x2bd108c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> HasCatalogHashInstalledAsync(string catalogHash);
                        /*0x2bd110c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> PrepareForContentUpdate(string catalogHash);
                        /*0x2bd118c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle FinalizeContentUpdate(string catalogHash);
                        /*0x2bd120c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadRequiredPackagedAssets(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
                    }

                    class ContentUpdateDebug : Packages.EA.PopCap.AddressablesAssets.Runtime.ContentUpdate
                    {
                        /*0x2bca198*/ ContentUpdateDebug();
                        /*0x2bd12cc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<bool> HasCatalogHashInstalledAsync(string catalogHash);
                        /*0x2bd138c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator> PrepareForContentUpdate(string catalogHash);
                        /*0x2bd13c4*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle FinalizeContentUpdate(string catalogHash);
                    }

                    class DownloadAssetRequest : Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest
                    {
                        /*0x2bd13fc*/ DownloadAssetRequest();
                    }

                    class Events
                    {
                        class AssetEvents
                        {
                            static /*0x0*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent<Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadEventData> OnBlockingLoadProgressUpdated;
                            static /*0x8*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent<Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadEventData> OnBlockingLoadStatusChanged;
                            static /*0x10*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent<Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadEventData> OnBackgroundDownloadProgressUpdated;
                            static /*0x18*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent<Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadEventData> OnBackgroundDownloadStatusChanged;

                            static /*0x2bd1400*/ AssetEvents();
                        }

                        class ClientEvents
                        {
                        }
                    }

                    class AssetSystemEvent
                    {
                        /*0x10*/ EA.Text.SmallString64 Name;

                        /*0x2bd1658*/ AssetSystemEvent(EA.Text.SmallString64 name);
                    }

                    class AssetSystemEvent<T>
                    {
                        /*0x0*/ EA.Text.SmallString64 Name;

                        /*0x1ffc854*/ AssetSystemEvent(EA.Text.SmallString64 name);
                    }

                    class EventManager
                    {
                        /*0x10*/ System.Collections.Generic.Dictionary<object, System.Collections.Generic.List<System.Delegate>> _routingTable;
                        /*0x18*/ System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.EventManager.UpdateAction> _updateActions;
                        /*0x20*/ int _dispatchDepth;

                        /*0x2bcdcf0*/ EventManager();
                        /*0x2bd168c*/ void Subscribe(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent messageKey, UnityEngine.Events.UnityAction listener);
                        /*0x1f30ff0*/ void Subscribe<T>(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent<T> messageKey, UnityEngine.Events.UnityAction<T> listener);
                        /*0x2bd1794*/ void Unsubscribe(object listener);
                        /*0x2bd1ac4*/ void Broadcast(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent messageKey);
                        /*0x1ffc854*/ void Broadcast<T>(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent<T> messageKey, T p1);
                        /*0x2bd1bdc*/ System.Collections.Generic.List<System.Delegate> GetDispatchList(object messageKey);
                        /*0x2bd1690*/ void Insert(object messageKey, System.Delegate callback);
                        /*0x2bd1798*/ void Remove(object listener);
                        /*0x2bd1cbc*/ void TryApplyUpdateActions();

                        enum UpdateActionType
                        {
                            Subscribe = 0,
                            Unsubscribe = 1,
                        }

                        struct UpdateAction
                        {
                            /*0x10*/ Packages.EA.PopCap.AddressablesAssets.Runtime.EventManager.UpdateActionType Type;
                            /*0x18*/ object MessageKey;
                            /*0x20*/ object Listener;
                            /*0x28*/ System.Delegate Callback;
                        }

                        class <>c__DisplayClass10_0
                        {
                            /*0x10*/ object listener;
                            /*0x18*/ System.Predicate<System.Delegate> <>9__0;

                            /*0x2bd1e20*/ <>c__DisplayClass10_0();
                            /*0x2bd1e28*/ bool <Remove>b__0(System.Delegate x);
                        }
                    }

                    enum AllocationMonitorType
                    {
                        Null = 0,
                        Assets = 1,
                        Bundles = 2,
                        All = 3,
                    }

                    interface IAllocationMonitor
                    {
                        /*0x1f2ffc8*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AllocationMonitorType get_MonitorType();
                        long get_SoftMemoryLimit();
                        /*0x1f30d60*/ void set_SoftMemoryLimit(long value);
                        long get_CurrentMemoryUsage();
                        /*0x1f2fe14*/ bool get_IsFull();
                        /*0x1f30d60*/ void SetSoftMemoryLimit(long softMemoryLimit);
                        bool HasFreeSpace(long requestedBytes);
                    }

                    interface IAllocationMonitorInternal : Packages.EA.PopCap.AddressablesAssets.Runtime.IAllocationMonitor
                    {
                        void MemoryFreed(string assetName, long numberOfBytes);
                        void MemoryAllocated(string assetName, long numberOfBytes);
                    }

                    class NullAllocationMonitor : Packages.EA.PopCap.AddressablesAssets.Runtime.IAllocationMonitor
                    {
                        /*0x10*/ long <SoftMemoryLimit>k__BackingField;
                        /*0x18*/ long <CurrentMemoryUsage>k__BackingField;
                        /*0x20*/ bool <IsFull>k__BackingField;

                        /*0x2bd1e7c*/ NullAllocationMonitor();
                        /*0x2bd1e48*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AllocationMonitorType get_MonitorType();
                        /*0x2bd1e50*/ long get_SoftMemoryLimit();
                        /*0x2bd1e58*/ void set_SoftMemoryLimit(long value);
                        /*0x2bd1e60*/ long get_CurrentMemoryUsage();
                        /*0x2bd1e68*/ bool get_IsFull();
                        /*0x2bd1e70*/ void SetSoftMemoryLimit(long softMemoryLimit);
                        /*0x2bd1e74*/ bool HasFreeSpace(long requestedBytes);
                    }

                    class AllocationMonitor : Packages.EA.PopCap.AddressablesAssets.Runtime.IAllocationMonitorInternal, Packages.EA.PopCap.AddressablesAssets.Runtime.IAllocationMonitor
                    {
                        /*0x10*/ long _currentMemoryUsage;
                        /*0x18*/ long _softMemoryLimit;
                        /*0x20*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AllocationMonitorType <MonitorType>k__BackingField;

                        /*0x2bd1e8c*/ AllocationMonitor(Packages.EA.PopCap.AddressablesAssets.Runtime.AllocationMonitorType monitorType);
                        /*0x2bd1e84*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AllocationMonitorType get_MonitorType();
                        /*0x2bd1eb4*/ long get_SoftMemoryLimit();
                        /*0x2bd1ebc*/ void set_SoftMemoryLimit(long value);
                        /*0x2bd1ec4*/ long get_CurrentMemoryUsage();
                        /*0x2bd1ecc*/ bool get_IsFull();
                        /*0x2bd1edc*/ bool HasFreeSpace(long requestedBytes);
                        /*0x2bd1ef0*/ void SetSoftMemoryLimit(long softMemoryLimit);
                        /*0x2bd1ef8*/ void MemoryFreed(string assetName, long numberOfBytes);
                        /*0x2bd1f08*/ void MemoryAllocated(string assetName, long numberOfBytes);
                        /*0x2bd1f18*/ void LogAllocationChange(string action, string assetName, long numberOfBytes);
                    }

                    class ExternalAllocationReporter : UnityEngine.ResourceManagement.EA.IExternalAllocationReporter
                    {
                        /*0x10*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AllocationMonitor _allocationMonitorInstance;

                        static /*0x2bd2060*/ long GetRuntimeMemorySize(string assetName, bool forClone);
                        static /*0x2bd20b8*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation GetLocation(string assetName);
                        /*0x2bd21e8*/ ExternalAllocationReporter();
                        /*0x2bd1f1c*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AllocationMonitor get__assetsAllocationMonitor();
                        /*0x2bd1f24*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AllocationMonitor get__bundleAllocationMonitor();
                        /*0x2bd1f2c*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAllocationMonitor get_AllocationMonitor();
                        /*0x2bd1f34*/ void ReportAssetBundleMemoryAllocated(string bundleName, long bytes);
                        /*0x2bd1f54*/ void ReportAssetBundleMemoryFreed(string bundleName, long bytes);
                        /*0x2bd1f74*/ void ReportAssetBundleLeak(string bundleName);
                        /*0x2bd1fec*/ void ReportMemoryAllocated(string assetName, long bytes);
                        /*0x2bd200c*/ void ReportMemoryFreed(string assetName, long bytes);
                        /*0x2bd202c*/ void ReportMemoryAllocated(string assetName, bool forClone);
                        /*0x2bd2084*/ void ReportMemoryFreed(string assetName, bool forClone);
                    }

                    class GetAssetRequest : Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest
                    {
                        /*0x48*/ bool <ActiveStateForAssetsToSetOnComplete>k__BackingField;
                        /*0x50*/ System.Nullable<UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters> <InstantiationParameters>k__BackingField;

                        /*0x2bd28f0*/ GetAssetRequest();
                        /*0x2bd225c*/ bool get_ActiveStateForAssetsToSetOnComplete();
                        /*0x2bd2264*/ void set_ActiveStateForAssetsToSetOnComplete(bool value);
                        /*0x2bd226c*/ System.Nullable<UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters> get_InstantiationParameters();
                        /*0x2bd2288*/ void set_InstantiationParameters(System.Nullable<UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters> value);
                        /*0x2bd22b4*/ void Initialize(uint id, ref Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequestInitData data);
                        /*0x2bd22fc*/ void RunPreCompleteCallbackFinalizationTasks();
                    }

                    interface IActiveAssetRequestProcessor : Packages.EA.PopCap.AddressablesAssets.Runtime.IObservable, Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                        /*0x1f30ebc*/ void Process(Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest request);
                        /*0x1f30ebc*/ void Cancel(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest request);
                        /*0x1f309e4*/ void BroadcastProgress();
                    }

                    interface IActiveRequestProgressHandler
                    {
                        /*0x1f30ebc*/ void OnComplete(Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest request);
                        /*0x1f30ebc*/ void OnProgress(Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest request);
                        /*0x1f30ebc*/ void OnError(Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest request);
                    }

                    interface IAssetCacheController : Packages.EA.PopCap.AddressablesAssets.Runtime.IWithdrawableAssetCache, Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                        /*0x1f30ebc*/ void CacheHandle(Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceHandle handle);
                        /*0x1f309e4*/ void CleanupCurrentStateCache();
                        /*0x1f309e4*/ void ManualLowMemoryCall();
                    }

                    interface IAssetCacheStore
                    {
                    }

                    interface IAssetCatalogVersionUpdateModule : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemInitializable
                    {
                        /*0x1f30ebc*/ void CheckForAssetCatalogVersionUpdate(ref Packages.EA.PopCap.AddressablesAssets.Runtime.CatalogVersionUpdateArgs updateArgs);
                        /*0x1f309e4*/ void BroadcastProgress();
                    }

                    interface IAssetDownloader
                    {
                        UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadAssetsAsync(System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, System.Action<UnityEngine.ResourceManagement.ResourceProviders.IAssetBundleResource> progressCallback);
                        UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle DownloadAssetAsync(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                    }

                    interface IAssetDownloadRouter
                    {
                        /*0x1f302cc*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest DownloadAssetsAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest request);
                    }

                    interface IAssetLoader
                    {
                        UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle InstantiateAssets(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters parameters);
                        UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle LoadAssets(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation resourceLocation, System.Action<UnityEngine.Object> individualCallback);
                    }

                    interface IAssetMemoryMonitor
                    {
                        /*0x1f30214*/ UnityEngine.ResourceManagement.EA.IExternalAllocationReporter get_AllocationReporter();
                        /*0x1f30214*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAllocationMonitor get_AllocationMonitor();
                    }

                    class AssetMemoryMonitor : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetMemoryMonitor
                    {
                        static /*0x2bd28f4*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IInstanceMemoryMonitor get_InstanceFactory();
                        /*0x2bd2a94*/ AssetMemoryMonitor();
                        /*0x2bd2960*/ UnityEngine.ResourceManagement.EA.IExternalAllocationReporter get_AllocationReporter();
                        /*0x2bd29f8*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAllocationMonitor get_AllocationMonitor();
                    }

                    interface IAssetPreloadController : Packages.EA.PopCap.AddressablesAssets.Runtime.IWithdrawableAssetCache, Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                        void PreCache(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest assetRequest, object registeredOwner, Packages.EA.PopCap.AddressablesAssets.Runtime.AssetPreloadOptions options);
                    }

                    interface IAssetRequestRecorder : Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                        /*0x1f30ebc*/ void Record(Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest handles);
                    }

                    interface IAssetRequestRouter : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemInitializable, Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                        /*0x1f302cc*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ActiveAssetRequest GetAssetsAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.GetAssetRequest request);
                        /*0x1f302cc*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ActivePreloadAssetRequest GetAssetsForPreloadAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.GetAssetRequest request);
                        void PreloadAssetsAsync(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest request, object registeredOwner, Packages.EA.PopCap.AddressablesAssets.Runtime.AssetPreloadOptions preloadOptions);
                    }

                    interface IAssetSystemInitializable
                    {
                        /*0x1f30ebc*/ void Initialize(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetManagementContext context);
                    }

                    interface IAssetSystemNvsContext
                    {
                        /*0x1f30214*/ System.Action get_OnValuesChanged();
                        /*0x1f30ebc*/ void set_OnValuesChanged(System.Action value);
                        /*0x1f2fe14*/ bool get_ContentUpdateEnabled();
                        /*0x1f2fe14*/ bool get_AddressablesAssetCachingEnabled();
                        /*0x1f2fe14*/ bool get_AddressablesBackgroundDownloadBatchingEnabled();
                        /*0x1f2ffc8*/ int get_DownloadTimeoutInSeconds();
                        /*0x1f2ffc8*/ int get_BundleRedirectLimit();
                        /*0x1f2ffc8*/ int get_BundleRetryCount();
                        /*0x1f2ffc8*/ int get_AssetBundleMaxParallelBackgroundRequests();
                    }

                    interface IBackgroundDownloadBatcher : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemInitializable, Packages.EA.PopCap.AddressablesAssets.Runtime.IObservable, Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                        long get_RemainingBytesToDownload();
                        /*0x1f30d60*/ void set_RemainingBytesToDownload(long value);
                        /*0x1f30ebc*/ void DownloadAssetsInBackground(Packages.EA.PopCap.AddressablesAssets.Runtime.DownloadAssetRequest assetRequest);
                    }

                    interface IProvider
                    {
                    }

                    interface IResourceCollection : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>>>, System.Collections.IEnumerable
                    {
                        /*0x1f30a84*/ void ReleaseAll(bool evict);
                        /*0x1f302cc*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle GetFirst(string name);
                        /*0x1f302cc*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle GetOneHandleAndReleaseAllOthers(string name);
                        /*0x1f30214*/ System.Collections.Generic.IEnumerable<string> get_Keys();
                        /*0x1f30214*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>> get_Values();
                        /*0x1f302cc*/ System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle> get_Item(string key);
                        /*0x1f2ffc8*/ int get_Count();
                        /*0x1f2fec8*/ bool ContainsKey(string key);
                        /*0x1f2fe14*/ bool IsNullOrEmpty();
                        /*0x1f2ff00*/ bool TryGetValue(string key, ref System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle> value);
                    }

                    interface IResourceCollectionInternal
                    {
                        /*0x1f30ff0*/ void Add(string key, Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle handle);
                    }

                    interface IResourceError
                    {
                        /*0x1f2ffc8*/ int get_ErrorCode();
                        /*0x1f30214*/ string get_ResourceName();
                        /*0x1f30214*/ string get_ErrorMessage();
                    }

                    interface IResourceHandle
                    {
                        /*0x1f30214*/ string get_Name();
                        /*0x1f30214*/ UnityEngine.Object get_Resource();
                        /*0x1f30214*/ UnityEngine.GameObject get_GO();
                        /*0x1f30214*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle Clone();
                        /*0x1f30240*/ System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle> Clone(int numberOfInstances);
                        /*0x1f30a84*/ void Release(bool evict);
                        /*0x1f2fe14*/ bool get_IsValid();
                    }

                    interface IResourceHandleInternal
                    {
                        /*0x1f30ebc*/ void SetOwnerCollection(Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection collection);
                        /*0x1f309e4*/ void HideHandle();
                        /*0x1f2fe14*/ bool get_WasHidden();
                        /*0x1f30a84*/ void set_WasHidden(bool value);
                    }

                    interface IResourceReleaseRouter : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemInitializable
                    {
                        /*0x1f30ebc*/ void ReleaseHandle(Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceHandle resourceHandle);
                    }

                    interface ISoftResetListener
                    {
                        /*0x1f309e4*/ void OnSoftReset();
                    }

                    interface IWithdrawableAssetCache : Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                        /*0x1f30ff0*/ void WithdrawHandles(System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> remainingLocations, System.Collections.Generic.List<UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle> listToAddHandlesTo);
                        UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle WithdrawHandle(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation requestedLocation, ref bool isFound);
                    }

                    struct AssetDownloadEventData
                    {
                        /*0x10*/ long BytesToDownload;
                        /*0x18*/ float NormalizedPercentComplete;
                        /*0x1c*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadStatus Status;

                        /*0x2bd2a9c*/ float get_MBToDownload();
                    }

                    enum AssetDownloadStatus
                    {
                        Active = 0,
                        Paused = 1,
                        Complete = 2,
                    }

                    class AssetDownloadProgressObserver : Packages.EA.PopCap.AddressablesAssets.Runtime.IActiveAssetRequestObserver, Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemObserver, Packages.EA.PopCap.AddressablesAssets.Runtime.IBackgroundDownloadStatusObserver
                    {
                        /*0x10*/ UnityEngine.ResourceManagement.EA.ResourcePriority _priorityToListenFor;
                        /*0x18*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent<Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadEventData> _progressEventToBroadcast;
                        /*0x20*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent<Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadEventData> _statusEventToBroadcast;
                        /*0x28*/ int _unfinishedRequestsCount;
                        /*0x30*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadEventData _assetDownloadData;
                        /*0x40*/ System.Collections.Generic.Dictionary<uint, Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest> _activeRequests;

                        /*0x2bd2b04*/ AssetDownloadProgressObserver(UnityEngine.ResourceManagement.EA.ResourcePriority priorityToListenFor, Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent<Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadEventData> progressEventToBroadcast, Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent<Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadEventData> statusEventToBroadcast);
                        /*0x2bd2aa8*/ bool get_AreDownloadsActive();
                        /*0x2bd2bd0*/ void NotifyAssetRequestCreated(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x2bd2fb4*/ void NotifyAssetRequestCompleted(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x2bd3474*/ void NotifyAssetRequestFailed(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x2bd3678*/ void NotifyAssetRequestProgress(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x2bd33dc*/ void CompleteObservationOfCurrentRequests();
                        /*0x2bd2e34*/ bool RequestMeetsRequirements(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x2bd30c8*/ void CalculateRemainingDownloadSize();
                        /*0x2bd3700*/ void NotifyDownloadQueueStateChanged(UnityEngine.ResourceManagement.EA.ResourcePriority priority, bool state);
                        /*0x2bd3784*/ void NotifyDownloadBatchProcessingStateChanged(bool isActive, long bytes);
                    }

                    class AssetSystemCentralObserver : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemCentralObserver, Packages.EA.PopCap.AddressablesAssets.Runtime.IAllAssetSystemObservers, Packages.EA.PopCap.AddressablesAssets.Runtime.IActiveAssetRequestObserver, Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemObserver, Packages.EA.PopCap.AddressablesAssets.Runtime.IBackgroundDownloadStatusObserver, Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemInitializable
                    {
                        /*0x10*/ System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IActiveAssetRequestObserver> _activeAssetRequestObservers;
                        /*0x18*/ System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IBackgroundDownloadStatusObserver> _backgroundDownloadStatusObservers;
                        /*0x20*/ System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IAddressablesEventObserver> _addressablesEventObservers;

                        /*0x2bcddcc*/ AssetSystemCentralObserver();
                        /*0x2bd3788*/ void Initialize(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetManagementContext context);
                        /*0x2bd37b8*/ void AddDefaultObservers(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetManagementContext context);
                        /*0x2bd38f8*/ void AddObservers(System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemObserver> assetSystemObservers);
                        /*0x2bd3a5c*/ void AddObserver(Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemObserver assetSystemObserver);
                        /*0x2bd3b88*/ void OnAddressablesDiagnosticEventReceived(UnityEngine.ResourceManagement.ResourceManager.DiagnosticEventContext eventContext);
                        /*0x2bd3cd4*/ void NotifyAssetRequestCreated(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x2bd3de4*/ void NotifyAssetRequestCompleted(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x2bd3ef8*/ void NotifyAssetRequestFailed(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x2bd400c*/ void NotifyAssetRequestProgress(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x2bd4120*/ void NotifyDownloadQueueStateChanged(UnityEngine.ResourceManagement.EA.ResourcePriority priority, bool isActive);
                        /*0x2bd4240*/ void NotifyDownloadBatchProcessingStateChanged(bool isActive, long bytes);
                    }

                    class AssetSystemObserverDispatch<T>
                    {
                        /*0x0*/ System.Collections.Generic.List<T> _activeAssetRequestObservers;

                        /*0x1f309e4*/ AssetSystemObserverDispatch();
                    }

                    class BackgroundDownloadProgressObserver : Packages.EA.PopCap.AddressablesAssets.Runtime.IActiveAssetRequestObserver, Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemObserver, Packages.EA.PopCap.AddressablesAssets.Runtime.IBackgroundDownloadStatusObserver
                    {
                        /*0x10*/ UnityEngine.ResourceManagement.EA.ResourcePriority _priorityToListenFor;
                        /*0x18*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent<Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadEventData> _progressEventToBroadcast;
                        /*0x20*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent<Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadEventData> _statusEventToBroadcast;
                        /*0x28*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadEventData _assetDownloadData;
                        /*0x38*/ System.Collections.Generic.Dictionary<uint, Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest> _activeRequests;
                        /*0x40*/ long _bytesDownloaded;

                        /*0x2bd3998*/ BackgroundDownloadProgressObserver(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent<Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadEventData> progressEventToBroadcast, Packages.EA.PopCap.AddressablesAssets.Runtime.AssetSystemEvent<Packages.EA.PopCap.AddressablesAssets.Runtime.AssetDownloadEventData> statusEventToBroadcast);
                        /*0x2bd4364*/ bool get_AreDownloadsActive();
                        /*0x2bd43c0*/ void NotifyAssetRequestCreated(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x2bd4730*/ void NotifyAssetRequestCompleted(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x2bd48f8*/ void NotifyAssetRequestFailed(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x2bd48fc*/ void NotifyAssetRequestProgress(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x2bd45b0*/ bool RequestMeetsRequirements(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x2bd48dc*/ void CalculateRemainingDownloadSize();
                        /*0x2bd4900*/ void NotifyDownloadQueueStateChanged(UnityEngine.ResourceManagement.EA.ResourcePriority priority, bool isActive);
                        /*0x2bd49a0*/ void NotifyDownloadBatchProcessingStateChanged(bool isActive, long bytes);
                    }

                    struct FailedHandleData
                    {
                        /*0x10*/ string Name;
                        /*0x18*/ bool IsValid;
                        /*0x20*/ System.Exception OperationException;

                        /*0x2bc69e0*/ FailedHandleData(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op);
                    }

                    interface IActiveAssetRequestObserver : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemObserver
                    {
                        /*0x1f30ebc*/ void NotifyAssetRequestCreated(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x1f30ebc*/ void NotifyAssetRequestCompleted(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x1f30ebc*/ void NotifyAssetRequestFailed(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                        /*0x1f30ebc*/ void NotifyAssetRequestProgress(Packages.EA.PopCap.AddressablesAssets.Runtime.IObservableActiveAssetRequest activeAssetRequest);
                    }

                    interface IAddressablesEventObserver : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemObserver
                    {
                        void NotifyEvent(UnityEngine.ResourceManagement.ResourceManager.DiagnosticEventContext context);
                    }

                    interface IAllAssetSystemObservers : Packages.EA.PopCap.AddressablesAssets.Runtime.IActiveAssetRequestObserver, Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemObserver, Packages.EA.PopCap.AddressablesAssets.Runtime.IBackgroundDownloadStatusObserver
                    {
                    }

                    interface IAssetSystemCentralObserver : Packages.EA.PopCap.AddressablesAssets.Runtime.IAllAssetSystemObservers, Packages.EA.PopCap.AddressablesAssets.Runtime.IActiveAssetRequestObserver, Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemObserver, Packages.EA.PopCap.AddressablesAssets.Runtime.IBackgroundDownloadStatusObserver, Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemInitializable
                    {
                        /*0x1f30ebc*/ void AddObserver(Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemObserver assetSystemObserver);
                        /*0x1f30ebc*/ void AddObservers(System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemObserver> assetSystemObservers);
                    }

                    interface IAssetSystemObserver
                    {
                    }

                    interface IBackgroundDownloadStatusObserver
                    {
                        void NotifyDownloadQueueStateChanged(UnityEngine.ResourceManagement.EA.ResourcePriority priority, bool isActive);
                        void NotifyDownloadBatchProcessingStateChanged(bool isActive, long bytes);
                    }

                    interface IObservable
                    {
                        /*0x1f30ebc*/ void AttachObserver(Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemCentralObserver obs);
                        /*0x1f30ebc*/ void DetachObserver(Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemCentralObserver obs);
                    }

                    interface IObservableActiveAssetRequest
                    {
                        /*0x1f2fe14*/ bool get_Canceled();
                        /*0x1f2ffc8*/ UnityEngine.ResourceManagement.EA.ResourcePriority get_Priority();
                        /*0x1f30214*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> get_RequestedLocations();
                        /*0x1f30804*/ float get_NormalizedRequestProgress();
                        /*0x1f30214*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequest get_AssetRequest();
                        uint get_Id();
                        /*0x1f2ffc8*/ Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequestType get_RequestType();
                        long get_DownloadSizeBytes();
                        /*0x1f2ffc8*/ int get_NumRequestsToComplete();
                        /*0x1f2ffc8*/ int get_CompletedRequestsCount();
                        Packages.EA.PopCap.AddressablesAssets.Runtime.FailedHandleData get_MostRecentlyFailedHandle();
                        /*0x1f309e4*/ void OnRequestCannotBeRecovered();
                    }

                    interface IInstanceMemoryMonitor
                    {
                        /*0x1f30214*/ UnityEngine.ResourceManagement.EA.IExternalAllocationReporter get_ExternalAllocationReporter();
                        /*0x1f30214*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAllocationMonitor get_AllocationMonitor();
                    }

                    interface IInstanceFactory
                    {
                        /*0x1f30394*/ UnityEngine.GameObject CloneInstance(UnityEngine.GameObject originalGameObject, UnityEngine.Transform parentTransform);
                        UnityEngine.GameObject CloneInstance(UnityEngine.GameObject originalGameObject, UnityEngine.Transform parentTransform, bool instantiateInWorldSpace);
                        /*0x1ffc854*/ UnityEngine.GameObject CloneInstance(UnityEngine.GameObject originalGameObject, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiationParameters);
                        /*0x1f30ebc*/ void ReleaseInstance(UnityEngine.GameObject gameObject);
                    }

                    class PopCapInstanceFactory : UnityEngine.ResourceManagement.ResourceProviders.IInstanceProvider, Packages.EA.PopCap.AddressablesAssets.Runtime.IInstanceFactory, Packages.EA.PopCap.AddressablesAssets.Runtime.IInstanceMemoryMonitor
                    {
                        static string UnityCloneTag = "(Clone)";
                        static string PuppetTemplateTag = " [Template]";
                        static int DefaultTrackerCapacity = 512;
                        /*0x10*/ System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject>> _instanceObjectToPrefabHandle;
                        /*0x18*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ExternalAllocationReporter _externalAllocationReporter;

                        static /*0x2bd5164*/ void DestroyInstance(UnityEngine.Object instance);
                        static /*0x2bd4e48*/ string SanitizeGameObjectName(string name);
                        /*0x2bd520c*/ PopCapInstanceFactory();
                        /*0x2bd4a5c*/ UnityEngine.ResourceManagement.EA.IExternalAllocationReporter get_ExternalAllocationReporter();
                        /*0x2bd4a64*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAllocationMonitor get_AllocationMonitor();
                        /*0x2bd4a7c*/ UnityEngine.GameObject CloneInstance(UnityEngine.GameObject originalGameObject, UnityEngine.Transform parentTransform);
                        /*0x2bd4ae0*/ UnityEngine.GameObject CloneInstance(UnityEngine.GameObject originalGameObject, UnityEngine.Transform parentTransform, bool instantiateInWorldSpace);
                        /*0x2bd4b44*/ UnityEngine.GameObject CloneInstance(UnityEngine.GameObject originalGameObject, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiationParameters);
                        /*0x2bd4ee0*/ UnityEngine.GameObject ProvideInstance(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> prefabHandle, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters);
                        /*0x2bd4cbc*/ UnityEngine.GameObject ProvideInstance(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.GameObject> prefabHandle, UnityEngine.ResourceManagement.ResourceProviders.InstantiationParameters instantiateParameters);
                        /*0x2bd4f1c*/ void ReleaseInstance(UnityEngine.GameObject instance);
                        /*0x2bd4f8c*/ void ReleaseInstance(UnityEngine.ResourceManagement.ResourceManager resourceManager, UnityEngine.GameObject instance);
                    }

                    struct ResourceCollection : Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>>>, System.Collections.IEnumerable
                    {
                        static /*0x0*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollection <Empty>k__BackingField;
                        /*0x10*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollectionImpl _resourceCollectionImpl;

                        static /*0x2bd6828*/ ResourceCollection();
                        static /*0x2bd52cc*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollection get_Empty();
                        static /*0x2bd6130*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollection MergeCollections(ref Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollection rc1, ref Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollection rc2);
                        static /*0x2bd62b0*/ void GenerateCollectionIfDefaultEmptyCollection(ref Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollection rc);
                        static /*0x2bd63b0*/ void PopulateHandlesFromCollection(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>> handles, ref Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollection rc);
                        static /*0x2bd6798*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollection MergeCollections(ref Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollection rc1, ref Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollection rc2, ref Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollection rc3);
                        /*0x2bc8724*/ ResourceCollection(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>> handles);
                        /*0x2bd5420*/ ResourceCollection(Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollectionImpl impl);
                        /*0x2bc85d4*/ void ReleaseAll(bool evict);
                        /*0x2bd5714*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle GetFirst(string name);
                        /*0x2bd57fc*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle GetOneHandleAndReleaseAllOthers(string name);
                        /*0x2bd5d20*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>>> GetEnumerator();
                        /*0x2bd5da0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                        /*0x2bd5dfc*/ int get_Count();
                        /*0x2bd5e60*/ bool ContainsKey(string key);
                        /*0x2bd5ecc*/ bool IsNullOrEmpty();
                        /*0x2bd5f48*/ bool TryGetValue(string key, ref System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle> value);
                        /*0x2bd5fe8*/ System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle> get_Item(string key);
                        /*0x2bd6068*/ System.Collections.Generic.IEnumerable<string> get_Keys();
                        /*0x2bd60cc*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>> get_Values();
                    }

                    class ResourceCollectionImpl : Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>>>, System.Collections.IEnumerable, Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollectionInternal
                    {
                        /*0x10*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>> _resources;

                        /*0x2bd5324*/ ResourceCollectionImpl(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>> resources);
                        /*0x2bd5428*/ void ReleaseAll(bool evict);
                        /*0x2bd5728*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle GetFirst(string name);
                        /*0x2bd5810*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle GetOneHandleAndReleaseAllOthers(string name);
                        /*0x2bd5d34*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>>> GetEnumerator();
                        /*0x2bd6c60*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                        /*0x2bd5e10*/ int get_Count();
                        /*0x2bd5e74*/ bool ContainsKey(string key);
                        /*0x2bd6c64*/ bool IsNullOrEmpty();
                        /*0x2bd5f5c*/ bool TryGetValue(string key, ref System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle> value);
                        /*0x2bd5ffc*/ System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle> get_Item(string key);
                        /*0x2bd607c*/ System.Collections.Generic.IEnumerable<string> get_Keys();
                        /*0x2bd60e0*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>> get_Values();
                        /*0x2bd6c8c*/ void Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollectionInternal.Add(string key, Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle handle);
                        /*0x2bd693c*/ void AssignCollectionToHandles();

                        class <GetEnumerator>d__5 : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>>>, System.Collections.IEnumerator, System.IDisposable
                        {
                            /*0x10*/ int <>1__state;
                            /*0x18*/ System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>> <>2__current;
                            /*0x28*/ Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceCollectionImpl <>4__this;
                            /*0x30*/ System.Collections.Generic.Dictionary.Enumerator<string, System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>> <>7__wrap1;

                            /*0x2bd6c38*/ <GetEnumerator>d__5(int <>1__state);
                            /*0x2bd6d94*/ void System.IDisposable.Dispose();
                            /*0x2bd6db0*/ bool MoveNext();
                            /*0x2bd7120*/ void <>m__Finally1();
                            /*0x2bd7170*/ System.Collections.Generic.KeyValuePair<string, System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Collections.Generic.IReadOnlyList<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle>>>.get_Current();
                            /*0x2bd717c*/ void System.Collections.IEnumerator.Reset();
                            /*0x2bd71b4*/ object System.Collections.IEnumerator.get_Current();
                        }
                    }

                    class ResourceError : Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceError
                    {
                        /*0x10*/ int <ErrorCode>k__BackingField;
                        /*0x18*/ string <ResourceName>k__BackingField;
                        /*0x20*/ string <ErrorMessage>k__BackingField;

                        /*0x2bd7210*/ ResourceError();
                        /*0x2bc6ce8*/ ResourceError(string resourceId, System.Exception exception);
                        /*0x2bd7218*/ ResourceError(string resourceId, string message, Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceError.ResourceErrorType errorType);
                        /*0x2bd726c*/ int get_ErrorCode();
                        /*0x2bd7274*/ string get_ResourceName();
                        /*0x2bd727c*/ string get_ErrorMessage();

                        enum ResourceErrorType
                        {
                            InvalidResourceName = 1,
                        }
                    }

                    class ResourceHandle : Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle, Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandleInternal
                    {
                        static string InvalidHandleName = "<INVALID RESOURCE>";
                        /*0x10*/ System.WeakReference<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection> _ownerCollection;
                        /*0x18*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation <OriginatingLocation>k__BackingField;
                        /*0x20*/ UnityEngine.GameObject _gameObject;
                        /*0x28*/ bool <IsOriginalResourceHandle>k__BackingField;
                        /*0x29*/ bool <IsPrefabInstance>k__BackingField;
                        /*0x30*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle <OriginatingAddressablesHandle>k__BackingField;
                        /*0x48*/ bool <IsValid>k__BackingField;
                        /*0x49*/ bool <Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandleInternal.WasHidden>k__BackingField;

                        /*0x2bc85ec*/ ResourceHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle resource, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation originatingLocation);
                        /*0x2bd728c*/ ResourceHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle sourceHandle, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation originatingLocation, UnityEngine.GameObject instance);
                        /*0x2bd7284*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation get_OriginatingLocation();
                        /*0x2bd730c*/ bool get_IsGameObject();
                        /*0x2bd737c*/ bool get_IsOriginalResourceHandle();
                        /*0x2bd7384*/ bool get_IsPrefabInstance();
                        /*0x2bd738c*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle get_OriginatingAddressablesHandle();
                        /*0x2bd73a0*/ string get_Name();
                        /*0x2bd753c*/ bool get_IsValid();
                        /*0x2bd7544*/ void set_IsValid(bool value);
                        /*0x2bd744c*/ UnityEngine.Object get_Resource();
                        /*0x2bd754c*/ bool Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandleInternal.get_WasHidden();
                        /*0x2bd7554*/ void Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandleInternal.set_WasHidden(bool value);
                        /*0x2bc8de4*/ UnityEngine.GameObject get_GO();
                        /*0x2bd755c*/ void Release(bool evict);
                        /*0x2bd766c*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle Clone();
                        /*0x2bd780c*/ System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle> Clone(int instancesToClone);
                        /*0x2bd7694*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandle CloneInternal();
                        /*0x2bd78e0*/ void PropagateClonedHandleToCollections(Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceHandle handle);
                        /*0x2bd7a94*/ void Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandleInternal.SetOwnerCollection(Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceCollection collection);
                        /*0x2bd7b18*/ void Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceHandleInternal.HideHandle();
                    }

                    class AssetBundleRequestOptionsPreparerStep : Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceLocationPreparerStep
                    {
                        /*0x2bd80a4*/ AssetBundleRequestOptionsPreparerStep();
                        /*0x2bd7bec*/ void Prepare(ref Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceLocationPreparerData data, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                        /*0x2bd80ac*/ void Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceLocationPreparerStep.Prepare(ref Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceLocationPreparerData data, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                    }

                    interface IResourceLocationPreparerStep
                    {
                        /*0x1f30ff0*/ void Prepare(ref Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceLocationPreparerData data, UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                    }

                    class ResourceLocationPreparer : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemInitializable
                    {
                        /*0x10*/ System.Collections.Generic.List<Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceLocationPreparerStep> _resourceLocationPreparers;

                        /*0x2bcdc68*/ ResourceLocationPreparer();
                        /*0x2bcce60*/ void Initialize(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetManagementContext context);
                        /*0x2bcd2cc*/ void PrepareResourceLocations(Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceLocationPreparerData preparerData, System.Collections.Generic.IList<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locationsList);
                    }

                    struct ResourceLocationPreparerData
                    {
                        /*0x10*/ UnityEngine.ResourceManagement.EA.ResourcePriority Priority;
                        /*0x14*/ int BundleRetryCount;
                        /*0x18*/ int BundleRedirectLimit;
                        /*0x1c*/ int DownloadTimeoutInSeconds;
                    }

                    interface IResourceManagerListener : Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemInitializable, Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                    }

                    class ResourceManagerListener : Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceManagerListener, Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemInitializable, Packages.EA.PopCap.AddressablesAssets.Runtime.ISoftResetListener
                    {
                        static /*0x2bd8190*/ void ResourceManagerExceptionHandler(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle op, System.Exception ex);
                        /*0x2bcdc58*/ ResourceManagerListener();
                        /*0x2bd80b0*/ void Initialize(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetManagementContext context);
                        /*0x2bd82d4*/ void OnSoftReset();
                    }

                    class ResourceReleaseRouter : Packages.EA.PopCap.AddressablesAssets.Runtime.IResourceReleaseRouter, Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetSystemInitializable
                    {
                        /*0x10*/ Packages.EA.PopCap.AddressablesAssets.Runtime.IAssetCacheController _assetCache;

                        /*0x2bcdc60*/ ResourceReleaseRouter();
                        /*0x2bd8368*/ void ReleaseHandle(Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceHandle resourceHandle);
                        /*0x2bd8440*/ void ReturnResourceToAddressables(Packages.EA.PopCap.AddressablesAssets.Runtime.ResourceHandle resourceHandle);
                        /*0x2bd8520*/ void Initialize(Packages.EA.PopCap.AddressablesAssets.Runtime.AssetManagementContext context);
                    }

                    class AddressablesResourceUtils
                    {
                        static /*0x2bc6f44*/ void ReleaseHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle);
                        static /*0x2bd8538*/ int CalculateCachedFilesCount(System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations);
                    }

                    class AssetRequestFilterer
                    {
                        static /*0x2bd8590*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> FilterOutLocations(System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequestFilterer.FilterOptions filterOptions);
                        static /*0x2bd8594*/ System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> FilterLocations(System.Collections.Generic.List<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> locations, Packages.EA.PopCap.AddressablesAssets.Runtime.AssetRequestFilterer.FilterOptions filterOptions);

                        enum FilterOptions
                        {
                            None = 0,
                            RemoveDownloads = 1,
                            KeepOnlyDownloads = 2,
                        }
                    }
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 68F63CDB441A598C6E11DE3763C7C07AB8CF05D3F6BE948453BB82C7A7390A86;
    static /*0x1eee*/ <PrivateImplementationDetails> AA58FF12C6B63977271A8A79E7FCB4DECA3367F5F091B54401AB8F1993AA52E5;

    struct __StaticArrayInitTypeSize=6110
    {
    }

    struct __StaticArrayInitTypeSize=7918
    {
    }
}
