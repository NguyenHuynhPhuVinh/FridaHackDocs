class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3c6e598*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x3c6e5a0*/ NullableAttribute(byte );
                /*0x3c6e628*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x3c6e658*/ NullableContextAttribute(byte );
            }
        }
    }
}

class AddressablesDownloader
{
    static int CalculateChunkSize = 32;
    /*0x10*/ UniRx.Subject<AddressablesDownloader.RemoteAssetLoadProgress> onDownloadProgressSubject;
    /*0x18*/ System.Threading.CancellationTokenSource calculateSource;
    /*0x20*/ string hashPattern;

    static /*0x3c6f18c*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> <CalculateAllDownloadSize>g__GetAllDependenciesRecursive|5_2(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, System.Collections.Generic.HashSet<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> visited);
    /*0x3c6f0e0*/ AddressablesDownloader();
    /*0x3c6e680*/ System.IObservable<AddressablesDownloader.RemoteAssetLoadProgress> OnDownloadProgress();
    /*0x3c6e6f0*/ Cysharp.Threading.Tasks.UniTask<AddressablesDownloader.AddresssablesDownloaderViewModel> CalculateAllDownloadSize();
    /*0x3c6e7f4*/ Cysharp.Threading.Tasks.UniTask<AddressablesDownloader.AddresssablesDownloaderViewModel> CalculateDownloadSize(System.Collections.Generic.IEnumerable<object> keys);
    /*0x3c6e90c*/ void CancelDownloadSizeCalculation();
    /*0x3c6e948*/ Cysharp.Threading.Tasks.UniTask<bool> Download(AddressablesDownloader.AddresssablesDownloaderViewModel model);
    /*0x3c6ea40*/ long GetFreeDiskSpace();
    /*0x3c6ef10*/ Cysharp.Threading.Tasks.UniTask<AddressablesDownloader.AddresssablesDownloaderViewModel> CalculateDownloadSize(System.Collections.Generic.List<object> keys, System.Threading.CancellationToken token);
    /*0x3c6f028*/ float GetSpentTime(System.DateTime startTime);

    class RemoteAssetLoadProgress
    {
        /*0x10*/ long <Max>k__BackingField;
        /*0x18*/ long <Current>k__BackingField;
        /*0x20*/ float <SpentTimeSec>k__BackingField;
        /*0x24*/ bool <HasError>k__BackingField;

        /*0x3c6f29c*/ RemoteAssetLoadProgress();
        /*0x3c6f258*/ long get_Max();
        /*0x3c6f260*/ void set_Max(long value);
        /*0x3c6f268*/ long get_Current();
        /*0x3c6f270*/ void set_Current(long value);
        /*0x3c6f278*/ float get_SpentTimeSec();
        /*0x3c6f280*/ void set_SpentTimeSec(float value);
        /*0x3c6f288*/ bool get_HasError();
        /*0x3c6f290*/ void set_HasError(bool value);
    }

    class AddresssablesDownloaderViewModel
    {
        /*0x10*/ long <Size>k__BackingField;
        /*0x18*/ System.Collections.Generic.List<object> <Keys>k__BackingField;

        /*0x3c6f2c4*/ AddresssablesDownloaderViewModel();
        /*0x3c6f2a4*/ long get_Size();
        /*0x3c6f2ac*/ void set_Size(long value);
        /*0x3c6f2b4*/ System.Collections.Generic.List<object> get_Keys();
        /*0x3c6f2bc*/ void set_Keys(System.Collections.Generic.List<object> value);
    }

    class <<CalculateAllDownloadSize>g__GetAllDependenciesRecursive|5_2>d : System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation <>2__current;
        /*0x20*/ int <>l__initialThreadId;
        /*0x28*/ System.Collections.Generic.HashSet<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> visited;
        /*0x30*/ System.Collections.Generic.HashSet<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> <>3__visited;
        /*0x38*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location;
        /*0x40*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation <>3__location;
        /*0x48*/ System.Collections.Generic.IEnumerator<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> <>7__wrap1;
        /*0x50*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation <dep>5__3;
        /*0x58*/ System.Collections.Generic.IEnumerator<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> <>7__wrap3;

