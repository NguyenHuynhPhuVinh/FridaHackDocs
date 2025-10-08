class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    /*0x3acade0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace Unity
{
    namespace MemoryProfiler
    {
        class MetadataInjector
        {
            static /*0x0*/ Unity.MemoryProfiler.DefaultMetadataCollect DefaultCollector;
            static /*0x8*/ long CollectorCount;
            static /*0x10*/ byte DefaultCollectorInjected;

            static /*0x3acade8*/ void PlayerInitMetadata();
            static /*0x3acaf9c*/ void InitializeMetadataCollection();
        }

        class MetadataCollect : System.IDisposable
        {
            /*0x10*/ bool disposed;

            /*0x3acb06c*/ MetadataCollect();
            /*0x1f30ebc*/ void CollectMetadata(Unity.Profiling.Memory.MemorySnapshotMetadata data);
            /*0x3acae94*/ void Dispose();
        }

        class DefaultMetadataCollect : Unity.MemoryProfiler.MetadataCollect
        {
            /*0x3acb014*/ DefaultMetadataCollect();
            /*0x3acb180*/ void CollectMetadata(Unity.Profiling.Memory.MemorySnapshotMetadata data);
        }
    }
}

class <PrivateImplementationDetails>
{
    struct __StaticArrayInitTypeSize=95
    {
    }

    struct __StaticArrayInitTypeSize=131
    {
    }
}
