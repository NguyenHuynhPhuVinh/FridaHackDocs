class <Module>
{
}

namespace UnityEngine
{
    class AssetBundle : UnityEngine.Object
    {
        static /*0x3d614f0*/ UnityEngine.AssetBundleCreateRequest LoadFromFileAsync_Internal(string path, uint crc, ulong offset);
        static /*0x3d61768*/ UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(string path);
        static /*0x3d61774*/ UnityEngine.AssetBundleCreateRequest LoadFromFileAsync(string path, uint crc);
        static /*0x3d6177c*/ UnityEngine.AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset);
        static /*0x3d619dc*/ UnityEngine.AssetBundle LoadFromFile(string path);
        static /*0x3d62a88*/ UnityEngine.AssetBundleRecompressOperation RecompressAssetBundleAsync(string inputPath, string outputPath, UnityEngine.BuildCompression method, uint expectedCRC, UnityEngine.ThreadPriority priority);
        static /*0x3d62a90*/ UnityEngine.AssetBundleRecompressOperation RecompressAssetBundleAsync_Internal(string inputPath, string outputPath, UnityEngine.BuildCompression method, uint expectedCRC, UnityEngine.ThreadPriority priority);
        static /*0x3d61714*/ nint LoadFromFileAsync_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper path, uint crc, ulong offset);
        static /*0x3d61988*/ nint LoadFromFile_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper path, uint crc, ulong offset);
        static /*0x3d61d10*/ nint LoadAsset_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, System.Type type);
        static /*0x3d62760*/ nint LoadAssetAsync_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, System.Type type);
        static /*0x3d62834*/ void Unload_Injected(nint _unity_self, bool unloadAllLoadedObjects);
        static /*0x3d628f0*/ string[] GetAllAssetNames_Injected(nint _unity_self);
        static /*0x3d629a4*/ string[] GetAllScenePaths_Injected(nint _unity_self);
        static /*0x3d629e0*/ UnityEngine.Object[] LoadAssetWithSubAssets_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, System.Type type);
        static /*0x3d62a34*/ nint LoadAssetWithSubAssetsAsync_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, System.Type type);
        static /*0x3d62d94*/ nint RecompressAssetBundleAsync_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper inputPath, ref UnityEngine.Bindings.ManagedSpanWrapper outputPath, ref UnityEngine.BuildCompression method, uint expectedCRC, UnityEngine.ThreadPriority priority);
        /*0x3d61498*/ AssetBundle();
        /*0x1ffc854*/ T LoadAsset<T>(string name);
        /*0x3d619e8*/ UnityEngine.Object LoadAsset(string name, System.Type type);
        /*0x3d61ae8*/ UnityEngine.Object LoadAsset_Internal(string name, System.Type type);
        /*0x3d61d64*/ UnityEngine.AssetBundleRequest LoadAssetAsync(string name, System.Type type);
        /*0x3d620a4*/ UnityEngine.Object[] LoadAssetWithSubAssets(string name, System.Type type);
        /*0x3d6235c*/ UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync(string name, System.Type type);
        /*0x1f30214*/ UnityEngine.AssetBundleRequest LoadAllAssetsAsync<T>();
        /*0x3d6269c*/ UnityEngine.AssetBundleRequest LoadAllAssetsAsync(System.Type type);
        /*0x3d61e64*/ UnityEngine.AssetBundleRequest LoadAssetAsync_Internal(string name, System.Type type);
        /*0x3d627b4*/ void Unload(bool unloadAllLoadedObjects);
        /*0x3d62878*/ string[] GetAllAssetNames();
        /*0x3d6292c*/ string[] GetAllScenePaths();
        /*0x3d621a4*/ UnityEngine.Object[] LoadAssetWithSubAssets_Internal(string name, System.Type type);
        /*0x3d6245c*/ UnityEngine.AssetBundleRequest LoadAssetWithSubAssetsAsync_Internal(string name, System.Type type);
    }

    class AssetBundleCreateRequest : UnityEngine.AsyncOperation
    {
        static /*0x3d62e88*/ nint get_assetBundle_Injected(nint _unity_self);
        /*0x3d62ec4*/ AssetBundleCreateRequest(nint ptr);
        /*0x3d62e00*/ UnityEngine.AssetBundle get_assetBundle();

        class BindingsMarshaller
        {
            static /*0x3d62ecc*/ UnityEngine.AssetBundleCreateRequest ConvertToManaged(nint ptr);
            static /*0x3d62f28*/ nint ConvertToNative(UnityEngine.AssetBundleCreateRequest assetBundleCreateRequest);
        }
    }

    class AssetBundleRecompressOperation : UnityEngine.AsyncOperation
    {
        static /*0x3d6303c*/ void get_humanReadableResult_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d630d0*/ bool get_success_Injected(nint _unity_self);
        /*0x3d6310c*/ AssetBundleRecompressOperation(nint ptr);
        /*0x3d62f3c*/ string get_humanReadableResult();
        /*0x3d63080*/ bool get_success();

        class BindingsMarshaller
        {
            static /*0x3d63114*/ UnityEngine.AssetBundleRecompressOperation ConvertToManaged(nint ptr);
            static /*0x3d63170*/ nint ConvertToNative(UnityEngine.AssetBundleRecompressOperation op);
        }
    }

    class AssetBundleRequest : UnityEngine.ResourceRequest
    {
        static /*0x3d6320c*/ nint GetResult_Injected(nint _unity_self);
        static /*0x3d632a4*/ UnityEngine.Object[] get_allAssets_Injected(nint _unity_self);
        /*0x3d632e0*/ AssetBundleRequest(nint ptr);
        /*0x3d63184*/ UnityEngine.Object GetResult();
        /*0x3d63248*/ UnityEngine.Object get_asset();
        /*0x3d63254*/ UnityEngine.Object[] get_allAssets();

        class BindingsMarshaller
        {
            static /*0x3d632e8*/ UnityEngine.AssetBundleRequest ConvertToManaged(nint ptr);
            static /*0x3d63344*/ nint ConvertToNative(UnityEngine.AssetBundleRequest request);
        }
    }

    class AssetBundleUnloadOperation : UnityEngine.AsyncOperation
    {
    }
}