        /*0x3c6f224*/ <<CalculateAllDownloadSize>g__GetAllDependenciesRecursive|5_2>d(int <>1__state);
        /*0x3c6f2cc*/ void System.IDisposable.Dispose();
        /*0x3c6f380*/ bool MoveNext();
        /*0x3c6fac4*/ void <>m__Finally1();
        /*0x3c6fa14*/ void <>m__Finally2();
        /*0x3c6fb74*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation System.Collections.Generic.IEnumerator<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>.get_Current();
        /*0x3c6fb7c*/ void System.Collections.IEnumerator.Reset();
        /*0x3c6fbb4*/ object System.Collections.IEnumerator.get_Current();
        /*0x3c6fbbc*/ System.Collections.Generic.IEnumerator<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>.GetEnumerator();
        /*0x3c6fc70*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
    }

    class <>c
    {
        static /*0x0*/ AddressablesDownloader.<> <>9;
        static /*0x8*/ System.Func<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator, System.Collections.Generic.IEnumerable<object>> <>9__5_0;
        static /*0x10*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, bool> <>9__5_3;
        static /*0x18*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> <>9__5_4;
        static /*0x20*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, bool> <>9__5_5;
        static /*0x28*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> <>9__5_6;

        static /*0x3c6fc74*/ <>c();
        /*0x3c6fcdc*/ <>c();
        /*0x3c6fce4*/ System.Collections.Generic.IEnumerable<object> <CalculateAllDownloadSize>b__5_0(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator);
        /*0x3c6fd84*/ bool <CalculateAllDownloadSize>b__5_3(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
        /*0x3c6fe24*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> <CalculateAllDownloadSize>b__5_4(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
        /*0x3c6fe30*/ bool <CalculateAllDownloadSize>b__5_5(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
        /*0x3c6fee0*/ string <CalculateAllDownloadSize>b__5_6(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
    }

    class <>c__DisplayClass5_0
    {
        /*0x10*/ AddressablesDownloader <>4__this;
        /*0x18*/ System.Collections.Generic.HashSet<string> seenBundleIds;
        /*0x20*/ System.Func<string, bool> <>9__7;

        /*0x3c6ff7c*/ <>c__DisplayClass5_0();
        /*0x3c6ff84*/ bool <CalculateAllDownloadSize>b__1(string key);
        /*0x3c70000*/ bool <CalculateAllDownloadSize>b__7(string id);
    }

    class <>c__DisplayClass8_0
    {
        /*0x10*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle;
        /*0x28*/ long lastDownloaded;
        /*0x30*/ AddressablesDownloader <>4__this;
        /*0x38*/ long maxSize;
        /*0x40*/ System.DateTime startTime;

        /*0x3c70058*/ <>c__DisplayClass8_0();
        /*0x3c70060*/ bool <Download>b__0();
    }

    struct <CalculateAllDownloadSize>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<AddressablesDownloader.AddresssablesDownloaderViewModel> <>t__builder;
        /*0x30*/ AddressablesDownloader <>4__this;
        /*0x38*/ AddressablesDownloader.<> <>8__1;
        /*0x40*/ System.Threading.CancellationToken <token>5__2;
        /*0x48*/ System.Collections.Generic.List<object> <resultKeys>5__3;
        /*0x50*/ System.Collections.Generic.List<string> <keys>5__4;
        /*0x58*/ int <i>5__5;
        /*0x60*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
        /*0x70*/ Cysharp.Threading.Tasks.UniTask.Awaiter<AddressablesDownloader.AddresssablesDownloaderViewModel> <>u__2;

        /*0x3c70174*/ void MoveNext();
        /*0x3c718c0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <CalculateDownloadSize>d__10 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<AddressablesDownloader.AddresssablesDownloaderViewModel> <>t__builder;
        /*0x30*/ System.Collections.Generic.List<object> keys;
        /*0x38*/ System.Threading.CancellationToken token;
        /*0x40*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> <handle>5__2;
        /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<long> <>u__1;

        /*0x3c71918*/ void MoveNext();
        /*0x3c71f08*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <CalculateDownloadSize>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<AddressablesDownloader.AddresssablesDownloaderViewModel> <>t__builder;
        /*0x30*/ AddressablesDownloader <>4__this;
        /*0x38*/ System.Collections.Generic.IEnumerable<object> keys;
        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<AddressablesDownloader.AddresssablesDownloaderViewModel> <>u__1;

        /*0x3c71f60*/ void MoveNext();
        /*0x3c72548*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <Download>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        /*0x30*/ AddressablesDownloader <>4__this;
        /*0x38*/ AddressablesDownloader.AddresssablesDownloaderViewModel model;
        /*0x40*/ AddressablesDownloader.<> <>8__1;
        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

        /*0x3c725a0*/ void MoveNext();
        /*0x3c72ce0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3c72d38*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3c72e2c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace VContainer
{
    class AssetManagementContainerBuilderExtension
    {
        static /*0x3c72e34*/ void RegisterProviders(VContainer.IContainerBuilder builder);

        class <>c
        {
            static /*0x0*/ VContainer.AssetManagementContainerBuilderExtension.<> <>9;
            static /*0x8*/ System.Func<System.Type, bool> <>9__0_0;
            static /*0x10*/ System.Func<System.Type, bool> <>9__0_1;
            static /*0x18*/ System.Func<System.Type, bool> <>9__0_2;
            static /*0x20*/ System.Func<System.Type, bool> <>9__0_3;

            static /*0x3c732bc*/ <>c();
            /*0x3c73324*/ <>c();
            /*0x3c7332c*/ bool <RegisterProviders>b__0_0(System.Type t);
            /*0x3c73370*/ bool <RegisterProviders>b__0_1(System.Type t);
            /*0x3c733d4*/ bool <RegisterProviders>b__0_2(System.Type t);
            /*0x3c73418*/ bool <RegisterProviders>b__0_3(System.Type t);
        }
    }
}

namespace Assets
{
    namespace AssetManagement
    {
        interface IAddressablesAssetProvider
        {
            /*0x380b128*/ bool get_DetailedLogging();
            /*0x380cdf0*/ void set_DetailedLogging(bool value);
            Cysharp.Threading.Tasks.UniTask Initialize(string remoteLoadPath, Assets.AssetManagement.AddressablesAssetProvider.RuntimeCachingPersistencePolicies cachePersistence, Assets.AssetManagement.AddressablesAssetProvider.UntrackedCacheLifetimeTypes untrackedCacheLifetime);
            /*0x380c9a0*/ Cysharp.Threading.Tasks.UniTask Reload();
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key, UnityEngine.GameObject owner);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key, UnityEngine.MonoBehaviour owner);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key);
            Cysharp.Threading.Tasks.UniTask<Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult> LoadSceneAsync(string key);
            /*0x380cb08*/ void ManuallyUpdateRuntimeCache();
        }

        interface IAssetInstanceProvider
        {
            Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key, bool active);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key, UnityEngine.Transform transform);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key, UnityEngine.Transform transform, bool active);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key, bool active);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key, UnityEngine.Transform transform);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key, UnityEngine.Transform transform, bool active);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args, bool active);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args, UnityEngine.Transform transform);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args, UnityEngine.Transform transform, bool active);
        }

        class AddressablesAssetProvider : Assets.AssetManagement.IAddressablesAssetProvider, Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSAssetProvider, Assets.AssetManagement.IAssetInstanceProvider
        {
            /*0x10*/ System.Collections.Generic.Dictionary<object, Assets.AssetManagement.AddressablesAssetProvider.OperationCacheData> assetCache;
            /*0x18*/ object locked;
            /*0x20*/ bool <DetailedLogging>k__BackingField;
            /*0x24*/ Assets.AssetManagement.AddressablesAssetProvider.RuntimeCachingPersistencePolicies cachePersistence;
            /*0x28*/ int untrackedCacheLifetime;
            /*0x2c*/ bool operationInProgress;

            /*0x3c7423c*/ AddressablesAssetProvider();
            /*0x3c7347c*/ bool get_DetailedLogging();
            /*0x3c73484*/ void set_DetailedLogging(bool value);
            /*0x3c73490*/ Cysharp.Threading.Tasks.UniTask Initialize(string assetUrl, Assets.AssetManagement.AddressablesAssetProvider.RuntimeCachingPersistencePolicies cachePersistence, Assets.AssetManagement.AddressablesAssetProvider.UntrackedCacheLifetimeTypes untrackedCacheLifetime);
            /*0x3c73574*/ Cysharp.Threading.Tasks.UniTask Reload();
            /*0x3c73604*/ Cysharp.Threading.Tasks.UniTask<Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult> LoadSceneAsync(string key);
            /*0x3c7371c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key);
            /*0x3c73898*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key, bool active);
            /*0x3c738d0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key, UnityEngine.Transform transform);
            /*0x3c73754*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key, UnityEngine.Transform transform, bool active);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key, bool active);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key, UnityEngine.Transform transform);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key, UnityEngine.Transform transform, bool active);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args, bool active);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args, UnityEngine.Transform transform);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args, UnityEngine.Transform transform, bool active);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key, UnityEngine.MonoBehaviour owner);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key, UnityEngine.GameObject owner);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key, bool increment, bool retry);
            /*0x3c73904*/ void AttachNotifyOnDestroy(object key, UnityEngine.GameObject owner);
            /*0x3c73c30*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSAssetProvider.Instantiate(object key, UnityEngine.Transform transform, bool active);
            /*0x3907c14*/ Cysharp.Threading.Tasks.UniTask<T> Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSAssetProvider.Load<T>(object key);
            /*0x3c73c64*/ void ExceptionHandler(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, System.Exception exception);
            /*0x3c73cf0*/ void ManuallyUpdateRuntimeCache();

            class OperationCacheData
            {
                /*0x10*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle <OperationHandle>k__BackingField;
                /*0x28*/ int <ReferenceCount>k__BackingField;
                /*0x2c*/ int <UntrackedLifetime>k__BackingField;
                /*0x30*/ bool <Untracked>k__BackingField;

                /*0x3c74364*/ OperationCacheData();
                /*0x3c742fc*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle get_OperationHandle();
                /*0x3c74310*/ void set_OperationHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle value);
                /*0x3c74330*/ int get_ReferenceCount();
                /*0x3c74338*/ void set_ReferenceCount(int value);
                /*0x3c74340*/ int get_UntrackedLifetime();
                /*0x3c74348*/ void set_UntrackedLifetime(int value);
                /*0x3c74350*/ bool get_Untracked();
                /*0x3c74358*/ void set_Untracked(bool value);
            }

            enum RuntimeCachingPersistencePolicies
            {
                Auto = 0,
                Manual = 1,
            }

            enum UntrackedCacheLifetimeTypes
            {
                None = 0,
                SingleSceneTransition = 1,
                DoubleSceneTransition = 2,
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<UnityEngine.ResourceManagement.ResourceProviders.SceneInstance> operation;

                /*0x3c7436c*/ <>c__DisplayClass11_0();
                /*0x3c74374*/ bool <LoadSceneAsync>b__0();
            }

            class <>c__DisplayClass27_0<T>
            {
                /*0x0*/ Assets.AssetManagement.AddressablesAssetProvider <>4__this;
                /*0x0*/ Assets.AssetManagement.AddressablesAssetProvider.OperationCacheData cache;

                /*0x380cb08*/ <>c__DisplayClass27_0();
                /*0x380b128*/ bool <Load>b__0();
                /*0x380b128*/ bool <Load>b__1();
            }

            class <>c__DisplayClass28_0
            {
                /*0x10*/ Assets.AssetManagement.AddressablesAssetProvider <>4__this;
                /*0x18*/ object key;

                /*0x3c73af4*/ <>c__DisplayClass28_0();
                /*0x3c743bc*/ void <AttachNotifyOnDestroy>b__0();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ string assetUrl;
                /*0x18*/ Assets.AssetManagement.AddressablesAssetProvider <>4__this;

                /*0x3c745bc*/ <>c__DisplayClass9_0();
                /*0x3c745c4*/ string <Initialize>g__InternalIdTransformFunc|0(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x3c74714*/ void <Initialize>b__1(UnityEngine.SceneManagement.Scene _);
            }

            struct <Initialize>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ string assetUrl;
                /*0x30*/ Assets.AssetManagement.AddressablesAssetProvider <>4__this;
                /*0x38*/ Assets.AssetManagement.AddressablesAssetProvider.<> <>8__1;
                /*0x40*/ Assets.AssetManagement.AddressablesAssetProvider.UntrackedCacheLifetimeTypes untrackedCacheLifetime;
                /*0x44*/ Assets.AssetManagement.AddressablesAssetProvider.RuntimeCachingPersistencePolicies cachePersistence;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3c7472c*/ void MoveNext();
                /*0x3c7540c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Instantiate>d__15 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
                /*0x30*/ Assets.AssetManagement.AddressablesAssetProvider <>4__this;
                /*0x38*/ object key;
                /*0x40*/ bool active;
                /*0x48*/ UnityEngine.Transform transform;
                /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x3c75418*/ void MoveNext();
                /*0x3c75b60*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InstantiateComponent>d__19<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ Assets.AssetManagement.AddressablesAssetProvider <>4__this;
                /*0x0*/ object key;
                /*0x0*/ UnityEngine.Transform transform;
                /*0x0*/ bool active;
                /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x380cb08*/ void MoveNext();
                /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <InstantiateUCS>d__23<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ Assets.AssetManagement.AddressablesAssetProvider <>4__this;
                /*0x0*/ object key;
                /*0x0*/ UnityEngine.Transform transform;
                /*0x0*/ object args;
                /*0x0*/ bool active;
                /*0x0*/ T <component>5__2;
                /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> <>u__1;
                /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<bool> <>u__2;

                /*0x380cb08*/ void MoveNext();
                /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Load>d__26<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ Assets.AssetManagement.AddressablesAssetProvider <>4__this;
                /*0x0*/ object key;
                /*0x0*/ UnityEngine.GameObject owner;
                /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> <>u__1;

                /*0x380cb08*/ void MoveNext();
                /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Load>d__27<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ Assets.AssetManagement.AddressablesAssetProvider <>4__this;
                /*0x0*/ object key;
                /*0x0*/ Assets.AssetManagement.AddressablesAssetProvider.<>c__DisplayClass27_0<T> <>8__1;
                /*0x0*/ bool increment;
                /*0x0*/ bool retry;
                /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;
                /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> <>u__2;

                /*0x380cb08*/ void MoveNext();
                /*0x380d83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <LoadSceneAsync>d__11 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult> <>t__builder;
                /*0x30*/ Assets.AssetManagement.AddressablesAssetProvider <>4__this;
                /*0x38*/ string key;
                /*0x40*/ Assets.AssetManagement.AddressablesAssetProvider.<> <>8__1;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3c75bb8*/ void MoveNext();
                /*0x3c76210*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Reload>d__10 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> <handle>5__2;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3c76268*/ void MoveNext();
                /*0x3c76858*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class AddressablesKeyProvider : Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSAssetKeyProvider, Assets.AssetManagement.IAddressablesKeyProvider
        {
            /*0x10*/ bool isRated;

            static /*0x3c76b14*/ string AcquireGameUiAssetKey(string name);
            /*0x3c79638*/ AddressablesKeyProvider();
            /*0x3c76864*/ void Initialize(bool rated);
            /*0x3c76870*/ string TryAcquireThingThumbnailKey(Assets.Api.Client.ThingTypes type, string assetId);
            /*0x3c76a24*/ string AcquireBackgroundAssetKeyByType(Assets.Api.Client.BackgroundAssetTypes type, string key);
            /*0x3c76ab8*/ string AcquireSceneKey(string sceneName);
            /*0x3c76ac0*/ string AcquireKey(string key);
            /*0x3c76b0c*/ string SceneKeyToSceneName(string key);
            /*0x3c76b60*/ string AcquireMainChapterBackgroundAssetKey(string key);
            /*0x3c76bac*/ string AcquireAdventureBackgroundAssetKey(string key);
            /*0x3c76bf8*/ string AcquireMemoryBackgroundKey(string key);
            /*0x3c76c44*/ string AcquireQuestTopBackgroundKey(string key);
            /*0x3c76c90*/ string AcquireShopBackgroundAssetKey(string key);
            /*0x3c76cdc*/ string AcquireFunctionalBackgroundAssetKey(string key);
            /*0x3c76d28*/ string AcquireMazeGuarderIllustBackgroundKey(string key);
            /*0x3c76d74*/ string AcquireItemIconKey(string key);
            /*0x3c76dc0*/ string AcquireItemBigIconKey(string key);
            /*0x3c76e0c*/ string AcquireGemIconKey();
            /*0x3c76e4c*/ string AcquireOreIconKey();
            /*0x3c76e8c*/ string AcquireMoneyIconKey();
            /*0x3c76ecc*/ string AcquireExpIconKey();
            /*0x3c76f0c*/ string AcquireCircleExpIconKey();
            /*0x3c76f4c*/ string AcquireTrophyIconKey();
            /*0x3c76f8c*/ string AcquireLocationUnlockPointIconKey();
            /*0x3c76fcc*/ string AcquireThumbnailFrameIconKey();
            /*0x3c7700c*/ string AcquireEmotionVfxTemplateKey();
            /*0x3c7704c*/ string AcquireIconFrameIconKey(string key);
            /*0x3c77098*/ string AcquireVipKey(string key);
            /*0x3c770e4*/ string AcquireTrophyKey(string key);
            /*0x3c77130*/ string AcquireEmptyTrophyKey();
            /*0x3c77170*/ string AcquireTrophyFrameKey(string key);
            /*0x3c771bc*/ string AcquireTrophyStageKey(string key);
            /*0x3c77208*/ string AcquireTeamEmblemKey(string key);
            /*0x3c77254*/ string AcquireCharacterNamePlateKey(string key);
            /*0x3c772a0*/ string AcquireSchoolLogoKey(string key);
            /*0x3c772ec*/ string AcquireTeamLogoKey(string key);
            /*0x3c77338*/ string AcquireTeamIconKey(string key);
            /*0x3c77384*/ string AcquireRelicIconKey(string key);
            /*0x3c773d0*/ string AcquireStampKey(string key);
            /*0x3c7741c*/ string AcquireTrackTextureKey(string key);
            /*0x3c77468*/ string AcquireMainChapterThumbnailAssetKey(string key);
            /*0x3c774b4*/ string AcquireMainEpisodeThumbnailAssetKey(string key);
            /*0x3c77500*/ string AcquireActorIconKey(string key);
            /*0x3c7754c*/ string AcquireQueueIconKey(string key);
            /*0x3c77598*/ string AcquireShopThumbnailAssetKey(string key);
            /*0x3c775e4*/ string AcquireShopProductIconAssetKey(string key);
            /*0x3c77630*/ string AcquireShopShochikubaiThumbnailAssetKey(string key);
            /*0x3c7767c*/ string AcquireExrtraSkillThumbnailAssetKey(string key);
            /*0x3c776c8*/ string AcquireStillThumbnailXAssetKey(string key);
            /*0x3c77714*/ string AcquireSceneThumbnailXAssetKey(string key);
            /*0x3c77760*/ string AcquireCharacterBackgroundXAssetKey(string key);
            /*0x3c777ac*/ string AcquireMazeRouteThumbnailKey(string key);
            /*0x3c777f8*/ string AcquireSpotAreaThumbnailKey(string key);
            /*0x3c77844*/ string AcquireSpotAreaPointThumbnailKey(string key);
            /*0x3c77890*/ string AcquireTypeEquipmentIconKey(string key);
            /*0x3c778dc*/ string AcquireMazeBonusIconKey(string key);
            /*0x3c77928*/ string AcquireMazeEncountBackgroundAssetKey(string key);
            /*0x3c77974*/ string AcquireModuleIconKey(string key);
            /*0x3c779c0*/ string AcquireCircleIconAssetKey(string key);
            /*0x3c77a0c*/ string AcquireMazeGuarderThumbnailKey(string key);
            /*0x3c77a58*/ string AcquireMazeGuarderIllustThumbnailAssetKey(string key);
            /*0x3c77aa4*/ string AcquireAdventureIllustThumbnailAssetKey(string key);
            /*0x3c77af0*/ string AcquireCharacterSquareIllustAssetKey(string key);
            /*0x3c77b3c*/ string AcquireCharacterVerticalIllustAssetKey(string key);
            /*0x3c77b88*/ string AcquireMachineSquareIllustAssetKey(string key);
            /*0x3c77bd4*/ string AcquireMemorySquareIllustAssetKey(string key);
            /*0x3c77c20*/ string AcquireCharacterStandSpineKey(string key);
            /*0x3c77c6c*/ string AcquireCharacterBackStandSpineKey(string key);
            /*0x3c77cb8*/ string AcquireBackgoundCharacterSpineKey(string key);
            /*0x3c77d04*/ string AcquireBackgroundSceneSpineKey(string key);
            /*0x3c77df0*/ string AcquireBattleCockpitKey(string key);
            /*0x3c77e3c*/ string AcquireBattleMecanimKey(string key);
            /*0x3c77e88*/ string AcquireBattleExtraSkillSpineKey(string key);
            /*0x3c77ed4*/ string AcquireSystemSpineKey(string key);
            /*0x3c77f20*/ string AcquireFunctionalBackgroundBuiltInImageKey(string key);
            /*0x3c77f6c*/ string AcquireFunctionalBackgroundMemoryImageKey(string key);
            /*0x3c77fb8*/ string AcquireFunctionalBackgroundSpotAreaImageKey(string key);
            /*0x3c78004*/ string AcquireBgmKey(string key);
            /*0x3c78050*/ string AcquireScenarioVoiceKey(string key);
            /*0x3c780bc*/ string AcquireTalkVoiceKey(string key, string key2);
            /*0x3c78130*/ string AcquireSystemVoiceKey(string key);
            /*0x3c7817c*/ string AcquireSystemVoiceKey(string assetId, string key);
            /*0x3c7822c*/ string AcquireCharacterSystemVoiceKey(string characterId, string key);
            /*0x3c782dc*/ string AcquireCharacterSystemVoiceKey(long characterId, string key);
            /*0x3c783ac*/ string AcquireCharacterMiscellaneousVoiceKey(long characterId, string key);
            /*0x3c7847c*/ string AcquireCharacterMiscellaneousVoiceKey(string characterId, string key);
            /*0x3c7852c*/ string AcquireCharacterBattleVoiceKey(long characterId, string key);
            /*0x3c785fc*/ string AcquireCharacterBattleVoiceKey(string characterId, string key);
            /*0x3c786ac*/ string AcquireCharacterVoiceKey(string assetId, string key);
            /*0x3c78720*/ string AcquireScenarioSoundEffectKey(string key);
            /*0x3c7876c*/ string AcquireSoundEffectKey(string key);
            /*0x3c787d8*/ string AcquireAnimationAssetKey(string key);
            /*0x3c78824*/ string AcquireAttributeTextureKey(Assets.Api.Client.CharacterAttributes attribute);
            /*0x3c78904*/ string AcquireRoleTextureKey(Assets.Api.Client.CharacterRoleTypes role);
            /*0x3c789d8*/ string AcquireRoundTextureKey(string key);
            /*0x3c78a44*/ string AcquireRarityTextureKey(string key);
            /*0x3c78ab0*/ string AcquireRarityHorizontalTextureKey(string key);
            /*0x3c78b1c*/ string AcquireAttributeTextureKey(string key);
            /*0x3c78b88*/ string AcquireBgIconKey(string key);
            /*0x3c78bf4*/ string AcquireFrameIconKey(string key);
            /*0x3c78c60*/ string AcquireBadgeTextureKey(string key);
            /*0x3c78ccc*/ string AcquireGachaFrameTextureKey(string key);
            /*0x3c78d38*/ string AcquireGachaLightTextureKey(string key);
            /*0x3c78da4*/ string AcquireStyleCardFrameTextureKey(string key);
            /*0x3c78e10*/ string AcquirePartyBuffTextureKey(string key);
            /*0x3c78e7c*/ string AcquireCharacterTypeTextureKey(string key);
            /*0x3c78ee8*/ string AcquireEpisodeIconTextureKey();
            /*0x3c78f28*/ string AcquireSkillTextureKey(string key);
            /*0x3c78f94*/ string AcquireOsTextureKey(string key);
            /*0x3c79000*/ string AcquireCharacterEvaluationTextureKey(string key);
            /*0x3c7906c*/ string AcquireModuleSlotTextureKey(string key);
            /*0x3c790d8*/ string AcquireDmmPointIconKey();
            /*0x3c79118*/ string AcquireScenarioPlayerIconKey();
            /*0x3c79158*/ string AcquireExtraSkillDummyKey();
            /*0x3c79198*/ string AcquireBackgroundSceneDummyKey();
            /*0x3c791d8*/ string AcquireBackgroundCharacterDummyKey();
            /*0x3c79218*/ string AcquireCharacterStandDummyKey();
            /*0x3c79258*/ string AcquirePlayerTeamIconKey();
            /*0x3c79298*/ string AcquireEnemyTeamIconKey();
            /*0x3c792d8*/ string AcquireToastTextImageKey(string key);
            /*0x3c79344*/ string AcquireRoleTextureKey(string key);
            /*0x3c793b0*/ string AcquireStatusEffectTextureKey(string key);
            /*0x3c7941c*/ string AcquireScenarioLogIconTextureKey(string key);
            /*0x3c79488*/ string AcquireLoadEventIconPartTextureKey(string key);
            /*0x3c794f4*/ string AcquireRelicCategoryTextureKey(string key);
            /*0x3c79560*/ string AcquireKindIconTextureKey(string key);
            /*0x3c795cc*/ string AcquireBadgeLabelTextureKey(string key);
            /*0x3c77d84*/ string get_Rating();
        }

        interface IDirectAssetProvider
        {
            void Initialize(string storageUrl, bool isAstcSupported, Assets.AssetManagement.DirectAssetProvider.RuntimeCachingPersistencePolicies cachePersistence, Assets.AssetManagement.DirectAssetProvider.UntrackedCacheLifetimeTypes untrackedCacheLifetime);
            Cysharp.Threading.Tasks.UniTask<string> AcquireVideoUrl(string assetKey);
            Cysharp.Threading.Tasks.UniTask<string> AcquireTextData(string assetKey);
            Cysharp.Threading.Tasks.UniTask<string> AcquireJsonData(string assetKey);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> AcquireTexture2D(string assetKey, UnityEngine.GameObject owner);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> AcquireTexture2D(string assetKey, UnityEngine.MonoBehaviour owner);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> AcquireTexture2D(string assetKey);
            /*0x380cb08*/ void ManuallyUpdateRuntimeCache();
            /*0x380cb08*/ void ClearRuntimeCache();
        }

        class DirectAssetProvider : Assets.AssetManagement.IDirectAssetProvider
        {
            static string GzCompression = "gz";
            static double CacheExpirationInDays = 7;
            /*0x10*/ Assets.Plugins.WebGl.IJSInterop jsinterop;
            /*0x18*/ string cacheDirectory;
            /*0x20*/ System.Collections.Generic.Dictionary<string, Assets.AssetManagement.DirectAssetProvider.TextureCacheData> textureCache;
            /*0x28*/ object locked;
            /*0x30*/ string storageUrl;
            /*0x38*/ bool isAstcSupported;
            /*0x3c*/ Assets.AssetManagement.DirectAssetProvider.RuntimeCachingPersistencePolicies cachePersistence;
            /*0x40*/ int untrackedCacheLifetime;

            /*0x3c79640*/ DirectAssetProvider(Assets.Plugins.WebGl.IJSInterop jsinterop);
            /*0x3c797a4*/ void Initialize(string storageUrl, bool isAstcSupported, Assets.AssetManagement.DirectAssetProvider.RuntimeCachingPersistencePolicies cachePersistence, Assets.AssetManagement.DirectAssetProvider.UntrackedCacheLifetimeTypes untrackedCacheLifetime);
            /*0x3c79d14*/ Cysharp.Threading.Tasks.UniTask<string> AcquireJsonData(string assetKey);
            /*0x3c79ec8*/ Cysharp.Threading.Tasks.UniTask<string> AcquireTextData(string assetKey);
            /*0x3c79d90*/ Cysharp.Threading.Tasks.UniTask<string> AcquireStringData(string assetKey, string extension);
            /*0x3c79f44*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> AcquireTexture2D(string assetKey, UnityEngine.MonoBehaviour owner);
            /*0x3c7a0d4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> AcquireTexture2D(string assetKey);
            /*0x3c79fa4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> AcquireTexture2D(string originalAssetKey, UnityEngine.GameObject owner);
            /*0x3c7a108*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> AcquireTexture2D(string assetKey, bool increment);
            /*0x3c7a230*/ Cysharp.Threading.Tasks.UniTask<string> AcquireVideoUrl(string assetKey);
            /*0x3c7a34c*/ bool TryStoreRequestData(UnityEngine.Networking.UnityWebRequest request, string eTagPath, string filePath);
            /*0x3c7a40c*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.Networking.UnityWebRequest, string, string>> ProcessWebRequest(string assetKey, string extension, string compression);
            /*0x3c7a554*/ UnityEngine.Texture2D CreateDDSTexture(byte[] bytes);
            /*0x3c7a6d0*/ UnityEngine.TextureFormat GetTextureFormatFromDDS(byte[] bytes);
            /*0x3c7ab3c*/ UnityEngine.Texture2D CreateASTCTexture(byte[] bytes);
            /*0x3c798c0*/ void ClearOldCache();
            /*0x3c7ad20*/ void ManuallyUpdateRuntimeCache();
            /*0x3c7b264*/ void ClearRuntimeCache();
            /*0x3c7b478*/ string FixTextureAssetKey(string assetKey);
            /*0x3c7b4f0*/ string FixVideoAssetKey(string assetKey);
            /*0x3c7b53c*/ string FixTextAssetKey(string assetKey);
            /*0x3c7b588*/ void <Initialize>b__11_0(UnityEngine.SceneManagement.Scene _);

            class TextureCacheData
            {
                /*0x10*/ UnityEngine.Texture2D <Texture>k__BackingField;
                /*0x18*/ int <ReferenceCount>k__BackingField;
                /*0x1c*/ int <UntrackedLifetime>k__BackingField;
                /*0x20*/ bool <Untracked>k__BackingField;

                /*0x3c7b5d0*/ TextureCacheData();
                /*0x3c7b58c*/ UnityEngine.Texture2D get_Texture();
                /*0x3c7b594*/ void set_Texture(UnityEngine.Texture2D value);
                /*0x3c7b59c*/ int get_ReferenceCount();
                /*0x3c7b5a4*/ void set_ReferenceCount(int value);
                /*0x3c7b5ac*/ int get_UntrackedLifetime();
                /*0x3c7b5b4*/ void set_UntrackedLifetime(int value);
                /*0x3c7b5bc*/ bool get_Untracked();
                /*0x3c7b5c4*/ void set_Untracked(bool value);
            }

            enum RuntimeCachingPersistencePolicies
            {
                Auto = 0,
                Manual = 1,
            }

            enum UntrackedCacheLifetimeTypes
            {
                None = 0,
                SingleSceneTransition = 1,
                DoubleSceneTransition = 2,
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ Assets.AssetManagement.DirectAssetProvider <>4__this;
                /*0x18*/ string assetKey;

                /*0x3c7b5d8*/ <>c__DisplayClass17_0();
                /*0x3c7b5e0*/ void <AcquireTexture2D>b__0();
            }

            struct <AcquireStringData>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<string> <>t__builder;
                /*0x30*/ string assetKey;
                /*0x38*/ Assets.AssetManagement.DirectAssetProvider <>4__this;
                /*0x40*/ string extension;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<UnityEngine.Networking.UnityWebRequest, string, string>> <>u__1;

                /*0x3c7b7dc*/ void MoveNext();
                /*0x3c7bd94*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AcquireTexture2D>d__17 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.Texture2D> <>t__builder;
                /*0x30*/ Assets.AssetManagement.DirectAssetProvider <>4__this;
                /*0x38*/ string originalAssetKey;
                /*0x40*/ Assets.AssetManagement.DirectAssetProvider.<> <>8__1;
                /*0x48*/ UnityEngine.GameObject owner;
                /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Texture2D> <>u__1;

                /*0x3c7bdec*/ void MoveNext();
                /*0x3c7c4f8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AcquireTexture2D>d__18 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.Texture2D> <>t__builder;
                /*0x30*/ string assetKey;
                /*0x38*/ Assets.AssetManagement.DirectAssetProvider <>4__this;
                /*0x40*/ bool increment;
                /*0x48*/ Assets.AssetManagement.DirectAssetProvider.TextureCacheData <cache>5__2;
                /*0x50*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<UnityEngine.Networking.UnityWebRequest, string, string>> <>u__1;

                /*0x3c7c550*/ void MoveNext();
                /*0x3c7ce88*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AcquireVideoUrl>d__19 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<string> <>t__builder;
                /*0x30*/ string assetKey;
                /*0x38*/ Assets.AssetManagement.DirectAssetProvider <>4__this;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<UnityEngine.Networking.UnityWebRequest, string, string>> <>u__1;
                /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter<string> <>u__2;

                /*0x3c7cee0*/ void MoveNext();
                /*0x3c7d6e8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <ProcessWebRequest>d__21 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<System.ValueTuple<UnityEngine.Networking.UnityWebRequest, string, string>> <>t__builder;
                /*0x40*/ Assets.AssetManagement.DirectAssetProvider <>4__this;
                /*0x48*/ string assetKey;
                /*0x50*/ string extension;
                /*0x58*/ string compression;
                /*0x60*/ string <eTagPath>5__2;
                /*0x68*/ string <filePath>5__3;
                /*0x70*/ string <requestUrl>5__4;
                /*0x78*/ UnityEngine.Networking.UnityWebRequest <request>5__5;
                /*0x80*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Networking.UnityWebRequest> <>u__1;

                /*0x3c7d740*/ void MoveNext();
                /*0x3c7e0f4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class DirectKeyProvider : Assets.AssetManagement.IDirectKeyProvider
        {
            /*0x3c7ea44*/ DirectKeyProvider();
            /*0x3c7e14c*/ string AcquirePolicyTextKey();
            /*0x3c7e18c*/ string AcquireLicenseTextKey();
            /*0x3c7e1cc*/ string AcquireStampSettingsTextKey();
            /*0x3c7e20c*/ string AcquireSubscriptionTextKey(string key);
            /*0x3c7e258*/ string AcquireBackgroundOfLoginBonusAssetKey(string key);
            /*0x3c7e2a4*/ string AcquireGachaBackgroundAssetKey(string key);
            /*0x3c7e2f0*/ string AcquireCharacterBackgroundAssetKey(string key);
            /*0x3c7e33c*/ string AcquireShopBackgroundAssetKey(string key);
            /*0x3c7e388*/ string AcquireSevenDaysMissionBackgroundAssetKey(string key);
            /*0x3c7e3d4*/ string AcquireLoginBonusBannerAssetKey(string key);
            /*0x3c7e420*/ string AcquireEventBannerAssetKey(string key);
            /*0x3c7e46c*/ string AcquireGachaBannerAssetKey(string key);
            /*0x3c7e4b8*/ string AcquireShopBannerAssetKey(string key);
            /*0x3c7e504*/ string AcquireSevenDaysMissionBannerAssetKey(string key);
            /*0x3c7e550*/ string AcquireEventLogoAssetKey(string key);
            /*0x3c7e59c*/ string AcquireLoginBonusLogoAssetKey(string key);
            /*0x3c7e5e8*/ string AcquireGachaLogoAssetKey(string key);
            /*0x3c7e634*/ string AcquireSevenDaysMissionLogoAssetKey(string key);
            /*0x3c7e680*/ string AcquireEventFramePanelAssetKey(string key);
            /*0x3c7e6cc*/ string AcquireInformationPanelAssetKey(string key);
            /*0x3c7e718*/ string AcquireGachaProductIconAssetKey(string key);
            /*0x3c7e764*/ string AcquireShopProductIconAssetKey(string key);
            /*0x3c7e7b0*/ string AcquireShopThumbnailAssetKey(string key);
            /*0x3c7e7fc*/ string AcquireTitleVideoKey();
            /*0x3c7e83c*/ string AcquireIntroTitleVideoKey();
            /*0x3c7e87c*/ string AcquireGachaVideoKey(string assetKey);
            /*0x3c7e8c8*/ string AcquireHomeVideoKey(string assetKey);
            /*0x3c7e914*/ string AcquireAdventureVideoKey(string assetKey);
            /*0x3c7e960*/ string AcquireBattleVideoKey(string assetKey);
            /*0x3c7e9ac*/ string AcquireChapterBranchVideoKey(string assetKey);
            /*0x3c7e9f8*/ string AcquireEventVideoKey(string assetKey);
        }

        interface IAddressablesKeyProvider
        {
            /*0x380bb68*/ string AcquireActorIconKey(string key);
            /*0x380bb68*/ string AcquireAdventureBackgroundAssetKey(string key);
            /*0x380bb68*/ string AcquireAttributeTextureKey(string key);
            /*0x380b9e8*/ string AcquireBackgroundCharacterDummyKey();
            /*0x380bb68*/ string AcquireBackgoundCharacterSpineKey(string key);
            /*0x380b9e8*/ string AcquireBackgroundSceneDummyKey();
            /*0x380bb68*/ string AcquireBackgroundSceneSpineKey(string key);
            string AcquireBackgroundAssetKeyByType(Assets.Api.Client.BackgroundAssetTypes type, string key);
            /*0x380bb68*/ string AcquireBadgeTextureKey(string key);
            /*0x380bb68*/ string AcquireBattleCockpitKey(string key);
            /*0x380bb68*/ string AcquireBattleMecanimKey(string key);
            /*0x380bb68*/ string AcquireBgIconKey(string key);
            /*0x380bb68*/ string AcquireBgmKey(string key);
            /*0x380bb68*/ string AcquireScenarioVoiceKey(string key);
            /*0x380bcbc*/ string AcquireTalkVoiceKey(string key, string key2);
            /*0x380bb68*/ string AcquireSoundEffectKey(string key);
            /*0x380bb68*/ string AcquireCharacterBackgroundXAssetKey(string key);
            /*0x380bb68*/ string AcquireCharacterBackStandSpineKey(string key);
            /*0x380bb68*/ string AcquireCharacterNamePlateKey(string key);
            /*0x380bb68*/ string AcquireStillThumbnailXAssetKey(string key);
            /*0x380bb68*/ string AcquireSceneThumbnailXAssetKey(string key);
            /*0x380bb68*/ string AcquireCharacterSquareIllustAssetKey(string key);
            /*0x380b9e8*/ string AcquireCharacterStandDummyKey();
            /*0x380bb68*/ string AcquireCharacterStandSpineKey(string key);
            /*0x380bb68*/ string AcquireCharacterVerticalIllustAssetKey(string key);
            /*0x380b9e8*/ string AcquireCircleExpIconKey();
            /*0x380b9e8*/ string AcquireTrophyIconKey();
            /*0x380b9e8*/ string AcquireThumbnailFrameIconKey();
            /*0x380bb68*/ string AcquireCircleIconAssetKey(string key);
            /*0x380bb68*/ string AcquireCharacterTypeTextureKey(string key);
            /*0x380b9e8*/ string AcquireGemIconKey();
            /*0x380b9e8*/ string AcquireOreIconKey();
            /*0x380b9e8*/ string AcquireDmmPointIconKey();
            /*0x380b9e8*/ string AcquireEmptyTrophyKey();
            /*0x380b9e8*/ string AcquireEpisodeIconTextureKey();
            /*0x380b9e8*/ string AcquireExpIconKey();
            /*0x380b9e8*/ string AcquireExtraSkillDummyKey();
            /*0x380bb68*/ string AcquireExrtraSkillThumbnailAssetKey(string key);
            /*0x380bb68*/ string AcquireBattleExtraSkillSpineKey(string key);
            /*0x380bb68*/ string AcquireSystemSpineKey(string key);
            /*0x380bb68*/ string AcquireFrameIconKey(string key);
            /*0x380bb68*/ string AcquireFunctionalBackgroundAssetKey(string key);
            /*0x380bb68*/ string AcquireGachaFrameTextureKey(string key);
            /*0x380bb68*/ string AcquireGachaLightTextureKey(string key);
            /*0x380bb68*/ string AcquireIconFrameIconKey(string key);
            /*0x380bb68*/ string AcquireItemIconKey(string key);
            /*0x380bb68*/ string AcquireItemBigIconKey(string key);
            /*0x380bb68*/ string AcquireKey(string key);
            /*0x380bb68*/ string AcquireMachineSquareIllustAssetKey(string key);
            /*0x380bb68*/ string AcquireMainChapterBackgroundAssetKey(string key);
            /*0x380bb68*/ string AcquireMainChapterThumbnailAssetKey(string key);
            /*0x380bb68*/ string AcquireMainEpisodeThumbnailAssetKey(string key);
            /*0x380bb68*/ string AcquireMemoryBackgroundKey(string key);
            /*0x380bb68*/ string AcquireQuestTopBackgroundKey(string key);
            /*0x380bb68*/ string AcquireMemorySquareIllustAssetKey(string key);
            /*0x380b9e8*/ string AcquireMoneyIconKey();
            /*0x380bb68*/ string AcquireOsTextureKey(string key);
            /*0x380bb68*/ string AcquireCharacterEvaluationTextureKey(string key);
            /*0x380bb68*/ string AcquireModuleSlotTextureKey(string key);
            /*0x380bb68*/ string AcquirePartyBuffTextureKey(string key);
            /*0x380bb68*/ string AcquireQueueIconKey(string key);
            /*0x380bb68*/ string AcquireRarityHorizontalTextureKey(string key);
            /*0x380bb68*/ string AcquireRoundTextureKey(string key);
            /*0x380bb68*/ string AcquireRarityTextureKey(string key);
            /*0x380b9e8*/ string AcquireScenarioPlayerIconKey();
            /*0x380bb68*/ string AcquireAnimationAssetKey(string key);
            /*0x380bb68*/ string AcquireSceneKey(string sceneName);
            /*0x380bb68*/ string AcquireSchoolLogoKey(string key);
            /*0x380bb68*/ string AcquireShopBackgroundAssetKey(string key);
            /*0x380bb68*/ string AcquireShopShochikubaiThumbnailAssetKey(string key);
            /*0x380bb68*/ string AcquireShopThumbnailAssetKey(string key);
            /*0x380bb68*/ string AcquireShopProductIconAssetKey(string key);
            /*0x380bb68*/ string AcquireSkillTextureKey(string key);
            /*0x380bb68*/ string AcquireKindIconTextureKey(string key);
            /*0x380bb68*/ string AcquireBadgeLabelTextureKey(string key);
            /*0x380bb68*/ string AcquireSystemVoiceKey(string key);
            /*0x380bb68*/ string AcquireStampKey(string key);
            /*0x380bb68*/ string AcquireStyleCardFrameTextureKey(string key);
            /*0x380bb68*/ string AcquireTeamEmblemKey(string key);
            /*0x380bb68*/ string AcquireTeamIconKey(string key);
            /*0x380bb68*/ string AcquireTeamLogoKey(string key);
            /*0x380bb68*/ string AcquireTrackTextureKey(string key);
            /*0x380bb68*/ string AcquireTrophyFrameKey(string key);
            /*0x380bb68*/ string AcquireTrophyKey(string key);
            /*0x380bb68*/ string AcquireTrophyStageKey(string key);
            /*0x380bb68*/ string AcquireVipKey(string key);
            /*0x380bb68*/ string AcquireFunctionalBackgroundBuiltInImageKey(string key);
            /*0x380bb68*/ string AcquireFunctionalBackgroundMemoryImageKey(string key);
            /*0x380bb68*/ string AcquireFunctionalBackgroundSpotAreaImageKey(string key);
            /*0x380bb68*/ string AcquireMazeRouteThumbnailKey(string key);
            /*0x380bb68*/ string AcquireSpotAreaThumbnailKey(string key);
            /*0x380bb68*/ string AcquireSpotAreaPointThumbnailKey(string key);
            /*0x380bb68*/ string AcquireMazeGuarderThumbnailKey(string key);
            /*0x380bb68*/ string AcquireMazeGuarderIllustThumbnailAssetKey(string key);
            /*0x380bb68*/ string AcquireAdventureIllustThumbnailAssetKey(string key);
            /*0x380bb68*/ string AcquireMazeGuarderIllustBackgroundKey(string key);
            /*0x380bb68*/ string AcquireTypeEquipmentIconKey(string key);
            /*0x380bb68*/ string AcquireMazeBonusIconKey(string key);
            /*0x380bb68*/ string AcquireMazeEncountBackgroundAssetKey(string key);
            /*0x380bb68*/ string AcquireRelicIconKey(string key);
            /*0x380bb68*/ string SceneKeyToSceneName(string key);
            string TryAcquireThingThumbnailKey(Assets.Api.Client.ThingTypes type, string assetId);
            /*0x380cdf0*/ void Initialize(bool rated);
            /*0x380b9e8*/ string AcquirePlayerTeamIconKey();
            /*0x380b9e8*/ string AcquireEnemyTeamIconKey();
            /*0x380bb68*/ string AcquireModuleIconKey(string key);
            /*0x380bb68*/ string AcquireToastTextImageKey(string key);
            /*0x380bb68*/ string AcquireRoleTextureKey(string key);
            /*0x380bb68*/ string AcquireStatusEffectTextureKey(string key);
            /*0x380bb68*/ string AcquireScenarioLogIconTextureKey(string key);
            /*0x380bb68*/ string AcquireLoadEventIconPartTextureKey(string key);
            /*0x380bb68*/ string AcquireRelicCategoryTextureKey(string key);
            string AcquireCharacterSystemVoiceKey(long characterId, string key);
            string AcquireCharacterMiscellaneousVoiceKey(long characterId, string key);
            /*0x380bcbc*/ string AcquireCharacterMiscellaneousVoiceKey(string characterId, string key);
            string AcquireCharacterBattleVoiceKey(long characterId, string key);
            /*0x380bcbc*/ string AcquireCharacterVoiceKey(string assetId, string key);
            /*0x380bcbc*/ string AcquireCharacterBattleVoiceKey(string characterId, string key);
            /*0x380bcbc*/ string AcquireCharacterSystemVoiceKey(string characterId, string key);
            /*0x380bcbc*/ string AcquireSystemVoiceKey(string assetId, string key);
            /*0x380bb68*/ string AcquireScenarioSoundEffectKey(string key);
            /*0x380b9e8*/ string AcquireLocationUnlockPointIconKey();
            /*0x380b9e8*/ string AcquireEmotionVfxTemplateKey();
            /*0x380ba90*/ string AcquireAttributeTextureKey(Assets.Api.Client.CharacterAttributes attribute);
            /*0x380ba90*/ string AcquireRoleTextureKey(Assets.Api.Client.CharacterRoleTypes role);
        }

        interface IDirectKeyProvider
        {
            /*0x380bb68*/ string AcquireAdventureVideoKey(string assetKey);
            /*0x380bb68*/ string AcquireBackgroundOfLoginBonusAssetKey(string key);
            /*0x380bb68*/ string AcquireBattleVideoKey(string assetKey);
            /*0x380bb68*/ string AcquireCharacterBackgroundAssetKey(string key);
            /*0x380bb68*/ string AcquireEventBannerAssetKey(string key);
            /*0x380bb68*/ string AcquireGachaBackgroundAssetKey(string key);
            /*0x380bb68*/ string AcquireGachaBannerAssetKey(string key);
            /*0x380bb68*/ string AcquireGachaVideoKey(string assetKey);
            /*0x380bb68*/ string AcquireHomeVideoKey(string assetKey);
            /*0x380bb68*/ string AcquireLoginBonusBannerAssetKey(string key);
            /*0x380bb68*/ string AcquireLoginBonusLogoAssetKey(string key);
            /*0x380bb68*/ string AcquireGachaLogoAssetKey(string key);
            /*0x380b9e8*/ string AcquirePolicyTextKey();
            /*0x380b9e8*/ string AcquireLicenseTextKey();
            /*0x380bb68*/ string AcquireSubscriptionTextKey(string key);
            /*0x380bb68*/ string AcquireShopBackgroundAssetKey(string key);
            /*0x380bb68*/ string AcquireShopThumbnailAssetKey(string key);
            /*0x380b9e8*/ string AcquireTitleVideoKey();
            /*0x380b9e8*/ string AcquireIntroTitleVideoKey();
            /*0x380b9e8*/ string AcquireStampSettingsTextKey();
            /*0x380bb68*/ string AcquireSevenDaysMissionBackgroundAssetKey(string key);
            /*0x380bb68*/ string AcquireSevenDaysMissionBannerAssetKey(string key);
            /*0x380bb68*/ string AcquireSevenDaysMissionLogoAssetKey(string key);
            /*0x380bb68*/ string AcquireGachaProductIconAssetKey(string key);
            /*0x380bb68*/ string AcquireShopProductIconAssetKey(string key);
            /*0x380bb68*/ string AcquireEventLogoAssetKey(string key);
            /*0x380bb68*/ string AcquireEventFramePanelAssetKey(string key);
            /*0x380bb68*/ string AcquireInformationPanelAssetKey(string key);
            /*0x380bb68*/ string AcquireShopBannerAssetKey(string key);
            /*0x380bb68*/ string AcquireChapterBranchVideoKey(string key);
            /*0x380bb68*/ string AcquireEventVideoKey(string key);
        }

        class NotifyOnDestroy : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Events.UnityEvent <OnDestroyEvent>k__BackingField;

            static /*0x3c73afc*/ void AttachTo(UnityEngine.GameObject owner, System.Action callbackOnDestroy);
            /*0x3c7ea78*/ NotifyOnDestroy();
            /*0x3c7ea4c*/ UnityEngine.Events.UnityEvent get_OnDestroyEvent();
            /*0x3c7ea54*/ void OnDestroy();

            class <>c__DisplayClass4_0
            {
                /*0x10*/ System.Action callbackOnDestroy;

                /*0x3c7ea70*/ <>c__DisplayClass4_0();
                /*0x3c7eae4*/ void <AttachTo>b__0();
            }
        }

        interface ISpineAssetProvider
        {
            Cysharp.Threading.Tasks.UniTask PreloadAdventureBackMecanim(string id);
            Cysharp.Threading.Tasks.UniTask PreloadAdventureMecanim(string id);
            Cysharp.Threading.Tasks.UniTask PreloadAdventureSceneMecanim(string id);
            Cysharp.Threading.Tasks.UniTask PreloadBackgroundMecanim(string id);
            Cysharp.Threading.Tasks.UniTask PreloadBattleExtraSkillMecanim(string id);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureBackMecanim(string id);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureBackMecanim(string id, bool active);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureBackMecanim(string id, UnityEngine.Transform parent);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureBackMecanim(string id, UnityEngine.Transform parent, bool active);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureMecanim(string id);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureMecanim(string id, bool active);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureMecanim(string id, UnityEngine.Transform parent);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureMecanim(string id, UnityEngine.Transform parent, bool active);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureSceneMecanim(string id);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureSceneMecanim(string id, bool active);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureSceneMecanim(string id, UnityEngine.Transform parent);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureSceneMecanim(string id, UnityEngine.Transform parent, bool active);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBackgroundMecanim(string id);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBackgroundMecanim(string id, bool active);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBackgroundMecanim(string id, UnityEngine.Transform parent);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBackgroundMecanim(string id, UnityEngine.Transform parent, bool active);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> RequestFrontBattleMecanim(string id, bool active);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> RequestFrontBattleMecanim(string id, UnityEngine.Transform parent);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> RequestBattleMecanim(string id, UnityEngine.Transform parent, bool active);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> RequestCockpitSkeleton(string id);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> RequestCockpitSkeleton(string id, bool active);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> RequestCockpitSkeleton(string id, UnityEngine.Transform parent);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> RequestCockpitSkeleton(string id, UnityEngine.Transform parent, bool active);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBattleExtraSkillMecanim(string id);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBattleExtraSkillMecanim(string id, bool active);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBattleExtraSkillMecanim(string id, UnityEngine.Transform parent);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBattleExtraSkillMecanim(string id, UnityEngine.Transform parent, bool active);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim>> RequestSystemSkeleton(string id);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim>> RequestSystemSkeleton(string id, bool active);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim>> RequestSystemSkeleton(string id, UnityEngine.Transform parent);
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim>> RequestSystemSkeleton(string id, UnityEngine.Transform parent, bool active);
            /*0x380d83c*/ void ReturnMecanim(Assets.AssetManagement.SpineMecanim reference);
            /*0x380d83c*/ void ReturnSkeleton(Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController> reference);
            /*0x380d83c*/ void ReturnSkeletonMecanim(Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim> reference);
            /*0x380d83c*/ void ReturnReference<T>(Assets.AssetManagement.SpineAssetProvider.Reference<T> reference);
        }

        class SpineAssetProvider : Assets.AssetManagement.ISpineAssetProvider
        {
            /*0x10*/ Assets.AssetManagement.IAddressablesAssetProvider assetProvider;
            /*0x18*/ Assets.AssetManagement.IAssetInstanceProvider instanceAssetProvider;
            /*0x20*/ Assets.AssetManagement.IAddressablesKeyProvider keyProvider;
            /*0x28*/ Assets.AssetManagement.IUnusedInstanceManager unusedInstanceManager;

            /*0x3c7eb08*/ SpineAssetProvider(Assets.AssetManagement.IAddressablesAssetProvider assetProvider, Assets.AssetManagement.IAssetInstanceProvider instanceAssetProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider, Assets.AssetManagement.IUnusedInstanceManager unusedInstanceManager);
            /*0x3c7eb7c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> RequestAdventureSceneMecanimDummy(UnityEngine.Transform parent, bool active);
            /*0x3c7eca0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> RequestAdventureMecanimDummy(UnityEngine.Transform parent, bool active);
            /*0x3c7edc4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> RequestAdventureBackMecanimDummy();
            /*0x3c7edfc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> RequestBackgroundMecanimDummy(UnityEngine.Transform parent, bool active);
            /*0x3c7ef20*/ Cysharp.Threading.Tasks.UniTask<Assets.Utilities.Spine.SkeletonController> RequestCockpitMecanimDummy(UnityEngine.Transform parent, bool active);
            /*0x3c7f044*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> RequestBattleExtraSkillMecanimDummy(UnityEngine.Transform parent, bool active);
            /*0x3c7f168*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureSceneMecanim(string id);
            /*0x3c7f2e4*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureSceneMecanim(string id, bool active);
            /*0x3c7f31c*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureSceneMecanim(string id, UnityEngine.Transform parent);
            /*0x3c7f1a0*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureSceneMecanim(string id, UnityEngine.Transform parent, bool active);
            /*0x3c7f350*/ Cysharp.Threading.Tasks.UniTask PreloadAdventureSceneMecanim(string id);
            /*0x3c7f4e0*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureMecanim(string id);
            /*0x3c7f554*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureMecanim(string id, bool active);
            /*0x3c7f590*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureMecanim(string id, UnityEngine.Transform parent);
            /*0x3c7f51c*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureMecanim(string id, UnityEngine.Transform parent, bool active);
            /*0x3c7f5c8*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureMecanim(string id, UnityEngine.Transform parent, bool active, bool isBackSpine);
            /*0x3c7f718*/ Cysharp.Threading.Tasks.UniTask PreloadAdventureMecanim(string id);
            /*0x3c7f8a8*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureBackMecanim(string id);
            /*0x3c7f91c*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureBackMecanim(string id, bool active);
            /*0x3c7f958*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureBackMecanim(string id, UnityEngine.Transform parent);
            /*0x3c7f8e4*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureBackMecanim(string id, UnityEngine.Transform parent, bool active);
            /*0x3c7f990*/ Cysharp.Threading.Tasks.UniTask PreloadAdventureBackMecanim(string id);
            /*0x3c7fb20*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBackgroundMecanim(string id);
            /*0x3c7fc9c*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBackgroundMecanim(string id, bool active);
            /*0x3c7fcd4*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBackgroundMecanim(string id, UnityEngine.Transform parent);
            /*0x3c7fb58*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBackgroundMecanim(string id, UnityEngine.Transform parent, bool active);
            /*0x3c7fd08*/ Cysharp.Threading.Tasks.UniTask PreloadBackgroundMecanim(string id);
            /*0x3c7fe98*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> RequestFrontBattleMecanim(string id);
            /*0x3c8006c*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> RequestFrontBattleMecanim(string id, bool active);
            /*0x3c80104*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> RequestFrontBattleMecanim(string id, UnityEngine.Transform parent);
            /*0x3c7ff28*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> RequestBattleMecanim(string id, UnityEngine.Transform parent, bool active);
            /*0x3c8019c*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> RequestCockpitSkeleton(string id);
            /*0x3c80318*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> RequestCockpitSkeleton(string id, bool active);
            /*0x3c80350*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> RequestCockpitSkeleton(string id, UnityEngine.Transform parent);
            /*0x3c801d4*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> RequestCockpitSkeleton(string id, UnityEngine.Transform parent, bool active);
            /*0x3c80384*/ Cysharp.Threading.Tasks.UniTask PreloadBattleExtraSkillMecanim(string id);
            /*0x3c80514*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBattleExtraSkillMecanim(string id);
            /*0x3c80690*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBattleExtraSkillMecanim(string id, bool active);
            /*0x3c806c8*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBattleExtraSkillMecanim(string id, UnityEngine.Transform parent);
            /*0x3c8054c*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBattleExtraSkillMecanim(string id, UnityEngine.Transform parent, bool active);
            /*0x3c806fc*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim>> RequestSystemSkeleton(string id);
            /*0x3c80878*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim>> RequestSystemSkeleton(string id, bool active);
            /*0x3c808b0*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim>> RequestSystemSkeleton(string id, UnityEngine.Transform parent);
            /*0x3c80734*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim>> RequestSystemSkeleton(string id, UnityEngine.Transform parent, bool active);
            /*0x3c808e4*/ void ReturnMecanim(Assets.AssetManagement.SpineMecanim reference);
            /*0x3c80b04*/ void ReturnSkeleton(Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController> reference);
            /*0x3c80be8*/ void ReturnSkeletonMecanim(Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim> reference);
            /*0x380d83c*/ void ReturnReference<T>(Assets.AssetManagement.SpineAssetProvider.Reference<T> reference);

            class Reference<T>
            {
                /*0x0*/ string <Key>k__BackingField;
                /*0x0*/ T <Instance>k__BackingField;

                /*0x3907c14*/ Reference(string key, T instance);
                /*0x380b9e8*/ string get_Key();
                /*0x3907c14*/ T get_Instance();
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ Assets.AssetManagement.SpineMecanim mecanim;

                /*0x3c80ccc*/ <>c__DisplayClass20_0();
                /*0x3c80cd4*/ void <RequestAdventureMecanim>b__0(Assets.Utilities.Spine.FaceStates face, float _);
                /*0x3c80d50*/ void <RequestAdventureMecanim>b__1(Assets.Utilities.Spine.FaceStates face, float _);
            }

            struct <RequestAdventureMecanim>d__20 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.AssetManagement.SpineMecanim> <>t__builder;
                /*0x30*/ bool isBackSpine;
                /*0x38*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x40*/ string id;
                /*0x48*/ UnityEngine.Transform parent;
                /*0x50*/ bool active;
                /*0x58*/ Assets.AssetManagement.SpineAssetProvider.<> <>8__1;
                /*0x60*/ string <key>5__2;
                /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x3c80d74*/ void MoveNext();
                /*0x3c82018*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestAdventureMecanimDummy>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ UnityEngine.Transform parent;
                /*0x40*/ bool active;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x3c82070*/ void MoveNext();
                /*0x3c82694*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestAdventureSceneMecanim>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.AssetManagement.SpineMecanim> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ string id;
                /*0x40*/ UnityEngine.Transform parent;
                /*0x48*/ bool active;
                /*0x50*/ string <key>5__2;
                /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x3c826ec*/ void MoveNext();
                /*0x3c83208*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestAdventureSceneMecanimDummy>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ UnityEngine.Transform parent;
                /*0x40*/ bool active;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x3c83260*/ void MoveNext();
                /*0x3c83884*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestBackgroundMecanim>d__30 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.AssetManagement.SpineMecanim> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ string id;
                /*0x40*/ UnityEngine.Transform parent;
                /*0x48*/ bool active;
                /*0x50*/ string <key>5__2;
                /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x3c838dc*/ void MoveNext();
                /*0x3c843fc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestBackgroundMecanimDummy>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ UnityEngine.Transform parent;
                /*0x40*/ bool active;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x3c84454*/ void MoveNext();
                /*0x3c84a78*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestBattleExtraSkillMecanim>d__44 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.AssetManagement.SpineMecanim> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ string id;
                /*0x40*/ UnityEngine.Transform parent;
                /*0x48*/ bool active;
                /*0x50*/ string <key>5__2;
                /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x3c84ad0*/ void MoveNext();
                /*0x3c855f0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestBattleExtraSkillMecanimDummy>d__10 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ UnityEngine.Transform parent;
                /*0x40*/ bool active;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x3c85648*/ void MoveNext();
                /*0x3c85c6c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestBattleMecanim>d__35 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ string id;
                /*0x40*/ UnityEngine.Transform parent;
                /*0x48*/ bool active;
                /*0x50*/ string <key>5__2;
                /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Utilities.Spine.MecanimController> <>u__1;

                /*0x3c85cc4*/ void MoveNext();
                /*0x3c86604*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestCockpitMecanimDummy>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Utilities.Spine.SkeletonController> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ UnityEngine.Transform parent;
                /*0x40*/ bool active;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Utilities.Spine.SkeletonController> <>u__1;

                /*0x3c8665c*/ void MoveNext();
                /*0x3c86cd4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestCockpitSkeleton>d__39 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ string id;
                /*0x40*/ UnityEngine.Transform parent;
                /*0x48*/ bool active;
                /*0x50*/ string <key>5__2;
                /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Utilities.Spine.SkeletonController> <>u__1;

                /*0x3c86d2c*/ void MoveNext();
                /*0x3c87864*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestSystemSkeleton>d__48 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim>> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ string id;
                /*0x40*/ UnityEngine.Transform parent;
                /*0x48*/ bool active;
                /*0x50*/ string <key>5__2;
                /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Spine.Unity.SkeletonMecanim> <>u__1;

                /*0x3c878bc*/ void MoveNext();
                /*0x3c881d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class SpineMecanim
        {
            /*0x10*/ string <Key>k__BackingField;
            /*0x18*/ UnityEngine.GameObject <Instance>k__BackingField;
            /*0x20*/ Assets.Utilities.Spine.MecanimController <MecanimController>k__BackingField;
            /*0x28*/ Assets.Utilities.Spine.BlinkAnimator <BlinkAnimator>k__BackingField;
            /*0x30*/ Assets.Utilities.Spine.EmotionAnimator <EmotionAnimator>k__BackingField;
            /*0x38*/ Assets.Utilities.Spine.LipSyncAnimator <LipSyncAnimator>k__BackingField;

            /*0x3c81eec*/ SpineMecanim(string key, UnityEngine.GameObject gameObject);
            /*0x3c88228*/ string get_Key();
            /*0x3c88230*/ UnityEngine.GameObject get_Instance();
            /*0x3c88238*/ Assets.Utilities.Spine.MecanimController get_MecanimController();
            /*0x3c88240*/ Assets.Utilities.Spine.BlinkAnimator get_BlinkAnimator();
            /*0x3c88248*/ Assets.Utilities.Spine.EmotionAnimator get_EmotionAnimator();
            /*0x3c88250*/ Assets.Utilities.Spine.LipSyncAnimator get_LipSyncAnimator();
        }

        interface ITextAssetProvider
        {
            Cysharp.Threading.Tasks.UniTask<string> LoadJsonAsset(string key);
            Cysharp.Threading.Tasks.UniTask<string> LoadTextAsset(string key);
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<string> LoadUserAgreementsJsonData();
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<string> LoadLicenseData();
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<string> LoadStampSettingData();
            Cysharp.Threading.Tasks.UniTask<string> LoadSubscriptionData(string assetId);
        }

        class TextAssetProvider : Assets.AssetManagement.ITextAssetProvider
        {
            /*0x10*/ Assets.AssetManagement.IAddressablesAssetProvider assetProvider;
            /*0x18*/ Assets.AssetManagement.IDirectAssetProvider directAssetProvider;
            /*0x20*/ Assets.AssetManagement.IAddressablesKeyProvider keyProvider;
            /*0x28*/ Assets.AssetManagement.IDirectKeyProvider directKeyProvider;

            /*0x3c88258*/ TextAssetProvider(Assets.AssetManagement.IAddressablesAssetProvider assetProvider, Assets.AssetManagement.IDirectAssetProvider directAssetProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider, Assets.AssetManagement.IDirectKeyProvider directKeyProvider);
            /*0x3c882cc*/ Cysharp.Threading.Tasks.UniTask<string> LoadTextDummy();
            /*0x3c8836c*/ Cysharp.Threading.Tasks.UniTask<string> LoadTextAsset(string key);
            /*0x3c88484*/ Cysharp.Threading.Tasks.UniTask<string> LoadJsonAsset(string key);
            /*0x3c8859c*/ Cysharp.Threading.Tasks.UniTask<string> LoadUserAgreementsJsonData();
            /*0x3c88670*/ Cysharp.Threading.Tasks.UniTask<string> LoadLicenseData();
            /*0x3c88744*/ Cysharp.Threading.Tasks.UniTask<string> LoadStampSettingData();
            /*0x3c88818*/ Cysharp.Threading.Tasks.UniTask<string> LoadSubscriptionData(string assetId);

            struct <LoadJsonAsset>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<string> <>t__builder;
                /*0x30*/ Assets.AssetManagement.TextAssetProvider <>4__this;
                /*0x38*/ string key;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<string> <>u__1;

                /*0x3c888f8*/ void MoveNext();
                /*0x3c89074*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <LoadTextAsset>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<string> <>t__builder;
                /*0x30*/ Assets.AssetManagement.TextAssetProvider <>4__this;
                /*0x38*/ string key;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<string> <>u__1;

                /*0x3c890cc*/ void MoveNext();
                /*0x3c89848*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        interface ITextureAssetProvider
        {
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadActorIcon(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadAdventureBackgroundTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadAttributeTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadBackgroundOfLoginBonusTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadFunctionalBackgroundAssetKey(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadBadgeTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadBgIconTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadCharacterNamePlateTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadCharacterSquareIllustTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadCharacterTypeTexture(string id);
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGemIconTexture();
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadOreIconTexture();
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadDirectTextureAsset(string id);
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadDummySprite();
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadDummyTexture();
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEpisodeIconTexture();
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEventBannerTexture(string id);
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadExpIconTexture();
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadFrameIconTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGachaFrameTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadRoleTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadStatusEffectTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGachaBannerTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGachaLightTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadIconFrameIconTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadItemIconTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadItemBigIconTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadLoginBonusBannerTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadLoginBonusLogoTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMainChapterThumbnailTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMainEpisodeThumbnailTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMemoryBackgroundTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadQuestTopBackgroundTexture(string id);
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMoneyIconTexture();
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadDmmPointIconTexture();
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadOsTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadCharacterEvaluationTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadModuleSlotTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadPartyBuffTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadQueueIcon(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadRarityHorizontalTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadRarityTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSchoolLogoTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGachaLogoTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopBackgroundTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopBackgroundPermanentTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopShochikubaiThumbnailTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopThumbnailTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopThumbnailPermanentTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopProductIconPermanentTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSkillTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadKindIconTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadBadgeLabelTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadStillThumbnailXTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSceneThumbnailXTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadSpriteAsset(object id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadStampTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadStyleCardFrameTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTeamEmblemTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTeamIconTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTeamLogoTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTeamVipTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTextureAsset(object key);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadThingThumbnailTexture(Assets.Api.Client.ThingTypes type, string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTrackTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTrophyFrameTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTrophyStageTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTrophyTexture(string id);
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEmptyTrophyTexture();
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeRouteThumbnailTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSpotAreaThumbnailTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSpotAreaPointThumbnailTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTypeEquipmentIconTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeBonusIconTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeEncountBackgroundTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadToastTextImageTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSevenDaysMissionLogoTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSevenDaysMissionBannerTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGachaProductIconTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopProductIconTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadTeamIcon(bool isEnemyTeam);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeGuarderThumbnailTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeGuarderIllustThumbnailTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadAdventureIllustThumbnailTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeGuarderIllustBackgroundTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEventLogoTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEventFramePanelTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEventIconPartTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopBannerTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadInformationPanelTexture(string id);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadAttributeSprite(Assets.Api.Client.CharacterAttributes attribute);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadAttributeTexture(Assets.Api.Client.CharacterAttributes attribute);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadRoleTexture(Assets.Api.Client.CharacterRoleTypes role);
            /*0x380cb08*/ void ClearDirectCache();
        }

        class TextureAssetProvider : Assets.AssetManagement.ITextureAssetProvider
        {
            /*0x10*/ Assets.AssetManagement.IAddressablesAssetProvider assetProvider;
            /*0x18*/ Assets.AssetManagement.IDirectAssetProvider directAssetProvider;
            /*0x20*/ Assets.AssetManagement.IAddressablesKeyProvider keyProvider;
            /*0x28*/ Assets.AssetManagement.IDirectKeyProvider directKeyProvider;

            /*0x3c898a0*/ TextureAssetProvider(Assets.AssetManagement.IAddressablesAssetProvider assetProvider, Assets.AssetManagement.IDirectAssetProvider directAssetProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider, Assets.AssetManagement.IDirectKeyProvider directKeyProvider);
            /*0x3c89914*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadDummyTexture();
            /*0x3c899d4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadDummySprite();
            /*0x3c89af0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTextureAsset(object key);
            /*0x3c89c08*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadSpriteAsset(object key);
            /*0x3c89d20*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadDirectTextureAsset(string key);
            /*0x3c89e38*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadThingThumbnailTexture(Assets.Api.Client.ThingTypes type, string id);
            /*0x3c89f34*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadTeamIcon(bool isEnemyTeam);
            /*0x3c8a04c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadStampTexture(string id);
            /*0x3c8a12c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadCharacterNamePlateTexture(string id);
            /*0x3c8a20c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMemoryBackgroundTexture(string id);
            /*0x3c8a2ec*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadQuestTopBackgroundTexture(string id);
            /*0x3c8a3cc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadRarityTexture(string id);
            /*0x3c8a4ac*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadAdventureBackgroundTexture(string id);
            /*0x3c8a58c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTeamIconTexture(string id);
            /*0x3c8a66c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTeamVipTexture(string id);
            /*0x3c8a74c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadAttributeTexture(string id);
            /*0x3c8a82c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadAttributeTexture(Assets.Api.Client.CharacterAttributes attribute);
            /*0x3c8a90c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadAttributeSprite(Assets.Api.Client.CharacterAttributes attribute);
            /*0x3c8a9ec*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadCharacterTypeTexture(string id);
            /*0x3c8aacc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadBackgroundOfLoginBonusTexture(string id);
            /*0x3c8abac*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadFunctionalBackgroundAssetKey(string id);
            /*0x3c8ac8c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMoneyIconTexture();
            /*0x3c8ad60*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadDmmPointIconTexture();
            /*0x3c8ae34*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadItemIconTexture(string id);
            /*0x3c8af14*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadItemBigIconTexture(string id);
            /*0x3c8aff4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGemIconTexture();
            /*0x3c8b0c8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadOreIconTexture();
            /*0x3c8b19c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTeamEmblemTexture(string id);
            /*0x3c8b27c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTeamLogoTexture(string id);
            /*0x3c8b35c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSchoolLogoTexture(string id);
            /*0x3c8b43c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGachaLogoTexture(string id);
            /*0x3c8b51c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadRarityHorizontalTexture(string id);
            /*0x3c8b5fc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadPartyBuffTexture(string id);
            /*0x3c8b6dc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTrackTexture(string id);
            /*0x3c8b7bc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTrophyTexture(string id);
            /*0x3c8b89c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEmptyTrophyTexture();
            /*0x3c8b970*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTrophyFrameTexture(string id);
            /*0x3c8ba50*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTrophyStageTexture(string id);
            /*0x3c8bb30*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadBgIconTexture(string id);
            /*0x3c8bc10*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadBadgeTexture(string id);
            /*0x3c8bcf0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEpisodeIconTexture();
            /*0x3c8bdc4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMainChapterThumbnailTexture(string id);
            /*0x3c8bea4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMainEpisodeThumbnailTexture(string id);
            /*0x3c8bf84*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGachaFrameTexture(string id);
            /*0x3c8c064*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGachaLightTexture(string id);
            /*0x3c8c144*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadStyleCardFrameTexture(string id);
            /*0x3c8c224*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadExpIconTexture();
            /*0x3c8c2f8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadIconFrameIconTexture(string id);
            /*0x3c8c3d8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadOsTexture(string id);
            /*0x3c8c4b8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadCharacterEvaluationTexture(string id);
            /*0x3c8c598*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadModuleSlotTexture(string id);
            /*0x3c8c678*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSkillTexture(string id);
            /*0x3c8c758*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadKindIconTexture(string id);
            /*0x3c8c838*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadBadgeLabelTexture(string id);
            /*0x3c8c918*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadCharacterSquareIllustTexture(string id);
            /*0x3c8c9f8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadFrameIconTexture(string id);
            /*0x3c8cad8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadLoginBonusLogoTexture(string id);
            /*0x3c8cbb8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopBackgroundPermanentTexture(string id);
            /*0x3c8cc98*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopShochikubaiThumbnailTexture(string id);
            /*0x3c8cd78*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopThumbnailPermanentTexture(string id);
            /*0x3c8ce58*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopProductIconPermanentTexture(string id);
            /*0x3c8cf38*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadActorIcon(string id);
            /*0x3c8d018*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadQueueIcon(string id);
            /*0x3c8d0f8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadExrtraSkillThumbnailTexture(string id);
            /*0x3c8d1d8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadStillThumbnailXTexture(string id);
            /*0x3c8d2b8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSceneThumbnailXTexture(string id);
            /*0x3c8d398*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadCharacterBackgroundXTexture(string id);
            /*0x3c8d478*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeRouteThumbnailTexture(string id);
            /*0x3c8d558*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadRelicIconTexture(string id);
            /*0x3c8d638*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSpotAreaThumbnailTexture(string id);
            /*0x3c8d718*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSpotAreaPointThumbnailTexture(string id);
            /*0x3c8d7f8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTypeEquipmentIconTexture(string id);
            /*0x3c8d8d8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeBonusIconTexture(string id);
            /*0x3c8d9b8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeEncountBackgroundTexture(string id);
            /*0x3c8da98*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadToastTextImageTexture(string id);
            /*0x3c8db78*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadRoleTexture(string id);
            /*0x3c8dc58*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadRoleTexture(Assets.Api.Client.CharacterRoleTypes role);
            /*0x3c8dd38*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadStatusEffectTexture(string id);
            /*0x3c8de18*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEventIconPartTexture(string id);
            /*0x3c8def8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGachaBannerTexture(string id);
            /*0x3c8dfd8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEventBannerTexture(string id);
            /*0x3c8e0b8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadLoginBonusBannerTexture(string id);
            /*0x3c8e198*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopThumbnailTexture(string id);
            /*0x3c8e278*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopBackgroundTexture(string id);
            /*0x3c8e358*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopBannerTexture(string id);
            /*0x3c8e438*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSevenDaysMissionLogoTexture(string id);
            /*0x3c8e518*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSevenDaysMissionBannerTexture(string id);
            /*0x3c8e5f8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGachaProductIconTexture(string id);
            /*0x3c8e6d8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopProductIconTexture(string id);
            /*0x3c8e7b8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEventLogoTexture(string id);
            /*0x3c8e898*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEventFramePanelTexture(string id);
            /*0x3c8e978*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadInformationPanelTexture(string id);
            /*0x3c8ea58*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeGuarderThumbnailTexture(string id);
            /*0x3c8eb38*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeGuarderIllustThumbnailTexture(string id);
            /*0x3c8ec18*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadAdventureIllustThumbnailTexture(string id);
            /*0x3c8ecf8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeGuarderIllustBackgroundTexture(string id);
            /*0x3c8edd8*/ void ClearDirectCache();

            struct <LoadDirectTextureAsset>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.Texture2D> <>t__builder;
                /*0x30*/ Assets.AssetManagement.TextureAssetProvider <>4__this;
                /*0x38*/ string key;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Texture2D> <>u__1;

                /*0x3c8ee7c*/ void MoveNext();
                /*0x3c8f624*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <LoadSpriteAsset>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.Sprite> <>t__builder;
                /*0x30*/ Assets.AssetManagement.TextureAssetProvider <>4__this;
                /*0x38*/ object key;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Sprite> <>u__1;

                /*0x3c8f67c*/ void MoveNext();
                /*0x3c8fe38*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <LoadTextureAsset>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.Texture2D> <>t__builder;
                /*0x30*/ Assets.AssetManagement.TextureAssetProvider <>4__this;
                /*0x38*/ object key;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Texture2D> <>u__1;

                /*0x3c8fe90*/ void MoveNext();
                /*0x3c9064c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        interface IUnusedInstanceManager
        {
            /*0x380b6a0*/ int get_CacheSize();
            /*0x380cffc*/ void set_CacheSize(int value);
            /*0x380d93c*/ void Record(string key, UnityEngine.GameObject instance);
            UnityEngine.GameObject TryRequest(string key, UnityEngine.Transform parent, bool active);
            /*0x380bcbc*/ UnityEngine.GameObject TryRequest(string key, UnityEngine.Transform parent);
            /*0x380bba0*/ UnityEngine.GameObject TryRequest(string key, bool active);
            /*0x380bb68*/ UnityEngine.GameObject TryRequest(string key);
            /*0x3907c14*/ T TryRequest<T>(string key, UnityEngine.Transform parent, bool active);
            /*0x3907c14*/ T TryRequest<T>(string key, UnityEngine.Transform parent);
            /*0x3907c14*/ T TryRequest<T>(string key, bool active);
            /*0x3907c14*/ T TryRequest<T>(string key);
        }

        class UnusedInstanceManager : UnityEngine.MonoBehaviour, Assets.AssetManagement.IUnusedInstanceManager
        {
            /*0x20*/ System.Collections.Generic.List<Assets.AssetManagement.UnusedInstanceManager.InstanceData> cache;
            /*0x28*/ object cacheLock;
            /*0x30*/ int <CacheSize>k__BackingField;

            /*0x3c912f8*/ UnusedInstanceManager();
            /*0x3c906a4*/ int get_CacheSize();
            /*0x3c906ac*/ void set_CacheSize(int value);
            /*0x3c906b4*/ void Record(string key, UnityEngine.GameObject instance);
            /*0x3c90b68*/ void TryUnloadExcess();
            /*0x3907c14*/ T TryRequest<T>(string key);
            /*0x3907c14*/ T TryRequest<T>(string key, bool active);
            /*0x3907c14*/ T TryRequest<T>(string key, UnityEngine.Transform parent);
            /*0x3907c14*/ T TryRequest<T>(string key, UnityEngine.Transform parent, bool active);
            /*0x3c90eb4*/ UnityEngine.GameObject TryRequest(string key);
            /*0x3c9110c*/ UnityEngine.GameObject TryRequest(string key, bool active);
            /*0x3c91118*/ UnityEngine.GameObject TryRequest(string key, UnityEngine.Transform parent);
            /*0x3c90ec0*/ UnityEngine.GameObject TryRequest(string key, UnityEngine.Transform parent, bool active);
            /*0x3c90950*/ bool Exist(int instanceId);
            /*0x3c91184*/ bool Exist(string key);

            class InstanceData
            {
                /*0x10*/ string <Key>k__BackingField;
                /*0x18*/ UnityEngine.GameObject <GameObject>k__BackingField;
                /*0x20*/ System.DateTime <LastUsed>k__BackingField;
                /*0x28*/ int <InstanceId>k__BackingField;

                /*0x3c90ab8*/ InstanceData(string key, UnityEngine.GameObject gameObject);
                /*0x3c913c0*/ string get_Key();
                /*0x3c913c8*/ UnityEngine.GameObject get_GameObject();
                /*0x3c913d0*/ System.DateTime get_LastUsed();
                /*0x3c913d8*/ void set_LastUsed(System.DateTime value);
                /*0x3c913e0*/ int get_InstanceId();
                /*0x3c91128*/ void Refresh();
            }

            class <>c
            {
                static /*0x0*/ Assets.AssetManagement.UnusedInstanceManager.<> <>9;
                static /*0x8*/ System.Func<Assets.AssetManagement.UnusedInstanceManager.InstanceData, System.DateTime> <>9__7_0;

                static /*0x3c913e8*/ <>c();
                /*0x3c91450*/ <>c();
                /*0x3c91458*/ System.DateTime <TryUnloadExcess>b__7_0(Assets.AssetManagement.UnusedInstanceManager.InstanceData item);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ string key;

                /*0x3c91120*/ <>c__DisplayClass15_0();
                /*0x3c91470*/ bool <TryRequest>b__0(Assets.AssetManagement.UnusedInstanceManager.InstanceData item);
            }
        }

        interface IVideoAssetProvider
        {
            Cysharp.Threading.Tasks.UniTask<string> LoadAdventureVideo(string id);
            Cysharp.Threading.Tasks.UniTask<string> LoadGachaVideo(string id);
            Cysharp.Threading.Tasks.UniTask<string> LoadHomeVideo(string id);
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<string> LoadTitleVideo();
            /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<string> LoadIntroTitleVideo();
            Cysharp.Threading.Tasks.UniTask<string> LoadChapterBranchVideo(string id);
            Cysharp.Threading.Tasks.UniTask<string> LoadEventVideo(string id);
        }

        class VideoAssetProvider : Assets.AssetManagement.IVideoAssetProvider
        {
            /*0x10*/ Assets.AssetManagement.IDirectAssetProvider assetProvider;
            /*0x18*/ Assets.AssetManagement.IDirectKeyProvider keyProvider;

            /*0x3c91494*/ VideoAssetProvider(Assets.AssetManagement.IDirectAssetProvider assetProvider, Assets.AssetManagement.IDirectKeyProvider keyProvider);
            /*0x3c914d8*/ Cysharp.Threading.Tasks.UniTask<string> LoadVideoDummy();
            /*0x3c91578*/ Cysharp.Threading.Tasks.UniTask<string> LoadVideoAsset(string key);
            /*0x3c91690*/ Cysharp.Threading.Tasks.UniTask<string> LoadTitleVideo();
            /*0x3c91764*/ Cysharp.Threading.Tasks.UniTask<string> LoadIntroTitleVideo();
            /*0x3c91838*/ Cysharp.Threading.Tasks.UniTask<string> LoadGachaVideo(string id);
            /*0x3c91918*/ Cysharp.Threading.Tasks.UniTask<string> LoadHomeVideo(string id);
            /*0x3c919f8*/ Cysharp.Threading.Tasks.UniTask<string> LoadAdventureVideo(string id);
            /*0x3c91ad4*/ Cysharp.Threading.Tasks.UniTask<string> LoadChapterBranchVideo(string id);
            /*0x3c91bb4*/ Cysharp.Threading.Tasks.UniTask<string> LoadEventVideo(string id);

            struct <LoadVideoAsset>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<string> <>t__builder;
                /*0x30*/ Assets.AssetManagement.VideoAssetProvider <>4__this;
                /*0x38*/ string key;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<string> <>u__1;

                /*0x3c91c94*/ void MoveNext();
                /*0x3c92410*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> DBCFA15EACAB303072570353511BC2270E336F171293848338FE50403AFA687D;
    static /*0x5ab*/ <PrivateImplementationDetails> F07735009DBE9911ED65CA1AADEF778A42EA06BF832DB3AE56E525478346858D;

    struct __StaticArrayInitTypeSize=787
    {
    }

    struct __StaticArrayInitTypeSize=1451
    {
    }
}
