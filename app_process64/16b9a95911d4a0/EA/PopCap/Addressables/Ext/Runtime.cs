class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x2bd86f0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x2bd87e0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
            namespace AddressableAssets
            {
                namespace Build
                {
                    namespace Runtime
                    {
                        class CacheLocationProvider
                        {
                            static /*0x0*/ string CacheLocationRoot;

                            static /*0x2bd87e8*/ CacheLocationProvider();
                        }

                        class RuntimeExtraData : UnityEngine.ResourceManagement.EA.IRuntimeLocationSizeData
                        {
                            /*0x10*/ long _runtimeSize;
                            /*0x18*/ long _cloneSize;

                            /*0x2bd8900*/ RuntimeExtraData();
                            /*0x2bd8844*/ long get_RuntimeSize();
                            /*0x2bd884c*/ void set_RuntimeSize(long value);
                            /*0x2bd8854*/ long get_CloneSize();
                            /*0x2bd885c*/ void set_CloneSize(long value);
                            /*0x2bd8864*/ string ToString();
                        }

                        class YetiCatalogUtils
                        {
                            static string PackageInBuildTag = "PackageInBuild";
                            static string LatestTag = "Latest";

                            /*0x2bd8908*/ YetiCatalogUtils();
                        }
                    }
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> C248C4A32B969F74A05B2737E45387219DEA8DDFC325B2A17D1B2F8CAE89B67B;
    static /*0xdd*/ <PrivateImplementationDetails> F0347DD2DE2DB79E8D500966F9E4952D2368AA70952F568C56A9270D47B759B9;

    struct __StaticArrayInitTypeSize=221
    {
    }

    struct __StaticArrayInitTypeSize=233
    {
    }
}
