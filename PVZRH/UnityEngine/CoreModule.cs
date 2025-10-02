class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x534220*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsUnmanagedAttribute : System.Attribute
            {
                /*0x534220*/ IsUnmanagedAttribute();
            }
        }
    }
}

namespace AOT
{
    class MonoPInvokeCallbackAttribute : System.Attribute
    {
        /*0x534220*/ MonoPInvokeCallbackAttribute(System.Type type);
    }
}

namespace UnityEngineInternal
{
    struct MathfInternal
    {
        static /*0x0*/ float FloatMinNormal;
        static /*0x4*/ float FloatMinDenormal;
        static /*0x8*/ bool IsFlushToZeroEnabled;

        static /*0x15cdee0*/ MathfInternal();
    }

    enum TypeInferenceRules
    {
        TypeReferencedByFirstArgument = 0,
        TypeReferencedBySecondArgument = 1,
        ArrayOfTypeReferencedByFirstArgument = 2,
        TypeOfFirstArgument = 3,
    }

    class TypeInferenceRuleAttribute : System.Attribute
    {
        /*0x10*/ string _rule;

        /*0x15dd5e0*/ TypeInferenceRuleAttribute(UnityEngineInternal.TypeInferenceRules rule);
        /*0xa32e30*/ TypeInferenceRuleAttribute(string rule);
        /*0x9e3110*/ string ToString();
    }

    class GenericStack : System.Collections.Stack
    {
        /*0x15c6be0*/ GenericStack();
    }
}

namespace Unity
{
    namespace Jobs
    {
        interface IJob
        {
            /*0x180fc0*/ void Execute();
        }

        class IJobExtensions
        {
            static /*0x180ff0*/ void EarlyJobInit<T>();
            static nint GetReflectionData<T>();
            static /*0x2a5510*/ Unity.Jobs.JobHandle Schedule<T>(T jobData, Unity.Jobs.JobHandle dependsOn);
            static /*0x2a5510*/ void Run<T>(T jobData);

            struct JobStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x180ff0*/ JobStruct();
                static /*0x180ff0*/ void Initialize();
                static /*0x1830f0*/ void Execute(ref T data, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

                class ExecuteJobFunction<T> : System.MulticastDelegate
                {
                    ExecuteJobFunction(object object, nint method);
                    void Invoke(ref T data, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);
                }
            }
        }

        interface IJobFor
        {
            /*0x17aa40*/ void Execute(int index);
        }

        class IJobForExtensions
        {
            static nint GetReflectionData<T>();
            static /*0x2a5510*/ Unity.Jobs.JobHandle ScheduleParallel<T>(T jobData, int arrayLength, int innerloopBatchCount, Unity.Jobs.JobHandle dependency);

            struct ForJobStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x180ff0*/ ForJobStruct();
                static /*0x180ff0*/ void Initialize();
                static /*0x1830f0*/ void Execute(ref T jobData, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

                class ExecuteJobFunction<T> : System.MulticastDelegate
                {
                    ExecuteJobFunction(object object, nint method);
                    void Invoke(ref T data, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);
                }
            }
        }

        interface IJobParallelFor
        {
            /*0x17aa40*/ void Execute(int index);
        }

        class IJobParallelForExtensions
        {
            static nint GetReflectionData<T>();
            static /*0x2a5510*/ Unity.Jobs.JobHandle Schedule<T>(T jobData, int arrayLength, int innerloopBatchCount, Unity.Jobs.JobHandle dependsOn);

            struct ParallelForJobStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x180ff0*/ ParallelForJobStruct();
                static /*0x180ff0*/ void Initialize();
                static /*0x1830f0*/ void Execute(ref T jobData, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

                class ExecuteJobFunction<T> : System.MulticastDelegate
                {
                    ExecuteJobFunction(object object, nint method);
                    void Invoke(ref T data, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);
                }
            }
        }

        struct JobHandle : System.IEquatable<Unity.Jobs.JobHandle>
        {
            /*0x10*/ ulong jobGroup;
            /*0x18*/ int version;

            static /*0x15ca310*/ void ScheduleBatchedJobs();
            static /*0x15ca290*/ void ScheduleBatchedJobsAndComplete(ref Unity.Jobs.JobHandle job);
            static /*0x15ca2d0*/ bool ScheduleBatchedJobsAndIsCompleted(ref Unity.Jobs.JobHandle job);
            static /*0x15ca1d0*/ Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle job0, Unity.Jobs.JobHandle job1);
            static /*0x15c9fe0*/ Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle job0, Unity.Jobs.JobHandle job1, Unity.Jobs.JobHandle job2);
            static /*0x15ca060*/ Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeArray<Unity.Jobs.JobHandle> jobs);
            static /*0x15ca110*/ Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeSlice<Unity.Jobs.JobHandle> jobs);
            static /*0x15c9df0*/ Unity.Jobs.JobHandle CombineDependenciesInternal2(ref Unity.Jobs.JobHandle job0, ref Unity.Jobs.JobHandle job1);
            static /*0x15c9ec0*/ Unity.Jobs.JobHandle CombineDependenciesInternal3(ref Unity.Jobs.JobHandle job0, ref Unity.Jobs.JobHandle job1, ref Unity.Jobs.JobHandle job2);
            static /*0x15c9f80*/ Unity.Jobs.JobHandle CombineDependenciesInternalPtr(void* jobs, int count);
            static /*0x15c9d90*/ void CombineDependenciesInternal2_Injected(ref Unity.Jobs.JobHandle job0, ref Unity.Jobs.JobHandle job1, ref Unity.Jobs.JobHandle ret);
            static /*0x15c9e50*/ void CombineDependenciesInternal3_Injected(ref Unity.Jobs.JobHandle job0, ref Unity.Jobs.JobHandle job1, ref Unity.Jobs.JobHandle job2, ref Unity.Jobs.JobHandle ret);
            static /*0x15c9f30*/ void CombineDependenciesInternalPtr_Injected(void* jobs, int count, ref Unity.Jobs.JobHandle ret);
            /*0x15ca240*/ void Complete();
            /*0x15ca2d0*/ bool get_IsCompleted();
            /*0x15ca280*/ bool Equals(Unity.Jobs.JobHandle other);
        }

        namespace LowLevel
        {
            namespace Unsafe
            {
                class JobProducerTypeAttribute : System.Attribute
                {
                    /*0x10*/ System.Type <ProducerType>k__BackingField;

                    /*0xa32e30*/ JobProducerTypeAttribute(System.Type producerType);
                }

                struct JobRanges
                {
                    /*0x10*/ int BatchSize;
                    /*0x14*/ int NumJobs;
                    /*0x18*/ int TotalIterationCount;
                    /*0x20*/ nint StartEndIndex;
                }

                enum ScheduleMode
                {
                    Run = 0,
                    Batched = 1,
                    Parallel = 1,
                    Single = 2,
                }

                class JobsUtility
                {
                    static /*0x0*/ Unity.Jobs.LowLevel.Unsafe.JobsUtility.PanicFunction_ PanicFunction;

                    static /*0x15ca460*/ void GetJobRange(ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex, ref int beginIndex, ref int endIndex);
                    static /*0x15ca4b0*/ bool GetWorkStealingRange(ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex, ref int beginIndex, ref int endIndex);
                    static /*0x15ca740*/ Unity.Jobs.JobHandle Schedule(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters);
                    static /*0x15ca680*/ Unity.Jobs.JobHandle ScheduleParallelFor(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount);
                    static /*0x15ca5c0*/ Unity.Jobs.JobHandle ScheduleParallelForTransform(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, nint transfromAccesssArray);
                    static /*0x15ca3f0*/ nint CreateJobReflectionData(System.Type wrapperJobType, System.Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2);
                    static /*0x15ca380*/ nint CreateJobReflectionData(System.Type type, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2);
                    static /*0x15ca790*/ bool get_IsExecutingJob();
                    static /*0x15ca7c0*/ void set_JobCompilerEnabled(bool value);
                    static /*0x15ca510*/ void InvokePanicFunction();
                    static /*0x15ca6f0*/ void Schedule_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, ref Unity.Jobs.JobHandle ret);
                    static /*0x15ca620*/ void ScheduleParallelFor_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, ref Unity.Jobs.JobHandle ret);
                    static /*0x15ca560*/ void ScheduleParallelForTransform_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, nint transfromAccesssArray, ref Unity.Jobs.JobHandle ret);

                    struct JobScheduleParameters
                    {
                        /*0x10*/ Unity.Jobs.JobHandle Dependency;
                        /*0x20*/ int ScheduleMode;
                        /*0x28*/ nint ReflectionData;
                        /*0x30*/ nint JobDataPtr;

                        /*0x15ca340*/ JobScheduleParameters(void* i_jobData, nint i_reflectionData, Unity.Jobs.JobHandle i_dependency, Unity.Jobs.LowLevel.Unsafe.ScheduleMode i_scheduleMode);
                    }

                    class PanicFunction_ : System.MulticastDelegate
                    {
                        /*0xe25c50*/ PanicFunction_(object object, nint method);
                        /*0x9dbe20*/ void Invoke();
                    }
                }
            }
        }
    }

    namespace IL2CPP
    {
        namespace CompilerServices
        {
            class Il2CppEagerStaticClassConstructionAttribute : System.Attribute
            {
                /*0x534220*/ Il2CppEagerStaticClassConstructionAttribute();
            }
        }
    }

    namespace Profiling
    {
        class IgnoredByDeepProfilerAttribute : System.Attribute
        {
            /*0x534220*/ IgnoredByDeepProfilerAttribute();
        }

        struct ProfilerCategory
        {
            /*0x10*/ ushort m_CategoryId;

            static /*0x6bba80*/ Unity.Profiling.ProfilerCategory get_Scripts();
            static /*0x15d1fd0*/ ushort op_Implicit(Unity.Profiling.ProfilerCategory category);
            /*0x9a9130*/ ProfilerCategory(ushort category);
            /*0x15d1ea0*/ string get_Name();
            /*0x15d1e90*/ string ToString();
        }

        enum ProfilerCategoryColor
        {
            Render = 0,
            Scripts = 1,
            BurstJobs = 2,
            Other = 3,
            Physics = 4,
            Animation = 5,
            Audio = 6,
            AudioJob = 7,
            AudioUpdateJob = 8,
            Lighting = 9,
            GC = 10,
            VSync = 11,
            Memory = 12,
            Internal = 13,
            UI = 14,
            Build = 15,
            Input = 16,
        }

        struct ProfilerMarker
        {
            /*0x10*/ nint m_Ptr;

            /*0x15d2090*/ ProfilerMarker(string name);
            /*0x15d2030*/ ProfilerMarker(Unity.Profiling.ProfilerCategory category, string name);
            /*0x15d1fe0*/ Unity.Profiling.ProfilerMarker.AutoScope Auto();

            struct AutoScope : System.IDisposable
            {
                /*0x10*/ nint m_Ptr;

                /*0x15bc0d0*/ AutoScope(nint markerPtr);
                /*0x15bc080*/ void Dispose();
            }
        }

        enum ProfilerMarkerDataUnit
        {
            Undefined = 0,
            TimeNanoseconds = 1,
            Bytes = 2,
            Count = 3,
            Percent = 4,
            FrequencyHz = 5,
        }

        enum ProfilerCounterOptions
        {
            None = 0,
            FlushOnEndOfFrame = 2,
            ResetToZeroOnFlush = 4,
        }

        enum ProfilerRecorderOptions
        {
            None = 0,
            StartImmediately = 1,
            KeepAliveDuringDomainReload = 2,
            CollectOnlyOnCurrentThread = 4,
            WrapAroundWhenCapacityReached = 8,
            SumAllSamplesInFrame = 16,
            GpuRecorder = 64,
            Default = 24,
        }

        struct ProfilerRecorderSample
        {
            /*0x10*/ long value;
            /*0x18*/ long count;
            /*0x20*/ long refValue;

            /*0xa5a7f0*/ long get_Count();
        }

        struct ProfilerRecorder : System.IDisposable
        {
            static Unity.Profiling.ProfilerRecorderOptions SharedRecorder = 128;
            /*0x10*/ ulong handle;

            static /*0x15d24a0*/ Unity.Profiling.ProfilerRecorder Create(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int maxSampleCount, Unity.Profiling.ProfilerRecorderOptions options);
            static /*0x15d2400*/ void Control(Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.ControlOptions options);
            static /*0x15d2610*/ long GetLastValue(Unity.Profiling.ProfilerRecorder handle);
            static /*0x15d2590*/ int GetCount(Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.CountOptions countOptions);
            static /*0x15d2890*/ bool GetValid(Unity.Profiling.ProfilerRecorder handle);
            static /*0x15d2690*/ bool GetRunning(Unity.Profiling.ProfilerRecorder handle);
            static /*0x15d2720*/ Unity.Profiling.ProfilerRecorderSample GetSampleInternal(Unity.Profiling.ProfilerRecorder handle, int index);
            static /*0x15d2440*/ void Create_Injected(ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int maxSampleCount, Unity.Profiling.ProfilerRecorderOptions options, ref Unity.Profiling.ProfilerRecorder ret);
            static /*0x15d23c0*/ void Control_Injected(ref Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.ControlOptions options);
            static /*0x15d25d0*/ long GetLastValue_Injected(ref Unity.Profiling.ProfilerRecorder handle);
            static /*0x15d2550*/ int GetCount_Injected(ref Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.CountOptions countOptions);
            static /*0x15d2850*/ bool GetValid_Injected(ref Unity.Profiling.ProfilerRecorder handle);
            static /*0x15d2650*/ bool GetRunning_Injected(ref Unity.Profiling.ProfilerRecorder handle);
            static /*0x15d26d0*/ void GetSampleInternal_Injected(ref Unity.Profiling.ProfilerRecorder handle, int index, ref Unity.Profiling.ProfilerRecorderSample ret);
            /*0x15d2a10*/ ProfilerRecorder(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int capacity, Unity.Profiling.ProfilerRecorderOptions options);
            /*0x15d2c40*/ bool get_Valid();
            /*0x15d28d0*/ void Start();
            /*0x15d2970*/ void Stop();
            /*0x15d2bb0*/ long get_LastValue();
            /*0x15d2a80*/ int get_Count();
            /*0x15d2b20*/ bool get_IsRunning();
            /*0x15d2780*/ Unity.Profiling.ProfilerRecorderSample GetSample(int index);
            /*0x15d2500*/ void Dispose();
            /*0x15d2350*/ void CheckInitializedAndThrow();

            enum ControlOptions
            {
                Start = 0,
                Stop = 1,
                Reset = 2,
                Release = 4,
                SetFilterToCurrentThread = 5,
                SetToCollectFromAllThreads = 6,
            }

            enum CountOptions
            {
                Count = 0,
                MaxCount = 1,
            }
        }

        class ProfilerRecorderDebugView
        {
        }

        struct DebugScreenCapture
        {
            /*0x10*/ Unity.Collections.NativeArray<byte> <RawImageDataReference>k__BackingField;
            /*0x20*/ UnityEngine.TextureFormat <ImageFormat>k__BackingField;
            /*0x24*/ int <Width>k__BackingField;
            /*0x28*/ int <Height>k__BackingField;

            /*0xdb4640*/ void set_RawImageDataReference(Unity.Collections.NativeArray<byte> value);
            /*0xdcd9c0*/ void set_ImageFormat(UnityEngine.TextureFormat value);
            /*0xc70b20*/ void set_Width(int value);
            /*0x8a5c50*/ void set_Height(int value);
        }

        namespace LowLevel
        {
            enum MarkerFlags
            {
                Default = 0,
                Script = 2,
                ScriptInvoke = 32,
                ScriptDeepProfiler = 64,
                AvailabilityEditor = 4,
                AvailabilityNonDevelopment = 8,
                Warning = 16,
                Counter = 128,
                SampleGPU = 256,
            }

            enum ProfilerMarkerDataType
            {
                InstanceId = 1,
                Int32 = 2,
                UInt32 = 3,
                Int64 = 4,
                UInt64 = 5,
                Float = 6,
                Double = 7,
                String16 = 9,
                Blob8 = 11,
                GfxResourceId = 12,
            }

            namespace Unsafe
            {
                struct ProfilerRecorderDescription
                {
                    /*0x10*/ Unity.Profiling.ProfilerCategory category;
                    /*0x12*/ Unity.Profiling.LowLevel.MarkerFlags flags;
                    /*0x14*/ Unity.Profiling.LowLevel.ProfilerMarkerDataType dataType;
                    /*0x15*/ Unity.Profiling.ProfilerMarkerDataUnit unitType;
                    /*0x18*/ int reserved0;
                    /*0x1c*/ int nameUtf8Len;
                    /*0x20*/ byte* nameUtf8;

                    /*0xba9530*/ Unity.Profiling.LowLevel.MarkerFlags get_Flags();
                }

                struct ProfilerRecorderHandle
                {
                    /*0x10*/ ulong handle;

                    static /*0x15d2250*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescription(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle);
                    static /*0x15d2150*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName__Unmanaged(Unity.Profiling.ProfilerCategory category, byte* name, int nameLen);
                    static /*0x15d2200*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescriptionInternal(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle);
                    static /*0x15d20e0*/ void GetByName__Unmanaged_Injected(ref Unity.Profiling.ProfilerCategory category, byte* name, int nameLen, ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ret);
                    static /*0x15d21b0*/ void GetDescriptionInternal_Injected(ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle, ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription ret);
                    /*0x9e29e0*/ ProfilerRecorderHandle(ulong handle);
                    /*0x15d2330*/ bool get_Valid();
                }

                struct ProfilerCategoryDescription
                {
                    /*0x10*/ ushort Id;
                    /*0x12*/ ushort Flags;
                    /*0x14*/ UnityEngine.Color32 Color;
                    /*0x18*/ int reserved0;
                    /*0x1c*/ int NameUtf8Len;
                    /*0x20*/ byte* NameUtf8;
                }

                class ProfilerUnsafeUtility
                {
                    static /*0x15d2ce0*/ ushort CreateCategory__Unmanaged(byte* name, int nameLen, Unity.Profiling.ProfilerCategoryColor colorIndex);
                    static /*0x15d2f60*/ Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription GetCategoryDescription(ushort categoryId);
                    static /*0x15d2e60*/ nint CreateMarker(string name, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, int metadataCount);
                    static /*0x15d2df0*/ nint CreateMarker__Unmanaged(byte* name, int nameLen, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, int metadataCount);
                    static /*0x15d2fc0*/ void SetMarkerMetadata__Unmanaged(nint markerPtr, int index, byte* name, int nameLen, byte type, byte unit);
                    static /*0x15d2ca0*/ void BeginSample(nint markerPtr);
                    static /*0x15d2ed0*/ void EndSample(nint markerPtr);
                    static /*0x15d2d40*/ void* CreateCounterValue__Unmanaged(ref nint counterPtr, byte* name, int nameLen, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, Unity.Profiling.ProfilerCounterOptions counterOptions);
                    static /*0x15d3040*/ string Utf8ToString(byte* chars, int charsLen);
                    static /*0x15d2f10*/ void GetCategoryDescription_Injected(ushort categoryId, ref Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription ret);
                }
            }
        }

        namespace Memory
        {
            class MemorySnapshotMetadata
            {
                /*0x10*/ string <Description>k__BackingField;
                /*0x18*/ byte[] <Data>k__BackingField;

                /*0x32f970*/ MemorySnapshotMetadata();
                /*0x73d3e0*/ string get_Description();
                /*0x9f12f0*/ void set_Description(string value);
                /*0x32f410*/ byte[] get_Data();
            }

            class MemoryProfiler
            {
                static /*0x0*/ System.Action<string, bool> m_SnapshotFinished;
                static /*0x8*/ System.Action<string, bool, Unity.Profiling.DebugScreenCapture> m_SaveScreenshotToDisk;
                static /*0x10*/ System.Action<Unity.Profiling.Memory.MemorySnapshotMetadata> CreatingMetadata;

                static /*0x15ce5e0*/ void add_CreatingMetadata(System.Action<Unity.Profiling.Memory.MemorySnapshotMetadata> value);
                static /*0x15ce6c0*/ void remove_CreatingMetadata(System.Action<Unity.Profiling.Memory.MemorySnapshotMetadata> value);
                static /*0x15ce060*/ byte[] PrepareMetadata();
                static /*0x15ce4c0*/ int WriteIntToByteArray(byte[] array, int offset, int value);
                static /*0x15ce540*/ int WriteStringToByteArray(byte[] array, int offset, string value);
                static /*0x15cdfd0*/ void FinalizeSnapshot(string path, bool result);
                static /*0x15ce390*/ void SaveScreenshotToDisk(string path, bool result, nint pixelsPtr, int pixelsCount, UnityEngine.TextureFormat format, int width, int height);
            }
        }
    }

    namespace IO
    {
        namespace LowLevel
        {
            namespace Unsafe
            {
                enum FileState
                {
                    Absent = 0,
                    Exists = 1,
                }

                enum AssetLoadingSubsystem
                {
                    Other = 0,
                    Texture = 1,
                    VirtualTexture = 2,
                    Mesh = 3,
                    Audio = 4,
                    Scripts = 5,
                    EntitiesScene = 6,
                    EntitiesStreamBinaryReader = 7,
                    FileInfo = 8,
                    ContentLoading = 9,
                }

                enum Priority
                {
                    PriorityLow = 0,
                    PriorityHigh = 1,
                }

                enum ProcessingState
                {
                    Unknown = 0,
                    InQueue = 1,
                    Reading = 2,
                    Completed = 3,
                    Failed = 4,
                    Canceled = 5,
                }

                enum FileReadType
                {
                    Sync = 0,
                    Async = 1,
                }

                struct AsyncReadManagerRequestMetric
                {
                    /*0x10*/ string <AssetName>k__BackingField;
                    /*0x18*/ string <FileName>k__BackingField;
                    /*0x20*/ ulong <OffsetBytes>k__BackingField;
                    /*0x28*/ ulong <SizeBytes>k__BackingField;
                    /*0x30*/ ulong <AssetTypeId>k__BackingField;
                    /*0x38*/ ulong <CurrentBytesRead>k__BackingField;
                    /*0x40*/ uint <BatchReadCount>k__BackingField;
                    /*0x44*/ bool <IsBatchRead>k__BackingField;
                    /*0x48*/ Unity.IO.LowLevel.Unsafe.ProcessingState <State>k__BackingField;
                    /*0x4c*/ Unity.IO.LowLevel.Unsafe.FileReadType <ReadType>k__BackingField;
                    /*0x50*/ Unity.IO.LowLevel.Unsafe.Priority <PriorityLevel>k__BackingField;
                    /*0x54*/ Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem <Subsystem>k__BackingField;
                    /*0x58*/ double <RequestTimeMicroseconds>k__BackingField;
                    /*0x60*/ double <TimeInQueueMicroseconds>k__BackingField;
                    /*0x68*/ double <TotalTimeMicroseconds>k__BackingField;
                }

                class AsyncReadManagerMetricsFilters
                {
                    /*0x10*/ ulong[] TypeIDs;
                    /*0x18*/ Unity.IO.LowLevel.Unsafe.ProcessingState[] States;
                    /*0x20*/ Unity.IO.LowLevel.Unsafe.FileReadType[] ReadTypes;
                    /*0x28*/ Unity.IO.LowLevel.Unsafe.Priority[] PriorityLevels;
                    /*0x30*/ Unity.IO.LowLevel.Unsafe.AssetLoadingSubsystem[] Subsystems;
                }
            }
        }

        namespace Archive
        {
            enum ArchiveStatus
            {
                InProgress = 0,
                Complete = 1,
                Failed = 2,
            }

            struct ArchiveFileInfo
            {
                /*0x10*/ string Filename;
                /*0x18*/ ulong FileSize;
            }

            struct ArchiveHandle
            {
                /*0x10*/ ulong Handle;
            }

            class ArchiveFileInterface
            {
            }
        }
    }

    namespace Collections
    {
        class ReadOnlyAttribute : System.Attribute
        {
            /*0x534220*/ ReadOnlyAttribute();
        }

        class WriteOnlyAttribute : System.Attribute
        {
            /*0x534220*/ WriteOnlyAttribute();
        }

        class DeallocateOnJobCompletionAttribute : System.Attribute
        {
            /*0x534220*/ DeallocateOnJobCompletionAttribute();
        }

        class NativeFixedLengthAttribute : System.Attribute
        {
        }

        class NativeMatchesParallelForLengthAttribute : System.Attribute
        {
        }

        class NativeDisableParallelForRestrictionAttribute : System.Attribute
        {
            /*0x534220*/ NativeDisableParallelForRestrictionAttribute();
        }

        enum Allocator
        {
            Invalid = 0,
            None = 1,
            Temp = 2,
            TempJob = 3,
            Persistent = 4,
            AudioKernel = 5,
            FirstUserIndex = 64,
        }

        enum LeakCategory
        {
            Invalid = 0,
            Malloc = 1,
            TempJob = 2,
            Persistent = 3,
            LightProbesQuery = 4,
            NativeTest = 5,
            MeshDataArray = 6,
            TransformAccessArray = 7,
            NavMeshQuery = 8,
        }

        enum NativeArrayOptions
        {
            UninitializedMemory = 0,
            ClearMemory = 1,
        }

        struct NativeArray<T> : System.IDisposable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.NativeArray<T>>
        {
            /*0x0*/ void* m_Buffer;
            /*0x0*/ int m_Length;
            /*0x0*/ Unity.Collections.Allocator m_AllocatorLabel;

            static void Allocate(int length, Unity.Collections.Allocator allocator, ref Unity.Collections.NativeArray<T> array);
            static /*0x2a5510*/ bool op_Equality(Unity.Collections.NativeArray<T> left, Unity.Collections.NativeArray<T> right);
            static /*0x2a5510*/ void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst);
            static /*0x2a5510*/ void Copy(T[] src, Unity.Collections.NativeArray<T> dst);
            static /*0x2a5510*/ void Copy(Unity.Collections.NativeArray<T> src, T[] dst);
            static /*0x2a5510*/ void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst, int length);
            static /*0x2a5510*/ void Copy(Unity.Collections.NativeArray<T> src, T[] dst, int length);
            static /*0x2a5510*/ void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
            static /*0x2a5510*/ void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length);
            static /*0x2a5510*/ void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
            static /*0x2a5510*/ void CopySafe(T[] src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
            static /*0x2a5510*/ void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length);
            NativeArray(int length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options);
            /*0x182a70*/ NativeArray(T[] array, Unity.Collections.Allocator allocator);
            /*0x2a5510*/ NativeArray(Unity.Collections.NativeArray<T> array, Unity.Collections.Allocator allocator);
            /*0x180980*/ int get_Length();
            /*0x2a5510*/ T get_Item(int index);
            /*0x2a5510*/ void set_Item(int index, T value);
            /*0x17cb40*/ bool get_IsCreated();
            /*0x180fc0*/ void Dispose();
            /*0x2a5510*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
            /*0x17aec0*/ void CopyFrom(T[] array);
            /*0x2a5510*/ void CopyFrom(Unity.Collections.NativeArray<T> array);
            /*0x17aec0*/ void CopyTo(T[] array);
            /*0x1803b0*/ T[] ToArray();
            /*0x2a5510*/ Unity.Collections.NativeArray.Enumerator<T> GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x2a5510*/ bool Equals(Unity.Collections.NativeArray<T> other);
            /*0x17e620*/ bool Equals(object obj);
            /*0x180980*/ int GetHashCode();
            /*0x2a5510*/ Unity.Collections.NativeArray<U> InternalReinterpret<U>(int length);
            /*0x2a5510*/ Unity.Collections.NativeArray<U> Reinterpret<U>();
            /*0x2a5510*/ Unity.Collections.NativeArray<U> Reinterpret<U>(int expectedTypeSize);
            /*0x2a5510*/ Unity.Collections.NativeArray<T> GetSubArray(int start, int length);
            /*0x2a5510*/ Unity.Collections.NativeArray.ReadOnly<T> AsReadOnly();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.NativeArray<T> m_Array;
                /*0x0*/ int m_Index;
                /*0x0*/ T value;

                /*0x17aec0*/ Enumerator(ref Unity.Collections.NativeArray<T> array);
                /*0x180fc0*/ void Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void Reset();
                /*0x2a5510*/ T get_Current();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
            }

            struct ReadOnly<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                /*0x0*/ void* m_Buffer;
                /*0x0*/ int m_Length;

                /*0x2a5510*/ ReadOnly(void* buffer, int length);
                /*0x180980*/ int get_Length();
                /*0x2a5510*/ T get_Item(int index);
                /*0x2a5510*/ Unity.Collections.NativeArray.ReadOnly.Enumerator<T> GetEnumerator();
                /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ Unity.Collections.NativeArray.ReadOnly<T> m_Array;
                    /*0x0*/ int m_Index;
                    /*0x0*/ T value;

                    /*0x17aec0*/ Enumerator(ref Unity.Collections.NativeArray.ReadOnly<T> array);
                    /*0x180fc0*/ void Dispose();
                    /*0x17cb40*/ bool MoveNext();
                    /*0x180fc0*/ void Reset();
                    /*0x2a5510*/ T get_Current();
                    /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                }
            }
        }

        struct NativeArrayDispose
        {
            /*0x10*/ void* m_Buffer;
            /*0x18*/ Unity.Collections.Allocator m_AllocatorLabel;

            /*0x15d1970*/ void Dispose();
        }

        struct NativeArrayDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeArrayDispose Data;

            static /*0x15d19c0*/ void RegisterNativeArrayDisposeJobReflectionData();
            /*0x15d1970*/ void Execute();
        }

        class NativeArrayDebugView<T>
        {
        }

        class NativeArrayReadOnlyDebugView<T>
        {
        }

        class NativeSliceExtensions
        {
            static /*0x2a5510*/ Unity.Collections.NativeSlice<T> Slice<T>(Unity.Collections.NativeArray<T> thisArray);
            static /*0x2a5510*/ Unity.Collections.NativeSlice<T> Slice<T>(Unity.Collections.NativeArray<T> thisArray, int start);
            static /*0x2a5510*/ Unity.Collections.NativeSlice<T> Slice<T>(Unity.Collections.NativeArray<T> thisArray, int start, int length);
            static /*0x2a5510*/ Unity.Collections.NativeSlice<T> Slice<T>(Unity.Collections.NativeSlice<T> thisSlice, int start, int length);
        }

        struct NativeSlice<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.NativeSlice<T>>
        {
            /*0x0*/ byte* m_Buffer;
            /*0x0*/ int m_Stride;
            /*0x0*/ int m_Length;

            static /*0x2a5510*/ Unity.Collections.NativeSlice<T> op_Implicit(Unity.Collections.NativeArray<T> array);
            /*0x2a5510*/ NativeSlice(Unity.Collections.NativeSlice<T> slice, int start, int length);
            /*0x2a5510*/ NativeSlice(Unity.Collections.NativeArray<T> array);
            /*0x2a5510*/ NativeSlice(Unity.Collections.NativeArray<T> array, int start);
            /*0x2a5510*/ NativeSlice(Unity.Collections.NativeArray<T> array, int start, int length);
            /*0x2a5510*/ Unity.Collections.NativeSlice<U> SliceConvert<U>();
            /*0x2a5510*/ Unity.Collections.NativeSlice<U> SliceWithStride<U>(int offset);
            /*0x2a5510*/ Unity.Collections.NativeSlice<U> SliceWithStride<U>();
            /*0x2a5510*/ T get_Item(int index);
            /*0x2a5510*/ void set_Item(int index, T value);
            /*0x2a5510*/ void CopyFrom(Unity.Collections.NativeSlice<T> slice);
            /*0x17aec0*/ void CopyFrom(T[] array);
            /*0x17aec0*/ void CopyTo(T[] array);
            /*0x180980*/ int get_Stride();
            /*0x180980*/ int get_Length();
            /*0x2a5510*/ Unity.Collections.NativeSlice.Enumerator<T> GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x2a5510*/ bool Equals(Unity.Collections.NativeSlice<T> other);
            /*0x17e620*/ bool Equals(object obj);
            /*0x180980*/ int GetHashCode();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.NativeSlice<T> m_Array;
                /*0x0*/ int m_Index;

                /*0x17aec0*/ Enumerator(ref Unity.Collections.NativeSlice<T> array);
                /*0x180fc0*/ void Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void Reset();
                /*0x2a5510*/ T get_Current();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class NativeSliceDebugView<T>
        {
        }

        namespace LowLevel
        {
            namespace Unsafe
            {
                class BurstLike
                {
                    struct SharedStatic<T>
                    {
                        /*0x0*/ void* _buffer;

                        static /*0x2a5510*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<T> GetOrCreate<TContext>(uint alignment);
                        /*0x2a5510*/ SharedStatic(void* buffer);
                        /*0x1803b0*/ ref T get_Data();
                    }

                    class SharedStatic
                    {
                        static /*0x15d9560*/ void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment);
                    }
                }

                class BurstRuntime
                {
                    static /*0x180cf0*/ long GetHashCode64<T>();
                    static /*0x111bea0*/ long HashStringWithFNV1A64(string text);

                    struct HashCode64<T>
                    {
                        static /*0x0*/ long Value;

                        static /*0x180ff0*/ HashCode64();
                    }
                }

                class NativeContainerAttribute : System.Attribute
                {
                    /*0x534220*/ NativeContainerAttribute();
                }

                class NativeContainerIsReadOnlyAttribute : System.Attribute
                {
                    /*0x534220*/ NativeContainerIsReadOnlyAttribute();
                }

                class NativeContainerIsAtomicWriteOnlyAttribute : System.Attribute
                {
                    /*0x534220*/ NativeContainerIsAtomicWriteOnlyAttribute();
                }

                class NativeContainerSupportsMinMaxWriteRestrictionAttribute : System.Attribute
                {
                    /*0x534220*/ NativeContainerSupportsMinMaxWriteRestrictionAttribute();
                }

                class NativeContainerSupportsDeallocateOnJobCompletionAttribute : System.Attribute
                {
                    /*0x534220*/ NativeContainerSupportsDeallocateOnJobCompletionAttribute();
                }

                class NativeContainerSupportsDeferredConvertListToArray : System.Attribute
                {
                    /*0x534220*/ NativeContainerSupportsDeferredConvertListToArray();
                }

                class NativeSetThreadIndexAttribute : System.Attribute
                {
                    /*0x534220*/ NativeSetThreadIndexAttribute();
                }

                class NativeContainerNeedsThreadIndexAttribute : System.Attribute
                {
                }

                class WriteAccessRequiredAttribute : System.Attribute
                {
                    /*0x534220*/ WriteAccessRequiredAttribute();
                }

                class NativeDisableUnsafePtrRestrictionAttribute : System.Attribute
                {
                    /*0x534220*/ NativeDisableUnsafePtrRestrictionAttribute();
                }

                class NativeDisableContainerSafetyRestrictionAttribute : System.Attribute
                {
                    /*0x534220*/ NativeDisableContainerSafetyRestrictionAttribute();
                }

                class NativeSetClassTypeToNullOnScheduleAttribute : System.Attribute
                {
                }

                class NativeArrayUnsafeUtility
                {
                    static /*0x2a5510*/ Unity.Collections.NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Unity.Collections.Allocator allocator);
                    static /*0x2a5510*/ void* GetUnsafePtr<T>(Unity.Collections.NativeArray<T> nativeArray);
                    static /*0x2a5510*/ void* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeArray<T> nativeArray);
                    static /*0x2a5510*/ void* GetUnsafeBufferPointerWithoutChecks<T>(Unity.Collections.NativeArray<T> nativeArray);
                }

                class NativeSliceUnsafeUtility
                {
                    static /*0x2a5510*/ Unity.Collections.NativeSlice<T> ConvertExistingDataToNativeSlice<T>(void* dataPointer, int stride, int length);
                    static /*0x2a5510*/ void* GetUnsafePtr<T>(Unity.Collections.NativeSlice<T> nativeSlice);
                    static /*0x2a5510*/ void* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeSlice<T> nativeSlice);
                }

                class UnsafeUtility
                {
                    static /*0x15ddc80*/ int LeakRecord(nint handle, Unity.Collections.LeakCategory category, int callstacksToSkip);
                    static /*0x15ddc40*/ int LeakErase(nint handle, Unity.Collections.LeakCategory category);
                    static /*0x15ddcd0*/ void* MallocTracked(long size, int alignment, Unity.Collections.Allocator allocator, int callstacksToSkip);
                    static /*0x15dd7d0*/ void FreeTracked(void* memory, Unity.Collections.Allocator allocator);
                    static /*0x15ddd30*/ void* Malloc(long size, int alignment, Unity.Collections.Allocator allocator);
                    static /*0x15dd810*/ void Free(void* memory, Unity.Collections.Allocator allocator);
                    static /*0x15dde90*/ void MemCpy(void* destination, void* source, long size);
                    static /*0x15dde30*/ void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count);
                    static /*0x15ddef0*/ void MemMove(void* destination, void* source, long size);
                    static /*0x15ddf50*/ void MemSet(void* destination, byte value, long size);
                    static /*0x15ddd80*/ void MemClear(void* destination, long size);
                    static /*0x15dddd0*/ int MemCmp(void* ptr1, void* ptr2, long size);
                    static /*0x15ddfb0*/ int SizeOf(System.Type type);
                    static /*0x15ddc00*/ bool IsBlittable(System.Type type);
                    static /*0x15ddad0*/ int GetScriptingTypeFlags(System.Type type);
                    static /*0x15ddba0*/ bool IsBlittableValueType(System.Type t);
                    static /*0x15dd8c0*/ string GetReasonForTypeNonBlittableImpl(System.Type t, string name);
                    static /*0x15ddb10*/ bool IsArrayBlittable(System.Array arr);
                    static /*0x15dd850*/ string GetReasonForArrayNonBlittable(System.Array arr);
                    static /*0x17cb70*/ bool IsUnmanaged<T>();
                    static /*0x17cb70*/ bool IsValidNativeContainerElementType<T>();
                    static /*0x1809b0*/ int AlignOf<T>();
                    static /*0x2a5510*/ void CopyPtrToStructure<T>(void* ptr, ref T output);
                    static /*0x2a5510*/ void InternalCopyPtrToStructure<T>(void* ptr, ref T output);
                    static /*0x2a5510*/ void CopyStructureToPtr<T>(ref T input, void* ptr);
                    static /*0x2a5510*/ void InternalCopyStructureToPtr<T>(ref T input, void* ptr);
                    static /*0x2a5510*/ T ReadArrayElement<T>(void* source, int index);
                    static /*0x2a5510*/ T ReadArrayElementWithStride<T>(void* source, int index, int stride);
                    static /*0x2a5510*/ void WriteArrayElement<T>(void* destination, int index, T value);
                    static /*0x2a5510*/ void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value);
                    static /*0x2a5510*/ void* AddressOf<T>(ref T output);
                    static /*0x1809b0*/ int SizeOf<T>();
                    static /*0x17e030*/ ref T As<U, T>(ref U from);
                    static /*0x2a5510*/ ref T AsRef<T>(void* ptr);
                    static /*0x2a5510*/ ref T ArrayElementAsRef<T>(void* ptr, int index);
                    static /*0x2a5510*/ int EnumToInt<T>(T enumValue);
                    static /*0x177670*/ void InternalEnumToInt<T>(ref T enumValue, ref int intValue);
                    static /*0x2a5510*/ bool EnumEquals<T>(T lhs, T rhs);

                    struct TypeFlagsCache<T>
                    {
                        static /*0x0*/ int flags;

                        static /*0x180ff0*/ TypeFlagsCache();
                        static /*0x177be0*/ void Init(ref int flags);
                    }

                    struct AlignOfHelper<T>
                    {
                        /*0x0*/ byte dummy;
                        /*0x0*/ T data;
                    }
                }
            }
        }
    }

    namespace Burst
    {
        class BurstAuthorizedExternalMethodAttribute : System.Attribute
        {
            /*0x534220*/ BurstAuthorizedExternalMethodAttribute();
        }

        class BurstDiscardAttribute : System.Attribute
        {
            /*0x534220*/ BurstDiscardAttribute();
        }

        namespace LowLevel
        {
            class BurstCompilerService
            {
                static /*0x15bdfe0*/ string GetDisassembly(System.Reflection.MethodInfo m, string compilerOptions);
                static /*0x15bdf20*/ int CompileAsyncDelegateMethod(object delegateMethod, string compilerOptions);
                static /*0x15bdf70*/ void* GetAsyncCompiledAsyncDelegateMethod(int userID);
                static /*0x15be030*/ void* GetOrCreateSharedMemory(ref UnityEngine.Hash128 key, uint size_of, uint alignment);
                static /*0x15be180*/ void SetCurrentExecutionMode(uint environment);
                static /*0x15bdfb0*/ uint GetCurrentExecutionMode();
                static /*0x15be0c0*/ void Log(void* userData, Unity.Burst.LowLevel.BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber);
                static /*0x15be120*/ void RuntimeLog(void* userData, Unity.Burst.LowLevel.BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber);
                static /*0x15be080*/ bool LoadBurstLibrary(string fullPathToLibBurstGenerated);

                enum BurstLogType
                {
                    Info = 0,
                    Warning = 1,
                    Error = 2,
                }
            }
        }
    }
}

namespace JetBrains
{
    namespace Annotations
    {
        class CanBeNullAttribute : System.Attribute
        {
            /*0x534220*/ CanBeNullAttribute();
        }

        class NotNullAttribute : System.Attribute
        {
            /*0x534220*/ NotNullAttribute();
        }

        class PureAttribute : System.Attribute
        {
            /*0x534220*/ PureAttribute();
        }

        class MustUseReturnValueAttribute : System.Attribute
        {
            /*0x534220*/ MustUseReturnValueAttribute();
        }

        class CollectionAccessAttribute : System.Attribute
        {
            /*0x10*/ JetBrains.Annotations.CollectionAccessType <CollectionAccessType>k__BackingField;

            /*0xea4040*/ CollectionAccessAttribute(JetBrains.Annotations.CollectionAccessType collectionAccessType);
        }

        enum CollectionAccessType
        {
            None = 0,
            Read = 1,
            ModifyExistingContent = 2,
            UpdatedContent = 6,
        }

        class NoEnumerationAttribute : System.Attribute
        {
            /*0x534220*/ NoEnumerationAttribute();
        }
    }
}

namespace UnityEngine
{
    struct SortingLayer
    {
        /*0x10*/ int m_Id;

        static /*0x15d9710*/ UnityEngine.SortingLayer[] get_layers();
        static /*0x15d9660*/ int[] GetSortingLayerIDsInternal();
        static /*0x15d9620*/ int GetLayerValueFromID(int id);
        static /*0x15d96d0*/ int NameToID(string name);
        static /*0x15d9690*/ string IDToName(int id);
        /*0x15d3b80*/ int get_id();
        /*0x15d97c0*/ int get_value();
    }

    enum WeightedMode
    {
        None = 0,
        In = 1,
        Out = 2,
        Both = 3,
    }

    struct Keyframe
    {
        /*0x10*/ float m_Time;
        /*0x14*/ float m_Value;
        /*0x18*/ float m_InTangent;
        /*0x1c*/ float m_OutTangent;
        /*0x20*/ int m_WeightedMode;
        /*0x24*/ float m_InWeight;
        /*0x28*/ float m_OutWeight;

        /*0x15ca830*/ Keyframe(float time, float value);
        /*0x15ca800*/ Keyframe(float time, float value, float inTangent, float outTangent);
        /*0x6ef1f0*/ float get_time();
        /*0x14668c0*/ void set_time(float value);
        /*0x6ef200*/ float get_value();
        /*0x14668d0*/ void set_value(float value);
        /*0x501230*/ float get_inTangent();
        /*0x14544b0*/ void set_inTangent(float value);
        /*0x501220*/ float get_outTangent();
        /*0x1202470*/ void set_outTangent(float value);
        /*0x8c1a50*/ float get_inWeight();
        /*0x10e9190*/ void set_inWeight(float value);
        /*0x15ca850*/ float get_outWeight();
        /*0xdd5200*/ void set_outWeight(float value);
        /*0x15bceb0*/ UnityEngine.WeightedMode get_weightedMode();
        /*0xdcd9c0*/ void set_weightedMode(UnityEngine.WeightedMode value);
        /*0xbf9940*/ int get_tangentMode();
        /*0x32d010*/ void set_tangentMode(int value);
        /*0xbf9940*/ int get_tangentModeInternal();
        /*0x32d010*/ void set_tangentModeInternal(int value);
    }

    enum WrapMode
    {
        Once = 1,
        Loop = 2,
        PingPong = 4,
        Default = 0,
        ClampForever = 8,
        Clamp = 1,
    }

    class AnimationCurve : System.IEquatable<UnityEngine.AnimationCurve>
    {
        /*0x10*/ nint m_Ptr;

        static /*0x15bac60*/ void Internal_Destroy(nint ptr);
        static /*0x15bac20*/ nint Internal_Create(UnityEngine.Keyframe[] keys);
        static /*0x15bacf0*/ UnityEngine.AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd);
        /*0x15bb0c0*/ AnimationCurve(UnityEngine.Keyframe[] keys);
        /*0x15bb080*/ AnimationCurve();
        /*0x15baca0*/ bool Internal_Equals(nint other);
        /*0x15babd0*/ void Internal_CopyFrom(nint other);
        /*0x15baa10*/ void Finalize();
        /*0x15ba9c0*/ float Evaluate(float time);
        /*0x15bab90*/ UnityEngine.Keyframe[] get_keys();
        /*0x15bafe0*/ void set_keys(UnityEngine.Keyframe[] value);
        /*0x15ba650*/ int AddKey(float time, float value);
        /*0x15ba5f0*/ int AddKey(UnityEngine.Keyframe key);
        /*0x15ba5a0*/ int AddKey_Internal(UnityEngine.Keyframe key);
        /*0x15baf50*/ int MoveKey(int index, UnityEngine.Keyframe key);
        /*0x15ba6b0*/ void ClearKeys();
        /*0x15bafa0*/ void RemoveKey(int index);
        /*0x15bb110*/ UnityEngine.Keyframe get_Item(int index);
        /*0x15bb1a0*/ int get_length();
        /*0x15bafe0*/ void SetKeys(UnityEngine.Keyframe[] keys);
        /*0x15bab20*/ UnityEngine.Keyframe GetKey(int index);
        /*0x15bab90*/ UnityEngine.Keyframe[] GetKeys();
        /*0x15baa90*/ int GetHashCode();
        /*0x15bb030*/ void SmoothTangents(int index, float weight);
        /*0x15bb220*/ UnityEngine.WrapMode get_preWrapMode();
        /*0x15bb2a0*/ void set_preWrapMode(UnityEngine.WrapMode value);
        /*0x15bb1e0*/ UnityEngine.WrapMode get_postWrapMode();
        /*0x15bb260*/ void set_postWrapMode(UnityEngine.WrapMode value);
        /*0x15ba820*/ bool Equals(object o);
        /*0x15ba740*/ bool Equals(UnityEngine.AnimationCurve other);
        /*0x15ba6f0*/ void CopyFrom(UnityEngine.AnimationCurve other);
        /*0x15ba550*/ int AddKey_Internal_Injected(ref UnityEngine.Keyframe key);
        /*0x15baf00*/ int MoveKey_Injected(int index, ref UnityEngine.Keyframe key);
        /*0x15baad0*/ void GetKey_Injected(int index, ref UnityEngine.Keyframe ret);
    }

    class Application
    {
        static /*0x0*/ UnityEngine.Application.LowMemoryCallback lowMemory;
        static /*0x8*/ UnityEngine.Application.MemoryUsageChangedCallback memoryUsageChanged;
        static /*0x10*/ UnityEngine.Application.LogCallback s_LogCallbackHandler;
        static /*0x18*/ UnityEngine.Application.LogCallback s_LogCallbackHandlerThreaded;
        static /*0x20*/ System.Action<bool> focusChanged;
        static /*0x28*/ System.Action<string> deepLinkActivated;
        static /*0x30*/ System.Func<bool> wantsToQuit;
        static /*0x38*/ System.Action quitting;
        static /*0x40*/ System.Action unloading;
        static /*0x48*/ System.Threading.CancellationTokenSource s_currentCancellationTokenSource;

        static /*0x15bbb60*/ Application();
        static /*0x15bbac0*/ void Quit(int exitCode);
        static /*0x15bbb00*/ void Quit();
        static /*0x15bbe30*/ bool get_isPlaying();
        static /*0x15bbd60*/ bool get_isFocused();
        static /*0x15bbd30*/ bool get_isBatchMode();
        static /*0x15bbe60*/ string get_persistentDataPath();
        static /*0x15bbec0*/ string get_productName();
        static /*0x15bba80*/ void OpenURL(string url);
        static /*0x15bc040*/ void set_targetFrameRate(int value);
        static /*0x15bbe90*/ UnityEngine.RuntimePlatform get_platform();
        static /*0x15bbd90*/ bool get_isMobilePlatform();
        static /*0x15bb3d0*/ void CallLowMemory(UnityEngine.ApplicationMemoryUsage usage);
        static /*0x15bb510*/ bool HasLogCallback();
        static /*0x15bb2e0*/ void CallLogCallback(string logString, string stackTrace, UnityEngine.LogType type, bool invokedOnMainThread);
        static /*0x15bbbe0*/ void add_onBeforeRender(UnityEngine.Events.UnityAction value);
        static /*0x15bbef0*/ void remove_onBeforeRender(UnityEngine.Events.UnityAction value);
        static /*0x15bbc30*/ void add_quitting(System.Action value);
        static /*0x15bbf40*/ void remove_quitting(System.Action value);
        static /*0x15bb760*/ bool Internal_ApplicationWantsToQuit();
        static /*0x15bb590*/ void Internal_ApplicationInit();
        static /*0x15bb620*/ void Internal_ApplicationQuit();
        static /*0x15bb6d0*/ void Internal_ApplicationUnload();
        static /*0x15bba40*/ void InvokeOnBeforeRender();
        static /*0x15bb9a0*/ void InvokeFocusChanged(bool focus);
        static /*0x15bb900*/ void InvokeDeepLinkActivated(string url);
        static /*0x6a6020*/ bool get_isEditor();

        class LowMemoryCallback : System.MulticastDelegate
        {
            /*0xe25c50*/ LowMemoryCallback(object object, nint method);
            /*0x9dbe20*/ void Invoke();
        }

        class MemoryUsageChangedCallback : System.MulticastDelegate
        {
            /*0xf0a420*/ MemoryUsageChangedCallback(object object, nint method);
            /*0x720980*/ void Invoke(ref UnityEngine.ApplicationMemoryUsageChange usage);
        }

        class LogCallback : System.MulticastDelegate
        {
            /*0x15cb410*/ LogCallback(object object, nint method);
            /*0x723400*/ void Invoke(string condition, string stackTrace, UnityEngine.LogType type);
        }
    }

    enum ApplicationMemoryUsage
    {
        Unknown = 0,
        Low = 1,
        Medium = 2,
        High = 3,
        Critical = 4,
    }

    struct ApplicationMemoryUsageChange
    {
        /*0x10*/ UnityEngine.ApplicationMemoryUsage <memoryUsage>k__BackingField;

        /*0x6bbd40*/ ApplicationMemoryUsageChange(UnityEngine.ApplicationMemoryUsage usage);
        /*0x6bbd40*/ void set_memoryUsage(UnityEngine.ApplicationMemoryUsage value);
    }

    enum SendMessageOptions
    {
        RequireReceiver = 0,
        DontRequireReceiver = 1,
    }

    enum Space
    {
        World = 0,
        Self = 1,
    }

    enum RuntimePlatform
    {
        OSXEditor = 0,
        OSXPlayer = 1,
        WindowsPlayer = 2,
        OSXWebPlayer = 3,
        OSXDashboardPlayer = 4,
        WindowsWebPlayer = 5,
        WindowsEditor = 7,
        IPhonePlayer = 8,
        XBOX360 = 10,
        PS3 = 9,
        Android = 11,
        NaCl = 12,
        FlashPlayer = 15,
        LinuxPlayer = 13,
        LinuxEditor = 16,
        WebGLPlayer = 17,
        MetroPlayerX86 = 18,
        WSAPlayerX86 = 18,
        MetroPlayerX64 = 19,
        WSAPlayerX64 = 19,
        MetroPlayerARM = 20,
        WSAPlayerARM = 20,
        WP8Player = 21,
        BlackBerryPlayer = 22,
        TizenPlayer = 23,
        PSP2 = 24,
        PS4 = 25,
        PSM = 26,
        XboxOne = 27,
        SamsungTVPlayer = 28,
        WiiU = 30,
        tvOS = 31,
        Switch = 32,
        Lumin = 33,
        Stadia = 34,
        CloudRendering = 35,
        GameCoreScarlett = -1,
        GameCoreXboxSeries = 36,
        GameCoreXboxOne = 37,
        PS5 = 38,
        EmbeddedLinuxArm64 = 39,
        EmbeddedLinuxArm32 = 40,
        EmbeddedLinuxX64 = 41,
        EmbeddedLinuxX86 = 42,
        LinuxServer = 43,
        WindowsServer = 44,
        OSXServer = 45,
        QNXArm32 = 46,
        QNXArm64 = 47,
        QNXX64 = 48,
        QNXX86 = 49,
        VisionOS = 50,
    }

    enum SystemLanguage
    {
        Afrikaans = 0,
        Arabic = 1,
        Basque = 2,
        Belarusian = 3,
        Bulgarian = 4,
        Catalan = 5,
        Chinese = 6,
        Czech = 7,
        Danish = 8,
        Dutch = 9,
        English = 10,
        Estonian = 11,
        Faroese = 12,
        Finnish = 13,
        French = 14,
        German = 15,
        Greek = 16,
        Hebrew = 17,
        Icelandic = 19,
        Indonesian = 20,
        Italian = 21,
        Japanese = 22,
        Korean = 23,
        Latvian = 24,
        Lithuanian = 25,
        Norwegian = 26,
        Polish = 27,
        Portuguese = 28,
        Romanian = 29,
        Russian = 30,
        SerboCroatian = 31,
        Slovak = 32,
        Slovenian = 33,
        Spanish = 34,
        Swedish = 35,
        Thai = 36,
        Turkish = 37,
        Ukrainian = 38,
        Vietnamese = 39,
        ChineseSimplified = 40,
        ChineseTraditional = 41,
        Hindi = 42,
        Unknown = 43,
        Hungarian = 18,
    }

    enum LogType
    {
        Error = 0,
        Assert = 1,
        Warning = 2,
        Log = 3,
        Exception = 4,
    }

    enum LogOption
    {
        None = 0,
        NoStacktrace = 1,
    }

    class BootConfigData
    {
        /*0x10*/ nint m_Ptr;

        static /*0x15bcec0*/ UnityEngine.BootConfigData WrapBootConfigData(nint nativeHandle);
        /*0x15bcf70*/ BootConfigData(nint nativeHandle);
    }

    class Camera : UnityEngine.Behaviour
    {
        static float kMinAperture = 0.699999988079071;
        static float kMaxAperture = 32;
        static int kMinBladeCount = 3;
        static int kMaxBladeCount = 11;
        static /*0x0*/ UnityEngine.Camera.CameraCallback onPreCull;
        static /*0x8*/ UnityEngine.Camera.CameraCallback onPreRender;
        static /*0x10*/ UnityEngine.Camera.CameraCallback onPostRender;

        static /*0x15bf4d0*/ UnityEngine.Camera get_main();
        static /*0x15bf360*/ UnityEngine.Camera get_current();
        static /*0x15be2e0*/ int GetAllCamerasCount();
        static /*0x15be310*/ int GetAllCamerasImpl(UnityEngine.Camera[] cam);
        static /*0x15be2e0*/ int get_allCamerasCount();
        static /*0x15befc0*/ UnityEngine.Camera[] get_allCameras();
        static /*0x15be350*/ int GetAllCameras(UnityEngine.Camera[] cameras);
        static /*0x15bead0*/ void SetupCurrent(UnityEngine.Camera cur);
        static /*0x15be220*/ void FireOnPreCull(UnityEngine.Camera cam);
        static /*0x15be280*/ void FireOnPreRender(UnityEngine.Camera cam);
        static /*0x15be1c0*/ void FireOnPostRender(UnityEngine.Camera cam);
        static /*0x15be430*/ bool GetCullingParameters_Internal(UnityEngine.Camera camera, bool stereoAware, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, int managedCullingParametersSize);
        /*0x15b84e0*/ Camera();
        /*0x15bf500*/ float get_nearClipPlane();
        /*0x15bf450*/ float get_farClipPlane();
        /*0x15bf490*/ float get_fieldOfView();
        /*0x15bfb40*/ void set_fieldOfView(float value);
        /*0x15bf090*/ bool get_allowHDR();
        /*0x15bf0d0*/ bool get_allowMSAA();
        /*0x15bf050*/ bool get_allowDynamicResolution();
        /*0x15bf580*/ float get_orthographicSize();
        /*0x15bfb90*/ void set_orthographicSize(float value);
        /*0x15bf5c0*/ bool get_orthographic();
        /*0x15bf540*/ UnityEngine.Rendering.OpaqueSortMode get_opaqueSortMode();
        /*0x15bf3d0*/ float get_depth();
        /*0x15bf110*/ float get_aspect();
        /*0x15bf320*/ int get_cullingMask();
        /*0x15bf410*/ int get_eventMask();
        /*0x15bf2a0*/ UnityEngine.CameraType get_cameraType();
        /*0x15bf1a0*/ UnityEngine.Color get_backgroundColor();
        /*0x15bfab0*/ void set_backgroundColor(UnityEngine.Color value);
        /*0x15bf2e0*/ UnityEngine.CameraClearFlags get_clearFlags();
        /*0x15bf390*/ UnityEngine.DepthTextureMode get_depthTextureMode();
        /*0x15bfb00*/ void set_depthTextureMode(UnityEngine.DepthTextureMode value);
        /*0x15bf970*/ bool get_usePhysicalProperties();
        /*0x15bf820*/ UnityEngine.Rect get_rect();
        /*0x15bfcd0*/ void set_rect(UnityEngine.Rect value);
        /*0x15bf690*/ UnityEngine.Rect get_pixelRect();
        /*0x15bfc30*/ void set_pixelRect(UnityEngine.Rect value);
        /*0x15bf6e0*/ int get_pixelWidth();
        /*0x15bf600*/ int get_pixelHeight();
        /*0x15bf930*/ UnityEngine.RenderTexture get_targetTexture();
        /*0x15bfd20*/ void set_targetTexture(UnityEngine.RenderTexture value);
        /*0x15bf8f0*/ int get_targetDisplay();
        /*0x15bf240*/ UnityEngine.Matrix4x4 get_cameraToWorldMatrix();
        /*0x15bfa00*/ UnityEngine.Matrix4x4 get_worldToCameraMatrix();
        /*0x15bfdc0*/ void set_worldToCameraMatrix(UnityEngine.Matrix4x4 value);
        /*0x15bf770*/ UnityEngine.Matrix4x4 get_projectionMatrix();
        /*0x15be4e0*/ void ResetWorldToCameraMatrix();
        /*0x15bede0*/ UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x15bef50*/ UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x15bec70*/ UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x15be890*/ UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x15bed50*/ UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position);
        /*0x15beec0*/ UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position);
        /*0x15bebe0*/ UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position);
        /*0x15be900*/ UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position);
        /*0x15be7c0*/ UnityEngine.Vector3 ScreenToViewportPoint(UnityEngine.Vector3 position);
        /*0x15be6f0*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x15be640*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x15be590*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos);
        /*0x15bf870*/ bool get_stereoEnabled();
        /*0x15bf8b0*/ UnityEngine.StereoTargetEyeMask get_stereoTargetEye();
        /*0x15be9e0*/ void SetStereoProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4 matrix);
        /*0x15bea80*/ void SetStereoViewMatrix(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4 matrix);
        /*0x15be4a0*/ int GetFilterMode();
        /*0x15be4a0*/ UnityEngine.Camera.SceneViewFilterMode get_sceneViewFilterMode();
        /*0x15beb10*/ bool TryGetCullingParameters(bool stereoAware, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters);
        /*0x15bf150*/ void get_backgroundColor_Injected(ref UnityEngine.Color ret);
        /*0x15bfa60*/ void set_backgroundColor_Injected(ref UnityEngine.Color value);
        /*0x15bf7d0*/ void get_rect_Injected(ref UnityEngine.Rect ret);
        /*0x15bfc80*/ void set_rect_Injected(ref UnityEngine.Rect value);
        /*0x15bf640*/ void get_pixelRect_Injected(ref UnityEngine.Rect ret);
        /*0x15bfbe0*/ void set_pixelRect_Injected(ref UnityEngine.Rect value);
        /*0x15bf1f0*/ void get_cameraToWorldMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        /*0x15bf9b0*/ void get_worldToCameraMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        /*0x15bfd70*/ void set_worldToCameraMatrix_Injected(ref UnityEngine.Matrix4x4 value);
        /*0x15bf720*/ void get_projectionMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        /*0x15bece0*/ void WorldToScreenPoint_Injected(ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        /*0x15bee50*/ void WorldToViewportPoint_Injected(ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        /*0x15beb70*/ void ViewportToWorldPoint_Injected(ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        /*0x15be820*/ void ScreenToWorldPoint_Injected(ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        /*0x15be760*/ void ScreenToViewportPoint_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        /*0x15be520*/ void ScreenPointToRay_Injected(ref UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Ray ret);
        /*0x15be990*/ void SetStereoProjectionMatrix_Injected(UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 matrix);
        /*0x15bea30*/ void SetStereoViewMatrix_Injected(UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 matrix);

        enum StereoscopicEye
        {
            Left = 0,
            Right = 1,
        }

        enum MonoOrStereoscopicEye
        {
            Left = 0,
            Right = 1,
            Mono = 2,
        }

        enum SceneViewFilterMode
        {
            Off = 0,
            ShowFiltered = 1,
        }

        class CameraCallback : System.MulticastDelegate
        {
            /*0xf0a420*/ CameraCallback(object object, nint method);
            /*0x720980*/ void Invoke(UnityEngine.Camera cam);
        }
    }

    struct BoundingSphere
    {
        /*0x10*/ UnityEngine.Vector3 position;
        /*0x1c*/ float radius;

        /*0x15bcff0*/ BoundingSphere(UnityEngine.Vector3 pos, float rad);
    }

    enum CullingQueryOptions
    {
        Normal = 0,
        IgnoreVisibility = 1,
        IgnoreDistance = 2,
    }

    struct CullingGroupEvent
    {
        /*0x10*/ int m_Index;
        /*0x14*/ byte m_PrevState;
        /*0x15*/ byte m_ThisState;
    }

    class CullingGroup : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.CullingGroup.StateChanged m_OnStateChanged;

        static /*0x15c1ce0*/ void SendEvents(UnityEngine.CullingGroup cullingGroup, nint eventsPtr, int count);
        static /*0x15c1bb0*/ nint Init(object scripting);
        /*0x15c1f20*/ CullingGroup();
        /*0x15c1ae0*/ void Finalize();
        /*0x15c1a60*/ void DisposeInternal();
        /*0x15c1aa0*/ void Dispose();
        /*0x15c1f80*/ void set_targetCamera(UnityEngine.Camera value);
        /*0x15c1de0*/ void SetBoundingSpheres(UnityEngine.BoundingSphere[] array);
        /*0x15c1da0*/ void SetBoundingSphereCount(int count);
        /*0x15c1c60*/ int QueryIndices(bool visible, int[] result, int firstIndex);
        /*0x15c1bf0*/ int QueryIndices(bool visible, int distanceIndex, UnityEngine.CullingQueryOptions options, int[] result, int firstIndex);
        /*0x15c1d50*/ void SetBoundingDistances(float[] distances);
        /*0x15c1e80*/ void SetDistanceReferencePoint_InternalVector3(UnityEngine.Vector3 point);
        /*0x15c1ed0*/ void SetDistanceReferencePoint(UnityEngine.Vector3 point);
        /*0x15c1b70*/ void FinalizerFailure();
        /*0x15c1e30*/ void SetDistanceReferencePoint_InternalVector3_Injected(ref UnityEngine.Vector3 point);

        class StateChanged : System.MulticastDelegate
        {
            /*0x720ff0*/ StateChanged(object object, nint method);
            /*0x720980*/ void Invoke(UnityEngine.CullingGroupEvent sphere);
        }
    }

    class ReflectionProbe : UnityEngine.Behaviour
    {
        static /*0x0*/ System.Action<UnityEngine.ReflectionProbe, UnityEngine.ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged;
        static /*0x8*/ System.Collections.Generic.Dictionary<int, System.Action<UnityEngine.Texture>> registeredDefaultReflectionSetActions;
        static /*0x10*/ System.Collections.Generic.List<System.Action<UnityEngine.Texture>> registeredDefaultReflectionTextureActions;

        static /*0x15d4dc0*/ ReflectionProbe();
        static /*0x15d4ef0*/ UnityEngine.Vector4 get_defaultTextureHDRDecodeValues();
        static /*0x15d4f60*/ UnityEngine.Texture get_defaultTexture();
        static /*0x15d4bf0*/ void CallReflectionProbeEvent(UnityEngine.ReflectionProbe probe, UnityEngine.ReflectionProbe.ReflectionProbeEvent probeEvent);
        static /*0x15d4c70*/ void CallSetDefaultReflection(UnityEngine.Texture defaultReflectionCubemap);
        static /*0x15d4eb0*/ void get_defaultTextureHDRDecodeValues_Injected(ref UnityEngine.Vector4 ret);
        /*0x15d4f90*/ UnityEngine.Rendering.ReflectionProbeRefreshMode get_refreshMode();

        enum ReflectionProbeEvent
        {
            ReflectionProbeAdded = 0,
            ReflectionProbeRemoved = 1,
        }
    }

    class DebugLogHandler : UnityEngine.ILogHandler
    {
        static /*0x15c20e0*/ void Internal_Log(UnityEngine.LogType level, UnityEngine.LogOption options, string msg, UnityEngine.Object obj);
        static /*0x15c2090*/ void Internal_LogException(System.Exception ex, UnityEngine.Object obj);
        /*0x32f970*/ DebugLogHandler();
        /*0x15c21d0*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
        /*0x15c2240*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.LogOption logOptions, UnityEngine.Object context, string format, object[] args);
        /*0x15c2140*/ void LogException(System.Exception exception, UnityEngine.Object context);
    }

    class Debug
    {
        static /*0x0*/ UnityEngine.ILogger s_DefaultLogger;
        static /*0x8*/ UnityEngine.ILogger s_Logger;

        static /*0x15c36b0*/ Debug();
        static /*0x15c37f0*/ UnityEngine.ILogger get_unityLogger();
        static /*0x15c2700*/ int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder);
        static /*0x15c35f0*/ void Log(object message);
        static /*0x15c3520*/ void Log(object message, UnityEngine.Object context);
        static /*0x15c2f10*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.LogOption logOptions, UnityEngine.Object context, string format, object[] args);
        static /*0x15c2cd0*/ void LogError(object message);
        static /*0x15c2c00*/ void LogError(object message, UnityEngine.Object context);
        static /*0x15c2b30*/ void LogErrorFormat(string format, object[] args);
        static /*0x15c2a50*/ void LogErrorFormat(UnityEngine.Object context, string format, object[] args);
        static /*0x15c2d90*/ void LogException(System.Exception exception);
        static /*0x15c2e50*/ void LogException(System.Exception exception, UnityEngine.Object context);
        static /*0x15c3460*/ void LogWarning(object message);
        static /*0x15c3390*/ void LogWarning(object message, UnityEngine.Object context);
        static /*0x15c31e0*/ void LogWarningFormat(string format, object[] args);
        static /*0x15c32b0*/ void LogWarningFormat(UnityEngine.Object context, string format, object[] args);
        static /*0x15c22c0*/ void Assert(bool condition);
        static /*0x15c23a0*/ void Assert(bool condition, string message);
        static /*0x15c2990*/ void LogAssertion(object message);
        static /*0x15c28c0*/ void LogAssertionFormat(string format, object[] args);
        static /*0x15c37c0*/ bool get_isDebugBuild();
        static /*0x15c2470*/ bool CallOverridenDebugHandler(System.Exception exception, UnityEngine.Object obj);
        static /*0x15c2750*/ bool IsLoggingEnabled();
    }

    class ExpressionEvaluator
    {
        static /*0x0*/ UnityEngine.ExpressionEvaluator.PcgRandom s_Random;
        static /*0x10*/ System.Collections.Generic.Dictionary<string, UnityEngine.ExpressionEvaluator.Operator> s_Operators;

        static /*0x15c5a30*/ ExpressionEvaluator();
        static /*0x17f7b0*/ bool Evaluate<T>(string expression, ref T value, ref UnityEngine.ExpressionEvaluator.Expression delayed);
        static /*0x2a5510*/ bool EvaluateTokens<T>(string[] tokens, ref T value, int index, int count);
        static /*0x15c41b0*/ bool EvaluateDouble(string[] tokens, ref double value, int index, int count);
        static /*0x15c5060*/ string[] InfixToRPN(string[] tokens);
        static /*0x15c56f0*/ bool NeedToPop(System.Collections.Generic.Stack<string> operatorStack, UnityEngine.ExpressionEvaluator.Operator newOperator);
        static /*0x15c4ae0*/ string[] ExpressionToTokens(string expression, ref bool hasVariables);
        static /*0x15c5520*/ bool IsCommand(string token);
        static /*0x15c5690*/ bool IsVariable(string token);
        static /*0x15c55a0*/ bool IsDelayedFunction(string token);
        static /*0x15c5610*/ bool IsOperator(string token);
        static /*0x15c5990*/ UnityEngine.ExpressionEvaluator.Operator TokenToOperator(string token);
        static /*0x15c57d0*/ string PreFormatExpression(string expression);
        static /*0x15c4ee0*/ string[] FixUnaryOperators(string[] tokens);
        static /*0x15c46b0*/ double EvaluateOp(double[] values, UnityEngine.ExpressionEvaluator.Op op, int index, int count);
        static /*0x1794f0*/ bool TryParse<T>(string expression, ref T result);

        class Expression
        {
            /*0x10*/ string[] rpnTokens;
            /*0x18*/ bool hasVariables;

            /*0x15c6150*/ Expression(string expression);
            /*0x2a5510*/ bool Evaluate<T>(ref T value, int index, int count);
            /*0x15c6070*/ bool Equals(object obj);
            /*0xe77c60*/ int GetHashCode();
            /*0x15c6110*/ string ToString();
        }

        struct PcgRandom
        {
            /*0x10*/ ulong increment;
            /*0x18*/ ulong state;

            static /*0x11cf8b0*/ uint RotateRight(uint v, int rot);
            static /*0x15d1ab0*/ uint XshRr(ulong s);
            /*0x15d1ae0*/ PcgRandom(ulong state, ulong sequence);
            /*0x15d1a40*/ uint GetUInt();
            /*0x15d1a90*/ void Step();
        }

        enum Op
        {
            Add = 0,
            Sub = 1,
            Mul = 2,
            Div = 3,
            Mod = 4,
            Neg = 5,
            Pow = 6,
            Sqrt = 7,
            Sin = 8,
            Cos = 9,
            Tan = 10,
            Floor = 11,
            Ceil = 12,
            Round = 13,
            Rand = 14,
            Linear = 15,
        }

        enum Associativity
        {
            Left = 0,
            Right = 1,
        }

        class Operator
        {
            /*0x10*/ UnityEngine.ExpressionEvaluator.Op op;
            /*0x14*/ int precedence;
            /*0x18*/ UnityEngine.ExpressionEvaluator.Associativity associativity;
            /*0x1c*/ int inputs;

            /*0x15d19f0*/ Operator(UnityEngine.ExpressionEvaluator.Op op, int precedence, int inputs, UnityEngine.ExpressionEvaluator.Associativity associativity);
        }

        class <>c
        {
            static /*0x0*/ UnityEngine.ExpressionEvaluator.<> <>9;
            static /*0x8*/ System.Func<string, bool> <>9__14_0;

            static /*0x15dd760*/ <>c();
            /*0x32f970*/ <>c();
            /*0x15dd660*/ bool <ExpressionToTokens>b__14_0(string f);
        }
    }

    struct Bounds : System.IEquatable<UnityEngine.Bounds>, System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3 m_Center;
        /*0x1c*/ UnityEngine.Vector3 m_Extents;

        static /*0x15bdc50*/ bool op_Equality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs);
        static /*0x15bdcf0*/ bool op_Inequality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs);
        /*0x15bdb40*/ Bounds(UnityEngine.Vector3 center, UnityEngine.Vector3 size);
        /*0x7ad070*/ int GetHashCode();
        /*0x15bd7d0*/ bool Equals(object other);
        /*0x15bd740*/ bool Equals(UnityEngine.Bounds other);
        /*0x15bd3e0*/ UnityEngine.Vector3 get_center();
        /*0x15bd5e0*/ void set_center(UnityEngine.Vector3 value);
        /*0x15bdc10*/ UnityEngine.Vector3 get_size();
        /*0x15bdee0*/ void set_size(UnityEngine.Vector3 value);
        /*0x15bd400*/ UnityEngine.Vector3 get_extents();
        /*0x15bd5f0*/ void set_extents(UnityEngine.Vector3 value);
        /*0x15bdbd0*/ UnityEngine.Vector3 get_min();
        /*0x15bde50*/ void set_min(UnityEngine.Vector3 value);
        /*0x15bdb90*/ UnityEngine.Vector3 get_max();
        /*0x15bddb0*/ void set_max(UnityEngine.Vector3 value);
        /*0x15bd8f0*/ void SetMinMax(UnityEngine.Vector3 min, UnityEngine.Vector3 max);
        /*0x10e8a10*/ void Encapsulate(UnityEngine.Vector3 point);
        /*0x10e8b10*/ void Encapsulate(UnityEngine.Bounds bounds);
        /*0x15bdb30*/ string ToString();
        /*0x15bd970*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct BoundsInt : System.IEquatable<UnityEngine.BoundsInt>, System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3Int m_Position;
        /*0x1c*/ UnityEngine.Vector3Int m_Size;

        /*0x1201cd0*/ BoundsInt(UnityEngine.Vector3Int position, UnityEngine.Vector3Int size);
        /*0x15bd490*/ int get_xMin();
        /*0x15bd610*/ void set_xMin(int value);
        /*0x15bd570*/ int get_yMin();
        /*0x15bd6b0*/ void set_yMin(int value);
        /*0x15bd420*/ int get_xMax();
        /*0x15bd600*/ void set_xMax(int value);
        /*0x15bd500*/ int get_yMax();
        /*0x15bd6a0*/ void set_yMax(int value);
        /*0x15bd3e0*/ UnityEngine.Vector3Int get_position();
        /*0x15bd5e0*/ void set_position(UnityEngine.Vector3Int value);
        /*0x15bd400*/ UnityEngine.Vector3Int get_size();
        /*0x15bd5f0*/ void set_size(UnityEngine.Vector3Int value);
        /*0x15bd3d0*/ string ToString();
        /*0x15bd230*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x15bd0b0*/ bool Equals(object other);
        /*0x15bd010*/ bool Equals(UnityEngine.BoundsInt other);
        /*0x15bd1f0*/ int GetHashCode();
    }

    class GeometryUtility
    {
        static /*0x15c6bf0*/ void CalculateFrustumPlanes(UnityEngine.Camera camera, UnityEngine.Plane[] planes);
        static /*0x15c6e00*/ void CalculateFrustumPlanes(UnityEngine.Matrix4x4 worldToProjectionMatrix, UnityEngine.Plane[] planes);
        static /*0x15c7010*/ bool TestPlanesAABB(UnityEngine.Plane[] planes, UnityEngine.Bounds bounds);
        static /*0x15c6f70*/ void Internal_ExtractPlanes(UnityEngine.Plane[] planes, UnityEngine.Matrix4x4 worldToProjectionMatrix);
        static /*0x15c6fc0*/ bool TestPlanesAABB_Injected(UnityEngine.Plane[] planes, ref UnityEngine.Bounds bounds);
        static /*0x15c6f20*/ void Internal_ExtractPlanes_Injected(UnityEngine.Plane[] planes, ref UnityEngine.Matrix4x4 worldToProjectionMatrix);
    }

    struct Plane : System.IFormattable
    {
        static int size = 16;
        /*0x10*/ UnityEngine.Vector3 m_Normal;
        /*0x1c*/ float m_Distance;

        /*0x15d1e00*/ Plane(UnityEngine.Vector3 inNormal, UnityEngine.Vector3 inPoint);
        /*0x15bd3e0*/ UnityEngine.Vector3 get_normal();
        /*0x501220*/ float get_distance();
        /*0x15d1b10*/ bool Raycast(UnityEngine.Ray ray, ref float enter);
        /*0x15d1df0*/ string ToString();
        /*0x15d1c30*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Ray : System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3 m_Origin;
        /*0x1c*/ UnityEngine.Vector3 m_Direction;

        /*0x15d3740*/ Ray(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        /*0x15bd3e0*/ UnityEngine.Vector3 get_origin();
        /*0x15bd5e0*/ void set_origin(UnityEngine.Vector3 value);
        /*0x15bd400*/ UnityEngine.Vector3 get_direction();
        /*0x15d37a0*/ void set_direction(UnityEngine.Vector3 value);
        /*0x15d3520*/ UnityEngine.Vector3 GetPoint(float distance);
        /*0x15d3570*/ string ToString();
        /*0x15d3580*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Ray2D : System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector2 m_Origin;
        /*0x18*/ UnityEngine.Vector2 m_Direction;

        /*0x15d34c0*/ UnityEngine.Vector2 get_origin();
        /*0x9e29e0*/ void set_origin(UnityEngine.Vector2 value);
        /*0x15d34a0*/ UnityEngine.Vector2 get_direction();
        /*0x15d34e0*/ void set_direction(UnityEngine.Vector2 value);
        /*0x15d32d0*/ string ToString();
        /*0x15d32e0*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Rect : System.IEquatable<UnityEngine.Rect>, System.IFormattable
    {
        /*0x10*/ float m_XMin;
        /*0x14*/ float m_YMin;
        /*0x18*/ float m_Width;
        /*0x1c*/ float m_Height;

        static /*0xb902a0*/ UnityEngine.Rect get_zero();
        static /*0x15d4650*/ UnityEngine.Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax);
        static /*0x15d4690*/ UnityEngine.Rect OrderMinMax(UnityEngine.Rect rect);
        static /*0x15d4ad0*/ bool op_Inequality(UnityEngine.Rect lhs, UnityEngine.Rect rhs);
        static /*0x15d4a90*/ bool op_Equality(UnityEngine.Rect lhs, UnityEngine.Rect rhs);
        /*0x11534a0*/ Rect(float x, float y, float width, float height);
        /*0x12457c0*/ Rect(UnityEngine.Vector2 position, UnityEngine.Vector2 size);
        /*0x11f1850*/ Rect(UnityEngine.Rect source);
        /*0x6ef1f0*/ float get_x();
        /*0x14668c0*/ void set_x(float value);
        /*0x6ef200*/ float get_y();
        /*0x14668d0*/ void set_y(float value);
        /*0x15d34c0*/ UnityEngine.Vector2 get_position();
        /*0x12303f0*/ void set_position(UnityEngine.Vector2 value);
        /*0x15d4a00*/ UnityEngine.Vector2 get_center();
        /*0x15d4a50*/ UnityEngine.Vector2 get_min();
        /*0x15d4b50*/ void set_min(UnityEngine.Vector2 value);
        /*0x15d4a30*/ UnityEngine.Vector2 get_max();
        /*0x15d4b20*/ void set_max(UnityEngine.Vector2 value);
        /*0x501230*/ float get_width();
        /*0x14544b0*/ void set_width(float value);
        /*0x501220*/ float get_height();
        /*0x1202470*/ void set_height(float value);
        /*0x15d34a0*/ UnityEngine.Vector2 get_size();
        /*0x1246470*/ void set_size(UnityEngine.Vector2 value);
        /*0x6ef1f0*/ float get_xMin();
        /*0x15d4ba0*/ void set_xMin(float value);
        /*0x6ef200*/ float get_yMin();
        /*0x15d4bd0*/ void set_yMin(float value);
        /*0x15d4a70*/ float get_xMax();
        /*0x15d4b90*/ void set_xMax(float value);
        /*0x15d4a80*/ float get_yMax();
        /*0x15d4bc0*/ void set_yMax(float value);
        /*0x15d4400*/ bool Contains(UnityEngine.Vector2 point);
        /*0x15d4440*/ bool Contains(UnityEngine.Vector3 point);
        /*0x15d4700*/ bool Overlaps(UnityEngine.Rect other);
        /*0x143dfd0*/ bool Overlaps(UnityEngine.Rect other, bool allowInverse);
        /*0x15d45b0*/ int GetHashCode();
        /*0x15d4480*/ bool Equals(object other);
        /*0x6ef140*/ bool Equals(UnityEngine.Rect other);
        /*0x15d4750*/ string ToString();
        /*0x15d4760*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct RectInt : System.IEquatable<UnityEngine.RectInt>, System.IFormattable
    {
        /*0x10*/ int m_XMin;
        /*0x14*/ int m_YMin;
        /*0x18*/ int m_Width;
        /*0x1c*/ int m_Height;

        /*0x1153590*/ RectInt(int xMin, int yMin, int width, int height);
        /*0x15d3b80*/ int get_x();
        /*0x6bbd40*/ void set_x(int value);
        /*0xc6bf90*/ int get_y();
        /*0xfc2c10*/ void set_y(int value);
        /*0xb73eb0*/ int get_width();
        /*0xf0fbd0*/ void set_width(int value);
        /*0xba1820*/ int get_height();
        /*0xf0fbc0*/ void set_height(int value);
        /*0x15d3b10*/ int get_xMin();
        /*0x15d3c00*/ int get_yMin();
        /*0x15d3aa0*/ int get_xMax();
        /*0x15d3b90*/ int get_yMax();
        /*0x15b9760*/ bool Overlaps(UnityEngine.RectInt other);
        /*0x15d3a90*/ string ToString();
        /*0x15d3820*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x15d37f0*/ bool Equals(UnityEngine.RectInt other);
    }

    class RectOffset : System.IFormattable
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ object m_SourceStyle;

        static /*0x15d3d80*/ nint InternalCreate();
        static /*0x15d3db0*/ void InternalDestroy(nint ptr);
        /*0x15d4140*/ RectOffset();
        /*0x15d40f0*/ RectOffset(object sourceStyle, nint source);
        /*0x15d3cd0*/ void Finalize();
        /*0x15d3df0*/ string ToString();
        /*0x15d3e00*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x15d3c70*/ void Destroy();
        /*0x15d4200*/ int get_left();
        /*0x15d4340*/ void set_left(int value);
        /*0x15d4240*/ int get_right();
        /*0x15d4380*/ void set_right(int value);
        /*0x15d4280*/ int get_top();
        /*0x15d43c0*/ void set_top(int value);
        /*0x15d4180*/ int get_bottom();
        /*0x15d4300*/ void set_bottom(int value);
        /*0x15d41c0*/ int get_horizontal();
        /*0x15d42c0*/ int get_vertical();
    }

    class LightingSettings : UnityEngine.Object
    {
        /*0x32d010*/ void LightingSettingsDontStripMe();
    }

    class Gizmos
    {
        static /*0x15c7230*/ void DrawLine(UnityEngine.Vector3 from, UnityEngine.Vector3 to);
        static /*0x15c72d0*/ void DrawSphere(UnityEngine.Vector3 center, float radius);
        static /*0x15c7370*/ void DrawWireCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size);
        static /*0x15c70b0*/ void DrawCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size);
        static /*0x15c7170*/ void DrawIcon(UnityEngine.Vector3 center, string name, bool allowScaling, UnityEngine.Color tint);
        static /*0x15c7400*/ void set_color(UnityEngine.Color value);
        static /*0x15c71e0*/ void DrawLine_Injected(ref UnityEngine.Vector3 from, ref UnityEngine.Vector3 to);
        static /*0x15c7280*/ void DrawSphere_Injected(ref UnityEngine.Vector3 center, float radius);
        static /*0x15c7320*/ void DrawWireCube_Injected(ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 size);
        static /*0x15c7060*/ void DrawCube_Injected(ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 size);
        static /*0x15c7100*/ void DrawIcon_Injected(ref UnityEngine.Vector3 center, string name, bool allowScaling, ref UnityEngine.Color tint);
        static /*0x15c73c0*/ void set_color_Injected(ref UnityEngine.Color value);
    }

    class BeforeRenderOrderAttribute : System.Attribute
    {
        /*0x10*/ int <order>k__BackingField;

        /*0x417e30*/ int get_order();
    }

    class BeforeRenderHelper
    {
        static /*0x0*/ System.Collections.Generic.List<UnityEngine.BeforeRenderHelper.OrderBlock> s_OrderBlocks;

        static /*0x15bcba0*/ BeforeRenderHelper();
        static /*0x15bc120*/ int GetUpdateOrder(UnityEngine.Events.UnityAction callback);
        static /*0x15bc3e0*/ void RegisterCallback(UnityEngine.Events.UnityAction callback);
        static /*0x15bc800*/ void UnregisterCallback(UnityEngine.Events.UnityAction callback);
        static /*0x15bc240*/ void Invoke();

        struct OrderBlock
        {
            /*0x10*/ int order;
            /*0x18*/ UnityEngine.Events.UnityAction callback;
        }
    }

    class CustomRenderTextureManager
    {
        static /*0x0*/ System.Action<UnityEngine.CustomRenderTexture> textureLoaded;
        static /*0x8*/ System.Action<UnityEngine.CustomRenderTexture> textureUnloaded;

        static /*0x15c1fd0*/ void InvokeOnTextureLoaded_Internal(UnityEngine.CustomRenderTexture source);
        static /*0x15c2030*/ void InvokeOnTextureUnloaded_Internal(UnityEngine.CustomRenderTexture source);
    }

    class Display
    {
        static /*0x0*/ UnityEngine.Display[] displays;
        static /*0x8*/ UnityEngine.Display _mainDisplay;
        static /*0x10*/ int m_ActiveEditorGameViewTarget;
        static /*0x18*/ UnityEngine.Display.DisplaysUpdatedDelegate onDisplaysUpdated;
        /*0x10*/ nint nativeDisplay;

        static /*0x15c3cf0*/ Display();
        static /*0x15c3be0*/ UnityEngine.Vector3 RelativeMouseAt(UnityEngine.Vector3 inputMouseCoordinates);
        static /*0x15c3ef0*/ UnityEngine.Display get_main();
        static /*0x15c3990*/ void RecreateDisplayList(nint[] nativeDisplay);
        static /*0x15c3840*/ void FireDisplaysUpdated();
        static /*0x15c3930*/ void GetSystemExtImpl(nint nativeDisplay, ref int w, ref int h);
        static /*0x15c38d0*/ void GetRenderingExtImpl(nint nativeDisplay, ref int w, ref int h);
        static /*0x15c3b80*/ int RelativeMouseAtImpl(int x, int y, ref int rx, ref int ry);
        static /*0x15c3cb0*/ bool RequiresSrgbBlitToBackbufferImpl(nint nativeDisplay);
        /*0x15c3eb0*/ Display();
        /*0x15c3e80*/ Display(nint nativeDisplay);
        /*0x15c3fc0*/ int get_renderingWidth();
        /*0x15c3f40*/ int get_renderingHeight();
        /*0x15c4130*/ int get_systemWidth();
        /*0x15c40b0*/ int get_systemHeight();
        /*0x15c4040*/ bool get_requiresSrgbBlitToBackbuffer();

        class DisplaysUpdatedDelegate : System.MulticastDelegate
        {
            /*0xe25c50*/ DisplaysUpdatedDelegate(object object, nint method);
            /*0x9dbe20*/ void Invoke();
        }
    }

    enum FullScreenMode
    {
        ExclusiveFullScreen = 0,
        FullScreenWindow = 1,
        MaximizedWindow = 2,
        Windowed = 3,
    }

    struct RefreshRate : System.IEquatable<UnityEngine.RefreshRate>, System.IComparable<UnityEngine.RefreshRate>
    {
        /*0x10*/ uint numerator;
        /*0x14*/ uint denominator;

        /*0x15d5110*/ double get_value();
        /*0x15d5030*/ bool Equals(UnityEngine.RefreshRate other);
        /*0x15d4fd0*/ int CompareTo(UnityEngine.RefreshRate other);
        /*0x15d5070*/ string ToString();
    }

    class Screen
    {
        static /*0x15d8fb0*/ int get_width();
        static /*0x15d8f80*/ int get_height();
        static /*0x15d8f20*/ float get_dpi();
        static /*0x15d8d30*/ UnityEngine.ScreenOrientation GetScreenOrientation();
        static /*0x15d8d30*/ UnityEngine.ScreenOrientation get_orientation();
        static /*0x15d8f50*/ bool get_fullScreen();
        static /*0x15d8dc0*/ void SetResolution(int width, int height, UnityEngine.FullScreenMode fullscreenMode, UnityEngine.RefreshRate preferredRefreshRate);
        static /*0x15d8ea0*/ void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate);
        static /*0x15d8e20*/ void SetResolution(int width, int height, bool fullscreen);
        static /*0x15d8d60*/ void SetResolution_Injected(int width, int height, UnityEngine.FullScreenMode fullscreenMode, ref UnityEngine.RefreshRate preferredRefreshRate);
    }

    struct RenderBuffer
    {
        /*0x10*/ int m_RenderTextureInstanceID;
        /*0x18*/ nint m_BufferPtr;
    }

    enum ComputeBufferMode
    {
        Immutable = 0,
        Dynamic = 1,
        Circular = 2,
        StreamOut = 3,
        SubUpdates = 4,
    }

    class Graphics
    {
        static /*0x0*/ int kMaxDrawMeshInstanceCount;
        static /*0x8*/ System.Collections.Generic.Dictionary<int, UnityEngine.RenderInstancedDataLayout> s_RenderInstancedDataLayouts;

        static /*0x15c93f0*/ Graphics();
        static /*0x15c8cb0*/ int Internal_GetMaxDrawMeshInstanceCount();
        static /*0x15c94b0*/ UnityEngine.Rendering.GraphicsTier get_activeTier();
        static /*0x15c8a80*/ bool GetPreserveFramebufferAlpha();
        static /*0x15c9540*/ bool get_preserveFramebufferAlpha();
        static /*0x15c8a50*/ UnityEngine.Rendering.OpenGLESVersion GetMinOpenGLESVersion();
        static /*0x15c94e0*/ UnityEngine.Rendering.OpenGLESVersion get_minOpenGLESVersion();
        static /*0x15c8ce0*/ void Internal_SetNullRT();
        static /*0x15c8d80*/ void Internal_SetRTSimple(UnityEngine.RenderBuffer color, UnityEngine.RenderBuffer depth, int mip, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x15c7ea0*/ void CopyTexture_Slice(UnityEngine.Texture src, int srcElement, int srcMip, UnityEngine.Texture dst, int dstElement, int dstMip);
        static /*0x15c7e30*/ void CopyTexture_Region(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, UnityEngine.Texture dst, int dstElement, int dstMip, int dstX, int dstY);
        static /*0x15c8bb0*/ void Internal_DrawMesh(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int layer, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x15c8ab0*/ void Internal_DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x15c7cc0*/ void Blit4(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset);
        static /*0x15c8a10*/ void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer buffer);
        static /*0x15c9010*/ void SetRenderTargetImpl(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, int mipLevel, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x15c8e20*/ void SetRenderTargetImpl(UnityEngine.RenderTexture rt, int mipLevel, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x15c91d0*/ void SetRenderTarget(UnityEngine.RenderTexture rt, int mipLevel, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x15c7f00*/ void CopyTexture(UnityEngine.Texture src, int srcElement, int srcMip, UnityEngine.Texture dst, int dstElement, int dstMip);
        static /*0x15c7fa0*/ void CopyTexture(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, UnityEngine.Texture dst, int dstElement, int dstMip, int dstX, int dstY);
        static /*0x15c8810*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int layer, UnityEngine.Camera camera, int submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x15c8120*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x15c7d50*/ void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset);
        static /*0x15c8690*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int layer, UnityEngine.Camera camera, int submeshIndex, UnityEngine.MaterialPropertyBlock properties);
        static /*0x15c8040*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, UnityEngine.Camera camera);
        static /*0x15c9100*/ void SetRenderTarget(UnityEngine.RenderTexture rt);
        static /*0x15c9160*/ void SetRenderTarget(UnityEngine.RenderTexture rt, int mipLevel);
        static /*0x15c8d10*/ void Internal_SetRTSimple_Injected(ref UnityEngine.RenderBuffer color, ref UnityEngine.RenderBuffer depth, int mip, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x15c8b30*/ void Internal_DrawMesh_Injected(UnityEngine.Mesh mesh, int submeshIndex, ref UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int layer, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x15c7c50*/ void Blit4_Injected(UnityEngine.Texture source, UnityEngine.RenderTexture dest, ref UnityEngine.Vector2 scale, ref UnityEngine.Vector2 offset);
    }

    class GL
    {
        static /*0x15c6a30*/ void Vertex3(float x, float y, float z);
        static /*0x15c69d0*/ void TexCoord3(float x, float y, float z);
        static /*0x15c6980*/ void TexCoord2(float x, float y);
        static /*0x15c6770*/ void ImmediateColor(float r, float g, float b, float a);
        static /*0x15c64c0*/ void Color(UnityEngine.Color c);
        static /*0x15c6b10*/ bool get_wireframe();
        static /*0x15c6ba0*/ void set_wireframe(bool value);
        static /*0x15c6940*/ void SetViewMatrix(UnityEngine.Matrix4x4 m);
        static /*0x15c6b40*/ void set_modelview(UnityEngine.Matrix4x4 value);
        static /*0x15c68d0*/ void PushMatrix();
        static /*0x15c68a0*/ void PopMatrix();
        static /*0x15c67f0*/ void LoadOrtho();
        static /*0x15c6860*/ void LoadProjectionMatrix(UnityEngine.Matrix4x4 mat);
        static /*0x15c6700*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(UnityEngine.Matrix4x4 proj, bool renderIntoTexture);
        static /*0x15c6620*/ void GLLoadPixelMatrixScript(float left, float right, float bottom, float top);
        static /*0x15c6620*/ void LoadPixelMatrix(float left, float right, float bottom, float top);
        static /*0x15c63b0*/ void Begin(int mode);
        static /*0x15c6510*/ void End();
        static /*0x15c65b0*/ void GLClear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
        static /*0x15c63f0*/ void Clear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
        static /*0x15c6460*/ void Clear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
        static /*0x15c6ad0*/ void Viewport(UnityEngine.Rect pixelRect);
        static /*0x15c6900*/ void SetViewMatrix_Injected(ref UnityEngine.Matrix4x4 m);
        static /*0x15c6820*/ void LoadProjectionMatrix_Injected(ref UnityEngine.Matrix4x4 mat);
        static /*0x15c66a0*/ void GetGPUProjectionMatrix_Injected(ref UnityEngine.Matrix4x4 proj, bool renderIntoTexture, ref UnityEngine.Matrix4x4 ret);
        static /*0x15c6540*/ void GLClear_Injected(bool clearDepth, bool clearColor, ref UnityEngine.Color backgroundColor, float depth);
        static /*0x15c6a90*/ void Viewport_Injected(ref UnityEngine.Rect pixelRect);
    }

    class ScalableBufferManager
    {
        static /*0x15d8d00*/ float get_widthScaleFactor();
        static /*0x15d8cd0*/ float get_heightScaleFactor();
        static /*0x15d8c80*/ void ResizeBuffers(float widthScale, float heightScale);
    }

    struct FrameTiming
    {
        /*0x10*/ double cpuFrameTime;
        /*0x18*/ double cpuMainThreadFrameTime;
        /*0x20*/ double cpuMainThreadPresentWaitTime;
        /*0x28*/ double cpuRenderThreadFrameTime;
        /*0x30*/ double gpuFrameTime;
        /*0x38*/ ulong frameStartTimestamp;
        /*0x40*/ ulong firstSubmitTimestamp;
        /*0x48*/ ulong cpuTimePresentCalled;
        /*0x50*/ ulong cpuTimeFrameComplete;
        /*0x58*/ float heightScale;
        /*0x5c*/ float widthScale;
        /*0x60*/ uint syncInterval;
    }

    class FrameTimingManager
    {
        static /*0x15c6340*/ void CaptureFrameTimings();
        static /*0x15c6370*/ uint GetLatestTimings(uint numFrames, UnityEngine.FrameTiming[] timings);
    }

    class LightmapSettings : UnityEngine.Object
    {
    }

    class LightProbes : UnityEngine.Object
    {
        static /*0x0*/ System.Action lightProbesUpdated;
        static /*0x8*/ System.Action tetrahedralizationCompleted;
        static /*0x10*/ System.Action needsRetetrahedralization;

        static /*0x15ca860*/ void Internal_CallLightProbesUpdatedFunction();
        static /*0x15ca910*/ void Internal_CallTetrahedralizationCompletedFunction();
        static /*0x15ca8b0*/ void Internal_CallNeedsRetetrahedralizationFunction();
    }

    class HDROutputSettings
    {
        static /*0x0*/ UnityEngine.HDROutputSettings[] displays;
        static /*0x8*/ UnityEngine.HDROutputSettings _mainDisplay;
        /*0x10*/ int m_DisplayIndex;

        static /*0x15c9860*/ HDROutputSettings();
        static /*0x15c9b00*/ UnityEngine.HDROutputSettings get_main();
        static /*0x15c95a0*/ bool GetActive(int displayIndex);
        static /*0x15c95e0*/ bool GetAvailable(int displayIndex);
        static /*0x15c9820*/ void SetAutomaticHDRTonemapping(int displayIndex, bool scripted);
        static /*0x15c9620*/ UnityEngine.ColorGamut GetDisplayColorGamut(int displayIndex);
        static /*0x15c9720*/ float GetPaperWhiteNits(int displayIndex);
        static /*0x15c9660*/ int GetMaxFullFrameToneMapLuminance(int displayIndex);
        static /*0x15c96a0*/ int GetMaxToneMapLuminance(int displayIndex);
        static /*0x15c96e0*/ int GetMinToneMapLuminance(int displayIndex);
        static /*0x15c9760*/ void RequestHDRModeChangeInternal(int displayIndex, bool enabled);
        /*0x15c9990*/ HDROutputSettings();
        /*0x32f460*/ HDROutputSettings(int displayIndex);
        /*0x15c99b0*/ bool get_active();
        /*0x15c9a20*/ bool get_available();
        /*0x15c9d10*/ void set_automaticHDRTonemapping(bool value);
        /*0x15c9a90*/ UnityEngine.ColorGamut get_displayColorGamut();
        /*0x15c9ca0*/ float get_paperWhiteNits();
        /*0x15c9b50*/ int get_maxFullFrameToneMapLuminance();
        /*0x15c9bc0*/ int get_maxToneMapLuminance();
        /*0x15c9c30*/ int get_minToneMapLuminance();
        /*0x15c97a0*/ void RequestHDRModeChange(bool enabled);
    }

    class ColorGamutUtility
    {
        static /*0x15bfe10*/ UnityEngine.ColorPrimaries GetColorPrimaries(UnityEngine.ColorGamut gamut);
        static /*0x15bfe90*/ UnityEngine.WhitePoint GetWhitePoint(UnityEngine.ColorGamut gamut);
        static /*0x15bfe50*/ UnityEngine.TransferFunction GetTransferFunction(UnityEngine.ColorGamut gamut);
    }

    struct Resolution
    {
        /*0x10*/ int m_Width;
        /*0x14*/ int m_Height;
        /*0x18*/ UnityEngine.RefreshRate m_RefreshRate;

        /*0x15d8ad0*/ string ToString();
    }

    struct RenderInstancedDataLayout
    {
        /*0x10*/ int <size>k__BackingField;
        /*0x14*/ int <offsetObjectToWorld>k__BackingField;
        /*0x18*/ int <offsetPrevObjectToWorld>k__BackingField;
        /*0x1c*/ int <offsetRenderingLayerMask>k__BackingField;
    }

    class QualitySettings : UnityEngine.Object
    {
        static /*0x0*/ System.Action<int, int> activeQualityLevelChanged;

        static /*0x15d3130*/ void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel);
        static /*0x15d3220*/ UnityEngine.ShadowmaskMode get_shadowmaskMode();
        static /*0x15d3290*/ void set_enableLODCrossFade(bool value);
        static /*0x15d31c0*/ int get_antiAliasing();
        static /*0x15d3250*/ void set_antiAliasing(int value);
        static /*0x15d31f0*/ bool get_billboardsFaceCameraPosition();
        static /*0x15d3190*/ UnityEngine.ColorSpace get_activeColorSpace();
    }

    class ImageEffectAllowedInSceneView : System.Attribute
    {
        /*0x534220*/ ImageEffectAllowedInSceneView();
    }

    class TrailRenderer : UnityEngine.Renderer
    {
        /*0x15b84e0*/ TrailRenderer();
        /*0x15dd590*/ void set_emitting(bool value);
    }

    class LineRenderer : UnityEngine.Renderer
    {
        /*0x15b84e0*/ LineRenderer();
        /*0x15cb1b0*/ float get_startWidth();
        /*0x15cb3c0*/ void set_startWidth(float value);
        /*0x15cb090*/ float get_endWidth();
        /*0x15cb290*/ void set_endWidth(float value);
        /*0x15cb160*/ UnityEngine.Color get_startColor();
        /*0x15cb370*/ void set_startColor(UnityEngine.Color value);
        /*0x15cb240*/ void set_endColor(UnityEngine.Color value);
        /*0x15cb0d0*/ int get_positionCount();
        /*0x15cb2e0*/ void set_positionCount(int value);
        /*0x15cb040*/ void SetPosition(int index, UnityEngine.Vector3 position);
        /*0x15caf40*/ UnityEngine.Vector3 GetPosition(int index);
        /*0x15cafa0*/ int GetPositions(UnityEngine.Vector3[] positions);
        /*0x15cb110*/ void get_startColor_Injected(ref UnityEngine.Color ret);
        /*0x15cb320*/ void set_startColor_Injected(ref UnityEngine.Color value);
        /*0x15cb1f0*/ void set_endColor_Injected(ref UnityEngine.Color value);
        /*0x15caff0*/ void SetPosition_Injected(int index, ref UnityEngine.Vector3 position);
        /*0x15caef0*/ void GetPosition_Injected(int index, ref UnityEngine.Vector3 ret);
    }

    class MaterialPropertyBlock
    {
        /*0x10*/ nint m_Ptr;

        static /*0x15cb560*/ nint CreateImpl();
        static /*0x15cb590*/ void DestroyImpl(nint mpb);
        /*0x15cc500*/ MaterialPropertyBlock();
        /*0x15cbad0*/ void SetIntImpl(int name, int value);
        /*0x15cba00*/ void SetFloatImpl(int name, float value);
        /*0x15cc3d0*/ void SetVectorImpl(int name, UnityEngine.Vector4 value);
        /*0x15cbf00*/ void SetMatrixImpl(int name, UnityEngine.Matrix4x4 value);
        /*0x15cc0c0*/ void SetTextureImpl(int name, UnityEngine.Texture value);
        /*0x15cc060*/ void SetRenderTextureImpl(int name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x15cb750*/ void SetFloatArrayImpl(int name, float[] values, int count);
        /*0x15cc110*/ void SetVectorArrayImpl(int name, UnityEngine.Vector4[] values, int count);
        /*0x15cbc00*/ void SetMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x15cb4d0*/ void Clear(bool keepMemory);
        /*0x15cb520*/ void Clear();
        /*0x15cb7b0*/ void SetFloatArray(int name, float[] values, int count);
        /*0x15cc1a0*/ void SetVectorArray(int name, UnityEngine.Vector4[] values, int count);
        /*0x15cbd50*/ void SetMatrixArray(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x15cb670*/ void Finalize();
        /*0x15cb5d0*/ void Dispose();
        /*0x15cbb20*/ void SetInt(string name, int value);
        /*0x15cbba0*/ void SetInt(int nameID, int value);
        /*0x15cba50*/ void SetFloat(string name, float value);
        /*0x15cba00*/ void SetFloat(int nameID, float value);
        /*0x15cbad0*/ void SetInteger(int nameID, int value);
        /*0x15cc470*/ void SetVector(string name, UnityEngine.Vector4 value);
        /*0x15cc420*/ void SetVector(int nameID, UnityEngine.Vector4 value);
        /*0x15cbfc0*/ void SetMatrix(string name, UnityEngine.Matrix4x4 value);
        /*0x15cbf50*/ void SetMatrix(int nameID, UnityEngine.Matrix4x4 value);
        /*0x15cc0c0*/ void SetTexture(int nameID, UnityEngine.Texture value);
        /*0x15cc060*/ void SetTexture(int nameID, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x15cb910*/ void SetFloatArray(string name, float[] values);
        /*0x15cc300*/ void SetVectorArray(string name, UnityEngine.Vector4[] values);
        /*0x15cc170*/ void SetVectorArray(int nameID, UnityEngine.Vector4[] values);
        /*0x15cbc60*/ void SetMatrixArray(string name, UnityEngine.Matrix4x4[] values);
        /*0x15cc380*/ void SetVectorImpl_Injected(int name, ref UnityEngine.Vector4 value);
        /*0x15cbeb0*/ void SetMatrixImpl_Injected(int name, ref UnityEngine.Matrix4x4 value);
    }

    class Renderer : UnityEngine.Component
    {
        /*0x15b84e0*/ Renderer();
        /*0x15d8640*/ UnityEngine.Bounds get_bounds();
        /*0x15d8770*/ UnityEngine.Bounds get_localBounds();
        /*0x15d84e0*/ UnityEngine.Material GetMaterial();
        /*0x15d8520*/ UnityEngine.Material GetSharedMaterial();
        /*0x15d8560*/ void SetMaterial(UnityEngine.Material m);
        /*0x15d86a0*/ bool get_enabled();
        /*0x15d8920*/ void set_enabled(bool value);
        /*0x15d86e0*/ bool get_isVisible();
        /*0x15d89c0*/ void set_shadowCastingMode(UnityEngine.Rendering.ShadowCastingMode value);
        /*0x15d8970*/ void set_receiveShadows(bool value);
        /*0x15d8a40*/ void set_sortingLayerName(string value);
        /*0x15d8850*/ int get_sortingLayerID();
        /*0x15d8a00*/ void set_sortingLayerID(int value);
        /*0x15d8890*/ int get_sortingOrder();
        /*0x15d8a90*/ void set_sortingOrder(int value);
        /*0x15d87d0*/ int get_sortingGroupID();
        /*0x15d8810*/ int get_sortingGroupOrder();
        /*0x15d85b0*/ bool get_allowOcclusionWhenDynamic();
        /*0x15d88d0*/ void set_allowOcclusionWhenDynamic(bool value);
        /*0x15d84e0*/ UnityEngine.Material get_material();
        /*0x15d8560*/ void set_material(UnityEngine.Material value);
        /*0x15d8520*/ UnityEngine.Material get_sharedMaterial();
        /*0x15d8560*/ void set_sharedMaterial(UnityEngine.Material value);
        /*0x15d85f0*/ void get_bounds_Injected(ref UnityEngine.Bounds ret);
        /*0x15d8720*/ void get_localBounds_Injected(ref UnityEngine.Bounds ret);
    }

    class RenderSettings : UnityEngine.Object
    {
        static /*0x15d5350*/ bool get_fog();
        static /*0x15d5310*/ UnityEngine.Color get_ambientSkyColor();
        static /*0x15d5170*/ UnityEngine.Color get_ambientEquatorColor();
        static /*0x15d51f0*/ UnityEngine.Color get_ambientGroundColor();
        static /*0x15d5420*/ UnityEngine.Color get_subtractiveShadowColor();
        static /*0x15d53b0*/ UnityEngine.Material get_skybox();
        static /*0x15d5460*/ UnityEngine.Light get_sun();
        static /*0x15d5270*/ UnityEngine.Rendering.SphericalHarmonicsL2 get_ambientProbe();
        static /*0x15d5380*/ float get_reflectionIntensity();
        static /*0x15d52d0*/ void get_ambientSkyColor_Injected(ref UnityEngine.Color ret);
        static /*0x15d5130*/ void get_ambientEquatorColor_Injected(ref UnityEngine.Color ret);
        static /*0x15d51b0*/ void get_ambientGroundColor_Injected(ref UnityEngine.Color ret);
        static /*0x15d53e0*/ void get_subtractiveShadowColor_Injected(ref UnityEngine.Color ret);
        static /*0x15d5230*/ void get_ambientProbe_Injected(ref UnityEngine.Rendering.SphericalHarmonicsL2 ret);
    }

    class Shader : UnityEngine.Object
    {
        static /*0x15d9060*/ UnityEngine.Shader Find(string name);
        static /*0x15d9520*/ void set_globalRenderPipeline(string value);
        static /*0x15d9020*/ void EnableKeyword(string keyword);
        static /*0x15d8fe0*/ void DisableKeyword(string keyword);
        static /*0x15d9370*/ int TagToID(string name);
        static /*0x15d90d0*/ int PropertyToID(string name);
        static /*0x15d91f0*/ void SetGlobalFloatImpl(int name, float value);
        static /*0x15d9330*/ void SetGlobalVectorImpl(int name, UnityEngine.Vector4 value);
        static /*0x15d9240*/ void SetGlobalTextureImpl(int name, UnityEngine.Texture value);
        static /*0x15d9190*/ void SetGlobalConstantBufferImpl(int name, UnityEngine.ComputeBuffer value, int offset, int size);
        static /*0x15d91f0*/ void SetGlobalFloat(int nameID, float value);
        static /*0x15d9110*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
        static /*0x15d9280*/ void SetGlobalTexture(string name, UnityEngine.Texture value);
        static /*0x15d9240*/ void SetGlobalTexture(int nameID, UnityEngine.Texture value);
        static /*0x15d9190*/ void SetGlobalConstantBuffer(int nameID, UnityEngine.ComputeBuffer value, int offset, int size);
        static /*0x15d92f0*/ void SetGlobalVectorImpl_Injected(int name, ref UnityEngine.Vector4 value);
        /*0x15d93b0*/ Shader();
        /*0x15d9400*/ bool get_isSupported();
        /*0x15d9490*/ UnityEngine.Rendering.LocalKeywordSpace get_keywordSpace();
        /*0x15d94e0*/ int get_passCount();
        /*0x15d9440*/ void get_keywordSpace_Injected(ref UnityEngine.Rendering.LocalKeywordSpace ret);
    }

    class Material : UnityEngine.Object
    {
        static /*0x15cc620*/ void CreateWithShader(UnityEngine.Material self, UnityEngine.Shader shader);
        static /*0x15cc5d0*/ void CreateWithMaterial(UnityEngine.Material self, UnityEngine.Material source);
        static /*0x15cc670*/ void CreateWithString(UnityEngine.Material self);
        /*0x15cdad0*/ Material(UnityEngine.Shader shader);
        /*0x15cdbc0*/ Material(UnityEngine.Material source);
        /*0x15cdb50*/ Material(string contents);
        /*0x15cddc0*/ UnityEngine.Shader get_shader();
        /*0x15cde90*/ void set_shader(UnityEngine.Shader value);
        /*0x15cdc80*/ UnityEngine.Texture get_mainTexture();
        /*0x15cc8c0*/ int GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags attributeFlag);
        /*0x15ccc80*/ bool HasProperty(int nameID);
        /*0x15cccc0*/ bool HasProperty(string name);
        /*0x15cde50*/ void set_renderQueue(int value);
        /*0x15cdd80*/ int get_rawRenderQueue();
        /*0x15cc700*/ void EnableKeyword(string keyword);
        /*0x15cc6b0*/ void DisableKeyword(string keyword);
        /*0x15cce80*/ void SetEnabledKeywords(UnityEngine.Rendering.LocalKeyword[] keywords);
        /*0x15cce80*/ void set_enabledKeywords(UnityEngine.Rendering.LocalKeyword[] value);
        /*0x15cdc40*/ bool get_enableInstancing();
        /*0x15cde00*/ void set_enableInstancing(bool value);
        /*0x15cdd40*/ int get_passCount();
        /*0x15cc750*/ int FindPass(string passName);
        /*0x15cca60*/ string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue);
        /*0x15ccad0*/ string GetTag(string tag, bool searchFallbacks);
        /*0x15cd660*/ bool SetPass(int pass);
        /*0x15cc580*/ void CopyPropertiesFromMaterial(UnityEngine.Material mat);
        /*0x15cca20*/ string[] GetShaderKeywords();
        /*0x15cd6a0*/ void SetShaderKeywords(string[] names);
        /*0x15cca20*/ string[] get_shaderKeywords();
        /*0x15cd6a0*/ void set_shaderKeywords(string[] value);
        /*0x15cc540*/ int ComputeCRC();
        /*0x15cd220*/ void SetIntImpl(int name, int value);
        /*0x15cd150*/ void SetFloatImpl(int name, float value);
        /*0x15ccd80*/ void SetColorImpl(int name, UnityEngine.Color value);
        /*0x15cd5a0*/ void SetMatrixImpl(int name, UnityEngine.Matrix4x4 value);
        /*0x15cd6f0*/ void SetTextureImpl(int name, UnityEngine.Texture value);
        /*0x15cce20*/ void SetConstantBufferImpl(int name, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x15cc900*/ float GetFloatImpl(int name);
        /*0x15cc7f0*/ UnityEngine.Color GetColorImpl(int name);
        /*0x15ccb60*/ UnityEngine.Texture GetTextureImpl(int name);
        /*0x15cced0*/ void SetFloatArrayImpl(int name, float[] values, int count);
        /*0x15cd7c0*/ void SetVectorArrayImpl(int name, UnityEngine.Vector4[] values, int count);
        /*0x15cd2d0*/ void SetMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x15ccff0*/ void SetFloatArray(int name, float[] values, int count);
        /*0x15cd820*/ void SetVectorArray(int name, UnityEngine.Vector4[] values, int count);
        /*0x15cd330*/ void SetMatrixArray(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x15cd270*/ void SetInt(int nameID, int value);
        /*0x15cd1a0*/ void SetFloat(string name, float value);
        /*0x15cd150*/ void SetFloat(int nameID, float value);
        /*0x15cd220*/ void SetInteger(int nameID, int value);
        /*0x15ccdd0*/ void SetColor(int nameID, UnityEngine.Color value);
        /*0x15cda40*/ void SetVector(int nameID, UnityEngine.Vector4 value);
        /*0x15cd5f0*/ void SetMatrix(int nameID, UnityEngine.Matrix4x4 value);
        /*0x15cd740*/ void SetTexture(string name, UnityEngine.Texture value);
        /*0x15cd6f0*/ void SetTexture(int nameID, UnityEngine.Texture value);
        /*0x15cce20*/ void SetConstantBuffer(int nameID, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x15ccf30*/ void SetFloatArray(int nameID, float[] values);
        /*0x15cd980*/ void SetVectorArray(int nameID, UnityEngine.Vector4[] values);
        /*0x15cd490*/ void SetMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
        /*0x15cc9b0*/ int GetInt(string name);
        /*0x15cc940*/ float GetFloat(string name);
        /*0x15cc900*/ float GetFloat(int nameID);
        /*0x15cc850*/ UnityEngine.Color GetColor(int nameID);
        /*0x15ccc10*/ UnityEngine.Vector4 GetVector(int nameID);
        /*0x15ccba0*/ UnityEngine.Texture GetTexture(string name);
        /*0x15ccb60*/ UnityEngine.Texture GetTexture(int nameID);
        /*0x15ccd30*/ void SetColorImpl_Injected(int name, ref UnityEngine.Color value);
        /*0x15cd550*/ void SetMatrixImpl_Injected(int name, ref UnityEngine.Matrix4x4 value);
        /*0x15cc7a0*/ void GetColorImpl_Injected(int name, ref UnityEngine.Color ret);
    }

    class GraphicsBuffer : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;

        static /*0x15c7b80*/ bool RequiresCompute(UnityEngine.GraphicsBuffer.Target target);
        static /*0x15c7b70*/ bool IsVertexIndexOrCopyOnly(UnityEngine.GraphicsBuffer.Target target);
        static /*0x15c76a0*/ nint InitBuffer(UnityEngine.GraphicsBuffer.Target target, UnityEngine.GraphicsBuffer.UsageFlags usageFlags, int count, int stride);
        static /*0x15c7440*/ void DestroyBuffer(UnityEngine.GraphicsBuffer buf);
        /*0x15c7be0*/ GraphicsBuffer(UnityEngine.GraphicsBuffer.Target target, int count, int stride);
        /*0x15c75e0*/ void Finalize();
        /*0x15c7480*/ void Dispose();
        /*0x15c7520*/ void Dispose(bool disposing);
        /*0x15c7700*/ void InternalInitialization(UnityEngine.GraphicsBuffer.Target target, UnityEngine.GraphicsBuffer.UsageFlags usageFlags, int count, int stride);
        /*0x15c7480*/ void Release();
        /*0x2a5510*/ void SetData<T>(Unity.Collections.NativeArray<T> data);
        /*0x2a5510*/ void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
        /*0x15c7b00*/ void InternalSetNativeData(nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
        /*0x15c7b90*/ void set_name(string value);
        /*0x15c7b90*/ void SetName(string name);

        enum Target
        {
            Vertex = 1,
            Index = 2,
            CopySource = 4,
            CopyDestination = 8,
            Structured = 16,
            Raw = 32,
            Append = 64,
            Counter = 128,
            IndirectArguments = 256,
            Constant = 512,
        }

        enum UsageFlags
        {
            None = 0,
            LockBufferForWrite = 1,
        }
    }

    struct LightBakingOutput
    {
        /*0x10*/ int probeOcclusionLightIndex;
        /*0x14*/ int occlusionMaskChannel;
        /*0x18*/ UnityEngine.LightmapBakeType lightmapBakeType;
        /*0x1c*/ UnityEngine.MixedLightingMode mixedLightingMode;
        /*0x20*/ bool isBaked;
    }

    class Light : UnityEngine.Behaviour
    {
        /*0x18*/ int m_BakedIndex;

        /*0x15b84e0*/ Light();
        /*0x15cae30*/ UnityEngine.LightType get_type();
        /*0x15cadf0*/ float get_spotAngle();
        /*0x15cabb0*/ float get_innerSpotAngle();
        /*0x15caae0*/ UnityEngine.Color get_color();
        /*0x15caa50*/ float get_colorTemperature();
        /*0x15cae70*/ bool get_useColorTemperature();
        /*0x15cabf0*/ float get_intensity();
        /*0x15caa10*/ float get_bounceIntensity();
        /*0x15cac70*/ float get_shadowBias();
        /*0x15cacf0*/ float get_shadowNormalBias();
        /*0x15cacb0*/ float get_shadowNearPlane();
        /*0x15cac30*/ float get_range();
        /*0x15ca9c0*/ UnityEngine.LightBakingOutput get_bakingOutput();
        /*0x15caeb0*/ void set_renderingLayerMask(int value);
        /*0x15cadb0*/ UnityEngine.LightShadows get_shadows();
        /*0x15cad70*/ float get_shadowStrength();
        /*0x15cad30*/ UnityEngine.Rendering.LightShadowResolution get_shadowResolution();
        /*0x15cab30*/ float get_cookieSize();
        /*0x15cab70*/ UnityEngine.Texture get_cookie();
        /*0x15caa90*/ void get_color_Injected(ref UnityEngine.Color ret);
        /*0x15ca970*/ void get_bakingOutput_Injected(ref UnityEngine.LightBakingOutput ret);
    }

    class Skybox : UnityEngine.Behaviour
    {
        /*0x15d95e0*/ UnityEngine.Material get_material();
    }

    class MeshFilter : UnityEngine.Component
    {
        /*0x15b84e0*/ MeshFilter();
        /*0x32d010*/ void DontStripMeshFilter();
        /*0x15ce7a0*/ void set_sharedMesh(UnityEngine.Mesh value);
    }

    enum TransparencySortMode
    {
        Default = 0,
        Perspective = 1,
        Orthographic = 2,
        CustomAxis = 3,
    }

    enum StereoTargetEyeMask
    {
        None = 0,
        Left = 1,
        Right = 2,
        Both = 3,
    }

    enum CameraType
    {
        Game = 1,
        SceneView = 2,
        Preview = 4,
        VR = 8,
        Reflection = 16,
    }

    enum ComputeBufferType
    {
        Default = 0,
        Raw = 1,
        Append = 2,
        Counter = 4,
        Constant = 8,
        Structured = 16,
        DrawIndirect = 256,
        IndirectArguments = 256,
        GPUMemory = 512,
    }

    enum LightType
    {
        Spot = 0,
        Directional = 1,
        Point = 2,
        Area = 3,
        Rectangle = 3,
        Disc = 4,
    }

    enum LightShadows
    {
        None = 0,
        Hard = 1,
        Soft = 2,
    }

    enum LightmapBakeType
    {
        Realtime = 4,
        Baked = 2,
        Mixed = 1,
    }

    enum MixedLightingMode
    {
        IndirectOnly = 0,
        Shadowmask = 2,
        Subtractive = 1,
    }

    enum ShadowmaskMode
    {
        Shadowmask = 0,
        DistanceShadowmask = 1,
    }

    enum ShadowObjectsFilter
    {
        AllObjects = 0,
        DynamicOnly = 1,
        StaticOnly = 2,
    }

    enum CameraClearFlags
    {
        Skybox = 1,
        Color = 2,
        SolidColor = 2,
        Depth = 3,
        Nothing = 4,
    }

    enum DepthTextureMode
    {
        None = 0,
        Depth = 1,
        DepthNormals = 2,
        MotionVectors = 4,
    }

    enum MeshTopology
    {
        Triangles = 0,
        Quads = 2,
        Lines = 3,
        LineStrip = 4,
        Points = 5,
    }

    enum ColorSpace
    {
        Uninitialized = -1,
        Gamma = 0,
        Linear = 1,
    }

    enum ColorGamut
    {
        sRGB = 0,
        Rec709 = 1,
        Rec2020 = 2,
        DisplayP3 = 3,
        HDR10 = 4,
        DolbyHDR = 5,
        P3D65G22 = 6,
    }

    enum ColorPrimaries
    {
        Unknown = -1,
        Rec709 = 0,
        Rec2020 = 1,
        P3 = 2,
    }

    enum WhitePoint
    {
        Unknown = -1,
        D65 = 0,
    }

    enum TransferFunction
    {
        Unknown = -1,
        sRGB = 0,
        BT1886 = 1,
        PQ = 2,
        Linear = 3,
        Gamma22 = 4,
    }

    enum ScreenOrientation
    {
        Portrait = 1,
        PortraitUpsideDown = 2,
        LandscapeLeft = 3,
        LandscapeRight = 4,
        AutoRotation = 5,
        Unknown = 0,
        Landscape = 3,
    }

    enum FilterMode
    {
        Point = 0,
        Bilinear = 1,
        Trilinear = 2,
    }

    enum TextureWrapMode
    {
        Repeat = 0,
        Clamp = 1,
        Mirror = 2,
        MirrorOnce = 3,
    }

    enum TextureFormat
    {
        Alpha8 = 1,
        ARGB4444 = 2,
        RGB24 = 3,
        RGBA32 = 4,
        ARGB32 = 5,
        RGB565 = 7,
        R16 = 9,
        DXT1 = 10,
        DXT5 = 12,
        RGBA4444 = 13,
        BGRA32 = 14,
        RHalf = 15,
        RGHalf = 16,
        RGBAHalf = 17,
        RFloat = 18,
        RGFloat = 19,
        RGBAFloat = 20,
        YUY2 = 21,
        RGB9e5Float = 22,
        BC4 = 26,
        BC5 = 27,
        BC6H = 24,
        BC7 = 25,
        DXT1Crunched = 28,
        DXT5Crunched = 29,
        PVRTC_RGB2 = 30,
        PVRTC_RGBA2 = 31,
        PVRTC_RGB4 = 32,
        PVRTC_RGBA4 = 33,
        ETC_RGB4 = 34,
        EAC_R = 41,
        EAC_R_SIGNED = 42,
        EAC_RG = 43,
        EAC_RG_SIGNED = 44,
        ETC2_RGB = 45,
        ETC2_RGBA1 = 46,
        ETC2_RGBA8 = 47,
        ASTC_4x4 = 48,
        ASTC_5x5 = 49,
        ASTC_6x6 = 50,
        ASTC_8x8 = 51,
        ASTC_10x10 = 52,
        ASTC_12x12 = 53,
        ETC_RGB4_3DS = 60,
        ETC_RGBA8_3DS = 61,
        RG16 = 62,
        R8 = 63,
        ETC_RGB4Crunched = 64,
        ETC2_RGBA8Crunched = 65,
        ASTC_HDR_4x4 = 66,
        ASTC_HDR_5x5 = 67,
        ASTC_HDR_6x6 = 68,
        ASTC_HDR_8x8 = 69,
        ASTC_HDR_10x10 = 70,
        ASTC_HDR_12x12 = 71,
        RG32 = 72,
        RGB48 = 73,
        RGBA64 = 74,
        ASTC_RGB_4x4 = 48,
        ASTC_RGB_5x5 = 49,
        ASTC_RGB_6x6 = 50,
        ASTC_RGB_8x8 = 51,
        ASTC_RGB_10x10 = 52,
        ASTC_RGB_12x12 = 53,
        ASTC_RGBA_4x4 = 54,
        ASTC_RGBA_5x5 = 55,
        ASTC_RGBA_6x6 = 56,
        ASTC_RGBA_8x8 = 57,
        ASTC_RGBA_10x10 = 58,
        ASTC_RGBA_12x12 = 59,
    }

    enum TextureColorSpace
    {
        Linear = 0,
        sRGB = 1,
    }

    enum CubemapFace
    {
        Unknown = -1,
        PositiveX = 0,
        NegativeX = 1,
        PositiveY = 2,
        NegativeY = 3,
        PositiveZ = 4,
        NegativeZ = 5,
    }

    enum RenderTextureFormat
    {
        ARGB32 = 0,
        Depth = 1,
        ARGBHalf = 2,
        Shadowmap = 3,
        RGB565 = 4,
        ARGB4444 = 5,
        ARGB1555 = 6,
        Default = 7,
        ARGB2101010 = 8,
        DefaultHDR = 9,
        ARGB64 = 10,
        ARGBFloat = 11,
        RGFloat = 12,
        RGHalf = 13,
        RFloat = 14,
        RHalf = 15,
        R8 = 16,
        ARGBInt = 17,
        RGInt = 18,
        RInt = 19,
        BGRA32 = 20,
        RGB111110Float = 22,
        RG32 = 23,
        RGBAUShort = 24,
        RG16 = 25,
        BGRA10101010_XR = 26,
        BGR101010_XR = 27,
        R16 = 28,
    }

    enum VRTextureUsage
    {
        None = 0,
        OneEye = 1,
        TwoEyes = 2,
        DeviceSpecific = 3,
    }

    enum RenderTextureCreationFlags
    {
        MipMap = 1,
        AutoGenerateMips = 2,
        SRGB = 4,
        EyeTexture = 8,
        EnableRandomWrite = 16,
        CreatedFromScript = 32,
        AllowVerticalFlip = 128,
        NoResolvedColorSurface = 256,
        DynamicallyScalable = 1024,
        BindMS = 2048,
    }

    enum RenderTextureReadWrite
    {
        Default = 0,
        Linear = 1,
        sRGB = 2,
    }

    enum RenderTextureMemoryless
    {
        None = 0,
        Color = 1,
        Depth = 2,
        MSAA = 4,
    }

    enum HDRDisplaySupportFlags
    {
        None = 0,
        Supported = 1,
        RuntimeSwitchable = 2,
        AutomaticTonemapping = 4,
    }

    enum LightmapsMode
    {
        NonDirectional = 0,
        CombinedDirectional = 1,
    }

    class LightProbeProxyVolume : UnityEngine.Behaviour
    {
    }

    class SkinnedMeshRenderer : UnityEngine.Renderer
    {
    }

    class MeshRenderer : UnityEngine.Renderer
    {
        /*0x32d010*/ void DontStripMeshRenderer();
    }

    class Mesh : UnityEngine.Object
    {
        static /*0x15cf2b0*/ void Internal_Create(UnityEngine.Mesh mono);
        static /*0x15cf110*/ UnityEngine.Rendering.VertexAttribute GetUVChannel(int uvIndex);
        static /*0x15cec50*/ int DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute channel);
        /*0x15d1200*/ Mesh();
        /*0x15d1660*/ void set_indexFormat(UnityEngine.Rendering.IndexFormat value);
        /*0x15d0f50*/ void SetVertexBufferParamsFromArray(int vertexCount, UnityEngine.Rendering.VertexAttributeDescriptor[] attributes);
        /*0x15cf250*/ void InternalSetVertexBufferData(int stream, nint data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x15cedc0*/ uint GetIndexCountImpl(int submesh);
        /*0x15ceec0*/ int[] GetIndicesImpl(int submesh, bool applyBaseVertex);
        /*0x15cfa20*/ void SetIndicesImpl(int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        /*0x15cfa90*/ void SetIndicesNativeArrayImpl(int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, nint indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        /*0x15cf3a0*/ void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute ch);
        /*0x15cf210*/ bool HasVertexAttribute(UnityEngine.Rendering.VertexAttribute attr);
        /*0x15cf650*/ void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x15ced00*/ System.Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim);
        /*0x15ced60*/ void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values);
        /*0x15d1320*/ bool get_canAccess();
        /*0x15d1470*/ int get_vertexCount();
        /*0x15d13f0*/ int get_subMeshCount();
        /*0x15cf0a0*/ UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(int index);
        /*0x15d12c0*/ UnityEngine.Bounds get_bounds();
        /*0x15d1540*/ void set_bounds(UnityEngine.Bounds value);
        /*0x15cebc0*/ void ClearImpl(bool keepVertexLayout);
        /*0x15cf460*/ void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x15cf2f0*/ void MarkDynamicImpl();
        /*0x15d1140*/ void UploadMeshDataImpl(bool markNoLongerReadable);
        /*0x2a5510*/ T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim);
        /*0x184ab0*/ T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel);
        /*0x15d0320*/ void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x2a5510*/ void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x2a5510*/ void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x2a5510*/ void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Collections.Generic.List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x2a5510*/ void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, System.Collections.Generic.List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x2a5510*/ void GetListForChannel<T>(System.Collections.Generic.List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim);
        /*0x2a5510*/ void GetListForChannel<T>(System.Collections.Generic.List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim, UnityEngine.Rendering.VertexAttributeFormat channelType);
        /*0x15d14b0*/ UnityEngine.Vector3[] get_vertices();
        /*0x15d1910*/ void set_vertices(UnityEngine.Vector3[] value);
        /*0x15d13b0*/ UnityEngine.Vector3[] get_normals();
        /*0x15d16a0*/ void set_normals(UnityEngine.Vector3[] value);
        /*0x15d1430*/ UnityEngine.Vector4[] get_tangents();
        /*0x15d1700*/ void set_tangents(UnityEngine.Vector4[] value);
        /*0x15d18b0*/ void set_uv(UnityEngine.Vector2[] value);
        /*0x15d1850*/ void set_uv2(UnityEngine.Vector2[] value);
        /*0x15d1600*/ void set_colors(UnityEngine.Color[] value);
        /*0x15d1360*/ UnityEngine.Color32[] get_colors32();
        /*0x15d1590*/ void set_colors32(UnityEngine.Color32[] value);
        /*0x15d10a0*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices);
        /*0x15d1020*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length);
        /*0x15d0fa0*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x15d0280*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals);
        /*0x15d0200*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length);
        /*0x15d0180*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x15d0680*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents);
        /*0x15d07a0*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length);
        /*0x15d0720*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x15cf980*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors);
        /*0x15cf740*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors, int start, int length);
        /*0x15cf870*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x15cf7c0*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors);
        /*0x15cf8f0*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length);
        /*0x15cf6b0*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x2a5510*/ void SetUvsImpl<T>(int uvIndex, int dim, System.Collections.Generic.List<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x15d0c40*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs);
        /*0x15d0e10*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs);
        /*0x15d0d80*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, int start, int length);
        /*0x15d0ec0*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x15d0cf0*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length);
        /*0x15d0bb0*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x2a5510*/ void GetUVsImpl<T>(int uvIndex, System.Collections.Generic.List<T> uvs, int dim);
        /*0x15cf1a0*/ void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs);
        /*0x15d0f50*/ void SetVertexBufferParams(int vertexCount, UnityEngine.Rendering.VertexAttributeDescriptor[] attributes);
        /*0x2a5510*/ void SetVertexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x15cf3e0*/ void PrintErrorCantAccessIndices();
        /*0x15ce810*/ bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles);
        /*0x15ce800*/ bool CheckCanAccessSubmeshTriangles(int submesh);
        /*0x15ce7f0*/ bool CheckCanAccessSubmeshIndices(int submesh);
        /*0x15d1760*/ void set_triangles(int[] value);
        /*0x15cef20*/ int[] GetIndices(int submesh);
        /*0x15cefb0*/ int[] GetIndices(int submesh, bool applyBaseVertex);
        /*0x15cee00*/ uint GetIndexCount(int submesh);
        /*0x15ce950*/ void CheckIndicesArrayRange(int valuesLength, int start, int length);
        /*0x15d0820*/ void SetTrianglesImpl(int submesh, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex);
        /*0x15d0ac0*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh);
        /*0x15d09c0*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x15d08e0*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x15d00a0*/ void SetIndices(int[] indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds);
        /*0x15cfef0*/ void SetIndices(int[] indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x15cfbe0*/ void SetIndices(int[] indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x15cfb00*/ void SetIndices(ushort[] indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x15cffd0*/ void SetIndices(ushort[] indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x2a5510*/ void SetIndices<T>(Unity.Collections.NativeArray<T> indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x2a5510*/ void SetIndices<T>(Unity.Collections.NativeArray<T> indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x15cfcb0*/ void SetIndices(System.Collections.Generic.List<int> indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x15cfde0*/ void SetIndices(System.Collections.Generic.List<int> indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x15cec10*/ void Clear();
        /*0x15cf4a0*/ void RecalculateBounds();
        /*0x15cf570*/ void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x15cf330*/ void MarkDynamic();
        /*0x15d1190*/ void UploadMeshData(bool markNoLongerReadable);
        /*0x15cf050*/ void GetSubMesh_Injected(int index, ref UnityEngine.Rendering.SubMeshDescriptor ret);
        /*0x15d1270*/ void get_bounds_Injected(ref UnityEngine.Bounds ret);
        /*0x15d14f0*/ void set_bounds_Injected(ref UnityEngine.Bounds value);

        struct MeshData
        {
            /*0x10*/ nint m_Ptr;
        }
    }

    struct BoneWeight : System.IEquatable<UnityEngine.BoneWeight>
    {
        /*0x10*/ float m_Weight0;
        /*0x14*/ float m_Weight1;
        /*0x18*/ float m_Weight2;
        /*0x1c*/ float m_Weight3;
        /*0x20*/ int m_BoneIndex0;
        /*0x24*/ int m_BoneIndex1;
        /*0x28*/ int m_BoneIndex2;
        /*0x2c*/ int m_BoneIndex3;

        /*0x6ef1f0*/ float get_weight0();
        /*0x6ef200*/ float get_weight1();
        /*0x501230*/ float get_weight2();
        /*0x501220*/ float get_weight3();
        /*0x15bceb0*/ int get_boneIndex0();
        /*0x8b8c40*/ int get_boneIndex1();
        /*0xbe6cb0*/ int get_boneIndex2();
        /*0x9e3120*/ int get_boneIndex3();
        /*0x15bcda0*/ int GetHashCode();
        /*0x15bcd00*/ bool Equals(object other);
        /*0x15bcc30*/ bool Equals(UnityEngine.BoneWeight other);
    }

    class Texture : UnityEngine.Object
    {
        static /*0x0*/ int GenerateAllMips;

        static /*0x15dcf80*/ Texture();
        /*0x15dcfc0*/ Texture();
        /*0x15dd1a0*/ int get_mipmapCount();
        /*0x15dd0d0*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x15dcb10*/ int GetDataWidth();
        /*0x15dcad0*/ int GetDataHeight();
        /*0x15dcb50*/ UnityEngine.Rendering.TextureDimension GetDimension();
        /*0x15dcb10*/ int get_width();
        /*0x15dd450*/ void set_width(int value);
        /*0x15dcad0*/ int get_height();
        /*0x15dd3c0*/ void set_height(int value);
        /*0x15dcb50*/ UnityEngine.Rendering.TextureDimension get_dimension();
        /*0x15dd340*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
        /*0x15dd120*/ bool get_isReadable();
        /*0x15dd2c0*/ UnityEngine.TextureWrapMode get_wrapMode();
        /*0x15dd550*/ void set_wrapMode(UnityEngine.TextureWrapMode value);
        /*0x15dd490*/ void set_wrapModeU(UnityEngine.TextureWrapMode value);
        /*0x15dd4d0*/ void set_wrapModeV(UnityEngine.TextureWrapMode value);
        /*0x15dd510*/ void set_wrapModeW(UnityEngine.TextureWrapMode value);
        /*0x15dd090*/ UnityEngine.FilterMode get_filterMode();
        /*0x15dd380*/ void set_filterMode(UnityEngine.FilterMode value);
        /*0x15dd050*/ int get_anisoLevel();
        /*0x15dd300*/ void set_anisoLevel(int value);
        /*0x15dd160*/ float get_mipMapBias();
        /*0x15dd400*/ void set_mipMapBias(float value);
        /*0x15dd230*/ UnityEngine.Vector2 get_texelSize();
        /*0x15dd280*/ uint get_updateCount();
        /*0x15dcbf0*/ int Internal_GetActiveTextureColorSpace();
        /*0x15dd010*/ UnityEngine.ColorSpace get_activeTextureColorSpace();
        /*0x15dcbe0*/ UnityEngine.TextureColorSpace GetTextureColorSpace(bool linear);
        /*0x15dcb90*/ UnityEngine.TextureColorSpace GetTextureColorSpace(UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x15dcde0*/ bool ValidateFormat(UnityEngine.TextureFormat format);
        /*0x15dcc30*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage);
        /*0x15dca40*/ UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture t);
        /*0x15dc9e0*/ UnityEngine.UnityException CreateNativeArrayLengthOverflowException();
        /*0x15dd1e0*/ void get_texelSize_Injected(ref UnityEngine.Vector2 ret);
    }

    class Texture2D : UnityEngine.Texture
    {
        static int streamingMipmapsPriorityMin = -128;
        static int streamingMipmapsPriorityMax = 127;

        static /*0x15dbbe0*/ UnityEngine.Texture2D get_whiteTexture();
        static /*0x15dbb30*/ UnityEngine.Texture2D get_blackTexture();
        static /*0x15daae0*/ bool Internal_CreateImpl(UnityEngine.Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex, string mipmapLimitGroupName);
        static /*0x15dab40*/ void Internal_Create(UnityEngine.Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex, string mipmapLimitGroupName);
        /*0x15db570*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount, nint nativeTex, string mipmapLimitGroupName);
        /*0x15db4c0*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x15db7f0*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, nint nativeTex, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        /*0x15db7b0*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x15dba70*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x15dbb60*/ UnityEngine.TextureFormat get_format();
        /*0x15dbba0*/ bool get_isReadable();
        /*0x15da730*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x15dac30*/ bool ReinitializeImpl(int width, int height);
        /*0x15daf20*/ void SetPixelImpl(int image, int mip, int x, int y, UnityEngine.Color color);
        /*0x15da910*/ UnityEngine.Color GetPixelBilinearImpl(int image, int mip, float u, float v);
        /*0x15dac80*/ bool ReinitializeWithTextureFormatImpl(int width, int height, UnityEngine.TextureFormat textureFormat, bool hasMipMap);
        /*0x15db0b0*/ void SetPixelsImpl(int x, int y, int w, int h, UnityEngine.Color[] pixel, int miplevel, int frame);
        /*0x15daaa0*/ nint GetWritableImageData(int frame);
        /*0x15daa60*/ ulong GetRawImageDataSize();
        /*0x15dae60*/ void SetAllPixels32(UnityEngine.Color32[] colors, int miplevel);
        /*0x15db3d0*/ bool ValidateFormat(UnityEngine.TextureFormat format, int width, int height);
        /*0x15db2a0*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height);
        /*0x15dafa0*/ void SetPixel(int x, int y, UnityEngine.Color color);
        /*0x15db110*/ void SetPixels(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color[] colors, int miplevel);
        /*0x15db1c0*/ void SetPixels(UnityEngine.Color[] colors);
        /*0x15da990*/ UnityEngine.Color GetPixelBilinear(float u, float v);
        /*0x2a5510*/ Unity.Collections.NativeArray<T> GetRawTextureData<T>();
        /*0x15da790*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x15da830*/ void Apply();
        /*0x15dacf0*/ bool Reinitialize(int width, int height);
        /*0x15dad80*/ bool Reinitialize(int width, int height, UnityEngine.TextureFormat format, bool hasMipMap);
        /*0x15dacf0*/ bool Resize(int width, int height);
        /*0x15dadf0*/ bool Resize(int width, int height, UnityEngine.TextureFormat format, bool hasMipMap);
        /*0x15dae60*/ void SetPixels32(UnityEngine.Color32[] colors, int miplevel);
        /*0x15db060*/ void SetPixels32(UnityEngine.Color32[] colors);
        /*0x15daec0*/ void SetPixelImpl_Injected(int image, int mip, int x, int y, ref UnityEngine.Color color);
        /*0x15da8b0*/ void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, ref UnityEngine.Color ret);
    }

    class Cubemap : UnityEngine.Texture
    {
        static /*0x15c0c00*/ bool Internal_CreateImpl(UnityEngine.Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x15c0c60*/ void Internal_Create(UnityEngine.Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x15c1190*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x15c12a0*/ Cubemap(int width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x15c1340*/ Cubemap(int width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x15c1390*/ Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x15c1430*/ Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x15c17a0*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex, bool createUninitialized);
        /*0x15c16c0*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x15c11f0*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, bool mipChain, bool createUninitialized);
        /*0x15c16a0*/ Cubemap(int width, UnityEngine.TextureFormat format, int mipCount);
        /*0x15c1770*/ Cubemap(int width, UnityEngine.TextureFormat format, int mipCount, bool createUninitialized);
        /*0x15c0a80*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x15c1a20*/ bool get_isReadable();
        /*0x15c0d90*/ void SetPixelImpl(int image, int mip, int x, int y, UnityEngine.Color color);
        /*0x15c0f90*/ bool ValidateFormat(UnityEngine.TextureFormat format, int width);
        /*0x15c1070*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width);
        /*0x15c0e10*/ void SetPixel(UnityEngine.CubemapFace face, int x, int y, UnityEngine.Color color);
        /*0x15c0ed0*/ void SetPixel(UnityEngine.CubemapFace face, int x, int y, UnityEngine.Color color, int mip);
        /*0x15c0b60*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x15c0ae0*/ void Apply();
        /*0x15c0d30*/ void SetPixelImpl_Injected(int image, int mip, int x, int y, ref UnityEngine.Color color);
    }

    class Texture3D : UnityEngine.Texture
    {
        static /*0x15dbd30*/ bool Internal_CreateImpl(UnityEngine.Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x15dbd90*/ void Internal_Create(UnityEngine.Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x15dc0f0*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x15dc790*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x15dc210*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x15dc6e0*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x15dc270*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x15dc960*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount);
        /*0x15dc920*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex);
        /*0x15dc4e0*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex, bool createUninitialized);
        /*0x15dc150*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x15dc420*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, bool createUninitialized);
        /*0x15dc850*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, nint nativeTex);
        /*0x15dc9a0*/ bool get_isReadable();
        /*0x15dbf50*/ void SetPixelImpl(int mip, int x, int y, int z, UnityEngine.Color color);
        /*0x15dbc10*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x15dc090*/ void SetPixels(UnityEngine.Color[] colors, int miplevel);
        /*0x15dbe80*/ bool SetPixelDataImpl(nint data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);
        /*0x15dbc90*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x15dbc80*/ void Apply(bool updateMipmaps);
        /*0x15dbc70*/ void Apply();
        /*0x15dbfd0*/ void SetPixel(int x, int y, int z, UnityEngine.Color color, int mipLevel);
        /*0x2a5510*/ void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, int sourceDataStartIndex);
        /*0x15dbef0*/ void SetPixelImpl_Injected(int mip, int x, int y, int z, ref UnityEngine.Color color);
    }

    class Texture2DArray : UnityEngine.Texture
    {
        static /*0x15da6c0*/ int get_allSlices();
        static /*0x15d9800*/ bool Internal_CreateImpl(UnityEngine.Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x15d9860*/ void Internal_Create(UnityEngine.Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x15d9b60*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x15da660*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x15d9c80*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x15da0d0*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x15da2d0*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x15d9e20*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized);
        /*0x15da480*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x15da590*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized);
        /*0x15da4c0*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x15d9bc0*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x15da6f0*/ bool get_isReadable();
        /*0x15d9a70*/ bool ValidateFormat(UnityEngine.TextureFormat format, int width, int height);
        /*0x15d9940*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height);
    }

    class CubemapArray : UnityEngine.Texture
    {
        static /*0x15c0050*/ bool Internal_CreateImpl(UnityEngine.CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x15c00b0*/ void Internal_Create(UnityEngine.CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x15c0260*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x15c0490*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x15c08a0*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x15c08f0*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x15c02c0*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x15c0540*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized);
        /*0x15c0460*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x15c0720*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized);
        /*0x15c07e0*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x15c0990*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x15c0a40*/ bool get_isReadable();
        /*0x15bfed0*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x15c0180*/ void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, int arrayElement, int miplevel);
        /*0x15c01f0*/ void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, int arrayElement);
        /*0x15bff30*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x15bffd0*/ void Apply();
    }

    class RenderTexture : UnityEngine.Texture
    {
        static /*0x15d54d0*/ UnityEngine.RenderTexture GetActive();
        static /*0x15d6680*/ void SetActive(UnityEngine.RenderTexture rt);
        static /*0x15d54d0*/ UnityEngine.RenderTexture get_active();
        static /*0x15d6680*/ void set_active(UnityEngine.RenderTexture value);
        static /*0x15d65c0*/ void Internal_Create(UnityEngine.RenderTexture rt);
        static /*0x15d5b20*/ UnityEngine.RenderTexture GetTemporary_Internal(UnityEngine.RenderTextureDescriptor desc);
        static /*0x15d6600*/ void ReleaseTemporary(UnityEngine.RenderTexture temp);
        static /*0x15d58b0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat);
        static /*0x15d58a0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.RenderTextureFormat format);
        static /*0x15d58a0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Experimental.Rendering.DefaultFormat format);
        static /*0x15d5820*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap);
        static /*0x15d6830*/ void ValidateRenderTextureDesc(UnityEngine.RenderTextureDescriptor desc);
        static /*0x15d5720*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultColorFormat(UnityEngine.Experimental.Rendering.DefaultFormat format);
        static /*0x15d5750*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultDepthStencilFormat(UnityEngine.Experimental.Rendering.DefaultFormat format, int depth);
        static /*0x15d55f0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.RenderTextureFormat renderTextureFormat, UnityEngine.RenderTextureReadWrite readWrite);
        static /*0x15d60c0*/ UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc);
        static /*0x15d59e0*/ UnityEngine.RenderTexture GetTemporaryImpl(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale);
        static /*0x15d62b0*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale);
        static /*0x15d5cc0*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage);
        static /*0x15d5b60*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode);
        static /*0x15d5e20*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing);
        static /*0x15d5f70*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
        static /*0x15d6160*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format);
        static /*0x15d5ae0*/ UnityEngine.RenderTexture GetTemporary_Internal_Injected(ref UnityEngine.RenderTextureDescriptor desc);
        /*0x15d7850*/ RenderTexture();
        /*0x15d7070*/ RenderTexture(UnityEngine.RenderTextureDescriptor desc);
        /*0x15d7a40*/ RenderTexture(UnityEngine.RenderTexture textureToCopy);
        /*0x15d7750*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format);
        /*0x15d6dc0*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x15d73f0*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount);
        /*0x15d6e60*/ RenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount);
        /*0x15d79a0*/ RenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
        /*0x15d7670*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
        /*0x15d72d0*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format);
        /*0x15d71b0*/ RenderTexture(int width, int height, int depth);
        /*0x15d78d0*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format, int mipCount);
        /*0x15d80d0*/ int get_width();
        /*0x15d84a0*/ void set_width(int value);
        /*0x15d7f90*/ int get_height();
        /*0x15d82c0*/ void set_height(int value);
        /*0x15d7e10*/ UnityEngine.Rendering.TextureDimension get_dimension();
        /*0x15d8230*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
        /*0x15d55a0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetColorFormat(bool suppressWarnings);
        /*0x15d66c0*/ void SetColorFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x15d7f50*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x15d66c0*/ void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x15d8050*/ bool get_useMipMap();
        /*0x15d83d0*/ void set_useMipMap(bool value);
        /*0x15d7fd0*/ bool get_sRGB();
        /*0x15d8460*/ void set_vrUsage(UnityEngine.VRTextureUsage value);
        /*0x15d8300*/ void set_memorylessMode(UnityEngine.RenderTextureMemoryless value);
        /*0x15d7e50*/ UnityEngine.RenderTextureFormat get_format();
        /*0x15d8340*/ void set_stencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x15d81f0*/ void set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x15d8150*/ void set_autoGenerateMips(bool value);
        /*0x15d8090*/ int get_volumeDepth();
        /*0x15d8420*/ void set_volumeDepth(int value);
        /*0x15d7c80*/ int get_antiAliasing();
        /*0x15d8110*/ void set_antiAliasing(int value);
        /*0x15d81a0*/ void set_bindTextureMS(bool value);
        /*0x15d8270*/ void set_enableRandomWrite(bool value);
        /*0x15d8010*/ bool get_useDynamicScale();
        /*0x15d8380*/ void set_useDynamicScale(bool value);
        /*0x15d5550*/ UnityEngine.RenderBuffer GetColorBuffer();
        /*0x15d57d0*/ UnityEngine.RenderBuffer GetDepthBuffer();
        /*0x15d6700*/ void SetMipMapCount(int count);
        /*0x15d7cc0*/ UnityEngine.RenderBuffer get_colorBuffer();
        /*0x15d7d20*/ UnityEngine.RenderBuffer get_depthBuffer();
        /*0x15d5490*/ bool Create();
        /*0x15d6640*/ void Release();
        /*0x15d67e0*/ void SetSRGBReadWrite(bool srgb);
        /*0x15d6790*/ void SetRenderTextureDescriptor(UnityEngine.RenderTextureDescriptor desc);
        /*0x15d5980*/ UnityEngine.RenderTextureDescriptor GetDescriptor();
        /*0x15d6410*/ void Initialize(int width, int height, int depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int mipCount);
        /*0x15d7d80*/ UnityEngine.RenderTextureDescriptor get_descriptor();
        /*0x15d5500*/ void GetColorBuffer_Injected(ref UnityEngine.RenderBuffer ret);
        /*0x15d5780*/ void GetDepthBuffer_Injected(ref UnityEngine.RenderBuffer ret);
        /*0x15d6740*/ void SetRenderTextureDescriptor_Injected(ref UnityEngine.RenderTextureDescriptor desc);
        /*0x15d5930*/ void GetDescriptor_Injected(ref UnityEngine.RenderTextureDescriptor ret);
    }

    class CustomRenderTexture : UnityEngine.RenderTexture
    {
    }

    struct RenderTextureDescriptor
    {
        /*0x10*/ int <width>k__BackingField;
        /*0x14*/ int <height>k__BackingField;
        /*0x18*/ int <msaaSamples>k__BackingField;
        /*0x1c*/ int <volumeDepth>k__BackingField;
        /*0x20*/ int <mipCount>k__BackingField;
        /*0x24*/ UnityEngine.Experimental.Rendering.GraphicsFormat _graphicsFormat;
        /*0x28*/ UnityEngine.Experimental.Rendering.GraphicsFormat <stencilFormat>k__BackingField;
        /*0x2c*/ UnityEngine.Experimental.Rendering.GraphicsFormat <depthStencilFormat>k__BackingField;
        /*0x30*/ UnityEngine.Rendering.TextureDimension <dimension>k__BackingField;
        /*0x34*/ UnityEngine.Rendering.ShadowSamplingMode <shadowSamplingMode>k__BackingField;
        /*0x38*/ UnityEngine.VRTextureUsage <vrUsage>k__BackingField;
        /*0x3c*/ UnityEngine.RenderTextureCreationFlags _flags;
        /*0x40*/ UnityEngine.RenderTextureMemoryless <memoryless>k__BackingField;

        /*0x15ea910*/ RenderTextureDescriptor(int width, int height);
        /*0x15eaba0*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat);
        /*0x15ead80*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits);
        /*0x15ea930*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits);
        /*0x15eab00*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits, int mipCount);
        /*0x15eac50*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits, int mipCount, UnityEngine.RenderTextureReadWrite readWrite);
        /*0x15eabc0*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits, int mipCount);
        /*0x15eaa20*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
        /*0x15eab30*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount);
        /*0x6bba50*/ int get_width();
        /*0x6bbd40*/ void set_width(int value);
        /*0xa5a7c0*/ int get_height();
        /*0xfc2c10*/ void set_height(int value);
        /*0x834a60*/ int get_msaaSamples();
        /*0xf0fbd0*/ void set_msaaSamples(int value);
        /*0x837600*/ int get_volumeDepth();
        /*0xf0fbc0*/ void set_volumeDepth(int value);
        /*0x417e30*/ int get_mipCount();
        /*0xdcd9c0*/ void set_mipCount(int value);
        /*0x8b8c40*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x15eb100*/ void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x8a5c50*/ void set_stencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0xc70b00*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat();
        /*0xc70b50*/ void set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x15eae50*/ UnityEngine.RenderTextureFormat get_colorFormat();
        /*0x15eafd0*/ void set_colorFormat(UnityEngine.RenderTextureFormat value);
        /*0x15eaf20*/ bool get_sRGB();
        /*0x15eb1c0*/ void set_sRGB(bool value);
        /*0x15eaec0*/ int get_depthBufferBits();
        /*0x15eb0b0*/ void set_depthBufferBits(int value);
        /*0x3e3af0*/ UnityEngine.Rendering.TextureDimension get_dimension();
        /*0x11172b0*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
        /*0x3e3ad0*/ UnityEngine.Rendering.ShadowSamplingMode get_shadowSamplingMode();
        /*0xc70b30*/ void set_shadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode value);
        /*0x3e3ae0*/ UnityEngine.VRTextureUsage get_vrUsage();
        /*0xc6dab0*/ void set_vrUsage(UnityEngine.VRTextureUsage value);
        /*0xa79cc0*/ UnityEngine.RenderTextureMemoryless get_memoryless();
        /*0xa79cd0*/ void set_memoryless(UnityEngine.RenderTextureMemoryless value);
        /*0x15ea8f0*/ void SetOrClearRenderTextureCreationFlag(bool value, UnityEngine.RenderTextureCreationFlags flag);
        /*0x15eaf80*/ bool get_useMipMap();
        /*0x15eb2a0*/ void set_useMipMap(bool value);
        /*0x15eae30*/ bool get_autoGenerateMips();
        /*0x15eaf90*/ void set_autoGenerateMips(bool value);
        /*0x15eaf10*/ bool get_enableRandomWrite();
        /*0x15eb0e0*/ void set_enableRandomWrite(bool value);
        /*0x15eae40*/ bool get_bindMS();
        /*0x15eafb0*/ void set_bindMS(bool value);
        /*0x15eb090*/ void set_createdFromScript(bool value);
        /*0x15eaf70*/ bool get_useDynamicScale();
        /*0x15eb280*/ void set_useDynamicScale(bool value);
    }

    struct Hash128 : System.IComparable, System.IComparable<UnityEngine.Hash128>, System.IEquatable<UnityEngine.Hash128>
    {
        static ulong kConst = 16045690984833335023;
        /*0x10*/ ulong u64_0;
        /*0x18*/ ulong u64_1;

        static /*0x15e4220*/ UnityEngine.Hash128 Parse(string hashString);
        static /*0x15e4190*/ string Hash128ToStringImpl(UnityEngine.Hash128 hash);
        static /*0x15e42e0*/ bool op_Equality(UnityEngine.Hash128 hash1, UnityEngine.Hash128 hash2);
        static /*0x15e4330*/ bool op_LessThan(UnityEngine.Hash128 x, UnityEngine.Hash128 y);
        static /*0x15e4300*/ bool op_GreaterThan(UnityEngine.Hash128 x, UnityEngine.Hash128 y);
        static /*0x15e41d0*/ void Parse_Injected(string hashString, ref UnityEngine.Hash128 ret);
        static /*0x15e4150*/ string Hash128ToStringImpl_Injected(ref UnityEngine.Hash128 hash);
        /*0x15e42b0*/ Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3);
        /*0xbee490*/ Hash128(ulong u64_0, ulong u64_1);
        /*0x15e3ff0*/ int CompareTo(UnityEngine.Hash128 rhs);
        /*0x15e4270*/ string ToString();
        /*0x15e4040*/ bool Equals(object obj);
        /*0x15e40f0*/ bool Equals(UnityEngine.Hash128 obj);
        /*0x15e4120*/ int GetHashCode();
        /*0x15e3f10*/ int CompareTo(object obj);
    }

    class HashUtilities
    {
        static /*0x15e43c0*/ void AppendHash(ref UnityEngine.Hash128 inHash, ref UnityEngine.Hash128 outHash);
    }

    class HashUnsafeUtilities
    {
        static /*0x15e43b0*/ void ComputeHash128(void* data, ulong dataSize, ulong* hash1, ulong* hash2);
        static /*0x15e4350*/ void ComputeHash128(void* data, ulong dataSize, UnityEngine.Hash128* hash);
    }

    class SpookyHash
    {
        static /*0x15ebe80*/ void Hash(void* message, ulong length, ulong* hash1, ulong* hash2);
        static /*0x15ebc90*/ void End(ulong* data, ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11);
        static /*0x15ebac0*/ void EndPartial(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11);
        static /*0x15ec7f0*/ void Rot64(ref ulong x, int k);
        static /*0x15ecad0*/ void Short(void* message, ulong length, ulong* hash1, ulong* hash2);
        static /*0x15ec960*/ void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3);
        static /*0x15ec810*/ void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3);
        static /*0x15ec570*/ void Mix(ulong* data, ref ulong s0, ref ulong s1, ref ulong s2, ref ulong s3, ref ulong s4, ref ulong s5, ref ulong s6, ref ulong s7, ref ulong s8, ref ulong s9, ref ulong s10, ref ulong s11);

        struct U
        {
            /*0x10*/ byte* p8;
            /*0x10*/ uint* p32;
            /*0x10*/ ulong* p64;
            /*0x10*/ ulong i;

            /*0x9e29e0*/ U(ushort* p8);
        }
    }

    enum CursorMode
    {
        Auto = 0,
        ForceSoftware = 1,
    }

    enum CursorLockMode
    {
        None = 0,
        Locked = 1,
        Confined = 2,
    }

    class Cursor
    {
        static /*0x15e1aa0*/ void SetCursor(UnityEngine.Texture2D texture, UnityEngine.Vector2 hotspot, UnityEngine.CursorMode cursorMode);
        static /*0x15e1af0*/ UnityEngine.CursorLockMode get_lockState();
        static /*0x15e1a40*/ void SetCursor_Injected(UnityEngine.Texture2D texture, ref UnityEngine.Vector2 hotspot, UnityEngine.CursorMode cursorMode);
    }

    enum KeyCode
    {
        None = 0,
        Backspace = 8,
        Delete = 127,
        Tab = 9,
        Clear = 12,
        Return = 13,
        Pause = 19,
        Escape = 27,
        Space = 32,
        Keypad0 = 256,
        Keypad1 = 257,
        Keypad2 = 258,
        Keypad3 = 259,
        Keypad4 = 260,
        Keypad5 = 261,
        Keypad6 = 262,
        Keypad7 = 263,
        Keypad8 = 264,
        Keypad9 = 265,
        KeypadPeriod = 266,
        KeypadDivide = 267,
        KeypadMultiply = 268,
        KeypadMinus = 269,
        KeypadPlus = 270,
        KeypadEnter = 271,
        KeypadEquals = 272,
        UpArrow = 273,
        DownArrow = 274,
        RightArrow = 275,
        LeftArrow = 276,
        Insert = 277,
        Home = 278,
        End = 279,
        PageUp = 280,
        PageDown = 281,
        F1 = 282,
        F2 = 283,
        F3 = 284,
        F4 = 285,
        F5 = 286,
        F6 = 287,
        F7 = 288,
        F8 = 289,
        F9 = 290,
        F10 = 291,
        F11 = 292,
        F12 = 293,
        F13 = 294,
        F14 = 295,
        F15 = 296,
        Alpha0 = 48,
        Alpha1 = 49,
        Alpha2 = 50,
        Alpha3 = 51,
        Alpha4 = 52,
        Alpha5 = 53,
        Alpha6 = 54,
        Alpha7 = 55,
        Alpha8 = 56,
        Alpha9 = 57,
        Exclaim = 33,
        DoubleQuote = 34,
        Hash = 35,
        Dollar = 36,
        Percent = 37,
        Ampersand = 38,
        Quote = 39,
        LeftParen = 40,
        RightParen = 41,
        Asterisk = 42,
        Plus = 43,
        Comma = 44,
        Minus = 45,
        Period = 46,
        Slash = 47,
        Colon = 58,
        Semicolon = 59,
        Less = 60,
        Equals = 61,
        Greater = 62,
        Question = 63,
        At = 64,
        LeftBracket = 91,
        Backslash = 92,
        RightBracket = 93,
        Caret = 94,
        Underscore = 95,
        BackQuote = 96,
        A = 97,
        B = 98,
        C = 99,
        D = 100,
        E = 101,
        F = 102,
        G = 103,
        H = 104,
        I = 105,
        J = 106,
        K = 107,
        L = 108,
        M = 109,
        N = 110,
        O = 111,
        P = 112,
        Q = 113,
        R = 114,
        S = 115,
        T = 116,
        U = 117,
        V = 118,
        W = 119,
        X = 120,
        Y = 121,
        Z = 122,
        LeftCurlyBracket = 123,
        Pipe = 124,
        RightCurlyBracket = 125,
        Tilde = 126,
        Numlock = 300,
        CapsLock = 301,
        ScrollLock = 302,
        RightShift = 303,
        LeftShift = 304,
        RightControl = 305,
        LeftControl = 306,
        RightAlt = 307,
        LeftAlt = 308,
        LeftMeta = 310,
        LeftCommand = 310,
        LeftApple = 310,
        LeftWindows = 311,
        RightMeta = 309,
        RightCommand = 309,
        RightApple = 309,
        RightWindows = 312,
        AltGr = 313,
        Help = 315,
        Print = 316,
        SysReq = 317,
        Break = 318,
        Menu = 319,
        F16 = 670,
        F17 = 671,
        F18 = 672,
        F19 = 673,
        F20 = 674,
        F21 = 675,
        F22 = 676,
        F23 = 677,
        F24 = 678,
        Mouse0 = 323,
        Mouse1 = 324,
        Mouse2 = 325,
        Mouse3 = 326,
        Mouse4 = 327,
        Mouse5 = 328,
        Mouse6 = 329,
        JoystickButton0 = 330,
        JoystickButton1 = 331,
        JoystickButton2 = 332,
        JoystickButton3 = 333,
        JoystickButton4 = 334,
        JoystickButton5 = 335,
        JoystickButton6 = 336,
        JoystickButton7 = 337,
        JoystickButton8 = 338,
        JoystickButton9 = 339,
        JoystickButton10 = 340,
        JoystickButton11 = 341,
        JoystickButton12 = 342,
        JoystickButton13 = 343,
        JoystickButton14 = 344,
        JoystickButton15 = 345,
        JoystickButton16 = 346,
        JoystickButton17 = 347,
        JoystickButton18 = 348,
        JoystickButton19 = 349,
        Joystick1Button0 = 350,
        Joystick1Button1 = 351,
        Joystick1Button2 = 352,
        Joystick1Button3 = 353,
        Joystick1Button4 = 354,
        Joystick1Button5 = 355,
        Joystick1Button6 = 356,
        Joystick1Button7 = 357,
        Joystick1Button8 = 358,
        Joystick1Button9 = 359,
        Joystick1Button10 = 360,
        Joystick1Button11 = 361,
        Joystick1Button12 = 362,
        Joystick1Button13 = 363,
        Joystick1Button14 = 364,
        Joystick1Button15 = 365,
        Joystick1Button16 = 366,
        Joystick1Button17 = 367,
        Joystick1Button18 = 368,
        Joystick1Button19 = 369,
        Joystick2Button0 = 370,
        Joystick2Button1 = 371,
        Joystick2Button2 = 372,
        Joystick2Button3 = 373,
        Joystick2Button4 = 374,
        Joystick2Button5 = 375,
        Joystick2Button6 = 376,
        Joystick2Button7 = 377,
        Joystick2Button8 = 378,
        Joystick2Button9 = 379,
        Joystick2Button10 = 380,
        Joystick2Button11 = 381,
        Joystick2Button12 = 382,
        Joystick2Button13 = 383,
        Joystick2Button14 = 384,
        Joystick2Button15 = 385,
        Joystick2Button16 = 386,
        Joystick2Button17 = 387,
        Joystick2Button18 = 388,
        Joystick2Button19 = 389,
        Joystick3Button0 = 390,
        Joystick3Button1 = 391,
        Joystick3Button2 = 392,
        Joystick3Button3 = 393,
        Joystick3Button4 = 394,
        Joystick3Button5 = 395,
        Joystick3Button6 = 396,
        Joystick3Button7 = 397,
        Joystick3Button8 = 398,
        Joystick3Button9 = 399,
        Joystick3Button10 = 400,
        Joystick3Button11 = 401,
        Joystick3Button12 = 402,
        Joystick3Button13 = 403,
        Joystick3Button14 = 404,
        Joystick3Button15 = 405,
        Joystick3Button16 = 406,
        Joystick3Button17 = 407,
        Joystick3Button18 = 408,
        Joystick3Button19 = 409,
        Joystick4Button0 = 410,
        Joystick4Button1 = 411,
        Joystick4Button2 = 412,
        Joystick4Button3 = 413,
        Joystick4Button4 = 414,
        Joystick4Button5 = 415,
        Joystick4Button6 = 416,
        Joystick4Button7 = 417,
        Joystick4Button8 = 418,
        Joystick4Button9 = 419,
        Joystick4Button10 = 420,
        Joystick4Button11 = 421,
        Joystick4Button12 = 422,
        Joystick4Button13 = 423,
        Joystick4Button14 = 424,
        Joystick4Button15 = 425,
        Joystick4Button16 = 426,
        Joystick4Button17 = 427,
        Joystick4Button18 = 428,
        Joystick4Button19 = 429,
        Joystick5Button0 = 430,
        Joystick5Button1 = 431,
        Joystick5Button2 = 432,
        Joystick5Button3 = 433,
        Joystick5Button4 = 434,
        Joystick5Button5 = 435,
        Joystick5Button6 = 436,
        Joystick5Button7 = 437,
        Joystick5Button8 = 438,
        Joystick5Button9 = 439,
        Joystick5Button10 = 440,
        Joystick5Button11 = 441,
        Joystick5Button12 = 442,
        Joystick5Button13 = 443,
        Joystick5Button14 = 444,
        Joystick5Button15 = 445,
        Joystick5Button16 = 446,
        Joystick5Button17 = 447,
        Joystick5Button18 = 448,
        Joystick5Button19 = 449,
        Joystick6Button0 = 450,
        Joystick6Button1 = 451,
        Joystick6Button2 = 452,
        Joystick6Button3 = 453,
        Joystick6Button4 = 454,
        Joystick6Button5 = 455,
        Joystick6Button6 = 456,
        Joystick6Button7 = 457,
        Joystick6Button8 = 458,
        Joystick6Button9 = 459,
        Joystick6Button10 = 460,
        Joystick6Button11 = 461,
        Joystick6Button12 = 462,
        Joystick6Button13 = 463,
        Joystick6Button14 = 464,
        Joystick6Button15 = 465,
        Joystick6Button16 = 466,
        Joystick6Button17 = 467,
        Joystick6Button18 = 468,
        Joystick6Button19 = 469,
        Joystick7Button0 = 470,
        Joystick7Button1 = 471,
        Joystick7Button2 = 472,
        Joystick7Button3 = 473,
        Joystick7Button4 = 474,
        Joystick7Button5 = 475,
        Joystick7Button6 = 476,
        Joystick7Button7 = 477,
        Joystick7Button8 = 478,
        Joystick7Button9 = 479,
        Joystick7Button10 = 480,
        Joystick7Button11 = 481,
        Joystick7Button12 = 482,
        Joystick7Button13 = 483,
        Joystick7Button14 = 484,
        Joystick7Button15 = 485,
        Joystick7Button16 = 486,
        Joystick7Button17 = 487,
        Joystick7Button18 = 488,
        Joystick7Button19 = 489,
        Joystick8Button0 = 490,
        Joystick8Button1 = 491,
        Joystick8Button2 = 492,
        Joystick8Button3 = 493,
        Joystick8Button4 = 494,
        Joystick8Button5 = 495,
        Joystick8Button6 = 496,
        Joystick8Button7 = 497,
        Joystick8Button8 = 498,
        Joystick8Button9 = 499,
        Joystick8Button10 = 500,
        Joystick8Button11 = 501,
        Joystick8Button12 = 502,
        Joystick8Button13 = 503,
        Joystick8Button14 = 504,
        Joystick8Button15 = 505,
        Joystick8Button16 = 506,
        Joystick8Button17 = 507,
        Joystick8Button18 = 508,
        Joystick8Button19 = 509,
    }

    interface ILogger : UnityEngine.ILogHandler
    {
        /*0x1803b0*/ UnityEngine.ILogHandler get_logHandler();
        /*0x17cb40*/ bool get_logEnabled();
        /*0x17bfd0*/ bool IsLogTypeAllowed(UnityEngine.LogType logType);
        void Log(UnityEngine.LogType logType, object message);
        void Log(UnityEngine.LogType logType, object message, UnityEngine.Object context);
        /*0x183150*/ void LogError(string tag, object message);
        void LogFormat(UnityEngine.LogType logType, string format, object[] args);
    }

    interface ILogHandler
    {
        void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
        /*0x183150*/ void LogException(System.Exception exception, UnityEngine.Object context);
    }

    class Logger : UnityEngine.ILogger, UnityEngine.ILogHandler
    {
        /*0x10*/ UnityEngine.ILogHandler <logHandler>k__BackingField;
        /*0x18*/ bool <logEnabled>k__BackingField;
        /*0x1c*/ UnityEngine.LogType <filterLogType>k__BackingField;

        static /*0x15e44a0*/ string GetString(object message);
        /*0x15e4c00*/ Logger(UnityEngine.ILogHandler logHandler);
        /*0x73d3e0*/ UnityEngine.ILogHandler get_logHandler();
        /*0x9f12f0*/ void set_logHandler(UnityEngine.ILogHandler value);
        /*0xdd36a0*/ bool get_logEnabled();
        /*0xdd5230*/ void set_logEnabled(bool value);
        /*0xc70b00*/ UnityEngine.LogType get_filterLogType();
        /*0xc70b50*/ void set_filterLogType(UnityEngine.LogType value);
        /*0x15e45d0*/ bool IsLogTypeAllowed(UnityEngine.LogType logType);
        /*0x15e4990*/ void Log(UnityEngine.LogType logType, object message);
        /*0x15e4ac0*/ void Log(UnityEngine.LogType logType, object message, UnityEngine.Object context);
        /*0x15e45f0*/ void LogError(string tag, object message);
        /*0x15e4770*/ void LogException(System.Exception exception, UnityEngine.Object context);
        /*0x15e4850*/ void LogFormat(UnityEngine.LogType logType, string format, object[] args);
        /*0x15e48f0*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
    }

    class UnityLogWriter : System.IO.TextWriter
    {
        static /*0x15ed680*/ void WriteStringToUnityLog(string s);
        static /*0x15ed640*/ void WriteStringToUnityLogImpl(string s);
        static /*0x15e0360*/ void Init();
        /*0x15ed7d0*/ UnityLogWriter();
        /*0x15ed700*/ void Write(char value);
        /*0x15ed6c0*/ void Write(string s);
        /*0x15ed780*/ void Write(char[] buffer, int index, int count);
    }

    struct Color : System.IEquatable<UnityEngine.Color>, System.IFormattable
    {
        /*0x10*/ float r;
        /*0x14*/ float g;
        /*0x18*/ float b;
        /*0x1c*/ float a;

        static /*0x15e0f70*/ UnityEngine.Color op_Addition(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x15e11d0*/ UnityEngine.Color op_Subtraction(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x15e1170*/ UnityEngine.Color op_Multiply(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x15e10d0*/ UnityEngine.Color op_Multiply(UnityEngine.Color a, float b);
        static /*0x15e1120*/ UnityEngine.Color op_Multiply(float b, UnityEngine.Color a);
        static /*0x15e0fd0*/ bool op_Equality(UnityEngine.Color lhs, UnityEngine.Color rhs);
        static /*0x15e1060*/ bool op_Inequality(UnityEngine.Color lhs, UnityEngine.Color rhs);
        static /*0x15e0940*/ UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, float t);
        static /*0x15e08c0*/ UnityEngine.Color LerpUnclamped(UnityEngine.Color a, UnityEngine.Color b, float t);
        static /*0x15e0f40*/ UnityEngine.Color get_red();
        static /*0x15e0e10*/ UnityEngine.Color get_green();
        static /*0x15e0cf0*/ UnityEngine.Color get_blue();
        static /*0x15e0f50*/ UnityEngine.Color get_white();
        static /*0x15e0ce0*/ UnityEngine.Color get_black();
        static /*0x15e0f60*/ UnityEngine.Color get_yellow();
        static /*0x15e0d00*/ UnityEngine.Color get_cyan();
        static /*0x15e0f10*/ UnityEngine.Color get_magenta();
        static /*0x15e0e00*/ UnityEngine.Color get_gray();
        static /*0x15e0e00*/ UnityEngine.Color get_grey();
        static /*0xbf9930*/ UnityEngine.Color get_clear();
        static /*0x15e1040*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Color c);
        static /*0x15e1040*/ UnityEngine.Color op_Implicit(UnityEngine.Vector4 v);
        /*0x11534a0*/ Color(float r, float g, float b, float a);
        /*0x15e0cc0*/ Color(float r, float g, float b);
        /*0x15e0a30*/ string ToString();
        /*0x15e0a40*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x65bf10*/ int GetHashCode();
        /*0x15e0740*/ bool Equals(object other);
        /*0x15e0840*/ bool Equals(UnityEngine.Color other);
        /*0x15e09e0*/ UnityEngine.Color RGBMultiplied(float multiplier);
        /*0x15e0e20*/ UnityEngine.Color get_linear();
        /*0x15e0d10*/ UnityEngine.Color get_gamma();
        /*0x15e0f20*/ float get_maxColorComponent();
    }

    struct Color32 : System.IFormattable
    {
        /*0x10*/ int rgba;
        /*0x10*/ byte r;
        /*0x11*/ byte g;
        /*0x12*/ byte b;
        /*0x13*/ byte a;

        static /*0x14267b0*/ UnityEngine.Color32 op_Implicit(UnityEngine.Color c);
        static /*0x15e0670*/ UnityEngine.Color op_Implicit(UnityEngine.Color32 c);
        /*0x1121b30*/ Color32(byte r, byte g, byte b, byte a);
        /*0x15e0660*/ string ToString();
        /*0x15e0400*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct GradientColorKey
    {
        /*0x10*/ UnityEngine.Color color;
        /*0x20*/ float time;

        /*0x15e3870*/ GradientColorKey(UnityEngine.Color col, float time);
    }

    struct GradientAlphaKey
    {
        /*0x10*/ float alpha;
        /*0x14*/ float time;

        /*0x99b700*/ GradientAlphaKey(float alpha, float time);
    }

    enum GradientMode
    {
        Blend = 0,
        Fixed = 1,
        PerceptualBlend = 2,
    }

    class Gradient : System.IEquatable<UnityEngine.Gradient>
    {
        /*0x10*/ nint m_Ptr;

        static /*0x15e3c50*/ nint Init();
        /*0x15e3d30*/ Gradient();
        /*0x15e3880*/ void Cleanup();
        /*0x15e3c80*/ bool Internal_Equals(nint other);
        /*0x15e3bc0*/ void Finalize();
        /*0x15e3b60*/ UnityEngine.Color Evaluate(float time);
        /*0x15e3db0*/ UnityEngine.GradientColorKey[] get_colorKeys();
        /*0x15e3e80*/ void set_colorKeys(UnityEngine.GradientColorKey[] value);
        /*0x15e3d70*/ UnityEngine.GradientAlphaKey[] get_alphaKeys();
        /*0x15e3e30*/ void set_alphaKeys(UnityEngine.GradientAlphaKey[] value);
        /*0x15e3df0*/ UnityEngine.GradientMode get_mode();
        /*0x15e3ed0*/ void set_mode(UnityEngine.GradientMode value);
        /*0x15e3cd0*/ void SetKeys(UnityEngine.GradientColorKey[] colorKeys, UnityEngine.GradientAlphaKey[] alphaKeys);
        /*0x15e38c0*/ bool Equals(object o);
        /*0x15e3a40*/ bool Equals(UnityEngine.Gradient other);
        /*0x15e3c40*/ int GetHashCode();
        /*0x15e3b00*/ void Evaluate_Injected(float time, ref UnityEngine.Color ret);
    }

    struct FrustumPlanes
    {
        /*0x10*/ float left;
        /*0x14*/ float right;
        /*0x18*/ float bottom;
        /*0x1c*/ float top;
        /*0x20*/ float zNear;
        /*0x24*/ float zFar;
    }

    struct Matrix4x4 : System.IEquatable<UnityEngine.Matrix4x4>, System.IFormattable
    {
        static /*0x0*/ UnityEngine.Matrix4x4 zeroMatrix;
        static /*0x40*/ UnityEngine.Matrix4x4 identityMatrix;
        /*0x10*/ float m00;
        /*0x14*/ float m10;
        /*0x18*/ float m20;
        /*0x1c*/ float m30;
        /*0x20*/ float m01;
        /*0x24*/ float m11;
        /*0x28*/ float m21;
        /*0x2c*/ float m31;
        /*0x30*/ float m02;
        /*0x34*/ float m12;
        /*0x38*/ float m22;
        /*0x3c*/ float m32;
        /*0x40*/ float m03;
        /*0x44*/ float m13;
        /*0x48*/ float m23;
        /*0x4c*/ float m33;

        static /*0x15e7980*/ Matrix4x4();
        static /*0x15e70b0*/ UnityEngine.Matrix4x4 TRS(UnityEngine.Vector3 pos, UnityEngine.Quaternion q, UnityEngine.Vector3 s);
        static /*0x15e6710*/ bool Inverse3DAffine(UnityEngine.Matrix4x4 input, ref UnityEngine.Matrix4x4 result);
        static /*0x15e67b0*/ UnityEngine.Matrix4x4 Inverse(UnityEngine.Matrix4x4 m);
        static /*0x15e7920*/ UnityEngine.Matrix4x4 Transpose(UnityEngine.Matrix4x4 m);
        static /*0x15e6bb0*/ UnityEngine.Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar);
        static /*0x15e6ce0*/ UnityEngine.Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar);
        static /*0x15e6880*/ UnityEngine.Matrix4x4 LookAt(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 up);
        static /*0x15e6200*/ UnityEngine.Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar);
        static /*0x15e60d0*/ UnityEngine.Matrix4x4 Frustum(UnityEngine.FrustumPlanes fp);
        static /*0x15e80e0*/ UnityEngine.Matrix4x4 op_Multiply(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs);
        static /*0x15e7fc0*/ UnityEngine.Vector4 op_Multiply(UnityEngine.Matrix4x4 lhs, UnityEngine.Vector4 vector);
        static /*0x15e7e10*/ bool op_Equality(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs);
        static /*0x15e7f50*/ bool op_Inequality(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs);
        static /*0x15e6f20*/ UnityEngine.Matrix4x4 Scale(UnityEngine.Vector3 vector);
        static /*0x15e7830*/ UnityEngine.Matrix4x4 Translate(UnityEngine.Vector3 vector);
        static /*0x15e6d70*/ UnityEngine.Matrix4x4 Rotate(UnityEngine.Quaternion q);
        static /*0x15e7db0*/ UnityEngine.Matrix4x4 get_zero();
        static /*0x15e7b80*/ UnityEngine.Matrix4x4 get_identity();
        static /*0x15e6530*/ void GetLossyScale_Injected(ref UnityEngine.Matrix4x4 _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x15e5de0*/ void DecomposeProjection_Injected(ref UnityEngine.Matrix4x4 _unity_self, ref UnityEngine.FrustumPlanes ret);
        static /*0x15e7040*/ void TRS_Injected(ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion q, ref UnityEngine.Vector3 s, ref UnityEngine.Matrix4x4 ret);
        static /*0x15e66c0*/ bool Inverse3DAffine_Injected(ref UnityEngine.Matrix4x4 input, ref UnityEngine.Matrix4x4 result);
        static /*0x15e6760*/ void Inverse_Injected(ref UnityEngine.Matrix4x4 m, ref UnityEngine.Matrix4x4 ret);
        static /*0x15e78d0*/ void Transpose_Injected(ref UnityEngine.Matrix4x4 m, ref UnityEngine.Matrix4x4 ret);
        static /*0x15e6b30*/ void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, ref UnityEngine.Matrix4x4 ret);
        static /*0x15e6c60*/ void Perspective_Injected(float fov, float aspect, float zNear, float zFar, ref UnityEngine.Matrix4x4 ret);
        static /*0x15e6810*/ void LookAt_Injected(ref UnityEngine.Vector3 from, ref UnityEngine.Vector3 to, ref UnityEngine.Vector3 up, ref UnityEngine.Matrix4x4 ret);
        static /*0x15e6050*/ void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, ref UnityEngine.Matrix4x4 ret);
        /*0x15e7aa0*/ Matrix4x4(UnityEngine.Vector4 column0, UnityEngine.Vector4 column1, UnityEngine.Vector4 column2, UnityEngine.Vector4 column3);
        /*0x15e6580*/ UnityEngine.Vector3 GetLossyScale();
        /*0x15e5e30*/ UnityEngine.FrustumPlanes DecomposeProjection();
        /*0x15e7c90*/ UnityEngine.Vector3 get_lossyScale();
        /*0x15e7b10*/ UnityEngine.FrustumPlanes get_decomposeProjection();
        /*0x15e7be0*/ UnityEngine.Matrix4x4 get_inverse();
        /*0x15e7d00*/ UnityEngine.Matrix4x4 get_transpose();
        /*0x15e8780*/ void set_Item(int row, int column, float value);
        /*0x15e8620*/ void set_Item(int index, float value);
        /*0x15e6380*/ int GetHashCode();
        /*0x15e5e90*/ bool Equals(object other);
        /*0x15e5f40*/ bool Equals(UnityEngine.Matrix4x4 other);
        /*0x15e62b0*/ UnityEngine.Vector4 GetColumn(int index);
        /*0x15e65d0*/ UnityEngine.Vector4 GetRow(int index);
        /*0x15e6fc0*/ void SetColumn(int index, UnityEngine.Vector4 column);
        /*0x15e69a0*/ UnityEngine.Vector3 MultiplyPoint(UnityEngine.Vector3 point);
        /*0x15e6900*/ UnityEngine.Vector3 MultiplyPoint3x4(UnityEngine.Vector3 point);
        /*0x15e6aa0*/ UnityEngine.Vector3 MultiplyVector(UnityEngine.Vector3 vector);
        /*0x15e7130*/ string ToString();
        /*0x15e7140*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Vector3 : System.IEquatable<UnityEngine.Vector3>, System.IFormattable
    {
        static float kEpsilon = 0.000009999999747378752;
        static float kEpsilonNormalSqrt = 1.0000000036274937e-15;
        static /*0x0*/ UnityEngine.Vector3 zeroVector;
        static /*0xc*/ UnityEngine.Vector3 oneVector;
        static /*0x18*/ UnityEngine.Vector3 upVector;
        static /*0x24*/ UnityEngine.Vector3 downVector;
        static /*0x30*/ UnityEngine.Vector3 leftVector;
        static /*0x3c*/ UnityEngine.Vector3 rightVector;
        static /*0x48*/ UnityEngine.Vector3 forwardVector;
        static /*0x54*/ UnityEngine.Vector3 backVector;
        static /*0x60*/ UnityEngine.Vector3 positiveInfinityVector;
        static /*0x6c*/ UnityEngine.Vector3 negativeInfinityVector;
        /*0x10*/ float x;
        /*0x14*/ float y;
        /*0x18*/ float z;

        static /*0x15efd60*/ Vector3();
        static /*0x15ef4e0*/ UnityEngine.Vector3 Lerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, float t);
        static /*0x15ef490*/ UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3 a, UnityEngine.Vector3 b, float t);
        static /*0x15ef680*/ UnityEngine.Vector3 MoveTowards(UnityEngine.Vector3 current, UnityEngine.Vector3 target, float maxDistanceDelta);
        static /*0x15ef220*/ UnityEngine.Vector3 Cross(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x348010*/ UnityEngine.Vector3 Normalize(UnityEngine.Vector3 value);
        static /*0x15ef350*/ float Dot(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x15ef900*/ UnityEngine.Vector3 ProjectOnPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal);
        static /*0x15ef0b0*/ float Angle(UnityEngine.Vector3 from, UnityEngine.Vector3 to);
        static /*0x15efa20*/ float SignedAngle(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 axis);
        static /*0x15ef280*/ float Distance(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x15ef550*/ float Magnitude(UnityEngine.Vector3 vector);
        static /*0x15efb00*/ float SqrMagnitude(UnityEngine.Vector3 vector);
        static /*0x15ef640*/ UnityEngine.Vector3 Min(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x15ef600*/ UnityEngine.Vector3 Max(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x15f0270*/ UnityEngine.Vector3 get_zero();
        static /*0x15f0180*/ UnityEngine.Vector3 get_one();
        static /*0x15effa0*/ UnityEngine.Vector3 get_forward();
        static /*0x15eff00*/ UnityEngine.Vector3 get_back();
        static /*0x15f0220*/ UnityEngine.Vector3 get_up();
        static /*0x15eff50*/ UnityEngine.Vector3 get_down();
        static /*0x15efff0*/ UnityEngine.Vector3 get_left();
        static /*0x15f01d0*/ UnityEngine.Vector3 get_right();
        static /*0x317140*/ UnityEngine.Vector3 op_Addition(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x348280*/ UnityEngine.Vector3 op_Subtraction(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x15f03c0*/ UnityEngine.Vector3 op_UnaryNegation(UnityEngine.Vector3 a);
        static /*0x15f0390*/ UnityEngine.Vector3 op_Multiply(UnityEngine.Vector3 a, float d);
        static /*0x15f0360*/ UnityEngine.Vector3 op_Multiply(float d, UnityEngine.Vector3 a);
        static /*0x348250*/ UnityEngine.Vector3 op_Division(UnityEngine.Vector3 a, float d);
        static /*0x15f02c0*/ bool op_Equality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x15f0300*/ bool op_Inequality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        /*0x1237080*/ Vector3(float x, float y, float z);
        /*0x15efee0*/ Vector3(float x, float y);
        /*0x1453c50*/ float get_Item(int index);
        /*0x15f03f0*/ void set_Item(int index, float value);
        /*0x15ef430*/ int GetHashCode();
        /*0x15ef380*/ bool Equals(object other);
        /*0x1236c60*/ bool Equals(UnityEngine.Vector3 other);
        /*0x15ef7f0*/ void Normalize();
        /*0x15f0130*/ UnityEngine.Vector3 get_normalized();
        /*0x15f0040*/ float get_magnitude();
        /*0x15efb00*/ float get_sqrMagnitude();
        /*0x15efb30*/ string ToString();
        /*0x15efb40*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Quaternion : System.IEquatable<UnityEngine.Quaternion>, System.IFormattable
    {
        static float kEpsilon = 9.999999974752427e-7;
        static /*0x0*/ UnityEngine.Quaternion identityQuaternion;
        /*0x10*/ float x;
        /*0x14*/ float y;
        /*0x18*/ float z;
        /*0x1c*/ float w;

        static /*0x15ea190*/ Quaternion();
        static /*0x15e9c40*/ UnityEngine.Quaternion Inverse(UnityEngine.Quaternion rotation);
        static /*0x15e9e90*/ UnityEngine.Quaternion Slerp(UnityEngine.Quaternion a, UnityEngine.Quaternion b, float t);
        static /*0x15e9a70*/ UnityEngine.Quaternion Internal_FromEulerRad(UnityEngine.Vector3 euler);
        static /*0x15e9ba0*/ UnityEngine.Vector3 Internal_ToEulerRad(UnityEngine.Quaternion rotation);
        static /*0x15e9770*/ UnityEngine.Quaternion AngleAxis(float angle, UnityEngine.Vector3 axis);
        static /*0x15e9dc0*/ UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 forward, UnityEngine.Vector3 upwards);
        static /*0x15e9d00*/ UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 forward);
        static /*0x15ea2e0*/ UnityEngine.Quaternion get_identity();
        static /*0x15ea3f0*/ UnityEngine.Quaternion op_Multiply(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x15ea500*/ UnityEngine.Vector3 op_Multiply(UnityEngine.Quaternion rotation, UnityEngine.Vector3 point);
        static /*0x15e9c90*/ bool IsEqualUsingDot(float dot);
        static /*0x15ea330*/ bool op_Equality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x15ea390*/ bool op_Inequality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x15e97d0*/ float Dot(UnityEngine.Quaternion a, UnityEngine.Quaternion b);
        static /*0x15e9ac0*/ UnityEngine.Vector3 Internal_MakePositive(UnityEngine.Vector3 euler);
        static /*0x15e99a0*/ UnityEngine.Quaternion Euler(float x, float y, float z);
        static /*0x15e9910*/ UnityEngine.Quaternion Euler(UnityEngine.Vector3 euler);
        static /*0x15e9bf0*/ void Inverse_Injected(ref UnityEngine.Quaternion rotation, ref UnityEngine.Quaternion ret);
        static /*0x15e9e20*/ void Slerp_Injected(ref UnityEngine.Quaternion a, ref UnityEngine.Quaternion b, float t, ref UnityEngine.Quaternion ret);
        static /*0x15e9a20*/ void Internal_FromEulerRad_Injected(ref UnityEngine.Vector3 euler, ref UnityEngine.Quaternion ret);
        static /*0x15e9b50*/ void Internal_ToEulerRad_Injected(ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 ret);
        static /*0x15e9710*/ void AngleAxis_Injected(float angle, ref UnityEngine.Vector3 axis, ref UnityEngine.Quaternion ret);
        static /*0x15e9ca0*/ void LookRotation_Injected(ref UnityEngine.Vector3 forward, ref UnityEngine.Vector3 upwards, ref UnityEngine.Quaternion ret);
        /*0x11534a0*/ Quaternion(float x, float y, float z, float w);
        /*0x15ea1d0*/ UnityEngine.Vector3 get_eulerAngles();
        /*0x65c140*/ int GetHashCode();
        /*0x15e9810*/ bool Equals(object other);
        /*0x15e0840*/ bool Equals(UnityEngine.Quaternion other);
        /*0x15ea180*/ string ToString();
        /*0x15e9f00*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Mathf
    {
        static /*0x0*/ float Epsilon;

        static /*0x15e5d20*/ Mathf();
        static /*0x15e54b0*/ bool IsPowerOfTwo(int value);
        static /*0x15e56e0*/ int NextPowerOfTwo(int value);
        static /*0x15e53b0*/ float GammaToLinearSpace(float value);
        static /*0x15e5550*/ float LinearToGammaSpace(float value);
        static /*0x15e50c0*/ UnityEngine.Color CorrelatedColorTemperatureToRGB(float kelvin);
        static /*0x15e52b0*/ ushort FloatToHalf(float val);
        static /*0x15e5720*/ float PerlinNoise(float x, float y);
        static /*0x15e5aa0*/ float Sin(float f);
        static /*0x15e5110*/ float Cos(float f);
        static /*0x15e5cc0*/ float Tan(float f);
        static /*0x15e4cf0*/ float Acos(float f);
        static /*0x15e4e50*/ float Atan(float f);
        static /*0x15e4de0*/ float Atan2(float y, float x);
        static /*0x15e5c40*/ float Sqrt(float f);
        static /*0x15e4c40*/ float Abs(float f);
        static /*0x15e4ca0*/ int Abs(int value);
        static /*0x15e56d0*/ float Min(float a, float b);
        static /*0x3306a0*/ int Min(int a, int b);
        static /*0x15e56c0*/ float Max(float a, float b);
        static /*0x13c0940*/ int Max(int a, int b);
        static /*0x15e57f0*/ float Pow(float f, float p);
        static /*0x15e5250*/ float Exp(float power);
        static /*0x15e55f0*/ float Log(float f, float p);
        static /*0x15e5660*/ float Log(float f);
        static /*0x15e5590*/ float Log10(float f);
        static /*0x15e4f10*/ float Ceil(float f);
        static /*0x15e5350*/ float Floor(float f);
        static /*0x15e5a20*/ float Round(float f);
        static /*0x15e4eb0*/ int CeilToInt(float f);
        static /*0x15e52f0*/ int FloorToInt(float f);
        static /*0x15e59c0*/ int RoundToInt(float f);
        static /*0x15e5a80*/ float Sign(float f);
        static /*0x15e5050*/ float Clamp(float value, float min, float max);
        static /*0x15e5030*/ int Clamp(int value, int min, int max);
        static /*0x15e4f70*/ float Clamp01(float value);
        static /*0x15e5510*/ float Lerp(float a, float b, float t);
        static /*0x15e54f0*/ float LerpUnclamped(float a, float b, float t);
        static /*0x15e4d50*/ bool Approximately(float a, float b);
        static /*0x15e5b00*/ float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime);
        static /*0x15e5860*/ float Repeat(float t, float length);
        static /*0x15e5770*/ float PingPong(float t, float length);
        static /*0x15e5470*/ float InverseLerp(float a, float b, float value);
        static /*0x15e4f90*/ float ClampToFloat(double value);
        static /*0x15e4ff0*/ int ClampToInt(long value);
        static /*0x15e5010*/ uint ClampToUInt(long value);
        static /*0x15e53f0*/ int GetNumberOfDecimalsForMinimumDifference(double minDifference);
        static /*0x15e58c0*/ double RoundBasedOnMinimumDifference(double valueToRound, double minDifference);
        static /*0x15e5170*/ double DiscardLeastSignificantDecimal(double v);
        static /*0x15e5070*/ void CorrelatedColorTemperatureToRGB_Injected(float kelvin, ref UnityEngine.Color ret);
    }

    struct Vector2 : System.IEquatable<UnityEngine.Vector2>, System.IFormattable
    {
        static float kEpsilon = 0.000009999999747378752;
        static float kEpsilonNormalSqrt = 1.0000000036274937e-15;
        static /*0x0*/ UnityEngine.Vector2 zeroVector;
        static /*0x8*/ UnityEngine.Vector2 oneVector;
        static /*0x10*/ UnityEngine.Vector2 upVector;
        static /*0x18*/ UnityEngine.Vector2 downVector;
        static /*0x20*/ UnityEngine.Vector2 leftVector;
        static /*0x28*/ UnityEngine.Vector2 rightVector;
        static /*0x30*/ UnityEngine.Vector2 positiveInfinityVector;
        static /*0x38*/ UnityEngine.Vector2 negativeInfinityVector;
        /*0x10*/ float x;
        /*0x14*/ float y;

        static /*0x15ee410*/ Vector2();
        static /*0x15ee020*/ UnityEngine.Vector2 Lerp(UnityEngine.Vector2 a, UnityEngine.Vector2 b, float t);
        static /*0x11b7220*/ UnityEngine.Vector2 LerpUnclamped(UnityEngine.Vector2 a, UnityEngine.Vector2 b, float t);
        static /*0x15ee110*/ UnityEngine.Vector2 MoveTowards(UnityEngine.Vector2 current, UnityEngine.Vector2 target, float maxDistanceDelta);
        static /*0x1230c10*/ UnityEngine.Vector2 Scale(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x15edf10*/ float Dot(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x15ede60*/ float Distance(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x15ee0d0*/ UnityEngine.Vector2 Min(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x15ee090*/ UnityEngine.Vector2 Max(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x1230590*/ UnityEngine.Vector2 op_Addition(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x1230c50*/ UnityEngine.Vector2 op_Subtraction(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x1230c10*/ UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x1230660*/ UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x1230ce0*/ UnityEngine.Vector2 op_UnaryNegation(UnityEngine.Vector2 a);
        static /*0x1230bb0*/ UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, float d);
        static /*0x1230be0*/ UnityEngine.Vector2 op_Multiply(float d, UnityEngine.Vector2 a);
        static /*0x1230630*/ UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, float d);
        static /*0x15ee850*/ bool op_Equality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x15ee8a0*/ bool op_Inequality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x15d34c0*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector3 v);
        static /*0x317110*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector2 v);
        static /*0x15ee800*/ UnityEngine.Vector2 get_zero();
        static /*0x15ee6a0*/ UnityEngine.Vector2 get_one();
        static /*0x15ee7b0*/ UnityEngine.Vector2 get_up();
        static /*0x15ee500*/ UnityEngine.Vector2 get_down();
        static /*0x15ee550*/ UnityEngine.Vector2 get_left();
        static /*0x15ee740*/ UnityEngine.Vector2 get_right();
        static /*0x15ee6f0*/ UnityEngine.Vector2 get_positiveInfinity();
        static /*0x15ee650*/ UnityEngine.Vector2 get_negativeInfinity();
        /*0x99b700*/ Vector2(float x, float y);
        /*0x1453bd0*/ float get_Item(int index);
        /*0x15debc0*/ void set_Item(int index, float value);
        /*0x347c30*/ void Normalize();
        /*0x347d70*/ UnityEngine.Vector2 get_normalized();
        /*0x15ee240*/ string ToString();
        /*0x15ee250*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x15edfe0*/ int GetHashCode();
        /*0x15edf40*/ bool Equals(object other);
        /*0x1230110*/ bool Equals(UnityEngine.Vector2 other);
        /*0x15ee5a0*/ float get_magnitude();
        /*0x15ee790*/ float get_sqrMagnitude();
    }

    struct Vector2Int : System.IEquatable<UnityEngine.Vector2Int>, System.IFormattable
    {
        static /*0x0*/ UnityEngine.Vector2Int s_Zero;
        static /*0x8*/ UnityEngine.Vector2Int s_One;
        static /*0x10*/ UnityEngine.Vector2Int s_Up;
        static /*0x18*/ UnityEngine.Vector2Int s_Down;
        static /*0x20*/ UnityEngine.Vector2Int s_Left;
        static /*0x28*/ UnityEngine.Vector2Int s_Right;
        /*0x10*/ int m_X;
        /*0x14*/ int m_Y;

        static /*0x15edbf0*/ Vector2Int();
        static /*0x15eda00*/ UnityEngine.Vector2Int Max(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs);
        static /*0x15ede00*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector2Int v);
        static /*0x15eddd0*/ UnityEngine.Vector3Int op_Explicit(UnityEngine.Vector2Int v);
        static /*0x15ed8f0*/ UnityEngine.Vector2Int FloorToInt(UnityEngine.Vector2 v);
        static /*0x15edd90*/ UnityEngine.Vector2Int op_Addition(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b);
        static /*0x15ede40*/ UnityEngine.Vector2Int op_Subtraction(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b);
        static /*0x15eddb0*/ bool op_Equality(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs);
        static /*0x15ede20*/ bool op_Inequality(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs);
        static /*0x15edd50*/ UnityEngine.Vector2Int get_zero();
        static /*0x15edd10*/ UnityEngine.Vector2Int get_one();
        /*0xa59f20*/ Vector2Int(int x, int y);
        /*0x15d3b80*/ int get_x();
        /*0x6bbd40*/ void set_x(int value);
        /*0xc6bf90*/ int get_y();
        /*0xfc2c10*/ void set_y(int value);
        /*0x15edce0*/ float get_magnitude();
        /*0x15ed840*/ bool Equals(object other);
        /*0x15ed820*/ bool Equals(UnityEngine.Vector2Int other);
        /*0x15ed9b0*/ int GetHashCode();
        /*0x15edbe0*/ string ToString();
        /*0x15eda30*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Vector3Int : System.IEquatable<UnityEngine.Vector3Int>, System.IFormattable
    {
        static /*0x0*/ UnityEngine.Vector3Int s_Zero;
        static /*0xc*/ UnityEngine.Vector3Int s_One;
        static /*0x18*/ UnityEngine.Vector3Int s_Up;
        static /*0x24*/ UnityEngine.Vector3Int s_Down;
        static /*0x30*/ UnityEngine.Vector3Int s_Left;
        static /*0x3c*/ UnityEngine.Vector3Int s_Right;
        static /*0x48*/ UnityEngine.Vector3Int s_Forward;
        static /*0x54*/ UnityEngine.Vector3Int s_Back;
        /*0x10*/ int m_X;
        /*0x14*/ int m_Y;
        /*0x18*/ int m_Z;

        static /*0x15eecf0*/ Vector3Int();
        static /*0x15eea70*/ UnityEngine.Vector3Int Min(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs);
        static /*0x15eea10*/ UnityEngine.Vector3Int Max(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs);
        static /*0x15eefb0*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector3Int v);
        static /*0x15eef90*/ UnityEngine.Vector2Int op_Explicit(UnityEngine.Vector3Int v);
        static /*0x15eeef0*/ UnityEngine.Vector3Int op_Addition(UnityEngine.Vector3Int a, UnityEngine.Vector3Int b);
        static /*0x15ef070*/ UnityEngine.Vector3Int op_Subtraction(UnityEngine.Vector3Int a, UnityEngine.Vector3Int b);
        static /*0x15ef030*/ UnityEngine.Vector3Int op_Multiply(UnityEngine.Vector3Int a, int b);
        static /*0x15eef30*/ UnityEngine.Vector3Int op_Division(UnityEngine.Vector3Int a, int b);
        static /*0x15eef70*/ bool op_Equality(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs);
        static /*0x15eefe0*/ bool op_Inequality(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs);
        static /*0x15eeea0*/ UnityEngine.Vector3Int get_zero();
        static /*0x15eee50*/ UnityEngine.Vector3Int get_one();
        /*0x15eee40*/ Vector3Int(int x, int y);
        /*0xd4ab30*/ Vector3Int(int x, int y, int z);
        /*0x15d3b80*/ int get_x();
        /*0x6bbd40*/ void set_x(int value);
        /*0xc6bf90*/ int get_y();
        /*0xfc2c10*/ void set_y(int value);
        /*0xb73eb0*/ int get_z();
        /*0xf0fbd0*/ void set_z(int value);
        /*0x15ee8f0*/ bool Equals(object other);
        /*0x15ee9c0*/ bool Equals(UnityEngine.Vector3Int other);
        /*0x8745d0*/ int GetHashCode();
        /*0x15eead0*/ string ToString();
        /*0x15eeae0*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Vector4 : System.IEquatable<UnityEngine.Vector4>, System.IFormattable
    {
        static float kEpsilon = 0.000009999999747378752;
        static /*0x0*/ UnityEngine.Vector4 zeroVector;
        static /*0x10*/ UnityEngine.Vector4 oneVector;
        static /*0x20*/ UnityEngine.Vector4 positiveInfinityVector;
        static /*0x30*/ UnityEngine.Vector4 negativeInfinityVector;
        /*0x10*/ float x;
        /*0x14*/ float y;
        /*0x18*/ float z;
        /*0x1c*/ float w;

        static /*0x15f09b0*/ Vector4();
        static /*0x15f0610*/ UnityEngine.Vector4 Normalize(UnityEngine.Vector4 a);
        static /*0x15e97d0*/ float Dot(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x15f0540*/ float Magnitude(UnityEngine.Vector4 a);
        static /*0x15f0bc0*/ UnityEngine.Vector4 get_zero();
        static /*0x15f0b20*/ UnityEngine.Vector4 get_one();
        static /*0x15e0f70*/ UnityEngine.Vector4 op_Addition(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x15e11d0*/ UnityEngine.Vector4 op_Subtraction(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x15f0db0*/ UnityEngine.Vector4 op_UnaryNegation(UnityEngine.Vector4 a);
        static /*0x15e10d0*/ UnityEngine.Vector4 op_Multiply(UnityEngine.Vector4 a, float d);
        static /*0x15e1120*/ UnityEngine.Vector4 op_Multiply(float d, UnityEngine.Vector4 a);
        static /*0x15f0c10*/ UnityEngine.Vector4 op_Division(UnityEngine.Vector4 a, float d);
        static /*0x15f0c30*/ bool op_Equality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs);
        static /*0x15f0d40*/ bool op_Inequality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs);
        static /*0x15f0cb0*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Vector3 v);
        static /*0x15f0c90*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector4 v);
        static /*0x15f0d00*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Vector2 v);
        static /*0x15d34c0*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector4 v);
        /*0x11534a0*/ Vector4(float x, float y, float z, float w);
        /*0x15f0a40*/ Vector4(float x, float y);
        /*0x15dec40*/ float get_Item(int index);
        /*0x13e4250*/ void set_Item(int index, float value);
        /*0x11534a0*/ void Set(float newX, float newY, float newZ, float newW);
        /*0x15f06e0*/ void Scale(UnityEngine.Vector4 scale);
        /*0x65c140*/ int GetHashCode();
        /*0x15f0480*/ bool Equals(object other);
        /*0x1245350*/ bool Equals(UnityEngine.Vector4 other);
        /*0x15f0a50*/ UnityEngine.Vector4 get_normalized();
        /*0x15f0b70*/ float get_sqrMagnitude();
        /*0x15f09a0*/ string ToString();
        /*0x15f0720*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct TypeDispatchData : System.IDisposable
    {
        /*0x10*/ UnityEngine.Object[] changed;
        /*0x18*/ Unity.Collections.NativeArray<int> changedID;
        /*0x28*/ Unity.Collections.NativeArray<int> destroyedID;

        /*0x15ed0f0*/ void Dispose();
    }

    struct TransformDispatchData : System.IDisposable
    {
        /*0x10*/ Unity.Collections.NativeArray<int> transformedID;
        /*0x20*/ Unity.Collections.NativeArray<int> parentID;
        /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices;
        /*0x40*/ Unity.Collections.NativeArray<UnityEngine.Vector3> positions;
        /*0x50*/ Unity.Collections.NativeArray<UnityEngine.Quaternion> rotations;
        /*0x60*/ Unity.Collections.NativeArray<UnityEngine.Vector3> scales;

        /*0x15ed040*/ void Dispose();
    }

    class ObjectDispatcher
    {
        static /*0x0*/ System.Action<UnityEngine.Object[], nint, nint, int, int, System.Action<UnityEngine.TypeDispatchData>> s_TypeDispatch;
        static /*0x8*/ System.Action<nint, nint, nint, nint, nint, nint, int, System.Action<UnityEngine.TransformDispatchData>> s_TransformDispatch;
        /*0x10*/ nint m_Ptr;

        static /*0x15e8c30*/ ObjectDispatcher();

        class <>c
        {
            static /*0x0*/ UnityEngine.ObjectDispatcher.<> <>9;

            static /*0x15ed560*/ <>c();
            /*0x32f970*/ <>c();
            /*0x15ed1f0*/ void <.cctor>b__54_0(UnityEngine.Object[] changed, nint changedID, nint destroyedID, int changedCount, int destroyedCount, System.Action<UnityEngine.TypeDispatchData> callback);
            /*0x15ed320*/ void <.cctor>b__54_1(nint transformed, nint parents, nint localToWorldMatrices, nint positions, nint rotations, nint scales, int count, System.Action<UnityEngine.TransformDispatchData> callback);
        }
    }

    class NumericFieldDraggerUtility
    {
        static /*0x0*/ bool s_UseYSign;

        static /*0x15e87b0*/ float Acceleration(bool shiftPressed, bool altPressed);
        static /*0x15e8b20*/ float NiceDelta(UnityEngine.Vector2 deviceDelta, float acceleration);
        static /*0x15e88b0*/ double CalculateFloatDragSensitivity(double value);
        static /*0x15e87f0*/ double CalculateFloatDragSensitivity(double value, double minValue, double maxValue);
        static /*0x15e8970*/ long CalculateIntDragSensitivity(long value);
        static /*0x15e8a20*/ ulong CalculateIntDragSensitivity(ulong value);
        static /*0x15e8aa0*/ double CalculateIntDragSensitivity(double value);
        static /*0x15e8990*/ long CalculateIntDragSensitivity(long value, long minValue, long maxValue);
    }

    interface IPlayerEditorConnectionNative
    {
        /*0x180fc0*/ void Initialize();
        /*0x180fc0*/ void DisconnectAll();
        void SendMessage(System.Guid messageId, byte[] data, int playerId);
        bool TrySendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x180fc0*/ void Poll();
        void RegisterInternal(System.Guid messageId);
        void UnregisterInternal(System.Guid messageId);
        /*0x17cb40*/ bool IsConnected();
    }

    class PlayerConnectionInternal : UnityEngine.IPlayerEditorConnectionNative
    {
        static /*0x15e8de0*/ bool IsConnected();
        static /*0x15e8db0*/ void Initialize();
        static /*0x15e8e40*/ void RegisterInternal(string messageId);
        static /*0x15e9240*/ void UnregisterInternal(string messageId);
        static /*0x15e8e80*/ void SendMessage(string messageId, byte[] data, int playerId);
        static /*0x15e8ee0*/ bool TrySendMessage(string messageId, byte[] data, int playerId);
        static /*0x15e8e10*/ void PollInternal();
        static /*0x15e8d80*/ void DisconnectAll();
        /*0x32f970*/ PlayerConnectionInternal();
        /*0x15e8fb0*/ void UnityEngine.IPlayerEditorConnectionNative.SendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x15e90c0*/ bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x15e8e10*/ void UnityEngine.IPlayerEditorConnectionNative.Poll();
        /*0x15e8f40*/ void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(System.Guid messageId);
        /*0x15e91d0*/ void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(System.Guid messageId);
        /*0x15e8db0*/ void UnityEngine.IPlayerEditorConnectionNative.Initialize();
        /*0x15e8de0*/ bool UnityEngine.IPlayerEditorConnectionNative.IsConnected();
        /*0x15e8d80*/ void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll();
    }

    class PlayerPrefsException : System.Exception
    {
        /*0x15e9280*/ PlayerPrefsException(string error);
    }

    class PlayerPrefs
    {
        static /*0x15e94a0*/ bool TrySetSetString(string key, string value);
        static /*0x15e9410*/ void SetString(string key, string value);
        static /*0x15e9350*/ string GetString(string key, string defaultValue);
        static /*0x15e92e0*/ string GetString(string key);
        static /*0x15e93a0*/ bool HasKey(string key);
        static /*0x15e93e0*/ void Save();
    }

    class PropertyAttribute : System.Attribute
    {
        /*0x534220*/ PropertyAttribute();
    }

    class InspectorNameAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ string displayName;

        /*0xa32e30*/ InspectorNameAttribute(string displayName);
    }

    class TooltipAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ string tooltip;

        /*0xa32e30*/ TooltipAttribute(string tooltip);
    }

    class SpaceAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ float height;

        /*0x15ebaa0*/ SpaceAttribute();
        /*0x14c9140*/ SpaceAttribute(float height);
    }

    class HeaderAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ string header;

        /*0xa32e30*/ HeaderAttribute(string header);
    }

    class RangeAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ float min;
        /*0x14*/ float max;

        /*0x14c9170*/ RangeAttribute(float min, float max);
    }

    class MinAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ float min;

        /*0x14c9140*/ MinAttribute(float min);
    }

    class MultilineAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ int lines;

        /*0x15e8790*/ MultilineAttribute();
    }

    class TextAreaAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ int minLines;
        /*0x14*/ int maxLines;

        /*0xeac080*/ TextAreaAttribute(int minLines, int maxLines);
    }

    class ColorUsageAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ bool showAlpha;
        /*0x11*/ bool hdr;
        /*0x14*/ float minBrightness;
        /*0x18*/ float maxBrightness;
        /*0x1c*/ float minExposureValue;
        /*0x20*/ float maxExposureValue;

        /*0x15e06f0*/ ColorUsageAttribute(bool showAlpha);
    }

    class DelayedAttribute : UnityEngine.PropertyAttribute
    {
        /*0x534220*/ DelayedAttribute();
    }

    class PropertyNameUtils
    {
        static /*0x15e9540*/ UnityEngine.PropertyName PropertyNameFromString(string name);
        static /*0x15e94f0*/ void PropertyNameFromString_Injected(string name, ref UnityEngine.PropertyName ret);
    }

    struct PropertyName : System.IEquatable<UnityEngine.PropertyName>
    {
        /*0x10*/ int id;

        static /*0x15e9630*/ bool IsNullOrEmpty(UnityEngine.PropertyName prop);
        static /*0x15e9700*/ bool op_Equality(UnityEngine.PropertyName lhs, UnityEngine.PropertyName rhs);
        static /*0x15e9540*/ UnityEngine.PropertyName op_Implicit(string name);
        /*0x15e96a0*/ PropertyName(string name);
        /*0x6bbd40*/ PropertyName(UnityEngine.PropertyName other);
        /*0x15d3b80*/ int GetHashCode();
        /*0x15e95a0*/ bool Equals(object other);
        /*0x15e9590*/ bool Equals(UnityEngine.PropertyName other);
        /*0x15e9640*/ string ToString();
    }

    class Random
    {
        static /*0x15ea670*/ void InitState(int seed);
        static /*0x15ea800*/ UnityEngine.Random.State get_state();
        static /*0x15ea8b0*/ void set_state(UnityEngine.Random.State value);
        static /*0x15ea6f0*/ float Range(float minInclusive, float maxInclusive);
        static /*0x15ea6b0*/ int Range(int minInclusive, int maxExclusive);
        static /*0x15ea6b0*/ int RandomRangeInt(int minInclusive, int maxExclusive);
        static /*0x15ea840*/ float get_value();
        static /*0x15ea780*/ UnityEngine.Vector3 get_insideUnitSphere();
        static /*0x15ea7c0*/ void get_state_Injected(ref UnityEngine.Random.State ret);
        static /*0x15ea870*/ void set_state_Injected(ref UnityEngine.Random.State value);
        static /*0x15ea740*/ void get_insideUnitSphere_Injected(ref UnityEngine.Vector3 ret);

        struct State
        {
            /*0x10*/ int s0;
            /*0x14*/ int s1;
            /*0x18*/ int s2;
            /*0x1c*/ int s3;
        }
    }

    class ResourceRequest : UnityEngine.AsyncOperation
    {
        /*0x20*/ string m_Path;
        /*0x28*/ System.Type m_Type;
    }

    class ResourcesAPIInternal
    {
        static /*0x15eb2c0*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type);
        static /*0x15eb300*/ UnityEngine.Shader FindShaderByName(string name);
        static /*0x15eb390*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        static /*0x15eb340*/ UnityEngine.Object[] LoadAll(string path, System.Type systemTypeInstance);
    }

    class ResourcesAPI
    {
        static /*0x0*/ UnityEngine.ResourcesAPI s_DefaultAPI;
        static /*0x8*/ UnityEngine.ResourcesAPI <overrideAPI>k__BackingField;

        static /*0x15eb500*/ ResourcesAPI();
        static /*0x15eb570*/ UnityEngine.ResourcesAPI get_ActiveAPI();
        static /*0x15eb620*/ UnityEngine.ResourcesAPI get_overrideAPI();
        /*0x32f970*/ ResourcesAPI();
        /*0x15eb3e0*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type systemTypeInstance);
        /*0x15eb420*/ UnityEngine.Shader FindShaderByName(string name);
        /*0x15eb4b0*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        /*0x15eb460*/ UnityEngine.Object[] LoadAll(string path, System.Type systemTypeInstance);
    }

    class Resources
    {
        static /*0x17e030*/ T[] ConvertObjects<T>(UnityEngine.Object[] rawObjects);
        static /*0x15eb670*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type);
        static /*0x180cf0*/ T[] FindObjectsOfTypeAll<T>();
        static /*0x2a5510*/ T Load<T>(string path);
        static /*0x15eb7b0*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        static /*0x15eb730*/ UnityEngine.Object[] LoadAll(string path, System.Type systemTypeInstance);
        static /*0x17e030*/ T[] LoadAll<T>(string path);
        static /*0x15eb6e0*/ UnityEngine.Object GetBuiltinResource(System.Type type, string path);
        static /*0x2a5510*/ T GetBuiltinResource<T>(string path);
    }

    class AsyncInstantiateOperation : UnityEngine.AsyncOperation
    {
        /*0x20*/ UnityEngine.Object[] m_Result;
    }

    class AsyncInstantiateOperationHelper
    {
        static /*0x15df490*/ void SetAsyncInstantiateOperationResult(UnityEngine.AsyncInstantiateOperation op, UnityEngine.Object[] result);
    }

    class AsyncOperation : UnityEngine.YieldInstruction
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ System.Action<UnityEngine.AsyncOperation> m_completeCallback;

        static /*0x15df530*/ void InternalDestroy(nint ptr);
        /*0x534220*/ AsyncOperation();
        /*0x15df4b0*/ void Finalize();
        /*0x15df570*/ void InvokeCompletionEvent();
    }

    class AttributeHelperEngine
    {
        static /*0x0*/ UnityEngine.DisallowMultipleComponent[] _disallowMultipleComponentArray;
        static /*0x8*/ UnityEngine.ExecuteInEditMode[] _executeInEditModeArray;
        static /*0x10*/ UnityEngine.RequireComponent[] _requireComponentArray;

        static /*0x15dff00*/ AttributeHelperEngine();
        static /*0x15df940*/ System.Type GetParentTypeDisallowingMultipleInclusion(System.Type type);
        static /*0x15dfa80*/ System.Type[] GetRequiredComponents(System.Type klass);
        static /*0x15df830*/ int GetExecuteMode(System.Type klass);
        static /*0x15df5c0*/ int CheckIsEditorScript(System.Type klass);
        static /*0x15df7c0*/ int GetDefaultExecutionOrderFor(System.Type klass);
        static /*0x2a5510*/ T GetCustomAttributeOfType<T>(System.Type klass);
    }

    class DisallowMultipleComponent : System.Attribute
    {
        /*0x534220*/ DisallowMultipleComponent();
    }

    class RequireComponent : System.Attribute
    {
        /*0x10*/ System.Type m_Type0;
        /*0x18*/ System.Type m_Type1;
        /*0x20*/ System.Type m_Type2;

        /*0xa32e30*/ RequireComponent(System.Type requiredComponent);
        /*0xea2f90*/ RequireComponent(System.Type requiredComponent, System.Type requiredComponent2);
    }

    class AddComponentMenu : System.Attribute
    {
        /*0x10*/ string m_AddComponentMenu;
        /*0x18*/ int m_Ordering;

        /*0x15decd0*/ AddComponentMenu(string menuName);
        /*0xea64b0*/ AddComponentMenu(string menuName, int order);
    }

    class ContextMenu : System.Attribute
    {
        /*0x10*/ string menuItem;
        /*0x18*/ bool validate;
        /*0x1c*/ int priority;

        /*0x15e1940*/ ContextMenu(string itemName);
        /*0x15e18f0*/ ContextMenu(string itemName, bool isValidateFunction);
        /*0x15e1890*/ ContextMenu(string itemName, bool isValidateFunction, int priority);
    }

    class ExecuteInEditMode : System.Attribute
    {
        /*0x534220*/ ExecuteInEditMode();
    }

    class ExecuteAlways : System.Attribute
    {
        /*0x534220*/ ExecuteAlways();
    }

    class HideInInspector : System.Attribute
    {
        /*0x534220*/ HideInInspector();
    }

    class HelpURLAttribute : System.Attribute
    {
        /*0x10*/ string m_Url;
        /*0x18*/ bool m_Dispatcher;
        /*0x20*/ string m_DispatchingFieldName;

        /*0x15e4430*/ HelpURLAttribute(string url);
        /*0x73d3e0*/ string get_URL();
    }

    class DefaultExecutionOrder : System.Attribute
    {
        /*0x10*/ int m_Order;

        /*0xea4040*/ DefaultExecutionOrder(int order);
        /*0x15bceb0*/ int get_order();
    }

    class AssemblyIsEditorAssembly : System.Attribute
    {
    }

    class ExcludeFromPresetAttribute : System.Attribute
    {
        /*0x534220*/ ExcludeFromPresetAttribute();
    }

    class Behaviour : UnityEngine.Component
    {
        /*0x15e0000*/ Behaviour();
        /*0x15e0050*/ bool get_enabled();
        /*0x15e00d0*/ void set_enabled(bool value);
        /*0x15e0090*/ bool get_isActiveAndEnabled();
    }

    struct CastHelper<T>
    {
        /*0x0*/ T t;
        /*0x0*/ nint onePointerFurtherThanT;
    }

    class ClassLibraryInitializer
    {
        static /*0x15e0360*/ void Init();
        static /*0x15e0240*/ void InitStdErrWithHandle(nint fileHandle);
        static /*0x15e0120*/ void InitAssemblyRedirections();

        class <>c
        {
            static /*0x0*/ UnityEngine.ClassLibraryInitializer.<> <>9;
            static /*0x8*/ System.ResolveEventHandler <>9__2_0;

            static /*0x15ed5d0*/ <>c();
            /*0x32f970*/ <>c();
            /*0x15ed150*/ System.Reflection.Assembly <InitAssemblyRedirections>b__2_0(object _, System.ResolveEventArgs args);
        }
    }

    struct AssemblyVersion
    {
        /*0x10*/ ushort major;
        /*0x12*/ ushort minor;
        /*0x14*/ ushort build;
        /*0x16*/ ushort revision;

        static /*0x15df450*/ bool op_Equality(UnityEngine.AssemblyVersion lhs, UnityEngine.AssemblyVersion rhs);
        /*0x15df240*/ string ToString();
        /*0x15df0f0*/ bool Equals(object other);
        /*0x15df1a0*/ int GetHashCode();
    }

    struct AssemblyFullName
    {
        /*0x10*/ string Name;
        /*0x18*/ UnityEngine.AssemblyVersion Version;
        /*0x20*/ string PublicKeyToken;
        /*0x28*/ string Culture;

        /*0x15ded10*/ bool Equals(object other);
        /*0x15dee40*/ int GetHashCode();
        /*0x15deee0*/ string ToString();
    }

    class Component : UnityEngine.Object
    {
        /*0x15e0000*/ Component();
        /*0x15e1850*/ UnityEngine.Transform get_transform();
        /*0x15e1810*/ UnityEngine.GameObject get_gameObject();
        /*0x15e1490*/ UnityEngine.Component GetComponent(System.Type type);
        /*0x15e1290*/ void GetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x2a5510*/ T GetComponent<T>();
        /*0x15e17a0*/ bool TryGetComponent(System.Type type, ref UnityEngine.Component component);
        /*0x17e620*/ bool TryGetComponent<T>(ref T component);
        /*0x15e1350*/ UnityEngine.Component GetComponentInChildren(System.Type t, bool includeInactive);
        /*0x15e12f0*/ UnityEngine.Component GetComponentInChildren(System.Type t);
        /*0x2a5510*/ T GetComponentInChildren<T>(bool includeInactive);
        /*0x2a5510*/ T GetComponentInChildren<T>();
        /*0x15e1550*/ UnityEngine.Component[] GetComponentsInChildren(System.Type t);
        T[] GetComponentsInChildren<T>(bool includeInactive);
        void GetComponentsInChildren<T>(bool includeInactive, System.Collections.Generic.List<T> result);
        /*0x1803b0*/ T[] GetComponentsInChildren<T>();
        /*0x17aec0*/ void GetComponentsInChildren<T>(System.Collections.Generic.List<T> results);
        /*0x15e1420*/ UnityEngine.Component GetComponentInParent(System.Type t, bool includeInactive);
        /*0x15e13c0*/ UnityEngine.Component GetComponentInParent(System.Type t);
        /*0x2a5510*/ T GetComponentInParent<T>();
        /*0x15e15b0*/ UnityEngine.Component[] GetComponentsInParent(System.Type t, bool includeInactive);
        /*0x15e1620*/ UnityEngine.Component[] GetComponentsInParent(System.Type t);
        T[] GetComponentsInParent<T>(bool includeInactive);
        void GetComponentsInParent<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        /*0x1803b0*/ T[] GetComponentsInParent<T>();
        /*0x15e1680*/ UnityEngine.Component[] GetComponents(System.Type type);
        /*0x15e14f0*/ void GetComponentsForListInternal(System.Type searchType, object resultList);
        /*0x15e14f0*/ void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results);
        /*0x17aec0*/ void GetComponents<T>(System.Collections.Generic.List<T> results);
        /*0x1803b0*/ T[] GetComponents<T>();
        /*0x15e1230*/ bool CompareTag(string tag);
        /*0x15e1750*/ void SendMessage(string methodName);
        /*0x15e16e0*/ void SendMessage(string methodName, object value, UnityEngine.SendMessageOptions options);
    }

    class Coroutine : UnityEngine.YieldInstruction
    {
        /*0x10*/ nint m_Ptr;

        static /*0x15e1a00*/ void ReleaseCoroutine(nint ptr);
        /*0x534220*/ Coroutine();
        /*0x15e1980*/ void Finalize();
    }

    class SetupCoroutine
    {
        static /*0x15eb960*/ void InvokeMoveNext(System.Collections.IEnumerator enumerator, nint returnValueAddress);
        static /*0x15eb830*/ object InvokeMember(object behaviour, string name, object variable);
    }

    class CustomYieldInstruction : System.Collections.IEnumerator
    {
        /*0x32f970*/ CustomYieldInstruction();
        /*0x17cb40*/ bool get_keepWaiting();
        /*0xbf9940*/ object get_Current();
        /*0xedfd70*/ bool MoveNext();
        /*0x32d010*/ void Reset();
    }

    struct EnumData
    {
        /*0x10*/ System.Enum[] values;
        /*0x18*/ int[] flagValues;
        /*0x20*/ string[] displayNames;
        /*0x28*/ string[] names;
        /*0x30*/ string[] tooltip;
        /*0x38*/ bool flags;
        /*0x40*/ System.Type underlyingType;
        /*0x48*/ bool unsigned;
        /*0x49*/ bool serializable;
    }

    class EnumDataUtility
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<System.ValueTuple<UnityEngine.EnumDataUtility.CachedType, System.Type>, UnityEngine.EnumData> s_EnumData;

        static /*0x15e37e0*/ EnumDataUtility();
        static /*0x15e2070*/ UnityEngine.EnumData GetCachedEnumData(System.Type enumType, UnityEngine.EnumDataUtility.CachedType cachedType, System.Func<string, string> nicifyName);
        static /*0x15e31c0*/ void HandleInspectorOrderAttribute(System.Type enumType, ref UnityEngine.EnumData enumData);
        static /*0x15e1b20*/ bool CheckObsoleteAddition(System.Reflection.FieldInfo field, UnityEngine.EnumDataUtility.CachedType cachedType);
        static /*0x15e1f40*/ string EnumTooltipFromEnumField(System.Reflection.FieldInfo field);
        static /*0x15e1c60*/ string EnumNameFromEnumField(System.Reflection.FieldInfo field, System.Func<string, string> nicifyName);
        static /*0x15e3770*/ string <EnumNameFromEnumField>g__NicifyName|8_0(ref UnityEngine.EnumDataUtility.<> );

        enum CachedType
        {
            ExcludeObsolete = 0,
            IncludeObsoleteExceptErrors = 1,
            IncludeAllObsolete = 2,
        }

        class <>c
        {
            static /*0x0*/ UnityEngine.EnumDataUtility.<> <>9;
            static /*0x8*/ System.Func<System.Reflection.FieldInfo, int> <>9__2_5;
            static /*0x10*/ System.Func<System.Reflection.FieldInfo, string> <>9__2_1;
            static /*0x18*/ System.Func<System.Reflection.FieldInfo, System.Enum> <>9__2_2;
            static /*0x20*/ System.Func<System.Enum, int> <>9__2_3;
            static /*0x28*/ System.Func<System.Enum, int> <>9__2_4;

            static /*0x160e120*/ <>c();
            /*0x32f970*/ <>c();
            /*0x7190b0*/ int <GetCachedEnumData>b__2_5(System.Reflection.FieldInfo f);
            /*0x160ddc0*/ string <GetCachedEnumData>b__2_1(System.Reflection.FieldInfo f);
            /*0x160de10*/ System.Enum <GetCachedEnumData>b__2_2(System.Reflection.FieldInfo f);
            /*0x160dea0*/ int <GetCachedEnumData>b__2_3(System.Enum v);
            /*0x160def0*/ int <GetCachedEnumData>b__2_4(System.Enum v);
        }

        class <>c__DisplayClass2_0
        {
            /*0x10*/ System.Func<string, string> nicifyName;

            /*0x32f970*/ <>c__DisplayClass2_0();
            /*0x160e050*/ string <GetCachedEnumData>b__0(System.Reflection.FieldInfo f);
        }

        struct <>c__DisplayClass8_0
        {
            /*0x10*/ System.Func<string, string> nicifyName;
            /*0x18*/ System.Reflection.FieldInfo field;
        }
    }

    class ExcludeFromObjectFactoryAttribute : System.Attribute
    {
        /*0x534220*/ ExcludeFromObjectFactoryAttribute();
    }

    class ExtensionOfNativeClassAttribute : System.Attribute
    {
        /*0x534220*/ ExtensionOfNativeClassAttribute();
    }

    class FailedToLoadScriptObject : UnityEngine.Object
    {
    }

    class GameObject : UnityEngine.Object
    {
        static /*0x15f8e10*/ void Internal_CreateGameObject(UnityEngine.GameObject self, string name);
        static /*0x15f87b0*/ UnityEngine.GameObject Find(string name);
        /*0x15f90f0*/ GameObject(string name);
        /*0x15f9270*/ GameObject();
        /*0x15f9170*/ GameObject(string name, System.Type[] components);
        /*0x2a5510*/ T GetComponent<T>();
        /*0x15f89b0*/ UnityEngine.Component GetComponent(System.Type type);
        /*0x15f87f0*/ void GetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x15f88a0*/ UnityEngine.Component GetComponentInChildren(System.Type type, bool includeInactive);
        /*0x15f8850*/ UnityEngine.Component GetComponentInChildren(System.Type type);
        /*0x2a5510*/ T GetComponentInChildren<T>();
        /*0x2a5510*/ T GetComponentInChildren<T>(bool includeInactive);
        /*0x15f8900*/ UnityEngine.Component GetComponentInParent(System.Type type, bool includeInactive);
        /*0x15f8960*/ UnityEngine.Component GetComponentInParent(System.Type type);
        /*0x2a5510*/ T GetComponentInParent<T>();
        /*0x2a5510*/ T GetComponentInParent<T>(bool includeInactive);
        /*0x15f8ce0*/ System.Array GetComponentsInternal(System.Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList);
        /*0x15f8d60*/ UnityEngine.Component[] GetComponents(System.Type type);
        /*0x1803b0*/ T[] GetComponents<T>();
        /*0x17aec0*/ void GetComponents<T>(System.Collections.Generic.List<T> results);
        /*0x15f8ac0*/ UnityEngine.Component[] GetComponentsInChildren(System.Type type);
        /*0x15f8a00*/ UnityEngine.Component[] GetComponentsInChildren(System.Type type, bool includeInactive);
        T[] GetComponentsInChildren<T>(bool includeInactive);
        void GetComponentsInChildren<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        /*0x1803b0*/ T[] GetComponentsInChildren<T>();
        /*0x15f8b70*/ UnityEngine.Component[] GetComponentsInParent(System.Type type);
        /*0x15f8c20*/ UnityEngine.Component[] GetComponentsInParent(System.Type type, bool includeInactive);
        void GetComponentsInParent<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        T[] GetComponentsInParent<T>(bool includeInactive);
        /*0x1803b0*/ T[] GetComponentsInParent<T>();
        /*0x17e620*/ bool TryGetComponent<T>(ref T component);
        /*0x15f8fd0*/ bool TryGetComponent(System.Type type, ref UnityEngine.Component component);
        /*0x15f8f80*/ UnityEngine.Component TryGetComponentInternal(System.Type type);
        /*0x15f8f20*/ void TryGetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x15f8710*/ UnityEngine.Component Internal_AddComponentWithType(System.Type componentType);
        /*0x15f8710*/ UnityEngine.Component AddComponent(System.Type componentType);
        /*0x2a5510*/ T AddComponent<T>();
        /*0x15f9480*/ UnityEngine.Transform get_transform();
        /*0x15f9360*/ int get_layer();
        /*0x15f94c0*/ void set_layer(int value);
        /*0x15f8ed0*/ void SetActive(bool value);
        /*0x15f9320*/ bool get_activeSelf();
        /*0x15f92e0*/ bool get_activeInHierarchy();
        /*0x15f9500*/ void set_tag(string value);
        /*0x15f8760*/ bool CompareTag(string tag);
        /*0x15f8e60*/ void SendMessage(string methodName, object value, UnityEngine.SendMessageOptions options);
        /*0x15f9430*/ UnityEngine.SceneManagement.Scene get_scene();
        /*0x15f93a0*/ ulong get_sceneCullingMask();
        /*0x15f93e0*/ void get_scene_Injected(ref UnityEngine.SceneManagement.Scene ret);
    }

    class InspectorOrderAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ UnityEngine.InspectorSort <m_inspectorSort>k__BackingField;
        /*0x14*/ UnityEngine.InspectorSortDirection <m_sortDirection>k__BackingField;

        /*0x417e30*/ UnityEngine.InspectorSort get_m_inspectorSort();
        /*0x70a440*/ UnityEngine.InspectorSortDirection get_m_sortDirection();
    }

    enum InspectorSort
    {
        ByName = 0,
        ByValue = 1,
    }

    enum InspectorSortDirection
    {
        Ascending = 0,
        Descending = 1,
    }

    struct LayerMask
    {
        /*0x10*/ int m_Mask;

        static /*0x15fa620*/ int op_Implicit(UnityEngine.LayerMask mask);
        static /*0x15fa620*/ UnityEngine.LayerMask op_Implicit(int intVal);
        static /*0x15fa5e0*/ int NameToLayer(string layerName);
        static /*0x15fa4f0*/ int GetMask(string[] layerNames);
        /*0x15d3b80*/ int get_value();
        /*0x6bbd40*/ void set_value(int value);
    }

    struct LazyLoadReference<T>
    {
        /*0x0*/ int m_InstanceID;
    }

    class ManagedStreamHelpers
    {
        static /*0x15fa900*/ void ValidateLoadFromStream(System.IO.Stream stream);
        static /*0x15fa710*/ void ManagedStreamRead(byte[] buffer, int offset, int count, System.IO.Stream stream, nint returnValueAddress);
        static /*0x15fa810*/ void ManagedStreamSeek(long offset, uint origin, System.IO.Stream stream, nint returnValueAddress);
        static /*0x15fa640*/ void ManagedStreamLength(System.IO.Stream stream, nint returnValueAddress);
    }

    class MonoBehaviour : UnityEngine.Behaviour
    {
        /*0x18*/ System.Threading.CancellationTokenSource m_CancellationTokenSource;

        static /*0x15fb9c0*/ void print(object message);
        static /*0x15fad10*/ void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self);
        static /*0x15fade0*/ bool Internal_IsInvokingAll(UnityEngine.MonoBehaviour self);
        static /*0x15fae20*/ void InvokeDelayed(UnityEngine.MonoBehaviour self, string methodName, float time, float repeatRate);
        static /*0x15fad50*/ void CancelInvoke(UnityEngine.MonoBehaviour self, string methodName);
        static /*0x15fafc0*/ bool IsInvoking(UnityEngine.MonoBehaviour self, string methodName);
        static /*0x15fb010*/ bool IsObjectMonoBehaviour(UnityEngine.Object obj);
        /*0x15b84e0*/ MonoBehaviour();
        /*0x15fb7f0*/ System.Threading.CancellationToken get_destroyCancellationToken();
        /*0x15fb090*/ void RaiseCancellation();
        /*0x15fade0*/ bool IsInvoking();
        /*0x15fad10*/ void CancelInvoke();
        /*0x15faf60*/ void Invoke(string methodName, float time);
        /*0x15fae90*/ void InvokeRepeating(string methodName, float time, float repeatRate);
        /*0x15fad50*/ void CancelInvoke(string methodName);
        /*0x15fafc0*/ bool IsInvoking(string methodName);
        /*0x15fb270*/ UnityEngine.Coroutine StartCoroutine(string methodName);
        /*0x15fb380*/ UnityEngine.Coroutine StartCoroutine(string methodName, object value);
        /*0x15fb160*/ UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine);
        /*0x15fb160*/ UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine);
        /*0x15fb6e0*/ void StopCoroutine(System.Collections.IEnumerator routine);
        /*0x15fb5d0*/ void StopCoroutine(UnityEngine.Coroutine routine);
        /*0x15fb580*/ void StopCoroutine(string methodName);
        /*0x15fb4a0*/ void StopAllCoroutines();
        /*0x15fb980*/ bool get_useGUILayout();
        /*0x15fba10*/ void set_useGUILayout(bool value);
        /*0x15fb100*/ UnityEngine.Coroutine StartCoroutineManaged(string methodName, object value);
        /*0x15fb0b0*/ UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator);
        /*0x15fb530*/ void StopCoroutineManaged(UnityEngine.Coroutine routine);
        /*0x15fb4e0*/ void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine);
        /*0x15fada0*/ string GetScriptClassName();
        /*0x15fb050*/ void OnCancellationTokenCreated();
    }

    class NoAllocHelpers
    {
        static /*0x1827f0*/ void ResizeList<T>(System.Collections.Generic.List<T> list, int size);
        static /*0x1827f0*/ void EnsureListElemCount<T>(System.Collections.Generic.List<T> list, int count);
        static /*0x15fbc50*/ int SafeLength(System.Array values);
        static /*0x17a070*/ int SafeLength<T>(System.Collections.Generic.List<T> values);
        static /*0x15fbc10*/ void Internal_ResizeList(object list, int size);
        static /*0x15fbbd0*/ System.Array ExtractArrayFromList(object list);
    }

    struct RangeInt
    {
        /*0x10*/ int start;
        /*0x14*/ int length;

        /*0xa59f20*/ RangeInt(int start, int length);
        /*0x16016d0*/ int get_end();
    }

    enum RuntimeInitializeLoadType
    {
        AfterSceneLoad = 0,
        BeforeSceneLoad = 1,
        AfterAssembliesLoaded = 2,
        BeforeSplashScreen = 3,
        SubsystemRegistration = 4,
    }

    class RuntimeInitializeOnLoadMethodAttribute : UnityEngine.Scripting.PreserveAttribute
    {
        /*0x10*/ UnityEngine.RuntimeInitializeLoadType m_LoadType;

        /*0xea4040*/ RuntimeInitializeOnLoadMethodAttribute(UnityEngine.RuntimeInitializeLoadType loadType);
        /*0xdcd9c0*/ void set_loadType(UnityEngine.RuntimeInitializeLoadType value);
    }

    class ScriptableObject : UnityEngine.Object
    {
        static /*0x16053a0*/ UnityEngine.ScriptableObject CreateInstance(System.Type type);
        static /*0x2a5510*/ T CreateInstance<T>();
        static /*0x1605430*/ void CreateScriptableObject(UnityEngine.ScriptableObject self);
        static /*0x16053e0*/ UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromType(System.Type type, bool applyDefaultsAndReset);
        /*0x1605470*/ ScriptableObject();
    }

    class ScriptingRuntime
    {
        static /*0x16054e0*/ string[] GetAllUserAssemblies();
    }

    class ScriptingUtility
    {
        static /*0x72f070*/ bool IsManagedCodeWorking();

        struct TestClass
        {
            /*0x10*/ int value;
        }
    }

    class SelectionBaseAttribute : System.Attribute
    {
        /*0x534220*/ SelectionBaseAttribute();
    }

    class StackTraceUtility
    {
        static /*0x0*/ string projectFolder;

        static /*0x1609320*/ StackTraceUtility();
        static /*0x1609200*/ void SetProjectFolder(string folder);
        static /*0x1608cd0*/ string ExtractStackTrace();
        static /*0x1608e10*/ void ExtractStringFromExceptionInternal(object exceptiono, ref string message, ref string stackTrace);
        static /*0x1608530*/ string ExtractFormattedStackTrace(System.Diagnostics.StackTrace stackTrace);
    }

    class UnityException : System.Exception
    {
        /*0x16102c0*/ UnityException();
        /*0x16103b0*/ UnityException(string message);
        /*0x1610330*/ UnityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    }

    class MissingReferenceException : System.Exception
    {
        /*0x15faca0*/ MissingReferenceException();
        /*0x15fac30*/ MissingReferenceException(string message);
        /*0x15fabb0*/ MissingReferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    }

    class TextAsset : UnityEngine.Object
    {
        static /*0x160a3b0*/ void Internal_CreateInstance(UnityEngine.TextAsset self, string text);
        static /*0x160a0d0*/ string DecodeString(byte[] bytes);
        /*0x160a490*/ TextAsset();
        /*0x160a500*/ TextAsset(UnityEngine.TextAsset.CreateOptions options, string text);
        /*0x160a590*/ byte[] get_bytes();
        /*0x160a330*/ nint GetDataPtr();
        /*0x160a370*/ long GetDataSize();
        /*0x160a400*/ string get_text();
        /*0x160a400*/ string ToString();
        /*0x2a5510*/ Unity.Collections.NativeArray<T> GetData<T>();

        enum CreateOptions
        {
            None = 0,
            CreateNativeObject = 1,
        }

        class EncodingUtility
        {
            static /*0x0*/ System.Collections.Generic.KeyValuePair<System.Byte[], System.Text.Encoding> encodingLookup;
            static /*0x8*/ System.Text.Encoding targetEncoding;

            static /*0x15f81b0*/ EncodingUtility();
        }
    }

    class TrackedReference
    {
        /*0x10*/ nint m_Ptr;
    }

    class UnhandledExceptionHandler
    {
        static /*0x160ebf0*/ void RegisterUECatcher();

        class <>c
        {
            static /*0x0*/ UnityEngine.UnhandledExceptionHandler.<> <>9;
            static /*0x8*/ System.UnhandledExceptionEventHandler <>9__0_0;

            static /*0x160e0b0*/ <>c();
            /*0x32f970*/ <>c();
            /*0x160df40*/ void <RegisterUECatcher>b__0_0(object sender, System.UnhandledExceptionEventArgs e);
        }
    }

    enum HideFlags
    {
        None = 0,
        HideInHierarchy = 1,
        HideInInspector = 2,
        DontSaveInEditor = 4,
        NotEditable = 8,
        DontSaveInBuild = 16,
        DontUnloadUnusedAsset = 32,
        DontSave = 52,
        HideAndDontSave = 61,
    }

    class Object
    {
        static string objectIsNullMessage = "The Object you want to instantiate is null.";
        static string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";
        static /*0x0*/ int OffsetOfInstanceIDInCPlusPlusObject;
        /*0x10*/ nint m_CachedPtr;

        static /*0x15fd3b0*/ Object();
        static /*0x15fd5b0*/ bool op_Implicit(UnityEngine.Object exists);
        static /*0x15fbcd0*/ bool CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs);
        static /*0x15fd280*/ bool IsNativeObjectAlive(UnityEngine.Object o);
        static /*0x15fc950*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x15fc4c0*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        static /*0x15fc7c0*/ UnityEngine.Object Instantiate(UnityEngine.Object original);
        static /*0x15fcbf0*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, bool instantiateInWorldSpace);
        static /*0x2a5510*/ T Instantiate<T>(T original);
        static /*0x2a5510*/ T Instantiate<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x2a5510*/ T Instantiate<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        static /*0x2a5510*/ T Instantiate<T>(T original, UnityEngine.Transform parent);
        static /*0x2a5510*/ T Instantiate<T>(T original, UnityEngine.Transform parent, bool worldPositionStays);
        static /*0x15fbe70*/ void Destroy(UnityEngine.Object obj, float t);
        static /*0x15fbec0*/ void Destroy(UnityEngine.Object obj);
        static /*0x15fbe20*/ void DestroyImmediate(UnityEngine.Object obj, bool allowDestroyingAssets);
        static /*0x15fbdb0*/ void DestroyImmediate(UnityEngine.Object obj);
        static /*0x15fc2a0*/ UnityEngine.Object[] FindObjectsOfType(System.Type type, bool includeInactive);
        static /*0x15fbf30*/ void DontDestroyOnLoad(UnityEngine.Object target);
        static /*0x180cf0*/ T[] FindObjectsOfType<T>();
        static /*0x2a5510*/ T FindObjectOfType<T>();
        static /*0x15fbc70*/ void CheckNullArgument(object arg, string message);
        static /*0x15fc200*/ UnityEngine.Object FindObjectOfType(System.Type type, bool includeInactive);
        static /*0x15fd4a0*/ bool op_Equality(UnityEngine.Object x, UnityEngine.Object y);
        static /*0x15fd640*/ bool op_Inequality(UnityEngine.Object x, UnityEngine.Object y);
        static /*0x15fc490*/ int GetOffsetOfInstanceIDInCPlusPlusObject();
        static /*0x15fd040*/ UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data);
        static /*0x15fcfe0*/ UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, bool worldPositionStays);
        static /*0x15fd1f0*/ UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
        static /*0x15fd0f0*/ UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
        static /*0x15fd370*/ string ToString(UnityEngine.Object obj);
        static /*0x15fc450*/ string GetName(UnityEngine.Object obj);
        static /*0x15fd2b0*/ void SetName(UnityEngine.Object obj, string name);
        static /*0x15fc1c0*/ UnityEngine.Object FindObjectFromInstanceID(int instanceID);
        static /*0x15fc2f0*/ UnityEngine.Object ForceLoadFromInstanceID(int instanceID);
        static /*0x15fd190*/ UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
        static /*0x15fd080*/ UnityEngine.Object Internal_InstantiateSingleWithParent_Injected(UnityEngine.Object data, UnityEngine.Transform parent, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
        /*0x32f970*/ Object();
        /*0x15fc340*/ int GetInstanceID();
        /*0x15fc330*/ int GetHashCode();
        /*0x15fbf70*/ bool Equals(object other);
        /*0x9e3110*/ nint GetCachedPtr();
        /*0x15fd430*/ string get_name();
        /*0x15fd790*/ void set_name(string value);
        /*0x15fd3f0*/ UnityEngine.HideFlags get_hideFlags();
        /*0x15fd750*/ void set_hideFlags(UnityEngine.HideFlags value);
        /*0x15fd300*/ string ToString();
    }

    class UnitySynchronizationContext : System.Threading.SynchronizationContext
    {
        /*0x18*/ System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue;
        /*0x20*/ System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork;
        /*0x28*/ int m_MainThreadID;
        /*0x2c*/ int m_TrackedCount;

        static /*0x1610910*/ void InitializeSynchronizationContext();
        static /*0x1610850*/ void ExecuteTasks();
        static /*0x16106f0*/ bool ExecutePendingTasks(long millisecondsTimeout);
        /*0x1610fe0*/ UnitySynchronizationContext(int mainThreadID);
        /*0x1610f20*/ UnitySynchronizationContext(System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> queue, int mainThreadID);
        /*0x1610c20*/ void Send(System.Threading.SendOrPostCallback callback, object state);
        /*0x1610a30*/ void Post(System.Threading.SendOrPostCallback callback, object state);
        /*0x1610420*/ System.Threading.SynchronizationContext CreateCopy();
        /*0x1610500*/ void Exec();
        /*0x16108b0*/ bool HasPendingTasks();

        struct WorkRequest
        {
            /*0x10*/ System.Threading.SendOrPostCallback m_DelagateCallback;
            /*0x18*/ object m_DelagateState;
            /*0x20*/ System.Threading.ManualResetEvent m_WaitHandle;

            /*0xd4aac0*/ WorkRequest(System.Threading.SendOrPostCallback callback, object state, System.Threading.ManualResetEvent waitHandle);
            /*0x1611870*/ void Invoke();
        }
    }

    class WaitForEndOfFrame : UnityEngine.YieldInstruction
    {
        /*0x32f970*/ WaitForEndOfFrame();
    }

    class WaitForFixedUpdate : UnityEngine.YieldInstruction
    {
        /*0x32f970*/ WaitForFixedUpdate();
    }

    class WaitForSeconds : UnityEngine.YieldInstruction
    {
        /*0x10*/ float m_Seconds;

        /*0x1611810*/ WaitForSeconds(float seconds);
    }

    class WaitForSecondsRealtime : UnityEngine.CustomYieldInstruction
    {
        /*0x10*/ float <waitTime>k__BackingField;
        /*0x14*/ float m_WaitUntilTime;

        /*0x1611740*/ WaitForSecondsRealtime(float time);
        /*0x8c2b50*/ float get_waitTime();
        /*0x10e91a0*/ void set_waitTime(float value);
        /*0x1611770*/ bool get_keepWaiting();
        /*0x1611730*/ void Reset();
    }

    class WaitUntil : UnityEngine.CustomYieldInstruction
    {
        /*0x10*/ System.Func<bool> m_Predicate;

        /*0xa32e30*/ WaitUntil(System.Func<bool> predicate);
        /*0x1611840*/ bool get_keepWaiting();
    }

    class YieldInstruction
    {
        /*0x32f970*/ YieldInstruction();
    }

    class SerializeField : System.Attribute
    {
        /*0x534220*/ SerializeField();
    }

    class SerializeReference : System.Attribute
    {
    }

    class PreferBinarySerialization : System.Attribute
    {
        /*0x534220*/ PreferBinarySerialization();
    }

    interface ISerializationCallbackReceiver
    {
        /*0x180fc0*/ void OnBeforeSerialize();
        /*0x180fc0*/ void OnAfterDeserialize();
    }

    class ComputeBuffer : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;

        static /*0x15f7050*/ nint InitBuffer(int count, int stride, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage);
        static /*0x15f6df0*/ void DestroyBuffer(UnityEngine.ComputeBuffer buf);
        /*0x15f7840*/ ComputeBuffer(int count, int stride);
        /*0x15f7600*/ ComputeBuffer(int count, int stride, UnityEngine.ComputeBufferType type);
        /*0x15f7630*/ ComputeBuffer(int count, int stride, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage, int stackDepth);
        /*0x15f6f90*/ void Finalize();
        /*0x15f6e30*/ void Dispose();
        /*0x15f6ed0*/ void Dispose(bool disposing);
        /*0x15f6e30*/ void Release();
        /*0x15f7870*/ int get_count();
        /*0x15f78b0*/ int get_stride();
        /*0x15f7430*/ void SetData(System.Array data);
        /*0x2a5510*/ void SetData<T>(Unity.Collections.NativeArray<T> data);
        /*0x15f7190*/ void SetData(System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count);
        /*0x15f7120*/ void InternalSetNativeData(nint data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);
        /*0x15f70b0*/ void InternalSetData(System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);
        /*0x15f75b0*/ void set_name(string value);
        /*0x15f75b0*/ void SetName(string name);
    }

    class ComputeShader : UnityEngine.Object
    {
        /*0x15f7990*/ int FindKernel(string name);
        /*0x15f7a40*/ void SetInt(int nameID, int val);
        /*0x15f79e0*/ void SetConstantComputeBuffer(int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
        /*0x15f7940*/ void EnableKeyword(string keyword);
        /*0x15f78f0*/ void DisableKeyword(string keyword);
        /*0x15f79e0*/ void SetConstantBuffer(int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
    }

    class LowerResBlitTexture : UnityEngine.Object
    {
        /*0x32d010*/ void LowerResBlitTextureDontStripMe();
    }

    class PreloadData : UnityEngine.Object
    {
        /*0x32d010*/ void PreloadDataDontStripMe();
    }

    enum OperatingSystemFamily
    {
        Other = 0,
        MacOSX = 1,
        Windows = 2,
        Linux = 3,
    }

    enum DeviceType
    {
        Unknown = 0,
        Handheld = 1,
        Console = 2,
        Desktop = 3,
    }

    class SystemInfo
    {
        static /*0x1609980*/ UnityEngine.OperatingSystemFamily get_operatingSystemFamily();
        static /*0x1609760*/ UnityEngine.DeviceType get_deviceType();
        static /*0x16097c0*/ string get_graphicsDeviceName();
        static /*0x1609820*/ string get_graphicsDeviceVendor();
        static /*0x16097f0*/ UnityEngine.Rendering.GraphicsDeviceType get_graphicsDeviceType();
        static /*0x16098c0*/ bool get_graphicsUVStartsAtTop();
        static /*0x1609890*/ int get_graphicsShaderLevel();
        static /*0x1609a30*/ UnityEngine.Rendering.RenderingThreadingMode get_renderingThreadingMode();
        static /*0x1609790*/ UnityEngine.Rendering.FoveatedRenderingCaps get_foveatedRenderingCaps();
        static /*0x1609a60*/ bool get_hasHiddenSurfaceRemovalOnGPU();
        static /*0x1609eb0*/ bool get_supportsShadows();
        static /*0x1609730*/ UnityEngine.Rendering.CopyTextureSupport get_copyTextureSupport();
        static /*0x1609be0*/ bool get_supportsComputeShaders();
        static /*0x1609d60*/ bool get_supportsRenderTargetArrayIndexFromVertexShader();
        static /*0x1609c40*/ bool get_supportsInstancing();
        static /*0x1609bb0*/ int get_supportedRenderTargetCount();
        static /*0x1609d00*/ int get_supportsMultisampledTextures();
        static /*0x1609c70*/ bool get_supportsMultisampleAutoResolve();
        static /*0x160a0a0*/ bool get_usesReversedZBuffer();
        static /*0x1609b10*/ bool IsValidEnumValue(System.Enum value);
        static /*0x1609d90*/ bool SupportsRenderTextureFormat(UnityEngine.RenderTextureFormat format);
        static /*0x1609f50*/ bool SupportsTextureFormat(UnityEngine.TextureFormat format);
        static /*0x1609950*/ int get_maxTextureSize();
        static /*0x1609920*/ int get_maxRenderTextureSize();
        static /*0x1609c10*/ bool get_supportsGraphicsFence();
        static /*0x1609b80*/ long get_maxGraphicsBufferSize();
        static /*0x160a070*/ bool get_usesLoadStoreActions();
        static /*0x16098f0*/ UnityEngine.HDRDisplaySupportFlags get_hdrDisplaySupportFlags();
        static /*0x1609d30*/ bool get_supportsMultiview();
        static /*0x1609ee0*/ bool get_supportsStoreAndResolveAction();
        static /*0x1609ca0*/ bool get_supportsMultisampleResolveDepth();
        static /*0x1609cd0*/ bool get_supportsMultisampleResolveStencil();
        static /*0x1609980*/ UnityEngine.OperatingSystemFamily GetOperatingSystemFamily();
        static /*0x1609760*/ UnityEngine.DeviceType GetDeviceType();
        static /*0x16097c0*/ string GetGraphicsDeviceName();
        static /*0x1609820*/ string GetGraphicsDeviceVendor();
        static /*0x16097f0*/ UnityEngine.Rendering.GraphicsDeviceType GetGraphicsDeviceType();
        static /*0x16098c0*/ bool GetGraphicsUVStartsAtTop();
        static /*0x1609890*/ int GetGraphicsShaderLevel();
        static /*0x1609a30*/ UnityEngine.Rendering.RenderingThreadingMode GetRenderingThreadingMode();
        static /*0x1609790*/ UnityEngine.Rendering.FoveatedRenderingCaps GetFoveatedRenderingCaps();
        static /*0x1609a60*/ bool HasHiddenSurfaceRemovalOnGPU();
        static /*0x1609eb0*/ bool SupportsShadows();
        static /*0x1609730*/ UnityEngine.Rendering.CopyTextureSupport GetCopyTextureSupport();
        static /*0x1609be0*/ bool SupportsComputeShaders();
        static /*0x1609d60*/ bool SupportsRenderTargetArrayIndexFromVertexShader();
        static /*0x1609c40*/ bool SupportsInstancing();
        static /*0x1609bb0*/ int SupportedRenderTargetCount();
        static /*0x1609d00*/ int SupportsMultisampledTextures();
        static /*0x1609c70*/ bool SupportsMultisampleAutoResolve();
        static /*0x160a0a0*/ bool UsesReversedZBuffer();
        static /*0x1609a90*/ bool HasRenderTextureNative(UnityEngine.RenderTextureFormat format);
        static /*0x1609f10*/ bool SupportsTextureFormatNative(UnityEngine.TextureFormat format);
        static /*0x1609950*/ int GetMaxTextureSize();
        static /*0x1609920*/ int GetMaxRenderTextureSize();
        static /*0x1609c10*/ bool SupportsGPUFence();
        static /*0x1609b80*/ long MaxGraphicsBufferSize();
        static /*0x1609ad0*/ bool IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage);
        static /*0x16096f0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage);
        static /*0x1609850*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat format);
        static /*0x16099f0*/ int GetRenderTextureSupportedMSAASampleCount(UnityEngine.RenderTextureDescriptor desc);
        static /*0x160a070*/ bool UsesLoadStoreActions();
        static /*0x16098f0*/ UnityEngine.HDRDisplaySupportFlags GetHDRDisplaySupportFlags();
        static /*0x1609d30*/ bool SupportsMultiview();
        static /*0x1609ee0*/ bool SupportsStoreAndResolveAction();
        static /*0x1609ca0*/ bool SupportsMultisampleResolveDepth();
        static /*0x1609cd0*/ bool SupportsMultisampleResolveStencil();
        static /*0x16099b0*/ int GetRenderTextureSupportedMSAASampleCount_Injected(ref UnityEngine.RenderTextureDescriptor desc);
    }

    class Time
    {
        static /*0x160a720*/ float get_time();
        static /*0x160a5d0*/ float get_deltaTime();
        static /*0x160a780*/ float get_unscaledTime();
        static /*0x160a750*/ float get_unscaledDeltaTime();
        static /*0x160a600*/ float get_fixedDeltaTime();
        static /*0x160a7b0*/ void set_maximumDeltaTime(float value);
        static /*0x160a6c0*/ float get_smoothDeltaTime();
        static /*0x160a6f0*/ float get_timeScale();
        static /*0x160a7f0*/ void set_timeScale(float value);
        static /*0x160a630*/ int get_frameCount();
        static /*0x160a690*/ int get_renderedFrameCount();
        static /*0x160a660*/ float get_realtimeSinceStartup();
    }

    struct TouchScreenKeyboard_InternalConstructorHelperArguments
    {
        /*0x10*/ uint keyboardType;
        /*0x14*/ uint autocorrection;
        /*0x18*/ uint multiline;
        /*0x1c*/ uint secure;
        /*0x20*/ uint alert;
        /*0x24*/ int characterLimit;
    }

    class TouchScreenKeyboard
    {
        static /*0x0*/ bool <disableInPlaceEditing>k__BackingField;
        /*0x10*/ nint m_Ptr;

        static /*0x160aa00*/ void Internal_Destroy(nint ptr);
        static /*0x160ad60*/ nint TouchScreenKeyboard_InternalConstructorHelper(ref UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder);
        static /*0x160b020*/ bool get_isSupported();
        static /*0x160afb0*/ bool get_disableInPlaceEditing();
        static /*0x160aff0*/ bool get_isInPlaceEditingAllowed();
        static /*0x160aa40*/ UnityEngine.TouchScreenKeyboard Open(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit);
        static /*0x160aba0*/ UnityEngine.TouchScreenKeyboard Open(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure);
        static /*0x160b240*/ void set_hideInput(bool value);
        static /*0x160a9b0*/ void GetSelection(ref int start, ref int length);
        static /*0x160ad20*/ void SetSelection(int start, int length);
        /*0x160adc0*/ TouchScreenKeyboard(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit);
        /*0x160a830*/ void Destroy();
        /*0x160a8d0*/ void Finalize();
        /*0x160b170*/ string get_text();
        /*0x160b380*/ void set_text(string value);
        /*0x160aef0*/ bool get_active();
        /*0x160b1b0*/ void set_active(bool value);
        /*0x160b130*/ UnityEngine.TouchScreenKeyboard.Status get_status();
        /*0x160b200*/ void set_characterLimit(int value);
        /*0x160af30*/ bool get_canGetSelection();
        /*0x160af70*/ bool get_canSetSelection();
        /*0x160b0e0*/ UnityEngine.RangeInt get_selection();
        /*0x160b280*/ void set_selection(UnityEngine.RangeInt value);

        enum Status
        {
            Visible = 0,
            Done = 1,
            Canceled = 2,
            LostFocus = 3,
        }
    }

    enum TouchScreenKeyboardType
    {
        Default = 0,
        ASCIICapable = 1,
        NumbersAndPunctuation = 2,
        URL = 3,
        NumberPad = 4,
        PhonePad = 5,
        NamePhonePad = 6,
        EmailAddress = 7,
        NintendoNetworkAccount = 8,
        Social = 9,
        Search = 10,
        DecimalPad = 11,
        OneTimeCode = 12,
    }

    class UINumericFieldsUtils
    {
        static /*0x0*/ string k_AllowedCharactersForFloat;
        static /*0x8*/ string k_AllowedCharactersForInt;
        static /*0x10*/ string k_DoubleFieldFormatString;
        static /*0x18*/ string k_FloatFieldFormatString;
        static /*0x20*/ string k_IntFieldFormatString;

        static /*0x160ea80*/ UINumericFieldsUtils();
        static /*0x160e190*/ bool TryConvertStringToDouble(string str, ref double value, ref UnityEngine.ExpressionEvaluator.Expression expr);
        static /*0x160e320*/ bool TryConvertStringToDouble(string str, string initialValueAsString, ref double value, ref UnityEngine.ExpressionEvaluator.Expression expression);
        static /*0x160e430*/ bool TryConvertStringToFloat(string str, string initialValueAsString, ref float value, ref UnityEngine.ExpressionEvaluator.Expression expression);
        static /*0x160e790*/ bool TryConvertStringToLong(string str, ref long value, ref UnityEngine.ExpressionEvaluator.Expression expr);
        static /*0x160e640*/ bool TryConvertStringToLong(string str, string initialValueAsString, ref long value, ref UnityEngine.ExpressionEvaluator.Expression expression);
        static /*0x160e8b0*/ bool TryConvertStringToULong(string str, ref ulong value, ref UnityEngine.ExpressionEvaluator.Expression expr);
        static /*0x160e930*/ bool TryConvertStringToULong(string str, string initialValueAsString, ref ulong value, ref UnityEngine.ExpressionEvaluator.Expression expression);
        static /*0x160e5a0*/ bool TryConvertStringToInt(string str, string initialValueAsString, ref int value, ref UnityEngine.ExpressionEvaluator.Expression expression);
        static /*0x160e810*/ bool TryConvertStringToUInt(string str, string initialValueAsString, ref uint value, ref UnityEngine.ExpressionEvaluator.Expression expression);
    }

    enum DrivenTransformProperties
    {
        None = 0,
        All = -1,
        AnchoredPositionX = 2,
        AnchoredPositionY = 4,
        AnchoredPositionZ = 8,
        Rotation = 16,
        ScaleX = 32,
        ScaleY = 64,
        ScaleZ = 128,
        AnchorMinX = 256,
        AnchorMinY = 512,
        AnchorMaxX = 1024,
        AnchorMaxY = 2048,
        SizeDeltaX = 4096,
        SizeDeltaY = 8192,
        PivotX = 16384,
        PivotY = 32768,
        AnchoredPosition = 6,
        AnchoredPosition3D = 14,
        Scale = 224,
        AnchorMin = 768,
        AnchorMax = 3072,
        Anchors = 3840,
        SizeDelta = 12288,
        Pivot = 49152,
    }

    struct DrivenRectTransformTracker
    {
        /*0x32d010*/ void Add(UnityEngine.Object driver, UnityEngine.RectTransform rectTransform, UnityEngine.DrivenTransformProperties drivenProperties);
        /*0x32d010*/ void Clear();
    }

    class RectTransform : UnityEngine.Transform
    {
        static /*0x0*/ UnityEngine.RectTransform.ReapplyDrivenProperties reapplyDrivenProperties;

        static /*0x1602440*/ void add_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value);
        static /*0x1602ac0*/ void remove_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value);
        static /*0x1601f90*/ void SendReapplyDrivenProperties(UnityEngine.RectTransform driven);
        /*0x15b84e0*/ RectTransform();
        /*0x16029d0*/ UnityEngine.Rect get_rect();
        /*0x16025f0*/ UnityEngine.Vector2 get_anchorMin();
        /*0x1602c60*/ void set_anchorMin(UnityEngine.Vector2 value);
        /*0x1602550*/ UnityEngine.Vector2 get_anchorMax();
        /*0x1602bd0*/ void set_anchorMax(UnityEngine.Vector2 value);
        /*0x1602690*/ UnityEngine.Vector2 get_anchoredPosition();
        /*0x1602cf0*/ void set_anchoredPosition(UnityEngine.Vector2 value);
        /*0x1602a70*/ UnityEngine.Vector2 get_sizeDelta();
        /*0x16032d0*/ void set_sizeDelta(UnityEngine.Vector2 value);
        /*0x1602930*/ UnityEngine.Vector2 get_pivot();
        /*0x1603240*/ void set_pivot(UnityEngine.Vector2 value);
        /*0x1602800*/ UnityEngine.Vector2 get_offsetMin();
        /*0x1602f80*/ void set_offsetMin(UnityEngine.Vector2 value);
        /*0x16026e0*/ UnityEngine.Vector2 get_offsetMax();
        /*0x1602d30*/ void set_offsetMax(UnityEngine.Vector2 value);
        /*0x1601a20*/ void GetLocalCorners(UnityEngine.Vector3[] fourCornersArray);
        /*0x1601cf0*/ void GetWorldCorners(UnityEngine.Vector3[] fourCornersArray);
        /*0x1601ff0*/ void SetSizeWithCurrentAnchors(UnityEngine.RectTransform.Axis axis, float size);
        /*0x1601b60*/ UnityEngine.Vector2 GetParentSize();
        /*0x1602980*/ void get_rect_Injected(ref UnityEngine.Rect ret);
        /*0x16025a0*/ void get_anchorMin_Injected(ref UnityEngine.Vector2 ret);
        /*0x1602c10*/ void set_anchorMin_Injected(ref UnityEngine.Vector2 value);
        /*0x1602500*/ void get_anchorMax_Injected(ref UnityEngine.Vector2 ret);
        /*0x1602b80*/ void set_anchorMax_Injected(ref UnityEngine.Vector2 value);
        /*0x1602640*/ void get_anchoredPosition_Injected(ref UnityEngine.Vector2 ret);
        /*0x1602ca0*/ void set_anchoredPosition_Injected(ref UnityEngine.Vector2 value);
        /*0x1602a20*/ void get_sizeDelta_Injected(ref UnityEngine.Vector2 ret);
        /*0x1603280*/ void set_sizeDelta_Injected(ref UnityEngine.Vector2 value);
        /*0x16028e0*/ void get_pivot_Injected(ref UnityEngine.Vector2 ret);
        /*0x16031f0*/ void set_pivot_Injected(ref UnityEngine.Vector2 value);

        enum Axis
        {
            Horizontal = 0,
            Vertical = 1,
        }

        class ReapplyDrivenProperties : System.MulticastDelegate
        {
            /*0xf0a420*/ ReapplyDrivenProperties(object object, nint method);
            /*0x720980*/ void Invoke(UnityEngine.RectTransform driven);
        }
    }

    class Transform : UnityEngine.Component, System.Collections.IEnumerable
    {
        static /*0x160bde0*/ UnityEngine.Transform FindRelativeTransformWithPath(UnityEngine.Transform transform, string path, bool isActiveOnly);
        /*0x15b84e0*/ Transform();
        /*0x160d5c0*/ UnityEngine.Vector3 get_position();
        /*0x160dcd0*/ void set_position(UnityEngine.Vector3 value);
        /*0x160d290*/ UnityEngine.Vector3 get_localPosition();
        /*0x160da30*/ void set_localPosition(UnityEngine.Vector3 value);
        /*0x160cf90*/ UnityEngine.Vector3 get_eulerAngles();
        /*0x160d900*/ void set_eulerAngles(UnityEngine.Vector3 value);
        /*0x160d170*/ UnityEngine.Vector3 get_localEulerAngles();
        /*0x160d610*/ UnityEngine.Vector3 get_right();
        /*0x160d780*/ UnityEngine.Vector3 get_up();
        /*0x160d060*/ UnityEngine.Vector3 get_forward();
        /*0x160d730*/ UnityEngine.Quaternion get_rotation();
        /*0x160dd70*/ void set_rotation(UnityEngine.Quaternion value);
        /*0x160d330*/ UnityEngine.Quaternion get_localRotation();
        /*0x160dad0*/ void set_localRotation(UnityEngine.Quaternion value);
        /*0x160d3d0*/ UnityEngine.Vector3 get_localScale();
        /*0x160db70*/ void set_localScale(UnityEngine.Vector3 value);
        /*0x160bf90*/ UnityEngine.Transform get_parent();
        /*0x160dbc0*/ void set_parent(UnityEngine.Transform value);
        /*0x160bf90*/ UnityEngine.Transform get_parentInternal();
        /*0x160c870*/ void set_parentInternal(UnityEngine.Transform value);
        /*0x160bf90*/ UnityEngine.Transform GetParent();
        /*0x160c870*/ void SetParent(UnityEngine.Transform p);
        /*0x160c8c0*/ void SetParent(UnityEngine.Transform parent, bool worldPositionStays);
        /*0x160d8a0*/ UnityEngine.Matrix4x4 get_worldToLocalMatrix();
        /*0x160d470*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
        /*0x160c980*/ void SetPositionAndRotation(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        /*0x160c810*/ void SetLocalPositionAndRotation(UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation);
        /*0x160cca0*/ void Translate(UnityEngine.Vector3 translation, UnityEngine.Space relativeTo);
        /*0x160cba0*/ void Translate(UnityEngine.Vector3 translation);
        /*0x160ce30*/ void Translate(float x, float y, float z);
        /*0x160c180*/ void Rotate(UnityEngine.Vector3 eulers, UnityEngine.Space relativeTo);
        /*0x160c120*/ void Rotate(UnityEngine.Vector3 eulers);
        /*0x160c150*/ void Rotate(float xAngle, float yAngle, float zAngle);
        /*0x160ca80*/ UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3 direction);
        /*0x160cb40*/ UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 position);
        /*0x160c070*/ UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 position);
        /*0x160cf50*/ int get_childCount();
        /*0x160c730*/ void SetAsFirstSibling();
        /*0x160c770*/ void SetAsLastSibling();
        /*0x160c9e0*/ void SetSiblingIndex(int index);
        /*0x160bfd0*/ int GetSiblingIndex();
        /*0x160be40*/ UnityEngine.Transform Find(string n);
        /*0x160d520*/ UnityEngine.Vector3 get_lossyScale();
        /*0x160c0d0*/ bool IsChildOf(UnityEngine.Transform parent);
        /*0x160d130*/ bool get_hasChanged();
        /*0x160d990*/ void set_hasChanged(bool value);
        /*0x160bf20*/ System.Collections.IEnumerator GetEnumerator();
        /*0x160bee0*/ UnityEngine.Transform GetChild(int index);
        /*0x160d570*/ void get_position_Injected(ref UnityEngine.Vector3 ret);
        /*0x160dc80*/ void set_position_Injected(ref UnityEngine.Vector3 value);
        /*0x160d240*/ void get_localPosition_Injected(ref UnityEngine.Vector3 ret);
        /*0x160d9e0*/ void set_localPosition_Injected(ref UnityEngine.Vector3 value);
        /*0x160d6e0*/ void get_rotation_Injected(ref UnityEngine.Quaternion ret);
        /*0x160dd20*/ void set_rotation_Injected(ref UnityEngine.Quaternion value);
        /*0x160d2e0*/ void get_localRotation_Injected(ref UnityEngine.Quaternion ret);
        /*0x160da80*/ void set_localRotation_Injected(ref UnityEngine.Quaternion value);
        /*0x160d380*/ void get_localScale_Injected(ref UnityEngine.Vector3 ret);
        /*0x160db20*/ void set_localScale_Injected(ref UnityEngine.Vector3 value);
        /*0x160d850*/ void get_worldToLocalMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        /*0x160d420*/ void get_localToWorldMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        /*0x160c920*/ void SetPositionAndRotation_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
        /*0x160c7b0*/ void SetLocalPositionAndRotation_Injected(ref UnityEngine.Vector3 localPosition, ref UnityEngine.Quaternion localRotation);
        /*0x160ca20*/ void TransformDirection_Injected(ref UnityEngine.Vector3 direction, ref UnityEngine.Vector3 ret);
        /*0x160cae0*/ void TransformPoint_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        /*0x160c010*/ void InverseTransformPoint_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        /*0x160d4d0*/ void get_lossyScale_Injected(ref UnityEngine.Vector3 ret);

        class Enumerator : System.Collections.IEnumerator
        {
            /*0x10*/ UnityEngine.Transform outer;
            /*0x18*/ int currentIndex;

            /*0x15f8680*/ Enumerator(UnityEngine.Transform outer);
            /*0x15f86c0*/ object get_Current();
            /*0x15f8620*/ bool MoveNext();
            /*0xf64680*/ void Reset();
        }
    }

    enum SpriteMaskInteraction
    {
        None = 0,
        VisibleInsideMask = 1,
        VisibleOutsideMask = 2,
    }

    class SpriteRenderer : UnityEngine.Renderer
    {
        /*0x18*/ UnityEngine.Events.UnityEvent<UnityEngine.SpriteRenderer> m_SpriteChangeEvent;

        /*0x31c640*/ SpriteRenderer();
        /*0x1606e30*/ void InvokeSpriteChanged();
        /*0x1606ff0*/ UnityEngine.Sprite get_sprite();
        /*0x16071a0*/ void set_sprite(UnityEngine.Sprite value);
        /*0x1606fa0*/ UnityEngine.Vector2 get_size();
        /*0x1607160*/ void set_size(UnityEngine.Vector2 value);
        /*0x1606f00*/ UnityEngine.Color get_color();
        /*0x1607080*/ void set_color(UnityEngine.Color value);
        /*0x16070d0*/ void set_maskInteraction(UnityEngine.SpriteMaskInteraction value);
        /*0x1606f50*/ void get_size_Injected(ref UnityEngine.Vector2 ret);
        /*0x1607110*/ void set_size_Injected(ref UnityEngine.Vector2 value);
        /*0x1606eb0*/ void get_color_Injected(ref UnityEngine.Color ret);
        /*0x1607030*/ void set_color_Injected(ref UnityEngine.Color value);
    }

    enum SpriteMeshType
    {
        FullRect = 0,
        Tight = 1,
    }

    enum SpritePackingRotation
    {
        None = 0,
        FlipHorizontal = 1,
        FlipVertical = 2,
        Rotate180 = 3,
        Any = 15,
    }

    struct SecondarySpriteTexture
    {
        /*0x10*/ string name;
        /*0x18*/ UnityEngine.Texture2D texture;
    }

    class Sprite : UnityEngine.Object
    {
        static /*0x1607270*/ UnityEngine.Sprite CreateSprite(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[] secondaryTexture);
        static /*0x16075b0*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape);
        static /*0x1607620*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[] secondaryTextures);
        static /*0x1607310*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border);
        static /*0x1607370*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType);
        static /*0x1607c60*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude);
        static /*0x16074f0*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit);
        static /*0x1607440*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot);
        static /*0x16071f0*/ UnityEngine.Sprite CreateSprite_Injected(UnityEngine.Texture2D texture, ref UnityEngine.Rect rect, ref UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, ref UnityEngine.Vector4 border, bool generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[] secondaryTexture);
        /*0x1608030*/ Sprite();
        /*0x1607eb0*/ int GetPackingRotation();
        /*0x1607e70*/ int GetPacked();
        /*0x1607fe0*/ UnityEngine.Rect GetTextureRect();
        /*0x1607d80*/ UnityEngine.Vector4 GetInnerUVs();
        /*0x1607e20*/ UnityEngine.Vector4 GetOuterUVs();
        /*0x1607f40*/ UnityEngine.Vector4 GetPadding();
        /*0x16081b0*/ UnityEngine.Bounds get_bounds();
        /*0x1608380*/ UnityEngine.Rect get_rect();
        /*0x1608110*/ UnityEngine.Vector4 get_border();
        /*0x1608430*/ UnityEngine.Texture2D get_texture();
        /*0x16082f0*/ float get_pixelsPerUnit();
        /*0x1608080*/ UnityEngine.Texture2D get_associatedAlphaSplitTexture();
        /*0x16082a0*/ UnityEngine.Vector2 get_pivot();
        /*0x1608210*/ bool get_packed();
        /*0x1607eb0*/ UnityEngine.SpritePackingRotation get_packingRotation();
        /*0x16083d0*/ UnityEngine.Rect get_textureRect();
        /*0x16084f0*/ UnityEngine.Vector2[] get_vertices();
        /*0x1608470*/ ushort[] get_triangles();
        /*0x16084b0*/ UnityEngine.Vector2[] get_uv();
        /*0x1607f90*/ void GetTextureRect_Injected(ref UnityEngine.Rect ret);
        /*0x1607d30*/ void GetInnerUVs_Injected(ref UnityEngine.Vector4 ret);
        /*0x1607dd0*/ void GetOuterUVs_Injected(ref UnityEngine.Vector4 ret);
        /*0x1607ef0*/ void GetPadding_Injected(ref UnityEngine.Vector4 ret);
        /*0x1608160*/ void get_bounds_Injected(ref UnityEngine.Bounds ret);
        /*0x1608330*/ void get_rect_Injected(ref UnityEngine.Rect ret);
        /*0x16080c0*/ void get_border_Injected(ref UnityEngine.Vector4 ret);
        /*0x1608250*/ void get_pivot_Injected(ref UnityEngine.Vector2 ret);
    }

    namespace _Scripting
    {
        namespace APIUpdating
        {
            class APIUpdaterRuntimeHelpers
            {
                static /*0x15f0e20*/ bool GetMovedFromAttributeDataForType(System.Type sourceType, ref string assembly, ref string nsp, ref string klass);
                static /*0x15f0fb0*/ bool GetObsoleteTypeRedirection(System.Type sourceType, ref string assemblyName, ref string nsp, ref string className);
            }
        }
    }

    namespace Sprites
    {
        class DataUtility
        {
            static /*0x15f7d20*/ UnityEngine.Vector4 GetInnerUV(UnityEngine.Sprite sprite);
            static /*0x15f7ea0*/ UnityEngine.Vector4 GetOuterUV(UnityEngine.Sprite sprite);
            static /*0x15f7f10*/ UnityEngine.Vector4 GetPadding(UnityEngine.Sprite sprite);
            static /*0x15f7d90*/ UnityEngine.Vector2 GetMinSize(UnityEngine.Sprite sprite);
        }
    }

    namespace U2D
    {
        class Light2DBase : UnityEngine.MonoBehaviour
        {
            /*0x15b84e0*/ Light2DBase();
        }

        class PixelPerfectRendering
        {
            static /*0x15ff430*/ void set_pixelSnapSpacing(float value);
        }

        struct SpriteBone
        {
            /*0x10*/ string m_Name;
            /*0x18*/ string m_Guid;
            /*0x20*/ UnityEngine.Vector3 m_Position;
            /*0x2c*/ UnityEngine.Quaternion m_Rotation;
            /*0x3c*/ float m_Length;
            /*0x40*/ int m_ParentId;
            /*0x44*/ UnityEngine.Color32 m_Color;

            /*0x69af20*/ string get_name();
            /*0xfbbe70*/ string get_guid();
            /*0x16062d0*/ UnityEngine.Vector3 get_position();
            /*0x16062f0*/ UnityEngine.Quaternion get_rotation();
            /*0x16062c0*/ int get_parentId();
        }

        struct SpriteChannelInfo
        {
            /*0x10*/ nint m_Buffer;
            /*0x18*/ int m_Count;
            /*0x1c*/ int m_Offset;
            /*0x20*/ int m_Stride;

            /*0x1606300*/ void* get_buffer();
            /*0xb73eb0*/ int get_count();
            /*0xba1820*/ int get_offset();
            /*0x15bceb0*/ int get_stride();
        }

        class SpriteDataAccessExtensions
        {
            static /*0x1784c0*/ void CheckAttributeTypeMatchesAndThrow<T>(UnityEngine.Rendering.VertexAttribute channel);
            static /*0x2a5510*/ Unity.Collections.NativeSlice<T> GetVertexAttribute<T>(UnityEngine.Sprite sprite, UnityEngine.Rendering.VertexAttribute channel);
            static /*0x16063c0*/ Unity.Collections.NativeArray<UnityEngine.Matrix4x4> GetBindPoses(UnityEngine.Sprite sprite);
            static /*0x1606610*/ Unity.Collections.NativeArray<ushort> GetIndices(UnityEngine.Sprite sprite);
            static /*0x1606470*/ UnityEngine.U2D.SpriteBone[] GetBones(UnityEngine.Sprite sprite);
            static /*0x1606740*/ bool HasVertexAttribute(UnityEngine.Sprite sprite, UnityEngine.Rendering.VertexAttribute channel);
            static /*0x1606700*/ int GetVertexCount(UnityEngine.Sprite sprite);
            static /*0x1606360*/ UnityEngine.U2D.SpriteChannelInfo GetBindPoseInfo(UnityEngine.Sprite sprite);
            static /*0x16065b0*/ UnityEngine.U2D.SpriteChannelInfo GetIndicesInfo(UnityEngine.Sprite sprite);
            static /*0x1606500*/ UnityEngine.U2D.SpriteChannelInfo GetChannelInfo(UnityEngine.Sprite sprite, UnityEngine.Rendering.VertexAttribute channel);
            static /*0x1606470*/ UnityEngine.U2D.SpriteBone[] GetBoneInfo(UnityEngine.Sprite sprite);
            static /*0x16066c0*/ int GetPrimaryVertexStreamSize(UnityEngine.Sprite sprite);
            static /*0x1606310*/ void GetBindPoseInfo_Injected(UnityEngine.Sprite sprite, ref UnityEngine.U2D.SpriteChannelInfo ret);
            static /*0x1606560*/ void GetIndicesInfo_Injected(UnityEngine.Sprite sprite, ref UnityEngine.U2D.SpriteChannelInfo ret);
            static /*0x16064b0*/ void GetChannelInfo_Injected(UnityEngine.Sprite sprite, UnityEngine.Rendering.VertexAttribute channel, ref UnityEngine.U2D.SpriteChannelInfo ret);
        }

        class SpriteRendererDataAccessExtensions
        {
            static /*0x1606a50*/ void SetDeformableBuffer(UnityEngine.SpriteRenderer spriteRenderer, Unity.Collections.NativeArray<byte> src);
            static /*0x1606860*/ void SetBatchDeformableBufferAndLocalAABBArray(UnityEngine.SpriteRenderer[] spriteRenderers, Unity.Collections.NativeArray<nint> buffers, Unity.Collections.NativeArray<int> bufferSizes, Unity.Collections.NativeArray<UnityEngine.Bounds> bounds);
            static /*0x16067c0*/ bool IsUsingDeformableBuffer(UnityEngine.SpriteRenderer spriteRenderer, nint buffer);
            static /*0x1606780*/ void DeactivateDeformableBuffer(UnityEngine.SpriteRenderer renderer);
            static /*0x1606de0*/ void SetLocalAABB(UnityEngine.SpriteRenderer renderer, UnityEngine.Bounds aabb);
            static /*0x1606d30*/ void SetDeformableBuffer(UnityEngine.SpriteRenderer spriteRenderer, void* src, int count);
            static /*0x16069e0*/ void SetBatchDeformableBufferAndLocalAABBArray(UnityEngine.SpriteRenderer[] spriteRenderers, void* buffers, void* bufferSizes, void* bounds, int count);
            static /*0x1606810*/ bool IsUsingDeformableBuffer(UnityEngine.SpriteRenderer spriteRenderer, void* buffer);
            static /*0x1606d90*/ void SetLocalAABB_Injected(UnityEngine.SpriteRenderer renderer, ref UnityEngine.Bounds aabb);
        }

        class SpriteAtlasManager
        {
            static /*0x0*/ System.Action<string, System.Action<UnityEngine.U2D.SpriteAtlas>> atlasRequested;
            static /*0x8*/ System.Action<UnityEngine.U2D.SpriteAtlas> atlasRegistered;

            static /*0x1606000*/ bool RequestAtlas(string tag);
            static /*0x16060b0*/ void add_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value);
            static /*0x1606190*/ void remove_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value);
            static /*0x1605f60*/ void PostRegisteredAtlas(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x1605fc0*/ void Register(UnityEngine.U2D.SpriteAtlas spriteAtlas);
        }

        class SpriteAtlas : UnityEngine.Object
        {
            /*0x1606270*/ bool CanBindTo(UnityEngine.Sprite sprite);
        }
    }

    namespace Profiling
    {
        class Profiler
        {
            static /*0x1601690*/ long GetRuntimeMemorySizeLong(UnityEngine.Object o);
        }

        class Recorder
        {
            static Unity.Profiling.ProfilerRecorderOptions s_RecorderDefaultOptions = 153;
            static /*0x0*/ UnityEngine.Profiling.Recorder s_InvalidRecorder;
            /*0x10*/ Unity.Profiling.ProfilerRecorder m_RecorderCPU;
            /*0x18*/ Unity.Profiling.ProfilerRecorder m_RecorderGPU;

            static /*0x16017c0*/ Recorder();
            /*0x32f970*/ Recorder();
            /*0x1601830*/ Recorder(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle);
            /*0x16016e0*/ void Finalize();
            /*0x1601920*/ bool get_enabled();
            /*0x1601750*/ void set_enabled(bool value);
            /*0x16018f0*/ long get_elapsedNanoseconds();
            /*0x1601930*/ long get_gpuElapsedNanoseconds();
            /*0x16019c0*/ int get_sampleBlockCount();
            /*0x1601960*/ int get_gpuSampleBlockCount();
            /*0x1601750*/ void SetEnabled(bool state);
        }

        class Sampler
        {
            static /*0x0*/ UnityEngine.Profiling.Sampler s_InvalidSampler;
            /*0x10*/ nint m_Ptr;

            static /*0x1603f50*/ Sampler();
            /*0x32f970*/ Sampler();
            /*0x1603fc0*/ bool get_isValid();
            /*0x1603e20*/ UnityEngine.Profiling.Recorder GetRecorder();
        }

        class CustomSampler : UnityEngine.Profiling.Sampler
        {
            static /*0x0*/ UnityEngine.Profiling.CustomSampler s_InvalidCustomSampler;

            static /*0x15f7bd0*/ CustomSampler();
            static /*0x15f7ad0*/ UnityEngine.Profiling.CustomSampler Create(string name, bool collectGpuData);
            /*0x15f7c70*/ CustomSampler();
            /*0x15f7cc0*/ CustomSampler(nint ptr);
        }
    }

    namespace Jobs
    {
        interface IJobParallelForTransform
        {
            /*0x2a5510*/ void Execute(int index, UnityEngine.Jobs.TransformAccess transform);
        }

        class IJobParallelForTransformExtensions
        {
            static nint GetReflectionData<T>();
            static /*0x2a5510*/ Unity.Jobs.JobHandle Schedule<T>(T jobData, UnityEngine.Jobs.TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn);

            struct TransformParallelForLoopStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x180ff0*/ TransformParallelForLoopStruct();
                static /*0x180ff0*/ void Initialize();
                static /*0x1830f0*/ void Execute(ref T jobData, nint jobData2, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

                struct TransformJobData<T>
                {
                    /*0x0*/ nint TransformAccessArray;
                    /*0x0*/ int IsReadOnly;
                }

                class ExecuteJobFunction<T> : System.MulticastDelegate
                {
                    ExecuteJobFunction(object object, nint method);
                    void Invoke(ref T jobData, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);
                }
            }
        }

        struct TransformAccess
        {
            /*0x10*/ nint hierarchy;
            /*0x18*/ int index;

            static /*0x160ba70*/ void GetPosition(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Vector3 p);
            static /*0x160bac0*/ void GetRotation(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Quaternion r);
            static /*0x160b9d0*/ void GetLocalScale(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Vector3 r);
            static /*0x160ba20*/ void GetLocalToWorldMatrix(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Matrix4x4 m);
            static /*0x160bb10*/ void GetWorldToLocalMatrix(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Matrix4x4 m);
            /*0x160bc70*/ UnityEngine.Vector3 get_position();
            /*0x160bce0*/ UnityEngine.Quaternion get_rotation();
            /*0x160bb60*/ UnityEngine.Vector3 get_localScale();
            /*0x160bbd0*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
            /*0x160bd40*/ UnityEngine.Matrix4x4 get_worldToLocalMatrix();
        }

        struct TransformAccessArray : System.IDisposable
        {
            /*0x10*/ nint m_TransformArray;

            static /*0x160b470*/ void Allocate(int capacity, int desiredJobCount, ref UnityEngine.Jobs.TransformAccessArray array);
            static /*0x160b4d0*/ nint Create(int capacity, int desiredJobCount);
            static /*0x160b510*/ void DestroyTransformAccessArray(nint transformArray);
            static /*0x160b7b0*/ void SetTransforms(nint transformArrayIntPtr, UnityEngine.Transform[] transforms);
            static /*0x160b3d0*/ void Add(nint transformArrayIntPtr, UnityEngine.Transform transform);
            static /*0x160b730*/ void RemoveAtSwapBack(nint transformArrayIntPtr, int index);
            static /*0x160b670*/ nint GetSortedTransformAccess(nint transformArrayIntPtr);
            static /*0x160b630*/ nint GetSortedToUserIndex(nint transformArrayIntPtr);
            static /*0x160b5f0*/ int GetLength(nint transformArrayIntPtr);
            static /*0x160b5b0*/ int GetCapacity(nint transformArrayIntPtr);
            static /*0x160b770*/ void SetCapacity(nint transformArrayIntPtr, int capacity);
            static /*0x160b6b0*/ UnityEngine.Transform GetTransform(nint transformArrayIntPtr, int index);
            /*0x160b850*/ TransformAccessArray(int capacity, int desiredJobCount);
            /*0x160b940*/ bool get_isCreated();
            /*0x160b550*/ void Dispose();
            /*0x69af20*/ nint GetTransformAccessArrayForSchedule();
            /*0x160b8c0*/ UnityEngine.Transform get_Item(int index);
            /*0x160b900*/ int get_capacity();
            /*0x160b990*/ void set_capacity(int value);
            /*0x160b950*/ int get_length();
            /*0x160b420*/ void Add(UnityEngine.Transform transform);
            /*0x160b6f0*/ void RemoveAtSwapBack(int index);
            /*0x160b800*/ void SetTransforms(UnityEngine.Transform[] transforms);
        }
    }

    namespace Windows
    {
        namespace Speech
        {
            class PhraseRecognitionSystem
            {
                static /*0x0*/ UnityEngine.Windows.Speech.PhraseRecognitionSystem.ErrorDelegate OnError;
                static /*0x8*/ UnityEngine.Windows.Speech.PhraseRecognitionSystem.StatusDelegate OnStatusChanged;

                static /*0x15fef70*/ void PhraseRecognitionSystem_InvokeErrorEvent(UnityEngine.Windows.Speech.SpeechError errorCode);
                static /*0x15fefd0*/ void PhraseRecognitionSystem_InvokeStatusChangedEvent(UnityEngine.Windows.Speech.SpeechSystemStatus status);

                class ErrorDelegate : System.MulticastDelegate
                {
                    /*0x721150*/ ErrorDelegate(object object, nint method);
                    /*0x720980*/ void Invoke(UnityEngine.Windows.Speech.SpeechError errorCode);
                }

                class StatusDelegate : System.MulticastDelegate
                {
                    /*0x721150*/ StatusDelegate(object object, nint method);
                    /*0x720980*/ void Invoke(UnityEngine.Windows.Speech.SpeechSystemStatus status);
                }
            }

            class PhraseRecognizer
            {
                /*0x10*/ nint m_Recognizer;
                /*0x18*/ UnityEngine.Windows.Speech.PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized;

                static /*0x15ff1f0*/ UnityEngine.Windows.Speech.SemanticMeaning[] MarshalSemanticMeaning(nint keys, nint values, nint valueSizes, int valueCount);
                /*0x15ff090*/ void InvokePhraseRecognizedEvent(string text, UnityEngine.Windows.Speech.ConfidenceLevel confidence, UnityEngine.Windows.Speech.SemanticMeaning[] semanticMeanings, long phraseStartFileTime, long phraseDurationTicks);

                class PhraseRecognizedDelegate : System.MulticastDelegate
                {
                    /*0x7210a0*/ PhraseRecognizedDelegate(object object, nint method);
                    /*0x720b50*/ void Invoke(UnityEngine.Windows.Speech.PhraseRecognizedEventArgs args);
                }
            }

            class DictationRecognizer
            {
                /*0x10*/ nint m_Recognizer;
                /*0x18*/ UnityEngine.Windows.Speech.DictationRecognizer.DictationHypothesisDelegate DictationHypothesis;
                /*0x20*/ UnityEngine.Windows.Speech.DictationRecognizer.DictationResultDelegate DictationResult;
                /*0x28*/ UnityEngine.Windows.Speech.DictationRecognizer.DictationCompletedDelegate DictationComplete;
                /*0x30*/ UnityEngine.Windows.Speech.DictationRecognizer.DictationErrorHandler DictationError;

                /*0x15f8170*/ void DictationRecognizer_InvokeHypothesisGeneratedEvent(string keyword);
                /*0x15f8190*/ void DictationRecognizer_InvokeResultGeneratedEvent(string keyword, UnityEngine.Windows.Speech.ConfidenceLevel minimumConfidence);
                /*0x15f8130*/ void DictationRecognizer_InvokeCompletedEvent(UnityEngine.Windows.Speech.DictationCompletionCause cause);
                /*0x15f8150*/ void DictationRecognizer_InvokeErrorEvent(string error, int hresult);

                class DictationHypothesisDelegate : System.MulticastDelegate
                {
                    /*0xf0a420*/ DictationHypothesisDelegate(object object, nint method);
                    /*0x720980*/ void Invoke(string text);
                }

                class DictationResultDelegate : System.MulticastDelegate
                {
                    /*0x15f8070*/ DictationResultDelegate(object object, nint method);
                    /*0x722200*/ void Invoke(string text, UnityEngine.Windows.Speech.ConfidenceLevel confidence);
                }

                class DictationCompletedDelegate : System.MulticastDelegate
                {
                    /*0x721150*/ DictationCompletedDelegate(object object, nint method);
                    /*0x720980*/ void Invoke(UnityEngine.Windows.Speech.DictationCompletionCause cause);
                }

                class DictationErrorHandler : System.MulticastDelegate
                {
                    /*0x15f8070*/ DictationErrorHandler(object object, nint method);
                    /*0x722200*/ void Invoke(string error, int hresult);
                }
            }

            enum ConfidenceLevel
            {
                High = 0,
                Medium = 1,
                Low = 2,
                Rejected = 3,
            }

            enum SpeechSystemStatus
            {
                Stopped = 0,
                Running = 1,
                Failed = 2,
            }

            enum SpeechError
            {
                NoError = 0,
                TopicLanguageNotSupported = 1,
                GrammarLanguageMismatch = 2,
                GrammarCompilationFailure = 3,
                AudioQualityFailure = 4,
                PauseLimitExceeded = 5,
                TimeoutExceeded = 6,
                NetworkFailure = 7,
                MicrophoneUnavailable = 8,
                UnknownError = 9,
            }

            enum DictationCompletionCause
            {
                Complete = 0,
                AudioQualityFailure = 1,
                Canceled = 2,
                TimeoutExceeded = 3,
                PauseLimitExceeded = 4,
                NetworkFailure = 5,
                MicrophoneUnavailable = 6,
                UnknownError = 7,
            }

            struct SemanticMeaning
            {
                /*0x10*/ string key;
                /*0x18*/ string[] values;
            }

            struct PhraseRecognizedEventArgs
            {
                /*0x10*/ UnityEngine.Windows.Speech.ConfidenceLevel confidence;
                /*0x18*/ UnityEngine.Windows.Speech.SemanticMeaning[] semanticMeanings;
                /*0x20*/ string text;
                /*0x28*/ System.DateTime phraseStartTime;
                /*0x30*/ System.TimeSpan phraseDuration;

                /*0x15ff030*/ PhraseRecognizedEventArgs(string text, UnityEngine.Windows.Speech.ConfidenceLevel confidence, UnityEngine.Windows.Speech.SemanticMeaning[] semanticMeanings, System.DateTime phraseStartTime, System.TimeSpan phraseDuration);
            }
        }

        namespace WebCam
        {
            class PhotoCapture : System.IDisposable
            {
                static /*0x0*/ long HR_SUCCESS;
                /*0x10*/ nint m_NativePtr;

                static /*0x15fef00*/ UnityEngine.Windows.WebCam.PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult);
                static /*0x15fee40*/ void InvokeOnCreatedResourceDelegate(UnityEngine.Windows.WebCam.PhotoCapture.OnCaptureResourceCreatedCallback callback, nint nativePtr);
                static /*0x15febd0*/ void InvokeOnPhotoModeStartedDelegate(UnityEngine.Windows.WebCam.PhotoCapture.OnPhotoModeStartedCallback callback, long hResult);
                static /*0x15febd0*/ void InvokeOnPhotoModeStoppedDelegate(UnityEngine.Windows.WebCam.PhotoCapture.OnPhotoModeStoppedCallback callback, long hResult);
                static /*0x15febd0*/ void InvokeOnCapturedPhotoToDiskDelegate(UnityEngine.Windows.WebCam.PhotoCapture.OnCapturedToDiskCallback callback, long hResult);
                static /*0x15fec70*/ void InvokeOnCapturedPhotoToMemoryDelegate(UnityEngine.Windows.WebCam.PhotoCapture.OnCapturedToMemoryCallback callback, long hResult, nint photoCaptureFramePtr);
                /*0x15c3e80*/ PhotoCapture(nint nativeCaptureObject);
                /*0x15feaa0*/ void Dispose();
                /*0x15fea60*/ void Dispose_Internal();
                /*0x15feb30*/ void Finalize();
                /*0x15fea20*/ void DisposeThreaded_Internal();

                enum CaptureResultType
                {
                    Success = 0,
                    UnknownError = 1,
                }

                struct PhotoCaptureResult
                {
                    /*0x10*/ UnityEngine.Windows.WebCam.PhotoCapture.CaptureResultType resultType;
                    /*0x18*/ long hResult;
                }

                class OnCaptureResourceCreatedCallback : System.MulticastDelegate
                {
                    /*0xfbe150*/ OnCaptureResourceCreatedCallback(object object, nint method);
                    /*0x720980*/ void Invoke(UnityEngine.Windows.WebCam.PhotoCapture captureObject);
                }

                class OnPhotoModeStartedCallback : System.MulticastDelegate
                {
                    /*0x720f40*/ OnPhotoModeStartedCallback(object object, nint method);
                    /*0x7208f0*/ void Invoke(UnityEngine.Windows.WebCam.PhotoCapture.PhotoCaptureResult result);
                }

                class OnPhotoModeStoppedCallback : System.MulticastDelegate
                {
                    /*0x720f40*/ OnPhotoModeStoppedCallback(object object, nint method);
                    /*0x7208f0*/ void Invoke(UnityEngine.Windows.WebCam.PhotoCapture.PhotoCaptureResult result);
                }

                class OnCapturedToDiskCallback : System.MulticastDelegate
                {
                    /*0x720f40*/ OnCapturedToDiskCallback(object object, nint method);
                    /*0x7208f0*/ void Invoke(UnityEngine.Windows.WebCam.PhotoCapture.PhotoCaptureResult result);
                }

                class OnCapturedToMemoryCallback : System.MulticastDelegate
                {
                    /*0x15fd810*/ OnCapturedToMemoryCallback(object object, nint method);
                    /*0x9dedb0*/ void Invoke(UnityEngine.Windows.WebCam.PhotoCapture.PhotoCaptureResult result, UnityEngine.Windows.WebCam.PhotoCaptureFrame photoCaptureFrame);
                }
            }

            class PhotoCaptureFrame : System.IDisposable
            {
                /*0x10*/ nint m_NativePtr;
                /*0x18*/ int <dataLength>k__BackingField;
                /*0x1c*/ bool <hasLocationData>k__BackingField;
                /*0x20*/ UnityEngine.Windows.WebCam.CapturePixelFormat <pixelFormat>k__BackingField;

                /*0x15fe940*/ PhotoCaptureFrame(nint nativePtr);
                /*0x8a5c20*/ int get_dataLength();
                /*0x8a5c50*/ void set_dataLength(int value);
                /*0x14efc30*/ void set_hasLocationData(bool value);
                /*0x11172b0*/ void set_pixelFormat(UnityEngine.Windows.WebCam.CapturePixelFormat value);
                /*0x15fe8c0*/ int GetDataLength();
                /*0x15fe900*/ bool GetHasLocationData();
                /*0x15fe880*/ UnityEngine.Windows.WebCam.CapturePixelFormat GetCapturePixelFormat();
                /*0x15fe6e0*/ void Cleanup();
                /*0x15fe780*/ void Dispose_Internal();
                /*0x15fe7c0*/ void Dispose();
                /*0x15fe820*/ void Finalize();
            }

            class VideoCapture : System.IDisposable
            {
                static /*0x0*/ long HR_SUCCESS;
                /*0x10*/ nint m_NativePtr;

                static /*0x16116c0*/ UnityEngine.Windows.WebCam.VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult);
                static /*0x1611560*/ void InvokeOnCreatedVideoCaptureResourceDelegate(UnityEngine.Windows.WebCam.VideoCapture.OnVideoCaptureResourceCreatedCallback callback, nint nativePtr);
                static /*0x1611620*/ void InvokeOnVideoModeStartedDelegate(UnityEngine.Windows.WebCam.VideoCapture.OnVideoModeStartedCallback callback, long hResult);
                static /*0x1611620*/ void InvokeOnVideoModeStoppedDelegate(UnityEngine.Windows.WebCam.VideoCapture.OnVideoModeStoppedCallback callback, long hResult);
                static /*0x1611620*/ void InvokeOnStartedRecordingVideoToDiskDelegate(UnityEngine.Windows.WebCam.VideoCapture.OnStartedRecordingVideoCallback callback, long hResult);
                static /*0x1611620*/ void InvokeOnStoppedRecordingVideoToDiskDelegate(UnityEngine.Windows.WebCam.VideoCapture.OnStoppedRecordingVideoCallback callback, long hResult);
                /*0x15c3e80*/ VideoCapture(nint nativeCaptureObject);
                /*0x1611430*/ void Dispose();
                /*0x16113f0*/ void Dispose_Internal();
                /*0x16114c0*/ void Finalize();
                /*0x16113b0*/ void DisposeThreaded_Internal();

                enum CaptureResultType
                {
                    Success = 0,
                    UnknownError = 1,
                }

                struct VideoCaptureResult
                {
                    /*0x10*/ UnityEngine.Windows.WebCam.VideoCapture.CaptureResultType resultType;
                    /*0x18*/ long hResult;
                }

                class OnVideoCaptureResourceCreatedCallback : System.MulticastDelegate
                {
                    /*0xfbe150*/ OnVideoCaptureResourceCreatedCallback(object object, nint method);
                    /*0x720980*/ void Invoke(UnityEngine.Windows.WebCam.VideoCapture captureObject);
                }

                class OnVideoModeStartedCallback : System.MulticastDelegate
                {
                    /*0x720f40*/ OnVideoModeStartedCallback(object object, nint method);
                    /*0x7208f0*/ void Invoke(UnityEngine.Windows.WebCam.VideoCapture.VideoCaptureResult result);
                }

                class OnVideoModeStoppedCallback : System.MulticastDelegate
                {
                    /*0x720f40*/ OnVideoModeStoppedCallback(object object, nint method);
                    /*0x7208f0*/ void Invoke(UnityEngine.Windows.WebCam.VideoCapture.VideoCaptureResult result);
                }

                class OnStartedRecordingVideoCallback : System.MulticastDelegate
                {
                    /*0x720f40*/ OnStartedRecordingVideoCallback(object object, nint method);
                    /*0x7208f0*/ void Invoke(UnityEngine.Windows.WebCam.VideoCapture.VideoCaptureResult result);
                }

                class OnStoppedRecordingVideoCallback : System.MulticastDelegate
                {
                    /*0x720f40*/ OnStoppedRecordingVideoCallback(object object, nint method);
                    /*0x7208f0*/ void Invoke(UnityEngine.Windows.WebCam.VideoCapture.VideoCaptureResult result);
                }
            }

            enum CapturePixelFormat
            {
                BGRA32 = 0,
                NV12 = 1,
                JPEG = 2,
                PNG = 3,
            }
        }
    }

    namespace Events
    {
        enum PersistentListenerMode
        {
            EventDefined = 0,
            Void = 1,
            Object = 2,
            Int = 3,
            Float = 4,
            String = 5,
            Bool = 6,
        }

        class UnityEventTools
        {
            static /*0x160fa70*/ string TidyAssemblyTypeName(string assemblyTypeName);
        }

        class ArgumentCache : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Object m_ObjectArgument;
            /*0x18*/ string m_ObjectArgumentAssemblyTypeName;
            /*0x20*/ int m_IntArgument;
            /*0x24*/ float m_FloatArgument;
            /*0x28*/ string m_StringArgument;
            /*0x30*/ bool m_BoolArgument;

            /*0x32f970*/ ArgumentCache();
            /*0x9e3110*/ UnityEngine.Object get_unityObjectArgument();
            /*0x8b8f40*/ string get_unityObjectArgumentAssemblyTypeName();
            /*0xca7c70*/ int get_intArgument();
            /*0x15f1330*/ float get_floatArgument();
            /*0x15f1340*/ string get_stringArgument();
            /*0x15f1320*/ bool get_boolArgument();
            /*0x15f12f0*/ void OnBeforeSerialize();
            /*0x15f12f0*/ void OnAfterDeserialize();
        }

        class BaseInvokableCall
        {
            static /*0x177be0*/ void ThrowOnInvalidArg<T>(object arg);
            static /*0x15f1680*/ bool AllowInvoke(System.Delegate delegate);
            /*0x32f970*/ BaseInvokableCall();
            /*0x15f17a0*/ BaseInvokableCall(object target, System.Reflection.MethodInfo function);
            /*0x17aec0*/ void Invoke(object[] args);
            bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall : UnityEngine.Events.BaseInvokableCall
        {
            /*0x10*/ UnityEngine.Events.UnityAction Delegate;

            /*0x15fa1b0*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x15fa180*/ InvokableCall(UnityEngine.Events.UnityAction action);
            /*0x15fa3b0*/ void add_Delegate(UnityEngine.Events.UnityAction value);
            /*0x15fa450*/ void remove_Delegate(UnityEngine.Events.UnityAction value);
            /*0x15fa130*/ void Invoke(object[] args);
            /*0x15fa130*/ void Invoke();
            /*0xa39620*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1> Delegate;

            /*0x183150*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x17aec0*/ InvokableCall(UnityEngine.Events.UnityAction<T1> action);
            /*0x17aec0*/ void add_Delegate(UnityEngine.Events.UnityAction<T1> value);
            /*0x17aec0*/ void remove_Delegate(UnityEngine.Events.UnityAction<T1> value);
            /*0x17aec0*/ void Invoke(object[] args);
            /*0x2a5510*/ void Invoke(T1 args0);
            bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2> Delegate;

            /*0x183150*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x17aec0*/ void Invoke(object[] args);
            bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2, T3> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2, T3> Delegate;

            /*0x183150*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x17aec0*/ void Invoke(object[] args);
            /*0x2a5510*/ void Invoke(T1 args0, T2 args1, T3 args2);
            bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2, T3, T4> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2, T3, T4> Delegate;

            /*0x183150*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x17aec0*/ void Invoke(object[] args);
            bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class CachedInvokableCall<T> : UnityEngine.Events.InvokableCall<T>
        {
            /*0x0*/ T m_Arg1;

            /*0x2a5510*/ CachedInvokableCall(UnityEngine.Object target, System.Reflection.MethodInfo theFunction, T argument);
            /*0x17aec0*/ void Invoke(object[] args);
            /*0x2a5510*/ void Invoke(T arg0);
        }

        enum UnityEventCallState
        {
            Off = 0,
            EditorAndRuntime = 1,
            RuntimeOnly = 2,
        }

        class PersistentCall : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Object m_Target;
            /*0x18*/ string m_TargetAssemblyTypeName;
            /*0x20*/ string m_MethodName;
            /*0x28*/ UnityEngine.Events.PersistentListenerMode m_Mode;
            /*0x30*/ UnityEngine.Events.ArgumentCache m_Arguments;
            /*0x38*/ UnityEngine.Events.UnityEventCallState m_CallState;

            static /*0x15fdbe0*/ UnityEngine.Events.BaseInvokableCall GetObjectCall(UnityEngine.Object target, System.Reflection.MethodInfo method, UnityEngine.Events.ArgumentCache arguments);
            /*0x15fe510*/ PersistentCall();
            /*0x9e3110*/ UnityEngine.Object get_target();
            /*0x15fe5b0*/ string get_targetAssemblyTypeName();
            /*0x15fe5a0*/ string get_methodName();
            /*0xca7c90*/ UnityEngine.Events.PersistentListenerMode get_mode();
            /*0x15fe590*/ UnityEngine.Events.ArgumentCache get_arguments();
            /*0x15fe4d0*/ bool IsValid();
            /*0x15fe160*/ UnityEngine.Events.BaseInvokableCall GetRuntimeCall(UnityEngine.Events.UnityEventBase theEvent);
            /*0x15f12f0*/ void OnBeforeSerialize();
            /*0x15f12f0*/ void OnAfterDeserialize();
        }

        class PersistentCallGroup
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Events.PersistentCall> m_Calls;

            /*0x15fdb60*/ PersistentCallGroup();
            /*0x15fd9e0*/ void Initialize(UnityEngine.Events.InvokableCallList invokableList, UnityEngine.Events.UnityEventBase unityEventBase);
        }

        class InvokableCallList
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_PersistentCalls;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_RuntimeCalls;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_ExecutingCalls;
            /*0x28*/ bool m_NeedsUpdate;

            /*0x15fa050*/ InvokableCallList();
            /*0x15f9bc0*/ void AddPersistentInvokableCall(UnityEngine.Events.BaseInvokableCall call);
            /*0x15f9b00*/ void AddListener(UnityEngine.Events.BaseInvokableCall call);
            /*0x15f9df0*/ void RemoveListener(object targetObj, System.Reflection.MethodInfo method);
            /*0x15f9c80*/ void ClearPersistent();
            /*0x15f9d40*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke();
        }

        class UnityEventBase : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Events.InvokableCallList m_Calls;
            /*0x18*/ UnityEngine.Events.PersistentCallGroup m_PersistentCalls;
            /*0x20*/ bool m_CallsDirty;

            static /*0x160f4b0*/ System.Reflection.MethodInfo GetValidMethodInfo(System.Type objectType, string functionName, System.Type[] argumentTypes);
            /*0x160f8b0*/ UnityEventBase();
            /*0x160f8a0*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x160f8a0*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x177730*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x177730*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x160eeb0*/ System.Reflection.MethodInfo FindMethod(UnityEngine.Events.PersistentCall call);
            /*0x160f0f0*/ System.Reflection.MethodInfo FindMethod(string name, System.Type listenerType, UnityEngine.Events.PersistentListenerMode mode, System.Type argumentType);
            /*0x160edd0*/ void DirtyPersistentCalls();
            /*0x160f7b0*/ void RebuildPersistentCallsIfNeeded();
            /*0x160ed10*/ void AddCall(UnityEngine.Events.BaseInvokableCall call);
            /*0x160f7f0*/ void RemoveListener(object targetObj, System.Reflection.MethodInfo method);
            /*0x160f6d0*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke();
            /*0x160f810*/ string ToString();
        }

        class UnityAction : System.MulticastDelegate
        {
            /*0xe25c50*/ UnityAction(object object, nint method);
            /*0x9dbe20*/ void Invoke();
        }

        class UnityEvent : UnityEngine.Events.UnityEventBase
        {
            /*0x28*/ object[] m_InvokeArray;

            static /*0x160fe30*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction action);
            /*0x16100f0*/ UnityEvent();
            /*0x160fc50*/ void AddListener(UnityEngine.Events.UnityAction call);
            /*0x160fd60*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x160fdc0*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x160fe90*/ void Invoke();
        }

        class UnityAction<T0> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x2a5510*/ void Invoke(T0 arg0);
        }

        class UnityEvent<T0> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            static /*0x17e030*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0> action);
            /*0x180fc0*/ UnityEvent();
            /*0x17aec0*/ void AddListener(UnityEngine.Events.UnityAction<T0> call);
            /*0x17aec0*/ void RemoveListener(UnityEngine.Events.UnityAction<T0> call);
            /*0x177730*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x177730*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x2a5510*/ void Invoke(T0 arg0);
        }

        class UnityAction<T0, T1> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x2a5510*/ void Invoke(T0 arg0, T1 arg1);
        }

        class UnityEvent<T0, T1> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            /*0x180fc0*/ UnityEvent();
            /*0x177730*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x177730*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
        }

        class UnityAction<T0, T1, T2> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x2a5510*/ void Invoke(T0 arg0, T1 arg1, T2 arg2);
        }

        class UnityEvent<T0, T1, T2> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            /*0x180fc0*/ UnityEvent();
            /*0x177730*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x177730*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x2a5510*/ void Invoke(T0 arg0, T1 arg1, T2 arg2);
        }

        class UnityAction<T0, T1, T2, T3> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x2a5510*/ void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3);
        }

        class UnityEvent<T0, T1, T2, T3> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            /*0x180fc0*/ UnityEvent();
            /*0x177730*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x177730*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
        }
    }

    namespace Serialization
    {
        class FormerlySerializedAsAttribute : System.Attribute
        {
            /*0x10*/ string m_oldName;

            /*0xa32e30*/ FormerlySerializedAsAttribute(string oldName);
        }
    }

    namespace Scripting
    {
        class AlwaysLinkAssemblyAttribute : System.Attribute
        {
            /*0x534220*/ AlwaysLinkAssemblyAttribute();
        }

        class PreserveAttribute : System.Attribute
        {
            /*0x534220*/ PreserveAttribute();
        }

        namespace APIUpdating
        {
            struct MovedFromAttributeData
            {
                /*0x10*/ string className;
                /*0x18*/ string nameSpace;
                /*0x20*/ string assembly;
                /*0x28*/ bool classHasChanged;
                /*0x29*/ bool nameSpaceHasChanged;
                /*0x2a*/ bool assemblyHasChanged;
                /*0x2b*/ bool autoUdpateAPI;

                /*0x15fba60*/ void Set(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName);
            }

            class MovedFromAttribute : System.Attribute
            {
                /*0x10*/ UnityEngine.Scripting.APIUpdating.MovedFromAttributeData data;

                /*0x15fbaf0*/ MovedFromAttribute(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName);
                /*0x15fbb50*/ MovedFromAttribute(string sourceNamespace);
            }
        }
    }

    namespace SceneManagement
    {
        struct Scene
        {
            /*0x10*/ int m_Handle;

            static /*0x1605220*/ bool IsValidInternal(int sceneHandle);
            static /*0x1604e20*/ string GetNameInternal(int sceneHandle);
            static /*0x1604da0*/ string GetGUIDInternal(int sceneHandle);
            static /*0x1604de0*/ bool GetIsLoadedInternal(int sceneHandle);
            static /*0x1604e60*/ int GetRootCountInternal(int sceneHandle);
            static /*0x1604ea0*/ void GetRootGameObjectsInternal(int sceneHandle, object resultRootList);
            static /*0x15e9700*/ bool op_Equality(UnityEngine.SceneManagement.Scene lhs, UnityEngine.SceneManagement.Scene rhs);
            /*0x15d3b80*/ int get_handle();
            /*0x16052a0*/ string get_guid();
            /*0x1605260*/ bool IsValid();
            /*0x1605320*/ string get_name();
            /*0x16052e0*/ bool get_isLoaded();
            /*0x1605360*/ int get_rootCount();
            /*0x1605150*/ UnityEngine.GameObject[] GetRootGameObjects();
            /*0x1604ee0*/ void GetRootGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> rootGameObjects);
            /*0x15d3b80*/ int GetHashCode();
            /*0x1604d20*/ bool Equals(object other);
        }

        class SceneManagerAPIInternal
        {
            static /*0x1604040*/ UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            static /*0x1603fd0*/ UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
        }

        class SceneManagerAPI
        {
            static /*0x0*/ UnityEngine.SceneManagement.SceneManagerAPI s_DefaultAPI;
            static /*0x8*/ UnityEngine.SceneManagement.SceneManagerAPI <overrideAPI>k__BackingField;

            static /*0x1604100*/ SceneManagerAPI();
            static /*0x1604170*/ UnityEngine.SceneManagement.SceneManagerAPI get_ActiveAPI();
            static /*0x1604220*/ UnityEngine.SceneManagement.SceneManagerAPI get_overrideAPI();
            /*0x32f970*/ SceneManagerAPI();
            /*0x16040a0*/ UnityEngine.AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            /*0x388e90*/ UnityEngine.AsyncOperation LoadFirstScene(bool mustLoadAsync);
        }

        class SceneManager
        {
            static /*0x0*/ bool s_AllowLoadScene;
            static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> sceneLoaded;
            static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> sceneUnloaded;
            static /*0x18*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> activeSceneChanged;

            static /*0x1604a90*/ SceneManager();
            static /*0x1604be0*/ int get_sceneCount();
            static /*0x16042b0*/ UnityEngine.SceneManagement.Scene GetActiveScene();
            static /*0x1604360*/ UnityEngine.SceneManagement.Scene GetSceneAt(int index);
            static /*0x1604630*/ UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            static /*0x1604a20*/ void MoveGameObjectToScene(UnityEngine.GameObject go, UnityEngine.SceneManagement.Scene scene);
            static /*0x16045c0*/ UnityEngine.AsyncOperation LoadFirstScene_Internal(bool async);
            static /*0x1604ad0*/ void add_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value);
            static /*0x1604c10*/ void remove_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value);
            static /*0x1604900*/ void LoadScene(string sceneName);
            static /*0x1604860*/ UnityEngine.SceneManagement.Scene LoadScene(string sceneName, UnityEngine.SceneManagement.LoadSceneParameters parameters);
            static /*0x1604710*/ void LoadScene(int sceneBuildIndex);
            static /*0x16047d0*/ UnityEngine.SceneManagement.Scene LoadScene(int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters);
            static /*0x1604480*/ void Internal_SceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            static /*0x1604520*/ void Internal_SceneUnloaded(UnityEngine.SceneManagement.Scene scene);
            static /*0x16043e0*/ void Internal_ActiveSceneChanged(UnityEngine.SceneManagement.Scene previousActiveScene, UnityEngine.SceneManagement.Scene newActiveScene);
            static /*0x1604270*/ void GetActiveScene_Injected(ref UnityEngine.SceneManagement.Scene ret);
            static /*0x1604320*/ void GetSceneAt_Injected(int index, ref UnityEngine.SceneManagement.Scene ret);
            static /*0x16049d0*/ void MoveGameObjectToScene_Injected(UnityEngine.GameObject go, ref UnityEngine.SceneManagement.Scene scene);
        }

        enum LoadSceneMode
        {
            Single = 0,
            Additive = 1,
        }

        enum LocalPhysicsMode
        {
            None = 0,
            Physics2D = 1,
            Physics3D = 2,
        }

        struct LoadSceneParameters
        {
            /*0x10*/ UnityEngine.SceneManagement.LoadSceneMode m_LoadSceneMode;
            /*0x14*/ UnityEngine.SceneManagement.LocalPhysicsMode m_LocalPhysicsMode;

            /*0x15fa630*/ LoadSceneParameters(UnityEngine.SceneManagement.LoadSceneMode mode);
        }
    }

    namespace LowLevel
    {
        struct PlayerLoopSystemInternal
        {
            /*0x10*/ System.Type type;
            /*0x18*/ UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction updateDelegate;
            /*0x20*/ nint updateFunction;
            /*0x28*/ nint loopConditionFunction;
            /*0x30*/ int numSubSystems;
        }

        struct PlayerLoopSystem
        {
            /*0x10*/ System.Type type;
            /*0x18*/ UnityEngine.LowLevel.PlayerLoopSystem[] subSystemList;
            /*0x20*/ UnityEngine.LowLevel.PlayerLoopSystem.UpdateFunction updateDelegate;
            /*0x28*/ nint updateFunction;
            /*0x30*/ nint loopConditionFunction;

            /*0x16014a0*/ string ToString();

            class UpdateFunction : System.MulticastDelegate
            {
                /*0xe25c50*/ UpdateFunction(object object, nint method);
                /*0x9dbe20*/ void Invoke();
            }
        }
    }

    namespace PlayerLoop
    {
        struct TimeUpdate
        {
            struct WaitForLastPresentationAndUpdateTime
            {
            }
        }

        struct Initialization
        {
            struct ProfilerStartFrame
            {
            }

            struct UpdateCameraMotionVectors
            {
            }

            struct DirectorSampleTime
            {
            }

            struct AsyncUploadTimeSlicedUpdate
            {
            }

            struct SynchronizeState
            {
            }

            struct SynchronizeInputs
            {
            }

            struct XREarlyUpdate
            {
            }
        }

        struct EarlyUpdate
        {
            struct PollPlayerConnection
            {
            }

            struct PollHtcsPlayerConnection
            {
            }

            struct GpuTimestamp
            {
            }

            struct AnalyticsCoreStatsUpdate
            {
            }

            struct UnityWebRequestUpdate
            {
            }

            struct UpdateStreamingManager
            {
            }

            struct ExecuteMainThreadJobs
            {
            }

            struct ProcessMouseInWindow
            {
            }

            struct ClearIntermediateRenderers
            {
            }

            struct ClearLines
            {
            }

            struct PresentBeforeUpdate
            {
            }

            struct ResetFrameStatsAfterPresent
            {
            }

            struct UpdateAsyncReadbackManager
            {
            }

            struct UpdateTextureStreamingManager
            {
            }

            struct UpdatePreloading
            {
            }

            struct UpdateContentLoading
            {
            }

            struct UpdateAsyncInstantiate
            {
            }

            struct RendererNotifyInvisible
            {
            }

            struct PlayerCleanupCachedData
            {
            }

            struct UpdateMainGameViewRect
            {
            }

            struct UpdateCanvasRectTransform
            {
            }

            struct UpdateInputManager
            {
            }

            struct ProcessRemoteInput
            {
            }

            struct XRUpdate
            {
            }

            struct ScriptRunDelayedStartupFrame
            {
            }

            struct UpdateKinect
            {
            }

            struct DeliverIosPlatformEvents
            {
            }

            struct DispatchEventQueueEvents
            {
            }

            struct Physics2DEarlyUpdate
            {
            }

            struct PhysicsResetInterpolatedTransformPosition
            {
            }

            struct SpriteAtlasManagerUpdate
            {
            }

            struct TangoUpdate
            {
            }

            struct ARCoreUpdate
            {
            }

            struct PerformanceAnalyticsUpdate
            {
            }
        }

        struct FixedUpdate
        {
            struct ClearLines
            {
            }

            struct DirectorFixedSampleTime
            {
            }

            struct AudioFixedUpdate
            {
            }

            struct ScriptRunBehaviourFixedUpdate
            {
            }

            struct DirectorFixedUpdate
            {
            }

            struct LegacyFixedAnimationUpdate
            {
            }

            struct XRFixedUpdate
            {
            }

            struct PhysicsFixedUpdate
            {
            }

            struct Physics2DFixedUpdate
            {
            }

            struct PhysicsClothFixedUpdate
            {
            }

            struct DirectorFixedUpdatePostPhysics
            {
            }

            struct ScriptRunDelayedFixedFrameRate
            {
            }

            struct NewInputFixedUpdate
            {
            }
        }

        struct PreUpdate
        {
            struct PhysicsUpdate
            {
            }

            struct Physics2DUpdate
            {
            }

            struct PhysicsClothUpdate
            {
            }

            struct CheckTexFieldInput
            {
            }

            struct IMGUISendQueuedEvents
            {
            }

            struct SendMouseEvents
            {
            }

            struct AIUpdate
            {
            }

            struct WindUpdate
            {
            }

            struct UpdateVideo
            {
            }

            struct NewInputUpdate
            {
            }
        }

        struct Update
        {
            struct ScriptRunBehaviourUpdate
            {
            }

            struct DirectorUpdate
            {
            }

            struct ScriptRunDelayedDynamicFrameRate
            {
            }

            struct ScriptRunDelayedTasks
            {
            }
        }

        struct PreLateUpdate
        {
            struct Physics2DLateUpdate
            {
            }

            struct PhysicsLateUpdate
            {
            }

            struct AIUpdatePostScript
            {
            }

            struct DirectorUpdateAnimationBegin
            {
            }

            struct LegacyAnimationUpdate
            {
            }

            struct DirectorUpdateAnimationEnd
            {
            }

            struct DirectorDeferredEvaluate
            {
            }

            struct UIElementsUpdatePanels
            {
            }

            struct UpdateNetworkManager
            {
            }

            struct UpdateMasterServerInterface
            {
            }

            struct EndGraphicsJobsAfterScriptUpdate
            {
            }

            struct ParticleSystemBeginUpdateAll
            {
            }

            struct ScriptRunBehaviourLateUpdate
            {
            }

            struct ConstraintManagerUpdate
            {
            }
        }

        struct PostLateUpdate
        {
            struct PlayerSendFrameStarted
            {
            }

            struct UpdateRectTransform
            {
            }

            struct UpdateCanvasRectTransform
            {
            }

            struct PlayerUpdateCanvases
            {
            }

            struct UpdateAudio
            {
            }

            struct UpdateVideo
            {
            }

            struct DirectorLateUpdate
            {
            }

            struct ScriptRunDelayedDynamicFrameRate
            {
            }

            struct VFXUpdate
            {
            }

            struct ParticleSystemEndUpdateAll
            {
            }

            struct EndGraphicsJobsAfterScriptLateUpdate
            {
            }

            struct UpdateSubstance
            {
            }

            struct UpdateCustomRenderTextures
            {
            }

            struct XRPostLateUpdate
            {
            }

            struct UpdateAllRenderers
            {
            }

            struct UpdateLightProbeProxyVolumes
            {
            }

            struct EnlightenRuntimeUpdate
            {
            }

            struct UpdateAllSkinnedMeshes
            {
            }

            struct ProcessWebSendMessages
            {
            }

            struct SortingGroupsUpdate
            {
            }

            struct UpdateVideoTextures
            {
            }

            struct DirectorRenderImage
            {
            }

            struct PlayerEmitCanvasGeometry
            {
            }

            struct PlayerRenderUIEBatchModeOffscreen
            {
            }

            struct FinishFrameRendering
            {
            }

            struct BatchModeUpdate
            {
            }

            struct PlayerSendFrameComplete
            {
            }

            struct UpdateCaptureScreenshot
            {
            }

            struct PresentAfterDraw
            {
            }

            struct ClearImmediateRenderers
            {
            }

            struct XRPostPresent
            {
            }

            struct UpdateResolution
            {
            }

            struct InputEndFrame
            {
            }

            struct GUIClearEvents
            {
            }

            struct ShaderHandleErrors
            {
            }

            struct ResetInputAxis
            {
            }

            struct ThreadedLoadingDebug
            {
            }

            struct ProfilerSynchronizeStats
            {
            }

            struct MemoryFrameMaintenance
            {
            }

            struct ExecuteGameCenterCallbacks
            {
            }

            struct XRPreEndFrame
            {
            }

            struct ProfilerEndFrame
            {
            }

            struct GraphicsWarmupPreloadedShaders
            {
            }

            struct PlayerSendFramePostPresent
            {
            }

            struct PhysicsSkinnedClothBeginUpdate
            {
            }

            struct PhysicsSkinnedClothFinishUpdate
            {
            }

            struct TriggerEndOfFrameCallbacks
            {
            }

            struct ObjectDispatcherPostLateUpdate
            {
            }
        }
    }

    namespace Pool
    {
        class CollectionPool<TCollection, TItem>
        {
            static /*0x0*/ UnityEngine.Pool.ObjectPool<TCollection> s_Pool;

            static /*0x180ff0*/ CollectionPool();
            static /*0x2a5510*/ TCollection Get();
            static /*0x2a5510*/ UnityEngine.Pool.PooledObject<TCollection> Get(ref TCollection value);
            static /*0x2a5510*/ void Release(TCollection toRelease);

            class <>c<TCollection, TItem>
            {
                static /*0x0*/ UnityEngine.Pool.CollectionPool.<>c<TCollection, TItem> <>9;

                static /*0x180ff0*/ <>c();
                /*0x180fc0*/ <>c();
                /*0x2a5510*/ TCollection <.cctor>b__5_0();
                /*0x2a5510*/ void <.cctor>b__5_1(TCollection l);
            }
        }

        interface IObjectPool<T>
        {
            /*0x2a5510*/ void Release(T element);
        }

        interface IPool
        {
        }

        class ObjectPool<T> : System.IDisposable, UnityEngine.Pool.IPool, UnityEngine.Pool.IObjectPool<T>
        {
            /*0x0*/ System.Collections.Generic.List<T> m_List;
            /*0x0*/ System.Func<T> m_CreateFunc;
            /*0x0*/ System.Action<T> m_ActionOnGet;
            /*0x0*/ System.Action<T> m_ActionOnRelease;
            /*0x0*/ System.Action<T> m_ActionOnDestroy;
            /*0x0*/ int m_MaxSize;
            /*0x0*/ bool m_CollectionCheck;
            /*0x0*/ int <CountAll>k__BackingField;

            /*0x2a5510*/ ObjectPool(System.Func<T> createFunc, System.Action<T> actionOnGet, System.Action<T> actionOnRelease, System.Action<T> actionOnDestroy, bool collectionCheck, int defaultCapacity, int maxSize);
            /*0x180980*/ int get_CountAll();
            /*0x17aa40*/ void set_CountAll(int value);
            /*0x180980*/ int get_CountInactive();
            /*0x2a5510*/ T Get();
            /*0x2a5510*/ UnityEngine.Pool.PooledObject<T> Get(ref T v);
            /*0x2a5510*/ void Release(T element);
            /*0x180fc0*/ void Clear();
            /*0x180fc0*/ void Dispose();
        }

        struct PooledObject<T> : System.IDisposable
        {
            /*0x0*/ T m_ToReturn;
            /*0x0*/ UnityEngine.Pool.IObjectPool<T> m_Pool;

            /*0x2a5510*/ PooledObject(T value, UnityEngine.Pool.IObjectPool<T> pool);
            /*0x180fc0*/ void System.IDisposable.Dispose();
        }

        class PoolManager
        {
            static /*0x0*/ System.Collections.Generic.List<System.WeakReference<UnityEngine.Pool.IPool>> s_WeakPoolReferences;

            static /*0x1601600*/ PoolManager();
            static /*0x16014d0*/ void Register(UnityEngine.Pool.IPool pool);
        }
    }

    namespace Networking
    {
        namespace PlayerConnection
        {
            class MessageEventArgs
            {
                /*0x10*/ int playerId;
                /*0x18*/ byte[] data;

                /*0x32f970*/ MessageEventArgs();
            }

            class PlayerConnection : UnityEngine.ScriptableObject
            {
                static /*0x0*/ UnityEngine.IPlayerEditorConnectionNative connectionNative;
                static /*0x8*/ UnityEngine.Networking.PlayerConnection.PlayerConnection s_Instance;
                /*0x18*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents;
                /*0x20*/ System.Collections.Generic.List<int> m_connectedPlayers;
                /*0x28*/ bool m_IsInitilized;

                static /*0x16009d0*/ UnityEngine.Networking.PlayerConnection.PlayerConnection get_instance();
                static /*0x15ff810*/ UnityEngine.Networking.PlayerConnection.PlayerConnection CreateInstance();
                static /*0x15ffa80*/ void MessageCallbackInternal(nint data, ulong size, ulong guid, string messageId);
                static /*0x15ff740*/ void ConnectedCallbackInternal(int playerId);
                static /*0x15ff980*/ void DisconnectedCallback(int playerId);
                /*0x16007c0*/ PlayerConnection();
                /*0x1600b60*/ bool get_isConnected();
                /*0x15ffbd0*/ void OnEnable();
                /*0x15ffa10*/ UnityEngine.IPlayerEditorConnectionNative GetConnectionNativeApi();
                /*0x15ffdf0*/ void Register(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);
                /*0x16004f0*/ void Unregister(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);
                /*0x15ffc30*/ void RegisterConnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x15ffd90*/ void RegisterDisconnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x1600430*/ void UnregisterConnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x1600490*/ void UnregisterDisconnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x1600090*/ void Send(System.Guid messageId, byte[] data);
                /*0x1600260*/ bool TrySend(System.Guid messageId, byte[] data);
                /*0x15ff470*/ bool BlockUntilRecvMsg(System.Guid messageId, int timeout);
                /*0x15ff8e0*/ void DisconnectAll();

                class <>c__DisplayClass12_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x32f970*/ <>c__DisplayClass12_0();
                    /*0x160dff0*/ bool <Register>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x32f970*/ <>c__DisplayClass13_0();
                    /*0x160dff0*/ bool <Unregister>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ bool msgReceived;

                    /*0x32f970*/ <>c__DisplayClass20_0();
                    /*0xbe4ad0*/ void <BlockUntilRecvMsg>b__0(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
                }
            }

            class PlayerEditorConnectionEvents
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers;
                /*0x18*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent;
                /*0x20*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent;

                /*0x1601380*/ PlayerEditorConnectionEvents();
                /*0x1600e70*/ void InvokeMessageIdSubscribers(System.Guid messageId, byte[] data, int playerId);
                /*0x1600c00*/ UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs> AddAndCreate(System.Guid messageId);
                /*0x1601240*/ void UnregisterManagedCallback(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);

                class MessageEvent : UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs>
                {
                    /*0x15faa70*/ MessageEvent();
                }

                class ConnectionChangeEvent : UnityEngine.Events.UnityEvent<int>
                {
                    /*0x15f7a90*/ ConnectionChangeEvent();
                }

                class MessageTypeSubscribers
                {
                    /*0x10*/ string m_messageTypeId;
                    /*0x18*/ int subscriberCount;
                    /*0x20*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageEvent messageCallback;

                    /*0x15faab0*/ MessageTypeSubscribers();
                    /*0x15fab40*/ System.Guid get_MessageTypeId();
                    /*0x15fab80*/ void set_MessageTypeId(System.Guid value);
                }

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x32f970*/ <>c__DisplayClass6_0();
                    /*0x160dff0*/ bool <InvokeMessageIdSubscribers>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x32f970*/ <>c__DisplayClass7_0();
                    /*0x160dff0*/ bool <AddAndCreate>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass8_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x32f970*/ <>c__DisplayClass8_0();
                    /*0x160dff0*/ bool <UnregisterManagedCallback>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }
            }
        }
    }

    namespace Internal
    {
        class DefaultValueAttribute : System.Attribute
        {
            /*0x10*/ object DefaultValue;

            /*0xa32e30*/ DefaultValueAttribute(string value);
            /*0x9e3110*/ object get_Value();
            /*0x15f7f80*/ bool Equals(object obj);
            /*0x15f8030*/ int GetHashCode();
        }

        class ExcludeFromDocsAttribute : System.Attribute
        {
            /*0x534220*/ ExcludeFromDocsAttribute();
        }
    }

    namespace Rendering
    {
        struct AsyncGPUReadbackRequest
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ int m_Version;

            static /*0x15f14e0*/ void WaitForCompletion_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest _unity_self);
            static /*0x15f1450*/ bool IsDone_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest _unity_self);
            static /*0x15f1410*/ bool HasError_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest _unity_self);
            static /*0x15f1390*/ int GetLayerCount_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest _unity_self);
            static /*0x15f13d0*/ int GetLayerDataSize_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest _unity_self);
            static /*0x15f1490*/ void SetScriptingCallback_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest _unity_self, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            static /*0x15f1350*/ nint GetDataRaw_Injected(ref UnityEngine.Rendering.AsyncGPUReadbackRequest _unity_self, int layer);
            /*0x15f14e0*/ void WaitForCompletion();
            /*0x2a5510*/ Unity.Collections.NativeArray<T> GetData<T>(int layer);
            /*0x15f1450*/ bool get_done();
            /*0x15f1410*/ bool get_hasError();
            /*0x15f1390*/ int get_layerCount();
            /*0x15f13d0*/ int get_layerDataSize();
            /*0x15f1450*/ bool IsDone();
            /*0x15f1410*/ bool HasError();
            /*0x15f1390*/ int GetLayerCount();
            /*0x15f13d0*/ int GetLayerDataSize();
            /*0x15f1490*/ void SetScriptingCallback(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x15f1350*/ nint GetDataRaw(int layer);
        }

        struct AsyncRequestNativeArrayData
        {
            /*0x10*/ void* nativeArrayBuffer;
            /*0x18*/ long lengthInBytes;
        }

        class AsyncGPUReadback
        {
            static /*0x15f15e0*/ UnityEngine.Rendering.AsyncGPUReadbackRequest Request(UnityEngine.GraphicsBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            static /*0x15f1580*/ UnityEngine.Rendering.AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_1(UnityEngine.GraphicsBuffer buffer, UnityEngine.Rendering.AsyncRequestNativeArrayData* data);
            static /*0x15f1520*/ void Request_Internal_GraphicsBuffer_1_Injected(UnityEngine.GraphicsBuffer buffer, UnityEngine.Rendering.AsyncRequestNativeArrayData* data, ref UnityEngine.Rendering.AsyncGPUReadbackRequest ret);
        }

        enum SynchronisationStage
        {
            VertexProcessing = 0,
            PixelProcessing = 1,
        }

        enum IndexFormat
        {
            UInt16 = 0,
            UInt32 = 1,
        }

        enum MeshUpdateFlags
        {
            Default = 0,
            DontValidateIndices = 1,
            DontResetBoneBounds = 2,
            DontNotifyMeshUsers = 4,
            DontRecalculateBounds = 8,
        }

        enum VertexAttributeFormat
        {
            Float32 = 0,
            Float16 = 1,
            UNorm8 = 2,
            SNorm8 = 3,
            UNorm16 = 4,
            SNorm16 = 5,
            UInt8 = 6,
            SInt8 = 7,
            UInt16 = 8,
            SInt16 = 9,
            UInt32 = 10,
            SInt32 = 11,
        }

        enum VertexAttribute
        {
            Position = 0,
            Normal = 1,
            Tangent = 2,
            Color = 3,
            TexCoord0 = 4,
            TexCoord1 = 5,
            TexCoord2 = 6,
            TexCoord3 = 7,
            TexCoord4 = 8,
            TexCoord5 = 9,
            TexCoord6 = 10,
            TexCoord7 = 11,
            BlendWeight = 12,
            BlendIndices = 13,
        }

        enum OpaqueSortMode
        {
            Default = 0,
            FrontToBack = 1,
            NoDistanceSort = 2,
        }

        enum RenderBufferLoadAction
        {
            Load = 0,
            Clear = 1,
            DontCare = 2,
        }

        enum RenderBufferStoreAction
        {
            Store = 0,
            Resolve = 1,
            StoreAndResolve = 2,
            DontCare = 3,
        }

        enum FastMemoryFlags
        {
            None = 0,
            SpillTop = 1,
            SpillBottom = 2,
        }

        enum BlendMode
        {
            Zero = 0,
            One = 1,
            DstColor = 2,
            SrcColor = 3,
            OneMinusDstColor = 4,
            SrcAlpha = 5,
            OneMinusSrcColor = 6,
            DstAlpha = 7,
            OneMinusDstAlpha = 8,
            SrcAlphaSaturate = 9,
            OneMinusSrcAlpha = 10,
        }

        enum BlendOp
        {
            Add = 0,
            Subtract = 1,
            ReverseSubtract = 2,
            Min = 3,
            Max = 4,
            LogicalClear = 5,
            LogicalSet = 6,
            LogicalCopy = 7,
            LogicalCopyInverted = 8,
            LogicalNoop = 9,
            LogicalInvert = 10,
            LogicalAnd = 11,
            LogicalNand = 12,
            LogicalOr = 13,
            LogicalNor = 14,
            LogicalXor = 15,
            LogicalEquivalence = 16,
            LogicalAndReverse = 17,
            LogicalAndInverted = 18,
            LogicalOrReverse = 19,
            LogicalOrInverted = 20,
            Multiply = 21,
            Screen = 22,
            Overlay = 23,
            Darken = 24,
            Lighten = 25,
            ColorDodge = 26,
            ColorBurn = 27,
            HardLight = 28,
            SoftLight = 29,
            Difference = 30,
            Exclusion = 31,
            HSLHue = 32,
            HSLSaturation = 33,
            HSLColor = 34,
            HSLLuminosity = 35,
        }

        enum CompareFunction
        {
            Disabled = 0,
            Never = 1,
            Less = 2,
            Equal = 3,
            LessEqual = 4,
            Greater = 5,
            NotEqual = 6,
            GreaterEqual = 7,
            Always = 8,
        }

        enum CullMode
        {
            Off = 0,
            Front = 1,
            Back = 2,
        }

        enum ColorWriteMask
        {
            Alpha = 1,
            Blue = 2,
            Green = 4,
            Red = 8,
            All = 15,
        }

        enum StencilOp
        {
            Keep = 0,
            Zero = 1,
            Replace = 2,
            IncrementSaturate = 3,
            DecrementSaturate = 4,
            Invert = 5,
            IncrementWrap = 6,
            DecrementWrap = 7,
        }

        enum BuiltinRenderTextureType
        {
            PropertyName = -4,
            BufferPtr = -3,
            RenderTexture = -2,
            BindableTexture = -1,
            None = 0,
            CurrentActive = 1,
            CameraTarget = 2,
            Depth = 3,
            DepthNormals = 4,
            ResolvedDepth = 5,
            PrepassNormalsSpec = 7,
            PrepassLight = 8,
            PrepassLightSpec = 9,
            GBuffer0 = 10,
            GBuffer1 = 11,
            GBuffer2 = 12,
            GBuffer3 = 13,
            Reflections = 14,
            MotionVectors = 15,
            GBuffer4 = 16,
            GBuffer5 = 17,
            GBuffer6 = 18,
            GBuffer7 = 19,
        }

        enum ShadowCastingMode
        {
            Off = 0,
            On = 1,
            TwoSided = 2,
            ShadowsOnly = 3,
        }

        enum LightShadowResolution
        {
            FromQualitySettings = -1,
            Low = 0,
            Medium = 1,
            High = 2,
            VeryHigh = 3,
        }

        enum GraphicsDeviceType
        {
            OpenGL2 = 0,
            Direct3D9 = 1,
            Direct3D11 = 2,
            PlayStation3 = 3,
            Null = 4,
            Xbox360 = 6,
            OpenGLES2 = 8,
            OpenGLES3 = 11,
            PlayStationVita = 12,
            PlayStation4 = 13,
            XboxOne = 14,
            PlayStationMobile = 15,
            Metal = 16,
            OpenGLCore = 17,
            Direct3D12 = 18,
            N3DS = 19,
            Vulkan = 21,
            Switch = 22,
            XboxOneD3D12 = 23,
            GameCoreXboxOne = 24,
            GameCoreScarlett = -1,
            GameCoreXboxSeries = 25,
            PlayStation5 = 26,
            PlayStation5NGGC = 27,
        }

        enum GraphicsTier
        {
            Tier1 = 0,
            Tier2 = 1,
            Tier3 = 2,
        }

        struct SubMeshDescriptor
        {
            /*0x10*/ UnityEngine.Bounds <bounds>k__BackingField;
            /*0x28*/ UnityEngine.MeshTopology <topology>k__BackingField;
            /*0x2c*/ int <indexStart>k__BackingField;
            /*0x30*/ int <indexCount>k__BackingField;
            /*0x34*/ int <baseVertex>k__BackingField;
            /*0x38*/ int <firstVertex>k__BackingField;
            /*0x3c*/ int <vertexCount>k__BackingField;

            /*0xa5a660*/ UnityEngine.Bounds get_bounds();
            /*0x8a5c20*/ UnityEngine.MeshTopology get_topology();
            /*0xc70b00*/ int get_indexStart();
            /*0x3e3af0*/ int get_indexCount();
            /*0x3e3ad0*/ int get_baseVertex();
            /*0x3e3ae0*/ int get_firstVertex();
            /*0xbe6c70*/ int get_vertexCount();
            /*0x1609390*/ string ToString();
        }

        struct VertexAttributeDescriptor : System.IEquatable<UnityEngine.Rendering.VertexAttributeDescriptor>
        {
            /*0x10*/ UnityEngine.Rendering.VertexAttribute <attribute>k__BackingField;
            /*0x14*/ UnityEngine.Rendering.VertexAttributeFormat <format>k__BackingField;
            /*0x18*/ int <dimension>k__BackingField;
            /*0x1c*/ int <stream>k__BackingField;

            /*0x1153590*/ VertexAttributeDescriptor(UnityEngine.Rendering.VertexAttribute attribute, UnityEngine.Rendering.VertexAttributeFormat format, int dimension, int stream);
            /*0x6bba50*/ UnityEngine.Rendering.VertexAttribute get_attribute();
            /*0x6bbd40*/ void set_attribute(UnityEngine.Rendering.VertexAttribute value);
            /*0xa5a7c0*/ UnityEngine.Rendering.VertexAttributeFormat get_format();
            /*0xfc2c10*/ void set_format(UnityEngine.Rendering.VertexAttributeFormat value);
            /*0x834a60*/ int get_dimension();
            /*0xf0fbd0*/ void set_dimension(int value);
            /*0x837600*/ int get_stream();
            /*0xf0fbc0*/ void set_stream(int value);
            /*0x1611190*/ string ToString();
            /*0x1611170*/ int GetHashCode();
            /*0x16110b0*/ bool Equals(object other);
            /*0x15d37f0*/ bool Equals(UnityEngine.Rendering.VertexAttributeDescriptor other);
        }

        enum FormatSwizzle
        {
            FormatSwizzleR = 0,
            FormatSwizzleG = 1,
            FormatSwizzleB = 2,
            FormatSwizzleA = 3,
            FormatSwizzle0 = 4,
            FormatSwizzle1 = 5,
        }

        struct RenderTargetIdentifier : System.IEquatable<UnityEngine.Rendering.RenderTargetIdentifier>
        {
            static int AllDepthSlices = -1;
            /*0x10*/ UnityEngine.Rendering.BuiltinRenderTextureType m_Type;
            /*0x14*/ int m_NameID;
            /*0x18*/ int m_InstanceID;
            /*0x20*/ nint m_BufferPointer;
            /*0x28*/ int m_MipLevel;
            /*0x2c*/ UnityEngine.CubemapFace m_CubeFace;
            /*0x30*/ int m_DepthSlice;

            static /*0x1603bf0*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.BuiltinRenderTextureType type);
            static /*0x1603cf0*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(string name);
            static /*0x1603c40*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(int nameID);
            static /*0x1603c90*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Texture tex);
            static /*0x16033c0*/ bool op_Equality(UnityEngine.Rendering.RenderTargetIdentifier lhs, UnityEngine.Rendering.RenderTargetIdentifier rhs);
            static /*0x1603d70*/ bool op_Inequality(UnityEngine.Rendering.RenderTargetIdentifier lhs, UnityEngine.Rendering.RenderTargetIdentifier rhs);
            /*0x1603910*/ RenderTargetIdentifier(UnityEngine.Rendering.BuiltinRenderTextureType type);
            /*0x1603840*/ RenderTargetIdentifier(string name);
            /*0x1603820*/ RenderTargetIdentifier(int nameID);
            /*0x16038e0*/ RenderTargetIdentifier(int nameID, int mipLevel, UnityEngine.CubemapFace cubeFace, int depthSlice);
            /*0x16038b0*/ RenderTargetIdentifier(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier, int mipLevel, UnityEngine.CubemapFace cubeFace, int depthSlice);
            /*0x1603930*/ RenderTargetIdentifier(UnityEngine.Texture tex);
            /*0x1603880*/ RenderTargetIdentifier(UnityEngine.RenderBuffer buf, int mipLevel, UnityEngine.CubemapFace cubeFace, int depthSlice);
            /*0x16034c0*/ string ToString();
            /*0x1603470*/ int GetHashCode();
            /*0x16033c0*/ bool Equals(UnityEngine.Rendering.RenderTargetIdentifier rhs);
            /*0x1603310*/ bool Equals(object obj);
        }

        enum RenderTargetFlags
        {
            None = 0,
            ReadOnlyDepth = 1,
            ReadOnlyStencil = 2,
            ReadOnlyDepthStencil = 3,
        }

        enum ReflectionProbeRefreshMode
        {
            OnAwake = 0,
            EveryFrame = 1,
            ViaScripting = 2,
        }

        enum ShadowSamplingMode
        {
            CompareDepths = 0,
            RawDepth = 1,
            None = 2,
        }

        enum LightProbeUsage
        {
            Off = 0,
            BlendProbes = 1,
            UseProxyVolume = 2,
            CustomProvided = 4,
        }

        enum BuiltinShaderDefine
        {
            UNITY_NO_DXT5nm = 0,
            UNITY_NO_RGBM = 1,
            UNITY_USE_NATIVE_HDR = 2,
            UNITY_ENABLE_REFLECTION_BUFFERS = 3,
            UNITY_FRAMEBUFFER_FETCH_AVAILABLE = 4,
            UNITY_ENABLE_NATIVE_SHADOW_LOOKUPS = 5,
            UNITY_METAL_SHADOWS_USE_POINT_FILTERING = 6,
            UNITY_NO_CUBEMAP_ARRAY = 7,
            UNITY_NO_SCREENSPACE_SHADOWS = 8,
            UNITY_USE_DITHER_MASK_FOR_ALPHABLENDED_SHADOWS = 9,
            UNITY_PBS_USE_BRDF1 = 10,
            UNITY_PBS_USE_BRDF2 = 11,
            UNITY_PBS_USE_BRDF3 = 12,
            UNITY_NO_FULL_STANDARD_SHADER = 13,
            UNITY_SPECCUBE_BOX_PROJECTION = 14,
            UNITY_SPECCUBE_BLENDING = 15,
            UNITY_ENABLE_DETAIL_NORMALMAP = 16,
            SHADER_API_MOBILE = 17,
            SHADER_API_DESKTOP = 18,
            UNITY_HARDWARE_TIER1 = 19,
            UNITY_HARDWARE_TIER2 = 20,
            UNITY_HARDWARE_TIER3 = 21,
            UNITY_COLORSPACE_GAMMA = 22,
            UNITY_LIGHT_PROBE_PROXY_VOLUME = 23,
            UNITY_HALF_PRECISION_FRAGMENT_SHADER_REGISTERS = 24,
            UNITY_LIGHTMAP_DLDR_ENCODING = 25,
            UNITY_LIGHTMAP_RGBM_ENCODING = 26,
            UNITY_LIGHTMAP_FULL_HDR = 27,
            UNITY_VIRTUAL_TEXTURING = 28,
            UNITY_PRETRANSFORM_TO_DISPLAY_ORIENTATION = 29,
            UNITY_ASTC_NORMALMAP_ENCODING = 30,
            SHADER_API_GLES30 = 31,
            UNITY_UNIFIED_SHADER_PRECISION_MODEL = 32,
            UNITY_PLATFORM_SUPPORTS_WAVE_32 = 33,
            UNITY_PLATFORM_SUPPORTS_WAVE_64 = 34,
            UNITY_NEEDS_RENDERPASS_FBFETCH_FALLBACK = 35,
        }

        enum TextureDimension
        {
            Unknown = -1,
            None = 0,
            Any = 1,
            Tex2D = 2,
            Tex3D = 3,
            Cube = 4,
            Tex2DArray = 5,
            CubeArray = 6,
        }

        enum CopyTextureSupport
        {
            None = 0,
            Basic = 1,
            Copy3D = 2,
            DifferentTypes = 4,
            TextureToRT = 8,
            RTToTexture = 16,
        }

        enum ComputeQueueType
        {
            Default = 0,
            Background = 1,
            Urgent = 2,
        }

        enum SinglePassStereoMode
        {
            None = 0,
            SideBySide = 1,
            Instancing = 2,
            Multiview = 3,
        }

        enum FoveatedRenderingCaps
        {
            None = 0,
            FoveationImage = 1,
            NonUniformRaster = 2,
        }

        enum FoveatedRenderingMode
        {
            Disabled = 0,
            Enabled = 1,
        }

        enum CommandBufferExecutionFlags
        {
            None = 0,
            AsyncCompute = 2,
        }

        enum RTClearFlags
        {
            None = 0,
            Color = 1,
            Depth = 2,
            Stencil = 4,
            All = 7,
            DepthStencil = 6,
            ColorDepth = 3,
            ColorStencil = 5,
        }

        enum RenderTextureSubElement
        {
            Color = 0,
            Depth = 1,
            Stencil = 2,
            Default = 3,
        }

        enum RenderingThreadingMode
        {
            Direct = 0,
            SingleThreaded = 1,
            MultiThreaded = 2,
            LegacyJobified = 3,
            NativeGraphicsJobs = 4,
            NativeGraphicsJobsWithoutRenderThread = 5,
        }

        enum CameraLateLatchMatrixType
        {
            View = 0,
            InverseView = 1,
            ViewProjection = 2,
            InverseViewProjection = 3,
        }

        enum OpenGLESVersion
        {
            None = 0,
            OpenGLES20 = 1,
            OpenGLES30 = 2,
            OpenGLES31 = 3,
            OpenGLES31AEP = 4,
            OpenGLES32 = 5,
        }

        enum SynchronisationStageFlags
        {
            VertexProcessing = 1,
            PixelProcessing = 2,
            ComputeProcessing = 4,
            AllGPUOperations = 7,
        }

        enum GraphicsFenceType
        {
            AsyncQueueSynchronisation = 0,
            CPUSynchronisation = 1,
        }

        struct GraphicsFence
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ int m_Version;
            /*0x1c*/ UnityEngine.Rendering.GraphicsFenceType m_FenceType;

            static /*0x15f96e0*/ UnityEngine.Rendering.SynchronisationStageFlags TranslateSynchronizationStageToFlags(UnityEngine.Rendering.SynchronisationStage s);
            static /*0x15f9560*/ int GetVersionNumber(nint fencePtr);
            /*0x15f95a0*/ void InitPostAllocation();
            /*0x15f9670*/ bool IsFencePending();
            /*0x15f96f0*/ void Validate();
            /*0x15f9550*/ int GetPlatformNotSupportedVersion();
        }

        class GraphicsSettings : UnityEngine.Object
        {
            static /*0x15f99d0*/ bool get_lightsUseLinearIntensity();
            static /*0x15f9a80*/ void set_lightsUseLinearIntensity(bool value);
            static /*0x15f9a40*/ void set_lightsUseColorTemperature(bool value);
            static /*0x15f9a00*/ void set_defaultRenderingLayerMask(uint value);
            static /*0x15f9ac0*/ void set_useScriptableRenderPipelineBatching(bool value);
            static /*0x15f97c0*/ bool HasShaderDefine(UnityEngine.Rendering.GraphicsTier tier, UnityEngine.Rendering.BuiltinShaderDefine defineHash);
            static /*0x15f9800*/ bool HasShaderDefine(UnityEngine.Rendering.BuiltinShaderDefine defineHash);
            static /*0x15f9910*/ UnityEngine.ScriptableObject get_INTERNAL_currentRenderPipeline();
            static /*0x15f9940*/ UnityEngine.Rendering.RenderPipelineAsset get_currentRenderPipeline();
            static /*0x177be0*/ void RegisterRenderPipelineSettings<T>(UnityEngine.Rendering.RenderPipelineGlobalSettings settings);
            static /*0x15f9880*/ void RegisterRenderPipeline(string renderpipelineName, UnityEngine.Object settings);
            static /*0x180ff0*/ void UnregisterRenderPipelineSettings<T>();
            static /*0x15f98d0*/ void UnregisterRenderPipeline(string renderpipelineName);
            static /*0x180cf0*/ UnityEngine.Rendering.RenderPipelineGlobalSettings GetSettingsForRenderPipeline<T>();
            static /*0x15f9780*/ UnityEngine.Object GetSettingsForRenderPipeline(string renderpipelineName);
        }

        class OnDemandRendering
        {
            static /*0x0*/ int m_RenderFrameInterval;

            static /*0x15fd950*/ OnDemandRendering();
            static /*0x15fd990*/ int get_renderFrameInterval();
            static /*0x15fd8c0*/ void GetRenderFrameInterval(ref int frameInterval);
        }

        class CommandBuffer : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x15f3e50*/ nint InitBuffer();
            /*0x15f6d60*/ CommandBuffer();
            /*0x15f43e0*/ void Internal_SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x15f2380*/ nint CreateGPUFence_Internal(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x15f6d00*/ void WaitOnGPUFence_Internal(nint fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x15f4470*/ void ReleaseBuffer();
            /*0x15f4870*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4 val);
            /*0x15f4790*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4[] values);
            /*0x15f4370*/ void Internal_SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x15f4300*/ void Internal_SetComputeConstantComputeBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x15f2570*/ void Internal_DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x15f6da0*/ void set_name(string value);
            /*0x15f20e0*/ void Clear();
            /*0x15f3fd0*/ void Internal_DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x15f4290*/ void Internal_DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x15f4240*/ void Internal_DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x15f4160*/ void Internal_DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x15f3ef0*/ void Internal_DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x15f40a0*/ void Internal_DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
            /*0x15f5480*/ void SetRandomWriteTarget_Texture(int index, ref UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x15f5410*/ void SetRandomWriteTarget_GraphicsBuffer(int index, UnityEngine.GraphicsBuffer uav, bool preserveCounterValue);
            /*0x15f1f10*/ void ClearRandomWriteTargets();
            /*0x15f67a0*/ void SetViewport(UnityEngine.Rect pixelRect);
            /*0x15f24e0*/ void DisableScissorRect();
            /*0x15f2170*/ void CopyTexture_Internal(ref UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode);
            /*0x15f1ca0*/ void Blit_Texture(UnityEngine.Texture source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Material mat, int pass, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            /*0x15f1b90*/ void Blit_Identifier(ref UnityEngine.Rendering.RenderTargetIdentifier source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Material mat, int pass, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            /*0x15f3cf0*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, UnityEngine.RenderTextureMemoryless memorylessMode, bool useDynamicScale);
            /*0x15f3a90*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, bool enableRandomWrite, UnityEngine.RenderTextureMemoryless memorylessMode);
            /*0x15f39e0*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing);
            /*0x15f3b90*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat format);
            /*0x15f3d80*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter);
            /*0x15f3c30*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer);
            /*0x15f3980*/ void GetTemporaryRTWithDescriptor(int nameID, UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter);
            /*0x15f3b10*/ void GetTemporaryRT(int nameID, UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter);
            /*0x15f44b0*/ void ReleaseTemporaryRT(int nameID);
            /*0x15f2070*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x15f1fb0*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
            /*0x15f4c50*/ void SetGlobalFloat(int nameID, float value);
            /*0x15f4ca0*/ void SetGlobalInt(int nameID, int value);
            /*0x15f4cf0*/ void SetGlobalInteger(int nameID, int value);
            /*0x15f51e0*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            /*0x15f4a00*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x15f4e40*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x15f37b0*/ void EnableShaderKeyword(string keyword);
            /*0x15f2520*/ void DisableShaderKeyword(string keyword);
            /*0x15f53a0*/ void SetMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x15f5270*/ void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x15f66f0*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            /*0x15f4ba0*/ void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x15f48e0*/ void SetExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags flags);
            /*0x15f6880*/ bool ValidateAgainstExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags requiredFlags, UnityEngine.Rendering.CommandBufferExecutionFlags invalidFlags);
            /*0x15f4c00*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x15f50d0*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x15f4da0*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x15f52e0*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x15f4420*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x15f6840*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x15f4f20*/ void SetGlobalTexture_Impl(int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x15f4960*/ void SetGlobalBufferInternal(int nameID, UnityEngine.ComputeBuffer value);
            /*0x15f1ad0*/ void BeginSample(string name);
            /*0x15f3850*/ void EndSample(string name);
            /*0x15f1a80*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x15f3800*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x15f1a80*/ void BeginSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler);
            /*0x15f3800*/ void EndSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler);
            /*0x15f4a50*/ void SetGlobalConstantBufferInternal(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x15f4b30*/ void SetGlobalConstantGraphicsBufferInternal(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x15f5230*/ void SetInstanceMultiplier(uint multiplier);
            /*0x15f4920*/ void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            /*0x15f67f0*/ void SetWireframe(bool enable);
            /*0x15f2120*/ void ConfigureFoveatedRendering(nint platformData);
            /*0x15f5e80*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x15f6310*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction);
            /*0x15f5970*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x15f5f20*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x15f60d0*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x15f6420*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x15f5d10*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x15f5aa0*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x15f58f0*/ void SetRenderTargetSingle_Internal(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x15f56d0*/ void SetRenderTargetColorDepth_Internal(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags);
            /*0x15f57d0*/ void SetRenderTargetMultiSubtarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x15f44f0*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data);
            /*0x15f3e80*/ void InternalSetComputeBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            /*0x15f38a0*/ void Finalize();
            /*0x15f25e0*/ void Dispose();
            /*0x15f2660*/ void Dispose(bool disposing);
            /*0x15f2290*/ UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence();
            /*0x15f23d0*/ UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x15f68d0*/ void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence);
            /*0x15f6a60*/ void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStage stage);
            /*0x15f6c10*/ void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x15f4700*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x15f4680*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x15f4300*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x15f2570*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x15f2cb0*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x15f2be0*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x15f2b80*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex);
            /*0x15f2c50*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material);
            /*0x15f3480*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x15f3760*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex);
            /*0x15f3780*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material);
            /*0x15f3430*/ void DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x15f3240*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x15f3060*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount);
            /*0x15f26a0*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x15f3020*/ void DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
            /*0x15f5550*/ void SetRandomWriteTarget(int index, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x15f55d0*/ void SetRandomWriteTarget(int index, UnityEngine.GraphicsBuffer buffer, bool preserveCounterValue);
            /*0x15f54d0*/ void SetRandomWriteTarget(int index, UnityEngine.GraphicsBuffer buffer);
            /*0x15f21e0*/ void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier src, UnityEngine.Rendering.RenderTargetIdentifier dst);
            /*0x15f1e30*/ void Blit(UnityEngine.Texture source, UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x15f1d40*/ void Blit(UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Material mat, int pass);
            /*0x15f5170*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
            /*0x15f4e90*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x15f4d40*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x15f5040*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderTargetIdentifier value);
            /*0x15f4fe0*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderTargetIdentifier value);
            /*0x15f4f80*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderTargetIdentifier value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x15f4960*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x15f4a50*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x15f4ac0*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x15f43e0*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x15f4800*/ void SetComputeVectorParam_Injected(UnityEngine.ComputeShader computeShader, int nameID, ref UnityEngine.Vector4 val);
            /*0x15f3f60*/ void Internal_DrawMesh_Injected(UnityEngine.Mesh mesh, ref UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x15f41f0*/ void Internal_DrawRendererList_Injected(ref UnityEngine.Rendering.RendererList rendererList);
            /*0x15f40f0*/ void Internal_DrawProcedural_Injected(ref UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x15f4050*/ void Internal_DrawOcclusionMesh_Injected(ref UnityEngine.RectInt normalizedCamViewport);
            /*0x15f6750*/ void SetViewport_Injected(ref UnityEngine.Rect pixelRect);
            /*0x15f1c30*/ void Blit_Texture_Injected(UnityEngine.Texture source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Material mat, int pass, ref UnityEngine.Vector2 scale, ref UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            /*0x15f1b20*/ void Blit_Identifier_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Material mat, int pass, ref UnityEngine.Vector2 scale, ref UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            /*0x15f3920*/ void GetTemporaryRTWithDescriptor_Injected(int nameID, ref UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter);
            /*0x15f1f50*/ void ClearRenderTarget_Injected(UnityEngine.Rendering.RTClearFlags clearFlags, ref UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x15f5120*/ void SetGlobalVector_Injected(int nameID, ref UnityEngine.Vector4 value);
            /*0x15f49b0*/ void SetGlobalColor_Injected(int nameID, ref UnityEngine.Color value);
            /*0x15f4df0*/ void SetGlobalMatrix_Injected(int nameID, ref UnityEngine.Matrix4x4 value);
            /*0x15f5330*/ void SetMaterialKeyword_Injected(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x15f6690*/ void SetViewProjectionMatrices_Injected(ref UnityEngine.Matrix4x4 view, ref UnityEngine.Matrix4x4 proj);
            /*0x15f5880*/ void SetRenderTargetSingle_Internal_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x15f5660*/ void SetRenderTargetColorDepth_Internal_Injected(ref UnityEngine.Rendering.RenderTargetIdentifier color, ref UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags);
            /*0x15f5760*/ void SetRenderTargetMultiSubtarget_Injected(UnityEngine.Rendering.RenderTargetIdentifier[] colors, ref UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
        }

        class CommandBufferExtensions
        {
            static /*0x15f18e0*/ void Internal_SwitchIntoFastMemory(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.FastMemoryFlags fastMemoryFlags, float residency, bool copyContents);
            static /*0x15f1950*/ void Internal_SwitchOutOfFastMemory(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.RenderTargetIdentifier rt, bool copyContents);
            static /*0x15f19b0*/ void SwitchIntoFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rid, UnityEngine.Rendering.FastMemoryFlags fastMemoryFlags, float residency, bool copyContents);
            static /*0x15f1a20*/ void SwitchOutOfFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rid, bool copyContents);
        }

        struct SphericalHarmonicsL2 : System.IEquatable<UnityEngine.Rendering.SphericalHarmonicsL2>
        {
            /*0x10*/ float shr0;
            /*0x14*/ float shr1;
            /*0x18*/ float shr2;
            /*0x1c*/ float shr3;
            /*0x20*/ float shr4;
            /*0x24*/ float shr5;
            /*0x28*/ float shr6;
            /*0x2c*/ float shr7;
            /*0x30*/ float shr8;
            /*0x34*/ float shg0;
            /*0x38*/ float shg1;
            /*0x3c*/ float shg2;
            /*0x40*/ float shg3;
            /*0x44*/ float shg4;
            /*0x48*/ float shg5;
            /*0x4c*/ float shg6;
            /*0x50*/ float shg7;
            /*0x54*/ float shg8;
            /*0x58*/ float shb0;
            /*0x5c*/ float shb1;
            /*0x60*/ float shb2;
            /*0x64*/ float shb3;
            /*0x68*/ float shb4;
            /*0x6c*/ float shb5;
            /*0x70*/ float shb6;
            /*0x74*/ float shb7;
            /*0x78*/ float shb8;

            static /*0x1605b20*/ bool op_Equality(UnityEngine.Rendering.SphericalHarmonicsL2 lhs, UnityEngine.Rendering.SphericalHarmonicsL2 rhs);
            /*0x1605900*/ float get_Item(int rgb, int coefficient);
            /*0x1605d40*/ void set_Item(int rgb, int coefficient, float value);
            /*0x1605730*/ int GetHashCode();
            /*0x1605510*/ bool Equals(object other);
            /*0x1605670*/ bool Equals(UnityEngine.Rendering.SphericalHarmonicsL2 other);
        }

        struct BatchID : System.IEquatable<UnityEngine.Rendering.BatchID>
        {
            static /*0x0*/ UnityEngine.Rendering.BatchID Null;
            /*0x10*/ uint value;

            static /*0x1612f90*/ BatchID();
            /*0x1612f80*/ int GetHashCode();
            /*0x1612ee0*/ bool Equals(object obj);
            /*0x15e9590*/ bool Equals(UnityEngine.Rendering.BatchID other);
        }

        struct BatchMaterialID : System.IEquatable<UnityEngine.Rendering.BatchMaterialID>
        {
            static /*0x0*/ UnityEngine.Rendering.BatchMaterialID Null;
            /*0x10*/ uint value;

            static /*0x1613070*/ BatchMaterialID();
            /*0x1612f80*/ int GetHashCode();
            /*0x1612fd0*/ bool Equals(object obj);
            /*0x15e9590*/ bool Equals(UnityEngine.Rendering.BatchMaterialID other);
        }

        struct BatchMeshID : System.IEquatable<UnityEngine.Rendering.BatchMeshID>
        {
            static /*0x0*/ UnityEngine.Rendering.BatchMeshID Null;
            /*0x10*/ uint value;

            static /*0x1613150*/ BatchMeshID();
            /*0x1612f80*/ int GetHashCode();
            /*0x16130b0*/ bool Equals(object obj);
            /*0x15e9590*/ bool Equals(UnityEngine.Rendering.BatchMeshID other);
        }

        enum BatchDrawCommandFlags
        {
            None = 0,
            FlipWinding = 1,
            HasMotion = 2,
            IsLightMapped = 4,
            HasSortingPosition = 8,
            LODCrossFade = 16,
        }

        enum BatchCullingFlags
        {
            None = 0,
            CullLightmappedShadowCasters = 1,
        }

        enum BatchCullingViewType
        {
            Unknown = 0,
            Camera = 1,
            Light = 2,
            Picking = 3,
            SelectionOutline = 4,
        }

        enum BatchCullingProjectionType
        {
            Unknown = 0,
            Perspective = 1,
            Orthographic = 2,
        }

        struct BatchPackedCullingViewID : System.IEquatable<UnityEngine.Rendering.BatchPackedCullingViewID>
        {
            /*0x10*/ ulong handle;

            /*0x1613220*/ int GetHashCode();
            /*0xc6a5a0*/ bool Equals(UnityEngine.Rendering.BatchPackedCullingViewID other);
            /*0x1613190*/ bool Equals(object obj);
        }

        struct BatchDrawCommand
        {
            /*0x10*/ uint visibleOffset;
            /*0x14*/ uint visibleCount;
            /*0x18*/ UnityEngine.Rendering.BatchID batchID;
            /*0x1c*/ UnityEngine.Rendering.BatchMaterialID materialID;
            /*0x20*/ UnityEngine.Rendering.BatchMeshID meshID;
            /*0x24*/ ushort submeshIndex;
            /*0x26*/ ushort splitVisibilityMask;
            /*0x28*/ UnityEngine.Rendering.BatchDrawCommandFlags flags;
            /*0x2c*/ int sortingPosition;
        }

        struct BatchFilterSettings
        {
            /*0x10*/ uint renderingLayerMask;
            /*0x14*/ byte layer;
            /*0x15*/ byte m_motionMode;
            /*0x16*/ byte m_shadowMode;
            /*0x17*/ byte m_receiveShadows;
            /*0x18*/ byte m_staticShadowCaster;
            /*0x19*/ byte m_allDepthSorted;
        }

        struct BatchDrawRange
        {
            /*0x10*/ uint drawCommandsBegin;
            /*0x14*/ uint drawCommandsCount;
            /*0x18*/ UnityEngine.Rendering.BatchFilterSettings filterSettings;
        }

        struct BatchCullingOutputDrawCommands
        {
            /*0x10*/ UnityEngine.Rendering.BatchDrawCommand* drawCommands;
            /*0x18*/ int* visibleInstances;
            /*0x20*/ UnityEngine.Rendering.BatchDrawRange* drawRanges;
            /*0x28*/ float* instanceSortingPositions;
            /*0x30*/ int* drawCommandPickingInstanceIDs;
            /*0x38*/ int drawCommandCount;
            /*0x3c*/ int visibleInstanceCount;
            /*0x40*/ int drawRangeCount;
            /*0x44*/ int instanceSortingPositionFloatCount;
        }

        struct CullingSplit
        {
            /*0x10*/ UnityEngine.Vector3 sphereCenter;
            /*0x1c*/ float sphereRadius;
            /*0x20*/ int cullingPlaneOffset;
            /*0x24*/ int cullingPlaneCount;
            /*0x28*/ float cascadeBlendCullingFactor;
            /*0x2c*/ float nearPlane;
            /*0x30*/ UnityEngine.Matrix4x4 cullingMatrix;
        }

        struct BatchCullingContext
        {
            /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Plane> cullingPlanes;
            /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.CullingSplit> cullingSplits;
            /*0x30*/ UnityEngine.Rendering.LODParameters lodParameters;
            /*0x4c*/ UnityEngine.Matrix4x4 localToWorldMatrix;
            /*0x8c*/ UnityEngine.Rendering.BatchCullingViewType viewType;
            /*0x90*/ UnityEngine.Rendering.BatchCullingProjectionType projectionType;
            /*0x94*/ UnityEngine.Rendering.BatchCullingFlags cullingFlags;
            /*0x98*/ UnityEngine.Rendering.BatchPackedCullingViewID viewID;
            /*0xa0*/ uint cullingLayerMask;
            /*0xa8*/ ulong sceneCullingMask;
            /*0xb0*/ byte isOrthographic;
            /*0xb4*/ int receiverPlaneOffset;
            /*0xb8*/ int receiverPlaneCount;

            /*0x1612e30*/ BatchCullingContext(Unity.Collections.NativeArray<UnityEngine.Plane> inCullingPlanes, Unity.Collections.NativeArray<UnityEngine.Rendering.CullingSplit> inCullingSplits, UnityEngine.Rendering.LODParameters inLodParameters, UnityEngine.Matrix4x4 inLocalToWorldMatrix, UnityEngine.Rendering.BatchCullingViewType inViewType, UnityEngine.Rendering.BatchCullingProjectionType inProjectionType, UnityEngine.Rendering.BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, int inReceiverPlaneOffset, int inReceiverPlaneCount);
        }

        struct BatchCullingOutput
        {
            /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.BatchCullingOutputDrawCommands> drawCommands;
        }

        struct BatchRendererCullingOutput
        {
            /*0x10*/ Unity.Jobs.JobHandle cullingJobsFence;
            /*0x20*/ UnityEngine.Matrix4x4 localToWorldMatrix;
            /*0x60*/ UnityEngine.Plane* cullingPlanes;
            /*0x68*/ int cullingPlaneCount;
            /*0x6c*/ int receiverPlaneOffset;
            /*0x70*/ int receiverPlaneCount;
            /*0x78*/ UnityEngine.Rendering.CullingSplit* cullingSplits;
            /*0x80*/ int cullingSplitCount;
            /*0x84*/ UnityEngine.Rendering.BatchCullingViewType viewType;
            /*0x88*/ UnityEngine.Rendering.BatchCullingProjectionType projectionType;
            /*0x8c*/ UnityEngine.Rendering.BatchCullingFlags cullingFlags;
            /*0x90*/ ulong viewID;
            /*0x98*/ uint cullingLayerMask;
            /*0xa0*/ ulong sceneCullingMask;
            /*0xa8*/ UnityEngine.Rendering.BatchCullingOutputDrawCommands* drawCommands;
        }

        class BatchRendererGroup
        {
            /*0x10*/ nint m_GroupHandle;
            /*0x18*/ UnityEngine.Rendering.BatchRendererGroup.OnPerformCulling m_PerformCulling;

            static /*0x1613230*/ void InvokeOnPerformCulling(UnityEngine.Rendering.BatchRendererGroup group, ref UnityEngine.Rendering.BatchRendererCullingOutput context, ref UnityEngine.Rendering.LODParameters lodParameters, nint userContext);

            class OnPerformCulling : System.MulticastDelegate
            {
                /*0x161b050*/ OnPerformCulling(object object, nint method);
                /*0x161af70*/ Unity.Jobs.JobHandle Invoke(UnityEngine.Rendering.BatchRendererGroup rendererGroup, UnityEngine.Rendering.BatchCullingContext cullingContext, UnityEngine.Rendering.BatchCullingOutput cullingOutput, nint userContext);
            }
        }

        struct AttachmentDescriptor : System.IEquatable<UnityEngine.Rendering.AttachmentDescriptor>
        {
            /*0x10*/ UnityEngine.Rendering.RenderBufferLoadAction m_LoadAction;
            /*0x14*/ UnityEngine.Rendering.RenderBufferStoreAction m_StoreAction;
            /*0x18*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_Format;
            /*0x20*/ UnityEngine.Rendering.RenderTargetIdentifier m_LoadStoreTarget;
            /*0x48*/ UnityEngine.Rendering.RenderTargetIdentifier m_ResolveTarget;
            /*0x70*/ UnityEngine.Color m_ClearColor;
            /*0x80*/ float m_ClearDepth;
            /*0x84*/ uint m_ClearStencil;

            static /*0x1612da0*/ bool op_Inequality(UnityEngine.Rendering.AttachmentDescriptor left, UnityEngine.Rendering.AttachmentDescriptor right);
            /*0x1612cb0*/ AttachmentDescriptor(UnityEngine.Experimental.Rendering.GraphicsFormat format);
            /*0x6bbd40*/ void set_loadAction(UnityEngine.Rendering.RenderBufferLoadAction value);
            /*0xfc2c10*/ void set_storeAction(UnityEngine.Rendering.RenderBufferStoreAction value);
            /*0xb73eb0*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
            /*0x1612d80*/ UnityEngine.Rendering.RenderTargetIdentifier get_loadStoreTarget();
            /*0x1612e10*/ void set_loadStoreTarget(UnityEngine.Rendering.RenderTargetIdentifier value);
            /*0x16128e0*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier target, bool loadExistingContents, bool storeResults);
            /*0x16128a0*/ void ConfigureResolveTarget(UnityEngine.Rendering.RenderTargetIdentifier target);
            /*0x1612880*/ void ConfigureClear(UnityEngine.Color clearColor, float clearDepth, uint clearStencil);
            /*0x1612a30*/ bool Equals(UnityEngine.Rendering.AttachmentDescriptor other);
            /*0x1612930*/ bool Equals(object obj);
            /*0x1612c20*/ int GetHashCode();
        }

        struct BlendState : System.IEquatable<UnityEngine.Rendering.BlendState>
        {
            /*0x10*/ UnityEngine.Rendering.RenderTargetBlendState m_BlendState0;
            /*0x18*/ UnityEngine.Rendering.RenderTargetBlendState m_BlendState1;
            /*0x20*/ UnityEngine.Rendering.RenderTargetBlendState m_BlendState2;
            /*0x28*/ UnityEngine.Rendering.RenderTargetBlendState m_BlendState3;
            /*0x30*/ UnityEngine.Rendering.RenderTargetBlendState m_BlendState4;
            /*0x38*/ UnityEngine.Rendering.RenderTargetBlendState m_BlendState5;
            /*0x40*/ UnityEngine.Rendering.RenderTargetBlendState m_BlendState6;
            /*0x48*/ UnityEngine.Rendering.RenderTargetBlendState m_BlendState7;
            /*0x50*/ byte m_SeparateMRTBlendStates;
            /*0x51*/ byte m_AlphaToMask;
            /*0x52*/ short m_Padding;

            static /*0x1613de0*/ UnityEngine.Rendering.BlendState get_defaultValue();
            /*0x1613cd0*/ BlendState(bool separateMRTBlend, bool alphaToMask);
            /*0x9e29e0*/ void set_blendState0(UnityEngine.Rendering.RenderTargetBlendState value);
            /*0x1613530*/ bool Equals(UnityEngine.Rendering.BlendState other);
            /*0x1613800*/ bool Equals(object obj);
            /*0x16138c0*/ int GetHashCode();
        }

        struct CoreCameraValues : System.IEquatable<UnityEngine.Rendering.CoreCameraValues>
        {
            /*0x10*/ int filterMode;
            /*0x14*/ uint cullingMask;
            /*0x18*/ int instanceID;

            /*0x1616040*/ bool Equals(UnityEngine.Rendering.CoreCameraValues other);
            /*0x1616060*/ bool Equals(object obj);
            /*0x1616130*/ int GetHashCode();
        }

        struct CameraProperties : System.IEquatable<UnityEngine.Rendering.CameraProperties>
        {
            static int k_NumLayers = 32;
            static int k_PlaneCount = 6;
            /*0x10*/ UnityEngine.Rect screenRect;
            /*0x20*/ UnityEngine.Vector3 viewDir;
            /*0x2c*/ float projectionNear;
            /*0x30*/ float projectionFar;
            /*0x34*/ float cameraNear;
            /*0x38*/ float cameraFar;
            /*0x3c*/ float cameraAspect;
            /*0x40*/ UnityEngine.Matrix4x4 cameraToWorld;
            /*0x80*/ UnityEngine.Matrix4x4 actualWorldToClip;
            /*0xc0*/ UnityEngine.Matrix4x4 cameraClipToWorld;
            /*0x100*/ UnityEngine.Matrix4x4 cameraWorldToClip;
            /*0x140*/ UnityEngine.Matrix4x4 implicitProjection;
            /*0x180*/ UnityEngine.Matrix4x4 stereoWorldToClipLeft;
            /*0x1c0*/ UnityEngine.Matrix4x4 stereoWorldToClipRight;
            /*0x200*/ UnityEngine.Matrix4x4 worldToCamera;
            /*0x240*/ UnityEngine.Vector3 up;
            /*0x24c*/ UnityEngine.Vector3 right;
            /*0x258*/ UnityEngine.Vector3 transformDirection;
            /*0x264*/ UnityEngine.Vector3 cameraEuler;
            /*0x270*/ UnityEngine.Vector3 velocity;
            /*0x27c*/ float farPlaneWorldSpaceLength;
            /*0x280*/ uint rendererCount;
            /*0x284*/ UnityEngine.Rendering.CameraProperties.<m_ShadowCullPlanes> m_ShadowCullPlanes;
            /*0x2e4*/ UnityEngine.Rendering.CameraProperties.<m_CameraCullPlanes> m_CameraCullPlanes;
            /*0x344*/ float baseFarDistance;
            /*0x348*/ UnityEngine.Vector3 shadowCullCenter;
            /*0x354*/ UnityEngine.Rendering.CameraProperties.<layerCullDistances> layerCullDistances;
            /*0x3d4*/ int layerCullSpherical;
            /*0x3d8*/ UnityEngine.Rendering.CoreCameraValues coreCameraValues;
            /*0x3e4*/ uint cameraType;
            /*0x3e8*/ int projectionIsOblique;
            /*0x3ec*/ int isImplicitProjectionMatrix;

            /*0x1615ef0*/ UnityEngine.Plane GetShadowCullingPlane(int index);
            /*0x16158f0*/ UnityEngine.Plane GetCameraCullingPlane(int index);
            /*0x1613fa0*/ bool Equals(UnityEngine.Rendering.CameraProperties other);
            /*0x16157b0*/ bool Equals(object obj);
            /*0x1615a00*/ int GetHashCode();

            struct <layerCullDistances>e__FixedBuffer
            {
                /*0x10*/ float FixedElementField;
            }

            struct <m_CameraCullPlanes>e__FixedBuffer
            {
                /*0x10*/ byte FixedElementField;
            }

            struct <m_ShadowCullPlanes>e__FixedBuffer
            {
                /*0x10*/ byte FixedElementField;
            }
        }

        enum CullingOptions
        {
            None = 0,
            ForceEvenIfCameraIsNotActive = 1,
            OcclusionCull = 2,
            NeedsLighting = 4,
            NeedsReflectionProbes = 8,
            Stereo = 16,
            DisablePerObjectCulling = 32,
            ShadowCasters = 64,
        }

        struct ScriptableCullingParameters : System.IEquatable<UnityEngine.Rendering.ScriptableCullingParameters>
        {
            static int k_MaximumCullingPlaneCount = 10;
            static int k_LayerCount = 32;
            static int k_CullingJobCountLowerLimit = 1;
            static int k_CullingJobCountUpperLimit = 16;
            static /*0x0*/ int maximumCullingPlaneCount;
            static /*0x4*/ int layerCount;
            /*0x10*/ int m_IsOrthographic;
            /*0x14*/ UnityEngine.Rendering.LODParameters m_LODParameters;
            /*0x30*/ UnityEngine.Rendering.ScriptableCullingParameters.<m_CullingPlanes> m_CullingPlanes;
            /*0xd0*/ int m_CullingPlaneCount;
            /*0xd4*/ uint m_CullingMask;
            /*0xd8*/ ulong m_SceneMask;
            /*0xe0*/ ulong m_ViewID;
            /*0xe8*/ UnityEngine.Rendering.ScriptableCullingParameters.<m_LayerFarCullDistances> m_LayerFarCullDistances;
            /*0x168*/ int m_LayerCull;
            /*0x16c*/ UnityEngine.Matrix4x4 m_CullingMatrix;
            /*0x1ac*/ UnityEngine.Vector3 m_Origin;
            /*0x1b8*/ float m_ShadowDistance;
            /*0x1bc*/ float m_ShadowNearPlaneOffset;
            /*0x1c0*/ UnityEngine.Rendering.CullingOptions m_CullingOptions;
            /*0x1c4*/ UnityEngine.Rendering.ReflectionProbeSortingCriteria m_ReflectionProbeSortingCriteria;
            /*0x1c8*/ UnityEngine.Rendering.CameraProperties m_CameraProperties;
            /*0x5a8*/ float m_AccurateOcclusionThreshold;
            /*0x5ac*/ int m_MaximumPortalCullingJobs;
            /*0x5b0*/ UnityEngine.Matrix4x4 m_StereoViewMatrix;
            /*0x5f0*/ UnityEngine.Matrix4x4 m_StereoProjectionMatrix;
            /*0x630*/ float m_StereoSeparationDistance;
            /*0x634*/ int m_maximumVisibleLights;
            /*0x638*/ bool m_ConservativeEnclosingSphere;
            /*0x63c*/ int m_NumIterationsEnclosingSphere;

            static /*0x1621990*/ ScriptableCullingParameters();
            /*0x1621ab0*/ void set_maximumVisibleLights(int value);
            /*0x1621a30*/ void set_conservativeEnclosingSphere(bool value);
            /*0x1621ac0*/ void set_numIterationsEnclosingSphere(int value);
            /*0x16219f0*/ int get_cullingPlaneCount();
            /*0x1621a50*/ void set_isOrthographic(bool value);
            /*0x1621ae0*/ void set_shadowDistance(float value);
            /*0x16219e0*/ UnityEngine.Rendering.CullingOptions get_cullingOptions();
            /*0x1621a40*/ void set_cullingOptions(UnityEngine.Rendering.CullingOptions value);
            /*0x1621ad0*/ void set_reflectionProbeSortingCriteria(UnityEngine.Rendering.ReflectionProbeSortingCriteria value);
            /*0x1621b30*/ void set_stereoViewMatrix(UnityEngine.Matrix4x4 value);
            /*0x1621a00*/ UnityEngine.Matrix4x4 get_stereoProjectionMatrix();
            /*0x1621af0*/ void set_stereoProjectionMatrix(UnityEngine.Matrix4x4 value);
            /*0x1621b20*/ void set_stereoSeparationDistance(float value);
            /*0x1621890*/ float GetLayerCullingDistance(int layerIndex);
            /*0x16214f0*/ UnityEngine.Plane GetCullingPlane(int index);
            /*0x1620da0*/ bool Equals(UnityEngine.Rendering.ScriptableCullingParameters other);
            /*0x1621420*/ bool Equals(object obj);
            /*0x1621640*/ int GetHashCode();

            struct <m_CullingPlanes>e__FixedBuffer
            {
                /*0x10*/ byte FixedElementField;
            }

            struct <m_LayerFarCullDistances>e__FixedBuffer
            {
                /*0x10*/ float FixedElementField;
            }
        }

        struct CullingResults : System.IEquatable<UnityEngine.Rendering.CullingResults>
        {
            /*0x10*/ nint ptr;
            /*0x18*/ UnityEngine.Rendering.CullingAllocationInfo* m_AllocationInfo;

            static /*0x1616870*/ int GetLightIndexCount(nint cullingResultsPtr);
            static /*0x1616a00*/ int GetReflectionProbeIndexCount(nint cullingResultsPtr);
            static /*0x16167a0*/ void FillLightAndReflectionProbeIndices(nint cullingResultsPtr, UnityEngine.ComputeBuffer computeBuffer);
            static /*0x16168b0*/ int GetLightIndexMapSize(nint cullingResultsPtr);
            static /*0x16167f0*/ void FillLightIndexMap(nint cullingResultsPtr, nint indexMapPtr, int indexMapSize);
            static /*0x1616b80*/ void SetLightIndexMap(nint cullingResultsPtr, nint indexMapPtr, int indexMapSize);
            static /*0x1616a90*/ bool GetShadowCasterBounds(nint cullingResultsPtr, int lightIndex, ref UnityEngine.Bounds bounds);
            static /*0x1616500*/ bool ComputeSpotShadowMatricesAndCullingPrimitives(nint cullingResultsPtr, int activeLightIndex, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            static /*0x16164a0*/ bool ComputePointShadowMatricesAndCullingPrimitives(nint cullingResultsPtr, int activeLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            static /*0x1616380*/ bool ComputeDirectionalShadowMatricesAndCullingPrimitives(nint cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, UnityEngine.Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            static /*0x1616d50*/ bool op_Equality(UnityEngine.Rendering.CullingResults left, UnityEngine.Rendering.CullingResults right);
            static /*0x1616240*/ bool ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(nint cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, ref UnityEngine.Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x1616c50*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> get_visibleLights();
            /*0x1616cd0*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleReflectionProbe> get_visibleReflectionProbes();
            /*0x2a5510*/ Unity.Collections.NativeArray<T> GetNativeArray<T>(void* dataPointer, int length);
            /*0x1616be0*/ int get_lightAndReflectionProbeIndexCount();
            /*0x1616750*/ void FillLightAndReflectionProbeIndices(UnityEngine.ComputeBuffer computeBuffer);
            /*0x16168f0*/ Unity.Collections.NativeArray<int> GetLightIndexMap(Unity.Collections.Allocator allocator);
            /*0x1616ae0*/ void SetLightIndexMap(Unity.Collections.NativeArray<int> lightIndexMap);
            /*0x1616a40*/ bool GetShadowCasterBounds(int lightIndex, ref UnityEngine.Bounds outBounds);
            /*0x1616560*/ bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x1616440*/ bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x16162b0*/ bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, UnityEngine.Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x16166d0*/ bool Equals(UnityEngine.Rendering.CullingResults other);
            /*0x16165c0*/ bool Equals(object obj);
            /*0x1616850*/ int GetHashCode();
        }

        struct CullingAllocationInfo
        {
            /*0x10*/ UnityEngine.Rendering.VisibleLight* visibleLightsPtr;
            /*0x18*/ UnityEngine.Rendering.VisibleLight* visibleOffscreenVertexLightsPtr;
            /*0x20*/ UnityEngine.Rendering.VisibleReflectionProbe* visibleReflectionProbesPtr;
            /*0x28*/ int visibleLightCount;
            /*0x2c*/ int visibleOffscreenVertexLightCount;
            /*0x30*/ int visibleReflectionProbeCount;
        }

        struct DepthState : System.IEquatable<UnityEngine.Rendering.DepthState>
        {
            /*0x10*/ byte m_WriteEnabled;
            /*0x11*/ sbyte m_CompareFunction;

            static /*0x1616f60*/ UnityEngine.Rendering.DepthState get_defaultValue();
            /*0x1616ee0*/ DepthState(bool writeEnabled, UnityEngine.Rendering.CompareFunction compareFunction);
            /*0x1616f50*/ UnityEngine.Rendering.CompareFunction get_compareFunction();
            /*0x1616e80*/ bool Equals(UnityEngine.Rendering.DepthState other);
            /*0x1616dd0*/ bool Equals(object obj);
            /*0x1616ea0*/ int GetHashCode();
        }

        struct DrawingSettings : System.IEquatable<UnityEngine.Rendering.DrawingSettings>
        {
            static /*0x0*/ int maxShaderPasses;
            /*0x10*/ UnityEngine.Rendering.SortingSettings m_SortingSettings;
            /*0x70*/ UnityEngine.Rendering.DrawingSettings.<shaderPassNames> shaderPassNames;
            /*0xb0*/ UnityEngine.Rendering.PerObjectData m_PerObjectData;
            /*0xb4*/ UnityEngine.Rendering.DrawRendererFlags m_Flags;
            /*0xb8*/ int m_OverrideShaderID;
            /*0xbc*/ int m_OverrideShaderPassIndex;
            /*0xc0*/ int m_OverrideMaterialInstanceId;
            /*0xc4*/ int m_OverrideMaterialPassIndex;
            /*0xc8*/ int m_fallbackMaterialInstanceId;
            /*0xcc*/ int m_MainLightIndex;
            /*0xd0*/ int m_UseSrpBatcher;

            static /*0x16178f0*/ DrawingSettings();
            static /*0x1617a70*/ bool op_Equality(UnityEngine.Rendering.DrawingSettings left, UnityEngine.Rendering.DrawingSettings right);
            /*0x1617930*/ DrawingSettings(UnityEngine.Rendering.ShaderTagId shaderPassName, UnityEngine.Rendering.SortingSettings sortingSettings);
            /*0x1617a30*/ UnityEngine.Rendering.SortingSettings get_sortingSettings();
            /*0x1617c70*/ void set_sortingSettings(UnityEngine.Rendering.SortingSettings value);
            /*0xbf30c0*/ void set_perObjectData(UnityEngine.Rendering.PerObjectData value);
            /*0x1617b60*/ void set_enableDynamicBatching(bool value);
            /*0x1617b80*/ void set_enableInstancing(bool value);
            /*0x1617bf0*/ void set_overrideMaterial(UnityEngine.Material value);
            /*0x1617c30*/ void set_overrideShader(UnityEngine.Shader value);
            /*0xbf2f00*/ void set_overrideMaterialPassIndex(int value);
            /*0xb69c80*/ void set_overrideShaderPassIndex(int value);
            /*0x1617ba0*/ void set_fallbackMaterial(UnityEngine.Material value);
            /*0x1617be0*/ void set_mainLightIndex(int value);
            /*0x1617660*/ UnityEngine.Rendering.ShaderTagId GetShaderPassName(int index);
            /*0x16177a0*/ void SetShaderPassName(int index, UnityEngine.Rendering.ShaderTagId shaderPassName);
            /*0x1617100*/ bool Equals(UnityEngine.Rendering.DrawingSettings other);
            /*0x1616fc0*/ bool Equals(object obj);
            /*0x1617600*/ int GetHashCode();

            struct <shaderPassNames>e__FixedBuffer
            {
                /*0x10*/ int FixedElementField;
            }
        }

        enum DrawRendererFlags
        {
            None = 0,
            EnableDynamicBatching = 1,
            EnableInstancing = 2,
        }

        struct FilteringSettings : System.IEquatable<UnityEngine.Rendering.FilteringSettings>
        {
            /*0x10*/ UnityEngine.Rendering.RenderQueueRange m_RenderQueueRange;
            /*0x18*/ int m_LayerMask;
            /*0x1c*/ uint m_RenderingLayerMask;
            /*0x20*/ int m_ExcludeMotionVectorObjects;
            /*0x24*/ UnityEngine.Rendering.SortingLayerRange m_SortingLayerRange;

            static /*0x1617f40*/ UnityEngine.Rendering.FilteringSettings get_defaultValue();
            static /*0x1617ca0*/ bool op_Equality(UnityEngine.Rendering.FilteringSettings left, UnityEngine.Rendering.FilteringSettings right);
            /*0x1617e60*/ FilteringSettings(System.Nullable<UnityEngine.Rendering.RenderQueueRange> renderQueueRange, int layerMask, uint renderingLayerMask, int excludeMotionVectorObjects);
            /*0x69af20*/ UnityEngine.Rendering.RenderQueueRange get_renderQueueRange();
            /*0x9e29e0*/ void set_renderQueueRange(UnityEngine.Rendering.RenderQueueRange value);
            /*0xf0fbd0*/ void set_layerMask(int value);
            /*0xf0fbc0*/ void set_renderingLayerMask(uint value);
            /*0x1618010*/ void set_excludeMotionVectorObjects(bool value);
            /*0xc70b20*/ void set_sortingLayerRange(UnityEngine.Rendering.SortingLayerRange value);
            /*0x1617ca0*/ bool Equals(UnityEngine.Rendering.FilteringSettings other);
            /*0x1617d50*/ bool Equals(object obj);
            /*0x1617df0*/ int GetHashCode();
        }

        enum GizmoSubset
        {
            PreImageEffects = 0,
            PostImageEffects = 1,
        }

        struct LODParameters : System.IEquatable<UnityEngine.Rendering.LODParameters>
        {
            /*0x10*/ int m_IsOrthographic;
            /*0x14*/ UnityEngine.Vector3 m_CameraPosition;
            /*0x20*/ float m_FieldOfView;
            /*0x24*/ float m_OrthoSize;
            /*0x28*/ int m_CameraPixelHeight;

            /*0x1618c40*/ bool Equals(UnityEngine.Rendering.LODParameters other);
            /*0x1618ce0*/ bool Equals(object obj);
            /*0x1618d90*/ int GetHashCode();
        }

        enum PerObjectData
        {
            None = 0,
            LightProbe = 1,
            ReflectionProbes = 2,
            LightProbeProxyVolume = 4,
            Lightmaps = 8,
            LightData = 16,
            MotionVectors = 32,
            LightIndices = 64,
            ReflectionProbeData = 128,
            OcclusionProbe = 256,
            OcclusionProbeProxyVolume = 512,
            ShadowMask = 1024,
        }

        struct RasterState : System.IEquatable<UnityEngine.Rendering.RasterState>
        {
            static /*0x0*/ UnityEngine.Rendering.RasterState defaultValue;
            /*0x10*/ UnityEngine.Rendering.CullMode m_CullingMode;
            /*0x14*/ int m_OffsetUnits;
            /*0x18*/ float m_OffsetFactor;
            /*0x1c*/ byte m_DepthClip;
            /*0x1d*/ byte m_Conservative;
            /*0x1e*/ byte m_Padding1;
            /*0x1f*/ byte m_Padding2;

            static /*0x161c0f0*/ RasterState();
            /*0x161c190*/ RasterState(UnityEngine.Rendering.CullMode cullingMode, int offsetUnits, float offsetFactor, bool depthClip);
            /*0x161bf10*/ bool Equals(UnityEngine.Rendering.RasterState other);
            /*0x161bf70*/ bool Equals(object obj);
            /*0x161c080*/ int GetHashCode();
        }

        enum ReflectionProbeSortingCriteria
        {
            None = 0,
            Importance = 1,
            Size = 2,
            ImportanceThenSize = 3,
        }

        struct RendererList
        {
            static /*0x0*/ UnityEngine.Rendering.RendererList nullRendererList;
            /*0x10*/ nuint context;
            /*0x18*/ uint index;
            /*0x1c*/ uint frame;
            /*0x20*/ uint type;

            static /*0x1620bc0*/ RendererList();
            static /*0x1620c30*/ bool get_isValid_Injected(ref UnityEngine.Rendering.RendererList _unity_self);
            /*0x1620c20*/ RendererList(nuint ctx, uint indx);
            /*0x1620c70*/ bool get_isValid();
        }

        enum RendererListStatus
        {
            kRendererListInvalid = -2,
            kRendererListProcessing = -1,
            kRendererListEmpty = 0,
            kRendererListPopulated = 1,
        }

        struct RendererListParams : System.IEquatable<UnityEngine.Rendering.RendererListParams>
        {
            static /*0x0*/ UnityEngine.Rendering.RendererListParams Invalid;
            /*0x10*/ UnityEngine.Rendering.CullingResults cullingResults;
            /*0x20*/ UnityEngine.Rendering.DrawingSettings drawSettings;
            /*0xe4*/ UnityEngine.Rendering.FilteringSettings filteringSettings;
            /*0xfc*/ UnityEngine.Rendering.ShaderTagId tagName;
            /*0x100*/ bool isPassTagName;
            /*0x108*/ System.Nullable<Unity.Collections.NativeArray<UnityEngine.Rendering.ShaderTagId>> tagValues;
            /*0x120*/ System.Nullable<Unity.Collections.NativeArray<UnityEngine.Rendering.RenderStateBlock>> stateBlocks;

            static /*0x16209d0*/ RendererListParams();
            /*0x1620a10*/ int get_numStateBlocks();
            /*0x1620a80*/ nint get_stateBlocksPtr();
            /*0x1620b20*/ nint get_tagsValuePtr();
            /*0x161f8b0*/ void Dispose();
            /*0x16204c0*/ void Validate();
            /*0x161fb00*/ bool Equals(UnityEngine.Rendering.RendererListParams other);
            /*0x161f9c0*/ bool Equals(object obj);
            /*0x16202e0*/ int GetHashCode();
        }

        class RenderPipeline
        {
            /*0x10*/ bool <disposed>k__BackingField;

            static /*0x161dda0*/ void BeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x161dcf0*/ void BeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            static /*0x161dfe0*/ void EndContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x161df30*/ void EndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            /*0x32f970*/ RenderPipeline();
            void Render(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera[] cameras);
            /*0x2a5510*/ void ProcessRenderRequests<RequestData>(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, RequestData renderRequest);
            /*0x2a5510*/ bool IsRenderRequestSupported<RequestData>(UnityEngine.Camera camera, RequestData data);
            /*0x161e190*/ void Render(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x161e100*/ void InternalRender(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x2a5510*/ void InternalProcessRenderRequests<RequestData>(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, RequestData renderRequest);
            /*0x793eb0*/ bool get_disposed();
            /*0x793ec0*/ void set_disposed(bool value);
            /*0x161dec0*/ void Dispose();
            /*0x32d010*/ void Dispose(bool disposing);
            /*0xbf9940*/ UnityEngine.Rendering.RenderPipelineGlobalSettings get_defaultSettings();

            class StandardRequest
            {
                /*0x10*/ UnityEngine.RenderTexture destination;
                /*0x18*/ int mipLevel;
                /*0x1c*/ UnityEngine.CubemapFace face;
                /*0x20*/ int slice;
            }
        }

        class RenderPipelineAsset : UnityEngine.ScriptableObject
        {
            /*0x533ec0*/ RenderPipelineAsset();
            /*0x161c220*/ UnityEngine.Rendering.RenderPipeline InternalCreatePipeline();
            /*0x388e90*/ string[] get_renderingLayerMaskNames();
            /*0x388e90*/ string[] get_prefixedRenderingLayerMaskNames();
            /*0x388e90*/ UnityEngine.Material get_defaultMaterial();
            /*0x388e90*/ UnityEngine.Shader get_autodeskInteractiveShader();
            /*0x388e90*/ UnityEngine.Shader get_autodeskInteractiveTransparentShader();
            /*0x388e90*/ UnityEngine.Shader get_autodeskInteractiveMaskedShader();
            /*0x388e90*/ UnityEngine.Shader get_terrainDetailLitShader();
            /*0x388e90*/ UnityEngine.Shader get_terrainDetailGrassShader();
            /*0x388e90*/ UnityEngine.Shader get_terrainDetailGrassBillboardShader();
            /*0x388e90*/ UnityEngine.Material get_defaultParticleMaterial();
            /*0x388e90*/ UnityEngine.Material get_defaultLineMaterial();
            /*0x388e90*/ UnityEngine.Material get_defaultTerrainMaterial();
            /*0x388e90*/ UnityEngine.Material get_defaultUIMaterial();
            /*0x388e90*/ UnityEngine.Material get_defaultUIOverdrawMaterial();
            /*0x388e90*/ UnityEngine.Material get_defaultUIETC1SupportedMaterial();
            /*0x388e90*/ UnityEngine.Material get_default2DMaterial();
            /*0x388e90*/ UnityEngine.Material get_default2DMaskMaterial();
            /*0x388e90*/ UnityEngine.Shader get_defaultShader();
            /*0x388e90*/ UnityEngine.Shader get_defaultSpeedTree7Shader();
            /*0x388e90*/ UnityEngine.Shader get_defaultSpeedTree8Shader();
            /*0x161c500*/ string get_renderPipelineShaderTag();
            /*0x1803b0*/ UnityEngine.Rendering.RenderPipeline CreatePipeline();
            /*0x161c440*/ void OnValidate();
            /*0x161c400*/ void OnDisable();
        }

        class RenderPipelineGlobalSettings : UnityEngine.ScriptableObject
        {
            /*0x533ec0*/ RenderPipelineGlobalSettings();
        }

        class RenderPipelineManager
        {
            static /*0x0*/ UnityEngine.Rendering.RenderPipelineAsset s_CurrentPipelineAsset;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.Camera> s_Cameras;
            static /*0x10*/ string s_CurrentPipelineType;
            static /*0x18*/ UnityEngine.Rendering.RenderPipeline s_CurrentPipeline;
            static /*0x20*/ System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera[]> beginFrameRendering;
            static /*0x28*/ System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera[]> endFrameRendering;
            static /*0x30*/ System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> beginContextRendering;
            static /*0x38*/ System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> endContextRendering;
            static /*0x40*/ System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> beginCameraRendering;
            static /*0x48*/ System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> endCameraRendering;
            static /*0x50*/ System.Action activeRenderPipelineTypeChanged;
            static /*0x58*/ System.Action<UnityEngine.Rendering.RenderPipelineAsset, UnityEngine.Rendering.RenderPipelineAsset> activeRenderPipelineAssetChanged;
            static /*0x60*/ System.Action activeRenderPipelineCreated;
            static /*0x68*/ System.Action activeRenderPipelineDisposed;

            static /*0x161d660*/ RenderPipelineManager();
            static /*0x161d980*/ UnityEngine.Rendering.RenderPipeline get_currentPipeline();
            static /*0x161dbf0*/ void set_currentPipeline(UnityEngine.Rendering.RenderPipeline value);
            static /*0x161d760*/ void add_beginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x161d9d0*/ void remove_beginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x161d870*/ void add_endCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x161dae0*/ void remove_endCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x161c600*/ void BeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x161c580*/ void BeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            static /*0x161cf20*/ void EndContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x161cea0*/ void EndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            static /*0x161d380*/ void OnActiveRenderPipelineTypeChanged();
            static /*0x161d270*/ void OnActiveRenderPipelineAssetChanged(UnityEngine.ScriptableObject from, UnityEngine.ScriptableObject to);
            static /*0x161d060*/ void HandleRenderPipelineChange(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset);
            static /*0x161c6f0*/ void CleanupRenderPipeline();
            static /*0x161d010*/ string GetCurrentPipelineAssetType();
            static /*0x161ca40*/ void DoRenderLoop_Internal(UnityEngine.Rendering.RenderPipelineAsset pipe, nint loopPtr, UnityEngine.Object renderRequest);
            static /*0x161d3f0*/ void PrepareRenderPipeline(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset);
            static /*0x161d100*/ bool IsPipelineRequireCreation();
        }

        struct RenderQueueRange : System.IEquatable<UnityEngine.Rendering.RenderQueueRange>
        {
            static int k_MinimumBound = 0;
            static int k_MaximumBound = 5000;
            static /*0x0*/ int minimumBound;
            static /*0x4*/ int maximumBound;
            /*0x10*/ int m_LowerBound;
            /*0x14*/ int m_UpperBound;

            static /*0x161e300*/ RenderQueueRange();
            static /*0x161e350*/ UnityEngine.Rendering.RenderQueueRange get_all();
            static /*0x161e370*/ UnityEngine.Rendering.RenderQueueRange get_opaque();
            static /*0x161e390*/ UnityEngine.Rendering.RenderQueueRange get_transparent();
            static /*0x161e3b0*/ bool op_Equality(UnityEngine.Rendering.RenderQueueRange left, UnityEngine.Rendering.RenderQueueRange right);
            /*0x161e210*/ bool Equals(UnityEngine.Rendering.RenderQueueRange other);
            /*0x161e230*/ bool Equals(object obj);
            /*0x161e2f0*/ int GetHashCode();
        }

        struct RenderStateBlock : System.IEquatable<UnityEngine.Rendering.RenderStateBlock>
        {
            /*0x10*/ UnityEngine.Rendering.BlendState m_BlendState;
            /*0x54*/ UnityEngine.Rendering.RasterState m_RasterState;
            /*0x64*/ UnityEngine.Rendering.DepthState m_DepthState;
            /*0x66*/ UnityEngine.Rendering.StencilState m_StencilState;
            /*0x74*/ int m_StencilReference;
            /*0x78*/ UnityEngine.Rendering.RenderStateMask m_Mask;

            /*0x161e880*/ RenderStateBlock(UnityEngine.Rendering.RenderStateMask mask);
            /*0x161ea50*/ void set_blendState(UnityEngine.Rendering.BlendState value);
            /*0x161ea90*/ void set_rasterState(UnityEngine.Rendering.RasterState value);
            /*0x161ea00*/ UnityEngine.Rendering.DepthState get_depthState();
            /*0x161ea80*/ void set_depthState(UnityEngine.Rendering.DepthState value);
            /*0x161ea30*/ UnityEngine.Rendering.StencilState get_stencilState();
            /*0x161eaa0*/ void set_stencilState(UnityEngine.Rendering.StencilState value);
            /*0x161ea20*/ int get_stencilReference();
            /*0x137dee0*/ void set_stencilReference(int value);
            /*0x161ea10*/ UnityEngine.Rendering.RenderStateMask get_mask();
            /*0x1355400*/ void set_mask(UnityEngine.Rendering.RenderStateMask value);
            /*0x161e430*/ bool Equals(UnityEngine.Rendering.RenderStateBlock other);
            /*0x161e660*/ bool Equals(object obj);
            /*0x161e760*/ int GetHashCode();
        }

        enum RenderStateMask
        {
            Nothing = 0,
            Blend = 1,
            Raster = 2,
            Depth = 4,
            Stencil = 8,
            Everything = 15,
        }

        struct RenderTargetBlendState : System.IEquatable<UnityEngine.Rendering.RenderTargetBlendState>
        {
            /*0x10*/ byte m_WriteMask;
            /*0x11*/ byte m_SourceColorBlendMode;
            /*0x12*/ byte m_DestinationColorBlendMode;
            /*0x13*/ byte m_SourceAlphaBlendMode;
            /*0x14*/ byte m_DestinationAlphaBlendMode;
            /*0x15*/ byte m_ColorBlendOperation;
            /*0x16*/ byte m_AlphaBlendOperation;
            /*0x17*/ byte m_Padding;

            static /*0x161ecd0*/ UnityEngine.Rendering.RenderTargetBlendState get_defaultValue();
            /*0x161eca0*/ RenderTargetBlendState(UnityEngine.Rendering.ColorWriteMask writeMask, UnityEngine.Rendering.BlendMode sourceColorBlendMode, UnityEngine.Rendering.BlendMode destinationColorBlendMode, UnityEngine.Rendering.BlendMode sourceAlphaBlendMode, UnityEngine.Rendering.BlendMode destinationAlphaBlendMode, UnityEngine.Rendering.BlendOp colorBlendOperation, UnityEngine.Rendering.BlendOp alphaBlendOperation);
            /*0x161eab0*/ bool Equals(UnityEngine.Rendering.RenderTargetBlendState other);
            /*0x161eb00*/ bool Equals(object obj);
            /*0x161ebf0*/ int GetHashCode();
        }

        struct ScriptableRenderContext : System.IEquatable<UnityEngine.Rendering.ScriptableRenderContext>
        {
            static /*0x0*/ UnityEngine.Rendering.ShaderTagId kRenderTypeTag;
            /*0x10*/ nint m_Ptr;

            static /*0x1624960*/ ScriptableRenderContext();
            static /*0x1621b60*/ void BeginRenderPass_Internal(nint self, int width, int height, int volumeDepth, int samples, nint colors, int colorCount, int depthAttachmentIndex);
            static /*0x1621cc0*/ void BeginSubPass_Internal(nint self, nint colors, int colorCount, nint inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly);
            static /*0x1623820*/ void EndSubPass_Internal(nint self);
            static /*0x1623770*/ void EndRenderPass_Internal(nint self);
            static /*0x1624010*/ void Internal_Cull(ref UnityEngine.Rendering.ScriptableCullingParameters parameters, UnityEngine.Rendering.ScriptableRenderContext renderLoop, nint results);
            static /*0x1623f60*/ void InitializeSortSettings(UnityEngine.Camera camera, ref UnityEngine.Rendering.SortingSettings sortingSettings);
            static /*0x1623730*/ void EmitGeometryForCamera(UnityEngine.Camera camera);
            static /*0x1623fb0*/ void Internal_Cull_Injected(ref UnityEngine.Rendering.ScriptableCullingParameters parameters, ref UnityEngine.Rendering.ScriptableRenderContext renderLoop, nint results);
            static /*0x1624810*/ void Submit_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self);
            static /*0x16246c0*/ bool SubmitForRenderPassValidation_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self);
            static /*0x1623dc0*/ void GetCameras_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, System.Type listType, object resultList);
            static /*0x1622d40*/ void DrawRenderers_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.ShaderTagId tagName, bool isPassTagName, nint tagValues, nint stateBlocks, int stateCount);
            static /*0x1623390*/ void DrawShadows_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint shadowDrawingSettings);
            static /*0x1623be0*/ void ExecuteCommandBuffer_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, UnityEngine.Rendering.CommandBuffer commandBuffer);
            static /*0x16239d0*/ void ExecuteCommandBufferAsync_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType);
            static /*0x16244a0*/ void SetupCameraProperties_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, UnityEngine.Camera camera, bool stereoSetup, int eye);
            static /*0x1624090*/ void InvokeOnRenderObjectCallback_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self);
            static /*0x1623600*/ void DrawWireOverlay_Impl_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, UnityEngine.Camera camera);
            static /*0x16234d0*/ void DrawUIOverlay_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, UnityEngine.Camera camera);
            static /*0x1621f30*/ void CreateRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.ShaderTagId tagName, bool isPassTagName, nint tagValues, nint stateBlocks, int stateCount, ref UnityEngine.Rendering.RendererList ret);
            static /*0x16223d0*/ void CreateSkyboxRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, UnityEngine.Camera camera, int mode, ref UnityEngine.Matrix4x4 proj, ref UnityEngine.Matrix4x4 view, ref UnityEngine.Matrix4x4 projR, ref UnityEngine.Matrix4x4 viewR, ref UnityEngine.Rendering.RendererList ret);
            static /*0x16241e0*/ void PrepareRendererListsAsync_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, object rendererLists);
            static /*0x1624310*/ UnityEngine.Rendering.RendererListStatus QueryRendererListStatus_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, ref UnityEngine.Rendering.RendererList handle);
            /*0x9e29e0*/ ScriptableRenderContext(nint ptr);
            /*0x1624850*/ void Submit_Internal();
            /*0x1624700*/ bool SubmitForRenderPassValidation_Internal();
            /*0x1623e20*/ void GetCameras_Internal(System.Type listType, object resultList);
            /*0x1622dc0*/ void DrawRenderers_Internal(nint cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, UnityEngine.Rendering.ShaderTagId tagName, bool isPassTagName, nint tagValues, nint stateBlocks, int stateCount);
            /*0x16233e0*/ void DrawShadows_Internal(nint shadowDrawingSettings);
            /*0x1623c30*/ void ExecuteCommandBuffer_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer);
            /*0x1623a30*/ void ExecuteCommandBufferAsync_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType);
            /*0x1624510*/ void SetupCameraProperties_Internal(UnityEngine.Camera camera, bool stereoSetup, int eye);
            /*0x16240d0*/ void InvokeOnRenderObjectCallback_Internal();
            /*0x1623650*/ void DrawWireOverlay_Impl(UnityEngine.Camera camera);
            /*0x1623520*/ void DrawUIOverlay_Internal(UnityEngine.Camera camera);
            /*0x1621fb0*/ UnityEngine.Rendering.RendererList CreateRendererList_Internal(nint cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, UnityEngine.Rendering.ShaderTagId tagName, bool isPassTagName, nint tagValues, nint stateBlocks, int stateCount);
            /*0x1622440*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList_Internal(UnityEngine.Camera camera, int mode, UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 projR, UnityEngine.Matrix4x4 viewR);
            /*0x1624230*/ void PrepareRendererListsAsync_Internal(object rendererLists);
            /*0x1624360*/ UnityEngine.Rendering.RendererListStatus QueryRendererListStatus_Internal(UnityEngine.Rendering.RendererList handle);
            /*0x1621bc0*/ void BeginRenderPass(int width, int height, int samples, Unity.Collections.NativeArray<UnityEngine.Rendering.AttachmentDescriptor> attachments, int depthAttachmentIndex);
            /*0x1621d40*/ void BeginSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthStencilReadOnly);
            /*0x1621e50*/ void BeginSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthStencilReadOnly);
            /*0x1623860*/ void EndSubPass();
            /*0x16237b0*/ void EndRenderPass();
            /*0x16248c0*/ void Submit();
            /*0x1624770*/ bool SubmitForRenderPassValidation();
            /*0x1623eb0*/ void GetCameras(System.Collections.Generic.List<UnityEngine.Camera> results);
            /*0x1622ea0*/ void DrawRenderers(UnityEngine.Rendering.CullingResults cullingResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings);
            /*0x1622f60*/ void DrawRenderers(UnityEngine.Rendering.CullingResults cullingResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock stateBlock);
            /*0x1623050*/ void DrawRenderers(UnityEngine.Rendering.CullingResults cullingResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, UnityEngine.Rendering.ShaderTagId tagName, bool isPassTagName, Unity.Collections.NativeArray<UnityEngine.Rendering.ShaderTagId> tagValues, Unity.Collections.NativeArray<UnityEngine.Rendering.RenderStateBlock> stateBlocks);
            /*0x1623460*/ void DrawShadows(ref UnityEngine.Rendering.ShadowDrawingSettings settings);
            /*0x1623cb0*/ void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer commandBuffer);
            /*0x1623ac0*/ void ExecuteCommandBufferAsync(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType);
            /*0x1624640*/ void SetupCameraProperties(UnityEngine.Camera camera, bool stereoSetup);
            /*0x16245b0*/ void SetupCameraProperties(UnityEngine.Camera camera, bool stereoSetup, int eye);
            /*0x1624140*/ void InvokeOnRenderObjectCallback();
            /*0x16236d0*/ void DrawWireOverlay(UnityEngine.Camera camera);
            /*0x16235a0*/ void DrawUIOverlay(UnityEngine.Camera camera);
            /*0x1622c50*/ UnityEngine.Rendering.CullingResults Cull(ref UnityEngine.Rendering.ScriptableCullingParameters parameters);
            /*0x1623970*/ bool Equals(UnityEngine.Rendering.ScriptableRenderContext other);
            /*0x16238d0*/ bool Equals(object obj);
            /*0x1612f80*/ int GetHashCode();
            /*0x16220a0*/ UnityEngine.Rendering.RendererList CreateRendererList(UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
            /*0x1622240*/ UnityEngine.Rendering.RendererList CreateRendererList(ref UnityEngine.Rendering.RendererListParams param);
            /*0x1622780*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrixL, UnityEngine.Matrix4x4 viewMatrixL, UnityEngine.Matrix4x4 projectionMatrixR, UnityEngine.Matrix4x4 viewMatrixR);
            /*0x1622510*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 viewMatrix);
            /*0x1622950*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Camera camera);
            /*0x16242b0*/ void PrepareRendererListsAsync(System.Collections.Generic.List<UnityEngine.Rendering.RendererList> rendererLists);
            /*0x16243e0*/ UnityEngine.Rendering.RendererListStatus QueryRendererListStatus(UnityEngine.Rendering.RendererList rendererList);
        }

        struct ShaderTagId : System.IEquatable<UnityEngine.Rendering.ShaderTagId>
        {
            static /*0x0*/ UnityEngine.Rendering.ShaderTagId none;
            /*0x10*/ int m_Id;

            static /*0x15e9700*/ bool op_Equality(UnityEngine.Rendering.ShaderTagId tag1, UnityEngine.Rendering.ShaderTagId tag2);
            static /*0x16251a0*/ bool op_Inequality(UnityEngine.Rendering.ShaderTagId tag1, UnityEngine.Rendering.ShaderTagId tag2);
            /*0x1625180*/ ShaderTagId(string name);
            /*0x15d3b80*/ int get_id();
            /*0x6bbd40*/ void set_id(int value);
            /*0x16250d0*/ bool Equals(object obj);
            /*0x15e9590*/ bool Equals(UnityEngine.Rendering.ShaderTagId other);
            /*0x1625160*/ int GetHashCode();
        }

        struct ShadowDrawingSettings : System.IEquatable<UnityEngine.Rendering.ShadowDrawingSettings>
        {
            /*0x10*/ UnityEngine.Rendering.CullingResults m_CullingResults;
            /*0x20*/ int m_LightIndex;
            /*0x24*/ int m_UseRenderingLayerMaskTest;
            /*0x28*/ UnityEngine.Rendering.ShadowSplitData m_SplitData;
            /*0x124*/ UnityEngine.ShadowObjectsFilter m_ObjectsFilter;
            /*0x128*/ UnityEngine.Rendering.BatchCullingProjectionType m_ProjectionType;

            /*0x16257a0*/ ShadowDrawingSettings(UnityEngine.Rendering.CullingResults cullingResults, int lightIndex, UnityEngine.Rendering.BatchCullingProjectionType projectionType);
            /*0x16258e0*/ void set_useRenderingLayerMaskTest(bool value);
            /*0x1625850*/ void set_splitData(UnityEngine.Rendering.ShadowSplitData value);
            /*0x16251b0*/ bool Equals(UnityEngine.Rendering.ShadowDrawingSettings other);
            /*0x16255f0*/ bool Equals(object obj);
            /*0x1625710*/ int GetHashCode();
        }

        struct ShadowSplitData : System.IEquatable<UnityEngine.Rendering.ShadowSplitData>
        {
            static int k_MaximumCullingPlaneCount = 10;
            static /*0x0*/ int maximumCullingPlaneCount;
            /*0x10*/ int m_CullingPlaneCount;
            /*0x14*/ UnityEngine.Rendering.ShadowSplitData.<m_CullingPlanes> m_CullingPlanes;
            /*0xb4*/ UnityEngine.Vector4 m_CullingSphere;
            /*0xc4*/ float m_ShadowCascadeBlendCullingFactor;
            /*0xc8*/ float m_CullingNearPlane;
            /*0xcc*/ UnityEngine.Matrix4x4 m_CullingMatrix;

            static /*0x1625f20*/ ShadowSplitData();
            /*0x15d3b80*/ int get_cullingPlaneCount();
            /*0x1625f60*/ UnityEngine.Vector4 get_cullingSphere();
            /*0x1625f70*/ void set_shadowCascadeBlendCullingFactor(float value);
            /*0x1625d20*/ UnityEngine.Plane GetCullingPlane(int index);
            /*0x1625a50*/ bool Equals(UnityEngine.Rendering.ShadowSplitData other);
            /*0x16258f0*/ bool Equals(object obj);
            /*0x1625e90*/ int GetHashCode();

            struct <m_CullingPlanes>e__FixedBuffer
            {
                /*0x10*/ byte FixedElementField;
            }
        }

        enum SortingCriteria
        {
            None = 0,
            SortingLayer = 1,
            RenderQueue = 2,
            BackToFront = 4,
            QuantizedFrontToBack = 8,
            OptimizeStateChanges = 16,
            CanvasOrder = 32,
            RendererPriority = 64,
            CommonOpaque = 59,
            CommonTransparent = 23,
        }

        struct SortingLayerRange : System.IEquatable<UnityEngine.Rendering.SortingLayerRange>
        {
            /*0x10*/ short m_LowerBound;
            /*0x12*/ short m_UpperBound;

            static /*0x16263d0*/ UnityEngine.Rendering.SortingLayerRange get_all();
            /*0xee74d0*/ SortingLayerRange(short lowerBound, short upperBound);
            /*0x16263e0*/ short get_lowerBound();
            /*0x16263f0*/ short get_upperBound();
            /*0x16262f0*/ bool Equals(UnityEngine.Rendering.SortingLayerRange other);
            /*0x1626310*/ bool Equals(object obj);
            /*0x16263c0*/ int GetHashCode();
        }

        enum DistanceMetric
        {
            Perspective = 0,
            Orthographic = 1,
            CustomAxis = 2,
        }

        struct SortingSettings : System.IEquatable<UnityEngine.Rendering.SortingSettings>
        {
            /*0x10*/ UnityEngine.Matrix4x4 m_WorldToCameraMatrix;
            /*0x50*/ UnityEngine.Vector3 m_CameraPosition;
            /*0x5c*/ UnityEngine.Vector3 m_CustomAxis;
            /*0x68*/ UnityEngine.Rendering.SortingCriteria m_Criteria;
            /*0x6c*/ UnityEngine.Rendering.DistanceMetric m_DistanceMetric;

            /*0x16266a0*/ SortingSettings(UnityEngine.Camera camera);
            /*0x1626730*/ void set_customAxis(UnityEngine.Vector3 value);
            /*0x1626720*/ UnityEngine.Rendering.SortingCriteria get_criteria();
            /*0x137d9e0*/ void set_criteria(UnityEngine.Rendering.SortingCriteria value);
            /*0x137dab0*/ void set_distanceMetric(UnityEngine.Rendering.DistanceMetric value);
            /*0x1626400*/ bool Equals(UnityEngine.Rendering.SortingSettings other);
            /*0x16264f0*/ bool Equals(object obj);
            /*0x16265d0*/ int GetHashCode();
        }

        struct StencilState : System.IEquatable<UnityEngine.Rendering.StencilState>
        {
            /*0x10*/ byte m_Enabled;
            /*0x11*/ byte m_ReadMask;
            /*0x12*/ byte m_WriteMask;
            /*0x13*/ byte m_Padding;
            /*0x14*/ byte m_CompareFunctionFront;
            /*0x15*/ byte m_PassOperationFront;
            /*0x16*/ byte m_FailOperationFront;
            /*0x17*/ byte m_ZFailOperationFront;
            /*0x18*/ byte m_CompareFunctionBack;
            /*0x19*/ byte m_PassOperationBack;
            /*0x1a*/ byte m_FailOperationBack;
            /*0x1b*/ byte m_ZFailOperationBack;

            static /*0x1626b90*/ UnityEngine.Rendering.StencilState get_defaultValue();
            /*0x1626b10*/ StencilState(bool enabled, byte readMask, byte writeMask, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.StencilOp passOperation, UnityEngine.Rendering.StencilOp failOperation, UnityEngine.Rendering.StencilOp zFailOperation);
            /*0x1626a40*/ StencilState(bool enabled, byte readMask, byte writeMask, UnityEngine.Rendering.CompareFunction compareFunctionFront, UnityEngine.Rendering.StencilOp passOperationFront, UnityEngine.Rendering.StencilOp failOperationFront, UnityEngine.Rendering.StencilOp zFailOperationFront, UnityEngine.Rendering.CompareFunction compareFunctionBack, UnityEngine.Rendering.StencilOp passOperationBack, UnityEngine.Rendering.StencilOp failOperationBack, UnityEngine.Rendering.StencilOp zFailOperationBack);
            /*0x1626c20*/ bool get_enabled();
            /*0x1626d00*/ void set_enabled(bool value);
            /*0x1626cb0*/ byte get_readMask();
            /*0x1626d80*/ void set_readMask(byte value);
            /*0x1626cc0*/ byte get_writeMask();
            /*0x1626d90*/ void set_writeMask(byte value);
            /*0x1626a00*/ void SetCompareFunction(UnityEngine.Rendering.CompareFunction value);
            /*0x1626a20*/ void SetPassOperation(UnityEngine.Rendering.StencilOp value);
            /*0x1626a10*/ void SetFailOperation(UnityEngine.Rendering.StencilOp value);
            /*0x1626a30*/ void SetZFailOperation(UnityEngine.Rendering.StencilOp value);
            /*0x1626b80*/ UnityEngine.Rendering.CompareFunction get_compareFunctionFront();
            /*0x1626cf0*/ void set_compareFunctionFront(UnityEngine.Rendering.CompareFunction value);
            /*0x1626ca0*/ UnityEngine.Rendering.StencilOp get_passOperationFront();
            /*0x1626d70*/ void set_passOperationFront(UnityEngine.Rendering.StencilOp value);
            /*0x1626c80*/ UnityEngine.Rendering.StencilOp get_failOperationFront();
            /*0x1626d60*/ void set_failOperationFront(UnityEngine.Rendering.StencilOp value);
            /*0x1626ce0*/ UnityEngine.Rendering.StencilOp get_zFailOperationFront();
            /*0x1626db0*/ void set_zFailOperationFront(UnityEngine.Rendering.StencilOp value);
            /*0x1626b70*/ UnityEngine.Rendering.CompareFunction get_compareFunctionBack();
            /*0x12e8d50*/ void set_compareFunctionBack(UnityEngine.Rendering.CompareFunction value);
            /*0x1626c90*/ UnityEngine.Rendering.StencilOp get_passOperationBack();
            /*0x12e8d70*/ void set_passOperationBack(UnityEngine.Rendering.StencilOp value);
            /*0x1626c70*/ UnityEngine.Rendering.StencilOp get_failOperationBack();
            /*0x12e8d60*/ void set_failOperationBack(UnityEngine.Rendering.StencilOp value);
            /*0x1626cd0*/ UnityEngine.Rendering.StencilOp get_zFailOperationBack();
            /*0x1626da0*/ void set_zFailOperationBack(UnityEngine.Rendering.StencilOp value);
            /*0x1626740*/ bool Equals(UnityEngine.Rendering.StencilState other);
            /*0x16267b0*/ bool Equals(object obj);
            /*0x1626900*/ int GetHashCode();
        }

        class SupportedRenderingFeatures
        {
            static /*0x0*/ UnityEngine.Rendering.SupportedRenderingFeatures s_Active;
            /*0x10*/ UnityEngine.Rendering.SupportedRenderingFeatures.ReflectionProbeModes <reflectionProbeModes>k__BackingField;
            /*0x14*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField;
            /*0x18*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes <mixedLightingModes>k__BackingField;
            /*0x1c*/ UnityEngine.LightmapBakeType <lightmapBakeTypes>k__BackingField;
            /*0x20*/ UnityEngine.LightmapsMode <lightmapsModes>k__BackingField;
            /*0x24*/ bool <enlightenLightmapper>k__BackingField;
            /*0x25*/ bool <enlighten>k__BackingField;
            /*0x26*/ bool <lightProbeProxyVolumes>k__BackingField;
            /*0x27*/ bool <motionVectors>k__BackingField;
            /*0x28*/ bool <receiveShadows>k__BackingField;
            /*0x29*/ bool <reflectionProbes>k__BackingField;
            /*0x2a*/ bool <reflectionProbesBlendDistance>k__BackingField;
            /*0x2b*/ bool <rendererPriority>k__BackingField;
            /*0x2c*/ bool <rendersUIOverlay>k__BackingField;
            /*0x2d*/ bool <overridesEnvironmentLighting>k__BackingField;
            /*0x2e*/ bool <overridesFog>k__BackingField;
            /*0x2f*/ bool <overridesRealtimeReflectionProbes>k__BackingField;
            /*0x30*/ bool <overridesOtherLightingSettings>k__BackingField;
            /*0x31*/ bool <editableMaterialRenderQueue>k__BackingField;
            /*0x32*/ bool <overridesLODBias>k__BackingField;
            /*0x33*/ bool <overridesMaximumLODLevel>k__BackingField;
            /*0x34*/ bool <overridesEnableLODCrossFade>k__BackingField;
            /*0x35*/ bool <rendererProbes>k__BackingField;
            /*0x36*/ bool <particleSystemInstancing>k__BackingField;
            /*0x37*/ bool <autoAmbientProbeBaking>k__BackingField;
            /*0x38*/ bool <autoDefaultReflectionProbeBaking>k__BackingField;
            /*0x39*/ bool <overridesShadowmask>k__BackingField;
            /*0x3a*/ bool <overridesLightProbeSystem>k__BackingField;
            /*0x3b*/ bool <supportsHDR>k__BackingField;
            /*0x40*/ string <overridesLightProbeSystemWarningMessage>k__BackingField;

            static /*0x16277f0*/ SupportedRenderingFeatures();
            static /*0x16278f0*/ UnityEngine.Rendering.SupportedRenderingFeatures get_active();
            static /*0x16279d0*/ void set_active(UnityEngine.Rendering.SupportedRenderingFeatures value);
            static /*0x1626de0*/ void FallbackMixedLightingModeByRef(nint fallbackModePtr);
            static /*0x16275c0*/ bool IsMixedLightingModeSupported(UnityEngine.MixedLightingMode mixedMode);
            static /*0x1627460*/ void IsMixedLightingModeSupportedByRef(UnityEngine.MixedLightingMode mixedMode, nint isSupportedPtr);
            static /*0x1627210*/ bool IsLightmapBakeTypeSupported(UnityEngine.LightmapBakeType bakeType);
            static /*0x1627110*/ void IsLightmapBakeTypeSupportedByRef(UnityEngine.LightmapBakeType bakeType, nint isSupportedPtr);
            static /*0x16273e0*/ void IsLightmapsModeSupportedByRef(UnityEngine.LightmapsMode mode, nint isSupportedPtr);
            static /*0x1627350*/ void IsLightmapperSupportedByRef(int lightmapper, nint isSupportedPtr);
            static /*0x1627710*/ void IsUIOverlayRenderedBySRP(nint isSupportedPtr);
            static /*0x1627030*/ void IsAutoAmbientProbeBakingSupported(nint isSupportedPtr);
            static /*0x16270a0*/ void IsAutoDefaultReflectionProbeBakingSupported(nint isSupportedPtr);
            static /*0x1627780*/ void OverridesLightProbeSystem(nint overridesPtr);
            static /*0x1626dc0*/ void FallbackLightmapperByRef(nint lightmapperPtr);
            /*0x1627860*/ SupportedRenderingFeatures();
            /*0x70a440*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_defaultMixedLightingModes();
            /*0x8a5c20*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_mixedLightingModes();
            /*0xc70b00*/ UnityEngine.LightmapBakeType get_lightmapBakeTypes();
            /*0x3e3af0*/ UnityEngine.LightmapsMode get_lightmapsModes();
            /*0xed9100*/ bool get_enlightenLightmapper();
            /*0x14efab0*/ bool get_enlighten();
            /*0x1569b40*/ void set_motionVectors(bool value);
            /*0x1569a90*/ bool get_rendersUIOverlay();
            /*0x1569af0*/ void set_rendersUIOverlay(bool value);
            /*0x1372a10*/ bool get_autoAmbientProbeBaking();
            /*0xd180c0*/ bool get_autoDefaultReflectionProbeBaking();
            /*0xe69700*/ bool get_overridesLightProbeSystem();
            /*0x1627a40*/ void set_supportsHDR(bool value);

            enum ReflectionProbeModes
            {
                None = 0,
                Rotation = 1,
            }

            enum LightmapMixedBakeModes
            {
                None = 0,
                IndirectOnly = 1,
                Subtractive = 2,
                Shadowmask = 4,
            }
        }

        struct VisibleLight : System.IEquatable<UnityEngine.Rendering.VisibleLight>
        {
            /*0x10*/ UnityEngine.LightType m_LightType;
            /*0x14*/ UnityEngine.Color m_FinalColor;
            /*0x24*/ UnityEngine.Rect m_ScreenRect;
            /*0x34*/ UnityEngine.Matrix4x4 m_LocalToWorldMatrix;
            /*0x74*/ float m_Range;
            /*0x78*/ float m_SpotAngle;
            /*0x7c*/ int m_InstanceId;
            /*0x80*/ UnityEngine.Rendering.VisibleLightFlags m_Flags;

            /*0x16284f0*/ UnityEngine.Light get_light();
            /*0x15d3b80*/ UnityEngine.LightType get_lightType();
            /*0x16284e0*/ UnityEngine.Color get_finalColor();
            /*0x1628570*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
            /*0x16285a0*/ float get_range();
            /*0x16285b0*/ float get_spotAngle();
            /*0x1628120*/ bool Equals(UnityEngine.Rendering.VisibleLight other);
            /*0x1628350*/ bool Equals(object obj);
            /*0x1628440*/ int GetHashCode();
        }

        enum VisibleLightFlags
        {
            IntersectsNearPlane = 1,
            IntersectsFarPlane = 2,
        }

        struct VisibleReflectionProbe : System.IEquatable<UnityEngine.Rendering.VisibleReflectionProbe>
        {
            /*0x10*/ UnityEngine.Bounds m_Bounds;
            /*0x28*/ UnityEngine.Matrix4x4 m_LocalToWorldMatrix;
            /*0x68*/ UnityEngine.Vector4 m_HdrData;
            /*0x78*/ UnityEngine.Vector3 m_Center;
            /*0x84*/ float m_BlendDistance;
            /*0x88*/ int m_Importance;
            /*0x8c*/ int m_BoxProjection;
            /*0x90*/ int m_InstanceId;
            /*0x94*/ int m_TextureId;

            /*0x1628c90*/ UnityEngine.Texture get_texture();
            /*0x1628c10*/ UnityEngine.ReflectionProbe get_reflectionProbe();
            /*0x1628b50*/ UnityEngine.Bounds get_bounds();
            /*0x1628be0*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
            /*0x1628b70*/ UnityEngine.Vector4 get_hdrData();
            /*0x1628b40*/ float get_blendDistance();
            /*0x1628b80*/ int get_importance();
            /*0x1628b90*/ bool get_isBoxProjection();
            /*0x16286d0*/ bool Equals(UnityEngine.Rendering.VisibleReflectionProbe other);
            /*0x16285c0*/ bool Equals(object obj);
            /*0x1628970*/ int GetHashCode();
        }

        struct LocalKeyword : System.IEquatable<UnityEngine.Rendering.LocalKeyword>
        {
            /*0x10*/ UnityEngine.Rendering.LocalKeywordSpace m_SpaceInfo;
            /*0x18*/ string m_Name;
            /*0x20*/ uint m_Index;

            static /*0x161ac50*/ uint GetShaderKeywordCount(UnityEngine.Shader shader);
            static /*0x161ac90*/ uint GetShaderKeywordIndex(UnityEngine.Shader shader, string keyword);
            /*0x161ace0*/ LocalKeyword(UnityEngine.Shader shader, string name);
            /*0xfbbe70*/ string ToString();
            /*0x161aaf0*/ bool Equals(object o);
            /*0x161aba0*/ bool Equals(UnityEngine.Rendering.LocalKeyword rhs);
            /*0x161ac10*/ int GetHashCode();
        }

        struct LocalKeywordSpace : System.IEquatable<UnityEngine.Rendering.LocalKeywordSpace>
        {
            /*0x10*/ nint m_KeywordSpace;

            static /*0x161aae0*/ bool op_Equality(UnityEngine.Rendering.LocalKeywordSpace lhs, UnityEngine.Rendering.LocalKeywordSpace rhs);
            /*0x161aa40*/ bool Equals(object o);
            /*0x161aad0*/ bool Equals(UnityEngine.Rendering.LocalKeywordSpace rhs);
            /*0x1612f80*/ int GetHashCode();
        }

        struct ShaderKeyword
        {
            /*0x10*/ string m_Name;
            /*0x18*/ uint m_Index;
            /*0x1c*/ bool m_IsLocal;
            /*0x1d*/ bool m_IsCompute;
            /*0x1e*/ bool m_IsValid;

            static /*0x1624f90*/ uint GetGlobalKeywordCount();
            static /*0x1624fc0*/ uint GetGlobalKeywordIndex(string keyword);
            static /*0x1624f50*/ void CreateGlobalKeyword(string keyword);
            /*0x1625000*/ ShaderKeyword(string keywordName);
            /*0x69af20*/ string get_name();
            /*0x69af20*/ string ToString();
        }

        struct ShaderKeywordSet
        {
            /*0x10*/ nint m_KeywordState;
            /*0x18*/ nint m_Shader;
            /*0x20*/ nint m_ComputeShader;
            /*0x28*/ ulong m_StateIndex;

            static /*0x1624f00*/ bool IsKeywordNameEnabled(UnityEngine.Rendering.ShaderKeywordSet state, string name);
            static /*0x1624eb0*/ bool IsKeywordNameEnabled_Injected(ref UnityEngine.Rendering.ShaderKeywordSet state, string name);
            /*0x1624d20*/ void CheckKeywordCompatible(UnityEngine.Rendering.ShaderKeyword keyword);
            /*0x1624dc0*/ bool IsEnabled(UnityEngine.Rendering.ShaderKeyword keyword);
        }

        enum ShaderPropertyFlags
        {
            None = 0,
            HideInInspector = 1,
            PerRendererData = 2,
            NoScaleOffset = 4,
            Normal = 8,
            HDR = 16,
            Gamma = 32,
            NonModifiableTextureData = 64,
            MainTexture = 128,
            MainColor = 256,
        }

        class SortingGroup : UnityEngine.Behaviour
        {
            static /*0x16260e0*/ int get_invalidSortingGroupID();
            static /*0x16260a0*/ UnityEngine.Rendering.SortingGroup GetSortingGroupByIndex(int index);
            /*0x15b84e0*/ SortingGroup();
            /*0x1626150*/ string get_sortingLayerName();
            /*0x1626260*/ void set_sortingLayerName(string value);
            /*0x1626110*/ int get_sortingLayerID();
            /*0x1626220*/ void set_sortingLayerID(int value);
            /*0x1626190*/ int get_sortingOrder();
            /*0x16262b0*/ void set_sortingOrder(int value);
            /*0x16261d0*/ void set_sortAtRoot(bool value);
        }

        namespace RendererUtils
        {
            struct RendererListDesc
            {
                static /*0x0*/ UnityEngine.Rendering.ShaderTagId s_EmptyName;
                /*0x10*/ UnityEngine.Rendering.SortingCriteria sortingCriteria;
                /*0x14*/ UnityEngine.Rendering.PerObjectData rendererConfiguration;
                /*0x18*/ UnityEngine.Rendering.RenderQueueRange renderQueueRange;
                /*0x20*/ System.Nullable<UnityEngine.Rendering.RenderStateBlock> stateBlock;
                /*0x90*/ UnityEngine.Shader overrideShader;
                /*0x98*/ UnityEngine.Material overrideMaterial;
                /*0xa0*/ bool excludeObjectMotionVectors;
                /*0xa4*/ int layerMask;
                /*0xa8*/ uint renderingLayerMask;
                /*0xac*/ int overrideMaterialPassIndex;
                /*0xb0*/ int overrideShaderPassIndex;
                /*0xb8*/ UnityEngine.Rendering.CullingResults <cullingResult>k__BackingField;
                /*0xc8*/ UnityEngine.Camera <camera>k__BackingField;
                /*0xd0*/ UnityEngine.Rendering.ShaderTagId <passName>k__BackingField;
                /*0xd8*/ UnityEngine.Rendering.ShaderTagId[] <passNames>k__BackingField;

                static /*0x161f850*/ RendererListDesc();
                static /*0x161ece0*/ UnityEngine.Rendering.RendererListParams ConvertToParameters(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                /*0x161f8a0*/ UnityEngine.Rendering.CullingResults get_cullingResult();
                /*0xb69980*/ UnityEngine.Camera get_camera();
                /*0xeeacb0*/ UnityEngine.Rendering.ShaderTagId get_passName();
                /*0x136fca0*/ UnityEngine.Rendering.ShaderTagId[] get_passNames();
                /*0x161f720*/ bool IsValid();
            }
        }
    }

    namespace Playables
    {
        struct FrameData
        {
            /*0x10*/ ulong m_FrameID;
            /*0x18*/ double m_DeltaTime;
            /*0x20*/ float m_Weight;
            /*0x24*/ float m_EffectiveWeight;
            /*0x28*/ double m_EffectiveParentDelay;
            /*0x30*/ float m_EffectiveParentSpeed;
            /*0x34*/ float m_EffectiveSpeed;
            /*0x38*/ UnityEngine.Playables.FrameData.Flags m_Flags;
            /*0x40*/ UnityEngine.Playables.PlayableOutput m_Output;

            enum Flags
            {
                Evaluate = 1,
                SeekOccured = 2,
                Loop = 4,
                Hold = 8,
                EffectivePlayStateDelayed = 16,
                EffectivePlayStatePlaying = 32,
            }
        }

        interface INotification
        {
        }

        interface INotificationReceiver
        {
            /*0x2a5510*/ void OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, object context);
        }

        interface IPlayableBehaviour
        {
            /*0x2a5510*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x2a5510*/ void OnGraphStop(UnityEngine.Playables.Playable playable);
            /*0x2a5510*/ void OnPlayableCreate(UnityEngine.Playables.Playable playable);
            /*0x2a5510*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x2a5510*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x2a5510*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x2a5510*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x2a5510*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
        }

        struct Playable : System.IEquatable<UnityEngine.Playables.Playable>
        {
            static /*0x0*/ UnityEngine.Playables.Playable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x161be10*/ Playable();
            static /*0x161beb0*/ UnityEngine.Playables.Playable get_Null();
            /*0xdb4640*/ Playable(UnityEngine.Playables.PlayableHandle handle);
            /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x161bd30*/ bool Equals(UnityEngine.Playables.Playable other);
        }

        class PlayableAsset : UnityEngine.ScriptableObject
        {
            static /*0x161b180*/ void Internal_CreatePlayable(UnityEngine.Playables.PlayableAsset asset, UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, nint ptr);
            static /*0x161b2b0*/ void Internal_GetPlayableAssetDuration(UnityEngine.Playables.PlayableAsset asset, nint ptrToDouble);
            /*0x533ec0*/ PlayableAsset();
            UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
            /*0x161b2f0*/ double get_duration();
            /*0x161b340*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
        }

        class PlayableBehaviour : UnityEngine.Playables.IPlayableBehaviour, System.ICloneable
        {
            /*0x32f970*/ PlayableBehaviour();
            /*0x32d010*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x32d010*/ void OnGraphStop(UnityEngine.Playables.Playable playable);
            /*0x32d010*/ void OnPlayableCreate(UnityEngine.Playables.Playable playable);
            /*0x32d010*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x32d010*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x32d010*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x32d010*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x32d010*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
            /*0x161b390*/ object Clone();
        }

        struct PlayableBinding
        {
            static /*0x0*/ UnityEngine.Playables.PlayableBinding[] None;
            static /*0x8*/ double DefaultDuration;
            /*0x10*/ string m_StreamName;
            /*0x18*/ UnityEngine.Object m_SourceObject;
            /*0x20*/ System.Type m_SourceBindingType;
            /*0x28*/ UnityEngine.Playables.PlayableBinding.CreateOutputMethod m_CreateOutputMethod;

            static /*0x161b3a0*/ PlayableBinding();

            class CreateOutputMethod : System.MulticastDelegate
            {
                /*0x1616190*/ CreateOutputMethod(object object, nint method);
                /*0x1616150*/ UnityEngine.Playables.PlayableOutput Invoke(UnityEngine.Playables.PlayableGraph graph, string name);
            }
        }

        struct PlayableGraph
        {
            /*0x10*/ nint m_Handle;
            /*0x18*/ uint m_Version;
        }

        struct PlayableHandle : System.IEquatable<UnityEngine.Playables.PlayableHandle>
        {
            static /*0x0*/ UnityEngine.Playables.PlayableHandle m_Null;
            /*0x10*/ nint m_Handle;
            /*0x18*/ uint m_Version;

            static /*0x161b7c0*/ PlayableHandle();
            static /*0x161b800*/ UnityEngine.Playables.PlayableHandle get_Null();
            static /*0x161b860*/ bool op_Equality(UnityEngine.Playables.PlayableHandle x, UnityEngine.Playables.PlayableHandle y);
            static /*0x161b430*/ bool CompareVersion(UnityEngine.Playables.PlayableHandle lhs, UnityEngine.Playables.PlayableHandle rhs);
            static /*0x161b710*/ bool IsValid_Injected(ref UnityEngine.Playables.PlayableHandle _unity_self);
            static /*0x161b660*/ System.Type GetPlayableType_Injected(ref UnityEngine.Playables.PlayableHandle _unity_self);
            /*0x17cb40*/ bool IsPlayableOfType<T>();
            /*0x161b480*/ bool Equals(object p);
            /*0x161b5a0*/ bool Equals(UnityEngine.Playables.PlayableHandle other);
            /*0x161b630*/ int GetHashCode();
            /*0x161b750*/ bool IsValid();
            /*0x161b6a0*/ System.Type GetPlayableType();
        }

        struct PlayableOutput : System.IEquatable<UnityEngine.Playables.PlayableOutput>
        {
            static /*0x0*/ UnityEngine.Playables.PlayableOutput m_NullPlayableOutput;
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x161bc90*/ PlayableOutput();
            /*0xdb4640*/ PlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x15b64a0*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            /*0x161bbb0*/ bool Equals(UnityEngine.Playables.PlayableOutput other);
        }

        struct PlayableOutputHandle : System.IEquatable<UnityEngine.Playables.PlayableOutputHandle>
        {
            static /*0x0*/ UnityEngine.Playables.PlayableOutputHandle m_Null;
            /*0x10*/ nint m_Handle;
            /*0x18*/ uint m_Version;

            static /*0x161ba90*/ PlayableOutputHandle();
            static /*0x161bad0*/ UnityEngine.Playables.PlayableOutputHandle get_Null();
            static /*0x161bb30*/ bool op_Equality(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs);
            static /*0x161b430*/ bool CompareVersion(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs);
            /*0x161b630*/ int GetHashCode();
            /*0x161b8e0*/ bool Equals(object p);
            /*0x161ba00*/ bool Equals(UnityEngine.Playables.PlayableOutputHandle other);
        }

        struct ScriptPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;
        }
    }

    namespace Experimental
    {
        namespace U2D
        {
            struct SpriteIntermediateRendererInfo
            {
                /*0x10*/ int SpriteID;
                /*0x14*/ int TextureID;
                /*0x18*/ int MaterialID;
                /*0x1c*/ UnityEngine.Color Color;
                /*0x2c*/ UnityEngine.Matrix4x4 Transform;
                /*0x6c*/ UnityEngine.Bounds Bounds;
                /*0x84*/ int Layer;
                /*0x88*/ int SortingLayer;
                /*0x8c*/ int SortingOrder;
                /*0x90*/ ulong SceneCullingMask;
                /*0x98*/ nint IndexData;
                /*0xa0*/ nint VertexData;
                /*0xa8*/ int IndexCount;
                /*0xac*/ int VertexCount;
                /*0xb0*/ int ShaderChannelMask;
            }

            class SpriteRendererGroup
            {
            }
        }

        namespace GlobalIllumination
        {
            enum LightType
            {
                Directional = 0,
                Point = 1,
                Spot = 2,
                Rectangle = 3,
                Disc = 4,
                SpotPyramidShape = 5,
                SpotBoxShape = 6,
            }

            enum LightMode
            {
                Realtime = 0,
                Mixed = 1,
                Baked = 2,
                Unknown = 3,
            }

            enum FalloffType
            {
                InverseSquared = 0,
                InverseSquaredNoRangeAttenuation = 1,
                Linear = 2,
                Legacy = 3,
                Undefined = 4,
            }

            enum AngularFalloffType
            {
                LUT = 0,
                AnalyticAndInnerAngle = 1,
            }

            struct LinearColor
            {
                /*0x10*/ float m_red;
                /*0x14*/ float m_green;
                /*0x18*/ float m_blue;
                /*0x1c*/ float m_intensity;

                static /*0x161a4f0*/ UnityEngine.Experimental.GlobalIllumination.LinearColor Convert(UnityEngine.Color color, float intensity);
                static /*0x161a4c0*/ UnityEngine.Experimental.GlobalIllumination.LinearColor Black();
                /*0x6ef1f0*/ float get_red();
                /*0x161a980*/ void set_red(float value);
                /*0x6ef200*/ float get_green();
                /*0x161a8c0*/ void set_green(float value);
                /*0x501230*/ float get_blue();
                /*0x161a800*/ void set_blue(float value);
            }

            struct DirectionalLight
            {
                /*0x10*/ int instanceID;
                /*0x14*/ bool shadow;
                /*0x15*/ UnityEngine.Experimental.GlobalIllumination.LightMode mode;
                /*0x18*/ UnityEngine.Vector3 position;
                /*0x24*/ UnityEngine.Quaternion orientation;
                /*0x34*/ UnityEngine.Experimental.GlobalIllumination.LinearColor color;
                /*0x44*/ UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor;
                /*0x54*/ float penumbraWidthRadian;
                /*0x58*/ UnityEngine.Vector3 direction;
            }

            struct PointLight
            {
                /*0x10*/ int instanceID;
                /*0x14*/ bool shadow;
                /*0x15*/ UnityEngine.Experimental.GlobalIllumination.LightMode mode;
                /*0x18*/ UnityEngine.Vector3 position;
                /*0x24*/ UnityEngine.Quaternion orientation;
                /*0x34*/ UnityEngine.Experimental.GlobalIllumination.LinearColor color;
                /*0x44*/ UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor;
                /*0x54*/ float range;
                /*0x58*/ float sphereRadius;
                /*0x5c*/ UnityEngine.Experimental.GlobalIllumination.FalloffType falloff;
            }

            struct SpotLight
            {
                /*0x10*/ int instanceID;
                /*0x14*/ bool shadow;
                /*0x15*/ UnityEngine.Experimental.GlobalIllumination.LightMode mode;
                /*0x18*/ UnityEngine.Vector3 position;
                /*0x24*/ UnityEngine.Quaternion orientation;
                /*0x34*/ UnityEngine.Experimental.GlobalIllumination.LinearColor color;
                /*0x44*/ UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor;
                /*0x54*/ float range;
                /*0x58*/ float sphereRadius;
                /*0x5c*/ float coneAngle;
                /*0x60*/ float innerConeAngle;
                /*0x64*/ UnityEngine.Experimental.GlobalIllumination.FalloffType falloff;
                /*0x65*/ UnityEngine.Experimental.GlobalIllumination.AngularFalloffType angularFalloff;
            }

            struct RectangleLight
            {
                /*0x10*/ int instanceID;
                /*0x14*/ bool shadow;
                /*0x15*/ UnityEngine.Experimental.GlobalIllumination.LightMode mode;
                /*0x18*/ UnityEngine.Vector3 position;
                /*0x24*/ UnityEngine.Quaternion orientation;
                /*0x34*/ UnityEngine.Experimental.GlobalIllumination.LinearColor color;
                /*0x44*/ UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor;
                /*0x54*/ float range;
                /*0x58*/ float width;
                /*0x5c*/ float height;
                /*0x60*/ UnityEngine.Experimental.GlobalIllumination.FalloffType falloff;
            }

            struct DiscLight
            {
                /*0x10*/ int instanceID;
                /*0x14*/ bool shadow;
                /*0x15*/ UnityEngine.Experimental.GlobalIllumination.LightMode mode;
                /*0x18*/ UnityEngine.Vector3 position;
                /*0x24*/ UnityEngine.Quaternion orientation;
                /*0x34*/ UnityEngine.Experimental.GlobalIllumination.LinearColor color;
                /*0x44*/ UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor;
                /*0x54*/ float range;
                /*0x58*/ float radius;
                /*0x5c*/ UnityEngine.Experimental.GlobalIllumination.FalloffType falloff;
            }

            struct Cookie
            {
                /*0x10*/ int instanceID;
                /*0x14*/ float scale;
                /*0x18*/ UnityEngine.Vector2 sizes;

                static /*0x1616000*/ UnityEngine.Experimental.GlobalIllumination.Cookie Defaults();
            }

            struct LightDataGI
            {
                /*0x10*/ int instanceID;
                /*0x14*/ int cookieID;
                /*0x18*/ float cookieScale;
                /*0x1c*/ UnityEngine.Experimental.GlobalIllumination.LinearColor color;
                /*0x2c*/ UnityEngine.Experimental.GlobalIllumination.LinearColor indirectColor;
                /*0x3c*/ UnityEngine.Quaternion orientation;
                /*0x4c*/ UnityEngine.Vector3 position;
                /*0x58*/ float range;
                /*0x5c*/ float coneAngle;
                /*0x60*/ float innerConeAngle;
                /*0x64*/ float shape0;
                /*0x68*/ float shape1;
                /*0x6c*/ UnityEngine.Experimental.GlobalIllumination.LightType type;
                /*0x6d*/ UnityEngine.Experimental.GlobalIllumination.LightMode mode;
                /*0x6e*/ byte shadow;
                /*0x6f*/ UnityEngine.Experimental.GlobalIllumination.FalloffType falloff;

                /*0x1618ed0*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x1618fe0*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.PointLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x1618e50*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.SpotLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x1619140*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.RectangleLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x1619050*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DiscLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x16190c0*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight light);
                /*0x16191b0*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.PointLight light);
                /*0x1618f50*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.SpotLight light);
                /*0x1618e40*/ void InitNoBake(int lightInstanceID);
            }

            class LightmapperUtils
            {
                static /*0x1619c70*/ UnityEngine.Experimental.GlobalIllumination.LightMode Extract(UnityEngine.LightmapBakeType baketype);
                static /*0x1619310*/ UnityEngine.Experimental.GlobalIllumination.LinearColor ExtractIndirect(UnityEngine.Light l);
                static /*0x16193a0*/ float ExtractInnerCone(UnityEngine.Light l);
                static /*0x1619290*/ UnityEngine.Color ExtractColorTemperature(UnityEngine.Light l);
                static /*0x1619230*/ void ApplyColorTemperature(UnityEngine.Color cct, ref UnityEngine.Experimental.GlobalIllumination.LinearColor lightColor);
                static /*0x16196d0*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight dir);
                static /*0x1619990*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.PointLight point);
                static /*0x1619c90*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.SpotLight spot);
                static /*0x16193f0*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.RectangleLight rect);
                static /*0x1619990*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.DiscLight disc);
                static /*0x1619fc0*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
            }

            class Lightmapping
            {
                static /*0x0*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate s_DefaultDelegate;
                static /*0x8*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate s_RequestLightsDelegate;

                static /*0x161a330*/ Lightmapping();
                static /*0x161a2a0*/ void SetDelegate(UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate del);
                static /*0x161a100*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate GetDelegate();
                static /*0x161a230*/ void ResetDelegate();
                static /*0x161a150*/ void RequestLights(UnityEngine.Light[] lights, nint outLightsPtr, int outLightsCount);

                class RequestLightsDelegate : System.MulticastDelegate
                {
                    /*0x1620ce0*/ RequestLightsDelegate(object object, nint method);
                    /*0x722210*/ void Invoke(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.<> <>9;

                    static /*0x16280b0*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x1627b10*/ void <.cctor>b__7_0(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }
            }
        }

        namespace Playables
        {
            struct CameraPlayable : System.IEquatable<UnityEngine.Experimental.Playables.CameraPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x1613ee0*/ bool Equals(UnityEngine.Experimental.Playables.CameraPlayable other);
            }

            struct MaterialEffectPlayable : System.IEquatable<UnityEngine.Experimental.Playables.MaterialEffectPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x161aeb0*/ bool Equals(UnityEngine.Experimental.Playables.MaterialEffectPlayable other);
            }

            struct TextureMixerPlayable : System.IEquatable<UnityEngine.Experimental.Playables.TextureMixerPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x15b64a0*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x1627a50*/ bool Equals(UnityEngine.Experimental.Playables.TextureMixerPlayable other);
            }

            struct TexturePlayableOutput
            {
                /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;
            }
        }

        namespace Rendering
        {
            class BuiltinRuntimeReflectionSystem : UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem, System.IDisposable
            {
                static /*0x1613e60*/ bool BuiltinUpdate();
                static /*0x1613e90*/ UnityEngine.Experimental.Rendering.BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New();
                /*0x32f970*/ BuiltinRuntimeReflectionSystem();
                /*0x1613e60*/ bool TickRealtimeProbes();
                /*0x32d010*/ void Dispose();
                /*0x32d010*/ void Dispose(bool disposing);
            }

            interface IScriptableRuntimeReflectionSystem : System.IDisposable
            {
                /*0x17cb40*/ bool TickRealtimeProbes();
            }

            class ScriptableRuntimeReflectionSystemSettings
            {
                static /*0x0*/ UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper s_Instance;

                static /*0x16249e0*/ ScriptableRuntimeReflectionSystemSettings();
                static /*0x1624ab0*/ void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value);
                static /*0x1624a60*/ UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance();
                static /*0x16249b0*/ void ScriptingDirtyReflectionSystemInstance();
            }

            class ScriptableRuntimeReflectionSystemWrapper
            {
                /*0x10*/ UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem <implementation>k__BackingField;

                /*0x32f970*/ ScriptableRuntimeReflectionSystemWrapper();
                /*0x73d3e0*/ UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem get_implementation();
                /*0x9f12f0*/ void set_implementation(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value);
                /*0x1624c50*/ void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(ref bool result);
            }

            enum TextureCreationFlags
            {
                None = 0,
                MipChain = 1,
                DontInitializePixels = 4,
                Crunch = 64,
                DontUploadUponCreate = 1024,
                IgnoreMipmapLimit = 2048,
            }

            enum FormatUsage
            {
                Sample = 0,
                Linear = 1,
                Sparse = 2,
                Render = 4,
                Blend = 5,
                GetPixels = 6,
                SetPixels = 7,
                SetPixels32 = 8,
                ReadPixels = 9,
                LoadStore = 10,
                MSAA2x = 11,
                MSAA4x = 12,
                MSAA8x = 13,
                StencilSampling = 16,
            }

            enum DefaultFormat
            {
                LDR = 0,
                HDR = 1,
                DepthStencil = 2,
                Shadow = 3,
                Video = 4,
            }

            enum GraphicsFormat
            {
                None = 0,
                R8_SRGB = 1,
                R8G8_SRGB = 2,
                R8G8B8_SRGB = 3,
                R8G8B8A8_SRGB = 4,
                R8_UNorm = 5,
                R8G8_UNorm = 6,
                R8G8B8_UNorm = 7,
                R8G8B8A8_UNorm = 8,
                R8_SNorm = 9,
                R8G8_SNorm = 10,
                R8G8B8_SNorm = 11,
                R8G8B8A8_SNorm = 12,
                R8_UInt = 13,
                R8G8_UInt = 14,
                R8G8B8_UInt = 15,
                R8G8B8A8_UInt = 16,
                R8_SInt = 17,
                R8G8_SInt = 18,
                R8G8B8_SInt = 19,
                R8G8B8A8_SInt = 20,
                R16_UNorm = 21,
                R16G16_UNorm = 22,
                R16G16B16_UNorm = 23,
                R16G16B16A16_UNorm = 24,
                R16_SNorm = 25,
                R16G16_SNorm = 26,
                R16G16B16_SNorm = 27,
                R16G16B16A16_SNorm = 28,
                R16_UInt = 29,
                R16G16_UInt = 30,
                R16G16B16_UInt = 31,
                R16G16B16A16_UInt = 32,
                R16_SInt = 33,
                R16G16_SInt = 34,
                R16G16B16_SInt = 35,
                R16G16B16A16_SInt = 36,
                R32_UInt = 37,
                R32G32_UInt = 38,
                R32G32B32_UInt = 39,
                R32G32B32A32_UInt = 40,
                R32_SInt = 41,
                R32G32_SInt = 42,
                R32G32B32_SInt = 43,
                R32G32B32A32_SInt = 44,
                R16_SFloat = 45,
                R16G16_SFloat = 46,
                R16G16B16_SFloat = 47,
                R16G16B16A16_SFloat = 48,
                R32_SFloat = 49,
                R32G32_SFloat = 50,
                R32G32B32_SFloat = 51,
                R32G32B32A32_SFloat = 52,
                B8G8R8_SRGB = 56,
                B8G8R8A8_SRGB = 57,
                B8G8R8_UNorm = 58,
                B8G8R8A8_UNorm = 59,
                B8G8R8_SNorm = 60,
                B8G8R8A8_SNorm = 61,
                B8G8R8_UInt = 62,
                B8G8R8A8_UInt = 63,
                B8G8R8_SInt = 64,
                B8G8R8A8_SInt = 65,
                R4G4B4A4_UNormPack16 = 66,
                B4G4R4A4_UNormPack16 = 67,
                R5G6B5_UNormPack16 = 68,
                B5G6R5_UNormPack16 = 69,
                R5G5B5A1_UNormPack16 = 70,
                B5G5R5A1_UNormPack16 = 71,
                A1R5G5B5_UNormPack16 = 72,
                E5B9G9R9_UFloatPack32 = 73,
                B10G11R11_UFloatPack32 = 74,
                A2B10G10R10_UNormPack32 = 75,
                A2B10G10R10_UIntPack32 = 76,
                A2B10G10R10_SIntPack32 = 77,
                A2R10G10B10_UNormPack32 = 78,
                A2R10G10B10_UIntPack32 = 79,
                A2R10G10B10_SIntPack32 = 80,
                A2R10G10B10_XRSRGBPack32 = 81,
                A2R10G10B10_XRUNormPack32 = 82,
                R10G10B10_XRSRGBPack32 = 83,
                R10G10B10_XRUNormPack32 = 84,
                A10R10G10B10_XRSRGBPack32 = 85,
                A10R10G10B10_XRUNormPack32 = 86,
                D16_UNorm = 90,
                D24_UNorm = 91,
                D24_UNorm_S8_UInt = 92,
                D32_SFloat = 93,
                D32_SFloat_S8_UInt = 94,
                S8_UInt = 95,
                RGB_DXT1_SRGB = 96,
                RGBA_DXT1_SRGB = 96,
                RGB_DXT1_UNorm = 97,
                RGBA_DXT1_UNorm = 97,
                RGBA_DXT3_SRGB = 98,
                RGBA_DXT3_UNorm = 99,
                RGBA_DXT5_SRGB = 100,
                RGBA_DXT5_UNorm = 101,
                R_BC4_UNorm = 102,
                R_BC4_SNorm = 103,
                RG_BC5_UNorm = 104,
                RG_BC5_SNorm = 105,
                RGB_BC6H_UFloat = 106,
                RGB_BC6H_SFloat = 107,
                RGBA_BC7_SRGB = 108,
                RGBA_BC7_UNorm = 109,
                RGB_PVRTC_2Bpp_SRGB = 110,
                RGB_PVRTC_2Bpp_UNorm = 111,
                RGB_PVRTC_4Bpp_SRGB = 112,
                RGB_PVRTC_4Bpp_UNorm = 113,
                RGBA_PVRTC_2Bpp_SRGB = 114,
                RGBA_PVRTC_2Bpp_UNorm = 115,
                RGBA_PVRTC_4Bpp_SRGB = 116,
                RGBA_PVRTC_4Bpp_UNorm = 117,
                RGB_ETC_UNorm = 118,
                RGB_ETC2_SRGB = 119,
                RGB_ETC2_UNorm = 120,
                RGB_A1_ETC2_SRGB = 121,
                RGB_A1_ETC2_UNorm = 122,
                RGBA_ETC2_SRGB = 123,
                RGBA_ETC2_UNorm = 124,
                R_EAC_UNorm = 125,
                R_EAC_SNorm = 126,
                RG_EAC_UNorm = 127,
                RG_EAC_SNorm = 128,
                RGBA_ASTC4X4_SRGB = 129,
                RGBA_ASTC4X4_UNorm = 130,
                RGBA_ASTC5X5_SRGB = 131,
                RGBA_ASTC5X5_UNorm = 132,
                RGBA_ASTC6X6_SRGB = 133,
                RGBA_ASTC6X6_UNorm = 134,
                RGBA_ASTC8X8_SRGB = 135,
                RGBA_ASTC8X8_UNorm = 136,
                RGBA_ASTC10X10_SRGB = 137,
                RGBA_ASTC10X10_UNorm = 138,
                RGBA_ASTC12X12_SRGB = 139,
                RGBA_ASTC12X12_UNorm = 140,
                YUV2 = 141,
                DepthAuto = 142,
                ShadowAuto = 143,
                VideoAuto = 144,
                RGBA_ASTC4X4_UFloat = 145,
                RGBA_ASTC5X5_UFloat = 146,
                RGBA_ASTC6X6_UFloat = 147,
                RGBA_ASTC8X8_UFloat = 148,
                RGBA_ASTC10X10_UFloat = 149,
                RGBA_ASTC12X12_UFloat = 150,
                D16_UNorm_S8_UInt = 151,
            }

            class GraphicsFormatUtility
            {
                static /*0x0*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] tableNoStencil;
                static /*0x8*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] tableStencil;

                static /*0x1618b50*/ GraphicsFormatUtility();
                static /*0x1618510*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Texture texture);
                static /*0x1618720*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.TextureFormat format, bool isSRGB);
                static /*0x1618590*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_TextureFormat(UnityEngine.TextureFormat format, bool isSRGB);
                static /*0x16186a0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, bool isSRGB);
                static /*0x1618550*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(UnityEngine.RenderTextureFormat format, bool isSRGB);
                static /*0x16185d0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
                static /*0x1618190*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits);
                static /*0x16181d0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormat(int minimumDepthBits);
                static /*0x1618150*/ int GetDepthBits(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1618240*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits);
                static /*0x1618b10*/ bool IsSRGBFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1618820*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetSRGBFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x16187a0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetLinearFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x16187e0*/ UnityEngine.RenderTextureFormat GetRenderTextureFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1618110*/ uint GetComponentCount(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x16184d0*/ string GetFormatString(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x16189a0*/ bool IsCompressedFormat_Native_TextureFormat(UnityEngine.TextureFormat format);
                static /*0x16189e0*/ bool IsCompressedFormat(UnityEngine.TextureFormat format);
                static /*0x1618090*/ bool CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, bool wholeImage);
                static /*0x1618020*/ bool CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1618960*/ bool IsAlphaOnlyFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1618a90*/ bool IsDepthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1618ad0*/ bool IsPVRTCFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1618a50*/ bool IsCrunchFormat(UnityEngine.TextureFormat format);
                static /*0x1618920*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleR(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x16188e0*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleG(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x16188a0*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleB(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1618860*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleA(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x16180d0*/ uint GetBlockSize(UnityEngine.Experimental.Rendering.GraphicsFormat format);
            }
        }
    }

    namespace Assertions
    {
        class Assert
        {
            static /*0x0*/ bool raiseExceptions;

            static /*0x1611ed0*/ Assert();
            static /*0x1611a30*/ void Fail(string message, string userMessage);
            static /*0x1611e70*/ void IsTrue(bool condition);
            static /*0x1611d80*/ void IsTrue(bool condition, string message);
            static /*0x1611b50*/ void IsFalse(bool condition, string message);
            static /*0x2a5510*/ void AreEqual<T>(T expected, T actual);
            static /*0x2a5510*/ void AreEqual<T>(T expected, T actual, string message);
            static /*0x2a5510*/ void AreEqual<T>(T expected, T actual, string message, System.Collections.Generic.IEqualityComparer<T> comparer);
            static /*0x1611980*/ void AreEqual(UnityEngine.Object expected, UnityEngine.Object actual, string message);
            static /*0x2a5510*/ void IsNull<T>(T value);
            static /*0x2a5510*/ void IsNull<T>(T value, string message);
            static /*0x1611ce0*/ void IsNull(UnityEngine.Object value, string message);
            static /*0x2a5510*/ void IsNotNull<T>(T value);
            static /*0x2a5510*/ void IsNotNull<T>(T value, string message);
            static /*0x1611c40*/ void IsNotNull(UnityEngine.Object value, string message);
            static /*0x1611910*/ void AreEqual(int expected, int actual);
        }

        class AssertionException : System.Exception
        {
            /*0x90*/ string m_UserMessage;

            /*0x1611f10*/ AssertionException(string message, string userMessage);
            /*0x1611f90*/ string get_Message();
        }

        class AssertionMessageUtil
        {
            static /*0x16125c0*/ string GetMessage(string failureMessage);
            static /*0x16122f0*/ string GetMessage(string failureMessage, string expected);
            static /*0x1612090*/ string GetEqualityMessage(object actual, object expected, bool expectEqual);
            static /*0x16126e0*/ string NullFailureMessage(object value, bool expectNull);
            static /*0x1611ff0*/ string BooleanFailureMessage(bool expected);
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 0EBBFED81071BF15F38AA1387D6D74E5788591B4AA6E85C7B739CF903789D438;
    static /*0x6*/ <PrivateImplementationDetails> 39D974909C7E64675317DD1A8583B8D8DE92E68B180532FADD22B482AD93DC83;
    static /*0x1a*/ <PrivateImplementationDetails> C77A066B9EC0272B121AD30CBAEDA4AD20F986D49CC6D0007EBF45888D8B09BF;

    struct __StaticArrayInitTypeSize=6
    {
    }

    struct __StaticArrayInitTypeSize=20
    {
    }
}
