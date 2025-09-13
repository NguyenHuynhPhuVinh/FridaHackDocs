class <Module>
{
}

namespace UnityEngine
{
    class AssetBundle : UnityEngine.Object
    {
        static /*0x2b37edc*/ UnityEngine.AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset);
        static /*0x2b37f34*/ UnityEngine.AssetBundle LoadFromFile(string path);
        /*0x2b37e78*/ AssetBundle();
        T LoadAsset<T>(string name);
        /*0x2b37f7c*/ UnityEngine.Object LoadAsset(string name, System.Type type);
        /*0x2b38080*/ UnityEngine.Object LoadAsset_Internal(string name, System.Type type);
        UnityEngine.AssetBundleRequest LoadAssetAsync<T>(string name);
        /*0x2b380d8*/ UnityEngine.AssetBundleRequest LoadAssetAsync(string name, System.Type type);
        /*0x2b381dc*/ UnityEngine.AssetBundleRequest LoadAssetAsync_Internal(string name, System.Type type);
        /*0x2b38234*/ void Unload(bool unloadAllLoadedObjects);
        /*0x2b38284*/ string[] GetAllScenePaths();
    }

    class AssetBundleCreateRequest : UnityEngine.AsyncOperation
    {
    }

    class AssetBundleRecompressOperation : UnityEngine.AsyncOperation
    {
    }

    class AssetBundleRequest : UnityEngine.ResourceRequest
    {
        /*0x2b38310*/ AssetBundleRequest();
        /*0x2b382c4*/ UnityEngine.Object GetResult();
        /*0x2b38304*/ UnityEngine.Object get_asset();
    }
}
