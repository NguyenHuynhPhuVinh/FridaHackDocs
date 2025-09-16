class <Module>
{
}

namespace UnityEngine
{
    class AssetBundle : UnityEngine.Object
    {
        static /*0x7e02f2c*/ UnityEngine.AssetBundle[] GetAllLoadedAssetBundles_Native();
        static /*0x7e02f54*/ System.Collections.Generic.IEnumerable<UnityEngine.AssetBundle> GetAllLoadedAssetBundles();
        static /*0x7e02f7c*/ UnityEngine.AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset);
        static /*0x7e03160*/ UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(string path);
        static /*0x7e0316c*/ UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc);
        static /*0x7e03174*/ UnityEngine.AssetBundle LoadFromMemory_Internal(byte[] binary, uint crc);
        static /*0x7e032a8*/ UnityEngine.AssetBundle LoadFromMemory(byte[] binary);
        static /*0x7e0310c*/ nint LoadFromFileAsync_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper path, uint crc, ulong offset);
        static /*0x7e03264*/ nint LoadFromMemory_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper binary, uint crc);
        static /*0x7e03964*/ nint LoadAssetAsync_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, System.Type type);
        static /*0x7e03a38*/ void Unload_Injected(nint _unity_self, bool unloadAllLoadedObjects);
        static /*0x7e03b10*/ nint UnloadAsync_Injected(nint _unity_self, bool unloadAllLoadedObjects);
        static /*0x7e03bb0*/ nint LoadAssetWithSubAssetsAsync_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, System.Type type);
        /*0x7e02ed4*/ AssetBundle();
        /*0x7e032b0*/ UnityEngine.AssetBundleRequest LoadAssetAsync(string name, System.Type type);
        /*0x7e03570*/ UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, System.Type type);
        /*0x7e03830*/ UnityEngine.AssetBundleRequest LoadAllAssetsAsync();
        /*0x38148bc*/ UnityEngine.AssetBundleRequest LoadAllAssetsAsync<T>();
        /*0x7e038a0*/ UnityEngine.AssetBundleRequest LoadAllAssetsAsync(System.Type type);
        /*0x7e033b0*/ UnityEngine.AssetBundleRequest LoadAssetAsync_Internal(string name, System.Type type);
        /*0x7e039b8*/ void Unload(bool unloadAllLoadedObjects);
        /*0x7e03a7c*/ UnityEngine.AssetBundleUnloadOperation UnloadAsync(bool unloadAllLoadedObjects);
        /*0x7e03670*/ UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, System.Type type);
    }

    class AssetBundleCreateRequest : UnityEngine.AsyncOperation
    {
        static /*0x7e03c8c*/ nint get_assetBundle_Injected(nint _unity_self);
        /*0x7e03cc8*/ AssetBundleCreateRequest(nint ptr);
        /*0x7e03c04*/ UnityEngine.AssetBundle get_assetBundle();

        class BindingsMarshaller
        {
            static /*0x7e03cd0*/ UnityEngine.AssetBundleCreateRequest ConvertToManaged(nint ptr);
            static /*0x7e03d2c*/ nint ConvertToNative(UnityEngine.AssetBundleCreateRequest assetBundleCreateRequest);
        }
    }

    class AssetBundleRecompressOperation : UnityEngine.AsyncOperation
    {
    }

    class AssetBundleRequest : UnityEngine.ResourceRequest
    {
        static /*0x7e03dcc*/ nint GetResult_Injected(nint _unity_self);
        static /*0x7e03e64*/ UnityEngine.Object[] get_allAssets_Injected(nint _unity_self);
        /*0x7e03ea0*/ AssetBundleRequest(nint ptr);
        /*0x7e03d44*/ UnityEngine.Object GetResult();
        /*0x7e03e08*/ UnityEngine.Object get_asset();
        /*0x7e03e14*/ UnityEngine.Object[] get_allAssets();

        class BindingsMarshaller
        {
            static /*0x7e03ea8*/ UnityEngine.AssetBundleRequest ConvertToManaged(nint ptr);
            static /*0x7e03f04*/ nint ConvertToNative(UnityEngine.AssetBundleRequest request);
        }
    }

    class AssetBundleUnloadOperation : UnityEngine.AsyncOperation
    {
        static /*0x7e03f6c*/ void WaitForCompletion_Injected(nint _unity_self);
        /*0x7e03fa8*/ AssetBundleUnloadOperation(nint ptr);
        /*0x7e03f1c*/ void WaitForCompletion();

        class BindingsMarshaller
        {
            static /*0x7e03b54*/ UnityEngine.AssetBundleUnloadOperation ConvertToManaged(nint ptr);
            static /*0x7e03fb0*/ nint ConvertToNative(UnityEngine.AssetBundleUnloadOperation assetBundleUnloadOperation);
        }
    }
}
