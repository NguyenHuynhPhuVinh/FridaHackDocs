class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3c7a0f4*/ EmbeddedAttribute();
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

                /*0x3c7a0fc*/ NullableAttribute(byte );
                /*0x3c7a184*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x3c7a1b4*/ NullableContextAttribute(byte );
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

    static /*0x3c7ace8*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> <CalculateAllDownloadSize>g__GetAllDependenciesRecursive|5_2(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location, System.Collections.Generic.HashSet<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> visited);
    /*0x3c7ac3c*/ AddressablesDownloader();
    /*0x3c7a1dc*/ System.IObservable<AddressablesDownloader.RemoteAssetLoadProgress> OnDownloadProgress();
    /*0x3c7a24c*/ Cysharp.Threading.Tasks.UniTask<AddressablesDownloader.AddresssablesDownloaderViewModel> CalculateAllDownloadSize();
    /*0x3c7a350*/ Cysharp.Threading.Tasks.UniTask<AddressablesDownloader.AddresssablesDownloaderViewModel> CalculateDownloadSize(System.Collections.Generic.IEnumerable<object> keys);
    /*0x3c7a468*/ void CancelDownloadSizeCalculation();
    /*0x3c7a4a4*/ Cysharp.Threading.Tasks.UniTask<bool> Download(AddressablesDownloader.AddresssablesDownloaderViewModel model);
    /*0x3c7a59c*/ long GetFreeDiskSpace();
    /*0x3c7aa6c*/ Cysharp.Threading.Tasks.UniTask<AddressablesDownloader.AddresssablesDownloaderViewModel> CalculateDownloadSize(System.Collections.Generic.List<object> keys, System.Threading.CancellationToken token);
    /*0x3c7ab84*/ float GetSpentTime(System.DateTime startTime);

    class RemoteAssetLoadProgress
    {
        /*0x10*/ long <Max>k__BackingField;
        /*0x18*/ long <Current>k__BackingField;
        /*0x20*/ float <SpentTimeSec>k__BackingField;
        /*0x24*/ bool <HasError>k__BackingField;

        /*0x3c7adf8*/ RemoteAssetLoadProgress();
        /*0x3c7adb4*/ long get_Max();
        /*0x3c7adbc*/ void set_Max(long value);
        /*0x3c7adc4*/ long get_Current();
        /*0x3c7adcc*/ void set_Current(long value);
        /*0x3c7add4*/ float get_SpentTimeSec();
        /*0x3c7addc*/ void set_SpentTimeSec(float value);
        /*0x3c7ade4*/ bool get_HasError();
        /*0x3c7adec*/ void set_HasError(bool value);
    }

    class AddresssablesDownloaderViewModel
    {
        /*0x10*/ long <Size>k__BackingField;
        /*0x18*/ System.Collections.Generic.List<object> <Keys>k__BackingField;

        /*0x3c7ae20*/ AddresssablesDownloaderViewModel();
        /*0x3c7ae00*/ long get_Size();
        /*0x3c7ae08*/ void set_Size(long value);
        /*0x3c7ae10*/ System.Collections.Generic.List<object> get_Keys();
        /*0x3c7ae18*/ void set_Keys(System.Collections.Generic.List<object> value);
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

        /*0x3c7ad80*/ <<CalculateAllDownloadSize>g__GetAllDependenciesRecursive|5_2>d(int <>1__state);
        /*0x3c7ae28*/ void System.IDisposable.Dispose();
        /*0x3c7aedc*/ bool MoveNext();
        /*0x3c7b620*/ void <>m__Finally1();
        /*0x3c7b570*/ void <>m__Finally2();
        /*0x3c7b6d0*/ UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation System.Collections.Generic.IEnumerator<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>.get_Current();
        /*0x3c7b6d8*/ void System.Collections.IEnumerator.Reset();
        /*0x3c7b710*/ object System.Collections.IEnumerator.get_Current();
        /*0x3c7b718*/ System.Collections.Generic.IEnumerator<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>.GetEnumerator();
        /*0x3c7b7cc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
    }

    class <>c
    {
        static /*0x0*/ AddressablesDownloader.<> <>9;
        static /*0x8*/ System.Func<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator, System.Collections.Generic.IEnumerable<object>> <>9__5_0;
        static /*0x10*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, bool> <>9__5_3;
        static /*0x18*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation>> <>9__5_4;
        static /*0x20*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, bool> <>9__5_5;
        static /*0x28*/ System.Func<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation, string> <>9__5_6;

        static /*0x3c7b7d0*/ <>c();
        /*0x3c7b838*/ <>c();
        /*0x3c7b840*/ System.Collections.Generic.IEnumerable<object> <CalculateAllDownloadSize>b__5_0(UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator locator);
        /*0x3c7b8e0*/ bool <CalculateAllDownloadSize>b__5_3(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
        /*0x3c7b980*/ System.Collections.Generic.IEnumerable<UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation> <CalculateAllDownloadSize>b__5_4(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
        /*0x3c7b98c*/ bool <CalculateAllDownloadSize>b__5_5(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
        /*0x3c7ba3c*/ string <CalculateAllDownloadSize>b__5_6(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
    }

    class <>c__DisplayClass5_0
    {
        /*0x10*/ AddressablesDownloader <>4__this;
        /*0x18*/ System.Collections.Generic.HashSet<string> seenBundleIds;
        /*0x20*/ System.Func<string, bool> <>9__7;

        /*0x3c7bad8*/ <>c__DisplayClass5_0();
        /*0x3c7bae0*/ bool <CalculateAllDownloadSize>b__1(string key);
        /*0x3c7bb5c*/ bool <CalculateAllDownloadSize>b__7(string id);
    }

    class <>c__DisplayClass8_0
    {
        /*0x10*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle;
        /*0x28*/ long lastDownloaded;
        /*0x30*/ AddressablesDownloader <>4__this;
        /*0x38*/ long maxSize;
        /*0x40*/ System.DateTime startTime;

        /*0x3c7bbb4*/ <>c__DisplayClass8_0();
        /*0x3c7bbbc*/ bool <Download>b__0();
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

        /*0x3c7bcd0*/ void MoveNext();
        /*0x3c7d41c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <CalculateDownloadSize>d__10 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<AddressablesDownloader.AddresssablesDownloaderViewModel> <>t__builder;
        /*0x30*/ System.Collections.Generic.List<object> keys;
        /*0x38*/ System.Threading.CancellationToken token;
        /*0x40*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<long> <handle>5__2;
        /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<long> <>u__1;

        /*0x3c7d474*/ void MoveNext();
        /*0x3c7da64*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <CalculateDownloadSize>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<AddressablesDownloader.AddresssablesDownloaderViewModel> <>t__builder;
        /*0x30*/ AddressablesDownloader <>4__this;
        /*0x38*/ System.Collections.Generic.IEnumerable<object> keys;
        /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<AddressablesDownloader.AddresssablesDownloaderViewModel> <>u__1;

        /*0x3c7dabc*/ void MoveNext();
        /*0x3c7e0a4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <Download>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<bool> <>t__builder;
        /*0x30*/ AddressablesDownloader <>4__this;
        /*0x38*/ AddressablesDownloader.AddresssablesDownloaderViewModel model;
        /*0x40*/ AddressablesDownloader.<> <>8__1;
        /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

        /*0x3c7e0fc*/ void MoveNext();
        /*0x3c7e83c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x3c7e894*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x3c7e988*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
        static /*0x3c7e990*/ void RegisterProviders(VContainer.IContainerBuilder builder);

        class <>c
        {
            static /*0x0*/ VContainer.AssetManagementContainerBuilderExtension.<> <>9;
            static /*0x8*/ System.Func<System.Type, bool> <>9__0_0;
            static /*0x10*/ System.Func<System.Type, bool> <>9__0_1;
            static /*0x18*/ System.Func<System.Type, bool> <>9__0_2;
            static /*0x20*/ System.Func<System.Type, bool> <>9__0_3;

            static /*0x3c7ee18*/ <>c();
            /*0x3c7ee80*/ <>c();
            /*0x3c7ee88*/ bool <RegisterProviders>b__0_0(System.Type t);
            /*0x3c7eecc*/ bool <RegisterProviders>b__0_1(System.Type t);
            /*0x3c7ef30*/ bool <RegisterProviders>b__0_2(System.Type t);
            /*0x3c7ef74*/ bool <RegisterProviders>b__0_3(System.Type t);
        }
    }
}

namespace Assets
{
    namespace AssetManagement
    {
        interface IAddressablesAssetProvider
        {
            /*0x3813ffc*/ bool get_DetailedLogging();
            /*0x3815cc4*/ void set_DetailedLogging(bool value);
            Cysharp.Threading.Tasks.UniTask Initialize(string remoteLoadPath, Assets.AssetManagement.AddressablesAssetProvider.RuntimeCachingPersistencePolicies cachePersistence, Assets.AssetManagement.AddressablesAssetProvider.UntrackedCacheLifetimeTypes untrackedCacheLifetime);
            /*0x3815874*/ Cysharp.Threading.Tasks.UniTask Reload();
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key, UnityEngine.GameObject owner);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key, UnityEngine.MonoBehaviour owner);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key);
            Cysharp.Threading.Tasks.UniTask<Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult> LoadSceneAsync(string key);
            /*0x38159dc*/ void ManuallyUpdateRuntimeCache();
        }

        interface IAssetInstanceProvider
        {
            Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key, bool active);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key, UnityEngine.Transform transform);
            Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key, UnityEngine.Transform transform, bool active);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key, bool active);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key, UnityEngine.Transform transform);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key, UnityEngine.Transform transform, bool active);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args, bool active);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args, UnityEngine.Transform transform);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args, UnityEngine.Transform transform, bool active);
        }

        class AddressablesAssetProvider : Assets.AssetManagement.IAddressablesAssetProvider, Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSAssetProvider, Assets.AssetManagement.IAssetInstanceProvider
        {
            /*0x10*/ System.Collections.Generic.Dictionary<object, Assets.AssetManagement.AddressablesAssetProvider.OperationCacheData> assetCache;
            /*0x18*/ object locked;
            /*0x20*/ bool <DetailedLogging>k__BackingField;
            /*0x24*/ Assets.AssetManagement.AddressablesAssetProvider.RuntimeCachingPersistencePolicies cachePersistence;
            /*0x28*/ int untrackedCacheLifetime;
            /*0x2c*/ bool operationInProgress;

            /*0x3c7fd98*/ AddressablesAssetProvider();
            /*0x3c7efd8*/ bool get_DetailedLogging();
            /*0x3c7efe0*/ void set_DetailedLogging(bool value);
            /*0x3c7efec*/ Cysharp.Threading.Tasks.UniTask Initialize(string assetUrl, Assets.AssetManagement.AddressablesAssetProvider.RuntimeCachingPersistencePolicies cachePersistence, Assets.AssetManagement.AddressablesAssetProvider.UntrackedCacheLifetimeTypes untrackedCacheLifetime);
            /*0x3c7f0d0*/ Cysharp.Threading.Tasks.UniTask Reload();
            /*0x3c7f160*/ Cysharp.Threading.Tasks.UniTask<Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult> LoadSceneAsync(string key);
            /*0x3c7f278*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key);
            /*0x3c7f3f4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key, bool active);
            /*0x3c7f42c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key, UnityEngine.Transform transform);
            /*0x3c7f2b0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Instantiate(object key, UnityEngine.Transform transform, bool active);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key, bool active);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key, UnityEngine.Transform transform);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateComponent<T>(object key, UnityEngine.Transform transform, bool active);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args, bool active);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args, UnityEngine.Transform transform);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> InstantiateUCS<T>(object key, object args, UnityEngine.Transform transform, bool active);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key, UnityEngine.MonoBehaviour owner);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key, UnityEngine.GameObject owner);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> Load<T>(object key, bool increment, bool retry);
            /*0x3c7f460*/ void AttachNotifyOnDestroy(object key, UnityEngine.GameObject owner);
            /*0x3c7f78c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSAssetProvider.Instantiate(object key, UnityEngine.Transform transform, bool active);
            /*0x3910ae8*/ Cysharp.Threading.Tasks.UniTask<T> Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSAssetProvider.Load<T>(object key);
            /*0x3c7f7c0*/ void ExceptionHandler(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle handle, System.Exception exception);
            /*0x3c7f84c*/ void ManuallyUpdateRuntimeCache();

            class OperationCacheData
            {
                /*0x10*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle <OperationHandle>k__BackingField;
                /*0x28*/ int <ReferenceCount>k__BackingField;
                /*0x2c*/ int <UntrackedLifetime>k__BackingField;
                /*0x30*/ bool <Untracked>k__BackingField;

                /*0x3c7fec0*/ OperationCacheData();
                /*0x3c7fe58*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle get_OperationHandle();
                /*0x3c7fe6c*/ void set_OperationHandle(UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle value);
                /*0x3c7fe8c*/ int get_ReferenceCount();
                /*0x3c7fe94*/ void set_ReferenceCount(int value);
                /*0x3c7fe9c*/ int get_UntrackedLifetime();
                /*0x3c7fea4*/ void set_UntrackedLifetime(int value);
                /*0x3c7feac*/ bool get_Untracked();
                /*0x3c7feb4*/ void set_Untracked(bool value);
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

                /*0x3c7fec8*/ <>c__DisplayClass11_0();
                /*0x3c7fed0*/ bool <LoadSceneAsync>b__0();
            }

            class <>c__DisplayClass27_0<T>
            {
                /*0x0*/ Assets.AssetManagement.AddressablesAssetProvider <>4__this;
                /*0x0*/ Assets.AssetManagement.AddressablesAssetProvider.OperationCacheData cache;

                /*0x38159dc*/ <>c__DisplayClass27_0();
                /*0x3813ffc*/ bool <Load>b__0();
                /*0x3813ffc*/ bool <Load>b__1();
            }

            class <>c__DisplayClass28_0
            {
                /*0x10*/ Assets.AssetManagement.AddressablesAssetProvider <>4__this;
                /*0x18*/ object key;

                /*0x3c7f650*/ <>c__DisplayClass28_0();
                /*0x3c7ff18*/ void <AttachNotifyOnDestroy>b__0();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ string assetUrl;
                /*0x18*/ Assets.AssetManagement.AddressablesAssetProvider <>4__this;

                /*0x3c80118*/ <>c__DisplayClass9_0();
                /*0x3c80120*/ string <Initialize>g__InternalIdTransformFunc|0(UnityEngine.ResourceManagement.ResourceLocations.IResourceLocation location);
                /*0x3c80270*/ void <Initialize>b__1(UnityEngine.SceneManagement.Scene _);
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

                /*0x3c80288*/ void MoveNext();
                /*0x3c80f68*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3c80f74*/ void MoveNext();
                /*0x3c816bc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x38159dc*/ void MoveNext();
                /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x38159dc*/ void MoveNext();
                /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Load>d__26<T> : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<T> <>t__builder;
                /*0x0*/ Assets.AssetManagement.AddressablesAssetProvider <>4__this;
                /*0x0*/ object key;
                /*0x0*/ UnityEngine.GameObject owner;
                /*0x0*/ Cysharp.Threading.Tasks.UniTask.Awaiter<T> <>u__1;

                /*0x38159dc*/ void MoveNext();
                /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x38159dc*/ void MoveNext();
                /*0x3816710*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <LoadSceneAsync>d__11 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSSceneManager.LoadSceneResult> <>t__builder;
                /*0x30*/ Assets.AssetManagement.AddressablesAssetProvider <>4__this;
                /*0x38*/ string key;
                /*0x40*/ Assets.AssetManagement.AddressablesAssetProvider.<> <>8__1;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3c81714*/ void MoveNext();
                /*0x3c81d6c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <Reload>d__10 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder <>t__builder;
                /*0x28*/ UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle<System.Collections.Generic.List<UnityEngine.AddressableAssets.ResourceLocators.IResourceLocator>> <handle>5__2;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter <>u__1;

                /*0x3c81dc4*/ void MoveNext();
                /*0x3c823b4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class AddressablesKeyProvider : Assets.UiComponentSystem.Runtime.ExternalInterfaces.IUCSAssetKeyProvider, Assets.AssetManagement.IAddressablesKeyProvider
        {
            /*0x10*/ bool isRated;

            static /*0x3c82670*/ string AcquireGameUiAssetKey(string name);
            /*0x3c85194*/ AddressablesKeyProvider();
            /*0x3c823c0*/ void Initialize(bool rated);
            /*0x3c823cc*/ string TryAcquireThingThumbnailKey(Assets.Api.Client.ThingTypes type, string assetId);
            /*0x3c82580*/ string AcquireBackgroundAssetKeyByType(Assets.Api.Client.BackgroundAssetTypes type, string key);
            /*0x3c82614*/ string AcquireSceneKey(string sceneName);
            /*0x3c8261c*/ string AcquireKey(string key);
            /*0x3c82668*/ string SceneKeyToSceneName(string key);
            /*0x3c826bc*/ string AcquireMainChapterBackgroundAssetKey(string key);
            /*0x3c82708*/ string AcquireAdventureBackgroundAssetKey(string key);
            /*0x3c82754*/ string AcquireMemoryBackgroundKey(string key);
            /*0x3c827a0*/ string AcquireQuestTopBackgroundKey(string key);
            /*0x3c827ec*/ string AcquireShopBackgroundAssetKey(string key);
            /*0x3c82838*/ string AcquireFunctionalBackgroundAssetKey(string key);
            /*0x3c82884*/ string AcquireMazeGuarderIllustBackgroundKey(string key);
            /*0x3c828d0*/ string AcquireItemIconKey(string key);
            /*0x3c8291c*/ string AcquireItemBigIconKey(string key);
            /*0x3c82968*/ string AcquireGemIconKey();
            /*0x3c829a8*/ string AcquireOreIconKey();
            /*0x3c829e8*/ string AcquireMoneyIconKey();
            /*0x3c82a28*/ string AcquireExpIconKey();
            /*0x3c82a68*/ string AcquireCircleExpIconKey();
            /*0x3c82aa8*/ string AcquireTrophyIconKey();
            /*0x3c82ae8*/ string AcquireLocationUnlockPointIconKey();
            /*0x3c82b28*/ string AcquireThumbnailFrameIconKey();
            /*0x3c82b68*/ string AcquireEmotionVfxTemplateKey();
            /*0x3c82ba8*/ string AcquireIconFrameIconKey(string key);
            /*0x3c82bf4*/ string AcquireVipKey(string key);
            /*0x3c82c40*/ string AcquireTrophyKey(string key);
            /*0x3c82c8c*/ string AcquireEmptyTrophyKey();
            /*0x3c82ccc*/ string AcquireTrophyFrameKey(string key);
            /*0x3c82d18*/ string AcquireTrophyStageKey(string key);
            /*0x3c82d64*/ string AcquireTeamEmblemKey(string key);
            /*0x3c82db0*/ string AcquireCharacterNamePlateKey(string key);
            /*0x3c82dfc*/ string AcquireSchoolLogoKey(string key);
            /*0x3c82e48*/ string AcquireTeamLogoKey(string key);
            /*0x3c82e94*/ string AcquireTeamIconKey(string key);
            /*0x3c82ee0*/ string AcquireRelicIconKey(string key);
            /*0x3c82f2c*/ string AcquireStampKey(string key);
            /*0x3c82f78*/ string AcquireTrackTextureKey(string key);
            /*0x3c82fc4*/ string AcquireMainChapterThumbnailAssetKey(string key);
            /*0x3c83010*/ string AcquireMainEpisodeThumbnailAssetKey(string key);
            /*0x3c8305c*/ string AcquireActorIconKey(string key);
            /*0x3c830a8*/ string AcquireQueueIconKey(string key);
            /*0x3c830f4*/ string AcquireShopThumbnailAssetKey(string key);
            /*0x3c83140*/ string AcquireShopProductIconAssetKey(string key);
            /*0x3c8318c*/ string AcquireShopShochikubaiThumbnailAssetKey(string key);
            /*0x3c831d8*/ string AcquireExrtraSkillThumbnailAssetKey(string key);
            /*0x3c83224*/ string AcquireStillThumbnailXAssetKey(string key);
            /*0x3c83270*/ string AcquireSceneThumbnailXAssetKey(string key);
            /*0x3c832bc*/ string AcquireCharacterBackgroundXAssetKey(string key);
            /*0x3c83308*/ string AcquireMazeRouteThumbnailKey(string key);
            /*0x3c83354*/ string AcquireSpotAreaThumbnailKey(string key);
            /*0x3c833a0*/ string AcquireSpotAreaPointThumbnailKey(string key);
            /*0x3c833ec*/ string AcquireTypeEquipmentIconKey(string key);
            /*0x3c83438*/ string AcquireMazeBonusIconKey(string key);
            /*0x3c83484*/ string AcquireMazeEncountBackgroundAssetKey(string key);
            /*0x3c834d0*/ string AcquireModuleIconKey(string key);
            /*0x3c8351c*/ string AcquireCircleIconAssetKey(string key);
            /*0x3c83568*/ string AcquireMazeGuarderThumbnailKey(string key);
            /*0x3c835b4*/ string AcquireMazeGuarderIllustThumbnailAssetKey(string key);
            /*0x3c83600*/ string AcquireAdventureIllustThumbnailAssetKey(string key);
            /*0x3c8364c*/ string AcquireCharacterSquareIllustAssetKey(string key);
            /*0x3c83698*/ string AcquireCharacterVerticalIllustAssetKey(string key);
            /*0x3c836e4*/ string AcquireMachineSquareIllustAssetKey(string key);
            /*0x3c83730*/ string AcquireMemorySquareIllustAssetKey(string key);
            /*0x3c8377c*/ string AcquireCharacterStandSpineKey(string key);
            /*0x3c837c8*/ string AcquireCharacterBackStandSpineKey(string key);
            /*0x3c83814*/ string AcquireBackgoundCharacterSpineKey(string key);
            /*0x3c83860*/ string AcquireBackgroundSceneSpineKey(string key);
            /*0x3c8394c*/ string AcquireBattleCockpitKey(string key);
            /*0x3c83998*/ string AcquireBattleMecanimKey(string key);
            /*0x3c839e4*/ string AcquireBattleExtraSkillSpineKey(string key);
            /*0x3c83a30*/ string AcquireSystemSpineKey(string key);
            /*0x3c83a7c*/ string AcquireFunctionalBackgroundBuiltInImageKey(string key);
            /*0x3c83ac8*/ string AcquireFunctionalBackgroundMemoryImageKey(string key);
            /*0x3c83b14*/ string AcquireFunctionalBackgroundSpotAreaImageKey(string key);
            /*0x3c83b60*/ string AcquireBgmKey(string key);
            /*0x3c83bac*/ string AcquireScenarioVoiceKey(string key);
            /*0x3c83c18*/ string AcquireTalkVoiceKey(string key, string key2);
            /*0x3c83c8c*/ string AcquireSystemVoiceKey(string key);
            /*0x3c83cd8*/ string AcquireSystemVoiceKey(string assetId, string key);
            /*0x3c83d88*/ string AcquireCharacterSystemVoiceKey(string characterId, string key);
            /*0x3c83e38*/ string AcquireCharacterSystemVoiceKey(long characterId, string key);
            /*0x3c83f08*/ string AcquireCharacterMiscellaneousVoiceKey(long characterId, string key);
            /*0x3c83fd8*/ string AcquireCharacterMiscellaneousVoiceKey(string characterId, string key);
            /*0x3c84088*/ string AcquireCharacterBattleVoiceKey(long characterId, string key);
            /*0x3c84158*/ string AcquireCharacterBattleVoiceKey(string characterId, string key);
            /*0x3c84208*/ string AcquireCharacterVoiceKey(string assetId, string key);
            /*0x3c8427c*/ string AcquireScenarioSoundEffectKey(string key);
            /*0x3c842c8*/ string AcquireSoundEffectKey(string key);
            /*0x3c84334*/ string AcquireAnimationAssetKey(string key);
            /*0x3c84380*/ string AcquireAttributeTextureKey(Assets.Api.Client.CharacterAttributes attribute);
            /*0x3c84460*/ string AcquireRoleTextureKey(Assets.Api.Client.CharacterRoleTypes role);
            /*0x3c84534*/ string AcquireRoundTextureKey(string key);
            /*0x3c845a0*/ string AcquireRarityTextureKey(string key);
            /*0x3c8460c*/ string AcquireRarityHorizontalTextureKey(string key);
            /*0x3c84678*/ string AcquireAttributeTextureKey(string key);
            /*0x3c846e4*/ string AcquireBgIconKey(string key);
            /*0x3c84750*/ string AcquireFrameIconKey(string key);
            /*0x3c847bc*/ string AcquireBadgeTextureKey(string key);
            /*0x3c84828*/ string AcquireGachaFrameTextureKey(string key);
            /*0x3c84894*/ string AcquireGachaLightTextureKey(string key);
            /*0x3c84900*/ string AcquireStyleCardFrameTextureKey(string key);
            /*0x3c8496c*/ string AcquirePartyBuffTextureKey(string key);
            /*0x3c849d8*/ string AcquireCharacterTypeTextureKey(string key);
            /*0x3c84a44*/ string AcquireEpisodeIconTextureKey();
            /*0x3c84a84*/ string AcquireSkillTextureKey(string key);
            /*0x3c84af0*/ string AcquireOsTextureKey(string key);
            /*0x3c84b5c*/ string AcquireCharacterEvaluationTextureKey(string key);
            /*0x3c84bc8*/ string AcquireModuleSlotTextureKey(string key);
            /*0x3c84c34*/ string AcquireDmmPointIconKey();
            /*0x3c84c74*/ string AcquireScenarioPlayerIconKey();
            /*0x3c84cb4*/ string AcquireExtraSkillDummyKey();
            /*0x3c84cf4*/ string AcquireBackgroundSceneDummyKey();
            /*0x3c84d34*/ string AcquireBackgroundCharacterDummyKey();
            /*0x3c84d74*/ string AcquireCharacterStandDummyKey();
            /*0x3c84db4*/ string AcquirePlayerTeamIconKey();
            /*0x3c84df4*/ string AcquireEnemyTeamIconKey();
            /*0x3c84e34*/ string AcquireToastTextImageKey(string key);
            /*0x3c84ea0*/ string AcquireRoleTextureKey(string key);
            /*0x3c84f0c*/ string AcquireStatusEffectTextureKey(string key);
            /*0x3c84f78*/ string AcquireScenarioLogIconTextureKey(string key);
            /*0x3c84fe4*/ string AcquireLoadEventIconPartTextureKey(string key);
            /*0x3c85050*/ string AcquireRelicCategoryTextureKey(string key);
            /*0x3c850bc*/ string AcquireKindIconTextureKey(string key);
            /*0x3c85128*/ string AcquireBadgeLabelTextureKey(string key);
            /*0x3c838e0*/ string get_Rating();
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
            /*0x38159dc*/ void ManuallyUpdateRuntimeCache();
            /*0x38159dc*/ void ClearRuntimeCache();
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

            /*0x3c8519c*/ DirectAssetProvider(Assets.Plugins.WebGl.IJSInterop jsinterop);
            /*0x3c85300*/ void Initialize(string storageUrl, bool isAstcSupported, Assets.AssetManagement.DirectAssetProvider.RuntimeCachingPersistencePolicies cachePersistence, Assets.AssetManagement.DirectAssetProvider.UntrackedCacheLifetimeTypes untrackedCacheLifetime);
            /*0x3c85870*/ Cysharp.Threading.Tasks.UniTask<string> AcquireJsonData(string assetKey);
            /*0x3c85a24*/ Cysharp.Threading.Tasks.UniTask<string> AcquireTextData(string assetKey);
            /*0x3c858ec*/ Cysharp.Threading.Tasks.UniTask<string> AcquireStringData(string assetKey, string extension);
            /*0x3c85aa0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> AcquireTexture2D(string assetKey, UnityEngine.MonoBehaviour owner);
            /*0x3c85c30*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> AcquireTexture2D(string assetKey);
            /*0x3c85b00*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> AcquireTexture2D(string originalAssetKey, UnityEngine.GameObject owner);
            /*0x3c85c64*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> AcquireTexture2D(string assetKey, bool increment);
            /*0x3c85d8c*/ Cysharp.Threading.Tasks.UniTask<string> AcquireVideoUrl(string assetKey);
            /*0x3c85ea8*/ bool TryStoreRequestData(UnityEngine.Networking.UnityWebRequest request, string eTagPath, string filePath);
            /*0x3c85f68*/ Cysharp.Threading.Tasks.UniTask<System.ValueTuple<UnityEngine.Networking.UnityWebRequest, string, string>> ProcessWebRequest(string assetKey, string extension, string compression);
            /*0x3c860b0*/ UnityEngine.Texture2D CreateDDSTexture(byte[] bytes);
            /*0x3c8622c*/ UnityEngine.TextureFormat GetTextureFormatFromDDS(byte[] bytes);
            /*0x3c86698*/ UnityEngine.Texture2D CreateASTCTexture(byte[] bytes);
            /*0x3c8541c*/ void ClearOldCache();
            /*0x3c8687c*/ void ManuallyUpdateRuntimeCache();
            /*0x3c86dc0*/ void ClearRuntimeCache();
            /*0x3c86fd4*/ string FixTextureAssetKey(string assetKey);
            /*0x3c8704c*/ string FixVideoAssetKey(string assetKey);
            /*0x3c87098*/ string FixTextAssetKey(string assetKey);
            /*0x3c870e4*/ void <Initialize>b__11_0(UnityEngine.SceneManagement.Scene _);

            class TextureCacheData
            {
                /*0x10*/ UnityEngine.Texture2D <Texture>k__BackingField;
                /*0x18*/ int <ReferenceCount>k__BackingField;
                /*0x1c*/ int <UntrackedLifetime>k__BackingField;
                /*0x20*/ bool <Untracked>k__BackingField;

                /*0x3c8712c*/ TextureCacheData();
                /*0x3c870e8*/ UnityEngine.Texture2D get_Texture();
                /*0x3c870f0*/ void set_Texture(UnityEngine.Texture2D value);
                /*0x3c870f8*/ int get_ReferenceCount();
                /*0x3c87100*/ void set_ReferenceCount(int value);
                /*0x3c87108*/ int get_UntrackedLifetime();
                /*0x3c87110*/ void set_UntrackedLifetime(int value);
                /*0x3c87118*/ bool get_Untracked();
                /*0x3c87120*/ void set_Untracked(bool value);
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

                /*0x3c87134*/ <>c__DisplayClass17_0();
                /*0x3c8713c*/ void <AcquireTexture2D>b__0();
            }

            struct <AcquireStringData>d__14 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<string> <>t__builder;
                /*0x30*/ string assetKey;
                /*0x38*/ Assets.AssetManagement.DirectAssetProvider <>4__this;
                /*0x40*/ string extension;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<UnityEngine.Networking.UnityWebRequest, string, string>> <>u__1;

                /*0x3c87338*/ void MoveNext();
                /*0x3c878f0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3c87948*/ void MoveNext();
                /*0x3c88054*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3c880ac*/ void MoveNext();
                /*0x3c889e4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <AcquireVideoUrl>d__19 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<string> <>t__builder;
                /*0x30*/ string assetKey;
                /*0x38*/ Assets.AssetManagement.DirectAssetProvider <>4__this;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<UnityEngine.Networking.UnityWebRequest, string, string>> <>u__1;
                /*0x68*/ Cysharp.Threading.Tasks.UniTask.Awaiter<string> <>u__2;

                /*0x3c88a3c*/ void MoveNext();
                /*0x3c89244*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3c8929c*/ void MoveNext();
                /*0x3c89c50*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        class DirectKeyProvider : Assets.AssetManagement.IDirectKeyProvider
        {
            /*0x3c8a5a0*/ DirectKeyProvider();
            /*0x3c89ca8*/ string AcquirePolicyTextKey();
            /*0x3c89ce8*/ string AcquireLicenseTextKey();
            /*0x3c89d28*/ string AcquireStampSettingsTextKey();
            /*0x3c89d68*/ string AcquireSubscriptionTextKey(string key);
            /*0x3c89db4*/ string AcquireBackgroundOfLoginBonusAssetKey(string key);
            /*0x3c89e00*/ string AcquireGachaBackgroundAssetKey(string key);
            /*0x3c89e4c*/ string AcquireCharacterBackgroundAssetKey(string key);
            /*0x3c89e98*/ string AcquireShopBackgroundAssetKey(string key);
            /*0x3c89ee4*/ string AcquireSevenDaysMissionBackgroundAssetKey(string key);
            /*0x3c89f30*/ string AcquireLoginBonusBannerAssetKey(string key);
            /*0x3c89f7c*/ string AcquireEventBannerAssetKey(string key);
            /*0x3c89fc8*/ string AcquireGachaBannerAssetKey(string key);
            /*0x3c8a014*/ string AcquireShopBannerAssetKey(string key);
            /*0x3c8a060*/ string AcquireSevenDaysMissionBannerAssetKey(string key);
            /*0x3c8a0ac*/ string AcquireEventLogoAssetKey(string key);
            /*0x3c8a0f8*/ string AcquireLoginBonusLogoAssetKey(string key);
            /*0x3c8a144*/ string AcquireGachaLogoAssetKey(string key);
            /*0x3c8a190*/ string AcquireSevenDaysMissionLogoAssetKey(string key);
            /*0x3c8a1dc*/ string AcquireEventFramePanelAssetKey(string key);
            /*0x3c8a228*/ string AcquireInformationPanelAssetKey(string key);
            /*0x3c8a274*/ string AcquireGachaProductIconAssetKey(string key);
            /*0x3c8a2c0*/ string AcquireShopProductIconAssetKey(string key);
            /*0x3c8a30c*/ string AcquireShopThumbnailAssetKey(string key);
            /*0x3c8a358*/ string AcquireTitleVideoKey();
            /*0x3c8a398*/ string AcquireIntroTitleVideoKey();
            /*0x3c8a3d8*/ string AcquireGachaVideoKey(string assetKey);
            /*0x3c8a424*/ string AcquireHomeVideoKey(string assetKey);
            /*0x3c8a470*/ string AcquireAdventureVideoKey(string assetKey);
            /*0x3c8a4bc*/ string AcquireBattleVideoKey(string assetKey);
            /*0x3c8a508*/ string AcquireChapterBranchVideoKey(string assetKey);
            /*0x3c8a554*/ string AcquireEventVideoKey(string assetKey);
        }

        interface IAddressablesKeyProvider
        {
            /*0x3814a3c*/ string AcquireActorIconKey(string key);
            /*0x3814a3c*/ string AcquireAdventureBackgroundAssetKey(string key);
            /*0x3814a3c*/ string AcquireAttributeTextureKey(string key);
            /*0x38148bc*/ string AcquireBackgroundCharacterDummyKey();
            /*0x3814a3c*/ string AcquireBackgoundCharacterSpineKey(string key);
            /*0x38148bc*/ string AcquireBackgroundSceneDummyKey();
            /*0x3814a3c*/ string AcquireBackgroundSceneSpineKey(string key);
            string AcquireBackgroundAssetKeyByType(Assets.Api.Client.BackgroundAssetTypes type, string key);
            /*0x3814a3c*/ string AcquireBadgeTextureKey(string key);
            /*0x3814a3c*/ string AcquireBattleCockpitKey(string key);
            /*0x3814a3c*/ string AcquireBattleMecanimKey(string key);
            /*0x3814a3c*/ string AcquireBgIconKey(string key);
            /*0x3814a3c*/ string AcquireBgmKey(string key);
            /*0x3814a3c*/ string AcquireScenarioVoiceKey(string key);
            /*0x3814b90*/ string AcquireTalkVoiceKey(string key, string key2);
            /*0x3814a3c*/ string AcquireSoundEffectKey(string key);
            /*0x3814a3c*/ string AcquireCharacterBackgroundXAssetKey(string key);
            /*0x3814a3c*/ string AcquireCharacterBackStandSpineKey(string key);
            /*0x3814a3c*/ string AcquireCharacterNamePlateKey(string key);
            /*0x3814a3c*/ string AcquireStillThumbnailXAssetKey(string key);
            /*0x3814a3c*/ string AcquireSceneThumbnailXAssetKey(string key);
            /*0x3814a3c*/ string AcquireCharacterSquareIllustAssetKey(string key);
            /*0x38148bc*/ string AcquireCharacterStandDummyKey();
            /*0x3814a3c*/ string AcquireCharacterStandSpineKey(string key);
            /*0x3814a3c*/ string AcquireCharacterVerticalIllustAssetKey(string key);
            /*0x38148bc*/ string AcquireCircleExpIconKey();
            /*0x38148bc*/ string AcquireTrophyIconKey();
            /*0x38148bc*/ string AcquireThumbnailFrameIconKey();
            /*0x3814a3c*/ string AcquireCircleIconAssetKey(string key);
            /*0x3814a3c*/ string AcquireCharacterTypeTextureKey(string key);
            /*0x38148bc*/ string AcquireGemIconKey();
            /*0x38148bc*/ string AcquireOreIconKey();
            /*0x38148bc*/ string AcquireDmmPointIconKey();
            /*0x38148bc*/ string AcquireEmptyTrophyKey();
            /*0x38148bc*/ string AcquireEpisodeIconTextureKey();
            /*0x38148bc*/ string AcquireExpIconKey();
            /*0x38148bc*/ string AcquireExtraSkillDummyKey();
            /*0x3814a3c*/ string AcquireExrtraSkillThumbnailAssetKey(string key);
            /*0x3814a3c*/ string AcquireBattleExtraSkillSpineKey(string key);
            /*0x3814a3c*/ string AcquireSystemSpineKey(string key);
            /*0x3814a3c*/ string AcquireFrameIconKey(string key);
            /*0x3814a3c*/ string AcquireFunctionalBackgroundAssetKey(string key);
            /*0x3814a3c*/ string AcquireGachaFrameTextureKey(string key);
            /*0x3814a3c*/ string AcquireGachaLightTextureKey(string key);
            /*0x3814a3c*/ string AcquireIconFrameIconKey(string key);
            /*0x3814a3c*/ string AcquireItemIconKey(string key);
            /*0x3814a3c*/ string AcquireItemBigIconKey(string key);
            /*0x3814a3c*/ string AcquireKey(string key);
            /*0x3814a3c*/ string AcquireMachineSquareIllustAssetKey(string key);
            /*0x3814a3c*/ string AcquireMainChapterBackgroundAssetKey(string key);
            /*0x3814a3c*/ string AcquireMainChapterThumbnailAssetKey(string key);
            /*0x3814a3c*/ string AcquireMainEpisodeThumbnailAssetKey(string key);
            /*0x3814a3c*/ string AcquireMemoryBackgroundKey(string key);
            /*0x3814a3c*/ string AcquireQuestTopBackgroundKey(string key);
            /*0x3814a3c*/ string AcquireMemorySquareIllustAssetKey(string key);
            /*0x38148bc*/ string AcquireMoneyIconKey();
            /*0x3814a3c*/ string AcquireOsTextureKey(string key);
            /*0x3814a3c*/ string AcquireCharacterEvaluationTextureKey(string key);
            /*0x3814a3c*/ string AcquireModuleSlotTextureKey(string key);
            /*0x3814a3c*/ string AcquirePartyBuffTextureKey(string key);
            /*0x3814a3c*/ string AcquireQueueIconKey(string key);
            /*0x3814a3c*/ string AcquireRarityHorizontalTextureKey(string key);
            /*0x3814a3c*/ string AcquireRoundTextureKey(string key);
            /*0x3814a3c*/ string AcquireRarityTextureKey(string key);
            /*0x38148bc*/ string AcquireScenarioPlayerIconKey();
            /*0x3814a3c*/ string AcquireAnimationAssetKey(string key);
            /*0x3814a3c*/ string AcquireSceneKey(string sceneName);
            /*0x3814a3c*/ string AcquireSchoolLogoKey(string key);
            /*0x3814a3c*/ string AcquireShopBackgroundAssetKey(string key);
            /*0x3814a3c*/ string AcquireShopShochikubaiThumbnailAssetKey(string key);
            /*0x3814a3c*/ string AcquireShopThumbnailAssetKey(string key);
            /*0x3814a3c*/ string AcquireShopProductIconAssetKey(string key);
            /*0x3814a3c*/ string AcquireSkillTextureKey(string key);
            /*0x3814a3c*/ string AcquireKindIconTextureKey(string key);
            /*0x3814a3c*/ string AcquireBadgeLabelTextureKey(string key);
            /*0x3814a3c*/ string AcquireSystemVoiceKey(string key);
            /*0x3814a3c*/ string AcquireStampKey(string key);
            /*0x3814a3c*/ string AcquireStyleCardFrameTextureKey(string key);
            /*0x3814a3c*/ string AcquireTeamEmblemKey(string key);
            /*0x3814a3c*/ string AcquireTeamIconKey(string key);
            /*0x3814a3c*/ string AcquireTeamLogoKey(string key);
            /*0x3814a3c*/ string AcquireTrackTextureKey(string key);
            /*0x3814a3c*/ string AcquireTrophyFrameKey(string key);
            /*0x3814a3c*/ string AcquireTrophyKey(string key);
            /*0x3814a3c*/ string AcquireTrophyStageKey(string key);
            /*0x3814a3c*/ string AcquireVipKey(string key);
            /*0x3814a3c*/ string AcquireFunctionalBackgroundBuiltInImageKey(string key);
            /*0x3814a3c*/ string AcquireFunctionalBackgroundMemoryImageKey(string key);
            /*0x3814a3c*/ string AcquireFunctionalBackgroundSpotAreaImageKey(string key);
            /*0x3814a3c*/ string AcquireMazeRouteThumbnailKey(string key);
            /*0x3814a3c*/ string AcquireSpotAreaThumbnailKey(string key);
            /*0x3814a3c*/ string AcquireSpotAreaPointThumbnailKey(string key);
            /*0x3814a3c*/ string AcquireMazeGuarderThumbnailKey(string key);
            /*0x3814a3c*/ string AcquireMazeGuarderIllustThumbnailAssetKey(string key);
            /*0x3814a3c*/ string AcquireAdventureIllustThumbnailAssetKey(string key);
            /*0x3814a3c*/ string AcquireMazeGuarderIllustBackgroundKey(string key);
            /*0x3814a3c*/ string AcquireTypeEquipmentIconKey(string key);
            /*0x3814a3c*/ string AcquireMazeBonusIconKey(string key);
            /*0x3814a3c*/ string AcquireMazeEncountBackgroundAssetKey(string key);
            /*0x3814a3c*/ string AcquireRelicIconKey(string key);
            /*0x3814a3c*/ string SceneKeyToSceneName(string key);
            string TryAcquireThingThumbnailKey(Assets.Api.Client.ThingTypes type, string assetId);
            /*0x3815cc4*/ void Initialize(bool rated);
            /*0x38148bc*/ string AcquirePlayerTeamIconKey();
            /*0x38148bc*/ string AcquireEnemyTeamIconKey();
            /*0x3814a3c*/ string AcquireModuleIconKey(string key);
            /*0x3814a3c*/ string AcquireToastTextImageKey(string key);
            /*0x3814a3c*/ string AcquireRoleTextureKey(string key);
            /*0x3814a3c*/ string AcquireStatusEffectTextureKey(string key);
            /*0x3814a3c*/ string AcquireScenarioLogIconTextureKey(string key);
            /*0x3814a3c*/ string AcquireLoadEventIconPartTextureKey(string key);
            /*0x3814a3c*/ string AcquireRelicCategoryTextureKey(string key);
            string AcquireCharacterSystemVoiceKey(long characterId, string key);
            string AcquireCharacterMiscellaneousVoiceKey(long characterId, string key);
            /*0x3814b90*/ string AcquireCharacterMiscellaneousVoiceKey(string characterId, string key);
            string AcquireCharacterBattleVoiceKey(long characterId, string key);
            /*0x3814b90*/ string AcquireCharacterVoiceKey(string assetId, string key);
            /*0x3814b90*/ string AcquireCharacterBattleVoiceKey(string characterId, string key);
            /*0x3814b90*/ string AcquireCharacterSystemVoiceKey(string characterId, string key);
            /*0x3814b90*/ string AcquireSystemVoiceKey(string assetId, string key);
            /*0x3814a3c*/ string AcquireScenarioSoundEffectKey(string key);
            /*0x38148bc*/ string AcquireLocationUnlockPointIconKey();
            /*0x38148bc*/ string AcquireEmotionVfxTemplateKey();
            /*0x3814964*/ string AcquireAttributeTextureKey(Assets.Api.Client.CharacterAttributes attribute);
            /*0x3814964*/ string AcquireRoleTextureKey(Assets.Api.Client.CharacterRoleTypes role);
        }

        interface IDirectKeyProvider
        {
            /*0x3814a3c*/ string AcquireAdventureVideoKey(string assetKey);
            /*0x3814a3c*/ string AcquireBackgroundOfLoginBonusAssetKey(string key);
            /*0x3814a3c*/ string AcquireBattleVideoKey(string assetKey);
            /*0x3814a3c*/ string AcquireCharacterBackgroundAssetKey(string key);
            /*0x3814a3c*/ string AcquireEventBannerAssetKey(string key);
            /*0x3814a3c*/ string AcquireGachaBackgroundAssetKey(string key);
            /*0x3814a3c*/ string AcquireGachaBannerAssetKey(string key);
            /*0x3814a3c*/ string AcquireGachaVideoKey(string assetKey);
            /*0x3814a3c*/ string AcquireHomeVideoKey(string assetKey);
            /*0x3814a3c*/ string AcquireLoginBonusBannerAssetKey(string key);
            /*0x3814a3c*/ string AcquireLoginBonusLogoAssetKey(string key);
            /*0x3814a3c*/ string AcquireGachaLogoAssetKey(string key);
            /*0x38148bc*/ string AcquirePolicyTextKey();
            /*0x38148bc*/ string AcquireLicenseTextKey();
            /*0x3814a3c*/ string AcquireSubscriptionTextKey(string key);
            /*0x3814a3c*/ string AcquireShopBackgroundAssetKey(string key);
            /*0x3814a3c*/ string AcquireShopThumbnailAssetKey(string key);
            /*0x38148bc*/ string AcquireTitleVideoKey();
            /*0x38148bc*/ string AcquireIntroTitleVideoKey();
            /*0x38148bc*/ string AcquireStampSettingsTextKey();
            /*0x3814a3c*/ string AcquireSevenDaysMissionBackgroundAssetKey(string key);
            /*0x3814a3c*/ string AcquireSevenDaysMissionBannerAssetKey(string key);
            /*0x3814a3c*/ string AcquireSevenDaysMissionLogoAssetKey(string key);
            /*0x3814a3c*/ string AcquireGachaProductIconAssetKey(string key);
            /*0x3814a3c*/ string AcquireShopProductIconAssetKey(string key);
            /*0x3814a3c*/ string AcquireEventLogoAssetKey(string key);
            /*0x3814a3c*/ string AcquireEventFramePanelAssetKey(string key);
            /*0x3814a3c*/ string AcquireInformationPanelAssetKey(string key);
            /*0x3814a3c*/ string AcquireShopBannerAssetKey(string key);
            /*0x3814a3c*/ string AcquireChapterBranchVideoKey(string key);
            /*0x3814a3c*/ string AcquireEventVideoKey(string key);
        }

        class NotifyOnDestroy : UnityEngine.MonoBehaviour
        {
            /*0x20*/ UnityEngine.Events.UnityEvent <OnDestroyEvent>k__BackingField;

            static /*0x3c7f658*/ void AttachTo(UnityEngine.GameObject owner, System.Action callbackOnDestroy);
            /*0x3c8a5d4*/ NotifyOnDestroy();
            /*0x3c8a5a8*/ UnityEngine.Events.UnityEvent get_OnDestroyEvent();
            /*0x3c8a5b0*/ void OnDestroy();

            class <>c__DisplayClass4_0
            {
                /*0x10*/ System.Action callbackOnDestroy;

                /*0x3c8a5cc*/ <>c__DisplayClass4_0();
                /*0x3c8a640*/ void <AttachTo>b__0();
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
            Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> RequestFrontBattleMecanim(string id, UnityEngine.Transform parent, bool active);
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
            /*0x3816710*/ void ReturnMecanim(Assets.AssetManagement.SpineMecanim reference);
            /*0x3816710*/ void ReturnSkeleton(Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController> reference);
            /*0x3816710*/ void ReturnSkeletonMecanim(Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim> reference);
            /*0x3816710*/ void ReturnReference<T>(Assets.AssetManagement.SpineAssetProvider.Reference<T> reference);
        }

        class SpineAssetProvider : Assets.AssetManagement.ISpineAssetProvider
        {
            /*0x10*/ Assets.AssetManagement.IAddressablesAssetProvider assetProvider;
            /*0x18*/ Assets.AssetManagement.IAssetInstanceProvider instanceAssetProvider;
            /*0x20*/ Assets.AssetManagement.IAddressablesKeyProvider keyProvider;
            /*0x28*/ Assets.AssetManagement.IUnusedInstanceManager unusedInstanceManager;

            /*0x3c8a664*/ SpineAssetProvider(Assets.AssetManagement.IAddressablesAssetProvider assetProvider, Assets.AssetManagement.IAssetInstanceProvider instanceAssetProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider, Assets.AssetManagement.IUnusedInstanceManager unusedInstanceManager);
            /*0x3c8a6d8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> RequestAdventureSceneMecanimDummy(UnityEngine.Transform parent, bool active);
            /*0x3c8a7fc*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> RequestAdventureMecanimDummy(UnityEngine.Transform parent, bool active);
            /*0x3c8a920*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> RequestAdventureBackMecanimDummy();
            /*0x3c8a958*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> RequestBackgroundMecanimDummy(UnityEngine.Transform parent, bool active);
            /*0x3c8aa7c*/ Cysharp.Threading.Tasks.UniTask<Assets.Utilities.Spine.SkeletonController> RequestCockpitMecanimDummy(UnityEngine.Transform parent, bool active);
            /*0x3c8aba0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.GameObject> RequestBattleExtraSkillMecanimDummy(UnityEngine.Transform parent, bool active);
            /*0x3c8acc4*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureSceneMecanim(string id);
            /*0x3c8ae40*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureSceneMecanim(string id, bool active);
            /*0x3c8ae78*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureSceneMecanim(string id, UnityEngine.Transform parent);
            /*0x3c8acfc*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureSceneMecanim(string id, UnityEngine.Transform parent, bool active);
            /*0x3c8aeac*/ Cysharp.Threading.Tasks.UniTask PreloadAdventureSceneMecanim(string id);
            /*0x3c8b03c*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureMecanim(string id);
            /*0x3c8b0b0*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureMecanim(string id, bool active);
            /*0x3c8b0ec*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureMecanim(string id, UnityEngine.Transform parent);
            /*0x3c8b078*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureMecanim(string id, UnityEngine.Transform parent, bool active);
            /*0x3c8b124*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureMecanim(string id, UnityEngine.Transform parent, bool active, bool isBackSpine);
            /*0x3c8b274*/ Cysharp.Threading.Tasks.UniTask PreloadAdventureMecanim(string id);
            /*0x3c8b404*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureBackMecanim(string id);
            /*0x3c8b478*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureBackMecanim(string id, bool active);
            /*0x3c8b4b4*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureBackMecanim(string id, UnityEngine.Transform parent);
            /*0x3c8b440*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestAdventureBackMecanim(string id, UnityEngine.Transform parent, bool active);
            /*0x3c8b4ec*/ Cysharp.Threading.Tasks.UniTask PreloadAdventureBackMecanim(string id);
            /*0x3c8b67c*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBackgroundMecanim(string id);
            /*0x3c8b7f8*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBackgroundMecanim(string id, bool active);
            /*0x3c8b830*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBackgroundMecanim(string id, UnityEngine.Transform parent);
            /*0x3c8b6b4*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBackgroundMecanim(string id, UnityEngine.Transform parent, bool active);
            /*0x3c8b864*/ Cysharp.Threading.Tasks.UniTask PreloadBackgroundMecanim(string id);
            /*0x3c8b9f4*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> RequestFrontBattleMecanim(string id);
            /*0x3c8bbc8*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> RequestFrontBattleMecanim(string id, bool active);
            /*0x3c8bc60*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> RequestFrontBattleMecanim(string id, UnityEngine.Transform parent);
            /*0x3c8bcf8*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> RequestFrontBattleMecanim(string id, UnityEngine.Transform parent, bool active);
            /*0x3c8ba84*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> RequestBattleMecanim(string id, UnityEngine.Transform parent, bool active);
            /*0x3c8bd98*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> RequestCockpitSkeleton(string id);
            /*0x3c8bf14*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> RequestCockpitSkeleton(string id, bool active);
            /*0x3c8bf4c*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> RequestCockpitSkeleton(string id, UnityEngine.Transform parent);
            /*0x3c8bdd0*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> RequestCockpitSkeleton(string id, UnityEngine.Transform parent, bool active);
            /*0x3c8bf80*/ Cysharp.Threading.Tasks.UniTask PreloadBattleExtraSkillMecanim(string id);
            /*0x3c8c110*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBattleExtraSkillMecanim(string id);
            /*0x3c8c28c*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBattleExtraSkillMecanim(string id, bool active);
            /*0x3c8c2c4*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBattleExtraSkillMecanim(string id, UnityEngine.Transform parent);
            /*0x3c8c148*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineMecanim> RequestBattleExtraSkillMecanim(string id, UnityEngine.Transform parent, bool active);
            /*0x3c8c2f8*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim>> RequestSystemSkeleton(string id);
            /*0x3c8c474*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim>> RequestSystemSkeleton(string id, bool active);
            /*0x3c8c4ac*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim>> RequestSystemSkeleton(string id, UnityEngine.Transform parent);
            /*0x3c8c330*/ Cysharp.Threading.Tasks.UniTask<Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim>> RequestSystemSkeleton(string id, UnityEngine.Transform parent, bool active);
            /*0x3c8c4e0*/ void ReturnMecanim(Assets.AssetManagement.SpineMecanim reference);
            /*0x3c8c700*/ void ReturnSkeleton(Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController> reference);
            /*0x3c8c7e4*/ void ReturnSkeletonMecanim(Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim> reference);
            /*0x3816710*/ void ReturnReference<T>(Assets.AssetManagement.SpineAssetProvider.Reference<T> reference);

            class Reference<T>
            {
                /*0x0*/ string <Key>k__BackingField;
                /*0x0*/ T <Instance>k__BackingField;

                /*0x3910ae8*/ Reference(string key, T instance);
                /*0x38148bc*/ string get_Key();
                /*0x3910ae8*/ T get_Instance();
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ Assets.AssetManagement.SpineMecanim mecanim;

                /*0x3c8c8c8*/ <>c__DisplayClass20_0();
                /*0x3c8c8d0*/ void <RequestAdventureMecanim>b__0(Assets.Utilities.Spine.FaceStates face, float _);
                /*0x3c8c94c*/ void <RequestAdventureMecanim>b__1(Assets.Utilities.Spine.FaceStates face, float _);
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

                /*0x3c8c970*/ void MoveNext();
                /*0x3c8dc14*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestAdventureMecanimDummy>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ UnityEngine.Transform parent;
                /*0x40*/ bool active;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x3c8dc6c*/ void MoveNext();
                /*0x3c8e290*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3c8e2e8*/ void MoveNext();
                /*0x3c8ee04*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestAdventureSceneMecanimDummy>d__5 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ UnityEngine.Transform parent;
                /*0x40*/ bool active;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x3c8ee5c*/ void MoveNext();
                /*0x3c8f480*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

                /*0x3c8f4d8*/ void MoveNext();
                /*0x3c8fff8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestBackgroundMecanimDummy>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ UnityEngine.Transform parent;
                /*0x40*/ bool active;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x3c90050*/ void MoveNext();
                /*0x3c90674*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestBattleExtraSkillMecanim>d__45 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.AssetManagement.SpineMecanim> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ string id;
                /*0x40*/ UnityEngine.Transform parent;
                /*0x48*/ bool active;
                /*0x50*/ string <key>5__2;
                /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x3c906cc*/ void MoveNext();
                /*0x3c911ec*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestBattleExtraSkillMecanimDummy>d__10 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.GameObject> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ UnityEngine.Transform parent;
                /*0x40*/ bool active;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.GameObject> <>u__1;

                /*0x3c91244*/ void MoveNext();
                /*0x3c91868*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestBattleMecanim>d__36 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.MecanimController>> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ string id;
                /*0x40*/ UnityEngine.Transform parent;
                /*0x48*/ bool active;
                /*0x50*/ string <key>5__2;
                /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Utilities.Spine.MecanimController> <>u__1;

                /*0x3c918c0*/ void MoveNext();
                /*0x3c92200*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestCockpitMecanimDummy>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.Utilities.Spine.SkeletonController> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ UnityEngine.Transform parent;
                /*0x40*/ bool active;
                /*0x48*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Utilities.Spine.SkeletonController> <>u__1;

                /*0x3c92258*/ void MoveNext();
                /*0x3c928d0*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestCockpitSkeleton>d__40 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.AssetManagement.SpineAssetProvider.Reference<Assets.Utilities.Spine.SkeletonController>> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ string id;
                /*0x40*/ UnityEngine.Transform parent;
                /*0x48*/ bool active;
                /*0x50*/ string <key>5__2;
                /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Assets.Utilities.Spine.SkeletonController> <>u__1;

                /*0x3c92928*/ void MoveNext();
                /*0x3c93460*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <RequestSystemSkeleton>d__49 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<Assets.AssetManagement.SpineAssetProvider.Reference<Spine.Unity.SkeletonMecanim>> <>t__builder;
                /*0x30*/ Assets.AssetManagement.SpineAssetProvider <>4__this;
                /*0x38*/ string id;
                /*0x40*/ UnityEngine.Transform parent;
                /*0x48*/ bool active;
                /*0x50*/ string <key>5__2;
                /*0x58*/ Cysharp.Threading.Tasks.UniTask.Awaiter<Spine.Unity.SkeletonMecanim> <>u__1;

                /*0x3c934b8*/ void MoveNext();
                /*0x3c93dcc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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

            /*0x3c8dae8*/ SpineMecanim(string key, UnityEngine.GameObject gameObject);
            /*0x3c93e24*/ string get_Key();
            /*0x3c93e2c*/ UnityEngine.GameObject get_Instance();
            /*0x3c93e34*/ Assets.Utilities.Spine.MecanimController get_MecanimController();
            /*0x3c93e3c*/ Assets.Utilities.Spine.BlinkAnimator get_BlinkAnimator();
            /*0x3c93e44*/ Assets.Utilities.Spine.EmotionAnimator get_EmotionAnimator();
            /*0x3c93e4c*/ Assets.Utilities.Spine.LipSyncAnimator get_LipSyncAnimator();
        }

        interface ITextAssetProvider
        {
            Cysharp.Threading.Tasks.UniTask<string> LoadJsonAsset(string key);
            Cysharp.Threading.Tasks.UniTask<string> LoadTextAsset(string key);
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<string> LoadUserAgreementsJsonData();
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<string> LoadLicenseData();
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<string> LoadStampSettingData();
            Cysharp.Threading.Tasks.UniTask<string> LoadSubscriptionData(string assetId);
        }

        class TextAssetProvider : Assets.AssetManagement.ITextAssetProvider
        {
            /*0x10*/ Assets.AssetManagement.IAddressablesAssetProvider assetProvider;
            /*0x18*/ Assets.AssetManagement.IDirectAssetProvider directAssetProvider;
            /*0x20*/ Assets.AssetManagement.IAddressablesKeyProvider keyProvider;
            /*0x28*/ Assets.AssetManagement.IDirectKeyProvider directKeyProvider;

            /*0x3c93e54*/ TextAssetProvider(Assets.AssetManagement.IAddressablesAssetProvider assetProvider, Assets.AssetManagement.IDirectAssetProvider directAssetProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider, Assets.AssetManagement.IDirectKeyProvider directKeyProvider);
            /*0x3c93ec8*/ Cysharp.Threading.Tasks.UniTask<string> LoadTextDummy();
            /*0x3c93f68*/ Cysharp.Threading.Tasks.UniTask<string> LoadTextAsset(string key);
            /*0x3c94080*/ Cysharp.Threading.Tasks.UniTask<string> LoadJsonAsset(string key);
            /*0x3c94198*/ Cysharp.Threading.Tasks.UniTask<string> LoadUserAgreementsJsonData();
            /*0x3c9426c*/ Cysharp.Threading.Tasks.UniTask<string> LoadLicenseData();
            /*0x3c94340*/ Cysharp.Threading.Tasks.UniTask<string> LoadStampSettingData();
            /*0x3c94414*/ Cysharp.Threading.Tasks.UniTask<string> LoadSubscriptionData(string assetId);

            struct <LoadJsonAsset>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<string> <>t__builder;
                /*0x30*/ Assets.AssetManagement.TextAssetProvider <>4__this;
                /*0x38*/ string key;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<string> <>u__1;

                /*0x3c944f4*/ void MoveNext();
                /*0x3c94c70*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <LoadTextAsset>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<string> <>t__builder;
                /*0x30*/ Assets.AssetManagement.TextAssetProvider <>4__this;
                /*0x38*/ string key;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<string> <>u__1;

                /*0x3c94cc8*/ void MoveNext();
                /*0x3c95444*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGemIconTexture();
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadOreIconTexture();
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadDirectTextureAsset(string id);
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadDummySprite();
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadDummyTexture();
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEpisodeIconTexture();
            Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEventBannerTexture(string id);
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadExpIconTexture();
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
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMoneyIconTexture();
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadDmmPointIconTexture();
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
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEmptyTrophyTexture();
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
            /*0x38159dc*/ void ClearDirectCache();
        }

        class TextureAssetProvider : Assets.AssetManagement.ITextureAssetProvider
        {
            /*0x10*/ Assets.AssetManagement.IAddressablesAssetProvider assetProvider;
            /*0x18*/ Assets.AssetManagement.IDirectAssetProvider directAssetProvider;
            /*0x20*/ Assets.AssetManagement.IAddressablesKeyProvider keyProvider;
            /*0x28*/ Assets.AssetManagement.IDirectKeyProvider directKeyProvider;

            /*0x3c9549c*/ TextureAssetProvider(Assets.AssetManagement.IAddressablesAssetProvider assetProvider, Assets.AssetManagement.IDirectAssetProvider directAssetProvider, Assets.AssetManagement.IAddressablesKeyProvider keyProvider, Assets.AssetManagement.IDirectKeyProvider directKeyProvider);
            /*0x3c95510*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadDummyTexture();
            /*0x3c955d0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadDummySprite();
            /*0x3c956ec*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTextureAsset(object key);
            /*0x3c95804*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadSpriteAsset(object key);
            /*0x3c9591c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadDirectTextureAsset(string key);
            /*0x3c95a34*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadThingThumbnailTexture(Assets.Api.Client.ThingTypes type, string id);
            /*0x3c95b30*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadTeamIcon(bool isEnemyTeam);
            /*0x3c95c48*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadStampTexture(string id);
            /*0x3c95d28*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadCharacterNamePlateTexture(string id);
            /*0x3c95e08*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMemoryBackgroundTexture(string id);
            /*0x3c95ee8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadQuestTopBackgroundTexture(string id);
            /*0x3c95fc8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadRarityTexture(string id);
            /*0x3c960a8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadAdventureBackgroundTexture(string id);
            /*0x3c96188*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTeamIconTexture(string id);
            /*0x3c96268*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTeamVipTexture(string id);
            /*0x3c96348*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadAttributeTexture(string id);
            /*0x3c96428*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadAttributeTexture(Assets.Api.Client.CharacterAttributes attribute);
            /*0x3c96508*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadAttributeSprite(Assets.Api.Client.CharacterAttributes attribute);
            /*0x3c965e8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadCharacterTypeTexture(string id);
            /*0x3c966c8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadBackgroundOfLoginBonusTexture(string id);
            /*0x3c967a8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadFunctionalBackgroundAssetKey(string id);
            /*0x3c96888*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMoneyIconTexture();
            /*0x3c9695c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadDmmPointIconTexture();
            /*0x3c96a30*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadItemIconTexture(string id);
            /*0x3c96b10*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadItemBigIconTexture(string id);
            /*0x3c96bf0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGemIconTexture();
            /*0x3c96cc4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadOreIconTexture();
            /*0x3c96d98*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTeamEmblemTexture(string id);
            /*0x3c96e78*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTeamLogoTexture(string id);
            /*0x3c96f58*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSchoolLogoTexture(string id);
            /*0x3c97038*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGachaLogoTexture(string id);
            /*0x3c97118*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadRarityHorizontalTexture(string id);
            /*0x3c971f8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadPartyBuffTexture(string id);
            /*0x3c972d8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTrackTexture(string id);
            /*0x3c973b8*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTrophyTexture(string id);
            /*0x3c97498*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEmptyTrophyTexture();
            /*0x3c9756c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTrophyFrameTexture(string id);
            /*0x3c9764c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTrophyStageTexture(string id);
            /*0x3c9772c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadBgIconTexture(string id);
            /*0x3c9780c*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadBadgeTexture(string id);
            /*0x3c978ec*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEpisodeIconTexture();
            /*0x3c979c0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMainChapterThumbnailTexture(string id);
            /*0x3c97aa0*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMainEpisodeThumbnailTexture(string id);
            /*0x3c97b80*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGachaFrameTexture(string id);
            /*0x3c97c60*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGachaLightTexture(string id);
            /*0x3c97d40*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadStyleCardFrameTexture(string id);
            /*0x3c97e20*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadExpIconTexture();
            /*0x3c97ef4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadIconFrameIconTexture(string id);
            /*0x3c97fd4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadOsTexture(string id);
            /*0x3c980b4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadCharacterEvaluationTexture(string id);
            /*0x3c98194*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadModuleSlotTexture(string id);
            /*0x3c98274*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSkillTexture(string id);
            /*0x3c98354*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadKindIconTexture(string id);
            /*0x3c98434*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadBadgeLabelTexture(string id);
            /*0x3c98514*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadCharacterSquareIllustTexture(string id);
            /*0x3c985f4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadFrameIconTexture(string id);
            /*0x3c986d4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadLoginBonusLogoTexture(string id);
            /*0x3c987b4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopBackgroundPermanentTexture(string id);
            /*0x3c98894*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopShochikubaiThumbnailTexture(string id);
            /*0x3c98974*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopThumbnailPermanentTexture(string id);
            /*0x3c98a54*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopProductIconPermanentTexture(string id);
            /*0x3c98b34*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadActorIcon(string id);
            /*0x3c98c14*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Sprite> LoadQueueIcon(string id);
            /*0x3c98cf4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadExrtraSkillThumbnailTexture(string id);
            /*0x3c98dd4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadStillThumbnailXTexture(string id);
            /*0x3c98eb4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSceneThumbnailXTexture(string id);
            /*0x3c98f94*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadCharacterBackgroundXTexture(string id);
            /*0x3c99074*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeRouteThumbnailTexture(string id);
            /*0x3c99154*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadRelicIconTexture(string id);
            /*0x3c99234*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSpotAreaThumbnailTexture(string id);
            /*0x3c99314*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSpotAreaPointThumbnailTexture(string id);
            /*0x3c993f4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadTypeEquipmentIconTexture(string id);
            /*0x3c994d4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeBonusIconTexture(string id);
            /*0x3c995b4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeEncountBackgroundTexture(string id);
            /*0x3c99694*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadToastTextImageTexture(string id);
            /*0x3c99774*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadRoleTexture(string id);
            /*0x3c99854*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadRoleTexture(Assets.Api.Client.CharacterRoleTypes role);
            /*0x3c99934*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadStatusEffectTexture(string id);
            /*0x3c99a14*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEventIconPartTexture(string id);
            /*0x3c99af4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGachaBannerTexture(string id);
            /*0x3c99bd4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEventBannerTexture(string id);
            /*0x3c99cb4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadLoginBonusBannerTexture(string id);
            /*0x3c99d94*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopThumbnailTexture(string id);
            /*0x3c99e74*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopBackgroundTexture(string id);
            /*0x3c99f54*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopBannerTexture(string id);
            /*0x3c9a034*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSevenDaysMissionLogoTexture(string id);
            /*0x3c9a114*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadSevenDaysMissionBannerTexture(string id);
            /*0x3c9a1f4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadGachaProductIconTexture(string id);
            /*0x3c9a2d4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadShopProductIconTexture(string id);
            /*0x3c9a3b4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEventLogoTexture(string id);
            /*0x3c9a494*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadEventFramePanelTexture(string id);
            /*0x3c9a574*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadInformationPanelTexture(string id);
            /*0x3c9a654*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeGuarderThumbnailTexture(string id);
            /*0x3c9a734*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeGuarderIllustThumbnailTexture(string id);
            /*0x3c9a814*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadAdventureIllustThumbnailTexture(string id);
            /*0x3c9a8f4*/ Cysharp.Threading.Tasks.UniTask<UnityEngine.Texture2D> LoadMazeGuarderIllustBackgroundTexture(string id);
            /*0x3c9a9d4*/ void ClearDirectCache();

            struct <LoadDirectTextureAsset>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.Texture2D> <>t__builder;
                /*0x30*/ Assets.AssetManagement.TextureAssetProvider <>4__this;
                /*0x38*/ string key;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Texture2D> <>u__1;

                /*0x3c9aa78*/ void MoveNext();
                /*0x3c9b220*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <LoadSpriteAsset>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.Sprite> <>t__builder;
                /*0x30*/ Assets.AssetManagement.TextureAssetProvider <>4__this;
                /*0x38*/ object key;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Sprite> <>u__1;

                /*0x3c9b278*/ void MoveNext();
                /*0x3c9ba34*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }

            struct <LoadTextureAsset>d__7 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<UnityEngine.Texture2D> <>t__builder;
                /*0x30*/ Assets.AssetManagement.TextureAssetProvider <>4__this;
                /*0x38*/ object key;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<UnityEngine.Texture2D> <>u__1;

                /*0x3c9ba8c*/ void MoveNext();
                /*0x3c9c248*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
            }
        }

        interface IUnusedInstanceManager
        {
            /*0x3814574*/ int get_CacheSize();
            /*0x3815ed0*/ void set_CacheSize(int value);
            /*0x3816810*/ void Record(string key, UnityEngine.GameObject instance);
            UnityEngine.GameObject TryRequest(string key, UnityEngine.Transform parent, bool active);
            /*0x3814b90*/ UnityEngine.GameObject TryRequest(string key, UnityEngine.Transform parent);
            /*0x3814a74*/ UnityEngine.GameObject TryRequest(string key, bool active);
            /*0x3814a3c*/ UnityEngine.GameObject TryRequest(string key);
            /*0x3910ae8*/ T TryRequest<T>(string key, UnityEngine.Transform parent, bool active);
            /*0x3910ae8*/ T TryRequest<T>(string key, UnityEngine.Transform parent);
            /*0x3910ae8*/ T TryRequest<T>(string key, bool active);
            /*0x3910ae8*/ T TryRequest<T>(string key);
        }

        class UnusedInstanceManager : UnityEngine.MonoBehaviour, Assets.AssetManagement.IUnusedInstanceManager
        {
            /*0x20*/ System.Collections.Generic.List<Assets.AssetManagement.UnusedInstanceManager.InstanceData> cache;
            /*0x28*/ object cacheLock;
            /*0x30*/ int <CacheSize>k__BackingField;

            /*0x3c9cef4*/ UnusedInstanceManager();
            /*0x3c9c2a0*/ int get_CacheSize();
            /*0x3c9c2a8*/ void set_CacheSize(int value);
            /*0x3c9c2b0*/ void Record(string key, UnityEngine.GameObject instance);
            /*0x3c9c764*/ void TryUnloadExcess();
            /*0x3910ae8*/ T TryRequest<T>(string key);
            /*0x3910ae8*/ T TryRequest<T>(string key, bool active);
            /*0x3910ae8*/ T TryRequest<T>(string key, UnityEngine.Transform parent);
            /*0x3910ae8*/ T TryRequest<T>(string key, UnityEngine.Transform parent, bool active);
            /*0x3c9cab0*/ UnityEngine.GameObject TryRequest(string key);
            /*0x3c9cd08*/ UnityEngine.GameObject TryRequest(string key, bool active);
            /*0x3c9cd14*/ UnityEngine.GameObject TryRequest(string key, UnityEngine.Transform parent);
            /*0x3c9cabc*/ UnityEngine.GameObject TryRequest(string key, UnityEngine.Transform parent, bool active);
            /*0x3c9c54c*/ bool Exist(int instanceId);
            /*0x3c9cd80*/ bool Exist(string key);

            class InstanceData
            {
                /*0x10*/ string <Key>k__BackingField;
                /*0x18*/ UnityEngine.GameObject <GameObject>k__BackingField;
                /*0x20*/ System.DateTime <LastUsed>k__BackingField;
                /*0x28*/ int <InstanceId>k__BackingField;

                /*0x3c9c6b4*/ InstanceData(string key, UnityEngine.GameObject gameObject);
                /*0x3c9cfbc*/ string get_Key();
                /*0x3c9cfc4*/ UnityEngine.GameObject get_GameObject();
                /*0x3c9cfcc*/ System.DateTime get_LastUsed();
                /*0x3c9cfd4*/ void set_LastUsed(System.DateTime value);
                /*0x3c9cfdc*/ int get_InstanceId();
                /*0x3c9cd24*/ void Refresh();
            }

            class <>c
            {
                static /*0x0*/ Assets.AssetManagement.UnusedInstanceManager.<> <>9;
                static /*0x8*/ System.Func<Assets.AssetManagement.UnusedInstanceManager.InstanceData, System.DateTime> <>9__7_0;

                static /*0x3c9cfe4*/ <>c();
                /*0x3c9d04c*/ <>c();
                /*0x3c9d054*/ System.DateTime <TryUnloadExcess>b__7_0(Assets.AssetManagement.UnusedInstanceManager.InstanceData item);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ string key;

                /*0x3c9cd1c*/ <>c__DisplayClass15_0();
                /*0x3c9d06c*/ bool <TryRequest>b__0(Assets.AssetManagement.UnusedInstanceManager.InstanceData item);
            }
        }

        interface IVideoAssetProvider
        {
            Cysharp.Threading.Tasks.UniTask<string> LoadAdventureVideo(string id);
            Cysharp.Threading.Tasks.UniTask<string> LoadGachaVideo(string id);
            Cysharp.Threading.Tasks.UniTask<string> LoadHomeVideo(string id);
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<string> LoadTitleVideo();
            /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<string> LoadIntroTitleVideo();
            Cysharp.Threading.Tasks.UniTask<string> LoadChapterBranchVideo(string id);
            Cysharp.Threading.Tasks.UniTask<string> LoadEventVideo(string id);
        }

        class VideoAssetProvider : Assets.AssetManagement.IVideoAssetProvider
        {
            /*0x10*/ Assets.AssetManagement.IDirectAssetProvider assetProvider;
            /*0x18*/ Assets.AssetManagement.IDirectKeyProvider keyProvider;

            /*0x3c9d090*/ VideoAssetProvider(Assets.AssetManagement.IDirectAssetProvider assetProvider, Assets.AssetManagement.IDirectKeyProvider keyProvider);
            /*0x3c9d0d4*/ Cysharp.Threading.Tasks.UniTask<string> LoadVideoDummy();
            /*0x3c9d174*/ Cysharp.Threading.Tasks.UniTask<string> LoadVideoAsset(string key);
            /*0x3c9d28c*/ Cysharp.Threading.Tasks.UniTask<string> LoadTitleVideo();
            /*0x3c9d360*/ Cysharp.Threading.Tasks.UniTask<string> LoadIntroTitleVideo();
            /*0x3c9d434*/ Cysharp.Threading.Tasks.UniTask<string> LoadGachaVideo(string id);
            /*0x3c9d514*/ Cysharp.Threading.Tasks.UniTask<string> LoadHomeVideo(string id);
            /*0x3c9d5f4*/ Cysharp.Threading.Tasks.UniTask<string> LoadAdventureVideo(string id);
            /*0x3c9d6d0*/ Cysharp.Threading.Tasks.UniTask<string> LoadChapterBranchVideo(string id);
            /*0x3c9d7b0*/ Cysharp.Threading.Tasks.UniTask<string> LoadEventVideo(string id);

            struct <LoadVideoAsset>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<string> <>t__builder;
                /*0x30*/ Assets.AssetManagement.VideoAssetProvider <>4__this;
                /*0x38*/ string key;
                /*0x40*/ Cysharp.Threading.Tasks.UniTask.Awaiter<string> <>u__1;

                /*0x3c9d890*/ void MoveNext();
                /*0x3c9e00c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
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
