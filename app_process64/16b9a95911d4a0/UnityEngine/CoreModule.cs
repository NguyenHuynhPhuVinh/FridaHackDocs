class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x3d64c40*/ EmbeddedAttribute();
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
                /*0x3d64c48*/ IsUnmanagedAttribute();
            }
        }
    }
}

namespace AOT
{
    class MonoPInvokeCallbackAttribute : System.Attribute
    {
        /*0x3d64c50*/ MonoPInvokeCallbackAttribute(System.Type type);
    }
}

namespace UnityEngineInternal
{
    struct MathfInternal
    {
        static /*0x0*/ float FloatMinNormal;
        static /*0x4*/ float FloatMinDenormal;
        static /*0x8*/ bool IsFlushToZeroEnabled;

        static /*0x3d64c58*/ MathfInternal();
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

        /*0x3d64cf0*/ TypeInferenceRuleAttribute(UnityEngineInternal.TypeInferenceRules rule);
        /*0x3d64d80*/ TypeInferenceRuleAttribute(string rule);
        /*0x3d64db0*/ string ToString();
    }

    class GenericStack : System.Collections.Stack
    {
        /*0x3d64db8*/ GenericStack();
    }
}

namespace Unity
{
    namespace Jobs
    {
        interface IJob
        {
            /*0x1f309e4*/ void Execute();
        }

        class IJobExtensions
        {
            static /*0x1f33998*/ void EarlyJobInit<T>();
            static nint GetReflectionData<T>();
            static /*0x1ffc854*/ Unity.Jobs.JobHandle Schedule<T>(T jobData, Unity.Jobs.JobHandle dependsOn);
            static /*0x1ffc854*/ void Run<T>(T jobData);

            struct JobStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x1f33998*/ JobStruct();
                static /*0x1f33998*/ void Initialize();
                static /*0x1f368ec*/ void Execute(ref T data, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

                class ExecuteJobFunction<T> : System.MulticastDelegate
                {
                    ExecuteJobFunction(object object, nint method);
                    void Invoke(ref T data, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);
                }
            }
        }

        interface IJobFor
        {
            /*0x1f30b78*/ void Execute(int index);
        }

        class IJobForExtensions
        {
            static /*0x1f33998*/ void EarlyJobInit<T>();
            static nint GetReflectionData<T>();
            static /*0x1ffc854*/ Unity.Jobs.JobHandle ScheduleParallel<T>(T jobData, int arrayLength, int innerloopBatchCount, Unity.Jobs.JobHandle dependency);

            struct ForJobStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x1f33998*/ ForJobStruct();
                static /*0x1f33998*/ void Initialize();
                static /*0x1f368ec*/ void Execute(ref T jobData, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

                class ExecuteJobFunction<T> : System.MulticastDelegate
                {
                    ExecuteJobFunction(object object, nint method);
                    void Invoke(ref T data, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);
                }
            }
        }

        interface IJobParallelFor
        {
            /*0x1f30b78*/ void Execute(int index);
        }

        class IJobParallelForExtensions
        {
            static /*0x1f33998*/ void EarlyJobInit<T>();
            static nint GetReflectionData<T>();
            static /*0x1ffc854*/ Unity.Jobs.JobHandle Schedule<T>(T jobData, int arrayLength, int innerloopBatchCount, Unity.Jobs.JobHandle dependsOn);
            static /*0x1ffc854*/ void Run<T>(T jobData, int arrayLength);

            struct ParallelForJobStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x1f33998*/ ParallelForJobStruct();
                static /*0x1f33998*/ void Initialize();
                static /*0x1f368ec*/ void Execute(ref T jobData, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

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

            static /*0x3d64ebc*/ void ScheduleBatchedJobs();
            static /*0x3d64e08*/ void ScheduleBatchedJobsAndComplete(ref Unity.Jobs.JobHandle job);
            static /*0x3d64e80*/ bool ScheduleBatchedJobsAndIsCompleted(ref Unity.Jobs.JobHandle job);
            static /*0x3d64ee4*/ Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle job0, Unity.Jobs.JobHandle job1);
            static /*0x3d64f68*/ Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle job0, Unity.Jobs.JobHandle job1, Unity.Jobs.JobHandle job2);
            static /*0x3d65004*/ Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeArray<Unity.Jobs.JobHandle> jobs);
            static /*0x3d650c0*/ Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeSlice<Unity.Jobs.JobHandle> jobs);
            static /*0x3d64f0c*/ Unity.Jobs.JobHandle CombineDependenciesInternal2(ref Unity.Jobs.JobHandle job0, ref Unity.Jobs.JobHandle job1);
            static /*0x3d64f98*/ Unity.Jobs.JobHandle CombineDependenciesInternal3(ref Unity.Jobs.JobHandle job0, ref Unity.Jobs.JobHandle job1, ref Unity.Jobs.JobHandle job2);
            static /*0x3d65064*/ Unity.Jobs.JobHandle CombineDependenciesInternalPtr(void* jobs, int count);
            static /*0x3d65158*/ void CombineDependenciesInternal2_Injected(ref Unity.Jobs.JobHandle job0, ref Unity.Jobs.JobHandle job1, ref Unity.Jobs.JobHandle ret);
            static /*0x3d651ac*/ void CombineDependenciesInternal3_Injected(ref Unity.Jobs.JobHandle job0, ref Unity.Jobs.JobHandle job1, ref Unity.Jobs.JobHandle job2, ref Unity.Jobs.JobHandle ret);
            static /*0x3d65208*/ void CombineDependenciesInternalPtr_Injected(void* jobs, int count, ref Unity.Jobs.JobHandle ret);
            /*0x3d64dc0*/ void Complete();
            /*0x3d64e44*/ bool get_IsCompleted();
            /*0x3d6525c*/ bool Equals(Unity.Jobs.JobHandle other);
        }

        namespace LowLevel
        {
            namespace Unsafe
            {
                class JobProducerTypeAttribute : System.Attribute
                {
                    /*0x10*/ System.Type <ProducerType>k__BackingField;

                    /*0x3d6526c*/ JobProducerTypeAttribute(System.Type producerType);
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

                    static /*0x3d6529c*/ void GetJobRange(ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex, ref int beginIndex, ref int endIndex);
                    static /*0x3d652e4*/ bool GetWorkStealingRange(ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex, ref int beginIndex, ref int endIndex);
                    static /*0x3d65340*/ Unity.Jobs.JobHandle Schedule(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters);
                    static /*0x3d653d8*/ Unity.Jobs.JobHandle ScheduleParallelFor(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount);
                    static /*0x3d654a0*/ Unity.Jobs.JobHandle ScheduleParallelForTransform(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, nint transfromAccesssArray);
                    static /*0x3d65550*/ nint CreateJobReflectionData(System.Type wrapperJobType, System.Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2);
                    static /*0x3d655bc*/ nint CreateJobReflectionData(System.Type type, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2);
                    static /*0x3d6561c*/ bool get_IsExecutingJob();
                    static /*0x3d65644*/ void set_JobCompilerEnabled(bool value);
                    static /*0x3d65680*/ int GetJobQueueWorkerThreadCount();
                    static /*0x3d656a8*/ int get_JobWorkerCount();
                    static /*0x3d656d0*/ int get_ThreadIndex();
                    static /*0x3d656f8*/ int get_ThreadIndexCount();
                    static /*0x3d65720*/ void InvokePanicFunction();
                    static /*0x3d65394*/ void Schedule_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, ref Unity.Jobs.JobHandle ret);
                    static /*0x3d65444*/ void ScheduleParallelFor_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, ref Unity.Jobs.JobHandle ret);
                    static /*0x3d654fc*/ void ScheduleParallelForTransform_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, nint transfromAccesssArray, ref Unity.Jobs.JobHandle ret);

                    struct JobScheduleParameters
                    {
                        /*0x10*/ Unity.Jobs.JobHandle Dependency;
                        /*0x20*/ int ScheduleMode;
                        /*0x28*/ nint ReflectionData;
                        /*0x30*/ nint JobDataPtr;

                        /*0x3d65784*/ JobScheduleParameters(void* i_jobData, nint i_reflectionData, Unity.Jobs.JobHandle i_dependency, Unity.Jobs.LowLevel.Unsafe.ScheduleMode i_scheduleMode);
                    }

                    class PanicFunction_ : System.MulticastDelegate
                    {
                        /*0x3d657bc*/ PanicFunction_(object object, nint method);
                        /*0x3d65858*/ void Invoke();
                    }
                }
            }
        }
    }

    namespace IntegerTime
    {
        struct DiscreteTime : System.IEquatable<Unity.IntegerTime.DiscreteTime>, System.IFormattable, System.IComparable<Unity.IntegerTime.DiscreteTime>
        {
            static /*0x0*/ Unity.IntegerTime.DiscreteTime Zero;
            static /*0x8*/ Unity.IntegerTime.DiscreteTime MinValue;
            static /*0x10*/ Unity.IntegerTime.DiscreteTime MaxValue;
            static /*0x18*/ int TicksPerSecondBits;
            static /*0x1c*/ int NonPow2TpsBits;
            /*0x10*/ long Value;

            static /*0x3d65d38*/ DiscreteTime();
            static /*0x3d65a50*/ Unity.IntegerTime.DiscreteTime FromTicks(long v);
            static /*0x3d65a54*/ float op_Explicit(Unity.IntegerTime.DiscreteTime d);
            static /*0x3d65a6c*/ double op_Explicit(Unity.IntegerTime.DiscreteTime d);
            static /*0x3d65a80*/ bool op_Inequality(Unity.IntegerTime.DiscreteTime lhs, Unity.IntegerTime.DiscreteTime rhs);
            static /*0x3d65a8c*/ bool op_GreaterThan(Unity.IntegerTime.DiscreteTime lhs, Unity.IntegerTime.DiscreteTime rhs);
            static /*0x3d65a98*/ bool op_GreaterThanOrEqual(Unity.IntegerTime.DiscreteTime lhs, Unity.IntegerTime.DiscreteTime rhs);
            static /*0x3d65aa4*/ Unity.IntegerTime.DiscreteTime op_Addition(Unity.IntegerTime.DiscreteTime lhs, Unity.IntegerTime.DiscreteTime rhs);
            static /*0x3d65b04*/ Unity.IntegerTime.DiscreteTime op_Subtraction(Unity.IntegerTime.DiscreteTime lhs, Unity.IntegerTime.DiscreteTime rhs);
            /*0x3d6586c*/ DiscreteTime(float v);
            /*0x3d6595c*/ DiscreteTime(double v);
            /*0x3d65a48*/ DiscreteTime(long v, int _);
            /*0x3d65b64*/ bool Equals(Unity.IntegerTime.DiscreteTime rhs);
            /*0x3d65b74*/ bool Equals(object o);
            /*0x3d65c10*/ int GetHashCode();
            /*0x3d65c18*/ string ToString();
            /*0x3d65c98*/ string ToString(string format, System.IFormatProvider formatProvider);
            /*0x3d65d30*/ int CompareTo(Unity.IntegerTime.DiscreteTime other);
        }

        struct RationalTime
        {
            /*0x10*/ long m_Count;
            /*0x18*/ Unity.IntegerTime.RationalTime.TicksPerSecond m_TicksPerSecond;

            static /*0x3d65e80*/ Unity.IntegerTime.DiscreteTime op_Explicit(Unity.IntegerTime.RationalTime t);
            /*0x3d65e78*/ long get_Count();

            struct TicksPerSecond : System.IEquatable<Unity.IntegerTime.RationalTime.TicksPerSecond>
            {
                static /*0x0*/ Unity.IntegerTime.RationalTime.TicksPerSecond DefaultTicksPerSecond;
                static /*0x8*/ Unity.IntegerTime.RationalTime.TicksPerSecond TicksPerSecond24;
                static /*0x10*/ Unity.IntegerTime.RationalTime.TicksPerSecond TicksPerSecond25;
                static /*0x18*/ Unity.IntegerTime.RationalTime.TicksPerSecond TicksPerSecond30;
                static /*0x20*/ Unity.IntegerTime.RationalTime.TicksPerSecond TicksPerSecond50;
                static /*0x28*/ Unity.IntegerTime.RationalTime.TicksPerSecond TicksPerSecond60;
                static /*0x30*/ Unity.IntegerTime.RationalTime.TicksPerSecond TicksPerSecond120;
                static /*0x38*/ Unity.IntegerTime.RationalTime.TicksPerSecond TicksPerSecond2397;
                static /*0x40*/ Unity.IntegerTime.RationalTime.TicksPerSecond TicksPerSecond2425;
                static /*0x48*/ Unity.IntegerTime.RationalTime.TicksPerSecond TicksPerSecond2997;
                static /*0x50*/ Unity.IntegerTime.RationalTime.TicksPerSecond TicksPerSecond5994;
                static /*0x58*/ Unity.IntegerTime.RationalTime.TicksPerSecond TicksPerSecond11988;
                static /*0x60*/ Unity.IntegerTime.RationalTime.TicksPerSecond DiscreteTimeRate;
                /*0x10*/ uint m_Numerator;
                /*0x14*/ uint m_Denominator;

                static /*0x3d6620c*/ TicksPerSecond();
                static /*0x3d65fec*/ void Simplify(ref uint num, ref uint den);
                static /*0x3d661dc*/ uint Gcd(uint a, uint b);
                /*0x3d65f78*/ TicksPerSecond(uint num, uint den);
                /*0x3d66094*/ bool Equals(Unity.IntegerTime.RationalTime.TicksPerSecond rhs);
                /*0x3d660bc*/ bool Equals(object rhs);
                /*0x3d66158*/ int GetHashCode();
            }
        }

        class RationalTimeExtensions
        {
            static /*0x3d65f24*/ Unity.IntegerTime.RationalTime Convert(Unity.IntegerTime.RationalTime time, Unity.IntegerTime.RationalTime.TicksPerSecond rate);
            static /*0x3d66430*/ void Convert_Injected(ref Unity.IntegerTime.RationalTime time, ref Unity.IntegerTime.RationalTime.TicksPerSecond rate, ref Unity.IntegerTime.RationalTime ret);
        }
    }

    namespace IL2CPP
    {
        namespace CompilerServices
        {
            class Il2CppEagerStaticClassConstructionAttribute : System.Attribute
            {
                /*0x3d66484*/ Il2CppEagerStaticClassConstructionAttribute();
            }
        }
    }

    namespace Profiling
    {
        class IgnoredByDeepProfilerAttribute : System.Attribute
        {
            /*0x3d6648c*/ IgnoredByDeepProfilerAttribute();
        }

        struct ProfilerCategory
        {
            /*0x10*/ ushort m_CategoryId;

            static /*0x3d66834*/ Unity.Profiling.ProfilerCategory get_Scripts();
            static /*0x3d6683c*/ ushort op_Implicit(Unity.Profiling.ProfilerCategory category);
            /*0x3d66494*/ ProfilerCategory(string categoryName, Unity.Profiling.ProfilerCategoryColor color);
            /*0x3d6662c*/ ProfilerCategory(ushort category);
            /*0x3d66634*/ string get_Name();
            /*0x3d66830*/ string ToString();
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

            /*0x3d66840*/ ProfilerMarker(string name);
            /*0x3d669f8*/ ProfilerMarker(Unity.Profiling.ProfilerCategory category, string name);
            /*0x3d66a1c*/ Unity.Profiling.ProfilerMarker.AutoScope Auto();

            struct AutoScope : System.IDisposable
            {
                /*0x10*/ nint m_Ptr;

                /*0x3d66a64*/ AutoScope(nint markerPtr);
                /*0x3d66ae8*/ void Dispose();
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

            /*0x3d66b70*/ long get_Count();
        }

        struct ProfilerRecorder : System.IDisposable
        {
            static Unity.Profiling.ProfilerRecorderOptions SharedRecorder = 128;
            /*0x10*/ ulong handle;

            static /*0x3d66b9c*/ Unity.Profiling.ProfilerRecorder Create(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int maxSampleCount, Unity.Profiling.ProfilerRecorderOptions options);
            static /*0x3d66d3c*/ void Control(Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.ControlOptions options);
            static /*0x3d66e20*/ long GetLastValue(Unity.Profiling.ProfilerRecorder handle);
            static /*0x3d66eb0*/ int GetCount(Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.CountOptions countOptions);
            static /*0x3d66c50*/ bool GetValid(Unity.Profiling.ProfilerRecorder handle);
            static /*0x3d66f48*/ bool GetRunning(Unity.Profiling.ProfilerRecorder handle);
            static /*0x3d66fd8*/ Unity.Profiling.ProfilerRecorderSample GetSampleInternal(Unity.Profiling.ProfilerRecorder handle, int index);
            static /*0x3d67044*/ void Create_Injected(ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int maxSampleCount, Unity.Profiling.ProfilerRecorderOptions options, ref Unity.Profiling.ProfilerRecorder ret);
            static /*0x3d670a0*/ void Control_Injected(ref Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.ControlOptions options);
            static /*0x3d670e4*/ long GetLastValue_Injected(ref Unity.Profiling.ProfilerRecorder handle);
            static /*0x3d67120*/ int GetCount_Injected(ref Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.CountOptions countOptions);
            static /*0x3d67164*/ bool GetValid_Injected(ref Unity.Profiling.ProfilerRecorder handle);
            static /*0x3d671a0*/ bool GetRunning_Injected(ref Unity.Profiling.ProfilerRecorder handle);
            static /*0x3d671dc*/ void GetSampleInternal_Injected(ref Unity.Profiling.ProfilerRecorder handle, int index, ref Unity.Profiling.ProfilerRecorderSample ret);
            /*0x3d66b78*/ ProfilerRecorder(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int capacity, Unity.Profiling.ProfilerRecorderOptions options);
            /*0x3d66bfc*/ bool get_Valid();
            /*0x3d66c94*/ void Start();
            /*0x3d66d84*/ void Stop();
            /*0x3d66dd4*/ long get_LastValue();
            /*0x3d66e60*/ int get_Count();
            /*0x3d66ef8*/ bool get_IsRunning();
            /*0x3d66f8c*/ Unity.Profiling.ProfilerRecorderSample GetSample(int index);
            /*0x3d67230*/ void Dispose();
            /*0x3d66ce4*/ void CheckInitializedAndThrow();

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

            /*0x3d67284*/ void set_RawImageDataReference(Unity.Collections.NativeArray<byte> value);
            /*0x3d6728c*/ void set_ImageFormat(UnityEngine.TextureFormat value);
            /*0x3d67294*/ void set_Width(int value);
            /*0x3d6729c*/ void set_Height(int value);
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

                    /*0x3d672a4*/ Unity.Profiling.LowLevel.MarkerFlags get_Flags();
                }

                struct ProfilerRecorderHandle
                {
                    /*0x10*/ ulong handle;

                    static /*0x3d672c8*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescription(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle);
                    static /*0x3d67428*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName__Unmanaged(Unity.Profiling.ProfilerCategory category, byte* name, int nameLen);
                    static /*0x3d673a4*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescriptionInternal(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle);
                    static /*0x3d6748c*/ void GetByName__Unmanaged_Injected(ref Unity.Profiling.ProfilerCategory category, byte* name, int nameLen, ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ret);
                    static /*0x3d674e8*/ void GetDescriptionInternal_Injected(ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle, ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription ret);
                    /*0x3d672ac*/ ProfilerRecorderHandle(ulong handle);
                    /*0x3d672b4*/ bool get_Valid();
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
                    static /*0x3d664b4*/ ushort CreateCategory(string name, Unity.Profiling.ProfilerCategoryColor colorIndex);
                    static /*0x3d67570*/ ushort CreateCategory__Unmanaged(byte* name, int nameLen, Unity.Profiling.ProfilerCategoryColor colorIndex);
                    static /*0x3d666b4*/ Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription GetCategoryDescription(ushort categoryId);
                    static /*0x3d66868*/ nint CreateMarker(string name, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, int metadataCount);
                    static /*0x3d67664*/ nint CreateMarker__Unmanaged(byte* name, int nameLen, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, int metadataCount);
                    static /*0x3d676d0*/ void SetMarkerMetadata__Unmanaged(nint markerPtr, int index, byte* name, int nameLen, byte type, byte unit);
                    static /*0x3d66aac*/ void BeginSample(nint markerPtr);
                    static /*0x3d66b34*/ void EndSample(nint markerPtr);
                    static /*0x3d67744*/ void* CreateCounterValue__Unmanaged(ref nint counterPtr, byte* name, int nameLen, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, Unity.Profiling.ProfilerCounterOptions counterOptions);
                    static /*0x3d66744*/ string Utf8ToString(byte* chars, int charsLen);
                    static /*0x3d6752c*/ ushort CreateCategory_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, Unity.Profiling.ProfilerCategoryColor colorIndex);
                    static /*0x3d675c4*/ void GetCategoryDescription_Injected(ushort categoryId, ref Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription ret);
                    static /*0x3d67608*/ nint CreateMarker_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, int metadataCount);
                }
            }
        }

        namespace Memory
        {
            class MemorySnapshotMetadata
            {
                /*0x10*/ string <Description>k__BackingField;
                /*0x18*/ byte[] <Data>k__BackingField;

                /*0x3d677f8*/ MemorySnapshotMetadata();
                /*0x3d677e0*/ string get_Description();
                /*0x3d677e8*/ void set_Description(string value);
                /*0x3d677f0*/ byte[] get_Data();
            }

            class MemoryProfiler
            {
                static /*0x0*/ System.Action<string, bool> m_SnapshotFinished;
                static /*0x8*/ System.Action<string, bool, Unity.Profiling.DebugScreenCapture> m_SaveScreenshotToDisk;
                static /*0x10*/ System.Action<Unity.Profiling.Memory.MemorySnapshotMetadata> CreatingMetadata;

                static /*0x3d67800*/ void add_CreatingMetadata(System.Action<Unity.Profiling.Memory.MemorySnapshotMetadata> value);
                static /*0x3d678d0*/ void remove_CreatingMetadata(System.Action<Unity.Profiling.Memory.MemorySnapshotMetadata> value);
                static /*0x3d679a0*/ byte[] PrepareMetadata();
                static /*0x3d67ba8*/ int WriteIntToByteArray(byte[] array, int offset, int value);
                static /*0x3d67c30*/ int WriteStringToByteArray(byte[] array, int offset, string value);
                static /*0x3d67d20*/ void FinalizeSnapshot(string path, bool result);
                static /*0x3d67db0*/ void SaveScreenshotToDisk(string path, bool result, nint pixelsPtr, int pixelsCount, UnityEngine.TextureFormat format, int width, int height);
            }
        }
    }

    namespace IO
    {
        namespace LowLevel
        {
            namespace Unsafe
            {
                struct ReadCommand
                {
                    /*0x10*/ void* Buffer;
                    /*0x18*/ long Offset;
                    /*0x20*/ long Size;
                }

                struct ReadCommandArray
                {
                    /*0x10*/ Unity.IO.LowLevel.Unsafe.ReadCommand* ReadCommands;
                    /*0x18*/ int CommandCount;
                }

                enum FileState
                {
                    Absent = 0,
                    Exists = 1,
                }

                struct FileInfoResult
                {
                    /*0x10*/ long FileSize;
                    /*0x18*/ Unity.IO.LowLevel.Unsafe.FileState FileState;
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

                enum ReadStatus
                {
                    Complete = 0,
                    InProgress = 1,
                    Failed = 2,
                    Truncated = 4,
                    Canceled = 5,
                }

                enum Priority
                {
                    PriorityLow = 0,
                    PriorityHigh = 1,
                }

                struct FileHandle
                {
                    /*0x10*/ nint fileCommandPtr;
                    /*0x18*/ int version;

                    static /*0x3d67f48*/ bool IsFileHandleValid(ref Unity.IO.LowLevel.Unsafe.FileHandle handle);
                    static /*0x3d67f84*/ Unity.Jobs.JobHandle GetJobHandle_Internal(ref Unity.IO.LowLevel.Unsafe.FileHandle handle);
                    static /*0x3d68118*/ void GetJobHandle_Internal_Injected(ref Unity.IO.LowLevel.Unsafe.FileHandle handle, ref Unity.Jobs.JobHandle ret);
                    /*0x3d67eb8*/ Unity.Jobs.JobHandle get_JobHandle();
                    /*0x3d67fd8*/ bool IsValid();
                    /*0x3d68014*/ Unity.Jobs.JobHandle Close(Unity.Jobs.JobHandle dependency);
                }

                struct ReadHandle : System.IDisposable
                {
                    /*0x10*/ nint ptr;
                    /*0x18*/ int version;

                    static /*0x3d684bc*/ void CancelInternal(Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x3d68628*/ Unity.IO.LowLevel.Unsafe.ReadStatus GetReadStatus(Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x3d683b0*/ void ReleaseReadHandle(Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x3d681a4*/ bool IsReadHandleValid(Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x3d685dc*/ Unity.Jobs.JobHandle GetJobHandle(Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x3d684fc*/ void CancelInternal_Injected(ref Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x3d68668*/ Unity.IO.LowLevel.Unsafe.ReadStatus GetReadStatus_Injected(ref Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x3d686a4*/ void ReleaseReadHandle_Injected(ref Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x3d686e0*/ bool IsReadHandleValid_Injected(ref Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x3d6871c*/ void GetJobHandle_Injected(ref Unity.IO.LowLevel.Unsafe.ReadHandle handle, ref Unity.Jobs.JobHandle ret);
                    /*0x3d6815c*/ bool IsValid();
                    /*0x3d681e8*/ void Dispose();
                    /*0x3d683f0*/ void Cancel();
                    /*0x3d68538*/ Unity.Jobs.JobHandle get_JobHandle();
                    /*0x3d682e4*/ Unity.IO.LowLevel.Unsafe.ReadStatus get_Status();
                }

                class AsyncReadManager
                {
                    static /*0x3d68760*/ Unity.IO.LowLevel.Unsafe.ReadHandle GetFileInfoInternal(string filename, void* cmd);
                    static /*0x3d68930*/ Unity.IO.LowLevel.Unsafe.ReadHandle GetFileInfo(string filename, Unity.IO.LowLevel.Unsafe.FileInfoResult* result);
                    static /*0x3d68984*/ Unity.IO.LowLevel.Unsafe.ReadHandle ReadWithHandlesInternal_NativeCopy(ref Unity.IO.LowLevel.Unsafe.FileHandle fileHandle, void* readCmdArray);
                    static /*0x3d68a34*/ Unity.IO.LowLevel.Unsafe.ReadHandle Read(ref Unity.IO.LowLevel.Unsafe.FileHandle fileHandle, Unity.IO.LowLevel.Unsafe.ReadCommandArray readCmdArray);
                    static /*0x3d68ad8*/ Unity.IO.LowLevel.Unsafe.FileHandle OpenFileAsync_Internal(string fileName);
                    static /*0x3d68c90*/ Unity.IO.LowLevel.Unsafe.FileHandle OpenFileAsync(string fileName);
                    static /*0x3d680bc*/ Unity.Jobs.JobHandle CloseFileAsync(ref Unity.IO.LowLevel.Unsafe.FileHandle fileHandle, Unity.Jobs.JobHandle dependency);
                    static /*0x3d688dc*/ void GetFileInfoInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper filename, void* cmd, ref Unity.IO.LowLevel.Unsafe.ReadHandle ret);
                    static /*0x3d689e0*/ void ReadWithHandlesInternal_NativeCopy_Injected(ref Unity.IO.LowLevel.Unsafe.FileHandle fileHandle, void* readCmdArray, ref Unity.IO.LowLevel.Unsafe.ReadHandle ret);
                    static /*0x3d68c4c*/ void OpenFileAsync_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper fileName, ref Unity.IO.LowLevel.Unsafe.FileHandle ret);
                    static /*0x3d68cf4*/ void CloseFileAsync_Injected(ref Unity.IO.LowLevel.Unsafe.FileHandle fileHandle, ref Unity.Jobs.JobHandle dependency, ref Unity.Jobs.JobHandle ret);
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
        class CollectionExtensions
        {
            static /*0x1f32888*/ string SerializedView<T>(System.Collections.Generic.IEnumerable<T> collection, System.Func<T, string> serializeElement);

            class <>c__DisplayClass3_0<T>
            {
                /*0x0*/ System.Func<T, string> serializeElement;

                /*0x1f309e4*/ <>c__DisplayClass3_0();
                /*0x1ffc854*/ string <SerializedView>b__0(T t);
            }
        }

        class ReadOnlyAttribute : System.Attribute
        {
            /*0x3d68d48*/ ReadOnlyAttribute();
        }

        class WriteOnlyAttribute : System.Attribute
        {
            /*0x3d68d50*/ WriteOnlyAttribute();
        }

        class DeallocateOnJobCompletionAttribute : System.Attribute
        {
            /*0x3d68d58*/ DeallocateOnJobCompletionAttribute();
        }

        class NativeFixedLengthAttribute : System.Attribute
        {
        }

        class NativeMatchesParallelForLengthAttribute : System.Attribute
        {
        }

        class NativeDisableParallelForRestrictionAttribute : System.Attribute
        {
            /*0x3d68d60*/ NativeDisableParallelForRestrictionAttribute();
        }

        enum Allocator
        {
            Invalid = 0,
            None = 1,
            Temp = 2,
            TempJob = 3,
            Persistent = 4,
            AudioKernel = 5,
            Domain = 6,
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
            static /*0x1ffc854*/ bool op_Equality(Unity.Collections.NativeArray<T> left, Unity.Collections.NativeArray<T> right);
            static /*0x1ffc854*/ bool op_Inequality(Unity.Collections.NativeArray<T> left, Unity.Collections.NativeArray<T> right);
            static /*0x1ffc854*/ void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst);
            static /*0x1ffc854*/ void Copy(T[] src, Unity.Collections.NativeArray<T> dst);
            static /*0x1ffc854*/ void Copy(Unity.Collections.NativeArray<T> src, T[] dst);
            static /*0x1ffc854*/ void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst, int length);
            static /*0x1ffc854*/ void Copy(Unity.Collections.NativeArray<T> src, T[] dst, int length);
            static /*0x1ffc854*/ void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
            static /*0x1ffc854*/ void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length);
            static /*0x1ffc854*/ void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
            static /*0x1ffc854*/ void CopySafe(T[] src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
            static /*0x1ffc854*/ void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length);
            static /*0x1ffc854*/ System.Span<T> op_Implicit(ref Unity.Collections.NativeArray<T> source);
            static /*0x1ffc854*/ System.ReadOnlySpan<T> op_Implicit(ref Unity.Collections.NativeArray<T> source);
            NativeArray(int length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options);
            /*0x1f30ee8*/ NativeArray(T[] array, Unity.Collections.Allocator allocator);
            /*0x1ffc854*/ NativeArray(Unity.Collections.NativeArray<T> array, Unity.Collections.Allocator allocator);
            /*0x1f2ffc8*/ int get_Length();
            /*0x1ffc854*/ T get_Item(int index);
            /*0x1ffc854*/ void set_Item(int index, T value);
            /*0x1f2fe14*/ bool get_IsCreated();
            /*0x1f309e4*/ void Dispose();
            /*0x1ffc854*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
            /*0x1f30ebc*/ void CopyFrom(T[] array);
            /*0x1ffc854*/ void CopyFrom(Unity.Collections.NativeArray<T> array);
            /*0x1f30ebc*/ void CopyTo(T[] array);
            /*0x1f30214*/ T[] ToArray();
            /*0x1ffc854*/ Unity.Collections.NativeArray.Enumerator<T> GetEnumerator();
            /*0x1f30214*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1ffc854*/ bool Equals(Unity.Collections.NativeArray<T> other);
            /*0x1f2fec8*/ bool Equals(object obj);
            /*0x1f2ffc8*/ int GetHashCode();
            /*0x1ffc854*/ Unity.Collections.NativeArray<U> InternalReinterpret<U>(int length);
            /*0x1ffc854*/ Unity.Collections.NativeArray<U> Reinterpret<U>();
            /*0x1ffc854*/ Unity.Collections.NativeArray<U> Reinterpret<U>(int expectedTypeSize);
            /*0x1ffc854*/ Unity.Collections.NativeArray<T> GetSubArray(int start, int length);
            /*0x1ffc854*/ Unity.Collections.NativeArray.ReadOnly<T> AsReadOnly();
            /*0x1ffc854*/ System.Span<T> AsSpan();
            /*0x1ffc854*/ System.ReadOnlySpan<T> AsReadOnlySpan();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.NativeArray<T> m_Array;
                /*0x0*/ int m_Index;
                /*0x0*/ T value;

                /*0x1f30ebc*/ Enumerator(ref Unity.Collections.NativeArray<T> array);
                /*0x1f309e4*/ void Dispose();
                /*0x1f2fe14*/ bool MoveNext();
                /*0x1f309e4*/ void Reset();
                /*0x1ffc854*/ T get_Current();
                /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
            }

            struct ReadOnly<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                /*0x0*/ void* m_Buffer;
                /*0x0*/ int m_Length;

                static /*0x1ffc854*/ System.ReadOnlySpan<T> op_Implicit(ref Unity.Collections.NativeArray.ReadOnly<T> source);
                /*0x1ffc854*/ ReadOnly(void* buffer, int length);
                /*0x1f2ffc8*/ int get_Length();
                /*0x1ffc854*/ T get_Item(int index);
                /*0x1f30240*/ ref T UnsafeElementAt(int index);
                /*0x1ffc854*/ Unity.Collections.NativeArray.ReadOnly.Enumerator<T> GetEnumerator();
                /*0x1f30214*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x1ffc854*/ System.ReadOnlySpan<T> AsReadOnlySpan();

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ Unity.Collections.NativeArray.ReadOnly<T> m_Array;
                    /*0x0*/ int m_Index;
                    /*0x0*/ T value;

                    /*0x1f30ebc*/ Enumerator(ref Unity.Collections.NativeArray.ReadOnly<T> array);
                    /*0x1f309e4*/ void Dispose();
                    /*0x1f2fe14*/ bool MoveNext();
                    /*0x1f309e4*/ void Reset();
                    /*0x1ffc854*/ T get_Current();
                    /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
                }
            }
        }

        struct NativeArrayDispose
        {
            /*0x10*/ void* m_Buffer;
            /*0x18*/ Unity.Collections.Allocator m_AllocatorLabel;

            /*0x3d68d68*/ void Dispose();
        }

        struct NativeArrayDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeArrayDispose Data;

            static /*0x3d68e34*/ void RegisterNativeArrayDisposeJobReflectionData();
            /*0x3d68df0*/ void Execute();
        }

        class NativeArrayDebugView<T>
        {
        }

        class NativeArrayReadOnlyDebugView<T>
        {
        }

        class NativeSliceExtensions
        {
            static /*0x1ffc854*/ Unity.Collections.NativeSlice<T> Slice<T>(Unity.Collections.NativeArray<T> thisArray);
            static /*0x1ffc854*/ Unity.Collections.NativeSlice<T> Slice<T>(Unity.Collections.NativeArray<T> thisArray, int start);
            static /*0x1ffc854*/ Unity.Collections.NativeSlice<T> Slice<T>(Unity.Collections.NativeArray<T> thisArray, int start, int length);
            static /*0x1ffc854*/ Unity.Collections.NativeSlice<T> Slice<T>(Unity.Collections.NativeSlice<T> thisSlice, int start, int length);
        }

        struct NativeSlice<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.NativeSlice<T>>
        {
            /*0x0*/ byte* m_Buffer;
            /*0x0*/ int m_Stride;
            /*0x0*/ int m_Length;

            static /*0x1ffc854*/ Unity.Collections.NativeSlice<T> op_Implicit(Unity.Collections.NativeArray<T> array);
            /*0x1ffc854*/ NativeSlice(Unity.Collections.NativeSlice<T> slice, int start, int length);
            /*0x1ffc854*/ NativeSlice(Unity.Collections.NativeArray<T> array);
            /*0x1ffc854*/ NativeSlice(Unity.Collections.NativeArray<T> array, int start);
            /*0x1ffc854*/ NativeSlice(Unity.Collections.NativeArray<T> array, int start, int length);
            /*0x1ffc854*/ Unity.Collections.NativeSlice<U> SliceConvert<U>();
            /*0x1ffc854*/ Unity.Collections.NativeSlice<U> SliceWithStride<U>(int offset);
            /*0x1ffc854*/ Unity.Collections.NativeSlice<U> SliceWithStride<U>();
            /*0x1ffc854*/ T get_Item(int index);
            /*0x1ffc854*/ void set_Item(int index, T value);
            /*0x1ffc854*/ void CopyFrom(Unity.Collections.NativeSlice<T> slice);
            /*0x1f2ffc8*/ int get_Stride();
            /*0x1f2ffc8*/ int get_Length();
            /*0x1ffc854*/ Unity.Collections.NativeSlice.Enumerator<T> GetEnumerator();
            /*0x1f30214*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            /*0x1f30214*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1ffc854*/ bool Equals(Unity.Collections.NativeSlice<T> other);
            /*0x1f2fec8*/ bool Equals(object obj);
            /*0x1f2ffc8*/ int GetHashCode();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.NativeSlice<T> m_Array;
                /*0x0*/ int m_Index;

                /*0x1f30ebc*/ Enumerator(ref Unity.Collections.NativeSlice<T> array);
                /*0x1f309e4*/ void Dispose();
                /*0x1f2fe14*/ bool MoveNext();
                /*0x1f309e4*/ void Reset();
                /*0x1ffc854*/ T get_Current();
                /*0x1f30214*/ object System.Collections.IEnumerator.get_Current();
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

                        static /*0x1ffc854*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<T> GetOrCreate<TContext>(uint alignment);
                        /*0x1ffc854*/ SharedStatic(void* buffer);
                        /*0x1f30214*/ ref T get_Data();
                    }

                    class SharedStatic
                    {
                        static /*0x3d68e74*/ void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment);
                    }
                }

                class BurstRuntime
                {
                    static /*0x1f32524*/ long GetHashCode64<T>();
                    static /*0x3d68f3c*/ long HashStringWithFNV1A64(string text);

                    struct HashCode64<T>
                    {
                        static /*0x0*/ long Value;

                        static /*0x1f33998*/ HashCode64();
                    }
                }

                class NativeContainerAttribute : System.Attribute
                {
                    /*0x3d68fc8*/ NativeContainerAttribute();
                }

                class NativeContainerIsReadOnlyAttribute : System.Attribute
                {
                    /*0x3d68fd0*/ NativeContainerIsReadOnlyAttribute();
                }

                class NativeContainerIsAtomicWriteOnlyAttribute : System.Attribute
                {
                    /*0x3d68fd8*/ NativeContainerIsAtomicWriteOnlyAttribute();
                }

                class NativeContainerSupportsMinMaxWriteRestrictionAttribute : System.Attribute
                {
                    /*0x3d68fe0*/ NativeContainerSupportsMinMaxWriteRestrictionAttribute();
                }

                class NativeContainerSupportsDeallocateOnJobCompletionAttribute : System.Attribute
                {
                    /*0x3d68fe8*/ NativeContainerSupportsDeallocateOnJobCompletionAttribute();
                }

                class NativeContainerSupportsDeferredConvertListToArray : System.Attribute
                {
                    /*0x3d68ff0*/ NativeContainerSupportsDeferredConvertListToArray();
                }

                class NativeSetThreadIndexAttribute : System.Attribute
                {
                    /*0x3d68ff8*/ NativeSetThreadIndexAttribute();
                }

                class NativeContainerNeedsThreadIndexAttribute : System.Attribute
                {
                }

                class WriteAccessRequiredAttribute : System.Attribute
                {
                    /*0x3d69000*/ WriteAccessRequiredAttribute();
                }

                class NativeDisableUnsafePtrRestrictionAttribute : System.Attribute
                {
                    /*0x3d69008*/ NativeDisableUnsafePtrRestrictionAttribute();
                }

                class NativeDisableContainerSafetyRestrictionAttribute : System.Attribute
                {
                    /*0x3d69010*/ NativeDisableContainerSafetyRestrictionAttribute();
                }

                class NativeSetClassTypeToNullOnScheduleAttribute : System.Attribute
                {
                }

                class NativeArrayUnsafeUtility
                {
                    static /*0x1ffc854*/ Unity.Collections.NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Unity.Collections.Allocator allocator);
                    static /*0x1ffc854*/ void* GetUnsafePtr<T>(Unity.Collections.NativeArray<T> nativeArray);
                    static /*0x1ffc854*/ void* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeArray<T> nativeArray);
                    static /*0x1ffc854*/ void* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeArray.ReadOnly<T> nativeArray);
                    static /*0x1ffc854*/ void* GetUnsafeBufferPointerWithoutChecks<T>(Unity.Collections.NativeArray<T> nativeArray);
                }

                class NativeSliceUnsafeUtility
                {
                    static /*0x1ffc854*/ Unity.Collections.NativeSlice<T> ConvertExistingDataToNativeSlice<T>(void* dataPointer, int stride, int length);
                    static /*0x1ffc854*/ void* GetUnsafePtr<T>(Unity.Collections.NativeSlice<T> nativeSlice);
                    static /*0x1ffc854*/ void* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeSlice<T> nativeSlice);
                }

                class UnsafeUtility
                {
                    static /*0x1f317dc*/ bool IsBlittable<T>();
                    static /*0x3d69018*/ int LeakRecord(nint handle, Unity.Collections.LeakCategory category, int callstacksToSkip);
                    static /*0x3d6906c*/ int LeakErase(nint handle, Unity.Collections.LeakCategory category);
                    static /*0x3d690b0*/ void* MallocTracked(long size, int alignment, Unity.Collections.Allocator allocator, int callstacksToSkip);
                    static /*0x3d68dac*/ void FreeTracked(void* memory, Unity.Collections.Allocator allocator);
                    static /*0x3d6910c*/ void* Malloc(long size, int alignment, Unity.Collections.Allocator allocator);
                    static /*0x3d69160*/ void Free(void* memory, Unity.Collections.Allocator allocator);
                    static /*0x3d67ccc*/ void MemCpy(void* destination, void* source, long size);
                    static /*0x3d691a4*/ void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count);
                    static /*0x3d69218*/ void MemMove(void* destination, void* source, long size);
                    static /*0x3d6926c*/ void MemSet(void* destination, byte value, long size);
                    static /*0x3d692c0*/ void MemClear(void* destination, long size);
                    static /*0x3d69308*/ int MemCmp(void* ptr1, void* ptr2, long size);
                    static /*0x3d6935c*/ int SizeOf(System.Type type);
                    static /*0x3d69398*/ bool IsBlittable(System.Type type);
                    static /*0x3d693d4*/ bool IsBlittableValueType(System.Type t);
                    static /*0x3d69434*/ string GetReasonForTypeNonBlittableImpl(System.Type t, string name);
                    static /*0x3d695f0*/ bool IsArrayBlittable(System.Array arr);
                    static /*0x1f317dc*/ bool IsGenericListBlittable<T>();
                    static /*0x3d69620*/ string GetReasonForArrayNonBlittable(System.Array arr);
                    static /*0x1f327a0*/ string GetReasonForGenericListNonBlittable<T>();
                    static /*0x1f31da0*/ int AlignOf<T>();
                    static /*0x1ffc854*/ void CopyPtrToStructure<T>(void* ptr, ref T output);
                    static /*0x1ffc854*/ void InternalCopyPtrToStructure<T>(void* ptr, ref T output);
                    static /*0x1ffc854*/ T ReadArrayElement<T>(void* source, int index);
                    static /*0x1ffc854*/ T ReadArrayElementWithStride<T>(void* source, int index, int stride);
                    static /*0x1ffc854*/ void WriteArrayElement<T>(void* destination, int index, T value);
                    static /*0x1ffc854*/ void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value);
                    static /*0x1ffc854*/ void* AddressOf<T>(ref T output);
                    static /*0x1f31da0*/ int SizeOf<T>();
                    static /*0x1f327cc*/ ref T As<U, T>(ref U from);
                    static /*0x1ffc854*/ T As<T>(object from);
                    static /*0x1ffc854*/ ref T AsRef<T>(void* ptr);
                    static /*0x1ffc854*/ ref T ArrayElementAsRef<T>(void* ptr, int index);
                    static /*0x1ffc854*/ int EnumToInt<T>(T enumValue);
                    static /*0x1f36f18*/ void InternalEnumToInt<T>(ref T enumValue, ref int intValue);
                    static /*0x1ffc854*/ bool EnumEquals<T>(T lhs, T rhs);

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
            /*0x3d6966c*/ BurstAuthorizedExternalMethodAttribute();
        }

        class BurstDiscardAttribute : System.Attribute
        {
            /*0x3d69674*/ BurstDiscardAttribute();
        }

        namespace LowLevel
        {
            class BurstCompilerService
            {
                static /*0x3d6967c*/ int CompileAsyncDelegateMethod(object delegateMethod, string compilerOptions);
                static /*0x3d69838*/ void* GetAsyncCompiledAsyncDelegateMethod(int userID);
                static /*0x3d68ee8*/ void* GetOrCreateSharedMemory(ref UnityEngine.Hash128 key, uint size_of, uint alignment);
                static /*0x3d69874*/ void Log(void* userData, Unity.Burst.LowLevel.BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber);
                static /*0x3d698e0*/ void RuntimeLog(void* userData, Unity.Burst.LowLevel.BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber);
                static /*0x3d697f4*/ int CompileAsyncDelegateMethod_Injected(object delegateMethod, ref UnityEngine.Bindings.ManagedSpanWrapper compilerOptions);

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
            /*0x3d6994c*/ CanBeNullAttribute();
        }

        class NotNullAttribute : System.Attribute
        {
            /*0x3d69954*/ NotNullAttribute();
        }

        class ItemCanBeNullAttribute : System.Attribute
        {
            /*0x3d6995c*/ ItemCanBeNullAttribute();
        }

        class ContractAnnotationAttribute : System.Attribute
        {
            /*0x10*/ string <Contract>k__BackingField;
            /*0x18*/ bool <ForceFullStates>k__BackingField;

            /*0x3d69964*/ ContractAnnotationAttribute(string contract);
            /*0x3d6999c*/ ContractAnnotationAttribute(string contract, bool forceFullStates);
        }

        class UsedImplicitlyAttribute : System.Attribute
        {
            /*0x10*/ JetBrains.Annotations.ImplicitUseKindFlags <UseKindFlags>k__BackingField;
            /*0x14*/ JetBrains.Annotations.ImplicitUseTargetFlags <TargetFlags>k__BackingField;

            /*0x3d699d8*/ UsedImplicitlyAttribute();
            /*0x3d69a28*/ UsedImplicitlyAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags);
            /*0x3d699fc*/ UsedImplicitlyAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, JetBrains.Annotations.ImplicitUseTargetFlags targetFlags);
        }

        class MeansImplicitUseAttribute : System.Attribute
        {
            /*0x10*/ JetBrains.Annotations.ImplicitUseKindFlags <UseKindFlags>k__BackingField;
            /*0x14*/ JetBrains.Annotations.ImplicitUseTargetFlags <TargetFlags>k__BackingField;

            /*0x3d69a54*/ MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseTargetFlags targetFlags);
            /*0x3d69a80*/ MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, JetBrains.Annotations.ImplicitUseTargetFlags targetFlags);
        }

        enum ImplicitUseKindFlags
        {
            Default = 7,
            Access = 1,
            Assign = 2,
            InstantiatedWithFixedConstructorSignature = 4,
            InstantiatedNoFixedConstructorSignature = 8,
        }

        enum ImplicitUseTargetFlags
        {
            Default = 1,
            Itself = 1,
            Members = 2,
            WithMembers = 3,
        }

        class PublicAPIAttribute : System.Attribute
        {
            /*0x3d69aac*/ PublicAPIAttribute();
        }

        class PureAttribute : System.Attribute
        {
            /*0x3d69ab4*/ PureAttribute();
        }

        class MustUseReturnValueAttribute : System.Attribute
        {
            /*0x3d69abc*/ MustUseReturnValueAttribute();
        }

        class CollectionAccessAttribute : System.Attribute
        {
            /*0x10*/ JetBrains.Annotations.CollectionAccessType <CollectionAccessType>k__BackingField;

            /*0x3d69ac4*/ CollectionAccessAttribute(JetBrains.Annotations.CollectionAccessType collectionAccessType);
        }

        enum CollectionAccessType
        {
            None = 0,
            Read = 1,
            ModifyExistingContent = 2,
            UpdatedContent = 6,
        }
    }
}

namespace UnityEngine
{
    enum SpriteDrawMode
    {
        Simple = 0,
        Sliced = 1,
        Tiled = 2,
    }

    enum SpriteTileMode
    {
        Continuous = 0,
        Adaptive = 1,
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

        static /*0x3d69f30*/ bool get_shouldSupportTiling_Injected(nint _unity_self);
        static /*0x3d69fe4*/ bool get_hasSpriteChangeEvents_Injected(nint _unity_self);
        static /*0x3d6a020*/ void set_hasSpriteChangeEvents_Injected(nint _unity_self, bool value);
        static /*0x3d6a0f8*/ nint get_sprite_Injected(nint _unity_self);
        static /*0x3d6a1e8*/ void set_sprite_Injected(nint _unity_self, nint value);
        static /*0x3d6a2a4*/ UnityEngine.SpriteDrawMode get_drawMode_Injected(nint _unity_self);
        static /*0x3d6a360*/ void set_drawMode_Injected(nint _unity_self, UnityEngine.SpriteDrawMode value);
        static /*0x3d6a42c*/ void get_size_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3d6a4f4*/ void set_size_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3d6a5b0*/ float get_adaptiveModeThreshold_Injected(nint _unity_self);
        static /*0x3d6a674*/ void set_adaptiveModeThreshold_Injected(nint _unity_self, float value);
        static /*0x3d6a738*/ UnityEngine.SpriteTileMode get_tileMode_Injected(nint _unity_self);
        static /*0x3d6a7f4*/ void set_tileMode_Injected(nint _unity_self, UnityEngine.SpriteTileMode value);
        static /*0x3d6a8cc*/ void get_color_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x3d6a9a0*/ void set_color_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x3d6aa5c*/ UnityEngine.SpriteMaskInteraction get_maskInteraction_Injected(nint _unity_self);
        static /*0x3d6ab18*/ void set_maskInteraction_Injected(nint _unity_self, UnityEngine.SpriteMaskInteraction value);
        static /*0x3d6abd4*/ bool get_flipX_Injected(nint _unity_self);
        static /*0x3d6ac90*/ void set_flipX_Injected(nint _unity_self, bool value);
        static /*0x3d6ad4c*/ bool get_flipY_Injected(nint _unity_self);
        static /*0x3d6ae08*/ void set_flipY_Injected(nint _unity_self, bool value);
        static /*0x3d6aec4*/ UnityEngine.SpriteSortPoint get_spriteSortPoint_Injected(nint _unity_self);
        static /*0x3d6af80*/ void set_spriteSortPoint_Injected(nint _unity_self, UnityEngine.SpriteSortPoint value);
        static /*0x3d6b03c*/ nint GetCurrentMeshDataPtr_Injected(nint _unity_self);
        static /*0x3d6b184*/ void Internal_GetSpriteBounds_Injected(nint _unity_self, UnityEngine.SpriteDrawMode mode, ref UnityEngine.Bounds ret);
        static /*0x3d6b2b0*/ void GetSecondaryTextureProperties_Injected(nint _unity_self, nint mbp);
        /*0x3d6b338*/ SpriteRenderer();
        /*0x3d69aec*/ void RegisterSpriteChangeCallback(UnityEngine.Events.UnityAction<UnityEngine.SpriteRenderer> callback);
        /*0x3d69c30*/ void UnregisterSpriteChangeCallback(UnityEngine.Events.UnityAction<UnityEngine.SpriteRenderer> callback);
        /*0x3d69cb4*/ void InvokeSpriteChanged();
        /*0x3d69eb8*/ bool get_shouldSupportTiling();
        /*0x3d69f6c*/ bool get_hasSpriteChangeEvents();
        /*0x3d69bb0*/ void set_hasSpriteChangeEvents(bool value);
        /*0x3d6a064*/ UnityEngine.Sprite get_sprite();
        /*0x3d6a134*/ void set_sprite(UnityEngine.Sprite value);
        /*0x3d6a22c*/ UnityEngine.SpriteDrawMode get_drawMode();
        /*0x3d6a2e0*/ void set_drawMode(UnityEngine.SpriteDrawMode value);
        /*0x3d6a3a4*/ UnityEngine.Vector2 get_size();
        /*0x3d6a470*/ void set_size(UnityEngine.Vector2 value);
        /*0x3d6a538*/ float get_adaptiveModeThreshold();
        /*0x3d6a5ec*/ void set_adaptiveModeThreshold(float value);
        /*0x3d6a6c0*/ UnityEngine.SpriteTileMode get_tileMode();
        /*0x3d6a774*/ void set_tileMode(UnityEngine.SpriteTileMode value);
        /*0x3d6a838*/ UnityEngine.Color get_color();
        /*0x3d6a910*/ void set_color(UnityEngine.Color value);
        /*0x3d6a9e4*/ UnityEngine.SpriteMaskInteraction get_maskInteraction();
        /*0x3d6aa98*/ void set_maskInteraction(UnityEngine.SpriteMaskInteraction value);
        /*0x3d6ab5c*/ bool get_flipX();
        /*0x3d6ac10*/ void set_flipX(bool value);
        /*0x3d6acd4*/ bool get_flipY();
        /*0x3d6ad88*/ void set_flipY(bool value);
        /*0x3d6ae4c*/ UnityEngine.SpriteSortPoint get_spriteSortPoint();
        /*0x3d6af00*/ void set_spriteSortPoint(UnityEngine.SpriteSortPoint value);
        /*0x3d6afc4*/ nint GetCurrentMeshDataPtr();
        /*0x3d6b078*/ UnityEngine.Mesh.MeshDataArray GetCurrentMeshData();
        /*0x3d6b0d4*/ UnityEngine.Bounds Internal_GetSpriteBounds(UnityEngine.SpriteDrawMode mode);
        /*0x3d6b1d8*/ void GetSecondaryTextureProperties(UnityEngine.MaterialPropertyBlock mbp);
        /*0x3d6b2f4*/ UnityEngine.Bounds GetSpriteBounds();
    }

    enum SpriteMeshType
    {
        FullRect = 0,
        Tight = 1,
    }

    enum SpritePackingMode
    {
        Tight = 0,
        Rectangle = 1,
    }

    enum SpritePackingRotation
    {
        None = 0,
        FlipHorizontal = 1,
        FlipVertical = 2,
        Rotate180 = 3,
        Any = 15,
    }

    enum SpriteSortPoint
    {
        Center = 0,
        Pivot = 1,
    }

    struct SecondarySpriteTexture
    {
        /*0x10*/ string name;
        /*0x18*/ UnityEngine.Texture2D texture;
    }

    class Sprite : UnityEngine.Object
    {
        static /*0x3d6b9e0*/ UnityEngine.Sprite CreateSpriteWithoutTextureScripting(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsToUnits, UnityEngine.Texture2D texture);
        static /*0x3d6bb0c*/ UnityEngine.Sprite CreateSprite(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[] secondaryTexture);
        static /*0x3d6d0d0*/ void GetPhysicsShapeImpl(UnityEngine.Sprite sprite, int shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2> physicsShape);
        static /*0x3d6d700*/ void OverridePhysicsShapeCount(UnityEngine.Sprite sprite, int physicsShapeCount);
        static /*0x3d6d78c*/ void OverridePhysicsShape(UnityEngine.Sprite sprite, UnityEngine.Vector2[] physicsShape, int idx);
        static /*0x3d6db88*/ UnityEngine.Sprite Create(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsToUnits, UnityEngine.Texture2D texture);
        static /*0x3d6db8c*/ UnityEngine.Sprite Create(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsToUnits);
        static /*0x3d6db94*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape);
        static /*0x3d6dba4*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[] secondaryTextures);
        static /*0x3d6dff8*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border);
        static /*0x3d6e00c*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType);
        static /*0x3d6e0f4*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude);
        static /*0x3d6e0fc*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit);
        static /*0x3d6e108*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot);
        static /*0x3d6b410*/ int GetPackingMode_Injected(nint _unity_self);
        static /*0x3d6b4c4*/ int GetPackingRotation_Injected(nint _unity_self);
        static /*0x3d6b578*/ int GetPacked_Injected(nint _unity_self);
        static /*0x3d6b648*/ void GetTextureRect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x3d6b714*/ void GetTextureRectOffset_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3d6b7ec*/ void GetInnerUVs_Injected(nint _unity_self, ref UnityEngine.Vector4 ret);
        static /*0x3d6b8c4*/ void GetOuterUVs_Injected(nint _unity_self, ref UnityEngine.Vector4 ret);
        static /*0x3d6b99c*/ void GetPadding_Injected(nint _unity_self, ref UnityEngine.Vector4 ret);
        static /*0x3d6baa8*/ nint CreateSpriteWithoutTextureScripting_Injected(ref UnityEngine.Rect rect, ref UnityEngine.Vector2 pivot, float pixelsToUnits, nint texture);
        static /*0x3d6bc10*/ nint CreateSprite_Injected(nint texture, ref UnityEngine.Rect rect, ref UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, ref UnityEngine.Vector4 border, bool generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[] secondaryTexture);
        static /*0x3d6bd50*/ void get_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x3d6be28*/ void get_rect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x3d6bf00*/ void get_border_Injected(nint _unity_self, ref UnityEngine.Vector4 ret);
        static /*0x3d6bfd8*/ nint get_texture_Injected(nint _unity_self);
        static /*0x3d6c08c*/ uint get_extrude_Injected(nint _unity_self);
        static /*0x3d6c16c*/ nint GetSecondaryTexture_Injected(nint _unity_self, int index);
        static /*0x3d6c228*/ int GetSecondaryTextureCount_Injected(nint _unity_self);
        static /*0x3d6c314*/ int GetSecondaryTextures_Injected(nint _unity_self, UnityEngine.SecondarySpriteTexture[] secondaryTexture);
        static /*0x3d6c3d0*/ float get_pixelsPerUnit_Injected(nint _unity_self);
        static /*0x3d6c484*/ float get_spriteAtlasTextureScale_Injected(nint _unity_self);
        static /*0x3d6c554*/ nint get_associatedAlphaSplitTexture_Injected(nint _unity_self);
        static /*0x3d6c618*/ void get_pivot_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3d6c6fc*/ UnityEngine.Vector2[] get_vertices_Injected(nint _unity_self);
        static /*0x3d6c7b0*/ ushort[] get_triangles_Injected(nint _unity_self);
        static /*0x3d6c864*/ UnityEngine.Vector2[] get_uv_Injected(nint _unity_self);
        static /*0x3d6c918*/ int GetPhysicsShapeCount_Injected(nint _unity_self);
        static /*0x3d6c9cc*/ uint GetScriptableObjectsCount_Injected(nint _unity_self);
        static /*0x3d6cab8*/ uint GetScriptableObjects_Injected(nint _unity_self, UnityEngine.ScriptableObject[] scriptableObjects);
        static /*0x3d6cbe0*/ bool AddScriptableObject_Injected(nint _unity_self, nint obj);
        static /*0x3d6cca4*/ bool RemoveScriptableObjectAt_Injected(nint _unity_self, uint i);
        static /*0x3d6cddc*/ bool SetScriptableObjectAt_Injected(nint _unity_self, nint obj, uint i);
        static /*0x3d6cf80*/ int Internal_GetPhysicsShapePointCount_Injected(nint _unity_self, int shapeIdx);
        static /*0x3d6d2e0*/ void GetPhysicsShapeImpl_Injected(nint sprite, int shapeIdx, ref UnityEngine.Bindings.BlittableListWrapper physicsShape);
        static /*0x3d6d8c0*/ void OverridePhysicsShapeCount_Injected(nint sprite, int physicsShapeCount);
        static /*0x3d6d904*/ void OverridePhysicsShape_Injected(nint sprite, ref UnityEngine.Bindings.ManagedSpanWrapper physicsShape, int idx);
        static /*0x3d6db34*/ void OverrideGeometry_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper vertices, ref UnityEngine.Bindings.ManagedSpanWrapper triangles);
        /*0x3d6b340*/ Sprite();
        /*0x3d6b398*/ int GetPackingMode();
        /*0x3d6b44c*/ int GetPackingRotation();
        /*0x3d6b500*/ int GetPacked();
        /*0x3d6b5b4*/ UnityEngine.Rect GetTextureRect();
        /*0x3d6b68c*/ UnityEngine.Vector2 GetTextureRectOffset();
        /*0x3d6b758*/ UnityEngine.Vector4 GetInnerUVs();
        /*0x3d6b830*/ UnityEngine.Vector4 GetOuterUVs();
        /*0x3d6b908*/ UnityEngine.Vector4 GetPadding();
        /*0x3d6bcac*/ UnityEngine.Bounds get_bounds();
        /*0x3d6bd94*/ UnityEngine.Rect get_rect();
        /*0x3d6be6c*/ UnityEngine.Vector4 get_border();
        /*0x3d6bf44*/ UnityEngine.Texture2D get_texture();
        /*0x3d6c014*/ uint get_extrude();
        /*0x3d6c0c8*/ UnityEngine.Texture2D GetSecondaryTexture(int index);
        /*0x3d6c1b0*/ int GetSecondaryTextureCount();
        /*0x3d6c264*/ int GetSecondaryTextures(UnityEngine.SecondarySpriteTexture[] secondaryTexture);
        /*0x3d6c358*/ float get_pixelsPerUnit();
        /*0x3d6c40c*/ float get_spriteAtlasTextureScale();
        /*0x3d6c4c0*/ UnityEngine.Texture2D get_associatedAlphaSplitTexture();
        /*0x3d6c590*/ UnityEngine.Vector2 get_pivot();
        /*0x3d6c65c*/ bool get_packed();
        /*0x3d6c674*/ UnityEngine.SpritePackingMode get_packingMode();
        /*0x3d6c678*/ UnityEngine.SpritePackingRotation get_packingRotation();
        /*0x3d6c67c*/ UnityEngine.Rect get_textureRect();
        /*0x3d6c680*/ UnityEngine.Vector2 get_textureRectOffset();
        /*0x3d6c684*/ UnityEngine.Vector2[] get_vertices();
        /*0x3d6c738*/ ushort[] get_triangles();
        /*0x3d6c7ec*/ UnityEngine.Vector2[] get_uv();
        /*0x3d6c8a0*/ int GetPhysicsShapeCount();
        /*0x3d6c954*/ uint GetScriptableObjectsCount();
        /*0x3d6ca08*/ uint GetScriptableObjects(UnityEngine.ScriptableObject[] scriptableObjects);
        /*0x3d6cafc*/ bool AddScriptableObject(UnityEngine.ScriptableObject obj);
        /*0x3d6cc24*/ bool RemoveScriptableObjectAt(uint i);
        /*0x3d6cce8*/ bool SetScriptableObjectAt(UnityEngine.ScriptableObject obj, uint i);
        /*0x3d6ce30*/ int GetPhysicsShapePointCount(int shapeIdx);
        /*0x3d6cf00*/ int Internal_GetPhysicsShapePointCount(int shapeIdx);
        /*0x3d6cfc4*/ int GetPhysicsShape(int shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2> physicsShape);
        /*0x3d6d334*/ void OverridePhysicsShape(System.Collections.Generic.IList<UnityEngine.Vector2[]> physicsShapes);
        /*0x3d6d958*/ void OverrideGeometry(UnityEngine.Vector2[] vertices, ushort[] triangles);
    }

    struct SortingLayer
    {
        /*0x10*/ int m_Id;

        static /*0x3d6e11c*/ int GetLayerValueFromID(int id);
        static /*0x3d6e158*/ int NameToID(string name);
        static /*0x3d6e2c8*/ int NameToID_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
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

        /*0x3d6e304*/ Keyframe(float time, float value);
        /*0x3d6e314*/ Keyframe(float time, float value, float inTangent, float outTangent);
        /*0x3d6e328*/ float get_time();
        /*0x3d6e330*/ void set_time(float value);
        /*0x3d6e338*/ float get_value();
        /*0x3d6e340*/ void set_value(float value);
        /*0x3d6e348*/ float get_inTangent();
        /*0x3d6e350*/ void set_inTangent(float value);
        /*0x3d6e358*/ float get_outTangent();
        /*0x3d6e360*/ void set_outTangent(float value);
        /*0x3d6e368*/ float get_inWeight();
        /*0x3d6e370*/ void set_inWeight(float value);
        /*0x3d6e378*/ float get_outWeight();
        /*0x3d6e380*/ void set_outWeight(float value);
        /*0x3d6e388*/ UnityEngine.WeightedMode get_weightedMode();
        /*0x3d6e390*/ void set_weightedMode(UnityEngine.WeightedMode value);
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
        /*0x18*/ bool m_RequiresNativeCleanup;

        static /*0x3d6e398*/ void Internal_Destroy(nint ptr);
        static /*0x3d6e3d4*/ nint Internal_Create(UnityEngine.Keyframe[] keys);
        static /*0x3d6f09c*/ UnityEngine.AnimationCurve Constant(float timeStart, float timeEnd, float value);
        static /*0x3d6f0ac*/ UnityEngine.AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd);
        static /*0x3d6f20c*/ UnityEngine.AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd);
        static /*0x3d6e4a4*/ nint Internal_Create_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keys);
        static /*0x3d6e538*/ bool Internal_Equals_Injected(nint _unity_self, nint other);
        static /*0x3d6e5d4*/ void Internal_CopyFrom_Injected(nint _unity_self, nint other);
        static /*0x3d6e734*/ float Evaluate_Injected(nint _unity_self, float time);
        static /*0x3d6ea2c*/ int AddKey_Injected(nint _unity_self, float time, float value);
        static /*0x3d6eb04*/ int AddKey_Internal_Injected(nint _unity_self, ref UnityEngine.Keyframe key);
        static /*0x3d6ebb0*/ int MoveKey_Injected(nint _unity_self, int index, ref UnityEngine.Keyframe key);
        static /*0x3d6ec54*/ void ClearKeys_Injected(nint _unity_self);
        static /*0x3d6ece8*/ void RemoveKey_Injected(nint _unity_self, int index);
        static /*0x3d6ee3c*/ int get_length_Injected(nint _unity_self);
        static /*0x3d6ee78*/ void SetKeys_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keys);
        static /*0x3d6eebc*/ void GetKey_Injected(nint _unity_self, int index, ref UnityEngine.Keyframe ret);
        static /*0x3d6ef10*/ void GetKeys_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3d6efa4*/ int GetHashCode_Injected(nint _unity_self);
        static /*0x3d6f048*/ void SmoothTangents_Injected(nint _unity_self, int index, float weight);
        /*0x3d6f1d4*/ AnimationCurve(UnityEngine.Keyframe[] keys);
        /*0x3d6f320*/ AnimationCurve();
        /*0x3d6f34c*/ AnimationCurve(nint ptr, bool ownMemory);
        /*0x3d6e4e0*/ bool Internal_Equals(nint other);
        /*0x3d6e57c*/ void Internal_CopyFrom(nint other);
        /*0x3d6e618*/ void Finalize();
        /*0x3d6e6d4*/ float Evaluate(float time);
        /*0x3d6e780*/ UnityEngine.Keyframe[] get_keys();
        /*0x3d6e8cc*/ void set_keys(UnityEngine.Keyframe[] value);
        /*0x3d6e9c4*/ int AddKey(float time, float value);
        /*0x3d6ea80*/ int AddKey(UnityEngine.Keyframe key);
        /*0x3d6eaac*/ int AddKey_Internal(UnityEngine.Keyframe key);
        /*0x3d6eb48*/ int MoveKey(int index, UnityEngine.Keyframe key);
        /*0x3d6ec04*/ void ClearKeys();
        /*0x3d6ec90*/ void RemoveKey(int index);
        /*0x3d6ed2c*/ UnityEngine.Keyframe get_Item(int index);
        /*0x3d6edec*/ int get_length();
        /*0x3d6e8d0*/ void SetKeys(UnityEngine.Keyframe[] keys);
        /*0x3d6ed5c*/ UnityEngine.Keyframe GetKey(int index);
        /*0x3d6e784*/ UnityEngine.Keyframe[] GetKeys();
        /*0x3d6ef54*/ int GetHashCode();
        /*0x3d6efe0*/ void SmoothTangents(int index, float weight);
        /*0x3d6f37c*/ bool Equals(object o);
        /*0x3d6f47c*/ bool Equals(UnityEngine.AnimationCurve other);
        /*0x3d6f4f4*/ void CopyFrom(UnityEngine.AnimationCurve other);

        class BindingsMarshaller
        {
            static /*0x3d6f508*/ UnityEngine.AnimationCurve ConvertToManaged(nint ptr);
            static /*0x3d6f56c*/ nint ConvertToNative(UnityEngine.AnimationCurve animationCurve);
        }
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
        static /*0x50*/ UnityEngine.Application.LogCallback s_RegisterLogCallbackDeprecated;

        static /*0x3d71cb4*/ Application();
        static /*0x3d6f580*/ void Quit(int exitCode);
        static /*0x3d6f5bc*/ void Quit();
        static /*0x3d6f62c*/ bool get_isPlaying();
        static /*0x3d6f654*/ bool get_isFocused();
        static /*0x3d6f67c*/ bool get_runInBackground();
        static /*0x3d6f6a4*/ bool get_isBatchMode();
        static /*0x3d6f6cc*/ string get_dataPath();
        static /*0x3d6f804*/ string get_streamingAssetsPath();
        static /*0x3d6f93c*/ string get_persistentDataPath();
        static /*0x3d6fa74*/ string get_temporaryCachePath();
        static /*0x3d6fbac*/ string get_absoluteURL();
        static /*0x3d6fce4*/ string get_unityVersion();
        static /*0x3d6fe1c*/ string get_version();
        static /*0x3d6ff54*/ string get_identifier();
        static /*0x3d7008c*/ string get_productName();
        static /*0x3d701c4*/ bool RequestAdvertisingIdentifierAsync(UnityEngine.Application.AdvertisingIdentifierCallback delegateMethod);
        static /*0x3d70200*/ void OpenURL(string url);
        static /*0x3d703c8*/ void set_targetFrameRate(int value);
        static /*0x3d70404*/ void SetLogCallbackDefined(bool defined);
        static /*0x3d70440*/ UnityEngine.StackTraceLogType GetStackTraceLogType(UnityEngine.LogType logType);
        static /*0x3d7047c*/ void SetStackTraceLogType(UnityEngine.LogType logType, UnityEngine.StackTraceLogType stackTraceType);
        static /*0x3d704c0*/ void set_backgroundLoadingPriority(UnityEngine.ThreadPriority value);
        static /*0x3d704fc*/ UnityEngine.RuntimePlatform get_platform();
        static /*0x3d70524*/ bool get_isMobilePlatform();
        static /*0x3d705c8*/ UnityEngine.NetworkReachability get_internetReachability();
        static /*0x3d705f0*/ void add_lowMemory(UnityEngine.Application.LowMemoryCallback value);
        static /*0x3d706c8*/ void remove_lowMemory(UnityEngine.Application.LowMemoryCallback value);
        static /*0x3d707a0*/ void CallLowMemory(UnityEngine.ApplicationMemoryUsage usage);
        static /*0x3d708d8*/ bool HasLogCallback();
        static /*0x3d7095c*/ void add_logMessageReceived(UnityEngine.Application.LogCallback value);
        static /*0x3d70a48*/ void remove_logMessageReceived(UnityEngine.Application.LogCallback value);
        static /*0x3d70b0c*/ void add_logMessageReceivedThreaded(UnityEngine.Application.LogCallback value);
        static /*0x3d70bf8*/ void remove_logMessageReceivedThreaded(UnityEngine.Application.LogCallback value);
        static /*0x3d70cbc*/ void CallLogCallback(string logString, string stackTrace, UnityEngine.LogType type, bool invokedOnMainThread);
        static /*0x3d70da4*/ void add_onBeforeRender(UnityEngine.Events.UnityAction value);
        static /*0x3d70dfc*/ void remove_onBeforeRender(UnityEngine.Events.UnityAction value);
        static /*0x3d70e54*/ void add_focusChanged(System.Action<bool> value);
        static /*0x3d70f48*/ void remove_focusChanged(System.Action<bool> value);
        static /*0x3d7103c*/ void add_deepLinkActivated(System.Action<string> value);
        static /*0x3d71130*/ void remove_deepLinkActivated(System.Action<string> value);
        static /*0x3d71224*/ void add_wantsToQuit(System.Func<bool> value);
        static /*0x3d71318*/ void remove_wantsToQuit(System.Func<bool> value);
        static /*0x3d7140c*/ bool Internal_ApplicationWantsToQuit();
        static /*0x3d71730*/ void Internal_InitializeExitCancellationToken();
        static /*0x3d71810*/ void Internal_RaiseExitCancellationToken();
        static /*0x3d7187c*/ void Internal_ApplicationQuit();
        static /*0x3d71910*/ void Internal_ApplicationUnload();
        static /*0x3d719a4*/ void InvokeOnBeforeRender();
        static /*0x3d719f4*/ void InvokeFocusChanged(bool focus);
        static /*0x3d71a98*/ void InvokeDeepLinkActivated(string url);
        static /*0x3d71b34*/ void RegisterLogCallback(UnityEngine.Application.LogCallback handler);
        static /*0x3d71b8c*/ void RegisterLogCallback(UnityEngine.Application.LogCallback handler, bool threaded);
        static /*0x3d71cac*/ bool get_isEditor();
        static /*0x3d6f7c8*/ void get_dataPath_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d6f900*/ void get_streamingAssetsPath_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d6fa38*/ void get_persistentDataPath_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d6fb70*/ void get_temporaryCachePath_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d6fca8*/ void get_absoluteURL_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d6fde0*/ void get_unityVersion_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d6ff18*/ void get_version_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d70050*/ void get_identifier_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d70188*/ void get_productName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d7038c*/ void OpenURL_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper url);

        class AdvertisingIdentifierCallback : System.MulticastDelegate
        {
            /*0x3d71d28*/ AdvertisingIdentifierCallback(object object, nint method);
            /*0x3d71ddc*/ void Invoke(string advertisingId, bool trackingEnabled, string errorMsg);
        }

        class LowMemoryCallback : System.MulticastDelegate
        {
            /*0x3d71df0*/ LowMemoryCallback(object object, nint method);
            /*0x3d71e8c*/ void Invoke();
        }

        class MemoryUsageChangedCallback : System.MulticastDelegate
        {
            /*0x3d71ea0*/ MemoryUsageChangedCallback(object object, nint method);
            /*0x3d71f50*/ void Invoke(ref UnityEngine.ApplicationMemoryUsageChange usage);
        }

        class LogCallback : System.MulticastDelegate
        {
            /*0x3d71f64*/ LogCallback(object object, nint method);
            /*0x3d72018*/ void Invoke(string condition, string stackTrace, UnityEngine.LogType type);
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

        /*0x3d708d0*/ ApplicationMemoryUsageChange(UnityEngine.ApplicationMemoryUsage usage);
        /*0x3d7202c*/ void set_memoryUsage(UnityEngine.ApplicationMemoryUsage value);
    }

    enum StackTraceLogType
    {
        None = 0,
        ScriptOnly = 1,
        Full = 2,
    }

    enum NetworkReachability
    {
        NotReachable = 0,
        ReachableViaCarrierDataNetwork = 1,
        ReachableViaLocalAreaNetwork = 2,
    }

    enum SendMessageOptions
    {
        RequireReceiver = 0,
        DontRequireReceiver = 1,
    }

    enum PrimitiveType
    {
        Sphere = 0,
        Capsule = 1,
        Cylinder = 2,
        Cube = 3,
        Plane = 4,
        Quad = 5,
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
        CloudRendering = -1,
        LinuxHeadlessSimulation = 35,
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
        Switch2 = 51,
        KeplerArm64 = 52,
        KeplerX64 = 53,
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

    enum ThreadPriority
    {
        Low = 0,
        BelowNormal = 1,
        Normal = 2,
        High = 4,
    }

    class BootConfigData
    {
        /*0x10*/ nint m_Ptr;

        static /*0x3d72034*/ UnityEngine.BootConfigData WrapBootConfigData(nint nativeHandle);
        /*0x3d7208c*/ BootConfigData(nint nativeHandle);
    }

    struct CachedAssetBundle
    {
        /*0x10*/ string m_Name;
        /*0x18*/ UnityEngine.Hash128 m_Hash;

        /*0x3d72100*/ CachedAssetBundle(string name, UnityEngine.Hash128 hash);
        /*0x3d7212c*/ string get_name();
        /*0x3d72134*/ UnityEngine.Hash128 get_hash();
    }

    struct Cache : System.IEquatable<UnityEngine.Cache>
    {
        /*0x10*/ int m_Handle;

        static /*0x3d72214*/ bool Cache_IsValid(int handle);
        static /*0x3d72258*/ string Cache_GetPath(int handle);
        static /*0x3d723ac*/ void Cache_SetMaximumDiskSpaceAvailable(int handle, long value);
        static /*0x3d72434*/ void Cache_SetExpirationDelay(int handle, int value);
        static /*0x3d72324*/ void Cache_GetPath_Injected(int handle, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        /*0x3d72140*/ int get_handle();
        /*0x3d72148*/ int GetHashCode();
        /*0x3d72150*/ bool Equals(object other);
        /*0x3d721c8*/ bool Equals(UnityEngine.Cache other);
        /*0x3d721d8*/ bool get_valid();
        /*0x3d72250*/ string get_path();
        /*0x3d72368*/ void set_maximumAvailableStorageSpace(long value);
        /*0x3d723f0*/ void set_expirationDelay(int value);
    }

    class Caching
    {
        static /*0x3d72478*/ void set_compressionEnabled(bool value);
        static /*0x3d724b4*/ bool get_ready();
        static /*0x3d724dc*/ bool ClearCache();
        static /*0x3d72504*/ bool ClearCachedVersion(string assetBundleName, UnityEngine.Hash128 hash);
        static /*0x3d72584*/ bool ClearCachedVersionInternal(string assetBundleName, UnityEngine.Hash128 hash);
        static /*0x3d72744*/ bool ClearOtherCachedVersions(string assetBundleName, UnityEngine.Hash128 hash);
        static /*0x3d7294c*/ bool ClearAllCachedVersions(string assetBundleName);
        static /*0x3d727c8*/ bool ClearCachedVersions(string assetBundleName, UnityEngine.Hash128 hash, bool keepInputVersion);
        static /*0x3d72a14*/ UnityEngine.Hash128[] GetCachedVersions(string assetBundleName);
        static /*0x3d72c70*/ void GetCachedVersions(string assetBundleName, System.Collections.Generic.List<UnityEngine.Hash128> outCachedVersions);
        static /*0x3d72d58*/ bool IsVersionCached(UnityEngine.CachedAssetBundle cachedBundle);
        static /*0x3d72dfc*/ bool IsVersionCached(string url, string assetBundleName, UnityEngine.Hash128 hash);
        static /*0x3d73094*/ UnityEngine.Cache AddCache(string cachePath);
        static /*0x3d73424*/ UnityEngine.Cache AddCache(string cachePath, bool isReadonly);
        static /*0x3d732b0*/ UnityEngine.Cache GetCacheByPath(string cachePath);
        static /*0x3d73638*/ UnityEngine.Cache get_defaultCache();
        static /*0x3d736b8*/ UnityEngine.Cache get_currentCacheForWriting();
        static /*0x3d73738*/ void set_currentCacheForWriting(UnityEngine.Cache value);
        static /*0x3d72700*/ bool ClearCachedVersionInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper assetBundleName, ref UnityEngine.Hash128 hash);
        static /*0x3d729c0*/ bool ClearCachedVersions_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper assetBundleName, ref UnityEngine.Hash128 hash, bool keepInputVersion);
        static /*0x3d72c2c*/ void GetCachedVersions_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper assetBundleName, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3d73040*/ bool IsVersionCached_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper url, ref UnityEngine.Bindings.ManagedSpanWrapper assetBundleName, ref UnityEngine.Hash128 hash);
        static /*0x3d735a0*/ void AddCache_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper cachePath, bool isReadonly, ref UnityEngine.Cache ret);
        static /*0x3d735f4*/ void GetCacheByPath_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper cachePath, ref UnityEngine.Cache ret);
        static /*0x3d7367c*/ void get_defaultCache_Injected(ref UnityEngine.Cache ret);
        static /*0x3d736fc*/ void get_currentCacheForWriting_Injected(ref UnityEngine.Cache ret);
        static /*0x3d73778*/ void set_currentCacheForWriting_Injected(ref UnityEngine.Cache value);
    }

    class BatchRendererGroupRuntimeAnalytic : UnityEngine.Analytics.AnalyticsEventBase
    {
        /*0x2c*/ int brgRuntimeStatus;

        static /*0x3d73828*/ UnityEngine.BatchRendererGroupRuntimeAnalytic CreateBatchRendererGroupRuntimeAnalytic();
        /*0x3d737b4*/ BatchRendererGroupRuntimeAnalytic();
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
        /*0x18*/ uint m_NonSerializedVersion;

        static /*0x3d76288*/ int get_PreviewCullingLayer();
        static /*0x3d7aaec*/ void CalculateProjectionMatrixFromPhysicalPropertiesInternal(ref UnityEngine.Matrix4x4 output, float focalLength, UnityEngine.Vector2 sensorSize, UnityEngine.Vector2 lensShift, float nearClip, float farClip, float gateAspect, UnityEngine.Camera.GateFitMode gateFitMode);
        static /*0x3d7ac08*/ void CalculateProjectionMatrixFromPhysicalProperties(ref UnityEngine.Matrix4x4 output, float focalLength, UnityEngine.Vector2 sensorSize, UnityEngine.Vector2 lensShift, float nearClip, float farClip, UnityEngine.Camera.GateFitParameters gateFitParameters);
        static /*0x3d7ac14*/ float FocalLengthToFieldOfView(float focalLength, float sensorSize);
        static /*0x3d7ac54*/ float FieldOfViewToFocalLength(float fieldOfView, float sensorSize);
        static /*0x3d7ac94*/ float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio);
        static /*0x3d7acd4*/ float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio);
        static /*0x3d7ad14*/ UnityEngine.Camera get_main();
        static /*0x3d7ad9c*/ UnityEngine.Camera get_current();
        static /*0x3d7ada0*/ UnityEngine.Camera get_currentInternal();
        static /*0x3d7be68*/ int GetAllCamerasCount();
        static /*0x3d7be90*/ int GetAllCamerasImpl(UnityEngine.Camera[] cam);
        static /*0x3d7bf44*/ int get_allCamerasCount();
        static /*0x3d7bf6c*/ UnityEngine.Camera[] get_allCameras();
        static /*0x3d7bfe4*/ int GetAllCameras(UnityEngine.Camera[] cameras);
        static /*0x3d7cc04*/ void SetupCurrent(UnityEngine.Camera cur);
        static /*0x3d7dd14*/ void FireOnPreCull(UnityEngine.Camera cam);
        static /*0x3d7dd80*/ void FireOnPreRender(UnityEngine.Camera cam);
        static /*0x3d7ddec*/ void FireOnPostRender(UnityEngine.Camera cam);
        static /*0x3d7de58*/ void BumpNonSerializedVersion(UnityEngine.Camera cam);
        static /*0x3d7de8c*/ bool GetCullingParameters_Internal(UnityEngine.Camera camera, bool stereoAware, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, int managedCullingParametersSize);
        static /*0x3d738f8*/ float get_nearClipPlane_Injected(nint _unity_self);
        static /*0x3d739bc*/ void set_nearClipPlane_Injected(nint _unity_self, float value);
        static /*0x3d73a80*/ float get_farClipPlane_Injected(nint _unity_self);
        static /*0x3d73b44*/ void set_farClipPlane_Injected(nint _unity_self, float value);
        static /*0x3d73c08*/ float get_fieldOfView_Injected(nint _unity_self);
        static /*0x3d73ccc*/ void set_fieldOfView_Injected(nint _unity_self, float value);
        static /*0x3d73d90*/ UnityEngine.RenderingPath get_renderingPath_Injected(nint _unity_self);
        static /*0x3d73e4c*/ void set_renderingPath_Injected(nint _unity_self, UnityEngine.RenderingPath value);
        static /*0x3d73f08*/ UnityEngine.RenderingPath get_actualRenderingPath_Injected(nint _unity_self);
        static /*0x3d73fbc*/ void Reset_Injected(nint _unity_self);
        static /*0x3d74070*/ bool get_allowHDR_Injected(nint _unity_self);
        static /*0x3d7412c*/ void set_allowHDR_Injected(nint _unity_self, bool value);
        static /*0x3d741e8*/ bool get_allowMSAA_Injected(nint _unity_self);
        static /*0x3d742a4*/ void set_allowMSAA_Injected(nint _unity_self, bool value);
        static /*0x3d74360*/ bool get_allowDynamicResolution_Injected(nint _unity_self);
        static /*0x3d7441c*/ void set_allowDynamicResolution_Injected(nint _unity_self, bool value);
        static /*0x3d744d8*/ bool get_forceIntoRenderTexture_Injected(nint _unity_self);
        static /*0x3d74594*/ void set_forceIntoRenderTexture_Injected(nint _unity_self, bool value);
        static /*0x3d74650*/ float get_orthographicSize_Injected(nint _unity_self);
        static /*0x3d74714*/ void set_orthographicSize_Injected(nint _unity_self, float value);
        static /*0x3d747d8*/ bool get_orthographic_Injected(nint _unity_self);
        static /*0x3d74894*/ void set_orthographic_Injected(nint _unity_self, bool value);
        static /*0x3d74950*/ UnityEngine.Rendering.OpaqueSortMode get_opaqueSortMode_Injected(nint _unity_self);
        static /*0x3d74a0c*/ void set_opaqueSortMode_Injected(nint _unity_self, UnityEngine.Rendering.OpaqueSortMode value);
        static /*0x3d74ac8*/ UnityEngine.TransparencySortMode get_transparencySortMode_Injected(nint _unity_self);
        static /*0x3d74b84*/ void set_transparencySortMode_Injected(nint _unity_self, UnityEngine.TransparencySortMode value);
        static /*0x3d74c60*/ void get_transparencySortAxis_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3d74d34*/ void set_transparencySortAxis_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x3d74df0*/ void ResetTransparencySortSettings_Injected(nint _unity_self);
        static /*0x3d74ea4*/ float get_depth_Injected(nint _unity_self);
        static /*0x3d74f68*/ void set_depth_Injected(nint _unity_self, float value);
        static /*0x3d7502c*/ float get_aspect_Injected(nint _unity_self);
        static /*0x3d750f0*/ void set_aspect_Injected(nint _unity_self, float value);
        static /*0x3d751b4*/ void ResetAspect_Injected(nint _unity_self);
        static /*0x3d75288*/ void get_velocity_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3d75344*/ int get_cullingMask_Injected(nint _unity_self);
        static /*0x3d75400*/ void set_cullingMask_Injected(nint _unity_self, int value);
        static /*0x3d754bc*/ int get_eventMask_Injected(nint _unity_self);
        static /*0x3d75578*/ void set_eventMask_Injected(nint _unity_self, int value);
        static /*0x3d758ac*/ bool get_layerCullSphericalInternal_Injected(nint _unity_self);
        static /*0x3d758e8*/ void set_layerCullSphericalInternal_Injected(nint _unity_self, bool value);
        static /*0x3d759a4*/ UnityEngine.CameraType get_cameraType_Injected(nint _unity_self);
        static /*0x3d75a60*/ void set_cameraType_Injected(nint _unity_self, UnityEngine.CameraType value);
        static /*0x3d75b38*/ nint get_skyboxMaterial_Injected(nint _unity_self);
        static /*0x3d75bec*/ ulong get_overrideSceneCullingMask_Injected(nint _unity_self);
        static /*0x3d75ca8*/ void set_overrideSceneCullingMask_Injected(nint _unity_self, ulong value);
        static /*0x3d75d64*/ ulong get_sceneCullingMask_Injected(nint _unity_self);
        static /*0x3d75e18*/ bool get_useInteractiveLightBakingData_Injected(nint _unity_self);
        static /*0x3d75ed4*/ void set_useInteractiveLightBakingData_Injected(nint _unity_self, bool value);
        static /*0x3d7606c*/ void GetLayerCullDistances_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3d761d8*/ void SetLayerCullDistances_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper d);
        static /*0x3d76308*/ bool get_useOcclusionCulling_Injected(nint _unity_self);
        static /*0x3d763c4*/ void set_useOcclusionCulling_Injected(nint _unity_self, bool value);
        static /*0x3d764b0*/ void get_cullingMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x3d76574*/ void set_cullingMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
        static /*0x3d76630*/ void ResetCullingMatrix_Injected(nint _unity_self);
        static /*0x3d76700*/ void get_backgroundColor_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x3d767d4*/ void set_backgroundColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x3d76890*/ UnityEngine.CameraClearFlags get_clearFlags_Injected(nint _unity_self);
        static /*0x3d7694c*/ void set_clearFlags_Injected(nint _unity_self, UnityEngine.CameraClearFlags value);
        static /*0x3d76a08*/ UnityEngine.DepthTextureMode get_depthTextureMode_Injected(nint _unity_self);
        static /*0x3d76ac4*/ void set_depthTextureMode_Injected(nint _unity_self, UnityEngine.DepthTextureMode value);
        static /*0x3d76b80*/ bool get_clearStencilAfterLightingPass_Injected(nint _unity_self);
        static /*0x3d76c3c*/ void set_clearStencilAfterLightingPass_Injected(nint _unity_self, bool value);
        static /*0x3d76e5c*/ void SetReplacementShader_Injected(nint _unity_self, nint shader, ref UnityEngine.Bindings.ManagedSpanWrapper replacementTag);
        static /*0x3d76f28*/ void ResetReplacementShader_Injected(nint _unity_self);
        static /*0x3d76fdc*/ UnityEngine.Camera.ProjectionMatrixMode get_projectionMatrixMode_Injected(nint _unity_self);
        static /*0x3d77090*/ bool get_usePhysicalProperties_Injected(nint _unity_self);
        static /*0x3d7714c*/ void set_usePhysicalProperties_Injected(nint _unity_self, bool value);
        static /*0x3d77208*/ int get_iso_Injected(nint _unity_self);
        static /*0x3d772c4*/ void set_iso_Injected(nint _unity_self, int value);
        static /*0x3d77380*/ float get_shutterSpeed_Injected(nint _unity_self);
        static /*0x3d77444*/ void set_shutterSpeed_Injected(nint _unity_self, float value);
        static /*0x3d77508*/ float get_aperture_Injected(nint _unity_self);
        static /*0x3d775cc*/ void set_aperture_Injected(nint _unity_self, float value);
        static /*0x3d77690*/ float get_focusDistance_Injected(nint _unity_self);
        static /*0x3d77754*/ void set_focusDistance_Injected(nint _unity_self, float value);
        static /*0x3d77818*/ float get_focalLength_Injected(nint _unity_self);
        static /*0x3d778dc*/ void set_focalLength_Injected(nint _unity_self, float value);
        static /*0x3d779a0*/ int get_bladeCount_Injected(nint _unity_self);
        static /*0x3d77a5c*/ void set_bladeCount_Injected(nint _unity_self, int value);
        static /*0x3d77b28*/ void get_curvature_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3d77bf0*/ void set_curvature_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3d77cac*/ float get_barrelClipping_Injected(nint _unity_self);
        static /*0x3d77d70*/ void set_barrelClipping_Injected(nint _unity_self, float value);
        static /*0x3d77e34*/ float get_anamorphism_Injected(nint _unity_self);
        static /*0x3d77ef8*/ void set_anamorphism_Injected(nint _unity_self, float value);
        static /*0x3d77fcc*/ void get_sensorSize_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3d78094*/ void set_sensorSize_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3d78160*/ void get_lensShift_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3d78228*/ void set_lensShift_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3d782e4*/ UnityEngine.Camera.GateFitMode get_gateFit_Injected(nint _unity_self);
        static /*0x3d783a0*/ void set_gateFit_Injected(nint _unity_self, UnityEngine.Camera.GateFitMode value);
        static /*0x3d7845c*/ float GetGateFittedFieldOfView_Injected(nint _unity_self);
        static /*0x3d78520*/ void GetGateFittedLensShift_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3d785fc*/ void GetLocalSpaceAim_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3d786d4*/ void get_rect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x3d787a8*/ void set_rect_Injected(nint _unity_self, ref UnityEngine.Rect value);
        static /*0x3d78880*/ void get_pixelRect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x3d78954*/ void set_pixelRect_Injected(nint _unity_self, ref UnityEngine.Rect value);
        static /*0x3d78a10*/ int get_pixelWidth_Injected(nint _unity_self);
        static /*0x3d78ac4*/ int get_pixelHeight_Injected(nint _unity_self);
        static /*0x3d78b78*/ int get_scaledPixelWidth_Injected(nint _unity_self);
        static /*0x3d78c2c*/ int get_scaledPixelHeight_Injected(nint _unity_self);
        static /*0x3d78cfc*/ nint get_targetTexture_Injected(nint _unity_self);
        static /*0x3d78dec*/ void set_targetTexture_Injected(nint _unity_self, nint value);
        static /*0x3d78ec4*/ nint get_activeTexture_Injected(nint _unity_self);
        static /*0x3d78f78*/ int get_targetDisplay_Injected(nint _unity_self);
        static /*0x3d79034*/ void set_targetDisplay_Injected(nint _unity_self, int value);
        static /*0x3d7910c*/ void SetTargetBuffersImpl_Injected(nint _unity_self, ref UnityEngine.RenderBuffer color, ref UnityEngine.RenderBuffer depth);
        static /*0x3d7926c*/ void SetTargetBuffersMRTImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper color, ref UnityEngine.RenderBuffer depth);
        static /*0x3d7933c*/ string[] GetCameraBufferWarnings_Injected(nint _unity_self);
        static /*0x3d79420*/ void get_cameraToWorldMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x3d7950c*/ void get_worldToCameraMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x3d795d0*/ void set_worldToCameraMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
        static /*0x3d796bc*/ void get_projectionMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x3d79780*/ void set_projectionMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
        static /*0x3d7986c*/ void get_nonJitteredProjectionMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x3d79930*/ void set_nonJitteredProjectionMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
        static /*0x3d799ec*/ bool get_useJitteredProjectionMatrixForTransparentRendering_Injected(nint _unity_self);
        static /*0x3d79aa8*/ void set_useJitteredProjectionMatrixForTransparentRendering_Injected(nint _unity_self, bool value);
        static /*0x3d79b94*/ void get_previousViewProjectionMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x3d79c50*/ void ResetWorldToCameraMatrix_Injected(nint _unity_self);
        static /*0x3d79d04*/ void ResetProjectionMatrix_Injected(nint _unity_self);
        static /*0x3d79df4*/ void CalculateObliqueMatrix_Injected(nint _unity_self, ref UnityEngine.Vector4 clipPlane, ref UnityEngine.Matrix4x4 ret);
        static /*0x3d79ef4*/ void WorldToScreenPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        static /*0x3d79ffc*/ void WorldToViewportPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        static /*0x3d7a104*/ void ViewportToWorldPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        static /*0x3d7a20c*/ void ScreenToWorldPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        static /*0x3d7a32c*/ void ScreenToViewportPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x3d7a424*/ void ViewportToScreenPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x3d7a518*/ void GetFrustumPlaneSizeAt_Injected(nint _unity_self, float distance, ref UnityEngine.Vector2 ret);
        static /*0x3d7a624*/ void ViewportPointToRay_Injected(nint _unity_self, ref UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Ray ret);
        static /*0x3d7a79c*/ void ScreenPointToRay_Injected(nint _unity_self, ref UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Ray ret);
        static /*0x3d7a9cc*/ void CalculateFrustumCornersInternal_Injected(nint _unity_self, ref UnityEngine.Rect viewport, float z, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Bindings.BlittableArrayWrapper outCorners);
        static /*0x3d7ab7c*/ void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(ref UnityEngine.Matrix4x4 output, float focalLength, ref UnityEngine.Vector2 sensorSize, ref UnityEngine.Vector2 lensShift, float nearClip, float farClip, float gateAspect, UnityEngine.Camera.GateFitMode gateFitMode);
        static /*0x3d7ad74*/ nint get_main_Injected();
        static /*0x3d7ae00*/ nint get_currentInternal_Injected();
        static /*0x3d7aeb0*/ void get_scene_Injected(nint _unity_self, ref UnityEngine.SceneManagement.Scene ret);
        static /*0x3d7af78*/ void set_scene_Injected(nint _unity_self, ref UnityEngine.SceneManagement.Scene value);
        static /*0x3d7b034*/ bool get_stereoEnabled_Injected(nint _unity_self);
        static /*0x3d7b0e8*/ float get_stereoSeparation_Injected(nint _unity_self);
        static /*0x3d7b1ac*/ void set_stereoSeparation_Injected(nint _unity_self, float value);
        static /*0x3d7b270*/ float get_stereoConvergence_Injected(nint _unity_self);
        static /*0x3d7b334*/ void set_stereoConvergence_Injected(nint _unity_self, float value);
        static /*0x3d7b3f8*/ bool get_areVRStereoViewMatricesWithinSingleCullTolerance_Injected(nint _unity_self);
        static /*0x3d7b61c*/ UnityEngine.StereoTargetEyeMask get_stereoTargetEyeInternal_Injected(nint _unity_self);
        static /*0x3d7b658*/ void set_stereoTargetEyeInternal_Injected(nint _unity_self, UnityEngine.StereoTargetEyeMask value);
        static /*0x3d7b714*/ UnityEngine.Camera.MonoOrStereoscopicEye get_stereoActiveEye_Injected(nint _unity_self);
        static /*0x3d7b808*/ void GetStereoNonJitteredProjectionMatrix_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 ret);
        static /*0x3d7b914*/ void GetStereoViewMatrix_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 ret);
        static /*0x3d7b9e8*/ void CopyStereoDeviceProjectionMatrixToNonJittered_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye);
        static /*0x3d7bae4*/ void GetStereoProjectionMatrix_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 ret);
        static /*0x3d7bbc8*/ void SetStereoProjectionMatrix_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 matrix);
        static /*0x3d7bc94*/ void ResetStereoProjectionMatrices_Injected(nint _unity_self);
        static /*0x3d7bd60*/ void SetStereoViewMatrix_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 matrix);
        static /*0x3d7be2c*/ void ResetStereoViewMatrices_Injected(nint _unity_self);
        static /*0x3d7bf08*/ int GetAllCamerasImpl_Injected(UnityEngine.Camera[] cam);
        static /*0x3d7c154*/ bool RenderToCubemapImpl_Injected(nint _unity_self, nint tex, int faceMask);
        static /*0x3d7c238*/ int GetFilterMode_Injected(nint _unity_self);
        static /*0x3d7c2f0*/ bool get_renderCloudsInSceneView_Injected(nint _unity_self);
        static /*0x3d7c3ac*/ void set_renderCloudsInSceneView_Injected(nint _unity_self, bool value);
        static /*0x3d7c4bc*/ bool RenderToCubemapEyeImpl_Injected(nint _unity_self, nint cubemap, int faceMask, UnityEngine.Camera.MonoOrStereoscopicEye stereoEye);
        static /*0x3d7c594*/ void Render_Injected(nint _unity_self);
        static /*0x3d7c7ac*/ void RenderWithShader_Injected(nint _unity_self, nint shader, ref UnityEngine.Bindings.ManagedSpanWrapper replacementTag);
        static /*0x3d7c878*/ void RenderDontRestore_Injected(nint _unity_self);
        static /*0x3d7ca80*/ void SubmitRenderRequestsInternal_Injected(nint _unity_self, object requests);
        static /*0x3d7cb98*/ UnityEngine.Object[] SubmitBuiltInObjectIDRenderRequest_Injected(nint _unity_self, nint target, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
        static /*0x3d7cc80*/ void SetupCurrent_Injected(nint cur);
        static /*0x3d7cd70*/ void CopyFrom_Injected(nint _unity_self, nint other);
        static /*0x3d7ce2c*/ int get_commandBufferCount_Injected(nint _unity_self);
        static /*0x3d7cee8*/ void RemoveCommandBuffersImpl_Injected(nint _unity_self, UnityEngine.Rendering.CameraEvent evt);
        static /*0x3d7cfa4*/ void RemoveAllCommandBuffersImpl_Injected(nint _unity_self);
        static /*0x3d7d2ac*/ void AddCommandBufferImpl_Injected(nint _unity_self, UnityEngine.Rendering.CameraEvent evt, nint buffer);
        static /*0x3d7d3f0*/ void AddCommandBufferAsyncImpl_Injected(nint _unity_self, UnityEngine.Rendering.CameraEvent evt, nint buffer, UnityEngine.Rendering.ComputeQueueType queueType);
        static /*0x3d7d534*/ void RemoveCommandBufferImpl_Injected(nint _unity_self, UnityEngine.Rendering.CameraEvent evt, nint buffer);
        static /*0x3d7dcd0*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffersImpl_Injected(nint _unity_self, UnityEngine.Rendering.CameraEvent evt);
        static /*0x3d7df38*/ bool GetCullingParameters_Internal_Injected(nint camera, bool stereoAware, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, int managedCullingParametersSize);
        /*0x3d73878*/ Camera();
        /*0x3d73880*/ float get_nearClipPlane();
        /*0x3d73934*/ void set_nearClipPlane(float value);
        /*0x3d73a08*/ float get_farClipPlane();
        /*0x3d73abc*/ void set_farClipPlane(float value);
        /*0x3d73b90*/ float get_fieldOfView();
        /*0x3d73c44*/ void set_fieldOfView(float value);
        /*0x3d73d18*/ UnityEngine.RenderingPath get_renderingPath();
        /*0x3d73dcc*/ void set_renderingPath(UnityEngine.RenderingPath value);
        /*0x3d73e90*/ UnityEngine.RenderingPath get_actualRenderingPath();
        /*0x3d73f44*/ void Reset();
        /*0x3d73ff8*/ bool get_allowHDR();
        /*0x3d740ac*/ void set_allowHDR(bool value);
        /*0x3d74170*/ bool get_allowMSAA();
        /*0x3d74224*/ void set_allowMSAA(bool value);
        /*0x3d742e8*/ bool get_allowDynamicResolution();
        /*0x3d7439c*/ void set_allowDynamicResolution(bool value);
        /*0x3d74460*/ bool get_forceIntoRenderTexture();
        /*0x3d74514*/ void set_forceIntoRenderTexture(bool value);
        /*0x3d745d8*/ float get_orthographicSize();
        /*0x3d7468c*/ void set_orthographicSize(float value);
        /*0x3d74760*/ bool get_orthographic();
        /*0x3d74814*/ void set_orthographic(bool value);
        /*0x3d748d8*/ UnityEngine.Rendering.OpaqueSortMode get_opaqueSortMode();
        /*0x3d7498c*/ void set_opaqueSortMode(UnityEngine.Rendering.OpaqueSortMode value);
        /*0x3d74a50*/ UnityEngine.TransparencySortMode get_transparencySortMode();
        /*0x3d74b04*/ void set_transparencySortMode(UnityEngine.TransparencySortMode value);
        /*0x3d74bc8*/ UnityEngine.Vector3 get_transparencySortAxis();
        /*0x3d74ca4*/ void set_transparencySortAxis(UnityEngine.Vector3 value);
        /*0x3d74d78*/ void ResetTransparencySortSettings();
        /*0x3d74e2c*/ float get_depth();
        /*0x3d74ee0*/ void set_depth(float value);
        /*0x3d74fb4*/ float get_aspect();
        /*0x3d75068*/ void set_aspect(float value);
        /*0x3d7513c*/ void ResetAspect();
        /*0x3d751f0*/ UnityEngine.Vector3 get_velocity();
        /*0x3d752cc*/ int get_cullingMask();
        /*0x3d75380*/ void set_cullingMask(int value);
        /*0x3d75444*/ int get_eventMask();
        /*0x3d754f8*/ void set_eventMask(int value);
        /*0x3d755bc*/ bool get_layerCullSpherical();
        /*0x3d75638*/ void set_layerCullSpherical(bool value);
        /*0x3d755c0*/ bool get_layerCullSphericalInternal();
        /*0x3d7582c*/ void set_layerCullSphericalInternal(bool value);
        /*0x3d7592c*/ UnityEngine.CameraType get_cameraType();
        /*0x3d759e0*/ void set_cameraType(UnityEngine.CameraType value);
        /*0x3d75aa4*/ UnityEngine.Material get_skyboxMaterial();
        /*0x3d75b74*/ ulong get_overrideSceneCullingMask();
        /*0x3d75c28*/ void set_overrideSceneCullingMask(ulong value);
        /*0x3d75cec*/ ulong get_sceneCullingMask();
        /*0x3d75da0*/ bool get_useInteractiveLightBakingData();
        /*0x3d75e54*/ void set_useInteractiveLightBakingData(bool value);
        /*0x3d75f18*/ float[] GetLayerCullDistances();
        /*0x3d760b0*/ void SetLayerCullDistances(float[] d);
        /*0x3d7621c*/ float[] get_layerCullDistances();
        /*0x3d76220*/ void set_layerCullDistances(float[] value);
        /*0x3d76290*/ bool get_useOcclusionCulling();
        /*0x3d76344*/ void set_useOcclusionCulling(bool value);
        /*0x3d76408*/ UnityEngine.Matrix4x4 get_cullingMatrix();
        /*0x3d764f4*/ void set_cullingMatrix(UnityEngine.Matrix4x4 value);
        /*0x3d765b8*/ void ResetCullingMatrix();
        /*0x3d7666c*/ UnityEngine.Color get_backgroundColor();
        /*0x3d76744*/ void set_backgroundColor(UnityEngine.Color value);
        /*0x3d76818*/ UnityEngine.CameraClearFlags get_clearFlags();
        /*0x3d768cc*/ void set_clearFlags(UnityEngine.CameraClearFlags value);
        /*0x3d76990*/ UnityEngine.DepthTextureMode get_depthTextureMode();
        /*0x3d76a44*/ void set_depthTextureMode(UnityEngine.DepthTextureMode value);
        /*0x3d76b08*/ bool get_clearStencilAfterLightingPass();
        /*0x3d76bbc*/ void set_clearStencilAfterLightingPass(bool value);
        /*0x3d76c80*/ void SetReplacementShader(UnityEngine.Shader shader, string replacementTag);
        /*0x3d76eb0*/ void ResetReplacementShader();
        /*0x3d76f64*/ UnityEngine.Camera.ProjectionMatrixMode get_projectionMatrixMode();
        /*0x3d77018*/ bool get_usePhysicalProperties();
        /*0x3d770cc*/ void set_usePhysicalProperties(bool value);
        /*0x3d77190*/ int get_iso();
        /*0x3d77244*/ void set_iso(int value);
        /*0x3d77308*/ float get_shutterSpeed();
        /*0x3d773bc*/ void set_shutterSpeed(float value);
        /*0x3d77490*/ float get_aperture();
        /*0x3d77544*/ void set_aperture(float value);
        /*0x3d77618*/ float get_focusDistance();
        /*0x3d776cc*/ void set_focusDistance(float value);
        /*0x3d777a0*/ float get_focalLength();
        /*0x3d77854*/ void set_focalLength(float value);
        /*0x3d77928*/ int get_bladeCount();
        /*0x3d779dc*/ void set_bladeCount(int value);
        /*0x3d77aa0*/ UnityEngine.Vector2 get_curvature();
        /*0x3d77b6c*/ void set_curvature(UnityEngine.Vector2 value);
        /*0x3d77c34*/ float get_barrelClipping();
        /*0x3d77ce8*/ void set_barrelClipping(float value);
        /*0x3d77dbc*/ float get_anamorphism();
        /*0x3d77e70*/ void set_anamorphism(float value);
        /*0x3d77f44*/ UnityEngine.Vector2 get_sensorSize();
        /*0x3d78010*/ void set_sensorSize(UnityEngine.Vector2 value);
        /*0x3d780d8*/ UnityEngine.Vector2 get_lensShift();
        /*0x3d781a4*/ void set_lensShift(UnityEngine.Vector2 value);
        /*0x3d7826c*/ UnityEngine.Camera.GateFitMode get_gateFit();
        /*0x3d78320*/ void set_gateFit(UnityEngine.Camera.GateFitMode value);
        /*0x3d783e4*/ float GetGateFittedFieldOfView();
        /*0x3d78498*/ UnityEngine.Vector2 GetGateFittedLensShift();
        /*0x3d78564*/ UnityEngine.Vector3 GetLocalSpaceAim();
        /*0x3d78640*/ UnityEngine.Rect get_rect();
        /*0x3d78718*/ void set_rect(UnityEngine.Rect value);
        /*0x3d787ec*/ UnityEngine.Rect get_pixelRect();
        /*0x3d788c4*/ void set_pixelRect(UnityEngine.Rect value);
        /*0x3d78998*/ int get_pixelWidth();
        /*0x3d78a4c*/ int get_pixelHeight();
        /*0x3d78b00*/ int get_scaledPixelWidth();
        /*0x3d78bb4*/ int get_scaledPixelHeight();
        /*0x3d78c68*/ UnityEngine.RenderTexture get_targetTexture();
        /*0x3d78d38*/ void set_targetTexture(UnityEngine.RenderTexture value);
        /*0x3d78e30*/ UnityEngine.RenderTexture get_activeTexture();
        /*0x3d78f00*/ int get_targetDisplay();
        /*0x3d78fb4*/ void set_targetDisplay(int value);
        /*0x3d79078*/ void SetTargetBuffersImpl(UnityEngine.RenderBuffer color, UnityEngine.RenderBuffer depth);
        /*0x3d79160*/ void SetTargetBuffers(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer);
        /*0x3d79164*/ void SetTargetBuffersMRTImpl(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer depth);
        /*0x3d792c0*/ void SetTargetBuffers(UnityEngine.RenderBuffer[] colorBuffer, UnityEngine.RenderBuffer depthBuffer);
        /*0x3d792c4*/ string[] GetCameraBufferWarnings();
        /*0x3d79378*/ UnityEngine.Matrix4x4 get_cameraToWorldMatrix();
        /*0x3d79464*/ UnityEngine.Matrix4x4 get_worldToCameraMatrix();
        /*0x3d79550*/ void set_worldToCameraMatrix(UnityEngine.Matrix4x4 value);
        /*0x3d79614*/ UnityEngine.Matrix4x4 get_projectionMatrix();
        /*0x3d79700*/ void set_projectionMatrix(UnityEngine.Matrix4x4 value);
        /*0x3d797c4*/ UnityEngine.Matrix4x4 get_nonJitteredProjectionMatrix();
        /*0x3d798b0*/ void set_nonJitteredProjectionMatrix(UnityEngine.Matrix4x4 value);
        /*0x3d79974*/ bool get_useJitteredProjectionMatrixForTransparentRendering();
        /*0x3d79a28*/ void set_useJitteredProjectionMatrixForTransparentRendering(bool value);
        /*0x3d79aec*/ UnityEngine.Matrix4x4 get_previousViewProjectionMatrix();
        /*0x3d79bd8*/ void ResetWorldToCameraMatrix();
        /*0x3d79c8c*/ void ResetProjectionMatrix();
        /*0x3d79d40*/ UnityEngine.Matrix4x4 CalculateObliqueMatrix(UnityEngine.Vector4 clipPlane);
        /*0x3d79e48*/ UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x3d79f50*/ UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x3d7a058*/ UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x3d7a160*/ UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x3d7a268*/ UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position);
        /*0x3d7a270*/ UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position);
        /*0x3d7a278*/ UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position);
        /*0x3d7a280*/ UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position);
        /*0x3d7a288*/ UnityEngine.Vector3 ScreenToViewportPoint(UnityEngine.Vector3 position);
        /*0x3d7a380*/ UnityEngine.Vector3 ViewportToScreenPoint(UnityEngine.Vector3 position);
        /*0x3d7a478*/ UnityEngine.Vector2 GetFrustumPlaneSizeAt(float distance);
        /*0x3d7a56c*/ UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x3d7a680*/ UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x3d7a6b0*/ UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3 pos);
        /*0x3d7a6e4*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x3d7a7f8*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x3d7a828*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos);
        /*0x3d7a85c*/ void CalculateFrustumCornersInternal(UnityEngine.Rect viewport, float z, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3[] outCorners);
        /*0x3d7aa38*/ void CalculateFrustumCorners(UnityEngine.Rect viewport, float z, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3[] outCorners);
        /*0x3d7ae28*/ UnityEngine.SceneManagement.Scene get_scene();
        /*0x3d7aef4*/ void set_scene(UnityEngine.SceneManagement.Scene value);
        /*0x3d7afbc*/ bool get_stereoEnabled();
        /*0x3d7b070*/ float get_stereoSeparation();
        /*0x3d7b124*/ void set_stereoSeparation(float value);
        /*0x3d7b1f8*/ float get_stereoConvergence();
        /*0x3d7b2ac*/ void set_stereoConvergence(float value);
        /*0x3d7b380*/ bool get_areVRStereoViewMatricesWithinSingleCullTolerance();
        /*0x3d7b434*/ UnityEngine.StereoTargetEyeMask get_stereoTargetEye();
        /*0x3d7b4b0*/ void set_stereoTargetEye(UnityEngine.StereoTargetEyeMask value);
        /*0x3d7b438*/ UnityEngine.StereoTargetEyeMask get_stereoTargetEyeInternal();
        /*0x3d7b59c*/ void set_stereoTargetEyeInternal(UnityEngine.StereoTargetEyeMask value);
        /*0x3d7b69c*/ UnityEngine.Camera.MonoOrStereoscopicEye get_stereoActiveEye();
        /*0x3d7b750*/ UnityEngine.Matrix4x4 GetStereoNonJitteredProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye);
        /*0x3d7b85c*/ UnityEngine.Matrix4x4 GetStereoViewMatrix(UnityEngine.Camera.StereoscopicEye eye);
        /*0x3d7b968*/ void CopyStereoDeviceProjectionMatrixToNonJittered(UnityEngine.Camera.StereoscopicEye eye);
        /*0x3d7ba2c*/ UnityEngine.Matrix4x4 GetStereoProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye);
        /*0x3d7bb38*/ void SetStereoProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4 matrix);
        /*0x3d7bc1c*/ void ResetStereoProjectionMatrices();
        /*0x3d7bcd0*/ void SetStereoViewMatrix(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4 matrix);
        /*0x3d7bdb4*/ void ResetStereoViewMatrices();
        /*0x3d7c098*/ bool RenderToCubemapImpl(UnityEngine.Texture tex, int faceMask);
        /*0x3d7c1a8*/ bool RenderToCubemap(UnityEngine.Cubemap cubemap, int faceMask);
        /*0x3d7c1ac*/ bool RenderToCubemap(UnityEngine.Cubemap cubemap);
        /*0x3d7c1b4*/ bool RenderToCubemap(UnityEngine.RenderTexture cubemap, int faceMask);
        /*0x3d7c1b8*/ bool RenderToCubemap(UnityEngine.RenderTexture cubemap);
        /*0x3d7c1c0*/ int GetFilterMode();
        /*0x3d7c274*/ UnityEngine.Camera.SceneViewFilterMode get_sceneViewFilterMode();
        /*0x3d7c278*/ bool get_renderCloudsInSceneView();
        /*0x3d7c32c*/ void set_renderCloudsInSceneView(bool value);
        /*0x3d7c3f0*/ bool RenderToCubemapEyeImpl(UnityEngine.RenderTexture cubemap, int faceMask, UnityEngine.Camera.MonoOrStereoscopicEye stereoEye);
        /*0x3d7c518*/ bool RenderToCubemap(UnityEngine.RenderTexture cubemap, int faceMask, UnityEngine.Camera.MonoOrStereoscopicEye stereoEye);
        /*0x3d7c51c*/ void Render();
        /*0x3d7c5d0*/ void RenderWithShader(UnityEngine.Shader shader, string replacementTag);
        /*0x3d7c800*/ void RenderDontRestore();
        /*0x3d7c8b4*/ void SubmitRenderRequests(System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests);
        /*0x1ffc854*/ void SubmitRenderRequest<RequestData>(RequestData renderRequest);
        /*0x3d7ca00*/ void SubmitRenderRequestsInternal(object requests);
        /*0x3d7cac4*/ UnityEngine.Object[] SubmitBuiltInObjectIDRenderRequest(UnityEngine.RenderTexture target, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
        /*0x3d7ccbc*/ void CopyFrom(UnityEngine.Camera other);
        /*0x3d7cdb4*/ int get_commandBufferCount();
        /*0x3d7ce68*/ void RemoveCommandBuffersImpl(UnityEngine.Rendering.CameraEvent evt);
        /*0x3d7cf2c*/ void RemoveAllCommandBuffersImpl();
        /*0x3d7cfe0*/ void RemoveCommandBuffers(UnityEngine.Rendering.CameraEvent evt);
        /*0x3d7d0dc*/ void RemoveAllCommandBuffers();
        /*0x3d7d1c4*/ void AddCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x3d7d300*/ void AddCommandBufferAsyncImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType);
        /*0x3d7d44c*/ void RemoveCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x3d7d588*/ void AddCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x3d7d77c*/ void AddCommandBufferAsync(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType);
        /*0x3d7d978*/ void RemoveCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x3d7db6c*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.CameraEvent evt);
        /*0x3d7dc50*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffersImpl(UnityEngine.Rendering.CameraEvent evt);
        /*0x3d7de74*/ void OnlyUsedForTesting1();
        /*0x3d7de78*/ void OnlyUsedForTesting2();
        /*0x3d7de7c*/ bool TryGetCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters);
        /*0x3d7df30*/ bool TryGetCullingParameters(bool stereoAware, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters);

        enum ProjectionMatrixMode
        {
            Explicit = 0,
            Implicit = 1,
            PhysicalPropertiesBased = 2,
        }

        enum GateFitMode
        {
            Vertical = 1,
            Horizontal = 2,
            Fill = 3,
            Overscan = 4,
            None = 0,
        }

        struct GateFitParameters
        {
            /*0x10*/ UnityEngine.Camera.GateFitMode <mode>k__BackingField;
            /*0x14*/ float <aspect>k__BackingField;

            /*0x3d7df94*/ UnityEngine.Camera.GateFitMode get_mode();
            /*0x3d7df9c*/ float get_aspect();
        }

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

        enum RenderRequestMode
        {
            None = 0,
            ObjectId = 1,
            Depth = 2,
            VertexNormal = 3,
            WorldPosition = 4,
            EntityId = 5,
            BaseColor = 6,
            SpecularColor = 7,
            Metallic = 8,
            Emission = 9,
            Normal = 10,
            Smoothness = 11,
            Occlusion = 12,
            DiffuseColor = 13,
        }

        enum RenderRequestOutputSpace
        {
            ScreenSpace = -1,
            UV0 = 0,
            UV1 = 1,
            UV2 = 2,
            UV3 = 3,
            UV4 = 4,
            UV5 = 5,
            UV6 = 6,
            UV7 = 7,
            UV8 = 8,
        }

        struct RenderRequest
        {
            /*0x10*/ UnityEngine.Camera.RenderRequestMode m_CameraRenderMode;
            /*0x18*/ UnityEngine.RenderTexture m_ResultRT;
            /*0x20*/ UnityEngine.Camera.RenderRequestOutputSpace m_OutputSpace;
        }

        class CameraCallback : System.MulticastDelegate
        {
            /*0x3d7dfa4*/ CameraCallback(object object, nint method);
            /*0x3d7e054*/ void Invoke(UnityEngine.Camera cam);
        }
    }

    struct BoundingSphere
    {
        /*0x10*/ UnityEngine.Vector3 position;
        /*0x1c*/ float radius;
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

        static /*0x3d7e838*/ void SendEvents(UnityEngine.CullingGroup cullingGroup, nint eventsPtr, int count);
        static /*0x3d7e0c4*/ nint Init(object scripting);
        static /*0x3d7e22c*/ void DisposeInternal_Injected(nint _unity_self);
        static /*0x3d7e328*/ void set_targetCamera_Injected(nint _unity_self, nint value);
        static /*0x3d7e3c4*/ void SetBoundingSpheres_Injected(nint _unity_self, UnityEngine.BoundingSphere[] array);
        static /*0x3d7e460*/ void SetBoundingSphereCount_Injected(nint _unity_self, int count);
        static /*0x3d7e5dc*/ int QueryIndices_Injected(nint _unity_self, bool visible, int distanceIndex, UnityEngine.CullingQueryOptions options, ref UnityEngine.Bindings.ManagedSpanWrapper result, int firstIndex);
        static /*0x3d7e744*/ void SetBoundingDistances_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper distances);
        static /*0x3d7e7f0*/ void SetDistanceReferencePoint_InternalVector3_Injected(nint _unity_self, ref UnityEngine.Vector3 point);
        static /*0x3d7e894*/ void FinalizerFailure_Injected(nint _unity_self);
        /*0x3d7e068*/ CullingGroup();
        /*0x3d7e100*/ void Finalize();
        /*0x3d7e1dc*/ void DisposeInternal();
        /*0x3d7e268*/ void Dispose();
        /*0x3d7e280*/ void set_targetCamera(UnityEngine.Camera value);
        /*0x3d7e36c*/ void SetBoundingSpheres(UnityEngine.BoundingSphere[] array);
        /*0x3d7e408*/ void SetBoundingSphereCount(int count);
        /*0x3d7e4a4*/ int QueryIndices(bool visible, int[] result, int firstIndex);
        /*0x3d7e4b8*/ int QueryIndices(bool visible, int distanceIndex, UnityEngine.CullingQueryOptions options, int[] result, int firstIndex);
        /*0x3d7e650*/ void SetBoundingDistances(float[] distances);
        /*0x3d7e788*/ void SetDistanceReferencePoint_InternalVector3(UnityEngine.Vector3 point);
        /*0x3d7e834*/ void SetDistanceReferencePoint(UnityEngine.Vector3 point);
        /*0x3d7e18c*/ void FinalizerFailure();

        class StateChanged : System.MulticastDelegate
        {
            /*0x3d7e8d0*/ StateChanged(object object, nint method);
            /*0x3d7e970*/ void Invoke(UnityEngine.CullingGroupEvent sphere);
        }

        class BindingsMarshaller
        {
            static /*0x3d7e984*/ nint ConvertToNative(UnityEngine.CullingGroup cullingGroup);
        }
    }

    class ReflectionProbe : UnityEngine.Behaviour
    {
        static /*0x0*/ System.Action<UnityEngine.ReflectionProbe, UnityEngine.ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged;
        static /*0x8*/ System.Collections.Generic.Dictionary<int, System.Action<UnityEngine.Texture>> registeredDefaultReflectionSetActions;
        static /*0x10*/ System.Collections.Generic.List<System.Action<UnityEngine.Texture>> registeredDefaultReflectionTextureActions;

        static /*0x3d7ee50*/ ReflectionProbe();
        static /*0x3d7ea70*/ UnityEngine.Vector4 get_defaultTextureHDRDecodeValues();
        static /*0x3d7eb34*/ UnityEngine.Texture get_defaultTexture();
        static /*0x3d7ebe0*/ void CallReflectionProbeEvent(UnityEngine.ReflectionProbe probe, UnityEngine.ReflectionProbe.ReflectionProbeEvent probeEvent);
        static /*0x3d7ec68*/ void CallSetDefaultReflection(UnityEngine.Texture defaultReflectionCubemap);
        static /*0x3d7ea34*/ UnityEngine.Rendering.ReflectionProbeRefreshMode get_refreshMode_Injected(nint _unity_self);
        static /*0x3d7eaf8*/ void get_defaultTextureHDRDecodeValues_Injected(ref UnityEngine.Vector4 ret);
        static /*0x3d7ebb8*/ nint get_defaultTexture_Injected();
        /*0x3d7e998*/ UnityEngine.Rendering.ReflectionProbeRefreshMode get_refreshMode();

        enum ReflectionProbeEvent
        {
            ReflectionProbeAdded = 0,
            ReflectionProbeRemoved = 1,
        }
    }

    class DebugLogHandler : UnityEngine.ILogHandler
    {
        static /*0x3d7ef38*/ void Internal_Log(UnityEngine.LogType level, UnityEngine.LogOption options, string msg, UnityEngine.Object obj);
        static /*0x3d7f148*/ void Internal_LogException(System.Exception ex, UnityEngine.Object obj);
        static /*0x3d7f0ec*/ void Internal_Log_Injected(UnityEngine.LogType level, UnityEngine.LogOption options, ref UnityEngine.Bindings.ManagedSpanWrapper msg, nint obj);
        static /*0x3d7f1d4*/ void Internal_LogException_Injected(System.Exception ex, nint obj);
        /*0x3d7f2f0*/ DebugLogHandler();
        /*0x3d7f218*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
        /*0x3d7f254*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.LogOption logOptions, UnityEngine.Object context, string format, object[] args);
        /*0x3d7f294*/ void LogException(System.Exception exception, UnityEngine.Object context);
    }

    class Debug
    {
        static /*0x0*/ UnityEngine.ILogger s_DefaultLogger;
        static /*0x8*/ UnityEngine.ILogger s_Logger;

        static /*0x3d80fc8*/ Debug();
        static /*0x3d7f2f8*/ UnityEngine.ILogger get_unityLogger();
        static /*0x3d7f350*/ void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color);
        static /*0x3d7f430*/ void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, float duration, bool depthTest);
        static /*0x3d7f550*/ void Break();
        static /*0x3d7f578*/ int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder);
        static /*0x3d7f77c*/ void Log(object message);
        static /*0x3d7f884*/ void Log(object message, UnityEngine.Object context);
        static /*0x3d7f99c*/ void LogFormat(string format, object[] args);
        static /*0x3d7fab4*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.LogOption logOptions, UnityEngine.Object context, string format, object[] args);
        static /*0x3d7fdc8*/ void LogError(object message);
        static /*0x3d7fed0*/ void LogError(object message, UnityEngine.Object context);
        static /*0x3d7ffe8*/ void LogErrorFormat(string format, object[] args);
        static /*0x3d80100*/ void LogErrorFormat(UnityEngine.Object context, string format, object[] args);
        static /*0x3d8021c*/ void set_developerConsoleEnabled(bool value);
        static /*0x3d80258*/ void set_developerConsoleVisible(bool value);
        static /*0x3d71628*/ void LogException(System.Exception exception);
        static /*0x3d69da4*/ void LogException(System.Exception exception, UnityEngine.Object context);
        static /*0x3d75724*/ void LogWarning(object message);
        static /*0x3d80294*/ void LogWarning(object message, UnityEngine.Object context);
        static /*0x3d803ac*/ void LogWarningFormat(string format, object[] args);
        static /*0x3d804c4*/ void LogWarningFormat(UnityEngine.Object context, string format, object[] args);
        static /*0x3d805e0*/ void Assert(bool condition);
        static /*0x3d80710*/ void Assert(bool condition, string message);
        static /*0x3d8082c*/ void LogAssertion(object message);
        static /*0x3d80934*/ void LogAssertionFormat(string format, object[] args);
        static /*0x3d80a4c*/ bool get_isDebugBuild();
        static /*0x3d80a74*/ bool CallOverridenDebugHandler(System.Exception exception, UnityEngine.Object obj);
        static /*0x3d80da4*/ bool IsLoggingEnabled();
        static /*0x3d7f4e4*/ void DrawLine_Injected(ref UnityEngine.Vector3 start, ref UnityEngine.Vector3 end, ref UnityEngine.Color color, float duration, bool depthTest);
        static /*0x3d7f728*/ int ExtractStackTraceNoAlloc_Injected(byte* buffer, int bufferMax, ref UnityEngine.Bindings.ManagedSpanWrapper projectFolder);
    }

    struct ExposedReference<T>
    {
        /*0x0*/ UnityEngine.PropertyName exposedName;
        /*0x0*/ UnityEngine.Object defaultValue;

        /*0x1ffc854*/ T Resolve(UnityEngine.IExposedPropertyTable resolver);
    }

    interface IExposedPropertyTable
    {
        UnityEngine.Object GetReferenceValue(UnityEngine.PropertyName id, ref bool idValid);
    }

    class ExpressionEvaluator
    {
        static /*0x0*/ UnityEngine.ExpressionEvaluator.PcgRandom s_Random;
        static /*0x10*/ System.Collections.Generic.Dictionary<string, UnityEngine.ExpressionEvaluator.Operator> s_Operators;

        static /*0x3d82700*/ ExpressionEvaluator();
        static /*0x1f319c4*/ bool Evaluate<T>(string expression, ref T value, ref UnityEngine.ExpressionEvaluator.Expression delayed);
        static /*0x1ffc854*/ bool EvaluateTokens<T>(string[] tokens, ref T value, int index, int count);
        static /*0x3d810b8*/ bool EvaluateDouble(string[] tokens, ref double value, int index, int count);
        static /*0x3d81ac4*/ string[] InfixToRPN(string[] tokens);
        static /*0x3d81f68*/ bool NeedToPop(System.Collections.Generic.Stack<string> operatorStack, UnityEngine.ExpressionEvaluator.Operator newOperator);
        static /*0x3d8205c*/ string[] ExpressionToTokens(string expression, ref bool hasVariables);
        static /*0x3d81664*/ bool IsCommand(string token);
        static /*0x3d81a60*/ bool IsVariable(string token);
        static /*0x3d81efc*/ bool IsDelayedFunction(string token);
        static /*0x3d81544*/ bool IsOperator(string token);
        static /*0x3d815c4*/ UnityEngine.ExpressionEvaluator.Operator TokenToOperator(string token);
        static /*0x3d8238c*/ string PreFormatExpression(string expression);
        static /*0x3d82544*/ string[] FixUnaryOperators(string[] tokens);
        static /*0x3d81710*/ double EvaluateOp(double[] values, UnityEngine.ExpressionEvaluator.Op op, int index, int count);
        static /*0x1f318fc*/ bool TryParse<T>(string expression, ref T result);

        class Expression
        {
            /*0x10*/ string[] rpnTokens;
            /*0x18*/ bool hasVariables;

            /*0x3d82cdc*/ Expression(string expression);
            bool Evaluate<T>(ref T value, int index, int count);
            /*0x3d82d68*/ bool Equals(object obj);
            /*0x3d82e0c*/ int GetHashCode();
            /*0x3d82e28*/ string ToString();
        }

        struct PcgRandom
        {
            /*0x10*/ ulong increment;
            /*0x18*/ ulong state;

            static /*0x3d82eac*/ uint RotateRight(uint v, int rot);
            static /*0x3d82e94*/ uint XshRr(ulong s);
            /*0x3d82c74*/ PcgRandom(ulong state, ulong sequence);
            /*0x3d826c8*/ uint GetUInt();
            /*0x3d82e74*/ void Step();
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

            /*0x3d82c9c*/ Operator(UnityEngine.ExpressionEvaluator.Op op, int precedence, int inputs, UnityEngine.ExpressionEvaluator.Associativity associativity);
        }

        class <>c
        {
            static /*0x0*/ UnityEngine.ExpressionEvaluator.<> <>9;
            static /*0x8*/ System.Func<string, bool> <>9__14_0;

            static /*0x3d82eb4*/ <>c();
            /*0x3d82f1c*/ <>c();
            /*0x3d82f24*/ bool <ExpressionToTokens>b__14_0(string f);
        }
    }

    enum CompressionType
    {
        None = 0,
        Lzma = 1,
        Lz4 = 2,
        Lz4HC = 3,
    }

    enum CompressionLevel
    {
        None = 0,
        Fastest = 1,
        Fast = 2,
        Normal = 3,
        High = 4,
        Maximum = 5,
    }

    struct BuildCompression
    {
        static /*0x0*/ UnityEngine.BuildCompression Uncompressed;
        static /*0xc*/ UnityEngine.BuildCompression LZ4;
        static /*0x18*/ UnityEngine.BuildCompression LZMA;
        static /*0x24*/ UnityEngine.BuildCompression UncompressedRuntime;
        static /*0x30*/ UnityEngine.BuildCompression LZ4Runtime;
        /*0x10*/ UnityEngine.CompressionType _compression;
        /*0x14*/ UnityEngine.CompressionLevel _level;
        /*0x18*/ uint _blockSize;

        static /*0x3d83038*/ BuildCompression();
        /*0x3d82fbc*/ BuildCompression(UnityEngine.CompressionType in_compression, UnityEngine.CompressionLevel in_level, uint in_blockSize);
        /*0x3d82fa4*/ void set_compression(UnityEngine.CompressionType value);
        /*0x3d82fac*/ void set_level(UnityEngine.CompressionLevel value);
        /*0x3d82fb4*/ void set_blockSize(uint value);
    }

    class LightingSettings : UnityEngine.Object
    {
        /*0x3d83160*/ void LightingSettingsDontStripMe();
    }

    struct Bounds : System.IEquatable<UnityEngine.Bounds>, System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3 m_Center;
        /*0x1c*/ UnityEngine.Vector3 m_Extents;

        static /*0x3d834b8*/ bool op_Equality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs);
        static /*0x3d8352c*/ bool op_Inequality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs);
        static /*0x3d839f8*/ bool Contains_Injected(ref UnityEngine.Bounds _unity_self, ref UnityEngine.Vector3 point);
        /*0x3d83164*/ Bounds(UnityEngine.Vector3 center, UnityEngine.Vector3 size);
        /*0x3d8318c*/ int GetHashCode();
        /*0x3d83254*/ bool Equals(object other);
        /*0x3d8331c*/ bool Equals(UnityEngine.Bounds other);
        /*0x3d83370*/ UnityEngine.Vector3 get_center();
        /*0x3d8337c*/ void set_center(UnityEngine.Vector3 value);
        /*0x3d83388*/ UnityEngine.Vector3 get_size();
        /*0x3d833a0*/ void set_size(UnityEngine.Vector3 value);
        /*0x3d833c0*/ UnityEngine.Vector3 get_extents();
        /*0x3d833cc*/ void set_extents(UnityEngine.Vector3 value);
        /*0x3d833d8*/ UnityEngine.Vector3 get_min();
        /*0x3d833f8*/ void set_min(UnityEngine.Vector3 value);
        /*0x3d83448*/ UnityEngine.Vector3 get_max();
        /*0x3d83468*/ void set_max(UnityEngine.Vector3 value);
        /*0x3d835a4*/ void SetMinMax(UnityEngine.Vector3 min, UnityEngine.Vector3 max);
        /*0x3d835dc*/ void Encapsulate(UnityEngine.Vector3 point);
        /*0x3d83654*/ void Encapsulate(UnityEngine.Bounds bounds);
        /*0x3d83750*/ bool Intersects(UnityEngine.Bounds bounds);
        /*0x3d837f0*/ string ToString();
        /*0x3d83800*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x3d839a0*/ bool Contains(UnityEngine.Vector3 point);
    }

    struct BoundsInt : System.IEquatable<UnityEngine.BoundsInt>, System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3Int m_Position;
        /*0x1c*/ UnityEngine.Vector3Int m_Size;

        /*0x3d83cb8*/ BoundsInt(UnityEngine.Vector3Int position, UnityEngine.Vector3Int size);
        /*0x3d83a3c*/ UnityEngine.Vector3Int get_min();
        /*0x3d83b54*/ int get_xMin();
        /*0x3d83bb8*/ int get_yMin();
        /*0x3d83c1c*/ int get_zMin();
        /*0x3d83c80*/ UnityEngine.Vector3Int get_position();
        /*0x3d83c90*/ void set_position(UnityEngine.Vector3Int value);
        /*0x3d83c9c*/ UnityEngine.Vector3Int get_size();
        /*0x3d83cac*/ void set_size(UnityEngine.Vector3Int value);
        /*0x3d83ccc*/ string ToString();
        /*0x3d83cdc*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x3d83e50*/ bool Equals(object other);
        /*0x3d83f18*/ bool Equals(UnityEngine.BoundsInt other);
        /*0x3d83f84*/ int GetHashCode();
    }

    class GeometryUtility
    {
        static /*0x3d84058*/ void CalculateFrustumPlanes(UnityEngine.Camera camera, UnityEngine.Plane[] planes);
        static /*0x3d840d8*/ void CalculateFrustumPlanes(UnityEngine.Matrix4x4 worldToProjectionMatrix, UnityEngine.Plane[] planes);
        static /*0x3d842c8*/ bool TestPlanesAABB(UnityEngine.Plane[] planes, UnityEngine.Bounds bounds);
        static /*0x3d841b4*/ void Internal_ExtractPlanes(UnityEngine.Plane[] planes, UnityEngine.Matrix4x4 worldToProjectionMatrix);
        static /*0x3d843a4*/ bool TestPlanesAABB_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper planes, ref UnityEngine.Bounds bounds);
        static /*0x3d843e8*/ void Internal_ExtractPlanes_Injected(ref UnityEngine.Bindings.BlittableArrayWrapper planes, ref UnityEngine.Matrix4x4 worldToProjectionMatrix);
    }

    struct Plane : System.IFormattable
    {
        static int size = 16;
        /*0x10*/ UnityEngine.Vector3 m_Normal;
        /*0x1c*/ float m_Distance;

        /*0x3d84454*/ Plane(UnityEngine.Vector3 inNormal, UnityEngine.Vector3 inPoint);
        /*0x3d84564*/ Plane(UnityEngine.Vector3 inNormal, float d);
        /*0x3d8442c*/ UnityEngine.Vector3 get_normal();
        /*0x3d84438*/ void set_normal(UnityEngine.Vector3 value);
        /*0x3d84444*/ float get_distance();
        /*0x3d8444c*/ void set_distance(float value);
        /*0x3d84658*/ UnityEngine.Vector3 ClosestPointOnPlane(UnityEngine.Vector3 point);
        /*0x3d84694*/ float GetDistanceToPoint(UnityEngine.Vector3 point);
        /*0x3d846b8*/ bool Raycast(UnityEngine.Ray ray, ref float enter);
        /*0x3d847b8*/ string ToString();
        /*0x3d847c8*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Ray : System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3 m_Origin;
        /*0x1c*/ UnityEngine.Vector3 m_Direction;

        /*0x3d84968*/ Ray(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        /*0x3d84a60*/ UnityEngine.Vector3 get_origin();
        /*0x3d84a6c*/ UnityEngine.Vector3 get_direction();
        /*0x3d84a78*/ UnityEngine.Vector3 GetPoint(float distance);
        /*0x3d84aa0*/ string ToString();
        /*0x3d84ab0*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Rect : System.IEquatable<UnityEngine.Rect>, System.IFormattable
    {
        /*0x10*/ float m_XMin;
        /*0x14*/ float m_YMin;
        /*0x18*/ float m_Width;
        /*0x1c*/ float m_Height;

        static /*0x3d84c74*/ UnityEngine.Rect get_zero();
        static /*0x3d84c88*/ UnityEngine.Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax);
        static /*0x3d84e80*/ UnityEngine.Rect OrderMinMax(UnityEngine.Rect rect);
        static /*0x3d84f88*/ bool op_Inequality(UnityEngine.Rect lhs, UnityEngine.Rect rhs);
        static /*0x3d84fb0*/ bool op_Equality(UnityEngine.Rect lhs, UnityEngine.Rect rhs);
        /*0x3d84c50*/ Rect(float x, float y, float width, float height);
        /*0x3d84c5c*/ Rect(UnityEngine.Vector2 position, UnityEngine.Vector2 size);
        /*0x3d84c68*/ Rect(UnityEngine.Rect source);
        /*0x3d84c94*/ float get_x();
        /*0x3d84c9c*/ void set_x(float value);
        /*0x3d84ca4*/ float get_y();
        /*0x3d84cac*/ void set_y(float value);
        /*0x3d84cb4*/ UnityEngine.Vector2 get_position();
        /*0x3d84cbc*/ void set_position(UnityEngine.Vector2 value);
        /*0x3d84cc4*/ UnityEngine.Vector2 get_center();
        /*0x3d84cdc*/ void set_center(UnityEngine.Vector2 value);
        /*0x3d84cf8*/ UnityEngine.Vector2 get_min();
        /*0x3d84d00*/ void set_min(UnityEngine.Vector2 value);
        /*0x3d84d1c*/ UnityEngine.Vector2 get_max();
        /*0x3d84d2c*/ void set_max(UnityEngine.Vector2 value);
        /*0x3d84d40*/ float get_width();
        /*0x3d84d48*/ void set_width(float value);
        /*0x3d84d50*/ float get_height();
        /*0x3d84d58*/ void set_height(float value);
        /*0x3d84d60*/ UnityEngine.Vector2 get_size();
        /*0x3d84d68*/ void set_size(UnityEngine.Vector2 value);
        /*0x3d84d70*/ float get_xMin();
        /*0x3d84d78*/ void set_xMin(float value);
        /*0x3d84d94*/ float get_yMin();
        /*0x3d84d9c*/ void set_yMin(float value);
        /*0x3d84db8*/ float get_xMax();
        /*0x3d84dc8*/ void set_xMax(float value);
        /*0x3d84dd8*/ float get_yMax();
        /*0x3d84de8*/ void set_yMax(float value);
        /*0x3d84df8*/ bool Contains(UnityEngine.Vector2 point);
        /*0x3d84e3c*/ bool Contains(UnityEngine.Vector3 point);
        /*0x3d84eac*/ bool Overlaps(UnityEngine.Rect other);
        /*0x3d84ef8*/ bool Overlaps(UnityEngine.Rect other, bool allowInverse);
        /*0x3d84fd8*/ int GetHashCode();
        /*0x3d85060*/ bool Equals(object other);
        /*0x3d8514c*/ bool Equals(UnityEngine.Rect other);
        /*0x3d851ec*/ string ToString();
        /*0x3d851f8*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct RectInt : System.IEquatable<UnityEngine.RectInt>, System.IFormattable
    {
        /*0x10*/ int m_XMin;
        /*0x14*/ int m_YMin;
        /*0x18*/ int m_Width;
        /*0x1c*/ int m_Height;

        /*0x3d86384*/ RectInt(int xMin, int yMin, int width, int height);
        /*0x3d861b4*/ int get_x();
        /*0x3d861bc*/ void set_x(int value);
        /*0x3d861c4*/ int get_y();
        /*0x3d861cc*/ void set_y(int value);
        /*0x3d861d4*/ int get_width();
        /*0x3d861dc*/ void set_width(int value);
        /*0x3d861e4*/ int get_height();
        /*0x3d861ec*/ void set_height(int value);
        /*0x3d861f4*/ int get_xMin();
        /*0x3d86258*/ int get_yMin();
        /*0x3d862bc*/ int get_xMax();
        /*0x3d86320*/ int get_yMax();
        /*0x3d86390*/ bool Overlaps(UnityEngine.RectInt other);
        /*0x3d86620*/ string ToString();
        /*0x3d86630*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x3d8686c*/ int GetHashCode();
        /*0x3d86900*/ bool Equals(object other);
        /*0x3d869a8*/ bool Equals(UnityEngine.RectInt other);
    }

    class RectOffset : System.IFormattable
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ object m_SourceStyle;

        static /*0x3d86a30*/ nint InternalCreate();
        static /*0x3d87134*/ void InternalDestroy(nint ptr);
        static /*0x3d87170*/ int get_left_Injected(nint _unity_self);
        static /*0x3d871ac*/ void set_left_Injected(nint _unity_self, int value);
        static /*0x3d871f0*/ int get_right_Injected(nint _unity_self);
        static /*0x3d8722c*/ void set_right_Injected(nint _unity_self, int value);
        static /*0x3d87270*/ int get_top_Injected(nint _unity_self);
        static /*0x3d872ac*/ void set_top_Injected(nint _unity_self, int value);
        static /*0x3d872f0*/ int get_bottom_Injected(nint _unity_self);
        static /*0x3d8732c*/ void set_bottom_Injected(nint _unity_self, int value);
        static /*0x3d873c0*/ int get_horizontal_Injected(nint _unity_self);
        static /*0x3d8744c*/ int get_vertical_Injected(nint _unity_self);
        static /*0x3d87500*/ void Remove_Injected(nint _unity_self, ref UnityEngine.Rect rect, ref UnityEngine.Rect ret);
        /*0x3d869ec*/ RectOffset();
        /*0x3d86a58*/ RectOffset(object sourceStyle, nint source);
        /*0x3d86ba8*/ RectOffset(int left, int right, int top, int bottom);
        /*0x3d86a94*/ void Finalize();
        /*0x3d86d98*/ string ToString();
        /*0x3d86da8*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x3d86b5c*/ void Destroy();
        /*0x3d86ff4*/ int get_left();
        /*0x3d86c38*/ void set_left(int value);
        /*0x3d87044*/ int get_right();
        /*0x3d86c90*/ void set_right(int value);
        /*0x3d87094*/ int get_top();
        /*0x3d86ce8*/ void set_top(int value);
        /*0x3d870e4*/ int get_bottom();
        /*0x3d86d40*/ void set_bottom(int value);
        /*0x3d87370*/ int get_horizontal();
        /*0x3d873fc*/ int get_vertical();
        /*0x3d87488*/ UnityEngine.Rect Remove(UnityEngine.Rect rect);

        class BindingsMarshaller
        {
            static /*0x3d87554*/ nint ConvertToNative(UnityEngine.RectOffset rectOffset);
        }
    }

    class Gizmos
    {
        static /*0x3d87568*/ void DrawLine(UnityEngine.Vector3 from, UnityEngine.Vector3 to);
        static /*0x3d875fc*/ void DrawWireSphere(UnityEngine.Vector3 center, float radius);
        static /*0x3d8769c*/ void DrawSphere(UnityEngine.Vector3 center, float radius);
        static /*0x3d8773c*/ void DrawIcon(UnityEngine.Vector3 center, string name, bool allowScaling);
        static /*0x3d87750*/ void DrawIcon(UnityEngine.Vector3 center, string name, bool allowScaling, UnityEngine.Color tint);
        static /*0x3d87934*/ void set_color(UnityEngine.Color value);
        static /*0x3d875b8*/ void DrawLine_Injected(ref UnityEngine.Vector3 from, ref UnityEngine.Vector3 to);
        static /*0x3d87650*/ void DrawWireSphere_Injected(ref UnityEngine.Vector3 center, float radius);
        static /*0x3d876f0*/ void DrawSphere_Injected(ref UnityEngine.Vector3 center, float radius);
        static /*0x3d878d8*/ void DrawIcon_Injected(ref UnityEngine.Vector3 center, ref UnityEngine.Bindings.ManagedSpanWrapper name, bool allowScaling, ref UnityEngine.Color tint);
        static /*0x3d87978*/ void set_color_Injected(ref UnityEngine.Color value);
    }

    class BeforeRenderOrderAttribute : System.Attribute
    {
        /*0x10*/ int <order>k__BackingField;

        /*0x3d879b4*/ int get_order();
    }

    class BeforeRenderHelper
    {
        static /*0x0*/ System.Collections.Generic.List<UnityEngine.BeforeRenderHelper.OrderBlock> s_OrderBlocks;

        static /*0x3d88364*/ BeforeRenderHelper();
        static /*0x3d879bc*/ int GetUpdateOrder(UnityEngine.Events.UnityAction callback);
        static /*0x3d87ac8*/ void RegisterCallback(UnityEngine.Events.UnityAction callback);
        static /*0x3d87e6c*/ void UnregisterCallback(UnityEngine.Events.UnityAction callback);
        static /*0x3d881ac*/ void Invoke();

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

        static /*0x3d883fc*/ void InvokeOnTextureLoaded_Internal(UnityEngine.CustomRenderTexture source);
        static /*0x3d88468*/ void InvokeOnTextureUnloaded_Internal(UnityEngine.CustomRenderTexture source);
    }

    class Display
    {
        static /*0x0*/ UnityEngine.Display[] displays;
        static /*0x8*/ UnityEngine.Display _mainDisplay;
        static /*0x10*/ int m_ActiveEditorGameViewTarget;
        static /*0x18*/ UnityEngine.Display.DisplaysUpdatedDelegate onDisplaysUpdated;
        /*0x10*/ nint nativeDisplay;

        static /*0x3d88c90*/ Display();
        static /*0x3d888e4*/ UnityEngine.Vector3 RelativeMouseAt(UnityEngine.Vector3 inputMouseCoordinates);
        static /*0x3d88a00*/ UnityEngine.Display get_main();
        static /*0x3d88a58*/ void RecreateDisplayList(nint[] nativeDisplay);
        static /*0x3d88bfc*/ void FireDisplaysUpdated();
        static /*0x3d88748*/ void GetSystemExtImpl(nint nativeDisplay, ref int w, ref int h);
        static /*0x3d885cc*/ void GetRenderingExtImpl(nint nativeDisplay, ref int w, ref int h);
        static /*0x3d889a4*/ int RelativeMouseAtImpl(int x, int y, ref int rx, ref int ry);
        static /*0x3d888a8*/ bool RequiresSrgbBlitToBackbufferImpl(nint nativeDisplay);
        /*0x3d884d4*/ Display();
        /*0x3d88510*/ Display(nint nativeDisplay);
        /*0x3d88538*/ int get_renderingWidth();
        /*0x3d88620*/ int get_renderingHeight();
        /*0x3d886b4*/ int get_systemWidth();
        /*0x3d8879c*/ int get_systemHeight();
        /*0x3d88830*/ bool get_requiresSrgbBlitToBackbuffer();

        class DisplaysUpdatedDelegate : System.MulticastDelegate
        {
            /*0x3d88dcc*/ DisplaysUpdatedDelegate(object object, nint method);
            /*0x3d88e68*/ void Invoke();
        }
    }

    struct LightProbesQuery : System.IDisposable
    {
        /*0x10*/ nint m_LightProbeContextWrapper;
        /*0x18*/ Unity.Collections.Allocator m_AllocatorLabel;

        static /*0x3d88ed0*/ nint Create();
        static /*0x3d88fe4*/ void Destroy(nint lightProbeContextWrapper);
        static /*0x3d89358*/ void CalculateInterpolatedLightAndOcclusionProbes(nint lightProbeContextWrapper, nint positions, nint tetrahedronIndices, nint lightProbes, nint occlusionProbes, int count);
        /*0x3d88e7c*/ LightProbesQuery(Unity.Collections.Allocator allocator);
        /*0x3d88ef8*/ void Dispose();
        /*0x3d89020*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
        /*0x3d89120*/ void CalculateInterpolatedLightAndOcclusionProbes(Unity.Collections.NativeArray<UnityEngine.Vector3> positions, Unity.Collections.NativeArray<int> tetrahedronIndices, Unity.Collections.NativeArray<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, Unity.Collections.NativeArray<UnityEngine.Vector4> occlusionProbes);

        struct LightProbesQueryDispose
        {
            /*0x10*/ nint m_LightProbeContextWrapper;

            /*0x3d893cc*/ void Dispose();
        }

        struct LightProbesQueryDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ UnityEngine.LightProbesQuery.LightProbesQueryDispose Data;

            /*0x3d8941c*/ void Execute();
        }
    }

    enum EnabledOrientation
    {
        kAutorotateToPortrait = 1,
        kAutorotateToPortraitUpsideDown = 2,
        kAutorotateToLandscapeLeft = 4,
        kAutorotateToLandscapeRight = 8,
    }

    struct RefreshRate : System.IEquatable<UnityEngine.RefreshRate>, System.IComparable<UnityEngine.RefreshRate>
    {
        /*0x10*/ uint numerator;
        /*0x14*/ uint denominator;

        /*0x3d89420*/ double get_value();
        /*0x3d89434*/ bool Equals(UnityEngine.RefreshRate other);
        /*0x3d89470*/ int CompareTo(UnityEngine.RefreshRate other);
        /*0x3d894c0*/ string ToString();
    }

    class Screen
    {
        static /*0x3d8955c*/ int get_width();
        static /*0x3d89584*/ int get_height();
        static /*0x3d895ac*/ float get_dpi();
        static /*0x3d895d4*/ UnityEngine.ScreenOrientation GetScreenOrientation();
        static /*0x3d895fc*/ UnityEngine.ScreenOrientation get_orientation();
        static /*0x3d89624*/ void set_sleepTimeout(int value);
        static /*0x3d89660*/ bool IsOrientationEnabled(UnityEngine.EnabledOrientation orient);
        static /*0x3d8969c*/ void SetOrientationEnabled(UnityEngine.EnabledOrientation orient, bool enabled);
        static /*0x3d896e0*/ bool get_autorotateToPortrait();
        static /*0x3d89710*/ void set_autorotateToPortrait(bool value);
        static /*0x3d89750*/ bool get_autorotateToPortraitUpsideDown();
        static /*0x3d89780*/ void set_autorotateToPortraitUpsideDown(bool value);
        static /*0x3d897c0*/ bool get_autorotateToLandscapeLeft();
        static /*0x3d897f0*/ void set_autorotateToLandscapeLeft(bool value);
        static /*0x3d89830*/ bool get_autorotateToLandscapeRight();
        static /*0x3d89860*/ void set_autorotateToLandscapeRight(bool value);
        static /*0x3d898a0*/ UnityEngine.Resolution get_currentResolution();
        static /*0x3d89920*/ bool get_fullScreen();
        static /*0x3d89948*/ UnityEngine.Rect get_safeArea();
        static /*0x3d899cc*/ void SetMSAASamples(int numSamples);
        static /*0x3d89a08*/ int GetMSAASamples();
        static /*0x3d89a30*/ int get_msaaSamples();
        static /*0x3d898e4*/ void get_currentResolution_Injected(ref UnityEngine.Resolution ret);
        static /*0x3d89990*/ void get_safeArea_Injected(ref UnityEngine.Rect ret);
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

        static /*0x3d8bc08*/ Graphics();
        static /*0x3d89a58*/ int Internal_GetMaxDrawMeshInstanceCount();
        static /*0x3d89a80*/ UnityEngine.Rendering.GraphicsTier get_activeTier();
        static /*0x3d89aa8*/ void set_activeTier(UnityEngine.Rendering.GraphicsTier value);
        static /*0x3d89ae4*/ bool GetPreserveFramebufferAlpha();
        static /*0x3d89b0c*/ bool get_preserveFramebufferAlpha();
        static /*0x3d89b74*/ UnityEngine.Rendering.OpenGLESVersion GetMinOpenGLESVersion();
        static /*0x3d89b9c*/ UnityEngine.Rendering.OpenGLESVersion get_minOpenGLESVersion();
        static /*0x3d89c04*/ void Internal_SetNullRT();
        static /*0x3d89c2c*/ void Internal_SetRTSimple(UnityEngine.RenderBuffer color, UnityEngine.RenderBuffer depth, int mip, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x3d89d40*/ void ClearRandomWriteTargets();
        static /*0x3d89d68*/ void CopyTexture_Slice(UnityEngine.Texture src, int srcElement, int srcMip, UnityEngine.Texture dst, int dstElement, int dstMip);
        static /*0x3d89ed4*/ void CopyTexture_Region(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, UnityEngine.Texture dst, int dstElement, int dstMip, int dstX, int dstY);
        static /*0x3d8a0c4*/ void Internal_DrawMesh(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int layer, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x3d8a364*/ void Internal_DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x3d8a6c4*/ void Internal_BlitMaterial5(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, int pass, bool setRT);
        static /*0x3d8a888*/ void Blit2(UnityEngine.Texture source, UnityEngine.RenderTexture dest);
        static /*0x3d8a9a8*/ void Blit4(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset);
        static /*0x3d8aafc*/ void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer buffer);
        static /*0x3d8abf8*/ void SetRenderTargetImpl(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, int mipLevel, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x3d8ac94*/ void SetRenderTargetImpl(UnityEngine.RenderTexture rt, int mipLevel, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x3d8adc0*/ void SetRenderTarget(UnityEngine.RenderTexture rt, int mipLevel, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x3d8ae3c*/ void CopyTexture(UnityEngine.Texture src, int srcElement, int srcMip, UnityEngine.Texture dst, int dstElement, int dstMip);
        static /*0x3d8aed0*/ void CopyTexture(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, UnityEngine.Texture dst, int dstElement, int dstMip, int dstX, int dstY);
        static /*0x3d8afe8*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int layer, UnityEngine.Camera camera, int submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x3d8b180*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x3d8b650*/ void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest);
        static /*0x3d8b6b4*/ void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset);
        static /*0x3d8b748*/ void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, int pass);
        static /*0x3d8b7c8*/ void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat);
        static /*0x3d8b838*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, int layer, UnityEngine.Camera camera);
        static /*0x3d8b998*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int layer, UnityEngine.Camera camera, int submeshIndex, UnityEngine.MaterialPropertyBlock properties);
        static /*0x3d8ba68*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, UnityEngine.Camera camera);
        static /*0x3d8bb3c*/ void SetRenderTarget(UnityEngine.RenderTexture rt);
        static /*0x3d8bb9c*/ void SetRenderTarget(UnityEngine.RenderTexture rt, int mipLevel);
        static /*0x3d89cd4*/ void Internal_SetRTSimple_Injected(ref UnityEngine.RenderBuffer color, ref UnityEngine.RenderBuffer depth, int mip, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x3d89e60*/ void CopyTexture_Slice_Injected(nint src, int srcElement, int srcMip, nint dst, int dstElement, int dstMip);
        static /*0x3d8a004*/ void CopyTexture_Region_Injected(nint src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, nint dst, int dstElement, int dstMip, int dstX, int dstY);
        static /*0x3d8a2a0*/ void Internal_DrawMesh_Injected(nint mesh, int submeshIndex, ref UnityEngine.Matrix4x4 matrix, nint material, int layer, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, nint probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume);
        static /*0x3d8a600*/ void Internal_DrawMeshInstanced_Injected(nint mesh, int submeshIndex, nint material, ref UnityEngine.Bindings.ManagedSpanWrapper matrices, int count, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume);
        static /*0x3d8a81c*/ void Internal_BlitMaterial5_Injected(nint source, nint dest, nint mat, int pass, bool setRT);
        static /*0x3d8a964*/ void Blit2_Injected(nint source, nint dest);
        static /*0x3d8aaa0*/ void Blit4_Injected(nint source, nint dest, ref UnityEngine.Vector2 scale, ref UnityEngine.Vector2 offset);
        static /*0x3d8abbc*/ void ExecuteCommandBuffer_Injected(nint buffer);
    }

    class GL
    {
        static /*0x3d8bcc8*/ void Vertex3(float x, float y, float z);
        static /*0x3d8bd18*/ void TexCoord3(float x, float y, float z);
        static /*0x3d8bd68*/ void TexCoord2(float x, float y);
        static /*0x3d8bdac*/ void ImmediateColor(float r, float g, float b, float a);
        static /*0x3d8be04*/ void Color(UnityEngine.Color c);
        static /*0x3d8be5c*/ bool get_wireframe();
        static /*0x3d8be84*/ void SetViewMatrix(UnityEngine.Matrix4x4 m);
        static /*0x3d8befc*/ void set_modelview(UnityEngine.Matrix4x4 value);
        static /*0x3d8bf48*/ void PushMatrix();
        static /*0x3d8bf70*/ void PopMatrix();
        static /*0x3d8bf98*/ void LoadOrtho();
        static /*0x3d8bfc0*/ void LoadProjectionMatrix(UnityEngine.Matrix4x4 mat);
        static /*0x3d8c038*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(UnityEngine.Matrix4x4 proj, bool renderIntoTexture);
        static /*0x3d8c108*/ void GLLoadPixelMatrixScript(float left, float right, float bottom, float top);
        static /*0x3d8c160*/ void LoadPixelMatrix(float left, float right, float bottom, float top);
        static /*0x3d8c1b8*/ void Begin(int mode);
        static /*0x3d8c1f4*/ void End();
        static /*0x3d8c21c*/ void GLClear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
        static /*0x3d8c2ec*/ void Clear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
        static /*0x3d8c2f0*/ void Clear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
        static /*0x3d8c2f8*/ void Viewport(UnityEngine.Rect pixelRect);
        static /*0x3d8bec0*/ void SetViewMatrix_Injected(ref UnityEngine.Matrix4x4 m);
        static /*0x3d8bffc*/ void LoadProjectionMatrix_Injected(ref UnityEngine.Matrix4x4 mat);
        static /*0x3d8c0b4*/ void GetGPUProjectionMatrix_Injected(ref UnityEngine.Matrix4x4 proj, bool renderIntoTexture, ref UnityEngine.Matrix4x4 ret);
        static /*0x3d8c288*/ void GLClear_Injected(bool clearDepth, bool clearColor, ref UnityEngine.Color backgroundColor, float depth);
        static /*0x3d8c33c*/ void Viewport_Injected(ref UnityEngine.Rect pixelRect);
    }

    class ScalableBufferManager
    {
        static /*0x3d8c378*/ float get_widthScaleFactor();
        static /*0x3d8c3a0*/ float get_heightScaleFactor();
        static /*0x3d8c3c8*/ void ResizeBuffers(float widthScale, float heightScale);
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
        static /*0x3d8c408*/ void CaptureFrameTimings();
        static /*0x3d8c430*/ uint GetLatestTimings(uint numFrames, UnityEngine.FrameTiming[] timings);
        static /*0x3d8c508*/ uint GetLatestTimings_Injected(uint numFrames, ref UnityEngine.Bindings.ManagedSpanWrapper timings);
    }

    class LightmapSettings : UnityEngine.Object
    {
    }

    class LightProbes : UnityEngine.Object
    {
        static /*0x0*/ System.Action lightProbesUpdated;
        static /*0x8*/ System.Action tetrahedralizationCompleted;
        static /*0x10*/ System.Action needsRetetrahedralization;

        static /*0x3d8c54c*/ void Internal_CallLightProbesUpdatedFunction();
        static /*0x3d8c5b0*/ void Internal_CallTetrahedralizationCompletedFunction();
        static /*0x3d8c614*/ void Internal_CallNeedsRetetrahedralizationFunction();
    }

    class HDROutputSettings
    {
        static /*0x0*/ UnityEngine.HDROutputSettings[] displays;
        static /*0x8*/ UnityEngine.HDROutputSettings _mainDisplay;
        /*0x10*/ int m_DisplayIndex;

        static /*0x3d8cf8c*/ HDROutputSettings();
        static /*0x3d8c694*/ UnityEngine.HDROutputSettings get_main();
        static /*0x3d8c764*/ bool GetActive(int displayIndex);
        static /*0x3d8c818*/ bool GetAvailable(int displayIndex);
        static /*0x3d8c8cc*/ bool GetAutomaticHDRTonemapping(int displayIndex);
        static /*0x3d8c990*/ void SetAutomaticHDRTonemapping(int displayIndex, bool scripted);
        static /*0x3d8ca4c*/ UnityEngine.ColorGamut GetDisplayColorGamut(int displayIndex);
        static /*0x3d8cb00*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(int displayIndex);
        static /*0x3d8cbb4*/ float GetPaperWhiteNits(int displayIndex);
        static /*0x3d8cc68*/ int GetMaxFullFrameToneMapLuminance(int displayIndex);
        static /*0x3d8cd1c*/ int GetMaxToneMapLuminance(int displayIndex);
        static /*0x3d8cdd0*/ int GetMinToneMapLuminance(int displayIndex);
        static /*0x3d8ce84*/ bool GetHDRModeChangeRequested(int displayIndex);
        static /*0x3d8cf48*/ void RequestHDRModeChangeInternal(int displayIndex, bool enabled);
        /*0x3d8c678*/ HDROutputSettings();
        /*0x3d8c6ec*/ bool get_active();
        /*0x3d8c7a0*/ bool get_available();
        /*0x3d8c854*/ bool get_automaticHDRTonemapping();
        /*0x3d8c908*/ void set_automaticHDRTonemapping(bool value);
        /*0x3d8c9d4*/ UnityEngine.ColorGamut get_displayColorGamut();
        /*0x3d8ca88*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x3d8cb3c*/ float get_paperWhiteNits();
        /*0x3d8cbf0*/ int get_maxFullFrameToneMapLuminance();
        /*0x3d8cca4*/ int get_maxToneMapLuminance();
        /*0x3d8cd58*/ int get_minToneMapLuminance();
        /*0x3d8ce0c*/ bool get_HDRModeChangeRequested();
        /*0x3d8cec0*/ void RequestHDRModeChange(bool enabled);
    }

    class ColorGamutUtility
    {
        static /*0x3d8d088*/ UnityEngine.ColorPrimaries GetColorPrimaries(UnityEngine.ColorGamut gamut);
        static /*0x3d8d0c4*/ UnityEngine.WhitePoint GetWhitePoint(UnityEngine.ColorGamut gamut);
        static /*0x3d8d100*/ UnityEngine.TransferFunction GetTransferFunction(UnityEngine.ColorGamut gamut);
    }

    struct Resolution
    {
        /*0x10*/ int m_Width;
        /*0x14*/ int m_Height;
        /*0x18*/ UnityEngine.RefreshRate m_RefreshRate;

        /*0x3d8d13c*/ int get_refreshRate();
        /*0x3d8d224*/ string ToString();
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

        static /*0x3d8d3bc*/ void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel);
        static /*0x3d8d434*/ int get_pixelLightCount();
        static /*0x3d8d45c*/ void set_pixelLightCount(int value);
        static /*0x3d8d498*/ UnityEngine.ShadowmaskMode get_shadowmaskMode();
        static /*0x3d8d4c0*/ float get_lodBias();
        static /*0x3d8d4e8*/ int get_maximumLODLevel();
        static /*0x3d8d510*/ void set_enableLODCrossFade(bool value);
        static /*0x3d8d54c*/ int get_antiAliasing();
        static /*0x3d8d574*/ void set_antiAliasing(int value);
        static /*0x3d8d5b0*/ bool get_billboardsFaceCameraPosition();
        static /*0x3d8d5d8*/ UnityEngine.ColorSpace get_activeColorSpace();
    }

    class TrailRenderer : UnityEngine.Renderer
    {
        static /*0x3d8d6f4*/ float get_time_Injected(nint _unity_self);
        static /*0x3d8d7b8*/ void set_time_Injected(nint _unity_self, float value);
        static /*0x3d8d87c*/ float get_startWidth_Injected(nint _unity_self);
        static /*0x3d8d940*/ void set_startWidth_Injected(nint _unity_self, float value);
        static /*0x3d8da04*/ float get_endWidth_Injected(nint _unity_self);
        static /*0x3d8dac8*/ void set_endWidth_Injected(nint _unity_self, float value);
        static /*0x3d8db8c*/ float get_widthMultiplier_Injected(nint _unity_self);
        static /*0x3d8dc50*/ void set_widthMultiplier_Injected(nint _unity_self, float value);
        static /*0x3d8dd14*/ bool get_autodestruct_Injected(nint _unity_self);
        static /*0x3d8ddd0*/ void set_autodestruct_Injected(nint _unity_self, bool value);
        static /*0x3d8de8c*/ bool get_emitting_Injected(nint _unity_self);
        static /*0x3d8df48*/ void set_emitting_Injected(nint _unity_self, bool value);
        static /*0x3d8e004*/ int get_numCornerVertices_Injected(nint _unity_self);
        static /*0x3d8e0c0*/ void set_numCornerVertices_Injected(nint _unity_self, int value);
        static /*0x3d8e17c*/ int get_numCapVertices_Injected(nint _unity_self);
        static /*0x3d8e238*/ void set_numCapVertices_Injected(nint _unity_self, int value);
        static /*0x3d8e2f4*/ float get_minVertexDistance_Injected(nint _unity_self);
        static /*0x3d8e3b8*/ void set_minVertexDistance_Injected(nint _unity_self, float value);
        static /*0x3d8e498*/ void get_startColor_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x3d8e56c*/ void set_startColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x3d8e644*/ void get_endColor_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x3d8e718*/ void set_endColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x3d8e75c*/ int get_positionCount_Injected(nint _unity_self);
        static /*0x3d8e830*/ void SetPosition_Injected(nint _unity_self, int index, ref UnityEngine.Vector3 position);
        static /*0x3d8e924*/ void GetPosition_Injected(nint _unity_self, int index, ref UnityEngine.Vector3 ret);
        static /*0x3d8ea00*/ void get_textureScale_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3d8eac8*/ void set_textureScale_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3d8eb84*/ float get_shadowBias_Injected(nint _unity_self);
        static /*0x3d8ec48*/ void set_shadowBias_Injected(nint _unity_self, float value);
        static /*0x3d8ed0c*/ bool get_generateLightingData_Injected(nint _unity_self);
        static /*0x3d8edc8*/ void set_generateLightingData_Injected(nint _unity_self, bool value);
        static /*0x3d8ee84*/ UnityEngine.LineTextureMode get_textureMode_Injected(nint _unity_self);
        static /*0x3d8ef40*/ void set_textureMode_Injected(nint _unity_self, UnityEngine.LineTextureMode value);
        static /*0x3d8effc*/ UnityEngine.LineAlignment get_alignment_Injected(nint _unity_self);
        static /*0x3d8f0b8*/ void set_alignment_Injected(nint _unity_self, UnityEngine.LineAlignment value);
        static /*0x3d8f174*/ UnityEngine.SpriteMaskInteraction get_maskInteraction_Injected(nint _unity_self);
        static /*0x3d8f230*/ void set_maskInteraction_Injected(nint _unity_self, UnityEngine.SpriteMaskInteraction value);
        static /*0x3d8f2ec*/ void Clear_Injected(nint _unity_self);
        static /*0x3d8f4b8*/ void BakeMesh_Injected(nint _unity_self, nint mesh, nint camera, bool useTransform);
        static /*0x3d8f7f4*/ nint GetWidthCurveCopy_Injected(nint _unity_self);
        static /*0x3d8f830*/ void SetWidthCurve_Injected(nint _unity_self, nint curve);
        static /*0x3d8f874*/ nint GetColorGradientCopy_Injected(nint _unity_self);
        static /*0x3d8f8b0*/ void SetColorGradient_Injected(nint _unity_self, nint curve);
        static /*0x3d8fa7c*/ int GetPositions_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper positions);
        static /*0x3d8fc48*/ int GetVisiblePositions_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper positions);
        static /*0x3d8fdb4*/ void SetPositions_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper positions);
        static /*0x3d8fe88*/ void AddPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 position);
        static /*0x3d8fff4*/ void AddPositions_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper positions);
        static /*0x3d90708*/ void SetPositionsWithNativeContainer_Injected(nint _unity_self, nint positions, int count);
        static /*0x3d9075c*/ int GetPositionsWithNativeContainer_Injected(nint _unity_self, nint positions, int length);
        static /*0x3d907b0*/ int GetVisiblePositionsWithNativeContainer_Injected(nint _unity_self, nint positions, int length);
        static /*0x3d90804*/ void AddPositionsWithNativeContainer_Injected(nint _unity_self, nint positions, int length);
        /*0x3d90858*/ TrailRenderer();
        /*0x3d8d600*/ int get_numPositions();
        /*0x3d8d67c*/ float get_time();
        /*0x3d8d730*/ void set_time(float value);
        /*0x3d8d804*/ float get_startWidth();
        /*0x3d8d8b8*/ void set_startWidth(float value);
        /*0x3d8d98c*/ float get_endWidth();
        /*0x3d8da40*/ void set_endWidth(float value);
        /*0x3d8db14*/ float get_widthMultiplier();
        /*0x3d8dbc8*/ void set_widthMultiplier(float value);
        /*0x3d8dc9c*/ bool get_autodestruct();
        /*0x3d8dd50*/ void set_autodestruct(bool value);
        /*0x3d8de14*/ bool get_emitting();
        /*0x3d8dec8*/ void set_emitting(bool value);
        /*0x3d8df8c*/ int get_numCornerVertices();
        /*0x3d8e040*/ void set_numCornerVertices(int value);
        /*0x3d8e104*/ int get_numCapVertices();
        /*0x3d8e1b8*/ void set_numCapVertices(int value);
        /*0x3d8e27c*/ float get_minVertexDistance();
        /*0x3d8e330*/ void set_minVertexDistance(float value);
        /*0x3d8e404*/ UnityEngine.Color get_startColor();
        /*0x3d8e4dc*/ void set_startColor(UnityEngine.Color value);
        /*0x3d8e5b0*/ UnityEngine.Color get_endColor();
        /*0x3d8e688*/ void set_endColor(UnityEngine.Color value);
        /*0x3d8d604*/ int get_positionCount();
        /*0x3d8e798*/ void SetPosition(int index, UnityEngine.Vector3 position);
        /*0x3d8e884*/ UnityEngine.Vector3 GetPosition(int index);
        /*0x3d8e978*/ UnityEngine.Vector2 get_textureScale();
        /*0x3d8ea44*/ void set_textureScale(UnityEngine.Vector2 value);
        /*0x3d8eb0c*/ float get_shadowBias();
        /*0x3d8ebc0*/ void set_shadowBias(float value);
        /*0x3d8ec94*/ bool get_generateLightingData();
        /*0x3d8ed48*/ void set_generateLightingData(bool value);
        /*0x3d8ee0c*/ UnityEngine.LineTextureMode get_textureMode();
        /*0x3d8eec0*/ void set_textureMode(UnityEngine.LineTextureMode value);
        /*0x3d8ef84*/ UnityEngine.LineAlignment get_alignment();
        /*0x3d8f038*/ void set_alignment(UnityEngine.LineAlignment value);
        /*0x3d8f0fc*/ UnityEngine.SpriteMaskInteraction get_maskInteraction();
        /*0x3d8f1b0*/ void set_maskInteraction(UnityEngine.SpriteMaskInteraction value);
        /*0x3d8f274*/ void Clear();
        /*0x3d8f328*/ void BakeMesh(UnityEngine.Mesh mesh, bool useTransform);
        /*0x3d8f360*/ void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, bool useTransform);
        /*0x3d8f514*/ UnityEngine.AnimationCurve get_widthCurve();
        /*0x3d8f5a8*/ void set_widthCurve(UnityEngine.AnimationCurve value);
        /*0x3d8f684*/ UnityEngine.Gradient get_colorGradient();
        /*0x3d8f718*/ void set_colorGradient(UnityEngine.Gradient value);
        /*0x3d8f518*/ UnityEngine.AnimationCurve GetWidthCurveCopy();
        /*0x3d8f5ac*/ void SetWidthCurve(UnityEngine.AnimationCurve curve);
        /*0x3d8f688*/ UnityEngine.Gradient GetColorGradientCopy();
        /*0x3d8f71c*/ void SetColorGradient(UnityEngine.Gradient curve);
        /*0x3d8f8f4*/ int GetPositions(UnityEngine.Vector3[] positions);
        /*0x3d8fac0*/ int GetVisiblePositions(UnityEngine.Vector3[] positions);
        /*0x3d8fc8c*/ void SetPositions(UnityEngine.Vector3[] positions);
        /*0x3d8fdf8*/ void AddPosition(UnityEngine.Vector3 position);
        /*0x3d8fecc*/ void AddPositions(UnityEngine.Vector3[] positions);
        /*0x3d90038*/ void SetPositions(Unity.Collections.NativeArray<UnityEngine.Vector3> positions);
        /*0x3d9013c*/ void SetPositions(Unity.Collections.NativeSlice<UnityEngine.Vector3> positions);
        /*0x3d901ec*/ int GetPositions(Unity.Collections.NativeArray<UnityEngine.Vector3> positions);
        /*0x3d902f0*/ int GetPositions(Unity.Collections.NativeSlice<UnityEngine.Vector3> positions);
        /*0x3d903a0*/ int GetVisiblePositions(Unity.Collections.NativeArray<UnityEngine.Vector3> positions);
        /*0x3d904a4*/ int GetVisiblePositions(Unity.Collections.NativeSlice<UnityEngine.Vector3> positions);
        /*0x3d90554*/ void AddPositions(Unity.Collections.NativeArray<UnityEngine.Vector3> positions);
        /*0x3d90658*/ void AddPositions(Unity.Collections.NativeSlice<UnityEngine.Vector3> positions);
        /*0x3d900ac*/ void SetPositionsWithNativeContainer(nint positions, int count);
        /*0x3d90260*/ int GetPositionsWithNativeContainer(nint positions, int length);
        /*0x3d90414*/ int GetVisiblePositionsWithNativeContainer(nint positions, int length);
        /*0x3d905c8*/ void AddPositionsWithNativeContainer(nint positions, int length);
    }

    class LineRenderer : UnityEngine.Renderer
    {
        static /*0x3d90c84*/ float get_startWidth_Injected(nint _unity_self);
        static /*0x3d90cc0*/ void set_startWidth_Injected(nint _unity_self, float value);
        static /*0x3d90d84*/ float get_endWidth_Injected(nint _unity_self);
        static /*0x3d90dc0*/ void set_endWidth_Injected(nint _unity_self, float value);
        static /*0x3d90e84*/ float get_widthMultiplier_Injected(nint _unity_self);
        static /*0x3d90f48*/ void set_widthMultiplier_Injected(nint _unity_self, float value);
        static /*0x3d9100c*/ int get_numCornerVertices_Injected(nint _unity_self);
        static /*0x3d910c8*/ void set_numCornerVertices_Injected(nint _unity_self, int value);
        static /*0x3d91184*/ int get_numCapVertices_Injected(nint _unity_self);
        static /*0x3d91240*/ void set_numCapVertices_Injected(nint _unity_self, int value);
        static /*0x3d912fc*/ bool get_useWorldSpace_Injected(nint _unity_self);
        static /*0x3d913b8*/ void set_useWorldSpace_Injected(nint _unity_self, bool value);
        static /*0x3d91474*/ bool get_loop_Injected(nint _unity_self);
        static /*0x3d91530*/ void set_loop_Injected(nint _unity_self, bool value);
        static /*0x3d91608*/ void get_startColor_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x3d9164c*/ void set_startColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x3d91724*/ void get_endColor_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x3d91768*/ void set_endColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x3d917ac*/ int get_positionCount_Injected(nint _unity_self);
        static /*0x3d917e8*/ void set_positionCount_Injected(nint _unity_self, int value);
        static /*0x3d918c4*/ void SetPosition_Injected(nint _unity_self, int index, ref UnityEngine.Vector3 position);
        static /*0x3d919b8*/ void GetPosition_Injected(nint _unity_self, int index, ref UnityEngine.Vector3 ret);
        static /*0x3d91a94*/ void get_textureScale_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3d91b5c*/ void set_textureScale_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3d91c18*/ float get_shadowBias_Injected(nint _unity_self);
        static /*0x3d91cdc*/ void set_shadowBias_Injected(nint _unity_self, float value);
        static /*0x3d91da0*/ bool get_generateLightingData_Injected(nint _unity_self);
        static /*0x3d91e5c*/ void set_generateLightingData_Injected(nint _unity_self, bool value);
        static /*0x3d91f18*/ UnityEngine.LineTextureMode get_textureMode_Injected(nint _unity_self);
        static /*0x3d91fd4*/ void set_textureMode_Injected(nint _unity_self, UnityEngine.LineTextureMode value);
        static /*0x3d92090*/ UnityEngine.LineAlignment get_alignment_Injected(nint _unity_self);
        static /*0x3d9214c*/ void set_alignment_Injected(nint _unity_self, UnityEngine.LineAlignment value);
        static /*0x3d92208*/ UnityEngine.SpriteMaskInteraction get_maskInteraction_Injected(nint _unity_self);
        static /*0x3d922c4*/ void set_maskInteraction_Injected(nint _unity_self, UnityEngine.SpriteMaskInteraction value);
        static /*0x3d92390*/ void Simplify_Injected(nint _unity_self, float tolerance);
        static /*0x3d9256c*/ void BakeMesh_Injected(nint _unity_self, nint mesh, nint camera, bool useTransform);
        static /*0x3d928a8*/ nint GetWidthCurveCopy_Injected(nint _unity_self);
        static /*0x3d928e4*/ void SetWidthCurve_Injected(nint _unity_self, nint curve);
        static /*0x3d92928*/ nint GetColorGradientCopy_Injected(nint _unity_self);
        static /*0x3d92964*/ void SetColorGradient_Injected(nint _unity_self, nint curve);
        static /*0x3d92b30*/ int GetPositions_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper positions);
        static /*0x3d92c9c*/ void SetPositions_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper positions);
        static /*0x3d93048*/ void SetPositionsWithNativeContainer_Injected(nint _unity_self, nint positions, int count);
        static /*0x3d9309c*/ int GetPositionsWithNativeContainer_Injected(nint _unity_self, nint positions, int length);
        /*0x3d930f0*/ LineRenderer();
        /*0x3d90868*/ void SetWidth(float start, float end);
        /*0x3d909a0*/ void SetColors(UnityEngine.Color start, UnityEngine.Color end);
        /*0x3d90b08*/ void SetVertexCount(int count);
        /*0x3d90b8c*/ int get_numPositions();
        /*0x3d90c08*/ void set_numPositions(int value);
        /*0x3d90c0c*/ float get_startWidth();
        /*0x3d90890*/ void set_startWidth(float value);
        /*0x3d90d0c*/ float get_endWidth();
        /*0x3d90918*/ void set_endWidth(float value);
        /*0x3d90e0c*/ float get_widthMultiplier();
        /*0x3d90ec0*/ void set_widthMultiplier(float value);
        /*0x3d90f94*/ int get_numCornerVertices();
        /*0x3d91048*/ void set_numCornerVertices(int value);
        /*0x3d9110c*/ int get_numCapVertices();
        /*0x3d911c0*/ void set_numCapVertices(int value);
        /*0x3d91284*/ bool get_useWorldSpace();
        /*0x3d91338*/ void set_useWorldSpace(bool value);
        /*0x3d913fc*/ bool get_loop();
        /*0x3d914b0*/ void set_loop(bool value);
        /*0x3d91574*/ UnityEngine.Color get_startColor();
        /*0x3d909e8*/ void set_startColor(UnityEngine.Color value);
        /*0x3d91690*/ UnityEngine.Color get_endColor();
        /*0x3d90a78*/ void set_endColor(UnityEngine.Color value);
        /*0x3d90b90*/ int get_positionCount();
        /*0x3d90b0c*/ void set_positionCount(int value);
        /*0x3d9182c*/ void SetPosition(int index, UnityEngine.Vector3 position);
        /*0x3d91918*/ UnityEngine.Vector3 GetPosition(int index);
        /*0x3d91a0c*/ UnityEngine.Vector2 get_textureScale();
        /*0x3d91ad8*/ void set_textureScale(UnityEngine.Vector2 value);
        /*0x3d91ba0*/ float get_shadowBias();
        /*0x3d91c54*/ void set_shadowBias(float value);
        /*0x3d91d28*/ bool get_generateLightingData();
        /*0x3d91ddc*/ void set_generateLightingData(bool value);
        /*0x3d91ea0*/ UnityEngine.LineTextureMode get_textureMode();
        /*0x3d91f54*/ void set_textureMode(UnityEngine.LineTextureMode value);
        /*0x3d92018*/ UnityEngine.LineAlignment get_alignment();
        /*0x3d920cc*/ void set_alignment(UnityEngine.LineAlignment value);
        /*0x3d92190*/ UnityEngine.SpriteMaskInteraction get_maskInteraction();
        /*0x3d92244*/ void set_maskInteraction(UnityEngine.SpriteMaskInteraction value);
        /*0x3d92308*/ void Simplify(float tolerance);
        /*0x3d923dc*/ void BakeMesh(UnityEngine.Mesh mesh, bool useTransform);
        /*0x3d92414*/ void BakeMesh(UnityEngine.Mesh mesh, UnityEngine.Camera camera, bool useTransform);
        /*0x3d925c8*/ UnityEngine.AnimationCurve get_widthCurve();
        /*0x3d9265c*/ void set_widthCurve(UnityEngine.AnimationCurve value);
        /*0x3d92738*/ UnityEngine.Gradient get_colorGradient();
        /*0x3d927cc*/ void set_colorGradient(UnityEngine.Gradient value);
        /*0x3d925cc*/ UnityEngine.AnimationCurve GetWidthCurveCopy();
        /*0x3d92660*/ void SetWidthCurve(UnityEngine.AnimationCurve curve);
        /*0x3d9273c*/ UnityEngine.Gradient GetColorGradientCopy();
        /*0x3d927d0*/ void SetColorGradient(UnityEngine.Gradient curve);
        /*0x3d929a8*/ int GetPositions(UnityEngine.Vector3[] positions);
        /*0x3d92b74*/ void SetPositions(UnityEngine.Vector3[] positions);
        /*0x3d92ce0*/ void SetPositions(Unity.Collections.NativeArray<UnityEngine.Vector3> positions);
        /*0x3d92de4*/ void SetPositions(Unity.Collections.NativeSlice<UnityEngine.Vector3> positions);
        /*0x3d92e94*/ int GetPositions(Unity.Collections.NativeArray<UnityEngine.Vector3> positions);
        /*0x3d92f98*/ int GetPositions(Unity.Collections.NativeSlice<UnityEngine.Vector3> positions);
        /*0x3d92d54*/ void SetPositionsWithNativeContainer(nint positions, int count);
        /*0x3d92f08*/ int GetPositionsWithNativeContainer(nint positions, int length);
    }

    class MaterialPropertyBlock
    {
        /*0x10*/ nint m_Ptr;

        static /*0x3d93df4*/ nint CreateImpl();
        static /*0x3d93e1c*/ void DestroyImpl(nint mpb);
        static /*0x3d9316c*/ void GetColorImpl_Injected(nint _unity_self, int name, ref UnityEngine.Color ret);
        static /*0x3d93228*/ void SetIntImpl_Injected(nint _unity_self, int name, int value);
        static /*0x3d932e4*/ void SetFloatImpl_Injected(nint _unity_self, int name, float value);
        static /*0x3d933a8*/ void SetVectorImpl_Injected(nint _unity_self, int name, ref UnityEngine.Vector4 value);
        static /*0x3d9346c*/ void SetColorImpl_Injected(nint _unity_self, int name, ref UnityEngine.Color value);
        static /*0x3d93528*/ void SetMatrixImpl_Injected(nint _unity_self, int name, ref UnityEngine.Matrix4x4 value);
        static /*0x3d93664*/ void SetTextureImpl_Injected(nint _unity_self, int name, nint value);
        static /*0x3d937a8*/ void SetRenderTextureImpl_Injected(nint _unity_self, int name, nint value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x3d93874*/ void SetBufferImpl_Injected(nint _unity_self, int name, nint value);
        static /*0x3d93950*/ void SetConstantBufferImpl_Injected(nint _unity_self, int name, nint value, int offset, int size);
        static /*0x3d93ac8*/ void SetFloatArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x3d93c30*/ void SetVectorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x3d93d98*/ void SetMatrixArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x3d93eb0*/ void Clear_Injected(nint _unity_self, bool keepMemory);
        /*0x3d94130*/ MaterialPropertyBlock();
        /*0x3d930f8*/ UnityEngine.Color GetColorImpl(int name);
        /*0x3d931c0*/ void SetIntImpl(int name, int value);
        /*0x3d9327c*/ void SetFloatImpl(int name, float value);
        /*0x3d93338*/ void SetVectorImpl(int name, UnityEngine.Vector4 value);
        /*0x3d933fc*/ void SetColorImpl(int name, UnityEngine.Color value);
        /*0x3d934c0*/ void SetMatrixImpl(int name, UnityEngine.Matrix4x4 value);
        /*0x3d9357c*/ void SetTextureImpl(int name, UnityEngine.Texture value);
        /*0x3d936b8*/ void SetRenderTextureImpl(int name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x3d93804*/ void SetBufferImpl(int name, UnityEngine.ComputeBuffer value);
        /*0x3d938c8*/ void SetConstantBufferImpl(int name, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x3d939bc*/ void SetFloatArrayImpl(int name, float[] values, int count);
        /*0x3d93b24*/ void SetVectorArrayImpl(int name, UnityEngine.Vector4[] values, int count);
        /*0x3d93c8c*/ void SetMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x3d93e58*/ void Clear(bool keepMemory);
        /*0x3d93ef4*/ void Clear();
        /*0x3d93efc*/ void SetFloatArray(int name, float[] values, int count);
        /*0x3d93fb8*/ void SetVectorArray(int name, UnityEngine.Vector4[] values, int count);
        /*0x3d94074*/ void SetMatrixArray(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x3d94174*/ void Finalize();
        /*0x3d941f8*/ void Dispose();
        /*0x3d9428c*/ void SetInt(string name, int value);
        /*0x3d9442c*/ void SetInt(int nameID, int value);
        /*0x3d94434*/ void SetFloat(string name, float value);
        /*0x3d94464*/ void SetFloat(int nameID, float value);
        /*0x3d94468*/ void SetInteger(int nameID, int value);
        /*0x3d9446c*/ void SetVector(string name, UnityEngine.Vector4 value);
        /*0x3d944bc*/ void SetVector(int nameID, UnityEngine.Vector4 value);
        /*0x3d944c0*/ void SetColor(string name, UnityEngine.Color value);
        /*0x3d94510*/ void SetColor(int nameID, UnityEngine.Color value);
        /*0x3d94514*/ void SetMatrix(string name, UnityEngine.Matrix4x4 value);
        /*0x3d94560*/ void SetMatrix(int nameID, UnityEngine.Matrix4x4 value);
        /*0x3d9458c*/ void SetBuffer(string name, UnityEngine.ComputeBuffer value);
        /*0x3d945bc*/ void SetTexture(string name, UnityEngine.Texture value);
        /*0x3d945ec*/ void SetTexture(int nameID, UnityEngine.Texture value);
        /*0x3d945f0*/ void SetTexture(int nameID, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x3d945f4*/ void SetConstantBuffer(int nameID, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x3d945f8*/ void SetFloatArray(string name, float[] values);
        /*0x3d94634*/ void SetVectorArray(string name, UnityEngine.Vector4[] values);
        /*0x3d94670*/ void SetVectorArray(int nameID, UnityEngine.Vector4[] values);
        /*0x3d94684*/ void SetMatrixArray(string name, UnityEngine.Matrix4x4[] values);
        /*0x3d946c0*/ UnityEngine.Color GetColor(int nameID);

        class BindingsMarshaller
        {
            static /*0x3d946c4*/ nint ConvertToNative(UnityEngine.MaterialPropertyBlock materialPropertyBlock);
        }
    }

    class Renderer : UnityEngine.Component
    {
        static /*0x3d9477c*/ void get_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x3d94840*/ void set_localBounds_Injected(nint _unity_self, ref UnityEngine.Bounds value);
        static /*0x3d94918*/ nint GetMaterial_Injected(nint _unity_self);
        static /*0x3d949e8*/ nint GetSharedMaterial_Injected(nint _unity_self);
        static /*0x3d94ad8*/ void SetMaterial_Injected(nint _unity_self, nint m);
        static /*0x3d94bdc*/ void SetMaterialArray_Injected(nint _unity_self, UnityEngine.Material[] m, int length);
        static /*0x3d94cd8*/ void Internal_SetPropertyBlock_Injected(nint _unity_self, nint properties);
        static /*0x3d94df4*/ void Internal_GetPropertyBlock_Injected(nint _unity_self, nint dest);
        static /*0x3d94ed0*/ void Internal_SetPropertyBlockMaterialIndex_Injected(nint _unity_self, nint properties, int materialIndex);
        static /*0x3d94fa8*/ bool get_enabled_Injected(nint _unity_self);
        static /*0x3d95064*/ void set_enabled_Injected(nint _unity_self, bool value);
        static /*0x3d95120*/ bool get_isVisible_Injected(nint _unity_self);
        static /*0x3d951dc*/ void set_shadowCastingMode_Injected(nint _unity_self, UnityEngine.Rendering.ShadowCastingMode value);
        static /*0x3d952a0*/ void set_receiveShadows_Injected(nint _unity_self, bool value);
        static /*0x3d9535c*/ int get_sortingLayerID_Injected(nint _unity_self);
        static /*0x3d95418*/ void set_sortingLayerID_Injected(nint _unity_self, int value);
        static /*0x3d954d4*/ int get_sortingOrder_Injected(nint _unity_self);
        static /*0x3d95590*/ void set_sortingOrder_Injected(nint _unity_self, int value);
        static /*0x3d9564c*/ int get_sortingGroupID_Injected(nint _unity_self);
        static /*0x3d95700*/ int get_sortingGroupOrder_Injected(nint _unity_self);
        static /*0x3d957b4*/ UnityEngine.Material[] GetSharedMaterialArray_Injected(nint _unity_self);
        /*0x3d90860*/ Renderer();
        /*0x3d946d8*/ UnityEngine.Bounds get_bounds();
        /*0x3d947c0*/ void set_localBounds(UnityEngine.Bounds value);
        /*0x3d94884*/ UnityEngine.Material GetMaterial();
        /*0x3d94954*/ UnityEngine.Material GetSharedMaterial();
        /*0x3d94a24*/ void SetMaterial(UnityEngine.Material m);
        /*0x3d94b1c*/ void SetMaterialArray(UnityEngine.Material[] m, int length);
        /*0x3d94c30*/ void SetMaterialArray(UnityEngine.Material[] m);
        /*0x3d94c50*/ void Internal_SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties);
        /*0x3d94d1c*/ void Internal_GetPropertyBlock(UnityEngine.MaterialPropertyBlock dest);
        /*0x3d94e38*/ void Internal_SetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock properties, int materialIndex);
        /*0x3d94f24*/ void SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties);
        /*0x3d94f28*/ void SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties, int materialIndex);
        /*0x3d94f2c*/ void GetPropertyBlock(UnityEngine.MaterialPropertyBlock properties);
        /*0x3d94f30*/ bool get_enabled();
        /*0x3d94fe4*/ void set_enabled(bool value);
        /*0x3d950a8*/ bool get_isVisible();
        /*0x3d9515c*/ void set_shadowCastingMode(UnityEngine.Rendering.ShadowCastingMode value);
        /*0x3d95220*/ void set_receiveShadows(bool value);
        /*0x3d952e4*/ int get_sortingLayerID();
        /*0x3d95398*/ void set_sortingLayerID(int value);
        /*0x3d9545c*/ int get_sortingOrder();
        /*0x3d95510*/ void set_sortingOrder(int value);
        /*0x3d955d4*/ int get_sortingGroupID();
        /*0x3d95688*/ int get_sortingGroupOrder();
        /*0x3d9573c*/ UnityEngine.Material[] GetSharedMaterialArray();
        /*0x3d957f0*/ UnityEngine.Material get_material();
        /*0x3d957f4*/ void set_material(UnityEngine.Material value);
        /*0x3d957f8*/ UnityEngine.Material get_sharedMaterial();
        /*0x3d957fc*/ void set_sharedMaterial(UnityEngine.Material value);
        /*0x3d95800*/ UnityEngine.Material[] get_sharedMaterials();
        /*0x3d95804*/ void set_sharedMaterials(UnityEngine.Material[] value);
    }

    class RenderSettings : UnityEngine.Object
    {
        static /*0x3d95808*/ bool get_fog();
        static /*0x3d95830*/ UnityEngine.Color get_ambientSkyColor();
        static /*0x3d958b4*/ UnityEngine.Color get_ambientEquatorColor();
        static /*0x3d95938*/ UnityEngine.Color get_ambientGroundColor();
        static /*0x3d959bc*/ UnityEngine.Color get_subtractiveShadowColor();
        static /*0x3d95a40*/ UnityEngine.Material get_skybox();
        static /*0x3d95ac8*/ UnityEngine.Light get_sun();
        static /*0x3d95b50*/ UnityEngine.Rendering.SphericalHarmonicsL2 get_ambientProbe();
        static /*0x3d95bf8*/ float get_reflectionIntensity();
        static /*0x3d95878*/ void get_ambientSkyColor_Injected(ref UnityEngine.Color ret);
        static /*0x3d958fc*/ void get_ambientEquatorColor_Injected(ref UnityEngine.Color ret);
        static /*0x3d95980*/ void get_ambientGroundColor_Injected(ref UnityEngine.Color ret);
        static /*0x3d95a04*/ void get_subtractiveShadowColor_Injected(ref UnityEngine.Color ret);
        static /*0x3d95aa0*/ nint get_skybox_Injected();
        static /*0x3d95b28*/ nint get_sun_Injected();
        static /*0x3d95bbc*/ void get_ambientProbe_Injected(ref UnityEngine.Rendering.SphericalHarmonicsL2 ret);
    }

    class Shader : UnityEngine.Object
    {
        static /*0x3d95c20*/ UnityEngine.Rendering.ShaderHardwareTier get_globalShaderHardwareTier();
        static /*0x3d95c88*/ void set_globalShaderHardwareTier(UnityEngine.Rendering.ShaderHardwareTier value);
        static /*0x3d95cfc*/ UnityEngine.Shader Find(string name);
        static /*0x3d95d68*/ UnityEngine.Shader FindBuiltin(string name);
        static /*0x3d95fa0*/ int get_maximumChunksOverride();
        static /*0x3d95fc8*/ void set_maximumChunksOverride(int value);
        static /*0x3d9617c*/ int get_globalMaximumLOD();
        static /*0x3d961a4*/ void set_globalMaximumLOD(int value);
        static /*0x3d96294*/ string get_globalRenderPipeline();
        static /*0x3d96394*/ void set_globalRenderPipeline(string value);
        static /*0x3d96538*/ UnityEngine.Rendering.GlobalKeyword[] get_enabledGlobalKeywords();
        static /*0x3d96588*/ UnityEngine.Rendering.GlobalKeyword[] get_globalKeywords();
        static /*0x3d96560*/ UnityEngine.Rendering.GlobalKeyword[] GetEnabledGlobalKeywords();
        static /*0x3d965b0*/ UnityEngine.Rendering.GlobalKeyword[] GetAllGlobalKeywords();
        static /*0x3d966a4*/ void EnableKeyword(string keyword);
        static /*0x3d96848*/ void DisableKeyword(string keyword);
        static /*0x3d969ec*/ bool IsKeywordEnabled(string keyword);
        static /*0x3d96b9c*/ void EnableKeywordFast(UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x3d96c18*/ void DisableKeywordFast(UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x3d96c94*/ void SetKeywordFast(UnityEngine.Rendering.GlobalKeyword keyword, bool value);
        static /*0x3d96d28*/ bool IsKeywordEnabledFast(UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x3d96da8*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x3d96dec*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x3d96e30*/ void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
        static /*0x3d96e84*/ bool IsKeywordEnabled(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x3d97034*/ void WarmupAllShaders();
        static /*0x3d9705c*/ int TagToID(string name);
        static /*0x3d97208*/ string IDToTag(int name);
        static /*0x3d942bc*/ int PropertyToID(string name);
        static /*0x3d97d3c*/ void SetGlobalIntImpl(int name, int value);
        static /*0x3d97d80*/ void SetGlobalFloatImpl(int name, float value);
        static /*0x3d97dcc*/ void SetGlobalVectorImpl(int name, UnityEngine.Vector4 value);
        static /*0x3d97e64*/ void SetGlobalMatrixImpl(int name, UnityEngine.Matrix4x4 value);
        static /*0x3d97eec*/ void SetGlobalTextureImpl(int name, UnityEngine.Texture value);
        static /*0x3d97fbc*/ void SetGlobalRenderTextureImpl(int name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x3d980a4*/ void SetGlobalBufferImpl(int name, UnityEngine.ComputeBuffer value);
        static /*0x3d98138*/ void SetGlobalGraphicsBufferImpl(int name, UnityEngine.GraphicsBuffer value);
        static /*0x3d981cc*/ void SetGlobalConstantBufferImpl(int name, UnityEngine.ComputeBuffer value, int offset, int size);
        static /*0x3d98290*/ void SetGlobalConstantGraphicsBufferImpl(int name, UnityEngine.GraphicsBuffer value, int offset, int size);
        static /*0x3d98354*/ void SetGlobalRayTracingAccelerationStructureImpl(int name, UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
        static /*0x3d983e8*/ int GetGlobalIntImpl(int name);
        static /*0x3d98424*/ float GetGlobalFloatImpl(int name);
        static /*0x3d98460*/ UnityEngine.Vector4 GetGlobalVectorImpl(int name);
        static /*0x3d984fc*/ UnityEngine.Matrix4x4 GetGlobalMatrixImpl(int name);
        static /*0x3d985ac*/ UnityEngine.Texture GetGlobalTextureImpl(int name);
        static /*0x3d98654*/ void SetGlobalFloatArrayImpl(int name, float[] values, int count);
        static /*0x3d98790*/ void SetGlobalVectorArrayImpl(int name, UnityEngine.Vector4[] values, int count);
        static /*0x3d988cc*/ void SetGlobalMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] values, int count);
        static /*0x3d98a08*/ float[] GetGlobalFloatArrayImpl(int name);
        static /*0x3d98b64*/ UnityEngine.Vector4[] GetGlobalVectorArrayImpl(int name);
        static /*0x3d98cc0*/ UnityEngine.Matrix4x4[] GetGlobalMatrixArrayImpl(int name);
        static /*0x3d98e1c*/ int GetGlobalFloatArrayCountImpl(int name);
        static /*0x3d98e58*/ int GetGlobalVectorArrayCountImpl(int name);
        static /*0x3d98e94*/ int GetGlobalMatrixArrayCountImpl(int name);
        static /*0x3d98ed0*/ void ExtractGlobalFloatArrayImpl(int name, float[] val);
        static /*0x3d99028*/ void ExtractGlobalVectorArrayImpl(int name, UnityEngine.Vector4[] val);
        static /*0x3d99180*/ void ExtractGlobalMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] val);
        static /*0x3d992d8*/ void SetGlobalFloatArray(int name, float[] values, int count);
        static /*0x3d99394*/ void SetGlobalVectorArray(int name, UnityEngine.Vector4[] values, int count);
        static /*0x3d99450*/ void SetGlobalMatrixArray(int name, UnityEngine.Matrix4x4[] values, int count);
        static /*0x3d9950c*/ void ExtractGlobalFloatArray(int name, System.Collections.Generic.List<float> values);
        static /*0x3d99690*/ void ExtractGlobalVectorArray(int name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        static /*0x3d99814*/ void ExtractGlobalMatrixArray(int name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        static /*0x3d99998*/ void SetGlobalInt(string name, int value);
        static /*0x3d999e0*/ void SetGlobalInt(int nameID, int value);
        static /*0x3d99a24*/ void SetGlobalFloat(string name, float value);
        static /*0x3d99a74*/ void SetGlobalFloat(int nameID, float value);
        static /*0x3d99ac0*/ void SetGlobalInteger(string name, int value);
        static /*0x3d99b08*/ void SetGlobalInteger(int nameID, int value);
        static /*0x3d99b4c*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
        static /*0x3d99b8c*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
        static /*0x3d99b90*/ void SetGlobalColor(string name, UnityEngine.Color value);
        static /*0x3d99bd0*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
        static /*0x3d99bd4*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
        static /*0x3d99c38*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
        static /*0x3d99c94*/ void SetGlobalTexture(string name, UnityEngine.Texture value);
        static /*0x3d99cac*/ void SetGlobalTexture(int nameID, UnityEngine.Texture value);
        static /*0x3d99cb0*/ void SetGlobalTexture(string name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x3d99cd8*/ void SetGlobalTexture(int nameID, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x3d99cdc*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
        static /*0x3d99d2c*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
        static /*0x3d99d7c*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
        static /*0x3d99dcc*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
        static /*0x3d99e1c*/ void SetGlobalConstantBuffer(string name, UnityEngine.ComputeBuffer value, int offset, int size);
        static /*0x3d99e84*/ void SetGlobalConstantBuffer(int nameID, UnityEngine.ComputeBuffer value, int offset, int size);
        static /*0x3d99eec*/ void SetGlobalConstantBuffer(string name, UnityEngine.GraphicsBuffer value, int offset, int size);
        static /*0x3d99f54*/ void SetGlobalConstantBuffer(int nameID, UnityEngine.GraphicsBuffer value, int offset, int size);
        static /*0x3d99fbc*/ void SetGlobalRayTracingAccelerationStructure(string name, UnityEngine.Rendering.RayTracingAccelerationStructure value);
        static /*0x3d9a00c*/ void SetGlobalRayTracingAccelerationStructure(int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure value);
        static /*0x3d9a05c*/ void SetGlobalFloatArray(string name, System.Collections.Generic.List<float> values);
        static /*0x3d9a0fc*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
        static /*0x3d9a190*/ void SetGlobalFloatArray(string name, float[] values);
        static /*0x3d9a1b4*/ void SetGlobalFloatArray(int nameID, float[] values);
        static /*0x3d9a1c8*/ void SetGlobalVectorArray(string name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        static /*0x3d9a268*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
        static /*0x3d9a2fc*/ void SetGlobalVectorArray(string name, UnityEngine.Vector4[] values);
        static /*0x3d9a320*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
        static /*0x3d9a334*/ void SetGlobalMatrixArray(string name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        static /*0x3d9a3d4*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        static /*0x3d9a468*/ void SetGlobalMatrixArray(string name, UnityEngine.Matrix4x4[] values);
        static /*0x3d9a48c*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
        static /*0x3d9a4a0*/ int GetGlobalInt(string name);
        static /*0x3d9a4fc*/ int GetGlobalInt(int nameID);
        static /*0x3d9a554*/ float GetGlobalFloat(string name);
        static /*0x3d9a594*/ float GetGlobalFloat(int nameID);
        static /*0x3d9a5d0*/ int GetGlobalInteger(string name);
        static /*0x3d9a610*/ int GetGlobalInteger(int nameID);
        static /*0x3d9a64c*/ UnityEngine.Vector4 GetGlobalVector(string name);
        static /*0x3d9a65c*/ UnityEngine.Vector4 GetGlobalVector(int nameID);
        static /*0x3d9a660*/ UnityEngine.Color GetGlobalColor(string name);
        static /*0x3d9a670*/ UnityEngine.Color GetGlobalColor(int nameID);
        static /*0x3d9a674*/ UnityEngine.Matrix4x4 GetGlobalMatrix(string name);
        static /*0x3d9a6f8*/ UnityEngine.Matrix4x4 GetGlobalMatrix(int nameID);
        static /*0x3d9a774*/ UnityEngine.Texture GetGlobalTexture(string name);
        static /*0x3d9a784*/ UnityEngine.Texture GetGlobalTexture(int nameID);
        static /*0x3d9a788*/ float[] GetGlobalFloatArray(string name);
        static /*0x3d9a798*/ float[] GetGlobalFloatArray(int nameID);
        static /*0x3d9a7f0*/ UnityEngine.Vector4[] GetGlobalVectorArray(string name);
        static /*0x3d9a800*/ UnityEngine.Vector4[] GetGlobalVectorArray(int nameID);
        static /*0x3d9a858*/ UnityEngine.Matrix4x4[] GetGlobalMatrixArray(string name);
        static /*0x3d9a868*/ UnityEngine.Matrix4x4[] GetGlobalMatrixArray(int nameID);
        static /*0x3d9a8c0*/ void GetGlobalFloatArray(string name, System.Collections.Generic.List<float> values);
        static /*0x3d9a8d8*/ void GetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
        static /*0x3d9a8dc*/ void GetGlobalVectorArray(string name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        static /*0x3d9a8f4*/ void GetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
        static /*0x3d9a8f8*/ void GetGlobalMatrixArray(string name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        static /*0x3d9a910*/ void GetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        static /*0x3d9a96c*/ string GetPropertyName(UnityEngine.Shader shader, int propertyIndex);
        static /*0x3d9ab1c*/ int GetPropertyNameId(UnityEngine.Shader shader, int propertyIndex);
        static /*0x3d9ac10*/ UnityEngine.Rendering.ShaderPropertyType GetPropertyType(UnityEngine.Shader shader, int propertyIndex);
        static /*0x3d9ad04*/ string GetPropertyDescription(UnityEngine.Shader shader, int propertyIndex);
        static /*0x3d9aeb4*/ UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(UnityEngine.Shader shader, int propertyIndex);
        static /*0x3d9afa8*/ string[] GetPropertyAttributes(UnityEngine.Shader shader, int propertyIndex);
        static /*0x3d9b09c*/ int GetPropertyDefaultIntValue(UnityEngine.Shader shader, int propertyIndex);
        static /*0x3d9b190*/ UnityEngine.Vector4 GetPropertyDefaultValue(UnityEngine.Shader shader, int propertyIndex);
        static /*0x3d9b2b0*/ UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(UnityEngine.Shader shader, int propertyIndex);
        static /*0x3d9b3a4*/ string GetPropertyTextureDefaultName(UnityEngine.Shader shader, int propertyIndex);
        static /*0x3d9b554*/ bool FindTextureStackImpl(UnityEngine.Shader s, int propertyIdx, ref string stackName, ref int layerIndex);
        static /*0x3d9b730*/ void CheckPropertyIndex(UnityEngine.Shader s, int propertyIndex);
        static /*0x3d95f64*/ nint FindBuiltin_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d9607c*/ int get_maximumLOD_Injected(nint _unity_self);
        static /*0x3d96138*/ void set_maximumLOD_Injected(nint _unity_self, int value);
        static /*0x3d96258*/ bool get_isSupported_Injected(nint _unity_self);
        static /*0x3d96358*/ void get_globalRenderPipeline_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d964fc*/ void set_globalRenderPipeline_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x3d96660*/ void get_keywordSpace_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeywordSpace ret);
        static /*0x3d9680c*/ void EnableKeyword_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x3d969b0*/ void DisableKeyword_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x3d96b60*/ bool IsKeywordEnabled_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x3d96bdc*/ void EnableKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x3d96c58*/ void DisableKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x3d96ce4*/ void SetKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
        static /*0x3d96d6c*/ bool IsKeywordEnabledFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x3d96f44*/ int get_renderQueue_Injected(nint _unity_self);
        static /*0x3d96ff8*/ UnityEngine.DisableBatchingType get_disableBatching_Injected(nint _unity_self);
        static /*0x3d971cc*/ int TagToID_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d972d4*/ void IDToTag_Injected(int name, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d97318*/ int PropertyToID_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d9756c*/ nint GetDependency_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3d97628*/ int get_passCount_Injected(nint _unity_self);
        static /*0x3d976dc*/ int get_subshaderCount_Injected(nint _unity_self);
        static /*0x3d97798*/ int GetPassCountInSubshader_Injected(nint _unity_self, int subshaderIndex);
        static /*0x3d97c38*/ int Internal_FindPassTagValue_Injected(nint _unity_self, int passIndex, int tagName);
        static /*0x3d97c8c*/ int Internal_FindPassTagValueInSubShader_Injected(nint _unity_self, int subShaderIndex, int passIndex, int tagName);
        static /*0x3d97ce8*/ int Internal_FindSubshaderTagValue_Injected(nint _unity_self, int subShaderIndex, int tagName);
        static /*0x3d97e20*/ void SetGlobalVectorImpl_Injected(int name, ref UnityEngine.Vector4 value);
        static /*0x3d97ea8*/ void SetGlobalMatrixImpl_Injected(int name, ref UnityEngine.Matrix4x4 value);
        static /*0x3d97f78*/ void SetGlobalTextureImpl_Injected(int name, nint value);
        static /*0x3d98050*/ void SetGlobalRenderTextureImpl_Injected(int name, nint value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x3d980f4*/ void SetGlobalBufferImpl_Injected(int name, nint value);
        static /*0x3d98188*/ void SetGlobalGraphicsBufferImpl_Injected(int name, nint value);
        static /*0x3d98234*/ void SetGlobalConstantBufferImpl_Injected(int name, nint value, int offset, int size);
        static /*0x3d982f8*/ void SetGlobalConstantGraphicsBufferImpl_Injected(int name, nint value, int offset, int size);
        static /*0x3d983a4*/ void SetGlobalRayTracingAccelerationStructureImpl_Injected(int name, nint accelerationStructure);
        static /*0x3d984b8*/ void GetGlobalVectorImpl_Injected(int name, ref UnityEngine.Vector4 ret);
        static /*0x3d98568*/ void GetGlobalMatrixImpl_Injected(int name, ref UnityEngine.Matrix4x4 ret);
        static /*0x3d98618*/ nint GetGlobalTextureImpl_Injected(int name);
        static /*0x3d9873c*/ void SetGlobalFloatArrayImpl_Injected(int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x3d98878*/ void SetGlobalVectorArrayImpl_Injected(int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x3d989b4*/ void SetGlobalMatrixArrayImpl_Injected(int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x3d98b20*/ void GetGlobalFloatArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3d98c7c*/ void GetGlobalVectorArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3d98dd8*/ void GetGlobalMatrixArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3d98fe4*/ void ExtractGlobalFloatArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x3d9913c*/ void ExtractGlobalVectorArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x3d99294*/ void ExtractGlobalMatrixArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x3d9aac8*/ void GetPropertyName_Injected(nint shader, int propertyIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d9abcc*/ int GetPropertyNameId_Injected(nint shader, int propertyIndex);
        static /*0x3d9acc0*/ UnityEngine.Rendering.ShaderPropertyType GetPropertyType_Injected(nint shader, int propertyIndex);
        static /*0x3d9ae60*/ void GetPropertyDescription_Injected(nint shader, int propertyIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d9af64*/ UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags_Injected(nint shader, int propertyIndex);
        static /*0x3d9b058*/ string[] GetPropertyAttributes_Injected(nint shader, int propertyIndex);
        static /*0x3d9b14c*/ int GetPropertyDefaultIntValue_Injected(nint shader, int propertyIndex);
        static /*0x3d9b25c*/ void GetPropertyDefaultValue_Injected(nint shader, int propertyIndex, ref UnityEngine.Vector4 ret);
        static /*0x3d9b360*/ UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension_Injected(nint shader, int propertyIndex);
        static /*0x3d9b500*/ void GetPropertyTextureDefaultName_Injected(nint shader, int propertyIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d9b6d4*/ bool FindTextureStackImpl_Injected(nint s, int propertyIdx, ref UnityEngine.Bindings.ManagedSpanWrapper stackName, ref int layerIndex);
        static /*0x3d9b818*/ int GetPropertyCount_Injected(nint _unity_self);
        static /*0x3d9b9fc*/ int FindPropertyIndex_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper propertyName);
        /*0x3d9a914*/ Shader();
        /*0x3d96004*/ int get_maximumLOD();
        /*0x3d960b8*/ void set_maximumLOD(int value);
        /*0x3d961e0*/ bool get_isSupported();
        /*0x3d965d8*/ UnityEngine.Rendering.LocalKeywordSpace get_keywordSpace();
        /*0x3d96ecc*/ int get_renderQueue();
        /*0x3d96f80*/ UnityEngine.DisableBatchingType get_disableBatching();
        /*0x3d97354*/ UnityEngine.Shader GetDependency(string name);
        /*0x3d975b0*/ int get_passCount();
        /*0x3d97664*/ int get_subshaderCount();
        /*0x3d97718*/ int GetPassCountInSubshader(int subshaderIndex);
        /*0x3d977dc*/ UnityEngine.Rendering.ShaderTagId FindPassTagValue(int passIndex, UnityEngine.Rendering.ShaderTagId tagName);
        /*0x3d97918*/ UnityEngine.Rendering.ShaderTagId FindPassTagValue(int subshaderIndex, int passIndex, UnityEngine.Rendering.ShaderTagId tagName);
        /*0x3d97aa4*/ UnityEngine.Rendering.ShaderTagId FindSubshaderTagValue(int subshaderIndex, UnityEngine.Rendering.ShaderTagId tagName);
        /*0x3d97888*/ int Internal_FindPassTagValue(int passIndex, int tagName);
        /*0x3d97a0c*/ int Internal_FindPassTagValueInSubShader(int subShaderIndex, int passIndex, int tagName);
        /*0x3d97ba8*/ int Internal_FindSubshaderTagValue(int subShaderIndex, int tagName);
        /*0x3d9b7a0*/ int GetPropertyCount();
        /*0x3d9b854*/ int FindPropertyIndex(string propertyName);
        /*0x3d9ba40*/ string GetPropertyName(int propertyIndex);
        /*0x3d9ba68*/ int GetPropertyNameId(int propertyIndex);
        /*0x3d9ba90*/ UnityEngine.Rendering.ShaderPropertyType GetPropertyType(int propertyIndex);
        /*0x3d9bab8*/ string GetPropertyDescription(int propertyIndex);
        /*0x3d9bae0*/ UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(int propertyIndex);
        /*0x3d9bb08*/ string[] GetPropertyAttributes(int propertyIndex);
        /*0x3d9bb30*/ float GetPropertyDefaultFloatValue(int propertyIndex);
        /*0x3d9bbc4*/ UnityEngine.Vector4 GetPropertyDefaultVectorValue(int propertyIndex);
        /*0x3d9bc54*/ UnityEngine.Vector2 GetPropertyRangeLimits(int propertyIndex);
        /*0x3d9bcf0*/ int GetPropertyDefaultIntValue(int propertyIndex);
        /*0x3d9bd80*/ UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(int propertyIndex);
        /*0x3d9be10*/ string GetPropertyTextureDefaultName(int propertyIndex);
        /*0x3d9bea0*/ bool FindTextureStack(int propertyIndex, ref string stackName, ref int layerIndex);
    }

    class Material : UnityEngine.Object
    {
        static /*0x0*/ int k_ColorId;
        static /*0x4*/ int k_MainTexId;

        static /*0x3da4cb4*/ Material();
        static /*0x3d9bf48*/ UnityEngine.Material Create(string scriptContents);
        static /*0x3d9c03c*/ void CreateWithShader(UnityEngine.Material self, UnityEngine.Shader shader);
        static /*0x3d9c15c*/ void CreateWithMaterial(UnityEngine.Material self, UnityEngine.Material source);
        static /*0x3d9c27c*/ void CreateWithString(UnityEngine.Material self);
        static /*0x3d9c3e0*/ UnityEngine.Material GetDefaultMaterial();
        static /*0x3d9c48c*/ UnityEngine.Material GetDefaultParticleMaterial();
        static /*0x3d9c538*/ UnityEngine.Material GetDefaultLineMaterial();
        static /*0x3d9c118*/ void CreateWithShader_Injected(UnityEngine.Material self, nint shader);
        static /*0x3d9c238*/ void CreateWithMaterial_Injected(UnityEngine.Material self, nint source);
        static /*0x3d9c464*/ nint GetDefaultMaterial_Injected();
        static /*0x3d9c510*/ nint GetDefaultParticleMaterial_Injected();
        static /*0x3d9c5bc*/ nint GetDefaultLineMaterial_Injected();
        static /*0x3d9c69c*/ nint get_shader_Injected(nint _unity_self);
        static /*0x3d9c7b0*/ void set_shader_Injected(nint _unity_self, nint value);
        static /*0x3d9cce8*/ int GetFirstPropertyNameIdByAttribute_Injected(nint _unity_self, UnityEngine.Rendering.ShaderPropertyFlags attributeFlag);
        static /*0x3d9cdd8*/ bool HasProperty_Injected(nint _unity_self, int nameID);
        static /*0x3d9cee8*/ bool HasFloatImpl_Injected(nint _unity_self, int name);
        static /*0x3d9d020*/ bool HasIntImpl_Injected(nint _unity_self, int name);
        static /*0x3d9d134*/ bool HasTextureImpl_Injected(nint _unity_self, int name);
        static /*0x3d9d248*/ bool HasMatrixImpl_Injected(nint _unity_self, int name);
        static /*0x3d9d35c*/ bool HasVectorImpl_Injected(nint _unity_self, int name);
        static /*0x3d9d494*/ bool HasBufferImpl_Injected(nint _unity_self, int name);
        static /*0x3d9d5a8*/ bool HasConstantBufferImpl_Injected(nint _unity_self, int name);
        static /*0x3d9d6ac*/ int get_renderQueue_Injected(nint _unity_self);
        static /*0x3d9d794*/ void set_renderQueue_Injected(nint _unity_self, int value);
        static /*0x3d9d874*/ int get_rawRenderQueue_Injected(nint _unity_self);
        static /*0x3d9da70*/ void EnableKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x3d9dc74*/ void DisableKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x3d9de88*/ bool IsKeywordEnabled_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x3d9df78*/ void EnableLocalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeyword keyword);
        static /*0x3d9e068*/ void DisableLocalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeyword keyword);
        static /*0x3d9e160*/ void SetLocalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
        static /*0x3d9e260*/ bool IsLocalKeywordEnabled_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeyword keyword);
        static /*0x3d9e3f4*/ UnityEngine.Rendering.LocalKeyword[] GetEnabledKeywords_Injected(nint _unity_self);
        static /*0x3d9e4dc*/ void SetEnabledKeywords_Injected(nint _unity_self, UnityEngine.Rendering.LocalKeyword[] keywords);
        static /*0x3d9e5c4*/ UnityEngine.MaterialGlobalIlluminationFlags get_globalIlluminationFlags_Injected(nint _unity_self);
        static /*0x3d9e6ac*/ void set_globalIlluminationFlags_Injected(nint _unity_self, UnityEngine.MaterialGlobalIlluminationFlags value);
        static /*0x3d9e78c*/ bool get_doubleSidedGI_Injected(nint _unity_self);
        static /*0x3d9e874*/ void set_doubleSidedGI_Injected(nint _unity_self, bool value);
        static /*0x3d9e8b8*/ bool get_enableInstancing_Injected(nint _unity_self);
        static /*0x3d9e9a0*/ void set_enableInstancing_Injected(nint _unity_self, bool value);
        static /*0x3d9ea80*/ int get_passCount_Injected(nint _unity_self);
        static /*0x3d9ec90*/ void SetShaderPassEnabled_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper passName, bool enabled);
        static /*0x3d9eeb4*/ bool GetShaderPassEnabled_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper passName);
        static /*0x3d9f054*/ void GetPassName_Injected(nint _unity_self, int pass, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d9f274*/ int FindPass_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper passName);
        static /*0x3d9f548*/ void SetOverrideTag_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper tag, ref UnityEngine.Bindings.ManagedSpanWrapper val);
        static /*0x3d9f8c8*/ void GetTagImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper tag, bool currentSubShaderOnly, ref UnityEngine.Bindings.ManagedSpanWrapper defaultValue, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3d9faac*/ void Lerp_Injected(nint _unity_self, nint start, nint end, float t);
        static /*0x3d9fbbc*/ bool SetPass_Injected(nint _unity_self, int pass);
        static /*0x3d9fcd8*/ void CopyPropertiesFromMaterial_Injected(nint _unity_self, nint mat);
        static /*0x3d9fdf4*/ void CopyMatchingPropertiesFromMaterial_Injected(nint _unity_self, nint mat);
        static /*0x3d9fed4*/ string[] GetShaderKeywords_Injected(nint _unity_self);
        static /*0x3d9ffbc*/ void SetShaderKeywords_Injected(nint _unity_self, string[] names);
        static /*0x3da00b4*/ string[] GetPropertyNamesImpl_Injected(nint _unity_self, int propertyType);
        static /*0x3da0194*/ int ComputeCRC_Injected(nint _unity_self);
        static /*0x3da026c*/ string[] GetTexturePropertyNames_Injected(nint _unity_self);
        static /*0x3da0420*/ void GetTexturePropertyNameIDs_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3da0510*/ void GetTexturePropertyNamesInternal_Injected(nint _unity_self, object outNames);
        static /*0x3da0600*/ void GetTexturePropertyNameIDsInternal_Injected(nint _unity_self, object outNames);
        static /*0x3da07a0*/ void SetIntImpl_Injected(nint _unity_self, int name, int value);
        static /*0x3da08b0*/ void SetFloatImpl_Injected(nint _unity_self, int name, float value);
        static /*0x3da09c8*/ void SetColorImpl_Injected(nint _unity_self, int name, ref UnityEngine.Color value);
        static /*0x3da0ad0*/ void SetMatrixImpl_Injected(nint _unity_self, int name, ref UnityEngine.Matrix4x4 value);
        static /*0x3da0c04*/ void SetTextureImpl_Injected(nint _unity_self, int name, nint value);
        static /*0x3da0d48*/ void SetRenderTextureImpl_Injected(nint _unity_self, int name, nint value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x3da0e60*/ void SetBufferImpl_Injected(nint _unity_self, int name, nint value);
        static /*0x3da0f70*/ void SetGraphicsBufferImpl_Injected(nint _unity_self, int name, nint value);
        static /*0x3da1098*/ void SetConstantBufferImpl_Injected(nint _unity_self, int name, nint value, int offset, int size);
        static /*0x3da11d8*/ void SetConstantGraphicsBufferImpl_Injected(nint _unity_self, int name, nint value, int offset, int size);
        static /*0x3da12f0*/ int GetIntImpl_Injected(nint _unity_self, int name);
        static /*0x3da13e0*/ float GetFloatImpl_Injected(nint _unity_self, int name);
        static /*0x3da14ec*/ void GetColorImpl_Injected(nint _unity_self, int name, ref UnityEngine.Color ret);
        static /*0x3da161c*/ void GetMatrixImpl_Injected(nint _unity_self, int name, ref UnityEngine.Matrix4x4 ret);
        static /*0x3da1738*/ nint GetTextureImpl_Injected(nint _unity_self, int name);
        static /*0x3da1838*/ void GetBufferImpl_Injected(nint _unity_self, int name, ref UnityEngine.GraphicsBufferHandle ret);
        static /*0x3da1948*/ void GetConstantBufferImpl_Injected(nint _unity_self, int name, ref UnityEngine.GraphicsBufferHandle ret);
        static /*0x3da1ae0*/ void SetFloatArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x3da1c80*/ void SetVectorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x3da1e20*/ void SetColorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x3da1fc0*/ void SetMatrixArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x3da21a0*/ void GetFloatArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3da2378*/ void GetVectorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3da2550*/ void GetColorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3da2728*/ void GetMatrixArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3da2828*/ int GetFloatArrayCountImpl_Injected(nint _unity_self, int name);
        static /*0x3da2918*/ int GetVectorArrayCountImpl_Injected(nint _unity_self, int name);
        static /*0x3da2a08*/ int GetColorArrayCountImpl_Injected(nint _unity_self, int name);
        static /*0x3da2af8*/ int GetMatrixArrayCountImpl_Injected(nint _unity_self, int name);
        static /*0x3da2cb0*/ void ExtractFloatArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x3da2e78*/ void ExtractVectorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x3da3040*/ void ExtractColorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x3da3208*/ void ExtractMatrixArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x3da3324*/ void GetTextureScaleAndOffsetImpl_Injected(nint _unity_self, int name, ref UnityEngine.Vector4 ret);
        static /*0x3da3430*/ void SetTextureOffsetImpl_Injected(nint _unity_self, int name, ref UnityEngine.Vector2 offset);
        static /*0x3da353c*/ void SetTextureScaleImpl_Injected(nint _unity_self, int name, ref UnityEngine.Vector2 scale);
        /*0x3d9c2b8*/ Material(UnityEngine.Shader shader);
        /*0x3d9c34c*/ Material(UnityEngine.Material source);
        /*0x3d9bf98*/ Material(string contents);
        /*0x3d9c5e4*/ UnityEngine.Shader get_shader();
        /*0x3d9c6d8*/ void set_shader(UnityEngine.Shader value);
        /*0x3d9c7f4*/ UnityEngine.Color get_color();
        /*0x3d9c918*/ void set_color(UnityEngine.Color value);
        /*0x3d9c9c0*/ UnityEngine.Texture get_mainTexture();
        /*0x3d9ca38*/ void set_mainTexture(UnityEngine.Texture value);
        /*0x3d9cab8*/ UnityEngine.Vector2 get_mainTextureOffset();
        /*0x3d9cb50*/ void set_mainTextureOffset(UnityEngine.Vector2 value);
        /*0x3d9cbe0*/ UnityEngine.Vector2 get_mainTextureScale();
        /*0x3d9cc58*/ void set_mainTextureScale(UnityEngine.Vector2 value);
        /*0x3d9c868*/ int GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags attributeFlag);
        /*0x3d9cd2c*/ bool HasProperty(int nameID);
        /*0x3d9ce1c*/ bool HasProperty(string name);
        /*0x3d9ce3c*/ bool HasFloatImpl(int name);
        /*0x3d9cf2c*/ bool HasFloat(string name);
        /*0x3d9cf4c*/ bool HasFloat(int nameID);
        /*0x3d9cf50*/ bool HasInt(string name);
        /*0x3d9cf70*/ bool HasInt(int nameID);
        /*0x3d9cf74*/ bool HasIntImpl(int name);
        /*0x3d9d064*/ bool HasInteger(string name);
        /*0x3d9d084*/ bool HasInteger(int nameID);
        /*0x3d9d088*/ bool HasTextureImpl(int name);
        /*0x3d9d178*/ bool HasTexture(string name);
        /*0x3d9d198*/ bool HasTexture(int nameID);
        /*0x3d9d19c*/ bool HasMatrixImpl(int name);
        /*0x3d9d28c*/ bool HasMatrix(string name);
        /*0x3d9d2ac*/ bool HasMatrix(int nameID);
        /*0x3d9d2b0*/ bool HasVectorImpl(int name);
        /*0x3d9d3a0*/ bool HasVector(string name);
        /*0x3d9d3c0*/ bool HasVector(int nameID);
        /*0x3d9d3c4*/ bool HasColor(string name);
        /*0x3d9d3e4*/ bool HasColor(int nameID);
        /*0x3d9d3e8*/ bool HasBufferImpl(int name);
        /*0x3d9d4d8*/ bool HasBuffer(string name);
        /*0x3d9d4f8*/ bool HasBuffer(int nameID);
        /*0x3d9d4fc*/ bool HasConstantBufferImpl(int name);
        /*0x3d9d5ec*/ bool HasConstantBuffer(string name);
        /*0x3d9d60c*/ bool HasConstantBuffer(int nameID);
        /*0x3d9d610*/ int get_renderQueue();
        /*0x3d9d6e8*/ void set_renderQueue(int value);
        /*0x3d9d7d8*/ int get_rawRenderQueue();
        /*0x3d9d8b0*/ void EnableKeyword(string keyword);
        /*0x3d9dab4*/ void DisableKeyword(string keyword);
        /*0x3d9dcb8*/ bool IsKeywordEnabled(string keyword);
        /*0x3d9decc*/ void EnableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword);
        /*0x3d9dfbc*/ void DisableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword);
        /*0x3d9e0ac*/ void SetLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword, bool value);
        /*0x3d9e1b4*/ bool IsLocalKeywordEnabled(UnityEngine.Rendering.LocalKeyword keyword);
        /*0x3d9e2a4*/ void EnableKeyword(ref UnityEngine.Rendering.LocalKeyword keyword);
        /*0x3d9e2d0*/ void DisableKeyword(ref UnityEngine.Rendering.LocalKeyword keyword);
        /*0x3d9e2fc*/ void SetKeyword(ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
        /*0x3d9e328*/ bool IsKeywordEnabled(ref UnityEngine.Rendering.LocalKeyword keyword);
        /*0x3d9e358*/ UnityEngine.Rendering.LocalKeyword[] GetEnabledKeywords();
        /*0x3d9e430*/ void SetEnabledKeywords(UnityEngine.Rendering.LocalKeyword[] keywords);
        /*0x3d9e520*/ UnityEngine.Rendering.LocalKeyword[] get_enabledKeywords();
        /*0x3d9e524*/ void set_enabledKeywords(UnityEngine.Rendering.LocalKeyword[] value);
        /*0x3d9e528*/ UnityEngine.MaterialGlobalIlluminationFlags get_globalIlluminationFlags();
        /*0x3d9e600*/ void set_globalIlluminationFlags(UnityEngine.MaterialGlobalIlluminationFlags value);
        /*0x3d9e6f0*/ bool get_doubleSidedGI();
        /*0x3d9e7c8*/ void set_doubleSidedGI(bool value);
        /*0x3d8b5b4*/ bool get_enableInstancing();
        /*0x3d9e8f4*/ void set_enableInstancing(bool value);
        /*0x3d9e9e4*/ int get_passCount();
        /*0x3d9eabc*/ void SetShaderPassEnabled(string passName, bool enabled);
        /*0x3d9ece4*/ bool GetShaderPassEnabled(string passName);
        /*0x3d9eef8*/ string GetPassName(int pass);
        /*0x3d9f0a8*/ int FindPass(string passName);
        /*0x3d9f2b8*/ void SetOverrideTag(string tag, string val);
        /*0x3d9f59c*/ string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue);
        /*0x3d9f934*/ string GetTag(string tag, bool searchFallbacks, string defaultValue);
        /*0x3d9f940*/ string GetTag(string tag, bool searchFallbacks);
        /*0x3d9f9a4*/ void Lerp(UnityEngine.Material start, UnityEngine.Material end, float t);
        /*0x3d9fb10*/ bool SetPass(int pass);
        /*0x3d9fc00*/ void CopyPropertiesFromMaterial(UnityEngine.Material mat);
        /*0x3d9fd1c*/ void CopyMatchingPropertiesFromMaterial(UnityEngine.Material mat);
        /*0x3d9fe38*/ string[] GetShaderKeywords();
        /*0x3d9ff10*/ void SetShaderKeywords(string[] names);
        /*0x3da0000*/ string[] get_shaderKeywords();
        /*0x3da0004*/ void set_shaderKeywords(string[] value);
        /*0x3da0008*/ string[] GetPropertyNamesImpl(int propertyType);
        /*0x3da00f8*/ int ComputeCRC();
        /*0x3da01d0*/ string[] GetTexturePropertyNames();
        /*0x3da02a8*/ int[] GetTexturePropertyNameIDs();
        /*0x3da0464*/ void GetTexturePropertyNamesInternal(object outNames);
        /*0x3da0554*/ void GetTexturePropertyNameIDsInternal(object outNames);
        /*0x3da0644*/ void GetTexturePropertyNames(System.Collections.Generic.List<string> outNames);
        /*0x3da0698*/ void GetTexturePropertyNameIDs(System.Collections.Generic.List<int> outNames);
        /*0x3da06ec*/ void SetIntImpl(int name, int value);
        /*0x3da07f4*/ void SetFloatImpl(int name, float value);
        /*0x3da0904*/ void SetColorImpl(int name, UnityEngine.Color value);
        /*0x3da0a1c*/ void SetMatrixImpl(int name, UnityEngine.Matrix4x4 value);
        /*0x3da0b24*/ void SetTextureImpl(int name, UnityEngine.Texture value);
        /*0x3da0c58*/ void SetRenderTextureImpl(int name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x3da0da4*/ void SetBufferImpl(int name, UnityEngine.ComputeBuffer value);
        /*0x3da0eb4*/ void SetGraphicsBufferImpl(int name, UnityEngine.GraphicsBuffer value);
        /*0x3da0fc4*/ void SetConstantBufferImpl(int name, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x3da1104*/ void SetConstantGraphicsBufferImpl(int name, UnityEngine.GraphicsBuffer value, int offset, int size);
        /*0x3da1244*/ int GetIntImpl(int name);
        /*0x3da1334*/ float GetFloatImpl(int name);
        /*0x3da1424*/ UnityEngine.Color GetColorImpl(int name);
        /*0x3da1540*/ UnityEngine.Matrix4x4 GetMatrixImpl(int name);
        /*0x3da1670*/ UnityEngine.Texture GetTextureImpl(int name);
        /*0x3da177c*/ UnityEngine.GraphicsBufferHandle GetBufferImpl(int name);
        /*0x3da188c*/ UnityEngine.GraphicsBufferHandle GetConstantBufferImpl(int name);
        /*0x3da199c*/ void SetFloatArrayImpl(int name, float[] values, int count);
        /*0x3da1b3c*/ void SetVectorArrayImpl(int name, UnityEngine.Vector4[] values, int count);
        /*0x3da1cdc*/ void SetColorArrayImpl(int name, UnityEngine.Color[] values, int count);
        /*0x3da1e7c*/ void SetMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x3da201c*/ float[] GetFloatArrayImpl(int name);
        /*0x3da21f4*/ UnityEngine.Vector4[] GetVectorArrayImpl(int name);
        /*0x3da23cc*/ UnityEngine.Color[] GetColorArrayImpl(int name);
        /*0x3da25a4*/ UnityEngine.Matrix4x4[] GetMatrixArrayImpl(int name);
        /*0x3da277c*/ int GetFloatArrayCountImpl(int name);
        /*0x3da286c*/ int GetVectorArrayCountImpl(int name);
        /*0x3da295c*/ int GetColorArrayCountImpl(int name);
        /*0x3da2a4c*/ int GetMatrixArrayCountImpl(int name);
        /*0x3da2b3c*/ void ExtractFloatArrayImpl(int name, float[] val);
        /*0x3da2d04*/ void ExtractVectorArrayImpl(int name, UnityEngine.Vector4[] val);
        /*0x3da2ecc*/ void ExtractColorArrayImpl(int name, UnityEngine.Color[] val);
        /*0x3da3094*/ void ExtractMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] val);
        /*0x3da325c*/ UnityEngine.Vector4 GetTextureScaleAndOffsetImpl(int name);
        /*0x3da3378*/ void SetTextureOffsetImpl(int name, UnityEngine.Vector2 offset);
        /*0x3da3484*/ void SetTextureScaleImpl(int name, UnityEngine.Vector2 scale);
        /*0x3da3590*/ void SetFloatArray(int name, float[] values, int count);
        /*0x3da364c*/ void SetVectorArray(int name, UnityEngine.Vector4[] values, int count);
        /*0x3da3708*/ void SetColorArray(int name, UnityEngine.Color[] values, int count);
        /*0x3da37c4*/ void SetMatrixArray(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x3da3880*/ void ExtractFloatArray(int name, System.Collections.Generic.List<float> values);
        /*0x3da39fc*/ void ExtractVectorArray(int name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        /*0x3da3b78*/ void ExtractColorArray(int name, System.Collections.Generic.List<UnityEngine.Color> values);
        /*0x3da3cf4*/ void ExtractMatrixArray(int name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        /*0x3da3e70*/ void SetInt(string name, int value);
        /*0x3da3ea0*/ void SetInt(int nameID, int value);
        /*0x3da3ea8*/ void SetFloat(string name, float value);
        /*0x3da3ed8*/ void SetFloat(int nameID, float value);
        /*0x3da3edc*/ void SetInteger(string name, int value);
        /*0x3da3f0c*/ void SetInteger(int nameID, int value);
        /*0x3da3f10*/ void SetColor(string name, UnityEngine.Color value);
        /*0x3d9c9bc*/ void SetColor(int nameID, UnityEngine.Color value);
        /*0x3da3f60*/ void SetVector(string name, UnityEngine.Vector4 value);
        /*0x3da3fb0*/ void SetVector(int nameID, UnityEngine.Vector4 value);
        /*0x3da3fb4*/ void SetMatrix(string name, UnityEngine.Matrix4x4 value);
        /*0x3da4000*/ void SetMatrix(int nameID, UnityEngine.Matrix4x4 value);
        /*0x3da402c*/ void SetTexture(string name, UnityEngine.Texture value);
        /*0x3d9cab4*/ void SetTexture(int nameID, UnityEngine.Texture value);
        /*0x3da405c*/ void SetTexture(string name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x3da4094*/ void SetTexture(int nameID, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x3da4098*/ void SetBuffer(string name, UnityEngine.ComputeBuffer value);
        /*0x3da40c8*/ void SetBuffer(int nameID, UnityEngine.ComputeBuffer value);
        /*0x3da40cc*/ void SetBuffer(string name, UnityEngine.GraphicsBuffer value);
        /*0x3da40fc*/ void SetBuffer(int nameID, UnityEngine.GraphicsBuffer value);
        /*0x3da4100*/ void SetConstantBuffer(string name, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x3da4148*/ void SetConstantBuffer(int nameID, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x3da414c*/ void SetConstantBuffer(string name, UnityEngine.GraphicsBuffer value, int offset, int size);
        /*0x3da4194*/ void SetConstantBuffer(int nameID, UnityEngine.GraphicsBuffer value, int offset, int size);
        /*0x3da4198*/ void SetFloatArray(string name, System.Collections.Generic.List<float> values);
        /*0x3da4240*/ void SetFloatArray(int nameID, System.Collections.Generic.List<float> values);
        /*0x3da42dc*/ void SetFloatArray(string name, float[] values);
        /*0x3da4318*/ void SetFloatArray(int nameID, float[] values);
        /*0x3da432c*/ void SetColorArray(string name, System.Collections.Generic.List<UnityEngine.Color> values);
        /*0x3da43d4*/ void SetColorArray(int nameID, System.Collections.Generic.List<UnityEngine.Color> values);
        /*0x3da4470*/ void SetColorArray(string name, UnityEngine.Color[] values);
        /*0x3da44ac*/ void SetColorArray(int nameID, UnityEngine.Color[] values);
        /*0x3da44c0*/ void SetVectorArray(string name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        /*0x3da4568*/ void SetVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
        /*0x3da4604*/ void SetVectorArray(string name, UnityEngine.Vector4[] values);
        /*0x3da4640*/ void SetVectorArray(int nameID, UnityEngine.Vector4[] values);
        /*0x3da4654*/ void SetMatrixArray(string name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        /*0x3da46fc*/ void SetMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        /*0x3da4798*/ void SetMatrixArray(string name, UnityEngine.Matrix4x4[] values);
        /*0x3da47d4*/ void SetMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
        /*0x3da47e8*/ int GetInt(string name);
        /*0x3da4824*/ int GetInt(int nameID);
        /*0x3da484c*/ float GetFloat(string name);
        /*0x3da486c*/ float GetFloat(int nameID);
        /*0x3da4870*/ int GetInteger(string name);
        /*0x3da4890*/ int GetInteger(int nameID);
        /*0x3da4894*/ UnityEngine.Color GetColor(string name);
        /*0x3d9c914*/ UnityEngine.Color GetColor(int nameID);
        /*0x3da48b4*/ UnityEngine.Vector4 GetVector(string name);
        /*0x3da48d4*/ UnityEngine.Vector4 GetVector(int nameID);
        /*0x3da48d8*/ UnityEngine.Matrix4x4 GetMatrix(string name);
        /*0x3da4924*/ UnityEngine.Matrix4x4 GetMatrix(int nameID);
        /*0x3da4954*/ UnityEngine.Texture GetTexture(string name);
        /*0x3d9ca34*/ UnityEngine.Texture GetTexture(int nameID);
        /*0x3da4974*/ UnityEngine.GraphicsBufferHandle GetBuffer(string name);
        /*0x3da4994*/ UnityEngine.GraphicsBufferHandle GetConstantBuffer(string name);
        /*0x3da49b4*/ float[] GetFloatArray(string name);
        /*0x3da49d4*/ float[] GetFloatArray(int nameID);
        /*0x3da4a10*/ UnityEngine.Color[] GetColorArray(string name);
        /*0x3da4a30*/ UnityEngine.Color[] GetColorArray(int nameID);
        /*0x3da4a6c*/ UnityEngine.Vector4[] GetVectorArray(string name);
        /*0x3da4a8c*/ UnityEngine.Vector4[] GetVectorArray(int nameID);
        /*0x3da4ac8*/ UnityEngine.Matrix4x4[] GetMatrixArray(string name);
        /*0x3da4ae8*/ UnityEngine.Matrix4x4[] GetMatrixArray(int nameID);
        /*0x3da4b24*/ void GetFloatArray(string name, System.Collections.Generic.List<float> values);
        /*0x3da4b54*/ void GetFloatArray(int nameID, System.Collections.Generic.List<float> values);
        /*0x3da4b58*/ void GetColorArray(string name, System.Collections.Generic.List<UnityEngine.Color> values);
        /*0x3da4b88*/ void GetColorArray(int nameID, System.Collections.Generic.List<UnityEngine.Color> values);
        /*0x3da4b8c*/ void GetVectorArray(string name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        /*0x3da4bbc*/ void GetVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
        /*0x3da4bc0*/ void GetMatrixArray(string name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        /*0x3da4bf0*/ void GetMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        /*0x3da4bf4*/ void SetTextureOffset(string name, UnityEngine.Vector2 value);
        /*0x3d9cbdc*/ void SetTextureOffset(int nameID, UnityEngine.Vector2 value);
        /*0x3da4c2c*/ void SetTextureScale(string name, UnityEngine.Vector2 value);
        /*0x3d9cce4*/ void SetTextureScale(int nameID, UnityEngine.Vector2 value);
        /*0x3da4c64*/ UnityEngine.Vector2 GetTextureOffset(string name);
        /*0x3d9cb38*/ UnityEngine.Vector2 GetTextureOffset(int nameID);
        /*0x3da4c90*/ UnityEngine.Vector2 GetTextureScale(string name);
        /*0x3d9cc54*/ UnityEngine.Vector2 GetTextureScale(int nameID);
        /*0x3da4cb0*/ string[] GetPropertyNames(UnityEngine.MaterialPropertyType type);
    }

    struct GraphicsBufferHandle : System.IEquatable<UnityEngine.GraphicsBufferHandle>
    {
        /*0x10*/ uint value;

        /*0x3da4d4c*/ int GetHashCode();
        /*0x3da4d54*/ bool Equals(object obj);
        /*0x3da4dcc*/ bool Equals(UnityEngine.GraphicsBufferHandle other);
    }

    class GraphicsBuffer : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;

        static /*0x3da4fd0*/ bool RequiresCompute(UnityEngine.GraphicsBuffer.Target target);
        static /*0x3da4fdc*/ bool IsVertexIndexOrCopyOnly(UnityEngine.GraphicsBuffer.Target target);
        static /*0x3da4fe8*/ nint InitBuffer(UnityEngine.GraphicsBuffer.Target target, UnityEngine.GraphicsBuffer.UsageFlags usageFlags, int count, int stride);
        static /*0x3da4f88*/ void DestroyBuffer(UnityEngine.GraphicsBuffer buf);
        static /*0x3da543c*/ bool IsValidBuffer(UnityEngine.GraphicsBuffer buf);
        static /*0x3da5044*/ void DestroyBuffer_Injected(nint buf);
        static /*0x3da5484*/ bool IsValidBuffer_Injected(nint buf);
        static /*0x3da5560*/ int get_count_Injected(nint _unity_self);
        static /*0x3da55ec*/ int get_stride_Injected(nint _unity_self);
        static /*0x3da5678*/ UnityEngine.GraphicsBuffer.UsageFlags GetUsageFlags_Injected(nint _unity_self);
        static /*0x3da5718*/ void get_bufferHandle_Injected(nint _unity_self, ref UnityEngine.GraphicsBufferHandle ret);
        static /*0x3da5aa4*/ void InternalSetNativeData_Injected(nint _unity_self, nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
        static /*0x3da5b18*/ void InternalSetData_Injected(nint _unity_self, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
        static /*0x3da5bf4*/ void* BeginBufferWrite_Injected(nint _unity_self, int offset, int size);
        static /*0x3da5ca0*/ void EndBufferWrite_Injected(nint _unity_self, int bytesWritten);
        static /*0x3da5e78*/ void SetName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        /*0x3da5080*/ GraphicsBuffer(nint ptr);
        /*0x3da50a8*/ GraphicsBuffer(UnityEngine.GraphicsBuffer.Target target, int count, int stride);
        /*0x3da53ec*/ GraphicsBuffer(UnityEngine.GraphicsBuffer.Target target, UnityEngine.GraphicsBuffer.UsageFlags usageFlags, int count, int stride);
        /*0x3da4ddc*/ void Finalize();
        /*0x3da4f24*/ void Dispose();
        /*0x3da4e64*/ void Dispose(bool disposing);
        /*0x3da50f4*/ void InternalInitialization(UnityEngine.GraphicsBuffer.Target target, UnityEngine.GraphicsBuffer.UsageFlags usageFlags, int count, int stride);
        /*0x3da5438*/ void Release();
        /*0x3da54c0*/ bool IsValid();
        /*0x3da5510*/ int get_count();
        /*0x3da559c*/ int get_stride();
        /*0x3da5628*/ UnityEngine.GraphicsBuffer.UsageFlags GetUsageFlags();
        /*0x3da56b4*/ UnityEngine.GraphicsBuffer.UsageFlags get_usageFlags();
        /*0x3da56b8*/ UnityEngine.GraphicsBufferHandle get_bufferHandle();
        /*0x1ffc854*/ void SetData<T>(Unity.Collections.NativeArray<T> data);
        /*0x3da575c*/ void SetData(System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
        /*0x1ffc854*/ void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
        /*0x3da5a1c*/ void InternalSetNativeData(nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
        /*0x3da5994*/ void InternalSetData(System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
        /*0x3da5b8c*/ void* BeginBufferWrite(int offset, int size);
        /*0x1ffc854*/ Unity.Collections.NativeArray<T> LockBufferForWrite<T>(int bufferStartIndex, int count);
        /*0x3da5c48*/ void EndBufferWrite(int bytesWritten);
        /*0x1f30b78*/ void UnlockBufferAfterWrite<T>(int countWritten);
        /*0x3da5ce4*/ void set_name(string value);
        /*0x3da5ce8*/ void SetName(string name);

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

        class BindingsMarshaller
        {
            static /*0x3da5ebc*/ UnityEngine.GraphicsBuffer ConvertToManaged(nint ptr);
            static /*0x3da5f18*/ nint ConvertToNative(UnityEngine.GraphicsBuffer graphicsBuffer);
        }
    }

    class Flare : UnityEngine.Object
    {
    }

    struct LightBakingOutput
    {
        /*0x10*/ int probeOcclusionLightIndex;
        /*0x14*/ int occlusionMaskChannel;
        /*0x18*/ UnityEngine.LightmapBakeType lightmapBakeType;
        /*0x1c*/ UnityEngine.MixedLightingMode mixedLightingMode;
        /*0x20*/ bool isBaked;
    }

    enum LightShadowCasterMode
    {
        Default = 0,
        NonLightmappedOnly = 1,
        Everything = 2,
    }

    class Light : UnityEngine.Behaviour
    {
        /*0x18*/ UnityEngine.LightShape <shape>k__BackingField;
        /*0x1c*/ int m_BakedIndex;

        static /*0x3daa390*/ int get_pixelLightCount();
        static /*0x3daa3b8*/ void set_pixelLightCount(int value);
        static /*0x3daa3f4*/ UnityEngine.Light[] GetLights(UnityEngine.LightType type, int layer);
        static /*0x3da5fa4*/ UnityEngine.LightType get_type_Injected(nint _unity_self);
        static /*0x3da6060*/ void set_type_Injected(nint _unity_self, UnityEngine.LightType value);
        static /*0x3da612c*/ float get_spotAngle_Injected(nint _unity_self);
        static /*0x3da61f0*/ void set_spotAngle_Injected(nint _unity_self, float value);
        static /*0x3da62b4*/ float get_innerSpotAngle_Injected(nint _unity_self);
        static /*0x3da6378*/ void set_innerSpotAngle_Injected(nint _unity_self, float value);
        static /*0x3da6458*/ void get_color_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x3da652c*/ void set_color_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x3da65e8*/ float get_colorTemperature_Injected(nint _unity_self);
        static /*0x3da66ac*/ void set_colorTemperature_Injected(nint _unity_self, float value);
        static /*0x3da6770*/ bool get_useColorTemperature_Injected(nint _unity_self);
        static /*0x3da682c*/ void set_useColorTemperature_Injected(nint _unity_self, bool value);
        static /*0x3da68e8*/ float get_intensity_Injected(nint _unity_self);
        static /*0x3da69ac*/ void set_intensity_Injected(nint _unity_self, float value);
        static /*0x3da6a70*/ float get_bounceIntensity_Injected(nint _unity_self);
        static /*0x3da6b34*/ void set_bounceIntensity_Injected(nint _unity_self, float value);
        static /*0x3da6bf8*/ UnityEngine.Rendering.LightUnit get_lightUnit_Injected(nint _unity_self);
        static /*0x3da6cb4*/ void set_lightUnit_Injected(nint _unity_self, UnityEngine.Rendering.LightUnit value);
        static /*0x3da6d70*/ float get_luxAtDistance_Injected(nint _unity_self);
        static /*0x3da6e34*/ void set_luxAtDistance_Injected(nint _unity_self, float value);
        static /*0x3da6ef8*/ bool get_enableSpotReflector_Injected(nint _unity_self);
        static /*0x3da6fb4*/ void set_enableSpotReflector_Injected(nint _unity_self, bool value);
        static /*0x3da7070*/ bool get_useBoundingSphereOverride_Injected(nint _unity_self);
        static /*0x3da712c*/ void set_useBoundingSphereOverride_Injected(nint _unity_self, bool value);
        static /*0x3da7204*/ void get_boundingSphereOverride_Injected(nint _unity_self, ref UnityEngine.Vector4 ret);
        static /*0x3da72d8*/ void set_boundingSphereOverride_Injected(nint _unity_self, ref UnityEngine.Vector4 value);
        static /*0x3da7394*/ bool get_useViewFrustumForShadowCasterCull_Injected(nint _unity_self);
        static /*0x3da7450*/ void set_useViewFrustumForShadowCasterCull_Injected(nint _unity_self, bool value);
        static /*0x3da750c*/ bool get_forceVisible_Injected(nint _unity_self);
        static /*0x3da75c8*/ void set_forceVisible_Injected(nint _unity_self, bool value);
        static /*0x3da7684*/ int get_shadowCustomResolution_Injected(nint _unity_self);
        static /*0x3da7740*/ void set_shadowCustomResolution_Injected(nint _unity_self, int value);
        static /*0x3da77fc*/ float get_shadowBias_Injected(nint _unity_self);
        static /*0x3da78c0*/ void set_shadowBias_Injected(nint _unity_self, float value);
        static /*0x3da7984*/ float get_shadowNormalBias_Injected(nint _unity_self);
        static /*0x3da7a48*/ void set_shadowNormalBias_Injected(nint _unity_self, float value);
        static /*0x3da7b0c*/ float get_shadowNearPlane_Injected(nint _unity_self);
        static /*0x3da7bd0*/ void set_shadowNearPlane_Injected(nint _unity_self, float value);
        static /*0x3da7c94*/ bool get_useShadowMatrixOverride_Injected(nint _unity_self);
        static /*0x3da7d50*/ void set_useShadowMatrixOverride_Injected(nint _unity_self, bool value);
        static /*0x3da7e3c*/ void get_shadowMatrixOverride_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x3da7f00*/ void set_shadowMatrixOverride_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
        static /*0x3da7fbc*/ float get_range_Injected(nint _unity_self);
        static /*0x3da8080*/ void set_range_Injected(nint _unity_self, float value);
        static /*0x3da8144*/ float get_dilatedRange_Injected(nint _unity_self);
        static /*0x3da8214*/ nint get_flare_Injected(nint _unity_self);
        static /*0x3da8304*/ void set_flare_Injected(nint _unity_self, nint value);
        static /*0x3da83ec*/ void get_bakingOutput_Injected(nint _unity_self, ref UnityEngine.LightBakingOutput ret);
        static /*0x3da84b0*/ void set_bakingOutput_Injected(nint _unity_self, ref UnityEngine.LightBakingOutput value);
        static /*0x3da856c*/ int get_cullingMask_Injected(nint _unity_self);
        static /*0x3da8628*/ void set_cullingMask_Injected(nint _unity_self, int value);
        static /*0x3da86e4*/ int get_renderingLayerMask_Injected(nint _unity_self);
        static /*0x3da87a0*/ void set_renderingLayerMask_Injected(nint _unity_self, int value);
        static /*0x3da885c*/ UnityEngine.LightShadowCasterMode get_lightShadowCasterMode_Injected(nint _unity_self);
        static /*0x3da8918*/ void set_lightShadowCasterMode_Injected(nint _unity_self, UnityEngine.LightShadowCasterMode value);
        static /*0x3da89d4*/ void Reset_Injected(nint _unity_self);
        static /*0x3da8a88*/ UnityEngine.LightShadows get_shadows_Injected(nint _unity_self);
        static /*0x3da8b44*/ void set_shadows_Injected(nint _unity_self, UnityEngine.LightShadows value);
        static /*0x3da8c00*/ float get_shadowStrength_Injected(nint _unity_self);
        static /*0x3da8cc4*/ void set_shadowStrength_Injected(nint _unity_self, float value);
        static /*0x3da8d88*/ UnityEngine.Rendering.LightShadowResolution get_shadowResolution_Injected(nint _unity_self);
        static /*0x3da8e44*/ void set_shadowResolution_Injected(nint _unity_self, UnityEngine.Rendering.LightShadowResolution value);
        static /*0x3da8ff4*/ void get_layerShadowCullDistances_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3da9138*/ void set_layerShadowCullDistances_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x3da91f4*/ float get_cookieSize_Injected(nint _unity_self);
        static /*0x3da92b8*/ void set_cookieSize_Injected(nint _unity_self, float value);
        static /*0x3da9398*/ nint get_cookie_Injected(nint _unity_self);
        static /*0x3da9488*/ void set_cookie_Injected(nint _unity_self, nint value);
        static /*0x3da9544*/ UnityEngine.LightRenderMode get_renderMode_Injected(nint _unity_self);
        static /*0x3da9600*/ void set_renderMode_Injected(nint _unity_self, UnityEngine.LightRenderMode value);
        static /*0x3da96dc*/ void get_areaSize_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3da97a4*/ void set_areaSize_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3da9990*/ void AddCommandBufferInternal_Injected(nint _unity_self, UnityEngine.Rendering.LightEvent evt, nint buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask);
        static /*0x3da9bb0*/ void AddCommandBufferAsyncInternal_Injected(nint _unity_self, UnityEngine.Rendering.LightEvent evt, nint buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType);
        static /*0x3da9da4*/ void RemoveCommandBufferInternal_Injected(nint _unity_self, UnityEngine.Rendering.LightEvent evt, nint buffer);
        static /*0x3da9f60*/ void RemoveCommandBuffersInternal_Injected(nint _unity_self, UnityEngine.Rendering.LightEvent evt);
        static /*0x3daa0f4*/ void RemoveAllCommandBuffersInternal_Injected(nint _unity_self);
        static /*0x3daa298*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffersInternal_Injected(nint _unity_self, UnityEngine.Rendering.LightEvent evt);
        static /*0x3daa354*/ int get_commandBufferCount_Injected(nint _unity_self);
        /*0x3daa45c*/ Light();
        /*0x3da5f2c*/ UnityEngine.LightType get_type();
        /*0x3da5fe0*/ void set_type(UnityEngine.LightType value);
        /*0x3da60a4*/ UnityEngine.LightShape get_shape();
        /*0x3da60ac*/ void set_shape(UnityEngine.LightShape value);
        /*0x3da60b4*/ float get_spotAngle();
        /*0x3da6168*/ void set_spotAngle(float value);
        /*0x3da623c*/ float get_innerSpotAngle();
        /*0x3da62f0*/ void set_innerSpotAngle(float value);
        /*0x3da63c4*/ UnityEngine.Color get_color();
        /*0x3da649c*/ void set_color(UnityEngine.Color value);
        /*0x3da6570*/ float get_colorTemperature();
        /*0x3da6624*/ void set_colorTemperature(float value);
        /*0x3da66f8*/ bool get_useColorTemperature();
        /*0x3da67ac*/ void set_useColorTemperature(bool value);
        /*0x3da6870*/ float get_intensity();
        /*0x3da6924*/ void set_intensity(float value);
        /*0x3da69f8*/ float get_bounceIntensity();
        /*0x3da6aac*/ void set_bounceIntensity(float value);
        /*0x3da6b80*/ UnityEngine.Rendering.LightUnit get_lightUnit();
        /*0x3da6c34*/ void set_lightUnit(UnityEngine.Rendering.LightUnit value);
        /*0x3da6cf8*/ float get_luxAtDistance();
        /*0x3da6dac*/ void set_luxAtDistance(float value);
        /*0x3da6e80*/ bool get_enableSpotReflector();
        /*0x3da6f34*/ void set_enableSpotReflector(bool value);
        /*0x3da6ff8*/ bool get_useBoundingSphereOverride();
        /*0x3da70ac*/ void set_useBoundingSphereOverride(bool value);
        /*0x3da7170*/ UnityEngine.Vector4 get_boundingSphereOverride();
        /*0x3da7248*/ void set_boundingSphereOverride(UnityEngine.Vector4 value);
        /*0x3da731c*/ bool get_useViewFrustumForShadowCasterCull();
        /*0x3da73d0*/ void set_useViewFrustumForShadowCasterCull(bool value);
        /*0x3da7494*/ bool get_forceVisible();
        /*0x3da7548*/ void set_forceVisible(bool value);
        /*0x3da760c*/ int get_shadowCustomResolution();
        /*0x3da76c0*/ void set_shadowCustomResolution(int value);
        /*0x3da7784*/ float get_shadowBias();
        /*0x3da7838*/ void set_shadowBias(float value);
        /*0x3da790c*/ float get_shadowNormalBias();
        /*0x3da79c0*/ void set_shadowNormalBias(float value);
        /*0x3da7a94*/ float get_shadowNearPlane();
        /*0x3da7b48*/ void set_shadowNearPlane(float value);
        /*0x3da7c1c*/ bool get_useShadowMatrixOverride();
        /*0x3da7cd0*/ void set_useShadowMatrixOverride(bool value);
        /*0x3da7d94*/ UnityEngine.Matrix4x4 get_shadowMatrixOverride();
        /*0x3da7e80*/ void set_shadowMatrixOverride(UnityEngine.Matrix4x4 value);
        /*0x3da7f44*/ float get_range();
        /*0x3da7ff8*/ void set_range(float value);
        /*0x3da80cc*/ float get_dilatedRange();
        /*0x3da8180*/ UnityEngine.Flare get_flare();
        /*0x3da8250*/ void set_flare(UnityEngine.Flare value);
        /*0x3da8348*/ UnityEngine.LightBakingOutput get_bakingOutput();
        /*0x3da8430*/ void set_bakingOutput(UnityEngine.LightBakingOutput value);
        /*0x3da84f4*/ int get_cullingMask();
        /*0x3da85a8*/ void set_cullingMask(int value);
        /*0x3da866c*/ int get_renderingLayerMask();
        /*0x3da8720*/ void set_renderingLayerMask(int value);
        /*0x3da87e4*/ UnityEngine.LightShadowCasterMode get_lightShadowCasterMode();
        /*0x3da8898*/ void set_lightShadowCasterMode(UnityEngine.LightShadowCasterMode value);
        /*0x3da895c*/ void Reset();
        /*0x3da8a10*/ UnityEngine.LightShadows get_shadows();
        /*0x3da8ac4*/ void set_shadows(UnityEngine.LightShadows value);
        /*0x3da8b88*/ float get_shadowStrength();
        /*0x3da8c3c*/ void set_shadowStrength(float value);
        /*0x3da8d10*/ UnityEngine.Rendering.LightShadowResolution get_shadowResolution();
        /*0x3da8dc4*/ void set_shadowResolution(UnityEngine.Rendering.LightShadowResolution value);
        /*0x3da8e88*/ float get_shadowSoftness();
        /*0x3da8e90*/ void set_shadowSoftness(float value);
        /*0x3da8e94*/ float get_shadowSoftnessFade();
        /*0x3da8e9c*/ void set_shadowSoftnessFade(float value);
        /*0x3da8ea0*/ float[] get_layerShadowCullDistances();
        /*0x3da9038*/ void set_layerShadowCullDistances(float[] value);
        /*0x3da917c*/ float get_cookieSize();
        /*0x3da9230*/ void set_cookieSize(float value);
        /*0x3da9304*/ UnityEngine.Texture get_cookie();
        /*0x3da93d4*/ void set_cookie(UnityEngine.Texture value);
        /*0x3da94cc*/ UnityEngine.LightRenderMode get_renderMode();
        /*0x3da9580*/ void set_renderMode(UnityEngine.LightRenderMode value);
        /*0x3da9644*/ int get_bakedIndex();
        /*0x3da964c*/ void set_bakedIndex(int value);
        /*0x3da9654*/ UnityEngine.Vector2 get_areaSize();
        /*0x3da9720*/ void set_areaSize(UnityEngine.Vector2 value);
        /*0x3da97e8*/ void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x3da97f0*/ void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask);
        /*0x3da98f0*/ void AddCommandBufferInternal(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask);
        /*0x3da99ec*/ void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType);
        /*0x3da99f8*/ void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType);
        /*0x3da9b00*/ void AddCommandBufferAsyncInternal(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType);
        /*0x3da9c1c*/ void RemoveCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x3da9d0c*/ void RemoveCommandBufferInternal(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x3da9df8*/ void RemoveCommandBuffers(UnityEngine.Rendering.LightEvent evt);
        /*0x3da9ee0*/ void RemoveCommandBuffersInternal(UnityEngine.Rendering.LightEvent evt);
        /*0x3da9fa4*/ void RemoveAllCommandBuffers();
        /*0x3daa07c*/ void RemoveAllCommandBuffersInternal();
        /*0x3daa130*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.LightEvent evt);
        /*0x3daa218*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffersInternal(UnityEngine.Rendering.LightEvent evt);
        /*0x3daa2dc*/ int get_commandBufferCount();
        /*0x3daa438*/ float get_shadowConstantBias();
        /*0x3daa440*/ void set_shadowConstantBias(float value);
        /*0x3daa444*/ float get_shadowObjectSizeBias();
        /*0x3daa44c*/ void set_shadowObjectSizeBias(float value);
        /*0x3daa450*/ bool get_attenuate();
        /*0x3daa458*/ void set_attenuate(bool value);
    }

    class Skybox : UnityEngine.Behaviour
    {
        static /*0x3daac10*/ nint get_material_Injected(nint _unity_self);
        /*0x3daab7c*/ UnityEngine.Material get_material();
    }

    class MeshFilter : UnityEngine.Component
    {
        static /*0x3daace4*/ nint get_sharedMesh_Injected(nint _unity_self);
        static /*0x3daadd4*/ void set_sharedMesh_Injected(nint _unity_self, nint value);
        static /*0x3daaeac*/ nint get_mesh_Injected(nint _unity_self);
        static /*0x3daaf9c*/ void set_mesh_Injected(nint _unity_self, nint value);
        /*0x3daafe0*/ MeshFilter();
        /*0x3daac4c*/ void DontStripMeshFilter();
        /*0x3daac50*/ UnityEngine.Mesh get_sharedMesh();
        /*0x3daad20*/ void set_sharedMesh(UnityEngine.Mesh value);
        /*0x3daae18*/ UnityEngine.Mesh get_mesh();
        /*0x3daaee8*/ void set_mesh(UnityEngine.Mesh value);
    }

    enum RenderingPath
    {
        UsePlayerSettings = -1,
        VertexLit = 0,
        Forward = 1,
        DeferredLighting = 2,
        DeferredShading = 3,
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
        Pyramid = 5,
        Box = 6,
        Tube = 7,
    }

    enum LightShape
    {
        Cone = 0,
        Pyramid = 1,
        Box = 2,
    }

    enum LightRenderMode
    {
        Auto = 0,
        ForcePixel = 1,
        ForceVertex = 2,
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

    enum SkinWeights
    {
        None = 0,
        OneBone = 1,
        TwoBones = 2,
        FourBones = 4,
        Unlimited = 255,
    }

    enum MeshTopology
    {
        Triangles = 0,
        Quads = 2,
        Lines = 3,
        LineStrip = 4,
        Points = 5,
    }

    enum SkinQuality
    {
        Auto = 0,
        Bone1 = 1,
        Bone2 = 2,
        Bone4 = 4,
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
        R8_SIGNED = 75,
        RG16_SIGNED = 76,
        RGB24_SIGNED = 77,
        RGBA32_SIGNED = 78,
        R16_SIGNED = 79,
        RG32_SIGNED = 80,
        RGB48_SIGNED = 81,
        RGBA64_SIGNED = 82,
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
        DynamicallyScalableExplicit = 131072,
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

    enum MaterialGlobalIlluminationFlags
    {
        None = 0,
        RealtimeEmissive = 1,
        BakedEmissive = 2,
        EmissiveIsBlack = 4,
        AnyEmissive = 3,
    }

    class LightProbeProxyVolume : UnityEngine.Behaviour
    {
    }

    enum MotionVectorGenerationMode
    {
        Camera = 0,
        Object = 1,
        ForceNoMotion = 2,
    }

    enum LineTextureMode
    {
        Stretch = 0,
        Tile = 1,
        DistributePerSegment = 2,
        RepeatPerSegment = 3,
        Static = 4,
    }

    enum LineAlignment
    {
        View = 0,
        Local = 1,
        TransformZ = 1,
    }

    class SkinnedMeshRenderer : UnityEngine.Renderer
    {
        static /*0x3dab060*/ UnityEngine.SkinQuality get_quality_Injected(nint _unity_self);
        static /*0x3dab11c*/ void set_quality_Injected(nint _unity_self, UnityEngine.SkinQuality value);
        static /*0x3dab1d8*/ bool get_updateWhenOffscreen_Injected(nint _unity_self);
        static /*0x3dab294*/ void set_updateWhenOffscreen_Injected(nint _unity_self, bool value);
        static /*0x3dab350*/ bool get_forceMatrixRecalculationPerRender_Injected(nint _unity_self);
        static /*0x3dab40c*/ void set_forceMatrixRecalculationPerRender_Injected(nint _unity_self, bool value);
        static /*0x3dab4e4*/ nint get_rootBone_Injected(nint _unity_self);
        static /*0x3dab5d4*/ void set_rootBone_Injected(nint _unity_self, nint value);
        static /*0x3dab690*/ UnityEngine.Transform[] get_bones_Injected(nint _unity_self);
        static /*0x3dab74c*/ void set_bones_Injected(nint _unity_self, UnityEngine.Transform[] value);
        static /*0x3dab824*/ nint get_sharedMesh_Injected(nint _unity_self);
        static /*0x3dab914*/ void set_sharedMesh_Injected(nint _unity_self, nint value);
        static /*0x3dab9d0*/ bool get_skinnedMotionVectors_Injected(nint _unity_self);
        static /*0x3daba8c*/ void set_skinnedMotionVectors_Injected(nint _unity_self, bool value);
        static /*0x3dabb50*/ float GetBlendShapeWeight_Injected(nint _unity_self, int index);
        static /*0x3dabc24*/ void SetBlendShapeWeight_Injected(nint _unity_self, int index, float value);
        static /*0x3dabd74*/ void BakeMesh_Injected(nint _unity_self, nint mesh, bool useScale);
        static /*0x3dac020*/ nint GetVertexBufferImpl_Injected(nint _unity_self);
        static /*0x3dac05c*/ nint GetPreviousVertexBufferImpl_Injected(nint _unity_self);
        static /*0x3dac110*/ UnityEngine.GraphicsBuffer.Target get_vertexBufferTarget_Injected(nint _unity_self);
        static /*0x3dac1cc*/ void set_vertexBufferTarget_Injected(nint _unity_self, UnityEngine.GraphicsBuffer.Target value);
        /*0x3dac210*/ SkinnedMeshRenderer();
        /*0x3daafe8*/ UnityEngine.SkinQuality get_quality();
        /*0x3dab09c*/ void set_quality(UnityEngine.SkinQuality value);
        /*0x3dab160*/ bool get_updateWhenOffscreen();
        /*0x3dab214*/ void set_updateWhenOffscreen(bool value);
        /*0x3dab2d8*/ bool get_forceMatrixRecalculationPerRender();
        /*0x3dab38c*/ void set_forceMatrixRecalculationPerRender(bool value);
        /*0x3dab450*/ UnityEngine.Transform get_rootBone();
        /*0x3dab520*/ void set_rootBone(UnityEngine.Transform value);
        /*0x3dab618*/ UnityEngine.Transform[] get_bones();
        /*0x3dab6cc*/ void set_bones(UnityEngine.Transform[] value);
        /*0x3dab790*/ UnityEngine.Mesh get_sharedMesh();
        /*0x3dab860*/ void set_sharedMesh(UnityEngine.Mesh value);
        /*0x3dab958*/ bool get_skinnedMotionVectors();
        /*0x3daba0c*/ void set_skinnedMotionVectors(bool value);
        /*0x3dabad0*/ float GetBlendShapeWeight(int index);
        /*0x3dabb94*/ void SetBlendShapeWeight(int index, float value);
        /*0x3dabc78*/ void BakeMesh(UnityEngine.Mesh mesh);
        /*0x3dabc80*/ void BakeMesh(UnityEngine.Mesh mesh, bool useScale);
        /*0x3dabdc8*/ UnityEngine.GraphicsBuffer GetVertexBuffer();
        /*0x3dabef4*/ UnityEngine.GraphicsBuffer GetPreviousVertexBuffer();
        /*0x3dabe64*/ UnityEngine.GraphicsBuffer GetVertexBufferImpl();
        /*0x3dabf90*/ UnityEngine.GraphicsBuffer GetPreviousVertexBufferImpl();
        /*0x3dac098*/ UnityEngine.GraphicsBuffer.Target get_vertexBufferTarget();
        /*0x3dac14c*/ void set_vertexBufferTarget(UnityEngine.GraphicsBuffer.Target value);
    }

    class MeshRenderer : UnityEngine.Renderer
    {
        static /*0x3dac2b0*/ nint get_additionalVertexStreams_Injected(nint _unity_self);
        static /*0x3dac3a0*/ void set_additionalVertexStreams_Injected(nint _unity_self, nint value);
        static /*0x3dac478*/ nint get_enlightenVertexStream_Injected(nint _unity_self);
        static /*0x3dac568*/ void set_enlightenVertexStream_Injected(nint _unity_self, nint value);
        static /*0x3dac624*/ int get_subMeshStartIndex_Injected(nint _unity_self);
        /*0x3dac660*/ MeshRenderer();
        /*0x3dac218*/ void DontStripMeshRenderer();
        /*0x3dac21c*/ UnityEngine.Mesh get_additionalVertexStreams();
        /*0x3dac2ec*/ void set_additionalVertexStreams(UnityEngine.Mesh value);
        /*0x3dac3e4*/ UnityEngine.Mesh get_enlightenVertexStream();
        /*0x3dac4b4*/ void set_enlightenVertexStream(UnityEngine.Mesh value);
        /*0x3dac5ac*/ int get_subMeshStartIndex();
    }

    enum LODFadeMode
    {
        None = 0,
        CrossFade = 1,
        SpeedTree = 2,
    }

    class LODGroup : UnityEngine.Component
    {
    }

    class Mesh : UnityEngine.Object
    {
        static /*0x3dac668*/ void Internal_Create(UnityEngine.Mesh mono);
        static /*0x3dac724*/ UnityEngine.Mesh FromInstanceID(int id);
        static /*0x3db3170*/ UnityEngine.Rendering.VertexAttribute GetUVChannel(int uvIndex);
        static /*0x3db31e4*/ int DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute channel);
        static /*0x3db5620*/ UnityEngine.Mesh.MeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh mesh);
        static /*0x3db5868*/ UnityEngine.Mesh.MeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh[] meshes);
        static /*0x3db5be4*/ UnityEngine.Mesh.MeshDataArray AcquireReadOnlyMeshData(System.Collections.Generic.List<UnityEngine.Mesh> meshes);
        static /*0x3db5ce4*/ UnityEngine.Mesh.MeshDataArray AllocateWritableMeshData(int meshCount);
        static /*0x3db5e58*/ UnityEngine.Mesh.MeshDataArray AllocateWritableMeshData(UnityEngine.Mesh mesh);
        static /*0x3db5e88*/ UnityEngine.Mesh.MeshDataArray AllocateWritableMeshData(UnityEngine.Mesh[] meshes);
        static /*0x3db5f24*/ UnityEngine.Mesh.MeshDataArray AllocateWritableMeshData(System.Collections.Generic.List<UnityEngine.Mesh> meshes);
        static /*0x3db6024*/ void ApplyAndDisposeWritableMeshData(UnityEngine.Mesh.MeshDataArray data, UnityEngine.Mesh mesh, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x3db6270*/ void ApplyAndDisposeWritableMeshData(UnityEngine.Mesh.MeshDataArray data, UnityEngine.Mesh[] meshes, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x3db65a0*/ void ApplyAndDisposeWritableMeshData(UnityEngine.Mesh.MeshDataArray data, System.Collections.Generic.List<UnityEngine.Mesh> meshes, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x3dac790*/ nint FromInstanceID_Injected(int id);
        static /*0x3dac844*/ UnityEngine.Rendering.IndexFormat get_indexFormat_Injected(nint _unity_self);
        static /*0x3dac900*/ void set_indexFormat_Injected(nint _unity_self, UnityEngine.Rendering.IndexFormat value);
        static /*0x3dac9bc*/ uint GetTotalIndexCount_Injected(nint _unity_self);
        static /*0x3daca88*/ void SetIndexBufferParams_Injected(nint _unity_self, int indexCount, UnityEngine.Rendering.IndexFormat format);
        static /*0x3dacb9c*/ void InternalSetIndexBufferData_Injected(nint _unity_self, nint data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x3dacce0*/ void InternalSetIndexBufferDataFromArray_Injected(nint _unity_self, System.Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x3dacdfc*/ void SetVertexBufferParamsFromPtr_Injected(nint _unity_self, int vertexCount, nint attributesPtr, int attributesCount);
        static /*0x3dacf68*/ void SetVertexBufferParamsFromArray_Injected(nint _unity_self, int vertexCount, ref UnityEngine.Bindings.ManagedSpanWrapper attributes);
        static /*0x3dad084*/ void InternalSetVertexBufferData_Injected(nint _unity_self, int stream, nint data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x3dad1d8*/ void InternalSetVertexBufferDataFromArray_Injected(nint _unity_self, int stream, System.Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x3dad2dc*/ System.Array GetVertexAttributesAlloc_Injected(nint _unity_self);
        static /*0x3dad440*/ int GetVertexAttributesArray_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper attributes);
        static /*0x3dad688*/ int GetVertexAttributesList_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper attributes);
        static /*0x3dad744*/ int GetVertexAttributeCountImpl_Injected(nint _unity_self);
        static /*0x3dad818*/ void GetVertexAttribute_Injected(nint _unity_self, int index, ref UnityEngine.Rendering.VertexAttributeDescriptor ret);
        static /*0x3dad8ec*/ uint GetIndexStartImpl_Injected(nint _unity_self, int submesh);
        static /*0x3dad9b0*/ uint GetIndexCountImpl_Injected(nint _unity_self, int submesh);
        static /*0x3dada74*/ uint GetTrianglesCountImpl_Injected(nint _unity_self, int submesh);
        static /*0x3dadb38*/ uint GetBaseVertexImpl_Injected(nint _unity_self, int submesh);
        static /*0x3dadce4*/ void GetTrianglesImpl_Injected(nint _unity_self, int submesh, bool applyBaseVertex, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3dadea8*/ void GetIndicesImpl_Injected(nint _unity_self, int submesh, bool applyBaseVertex, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3dadfdc*/ void SetIndicesImpl_Injected(nint _unity_self, int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        static /*0x3dae150*/ void SetIndicesNativeArrayImpl_Injected(nint _unity_self, int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, nint indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        static /*0x3dae354*/ void GetTrianglesNonAllocImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values, int submesh, bool applyBaseVertex);
        static /*0x3dae518*/ void GetTrianglesNonAllocImpl16_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values, int submesh, bool applyBaseVertex);
        static /*0x3dae6dc*/ void GetIndicesNonAllocImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values, int submesh, bool applyBaseVertex);
        static /*0x3dae8a0*/ void GetIndicesNonAllocImpl16_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values, int submesh, bool applyBaseVertex);
        static /*0x3dae97c*/ void PrintErrorCantAccessChannel_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute ch);
        static /*0x3daea40*/ bool HasVertexAttribute_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute attr);
        static /*0x3daeb04*/ int GetVertexAttributeDimension_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute attr);
        static /*0x3daebc8*/ UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute attr);
        static /*0x3daec8c*/ int GetVertexAttributeStream_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute attr);
        static /*0x3daed50*/ int GetVertexAttributeOffset_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute attr);
        static /*0x3daee6c*/ void SetArrayForChannelImpl_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x3daefe0*/ void SetNativeArrayForChannelImpl_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, nint values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x3daf114*/ System.Array GetAllocArrayFromChannelImpl_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim);
        static /*0x3daf218*/ void GetArrayFromChannelImpl_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values);
        static /*0x3daf2fc*/ int get_vertexBufferCount_Injected(nint _unity_self);
        static /*0x3daf3b8*/ int GetVertexBufferStride_Injected(nint _unity_self, int stream);
        static /*0x3daf47c*/ nint GetNativeVertexBufferPtr_Injected(nint _unity_self, int index);
        static /*0x3daf538*/ nint GetNativeIndexBufferPtr_Injected(nint _unity_self);
        static /*0x3daf60c*/ nint GetVertexBufferImpl_Injected(nint _unity_self, int index);
        static /*0x3daf6e0*/ nint GetIndexBufferImpl_Injected(nint _unity_self);
        static /*0x3daf7b4*/ nint GetBoneWeightBufferImpl_Injected(nint _unity_self, int bonesPerVertex);
        static /*0x3daf890*/ nint GetBlendShapeBufferImpl_Injected(nint _unity_self, int layout);
        static /*0x3daf94c*/ UnityEngine.GraphicsBuffer.Target get_vertexBufferTarget_Injected(nint _unity_self);
        static /*0x3dafa08*/ void set_vertexBufferTarget_Injected(nint _unity_self, UnityEngine.GraphicsBuffer.Target value);
        static /*0x3dafac4*/ UnityEngine.GraphicsBuffer.Target get_indexBufferTarget_Injected(nint _unity_self);
        static /*0x3dafb80*/ void set_indexBufferTarget_Injected(nint _unity_self, UnityEngine.GraphicsBuffer.Target value);
        static /*0x3dafc3c*/ int get_blendShapeCount_Injected(nint _unity_self);
        static /*0x3dafcf0*/ void ClearBlendShapes_Injected(nint _unity_self);
        static /*0x3dafe64*/ void GetBlendShapeName_Injected(nint _unity_self, int shapeIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3db0060*/ int GetBlendShapeIndex_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper blendShapeName);
        static /*0x3db0124*/ int GetBlendShapeFrameCount_Injected(nint _unity_self, int shapeIndex);
        static /*0x3db01f8*/ float GetBlendShapeFrameWeight_Injected(nint _unity_self, int shapeIndex, int frameIndex);
        static /*0x3db03ec*/ void GetBlendShapeFrameVertices_Injected(nint _unity_self, int shapeIndex, int frameIndex, ref UnityEngine.Bindings.ManagedSpanWrapper deltaVertices, ref UnityEngine.Bindings.ManagedSpanWrapper deltaNormals, ref UnityEngine.Bindings.ManagedSpanWrapper deltaTangents);
        static /*0x3db0734*/ void AddBlendShapeFrame_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper shapeName, float frameWeight, ref UnityEngine.Bindings.ManagedSpanWrapper deltaVertices, ref UnityEngine.Bindings.ManagedSpanWrapper deltaNormals, ref UnityEngine.Bindings.ManagedSpanWrapper deltaTangents);
        static /*0x3db0850*/ void GetBlendShapeOffsetInternal_Injected(nint _unity_self, int index, ref UnityEngine.BlendShape ret);
        static /*0x3db091c*/ bool HasBoneWeights_Injected(nint _unity_self);
        static /*0x3db0aac*/ void GetBoneWeightsImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3db0bf0*/ void SetBoneWeightsImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper weights);
        static /*0x3db0da0*/ void InternalSetBoneWeights_Injected(nint _unity_self, nint bonesPerVertex, int bonesPerVertexSize, nint weights, int weightsSize);
        static /*0x3db10d4*/ int GetAllBoneWeightsArraySize_Injected(nint _unity_self);
        static /*0x3db1188*/ int GetBoneWeightBufferLayoutInternal_Injected(nint _unity_self);
        static /*0x3db11c4*/ nint GetAllBoneWeightsArray_Injected(nint _unity_self);
        static /*0x3db1200*/ nint GetBonesPerVertexArray_Injected(nint _unity_self);
        static /*0x3db12b4*/ int get_bindposeCount_Injected(nint _unity_self);
        static /*0x3db1444*/ void get_bindposes_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3db1588*/ void set_bindposes_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x3db1824*/ void SetBindposesFromScript_NativeArray_Injected(nint _unity_self, nint posesPtr, int posesCount);
        static /*0x3db1878*/ nint GetBindposesArray_Injected(nint _unity_self);
        static /*0x3db1a00*/ void GetBoneWeightsNonAllocImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values);
        static /*0x3db1b90*/ void GetBindposesNonAllocImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values);
        static /*0x3db1c4c*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x3db1d00*/ bool get_canAccess_Injected(nint _unity_self);
        static /*0x3db1d3c*/ int get_vertexCount_Injected(nint _unity_self);
        static /*0x3db1df0*/ int get_subMeshCount_Injected(nint _unity_self);
        static /*0x3db1eac*/ void set_subMeshCount_Injected(nint _unity_self, int value);
        static /*0x3db1f88*/ void SetSubMesh_Injected(nint _unity_self, int index, ref UnityEngine.Rendering.SubMeshDescriptor desc, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x3db209c*/ void GetSubMesh_Injected(nint _unity_self, int index, ref UnityEngine.Rendering.SubMeshDescriptor ret);
        static /*0x3db2218*/ void SetAllSubMeshesAtOnceFromArray_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x3db232c*/ void SetAllSubMeshesAtOnceFromNativeArray_Injected(nint _unity_self, nint desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x3db243c*/ void get_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x3db2500*/ void set_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds value);
        static /*0x3db25c4*/ void ClearImpl_Injected(nint _unity_self, bool keepVertexLayout);
        static /*0x3db2688*/ void RecalculateBoundsImpl_Injected(nint _unity_self, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x3db274c*/ void RecalculateNormalsImpl_Injected(nint _unity_self, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x3db2810*/ void RecalculateTangentsImpl_Injected(nint _unity_self, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x3db28cc*/ void MarkDynamicImpl_Injected(nint _unity_self);
        static /*0x3db2980*/ void MarkModified_Injected(nint _unity_self);
        static /*0x3db2a3c*/ void UploadMeshDataImpl_Injected(nint _unity_self, bool markNoLongerReadable);
        static /*0x3db2b00*/ UnityEngine.MeshTopology GetTopologyImpl_Injected(nint _unity_self, int submesh);
        static /*0x3db2bd4*/ void RecalculateUVDistributionMetricImpl_Injected(nint _unity_self, int uvSetIndex, float uvAreaThreshold);
        static /*0x3db2cb0*/ void RecalculateUVDistributionMetricsImpl_Injected(nint _unity_self, float uvAreaThreshold);
        static /*0x3db2d7c*/ float GetUVDistributionMetric_Injected(nint _unity_self, int uvSetIndex);
        static /*0x3db2ee8*/ void CombineMeshesImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData);
        static /*0x3db2fcc*/ void OptimizeImpl_Injected(nint _unity_self);
        static /*0x3db3080*/ void OptimizeIndexBuffersImpl_Injected(nint _unity_self);
        static /*0x3db3134*/ void OptimizeReorderVertexBufferImpl_Injected(nint _unity_self);
        /*0x3dac6a4*/ Mesh();
        /*0x3dac7cc*/ UnityEngine.Rendering.IndexFormat get_indexFormat();
        /*0x3dac880*/ void set_indexFormat(UnityEngine.Rendering.IndexFormat value);
        /*0x3dac944*/ uint GetTotalIndexCount();
        /*0x3dac9f8*/ void SetIndexBufferParams(int indexCount, UnityEngine.Rendering.IndexFormat format);
        /*0x3dacadc*/ void InternalSetIndexBufferData(nint data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3dacc20*/ void InternalSetIndexBufferDataFromArray(System.Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3dacd64*/ void SetVertexBufferParamsFromPtr(int vertexCount, nint attributesPtr, int attributesCount);
        /*0x3dace58*/ void SetVertexBufferParamsFromArray(int vertexCount, UnityEngine.Rendering.VertexAttributeDescriptor[] attributes);
        /*0x3dacfbc*/ void InternalSetVertexBufferData(int stream, nint data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3dad110*/ void InternalSetVertexBufferDataFromArray(int stream, System.Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3dad264*/ System.Array GetVertexAttributesAlloc();
        /*0x3dad318*/ int GetVertexAttributesArray(UnityEngine.Rendering.VertexAttributeDescriptor[] attributes);
        /*0x3dad484*/ int GetVertexAttributesList(System.Collections.Generic.List<UnityEngine.Rendering.VertexAttributeDescriptor> attributes);
        /*0x3dad6cc*/ int GetVertexAttributeCountImpl();
        /*0x3dad780*/ UnityEngine.Rendering.VertexAttributeDescriptor GetVertexAttribute(int index);
        /*0x3dad86c*/ uint GetIndexStartImpl(int submesh);
        /*0x3dad930*/ uint GetIndexCountImpl(int submesh);
        /*0x3dad9f4*/ uint GetTrianglesCountImpl(int submesh);
        /*0x3dadab8*/ uint GetBaseVertexImpl(int submesh);
        /*0x3dadb7c*/ int[] GetTrianglesImpl(int submesh, bool applyBaseVertex);
        /*0x3dadd40*/ int[] GetIndicesImpl(int submesh, bool applyBaseVertex);
        /*0x3dadf04*/ void SetIndicesImpl(int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        /*0x3dae078*/ void SetIndicesNativeArrayImpl(int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, nint indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        /*0x3dae1ec*/ void GetTrianglesNonAllocImpl(int[] values, int submesh, bool applyBaseVertex);
        /*0x3dae3b0*/ void GetTrianglesNonAllocImpl16(ushort[] values, int submesh, bool applyBaseVertex);
        /*0x3dae574*/ void GetIndicesNonAllocImpl(int[] values, int submesh, bool applyBaseVertex);
        /*0x3dae738*/ void GetIndicesNonAllocImpl16(ushort[] values, int submesh, bool applyBaseVertex);
        /*0x3dae8fc*/ void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute ch);
        /*0x3dae9c0*/ bool HasVertexAttribute(UnityEngine.Rendering.VertexAttribute attr);
        /*0x3daea84*/ int GetVertexAttributeDimension(UnityEngine.Rendering.VertexAttribute attr);
        /*0x3daeb48*/ UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(UnityEngine.Rendering.VertexAttribute attr);
        /*0x3daec0c*/ int GetVertexAttributeStream(UnityEngine.Rendering.VertexAttribute attr);
        /*0x3daecd0*/ int GetVertexAttributeOffset(UnityEngine.Rendering.VertexAttribute attr);
        /*0x3daed94*/ void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3daef08*/ void SetNativeArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, nint values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3daf07c*/ System.Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim);
        /*0x3daf170*/ void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values);
        /*0x3daf284*/ int get_vertexBufferCount();
        /*0x3daf338*/ int GetVertexBufferStride(int stream);
        /*0x3daf3fc*/ nint GetNativeVertexBufferPtr(int index);
        /*0x3daf4c0*/ nint GetNativeIndexBufferPtr();
        /*0x3daf574*/ UnityEngine.GraphicsBuffer GetVertexBufferImpl(int index);
        /*0x3daf650*/ UnityEngine.GraphicsBuffer GetIndexBufferImpl();
        /*0x3daf71c*/ UnityEngine.GraphicsBuffer GetBoneWeightBufferImpl(int bonesPerVertex);
        /*0x3daf7f8*/ UnityEngine.GraphicsBuffer GetBlendShapeBufferImpl(int layout);
        /*0x3daf8d4*/ UnityEngine.GraphicsBuffer.Target get_vertexBufferTarget();
        /*0x3daf988*/ void set_vertexBufferTarget(UnityEngine.GraphicsBuffer.Target value);
        /*0x3dafa4c*/ UnityEngine.GraphicsBuffer.Target get_indexBufferTarget();
        /*0x3dafb00*/ void set_indexBufferTarget(UnityEngine.GraphicsBuffer.Target value);
        /*0x3dafbc4*/ int get_blendShapeCount();
        /*0x3dafc78*/ void ClearBlendShapes();
        /*0x3dafd2c*/ string GetBlendShapeName(int shapeIndex);
        /*0x3dafeb8*/ int GetBlendShapeIndex(string blendShapeName);
        /*0x3db00a4*/ int GetBlendShapeFrameCount(int shapeIndex);
        /*0x3db0168*/ float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex);
        /*0x3db024c*/ void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, UnityEngine.Vector3[] deltaVertices, UnityEngine.Vector3[] deltaNormals, UnityEngine.Vector3[] deltaTangents);
        /*0x3db0460*/ void AddBlendShapeFrame(string shapeName, float frameWeight, UnityEngine.Vector3[] deltaVertices, UnityEngine.Vector3[] deltaNormals, UnityEngine.Vector3[] deltaTangents);
        /*0x3db07b0*/ UnityEngine.BlendShape GetBlendShapeOffsetInternal(int index);
        /*0x3db08a4*/ bool HasBoneWeights();
        /*0x3db0958*/ UnityEngine.BoneWeight[] GetBoneWeightsImpl();
        /*0x3db0af0*/ void SetBoneWeightsImpl(UnityEngine.BoneWeight[] weights);
        /*0x3db0c34*/ void SetBoneWeights(Unity.Collections.NativeArray<byte> bonesPerVertex, Unity.Collections.NativeArray<UnityEngine.BoneWeight1> weights);
        /*0x3db0cf8*/ void InternalSetBoneWeights(nint bonesPerVertex, int bonesPerVertexSize, nint weights, int weightsSize);
        /*0x3db0e0c*/ Unity.Collections.NativeArray<UnityEngine.BoneWeight1> GetAllBoneWeights();
        /*0x3db0f68*/ Unity.Collections.NativeArray<byte> GetBonesPerVertex();
        /*0x3db0ef0*/ int GetAllBoneWeightsArraySize();
        /*0x3db1110*/ int GetBoneWeightBufferLayoutInternal();
        /*0x3db0e78*/ nint GetAllBoneWeightsArray();
        /*0x3db105c*/ nint GetBonesPerVertexArray();
        /*0x3db123c*/ int get_bindposeCount();
        /*0x3db12f0*/ UnityEngine.Matrix4x4[] get_bindposes();
        /*0x3db1488*/ void set_bindposes(UnityEngine.Matrix4x4[] value);
        /*0x3db15cc*/ Unity.Collections.NativeArray<UnityEngine.Matrix4x4> GetBindposes();
        /*0x3db16b0*/ void SetBindposes(Unity.Collections.NativeArray<UnityEngine.Matrix4x4> poses);
        /*0x3db1794*/ void SetBindposesFromScript_NativeArray(nint posesPtr, int posesCount);
        /*0x3db1638*/ nint GetBindposesArray();
        /*0x3db18b4*/ void GetBoneWeightsNonAllocImpl(UnityEngine.BoneWeight[] values);
        /*0x3db1a44*/ void GetBindposesNonAllocImpl(UnityEngine.Matrix4x4[] values);
        /*0x3db1bd4*/ bool get_isReadable();
        /*0x3db1c88*/ bool get_canAccess();
        /*0x3db0fe4*/ int get_vertexCount();
        /*0x3db1d78*/ int get_subMeshCount();
        /*0x3db1e2c*/ void set_subMeshCount(int value);
        /*0x3db1ef0*/ void SetSubMesh(int index, UnityEngine.Rendering.SubMeshDescriptor desc, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db1fe4*/ UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(int index);
        /*0x3db20f0*/ void SetAllSubMeshesAtOnceFromArray(UnityEngine.Rendering.SubMeshDescriptor[] desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db2284*/ void SetAllSubMeshesAtOnceFromNativeArray(nint desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db2398*/ UnityEngine.Bounds get_bounds();
        /*0x3db2480*/ void set_bounds(UnityEngine.Bounds value);
        /*0x3db2544*/ void ClearImpl(bool keepVertexLayout);
        /*0x3db2608*/ void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db26cc*/ void RecalculateNormalsImpl(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db2790*/ void RecalculateTangentsImpl(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db2854*/ void MarkDynamicImpl();
        /*0x3db2908*/ void MarkModified();
        /*0x3db29bc*/ void UploadMeshDataImpl(bool markNoLongerReadable);
        /*0x3db2a80*/ UnityEngine.MeshTopology GetTopologyImpl(int submesh);
        /*0x3db2b44*/ void RecalculateUVDistributionMetricImpl(int uvSetIndex, float uvAreaThreshold);
        /*0x3db2c28*/ void RecalculateUVDistributionMetricsImpl(float uvAreaThreshold);
        /*0x3db2cfc*/ float GetUVDistributionMetric(int uvSetIndex);
        /*0x3db2dc0*/ void CombineMeshesImpl(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData);
        /*0x3db2f54*/ void OptimizeImpl();
        /*0x3db3008*/ void OptimizeIndexBuffersImpl();
        /*0x3db30bc*/ void OptimizeReorderVertexBufferImpl();
        T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim);
        /*0x1f30240*/ T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel);
        /*0x3db3280*/ void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db34ac*/ void SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, nint values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Collections.Generic.List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, System.Collections.Generic.List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        void GetListForChannel<T>(System.Collections.Generic.List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim);
        /*0x1ffc854*/ void GetListForChannel<T>(System.Collections.Generic.List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim, UnityEngine.Rendering.VertexAttributeFormat channelType);
        /*0x3db36d4*/ UnityEngine.Vector3[] get_vertices();
        /*0x3db3720*/ void set_vertices(UnityEngine.Vector3[] value);
        /*0x3db3780*/ UnityEngine.Vector3[] get_normals();
        /*0x3db37cc*/ void set_normals(UnityEngine.Vector3[] value);
        /*0x3db382c*/ UnityEngine.Vector4[] get_tangents();
        /*0x3db3878*/ void set_tangents(UnityEngine.Vector4[] value);
        /*0x3db38d8*/ UnityEngine.Vector2[] get_uv();
        /*0x3db3924*/ void set_uv(UnityEngine.Vector2[] value);
        /*0x3db3984*/ UnityEngine.Vector2[] get_uv2();
        /*0x3db39d0*/ void set_uv2(UnityEngine.Vector2[] value);
        /*0x3db3a30*/ UnityEngine.Vector2[] get_uv3();
        /*0x3db3a7c*/ void set_uv3(UnityEngine.Vector2[] value);
        /*0x3db3adc*/ UnityEngine.Vector2[] get_uv4();
        /*0x3db3b28*/ void set_uv4(UnityEngine.Vector2[] value);
        /*0x3db3b88*/ UnityEngine.Vector2[] get_uv5();
        /*0x3db3bd4*/ void set_uv5(UnityEngine.Vector2[] value);
        /*0x3db3c34*/ UnityEngine.Vector2[] get_uv6();
        /*0x3db3c80*/ void set_uv6(UnityEngine.Vector2[] value);
        /*0x3db3ce0*/ UnityEngine.Vector2[] get_uv7();
        /*0x3db3d2c*/ void set_uv7(UnityEngine.Vector2[] value);
        /*0x3db3d8c*/ UnityEngine.Vector2[] get_uv8();
        /*0x3db3dd8*/ void set_uv8(UnityEngine.Vector2[] value);
        /*0x3db3e38*/ UnityEngine.Color[] get_colors();
        /*0x3db3e84*/ void set_colors(UnityEngine.Color[] value);
        /*0x3db3ee4*/ UnityEngine.Color32[] get_colors32();
        /*0x3db3f38*/ void set_colors32(UnityEngine.Color32[] value);
        /*0x3db3fa0*/ void GetVertices(System.Collections.Generic.List<UnityEngine.Vector3> vertices);
        /*0x3db4064*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices);
        /*0x3db40d0*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length);
        /*0x3db40d8*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db4154*/ void SetVertices(UnityEngine.Vector3[] inVertices);
        /*0x3db41bc*/ void SetVertices(UnityEngine.Vector3[] inVertices, int start, int length);
        /*0x3db4224*/ void SetVertices(UnityEngine.Vector3[] inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices);
        /*0x1ffc854*/ void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length);
        /*0x1ffc854*/ void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db4290*/ void GetNormals(System.Collections.Generic.List<UnityEngine.Vector3> normals);
        /*0x3db4354*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals);
        /*0x3db43c0*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length);
        /*0x3db43c8*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db4444*/ void SetNormals(UnityEngine.Vector3[] inNormals);
        /*0x3db44ac*/ void SetNormals(UnityEngine.Vector3[] inNormals, int start, int length);
        /*0x3db4514*/ void SetNormals(UnityEngine.Vector3[] inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals);
        /*0x1ffc854*/ void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length);
        /*0x1ffc854*/ void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db4580*/ void GetTangents(System.Collections.Generic.List<UnityEngine.Vector4> tangents);
        /*0x3db4644*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents);
        /*0x3db46b0*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length);
        /*0x3db46b8*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db4734*/ void SetTangents(UnityEngine.Vector4[] inTangents);
        /*0x3db479c*/ void SetTangents(UnityEngine.Vector4[] inTangents, int start, int length);
        /*0x3db4804*/ void SetTangents(UnityEngine.Vector4[] inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents);
        /*0x1ffc854*/ void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length);
        /*0x1ffc854*/ void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db4870*/ void GetColors(System.Collections.Generic.List<UnityEngine.Color> colors);
        /*0x3db4934*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors);
        /*0x3db49a0*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors, int start, int length);
        /*0x3db49a8*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db4a24*/ void SetColors(UnityEngine.Color[] inColors);
        /*0x3db4a8c*/ void SetColors(UnityEngine.Color[] inColors, int start, int length);
        /*0x3db4af4*/ void SetColors(UnityEngine.Color[] inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db4b60*/ void GetColors(System.Collections.Generic.List<UnityEngine.Color32> colors);
        /*0x3db4c28*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors);
        /*0x3db4c94*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length);
        /*0x3db4c9c*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db4d30*/ void SetColors(UnityEngine.Color32[] inColors);
        /*0x3db4d98*/ void SetColors(UnityEngine.Color32[] inColors, int start, int length);
        /*0x3db4e00*/ void SetColors(UnityEngine.Color32[] inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetColors<T>(Unity.Collections.NativeArray<T> inColors);
        /*0x1ffc854*/ void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length);
        /*0x1ffc854*/ void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetUvsImpl<T>(int uvIndex, int dim, System.Collections.Generic.List<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db4e6c*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs);
        /*0x3db4ee8*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs);
        /*0x3db4f64*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs);
        /*0x3db4ee0*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, int start, int length);
        /*0x3db4fe0*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db4f5c*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs, int start, int length);
        /*0x3db506c*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db4fd8*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length);
        /*0x3db50f8*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db5184*/ void SetUvsImpl(int uvIndex, int dim, System.Array uvs, int arrayStart, int arraySize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db528c*/ void SetUVs(int channel, UnityEngine.Vector2[] uvs);
        /*0x3db52ec*/ void SetUVs(int channel, UnityEngine.Vector3[] uvs);
        /*0x3db534c*/ void SetUVs(int channel, UnityEngine.Vector4[] uvs);
        /*0x3db52d4*/ void SetUVs(int channel, UnityEngine.Vector2[] uvs, int start, int length);
        /*0x3db53ac*/ void SetUVs(int channel, UnityEngine.Vector2[] uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db5334*/ void SetUVs(int channel, UnityEngine.Vector3[] uvs, int start, int length);
        /*0x3db53c4*/ void SetUVs(int channel, UnityEngine.Vector3[] uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db5394*/ void SetUVs(int channel, UnityEngine.Vector4[] uvs, int start, int length);
        /*0x3db53dc*/ void SetUVs(int channel, UnityEngine.Vector4[] uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs);
        /*0x1ffc854*/ void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length);
        /*0x1ffc854*/ void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void GetUVsImpl<T>(int uvIndex, System.Collections.Generic.List<T> uvs, int dim);
        /*0x3db53f4*/ void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs);
        /*0x3db5458*/ void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs);
        /*0x3db54bc*/ void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs);
        /*0x3db5520*/ int get_vertexAttributeCount();
        /*0x3db5524*/ UnityEngine.Rendering.VertexAttributeDescriptor[] GetVertexAttributes();
        /*0x3db5590*/ int GetVertexAttributes(UnityEngine.Rendering.VertexAttributeDescriptor[] attributes);
        /*0x3db5594*/ int GetVertexAttributes(System.Collections.Generic.List<UnityEngine.Rendering.VertexAttributeDescriptor> attributes);
        /*0x3db5598*/ void SetVertexBufferParams(int vertexCount, UnityEngine.Rendering.VertexAttributeDescriptor[] attributes);
        /*0x3db559c*/ void SetVertexBufferParams(int vertexCount, Unity.Collections.NativeArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes);
        /*0x1ffc854*/ void SetVertexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetVertexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, int stream, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetVertexBufferData<T>(System.Collections.Generic.List<T> data, int dataStart, int meshBufferStart, int count, int stream, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db6768*/ UnityEngine.GraphicsBuffer GetVertexBuffer(int index);
        /*0x3db6814*/ UnityEngine.GraphicsBuffer GetIndexBuffer();
        /*0x3db68b0*/ UnityEngine.GraphicsBuffer GetBoneWeightBuffer(UnityEngine.SkinWeights layout);
        /*0x3db6b58*/ UnityEngine.GraphicsBuffer GetBlendShapeBuffer(UnityEngine.Rendering.BlendShapeBufferLayout layout);
        /*0x3db6c68*/ UnityEngine.GraphicsBuffer GetBlendShapeBuffer();
        /*0x3db6d68*/ UnityEngine.BlendShapeBufferRange GetBlendShapeBufferRange(int blendShapeIndex);
        /*0x3db6e30*/ void PrintErrorCantAccessIndices();
        /*0x3db6ecc*/ bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles);
        /*0x3db6fd0*/ bool CheckCanAccessSubmeshTriangles(int submesh);
        /*0x3db6fd8*/ bool CheckCanAccessSubmeshIndices(int submesh);
        /*0x3db6fe0*/ int[] get_triangles();
        /*0x3db7054*/ void set_triangles(int[] value);
        /*0x3db7178*/ int[] GetTriangles(int submesh);
        /*0x3db7180*/ int[] GetTriangles(int submesh, bool applyBaseVertex);
        /*0x3db7208*/ void GetTriangles(System.Collections.Generic.List<int> triangles, int submesh);
        /*0x3db7210*/ void GetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool applyBaseVertex);
        /*0x3db7380*/ void GetTriangles(System.Collections.Generic.List<ushort> triangles, int submesh, bool applyBaseVertex);
        /*0x3db74f0*/ int[] GetIndices(int submesh);
        /*0x3db74f8*/ int[] GetIndices(int submesh, bool applyBaseVertex);
        /*0x3db7580*/ void GetIndices(System.Collections.Generic.List<int> indices, int submesh);
        /*0x3db7588*/ void GetIndices(System.Collections.Generic.List<int> indices, int submesh, bool applyBaseVertex);
        /*0x3db7774*/ void GetIndices(System.Collections.Generic.List<ushort> indices, int submesh, bool applyBaseVertex);
        /*0x1ffc854*/ void SetIndexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetIndexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetIndexBufferData<T>(System.Collections.Generic.List<T> data, int dataStart, int meshBufferStart, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db78e4*/ uint GetIndexStart(int submesh);
        /*0x3db76f8*/ uint GetIndexCount(int submesh);
        /*0x3db7960*/ uint GetBaseVertex(int submesh);
        /*0x3db79dc*/ void CheckIndicesArrayRange(int valuesLength, int start, int length);
        /*0x3db70f8*/ void SetTrianglesImpl(int submesh, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex);
        /*0x3db7b78*/ void SetTriangles(int[] triangles, int submesh);
        /*0x3db7c18*/ void SetTriangles(int[] triangles, int submesh, bool calculateBounds);
        /*0x3db7bc0*/ void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db7c6c*/ void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db7d08*/ void SetTriangles(ushort[] triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db7d60*/ void SetTriangles(ushort[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db7dfc*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh);
        /*0x3db7e90*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds);
        /*0x3db7e08*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db7e98*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db7fbc*/ void SetTriangles(System.Collections.Generic.List<ushort> triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db8044*/ void SetTriangles(System.Collections.Generic.List<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db8168*/ void SetIndices(int[] indices, UnityEngine.MeshTopology topology, int submesh);
        /*0x3db8240*/ void SetIndices(int[] indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds);
        /*0x3db81cc*/ void SetIndices(int[] indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db82a8*/ void SetIndices(int[] indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db8350*/ void SetIndices(ushort[] indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db83c4*/ void SetIndices(ushort[] indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x1ffc854*/ void SetIndices<T>(Unity.Collections.NativeArray<T> indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x1ffc854*/ void SetIndices<T>(Unity.Collections.NativeArray<T> indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db846c*/ void SetIndices(System.Collections.Generic.List<int> indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db8510*/ void SetIndices(System.Collections.Generic.List<int> indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db8638*/ void SetIndices(System.Collections.Generic.List<ushort> indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db86dc*/ void SetIndices(System.Collections.Generic.List<ushort> indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x3db8804*/ void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[] desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db8a78*/ void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[] desc, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db8aa0*/ void SetSubMeshes(System.Collections.Generic.List<UnityEngine.Rendering.SubMeshDescriptor> desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db8b50*/ void SetSubMeshes(System.Collections.Generic.List<UnityEngine.Rendering.SubMeshDescriptor> desc, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1ffc854*/ void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db8c04*/ void GetBindposes(System.Collections.Generic.List<UnityEngine.Matrix4x4> bindposes);
        /*0x3db8d10*/ void GetBoneWeights(System.Collections.Generic.List<UnityEngine.BoneWeight> boneWeights);
        /*0x3db8e20*/ UnityEngine.BoneWeight[] get_boneWeights();
        /*0x3db8e24*/ void set_boneWeights(UnityEngine.BoneWeight[] value);
        /*0x3db8e28*/ UnityEngine.SkinWeights get_skinWeightBufferLayout();
        /*0x3db8e2c*/ void Clear(bool keepVertexLayout);
        /*0x3db8e30*/ void Clear();
        /*0x3db8e38*/ void RecalculateBounds();
        /*0x3db8ef8*/ void RecalculateNormals();
        /*0x3db8fb8*/ void RecalculateTangents();
        /*0x3db8e40*/ void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db8f00*/ void RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db8fc0*/ void RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3db9078*/ void RecalculateUVDistributionMetric(int uvSetIndex, float uvAreaThreshold);
        /*0x3db9144*/ void RecalculateUVDistributionMetrics(float uvAreaThreshold);
        /*0x3db9208*/ void MarkDynamic();
        /*0x3db922c*/ void UploadMeshData(bool markNoLongerReadable);
        /*0x3db9264*/ void Optimize();
        /*0x3db9314*/ void OptimizeIndexBuffers();
        /*0x3db93c4*/ void OptimizeReorderVertexBuffer();
        /*0x3db9474*/ UnityEngine.MeshTopology GetTopology(int submesh);
        /*0x3db9518*/ void CombineMeshes(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData);
        /*0x3db951c*/ void CombineMeshes(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices);
        /*0x3db9524*/ void CombineMeshes(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes);
        /*0x3db9530*/ void CombineMeshes(UnityEngine.CombineInstance[] combine);

        struct MeshData
        {
            /*0x10*/ nint m_Ptr;
        }

        struct MeshDataArray : System.IDisposable
        {
            /*0x10*/ nint* m_Ptrs;
            /*0x18*/ int m_Length;

            static /*0x3db9540*/ void AcquireReadOnlyMeshData(UnityEngine.Mesh mesh, nint* datas);
            static /*0x3db9634*/ void AcquireReadOnlyMeshDatas(UnityEngine.Mesh[] meshes, nint* datas, int count);
            static /*0x3db9718*/ void AcquireMeshDataCopy(UnityEngine.Mesh mesh, nint* datas);
            static /*0x3db980c*/ void AcquireMeshDatasCopy(UnityEngine.Mesh[] meshes, nint* datas, int count);
            static /*0x3db98f0*/ void ReleaseMeshDatas(nint* datas, int count);
            static /*0x3db9934*/ void CreateNewMeshDatas(nint* datas, int count);
            static /*0x3db9978*/ void ApplyToMeshesImpl(UnityEngine.Mesh[] meshes, nint* datas, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
            static /*0x3db9a6c*/ void ApplyToMeshImpl(UnityEngine.Mesh mesh, nint data, UnityEngine.Rendering.MeshUpdateFlags flags);
            static /*0x3db95f0*/ void AcquireReadOnlyMeshData_Injected(nint mesh, nint* datas);
            static /*0x3db96c4*/ void AcquireReadOnlyMeshDatas_Injected(UnityEngine.Mesh[] meshes, nint* datas, int count);
            static /*0x3db97c8*/ void AcquireMeshDataCopy_Injected(nint mesh, nint* datas);
            static /*0x3db989c*/ void AcquireMeshDatasCopy_Injected(UnityEngine.Mesh[] meshes, nint* datas, int count);
            static /*0x3db9a10*/ void ApplyToMeshesImpl_Injected(UnityEngine.Mesh[] meshes, nint* datas, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
            static /*0x3db9b2c*/ void ApplyToMeshImpl_Injected(nint mesh, nint data, UnityEngine.Rendering.MeshUpdateFlags flags);
            /*0x3db5650*/ MeshDataArray(UnityEngine.Mesh mesh, bool checkReadWrite, bool createAsCopy);
            /*0x3db5904*/ MeshDataArray(UnityEngine.Mesh[] meshes, int meshesCount, bool checkReadWrite, bool createAsCopy);
            /*0x3db5d0c*/ MeshDataArray(int meshesCount);
            /*0x3db9b80*/ int get_Length();
            /*0x3db9b88*/ void Dispose();
            /*0x3db61a0*/ void ApplyToMeshAndDispose(UnityEngine.Mesh mesh, UnityEngine.Rendering.MeshUpdateFlags flags);
            /*0x3db63bc*/ void ApplyToMeshesAndDispose(UnityEngine.Mesh[] meshes, UnityEngine.Rendering.MeshUpdateFlags flags);
        }
    }

    struct BlendShape
    {
        /*0x10*/ uint m_FirstVertex;
        /*0x14*/ uint m_VertexCount;
        /*0x18*/ bool m_HasNormals;
        /*0x19*/ bool m_HasTangents;

        /*0x3db6e10*/ uint get_firstVertex();
        /*0x3db6e20*/ uint get_vertexCount();
    }

    struct BlendShapeBufferRange
    {
        /*0x10*/ uint m_StartIndex;
        /*0x14*/ uint m_EndIndex;

        /*0x3db6e18*/ void set_startIndex(uint value);
        /*0x3db6e28*/ void set_endIndex(uint value);
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

        /*0x3db9c10*/ float get_weight0();
        /*0x3db9c18*/ float get_weight1();
        /*0x3db9c20*/ float get_weight2();
        /*0x3db9c28*/ float get_weight3();
        /*0x3db9c30*/ int get_boneIndex0();
        /*0x3db9c38*/ int get_boneIndex1();
        /*0x3db9c40*/ int get_boneIndex2();
        /*0x3db9c48*/ int get_boneIndex3();
        /*0x3db9c50*/ int GetHashCode();
        /*0x3db9d5c*/ bool Equals(object other);
        /*0x3db9de4*/ bool Equals(UnityEngine.BoneWeight other);
    }

    struct BoneWeight1 : System.IEquatable<UnityEngine.BoneWeight1>
    {
        /*0x10*/ float m_Weight;
        /*0x14*/ int m_BoneIndex;

        /*0x3db9ebc*/ float get_weight();
        /*0x3db9ec4*/ int get_boneIndex();
        /*0x3db9ecc*/ bool Equals(object other);
        /*0x3db9f48*/ bool Equals(UnityEngine.BoneWeight1 other);
        /*0x3db9fa8*/ int GetHashCode();
    }

    struct CombineInstance
    {
        /*0x10*/ int m_MeshInstanceID;
        /*0x14*/ int m_SubMeshIndex;
        /*0x18*/ UnityEngine.Matrix4x4 m_Transform;
        /*0x58*/ UnityEngine.Vector4 m_LightmapScaleOffset;
        /*0x68*/ UnityEngine.Vector4 m_RealtimeLightmapScaleOffset;
    }

    class Texture : UnityEngine.Object
    {
        static /*0x0*/ int GenerateAllMips;

        static /*0x3dbbb60*/ Texture();
        static /*0x3dbb320*/ void SetStreamingTextureMaterialDebugPropertiesWithSlot(int materialTextureSlot);
        static /*0x3dbb35c*/ void SetStreamingTextureMaterialDebugProperties(int materialTextureSlot);
        static /*0x3dbb3d0*/ bool get_streamingTextureDiscardUnusedMips();
        static /*0x3dbb3f8*/ void set_streamingTextureDiscardUnusedMips(bool value);
        static /*0x3dba0e8*/ int get_mipmapCount_Injected(nint _unity_self);
        static /*0x3dba218*/ int GetDataWidth_Injected(nint _unity_self);
        static /*0x3dba2f0*/ int GetDataHeight_Injected(nint _unity_self);
        static /*0x3dba3c8*/ UnityEngine.Rendering.TextureDimension GetDimension_Injected(nint _unity_self);
        static /*0x3dba554*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x3dba62c*/ UnityEngine.TextureWrapMode get_wrapMode_Injected(nint _unity_self);
        static /*0x3dba714*/ void set_wrapMode_Injected(nint _unity_self, UnityEngine.TextureWrapMode value);
        static /*0x3dba804*/ void set_wrapModeU_Injected(nint _unity_self, UnityEngine.TextureWrapMode value);
        static /*0x3dba8f4*/ void set_wrapModeV_Injected(nint _unity_self, UnityEngine.TextureWrapMode value);
        static /*0x3dba9e4*/ void set_wrapModeW_Injected(nint _unity_self, UnityEngine.TextureWrapMode value);
        static /*0x3dbaac4*/ UnityEngine.FilterMode get_filterMode_Injected(nint _unity_self);
        static /*0x3dbabac*/ void set_filterMode_Injected(nint _unity_self, UnityEngine.FilterMode value);
        static /*0x3dbac8c*/ int get_anisoLevel_Injected(nint _unity_self);
        static /*0x3dbad74*/ void set_anisoLevel_Injected(nint _unity_self, int value);
        static /*0x3dbae54*/ float get_mipMapBias_Injected(nint _unity_self);
        static /*0x3dbaf3c*/ void set_mipMapBias_Injected(nint _unity_self, float value);
        static /*0x3dbb03c*/ void get_texelSize_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3dbb11c*/ uint get_updateCount_Injected(nint _unity_self);
        static /*0x3dbb1f4*/ void IncrementUpdateCount_Injected(nint _unity_self);
        static /*0x3dbb2cc*/ int Internal_GetActiveTextureColorSpace_Injected(nint _unity_self);
        static /*0x3dbb4e8*/ ulong GetPixelDataSize_Injected(nint _unity_self, int mipLevel, int element);
        static /*0x3dbb5f0*/ ulong GetPixelDataOffset_Injected(nint _unity_self, int mipLevel, int element);
        /*0x3db9ff4*/ Texture();
        /*0x3dba04c*/ int get_mipmapCount();
        /*0x3dba124*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x3dba17c*/ int GetDataWidth();
        /*0x3dba254*/ int GetDataHeight();
        /*0x3dba32c*/ UnityEngine.Rendering.TextureDimension GetDimension();
        /*0x3dba404*/ int get_width();
        /*0x3dba408*/ void set_width(int value);
        /*0x3dba440*/ int get_height();
        /*0x3dba444*/ void set_height(int value);
        /*0x3dba47c*/ UnityEngine.Rendering.TextureDimension get_dimension();
        /*0x3dba480*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
        /*0x3dba4b8*/ bool get_isReadable();
        /*0x3dba590*/ UnityEngine.TextureWrapMode get_wrapMode();
        /*0x3dba668*/ void set_wrapMode(UnityEngine.TextureWrapMode value);
        /*0x3dba758*/ void set_wrapModeU(UnityEngine.TextureWrapMode value);
        /*0x3dba848*/ void set_wrapModeV(UnityEngine.TextureWrapMode value);
        /*0x3dba938*/ void set_wrapModeW(UnityEngine.TextureWrapMode value);
        /*0x3dbaa28*/ UnityEngine.FilterMode get_filterMode();
        /*0x3dbab00*/ void set_filterMode(UnityEngine.FilterMode value);
        /*0x3dbabf0*/ int get_anisoLevel();
        /*0x3dbacc8*/ void set_anisoLevel(int value);
        /*0x3dbadb8*/ float get_mipMapBias();
        /*0x3dbae90*/ void set_mipMapBias(float value);
        /*0x3dbaf88*/ UnityEngine.Vector2 get_texelSize();
        /*0x3dbb080*/ uint get_updateCount();
        /*0x3dbb158*/ void IncrementUpdateCount();
        /*0x3dbb230*/ int Internal_GetActiveTextureColorSpace();
        /*0x3dbb308*/ UnityEngine.ColorSpace get_activeTextureColorSpace();
        /*0x3dbb434*/ ulong GetPixelDataSize(int mipLevel, int element);
        /*0x3dbb53c*/ ulong GetPixelDataOffset(int mipLevel, int element);
        /*0x3dbb644*/ UnityEngine.TextureColorSpace GetTextureColorSpace(bool linear);
        /*0x3dbb650*/ UnityEngine.TextureColorSpace GetTextureColorSpace(UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x3dbb6b0*/ bool ValidateFormat(UnityEngine.TextureFormat format);
        /*0x3dbb878*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.GraphicsFormatUsage usage);
        /*0x3dbb9b4*/ UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture t);
        /*0x3dbba54*/ UnityEngine.UnityException IgnoreMipmapLimitCannotBeToggledException(UnityEngine.Texture t);
        /*0x3dbbaf4*/ UnityEngine.UnityException CreateNativeArrayLengthOverflowException();
    }

    class Texture2D : UnityEngine.Texture
    {
        static int streamingMipmapsPriorityMin = -128;
        static int streamingMipmapsPriorityMax = 127;

        static /*0x3dbbffc*/ UnityEngine.Texture2D get_whiteTexture();
        static /*0x3dbc084*/ UnityEngine.Texture2D get_blackTexture();
        static /*0x3dbc10c*/ UnityEngine.Texture2D get_redTexture();
        static /*0x3dbc194*/ UnityEngine.Texture2D get_grayTexture();
        static /*0x3dbc21c*/ UnityEngine.Texture2D get_linearGrayTexture();
        static /*0x3dbc2a4*/ UnityEngine.Texture2D get_normalTexture();
        static /*0x3dbc3f0*/ bool Internal_CreateEmptyImpl(UnityEngine.Texture2D mono);
        static /*0x3dbc42c*/ bool Internal_CreateImpl(UnityEngine.Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        static /*0x3dbc6b8*/ void Internal_Create(UnityEngine.Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        static /*0x3dbd904*/ void GenerateAtlasImpl(UnityEngine.Vector2[] sizes, int padding, int atlasSize, UnityEngine.Rect[] rect);
        static /*0x3dbfedc*/ UnityEngine.Texture2D CreateExternalTexture(int width, int height, UnityEngine.TextureFormat format, bool mipChain, bool linear, nint nativeTex);
        static /*0x3dc088c*/ bool GenerateAtlas(UnityEngine.Vector2[] sizes, int padding, int atlasSize, System.Collections.Generic.List<UnityEngine.Rect> results);
        static /*0x3dbbc24*/ UnityEngine.TextureFormat get_format_Injected(nint _unity_self);
        static /*0x3dbbcd8*/ bool IgnoreMipmapLimit_Injected(nint _unity_self);
        static /*0x3dbbd94*/ void SetIgnoreMipmapLimitAndReload_Injected(nint _unity_self, bool value);
        static /*0x3dbbf04*/ void get_mipmapLimitGroup_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3dbbfc0*/ int get_activeMipmapLimit_Injected(nint _unity_self);
        static /*0x3dbc05c*/ nint get_whiteTexture_Injected();
        static /*0x3dbc0e4*/ nint get_blackTexture_Injected();
        static /*0x3dbc16c*/ nint get_redTexture_Injected();
        static /*0x3dbc1f4*/ nint get_grayTexture_Injected();
        static /*0x3dbc27c*/ nint get_linearGrayTexture_Injected();
        static /*0x3dbc304*/ nint get_normalTexture_Injected();
        static /*0x3dbc3ac*/ void Compress_Injected(nint _unity_self, bool highQuality);
        static /*0x3dbc610*/ bool Internal_CreateImpl_Injected(UnityEngine.Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex, bool ignoreMipmapLimit, ref UnityEngine.Bindings.ManagedSpanWrapper mipmapLimitGroupName);
        static /*0x3dbc7a4*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x3dbc858*/ bool get_vtOnly_Injected(nint _unity_self);
        static /*0x3dbc924*/ void ApplyImpl_Injected(nint _unity_self, bool updateMipmaps, bool makeNoLongerReadable);
        static /*0x3dbca08*/ bool ReinitializeImpl_Injected(nint _unity_self, int width, int height);
        static /*0x3dbcb1c*/ void SetPixelImpl_Injected(nint _unity_self, int image, int mip, int x, int y, ref UnityEngine.Color color);
        static /*0x3dbcc54*/ void GetPixelImpl_Injected(nint _unity_self, int image, int mip, int x, int y, ref UnityEngine.Color ret);
        static /*0x3dbcd8c*/ void GetPixelBilinearImpl_Injected(nint _unity_self, int image, int mip, float u, float v, ref UnityEngine.Color ret);
        static /*0x3dbcea8*/ bool ReinitializeWithFormatImpl_Injected(nint _unity_self, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap);
        static /*0x3dbcfbc*/ bool ReinitializeWithTextureFormatImpl_Injected(nint _unity_self, int width, int height, UnityEngine.TextureFormat textureFormat, bool hasMipMap);
        static /*0x3dbd0d8*/ void ReadPixelsImpl_Injected(nint _unity_self, ref UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps);
        static /*0x3dbd28c*/ void SetPixelsImpl_Injected(nint _unity_self, int x, int y, int w, int h, ref UnityEngine.Bindings.ManagedSpanWrapper pixel, int miplevel, int frame);
        static /*0x3dbd3a8*/ bool LoadRawTextureDataImpl_Injected(nint _unity_self, nint data, ulong size);
        static /*0x3dbd500*/ bool LoadRawTextureDataImplArray_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper data);
        static /*0x3dbd5f4*/ bool SetPixelDataImplArray_Injected(nint _unity_self, System.Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);
        static /*0x3dbd718*/ bool SetPixelDataImpl_Injected(nint _unity_self, nint data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);
        static /*0x3dbd80c*/ nint GetWritableImageData_Injected(nint _unity_self, int frame);
        static /*0x3dbd8c8*/ ulong GetImageDataSize_Injected(nint _unity_self);
        static /*0x3dbdad0*/ void GenerateAtlasImpl_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper sizes, int padding, int atlasSize, ref UnityEngine.Bindings.BlittableArrayWrapper rect);
        static /*0x3dbdba4*/ bool get_isPreProcessed_Injected(nint _unity_self);
        static /*0x3dbdc58*/ bool get_streamingMipmaps_Injected(nint _unity_self);
        static /*0x3dbdd0c*/ int get_streamingMipmapsPriority_Injected(nint _unity_self);
        static /*0x3dbddc0*/ int get_requestedMipmapLevel_Injected(nint _unity_self);
        static /*0x3dbde7c*/ void set_requestedMipmapLevel_Injected(nint _unity_self, int value);
        static /*0x3dbdf38*/ int get_minimumMipmapLevel_Injected(nint _unity_self);
        static /*0x3dbdff4*/ void set_minimumMipmapLevel_Injected(nint _unity_self, int value);
        static /*0x3dbe0b0*/ bool get_loadAllMips_Injected(nint _unity_self);
        static /*0x3dbe16c*/ void set_loadAllMips_Injected(nint _unity_self, bool value);
        static /*0x3dbe228*/ int get_calculatedMipmapLevel_Injected(nint _unity_self);
        static /*0x3dbe2dc*/ int get_desiredMipmapLevel_Injected(nint _unity_self);
        static /*0x3dbe390*/ int get_loadingMipmapLevel_Injected(nint _unity_self);
        static /*0x3dbe444*/ int get_loadedMipmapLevel_Injected(nint _unity_self);
        static /*0x3dbe4f8*/ void ClearRequestedMipmapLevel_Injected(nint _unity_self);
        static /*0x3dbe5ac*/ bool IsRequestedMipmapLevelLoaded_Injected(nint _unity_self);
        static /*0x3dbe660*/ void ClearMinimumMipmapLevel_Injected(nint _unity_self);
        static /*0x3dbe71c*/ void UpdateExternalTexture_Injected(nint _unity_self, nint nativeTex);
        static /*0x3dbe870*/ void SetAllPixels32_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, int miplevel);
        static /*0x3dbea04*/ void SetBlockOfPixels32_Injected(nint _unity_self, int x, int y, int blockWidth, int blockHeight, ref UnityEngine.Bindings.ManagedSpanWrapper colors, int miplevel);
        static /*0x3dbeb00*/ byte[] GetRawTextureData_Injected(nint _unity_self);
        static /*0x3dbebec*/ UnityEngine.Color[] GetPixels_Injected(nint _unity_self, int x, int y, int blockWidth, int blockHeight, int miplevel);
        static /*0x3dbece8*/ UnityEngine.Color32[] GetPixels32_Injected(nint _unity_self, int miplevel);
        static /*0x3dbeddc*/ UnityEngine.Rect[] PackTextures_Injected(nint _unity_self, UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable);
        static /*0x3dbef10*/ void CopyPixels_Full_Injected(nint _unity_self, nint src);
        static /*0x3dbf028*/ void CopyPixels_Slice_Injected(nint _unity_self, nint src, int srcElement, int srcMip, int dstMip);
        static /*0x3dbf1a8*/ void CopyPixels_Region_Injected(nint _unity_self, nint src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY);
        /*0x3dbf468*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount, nint nativeTex, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x3dbf57c*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x3dbf66c*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.DefaultFormat format, int mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x3dbf6d4*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.DefaultFormat format, int mipCount, string mipmapLimitGroupName, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x3dbf77c*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.DefaultFormat format, int mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x3dbf5c8*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x3dbf7f4*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x3dbf820*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount, string mipmapLimitGroupName, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x3dbf8a8*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x3dbf8d8*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, nint nativeTex, bool createUninitialized, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x3dbfa7c*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x3dbfaa0*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized);
        /*0x3dbfac4*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x3dbfad8*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        /*0x3dbfb68*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x3dbfc20*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized);
        /*0x3dbfce4*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x3dbfd98*/ Texture2D(int width, int height);
        /*0x3dbbbac*/ UnityEngine.TextureFormat get_format();
        /*0x3dbbc60*/ bool IgnoreMipmapLimit();
        /*0x3dbbd14*/ void SetIgnoreMipmapLimitAndReload(bool value);
        /*0x3dbbdd8*/ string get_mipmapLimitGroup();
        /*0x3dbbf48*/ int get_activeMipmapLimit();
        /*0x3dbc32c*/ void Compress(bool highQuality);
        /*0x3dbc72c*/ bool get_isReadable();
        /*0x3dbc7e0*/ bool get_vtOnly();
        /*0x3dbc894*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x3dbc978*/ bool ReinitializeImpl(int width, int height);
        /*0x3dbca5c*/ void SetPixelImpl(int image, int mip, int x, int y, UnityEngine.Color color);
        /*0x3dbcb90*/ UnityEngine.Color GetPixelImpl(int image, int mip, int x, int y);
        /*0x3dbccc8*/ UnityEngine.Color GetPixelBilinearImpl(int image, int mip, float u, float v);
        /*0x3dbce00*/ bool ReinitializeWithFormatImpl(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap);
        /*0x3dbcf14*/ bool ReinitializeWithTextureFormatImpl(int width, int height, UnityEngine.TextureFormat textureFormat, bool hasMipMap);
        /*0x3dbd028*/ void ReadPixelsImpl(UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps);
        /*0x3dbd144*/ void SetPixelsImpl(int x, int y, int w, int h, UnityEngine.Color[] pixel, int miplevel, int frame);
        /*0x3dbd318*/ bool LoadRawTextureDataImpl(nint data, ulong size);
        /*0x3dbd3fc*/ bool LoadRawTextureDataImplArray(byte[] data);
        /*0x3dbd544*/ bool SetPixelDataImplArray(System.Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);
        /*0x3dbd668*/ bool SetPixelDataImpl(nint data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);
        /*0x3dbd78c*/ nint GetWritableImageData(int frame);
        /*0x3dbd850*/ ulong GetImageDataSize();
        /*0x3dbdb2c*/ bool get_isPreProcessed();
        /*0x3dbdbe0*/ bool get_streamingMipmaps();
        /*0x3dbdc94*/ int get_streamingMipmapsPriority();
        /*0x3dbdd48*/ int get_requestedMipmapLevel();
        /*0x3dbddfc*/ void set_requestedMipmapLevel(int value);
        /*0x3dbdec0*/ int get_minimumMipmapLevel();
        /*0x3dbdf74*/ void set_minimumMipmapLevel(int value);
        /*0x3dbe038*/ bool get_loadAllMips();
        /*0x3dbe0ec*/ void set_loadAllMips(bool value);
        /*0x3dbe1b0*/ int get_calculatedMipmapLevel();
        /*0x3dbe264*/ int get_desiredMipmapLevel();
        /*0x3dbe318*/ int get_loadingMipmapLevel();
        /*0x3dbe3cc*/ int get_loadedMipmapLevel();
        /*0x3dbe480*/ void ClearRequestedMipmapLevel();
        /*0x3dbe534*/ bool IsRequestedMipmapLevelLoaded();
        /*0x3dbe5e8*/ void ClearMinimumMipmapLevel();
        /*0x3dbe69c*/ void UpdateExternalTexture(nint nativeTex);
        /*0x3dbe760*/ void SetAllPixels32(UnityEngine.Color32[] colors, int miplevel);
        /*0x3dbe8c4*/ void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color32[] colors, int miplevel);
        /*0x3dbea88*/ byte[] GetRawTextureData();
        /*0x3dbeb3c*/ UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel);
        /*0x3dbec60*/ UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight);
        /*0x3dbec68*/ UnityEngine.Color32[] GetPixels32(int miplevel);
        /*0x3dbed2c*/ UnityEngine.Color32[] GetPixels32();
        /*0x3dbed34*/ UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable);
        /*0x3dbee48*/ UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize);
        /*0x3dbee50*/ UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, int padding);
        /*0x3dbee5c*/ void CopyPixels_Full(UnityEngine.Texture src);
        /*0x3dbef54*/ void CopyPixels_Slice(UnityEngine.Texture src, int srcElement, int srcMip, int dstMip);
        /*0x3dbf094*/ void CopyPixels_Region(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY);
        /*0x3dbf258*/ bool ValidateFormat(UnityEngine.TextureFormat format, int width, int height);
        /*0x3dbf334*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height);
        /*0x3dbffd4*/ void SetPixel(int x, int y, UnityEngine.Color color);
        /*0x3dc0070*/ void SetPixel(int x, int y, UnityEngine.Color color, int mipLevel);
        /*0x3dc0118*/ void SetPixels(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color[] colors, int miplevel);
        /*0x3dc01bc*/ void SetPixels(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color[] colors);
        /*0x3dc01c4*/ void SetPixels(UnityEngine.Color[] colors, int miplevel);
        /*0x3dc0240*/ void SetPixels(UnityEngine.Color[] colors);
        /*0x3dc029c*/ UnityEngine.Color GetPixel(int x, int y);
        /*0x3dc0308*/ UnityEngine.Color GetPixel(int x, int y, int mipLevel);
        /*0x3dc0380*/ UnityEngine.Color GetPixelBilinear(float u, float v);
        /*0x3dc03e8*/ UnityEngine.Color GetPixelBilinear(float u, float v, int mipLevel);
        /*0x3dc045c*/ void LoadRawTextureData(nint data, int size);
        /*0x3dc0574*/ void LoadRawTextureData(byte[] data);
        /*0x1ffc854*/ void LoadRawTextureData<T>(Unity.Collections.NativeArray<T> data);
        void SetPixelData<T>(T[] data, int mipLevel, int sourceDataStartIndex);
        /*0x1ffc854*/ void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, int sourceDataStartIndex);
        /*0x1ffc854*/ Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel);
        /*0x1ffc854*/ Unity.Collections.NativeArray<T> GetRawTextureData<T>();
        /*0x3dc067c*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x3dc06e0*/ void Apply(bool updateMipmaps);
        /*0x3dc06e8*/ void Apply();
        /*0x3dc06f4*/ bool Reinitialize(int width, int height);
        /*0x3dc0758*/ bool Reinitialize(int width, int height, UnityEngine.TextureFormat format, bool hasMipMap);
        /*0x3dc075c*/ bool Reinitialize(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap);
        /*0x3dc07d8*/ bool Resize(int width, int height);
        /*0x3dc07dc*/ bool Resize(int width, int height, UnityEngine.TextureFormat format, bool hasMipMap);
        /*0x3dc07e0*/ bool Resize(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap);
        /*0x3dc07e4*/ void ReadPixels(UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps);
        /*0x3dc0884*/ void ReadPixels(UnityEngine.Rect source, int destX, int destY);
        /*0x3dc0a84*/ void SetPixels32(UnityEngine.Color32[] colors, int miplevel);
        /*0x3dc0a88*/ void SetPixels32(UnityEngine.Color32[] colors);
        /*0x3dc0a90*/ void SetPixels32(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color32[] colors, int miplevel);
        /*0x3dc0a94*/ void SetPixels32(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color32[] colors);
        /*0x3dc0a9c*/ UnityEngine.Color[] GetPixels(int miplevel);
        /*0x3dc0b08*/ UnityEngine.Color[] GetPixels();
        /*0x3dc0b10*/ void CopyPixels(UnityEngine.Texture src);
        /*0x3dc0b90*/ void CopyPixels(UnityEngine.Texture src, int srcElement, int srcMip, int dstMip);
        /*0x3dc0c30*/ void CopyPixels(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY);
        /*0x3dc0d18*/ bool get_ignoreMipmapLimit();
        /*0x3dc0d1c*/ void set_ignoreMipmapLimit(bool value);
    }

    class Cubemap : UnityEngine.Texture
    {
        static /*0x3dc0d78*/ bool Internal_CreateImpl(UnityEngine.Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x3dc0dfc*/ void Internal_Create(UnityEngine.Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x3dc1580*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x3dc0f60*/ void ApplyImpl_Injected(nint _unity_self, bool updateMipmaps, bool makeNoLongerReadable);
        static /*0x3dc102c*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x3dc1128*/ void SetPixelImpl_Injected(nint _unity_self, int image, int mip, int x, int y, ref UnityEngine.Color color);
        /*0x3dc1394*/ Cubemap(int width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x3dc1458*/ Cubemap(int width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x3dc13d0*/ Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x3dc14a4*/ Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x3dc15d4*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex, bool createUninitialized);
        /*0x3dc1730*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x3dc17c0*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, bool mipChain, bool createUninitialized);
        /*0x3dc185c*/ Cubemap(int width, UnityEngine.TextureFormat format, int mipCount);
        /*0x3dc1868*/ Cubemap(int width, UnityEngine.TextureFormat format, int mipCount, bool createUninitialized);
        /*0x3dc0ed0*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x3dc0fb4*/ bool get_isReadable();
        /*0x3dc1068*/ void SetPixelImpl(int image, int mip, int x, int y, UnityEngine.Color color);
        /*0x3dc119c*/ bool ValidateFormat(UnityEngine.TextureFormat format, int width);
        /*0x3dc126c*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width);
        /*0x3dc1874*/ void SetPixel(UnityEngine.CubemapFace face, int x, int y, UnityEngine.Color color);
        /*0x3dc187c*/ void SetPixel(UnityEngine.CubemapFace face, int x, int y, UnityEngine.Color color, int mip);
        /*0x3dc1928*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x3dc198c*/ void Apply();
    }

    class Texture3D : UnityEngine.Texture
    {
        static /*0x3dc1b80*/ bool Internal_CreateImpl(UnityEngine.Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x3dc1c1c*/ void Internal_Create(UnityEngine.Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x3dc2250*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x3dc1a10*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x3dc1b0c*/ void SetPixelImpl_Injected(nint _unity_self, int mip, int x, int y, int z, ref UnityEngine.Color color);
        static /*0x3dc1da0*/ void ApplyImpl_Injected(nint _unity_self, bool updateMipmaps, bool makeNoLongerReadable);
        static /*0x3dc1f04*/ void SetPixels_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, int miplevel);
        static /*0x3dc1fd0*/ nint GetImageData_Injected(nint _unity_self);
        /*0x3dc200c*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x3dc2100*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x3dc2060*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x3dc2164*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x3dc22a4*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount);
        /*0x3dc22c4*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex);
        /*0x3dc22e0*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex, bool createUninitialized);
        /*0x3dc2444*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x3dc24f8*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, bool createUninitialized);
        /*0x3dc25b8*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, nint nativeTex);
        /*0x3dc1998*/ bool get_isReadable();
        /*0x3dc1a4c*/ void SetPixelImpl(int mip, int x, int y, int z, UnityEngine.Color color);
        /*0x3dc1d10*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x3dc1df4*/ void SetPixels(UnityEngine.Color[] colors, int miplevel);
        /*0x3dc1f58*/ nint GetImageData();
        /*0x3dc2678*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x3dc26dc*/ void Apply(bool updateMipmaps);
        /*0x3dc26e4*/ void Apply();
        /*0x3dc26f0*/ void SetPixel(int x, int y, int z, UnityEngine.Color color, int mipLevel);
        /*0x1ffc854*/ Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel);
    }

    class Texture2DArray : UnityEngine.Texture
    {
        static /*0x3dc279c*/ int get_allSlices();
        static /*0x3dc2878*/ bool Internal_CreateImpl(UnityEngine.Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        static /*0x3dc2b04*/ void Internal_Create(UnityEngine.Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        static /*0x3dc30a8*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x3dc283c*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x3dc2a5c*/ bool Internal_CreateImpl_Injected(UnityEngine.Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, bool ignoreMipmapLimit, ref UnityEngine.Bindings.ManagedSpanWrapper mipmapLimitGroupName);
        /*0x3dc2d88*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x3dc2e8c*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x3dc2f1c*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x3dc2ddc*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x3dc2f00*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x3dc2f90*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x3dc30fc*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x3dc32a4*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized);
        /*0x3dc32c0*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x3dc32e0*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized);
        /*0x3dc33a8*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x3dc346c*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x3dc27c4*/ bool get_isReadable();
        /*0x3dc2b78*/ bool ValidateFormat(UnityEngine.TextureFormat format, int width, int height);
        /*0x3dc2c54*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height);
    }

    class CubemapArray : UnityEngine.Texture
    {
        static /*0x3dc35d8*/ bool Internal_CreateImpl(UnityEngine.CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x3dc365c*/ void Internal_Create(UnityEngine.CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x3dc3bcc*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x3dc359c*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x3dc37c0*/ void ApplyImpl_Injected(nint _unity_self, bool updateMipmaps, bool makeNoLongerReadable);
        static /*0x3dc393c*/ void SetPixels_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, UnityEngine.CubemapFace face, int arrayElement, int miplevel);
        /*0x3dc39b0*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x3dc3a8c*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x3dc39fc*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x3dc3ae0*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x3dc3c20*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized);
        /*0x3dc3d8c*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x3dc3d94*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized);
        /*0x3dc3e44*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x3dc3ee8*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x3dc3524*/ bool get_isReadable();
        /*0x3dc3730*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x3dc3814*/ void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, int arrayElement, int miplevel);
        /*0x3dc39a8*/ void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, int arrayElement);
        /*0x3dc3f88*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x3dc3fec*/ void Apply();
    }

    class RenderTexture : UnityEngine.Texture
    {
        static /*0x3dc5d18*/ UnityEngine.RenderTexture GetActive();
        static /*0x3dc5da0*/ void SetActive(UnityEngine.RenderTexture rt);
        static /*0x3dc5e58*/ UnityEngine.RenderTexture get_active();
        static /*0x3dc5e5c*/ void set_active(UnityEngine.RenderTexture value);
        static /*0x3dc6ba8*/ void Internal_Create(UnityEngine.RenderTexture rt);
        static /*0x3dc6be4*/ bool SupportsStencil(UnityEngine.RenderTexture rt);
        static /*0x3dc6da4*/ UnityEngine.RenderTexture GetTemporary_Internal(UnityEngine.RenderTextureDescriptor desc);
        static /*0x3dc6e4c*/ void ReleaseTemporary(UnityEngine.RenderTexture temp);
        static /*0x3dc7c24*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat);
        static /*0x3dc8164*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.RenderTextureFormat format, bool disableFallback);
        static /*0x3dc82cc*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Experimental.Rendering.DefaultFormat format);
        static /*0x3dc82d8*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Rendering.ShadowSamplingMode shadowSamplingMode);
        static /*0x3dc81b0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap);
        static /*0x3dc7190*/ void ValidateRenderTextureDesc(ref UnityEngine.RenderTextureDescriptor desc);
        static /*0x3dc782c*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultColorFormat(UnityEngine.Experimental.Rendering.DefaultFormat format);
        static /*0x3dc7848*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultDepthStencilFormat(UnityEngine.Experimental.Rendering.DefaultFormat format, int depth);
        static /*0x3dc81a0*/ UnityEngine.Rendering.ShadowSamplingMode GetShadowSamplingModeForFormat(UnityEngine.RenderTextureFormat format);
        static /*0x3dc79f4*/ UnityEngine.Rendering.ShadowSamplingMode GetShadowSamplingModeForFormat(UnityEngine.Experimental.Rendering.DefaultFormat format);
        static /*0x3dc4da8*/ void WarnAboutFallbackTo16BitsDepth(UnityEngine.RenderTextureFormat format);
        static /*0x3dc800c*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.RenderTextureFormat renderTextureFormat, UnityEngine.RenderTextureReadWrite readWrite);
        static /*0x3dc83b8*/ UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc);
        static /*0x3dc841c*/ UnityEngine.RenderTexture GetTemporaryImpl(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale, UnityEngine.Rendering.ShadowSamplingMode shadowSamplingMode);
        static /*0x3dc85ac*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale);
        static /*0x3dc862c*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage);
        static /*0x3dc86a8*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode);
        static /*0x3dc8718*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing);
        static /*0x3dc8784*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format);
        static /*0x3dc87e4*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale);
        static /*0x3dc8888*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage);
        static /*0x3dc88a4*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode);
        static /*0x3dc88c4*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing);
        static /*0x3dc88e8*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
        static /*0x3dc8910*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format);
        static /*0x3dc893c*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer);
        static /*0x3dc896c*/ UnityEngine.RenderTexture GetTemporary(int width, int height);
        static /*0x3dc8a2c*/ bool get_enabled();
        static /*0x3dc8a34*/ void set_enabled(bool value);
        static /*0x3dc4070*/ int get_width_Injected(nint _unity_self);
        static /*0x3dc412c*/ void set_width_Injected(nint _unity_self, int value);
        static /*0x3dc41e8*/ int get_height_Injected(nint _unity_self);
        static /*0x3dc42a4*/ void set_height_Injected(nint _unity_self, int value);
        static /*0x3dc4360*/ UnityEngine.Rendering.TextureDimension get_dimension_Injected(nint _unity_self);
        static /*0x3dc441c*/ void set_dimension_Injected(nint _unity_self, UnityEngine.Rendering.TextureDimension value);
        static /*0x3dc44e0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetColorFormat_Injected(nint _unity_self, bool suppressWarnings);
        static /*0x3dc45a4*/ void SetColorFormat_Injected(nint _unity_self, UnityEngine.Experimental.Rendering.GraphicsFormat format);
        static /*0x3dc466c*/ bool get_useMipMap_Injected(nint _unity_self);
        static /*0x3dc4728*/ void set_useMipMap_Injected(nint _unity_self, bool value);
        static /*0x3dc47e4*/ bool get_sRGB_Injected(nint _unity_self);
        static /*0x3dc4898*/ UnityEngine.VRTextureUsage get_vrUsage_Injected(nint _unity_self);
        static /*0x3dc4954*/ void set_vrUsage_Injected(nint _unity_self, UnityEngine.VRTextureUsage value);
        static /*0x3dc4a10*/ UnityEngine.RenderTextureMemoryless get_memorylessMode_Injected(nint _unity_self);
        static /*0x3dc4acc*/ void set_memorylessMode_Injected(nint _unity_self, UnityEngine.RenderTextureMemoryless value);
        static /*0x3dc4fe0*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_stencilFormat_Injected(nint _unity_self);
        static /*0x3dc509c*/ void set_stencilFormat_Injected(nint _unity_self, UnityEngine.Experimental.Rendering.GraphicsFormat value);
        static /*0x3dc50e0*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat_Injected(nint _unity_self);
        static /*0x3dc511c*/ void set_depthStencilFormat_Injected(nint _unity_self, UnityEngine.Experimental.Rendering.GraphicsFormat value);
        static /*0x3dc51d8*/ bool get_autoGenerateMips_Injected(nint _unity_self);
        static /*0x3dc5294*/ void set_autoGenerateMips_Injected(nint _unity_self, bool value);
        static /*0x3dc5350*/ int get_volumeDepth_Injected(nint _unity_self);
        static /*0x3dc540c*/ void set_volumeDepth_Injected(nint _unity_self, int value);
        static /*0x3dc54c8*/ int get_antiAliasing_Injected(nint _unity_self);
        static /*0x3dc5584*/ void set_antiAliasing_Injected(nint _unity_self, int value);
        static /*0x3dc5640*/ bool get_bindTextureMS_Injected(nint _unity_self);
        static /*0x3dc56fc*/ void set_bindTextureMS_Injected(nint _unity_self, bool value);
        static /*0x3dc57b8*/ bool get_enableRandomWrite_Injected(nint _unity_self);
        static /*0x3dc5874*/ void set_enableRandomWrite_Injected(nint _unity_self, bool value);
        static /*0x3dc5930*/ bool get_useDynamicScale_Injected(nint _unity_self);
        static /*0x3dc59ec*/ void set_useDynamicScale_Injected(nint _unity_self, bool value);
        static /*0x3dc5aa8*/ bool get_useDynamicScaleExplicit_Injected(nint _unity_self);
        static /*0x3dc5b64*/ void set_useDynamicScaleExplicit_Injected(nint _unity_self, bool value);
        static /*0x3dc5c20*/ void ApplyDynamicScale_Injected(nint _unity_self);
        static /*0x3dc5cd4*/ bool GetIsPowerOfTwo_Injected(nint _unity_self);
        static /*0x3dc5d78*/ nint GetActive_Injected();
        static /*0x3dc5e1c*/ void SetActive_Injected(nint rt);
        static /*0x3dc5ef0*/ void GetColorBuffer_Injected(nint _unity_self, ref UnityEngine.RenderBuffer ret);
        static /*0x3dc5fc4*/ void GetDepthBuffer_Injected(nint _unity_self, ref UnityEngine.RenderBuffer ret);
        static /*0x3dc6088*/ void SetMipMapCount_Injected(nint _unity_self, int count);
        static /*0x3dc60cc*/ void SetShadowSamplingMode_Injected(nint _unity_self, UnityEngine.Rendering.ShadowSamplingMode samplingMode);
        static /*0x3dc6190*/ nint GetNativeDepthBufferPtr_Injected(nint _unity_self);
        static /*0x3dc625c*/ void DiscardContents_Injected(nint _unity_self, bool discardColor, bool discardDepth);
        static /*0x3dc6328*/ void MarkRestoreExpected_Injected(nint _unity_self);
        static /*0x3dc63e8*/ void ResolveAA_Injected(nint _unity_self);
        static /*0x3dc64d8*/ void ResolveAATo_Injected(nint _unity_self, nint rt);
        static /*0x3dc66c0*/ void SetGlobalShaderProperty_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper propertyName);
        static /*0x3dc677c*/ bool Create_Injected(nint _unity_self);
        static /*0x3dc6830*/ void Release_Injected(nint _unity_self);
        static /*0x3dc68e4*/ bool IsCreated_Injected(nint _unity_self);
        static /*0x3dc6998*/ void GenerateMips_Injected(nint _unity_self);
        static /*0x3dc6a90*/ void ConvertToEquirect_Injected(nint _unity_self, nint equirect, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        static /*0x3dc6b64*/ void SetSRGBReadWrite_Injected(nint _unity_self, bool srgb);
        static /*0x3dc6c60*/ bool SupportsStencil_Injected(nint rt);
        static /*0x3dc6d1c*/ void SetRenderTextureDescriptor_Injected(nint _unity_self, ref UnityEngine.RenderTextureDescriptor desc);
        static /*0x3dc6d60*/ void GetDescriptor_Injected(nint _unity_self, ref UnityEngine.RenderTextureDescriptor ret);
        static /*0x3dc6e10*/ nint GetTemporary_Internal_Injected(ref UnityEngine.RenderTextureDescriptor desc);
        static /*0x3dc6ec8*/ void ReleaseTemporary_Injected(nint temp);
        static /*0x3dc6f7c*/ int get_depth_Injected(nint _unity_self);
        static /*0x3dc7038*/ void set_depth_Injected(nint _unity_self, int value);
        /*0x3dc707c*/ RenderTexture();
        /*0x3dc70d0*/ RenderTexture(UnityEngine.RenderTextureDescriptor desc);
        /*0x3dc7558*/ RenderTexture(UnityEngine.RenderTexture textureToCopy);
        /*0x3dc76f8*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format);
        /*0x3dc7a04*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x3dc7a94*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount);
        /*0x3dc7870*/ RenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount);
        /*0x3dc7c2c*/ RenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
        /*0x3dc7cbc*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
        /*0x3dc7ed4*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format);
        /*0x3dc8004*/ RenderTexture(int width, int height, int depth);
        /*0x3dc7f64*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format, int mipCount);
        /*0x3dc3ff8*/ int get_width();
        /*0x3dc40ac*/ void set_width(int value);
        /*0x3dc4170*/ int get_height();
        /*0x3dc4224*/ void set_height(int value);
        /*0x3dc42e8*/ UnityEngine.Rendering.TextureDimension get_dimension();
        /*0x3dc439c*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
        /*0x3dc4460*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetColorFormat(bool suppressWarnings);
        /*0x3dc4524*/ void SetColorFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x3dc45e8*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x3dc45f0*/ void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x3dc45f4*/ bool get_useMipMap();
        /*0x3dc46a8*/ void set_useMipMap(bool value);
        /*0x3dc476c*/ bool get_sRGB();
        /*0x3dc4820*/ UnityEngine.VRTextureUsage get_vrUsage();
        /*0x3dc48d4*/ void set_vrUsage(UnityEngine.VRTextureUsage value);
        /*0x3dc4998*/ UnityEngine.RenderTextureMemoryless get_memorylessMode();
        /*0x3dc4a4c*/ void set_memorylessMode(UnityEngine.RenderTextureMemoryless value);
        /*0x3dc4b10*/ UnityEngine.RenderTextureFormat get_format();
        /*0x3dc4c74*/ void set_format(UnityEngine.RenderTextureFormat value);
        /*0x3dc4f68*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_stencilFormat();
        /*0x3dc501c*/ void set_stencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x3dc4d30*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat();
        /*0x3dc4e68*/ void set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x3dc5160*/ bool get_autoGenerateMips();
        /*0x3dc5214*/ void set_autoGenerateMips(bool value);
        /*0x3dc52d8*/ int get_volumeDepth();
        /*0x3dc538c*/ void set_volumeDepth(int value);
        /*0x3dc5450*/ int get_antiAliasing();
        /*0x3dc5504*/ void set_antiAliasing(int value);
        /*0x3dc55c8*/ bool get_bindTextureMS();
        /*0x3dc567c*/ void set_bindTextureMS(bool value);
        /*0x3dc5740*/ bool get_enableRandomWrite();
        /*0x3dc57f4*/ void set_enableRandomWrite(bool value);
        /*0x3dc58b8*/ bool get_useDynamicScale();
        /*0x3dc596c*/ void set_useDynamicScale(bool value);
        /*0x3dc5a30*/ bool get_useDynamicScaleExplicit();
        /*0x3dc5ae4*/ void set_useDynamicScaleExplicit(bool value);
        /*0x3dc5ba8*/ void ApplyDynamicScale();
        /*0x3dc5c5c*/ bool GetIsPowerOfTwo();
        /*0x3dc5d10*/ bool get_isPowerOfTwo();
        /*0x3dc5d14*/ void set_isPowerOfTwo(bool value);
        /*0x3dc5e60*/ UnityEngine.RenderBuffer GetColorBuffer();
        /*0x3dc5f34*/ UnityEngine.RenderBuffer GetDepthBuffer();
        /*0x3dc6008*/ void SetMipMapCount(int count);
        /*0x3dc4ee8*/ void SetShadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode samplingMode);
        /*0x3dc6110*/ UnityEngine.RenderBuffer get_colorBuffer();
        /*0x3dc6114*/ UnityEngine.RenderBuffer get_depthBuffer();
        /*0x3dc6118*/ nint GetNativeDepthBufferPtr();
        /*0x3dc61cc*/ void DiscardContents(bool discardColor, bool discardDepth);
        /*0x3dc62b0*/ void MarkRestoreExpected();
        /*0x3dc6364*/ void DiscardContents();
        /*0x3dc6370*/ void ResolveAA();
        /*0x3dc6424*/ void ResolveAATo(UnityEngine.RenderTexture rt);
        /*0x3dc651c*/ void ResolveAntiAliasedSurface();
        /*0x3dc6520*/ void ResolveAntiAliasedSurface(UnityEngine.RenderTexture target);
        /*0x3dc6524*/ void SetGlobalShaderProperty(string propertyName);
        /*0x3dc6704*/ bool Create();
        /*0x3dc67b8*/ void Release();
        /*0x3dc686c*/ bool IsCreated();
        /*0x3dc6920*/ void GenerateMips();
        /*0x3dc69d4*/ void ConvertToEquirect(UnityEngine.RenderTexture equirect, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x3dc6ae4*/ void SetSRGBReadWrite(bool srgb);
        /*0x3dc6c9c*/ void SetRenderTextureDescriptor(UnityEngine.RenderTextureDescriptor desc);
        /*0x3dc4bc0*/ UnityEngine.RenderTextureDescriptor GetDescriptor();
        /*0x3dc6f04*/ int get_depth();
        /*0x3dc6fb8*/ void set_depth(int value);
        /*0x3dc7d64*/ void Initialize(int width, int height, int depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int mipCount);
        /*0x3dc76bc*/ UnityEngine.RenderTextureDescriptor get_descriptor();
        /*0x3dc82e4*/ void set_descriptor(UnityEngine.RenderTextureDescriptor value);
        /*0x3dc89a0*/ bool get_isCubemap();
        /*0x3dc89c0*/ void set_isCubemap(bool value);
        /*0x3dc89e8*/ bool get_isVolume();
        /*0x3dc8a08*/ void set_isVolume(bool value);
        /*0x3dc8a38*/ UnityEngine.Vector2 GetTexelOffset();
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

        /*0x3dc8e04*/ RenderTextureDescriptor(int width, int height);
        /*0x3dc8e10*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat);
        /*0x3dc8e18*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits);
        /*0x3dc8eb4*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits);
        /*0x3dc8eac*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits, int mipCount);
        /*0x3dc8fb0*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits, int mipCount, UnityEngine.RenderTextureReadWrite readWrite);
        /*0x3dc8f44*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits, int mipCount);
        /*0x3dc84cc*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
        /*0x3dc9084*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount);
        /*0x3dc8a78*/ int get_width();
        /*0x3dc8a80*/ void set_width(int value);
        /*0x3dc8a88*/ int get_height();
        /*0x3dc8a90*/ void set_height(int value);
        /*0x3dc8a98*/ int get_msaaSamples();
        /*0x3dc8aa0*/ void set_msaaSamples(int value);
        /*0x3dc8aa8*/ int get_volumeDepth();
        /*0x3dc8ab0*/ void set_volumeDepth(int value);
        /*0x3dc8ab8*/ void set_mipCount(int value);
        /*0x3dc8334*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x3dc8ac0*/ void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x3dc8b64*/ void set_stencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x3dc8b6c*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat();
        /*0x3dc8b74*/ void set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x3dc833c*/ UnityEngine.RenderTextureFormat get_colorFormat();
        /*0x3dc8b7c*/ void set_colorFormat(UnityEngine.RenderTextureFormat value);
        /*0x3dc8c3c*/ bool get_sRGB();
        /*0x3dc8cf4*/ void set_sRGB(bool value);
        /*0x3dc8c98*/ int get_depthBufferBits();
        /*0x3dc8d98*/ void set_depthBufferBits(int value);
        /*0x3dc8dc4*/ UnityEngine.Rendering.TextureDimension get_dimension();
        /*0x3dc8dcc*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
        /*0x3dc8dd4*/ UnityEngine.Rendering.ShadowSamplingMode get_shadowSamplingMode();
        /*0x3dc8ddc*/ void set_shadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode value);
        /*0x3dc8de4*/ UnityEngine.VRTextureUsage get_vrUsage();
        /*0x3dc8dec*/ void set_vrUsage(UnityEngine.VRTextureUsage value);
        /*0x3dc8df4*/ UnityEngine.RenderTextureMemoryless get_memoryless();
        /*0x3dc8dfc*/ void set_memoryless(UnityEngine.RenderTextureMemoryless value);
        /*0x3dc8b48*/ void SetOrClearRenderTextureCreationFlag(bool value, UnityEngine.RenderTextureCreationFlags flag);
        /*0x3dc90e4*/ bool get_useMipMap();
        /*0x3dc90f0*/ void set_useMipMap(bool value);
        /*0x3dc9100*/ bool get_autoGenerateMips();
        /*0x3dc910c*/ void set_autoGenerateMips(bool value);
        /*0x3dc912c*/ bool get_enableRandomWrite();
        /*0x3dc9138*/ void set_enableRandomWrite(bool value);
        /*0x3dc9158*/ bool get_bindMS();
        /*0x3dc9164*/ void set_bindMS(bool value);
        /*0x3dc83fc*/ void set_createdFromScript(bool value);
        /*0x3dc9184*/ bool get_useDynamicScale();
        /*0x3dc858c*/ void set_useDynamicScale(bool value);
        /*0x3dc9190*/ bool get_useDynamicScaleExplicit();
        /*0x3dc919c*/ void set_useDynamicScaleExplicit(bool value);
    }

    struct MipmapLimitDescriptor
    {
        /*0x10*/ bool <useMipmapLimit>k__BackingField;
        /*0x18*/ string <groupName>k__BackingField;

        /*0x3dbf76c*/ MipmapLimitDescriptor(bool useMipmapLimit, string groupName);
        /*0x3dc91bc*/ bool get_useMipmapLimit();
        /*0x3dc91c4*/ string get_groupName();
    }

    class Handheld
    {
        static /*0x3dc91cc*/ void ClearShaderCache();
    }

    struct Hash128 : System.IComparable, System.IComparable<UnityEngine.Hash128>, System.IEquatable<UnityEngine.Hash128>
    {
        static ulong kConst = 16045690984833335023;
        /*0x10*/ ulong u64_0;
        /*0x18*/ ulong u64_1;

        static /*0x3dc939c*/ UnityEngine.Hash128 Parse(string hashString);
        static /*0x3dc92cc*/ string Hash128ToStringImpl(UnityEngine.Hash128 hash);
        static /*0x3dc9598*/ void ComputeFromString(string data, ref UnityEngine.Hash128 hash);
        static /*0x3dc974c*/ void ComputeFromPtr(nint data, int start, int count, int elemSize, ref UnityEngine.Hash128 hash);
        static /*0x3dc97b8*/ UnityEngine.Hash128 Compute(string data);
        static UnityEngine.Hash128 Compute<T>(ref T val);
        static /*0x3dc97dc*/ UnityEngine.Hash128 Compute(int val);
        static /*0x3dc9900*/ bool op_Equality(UnityEngine.Hash128 hash1, UnityEngine.Hash128 hash2);
        static /*0x3dc9a0c*/ bool op_Inequality(UnityEngine.Hash128 hash1, UnityEngine.Hash128 hash2);
        static /*0x3dc9280*/ bool op_LessThan(UnityEngine.Hash128 x, UnityEngine.Hash128 y);
        static /*0x3dc9298*/ bool op_GreaterThan(UnityEngine.Hash128 x, UnityEngine.Hash128 y);
        static /*0x3dc9a1c*/ void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3);
        static /*0x3dc9bb0*/ void Rot64(ref ulong x, int k);
        static /*0x3dc9510*/ void Parse_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper hashString, ref UnityEngine.Hash128 ret);
        static /*0x3dc9554*/ void Hash128ToStringImpl_Injected(ref UnityEngine.Hash128 hash, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3dc9708*/ void ComputeFromString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper data, ref UnityEngine.Hash128 hash);
        /*0x3dc91f4*/ Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3);
        /*0x3dc920c*/ Hash128(ulong u64_0, ulong u64_1);
        /*0x3dc9214*/ bool get_isValid();
        /*0x3dc9234*/ int CompareTo(UnityEngine.Hash128 rhs);
        /*0x3dc92c0*/ string ToString();
        /*0x3dc9808*/ void Append(string data);
        /*0x1f30ebc*/ void Append<T>(ref T val);
        /*0x3dc9804*/ void Append(int val);
        /*0x3dc9884*/ bool Equals(object obj);
        /*0x3dc9910*/ bool Equals(UnityEngine.Hash128 obj);
        /*0x3dc9924*/ int GetHashCode();
        /*0x3dc9958*/ int CompareTo(object obj);
        /*0x3dc9818*/ void ShortHash4(uint data);
    }

    class HashUtilities
    {
        static /*0x3dc9bc4*/ void AppendHash(ref UnityEngine.Hash128 inHash, ref UnityEngine.Hash128 outHash);
    }

    class HashUnsafeUtilities
    {
        static /*0x3dc9c24*/ void ComputeHash128(void* data, ulong dataSize, ulong* hash1, ulong* hash2);
        static /*0x3dc9bd0*/ void ComputeHash128(void* data, ulong dataSize, UnityEngine.Hash128* hash);
    }

    class SpookyHash
    {
        static /*0x3dc9c28*/ void Hash(void* message, ulong length, ulong* hash1, ulong* hash2);
        static /*0x3dca530*/ void End(ulong* data, ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11);
        static /*0x3dca6e8*/ void EndPartial(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11);
        static /*0x3dca8dc*/ void Rot64(ref ulong x, int k);
        static /*0x3dc9ecc*/ void Short(void* message, ulong length, ulong* hash1, ulong* hash2);
        static /*0x3dca8f0*/ void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3);
        static /*0x3dcaaa4*/ void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3);
        static /*0x3dca188*/ void Mix(ulong* data, ref ulong s0, ref ulong s1, ref ulong s2, ref ulong s3, ref ulong s4, ref ulong s5, ref ulong s6, ref ulong s7, ref ulong s8, ref ulong s9, ref ulong s10, ref ulong s11);

        struct U
        {
            /*0x10*/ byte* p8;
            /*0x10*/ uint* p32;
            /*0x10*/ ulong* p64;
            /*0x10*/ ulong i;

            /*0x3dca180*/ U(ushort* p8);
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
        static /*0x3dcac38*/ void SetCursor(UnityEngine.Texture2D texture, UnityEngine.Vector2 hotspot, UnityEngine.CursorMode cursorMode);
        static /*0x3dcad24*/ void set_visible(bool value);
        static /*0x3dcad60*/ UnityEngine.CursorLockMode get_lockState();
        static /*0x3dcad88*/ void set_lockState(UnityEngine.CursorLockMode value);
        static /*0x3dcacd0*/ void SetCursor_Injected(nint texture, ref UnityEngine.Vector2 hotspot, UnityEngine.CursorMode cursorMode);
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
        WheelUp = 321,
        WheelDown = 322,
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

    interface ILogHandler
    {
        void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
        /*0x1f30ff0*/ void LogException(System.Exception exception, UnityEngine.Object context);
    }

    interface ILogger : UnityEngine.ILogHandler
    {
        /*0x1f30214*/ UnityEngine.ILogHandler get_logHandler();
        /*0x1f2fe14*/ bool get_logEnabled();
        /*0x1f30b78*/ void set_filterLogType(UnityEngine.LogType value);
        /*0x1f2fe40*/ bool IsLogTypeAllowed(UnityEngine.LogType logType);
        /*0x1f30c88*/ void Log(UnityEngine.LogType logType, object message);
        /*0x1f30d20*/ void Log(UnityEngine.LogType logType, object message, UnityEngine.Object context);
        /*0x1f30ebc*/ void Log(object message);
        /*0x1f30ff0*/ void LogWarning(string tag, object message);
        /*0x1f30ff0*/ void LogError(string tag, object message);
        /*0x1f30d20*/ void LogFormat(UnityEngine.LogType logType, string format, object[] args);
    }

    class Logger : UnityEngine.ILogger, UnityEngine.ILogHandler
    {
        /*0x10*/ UnityEngine.ILogHandler <logHandler>k__BackingField;
        /*0x18*/ bool <logEnabled>k__BackingField;
        /*0x1c*/ UnityEngine.LogType <filterLogType>k__BackingField;

        static /*0x3dcae6c*/ string GetString(object message);
        /*0x3dcadc4*/ Logger(UnityEngine.ILogHandler logHandler);
        /*0x3dcae08*/ UnityEngine.ILogHandler get_logHandler();
        /*0x3dcae10*/ void set_logHandler(UnityEngine.ILogHandler value);
        /*0x3dcae18*/ bool get_logEnabled();
        /*0x3dcae20*/ void set_logEnabled(bool value);
        /*0x3dcae28*/ UnityEngine.LogType get_filterLogType();
        /*0x3dcae30*/ void set_filterLogType(UnityEngine.LogType value);
        /*0x3dcae38*/ bool IsLogTypeAllowed(UnityEngine.LogType logType);
        /*0x3dcaf8c*/ void Log(UnityEngine.LogType logType, object message);
        /*0x3dcb10c*/ void Log(UnityEngine.LogType logType, object message, UnityEngine.Object context);
        /*0x3dcb290*/ void Log(object message);
        /*0x3dcb3f8*/ void LogWarning(string tag, object message);
        /*0x3dcb5a4*/ void LogError(string tag, object message);
        /*0x3dcb74c*/ void LogException(System.Exception exception, UnityEngine.Object context);
        /*0x3dcb820*/ void LogFormat(UnityEngine.LogType logType, string format, object[] args);
        /*0x3dcb918*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
    }

    class UnityLogWriter : System.IO.TextWriter
    {
        static /*0x3dcba20*/ void WriteStringToUnityLog(string s);
        static /*0x3dcba2c*/ void WriteStringToUnityLogImpl(string s);
        static /*0x3dcbbd0*/ void Init();
        static /*0x3dcbb94*/ void WriteStringToUnityLogImpl_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper s);
        /*0x3dcbc8c*/ UnityLogWriter();
        /*0x3dcbce4*/ System.Text.Encoding get_Encoding();
        /*0x3dcbcec*/ void Write(char value);
        /*0x3dcbd28*/ void Write(string s);
        /*0x3dcbd38*/ void Write(char[] buffer, int index, int count);
    }

    struct Color : System.IEquatable<UnityEngine.Color>, System.IFormattable
    {
        /*0x10*/ float r;
        /*0x14*/ float g;
        /*0x18*/ float b;
        /*0x1c*/ float a;

        static /*0x3dcc188*/ UnityEngine.Color op_Addition(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x3dcc19c*/ UnityEngine.Color op_Subtraction(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x3dcc1b0*/ UnityEngine.Color op_Multiply(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x3dcc1c4*/ UnityEngine.Color op_Multiply(UnityEngine.Color a, float b);
        static /*0x3dcc1d8*/ bool op_Equality(UnityEngine.Color lhs, UnityEngine.Color rhs);
        static /*0x3dcc218*/ bool op_Inequality(UnityEngine.Color lhs, UnityEngine.Color rhs);
        static /*0x3dcc258*/ UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, float t);
        static /*0x3dcc2a8*/ UnityEngine.Color LerpUnclamped(UnityEngine.Color a, UnityEngine.Color b, float t);
        static /*0x3dcc2fc*/ UnityEngine.Color get_red();
        static /*0x3dcc310*/ UnityEngine.Color get_green();
        static /*0x3dcc324*/ UnityEngine.Color get_blue();
        static /*0x3dcc338*/ UnityEngine.Color get_white();
        static /*0x3dcc34c*/ UnityEngine.Color get_black();
        static /*0x3dcc360*/ UnityEngine.Color get_yellow();
        static /*0x3dcc37c*/ UnityEngine.Color get_cyan();
        static /*0x3dcc390*/ UnityEngine.Color get_magenta();
        static /*0x3dcc3a4*/ UnityEngine.Color get_gray();
        static /*0x3dcc3b8*/ UnityEngine.Color get_grey();
        static /*0x3dcc3cc*/ UnityEngine.Color get_clear();
        static /*0x3dcc5cc*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Color c);
        static /*0x3dcc5d0*/ UnityEngine.Color op_Implicit(UnityEngine.Vector4 v);
        static /*0x3dcc5d4*/ UnityEngine.Color HSVToRGB(float H, float S, float V);
        static /*0x3dcc5dc*/ UnityEngine.Color HSVToRGB(float H, float S, float V, bool hdr);
        /*0x3dcbd50*/ Color(float r, float g, float b, float a);
        /*0x3dcbd5c*/ Color(float r, float g, float b);
        /*0x3dcbd70*/ string ToString();
        /*0x3dcbd80*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x3dcbfb8*/ int GetHashCode();
        /*0x3dcc034*/ bool Equals(object other);
        /*0x3dcc108*/ bool Equals(UnityEngine.Color other);
        /*0x3dcc2e0*/ UnityEngine.Color RGBMultiplied(float multiplier);
        /*0x3dcc3e0*/ UnityEngine.Color get_linear();
        /*0x3dcc4c8*/ UnityEngine.Color get_gamma();
        /*0x3dcc5b0*/ float get_maxColorComponent();
    }

    struct Color32 : System.IEquatable<UnityEngine.Color32>, System.IFormattable
    {
        /*0x10*/ int rgba;
        /*0x10*/ byte r;
        /*0x11*/ byte g;
        /*0x12*/ byte b;
        /*0x13*/ byte a;

        static /*0x3dcc78c*/ UnityEngine.Color32 op_Implicit(UnityEngine.Color c);
        static /*0x3dcca7c*/ UnityEngine.Color op_Implicit(UnityEngine.Color32 c);
        static /*0x3dccab8*/ UnityEngine.Color32 LerpUnclamped(UnityEngine.Color32 a, UnityEngine.Color32 b, float t);
        /*0x3dcc774*/ Color32(byte r, byte g, byte b, byte a);
        /*0x3dccb88*/ int GetHashCode();
        /*0x3dccb90*/ bool Equals(object other);
        /*0x3dccc08*/ bool Equals(UnityEngine.Color32 other);
        /*0x3dccc18*/ string ToString();
        /*0x3dccc28*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    class ColorUtility
    {
        static /*0x3dcce34*/ bool DoTryParseHtmlColor(string htmlString, ref UnityEngine.Color32 color);
        static /*0x3dccff4*/ bool TryParseHtmlString(string htmlString, ref UnityEngine.Color color);
        static /*0x3dcd060*/ string ToHtmlStringRGBA(UnityEngine.Color color);
        static /*0x3dccfb0*/ bool DoTryParseHtmlColor_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper htmlString, ref UnityEngine.Color32 color);
    }

    struct GradientColorKey
    {
        /*0x10*/ UnityEngine.Color color;
        /*0x20*/ float time;

        /*0x3dcd560*/ GradientColorKey(UnityEngine.Color col, float time);
    }

    struct GradientAlphaKey
    {
        /*0x10*/ float alpha;
        /*0x14*/ float time;

        /*0x3dcd570*/ GradientAlphaKey(float alpha, float time);
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
        /*0x18*/ bool m_RequiresNativeCleanup;

        static /*0x3dcd578*/ nint Init();
        static /*0x3dcd5f0*/ void Cleanup_Injected(nint _unity_self);
        static /*0x3dcd684*/ bool Internal_Equals_Injected(nint _unity_self, nint other);
        static /*0x3dcd848*/ void Evaluate_Injected(nint _unity_self, float time, ref UnityEngine.Color ret);
        static /*0x3dcd9e4*/ void get_colorKeys_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3dcdb70*/ void get_alphaKeys_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x3dcdc04*/ UnityEngine.GradientMode get_mode_Injected(nint _unity_self);
        static /*0x3dcdc98*/ void set_mode_Injected(nint _unity_self, UnityEngine.GradientMode value);
        static /*0x3dcdd2c*/ UnityEngine.ColorSpace get_colorSpace_Injected(nint _unity_self);
        static /*0x3dcddc0*/ void set_colorSpace_Injected(nint _unity_self, UnityEngine.ColorSpace value);
        static /*0x3dcdf7c*/ void SetKeys_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colorKeys, ref UnityEngine.Bindings.ManagedSpanWrapper alphaKeys);
        /*0x3dcd6c8*/ Gradient();
        /*0x3dcd714*/ Gradient(nint ptr);
        /*0x3dcd5a0*/ void Cleanup();
        /*0x3dcd62c*/ bool Internal_Equals(nint other);
        /*0x3dcd740*/ void Finalize();
        /*0x3dcd7cc*/ UnityEngine.Color Evaluate(float time);
        /*0x3dcd89c*/ UnityEngine.GradientColorKey[] get_colorKeys();
        /*0x3dcda28*/ UnityEngine.GradientAlphaKey[] get_alphaKeys();
        /*0x3dcdbb4*/ UnityEngine.GradientMode get_mode();
        /*0x3dcdc40*/ void set_mode(UnityEngine.GradientMode value);
        /*0x3dcdcdc*/ UnityEngine.ColorSpace get_colorSpace();
        /*0x3dcdd68*/ void set_colorSpace(UnityEngine.ColorSpace value);
        /*0x3dcde04*/ void SetKeys(UnityEngine.GradientColorKey[] colorKeys, UnityEngine.GradientAlphaKey[] alphaKeys);
        /*0x3dcdfd0*/ bool Equals(object o);
        /*0x3dce0d0*/ bool Equals(UnityEngine.Gradient other);
        /*0x3dce148*/ int GetHashCode();

        class BindingsMarshaller
        {
            static /*0x3dce154*/ nint ConvertToNative(UnityEngine.Gradient graident);
            static /*0x3dce168*/ UnityEngine.Gradient ConvertToManaged(nint ptr);
        }
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

        static /*0x3dcfc0c*/ Matrix4x4();
        static /*0x3dce42c*/ UnityEngine.Matrix4x4 TRS(UnityEngine.Vector3 pos, UnityEngine.Quaternion q, UnityEngine.Vector3 s);
        static /*0x3dce518*/ bool Inverse3DAffine(UnityEngine.Matrix4x4 input, ref UnityEngine.Matrix4x4 result);
        static /*0x3dce5a0*/ UnityEngine.Matrix4x4 Inverse(UnityEngine.Matrix4x4 m);
        static /*0x3dce6d8*/ UnityEngine.Matrix4x4 Transpose(UnityEngine.Matrix4x4 m);
        static /*0x3dce810*/ UnityEngine.Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar);
        static /*0x3dce940*/ UnityEngine.Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar);
        static /*0x3dcea40*/ UnityEngine.Matrix4x4 LookAt(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 up);
        static /*0x3dcf134*/ UnityEngine.Matrix4x4 op_Multiply(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs);
        static /*0x3dcf1d8*/ UnityEngine.Vector4 op_Multiply(UnityEngine.Matrix4x4 lhs, UnityEngine.Vector4 vector);
        static /*0x3dcf48c*/ UnityEngine.Matrix4x4 Scale(UnityEngine.Vector3 vector);
        static /*0x3dcf4b8*/ UnityEngine.Matrix4x4 Translate(UnityEngine.Vector3 vector);
        static /*0x3dcf4ec*/ UnityEngine.Matrix4x4 Rotate(UnityEngine.Quaternion q);
        static /*0x3dcf584*/ UnityEngine.Matrix4x4 get_zero();
        static /*0x3dcf5dc*/ UnityEngine.Matrix4x4 get_identity();
        static /*0x3dce220*/ void GetRotation_Injected(ref UnityEngine.Matrix4x4 _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x3dce2c0*/ void GetLossyScale_Injected(ref UnityEngine.Matrix4x4 _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3dce36c*/ void DecomposeProjection_Injected(ref UnityEngine.Matrix4x4 _unity_self, ref UnityEngine.FrustumPlanes ret);
        static /*0x3dce4bc*/ void TRS_Injected(ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion q, ref UnityEngine.Vector3 s, ref UnityEngine.Matrix4x4 ret);
        static /*0x3dce55c*/ bool Inverse3DAffine_Injected(ref UnityEngine.Matrix4x4 input, ref UnityEngine.Matrix4x4 result);
        static /*0x3dce60c*/ void Inverse_Injected(ref UnityEngine.Matrix4x4 m, ref UnityEngine.Matrix4x4 ret);
        static /*0x3dce744*/ void Transpose_Injected(ref UnityEngine.Matrix4x4 m, ref UnityEngine.Matrix4x4 ret);
        static /*0x3dce8bc*/ void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, ref UnityEngine.Matrix4x4 ret);
        static /*0x3dce9d4*/ void Perspective_Injected(float fov, float aspect, float zNear, float zFar, ref UnityEngine.Matrix4x4 ret);
        static /*0x3dcead0*/ void LookAt_Injected(ref UnityEngine.Vector3 from, ref UnityEngine.Vector3 to, ref UnityEngine.Vector3 up, ref UnityEngine.Matrix4x4 ret);
        /*0x3dceb2c*/ Matrix4x4(UnityEngine.Vector4 column0, UnityEngine.Vector4 column1, UnityEngine.Vector4 column2, UnityEngine.Vector4 column3);
        /*0x3dce1c8*/ UnityEngine.Quaternion GetRotation();
        /*0x3dce264*/ UnityEngine.Vector3 GetLossyScale();
        /*0x3dce304*/ UnityEngine.FrustumPlanes DecomposeProjection();
        /*0x3dce3b0*/ UnityEngine.Quaternion get_rotation();
        /*0x3dce3b4*/ UnityEngine.Vector3 get_lossyScale();
        /*0x3dce3b8*/ UnityEngine.FrustumPlanes get_decomposeProjection();
        /*0x3dce650*/ UnityEngine.Matrix4x4 get_inverse();
        /*0x3dce788*/ UnityEngine.Matrix4x4 get_transpose();
        /*0x3dceb48*/ float get_Item(int row, int column);
        /*0x3dcec3c*/ void set_Item(int row, int column, float value);
        /*0x3dceb50*/ float get_Item(int index);
        /*0x3dcec44*/ void set_Item(int index, float value);
        /*0x3dced30*/ int GetHashCode();
        /*0x3dcefa0*/ bool Equals(object other);
        /*0x3dcf098*/ bool Equals(UnityEngine.Matrix4x4 other);
        /*0x3dceed0*/ UnityEngine.Vector4 GetColumn(int index);
        /*0x3dcf20c*/ UnityEngine.Vector4 GetRow(int index);
        /*0x3dcf2dc*/ UnityEngine.Vector3 GetPosition();
        /*0x3dcf2e8*/ void SetColumn(int index, UnityEngine.Vector4 column);
        /*0x3dcf360*/ UnityEngine.Vector3 MultiplyPoint(UnityEngine.Vector3 point);
        /*0x3dcf3ec*/ UnityEngine.Vector3 MultiplyPoint3x4(UnityEngine.Vector3 point);
        /*0x3dcf444*/ UnityEngine.Vector3 MultiplyVector(UnityEngine.Vector3 vector);
        /*0x3dcf634*/ string ToString();
        /*0x3dcf644*/ string ToString(string format, System.IFormatProvider formatProvider);
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

        static /*0x3dd0d2c*/ Vector3();
        static /*0x3dcfc8c*/ UnityEngine.Vector3 Lerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, float t);
        static /*0x3dcfccc*/ UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3 a, UnityEngine.Vector3 b, float t);
        static /*0x3dcfe00*/ UnityEngine.Vector3 Scale(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x3dcfe10*/ UnityEngine.Vector3 Cross(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x3dcff48*/ UnityEngine.Vector3 Normalize(UnityEngine.Vector3 value);
        static /*0x3dd01c4*/ float Dot(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x3dd01dc*/ UnityEngine.Vector3 ProjectOnPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal);
        static /*0x3dd02b4*/ float Angle(UnityEngine.Vector3 from, UnityEngine.Vector3 to);
        static /*0x3dd03d4*/ float SignedAngle(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 axis);
        static /*0x3dd0548*/ float Distance(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x3dd05e8*/ UnityEngine.Vector3 ClampMagnitude(UnityEngine.Vector3 vector, float maxLength);
        static /*0x3dd069c*/ float Magnitude(UnityEngine.Vector3 vector);
        static /*0x3dd0794*/ float SqrMagnitude(UnityEngine.Vector3 vector);
        static /*0x3dd07cc*/ UnityEngine.Vector3 Min(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x3dd07e8*/ UnityEngine.Vector3 Max(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x3dd0804*/ UnityEngine.Vector3 get_zero();
        static /*0x3dd0850*/ UnityEngine.Vector3 get_one();
        static /*0x3dd089c*/ UnityEngine.Vector3 get_forward();
        static /*0x3dd08e8*/ UnityEngine.Vector3 get_back();
        static /*0x3dd0934*/ UnityEngine.Vector3 get_up();
        static /*0x3dd0980*/ UnityEngine.Vector3 get_down();
        static /*0x3dd09cc*/ UnityEngine.Vector3 get_left();
        static /*0x3dd0a18*/ UnityEngine.Vector3 get_right();
        static /*0x3dd0a64*/ UnityEngine.Vector3 op_Addition(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x3dd0a74*/ UnityEngine.Vector3 op_Subtraction(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x3dd0a84*/ UnityEngine.Vector3 op_UnaryNegation(UnityEngine.Vector3 a);
        static /*0x3dd0a94*/ UnityEngine.Vector3 op_Multiply(UnityEngine.Vector3 a, float d);
        static /*0x3dd0aa4*/ UnityEngine.Vector3 op_Multiply(float d, UnityEngine.Vector3 a);
        static /*0x3dd0ab8*/ UnityEngine.Vector3 op_Division(UnityEngine.Vector3 a, float d);
        static /*0x3dd0ac8*/ bool op_Equality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x3dd0afc*/ bool op_Inequality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        /*0x3dcfddc*/ Vector3(float x, float y, float z);
        /*0x3dcfde8*/ Vector3(float x, float y);
        /*0x3dcfcf4*/ float get_Item(int index);
        /*0x3dcfd68*/ void set_Item(int index, float value);
        /*0x3dcfdf4*/ void Set(float newX, float newY, float newZ);
        /*0x3dcfe38*/ int GetHashCode();
        /*0x3dcfe80*/ bool Equals(object other);
        /*0x3dcff18*/ bool Equals(UnityEngine.Vector3 other);
        /*0x3dd0018*/ void Normalize();
        /*0x3dd00f8*/ UnityEngine.Vector3 get_normalized();
        /*0x3dd071c*/ float get_magnitude();
        /*0x3dd07ac*/ float get_sqrMagnitude();
        /*0x3dd0b30*/ string ToString();
        /*0x3dd0b40*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Quaternion : System.IEquatable<UnityEngine.Quaternion>, System.IFormattable
    {
        static float kEpsilon = 9.999999974752427e-7;
        static /*0x0*/ UnityEngine.Quaternion identityQuaternion;
        /*0x10*/ float x;
        /*0x14*/ float y;
        /*0x18*/ float z;
        /*0x1c*/ float w;

        static /*0x3dd1cd4*/ Quaternion();
        static /*0x3dd0e28*/ UnityEngine.Quaternion FromToRotation(UnityEngine.Vector3 fromDirection, UnityEngine.Vector3 toDirection);
        static /*0x3dd0edc*/ UnityEngine.Quaternion Inverse(UnityEngine.Quaternion rotation);
        static /*0x3dd0f74*/ UnityEngine.Quaternion Slerp(UnityEngine.Quaternion a, UnityEngine.Quaternion b, float t);
        static /*0x3dd104c*/ UnityEngine.Quaternion Lerp(UnityEngine.Quaternion a, UnityEngine.Quaternion b, float t);
        static /*0x3dd1124*/ UnityEngine.Quaternion LerpUnclamped(UnityEngine.Quaternion a, UnityEngine.Quaternion b, float t);
        static /*0x3dd11fc*/ UnityEngine.Quaternion Internal_FromEulerRad(UnityEngine.Vector3 euler);
        static /*0x3dd1294*/ UnityEngine.Vector3 Internal_ToEulerRad(UnityEngine.Quaternion rotation);
        static /*0x3dd1330*/ void Internal_ToAxisAngleRad(UnityEngine.Quaternion q, ref UnityEngine.Vector3 axis, ref float angle);
        static /*0x3dd13e0*/ UnityEngine.Quaternion AngleAxis(float angle, UnityEngine.Vector3 axis);
        static /*0x3dd1498*/ UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 forward, UnityEngine.Vector3 upwards);
        static /*0x3dd154c*/ UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 forward);
        static /*0x3dd15c4*/ UnityEngine.Quaternion get_identity();
        static /*0x3dd1610*/ UnityEngine.Quaternion op_Multiply(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x3dd1684*/ UnityEngine.Vector3 op_Multiply(UnityEngine.Quaternion rotation, UnityEngine.Vector3 point);
        static /*0x3dd1728*/ bool IsEqualUsingDot(float dot);
        static /*0x3dd173c*/ bool op_Equality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x3dd176c*/ bool op_Inequality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x3dd179c*/ float Dot(UnityEngine.Quaternion a, UnityEngine.Quaternion b);
        static /*0x3dd17bc*/ UnityEngine.Vector3 Internal_MakePositive(UnityEngine.Vector3 euler);
        static /*0x3dd1870*/ UnityEngine.Quaternion Euler(float x, float y, float z);
        static /*0x3dd1888*/ UnityEngine.Quaternion Euler(UnityEngine.Vector3 euler);
        static /*0x3dd0e88*/ void FromToRotation_Injected(ref UnityEngine.Vector3 fromDirection, ref UnityEngine.Vector3 toDirection, ref UnityEngine.Quaternion ret);
        static /*0x3dd0f30*/ void Inverse_Injected(ref UnityEngine.Quaternion rotation, ref UnityEngine.Quaternion ret);
        static /*0x3dd0fe8*/ void Slerp_Injected(ref UnityEngine.Quaternion a, ref UnityEngine.Quaternion b, float t, ref UnityEngine.Quaternion ret);
        static /*0x3dd10c0*/ void Lerp_Injected(ref UnityEngine.Quaternion a, ref UnityEngine.Quaternion b, float t, ref UnityEngine.Quaternion ret);
        static /*0x3dd1198*/ void LerpUnclamped_Injected(ref UnityEngine.Quaternion a, ref UnityEngine.Quaternion b, float t, ref UnityEngine.Quaternion ret);
        static /*0x3dd1250*/ void Internal_FromEulerRad_Injected(ref UnityEngine.Vector3 euler, ref UnityEngine.Quaternion ret);
        static /*0x3dd12ec*/ void Internal_ToEulerRad_Injected(ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 ret);
        static /*0x3dd138c*/ void Internal_ToAxisAngleRad_Injected(ref UnityEngine.Quaternion q, ref UnityEngine.Vector3 axis, ref float angle);
        static /*0x3dd1444*/ void AngleAxis_Injected(float angle, ref UnityEngine.Vector3 axis, ref UnityEngine.Quaternion ret);
        static /*0x3dd14f8*/ void LookRotation_Injected(ref UnityEngine.Vector3 forward, ref UnityEngine.Vector3 upwards, ref UnityEngine.Quaternion ret);
        /*0x3dd15b8*/ Quaternion(float x, float y, float z, float w);
        /*0x3dd1844*/ UnityEngine.Vector3 get_eulerAngles();
        /*0x3dd18a0*/ void ToAngleAxis(ref float angle, ref UnityEngine.Vector3 axis);
        /*0x3dd18d4*/ int GetHashCode();
        /*0x3dd1938*/ bool Equals(object other);
        /*0x3dd1a0c*/ bool Equals(UnityEngine.Quaternion other);
        /*0x3dd1a8c*/ string ToString();
        /*0x3dd1a9c*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Mathf
    {
        static /*0x0*/ float Epsilon;

        static /*0x3dd2d48*/ Mathf();
        static /*0x3dcc490*/ float GammaToLinearSpace(float value);
        static /*0x3dcc578*/ float LinearToGammaSpace(float value);
        static /*0x3dd1d24*/ UnityEngine.Color CorrelatedColorTemperatureToRGB(float kelvin);
        static /*0x3dd1dc8*/ ushort FloatToHalf(float val);
        static /*0x3dd1e00*/ float Sin(float f);
        static /*0x3dd1e64*/ float Cos(float f);
        static /*0x3dd1ec8*/ float Tan(float f);
        static /*0x3dd1f2c*/ float Acos(float f);
        static /*0x3dd1f90*/ float Atan(float f);
        static /*0x3dd1ff4*/ float Atan2(float y, float x);
        static /*0x3dd2060*/ float Sqrt(float f);
        static /*0x3dd20bc*/ float Abs(float f);
        static /*0x3dd2118*/ int Abs(int value);
        static /*0x3dd2170*/ float Min(float a, float b);
        static /*0x3dd217c*/ int Min(int a, int b);
        static /*0x3dd2188*/ int Min(int[] values);
        static /*0x3dd21dc*/ float Max(float a, float b);
        static /*0x3dd21e8*/ int Max(int a, int b);
        static /*0x3dd21f4*/ float Pow(float f, float p);
        static /*0x3dd2264*/ float Exp(float power);
        static /*0x3dd22c8*/ float Log(float f, float p);
        static /*0x3dd2338*/ float Log(float f);
        static /*0x3dd239c*/ float Log10(float f);
        static /*0x3dd2400*/ float Ceil(float f);
        static /*0x3dd245c*/ float Floor(float f);
        static /*0x3dd24b8*/ float Round(float f);
        static /*0x3dd2580*/ int CeilToInt(float f);
        static /*0x3dd25f4*/ int FloorToInt(float f);
        static /*0x3dd2668*/ int RoundToInt(float f);
        static /*0x3dd2744*/ float Sign(float f);
        static /*0x3dd2758*/ float Clamp(float value, float min, float max);
        static /*0x3dd276c*/ int Clamp(int value, int min, int max);
        static /*0x3dd2780*/ float Clamp01(float value);
        static /*0x3dd279c*/ float Lerp(float a, float b, float t);
        static /*0x3dd27c4*/ float LerpUnclamped(float a, float b, float t);
        static /*0x3dd27d4*/ float MoveTowards(float current, float target, float maxDelta);
        static /*0x3dd27f8*/ float SmoothStep(float from, float to, float t);
        static /*0x3dd2840*/ bool Approximately(float a, float b);
        static /*0x3dd28d0*/ float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime);
        static /*0x3dd29a0*/ float Repeat(float t, float length);
        static /*0x3dd29c8*/ float InverseLerp(float a, float b, float value);
        static /*0x3dd2a00*/ float ClampToFloat(double value);
        static /*0x3dd2a6c*/ int ClampToInt(long value);
        static /*0x3dd2a88*/ uint ClampToUInt(long value);
        static /*0x3dd2aa0*/ int GetNumberOfDecimalsForMinimumDifference(double minDifference);
        static /*0x3dd2b2c*/ double RoundBasedOnMinimumDifference(double valueToRound, double minDifference);
        static /*0x3dd2bb8*/ double DiscardLeastSignificantDecimal(double v);
        static /*0x3dd2d18*/ int NextPowerOfTwo(int value);
        static /*0x3dd2d38*/ bool IsPowerOfTwo(int value);
        static /*0x3dd1d7c*/ void CorrelatedColorTemperatureToRGB_Injected(float kelvin, ref UnityEngine.Color ret);
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

        static /*0x3dd3960*/ Vector2();
        static /*0x3dd2ed0*/ UnityEngine.Vector2 Lerp(UnityEngine.Vector2 a, UnityEngine.Vector2 b, float t);
        static /*0x3dd2f04*/ UnityEngine.Vector2 LerpUnclamped(UnityEngine.Vector2 a, UnityEngine.Vector2 b, float t);
        static /*0x3dd2f20*/ UnityEngine.Vector2 Scale(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x3dd332c*/ float Dot(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x3dd33b4*/ float Angle(UnityEngine.Vector2 from, UnityEngine.Vector2 to);
        static /*0x3dd34ac*/ float SignedAngle(UnityEngine.Vector2 from, UnityEngine.Vector2 to);
        static /*0x3dd35b4*/ float Distance(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x3dd3638*/ UnityEngine.Vector2 Min(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x3dd364c*/ UnityEngine.Vector2 Max(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x3dd3660*/ UnityEngine.Vector2 op_Addition(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x3dd366c*/ UnityEngine.Vector2 op_Subtraction(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x3dd3678*/ UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x3dd3684*/ UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x3dd3690*/ UnityEngine.Vector2 op_UnaryNegation(UnityEngine.Vector2 a);
        static /*0x3dd369c*/ UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, float d);
        static /*0x3dd36a8*/ UnityEngine.Vector2 op_Multiply(float d, UnityEngine.Vector2 a);
        static /*0x3dd36b8*/ UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, float d);
        static /*0x3dd36c4*/ bool op_Equality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x3dd36ec*/ bool op_Inequality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x3dd3714*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector3 v);
        static /*0x3dd3718*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector2 v);
        static /*0x3dd3720*/ UnityEngine.Vector2 get_zero();
        static /*0x3dd3768*/ UnityEngine.Vector2 get_one();
        static /*0x3dd37b0*/ UnityEngine.Vector2 get_up();
        static /*0x3dd37f8*/ UnityEngine.Vector2 get_down();
        static /*0x3dd3840*/ UnityEngine.Vector2 get_left();
        static /*0x3dd3888*/ UnityEngine.Vector2 get_right();
        static /*0x3dd38d0*/ UnityEngine.Vector2 get_positiveInfinity();
        static /*0x3dd3918*/ UnityEngine.Vector2 get_negativeInfinity();
        /*0x3dd2ec8*/ Vector2(float x, float y);
        /*0x3dd2e00*/ float get_Item(int index);
        /*0x3dd2e64*/ void set_Item(int index, float value);
        /*0x3dd2f2c*/ void Normalize();
        /*0x3dd2fec*/ UnityEngine.Vector2 get_normalized();
        /*0x3dd309c*/ string ToString();
        /*0x3dd30ac*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x3dd324c*/ int GetHashCode();
        /*0x3dd3280*/ bool Equals(object other);
        /*0x3dd3308*/ bool Equals(UnityEngine.Vector2 other);
        /*0x3dd333c*/ float get_magnitude();
        /*0x3dd33a4*/ float get_sqrMagnitude();
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

        static /*0x3dd4070*/ Vector2Int();
        static /*0x3dd3a54*/ UnityEngine.Vector2Int Max(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs);
        static /*0x3dd3a74*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector2Int v);
        static /*0x3dd3a84*/ UnityEngine.Vector2Int FloorToInt(UnityEngine.Vector2 v);
        static /*0x3dd3b44*/ UnityEngine.Vector2Int RoundToInt(UnityEngine.Vector2 v);
        static /*0x3dd3ce4*/ UnityEngine.Vector2Int op_Addition(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b);
        static /*0x3dd3cfc*/ UnityEngine.Vector2Int op_Subtraction(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b);
        static /*0x3dd3d14*/ UnityEngine.Vector2Int op_Multiply(int a, UnityEngine.Vector2Int b);
        static /*0x3dd3d28*/ UnityEngine.Vector2Int op_Multiply(UnityEngine.Vector2Int a, int b);
        static /*0x3dd3d3c*/ UnityEngine.Vector2Int op_Division(UnityEngine.Vector2Int a, int b);
        static /*0x3dd3d50*/ bool op_Equality(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs);
        static /*0x3dd3d5c*/ bool op_Inequality(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs);
        static /*0x3dd3fe0*/ UnityEngine.Vector2Int get_zero();
        static /*0x3dd4028*/ UnityEngine.Vector2Int get_one();
        /*0x3dd3a34*/ Vector2Int(int x, int y);
        /*0x3dd3a14*/ int get_x();
        /*0x3dd3a1c*/ void set_x(int value);
        /*0x3dd3a24*/ int get_y();
        /*0x3dd3a2c*/ void set_y(int value);
        /*0x3dd3a3c*/ float get_magnitude();
        /*0x3dd3d68*/ bool Equals(object other);
        /*0x3dd3df0*/ bool Equals(UnityEngine.Vector2Int other);
        /*0x3dd3e18*/ int GetHashCode();
        /*0x3dd3e3c*/ string ToString();
        /*0x3dd3e4c*/ string ToString(string format, System.IFormatProvider formatProvider);
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

        static /*0x3dd45f8*/ Vector3Int();
        static /*0x3dd4134*/ UnityEngine.Vector3Int Min(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs);
        static /*0x3dd415c*/ UnityEngine.Vector3Int Max(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs);
        static /*0x3dd4184*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector3Int v);
        static /*0x3dd4198*/ UnityEngine.Vector2Int op_Explicit(UnityEngine.Vector3Int v);
        static /*0x3dd419c*/ UnityEngine.Vector3Int op_Addition(UnityEngine.Vector3Int a, UnityEngine.Vector3Int b);
        static /*0x3dd41b8*/ UnityEngine.Vector3Int op_Subtraction(UnityEngine.Vector3Int a, UnityEngine.Vector3Int b);
        static /*0x3dd41d4*/ UnityEngine.Vector3Int op_Multiply(UnityEngine.Vector3Int a, int b);
        static /*0x3dd41ec*/ UnityEngine.Vector3Int op_Division(UnityEngine.Vector3Int a, int b);
        static /*0x3dd4204*/ bool op_Equality(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs);
        static /*0x3dd4560*/ UnityEngine.Vector3Int get_zero();
        static /*0x3dd45ac*/ UnityEngine.Vector3Int get_one();
        /*0x3dd4128*/ Vector3Int(int x, int y, int z);
        /*0x3dd40f8*/ int get_x();
        /*0x3dd4100*/ void set_x(int value);
        /*0x3dd4108*/ int get_y();
        /*0x3dd4110*/ void set_y(int value);
        /*0x3dd4118*/ int get_z();
        /*0x3dd4120*/ void set_z(int value);
        /*0x3dd422c*/ bool Equals(object other);
        /*0x3dd42c0*/ bool Equals(UnityEngine.Vector3Int other);
        /*0x3dd42f0*/ int GetHashCode();
        /*0x3dd4368*/ string ToString();
        /*0x3dd4378*/ string ToString(string format, System.IFormatProvider formatProvider);
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

        static /*0x3dd5070*/ Vector4();
        static /*0x3dd4974*/ UnityEngine.Vector4 Normalize(UnityEngine.Vector4 a);
        static /*0x3dd4b2c*/ float Dot(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x3dd4b4c*/ float Magnitude(UnityEngine.Vector4 a);
        static /*0x3dd4c78*/ UnityEngine.Vector4 get_zero();
        static /*0x3dd4cc4*/ UnityEngine.Vector4 get_one();
        static /*0x3dd4d10*/ UnityEngine.Vector4 op_Addition(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x3dd4d24*/ UnityEngine.Vector4 op_Subtraction(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x3dd4d38*/ UnityEngine.Vector4 op_UnaryNegation(UnityEngine.Vector4 a);
        static /*0x3dd4d4c*/ UnityEngine.Vector4 op_Multiply(UnityEngine.Vector4 a, float d);
        static /*0x3dd4d60*/ UnityEngine.Vector4 op_Multiply(float d, UnityEngine.Vector4 a);
        static /*0x3dd4d78*/ UnityEngine.Vector4 op_Division(UnityEngine.Vector4 a, float d);
        static /*0x3dd4d8c*/ bool op_Equality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs);
        static /*0x3dd4dcc*/ bool op_Inequality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs);
        static /*0x3dd4e0c*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Vector3 v);
        static /*0x3dd4e14*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector4 v);
        static /*0x3dd4e18*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Vector2 v);
        static /*0x3dd4e24*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector4 v);
        /*0x3dd47dc*/ Vector4(float x, float y, float z, float w);
        /*0x3dd47e8*/ Vector4(float x, float y, float z);
        /*0x3dd47f8*/ Vector4(float x, float y);
        /*0x3dd46c4*/ float get_Item(int index);
        /*0x3dd4750*/ void set_Item(int index, float value);
        /*0x3dd4804*/ void Set(float newX, float newY, float newZ, float newW);
        /*0x3dd4810*/ void Scale(UnityEngine.Vector4 scale);
        /*0x3dd482c*/ int GetHashCode();
        /*0x3dd4890*/ bool Equals(object other);
        /*0x3dd4938*/ bool Equals(UnityEngine.Vector4 other);
        /*0x3dd4a54*/ UnityEngine.Vector4 get_normalized();
        /*0x3dd4bd8*/ float get_magnitude();
        /*0x3dd4c54*/ float get_sqrMagnitude();
        /*0x3dd4e28*/ string ToString();
        /*0x3dd4e38*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct TypeDispatchData : System.IDisposable
    {
        /*0x10*/ UnityEngine.Object[] changed;
        /*0x18*/ Unity.Collections.NativeArray<int> changedID;
        /*0x28*/ Unity.Collections.NativeArray<int> destroyedID;

        /*0x3dd50e4*/ void Dispose();
    }

    struct TransformDispatchData : System.IDisposable
    {
        /*0x10*/ Unity.Collections.NativeArray<int> transformedID;
        /*0x20*/ Unity.Collections.NativeArray<int> parentID;
        /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices;
        /*0x40*/ Unity.Collections.NativeArray<UnityEngine.Vector3> positions;
        /*0x50*/ Unity.Collections.NativeArray<UnityEngine.Quaternion> rotations;
        /*0x60*/ Unity.Collections.NativeArray<UnityEngine.Vector3> scales;

        /*0x3dd514c*/ void Dispose();
    }

    class ObjectDispatcher : System.IDisposable
    {
        static /*0x0*/ System.Action<UnityEngine.Object[], nint, nint, int, int, System.Action<UnityEngine.TypeDispatchData>> s_TypeDispatch;
        static /*0x8*/ System.Action<nint, nint, nint, nint, nint, nint, int, System.Action<UnityEngine.TransformDispatchData>> s_TransformDispatch;
        /*0x10*/ nint m_Ptr;
        /*0x18*/ Unity.Collections.Allocator m_DispatchAllocator;
        /*0x20*/ UnityEngine.TypeDispatchData m_TypeDispatchData;
        /*0x48*/ UnityEngine.TransformDispatchData m_TransformDispatchData;
        /*0xa8*/ UnityEngine.Component[] m_TransformedComponents;
        /*0xb0*/ System.Action<UnityEngine.TypeDispatchData> m_TypeDataCallback;
        /*0xb8*/ System.Action<UnityEngine.TransformDispatchData> m_TransformDataCallback;
        /*0xc0*/ System.Action<UnityEngine.Component[]> m_TransformComponentCallback;

        static /*0x3dd5f4c*/ ObjectDispatcher();
        static /*0x3dd53c4*/ nint CreateDispatchSystemHandle();
        static /*0x3dd555c*/ void DestroyDispatchSystemHandle(nint ptr);
        static /*0x3dd5da4*/ void EnableTypeTracking(nint ptr, System.Type type, UnityEngine.ObjectDispatcher.TypeTrackingFlags typeTrackingMask);
        static /*0x3dd5ef8*/ void EnableTransformTracking(nint ptr, System.Type type, UnityEngine.ObjectDispatcher.TransformTrackingType trackingType);
        static /*0x3dd5a90*/ void DispatchTypeChangesAndClear(nint ptr, System.Type type, System.Action<UnityEngine.Object[], nint, nint, int, int, System.Action<UnityEngine.TypeDispatchData>> callback, bool sortByInstanceID, bool noScriptingArray, System.Action<UnityEngine.TypeDispatchData> param);
        static /*0x3dd5bc4*/ void DispatchTransformDataChangesAndClear(nint ptr, System.Type type, UnityEngine.ObjectDispatcher.TransformTrackingType trackingType, System.Action<nint, nint, nint, nint, nint, nint, int, System.Action<UnityEngine.TransformDispatchData>> callback, System.Action<UnityEngine.TransformDispatchData> param);
        /*0x3dd522c*/ ObjectDispatcher();
        /*0x3dd521c*/ bool get_valid();
        /*0x3dd53ec*/ void Finalize();
        /*0x3dd54f8*/ void Dispose();
        /*0x3dd5474*/ void Dispose(bool disposing);
        /*0x3dd5598*/ void ValidateSystemHandleAndThrow();
        /*0x3dd55f0*/ void ValidateTypeAndThrow(System.Type type);
        /*0x3dd56c4*/ void ValidateComponentTypeAndThrow(System.Type type);
        /*0x3dd5798*/ void DispatchCallback(UnityEngine.TypeDispatchData data);
        /*0x3dd584c*/ void DispatchCallback(UnityEngine.TransformDispatchData data);
        /*0x3dd59c0*/ void DispatchCallback(UnityEngine.Component[] components);
        /*0x3dd59c8*/ void DispatchTypeChangesAndClear(System.Type type, System.Action<UnityEngine.TypeDispatchData> callback, bool sortByInstanceID, bool noScriptingArray);
        /*0x3dd5b04*/ void DispatchTransformChangesAndClear(System.Type type, UnityEngine.ObjectDispatcher.TransformTrackingType trackingType, System.Action<UnityEngine.TransformDispatchData> callback);
        /*0x3dd5c30*/ UnityEngine.TypeDispatchData GetTypeChangesAndClear(System.Type type, Unity.Collections.Allocator allocator, bool sortByInstanceID, bool noScriptingArray);
        /*0x3dd5c6c*/ UnityEngine.TransformDispatchData GetTransformChangesAndClear(System.Type type, UnityEngine.ObjectDispatcher.TransformTrackingType trackingType, Unity.Collections.Allocator allocator);
        /*0x3dd5ca4*/ void EnableTypeTracking(UnityEngine.ObjectDispatcher.TypeTrackingFlags typeTrackingMask, System.Type[] types);
        /*0x3dd5df8*/ void EnableTransformTracking(UnityEngine.ObjectDispatcher.TransformTrackingType trackingType, System.Type[] types);
        /*0x1ffc854*/ UnityEngine.TypeDispatchData GetTypeChangesAndClear<T>(Unity.Collections.Allocator allocator, bool sortByInstanceID, bool noScriptingArray);
        /*0x1ffc854*/ UnityEngine.TransformDispatchData GetTransformChangesAndClear<T>(UnityEngine.ObjectDispatcher.TransformTrackingType trackingType, Unity.Collections.Allocator allocator);
        /*0x1f30b78*/ void EnableTypeTracking<T>(UnityEngine.ObjectDispatcher.TypeTrackingFlags typeTrackingMask);
        /*0x1f30b78*/ void EnableTransformTracking<T>(UnityEngine.ObjectDispatcher.TransformTrackingType trackingType);

        enum TransformTrackingType
        {
            GlobalTRS = 0,
            LocalTRS = 1,
            Hierarchy = 2,
        }

        enum TypeTrackingFlags
        {
            SceneObjects = 1,
            Assets = 2,
            EditorOnlyObjects = 4,
            Default = 3,
            All = 7,
        }

        class <>c
        {
            static /*0x0*/ UnityEngine.ObjectDispatcher.<> <>9;

            static /*0x3dd6088*/ <>c();
            /*0x3dd60f0*/ <>c();
            /*0x3dd60f8*/ void <.cctor>b__64_0(UnityEngine.Object[] changed, nint changedID, nint destroyedID, int changedCount, int destroyedCount, System.Action<UnityEngine.TypeDispatchData> callback);
            /*0x3dd6200*/ void <.cctor>b__64_1(nint transformed, nint parents, nint localToWorldMatrices, nint positions, nint rotations, nint scales, int count, System.Action<UnityEngine.TransformDispatchData> callback);
        }
    }

    class NumericFieldDraggerUtility
    {
        static /*0x0*/ bool s_UseYSign;

        static /*0x3dd63b0*/ float Acceleration(bool shiftPressed, bool altPressed);
        static /*0x3dd63d4*/ float NiceDelta(UnityEngine.Vector2 deviceDelta, float acceleration);
        static /*0x3dd652c*/ double CalculateFloatDragSensitivity(double value);
        static /*0x3dd65c0*/ double CalculateFloatDragSensitivity(double value, double minValue, double maxValue);
        static /*0x3dd6650*/ long CalculateIntDragSensitivity(long value);
        static /*0x3dd66f8*/ ulong CalculateIntDragSensitivity(ulong value);
        static /*0x3dd667c*/ double CalculateIntDragSensitivity(double value);
        static /*0x3dd671c*/ long CalculateIntDragSensitivity(long value, long minValue, long maxValue);
    }

    interface IPlayerEditorConnectionNative
    {
        /*0x1f309e4*/ void Initialize();
        /*0x1f309e4*/ void DisconnectAll();
        void SendMessage(System.Guid messageId, byte[] data, int playerId);
        bool TrySendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x1f309e4*/ void Poll();
        void RegisterInternal(System.Guid messageId);
        void UnregisterInternal(System.Guid messageId);
        /*0x1f2fe14*/ bool IsConnected();
    }

    class PlayerConnectionInternal : UnityEngine.IPlayerEditorConnectionNative
    {
        static /*0x3dd720c*/ bool IsConnected();
        static /*0x3dd71bc*/ void Initialize();
        static /*0x3dd6e68*/ void RegisterInternal(string messageId);
        static /*0x3dd702c*/ void UnregisterInternal(string messageId);
        static /*0x3dd68bc*/ void SendMessage(string messageId, byte[] data, int playerId);
        static /*0x3dd6bb8*/ bool TrySendMessage(string messageId, byte[] data, int playerId);
        static /*0x3dd6de4*/ void PollInternal();
        static /*0x3dd725c*/ void DisconnectAll();
        static /*0x3dd7284*/ void RegisterInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper messageId);
        static /*0x3dd72c0*/ void UnregisterInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper messageId);
        static /*0x3dd72fc*/ void SendMessage_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper messageId, ref UnityEngine.Bindings.ManagedSpanWrapper data, int playerId);
        static /*0x3dd7350*/ bool TrySendMessage_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper messageId, ref UnityEngine.Bindings.ManagedSpanWrapper data, int playerId);
        /*0x3dd73a4*/ PlayerConnectionInternal();
        /*0x3dd67bc*/ void UnityEngine.IPlayerEditorConnectionNative.SendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x3dd6ab4*/ bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x3dd6dbc*/ void UnityEngine.IPlayerEditorConnectionNative.Poll();
        /*0x3dd6e0c*/ void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(System.Guid messageId);
        /*0x3dd6fd0*/ void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(System.Guid messageId);
        /*0x3dd7194*/ void UnityEngine.IPlayerEditorConnectionNative.Initialize();
        /*0x3dd71e4*/ bool UnityEngine.IPlayerEditorConnectionNative.IsConnected();
        /*0x3dd7234*/ void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll();
    }

    class PlayerPrefsException : System.Exception
    {
        /*0x3dd73ac*/ PlayerPrefsException(string error);
    }

    class PlayerPrefs
    {
        static /*0x3dd7414*/ bool TrySetInt(string key, int value);
        static /*0x3dd75d4*/ bool TrySetFloat(string key, float value);
        static /*0x3dd77a4*/ bool TrySetSetString(string key, string value);
        static /*0x3dd7a24*/ void SetInt(string key, int value);
        static /*0x3dd7a7c*/ int GetInt(string key, int defaultValue);
        static /*0x3dd7c38*/ int GetInt(string key);
        static /*0x3dd7c40*/ void SetFloat(string key, float value);
        static /*0x3dd7c98*/ float GetFloat(string key, float defaultValue);
        static /*0x3dd7e60*/ void SetString(string key, string value);
        static /*0x3dd7eb8*/ string GetString(string key, string defaultValue);
        static /*0x3dd81bc*/ string GetString(string key);
        static /*0x3dd8204*/ bool HasKey(string key);
        static /*0x3dd83b4*/ void DeleteKey(string key);
        static /*0x3dd8558*/ void DeleteAll();
        static /*0x3dd8580*/ void Save();
        static /*0x3dd7590*/ bool TrySetInt_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key, int value);
        static /*0x3dd7758*/ bool TrySetFloat_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key, float value);
        static /*0x3dd79e0*/ bool TrySetSetString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x3dd7bf4*/ int GetInt_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key, int defaultValue);
        static /*0x3dd7e14*/ float GetFloat_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key, float defaultValue);
        static /*0x3dd8168*/ void GetString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key, ref UnityEngine.Bindings.ManagedSpanWrapper defaultValue, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3dd8378*/ bool HasKey_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key);
        static /*0x3dd851c*/ void DeleteKey_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key);
    }

    class PropertyAttribute : System.Attribute
    {
        /*0x10*/ int <order>k__BackingField;
        /*0x14*/ bool <applyToCollection>k__BackingField;

        /*0x3dd85b0*/ PropertyAttribute();
        /*0x3dd85cc*/ PropertyAttribute(bool applyToCollection);
        /*0x3dd85a8*/ void set_order(int value);
    }

    class InspectorNameAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ string displayName;

        /*0x3dd85f4*/ InspectorNameAttribute(string displayName);
    }

    class TooltipAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ string tooltip;

        /*0x3dd862c*/ TooltipAttribute(string tooltip);
    }

    class SpaceAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ float height;

        /*0x3dd8660*/ SpaceAttribute();
        /*0x3dd8688*/ SpaceAttribute(float height);
    }

    class HeaderAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ string header;

        /*0x3dd86b8*/ HeaderAttribute(string header);
    }

    class RangeAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ float min;
        /*0x1c*/ float max;

        /*0x3dd86f0*/ RangeAttribute(float min, float max);
    }

    class MinAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ float min;

        /*0x3dd8720*/ MinAttribute(float min);
    }

    class MultilineAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ int lines;

        /*0x3dd874c*/ MultilineAttribute();
    }

    class TextAreaAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ int minLines;
        /*0x1c*/ int maxLines;

        /*0x3dd8770*/ TextAreaAttribute(int minLines, int maxLines);
    }

    class DelayedAttribute : UnityEngine.PropertyAttribute
    {
        /*0x3dd87a0*/ DelayedAttribute();
    }

    class PropertyNameUtils
    {
        static /*0x3dd87bc*/ UnityEngine.PropertyName PropertyNameFromString(string name);
        static /*0x3dd8930*/ void PropertyNameFromString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.PropertyName ret);
    }

    struct PropertyName : System.IEquatable<UnityEngine.PropertyName>
    {
        /*0x10*/ int id;

        static /*0x3dd8998*/ bool IsNullOrEmpty(UnityEngine.PropertyName prop);
        static /*0x3dd89a4*/ bool op_Equality(UnityEngine.PropertyName lhs, UnityEngine.PropertyName rhs);
        static /*0x3dd8a40*/ UnityEngine.PropertyName op_Implicit(string name);
        /*0x3dd8974*/ PropertyName(string name);
        /*0x3dd8990*/ PropertyName(UnityEngine.PropertyName other);
        /*0x3dd89b0*/ int GetHashCode();
        /*0x3dd89b8*/ bool Equals(object other);
        /*0x3dd8a30*/ bool Equals(UnityEngine.PropertyName other);
        /*0x3dd8a44*/ string ToString();
    }

    class Random
    {
        static /*0x3dd8abc*/ void InitState(int seed);
        static /*0x3dd8af8*/ UnityEngine.Random.State get_state();
        static /*0x3dd8b78*/ void set_state(UnityEngine.Random.State value);
        static /*0x3dd8bf4*/ float Range(float minInclusive, float maxInclusive);
        static /*0x3dd8c34*/ int Range(int minInclusive, int maxExclusive);
        static /*0x3dd8c78*/ int RandomRangeInt(int minInclusive, int maxExclusive);
        static /*0x3dd8cbc*/ float get_value();
        static /*0x3dd8ce4*/ UnityEngine.Vector3 get_insideUnitSphere();
        static /*0x3dd8d6c*/ void GetRandomUnitCircle(ref UnityEngine.Vector2 output);
        static /*0x3dd8da8*/ UnityEngine.Vector2 get_insideUnitCircle();
        static /*0x3dd8b3c*/ void get_state_Injected(ref UnityEngine.Random.State ret);
        static /*0x3dd8bb8*/ void set_state_Injected(ref UnityEngine.Random.State value);
        static /*0x3dd8d30*/ void get_insideUnitSphere_Injected(ref UnityEngine.Vector3 ret);

        struct State
        {
            /*0x10*/ int s0;
            /*0x14*/ int s1;
            /*0x18*/ int s2;
            /*0x1c*/ int s3;
        }
    }

    struct RenderingLayerMask
    {
        static int maxRenderingLayerSize = 32;
        static /*0x0*/ UnityEngine.RenderingLayerMask <defaultRenderingLayerMask>k__BackingField;
        /*0x10*/ uint m_Bits;

        static /*0x3dd8fe4*/ RenderingLayerMask();
        static /*0x3dd8dec*/ uint op_Implicit(UnityEngine.RenderingLayerMask mask);
        static /*0x3dd8df0*/ UnityEngine.RenderingLayerMask op_Implicit(uint intVal);
        static /*0x3dd8df4*/ int op_Implicit(UnityEngine.RenderingLayerMask mask);
        static /*0x3dd8df8*/ UnityEngine.RenderingLayerMask op_Implicit(int intVal);
        static /*0x3dd8dfc*/ string RenderingLayerToName(int layer);
        static /*0x3dd8f44*/ int GetDefinedRenderingLayerCount();
        static /*0x3dd8f6c*/ uint GetDefinedRenderingLayersCombinedMaskValue();
        static /*0x3dd8f94*/ string[] GetDefinedRenderingLayerNames();
        static /*0x3dd8fbc*/ int GetRenderingLayerCount();
        static /*0x3dd8f00*/ void RenderingLayerToName_Injected(int layer, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
    }

    class ResourceRequest : UnityEngine.AsyncOperation
    {
        /*0x20*/ string m_Path;
        /*0x28*/ System.Type m_Type;

        /*0x3dd904c*/ ResourceRequest(nint ptr);
        /*0x3dd9030*/ UnityEngine.Object GetResult();
        /*0x3dd9040*/ UnityEngine.Object get_asset();

        class BindingsMarshaller
        {
            static /*0x3dd9054*/ UnityEngine.ResourceRequest ConvertToManaged(nint ptr);
        }
    }

    class ResourcesAPIInternal
    {
        static /*0x3dda508*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type);
        static /*0x3dda544*/ UnityEngine.Shader FindShaderByName(string name);
        static /*0x3dda77c*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        static /*0x3dda9d0*/ UnityEngine.Object[] LoadAll(string path, System.Type systemTypeInstance);
        static /*0x3ddabe4*/ UnityEngine.ResourceRequest LoadAsyncInternal(string path, System.Type type);
        static /*0x3ddae40*/ void UnloadAsset(UnityEngine.Object assetToUnload);
        static /*0x3dda740*/ nint FindShaderByName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3dda98c*/ nint Load_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper path, System.Type systemTypeInstance);
        static /*0x3ddaba0*/ UnityEngine.Object[] LoadAll_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper path, System.Type systemTypeInstance);
        static /*0x3ddadfc*/ nint LoadAsyncInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper path, System.Type type);
        static /*0x3ddaebc*/ void UnloadAsset_Injected(nint assetToUnload);
    }

    class ResourcesAPI
    {
        static /*0x0*/ UnityEngine.ResourcesAPI s_DefaultAPI;
        static /*0x8*/ UnityEngine.ResourcesAPI <overrideAPI>k__BackingField;

        static /*0x3ddb0b8*/ ResourcesAPI();
        static /*0x3ddaef8*/ UnityEngine.ResourcesAPI get_ActiveAPI();
        static /*0x3ddafa0*/ UnityEngine.ResourcesAPI get_overrideAPI();
        /*0x3ddaff8*/ ResourcesAPI();
        /*0x3ddb000*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type systemTypeInstance);
        /*0x3ddb03c*/ UnityEngine.Shader FindShaderByName(string name);
        /*0x3ddb044*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        /*0x3ddb050*/ UnityEngine.Object[] LoadAll(string path, System.Type systemTypeInstance);
        /*0x3ddb05c*/ UnityEngine.ResourceRequest LoadAsync(string path, System.Type systemTypeInstance);
        /*0x3ddb0b0*/ void UnloadAsset(UnityEngine.Object assetToUnload);
    }

    class Resources
    {
        static /*0x1f327cc*/ T[] ConvertObjects<T>(UnityEngine.Object[] rawObjects);
        static /*0x3ddb120*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type);
        static /*0x1f327a0*/ T[] FindObjectsOfTypeAll<T>();
        static /*0x3ddb188*/ UnityEngine.Object Load(string path);
        static /*0x1ffc854*/ T Load<T>(string path);
        static /*0x3ddb1f8*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        static /*0x3ddb270*/ UnityEngine.ResourceRequest LoadAsync(string path, System.Type type);
        static /*0x3ddb2e8*/ UnityEngine.Object[] LoadAll(string path, System.Type systemTypeInstance);
        static /*0x3ddb360*/ UnityEngine.Object GetBuiltinResource(System.Type type, string path);
        static /*0x1ffc854*/ T GetBuiltinResource<T>(string path);
        static /*0x3ddb5b4*/ void UnloadAsset(UnityEngine.Object assetToUnload);
        static /*0x3ddb61c*/ UnityEngine.AsyncOperation UnloadUnusedAssets();
        static /*0x3ddb6d4*/ UnityEngine.Object InstanceIDToObject(int instanceID);
        static /*0x3ddb77c*/ bool InstanceIDIsValid(int instanceId);
        static /*0x3ddb570*/ nint GetBuiltinResource_Injected(System.Type type, ref UnityEngine.Bindings.ManagedSpanWrapper path);
        static /*0x3ddb654*/ nint UnloadUnusedAssets_Injected();
        static /*0x3ddb740*/ nint InstanceIDToObject_Injected(int instanceID);
    }

    class AsyncInstantiateOperation : UnityEngine.AsyncOperation
    {
        static /*0x0*/ System.Threading.CancellationTokenSource s_GlobalCancellation;
        /*0x20*/ UnityEngine.Object[] m_Result;
        /*0x28*/ System.Threading.CancellationToken m_CancellationToken;

        static /*0x3ddb9b0*/ AsyncInstantiateOperation();
        /*0x3ddb7b8*/ AsyncInstantiateOperation(nint ptr, System.Threading.CancellationToken cancellationToken);
        /*0x3ddb8ec*/ bool IsCancellationRequested();
        /*0x3ddb944*/ UnityEngine.Object[] CreateResultArray(int size);
    }

    class AsyncInstantiateOperation<T> : UnityEngine.AsyncInstantiateOperation
    {
        /*0x1ffc854*/ AsyncInstantiateOperation(nint ptr, System.Threading.CancellationToken cancellationToken);
        /*0x1f30240*/ UnityEngine.Object[] CreateResultArray(int size);
    }

    class AsyncInstantiateOperationHelper
    {
        static /*0x3ddba2c*/ UnityEngine.Object[] CreateAsyncInstantiateOperationResultArray(UnityEngine.AsyncInstantiateOperation op, int size);
    }

    class AsyncOperation : UnityEngine.YieldInstruction
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ System.Action<UnityEngine.AsyncOperation> m_completeCallback;

        static /*0x3ddba44*/ void InternalDestroy(nint ptr);
        static /*0x3ddba80*/ void InternalSetManagedObject(nint ptr, UnityEngine.AsyncOperation self);
        static /*0x3ddbb1c*/ bool get_isDone_Injected(nint _unity_self);
        static /*0x3ddbba8*/ float get_progress_Injected(nint _unity_self);
        static /*0x3ddbc3c*/ void set_priority_Injected(nint _unity_self, int value);
        static /*0x3ddbcd8*/ void set_allowSceneActivation_Injected(nint _unity_self, bool value);
        /*0x3ddb894*/ AsyncOperation(nint ptr);
        /*0x3ddbacc*/ bool get_isDone();
        /*0x3ddbb58*/ float get_progress();
        /*0x3ddbbe4*/ void set_priority(int value);
        /*0x3ddbc80*/ void set_allowSceneActivation(bool value);
        /*0x3ddbd1c*/ void Finalize();
        /*0x3ddbdcc*/ void InvokeCompletionEvent();
        /*0x3ddbe1c*/ void add_completed(System.Action<UnityEngine.AsyncOperation> value);
        /*0x3ddbef8*/ void remove_completed(System.Action<UnityEngine.AsyncOperation> value);

        class BindingsMarshaller
        {
            static /*0x3ddb67c*/ UnityEngine.AsyncOperation ConvertToManaged(nint ptr);
            static /*0x3ddbfa0*/ nint ConvertToNative(UnityEngine.AsyncOperation asyncOperation);
        }
    }

    class AttributeHelperEngine
    {
        static /*0x0*/ UnityEngine.DisallowMultipleComponent[] _disallowMultipleComponentArray;
        static /*0x8*/ UnityEngine.ExecuteInEditMode[] _executeInEditModeArray;
        static /*0x10*/ UnityEngine.RequireComponent[] _requireComponentArray;

        static /*0x3ddc790*/ AttributeHelperEngine();
        static /*0x3ddbfb4*/ System.Type GetParentTypeDisallowingMultipleInclusion(System.Type type);
        static /*0x3ddc0dc*/ System.Type[] GetRequiredComponents(System.Type klass);
        static /*0x3ddc50c*/ int GetExecuteMode(System.Type klass);
        static /*0x3ddc60c*/ int CheckIsEditorScript(System.Type klass);
        static /*0x3ddc710*/ int GetDefaultExecutionOrderFor(System.Type klass);
        static /*0x1ffc854*/ T GetCustomAttributeOfType<T>(System.Type klass);
    }

    class DisallowMultipleComponent : System.Attribute
    {
        /*0x3ddc87c*/ DisallowMultipleComponent();
    }

    class RequireComponent : System.Attribute
    {
        /*0x10*/ System.Type m_Type0;
        /*0x18*/ System.Type m_Type1;
        /*0x20*/ System.Type m_Type2;

        /*0x3ddc884*/ RequireComponent(System.Type requiredComponent);
        /*0x3ddc8b4*/ RequireComponent(System.Type requiredComponent, System.Type requiredComponent2);
    }

    class AddComponentMenu : System.Attribute
    {
        /*0x10*/ string m_AddComponentMenu;
        /*0x18*/ int m_Ordering;

        /*0x3ddc8f8*/ AddComponentMenu(string menuName);
        /*0x3ddc930*/ AddComponentMenu(string menuName, int order);
    }

    class CreateAssetMenuAttribute : System.Attribute
    {
        /*0x10*/ string <menuName>k__BackingField;
        /*0x18*/ string <fileName>k__BackingField;
        /*0x20*/ int <order>k__BackingField;

        /*0x3ddc984*/ CreateAssetMenuAttribute();
        /*0x3ddc96c*/ void set_menuName(string value);
        /*0x3ddc974*/ void set_fileName(string value);
        /*0x3ddc97c*/ void set_order(int value);
    }

    class ContextMenu : System.Attribute
    {
        /*0x10*/ string menuItem;
        /*0x18*/ bool validate;
        /*0x1c*/ int priority;

        /*0x3ddc98c*/ ContextMenu(string itemName);
        /*0x3ddc9d0*/ ContextMenu(string itemName, bool isValidateFunction);
        /*0x3ddca18*/ ContextMenu(string itemName, bool isValidateFunction, int priority);
    }

    class ExecuteInEditMode : System.Attribute
    {
        /*0x3ddca64*/ ExecuteInEditMode();
    }

    class ExecuteAlways : System.Attribute
    {
        /*0x3ddca6c*/ ExecuteAlways();
    }

    class HideInInspector : System.Attribute
    {
        /*0x3ddca74*/ HideInInspector();
    }

    class HideInCallstackAttribute : System.Attribute
    {
    }

    class HelpURLAttribute : System.Attribute
    {
        /*0x10*/ string m_Url;
        /*0x18*/ bool m_Dispatcher;
        /*0x20*/ string m_DispatchingFieldName;

        /*0x3ddca7c*/ HelpURLAttribute(string url);
        /*0x3ddcaf8*/ string get_URL();
    }

    class DefaultExecutionOrder : System.Attribute
    {
        /*0x10*/ int m_Order;

        /*0x3ddcb00*/ DefaultExecutionOrder(int order);
        /*0x3ddc788*/ int get_order();
    }

    class AssemblyIsEditorAssembly : System.Attribute
    {
    }

    class ExcludeFromPresetAttribute : System.Attribute
    {
        /*0x3ddcb28*/ ExcludeFromPresetAttribute();
    }

    class Awaitable : System.Collections.IEnumerator
    {
        static /*0x0*/ bool _nextFrameAndEndOfFrameWiredUp;
        static /*0x8*/ System.Threading.CancellationTokenRegistration _nextFrameAndEndOfFrameWiredUpCTRegistration;
        static /*0x20*/ UnityEngine.Awaitable.DoubleBufferedAwaitableList _nextFrameAwaitables;
        static /*0x28*/ UnityEngine.Awaitable.DoubleBufferedAwaitableList _endOfFrameAwaitables;
        static /*0x30*/ System.Threading.SynchronizationContext _synchronizationContext;
        static /*0x38*/ int _mainThreadId;
        static /*0x40*/ System.Threading.ThreadLocal<UnityEngine.Pool.ObjectPool<UnityEngine.Awaitable>> _pool;
        /*0x10*/ System.Threading.SpinLock _spinLock;
        /*0x18*/ UnityEngine.Awaitable.AwaitableHandle _handle;
        /*0x20*/ System.Runtime.ExceptionServices.ExceptionDispatchInfo _exceptionToRethrow;
        /*0x28*/ bool _managedAwaitableDone;
        /*0x2c*/ UnityEngine.Awaitable.AwaiterCompletionThreadAffinity _completionThreadAffinity;
        /*0x30*/ System.Action _continuation;
        /*0x38*/ System.Nullable<System.Threading.CancellationTokenRegistration> _cancelTokenRegistration;
        /*0x58*/ UnityEngine.Awaitable.DoubleBufferedAwaitableList _managedCompletionQueue;

        static /*0x3dde32c*/ Awaitable();
        static /*0x3ddcdb0*/ void ReleaseNativeAwaitable(nint nativeAwaitable);
        static /*0x3ddcdec*/ int IsNativeAwaitableCompleted(nint nativeAwaitable);
        static /*0x3ddce28*/ void OnDelayedCallManagerCleared();
        static /*0x3ddcf3c*/ void OnUpdate();
        static /*0x3ddd2f8*/ void OnEndOfFrame();
        static /*0x3ddd358*/ void SetSynchronizationContext(UnityEngine.UnitySynchronizationContext synchronizationContext);
        static /*0x3ddd3e0*/ bool MatchCompletionThreadAffinity(UnityEngine.Awaitable.AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity);
        static /*0x3ddd62c*/ void DoRunContinuationOnSynchonizationContext(object continuation);
        /*0x3ddd3d4*/ Awaitable();
        /*0x3ddcb30*/ void SetExceptionFromNative(System.Exception ex);
        /*0x3ddcc6c*/ void RunContinuation();
        /*0x3ddd4c8*/ void RunOrScheduleContinuation(UnityEngine.Awaitable.AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity, System.Action continuation);
        /*0x3ddd698*/ void RaiseManagedCompletion();
        /*0x3ddd800*/ void PropagateExceptionAndRelease();
        /*0x3dddcf4*/ bool get_IsCompletedNoLock();
        /*0x3ddde88*/ bool get_IsCompleted();
        /*0x3dddfb0*/ bool get_IsDettachedOrCompleted();
        /*0x3dde248*/ UnityEngine.Awaitable.AwaitableHandle CheckPointerValidity();
        /*0x3dde2ec*/ bool System.Collections.IEnumerator.MoveNext();
        /*0x3dde320*/ void System.Collections.IEnumerator.Reset();
        /*0x3dde324*/ object System.Collections.IEnumerator.get_Current();

        enum AwaiterCompletionThreadAffinity
        {
            None = 0,
            MainThread = 1,
            BackgroundThread = 2,
        }

        struct AwaitableAsyncMethodBuilder
        {
            /*0x10*/ UnityEngine.Awaitable.AwaitableAsyncMethodBuilder.IStateMachineBox _stateMachineBox;
            /*0x18*/ UnityEngine.Awaitable _resultingCoroutine;

            interface IStateMachineBox : System.IDisposable
            {
            }
        }

        struct AwaitableAndFrameIndex
        {
            /*0x10*/ UnityEngine.Awaitable <Awaitable>k__BackingField;
            /*0x18*/ int <FrameIndex>k__BackingField;

            /*0x3dde560*/ UnityEngine.Awaitable get_Awaitable();
            /*0x3dde568*/ int get_FrameIndex();
        }

        class DoubleBufferedAwaitableList
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Awaitable.AwaitableAndFrameIndex> _awaitables;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Awaitable.AwaitableAndFrameIndex> _scratch;

            /*0x3dde4b4*/ DoubleBufferedAwaitableList();
            /*0x3ddcf9c*/ void SwapAndComplete();
            /*0x3ddcea0*/ void Clear();
        }

        struct AwaitableHandle
        {
            static /*0x0*/ UnityEngine.Awaitable.AwaitableHandle ManagedHandle;
            static /*0x8*/ UnityEngine.Awaitable.AwaitableHandle NullHandle;
            /*0x10*/ nint _handle;

            static /*0x3dde5a4*/ AwaitableHandle();
            static /*0x3dde5a0*/ nint op_Implicit(UnityEngine.Awaitable.AwaitableHandle handle);
            /*0x3dde598*/ AwaitableHandle(nint handle);
            /*0x3dddce4*/ bool get_IsNull();
            /*0x3dddc7c*/ bool get_IsManaged();
        }

        class <>c
        {
            static /*0x0*/ UnityEngine.Awaitable.<> <>9;
            static /*0x8*/ System.Func<UnityEngine.Awaitable> <>9__76_1;

            static /*0x3dde604*/ <>c();
            /*0x3dde66c*/ <>c();
            /*0x3dde674*/ UnityEngine.Pool.ObjectPool<UnityEngine.Awaitable> <.cctor>b__76_0();
            /*0x3dde7b0*/ UnityEngine.Awaitable <.cctor>b__76_1();
        }
    }

    class Behaviour : UnityEngine.Component
    {
        static /*0x3dde880*/ bool get_enabled_Injected(nint _unity_self);
        static /*0x3dde93c*/ void set_enabled_Injected(nint _unity_self, bool value);
        static /*0x3dde9f8*/ bool get_isActiveAndEnabled_Injected(nint _unity_self);
        /*0x3ddea34*/ Behaviour();
        /*0x3dde808*/ bool get_enabled();
        /*0x3dde8bc*/ void set_enabled(bool value);
        /*0x3dde980*/ bool get_isActiveAndEnabled();
    }

    struct CastHelper<T>
    {
        /*0x0*/ T t;
        /*0x0*/ nint onePointerFurtherThanT;
    }

    class ClassLibraryInitializer
    {
        static /*0x3ddea90*/ void Init();
    }

    struct AssemblyVersion
    {
        /*0x10*/ ushort major;
        /*0x12*/ ushort minor;
        /*0x14*/ ushort build;
        /*0x16*/ ushort revision;

        static /*0x3ddea98*/ bool op_Equality(UnityEngine.AssemblyVersion lhs, UnityEngine.AssemblyVersion rhs);
        /*0x3ddeaa4*/ string ToString();
        /*0x3ddec74*/ bool Equals(object other);
        /*0x3dded1c*/ int GetHashCode();
    }

    struct AssemblyFullName
    {
        /*0x10*/ string Name;
        /*0x18*/ UnityEngine.AssemblyVersion Version;
        /*0x20*/ string PublicKeyToken;
        /*0x28*/ string Culture;

        /*0x3ddedc8*/ bool Equals(object other);
        /*0x3ddee8c*/ int GetHashCode();
        /*0x3ddef24*/ string ToString();
    }

    class Component : UnityEngine.Object
    {
        static /*0x3ddf188*/ nint get_transform_Injected(nint _unity_self);
        static /*0x3ddf258*/ nint get_gameObject_Injected(nint _unity_self);
        static /*0x3ddf3e8*/ void GetComponentFastPath_Injected(nint _unity_self, System.Type type, nint oneFurtherThanResultValue);
        static /*0x3ddf73c*/ void GetComponentsForListInternal_Injected(nint _unity_self, System.Type searchType, object resultList);
        /*0x3ddea38*/ Component();
        /*0x3ddf0f4*/ UnityEngine.Transform get_transform();
        /*0x3ddf1c4*/ UnityEngine.GameObject get_gameObject();
        /*0x3ddf294*/ UnityEngine.Component GetComponent(System.Type type);
        /*0x3ddf358*/ void GetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x1ffc854*/ T GetComponent<T>();
        /*0x3ddf43c*/ bool TryGetComponent(System.Type type, ref UnityEngine.Component component);
        /*0x1f2fec8*/ bool TryGetComponent<T>(ref T component);
        /*0x3ddf4f4*/ UnityEngine.Component GetComponentInChildren(System.Type t, bool includeInactive);
        /*0x1ffc854*/ T GetComponentInChildren<T>(bool includeInactive);
        /*0x1ffc854*/ T GetComponentInChildren<T>();
        T[] GetComponentsInChildren<T>(bool includeInactive);
        /*0x1f30ac0*/ void GetComponentsInChildren<T>(bool includeInactive, System.Collections.Generic.List<T> result);
        /*0x1f30214*/ T[] GetComponentsInChildren<T>();
        /*0x1f30ebc*/ void GetComponentsInChildren<T>(System.Collections.Generic.List<T> results);
        /*0x3ddf5d0*/ UnityEngine.Component GetComponentInParent(System.Type t, bool includeInactive);
        /*0x1ffc854*/ T GetComponentInParent<T>();
        T[] GetComponentsInParent<T>(bool includeInactive);
        /*0x1f30ac0*/ void GetComponentsInParent<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        /*0x1f30214*/ T[] GetComponentsInParent<T>();
        /*0x3ddf6ac*/ void GetComponentsForListInternal(System.Type searchType, object resultList);
        /*0x3ddf790*/ void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results);
        /*0x1f30ebc*/ void GetComponents<T>(System.Collections.Generic.List<T> results);
        /*0x1f30214*/ T[] GetComponents<T>();
        /*0x3ddf794*/ bool CompareTag(string tag);
    }

    class Coroutine : UnityEngine.YieldInstruction
    {
        /*0x10*/ nint m_Ptr;

        static /*0x3ddf878*/ void ReleaseCoroutine(nint ptr);
        /*0x3ddf7c0*/ Coroutine();
        /*0x3ddf7c8*/ void Finalize();

        class BindingsMarshaller
        {
            static /*0x3ddf8b4*/ nint ConvertToNative(UnityEngine.Coroutine coroutine);
        }
    }

    class SetupCoroutine
    {
        static /*0x3ddf8c8*/ void InvokeMoveNext(System.Collections.IEnumerator enumerator, nint returnValueAddress);
        static /*0x3ddf9e4*/ object InvokeMember(object behaviour, string name, object variable);
    }

    class CustomYieldInstruction : System.Collections.IEnumerator
    {
        /*0x3ddfafc*/ CustomYieldInstruction();
        /*0x1f2fe14*/ bool get_keepWaiting();
        /*0x3ddfae4*/ object get_Current();
        /*0x3ddfaec*/ bool MoveNext();
        /*0x3ddfaf8*/ void Reset();
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

        static /*0x3de138c*/ EnumDataUtility();
        static /*0x3ddfb04*/ UnityEngine.EnumData GetCachedEnumData(System.Type enumType, UnityEngine.EnumDataUtility.CachedType cachedType, System.Func<string, string> nicifyName);
        static /*0x3de0af0*/ void HandleInspectorOrderAttribute(System.Type enumType, ref UnityEngine.EnumData enumData);
        static /*0x3de09d4*/ bool CheckObsoleteAddition(System.Reflection.FieldInfo field, UnityEngine.EnumDataUtility.CachedType cachedType);
        static /*0x3de1000*/ string EnumTooltipFromEnumField(System.Reflection.FieldInfo field);
        static /*0x3de1120*/ string EnumNameFromEnumField(System.Reflection.FieldInfo field, System.Func<string, string> nicifyName);
        static /*0x3de1324*/ string <EnumNameFromEnumField>g__NicifyName|8_0(ref UnityEngine.EnumDataUtility.<> );

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

            static /*0x3de1424*/ <>c();
            /*0x3de148c*/ <>c();
            /*0x3de1494*/ int <GetCachedEnumData>b__2_5(System.Reflection.FieldInfo f);
            /*0x3de14b8*/ string <GetCachedEnumData>b__2_1(System.Reflection.FieldInfo f);
            /*0x3de150c*/ System.Enum <GetCachedEnumData>b__2_2(System.Reflection.FieldInfo f);
            /*0x3de1574*/ int <GetCachedEnumData>b__2_3(System.Enum v);
            /*0x3de15d0*/ int <GetCachedEnumData>b__2_4(System.Enum v);
        }

        class <>c__DisplayClass2_0
        {
            /*0x10*/ System.Func<string, string> nicifyName;

            /*0x3de09cc*/ <>c__DisplayClass2_0();
            /*0x3de162c*/ string <GetCachedEnumData>b__0(System.Reflection.FieldInfo f);
        }

        struct <>c__DisplayClass8_0
        {
            /*0x10*/ System.Func<string, string> nicifyName;
            /*0x18*/ System.Reflection.FieldInfo field;
        }
    }

    class ExcludeFromObjectFactoryAttribute : System.Attribute
    {
        /*0x3de1694*/ ExcludeFromObjectFactoryAttribute();
    }

    class ExtensionOfNativeClassAttribute : System.Attribute
    {
        /*0x3de169c*/ ExtensionOfNativeClassAttribute();
    }

    class FailedToLoadScriptObject : UnityEngine.Object
    {
    }

    class GameObject : UnityEngine.Object
    {
        static /*0x3de16a4*/ UnityEngine.GameObject CreatePrimitive(UnityEngine.PrimitiveType type);
        static /*0x3de2360*/ UnityEngine.GameObject FindWithTag(string tag);
        static /*0x3de2560*/ void FindGameObjectsWithTagForListInternal(string tag, object results);
        static /*0x3de2714*/ void FindGameObjectsWithTag(string tag, System.Collections.Generic.List<UnityEngine.GameObject> results);
        static /*0x3de2364*/ UnityEngine.GameObject FindGameObjectWithTag(string tag);
        static /*0x3de41fc*/ UnityEngine.GameObject[] FindGameObjectsWithTag(string tag);
        static /*0x3de4568*/ void Internal_CreateGameObject(UnityEngine.GameObject self, string name);
        static /*0x3de4840*/ UnityEngine.GameObject Find(string name);
        static /*0x3de4a78*/ void SetGameObjectsActive(nint instanceIds, int instanceCount, bool active);
        static /*0x3de4acc*/ void SetGameObjectsActive(Unity.Collections.NativeArray<int> instanceIDs, bool active);
        static /*0x3de4be4*/ void SetGameObjectsActive(System.ReadOnlySpan<int> instanceIDs, bool active);
        static /*0x3de4c98*/ void InstantiateGameObjects(int sourceInstanceID, nint newInstanceIDs, nint newTransformInstanceIDs, int count, UnityEngine.SceneManagement.Scene destinationScene);
        static /*0x3de4d74*/ void InstantiateGameObjects(int sourceInstanceID, int count, Unity.Collections.NativeArray<int> newInstanceIDs, Unity.Collections.NativeArray<int> newTransformInstanceIDs, UnityEngine.SceneManagement.Scene destinationScene);
        static /*0x3de4f40*/ UnityEngine.SceneManagement.Scene GetScene(int instanceID);
        static /*0x3de1710*/ nint CreatePrimitive_Injected(UnityEngine.PrimitiveType type);
        static /*0x3de174c*/ nint GetComponent_Injected(nint _unity_self, System.Type type);
        static /*0x3de1820*/ void GetComponentFastPath_Injected(nint _unity_self, System.Type type, nint oneFurtherThanResultValue);
        static /*0x3de1a8c*/ nint GetComponentByName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper type);
        static /*0x3de1cf8*/ nint GetComponentByNameWithCase_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper type, bool caseSensitive);
        static /*0x3de1d50*/ nint GetComponentInChildren_Injected(nint _unity_self, System.Type type, bool includeInactive);
        static /*0x3de1dac*/ nint GetComponentInParent_Injected(nint _unity_self, System.Type type, bool includeInactive);
        static /*0x3de1ec8*/ System.Array GetComponentsInternal_Injected(nint _unity_self, System.Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList);
        static /*0x3de2238*/ nint TryGetComponentInternal_Injected(nint _unity_self, System.Type type);
        static /*0x3de230c*/ void TryGetComponentFastPath_Injected(nint _unity_self, System.Type type, nint oneFurtherThanResultValue);
        static /*0x3de26d0*/ void FindGameObjectsWithTagForListInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper tag, object results);
        static /*0x3de2e7c*/ nint AddComponentInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper className);
        static /*0x3de2f64*/ nint Internal_AddComponentWithType_Injected(nint _unity_self, System.Type componentType);
        static /*0x3de3024*/ int GetComponentCount_Injected(nint _unity_self);
        static /*0x3de3104*/ nint QueryComponentAtIndex_Injected(nint _unity_self, int index);
        static /*0x3de328c*/ int GetComponentIndex_Injected(nint _unity_self, nint component);
        static /*0x3de3364*/ nint get_transform_Injected(nint _unity_self);
        static /*0x3de3418*/ int get_layer_Injected(nint _unity_self);
        static /*0x3de34d4*/ void set_layer_Injected(nint _unity_self, int value);
        static /*0x3de3590*/ bool get_active_Injected(nint _unity_self);
        static /*0x3de364c*/ void set_active_Injected(nint _unity_self, bool value);
        static /*0x3de3710*/ void SetActive_Injected(nint _unity_self, bool value);
        static /*0x3de37cc*/ bool get_activeSelf_Injected(nint _unity_self);
        static /*0x3de3880*/ bool get_activeInHierarchy_Injected(nint _unity_self);
        static /*0x3de393c*/ void SetActiveRecursively_Injected(nint _unity_self, bool state);
        static /*0x3de39f8*/ bool get_isStatic_Injected(nint _unity_self);
        static /*0x3de3ab4*/ void set_isStatic_Injected(nint _unity_self, bool value);
        static /*0x3de3b70*/ bool get_isStaticBatchable_Injected(nint _unity_self);
        static /*0x3de3cd8*/ void get_tag_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3de3eb8*/ void set_tag_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x3de4138*/ bool CompareTag_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper tag);
        static /*0x3de417c*/ bool CompareTagHandle_Internal_Injected(nint _unity_self, ref UnityEngine.TagHandle tag);
        static /*0x3de41c0*/ nint FindGameObjectWithTag_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper tag);
        static /*0x3de436c*/ UnityEngine.GameObject[] FindGameObjectsWithTag_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper tag);
        static /*0x3de43a8*/ void SendMessageUpwards_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object value, UnityEngine.SendMessageOptions options);
        static /*0x3de4418*/ void SendMessage_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object value, UnityEngine.SendMessageOptions options);
        static /*0x3de4488*/ void BroadcastMessage_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object parameter, UnityEngine.SendMessageOptions options);
        static /*0x3de47fc*/ void Internal_CreateGameObject_Injected(UnityEngine.GameObject self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3de4a3c*/ nint Find_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3de4d08*/ void InstantiateGameObjects_Injected(int sourceInstanceID, nint newInstanceIDs, nint newTransformInstanceIDs, int count, ref UnityEngine.SceneManagement.Scene destinationScene);
        static /*0x3de4f8c*/ void GetScene_Injected(int instanceID, ref UnityEngine.SceneManagement.Scene ret);
        static /*0x3de5058*/ void get_scene_Injected(nint _unity_self, ref UnityEngine.SceneManagement.Scene ret);
        static /*0x3de5114*/ ulong get_sceneCullingMask_Injected(nint _unity_self);
        /*0x3de44f8*/ GameObject(string name);
        /*0x3de46d8*/ GameObject();
        /*0x3de473c*/ GameObject(string name, System.Type[] components);
        /*0x1ffc854*/ T GetComponent<T>();
        /*0x3ddf2b4*/ UnityEngine.Component GetComponent(System.Type type);
        /*0x3de1790*/ void GetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x3de1874*/ UnityEngine.Component GetComponentByName(string type);
        /*0x3de1ad0*/ UnityEngine.Component GetComponentByNameWithCase(string type, bool caseSensitive);
        /*0x3de1d4c*/ UnityEngine.Component GetComponent(string type);
        /*0x3ddf524*/ UnityEngine.Component GetComponentInChildren(System.Type type, bool includeInactive);
        /*0x3de1da4*/ UnityEngine.Component GetComponentInChildren(System.Type type);
        /*0x1ffc854*/ T GetComponentInChildren<T>();
        /*0x1ffc854*/ T GetComponentInChildren<T>(bool includeInactive);
        /*0x3ddf600*/ UnityEngine.Component GetComponentInParent(System.Type type, bool includeInactive);
        /*0x3de1e00*/ UnityEngine.Component GetComponentInParent(System.Type type);
        /*0x1ffc854*/ T GetComponentInParent<T>();
        /*0x1ffc854*/ T GetComponentInParent<T>(bool includeInactive);
        /*0x3de1e08*/ System.Array GetComponentsInternal(System.Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList);
        /*0x3de1f4c*/ UnityEngine.Component[] GetComponents(System.Type type);
        /*0x1f30214*/ T[] GetComponents<T>();
        /*0x3de1fd4*/ void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results);
        /*0x1f30ebc*/ void GetComponents<T>(System.Collections.Generic.List<T> results);
        /*0x3de1fec*/ UnityEngine.Component[] GetComponentsInChildren(System.Type type);
        /*0x3de1ff4*/ UnityEngine.Component[] GetComponentsInChildren(System.Type type, bool includeInactive);
        T[] GetComponentsInChildren<T>(bool includeInactive);
        /*0x1f30ac0*/ void GetComponentsInChildren<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        /*0x1f30214*/ T[] GetComponentsInChildren<T>();
        /*0x1f30ebc*/ void GetComponentsInChildren<T>(System.Collections.Generic.List<T> results);
        /*0x3de2088*/ UnityEngine.Component[] GetComponentsInParent(System.Type type);
        /*0x3de2090*/ UnityEngine.Component[] GetComponentsInParent(System.Type type, bool includeInactive);
        /*0x1f30ac0*/ void GetComponentsInParent<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        T[] GetComponentsInParent<T>(bool includeInactive);
        /*0x1f30214*/ T[] GetComponentsInParent<T>();
        /*0x1f2fec8*/ bool TryGetComponent<T>(ref T component);
        /*0x3ddf46c*/ bool TryGetComponent(System.Type type, ref UnityEngine.Component component);
        /*0x3de2124*/ UnityEngine.Component TryGetComponentInternal(System.Type type);
        /*0x3de227c*/ void TryGetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x3de2718*/ void SendMessageUpwards(string methodName, UnityEngine.SendMessageOptions options);
        /*0x3de28dc*/ void SendMessage(string methodName, UnityEngine.SendMessageOptions options);
        /*0x3de2aa0*/ void BroadcastMessage(string methodName, UnityEngine.SendMessageOptions options);
        /*0x3de2c64*/ UnityEngine.Component AddComponentInternal(string className);
        /*0x3de2ec0*/ UnityEngine.Component Internal_AddComponentWithType(System.Type componentType);
        /*0x3de2fa8*/ UnityEngine.Component AddComponent(System.Type componentType);
        /*0x1ffc854*/ T AddComponent<T>();
        /*0x3de2fac*/ int GetComponentCount();
        /*0x3de3060*/ UnityEngine.Component QueryComponentAtIndex(int index);
        /*0x3de3148*/ UnityEngine.Component GetComponentAtIndex(int index);
        /*0x1ffc854*/ T GetComponentAtIndex<T>(int index);
        /*0x3de31d8*/ int GetComponentIndex(UnityEngine.Component component);
        /*0x3de32d0*/ UnityEngine.Transform get_transform();
        /*0x3de33a0*/ int get_layer();
        /*0x3de3454*/ void set_layer(int value);
        /*0x3de3518*/ bool get_active();
        /*0x3de35cc*/ void set_active(bool value);
        /*0x3de3690*/ void SetActive(bool value);
        /*0x3de3754*/ bool get_activeSelf();
        /*0x3de3808*/ bool get_activeInHierarchy();
        /*0x3de38bc*/ void SetActiveRecursively(bool state);
        /*0x3de3980*/ bool get_isStatic();
        /*0x3de3a34*/ void set_isStatic(bool value);
        /*0x3de3af8*/ bool get_isStaticBatchable();
        /*0x3de3bac*/ string get_tag();
        /*0x3de3d1c*/ void set_tag(string value);
        /*0x3ddf7b4*/ bool CompareTag(string tag);
        /*0x3de40a8*/ bool CompareTag(UnityEngine.TagHandle tag);
        /*0x3de3efc*/ bool CompareTag_Internal(string tag);
        /*0x3de40b0*/ bool CompareTagHandle_Internal(UnityEngine.TagHandle tag);
        /*0x3de2724*/ void SendMessageUpwards(string methodName, object value, UnityEngine.SendMessageOptions options);
        /*0x3de4404*/ void SendMessageUpwards(string methodName, object value);
        /*0x3de440c*/ void SendMessageUpwards(string methodName);
        /*0x3de28e8*/ void SendMessage(string methodName, object value, UnityEngine.SendMessageOptions options);
        /*0x3de4474*/ void SendMessage(string methodName, object value);
        /*0x3de447c*/ void SendMessage(string methodName);
        /*0x3de2aac*/ void BroadcastMessage(string methodName, object parameter, UnityEngine.SendMessageOptions options);
        /*0x3de44e4*/ void BroadcastMessage(string methodName, object parameter);
        /*0x3de44ec*/ void BroadcastMessage(string methodName);
        /*0x3de4fd0*/ UnityEngine.SceneManagement.Scene get_scene();
        /*0x3de509c*/ ulong get_sceneCullingMask();
        /*0x3de5150*/ UnityEngine.GameObject get_gameObject();
    }

    class InspectorOrderAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ UnityEngine.InspectorSort <m_inspectorSort>k__BackingField;
        /*0x1c*/ UnityEngine.InspectorSortDirection <m_sortDirection>k__BackingField;

        /*0x3de5154*/ UnityEngine.InspectorSort get_m_inspectorSort();
        /*0x3de515c*/ UnityEngine.InspectorSortDirection get_m_sortDirection();
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

        static /*0x3de5164*/ int op_Implicit(UnityEngine.LayerMask mask);
        static /*0x3de5168*/ UnityEngine.LayerMask op_Implicit(int intVal);
        static /*0x3de5174*/ int NameToLayer(string layerName);
        static /*0x3de52e4*/ int NameToLayer_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper layerName);
        /*0x3de516c*/ int get_value();
    }

    struct LazyLoadReference<T>
    {
        static int kInstanceID_None = 0;
        /*0x0*/ int m_InstanceID;

        static /*0x1ffc854*/ UnityEngine.LazyLoadReference<T> op_Implicit(T asset);
        /*0x1f2fe14*/ bool get_isSet();
        /*0x1ffc854*/ T get_asset();
        /*0x1ffc854*/ void set_asset(T value);
    }

    class ManagedStreamHelpers
    {
        static /*0x3de5320*/ void ValidateLoadFromStream(System.IO.Stream stream);
        static /*0x3de5424*/ void ManagedStreamRead(byte[] buffer, int offset, int count, System.IO.Stream stream, nint returnValueAddress);
        static /*0x3de54f8*/ void ManagedStreamSeek(long offset, uint origin, System.IO.Stream stream, nint returnValueAddress);
        static /*0x3de55c4*/ void ManagedStreamLength(System.IO.Stream stream, nint returnValueAddress);
    }

    class MonoBehaviour : UnityEngine.Behaviour
    {
        /*0x18*/ System.Threading.CancellationTokenSource m_CancellationTokenSource;

        static /*0x3de6ce0*/ void print(object message);
        static /*0x3de5988*/ void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self);
        static /*0x3de58dc*/ bool Internal_IsInvokingAll(UnityEngine.MonoBehaviour self);
        static /*0x3de5a38*/ void InvokeDelayed(UnityEngine.MonoBehaviour self, string methodName, float time, float repeatRate);
        static /*0x3de5d00*/ void CancelInvoke(UnityEngine.MonoBehaviour self, string methodName);
        static /*0x3de5ed4*/ bool IsInvoking(UnityEngine.MonoBehaviour self, string methodName);
        static /*0x3de617c*/ bool IsObjectMonoBehaviour(UnityEngine.Object obj);
        static /*0x3de6908*/ void StopCoroutine_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName);
        static /*0x3de69c4*/ void StopAllCoroutines_Injected(nint _unity_self);
        static /*0x3de6a78*/ bool get_useGUILayout_Injected(nint _unity_self);
        static /*0x3de6b34*/ void set_useGUILayout_Injected(nint _unity_self, bool value);
        static /*0x3de6bf0*/ bool get_didStart_Injected(nint _unity_self);
        static /*0x3de6ca4*/ bool get_didAwake_Injected(nint _unity_self);
        static /*0x3de6d38*/ void Internal_CancelInvokeAll_Injected(nint self);
        static /*0x3de6d74*/ bool Internal_IsInvokingAll_Injected(nint self);
        static /*0x3de6db0*/ void InvokeDelayed_Injected(nint self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, float time, float repeatRate);
        static /*0x3de6e0c*/ void CancelInvoke_Injected(nint self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName);
        static /*0x3de6e50*/ bool IsInvoking_Injected(nint self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName);
        static /*0x3de6e94*/ bool IsObjectMonoBehaviour_Injected(nint obj);
        static /*0x3de6ed0*/ UnityEngine.Coroutine StartCoroutineManaged_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object value);
        static /*0x3de6f24*/ UnityEngine.Coroutine StartCoroutineManaged2_Injected(nint _unity_self, System.Collections.IEnumerator enumerator);
        static /*0x3de6f68*/ void StopCoroutineManaged_Injected(nint _unity_self, nint routine);
        static /*0x3de6fac*/ void StopCoroutineFromEnumeratorManaged_Injected(nint _unity_self, System.Collections.IEnumerator routine);
        static /*0x3de711c*/ void GetScriptClassName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3de7160*/ void OnCancellationTokenCreated_Injected(nint _unity_self);
        /*0x3de719c*/ MonoBehaviour();
        /*0x3de5670*/ System.Threading.CancellationToken get_destroyCancellationToken();
        /*0x3de58c4*/ void RaiseCancellation();
        /*0x3de58d8*/ bool IsInvoking();
        /*0x3de5984*/ void CancelInvoke();
        /*0x3de5a30*/ void Invoke(string methodName, float time);
        /*0x3de5c20*/ void InvokeRepeating(string methodName, float time, float repeatRate);
        /*0x3de5cfc*/ void CancelInvoke(string methodName);
        /*0x3de5ed0*/ bool IsInvoking(string methodName);
        /*0x3de60b0*/ UnityEngine.Coroutine StartCoroutine(string methodName);
        /*0x3de60b8*/ UnityEngine.Coroutine StartCoroutine(string methodName, object value);
        /*0x3de63dc*/ UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine);
        /*0x3de6508*/ UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine);
        /*0x3de650c*/ void StopCoroutine(System.Collections.IEnumerator routine);
        /*0x3de6638*/ void StopCoroutine(UnityEngine.Coroutine routine);
        /*0x3de676c*/ void StopCoroutine(string methodName);
        /*0x3de694c*/ void StopAllCoroutines();
        /*0x3de6a00*/ bool get_useGUILayout();
        /*0x3de6ab4*/ void set_useGUILayout(bool value);
        /*0x3de6b78*/ bool get_didStart();
        /*0x3de6c2c*/ bool get_didAwake();
        /*0x3de6224*/ UnityEngine.Coroutine StartCoroutineManaged(string methodName, object value);
        /*0x3de6488*/ UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator);
        /*0x3de66e4*/ void StopCoroutineManaged(UnityEngine.Coroutine routine);
        /*0x3de65b8*/ void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine);
        /*0x3de6ff0*/ string GetScriptClassName();
        /*0x3de584c*/ void OnCancellationTokenCreated();
    }

    class NoAllocHelpers
    {
        static /*0x1f36244*/ void EnsureListElemCount<T>(System.Collections.Generic.List<T> list, int count);
        static /*0x3de71a0*/ int SafeLength(System.Array values);
        static /*0x1f31f88*/ int SafeLength<T>(System.Collections.Generic.List<T> values);
        static /*0x1f327cc*/ T[] ExtractArrayFromList<T>(System.Collections.Generic.List<T> list);
        static /*0x1ffc854*/ void ResetListContents<T>(System.Collections.Generic.List<T> list, System.ReadOnlySpan<T> span);
        static /*0x1f36244*/ void ResetListSize<T>(System.Collections.Generic.List<T> list, int size);

        class ListPrivateFieldAccess<T>
        {
            /*0x0*/ T[] _items;
            /*0x0*/ int _size;
            /*0x0*/ int _version;
        }
    }

    struct RangeInt
    {
        /*0x10*/ int start;
        /*0x14*/ int length;

        /*0x3de71bc*/ RangeInt(int start, int length);
        /*0x3de71b0*/ int get_end();
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

        /*0x3de71c4*/ RuntimeInitializeOnLoadMethodAttribute();
        /*0x3de71e8*/ RuntimeInitializeOnLoadMethodAttribute(UnityEngine.RuntimeInitializeLoadType loadType);
        /*0x3de71e0*/ void set_loadType(UnityEngine.RuntimeInitializeLoadType value);
    }

    class ScriptableObject : UnityEngine.Object
    {
        static /*0x3de72cc*/ UnityEngine.ScriptableObject CreateInstance(System.Type type);
        static /*0x1ffc854*/ T CreateInstance<T>();
        static /*0x3de7290*/ void CreateScriptableObject(UnityEngine.ScriptableObject self);
        static /*0x3de72d4*/ UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromType(System.Type type, bool applyDefaultsAndReset);
        static /*0x3de7350*/ nint CreateScriptableObjectInstanceFromType_Injected(System.Type type, bool applyDefaultsAndReset);
        /*0x3de7210*/ ScriptableObject();
    }

    class ScriptingRuntime
    {
        static /*0x3de7394*/ string[] GetAllUserAssemblies();
    }

    class ScriptingUtility
    {
        static /*0x3de73bc*/ bool IsManagedCodeWorking();
        static /*0x3de73c4*/ void SetupCallbacks(nint p);

        struct TestClass
        {
            /*0x10*/ int value;
        }
    }

    class SelectionBaseAttribute : System.Attribute
    {
        /*0x3de73c8*/ SelectionBaseAttribute();
    }

    class StackTraceUtility
    {
        static /*0x0*/ string projectFolder;

        static /*0x3de80f8*/ StackTraceUtility();
        static /*0x3de73d0*/ void SetProjectFolder(string folder);
        static /*0x3de74d4*/ string ExtractStackTrace();
        static /*0x3de7d80*/ void ExtractStringFromExceptionInternal(object exceptiono, ref string message, ref string stackTrace);
        static /*0x3de7630*/ string ExtractFormattedStackTrace(System.Diagnostics.StackTrace stackFrames);
    }

    class UnityException : System.Exception
    {
        /*0x3de8160*/ UnityException();
        /*0x3de5c84*/ UnityException(string message);
        /*0x3de81e0*/ UnityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    }

    class MissingReferenceException : System.Exception
    {
        /*0x3de8260*/ MissingReferenceException();
        /*0x3de57d4*/ MissingReferenceException(string message);
        /*0x3de82e0*/ MissingReferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    }

    struct TagHandle
    {
        /*0x10*/ uint _tagIndex;

        static /*0x3de8368*/ string TagToString(uint tagIndex);
        static /*0x3de8434*/ void TagToString_Injected(uint tagIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        /*0x3de8360*/ string ToString();
    }

    class TextAsset : UnityEngine.Object
    {
        static /*0x3de85f0*/ void Internal_CreateInstance(UnityEngine.TextAsset self, string text);
        static /*0x3de87a4*/ void Internal_CreateInstanceFromBytes(UnityEngine.TextAsset self, System.ReadOnlySpan<byte> bytes);
        static /*0x3de8a48*/ string DecodeString(byte[] bytes);
        static /*0x3de84f0*/ byte[] get_bytes_Injected(nint _unity_self);
        static /*0x3de85ac*/ byte[] GetPreviewBytes_Injected(nint _unity_self, int maxByteCount);
        static /*0x3de8760*/ void Internal_CreateInstance_Injected(UnityEngine.TextAsset self, ref UnityEngine.Bindings.ManagedSpanWrapper text);
        static /*0x3de8860*/ void Internal_CreateInstanceFromBytes_Injected(UnityEngine.TextAsset self, ref UnityEngine.Bindings.ManagedSpanWrapper bytes);
        static /*0x3de891c*/ nint GetDataPtr_Injected(nint _unity_self);
        static /*0x3de89d0*/ long GetDataSize_Injected(nint _unity_self);
        /*0x3de8de8*/ TextAsset();
        /*0x3de8e80*/ TextAsset(string text);
        /*0x3de8e8c*/ TextAsset(System.ReadOnlySpan<byte> bytes);
        /*0x3de8df4*/ TextAsset(UnityEngine.TextAsset.CreateOptions options, string text);
        /*0x3de8e9c*/ TextAsset(UnityEngine.TextAsset.CreateOptions options, System.ReadOnlySpan<byte> bytes);
        /*0x3de8478*/ byte[] get_bytes();
        /*0x3de852c*/ byte[] GetPreviewBytes(int maxByteCount);
        /*0x3de88a4*/ nint GetDataPtr();
        /*0x3de8958*/ long GetDataSize();
        /*0x3de8a0c*/ string get_text();
        /*0x3de8de0*/ long get_dataSize();
        /*0x3de8de4*/ string ToString();
        /*0x1ffc854*/ Unity.Collections.NativeArray<T> GetData<T>();
        /*0x3de8f3c*/ string GetPreview(int maxChars);

        enum CreateOptions
        {
            None = 0,
            CreateNativeObject = 1,
        }

        class EncodingUtility
        {
            static /*0x0*/ System.Collections.Generic.KeyValuePair<System.Byte[], System.Text.Encoding> encodingLookup;
            static /*0x8*/ System.Text.Encoding targetEncoding;

            static /*0x3de8f50*/ EncodingUtility();
        }
    }

    class TrackedReference
    {
        /*0x10*/ nint m_Ptr;

        static /*0x3de9328*/ bool op_Equality(UnityEngine.TrackedReference x, UnityEngine.TrackedReference y);
        static /*0x3de9374*/ bool op_Inequality(UnityEngine.TrackedReference x, UnityEngine.TrackedReference y);
        static /*0x3de948c*/ bool op_Implicit(UnityEngine.TrackedReference exists);
        /*0x3de9320*/ TrackedReference();
        /*0x3de93c0*/ bool Equals(object o);
        /*0x3de9480*/ int GetHashCode();
    }

    class UnhandledExceptionHandler
    {
        static /*0x3de94a0*/ void RegisterUECatcher();

        class <>c
        {
            static /*0x0*/ UnityEngine.UnhandledExceptionHandler.<> <>9;
            static /*0x8*/ System.UnhandledExceptionEventHandler <>9__0_0;

            static /*0x3de959c*/ <>c();
            /*0x3de9604*/ <>c();
            /*0x3de960c*/ void <RegisterUECatcher>b__0_0(object sender, System.UnhandledExceptionEventArgs e);
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

    enum FindObjectsSortMode
    {
        None = 0,
        InstanceID = 1,
    }

    enum FindObjectsInactive
    {
        Exclude = 0,
        Include = 1,
    }

    struct InstantiateParameters
    {
        /*0x10*/ UnityEngine.Transform parent;
        /*0x18*/ UnityEngine.SceneManagement.Scene scene;
        /*0x1c*/ bool worldSpace;
        /*0x1d*/ bool originalImmutable;
    }

    class Object
    {
        static int kInstanceID_None = 0;
        static string objectIsNullMessage = "The Object you want to instantiate is null.";
        static string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";
        static /*0x0*/ int OffsetOfInstanceIDInCPlusPlusObject;
        /*0x10*/ nint m_CachedPtr;

        static /*0x3dec2bc*/ Object();
        static /*0x3de98e4*/ bool op_Implicit(UnityEngine.Object exists);
        static /*0x3de983c*/ bool CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs);
        static /*0x3de9948*/ bool IsNativeObjectAlive(UnityEngine.Object o);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, UnityEngine.Transform parent);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Transform parent);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Threading.CancellationToken cancellationToken);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Transform parent, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Transform parent, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations, System.Threading.CancellationToken cancellationToken);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, UnityEngine.InstantiateParameters parameters, System.Threading.CancellationToken cancellationToken);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.InstantiateParameters parameters, System.Threading.CancellationToken cancellationToken);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters, System.Threading.CancellationToken cancellationToken);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters, System.Threading.CancellationToken cancellationToken);
        static /*0x1ffc854*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations, UnityEngine.InstantiateParameters parameters, System.Threading.CancellationToken cancellationToken);
        static /*0x3de9d64*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x3dea06c*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        static /*0x3dea398*/ UnityEngine.Object Instantiate(UnityEngine.Object original);
        static /*0x3dea550*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.SceneManagement.Scene scene);
        static /*0x1ffc854*/ T Instantiate<T>(T original, UnityEngine.InstantiateParameters parameters);
        static /*0x1ffc854*/ T Instantiate<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters);
        static /*0x3dea72c*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent);
        static /*0x3dea794*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, bool instantiateInWorldSpace);
        static /*0x1ffc854*/ T Instantiate<T>(T original);
        static /*0x1ffc854*/ T Instantiate<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x1ffc854*/ T Instantiate<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        static /*0x1ffc854*/ T Instantiate<T>(T original, UnityEngine.Transform parent);
        static /*0x1ffc854*/ T Instantiate<T>(T original, UnityEngine.Transform parent, bool worldPositionStays);
        static /*0x3deaa28*/ void Destroy(UnityEngine.Object obj, float t);
        static /*0x3deab24*/ void Destroy(UnityEngine.Object obj);
        static /*0x3deab7c*/ void DestroyImmediate(UnityEngine.Object obj, bool allowDestroyingAssets);
        static /*0x3deac70*/ void DestroyImmediate(UnityEngine.Object obj);
        static /*0x3deacc8*/ UnityEngine.Object[] FindObjectsOfType(System.Type type);
        static /*0x3dead40*/ UnityEngine.Object[] FindObjectsOfType(System.Type type, bool includeInactive);
        static /*0x3dead84*/ UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode);
        static /*0x3deae0c*/ UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);
        static /*0x3deae60*/ void DontDestroyOnLoad(UnityEngine.Object target);
        static /*0x3deb130*/ void DestroyObject(UnityEngine.Object obj, float t);
        static /*0x3deb194*/ void DestroyObject(UnityEngine.Object obj);
        static /*0x3deb1ec*/ UnityEngine.Object[] FindSceneObjectsOfType(System.Type type);
        static /*0x3deb240*/ UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type);
        static /*0x1f327a0*/ T[] FindObjectsOfType<T>();
        static T[] FindObjectsByType<T>(UnityEngine.FindObjectsSortMode sortMode);
        static T[] FindObjectsOfType<T>(bool includeInactive);
        static T[] FindObjectsByType<T>(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);
        static /*0x1ffc854*/ T FindObjectOfType<T>();
        static /*0x1ffc854*/ T FindObjectOfType<T>(bool includeInactive);
        static /*0x1ffc854*/ T FindFirstObjectByType<T>();
        static /*0x1ffc854*/ T FindAnyObjectByType<T>();
        static /*0x1ffc854*/ T FindFirstObjectByType<T>(UnityEngine.FindObjectsInactive findObjectsInactive);
        static /*0x1ffc854*/ T FindAnyObjectByType<T>(UnityEngine.FindObjectsInactive findObjectsInactive);
        static /*0x3deb27c*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type);
        static /*0x3de9f14*/ void CheckNullArgument(object arg, string message);
        static /*0x3deb280*/ UnityEngine.Object FindObjectOfType(System.Type type);
        static /*0x3deb318*/ UnityEngine.Object FindFirstObjectByType(System.Type type);
        static /*0x3deb3bc*/ UnityEngine.Object FindAnyObjectByType(System.Type type);
        static /*0x3deb460*/ UnityEngine.Object FindObjectOfType(System.Type type, bool includeInactive);
        static /*0x3deb504*/ UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive);
        static /*0x3deb5b4*/ UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive);
        static /*0x3de5770*/ bool op_Equality(UnityEngine.Object x, UnityEngine.Object y);
        static /*0x3de21c8*/ bool op_Inequality(UnityEngine.Object x, UnityEngine.Object y);
        static /*0x3deb7e8*/ int GetOffsetOfInstanceIDInCPlusPlusObject();
        static /*0x3de9a1c*/ bool CurrentThreadIsMainThread();
        static /*0x3dea468*/ UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data);
        static /*0x3dea630*/ UnityEngine.Object Internal_CloneSingleWithScene(UnityEngine.Object data, UnityEngine.SceneManagement.Scene scene);
        static /*0x3deb890*/ UnityEngine.Object Internal_CloneSingleWithParams(UnityEngine.Object data, UnityEngine.InstantiateParameters parameters);
        static /*0x3deb9d0*/ UnityEngine.Object Internal_InstantiateSingleWithParams(UnityEngine.Object data, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters);
        static /*0x3dea8bc*/ UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, bool worldPositionStays);
        static /*0x3debb94*/ nint Internal_InstantiateAsyncWithParams(UnityEngine.Object original, int count, UnityEngine.InstantiateParameters parameters, nint positions, int positionsCount, nint rotations, int rotationsCount);
        static /*0x3de9f60*/ UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
        static /*0x3dea210*/ UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
        static /*0x3deb6b8*/ string ToString(UnityEngine.Object obj);
        static /*0x3debe70*/ bool IsPersistent(UnityEngine.Object obj);
        static /*0x3debfbc*/ bool DoesObjectWithInstanceIDExist(int instanceID);
        static /*0x3debff8*/ UnityEngine.Object FindObjectFromInstanceID(int instanceID);
        static /*0x3dec0c4*/ nint GetPtrFromInstanceID(int instanceID, System.Type objectType, ref bool isMonoBehaviour);
        static /*0x3dec118*/ UnityEngine.Object ForceLoadFromInstanceID(int instanceID);
        static /*0x3deaad8*/ void Destroy_Injected(nint obj, float t);
        static /*0x3deac2c*/ void DestroyImmediate_Injected(nint obj, bool allowDestroyingAssets);
        static /*0x3deaf2c*/ void DontDestroyOnLoad_Injected(nint target);
        static /*0x3deb004*/ UnityEngine.HideFlags get_hideFlags_Injected(nint _unity_self);
        static /*0x3deb0ec*/ void set_hideFlags_Injected(nint _unity_self, UnityEngine.HideFlags value);
        static /*0x3deb810*/ nint Internal_CloneSingle_Injected(nint data);
        static /*0x3deb84c*/ nint Internal_CloneSingleWithScene_Injected(nint data, ref UnityEngine.SceneManagement.Scene scene);
        static /*0x3deb98c*/ nint Internal_CloneSingleWithParams_Injected(nint data, ref UnityEngine.InstantiateParameters parameters);
        static /*0x3debae4*/ nint Internal_InstantiateSingleWithParams_Injected(nint data, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.InstantiateParameters parameters);
        static /*0x3debb40*/ nint Internal_CloneSingleWithParent_Injected(nint data, nint parent, bool worldPositionStays);
        static /*0x3debcb4*/ nint Internal_InstantiateAsyncWithParams_Injected(nint original, int count, ref UnityEngine.InstantiateParameters parameters, nint positions, int positionsCount, nint rotations, int rotationsCount);
        static /*0x3debd38*/ nint Internal_InstantiateSingle_Injected(nint data, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
        static /*0x3debd8c*/ nint Internal_InstantiateSingleWithParent_Injected(nint data, nint parent, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
        static /*0x3debde8*/ void ToString_Injected(nint obj, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3debe2c*/ void GetName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3debf3c*/ bool IsPersistent_Injected(nint obj);
        static /*0x3debf78*/ void SetName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3dec088*/ nint FindObjectFromInstanceID_Injected(int instanceID);
        static /*0x3dec1a8*/ nint ForceLoadFromInstanceID_Injected(int instanceID);
        static /*0x3dec280*/ void MarkDirty_Injected(nint _unity_self);
        /*0x3ddf7b8*/ Object();
        /*0x3de96c0*/ int GetInstanceID();
        /*0x3de9738*/ int GetHashCode();
        /*0x3de9740*/ bool Equals(object other);
        /*0x3de9964*/ void EnsureRunningOnMainThread();
        /*0x3de9a44*/ nint GetCachedPtr();
        /*0x3de9a4c*/ string get_name();
        /*0x3de9ba0*/ void set_name(string value);
        /*0x3deaf68*/ UnityEngine.HideFlags get_hideFlags();
        /*0x3deb040*/ void set_hideFlags(UnityEngine.HideFlags value);
        /*0x3deb664*/ string ToString();
        /*0x3de9a50*/ string GetName();
        /*0x3de9ba4*/ void SetName(string name);
        /*0x3dec1e4*/ void MarkDirty();

        class MarshalledUnityObject
        {
            static /*0x1ffc854*/ nint Marshal<T>(T obj);
            static /*0x1ffc854*/ nint MarshalNotNull<T>(T obj);
            static /*0x3dec324*/ void TryThrowEditorNullExceptionObject(UnityEngine.Object unityObj, string paramterName);
        }
    }

    class UnitySynchronizationContext : System.Threading.SynchronizationContext
    {
        /*0x18*/ System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue;
        /*0x20*/ System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork;
        /*0x28*/ int m_MainThreadID;
        /*0x2c*/ int m_TrackedCount;

        static /*0x3decc88*/ void InitializeSynchronizationContext();
        static /*0x3decd2c*/ void ExecuteTasks();
        static /*0x3decd84*/ bool ExecutePendingTasks(long millisecondsTimeout);
        /*0x3dec330*/ UnitySynchronizationContext(int mainThreadID);
        /*0x3dec3f4*/ UnitySynchronizationContext(System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> queue, int mainThreadID);
        /*0x3dec328*/ int get_MainThreadId();
        /*0x3dec4ac*/ void Send(System.Threading.SendOrPostCallback callback, object state);
        /*0x3dec79c*/ void OperationStarted();
        /*0x3dec7a8*/ void OperationCompleted();
        /*0x3dec7b4*/ void Post(System.Threading.SendOrPostCallback callback, object state);
        /*0x3dec8f0*/ System.Threading.SynchronizationContext CreateCopy();
        /*0x3dec954*/ void Exec();
        /*0x3decc28*/ bool HasPendingTasks();

        struct WorkRequest
        {
            /*0x10*/ System.Threading.SendOrPostCallback m_DelagateCallback;
            /*0x18*/ object m_DelagateState;
            /*0x20*/ System.Threading.ManualResetEvent m_WaitHandle;

            /*0x3dec758*/ WorkRequest(System.Threading.SendOrPostCallback callback, object state, System.Threading.ManualResetEvent waitHandle);
            /*0x3decb5c*/ void Invoke();
        }
    }

    class WaitForEndOfFrame : UnityEngine.YieldInstruction
    {
        /*0x3dece70*/ WaitForEndOfFrame();
    }

    class WaitForFixedUpdate : UnityEngine.YieldInstruction
    {
        /*0x3dece78*/ WaitForFixedUpdate();
    }

    class WaitForSeconds : UnityEngine.YieldInstruction
    {
        /*0x10*/ float m_Seconds;

        /*0x3dece80*/ WaitForSeconds(float seconds);
    }

    class WaitForSecondsRealtime : UnityEngine.CustomYieldInstruction
    {
        /*0x10*/ float <waitTime>k__BackingField;
        /*0x14*/ float m_WaitUntilTime;

        /*0x3decf7c*/ WaitForSecondsRealtime(float time);
        /*0x3decea8*/ float get_waitTime();
        /*0x3deceb0*/ void set_waitTime(float value);
        /*0x3deceb8*/ bool get_keepWaiting();
        /*0x3decfac*/ void Reset();
    }

    class YieldInstruction
    {
        /*0x3ddbac4*/ YieldInstruction();
    }

    class SerializeField : System.Attribute
    {
        /*0x3decfb8*/ SerializeField();
    }

    class SerializeReference : System.Attribute
    {
        /*0x3decfc0*/ SerializeReference();
    }

    class PreferBinarySerialization : System.Attribute
    {
        /*0x3decfc8*/ PreferBinarySerialization();
    }

    interface ISerializationCallbackReceiver
    {
        /*0x1f309e4*/ void OnBeforeSerialize();
        /*0x1f309e4*/ void OnAfterDeserialize();
    }

    class ComputeBuffer : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;

        static /*0x3ded1c4*/ nint InitBuffer(int count, int stride, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage);
        static /*0x3ded17c*/ void DestroyBuffer(UnityEngine.ComputeBuffer buf);
        static /*0x3ded474*/ bool IsValidBuffer(UnityEngine.ComputeBuffer buf);
        static /*0x3ded220*/ void DestroyBuffer_Injected(nint buf);
        static /*0x3ded4bc*/ bool IsValidBuffer_Injected(nint buf);
        static /*0x3ded598*/ int get_count_Injected(nint _unity_self);
        static /*0x3ded624*/ int get_stride_Injected(nint _unity_self);
        static /*0x3ded8a0*/ void InternalSetNativeData_Injected(nint _unity_self, nint data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);
        static /*0x3ded914*/ void InternalSetData_Injected(nint _unity_self, System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);
        /*0x3ded25c*/ ComputeBuffer(int count, int stride);
        /*0x3ded440*/ ComputeBuffer(int count, int stride, UnityEngine.ComputeBufferType type);
        /*0x3ded268*/ ComputeBuffer(int count, int stride, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage, int stackDepth);
        /*0x3decfd0*/ void Finalize();
        /*0x3ded118*/ void Dispose();
        /*0x3ded058*/ void Dispose(bool disposing);
        /*0x3ded470*/ void Release();
        /*0x3ded4f8*/ bool IsValid();
        /*0x3ded548*/ int get_count();
        /*0x3ded5d4*/ int get_stride();
        /*0x3ded660*/ void SetData(System.Array data);
        /*0x1ffc854*/ void SetData<T>(Unity.Collections.NativeArray<T> data);
        /*0x1ffc854*/ void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count);
        /*0x3ded818*/ void InternalSetNativeData(nint data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);
        /*0x3ded790*/ void InternalSetData(System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

        class BindingsMarshaller
        {
            static /*0x3ded988*/ nint ConvertToNative(UnityEngine.ComputeBuffer computeBuffer);
        }
    }

    class ComputeShader : UnityEngine.Object
    {
        static /*0x3dedb44*/ int FindKernel_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x3dedc18*/ void SetInt_Injected(nint _unity_self, int nameID, int val);
        static /*0x3dedd7c*/ void SetIntArray_Injected(nint _unity_self, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
        static /*0x3dedec0*/ void Internal_SetBuffer_Injected(nint _unity_self, int kernelIndex, int nameID, nint buffer);
        static /*0x3dee00c*/ void Internal_SetGraphicsBuffer_Injected(nint _unity_self, int kernelIndex, int nameID, nint buffer);
        static /*0x3dee170*/ void SetConstantComputeBuffer_Injected(nint _unity_self, int nameID, nint buffer, int offset, int size);
        static /*0x3dee284*/ void Dispatch_Injected(nint _unity_self, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
        static /*0x3dee378*/ void get_keywordSpace_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeywordSpace ret);
        static /*0x3dee558*/ void EnableKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x3dee738*/ void DisableKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x3dee7fc*/ void SetShaderKeywords_Injected(nint _unity_self, string[] names);
        /*0x3dee844*/ ComputeShader();
        /*0x3ded99c*/ int FindKernel(string name);
        /*0x3dedb88*/ void SetInt(int nameID, int val);
        /*0x3dedc6c*/ void SetIntArray(int nameID, int[] values);
        /*0x3deddd0*/ void Internal_SetBuffer(int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
        /*0x3dedf1c*/ void Internal_SetGraphicsBuffer(int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
        /*0x3dee068*/ void SetBuffer(int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
        /*0x3dee06c*/ void SetBuffer(int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
        /*0x3dee070*/ void SetConstantComputeBuffer(int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
        /*0x3dee1dc*/ void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
        /*0x3dee2f0*/ UnityEngine.Rendering.LocalKeywordSpace get_keywordSpace();
        /*0x3dee3bc*/ void EnableKeyword(string keyword);
        /*0x3dee59c*/ void DisableKeyword(string keyword);
        /*0x3dee77c*/ void SetShaderKeywords(string[] names);
        /*0x3dee840*/ void set_shaderKeywords(string[] value);
        /*0x3dee89c*/ void SetInts(int nameID, int[] values);
        /*0x3dee8a0*/ void SetConstantBuffer(int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
    }

    enum MaterialPropertyType
    {
        Float = 0,
        Int = 1,
        Vector = 2,
        Matrix = 3,
        Texture = 4,
        ConstantBuffer = 5,
        ComputeBuffer = 6,
    }

    enum DisableBatchingType
    {
        False = 0,
        True = 1,
        WhenLODFading = 2,
    }

    class LowerResBlitTexture : UnityEngine.Object
    {
        /*0x3dee8a4*/ void LowerResBlitTextureDontStripMe();
    }

    class PreloadData : UnityEngine.Object
    {
        /*0x3dee8a8*/ void PreloadDataDontStripMe();
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
        static /*0x3dee8ac*/ string get_operatingSystem();
        static /*0x3dee974*/ UnityEngine.OperatingSystemFamily get_operatingSystemFamily();
        static /*0x3dee9c4*/ string get_processorType();
        static /*0x3deea8c*/ int get_processorFrequency();
        static /*0x3deeadc*/ int get_processorCount();
        static /*0x3deeb2c*/ int get_systemMemorySize();
        static /*0x3deeb7c*/ string get_deviceUniqueIdentifier();
        static /*0x3deec44*/ string get_deviceName();
        static /*0x3deed0c*/ string get_deviceModel();
        static /*0x3deedd4*/ UnityEngine.DeviceType get_deviceType();
        static /*0x3deee24*/ int get_graphicsMemorySize();
        static /*0x3deee74*/ string get_graphicsDeviceName();
        static /*0x3deef3c*/ string get_graphicsDeviceVendor();
        static /*0x3def004*/ int get_graphicsDeviceID();
        static /*0x3def054*/ int get_graphicsDeviceVendorID();
        static /*0x3def0a4*/ UnityEngine.Rendering.GraphicsDeviceType get_graphicsDeviceType();
        static /*0x3def0f4*/ bool get_graphicsUVStartsAtTop();
        static /*0x3def144*/ string get_graphicsDeviceVersion();
        static /*0x3def20c*/ int get_graphicsShaderLevel();
        static /*0x3def25c*/ UnityEngine.Rendering.RenderingThreadingMode get_renderingThreadingMode();
        static /*0x3def2ac*/ UnityEngine.Rendering.FoveatedRenderingCaps get_foveatedRenderingCaps();
        static /*0x3def2fc*/ bool get_hasHiddenSurfaceRemovalOnGPU();
        static /*0x3def34c*/ bool get_supportsShadows();
        static /*0x3def39c*/ UnityEngine.Rendering.CopyTextureSupport get_copyTextureSupport();
        static /*0x3def3ec*/ bool get_supportsComputeShaders();
        static /*0x3def43c*/ bool get_supportsRenderTargetArrayIndexFromVertexShader();
        static /*0x3def48c*/ bool get_supportsInstancing();
        static /*0x3def4dc*/ int get_supportedRenderTargetCount();
        static /*0x3def52c*/ int get_supportsMultisampledTextures();
        static /*0x3def57c*/ bool get_supportsMultisampledBackBuffer();
        static /*0x3def5cc*/ bool get_supportsMultisampleAutoResolve();
        static /*0x3def61c*/ bool get_usesReversedZBuffer();
        static /*0x3def66c*/ bool IsValidEnumValue(System.Enum value);
        static /*0x3def6c0*/ bool SupportsRenderTextureFormat(UnityEngine.RenderTextureFormat format);
        static /*0x3def7d0*/ bool SupportsTextureFormat(UnityEngine.TextureFormat format);
        static /*0x3def8e0*/ int get_maxTextureSize();
        static /*0x3def930*/ int get_maxRenderTextureSize();
        static /*0x3def980*/ bool get_supportsGraphicsFence();
        static /*0x3ded448*/ long get_maxGraphicsBufferSize();
        static /*0x3def9f8*/ bool get_usesLoadStoreActions();
        static /*0x3defa48*/ UnityEngine.HDRDisplaySupportFlags get_hdrDisplaySupportFlags();
        static /*0x3defa98*/ bool get_supportsMultiview();
        static /*0x3defae8*/ bool get_supportsStoreAndResolveAction();
        static /*0x3defb38*/ bool get_supportsMultisampleResolveDepth();
        static /*0x3defb88*/ bool get_supportsMultisampleResolveStencil();
        static /*0x3defbd8*/ bool get_supportsIndirectArgumentsBuffer();
        static /*0x3dee8b0*/ string GetOperatingSystem();
        static /*0x3dee99c*/ UnityEngine.OperatingSystemFamily GetOperatingSystemFamily();
        static /*0x3dee9c8*/ string GetProcessorType();
        static /*0x3deeab4*/ int GetProcessorFrequencyMHz();
        static /*0x3deeb04*/ int GetProcessorCount();
        static /*0x3deeb54*/ int GetPhysicalMemoryMB();
        static /*0x3deeb80*/ string GetDeviceUniqueIdentifier();
        static /*0x3deec48*/ string GetDeviceName();
        static /*0x3deed10*/ string GetDeviceModel();
        static /*0x3deedfc*/ UnityEngine.DeviceType GetDeviceType();
        static /*0x3deee4c*/ int GetGraphicsMemorySize();
        static /*0x3deee78*/ string GetGraphicsDeviceName();
        static /*0x3deef40*/ string GetGraphicsDeviceVendor();
        static /*0x3def02c*/ int GetGraphicsDeviceID();
        static /*0x3def07c*/ int GetGraphicsDeviceVendorID();
        static /*0x3def0cc*/ UnityEngine.Rendering.GraphicsDeviceType GetGraphicsDeviceType();
        static /*0x3def11c*/ bool GetGraphicsUVStartsAtTop();
        static /*0x3def148*/ string GetGraphicsDeviceVersion();
        static /*0x3def234*/ int GetGraphicsShaderLevel();
        static /*0x3def284*/ UnityEngine.Rendering.RenderingThreadingMode GetRenderingThreadingMode();
        static /*0x3def2d4*/ UnityEngine.Rendering.FoveatedRenderingCaps GetFoveatedRenderingCaps();
        static /*0x3def324*/ bool HasHiddenSurfaceRemovalOnGPU();
        static /*0x3def374*/ bool SupportsShadows();
        static /*0x3def3c4*/ UnityEngine.Rendering.CopyTextureSupport GetCopyTextureSupport();
        static /*0x3def414*/ bool SupportsComputeShaders();
        static /*0x3def464*/ bool SupportsRenderTargetArrayIndexFromVertexShader();
        static /*0x3def4b4*/ bool SupportsInstancing();
        static /*0x3def504*/ int SupportedRenderTargetCount();
        static /*0x3def554*/ int SupportsMultisampledTextures();
        static /*0x3def5a4*/ bool SupportsMultisampledBackBuffer();
        static /*0x3def5f4*/ bool SupportsMultisampleAutoResolve();
        static /*0x3def644*/ bool UsesReversedZBuffer();
        static /*0x3def794*/ bool HasRenderTextureNative(UnityEngine.RenderTextureFormat format);
        static /*0x3def8a4*/ bool SupportsTextureFormatNative(UnityEngine.TextureFormat format);
        static /*0x3def908*/ int GetMaxTextureSize();
        static /*0x3def958*/ int GetMaxRenderTextureSize();
        static /*0x3def9a8*/ bool SupportsGPUFence();
        static /*0x3def9d0*/ long MaxGraphicsBufferSize();
        static /*0x3defe08*/ bool IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.GraphicsFormatUsage usage);
        static /*0x3defe4c*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.GraphicsFormatUsage usage);
        static /*0x3defe90*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat format);
        static /*0x3defecc*/ int GetRenderTextureSupportedMSAASampleCount(UnityEngine.RenderTextureDescriptor desc);
        static /*0x3defa20*/ bool UsesLoadStoreActions();
        static /*0x3defa70*/ UnityEngine.HDRDisplaySupportFlags GetHDRDisplaySupportFlags();
        static /*0x3defac0*/ bool SupportsMultiview();
        static /*0x3defb10*/ bool SupportsStoreAndResolveAction();
        static /*0x3defb60*/ bool SupportsMultisampleResolveDepth();
        static /*0x3defbb0*/ bool SupportsMultisampleResolveStencil();
        static /*0x3defc00*/ bool SupportsIndirectArgumentsBuffer();
        static /*0x3defc28*/ void GetOperatingSystem_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3defc64*/ void GetProcessorType_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3defca0*/ void GetDeviceUniqueIdentifier_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3defcdc*/ void GetDeviceName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3defd18*/ void GetDeviceModel_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3defd54*/ void GetGraphicsDeviceName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3defd90*/ void GetGraphicsDeviceVendor_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3defdcc*/ void GetGraphicsDeviceVersion_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3deff08*/ int GetRenderTextureSupportedMSAASampleCount_Injected(ref UnityEngine.RenderTextureDescriptor desc);
    }

    class SystemClock
    {
        static /*0x0*/ System.DateTime s_Epoch;

        static /*0x3deff94*/ SystemClock();
        static /*0x3deff44*/ System.DateTime get_now();
    }

    class Time
    {
        static /*0x3df0010*/ float get_time();
        static /*0x3df0038*/ Unity.IntegerTime.RationalTime get_timeAsRational();
        static /*0x3df00b8*/ float get_deltaTime();
        static /*0x3df00e0*/ float get_unscaledTime();
        static /*0x3df0108*/ float get_unscaledDeltaTime();
        static /*0x3df0130*/ float get_smoothDeltaTime();
        static /*0x3df0158*/ float get_timeScale();
        static /*0x3dde570*/ int get_frameCount();
        static /*0x3df0180*/ int get_renderedFrameCount();
        static /*0x3decf54*/ float get_realtimeSinceStartup();
        static /*0x3df007c*/ void get_timeAsRational_Injected(ref Unity.IntegerTime.RationalTime ret);
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

        static /*0x3df01a8*/ void Internal_Destroy(nint ptr);
        static /*0x3df0440*/ nint TouchScreenKeyboard_InternalConstructorHelper(ref UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder);
        static /*0x3df06dc*/ bool get_isSupported();
        static /*0x3df0798*/ bool get_disableInPlaceEditing();
        static /*0x3df07e0*/ bool get_isInPlaceEditingAllowed();
        static /*0x3df084c*/ bool IsInPlaceEditingAllowed();
        static /*0x3df0874*/ UnityEngine.TouchScreenKeyboard Open(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit);
        static /*0x3df092c*/ UnityEngine.TouchScreenKeyboard Open(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure);
        static /*0x3df09b8*/ UnityEngine.TouchScreenKeyboard Open(string text, UnityEngine.TouchScreenKeyboardType keyboardType);
        static /*0x3df0d48*/ void set_hideInput(bool value);
        static /*0x3df0d84*/ UnityEngine.TouchScreenKeyboard.InputFieldAppearance get_inputFieldAppearance();
        static /*0x3df0ed4*/ bool GetDone(nint ptr);
        static /*0x3df11d8*/ void GetSelection(ref int start, ref int length);
        static /*0x3df1324*/ void SetSelection(int start, int length);
        static /*0x3df0688*/ nint TouchScreenKeyboard_InternalConstructorHelper_Injected(ref UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments arguments, ref UnityEngine.Bindings.ManagedSpanWrapper text, ref UnityEngine.Bindings.ManagedSpanWrapper textPlaceholder);
        static /*0x3df0b30*/ void get_text_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3df0d04*/ void set_text_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x3df0dfc*/ bool get_active_Injected(nint _unity_self);
        static /*0x3df0e90*/ void set_active_Injected(nint _unity_self, bool value);
        static /*0x3df0f9c*/ UnityEngine.TouchScreenKeyboard.Status get_status_Injected(nint _unity_self);
        static /*0x3df1030*/ void set_characterLimit_Injected(nint _unity_self, int value);
        static /*0x3df10c4*/ bool get_canGetSelection_Injected(nint _unity_self);
        static /*0x3df1150*/ bool get_canSetSelection_Injected(nint _unity_self);
        /*0x3df02fc*/ TouchScreenKeyboard(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit);
        /*0x3df01e4*/ void Destroy();
        /*0x3df0278*/ void Finalize();
        /*0x3df0a30*/ string get_text();
        /*0x3df0b74*/ void set_text(string value);
        /*0x3df0dac*/ bool get_active();
        /*0x3df0e38*/ void set_active(bool value);
        /*0x3df0f10*/ bool get_done();
        /*0x3df0f4c*/ UnityEngine.TouchScreenKeyboard.Status get_status();
        /*0x3df0fd8*/ void set_characterLimit(int value);
        /*0x3df1074*/ bool get_canGetSelection();
        /*0x3df1100*/ bool get_canSetSelection();
        /*0x3df118c*/ UnityEngine.RangeInt get_selection();
        /*0x3df121c*/ void set_selection(UnityEngine.RangeInt value);

        enum Status
        {
            Visible = 0,
            Done = 1,
            Canceled = 2,
            LostFocus = 3,
        }

        enum InputFieldAppearance
        {
            Customizable = 0,
            AlwaysVisible = 1,
            AlwaysHidden = 2,
        }

        class BindingsMarshaller
        {
            static /*0x3df1368*/ nint ConvertToNative(UnityEngine.TouchScreenKeyboard touchScreenKeyboard);
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

        static /*0x3df1b58*/ UINumericFieldsUtils();
        static /*0x3df137c*/ bool TryConvertStringToDouble(string str, ref double value, ref UnityEngine.ExpressionEvaluator.Expression expr);
        static /*0x3df1518*/ bool TryConvertStringToDouble(string str, string initialValueAsString, ref double value, ref UnityEngine.ExpressionEvaluator.Expression expression);
        static /*0x3df1634*/ bool TryConvertStringToFloat(string str, string initialValueAsString, ref float value, ref UnityEngine.ExpressionEvaluator.Expression expression);
        static /*0x3df16d0*/ bool TryConvertStringToLong(string str, ref long value, ref UnityEngine.ExpressionEvaluator.Expression expr);
        static /*0x3df1754*/ bool TryConvertStringToLong(string str, string initialValueAsString, ref long value, ref UnityEngine.ExpressionEvaluator.Expression expression);
        static /*0x3df1870*/ bool TryConvertStringToULong(string str, ref ulong value, ref UnityEngine.ExpressionEvaluator.Expression expr);
        static /*0x3df18f4*/ bool TryConvertStringToULong(string str, string initialValueAsString, ref ulong value, ref UnityEngine.ExpressionEvaluator.Expression expression);
        static /*0x3df1a10*/ bool TryConvertStringToInt(string str, string initialValueAsString, ref int value, ref UnityEngine.ExpressionEvaluator.Expression expression);
        static /*0x3df1ab4*/ bool TryConvertStringToUInt(string str, string initialValueAsString, ref uint value, ref UnityEngine.ExpressionEvaluator.Expression expression);
    }

    class NameFormatter
    {
        static /*0x3df1c70*/ string FormatVariableName(string name);
        static /*0x3df1e60*/ void FormatVariableName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
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
        /*0x3df1ea4*/ void Add(UnityEngine.Object driver, UnityEngine.RectTransform rectTransform, UnityEngine.DrivenTransformProperties drivenProperties);
        /*0x3df1ea8*/ void Clear();
    }

    class RectTransform : UnityEngine.Transform
    {
        static /*0x0*/ UnityEngine.RectTransform.ReapplyDrivenProperties reapplyDrivenProperties;

        static /*0x3df1eac*/ void add_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value);
        static /*0x3df1f64*/ void remove_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value);
        static /*0x3df36b0*/ void SendReapplyDrivenProperties(UnityEngine.RectTransform driven);
        static /*0x3df20b0*/ void get_rect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x3df217c*/ void get_anchorMin_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3df2244*/ void set_anchorMin_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3df2310*/ void get_anchorMax_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3df23d8*/ void set_anchorMax_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3df24a4*/ void get_anchoredPosition_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3df256c*/ void set_anchoredPosition_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3df2638*/ void get_sizeDelta_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3df2700*/ void set_sizeDelta_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3df27cc*/ void get_pivot_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x3df2894*/ void set_pivot_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x3df2ddc*/ nint get_drivenByObject_Injected(nint _unity_self);
        static /*0x3df2ecc*/ void set_drivenByObject_Injected(nint _unity_self, nint value);
        static /*0x3df2f88*/ UnityEngine.DrivenTransformProperties get_drivenProperties_Injected(nint _unity_self);
        static /*0x3df3044*/ void set_drivenProperties_Injected(nint _unity_self, UnityEngine.DrivenTransformProperties value);
        static /*0x3df3100*/ void ForceUpdateRectTransforms_Injected(nint _unity_self);
        /*0x3df3880*/ RectTransform();
        /*0x3df201c*/ UnityEngine.Rect get_rect();
        /*0x3df20f4*/ UnityEngine.Vector2 get_anchorMin();
        /*0x3df21c0*/ void set_anchorMin(UnityEngine.Vector2 value);
        /*0x3df2288*/ UnityEngine.Vector2 get_anchorMax();
        /*0x3df2354*/ void set_anchorMax(UnityEngine.Vector2 value);
        /*0x3df241c*/ UnityEngine.Vector2 get_anchoredPosition();
        /*0x3df24e8*/ void set_anchoredPosition(UnityEngine.Vector2 value);
        /*0x3df25b0*/ UnityEngine.Vector2 get_sizeDelta();
        /*0x3df267c*/ void set_sizeDelta(UnityEngine.Vector2 value);
        /*0x3df2744*/ UnityEngine.Vector2 get_pivot();
        /*0x3df2810*/ void set_pivot(UnityEngine.Vector2 value);
        /*0x3df28d8*/ UnityEngine.Vector3 get_anchoredPosition3D();
        /*0x3df29a4*/ void set_anchoredPosition3D(UnityEngine.Vector3 value);
        /*0x3df2a64*/ UnityEngine.Vector2 get_offsetMin();
        /*0x3df2ab8*/ void set_offsetMin(UnityEngine.Vector2 value);
        /*0x3df2bac*/ UnityEngine.Vector2 get_offsetMax();
        /*0x3df2c4c*/ void set_offsetMax(UnityEngine.Vector2 value);
        /*0x3df2d48*/ UnityEngine.Object get_drivenByObject();
        /*0x3df2e18*/ void set_drivenByObject(UnityEngine.Object value);
        /*0x3df2f10*/ UnityEngine.DrivenTransformProperties get_drivenProperties();
        /*0x3df2fc4*/ void set_drivenProperties(UnityEngine.DrivenTransformProperties value);
        /*0x3df3088*/ void ForceUpdateRectTransforms();
        /*0x3df313c*/ void GetLocalCorners(UnityEngine.Vector3[] fourCornersArray);
        /*0x3df321c*/ void GetWorldCorners(UnityEngine.Vector3[] fourCornersArray);
        /*0x3df33cc*/ void SetInsetAndSizeFromParentEdge(UnityEngine.RectTransform.Edge edge, float inset, float size);
        /*0x3df34d0*/ void SetSizeWithCurrentAnchors(UnityEngine.RectTransform.Axis axis, float size);
        /*0x3df371c*/ UnityEngine.Rect GetRectInParentSpace();
        /*0x3df35cc*/ UnityEngine.Vector2 GetParentSize();

        enum Edge
        {
            Left = 0,
            Right = 1,
            Top = 2,
            Bottom = 3,
        }

        enum Axis
        {
            Horizontal = 0,
            Vertical = 1,
        }

        class ReapplyDrivenProperties : System.MulticastDelegate
        {
            /*0x3df3888*/ ReapplyDrivenProperties(object object, nint method);
            /*0x3df3938*/ void Invoke(UnityEngine.RectTransform driven);
        }
    }

    enum RotationOrder
    {
        OrderXYZ = 0,
        OrderXZY = 1,
        OrderYZX = 2,
        OrderYXZ = 3,
        OrderZXY = 4,
        OrderZYX = 5,
    }

    class Transform : UnityEngine.Component, System.Collections.IEnumerable
    {
        static /*0x3df39e4*/ void get_position_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3df3ab8*/ void set_position_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x3df3afc*/ void get_localPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3df3b40*/ void set_localPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x3df3c24*/ void GetLocalEulerAngles_Injected(nint _unity_self, UnityEngine.RotationOrder order, ref UnityEngine.Vector3 ret);
        static /*0x3df3d10*/ void SetLocalEulerAngles_Injected(nint _unity_self, ref UnityEngine.Vector3 euler, UnityEngine.RotationOrder order);
        static /*0x3df3df4*/ void SetLocalEulerHint_Injected(nint _unity_self, ref UnityEngine.Vector3 euler);
        static /*0x3df43d8*/ void get_rotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x3df441c*/ void set_rotation_Injected(nint _unity_self, ref UnityEngine.Quaternion value);
        static /*0x3df4460*/ void get_localRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x3df44a4*/ void set_localRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion value);
        static /*0x3df45e8*/ int GetRotationOrderInternal_Injected(nint _unity_self);
        static /*0x3df4624*/ void SetRotationOrderInternal_Injected(nint _unity_self, UnityEngine.RotationOrder rotationOrder);
        static /*0x3df4700*/ void get_localScale_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3df47d4*/ void set_localScale_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x3df496c*/ nint GetParent_Injected(nint _unity_self);
        static /*0x3df4a64*/ void SetParent_Injected(nint _unity_self, nint parent, bool worldPositionStays);
        static /*0x3df4b60*/ void get_worldToLocalMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x3df4ba4*/ void get_localToWorldMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x3df4c84*/ void SetPositionAndRotation_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
        static /*0x3df4d74*/ void SetLocalPositionAndRotation_Injected(nint _unity_self, ref UnityEngine.Vector3 localPosition, ref UnityEngine.Quaternion localRotation);
        static /*0x3df4e58*/ void GetPositionAndRotation_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
        static /*0x3df4f3c*/ void GetLocalPositionAndRotation_Injected(nint _unity_self, ref UnityEngine.Vector3 localPosition, ref UnityEngine.Quaternion localRotation);
        static /*0x3df54f0*/ void RotateAroundInternal_Injected(nint _unity_self, ref UnityEngine.Vector3 axis, float angle);
        static /*0x3df5964*/ void Internal_LookAt_Injected(nint _unity_self, ref UnityEngine.Vector3 worldPosition, ref UnityEngine.Vector3 worldUp);
        static /*0x3df59b8*/ void TransformDirection_Injected(nint _unity_self, ref UnityEngine.Vector3 direction, ref UnityEngine.Vector3 ret);
        static /*0x3df5b5c*/ void TransformDirectionsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper directions, ref UnityEngine.Bindings.ManagedSpanWrapper transformedDirections);
        static /*0x3df5d98*/ void InverseTransformDirection_Injected(nint _unity_self, ref UnityEngine.Vector3 direction, ref UnityEngine.Vector3 ret);
        static /*0x3df5f3c*/ void InverseTransformDirectionsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper directions, ref UnityEngine.Bindings.ManagedSpanWrapper transformedDirections);
        static /*0x3df6178*/ void TransformVector_Injected(nint _unity_self, ref UnityEngine.Vector3 vector, ref UnityEngine.Vector3 ret);
        static /*0x3df631c*/ void TransformVectorsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper vectors, ref UnityEngine.Bindings.ManagedSpanWrapper transformedVectors);
        static /*0x3df6558*/ void InverseTransformVector_Injected(nint _unity_self, ref UnityEngine.Vector3 vector, ref UnityEngine.Vector3 ret);
        static /*0x3df66fc*/ void InverseTransformVectorsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper vectors, ref UnityEngine.Bindings.ManagedSpanWrapper transformedVectors);
        static /*0x3df6938*/ void TransformPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x3df6adc*/ void TransformPointsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper positions, ref UnityEngine.Bindings.ManagedSpanWrapper transformedPositions);
        static /*0x3df6d18*/ void InverseTransformPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x3df6ebc*/ void InverseTransformPointsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper positions, ref UnityEngine.Bindings.ManagedSpanWrapper transformedPositions);
        static /*0x3df70ec*/ nint GetRoot_Injected(nint _unity_self);
        static /*0x3df71a0*/ int get_childCount_Injected(nint _unity_self);
        static /*0x3df7254*/ void DetachChildren_Injected(nint _unity_self);
        static /*0x3df7308*/ void SetAsFirstSibling_Injected(nint _unity_self);
        static /*0x3df73bc*/ void SetAsLastSibling_Injected(nint _unity_self);
        static /*0x3df7478*/ void SetSiblingIndex_Injected(nint _unity_self, int index);
        static /*0x3df7578*/ void MoveAfterSibling_Injected(nint _unity_self, nint transform, bool notifyEditorAndMarkDirty);
        static /*0x3df7644*/ int GetSiblingIndex_Injected(nint _unity_self);
        static /*0x3df78a8*/ nint FindRelativeTransformWithPath_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper path, bool isActiveOnly);
        static /*0x3df79cc*/ void SendTransformChangedScale_Injected(nint _unity_self);
        static /*0x3df7aa0*/ void get_lossyScale_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x3df7bbc*/ bool IsChildOf_Injected(nint _unity_self, nint parent);
        static /*0x3df7c78*/ bool get_hasChanged_Injected(nint _unity_self);
        static /*0x3df7d34*/ void set_hasChanged_Injected(nint _unity_self, bool value);
        static /*0x3df7ec4*/ void RotateAround_Injected(nint _unity_self, ref UnityEngine.Vector3 axis, float angle);
        static /*0x3df7fb8*/ void RotateAroundLocal_Injected(nint _unity_self, ref UnityEngine.Vector3 axis, float angle);
        static /*0x3df80b0*/ nint GetChild_Injected(nint _unity_self, int index);
        static /*0x3df816c*/ int GetChildCount_Injected(nint _unity_self);
        static /*0x3df82a8*/ int internal_getHierarchyCapacity_Injected(nint _unity_self);
        static /*0x3df82e4*/ void internal_setHierarchyCapacity_Injected(nint _unity_self, int value);
        static /*0x3df83a4*/ int internal_getHierarchyCount_Injected(nint _unity_self);
        static /*0x3df8458*/ bool IsNonUniformScaleTransform_Injected(nint _unity_self);
        static /*0x3df8594*/ void SetConstrainProportionsScale_Injected(nint _unity_self, bool isLinked);
        static /*0x3df85d8*/ bool IsConstrainProportionsScale_Injected(nint _unity_self);
        /*0x3df3884*/ Transform();
        /*0x3df394c*/ UnityEngine.Vector3 get_position();
        /*0x3df3a28*/ void set_position(UnityEngine.Vector3 value);
        /*0x3df290c*/ UnityEngine.Vector3 get_localPosition();
        /*0x3df29d4*/ void set_localPosition(UnityEngine.Vector3 value);
        /*0x3df3b84*/ UnityEngine.Vector3 GetLocalEulerAngles(UnityEngine.RotationOrder order);
        /*0x3df3c78*/ void SetLocalEulerAngles(UnityEngine.Vector3 euler, UnityEngine.RotationOrder order);
        /*0x3df3d64*/ void SetLocalEulerHint(UnityEngine.Vector3 euler);
        /*0x3df3e38*/ UnityEngine.Vector3 get_eulerAngles();
        /*0x3df3efc*/ void set_eulerAngles(UnityEngine.Vector3 value);
        /*0x3df3fbc*/ UnityEngine.Vector3 get_localEulerAngles();
        /*0x3df4080*/ void set_localEulerAngles(UnityEngine.Vector3 value);
        /*0x3df4140*/ UnityEngine.Vector3 get_right();
        /*0x3df41bc*/ void set_right(UnityEngine.Vector3 value);
        /*0x3df4240*/ UnityEngine.Vector3 get_up();
        /*0x3df42bc*/ void set_up(UnityEngine.Vector3 value);
        /*0x3df4340*/ UnityEngine.Vector3 get_forward();
        /*0x3df43bc*/ void set_forward(UnityEngine.Vector3 value);
        /*0x3df3e68*/ UnityEngine.Quaternion get_rotation();
        /*0x3df3f2c*/ void set_rotation(UnityEngine.Quaternion value);
        /*0x3df3fec*/ UnityEngine.Quaternion get_localRotation();
        /*0x3df40b0*/ void set_localRotation(UnityEngine.Quaternion value);
        /*0x3df44e8*/ UnityEngine.RotationOrder get_rotationOrder();
        /*0x3df4564*/ void set_rotationOrder(UnityEngine.RotationOrder value);
        /*0x3df44ec*/ int GetRotationOrderInternal();
        /*0x3df4568*/ void SetRotationOrderInternal(UnityEngine.RotationOrder rotationOrder);
        /*0x3df4668*/ UnityEngine.Vector3 get_localScale();
        /*0x3df4744*/ void set_localScale(UnityEngine.Vector3 value);
        /*0x3df387c*/ UnityEngine.Transform get_parent();
        /*0x3df481c*/ void set_parent(UnityEngine.Transform value);
        /*0x3df4818*/ UnityEngine.Transform get_parentInternal();
        /*0x3df48c8*/ void set_parentInternal(UnityEngine.Transform value);
        /*0x3df48d0*/ UnityEngine.Transform GetParent();
        /*0x3df4964*/ void SetParent(UnityEngine.Transform p);
        /*0x3df49a8*/ void SetParent(UnityEngine.Transform parent, bool worldPositionStays);
        /*0x3df4ab8*/ UnityEngine.Matrix4x4 get_worldToLocalMatrix();
        /*0x3df3324*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
        /*0x3df4be8*/ void SetPositionAndRotation(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        /*0x3df4cd8*/ void SetLocalPositionAndRotation(UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation);
        /*0x3df4dc8*/ void GetPositionAndRotation(ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
        /*0x3df4eac*/ void GetLocalPositionAndRotation(ref UnityEngine.Vector3 localPosition, ref UnityEngine.Quaternion localRotation);
        /*0x3df4f90*/ void Translate(UnityEngine.Vector3 translation, UnityEngine.Space relativeTo);
        /*0x3df50bc*/ void Translate(UnityEngine.Vector3 translation);
        /*0x3df50c4*/ void Translate(float x, float y, float z, UnityEngine.Space relativeTo);
        /*0x3df50c8*/ void Translate(float x, float y, float z);
        /*0x3df50d0*/ void Translate(UnityEngine.Vector3 translation, UnityEngine.Transform relativeTo);
        /*0x3df51b0*/ void Translate(float x, float y, float z, UnityEngine.Transform relativeTo);
        /*0x3df51b4*/ void Rotate(UnityEngine.Vector3 eulers, UnityEngine.Space relativeTo);
        /*0x3df543c*/ void Rotate(UnityEngine.Vector3 eulers);
        /*0x3df5444*/ void Rotate(float xAngle, float yAngle, float zAngle, UnityEngine.Space relativeTo);
        /*0x3df5448*/ void Rotate(float xAngle, float yAngle, float zAngle);
        /*0x3df5450*/ void RotateAroundInternal(UnityEngine.Vector3 axis, float angle);
        /*0x3df5544*/ void Rotate(UnityEngine.Vector3 axis, float angle, UnityEngine.Space relativeTo);
        /*0x3df55cc*/ void Rotate(UnityEngine.Vector3 axis, float angle);
        /*0x3df55d4*/ void RotateAround(UnityEngine.Vector3 point, UnityEngine.Vector3 axis, float angle);
        /*0x3df5698*/ void LookAt(UnityEngine.Transform target, UnityEngine.Vector3 worldUp);
        /*0x3df5758*/ void LookAt(UnityEngine.Transform target);
        /*0x3df5754*/ void LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp);
        /*0x3df58e8*/ void LookAt(UnityEngine.Vector3 worldPosition);
        /*0x3df584c*/ void Internal_LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp);
        /*0x3df5018*/ UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3 direction);
        /*0x3df5a0c*/ UnityEngine.Vector3 TransformDirection(float x, float y, float z);
        /*0x3df5a10*/ void TransformDirectionsInternal(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections);
        /*0x3df5bb0*/ void TransformDirections(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections);
        /*0x3df5c78*/ void TransformDirections(System.Span<UnityEngine.Vector3> directions);
        /*0x3df5cf4*/ UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3 direction);
        /*0x3df5dec*/ UnityEngine.Vector3 InverseTransformDirection(float x, float y, float z);
        /*0x3df5df0*/ void InverseTransformDirectionsInternal(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections);
        /*0x3df5f90*/ void InverseTransformDirections(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections);
        /*0x3df6058*/ void InverseTransformDirections(System.Span<UnityEngine.Vector3> directions);
        /*0x3df60d4*/ UnityEngine.Vector3 TransformVector(UnityEngine.Vector3 vector);
        /*0x3df61cc*/ UnityEngine.Vector3 TransformVector(float x, float y, float z);
        /*0x3df61d0*/ void TransformVectorsInternal(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors);
        /*0x3df6370*/ void TransformVectors(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors);
        /*0x3df6438*/ void TransformVectors(System.Span<UnityEngine.Vector3> vectors);
        /*0x3df64b4*/ UnityEngine.Vector3 InverseTransformVector(UnityEngine.Vector3 vector);
        /*0x3df65ac*/ UnityEngine.Vector3 InverseTransformVector(float x, float y, float z);
        /*0x3df65b0*/ void InverseTransformVectorsInternal(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors);
        /*0x3df6750*/ void InverseTransformVectors(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors);
        /*0x3df6818*/ void InverseTransformVectors(System.Span<UnityEngine.Vector3> vectors);
        /*0x3df6894*/ UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 position);
        /*0x3df698c*/ UnityEngine.Vector3 TransformPoint(float x, float y, float z);
        /*0x3df6990*/ void TransformPointsInternal(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions);
        /*0x3df6b30*/ void TransformPoints(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions);
        /*0x3df6bf8*/ void TransformPoints(System.Span<UnityEngine.Vector3> positions);
        /*0x3df6c74*/ UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 position);
        /*0x3df6d6c*/ UnityEngine.Vector3 InverseTransformPoint(float x, float y, float z);
        /*0x3df6d70*/ void InverseTransformPointsInternal(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions);
        /*0x3df6f10*/ void InverseTransformPoints(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions);
        /*0x3df6fd8*/ void InverseTransformPoints(System.Span<UnityEngine.Vector3> positions);
        /*0x3df7054*/ UnityEngine.Transform get_root();
        /*0x3df7058*/ UnityEngine.Transform GetRoot();
        /*0x3df7128*/ int get_childCount();
        /*0x3df71dc*/ void DetachChildren();
        /*0x3df7290*/ void SetAsFirstSibling();
        /*0x3df7344*/ void SetAsLastSibling();
        /*0x3df73f8*/ void SetSiblingIndex(int index);
        /*0x3df74bc*/ void MoveAfterSibling(UnityEngine.Transform transform, bool notifyEditorAndMarkDirty);
        /*0x3df75cc*/ int GetSiblingIndex();
        /*0x3df7680*/ UnityEngine.Transform FindRelativeTransformWithPath(string path, bool isActiveOnly);
        /*0x3df78fc*/ UnityEngine.Transform Find(string n);
        /*0x3df7954*/ void SendTransformChangedScale();
        /*0x3df7a08*/ UnityEngine.Vector3 get_lossyScale();
        /*0x3df7ae4*/ bool IsChildOf(UnityEngine.Transform parent);
        /*0x3df7c00*/ bool get_hasChanged();
        /*0x3df7cb4*/ void set_hasChanged(bool value);
        /*0x3df7d78*/ UnityEngine.Transform FindChild(string n);
        /*0x3df7d7c*/ System.Collections.IEnumerator GetEnumerator();
        /*0x3df7e24*/ void RotateAround(UnityEngine.Vector3 axis, float angle);
        /*0x3df7f18*/ void RotateAroundLocal(UnityEngine.Vector3 axis, float angle);
        /*0x3df800c*/ UnityEngine.Transform GetChild(int index);
        /*0x3df80f4*/ int GetChildCount();
        /*0x3df81a8*/ int get_hierarchyCapacity();
        /*0x3df8224*/ void set_hierarchyCapacity(int value);
        /*0x3df81ac*/ int internal_getHierarchyCapacity();
        /*0x3df8228*/ void internal_setHierarchyCapacity(int value);
        /*0x3df8328*/ int get_hierarchyCount();
        /*0x3df832c*/ int internal_getHierarchyCount();
        /*0x3df83e0*/ bool IsNonUniformScaleTransform();
        /*0x3df8494*/ bool get_constrainProportionsScale();
        /*0x3df8510*/ void set_constrainProportionsScale(bool value);
        /*0x3df8514*/ void SetConstrainProportionsScale(bool isLinked);
        /*0x3df8498*/ bool IsConstrainProportionsScale();

        class Enumerator : System.Collections.IEnumerator
        {
            /*0x10*/ UnityEngine.Transform outer;
            /*0x18*/ int currentIndex;

            /*0x3df7dec*/ Enumerator(UnityEngine.Transform outer);
            /*0x3df8614*/ object get_Current();
            /*0x3df8630*/ bool MoveNext();
            /*0x3df8664*/ void Reset();
        }
    }

    namespace _Scripting
    {
        namespace APIUpdating
        {
            class APIUpdaterRuntimeHelpers
            {
                static /*0x3df8670*/ bool GetMovedFromAttributeDataForType(System.Type sourceType, ref string assembly, ref string nsp, ref string klass);
                static /*0x3df87e0*/ bool GetObsoleteTypeRedirection(System.Type sourceType, ref string assemblyName, ref string nsp, ref string className);
            }
        }
    }

    namespace Profiling
    {
        class Profiler
        {
            static /*0x3df8d44*/ long GetRuntimeMemorySizeLong(UnityEngine.Object o);
            static /*0x3df8ea4*/ long GetMonoUsedSizeLong();
            static /*0x3df8e68*/ long GetRuntimeMemorySizeLong_Injected(nint o);
        }

        class Recorder
        {
            static Unity.Profiling.ProfilerRecorderOptions s_RecorderDefaultOptions = 153;
            static /*0x0*/ UnityEngine.Profiling.Recorder s_InvalidRecorder;
            /*0x10*/ Unity.Profiling.ProfilerRecorder m_RecorderCPU;
            /*0x18*/ Unity.Profiling.ProfilerRecorder m_RecorderGPU;

            static /*0x3df91c4*/ Recorder();
            /*0x3df8ecc*/ Recorder();
            /*0x3df8ed4*/ Recorder(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle);
            /*0x3df8f8c*/ void Finalize();
            /*0x3df902c*/ bool get_enabled();
            /*0x3df9038*/ void set_enabled(bool value);
            /*0x3df90a4*/ long get_elapsedNanoseconds();
            /*0x3df90d8*/ long get_gpuElapsedNanoseconds();
            /*0x3df910c*/ int get_sampleBlockCount();
            /*0x3df9168*/ int get_gpuSampleBlockCount();
            /*0x3df903c*/ void SetEnabled(bool state);
        }

        class Sampler
        {
            static /*0x0*/ UnityEngine.Profiling.Sampler s_InvalidSampler;
            /*0x10*/ nint m_Ptr;

            static /*0x3df92f0*/ Sampler();
            /*0x3df922c*/ Sampler();
            /*0x3df9234*/ Sampler(nint ptr);
            /*0x3df925c*/ bool get_isValid();
            /*0x3df926c*/ UnityEngine.Profiling.Recorder GetRecorder();
        }

        class CustomSampler : UnityEngine.Profiling.Sampler
        {
            static /*0x0*/ UnityEngine.Profiling.CustomSampler s_InvalidCustomSampler;

            static /*0x3df94c8*/ CustomSampler();
            static /*0x3df941c*/ UnityEngine.Profiling.CustomSampler Create(string name, bool collectGpuData);
            /*0x3df9358*/ CustomSampler();
            /*0x3df93b0*/ CustomSampler(nint ptr);

            class BindingsMarshaller
            {
                static /*0x3df952c*/ nint ConvertToNative(UnityEngine.Profiling.CustomSampler customSampler);
            }
        }
    }

    namespace Jobs
    {
        interface IJobParallelForTransform
        {
            /*0x1ffc854*/ void Execute(int index, UnityEngine.Jobs.TransformAccess transform);
        }

        class IJobParallelForTransformExtensions
        {
            static /*0x1f33998*/ void EarlyJobInit<T>();
            static nint GetReflectionData<T>();
            static /*0x1ffc854*/ Unity.Jobs.JobHandle Schedule<T>(T jobData, UnityEngine.Jobs.TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn);

            struct TransformParallelForLoopStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x1f33998*/ TransformParallelForLoopStruct();
                static /*0x1f33998*/ void Initialize();
                static /*0x1f368ec*/ void Execute(ref T jobData, nint jobData2, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

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

            static /*0x3df959c*/ void GetPosition(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Vector3 p);
            static /*0x3df9638*/ void GetRotation(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Quaternion r);
            static /*0x3df96d8*/ void GetLocalScale(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Vector3 r);
            static /*0x3df9788*/ void GetLocalToWorldMatrix(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Matrix4x4 m);
            static /*0x3df9838*/ void GetWorldToLocalMatrix(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Matrix4x4 m);
            /*0x3df9540*/ UnityEngine.Vector3 get_position();
            /*0x3df95e0*/ UnityEngine.Quaternion get_rotation();
            /*0x3df967c*/ UnityEngine.Vector3 get_localScale();
            /*0x3df971c*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
            /*0x3df97cc*/ UnityEngine.Matrix4x4 get_worldToLocalMatrix();
        }

        struct TransformAccessArray : System.IDisposable
        {
            /*0x10*/ nint m_TransformArray;

            static /*0x3df9890*/ void Allocate(int capacity, int desiredJobCount, ref UnityEngine.Jobs.TransformAccessArray array);
            static /*0x3df98f4*/ nint Create(int capacity, int desiredJobCount);
            static /*0x3df99a0*/ void DestroyTransformAccessArray(nint transformArray);
            static /*0x3df9d40*/ void SetTransforms(nint transformArrayIntPtr, UnityEngine.Transform[] transforms);
            static /*0x3df9be8*/ void Add(nint transformArrayIntPtr, UnityEngine.Transform transform);
            static /*0x3df9cb8*/ void RemoveAtSwapBack(nint transformArrayIntPtr, int index);
            static /*0x3df9dc8*/ nint GetSortedTransformAccess(nint transformArrayIntPtr);
            static /*0x3df9e04*/ nint GetSortedToUserIndex(nint transformArrayIntPtr);
            static /*0x3df9ba4*/ int GetLength(nint transformArrayIntPtr);
            static /*0x3df9aa4*/ int GetCapacity(nint transformArrayIntPtr);
            static /*0x3df9b24*/ void SetCapacity(nint transformArrayIntPtr, int capacity);
            static /*0x3df99ec*/ UnityEngine.Transform GetTransform(nint transformArrayIntPtr, int index);
            static /*0x3df9d84*/ void Add_Injected(nint transformArrayIntPtr, nint transform);
            static /*0x3df9e40*/ nint GetTransform_Injected(nint transformArrayIntPtr, int index);
            /*0x3df987c*/ TransformAccessArray(int capacity, int desiredJobCount);
            /*0x3df9938*/ bool get_isCreated();
            /*0x3df9948*/ void Dispose();
            /*0x3df99dc*/ nint GetTransformAccessArrayForSchedule();
            /*0x3df99e4*/ UnityEngine.Transform get_Item(int index);
            /*0x3df9a68*/ int get_capacity();
            /*0x3df9ae0*/ void set_capacity(int value);
            /*0x3df9b68*/ int get_length();
            /*0x3df9be0*/ void Add(UnityEngine.Transform transform);
            /*0x3df9c74*/ void RemoveAtSwapBack(int index);
            /*0x3df9cfc*/ void SetTransforms(UnityEngine.Transform[] transforms);
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
            static /*0x3df9e84*/ string TidyAssemblyTypeName(string assemblyTypeName);
        }

        class ArgumentCache : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Object m_ObjectArgument;
            /*0x18*/ string m_ObjectArgumentAssemblyTypeName;
            /*0x20*/ int m_IntArgument;
            /*0x24*/ float m_FloatArgument;
            /*0x28*/ string m_StringArgument;
            /*0x30*/ bool m_BoolArgument;

            /*0x3dfa128*/ ArgumentCache();
            /*0x3dfa0b0*/ UnityEngine.Object get_unityObjectArgument();
            /*0x3dfa0b8*/ string get_unityObjectArgumentAssemblyTypeName();
            /*0x3dfa0c0*/ int get_intArgument();
            /*0x3dfa0c8*/ float get_floatArgument();
            /*0x3dfa0d0*/ string get_stringArgument();
            /*0x3dfa0d8*/ bool get_boolArgument();
            /*0x3dfa0e0*/ void OnBeforeSerialize();
            /*0x3dfa104*/ void OnAfterDeserialize();
        }

        class BaseInvokableCall
        {
            static /*0x1f350f8*/ void ThrowOnInvalidArg<T>(object arg);
            static /*0x3dfa22c*/ bool AllowInvoke(System.Delegate delegate);
            /*0x3dfa130*/ BaseInvokableCall();
            /*0x3dfa138*/ BaseInvokableCall(object target, System.Reflection.MethodInfo function);
            /*0x1f30ebc*/ void Invoke(object[] args);
            /*0x1f2ff00*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall : UnityEngine.Events.BaseInvokableCall
        {
            /*0x10*/ UnityEngine.Events.UnityAction Delegate;

            /*0x3dfa408*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x3dfa4dc*/ InvokableCall(UnityEngine.Events.UnityAction action);
            /*0x3dfa2d0*/ void add_Delegate(UnityEngine.Events.UnityAction value);
            /*0x3dfa36c*/ void remove_Delegate(UnityEngine.Events.UnityAction value);
            /*0x3dfa508*/ void Invoke(object[] args);
            /*0x3dfa544*/ void Invoke();
            /*0x3dfa580*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1> Delegate;

            /*0x1f30ff0*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x1f30ebc*/ InvokableCall(UnityEngine.Events.UnityAction<T1> action);
            /*0x1f30ebc*/ void add_Delegate(UnityEngine.Events.UnityAction<T1> value);
            /*0x1f30ebc*/ void remove_Delegate(UnityEngine.Events.UnityAction<T1> value);
            /*0x1f30ebc*/ void Invoke(object[] args);
            /*0x1ffc854*/ void Invoke(T1 args0);
            /*0x1f2ff00*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2> Delegate;

            /*0x1f30ff0*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x1f30ebc*/ void Invoke(object[] args);
            /*0x1f2ff00*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2, T3> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2, T3> Delegate;

            /*0x1f30ff0*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x1f30ebc*/ InvokableCall(UnityEngine.Events.UnityAction<T1, T2, T3> action);
            /*0x1f30ebc*/ void add_Delegate(UnityEngine.Events.UnityAction<T1, T2, T3> value);
            /*0x1f30ebc*/ void remove_Delegate(UnityEngine.Events.UnityAction<T1, T2, T3> value);
            /*0x1f30ebc*/ void Invoke(object[] args);
            /*0x1ffc854*/ void Invoke(T1 args0, T2 args1, T3 args2);
            /*0x1f2ff00*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2, T3, T4> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2, T3, T4> Delegate;

            /*0x1f30ff0*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x1f30ebc*/ void Invoke(object[] args);
            /*0x1f2ff00*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class CachedInvokableCall<T> : UnityEngine.Events.InvokableCall<T>
        {
            /*0x0*/ T m_Arg1;

            /*0x1ffc854*/ CachedInvokableCall(UnityEngine.Object target, System.Reflection.MethodInfo theFunction, T argument);
            /*0x1f30ebc*/ void Invoke(object[] args);
            /*0x1ffc854*/ void Invoke(T arg0);
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

            static /*0x3dfaba8*/ UnityEngine.Events.BaseInvokableCall GetObjectCall(UnityEngine.Object target, System.Reflection.MethodInfo method, UnityEngine.Events.ArgumentCache arguments);
            /*0x3dfb068*/ PersistentCall();
            /*0x3dfa5cc*/ UnityEngine.Object get_target();
            /*0x3dfa5d4*/ string get_targetAssemblyTypeName();
            /*0x3dfa690*/ string get_methodName();
            /*0x3dfa698*/ UnityEngine.Events.PersistentListenerMode get_mode();
            /*0x3dfa6a0*/ UnityEngine.Events.ArgumentCache get_arguments();
            /*0x3dfa6a8*/ bool IsValid();
            /*0x3dfa6e4*/ UnityEngine.Events.BaseInvokableCall GetRuntimeCall(UnityEngine.Events.UnityEventBase theEvent);
            /*0x3dfb020*/ void OnBeforeSerialize();
            /*0x3dfb044*/ void OnAfterDeserialize();
        }

        class PersistentCallGroup
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Events.PersistentCall> m_Calls;

            /*0x3dfb0e0*/ PersistentCallGroup();
            /*0x3dfb168*/ void Initialize(UnityEngine.Events.InvokableCallList invokableList, UnityEngine.Events.UnityEventBase unityEventBase);
        }

        class InvokableCallList
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_PersistentCalls;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_RuntimeCalls;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_ExecutingCalls;
            /*0x28*/ bool m_NeedsUpdate;

            /*0x3dfb9a8*/ InvokableCallList();
            /*0x3dfb3d0*/ int get_Count();
            /*0x3dfb36c*/ void AddPersistentInvokableCall(UnityEngine.Events.BaseInvokableCall call);
            /*0x3dfb428*/ void AddListener(UnityEngine.Events.BaseInvokableCall call);
            /*0x3dfb48c*/ void RemoveListener(object targetObj, System.Reflection.MethodInfo method);
            /*0x3dfb6d4*/ void Clear();
            /*0x3dfb7cc*/ void ClearPersistent();
            /*0x3dfb8c4*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke();
        }

        class UnityEventBase : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Events.InvokableCallList m_Calls;
            /*0x18*/ UnityEngine.Events.PersistentCallGroup m_PersistentCalls;
            /*0x20*/ bool m_CallsDirty;

            static /*0x3dfbe10*/ System.Reflection.MethodInfo GetValidMethodInfo(System.Type objectType, string functionName, System.Type[] argumentTypes);
            /*0x3dfba80*/ UnityEventBase();
            /*0x3dfbb2c*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x3dfbb58*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x1f30394*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x1f30394*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x3dfa9e4*/ System.Reflection.MethodInfo FindMethod(UnityEngine.Events.PersistentCall call);
            /*0x3dfbb5c*/ System.Reflection.MethodInfo FindMethod(string name, System.Type listenerType, UnityEngine.Events.PersistentListenerMode mode, System.Type argumentType);
            /*0x3dfbfc0*/ int GetCallsCount();
            /*0x3dfbb30*/ void DirtyPersistentCalls();
            /*0x3dfbfd4*/ void RebuildPersistentCallsIfNeeded();
            /*0x3dfc008*/ void AddCall(UnityEngine.Events.BaseInvokableCall call);
            /*0x3dfc01c*/ void RemoveListener(object targetObj, System.Reflection.MethodInfo method);
            /*0x3dfc030*/ void RemoveAllListeners();
            /*0x3dfc044*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke();
            /*0x3dfc064*/ string ToString();
        }

        class UnityAction : System.MulticastDelegate
        {
            /*0x3dfc0e8*/ UnityAction(object object, nint method);
            /*0x3dfc184*/ void Invoke();
        }

        class UnityEvent : UnityEngine.Events.UnityEventBase
        {
            /*0x28*/ object[] m_InvokeArray;

            static /*0x3dfc1e4*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction action);
            /*0x3dfc198*/ UnityEvent();
            /*0x3dfc1b8*/ void AddListener(UnityEngine.Events.UnityAction call);
            /*0x3dfc248*/ void RemoveListener(UnityEngine.Events.UnityAction call);
            /*0x3dfc28c*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x3dfc2f0*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x3dfc358*/ void Invoke();
        }

        class UnityAction<T0> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x1ffc854*/ void Invoke(T0 arg0);
        }

        class UnityEvent<T0> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            static /*0x1f327cc*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0> action);
            /*0x1f309e4*/ UnityEvent();
            /*0x1f30ebc*/ void AddListener(UnityEngine.Events.UnityAction<T0> call);
            /*0x1f30ebc*/ void RemoveListener(UnityEngine.Events.UnityAction<T0> call);
            /*0x1f30394*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x1f30394*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x1ffc854*/ void Invoke(T0 arg0);
        }

        class UnityAction<T0, T1> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x1ffc854*/ void Invoke(T0 arg0, T1 arg1);
        }

        class UnityEvent<T0, T1> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            /*0x1f309e4*/ UnityEvent();
            /*0x1f30394*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x1f30394*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
        }

        class UnityAction<T0, T1, T2> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x1ffc854*/ void Invoke(T0 arg0, T1 arg1, T2 arg2);
        }

        class UnityEvent<T0, T1, T2> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            static /*0x1f327cc*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0, T1, T2> action);
            /*0x1f309e4*/ UnityEvent();
            /*0x1f30ebc*/ void AddListener(UnityEngine.Events.UnityAction<T0, T1, T2> call);
            /*0x1f30ebc*/ void RemoveListener(UnityEngine.Events.UnityAction<T0, T1, T2> call);
            /*0x1f30394*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x1f30394*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x1ffc854*/ void Invoke(T0 arg0, T1 arg1, T2 arg2);
        }

        class UnityAction<T0, T1, T2, T3> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x1ffc854*/ void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3);
        }

        class UnityEvent<T0, T1, T2, T3> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            /*0x1f309e4*/ UnityEvent();
            /*0x1f30394*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x1f30394*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
        }
    }

    namespace Serialization
    {
        class FormerlySerializedAsAttribute : System.Attribute
        {
            /*0x10*/ string m_oldName;

            /*0x3dfc504*/ FormerlySerializedAsAttribute(string oldName);
        }
    }

    namespace Categorization
    {
        class ElementInfoAttribute : System.Attribute
        {
            /*0x10*/ int <Order>k__BackingField;
            /*0x18*/ string <Name>k__BackingField;

            /*0x3dfc53c*/ ElementInfoAttribute();
            /*0x3dfc534*/ void set_Order(int value);
        }

        class CategoryInfoAttribute : System.Attribute
        {
            /*0x10*/ int <Order>k__BackingField;
            /*0x18*/ string <Name>k__BackingField;

            /*0x3dfc578*/ CategoryInfoAttribute();
            /*0x3dfc568*/ void set_Order(int value);
            /*0x3dfc570*/ void set_Name(string value);
        }
    }

    namespace Bindings
    {
        struct Unmarshal
        {
            static /*0x1ffc854*/ T UnmarshalUnityObject<T>(nint gcHandlePtr);
            static /*0x3dfc5a4*/ System.Runtime.InteropServices.GCHandle FromIntPtrUnsafe(nint gcHandle);
        }

        class ThrowHelper
        {
            static /*0x3df8dd8*/ void ThrowArgumentNullException(object obj, string parameterName);
            static /*0x3dfc5e0*/ void ThrowNullReferenceException(object obj);
        }

        class BindingsAllocator
        {
            static /*0x3dfc664*/ void Free(void* ptr);
            static /*0x3dfc6a0*/ void FreeNativeOwnedMemory(void* ptr);
            static /*0x3dfc6dc*/ void* GetNativeOwnedDataPointer(void* ptr);

            struct NativeOwnedMemory
            {
                /*0x10*/ void* data;
            }
        }

        struct BlittableArrayWrapper
        {
            /*0x10*/ void* data;
            /*0x18*/ int size;
            /*0x1c*/ UnityEngine.Bindings.BlittableArrayWrapper.UpdateFlags updateFlags;

            /*0x3dfc6f0*/ BlittableArrayWrapper(void* data, int size);
            /*0x1f30ebc*/ void Unmarshal<T>(ref T[] array);

            enum UpdateFlags
            {
                NoUpdateNeeded = 0,
                SizeChanged = 1,
                DataIsNativePointer = 2,
                DataIsNativeOwnedMemory = 3,
                DataIsEmpty = 4,
                DataIsNull = 5,
            }
        }

        struct BlittableListWrapper
        {
            /*0x10*/ UnityEngine.Bindings.BlittableArrayWrapper arrayWrapper;
            /*0x20*/ int listSize;

            /*0x3dfc6fc*/ BlittableListWrapper(UnityEngine.Bindings.BlittableArrayWrapper arrayWrapper, int listSize);
            /*0x1f30ebc*/ void Unmarshal<T>(System.Collections.Generic.List<T> list);
        }

        class ExceptionMarshaller
        {
            [ThreadStatic] static System.Exception s_pendingException;

            static /*0x3dfc708*/ void SetPendingException(System.Exception ex);
        }

        struct ManagedSpanWrapper
        {
            /*0x10*/ void* begin;
            /*0x18*/ int length;

            /*0x3dfc760*/ ManagedSpanWrapper(void* begin, int length);
        }

        class StringMarshaller
        {
            static /*0x3dfc76c*/ bool TryMarshalEmptyOrNullString(string s, ref UnityEngine.Bindings.ManagedSpanWrapper managedSpanWrapper);
        }

        struct OutStringMarshaller
        {
            static /*0x3dfc7c4*/ string GetStringAndDispose(UnityEngine.Bindings.ManagedSpanWrapper managedSpan);
        }
    }

    namespace Scripting
    {
        class AlwaysLinkAssemblyAttribute : System.Attribute
        {
            /*0x3dfc84c*/ AlwaysLinkAssemblyAttribute();
        }

        class PreserveAttribute : System.Attribute
        {
            /*0x3dfc854*/ PreserveAttribute();
        }

        class RequiredMemberAttribute : System.Attribute
        {
            /*0x3dfc85c*/ RequiredMemberAttribute();
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

                /*0x3dfc864*/ void Set(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName);
            }

            class MovedFromAttribute : System.Attribute
            {
                /*0x10*/ UnityEngine.Scripting.APIUpdating.MovedFromAttributeData data;

                /*0x3dfc8f4*/ MovedFromAttribute(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName);
                /*0x3dfc940*/ MovedFromAttribute(string sourceNamespace);
            }
        }
    }

    namespace SceneManagement
    {
        struct Scene
        {
            /*0x10*/ int m_Handle;

            static /*0x3dfc978*/ bool IsValidInternal(int sceneHandle);
            static /*0x3dfc9b4*/ string GetNameInternal(int sceneHandle);
            static /*0x3dfcac0*/ string GetGUIDInternal(int sceneHandle);
            static /*0x3dfcbcc*/ bool GetIsLoadedInternal(int sceneHandle);
            static /*0x3dfcc08*/ int GetRootCountInternal(int sceneHandle);
            static /*0x3dfcc44*/ void GetRootGameObjectsInternal(int sceneHandle, object resultRootList);
            static /*0x3dfd0dc*/ bool op_Equality(UnityEngine.SceneManagement.Scene lhs, UnityEngine.SceneManagement.Scene rhs);
            static /*0x3dfca7c*/ void GetNameInternal_Injected(int sceneHandle, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x3dfcb88*/ void GetGUIDInternal_Injected(int sceneHandle, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            /*0x3dfcc88*/ int get_handle();
            /*0x3dfcc90*/ string get_guid();
            /*0x3dfcc98*/ bool IsValid();
            /*0x3dfccd4*/ string get_name();
            /*0x3dfccdc*/ bool get_isLoaded();
            /*0x3dfcd18*/ int get_rootCount();
            /*0x3dfcd54*/ UnityEngine.GameObject[] GetRootGameObjects();
            /*0x3dfce2c*/ void GetRootGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> rootGameObjects);
            /*0x3dfd0e8*/ int GetHashCode();
            /*0x3dfd0f0*/ bool Equals(object other);
        }

        class SceneManagerAPIInternal
        {
            static /*0x3dfd168*/ UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            static /*0x3dfd36c*/ nint LoadSceneAsyncNameIndexInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper sceneName, int sceneBuildIndex, ref UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
        }

        class SceneManagerAPI
        {
            static /*0x0*/ UnityEngine.SceneManagement.SceneManagerAPI s_DefaultAPI;
            static /*0x8*/ UnityEngine.SceneManagement.SceneManagerAPI <overrideAPI>k__BackingField;

            static /*0x3dfd4ec*/ SceneManagerAPI();
            static /*0x3dfd3c8*/ UnityEngine.SceneManagement.SceneManagerAPI get_ActiveAPI();
            static /*0x3dfd470*/ UnityEngine.SceneManagement.SceneManagerAPI get_overrideAPI();
            /*0x3dfd4c8*/ SceneManagerAPI();
            /*0x3dfd4d0*/ UnityEngine.AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            /*0x3dfd4e4*/ UnityEngine.AsyncOperation LoadFirstScene(bool mustLoadAsync);
        }

        class SceneManager
        {
            static /*0x0*/ bool s_AllowLoadScene;
            static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> sceneLoaded;
            static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> sceneUnloaded;
            static /*0x18*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> activeSceneChanged;

            static /*0x3dfe1f8*/ SceneManager();
            static /*0x3dfd554*/ int get_sceneCount();
            static /*0x3dfd57c*/ UnityEngine.SceneManagement.Scene GetActiveScene();
            static /*0x3dfd634*/ UnityEngine.SceneManagement.Scene GetSceneAt(int index);
            static /*0x3dfd704*/ UnityEngine.AsyncOperation UnloadSceneAsyncInternal(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.UnloadSceneOptions options);
            static /*0x3dfd7dc*/ UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            static /*0x3dfd8b8*/ void MoveGameObjectToScene(UnityEngine.GameObject go, UnityEngine.SceneManagement.Scene scene);
            static /*0x3dfd9c0*/ UnityEngine.AsyncOperation LoadFirstScene_Internal(bool async);
            static /*0x3dfda28*/ void add_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> value);
            static /*0x3dfdb1c*/ void remove_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> value);
            static /*0x3dfdc10*/ void add_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value);
            static /*0x3dfdd04*/ void remove_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value);
            static /*0x3dfddf8*/ void LoadScene(string sceneName);
            static /*0x3dfde58*/ UnityEngine.SceneManagement.Scene LoadScene(string sceneName, UnityEngine.SceneManagement.LoadSceneParameters parameters);
            static /*0x3dfdeec*/ UnityEngine.AsyncOperation LoadSceneAsync(string sceneName);
            static /*0x3dfdf44*/ UnityEngine.AsyncOperation LoadSceneAsync(string sceneName, UnityEngine.SceneManagement.LoadSceneParameters parameters);
            static /*0x3dfdfb0*/ UnityEngine.AsyncOperation UnloadSceneAsync(UnityEngine.SceneManagement.Scene scene);
            static /*0x3dfe008*/ void Internal_SceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            static /*0x3dfe0b0*/ void Internal_SceneUnloaded(UnityEngine.SceneManagement.Scene scene);
            static /*0x3dfe150*/ void Internal_ActiveSceneChanged(UnityEngine.SceneManagement.Scene previousActiveScene, UnityEngine.SceneManagement.Scene newActiveScene);
            static /*0x3dfd5f8*/ void GetActiveScene_Injected(ref UnityEngine.SceneManagement.Scene ret);
            static /*0x3dfd6c0*/ void GetSceneAt_Injected(int index, ref UnityEngine.SceneManagement.Scene ret);
            static /*0x3dfd798*/ nint UnloadSceneAsyncInternal_Injected(ref UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.UnloadSceneOptions options);
            static /*0x3dfd97c*/ void MoveGameObjectToScene_Injected(nint go, ref UnityEngine.SceneManagement.Scene scene);
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

            /*0x3dfde50*/ LoadSceneParameters(UnityEngine.SceneManagement.LoadSceneMode mode);
            /*0x3dfe244*/ void set_loadSceneMode(UnityEngine.SceneManagement.LoadSceneMode value);
        }

        enum UnloadSceneOptions
        {
            None = 0,
            UnloadAllEmbeddedSceneObjects = 1,
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

            /*0x3dfe24c*/ string ToString();

            class UpdateFunction : System.MulticastDelegate
            {
                /*0x3dfe268*/ UpdateFunction(object object, nint method);
                /*0x3dfe304*/ void Invoke();
            }
        }

        class PlayerLoop
        {
            static /*0x3dfe318*/ UnityEngine.LowLevel.PlayerLoopSystem GetCurrentPlayerLoop();
            static /*0x3dfe5ec*/ void SetPlayerLoop(UnityEngine.LowLevel.PlayerLoopSystem loop);
            static /*0x3dfe6d8*/ int PlayerLoopSystemToInternal(UnityEngine.LowLevel.PlayerLoopSystem sys, ref System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystemInternal> internalSys);
            static /*0x3dfe3b0*/ UnityEngine.LowLevel.PlayerLoopSystem InternalToPlayerLoopSystem(UnityEngine.LowLevel.PlayerLoopSystemInternal[] internalSys, ref int offset);
            static /*0x3dfe388*/ UnityEngine.LowLevel.PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal();
            static /*0x3dfe870*/ void SetPlayerLoopInternal(UnityEngine.LowLevel.PlayerLoopSystemInternal[] loop);
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

            struct InputForUIUpdate
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

            struct AccessibilityUpdate
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

            struct UIElementsRepaintPanels
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

            struct UIElementsRenderBatchModeOffscreen
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

            static /*0x1f33998*/ CollectionPool();
            static /*0x1ffc854*/ TCollection Get();
            static /*0x1ffc854*/ UnityEngine.Pool.PooledObject<TCollection> Get(ref TCollection value);
            static /*0x1ffc854*/ void Release(TCollection toRelease);

            class <>c<TCollection, TItem>
            {
                static /*0x0*/ UnityEngine.Pool.CollectionPool.<>c<TCollection, TItem> <>9;

                static /*0x1f33998*/ <>c();
                /*0x1f309e4*/ <>c();
                /*0x1ffc854*/ TCollection <.cctor>b__5_0();
                /*0x1ffc854*/ void <.cctor>b__5_1(TCollection l);
            }
        }

        class GenericPool<T>
        {
            static /*0x0*/ UnityEngine.Pool.ObjectPool<T> s_Pool;

            static /*0x1f33998*/ GenericPool();
            static /*0x1ffc854*/ T Get();
            static /*0x1ffc854*/ UnityEngine.Pool.PooledObject<T> Get(ref T value);
            static /*0x1ffc854*/ void Release(T toRelease);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Pool.GenericPool.<>c<T> <>9;

                static /*0x1f33998*/ <>c();
                /*0x1f309e4*/ <>c();
                /*0x1ffc854*/ T <.cctor>b__5_0();
            }
        }

        interface IObjectPool<T>
        {
            /*0x1ffc854*/ void Release(T element);
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
            /*0x0*/ T m_FreshlyReleased;
            /*0x0*/ int <CountAll>k__BackingField;

            /*0x1ffc854*/ ObjectPool(System.Func<T> createFunc, System.Action<T> actionOnGet, System.Action<T> actionOnRelease, System.Action<T> actionOnDestroy, bool collectionCheck, int defaultCapacity, int maxSize);
            /*0x1f2ffc8*/ int get_CountAll();
            /*0x1f30b78*/ void set_CountAll(int value);
            /*0x1f2ffc8*/ int get_CountInactive();
            /*0x1ffc854*/ T Get();
            /*0x1ffc854*/ UnityEngine.Pool.PooledObject<T> Get(ref T v);
            /*0x1ffc854*/ void Release(T element);
            /*0x1f309e4*/ void Clear();
            /*0x1f309e4*/ void Dispose();
        }

        class PoolManager
        {
            static /*0x0*/ System.Collections.Generic.List<System.WeakReference<UnityEngine.Pool.IPool>> s_WeakPoolReferences;

            static /*0x3dfe978*/ PoolManager();
            static /*0x3dfe8ac*/ void Register(UnityEngine.Pool.IPool pool);
        }

        struct PooledObject<T> : System.IDisposable
        {
            /*0x0*/ T m_ToReturn;
            /*0x0*/ UnityEngine.Pool.IObjectPool<T> m_Pool;

            /*0x1ffc854*/ PooledObject(T value, UnityEngine.Pool.IObjectPool<T> pool);
            /*0x1f309e4*/ void System.IDisposable.Dispose();
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

                /*0x3dfea10*/ MessageEventArgs();
            }

            class PlayerConnection : UnityEngine.ScriptableObject
            {
                static /*0x0*/ UnityEngine.IPlayerEditorConnectionNative connectionNative;
                static /*0x8*/ UnityEngine.Networking.PlayerConnection.PlayerConnection s_Instance;
                /*0x18*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents;
                /*0x20*/ System.Collections.Generic.List<int> m_connectedPlayers;
                /*0x28*/ bool m_IsInitilized;

                static /*0x3dfea18*/ UnityEngine.Networking.PlayerConnection.PlayerConnection get_instance();
                static /*0x3dfeab0*/ UnityEngine.Networking.PlayerConnection.PlayerConnection CreateInstance();
                static /*0x3dffc4c*/ void MessageCallbackInternal(nint data, ulong size, ulong guid, string messageId);
                static /*0x3dffee4*/ void ConnectedCallbackInternal(int playerId);
                static /*0x3dfff84*/ void DisconnectedCallback(int playerId);
                /*0x3e00024*/ PlayerConnection();
                /*0x3dfeb4c*/ bool get_isConnected();
                /*0x3dfec60*/ void OnEnable();
                /*0x3dfebe8*/ UnityEngine.IPlayerEditorConnectionNative GetConnectionNativeApi();
                /*0x3dfed20*/ void Register(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);
                /*0x3dff0dc*/ void Unregister(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);
                /*0x3dff3b4*/ void RegisterConnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x3dff5a8*/ void RegisterDisconnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x3dff608*/ void UnregisterConnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x3dff668*/ void UnregisterDisconnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x3dff6c8*/ void Send(System.Guid messageId, byte[] data);
                /*0x3dff820*/ bool TrySend(System.Guid messageId, byte[] data);
                /*0x3dff978*/ bool BlockUntilRecvMsg(System.Guid messageId, int timeout);
                /*0x3dffbb0*/ void DisconnectAll();

                class <>c__DisplayClass12_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x3dfef5c*/ <>c__DisplayClass12_0();
                    /*0x3e001bc*/ bool <Register>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x3dff280*/ <>c__DisplayClass13_0();
                    /*0x3e00230*/ bool <Unregister>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ bool msgReceived;

                    /*0x3dffba8*/ <>c__DisplayClass20_0();
                    /*0x3e00278*/ void <BlockUntilRecvMsg>b__0(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
                }
            }

            class PlayerEditorConnectionEvents
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> m_MessageTypeSubscribers;
                /*0x18*/ System.Collections.Generic.Dictionary<System.Guid, UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> m_SubscriberLookup;
                /*0x20*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent;
                /*0x28*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent;

                /*0x3e000e0*/ PlayerEditorConnectionEvents();
                /*0x3e00284*/ System.Collections.Generic.IReadOnlyList<UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> get_messageTypeSubscribers();
                /*0x3e0028c*/ void BuildLookup();
                /*0x3dffd64*/ void InvokeMessageIdSubscribers(System.Guid messageId, byte[] data, int playerId);
                /*0x3dfef64*/ UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs> AddAndCreate(System.Guid messageId);
                /*0x3dff288*/ void UnregisterManagedCallback(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);

                class MessageEvent : UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs>
                {
                    /*0x3e00690*/ MessageEvent();
                }

                class ConnectionChangeEvent : UnityEngine.Events.UnityEvent<int>
                {
                    /*0x3e006d8*/ ConnectionChangeEvent();
                }

                class MessageTypeSubscribers
                {
                    /*0x10*/ string m_messageTypeId;
                    /*0x18*/ int subscriberCount;
                    /*0x20*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageEvent messageCallback;

                    /*0x3e005ec*/ MessageTypeSubscribers();
                    /*0x3e00204*/ System.Guid get_MessageTypeId();
                    /*0x3e00658*/ void set_MessageTypeId(System.Guid value);
                }
            }
        }
    }

    namespace Internal
    {
        class DefaultValueAttribute : System.Attribute
        {
            /*0x10*/ object DefaultValue;

            /*0x3e00720*/ DefaultValueAttribute(string value);
            /*0x3e00750*/ object get_Value();
            /*0x3e00758*/ bool Equals(object obj);
            /*0x3e007fc*/ int GetHashCode();
        }

        class ExcludeFromDocsAttribute : System.Attribute
        {
            /*0x3e00820*/ ExcludeFromDocsAttribute();
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

            /*0x3e00828*/ bool HasFlags(UnityEngine.Playables.FrameData.Flags flag);
            /*0x3e00838*/ float get_deltaTime();
            /*0x3e00844*/ float get_effectiveParentSpeed();
            /*0x3e0084c*/ float get_effectiveSpeed();
            /*0x3e00854*/ UnityEngine.Playables.FrameData.EvaluationType get_evaluationType();
            /*0x3e00864*/ bool get_timeLooped();
            /*0x3e00870*/ bool get_timeHeld();
            /*0x3e0087c*/ UnityEngine.Playables.PlayableOutput get_output();
            /*0x3e00888*/ UnityEngine.Playables.PlayState get_effectivePlayState();

            enum Flags
            {
                Evaluate = 1,
                SeekOccured = 2,
                Loop = 4,
                Hold = 8,
                EffectivePlayStateDelayed = 16,
                EffectivePlayStatePlaying = 32,
            }

            enum EvaluationType
            {
                Evaluate = 0,
                Playback = 1,
            }
        }

        interface INotification
        {
        }

        interface INotificationReceiver
        {
            /*0x1ffc854*/ void OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, object context);
        }

        interface IPlayable
        {
            /*0x1ffc854*/ UnityEngine.Playables.PlayableHandle GetHandle();
        }

        interface IPlayableBehaviour
        {
            /*0x1ffc854*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x1ffc854*/ void OnGraphStop(UnityEngine.Playables.Playable playable);
            /*0x1ffc854*/ void OnPlayableCreate(UnityEngine.Playables.Playable playable);
            /*0x1ffc854*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x1ffc854*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x1ffc854*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x1ffc854*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x1ffc854*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
        }

        interface IPlayableOutput
        {
            /*0x1ffc854*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
        }

        enum DirectorWrapMode
        {
            Hold = 0,
            Loop = 1,
            None = 2,
        }

        struct Playable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Playables.Playable>
        {
            static /*0x0*/ UnityEngine.Playables.Playable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x3e00c00*/ Playable();
            static /*0x3e008a0*/ UnityEngine.Playables.Playable get_Null();
            static /*0x3e008f8*/ UnityEngine.Playables.Playable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            /*0x3e009f0*/ Playable(UnityEngine.Playables.PlayableHandle handle);
            /*0x3e009f8*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x3e00a04*/ System.Type GetPlayableType();
            /*0x3e00af0*/ bool Equals(UnityEngine.Playables.Playable other);
        }

        interface IPlayableAsset
        {
            UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
            double get_duration();
        }

        class PlayableAsset : UnityEngine.ScriptableObject, UnityEngine.Playables.IPlayableAsset
        {
            static /*0x3e00d78*/ void Internal_CreatePlayable(UnityEngine.Playables.PlayableAsset asset, UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, nint ptr);
            static /*0x3e00e50*/ void Internal_GetPlayableAssetDuration(UnityEngine.Playables.PlayableAsset asset, nint ptrToDouble);
            /*0x3e00e78*/ PlayableAsset();
            UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
            /*0x3e00cc8*/ double get_duration();
            /*0x3e00d20*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
        }

        class PlayableBehaviour : UnityEngine.Playables.IPlayableBehaviour, System.ICloneable
        {
            /*0x3e00e80*/ PlayableBehaviour();
            /*0x3e00e88*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x3e00e8c*/ void OnGraphStop(UnityEngine.Playables.Playable playable);
            /*0x3e00e90*/ void OnPlayableCreate(UnityEngine.Playables.Playable playable);
            /*0x3e00e94*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x3e00e98*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x3e00e9c*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x3e00ea0*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x3e00ea4*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
            /*0x3e00ea8*/ object Clone();
        }

        struct PlayableBinding
        {
            static /*0x0*/ UnityEngine.Playables.PlayableBinding[] None;
            static /*0x8*/ double DefaultDuration;
            /*0x10*/ string m_StreamName;
            /*0x18*/ UnityEngine.Object m_SourceObject;
            /*0x20*/ System.Type m_SourceBindingType;
            /*0x28*/ UnityEngine.Playables.PlayableBinding.CreateOutputMethod m_CreateOutputMethod;

            static /*0x3e01028*/ PlayableBinding();
            static /*0x3e00fa0*/ UnityEngine.Playables.PlayableBinding CreateInternal(string name, UnityEngine.Object sourceObject, System.Type sourceType, UnityEngine.Playables.PlayableBinding.CreateOutputMethod createFunction);
            /*0x3e00eb0*/ UnityEngine.Object get_sourceObject();
            /*0x3e00eb8*/ UnityEngine.Playables.PlayableOutput CreateOutput(UnityEngine.Playables.PlayableGraph graph);

            class CreateOutputMethod : System.MulticastDelegate
            {
                /*0x3e010b0*/ CreateOutputMethod(object object, nint method);
                /*0x3e01150*/ UnityEngine.Playables.PlayableOutput Invoke(UnityEngine.Playables.PlayableGraph graph, string name);
            }
        }

        enum PlayableTraversalMode
        {
            Mix = 0,
            Passthrough = 1,
        }

        class PlayableExtensions
        {
            static /*0x1ffc854*/ bool IsValid<U>(U playable);
            static /*0x1ffc854*/ UnityEngine.Playables.PlayableGraph GetGraph<U>(U playable);
            static /*0x1ffc854*/ UnityEngine.Playables.PlayState GetPlayState<U>(U playable);
            static /*0x1ffc854*/ void Play<U>(U playable);
            static /*0x1ffc854*/ void Pause<U>(U playable);
            static /*0x1ffc854*/ void SetSpeed<U>(U playable, double value);
            static /*0x1ffc854*/ double GetSpeed<U>(U playable);
            static /*0x1ffc854*/ void SetDuration<U>(U playable, double value);
            static /*0x1ffc854*/ double GetDuration<U>(U playable);
            static /*0x1ffc854*/ void SetTime<U>(U playable, double value);
            static /*0x1ffc854*/ double GetTime<U>(U playable);
            static /*0x1ffc854*/ double GetPreviousTime<U>(U playable);
            static /*0x1ffc854*/ void SetDone<U>(U playable, bool value);
            static /*0x1ffc854*/ bool IsDone<U>(U playable);
            static /*0x1ffc854*/ void SetPropagateSetTime<U>(U playable, bool value);
            static /*0x1ffc854*/ void SetInputCount<U>(U playable, int value);
            static /*0x1ffc854*/ int GetInputCount<U>(U playable);
            static /*0x1ffc854*/ UnityEngine.Playables.Playable GetInput<U>(U playable, int inputPort);
            static /*0x1ffc854*/ void SetInputWeight<U>(U playable, int inputIndex, float weight);
            static /*0x1ffc854*/ void SetInputWeight<U, V>(U playable, V input, float weight);
            static /*0x1ffc854*/ float GetInputWeight<U>(U playable, int inputIndex);
            static /*0x1ffc854*/ void SetTraversalMode<U>(U playable, UnityEngine.Playables.PlayableTraversalMode mode);
            static /*0x1ffc854*/ UnityEngine.Playables.DirectorWrapMode GetTimeWrapMode<U>(U playable);
            static /*0x1ffc854*/ void SetTimeWrapMode<U>(U playable, UnityEngine.Playables.DirectorWrapMode value);
        }

        enum DirectorUpdateMode
        {
            DSPClock = 0,
            GameTime = 1,
            UnscaledGameTime = 2,
            Manual = 3,
        }

        struct PlayableGraph
        {
            /*0x10*/ nint m_Handle;
            /*0x18*/ uint m_Version;

            static /*0x3e011f0*/ UnityEngine.Playables.PlayableGraph Create();
            static /*0x3e011f8*/ UnityEngine.Playables.PlayableGraph Create(string name);
            static /*0x3e01344*/ void Create_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Playables.PlayableGraph ret);
            static /*0x3e01534*/ void CreatePlayableHandle_Injected(ref UnityEngine.Playables.PlayableGraph _unity_self, ref UnityEngine.Playables.PlayableHandle ret);
            static /*0x3e016dc*/ bool CreateScriptOutputInternal_Injected(ref UnityEngine.Playables.PlayableGraph _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Playables.PlayableOutputHandle handle);
            static /*0x3e017a4*/ bool ConnectInternal_Injected(ref UnityEngine.Playables.PlayableGraph _unity_self, ref UnityEngine.Playables.PlayableHandle source, int sourceOutputPort, ref UnityEngine.Playables.PlayableHandle destination, int destinationInputPort);
            static /*0x3e01868*/ void DisconnectInternal_Injected(ref UnityEngine.Playables.PlayableGraph _unity_self, ref UnityEngine.Playables.PlayableHandle playable, int inputPort);
            static /*0x3e0190c*/ void DestroySubgraphInternal_Injected(ref UnityEngine.Playables.PlayableGraph _unity_self, ref UnityEngine.Playables.PlayableHandle playable);
            /*0x1ffc854*/ bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort);
            /*0x1ffc854*/ void Disconnect<U>(U input, int inputPort);
            /*0x1ffc854*/ void DestroySubgraph<U>(U playable);
            /*0x3e01164*/ void Evaluate();
            /*0x3e01388*/ void Destroy();
            /*0x3e013c4*/ bool IsValid();
            /*0x3e01400*/ void Play();
            /*0x3e0143c*/ void Stop();
            /*0x3e011a4*/ void Evaluate(float deltaTime);
            /*0x3e01478*/ void SetTimeUpdateMode(UnityEngine.Playables.DirectorUpdateMode value);
            /*0x3e014bc*/ UnityEngine.IExposedPropertyTable GetResolver();
            /*0x3e014f8*/ int GetPlayableCount();
            /*0x3e0099c*/ UnityEngine.Playables.PlayableHandle CreatePlayableHandle();
            /*0x3e01578*/ bool CreateScriptOutputInternal(string name, ref UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x3e01730*/ bool ConnectInternal(UnityEngine.Playables.PlayableHandle source, int sourceOutputPort, UnityEngine.Playables.PlayableHandle destination, int destinationInputPort);
            /*0x3e01810*/ void DisconnectInternal(UnityEngine.Playables.PlayableHandle playable, int inputPort);
            /*0x3e018bc*/ void DestroySubgraphInternal(UnityEngine.Playables.PlayableHandle playable);
        }

        enum PlayState
        {
            Paused = 0,
            Playing = 1,
            Delayed = 2,
        }

        struct PlayableHandle : System.IEquatable<UnityEngine.Playables.PlayableHandle>
        {
            static /*0x0*/ UnityEngine.Playables.PlayableHandle m_Null;
            /*0x10*/ nint m_Handle;
            /*0x18*/ uint m_Version;

            static /*0x3e027e4*/ PlayableHandle();
            static /*0x3e00c70*/ UnityEngine.Playables.PlayableHandle get_Null();
            static /*0x3e00b88*/ bool op_Equality(UnityEngine.Playables.PlayableHandle x, UnityEngine.Playables.PlayableHandle y);
            static /*0x3e01cc0*/ bool op_Inequality(UnityEngine.Playables.PlayableHandle x, UnityEngine.Playables.PlayableHandle y);
            static /*0x3e01cb0*/ bool CompareVersion(UnityEngine.Playables.PlayableHandle lhs, UnityEngine.Playables.PlayableHandle rhs);
            static /*0x3e024e0*/ void GetGraph_Injected(ref UnityEngine.Playables.PlayableHandle _unity_self, ref UnityEngine.Playables.PlayableGraph ret);
            static /*0x3e02600*/ void SetInputWeight_Injected(ref UnityEngine.Playables.PlayableHandle _unity_self, ref UnityEngine.Playables.PlayableHandle input, float weight);
            static /*0x3e02790*/ void GetInputHandle_Injected(ref UnityEngine.Playables.PlayableHandle _unity_self, int index, ref UnityEngine.Playables.PlayableHandle ret);
            /*0x1ffc854*/ T GetObject<T>();
            /*0x1f2fe14*/ bool IsPlayableOfType<T>();
            /*0x3e01950*/ UnityEngine.Playables.Playable GetInput(int inputPort);
            /*0x3e01a50*/ bool SetInputWeight(int inputIndex, float weight);
            /*0x3e01bcc*/ float GetInputWeight(int inputIndex);
            /*0x3e01d38*/ bool Equals(object p);
            /*0x3e01de4*/ bool Equals(UnityEngine.Playables.PlayableHandle other);
            /*0x3e01e54*/ int GetHashCode();
            /*0x3e01b08*/ bool CheckInputBounds(int inputIndex);
            /*0x3e01e88*/ bool CheckInputBounds(int inputIndex, bool acceptAny);
            /*0x3e020c4*/ bool IsValid();
            /*0x3e00ab4*/ System.Type GetPlayableType();
            /*0x3e02100*/ void SetScriptInstance(object scriptInstance);
            /*0x3e02144*/ UnityEngine.Playables.PlayState GetPlayState();
            /*0x3e02180*/ void Play();
            /*0x3e021bc*/ void Pause();
            /*0x3e021f8*/ double GetSpeed();
            /*0x3e02234*/ void SetSpeed(double value);
            /*0x3e02280*/ double GetTime();
            /*0x3e022bc*/ void SetTime(double value);
            /*0x3e02308*/ bool IsDone();
            /*0x3e02344*/ void SetDone(bool value);
            /*0x3e02388*/ double GetDuration();
            /*0x3e023c4*/ void SetDuration(double value);
            /*0x3e02410*/ void SetPropagateSetTime(bool value);
            /*0x3e02454*/ UnityEngine.Playables.PlayableGraph GetGraph();
            /*0x3e02088*/ int GetInputCount();
            /*0x3e02524*/ void SetInputCount(int value);
            /*0x3e02568*/ void SetInputWeight(UnityEngine.Playables.PlayableHandle input, float weight);
            /*0x3e02654*/ double GetPreviousTime();
            /*0x3e02690*/ void SetTraversalMode(UnityEngine.Playables.PlayableTraversalMode mode);
            /*0x3e026d4*/ UnityEngine.Playables.DirectorWrapMode GetTimeWrapMode();
            /*0x3e02710*/ void SetTimeWrapMode(UnityEngine.Playables.DirectorWrapMode mode);
            /*0x3e02754*/ object GetScriptInstance();
            /*0x3e019b4*/ UnityEngine.Playables.PlayableHandle GetInputHandle(int index);
            /*0x3e01b78*/ void SetInputWeightFromIndex(int index, float weight);
            /*0x3e01c6c*/ float GetInputWeightFromIndex(int index);
        }

        struct PlayableOutput : UnityEngine.Playables.IPlayableOutput, System.IEquatable<UnityEngine.Playables.PlayableOutput>
        {
            static /*0x0*/ UnityEngine.Playables.PlayableOutput m_NullPlayableOutput;
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x3e02950*/ PlayableOutput();
            static /*0x3e00f48*/ UnityEngine.Playables.PlayableOutput get_Null();
            /*0x3e0282c*/ PlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x3e02834*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            /*0x1f2fe14*/ bool IsPlayableOutputOfType<T>();
            /*0x3e02840*/ bool Equals(UnityEngine.Playables.PlayableOutput other);
        }

        class PlayableOutputExtensions
        {
            static /*0x1ffc854*/ void SetReferenceObject<U>(U output, UnityEngine.Object value);
            static /*0x1ffc854*/ void SetUserData<U>(U output, UnityEngine.Object value);
            static /*0x1ffc854*/ UnityEngine.Playables.Playable GetSourcePlayable<U>(U output);
            static /*0x1ffc854*/ void SetSourcePlayable<U, V>(U output, V value, int port);
            static /*0x1ffc854*/ int GetSourceOutputPort<U>(U output);
            static /*0x1ffc854*/ void SetWeight<U>(U output, float value);
            static /*0x1ffc854*/ void PushNotification<U>(U output, UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, object context);
            static /*0x1ffc854*/ void AddNotificationReceiver<U>(U output, UnityEngine.Playables.INotificationReceiver receiver);
        }

        struct PlayableOutputHandle : System.IEquatable<UnityEngine.Playables.PlayableOutputHandle>
        {
            static /*0x0*/ UnityEngine.Playables.PlayableOutputHandle m_Null;
            /*0x10*/ nint m_Handle;
            /*0x18*/ uint m_Version;

            static /*0x3e030ac*/ PlayableOutputHandle();
            static /*0x3e029c0*/ UnityEngine.Playables.PlayableOutputHandle get_Null();
            static /*0x3e028d8*/ bool op_Equality(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs);
            static /*0x3e02a4c*/ bool CompareVersion(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs);
            static /*0x3e02ca0*/ void SetReferenceObject_Injected(ref UnityEngine.Playables.PlayableOutputHandle _unity_self, nint target);
            static /*0x3e02db4*/ void GetSourcePlayable_Injected(ref UnityEngine.Playables.PlayableOutputHandle _unity_self, ref UnityEngine.Playables.PlayableHandle ret);
            static /*0x3e02e90*/ void SetSourcePlayable_Injected(ref UnityEngine.Playables.PlayableOutputHandle _unity_self, ref UnityEngine.Playables.PlayableHandle target, int port);
            static /*0x3e0300c*/ void PushNotification_Injected(ref UnityEngine.Playables.PlayableOutputHandle _unity_self, ref UnityEngine.Playables.PlayableHandle origin, UnityEngine.Playables.INotification notification, object context);
            /*0x1f2fe14*/ bool IsPlayableOutputOfType<T>();
            /*0x3e02a18*/ int GetHashCode();
            /*0x3e02a5c*/ bool Equals(object p);
            /*0x3e02b08*/ bool Equals(UnityEngine.Playables.PlayableOutputHandle other);
            /*0x3e02b78*/ bool IsValid();
            /*0x3e02bb4*/ System.Type GetPlayableOutputType();
            /*0x3e02bf0*/ void SetReferenceObject(UnityEngine.Object target);
            /*0x3e02ce4*/ void SetUserData(UnityEngine.Object target);
            /*0x3e02d28*/ UnityEngine.Playables.PlayableHandle GetSourcePlayable();
            /*0x3e02df8*/ void SetSourcePlayable(UnityEngine.Playables.PlayableHandle target, int port);
            /*0x3e02ee4*/ int GetSourceOutputPort();
            /*0x3e02f20*/ void SetWeight(float weight);
            /*0x3e02f6c*/ void PushNotification(UnityEngine.Playables.PlayableHandle origin, UnityEngine.Playables.INotification notification, object context);
            /*0x3e03068*/ void AddNotificationReceiver(UnityEngine.Playables.INotificationReceiver receiver);
        }

        struct ScriptPlayable<T> : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Playables.ScriptPlayable<T>>
        {
            static /*0x0*/ UnityEngine.Playables.ScriptPlayable<T> m_NullPlayable;
            /*0x0*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x1f33998*/ ScriptPlayable();
            static /*0x1ffc854*/ UnityEngine.Playables.ScriptPlayable<T> get_Null();
            static /*0x1ffc854*/ UnityEngine.Playables.ScriptPlayable<T> Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x1ffc854*/ UnityEngine.Playables.ScriptPlayable<T> Create(UnityEngine.Playables.PlayableGraph graph, T template, int inputCount);
            static /*0x1ffc854*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, T template, int inputCount);
            static /*0x1f327a0*/ object CreateScriptInstance();
            static /*0x1f327cc*/ object CloneScriptInstance(UnityEngine.Playables.IPlayableBehaviour source);
            static /*0x1f327cc*/ object CloneScriptInstanceFromEngineObject(UnityEngine.Object source);
            static /*0x1f327cc*/ object CloneScriptInstanceFromIClonable(System.ICloneable source);
            static /*0x1ffc854*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Playables.ScriptPlayable<T> playable);
            /*0x1ffc854*/ ScriptPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x1ffc854*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x1ffc854*/ T GetBehaviour();
            /*0x1ffc854*/ bool Equals(UnityEngine.Playables.ScriptPlayable<T> other);
        }

        class ScriptPlayableBinding
        {
            static /*0x3e030f4*/ UnityEngine.Playables.PlayableBinding Create(string name, UnityEngine.Object key, System.Type type);
            static /*0x3e031d8*/ UnityEngine.Playables.PlayableOutput CreateScriptOutput(UnityEngine.Playables.PlayableGraph graph, string name);
        }

        struct ScriptPlayableOutput : UnityEngine.Playables.IPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x3e031dc*/ UnityEngine.Playables.ScriptPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, string name);
            static /*0x3e03230*/ UnityEngine.Playables.ScriptPlayableOutput get_Null();
            static /*0x3e0322c*/ UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Playables.ScriptPlayableOutput output);
            /*0x3e032a8*/ ScriptPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x3e033b4*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
        }
    }

    namespace Diagnostics
    {
        enum ForcedCrashCategory
        {
            AccessViolation = 0,
            FatalError = 1,
            Abort = 2,
            PureVirtualFunction = 3,
            MonoAbort = 4,
        }

        class Utils
        {
            static /*0x3e033c0*/ void ForceCrash(UnityEngine.Diagnostics.ForcedCrashCategory crashCategory);
        }
    }

    namespace Device
    {
        class Application
        {
            static /*0x3e033fc*/ UnityEngine.RuntimePlatform get_platform();
        }

        class SystemInfo
        {
            static /*0x3e0344c*/ string get_operatingSystem();
            static /*0x3e03454*/ int get_processorFrequency();
            static /*0x3e0345c*/ int get_processorCount();
            static /*0x3e03464*/ int get_systemMemorySize();
            static /*0x3e0346c*/ string get_deviceUniqueIdentifier();
            static /*0x3e03474*/ string get_deviceModel();
            static /*0x3e0347c*/ int get_graphicsMemorySize();
            static /*0x3e03484*/ UnityEngine.Rendering.GraphicsDeviceType get_graphicsDeviceType();
        }
    }

    namespace Assertions
    {
        class Assert
        {
            static /*0x0*/ bool raiseExceptions;

            static /*0x3e03f04*/ Assert();
            static /*0x3e0348c*/ void Fail(string message, string userMessage);
            static /*0x3e03628*/ void IsTrue(bool condition);
            static /*0x3e03690*/ void IsTrue(bool condition, string message);
            static /*0x3e037ac*/ void IsFalse(bool condition);
            static /*0x3e03814*/ void IsFalse(bool condition, string message);
            static /*0x1ffc854*/ void AreEqual<T>(T expected, T actual);
            static /*0x1ffc854*/ void AreEqual<T>(T expected, T actual, string message);
            static /*0x1ffc854*/ void AreEqual<T>(T expected, T actual, string message, System.Collections.Generic.IEqualityComparer<T> comparer);
            static /*0x3e03890*/ void AreEqual(UnityEngine.Object expected, UnityEngine.Object actual, string message);
            static /*0x1ffc854*/ void IsNull<T>(T value);
            static /*0x1ffc854*/ void IsNull<T>(T value, string message);
            static /*0x3e03b7c*/ void IsNull(UnityEngine.Object value, string message);
            static /*0x1ffc854*/ void IsNotNull<T>(T value);
            static /*0x1ffc854*/ void IsNotNull<T>(T value, string message);
            static /*0x3e03db8*/ void IsNotNull(UnityEngine.Object value, string message);
            static /*0x3e03e74*/ void AreEqual(int expected, int actual);
        }

        class AssertionException : System.Exception
        {
            /*0x90*/ string m_UserMessage;

            /*0x3e035ac*/ AssertionException(string message, string userMessage);
            /*0x3e03f50*/ string get_Message();
        }

        class AssertionMessageUtil
        {
            static /*0x3e03fc4*/ string GetMessage(string failureMessage);
            static /*0x3e040c4*/ string GetMessage(string failureMessage, string expected);
            static /*0x3e03958*/ string GetEqualityMessage(object actual, object expected, bool expectEqual);
            static /*0x3e03c38*/ string NullFailureMessage(object value, bool expectNull);
            static /*0x3e0370c*/ string BooleanFailureMessage(bool expected);
        }
    }

    namespace Analytics
    {
        enum SendEventOptions
        {
            kAppendNone = 0,
            kAppendBuildGuid = 1,
            kAppendBuildTarget = 2,
        }

        class AnalyticsEventBase
        {
            /*0x10*/ string eventName;
            /*0x18*/ int eventVersion;
            /*0x20*/ string eventPrefix;
            /*0x28*/ UnityEngine.Analytics.SendEventOptions sendEventOptions;

            /*0x3e04248*/ AnalyticsEventBase(string eventName, int eventVersion, UnityEngine.Analytics.SendEventOptions sendEventOptions, string eventPrefix);
        }

        class BatchRenderGroupUsageAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ int maxBRGInstance;
            /*0x30*/ int maxMeshCount;
            /*0x34*/ int maxMaterialCount;
            /*0x38*/ int maxDrawCommandBatch;

            static /*0x3e04314*/ UnityEngine.Analytics.BatchRenderGroupUsageAnalytic CreateBatchRenderGroupUsageAnalytic();
            /*0x3e042a4*/ BatchRenderGroupUsageAnalytic();
        }

        class UaaLApplicationLaunchAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ int launch_type;
            /*0x30*/ int launch_process_type;

            static /*0x3e043d4*/ UnityEngine.Analytics.UaaLApplicationLaunchAnalytic CreateUaaLApplicationLaunchAnalytic();
            /*0x3e04364*/ UaaLApplicationLaunchAnalytic();
        }

        class ShaderRuntimeInfoAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x30*/ long VariantsRequested;
            /*0x38*/ long VariantsRequestedMissing;
            /*0x40*/ long VariantsRequestedUnsupported;
            /*0x48*/ long VariantsRequestedCompiled;
            /*0x50*/ long VariantsRequestedViaWarmup;
            /*0x58*/ long VariantsUnused;
            /*0x60*/ int VariantsCompilationTimeTotal;
            /*0x64*/ int VariantsCompilationTimeMax;
            /*0x68*/ int VariantsCompilationTimeMedian;
            /*0x6c*/ int VariantsWarmupTimeTotal;
            /*0x70*/ int VariantsWarmupTimeMax;
            /*0x74*/ int VariantsWarmupTimeMedian;
            /*0x78*/ bool UseProgressiveWarmup;
            /*0x7c*/ int ShaderChunkSizeMin;
            /*0x80*/ int ShaderChunkSizeMax;
            /*0x84*/ int ShaderChunkSizeAvg;
            /*0x88*/ int ShaderChunkCountMin;
            /*0x8c*/ int ShaderChunkCountMax;
            /*0x90*/ int ShaderChunkCountAvg;

            static /*0x3e044b0*/ UnityEngine.Analytics.ShaderRuntimeInfoAnalytic CreateShaderRuntimeInfoAnalytic();
            /*0x3e04424*/ ShaderRuntimeInfoAnalytic();
        }
    }

    namespace Rendering
    {
        class SortingGroup : UnityEngine.Behaviour
        {
            static /*0x3e04500*/ int get_invalidSortingGroupID();
            static /*0x3e04528*/ UnityEngine.Rendering.SortingGroup GetSortingGroupByIndex(int index);
            static /*0x3e04594*/ nint GetSortingGroupByIndex_Injected(int index);
            static /*0x3e04644*/ int get_sortingLayerID_Injected(nint _unity_self);
            static /*0x3e046f4*/ int get_sortingOrder_Injected(nint _unity_self);
            static /*0x3e047ac*/ void set_sortingOrder_Injected(nint _unity_self, int value);
            /*0x3e045d0*/ int get_sortingLayerID();
            /*0x3e04680*/ int get_sortingOrder();
            /*0x3e04730*/ void set_sortingOrder(int value);
        }

        struct AsyncGPUReadbackRequest
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ int m_Version;

            static /*0x3e04a94*/ void InvokeCallback(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncGPUReadbackRequest obj);
            /*0x3e047f0*/ void WaitForCompletion();
            /*0x1ffc854*/ Unity.Collections.NativeArray<T> GetData<T>(int layer);
            /*0x3e0482c*/ bool get_done();
            /*0x3e048a4*/ bool get_hasError();
            /*0x3e0491c*/ int get_layerCount();
            /*0x3e04994*/ int get_layerDataSize();
            /*0x3e04868*/ bool IsDone();
            /*0x3e048e0*/ bool HasError();
            /*0x3e04958*/ int GetLayerCount();
            /*0x3e049d0*/ int GetLayerDataSize();
            /*0x3e04a0c*/ void SetScriptingCallback(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3e04a50*/ nint GetDataRaw(int layer);
        }

        struct AsyncRequestNativeArrayData
        {
            /*0x10*/ void* nativeArrayBuffer;
            /*0x18*/ long lengthInBytes;

            static /*0x1ffc854*/ UnityEngine.Rendering.AsyncRequestNativeArrayData CreateAndCheckAccess<T>(Unity.Collections.NativeArray<T> array);
        }

        class AsyncGPUReadback
        {
            static /*0x3e04ad0*/ UnityEngine.Rendering.AsyncGPUReadbackRequest Request(UnityEngine.GraphicsBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            static /*0x3e04bd8*/ UnityEngine.Rendering.AsyncGPUReadbackRequest Request(UnityEngine.GraphicsBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            static /*0x3e04b30*/ UnityEngine.Rendering.AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_1(UnityEngine.GraphicsBuffer buffer, UnityEngine.Rendering.AsyncRequestNativeArrayData* data);
            static /*0x3e04c38*/ UnityEngine.Rendering.AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_2(UnityEngine.GraphicsBuffer src, int size, int offset, UnityEngine.Rendering.AsyncRequestNativeArrayData* data);
            static /*0x3e04cf8*/ void Request_Internal_GraphicsBuffer_1_Injected(nint buffer, UnityEngine.Rendering.AsyncRequestNativeArrayData* data, ref UnityEngine.Rendering.AsyncGPUReadbackRequest ret);
            static /*0x3e04d4c*/ void Request_Internal_GraphicsBuffer_2_Injected(nint src, int size, int offset, UnityEngine.Rendering.AsyncRequestNativeArrayData* data, ref UnityEngine.Rendering.AsyncGPUReadbackRequest ret);
        }

        enum SynchronisationStage
        {
            VertexProcessing = 0,
            PixelProcessing = 1,
        }

        enum ShaderHardwareTier
        {
            Tier1 = 0,
            Tier2 = 1,
            Tier3 = 2,
        }

        enum BlendShapeBufferLayout
        {
            PerShape = 0,
            PerVertex = 1,
        }

        enum RayTracingAccelerationStructureBuildFlags
        {
            None = 0,
            PreferFastTrace = 1,
            PreferFastBuild = 2,
            MinimizeMemory = 4,
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

        enum CameraEvent
        {
            BeforeDepthTexture = 0,
            AfterDepthTexture = 1,
            BeforeDepthNormalsTexture = 2,
            AfterDepthNormalsTexture = 3,
            BeforeGBuffer = 4,
            AfterGBuffer = 5,
            BeforeLighting = 6,
            AfterLighting = 7,
            BeforeFinalPass = 8,
            AfterFinalPass = 9,
            BeforeForwardOpaque = 10,
            AfterForwardOpaque = 11,
            BeforeImageEffectsOpaque = 12,
            AfterImageEffectsOpaque = 13,
            BeforeSkybox = 14,
            AfterSkybox = 15,
            BeforeForwardAlpha = 16,
            AfterForwardAlpha = 17,
            BeforeImageEffects = 18,
            AfterImageEffects = 19,
            AfterEverything = 20,
            BeforeReflections = 21,
            AfterReflections = 22,
            BeforeHaloAndLensFlares = 23,
            AfterHaloAndLensFlares = 24,
        }

        class CameraEventUtils
        {
            static /*0x3e04db8*/ bool IsValid(UnityEngine.Rendering.CameraEvent value);
        }

        enum LightEvent
        {
            BeforeShadowMap = 0,
            AfterShadowMap = 1,
            BeforeScreenspaceMask = 2,
            AfterScreenspaceMask = 3,
            BeforeShadowMapPass = 4,
            AfterShadowMapPass = 5,
        }

        enum ShadowMapPass
        {
            PointlightPositiveX = 1,
            PointlightNegativeX = 2,
            PointlightPositiveY = 4,
            PointlightNegativeY = 8,
            PointlightPositiveZ = 16,
            PointlightNegativeZ = 32,
            DirectionalCascade0 = 64,
            DirectionalCascade1 = 128,
            DirectionalCascade2 = 256,
            DirectionalCascade3 = 512,
            Spotlight = 1024,
            AreaLight = 2048,
            Pointlight = 63,
            Directional = 960,
            All = 2047,
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

        enum LightUnit
        {
            Lumen = 0,
            Candela = 1,
            Lux = 2,
            Nits = 3,
            Ev100 = 4,
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
            WebGPU = 28,
            Switch2 = 29,
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

            /*0x3e04dc4*/ UnityEngine.Bounds get_bounds();
            /*0x3e04dd8*/ UnityEngine.MeshTopology get_topology();
            /*0x3e04de0*/ int get_indexStart();
            /*0x3e04de8*/ int get_indexCount();
            /*0x3e04df0*/ int get_baseVertex();
            /*0x3e04df8*/ int get_firstVertex();
            /*0x3e04e00*/ int get_vertexCount();
            /*0x3e04e08*/ string ToString();
        }

        struct VertexAttributeDescriptor : System.IEquatable<UnityEngine.Rendering.VertexAttributeDescriptor>
        {
            /*0x10*/ UnityEngine.Rendering.VertexAttribute <attribute>k__BackingField;
            /*0x14*/ UnityEngine.Rendering.VertexAttributeFormat <format>k__BackingField;
            /*0x18*/ int <dimension>k__BackingField;
            /*0x1c*/ int <stream>k__BackingField;

            /*0x3e0512c*/ VertexAttributeDescriptor(UnityEngine.Rendering.VertexAttribute attribute, UnityEngine.Rendering.VertexAttributeFormat format, int dimension, int stream);
            /*0x3e050ec*/ UnityEngine.Rendering.VertexAttribute get_attribute();
            /*0x3e050f4*/ void set_attribute(UnityEngine.Rendering.VertexAttribute value);
            /*0x3e050fc*/ UnityEngine.Rendering.VertexAttributeFormat get_format();
            /*0x3e05104*/ void set_format(UnityEngine.Rendering.VertexAttributeFormat value);
            /*0x3e0510c*/ int get_dimension();
            /*0x3e05114*/ void set_dimension(int value);
            /*0x3e0511c*/ int get_stream();
            /*0x3e05124*/ void set_stream(int value);
            /*0x3e05138*/ string ToString();
            /*0x3e05330*/ int GetHashCode();
            /*0x3e05354*/ bool Equals(object other);
            /*0x3e053fc*/ bool Equals(UnityEngine.Rendering.VertexAttributeDescriptor other);
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

            static /*0x3e05640*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.BuiltinRenderTextureType type);
            static /*0x3e05660*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(string name);
            static /*0x3e05694*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(int nameID);
            static /*0x3e056b4*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Texture tex);
            static /*0x3e05b28*/ bool op_Equality(UnityEngine.Rendering.RenderTargetIdentifier lhs, UnityEngine.Rendering.RenderTargetIdentifier rhs);
            static /*0x3e05b58*/ bool op_Inequality(UnityEngine.Rendering.RenderTargetIdentifier lhs, UnityEngine.Rendering.RenderTargetIdentifier rhs);
            /*0x3e05440*/ RenderTargetIdentifier(UnityEngine.Rendering.BuiltinRenderTextureType type);
            /*0x3e05460*/ RenderTargetIdentifier(string name);
            /*0x3e05498*/ RenderTargetIdentifier(int nameID);
            /*0x3e054b8*/ RenderTargetIdentifier(int nameID, int mipLevel, UnityEngine.CubemapFace cubeFace, int depthSlice);
            /*0x3e054d4*/ RenderTargetIdentifier(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier, int mipLevel, UnityEngine.CubemapFace cubeFace, int depthSlice);
            /*0x3e05500*/ RenderTargetIdentifier(UnityEngine.Texture tex);
            /*0x3e05620*/ RenderTargetIdentifier(UnityEngine.RenderBuffer buf, int mipLevel, UnityEngine.CubemapFace cubeFace, int depthSlice);
            /*0x3e056f4*/ string ToString();
            /*0x3e059d0*/ int GetHashCode();
            /*0x3e05a1c*/ bool Equals(UnityEngine.Rendering.RenderTargetIdentifier rhs);
            /*0x3e05a98*/ bool Equals(object obj);
        }

        enum RenderTargetFlags
        {
            None = 0,
            ReadOnlyDepth = 1,
            ReadOnlyStencil = 2,
            ReadOnlyDepthStencil = 3,
        }

        struct RenderTargetBinding
        {
            /*0x10*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_ColorRenderTargets;
            /*0x18*/ UnityEngine.Rendering.RenderTargetIdentifier m_DepthRenderTarget;
            /*0x40*/ UnityEngine.Rendering.RenderBufferLoadAction[] m_ColorLoadActions;
            /*0x48*/ UnityEngine.Rendering.RenderBufferStoreAction[] m_ColorStoreActions;
            /*0x50*/ UnityEngine.Rendering.RenderBufferLoadAction m_DepthLoadAction;
            /*0x54*/ UnityEngine.Rendering.RenderBufferStoreAction m_DepthStoreAction;
            /*0x58*/ UnityEngine.Rendering.RenderTargetFlags m_Flags;

            /*0x3e05b8c*/ UnityEngine.Rendering.RenderTargetIdentifier[] get_colorRenderTargets();
            /*0x3e05b94*/ UnityEngine.Rendering.RenderTargetIdentifier get_depthRenderTarget();
            /*0x3e05bac*/ UnityEngine.Rendering.RenderBufferLoadAction[] get_colorLoadActions();
            /*0x3e05bb4*/ UnityEngine.Rendering.RenderBufferStoreAction[] get_colorStoreActions();
            /*0x3e05bbc*/ UnityEngine.Rendering.RenderBufferLoadAction get_depthLoadAction();
            /*0x3e05bc4*/ UnityEngine.Rendering.RenderBufferStoreAction get_depthStoreAction();
            /*0x3e05bcc*/ UnityEngine.Rendering.RenderTargetFlags get_flags();
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
            SHADER_API_GLES31 = 32,
            SHADER_API_GLES32 = 33,
            UNITY_UNIFIED_SHADER_PRECISION_MODEL = 34,
            UNITY_PLATFORM_SUPPORTS_WAVE_32 = 35,
            UNITY_PLATFORM_SUPPORTS_WAVE_64 = 36,
            UNITY_NEEDS_RENDERPASS_FBFETCH_FALLBACK = 37,
            UNITY_PLATFORM_SUPPORTS_DEPTH_FETCH = 38,
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
            ModeChangeOnlyBeforeRenderTargetSet = 4,
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
            NativeGraphicsJobsSplitThreading = 6,
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

            static /*0x3e05bd4*/ UnityEngine.Rendering.SynchronisationStageFlags TranslateSynchronizationStageToFlags(UnityEngine.Rendering.SynchronisationStage s);
            static /*0x3e05c94*/ int GetVersionNumber(nint fencePtr);
            /*0x3e05be4*/ void InitPostAllocation();
            /*0x3e05cd0*/ bool IsFencePending();
            /*0x3e05d28*/ void Validate();
            /*0x3e05c8c*/ int GetPlatformNotSupportedVersion();
        }

        class GraphicsSettings : UnityEngine.Object
        {
            static /*0x0*/ System.Lazy<UnityEngine.Rendering.RenderPipelineGlobalSettings> s_CurrentRenderPipelineGlobalSettings;

            static /*0x3e06a80*/ GraphicsSettings();
            static /*0x3e05da0*/ UnityEngine.Object Internal_GetSettingsForRenderPipeline(string renderpipelineName);
            static /*0x1f327a0*/ UnityEngine.Rendering.RenderPipelineGlobalSettings GetSettingsForRenderPipeline<T>();
            static /*0x3e05fd8*/ UnityEngine.Rendering.RenderPipelineGlobalSettings Internal_GetCurrentRenderPipelineGlobalSettings();
            static /*0x3e06180*/ bool TryGetCurrentRenderPipelineGlobalSettings(ref UnityEngine.Rendering.RenderPipelineGlobalSettings asset);
            static /*0x1ffc854*/ T GetRenderPipelineSettings<T>();
            static /*0x1f31840*/ bool TryGetRenderPipelineSettings<T>(ref T settings);
            static /*0x3e06258*/ bool get_lightsUseLinearIntensity();
            static /*0x3e06280*/ void set_lightsUseLinearIntensity(bool value);
            static /*0x3e062bc*/ void set_lightsUseColorTemperature(bool value);
            static /*0x3e062f8*/ void set_useScriptableRenderPipelineBatching(bool value);
            static /*0x3e06334*/ bool HasShaderDefine(UnityEngine.Rendering.GraphicsTier tier, UnityEngine.Rendering.BuiltinShaderDefine defineHash);
            static /*0x3e06378*/ bool HasShaderDefine(UnityEngine.Rendering.BuiltinShaderDefine defineHash);
            static /*0x3e06424*/ UnityEngine.ScriptableObject get_INTERNAL_currentRenderPipeline();
            static /*0x3e060e4*/ UnityEngine.Rendering.RenderPipelineAsset get_currentRenderPipeline();
            static /*0x3e064d0*/ bool get_isScriptableRenderPipelineEnabled();
            static /*0x3e06558*/ System.Type get_currentRenderPipelineAssetType();
            static /*0x3e065dc*/ UnityEngine.Shader GetDefaultShader(UnityEngine.Rendering.DefaultShaderType type);
            static /*0x3e0683c*/ UnityEngine.Material GetDefaultMaterial(UnityEngine.Rendering.DefaultMaterialType type);
            static /*0x3e05f9c*/ nint Internal_GetSettingsForRenderPipeline_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper renderpipelineName);
            static /*0x3e064a8*/ nint get_INTERNAL_currentRenderPipeline_Injected();

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.GraphicsSettings.<> <>9;

                static /*0x3e06b98*/ <>c();
                /*0x3e06c00*/ <>c();
                /*0x3e06c08*/ UnityEngine.Rendering.RenderPipelineGlobalSettings <.cctor>b__93_0();
            }
        }

        enum DefaultMaterialType
        {
            Default = 0,
            Particle = 1,
            Line = 2,
            Terrain = 3,
            Sprite = 4,
            SpriteMask = 5,
            UGUI = 6,
            UGUI_Overdraw = 7,
            UGUI_ETC1Supported = 8,
        }

        enum DefaultShaderType
        {
            Default = 0,
            AutodeskInteractive = 1,
            AutodeskInteractiveTransparent = 2,
            AutodeskInteractiveMasked = 3,
            TerrainDetailLit = 4,
            TerrainDetailGrass = 5,
            TerrainDetailGrassBillboard = 6,
            SpeedTree7 = 7,
            SpeedTree8 = 8,
            SpeedTree9 = 9,
        }

        interface IRenderPipelineGraphicsSettings
        {
            /*0x1f2ffc8*/ int get_version();
            /*0x3e06c54*/ bool get_isAvailableInPlayerBuild();
        }

        interface IRenderPipelineResources : UnityEngine.Rendering.IRenderPipelineGraphicsSettings
        {
        }

        enum SearchType
        {
            ProjectPath = 0,
            BuiltinPath = 1,
            BuiltinExtraPath = 2,
            ShaderName = 3,
        }

        class ResourcePathsBaseAttribute : System.Attribute
        {
            /*0x3e06c5c*/ ResourcePathsBaseAttribute(string[] paths, bool isField, UnityEngine.Rendering.SearchType location);
        }

        class ResourcePathAttribute : UnityEngine.Rendering.ResourcePathsBaseAttribute
        {
            /*0x3e06c64*/ ResourcePathAttribute(string path, UnityEngine.Rendering.SearchType location);
        }

        class ResourcePathsAttribute : UnityEngine.Rendering.ResourcePathsBaseAttribute
        {
            /*0x3e06c6c*/ ResourcePathsAttribute(string[] paths, UnityEngine.Rendering.SearchType location);
        }

        class ResourceFormattedPathsAttribute : UnityEngine.Rendering.ResourcePathsBaseAttribute
        {
            /*0x3e06c74*/ ResourceFormattedPathsAttribute(string pathFormat, int rangeMin, int rangeMax, UnityEngine.Rendering.SearchType location);
        }

        class OnDemandRendering
        {
            static /*0x0*/ int m_RenderFrameInterval;

            static /*0x3e06d2c*/ OnDemandRendering();
            static /*0x3e06c7c*/ int get_renderFrameInterval();
            static /*0x3e06cd4*/ void GetRenderFrameInterval(ref int frameInterval);
        }

        class RayTracingAccelerationStructure : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x3e06e6c*/ void Destroy(UnityEngine.Rendering.RayTracingAccelerationStructure accelStruct);
            static /*0x3e06eb4*/ void Destroy_Injected(nint accelStruct);
            /*0x3e06d78*/ void Dispose();
            /*0x3e06e14*/ void Dispose(bool disposing);

            struct BuildSettings
            {
                /*0x10*/ UnityEngine.Rendering.RayTracingAccelerationStructureBuildFlags <buildFlags>k__BackingField;
                /*0x14*/ UnityEngine.Vector3 <relativeOrigin>k__BackingField;

                /*0x3e06f04*/ BuildSettings();
                /*0x3e06ef0*/ void set_buildFlags(UnityEngine.Rendering.RayTracingAccelerationStructureBuildFlags value);
                /*0x3e06ef8*/ void set_relativeOrigin(UnityEngine.Vector3 value);
            }

            class BindingsMarshaller
            {
                static /*0x3e06f60*/ nint ConvertToNative(UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            }
        }

        class RenderPipelineGraphicsSettingsCollection
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> m_List;

            /*0x3e06f7c*/ RenderPipelineGraphicsSettingsCollection();
            /*0x3e06f74*/ System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> get_settingsList();
        }

        class RenderPipelineGraphicsSettingsExtensions
        {
            static /*0x1ffc854*/ void SetValueAndNotify<T>(UnityEngine.Rendering.IRenderPipelineGraphicsSettings settings, ref T currentPropertyValue, T newValue, string propertyName);
        }

        class RecreatePipelineOnChangeAttribute : System.Attribute
        {
            /*0x3e07004*/ RecreatePipelineOnChangeAttribute();
        }

        class CommandBuffer : System.IDisposable
        {
            static /*0x0*/ bool ThrowOnSetRenderTarget;
            /*0x10*/ nint m_Ptr;

            static /*0x3e07f40*/ nint InitBuffer();
            static /*0x3e10cb0*/ void CheckThrowOnSetRenderTarget();
            static /*0x3e070f0*/ void Internal_RequestAsyncReadback_1_Injected(nint _unity_self, nint src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x3e07248*/ void Internal_RequestAsyncReadback_2_Injected(nint _unity_self, nint src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x3e073ac*/ void Internal_RequestAsyncReadback_3_Injected(nint _unity_self, nint src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x3e07508*/ void Internal_RequestAsyncReadback_4_Injected(nint _unity_self, nint src, int mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x3e0767c*/ void Internal_RequestAsyncReadback_5_Injected(nint _unity_self, nint src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x3e07874*/ void Internal_RequestAsyncReadback_6_Injected(nint _unity_self, nint src, int mipIndex, int x, int width, int y, int height, int z, int depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x3e07aa8*/ void Internal_RequestAsyncReadback_7_Injected(nint _unity_self, nint src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x3e07c44*/ void Internal_RequestAsyncReadback_8_Injected(nint _unity_self, nint src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x3e07d9c*/ void Internal_RequestAsyncReadback_9_Injected(nint _unity_self, nint src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x3e07e64*/ void SetInvertCulling_Injected(nint _unity_self, bool invertCulling);
            static /*0x3e07efc*/ void Internal_SetSinglePassStereo_Injected(nint _unity_self, UnityEngine.Rendering.SinglePassStereoMode mode);
            static /*0x3e07fcc*/ nint CreateGPUFence_Internal_Injected(nint _unity_self, UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage);
            static /*0x3e08084*/ void WaitOnGPUFence_Internal_Injected(nint _unity_self, nint fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage);
            static /*0x3e08124*/ void ReleaseBuffer_Injected(nint _unity_self);
            static /*0x3e08234*/ void SetComputeFloatParam_Injected(nint _unity_self, nint computeShader, int nameID, float val);
            static /*0x3e08364*/ void SetComputeIntParam_Injected(nint _unity_self, nint computeShader, int nameID, int val);
            static /*0x3e0849c*/ void SetComputeVectorParam_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Vector4 val);
            static /*0x3e08634*/ void SetComputeVectorArrayParam_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x3e0875c*/ void SetComputeMatrixParam_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Matrix4x4 val);
            static /*0x3e088f4*/ void SetComputeMatrixArrayParam_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x3e08a8c*/ void Internal_SetComputeFloats_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x3e08c24*/ void Internal_SetComputeInts_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x3e08d74*/ void Internal_SetComputeTextureParam_Injected(nint _unity_self, nint computeShader, int kernelIndex, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            static /*0x3e08edc*/ void Internal_SetComputeBufferParam_Injected(nint _unity_self, nint computeShader, int kernelIndex, int nameID, nint buffer);
            static /*0x3e09028*/ void Internal_SetComputeGraphicsBufferHandleParam_Injected(nint _unity_self, nint computeShader, int kernelIndex, int nameID, ref UnityEngine.GraphicsBufferHandle bufferHandle);
            static /*0x3e09178*/ void Internal_SetComputeGraphicsBufferParam_Injected(nint _unity_self, nint computeShader, int kernelIndex, int nameID, nint buffer);
            static /*0x3e092d0*/ void Internal_SetComputeConstantComputeBufferParam_Injected(nint _unity_self, nint computeShader, int nameID, nint buffer, int offset, int size);
            static /*0x3e09430*/ void Internal_SetComputeConstantGraphicsBufferParam_Injected(nint _unity_self, nint computeShader, int nameID, nint buffer, int offset, int size);
            static /*0x3e09588*/ void Internal_DispatchCompute_Injected(nint _unity_self, nint computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            static /*0x3e096e0*/ void Internal_DispatchComputeIndirect_Injected(nint _unity_self, nint computeShader, int kernelIndex, nint indirectBuffer, uint argsOffset);
            static /*0x3e09830*/ void Internal_DispatchComputeIndirectGraphicsBuffer_Injected(nint _unity_self, nint computeShader, int kernelIndex, nint indirectBuffer, uint argsOffset);
            static /*0x3e09970*/ void Internal_SetRayTracingComputeBufferParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, nint buffer);
            static /*0x3e09aa0*/ void Internal_SetRayTracingGraphicsBufferParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, nint buffer);
            static /*0x3e09bcc*/ void Internal_SetRayTracingGraphicsBufferHandleParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.GraphicsBufferHandle bufferHandle);
            static /*0x3e09d14*/ void Internal_SetRayTracingConstantComputeBufferParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, nint buffer, int offset, int size);
            static /*0x3e09e74*/ void Internal_SetRayTracingConstantGraphicsBufferParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, nint buffer, int offset, int size);
            static /*0x3e09fb4*/ void Internal_SetRayTracingTextureParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt);
            static /*0x3e0a0e4*/ void Internal_SetRayTracingFloatParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, float val);
            static /*0x3e0a214*/ void Internal_SetRayTracingIntParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, int val);
            static /*0x3e0a34c*/ void Internal_SetRayTracingVectorParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Vector4 val);
            static /*0x3e0a4e4*/ void Internal_SetRayTracingVectorArrayParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x3e0a60c*/ void Internal_SetRayTracingMatrixParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Matrix4x4 val);
            static /*0x3e0a7a4*/ void Internal_SetRayTracingMatrixArrayParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x3e0a93c*/ void Internal_SetRayTracingFloats_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x3e0aad4*/ void Internal_SetRayTracingInts_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x3e0abec*/ void Internal_BuildRayTracingAccelerationStructure_Injected(nint _unity_self, nint accelerationStructure, ref UnityEngine.Rendering.RayTracingAccelerationStructure.BuildSettings buildSettings);
            static /*0x3e0ad48*/ void Internal_SetRayTracingAccelerationStructure_Injected(nint _unity_self, nint rayTracingShader, int nameID, nint accelerationStructure);
            static /*0x3e0aebc*/ void Internal_SetComputeRayTracingAccelerationStructure_Injected(nint _unity_self, nint computeShader, int kernelIndex, int nameID, nint accelerationStructure);
            static /*0x3e0b14c*/ void Internal_DispatchRays_Injected(nint _unity_self, nint rayTracingShader, ref UnityEngine.Bindings.ManagedSpanWrapper rayGenShaderName, uint width, uint height, uint depth, nint camera);
            static /*0x3e0b254*/ void CopyCounterValueCC_Injected(nint _unity_self, nint src, nint dst, uint dstOffsetBytes);
            static /*0x3e0b334*/ void CopyCounterValueGC_Injected(nint _unity_self, nint src, nint dst, uint dstOffsetBytes);
            static /*0x3e0b414*/ void CopyCounterValueCG_Injected(nint _unity_self, nint src, nint dst, uint dstOffsetBytes);
            static /*0x3e0b4f4*/ void CopyCounterValueGG_Injected(nint _unity_self, nint src, nint dst, uint dstOffsetBytes);
            static /*0x3e0b648*/ void get_name_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x3e0b7f0*/ void set_name_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x3e0b880*/ int get_sizeInBytes_Injected(nint _unity_self);
            static /*0x3e0b908*/ void Clear_Injected(nint _unity_self);
            static /*0x3e0ba6c*/ void Internal_DrawMesh_Injected(nint _unity_self, nint mesh, ref UnityEngine.Matrix4x4 matrix, nint material, int submeshIndex, int shaderPass, nint properties);
            static /*0x3e0bcbc*/ void Internal_DrawMultipleMeshes_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper matrices, UnityEngine.Mesh[] meshes, ref UnityEngine.Bindings.ManagedSpanWrapper subsetIndices, int count, nint material, int shaderPass, nint properties);
            static /*0x3e0be50*/ void Internal_DrawRenderer_Injected(nint _unity_self, nint renderer, nint material, int submeshIndex, int shaderPass);
            static /*0x3e0bf10*/ void Internal_DrawRendererList_Injected(nint _unity_self, ref UnityEngine.Rendering.RendererList rendererList);
            static /*0x3e0c040*/ void Internal_DrawProcedural_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, nint properties);
            static /*0x3e0c1d8*/ void Internal_DrawProceduralIndexed_Injected(nint _unity_self, nint indexBuffer, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, nint properties);
            static /*0x3e0c368*/ void Internal_DrawProceduralIndirect_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x3e0c508*/ void Internal_DrawProceduralIndexedIndirect_Injected(nint _unity_self, nint indexBuffer, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x3e0c698*/ void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x3e0c838*/ void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(nint _unity_self, nint indexBuffer, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x3e0ca5c*/ void Internal_DrawMeshInstanced_Injected(nint _unity_self, nint mesh, int submeshIndex, nint material, int shaderPass, ref UnityEngine.Bindings.ManagedSpanWrapper matrices, int count, nint properties);
            static /*0x3e0cbf8*/ void Internal_DrawMeshInstancedProcedural_Injected(nint _unity_self, nint mesh, int submeshIndex, nint material, int shaderPass, int count, nint properties);
            static /*0x3e0cd9c*/ void Internal_DrawMeshInstancedIndirect_Injected(nint _unity_self, nint mesh, int submeshIndex, nint material, int shaderPass, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x3e0cf48*/ void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(nint _unity_self, nint mesh, int submeshIndex, nint material, int shaderPass, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x3e0d034*/ void Internal_DrawOcclusionMesh_Injected(nint _unity_self, ref UnityEngine.RectInt normalizedCamViewport);
            static /*0x3e0d0dc*/ void SetRandomWriteTarget_Texture_Injected(nint _unity_self, int index, ref UnityEngine.Rendering.RenderTargetIdentifier rt);
            static /*0x3e0d1a8*/ void SetRandomWriteTarget_GraphicsBuffer_Injected(nint _unity_self, int index, nint uav, bool preserveCounterValue);
            static /*0x3e0d250*/ void ClearRandomWriteTargets_Injected(nint _unity_self);
            static /*0x3e0d2f0*/ void SetViewport_Injected(nint _unity_self, ref UnityEngine.Rect pixelRect);
            static /*0x3e0d398*/ void EnableScissorRect_Injected(nint _unity_self, ref UnityEngine.Rect scissor);
            static /*0x3e0d428*/ void DisableScissorRect_Injected(nint _unity_self);
            static /*0x3e0d53c*/ void CopyTexture_Internal_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode);
            static /*0x3e0d728*/ void Blit_Texture_Injected(nint _unity_self, nint source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, nint mat, int pass, ref UnityEngine.Vector2 scale, ref UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            static /*0x3e0d8bc*/ void Blit_Identifier_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, nint mat, int pass, ref UnityEngine.Vector2 scale, ref UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            static /*0x3e0d9c4*/ void GetTemporaryRTWithDescriptor_Injected(nint _unity_self, int nameID, ref UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter);
            static /*0x3e0daa8*/ void ReleaseTemporaryRT_Injected(nint _unity_self, int nameID);
            static /*0x3e0dfd8*/ void SetGlobalFloat_Injected(nint _unity_self, int nameID, float value);
            static /*0x3e0e090*/ void SetGlobalInt_Injected(nint _unity_self, int nameID, int value);
            static /*0x3e0e148*/ void SetGlobalInteger_Injected(nint _unity_self, int nameID, int value);
            static /*0x3e0e208*/ void SetGlobalVector_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector4 value);
            static /*0x3e0e2c8*/ void SetGlobalColor_Injected(nint _unity_self, int nameID, ref UnityEngine.Color value);
            static /*0x3e0e380*/ void SetGlobalMatrix_Injected(nint _unity_self, int nameID, ref UnityEngine.Matrix4x4 value);
            static /*0x3e0e538*/ void EnableShaderKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            static /*0x3e0e5dc*/ void EnableGlobalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.GlobalKeyword keyword);
            static /*0x3e0e6cc*/ void EnableMaterialKeyword_Injected(nint _unity_self, nint material, ref UnityEngine.Rendering.LocalKeyword keyword);
            static /*0x3e0e7cc*/ void EnableComputeKeyword_Injected(nint _unity_self, nint computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            static /*0x3e0e9e8*/ void DisableShaderKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            static /*0x3e0ea8c*/ void DisableGlobalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.GlobalKeyword keyword);
            static /*0x3e0eb7c*/ void DisableMaterialKeyword_Injected(nint _unity_self, nint material, ref UnityEngine.Rendering.LocalKeyword keyword);
            static /*0x3e0ec7c*/ void DisableComputeKeyword_Injected(nint _unity_self, nint computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            static /*0x3e0ed9c*/ void SetGlobalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            static /*0x3e0eea4*/ void SetMaterialKeyword_Injected(nint _unity_self, nint material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            static /*0x3e0efb4*/ void SetComputeKeyword_Injected(nint _unity_self, nint computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            static /*0x3e0f0e0*/ void SetViewProjectionMatrices_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 view, ref UnityEngine.Matrix4x4 proj);
            static /*0x3e0f198*/ void SetGlobalDepthBias_Injected(nint _unity_self, float bias, float slopeBias);
            static /*0x3e0f240*/ void SetExecutionFlags_Injected(nint _unity_self, UnityEngine.Rendering.CommandBufferExecutionFlags flags);
            static /*0x3e0f284*/ bool ValidateAgainstExecutionFlags_Injected(nint _unity_self, UnityEngine.Rendering.CommandBufferExecutionFlags requiredFlags, UnityEngine.Rendering.CommandBufferExecutionFlags invalidFlags);
            static /*0x3e0f33c*/ void SetGlobalFloatArrayListImpl_Injected(nint _unity_self, int nameID, object values);
            static /*0x3e0f3f4*/ void SetGlobalVectorArrayListImpl_Injected(nint _unity_self, int nameID, object values);
            static /*0x3e0f4ac*/ void SetGlobalMatrixArrayListImpl_Injected(nint _unity_self, int nameID, object values);
            static /*0x3e0f614*/ void SetGlobalFloatArray_Injected(nint _unity_self, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x3e0f77c*/ void SetGlobalVectorArray_Injected(nint _unity_self, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x3e0f8e4*/ void SetGlobalMatrixArray_Injected(nint _unity_self, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x3e0fa3c*/ void SetLateLatchProjectionMatrices_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper projectionMat);
            static /*0x3e0fae4*/ void MarkLateLatchMatrixShaderPropertyID_Injected(nint _unity_self, UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            static /*0x3e0fb8c*/ void UnmarkLateLatchMatrix_Injected(nint _unity_self, UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            static /*0x3e0fc3c*/ void SetGlobalTexture_Impl_Injected(nint _unity_self, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderTextureSubElement element);
            static /*0x3e0fd08*/ void SetGlobalBufferInternal_Injected(nint _unity_self, int nameID, nint value);
            static /*0x3e0fdcc*/ void SetGlobalGraphicsBufferInternal_Injected(nint _unity_self, int nameID, nint value);
            static /*0x3e0fe84*/ void SetShadowSamplingMode_Impl_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            static /*0x3e0ff3c*/ void IssuePluginEventInternal_Injected(nint _unity_self, nint callback, int eventID);
            static /*0x3e100f4*/ void BeginSample_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            static /*0x3e1029c*/ void EndSample_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            static /*0x3e10438*/ void BeginSample_CustomSampler_Injected(nint _unity_self, nint sampler);
            static /*0x3e1047c*/ void EndSample_CustomSampler_Injected(nint _unity_self, nint sampler);
            static /*0x3e1052c*/ void IssuePluginEventAndDataInternal_Injected(nint _unity_self, nint callback, int eventID, nint data);
            static /*0x3e1061c*/ void IssuePluginCustomBlitInternal_Injected(nint _unity_self, nint callback, uint command, ref UnityEngine.Rendering.RenderTargetIdentifier source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            static /*0x3e10764*/ void IssuePluginCustomTextureUpdateInternal_Injected(nint _unity_self, nint callback, nint targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2);
            static /*0x3e10858*/ void SetGlobalConstantBufferInternal_Injected(nint _unity_self, nint buffer, int nameID, int offset, int size);
            static /*0x3e1094c*/ void SetGlobalConstantGraphicsBufferInternal_Injected(nint _unity_self, nint buffer, int nameID, int offset, int size);
            static /*0x3e10a0c*/ void IncrementUpdateCount_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier dest);
            static /*0x3e10aa4*/ void SetInstanceMultiplier_Injected(nint _unity_self, uint multiplier);
            static /*0x3e10b3c*/ void SetFoveatedRenderingMode_Injected(nint _unity_self, UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            static /*0x3e10bd4*/ void SetWireframe_Injected(nint _unity_self, bool enable);
            static /*0x3e10c6c*/ void ConfigureFoveatedRendering_Injected(nint _unity_self, nint platformData);
            static /*0x3e12764*/ void ClearRenderTargetSingle_Internal_Injected(nint _unity_self, UnityEngine.Rendering.RTClearFlags clearFlags, ref UnityEngine.Color color, float depth, uint stencil);
            static /*0x3e127d0*/ void ClearRenderTargetMulti_Internal_Injected(nint _unity_self, UnityEngine.Rendering.RTClearFlags clearFlags, ref UnityEngine.Bindings.ManagedSpanWrapper colors, float depth, uint stencil);
            static /*0x3e1283c*/ void SetRenderTargetSingle_Internal_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            static /*0x3e128b0*/ void SetRenderTargetColorDepth_Internal_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier color, ref UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags);
            static /*0x3e1293c*/ void SetRenderTargetMulti_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, ref UnityEngine.Rendering.RenderTargetIdentifier depth, ref UnityEngine.Bindings.ManagedSpanWrapper colorLoadActions, ref UnityEngine.Bindings.ManagedSpanWrapper colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags);
            static /*0x3e129c8*/ void SetRenderTargetColorDepthSubtarget_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier color, ref UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3e12a6c*/ void SetRenderTargetMultiSubtarget_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, ref UnityEngine.Rendering.RenderTargetIdentifier depth, ref UnityEngine.Bindings.ManagedSpanWrapper colorLoadActions, ref UnityEngine.Bindings.ManagedSpanWrapper colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x3e1311c*/ void InternalSetComputeBufferNativeData_Injected(nint _unity_self, nint buffer, nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            static /*0x3e131a0*/ void InternalSetComputeBufferData_Injected(nint _unity_self, nint buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            static /*0x3e13224*/ void InternalSetComputeBufferCounterValue_Injected(nint _unity_self, nint buffer, uint counterValue);
            static /*0x3e13884*/ void InternalSetGraphicsBufferNativeData_Injected(nint _unity_self, nint buffer, nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            static /*0x3e13908*/ void InternalSetGraphicsBufferData_Injected(nint _unity_self, nint buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            static /*0x3e1398c*/ void InternalSetGraphicsBufferCounterValue_Injected(nint _unity_self, nint buffer, uint counterValue);
            static /*0x3e13b8c*/ void BeginRenderPass_Internal_Injected(nint _unity_self, int width, int height, int volumeDepth, int samples, ref UnityEngine.Bindings.ManagedSpanWrapper attachments, int depthAttachmentIndex, ref UnityEngine.Bindings.ManagedSpanWrapper subPasses, ref UnityEngine.Bindings.ManagedSpanWrapper debugNameUtf8);
            static /*0x3e13d78*/ void NextSubPass_Internal_Injected(nint _unity_self);
            static /*0x3e13e20*/ void EndRenderPass_Internal_Injected(nint _unity_self);
            static /*0x3e13f30*/ void SetupCameraProperties_Internal_Injected(nint _unity_self, nint camera);
            static /*0x3e13ff0*/ void InvokeOnRenderObjectCallbacks_Internal_Injected(nint _unity_self);
            /*0x3e14154*/ CommandBuffer();
            /*0x1f310fc*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.ComputeBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.ComputeBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x1f310fc*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.GraphicsBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.GraphicsBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x1f310fc*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x1ffc854*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x1ffc854*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x1ffc854*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3e0700c*/ void Internal_RequestAsyncReadback_1(UnityEngine.ComputeBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x3e0714c*/ void Internal_RequestAsyncReadback_2(UnityEngine.ComputeBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x3e072bc*/ void Internal_RequestAsyncReadback_3(UnityEngine.Texture src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x3e07408*/ void Internal_RequestAsyncReadback_4(UnityEngine.Texture src, int mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x3e07574*/ void Internal_RequestAsyncReadback_5(UnityEngine.Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x3e076f0*/ void Internal_RequestAsyncReadback_6(UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x3e0791c*/ void Internal_RequestAsyncReadback_7(UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x3e07b60*/ void Internal_RequestAsyncReadback_8(UnityEngine.GraphicsBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x3e07ca0*/ void Internal_RequestAsyncReadback_9(UnityEngine.GraphicsBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x3e07e10*/ void SetInvertCulling(bool invertCulling);
            /*0x3e07ea8*/ void Internal_SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x3e07f68*/ nint CreateGPUFence_Internal(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x3e08020*/ void WaitOnGPUFence_Internal(nint fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x3e080d8*/ void ReleaseBuffer();
            /*0x3e08160*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, int nameID, float val);
            /*0x3e08298*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, int nameID, int val);
            /*0x3e083c0*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4 val);
            /*0x3e084f8*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4[] values);
            /*0x3e08690*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x3e087b8*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x3e08950*/ void Internal_SetComputeFloats(UnityEngine.ComputeShader computeShader, int nameID, float[] values);
            /*0x3e08ae8*/ void Internal_SetComputeInts(UnityEngine.ComputeShader computeShader, int nameID, int[] values);
            /*0x3e08c80*/ void Internal_SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3e08df8*/ void Internal_SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x3e08f48*/ void Internal_SetComputeGraphicsBufferHandleParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3e09094*/ void Internal_SetComputeGraphicsBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x3e091e4*/ void Internal_SetComputeConstantComputeBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3e09344*/ void Internal_SetComputeConstantGraphicsBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3e094a4*/ void Internal_DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x3e095fc*/ void Internal_DispatchComputeIndirect(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset);
            /*0x3e0974c*/ void Internal_DispatchComputeIndirectGraphicsBuffer(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset);
            /*0x3e0989c*/ void Internal_SetRayTracingComputeBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x3e099cc*/ void Internal_SetRayTracingGraphicsBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x3e09afc*/ void Internal_SetRayTracingGraphicsBufferHandleParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3e09c28*/ void Internal_SetRayTracingConstantComputeBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3e09d88*/ void Internal_SetRayTracingConstantGraphicsBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3e09ee8*/ void Internal_SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x3e0a010*/ void Internal_SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float val);
            /*0x3e0a148*/ void Internal_SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int val);
            /*0x3e0a270*/ void Internal_SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4 val);
            /*0x3e0a3a8*/ void Internal_SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4[] values);
            /*0x3e0a540*/ void Internal_SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x3e0a668*/ void Internal_SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x3e0a800*/ void Internal_SetRayTracingFloats(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float[] values);
            /*0x3e0a998*/ void Internal_SetRayTracingInts(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int[] values);
            /*0x3e0ab30*/ void Internal_BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure, UnityEngine.Rendering.RayTracingAccelerationStructure.BuildSettings buildSettings);
            /*0x3e0ac40*/ void Internal_SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x3e0ada4*/ void Internal_SetComputeRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x3e0af28*/ void Internal_DispatchRays(UnityEngine.Rendering.RayTracingShader rayTracingShader, string rayGenShaderName, uint width, uint height, uint depth, UnityEngine.Camera camera);
            /*0x3e0b1d0*/ void CopyCounterValueCC(UnityEngine.ComputeBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x3e0b2b0*/ void CopyCounterValueGC(UnityEngine.GraphicsBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x3e0b390*/ void CopyCounterValueCG(UnityEngine.ComputeBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x3e0b470*/ void CopyCounterValueGG(UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x3e0b550*/ string get_name();
            /*0x3e0b68c*/ void set_name(string value);
            /*0x3e0b834*/ int get_sizeInBytes();
            /*0x3e0b8bc*/ void Clear();
            /*0x3e0b944*/ void Internal_DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e0baf0*/ void Internal_DrawMultipleMeshes(UnityEngine.Matrix4x4[] matrices, UnityEngine.Mesh[] meshes, int[] subsetIndices, int count, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e0bd48*/ void Internal_DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x3e0bebc*/ void Internal_DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x3e0bf54*/ void Internal_DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e0c0cc*/ void Internal_DrawProceduralIndexed(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e0c274*/ void Internal_DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e0c3f4*/ void Internal_DrawProceduralIndexedIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e0c5a4*/ void Internal_DrawProceduralIndirectGraphicsBuffer(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e0c724*/ void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e0c8d4*/ void Internal_DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e0cae8*/ void Internal_DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e0cc7c*/ void Internal_DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e0ce28*/ void Internal_DrawMeshInstancedIndirectGraphicsBuffer(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e0cfd4*/ void Internal_DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
            /*0x3e0d078*/ void SetRandomWriteTarget_Texture(int index, ref UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x3e0d130*/ void SetRandomWriteTarget_GraphicsBuffer(int index, UnityEngine.GraphicsBuffer uav, bool preserveCounterValue);
            /*0x3e0d204*/ void ClearRandomWriteTargets();
            /*0x3e0d28c*/ void SetViewport(UnityEngine.Rect pixelRect);
            /*0x3e0d334*/ void EnableScissorRect(UnityEngine.Rect scissor);
            /*0x3e0d3dc*/ void DisableScissorRect();
            /*0x3e0d464*/ void CopyTexture_Internal(ref UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode);
            /*0x3e0d604*/ void Blit_Texture(UnityEngine.Texture source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Material mat, int pass, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            /*0x3e0d7c4*/ void Blit_Identifier(ref UnityEngine.Rendering.RenderTargetIdentifier source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Material mat, int pass, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            /*0x3e0d958*/ void GetTemporaryRTWithDescriptor(int nameID, UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter);
            /*0x3e0da20*/ void GetTemporaryRT(int nameID, UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter);
            /*0x3e0da54*/ void ReleaseTemporaryRT(int nameID);
            /*0x3e0daec*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
            /*0x3e0db90*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
            /*0x3e0daf8*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x3e0dc88*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x3e0dd00*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color[] backgroundColors, float depth, uint stencil);
            /*0x3e0df74*/ void SetGlobalFloat(int nameID, float value);
            /*0x3e0e02c*/ void SetGlobalInt(int nameID, int value);
            /*0x3e0e0e4*/ void SetGlobalInteger(int nameID, int value);
            /*0x3e0e19c*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            /*0x3e0e25c*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x3e0e31c*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x3e0e3d4*/ void EnableShaderKeyword(string keyword);
            /*0x3e0e57c*/ void EnableGlobalKeyword(UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3e0e620*/ void EnableMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3e0e720*/ void EnableComputeKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3e0e820*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3e0e82c*/ void EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3e0e858*/ void EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3e0e884*/ void DisableShaderKeyword(string keyword);
            /*0x3e0ea2c*/ void DisableGlobalKeyword(UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3e0ead0*/ void DisableMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3e0ebd0*/ void DisableComputeKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3e0ecd0*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x3e0ecdc*/ void DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3e0ed08*/ void DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x3e0ed34*/ void SetGlobalKeyword(UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x3e0edf0*/ void SetMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3e0ef00*/ void SetComputeKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3e0f010*/ void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x3e0f024*/ void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3e0f050*/ void SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x3e0f07c*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            /*0x3e0f134*/ void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x3e0f1ec*/ void SetExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags flags);
            /*0x3e0db98*/ bool ValidateAgainstExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags requiredFlags, UnityEngine.Rendering.CommandBufferExecutionFlags invalidFlags);
            /*0x3e0f2d8*/ void SetGlobalFloatArrayListImpl(int nameID, object values);
            /*0x3e0f390*/ void SetGlobalVectorArrayListImpl(int nameID, object values);
            /*0x3e0f448*/ void SetGlobalMatrixArrayListImpl(int nameID, object values);
            /*0x3e0f500*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x3e0f668*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x3e0f7d0*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x3e0f938*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x3e0fa80*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x3e0fb38*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x3e0fbd0*/ void SetGlobalTexture_Impl(int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3e0fc98*/ void SetGlobalBufferInternal(int nameID, UnityEngine.ComputeBuffer value);
            /*0x3e0fd5c*/ void SetGlobalGraphicsBufferInternal(int nameID, UnityEngine.GraphicsBuffer value);
            /*0x3e0fe20*/ void SetShadowSamplingMode_Impl(ref UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x3e0fed8*/ void IssuePluginEventInternal(nint callback, int eventID);
            /*0x3e0ff90*/ void BeginSample(string name);
            /*0x3e10138*/ void EndSample(string name);
            /*0x3e102e0*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x3e1038c*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x3e102e4*/ void BeginSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler);
            /*0x3e10390*/ void EndSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler);
            /*0x3e104c0*/ void IssuePluginEventAndDataInternal(nint callback, int eventID, nint data);
            /*0x3e10588*/ void IssuePluginCustomBlitInternal(nint callback, uint command, ref UnityEngine.Rendering.RenderTargetIdentifier source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x3e106a0*/ void IssuePluginCustomTextureUpdateInternal(nint callback, UnityEngine.Texture targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2);
            /*0x3e107d0*/ void SetGlobalConstantBufferInternal(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x3e108c4*/ void SetGlobalConstantGraphicsBufferInternal(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x3e109b8*/ void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x3e10a50*/ void SetInstanceMultiplier(uint multiplier);
            /*0x3e10ae8*/ void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            /*0x3e10b80*/ void SetWireframe(bool enable);
            /*0x3e10c18*/ void ConfigureFoveatedRendering(nint platformData);
            /*0x3e10d44*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x3e10e2c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction);
            /*0x3e10ef0*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x3e10fcc*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x3e110b8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x3e111b0*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3e112dc*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x3e113f8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel);
            /*0x3e11510*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x3e11624*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3e11774*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x3e1186c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x3e11be0*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3e11f8c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3e123e8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding);
            /*0x3e0dbfc*/ void ClearRenderTargetSingle_Internal(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color color, float depth, uint stencil);
            /*0x3e0de6c*/ void ClearRenderTargetMulti_Internal(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color[] colors, float depth, uint stencil);
            /*0x3e10da8*/ void SetRenderTargetSingle_Internal(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x3e1135c*/ void SetRenderTargetColorDepth_Internal(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags);
            /*0x3e119e8*/ void SetRenderTargetMulti_Internal(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags);
            /*0x3e12334*/ void SetRenderTargetColorDepthSubtarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3e11d80*/ void SetRenderTargetMultiSubtarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x3e12b10*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data);
            /*0x1f30ff0*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x3e12d38*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3e12f78*/ void SetBufferCounterValue(UnityEngine.ComputeBuffer buffer, uint counterValue);
            /*0x3e13034*/ void InternalSetComputeBufferNativeData(UnityEngine.ComputeBuffer buffer, nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            /*0x3e12c50*/ void InternalSetComputeBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            /*0x3e12f7c*/ void InternalSetComputeBufferCounterValue(UnityEngine.ComputeBuffer buffer, uint counterValue);
            /*0x3e13278*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data);
            /*0x1f30ff0*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x3e134a0*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x1ffc854*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3e136e0*/ void SetBufferCounterValue(UnityEngine.GraphicsBuffer buffer, uint counterValue);
            /*0x3e1379c*/ void InternalSetGraphicsBufferNativeData(UnityEngine.GraphicsBuffer buffer, nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            /*0x3e133b8*/ void InternalSetGraphicsBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            /*0x3e136e4*/ void InternalSetGraphicsBufferCounterValue(UnityEngine.GraphicsBuffer buffer, uint counterValue);
            /*0x3e139e0*/ void BeginRenderPass_Internal(int width, int height, int volumeDepth, int samples, System.ReadOnlySpan<UnityEngine.Rendering.AttachmentDescriptor> attachments, int depthAttachmentIndex, System.ReadOnlySpan<UnityEngine.Rendering.SubPassDescriptor> subPasses, System.ReadOnlySpan<byte> debugNameUtf8);
            /*0x3e13c28*/ void BeginRenderPass(int width, int height, int volumeDepth, int samples, Unity.Collections.NativeArray<UnityEngine.Rendering.AttachmentDescriptor> attachments, int depthAttachmentIndex, Unity.Collections.NativeArray<UnityEngine.Rendering.SubPassDescriptor> subPasses, System.ReadOnlySpan<byte> debugNameUtf8);
            /*0x3e13d2c*/ void NextSubPass_Internal();
            /*0x3e13db4*/ void NextSubPass();
            /*0x3e13dd4*/ void EndRenderPass_Internal();
            /*0x3e13e5c*/ void EndRenderPass();
            /*0x3e13e7c*/ void SetupCameraProperties_Internal(UnityEngine.Camera camera);
            /*0x3e13f74*/ void SetupCameraProperties(UnityEngine.Camera camera);
            /*0x3e13fa4*/ void InvokeOnRenderObjectCallbacks_Internal();
            /*0x3e1402c*/ void InvokeOnRenderObjectCallbacks();
            /*0x3e1404c*/ void Finalize();
            /*0x3e140f0*/ void Dispose();
            /*0x3e140d8*/ void Dispose(bool disposing);
            /*0x3e14198*/ void Release();
            /*0x3e1419c*/ UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence();
            /*0x3e141a8*/ UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x3e141e0*/ void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence);
            /*0x3e141e8*/ void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStage stage);
            /*0x3e141f8*/ void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x3e142dc*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, string name, float val);
            /*0x3e14320*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, string name, int val);
            /*0x3e1435c*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4 val);
            /*0x3e143c0*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4[] values);
            /*0x3e143fc*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4 val);
            /*0x3e14454*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x3e14490*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, string name, float[] values);
            /*0x3e144cc*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, int nameID, float[] values);
            /*0x3e144d0*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, string name, int[] values);
            /*0x3e1450c*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, int nameID, int[] values);
            /*0x3e14510*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x3e14564*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x3e14570*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x3e145c8*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x3e145d0*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3e14634*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3e14638*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x3e1463c*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.ComputeBuffer buffer);
            /*0x3e14688*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3e14690*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3e146dc*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x3e146e0*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x3e1472c*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3e14730*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3e14784*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3e14788*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3e147dc*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x3e147e0*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset);
            /*0x3e14888*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset);
            /*0x3e14930*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x3e14994*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure, UnityEngine.Vector3 relativeOrigin);
            /*0x3e14a0c*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x3e14a48*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x3e14a4c*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x3e14a98*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x3e14a9c*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer);
            /*0x3e14ad8*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x3e14adc*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x3e14b18*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x3e14b1c*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3e14b58*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x3e14b60*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3e14b64*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x3e14bb8*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3e14bbc*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x3e14c10*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x3e14c4c*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x3e14c50*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float val);
            /*0x3e14c94*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float val);
            /*0x3e14c98*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float[] values);
            /*0x3e14cd4*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float[] values);
            /*0x3e14cd8*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int val);
            /*0x3e14d14*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int val);
            /*0x3e14d18*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int[] values);
            /*0x3e14d54*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int[] values);
            /*0x3e14d58*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4 val);
            /*0x3e14dbc*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4 val);
            /*0x3e14dc0*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4[] values);
            /*0x3e14dfc*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4[] values);
            /*0x3e14e00*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4 val);
            /*0x3e14e58*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x3e14e84*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x3e14ec0*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x3e14ec4*/ void DispatchRays(UnityEngine.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, UnityEngine.Camera camera);
            /*0x3e14ec8*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e150f8*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x3e15128*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex);
            /*0x3e1515c*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material);
            /*0x3e15194*/ void DrawMultipleMeshes(UnityEngine.Matrix4x4[] matrices, UnityEngine.Mesh[] meshes, int[] subsetIndices, int count, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e1523c*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x3e153fc*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex);
            /*0x3e15404*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material);
            /*0x3e15410*/ void DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x3e1543c*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e15570*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount);
            /*0x3e155a0*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount);
            /*0x3e155d4*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e1571c*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount);
            /*0x3e1574c*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount);
            /*0x3e15780*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e15910*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x3e15940*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x3e15974*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e15b20*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x3e15b50*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x3e15b84*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e15d14*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x3e15d44*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x3e15d78*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e15f24*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x3e15f54*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x3e15f88*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e16308*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count);
            /*0x3e16324*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices);
            /*0x3e1634c*/ void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e1657c*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e167b8*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x3e167d4*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x3e167f4*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x3e16a30*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x3e16a4c*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x3e16a6c*/ void DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
            /*0x3e16a70*/ void SetRandomWriteTarget(int index, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x3e16aa8*/ void SetRandomWriteTarget(int index, UnityEngine.GraphicsBuffer buffer, bool preserveCounterValue);
            /*0x3e16af0*/ void SetRandomWriteTarget(int index, UnityEngine.GraphicsBuffer buffer);
            /*0x3e16b2c*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x3e16b30*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x3e16b34*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x3e16b38*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x3e16b3c*/ void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier src, UnityEngine.Rendering.RenderTargetIdentifier dst);
            /*0x3e16b90*/ void Blit(UnityEngine.Texture source, UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x3e16bf0*/ void Blit(UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x3e16c50*/ void SetGlobalFloat(string name, float value);
            /*0x3e16c84*/ void SetGlobalInt(string name, int value);
            /*0x3e16cb8*/ void SetGlobalInteger(string name, int value);
            /*0x3e16cec*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
            /*0x3e16d40*/ void SetGlobalColor(string name, UnityEngine.Color value);
            /*0x3e16d94*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x3e16de4*/ void SetGlobalFloatArray(string propertyName, System.Collections.Generic.List<float> values);
            /*0x3e16e18*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
            /*0x3e16ef4*/ void SetGlobalFloatArray(string propertyName, float[] values);
            /*0x3e16f28*/ void SetGlobalVectorArray(string propertyName, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x3e16f5c*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x3e17038*/ void SetGlobalVectorArray(string propertyName, UnityEngine.Vector4[] values);
            /*0x3e1706c*/ void SetGlobalMatrixArray(string propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x3e170a0*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x3e1717c*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x3e171b0*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderTargetIdentifier value);
            /*0x3e17208*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderTargetIdentifier value);
            /*0x3e17210*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderTargetIdentifier value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3e17204*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderTargetIdentifier value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x3e17268*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
            /*0x3e1729c*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x3e172a0*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
            /*0x3e172d4*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
            /*0x3e172d8*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x3e172dc*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, string name, int offset, int size);
            /*0x3e17328*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x3e1732c*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x3e17378*/ void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x3e173b0*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x3e173b4*/ void IssuePluginEvent(nint callback, int eventID);
            /*0x3e17408*/ void IssuePluginEventAndData(nint callback, int eventID, nint data);
            /*0x3e1749c*/ void IssuePluginCustomBlit(nint callback, uint command, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x3e17504*/ void IssuePluginCustomTextureUpdateV2(nint callback, UnityEngine.Texture targetTexture, uint userData);

            class BindingsMarshaller
            {
                static /*0x3e17550*/ nint ConvertToNative(UnityEngine.Rendering.CommandBuffer commandBuffer);
            }
        }

        class CommandBufferExtensions
        {
            static /*0x3e17564*/ void Internal_SwitchIntoFastMemory(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.FastMemoryFlags fastMemoryFlags, float residency, bool copyContents);
            static /*0x3e1769c*/ void Internal_SwitchOutOfFastMemory(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.RenderTargetIdentifier rt, bool copyContents);
            static /*0x3e177a4*/ void SwitchIntoFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rid, UnityEngine.Rendering.FastMemoryFlags fastMemoryFlags, float residency, bool copyContents);
            static /*0x3e177a8*/ void SwitchOutOfFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rid, bool copyContents);
            static /*0x3e17630*/ void Internal_SwitchIntoFastMemory_Injected(nint cmd, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.FastMemoryFlags fastMemoryFlags, float residency, bool copyContents);
            static /*0x3e17750*/ void Internal_SwitchOutOfFastMemory_Injected(nint cmd, ref UnityEngine.Rendering.RenderTargetIdentifier rt, bool copyContents);
        }

        class SupportedOnRenderPipelineAttribute : System.Attribute
        {
            static /*0x0*/ System.Lazy<System.Type[]> k_DefaultRenderPipelineAsset;
            /*0x10*/ System.Type[] <renderPipelineTypes>k__BackingField;

            static /*0x3e17da4*/ SupportedOnRenderPipelineAttribute();
            static /*0x3e17bd0*/ UnityEngine.Rendering.SupportedOnRenderPipelineAttribute.SupportedMode GetSupportedMode(System.Type[] renderPipelineTypes, System.Type renderPipelineAssetType);
            static /*0x3e17d30*/ bool IsTypeSupportedOnRenderPipeline(System.Type type, System.Type renderPipelineAssetType);
            /*0x3e177b4*/ SupportedOnRenderPipelineAttribute(System.Type renderPipeline);
            /*0x3e17860*/ SupportedOnRenderPipelineAttribute(System.Type[] renderPipeline);
            /*0x3e177ac*/ System.Type[] get_renderPipelineTypes();
            /*0x3e17b68*/ UnityEngine.Rendering.SupportedOnRenderPipelineAttribute.SupportedMode GetSupportedMode(System.Type renderPipelineAssetType);

            enum SupportedMode
            {
                Unsupported = 0,
                Supported = 1,
                SupportedByBaseClass = 2,
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.SupportedOnRenderPipelineAttribute.<> <>9;
                static /*0x8*/ System.Func<System.Type, string> <>9__6_0;

                static /*0x3e17ebc*/ <>c();
                /*0x3e17f24*/ <>c();
                /*0x3e17f2c*/ string <.ctor>b__6_0(System.Type t);
                /*0x3e17f4c*/ System.Type[] <.cctor>b__12_0();
            }
        }

        class Watermark
        {
            static /*0x3e18028*/ bool IsVisible();
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

            static /*0x3e185a4*/ bool op_Equality(UnityEngine.Rendering.SphericalHarmonicsL2 lhs, UnityEngine.Rendering.SphericalHarmonicsL2 rhs);
            static /*0x3e18760*/ bool op_Inequality(UnityEngine.Rendering.SphericalHarmonicsL2 lhs, UnityEngine.Rendering.SphericalHarmonicsL2 rhs);
            /*0x3e18050*/ float get_Item(int rgb, int coefficient);
            /*0x3e18198*/ void set_Item(int rgb, int coefficient, float value);
            /*0x3e182e0*/ int GetHashCode();
            /*0x3e184b4*/ bool Equals(object other);
            /*0x3e1855c*/ bool Equals(UnityEngine.Rendering.SphericalHarmonicsL2 other);
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

            static /*0x3e18be8*/ bool op_Inequality(UnityEngine.Rendering.AttachmentDescriptor left, UnityEngine.Rendering.AttachmentDescriptor right);
            /*0x3e188ac*/ AttachmentDescriptor(UnityEngine.Experimental.Rendering.GraphicsFormat format);
            /*0x3e187ac*/ void set_loadAction(UnityEngine.Rendering.RenderBufferLoadAction value);
            /*0x3e187b4*/ void set_storeAction(UnityEngine.Rendering.RenderBufferStoreAction value);
            /*0x3e187bc*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
            /*0x3e187c4*/ UnityEngine.Rendering.RenderTargetIdentifier get_loadStoreTarget();
            /*0x3e187d8*/ void set_loadStoreTarget(UnityEngine.Rendering.RenderTargetIdentifier value);
            /*0x3e187ec*/ void set_resolveTarget(UnityEngine.Rendering.RenderTargetIdentifier value);
            /*0x3e18804*/ void set_clearColor(UnityEngine.Color value);
            /*0x3e18810*/ void set_clearDepth(float value);
            /*0x3e18818*/ void set_clearStencil(uint value);
            /*0x3e18820*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier target, bool loadExistingContents, bool storeResults);
            /*0x3e18864*/ void ConfigureResolveTarget(UnityEngine.Rendering.RenderTargetIdentifier target);
            /*0x3e18890*/ void ConfigureClear(UnityEngine.Color clearColor, float clearDepth, uint clearStencil);
            /*0x3e18950*/ bool Equals(UnityEngine.Rendering.AttachmentDescriptor other);
            /*0x3e18a64*/ bool Equals(object obj);
            /*0x3e18af4*/ int GetHashCode();
        }

        enum SubPassFlags
        {
            None = 0,
            ReadOnlyDepth = 2,
            ReadOnlyStencil = 4,
            ReadOnlyDepthStencil = 6,
        }

        struct AttachmentIndexArray
        {
            static /*0x0*/ UnityEngine.Rendering.AttachmentIndexArray Emtpy;
            /*0x10*/ int a0;
            /*0x14*/ int a1;
            /*0x18*/ int a2;
            /*0x1c*/ int a3;
            /*0x20*/ int a4;
            /*0x24*/ int a5;
            /*0x28*/ int a6;
            /*0x2c*/ int a7;
            /*0x30*/ int activeAttachments;

            static /*0x3e18e2c*/ AttachmentIndexArray();
            /*0x3e18c20*/ AttachmentIndexArray(int numAttachments);
            /*0x3e18cb4*/ int get_Item(int index);
            /*0x3e18d6c*/ void set_Item(int index, int value);
            /*0x3e18e24*/ int get_Length();
        }

        struct SubPassDescriptor
        {
            /*0x10*/ UnityEngine.Rendering.AttachmentIndexArray inputs;
            /*0x34*/ UnityEngine.Rendering.AttachmentIndexArray colorOutputs;
            /*0x58*/ UnityEngine.Rendering.SubPassFlags flags;
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

            static /*0x3e18e7c*/ UnityEngine.Rendering.BlendState get_defaultValue();
            /*0x3e18ec4*/ BlendState(bool separateMRTBlend, bool alphaToMask);
            /*0x3e18f68*/ void set_blendState0(UnityEngine.Rendering.RenderTargetBlendState value);
            /*0x3e18f70*/ bool Equals(UnityEngine.Rendering.BlendState other);
            /*0x3e190a8*/ bool Equals(object obj);
            /*0x3e19138*/ int GetHashCode();
        }

        struct CoreCameraValues : System.IEquatable<UnityEngine.Rendering.CoreCameraValues>
        {
            /*0x10*/ int filterMode;
            /*0x14*/ uint cullingMask;
            /*0x18*/ int instanceID;

            /*0x3e19294*/ bool Equals(UnityEngine.Rendering.CoreCameraValues other);
            /*0x3e192c8*/ bool Equals(object obj);
            /*0x3e19360*/ int GetHashCode();
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
            /*0x3f0*/ bool useInteractiveLightBakingData;

            /*0x3e19380*/ UnityEngine.Plane GetShadowCullingPlane(int index);
            /*0x3e19450*/ UnityEngine.Plane GetCameraCullingPlane(int index);
            /*0x3e19520*/ bool Equals(UnityEngine.Rendering.CameraProperties other);
            /*0x3e19b64*/ bool Equals(object obj);
            /*0x3e19c1c*/ int GetHashCode();

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
            /*0x10*/ UnityEngine.Rendering.LODParameters m_LODParameters;
            /*0x2c*/ UnityEngine.Rendering.ScriptableCullingParameters.<m_CullingPlanes> m_CullingPlanes;
            /*0xcc*/ int m_CullingPlaneCount;
            /*0xd0*/ uint m_CullingMask;
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
            /*0x5ac*/ float m_AccurateOcclusionThreshold;
            /*0x5b0*/ int m_MaximumPortalCullingJobs;
            /*0x5b4*/ UnityEngine.Matrix4x4 m_StereoViewMatrix;
            /*0x5f4*/ UnityEngine.Matrix4x4 m_StereoProjectionMatrix;
            /*0x634*/ float m_StereoSeparationDistance;
            /*0x638*/ int m_maximumVisibleLights;
            /*0x63c*/ bool m_ConservativeEnclosingSphere;
            /*0x640*/ int m_NumIterationsEnclosingSphere;

            static /*0x3e1aae4*/ ScriptableCullingParameters();
            /*0x3e1a074*/ void set_maximumVisibleLights(int value);
            /*0x3e1a07c*/ void set_conservativeEnclosingSphere(bool value);
            /*0x3e1a084*/ void set_numIterationsEnclosingSphere(int value);
            /*0x3e1a08c*/ int get_cullingPlaneCount();
            /*0x3e1a094*/ void set_shadowDistance(float value);
            /*0x3e1a09c*/ UnityEngine.Rendering.CullingOptions get_cullingOptions();
            /*0x3e1a0a4*/ void set_cullingOptions(UnityEngine.Rendering.CullingOptions value);
            /*0x3e1a0ac*/ void set_reflectionProbeSortingCriteria(UnityEngine.Rendering.ReflectionProbeSortingCriteria value);
            /*0x3e1a0b4*/ float GetLayerCullingDistance(int layerIndex);
            /*0x3e1a178*/ UnityEngine.Plane GetCullingPlane(int index);
            /*0x3e1a2a4*/ bool Equals(UnityEngine.Rendering.ScriptableCullingParameters other);
            /*0x3e1a718*/ bool Equals(object obj);
            /*0x3e1a814*/ int GetHashCode();

            struct <m_CullingPlanes>e__FixedBuffer
            {
                /*0x10*/ byte FixedElementField;
            }

            struct <m_LayerFarCullDistances>e__FixedBuffer
            {
                /*0x10*/ float FixedElementField;
            }
        }

        struct LightShadowCasterCullingInfo
        {
            /*0x10*/ UnityEngine.RangeInt splitRange;
            /*0x18*/ UnityEngine.Rendering.BatchCullingProjectionType projectionType;
            /*0x1c*/ ushort splitExclusionMask;
        }

        struct ShadowCastersCullingInfos
        {
            /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.ShadowSplitData> splitBuffer;
            /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.LightShadowCasterCullingInfo> perLightInfos;
        }

        struct CullingResults : System.IEquatable<UnityEngine.Rendering.CullingResults>
        {
            /*0x10*/ nint ptr;
            /*0x18*/ UnityEngine.Rendering.CullingAllocationInfo* m_AllocationInfo;

            static /*0x3e1ab34*/ int GetLightIndexCount(nint cullingResultsPtr);
            static /*0x3e1ab70*/ int GetReflectionProbeIndexCount(nint cullingResultsPtr);
            static /*0x3e1abac*/ void FillLightAndReflectionProbeIndices(nint cullingResultsPtr, UnityEngine.ComputeBuffer computeBuffer);
            static /*0x3e1ac40*/ int GetLightIndexMapSize(nint cullingResultsPtr);
            static /*0x3e1ac7c*/ void FillLightIndexMap(nint cullingResultsPtr, nint indexMapPtr, int indexMapSize);
            static /*0x3e1acd0*/ void SetLightIndexMap(nint cullingResultsPtr, nint indexMapPtr, int indexMapSize);
            static /*0x3e1ad24*/ bool GetShadowCasterBounds(nint cullingResultsPtr, int lightIndex, ref UnityEngine.Bounds bounds);
            static /*0x3e1ad78*/ bool ComputeSpotShadowMatricesAndCullingPrimitives(nint cullingResultsPtr, int activeLightIndex, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            static /*0x3e1ade4*/ bool ComputePointShadowMatricesAndCullingPrimitives(nint cullingResultsPtr, int activeLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            static /*0x3e1ae68*/ bool ComputeDirectionalShadowMatricesAndCullingPrimitives(nint cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, UnityEngine.Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            static /*0x3e1b5f0*/ bool op_Equality(UnityEngine.Rendering.CullingResults left, UnityEngine.Rendering.CullingResults right);
            static /*0x3e1abfc*/ void FillLightAndReflectionProbeIndices_Injected(nint cullingResultsPtr, nint computeBuffer);
            static /*0x3e1af20*/ bool ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(nint cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, ref UnityEngine.Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x3e1afcc*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> get_visibleLights();
            /*0x3e1b028*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleReflectionProbe> get_visibleReflectionProbes();
            /*0x1ffc854*/ Unity.Collections.NativeArray<T> GetNativeArray<T>(void* dataPointer, int length);
            /*0x3e1b084*/ int get_lightAndReflectionProbeIndexCount();
            /*0x3e1b0fc*/ void FillLightAndReflectionProbeIndices(UnityEngine.ComputeBuffer computeBuffer);
            /*0x3e1b14c*/ Unity.Collections.NativeArray<int> GetLightIndexMap(Unity.Collections.Allocator allocator);
            /*0x3e1b258*/ void SetLightIndexMap(Unity.Collections.NativeArray<int> lightIndexMap);
            /*0x3e1b2f4*/ bool GetShadowCasterBounds(int lightIndex, ref UnityEngine.Bounds outBounds);
            /*0x3e1b348*/ bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x3e1b3b4*/ bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x3e1b438*/ bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, UnityEngine.Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x3e1b4f0*/ bool Equals(UnityEngine.Rendering.CullingResults other);
            /*0x3e1b54c*/ bool Equals(object obj);
            /*0x3e1b5c8*/ int GetHashCode();
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

            static /*0x3e1b61c*/ UnityEngine.Rendering.DepthState get_defaultValue();
            /*0x3e1b640*/ DepthState(bool writeEnabled, UnityEngine.Rendering.CompareFunction compareFunction);
            /*0x3e1b6b4*/ UnityEngine.Rendering.CompareFunction get_compareFunction();
            /*0x3e1b6bc*/ bool Equals(UnityEngine.Rendering.DepthState other);
            /*0x3e1b6e4*/ bool Equals(object obj);
            /*0x3e1b76c*/ int GetHashCode();
        }

        enum DrawRendererFlags
        {
            None = 0,
            EnableDynamicBatching = 1,
            EnableInstancing = 2,
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

            static /*0x3e1c08c*/ DrawingSettings();
            static /*0x3e1bfd0*/ bool op_Equality(UnityEngine.Rendering.DrawingSettings left, UnityEngine.Rendering.DrawingSettings right);
            /*0x3e1b7a8*/ DrawingSettings(UnityEngine.Rendering.ShaderTagId shaderPassName, UnityEngine.Rendering.SortingSettings sortingSettings);
            /*0x3e1b874*/ void set_perObjectData(UnityEngine.Rendering.PerObjectData value);
            /*0x3e1b87c*/ void set_enableDynamicBatching(bool value);
            /*0x3e1b88c*/ void set_enableInstancing(bool value);
            /*0x3e1b8ac*/ void set_overrideMaterial(UnityEngine.Material value);
            /*0x3e1b8d8*/ void set_overrideShader(UnityEngine.Shader value);
            /*0x3e1b904*/ void set_overrideMaterialPassIndex(int value);
            /*0x3e1b90c*/ void set_overrideShaderPassIndex(int value);
            /*0x3e1b914*/ void set_mainLightIndex(int value);
            /*0x3e1b91c*/ UnityEngine.Rendering.ShaderTagId GetShaderPassName(int index);
            /*0x3e1ba60*/ void SetShaderPassName(int index, UnityEngine.Rendering.ShaderTagId shaderPassName);
            /*0x3e1bba8*/ bool Equals(UnityEngine.Rendering.DrawingSettings other);
            /*0x3e1bdc0*/ bool Equals(object obj);
            /*0x3e1bebc*/ int GetHashCode();

            struct <shaderPassNames>e__FixedBuffer
            {
                /*0x10*/ int FixedElementField;
            }
        }

        struct FilteringSettings : System.IEquatable<UnityEngine.Rendering.FilteringSettings>
        {
            /*0x10*/ UnityEngine.Rendering.RenderQueueRange m_RenderQueueRange;
            /*0x18*/ int m_LayerMask;
            /*0x1c*/ uint m_RenderingLayerMask;
            /*0x20*/ uint m_BatchLayerMask;
            /*0x24*/ int m_ExcludeMotionVectorObjects;
            /*0x28*/ int m_ForceAllMotionVectorObjects;
            /*0x2c*/ UnityEngine.Rendering.SortingLayerRange m_SortingLayerRange;

            static /*0x3e1c4b8*/ bool op_Equality(UnityEngine.Rendering.FilteringSettings left, UnityEngine.Rendering.FilteringSettings right);
            /*0x3e1c0d8*/ FilteringSettings(System.Nullable<UnityEngine.Rendering.RenderQueueRange> renderQueueRange, int layerMask, uint renderingLayerMask, int excludeMotionVectorObjects);
            /*0x3e1c270*/ UnityEngine.Rendering.RenderQueueRange get_renderQueueRange();
            /*0x3e1c278*/ void set_batchLayerMask(uint value);
            /*0x3e1c280*/ void set_excludeMotionVectorObjects(bool value);
            /*0x3e1c28c*/ bool Equals(UnityEngine.Rendering.FilteringSettings other);
            /*0x3e1c388*/ bool Equals(object obj);
            /*0x3e1c410*/ int GetHashCode();
        }

        enum GizmoSubset
        {
            PreImageEffects = 0,
            PostImageEffects = 1,
        }

        class InvalidImportException : System.Exception
        {
        }

        struct LODParameters : System.IEquatable<UnityEngine.Rendering.LODParameters>
        {
            /*0x10*/ int m_IsOrthographic;
            /*0x14*/ UnityEngine.Vector3 m_CameraPosition;
            /*0x20*/ float m_FieldOfView;
            /*0x24*/ float m_OrthoSize;
            /*0x28*/ int m_CameraPixelHeight;

            /*0x3e1c4e0*/ bool get_isOrthographic();
            /*0x3e1c53c*/ UnityEngine.Vector3 get_cameraPosition();
            /*0x3e1c548*/ float get_fieldOfView();
            /*0x3e1c550*/ float get_orthoSize();
            /*0x3e1a674*/ bool Equals(UnityEngine.Rendering.LODParameters other);
            /*0x3e1c558*/ bool Equals(object obj);
            /*0x3e1aa50*/ int GetHashCode();
        }

        class ObjectIdRequest
        {
            /*0x10*/ UnityEngine.RenderTexture <destination>k__BackingField;

            /*0x3e1c5e8*/ UnityEngine.RenderTexture get_destination();
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

            static /*0x3e1c81c*/ RasterState();
            /*0x3e1c5f0*/ RasterState(UnityEngine.Rendering.CullMode cullingMode, int offsetUnits, float offsetFactor, bool depthClip);
            /*0x3e1c694*/ bool Equals(UnityEngine.Rendering.RasterState other);
            /*0x3e1c710*/ bool Equals(object obj);
            /*0x3e1c7bc*/ int GetHashCode();
        }

        enum ReflectionProbeSortingCriteria
        {
            None = 0,
            Importance = 1,
            Size = 2,
            ImportanceThenSize = 3,
        }

        class RenderPipeline
        {
            /*0x10*/ bool <disposed>k__BackingField;

            static /*0x3e1c88c*/ void BeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x3e1c9dc*/ void BeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            static /*0x3e1cac8*/ void EndContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x3e1cc18*/ void EndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            /*0x3e1ce88*/ RenderPipeline();
            void Render(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera[] cameras);
            /*0x1ffc854*/ void ProcessRenderRequests<RequestData>(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, RequestData renderRequest);
            /*0x1ffc854*/ bool IsRenderRequestSupported<RequestData>(UnityEngine.Camera camera, RequestData data);
            /*0x3e1cd04*/ void Render(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x3e1cd7c*/ void InternalRender(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x1ffc854*/ void InternalProcessRenderRequests<RequestData>(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, RequestData renderRequest);
            /*0x3e1cdf4*/ bool get_disposed();
            /*0x3e1cdfc*/ void set_disposed(bool value);
            /*0x3e1ce04*/ void Dispose();
            /*0x3e1ce7c*/ void Dispose(bool disposing);
            /*0x3e1ce80*/ UnityEngine.Rendering.RenderPipelineGlobalSettings get_defaultSettings();

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
            /*0x3e1d4d0*/ RenderPipelineAsset();
            /*0x3e1ce90*/ UnityEngine.Rendering.RenderPipeline InternalCreatePipeline();
            /*0x3e1cf6c*/ UnityEngine.Material get_defaultMaterial();
            /*0x3e1cf74*/ UnityEngine.Shader get_autodeskInteractiveShader();
            /*0x3e1cf7c*/ UnityEngine.Shader get_autodeskInteractiveTransparentShader();
            /*0x3e1cf84*/ UnityEngine.Shader get_autodeskInteractiveMaskedShader();
            /*0x3e1cf8c*/ UnityEngine.Shader get_terrainDetailLitShader();
            /*0x3e1cf94*/ UnityEngine.Shader get_terrainDetailGrassShader();
            /*0x3e1cf9c*/ UnityEngine.Shader get_terrainDetailGrassBillboardShader();
            /*0x3e1cfa4*/ UnityEngine.Material get_defaultParticleMaterial();
            /*0x3e1cfac*/ UnityEngine.Material get_defaultLineMaterial();
            /*0x3e1cfb4*/ UnityEngine.Material get_defaultTerrainMaterial();
            /*0x3e1cfbc*/ UnityEngine.Material get_defaultUIMaterial();
            /*0x3e1cfc4*/ UnityEngine.Material get_defaultUIOverdrawMaterial();
            /*0x3e1cfcc*/ UnityEngine.Material get_defaultUIETC1SupportedMaterial();
            /*0x3e1cfd4*/ UnityEngine.Material get_default2DMaterial();
            /*0x3e1cfdc*/ UnityEngine.Material get_default2DMaskMaterial();
            /*0x3e1cfe4*/ UnityEngine.Shader get_defaultShader();
            /*0x3e1cfec*/ UnityEngine.Shader get_defaultSpeedTree7Shader();
            /*0x3e1cff4*/ UnityEngine.Shader get_defaultSpeedTree8Shader();
            /*0x3e1cffc*/ UnityEngine.Shader get_defaultSpeedTree9Shader();
            /*0x3e1d004*/ string get_renderPipelineShaderTag();
            /*0x1f30214*/ UnityEngine.Rendering.RenderPipeline CreatePipeline();
            /*0x3e1d084*/ System.Type get_pipelineType();
            /*0x3e1d0f4*/ string get_pipelineTypeFullName();
            /*0x3e1d13c*/ void EnsureGlobalSettings();
            /*0x3e1d140*/ void OnValidate();
            /*0x3e1d24c*/ void OnDisable();
            /*0x3e1d450*/ System.Type get_renderPipelineType();
            /*0x3e1d4c0*/ string[] get_renderingLayerMaskNames();
            /*0x3e1d4c8*/ string[] get_prefixedRenderingLayerMaskNames();
        }

        class RenderPipelineAsset<TRenderPipeline> : UnityEngine.Rendering.RenderPipelineAsset
        {
            /*0x1f309e4*/ RenderPipelineAsset();
            /*0x1f30214*/ System.Type get_pipelineType();
            /*0x1f30214*/ string get_renderPipelineShaderTag();
            /*0x1f30214*/ System.Type get_renderPipelineType();
        }

        class RenderPipelineGlobalSettings : UnityEngine.ScriptableObject, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x18*/ System.Collections.Generic.Dictionary<System.Type, int> <settingsMap>k__BackingField;

            /*0x3e1d9cc*/ RenderPipelineGlobalSettings();
            /*0x3e1d4d8*/ System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> get_settingsList();
            /*0x3e1d70c*/ System.Collections.Generic.Dictionary<System.Type, int> get_settingsMap();
            /*0x3e1d714*/ void RecreateSettingsMap();
            /*0x3e1d850*/ bool TryGet(System.Type type, ref UnityEngine.Rendering.IRenderPipelineGraphicsSettings settings);
            /*0x1f2fec8*/ bool TryGetFirstSettingsImplementingInterface<TSettingsInterfaceType>(ref TSettingsInterfaceType settings);
            /*0x1f2fec8*/ bool GetSettingsImplementingInterface<TSettingsInterfaceType>(ref System.Collections.Generic.List<TSettingsInterfaceType> settings);
            /*0x3e1d94c*/ bool Contains(System.Type type);
            /*0x3e1d9c4*/ void OnBeforeSerialize();
            /*0x3e1d9c8*/ void OnAfterDeserialize();
        }

        class RenderPipelineManager
        {
            static /*0x0*/ bool s_CleanUpPipeline;
            static /*0x8*/ string s_CurrentPipelineType;
            static /*0x10*/ UnityEngine.Rendering.RenderPipelineAsset s_CurrentPipelineAsset;
            static /*0x18*/ UnityEngine.Rendering.RenderPipeline s_CurrentPipeline;
            static /*0x20*/ System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> beginContextRendering;
            static /*0x28*/ System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> endContextRendering;
            static /*0x30*/ System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> beginCameraRendering;
            static /*0x38*/ System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> endCameraRendering;
            static /*0x40*/ System.Action activeRenderPipelineTypeChanged;
            static /*0x48*/ System.Action<UnityEngine.Rendering.RenderPipelineAsset, UnityEngine.Rendering.RenderPipelineAsset> activeRenderPipelineAssetChanged;
            static /*0x50*/ System.Action activeRenderPipelineCreated;
            static /*0x58*/ System.Action activeRenderPipelineDisposed;
            static /*0x60*/ System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera[]> beginFrameRendering;
            static /*0x68*/ System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera[]> endFrameRendering;

            static /*0x3e1ecd4*/ RenderPipelineManager();
            static /*0x3e1da54*/ UnityEngine.Rendering.RenderPipeline get_currentPipeline();
            static /*0x3e1daac*/ void set_currentPipeline(UnityEngine.Rendering.RenderPipeline value);
            static /*0x3e1db64*/ void add_beginContextRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> value);
            static /*0x3e1dc58*/ void remove_beginContextRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> value);
            static /*0x3e1dd4c*/ void add_endContextRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> value);
            static /*0x3e1de40*/ void remove_endContextRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> value);
            static /*0x3e1df34*/ void add_beginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x3e1e028*/ void remove_beginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x3e1e11c*/ void add_endCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x3e1e210*/ void remove_endCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x3e1c8f0*/ void BeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x3e1ca40*/ void BeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            static /*0x3e1cb2c*/ void EndContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x3e1cc7c*/ void EndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            static /*0x3e1e304*/ void OnActiveRenderPipelineTypeChanged();
            static /*0x3e1e378*/ void OnActiveRenderPipelineAssetChanged(UnityEngine.ScriptableObject from, UnityEngine.ScriptableObject to);
            static /*0x3e1e484*/ void HandleRenderPipelineChange(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset);
            static /*0x3e1d194*/ void RecreateCurrentPipeline(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset);
            static /*0x3e1d298*/ void CleanupRenderPipeline();
            static /*0x3e1e628*/ string GetCurrentPipelineAssetType();
            static /*0x3e1e680*/ void DoRenderLoop_Internal(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset, nint loopPtr, UnityEngine.Object renderRequest);
            static /*0x3e1e980*/ bool TryPrepareRenderPipeline(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset);
            static /*0x3e1e520*/ bool get_isCurrentPipelineValid();
            static /*0x3e1eb88*/ bool IsPipelineRequireCreation();
        }

        struct RenderQueueRange : System.IEquatable<UnityEngine.Rendering.RenderQueueRange>
        {
            static int k_MinimumBound = 0;
            static int k_MaximumBound = 5000;
            static /*0x0*/ int minimumBound;
            static /*0x4*/ int maximumBound;
            /*0x10*/ int m_LowerBound;
            /*0x14*/ int m_UpperBound;

            static /*0x3e1ee8c*/ RenderQueueRange();
            static /*0x3e1c260*/ UnityEngine.Rendering.RenderQueueRange get_all();
            static /*0x3e1ed4c*/ UnityEngine.Rendering.RenderQueueRange get_opaque();
            static /*0x3e1ed54*/ UnityEngine.Rendering.RenderQueueRange get_transparent();
            static /*0x3e1ee28*/ bool op_Equality(UnityEngine.Rendering.RenderQueueRange left, UnityEngine.Rendering.RenderQueueRange right);
            /*0x3e1ed60*/ int get_lowerBound();
            /*0x3e1ed68*/ int get_upperBound();
            /*0x3e1c360*/ bool Equals(UnityEngine.Rendering.RenderQueueRange other);
            /*0x3e1ed70*/ bool Equals(object obj);
            /*0x3e1c4a4*/ int GetHashCode();
        }

        struct RenderStateBlock : System.IEquatable<UnityEngine.Rendering.RenderStateBlock>
        {
            /*0x10*/ UnityEngine.Rendering.BlendState m_BlendState;
            /*0x54*/ UnityEngine.Rendering.RasterState m_RasterState;
            /*0x64*/ UnityEngine.Rendering.DepthState m_DepthState;
            /*0x66*/ UnityEngine.Rendering.StencilState m_StencilState;
            /*0x74*/ int m_StencilReference;
            /*0x78*/ UnityEngine.Rendering.RenderStateMask m_Mask;

            /*0x3e1eedc*/ RenderStateBlock(UnityEngine.Rendering.RenderStateMask mask);
            /*0x3e1f008*/ void set_blendState(UnityEngine.Rendering.BlendState value);
            /*0x3e1f010*/ void set_rasterState(UnityEngine.Rendering.RasterState value);
            /*0x3e1f01c*/ UnityEngine.Rendering.DepthState get_depthState();
            /*0x3e1f024*/ void set_depthState(UnityEngine.Rendering.DepthState value);
            /*0x3e1f02c*/ UnityEngine.Rendering.StencilState get_stencilState();
            /*0x3e1f03c*/ void set_stencilState(UnityEngine.Rendering.StencilState value);
            /*0x3e1f048*/ int get_stencilReference();
            /*0x3e1f050*/ void set_stencilReference(int value);
            /*0x3e1f058*/ UnityEngine.Rendering.RenderStateMask get_mask();
            /*0x3e1f060*/ void set_mask(UnityEngine.Rendering.RenderStateMask value);
            /*0x3e1f068*/ bool Equals(UnityEngine.Rendering.RenderStateBlock other);
            /*0x3e1f214*/ bool Equals(object obj);
            /*0x3e1f2a4*/ int GetHashCode();
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

            static /*0x3e18f5c*/ UnityEngine.Rendering.RenderTargetBlendState get_defaultValue();
            /*0x3e1f460*/ RenderTargetBlendState(UnityEngine.Rendering.ColorWriteMask writeMask, UnityEngine.Rendering.BlendMode sourceColorBlendMode, UnityEngine.Rendering.BlendMode destinationColorBlendMode, UnityEngine.Rendering.BlendMode sourceAlphaBlendMode, UnityEngine.Rendering.BlendMode destinationAlphaBlendMode, UnityEngine.Rendering.BlendOp colorBlendOperation, UnityEngine.Rendering.BlendOp alphaBlendOperation);
            /*0x3e19030*/ bool Equals(UnityEngine.Rendering.RenderTargetBlendState other);
            /*0x3e1f484*/ bool Equals(object obj);
            /*0x3e191f4*/ int GetHashCode();
        }

        struct RendererList
        {
            static /*0x0*/ UnityEngine.Rendering.RendererList nullRendererList;
            /*0x10*/ nuint context;
            /*0x18*/ uint index;
            /*0x1c*/ uint frame;
            /*0x20*/ uint type;
            /*0x24*/ uint contextID;

            static /*0x3e1f54c*/ RendererList();
            /*0x3e1f53c*/ RendererList(nuint ctx, uint indx);
            /*0x3e1f500*/ bool get_isValid();
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
            /*0x104*/ UnityEngine.Rendering.ShaderTagId tagName;
            /*0x108*/ bool isPassTagName;
            /*0x110*/ System.Nullable<Unity.Collections.NativeArray<UnityEngine.Rendering.ShaderTagId>> tagValues;
            /*0x128*/ System.Nullable<Unity.Collections.NativeArray<UnityEngine.Rendering.RenderStateBlock>> stateBlocks;

            static /*0x3e20374*/ RendererListParams();
            /*0x3e1f5a0*/ RendererListParams(UnityEngine.Rendering.CullingResults cullingResults, UnityEngine.Rendering.DrawingSettings drawSettings, UnityEngine.Rendering.FilteringSettings filteringSettings);
            /*0x3e1f640*/ int get_numStateBlocks();
            /*0x3e1f6ec*/ nint get_stateBlocksPtr();
            /*0x3e1f7bc*/ nint get_tagsValuePtr();
            /*0x3e1f88c*/ void Validate();
            /*0x3e1fdd4*/ bool Equals(UnityEngine.Rendering.RendererListParams other);
            /*0x3e20134*/ bool Equals(object obj);
            /*0x3e20230*/ int GetHashCode();
        }

        struct ScriptableRenderContext : System.IEquatable<UnityEngine.Rendering.ScriptableRenderContext>
        {
            static /*0x0*/ UnityEngine.Rendering.ShaderTagId kRenderTypeTag;
            /*0x10*/ nint m_Ptr;

            static /*0x3e22c04*/ ScriptableRenderContext();
            static /*0x3e203c0*/ void BeginRenderPass_Internal(nint self, int width, int height, int volumeDepth, int samples, nint colors, int colorCount, int depthAttachmentIndex);
            static /*0x3e2044c*/ void BeginSubPass_Internal(nint self, nint colors, int colorCount, nint inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly);
            static /*0x3e204d0*/ void EndSubPass_Internal(nint self);
            static /*0x3e2050c*/ void EndRenderPass_Internal(nint self);
            static /*0x3e20548*/ bool HasInvokeOnRenderObjectCallbacks_Internal();
            static /*0x3e20570*/ void Internal_Cull(ref UnityEngine.Rendering.ScriptableCullingParameters parameters, UnityEngine.Rendering.ScriptableRenderContext renderLoop, nint results);
            static /*0x3e20654*/ void Internal_CullShadowCasters(UnityEngine.Rendering.ScriptableRenderContext renderLoop, nint context);
            static /*0x3e20720*/ void InitializeSortSettings(UnityEngine.Camera camera, ref UnityEngine.Rendering.SortingSettings sortingSettings);
            static /*0x3e208e0*/ void EmitGeometryForCamera(UnityEngine.Camera camera);
            static /*0x3e20600*/ void Internal_Cull_Injected(ref UnityEngine.Rendering.ScriptableCullingParameters parameters, ref UnityEngine.Rendering.ScriptableRenderContext renderLoop, nint results);
            static /*0x3e206dc*/ void Internal_CullShadowCasters_Injected(ref UnityEngine.Rendering.ScriptableRenderContext renderLoop, nint context);
            static /*0x3e207d0*/ void InitializeSortSettings_Injected(nint camera, ref UnityEngine.Rendering.SortingSettings sortingSettings);
            static /*0x3e20980*/ void EmitGeometryForCamera_Injected(nint camera);
            static /*0x3e20a40*/ void ExecuteCommandBuffer_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint commandBuffer);
            static /*0x3e20b18*/ void ExecuteCommandBufferAsync_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType);
            static /*0x3e20c60*/ void SetupCameraProperties_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera, bool stereoSetup, int eye);
            static /*0x3e20d98*/ void DrawWireOverlay_Impl_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera);
            static /*0x3e20ee4*/ void CreateRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.ShaderTagId tagName, bool isPassTagName, nint tagValues, nint stateBlocks, int stateCount, ref UnityEngine.Rendering.RendererList ret);
            static /*0x3e21038*/ void CreateShadowRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint shadowDrawinSettings, ref UnityEngine.Rendering.RendererList ret);
            static /*0x3e211d0*/ void CreateSkyboxRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera, int mode, ref UnityEngine.Matrix4x4 proj, ref UnityEngine.Matrix4x4 view, ref UnityEngine.Matrix4x4 projR, ref UnityEngine.Matrix4x4 viewR, ref UnityEngine.Rendering.RendererList ret);
            static /*0x3e21370*/ void CreateGizmoRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera, UnityEngine.Rendering.GizmoSubset gizmoSubset, ref UnityEngine.Rendering.RendererList ret);
            static /*0x3e214e0*/ void CreateUIOverlayRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera, UnityEngine.Rendering.UISubset uiSubset, ref UnityEngine.Rendering.RendererList ret);
            static /*0x3e21644*/ void CreateWireOverlayRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera, ref UnityEngine.Rendering.RendererList ret);
            static /*0x3e21760*/ UnityEngine.Rendering.RendererListStatus QueryRendererListStatus_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, ref UnityEngine.Rendering.RendererList handle);
            /*0x3e1eab4*/ ScriptableRenderContext(nint ptr);
            /*0x3e20814*/ void Submit_Internal();
            /*0x3e20850*/ bool SubmitForRenderPassValidation_Internal();
            /*0x3e2088c*/ void GetCameras_Internal(System.Type listType, object resultList);
            /*0x3e209bc*/ void ExecuteCommandBuffer_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer);
            /*0x3e20a84*/ void ExecuteCommandBufferAsync_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType);
            /*0x3e20b6c*/ void SetupCameraProperties_Internal(UnityEngine.Camera camera, bool stereoSetup, int eye);
            /*0x3e20cbc*/ void DrawWireOverlay_Impl(UnityEngine.Camera camera);
            /*0x3e20ddc*/ nint Internal_GetPtr();
            /*0x3e20de4*/ UnityEngine.Rendering.RendererList CreateRendererList_Internal(nint cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, UnityEngine.Rendering.ShaderTagId tagName, bool isPassTagName, nint tagValues, nint stateBlocks, int stateCount);
            /*0x3e20f88*/ UnityEngine.Rendering.RendererList CreateShadowRendererList_Internal(nint shadowDrawinSettings);
            /*0x3e2108c*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList_Internal(UnityEngine.Camera camera, int mode, UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 projR, UnityEngine.Matrix4x4 viewR);
            /*0x3e2125c*/ UnityEngine.Rendering.RendererList CreateGizmoRendererList_Internal(UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset);
            /*0x3e213cc*/ UnityEngine.Rendering.RendererList CreateUIOverlayRendererList_Internal(UnityEngine.Camera camera, UnityEngine.Rendering.UISubset uiSubset);
            /*0x3e2153c*/ UnityEngine.Rendering.RendererList CreateWireOverlayRendererList_Internal(UnityEngine.Camera camera);
            /*0x3e21698*/ void PrepareRendererListsAsync_Internal(object rendererLists);
            /*0x3e216dc*/ UnityEngine.Rendering.RendererListStatus QueryRendererListStatus_Internal(UnityEngine.Rendering.RendererList handle);
            /*0x3e217a4*/ void BeginRenderPass(int width, int height, int samples, Unity.Collections.NativeArray<UnityEngine.Rendering.AttachmentDescriptor> attachments, int depthAttachmentIndex);
            /*0x3e218a4*/ void BeginSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthStencilReadOnly);
            /*0x3e219b0*/ void BeginSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthStencilReadOnly);
            /*0x3e21a90*/ void EndSubPass();
            /*0x3e21b08*/ void EndRenderPass();
            /*0x3e21b80*/ void Submit();
            /*0x3e21bf4*/ bool SubmitForRenderPassValidation();
            /*0x3e21c68*/ bool HasInvokeOnRenderObjectCallbacks();
            /*0x3e1eabc*/ void GetCameras(System.Collections.Generic.List<UnityEngine.Camera> results);
            /*0x3e21cd0*/ void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer commandBuffer);
            /*0x3e21db4*/ void ExecuteCommandBufferAsync(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType);
            /*0x3e21ea8*/ void SetupCameraProperties(UnityEngine.Camera camera, bool stereoSetup);
            /*0x3e21f18*/ void SetupCameraProperties(UnityEngine.Camera camera, bool stereoSetup, int eye);
            /*0x3e21f94*/ void DrawWireOverlay(UnityEngine.Camera camera);
            /*0x3e21ff8*/ UnityEngine.Rendering.CullingResults Cull(ref UnityEngine.Rendering.ScriptableCullingParameters parameters);
            /*0x3e2208c*/ void CullShadowCasters(UnityEngine.Rendering.CullingResults cullingResults, UnityEngine.Rendering.ShadowCastersCullingInfos infos);
            /*0x3e22188*/ bool Equals(UnityEngine.Rendering.ScriptableRenderContext other);
            /*0x3e221cc*/ bool Equals(object obj);
            /*0x3e2229c*/ int GetHashCode();
            /*0x3e222a4*/ UnityEngine.Rendering.RendererList CreateRendererList(ref UnityEngine.Rendering.RendererListParams param);
            /*0x3e223c8*/ UnityEngine.Rendering.RendererList CreateShadowRendererList(ref UnityEngine.Rendering.ShadowDrawingSettings settings);
            /*0x3e2246c*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrixL, UnityEngine.Matrix4x4 viewMatrixL, UnityEngine.Matrix4x4 projectionMatrixR, UnityEngine.Matrix4x4 viewMatrixR);
            /*0x3e225c0*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 viewMatrix);
            /*0x3e2272c*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Camera camera);
            /*0x3e22894*/ UnityEngine.Rendering.RendererList CreateGizmoRendererList(UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset);
            /*0x3e22930*/ UnityEngine.Rendering.RendererList CreateUIOverlayRendererList(UnityEngine.Camera camera);
            /*0x3e229c4*/ UnityEngine.Rendering.RendererList CreateUIOverlayRendererList(UnityEngine.Camera camera, UnityEngine.Rendering.UISubset uiSubset);
            /*0x3e22a60*/ UnityEngine.Rendering.RendererList CreateWireOverlayRendererList(UnityEngine.Camera camera);
            /*0x3e22af0*/ void PrepareRendererListsAsync(System.Collections.Generic.List<UnityEngine.Rendering.RendererList> rendererLists);
            /*0x3e22b74*/ UnityEngine.Rendering.RendererListStatus QueryRendererListStatus(UnityEngine.Rendering.RendererList rendererList);

            struct CullShadowCastersContext
            {
                /*0x10*/ nint cullResults;
                /*0x18*/ UnityEngine.Rendering.ShadowSplitData* splitBuffer;
                /*0x20*/ int splitBufferLength;
                /*0x28*/ UnityEngine.Rendering.LightShadowCasterCullingInfo* perLightInfos;
                /*0x30*/ int perLightInfoCount;
            }
        }

        struct ShaderTagId : System.IEquatable<UnityEngine.Rendering.ShaderTagId>
        {
            static /*0x0*/ UnityEngine.Rendering.ShaderTagId none;
            /*0x10*/ int m_Id;

            static /*0x3e20128*/ bool op_Equality(UnityEngine.Rendering.ShaderTagId tag1, UnityEngine.Rendering.ShaderTagId tag2);
            static /*0x3e22d04*/ bool op_Inequality(UnityEngine.Rendering.ShaderTagId tag1, UnityEngine.Rendering.ShaderTagId tag2);
            /*0x3e22c6c*/ ShaderTagId(string name);
            /*0x3e1b86c*/ int get_id();
            /*0x3e1ba58*/ void set_id(int value);
            /*0x3e22c8c*/ bool Equals(object obj);
            /*0x3e1bce4*/ bool Equals(UnityEngine.Rendering.ShaderTagId other);
            /*0x3e20354*/ int GetHashCode();
        }

        struct ShadowDrawingSettings : System.IEquatable<UnityEngine.Rendering.ShadowDrawingSettings>
        {
            /*0x10*/ UnityEngine.Rendering.CullingResults m_CullingResults;
            /*0x20*/ int m_LightIndex;
            /*0x24*/ int m_SplitIndex;
            /*0x28*/ int m_UseRenderingLayerMaskTest;
            /*0x2c*/ uint m_BatchLayerMask;
            /*0x30*/ UnityEngine.Rendering.ShadowSplitData m_SplitData;
            /*0x12c*/ UnityEngine.ShadowObjectsFilter m_ObjectsFilter;
            /*0x130*/ UnityEngine.Rendering.BatchCullingProjectionType m_ProjectionType;

            /*0x3e22d1c*/ ShadowDrawingSettings(UnityEngine.Rendering.CullingResults cullingResults, int lightIndex);
            /*0x3e22d10*/ void set_useRenderingLayerMaskTest(bool value);
            /*0x3e22e94*/ bool Equals(UnityEngine.Rendering.ShadowDrawingSettings other);
            /*0x3e2316c*/ bool Equals(object obj);
            /*0x3e23224*/ int GetHashCode();
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

            static /*0x3e235c8*/ ShadowSplitData();
            /*0x3e23370*/ int get_cullingPlaneCount();
            /*0x3e23378*/ UnityEngine.Vector4 get_cullingSphere();
            /*0x3e22dc0*/ void set_shadowCascadeBlendCullingFactor(float value);
            /*0x3e23384*/ UnityEngine.Plane GetCullingPlane(int index);
            /*0x3e22ff8*/ bool Equals(UnityEngine.Rendering.ShadowSplitData other);
            /*0x3e234cc*/ bool Equals(object obj);
            /*0x3e232f4*/ int GetHashCode();

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

            static /*0x3e1c268*/ UnityEngine.Rendering.SortingLayerRange get_all();
            /*0x3e23614*/ bool Equals(UnityEngine.Rendering.SortingLayerRange other);
            /*0x3e23638*/ bool Equals(object obj);
            /*0x3e236bc*/ int GetHashCode();
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

            /*0x3e236c4*/ SortingSettings(UnityEngine.Camera camera);
            /*0x3e23728*/ UnityEngine.Rendering.SortingCriteria get_criteria();
            /*0x3e23730*/ void set_criteria(UnityEngine.Rendering.SortingCriteria value);
            /*0x3e1bcf4*/ bool Equals(UnityEngine.Rendering.SortingSettings other);
            /*0x3e23738*/ bool Equals(object obj);
            /*0x3e1bf14*/ int GetHashCode();
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

            static /*0x3e1efac*/ UnityEngine.Rendering.StencilState get_defaultValue();
            /*0x3e237c8*/ StencilState(bool enabled, byte readMask, byte writeMask, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.StencilOp passOperation, UnityEngine.Rendering.StencilOp failOperation, UnityEngine.Rendering.StencilOp zFailOperation);
            /*0x3e237f0*/ StencilState(bool enabled, byte readMask, byte writeMask, UnityEngine.Rendering.CompareFunction compareFunctionFront, UnityEngine.Rendering.StencilOp passOperationFront, UnityEngine.Rendering.StencilOp failOperationFront, UnityEngine.Rendering.StencilOp zFailOperationFront, UnityEngine.Rendering.CompareFunction compareFunctionBack, UnityEngine.Rendering.StencilOp passOperationBack, UnityEngine.Rendering.StencilOp failOperationBack, UnityEngine.Rendering.StencilOp zFailOperationBack);
            /*0x3e238d4*/ bool get_enabled();
            /*0x3e23930*/ void set_enabled(bool value);
            /*0x3e2399c*/ byte get_readMask();
            /*0x3e239a4*/ void set_readMask(byte value);
            /*0x3e239ac*/ byte get_writeMask();
            /*0x3e239b4*/ void set_writeMask(byte value);
            /*0x3e239bc*/ void SetCompareFunction(UnityEngine.Rendering.CompareFunction value);
            /*0x3e239d8*/ void SetPassOperation(UnityEngine.Rendering.StencilOp value);
            /*0x3e239f4*/ void SetFailOperation(UnityEngine.Rendering.StencilOp value);
            /*0x3e23a10*/ void SetZFailOperation(UnityEngine.Rendering.StencilOp value);
            /*0x3e23a2c*/ UnityEngine.Rendering.CompareFunction get_compareFunctionFront();
            /*0x3e239c8*/ void set_compareFunctionFront(UnityEngine.Rendering.CompareFunction value);
            /*0x3e23a34*/ UnityEngine.Rendering.StencilOp get_passOperationFront();
            /*0x3e239e4*/ void set_passOperationFront(UnityEngine.Rendering.StencilOp value);
            /*0x3e23a3c*/ UnityEngine.Rendering.StencilOp get_failOperationFront();
            /*0x3e23a00*/ void set_failOperationFront(UnityEngine.Rendering.StencilOp value);
            /*0x3e23a44*/ UnityEngine.Rendering.StencilOp get_zFailOperationFront();
            /*0x3e23a1c*/ void set_zFailOperationFront(UnityEngine.Rendering.StencilOp value);
            /*0x3e23a4c*/ UnityEngine.Rendering.CompareFunction get_compareFunctionBack();
            /*0x3e239d0*/ void set_compareFunctionBack(UnityEngine.Rendering.CompareFunction value);
            /*0x3e23a54*/ UnityEngine.Rendering.StencilOp get_passOperationBack();
            /*0x3e239ec*/ void set_passOperationBack(UnityEngine.Rendering.StencilOp value);
            /*0x3e23a5c*/ UnityEngine.Rendering.StencilOp get_failOperationBack();
            /*0x3e23a08*/ void set_failOperationBack(UnityEngine.Rendering.StencilOp value);
            /*0x3e23a64*/ UnityEngine.Rendering.StencilOp get_zFailOperationBack();
            /*0x3e23a24*/ void set_zFailOperationBack(UnityEngine.Rendering.StencilOp value);
            /*0x3e1f164*/ bool Equals(UnityEngine.Rendering.StencilState other);
            /*0x3e23a6c*/ bool Equals(object obj);
            /*0x3e1f370*/ int GetHashCode();
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
            /*0x26*/ bool <skyOcclusion>k__BackingField;
            /*0x27*/ bool <lightProbeProxyVolumes>k__BackingField;
            /*0x28*/ bool <motionVectors>k__BackingField;
            /*0x29*/ bool <receiveShadows>k__BackingField;
            /*0x2a*/ bool <reflectionProbes>k__BackingField;
            /*0x2b*/ bool <reflectionProbesBlendDistance>k__BackingField;
            /*0x2c*/ bool <rendererPriority>k__BackingField;
            /*0x2d*/ bool <rendersUIOverlay>k__BackingField;
            /*0x2e*/ bool <overridesEnvironmentLighting>k__BackingField;
            /*0x2f*/ bool <overridesFog>k__BackingField;
            /*0x30*/ bool <overridesRealtimeReflectionProbes>k__BackingField;
            /*0x31*/ bool <overridesOtherLightingSettings>k__BackingField;
            /*0x32*/ bool <editableMaterialRenderQueue>k__BackingField;
            /*0x33*/ bool <overridesLODBias>k__BackingField;
            /*0x34*/ bool <overridesMaximumLODLevel>k__BackingField;
            /*0x35*/ bool <overridesEnableLODCrossFade>k__BackingField;
            /*0x36*/ bool <rendererProbes>k__BackingField;
            /*0x37*/ bool <particleSystemInstancing>k__BackingField;
            /*0x38*/ bool <ambientProbeBaking>k__BackingField;
            /*0x39*/ bool <defaultReflectionProbeBaking>k__BackingField;
            /*0x3a*/ bool <overridesShadowmask>k__BackingField;
            /*0x3b*/ bool <overridesLightProbeSystem>k__BackingField;
            /*0x3c*/ bool <supportsHDR>k__BackingField;
            /*0x3d*/ bool <supportsClouds>k__BackingField;
            /*0x40*/ string <overridesLightProbeSystemWarningMessage>k__BackingField;

            static /*0x3e24358*/ SupportedRenderingFeatures();
            static /*0x3e23aec*/ UnityEngine.Rendering.SupportedRenderingFeatures get_active();
            static /*0x3e1e5c0*/ void set_active(UnityEngine.Rendering.SupportedRenderingFeatures value);
            static /*0x3e23ca4*/ void FallbackMixedLightingModeByRef(nint fallbackModePtr);
            static /*0x3e23dd8*/ bool IsMixedLightingModeSupported(UnityEngine.MixedLightingMode mixedMode);
            static /*0x3e23e44*/ void IsMixedLightingModeSupportedByRef(UnityEngine.MixedLightingMode mixedMode, nint isSupportedPtr);
            static /*0x3e23f4c*/ bool IsLightmapBakeTypeSupported(UnityEngine.LightmapBakeType bakeType);
            static /*0x3e23fb8*/ void IsLightmapBakeTypeSupportedByRef(UnityEngine.LightmapBakeType bakeType, nint isSupportedPtr);
            static /*0x3e240a8*/ void IsLightmapsModeSupportedByRef(UnityEngine.LightmapsMode mode, nint isSupportedPtr);
            static /*0x3e24134*/ void IsLightmapperSupportedByRef(int lightmapper, nint isSupportedPtr);
            static /*0x3e2415c*/ void IsUIOverlayRenderedBySRP(nint isSupportedPtr);
            static /*0x3e241d4*/ void IsAmbientProbeBakingSupported(nint isSupportedPtr);
            static /*0x3e2424c*/ void IsDefaultReflectionProbeBakingSupported(nint isSupportedPtr);
            static /*0x3e242c4*/ void OverridesLightProbeSystem(nint overridesPtr);
            static /*0x3e2433c*/ void FallbackLightmapperByRef(nint lightmapperPtr);
            /*0x3e23b9c*/ SupportedRenderingFeatures();
            /*0x3e23c3c*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_defaultMixedLightingModes();
            /*0x3e23c44*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_mixedLightingModes();
            /*0x3e23c4c*/ UnityEngine.LightmapBakeType get_lightmapBakeTypes();
            /*0x3e23c54*/ UnityEngine.LightmapsMode get_lightmapsModes();
            /*0x3e23c5c*/ bool get_enlighten();
            /*0x3e23c64*/ void set_skyOcclusion(bool value);
            /*0x3e23c6c*/ bool get_rendersUIOverlay();
            /*0x3e23c74*/ void set_rendersUIOverlay(bool value);
            /*0x3e23c7c*/ bool get_ambientProbeBaking();
            /*0x3e23c84*/ bool get_defaultReflectionProbeBaking();
            /*0x3e23c8c*/ bool get_overridesLightProbeSystem();
            /*0x3e23c94*/ void set_overridesLightProbeSystem(bool value);
            /*0x3e23c9c*/ void set_supportsHDR(bool value);

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

        enum UISubset
        {
            UIToolkit_UGUI = 1,
            LowLevel = 2,
            All = -1,
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

            /*0x3e243bc*/ UnityEngine.Light get_light();
            /*0x3e24448*/ UnityEngine.LightType get_lightType();
            /*0x3e24450*/ UnityEngine.Color get_finalColor();
            /*0x3e2445c*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
            /*0x3e24478*/ float get_range();
            /*0x3e24480*/ float get_spotAngle();
            /*0x3e24488*/ bool Equals(UnityEngine.Rendering.VisibleLight other);
            /*0x3e2462c*/ bool Equals(object obj);
            /*0x3e246bc*/ int GetHashCode();
        }

        enum VisibleLightFlags
        {
            IntersectsNearPlane = 1,
            IntersectsFarPlane = 2,
            ForcedVisible = 4,
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

            /*0x3e247b8*/ UnityEngine.Texture get_texture();
            /*0x3e24860*/ UnityEngine.ReflectionProbe get_reflectionProbe();
            /*0x3e248ec*/ UnityEngine.Bounds get_bounds();
            /*0x3e24900*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
            /*0x3e2491c*/ UnityEngine.Vector4 get_hdrData();
            /*0x3e24928*/ float get_blendDistance();
            /*0x3e24930*/ int get_importance();
            /*0x3e24938*/ bool get_isBoxProjection();
            /*0x3e24994*/ bool Equals(UnityEngine.Rendering.VisibleReflectionProbe other);
            /*0x3e24b1c*/ bool Equals(object obj);
            /*0x3e24bac*/ int GetHashCode();
        }

        struct BatchID : System.IEquatable<UnityEngine.Rendering.BatchID>
        {
            static /*0x0*/ UnityEngine.Rendering.BatchID Null;
            /*0x10*/ uint value;

            static /*0x3e24e14*/ BatchID();
            /*0x3e24d54*/ int GetHashCode();
            /*0x3e24d5c*/ bool Equals(object obj);
            /*0x3e24e04*/ bool Equals(UnityEngine.Rendering.BatchID other);
        }

        struct BatchMaterialID : System.IEquatable<UnityEngine.Rendering.BatchMaterialID>
        {
            static /*0x0*/ UnityEngine.Rendering.BatchMaterialID Null;
            /*0x10*/ uint value;

            static /*0x3e24f80*/ BatchMaterialID();
            static /*0x3e24f1c*/ bool op_Equality(UnityEngine.Rendering.BatchMaterialID a, UnityEngine.Rendering.BatchMaterialID b);
            /*0x3e24e5c*/ int GetHashCode();
            /*0x3e24e64*/ bool Equals(object obj);
            /*0x3e24f0c*/ bool Equals(UnityEngine.Rendering.BatchMaterialID other);
        }

        struct BatchMeshID : System.IEquatable<UnityEngine.Rendering.BatchMeshID>
        {
            static /*0x0*/ UnityEngine.Rendering.BatchMeshID Null;
            /*0x10*/ uint value;

            static /*0x3e250ec*/ BatchMeshID();
            static /*0x3e25088*/ bool op_Equality(UnityEngine.Rendering.BatchMeshID a, UnityEngine.Rendering.BatchMeshID b);
            /*0x3e24fc8*/ int GetHashCode();
            /*0x3e24fd0*/ bool Equals(object obj);
            /*0x3e25078*/ bool Equals(UnityEngine.Rendering.BatchMeshID other);
        }

        enum BatchDrawCommandType
        {
            Direct = 0,
            Indirect = 1,
            Procedural = 2,
            ProceduralIndirect = 3,
        }

        enum BatchDrawCommandFlags
        {
            None = 0,
            FlipWinding = 1,
            HasMotion = 2,
            IsLightMapped = 4,
            HasSortingPosition = 8,
            LODCrossFadeKeyword = 16,
            LODCrossFadeValuePacked = 32,
            LODCrossFade = 48,
            UseLegacyLightmapsKeyword = 64,
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
            Filtering = 5,
        }

        enum BatchCullingProjectionType
        {
            Unknown = 0,
            Perspective = 1,
            Orthographic = 2,
        }

        enum BatchBufferTarget
        {
            Unknown = 0,
            UnsupportedByUnderlyingGraphicsApi = -1,
            RawBuffer = 1,
            ConstantBuffer = 2,
        }

        struct BatchPackedCullingViewID : System.IEquatable<UnityEngine.Rendering.BatchPackedCullingViewID>
        {
            /*0x10*/ ulong handle;

            /*0x3e25134*/ int GetHashCode();
            /*0x3e2513c*/ bool Equals(UnityEngine.Rendering.BatchPackedCullingViewID other);
            /*0x3e2514c*/ bool Equals(object obj);
            /*0x3e251c4*/ int GetInstanceID();
        }

        struct BatchDrawCommand
        {
            /*0x10*/ UnityEngine.Rendering.BatchDrawCommandFlags flags;
            /*0x14*/ UnityEngine.Rendering.BatchID batchID;
            /*0x18*/ UnityEngine.Rendering.BatchMaterialID materialID;
            /*0x1c*/ ushort splitVisibilityMask;
            /*0x1e*/ ushort lightmapIndex;
            /*0x20*/ int sortingPosition;
            /*0x24*/ uint visibleOffset;
            /*0x28*/ uint visibleCount;
            /*0x2c*/ UnityEngine.Rendering.BatchMeshID meshID;
            /*0x30*/ ushort submeshIndex;
            /*0x32*/ ushort unusedPadding2;
        }

        struct BatchDrawCommandIndirect
        {
            /*0x10*/ UnityEngine.Rendering.BatchDrawCommandFlags flags;
            /*0x14*/ UnityEngine.Rendering.BatchID batchID;
            /*0x18*/ UnityEngine.Rendering.BatchMaterialID materialID;
            /*0x1c*/ ushort splitVisibilityMask;
            /*0x1e*/ ushort lightmapIndex;
            /*0x20*/ int sortingPosition;
            /*0x24*/ uint visibleOffset;
            /*0x28*/ UnityEngine.Rendering.BatchMeshID meshID;
            /*0x2c*/ UnityEngine.MeshTopology topology;
            /*0x30*/ UnityEngine.GraphicsBufferHandle visibleInstancesBufferHandle;
            /*0x34*/ uint visibleInstancesBufferWindowOffset;
            /*0x38*/ uint visibleInstancesBufferWindowSizeBytes;
            /*0x3c*/ UnityEngine.GraphicsBufferHandle indirectArgsBufferHandle;
            /*0x40*/ uint indirectArgsBufferOffset;
        }

        struct BatchDrawCommandProcedural
        {
            /*0x10*/ UnityEngine.Rendering.BatchDrawCommandFlags flags;
            /*0x14*/ UnityEngine.Rendering.BatchID batchID;
            /*0x18*/ UnityEngine.Rendering.BatchMaterialID materialID;
            /*0x1c*/ ushort splitVisibilityMask;
            /*0x1e*/ ushort lightmapIndex;
            /*0x20*/ int sortingPosition;
            /*0x24*/ uint visibleOffset;
            /*0x28*/ uint visibleCount;
            /*0x2c*/ UnityEngine.MeshTopology topology;
            /*0x30*/ UnityEngine.GraphicsBufferHandle indexBufferHandle;
            /*0x34*/ uint baseVertex;
            /*0x38*/ uint indexOffsetBytes;
            /*0x3c*/ uint elementCount;
        }

        struct BatchDrawCommandProceduralIndirect
        {
            /*0x10*/ UnityEngine.Rendering.BatchDrawCommandFlags flags;
            /*0x14*/ UnityEngine.Rendering.BatchID batchID;
            /*0x18*/ UnityEngine.Rendering.BatchMaterialID materialID;
            /*0x1c*/ ushort splitVisibilityMask;
            /*0x1e*/ ushort lightmapIndex;
            /*0x20*/ int sortingPosition;
            /*0x24*/ uint visibleOffset;
            /*0x28*/ UnityEngine.MeshTopology topology;
            /*0x2c*/ UnityEngine.GraphicsBufferHandle indexBufferHandle;
            /*0x30*/ UnityEngine.GraphicsBufferHandle visibleInstancesBufferHandle;
            /*0x34*/ uint visibleInstancesBufferWindowOffset;
            /*0x38*/ uint visibleInstancesBufferWindowSizeBytes;
            /*0x3c*/ UnityEngine.GraphicsBufferHandle indirectArgsBufferHandle;
            /*0x40*/ uint indirectArgsBufferOffset;
        }

        struct BatchFilterSettings
        {
            /*0x10*/ uint renderingLayerMask;
            /*0x14*/ int rendererPriority;
            /*0x18*/ ulong m_sceneCullingMask;
            /*0x20*/ byte layer;
            /*0x21*/ byte m_batchLayer;
            /*0x22*/ byte m_motionMode;
            /*0x23*/ byte m_shadowMode;
            /*0x24*/ byte m_receiveShadows;
            /*0x25*/ byte m_staticShadowCaster;
            /*0x26*/ byte m_allDepthSorted;
            /*0x27*/ byte m_isSceneCullingMaskSet;

            /*0x3e251cc*/ void set_batchLayer(byte value);
            /*0x3e251d4*/ void set_motionMode(UnityEngine.MotionVectorGenerationMode value);
            /*0x3e251dc*/ void set_shadowCastingMode(UnityEngine.Rendering.ShadowCastingMode value);
            /*0x3e251e4*/ void set_receiveShadows(bool value);
            /*0x3e251ec*/ void set_staticShadowCaster(bool value);
            /*0x3e251f4*/ void set_allDepthSorted(bool value);
        }

        struct BatchDrawRange
        {
            /*0x10*/ UnityEngine.Rendering.BatchDrawCommandType drawCommandsType;
            /*0x14*/ uint drawCommandsBegin;
            /*0x18*/ uint drawCommandsCount;
            /*0x20*/ UnityEngine.Rendering.BatchFilterSettings filterSettings;
        }

        struct BatchCullingOutputDrawCommands
        {
            /*0x10*/ UnityEngine.Rendering.BatchDrawCommand* drawCommands;
            /*0x18*/ UnityEngine.Rendering.BatchDrawCommandIndirect* indirectDrawCommands;
            /*0x20*/ UnityEngine.Rendering.BatchDrawCommandProcedural* proceduralDrawCommands;
            /*0x28*/ UnityEngine.Rendering.BatchDrawCommandProceduralIndirect* proceduralIndirectDrawCommands;
            /*0x30*/ int* visibleInstances;
            /*0x38*/ UnityEngine.Rendering.BatchDrawRange* drawRanges;
            /*0x40*/ float* instanceSortingPositions;
            /*0x48*/ int* drawCommandPickingInstanceIDs;
            /*0x50*/ int drawCommandCount;
            /*0x54*/ int indirectDrawCommandCount;
            /*0x58*/ int proceduralDrawCommandCount;
            /*0x5c*/ int proceduralIndirectDrawCommandCount;
            /*0x60*/ int visibleInstanceCount;
            /*0x64*/ int drawRangeCount;
            /*0x68*/ int instanceSortingPositionFloatCount;
        }

        struct MetadataValue
        {
            /*0x10*/ int NameID;
            /*0x14*/ uint Value;
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
            /*0xb0*/ ushort splitExclusionMask;
            /*0xb2*/ byte isOrthographic;
            /*0xb4*/ int receiverPlaneOffset;
            /*0xb8*/ int receiverPlaneCount;
            /*0xc0*/ nint occlusionBuffer;

            /*0x3e251fc*/ BatchCullingContext(Unity.Collections.NativeArray<UnityEngine.Plane> inCullingPlanes, Unity.Collections.NativeArray<UnityEngine.Rendering.CullingSplit> inCullingSplits, UnityEngine.Rendering.LODParameters inLodParameters, UnityEngine.Matrix4x4 inLocalToWorldMatrix, UnityEngine.Rendering.BatchCullingViewType inViewType, UnityEngine.Rendering.BatchCullingProjectionType inProjectionType, UnityEngine.Rendering.BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, byte inExclusionSplitMask, int inReceiverPlaneOffset, int inReceiverPlaneCount, nint inOcclusionBuffer);
        }

        struct BatchCullingOutput
        {
            /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.BatchCullingOutputDrawCommands> drawCommands;
            /*0x20*/ Unity.Collections.NativeArray<nint> customCullingResult;
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
            /*0x9c*/ byte splitExclusionMask;
            /*0xa0*/ ulong sceneCullingMask;
            /*0xa8*/ UnityEngine.Rendering.BatchCullingOutputDrawCommands* drawCommands;
            /*0xb0*/ uint brgId;
            /*0xb8*/ nint occlusionBuffer;
            /*0xc0*/ nint customCullingResult;
        }

        struct BatchRendererGroupCreateInfo
        {
            /*0x10*/ UnityEngine.Rendering.BatchRendererGroup.OnPerformCulling cullingCallback;
            /*0x18*/ UnityEngine.Rendering.BatchRendererGroup.OnFinishedCulling finishedCullingCallback;
            /*0x20*/ nint userContext;
        }

        class BatchRendererGroup : System.IDisposable
        {
            /*0x10*/ nint m_GroupHandle;
            /*0x18*/ UnityEngine.Rendering.BatchRendererGroup.OnPerformCulling m_PerformCulling;
            /*0x20*/ UnityEngine.Rendering.BatchRendererGroup.OnFinishedCulling m_FinishedCulling;

            static /*0x3e25a90*/ UnityEngine.Rendering.BatchBufferTarget GetBufferTarget();
            static /*0x3e25ab8*/ UnityEngine.Rendering.BatchBufferTarget get_BufferTarget();
            static /*0x3e25314*/ nint Create(UnityEngine.Rendering.BatchRendererGroup group, void* userContext);
            static /*0x3e253a0*/ void Destroy(nint groupHandle);
            static /*0x3e25ae0*/ void InvokeOnPerformCulling(UnityEngine.Rendering.BatchRendererGroup group, ref UnityEngine.Rendering.BatchRendererCullingOutput context, ref UnityEngine.Rendering.LODParameters lodParameters, nint userContext);
            static /*0x3e25d30*/ void InvokeOnFinishedCulling(UnityEngine.Rendering.BatchRendererGroup group, nint customCullingResult);
            static /*0x3e25df8*/ bool OcclusionTestAABB(nint occlusionBuffer, UnityEngine.Bounds aabb);
            static /*0x3e25470*/ void AddDrawCommandBatch_Injected(nint _unity_self, nint values, int count, ref UnityEngine.GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize, ref UnityEngine.Rendering.BatchID ret);
            static /*0x3e255dc*/ void RemoveDrawCommandBatch_Injected(nint _unity_self, ref UnityEngine.Rendering.BatchID batchID);
            static /*0x3e25768*/ void RegisterMaterials_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper materialID, ref UnityEngine.Bindings.ManagedSpanWrapper batchMaterialID);
            static /*0x3e25818*/ void UnregisterMaterial_Injected(nint _unity_self, ref UnityEngine.Rendering.BatchMaterialID material);
            static /*0x3e2599c*/ void RegisterMeshes_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper meshID, ref UnityEngine.Bindings.ManagedSpanWrapper batchMeshID);
            static /*0x3e25a4c*/ void UnregisterMesh_Injected(nint _unity_self, ref UnityEngine.Rendering.BatchMeshID mesh);
            static /*0x3e25e3c*/ bool OcclusionTestAABB_Injected(nint occlusionBuffer, ref UnityEngine.Bounds aabb);
            /*0x3e25288*/ BatchRendererGroup(UnityEngine.Rendering.BatchRendererGroupCreateInfo info);
            /*0x3e25358*/ void Dispose();
            /*0x3e253dc*/ UnityEngine.Rendering.BatchID AddDrawCommandBatch(nint values, int count, UnityEngine.GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize);
            /*0x3e254f4*/ UnityEngine.Rendering.BatchID AddBatch(Unity.Collections.NativeArray<UnityEngine.Rendering.MetadataValue> batchMetadata, UnityEngine.GraphicsBufferHandle buffer);
            /*0x3e25580*/ void RemoveDrawCommandBatch(UnityEngine.Rendering.BatchID batchID);
            /*0x3e25620*/ void RemoveBatch(UnityEngine.Rendering.BatchID batchID);
            /*0x3e25628*/ void RegisterMaterials(System.ReadOnlySpan<int> materialID, System.Span<UnityEngine.Rendering.BatchMaterialID> batchMaterialID);
            /*0x3e257bc*/ void UnregisterMaterial(UnityEngine.Rendering.BatchMaterialID material);
            /*0x3e2585c*/ void RegisterMeshes(System.ReadOnlySpan<int> meshID, System.Span<UnityEngine.Rendering.BatchMeshID> batchMeshID);
            /*0x3e259f0*/ void UnregisterMesh(UnityEngine.Rendering.BatchMeshID mesh);

            class OnPerformCulling : System.MulticastDelegate
            {
                /*0x3e25e80*/ OnPerformCulling(object object, nint method);
                /*0x3e25f8c*/ Unity.Jobs.JobHandle Invoke(UnityEngine.Rendering.BatchRendererGroup rendererGroup, UnityEngine.Rendering.BatchCullingContext cullingContext, UnityEngine.Rendering.BatchCullingOutput cullingOutput, nint userContext);
            }

            class OnFinishedCulling : System.MulticastDelegate
            {
                /*0x3e26004*/ OnFinishedCulling(object object, nint method);
                /*0x3e260a4*/ void Invoke(nint customCullingResult);
            }

            class BindingsMarshaller
            {
                static /*0x3e260b8*/ nint ConvertToNative(UnityEngine.Rendering.BatchRendererGroup batchRendererGroup);
            }
        }

        class GPUDrivenLODGroupDataCallback : System.MulticastDelegate
        {
            /*0x3e260cc*/ GPUDrivenLODGroupDataCallback(object object, nint method);
            /*0x3e2617c*/ void Invoke(ref UnityEngine.Rendering.GPUDrivenLODGroupData lodGroupData);
        }

        class GPUDrivenLODGroupDataNativeCallback : System.MulticastDelegate
        {
            /*0x3e26190*/ GPUDrivenLODGroupDataNativeCallback(object object, nint method);
            /*0x3e26244*/ void Invoke(ref UnityEngine.Rendering.GPUDrivenLODGroupDataNative lodGroupDataNative, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback callback);
        }

        class GPUDrivenRendererDataCallback : System.MulticastDelegate
        {
            /*0x3e26258*/ GPUDrivenRendererDataCallback(object object, nint method);
            /*0x3e2630c*/ void Invoke(ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, System.Collections.Generic.IList<UnityEngine.Mesh> meshes, System.Collections.Generic.IList<UnityEngine.Material> materials);
        }

        class GPUDrivenRendererDataNativeCallback : System.MulticastDelegate
        {
            /*0x3e26320*/ GPUDrivenRendererDataNativeCallback(object object, nint method);
            /*0x3e263d4*/ void Invoke(ref UnityEngine.Rendering.GPUDrivenRendererGroupDataNative rendererDataNative, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, UnityEngine.Rendering.GPUDrivenRendererDataCallback callback);
        }

        class GPUDrivenCallbacks
        {
            static /*0x3e263e8*/ void InvokeGPUDrivenLODGroupDataNativeCallback(UnityEngine.Rendering.GPUDrivenLODGroupDataNativeCallback callback, ref UnityEngine.Rendering.GPUDrivenLODGroupDataNative lodGroupDataNative, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback target);
            static /*0x3e26408*/ void InvokeGPUDrivenRendererDataNativeCallback(UnityEngine.Rendering.GPUDrivenRendererDataNativeCallback callback, ref UnityEngine.Rendering.GPUDrivenRendererGroupDataNative rendererDataNative, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, UnityEngine.Rendering.GPUDrivenRendererDataCallback target);
        }

        class GPUDrivenProcessor
        {
            static /*0x0*/ UnityEngine.Rendering.GPUDrivenRendererDataNativeCallback s_NativeRendererCallback;
            static /*0x8*/ UnityEngine.Rendering.GPUDrivenLODGroupDataNativeCallback s_NativeLODGroupCallback;
            /*0x10*/ nint m_Ptr;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Mesh> <scratchMeshes>k__BackingField;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Material> <scratchMaterials>k__BackingField;

            static /*0x3e272f4*/ GPUDrivenProcessor();
            static /*0x3e26570*/ nint Internal_Create();
            static /*0x3e26720*/ void Internal_Destroy(nint ptr);
            static /*0x3e26f88*/ int ClassifyMaterialsImpl(System.ReadOnlySpan<int> materialIDs, System.Span<int> unsupportedMaterialIDs, System.Span<int> supportedMaterialIDs, System.Span<UnityEngine.Rendering.GPUDrivenPackedMaterialData> supportedPackedMaterialDatas);
            static /*0x3e271bc*/ int ClassifyMaterials(Unity.Collections.NativeArray<int> materialIDs, Unity.Collections.NativeArray<int> unsupportedMaterialIDs, Unity.Collections.NativeArray<int> supportedMaterialIDs, Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedMaterialData> supportedPackedMaterialDatas);
            static /*0x3e26898*/ void EnableGPUDrivenRenderingAndDispatchRendererData_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper renderersID, UnityEngine.Rendering.GPUDrivenRendererDataNativeCallback callback, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, UnityEngine.Rendering.GPUDrivenRendererDataCallback param, bool materialUpdateOnly);
            static /*0x3e26b94*/ void DisableGPUDrivenRendering_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper renderersID);
            static /*0x3e26cf4*/ void DispatchLODGroupData_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper lodGroupID, UnityEngine.Rendering.GPUDrivenLODGroupDataNativeCallback callback, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback param);
            static /*0x3e26e78*/ void set_enablePartialRendering_Injected(nint _unity_self, bool value);
            static /*0x3e26f4c*/ void ClearMaterialFilters_Injected(nint _unity_self);
            static /*0x3e27160*/ int ClassifyMaterialsImpl_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper materialIDs, ref UnityEngine.Bindings.ManagedSpanWrapper unsupportedMaterialIDs, ref UnityEngine.Bindings.ManagedSpanWrapper supportedMaterialIDs, ref UnityEngine.Bindings.ManagedSpanWrapper supportedPackedMaterialDatas);
            /*0x3e26448*/ GPUDrivenProcessor();
            /*0x3e26428*/ System.Collections.Generic.List<UnityEngine.Mesh> get_scratchMeshes();
            /*0x3e26430*/ void set_scratchMeshes(System.Collections.Generic.List<UnityEngine.Mesh> value);
            /*0x3e26438*/ System.Collections.Generic.List<UnityEngine.Material> get_scratchMaterials();
            /*0x3e26440*/ void set_scratchMaterials(System.Collections.Generic.List<UnityEngine.Material> value);
            /*0x3e26598*/ void Finalize();
            /*0x3e266a0*/ void Dispose();
            /*0x3e2661c*/ void Destroy();
            /*0x3e2675c*/ void EnableGPUDrivenRenderingAndDispatchRendererData(System.ReadOnlySpan<int> renderersID, UnityEngine.Rendering.GPUDrivenRendererDataNativeCallback callback, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, UnityEngine.Rendering.GPUDrivenRendererDataCallback param, bool materialUpdateOnly);
            /*0x3e2691c*/ void EnableGPUDrivenRenderingAndDispatchRendererData(System.ReadOnlySpan<int> renderersID, UnityEngine.Rendering.GPUDrivenRendererDataCallback callback, bool materialUpdateOnly);
            /*0x3e26a90*/ void DisableGPUDrivenRendering(System.ReadOnlySpan<int> renderersID);
            /*0x3e26bd8*/ void DispatchLODGroupData(System.ReadOnlySpan<int> lodGroupID, UnityEngine.Rendering.GPUDrivenLODGroupDataNativeCallback callback, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback param);
            /*0x3e26d50*/ void DispatchLODGroupData(System.ReadOnlySpan<int> lodGroupID, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback callback);
            /*0x3e26dd8*/ void set_enablePartialRendering(bool value);
            /*0x3e26ebc*/ void ClearMaterialFilters();

            class BindingsMarshaller
            {
                static /*0x3e27428*/ nint ConvertToNative(UnityEngine.Rendering.GPUDrivenProcessor obj);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.GPUDrivenProcessor.<> <>9;

                static /*0x3e2743c*/ <>c();
                /*0x3e274a4*/ <>c();
                /*0x3e274ac*/ void <.cctor>b__34_0(ref UnityEngine.Rendering.GPUDrivenRendererGroupDataNative nativeData, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, UnityEngine.Rendering.GPUDrivenRendererDataCallback callback);
                /*0x3e27a64*/ void <.cctor>b__34_1(ref UnityEngine.Rendering.GPUDrivenLODGroupDataNative nativeData, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback callback);
            }
        }

        struct GPUDrivenRendererEditorData
        {
            /*0x10*/ ulong sceneCullingMask;
        }

        struct GPUDrivenRendererGroupDataNative
        {
            /*0x10*/ int* rendererGroupID;
            /*0x18*/ UnityEngine.Bounds* localBounds;
            /*0x20*/ UnityEngine.Vector4* lightmapScaleOffset;
            /*0x28*/ int* gameObjectLayer;
            /*0x30*/ uint* renderingLayerMask;
            /*0x38*/ int* lodGroupID;
            /*0x40*/ UnityEngine.MotionVectorGenerationMode* motionVecGenMode;
            /*0x48*/ UnityEngine.Rendering.GPUDrivenPackedRendererData* packedRendererData;
            /*0x50*/ int* rendererPriority;
            /*0x58*/ int* meshIndex;
            /*0x60*/ short* subMeshStartIndex;
            /*0x68*/ int* materialsOffset;
            /*0x70*/ short* materialsCount;
            /*0x78*/ int* instancesOffset;
            /*0x80*/ int* instancesCount;
            /*0x88*/ UnityEngine.Rendering.GPUDrivenRendererEditorData* editorData;
            /*0x90*/ int rendererGroupCount;
            /*0x98*/ int* invalidRendererGroupID;
            /*0xa0*/ int invalidRendererGroupIDCount;
            /*0xa8*/ UnityEngine.Matrix4x4* localToWorldMatrix;
            /*0xb0*/ UnityEngine.Matrix4x4* prevLocalToWorldMatrix;
            /*0xb8*/ int* rendererGroupIndex;
            /*0xc0*/ int instanceCount;
            /*0xc8*/ int* meshID;
            /*0xd0*/ short* subMeshCount;
            /*0xd8*/ int* subMeshDescOffset;
            /*0xe0*/ int meshCount;
            /*0xe8*/ UnityEngine.Rendering.SubMeshDescriptor* subMeshDesc;
            /*0xf0*/ int subMeshDescCount;
            /*0xf8*/ int* materialIndex;
            /*0x100*/ int materialIndexCount;
            /*0x108*/ int* materialID;
            /*0x110*/ UnityEngine.Rendering.GPUDrivenPackedMaterialData* packedMaterialData;
            /*0x118*/ int* materialFilterFlags;
            /*0x120*/ int materialCount;
        }

        struct GPUDrivenLODGroupDataNative
        {
            /*0x10*/ int* lodGroupID;
            /*0x18*/ int* lodOffset;
            /*0x20*/ int* lodCount;
            /*0x28*/ UnityEngine.LODFadeMode* fadeMode;
            /*0x30*/ UnityEngine.Vector3* worldSpaceReferencePoint;
            /*0x38*/ float* worldSpaceSize;
            /*0x40*/ short* renderersCount;
            /*0x48*/ bool* lastLODIsBillboard;
            /*0x50*/ byte* forceLODMask;
            /*0x58*/ int lodGroupCount;
            /*0x60*/ int* invalidLODGroupID;
            /*0x68*/ int invalidLODGroupCount;
            /*0x70*/ short* lodRenderersCount;
            /*0x78*/ float* lodScreenRelativeTransitionHeight;
            /*0x80*/ float* lodFadeTransitionWidth;
            /*0x88*/ int lodDataCount;
        }

        struct GPUDrivenPackedRendererData
        {
            /*0x10*/ uint data;

            /*0x3e27da0*/ GPUDrivenPackedRendererData();
            /*0x3e27d40*/ bool get_staticShadowCaster();
            /*0x3e27d4c*/ byte get_lodMask();
            /*0x3e27d58*/ UnityEngine.Rendering.ShadowCastingMode get_shadowCastingMode();
            /*0x3e27d64*/ UnityEngine.Rendering.LightProbeUsage get_lightProbeUsage();
            /*0x3e27d70*/ UnityEngine.MotionVectorGenerationMode get_motionVecGenMode();
            /*0x3e27d7c*/ bool get_isPartOfStaticBatch();
            /*0x3e27d88*/ bool get_hasTree();
            /*0x3e27d94*/ bool get_smallMeshCulling();
        }

        struct GPUDrivenPackedMaterialData
        {
            /*0x10*/ uint data;

            /*0x3e27dcc*/ GPUDrivenPackedMaterialData();
            /*0x3e27da8*/ bool get_isTransparent();
            /*0x3e27db4*/ bool get_isMotionVectorsPassEnabled();
            /*0x3e27dc0*/ bool get_isIndirectSupported();
            /*0x3e27dd4*/ bool Equals(UnityEngine.Rendering.GPUDrivenPackedMaterialData other);
        }

        struct GPUDrivenRendererGroupData
        {
            /*0x10*/ Unity.Collections.NativeArray<int> rendererGroupID;
            /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Bounds> localBounds;
            /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Vector4> lightmapScaleOffset;
            /*0x40*/ Unity.Collections.NativeArray<int> gameObjectLayer;
            /*0x50*/ Unity.Collections.NativeArray<uint> renderingLayerMask;
            /*0x60*/ Unity.Collections.NativeArray<int> lodGroupID;
            /*0x70*/ Unity.Collections.NativeArray<int> lightmapIndex;
            /*0x80*/ Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedRendererData> packedRendererData;
            /*0x90*/ Unity.Collections.NativeArray<int> rendererPriority;
            /*0xa0*/ Unity.Collections.NativeArray<int> meshIndex;
            /*0xb0*/ Unity.Collections.NativeArray<short> subMeshStartIndex;
            /*0xc0*/ Unity.Collections.NativeArray<int> materialsOffset;
            /*0xd0*/ Unity.Collections.NativeArray<short> materialsCount;
            /*0xe0*/ Unity.Collections.NativeArray<int> instancesOffset;
            /*0xf0*/ Unity.Collections.NativeArray<int> instancesCount;
            /*0x100*/ Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenRendererEditorData> editorData;
            /*0x110*/ Unity.Collections.NativeArray<int> invalidRendererGroupID;
            /*0x120*/ Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrix;
            /*0x130*/ Unity.Collections.NativeArray<UnityEngine.Matrix4x4> prevLocalToWorldMatrix;
            /*0x140*/ Unity.Collections.NativeArray<int> rendererGroupIndex;
            /*0x150*/ Unity.Collections.NativeArray<int> meshID;
            /*0x160*/ Unity.Collections.NativeArray<short> subMeshCount;
            /*0x170*/ Unity.Collections.NativeArray<int> subMeshDescOffset;
            /*0x180*/ Unity.Collections.NativeArray<UnityEngine.Rendering.SubMeshDescriptor> subMeshDesc;
            /*0x190*/ Unity.Collections.NativeArray<int> materialIndex;
            /*0x1a0*/ Unity.Collections.NativeArray<int> materialID;
            /*0x1b0*/ Unity.Collections.NativeArray<UnityEngine.Rendering.GPUDrivenPackedMaterialData> packedMaterialData;
            /*0x1c0*/ Unity.Collections.NativeArray<int> materialFilterFlags;
        }

        struct GPUDrivenLODGroupData
        {
            /*0x10*/ Unity.Collections.NativeArray<int> lodGroupID;
            /*0x20*/ Unity.Collections.NativeArray<int> lodOffset;
            /*0x30*/ Unity.Collections.NativeArray<int> lodCount;
            /*0x40*/ Unity.Collections.NativeArray<UnityEngine.LODFadeMode> fadeMode;
            /*0x50*/ Unity.Collections.NativeArray<UnityEngine.Vector3> worldSpaceReferencePoint;
            /*0x60*/ Unity.Collections.NativeArray<float> worldSpaceSize;
            /*0x70*/ Unity.Collections.NativeArray<short> renderersCount;
            /*0x80*/ Unity.Collections.NativeArray<bool> lastLODIsBillboard;
            /*0x90*/ Unity.Collections.NativeArray<byte> forceLODMask;
            /*0xa0*/ Unity.Collections.NativeArray<int> invalidLODGroupID;
            /*0xb0*/ Unity.Collections.NativeArray<short> lodRenderersCount;
            /*0xc0*/ Unity.Collections.NativeArray<float> lodScreenRelativeTransitionHeight;
            /*0xd0*/ Unity.Collections.NativeArray<float> lodFadeTransitionWidth;
        }

        struct GlobalKeyword
        {
            /*0x10*/ string m_Name;
            /*0x18*/ uint m_Index;

            static /*0x3e27de8*/ uint GetGlobalKeywordCount();
            static /*0x3e27e10*/ uint GetGlobalKeywordIndex(string keyword);
            static /*0x3e27fbc*/ void CreateGlobalKeyword(string keyword);
            static /*0x3e28160*/ UnityEngine.Rendering.GlobalKeyword Create(string name);
            static /*0x3e27f80*/ uint GetGlobalKeywordIndex_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            static /*0x3e28124*/ void CreateGlobalKeyword_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            /*0x3e28190*/ GlobalKeyword(string name);
            /*0x3e282d4*/ string ToString();
        }

        struct LocalKeyword : System.IEquatable<UnityEngine.Rendering.LocalKeyword>
        {
            /*0x10*/ UnityEngine.Rendering.LocalKeywordSpace m_SpaceInfo;
            /*0x18*/ string m_Name;
            /*0x20*/ uint m_Index;

            static /*0x3e282dc*/ uint GetShaderKeywordCount(UnityEngine.Shader shader);
            static /*0x3e28394*/ uint GetShaderKeywordIndex(UnityEngine.Shader shader, string keyword);
            static /*0x3e28588*/ uint GetComputeShaderKeywordCount(UnityEngine.ComputeShader shader);
            static /*0x3e28640*/ uint GetComputeShaderKeywordIndex(UnityEngine.ComputeShader shader, string keyword);
            static /*0x3e28358*/ uint GetShaderKeywordCount_Injected(nint shader);
            static /*0x3e28544*/ uint GetShaderKeywordIndex_Injected(nint shader, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            static /*0x3e28604*/ uint GetComputeShaderKeywordCount_Injected(nint shader);
            static /*0x3e287f0*/ uint GetComputeShaderKeywordIndex_Injected(nint shader, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            /*0x3e2883c*/ LocalKeyword(UnityEngine.Shader shader, string name);
            /*0x3e289ec*/ LocalKeyword(UnityEngine.ComputeShader shader, string name);
            /*0x3e28834*/ string get_name();
            /*0x3e28b9c*/ string ToString();
            /*0x3e28ba4*/ bool Equals(object o);
            /*0x3e28c2c*/ bool Equals(UnityEngine.Rendering.LocalKeyword rhs);
            /*0x3e28c64*/ int GetHashCode();
        }

        struct LocalKeywordSpace : System.IEquatable<UnityEngine.Rendering.LocalKeywordSpace>
        {
            /*0x10*/ nint m_KeywordSpace;

            static /*0x3e28c58*/ bool op_Equality(UnityEngine.Rendering.LocalKeywordSpace lhs, UnityEngine.Rendering.LocalKeywordSpace rhs);
            /*0x3e28ca4*/ UnityEngine.Rendering.LocalKeyword[] GetKeywords();
            /*0x3e28ce0*/ UnityEngine.Rendering.LocalKeyword[] get_keywords();
            /*0x3e28d1c*/ bool Equals(object o);
            /*0x3e28d94*/ bool Equals(UnityEngine.Rendering.LocalKeywordSpace rhs);
            /*0x3e28c9c*/ int GetHashCode();
        }

        class RayTracingShader : UnityEngine.Object
        {
            /*0x3e28da4*/ RayTracingShader();
        }

        struct ShaderKeyword
        {
            /*0x10*/ string m_Name;
            /*0x18*/ uint m_Index;
            /*0x1c*/ bool m_IsLocal;
            /*0x1d*/ bool m_IsCompute;
            /*0x1e*/ bool m_IsValid;

            static /*0x3e28dfc*/ uint GetGlobalKeywordCount();
            static /*0x3e28e24*/ uint GetGlobalKeywordIndex(string keyword);
            static /*0x3e28fd0*/ void CreateGlobalKeyword(string keyword);
            static /*0x3e28f94*/ uint GetGlobalKeywordIndex_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            static /*0x3e29138*/ void CreateGlobalKeyword_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            /*0x3e2917c*/ ShaderKeyword(string keywordName);
            /*0x3e29174*/ string get_name();
            /*0x3e29204*/ string ToString();
        }

        struct ShaderKeywordSet
        {
            /*0x10*/ nint m_KeywordState;
            /*0x18*/ nint m_Shader;
            /*0x20*/ nint m_ComputeShader;
            /*0x28*/ ulong m_StateIndex;

            static /*0x3e2920c*/ bool IsKeywordNameEnabled(UnityEngine.Rendering.ShaderKeywordSet state, string name);
            static /*0x3e29388*/ bool IsKeywordNameEnabled_Injected(ref UnityEngine.Rendering.ShaderKeywordSet state, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            /*0x3e293cc*/ void CheckKeywordCompatible(UnityEngine.Rendering.ShaderKeyword keyword);
            /*0x3e29480*/ bool IsEnabled(UnityEngine.Rendering.ShaderKeyword keyword);
        }

        enum ShaderPropertyType
        {
            Color = 0,
            Vector = 1,
            Float = 2,
            Range = 3,
            Texture = 4,
            Int = 5,
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
                /*0xac*/ uint <batchLayerMask>k__BackingField;
                /*0xb0*/ int overrideMaterialPassIndex;
                /*0xb4*/ int overrideShaderPassIndex;
                /*0xb8*/ UnityEngine.Rendering.CullingResults <cullingResult>k__BackingField;
                /*0xc8*/ UnityEngine.Camera <camera>k__BackingField;
                /*0xd0*/ UnityEngine.Rendering.ShaderTagId <passName>k__BackingField;
                /*0xd8*/ UnityEngine.Rendering.ShaderTagId[] <passNames>k__BackingField;

                static /*0x3e29d74*/ RendererListDesc();
                static /*0x3e29604*/ UnityEngine.Rendering.RendererListParams ConvertToParameters(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                /*0x3e294c0*/ uint get_batchLayerMask();
                /*0x3e294c8*/ UnityEngine.Rendering.CullingResults get_cullingResult();
                /*0x3e294d4*/ UnityEngine.Camera get_camera();
                /*0x3e294dc*/ UnityEngine.Rendering.ShaderTagId get_passName();
                /*0x3e294e4*/ UnityEngine.Rendering.ShaderTagId[] get_passNames();
                /*0x3e294ec*/ bool IsValid();
            }
        }
    }

    namespace Experimental
    {
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

                static /*0x3e29ff8*/ UnityEngine.Experimental.GlobalIllumination.LinearColor Convert(UnityEngine.Color color, float intensity);
                static /*0x3e2a290*/ UnityEngine.Experimental.GlobalIllumination.LinearColor Black();
                /*0x3e29ddc*/ float get_red();
                /*0x3e29de4*/ void set_red(float value);
                /*0x3e29e90*/ float get_green();
                /*0x3e29e98*/ void set_green(float value);
                /*0x3e29f44*/ float get_blue();
                /*0x3e29f4c*/ void set_blue(float value);
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

                static /*0x3e2a2a4*/ UnityEngine.Experimental.GlobalIllumination.Cookie Defaults();
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

                /*0x3e2a2b0*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x3e2a320*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.PointLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x3e2a398*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.SpotLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x3e2a414*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.RectangleLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x3e2a488*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DiscLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x3e2a500*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight light);
                /*0x3e2a578*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.PointLight light);
                /*0x3e2a5ec*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.SpotLight light);
                /*0x3e2a618*/ void InitNoBake(int lightInstanceID);
            }

            class LightmapperUtils
            {
                static /*0x3e2a820*/ UnityEngine.Experimental.GlobalIllumination.LightMode Extract(UnityEngine.LightmapBakeType baketype);
                static /*0x3e2a838*/ UnityEngine.Experimental.GlobalIllumination.LinearColor ExtractIndirect(UnityEngine.Light l);
                static /*0x3e2a8b4*/ float ExtractInnerCone(UnityEngine.Light l);
                static /*0x3e2a908*/ UnityEngine.Color ExtractColorTemperature(UnityEngine.Light l);
                static /*0x3e2a9c0*/ void ApplyColorTemperature(UnityEngine.Color cct, ref UnityEngine.Experimental.GlobalIllumination.LinearColor lightColor);
                static /*0x3e2aa38*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight dir);
                static /*0x3e2abd0*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.PointLight point);
                static /*0x3e2ad80*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.SpotLight spot);
                static /*0x3e2af58*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.RectangleLight rect);
                static /*0x3e2b108*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.DiscLight disc);
                static /*0x3e2b2b8*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
            }

            class Lightmapping
            {
                static /*0x0*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate s_DefaultDelegate;
                static /*0x8*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate s_RequestLightsDelegate;

                static /*0x3e2b5f8*/ Lightmapping();
                static /*0x3e2b3fc*/ void SetDelegate(UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate del);
                static /*0x3e2b478*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate GetDelegate();
                static /*0x3e2b4d0*/ void ResetDelegate();
                static /*0x3e2b52c*/ void RequestLights(UnityEngine.Light[] lights, nint outLightsPtr, int outLightsCount);

                class RequestLightsDelegate : System.MulticastDelegate
                {
                    /*0x3e2b6d8*/ RequestLightsDelegate(object object, nint method);
                    /*0x3e2b78c*/ void Invoke(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.<> <>9;

                    static /*0x3e2b7a0*/ <>c();
                    /*0x3e2b808*/ <>c();
                    /*0x3e2b810*/ void <.cctor>b__7_0(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }
            }
        }

        namespace Playables
        {
            struct CameraPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Experimental.Playables.CameraPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x3e2ba84*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x3e2ba90*/ bool Equals(UnityEngine.Experimental.Playables.CameraPlayable other);
            }

            struct MaterialEffectPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Experimental.Playables.MaterialEffectPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x3e2bb08*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x3e2bb14*/ bool Equals(UnityEngine.Experimental.Playables.MaterialEffectPlayable other);
            }

            struct TextureMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Experimental.Playables.TextureMixerPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x3e2bb8c*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x3e2bb98*/ bool Equals(UnityEngine.Experimental.Playables.TextureMixerPlayable other);
            }

            struct TexturePlayableOutput : UnityEngine.Playables.IPlayableOutput
            {
                /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

                /*0x3e2bc10*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            }
        }

        namespace Rendering
        {
            class BuiltinRuntimeReflectionSystem : UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem, System.IDisposable
            {
                static /*0x3e2bc44*/ bool BuiltinUpdate();
                static /*0x3e2bc74*/ UnityEngine.Experimental.Rendering.BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New();
                /*0x3e2bcc8*/ BuiltinRuntimeReflectionSystem();
                /*0x3e2bc1c*/ bool TickRealtimeProbes();
                /*0x3e2bc6c*/ void Dispose();
                /*0x3e2bc70*/ void Dispose(bool disposing);
            }

            interface IScriptableRuntimeReflectionSystem : System.IDisposable
            {
                /*0x1f2fe14*/ bool TickRealtimeProbes();
            }

            class ScriptableRuntimeReflectionSystemSettings
            {
                static /*0x0*/ UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper s_Instance;

                static /*0x3e2be9c*/ ScriptableRuntimeReflectionSystemSettings();
                static /*0x3e2bcd0*/ void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value);
                static /*0x3e2be1c*/ UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance();
                static /*0x3e2be74*/ void ScriptingDirtyReflectionSystemInstance();
            }

            class ScriptableRuntimeReflectionSystemWrapper
            {
                /*0x10*/ UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem <implementation>k__BackingField;

                /*0x3e2bf18*/ ScriptableRuntimeReflectionSystemWrapper();
                /*0x3e2bf20*/ UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem get_implementation();
                /*0x3e2bf28*/ void set_implementation(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value);
                /*0x3e2bf30*/ void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(ref bool result);
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

            enum GraphicsFormatUsage
            {
                None = 0,
                Sample = 1,
                Linear = 2,
                Sparse = 4,
                Render = 16,
                Blend = 32,
                GetPixels = 64,
                SetPixels = 128,
                SetPixels32 = 256,
                ReadPixels = 512,
                LoadStore = 1024,
                MSAA2x = 2048,
                MSAA4x = 4096,
                MSAA8x = 8192,
                StencilSampling = 65536,
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

                static /*0x3e2cd68*/ GraphicsFormatUtility();
                static /*0x3e2bff0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Texture texture);
                static /*0x3e2c0f8*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.TextureFormat format, bool isSRGB);
                static /*0x3e2c17c*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_TextureFormat(UnityEngine.TextureFormat format, bool isSRGB);
                static /*0x3e2c1c0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, bool isSRGB);
                static /*0x3e2c244*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(UnityEngine.RenderTextureFormat format, bool isSRGB);
                static /*0x3e2c288*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
                static /*0x3e2c310*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits);
                static /*0x3e2c34c*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormat(int depthBits);
                static /*0x3e2c3c0*/ int GetDepthBits(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2c3fc*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits);
                static /*0x3e2c604*/ bool IsSRGBFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2c640*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetSRGBFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2c67c*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetLinearFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2c6b8*/ UnityEngine.RenderTextureFormat GetRenderTextureFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2c6f4*/ uint GetAlphaComponentCount(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2c730*/ uint GetComponentCount(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2c76c*/ string GetFormatString(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2c8b4*/ bool IsCompressedFormat_Native_TextureFormat(UnityEngine.TextureFormat format);
                static /*0x3e2c8f0*/ bool IsCompressedFormat(UnityEngine.TextureFormat format);
                static /*0x3e2c964*/ bool CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, bool wholeImage);
                static /*0x3e2c9a8*/ bool CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2ca20*/ bool IsAlphaOnlyFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2ca5c*/ bool HasAlphaChannel(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2ca98*/ bool IsDepthFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2cad4*/ bool IsStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2cb10*/ bool IsDepthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2cb4c*/ bool IsFloatFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2cb88*/ bool IsHalfFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2cbc4*/ bool IsPVRTCFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2cc00*/ bool IsCrunchFormat(UnityEngine.TextureFormat format);
                static /*0x3e2cc3c*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleR(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2cc78*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleG(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2ccb4*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleB(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2ccf0*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleA(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2cd2c*/ uint GetBlockSize(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x3e2c0bc*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat_Injected(nint texture);
                static /*0x3e2c870*/ void GetFormatString_Injected(UnityEngine.Experimental.Rendering.GraphicsFormat format, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            }
        }

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
    }

    namespace Sprites
    {
        class DataUtility
        {
            static /*0x3e2ce4c*/ UnityEngine.Vector4 GetInnerUV(UnityEngine.Sprite sprite);
            static /*0x3e2ce60*/ UnityEngine.Vector4 GetOuterUV(UnityEngine.Sprite sprite);
            static /*0x3e2ce74*/ UnityEngine.Vector4 GetPadding(UnityEngine.Sprite sprite);
            static /*0x3e2ce88*/ UnityEngine.Vector2 GetMinSize(UnityEngine.Sprite sprite);
        }
    }

    namespace U2D
    {
        struct SpriteBone
        {
            /*0x10*/ string m_Name;
            /*0x18*/ string m_Guid;
            /*0x20*/ UnityEngine.Vector3 m_Position;
            /*0x2c*/ UnityEngine.Quaternion m_Rotation;
            /*0x3c*/ float m_Length;
            /*0x40*/ int m_ParentId;
            /*0x44*/ UnityEngine.Color32 m_Color;

            /*0x3e2cee8*/ string get_name();
            /*0x3e2cef0*/ string get_guid();
            /*0x3e2cef8*/ UnityEngine.Vector3 get_position();
            /*0x3e2cf04*/ UnityEngine.Quaternion get_rotation();
            /*0x3e2cf10*/ int get_parentId();
        }

        struct SpriteChannelInfo
        {
            /*0x10*/ nint m_Buffer;
            /*0x18*/ int m_Count;
            /*0x1c*/ int m_Offset;
            /*0x20*/ int m_Stride;

            /*0x3e2cf18*/ void* get_buffer();
            /*0x3e2cf24*/ int get_count();
            /*0x3e2cf2c*/ int get_offset();
            /*0x3e2cf34*/ int get_stride();
        }

        class SpriteDataAccessExtensions
        {
            static /*0x1f346e4*/ void CheckAttributeTypeMatchesAndThrow<T>(UnityEngine.Rendering.VertexAttribute channel);
            static /*0x1ffc854*/ Unity.Collections.NativeSlice<T> GetVertexAttribute<T>(UnityEngine.Sprite sprite, UnityEngine.Rendering.VertexAttribute channel);
            static /*0x3e2cf3c*/ Unity.Collections.NativeArray<UnityEngine.Matrix4x4> GetBindPoses(UnityEngine.Sprite sprite);
            static /*0x3e2d080*/ Unity.Collections.NativeArray<ushort> GetIndices(UnityEngine.Sprite sprite);
            static /*0x3e2d1c4*/ UnityEngine.U2D.SpriteBone[] GetBones(UnityEngine.Sprite sprite);
            static /*0x3e2d270*/ bool HasVertexAttribute(UnityEngine.Sprite sprite, UnityEngine.Rendering.VertexAttribute channel);
            static /*0x3e2d364*/ int GetVertexCount(UnityEngine.Sprite sprite);
            static /*0x3e2cfac*/ UnityEngine.U2D.SpriteChannelInfo GetBindPoseInfo(UnityEngine.Sprite sprite);
            static /*0x3e2d0f0*/ UnityEngine.U2D.SpriteChannelInfo GetIndicesInfo(UnityEngine.Sprite sprite);
            static /*0x3e2d4d0*/ UnityEngine.U2D.SpriteChannelInfo GetChannelInfo(UnityEngine.Sprite sprite, UnityEngine.Rendering.VertexAttribute channel);
            static /*0x3e2d1c8*/ UnityEngine.U2D.SpriteBone[] GetBoneInfo(UnityEngine.Sprite sprite);
            static /*0x3e2d640*/ int GetPrimaryVertexStreamSize(UnityEngine.Sprite sprite);
            static /*0x3e2d320*/ bool HasVertexAttribute_Injected(nint sprite, UnityEngine.Rendering.VertexAttribute channel);
            static /*0x3e2d40c*/ int GetVertexCount_Injected(nint sprite);
            static /*0x3e2d448*/ void GetBindPoseInfo_Injected(nint sprite, ref UnityEngine.U2D.SpriteChannelInfo ret);
            static /*0x3e2d48c*/ void GetIndicesInfo_Injected(nint sprite, ref UnityEngine.U2D.SpriteChannelInfo ret);
            static /*0x3e2d5b0*/ void GetChannelInfo_Injected(nint sprite, UnityEngine.Rendering.VertexAttribute channel, ref UnityEngine.U2D.SpriteChannelInfo ret);
            static /*0x3e2d604*/ UnityEngine.U2D.SpriteBone[] GetBoneInfo_Injected(nint sprite);
            static /*0x3e2d6bc*/ int GetPrimaryVertexStreamSize_Injected(nint sprite);
        }

        class SpriteRendererDataAccessExtensions
        {
            static /*0x3e2d6f8*/ void SetDeformableBuffer(UnityEngine.SpriteRenderer spriteRenderer, Unity.Collections.NativeArray<byte> src);
            static /*0x3e2d988*/ void SetBatchDeformableBufferAndLocalAABBArray(UnityEngine.SpriteRenderer[] spriteRenderers, Unity.Collections.NativeArray<nint> buffers, Unity.Collections.NativeArray<int> bufferSizes, Unity.Collections.NativeArray<UnityEngine.Bounds> bounds);
            static /*0x3e2db68*/ void SetBoneTransformsArray(UnityEngine.SpriteRenderer[] spriteRenderers, Unity.Collections.NativeArray<nint> buffers, Unity.Collections.NativeArray<int> bufferSizes, Unity.Collections.NativeArray<UnityEngine.Bounds> bounds);
            static /*0x3e2dd48*/ bool IsUsingDeformableBuffer(UnityEngine.SpriteRenderer spriteRenderer, nint buffer);
            static /*0x3e2de1c*/ void DeactivateDeformableBuffer(UnityEngine.SpriteRenderer renderer);
            static /*0x3e2df00*/ void SetLocalAABB(UnityEngine.SpriteRenderer renderer, UnityEngine.Bounds aabb);
            static /*0x3e2d8c8*/ void SetDeformableBuffer(UnityEngine.SpriteRenderer spriteRenderer, void* src, int count);
            static /*0x3e2dafc*/ void SetBatchDeformableBufferAndLocalAABBArray(UnityEngine.SpriteRenderer[] spriteRenderers, void* buffers, void* bufferSizes, void* bounds, int count);
            static /*0x3e2dd6c*/ bool IsUsingDeformableBuffer(UnityEngine.SpriteRenderer spriteRenderer, void* buffer);
            static /*0x3e2dcdc*/ void SetBoneTransformsArray(UnityEngine.SpriteRenderer[] spriteRenderers, void* buffers, void* bufferSizes, void* bounds, int count);
            static /*0x3e2e08c*/ bool IsGPUSkinningEnabled();
            static /*0x3e2dec4*/ void DeactivateDeformableBuffer_Injected(nint renderer);
            static /*0x3e2dfb0*/ void SetLocalAABB_Injected(nint renderer, ref UnityEngine.Bounds aabb);
            static /*0x3e2dff4*/ void SetDeformableBuffer_Injected(nint spriteRenderer, void* src, int count);
            static /*0x3e2e048*/ bool IsUsingDeformableBuffer_Injected(nint spriteRenderer, void* buffer);
        }

        class SpriteAtlasManager
        {
            static /*0x0*/ System.Action<string, System.Action<UnityEngine.U2D.SpriteAtlas>> atlasRequested;
            static /*0x8*/ System.Action<UnityEngine.U2D.SpriteAtlas> atlasRegistered;

            static /*0x3e2e0b4*/ void add_atlasRequested(System.Action<string, System.Action<UnityEngine.U2D.SpriteAtlas>> value);
            static /*0x3e2e180*/ void remove_atlasRequested(System.Action<string, System.Action<UnityEngine.U2D.SpriteAtlas>> value);
            static /*0x3e2e24c*/ bool RequestAtlas(string tag);
            static /*0x3e2e300*/ void add_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value);
            static /*0x3e2e3d0*/ void remove_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value);
            static /*0x3e2e4a0*/ void PostRegisteredAtlas(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x3e2e50c*/ void Register(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x3e2e588*/ void Register_Injected(nint spriteAtlas);
        }

        class SpriteAtlas : UnityEngine.Object
        {
            static /*0x3e2e63c*/ bool get_isVariant_Injected(nint _unity_self);
            static /*0x3e2e7a4*/ void get_tag_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x3e2e860*/ int get_spriteCount_Injected(nint _unity_self);
            static /*0x3e2e980*/ bool CanBindTo_Injected(nint _unity_self, nint sprite);
            static /*0x3e2ebdc*/ nint GetSprite_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            static /*0x3e2ee60*/ int GetSpritesScripting_Injected(nint _unity_self, UnityEngine.Sprite[] sprites);
            static /*0x3e2eea4*/ int GetSpritesWithNameScripting_Injected(nint _unity_self, UnityEngine.Sprite[] sprites, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            /*0x3e2eef8*/ SpriteAtlas();
            /*0x3e2e5c4*/ bool get_isVariant();
            /*0x3e2e678*/ string get_tag();
            /*0x3e2e7e8*/ int get_spriteCount();
            /*0x3e2e89c*/ bool CanBindTo(UnityEngine.Sprite sprite);
            /*0x3e2e9c4*/ UnityEngine.Sprite GetSprite(string name);
            /*0x3e2ec20*/ int GetSprites(UnityEngine.Sprite[] sprites);
            /*0x3e2eca4*/ int GetSprites(UnityEngine.Sprite[] sprites, string name);
            /*0x3e2ec24*/ int GetSpritesScripting(UnityEngine.Sprite[] sprites);
            /*0x3e2eca8*/ int GetSpritesWithNameScripting(UnityEngine.Sprite[] sprites, string name);
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
