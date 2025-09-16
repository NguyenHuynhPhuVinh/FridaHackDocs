class <Module>
{
}

namespace UnityEngine
{
    class AssetBundle : UnityEngine.Object
    {
        static /*0x7debafc*/ UnityEngine.AssetBundle[] GetAllLoadedAssetBundles_Native();
        static /*0x7debb24*/ System.Collections.Generic.IEnumerable<UnityEngine.AssetBundle> GetAllLoadedAssetBundles();
        static /*0x7debb4c*/ UnityEngine.AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset);
        static /*0x7debd30*/ UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(string path);
        static /*0x7debd3c*/ UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc);
        static /*0x7debd44*/ UnityEngine.AssetBundle LoadFromMemory_Internal(byte[] binary, uint crc);
        static /*0x7debe78*/ UnityEngine.AssetBundle LoadFromMemory(byte[] binary);
        static /*0x7debcdc*/ nint LoadFromFileAsync_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper path, uint crc, ulong offset);
        static /*0x7debe34*/ nint LoadFromMemory_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper binary, uint crc);
        static /*0x7dec534*/ nint LoadAssetAsync_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, System.Type type);
        static /*0x7dec608*/ void Unload_Injected(nint _unity_self, bool unloadAllLoadedObjects);
        static /*0x7dec6e0*/ nint UnloadAsync_Injected(nint _unity_self, bool unloadAllLoadedObjects);
        static /*0x7dec780*/ nint LoadAssetWithSubAssetsAsync_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, System.Type type);
        /*0x7debaa4*/ AssetBundle();
        /*0x7debe80*/ UnityEngine.AssetBundleRequest LoadAssetAsync(string name, System.Type type);
        /*0x7dec140*/ UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, System.Type type);
        /*0x7dec400*/ UnityEngine.AssetBundleRequest LoadAllAssetsAsync();
        /*0x380b9e8*/ UnityEngine.AssetBundleRequest LoadAllAssetsAsync<T>();
        /*0x7dec470*/ UnityEngine.AssetBundleRequest LoadAllAssetsAsync(System.Type type);
        /*0x7debf80*/ UnityEngine.AssetBundleRequest LoadAssetAsync_Internal(string name, System.Type type);
        /*0x7dec588*/ void Unload(bool unloadAllLoadedObjects);
        /*0x7dec64c*/ UnityEngine.AssetBundleUnloadOperation UnloadAsync(bool unloadAllLoadedObjects);
        /*0x7dec240*/ UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, System.Type type);
    }

    class AssetBundleCreateRequest : UnityEngine.AsyncOperation
    {
        static /*0x7dec85c*/ nint get_assetBundle_Injected(nint _unity_self);
        /*0x7dec898*/ AssetBundleCreateRequest(nint ptr);
        /*0x7dec7d4*/ UnityEngine.AssetBundle get_assetBundle();

        class BindingsMarshaller
        {
            static /*0x7dec8a0*/ UnityEngine.AssetBundleCreateRequest ConvertToManaged(nint ptr);
            static /*0x7dec8fc*/ nint ConvertToNative(UnityEngine.AssetBundleCreateRequest assetBundleCreateRequest);
        }
    }

    class AssetBundleRecompressOperation : UnityEngine.AsyncOperation
    {
    }

    class AssetBundleRequest : UnityEngine.ResourceRequest
    {
        static /*0x7dec99c*/ nint GetResult_Injected(nint _unity_self);
        static /*0x7deca34*/ UnityEngine.Object[] get_allAssets_Injected(nint _unity_self);
        /*0x7deca70*/ AssetBundleRequest(nint ptr);
        /*0x7dec914*/ UnityEngine.Object GetResult();
        /*0x7dec9d8*/ UnityEngine.Object get_asset();
        /*0x7dec9e4*/ UnityEngine.Object[] get_allAssets();

        class BindingsMarshaller
        {
            static /*0x7deca78*/ UnityEngine.AssetBundleRequest ConvertToManaged(nint ptr);
            static /*0x7decad4*/ nint ConvertToNative(UnityEngine.AssetBundleRequest request);
        }
    }

    class AssetBundleUnloadOperation : UnityEngine.AsyncOperation
    {
        static /*0x7decb3c*/ void WaitForCompletion_Injected(nint _unity_self);
        /*0x7decb78*/ AssetBundleUnloadOperation(nint ptr);
        /*0x7decaec*/ void WaitForCompletion();

        class BindingsMarshaller
        {
            static /*0x7dec724*/ UnityEngine.AssetBundleUnloadOperation ConvertToManaged(nint ptr);
            static /*0x7decb80*/ nint ConvertToNative(UnityEngine.AssetBundleUnloadOperation assetBundleUnloadOperation);
        }
    }
}
