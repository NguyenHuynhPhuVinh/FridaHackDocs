class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x129c210*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x32f970*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

            static /*0x129be90*/ void PlayerInitMetadata();
            static /*0x129bce0*/ void InitializeMetadataCollection();
        }

        class MetadataCollect : System.IDisposable
        {
            /*0x10*/ bool disposed;

            /*0x129bbb0*/ MetadataCollect();
            /*0x17aec0*/ void CollectMetadata(Unity.Profiling.Memory.MemorySnapshotMetadata data);
            /*0x129ba80*/ void Dispose();
        }

        class DefaultMetadataCollect : Unity.MemoryProfiler.MetadataCollect
        {
            /*0x129b920*/ DefaultMetadataCollect();
            /*0x129b8a0*/ void CollectMetadata(Unity.Profiling.Memory.MemorySnapshotMetadata data);
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 77A467736BEC82387CA4D4B1BE0E47B7D748AB1C6CFBE9A4B44564FA8015EB6D;
    static /*0x83*/ <PrivateImplementationDetails> F25D8D5041790832A6D593FE8EED8995E9C72000ABB787DD4FAE327D906AD347;

    struct __StaticArrayInitTypeSize=88
    {
    }

    struct __StaticArrayInitTypeSize=131
    {
    }
}
