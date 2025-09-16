class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7df2088*/ EmbeddedAttribute();
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
                /*0x7df2090*/ IsUnmanagedAttribute();
            }
        }
    }
}

namespace AOT
{
    class MonoPInvokeCallbackAttribute : System.Attribute
    {
        /*0x7df2098*/ MonoPInvokeCallbackAttribute(System.Type type);
    }
}

namespace UnityEngineInternal
{
    struct MathfInternal
    {
        static /*0x0*/ float FloatMinNormal;
        static /*0x4*/ float FloatMinDenormal;
        static /*0x8*/ bool IsFlushToZeroEnabled;

        static /*0x7df20a0*/ MathfInternal();
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

        /*0x7df2138*/ TypeInferenceRuleAttribute(UnityEngineInternal.TypeInferenceRules rule);
        /*0x7df21c8*/ TypeInferenceRuleAttribute(string rule);
        /*0x7df21f8*/ string ToString();
    }

    class GenericStack : System.Collections.Stack
    {
        /*0x7df2200*/ GenericStack();
    }
}

namespace Unity
{
    namespace Jobs
    {
        interface IJob
        {
            /*0x380cb08*/ void Execute();
        }

        class IJobExtensions
        {
            static /*0x38358cc*/ void EarlyJobInit<T>();
            static nint GetReflectionData<T>();
            static /*0x3907c14*/ Unity.Jobs.JobHandle Schedule<T>(T jobData, Unity.Jobs.JobHandle dependsOn);
            static /*0x3907c14*/ void Run<T>(T jobData);

            struct JobStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x38358cc*/ JobStruct();
                static /*0x38358cc*/ void Initialize();
                static /*0x383a8c4*/ void Execute(ref T data, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

                class ExecuteJobFunction<T> : System.MulticastDelegate
                {
                    ExecuteJobFunction(object object, nint method);
                    void Invoke(ref T data, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);
                }
            }
        }

        interface IJobFor
        {
            /*0x380cffc*/ void Execute(int index);
        }

        class IJobForExtensions
        {
            static /*0x38358cc*/ void EarlyJobInit<T>();
            static nint GetReflectionData<T>();
            static /*0x3907c14*/ Unity.Jobs.JobHandle ScheduleParallel<T>(T jobData, int arrayLength, int innerloopBatchCount, Unity.Jobs.JobHandle dependency);

            struct ForJobStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x38358cc*/ ForJobStruct();
                static /*0x38358cc*/ void Initialize();
                static /*0x383a8c4*/ void Execute(ref T jobData, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

                class ExecuteJobFunction<T> : System.MulticastDelegate
                {
                    ExecuteJobFunction(object object, nint method);
                    void Invoke(ref T data, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);
                }
            }
        }

        interface IJobParallelFor
        {
            /*0x380cffc*/ void Execute(int index);
        }

        class IJobParallelForExtensions
        {
            static /*0x38358cc*/ void EarlyJobInit<T>();
            static nint GetReflectionData<T>();
            static /*0x3907c14*/ Unity.Jobs.JobHandle Schedule<T>(T jobData, int arrayLength, int innerloopBatchCount, Unity.Jobs.JobHandle dependsOn);
            static /*0x3907c14*/ void Run<T>(T jobData, int arrayLength);

            struct ParallelForJobStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x38358cc*/ ParallelForJobStruct();
                static /*0x38358cc*/ void Initialize();
                static /*0x383a8c4*/ void Execute(ref T jobData, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

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

            static /*0x7df230c*/ void ScheduleBatchedJobs();
            static /*0x7df2258*/ void ScheduleBatchedJobsAndComplete(ref Unity.Jobs.JobHandle job);
            static /*0x7df22d0*/ bool ScheduleBatchedJobsAndIsCompleted(ref Unity.Jobs.JobHandle job);
            static /*0x7df2334*/ Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle job0, Unity.Jobs.JobHandle job1);
            static /*0x7df23b8*/ Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeArray<Unity.Jobs.JobHandle> jobs);
            static /*0x7df2474*/ Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeSlice<Unity.Jobs.JobHandle> jobs);
            static /*0x7df235c*/ Unity.Jobs.JobHandle CombineDependenciesInternal2(ref Unity.Jobs.JobHandle job0, ref Unity.Jobs.JobHandle job1);
            static /*0x7df2418*/ Unity.Jobs.JobHandle CombineDependenciesInternalPtr(void* jobs, int count);
            static /*0x7df250c*/ void CombineDependenciesInternal2_Injected(ref Unity.Jobs.JobHandle job0, ref Unity.Jobs.JobHandle job1, ref Unity.Jobs.JobHandle ret);
            static /*0x7df2560*/ void CombineDependenciesInternalPtr_Injected(void* jobs, int count, ref Unity.Jobs.JobHandle ret);
            /*0x7df2208*/ void Complete();
            /*0x7df2294*/ bool get_IsCompleted();
            /*0x7df25b4*/ bool Equals(Unity.Jobs.JobHandle other);
        }

        namespace LowLevel
        {
            namespace Unsafe
            {
                class JobProducerTypeAttribute : System.Attribute
                {
                    /*0x10*/ System.Type <ProducerType>k__BackingField;

                    /*0x7df25c4*/ JobProducerTypeAttribute(System.Type producerType);
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

                    static /*0x7df25f4*/ void GetJobRange(ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex, ref int beginIndex, ref int endIndex);
                    static /*0x7df263c*/ bool GetWorkStealingRange(ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex, ref int beginIndex, ref int endIndex);
                    static /*0x7df2698*/ Unity.Jobs.JobHandle Schedule(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters);
                    static /*0x7df2730*/ Unity.Jobs.JobHandle ScheduleParallelFor(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount);
                    static /*0x7df27f8*/ Unity.Jobs.JobHandle ScheduleParallelForTransform(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, nint transfromAccesssArray);
                    static /*0x7df28a8*/ nint CreateJobReflectionData(System.Type wrapperJobType, System.Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2);
                    static /*0x7df2914*/ nint CreateJobReflectionData(System.Type type, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2);
                    static /*0x7df2974*/ bool get_IsExecutingJob();
                    static /*0x7df299c*/ void set_JobCompilerEnabled(bool value);
                    static /*0x7df29d8*/ int GetJobQueueWorkerThreadCount();
                    static /*0x7df2a00*/ int get_JobWorkerCount();
                    static /*0x7df2a28*/ int get_ThreadIndex();
                    static /*0x7df2a50*/ int get_ThreadIndexCount();
                    static /*0x7df2a78*/ void InvokePanicFunction();
                    static /*0x7df26ec*/ void Schedule_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, ref Unity.Jobs.JobHandle ret);
                    static /*0x7df279c*/ void ScheduleParallelFor_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, ref Unity.Jobs.JobHandle ret);
                    static /*0x7df2854*/ void ScheduleParallelForTransform_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, nint transfromAccesssArray, ref Unity.Jobs.JobHandle ret);

                    struct JobScheduleParameters
                    {
                        /*0x10*/ Unity.Jobs.JobHandle Dependency;
                        /*0x20*/ int ScheduleMode;
                        /*0x28*/ nint ReflectionData;
                        /*0x30*/ nint JobDataPtr;

                        /*0x7df2adc*/ JobScheduleParameters(void* i_jobData, nint i_reflectionData, Unity.Jobs.JobHandle i_dependency, Unity.Jobs.LowLevel.Unsafe.ScheduleMode i_scheduleMode);
                    }

                    class PanicFunction_ : System.MulticastDelegate
                    {
                        /*0x7df2b14*/ PanicFunction_(object object, nint method);
                        /*0x7df2bb0*/ void Invoke();
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

            static /*0x7df3090*/ DiscreteTime();
            static /*0x7df2da8*/ Unity.IntegerTime.DiscreteTime FromTicks(long v);
            static /*0x7df2dac*/ float op_Explicit(Unity.IntegerTime.DiscreteTime d);
            static /*0x7df2dc4*/ double op_Explicit(Unity.IntegerTime.DiscreteTime d);
            static /*0x7df2dd8*/ bool op_Inequality(Unity.IntegerTime.DiscreteTime lhs, Unity.IntegerTime.DiscreteTime rhs);
            static /*0x7df2de4*/ bool op_GreaterThan(Unity.IntegerTime.DiscreteTime lhs, Unity.IntegerTime.DiscreteTime rhs);
            static /*0x7df2df0*/ bool op_GreaterThanOrEqual(Unity.IntegerTime.DiscreteTime lhs, Unity.IntegerTime.DiscreteTime rhs);
            static /*0x7df2dfc*/ Unity.IntegerTime.DiscreteTime op_Addition(Unity.IntegerTime.DiscreteTime lhs, Unity.IntegerTime.DiscreteTime rhs);
            static /*0x7df2e5c*/ Unity.IntegerTime.DiscreteTime op_Subtraction(Unity.IntegerTime.DiscreteTime lhs, Unity.IntegerTime.DiscreteTime rhs);
            /*0x7df2bc4*/ DiscreteTime(float v);
            /*0x7df2cb4*/ DiscreteTime(double v);
            /*0x7df2da0*/ DiscreteTime(long v, int _);
            /*0x7df2ebc*/ bool Equals(Unity.IntegerTime.DiscreteTime rhs);
            /*0x7df2ecc*/ bool Equals(object o);
            /*0x7df2f68*/ int GetHashCode();
            /*0x7df2f70*/ string ToString();
            /*0x7df2ff0*/ string ToString(string format, System.IFormatProvider formatProvider);
            /*0x7df3088*/ int CompareTo(Unity.IntegerTime.DiscreteTime other);
        }

        struct RationalTime
        {
            /*0x10*/ long m_Count;
            /*0x18*/ Unity.IntegerTime.RationalTime.TicksPerSecond m_TicksPerSecond;

            static /*0x7df31d8*/ Unity.IntegerTime.DiscreteTime op_Explicit(Unity.IntegerTime.RationalTime t);
            /*0x7df31d0*/ long get_Count();

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

                static /*0x7df3550*/ TicksPerSecond();
                static /*0x7df3344*/ void Simplify(ref uint num, ref uint den);
                static /*0x7df3524*/ uint Gcd(uint a, uint b);
                /*0x7df32d0*/ TicksPerSecond(uint num, uint den);
                /*0x7df33ec*/ bool Equals(Unity.IntegerTime.RationalTime.TicksPerSecond rhs);
                /*0x7df3414*/ bool Equals(object rhs);
                /*0x7df34b0*/ int GetHashCode();
            }
        }

        class RationalTimeExtensions
        {
            static /*0x7df327c*/ Unity.IntegerTime.RationalTime Convert(Unity.IntegerTime.RationalTime time, Unity.IntegerTime.RationalTime.TicksPerSecond rate);
            static /*0x7df3774*/ void Convert_Injected(ref Unity.IntegerTime.RationalTime time, ref Unity.IntegerTime.RationalTime.TicksPerSecond rate, ref Unity.IntegerTime.RationalTime ret);
        }
    }

    namespace IL2CPP
    {
        namespace CompilerServices
        {
            class Il2CppEagerStaticClassConstructionAttribute : System.Attribute
            {
                /*0x7df37c8*/ Il2CppEagerStaticClassConstructionAttribute();
            }
        }
    }

    namespace Profiling
    {
        class IgnoredByDeepProfilerAttribute : System.Attribute
        {
            /*0x7df37d0*/ IgnoredByDeepProfilerAttribute();
        }

        struct ProfilerCategory
        {
            /*0x10*/ ushort m_CategoryId;

            static /*0x7df3b78*/ Unity.Profiling.ProfilerCategory get_Render();
            static /*0x7df3b80*/ Unity.Profiling.ProfilerCategory get_Scripts();
            static /*0x7df3b88*/ Unity.Profiling.ProfilerCategory get_Loading();
            static /*0x7df3b90*/ ushort op_Implicit(Unity.Profiling.ProfilerCategory category);
            /*0x7df37d8*/ ProfilerCategory(string categoryName, Unity.Profiling.ProfilerCategoryColor color);
            /*0x7df3970*/ ProfilerCategory(ushort category);
            /*0x7df3978*/ string get_Name();
            /*0x7df3b74*/ string ToString();
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

            /*0x7df3b94*/ ProfilerMarker(string name);
            /*0x7df3d50*/ ProfilerMarker(Unity.Profiling.ProfilerCategory category, string name);
            /*0x7df3d74*/ Unity.Profiling.ProfilerMarker.AutoScope Auto();

            struct AutoScope : System.IDisposable
            {
                /*0x10*/ nint m_Ptr;

                /*0x7df3dbc*/ AutoScope(nint markerPtr);
                /*0x7df3e48*/ void Dispose();
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

            /*0x7df3ed0*/ long get_Count();
        }

        struct ProfilerRecorder : System.IDisposable
        {
            static Unity.Profiling.ProfilerRecorderOptions SharedRecorder = 128;
            /*0x10*/ ulong handle;

            static /*0x7df3f9c*/ Unity.Profiling.ProfilerRecorder StartNew(Unity.Profiling.ProfilerCategory category, string statName, int capacity, Unity.Profiling.ProfilerRecorderOptions options);
            static /*0x7df3f18*/ Unity.Profiling.ProfilerRecorder Create(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int maxSampleCount, Unity.Profiling.ProfilerRecorderOptions options);
            static /*0x7df4138*/ void Control(Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.ControlOptions options);
            static /*0x7df421c*/ long GetLastValue(Unity.Profiling.ProfilerRecorder handle);
            static /*0x7df42ac*/ int GetCount(Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.CountOptions countOptions);
            static /*0x7df4048*/ bool GetValid(Unity.Profiling.ProfilerRecorder handle);
            static /*0x7df4344*/ bool GetRunning(Unity.Profiling.ProfilerRecorder handle);
            static /*0x7df43dc*/ Unity.Profiling.ProfilerRecorderSample GetSampleInternal(Unity.Profiling.ProfilerRecorder handle, int index);
            static /*0x7df4448*/ void Create_Injected(ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int maxSampleCount, Unity.Profiling.ProfilerRecorderOptions options, ref Unity.Profiling.ProfilerRecorder ret);
            static /*0x7df44a4*/ void Control_Injected(ref Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.ControlOptions options);
            static /*0x7df44e8*/ long GetLastValue_Injected(ref Unity.Profiling.ProfilerRecorder handle);
            static /*0x7df4524*/ int GetCount_Injected(ref Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.CountOptions countOptions);
            static /*0x7df4568*/ bool GetValid_Injected(ref Unity.Profiling.ProfilerRecorder handle);
            static /*0x7df45a4*/ bool GetRunning_Injected(ref Unity.Profiling.ProfilerRecorder handle);
            static /*0x7df45e0*/ void GetSampleInternal_Injected(ref Unity.Profiling.ProfilerRecorder handle, int index, ref Unity.Profiling.ProfilerRecorderSample ret);
            /*0x7df3ed8*/ ProfilerRecorder(Unity.Profiling.ProfilerCategory category, char* statName, int statNameLen, int capacity, Unity.Profiling.ProfilerRecorderOptions options);
            /*0x7df3f78*/ ProfilerRecorder(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int capacity, Unity.Profiling.ProfilerRecorderOptions options);
            /*0x7df3ff4*/ bool get_Valid();
            /*0x7df408c*/ void Start();
            /*0x7df4180*/ void Stop();
            /*0x7df41d0*/ long get_LastValue();
            /*0x7df425c*/ int get_Count();
            /*0x7df42f4*/ bool get_IsRunning();
            /*0x7df4388*/ Unity.Profiling.ProfilerRecorderSample GetSample(int index);
            /*0x7df4634*/ void Dispose();
            /*0x7df40dc*/ void CheckInitializedAndThrow();

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

            /*0x7df4688*/ void set_RawImageDataReference(Unity.Collections.NativeArray<byte> value);
            /*0x7df4690*/ void set_ImageFormat(UnityEngine.TextureFormat value);
            /*0x7df4698*/ void set_Width(int value);
            /*0x7df46a0*/ void set_Height(int value);
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

                    /*0x7df46a8*/ Unity.Profiling.LowLevel.MarkerFlags get_Flags();
                }

                struct ProfilerRecorderHandle
                {
                    /*0x10*/ ulong handle;

                    static /*0x7df46cc*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescription(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle);
                    static /*0x7df4818*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName__Unmanaged(Unity.Profiling.ProfilerCategory category, byte* name, int nameLen);
                    static /*0x7df48d8*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName(Unity.Profiling.ProfilerCategory category, char* name, int nameLen);
                    static /*0x7df48e0*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName_Unsafe(Unity.Profiling.ProfilerCategory category, char* name, int nameLen);
                    static /*0x7df4794*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescriptionInternal(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle);
                    static /*0x7df487c*/ void GetByName__Unmanaged_Injected(ref Unity.Profiling.ProfilerCategory category, byte* name, int nameLen, ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ret);
                    static /*0x7df4944*/ void GetByName_Unsafe_Injected(ref Unity.Profiling.ProfilerCategory category, char* name, int nameLen, ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ret);
                    static /*0x7df49a0*/ void GetDescriptionInternal_Injected(ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle, ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription ret);
                    /*0x7df46b0*/ ProfilerRecorderHandle(ulong handle);
                    /*0x7df46b8*/ bool get_Valid();
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
                    static /*0x7df37f8*/ ushort CreateCategory(string name, Unity.Profiling.ProfilerCategoryColor colorIndex);
                    static /*0x7df4a28*/ ushort CreateCategory__Unmanaged(byte* name, int nameLen, Unity.Profiling.ProfilerCategoryColor colorIndex);
                    static /*0x7df39f8*/ Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription GetCategoryDescription(ushort categoryId);
                    static /*0x7df3bc0*/ nint CreateMarker(string name, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, int metadataCount);
                    static /*0x7df4b1c*/ nint CreateMarker__Unmanaged(byte* name, int nameLen, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, int metadataCount);
                    static /*0x7df4b88*/ void SetMarkerMetadata__Unmanaged(nint markerPtr, int index, byte* name, int nameLen, byte type, byte unit);
                    static /*0x7df3e0c*/ void BeginSample(nint markerPtr);
                    static /*0x7df3e94*/ void EndSample(nint markerPtr);
                    static /*0x7df4bfc*/ void* CreateCounterValue__Unmanaged(ref nint counterPtr, byte* name, int nameLen, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, Unity.Profiling.ProfilerCounterOptions counterOptions);
                    static /*0x7df3a88*/ string Utf8ToString(byte* chars, int charsLen);
                    static /*0x7df49e4*/ ushort CreateCategory_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, Unity.Profiling.ProfilerCategoryColor colorIndex);
                    static /*0x7df4a7c*/ void GetCategoryDescription_Injected(ushort categoryId, ref Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription ret);
                    static /*0x7df4ac0*/ nint CreateMarker_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, int metadataCount);
                }
            }
        }

        namespace Memory
        {
            class MemorySnapshotMetadata
            {
                /*0x10*/ string <Description>k__BackingField;
                /*0x18*/ byte[] <Data>k__BackingField;

                /*0x7df4cb0*/ MemorySnapshotMetadata();
                /*0x7df4c98*/ string get_Description();
                /*0x7df4ca0*/ void set_Description(string value);
                /*0x7df4ca8*/ byte[] get_Data();
            }

            class MemoryProfiler
            {
                static /*0x0*/ System.Action<string, bool> m_SnapshotFinished;
                static /*0x8*/ System.Action<string, bool, Unity.Profiling.DebugScreenCapture> m_SaveScreenshotToDisk;
                static /*0x10*/ System.Action<Unity.Profiling.Memory.MemorySnapshotMetadata> CreatingMetadata;

                static /*0x7df4cb8*/ byte[] PrepareMetadata();
                static /*0x7df4ec0*/ int WriteIntToByteArray(byte[] array, int offset, int value);
                static /*0x7df4f4c*/ int WriteStringToByteArray(byte[] array, int offset, string value);
                static /*0x7df503c*/ void FinalizeSnapshot(string path, bool result);
                static /*0x7df50d0*/ void SaveScreenshotToDisk(string path, bool result, nint pixelsPtr, int pixelsCount, UnityEngine.TextureFormat format, int width, int height);
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

                    static /*0x7df5264*/ bool IsFileHandleValid(ref Unity.IO.LowLevel.Unsafe.FileHandle handle);
                    static /*0x7df52a0*/ Unity.Jobs.JobHandle GetJobHandle_Internal(ref Unity.IO.LowLevel.Unsafe.FileHandle handle);
                    static /*0x7df5434*/ void GetJobHandle_Internal_Injected(ref Unity.IO.LowLevel.Unsafe.FileHandle handle, ref Unity.Jobs.JobHandle ret);
                    /*0x7df51d4*/ Unity.Jobs.JobHandle get_JobHandle();
                    /*0x7df52f4*/ bool IsValid();
                    /*0x7df5330*/ Unity.Jobs.JobHandle Close(Unity.Jobs.JobHandle dependency);
                }

                struct ReadHandle : System.IDisposable
                {
                    /*0x10*/ nint ptr;
                    /*0x18*/ int version;

                    static /*0x7df567c*/ void CancelInternal(Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7df57b0*/ Unity.IO.LowLevel.Unsafe.ReadStatus GetReadStatus(Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7df55d0*/ void ReleaseReadHandle(Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7df5484*/ bool IsReadHandleValid(Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7df5764*/ Unity.Jobs.JobHandle GetJobHandle(Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7df56bc*/ void CancelInternal_Injected(ref Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7df57f0*/ Unity.IO.LowLevel.Unsafe.ReadStatus GetReadStatus_Injected(ref Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7df582c*/ void ReleaseReadHandle_Injected(ref Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7df5868*/ bool IsReadHandleValid_Injected(ref Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7df58a4*/ void GetJobHandle_Injected(ref Unity.IO.LowLevel.Unsafe.ReadHandle handle, ref Unity.Jobs.JobHandle ret);
                    /*0x7df5478*/ bool IsValid();
                    /*0x7df54c8*/ void Dispose();
                    /*0x7df5610*/ void Cancel();
                    /*0x7df56f8*/ Unity.Jobs.JobHandle get_JobHandle();
                    /*0x7df5564*/ Unity.IO.LowLevel.Unsafe.ReadStatus get_Status();
                }

                class AsyncReadManager
                {
                    static /*0x7df58e8*/ Unity.IO.LowLevel.Unsafe.ReadHandle GetFileInfoInternal(string filename, void* cmd);
                    static /*0x7df5ad4*/ Unity.IO.LowLevel.Unsafe.ReadHandle GetFileInfo(string filename, Unity.IO.LowLevel.Unsafe.FileInfoResult* result);
                    static /*0x7df5b28*/ Unity.IO.LowLevel.Unsafe.ReadHandle ReadWithHandlesInternal_NativeCopy(ref Unity.IO.LowLevel.Unsafe.FileHandle fileHandle, void* readCmdArray);
                    static /*0x7df5bd8*/ Unity.IO.LowLevel.Unsafe.ReadHandle Read(ref Unity.IO.LowLevel.Unsafe.FileHandle fileHandle, Unity.IO.LowLevel.Unsafe.ReadCommandArray readCmdArray);
                    static /*0x7df5c7c*/ Unity.IO.LowLevel.Unsafe.FileHandle OpenFileAsync_Internal(string fileName);
                    static /*0x7df5e50*/ Unity.IO.LowLevel.Unsafe.FileHandle OpenFileAsync(string fileName);
                    static /*0x7df53d8*/ Unity.Jobs.JobHandle CloseFileAsync(ref Unity.IO.LowLevel.Unsafe.FileHandle fileHandle, Unity.Jobs.JobHandle dependency);
                    static /*0x7df5a80*/ void GetFileInfoInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper filename, void* cmd, ref Unity.IO.LowLevel.Unsafe.ReadHandle ret);
                    static /*0x7df5b84*/ void ReadWithHandlesInternal_NativeCopy_Injected(ref Unity.IO.LowLevel.Unsafe.FileHandle fileHandle, void* readCmdArray, ref Unity.IO.LowLevel.Unsafe.ReadHandle ret);
                    static /*0x7df5e0c*/ void OpenFileAsync_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper fileName, ref Unity.IO.LowLevel.Unsafe.FileHandle ret);
                    static /*0x7df5eb4*/ void CloseFileAsync_Injected(ref Unity.IO.LowLevel.Unsafe.FileHandle fileHandle, ref Unity.Jobs.JobHandle dependency, ref Unity.Jobs.JobHandle ret);
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
            static /*0x3830700*/ string SerializedView<T>(System.Collections.Generic.IEnumerable<T> collection, System.Func<T, string> serializeElement);

            class <>c__DisplayClass3_0<T>
            {
                /*0x0*/ System.Func<T, string> serializeElement;

                /*0x380cb08*/ <>c__DisplayClass3_0();
                /*0x3907c14*/ string <SerializedView>b__0(T t);
            }
        }

        class ReadOnlyAttribute : System.Attribute
        {
            /*0x7df5f08*/ ReadOnlyAttribute();
        }

        class WriteOnlyAttribute : System.Attribute
        {
            /*0x7df5f10*/ WriteOnlyAttribute();
        }

        class DeallocateOnJobCompletionAttribute : System.Attribute
        {
            /*0x7df5f18*/ DeallocateOnJobCompletionAttribute();
        }

        class NativeFixedLengthAttribute : System.Attribute
        {
        }

        class NativeMatchesParallelForLengthAttribute : System.Attribute
        {
        }

        class NativeDisableParallelForRestrictionAttribute : System.Attribute
        {
            /*0x7df5f20*/ NativeDisableParallelForRestrictionAttribute();
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
            static /*0x3907c14*/ bool op_Equality(Unity.Collections.NativeArray<T> left, Unity.Collections.NativeArray<T> right);
            static /*0x3907c14*/ void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst);
            static /*0x3907c14*/ void Copy(T[] src, Unity.Collections.NativeArray<T> dst);
            static /*0x3907c14*/ void Copy(Unity.Collections.NativeArray<T> src, T[] dst);
            static /*0x3907c14*/ void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst, int length);
            static /*0x3907c14*/ void Copy(Unity.Collections.NativeArray<T> src, T[] dst, int length);
            static /*0x3907c14*/ void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
            static /*0x3907c14*/ void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length);
            static /*0x3907c14*/ void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
            static /*0x3907c14*/ void CopySafe(T[] src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
            static /*0x3907c14*/ void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length);
            static /*0x3907c14*/ System.Span<T> op_Implicit(ref Unity.Collections.NativeArray<T> source);
            static /*0x3907c14*/ System.ReadOnlySpan<T> op_Implicit(ref Unity.Collections.NativeArray<T> source);
            NativeArray(int length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options);
            /*0x380d8b8*/ NativeArray(T[] array, Unity.Collections.Allocator allocator);
            /*0x3907c14*/ NativeArray(Unity.Collections.NativeArray<T> array, Unity.Collections.Allocator allocator);
            /*0x380b6a0*/ int get_Length();
            /*0x3907c14*/ T get_Item(int index);
            /*0x3907c14*/ void set_Item(int index, T value);
            /*0x380b128*/ bool get_IsCreated();
            /*0x380cb08*/ void Dispose();
            /*0x3907c14*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
            /*0x380d83c*/ void CopyFrom(T[] array);
            /*0x3907c14*/ void CopyFrom(Unity.Collections.NativeArray<T> array);
            /*0x380d83c*/ void CopyTo(T[] array);
            /*0x380b9e8*/ T[] ToArray();
            /*0x3907c14*/ Unity.Collections.NativeArray.Enumerator<T> GetEnumerator();
            /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x3907c14*/ bool Equals(Unity.Collections.NativeArray<T> other);
            /*0x380b2f0*/ bool Equals(object obj);
            /*0x380b6a0*/ int GetHashCode();
            /*0x3907c14*/ Unity.Collections.NativeArray<U> InternalReinterpret<U>(int length);
            /*0x3907c14*/ Unity.Collections.NativeArray<U> Reinterpret<U>();
            /*0x3907c14*/ Unity.Collections.NativeArray<U> Reinterpret<U>(int expectedTypeSize);
            /*0x3907c14*/ Unity.Collections.NativeArray<T> GetSubArray(int start, int length);
            /*0x3907c14*/ Unity.Collections.NativeArray.ReadOnly<T> AsReadOnly();
            /*0x3907c14*/ System.Span<T> AsSpan();
            /*0x3907c14*/ System.ReadOnlySpan<T> AsReadOnlySpan();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.NativeArray<T> m_Array;
                /*0x0*/ int m_Index;
                /*0x0*/ T value;

                /*0x380d83c*/ Enumerator(ref Unity.Collections.NativeArray<T> array);
                /*0x380cb08*/ void Dispose();
                /*0x380b128*/ bool MoveNext();
                /*0x380cb08*/ void Reset();
                /*0x3907c14*/ T get_Current();
                /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
            }

            struct ReadOnly<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                /*0x0*/ void* m_Buffer;
                /*0x0*/ int m_Length;

                static /*0x3907c14*/ System.ReadOnlySpan<T> op_Implicit(ref Unity.Collections.NativeArray.ReadOnly<T> source);
                /*0x3907c14*/ ReadOnly(void* buffer, int length);
                /*0x380b6a0*/ int get_Length();
                /*0x3907c14*/ T get_Item(int index);
                /*0x380ba90*/ ref T UnsafeElementAt(int index);
                /*0x3907c14*/ Unity.Collections.NativeArray.ReadOnly.Enumerator<T> GetEnumerator();
                /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3907c14*/ System.ReadOnlySpan<T> AsReadOnlySpan();

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ Unity.Collections.NativeArray.ReadOnly<T> m_Array;
                    /*0x0*/ int m_Index;
                    /*0x0*/ T value;

                    /*0x380d83c*/ Enumerator(ref Unity.Collections.NativeArray.ReadOnly<T> array);
                    /*0x380cb08*/ void Dispose();
                    /*0x380b128*/ bool MoveNext();
                    /*0x380cb08*/ void Reset();
                    /*0x3907c14*/ T get_Current();
                    /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
                }
            }
        }

        struct NativeArrayDispose
        {
            /*0x10*/ void* m_Buffer;
            /*0x18*/ Unity.Collections.Allocator m_AllocatorLabel;

            /*0x7df5f28*/ void Dispose();
        }

        struct NativeArrayDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeArrayDispose Data;

            static /*0x7df5ff4*/ void RegisterNativeArrayDisposeJobReflectionData();
            /*0x7df5fb0*/ void Execute();
        }

        class NativeArrayDebugView<T>
        {
        }

        class NativeArrayReadOnlyDebugView<T>
        {
        }

        class NativeSliceExtensions
        {
            static /*0x3907c14*/ Unity.Collections.NativeSlice<T> Slice<T>(Unity.Collections.NativeArray<T> thisArray, int start, int length);
            static /*0x3907c14*/ Unity.Collections.NativeSlice<T> Slice<T>(Unity.Collections.NativeSlice<T> thisSlice, int start, int length);
        }

        struct NativeSlice<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.NativeSlice<T>>
        {
            /*0x0*/ byte* m_Buffer;
            /*0x0*/ int m_Stride;
            /*0x0*/ int m_Length;

            static /*0x3907c14*/ Unity.Collections.NativeSlice<T> op_Implicit(Unity.Collections.NativeArray<T> array);
            /*0x3907c14*/ NativeSlice(Unity.Collections.NativeSlice<T> slice, int start, int length);
            /*0x3907c14*/ NativeSlice(Unity.Collections.NativeArray<T> array);
            /*0x3907c14*/ NativeSlice(Unity.Collections.NativeArray<T> array, int start, int length);
            /*0x3907c14*/ T get_Item(int index);
            /*0x3907c14*/ void set_Item(int index, T value);
            /*0x3907c14*/ void CopyFrom(Unity.Collections.NativeSlice<T> slice);
            /*0x380b6a0*/ int get_Stride();
            /*0x380b6a0*/ int get_Length();
            /*0x3907c14*/ Unity.Collections.NativeSlice.Enumerator<T> GetEnumerator();
            /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x3907c14*/ bool Equals(Unity.Collections.NativeSlice<T> other);
            /*0x380b2f0*/ bool Equals(object obj);
            /*0x380b6a0*/ int GetHashCode();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.NativeSlice<T> m_Array;
                /*0x0*/ int m_Index;

                /*0x380d83c*/ Enumerator(ref Unity.Collections.NativeSlice<T> array);
                /*0x380cb08*/ void Dispose();
                /*0x380b128*/ bool MoveNext();
                /*0x380cb08*/ void Reset();
                /*0x3907c14*/ T get_Current();
                /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
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

                        static /*0x3907c14*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<T> GetOrCreate<TContext>(uint alignment);
                        /*0x3907c14*/ SharedStatic(void* buffer);
                        /*0x380b9e8*/ ref T get_Data();
                    }

                    class SharedStatic
                    {
                        static /*0x7df6034*/ void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment);
                    }
                }

                class BurstRuntime
                {
                    static /*0x382c454*/ long GetHashCode64<T>();
                    static /*0x7df60fc*/ long HashStringWithFNV1A64(string text);

                    struct HashCode64<T>
                    {
                        static /*0x0*/ long Value;

                        static /*0x38358cc*/ HashCode64();
                    }
                }

                class NativeContainerAttribute : System.Attribute
                {
                    /*0x7df6188*/ NativeContainerAttribute();
                }

                class NativeContainerIsReadOnlyAttribute : System.Attribute
                {
                    /*0x7df6190*/ NativeContainerIsReadOnlyAttribute();
                }

                class NativeContainerIsAtomicWriteOnlyAttribute : System.Attribute
                {
                    /*0x7df6198*/ NativeContainerIsAtomicWriteOnlyAttribute();
                }

                class NativeContainerSupportsMinMaxWriteRestrictionAttribute : System.Attribute
                {
                    /*0x7df61a0*/ NativeContainerSupportsMinMaxWriteRestrictionAttribute();
                }

                class NativeContainerSupportsDeallocateOnJobCompletionAttribute : System.Attribute
                {
                    /*0x7df61a8*/ NativeContainerSupportsDeallocateOnJobCompletionAttribute();
                }

                class NativeContainerSupportsDeferredConvertListToArray : System.Attribute
                {
                    /*0x7df61b0*/ NativeContainerSupportsDeferredConvertListToArray();
                }

                class NativeSetThreadIndexAttribute : System.Attribute
                {
                    /*0x7df61b8*/ NativeSetThreadIndexAttribute();
                }

                class NativeContainerNeedsThreadIndexAttribute : System.Attribute
                {
                }

                class WriteAccessRequiredAttribute : System.Attribute
                {
                    /*0x7df61c0*/ WriteAccessRequiredAttribute();
                }

                class NativeDisableUnsafePtrRestrictionAttribute : System.Attribute
                {
                    /*0x7df61c8*/ NativeDisableUnsafePtrRestrictionAttribute();
                }

                class NativeDisableContainerSafetyRestrictionAttribute : System.Attribute
                {
                    /*0x7df61d0*/ NativeDisableContainerSafetyRestrictionAttribute();
                }

                class NativeSetClassTypeToNullOnScheduleAttribute : System.Attribute
                {
                }

                class NativeArrayUnsafeUtility
                {
                    static /*0x3907c14*/ Unity.Collections.NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Unity.Collections.Allocator allocator);
                    static /*0x3907c14*/ void* GetUnsafePtr<T>(Unity.Collections.NativeArray<T> nativeArray);
                    static /*0x3907c14*/ void* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeArray<T> nativeArray);
                    static /*0x3907c14*/ void* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeArray.ReadOnly<T> nativeArray);
                    static /*0x3907c14*/ void* GetUnsafeBufferPointerWithoutChecks<T>(Unity.Collections.NativeArray<T> nativeArray);
                }

                class NativeSliceUnsafeUtility
                {
                    static /*0x3907c14*/ Unity.Collections.NativeSlice<T> ConvertExistingDataToNativeSlice<T>(void* dataPointer, int stride, int length);
                    static /*0x3907c14*/ void* GetUnsafePtr<T>(Unity.Collections.NativeSlice<T> nativeSlice);
                    static /*0x3907c14*/ void* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeSlice<T> nativeSlice);
                }

                class UnsafeUtility
                {
                    static /*0x3818690*/ bool IsBlittable<T>();
                    static /*0x7df61d8*/ int LeakRecord(nint handle, Unity.Collections.LeakCategory category, int callstacksToSkip);
                    static /*0x7df622c*/ int LeakErase(nint handle, Unity.Collections.LeakCategory category);
                    static /*0x7df6270*/ void* MallocTracked(long size, int alignment, Unity.Collections.Allocator allocator, int callstacksToSkip);
                    static /*0x7df5f6c*/ void FreeTracked(void* memory, Unity.Collections.Allocator allocator);
                    static /*0x7df62cc*/ void* Malloc(long size, int alignment, Unity.Collections.Allocator allocator);
                    static /*0x7df6320*/ void Free(void* memory, Unity.Collections.Allocator allocator);
                    static /*0x7df4fe8*/ void MemCpy(void* destination, void* source, long size);
                    static /*0x7df6364*/ void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count);
                    static /*0x7df63d8*/ void MemMove(void* destination, void* source, long size);
                    static /*0x7df642c*/ void MemSet(void* destination, byte value, long size);
                    static /*0x7df6480*/ void MemClear(void* destination, long size);
                    static /*0x7df64c8*/ int MemCmp(void* ptr1, void* ptr2, long size);
                    static /*0x7df651c*/ int SizeOf(System.Type type);
                    static /*0x7df6558*/ bool IsBlittable(System.Type type);
                    static /*0x7df6594*/ bool IsBlittableValueType(System.Type t);
                    static /*0x7df65f4*/ string GetReasonForTypeNonBlittableImpl(System.Type t, string name);
                    static /*0x7df67b0*/ bool IsArrayBlittable(System.Array arr);
                    static /*0x3818690*/ bool IsGenericListBlittable<T>();
                    static /*0x7df67e0*/ string GetReasonForArrayNonBlittable(System.Array arr);
                    static /*0x382dee4*/ string GetReasonForGenericListNonBlittable<T>();
                    static /*0x3821e38*/ int AlignOf<T>();
                    static /*0x3907c14*/ void CopyPtrToStructure<T>(void* ptr, ref T output);
                    static /*0x3907c14*/ void InternalCopyPtrToStructure<T>(void* ptr, ref T output);
                    static /*0x3907c14*/ T ReadArrayElement<T>(void* source, int index);
                    static /*0x3907c14*/ T ReadArrayElementWithStride<T>(void* source, int index, int stride);
                    static /*0x3907c14*/ void WriteArrayElement<T>(void* destination, int index, T value);
                    static /*0x3907c14*/ void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value);
                    static /*0x3907c14*/ void* AddressOf<T>(ref T output);
                    static /*0x3821e38*/ int SizeOf<T>();
                    static /*0x382eaf0*/ ref T As<U, T>(ref U from);
                    static /*0x3907c14*/ T As<T>(object from);
                    static /*0x3907c14*/ ref T AsRef<T>(void* ptr);
                    static /*0x3907c14*/ ref T ArrayElementAsRef<T>(void* ptr, int index);
                    static /*0x3907c14*/ int EnumToInt<T>(T enumValue);
                    static /*0x383af28*/ void InternalEnumToInt<T>(ref T enumValue, ref int intValue);
                    static /*0x3907c14*/ bool EnumEquals<T>(T lhs, T rhs);

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
            /*0x7df682c*/ BurstAuthorizedExternalMethodAttribute();
        }

        class BurstDiscardAttribute : System.Attribute
        {
            /*0x7df6834*/ BurstDiscardAttribute();
        }

        namespace LowLevel
        {
            class BurstCompilerService
            {
                static /*0x7df683c*/ int CompileAsyncDelegateMethod(object delegateMethod, string compilerOptions);
                static /*0x7df69f8*/ void* GetAsyncCompiledAsyncDelegateMethod(int userID);
                static /*0x7df60a8*/ void* GetOrCreateSharedMemory(ref UnityEngine.Hash128 key, uint size_of, uint alignment);
                static /*0x7df6a34*/ void Log(void* userData, Unity.Burst.LowLevel.BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber);
                static /*0x7df6aa0*/ void RuntimeLog(void* userData, Unity.Burst.LowLevel.BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber);
                static /*0x7df69b4*/ int CompileAsyncDelegateMethod_Injected(object delegateMethod, ref UnityEngine.Bindings.ManagedSpanWrapper compilerOptions);

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
            /*0x7df6b0c*/ CanBeNullAttribute();
        }

        class NotNullAttribute : System.Attribute
        {
            /*0x7df6b14*/ NotNullAttribute();
        }

        class UsedImplicitlyAttribute : System.Attribute
        {
            /*0x10*/ JetBrains.Annotations.ImplicitUseKindFlags <UseKindFlags>k__BackingField;
            /*0x14*/ JetBrains.Annotations.ImplicitUseTargetFlags <TargetFlags>k__BackingField;

            /*0x7df6b1c*/ UsedImplicitlyAttribute();
            /*0x7df6b40*/ UsedImplicitlyAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, JetBrains.Annotations.ImplicitUseTargetFlags targetFlags);
        }

        class MeansImplicitUseAttribute : System.Attribute
        {
            /*0x10*/ JetBrains.Annotations.ImplicitUseKindFlags <UseKindFlags>k__BackingField;
            /*0x14*/ JetBrains.Annotations.ImplicitUseTargetFlags <TargetFlags>k__BackingField;

            /*0x7df6b6c*/ MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags);
            /*0x7df6b98*/ MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, JetBrains.Annotations.ImplicitUseTargetFlags targetFlags);
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

        class PureAttribute : System.Attribute
        {
            /*0x7df6bc4*/ PureAttribute();
        }

        class MustUseReturnValueAttribute : System.Attribute
        {
            /*0x7df6bcc*/ MustUseReturnValueAttribute();
        }

        class CollectionAccessAttribute : System.Attribute
        {
            /*0x10*/ JetBrains.Annotations.CollectionAccessType <CollectionAccessType>k__BackingField;

            /*0x7df6bd4*/ CollectionAccessAttribute(JetBrains.Annotations.CollectionAccessType collectionAccessType);
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

        static /*0x7df7040*/ bool get_shouldSupportTiling_Injected(nint _unity_self);
        static /*0x7df70f4*/ bool get_hasSpriteChangeEvents_Injected(nint _unity_self);
        static /*0x7df7130*/ void set_hasSpriteChangeEvents_Injected(nint _unity_self, bool value);
        static /*0x7df7208*/ nint get_sprite_Injected(nint _unity_self);
        static /*0x7df72f8*/ void set_sprite_Injected(nint _unity_self, nint value);
        static /*0x7df73b4*/ UnityEngine.SpriteDrawMode get_drawMode_Injected(nint _unity_self);
        static /*0x7df7470*/ void set_drawMode_Injected(nint _unity_self, UnityEngine.SpriteDrawMode value);
        static /*0x7df753c*/ void get_size_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7df7604*/ void set_size_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7df76c0*/ float get_adaptiveModeThreshold_Injected(nint _unity_self);
        static /*0x7df7784*/ void set_adaptiveModeThreshold_Injected(nint _unity_self, float value);
        static /*0x7df7848*/ UnityEngine.SpriteTileMode get_tileMode_Injected(nint _unity_self);
        static /*0x7df7904*/ void set_tileMode_Injected(nint _unity_self, UnityEngine.SpriteTileMode value);
        static /*0x7df79dc*/ void get_color_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x7df7ab0*/ void set_color_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x7df7b6c*/ UnityEngine.SpriteMaskInteraction get_maskInteraction_Injected(nint _unity_self);
        static /*0x7df7c28*/ void set_maskInteraction_Injected(nint _unity_self, UnityEngine.SpriteMaskInteraction value);
        static /*0x7df7ce4*/ bool get_flipX_Injected(nint _unity_self);
        static /*0x7df7da0*/ void set_flipX_Injected(nint _unity_self, bool value);
        static /*0x7df7e5c*/ bool get_flipY_Injected(nint _unity_self);
        static /*0x7df7f18*/ void set_flipY_Injected(nint _unity_self, bool value);
        static /*0x7df7fd4*/ UnityEngine.SpriteSortPoint get_spriteSortPoint_Injected(nint _unity_self);
        static /*0x7df8090*/ void set_spriteSortPoint_Injected(nint _unity_self, UnityEngine.SpriteSortPoint value);
        static /*0x7df814c*/ nint GetCurrentMeshDataPtr_Injected(nint _unity_self);
        static /*0x7df8294*/ void Internal_GetSpriteBounds_Injected(nint _unity_self, UnityEngine.SpriteDrawMode mode, ref UnityEngine.Bounds ret);
        static /*0x7df83c0*/ void GetSecondaryTextureProperties_Injected(nint _unity_self, nint mbp);
        /*0x7df844c*/ SpriteRenderer();
        /*0x7df6bfc*/ void RegisterSpriteChangeCallback(UnityEngine.Events.UnityAction<UnityEngine.SpriteRenderer> callback);
        /*0x7df6d40*/ void UnregisterSpriteChangeCallback(UnityEngine.Events.UnityAction<UnityEngine.SpriteRenderer> callback);
        /*0x7df6dc4*/ void InvokeSpriteChanged();
        /*0x7df6fc8*/ bool get_shouldSupportTiling();
        /*0x7df707c*/ bool get_hasSpriteChangeEvents();
        /*0x7df6cc0*/ void set_hasSpriteChangeEvents(bool value);
        /*0x7df7174*/ UnityEngine.Sprite get_sprite();
        /*0x7df7244*/ void set_sprite(UnityEngine.Sprite value);
        /*0x7df733c*/ UnityEngine.SpriteDrawMode get_drawMode();
        /*0x7df73f0*/ void set_drawMode(UnityEngine.SpriteDrawMode value);
        /*0x7df74b4*/ UnityEngine.Vector2 get_size();
        /*0x7df7580*/ void set_size(UnityEngine.Vector2 value);
        /*0x7df7648*/ float get_adaptiveModeThreshold();
        /*0x7df76fc*/ void set_adaptiveModeThreshold(float value);
        /*0x7df77d0*/ UnityEngine.SpriteTileMode get_tileMode();
        /*0x7df7884*/ void set_tileMode(UnityEngine.SpriteTileMode value);
        /*0x7df7948*/ UnityEngine.Color get_color();
        /*0x7df7a20*/ void set_color(UnityEngine.Color value);
        /*0x7df7af4*/ UnityEngine.SpriteMaskInteraction get_maskInteraction();
        /*0x7df7ba8*/ void set_maskInteraction(UnityEngine.SpriteMaskInteraction value);
        /*0x7df7c6c*/ bool get_flipX();
        /*0x7df7d20*/ void set_flipX(bool value);
        /*0x7df7de4*/ bool get_flipY();
        /*0x7df7e98*/ void set_flipY(bool value);
        /*0x7df7f5c*/ UnityEngine.SpriteSortPoint get_spriteSortPoint();
        /*0x7df8010*/ void set_spriteSortPoint(UnityEngine.SpriteSortPoint value);
        /*0x7df80d4*/ nint GetCurrentMeshDataPtr();
        /*0x7df8188*/ UnityEngine.Mesh.MeshDataArray GetCurrentMeshData();
        /*0x7df81e4*/ UnityEngine.Bounds Internal_GetSpriteBounds(UnityEngine.SpriteDrawMode mode);
        /*0x7df82e8*/ void GetSecondaryTextureProperties(UnityEngine.MaterialPropertyBlock mbp);
        /*0x7df8404*/ UnityEngine.Bounds GetSpriteBounds();
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
        static /*0x7df8af4*/ UnityEngine.Sprite CreateSpriteWithoutTextureScripting(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsToUnits, UnityEngine.Texture2D texture);
        static /*0x7df8c28*/ UnityEngine.Sprite CreateSprite(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[] secondaryTexture);
        static /*0x7dfa140*/ void GetPhysicsShapeImpl(UnityEngine.Sprite sprite, int shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2> physicsShape);
        static /*0x7dfa768*/ void OverridePhysicsShapeCount(UnityEngine.Sprite sprite, int physicsShapeCount);
        static /*0x7dfa7fc*/ void OverridePhysicsShape(UnityEngine.Sprite sprite, UnityEngine.Vector2[] physicsShape, int idx);
        static /*0x7dfabfc*/ UnityEngine.Sprite Create(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsToUnits, UnityEngine.Texture2D texture);
        static /*0x7dfac00*/ UnityEngine.Sprite Create(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsToUnits);
        static /*0x7dfac08*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape);
        static /*0x7dfac1c*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[] secondaryTextures);
        static /*0x7dfb088*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border);
        static /*0x7dfb09c*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType);
        static /*0x7dfb184*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude);
        static /*0x7dfb18c*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit);
        static /*0x7dfb198*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot);
        static /*0x7df8524*/ int GetPackingMode_Injected(nint _unity_self);
        static /*0x7df85d8*/ int GetPackingRotation_Injected(nint _unity_self);
        static /*0x7df868c*/ int GetPacked_Injected(nint _unity_self);
        static /*0x7df875c*/ void GetTextureRect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x7df8828*/ void GetTextureRectOffset_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7df8900*/ void GetInnerUVs_Injected(nint _unity_self, ref UnityEngine.Vector4 ret);
        static /*0x7df89d8*/ void GetOuterUVs_Injected(nint _unity_self, ref UnityEngine.Vector4 ret);
        static /*0x7df8ab0*/ void GetPadding_Injected(nint _unity_self, ref UnityEngine.Vector4 ret);
        static /*0x7df8bc4*/ nint CreateSpriteWithoutTextureScripting_Injected(ref UnityEngine.Rect rect, ref UnityEngine.Vector2 pivot, float pixelsToUnits, nint texture);
        static /*0x7df8d34*/ nint CreateSprite_Injected(nint texture, ref UnityEngine.Rect rect, ref UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, ref UnityEngine.Vector4 border, bool generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[] secondaryTexture);
        static /*0x7df8e74*/ void get_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x7df8f4c*/ void get_rect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x7df9024*/ void get_border_Injected(nint _unity_self, ref UnityEngine.Vector4 ret);
        static /*0x7df90fc*/ nint get_texture_Injected(nint _unity_self);
        static /*0x7df91dc*/ nint GetSecondaryTexture_Injected(nint _unity_self, int index);
        static /*0x7df9298*/ int GetSecondaryTextureCount_Injected(nint _unity_self);
        static /*0x7df9384*/ int GetSecondaryTextures_Injected(nint _unity_self, UnityEngine.SecondarySpriteTexture[] secondaryTexture);
        static /*0x7df9440*/ float get_pixelsPerUnit_Injected(nint _unity_self);
        static /*0x7df94f4*/ float get_spriteAtlasTextureScale_Injected(nint _unity_self);
        static /*0x7df95c4*/ nint get_associatedAlphaSplitTexture_Injected(nint _unity_self);
        static /*0x7df9688*/ void get_pivot_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7df976c*/ UnityEngine.Vector2[] get_vertices_Injected(nint _unity_self);
        static /*0x7df9820*/ ushort[] get_triangles_Injected(nint _unity_self);
        static /*0x7df98d4*/ UnityEngine.Vector2[] get_uv_Injected(nint _unity_self);
        static /*0x7df9988*/ int GetPhysicsShapeCount_Injected(nint _unity_self);
        static /*0x7df9a3c*/ uint GetScriptableObjectsCount_Injected(nint _unity_self);
        static /*0x7df9b28*/ uint GetScriptableObjects_Injected(nint _unity_self, UnityEngine.ScriptableObject[] scriptableObjects);
        static /*0x7df9c50*/ bool AddScriptableObject_Injected(nint _unity_self, nint obj);
        static /*0x7df9d14*/ bool RemoveScriptableObjectAt_Injected(nint _unity_self, uint i);
        static /*0x7df9e4c*/ bool SetScriptableObjectAt_Injected(nint _unity_self, nint obj, uint i);
        static /*0x7df9ff0*/ int Internal_GetPhysicsShapePointCount_Injected(nint _unity_self, int shapeIdx);
        static /*0x7dfa340*/ void GetPhysicsShapeImpl_Injected(nint sprite, int shapeIdx, ref UnityEngine.Bindings.BlittableListWrapper physicsShape);
        static /*0x7dfa93c*/ void OverridePhysicsShapeCount_Injected(nint sprite, int physicsShapeCount);
        static /*0x7dfa980*/ void OverridePhysicsShape_Injected(nint sprite, ref UnityEngine.Bindings.ManagedSpanWrapper physicsShape, int idx);
        static /*0x7dfaba8*/ void OverrideGeometry_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper vertices, ref UnityEngine.Bindings.ManagedSpanWrapper triangles);
        /*0x7df8454*/ Sprite();
        /*0x7df84ac*/ int GetPackingMode();
        /*0x7df8560*/ int GetPackingRotation();
        /*0x7df8614*/ int GetPacked();
        /*0x7df86c8*/ UnityEngine.Rect GetTextureRect();
        /*0x7df87a0*/ UnityEngine.Vector2 GetTextureRectOffset();
        /*0x7df886c*/ UnityEngine.Vector4 GetInnerUVs();
        /*0x7df8944*/ UnityEngine.Vector4 GetOuterUVs();
        /*0x7df8a1c*/ UnityEngine.Vector4 GetPadding();
        /*0x7df8dd0*/ UnityEngine.Bounds get_bounds();
        /*0x7df8eb8*/ UnityEngine.Rect get_rect();
        /*0x7df8f90*/ UnityEngine.Vector4 get_border();
        /*0x7df9068*/ UnityEngine.Texture2D get_texture();
        /*0x7df9138*/ UnityEngine.Texture2D GetSecondaryTexture(int index);
        /*0x7df9220*/ int GetSecondaryTextureCount();
        /*0x7df92d4*/ int GetSecondaryTextures(UnityEngine.SecondarySpriteTexture[] secondaryTexture);
        /*0x7df93c8*/ float get_pixelsPerUnit();
        /*0x7df947c*/ float get_spriteAtlasTextureScale();
        /*0x7df9530*/ UnityEngine.Texture2D get_associatedAlphaSplitTexture();
        /*0x7df9600*/ UnityEngine.Vector2 get_pivot();
        /*0x7df96cc*/ bool get_packed();
        /*0x7df96e4*/ UnityEngine.SpritePackingMode get_packingMode();
        /*0x7df96e8*/ UnityEngine.SpritePackingRotation get_packingRotation();
        /*0x7df96ec*/ UnityEngine.Rect get_textureRect();
        /*0x7df96f0*/ UnityEngine.Vector2 get_textureRectOffset();
        /*0x7df96f4*/ UnityEngine.Vector2[] get_vertices();
        /*0x7df97a8*/ ushort[] get_triangles();
        /*0x7df985c*/ UnityEngine.Vector2[] get_uv();
        /*0x7df9910*/ int GetPhysicsShapeCount();
        /*0x7df99c4*/ uint GetScriptableObjectsCount();
        /*0x7df9a78*/ uint GetScriptableObjects(UnityEngine.ScriptableObject[] scriptableObjects);
        /*0x7df9b6c*/ bool AddScriptableObject(UnityEngine.ScriptableObject obj);
        /*0x7df9c94*/ bool RemoveScriptableObjectAt(uint i);
        /*0x7df9d58*/ bool SetScriptableObjectAt(UnityEngine.ScriptableObject obj, uint i);
        /*0x7df9ea0*/ int GetPhysicsShapePointCount(int shapeIdx);
        /*0x7df9f70*/ int Internal_GetPhysicsShapePointCount(int shapeIdx);
        /*0x7dfa034*/ int GetPhysicsShape(int shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2> physicsShape);
        /*0x7dfa394*/ void OverridePhysicsShape(System.Collections.Generic.IList<UnityEngine.Vector2[]> physicsShapes);
        /*0x7dfa9d4*/ void OverrideGeometry(UnityEngine.Vector2[] vertices, ushort[] triangles);
    }

    struct SortingLayer
    {
        /*0x10*/ int m_Id;

        static /*0x7dfb1ac*/ int GetLayerValueFromID(int id);
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

        /*0x7dfb1e8*/ Keyframe(float time, float value);
        /*0x7dfb1f8*/ Keyframe(float time, float value, float inTangent, float outTangent);
        /*0x7dfb20c*/ float get_time();
        /*0x7dfb214*/ void set_time(float value);
        /*0x7dfb21c*/ float get_value();
        /*0x7dfb224*/ void set_value(float value);
        /*0x7dfb22c*/ float get_inTangent();
        /*0x7dfb234*/ void set_inTangent(float value);
        /*0x7dfb23c*/ float get_outTangent();
        /*0x7dfb244*/ void set_outTangent(float value);
        /*0x7dfb24c*/ float get_inWeight();
        /*0x7dfb254*/ void set_inWeight(float value);
        /*0x7dfb25c*/ float get_outWeight();
        /*0x7dfb264*/ void set_outWeight(float value);
        /*0x7dfb26c*/ UnityEngine.WeightedMode get_weightedMode();
        /*0x7dfb274*/ void set_weightedMode(UnityEngine.WeightedMode value);
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

        static /*0x7dfb27c*/ void Internal_Destroy(nint ptr);
        static /*0x7dfb2b8*/ nint Internal_Create(UnityEngine.Keyframe[] keys);
        static /*0x7dfbf60*/ UnityEngine.AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd);
        static /*0x7dfc0e8*/ UnityEngine.AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd);
        static /*0x7dfb384*/ nint Internal_Create_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keys);
        static /*0x7dfb418*/ bool Internal_Equals_Injected(nint _unity_self, nint other);
        static /*0x7dfb4b4*/ void Internal_CopyFrom_Injected(nint _unity_self, nint other);
        static /*0x7dfb61c*/ float Evaluate_Injected(nint _unity_self, float time);
        static /*0x7dfb8e4*/ int AddKey_Injected(nint _unity_self, float time, float value);
        static /*0x7dfb9bc*/ int AddKey_Internal_Injected(nint _unity_self, ref UnityEngine.Keyframe key);
        static /*0x7dfba68*/ int MoveKey_Injected(nint _unity_self, int index, ref UnityEngine.Keyframe key);
        static /*0x7dfbb0c*/ void ClearKeys_Injected(nint _unity_self);
        static /*0x7dfbba0*/ void RemoveKey_Injected(nint _unity_self, int index);
        static /*0x7dfbd00*/ int get_length_Injected(nint _unity_self);
        static /*0x7dfbd3c*/ void SetKeys_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keys);
        static /*0x7dfbd80*/ void GetKey_Injected(nint _unity_self, int index, ref UnityEngine.Keyframe ret);
        static /*0x7dfbdd4*/ void GetKeys_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7dfbe68*/ int GetHashCode_Injected(nint _unity_self);
        static /*0x7dfbf0c*/ void SmoothTangents_Injected(nint _unity_self, int index, float weight);
        /*0x7dfc0b0*/ AnimationCurve(UnityEngine.Keyframe[] keys);
        /*0x7dfc22c*/ AnimationCurve();
        /*0x7dfc258*/ AnimationCurve(nint ptr, bool ownMemory);
        /*0x7dfb3c0*/ bool Internal_Equals(nint other);
        /*0x7dfb45c*/ void Internal_CopyFrom(nint other);
        /*0x7dfb4f8*/ void Finalize();
        /*0x7dfb5bc*/ float Evaluate(float time);
        /*0x7dfb668*/ UnityEngine.Keyframe[] get_keys();
        /*0x7dfb788*/ void set_keys(UnityEngine.Keyframe[] value);
        /*0x7dfb87c*/ int AddKey(float time, float value);
        /*0x7dfb938*/ int AddKey(UnityEngine.Keyframe key);
        /*0x7dfb964*/ int AddKey_Internal(UnityEngine.Keyframe key);
        /*0x7dfba00*/ int MoveKey(int index, UnityEngine.Keyframe key);
        /*0x7dfbabc*/ void ClearKeys();
        /*0x7dfbb48*/ void RemoveKey(int index);
        /*0x7dfbbe4*/ UnityEngine.Keyframe get_Item(int index);
        /*0x7dfbcb0*/ int get_length();
        /*0x7dfb78c*/ void SetKeys(UnityEngine.Keyframe[] keys);
        /*0x7dfbc20*/ UnityEngine.Keyframe GetKey(int index);
        /*0x7dfb66c*/ UnityEngine.Keyframe[] GetKeys();
        /*0x7dfbe18*/ int GetHashCode();
        /*0x7dfbea4*/ void SmoothTangents(int index, float weight);
        /*0x7dfc288*/ bool Equals(object o);
        /*0x7dfc388*/ bool Equals(UnityEngine.AnimationCurve other);
        /*0x7dfc40c*/ void CopyFrom(UnityEngine.AnimationCurve other);

        class BindingsMarshaller
        {
            static /*0x7dfc424*/ nint ConvertToNative(UnityEngine.AnimationCurve animationCurve);
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

        static /*0x7dfe610*/ Application();
        static /*0x7dfc43c*/ void Quit(int exitCode);
        static /*0x7dfc478*/ void Quit();
        static /*0x7dfc4e8*/ bool get_isPlaying();
        static /*0x7dfc510*/ bool IsPlaying(UnityEngine.Object obj);
        static /*0x7dfc618*/ bool get_isFocused();
        static /*0x7dfc640*/ bool get_runInBackground();
        static /*0x7dfc668*/ bool get_isBatchMode();
        static /*0x7dfc690*/ string get_dataPath();
        static /*0x7dfc7b8*/ string get_streamingAssetsPath();
        static /*0x7dfc8e0*/ string get_persistentDataPath();
        static /*0x7dfca08*/ string get_unityVersion();
        static /*0x7dfcb30*/ string get_version();
        static /*0x7dfcc58*/ string get_identifier();
        static /*0x7dfcd80*/ string get_productName();
        static /*0x7dfcea8*/ string get_cloudProjectId();
        static /*0x7dfcfd0*/ void OpenURL(string url);
        static /*0x7dfd198*/ int get_targetFrameRate();
        static /*0x7dfd1c0*/ void set_targetFrameRate(int value);
        static /*0x7dfd1fc*/ void SetLogCallbackDefined(bool defined);
        static /*0x7dfd238*/ UnityEngine.StackTraceLogType GetStackTraceLogType(UnityEngine.LogType logType);
        static /*0x7dfd274*/ UnityEngine.RuntimePlatform get_platform();
        static /*0x7dfd29c*/ bool get_isMobilePlatform();
        static /*0x7dfd360*/ UnityEngine.SystemLanguage get_systemLanguage();
        static /*0x7dfd388*/ void add_lowMemory(UnityEngine.Application.LowMemoryCallback value);
        static /*0x7dfd460*/ void remove_lowMemory(UnityEngine.Application.LowMemoryCallback value);
        static /*0x7dfd538*/ void CallLowMemory(UnityEngine.ApplicationMemoryUsage usage);
        static /*0x7dfd670*/ bool HasLogCallback();
        static /*0x7dfd6f4*/ void add_logMessageReceived(UnityEngine.Application.LogCallback value);
        static /*0x7dfd7e0*/ void remove_logMessageReceived(UnityEngine.Application.LogCallback value);
        static /*0x7dfd8a4*/ void CallLogCallback(string logString, string stackTrace, UnityEngine.LogType type, bool invokedOnMainThread);
        static /*0x7dfd980*/ void add_focusChanged(System.Action<bool> value);
        static /*0x7dfda74*/ void remove_focusChanged(System.Action<bool> value);
        static /*0x7dfdb68*/ void add_wantsToQuit(System.Func<bool> value);
        static /*0x7dfdc5c*/ void remove_wantsToQuit(System.Func<bool> value);
        static /*0x7dfdd50*/ void add_quitting(System.Action value);
        static /*0x7dfde2c*/ void remove_quitting(System.Action value);
        static /*0x7dfdf08*/ bool Internal_ApplicationWantsToQuit();
        static /*0x7dfe20c*/ void Internal_InitializeExitCancellationToken();
        static /*0x7dfe2ec*/ void Internal_RaiseExitCancellationToken();
        static /*0x7dfe358*/ void Internal_ApplicationQuit();
        static /*0x7dfe3ec*/ void Internal_ApplicationUnload();
        static /*0x7dfe480*/ void InvokeOnBeforeRender();
        static /*0x7dfe4d0*/ void InvokeFocusChanged(bool focus);
        static /*0x7dfe56c*/ void InvokeDeepLinkActivated(string url);
        static /*0x7dfe608*/ bool get_isEditor();
        static /*0x7dfc5dc*/ bool IsPlaying_Injected(nint obj);
        static /*0x7dfc77c*/ void get_dataPath_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7dfc8a4*/ void get_streamingAssetsPath_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7dfc9cc*/ void get_persistentDataPath_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7dfcaf4*/ void get_unityVersion_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7dfcc1c*/ void get_version_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7dfcd44*/ void get_identifier_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7dfce6c*/ void get_productName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7dfcf94*/ void get_cloudProjectId_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7dfd15c*/ void OpenURL_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper url);

        class LowMemoryCallback : System.MulticastDelegate
        {
            /*0x7dfe684*/ LowMemoryCallback(object object, nint method);
            /*0x7dfe720*/ void Invoke();
        }

        class MemoryUsageChangedCallback : System.MulticastDelegate
        {
            /*0x7dfe734*/ MemoryUsageChangedCallback(object object, nint method);
            /*0x7dfe7e4*/ void Invoke(ref UnityEngine.ApplicationMemoryUsageChange usage);
        }

        class LogCallback : System.MulticastDelegate
        {
            /*0x7dfe7f8*/ LogCallback(object object, nint method);
            /*0x7dfe8ac*/ void Invoke(string condition, string stackTrace, UnityEngine.LogType type);
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

        /*0x7dfd668*/ ApplicationMemoryUsageChange(UnityEngine.ApplicationMemoryUsage usage);
        /*0x7dfe8c0*/ void set_memoryUsage(UnityEngine.ApplicationMemoryUsage value);
    }

    enum StackTraceLogType
    {
        None = 0,
        ScriptOnly = 1,
        Full = 2,
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
        ReservedCFE = 51,
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

        static /*0x7dfe8c8*/ UnityEngine.BootConfigData WrapBootConfigData(nint nativeHandle);
        /*0x7dfe920*/ BootConfigData(nint nativeHandle);
    }

    struct CachedAssetBundle
    {
        /*0x10*/ string m_Name;
        /*0x18*/ UnityEngine.Hash128 m_Hash;

        /*0x7dfe994*/ CachedAssetBundle(string name, UnityEngine.Hash128 hash);
        /*0x7dfe9c0*/ string get_name();
        /*0x7dfe9c8*/ UnityEngine.Hash128 get_hash();
    }

    struct Cache : System.IEquatable<UnityEngine.Cache>
    {
        /*0x10*/ int m_Handle;

        static /*0x7dfeaa8*/ bool Cache_IsValid(int handle);
        static /*0x7dfeaec*/ string Cache_GetPath(int handle);
        static /*0x7dfec30*/ void Cache_SetMaximumDiskSpaceAvailable(int handle, long value);
        static /*0x7dfecb8*/ void Cache_SetExpirationDelay(int handle, int value);
        static /*0x7dfeba8*/ void Cache_GetPath_Injected(int handle, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        /*0x7dfe9d4*/ int get_handle();
        /*0x7dfe9dc*/ int GetHashCode();
        /*0x7dfe9e4*/ bool Equals(object other);
        /*0x7dfea5c*/ bool Equals(UnityEngine.Cache other);
        /*0x7dfea6c*/ bool get_valid();
        /*0x7dfeae4*/ string get_path();
        /*0x7dfebec*/ void set_maximumAvailableStorageSpace(long value);
        /*0x7dfec74*/ void set_expirationDelay(int value);
    }

    class Caching
    {
        static /*0x7dfecfc*/ void set_compressionEnabled(bool value);
        static /*0x7dfed38*/ bool get_ready();
        static /*0x7dfed60*/ bool ClearCache();
        static /*0x7dfed88*/ bool ClearCachedVersion(string assetBundleName, UnityEngine.Hash128 hash);
        static /*0x7dfee08*/ bool ClearCachedVersionInternal(string assetBundleName, UnityEngine.Hash128 hash);
        static /*0x7dfefc8*/ bool ClearOtherCachedVersions(string assetBundleName, UnityEngine.Hash128 hash);
        static /*0x7dff1d0*/ bool ClearAllCachedVersions(string assetBundleName);
        static /*0x7dff04c*/ bool ClearCachedVersions(string assetBundleName, UnityEngine.Hash128 hash, bool keepInputVersion);
        static /*0x7dff298*/ bool IsVersionCached(UnityEngine.CachedAssetBundle cachedBundle);
        static /*0x7dff33c*/ bool IsVersionCached(string url, string assetBundleName, UnityEngine.Hash128 hash);
        static /*0x7dff5d4*/ UnityEngine.Cache AddCache(string cachePath);
        static /*0x7dff970*/ UnityEngine.Cache AddCache(string cachePath, bool isReadonly);
        static /*0x7dff7f8*/ UnityEngine.Cache GetCacheByPath(string cachePath);
        static /*0x7dffb88*/ UnityEngine.Cache get_defaultCache();
        static /*0x7dffc08*/ UnityEngine.Cache get_currentCacheForWriting();
        static /*0x7dffc88*/ void set_currentCacheForWriting(UnityEngine.Cache value);
        static /*0x7dfef84*/ bool ClearCachedVersionInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper assetBundleName, ref UnityEngine.Hash128 hash);
        static /*0x7dff244*/ bool ClearCachedVersions_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper assetBundleName, ref UnityEngine.Hash128 hash, bool keepInputVersion);
        static /*0x7dff580*/ bool IsVersionCached_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper url, ref UnityEngine.Bindings.ManagedSpanWrapper assetBundleName, ref UnityEngine.Hash128 hash);
        static /*0x7dffaf0*/ void AddCache_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper cachePath, bool isReadonly, ref UnityEngine.Cache ret);
        static /*0x7dffb44*/ void GetCacheByPath_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper cachePath, ref UnityEngine.Cache ret);
        static /*0x7dffbcc*/ void get_defaultCache_Injected(ref UnityEngine.Cache ret);
        static /*0x7dffc4c*/ void get_currentCacheForWriting_Injected(ref UnityEngine.Cache ret);
        static /*0x7dffcc8*/ void set_currentCacheForWriting_Injected(ref UnityEngine.Cache value);
    }

    class BatchRendererGroupRuntimeAnalytic : UnityEngine.Analytics.AnalyticsEventBase
    {
        /*0x2c*/ int brgRuntimeStatus;

        static /*0x7dffd78*/ UnityEngine.BatchRendererGroupRuntimeAnalytic CreateBatchRendererGroupRuntimeAnalytic();
        /*0x7dffd04*/ BatchRendererGroupRuntimeAnalytic();
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

        static /*0x7e027a8*/ int get_PreviewCullingLayer();
        static /*0x7e0704c*/ void CalculateProjectionMatrixFromPhysicalPropertiesInternal(ref UnityEngine.Matrix4x4 output, float focalLength, UnityEngine.Vector2 sensorSize, UnityEngine.Vector2 lensShift, float nearClip, float farClip, float gateAspect, UnityEngine.Camera.GateFitMode gateFitMode);
        static /*0x7e07168*/ void CalculateProjectionMatrixFromPhysicalProperties(ref UnityEngine.Matrix4x4 output, float focalLength, UnityEngine.Vector2 sensorSize, UnityEngine.Vector2 lensShift, float nearClip, float farClip, UnityEngine.Camera.GateFitParameters gateFitParameters);
        static /*0x7e07174*/ float FocalLengthToFieldOfView(float focalLength, float sensorSize);
        static /*0x7e071b4*/ float FieldOfViewToFocalLength(float fieldOfView, float sensorSize);
        static /*0x7e071f4*/ float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio);
        static /*0x7e07234*/ float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio);
        static /*0x7e07274*/ UnityEngine.Camera get_main();
        static /*0x7e07300*/ UnityEngine.Camera get_current();
        static /*0x7e07304*/ UnityEngine.Camera get_currentInternal();
        static /*0x7e083d0*/ int GetAllCamerasCount();
        static /*0x7e083f8*/ int GetAllCamerasImpl(UnityEngine.Camera[] cam);
        static /*0x7e084ac*/ int get_allCamerasCount();
        static /*0x7e084d4*/ UnityEngine.Camera[] get_allCameras();
        static /*0x7e08550*/ int GetAllCameras(UnityEngine.Camera[] cameras);
        static /*0x7e09174*/ void SetupCurrent(UnityEngine.Camera cur);
        static /*0x7e0a28c*/ void FireOnPreCull(UnityEngine.Camera cam);
        static /*0x7e0a2f8*/ void FireOnPreRender(UnityEngine.Camera cam);
        static /*0x7e0a364*/ void FireOnPostRender(UnityEngine.Camera cam);
        static /*0x7e0a3d0*/ void BumpNonSerializedVersion(UnityEngine.Camera cam);
        static /*0x7e0a408*/ bool GetCullingParameters_Internal(UnityEngine.Camera camera, bool stereoAware, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, int managedCullingParametersSize);
        static /*0x7dffe48*/ float get_nearClipPlane_Injected(nint _unity_self);
        static /*0x7dfff0c*/ void set_nearClipPlane_Injected(nint _unity_self, float value);
        static /*0x7dfffd0*/ float get_farClipPlane_Injected(nint _unity_self);
        static /*0x7e00094*/ void set_farClipPlane_Injected(nint _unity_self, float value);
        static /*0x7e00158*/ float get_fieldOfView_Injected(nint _unity_self);
        static /*0x7e0021c*/ void set_fieldOfView_Injected(nint _unity_self, float value);
        static /*0x7e002e0*/ UnityEngine.RenderingPath get_renderingPath_Injected(nint _unity_self);
        static /*0x7e0039c*/ void set_renderingPath_Injected(nint _unity_self, UnityEngine.RenderingPath value);
        static /*0x7e00458*/ UnityEngine.RenderingPath get_actualRenderingPath_Injected(nint _unity_self);
        static /*0x7e0050c*/ void Reset_Injected(nint _unity_self);
        static /*0x7e005c0*/ bool get_allowHDR_Injected(nint _unity_self);
        static /*0x7e0067c*/ void set_allowHDR_Injected(nint _unity_self, bool value);
        static /*0x7e00738*/ bool get_allowMSAA_Injected(nint _unity_self);
        static /*0x7e007f4*/ void set_allowMSAA_Injected(nint _unity_self, bool value);
        static /*0x7e008b0*/ bool get_allowDynamicResolution_Injected(nint _unity_self);
        static /*0x7e0096c*/ void set_allowDynamicResolution_Injected(nint _unity_self, bool value);
        static /*0x7e00a28*/ bool get_forceIntoRenderTexture_Injected(nint _unity_self);
        static /*0x7e00ae4*/ void set_forceIntoRenderTexture_Injected(nint _unity_self, bool value);
        static /*0x7e00ba0*/ float get_orthographicSize_Injected(nint _unity_self);
        static /*0x7e00c64*/ void set_orthographicSize_Injected(nint _unity_self, float value);
        static /*0x7e00d28*/ bool get_orthographic_Injected(nint _unity_self);
        static /*0x7e00de4*/ void set_orthographic_Injected(nint _unity_self, bool value);
        static /*0x7e00ea0*/ UnityEngine.Rendering.OpaqueSortMode get_opaqueSortMode_Injected(nint _unity_self);
        static /*0x7e00f5c*/ void set_opaqueSortMode_Injected(nint _unity_self, UnityEngine.Rendering.OpaqueSortMode value);
        static /*0x7e01018*/ UnityEngine.TransparencySortMode get_transparencySortMode_Injected(nint _unity_self);
        static /*0x7e010d4*/ void set_transparencySortMode_Injected(nint _unity_self, UnityEngine.TransparencySortMode value);
        static /*0x7e011b0*/ void get_transparencySortAxis_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e01284*/ void set_transparencySortAxis_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7e01340*/ void ResetTransparencySortSettings_Injected(nint _unity_self);
        static /*0x7e013f4*/ float get_depth_Injected(nint _unity_self);
        static /*0x7e014b8*/ void set_depth_Injected(nint _unity_self, float value);
        static /*0x7e0157c*/ float get_aspect_Injected(nint _unity_self);
        static /*0x7e01640*/ void set_aspect_Injected(nint _unity_self, float value);
        static /*0x7e01704*/ void ResetAspect_Injected(nint _unity_self);
        static /*0x7e017d8*/ void get_velocity_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e01894*/ int get_cullingMask_Injected(nint _unity_self);
        static /*0x7e01950*/ void set_cullingMask_Injected(nint _unity_self, int value);
        static /*0x7e01a0c*/ int get_eventMask_Injected(nint _unity_self);
        static /*0x7e01ac8*/ void set_eventMask_Injected(nint _unity_self, int value);
        static /*0x7e01dfc*/ bool get_layerCullSphericalInternal_Injected(nint _unity_self);
        static /*0x7e01e38*/ void set_layerCullSphericalInternal_Injected(nint _unity_self, bool value);
        static /*0x7e01ef4*/ UnityEngine.CameraType get_cameraType_Injected(nint _unity_self);
        static /*0x7e01fb0*/ void set_cameraType_Injected(nint _unity_self, UnityEngine.CameraType value);
        static /*0x7e02088*/ nint get_skyboxMaterial_Injected(nint _unity_self);
        static /*0x7e0213c*/ ulong get_overrideSceneCullingMask_Injected(nint _unity_self);
        static /*0x7e021f8*/ void set_overrideSceneCullingMask_Injected(nint _unity_self, ulong value);
        static /*0x7e022b4*/ ulong get_sceneCullingMask_Injected(nint _unity_self);
        static /*0x7e02368*/ bool get_useInteractiveLightBakingData_Injected(nint _unity_self);
        static /*0x7e02424*/ void set_useInteractiveLightBakingData_Injected(nint _unity_self, bool value);
        static /*0x7e02590*/ void GetLayerCullDistances_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e026f8*/ void SetLayerCullDistances_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper d);
        static /*0x7e02828*/ bool get_useOcclusionCulling_Injected(nint _unity_self);
        static /*0x7e028e4*/ void set_useOcclusionCulling_Injected(nint _unity_self, bool value);
        static /*0x7e029d0*/ void get_cullingMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e02a94*/ void set_cullingMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
        static /*0x7e02b50*/ void ResetCullingMatrix_Injected(nint _unity_self);
        static /*0x7e02c20*/ void get_backgroundColor_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x7e02cf4*/ void set_backgroundColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x7e02db0*/ UnityEngine.CameraClearFlags get_clearFlags_Injected(nint _unity_self);
        static /*0x7e02e6c*/ void set_clearFlags_Injected(nint _unity_self, UnityEngine.CameraClearFlags value);
        static /*0x7e02f28*/ UnityEngine.DepthTextureMode get_depthTextureMode_Injected(nint _unity_self);
        static /*0x7e02fe4*/ void set_depthTextureMode_Injected(nint _unity_self, UnityEngine.DepthTextureMode value);
        static /*0x7e030a0*/ bool get_clearStencilAfterLightingPass_Injected(nint _unity_self);
        static /*0x7e0315c*/ void set_clearStencilAfterLightingPass_Injected(nint _unity_self, bool value);
        static /*0x7e0337c*/ void SetReplacementShader_Injected(nint _unity_self, nint shader, ref UnityEngine.Bindings.ManagedSpanWrapper replacementTag);
        static /*0x7e03448*/ void ResetReplacementShader_Injected(nint _unity_self);
        static /*0x7e034fc*/ UnityEngine.Camera.ProjectionMatrixMode get_projectionMatrixMode_Injected(nint _unity_self);
        static /*0x7e035b0*/ bool get_usePhysicalProperties_Injected(nint _unity_self);
        static /*0x7e0366c*/ void set_usePhysicalProperties_Injected(nint _unity_self, bool value);
        static /*0x7e03728*/ int get_iso_Injected(nint _unity_self);
        static /*0x7e037e4*/ void set_iso_Injected(nint _unity_self, int value);
        static /*0x7e038a0*/ float get_shutterSpeed_Injected(nint _unity_self);
        static /*0x7e03964*/ void set_shutterSpeed_Injected(nint _unity_self, float value);
        static /*0x7e03a28*/ float get_aperture_Injected(nint _unity_self);
        static /*0x7e03aec*/ void set_aperture_Injected(nint _unity_self, float value);
        static /*0x7e03bb0*/ float get_focusDistance_Injected(nint _unity_self);
        static /*0x7e03c74*/ void set_focusDistance_Injected(nint _unity_self, float value);
        static /*0x7e03d38*/ float get_focalLength_Injected(nint _unity_self);
        static /*0x7e03dfc*/ void set_focalLength_Injected(nint _unity_self, float value);
        static /*0x7e03ec0*/ int get_bladeCount_Injected(nint _unity_self);
        static /*0x7e03f7c*/ void set_bladeCount_Injected(nint _unity_self, int value);
        static /*0x7e04048*/ void get_curvature_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e04110*/ void set_curvature_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e041cc*/ float get_barrelClipping_Injected(nint _unity_self);
        static /*0x7e04290*/ void set_barrelClipping_Injected(nint _unity_self, float value);
        static /*0x7e04354*/ float get_anamorphism_Injected(nint _unity_self);
        static /*0x7e04418*/ void set_anamorphism_Injected(nint _unity_self, float value);
        static /*0x7e044ec*/ void get_sensorSize_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e045b4*/ void set_sensorSize_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e04680*/ void get_lensShift_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e04748*/ void set_lensShift_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e04804*/ UnityEngine.Camera.GateFitMode get_gateFit_Injected(nint _unity_self);
        static /*0x7e048c0*/ void set_gateFit_Injected(nint _unity_self, UnityEngine.Camera.GateFitMode value);
        static /*0x7e0497c*/ float GetGateFittedFieldOfView_Injected(nint _unity_self);
        static /*0x7e04a40*/ void GetGateFittedLensShift_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e04b1c*/ void GetLocalSpaceAim_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e04bf4*/ void get_rect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x7e04cc8*/ void set_rect_Injected(nint _unity_self, ref UnityEngine.Rect value);
        static /*0x7e04da0*/ void get_pixelRect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x7e04e74*/ void set_pixelRect_Injected(nint _unity_self, ref UnityEngine.Rect value);
        static /*0x7e04f30*/ int get_pixelWidth_Injected(nint _unity_self);
        static /*0x7e04fe4*/ int get_pixelHeight_Injected(nint _unity_self);
        static /*0x7e05098*/ int get_scaledPixelWidth_Injected(nint _unity_self);
        static /*0x7e0514c*/ int get_scaledPixelHeight_Injected(nint _unity_self);
        static /*0x7e0521c*/ nint get_targetTexture_Injected(nint _unity_self);
        static /*0x7e0530c*/ void set_targetTexture_Injected(nint _unity_self, nint value);
        static /*0x7e053e4*/ nint get_activeTexture_Injected(nint _unity_self);
        static /*0x7e05498*/ int get_targetDisplay_Injected(nint _unity_self);
        static /*0x7e05554*/ void set_targetDisplay_Injected(nint _unity_self, int value);
        static /*0x7e0562c*/ void SetTargetBuffersImpl_Injected(nint _unity_self, ref UnityEngine.RenderBuffer color, ref UnityEngine.RenderBuffer depth);
        static /*0x7e05788*/ void SetTargetBuffersMRTImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper color, ref UnityEngine.RenderBuffer depth);
        static /*0x7e05858*/ string[] GetCameraBufferWarnings_Injected(nint _unity_self);
        static /*0x7e0593c*/ void get_cameraToWorldMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e05a28*/ void get_worldToCameraMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e05aec*/ void set_worldToCameraMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
        static /*0x7e05bd8*/ void get_projectionMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e05c9c*/ void set_projectionMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
        static /*0x7e05d88*/ void get_nonJitteredProjectionMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e05e4c*/ void set_nonJitteredProjectionMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
        static /*0x7e05f08*/ bool get_useJitteredProjectionMatrixForTransparentRendering_Injected(nint _unity_self);
        static /*0x7e05fc4*/ void set_useJitteredProjectionMatrixForTransparentRendering_Injected(nint _unity_self, bool value);
        static /*0x7e060b0*/ void get_previousViewProjectionMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e0616c*/ void ResetWorldToCameraMatrix_Injected(nint _unity_self);
        static /*0x7e06220*/ void ResetProjectionMatrix_Injected(nint _unity_self);
        static /*0x7e06310*/ void CalculateObliqueMatrix_Injected(nint _unity_self, ref UnityEngine.Vector4 clipPlane, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e06410*/ void WorldToScreenPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        static /*0x7e06518*/ void WorldToViewportPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        static /*0x7e06620*/ void ViewportToWorldPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        static /*0x7e06728*/ void ScreenToWorldPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        static /*0x7e06848*/ void ScreenToViewportPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x7e06940*/ void ViewportToScreenPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x7e06a34*/ void GetFrustumPlaneSizeAt_Injected(nint _unity_self, float distance, ref UnityEngine.Vector2 ret);
        static /*0x7e06b40*/ void ViewportPointToRay_Injected(nint _unity_self, ref UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Ray ret);
        static /*0x7e06cd4*/ void ScreenPointToRay_Injected(nint _unity_self, ref UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Ray ret);
        static /*0x7e06f2c*/ void CalculateFrustumCornersInternal_Injected(nint _unity_self, ref UnityEngine.Rect viewport, float z, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Bindings.BlittableArrayWrapper outCorners);
        static /*0x7e070dc*/ void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(ref UnityEngine.Matrix4x4 output, float focalLength, ref UnityEngine.Vector2 sensorSize, ref UnityEngine.Vector2 lensShift, float nearClip, float farClip, float gateAspect, UnityEngine.Camera.GateFitMode gateFitMode);
        static /*0x7e072d8*/ nint get_main_Injected();
        static /*0x7e07368*/ nint get_currentInternal_Injected();
        static /*0x7e07418*/ void get_scene_Injected(nint _unity_self, ref UnityEngine.SceneManagement.Scene ret);
        static /*0x7e074e0*/ void set_scene_Injected(nint _unity_self, ref UnityEngine.SceneManagement.Scene value);
        static /*0x7e0759c*/ bool get_stereoEnabled_Injected(nint _unity_self);
        static /*0x7e07650*/ float get_stereoSeparation_Injected(nint _unity_self);
        static /*0x7e07714*/ void set_stereoSeparation_Injected(nint _unity_self, float value);
        static /*0x7e077d8*/ float get_stereoConvergence_Injected(nint _unity_self);
        static /*0x7e0789c*/ void set_stereoConvergence_Injected(nint _unity_self, float value);
        static /*0x7e07960*/ bool get_areVRStereoViewMatricesWithinSingleCullTolerance_Injected(nint _unity_self);
        static /*0x7e07b84*/ UnityEngine.StereoTargetEyeMask get_stereoTargetEyeInternal_Injected(nint _unity_self);
        static /*0x7e07bc0*/ void set_stereoTargetEyeInternal_Injected(nint _unity_self, UnityEngine.StereoTargetEyeMask value);
        static /*0x7e07c7c*/ UnityEngine.Camera.MonoOrStereoscopicEye get_stereoActiveEye_Injected(nint _unity_self);
        static /*0x7e07d70*/ void GetStereoNonJitteredProjectionMatrix_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e07e7c*/ void GetStereoViewMatrix_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e07f50*/ void CopyStereoDeviceProjectionMatrixToNonJittered_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye);
        static /*0x7e0804c*/ void GetStereoProjectionMatrix_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e08130*/ void SetStereoProjectionMatrix_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 matrix);
        static /*0x7e081fc*/ void ResetStereoProjectionMatrices_Injected(nint _unity_self);
        static /*0x7e082c8*/ void SetStereoViewMatrix_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 matrix);
        static /*0x7e08394*/ void ResetStereoViewMatrices_Injected(nint _unity_self);
        static /*0x7e08470*/ int GetAllCamerasImpl_Injected(UnityEngine.Camera[] cam);
        static /*0x7e086c4*/ bool RenderToCubemapImpl_Injected(nint _unity_self, nint tex, int faceMask);
        static /*0x7e087a8*/ int GetFilterMode_Injected(nint _unity_self);
        static /*0x7e08860*/ bool get_renderCloudsInSceneView_Injected(nint _unity_self);
        static /*0x7e0891c*/ void set_renderCloudsInSceneView_Injected(nint _unity_self, bool value);
        static /*0x7e08a2c*/ bool RenderToCubemapEyeImpl_Injected(nint _unity_self, nint cubemap, int faceMask, UnityEngine.Camera.MonoOrStereoscopicEye stereoEye);
        static /*0x7e08b04*/ void Render_Injected(nint _unity_self);
        static /*0x7e08d1c*/ void RenderWithShader_Injected(nint _unity_self, nint shader, ref UnityEngine.Bindings.ManagedSpanWrapper replacementTag);
        static /*0x7e08de8*/ void RenderDontRestore_Injected(nint _unity_self);
        static /*0x7e08ff0*/ void SubmitRenderRequestsInternal_Injected(nint _unity_self, object requests);
        static /*0x7e09108*/ UnityEngine.Object[] SubmitBuiltInObjectIDRenderRequest_Injected(nint _unity_self, nint target, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
        static /*0x7e091f8*/ void SetupCurrent_Injected(nint cur);
        static /*0x7e092e8*/ void CopyFrom_Injected(nint _unity_self, nint other);
        static /*0x7e093a4*/ int get_commandBufferCount_Injected(nint _unity_self);
        static /*0x7e09460*/ void RemoveCommandBuffersImpl_Injected(nint _unity_self, UnityEngine.Rendering.CameraEvent evt);
        static /*0x7e0951c*/ void RemoveAllCommandBuffersImpl_Injected(nint _unity_self);
        static /*0x7e09824*/ void AddCommandBufferImpl_Injected(nint _unity_self, UnityEngine.Rendering.CameraEvent evt, nint buffer);
        static /*0x7e09968*/ void AddCommandBufferAsyncImpl_Injected(nint _unity_self, UnityEngine.Rendering.CameraEvent evt, nint buffer, UnityEngine.Rendering.ComputeQueueType queueType);
        static /*0x7e09aac*/ void RemoveCommandBufferImpl_Injected(nint _unity_self, UnityEngine.Rendering.CameraEvent evt, nint buffer);
        static /*0x7e0a248*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffersImpl_Injected(nint _unity_self, UnityEngine.Rendering.CameraEvent evt);
        static /*0x7e0a4c0*/ bool GetCullingParameters_Internal_Injected(nint camera, bool stereoAware, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, int managedCullingParametersSize);
        /*0x7dffdc8*/ Camera();
        /*0x7dffdd0*/ float get_nearClipPlane();
        /*0x7dffe84*/ void set_nearClipPlane(float value);
        /*0x7dfff58*/ float get_farClipPlane();
        /*0x7e0000c*/ void set_farClipPlane(float value);
        /*0x7e000e0*/ float get_fieldOfView();
        /*0x7e00194*/ void set_fieldOfView(float value);
        /*0x7e00268*/ UnityEngine.RenderingPath get_renderingPath();
        /*0x7e0031c*/ void set_renderingPath(UnityEngine.RenderingPath value);
        /*0x7e003e0*/ UnityEngine.RenderingPath get_actualRenderingPath();
        /*0x7e00494*/ void Reset();
        /*0x7e00548*/ bool get_allowHDR();
        /*0x7e005fc*/ void set_allowHDR(bool value);
        /*0x7e006c0*/ bool get_allowMSAA();
        /*0x7e00774*/ void set_allowMSAA(bool value);
        /*0x7e00838*/ bool get_allowDynamicResolution();
        /*0x7e008ec*/ void set_allowDynamicResolution(bool value);
        /*0x7e009b0*/ bool get_forceIntoRenderTexture();
        /*0x7e00a64*/ void set_forceIntoRenderTexture(bool value);
        /*0x7e00b28*/ float get_orthographicSize();
        /*0x7e00bdc*/ void set_orthographicSize(float value);
        /*0x7e00cb0*/ bool get_orthographic();
        /*0x7e00d64*/ void set_orthographic(bool value);
        /*0x7e00e28*/ UnityEngine.Rendering.OpaqueSortMode get_opaqueSortMode();
        /*0x7e00edc*/ void set_opaqueSortMode(UnityEngine.Rendering.OpaqueSortMode value);
        /*0x7e00fa0*/ UnityEngine.TransparencySortMode get_transparencySortMode();
        /*0x7e01054*/ void set_transparencySortMode(UnityEngine.TransparencySortMode value);
        /*0x7e01118*/ UnityEngine.Vector3 get_transparencySortAxis();
        /*0x7e011f4*/ void set_transparencySortAxis(UnityEngine.Vector3 value);
        /*0x7e012c8*/ void ResetTransparencySortSettings();
        /*0x7e0137c*/ float get_depth();
        /*0x7e01430*/ void set_depth(float value);
        /*0x7e01504*/ float get_aspect();
        /*0x7e015b8*/ void set_aspect(float value);
        /*0x7e0168c*/ void ResetAspect();
        /*0x7e01740*/ UnityEngine.Vector3 get_velocity();
        /*0x7e0181c*/ int get_cullingMask();
        /*0x7e018d0*/ void set_cullingMask(int value);
        /*0x7e01994*/ int get_eventMask();
        /*0x7e01a48*/ void set_eventMask(int value);
        /*0x7e01b0c*/ bool get_layerCullSpherical();
        /*0x7e01b88*/ void set_layerCullSpherical(bool value);
        /*0x7e01b10*/ bool get_layerCullSphericalInternal();
        /*0x7e01d7c*/ void set_layerCullSphericalInternal(bool value);
        /*0x7e01e7c*/ UnityEngine.CameraType get_cameraType();
        /*0x7e01f30*/ void set_cameraType(UnityEngine.CameraType value);
        /*0x7e01ff4*/ UnityEngine.Material get_skyboxMaterial();
        /*0x7e020c4*/ ulong get_overrideSceneCullingMask();
        /*0x7e02178*/ void set_overrideSceneCullingMask(ulong value);
        /*0x7e0223c*/ ulong get_sceneCullingMask();
        /*0x7e022f0*/ bool get_useInteractiveLightBakingData();
        /*0x7e023a4*/ void set_useInteractiveLightBakingData(bool value);
        /*0x7e02468*/ float[] GetLayerCullDistances();
        /*0x7e025d4*/ void SetLayerCullDistances(float[] d);
        /*0x7e0273c*/ float[] get_layerCullDistances();
        /*0x7e02740*/ void set_layerCullDistances(float[] value);
        /*0x7e027b0*/ bool get_useOcclusionCulling();
        /*0x7e02864*/ void set_useOcclusionCulling(bool value);
        /*0x7e02928*/ UnityEngine.Matrix4x4 get_cullingMatrix();
        /*0x7e02a14*/ void set_cullingMatrix(UnityEngine.Matrix4x4 value);
        /*0x7e02ad8*/ void ResetCullingMatrix();
        /*0x7e02b8c*/ UnityEngine.Color get_backgroundColor();
        /*0x7e02c64*/ void set_backgroundColor(UnityEngine.Color value);
        /*0x7e02d38*/ UnityEngine.CameraClearFlags get_clearFlags();
        /*0x7e02dec*/ void set_clearFlags(UnityEngine.CameraClearFlags value);
        /*0x7e02eb0*/ UnityEngine.DepthTextureMode get_depthTextureMode();
        /*0x7e02f64*/ void set_depthTextureMode(UnityEngine.DepthTextureMode value);
        /*0x7e03028*/ bool get_clearStencilAfterLightingPass();
        /*0x7e030dc*/ void set_clearStencilAfterLightingPass(bool value);
        /*0x7e031a0*/ void SetReplacementShader(UnityEngine.Shader shader, string replacementTag);
        /*0x7e033d0*/ void ResetReplacementShader();
        /*0x7e03484*/ UnityEngine.Camera.ProjectionMatrixMode get_projectionMatrixMode();
        /*0x7e03538*/ bool get_usePhysicalProperties();
        /*0x7e035ec*/ void set_usePhysicalProperties(bool value);
        /*0x7e036b0*/ int get_iso();
        /*0x7e03764*/ void set_iso(int value);
        /*0x7e03828*/ float get_shutterSpeed();
        /*0x7e038dc*/ void set_shutterSpeed(float value);
        /*0x7e039b0*/ float get_aperture();
        /*0x7e03a64*/ void set_aperture(float value);
        /*0x7e03b38*/ float get_focusDistance();
        /*0x7e03bec*/ void set_focusDistance(float value);
        /*0x7e03cc0*/ float get_focalLength();
        /*0x7e03d74*/ void set_focalLength(float value);
        /*0x7e03e48*/ int get_bladeCount();
        /*0x7e03efc*/ void set_bladeCount(int value);
        /*0x7e03fc0*/ UnityEngine.Vector2 get_curvature();
        /*0x7e0408c*/ void set_curvature(UnityEngine.Vector2 value);
        /*0x7e04154*/ float get_barrelClipping();
        /*0x7e04208*/ void set_barrelClipping(float value);
        /*0x7e042dc*/ float get_anamorphism();
        /*0x7e04390*/ void set_anamorphism(float value);
        /*0x7e04464*/ UnityEngine.Vector2 get_sensorSize();
        /*0x7e04530*/ void set_sensorSize(UnityEngine.Vector2 value);
        /*0x7e045f8*/ UnityEngine.Vector2 get_lensShift();
        /*0x7e046c4*/ void set_lensShift(UnityEngine.Vector2 value);
        /*0x7e0478c*/ UnityEngine.Camera.GateFitMode get_gateFit();
        /*0x7e04840*/ void set_gateFit(UnityEngine.Camera.GateFitMode value);
        /*0x7e04904*/ float GetGateFittedFieldOfView();
        /*0x7e049b8*/ UnityEngine.Vector2 GetGateFittedLensShift();
        /*0x7e04a84*/ UnityEngine.Vector3 GetLocalSpaceAim();
        /*0x7e04b60*/ UnityEngine.Rect get_rect();
        /*0x7e04c38*/ void set_rect(UnityEngine.Rect value);
        /*0x7e04d0c*/ UnityEngine.Rect get_pixelRect();
        /*0x7e04de4*/ void set_pixelRect(UnityEngine.Rect value);
        /*0x7e04eb8*/ int get_pixelWidth();
        /*0x7e04f6c*/ int get_pixelHeight();
        /*0x7e05020*/ int get_scaledPixelWidth();
        /*0x7e050d4*/ int get_scaledPixelHeight();
        /*0x7e05188*/ UnityEngine.RenderTexture get_targetTexture();
        /*0x7e05258*/ void set_targetTexture(UnityEngine.RenderTexture value);
        /*0x7e05350*/ UnityEngine.RenderTexture get_activeTexture();
        /*0x7e05420*/ int get_targetDisplay();
        /*0x7e054d4*/ void set_targetDisplay(int value);
        /*0x7e05598*/ void SetTargetBuffersImpl(UnityEngine.RenderBuffer color, UnityEngine.RenderBuffer depth);
        /*0x7e05680*/ void SetTargetBuffers(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer);
        /*0x7e05684*/ void SetTargetBuffersMRTImpl(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer depth);
        /*0x7e057dc*/ void SetTargetBuffers(UnityEngine.RenderBuffer[] colorBuffer, UnityEngine.RenderBuffer depthBuffer);
        /*0x7e057e0*/ string[] GetCameraBufferWarnings();
        /*0x7e05894*/ UnityEngine.Matrix4x4 get_cameraToWorldMatrix();
        /*0x7e05980*/ UnityEngine.Matrix4x4 get_worldToCameraMatrix();
        /*0x7e05a6c*/ void set_worldToCameraMatrix(UnityEngine.Matrix4x4 value);
        /*0x7e05b30*/ UnityEngine.Matrix4x4 get_projectionMatrix();
        /*0x7e05c1c*/ void set_projectionMatrix(UnityEngine.Matrix4x4 value);
        /*0x7e05ce0*/ UnityEngine.Matrix4x4 get_nonJitteredProjectionMatrix();
        /*0x7e05dcc*/ void set_nonJitteredProjectionMatrix(UnityEngine.Matrix4x4 value);
        /*0x7e05e90*/ bool get_useJitteredProjectionMatrixForTransparentRendering();
        /*0x7e05f44*/ void set_useJitteredProjectionMatrixForTransparentRendering(bool value);
        /*0x7e06008*/ UnityEngine.Matrix4x4 get_previousViewProjectionMatrix();
        /*0x7e060f4*/ void ResetWorldToCameraMatrix();
        /*0x7e061a8*/ void ResetProjectionMatrix();
        /*0x7e0625c*/ UnityEngine.Matrix4x4 CalculateObliqueMatrix(UnityEngine.Vector4 clipPlane);
        /*0x7e06364*/ UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e0646c*/ UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e06574*/ UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e0667c*/ UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e06784*/ UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position);
        /*0x7e0678c*/ UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position);
        /*0x7e06794*/ UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position);
        /*0x7e0679c*/ UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position);
        /*0x7e067a4*/ UnityEngine.Vector3 ScreenToViewportPoint(UnityEngine.Vector3 position);
        /*0x7e0689c*/ UnityEngine.Vector3 ViewportToScreenPoint(UnityEngine.Vector3 position);
        /*0x7e06994*/ UnityEngine.Vector2 GetFrustumPlaneSizeAt(float distance);
        /*0x7e06a88*/ UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e06b9c*/ UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e06bd4*/ UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3 pos);
        /*0x7e06c1c*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e06d30*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e06d68*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos);
        /*0x7e06db0*/ void CalculateFrustumCornersInternal(UnityEngine.Rect viewport, float z, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3[] outCorners);
        /*0x7e06f98*/ void CalculateFrustumCorners(UnityEngine.Rect viewport, float z, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3[] outCorners);
        /*0x7e07390*/ UnityEngine.SceneManagement.Scene get_scene();
        /*0x7e0745c*/ void set_scene(UnityEngine.SceneManagement.Scene value);
        /*0x7e07524*/ bool get_stereoEnabled();
        /*0x7e075d8*/ float get_stereoSeparation();
        /*0x7e0768c*/ void set_stereoSeparation(float value);
        /*0x7e07760*/ float get_stereoConvergence();
        /*0x7e07814*/ void set_stereoConvergence(float value);
        /*0x7e078e8*/ bool get_areVRStereoViewMatricesWithinSingleCullTolerance();
        /*0x7e0799c*/ UnityEngine.StereoTargetEyeMask get_stereoTargetEye();
        /*0x7e07a18*/ void set_stereoTargetEye(UnityEngine.StereoTargetEyeMask value);
        /*0x7e079a0*/ UnityEngine.StereoTargetEyeMask get_stereoTargetEyeInternal();
        /*0x7e07b04*/ void set_stereoTargetEyeInternal(UnityEngine.StereoTargetEyeMask value);
        /*0x7e07c04*/ UnityEngine.Camera.MonoOrStereoscopicEye get_stereoActiveEye();
        /*0x7e07cb8*/ UnityEngine.Matrix4x4 GetStereoNonJitteredProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye);
        /*0x7e07dc4*/ UnityEngine.Matrix4x4 GetStereoViewMatrix(UnityEngine.Camera.StereoscopicEye eye);
        /*0x7e07ed0*/ void CopyStereoDeviceProjectionMatrixToNonJittered(UnityEngine.Camera.StereoscopicEye eye);
        /*0x7e07f94*/ UnityEngine.Matrix4x4 GetStereoProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye);
        /*0x7e080a0*/ void SetStereoProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4 matrix);
        /*0x7e08184*/ void ResetStereoProjectionMatrices();
        /*0x7e08238*/ void SetStereoViewMatrix(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4 matrix);
        /*0x7e0831c*/ void ResetStereoViewMatrices();
        /*0x7e08608*/ bool RenderToCubemapImpl(UnityEngine.Texture tex, int faceMask);
        /*0x7e08718*/ bool RenderToCubemap(UnityEngine.Cubemap cubemap, int faceMask);
        /*0x7e0871c*/ bool RenderToCubemap(UnityEngine.Cubemap cubemap);
        /*0x7e08724*/ bool RenderToCubemap(UnityEngine.RenderTexture cubemap, int faceMask);
        /*0x7e08728*/ bool RenderToCubemap(UnityEngine.RenderTexture cubemap);
        /*0x7e08730*/ int GetFilterMode();
        /*0x7e087e4*/ UnityEngine.Camera.SceneViewFilterMode get_sceneViewFilterMode();
        /*0x7e087e8*/ bool get_renderCloudsInSceneView();
        /*0x7e0889c*/ void set_renderCloudsInSceneView(bool value);
        /*0x7e08960*/ bool RenderToCubemapEyeImpl(UnityEngine.RenderTexture cubemap, int faceMask, UnityEngine.Camera.MonoOrStereoscopicEye stereoEye);
        /*0x7e08a88*/ bool RenderToCubemap(UnityEngine.RenderTexture cubemap, int faceMask, UnityEngine.Camera.MonoOrStereoscopicEye stereoEye);
        /*0x7e08a8c*/ void Render();
        /*0x7e08b40*/ void RenderWithShader(UnityEngine.Shader shader, string replacementTag);
        /*0x7e08d70*/ void RenderDontRestore();
        /*0x7e08e24*/ void SubmitRenderRequests(System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests);
        /*0x3907c14*/ void SubmitRenderRequest<RequestData>(RequestData renderRequest);
        /*0x7e08f70*/ void SubmitRenderRequestsInternal(object requests);
        /*0x7e09034*/ UnityEngine.Object[] SubmitBuiltInObjectIDRenderRequest(UnityEngine.RenderTexture target, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
        /*0x7e09234*/ void CopyFrom(UnityEngine.Camera other);
        /*0x7e0932c*/ int get_commandBufferCount();
        /*0x7e093e0*/ void RemoveCommandBuffersImpl(UnityEngine.Rendering.CameraEvent evt);
        /*0x7e094a4*/ void RemoveAllCommandBuffersImpl();
        /*0x7e09558*/ void RemoveCommandBuffers(UnityEngine.Rendering.CameraEvent evt);
        /*0x7e09654*/ void RemoveAllCommandBuffers();
        /*0x7e0973c*/ void AddCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x7e09878*/ void AddCommandBufferAsyncImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType);
        /*0x7e099c4*/ void RemoveCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x7e09b00*/ void AddCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x7e09cf4*/ void AddCommandBufferAsync(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType);
        /*0x7e09ef0*/ void RemoveCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x7e0a0e4*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.CameraEvent evt);
        /*0x7e0a1c8*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffersImpl(UnityEngine.Rendering.CameraEvent evt);
        /*0x7e0a3f0*/ void OnlyUsedForTesting1();
        /*0x7e0a3f4*/ void OnlyUsedForTesting2();
        /*0x7e0a3f8*/ bool TryGetCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters);
        /*0x7e0a4b4*/ bool TryGetCullingParameters(bool stereoAware, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters);

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

            /*0x7e0a51c*/ UnityEngine.Camera.GateFitMode get_mode();
            /*0x7e0a524*/ float get_aspect();
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
            /*0x7e0a52c*/ CameraCallback(object object, nint method);
            /*0x7e0a5dc*/ void Invoke(UnityEngine.Camera cam);
        }
    }

    struct BoundingSphere
    {
        /*0x10*/ UnityEngine.Vector3 position;
        /*0x1c*/ float radius;

        /*0x7e0a5f0*/ BoundingSphere(UnityEngine.Vector3 pos, float rad);
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

        static /*0x7e0addc*/ void SendEvents(UnityEngine.CullingGroup cullingGroup, nint eventsPtr, int count);
        static /*0x7e0a658*/ nint Init(object scripting);
        static /*0x7e0a7d4*/ void DisposeInternal_Injected(nint _unity_self);
        static /*0x7e0a8d0*/ void set_targetCamera_Injected(nint _unity_self, nint value);
        static /*0x7e0a96c*/ void SetBoundingSpheres_Injected(nint _unity_self, UnityEngine.BoundingSphere[] array);
        static /*0x7e0aa08*/ void SetBoundingSphereCount_Injected(nint _unity_self, int count);
        static /*0x7e0ab84*/ int QueryIndices_Injected(nint _unity_self, bool visible, int distanceIndex, UnityEngine.CullingQueryOptions options, ref UnityEngine.Bindings.ManagedSpanWrapper result, int firstIndex);
        static /*0x7e0ace8*/ void SetBoundingDistances_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper distances);
        static /*0x7e0ad94*/ void SetDistanceReferencePoint_InternalVector3_Injected(nint _unity_self, ref UnityEngine.Vector3 point);
        static /*0x7e0ae38*/ void FinalizerFailure_Injected(nint _unity_self);
        /*0x7e0a5fc*/ CullingGroup();
        /*0x7e0a694*/ void Finalize();
        /*0x7e0a784*/ void DisposeInternal();
        /*0x7e0a810*/ void Dispose();
        /*0x7e0a828*/ void set_targetCamera(UnityEngine.Camera value);
        /*0x7e0a914*/ void SetBoundingSpheres(UnityEngine.BoundingSphere[] array);
        /*0x7e0a9b0*/ void SetBoundingSphereCount(int count);
        /*0x7e0aa4c*/ int QueryIndices(bool visible, int[] result, int firstIndex);
        /*0x7e0aa64*/ int QueryIndices(bool visible, int distanceIndex, UnityEngine.CullingQueryOptions options, int[] result, int firstIndex);
        /*0x7e0abf8*/ void SetBoundingDistances(float[] distances);
        /*0x7e0ad2c*/ void SetDistanceReferencePoint_InternalVector3(UnityEngine.Vector3 point);
        /*0x7e0add8*/ void SetDistanceReferencePoint(UnityEngine.Vector3 point);
        /*0x7e0a734*/ void FinalizerFailure();

        class StateChanged : System.MulticastDelegate
        {
            /*0x7e0ae74*/ StateChanged(object object, nint method);
            /*0x7e0af14*/ void Invoke(UnityEngine.CullingGroupEvent sphere);
        }

        class BindingsMarshaller
        {
            static /*0x7e0af28*/ nint ConvertToNative(UnityEngine.CullingGroup cullingGroup);
        }
    }

    class ReflectionProbe : UnityEngine.Behaviour
    {
        static /*0x0*/ System.Action<UnityEngine.ReflectionProbe, UnityEngine.ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged;
        static /*0x8*/ System.Collections.Generic.Dictionary<int, System.Action<UnityEngine.Texture>> registeredDefaultReflectionSetActions;
        static /*0x10*/ System.Collections.Generic.List<System.Action<UnityEngine.Texture>> registeredDefaultReflectionTextureActions;

        static /*0x7e0b3a0*/ ReflectionProbe();
        static /*0x7e0b018*/ UnityEngine.Vector4 get_defaultTextureHDRDecodeValues();
        static /*0x7e0b0dc*/ UnityEngine.Texture get_defaultTexture();
        static /*0x7e0b18c*/ void CallReflectionProbeEvent(UnityEngine.ReflectionProbe probe, UnityEngine.ReflectionProbe.ReflectionProbeEvent probeEvent);
        static /*0x7e0b21c*/ void CallSetDefaultReflection(UnityEngine.Texture defaultReflectionCubemap);
        static /*0x7e0afdc*/ UnityEngine.Rendering.ReflectionProbeRefreshMode get_refreshMode_Injected(nint _unity_self);
        static /*0x7e0b0a0*/ void get_defaultTextureHDRDecodeValues_Injected(ref UnityEngine.Vector4 ret);
        static /*0x7e0b164*/ nint get_defaultTexture_Injected();
        /*0x7e0af40*/ UnityEngine.Rendering.ReflectionProbeRefreshMode get_refreshMode();

        enum ReflectionProbeEvent
        {
            ReflectionProbeAdded = 0,
            ReflectionProbeRemoved = 1,
        }
    }

    class DebugLogHandler : UnityEngine.ILogHandler
    {
        static /*0x7e0b488*/ void Internal_Log(UnityEngine.LogType level, UnityEngine.LogOption options, string msg, UnityEngine.Object obj);
        static /*0x7e0b698*/ void Internal_LogException(System.Exception ex, UnityEngine.Object obj);
        static /*0x7e0b63c*/ void Internal_Log_Injected(UnityEngine.LogType level, UnityEngine.LogOption options, ref UnityEngine.Bindings.ManagedSpanWrapper msg, nint obj);
        static /*0x7e0b72c*/ void Internal_LogException_Injected(System.Exception ex, nint obj);
        /*0x7e0b848*/ DebugLogHandler();
        /*0x7e0b770*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
        /*0x7e0b7ac*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.LogOption logOptions, UnityEngine.Object context, string format, object[] args);
        /*0x7e0b7ec*/ void LogException(System.Exception exception, UnityEngine.Object context);
    }

    class Debug
    {
        static /*0x0*/ UnityEngine.ILogger s_DefaultLogger;
        static /*0x8*/ UnityEngine.ILogger s_Logger;

        static /*0x7e0d520*/ Debug();
        static /*0x7e0b850*/ UnityEngine.ILogger get_unityLogger();
        static /*0x7e0b8a8*/ void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color);
        static /*0x7e0b990*/ void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, float duration, bool depthTest);
        static /*0x7e0bab0*/ int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder);
        static /*0x7e0bcb4*/ void Log(object message);
        static /*0x7e0bdbc*/ void Log(object message, UnityEngine.Object context);
        static /*0x7e0bed4*/ void LogFormat(string format, object[] args);
        static /*0x7e0bfec*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.LogOption logOptions, UnityEngine.Object context, string format, object[] args);
        static /*0x7e0c2d0*/ void LogError(object message);
        static /*0x7e0c3d8*/ void LogError(object message, UnityEngine.Object context);
        static /*0x7e0c4f0*/ void LogErrorFormat(string format, object[] args);
        static /*0x7e0c608*/ void LogErrorFormat(UnityEngine.Object context, string format, object[] args);
        static /*0x7dfe104*/ void LogException(System.Exception exception);
        static /*0x7df6eb4*/ void LogException(System.Exception exception, UnityEngine.Object context);
        static /*0x7e01c74*/ void LogWarning(object message);
        static /*0x7e0c724*/ void LogWarning(object message, UnityEngine.Object context);
        static /*0x7e0c83c*/ void LogWarningFormat(string format, object[] args);
        static /*0x7e0c954*/ void LogWarningFormat(UnityEngine.Object context, string format, object[] args);
        static /*0x7e0ca70*/ void Assert(bool condition);
        static /*0x7e0cba0*/ void Assert(bool condition, string message);
        static /*0x7e0ccbc*/ void LogAssertion(object message);
        static /*0x7e0cdc4*/ void LogAssertionFormat(string format, object[] args);
        static /*0x7e0cedc*/ bool get_isDebugBuild();
        static /*0x7e0cf04*/ bool CallOverridenDebugHandler(System.Exception exception, UnityEngine.Object obj);
        static /*0x7e0d2fc*/ bool IsLoggingEnabled();
        static /*0x7e0ba44*/ void DrawLine_Injected(ref UnityEngine.Vector3 start, ref UnityEngine.Vector3 end, ref UnityEngine.Color color, float duration, bool depthTest);
        static /*0x7e0bc60*/ int ExtractStackTraceNoAlloc_Injected(byte* buffer, int bufferMax, ref UnityEngine.Bindings.ManagedSpanWrapper projectFolder);
    }

    struct ExposedReference<T>
    {
        /*0x0*/ UnityEngine.PropertyName exposedName;
        /*0x0*/ UnityEngine.Object defaultValue;

        /*0x3907c14*/ T Resolve(UnityEngine.IExposedPropertyTable resolver);
    }

    interface IExposedPropertyTable
    {
        UnityEngine.Object GetReferenceValue(UnityEngine.PropertyName id, ref bool idValid);
    }

    class ExpressionEvaluator
    {
        static /*0x0*/ UnityEngine.ExpressionEvaluator.PcgRandom s_Random;
        static /*0x10*/ System.Collections.Generic.Dictionary<string, UnityEngine.ExpressionEvaluator.Operator> s_Operators;

        static /*0x7e0edbc*/ ExpressionEvaluator();
        static /*0x381cd68*/ bool Evaluate<T>(string expression, ref T value, ref UnityEngine.ExpressionEvaluator.Expression delayed);
        static /*0x3907c14*/ bool EvaluateTokens<T>(string[] tokens, ref T value, int index, int count);
        static /*0x7e0d610*/ bool EvaluateDouble(string[] tokens, ref double value, int index, int count);
        static /*0x7e0e068*/ string[] InfixToRPN(string[] tokens);
        static /*0x7e0e4d4*/ bool NeedToPop(System.Collections.Generic.Stack<string> operatorStack, UnityEngine.ExpressionEvaluator.Operator newOperator);
        static /*0x7e0e5bc*/ string[] ExpressionToTokens(string expression, ref bool hasVariables);
        static /*0x7e0dc00*/ bool IsCommand(string token);
        static /*0x7e0e000*/ bool IsVariable(string token);
        static /*0x7e0e468*/ bool IsDelayedFunction(string token);
        static /*0x7e0dae0*/ bool IsOperator(string token);
        static /*0x7e0db60*/ UnityEngine.ExpressionEvaluator.Operator TokenToOperator(string token);
        static /*0x7e0ea0c*/ string PreFormatExpression(string expression);
        static /*0x7e0ebec*/ string[] FixUnaryOperators(string[] tokens);
        static /*0x7e0dcac*/ double EvaluateOp(double[] values, UnityEngine.ExpressionEvaluator.Op op, int index, int count);
        static /*0x381cca4*/ bool TryParse<T>(string expression, ref T result);

        class Expression
        {
            /*0x10*/ string[] rpnTokens;
            /*0x18*/ bool hasVariables;

            /*0x7e0f398*/ Expression(string expression);
            bool Evaluate<T>(ref T value, int index, int count);
        }

        struct PcgRandom
        {
            /*0x10*/ ulong increment;
            /*0x18*/ ulong state;

            static /*0x7e0f45c*/ uint RotateRight(uint v, int rot);
            static /*0x7e0f444*/ uint XshRr(ulong s);
            /*0x7e0f330*/ PcgRandom(ulong state, ulong sequence);
            /*0x7e0ed84*/ uint GetUInt();
            /*0x7e0f424*/ void Step();
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

            /*0x7e0f358*/ Operator(UnityEngine.ExpressionEvaluator.Op op, int precedence, int inputs, UnityEngine.ExpressionEvaluator.Associativity associativity);
        }

        class <>c
        {
            static /*0x0*/ UnityEngine.ExpressionEvaluator.<> <>9;
            static /*0x8*/ System.Func<string, bool> <>9__14_0;

            static /*0x7e0f464*/ <>c();
            /*0x7e0f4cc*/ <>c();
            /*0x7e0f4d4*/ bool <ExpressionToTokens>b__14_0(string f);
        }
    }

    class LightingSettings : UnityEngine.Object
    {
        static /*0x7e0f5d8*/ void Internal_Create(UnityEngine.LightingSettings self);
        static /*0x7e0f68c*/ bool get_bakedGI_Injected(nint _unity_self);
        static /*0x7e0f748*/ void set_bakedGI_Injected(nint _unity_self, bool value);
        static /*0x7e0f804*/ bool get_realtimeGI_Injected(nint _unity_self);
        static /*0x7e0f8c0*/ void set_realtimeGI_Injected(nint _unity_self, bool value);
        static /*0x7e0f97c*/ bool get_realtimeEnvironmentLighting_Injected(nint _unity_self);
        static /*0x7e0fa38*/ void set_realtimeEnvironmentLighting_Injected(nint _unity_self, bool value);
        /*0x7e0f558*/ LightingSettings();
        /*0x7e0f554*/ void LightingSettingsDontStripMe();
        /*0x7e0f614*/ bool get_bakedGI();
        /*0x7e0f6c8*/ void set_bakedGI(bool value);
        /*0x7e0f78c*/ bool get_realtimeGI();
        /*0x7e0f840*/ void set_realtimeGI(bool value);
        /*0x7e0f904*/ bool get_realtimeEnvironmentLighting();
        /*0x7e0f9b8*/ void set_realtimeEnvironmentLighting(bool value);
    }

    struct Bounds : System.IEquatable<UnityEngine.Bounds>, System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3 m_Center;
        /*0x1c*/ UnityEngine.Vector3 m_Extents;

        static /*0x7e0fdf4*/ bool op_Equality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs);
        static /*0x7e0fe70*/ bool op_Inequality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs);
        /*0x7e0fa7c*/ Bounds(UnityEngine.Vector3 center, UnityEngine.Vector3 size);
        /*0x7e0fa9c*/ int GetHashCode();
        /*0x7e0fb74*/ bool Equals(object other);
        /*0x7e0fc44*/ bool Equals(UnityEngine.Bounds other);
        /*0x7e0fcb0*/ UnityEngine.Vector3 get_center();
        /*0x7e0fcbc*/ void set_center(UnityEngine.Vector3 value);
        /*0x7e0fcc8*/ UnityEngine.Vector3 get_size();
        /*0x7e0fce0*/ void set_size(UnityEngine.Vector3 value);
        /*0x7e0fcfc*/ UnityEngine.Vector3 get_extents();
        /*0x7e0fd08*/ void set_extents(UnityEngine.Vector3 value);
        /*0x7e0fd14*/ UnityEngine.Vector3 get_min();
        /*0x7e0fd34*/ void set_min(UnityEngine.Vector3 value);
        /*0x7e0fd84*/ UnityEngine.Vector3 get_max();
        /*0x7e0fda4*/ void set_max(UnityEngine.Vector3 value);
        /*0x7e0feec*/ void SetMinMax(UnityEngine.Vector3 min, UnityEngine.Vector3 max);
        /*0x7e0ff24*/ void Encapsulate(UnityEngine.Vector3 point);
        /*0x7e0ff9c*/ void Encapsulate(UnityEngine.Bounds bounds);
        /*0x7e10098*/ bool Intersects(UnityEngine.Bounds bounds);
        /*0x7e10138*/ string ToString();
        /*0x7e10148*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct BoundsInt : System.IEquatable<UnityEngine.BoundsInt>, System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3Int m_Position;
        /*0x1c*/ UnityEngine.Vector3Int m_Size;

        /*0x7e10320*/ BoundsInt(UnityEngine.Vector3Int position, UnityEngine.Vector3Int size);
        /*0x7e102e8*/ UnityEngine.Vector3Int get_position();
        /*0x7e102f8*/ void set_position(UnityEngine.Vector3Int value);
        /*0x7e10304*/ UnityEngine.Vector3Int get_size();
        /*0x7e10314*/ void set_size(UnityEngine.Vector3Int value);
        /*0x7e10334*/ string ToString();
        /*0x7e10344*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x7e104b8*/ bool Equals(object other);
        /*0x7e1058c*/ bool Equals(UnityEngine.BoundsInt other);
        /*0x7e10604*/ int GetHashCode();
    }

    class GeometryUtility
    {
        static /*0x7e106e0*/ void CalculateFrustumPlanes(UnityEngine.Camera camera, UnityEngine.Plane[] planes);
        static /*0x7e10760*/ void CalculateFrustumPlanes(UnityEngine.Matrix4x4 worldToProjectionMatrix, UnityEngine.Plane[] planes);
        static /*0x7e10960*/ bool TestPlanesAABB(UnityEngine.Plane[] planes, UnityEngine.Bounds bounds);
        static /*0x7e1083c*/ void Internal_ExtractPlanes(UnityEngine.Plane[] planes, UnityEngine.Matrix4x4 worldToProjectionMatrix);
        static /*0x7e10a38*/ bool TestPlanesAABB_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper planes, ref UnityEngine.Bounds bounds);
        static /*0x7e10a7c*/ void Internal_ExtractPlanes_Injected(ref UnityEngine.Bindings.BlittableArrayWrapper planes, ref UnityEngine.Matrix4x4 worldToProjectionMatrix);
    }

    struct Plane : System.IFormattable
    {
        static int size = 16;
        /*0x10*/ UnityEngine.Vector3 m_Normal;
        /*0x1c*/ float m_Distance;

        /*0x7e10ad4*/ Plane(UnityEngine.Vector3 inNormal, UnityEngine.Vector3 inPoint);
        /*0x7e10be4*/ Plane(UnityEngine.Vector3 inNormal, float d);
        /*0x7e10ccc*/ Plane(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c);
        /*0x7e10ac0*/ UnityEngine.Vector3 get_normal();
        /*0x7e10acc*/ float get_distance();
        /*0x7e10e44*/ float GetDistanceToPoint(UnityEngine.Vector3 point);
        /*0x7e10e68*/ bool Raycast(UnityEngine.Ray ray, ref float enter);
        /*0x7e10f68*/ string ToString();
        /*0x7e10f78*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Ray : System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3 m_Origin;
        /*0x1c*/ UnityEngine.Vector3 m_Direction;

        /*0x7e11118*/ Ray(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        /*0x7e11204*/ UnityEngine.Vector3 get_origin();
        /*0x7e11210*/ UnityEngine.Vector3 get_direction();
        /*0x7e1121c*/ UnityEngine.Vector3 GetPoint(float distance);
        /*0x7e11244*/ string ToString();
        /*0x7e11254*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Rect : System.IEquatable<UnityEngine.Rect>, System.IFormattable
    {
        /*0x10*/ float m_XMin;
        /*0x14*/ float m_YMin;
        /*0x18*/ float m_Width;
        /*0x1c*/ float m_Height;

        static /*0x7e11418*/ UnityEngine.Rect get_zero();
        static /*0x7e1142c*/ UnityEngine.Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax);
        static /*0x7e11624*/ UnityEngine.Rect OrderMinMax(UnityEngine.Rect rect);
        static /*0x7e11730*/ bool op_Inequality(UnityEngine.Rect lhs, UnityEngine.Rect rhs);
        static /*0x7e11764*/ bool op_Equality(UnityEngine.Rect lhs, UnityEngine.Rect rhs);
        /*0x7e113f4*/ Rect(float x, float y, float width, float height);
        /*0x7e11400*/ Rect(UnityEngine.Vector2 position, UnityEngine.Vector2 size);
        /*0x7e1140c*/ Rect(UnityEngine.Rect source);
        /*0x7e11438*/ float get_x();
        /*0x7e11440*/ void set_x(float value);
        /*0x7e11448*/ float get_y();
        /*0x7e11450*/ void set_y(float value);
        /*0x7e11458*/ UnityEngine.Vector2 get_position();
        /*0x7e11460*/ void set_position(UnityEngine.Vector2 value);
        /*0x7e11468*/ UnityEngine.Vector2 get_center();
        /*0x7e11480*/ void set_center(UnityEngine.Vector2 value);
        /*0x7e1149c*/ UnityEngine.Vector2 get_min();
        /*0x7e114a4*/ void set_min(UnityEngine.Vector2 value);
        /*0x7e114c0*/ UnityEngine.Vector2 get_max();
        /*0x7e114d0*/ void set_max(UnityEngine.Vector2 value);
        /*0x7e114e4*/ float get_width();
        /*0x7e114ec*/ void set_width(float value);
        /*0x7e114f4*/ float get_height();
        /*0x7e114fc*/ void set_height(float value);
        /*0x7e11504*/ UnityEngine.Vector2 get_size();
        /*0x7e1150c*/ void set_size(UnityEngine.Vector2 value);
        /*0x7e11514*/ float get_xMin();
        /*0x7e1151c*/ void set_xMin(float value);
        /*0x7e11538*/ float get_yMin();
        /*0x7e11540*/ void set_yMin(float value);
        /*0x7e1155c*/ float get_xMax();
        /*0x7e1156c*/ void set_xMax(float value);
        /*0x7e1157c*/ float get_yMax();
        /*0x7e1158c*/ void set_yMax(float value);
        /*0x7e1159c*/ bool Contains(UnityEngine.Vector2 point);
        /*0x7e115e0*/ bool Contains(UnityEngine.Vector3 point);
        /*0x7e11650*/ bool Overlaps(UnityEngine.Rect other);
        /*0x7e1169c*/ bool Overlaps(UnityEngine.Rect other, bool allowInverse);
        /*0x7e11798*/ int GetHashCode();
        /*0x7e11824*/ bool Equals(object other);
        /*0x7e1191c*/ bool Equals(UnityEngine.Rect other);
        /*0x7e119c8*/ string ToString();
        /*0x7e119d4*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct RectInt : System.IEquatable<UnityEngine.RectInt>, System.IFormattable
    {
        /*0x10*/ int m_XMin;
        /*0x14*/ int m_YMin;
        /*0x18*/ int m_Width;
        /*0x1c*/ int m_Height;

        /*0x7e12a9c*/ RectInt(int xMin, int yMin, int width, int height);
        /*0x7e128cc*/ int get_x();
        /*0x7e128d4*/ void set_x(int value);
        /*0x7e128dc*/ int get_y();
        /*0x7e128e4*/ void set_y(int value);
        /*0x7e128ec*/ int get_width();
        /*0x7e128f4*/ void set_width(int value);
        /*0x7e128fc*/ int get_height();
        /*0x7e12904*/ void set_height(int value);
        /*0x7e1290c*/ int get_xMin();
        /*0x7e12970*/ int get_yMin();
        /*0x7e129d4*/ int get_xMax();
        /*0x7e12a38*/ int get_yMax();
        /*0x7e12aa8*/ bool Overlaps(UnityEngine.RectInt other);
        /*0x7e12d48*/ string ToString();
        /*0x7e12d58*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x7e12f94*/ int GetHashCode();
        /*0x7e1302c*/ bool Equals(object other);
        /*0x7e130d4*/ bool Equals(UnityEngine.RectInt other);
    }

    class RectOffset : System.IFormattable
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ object m_SourceStyle;

        static /*0x7e13160*/ nint InternalCreate();
        static /*0x7e1386c*/ void InternalDestroy(nint ptr);
        static /*0x7e138a8*/ int get_left_Injected(nint _unity_self);
        static /*0x7e138e4*/ void set_left_Injected(nint _unity_self, int value);
        static /*0x7e13928*/ int get_right_Injected(nint _unity_self);
        static /*0x7e13964*/ void set_right_Injected(nint _unity_self, int value);
        static /*0x7e139a8*/ int get_top_Injected(nint _unity_self);
        static /*0x7e139e4*/ void set_top_Injected(nint _unity_self, int value);
        static /*0x7e13a28*/ int get_bottom_Injected(nint _unity_self);
        static /*0x7e13a64*/ void set_bottom_Injected(nint _unity_self, int value);
        static /*0x7e13af8*/ int get_horizontal_Injected(nint _unity_self);
        static /*0x7e13b84*/ int get_vertical_Injected(nint _unity_self);
        static /*0x7e13c38*/ void Remove_Injected(nint _unity_self, ref UnityEngine.Rect rect, ref UnityEngine.Rect ret);
        /*0x7e13118*/ RectOffset();
        /*0x7e13188*/ RectOffset(object sourceStyle, nint source);
        /*0x7e132dc*/ RectOffset(int left, int right, int top, int bottom);
        /*0x7e131c4*/ void Finalize();
        /*0x7e134d0*/ string ToString();
        /*0x7e134e0*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x7e13290*/ void Destroy();
        /*0x7e1372c*/ int get_left();
        /*0x7e13370*/ void set_left(int value);
        /*0x7e1377c*/ int get_right();
        /*0x7e133c8*/ void set_right(int value);
        /*0x7e137cc*/ int get_top();
        /*0x7e13420*/ void set_top(int value);
        /*0x7e1381c*/ int get_bottom();
        /*0x7e13478*/ void set_bottom(int value);
        /*0x7e13aa8*/ int get_horizontal();
        /*0x7e13b34*/ int get_vertical();
        /*0x7e13bc0*/ UnityEngine.Rect Remove(UnityEngine.Rect rect);

        class BindingsMarshaller
        {
            static /*0x7e13c8c*/ nint ConvertToNative(UnityEngine.RectOffset rectOffset);
        }
    }

    class Gizmos
    {
        static /*0x7e13ca4*/ void DrawLine(UnityEngine.Vector3 from, UnityEngine.Vector3 to);
        static /*0x7e13d38*/ void DrawWireSphere(UnityEngine.Vector3 center, float radius);
        static /*0x7e13dd8*/ void DrawSphere(UnityEngine.Vector3 center, float radius);
        static /*0x7e13e78*/ void DrawWireCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size);
        static /*0x7e13f0c*/ void DrawCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size);
        static /*0x7e13fa0*/ void DrawMesh(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale);
        static /*0x7e140d8*/ void DrawWireMesh(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale);
        static /*0x7e14210*/ void DrawIcon(UnityEngine.Vector3 center, string name, bool allowScaling, UnityEngine.Color tint);
        static /*0x7e143f4*/ void set_color(UnityEngine.Color value);
        static /*0x7e14474*/ void set_matrix(UnityEngine.Matrix4x4 value);
        static /*0x7e144ec*/ void DrawMesh(UnityEngine.Mesh mesh);
        static /*0x7e145f0*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale);
        static /*0x7e14608*/ void DrawWireMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale);
        static /*0x7e13cf4*/ void DrawLine_Injected(ref UnityEngine.Vector3 from, ref UnityEngine.Vector3 to);
        static /*0x7e13d8c*/ void DrawWireSphere_Injected(ref UnityEngine.Vector3 center, float radius);
        static /*0x7e13e2c*/ void DrawSphere_Injected(ref UnityEngine.Vector3 center, float radius);
        static /*0x7e13ec8*/ void DrawWireCube_Injected(ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 size);
        static /*0x7e13f5c*/ void DrawCube_Injected(ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 size);
        static /*0x7e1406c*/ void DrawMesh_Injected(nint mesh, int submeshIndex, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 scale);
        static /*0x7e141a4*/ void DrawWireMesh_Injected(nint mesh, int submeshIndex, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 scale);
        static /*0x7e14398*/ void DrawIcon_Injected(ref UnityEngine.Vector3 center, ref UnityEngine.Bindings.ManagedSpanWrapper name, bool allowScaling, ref UnityEngine.Color tint);
        static /*0x7e14438*/ void set_color_Injected(ref UnityEngine.Color value);
        static /*0x7e144b0*/ void set_matrix_Injected(ref UnityEngine.Matrix4x4 value);
    }

    class BeforeRenderHelper
    {
        static /*0x0*/ System.Collections.Generic.List<UnityEngine.BeforeRenderHelper.OrderBlock> s_OrderBlocks;

        static /*0x7e147cc*/ BeforeRenderHelper();
        static /*0x7e14620*/ void Invoke();

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
        static /*0x10*/ System.Action<UnityEngine.CustomRenderTexture, int> updateTriggered;
        static /*0x18*/ System.Action<UnityEngine.CustomRenderTexture> initializeTriggered;

        static /*0x7e14864*/ void InvokeOnTextureLoaded_Internal(UnityEngine.CustomRenderTexture source);
        static /*0x7e148d0*/ void InvokeOnTextureUnloaded_Internal(UnityEngine.CustomRenderTexture source);
        static /*0x7e1493c*/ void InvokeTriggerUpdate(UnityEngine.CustomRenderTexture crt, int updateCount);
        static /*0x7e149bc*/ void InvokeTriggerInitialize(UnityEngine.CustomRenderTexture crt);
    }

    class Display
    {
        static /*0x0*/ UnityEngine.Display[] displays;
        static /*0x8*/ UnityEngine.Display _mainDisplay;
        static /*0x10*/ int m_ActiveEditorGameViewTarget;
        static /*0x18*/ UnityEngine.Display.DisplaysUpdatedDelegate onDisplaysUpdated;
        /*0x10*/ nint nativeDisplay;

        static /*0x7e152bc*/ Display();
        static /*0x7e14f24*/ UnityEngine.Vector3 RelativeMouseAt(UnityEngine.Vector3 inputMouseCoordinates);
        static /*0x7e15040*/ UnityEngine.Display get_main();
        static /*0x7e15098*/ void RecreateDisplayList(nint[] nativeDisplay);
        static /*0x7e15228*/ void FireDisplaysUpdated();
        static /*0x7e14c9c*/ void GetSystemExtImpl(nint nativeDisplay, ref int w, ref int h);
        static /*0x7e14b20*/ void GetRenderingExtImpl(nint nativeDisplay, ref int w, ref int h);
        static /*0x7e14e1c*/ void GetRenderingBuffersImpl(nint nativeDisplay, ref UnityEngine.RenderBuffer color, ref UnityEngine.RenderBuffer depth);
        static /*0x7e14fe4*/ int RelativeMouseAtImpl(int x, int y, ref int rx, ref int ry);
        static /*0x7e14ee8*/ bool RequiresSrgbBlitToBackbufferImpl(nint nativeDisplay);
        /*0x7e14a28*/ Display();
        /*0x7e14a64*/ Display(nint nativeDisplay);
        /*0x7e14a8c*/ int get_renderingWidth();
        /*0x7e14b74*/ int get_renderingHeight();
        /*0x7e14c08*/ int get_systemWidth();
        /*0x7e14cf0*/ int get_systemHeight();
        /*0x7e14d84*/ UnityEngine.RenderBuffer get_colorBuffer();
        /*0x7e14e70*/ bool get_requiresSrgbBlitToBackbuffer();

        class DisplaysUpdatedDelegate : System.MulticastDelegate
        {
            /*0x7e153f8*/ DisplaysUpdatedDelegate(object object, nint method);
            /*0x7e15494*/ void Invoke();
        }
    }

    struct LightProbesQuery : System.IDisposable
    {
        /*0x10*/ nint m_LightProbeContextWrapper;
        /*0x18*/ Unity.Collections.Allocator m_AllocatorLabel;

        static /*0x7e154fc*/ nint Create();
        static /*0x7e15610*/ void Destroy(nint lightProbeContextWrapper);
        static /*0x7e1597c*/ void CalculateInterpolatedLightAndOcclusionProbes(nint lightProbeContextWrapper, nint positions, nint tetrahedronIndices, nint lightProbes, nint occlusionProbes, int count);
        /*0x7e154a8*/ LightProbesQuery(Unity.Collections.Allocator allocator);
        /*0x7e15524*/ void Dispose();
        /*0x7e1564c*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
        /*0x7e15744*/ void CalculateInterpolatedLightAndOcclusionProbes(Unity.Collections.NativeArray<UnityEngine.Vector3> positions, Unity.Collections.NativeArray<int> tetrahedronIndices, Unity.Collections.NativeArray<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, Unity.Collections.NativeArray<UnityEngine.Vector4> occlusionProbes);

        struct LightProbesQueryDispose
        {
            /*0x10*/ nint m_LightProbeContextWrapper;

            /*0x7e159f0*/ void Dispose();
        }

        struct LightProbesQueryDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ UnityEngine.LightProbesQuery.LightProbesQueryDispose Data;

            /*0x7e15a40*/ void Execute();
        }
    }

    struct RefreshRate : System.IEquatable<UnityEngine.RefreshRate>, System.IComparable<UnityEngine.RefreshRate>
    {
        /*0x10*/ uint numerator;
        /*0x14*/ uint denominator;

        /*0x7e15a44*/ double get_value();
        /*0x7e15a58*/ bool Equals(UnityEngine.RefreshRate other);
        /*0x7e15a94*/ int CompareTo(UnityEngine.RefreshRate other);
        /*0x7e15ae8*/ string ToString();
    }

    class Screen
    {
        static /*0x7e15b88*/ int get_width();
        static /*0x7e15bb0*/ int get_height();
        static /*0x7e15bd8*/ float get_dpi();
        static /*0x7e15c00*/ UnityEngine.ScreenOrientation GetScreenOrientation();
        static /*0x7e15c28*/ UnityEngine.ScreenOrientation get_orientation();
        static /*0x7e15c50*/ void set_sleepTimeout(int value);
        static /*0x7e15c8c*/ UnityEngine.Resolution get_currentResolution();
        static /*0x7e15d0c*/ bool get_fullScreen();
        static /*0x7e15d34*/ UnityEngine.Rect get_safeArea();
        static /*0x7e15db8*/ void SetMSAASamples(int numSamples);
        static /*0x7e15df4*/ int GetMSAASamples();
        static /*0x7e15e1c*/ int get_msaaSamples();
        static /*0x7e15cd0*/ void get_currentResolution_Injected(ref UnityEngine.Resolution ret);
        static /*0x7e15d7c*/ void get_safeArea_Injected(ref UnityEngine.Rect ret);
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

        static /*0x7e17e14*/ Graphics();
        static /*0x7e15e44*/ int Internal_GetMaxDrawMeshInstanceCount();
        static /*0x7e15e6c*/ UnityEngine.Rendering.GraphicsTier get_activeTier();
        static /*0x7e15e94*/ void set_activeTier(UnityEngine.Rendering.GraphicsTier value);
        static /*0x7e15ed0*/ bool GetPreserveFramebufferAlpha();
        static /*0x7e15ef8*/ bool get_preserveFramebufferAlpha();
        static /*0x7e15f60*/ UnityEngine.Rendering.OpenGLESVersion GetMinOpenGLESVersion();
        static /*0x7e15f88*/ UnityEngine.Rendering.OpenGLESVersion get_minOpenGLESVersion();
        static /*0x7e15ff0*/ void Internal_SetNullRT();
        static /*0x7e16018*/ void Internal_SetRTSimple(UnityEngine.RenderBuffer color, UnityEngine.RenderBuffer depth, int mip, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x7e1612c*/ void ClearRandomWriteTargets();
        static /*0x7e16154*/ void CopyTexture_Slice(UnityEngine.Texture src, int srcElement, int srcMip, UnityEngine.Texture dst, int dstElement, int dstMip);
        static /*0x7e162c8*/ void CopyTexture_Region(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, UnityEngine.Texture dst, int dstElement, int dstMip, int dstX, int dstY);
        static /*0x7e164c0*/ void Internal_DrawMesh(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int layer, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x7e16764*/ void Internal_DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x7e16acc*/ void Blit2(UnityEngine.Texture source, UnityEngine.RenderTexture dest);
        static /*0x7e16bec*/ void Blit4(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset);
        static /*0x7e16d40*/ void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer buffer);
        static /*0x7e16e3c*/ void SetRenderTargetImpl(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, int mipLevel, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x7e16ed8*/ void SetRenderTargetImpl(UnityEngine.RenderTexture rt, int mipLevel, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x7e1700c*/ void SetRenderTarget(UnityEngine.RenderTexture rt, int mipLevel, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x7e17088*/ void CopyTexture(UnityEngine.Texture src, int srcElement, int srcMip, UnityEngine.Texture dst, int dstElement, int dstMip);
        static /*0x7e1711c*/ void CopyTexture(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, UnityEngine.Texture dst, int dstElement, int dstMip, int dstX, int dstY);
        static /*0x7e17234*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int layer, UnityEngine.Camera camera, int submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x7e173cc*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x7e17924*/ void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest);
        static /*0x7e17988*/ void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset);
        static /*0x7e17a1c*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, int layer, UnityEngine.Camera camera);
        static /*0x7e17b8c*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int layer, UnityEngine.Camera camera, int submeshIndex, UnityEngine.MaterialPropertyBlock properties);
        static /*0x7e17c74*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, UnityEngine.Camera camera);
        static /*0x7e17d48*/ void SetRenderTarget(UnityEngine.RenderTexture rt);
        static /*0x7e17da8*/ void SetRenderTarget(UnityEngine.RenderTexture rt, int mipLevel);
        static /*0x7e160c0*/ void Internal_SetRTSimple_Injected(ref UnityEngine.RenderBuffer color, ref UnityEngine.RenderBuffer depth, int mip, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x7e16254*/ void CopyTexture_Slice_Injected(nint src, int srcElement, int srcMip, nint dst, int dstElement, int dstMip);
        static /*0x7e16400*/ void CopyTexture_Region_Injected(nint src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, nint dst, int dstElement, int dstMip, int dstX, int dstY);
        static /*0x7e166a4*/ void Internal_DrawMesh_Injected(nint mesh, int submeshIndex, ref UnityEngine.Matrix4x4 matrix, nint material, int layer, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, nint probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume);
        static /*0x7e16a0c*/ void Internal_DrawMeshInstanced_Injected(nint mesh, int submeshIndex, nint material, ref UnityEngine.Bindings.ManagedSpanWrapper matrices, int count, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume);
        static /*0x7e16ba8*/ void Blit2_Injected(nint source, nint dest);
        static /*0x7e16ce4*/ void Blit4_Injected(nint source, nint dest, ref UnityEngine.Vector2 scale, ref UnityEngine.Vector2 offset);
        static /*0x7e16e00*/ void ExecuteCommandBuffer_Injected(nint buffer);
    }

    class GL
    {
        static /*0x7e17ed4*/ void Vertex3(float x, float y, float z);
        static /*0x7e17f24*/ void TexCoord3(float x, float y, float z);
        static /*0x7e17f74*/ void TexCoord2(float x, float y);
        static /*0x7e17fb8*/ void ImmediateColor(float r, float g, float b, float a);
        static /*0x7e18010*/ void Color(UnityEngine.Color c);
        static /*0x7e18068*/ bool get_wireframe();
        static /*0x7e18090*/ void SetViewMatrix(UnityEngine.Matrix4x4 m);
        static /*0x7e18108*/ void set_modelview(UnityEngine.Matrix4x4 value);
        static /*0x7e18154*/ void PushMatrix();
        static /*0x7e1817c*/ void PopMatrix();
        static /*0x7e181a4*/ void LoadOrtho();
        static /*0x7e181cc*/ void LoadProjectionMatrix(UnityEngine.Matrix4x4 mat);
        static /*0x7e18244*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(UnityEngine.Matrix4x4 proj, bool renderIntoTexture);
        static /*0x7e18314*/ void GLLoadPixelMatrixScript(float left, float right, float bottom, float top);
        static /*0x7e1836c*/ void LoadPixelMatrix(float left, float right, float bottom, float top);
        static /*0x7e183c4*/ void Begin(int mode);
        static /*0x7e18400*/ void End();
        static /*0x7e18428*/ void GLClear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
        static /*0x7e184f8*/ void Clear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
        static /*0x7e18504*/ void Clear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
        static /*0x7e18514*/ void Viewport(UnityEngine.Rect pixelRect);
        static /*0x7e180cc*/ void SetViewMatrix_Injected(ref UnityEngine.Matrix4x4 m);
        static /*0x7e18208*/ void LoadProjectionMatrix_Injected(ref UnityEngine.Matrix4x4 mat);
        static /*0x7e182c0*/ void GetGPUProjectionMatrix_Injected(ref UnityEngine.Matrix4x4 proj, bool renderIntoTexture, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e18494*/ void GLClear_Injected(bool clearDepth, bool clearColor, ref UnityEngine.Color backgroundColor, float depth);
        static /*0x7e18558*/ void Viewport_Injected(ref UnityEngine.Rect pixelRect);
    }

    class ScalableBufferManager
    {
        static /*0x7e18594*/ float get_widthScaleFactor();
        static /*0x7e185bc*/ float get_heightScaleFactor();
        static /*0x7e185e4*/ void ResizeBuffers(float widthScale, float heightScale);
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
        static /*0x7e18624*/ void CaptureFrameTimings();
        static /*0x7e1864c*/ uint GetLatestTimings(uint numFrames, UnityEngine.FrameTiming[] timings);
        static /*0x7e18720*/ uint GetLatestTimings_Injected(uint numFrames, ref UnityEngine.Bindings.ManagedSpanWrapper timings);
    }

    class LightmapData
    {
        /*0x10*/ UnityEngine.Texture2D m_Light;
        /*0x18*/ UnityEngine.Texture2D m_Dir;
        /*0x20*/ UnityEngine.Texture2D m_ShadowMask;

        /*0x7e18764*/ LightmapData();
    }

    class LightmapSettings : UnityEngine.Object
    {
        static /*0x7e187c4*/ UnityEngine.LightmapData[] get_lightmaps();
        static /*0x7e187ec*/ void set_lightmaps(UnityEngine.LightmapData[] value);
        static /*0x7e18828*/ UnityEngine.LightmapsMode get_lightmapsMode();
        static /*0x7e18850*/ void set_lightmapsMode(UnityEngine.LightmapsMode value);
        static /*0x7e1888c*/ UnityEngine.LightProbes get_lightProbes();
        static /*0x7e18918*/ void set_lightProbes(UnityEngine.LightProbes value);
        static /*0x7e189d8*/ void Reset();
        static /*0x7e18a00*/ UnityEngine.LightmapsModeLegacy get_lightmapsModeLegacy();
        static /*0x7e18a08*/ void set_lightmapsModeLegacy(UnityEngine.LightmapsModeLegacy value);
        static /*0x7e18a0c*/ UnityEngine.ColorSpace get_bakedColorSpace();
        static /*0x7e18a5c*/ void set_bakedColorSpace(UnityEngine.ColorSpace value);
        static /*0x7e188f0*/ nint get_lightProbes_Injected();
        static /*0x7e1899c*/ void set_lightProbes_Injected(nint value);
        /*0x7e1876c*/ LightmapSettings();
    }

    class LightProbes : UnityEngine.Object
    {
        static /*0x0*/ System.Action lightProbesUpdated;
        static /*0x8*/ System.Action tetrahedralizationCompleted;
        static /*0x10*/ System.Action needsRetetrahedralization;

        static /*0x7e18ab8*/ void add_lightProbesUpdated(System.Action value);
        static /*0x7e18b70*/ void remove_lightProbesUpdated(System.Action value);
        static /*0x7e18c28*/ void Internal_CallLightProbesUpdatedFunction();
        static /*0x7e18c8c*/ void add_tetrahedralizationCompleted(System.Action value);
        static /*0x7e18d48*/ void remove_tetrahedralizationCompleted(System.Action value);
        static /*0x7e18e04*/ void Internal_CallTetrahedralizationCompletedFunction();
        static /*0x7e18e68*/ void add_needsRetetrahedralization(System.Action value);
        static /*0x7e18f24*/ void remove_needsRetetrahedralization(System.Action value);
        static /*0x7e18fe0*/ void Internal_CallNeedsRetetrahedralizationFunction();
        static /*0x7e19044*/ void Tetrahedralize();
        static /*0x7e1906c*/ void TetrahedralizeAsync();
        static /*0x7e19094*/ void GetInterpolatedProbe(UnityEngine.Vector3 position, UnityEngine.Renderer renderer, ref UnityEngine.Rendering.SphericalHarmonicsL2 probe);
        static /*0x7e19194*/ bool AreLightProbesAllowed(UnityEngine.Renderer renderer);
        static /*0x7e19254*/ void CalculateInterpolatedLightAndOcclusionProbes(UnityEngine.Vector3[] positions, UnityEngine.Rendering.SphericalHarmonicsL2[] lightProbes, UnityEngine.Vector4[] occlusionProbes);
        static /*0x7e19568*/ void CalculateInterpolatedLightAndOcclusionProbes(System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, System.Collections.Generic.List<UnityEngine.Vector4> occlusionProbes);
        static /*0x7e1939c*/ void CalculateInterpolatedLightAndOcclusionProbes_Internal(UnityEngine.Vector3[] positions, int positionsCount, UnityEngine.Rendering.SphericalHarmonicsL2[] lightProbes, UnityEngine.Vector4[] occlusionProbes);
        static /*0x7e197d4*/ UnityEngine.LightProbes GetSharedLightProbesForScene(UnityEngine.SceneManagement.Scene scene);
        static /*0x7e19880*/ UnityEngine.LightProbes GetInstantiatedLightProbesForScene(UnityEngine.SceneManagement.Scene scene);
        static /*0x7e1a2e4*/ int GetCount();
        static /*0x7e19140*/ void GetInterpolatedProbe_Injected(ref UnityEngine.Vector3 position, nint renderer, ref UnityEngine.Rendering.SphericalHarmonicsL2 probe);
        static /*0x7e19218*/ bool AreLightProbesAllowed_Injected(nint renderer);
        static /*0x7e19778*/ void CalculateInterpolatedLightAndOcclusionProbes_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper positions, int positionsCount, ref UnityEngine.Bindings.ManagedSpanWrapper lightProbes, ref UnityEngine.Bindings.ManagedSpanWrapper occlusionProbes);
        static /*0x7e19844*/ nint GetSharedLightProbesForScene_Injected(ref UnityEngine.SceneManagement.Scene scene);
        static /*0x7e198f0*/ nint GetInstantiatedLightProbesForScene_Injected(ref UnityEngine.SceneManagement.Scene scene);
        static /*0x7e19a54*/ void get_positions_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e19bc0*/ void GetPositionsSelf_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e19d14*/ bool SetPositionsSelf_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper positions, bool checkForDuplicatePositions);
        static /*0x7e19e90*/ void get_bakedProbes_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e19fd0*/ void set_bakedProbes_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7e1a08c*/ int get_count_Injected(nint _unity_self);
        static /*0x7e1a140*/ int get_countSelf_Injected(nint _unity_self);
        static /*0x7e1a1f4*/ int get_cellCount_Injected(nint _unity_self);
        static /*0x7e1a2a8*/ int get_cellCountSelf_Injected(nint _unity_self);
        /*0x7e18a60*/ LightProbes();
        /*0x7e1992c*/ UnityEngine.Vector3[] get_positions();
        /*0x7e19a98*/ UnityEngine.Vector3[] GetPositionsSelf();
        /*0x7e19c04*/ bool SetPositionsSelf(UnityEngine.Vector3[] positions, bool checkForDuplicatePositions);
        /*0x7e19d68*/ UnityEngine.Rendering.SphericalHarmonicsL2[] get_bakedProbes();
        /*0x7e19ed4*/ void set_bakedProbes(UnityEngine.Rendering.SphericalHarmonicsL2[] value);
        /*0x7e1a014*/ int get_count();
        /*0x7e1a0c8*/ int get_countSelf();
        /*0x7e1a17c*/ int get_cellCount();
        /*0x7e1a230*/ int get_cellCountSelf();
        /*0x7e1a30c*/ void GetInterpolatedLightProbe(UnityEngine.Vector3 position, UnityEngine.Renderer renderer, float[] coefficients);
        /*0x7e1a310*/ float[] get_coefficients();
        /*0x7e1a354*/ void set_coefficients(float[] value);
    }

    class HDROutputSettings
    {
        static /*0x0*/ UnityEngine.HDROutputSettings[] displays;
        static /*0x8*/ UnityEngine.HDROutputSettings _mainDisplay;
        /*0x10*/ int m_DisplayIndex;

        static /*0x7e1ac94*/ HDROutputSettings();
        static /*0x7e1a39c*/ UnityEngine.HDROutputSettings get_main();
        static /*0x7e1a46c*/ bool GetActive(int displayIndex);
        static /*0x7e1a520*/ bool GetAvailable(int displayIndex);
        static /*0x7e1a5d4*/ bool GetAutomaticHDRTonemapping(int displayIndex);
        static /*0x7e1a698*/ void SetAutomaticHDRTonemapping(int displayIndex, bool scripted);
        static /*0x7e1a754*/ UnityEngine.ColorGamut GetDisplayColorGamut(int displayIndex);
        static /*0x7e1a808*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(int displayIndex);
        static /*0x7e1a8bc*/ float GetPaperWhiteNits(int displayIndex);
        static /*0x7e1a970*/ int GetMaxFullFrameToneMapLuminance(int displayIndex);
        static /*0x7e1aa24*/ int GetMaxToneMapLuminance(int displayIndex);
        static /*0x7e1aad8*/ int GetMinToneMapLuminance(int displayIndex);
        static /*0x7e1ab8c*/ bool GetHDRModeChangeRequested(int displayIndex);
        static /*0x7e1ac50*/ void RequestHDRModeChangeInternal(int displayIndex, bool enabled);
        /*0x7e1a358*/ HDROutputSettings();
        /*0x7e1a374*/ HDROutputSettings(int displayIndex);
        /*0x7e1a3f4*/ bool get_active();
        /*0x7e1a4a8*/ bool get_available();
        /*0x7e1a55c*/ bool get_automaticHDRTonemapping();
        /*0x7e1a610*/ void set_automaticHDRTonemapping(bool value);
        /*0x7e1a6dc*/ UnityEngine.ColorGamut get_displayColorGamut();
        /*0x7e1a790*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x7e1a844*/ float get_paperWhiteNits();
        /*0x7e1a8f8*/ int get_maxFullFrameToneMapLuminance();
        /*0x7e1a9ac*/ int get_maxToneMapLuminance();
        /*0x7e1aa60*/ int get_minToneMapLuminance();
        /*0x7e1ab14*/ bool get_HDRModeChangeRequested();
        /*0x7e1abc8*/ void RequestHDRModeChange(bool enabled);
    }

    class ColorGamutUtility
    {
        static /*0x7e1ad90*/ UnityEngine.ColorPrimaries GetColorPrimaries(UnityEngine.ColorGamut gamut);
        static /*0x7e1adcc*/ UnityEngine.WhitePoint GetWhitePoint(UnityEngine.ColorGamut gamut);
        static /*0x7e1ae08*/ UnityEngine.TransferFunction GetTransferFunction(UnityEngine.ColorGamut gamut);
    }

    struct Resolution
    {
        /*0x10*/ int m_Width;
        /*0x14*/ int m_Height;
        /*0x18*/ UnityEngine.RefreshRate m_RefreshRate;

        /*0x7e1ae44*/ UnityEngine.RefreshRate get_refreshRateRatio();
        /*0x7e1ae4c*/ string ToString();
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

        static /*0x7e1afe4*/ void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel);
        static /*0x7e1b064*/ int get_pixelLightCount();
        static /*0x7e1b08c*/ void set_pixelLightCount(int value);
        static /*0x7e1b0c8*/ UnityEngine.ShadowmaskMode get_shadowmaskMode();
        static /*0x7e1b0f0*/ float get_lodBias();
        static /*0x7e1b118*/ int get_maximumLODLevel();
        static /*0x7e1b140*/ void set_enableLODCrossFade(bool value);
        static /*0x7e1b17c*/ int get_vSyncCount();
        static /*0x7e1b1a4*/ void set_vSyncCount(int value);
        static /*0x7e1b1e0*/ int get_antiAliasing();
        static /*0x7e1b208*/ void set_antiAliasing(int value);
        static /*0x7e1b244*/ bool get_billboardsFaceCameraPosition();
        static /*0x7e1b26c*/ int GetQualityLevel();
        static /*0x7e1b294*/ string[] get_names();
        static /*0x7e18a34*/ UnityEngine.ColorSpace get_desiredColorSpace();
        static /*0x7e1b2bc*/ UnityEngine.ColorSpace get_activeColorSpace();
    }

    class ImageEffectAllowedInSceneView : System.Attribute
    {
        /*0x7e1b2e4*/ ImageEffectAllowedInSceneView();
    }

    class ImageEffectUsesCommandBuffer : System.Attribute
    {
        /*0x7e1b2ec*/ ImageEffectUsesCommandBuffer();
    }

    enum LightmapsModeLegacy
    {
        Single = 0,
        Dual = 1,
        Directional = 2,
    }

    class TrailRenderer : UnityEngine.Renderer
    {
        static /*0x7e1b36c*/ float get_time_Injected(nint _unity_self);
        static /*0x7e1b430*/ void set_time_Injected(nint _unity_self, float value);
        static /*0x7e1b4f4*/ float get_startWidth_Injected(nint _unity_self);
        static /*0x7e1b5b8*/ void set_startWidth_Injected(nint _unity_self, float value);
        static /*0x7e1b67c*/ float get_endWidth_Injected(nint _unity_self);
        static /*0x7e1b740*/ void set_endWidth_Injected(nint _unity_self, float value);
        /*0x7e1b2f4*/ float get_time();
        /*0x7e1b3a8*/ void set_time(float value);
        /*0x7e1b47c*/ float get_startWidth();
        /*0x7e1b530*/ void set_startWidth(float value);
        /*0x7e1b604*/ float get_endWidth();
        /*0x7e1b6b8*/ void set_endWidth(float value);
    }

    class LineRenderer : UnityEngine.Renderer
    {
        static /*0x7e1b81c*/ void set_startColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x7e1b8f0*/ void set_endColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        /*0x7e1b78c*/ void set_startColor(UnityEngine.Color value);
        /*0x7e1b860*/ void set_endColor(UnityEngine.Color value);
    }

    class MaterialPropertyBlock
    {
        /*0x10*/ nint m_Ptr;

        static /*0x7e1c6c0*/ nint CreateImpl();
        static /*0x7e1c6e8*/ void DestroyImpl(nint mpb);
        static /*0x7e1b98c*/ float GetFloatImpl_Injected(nint _unity_self, int name);
        static /*0x7e1ba44*/ void GetColorImpl_Injected(nint _unity_self, int name, ref UnityEngine.Color ret);
        static /*0x7e1bb00*/ void SetIntImpl_Injected(nint _unity_self, int name, int value);
        static /*0x7e1bbbc*/ void SetFloatImpl_Injected(nint _unity_self, int name, float value);
        static /*0x7e1bc80*/ void SetVectorImpl_Injected(nint _unity_self, int name, ref UnityEngine.Vector4 value);
        static /*0x7e1bd44*/ void SetColorImpl_Injected(nint _unity_self, int name, ref UnityEngine.Color value);
        static /*0x7e1be00*/ void SetMatrixImpl_Injected(nint _unity_self, int name, ref UnityEngine.Matrix4x4 value);
        static /*0x7e1bf3c*/ void SetTextureImpl_Injected(nint _unity_self, int name, nint value);
        static /*0x7e1c080*/ void SetRenderTextureImpl_Injected(nint _unity_self, int name, nint value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x7e1c14c*/ void SetBufferImpl_Injected(nint _unity_self, int name, nint value);
        static /*0x7e1c228*/ void SetConstantBufferImpl_Injected(nint _unity_self, int name, nint value, int offset, int size);
        static /*0x7e1c39c*/ void SetFloatArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e1c500*/ void SetVectorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e1c664*/ void SetMatrixArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e1c77c*/ void Clear_Injected(nint _unity_self, bool keepMemory);
        /*0x7e1c9fc*/ MaterialPropertyBlock();
        /*0x7e1b934*/ float GetFloatImpl(int name);
        /*0x7e1b9d0*/ UnityEngine.Color GetColorImpl(int name);
        /*0x7e1ba98*/ void SetIntImpl(int name, int value);
        /*0x7e1bb54*/ void SetFloatImpl(int name, float value);
        /*0x7e1bc10*/ void SetVectorImpl(int name, UnityEngine.Vector4 value);
        /*0x7e1bcd4*/ void SetColorImpl(int name, UnityEngine.Color value);
        /*0x7e1bd98*/ void SetMatrixImpl(int name, UnityEngine.Matrix4x4 value);
        /*0x7e1be54*/ void SetTextureImpl(int name, UnityEngine.Texture value);
        /*0x7e1bf90*/ void SetRenderTextureImpl(int name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x7e1c0dc*/ void SetBufferImpl(int name, UnityEngine.ComputeBuffer value);
        /*0x7e1c1a0*/ void SetConstantBufferImpl(int name, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x7e1c294*/ void SetFloatArrayImpl(int name, float[] values, int count);
        /*0x7e1c3f8*/ void SetVectorArrayImpl(int name, UnityEngine.Vector4[] values, int count);
        /*0x7e1c55c*/ void SetMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x7e1c724*/ void Clear(bool keepMemory);
        /*0x7e1c7c0*/ void Clear();
        /*0x7e1c7c8*/ void SetFloatArray(int name, float[] values, int count);
        /*0x7e1c884*/ void SetVectorArray(int name, UnityEngine.Vector4[] values, int count);
        /*0x7e1c940*/ void SetMatrixArray(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x7e1ca44*/ void Finalize();
        /*0x7e1cad8*/ void Dispose();
        /*0x7e1cb6c*/ void SetInt(string name, int value);
        /*0x7e1cd0c*/ void SetInt(int nameID, int value);
        /*0x7e1cd14*/ void SetFloat(string name, float value);
        /*0x7e1cd44*/ void SetFloat(int nameID, float value);
        /*0x7e1cd48*/ void SetInteger(int nameID, int value);
        /*0x7e1cd4c*/ void SetVector(string name, UnityEngine.Vector4 value);
        /*0x7e1cd9c*/ void SetVector(int nameID, UnityEngine.Vector4 value);
        /*0x7e1cda0*/ void SetColor(string name, UnityEngine.Color value);
        /*0x7e1cdf0*/ void SetColor(int nameID, UnityEngine.Color value);
        /*0x7e1cdf4*/ void SetMatrix(string name, UnityEngine.Matrix4x4 value);
        /*0x7e1ce40*/ void SetMatrix(int nameID, UnityEngine.Matrix4x4 value);
        /*0x7e1ce6c*/ void SetBuffer(string name, UnityEngine.ComputeBuffer value);
        /*0x7e1ce9c*/ void SetBuffer(int nameID, UnityEngine.ComputeBuffer value);
        /*0x7e1cea0*/ void SetTexture(string name, UnityEngine.Texture value);
        /*0x7e1ced0*/ void SetTexture(int nameID, UnityEngine.Texture value);
        /*0x7e1ced4*/ void SetTexture(int nameID, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x7e1ced8*/ void SetConstantBuffer(int nameID, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x7e1cedc*/ void SetFloatArray(string name, float[] values);
        /*0x7e1cf18*/ void SetVectorArray(string name, UnityEngine.Vector4[] values);
        /*0x7e1cf54*/ void SetVectorArray(int nameID, UnityEngine.Vector4[] values);
        /*0x7e1cf6c*/ void SetMatrixArray(string name, UnityEngine.Matrix4x4[] values);
        /*0x7e1cfa8*/ float GetFloat(string name);
        /*0x7e1cfc8*/ UnityEngine.Color GetColor(string name);

        class BindingsMarshaller
        {
            static /*0x7e1cfe8*/ nint ConvertToNative(UnityEngine.MaterialPropertyBlock materialPropertyBlock);
        }
    }

    class Renderer : UnityEngine.Component
    {
        static /*0x7e1d080*/ void set_localBounds_Injected(nint _unity_self, ref UnityEngine.Bounds value);
        static /*0x7e1d158*/ nint GetMaterial_Injected(nint _unity_self);
        static /*0x7e1d228*/ nint GetSharedMaterial_Injected(nint _unity_self);
        static /*0x7e1d318*/ void SetMaterial_Injected(nint _unity_self, nint m);
        static /*0x7e1d3dc*/ void CopyMaterialArray_Injected(nint _unity_self, UnityEngine.Material[] m);
        static /*0x7e1d4e0*/ void SetMaterialArray_Injected(nint _unity_self, UnityEngine.Material[] m, int length);
        static /*0x7e1d5e0*/ void Internal_SetPropertyBlock_Injected(nint _unity_self, nint properties);
        static /*0x7e1d6fc*/ void Internal_GetPropertyBlock_Injected(nint _unity_self, nint dest);
        static /*0x7e1d7d8*/ void Internal_SetPropertyBlockMaterialIndex_Injected(nint _unity_self, nint properties, int materialIndex);
        static /*0x7e1d914*/ void Internal_GetPropertyBlockMaterialIndex_Injected(nint _unity_self, nint dest, int materialIndex);
        static /*0x7e1d9e0*/ bool HasPropertyBlock_Injected(nint _unity_self);
        static /*0x7e1daa4*/ bool get_enabled_Injected(nint _unity_self);
        static /*0x7e1db60*/ void set_enabled_Injected(nint _unity_self, bool value);
        static /*0x7e1dc1c*/ bool get_isVisible_Injected(nint _unity_self);
        static /*0x7e1dcd0*/ UnityEngine.Rendering.ShadowCastingMode get_shadowCastingMode_Injected(nint _unity_self);
        static /*0x7e1dd8c*/ void set_shadowCastingMode_Injected(nint _unity_self, UnityEngine.Rendering.ShadowCastingMode value);
        static /*0x7e1de48*/ bool get_receiveShadows_Injected(nint _unity_self);
        static /*0x7e1df04*/ void set_receiveShadows_Injected(nint _unity_self, bool value);
        static /*0x7e1dfc0*/ UnityEngine.MotionVectorGenerationMode get_motionVectorGenerationMode_Injected(nint _unity_self);
        static /*0x7e1e07c*/ void set_motionVectorGenerationMode_Injected(nint _unity_self, UnityEngine.MotionVectorGenerationMode value);
        static /*0x7e1e138*/ UnityEngine.Rendering.LightProbeUsage get_lightProbeUsage_Injected(nint _unity_self);
        static /*0x7e1e1f4*/ void set_lightProbeUsage_Injected(nint _unity_self, UnityEngine.Rendering.LightProbeUsage value);
        static /*0x7e1e2b0*/ UnityEngine.Rendering.ReflectionProbeUsage get_reflectionProbeUsage_Injected(nint _unity_self);
        static /*0x7e1e36c*/ void set_reflectionProbeUsage_Injected(nint _unity_self, UnityEngine.Rendering.ReflectionProbeUsage value);
        static /*0x7e1e428*/ int get_sortingLayerID_Injected(nint _unity_self);
        static /*0x7e1e4e4*/ void set_sortingLayerID_Injected(nint _unity_self, int value);
        static /*0x7e1e5a0*/ int get_sortingOrder_Injected(nint _unity_self);
        static /*0x7e1e65c*/ void set_sortingOrder_Injected(nint _unity_self, int value);
        static /*0x7e1e718*/ int get_sortingGroupID_Injected(nint _unity_self);
        static /*0x7e1e7cc*/ int get_sortingGroupOrder_Injected(nint _unity_self);
        static /*0x7e1e89c*/ nint get_probeAnchor_Injected(nint _unity_self);
        static /*0x7e1e98c*/ void set_probeAnchor_Injected(nint _unity_self, nint value);
        static /*0x7e1ea48*/ int GetMaterialCount_Injected(nint _unity_self);
        static /*0x7e1eafc*/ UnityEngine.Material[] GetSharedMaterialArray_Injected(nint _unity_self);
        /*0x7e1ed48*/ Renderer();
        /*0x7e1d000*/ void set_localBounds(UnityEngine.Bounds value);
        /*0x7e1d0c4*/ UnityEngine.Material GetMaterial();
        /*0x7e1d194*/ UnityEngine.Material GetSharedMaterial();
        /*0x7e1d264*/ void SetMaterial(UnityEngine.Material m);
        /*0x7e1d35c*/ void CopyMaterialArray(UnityEngine.Material[] m);
        /*0x7e1d420*/ void SetMaterialArray(UnityEngine.Material[] m, int length);
        /*0x7e1d534*/ void SetMaterialArray(UnityEngine.Material[] m);
        /*0x7e1d558*/ void Internal_SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties);
        /*0x7e1d624*/ void Internal_GetPropertyBlock(UnityEngine.MaterialPropertyBlock dest);
        /*0x7e1d740*/ void Internal_SetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock properties, int materialIndex);
        /*0x7e1d82c*/ void Internal_GetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock dest, int materialIndex);
        /*0x7e1d968*/ bool HasPropertyBlock();
        /*0x7e1da1c*/ void SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties);
        /*0x7e1da20*/ void SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties, int materialIndex);
        /*0x7e1da24*/ void GetPropertyBlock(UnityEngine.MaterialPropertyBlock properties);
        /*0x7e1da28*/ void GetPropertyBlock(UnityEngine.MaterialPropertyBlock properties, int materialIndex);
        /*0x7e1da2c*/ bool get_enabled();
        /*0x7e1dae0*/ void set_enabled(bool value);
        /*0x7e1dba4*/ bool get_isVisible();
        /*0x7e1dc58*/ UnityEngine.Rendering.ShadowCastingMode get_shadowCastingMode();
        /*0x7e1dd0c*/ void set_shadowCastingMode(UnityEngine.Rendering.ShadowCastingMode value);
        /*0x7e1ddd0*/ bool get_receiveShadows();
        /*0x7e1de84*/ void set_receiveShadows(bool value);
        /*0x7e1df48*/ UnityEngine.MotionVectorGenerationMode get_motionVectorGenerationMode();
        /*0x7e1dffc*/ void set_motionVectorGenerationMode(UnityEngine.MotionVectorGenerationMode value);
        /*0x7e1e0c0*/ UnityEngine.Rendering.LightProbeUsage get_lightProbeUsage();
        /*0x7e1e174*/ void set_lightProbeUsage(UnityEngine.Rendering.LightProbeUsage value);
        /*0x7e1e238*/ UnityEngine.Rendering.ReflectionProbeUsage get_reflectionProbeUsage();
        /*0x7e1e2ec*/ void set_reflectionProbeUsage(UnityEngine.Rendering.ReflectionProbeUsage value);
        /*0x7e1e3b0*/ int get_sortingLayerID();
        /*0x7e1e464*/ void set_sortingLayerID(int value);
        /*0x7e1e528*/ int get_sortingOrder();
        /*0x7e1e5dc*/ void set_sortingOrder(int value);
        /*0x7e1e6a0*/ int get_sortingGroupID();
        /*0x7e1e754*/ int get_sortingGroupOrder();
        /*0x7e1e808*/ UnityEngine.Transform get_probeAnchor();
        /*0x7e1e8d8*/ void set_probeAnchor(UnityEngine.Transform value);
        /*0x7e1e9d0*/ int GetMaterialCount();
        /*0x7e1ea84*/ UnityEngine.Material[] GetSharedMaterialArray();
        /*0x7e1eb38*/ void set_materials(UnityEngine.Material[] value);
        /*0x7e1eb3c*/ UnityEngine.Material get_material();
        /*0x7e1eb40*/ void set_material(UnityEngine.Material value);
        /*0x7e1eb44*/ UnityEngine.Material get_sharedMaterial();
        /*0x7e1eb48*/ void set_sharedMaterial(UnityEngine.Material value);
        /*0x7e1eb4c*/ UnityEngine.Material[] get_sharedMaterials();
        /*0x7e1eb50*/ void set_sharedMaterials(UnityEngine.Material[] value);
        /*0x7e1eb54*/ void GetMaterials(System.Collections.Generic.List<UnityEngine.Material> m);
        /*0x7e1ec60*/ void SetMaterials(System.Collections.Generic.List<UnityEngine.Material> materials);
    }

    class RenderSettings : UnityEngine.Object
    {
        static /*0x7e1ed50*/ float get_ambientSkyboxAmount();
        static /*0x7e1eda0*/ void set_ambientSkyboxAmount(float value);
        static /*0x7e1ee68*/ bool get_fog();
        static /*0x7e1ee90*/ void set_fog(bool value);
        static /*0x7e1eecc*/ float get_fogStartDistance();
        static /*0x7e1eef4*/ void set_fogStartDistance(float value);
        static /*0x7e1ef2c*/ float get_fogEndDistance();
        static /*0x7e1ef54*/ void set_fogEndDistance(float value);
        static /*0x7e1ef8c*/ UnityEngine.FogMode get_fogMode();
        static /*0x7e1efb4*/ void set_fogMode(UnityEngine.FogMode value);
        static /*0x7e1eff0*/ UnityEngine.Color get_fogColor();
        static /*0x7e1f074*/ void set_fogColor(UnityEngine.Color value);
        static /*0x7e1f0f4*/ float get_fogDensity();
        static /*0x7e1f11c*/ void set_fogDensity(float value);
        static /*0x7e1f154*/ UnityEngine.Rendering.AmbientMode get_ambientMode();
        static /*0x7e1f17c*/ void set_ambientMode(UnityEngine.Rendering.AmbientMode value);
        static /*0x7e1f1b8*/ UnityEngine.Color get_ambientSkyColor();
        static /*0x7e1f23c*/ void set_ambientSkyColor(UnityEngine.Color value);
        static /*0x7e1f2bc*/ UnityEngine.Color get_ambientEquatorColor();
        static /*0x7e1f340*/ void set_ambientEquatorColor(UnityEngine.Color value);
        static /*0x7e1f3c0*/ UnityEngine.Color get_ambientGroundColor();
        static /*0x7e1f444*/ void set_ambientGroundColor(UnityEngine.Color value);
        static /*0x7e1ed78*/ float get_ambientIntensity();
        static /*0x7e1edd8*/ void set_ambientIntensity(float value);
        static /*0x7e1f4c4*/ UnityEngine.Color get_ambientLight();
        static /*0x7e1f548*/ void set_ambientLight(UnityEngine.Color value);
        static /*0x7e1f5c8*/ UnityEngine.Color get_subtractiveShadowColor();
        static /*0x7e1f64c*/ void set_subtractiveShadowColor(UnityEngine.Color value);
        static /*0x7e1f6cc*/ UnityEngine.Material get_skybox();
        static /*0x7e1f758*/ void set_skybox(UnityEngine.Material value);
        static /*0x7e1f818*/ UnityEngine.Light get_sun();
        static /*0x7e1f8a4*/ void set_sun(UnityEngine.Light value);
        static /*0x7e1f964*/ UnityEngine.Rendering.SphericalHarmonicsL2 get_ambientProbe();
        static /*0x7e1fa0c*/ void set_ambientProbe(UnityEngine.Rendering.SphericalHarmonicsL2 value);
        static /*0x7e1fa84*/ UnityEngine.Cubemap get_customReflection();
        static /*0x7e1fb7c*/ void set_customReflection(UnityEngine.Cubemap value);
        static /*0x7e1fb18*/ UnityEngine.Texture get_customReflectionTexture();
        static /*0x7e1fb80*/ void set_customReflectionTexture(UnityEngine.Texture value);
        static /*0x7e1fc68*/ float get_reflectionIntensity();
        static /*0x7e1fc90*/ void set_reflectionIntensity(float value);
        static /*0x7e1fcc8*/ int get_reflectionBounces();
        static /*0x7e1fcf0*/ void set_reflectionBounces(int value);
        static /*0x7e1fd2c*/ UnityEngine.Cubemap get_defaultReflection();
        static /*0x7e1fdb8*/ UnityEngine.Rendering.DefaultReflectionMode get_defaultReflectionMode();
        static /*0x7e1fde0*/ void set_defaultReflectionMode(UnityEngine.Rendering.DefaultReflectionMode value);
        static /*0x7e1fe1c*/ int get_defaultReflectionResolution();
        static /*0x7e1fe44*/ void set_defaultReflectionResolution(int value);
        static /*0x7e1fe80*/ float get_haloStrength();
        static /*0x7e1fea8*/ void set_haloStrength(float value);
        static /*0x7e1fee0*/ float get_flareStrength();
        static /*0x7e1ff08*/ void set_flareStrength(float value);
        static /*0x7e1ff40*/ float get_flareFadeSpeed();
        static /*0x7e1ff68*/ void set_flareFadeSpeed(float value);
        static /*0x7e1ffa0*/ UnityEngine.Object GetRenderSettings();
        static /*0x7e2002c*/ void Reset();
        static /*0x7e1f038*/ void get_fogColor_Injected(ref UnityEngine.Color ret);
        static /*0x7e1f0b8*/ void set_fogColor_Injected(ref UnityEngine.Color value);
        static /*0x7e1f200*/ void get_ambientSkyColor_Injected(ref UnityEngine.Color ret);
        static /*0x7e1f280*/ void set_ambientSkyColor_Injected(ref UnityEngine.Color value);
        static /*0x7e1f304*/ void get_ambientEquatorColor_Injected(ref UnityEngine.Color ret);
        static /*0x7e1f384*/ void set_ambientEquatorColor_Injected(ref UnityEngine.Color value);
        static /*0x7e1f408*/ void get_ambientGroundColor_Injected(ref UnityEngine.Color ret);
        static /*0x7e1f488*/ void set_ambientGroundColor_Injected(ref UnityEngine.Color value);
        static /*0x7e1f50c*/ void get_ambientLight_Injected(ref UnityEngine.Color ret);
        static /*0x7e1f58c*/ void set_ambientLight_Injected(ref UnityEngine.Color value);
        static /*0x7e1f610*/ void get_subtractiveShadowColor_Injected(ref UnityEngine.Color ret);
        static /*0x7e1f690*/ void set_subtractiveShadowColor_Injected(ref UnityEngine.Color value);
        static /*0x7e1f730*/ nint get_skybox_Injected();
        static /*0x7e1f7dc*/ void set_skybox_Injected(nint value);
        static /*0x7e1f87c*/ nint get_sun_Injected();
        static /*0x7e1f928*/ void set_sun_Injected(nint value);
        static /*0x7e1f9d0*/ void get_ambientProbe_Injected(ref UnityEngine.Rendering.SphericalHarmonicsL2 ret);
        static /*0x7e1fa48*/ void set_ambientProbe_Injected(ref UnityEngine.Rendering.SphericalHarmonicsL2 value);
        static /*0x7e1fc04*/ nint get_customReflectionTexture_Injected();
        static /*0x7e1fc2c*/ void set_customReflectionTexture_Injected(nint value);
        static /*0x7e1fd90*/ nint get_defaultReflection_Injected();
        static /*0x7e20004*/ nint GetRenderSettings_Injected();
        /*0x7e1ee10*/ RenderSettings();
    }

    class Shader : UnityEngine.Object
    {
        static /*0x7e20054*/ UnityEngine.Rendering.ShaderHardwareTier get_globalShaderHardwareTier();
        static /*0x7e200bc*/ void set_globalShaderHardwareTier(UnityEngine.Rendering.ShaderHardwareTier value);
        static /*0x7e20130*/ UnityEngine.Shader Find(string name);
        static /*0x7e2019c*/ UnityEngine.Shader FindBuiltin(string name);
        static /*0x7e2039c*/ int get_maximumChunksOverride();
        static /*0x7e203c4*/ void set_maximumChunksOverride(int value);
        static /*0x7e20578*/ int get_globalMaximumLOD();
        static /*0x7e205a0*/ void set_globalMaximumLOD(int value);
        static /*0x7e20690*/ string get_globalRenderPipeline();
        static /*0x7e20780*/ void set_globalRenderPipeline(string value);
        static /*0x7e20924*/ UnityEngine.Rendering.GlobalKeyword[] get_enabledGlobalKeywords();
        static /*0x7e20974*/ UnityEngine.Rendering.GlobalKeyword[] get_globalKeywords();
        static /*0x7e2094c*/ UnityEngine.Rendering.GlobalKeyword[] GetEnabledGlobalKeywords();
        static /*0x7e2099c*/ UnityEngine.Rendering.GlobalKeyword[] GetAllGlobalKeywords();
        static /*0x7e20a90*/ void EnableKeyword(string keyword);
        static /*0x7e20c34*/ void DisableKeyword(string keyword);
        static /*0x7e20dd8*/ bool IsKeywordEnabled(string keyword);
        static /*0x7e20f88*/ void EnableKeywordFast(UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e21004*/ void DisableKeywordFast(UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e21080*/ void SetKeywordFast(UnityEngine.Rendering.GlobalKeyword keyword, bool value);
        static /*0x7e21114*/ bool IsKeywordEnabledFast(UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e21194*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e211a0*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e211ac*/ void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
        static /*0x7e211c0*/ bool IsKeywordEnabled(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e21334*/ void WarmupAllShaders();
        static /*0x7e2135c*/ int TagToID(string name);
        static /*0x7e21508*/ string IDToTag(int name);
        static /*0x7e1cb9c*/ int PropertyToID(string name);
        static /*0x7e2201c*/ void SetGlobalIntImpl(int name, int value);
        static /*0x7e22060*/ void SetGlobalFloatImpl(int name, float value);
        static /*0x7e220ac*/ void SetGlobalVectorImpl(int name, UnityEngine.Vector4 value);
        static /*0x7e22144*/ void SetGlobalMatrixImpl(int name, UnityEngine.Matrix4x4 value);
        static /*0x7e221cc*/ void SetGlobalTextureImpl(int name, UnityEngine.Texture value);
        static /*0x7e222a4*/ void SetGlobalRenderTextureImpl(int name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x7e22394*/ void SetGlobalBufferImpl(int name, UnityEngine.ComputeBuffer value);
        static /*0x7e22428*/ void SetGlobalGraphicsBufferImpl(int name, UnityEngine.GraphicsBuffer value);
        static /*0x7e224bc*/ void SetGlobalConstantBufferImpl(int name, UnityEngine.ComputeBuffer value, int offset, int size);
        static /*0x7e22580*/ void SetGlobalConstantGraphicsBufferImpl(int name, UnityEngine.GraphicsBuffer value, int offset, int size);
        static /*0x7e22644*/ void SetGlobalRayTracingAccelerationStructureImpl(int name, UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
        static /*0x7e226d8*/ int GetGlobalIntImpl(int name);
        static /*0x7e22714*/ float GetGlobalFloatImpl(int name);
        static /*0x7e22750*/ UnityEngine.Vector4 GetGlobalVectorImpl(int name);
        static /*0x7e227ec*/ UnityEngine.Matrix4x4 GetGlobalMatrixImpl(int name);
        static /*0x7e2289c*/ UnityEngine.Texture GetGlobalTextureImpl(int name);
        static /*0x7e22944*/ void SetGlobalFloatArrayImpl(int name, float[] values, int count);
        static /*0x7e22a7c*/ void SetGlobalVectorArrayImpl(int name, UnityEngine.Vector4[] values, int count);
        static /*0x7e22bb4*/ void SetGlobalMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] values, int count);
        static /*0x7e22cec*/ float[] GetGlobalFloatArrayImpl(int name);
        static /*0x7e22e2c*/ UnityEngine.Vector4[] GetGlobalVectorArrayImpl(int name);
        static /*0x7e22f6c*/ UnityEngine.Matrix4x4[] GetGlobalMatrixArrayImpl(int name);
        static /*0x7e230ac*/ int GetGlobalFloatArrayCountImpl(int name);
        static /*0x7e230e8*/ int GetGlobalVectorArrayCountImpl(int name);
        static /*0x7e23124*/ int GetGlobalMatrixArrayCountImpl(int name);
        static /*0x7e23160*/ void ExtractGlobalFloatArrayImpl(int name, float[] val);
        static /*0x7e232c8*/ void ExtractGlobalVectorArrayImpl(int name, UnityEngine.Vector4[] val);
        static /*0x7e23430*/ void ExtractGlobalMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] val);
        static /*0x7e23598*/ void SetGlobalFloatArray(int name, float[] values, int count);
        static /*0x7e23654*/ void SetGlobalVectorArray(int name, UnityEngine.Vector4[] values, int count);
        static /*0x7e23710*/ void SetGlobalMatrixArray(int name, UnityEngine.Matrix4x4[] values, int count);
        static /*0x7e237cc*/ void ExtractGlobalFloatArray(int name, System.Collections.Generic.List<float> values);
        static /*0x7e23908*/ void ExtractGlobalVectorArray(int name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        static /*0x7e23a44*/ void ExtractGlobalMatrixArray(int name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        static /*0x7e23b80*/ void SetGlobalInt(string name, int value);
        static /*0x7e23bc8*/ void SetGlobalInt(int nameID, int value);
        static /*0x7e23c0c*/ void SetGlobalFloat(string name, float value);
        static /*0x7e23c5c*/ void SetGlobalFloat(int nameID, float value);
        static /*0x7e23ca8*/ void SetGlobalInteger(string name, int value);
        static /*0x7e23cf0*/ void SetGlobalInteger(int nameID, int value);
        static /*0x7e23d34*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
        static /*0x7e23d74*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
        static /*0x7e23d78*/ void SetGlobalColor(string name, UnityEngine.Color value);
        static /*0x7e23db8*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
        static /*0x7e23dbc*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
        static /*0x7e23e20*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
        static /*0x7e23e7c*/ void SetGlobalTexture(string name, UnityEngine.Texture value);
        static /*0x7e23e94*/ void SetGlobalTexture(int nameID, UnityEngine.Texture value);
        static /*0x7e23e98*/ void SetGlobalTexture(string name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x7e23ec0*/ void SetGlobalTexture(int nameID, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x7e23ec4*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
        static /*0x7e23f14*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
        static /*0x7e23f64*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
        static /*0x7e23fb4*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
        static /*0x7e24004*/ void SetGlobalConstantBuffer(string name, UnityEngine.ComputeBuffer value, int offset, int size);
        static /*0x7e2406c*/ void SetGlobalConstantBuffer(int nameID, UnityEngine.ComputeBuffer value, int offset, int size);
        static /*0x7e240d4*/ void SetGlobalConstantBuffer(string name, UnityEngine.GraphicsBuffer value, int offset, int size);
        static /*0x7e2413c*/ void SetGlobalConstantBuffer(int nameID, UnityEngine.GraphicsBuffer value, int offset, int size);
        static /*0x7e241a4*/ void SetGlobalRayTracingAccelerationStructure(string name, UnityEngine.Rendering.RayTracingAccelerationStructure value);
        static /*0x7e241f4*/ void SetGlobalRayTracingAccelerationStructure(int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure value);
        static /*0x7e24244*/ void SetGlobalFloatArray(string name, System.Collections.Generic.List<float> values);
        static /*0x7e242e4*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
        static /*0x7e24378*/ void SetGlobalFloatArray(string name, float[] values);
        static /*0x7e2439c*/ void SetGlobalFloatArray(int nameID, float[] values);
        static /*0x7e243b4*/ void SetGlobalVectorArray(string name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        static /*0x7e24454*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
        static /*0x7e244e8*/ void SetGlobalVectorArray(string name, UnityEngine.Vector4[] values);
        static /*0x7e2450c*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
        static /*0x7e24524*/ void SetGlobalMatrixArray(string name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        static /*0x7e245c4*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        static /*0x7e24658*/ void SetGlobalMatrixArray(string name, UnityEngine.Matrix4x4[] values);
        static /*0x7e2467c*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
        static /*0x7e24694*/ int GetGlobalInt(string name);
        static /*0x7e246f0*/ int GetGlobalInt(int nameID);
        static /*0x7e24748*/ float GetGlobalFloat(string name);
        static /*0x7e24788*/ float GetGlobalFloat(int nameID);
        static /*0x7e247c4*/ int GetGlobalInteger(string name);
        static /*0x7e24804*/ int GetGlobalInteger(int nameID);
        static /*0x7e24840*/ UnityEngine.Vector4 GetGlobalVector(string name);
        static /*0x7e24850*/ UnityEngine.Vector4 GetGlobalVector(int nameID);
        static /*0x7e24854*/ UnityEngine.Color GetGlobalColor(string name);
        static /*0x7e24864*/ UnityEngine.Color GetGlobalColor(int nameID);
        static /*0x7e24868*/ UnityEngine.Matrix4x4 GetGlobalMatrix(string name);
        static /*0x7e248ec*/ UnityEngine.Matrix4x4 GetGlobalMatrix(int nameID);
        static /*0x7e24968*/ UnityEngine.Texture GetGlobalTexture(string name);
        static /*0x7e24978*/ UnityEngine.Texture GetGlobalTexture(int nameID);
        static /*0x7e2497c*/ float[] GetGlobalFloatArray(string name);
        static /*0x7e2498c*/ float[] GetGlobalFloatArray(int nameID);
        static /*0x7e249e4*/ UnityEngine.Vector4[] GetGlobalVectorArray(string name);
        static /*0x7e249f4*/ UnityEngine.Vector4[] GetGlobalVectorArray(int nameID);
        static /*0x7e24a4c*/ UnityEngine.Matrix4x4[] GetGlobalMatrixArray(string name);
        static /*0x7e24a5c*/ UnityEngine.Matrix4x4[] GetGlobalMatrixArray(int nameID);
        static /*0x7e24ab4*/ void GetGlobalFloatArray(string name, System.Collections.Generic.List<float> values);
        static /*0x7e24acc*/ void GetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
        static /*0x7e24ad0*/ void GetGlobalVectorArray(string name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        static /*0x7e24ae8*/ void GetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
        static /*0x7e24aec*/ void GetGlobalMatrixArray(string name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        static /*0x7e24b04*/ void GetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        static /*0x7e24b60*/ string GetPropertyName(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e24cec*/ int GetPropertyNameId(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e24de0*/ UnityEngine.Rendering.ShaderPropertyType GetPropertyType(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e24ed4*/ string GetPropertyDescription(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e25060*/ UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e25154*/ string[] GetPropertyAttributes(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e25248*/ int GetPropertyDefaultIntValue(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e2533c*/ UnityEngine.Vector4 GetPropertyDefaultValue(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e2545c*/ UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e25550*/ string GetPropertyTextureDefaultName(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e256dc*/ bool FindTextureStackImpl(UnityEngine.Shader s, int propertyIdx, ref string stackName, ref int layerIndex);
        static /*0x7e258b0*/ void CheckPropertyIndex(UnityEngine.Shader s, int propertyIndex);
        static /*0x7e20360*/ nint FindBuiltin_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e20478*/ int get_maximumLOD_Injected(nint _unity_self);
        static /*0x7e20534*/ void set_maximumLOD_Injected(nint _unity_self, int value);
        static /*0x7e20654*/ bool get_isSupported_Injected(nint _unity_self);
        static /*0x7e20744*/ void get_globalRenderPipeline_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e208e8*/ void set_globalRenderPipeline_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7e20a4c*/ void get_keywordSpace_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeywordSpace ret);
        static /*0x7e20bf8*/ void EnableKeyword_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e20d9c*/ void DisableKeyword_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e20f4c*/ bool IsKeywordEnabled_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e20fc8*/ void EnableKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e21044*/ void DisableKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e210d0*/ void SetKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
        static /*0x7e21158*/ bool IsKeywordEnabledFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e21244*/ int get_renderQueue_Injected(nint _unity_self);
        static /*0x7e212f8*/ UnityEngine.DisableBatchingType get_disableBatching_Injected(nint _unity_self);
        static /*0x7e214cc*/ int TagToID_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e215c4*/ void IDToTag_Injected(int name, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e21608*/ int PropertyToID_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e21838*/ nint GetDependency_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e218f4*/ int get_passCount_Injected(nint _unity_self);
        static /*0x7e219a8*/ int get_subshaderCount_Injected(nint _unity_self);
        static /*0x7e21a64*/ int GetPassCountInSubshader_Injected(nint _unity_self, int subshaderIndex);
        static /*0x7e21f18*/ int Internal_FindPassTagValue_Injected(nint _unity_self, int passIndex, int tagName);
        static /*0x7e21f6c*/ int Internal_FindPassTagValueInSubShader_Injected(nint _unity_self, int subShaderIndex, int passIndex, int tagName);
        static /*0x7e21fc8*/ int Internal_FindSubshaderTagValue_Injected(nint _unity_self, int subShaderIndex, int tagName);
        static /*0x7e22100*/ void SetGlobalVectorImpl_Injected(int name, ref UnityEngine.Vector4 value);
        static /*0x7e22188*/ void SetGlobalMatrixImpl_Injected(int name, ref UnityEngine.Matrix4x4 value);
        static /*0x7e22260*/ void SetGlobalTextureImpl_Injected(int name, nint value);
        static /*0x7e22340*/ void SetGlobalRenderTextureImpl_Injected(int name, nint value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x7e223e4*/ void SetGlobalBufferImpl_Injected(int name, nint value);
        static /*0x7e22478*/ void SetGlobalGraphicsBufferImpl_Injected(int name, nint value);
        static /*0x7e22524*/ void SetGlobalConstantBufferImpl_Injected(int name, nint value, int offset, int size);
        static /*0x7e225e8*/ void SetGlobalConstantGraphicsBufferImpl_Injected(int name, nint value, int offset, int size);
        static /*0x7e22694*/ void SetGlobalRayTracingAccelerationStructureImpl_Injected(int name, nint accelerationStructure);
        static /*0x7e227a8*/ void GetGlobalVectorImpl_Injected(int name, ref UnityEngine.Vector4 ret);
        static /*0x7e22858*/ void GetGlobalMatrixImpl_Injected(int name, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e22908*/ nint GetGlobalTextureImpl_Injected(int name);
        static /*0x7e22a28*/ void SetGlobalFloatArrayImpl_Injected(int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e22b60*/ void SetGlobalVectorArrayImpl_Injected(int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e22c98*/ void SetGlobalMatrixArrayImpl_Injected(int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e22de8*/ void GetGlobalFloatArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e22f28*/ void GetGlobalVectorArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e23068*/ void GetGlobalMatrixArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e23284*/ void ExtractGlobalFloatArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x7e233ec*/ void ExtractGlobalVectorArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x7e23554*/ void ExtractGlobalMatrixArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x7e24c98*/ void GetPropertyName_Injected(nint shader, int propertyIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e24d9c*/ int GetPropertyNameId_Injected(nint shader, int propertyIndex);
        static /*0x7e24e90*/ UnityEngine.Rendering.ShaderPropertyType GetPropertyType_Injected(nint shader, int propertyIndex);
        static /*0x7e2500c*/ void GetPropertyDescription_Injected(nint shader, int propertyIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e25110*/ UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags_Injected(nint shader, int propertyIndex);
        static /*0x7e25204*/ string[] GetPropertyAttributes_Injected(nint shader, int propertyIndex);
        static /*0x7e252f8*/ int GetPropertyDefaultIntValue_Injected(nint shader, int propertyIndex);
        static /*0x7e25408*/ void GetPropertyDefaultValue_Injected(nint shader, int propertyIndex, ref UnityEngine.Vector4 ret);
        static /*0x7e2550c*/ UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension_Injected(nint shader, int propertyIndex);
        static /*0x7e25688*/ void GetPropertyTextureDefaultName_Injected(nint shader, int propertyIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e25854*/ bool FindTextureStackImpl_Injected(nint s, int propertyIdx, ref UnityEngine.Bindings.ManagedSpanWrapper stackName, ref int layerIndex);
        static /*0x7e25998*/ int GetPropertyCount_Injected(nint _unity_self);
        static /*0x7e25b7c*/ int FindPropertyIndex_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper propertyName);
        /*0x7e24b08*/ Shader();
        /*0x7e20400*/ int get_maximumLOD();
        /*0x7e204b4*/ void set_maximumLOD(int value);
        /*0x7e205dc*/ bool get_isSupported();
        /*0x7e209c4*/ UnityEngine.Rendering.LocalKeywordSpace get_keywordSpace();
        /*0x7e211cc*/ int get_renderQueue();
        /*0x7e21280*/ UnityEngine.DisableBatchingType get_disableBatching();
        /*0x7e21644*/ UnityEngine.Shader GetDependency(string name);
        /*0x7e2187c*/ int get_passCount();
        /*0x7e21930*/ int get_subshaderCount();
        /*0x7e219e4*/ int GetPassCountInSubshader(int subshaderIndex);
        /*0x7e21aa8*/ UnityEngine.Rendering.ShaderTagId FindPassTagValue(int passIndex, UnityEngine.Rendering.ShaderTagId tagName);
        /*0x7e21bf0*/ UnityEngine.Rendering.ShaderTagId FindPassTagValue(int subshaderIndex, int passIndex, UnityEngine.Rendering.ShaderTagId tagName);
        /*0x7e21d80*/ UnityEngine.Rendering.ShaderTagId FindSubshaderTagValue(int subshaderIndex, UnityEngine.Rendering.ShaderTagId tagName);
        /*0x7e21b60*/ int Internal_FindPassTagValue(int passIndex, int tagName);
        /*0x7e21ce8*/ int Internal_FindPassTagValueInSubShader(int subShaderIndex, int passIndex, int tagName);
        /*0x7e21e88*/ int Internal_FindSubshaderTagValue(int subShaderIndex, int tagName);
        /*0x7e25920*/ int GetPropertyCount();
        /*0x7e259d4*/ int FindPropertyIndex(string propertyName);
        /*0x7e25bc0*/ string GetPropertyName(int propertyIndex);
        /*0x7e25be8*/ int GetPropertyNameId(int propertyIndex);
        /*0x7e25c10*/ UnityEngine.Rendering.ShaderPropertyType GetPropertyType(int propertyIndex);
        /*0x7e25c38*/ string GetPropertyDescription(int propertyIndex);
        /*0x7e25c60*/ UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(int propertyIndex);
        /*0x7e25c88*/ string[] GetPropertyAttributes(int propertyIndex);
        /*0x7e25cb0*/ float GetPropertyDefaultFloatValue(int propertyIndex);
        /*0x7e25d44*/ UnityEngine.Vector4 GetPropertyDefaultVectorValue(int propertyIndex);
        /*0x7e25dd4*/ UnityEngine.Vector2 GetPropertyRangeLimits(int propertyIndex);
        /*0x7e25e70*/ int GetPropertyDefaultIntValue(int propertyIndex);
        /*0x7e25f00*/ UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(int propertyIndex);
        /*0x7e25f90*/ string GetPropertyTextureDefaultName(int propertyIndex);
        /*0x7e26020*/ bool FindTextureStack(int propertyIndex, ref string stackName, ref int layerIndex);
    }

    class Material : UnityEngine.Object
    {
        static /*0x0*/ int k_ColorId;
        static /*0x4*/ int k_MainTexId;

        static /*0x7e2ec1c*/ Material();
        static /*0x7e260c8*/ UnityEngine.Material Create(string scriptContents);
        static /*0x7e261bc*/ void CreateWithShader(UnityEngine.Material self, UnityEngine.Shader shader);
        static /*0x7e262dc*/ void CreateWithMaterial(UnityEngine.Material self, UnityEngine.Material source);
        static /*0x7e263fc*/ void CreateWithString(UnityEngine.Material self);
        static /*0x7e26560*/ UnityEngine.Material GetDefaultMaterial();
        static /*0x7e26610*/ UnityEngine.Material GetDefaultParticleMaterial();
        static /*0x7e266c0*/ UnityEngine.Material GetDefaultLineMaterial();
        static /*0x7e26298*/ void CreateWithShader_Injected(UnityEngine.Material self, nint shader);
        static /*0x7e263b8*/ void CreateWithMaterial_Injected(UnityEngine.Material self, nint source);
        static /*0x7e265e8*/ nint GetDefaultMaterial_Injected();
        static /*0x7e26698*/ nint GetDefaultParticleMaterial_Injected();
        static /*0x7e26748*/ nint GetDefaultLineMaterial_Injected();
        static /*0x7e26828*/ nint get_shader_Injected(nint _unity_self);
        static /*0x7e2693c*/ void set_shader_Injected(nint _unity_self, nint value);
        static /*0x7e26e74*/ int GetFirstPropertyNameIdByAttribute_Injected(nint _unity_self, UnityEngine.Rendering.ShaderPropertyFlags attributeFlag);
        static /*0x7e26f64*/ bool HasProperty_Injected(nint _unity_self, int nameID);
        static /*0x7e27074*/ bool HasFloatImpl_Injected(nint _unity_self, int name);
        static /*0x7e271ac*/ bool HasIntImpl_Injected(nint _unity_self, int name);
        static /*0x7e272c0*/ bool HasTextureImpl_Injected(nint _unity_self, int name);
        static /*0x7e273d4*/ bool HasMatrixImpl_Injected(nint _unity_self, int name);
        static /*0x7e274e8*/ bool HasVectorImpl_Injected(nint _unity_self, int name);
        static /*0x7e27620*/ bool HasBufferImpl_Injected(nint _unity_self, int name);
        static /*0x7e27734*/ bool HasConstantBufferImpl_Injected(nint _unity_self, int name);
        static /*0x7e27838*/ int get_renderQueue_Injected(nint _unity_self);
        static /*0x7e27920*/ void set_renderQueue_Injected(nint _unity_self, int value);
        static /*0x7e27a00*/ int get_rawRenderQueue_Injected(nint _unity_self);
        static /*0x7e27bfc*/ void EnableKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e27e00*/ void DisableKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e28014*/ bool IsKeywordEnabled_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e28104*/ void EnableLocalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeyword keyword);
        static /*0x7e281f4*/ void DisableLocalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeyword keyword);
        static /*0x7e282ec*/ void SetLocalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
        static /*0x7e283ec*/ bool IsLocalKeywordEnabled_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeyword keyword);
        static /*0x7e28584*/ UnityEngine.Rendering.LocalKeyword[] GetEnabledKeywords_Injected(nint _unity_self);
        static /*0x7e2866c*/ void SetEnabledKeywords_Injected(nint _unity_self, UnityEngine.Rendering.LocalKeyword[] keywords);
        static /*0x7e28754*/ UnityEngine.MaterialGlobalIlluminationFlags get_globalIlluminationFlags_Injected(nint _unity_self);
        static /*0x7e2883c*/ void set_globalIlluminationFlags_Injected(nint _unity_self, UnityEngine.MaterialGlobalIlluminationFlags value);
        static /*0x7e2891c*/ bool get_doubleSidedGI_Injected(nint _unity_self);
        static /*0x7e28a04*/ void set_doubleSidedGI_Injected(nint _unity_self, bool value);
        static /*0x7e28a48*/ bool get_enableInstancing_Injected(nint _unity_self);
        static /*0x7e28b30*/ void set_enableInstancing_Injected(nint _unity_self, bool value);
        static /*0x7e28c10*/ int get_passCount_Injected(nint _unity_self);
        static /*0x7e28e20*/ void SetShaderPassEnabled_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper passName, bool enabled);
        static /*0x7e29044*/ bool GetShaderPassEnabled_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper passName);
        static /*0x7e291b4*/ void GetPassName_Injected(nint _unity_self, int pass, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e293d4*/ int FindPass_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper passName);
        static /*0x7e296a8*/ void SetOverrideTag_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper tag, ref UnityEngine.Bindings.ManagedSpanWrapper val);
        static /*0x7e299d4*/ void GetTagImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper tag, bool currentSubShaderOnly, ref UnityEngine.Bindings.ManagedSpanWrapper defaultValue, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e29bb8*/ void Lerp_Injected(nint _unity_self, nint start, nint end, float t);
        static /*0x7e29cc8*/ bool SetPass_Injected(nint _unity_self, int pass);
        static /*0x7e29de4*/ void CopyPropertiesFromMaterial_Injected(nint _unity_self, nint mat);
        static /*0x7e29f00*/ void CopyMatchingPropertiesFromMaterial_Injected(nint _unity_self, nint mat);
        static /*0x7e29fe0*/ string[] GetShaderKeywords_Injected(nint _unity_self);
        static /*0x7e2a0c8*/ void SetShaderKeywords_Injected(nint _unity_self, string[] names);
        static /*0x7e2a1c0*/ string[] GetPropertyNamesImpl_Injected(nint _unity_self, int propertyType);
        static /*0x7e2a2a0*/ int ComputeCRC_Injected(nint _unity_self);
        static /*0x7e2a378*/ string[] GetTexturePropertyNames_Injected(nint _unity_self);
        static /*0x7e2a500*/ void GetTexturePropertyNameIDs_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e2a5f0*/ void GetTexturePropertyNamesInternal_Injected(nint _unity_self, object outNames);
        static /*0x7e2a6e0*/ void GetTexturePropertyNameIDsInternal_Injected(nint _unity_self, object outNames);
        static /*0x7e2a880*/ void SetIntImpl_Injected(nint _unity_self, int name, int value);
        static /*0x7e2a990*/ void SetFloatImpl_Injected(nint _unity_self, int name, float value);
        static /*0x7e2aaa8*/ void SetColorImpl_Injected(nint _unity_self, int name, ref UnityEngine.Color value);
        static /*0x7e2abb0*/ void SetMatrixImpl_Injected(nint _unity_self, int name, ref UnityEngine.Matrix4x4 value);
        static /*0x7e2ace4*/ void SetTextureImpl_Injected(nint _unity_self, int name, nint value);
        static /*0x7e2ae28*/ void SetRenderTextureImpl_Injected(nint _unity_self, int name, nint value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x7e2af40*/ void SetBufferImpl_Injected(nint _unity_self, int name, nint value);
        static /*0x7e2b050*/ void SetGraphicsBufferImpl_Injected(nint _unity_self, int name, nint value);
        static /*0x7e2b178*/ void SetConstantBufferImpl_Injected(nint _unity_self, int name, nint value, int offset, int size);
        static /*0x7e2b2b8*/ void SetConstantGraphicsBufferImpl_Injected(nint _unity_self, int name, nint value, int offset, int size);
        static /*0x7e2b3d0*/ int GetIntImpl_Injected(nint _unity_self, int name);
        static /*0x7e2b4c0*/ float GetFloatImpl_Injected(nint _unity_self, int name);
        static /*0x7e2b5cc*/ void GetColorImpl_Injected(nint _unity_self, int name, ref UnityEngine.Color ret);
        static /*0x7e2b6fc*/ void GetMatrixImpl_Injected(nint _unity_self, int name, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e2b818*/ nint GetTextureImpl_Injected(nint _unity_self, int name);
        static /*0x7e2b918*/ void GetBufferImpl_Injected(nint _unity_self, int name, ref UnityEngine.GraphicsBufferHandle ret);
        static /*0x7e2ba28*/ void GetConstantBufferImpl_Injected(nint _unity_self, int name, ref UnityEngine.GraphicsBufferHandle ret);
        static /*0x7e2bbb4*/ void SetFloatArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e2bd48*/ void SetVectorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e2bedc*/ void SetColorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e2c070*/ void SetMatrixArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e2c228*/ void GetFloatArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e2c3d8*/ void GetVectorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e2c588*/ void GetColorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e2c738*/ void GetMatrixArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e2c838*/ int GetFloatArrayCountImpl_Injected(nint _unity_self, int name);
        static /*0x7e2c928*/ int GetVectorArrayCountImpl_Injected(nint _unity_self, int name);
        static /*0x7e2ca18*/ int GetColorArrayCountImpl_Injected(nint _unity_self, int name);
        static /*0x7e2cb08*/ int GetMatrixArrayCountImpl_Injected(nint _unity_self, int name);
        static /*0x7e2ccd0*/ void ExtractFloatArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x7e2cea8*/ void ExtractVectorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x7e2d080*/ void ExtractColorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x7e2d258*/ void ExtractMatrixArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x7e2d374*/ void GetTextureScaleAndOffsetImpl_Injected(nint _unity_self, int name, ref UnityEngine.Vector4 ret);
        static /*0x7e2d480*/ void SetTextureOffsetImpl_Injected(nint _unity_self, int name, ref UnityEngine.Vector2 offset);
        static /*0x7e2d58c*/ void SetTextureScaleImpl_Injected(nint _unity_self, int name, ref UnityEngine.Vector2 scale);
        /*0x7e26438*/ Material(UnityEngine.Shader shader);
        /*0x7e264cc*/ Material(UnityEngine.Material source);
        /*0x7e26118*/ Material(string contents);
        /*0x7e26770*/ UnityEngine.Shader get_shader();
        /*0x7e26864*/ void set_shader(UnityEngine.Shader value);
        /*0x7e26980*/ UnityEngine.Color get_color();
        /*0x7e26aa4*/ void set_color(UnityEngine.Color value);
        /*0x7e26b4c*/ UnityEngine.Texture get_mainTexture();
        /*0x7e26bc4*/ void set_mainTexture(UnityEngine.Texture value);
        /*0x7e26c44*/ UnityEngine.Vector2 get_mainTextureOffset();
        /*0x7e26cdc*/ void set_mainTextureOffset(UnityEngine.Vector2 value);
        /*0x7e26d6c*/ UnityEngine.Vector2 get_mainTextureScale();
        /*0x7e26de4*/ void set_mainTextureScale(UnityEngine.Vector2 value);
        /*0x7e269f4*/ int GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags attributeFlag);
        /*0x7e26eb8*/ bool HasProperty(int nameID);
        /*0x7e26fa8*/ bool HasProperty(string name);
        /*0x7e26fc8*/ bool HasFloatImpl(int name);
        /*0x7e270b8*/ bool HasFloat(string name);
        /*0x7e270d8*/ bool HasFloat(int nameID);
        /*0x7e270dc*/ bool HasInt(string name);
        /*0x7e270fc*/ bool HasInt(int nameID);
        /*0x7e27100*/ bool HasIntImpl(int name);
        /*0x7e271f0*/ bool HasInteger(string name);
        /*0x7e27210*/ bool HasInteger(int nameID);
        /*0x7e27214*/ bool HasTextureImpl(int name);
        /*0x7e27304*/ bool HasTexture(string name);
        /*0x7e27324*/ bool HasTexture(int nameID);
        /*0x7e27328*/ bool HasMatrixImpl(int name);
        /*0x7e27418*/ bool HasMatrix(string name);
        /*0x7e27438*/ bool HasMatrix(int nameID);
        /*0x7e2743c*/ bool HasVectorImpl(int name);
        /*0x7e2752c*/ bool HasVector(string name);
        /*0x7e2754c*/ bool HasVector(int nameID);
        /*0x7e27550*/ bool HasColor(string name);
        /*0x7e27570*/ bool HasColor(int nameID);
        /*0x7e27574*/ bool HasBufferImpl(int name);
        /*0x7e27664*/ bool HasBuffer(string name);
        /*0x7e27684*/ bool HasBuffer(int nameID);
        /*0x7e27688*/ bool HasConstantBufferImpl(int name);
        /*0x7e27778*/ bool HasConstantBuffer(string name);
        /*0x7e27798*/ bool HasConstantBuffer(int nameID);
        /*0x7e2779c*/ int get_renderQueue();
        /*0x7e27874*/ void set_renderQueue(int value);
        /*0x7e27964*/ int get_rawRenderQueue();
        /*0x7e27a3c*/ void EnableKeyword(string keyword);
        /*0x7e27c40*/ void DisableKeyword(string keyword);
        /*0x7e27e44*/ bool IsKeywordEnabled(string keyword);
        /*0x7e28058*/ void EnableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword);
        /*0x7e28148*/ void DisableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword);
        /*0x7e28238*/ void SetLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword, bool value);
        /*0x7e28340*/ bool IsLocalKeywordEnabled(UnityEngine.Rendering.LocalKeyword keyword);
        /*0x7e28430*/ void EnableKeyword(ref UnityEngine.Rendering.LocalKeyword keyword);
        /*0x7e2845c*/ void DisableKeyword(ref UnityEngine.Rendering.LocalKeyword keyword);
        /*0x7e28488*/ void SetKeyword(ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
        /*0x7e284b8*/ bool IsKeywordEnabled(ref UnityEngine.Rendering.LocalKeyword keyword);
        /*0x7e284e8*/ UnityEngine.Rendering.LocalKeyword[] GetEnabledKeywords();
        /*0x7e285c0*/ void SetEnabledKeywords(UnityEngine.Rendering.LocalKeyword[] keywords);
        /*0x7e286b0*/ UnityEngine.Rendering.LocalKeyword[] get_enabledKeywords();
        /*0x7e286b4*/ void set_enabledKeywords(UnityEngine.Rendering.LocalKeyword[] value);
        /*0x7e286b8*/ UnityEngine.MaterialGlobalIlluminationFlags get_globalIlluminationFlags();
        /*0x7e28790*/ void set_globalIlluminationFlags(UnityEngine.MaterialGlobalIlluminationFlags value);
        /*0x7e28880*/ bool get_doubleSidedGI();
        /*0x7e28958*/ void set_doubleSidedGI(bool value);
        /*0x7e17888*/ bool get_enableInstancing();
        /*0x7e28a84*/ void set_enableInstancing(bool value);
        /*0x7e28b74*/ int get_passCount();
        /*0x7e28c4c*/ void SetShaderPassEnabled(string passName, bool enabled);
        /*0x7e28e74*/ bool GetShaderPassEnabled(string passName);
        /*0x7e29088*/ string GetPassName(int pass);
        /*0x7e29208*/ int FindPass(string passName);
        /*0x7e29418*/ void SetOverrideTag(string tag, string val);
        /*0x7e296fc*/ string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue);
        /*0x7e29a40*/ string GetTag(string tag, bool searchFallbacks, string defaultValue);
        /*0x7e29a4c*/ string GetTag(string tag, bool searchFallbacks);
        /*0x7e29ab0*/ void Lerp(UnityEngine.Material start, UnityEngine.Material end, float t);
        /*0x7e29c1c*/ bool SetPass(int pass);
        /*0x7e29d0c*/ void CopyPropertiesFromMaterial(UnityEngine.Material mat);
        /*0x7e29e28*/ void CopyMatchingPropertiesFromMaterial(UnityEngine.Material mat);
        /*0x7e29f44*/ string[] GetShaderKeywords();
        /*0x7e2a01c*/ void SetShaderKeywords(string[] names);
        /*0x7e2a10c*/ string[] get_shaderKeywords();
        /*0x7e2a110*/ void set_shaderKeywords(string[] value);
        /*0x7e2a114*/ string[] GetPropertyNamesImpl(int propertyType);
        /*0x7e2a204*/ int ComputeCRC();
        /*0x7e2a2dc*/ string[] GetTexturePropertyNames();
        /*0x7e2a3b4*/ int[] GetTexturePropertyNameIDs();
        /*0x7e2a544*/ void GetTexturePropertyNamesInternal(object outNames);
        /*0x7e2a634*/ void GetTexturePropertyNameIDsInternal(object outNames);
        /*0x7e2a724*/ void GetTexturePropertyNames(System.Collections.Generic.List<string> outNames);
        /*0x7e2a778*/ void GetTexturePropertyNameIDs(System.Collections.Generic.List<int> outNames);
        /*0x7e2a7cc*/ void SetIntImpl(int name, int value);
        /*0x7e2a8d4*/ void SetFloatImpl(int name, float value);
        /*0x7e2a9e4*/ void SetColorImpl(int name, UnityEngine.Color value);
        /*0x7e2aafc*/ void SetMatrixImpl(int name, UnityEngine.Matrix4x4 value);
        /*0x7e2ac04*/ void SetTextureImpl(int name, UnityEngine.Texture value);
        /*0x7e2ad38*/ void SetRenderTextureImpl(int name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x7e2ae84*/ void SetBufferImpl(int name, UnityEngine.ComputeBuffer value);
        /*0x7e2af94*/ void SetGraphicsBufferImpl(int name, UnityEngine.GraphicsBuffer value);
        /*0x7e2b0a4*/ void SetConstantBufferImpl(int name, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x7e2b1e4*/ void SetConstantGraphicsBufferImpl(int name, UnityEngine.GraphicsBuffer value, int offset, int size);
        /*0x7e2b324*/ int GetIntImpl(int name);
        /*0x7e2b414*/ float GetFloatImpl(int name);
        /*0x7e2b504*/ UnityEngine.Color GetColorImpl(int name);
        /*0x7e2b620*/ UnityEngine.Matrix4x4 GetMatrixImpl(int name);
        /*0x7e2b750*/ UnityEngine.Texture GetTextureImpl(int name);
        /*0x7e2b85c*/ UnityEngine.GraphicsBufferHandle GetBufferImpl(int name);
        /*0x7e2b96c*/ UnityEngine.GraphicsBufferHandle GetConstantBufferImpl(int name);
        /*0x7e2ba7c*/ void SetFloatArrayImpl(int name, float[] values, int count);
        /*0x7e2bc10*/ void SetVectorArrayImpl(int name, UnityEngine.Vector4[] values, int count);
        /*0x7e2bda4*/ void SetColorArrayImpl(int name, UnityEngine.Color[] values, int count);
        /*0x7e2bf38*/ void SetMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x7e2c0cc*/ float[] GetFloatArrayImpl(int name);
        /*0x7e2c27c*/ UnityEngine.Vector4[] GetVectorArrayImpl(int name);
        /*0x7e2c42c*/ UnityEngine.Color[] GetColorArrayImpl(int name);
        /*0x7e2c5dc*/ UnityEngine.Matrix4x4[] GetMatrixArrayImpl(int name);
        /*0x7e2c78c*/ int GetFloatArrayCountImpl(int name);
        /*0x7e2c87c*/ int GetVectorArrayCountImpl(int name);
        /*0x7e2c96c*/ int GetColorArrayCountImpl(int name);
        /*0x7e2ca5c*/ int GetMatrixArrayCountImpl(int name);
        /*0x7e2cb4c*/ void ExtractFloatArrayImpl(int name, float[] val);
        /*0x7e2cd24*/ void ExtractVectorArrayImpl(int name, UnityEngine.Vector4[] val);
        /*0x7e2cefc*/ void ExtractColorArrayImpl(int name, UnityEngine.Color[] val);
        /*0x7e2d0d4*/ void ExtractMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] val);
        /*0x7e2d2ac*/ UnityEngine.Vector4 GetTextureScaleAndOffsetImpl(int name);
        /*0x7e2d3c8*/ void SetTextureOffsetImpl(int name, UnityEngine.Vector2 offset);
        /*0x7e2d4d4*/ void SetTextureScaleImpl(int name, UnityEngine.Vector2 scale);
        /*0x7e2d5e0*/ void SetFloatArray(int name, float[] values, int count);
        /*0x7e2d69c*/ void SetVectorArray(int name, UnityEngine.Vector4[] values, int count);
        /*0x7e2d758*/ void SetColorArray(int name, UnityEngine.Color[] values, int count);
        /*0x7e2d814*/ void SetMatrixArray(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x7e2d8d0*/ void ExtractFloatArray(int name, System.Collections.Generic.List<float> values);
        /*0x7e2da04*/ void ExtractVectorArray(int name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        /*0x7e2db38*/ void ExtractColorArray(int name, System.Collections.Generic.List<UnityEngine.Color> values);
        /*0x7e2dc6c*/ void ExtractMatrixArray(int name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        /*0x7e2dda0*/ void SetInt(string name, int value);
        /*0x7e2ddd0*/ void SetInt(int nameID, int value);
        /*0x7e2ddd8*/ void SetFloat(string name, float value);
        /*0x7e2de08*/ void SetFloat(int nameID, float value);
        /*0x7e2de0c*/ void SetInteger(string name, int value);
        /*0x7e2de3c*/ void SetInteger(int nameID, int value);
        /*0x7e2de40*/ void SetColor(string name, UnityEngine.Color value);
        /*0x7e26b48*/ void SetColor(int nameID, UnityEngine.Color value);
        /*0x7e2de90*/ void SetVector(string name, UnityEngine.Vector4 value);
        /*0x7e2dee0*/ void SetVector(int nameID, UnityEngine.Vector4 value);
        /*0x7e2dee4*/ void SetMatrix(string name, UnityEngine.Matrix4x4 value);
        /*0x7e2df30*/ void SetMatrix(int nameID, UnityEngine.Matrix4x4 value);
        /*0x7e2df5c*/ void SetTexture(string name, UnityEngine.Texture value);
        /*0x7e26c40*/ void SetTexture(int nameID, UnityEngine.Texture value);
        /*0x7e2df8c*/ void SetTexture(string name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x7e2dfc4*/ void SetTexture(int nameID, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x7e2dfc8*/ void SetBuffer(string name, UnityEngine.ComputeBuffer value);
        /*0x7e2dff8*/ void SetBuffer(int nameID, UnityEngine.ComputeBuffer value);
        /*0x7e2dffc*/ void SetBuffer(string name, UnityEngine.GraphicsBuffer value);
        /*0x7e2e02c*/ void SetBuffer(int nameID, UnityEngine.GraphicsBuffer value);
        /*0x7e2e030*/ void SetConstantBuffer(string name, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x7e2e078*/ void SetConstantBuffer(int nameID, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x7e2e07c*/ void SetConstantBuffer(string name, UnityEngine.GraphicsBuffer value, int offset, int size);
        /*0x7e2e0c4*/ void SetConstantBuffer(int nameID, UnityEngine.GraphicsBuffer value, int offset, int size);
        /*0x7e2e0c8*/ void SetFloatArray(string name, System.Collections.Generic.List<float> values);
        /*0x7e2e170*/ void SetFloatArray(int nameID, System.Collections.Generic.List<float> values);
        /*0x7e2e20c*/ void SetFloatArray(string name, float[] values);
        /*0x7e2e248*/ void SetFloatArray(int nameID, float[] values);
        /*0x7e2e260*/ void SetColorArray(string name, System.Collections.Generic.List<UnityEngine.Color> values);
        /*0x7e2e308*/ void SetColorArray(int nameID, System.Collections.Generic.List<UnityEngine.Color> values);
        /*0x7e2e3a4*/ void SetColorArray(string name, UnityEngine.Color[] values);
        /*0x7e2e3e0*/ void SetColorArray(int nameID, UnityEngine.Color[] values);
        /*0x7e2e3f8*/ void SetVectorArray(string name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        /*0x7e2e4a0*/ void SetVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
        /*0x7e2e53c*/ void SetVectorArray(string name, UnityEngine.Vector4[] values);
        /*0x7e2e578*/ void SetVectorArray(int nameID, UnityEngine.Vector4[] values);
        /*0x7e2e590*/ void SetMatrixArray(string name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        /*0x7e2e638*/ void SetMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        /*0x7e2e6d4*/ void SetMatrixArray(string name, UnityEngine.Matrix4x4[] values);
        /*0x7e2e710*/ void SetMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
        /*0x7e2e728*/ int GetInt(string name);
        /*0x7e2e764*/ int GetInt(int nameID);
        /*0x7e2e78c*/ float GetFloat(string name);
        /*0x7e2e7ac*/ float GetFloat(int nameID);
        /*0x7e2e7b0*/ int GetInteger(string name);
        /*0x7e2e7d0*/ int GetInteger(int nameID);
        /*0x7e2e7d4*/ UnityEngine.Color GetColor(string name);
        /*0x7e26aa0*/ UnityEngine.Color GetColor(int nameID);
        /*0x7e2e7f4*/ UnityEngine.Vector4 GetVector(string name);
        /*0x7e2e814*/ UnityEngine.Vector4 GetVector(int nameID);
        /*0x7e2e818*/ UnityEngine.Matrix4x4 GetMatrix(string name);
        /*0x7e2e870*/ UnityEngine.Matrix4x4 GetMatrix(int nameID);
        /*0x7e2e8ac*/ UnityEngine.Texture GetTexture(string name);
        /*0x7e26bc0*/ UnityEngine.Texture GetTexture(int nameID);
        /*0x7e2e8cc*/ UnityEngine.GraphicsBufferHandle GetBuffer(string name);
        /*0x7e2e8f4*/ UnityEngine.GraphicsBufferHandle GetConstantBuffer(string name);
        /*0x7e2e91c*/ float[] GetFloatArray(string name);
        /*0x7e2e93c*/ float[] GetFloatArray(int nameID);
        /*0x7e2e978*/ UnityEngine.Color[] GetColorArray(string name);
        /*0x7e2e998*/ UnityEngine.Color[] GetColorArray(int nameID);
        /*0x7e2e9d4*/ UnityEngine.Vector4[] GetVectorArray(string name);
        /*0x7e2e9f4*/ UnityEngine.Vector4[] GetVectorArray(int nameID);
        /*0x7e2ea30*/ UnityEngine.Matrix4x4[] GetMatrixArray(string name);
        /*0x7e2ea50*/ UnityEngine.Matrix4x4[] GetMatrixArray(int nameID);
        /*0x7e2ea8c*/ void GetFloatArray(string name, System.Collections.Generic.List<float> values);
        /*0x7e2eabc*/ void GetFloatArray(int nameID, System.Collections.Generic.List<float> values);
        /*0x7e2eac0*/ void GetColorArray(string name, System.Collections.Generic.List<UnityEngine.Color> values);
        /*0x7e2eaf0*/ void GetColorArray(int nameID, System.Collections.Generic.List<UnityEngine.Color> values);
        /*0x7e2eaf4*/ void GetVectorArray(string name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        /*0x7e2eb24*/ void GetVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
        /*0x7e2eb28*/ void GetMatrixArray(string name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        /*0x7e2eb58*/ void GetMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        /*0x7e2eb5c*/ void SetTextureOffset(string name, UnityEngine.Vector2 value);
        /*0x7e26d68*/ void SetTextureOffset(int nameID, UnityEngine.Vector2 value);
        /*0x7e2eb94*/ void SetTextureScale(string name, UnityEngine.Vector2 value);
        /*0x7e26e70*/ void SetTextureScale(int nameID, UnityEngine.Vector2 value);
        /*0x7e2ebcc*/ UnityEngine.Vector2 GetTextureOffset(string name);
        /*0x7e26cc4*/ UnityEngine.Vector2 GetTextureOffset(int nameID);
        /*0x7e2ebf8*/ UnityEngine.Vector2 GetTextureScale(string name);
        /*0x7e26de0*/ UnityEngine.Vector2 GetTextureScale(int nameID);
        /*0x7e2ec18*/ string[] GetPropertyNames(UnityEngine.MaterialPropertyType type);
    }

    struct GraphicsBufferHandle : System.IEquatable<UnityEngine.GraphicsBufferHandle>
    {
        /*0x10*/ uint value;

        /*0x7e2ecb0*/ int GetHashCode();
        /*0x7e2ecb8*/ bool Equals(object obj);
        /*0x7e2ed30*/ bool Equals(UnityEngine.GraphicsBufferHandle other);
    }

    class GraphicsBuffer : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;

        static /*0x7e2ef44*/ bool RequiresCompute(UnityEngine.GraphicsBuffer.Target target);
        static /*0x7e2ef50*/ bool IsVertexIndexOrCopyOnly(UnityEngine.GraphicsBuffer.Target target);
        static /*0x7e2ef5c*/ nint InitBuffer(UnityEngine.GraphicsBuffer.Target target, UnityEngine.GraphicsBuffer.UsageFlags usageFlags, int count, int stride);
        static /*0x7e2eefc*/ void DestroyBuffer(UnityEngine.GraphicsBuffer buf);
        static /*0x7e2f3b0*/ bool IsValidBuffer(UnityEngine.GraphicsBuffer buf);
        static /*0x7e2efb8*/ void DestroyBuffer_Injected(nint buf);
        static /*0x7e2f3f8*/ bool IsValidBuffer_Injected(nint buf);
        static /*0x7e2f4d4*/ int get_count_Injected(nint _unity_self);
        static /*0x7e2f560*/ int get_stride_Injected(nint _unity_self);
        static /*0x7e2f5ec*/ UnityEngine.GraphicsBuffer.UsageFlags GetUsageFlags_Injected(nint _unity_self);
        static /*0x7e2f68c*/ void get_bufferHandle_Injected(nint _unity_self, ref UnityEngine.GraphicsBufferHandle ret);
        static /*0x7e2fa18*/ void InternalSetNativeData_Injected(nint _unity_self, nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
        static /*0x7e2fa8c*/ void InternalSetData_Injected(nint _unity_self, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
        static /*0x7e2fb68*/ void* BeginBufferWrite_Injected(nint _unity_self, int offset, int size);
        static /*0x7e2fc14*/ void EndBufferWrite_Injected(nint _unity_self, int bytesWritten);
        static /*0x7e2fdec*/ void SetName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        /*0x7e2eff4*/ GraphicsBuffer(nint ptr);
        /*0x7e2f01c*/ GraphicsBuffer(UnityEngine.GraphicsBuffer.Target target, int count, int stride);
        /*0x7e2f360*/ GraphicsBuffer(UnityEngine.GraphicsBuffer.Target target, UnityEngine.GraphicsBuffer.UsageFlags usageFlags, int count, int stride);
        /*0x7e2ed40*/ void Finalize();
        /*0x7e2ee98*/ void Dispose();
        /*0x7e2edd8*/ void Dispose(bool disposing);
        /*0x7e2f068*/ void InternalInitialization(UnityEngine.GraphicsBuffer.Target target, UnityEngine.GraphicsBuffer.UsageFlags usageFlags, int count, int stride);
        /*0x7e2f3ac*/ void Release();
        /*0x7e2f434*/ bool IsValid();
        /*0x7e2f484*/ int get_count();
        /*0x7e2f510*/ int get_stride();
        /*0x7e2f59c*/ UnityEngine.GraphicsBuffer.UsageFlags GetUsageFlags();
        /*0x7e2f628*/ UnityEngine.GraphicsBuffer.UsageFlags get_usageFlags();
        /*0x7e2f62c*/ UnityEngine.GraphicsBufferHandle get_bufferHandle();
        /*0x3907c14*/ void SetData<T>(Unity.Collections.NativeArray<T> data);
        /*0x7e2f6d0*/ void SetData(System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
        /*0x3907c14*/ void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
        /*0x7e2f990*/ void InternalSetNativeData(nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
        /*0x7e2f908*/ void InternalSetData(System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
        /*0x7e2fb00*/ void* BeginBufferWrite(int offset, int size);
        /*0x3907c14*/ Unity.Collections.NativeArray<T> LockBufferForWrite<T>(int bufferStartIndex, int count);
        /*0x7e2fbbc*/ void EndBufferWrite(int bytesWritten);
        /*0x380cffc*/ void UnlockBufferAfterWrite<T>(int countWritten);
        /*0x7e2fc58*/ void set_name(string value);
        /*0x7e2fc5c*/ void SetName(string name);

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
            static /*0x7e2fe30*/ UnityEngine.GraphicsBuffer ConvertToManaged(nint ptr);
            static /*0x7e2fe8c*/ nint ConvertToNative(UnityEngine.GraphicsBuffer graphicsBuffer);
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

        static /*0x7e342d8*/ int get_pixelLightCount();
        static /*0x7e34300*/ void set_pixelLightCount(int value);
        static /*0x7e3433c*/ UnityEngine.Light[] GetLights(UnityEngine.LightType type, int layer);
        static /*0x7e2ff1c*/ UnityEngine.LightType get_type_Injected(nint _unity_self);
        static /*0x7e2ffd8*/ void set_type_Injected(nint _unity_self, UnityEngine.LightType value);
        static /*0x7e300a4*/ float get_spotAngle_Injected(nint _unity_self);
        static /*0x7e30168*/ void set_spotAngle_Injected(nint _unity_self, float value);
        static /*0x7e3022c*/ float get_innerSpotAngle_Injected(nint _unity_self);
        static /*0x7e302f0*/ void set_innerSpotAngle_Injected(nint _unity_self, float value);
        static /*0x7e303d0*/ void get_color_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x7e304a4*/ void set_color_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x7e30560*/ float get_colorTemperature_Injected(nint _unity_self);
        static /*0x7e30624*/ void set_colorTemperature_Injected(nint _unity_self, float value);
        static /*0x7e306e8*/ bool get_useColorTemperature_Injected(nint _unity_self);
        static /*0x7e307a4*/ void set_useColorTemperature_Injected(nint _unity_self, bool value);
        static /*0x7e30860*/ float get_intensity_Injected(nint _unity_self);
        static /*0x7e30924*/ void set_intensity_Injected(nint _unity_self, float value);
        static /*0x7e309e8*/ float get_bounceIntensity_Injected(nint _unity_self);
        static /*0x7e30aac*/ void set_bounceIntensity_Injected(nint _unity_self, float value);
        static /*0x7e30b70*/ UnityEngine.Rendering.LightUnit get_lightUnit_Injected(nint _unity_self);
        static /*0x7e30c2c*/ void set_lightUnit_Injected(nint _unity_self, UnityEngine.Rendering.LightUnit value);
        static /*0x7e30ce8*/ float get_luxAtDistance_Injected(nint _unity_self);
        static /*0x7e30dac*/ void set_luxAtDistance_Injected(nint _unity_self, float value);
        static /*0x7e30e70*/ bool get_enableSpotReflector_Injected(nint _unity_self);
        static /*0x7e30f2c*/ void set_enableSpotReflector_Injected(nint _unity_self, bool value);
        static /*0x7e30fe8*/ bool get_useBoundingSphereOverride_Injected(nint _unity_self);
        static /*0x7e310a4*/ void set_useBoundingSphereOverride_Injected(nint _unity_self, bool value);
        static /*0x7e3117c*/ void get_boundingSphereOverride_Injected(nint _unity_self, ref UnityEngine.Vector4 ret);
        static /*0x7e31250*/ void set_boundingSphereOverride_Injected(nint _unity_self, ref UnityEngine.Vector4 value);
        static /*0x7e3130c*/ bool get_useViewFrustumForShadowCasterCull_Injected(nint _unity_self);
        static /*0x7e313c8*/ void set_useViewFrustumForShadowCasterCull_Injected(nint _unity_self, bool value);
        static /*0x7e31484*/ bool get_forceVisible_Injected(nint _unity_self);
        static /*0x7e31540*/ void set_forceVisible_Injected(nint _unity_self, bool value);
        static /*0x7e315fc*/ int get_shadowCustomResolution_Injected(nint _unity_self);
        static /*0x7e316b8*/ void set_shadowCustomResolution_Injected(nint _unity_self, int value);
        static /*0x7e31774*/ float get_shadowBias_Injected(nint _unity_self);
        static /*0x7e31838*/ void set_shadowBias_Injected(nint _unity_self, float value);
        static /*0x7e318fc*/ float get_shadowNormalBias_Injected(nint _unity_self);
        static /*0x7e319c0*/ void set_shadowNormalBias_Injected(nint _unity_self, float value);
        static /*0x7e31a84*/ float get_shadowNearPlane_Injected(nint _unity_self);
        static /*0x7e31b48*/ void set_shadowNearPlane_Injected(nint _unity_self, float value);
        static /*0x7e31c0c*/ bool get_useShadowMatrixOverride_Injected(nint _unity_self);
        static /*0x7e31cc8*/ void set_useShadowMatrixOverride_Injected(nint _unity_self, bool value);
        static /*0x7e31db4*/ void get_shadowMatrixOverride_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e31e78*/ void set_shadowMatrixOverride_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
        static /*0x7e31f34*/ float get_range_Injected(nint _unity_self);
        static /*0x7e31ff8*/ void set_range_Injected(nint _unity_self, float value);
        static /*0x7e320bc*/ float get_dilatedRange_Injected(nint _unity_self);
        static /*0x7e3218c*/ nint get_flare_Injected(nint _unity_self);
        static /*0x7e3227c*/ void set_flare_Injected(nint _unity_self, nint value);
        static /*0x7e32364*/ void get_bakingOutput_Injected(nint _unity_self, ref UnityEngine.LightBakingOutput ret);
        static /*0x7e32428*/ void set_bakingOutput_Injected(nint _unity_self, ref UnityEngine.LightBakingOutput value);
        static /*0x7e324e4*/ int get_cullingMask_Injected(nint _unity_self);
        static /*0x7e325a0*/ void set_cullingMask_Injected(nint _unity_self, int value);
        static /*0x7e3265c*/ int get_renderingLayerMask_Injected(nint _unity_self);
        static /*0x7e32718*/ void set_renderingLayerMask_Injected(nint _unity_self, int value);
        static /*0x7e327d4*/ UnityEngine.LightShadowCasterMode get_lightShadowCasterMode_Injected(nint _unity_self);
        static /*0x7e32890*/ void set_lightShadowCasterMode_Injected(nint _unity_self, UnityEngine.LightShadowCasterMode value);
        static /*0x7e3294c*/ void Reset_Injected(nint _unity_self);
        static /*0x7e32a00*/ UnityEngine.LightShadows get_shadows_Injected(nint _unity_self);
        static /*0x7e32abc*/ void set_shadows_Injected(nint _unity_self, UnityEngine.LightShadows value);
        static /*0x7e32b78*/ float get_shadowStrength_Injected(nint _unity_self);
        static /*0x7e32c3c*/ void set_shadowStrength_Injected(nint _unity_self, float value);
        static /*0x7e32d00*/ UnityEngine.Rendering.LightShadowResolution get_shadowResolution_Injected(nint _unity_self);
        static /*0x7e32dbc*/ void set_shadowResolution_Injected(nint _unity_self, UnityEngine.Rendering.LightShadowResolution value);
        static /*0x7e32f40*/ void get_layerShadowCullDistances_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e33080*/ void set_layerShadowCullDistances_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7e3313c*/ float get_cookieSize_Injected(nint _unity_self);
        static /*0x7e33200*/ void set_cookieSize_Injected(nint _unity_self, float value);
        static /*0x7e332e0*/ nint get_cookie_Injected(nint _unity_self);
        static /*0x7e333d0*/ void set_cookie_Injected(nint _unity_self, nint value);
        static /*0x7e3348c*/ UnityEngine.LightRenderMode get_renderMode_Injected(nint _unity_self);
        static /*0x7e33548*/ void set_renderMode_Injected(nint _unity_self, UnityEngine.LightRenderMode value);
        static /*0x7e33624*/ void get_areaSize_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e336ec*/ void set_areaSize_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e338d8*/ void AddCommandBufferInternal_Injected(nint _unity_self, UnityEngine.Rendering.LightEvent evt, nint buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask);
        static /*0x7e33af8*/ void AddCommandBufferAsyncInternal_Injected(nint _unity_self, UnityEngine.Rendering.LightEvent evt, nint buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType);
        static /*0x7e33cec*/ void RemoveCommandBufferInternal_Injected(nint _unity_self, UnityEngine.Rendering.LightEvent evt, nint buffer);
        static /*0x7e33ea8*/ void RemoveCommandBuffersInternal_Injected(nint _unity_self, UnityEngine.Rendering.LightEvent evt);
        static /*0x7e3403c*/ void RemoveAllCommandBuffersInternal_Injected(nint _unity_self);
        static /*0x7e341e0*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffersInternal_Injected(nint _unity_self, UnityEngine.Rendering.LightEvent evt);
        static /*0x7e3429c*/ int get_commandBufferCount_Injected(nint _unity_self);
        /*0x7e343a4*/ Light();
        /*0x7e2fea4*/ UnityEngine.LightType get_type();
        /*0x7e2ff58*/ void set_type(UnityEngine.LightType value);
        /*0x7e3001c*/ UnityEngine.LightShape get_shape();
        /*0x7e30024*/ void set_shape(UnityEngine.LightShape value);
        /*0x7e3002c*/ float get_spotAngle();
        /*0x7e300e0*/ void set_spotAngle(float value);
        /*0x7e301b4*/ float get_innerSpotAngle();
        /*0x7e30268*/ void set_innerSpotAngle(float value);
        /*0x7e3033c*/ UnityEngine.Color get_color();
        /*0x7e30414*/ void set_color(UnityEngine.Color value);
        /*0x7e304e8*/ float get_colorTemperature();
        /*0x7e3059c*/ void set_colorTemperature(float value);
        /*0x7e30670*/ bool get_useColorTemperature();
        /*0x7e30724*/ void set_useColorTemperature(bool value);
        /*0x7e307e8*/ float get_intensity();
        /*0x7e3089c*/ void set_intensity(float value);
        /*0x7e30970*/ float get_bounceIntensity();
        /*0x7e30a24*/ void set_bounceIntensity(float value);
        /*0x7e30af8*/ UnityEngine.Rendering.LightUnit get_lightUnit();
        /*0x7e30bac*/ void set_lightUnit(UnityEngine.Rendering.LightUnit value);
        /*0x7e30c70*/ float get_luxAtDistance();
        /*0x7e30d24*/ void set_luxAtDistance(float value);
        /*0x7e30df8*/ bool get_enableSpotReflector();
        /*0x7e30eac*/ void set_enableSpotReflector(bool value);
        /*0x7e30f70*/ bool get_useBoundingSphereOverride();
        /*0x7e31024*/ void set_useBoundingSphereOverride(bool value);
        /*0x7e310e8*/ UnityEngine.Vector4 get_boundingSphereOverride();
        /*0x7e311c0*/ void set_boundingSphereOverride(UnityEngine.Vector4 value);
        /*0x7e31294*/ bool get_useViewFrustumForShadowCasterCull();
        /*0x7e31348*/ void set_useViewFrustumForShadowCasterCull(bool value);
        /*0x7e3140c*/ bool get_forceVisible();
        /*0x7e314c0*/ void set_forceVisible(bool value);
        /*0x7e31584*/ int get_shadowCustomResolution();
        /*0x7e31638*/ void set_shadowCustomResolution(int value);
        /*0x7e316fc*/ float get_shadowBias();
        /*0x7e317b0*/ void set_shadowBias(float value);
        /*0x7e31884*/ float get_shadowNormalBias();
        /*0x7e31938*/ void set_shadowNormalBias(float value);
        /*0x7e31a0c*/ float get_shadowNearPlane();
        /*0x7e31ac0*/ void set_shadowNearPlane(float value);
        /*0x7e31b94*/ bool get_useShadowMatrixOverride();
        /*0x7e31c48*/ void set_useShadowMatrixOverride(bool value);
        /*0x7e31d0c*/ UnityEngine.Matrix4x4 get_shadowMatrixOverride();
        /*0x7e31df8*/ void set_shadowMatrixOverride(UnityEngine.Matrix4x4 value);
        /*0x7e31ebc*/ float get_range();
        /*0x7e31f70*/ void set_range(float value);
        /*0x7e32044*/ float get_dilatedRange();
        /*0x7e320f8*/ UnityEngine.Flare get_flare();
        /*0x7e321c8*/ void set_flare(UnityEngine.Flare value);
        /*0x7e322c0*/ UnityEngine.LightBakingOutput get_bakingOutput();
        /*0x7e323a8*/ void set_bakingOutput(UnityEngine.LightBakingOutput value);
        /*0x7e3246c*/ int get_cullingMask();
        /*0x7e32520*/ void set_cullingMask(int value);
        /*0x7e325e4*/ int get_renderingLayerMask();
        /*0x7e32698*/ void set_renderingLayerMask(int value);
        /*0x7e3275c*/ UnityEngine.LightShadowCasterMode get_lightShadowCasterMode();
        /*0x7e32810*/ void set_lightShadowCasterMode(UnityEngine.LightShadowCasterMode value);
        /*0x7e328d4*/ void Reset();
        /*0x7e32988*/ UnityEngine.LightShadows get_shadows();
        /*0x7e32a3c*/ void set_shadows(UnityEngine.LightShadows value);
        /*0x7e32b00*/ float get_shadowStrength();
        /*0x7e32bb4*/ void set_shadowStrength(float value);
        /*0x7e32c88*/ UnityEngine.Rendering.LightShadowResolution get_shadowResolution();
        /*0x7e32d3c*/ void set_shadowResolution(UnityEngine.Rendering.LightShadowResolution value);
        /*0x7e32e00*/ float get_shadowSoftness();
        /*0x7e32e08*/ void set_shadowSoftness(float value);
        /*0x7e32e0c*/ float get_shadowSoftnessFade();
        /*0x7e32e14*/ void set_shadowSoftnessFade(float value);
        /*0x7e32e18*/ float[] get_layerShadowCullDistances();
        /*0x7e32f84*/ void set_layerShadowCullDistances(float[] value);
        /*0x7e330c4*/ float get_cookieSize();
        /*0x7e33178*/ void set_cookieSize(float value);
        /*0x7e3324c*/ UnityEngine.Texture get_cookie();
        /*0x7e3331c*/ void set_cookie(UnityEngine.Texture value);
        /*0x7e33414*/ UnityEngine.LightRenderMode get_renderMode();
        /*0x7e334c8*/ void set_renderMode(UnityEngine.LightRenderMode value);
        /*0x7e3358c*/ int get_bakedIndex();
        /*0x7e33594*/ void set_bakedIndex(int value);
        /*0x7e3359c*/ UnityEngine.Vector2 get_areaSize();
        /*0x7e33668*/ void set_areaSize(UnityEngine.Vector2 value);
        /*0x7e33730*/ void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x7e33738*/ void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask);
        /*0x7e33838*/ void AddCommandBufferInternal(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask);
        /*0x7e33934*/ void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType);
        /*0x7e33940*/ void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType);
        /*0x7e33a48*/ void AddCommandBufferAsyncInternal(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType);
        /*0x7e33b64*/ void RemoveCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x7e33c54*/ void RemoveCommandBufferInternal(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x7e33d40*/ void RemoveCommandBuffers(UnityEngine.Rendering.LightEvent evt);
        /*0x7e33e28*/ void RemoveCommandBuffersInternal(UnityEngine.Rendering.LightEvent evt);
        /*0x7e33eec*/ void RemoveAllCommandBuffers();
        /*0x7e33fc4*/ void RemoveAllCommandBuffersInternal();
        /*0x7e34078*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.LightEvent evt);
        /*0x7e34160*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffersInternal(UnityEngine.Rendering.LightEvent evt);
        /*0x7e34224*/ int get_commandBufferCount();
        /*0x7e34380*/ float get_shadowConstantBias();
        /*0x7e34388*/ void set_shadowConstantBias(float value);
        /*0x7e3438c*/ float get_shadowObjectSizeBias();
        /*0x7e34394*/ void set_shadowObjectSizeBias(float value);
        /*0x7e34398*/ bool get_attenuate();
        /*0x7e343a0*/ void set_attenuate(bool value);
    }

    class Skybox : UnityEngine.Behaviour
    {
        static /*0x7e34440*/ nint get_material_Injected(nint _unity_self);
        /*0x7e343ac*/ UnityEngine.Material get_material();
    }

    class MeshFilter : UnityEngine.Component
    {
        static /*0x7e34514*/ nint get_sharedMesh_Injected(nint _unity_self);
        static /*0x7e34604*/ void set_sharedMesh_Injected(nint _unity_self, nint value);
        static /*0x7e346dc*/ nint get_mesh_Injected(nint _unity_self);
        static /*0x7e347cc*/ void set_mesh_Injected(nint _unity_self, nint value);
        /*0x7e34810*/ MeshFilter();
        /*0x7e3447c*/ void DontStripMeshFilter();
        /*0x7e34480*/ UnityEngine.Mesh get_sharedMesh();
        /*0x7e34550*/ void set_sharedMesh(UnityEngine.Mesh value);
        /*0x7e34648*/ UnityEngine.Mesh get_mesh();
        /*0x7e34718*/ void set_mesh(UnityEngine.Mesh value);
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

    enum FogMode
    {
        Linear = 1,
        Exponential = 2,
        ExponentialSquared = 3,
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

    enum NPOTSupport
    {
        None = 0,
        Restricted = 1,
        Full = 2,
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

    enum CustomRenderTextureInitializationSource
    {
        TextureAndColor = 0,
        Material = 1,
    }

    enum CustomRenderTextureUpdateMode
    {
        OnLoad = 0,
        Realtime = 1,
        OnDemand = 2,
    }

    enum CustomRenderTextureUpdateZoneSpace
    {
        Normalized = 0,
        Pixel = 1,
    }

    enum MotionVectorGenerationMode
    {
        Camera = 0,
        Object = 1,
        ForceNoMotion = 2,
    }

    class SkinnedMeshRenderer : UnityEngine.Renderer
    {
    }

    class MeshRenderer : UnityEngine.Renderer
    {
        static /*0x7e348b0*/ nint get_additionalVertexStreams_Injected(nint _unity_self);
        static /*0x7e349a0*/ void set_additionalVertexStreams_Injected(nint _unity_self, nint value);
        static /*0x7e34a78*/ nint get_enlightenVertexStream_Injected(nint _unity_self);
        static /*0x7e34b68*/ void set_enlightenVertexStream_Injected(nint _unity_self, nint value);
        static /*0x7e34c24*/ int get_subMeshStartIndex_Injected(nint _unity_self);
        /*0x7e34c60*/ MeshRenderer();
        /*0x7e34818*/ void DontStripMeshRenderer();
        /*0x7e3481c*/ UnityEngine.Mesh get_additionalVertexStreams();
        /*0x7e348ec*/ void set_additionalVertexStreams(UnityEngine.Mesh value);
        /*0x7e349e4*/ UnityEngine.Mesh get_enlightenVertexStream();
        /*0x7e34ab4*/ void set_enlightenVertexStream(UnityEngine.Mesh value);
        /*0x7e34bac*/ int get_subMeshStartIndex();
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
        static /*0x7e34c68*/ void Internal_Create(UnityEngine.Mesh mono);
        static /*0x7e34d24*/ UnityEngine.Mesh FromInstanceID(int id);
        static /*0x7e3b670*/ UnityEngine.Rendering.VertexAttribute GetUVChannel(int uvIndex);
        static /*0x7e3b6e4*/ int DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute channel);
        static /*0x7e3db20*/ UnityEngine.Mesh.MeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh mesh);
        static /*0x7e3db54*/ UnityEngine.Mesh.MeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh[] meshes);
        static /*0x7e3dbf4*/ UnityEngine.Mesh.MeshDataArray AcquireReadOnlyMeshData(System.Collections.Generic.List<UnityEngine.Mesh> meshes);
        static /*0x7e3dcf8*/ UnityEngine.Mesh.MeshDataArray AllocateWritableMeshData(int meshCount);
        static /*0x7e3dd24*/ UnityEngine.Mesh.MeshDataArray AllocateWritableMeshData(UnityEngine.Mesh mesh);
        static /*0x7e3dd58*/ UnityEngine.Mesh.MeshDataArray AllocateWritableMeshData(UnityEngine.Mesh[] meshes);
        static /*0x7e3ddf8*/ UnityEngine.Mesh.MeshDataArray AllocateWritableMeshData(System.Collections.Generic.List<UnityEngine.Mesh> meshes);
        static /*0x7e3defc*/ void ApplyAndDisposeWritableMeshData(UnityEngine.Mesh.MeshDataArray data, UnityEngine.Mesh mesh, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e3e07c*/ void ApplyAndDisposeWritableMeshData(UnityEngine.Mesh.MeshDataArray data, UnityEngine.Mesh[] meshes, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e3e1cc*/ void ApplyAndDisposeWritableMeshData(UnityEngine.Mesh.MeshDataArray data, System.Collections.Generic.List<UnityEngine.Mesh> meshes, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e34d90*/ nint FromInstanceID_Injected(int id);
        static /*0x7e34e44*/ UnityEngine.Rendering.IndexFormat get_indexFormat_Injected(nint _unity_self);
        static /*0x7e34f00*/ void set_indexFormat_Injected(nint _unity_self, UnityEngine.Rendering.IndexFormat value);
        static /*0x7e34fbc*/ uint GetTotalIndexCount_Injected(nint _unity_self);
        static /*0x7e35088*/ void SetIndexBufferParams_Injected(nint _unity_self, int indexCount, UnityEngine.Rendering.IndexFormat format);
        static /*0x7e3519c*/ void InternalSetIndexBufferData_Injected(nint _unity_self, nint data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e352e0*/ void InternalSetIndexBufferDataFromArray_Injected(nint _unity_self, System.Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e353fc*/ void SetVertexBufferParamsFromPtr_Injected(nint _unity_self, int vertexCount, nint attributesPtr, int attributesCount);
        static /*0x7e35564*/ void SetVertexBufferParamsFromArray_Injected(nint _unity_self, int vertexCount, ref UnityEngine.Bindings.ManagedSpanWrapper attributes);
        static /*0x7e35680*/ void InternalSetVertexBufferData_Injected(nint _unity_self, int stream, nint data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e357d4*/ void InternalSetVertexBufferDataFromArray_Injected(nint _unity_self, int stream, System.Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e358d8*/ System.Array GetVertexAttributesAlloc_Injected(nint _unity_self);
        static /*0x7e35a38*/ int GetVertexAttributesArray_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper attributes);
        static /*0x7e35c84*/ int GetVertexAttributesList_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper attributes);
        static /*0x7e35d40*/ int GetVertexAttributeCountImpl_Injected(nint _unity_self);
        static /*0x7e35e14*/ void GetVertexAttribute_Injected(nint _unity_self, int index, ref UnityEngine.Rendering.VertexAttributeDescriptor ret);
        static /*0x7e35ee8*/ uint GetIndexStartImpl_Injected(nint _unity_self, int submesh);
        static /*0x7e35fac*/ uint GetIndexCountImpl_Injected(nint _unity_self, int submesh);
        static /*0x7e36070*/ uint GetTrianglesCountImpl_Injected(nint _unity_self, int submesh);
        static /*0x7e36134*/ uint GetBaseVertexImpl_Injected(nint _unity_self, int submesh);
        static /*0x7e362bc*/ void GetTrianglesImpl_Injected(nint _unity_self, int submesh, bool applyBaseVertex, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e3645c*/ void GetIndicesImpl_Injected(nint _unity_self, int submesh, bool applyBaseVertex, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e36590*/ void SetIndicesImpl_Injected(nint _unity_self, int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        static /*0x7e36704*/ void SetIndicesNativeArrayImpl_Injected(nint _unity_self, int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, nint indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        static /*0x7e36914*/ void GetTrianglesNonAllocImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values, int submesh, bool applyBaseVertex);
        static /*0x7e36ae4*/ void GetTrianglesNonAllocImpl16_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values, int submesh, bool applyBaseVertex);
        static /*0x7e36cb4*/ void GetIndicesNonAllocImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values, int submesh, bool applyBaseVertex);
        static /*0x7e36e84*/ void GetIndicesNonAllocImpl16_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values, int submesh, bool applyBaseVertex);
        static /*0x7e36f60*/ void PrintErrorCantAccessChannel_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute ch);
        static /*0x7e37024*/ bool HasVertexAttribute_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute attr);
        static /*0x7e370e8*/ int GetVertexAttributeDimension_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute attr);
        static /*0x7e371ac*/ UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute attr);
        static /*0x7e37270*/ int GetVertexAttributeStream_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute attr);
        static /*0x7e37334*/ int GetVertexAttributeOffset_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute attr);
        static /*0x7e37450*/ void SetArrayForChannelImpl_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e375c4*/ void SetNativeArrayForChannelImpl_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, nint values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e376f8*/ System.Array GetAllocArrayFromChannelImpl_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim);
        static /*0x7e377fc*/ void GetArrayFromChannelImpl_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values);
        static /*0x7e378e0*/ int get_vertexBufferCount_Injected(nint _unity_self);
        static /*0x7e3799c*/ int GetVertexBufferStride_Injected(nint _unity_self, int stream);
        static /*0x7e37a60*/ nint GetNativeVertexBufferPtr_Injected(nint _unity_self, int index);
        static /*0x7e37b1c*/ nint GetNativeIndexBufferPtr_Injected(nint _unity_self);
        static /*0x7e37bec*/ nint GetVertexBufferImpl_Injected(nint _unity_self, int index);
        static /*0x7e37cbc*/ nint GetIndexBufferImpl_Injected(nint _unity_self);
        static /*0x7e37d8c*/ nint GetBoneWeightBufferImpl_Injected(nint _unity_self, int bonesPerVertex);
        static /*0x7e37e64*/ nint GetBlendShapeBufferImpl_Injected(nint _unity_self, int layout);
        static /*0x7e37f20*/ UnityEngine.GraphicsBuffer.Target get_vertexBufferTarget_Injected(nint _unity_self);
        static /*0x7e37fdc*/ void set_vertexBufferTarget_Injected(nint _unity_self, UnityEngine.GraphicsBuffer.Target value);
        static /*0x7e38098*/ UnityEngine.GraphicsBuffer.Target get_indexBufferTarget_Injected(nint _unity_self);
        static /*0x7e38154*/ void set_indexBufferTarget_Injected(nint _unity_self, UnityEngine.GraphicsBuffer.Target value);
        static /*0x7e38210*/ int get_blendShapeCount_Injected(nint _unity_self);
        static /*0x7e382c4*/ void ClearBlendShapes_Injected(nint _unity_self);
        static /*0x7e38408*/ void GetBlendShapeName_Injected(nint _unity_self, int shapeIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e38604*/ int GetBlendShapeIndex_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper blendShapeName);
        static /*0x7e386c8*/ int GetBlendShapeFrameCount_Injected(nint _unity_self, int shapeIndex);
        static /*0x7e3879c*/ float GetBlendShapeFrameWeight_Injected(nint _unity_self, int shapeIndex, int frameIndex);
        static /*0x7e389a4*/ void GetBlendShapeFrameVertices_Injected(nint _unity_self, int shapeIndex, int frameIndex, ref UnityEngine.Bindings.ManagedSpanWrapper deltaVertices, ref UnityEngine.Bindings.ManagedSpanWrapper deltaNormals, ref UnityEngine.Bindings.ManagedSpanWrapper deltaTangents);
        static /*0x7e38cfc*/ void AddBlendShapeFrame_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper shapeName, float frameWeight, ref UnityEngine.Bindings.ManagedSpanWrapper deltaVertices, ref UnityEngine.Bindings.ManagedSpanWrapper deltaNormals, ref UnityEngine.Bindings.ManagedSpanWrapper deltaTangents);
        static /*0x7e38e18*/ void GetBlendShapeOffsetInternal_Injected(nint _unity_self, int index, ref UnityEngine.BlendShape ret);
        static /*0x7e38ee4*/ bool HasBoneWeights_Injected(nint _unity_self);
        static /*0x7e39048*/ void GetBoneWeightsImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e39188*/ void SetBoneWeightsImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper weights);
        static /*0x7e39338*/ void InternalSetBoneWeights_Injected(nint _unity_self, nint bonesPerVertex, int bonesPerVertexSize, nint weights, int weightsSize);
        static /*0x7e3966c*/ int GetAllBoneWeightsArraySize_Injected(nint _unity_self);
        static /*0x7e39720*/ int GetBoneWeightBufferLayoutInternal_Injected(nint _unity_self);
        static /*0x7e3975c*/ nint GetAllBoneWeightsArray_Injected(nint _unity_self);
        static /*0x7e39798*/ nint GetBonesPerVertexArray_Injected(nint _unity_self);
        static /*0x7e3984c*/ int get_bindposeCount_Injected(nint _unity_self);
        static /*0x7e399b0*/ void get_bindposes_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e39af0*/ void set_bindposes_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7e39d8c*/ void SetBindposesFromScript_NativeArray_Injected(nint _unity_self, nint posesPtr, int posesCount);
        static /*0x7e39de0*/ nint GetBindposesArray_Injected(nint _unity_self);
        static /*0x7e39f74*/ void GetBoneWeightsNonAllocImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values);
        static /*0x7e3a110*/ void GetBindposesNonAllocImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values);
        static /*0x7e3a1cc*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x7e3a280*/ bool get_canAccess_Injected(nint _unity_self);
        static /*0x7e3a2bc*/ int get_vertexCount_Injected(nint _unity_self);
        static /*0x7e3a2f8*/ int get_subMeshCount_Injected(nint _unity_self);
        static /*0x7e3a3b4*/ void set_subMeshCount_Injected(nint _unity_self, int value);
        static /*0x7e3a490*/ void SetSubMesh_Injected(nint _unity_self, int index, ref UnityEngine.Rendering.SubMeshDescriptor desc, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e3a5a4*/ void GetSubMesh_Injected(nint _unity_self, int index, ref UnityEngine.Rendering.SubMeshDescriptor ret);
        static /*0x7e3a71c*/ void SetAllSubMeshesAtOnceFromArray_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e3a830*/ void SetAllSubMeshesAtOnceFromNativeArray_Injected(nint _unity_self, nint desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e3a940*/ void get_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x7e3aa04*/ void set_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds value);
        static /*0x7e3aac8*/ void ClearImpl_Injected(nint _unity_self, bool keepVertexLayout);
        static /*0x7e3ab8c*/ void RecalculateBoundsImpl_Injected(nint _unity_self, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e3ac50*/ void RecalculateNormalsImpl_Injected(nint _unity_self, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e3ad14*/ void RecalculateTangentsImpl_Injected(nint _unity_self, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e3add0*/ void MarkDynamicImpl_Injected(nint _unity_self);
        static /*0x7e3ae84*/ void MarkModified_Injected(nint _unity_self);
        static /*0x7e3af40*/ void UploadMeshDataImpl_Injected(nint _unity_self, bool markNoLongerReadable);
        static /*0x7e3b004*/ UnityEngine.MeshTopology GetTopologyImpl_Injected(nint _unity_self, int submesh);
        static /*0x7e3b0d8*/ void RecalculateUVDistributionMetricImpl_Injected(nint _unity_self, int uvSetIndex, float uvAreaThreshold);
        static /*0x7e3b1b4*/ void RecalculateUVDistributionMetricsImpl_Injected(nint _unity_self, float uvAreaThreshold);
        static /*0x7e3b280*/ float GetUVDistributionMetric_Injected(nint _unity_self, int uvSetIndex);
        static /*0x7e3b3e8*/ void CombineMeshesImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData);
        static /*0x7e3b4cc*/ void OptimizeImpl_Injected(nint _unity_self);
        static /*0x7e3b580*/ void OptimizeIndexBuffersImpl_Injected(nint _unity_self);
        static /*0x7e3b634*/ void OptimizeReorderVertexBufferImpl_Injected(nint _unity_self);
        /*0x7e34ca4*/ Mesh();
        /*0x7e34dcc*/ UnityEngine.Rendering.IndexFormat get_indexFormat();
        /*0x7e34e80*/ void set_indexFormat(UnityEngine.Rendering.IndexFormat value);
        /*0x7e34f44*/ uint GetTotalIndexCount();
        /*0x7e34ff8*/ void SetIndexBufferParams(int indexCount, UnityEngine.Rendering.IndexFormat format);
        /*0x7e350dc*/ void InternalSetIndexBufferData(nint data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e35220*/ void InternalSetIndexBufferDataFromArray(System.Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e35364*/ void SetVertexBufferParamsFromPtr(int vertexCount, nint attributesPtr, int attributesCount);
        /*0x7e35458*/ void SetVertexBufferParamsFromArray(int vertexCount, UnityEngine.Rendering.VertexAttributeDescriptor[] attributes);
        /*0x7e355b8*/ void InternalSetVertexBufferData(int stream, nint data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3570c*/ void InternalSetVertexBufferDataFromArray(int stream, System.Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e35860*/ System.Array GetVertexAttributesAlloc();
        /*0x7e35914*/ int GetVertexAttributesArray(UnityEngine.Rendering.VertexAttributeDescriptor[] attributes);
        /*0x7e35a7c*/ int GetVertexAttributesList(System.Collections.Generic.List<UnityEngine.Rendering.VertexAttributeDescriptor> attributes);
        /*0x7e35cc8*/ int GetVertexAttributeCountImpl();
        /*0x7e35d7c*/ UnityEngine.Rendering.VertexAttributeDescriptor GetVertexAttribute(int index);
        /*0x7e35e68*/ uint GetIndexStartImpl(int submesh);
        /*0x7e35f2c*/ uint GetIndexCountImpl(int submesh);
        /*0x7e35ff0*/ uint GetTrianglesCountImpl(int submesh);
        /*0x7e360b4*/ uint GetBaseVertexImpl(int submesh);
        /*0x7e36178*/ int[] GetTrianglesImpl(int submesh, bool applyBaseVertex);
        /*0x7e36318*/ int[] GetIndicesImpl(int submesh, bool applyBaseVertex);
        /*0x7e364b8*/ void SetIndicesImpl(int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        /*0x7e3662c*/ void SetIndicesNativeArrayImpl(int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, nint indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        /*0x7e367a0*/ void GetTrianglesNonAllocImpl(int[] values, int submesh, bool applyBaseVertex);
        /*0x7e36970*/ void GetTrianglesNonAllocImpl16(ushort[] values, int submesh, bool applyBaseVertex);
        /*0x7e36b40*/ void GetIndicesNonAllocImpl(int[] values, int submesh, bool applyBaseVertex);
        /*0x7e36d10*/ void GetIndicesNonAllocImpl16(ushort[] values, int submesh, bool applyBaseVertex);
        /*0x7e36ee0*/ void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute ch);
        /*0x7e36fa4*/ bool HasVertexAttribute(UnityEngine.Rendering.VertexAttribute attr);
        /*0x7e37068*/ int GetVertexAttributeDimension(UnityEngine.Rendering.VertexAttribute attr);
        /*0x7e3712c*/ UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(UnityEngine.Rendering.VertexAttribute attr);
        /*0x7e371f0*/ int GetVertexAttributeStream(UnityEngine.Rendering.VertexAttribute attr);
        /*0x7e372b4*/ int GetVertexAttributeOffset(UnityEngine.Rendering.VertexAttribute attr);
        /*0x7e37378*/ void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e374ec*/ void SetNativeArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, nint values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e37660*/ System.Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim);
        /*0x7e37754*/ void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values);
        /*0x7e37868*/ int get_vertexBufferCount();
        /*0x7e3791c*/ int GetVertexBufferStride(int stream);
        /*0x7e379e0*/ nint GetNativeVertexBufferPtr(int index);
        /*0x7e37aa4*/ nint GetNativeIndexBufferPtr();
        /*0x7e37b58*/ UnityEngine.GraphicsBuffer GetVertexBufferImpl(int index);
        /*0x7e37c30*/ UnityEngine.GraphicsBuffer GetIndexBufferImpl();
        /*0x7e37cf8*/ UnityEngine.GraphicsBuffer GetBoneWeightBufferImpl(int bonesPerVertex);
        /*0x7e37dd0*/ UnityEngine.GraphicsBuffer GetBlendShapeBufferImpl(int layout);
        /*0x7e37ea8*/ UnityEngine.GraphicsBuffer.Target get_vertexBufferTarget();
        /*0x7e37f5c*/ void set_vertexBufferTarget(UnityEngine.GraphicsBuffer.Target value);
        /*0x7e38020*/ UnityEngine.GraphicsBuffer.Target get_indexBufferTarget();
        /*0x7e380d4*/ void set_indexBufferTarget(UnityEngine.GraphicsBuffer.Target value);
        /*0x7e38198*/ int get_blendShapeCount();
        /*0x7e3824c*/ void ClearBlendShapes();
        /*0x7e38300*/ string GetBlendShapeName(int shapeIndex);
        /*0x7e3845c*/ int GetBlendShapeIndex(string blendShapeName);
        /*0x7e38648*/ int GetBlendShapeFrameCount(int shapeIndex);
        /*0x7e3870c*/ float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex);
        /*0x7e387f0*/ void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, UnityEngine.Vector3[] deltaVertices, UnityEngine.Vector3[] deltaNormals, UnityEngine.Vector3[] deltaTangents);
        /*0x7e38a18*/ void AddBlendShapeFrame(string shapeName, float frameWeight, UnityEngine.Vector3[] deltaVertices, UnityEngine.Vector3[] deltaNormals, UnityEngine.Vector3[] deltaTangents);
        /*0x7e38d78*/ UnityEngine.BlendShape GetBlendShapeOffsetInternal(int index);
        /*0x7e38e6c*/ bool HasBoneWeights();
        /*0x7e38f20*/ UnityEngine.BoneWeight[] GetBoneWeightsImpl();
        /*0x7e3908c*/ void SetBoneWeightsImpl(UnityEngine.BoneWeight[] weights);
        /*0x7e391cc*/ void SetBoneWeights(Unity.Collections.NativeArray<byte> bonesPerVertex, Unity.Collections.NativeArray<UnityEngine.BoneWeight1> weights);
        /*0x7e39290*/ void InternalSetBoneWeights(nint bonesPerVertex, int bonesPerVertexSize, nint weights, int weightsSize);
        /*0x7e393a4*/ Unity.Collections.NativeArray<UnityEngine.BoneWeight1> GetAllBoneWeights();
        /*0x7e39500*/ Unity.Collections.NativeArray<byte> GetBonesPerVertex();
        /*0x7e39488*/ int GetAllBoneWeightsArraySize();
        /*0x7e396a8*/ int GetBoneWeightBufferLayoutInternal();
        /*0x7e39410*/ nint GetAllBoneWeightsArray();
        /*0x7e395f4*/ nint GetBonesPerVertexArray();
        /*0x7e397d4*/ int get_bindposeCount();
        /*0x7e39888*/ UnityEngine.Matrix4x4[] get_bindposes();
        /*0x7e399f4*/ void set_bindposes(UnityEngine.Matrix4x4[] value);
        /*0x7e39b34*/ Unity.Collections.NativeArray<UnityEngine.Matrix4x4> GetBindposes();
        /*0x7e39c18*/ void SetBindposes(Unity.Collections.NativeArray<UnityEngine.Matrix4x4> poses);
        /*0x7e39cfc*/ void SetBindposesFromScript_NativeArray(nint posesPtr, int posesCount);
        /*0x7e39ba0*/ nint GetBindposesArray();
        /*0x7e39e1c*/ void GetBoneWeightsNonAllocImpl(UnityEngine.BoneWeight[] values);
        /*0x7e39fb8*/ void GetBindposesNonAllocImpl(UnityEngine.Matrix4x4[] values);
        /*0x7e3a154*/ bool get_isReadable();
        /*0x7e3a208*/ bool get_canAccess();
        /*0x7e3957c*/ int get_vertexCount();
        /*0x7e17810*/ int get_subMeshCount();
        /*0x7e3a334*/ void set_subMeshCount(int value);
        /*0x7e3a3f8*/ void SetSubMesh(int index, UnityEngine.Rendering.SubMeshDescriptor desc, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3a4ec*/ UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(int index);
        /*0x7e3a5f8*/ void SetAllSubMeshesAtOnceFromArray(UnityEngine.Rendering.SubMeshDescriptor[] desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3a788*/ void SetAllSubMeshesAtOnceFromNativeArray(nint desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3a89c*/ UnityEngine.Bounds get_bounds();
        /*0x7e3a984*/ void set_bounds(UnityEngine.Bounds value);
        /*0x7e3aa48*/ void ClearImpl(bool keepVertexLayout);
        /*0x7e3ab0c*/ void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3abd0*/ void RecalculateNormalsImpl(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3ac94*/ void RecalculateTangentsImpl(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3ad58*/ void MarkDynamicImpl();
        /*0x7e3ae0c*/ void MarkModified();
        /*0x7e3aec0*/ void UploadMeshDataImpl(bool markNoLongerReadable);
        /*0x7e3af84*/ UnityEngine.MeshTopology GetTopologyImpl(int submesh);
        /*0x7e3b048*/ void RecalculateUVDistributionMetricImpl(int uvSetIndex, float uvAreaThreshold);
        /*0x7e3b12c*/ void RecalculateUVDistributionMetricsImpl(float uvAreaThreshold);
        /*0x7e3b200*/ float GetUVDistributionMetric(int uvSetIndex);
        /*0x7e3b2c4*/ void CombineMeshesImpl(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData);
        /*0x7e3b454*/ void OptimizeImpl();
        /*0x7e3b508*/ void OptimizeIndexBuffersImpl();
        /*0x7e3b5bc*/ void OptimizeReorderVertexBufferImpl();
        T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim);
        /*0x380ba90*/ T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel);
        /*0x7e3b780*/ void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3b9ac*/ void SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, nint values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Collections.Generic.List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, System.Collections.Generic.List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        void GetListForChannel<T>(System.Collections.Generic.List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim);
        /*0x3907c14*/ void GetListForChannel<T>(System.Collections.Generic.List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim, UnityEngine.Rendering.VertexAttributeFormat channelType);
        /*0x7e3bbd4*/ UnityEngine.Vector3[] get_vertices();
        /*0x7e3bc20*/ void set_vertices(UnityEngine.Vector3[] value);
        /*0x7e3bc80*/ UnityEngine.Vector3[] get_normals();
        /*0x7e3bccc*/ void set_normals(UnityEngine.Vector3[] value);
        /*0x7e3bd2c*/ UnityEngine.Vector4[] get_tangents();
        /*0x7e3bd78*/ void set_tangents(UnityEngine.Vector4[] value);
        /*0x7e3bdd8*/ UnityEngine.Vector2[] get_uv();
        /*0x7e3be24*/ void set_uv(UnityEngine.Vector2[] value);
        /*0x7e3be84*/ UnityEngine.Vector2[] get_uv2();
        /*0x7e3bed0*/ void set_uv2(UnityEngine.Vector2[] value);
        /*0x7e3bf30*/ UnityEngine.Vector2[] get_uv3();
        /*0x7e3bf7c*/ void set_uv3(UnityEngine.Vector2[] value);
        /*0x7e3bfdc*/ UnityEngine.Vector2[] get_uv4();
        /*0x7e3c028*/ void set_uv4(UnityEngine.Vector2[] value);
        /*0x7e3c088*/ UnityEngine.Vector2[] get_uv5();
        /*0x7e3c0d4*/ void set_uv5(UnityEngine.Vector2[] value);
        /*0x7e3c134*/ UnityEngine.Vector2[] get_uv6();
        /*0x7e3c180*/ void set_uv6(UnityEngine.Vector2[] value);
        /*0x7e3c1e0*/ UnityEngine.Vector2[] get_uv7();
        /*0x7e3c22c*/ void set_uv7(UnityEngine.Vector2[] value);
        /*0x7e3c28c*/ UnityEngine.Vector2[] get_uv8();
        /*0x7e3c2d8*/ void set_uv8(UnityEngine.Vector2[] value);
        /*0x7e3c338*/ UnityEngine.Color[] get_colors();
        /*0x7e3c384*/ void set_colors(UnityEngine.Color[] value);
        /*0x7e3c3e4*/ UnityEngine.Color32[] get_colors32();
        /*0x7e3c438*/ void set_colors32(UnityEngine.Color32[] value);
        /*0x7e3c4a0*/ void GetVertices(System.Collections.Generic.List<UnityEngine.Vector3> vertices);
        /*0x7e3c564*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices);
        /*0x7e3c5d0*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length);
        /*0x7e3c5d8*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3c654*/ void SetVertices(UnityEngine.Vector3[] inVertices);
        /*0x7e3c6bc*/ void SetVertices(UnityEngine.Vector3[] inVertices, int start, int length);
        /*0x7e3c724*/ void SetVertices(UnityEngine.Vector3[] inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices);
        /*0x3907c14*/ void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length);
        /*0x3907c14*/ void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3c790*/ void GetNormals(System.Collections.Generic.List<UnityEngine.Vector3> normals);
        /*0x7e3c854*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals);
        /*0x7e3c8c0*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length);
        /*0x7e3c8c8*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3c944*/ void SetNormals(UnityEngine.Vector3[] inNormals);
        /*0x7e3c9ac*/ void SetNormals(UnityEngine.Vector3[] inNormals, int start, int length);
        /*0x7e3ca14*/ void SetNormals(UnityEngine.Vector3[] inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals);
        /*0x3907c14*/ void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length);
        /*0x3907c14*/ void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3ca80*/ void GetTangents(System.Collections.Generic.List<UnityEngine.Vector4> tangents);
        /*0x7e3cb44*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents);
        /*0x7e3cbb0*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length);
        /*0x7e3cbb8*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3cc34*/ void SetTangents(UnityEngine.Vector4[] inTangents);
        /*0x7e3cc9c*/ void SetTangents(UnityEngine.Vector4[] inTangents, int start, int length);
        /*0x7e3cd04*/ void SetTangents(UnityEngine.Vector4[] inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents);
        /*0x3907c14*/ void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length);
        /*0x3907c14*/ void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3cd70*/ void GetColors(System.Collections.Generic.List<UnityEngine.Color> colors);
        /*0x7e3ce34*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors);
        /*0x7e3cea0*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors, int start, int length);
        /*0x7e3cea8*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3cf24*/ void SetColors(UnityEngine.Color[] inColors);
        /*0x7e3cf8c*/ void SetColors(UnityEngine.Color[] inColors, int start, int length);
        /*0x7e3cff4*/ void SetColors(UnityEngine.Color[] inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3d060*/ void GetColors(System.Collections.Generic.List<UnityEngine.Color32> colors);
        /*0x7e3d128*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors);
        /*0x7e3d194*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length);
        /*0x7e3d19c*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3d230*/ void SetColors(UnityEngine.Color32[] inColors);
        /*0x7e3d298*/ void SetColors(UnityEngine.Color32[] inColors, int start, int length);
        /*0x7e3d300*/ void SetColors(UnityEngine.Color32[] inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetColors<T>(Unity.Collections.NativeArray<T> inColors);
        /*0x3907c14*/ void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length);
        /*0x3907c14*/ void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetUvsImpl<T>(int uvIndex, int dim, System.Collections.Generic.List<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3d36c*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs);
        /*0x7e3d3e8*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs);
        /*0x7e3d464*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs);
        /*0x7e3d3e0*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, int start, int length);
        /*0x7e3d4e0*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3d45c*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs, int start, int length);
        /*0x7e3d56c*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3d4d8*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length);
        /*0x7e3d5f8*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3d684*/ void SetUvsImpl(int uvIndex, int dim, System.Array uvs, int arrayStart, int arraySize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3d78c*/ void SetUVs(int channel, UnityEngine.Vector2[] uvs);
        /*0x7e3d7ec*/ void SetUVs(int channel, UnityEngine.Vector3[] uvs);
        /*0x7e3d84c*/ void SetUVs(int channel, UnityEngine.Vector4[] uvs);
        /*0x7e3d7d4*/ void SetUVs(int channel, UnityEngine.Vector2[] uvs, int start, int length);
        /*0x7e3d8ac*/ void SetUVs(int channel, UnityEngine.Vector2[] uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3d834*/ void SetUVs(int channel, UnityEngine.Vector3[] uvs, int start, int length);
        /*0x7e3d8c4*/ void SetUVs(int channel, UnityEngine.Vector3[] uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3d894*/ void SetUVs(int channel, UnityEngine.Vector4[] uvs, int start, int length);
        /*0x7e3d8dc*/ void SetUVs(int channel, UnityEngine.Vector4[] uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs);
        /*0x3907c14*/ void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length);
        /*0x3907c14*/ void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void GetUVsImpl<T>(int uvIndex, System.Collections.Generic.List<T> uvs, int dim);
        /*0x7e3d8f4*/ void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs);
        /*0x7e3d958*/ void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs);
        /*0x7e3d9bc*/ void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs);
        /*0x7e3da20*/ int get_vertexAttributeCount();
        /*0x7e3da24*/ UnityEngine.Rendering.VertexAttributeDescriptor[] GetVertexAttributes();
        /*0x7e3da90*/ int GetVertexAttributes(UnityEngine.Rendering.VertexAttributeDescriptor[] attributes);
        /*0x7e3da94*/ int GetVertexAttributes(System.Collections.Generic.List<UnityEngine.Rendering.VertexAttributeDescriptor> attributes);
        /*0x7e3da98*/ void SetVertexBufferParams(int vertexCount, UnityEngine.Rendering.VertexAttributeDescriptor[] attributes);
        /*0x7e3da9c*/ void SetVertexBufferParams(int vertexCount, Unity.Collections.NativeArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes);
        /*0x3907c14*/ void SetVertexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetVertexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, int stream, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetVertexBufferData<T>(System.Collections.Generic.List<T> data, int dataStart, int meshBufferStart, int count, int stream, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3e398*/ UnityEngine.GraphicsBuffer GetVertexBuffer(int index);
        /*0x7e3e444*/ UnityEngine.GraphicsBuffer GetIndexBuffer();
        /*0x7e3e4e0*/ UnityEngine.GraphicsBuffer GetBoneWeightBuffer(UnityEngine.SkinWeights layout);
        /*0x7e3e788*/ UnityEngine.GraphicsBuffer GetBlendShapeBuffer(UnityEngine.Rendering.BlendShapeBufferLayout layout);
        /*0x7e3e898*/ UnityEngine.GraphicsBuffer GetBlendShapeBuffer();
        /*0x7e3e998*/ UnityEngine.BlendShapeBufferRange GetBlendShapeBufferRange(int blendShapeIndex);
        /*0x7e3ea9c*/ void PrintErrorCantAccessIndices();
        /*0x7e3eb38*/ bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles);
        /*0x7e3ec3c*/ bool CheckCanAccessSubmeshTriangles(int submesh);
        /*0x7e3ec44*/ bool CheckCanAccessSubmeshIndices(int submesh);
        /*0x7e3ec4c*/ int[] get_triangles();
        /*0x7e3ecc0*/ void set_triangles(int[] value);
        /*0x7e3ede4*/ int[] GetTriangles(int submesh);
        /*0x7e3edec*/ int[] GetTriangles(int submesh, bool applyBaseVertex);
        /*0x7e3ee74*/ void GetTriangles(System.Collections.Generic.List<int> triangles, int submesh);
        /*0x7e3ee7c*/ void GetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool applyBaseVertex);
        /*0x7e3efec*/ void GetTriangles(System.Collections.Generic.List<ushort> triangles, int submesh, bool applyBaseVertex);
        /*0x7e3f15c*/ int[] GetIndices(int submesh);
        /*0x7e3f164*/ int[] GetIndices(int submesh, bool applyBaseVertex);
        /*0x7e3f1ec*/ void GetIndices(System.Collections.Generic.List<int> indices, int submesh);
        /*0x7e3f1f4*/ void GetIndices(System.Collections.Generic.List<int> indices, int submesh, bool applyBaseVertex);
        /*0x7e3f3e0*/ void GetIndices(System.Collections.Generic.List<ushort> indices, int submesh, bool applyBaseVertex);
        /*0x3907c14*/ void SetIndexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetIndexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetIndexBufferData<T>(System.Collections.Generic.List<T> data, int dataStart, int meshBufferStart, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e3f550*/ uint GetIndexStart(int submesh);
        /*0x7e3f364*/ uint GetIndexCount(int submesh);
        /*0x7e3f5cc*/ uint GetBaseVertex(int submesh);
        /*0x7e3f648*/ void CheckIndicesArrayRange(int valuesLength, int start, int length);
        /*0x7e3ed64*/ void SetTrianglesImpl(int submesh, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex);
        /*0x7e3f7e4*/ void SetTriangles(int[] triangles, int submesh);
        /*0x7e3f884*/ void SetTriangles(int[] triangles, int submesh, bool calculateBounds);
        /*0x7e3f82c*/ void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e3f8d8*/ void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e3f974*/ void SetTriangles(ushort[] triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e3f9cc*/ void SetTriangles(ushort[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e3fa68*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh);
        /*0x7e3fafc*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds);
        /*0x7e3fa74*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e3fb08*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e3fc2c*/ void SetTriangles(System.Collections.Generic.List<ushort> triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e3fcb4*/ void SetTriangles(System.Collections.Generic.List<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e3fdd8*/ void SetIndices(int[] indices, UnityEngine.MeshTopology topology, int submesh);
        /*0x7e3feb0*/ void SetIndices(int[] indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds);
        /*0x7e3fe3c*/ void SetIndices(int[] indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e3ff18*/ void SetIndices(int[] indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e3ffc0*/ void SetIndices(ushort[] indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e40034*/ void SetIndices(ushort[] indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x3907c14*/ void SetIndices<T>(Unity.Collections.NativeArray<T> indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x3907c14*/ void SetIndices<T>(Unity.Collections.NativeArray<T> indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e400dc*/ void SetIndices(System.Collections.Generic.List<int> indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e40180*/ void SetIndices(System.Collections.Generic.List<int> indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e402a8*/ void SetIndices(System.Collections.Generic.List<ushort> indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e4034c*/ void SetIndices(System.Collections.Generic.List<ushort> indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e40474*/ void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[] desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e406d8*/ void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[] desc, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e40704*/ void SetSubMeshes(System.Collections.Generic.List<UnityEngine.Rendering.SubMeshDescriptor> desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e407b4*/ void SetSubMeshes(System.Collections.Generic.List<UnityEngine.Rendering.SubMeshDescriptor> desc, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3907c14*/ void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e40868*/ void GetBindposes(System.Collections.Generic.List<UnityEngine.Matrix4x4> bindposes);
        /*0x7e40974*/ void GetBoneWeights(System.Collections.Generic.List<UnityEngine.BoneWeight> boneWeights);
        /*0x7e40a84*/ UnityEngine.BoneWeight[] get_boneWeights();
        /*0x7e40a88*/ void set_boneWeights(UnityEngine.BoneWeight[] value);
        /*0x7e40a8c*/ UnityEngine.SkinWeights get_skinWeightBufferLayout();
        /*0x7e40a90*/ void Clear(bool keepVertexLayout);
        /*0x7e40a98*/ void Clear();
        /*0x7e40aa0*/ void RecalculateBounds();
        /*0x7e40b60*/ void RecalculateNormals();
        /*0x7e40c20*/ void RecalculateTangents();
        /*0x7e40aa8*/ void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e40b68*/ void RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e40c28*/ void RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e40ce0*/ void RecalculateUVDistributionMetric(int uvSetIndex, float uvAreaThreshold);
        /*0x7e40dac*/ void RecalculateUVDistributionMetrics(float uvAreaThreshold);
        /*0x7e40e70*/ void MarkDynamic();
        /*0x7e40e94*/ void UploadMeshData(bool markNoLongerReadable);
        /*0x7e40ecc*/ void Optimize();
        /*0x7e40f7c*/ void OptimizeIndexBuffers();
        /*0x7e4102c*/ void OptimizeReorderVertexBuffer();
        /*0x7e410dc*/ UnityEngine.MeshTopology GetTopology(int submesh);
        /*0x7e41180*/ void CombineMeshes(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData);
        /*0x7e41190*/ void CombineMeshes(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices);
        /*0x7e411a0*/ void CombineMeshes(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes);
        /*0x7e411b0*/ void CombineMeshes(UnityEngine.CombineInstance[] combine);

        struct MeshData
        {
            /*0x10*/ nint m_Ptr;
        }

        struct MeshDataArray : System.IDisposable
        {
            /*0x10*/ nint* m_Ptrs;
            /*0x18*/ int m_Length;

            static /*0x7e42484*/ void AcquireReadOnlyMeshData(UnityEngine.Mesh mesh, nint* datas);
            static /*0x7e42578*/ void AcquireReadOnlyMeshDatas(UnityEngine.Mesh[] meshes, nint* datas, int count);
            static /*0x7e4265c*/ void AcquireMeshDataCopy(UnityEngine.Mesh mesh, nint* datas);
            static /*0x7e42750*/ void AcquireMeshDatasCopy(UnityEngine.Mesh[] meshes, nint* datas, int count);
            static /*0x7e42834*/ void ReleaseMeshDatas(nint* datas, int count);
            static /*0x7e42878*/ void CreateNewMeshDatas(nint* datas, int count);
            static /*0x7e428bc*/ void ApplyToMeshesImpl(UnityEngine.Mesh[] meshes, nint* datas, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
            static /*0x7e429b0*/ void ApplyToMeshImpl(UnityEngine.Mesh mesh, nint data, UnityEngine.Rendering.MeshUpdateFlags flags);
            static /*0x7e42534*/ void AcquireReadOnlyMeshData_Injected(nint mesh, nint* datas);
            static /*0x7e42608*/ void AcquireReadOnlyMeshDatas_Injected(UnityEngine.Mesh[] meshes, nint* datas, int count);
            static /*0x7e4270c*/ void AcquireMeshDataCopy_Injected(nint mesh, nint* datas);
            static /*0x7e427e0*/ void AcquireMeshDatasCopy_Injected(UnityEngine.Mesh[] meshes, nint* datas, int count);
            static /*0x7e42954*/ void ApplyToMeshesImpl_Injected(UnityEngine.Mesh[] meshes, nint* datas, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
            static /*0x7e42a70*/ void ApplyToMeshImpl_Injected(nint mesh, nint data, UnityEngine.Rendering.MeshUpdateFlags flags);
            /*0x7e42e10*/ MeshDataArray(UnityEngine.Mesh mesh, bool checkReadWrite, bool createAsCopy);
            /*0x7e43004*/ MeshDataArray(UnityEngine.Mesh[] meshes, int meshesCount, bool checkReadWrite, bool createAsCopy);
            /*0x7e432c8*/ MeshDataArray(int meshesCount);
            /*0x7e42ac4*/ int get_Length();
            /*0x7e42acc*/ void Dispose();
            /*0x7e42b54*/ void ApplyToMeshAndDispose(UnityEngine.Mesh mesh, UnityEngine.Rendering.MeshUpdateFlags flags);
            /*0x7e42c28*/ void ApplyToMeshesAndDispose(UnityEngine.Mesh[] meshes, UnityEngine.Rendering.MeshUpdateFlags flags);
        }
    }

    struct BlendShape
    {
        /*0x10*/ uint m_FirstVertex;
        /*0x14*/ uint m_VertexCount;
        /*0x18*/ bool m_HasNormals;
        /*0x19*/ bool m_HasTangents;

        /*0x7e433e8*/ uint get_firstVertex();
        /*0x7e433f0*/ uint get_vertexCount();
    }

    struct BlendShapeBufferRange
    {
        /*0x10*/ uint m_StartIndex;
        /*0x14*/ uint m_EndIndex;

        /*0x7e433f8*/ void set_startIndex(uint value);
        /*0x7e43400*/ void set_endIndex(uint value);
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

        /*0x7e43408*/ float get_weight0();
        /*0x7e43410*/ float get_weight1();
        /*0x7e43418*/ float get_weight2();
        /*0x7e43420*/ float get_weight3();
        /*0x7e43428*/ int get_boneIndex0();
        /*0x7e43430*/ int get_boneIndex1();
        /*0x7e43438*/ int get_boneIndex2();
        /*0x7e43440*/ int get_boneIndex3();
        /*0x7e43448*/ int GetHashCode();
        /*0x7e43554*/ bool Equals(object other);
        /*0x7e435dc*/ bool Equals(UnityEngine.BoneWeight other);
    }

    struct BoneWeight1 : System.IEquatable<UnityEngine.BoneWeight1>
    {
        /*0x10*/ float m_Weight;
        /*0x14*/ int m_BoneIndex;

        /*0x7e436c0*/ float get_weight();
        /*0x7e436c8*/ int get_boneIndex();
        /*0x7e436d0*/ bool Equals(object other);
        /*0x7e43748*/ bool Equals(UnityEngine.BoneWeight1 other);
        /*0x7e437a8*/ int GetHashCode();
    }

    struct CombineInstance
    {
        /*0x10*/ int m_MeshInstanceID;
        /*0x14*/ int m_SubMeshIndex;
        /*0x18*/ UnityEngine.Matrix4x4 m_Transform;
        /*0x58*/ UnityEngine.Vector4 m_LightmapScaleOffset;
        /*0x68*/ UnityEngine.Vector4 m_RealtimeLightmapScaleOffset;

        /*0x7e437f4*/ void set_mesh(UnityEngine.Mesh value);
        /*0x7e43884*/ void set_subMeshIndex(int value);
        /*0x7e4388c*/ void set_transform(UnityEngine.Matrix4x4 value);
    }

    class Texture : UnityEngine.Object
    {
        static /*0x0*/ int GenerateAllMips;

        static /*0x7e45410*/ Texture();
        static /*0x7e44bd4*/ void SetStreamingTextureMaterialDebugPropertiesWithSlot(int materialTextureSlot);
        static /*0x7e44c10*/ void SetStreamingTextureMaterialDebugProperties(int materialTextureSlot);
        static /*0x7e44c84*/ bool get_streamingTextureDiscardUnusedMips();
        static /*0x7e44cac*/ void set_streamingTextureDiscardUnusedMips(bool value);
        static /*0x7e4399c*/ int get_mipmapCount_Injected(nint _unity_self);
        static /*0x7e43acc*/ int GetDataWidth_Injected(nint _unity_self);
        static /*0x7e43ba4*/ int GetDataHeight_Injected(nint _unity_self);
        static /*0x7e43c7c*/ UnityEngine.Rendering.TextureDimension GetDimension_Injected(nint _unity_self);
        static /*0x7e43e08*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x7e43ee0*/ UnityEngine.TextureWrapMode get_wrapMode_Injected(nint _unity_self);
        static /*0x7e43fc8*/ void set_wrapMode_Injected(nint _unity_self, UnityEngine.TextureWrapMode value);
        static /*0x7e440b8*/ void set_wrapModeU_Injected(nint _unity_self, UnityEngine.TextureWrapMode value);
        static /*0x7e441a8*/ void set_wrapModeV_Injected(nint _unity_self, UnityEngine.TextureWrapMode value);
        static /*0x7e44298*/ void set_wrapModeW_Injected(nint _unity_self, UnityEngine.TextureWrapMode value);
        static /*0x7e44378*/ UnityEngine.FilterMode get_filterMode_Injected(nint _unity_self);
        static /*0x7e44460*/ void set_filterMode_Injected(nint _unity_self, UnityEngine.FilterMode value);
        static /*0x7e44540*/ int get_anisoLevel_Injected(nint _unity_self);
        static /*0x7e44628*/ void set_anisoLevel_Injected(nint _unity_self, int value);
        static /*0x7e44708*/ float get_mipMapBias_Injected(nint _unity_self);
        static /*0x7e447f0*/ void set_mipMapBias_Injected(nint _unity_self, float value);
        static /*0x7e448f0*/ void get_texelSize_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e449d0*/ uint get_updateCount_Injected(nint _unity_self);
        static /*0x7e44aa8*/ void IncrementUpdateCount_Injected(nint _unity_self);
        static /*0x7e44b80*/ int Internal_GetActiveTextureColorSpace_Injected(nint _unity_self);
        static /*0x7e44d9c*/ ulong GetPixelDataSize_Injected(nint _unity_self, int mipLevel, int element);
        static /*0x7e44ea4*/ ulong GetPixelDataOffset_Injected(nint _unity_self, int mipLevel, int element);
        /*0x7e438a8*/ Texture();
        /*0x7e43900*/ int get_mipmapCount();
        /*0x7e439d8*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x7e43a30*/ int GetDataWidth();
        /*0x7e43b08*/ int GetDataHeight();
        /*0x7e43be0*/ UnityEngine.Rendering.TextureDimension GetDimension();
        /*0x7e43cb8*/ int get_width();
        /*0x7e43cbc*/ void set_width(int value);
        /*0x7e43cf4*/ int get_height();
        /*0x7e43cf8*/ void set_height(int value);
        /*0x7e43d30*/ UnityEngine.Rendering.TextureDimension get_dimension();
        /*0x7e43d34*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
        /*0x7e43d6c*/ bool get_isReadable();
        /*0x7e43e44*/ UnityEngine.TextureWrapMode get_wrapMode();
        /*0x7e43f1c*/ void set_wrapMode(UnityEngine.TextureWrapMode value);
        /*0x7e4400c*/ void set_wrapModeU(UnityEngine.TextureWrapMode value);
        /*0x7e440fc*/ void set_wrapModeV(UnityEngine.TextureWrapMode value);
        /*0x7e441ec*/ void set_wrapModeW(UnityEngine.TextureWrapMode value);
        /*0x7e442dc*/ UnityEngine.FilterMode get_filterMode();
        /*0x7e443b4*/ void set_filterMode(UnityEngine.FilterMode value);
        /*0x7e444a4*/ int get_anisoLevel();
        /*0x7e4457c*/ void set_anisoLevel(int value);
        /*0x7e4466c*/ float get_mipMapBias();
        /*0x7e44744*/ void set_mipMapBias(float value);
        /*0x7e4483c*/ UnityEngine.Vector2 get_texelSize();
        /*0x7e44934*/ uint get_updateCount();
        /*0x7e44a0c*/ void IncrementUpdateCount();
        /*0x7e44ae4*/ int Internal_GetActiveTextureColorSpace();
        /*0x7e44bbc*/ UnityEngine.ColorSpace get_activeTextureColorSpace();
        /*0x7e44ce8*/ ulong GetPixelDataSize(int mipLevel, int element);
        /*0x7e44df0*/ ulong GetPixelDataOffset(int mipLevel, int element);
        /*0x7e44ef8*/ UnityEngine.TextureColorSpace GetTextureColorSpace(bool linear);
        /*0x7e44f04*/ UnityEngine.TextureColorSpace GetTextureColorSpace(UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x7e44f64*/ bool ValidateFormat(UnityEngine.TextureFormat format);
        /*0x7e4512c*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.GraphicsFormatUsage usage);
        /*0x7e45264*/ UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture t);
        /*0x7e45304*/ UnityEngine.UnityException IgnoreMipmapLimitCannotBeToggledException(UnityEngine.Texture t);
        /*0x7e453a4*/ UnityEngine.UnityException CreateNativeArrayLengthOverflowException();
    }

    class Texture2D : UnityEngine.Texture
    {
        static int streamingMipmapsPriorityMin = -128;
        static int streamingMipmapsPriorityMax = 127;

        static /*0x7e4587c*/ UnityEngine.Texture2D get_whiteTexture();
        static /*0x7e45908*/ UnityEngine.Texture2D get_blackTexture();
        static /*0x7e45994*/ UnityEngine.Texture2D get_redTexture();
        static /*0x7e45a20*/ UnityEngine.Texture2D get_grayTexture();
        static /*0x7e45aac*/ UnityEngine.Texture2D get_linearGrayTexture();
        static /*0x7e45b38*/ UnityEngine.Texture2D get_normalTexture();
        static /*0x7e45c88*/ bool Internal_CreateEmptyImpl(UnityEngine.Texture2D mono);
        static /*0x7e45cc4*/ bool Internal_CreateImpl(UnityEngine.Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        static /*0x7e45f50*/ void Internal_Create(UnityEngine.Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        static /*0x7e47198*/ void GenerateAtlasImpl(UnityEngine.Vector2[] sizes, int padding, int atlasSize, UnityEngine.Rect[] rect);
        static /*0x7e49780*/ UnityEngine.Texture2D CreateExternalTexture(int width, int height, UnityEngine.TextureFormat format, bool mipChain, bool linear, nint nativeTex);
        static /*0x7e4a13c*/ bool GenerateAtlas(UnityEngine.Vector2[] sizes, int padding, int atlasSize, System.Collections.Generic.List<UnityEngine.Rect> results);
        static /*0x7e454d4*/ UnityEngine.TextureFormat get_format_Injected(nint _unity_self);
        static /*0x7e45588*/ bool IgnoreMipmapLimit_Injected(nint _unity_self);
        static /*0x7e45644*/ void SetIgnoreMipmapLimitAndReload_Injected(nint _unity_self, bool value);
        static /*0x7e45784*/ void get_mipmapLimitGroup_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e45840*/ int get_activeMipmapLimit_Injected(nint _unity_self);
        static /*0x7e458e0*/ nint get_whiteTexture_Injected();
        static /*0x7e4596c*/ nint get_blackTexture_Injected();
        static /*0x7e459f8*/ nint get_redTexture_Injected();
        static /*0x7e45a84*/ nint get_grayTexture_Injected();
        static /*0x7e45b10*/ nint get_linearGrayTexture_Injected();
        static /*0x7e45b9c*/ nint get_normalTexture_Injected();
        static /*0x7e45c44*/ void Compress_Injected(nint _unity_self, bool highQuality);
        static /*0x7e45ea8*/ bool Internal_CreateImpl_Injected(UnityEngine.Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex, bool ignoreMipmapLimit, ref UnityEngine.Bindings.ManagedSpanWrapper mipmapLimitGroupName);
        static /*0x7e46040*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x7e460f4*/ bool get_vtOnly_Injected(nint _unity_self);
        static /*0x7e461c0*/ void ApplyImpl_Injected(nint _unity_self, bool updateMipmaps, bool makeNoLongerReadable);
        static /*0x7e462a4*/ bool ReinitializeImpl_Injected(nint _unity_self, int width, int height);
        static /*0x7e463b8*/ void SetPixelImpl_Injected(nint _unity_self, int image, int mip, int x, int y, ref UnityEngine.Color color);
        static /*0x7e464f0*/ void GetPixelImpl_Injected(nint _unity_self, int image, int mip, int x, int y, ref UnityEngine.Color ret);
        static /*0x7e46628*/ void GetPixelBilinearImpl_Injected(nint _unity_self, int image, int mip, float u, float v, ref UnityEngine.Color ret);
        static /*0x7e46744*/ bool ReinitializeWithFormatImpl_Injected(nint _unity_self, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap);
        static /*0x7e46858*/ bool ReinitializeWithTextureFormatImpl_Injected(nint _unity_self, int width, int height, UnityEngine.TextureFormat textureFormat, bool hasMipMap);
        static /*0x7e46974*/ void ReadPixelsImpl_Injected(nint _unity_self, ref UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps);
        static /*0x7e46b24*/ void SetPixelsImpl_Injected(nint _unity_self, int x, int y, int w, int h, ref UnityEngine.Bindings.ManagedSpanWrapper pixel, int miplevel, int frame);
        static /*0x7e46c40*/ bool LoadRawTextureDataImpl_Injected(nint _unity_self, nint data, ulong size);
        static /*0x7e46d94*/ bool LoadRawTextureDataImplArray_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper data);
        static /*0x7e46e88*/ bool SetPixelDataImplArray_Injected(nint _unity_self, System.Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);
        static /*0x7e46fac*/ bool SetPixelDataImpl_Injected(nint _unity_self, nint data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);
        static /*0x7e470a0*/ nint GetWritableImageData_Injected(nint _unity_self, int frame);
        static /*0x7e4715c*/ ulong GetImageDataSize_Injected(nint _unity_self);
        static /*0x7e4734c*/ void GenerateAtlasImpl_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper sizes, int padding, int atlasSize, ref UnityEngine.Bindings.BlittableArrayWrapper rect);
        static /*0x7e47420*/ bool get_isPreProcessed_Injected(nint _unity_self);
        static /*0x7e474d4*/ bool get_streamingMipmaps_Injected(nint _unity_self);
        static /*0x7e47588*/ int get_streamingMipmapsPriority_Injected(nint _unity_self);
        static /*0x7e4763c*/ int get_requestedMipmapLevel_Injected(nint _unity_self);
        static /*0x7e476f8*/ void set_requestedMipmapLevel_Injected(nint _unity_self, int value);
        static /*0x7e477b4*/ int get_minimumMipmapLevel_Injected(nint _unity_self);
        static /*0x7e47870*/ void set_minimumMipmapLevel_Injected(nint _unity_self, int value);
        static /*0x7e4792c*/ bool get_loadAllMips_Injected(nint _unity_self);
        static /*0x7e479e8*/ void set_loadAllMips_Injected(nint _unity_self, bool value);
        static /*0x7e47aa4*/ int get_calculatedMipmapLevel_Injected(nint _unity_self);
        static /*0x7e47b58*/ int get_desiredMipmapLevel_Injected(nint _unity_self);
        static /*0x7e47c0c*/ int get_loadingMipmapLevel_Injected(nint _unity_self);
        static /*0x7e47cc0*/ int get_loadedMipmapLevel_Injected(nint _unity_self);
        static /*0x7e47d74*/ void ClearRequestedMipmapLevel_Injected(nint _unity_self);
        static /*0x7e47e28*/ bool IsRequestedMipmapLevelLoaded_Injected(nint _unity_self);
        static /*0x7e47edc*/ void ClearMinimumMipmapLevel_Injected(nint _unity_self);
        static /*0x7e47f98*/ void UpdateExternalTexture_Injected(nint _unity_self, nint nativeTex);
        static /*0x7e480e8*/ void SetAllPixels32_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, int miplevel);
        static /*0x7e48278*/ void SetBlockOfPixels32_Injected(nint _unity_self, int x, int y, int blockWidth, int blockHeight, ref UnityEngine.Bindings.ManagedSpanWrapper colors, int miplevel);
        static /*0x7e48374*/ byte[] GetRawTextureData_Injected(nint _unity_self);
        static /*0x7e48460*/ UnityEngine.Color[] GetPixels_Injected(nint _unity_self, int x, int y, int blockWidth, int blockHeight, int miplevel);
        static /*0x7e4855c*/ UnityEngine.Color32[] GetPixels32_Injected(nint _unity_self, int miplevel);
        static /*0x7e48650*/ UnityEngine.Rect[] PackTextures_Injected(nint _unity_self, UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable);
        static /*0x7e48784*/ void CopyPixels_Full_Injected(nint _unity_self, nint src);
        static /*0x7e4889c*/ void CopyPixels_Slice_Injected(nint _unity_self, nint src, int srcElement, int srcMip, int dstMip);
        static /*0x7e48a1c*/ void CopyPixels_Region_Injected(nint _unity_self, nint src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY);
        /*0x7e48ce4*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount, nint nativeTex, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e48e00*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e48ef0*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.DefaultFormat format, int mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e48f58*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.DefaultFormat format, int mipCount, string mipmapLimitGroupName, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e49004*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.DefaultFormat format, int mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e48e4c*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e4907c*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e490a8*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount, string mipmapLimitGroupName, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e49130*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e4915c*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, nint nativeTex, bool createUninitialized, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e49304*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x7e4932c*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized);
        /*0x7e49354*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e4936c*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        /*0x7e49400*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x7e494bc*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized);
        /*0x7e49584*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x7e4963c*/ Texture2D(int width, int height);
        /*0x7e4545c*/ UnityEngine.TextureFormat get_format();
        /*0x7e45510*/ bool IgnoreMipmapLimit();
        /*0x7e455c4*/ void SetIgnoreMipmapLimitAndReload(bool value);
        /*0x7e45688*/ string get_mipmapLimitGroup();
        /*0x7e457c8*/ int get_activeMipmapLimit();
        /*0x7e45bc4*/ void Compress(bool highQuality);
        /*0x7e45fc8*/ bool get_isReadable();
        /*0x7e4607c*/ bool get_vtOnly();
        /*0x7e46130*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e46214*/ bool ReinitializeImpl(int width, int height);
        /*0x7e462f8*/ void SetPixelImpl(int image, int mip, int x, int y, UnityEngine.Color color);
        /*0x7e4642c*/ UnityEngine.Color GetPixelImpl(int image, int mip, int x, int y);
        /*0x7e46564*/ UnityEngine.Color GetPixelBilinearImpl(int image, int mip, float u, float v);
        /*0x7e4669c*/ bool ReinitializeWithFormatImpl(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap);
        /*0x7e467b0*/ bool ReinitializeWithTextureFormatImpl(int width, int height, UnityEngine.TextureFormat textureFormat, bool hasMipMap);
        /*0x7e468c4*/ void ReadPixelsImpl(UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps);
        /*0x7e469e0*/ void SetPixelsImpl(int x, int y, int w, int h, UnityEngine.Color[] pixel, int miplevel, int frame);
        /*0x7e46bb0*/ bool LoadRawTextureDataImpl(nint data, ulong size);
        /*0x7e46c94*/ bool LoadRawTextureDataImplArray(byte[] data);
        /*0x7e46dd8*/ bool SetPixelDataImplArray(System.Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);
        /*0x7e46efc*/ bool SetPixelDataImpl(nint data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);
        /*0x7e47020*/ nint GetWritableImageData(int frame);
        /*0x7e470e4*/ ulong GetImageDataSize();
        /*0x7e473a8*/ bool get_isPreProcessed();
        /*0x7e4745c*/ bool get_streamingMipmaps();
        /*0x7e47510*/ int get_streamingMipmapsPriority();
        /*0x7e475c4*/ int get_requestedMipmapLevel();
        /*0x7e47678*/ void set_requestedMipmapLevel(int value);
        /*0x7e4773c*/ int get_minimumMipmapLevel();
        /*0x7e477f0*/ void set_minimumMipmapLevel(int value);
        /*0x7e478b4*/ bool get_loadAllMips();
        /*0x7e47968*/ void set_loadAllMips(bool value);
        /*0x7e47a2c*/ int get_calculatedMipmapLevel();
        /*0x7e47ae0*/ int get_desiredMipmapLevel();
        /*0x7e47b94*/ int get_loadingMipmapLevel();
        /*0x7e47c48*/ int get_loadedMipmapLevel();
        /*0x7e47cfc*/ void ClearRequestedMipmapLevel();
        /*0x7e47db0*/ bool IsRequestedMipmapLevelLoaded();
        /*0x7e47e64*/ void ClearMinimumMipmapLevel();
        /*0x7e47f18*/ void UpdateExternalTexture(nint nativeTex);
        /*0x7e47fdc*/ void SetAllPixels32(UnityEngine.Color32[] colors, int miplevel);
        /*0x7e4813c*/ void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color32[] colors, int miplevel);
        /*0x7e482fc*/ byte[] GetRawTextureData();
        /*0x7e483b0*/ UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel);
        /*0x7e484d4*/ UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight);
        /*0x7e484dc*/ UnityEngine.Color32[] GetPixels32(int miplevel);
        /*0x7e485a0*/ UnityEngine.Color32[] GetPixels32();
        /*0x7e485a8*/ UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable);
        /*0x7e486bc*/ UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize);
        /*0x7e486c4*/ UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, int padding);
        /*0x7e486d0*/ void CopyPixels_Full(UnityEngine.Texture src);
        /*0x7e487c8*/ void CopyPixels_Slice(UnityEngine.Texture src, int srcElement, int srcMip, int dstMip);
        /*0x7e48908*/ void CopyPixels_Region(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY);
        /*0x7e48acc*/ bool ValidateFormat(UnityEngine.TextureFormat format, int width, int height);
        /*0x7e48bac*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height);
        /*0x7e49878*/ void SetPixel(int x, int y, UnityEngine.Color color);
        /*0x7e49914*/ void SetPixel(int x, int y, UnityEngine.Color color, int mipLevel);
        /*0x7e499bc*/ void SetPixels(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color[] colors, int miplevel);
        /*0x7e49a60*/ void SetPixels(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color[] colors);
        /*0x7e49a68*/ void SetPixels(UnityEngine.Color[] colors, int miplevel);
        /*0x7e49ae0*/ void SetPixels(UnityEngine.Color[] colors);
        /*0x7e49b3c*/ UnityEngine.Color GetPixel(int x, int y);
        /*0x7e49ba8*/ UnityEngine.Color GetPixel(int x, int y, int mipLevel);
        /*0x7e49c20*/ UnityEngine.Color GetPixelBilinear(float u, float v);
        /*0x7e49c88*/ UnityEngine.Color GetPixelBilinear(float u, float v, int mipLevel);
        /*0x7e49cfc*/ void LoadRawTextureData(nint data, int size);
        /*0x7e49e14*/ void LoadRawTextureData(byte[] data);
        /*0x3907c14*/ void LoadRawTextureData<T>(Unity.Collections.NativeArray<T> data);
        void SetPixelData<T>(T[] data, int mipLevel, int sourceDataStartIndex);
        /*0x3907c14*/ void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, int sourceDataStartIndex);
        /*0x3907c14*/ Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel);
        /*0x3907c14*/ Unity.Collections.NativeArray<T> GetRawTextureData<T>();
        /*0x7e49f1c*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e49f80*/ void Apply(bool updateMipmaps);
        /*0x7e49f8c*/ void Apply();
        /*0x7e49f98*/ bool Reinitialize(int width, int height);
        /*0x7e49ffc*/ bool Reinitialize(int width, int height, UnityEngine.TextureFormat format, bool hasMipMap);
        /*0x7e4a004*/ bool Reinitialize(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap);
        /*0x7e4a080*/ bool Resize(int width, int height);
        /*0x7e4a084*/ bool Resize(int width, int height, UnityEngine.TextureFormat format, bool hasMipMap);
        /*0x7e4a08c*/ bool Resize(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap);
        /*0x7e4a094*/ void ReadPixels(UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps);
        /*0x7e4a134*/ void ReadPixels(UnityEngine.Rect source, int destX, int destY);
        /*0x7e4a2ec*/ void SetPixels32(UnityEngine.Color32[] colors, int miplevel);
        /*0x7e4a2f0*/ void SetPixels32(UnityEngine.Color32[] colors);
        /*0x7e4a2f8*/ void SetPixels32(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color32[] colors, int miplevel);
        /*0x7e4a2fc*/ void SetPixels32(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color32[] colors);
        /*0x7e4a304*/ UnityEngine.Color[] GetPixels(int miplevel);
        /*0x7e4a36c*/ UnityEngine.Color[] GetPixels();
        /*0x7e4a374*/ void CopyPixels(UnityEngine.Texture src);
        /*0x7e4a3f4*/ void CopyPixels(UnityEngine.Texture src, int srcElement, int srcMip, int dstMip);
        /*0x7e4a494*/ void CopyPixels(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY);
        /*0x7e4a57c*/ bool get_ignoreMipmapLimit();
        /*0x7e4a580*/ void set_ignoreMipmapLimit(bool value);
    }

    class Cubemap : UnityEngine.Texture
    {
        static /*0x7e4a690*/ bool Internal_CreateImpl(UnityEngine.Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x7e4a714*/ void Internal_Create(UnityEngine.Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x7e4c6c0*/ UnityEngine.Cubemap CreateExternalTexture(int width, UnityEngine.TextureFormat format, bool mipmap, nint nativeTex);
        static /*0x7e4c3c4*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x7e4a654*/ UnityEngine.TextureFormat get_format_Injected(nint _unity_self);
        static /*0x7e4a878*/ void ApplyImpl_Injected(nint _unity_self, bool updateMipmaps, bool makeNoLongerReadable);
        static /*0x7e4a94c*/ void UpdateExternalTexture_Injected(nint _unity_self, nint nativeTexture);
        static /*0x7e4aa08*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x7e4ab04*/ void SetPixelImpl_Injected(nint _unity_self, int image, int mip, int x, int y, ref UnityEngine.Color color);
        static /*0x7e4ac3c*/ void GetPixelImpl_Injected(nint _unity_self, int image, int mip, int x, int y, ref UnityEngine.Color ret);
        static /*0x7e4ad30*/ void SmoothEdges_Injected(nint _unity_self, int smoothRegionWidthInPixels);
        static /*0x7e4ae0c*/ UnityEngine.Color[] GetPixels_Injected(nint _unity_self, UnityEngine.CubemapFace face, int miplevel);
        static /*0x7e4af7c*/ void SetPixels_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, UnityEngine.CubemapFace face, int miplevel);
        static /*0x7e4b098*/ bool SetPixelDataImplArray_Injected(nint _unity_self, System.Array data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);
        static /*0x7e4b1dc*/ bool SetPixelDataImpl_Injected(nint _unity_self, nint data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);
        static /*0x7e4b31c*/ void CopyPixels_Full_Injected(nint _unity_self, nint src);
        static /*0x7e4b444*/ void CopyPixels_Slice_Injected(nint _unity_self, nint src, int srcElement, int srcMip, int dstFace, int dstMip);
        static /*0x7e4b5d4*/ void CopyPixels_Region_Injected(nint _unity_self, nint src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstFace, int dstMip, int dstX, int dstY);
        static /*0x7e4b714*/ nint GetWritableImageData_Injected(nint _unity_self, int frame);
        static /*0x7e4b7d0*/ bool get_isPreProcessed_Injected(nint _unity_self);
        static /*0x7e4b884*/ bool get_streamingMipmaps_Injected(nint _unity_self);
        static /*0x7e4b938*/ int get_streamingMipmapsPriority_Injected(nint _unity_self);
        static /*0x7e4b9ec*/ int get_requestedMipmapLevel_Injected(nint _unity_self);
        static /*0x7e4baa8*/ void set_requestedMipmapLevel_Injected(nint _unity_self, int value);
        static /*0x7e4bb64*/ bool get_loadAllMips_Injected(nint _unity_self);
        static /*0x7e4bc20*/ void set_loadAllMips_Injected(nint _unity_self, bool value);
        static /*0x7e4bcdc*/ int get_desiredMipmapLevel_Injected(nint _unity_self);
        static /*0x7e4bd90*/ int get_loadingMipmapLevel_Injected(nint _unity_self);
        static /*0x7e4be44*/ int get_loadedMipmapLevel_Injected(nint _unity_self);
        static /*0x7e4bef8*/ void ClearRequestedMipmapLevel_Injected(nint _unity_self);
        static /*0x7e4bfac*/ bool IsRequestedMipmapLevelLoaded_Injected(nint _unity_self);
        /*0x7e4c1d8*/ Cubemap(int width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e4c29c*/ Cubemap(int width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e4c214*/ Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e4c2e8*/ Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e4c418*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex, bool createUninitialized);
        /*0x7e4c574*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x7e4c608*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, bool mipChain, bool createUninitialized);
        /*0x7e4c6a8*/ Cubemap(int width, UnityEngine.TextureFormat format, int mipCount);
        /*0x7e4c6b4*/ Cubemap(int width, UnityEngine.TextureFormat format, int mipCount, bool createUninitialized);
        /*0x7e4a5dc*/ UnityEngine.TextureFormat get_format();
        /*0x7e4a7e8*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e4a8cc*/ void UpdateExternalTexture(nint nativeTexture);
        /*0x7e4a990*/ bool get_isReadable();
        /*0x7e4aa44*/ void SetPixelImpl(int image, int mip, int x, int y, UnityEngine.Color color);
        /*0x7e4ab78*/ UnityEngine.Color GetPixelImpl(int image, int mip, int x, int y);
        /*0x7e4acb0*/ void SmoothEdges(int smoothRegionWidthInPixels);
        /*0x7e4ad74*/ void SmoothEdges();
        /*0x7e4ad7c*/ UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace face, int miplevel);
        /*0x7e4ae60*/ UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace face);
        /*0x7e4ae68*/ void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, int miplevel);
        /*0x7e4afd8*/ bool SetPixelDataImplArray(System.Array data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);
        /*0x7e4b11c*/ bool SetPixelDataImpl(nint data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);
        /*0x7e4b260*/ void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face);
        /*0x7e4b268*/ void CopyPixels_Full(UnityEngine.Texture src);
        /*0x7e4b360*/ void CopyPixels_Slice(UnityEngine.Texture src, int srcElement, int srcMip, int dstFace, int dstMip);
        /*0x7e4b4b8*/ void CopyPixels_Region(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstFace, int dstMip, int dstX, int dstY);
        /*0x7e4b694*/ nint GetWritableImageData(int frame);
        /*0x7e4b758*/ bool get_isPreProcessed();
        /*0x7e4b80c*/ bool get_streamingMipmaps();
        /*0x7e4b8c0*/ int get_streamingMipmapsPriority();
        /*0x7e4b974*/ int get_requestedMipmapLevel();
        /*0x7e4ba28*/ void set_requestedMipmapLevel(int value);
        /*0x7e4baec*/ bool get_loadAllMips();
        /*0x7e4bba0*/ void set_loadAllMips(bool value);
        /*0x7e4bc64*/ int get_desiredMipmapLevel();
        /*0x7e4bd18*/ int get_loadingMipmapLevel();
        /*0x7e4bdcc*/ int get_loadedMipmapLevel();
        /*0x7e4be80*/ void ClearRequestedMipmapLevel();
        /*0x7e4bf34*/ bool IsRequestedMipmapLevelLoaded();
        /*0x7e4bfe8*/ bool ValidateFormat(UnityEngine.TextureFormat format, int width);
        /*0x7e4c0bc*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width);
        void SetPixelData<T>(T[] data, int mipLevel, UnityEngine.CubemapFace face, int sourceDataStartIndex);
        /*0x3907c14*/ void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, UnityEngine.CubemapFace face, int sourceDataStartIndex);
        /*0x3907c14*/ Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel, UnityEngine.CubemapFace face);
        /*0x7e4c7c4*/ void SetPixel(UnityEngine.CubemapFace face, int x, int y, UnityEngine.Color color);
        /*0x7e4c7cc*/ void SetPixel(UnityEngine.CubemapFace face, int x, int y, UnityEngine.Color color, int mip);
        /*0x7e4c878*/ UnityEngine.Color GetPixel(UnityEngine.CubemapFace face, int x, int y);
        /*0x7e4c880*/ UnityEngine.Color GetPixel(UnityEngine.CubemapFace face, int x, int y, int mip);
        /*0x7e4c8fc*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e4c960*/ void Apply(bool updateMipmaps);
        /*0x7e4c96c*/ void Apply();
        /*0x7e4c978*/ void CopyPixels(UnityEngine.Texture src);
        /*0x7e4c9f8*/ void CopyPixels(UnityEngine.Texture src, int srcElement, int srcMip, UnityEngine.CubemapFace dstFace, int dstMip);
        /*0x7e4caa8*/ void CopyPixels(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, UnityEngine.CubemapFace dstFace, int dstMip, int dstX, int dstY);
    }

    class Texture3D : UnityEngine.Texture
    {
        static /*0x7e4ce3c*/ bool Internal_CreateImpl(UnityEngine.Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x7e4ced8*/ void Internal_Create(UnityEngine.Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x7e4d508*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x7e4cc18*/ int get_depth_Injected(nint _unity_self);
        static /*0x7e4cccc*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x7e4cdc8*/ void SetPixelImpl_Injected(nint _unity_self, int mip, int x, int y, int z, ref UnityEngine.Color color);
        static /*0x7e4d05c*/ void ApplyImpl_Injected(nint _unity_self, bool updateMipmaps, bool makeNoLongerReadable);
        static /*0x7e4d1bc*/ void SetPixels_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, int miplevel);
        static /*0x7e4d288*/ nint GetImageData_Injected(nint _unity_self);
        /*0x7e4d2c4*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e4d3b8*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e4d318*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e4d41c*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e4d55c*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount);
        /*0x7e4d57c*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex);
        /*0x7e4d598*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex, bool createUninitialized);
        /*0x7e4d6fc*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x7e4d7b4*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, bool createUninitialized);
        /*0x7e4d878*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, nint nativeTex);
        /*0x7e4cba0*/ int get_depth();
        /*0x7e4cc54*/ bool get_isReadable();
        /*0x7e4cd08*/ void SetPixelImpl(int mip, int x, int y, int z, UnityEngine.Color color);
        /*0x7e4cfcc*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e4d0b0*/ void SetPixels(UnityEngine.Color[] colors, int miplevel);
        /*0x7e4d210*/ nint GetImageData();
        /*0x7e4d93c*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e4d9a0*/ void Apply(bool updateMipmaps);
        /*0x7e4d9ac*/ void Apply();
        /*0x7e4d9b8*/ void SetPixel(int x, int y, int z, UnityEngine.Color color, int mipLevel);
        /*0x3907c14*/ Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel);
    }

    class Texture2DArray : UnityEngine.Texture
    {
        static /*0x7e4da64*/ int get_allSlices();
        static /*0x7e4db40*/ bool Internal_CreateImpl(UnityEngine.Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        static /*0x7e4ddcc*/ void Internal_Create(UnityEngine.Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        static /*0x7e4e380*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x7e4db04*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x7e4dd24*/ bool Internal_CreateImpl_Injected(UnityEngine.Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, bool ignoreMipmapLimit, ref UnityEngine.Bindings.ManagedSpanWrapper mipmapLimitGroupName);
        /*0x7e4e05c*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e4e160*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e4e1f0*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e4e0b0*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e4e1d4*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e4e264*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e4e3d4*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e4e580*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized);
        /*0x7e4e5a4*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x7e4e5c8*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized);
        /*0x7e4e694*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x7e4e75c*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x7e4da8c*/ bool get_isReadable();
        /*0x7e4de44*/ bool ValidateFormat(UnityEngine.TextureFormat format, int width, int height);
        /*0x7e4df24*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height);
    }

    class CubemapArray : UnityEngine.Texture
    {
        static /*0x7e4e8cc*/ bool Internal_CreateImpl(UnityEngine.CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x7e4e950*/ void Internal_Create(UnityEngine.CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x7e4eebc*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x7e4e890*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x7e4eab4*/ void ApplyImpl_Injected(nint _unity_self, bool updateMipmaps, bool makeNoLongerReadable);
        static /*0x7e4ec2c*/ void SetPixels_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, UnityEngine.CubemapFace face, int arrayElement, int miplevel);
        /*0x7e4eca0*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e4ed7c*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e4ecec*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e4edd0*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e4ef10*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized);
        /*0x7e4f07c*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x7e4f088*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized);
        /*0x7e4f13c*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x7e4f1e4*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x7e4e818*/ bool get_isReadable();
        /*0x7e4ea24*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e4eb08*/ void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, int arrayElement, int miplevel);
        /*0x7e4ec98*/ void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, int arrayElement);
        /*0x7e4f288*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e4f2ec*/ void Apply();
    }

    class RenderTexture : UnityEngine.Texture
    {
        static /*0x7e505f8*/ UnityEngine.RenderTexture GetActive();
        static /*0x7e50684*/ void SetActive(UnityEngine.RenderTexture rt);
        static /*0x7e50744*/ UnityEngine.RenderTexture get_active();
        static /*0x7e50748*/ void set_active(UnityEngine.RenderTexture value);
        static /*0x7e50d64*/ void Internal_Create(UnityEngine.RenderTexture rt);
        static /*0x7e50ea8*/ UnityEngine.RenderTexture GetTemporary_Internal(UnityEngine.RenderTextureDescriptor desc);
        static /*0x7e50f50*/ void ReleaseTemporary(UnityEngine.RenderTexture temp);
        static /*0x7e51be4*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat);
        static /*0x7e52120*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.RenderTextureFormat format, bool disableFallback);
        static /*0x7e52344*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Experimental.Rendering.DefaultFormat format);
        static /*0x7e52350*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Rendering.ShadowSamplingMode shadowSamplingMode);
        static /*0x7e5216c*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap);
        static /*0x7e51124*/ void ValidateRenderTextureDesc(ref UnityEngine.RenderTextureDescriptor desc);
        static /*0x7e517f4*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultColorFormat(UnityEngine.Experimental.Rendering.DefaultFormat format);
        static /*0x7e51810*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultDepthStencilFormat(UnityEngine.Experimental.Rendering.DefaultFormat format, int depth);
        static /*0x7e5215c*/ UnityEngine.Rendering.ShadowSamplingMode GetShadowSamplingModeForFormat(UnityEngine.RenderTextureFormat format);
        static /*0x7e519b8*/ UnityEngine.Rendering.ShadowSamplingMode GetShadowSamplingModeForFormat(UnityEngine.Experimental.Rendering.DefaultFormat format);
        static /*0x7e52284*/ void WarnAboutFallbackTo16BitsDepth(UnityEngine.RenderTextureFormat format);
        static /*0x7e51fcc*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.RenderTextureFormat renderTextureFormat, UnityEngine.RenderTextureReadWrite readWrite);
        static /*0x7e523e0*/ UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc);
        static /*0x7e52444*/ UnityEngine.RenderTexture GetTemporaryImpl(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale, UnityEngine.Rendering.ShadowSamplingMode shadowSamplingMode);
        static /*0x7e525e8*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale);
        static /*0x7e52668*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage);
        static /*0x7e526e4*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode);
        static /*0x7e52754*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing);
        static /*0x7e527c0*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format);
        static /*0x7e52820*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale);
        static /*0x7e528c4*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage);
        static /*0x7e528e0*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode);
        static /*0x7e52900*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing);
        static /*0x7e52924*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
        static /*0x7e5294c*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format);
        static /*0x7e4f370*/ int get_width_Injected(nint _unity_self);
        static /*0x7e4f42c*/ void set_width_Injected(nint _unity_self, int value);
        static /*0x7e4f4e8*/ int get_height_Injected(nint _unity_self);
        static /*0x7e4f5a4*/ void set_height_Injected(nint _unity_self, int value);
        static /*0x7e4f660*/ UnityEngine.Rendering.TextureDimension get_dimension_Injected(nint _unity_self);
        static /*0x7e4f71c*/ void set_dimension_Injected(nint _unity_self, UnityEngine.Rendering.TextureDimension value);
        static /*0x7e4f7e0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetColorFormat_Injected(nint _unity_self, bool suppressWarnings);
        static /*0x7e4f8a4*/ void SetColorFormat_Injected(nint _unity_self, UnityEngine.Experimental.Rendering.GraphicsFormat format);
        static /*0x7e4f96c*/ bool get_useMipMap_Injected(nint _unity_self);
        static /*0x7e4fa28*/ void set_useMipMap_Injected(nint _unity_self, bool value);
        static /*0x7e4fae4*/ bool get_sRGB_Injected(nint _unity_self);
        static /*0x7e4fcfc*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat_Injected(nint _unity_self);
        static /*0x7e4fdb8*/ void set_depthStencilFormat_Injected(nint _unity_self, UnityEngine.Experimental.Rendering.GraphicsFormat value);
        static /*0x7e4fe7c*/ void set_autoGenerateMips_Injected(nint _unity_self, bool value);
        static /*0x7e4ff38*/ int get_volumeDepth_Injected(nint _unity_self);
        static /*0x7e4fff4*/ void set_volumeDepth_Injected(nint _unity_self, int value);
        static /*0x7e500b0*/ int get_antiAliasing_Injected(nint _unity_self);
        static /*0x7e50164*/ bool get_bindTextureMS_Injected(nint _unity_self);
        static /*0x7e50218*/ bool get_enableRandomWrite_Injected(nint _unity_self);
        static /*0x7e502d4*/ void set_enableRandomWrite_Injected(nint _unity_self, bool value);
        static /*0x7e50390*/ bool get_useDynamicScale_Injected(nint _unity_self);
        static /*0x7e5044c*/ void set_useDynamicScale_Injected(nint _unity_self, bool value);
        static /*0x7e50508*/ bool get_useDynamicScaleExplicit_Injected(nint _unity_self);
        static /*0x7e505bc*/ void ApplyDynamicScale_Injected(nint _unity_self);
        static /*0x7e5065c*/ nint GetActive_Injected();
        static /*0x7e50708*/ void SetActive_Injected(nint rt);
        static /*0x7e507dc*/ void GetColorBuffer_Injected(nint _unity_self, ref UnityEngine.RenderBuffer ret);
        static /*0x7e508b0*/ void GetDepthBuffer_Injected(nint _unity_self, ref UnityEngine.RenderBuffer ret);
        static /*0x7e50974*/ void SetMipMapCount_Injected(nint _unity_self, int count);
        static /*0x7e50a38*/ void SetShadowSamplingMode_Injected(nint _unity_self, UnityEngine.Rendering.ShadowSamplingMode samplingMode);
        static /*0x7e50afc*/ bool Create_Injected(nint _unity_self);
        static /*0x7e50bb0*/ void Release_Injected(nint _unity_self);
        static /*0x7e50c64*/ bool IsCreated_Injected(nint _unity_self);
        static /*0x7e50d20*/ void SetSRGBReadWrite_Injected(nint _unity_self, bool srgb);
        static /*0x7e50e20*/ void SetRenderTextureDescriptor_Injected(nint _unity_self, ref UnityEngine.RenderTextureDescriptor desc);
        static /*0x7e50e64*/ void GetDescriptor_Injected(nint _unity_self, ref UnityEngine.RenderTextureDescriptor ret);
        static /*0x7e50f14*/ nint GetTemporary_Internal_Injected(ref UnityEngine.RenderTextureDescriptor desc);
        static /*0x7e50fd4*/ void ReleaseTemporary_Injected(nint temp);
        /*0x7e51010*/ RenderTexture();
        /*0x7e51064*/ RenderTexture(UnityEngine.RenderTextureDescriptor desc);
        /*0x7e514ec*/ RenderTexture(UnityEngine.RenderTexture textureToCopy);
        /*0x7e516c0*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format);
        /*0x7e519c8*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x7e51a58*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount);
        /*0x7e51838*/ RenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount);
        /*0x7e51bec*/ RenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
        /*0x7e51c7c*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
        /*0x7e51e94*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format);
        /*0x7e51fc4*/ RenderTexture(int width, int height, int depth);
        /*0x7e51f24*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format, int mipCount);
        /*0x7e4f2f8*/ int get_width();
        /*0x7e4f3ac*/ void set_width(int value);
        /*0x7e4f470*/ int get_height();
        /*0x7e4f524*/ void set_height(int value);
        /*0x7e4f5e8*/ UnityEngine.Rendering.TextureDimension get_dimension();
        /*0x7e4f69c*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
        /*0x7e4f760*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetColorFormat(bool suppressWarnings);
        /*0x7e4f824*/ void SetColorFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x7e4f8e8*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x7e4f8f0*/ void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x7e4f8f4*/ bool get_useMipMap();
        /*0x7e4f9a8*/ void set_useMipMap(bool value);
        /*0x7e4fa6c*/ bool get_sRGB();
        /*0x7e4fb20*/ UnityEngine.RenderTextureFormat get_format();
        /*0x7e4fc84*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat();
        /*0x7e4fd38*/ void set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x7e4fdfc*/ void set_autoGenerateMips(bool value);
        /*0x7e4fec0*/ int get_volumeDepth();
        /*0x7e4ff74*/ void set_volumeDepth(int value);
        /*0x7e50038*/ int get_antiAliasing();
        /*0x7e500ec*/ bool get_bindTextureMS();
        /*0x7e501a0*/ bool get_enableRandomWrite();
        /*0x7e50254*/ void set_enableRandomWrite(bool value);
        /*0x7e50318*/ bool get_useDynamicScale();
        /*0x7e503cc*/ void set_useDynamicScale(bool value);
        /*0x7e50490*/ bool get_useDynamicScaleExplicit();
        /*0x7e50544*/ void ApplyDynamicScale();
        /*0x7e5074c*/ UnityEngine.RenderBuffer GetColorBuffer();
        /*0x7e50820*/ UnityEngine.RenderBuffer GetDepthBuffer();
        /*0x7e508f4*/ void SetMipMapCount(int count);
        /*0x7e509b8*/ void SetShadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode samplingMode);
        /*0x7e50a7c*/ UnityEngine.RenderBuffer get_colorBuffer();
        /*0x7e50a80*/ UnityEngine.RenderBuffer get_depthBuffer();
        /*0x7e50a84*/ bool Create();
        /*0x7e50b38*/ void Release();
        /*0x7e50bec*/ bool IsCreated();
        /*0x7e50ca0*/ void SetSRGBReadWrite(bool srgb);
        /*0x7e50da0*/ void SetRenderTextureDescriptor(UnityEngine.RenderTextureDescriptor desc);
        /*0x7e4fbd0*/ UnityEngine.RenderTextureDescriptor GetDescriptor();
        /*0x7e51d24*/ void Initialize(int width, int height, int depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int mipCount);
        /*0x7e51678*/ UnityEngine.RenderTextureDescriptor get_descriptor();
    }

    struct CustomRenderTextureUpdateZone
    {
        /*0x10*/ UnityEngine.Vector3 updateZoneCenter;
        /*0x1c*/ UnityEngine.Vector3 updateZoneSize;
        /*0x28*/ float rotation;
        /*0x2c*/ int passIndex;
        /*0x30*/ bool needSwap;
    }

    class CustomRenderTexture : UnityEngine.RenderTexture
    {
        static /*0x7e52978*/ void Internal_CreateCustomRenderTexture(UnityEngine.CustomRenderTexture rt);
        static /*0x7e52a34*/ void TriggerUpdate_Injected(nint _unity_self, int count);
        static /*0x7e52b40*/ void TriggerInitialization_Injected(nint _unity_self);
        static /*0x7e52c10*/ void ClearUpdateZones_Injected(nint _unity_self);
        static /*0x7e52ce0*/ nint get_material_Injected(nint _unity_self);
        static /*0x7e52dd0*/ void set_material_Injected(nint _unity_self, nint value);
        static /*0x7e52ea8*/ nint get_initializationMaterial_Injected(nint _unity_self);
        static /*0x7e52f98*/ void set_initializationMaterial_Injected(nint _unity_self, nint value);
        static /*0x7e53070*/ nint get_initializationTexture_Injected(nint _unity_self);
        static /*0x7e53160*/ void set_initializationTexture_Injected(nint _unity_self, nint value);
        static /*0x7e53254*/ void GetUpdateZonesInternal_Injected(nint _unity_self, object updateZones);
        static /*0x7e53398*/ void SetUpdateZonesInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper updateZones);
        static /*0x7e53470*/ nint GetDoubleBufferRenderTexture_Injected(nint _unity_self);
        static /*0x7e53524*/ void EnsureDoubleBufferConsistency_Injected(nint _unity_self);
        static /*0x7e5362c*/ UnityEngine.CustomRenderTextureInitializationSource get_initializationSource_Injected(nint _unity_self);
        static /*0x7e536e8*/ void set_initializationSource_Injected(nint _unity_self, UnityEngine.CustomRenderTextureInitializationSource value);
        static /*0x7e537c0*/ void get_initializationColor_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x7e53894*/ void set_initializationColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x7e53950*/ UnityEngine.CustomRenderTextureUpdateMode get_updateMode_Injected(nint _unity_self);
        static /*0x7e53a0c*/ void set_updateMode_Injected(nint _unity_self, UnityEngine.CustomRenderTextureUpdateMode value);
        static /*0x7e53ac8*/ UnityEngine.CustomRenderTextureUpdateMode get_initializationMode_Injected(nint _unity_self);
        static /*0x7e53b84*/ void set_initializationMode_Injected(nint _unity_self, UnityEngine.CustomRenderTextureUpdateMode value);
        static /*0x7e53c40*/ UnityEngine.CustomRenderTextureUpdateZoneSpace get_updateZoneSpace_Injected(nint _unity_self);
        static /*0x7e53cfc*/ void set_updateZoneSpace_Injected(nint _unity_self, UnityEngine.CustomRenderTextureUpdateZoneSpace value);
        static /*0x7e53db8*/ int get_shaderPass_Injected(nint _unity_self);
        static /*0x7e53e74*/ void set_shaderPass_Injected(nint _unity_self, int value);
        static /*0x7e53f30*/ uint get_cubemapFaceMask_Injected(nint _unity_self);
        static /*0x7e53fec*/ void set_cubemapFaceMask_Injected(nint _unity_self, uint value);
        static /*0x7e540a8*/ bool get_doubleBuffered_Injected(nint _unity_self);
        static /*0x7e54164*/ void set_doubleBuffered_Injected(nint _unity_self, bool value);
        static /*0x7e54220*/ bool get_wrapUpdateZones_Injected(nint _unity_self);
        static /*0x7e542dc*/ void set_wrapUpdateZones_Injected(nint _unity_self, bool value);
        static /*0x7e54398*/ float get_updatePeriod_Injected(nint _unity_self);
        static /*0x7e5445c*/ void set_updatePeriod_Injected(nint _unity_self, float value);
        /*0x7e544a8*/ CustomRenderTexture(int width, int height, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
        /*0x7e54680*/ CustomRenderTexture(int width, int height, UnityEngine.RenderTextureFormat format);
        /*0x7e54688*/ CustomRenderTexture(int width, int height);
        /*0x7e546c4*/ CustomRenderTexture(int width, int height, UnityEngine.Experimental.Rendering.DefaultFormat defaultFormat);
        /*0x7e54570*/ CustomRenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x7e529b4*/ void TriggerUpdate(int count);
        /*0x7e52a78*/ void Update(int count);
        /*0x7e52aa4*/ void Update();
        /*0x7e52ac8*/ void TriggerInitialization();
        /*0x7e52b7c*/ void Initialize();
        /*0x7e52b98*/ void ClearUpdateZones();
        /*0x7e52c4c*/ UnityEngine.Material get_material();
        /*0x7e52d1c*/ void set_material(UnityEngine.Material value);
        /*0x7e52e14*/ UnityEngine.Material get_initializationMaterial();
        /*0x7e52ee4*/ void set_initializationMaterial(UnityEngine.Material value);
        /*0x7e52fdc*/ UnityEngine.Texture get_initializationTexture();
        /*0x7e530ac*/ void set_initializationTexture(UnityEngine.Texture value);
        /*0x7e531a4*/ void GetUpdateZonesInternal(object updateZones);
        /*0x7e53298*/ void GetUpdateZones(System.Collections.Generic.List<UnityEngine.CustomRenderTextureUpdateZone> updateZones);
        /*0x7e5329c*/ void SetUpdateZonesInternal(UnityEngine.CustomRenderTextureUpdateZone[] updateZones);
        /*0x7e533dc*/ UnityEngine.RenderTexture GetDoubleBufferRenderTexture();
        /*0x7e534ac*/ void EnsureDoubleBufferConsistency();
        /*0x7e53560*/ void SetUpdateZones(UnityEngine.CustomRenderTextureUpdateZone[] updateZones);
        /*0x7e535b4*/ UnityEngine.CustomRenderTextureInitializationSource get_initializationSource();
        /*0x7e53668*/ void set_initializationSource(UnityEngine.CustomRenderTextureInitializationSource value);
        /*0x7e5372c*/ UnityEngine.Color get_initializationColor();
        /*0x7e53804*/ void set_initializationColor(UnityEngine.Color value);
        /*0x7e538d8*/ UnityEngine.CustomRenderTextureUpdateMode get_updateMode();
        /*0x7e5398c*/ void set_updateMode(UnityEngine.CustomRenderTextureUpdateMode value);
        /*0x7e53a50*/ UnityEngine.CustomRenderTextureUpdateMode get_initializationMode();
        /*0x7e53b04*/ void set_initializationMode(UnityEngine.CustomRenderTextureUpdateMode value);
        /*0x7e53bc8*/ UnityEngine.CustomRenderTextureUpdateZoneSpace get_updateZoneSpace();
        /*0x7e53c7c*/ void set_updateZoneSpace(UnityEngine.CustomRenderTextureUpdateZoneSpace value);
        /*0x7e53d40*/ int get_shaderPass();
        /*0x7e53df4*/ void set_shaderPass(int value);
        /*0x7e53eb8*/ uint get_cubemapFaceMask();
        /*0x7e53f6c*/ void set_cubemapFaceMask(uint value);
        /*0x7e54030*/ bool get_doubleBuffered();
        /*0x7e540e4*/ void set_doubleBuffered(bool value);
        /*0x7e541a8*/ bool get_wrapUpdateZones();
        /*0x7e5425c*/ void set_wrapUpdateZones(bool value);
        /*0x7e54320*/ float get_updatePeriod();
        /*0x7e543d4*/ void set_updatePeriod(float value);
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

        /*0x7e54af8*/ RenderTextureDescriptor(int width, int height);
        /*0x7e54b04*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat);
        /*0x7e54b0c*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits);
        /*0x7e54ba8*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits);
        /*0x7e54ba0*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits, int mipCount);
        /*0x7e54ca4*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits, int mipCount, UnityEngine.RenderTextureReadWrite readWrite);
        /*0x7e54c38*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits, int mipCount);
        /*0x7e52508*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
        /*0x7e54d7c*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount);
        /*0x7e54764*/ int get_width();
        /*0x7e5476c*/ void set_width(int value);
        /*0x7e54774*/ int get_height();
        /*0x7e5477c*/ void set_height(int value);
        /*0x7e54784*/ int get_msaaSamples();
        /*0x7e5478c*/ void set_msaaSamples(int value);
        /*0x7e54794*/ int get_volumeDepth();
        /*0x7e5479c*/ void set_volumeDepth(int value);
        /*0x7e547a4*/ int get_mipCount();
        /*0x7e547ac*/ void set_mipCount(int value);
        /*0x7e5235c*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x7e547b4*/ void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x7e54858*/ void set_stencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x7e54860*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat();
        /*0x7e54868*/ void set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x7e52364*/ UnityEngine.RenderTextureFormat get_colorFormat();
        /*0x7e54870*/ void set_colorFormat(UnityEngine.RenderTextureFormat value);
        /*0x7e54930*/ bool get_sRGB();
        /*0x7e549e8*/ void set_sRGB(bool value);
        /*0x7e5498c*/ int get_depthBufferBits();
        /*0x7e54a8c*/ void set_depthBufferBits(int value);
        /*0x7e54ab8*/ UnityEngine.Rendering.TextureDimension get_dimension();
        /*0x7e54ac0*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
        /*0x7e54ac8*/ UnityEngine.Rendering.ShadowSamplingMode get_shadowSamplingMode();
        /*0x7e54ad0*/ void set_shadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode value);
        /*0x7e54ad8*/ UnityEngine.VRTextureUsage get_vrUsage();
        /*0x7e54ae0*/ void set_vrUsage(UnityEngine.VRTextureUsage value);
        /*0x7e54ae8*/ UnityEngine.RenderTextureMemoryless get_memoryless();
        /*0x7e54af0*/ void set_memoryless(UnityEngine.RenderTextureMemoryless value);
        /*0x7e5483c*/ void SetOrClearRenderTextureCreationFlag(bool value, UnityEngine.RenderTextureCreationFlags flag);
        /*0x7e54ddc*/ bool get_useMipMap();
        /*0x7e54de8*/ void set_useMipMap(bool value);
        /*0x7e54df8*/ bool get_autoGenerateMips();
        /*0x7e54e04*/ void set_autoGenerateMips(bool value);
        /*0x7e54e24*/ bool get_enableRandomWrite();
        /*0x7e54e30*/ void set_enableRandomWrite(bool value);
        /*0x7e54e50*/ bool get_bindMS();
        /*0x7e54e5c*/ void set_bindMS(bool value);
        /*0x7e52424*/ void set_createdFromScript(bool value);
        /*0x7e54e7c*/ bool get_useDynamicScale();
        /*0x7e525c8*/ void set_useDynamicScale(bool value);
        /*0x7e54e88*/ bool get_useDynamicScaleExplicit();
        /*0x7e54e94*/ void set_useDynamicScaleExplicit(bool value);
    }

    struct MipmapLimitDescriptor
    {
        /*0x10*/ bool <useMipmapLimit>k__BackingField;
        /*0x18*/ string <groupName>k__BackingField;

        /*0x7e48ff0*/ MipmapLimitDescriptor(bool useMipmapLimit, string groupName);
        /*0x7e54eb4*/ bool get_useMipmapLimit();
        /*0x7e54ebc*/ string get_groupName();
    }

    struct Hash128 : System.IComparable, System.IComparable<UnityEngine.Hash128>, System.IEquatable<UnityEngine.Hash128>
    {
        static ulong kConst = 16045690984833335023;
        /*0x10*/ ulong u64_0;
        /*0x18*/ ulong u64_1;

        static /*0x7e55074*/ UnityEngine.Hash128 Parse(string hashString);
        static /*0x7e54fb8*/ string Hash128ToStringImpl(UnityEngine.Hash128 hash);
        static /*0x7e55270*/ void ComputeFromString(string data, ref UnityEngine.Hash128 hash);
        static /*0x7e55424*/ void ComputeFromPtr(nint data, int start, int count, int elemSize, ref UnityEngine.Hash128 hash);
        static /*0x7e55490*/ UnityEngine.Hash128 Compute(string data);
        static UnityEngine.Hash128 Compute<T>(ref T val);
        static /*0x7e554b4*/ UnityEngine.Hash128 Compute(int val);
        static /*0x7e555e8*/ bool op_Equality(UnityEngine.Hash128 hash1, UnityEngine.Hash128 hash2);
        static /*0x7e5570c*/ bool op_Inequality(UnityEngine.Hash128 hash1, UnityEngine.Hash128 hash2);
        static /*0x7e54f58*/ bool op_LessThan(UnityEngine.Hash128 x, UnityEngine.Hash128 y);
        static /*0x7e54f70*/ bool op_GreaterThan(UnityEngine.Hash128 x, UnityEngine.Hash128 y);
        static /*0x7e55724*/ void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3);
        static /*0x7e558b8*/ void Rot64(ref ulong x, int k);
        static /*0x7e551e8*/ void Parse_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper hashString, ref UnityEngine.Hash128 ret);
        static /*0x7e5522c*/ void Hash128ToStringImpl_Injected(ref UnityEngine.Hash128 hash, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e553e0*/ void ComputeFromString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper data, ref UnityEngine.Hash128 hash);
        /*0x7e54ec4*/ Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3);
        /*0x7e54edc*/ Hash128(ulong u64_0, ulong u64_1);
        /*0x7e54ee4*/ bool get_isValid();
        /*0x7e54f04*/ int CompareTo(UnityEngine.Hash128 rhs);
        /*0x7e54fac*/ string ToString();
        /*0x7e554e0*/ void Append(string data);
        /*0x380d83c*/ void Append<T>(ref T val);
        /*0x7e554dc*/ void Append(int val);
        /*0x7e55564*/ bool Equals(object obj);
        /*0x7e55600*/ bool Equals(UnityEngine.Hash128 obj);
        /*0x7e5561c*/ int GetHashCode();
        /*0x7e55650*/ int CompareTo(object obj);
        /*0x7e554f0*/ void ShortHash4(uint data);
    }

    class HashUtilities
    {
        static /*0x7e558cc*/ void AppendHash(ref UnityEngine.Hash128 inHash, ref UnityEngine.Hash128 outHash);
    }

    class HashUnsafeUtilities
    {
        static /*0x7e5591c*/ void ComputeHash128(void* data, ulong dataSize, ulong* hash1, ulong* hash2);
        static /*0x7e558d8*/ void ComputeHash128(void* data, ulong dataSize, UnityEngine.Hash128* hash);
    }

    class SpookyHash
    {
        static /*0x0*/ bool AllowUnalignedRead;

        static /*0x7e56f34*/ SpookyHash();
        static /*0x7e55cb8*/ bool AttemptDetectAllowUnalignedRead();
        static /*0x7e55998*/ void Hash(void* message, ulong length, ulong* hash1, ulong* hash2);
        static /*0x7e56604*/ void End(ulong* data, ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11);
        static /*0x7e56870*/ void EndPartial(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11);
        static /*0x7e56b08*/ void Rot64(ref ulong x, int k);
        static /*0x7e55d40*/ void Short(void* message, ulong length, ulong* hash1, ulong* hash2);
        static /*0x7e56b1c*/ void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3);
        static /*0x7e56d38*/ void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3);
        static /*0x7e560e0*/ void Mix(ulong* data, ref ulong s0, ref ulong s1, ref ulong s2, ref ulong s3, ref ulong s4, ref ulong s5, ref ulong s6, ref ulong s7, ref ulong s8, ref ulong s9, ref ulong s10, ref ulong s11);
        static /*0x7e5652c*/ void memset(void* dst, int value, ulong numberOfBytes);

        struct U
        {
            /*0x10*/ byte* p8;
            /*0x10*/ uint* p32;
            /*0x10*/ ulong* p64;
            /*0x10*/ ulong i;

            /*0x7e560d8*/ U(ushort* p8);
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
        static /*0x7e56f84*/ void SetCursor(UnityEngine.Texture2D texture, UnityEngine.Vector2 hotspot, UnityEngine.CursorMode cursorMode);
        static /*0x7e57078*/ UnityEngine.CursorLockMode get_lockState();
        static /*0x7e57024*/ void SetCursor_Injected(nint texture, ref UnityEngine.Vector2 hotspot, UnityEngine.CursorMode cursorMode);
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
        /*0x380d93c*/ void LogException(System.Exception exception, UnityEngine.Object context);
    }

    interface ILogger : UnityEngine.ILogHandler
    {
        /*0x380b9e8*/ UnityEngine.ILogHandler get_logHandler();
        /*0x380b128*/ bool get_logEnabled();
        /*0x380cffc*/ void set_filterLogType(UnityEngine.LogType value);
        /*0x380b228*/ bool IsLogTypeAllowed(UnityEngine.LogType logType);
        /*0x380d170*/ void Log(UnityEngine.LogType logType, object message);
        void Log(UnityEngine.LogType logType, object message, UnityEngine.Object context);
        void Log(UnityEngine.LogType logType, string tag, object message);
        /*0x380d93c*/ void Log(string tag, object message);
        /*0x380d93c*/ void LogWarning(string tag, object message);
        /*0x380d93c*/ void LogError(string tag, object message);
        void LogFormat(UnityEngine.LogType logType, string format, object[] args);
        /*0x380d83c*/ void LogException(System.Exception exception);
    }

    class Logger : UnityEngine.ILogger, UnityEngine.ILogHandler
    {
        /*0x10*/ UnityEngine.ILogHandler <logHandler>k__BackingField;
        /*0x18*/ bool <logEnabled>k__BackingField;
        /*0x1c*/ UnityEngine.LogType <filterLogType>k__BackingField;

        static /*0x7e57150*/ string GetString(object message);
        /*0x7e570a0*/ Logger(UnityEngine.ILogHandler logHandler);
        /*0x7e570e4*/ UnityEngine.ILogHandler get_logHandler();
        /*0x7e570ec*/ void set_logHandler(UnityEngine.ILogHandler value);
        /*0x7e570f4*/ bool get_logEnabled();
        /*0x7e570fc*/ void set_logEnabled(bool value);
        /*0x7e57108*/ UnityEngine.LogType get_filterLogType();
        /*0x7e57110*/ void set_filterLogType(UnityEngine.LogType value);
        /*0x7e57118*/ bool IsLogTypeAllowed(UnityEngine.LogType logType);
        /*0x7e57270*/ void Log(UnityEngine.LogType logType, object message);
        /*0x7e573f4*/ void Log(UnityEngine.LogType logType, object message, UnityEngine.Object context);
        /*0x7e5757c*/ void Log(UnityEngine.LogType logType, string tag, object message);
        /*0x7e57738*/ void Log(string tag, object message);
        /*0x7e578e4*/ void LogWarning(string tag, object message);
        /*0x7e57a90*/ void LogError(string tag, object message);
        /*0x7e57c38*/ void LogException(System.Exception exception);
        /*0x7e57cfc*/ void LogException(System.Exception exception, UnityEngine.Object context);
        /*0x7e57dd0*/ void LogFormat(UnityEngine.LogType logType, string format, object[] args);
        /*0x7e57ecc*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
    }

    class UnityLogWriter : System.IO.TextWriter
    {
        static /*0x7e57fd8*/ void WriteStringToUnityLog(string s);
        static /*0x7e57fe4*/ void WriteStringToUnityLogImpl(string s);
        static /*0x7e58188*/ void Init();
        static /*0x7e5814c*/ void WriteStringToUnityLogImpl_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper s);
        /*0x7e58244*/ UnityLogWriter();
        /*0x7e5829c*/ System.Text.Encoding get_Encoding();
        /*0x7e582a4*/ void Write(char value);
        /*0x7e582e0*/ void Write(string s);
        /*0x7e582f0*/ void Write(char[] buffer, int index, int count);
    }

    struct Color : System.IEquatable<UnityEngine.Color>, System.IFormattable
    {
        /*0x10*/ float r;
        /*0x14*/ float g;
        /*0x18*/ float b;
        /*0x1c*/ float a;

        static /*0x7e5874c*/ UnityEngine.Color op_Addition(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x7e58760*/ UnityEngine.Color op_Subtraction(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x7e58774*/ UnityEngine.Color op_Multiply(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x7e58788*/ UnityEngine.Color op_Multiply(UnityEngine.Color a, float b);
        static /*0x7e5879c*/ bool op_Equality(UnityEngine.Color lhs, UnityEngine.Color rhs);
        static /*0x7e587dc*/ bool op_Inequality(UnityEngine.Color lhs, UnityEngine.Color rhs);
        static /*0x7e5881c*/ UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, float t);
        static /*0x7e58868*/ UnityEngine.Color LerpUnclamped(UnityEngine.Color a, UnityEngine.Color b, float t);
        static /*0x7e588bc*/ UnityEngine.Color get_red();
        static /*0x7e588d0*/ UnityEngine.Color get_green();
        static /*0x7e588e4*/ UnityEngine.Color get_blue();
        static /*0x7e588f8*/ UnityEngine.Color get_white();
        static /*0x7e5890c*/ UnityEngine.Color get_black();
        static /*0x7e58920*/ UnityEngine.Color get_yellow();
        static /*0x7e5893c*/ UnityEngine.Color get_magenta();
        static /*0x7e58950*/ UnityEngine.Color get_gray();
        static /*0x7e58964*/ UnityEngine.Color get_grey();
        static /*0x7e58978*/ UnityEngine.Color get_clear();
        static /*0x7e58a60*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Color c);
        static /*0x7e58a64*/ UnityEngine.Color op_Implicit(UnityEngine.Vector4 v);
        /*0x7e58308*/ Color(float r, float g, float b, float a);
        /*0x7e58314*/ Color(float r, float g, float b);
        /*0x7e58328*/ string ToString();
        /*0x7e58338*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x7e58570*/ int GetHashCode();
        /*0x7e585f8*/ bool Equals(object other);
        /*0x7e586cc*/ bool Equals(UnityEngine.Color other);
        /*0x7e588a0*/ UnityEngine.Color RGBMultiplied(float multiplier);
        /*0x7e5898c*/ UnityEngine.Color get_linear();
        /*0x7e589e8*/ UnityEngine.Color get_gamma();
        /*0x7e58a44*/ float get_maxColorComponent();
    }

    struct Color32 : System.IEquatable<UnityEngine.Color32>, System.IFormattable
    {
        /*0x10*/ int rgba;
        /*0x10*/ byte r;
        /*0x11*/ byte g;
        /*0x12*/ byte b;
        /*0x13*/ byte a;

        static /*0x7e58a80*/ UnityEngine.Color32 op_Implicit(UnityEngine.Color c);
        static /*0x7e58d44*/ UnityEngine.Color op_Implicit(UnityEngine.Color32 c);
        /*0x7e58a68*/ Color32(byte r, byte g, byte b, byte a);
        /*0x7e58d80*/ int GetHashCode();
        /*0x7e58d88*/ bool Equals(object other);
        /*0x7e58e00*/ bool Equals(UnityEngine.Color32 other);
        /*0x7e58e10*/ string ToString();
        /*0x7e58e20*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    class ColorUtility
    {
        static /*0x7e5902c*/ bool DoTryParseHtmlColor(string htmlString, ref UnityEngine.Color32 color);
        static /*0x7e591ec*/ bool TryParseHtmlString(string htmlString, ref UnityEngine.Color color);
        static /*0x7e59250*/ string ToHtmlStringRGB(UnityEngine.Color color);
        static /*0x7e591a8*/ bool DoTryParseHtmlColor_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper htmlString, ref UnityEngine.Color32 color);
    }

    struct GradientColorKey
    {
        /*0x10*/ UnityEngine.Color color;
        /*0x20*/ float time;

        /*0x7e59650*/ GradientColorKey(UnityEngine.Color col, float time);
    }

    struct GradientAlphaKey
    {
        /*0x10*/ float alpha;
        /*0x14*/ float time;

        /*0x7e59660*/ GradientAlphaKey(float alpha, float time);
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

        static /*0x7e59668*/ nint Init();
        static /*0x7e596e0*/ void Cleanup_Injected(nint _unity_self);
        static /*0x7e59774*/ bool Internal_Equals_Injected(nint _unity_self, nint other);
        static /*0x7e59950*/ void Evaluate_Injected(nint _unity_self, float time, ref UnityEngine.Color ret);
        static /*0x7e59ac0*/ void get_colorKeys_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e59c20*/ void get_alphaKeys_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e59cb4*/ UnityEngine.GradientMode get_mode_Injected(nint _unity_self);
        static /*0x7e59d48*/ void set_mode_Injected(nint _unity_self, UnityEngine.GradientMode value);
        static /*0x7e59ddc*/ UnityEngine.ColorSpace get_colorSpace_Injected(nint _unity_self);
        static /*0x7e59e70*/ void set_colorSpace_Injected(nint _unity_self, UnityEngine.ColorSpace value);
        static /*0x7e5a024*/ void SetKeys_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colorKeys, ref UnityEngine.Bindings.ManagedSpanWrapper alphaKeys);
        /*0x7e597b8*/ Gradient();
        /*0x7e59808*/ Gradient(nint ptr);
        /*0x7e59690*/ void Cleanup();
        /*0x7e5971c*/ bool Internal_Equals(nint other);
        /*0x7e59834*/ void Finalize();
        /*0x7e598d4*/ UnityEngine.Color Evaluate(float time);
        /*0x7e599a4*/ UnityEngine.GradientColorKey[] get_colorKeys();
        /*0x7e59b04*/ UnityEngine.GradientAlphaKey[] get_alphaKeys();
        /*0x7e59c64*/ UnityEngine.GradientMode get_mode();
        /*0x7e59cf0*/ void set_mode(UnityEngine.GradientMode value);
        /*0x7e59d8c*/ UnityEngine.ColorSpace get_colorSpace();
        /*0x7e59e18*/ void set_colorSpace(UnityEngine.ColorSpace value);
        /*0x7e59eb4*/ void SetKeys(UnityEngine.GradientColorKey[] colorKeys, UnityEngine.GradientAlphaKey[] alphaKeys);
        /*0x7e5a078*/ bool Equals(object o);
        /*0x7e5a178*/ bool Equals(UnityEngine.Gradient other);
        /*0x7e5a1fc*/ int GetHashCode();

        class BindingsMarshaller
        {
            static /*0x7e5a208*/ nint ConvertToNative(UnityEngine.Gradient graident);
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

        static /*0x7e5c0dc*/ Matrix4x4();
        static /*0x7e5a484*/ UnityEngine.Matrix4x4 TRS(UnityEngine.Vector3 pos, UnityEngine.Quaternion q, UnityEngine.Vector3 s);
        static /*0x7e5a570*/ bool Inverse3DAffine(UnityEngine.Matrix4x4 input, ref UnityEngine.Matrix4x4 result);
        static /*0x7e5a5f8*/ UnityEngine.Matrix4x4 Inverse(UnityEngine.Matrix4x4 m);
        static /*0x7e5a730*/ UnityEngine.Matrix4x4 Transpose(UnityEngine.Matrix4x4 m);
        static /*0x7e5a868*/ UnityEngine.Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar);
        static /*0x7e5a998*/ UnityEngine.Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar);
        static /*0x7e5aa98*/ UnityEngine.Matrix4x4 LookAt(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 up);
        static /*0x7e5ab84*/ UnityEngine.Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar);
        static /*0x7e5acb4*/ UnityEngine.Matrix4x4 Frustum(UnityEngine.FrustumPlanes fp);
        static /*0x7e5b46c*/ UnityEngine.Matrix4x4 op_Multiply(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs);
        static /*0x7e5b564*/ UnityEngine.Vector4 op_Multiply(UnityEngine.Matrix4x4 lhs, UnityEngine.Vector4 vector);
        static /*0x7e5b598*/ bool op_Equality(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs);
        static /*0x7e5b95c*/ UnityEngine.Matrix4x4 Scale(UnityEngine.Vector3 vector);
        static /*0x7e5b988*/ UnityEngine.Matrix4x4 Translate(UnityEngine.Vector3 vector);
        static /*0x7e5b9bc*/ UnityEngine.Matrix4x4 Rotate(UnityEngine.Quaternion q);
        static /*0x7e5ba54*/ UnityEngine.Matrix4x4 get_zero();
        static /*0x7e5baac*/ UnityEngine.Matrix4x4 get_identity();
        static /*0x7e5a278*/ void GetRotation_Injected(ref UnityEngine.Matrix4x4 _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7e5a318*/ void GetLossyScale_Injected(ref UnityEngine.Matrix4x4 _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e5a3c4*/ void DecomposeProjection_Injected(ref UnityEngine.Matrix4x4 _unity_self, ref UnityEngine.FrustumPlanes ret);
        static /*0x7e5a514*/ void TRS_Injected(ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion q, ref UnityEngine.Vector3 s, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e5a5b4*/ bool Inverse3DAffine_Injected(ref UnityEngine.Matrix4x4 input, ref UnityEngine.Matrix4x4 result);
        static /*0x7e5a664*/ void Inverse_Injected(ref UnityEngine.Matrix4x4 m, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e5a79c*/ void Transpose_Injected(ref UnityEngine.Matrix4x4 m, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e5a914*/ void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e5aa2c*/ void Perspective_Injected(float fov, float aspect, float zNear, float zFar, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e5ab28*/ void LookAt_Injected(ref UnityEngine.Vector3 from, ref UnityEngine.Vector3 to, ref UnityEngine.Vector3 up, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e5ac30*/ void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, ref UnityEngine.Matrix4x4 ret);
        /*0x7e5ad64*/ Matrix4x4(UnityEngine.Vector4 column0, UnityEngine.Vector4 column1, UnityEngine.Vector4 column2, UnityEngine.Vector4 column3);
        /*0x7e5a220*/ UnityEngine.Quaternion GetRotation();
        /*0x7e5a2bc*/ UnityEngine.Vector3 GetLossyScale();
        /*0x7e5a35c*/ UnityEngine.FrustumPlanes DecomposeProjection();
        /*0x7e5a408*/ UnityEngine.Quaternion get_rotation();
        /*0x7e5a40c*/ UnityEngine.Vector3 get_lossyScale();
        /*0x7e5a410*/ UnityEngine.FrustumPlanes get_decomposeProjection();
        /*0x7e5a6a8*/ UnityEngine.Matrix4x4 get_inverse();
        /*0x7e5a7e0*/ UnityEngine.Matrix4x4 get_transpose();
        /*0x7e5ad80*/ float get_Item(int row, int column);
        /*0x7e5ae78*/ void set_Item(int row, int column, float value);
        /*0x7e5ad88*/ float get_Item(int index);
        /*0x7e5ae80*/ void set_Item(int index, float value);
        /*0x7e5af70*/ int GetHashCode();
        /*0x7e5b1f0*/ bool Equals(object other);
        /*0x7e5b364*/ bool Equals(UnityEngine.Matrix4x4 other);
        /*0x7e5b11c*/ UnityEngine.Vector4 GetColumn(int index);
        /*0x7e5b67c*/ UnityEngine.Vector4 GetRow(int index);
        /*0x7e5b750*/ UnityEngine.Vector3 GetPosition();
        /*0x7e5b75c*/ void SetColumn(int index, UnityEngine.Vector4 column);
        /*0x7e5b7d4*/ void SetRow(int index, UnityEngine.Vector4 row);
        /*0x7e5b83c*/ UnityEngine.Vector3 MultiplyPoint(UnityEngine.Vector3 point);
        /*0x7e5b8bc*/ UnityEngine.Vector3 MultiplyPoint3x4(UnityEngine.Vector3 point);
        /*0x7e5b914*/ UnityEngine.Vector3 MultiplyVector(UnityEngine.Vector3 vector);
        /*0x7e5bb04*/ string ToString();
        /*0x7e5bb14*/ string ToString(string format, System.IFormatProvider formatProvider);
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

        static /*0x7e5e3c0*/ Vector3();
        static /*0x7e5cef8*/ UnityEngine.Vector3 Slerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, float t);
        static /*0x7e5cfd0*/ UnityEngine.Vector3 Lerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, float t);
        static /*0x7e5d00c*/ UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3 a, UnityEngine.Vector3 b, float t);
        static /*0x7e5d034*/ UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3 current, UnityEngine.Vector3 target, ref UnityEngine.Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime);
        static /*0x7e5d398*/ UnityEngine.Vector3 Cross(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x7e5d4d0*/ UnityEngine.Vector3 Normalize(UnityEngine.Vector3 value);
        static /*0x7e5d754*/ float Dot(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x7e5d76c*/ UnityEngine.Vector3 Project(UnityEngine.Vector3 vector, UnityEngine.Vector3 onNormal);
        static /*0x7e5d868*/ UnityEngine.Vector3 ProjectOnPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal);
        static /*0x7e5d940*/ float Angle(UnityEngine.Vector3 from, UnityEngine.Vector3 to);
        static /*0x7e5da5c*/ float SignedAngle(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 axis);
        static /*0x7e5dbd4*/ float Distance(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x7e5dc74*/ UnityEngine.Vector3 ClampMagnitude(UnityEngine.Vector3 vector, float maxLength);
        static /*0x7e5dd28*/ float Magnitude(UnityEngine.Vector3 vector);
        static /*0x7e5de28*/ float SqrMagnitude(UnityEngine.Vector3 vector);
        static /*0x7e5de60*/ UnityEngine.Vector3 Min(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x7e5de7c*/ UnityEngine.Vector3 Max(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x7e5de98*/ UnityEngine.Vector3 get_zero();
        static /*0x7e5dee4*/ UnityEngine.Vector3 get_one();
        static /*0x7e5df30*/ UnityEngine.Vector3 get_forward();
        static /*0x7e5df7c*/ UnityEngine.Vector3 get_back();
        static /*0x7e5dfc8*/ UnityEngine.Vector3 get_up();
        static /*0x7e5e014*/ UnityEngine.Vector3 get_down();
        static /*0x7e5e060*/ UnityEngine.Vector3 get_left();
        static /*0x7e5e0ac*/ UnityEngine.Vector3 get_right();
        static /*0x7e5e0f8*/ UnityEngine.Vector3 op_Addition(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x7e5e108*/ UnityEngine.Vector3 op_Subtraction(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x7e5e118*/ UnityEngine.Vector3 op_UnaryNegation(UnityEngine.Vector3 a);
        static /*0x7e5e128*/ UnityEngine.Vector3 op_Multiply(UnityEngine.Vector3 a, float d);
        static /*0x7e5e138*/ UnityEngine.Vector3 op_Multiply(float d, UnityEngine.Vector3 a);
        static /*0x7e5e14c*/ UnityEngine.Vector3 op_Division(UnityEngine.Vector3 a, float d);
        static /*0x7e5e15c*/ bool op_Equality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x7e5e190*/ bool op_Inequality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x7e5cf6c*/ void Slerp_Injected(ref UnityEngine.Vector3 a, ref UnityEngine.Vector3 b, float t, ref UnityEngine.Vector3 ret);
        /*0x7e5d360*/ Vector3(float x, float y, float z);
        /*0x7e5d36c*/ Vector3(float x, float y);
        /*0x7e5d270*/ float get_Item(int index);
        /*0x7e5d2e8*/ void set_Item(int index, float value);
        /*0x7e5d378*/ void Scale(UnityEngine.Vector3 scale);
        /*0x7e5d3c0*/ int GetHashCode();
        /*0x7e5d408*/ bool Equals(object other);
        /*0x7e5d4a0*/ bool Equals(UnityEngine.Vector3 other);
        /*0x7e5d5a0*/ void Normalize();
        /*0x7e5d688*/ UnityEngine.Vector3 get_normalized();
        /*0x7e5dda8*/ float get_magnitude();
        /*0x7e5de40*/ float get_sqrMagnitude();
        /*0x7e5e1c4*/ string ToString();
        /*0x7e5e1d4*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Quaternion : System.IEquatable<UnityEngine.Quaternion>, System.IFormattable
    {
        static float kEpsilon = 9.999999974752427e-7;
        static /*0x0*/ UnityEngine.Quaternion identityQuaternion;
        /*0x10*/ float x;
        /*0x14*/ float y;
        /*0x18*/ float z;
        /*0x1c*/ float w;

        static /*0x7e5f490*/ Quaternion();
        static /*0x7e5e4bc*/ UnityEngine.Quaternion FromToRotation(UnityEngine.Vector3 fromDirection, UnityEngine.Vector3 toDirection);
        static /*0x7e5e570*/ UnityEngine.Quaternion Inverse(UnityEngine.Quaternion rotation);
        static /*0x7e5e608*/ UnityEngine.Quaternion Slerp(UnityEngine.Quaternion a, UnityEngine.Quaternion b, float t);
        static /*0x7e5e6dc*/ UnityEngine.Quaternion SlerpUnclamped(UnityEngine.Quaternion a, UnityEngine.Quaternion b, float t);
        static /*0x7e5e7b0*/ UnityEngine.Quaternion Internal_FromEulerRad(UnityEngine.Vector3 euler);
        static /*0x7e5e848*/ UnityEngine.Vector3 Internal_ToEulerRad(UnityEngine.Quaternion rotation);
        static /*0x7e5e8e4*/ void Internal_ToAxisAngleRad(UnityEngine.Quaternion q, ref UnityEngine.Vector3 axis, ref float angle);
        static /*0x7e5e994*/ UnityEngine.Quaternion AngleAxis(float angle, UnityEngine.Vector3 axis);
        static /*0x7e5ea4c*/ UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 forward, UnityEngine.Vector3 upwards);
        static /*0x7e5eb00*/ UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 forward);
        static /*0x7e5eb78*/ UnityEngine.Quaternion get_identity();
        static /*0x7e5ebc4*/ UnityEngine.Quaternion op_Multiply(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x7e5ec38*/ UnityEngine.Vector3 op_Multiply(UnityEngine.Quaternion rotation, UnityEngine.Vector3 point);
        static /*0x7e5ecdc*/ bool IsEqualUsingDot(float dot);
        static /*0x7e5ecf0*/ bool op_Equality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x7e5ed20*/ bool op_Inequality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x7e5ed50*/ float Dot(UnityEngine.Quaternion a, UnityEngine.Quaternion b);
        static /*0x7e5ed70*/ float Angle(UnityEngine.Quaternion a, UnityEngine.Quaternion b);
        static /*0x7e5edd0*/ UnityEngine.Vector3 Internal_MakePositive(UnityEngine.Vector3 euler);
        static /*0x7e5ee84*/ UnityEngine.Quaternion Euler(float x, float y, float z);
        static /*0x7e5ee9c*/ UnityEngine.Quaternion Euler(UnityEngine.Vector3 euler);
        static /*0x7e5eee8*/ UnityEngine.Quaternion Normalize(UnityEngine.Quaternion q);
        static /*0x7e5e51c*/ void FromToRotation_Injected(ref UnityEngine.Vector3 fromDirection, ref UnityEngine.Vector3 toDirection, ref UnityEngine.Quaternion ret);
        static /*0x7e5e5c4*/ void Inverse_Injected(ref UnityEngine.Quaternion rotation, ref UnityEngine.Quaternion ret);
        static /*0x7e5e678*/ void Slerp_Injected(ref UnityEngine.Quaternion a, ref UnityEngine.Quaternion b, float t, ref UnityEngine.Quaternion ret);
        static /*0x7e5e74c*/ void SlerpUnclamped_Injected(ref UnityEngine.Quaternion a, ref UnityEngine.Quaternion b, float t, ref UnityEngine.Quaternion ret);
        static /*0x7e5e804*/ void Internal_FromEulerRad_Injected(ref UnityEngine.Vector3 euler, ref UnityEngine.Quaternion ret);
        static /*0x7e5e8a0*/ void Internal_ToEulerRad_Injected(ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 ret);
        static /*0x7e5e940*/ void Internal_ToAxisAngleRad_Injected(ref UnityEngine.Quaternion q, ref UnityEngine.Vector3 axis, ref float angle);
        static /*0x7e5e9f8*/ void AngleAxis_Injected(float angle, ref UnityEngine.Vector3 axis, ref UnityEngine.Quaternion ret);
        static /*0x7e5eaac*/ void LookRotation_Injected(ref UnityEngine.Vector3 forward, ref UnityEngine.Vector3 upwards, ref UnityEngine.Quaternion ret);
        /*0x7e5eb6c*/ Quaternion(float x, float y, float z, float w);
        /*0x7e5ee58*/ UnityEngine.Vector3 get_eulerAngles();
        /*0x7e5eeb4*/ void ToAngleAxis(ref float angle, ref UnityEngine.Vector3 axis);
        /*0x7e5efc4*/ UnityEngine.Quaternion get_normalized();
        /*0x7e5f090*/ int GetHashCode();
        /*0x7e5f0f4*/ bool Equals(object other);
        /*0x7e5f1c8*/ bool Equals(UnityEngine.Quaternion other);
        /*0x7e5f248*/ string ToString();
        /*0x7e5f258*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Mathf
    {
        static /*0x0*/ float Epsilon;

        static /*0x7e60650*/ Mathf();
        static /*0x7e5f4e0*/ float GammaToLinearSpace(float value);
        static /*0x7e5f518*/ float LinearToGammaSpace(float value);
        static /*0x7e5f550*/ UnityEngine.Color CorrelatedColorTemperatureToRGB(float kelvin);
        static /*0x7e5f5f4*/ ushort FloatToHalf(float val);
        static /*0x7e5f62c*/ float PerlinNoise(float x, float y);
        static /*0x7e5f66c*/ float Sin(float f);
        static /*0x7e5f6d0*/ float Cos(float f);
        static /*0x7e5f734*/ float Tan(float f);
        static /*0x7e5f798*/ float Asin(float f);
        static /*0x7e5f7fc*/ float Acos(float f);
        static /*0x7e5f860*/ float Atan(float f);
        static /*0x7e5f8c4*/ float Atan2(float y, float x);
        static /*0x7e5f930*/ float Sqrt(float f);
        static /*0x7e5f98c*/ float Abs(float f);
        static /*0x7e5f9e8*/ int Abs(int value);
        static /*0x7e5fa40*/ float Min(float a, float b);
        static /*0x7e5fa4c*/ float Min(float[] values);
        static /*0x7e5fa9c*/ int Min(int a, int b);
        static /*0x7e5faa8*/ float Max(float a, float b);
        static /*0x7e5fab4*/ int Max(int a, int b);
        static /*0x7e5fac0*/ float Pow(float f, float p);
        static /*0x7e5fb30*/ float Exp(float power);
        static /*0x7e5fb94*/ float Log(float f, float p);
        static /*0x7e5fc04*/ float Log(float f);
        static /*0x7e5fc68*/ float Log10(float f);
        static /*0x7e5fccc*/ float Ceil(float f);
        static /*0x7e5fd28*/ float Floor(float f);
        static /*0x7e5fd84*/ float Round(float f);
        static /*0x7e5fe4c*/ int CeilToInt(float f);
        static /*0x7e5fec0*/ int FloorToInt(float f);
        static /*0x7e5ff34*/ int RoundToInt(float f);
        static /*0x7e60010*/ float Sign(float f);
        static /*0x7e60024*/ float Clamp(float value, float min, float max);
        static /*0x7e60040*/ int Clamp(int value, int min, int max);
        static /*0x7e6005c*/ float Clamp01(float value);
        static /*0x7e60078*/ float Lerp(float a, float b, float t);
        static /*0x7e6009c*/ float LerpUnclamped(float a, float b, float t);
        static /*0x7e600ac*/ float LerpAngle(float a, float b, float t);
        static /*0x7e60110*/ bool Approximately(float a, float b);
        static /*0x7e601a0*/ float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime);
        static /*0x7e6026c*/ float Repeat(float t, float length);
        static /*0x7e60294*/ float InverseLerp(float a, float b, float value);
        static /*0x7e602c4*/ float ClampToFloat(double value);
        static /*0x7e60330*/ int ClampToInt(long value);
        static /*0x7e60358*/ uint ClampToUInt(long value);
        static /*0x7e60374*/ int GetNumberOfDecimalsForMinimumDifference(double minDifference);
        static /*0x7e60400*/ double RoundBasedOnMinimumDifference(double valueToRound, double minDifference);
        static /*0x7e6048c*/ double DiscardLeastSignificantDecimal(double v);
        static /*0x7e605ec*/ int NextPowerOfTwo(int value);
        static /*0x7e6060c*/ int ClosestPowerOfTwo(int value);
        static /*0x7e60640*/ bool IsPowerOfTwo(int value);
        static /*0x7e5f5a8*/ void CorrelatedColorTemperatureToRGB_Injected(float kelvin, ref UnityEngine.Color ret);
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

        static /*0x7e61228*/ Vector2();
        static /*0x7e607e4*/ UnityEngine.Vector2 Lerp(UnityEngine.Vector2 a, UnityEngine.Vector2 b, float t);
        static /*0x7e60814*/ UnityEngine.Vector2 LerpUnclamped(UnityEngine.Vector2 a, UnityEngine.Vector2 b, float t);
        static /*0x7e60830*/ UnityEngine.Vector2 Scale(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x7e60c54*/ float Dot(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x7e60ce4*/ float Angle(UnityEngine.Vector2 from, UnityEngine.Vector2 to);
        static /*0x7e60dd8*/ float Distance(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x7e60e5c*/ UnityEngine.Vector2 ClampMagnitude(UnityEngine.Vector2 vector, float maxLength);
        static /*0x7e60ef0*/ float SqrMagnitude(UnityEngine.Vector2 a);
        static /*0x7e60f00*/ UnityEngine.Vector2 Min(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x7e60f14*/ UnityEngine.Vector2 Max(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x7e60f28*/ UnityEngine.Vector2 op_Addition(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x7e60f34*/ UnityEngine.Vector2 op_Subtraction(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x7e60f40*/ UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x7e60f4c*/ UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x7e60f58*/ UnityEngine.Vector2 op_UnaryNegation(UnityEngine.Vector2 a);
        static /*0x7e60f64*/ UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, float d);
        static /*0x7e60f70*/ UnityEngine.Vector2 op_Multiply(float d, UnityEngine.Vector2 a);
        static /*0x7e60f80*/ UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, float d);
        static /*0x7e60f8c*/ bool op_Equality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x7e60fb4*/ bool op_Inequality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x7e60fdc*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector3 v);
        static /*0x7e60fe0*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector2 v);
        static /*0x7e60fe8*/ UnityEngine.Vector2 get_zero();
        static /*0x7e61030*/ UnityEngine.Vector2 get_one();
        static /*0x7e61078*/ UnityEngine.Vector2 get_up();
        static /*0x7e610c0*/ UnityEngine.Vector2 get_down();
        static /*0x7e61108*/ UnityEngine.Vector2 get_left();
        static /*0x7e61150*/ UnityEngine.Vector2 get_right();
        static /*0x7e61198*/ UnityEngine.Vector2 get_positiveInfinity();
        static /*0x7e611e0*/ UnityEngine.Vector2 get_negativeInfinity();
        /*0x7e607dc*/ Vector2(float x, float y);
        /*0x7e6070c*/ float get_Item(int index);
        /*0x7e60774*/ void set_Item(int index, float value);
        /*0x7e6083c*/ void Scale(UnityEngine.Vector2 scale);
        /*0x7e60850*/ void Normalize();
        /*0x7e60914*/ UnityEngine.Vector2 get_normalized();
        /*0x7e609c4*/ string ToString();
        /*0x7e609d4*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x7e60b74*/ int GetHashCode();
        /*0x7e60ba8*/ bool Equals(object other);
        /*0x7e60c30*/ bool Equals(UnityEngine.Vector2 other);
        /*0x7e60c64*/ float get_magnitude();
        /*0x7e60cd0*/ float get_sqrMagnitude();
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

        static /*0x7e617a0*/ Vector2Int();
        static /*0x7e6131c*/ UnityEngine.Vector2Int Max(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs);
        static /*0x7e6133c*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector2Int v);
        static /*0x7e6134c*/ UnityEngine.Vector2Int FloorToInt(UnityEngine.Vector2 v);
        static /*0x7e61414*/ UnityEngine.Vector2Int op_Addition(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b);
        static /*0x7e6142c*/ UnityEngine.Vector2Int op_Multiply(int a, UnityEngine.Vector2Int b);
        static /*0x7e61444*/ UnityEngine.Vector2Int op_Division(UnityEngine.Vector2Int a, int b);
        static /*0x7e61458*/ bool op_Equality(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs);
        static /*0x7e61478*/ bool op_Inequality(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs);
        static /*0x7e61710*/ UnityEngine.Vector2Int get_zero();
        static /*0x7e61758*/ UnityEngine.Vector2Int get_one();
        /*0x7e612fc*/ Vector2Int(int x, int y);
        /*0x7e612dc*/ int get_x();
        /*0x7e612e4*/ void set_x(int value);
        /*0x7e612ec*/ int get_y();
        /*0x7e612f4*/ void set_y(int value);
        /*0x7e61304*/ float get_magnitude();
        /*0x7e61498*/ bool Equals(object other);
        /*0x7e61520*/ bool Equals(UnityEngine.Vector2Int other);
        /*0x7e61548*/ int GetHashCode();
        /*0x7e6156c*/ string ToString();
        /*0x7e6157c*/ string ToString(string format, System.IFormatProvider formatProvider);
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

        static /*0x7e61d48*/ Vector3Int();
        static /*0x7e61864*/ UnityEngine.Vector3Int Min(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs);
        static /*0x7e61890*/ UnityEngine.Vector3Int Max(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs);
        static /*0x7e618bc*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector3Int v);
        static /*0x7e618d0*/ UnityEngine.Vector3Int op_Addition(UnityEngine.Vector3Int a, UnityEngine.Vector3Int b);
        static /*0x7e618ec*/ UnityEngine.Vector3Int op_Subtraction(UnityEngine.Vector3Int a, UnityEngine.Vector3Int b);
        static /*0x7e61908*/ UnityEngine.Vector3Int op_Multiply(UnityEngine.Vector3Int a, int b);
        static /*0x7e61920*/ UnityEngine.Vector3Int op_Division(UnityEngine.Vector3Int a, int b);
        static /*0x7e61938*/ bool op_Equality(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs);
        static /*0x7e61cb0*/ UnityEngine.Vector3Int get_zero();
        static /*0x7e61cfc*/ UnityEngine.Vector3Int get_one();
        /*0x7e61858*/ Vector3Int(int x, int y, int z);
        /*0x7e61828*/ int get_x();
        /*0x7e61830*/ void set_x(int value);
        /*0x7e61838*/ int get_y();
        /*0x7e61840*/ void set_y(int value);
        /*0x7e61848*/ int get_z();
        /*0x7e61850*/ void set_z(int value);
        /*0x7e61968*/ bool Equals(object other);
        /*0x7e61a04*/ bool Equals(UnityEngine.Vector3Int other);
        /*0x7e61a3c*/ int GetHashCode();
        /*0x7e61ab8*/ string ToString();
        /*0x7e61ac8*/ string ToString(string format, System.IFormatProvider formatProvider);
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

        static /*0x7e62824*/ Vector4();
        static /*0x7e61f68*/ UnityEngine.Vector4 Lerp(UnityEngine.Vector4 a, UnityEngine.Vector4 b, float t);
        static /*0x7e62118*/ UnityEngine.Vector4 Normalize(UnityEngine.Vector4 a);
        static /*0x7e622d0*/ float Dot(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x7e622f0*/ float Magnitude(UnityEngine.Vector4 a);
        static /*0x7e6242c*/ UnityEngine.Vector4 get_zero();
        static /*0x7e62478*/ UnityEngine.Vector4 get_one();
        static /*0x7e624c4*/ UnityEngine.Vector4 op_Addition(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x7e624d8*/ UnityEngine.Vector4 op_Subtraction(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x7e624ec*/ UnityEngine.Vector4 op_UnaryNegation(UnityEngine.Vector4 a);
        static /*0x7e62500*/ UnityEngine.Vector4 op_Multiply(UnityEngine.Vector4 a, float d);
        static /*0x7e62514*/ UnityEngine.Vector4 op_Multiply(float d, UnityEngine.Vector4 a);
        static /*0x7e6252c*/ UnityEngine.Vector4 op_Division(UnityEngine.Vector4 a, float d);
        static /*0x7e62540*/ bool op_Equality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs);
        static /*0x7e62580*/ bool op_Inequality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs);
        static /*0x7e625c0*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Vector3 v);
        static /*0x7e625c8*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector4 v);
        static /*0x7e625cc*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Vector2 v);
        static /*0x7e625d8*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector4 v);
        /*0x7e61f34*/ Vector4(float x, float y, float z, float w);
        /*0x7e61f40*/ Vector4(float x, float y, float z);
        /*0x7e61f50*/ Vector4(float x, float y);
        /*0x7e61e14*/ float get_Item(int index);
        /*0x7e61ea4*/ void set_Item(int index, float value);
        /*0x7e61f5c*/ void Set(float newX, float newY, float newZ, float newW);
        /*0x7e61fb4*/ void Scale(UnityEngine.Vector4 scale);
        /*0x7e61fd0*/ int GetHashCode();
        /*0x7e62034*/ bool Equals(object other);
        /*0x7e620dc*/ bool Equals(UnityEngine.Vector4 other);
        /*0x7e621f8*/ UnityEngine.Vector4 get_normalized();
        /*0x7e6237c*/ float get_magnitude();
        /*0x7e62404*/ float get_sqrMagnitude();
        /*0x7e625dc*/ string ToString();
        /*0x7e625ec*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct TypeDispatchData : System.IDisposable
    {
        /*0x10*/ UnityEngine.Object[] changed;
        /*0x18*/ Unity.Collections.NativeArray<int> changedID;
        /*0x28*/ Unity.Collections.NativeArray<int> destroyedID;

        /*0x7e62898*/ void Dispose();
    }

    struct TransformDispatchData : System.IDisposable
    {
        /*0x10*/ Unity.Collections.NativeArray<int> transformedID;
        /*0x20*/ Unity.Collections.NativeArray<int> parentID;
        /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices;
        /*0x40*/ Unity.Collections.NativeArray<UnityEngine.Vector3> positions;
        /*0x50*/ Unity.Collections.NativeArray<UnityEngine.Quaternion> rotations;
        /*0x60*/ Unity.Collections.NativeArray<UnityEngine.Vector3> scales;

        /*0x7e62900*/ void Dispose();
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

        static /*0x7e63720*/ ObjectDispatcher();
        static /*0x7e62b78*/ nint CreateDispatchSystemHandle();
        static /*0x7e62d20*/ void DestroyDispatchSystemHandle(nint ptr);
        static /*0x7e63578*/ void EnableTypeTracking(nint ptr, System.Type type, UnityEngine.ObjectDispatcher.TypeTrackingFlags typeTrackingMask);
        static /*0x7e636cc*/ void EnableTransformTracking(nint ptr, System.Type type, UnityEngine.ObjectDispatcher.TransformTrackingType trackingType);
        static /*0x7e63258*/ void DispatchTypeChangesAndClear(nint ptr, System.Type type, System.Action<UnityEngine.Object[], nint, nint, int, int, System.Action<UnityEngine.TypeDispatchData>> callback, bool sortByInstanceID, bool noScriptingArray, System.Action<UnityEngine.TypeDispatchData> param);
        static /*0x7e6338c*/ void DispatchTransformDataChangesAndClear(nint ptr, System.Type type, UnityEngine.ObjectDispatcher.TransformTrackingType trackingType, System.Action<nint, nint, nint, nint, nint, nint, int, System.Action<UnityEngine.TransformDispatchData>> callback, System.Action<UnityEngine.TransformDispatchData> param);
        /*0x7e629e0*/ ObjectDispatcher();
        /*0x7e629d0*/ bool get_valid();
        /*0x7e62ba0*/ void Finalize();
        /*0x7e62cbc*/ void Dispose();
        /*0x7e62c38*/ void Dispose(bool disposing);
        /*0x7e62d5c*/ void ValidateSystemHandleAndThrow();
        /*0x7e62db8*/ void ValidateTypeAndThrow(System.Type type);
        /*0x7e62e8c*/ void ValidateComponentTypeAndThrow(System.Type type);
        /*0x7e62f60*/ void DispatchCallback(UnityEngine.TypeDispatchData data);
        /*0x7e63014*/ void DispatchCallback(UnityEngine.TransformDispatchData data);
        /*0x7e63188*/ void DispatchCallback(UnityEngine.Component[] components);
        /*0x7e63190*/ void DispatchTypeChangesAndClear(System.Type type, System.Action<UnityEngine.TypeDispatchData> callback, bool sortByInstanceID, bool noScriptingArray);
        /*0x7e632cc*/ void DispatchTransformChangesAndClear(System.Type type, UnityEngine.ObjectDispatcher.TransformTrackingType trackingType, System.Action<UnityEngine.TransformDispatchData> callback);
        /*0x7e633f8*/ UnityEngine.TypeDispatchData GetTypeChangesAndClear(System.Type type, Unity.Collections.Allocator allocator, bool sortByInstanceID, bool noScriptingArray);
        /*0x7e6343c*/ UnityEngine.TransformDispatchData GetTransformChangesAndClear(System.Type type, UnityEngine.ObjectDispatcher.TransformTrackingType trackingType, Unity.Collections.Allocator allocator);
        /*0x7e63478*/ void EnableTypeTracking(UnityEngine.ObjectDispatcher.TypeTrackingFlags typeTrackingMask, System.Type[] types);
        /*0x7e635cc*/ void EnableTransformTracking(UnityEngine.ObjectDispatcher.TransformTrackingType trackingType, System.Type[] types);
        /*0x3907c14*/ UnityEngine.TypeDispatchData GetTypeChangesAndClear<T>(Unity.Collections.Allocator allocator, bool sortByInstanceID, bool noScriptingArray);
        /*0x3907c14*/ UnityEngine.TransformDispatchData GetTransformChangesAndClear<T>(UnityEngine.ObjectDispatcher.TransformTrackingType trackingType, Unity.Collections.Allocator allocator);
        /*0x380cffc*/ void EnableTypeTracking<T>(UnityEngine.ObjectDispatcher.TypeTrackingFlags typeTrackingMask);
        /*0x380cffc*/ void EnableTransformTracking<T>(UnityEngine.ObjectDispatcher.TransformTrackingType trackingType);

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

            static /*0x7e6385c*/ <>c();
            /*0x7e638c4*/ <>c();
            /*0x7e638cc*/ void <.cctor>b__64_0(UnityEngine.Object[] changed, nint changedID, nint destroyedID, int changedCount, int destroyedCount, System.Action<UnityEngine.TypeDispatchData> callback);
            /*0x7e639e0*/ void <.cctor>b__64_1(nint transformed, nint parents, nint localToWorldMatrices, nint positions, nint rotations, nint scales, int count, System.Action<UnityEngine.TransformDispatchData> callback);
        }
    }

    class NumericFieldDraggerUtility
    {
        static /*0x0*/ bool s_UseYSign;

        static /*0x7e63b94*/ float Acceleration(bool shiftPressed, bool altPressed);
        static /*0x7e63bb8*/ float NiceDelta(UnityEngine.Vector2 deviceDelta, float acceleration);
        static /*0x7e63d10*/ double CalculateFloatDragSensitivity(double value);
        static /*0x7e63da0*/ double CalculateFloatDragSensitivity(double value, double minValue, double maxValue);
        static /*0x7e63e30*/ long CalculateIntDragSensitivity(long value);
        static /*0x7e63ed8*/ ulong CalculateIntDragSensitivity(ulong value);
        static /*0x7e63e5c*/ double CalculateIntDragSensitivity(double value);
        static /*0x7e63efc*/ long CalculateIntDragSensitivity(long value, long minValue, long maxValue);
    }

    interface IPlayerEditorConnectionNative
    {
        /*0x380cb08*/ void Initialize();
        /*0x380cb08*/ void DisconnectAll();
        void SendMessage(System.Guid messageId, byte[] data, int playerId);
        bool TrySendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x380cb08*/ void Poll();
        void RegisterInternal(System.Guid messageId);
        void UnregisterInternal(System.Guid messageId);
        /*0x380b128*/ bool IsConnected();
    }

    class PlayerConnectionInternal : UnityEngine.IPlayerEditorConnectionNative
    {
        static /*0x7e649ec*/ bool IsConnected();
        static /*0x7e6499c*/ void Initialize();
        static /*0x7e64648*/ void RegisterInternal(string messageId);
        static /*0x7e6480c*/ void UnregisterInternal(string messageId);
        static /*0x7e6409c*/ void SendMessage(string messageId, byte[] data, int playerId);
        static /*0x7e64398*/ bool TrySendMessage(string messageId, byte[] data, int playerId);
        static /*0x7e645c4*/ void PollInternal();
        static /*0x7e64a3c*/ void DisconnectAll();
        static /*0x7e64a64*/ void RegisterInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper messageId);
        static /*0x7e64aa0*/ void UnregisterInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper messageId);
        static /*0x7e64adc*/ void SendMessage_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper messageId, ref UnityEngine.Bindings.ManagedSpanWrapper data, int playerId);
        static /*0x7e64b30*/ bool TrySendMessage_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper messageId, ref UnityEngine.Bindings.ManagedSpanWrapper data, int playerId);
        /*0x7e64b84*/ PlayerConnectionInternal();
        /*0x7e63f9c*/ void UnityEngine.IPlayerEditorConnectionNative.SendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x7e64294*/ bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x7e6459c*/ void UnityEngine.IPlayerEditorConnectionNative.Poll();
        /*0x7e645ec*/ void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(System.Guid messageId);
        /*0x7e647b0*/ void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(System.Guid messageId);
        /*0x7e64974*/ void UnityEngine.IPlayerEditorConnectionNative.Initialize();
        /*0x7e649c4*/ bool UnityEngine.IPlayerEditorConnectionNative.IsConnected();
        /*0x7e64a14*/ void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll();
    }

    class PlayerPrefsException : System.Exception
    {
        /*0x7e64b8c*/ PlayerPrefsException(string error);
    }

    class PlayerPrefs
    {
        static /*0x7e64bf4*/ bool TrySetInt(string key, int value);
        static /*0x7e64db4*/ bool TrySetSetString(string key, string value);
        static /*0x7e65034*/ void SetInt(string key, int value);
        static /*0x7e6508c*/ int GetInt(string key, int defaultValue);
        static /*0x7e65248*/ int GetInt(string key);
        static /*0x7e65250*/ void SetString(string key, string value);
        static /*0x7e652a8*/ string GetString(string key, string defaultValue);
        static /*0x7e6556c*/ string GetString(string key);
        static /*0x7e655b4*/ bool HasKey(string key);
        static /*0x7e65764*/ void DeleteKey(string key);
        static /*0x7e65908*/ void Save();
        static /*0x7e64d70*/ bool TrySetInt_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key, int value);
        static /*0x7e64ff0*/ bool TrySetSetString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7e65204*/ int GetInt_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key, int defaultValue);
        static /*0x7e65518*/ void GetString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key, ref UnityEngine.Bindings.ManagedSpanWrapper defaultValue, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e65728*/ bool HasKey_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key);
        static /*0x7e658cc*/ void DeleteKey_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key);
    }

    class PropertyAttribute : System.Attribute
    {
        /*0x10*/ int <order>k__BackingField;
        /*0x14*/ bool <applyToCollection>k__BackingField;

        /*0x7e65930*/ PropertyAttribute();
        /*0x7e6594c*/ PropertyAttribute(bool applyToCollection);
    }

    class InspectorNameAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ string displayName;

        /*0x7e65974*/ InspectorNameAttribute(string displayName);
    }

    class TooltipAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ string tooltip;

        /*0x7e659a8*/ TooltipAttribute(string tooltip);
    }

    class SpaceAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ float height;

        /*0x7e659dc*/ SpaceAttribute();
        /*0x7e65a00*/ SpaceAttribute(float height);
    }

    class HeaderAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ string header;

        /*0x7e65a2c*/ HeaderAttribute(string header);
    }

    class RangeAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ float min;
        /*0x1c*/ float max;

        /*0x7e65a60*/ RangeAttribute(float min, float max);
    }

    class MinAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ float min;

        /*0x7e65a90*/ MinAttribute(float min);
    }

    class MultilineAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ int lines;

        /*0x7e65abc*/ MultilineAttribute();
    }

    class TextAreaAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ int minLines;
        /*0x1c*/ int maxLines;

        /*0x7e65ae0*/ TextAreaAttribute(int minLines, int maxLines);
    }

    class ColorUsageAttribute : UnityEngine.PropertyAttribute
    {
        /*0x15*/ bool showAlpha;
        /*0x16*/ bool hdr;
        /*0x18*/ float minBrightness;
        /*0x1c*/ float maxBrightness;
        /*0x20*/ float minExposureValue;
        /*0x24*/ float maxExposureValue;

        /*0x7e65b10*/ ColorUsageAttribute(bool showAlpha);
        /*0x7e65b50*/ ColorUsageAttribute(bool showAlpha, bool hdr);
    }

    class DelayedAttribute : UnityEngine.PropertyAttribute
    {
        /*0x7e65b98*/ DelayedAttribute();
    }

    class NonReorderableAttribute : UnityEngine.PropertyAttribute
    {
        /*0x7e65bb4*/ NonReorderableAttribute();
    }

    class PropertyNameUtils
    {
        static /*0x7e65bd0*/ UnityEngine.PropertyName PropertyNameFromString(string name);
        static /*0x7e65d48*/ void PropertyNameFromString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.PropertyName ret);
    }

    struct PropertyName : System.IEquatable<UnityEngine.PropertyName>
    {
        /*0x10*/ int id;

        static /*0x7e65db0*/ bool IsNullOrEmpty(UnityEngine.PropertyName prop);
        static /*0x7e65dbc*/ bool op_Equality(UnityEngine.PropertyName lhs, UnityEngine.PropertyName rhs);
        static /*0x7e65e58*/ UnityEngine.PropertyName op_Implicit(string name);
        /*0x7e65d8c*/ PropertyName(string name);
        /*0x7e65da8*/ PropertyName(UnityEngine.PropertyName other);
        /*0x7e65dc8*/ int GetHashCode();
        /*0x7e65dd0*/ bool Equals(object other);
        /*0x7e65e48*/ bool Equals(UnityEngine.PropertyName other);
        /*0x7e65e6c*/ string ToString();
    }

    class Random
    {
        static /*0x7e65ee4*/ void InitState(int seed);
        static /*0x7e65f20*/ UnityEngine.Random.State get_state();
        static /*0x7e65fa0*/ void set_state(UnityEngine.Random.State value);
        static /*0x7e6601c*/ float Range(float minInclusive, float maxInclusive);
        static /*0x7e6605c*/ int Range(int minInclusive, int maxExclusive);
        static /*0x7e660a0*/ int RandomRangeInt(int minInclusive, int maxExclusive);
        static /*0x7e660e4*/ float get_value();
        static /*0x7e6610c*/ void GetRandomUnitCircle(ref UnityEngine.Vector2 output);
        static /*0x7e66148*/ UnityEngine.Vector2 get_insideUnitCircle();
        static /*0x7e65f64*/ void get_state_Injected(ref UnityEngine.Random.State ret);
        static /*0x7e65fe0*/ void set_state_Injected(ref UnityEngine.Random.State value);

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

        static /*0x7e663dc*/ RenderingLayerMask();
        static /*0x7e6618c*/ uint op_Implicit(UnityEngine.RenderingLayerMask mask);
        static /*0x7e66190*/ int NameToRenderingLayer(string layerName);
        static /*0x7e66364*/ uint GetDefinedRenderingLayersCombinedMaskValue();
        static /*0x7e6638c*/ string[] GetDefinedRenderingLayerNames();
        static /*0x7e663b4*/ int GetRenderingLayerCount();
        static /*0x7e66328*/ int NameToRenderingLayer_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper layerName);
    }

    class ResourceRequest : UnityEngine.AsyncOperation
    {
        /*0x20*/ string m_Path;
        /*0x28*/ System.Type m_Type;

        /*0x7e664ac*/ ResourceRequest(nint ptr);
        /*0x7e66428*/ UnityEngine.Object GetResult();
    }

    class ResourcesAPIInternal
    {
        static /*0x7e66504*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type);
        static /*0x7e66540*/ UnityEngine.Shader FindShaderByName(string name);
        static /*0x7e66740*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        static /*0x7e66704*/ nint FindShaderByName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e6692c*/ nint Load_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper path, System.Type systemTypeInstance);
    }

    class ResourcesAPI
    {
        static /*0x0*/ UnityEngine.ResourcesAPI s_DefaultAPI;
        static /*0x8*/ UnityEngine.ResourcesAPI <overrideAPI>k__BackingField;

        static /*0x7e66ac8*/ ResourcesAPI();
        static /*0x7e66970*/ UnityEngine.ResourcesAPI get_ActiveAPI();
        static /*0x7e66a18*/ UnityEngine.ResourcesAPI get_overrideAPI();
        /*0x7e66a70*/ ResourcesAPI();
        /*0x7e66a78*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type systemTypeInstance);
        /*0x7e66ab4*/ UnityEngine.Shader FindShaderByName(string name);
        /*0x7e66abc*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
    }

    class Resources
    {
        static /*0x382eaf0*/ T[] ConvertObjects<T>(UnityEngine.Object[] rawObjects);
        static /*0x7e66b30*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type);
        static /*0x382dee4*/ T[] FindObjectsOfTypeAll<T>();
        static /*0x7e66b98*/ UnityEngine.Object Load(string path);
        static /*0x3907c14*/ T Load<T>(string path);
        static /*0x7e66434*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        static /*0x7e66c08*/ UnityEngine.Object GetBuiltinResource(System.Type type, string path);
        static /*0x3907c14*/ T GetBuiltinResource<T>(string path);
        static /*0x7e66e38*/ UnityEngine.AsyncOperation UnloadUnusedAssets();
        static /*0x7e66df4*/ nint GetBuiltinResource_Injected(System.Type type, ref UnityEngine.Bindings.ManagedSpanWrapper path);
        static /*0x7e66e74*/ nint UnloadUnusedAssets_Injected();
    }

    class AsyncInstantiateOperation : UnityEngine.AsyncOperation
    {
        /*0x20*/ UnityEngine.Object[] m_Result;
        /*0x28*/ System.Threading.CancellationToken m_CancellationToken;

        /*0x7e66ef4*/ AsyncInstantiateOperation(nint ptr, System.Threading.CancellationToken cancellationToken);
        /*0x7e66f20*/ bool IsCancellationRequested();
        /*0x7e66f78*/ UnityEngine.Object[] CreateResultArray(int size);
    }

    class AsyncInstantiateOperation<T> : UnityEngine.AsyncInstantiateOperation
    {
        /*0x3907c14*/ AsyncInstantiateOperation(nint ptr, System.Threading.CancellationToken cancellationToken);
        /*0x380ba90*/ UnityEngine.Object[] CreateResultArray(int size);
    }

    class AsyncInstantiateOperationHelper
    {
        static /*0x7e66fe4*/ UnityEngine.Object[] CreateAsyncInstantiateOperationResultArray(UnityEngine.AsyncInstantiateOperation op, int size);
    }

    class AsyncOperation : UnityEngine.YieldInstruction
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ System.Action<UnityEngine.AsyncOperation> m_completeCallback;

        static /*0x7e67000*/ void InternalDestroy(nint ptr);
        static /*0x7e6703c*/ void InternalSetManagedObject(nint ptr, UnityEngine.AsyncOperation self);
        static /*0x7e670d0*/ bool get_isDone_Injected(nint _unity_self);
        static /*0x7e6715c*/ float get_progress_Injected(nint _unity_self);
        static /*0x7e671f0*/ void set_priority_Injected(nint _unity_self, int value);
        static /*0x7e67284*/ bool get_allowSceneActivation_Injected(nint _unity_self);
        static /*0x7e67318*/ void set_allowSceneActivation_Injected(nint _unity_self, bool value);
        /*0x7e664b0*/ AsyncOperation(nint ptr);
        /*0x7e67080*/ bool get_isDone();
        /*0x7e6710c*/ float get_progress();
        /*0x7e67198*/ void set_priority(int value);
        /*0x7e67234*/ bool get_allowSceneActivation();
        /*0x7e672c0*/ void set_allowSceneActivation(bool value);
        /*0x7e6735c*/ void Finalize();
        /*0x7e67418*/ void InvokeCompletionEvent();
        /*0x7e67468*/ void add_completed(System.Action<UnityEngine.AsyncOperation> value);
        /*0x7e67544*/ void remove_completed(System.Action<UnityEngine.AsyncOperation> value);

        class BindingsMarshaller
        {
            static /*0x7e66e9c*/ UnityEngine.AsyncOperation ConvertToManaged(nint ptr);
            static /*0x7e675ec*/ nint ConvertToNative(UnityEngine.AsyncOperation asyncOperation);
        }
    }

    class AttributeHelperEngine
    {
        static /*0x0*/ UnityEngine.DisallowMultipleComponent[] _disallowMultipleComponentArray;
        static /*0x8*/ UnityEngine.ExecuteInEditMode[] _executeInEditModeArray;
        static /*0x10*/ UnityEngine.RequireComponent[] _requireComponentArray;

        static /*0x7e67eb0*/ AttributeHelperEngine();
        static /*0x7e67604*/ System.Type GetParentTypeDisallowingMultipleInclusion(System.Type type);
        static /*0x7e6772c*/ System.Type[] GetRequiredComponents(System.Type klass);
        static /*0x7e67c2c*/ int GetExecuteMode(System.Type klass);
        static /*0x7e67d2c*/ int CheckIsEditorScript(System.Type klass);
        static /*0x7e67e30*/ int GetDefaultExecutionOrderFor(System.Type klass);
        static /*0x3907c14*/ T GetCustomAttributeOfType<T>(System.Type klass);
    }

    class DisallowMultipleComponent : System.Attribute
    {
        /*0x7e67f9c*/ DisallowMultipleComponent();
    }

    class RequireComponent : System.Attribute
    {
        /*0x10*/ System.Type m_Type0;
        /*0x18*/ System.Type m_Type1;
        /*0x20*/ System.Type m_Type2;

        /*0x7e67fa4*/ RequireComponent(System.Type requiredComponent);
        /*0x7e67fd4*/ RequireComponent(System.Type requiredComponent, System.Type requiredComponent2);
        /*0x7e68018*/ RequireComponent(System.Type requiredComponent, System.Type requiredComponent2, System.Type requiredComponent3);
    }

    class AddComponentMenu : System.Attribute
    {
        /*0x10*/ string m_AddComponentMenu;
        /*0x18*/ int m_Ordering;

        /*0x7e68078*/ AddComponentMenu(string menuName);
        /*0x7e680b0*/ AddComponentMenu(string menuName, int order);
    }

    class CreateAssetMenuAttribute : System.Attribute
    {
        /*0x10*/ string <menuName>k__BackingField;
        /*0x18*/ string <fileName>k__BackingField;
        /*0x20*/ int <order>k__BackingField;

        /*0x7e68104*/ CreateAssetMenuAttribute();
        /*0x7e680ec*/ void set_menuName(string value);
        /*0x7e680f4*/ void set_fileName(string value);
        /*0x7e680fc*/ void set_order(int value);
    }

    class ContextMenu : System.Attribute
    {
        /*0x10*/ string menuItem;
        /*0x18*/ bool validate;
        /*0x1c*/ int priority;

        /*0x7e6810c*/ ContextMenu(string itemName);
        /*0x7e68150*/ ContextMenu(string itemName, bool isValidateFunction);
        /*0x7e68198*/ ContextMenu(string itemName, bool isValidateFunction, int priority);
    }

    class ExecuteInEditMode : System.Attribute
    {
        /*0x7e681e4*/ ExecuteInEditMode();
    }

    class ExecuteAlways : System.Attribute
    {
        /*0x7e681ec*/ ExecuteAlways();
    }

    class HideInInspector : System.Attribute
    {
        /*0x7e681f4*/ HideInInspector();
    }

    class HelpURLAttribute : System.Attribute
    {
        /*0x10*/ string m_Url;
        /*0x18*/ bool m_Dispatcher;
        /*0x20*/ string m_DispatchingFieldName;

        /*0x7e681fc*/ HelpURLAttribute(string url);
        /*0x7e68278*/ string get_URL();
    }

    class DefaultExecutionOrder : System.Attribute
    {
        /*0x10*/ int m_Order;

        /*0x7e68280*/ DefaultExecutionOrder(int order);
        /*0x7e67ea8*/ int get_order();
    }

    class AssemblyIsEditorAssembly : System.Attribute
    {
    }

    class ExcludeFromPresetAttribute : System.Attribute
    {
        /*0x7e682a8*/ ExcludeFromPresetAttribute();
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

        static /*0x7e6992c*/ Awaitable();
        static /*0x7e68528*/ void ReleaseNativeAwaitable(nint nativeAwaitable);
        static /*0x7e68564*/ int IsNativeAwaitableCompleted(nint nativeAwaitable);
        static /*0x7e685a0*/ void OnDelayedCallManagerCleared();
        static /*0x7e68688*/ void OnUpdate();
        static /*0x7e689e8*/ void OnEndOfFrame();
        static /*0x7e68a48*/ void SetSynchronizationContext(UnityEngine.UnitySynchronizationContext synchronizationContext);
        static /*0x7e68ad0*/ bool MatchCompletionThreadAffinity(UnityEngine.Awaitable.AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity);
        static /*0x7e68d1c*/ void DoRunContinuationOnSynchonizationContext(object continuation);
        /*0x7e68ac4*/ Awaitable();
        /*0x7e682b0*/ void SetExceptionFromNative(System.Exception ex);
        /*0x7e683e0*/ void RunContinuation();
        /*0x7e68bb8*/ void RunOrScheduleContinuation(UnityEngine.Awaitable.AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity, System.Action continuation);
        /*0x7e68d88*/ void RaiseManagedCompletion();
        /*0x7e68eec*/ void PropagateExceptionAndRelease();
        /*0x7e6930c*/ bool get_IsCompletedNoLock();
        /*0x7e69494*/ bool get_IsCompleted();
        /*0x7e695b8*/ bool get_IsDettachedOrCompleted();
        /*0x7e69848*/ UnityEngine.Awaitable.AwaitableHandle CheckPointerValidity();
        /*0x7e698ec*/ bool System.Collections.IEnumerator.MoveNext();
        /*0x7e69920*/ void System.Collections.IEnumerator.Reset();
        /*0x7e69924*/ object System.Collections.IEnumerator.get_Current();

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

            /*0x7e69b60*/ UnityEngine.Awaitable get_Awaitable();
            /*0x7e69b68*/ int get_FrameIndex();
        }

        class DoubleBufferedAwaitableList
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Awaitable.AwaitableAndFrameIndex> _awaitables;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Awaitable.AwaitableAndFrameIndex> _scratch;

            /*0x7e69ab4*/ DoubleBufferedAwaitableList();
            /*0x7e686e8*/ void SwapAndComplete();
            /*0x7e68618*/ void Clear();
        }

        struct AwaitableHandle
        {
            static /*0x0*/ UnityEngine.Awaitable.AwaitableHandle ManagedHandle;
            static /*0x8*/ UnityEngine.Awaitable.AwaitableHandle NullHandle;
            /*0x10*/ nint _handle;

            static /*0x7e69b7c*/ AwaitableHandle();
            static /*0x7e69b78*/ nint op_Implicit(UnityEngine.Awaitable.AwaitableHandle handle);
            /*0x7e69b70*/ AwaitableHandle(nint handle);
            /*0x7e692fc*/ bool get_IsNull();
            /*0x7e69294*/ bool get_IsManaged();
        }

        class <>c
        {
            static /*0x0*/ UnityEngine.Awaitable.<> <>9;
            static /*0x8*/ System.Func<UnityEngine.Awaitable> <>9__76_1;

            static /*0x7e69bdc*/ <>c();
            /*0x7e69c44*/ <>c();
            /*0x7e69c4c*/ UnityEngine.Pool.ObjectPool<UnityEngine.Awaitable> <.cctor>b__76_0();
            /*0x7e69d88*/ UnityEngine.Awaitable <.cctor>b__76_1();
        }
    }

    class Behaviour : UnityEngine.Component
    {
        static /*0x7e69e58*/ bool get_enabled_Injected(nint _unity_self);
        static /*0x7e69f14*/ void set_enabled_Injected(nint _unity_self, bool value);
        static /*0x7e69fd0*/ bool get_isActiveAndEnabled_Injected(nint _unity_self);
        /*0x7e6a00c*/ Behaviour();
        /*0x7e69de0*/ bool get_enabled();
        /*0x7e69e94*/ void set_enabled(bool value);
        /*0x7e69f58*/ bool get_isActiveAndEnabled();
    }

    struct CastHelper<T>
    {
        /*0x0*/ T t;
        /*0x0*/ nint onePointerFurtherThanT;
    }

    class ClassLibraryInitializer
    {
        static /*0x7e6a068*/ void Init();
    }

    struct AssemblyVersion
    {
        /*0x10*/ ushort major;
        /*0x12*/ ushort minor;
        /*0x14*/ ushort build;
        /*0x16*/ ushort revision;

        static /*0x7e6a070*/ bool op_Equality(UnityEngine.AssemblyVersion lhs, UnityEngine.AssemblyVersion rhs);
        /*0x7e6a0a0*/ string ToString();
        /*0x7e6a270*/ bool Equals(object other);
        /*0x7e6a318*/ int GetHashCode();
    }

    struct AssemblyFullName
    {
        /*0x10*/ string Name;
        /*0x18*/ UnityEngine.AssemblyVersion Version;
        /*0x20*/ string PublicKeyToken;
        /*0x28*/ string Culture;

        /*0x7e6a3a8*/ bool Equals(object other);
        /*0x7e6a480*/ int GetHashCode();
        /*0x7e6a508*/ string ToString();
    }

    class Component : UnityEngine.Object
    {
        static /*0x7e6a76c*/ nint get_transform_Injected(nint _unity_self);
        static /*0x7e6a83c*/ nint get_gameObject_Injected(nint _unity_self);
        static /*0x7e6a9cc*/ void GetComponentFastPath_Injected(nint _unity_self, System.Type type, nint oneFurtherThanResultValue);
        static /*0x7e6ad24*/ void GetComponentsForListInternal_Injected(nint _unity_self, System.Type searchType, object resultList);
        static /*0x7e6b228*/ void SendMessage_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object value, UnityEngine.SendMessageOptions options);
        static /*0x7e6b43c*/ void BroadcastMessage_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object parameter, UnityEngine.SendMessageOptions options);
        /*0x7e6a010*/ Component();
        /*0x7e6a6d8*/ UnityEngine.Transform get_transform();
        /*0x7e6a7a8*/ UnityEngine.GameObject get_gameObject();
        /*0x7e6a878*/ UnityEngine.Component GetComponent(System.Type type);
        /*0x7e6a93c*/ void GetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x3907c14*/ T GetComponent<T>();
        /*0x7e6aa20*/ bool TryGetComponent(System.Type type, ref UnityEngine.Component component);
        /*0x380b2f0*/ bool TryGetComponent<T>(ref T component);
        /*0x7e6aadc*/ UnityEngine.Component GetComponentInChildren(System.Type t, bool includeInactive);
        /*0x3907c14*/ T GetComponentInChildren<T>(bool includeInactive);
        /*0x3907c14*/ T GetComponentInChildren<T>();
        T[] GetComponentsInChildren<T>(bool includeInactive);
        void GetComponentsInChildren<T>(bool includeInactive, System.Collections.Generic.List<T> result);
        /*0x380b9e8*/ T[] GetComponentsInChildren<T>();
        /*0x380d83c*/ void GetComponentsInChildren<T>(System.Collections.Generic.List<T> results);
        /*0x7e6abb8*/ UnityEngine.Component GetComponentInParent(System.Type t, bool includeInactive);
        /*0x3907c14*/ T GetComponentInParent<T>();
        T[] GetComponentsInParent<T>(bool includeInactive);
        void GetComponentsInParent<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        /*0x380b9e8*/ T[] GetComponentsInParent<T>();
        /*0x7e6ac94*/ void GetComponentsForListInternal(System.Type searchType, object resultList);
        /*0x7e6ad78*/ void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results);
        /*0x380d83c*/ void GetComponents<T>(System.Collections.Generic.List<T> results);
        /*0x7e6ad7c*/ string get_tag();
        /*0x7e6ae90*/ void set_tag(string value);
        /*0x380b9e8*/ T[] GetComponents<T>();
        /*0x7e6b04c*/ bool CompareTag(string tag);
        /*0x7e6b070*/ void SendMessage(string methodName, object value, UnityEngine.SendMessageOptions options);
        /*0x7e6b284*/ void BroadcastMessage(string methodName, object parameter, UnityEngine.SendMessageOptions options);
    }

    class Coroutine : UnityEngine.YieldInstruction
    {
        /*0x10*/ nint m_Ptr;

        static /*0x7e6b55c*/ void ReleaseCoroutine(nint ptr);
        /*0x7e6b498*/ Coroutine();
        /*0x7e6b4a0*/ void Finalize();

        class BindingsMarshaller
        {
            static /*0x7e6b598*/ nint ConvertToNative(UnityEngine.Coroutine coroutine);
        }
    }

    class SetupCoroutine
    {
        static /*0x7e6b5b0*/ void InvokeMoveNext(System.Collections.IEnumerator enumerator, nint returnValueAddress);
        static /*0x7e6b6cc*/ object InvokeMember(object behaviour, string name, object variable);
    }

    class CustomYieldInstruction : System.Collections.IEnumerator
    {
        /*0x7e6b7e4*/ CustomYieldInstruction();
        /*0x380b128*/ bool get_keepWaiting();
        /*0x7e6b7cc*/ object get_Current();
        /*0x7e6b7d4*/ bool MoveNext();
        /*0x7e6b7e0*/ void Reset();
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

        static /*0x7e6d070*/ EnumDataUtility();
        static /*0x7e6b7ec*/ UnityEngine.EnumData GetCachedEnumData(System.Type enumType, UnityEngine.EnumDataUtility.CachedType cachedType, System.Func<string, string> nicifyName);
        static /*0x7e6c834*/ void HandleInspectorOrderAttribute(System.Type enumType, ref UnityEngine.EnumData enumData);
        static /*0x7e6c720*/ bool CheckObsoleteAddition(System.Reflection.FieldInfo field, UnityEngine.EnumDataUtility.CachedType cachedType);
        static /*0x7e6cd20*/ string EnumTooltipFromEnumField(System.Reflection.FieldInfo field);
        static /*0x7e6ce30*/ string EnumNameFromEnumField(System.Reflection.FieldInfo field, System.Func<string, string> nicifyName);
        static /*0x7e6d020*/ string <EnumNameFromEnumField>g__NicifyName|8_0(ref UnityEngine.EnumDataUtility.<> );

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

            static /*0x7e6d108*/ <>c();
            /*0x7e6d170*/ <>c();
            /*0x7e6d178*/ int <GetCachedEnumData>b__2_5(System.Reflection.FieldInfo f);
            /*0x7e6d1a0*/ string <GetCachedEnumData>b__2_1(System.Reflection.FieldInfo f);
            /*0x7e6d1f4*/ System.Enum <GetCachedEnumData>b__2_2(System.Reflection.FieldInfo f);
            /*0x7e6d25c*/ int <GetCachedEnumData>b__2_3(System.Enum v);
            /*0x7e6d2b8*/ int <GetCachedEnumData>b__2_4(System.Enum v);
        }

        class <>c__DisplayClass2_0
        {
            /*0x10*/ System.Func<string, string> nicifyName;

            /*0x7e6c718*/ <>c__DisplayClass2_0();
            /*0x7e6d314*/ string <GetCachedEnumData>b__0(System.Reflection.FieldInfo f);
        }

        struct <>c__DisplayClass8_0
        {
            /*0x10*/ System.Func<string, string> nicifyName;
            /*0x18*/ System.Reflection.FieldInfo field;
        }
    }

    class ExcludeFromObjectFactoryAttribute : System.Attribute
    {
        /*0x7e6d37c*/ ExcludeFromObjectFactoryAttribute();
    }

    class ExtensionOfNativeClassAttribute : System.Attribute
    {
        /*0x7e6d384*/ ExtensionOfNativeClassAttribute();
    }

    class FailedToLoadScriptObject : UnityEngine.Object
    {
    }

    class GameObject : UnityEngine.Object
    {
        static /*0x7e6d38c*/ UnityEngine.GameObject CreatePrimitive(UnityEngine.PrimitiveType type);
        static /*0x7e6df88*/ UnityEngine.GameObject FindWithTag(string tag);
        static /*0x7e6e150*/ void FindGameObjectsWithTagForListInternal(string tag, object results);
        static /*0x7e6e304*/ void FindGameObjectsWithTag(string tag, System.Collections.Generic.List<UnityEngine.GameObject> results);
        static /*0x7e6df8c*/ UnityEngine.GameObject FindGameObjectWithTag(string tag);
        static /*0x7e6fb00*/ UnityEngine.GameObject[] FindGameObjectsWithTag(string tag);
        static /*0x7e6fe6c*/ void Internal_CreateGameObject(UnityEngine.GameObject self, string name);
        static /*0x7e70144*/ UnityEngine.GameObject Find(string name);
        static /*0x7e70344*/ void SetGameObjectsActive(nint instanceIds, int instanceCount, bool active);
        static /*0x7e70398*/ void SetGameObjectsActive(Unity.Collections.NativeArray<int> instanceIDs, bool active);
        static /*0x7e704b0*/ void SetGameObjectsActive(System.ReadOnlySpan<int> instanceIDs, bool active);
        static /*0x7e70564*/ void InstantiateGameObjects(int sourceInstanceID, nint newInstanceIDs, nint newTransformInstanceIDs, int count, UnityEngine.SceneManagement.Scene destinationScene);
        static /*0x7e70640*/ void InstantiateGameObjects(int sourceInstanceID, int count, Unity.Collections.NativeArray<int> newInstanceIDs, Unity.Collections.NativeArray<int> newTransformInstanceIDs, UnityEngine.SceneManagement.Scene destinationScene);
        static /*0x7e7080c*/ UnityEngine.SceneManagement.Scene GetScene(int instanceID);
        static /*0x7e6d3f8*/ nint CreatePrimitive_Injected(UnityEngine.PrimitiveType type);
        static /*0x7e6d434*/ nint GetComponent_Injected(nint _unity_self, System.Type type);
        static /*0x7e6d508*/ void GetComponentFastPath_Injected(nint _unity_self, System.Type type, nint oneFurtherThanResultValue);
        static /*0x7e6d750*/ nint GetComponentByName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper type);
        static /*0x7e6d990*/ nint GetComponentByNameWithCase_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper type, bool caseSensitive);
        static /*0x7e6d9e8*/ nint GetComponentInChildren_Injected(nint _unity_self, System.Type type, bool includeInactive);
        static /*0x7e6da44*/ nint GetComponentInParent_Injected(nint _unity_self, System.Type type, bool includeInactive);
        static /*0x7e6db60*/ System.Array GetComponentsInternal_Injected(nint _unity_self, System.Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList);
        static /*0x7e6de60*/ nint TryGetComponentInternal_Injected(nint _unity_self, System.Type type);
        static /*0x7e6df34*/ void TryGetComponentFastPath_Injected(nint _unity_self, System.Type type, nint oneFurtherThanResultValue);
        static /*0x7e6e2c0*/ void FindGameObjectsWithTagForListInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper tag, object results);
        static /*0x7e6ea48*/ nint AddComponentInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper className);
        static /*0x7e6eb30*/ nint Internal_AddComponentWithType_Injected(nint _unity_self, System.Type componentType);
        static /*0x7e6ebf0*/ int GetComponentCount_Injected(nint _unity_self);
        static /*0x7e6ecd0*/ nint QueryComponentAtIndex_Injected(nint _unity_self, int index);
        static /*0x7e6ee58*/ int GetComponentIndex_Injected(nint _unity_self, nint component);
        static /*0x7e6ef30*/ nint get_transform_Injected(nint _unity_self);
        static /*0x7e6efe4*/ int get_layer_Injected(nint _unity_self);
        static /*0x7e6f0a0*/ void set_layer_Injected(nint _unity_self, int value);
        static /*0x7e6f15c*/ bool get_active_Injected(nint _unity_self);
        static /*0x7e6f218*/ void set_active_Injected(nint _unity_self, bool value);
        static /*0x7e6f2dc*/ void SetActive_Injected(nint _unity_self, bool value);
        static /*0x7e6f398*/ bool get_activeSelf_Injected(nint _unity_self);
        static /*0x7e6f44c*/ bool get_activeInHierarchy_Injected(nint _unity_self);
        static /*0x7e6f508*/ void SetActiveRecursively_Injected(nint _unity_self, bool state);
        static /*0x7e6f5c4*/ bool get_isStatic_Injected(nint _unity_self);
        static /*0x7e6f680*/ void set_isStatic_Injected(nint _unity_self, bool value);
        static /*0x7e6f73c*/ bool get_isStaticBatchable_Injected(nint _unity_self);
        static /*0x7e6f778*/ void get_tag_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e6f7bc*/ void set_tag_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7e6fa3c*/ bool CompareTag_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper tag);
        static /*0x7e6fa80*/ bool CompareTagHandle_Internal_Injected(nint _unity_self, ref UnityEngine.TagHandle tag);
        static /*0x7e6fac4*/ nint FindGameObjectWithTag_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper tag);
        static /*0x7e6fc70*/ UnityEngine.GameObject[] FindGameObjectsWithTag_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper tag);
        static /*0x7e6fcac*/ void SendMessageUpwards_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object value, UnityEngine.SendMessageOptions options);
        static /*0x7e6fd1c*/ void SendMessage_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object value, UnityEngine.SendMessageOptions options);
        static /*0x7e6fd8c*/ void BroadcastMessage_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object parameter, UnityEngine.SendMessageOptions options);
        static /*0x7e70100*/ void Internal_CreateGameObject_Injected(UnityEngine.GameObject self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e70308*/ nint Find_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e705d4*/ void InstantiateGameObjects_Injected(int sourceInstanceID, nint newInstanceIDs, nint newTransformInstanceIDs, int count, ref UnityEngine.SceneManagement.Scene destinationScene);
        static /*0x7e70858*/ void GetScene_Injected(int instanceID, ref UnityEngine.SceneManagement.Scene ret);
        static /*0x7e70924*/ void get_scene_Injected(nint _unity_self, ref UnityEngine.SceneManagement.Scene ret);
        static /*0x7e709e0*/ ulong get_sceneCullingMask_Injected(nint _unity_self);
        /*0x7e6fdfc*/ GameObject(string name);
        /*0x7e6ffdc*/ GameObject();
        /*0x7e70040*/ GameObject(string name, System.Type[] components);
        /*0x3907c14*/ T GetComponent<T>();
        /*0x7e6a898*/ UnityEngine.Component GetComponent(System.Type type);
        /*0x7e6d478*/ void GetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x7e6d55c*/ UnityEngine.Component GetComponentByName(string type);
        /*0x7e6d794*/ UnityEngine.Component GetComponentByNameWithCase(string type, bool caseSensitive);
        /*0x7e6d9e4*/ UnityEngine.Component GetComponent(string type);
        /*0x7e6ab0c*/ UnityEngine.Component GetComponentInChildren(System.Type type, bool includeInactive);
        /*0x7e6da3c*/ UnityEngine.Component GetComponentInChildren(System.Type type);
        /*0x3907c14*/ T GetComponentInChildren<T>();
        /*0x3907c14*/ T GetComponentInChildren<T>(bool includeInactive);
        /*0x7e6abe8*/ UnityEngine.Component GetComponentInParent(System.Type type, bool includeInactive);
        /*0x7e6da98*/ UnityEngine.Component GetComponentInParent(System.Type type);
        /*0x3907c14*/ T GetComponentInParent<T>();
        /*0x3907c14*/ T GetComponentInParent<T>(bool includeInactive);
        /*0x7e6daa0*/ System.Array GetComponentsInternal(System.Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList);
        /*0x7e6dbe4*/ UnityEngine.Component[] GetComponents(System.Type type);
        /*0x380b9e8*/ T[] GetComponents<T>();
        /*0x7e6dc6c*/ void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results);
        /*0x380d83c*/ void GetComponents<T>(System.Collections.Generic.List<T> results);
        /*0x7e6dc84*/ UnityEngine.Component[] GetComponentsInChildren(System.Type type);
        /*0x7e6dc8c*/ UnityEngine.Component[] GetComponentsInChildren(System.Type type, bool includeInactive);
        T[] GetComponentsInChildren<T>(bool includeInactive);
        void GetComponentsInChildren<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        /*0x380b9e8*/ T[] GetComponentsInChildren<T>();
        /*0x380d83c*/ void GetComponentsInChildren<T>(System.Collections.Generic.List<T> results);
        /*0x7e6dd20*/ UnityEngine.Component[] GetComponentsInParent(System.Type type);
        /*0x7e6dd28*/ UnityEngine.Component[] GetComponentsInParent(System.Type type, bool includeInactive);
        void GetComponentsInParent<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        T[] GetComponentsInParent<T>(bool includeInactive);
        /*0x380b9e8*/ T[] GetComponentsInParent<T>();
        /*0x380b2f0*/ bool TryGetComponent<T>(ref T component);
        /*0x7e6aa50*/ bool TryGetComponent(System.Type type, ref UnityEngine.Component component);
        /*0x7e6ddbc*/ UnityEngine.Component TryGetComponentInternal(System.Type type);
        /*0x7e6dea4*/ void TryGetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x7e6e308*/ void SendMessageUpwards(string methodName, UnityEngine.SendMessageOptions options);
        /*0x7e6e4cc*/ void SendMessage(string methodName, UnityEngine.SendMessageOptions options);
        /*0x7e6e690*/ void BroadcastMessage(string methodName, UnityEngine.SendMessageOptions options);
        /*0x7e6e854*/ UnityEngine.Component AddComponentInternal(string className);
        /*0x7e6ea8c*/ UnityEngine.Component Internal_AddComponentWithType(System.Type componentType);
        /*0x7e6eb74*/ UnityEngine.Component AddComponent(System.Type componentType);
        /*0x3907c14*/ T AddComponent<T>();
        /*0x7e6eb78*/ int GetComponentCount();
        /*0x7e6ec2c*/ UnityEngine.Component QueryComponentAtIndex(int index);
        /*0x7e6ed14*/ UnityEngine.Component GetComponentAtIndex(int index);
        /*0x3907c14*/ T GetComponentAtIndex<T>(int index);
        /*0x7e6eda4*/ int GetComponentIndex(UnityEngine.Component component);
        /*0x7e6ee9c*/ UnityEngine.Transform get_transform();
        /*0x7e6ef6c*/ int get_layer();
        /*0x7e6f020*/ void set_layer(int value);
        /*0x7e6f0e4*/ bool get_active();
        /*0x7e6f198*/ void set_active(bool value);
        /*0x7e6f25c*/ void SetActive(bool value);
        /*0x7e6f320*/ bool get_activeSelf();
        /*0x7e6f3d4*/ bool get_activeInHierarchy();
        /*0x7e6f488*/ void SetActiveRecursively(bool state);
        /*0x7e6f54c*/ bool get_isStatic();
        /*0x7e6f600*/ void set_isStatic(bool value);
        /*0x7e6f6c4*/ bool get_isStaticBatchable();
        /*0x7e6ad94*/ string get_tag();
        /*0x7e6aeb0*/ void set_tag(string value);
        /*0x7e6b06c*/ bool CompareTag(string tag);
        /*0x7e6f9ac*/ bool CompareTag(UnityEngine.TagHandle tag);
        /*0x7e6f800*/ bool CompareTag_Internal(string tag);
        /*0x7e6f9b4*/ bool CompareTagHandle_Internal(UnityEngine.TagHandle tag);
        /*0x7e6e314*/ void SendMessageUpwards(string methodName, object value, UnityEngine.SendMessageOptions options);
        /*0x7e6fd08*/ void SendMessageUpwards(string methodName, object value);
        /*0x7e6fd10*/ void SendMessageUpwards(string methodName);
        /*0x7e6e4d8*/ void SendMessage(string methodName, object value, UnityEngine.SendMessageOptions options);
        /*0x7e6fd78*/ void SendMessage(string methodName, object value);
        /*0x7e6fd80*/ void SendMessage(string methodName);
        /*0x7e6e69c*/ void BroadcastMessage(string methodName, object parameter, UnityEngine.SendMessageOptions options);
        /*0x7e6fde8*/ void BroadcastMessage(string methodName, object parameter);
        /*0x7e6fdf0*/ void BroadcastMessage(string methodName);
        /*0x7e7089c*/ UnityEngine.SceneManagement.Scene get_scene();
        /*0x7e70968*/ ulong get_sceneCullingMask();
        /*0x7e70a1c*/ UnityEngine.GameObject get_gameObject();
    }

    class InspectorOrderAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ UnityEngine.InspectorSort <m_inspectorSort>k__BackingField;
        /*0x1c*/ UnityEngine.InspectorSortDirection <m_sortDirection>k__BackingField;

        /*0x7e70a20*/ UnityEngine.InspectorSort get_m_inspectorSort();
        /*0x7e70a28*/ UnityEngine.InspectorSortDirection get_m_sortDirection();
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

        static /*0x7e70a30*/ int op_Implicit(UnityEngine.LayerMask mask);
        static /*0x7e70a34*/ UnityEngine.LayerMask op_Implicit(int intVal);
        static /*0x7e70a44*/ int NameToLayer(string layerName);
        static /*0x7e70bf0*/ int GetMask(string[] layerNames);
        static /*0x7e70bb4*/ int NameToLayer_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper layerName);
        /*0x7e70a3c*/ int get_value();
    }

    struct LazyLoadReference<T>
    {
        static int kInstanceID_None = 0;
        /*0x0*/ int m_InstanceID;

        static /*0x3907c14*/ UnityEngine.LazyLoadReference<T> op_Implicit(T asset);
        /*0x380b128*/ bool get_isSet();
        /*0x3907c14*/ T get_asset();
        /*0x3907c14*/ void set_asset(T value);
    }

    class ManagedStreamHelpers
    {
        static /*0x7e70cbc*/ void ValidateLoadFromStream(System.IO.Stream stream);
        static /*0x7e70dc0*/ void ManagedStreamRead(byte[] buffer, int offset, int count, System.IO.Stream stream, nint returnValueAddress);
        static /*0x7e70e94*/ void ManagedStreamSeek(long offset, uint origin, System.IO.Stream stream, nint returnValueAddress);
        static /*0x7e70f60*/ void ManagedStreamLength(System.IO.Stream stream, nint returnValueAddress);
    }

    class MonoBehaviour : UnityEngine.Behaviour
    {
        /*0x18*/ System.Threading.CancellationTokenSource m_CancellationTokenSource;

        static /*0x7e72538*/ void print(object message);
        static /*0x7e71250*/ void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self);
        static /*0x7e711a4*/ bool Internal_IsInvokingAll(UnityEngine.MonoBehaviour self);
        static /*0x7e71300*/ void InvokeDelayed(UnityEngine.MonoBehaviour self, string methodName, float time, float repeatRate);
        static /*0x7e71558*/ void CancelInvoke(UnityEngine.MonoBehaviour self, string methodName);
        static /*0x7e7172c*/ bool IsInvoking(UnityEngine.MonoBehaviour self, string methodName);
        static /*0x7e719d4*/ bool IsObjectMonoBehaviour(UnityEngine.Object obj);
        static /*0x7e72160*/ void StopCoroutine_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName);
        static /*0x7e7221c*/ void StopAllCoroutines_Injected(nint _unity_self);
        static /*0x7e722d0*/ bool get_useGUILayout_Injected(nint _unity_self);
        static /*0x7e7238c*/ void set_useGUILayout_Injected(nint _unity_self, bool value);
        static /*0x7e72448*/ bool get_didStart_Injected(nint _unity_self);
        static /*0x7e724fc*/ bool get_didAwake_Injected(nint _unity_self);
        static /*0x7e72590*/ void Internal_CancelInvokeAll_Injected(nint self);
        static /*0x7e725cc*/ bool Internal_IsInvokingAll_Injected(nint self);
        static /*0x7e72608*/ void InvokeDelayed_Injected(nint self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, float time, float repeatRate);
        static /*0x7e72664*/ void CancelInvoke_Injected(nint self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName);
        static /*0x7e726a8*/ bool IsInvoking_Injected(nint self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName);
        static /*0x7e726ec*/ bool IsObjectMonoBehaviour_Injected(nint obj);
        static /*0x7e72728*/ UnityEngine.Coroutine StartCoroutineManaged_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object value);
        static /*0x7e7277c*/ UnityEngine.Coroutine StartCoroutineManaged2_Injected(nint _unity_self, System.Collections.IEnumerator enumerator);
        static /*0x7e727c0*/ void StopCoroutineManaged_Injected(nint _unity_self, nint routine);
        static /*0x7e72804*/ void StopCoroutineFromEnumeratorManaged_Injected(nint _unity_self, System.Collections.IEnumerator routine);
        static /*0x7e72944*/ void GetScriptClassName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e72988*/ void OnCancellationTokenCreated_Injected(nint _unity_self);
        /*0x7e729c4*/ MonoBehaviour();
        /*0x7e7100c*/ System.Threading.CancellationToken get_destroyCancellationToken();
        /*0x7e7118c*/ void RaiseCancellation();
        /*0x7e711a0*/ bool IsInvoking();
        /*0x7e7124c*/ void CancelInvoke();
        /*0x7e712f8*/ void Invoke(string methodName, float time);
        /*0x7e714e8*/ void InvokeRepeating(string methodName, float time, float repeatRate);
        /*0x7e71554*/ void CancelInvoke(string methodName);
        /*0x7e71728*/ bool IsInvoking(string methodName);
        /*0x7e71908*/ UnityEngine.Coroutine StartCoroutine(string methodName);
        /*0x7e71910*/ UnityEngine.Coroutine StartCoroutine(string methodName, object value);
        /*0x7e71c34*/ UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine);
        /*0x7e71d60*/ UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine);
        /*0x7e71d64*/ void StopCoroutine(System.Collections.IEnumerator routine);
        /*0x7e71e90*/ void StopCoroutine(UnityEngine.Coroutine routine);
        /*0x7e71fc4*/ void StopCoroutine(string methodName);
        /*0x7e721a4*/ void StopAllCoroutines();
        /*0x7e72258*/ bool get_useGUILayout();
        /*0x7e7230c*/ void set_useGUILayout(bool value);
        /*0x7e723d0*/ bool get_didStart();
        /*0x7e72484*/ bool get_didAwake();
        /*0x7e71a7c*/ UnityEngine.Coroutine StartCoroutineManaged(string methodName, object value);
        /*0x7e71ce0*/ UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator);
        /*0x7e71f3c*/ void StopCoroutineManaged(UnityEngine.Coroutine routine);
        /*0x7e71e10*/ void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine);
        /*0x7e72848*/ string GetScriptClassName();
        /*0x7e71114*/ void OnCancellationTokenCreated();
    }

    class NoAllocHelpers
    {
        static /*0x3839e58*/ void EnsureListElemCount<T>(System.Collections.Generic.List<T> list, int count);
        static /*0x7e729c8*/ int SafeLength(System.Array values);
        static /*0x3824ba4*/ int SafeLength<T>(System.Collections.Generic.List<T> values);
        static /*0x382eaf0*/ T[] ExtractArrayFromList<T>(System.Collections.Generic.List<T> list);
        static /*0x3907c14*/ void ResetListContents<T>(System.Collections.Generic.List<T> list, System.ReadOnlySpan<T> span);
        static /*0x3839e58*/ void ResetListSize<T>(System.Collections.Generic.List<T> list, int size);

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

        /*0x7e729e4*/ RangeInt(int start, int length);
        /*0x7e729d8*/ int get_end();
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

        /*0x7e729ec*/ RuntimeInitializeOnLoadMethodAttribute();
        /*0x7e72a10*/ RuntimeInitializeOnLoadMethodAttribute(UnityEngine.RuntimeInitializeLoadType loadType);
        /*0x7e72a08*/ void set_loadType(UnityEngine.RuntimeInitializeLoadType value);
    }

    class ScriptableObject : UnityEngine.Object
    {
        static /*0x7e72af4*/ UnityEngine.ScriptableObject CreateInstance(System.Type type);
        static /*0x3907c14*/ T CreateInstance<T>();
        static /*0x7e72ab8*/ void CreateScriptableObject(UnityEngine.ScriptableObject self);
        static /*0x7e72afc*/ UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromType(System.Type type, bool applyDefaultsAndReset);
        static /*0x7e72b78*/ nint CreateScriptableObjectInstanceFromType_Injected(System.Type type, bool applyDefaultsAndReset);
        /*0x7e72a38*/ ScriptableObject();
    }

    class ScriptingRuntime
    {
        static /*0x7e72bbc*/ string[] GetAllUserAssemblies();
    }

    class ScriptingUtility
    {
        static /*0x7e72be4*/ bool IsManagedCodeWorking();
        static /*0x7e72bec*/ void SetupCallbacks(nint p);

        struct TestClass
        {
            /*0x10*/ int value;
        }
    }

    class SelectionBaseAttribute : System.Attribute
    {
        /*0x7e72bf0*/ SelectionBaseAttribute();
    }

    class StackTraceUtility
    {
        static /*0x0*/ string projectFolder;

        static /*0x7e738d4*/ StackTraceUtility();
        static /*0x7e72bf8*/ void SetProjectFolder(string folder);
        static /*0x7e72cfc*/ string ExtractStackTrace();
        static /*0x7e73558*/ void ExtractStringFromExceptionInternal(object exceptiono, ref string message, ref string stackTrace);
        static /*0x7e72e58*/ string ExtractFormattedStackTrace(System.Diagnostics.StackTrace stackTrace);
    }

    class UnityException : System.Exception
    {
        /*0x7e73b8c*/ UnityException();
        /*0x7e73c0c*/ UnityException(string message);
        /*0x7e73c84*/ UnityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    }

    class MissingReferenceException : System.Exception
    {
        /*0x7e73d04*/ MissingReferenceException();
        /*0x7e73d84*/ MissingReferenceException(string message);
        /*0x7e73dfc*/ MissingReferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    }

    struct TagHandle
    {
        /*0x10*/ uint _tagIndex;

        static /*0x7e73e84*/ string TagToString(uint tagIndex);
        static /*0x7e73f38*/ void TagToString_Injected(uint tagIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        /*0x7e73e7c*/ string ToString();
    }

    class TextAsset : UnityEngine.Object
    {
        static /*0x7e74130*/ void Internal_CreateInstance(UnityEngine.TextAsset self, string text);
        static /*0x7e742c8*/ void Internal_CreateInstanceFromBytes(UnityEngine.TextAsset self, System.ReadOnlySpan<byte> bytes);
        static /*0x7e7455c*/ string DecodeString(byte[] bytes);
        static /*0x7e74034*/ byte[] get_bytes_Injected(nint _unity_self);
        static /*0x7e740ec*/ byte[] GetPreviewBytes_Injected(nint _unity_self, int maxByteCount);
        static /*0x7e74284*/ void Internal_CreateInstance_Injected(UnityEngine.TextAsset self, ref UnityEngine.Bindings.ManagedSpanWrapper text);
        static /*0x7e7437c*/ void Internal_CreateInstanceFromBytes_Injected(UnityEngine.TextAsset self, ref UnityEngine.Bindings.ManagedSpanWrapper bytes);
        static /*0x7e74434*/ nint GetDataPtr_Injected(nint _unity_self);
        static /*0x7e744e4*/ long GetDataSize_Injected(nint _unity_self);
        /*0x7e747e8*/ TextAsset();
        /*0x7e74880*/ TextAsset(string text);
        /*0x7e7488c*/ TextAsset(System.ReadOnlySpan<byte> bytes);
        /*0x7e747f4*/ TextAsset(UnityEngine.TextAsset.CreateOptions options, string text);
        /*0x7e7489c*/ TextAsset(UnityEngine.TextAsset.CreateOptions options, System.ReadOnlySpan<byte> bytes);
        /*0x7e73f7c*/ byte[] get_bytes();
        /*0x7e74070*/ byte[] GetPreviewBytes(int maxByteCount);
        /*0x7e743c0*/ nint GetDataPtr();
        /*0x7e74470*/ long GetDataSize();
        /*0x7e74520*/ string get_text();
        /*0x7e747e0*/ long get_dataSize();
        /*0x7e747e4*/ string ToString();
        /*0x3907c14*/ Unity.Collections.NativeArray<T> GetData<T>();
        /*0x7e74944*/ string GetPreview(int maxChars);

        enum CreateOptions
        {
            None = 0,
            CreateNativeObject = 1,
        }

        class EncodingUtility
        {
            static /*0x0*/ System.Collections.Generic.KeyValuePair<System.Byte[], System.Text.Encoding> encodingLookup;
            static /*0x8*/ System.Text.Encoding targetEncoding;

            static /*0x7e74958*/ EncodingUtility();
        }
    }

    class TrackedReference
    {
        /*0x10*/ nint m_Ptr;

        static /*0x7e74d30*/ bool op_Equality(UnityEngine.TrackedReference x, UnityEngine.TrackedReference y);
        /*0x7e74d28*/ TrackedReference();
        /*0x7e74d80*/ bool Equals(object o);
        /*0x7e74e00*/ int GetHashCode();
    }

    class UnhandledExceptionHandler
    {
        static /*0x7e74e0c*/ void RegisterUECatcher();

        class <>c
        {
            static /*0x0*/ UnityEngine.UnhandledExceptionHandler.<> <>9;
            static /*0x8*/ System.UnhandledExceptionEventHandler <>9__0_0;

            static /*0x7e74f08*/ <>c();
            /*0x7e74f70*/ <>c();
            /*0x7e74f78*/ void <RegisterUECatcher>b__0_0(object sender, System.UnhandledExceptionEventArgs e);
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
    }

    class Object
    {
        static int kInstanceID_None = 0;
        static string objectIsNullMessage = "The Object you want to instantiate is null.";
        static string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";
        static /*0x0*/ int OffsetOfInstanceIDInCPlusPlusObject;
        /*0x10*/ nint m_CachedPtr;

        static /*0x7e77b64*/ Object();
        static /*0x7e752b4*/ bool op_Implicit(UnityEngine.Object exists);
        static /*0x7e7520c*/ bool CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs);
        static /*0x7e75318*/ bool IsNativeObjectAlive(UnityEngine.Object o);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, UnityEngine.Transform parent);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Transform parent);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Threading.CancellationToken cancellationToken);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Transform parent, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Transform parent, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations, System.Threading.CancellationToken cancellationToken);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, UnityEngine.InstantiateParameters parameters, System.Threading.CancellationToken cancellationToken);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.InstantiateParameters parameters, System.Threading.CancellationToken cancellationToken);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters, System.Threading.CancellationToken cancellationToken);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters, System.Threading.CancellationToken cancellationToken);
        static /*0x3907c14*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations, UnityEngine.InstantiateParameters parameters, System.Threading.CancellationToken cancellationToken);
        static /*0x7e756d4*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x7e759bc*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        static /*0x7e75cb0*/ UnityEngine.Object Instantiate(UnityEngine.Object original);
        static /*0x7e75e48*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.SceneManagement.Scene scene);
        static /*0x3907c14*/ T Instantiate<T>(T original, UnityEngine.InstantiateParameters parameters);
        static /*0x3907c14*/ T Instantiate<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters);
        static /*0x7e76004*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent);
        static /*0x7e7606c*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, bool instantiateInWorldSpace);
        static /*0x3907c14*/ T Instantiate<T>(T original);
        static /*0x3907c14*/ T Instantiate<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x3907c14*/ T Instantiate<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        static /*0x3907c14*/ T Instantiate<T>(T original, UnityEngine.Transform parent);
        static /*0x3907c14*/ T Instantiate<T>(T original, UnityEngine.Transform parent, bool worldPositionStays);
        static /*0x7e762c8*/ void Destroy(UnityEngine.Object obj, float t);
        static /*0x7e763c4*/ void Destroy(UnityEngine.Object obj);
        static /*0x7e7641c*/ void DestroyImmediate(UnityEngine.Object obj, bool allowDestroyingAssets);
        static /*0x7e76510*/ void DestroyImmediate(UnityEngine.Object obj);
        static /*0x7e76568*/ UnityEngine.Object[] FindObjectsOfType(System.Type type);
        static /*0x7e765e0*/ UnityEngine.Object[] FindObjectsOfType(System.Type type, bool includeInactive);
        static /*0x7e76624*/ UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode);
        static /*0x7e766ac*/ UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);
        static /*0x7e76700*/ void DontDestroyOnLoad(UnityEngine.Object target);
        static /*0x7e769f0*/ void DestroyObject(UnityEngine.Object obj, float t);
        static /*0x7e76a54*/ void DestroyObject(UnityEngine.Object obj);
        static /*0x7e76aac*/ UnityEngine.Object[] FindSceneObjectsOfType(System.Type type);
        static /*0x7e76b00*/ UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type);
        static /*0x382dee4*/ T[] FindObjectsOfType<T>();
        static /*0x382e920*/ T[] FindObjectsByType<T>(UnityEngine.FindObjectsSortMode sortMode);
        static /*0x382e7b8*/ T[] FindObjectsOfType<T>(bool includeInactive);
        static /*0x382e958*/ T[] FindObjectsByType<T>(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);
        static /*0x3907c14*/ T FindObjectOfType<T>();
        static /*0x3907c14*/ T FindObjectOfType<T>(bool includeInactive);
        static /*0x3907c14*/ T FindFirstObjectByType<T>();
        static /*0x3907c14*/ T FindAnyObjectByType<T>();
        static /*0x3907c14*/ T FindFirstObjectByType<T>(UnityEngine.FindObjectsInactive findObjectsInactive);
        static /*0x3907c14*/ T FindAnyObjectByType<T>(UnityEngine.FindObjectsInactive findObjectsInactive);
        static /*0x7e76b3c*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type);
        static /*0x7e75884*/ void CheckNullArgument(object arg, string message);
        static /*0x7e76b44*/ UnityEngine.Object FindObjectOfType(System.Type type);
        static /*0x7e76bdc*/ UnityEngine.Object FindFirstObjectByType(System.Type type);
        static /*0x7e76c80*/ UnityEngine.Object FindAnyObjectByType(System.Type type);
        static /*0x7e76d24*/ UnityEngine.Object FindObjectOfType(System.Type type, bool includeInactive);
        static /*0x7e76dc8*/ UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive);
        static /*0x7e76e78*/ UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive);
        static /*0x7e751a8*/ bool op_Equality(UnityEngine.Object x, UnityEngine.Object y);
        static /*0x7e77094*/ bool op_Inequality(UnityEngine.Object x, UnityEngine.Object y);
        static /*0x7e77104*/ int GetOffsetOfInstanceIDInCPlusPlusObject();
        static /*0x7e753f4*/ bool CurrentThreadIsMainThread();
        static /*0x7e75d80*/ UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data);
        static /*0x7e75f28*/ UnityEngine.Object Internal_CloneSingleWithScene(UnityEngine.Object data, UnityEngine.SceneManagement.Scene scene);
        static /*0x7e771ac*/ UnityEngine.Object Internal_CloneSingleWithParams(UnityEngine.Object data, UnityEngine.InstantiateParameters parameters);
        static /*0x7e772cc*/ UnityEngine.Object Internal_InstantiateSingleWithParams(UnityEngine.Object data, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters);
        static /*0x7e76194*/ UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, bool worldPositionStays);
        static /*0x7e77470*/ nint Internal_InstantiateAsyncWithParams(UnityEngine.Object original, int count, UnityEngine.InstantiateParameters parameters, nint positions, int positionsCount, nint rotations, int rotationsCount, bool hasManagedCancellationToken);
        static /*0x7e758d0*/ UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
        static /*0x7e75b60*/ UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
        static /*0x7e76f7c*/ string ToString(UnityEngine.Object obj);
        static /*0x7e7773c*/ bool IsPersistent(UnityEngine.Object obj);
        static /*0x7e77868*/ bool DoesObjectWithInstanceIDExist(int instanceID);
        static /*0x7e778a4*/ UnityEngine.Object FindObjectFromInstanceID(int instanceID);
        static /*0x7e77970*/ nint GetPtrFromInstanceID(int instanceID, System.Type objectType, ref bool isMonoBehaviour);
        static /*0x7e779c4*/ UnityEngine.Object ForceLoadFromInstanceID(int instanceID);
        static /*0x7e76378*/ void Destroy_Injected(nint obj, float t);
        static /*0x7e764cc*/ void DestroyImmediate_Injected(nint obj, bool allowDestroyingAssets);
        static /*0x7e767fc*/ void DontDestroyOnLoad_Injected(nint target);
        static /*0x7e768d0*/ UnityEngine.HideFlags get_hideFlags_Injected(nint _unity_self);
        static /*0x7e769ac*/ void set_hideFlags_Injected(nint _unity_self, UnityEngine.HideFlags value);
        static /*0x7e7712c*/ nint Internal_CloneSingle_Injected(nint data);
        static /*0x7e77168*/ nint Internal_CloneSingleWithScene_Injected(nint data, ref UnityEngine.SceneManagement.Scene scene);
        static /*0x7e77288*/ nint Internal_CloneSingleWithParams_Injected(nint data, ref UnityEngine.InstantiateParameters parameters);
        static /*0x7e773c0*/ nint Internal_InstantiateSingleWithParams_Injected(nint data, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.InstantiateParameters parameters);
        static /*0x7e7741c*/ nint Internal_CloneSingleWithParent_Injected(nint data, nint parent, bool worldPositionStays);
        static /*0x7e77578*/ nint Internal_InstantiateAsyncWithParams_Injected(nint original, int count, ref UnityEngine.InstantiateParameters parameters, nint positions, int positionsCount, nint rotations, int rotationsCount, bool hasManagedCancellationToken);
        static /*0x7e77604*/ nint Internal_InstantiateSingle_Injected(nint data, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
        static /*0x7e77658*/ nint Internal_InstantiateSingleWithParent_Injected(nint data, nint parent, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
        static /*0x7e776b4*/ void ToString_Injected(nint obj, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e776f8*/ void GetName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e777e8*/ bool IsPersistent_Injected(nint obj);
        static /*0x7e77824*/ void SetName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e77934*/ nint FindObjectFromInstanceID_Injected(int instanceID);
        static /*0x7e77a54*/ nint ForceLoadFromInstanceID_Injected(int instanceID);
        static /*0x7e77b28*/ void MarkDirty_Injected(nint _unity_self);
        /*0x7e7493c*/ Object();
        /*0x7e7502c*/ int GetInstanceID();
        /*0x7e750a4*/ int GetHashCode();
        /*0x7e750ac*/ bool Equals(object other);
        /*0x7e75338*/ void EnsureRunningOnMainThread();
        /*0x7e7541c*/ nint GetCachedPtr();
        /*0x7e75424*/ string get_name();
        /*0x7e7553c*/ void set_name(string value);
        /*0x7e76838*/ UnityEngine.HideFlags get_hideFlags();
        /*0x7e7690c*/ void set_hideFlags(UnityEngine.HideFlags value);
        /*0x7e76f28*/ string ToString();
        /*0x7e75428*/ string GetName();
        /*0x7e75540*/ void SetName(string name);
        /*0x7e77a90*/ void MarkDirty();

        class MarshalledUnityObject
        {
            static /*0x3907c14*/ nint Marshal<T>(T obj);
            static /*0x3907c14*/ nint MarshalNotNull<T>(T obj);
            static /*0x7e77bd0*/ void TryThrowEditorNullExceptionObject(UnityEngine.Object unityObj, string paramterName);
        }
    }

    class UnitySynchronizationContext : System.Threading.SynchronizationContext
    {
        /*0x18*/ System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue;
        /*0x20*/ System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork;
        /*0x28*/ int m_MainThreadID;
        /*0x2c*/ int m_TrackedCount;

        static /*0x7e78620*/ void InitializeSynchronizationContext();
        static /*0x7e786c8*/ void ExecuteTasks();
        static /*0x7e78720*/ bool ExecutePendingTasks(long millisecondsTimeout);
        /*0x7e77bdc*/ UnitySynchronizationContext(int mainThreadID);
        /*0x7e77ca0*/ UnitySynchronizationContext(System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> queue, int mainThreadID);
        /*0x7e77bd4*/ int get_MainThreadId();
        /*0x7e77d58*/ void Send(System.Threading.SendOrPostCallback callback, object state);
        /*0x7e78104*/ void OperationStarted();
        /*0x7e78110*/ void OperationCompleted();
        /*0x7e7811c*/ void Post(System.Threading.SendOrPostCallback callback, object state);
        /*0x7e782cc*/ System.Threading.SynchronizationContext CreateCopy();
        /*0x7e78330*/ void Exec();
        /*0x7e785c0*/ bool HasPendingTasks();

        struct WorkRequest
        {
            /*0x10*/ System.Threading.SendOrPostCallback m_DelagateCallback;
            /*0x18*/ object m_DelagateState;
            /*0x20*/ System.Threading.ManualResetEvent m_WaitHandle;

            /*0x7e780c0*/ WorkRequest(System.Threading.SendOrPostCallback callback, object state, System.Threading.ManualResetEvent waitHandle);
            /*0x7e78514*/ void Invoke();
        }
    }

    class WaitForEndOfFrame : UnityEngine.YieldInstruction
    {
        /*0x7e7880c*/ WaitForEndOfFrame();
    }

    class WaitForFixedUpdate : UnityEngine.YieldInstruction
    {
        /*0x7e7881c*/ WaitForFixedUpdate();
    }

    class WaitForSeconds : UnityEngine.YieldInstruction
    {
        /*0x10*/ float m_Seconds;

        /*0x7e78824*/ WaitForSeconds(float seconds);
    }

    class WaitForSecondsRealtime : UnityEngine.CustomYieldInstruction
    {
        /*0x10*/ float <waitTime>k__BackingField;
        /*0x14*/ float m_WaitUntilTime;

        /*0x7e78920*/ WaitForSecondsRealtime(float time);
        /*0x7e7884c*/ float get_waitTime();
        /*0x7e78854*/ void set_waitTime(float value);
        /*0x7e7885c*/ bool get_keepWaiting();
        /*0x7e78950*/ void Reset();
    }

    enum WaitTimeoutMode
    {
        Realtime = 0,
        InGameTime = 1,
    }

    class WaitUntil : UnityEngine.CustomYieldInstruction
    {
        /*0x10*/ System.Func<bool> m_Predicate;
        /*0x18*/ System.Action m_TimeoutCallback;
        /*0x20*/ UnityEngine.WaitTimeoutMode m_TimeoutMode;
        /*0x28*/ double m_MaxExecutionTime;

        /*0x7e78a20*/ WaitUntil(System.Func<bool> predicate);
        /*0x7e7895c*/ bool get_keepWaiting();
        /*0x7e78a58*/ double GetTime();
    }

    class YieldInstruction
    {
        /*0x7e78814*/ YieldInstruction();
    }

    class SerializeField : System.Attribute
    {
        /*0x7e78afc*/ SerializeField();
    }

    class SerializeReference : System.Attribute
    {
        /*0x7e78b04*/ SerializeReference();
    }

    class PreferBinarySerialization : System.Attribute
    {
        /*0x7e78b0c*/ PreferBinarySerialization();
    }

    interface ISerializationCallbackReceiver
    {
        /*0x380cb08*/ void OnBeforeSerialize();
        /*0x380cb08*/ void OnAfterDeserialize();
    }

    class ComputeBuffer : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;

        static /*0x7e78d18*/ nint InitBuffer(int count, int stride, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage);
        static /*0x7e78cd0*/ void DestroyBuffer(UnityEngine.ComputeBuffer buf);
        static /*0x7e78d74*/ void DestroyBuffer_Injected(nint buf);
        static /*0x7e79018*/ int get_count_Injected(nint _unity_self);
        static /*0x7e790a0*/ int get_stride_Injected(nint _unity_self);
        static /*0x7e79314*/ void InternalSetNativeData_Injected(nint _unity_self, nint data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);
        static /*0x7e79388*/ void InternalSetData_Injected(nint _unity_self, System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);
        /*0x7e78db0*/ ComputeBuffer(int count, int stride);
        /*0x7e78f98*/ ComputeBuffer(int count, int stride, UnityEngine.ComputeBufferType type);
        /*0x7e78dbc*/ ComputeBuffer(int count, int stride, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage, int stackDepth);
        /*0x7e78b14*/ void Finalize();
        /*0x7e78c6c*/ void Dispose();
        /*0x7e78bac*/ void Dispose(bool disposing);
        /*0x7e78fc8*/ void Release();
        /*0x7e78fcc*/ int get_count();
        /*0x7e79054*/ int get_stride();
        /*0x7e790dc*/ void SetData(System.Array data);
        /*0x3907c14*/ void SetData<T>(Unity.Collections.NativeArray<T> data);
        /*0x3907c14*/ void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count);
        /*0x7e79290*/ void InternalSetNativeData(nint data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);
        /*0x7e7920c*/ void InternalSetData(System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

        class BindingsMarshaller
        {
            static /*0x7e793fc*/ nint ConvertToNative(UnityEngine.ComputeBuffer computeBuffer);
        }
    }

    class ComputeShader : UnityEngine.Object
    {
        static /*0x7e79590*/ int FindKernel_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e79660*/ void SetInt_Injected(nint _unity_self, int nameID, int val);
        static /*0x7e797b4*/ void SetIntArray_Injected(nint _unity_self, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
        static /*0x7e798d8*/ void Internal_SetBuffer_Injected(nint _unity_self, int kernelIndex, int nameID, nint buffer);
        static /*0x7e79a04*/ void Internal_SetGraphicsBuffer_Injected(nint _unity_self, int kernelIndex, int nameID, nint buffer);
        static /*0x7e79b48*/ void SetConstantComputeBuffer_Injected(nint _unity_self, int nameID, nint buffer, int offset, int size);
        static /*0x7e79c58*/ void GetKernelThreadGroupSizes_Injected(nint _unity_self, int kernelIndex, ref uint x, ref uint y, ref uint z);
        static /*0x7e79d68*/ void Dispatch_Injected(nint _unity_self, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
        static /*0x7e79e58*/ void get_keywordSpace_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeywordSpace ret);
        static /*0x7e7a00c*/ void EnableKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e7a1c0*/ void DisableKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e7a280*/ void SetShaderKeywords_Injected(nint _unity_self, string[] names);
        /*0x7e7a2c8*/ ComputeShader();
        /*0x7e79414*/ int FindKernel(string name);
        /*0x7e795d4*/ void SetInt(int nameID, int val);
        /*0x7e796b4*/ void SetIntArray(int nameID, int[] values);
        /*0x7e79808*/ void Internal_SetBuffer(int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
        /*0x7e79934*/ void Internal_SetGraphicsBuffer(int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
        /*0x7e79a60*/ void SetBuffer(int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
        /*0x7e79a64*/ void SetBuffer(int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
        /*0x7e79a68*/ void SetConstantComputeBuffer(int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
        /*0x7e79bb4*/ void GetKernelThreadGroupSizes(int kernelIndex, ref uint x, ref uint y, ref uint z);
        /*0x7e79cc4*/ void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
        /*0x7e79dd4*/ UnityEngine.Rendering.LocalKeywordSpace get_keywordSpace();
        /*0x7e79e9c*/ void EnableKeyword(string keyword);
        /*0x7e7a050*/ void DisableKeyword(string keyword);
        /*0x7e7a204*/ void SetShaderKeywords(string[] names);
        /*0x7e7a2c4*/ void set_shaderKeywords(string[] value);
        /*0x7e7a320*/ void SetInts(int nameID, int[] values);
        /*0x7e7a324*/ void SetConstantBuffer(int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
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
        /*0x7e7a328*/ void LowerResBlitTextureDontStripMe();
    }

    class PreloadData : UnityEngine.Object
    {
        /*0x7e7a32c*/ void PreloadDataDontStripMe();
    }

    enum BatteryStatus
    {
        Unknown = 0,
        Charging = 1,
        Discharging = 2,
        NotCharging = 3,
        Full = 4,
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
        static /*0x7e7a330*/ float get_batteryLevel();
        static /*0x7e7a380*/ UnityEngine.BatteryStatus get_batteryStatus();
        static /*0x7e7a3d0*/ string get_operatingSystem();
        static /*0x7e7a480*/ UnityEngine.OperatingSystemFamily get_operatingSystemFamily();
        static /*0x7e7a4d0*/ string get_processorType();
        static /*0x7e7a580*/ int get_processorCount();
        static /*0x7e7a5d0*/ int get_systemMemorySize();
        static /*0x7e7a620*/ string get_deviceUniqueIdentifier();
        static /*0x7e7a6d0*/ string get_deviceName();
        static /*0x7e7a780*/ string get_deviceModel();
        static /*0x7e7a830*/ bool get_supportsAccelerometer();
        static /*0x7e7a880*/ bool get_supportsGyroscope();
        static /*0x7e7a8d0*/ bool get_supportsLocationService();
        static /*0x7e7a920*/ bool get_supportsVibration();
        static /*0x7e7a970*/ UnityEngine.DeviceType get_deviceType();
        static /*0x7e7a9c0*/ int get_graphicsMemorySize();
        static /*0x7e7aa10*/ string get_graphicsDeviceName();
        static /*0x7e7aac0*/ string get_graphicsDeviceVendor();
        static /*0x7e7ab70*/ int get_graphicsDeviceVendorID();
        static /*0x7e7abc0*/ UnityEngine.Rendering.GraphicsDeviceType get_graphicsDeviceType();
        static /*0x7e7ac10*/ bool get_graphicsUVStartsAtTop();
        static /*0x7e7ac60*/ string get_graphicsDeviceVersion();
        static /*0x7e7ad10*/ int get_graphicsShaderLevel();
        static /*0x7e7ad60*/ UnityEngine.Rendering.FoveatedRenderingCaps get_foveatedRenderingCaps();
        static /*0x7e7adb0*/ bool get_hasHiddenSurfaceRemovalOnGPU();
        static /*0x7e7ae00*/ bool get_supportsShadows();
        static /*0x7e7ae50*/ bool get_supportsMotionVectors();
        static /*0x7e7aea0*/ bool get_supports3DRenderTextures();
        static /*0x7e7aef0*/ UnityEngine.Rendering.CopyTextureSupport get_copyTextureSupport();
        static /*0x7e7af40*/ bool get_supportsComputeShaders();
        static /*0x7e7af90*/ bool get_supportsRenderTargetArrayIndexFromVertexShader();
        static /*0x7e7afe0*/ bool get_supportsInstancing();
        static /*0x7e7b030*/ bool get_supportsSparseTextures();
        static /*0x7e7b080*/ int get_supportedRenderTargetCount();
        static /*0x7e7b0d0*/ int get_supportsMultisampledTextures();
        static /*0x7e7b120*/ bool get_supportsMultisampledBackBuffer();
        static /*0x7e7b170*/ bool get_supportsMultisampleAutoResolve();
        static /*0x7e7b1c0*/ bool get_usesReversedZBuffer();
        static /*0x7e7b210*/ bool IsValidEnumValue(System.Enum value);
        static /*0x7e7b264*/ bool SupportsRenderTextureFormat(UnityEngine.RenderTextureFormat format);
        static /*0x7e7b374*/ bool SupportsTextureFormat(UnityEngine.TextureFormat format);
        static /*0x7e7b484*/ UnityEngine.NPOTSupport get_npotSupport();
        static /*0x7e7b4d4*/ int get_maxTextureSize();
        static /*0x7e7b524*/ int get_maxRenderTextureSize();
        static /*0x7e7b574*/ bool get_supportsGraphicsFence();
        static /*0x7e78fa0*/ long get_maxGraphicsBufferSize();
        static /*0x7e7b5ec*/ bool get_usesLoadStoreActions();
        static /*0x7e7b63c*/ UnityEngine.HDRDisplaySupportFlags get_hdrDisplaySupportFlags();
        static /*0x7e7b68c*/ bool get_supportsMultiview();
        static /*0x7e7b6dc*/ bool get_supportsStoreAndResolveAction();
        static /*0x7e7b72c*/ bool get_supportsMultisampleResolveDepth();
        static /*0x7e7b77c*/ bool get_supportsMultisampleResolveStencil();
        static /*0x7e7b7cc*/ bool get_supportsIndirectArgumentsBuffer();
        static /*0x7e7a358*/ float GetBatteryLevel();
        static /*0x7e7a3a8*/ UnityEngine.BatteryStatus GetBatteryStatus();
        static /*0x7e7a3d4*/ string GetOperatingSystem();
        static /*0x7e7a4a8*/ UnityEngine.OperatingSystemFamily GetOperatingSystemFamily();
        static /*0x7e7a4d4*/ string GetProcessorType();
        static /*0x7e7a5a8*/ int GetProcessorCount();
        static /*0x7e7a5f8*/ int GetPhysicalMemoryMB();
        static /*0x7e7a624*/ string GetDeviceUniqueIdentifier();
        static /*0x7e7a6d4*/ string GetDeviceName();
        static /*0x7e7a784*/ string GetDeviceModel();
        static /*0x7e7a858*/ bool SupportsAccelerometer();
        static /*0x7e7a8a8*/ bool IsGyroAvailable();
        static /*0x7e7a8f8*/ bool SupportsLocationService();
        static /*0x7e7a948*/ bool SupportsVibration();
        static /*0x7e7a998*/ UnityEngine.DeviceType GetDeviceType();
        static /*0x7e7a9e8*/ int GetGraphicsMemorySize();
        static /*0x7e7aa14*/ string GetGraphicsDeviceName();
        static /*0x7e7aac4*/ string GetGraphicsDeviceVendor();
        static /*0x7e7ab98*/ int GetGraphicsDeviceVendorID();
        static /*0x7e7abe8*/ UnityEngine.Rendering.GraphicsDeviceType GetGraphicsDeviceType();
        static /*0x7e7ac38*/ bool GetGraphicsUVStartsAtTop();
        static /*0x7e7ac64*/ string GetGraphicsDeviceVersion();
        static /*0x7e7ad38*/ int GetGraphicsShaderLevel();
        static /*0x7e7ad88*/ UnityEngine.Rendering.FoveatedRenderingCaps GetFoveatedRenderingCaps();
        static /*0x7e7add8*/ bool HasHiddenSurfaceRemovalOnGPU();
        static /*0x7e7ae28*/ bool SupportsShadows();
        static /*0x7e7ae78*/ bool SupportsMotionVectors();
        static /*0x7e7aec8*/ bool Supports3DRenderTextures();
        static /*0x7e7af18*/ UnityEngine.Rendering.CopyTextureSupport GetCopyTextureSupport();
        static /*0x7e7af68*/ bool SupportsComputeShaders();
        static /*0x7e7afb8*/ bool SupportsRenderTargetArrayIndexFromVertexShader();
        static /*0x7e7b008*/ bool SupportsInstancing();
        static /*0x7e7b058*/ bool SupportsSparseTextures();
        static /*0x7e7b0a8*/ int SupportedRenderTargetCount();
        static /*0x7e7b0f8*/ int SupportsMultisampledTextures();
        static /*0x7e7b148*/ bool SupportsMultisampledBackBuffer();
        static /*0x7e7b198*/ bool SupportsMultisampleAutoResolve();
        static /*0x7e7b1e8*/ bool UsesReversedZBuffer();
        static /*0x7e7b338*/ bool HasRenderTextureNative(UnityEngine.RenderTextureFormat format);
        static /*0x7e7b448*/ bool SupportsTextureFormatNative(UnityEngine.TextureFormat format);
        static /*0x7e7b4ac*/ UnityEngine.NPOTSupport GetNPOTSupport();
        static /*0x7e7b4fc*/ int GetMaxTextureSize();
        static /*0x7e7b54c*/ int GetMaxRenderTextureSize();
        static /*0x7e7b59c*/ bool SupportsGPUFence();
        static /*0x7e7b5c4*/ long MaxGraphicsBufferSize();
        static /*0x7e7b9fc*/ bool IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.GraphicsFormatUsage usage);
        static /*0x7e7ba40*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.GraphicsFormatUsage usage);
        static /*0x7e7ba84*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat format);
        static /*0x7e7bac0*/ int GetRenderTextureSupportedMSAASampleCount(UnityEngine.RenderTextureDescriptor desc);
        static /*0x7e7b614*/ bool UsesLoadStoreActions();
        static /*0x7e7b664*/ UnityEngine.HDRDisplaySupportFlags GetHDRDisplaySupportFlags();
        static /*0x7e7b6b4*/ bool SupportsMultiview();
        static /*0x7e7b704*/ bool SupportsStoreAndResolveAction();
        static /*0x7e7b754*/ bool SupportsMultisampleResolveDepth();
        static /*0x7e7b7a4*/ bool SupportsMultisampleResolveStencil();
        static /*0x7e7b7f4*/ bool SupportsIndirectArgumentsBuffer();
        static /*0x7e7b81c*/ void GetOperatingSystem_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e7b858*/ void GetProcessorType_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e7b894*/ void GetDeviceUniqueIdentifier_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e7b8d0*/ void GetDeviceName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e7b90c*/ void GetDeviceModel_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e7b948*/ void GetGraphicsDeviceName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e7b984*/ void GetGraphicsDeviceVendor_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e7b9c0*/ void GetGraphicsDeviceVersion_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e7bafc*/ int GetRenderTextureSupportedMSAASampleCount_Injected(ref UnityEngine.RenderTextureDescriptor desc);
    }

    class SystemClock
    {
        static /*0x0*/ System.DateTime s_Epoch;

        static /*0x7e7bb88*/ SystemClock();
        static /*0x7e7bb38*/ System.DateTime get_now();
    }

    class Time
    {
        static /*0x7e7bc04*/ float get_time();
        static /*0x7e78ad4*/ double get_timeAsDouble();
        static /*0x7e7bc2c*/ Unity.IntegerTime.RationalTime get_timeAsRational();
        static /*0x7e7bcac*/ float get_timeSinceLevelLoad();
        static /*0x7e7bcd4*/ float get_deltaTime();
        static /*0x7e7bcfc*/ float get_fixedTime();
        static /*0x7e7bd24*/ float get_unscaledTime();
        static /*0x7e7bd4c*/ float get_fixedUnscaledTime();
        static /*0x7e7bd74*/ float get_unscaledDeltaTime();
        static /*0x7e7bd9c*/ float get_fixedDeltaTime();
        static /*0x7e7bdc4*/ float get_smoothDeltaTime();
        static /*0x7e7bdec*/ float get_timeScale();
        static /*0x7e7be14*/ void set_timeScale(float value);
        static /*0x7e7be4c*/ int get_frameCount();
        static /*0x7e7be74*/ int get_renderedFrameCount();
        static /*0x7e788f8*/ float get_realtimeSinceStartup();
        static /*0x7e78aac*/ double get_realtimeSinceStartupAsDouble();
        static /*0x7e7be9c*/ bool get_inFixedTimeStep();
        static /*0x7e7bc70*/ void get_timeAsRational_Injected(ref Unity.IntegerTime.RationalTime ret);
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

        static /*0x7e7bec4*/ void Internal_Destroy(nint ptr);
        static /*0x7e7c16c*/ nint TouchScreenKeyboard_InternalConstructorHelper(ref UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder);
        static /*0x7e7c3bc*/ bool get_isSupported();
        static /*0x7e7c480*/ bool get_disableInPlaceEditing();
        static /*0x7e7c4c8*/ bool get_isInPlaceEditingAllowed();
        static /*0x7e7c534*/ bool IsInPlaceEditingAllowed();
        static /*0x7e7c55c*/ UnityEngine.TouchScreenKeyboard Open(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit);
        static /*0x7e7c614*/ UnityEngine.TouchScreenKeyboard Open(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure);
        static /*0x7e7c95c*/ void set_hideInput(bool value);
        static /*0x7e7c998*/ UnityEngine.TouchScreenKeyboard.InputFieldAppearance get_inputFieldAppearance();
        static /*0x7e7cd5c*/ void GetSelection(ref int start, ref int length);
        static /*0x7e7ce64*/ void SetSelection(int start, int length);
        static /*0x7e7c368*/ nint TouchScreenKeyboard_InternalConstructorHelper_Injected(ref UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments arguments, ref UnityEngine.Bindings.ManagedSpanWrapper text, ref UnityEngine.Bindings.ManagedSpanWrapper textPlaceholder);
        static /*0x7e7c770*/ void get_text_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e7c918*/ void set_text_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7e7ca0c*/ bool get_active_Injected(nint _unity_self);
        static /*0x7e7ca9c*/ void set_active_Injected(nint _unity_self, bool value);
        static /*0x7e7cb2c*/ UnityEngine.TouchScreenKeyboard.Status get_status_Injected(nint _unity_self);
        static /*0x7e7cbbc*/ void set_characterLimit_Injected(nint _unity_self, int value);
        static /*0x7e7cc4c*/ bool get_canGetSelection_Injected(nint _unity_self);
        static /*0x7e7ccd4*/ bool get_canSetSelection_Injected(nint _unity_self);
        /*0x7e7c028*/ TouchScreenKeyboard(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit);
        /*0x7e7bf00*/ void Destroy();
        /*0x7e7bf94*/ void Finalize();
        /*0x7e7c6a0*/ string get_text();
        /*0x7e7c7b4*/ void set_text(string value);
        /*0x7e7c9c0*/ bool get_active();
        /*0x7e7ca48*/ void set_active(bool value);
        /*0x7e7cae0*/ UnityEngine.TouchScreenKeyboard.Status get_status();
        /*0x7e7cb68*/ void set_characterLimit(int value);
        /*0x7e7cc00*/ bool get_canGetSelection();
        /*0x7e7cc88*/ bool get_canSetSelection();
        /*0x7e7cd10*/ UnityEngine.RangeInt get_selection();
        /*0x7e7cda0*/ void set_selection(UnityEngine.RangeInt value);

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
            static /*0x7e7cea8*/ nint ConvertToNative(UnityEngine.TouchScreenKeyboard touchScreenKeyboard);
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

        static /*0x7e7d640*/ UINumericFieldsUtils();
        static /*0x7e7cec0*/ bool TryConvertStringToDouble(string str, ref double value, ref UnityEngine.ExpressionEvaluator.Expression expr);
        static /*0x7e7d05c*/ bool TryConvertStringToDouble(string str, string initialValueAsString, ref double value);
        static /*0x7e7d164*/ bool TryConvertStringToFloat(string str, string initialValueAsString, ref float value);
        static /*0x7e7d1f8*/ bool TryConvertStringToLong(string str, ref long value, ref UnityEngine.ExpressionEvaluator.Expression expr);
        static /*0x7e7d27c*/ bool TryConvertStringToLong(string str, string initialValueAsString, ref long value);
        static /*0x7e7d380*/ bool TryConvertStringToULong(string str, ref ulong value, ref UnityEngine.ExpressionEvaluator.Expression expr);
        static /*0x7e7d404*/ bool TryConvertStringToULong(string str, string initialValueAsString, ref ulong value);
        static /*0x7e7d508*/ bool TryConvertStringToInt(string str, string initialValueAsString, ref int value);
        static /*0x7e7d5a4*/ bool TryConvertStringToUInt(string str, string initialValueAsString, ref uint value);
    }

    class NameFormatter
    {
        static /*0x7e7d75c*/ string FormatVariableName(string name);
        static /*0x7e7d8d4*/ void FormatVariableName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
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
        /*0x7e7d918*/ void Add(UnityEngine.Object driver, UnityEngine.RectTransform rectTransform, UnityEngine.DrivenTransformProperties drivenProperties);
        /*0x7e7d91c*/ void Clear();
    }

    class RectTransform : UnityEngine.Transform
    {
        static /*0x0*/ UnityEngine.RectTransform.ReapplyDrivenProperties reapplyDrivenProperties;

        static /*0x7e7d920*/ void add_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value);
        static /*0x7e7d9d8*/ void remove_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value);
        static /*0x7e7f0e0*/ void SendReapplyDrivenProperties(UnityEngine.RectTransform driven);
        static /*0x7e7db20*/ void get_rect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x7e7dbe8*/ void get_anchorMin_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e7dcac*/ void set_anchorMin_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e7dd74*/ void get_anchorMax_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e7de38*/ void set_anchorMax_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e7df00*/ void get_anchoredPosition_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e7dfc4*/ void set_anchoredPosition_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e7e08c*/ void get_sizeDelta_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e7e150*/ void set_sizeDelta_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e7e218*/ void get_pivot_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e7e2dc*/ void set_pivot_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e7e818*/ nint get_drivenByObject_Injected(nint _unity_self);
        static /*0x7e7e8fc*/ void set_drivenByObject_Injected(nint _unity_self, nint value);
        static /*0x7e7e9b4*/ UnityEngine.DrivenTransformProperties get_drivenProperties_Injected(nint _unity_self);
        static /*0x7e7ea6c*/ void set_drivenProperties_Injected(nint _unity_self, UnityEngine.DrivenTransformProperties value);
        static /*0x7e7eb24*/ void ForceUpdateRectTransforms_Injected(nint _unity_self);
        /*0x7e7f2c8*/ RectTransform();
        /*0x7e7da90*/ UnityEngine.Rect get_rect();
        /*0x7e7db64*/ UnityEngine.Vector2 get_anchorMin();
        /*0x7e7dc2c*/ void set_anchorMin(UnityEngine.Vector2 value);
        /*0x7e7dcf0*/ UnityEngine.Vector2 get_anchorMax();
        /*0x7e7ddb8*/ void set_anchorMax(UnityEngine.Vector2 value);
        /*0x7e7de7c*/ UnityEngine.Vector2 get_anchoredPosition();
        /*0x7e7df44*/ void set_anchoredPosition(UnityEngine.Vector2 value);
        /*0x7e7e008*/ UnityEngine.Vector2 get_sizeDelta();
        /*0x7e7e0d0*/ void set_sizeDelta(UnityEngine.Vector2 value);
        /*0x7e7e194*/ UnityEngine.Vector2 get_pivot();
        /*0x7e7e25c*/ void set_pivot(UnityEngine.Vector2 value);
        /*0x7e7e320*/ UnityEngine.Vector3 get_anchoredPosition3D();
        /*0x7e7e3e8*/ void set_anchoredPosition3D(UnityEngine.Vector3 value);
        /*0x7e7e4a4*/ UnityEngine.Vector2 get_offsetMin();
        /*0x7e7e4f8*/ void set_offsetMin(UnityEngine.Vector2 value);
        /*0x7e7e5ec*/ UnityEngine.Vector2 get_offsetMax();
        /*0x7e7e68c*/ void set_offsetMax(UnityEngine.Vector2 value);
        /*0x7e7e788*/ UnityEngine.Object get_drivenByObject();
        /*0x7e7e854*/ void set_drivenByObject(UnityEngine.Object value);
        /*0x7e7e940*/ UnityEngine.DrivenTransformProperties get_drivenProperties();
        /*0x7e7e9f0*/ void set_drivenProperties(UnityEngine.DrivenTransformProperties value);
        /*0x7e7eab0*/ void ForceUpdateRectTransforms();
        /*0x7e7eb60*/ void GetLocalCorners(UnityEngine.Vector3[] fourCornersArray);
        /*0x7e7ec40*/ void GetWorldCorners(UnityEngine.Vector3[] fourCornersArray);
        /*0x7e7edf4*/ void SetInsetAndSizeFromParentEdge(UnityEngine.RectTransform.Edge edge, float inset, float size);
        /*0x7e7ef04*/ void SetSizeWithCurrentAnchors(UnityEngine.RectTransform.Axis axis, float size);
        /*0x7e7f14c*/ UnityEngine.Rect GetRectInParentSpace();
        /*0x7e7effc*/ UnityEngine.Vector2 GetParentSize();

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
            /*0x7e7f2d8*/ ReapplyDrivenProperties(object object, nint method);
            /*0x7e7f388*/ void Invoke(UnityEngine.RectTransform driven);
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
        static /*0x7e7f430*/ void get_position_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e7f500*/ void set_position_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7e7f544*/ void get_localPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e7f588*/ void set_localPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7e7f668*/ void GetLocalEulerAngles_Injected(nint _unity_self, UnityEngine.RotationOrder order, ref UnityEngine.Vector3 ret);
        static /*0x7e7f750*/ void SetLocalEulerAngles_Injected(nint _unity_self, ref UnityEngine.Vector3 euler, UnityEngine.RotationOrder order);
        static /*0x7e7f830*/ void SetLocalEulerHint_Injected(nint _unity_self, ref UnityEngine.Vector3 euler);
        static /*0x7e7fe04*/ void get_rotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7e7fe48*/ void set_rotation_Injected(nint _unity_self, ref UnityEngine.Quaternion value);
        static /*0x7e7fe8c*/ void get_localRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7e7fed0*/ void set_localRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion value);
        static /*0x7e8000c*/ int GetRotationOrderInternal_Injected(nint _unity_self);
        static /*0x7e80048*/ void SetRotationOrderInternal_Injected(nint _unity_self, UnityEngine.RotationOrder rotationOrder);
        static /*0x7e80120*/ void get_localScale_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e801f0*/ void set_localScale_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7e80384*/ nint GetParent_Injected(nint _unity_self);
        static /*0x7e80478*/ void SetParent_Injected(nint _unity_self, nint parent, bool worldPositionStays);
        static /*0x7e80570*/ void get_worldToLocalMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e805b4*/ void get_localToWorldMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e80690*/ void SetPositionAndRotation_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
        static /*0x7e8077c*/ void SetLocalPositionAndRotation_Injected(nint _unity_self, ref UnityEngine.Vector3 localPosition, ref UnityEngine.Quaternion localRotation);
        static /*0x7e8085c*/ void GetPositionAndRotation_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
        static /*0x7e8093c*/ void GetLocalPositionAndRotation_Injected(nint _unity_self, ref UnityEngine.Vector3 localPosition, ref UnityEngine.Quaternion localRotation);
        static /*0x7e80ee8*/ void RotateAroundInternal_Injected(nint _unity_self, ref UnityEngine.Vector3 axis, float angle);
        static /*0x7e8135c*/ void Internal_LookAt_Injected(nint _unity_self, ref UnityEngine.Vector3 worldPosition, ref UnityEngine.Vector3 worldUp);
        static /*0x7e813b0*/ void TransformDirection_Injected(nint _unity_self, ref UnityEngine.Vector3 direction, ref UnityEngine.Vector3 ret);
        static /*0x7e81538*/ void TransformDirectionsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper directions, ref UnityEngine.Bindings.ManagedSpanWrapper transformedDirections);
        static /*0x7e81770*/ void InverseTransformDirection_Injected(nint _unity_self, ref UnityEngine.Vector3 direction, ref UnityEngine.Vector3 ret);
        static /*0x7e818f8*/ void InverseTransformDirectionsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper directions, ref UnityEngine.Bindings.ManagedSpanWrapper transformedDirections);
        static /*0x7e81b30*/ void TransformVector_Injected(nint _unity_self, ref UnityEngine.Vector3 vector, ref UnityEngine.Vector3 ret);
        static /*0x7e81cb8*/ void TransformVectorsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper vectors, ref UnityEngine.Bindings.ManagedSpanWrapper transformedVectors);
        static /*0x7e81ef0*/ void InverseTransformVector_Injected(nint _unity_self, ref UnityEngine.Vector3 vector, ref UnityEngine.Vector3 ret);
        static /*0x7e82078*/ void InverseTransformVectorsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper vectors, ref UnityEngine.Bindings.ManagedSpanWrapper transformedVectors);
        static /*0x7e822b0*/ void TransformPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x7e82438*/ void TransformPointsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper positions, ref UnityEngine.Bindings.ManagedSpanWrapper transformedPositions);
        static /*0x7e82670*/ void InverseTransformPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x7e827f8*/ void InverseTransformPointsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper positions, ref UnityEngine.Bindings.ManagedSpanWrapper transformedPositions);
        static /*0x7e82a24*/ nint GetRoot_Injected(nint _unity_self);
        static /*0x7e82ad4*/ int get_childCount_Injected(nint _unity_self);
        static /*0x7e82b84*/ void DetachChildren_Injected(nint _unity_self);
        static /*0x7e82c34*/ void SetAsFirstSibling_Injected(nint _unity_self);
        static /*0x7e82ce4*/ void SetAsLastSibling_Injected(nint _unity_self);
        static /*0x7e82d9c*/ void SetSiblingIndex_Injected(nint _unity_self, int index);
        static /*0x7e82e98*/ void MoveAfterSibling_Injected(nint _unity_self, nint transform, bool notifyEditorAndMarkDirty);
        static /*0x7e82f60*/ int GetSiblingIndex_Injected(nint _unity_self);
        static /*0x7e8316c*/ nint FindRelativeTransformWithPath_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper path, bool isActiveOnly);
        static /*0x7e8328c*/ void SendTransformChangedScale_Injected(nint _unity_self);
        static /*0x7e8335c*/ void get_lossyScale_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e83458*/ bool IsChildOf_Injected(nint _unity_self, nint parent);
        static /*0x7e83510*/ bool get_hasChanged_Injected(nint _unity_self);
        static /*0x7e835c8*/ void set_hasChanged_Injected(nint _unity_self, bool value);
        static /*0x7e83754*/ void RotateAround_Injected(nint _unity_self, ref UnityEngine.Vector3 axis, float angle);
        static /*0x7e83844*/ void RotateAroundLocal_Injected(nint _unity_self, ref UnityEngine.Vector3 axis, float angle);
        static /*0x7e83938*/ nint GetChild_Injected(nint _unity_self, int index);
        static /*0x7e839f0*/ int GetChildCount_Injected(nint _unity_self);
        static /*0x7e83b24*/ int internal_getHierarchyCapacity_Injected(nint _unity_self);
        static /*0x7e83b60*/ void internal_setHierarchyCapacity_Injected(nint _unity_self, int value);
        static /*0x7e83c1c*/ int internal_getHierarchyCount_Injected(nint _unity_self);
        static /*0x7e83ccc*/ bool IsNonUniformScaleTransform_Injected(nint _unity_self);
        static /*0x7e83e04*/ void SetConstrainProportionsScale_Injected(nint _unity_self, bool isLinked);
        static /*0x7e83e48*/ bool IsConstrainProportionsScale_Injected(nint _unity_self);
        /*0x7e7f2d0*/ Transform();
        /*0x7e7f39c*/ UnityEngine.Vector3 get_position();
        /*0x7e7f474*/ void set_position(UnityEngine.Vector3 value);
        /*0x7e7e354*/ UnityEngine.Vector3 get_localPosition();
        /*0x7e7e418*/ void set_localPosition(UnityEngine.Vector3 value);
        /*0x7e7f5cc*/ UnityEngine.Vector3 GetLocalEulerAngles(UnityEngine.RotationOrder order);
        /*0x7e7f6bc*/ void SetLocalEulerAngles(UnityEngine.Vector3 euler, UnityEngine.RotationOrder order);
        /*0x7e7f7a4*/ void SetLocalEulerHint(UnityEngine.Vector3 euler);
        /*0x7e7f874*/ UnityEngine.Vector3 get_eulerAngles();
        /*0x7e7f934*/ void set_eulerAngles(UnityEngine.Vector3 value);
        /*0x7e7f9f0*/ UnityEngine.Vector3 get_localEulerAngles();
        /*0x7e7fab0*/ void set_localEulerAngles(UnityEngine.Vector3 value);
        /*0x7e7fb6c*/ UnityEngine.Vector3 get_right();
        /*0x7e7fbe8*/ void set_right(UnityEngine.Vector3 value);
        /*0x7e7fc6c*/ UnityEngine.Vector3 get_up();
        /*0x7e7fce8*/ void set_up(UnityEngine.Vector3 value);
        /*0x7e7fd6c*/ UnityEngine.Vector3 get_forward();
        /*0x7e7fde8*/ void set_forward(UnityEngine.Vector3 value);
        /*0x7e7f8a4*/ UnityEngine.Quaternion get_rotation();
        /*0x7e7f964*/ void set_rotation(UnityEngine.Quaternion value);
        /*0x7e7fa20*/ UnityEngine.Quaternion get_localRotation();
        /*0x7e7fae0*/ void set_localRotation(UnityEngine.Quaternion value);
        /*0x7e7ff14*/ UnityEngine.RotationOrder get_rotationOrder();
        /*0x7e7ff8c*/ void set_rotationOrder(UnityEngine.RotationOrder value);
        /*0x7e7ff18*/ int GetRotationOrderInternal();
        /*0x7e7ff90*/ void SetRotationOrderInternal(UnityEngine.RotationOrder rotationOrder);
        /*0x7e8008c*/ UnityEngine.Vector3 get_localScale();
        /*0x7e80164*/ void set_localScale(UnityEngine.Vector3 value);
        /*0x7e7f2c4*/ UnityEngine.Transform get_parent();
        /*0x7e80238*/ void set_parent(UnityEngine.Transform value);
        /*0x7e80234*/ UnityEngine.Transform get_parentInternal();
        /*0x7e802e4*/ void set_parentInternal(UnityEngine.Transform value);
        /*0x7e802ec*/ UnityEngine.Transform GetParent();
        /*0x7e8037c*/ void SetParent(UnityEngine.Transform p);
        /*0x7e803c0*/ void SetParent(UnityEngine.Transform parent, bool worldPositionStays);
        /*0x7e804cc*/ UnityEngine.Matrix4x4 get_worldToLocalMatrix();
        /*0x7e7ed50*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
        /*0x7e805f8*/ void SetPositionAndRotation(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        /*0x7e806e4*/ void SetLocalPositionAndRotation(UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation);
        /*0x7e807d0*/ void GetPositionAndRotation(ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
        /*0x7e808b0*/ void GetLocalPositionAndRotation(ref UnityEngine.Vector3 localPosition, ref UnityEngine.Quaternion localRotation);
        /*0x7e80990*/ void Translate(UnityEngine.Vector3 translation, UnityEngine.Space relativeTo);
        /*0x7e80ab8*/ void Translate(UnityEngine.Vector3 translation);
        /*0x7e80ac0*/ void Translate(float x, float y, float z, UnityEngine.Space relativeTo);
        /*0x7e80ac4*/ void Translate(float x, float y, float z);
        /*0x7e80acc*/ void Translate(UnityEngine.Vector3 translation, UnityEngine.Transform relativeTo);
        /*0x7e80bac*/ void Translate(float x, float y, float z, UnityEngine.Transform relativeTo);
        /*0x7e80bb0*/ void Rotate(UnityEngine.Vector3 eulers, UnityEngine.Space relativeTo);
        /*0x7e80e38*/ void Rotate(UnityEngine.Vector3 eulers);
        /*0x7e80e40*/ void Rotate(float xAngle, float yAngle, float zAngle, UnityEngine.Space relativeTo);
        /*0x7e80e44*/ void Rotate(float xAngle, float yAngle, float zAngle);
        /*0x7e80e4c*/ void RotateAroundInternal(UnityEngine.Vector3 axis, float angle);
        /*0x7e80f3c*/ void Rotate(UnityEngine.Vector3 axis, float angle, UnityEngine.Space relativeTo);
        /*0x7e80fc8*/ void Rotate(UnityEngine.Vector3 axis, float angle);
        /*0x7e80fd0*/ void RotateAround(UnityEngine.Vector3 point, UnityEngine.Vector3 axis, float angle);
        /*0x7e81094*/ void LookAt(UnityEngine.Transform target, UnityEngine.Vector3 worldUp);
        /*0x7e81154*/ void LookAt(UnityEngine.Transform target);
        /*0x7e81150*/ void LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp);
        /*0x7e812e0*/ void LookAt(UnityEngine.Vector3 worldPosition);
        /*0x7e81248*/ void Internal_LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp);
        /*0x7e80a18*/ UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3 direction);
        /*0x7e81404*/ UnityEngine.Vector3 TransformDirection(float x, float y, float z);
        /*0x7e81408*/ void TransformDirectionsInternal(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections);
        /*0x7e8158c*/ void TransformDirections(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections);
        /*0x7e81654*/ void TransformDirections(System.Span<UnityEngine.Vector3> directions);
        /*0x7e816d0*/ UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3 direction);
        /*0x7e817c4*/ UnityEngine.Vector3 InverseTransformDirection(float x, float y, float z);
        /*0x7e817c8*/ void InverseTransformDirectionsInternal(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections);
        /*0x7e8194c*/ void InverseTransformDirections(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections);
        /*0x7e81a14*/ void InverseTransformDirections(System.Span<UnityEngine.Vector3> directions);
        /*0x7e81a90*/ UnityEngine.Vector3 TransformVector(UnityEngine.Vector3 vector);
        /*0x7e81b84*/ UnityEngine.Vector3 TransformVector(float x, float y, float z);
        /*0x7e81b88*/ void TransformVectorsInternal(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors);
        /*0x7e81d0c*/ void TransformVectors(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors);
        /*0x7e81dd4*/ void TransformVectors(System.Span<UnityEngine.Vector3> vectors);
        /*0x7e81e50*/ UnityEngine.Vector3 InverseTransformVector(UnityEngine.Vector3 vector);
        /*0x7e81f44*/ UnityEngine.Vector3 InverseTransformVector(float x, float y, float z);
        /*0x7e81f48*/ void InverseTransformVectorsInternal(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors);
        /*0x7e820cc*/ void InverseTransformVectors(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors);
        /*0x7e82194*/ void InverseTransformVectors(System.Span<UnityEngine.Vector3> vectors);
        /*0x7e82210*/ UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 position);
        /*0x7e82304*/ UnityEngine.Vector3 TransformPoint(float x, float y, float z);
        /*0x7e82308*/ void TransformPointsInternal(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions);
        /*0x7e8248c*/ void TransformPoints(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions);
        /*0x7e82554*/ void TransformPoints(System.Span<UnityEngine.Vector3> positions);
        /*0x7e825d0*/ UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 position);
        /*0x7e826c4*/ UnityEngine.Vector3 InverseTransformPoint(float x, float y, float z);
        /*0x7e826c8*/ void InverseTransformPointsInternal(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions);
        /*0x7e8284c*/ void InverseTransformPoints(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions);
        /*0x7e82914*/ void InverseTransformPoints(System.Span<UnityEngine.Vector3> positions);
        /*0x7e82990*/ UnityEngine.Transform get_root();
        /*0x7e82994*/ UnityEngine.Transform GetRoot();
        /*0x7e82a60*/ int get_childCount();
        /*0x7e82b10*/ void DetachChildren();
        /*0x7e82bc0*/ void SetAsFirstSibling();
        /*0x7e82c70*/ void SetAsLastSibling();
        /*0x7e82d20*/ void SetSiblingIndex(int index);
        /*0x7e82de0*/ void MoveAfterSibling(UnityEngine.Transform transform, bool notifyEditorAndMarkDirty);
        /*0x7e82eec*/ int GetSiblingIndex();
        /*0x7e82f9c*/ UnityEngine.Transform FindRelativeTransformWithPath(string path, bool isActiveOnly);
        /*0x7e831c0*/ UnityEngine.Transform Find(string n);
        /*0x7e83218*/ void SendTransformChangedScale();
        /*0x7e832c8*/ UnityEngine.Vector3 get_lossyScale();
        /*0x7e833a0*/ bool IsChildOf(UnityEngine.Transform parent);
        /*0x7e8349c*/ bool get_hasChanged();
        /*0x7e8354c*/ void set_hasChanged(bool value);
        /*0x7e8360c*/ UnityEngine.Transform FindChild(string n);
        /*0x7e83610*/ System.Collections.IEnumerator GetEnumerator();
        /*0x7e836b8*/ void RotateAround(UnityEngine.Vector3 axis, float angle);
        /*0x7e837a8*/ void RotateAroundLocal(UnityEngine.Vector3 axis, float angle);
        /*0x7e83898*/ UnityEngine.Transform GetChild(int index);
        /*0x7e8397c*/ int GetChildCount();
        /*0x7e83a2c*/ int get_hierarchyCapacity();
        /*0x7e83aa4*/ void set_hierarchyCapacity(int value);
        /*0x7e83a30*/ int internal_getHierarchyCapacity();
        /*0x7e83aa8*/ void internal_setHierarchyCapacity(int value);
        /*0x7e83ba4*/ int get_hierarchyCount();
        /*0x7e83ba8*/ int internal_getHierarchyCount();
        /*0x7e83c58*/ bool IsNonUniformScaleTransform();
        /*0x7e83d08*/ bool get_constrainProportionsScale();
        /*0x7e83d80*/ void set_constrainProportionsScale(bool value);
        /*0x7e83d88*/ void SetConstrainProportionsScale(bool isLinked);
        /*0x7e83d0c*/ bool IsConstrainProportionsScale();

        class Enumerator : System.Collections.IEnumerator
        {
            /*0x10*/ UnityEngine.Transform outer;
            /*0x18*/ int currentIndex;

            /*0x7e83680*/ Enumerator(UnityEngine.Transform outer);
            /*0x7e83e84*/ object get_Current();
            /*0x7e83ea4*/ bool MoveNext();
            /*0x7e83ed8*/ void Reset();
        }
    }

    namespace _Scripting
    {
        namespace APIUpdating
        {
            class APIUpdaterRuntimeHelpers
            {
                static /*0x7e83ee4*/ bool GetMovedFromAttributeDataForType(System.Type sourceType, ref string assembly, ref string nsp, ref string klass);
                static /*0x7e84054*/ bool GetObsoleteTypeRedirection(System.Type sourceType, ref string assemblyName, ref string nsp, ref string className);
            }
        }
    }

    namespace Profiling
    {
        class Profiler
        {
            static /*0x7e8436c*/ bool get_enabled();
            static /*0x7e84394*/ long GetRuntimeMemorySizeLong(UnityEngine.Object o);
            static /*0x7e84458*/ long GetMonoHeapSizeLong();
            static /*0x7e84480*/ long GetMonoUsedSizeLong();
            static /*0x7e844a8*/ long GetTotalAllocatedMemoryLong();
            static /*0x7e844d0*/ long GetTotalReservedMemoryLong();
            static /*0x7e8441c*/ long GetRuntimeMemorySizeLong_Injected(nint o);
        }

        class Recorder
        {
            static Unity.Profiling.ProfilerRecorderOptions s_RecorderDefaultOptions = 153;
            static /*0x0*/ UnityEngine.Profiling.Recorder s_InvalidRecorder;
            /*0x10*/ Unity.Profiling.ProfilerRecorder m_RecorderCPU;
            /*0x18*/ Unity.Profiling.ProfilerRecorder m_RecorderGPU;

            static /*0x7e84808*/ Recorder();
            /*0x7e844f8*/ Recorder();
            /*0x7e84500*/ Recorder(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle);
            /*0x7e845b8*/ void Finalize();
            /*0x7e84664*/ bool get_enabled();
            /*0x7e84670*/ void set_enabled(bool value);
            /*0x7e846e8*/ long get_elapsedNanoseconds();
            /*0x7e8471c*/ long get_gpuElapsedNanoseconds();
            /*0x7e84750*/ int get_sampleBlockCount();
            /*0x7e847ac*/ int get_gpuSampleBlockCount();
            /*0x7e84678*/ void SetEnabled(bool state);
        }

        class Sampler
        {
            static /*0x0*/ UnityEngine.Profiling.Sampler s_InvalidSampler;
            /*0x10*/ nint m_Ptr;

            static /*0x7e84934*/ Sampler();
            /*0x7e84870*/ Sampler();
            /*0x7e84878*/ Sampler(nint ptr);
            /*0x7e848a0*/ bool get_isValid();
            /*0x7e848b0*/ UnityEngine.Profiling.Recorder GetRecorder();
        }

        class CustomSampler : UnityEngine.Profiling.Sampler
        {
            static /*0x0*/ UnityEngine.Profiling.CustomSampler s_InvalidCustomSampler;

            static /*0x7e84b14*/ CustomSampler();
            static /*0x7e84a60*/ UnityEngine.Profiling.CustomSampler Create(string name, bool collectGpuData);
            /*0x7e8499c*/ CustomSampler();
            /*0x7e849f4*/ CustomSampler(nint ptr);

            class BindingsMarshaller
            {
                static /*0x7e84b78*/ nint ConvertToNative(UnityEngine.Profiling.CustomSampler customSampler);
            }
        }
    }

    namespace Jobs
    {
        interface IJobParallelForTransform
        {
            /*0x3907c14*/ void Execute(int index, UnityEngine.Jobs.TransformAccess transform);
        }

        class IJobParallelForTransformExtensions
        {
            static nint GetReflectionData<T>();
            static /*0x3907c14*/ Unity.Jobs.JobHandle Schedule<T>(T jobData, UnityEngine.Jobs.TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn);

            struct TransformParallelForLoopStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x38358cc*/ TransformParallelForLoopStruct();
                static /*0x38358cc*/ void Initialize();
                static /*0x383a8c4*/ void Execute(ref T jobData, nint jobData2, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

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

            static /*0x7e84bec*/ void GetPosition(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Vector3 p);
            static /*0x7e84c88*/ void GetRotation(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Quaternion r);
            static /*0x7e84d28*/ void GetLocalScale(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Vector3 r);
            static /*0x7e84dd8*/ void GetLocalToWorldMatrix(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Matrix4x4 m);
            /*0x7e84b90*/ UnityEngine.Vector3 get_position();
            /*0x7e84c30*/ UnityEngine.Quaternion get_rotation();
            /*0x7e84ccc*/ UnityEngine.Vector3 get_localScale();
            /*0x7e84d6c*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
        }

        struct TransformAccessArray : System.IDisposable
        {
            /*0x10*/ nint m_TransformArray;

            static /*0x7e84e30*/ void Allocate(int capacity, int desiredJobCount, ref UnityEngine.Jobs.TransformAccessArray array);
            static /*0x7e84e94*/ nint Create(int capacity, int desiredJobCount);
            static /*0x7e84f40*/ void DestroyTransformAccessArray(nint transformArray);
            static /*0x7e85088*/ void Add(nint transformArrayIntPtr, UnityEngine.Transform transform);
            static /*0x7e85160*/ void RemoveAtSwapBack(nint transformArrayIntPtr, int index);
            static /*0x7e851e8*/ nint GetSortedTransformAccess(nint transformArrayIntPtr);
            static /*0x7e85224*/ nint GetSortedToUserIndex(nint transformArrayIntPtr);
            static /*0x7e85044*/ int GetLength(nint transformArrayIntPtr);
            static /*0x7e84f8c*/ UnityEngine.Transform GetTransform(nint transformArrayIntPtr, int index);
            static /*0x7e851a4*/ void Add_Injected(nint transformArrayIntPtr, nint transform);
            static /*0x7e85260*/ nint GetTransform_Injected(nint transformArrayIntPtr, int index);
            /*0x7e84e1c*/ TransformAccessArray(int capacity, int desiredJobCount);
            /*0x7e84ed8*/ bool get_isCreated();
            /*0x7e84ee8*/ void Dispose();
            /*0x7e84f7c*/ nint GetTransformAccessArrayForSchedule();
            /*0x7e84f84*/ UnityEngine.Transform get_Item(int index);
            /*0x7e85008*/ int get_length();
            /*0x7e85080*/ void Add(UnityEngine.Transform transform);
            /*0x7e8511c*/ void RemoveAtSwapBack(int index);
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
            static /*0x7e852a4*/ string TidyAssemblyTypeName(string assemblyTypeName);
        }

        class ArgumentCache : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Object m_ObjectArgument;
            /*0x18*/ string m_ObjectArgumentAssemblyTypeName;
            /*0x20*/ int m_IntArgument;
            /*0x24*/ float m_FloatArgument;
            /*0x28*/ string m_StringArgument;
            /*0x30*/ bool m_BoolArgument;

            /*0x7e85548*/ ArgumentCache();
            /*0x7e854d0*/ UnityEngine.Object get_unityObjectArgument();
            /*0x7e854d8*/ string get_unityObjectArgumentAssemblyTypeName();
            /*0x7e854e0*/ int get_intArgument();
            /*0x7e854e8*/ float get_floatArgument();
            /*0x7e854f0*/ string get_stringArgument();
            /*0x7e854f8*/ bool get_boolArgument();
            /*0x7e85500*/ void OnBeforeSerialize();
            /*0x7e85524*/ void OnAfterDeserialize();
        }

        class BaseInvokableCall
        {
            static /*0x3837da0*/ void ThrowOnInvalidArg<T>(object arg);
            static /*0x7e8564c*/ bool AllowInvoke(System.Delegate delegate);
            /*0x7e85550*/ BaseInvokableCall();
            /*0x7e85558*/ BaseInvokableCall(object target, System.Reflection.MethodInfo function);
            /*0x380d83c*/ void Invoke(object[] args);
            /*0x380b32c*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall : UnityEngine.Events.BaseInvokableCall
        {
            /*0x10*/ UnityEngine.Events.UnityAction Delegate;

            /*0x7e85828*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x7e858fc*/ InvokableCall(UnityEngine.Events.UnityAction action);
            /*0x7e856f0*/ void add_Delegate(UnityEngine.Events.UnityAction value);
            /*0x7e8578c*/ void remove_Delegate(UnityEngine.Events.UnityAction value);
            /*0x7e85928*/ void Invoke(object[] args);
            /*0x7e85964*/ void Invoke();
            /*0x7e859a0*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1> Delegate;

            /*0x380d93c*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x380d83c*/ InvokableCall(UnityEngine.Events.UnityAction<T1> action);
            /*0x380d83c*/ void add_Delegate(UnityEngine.Events.UnityAction<T1> value);
            /*0x380d83c*/ void remove_Delegate(UnityEngine.Events.UnityAction<T1> value);
            /*0x380d83c*/ void Invoke(object[] args);
            /*0x3907c14*/ void Invoke(T1 args0);
            /*0x380b32c*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2> Delegate;

            /*0x380d93c*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x380d83c*/ InvokableCall(UnityEngine.Events.UnityAction<T1, T2> action);
            /*0x380d83c*/ void add_Delegate(UnityEngine.Events.UnityAction<T1, T2> value);
            /*0x380d83c*/ void remove_Delegate(UnityEngine.Events.UnityAction<T1, T2> value);
            /*0x380d83c*/ void Invoke(object[] args);
            /*0x3907c14*/ void Invoke(T1 args0, T2 args1);
            /*0x380b32c*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2, T3> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2, T3> Delegate;

            /*0x380d93c*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x380d83c*/ InvokableCall(UnityEngine.Events.UnityAction<T1, T2, T3> action);
            /*0x380d83c*/ void add_Delegate(UnityEngine.Events.UnityAction<T1, T2, T3> value);
            /*0x380d83c*/ void remove_Delegate(UnityEngine.Events.UnityAction<T1, T2, T3> value);
            /*0x380d83c*/ void Invoke(object[] args);
            /*0x3907c14*/ void Invoke(T1 args0, T2 args1, T3 args2);
            /*0x380b32c*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2, T3, T4> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2, T3, T4> Delegate;

            /*0x380d93c*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x380d83c*/ InvokableCall(UnityEngine.Events.UnityAction<T1, T2, T3, T4> action);
            /*0x380d83c*/ void add_Delegate(UnityEngine.Events.UnityAction<T1, T2, T3, T4> value);
            /*0x380d83c*/ void remove_Delegate(UnityEngine.Events.UnityAction<T1, T2, T3, T4> value);
            /*0x380d83c*/ void Invoke(object[] args);
            /*0x380b32c*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class CachedInvokableCall<T> : UnityEngine.Events.InvokableCall<T>
        {
            /*0x0*/ T m_Arg1;

            /*0x3907c14*/ CachedInvokableCall(UnityEngine.Object target, System.Reflection.MethodInfo theFunction, T argument);
            /*0x380d83c*/ void Invoke(object[] args);
            /*0x3907c14*/ void Invoke(T arg0);
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

            static /*0x7e85fa8*/ UnityEngine.Events.BaseInvokableCall GetObjectCall(UnityEngine.Object target, System.Reflection.MethodInfo method, UnityEngine.Events.ArgumentCache arguments);
            /*0x7e86464*/ PersistentCall();
            /*0x7e859ec*/ UnityEngine.Object get_target();
            /*0x7e859f4*/ string get_targetAssemblyTypeName();
            /*0x7e85aac*/ string get_methodName();
            /*0x7e85ab4*/ UnityEngine.Events.PersistentListenerMode get_mode();
            /*0x7e85abc*/ UnityEngine.Events.ArgumentCache get_arguments();
            /*0x7e85ac4*/ bool IsValid();
            /*0x7e85b00*/ UnityEngine.Events.BaseInvokableCall GetRuntimeCall(UnityEngine.Events.UnityEventBase theEvent);
            /*0x7e8641c*/ void OnBeforeSerialize();
            /*0x7e86440*/ void OnAfterDeserialize();
        }

        class PersistentCallGroup
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Events.PersistentCall> m_Calls;

            /*0x7e864dc*/ PersistentCallGroup();
            /*0x7e86564*/ void Initialize(UnityEngine.Events.InvokableCallList invokableList, UnityEngine.Events.UnityEventBase unityEventBase);
        }

        class InvokableCallList
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_PersistentCalls;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_RuntimeCalls;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_ExecutingCalls;
            /*0x28*/ bool m_NeedsUpdate;

            /*0x7e86d78*/ InvokableCallList();
            /*0x7e867a8*/ int get_Count();
            /*0x7e866f4*/ void AddPersistentInvokableCall(UnityEngine.Events.BaseInvokableCall call);
            /*0x7e86800*/ void AddListener(UnityEngine.Events.BaseInvokableCall call);
            /*0x7e868b4*/ void RemoveListener(object targetObj, System.Reflection.MethodInfo method);
            /*0x7e86b34*/ void Clear();
            /*0x7e86bfc*/ void ClearPersistent();
            /*0x7e86cc4*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke();
        }

        class UnityEventBase : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Events.InvokableCallList m_Calls;
            /*0x18*/ UnityEngine.Events.PersistentCallGroup m_PersistentCalls;
            /*0x20*/ bool m_CallsDirty;

            static /*0x7e871cc*/ System.Reflection.MethodInfo GetValidMethodInfo(System.Type objectType, string functionName, System.Type[] argumentTypes);
            /*0x7e86e50*/ UnityEventBase();
            /*0x7e86efc*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7e86f28*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x380bcbc*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x380bcbc*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x7e85de8*/ System.Reflection.MethodInfo FindMethod(UnityEngine.Events.PersistentCall call);
            /*0x7e86f2c*/ System.Reflection.MethodInfo FindMethod(string name, System.Type listenerType, UnityEngine.Events.PersistentListenerMode mode, System.Type argumentType);
            /*0x7e87378*/ int GetCallsCount();
            /*0x7e86f00*/ void DirtyPersistentCalls();
            /*0x7e87390*/ void RebuildPersistentCallsIfNeeded();
            /*0x7e873c4*/ void AddCall(UnityEngine.Events.BaseInvokableCall call);
            /*0x7e873dc*/ void RemoveListener(object targetObj, System.Reflection.MethodInfo method);
            /*0x7e873f4*/ void RemoveAllListeners();
            /*0x7e8740c*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke();
            /*0x7e8742c*/ string ToString();
        }

        class UnityAction : System.MulticastDelegate
        {
            /*0x7e874b0*/ UnityAction(object object, nint method);
            /*0x7e8754c*/ void Invoke();
        }

        class UnityEvent : UnityEngine.Events.UnityEventBase
        {
            /*0x28*/ object[] m_InvokeArray;

            static /*0x7e875ac*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction action);
            /*0x7e87560*/ UnityEvent();
            /*0x7e87580*/ void AddListener(UnityEngine.Events.UnityAction call);
            /*0x7e87610*/ void RemoveListener(UnityEngine.Events.UnityAction call);
            /*0x7e87654*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x7e876b8*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x7e87720*/ void Invoke();
        }

        class UnityAction<T0> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x3907c14*/ void Invoke(T0 arg0);
        }

        class UnityEvent<T0> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            static /*0x382eaf0*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0> action);
            /*0x380cb08*/ UnityEvent();
            /*0x380d83c*/ void AddListener(UnityEngine.Events.UnityAction<T0> call);
            /*0x380d83c*/ void RemoveListener(UnityEngine.Events.UnityAction<T0> call);
            /*0x380bcbc*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x380bcbc*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x3907c14*/ void Invoke(T0 arg0);
        }

        class UnityAction<T0, T1> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x3907c14*/ void Invoke(T0 arg0, T1 arg1);
        }

        class UnityEvent<T0, T1> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            static /*0x382eaf0*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0, T1> action);
            /*0x380cb08*/ UnityEvent();
            /*0x380d83c*/ void AddListener(UnityEngine.Events.UnityAction<T0, T1> call);
            /*0x380d83c*/ void RemoveListener(UnityEngine.Events.UnityAction<T0, T1> call);
            /*0x380bcbc*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x380bcbc*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x3907c14*/ void Invoke(T0 arg0, T1 arg1);
        }

        class UnityAction<T0, T1, T2> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x3907c14*/ void Invoke(T0 arg0, T1 arg1, T2 arg2);
        }

        class UnityEvent<T0, T1, T2> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            static /*0x382eaf0*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0, T1, T2> action);
            /*0x380cb08*/ UnityEvent();
            /*0x380d83c*/ void AddListener(UnityEngine.Events.UnityAction<T0, T1, T2> call);
            /*0x380d83c*/ void RemoveListener(UnityEngine.Events.UnityAction<T0, T1, T2> call);
            /*0x380bcbc*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x380bcbc*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x3907c14*/ void Invoke(T0 arg0, T1 arg1, T2 arg2);
        }

        class UnityAction<T0, T1, T2, T3> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x3907c14*/ void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3);
        }

        class UnityEvent<T0, T1, T2, T3> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            static /*0x382eaf0*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0, T1, T2, T3> action);
            /*0x380cb08*/ UnityEvent();
            /*0x380d83c*/ void AddListener(UnityEngine.Events.UnityAction<T0, T1, T2, T3> call);
            /*0x380d83c*/ void RemoveListener(UnityEngine.Events.UnityAction<T0, T1, T2, T3> call);
            /*0x380bcbc*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x380bcbc*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
        }
    }

    namespace Serialization
    {
        class FormerlySerializedAsAttribute : System.Attribute
        {
            /*0x10*/ string m_oldName;

            /*0x7e878b4*/ FormerlySerializedAsAttribute(string oldName);
        }
    }

    namespace Categorization
    {
        class ElementInfoAttribute : System.Attribute
        {
            /*0x10*/ int <Order>k__BackingField;
            /*0x18*/ string <Name>k__BackingField;

            /*0x7e878ec*/ ElementInfoAttribute();
            /*0x7e878e4*/ void set_Order(int value);
        }

        class CategoryInfoAttribute : System.Attribute
        {
            /*0x10*/ int <Order>k__BackingField;
            /*0x18*/ string <Name>k__BackingField;

            /*0x7e87928*/ CategoryInfoAttribute();
            /*0x7e87918*/ void set_Order(int value);
            /*0x7e87920*/ void set_Name(string value);
        }
    }

    namespace Bindings
    {
        struct Unmarshal
        {
            static /*0x3907c14*/ T UnmarshalUnityObject<T>(nint gcHandlePtr);
            static /*0x7e87954*/ System.Runtime.InteropServices.GCHandle FromIntPtrUnsafe(nint gcHandle);
        }

        class ThrowHelper
        {
            static /*0x7e767ac*/ void ThrowArgumentNullException(object obj, string parameterName);
            static /*0x7e73ff0*/ void ThrowNullReferenceException(object obj);
        }

        class BindingsAllocator
        {
            static /*0x7e87990*/ void Free(void* ptr);
            static /*0x7e879cc*/ void FreeNativeOwnedMemory(void* ptr);
            static /*0x7e87a08*/ void* GetNativeOwnedDataPointer(void* ptr);

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

            /*0x7e87a20*/ BlittableArrayWrapper(void* data, int size);
            /*0x380d83c*/ void Unmarshal<T>(ref T[] array);

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

            /*0x7e87a2c*/ BlittableListWrapper(UnityEngine.Bindings.BlittableArrayWrapper arrayWrapper, int listSize);
            /*0x380d83c*/ void Unmarshal<T>(System.Collections.Generic.List<T> list);
        }

        class ExceptionMarshaller
        {
            [ThreadStatic] static System.Exception s_pendingException;

            static /*0x7e87a38*/ void SetPendingException(System.Exception ex);
        }

        struct ManagedSpanWrapper
        {
            /*0x10*/ void* begin;
            /*0x18*/ int length;

            /*0x7e74278*/ ManagedSpanWrapper(void* begin, int length);
        }

        class StringMarshaller
        {
            static /*0x7e87a90*/ bool TryMarshalEmptyOrNullString(string s, ref UnityEngine.Bindings.ManagedSpanWrapper managedSpanWrapper);
        }

        struct OutStringMarshaller
        {
            static /*0x7e87ae8*/ string GetStringAndDispose(UnityEngine.Bindings.ManagedSpanWrapper managedSpan);
        }
    }

    namespace Scripting
    {
        class AlwaysLinkAssemblyAttribute : System.Attribute
        {
            /*0x7e87b70*/ AlwaysLinkAssemblyAttribute();
        }

        class GarbageCollector
        {
            static /*0x7e87b78*/ UnityEngine.Scripting.GarbageCollector.Mode get_GCMode();
            static /*0x7e87ba0*/ UnityEngine.Scripting.GarbageCollector.Mode GetMode();

            enum Mode
            {
                Disabled = 0,
                Enabled = 1,
                Manual = 2,
            }
        }

        class PreserveAttribute : System.Attribute
        {
            /*0x7e87bc8*/ PreserveAttribute();
        }

        class RequiredMemberAttribute : System.Attribute
        {
            /*0x7e87bd0*/ RequiredMemberAttribute();
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

                /*0x7e87bd8*/ void Set(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName);
            }

            class MovedFromAttribute : System.Attribute
            {
                /*0x10*/ UnityEngine.Scripting.APIUpdating.MovedFromAttributeData data;

                /*0x7e87c68*/ MovedFromAttribute(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName);
                /*0x7e87cb4*/ MovedFromAttribute(string sourceNamespace);
            }
        }
    }

    namespace SceneManagement
    {
        struct Scene
        {
            /*0x10*/ int m_Handle;

            static /*0x7e87cec*/ bool IsValidInternal(int sceneHandle);
            static /*0x7e87d28*/ string GetPathInternal(int sceneHandle);
            static /*0x7e87e20*/ string GetNameInternal(int sceneHandle);
            static /*0x7e87f18*/ string GetGUIDInternal(int sceneHandle);
            static /*0x7e88010*/ bool GetIsLoadedInternal(int sceneHandle);
            static /*0x7e8804c*/ int GetBuildIndexInternal(int sceneHandle);
            static /*0x7e88088*/ int GetRootCountInternal(int sceneHandle);
            static /*0x7e880c4*/ void GetRootGameObjectsInternal(int sceneHandle, object resultRootList);
            static /*0x7e88564*/ bool op_Equality(UnityEngine.SceneManagement.Scene lhs, UnityEngine.SceneManagement.Scene rhs);
            static /*0x7e87ddc*/ void GetPathInternal_Injected(int sceneHandle, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x7e87ed4*/ void GetNameInternal_Injected(int sceneHandle, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x7e87fcc*/ void GetGUIDInternal_Injected(int sceneHandle, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            /*0x7e88108*/ int get_handle();
            /*0x7e88110*/ string get_guid();
            /*0x7e88118*/ bool IsValid();
            /*0x7e88154*/ string get_path();
            /*0x7e8815c*/ string get_name();
            /*0x7e88164*/ bool get_isLoaded();
            /*0x7e881a0*/ int get_buildIndex();
            /*0x7e881dc*/ int get_rootCount();
            /*0x7e88218*/ UnityEngine.GameObject[] GetRootGameObjects();
            /*0x7e882f0*/ void GetRootGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> rootGameObjects);
            /*0x7e88570*/ int GetHashCode();
            /*0x7e88578*/ bool Equals(object other);
        }

        class SceneManagerAPIInternal
        {
            static /*0x7e885f0*/ UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            static /*0x7e88760*/ nint LoadSceneAsyncNameIndexInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper sceneName, int sceneBuildIndex, ref UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
        }

        class SceneManagerAPI
        {
            static /*0x0*/ UnityEngine.SceneManagement.SceneManagerAPI s_DefaultAPI;
            static /*0x8*/ UnityEngine.SceneManagement.SceneManagerAPI <overrideAPI>k__BackingField;

            static /*0x7e888e4*/ SceneManagerAPI();
            static /*0x7e887bc*/ UnityEngine.SceneManagement.SceneManagerAPI get_ActiveAPI();
            static /*0x7e88864*/ UnityEngine.SceneManagement.SceneManagerAPI get_overrideAPI();
            /*0x7e888bc*/ SceneManagerAPI();
            /*0x7e888c4*/ UnityEngine.AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            /*0x7e888dc*/ UnityEngine.AsyncOperation LoadFirstScene(bool mustLoadAsync);
        }

        class SceneManager
        {
            static /*0x0*/ bool s_AllowLoadScene;
            static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> sceneLoaded;
            static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> sceneUnloaded;
            static /*0x18*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> activeSceneChanged;

            static /*0x7e89748*/ SceneManager();
            static /*0x7e8894c*/ int get_sceneCount();
            static /*0x7e88974*/ int get_loadedSceneCount();
            static /*0x7e8899c*/ UnityEngine.SceneManagement.Scene GetActiveScene();
            static /*0x7e88a54*/ bool SetActiveScene(UnityEngine.SceneManagement.Scene scene);
            static /*0x7e88b0c*/ UnityEngine.SceneManagement.Scene GetSceneAt(int index);
            static /*0x7e88bdc*/ UnityEngine.AsyncOperation UnloadSceneAsyncInternal(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.UnloadSceneOptions options);
            static /*0x7e88cb4*/ UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            static /*0x7e88d90*/ UnityEngine.AsyncOperation LoadFirstScene_Internal(bool async);
            static /*0x7e88df8*/ void add_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> value);
            static /*0x7e88eec*/ void remove_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> value);
            static /*0x7e88fe0*/ void add_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value);
            static /*0x7e890d4*/ void remove_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value);
            static /*0x7e891c8*/ void add_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> value);
            static /*0x7e892bc*/ void remove_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> value);
            static /*0x7e893b0*/ UnityEngine.AsyncOperation LoadSceneAsync(int sceneBuildIndex);
            static /*0x7e89410*/ UnityEngine.AsyncOperation LoadSceneAsync(int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters);
            static /*0x7e8947c*/ UnityEngine.AsyncOperation LoadSceneAsync(string sceneName, UnityEngine.SceneManagement.LoadSceneParameters parameters);
            static /*0x7e894e8*/ UnityEngine.AsyncOperation UnloadSceneAsync(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.UnloadSceneOptions options);
            static /*0x7e8954c*/ void Internal_SceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            static /*0x7e895fc*/ void Internal_SceneUnloaded(UnityEngine.SceneManagement.Scene scene);
            static /*0x7e89698*/ void Internal_ActiveSceneChanged(UnityEngine.SceneManagement.Scene previousActiveScene, UnityEngine.SceneManagement.Scene newActiveScene);
            static /*0x7e88a18*/ void GetActiveScene_Injected(ref UnityEngine.SceneManagement.Scene ret);
            static /*0x7e88ad0*/ bool SetActiveScene_Injected(ref UnityEngine.SceneManagement.Scene scene);
            static /*0x7e88b98*/ void GetSceneAt_Injected(int index, ref UnityEngine.SceneManagement.Scene ret);
            static /*0x7e88c70*/ nint UnloadSceneAsyncInternal_Injected(ref UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.UnloadSceneOptions options);
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

            /*0x7e89408*/ LoadSceneParameters(UnityEngine.SceneManagement.LoadSceneMode mode);
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

            /*0x7e89794*/ string ToString();

            class UpdateFunction : System.MulticastDelegate
            {
                /*0x7e897b4*/ UpdateFunction(object object, nint method);
                /*0x7e89850*/ void Invoke();
            }
        }

        class PlayerLoop
        {
            static /*0x7e89864*/ UnityEngine.LowLevel.PlayerLoopSystem GetCurrentPlayerLoop();
            static /*0x7e89bb4*/ void SetPlayerLoop(UnityEngine.LowLevel.PlayerLoopSystem loop);
            static /*0x7e89ca0*/ int PlayerLoopSystemToInternal(UnityEngine.LowLevel.PlayerLoopSystem sys, ref System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystemInternal> internalSys);
            static /*0x7e89900*/ UnityEngine.LowLevel.PlayerLoopSystem InternalToPlayerLoopSystem(UnityEngine.LowLevel.PlayerLoopSystemInternal[] internalSys, ref int offset);
            static /*0x7e898d8*/ UnityEngine.LowLevel.PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal();
            static /*0x7e89ea8*/ void SetPlayerLoopInternal(UnityEngine.LowLevel.PlayerLoopSystemInternal[] loop);
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

            static /*0x38358cc*/ CollectionPool();
            static /*0x3907c14*/ TCollection Get();
            static /*0x3907c14*/ UnityEngine.Pool.PooledObject<TCollection> Get(ref TCollection value);
            static /*0x3907c14*/ void Release(TCollection toRelease);

            class <>c<TCollection, TItem>
            {
                static /*0x0*/ UnityEngine.Pool.CollectionPool.<>c<TCollection, TItem> <>9;

                static /*0x38358cc*/ <>c();
                /*0x380cb08*/ <>c();
                /*0x3907c14*/ TCollection <.cctor>b__5_0();
                /*0x3907c14*/ void <.cctor>b__5_1(TCollection l);
            }
        }

        class GenericPool<T>
        {
            static /*0x0*/ UnityEngine.Pool.ObjectPool<T> s_Pool;

            static /*0x38358cc*/ GenericPool();
            static /*0x3907c14*/ T Get();
            static /*0x3907c14*/ UnityEngine.Pool.PooledObject<T> Get(ref T value);
            static /*0x3907c14*/ void Release(T toRelease);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Pool.GenericPool.<>c<T> <>9;

                static /*0x38358cc*/ <>c();
                /*0x380cb08*/ <>c();
                /*0x3907c14*/ T <.cctor>b__5_0();
            }
        }

        interface IObjectPool<T>
        {
            /*0x3907c14*/ void Release(T element);
        }

        class ObjectPool<T> : System.IDisposable, UnityEngine.Pool.IObjectPool<T>
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

            /*0x3907c14*/ ObjectPool(System.Func<T> createFunc, System.Action<T> actionOnGet, System.Action<T> actionOnRelease, System.Action<T> actionOnDestroy, bool collectionCheck, int defaultCapacity, int maxSize);
            /*0x380b6a0*/ int get_CountAll();
            /*0x380cffc*/ void set_CountAll(int value);
            /*0x380b6a0*/ int get_CountInactive();
            /*0x3907c14*/ T Get();
            /*0x3907c14*/ UnityEngine.Pool.PooledObject<T> Get(ref T v);
            /*0x3907c14*/ void Release(T element);
            /*0x380cb08*/ void Clear();
            /*0x380cb08*/ void Dispose();
        }

        struct PooledObject<T> : System.IDisposable
        {
            /*0x0*/ T m_ToReturn;
            /*0x0*/ UnityEngine.Pool.IObjectPool<T> m_Pool;

            /*0x3907c14*/ PooledObject(T value, UnityEngine.Pool.IObjectPool<T> pool);
            /*0x380cb08*/ void System.IDisposable.Dispose();
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

                /*0x7e89ee4*/ MessageEventArgs();
            }

            interface IEditorPlayerConnection
            {
                void Register(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);
                /*0x380d83c*/ void RegisterConnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x380d83c*/ void RegisterDisconnection(UnityEngine.Events.UnityAction<int> callback);
                void Send(System.Guid messageId, byte[] data);
            }

            class PlayerConnection : UnityEngine.ScriptableObject, UnityEngine.Networking.PlayerConnection.IEditorPlayerConnection
            {
                static /*0x0*/ UnityEngine.IPlayerEditorConnectionNative connectionNative;
                static /*0x8*/ UnityEngine.Networking.PlayerConnection.PlayerConnection s_Instance;
                /*0x18*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents;
                /*0x20*/ System.Collections.Generic.List<int> m_connectedPlayers;
                /*0x28*/ bool m_IsInitilized;

                static /*0x7e89eec*/ UnityEngine.Networking.PlayerConnection.PlayerConnection get_instance();
                static /*0x7e89f80*/ UnityEngine.Networking.PlayerConnection.PlayerConnection CreateInstance();
                static /*0x7e8b118*/ void MessageCallbackInternal(nint data, ulong size, ulong guid, string messageId);
                static /*0x7e8b3b0*/ void ConnectedCallbackInternal(int playerId);
                static /*0x7e8b488*/ void DisconnectedCallback(int playerId);
                /*0x7e8b51c*/ PlayerConnection();
                /*0x7e8a018*/ bool get_isConnected();
                /*0x7e8a12c*/ void OnEnable();
                /*0x7e8a0b4*/ UnityEngine.IPlayerEditorConnectionNative GetConnectionNativeApi();
                /*0x7e8a1ec*/ void Register(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);
                /*0x7e8a5f8*/ void Unregister(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);
                /*0x7e8a8d0*/ void RegisterConnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x7e8aa70*/ void RegisterDisconnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x7e8aad0*/ void UnregisterConnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x7e8ab30*/ void UnregisterDisconnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x7e8ab90*/ void Send(System.Guid messageId, byte[] data);
                /*0x7e8ace8*/ bool TrySend(System.Guid messageId, byte[] data);
                /*0x7e8ae40*/ bool BlockUntilRecvMsg(System.Guid messageId, int timeout);
                /*0x7e8b07c*/ void DisconnectAll();

                class <>c__DisplayClass12_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x7e8a428*/ <>c__DisplayClass12_0();
                    /*0x7e8b6b4*/ bool <Register>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x7e8a79c*/ <>c__DisplayClass13_0();
                    /*0x7e8b728*/ bool <Unregister>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ bool msgReceived;

                    /*0x7e8b074*/ <>c__DisplayClass20_0();
                    /*0x7e8b770*/ void <BlockUntilRecvMsg>b__0(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
                }
            }

            class PlayerEditorConnectionEvents
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> m_MessageTypeSubscribers;
                /*0x18*/ System.Collections.Generic.Dictionary<System.Guid, UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> m_SubscriberLookup;
                /*0x20*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent;
                /*0x28*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent;

                /*0x7e8b5d8*/ PlayerEditorConnectionEvents();
                /*0x7e8b77c*/ System.Collections.Generic.IReadOnlyList<UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> get_messageTypeSubscribers();
                /*0x7e8b784*/ void BuildLookup();
                /*0x7e8b230*/ void InvokeMessageIdSubscribers(System.Guid messageId, byte[] data, int playerId);
                /*0x7e8a430*/ UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs> AddAndCreate(System.Guid messageId);
                /*0x7e8a7a4*/ void UnregisterManagedCallback(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);

                class MessageEvent : UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs>
                {
                    /*0x7e8bbbc*/ MessageEvent();
                }

                class ConnectionChangeEvent : UnityEngine.Events.UnityEvent<int>
                {
                    /*0x7e8bc04*/ ConnectionChangeEvent();
                }

                class MessageTypeSubscribers
                {
                    /*0x10*/ string m_messageTypeId;
                    /*0x18*/ int subscriberCount;
                    /*0x20*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageEvent messageCallback;

                    /*0x7e8bb18*/ MessageTypeSubscribers();
                    /*0x7e8b6fc*/ System.Guid get_MessageTypeId();
                    /*0x7e8bb84*/ void set_MessageTypeId(System.Guid value);
                }
            }
        }
    }

    namespace Internal
    {
        class DefaultValueAttribute : System.Attribute
        {
            /*0x10*/ object DefaultValue;

            /*0x7e8bc4c*/ DefaultValueAttribute(string value);
            /*0x7e8bc7c*/ object get_Value();
            /*0x7e8bc84*/ bool Equals(object obj);
            /*0x7e8bd3c*/ int GetHashCode();
        }

        class ExcludeFromDocsAttribute : System.Attribute
        {
            /*0x7e8bd60*/ ExcludeFromDocsAttribute();
        }

        interface ISubAssetNotDuplicatable
        {
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

            /*0x7e8bd68*/ bool HasFlags(UnityEngine.Playables.FrameData.Flags flag);
            /*0x7e8bd78*/ float get_deltaTime();
            /*0x7e8bd84*/ float get_effectiveSpeed();
            /*0x7e8bd8c*/ UnityEngine.Playables.FrameData.EvaluationType get_evaluationType();
            /*0x7e8bd9c*/ bool get_timeLooped();
            /*0x7e8bda8*/ UnityEngine.Playables.PlayableOutput get_output();

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
            /*0x3907c14*/ void OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, object context);
        }

        interface IPlayable
        {
            /*0x3907c14*/ UnityEngine.Playables.PlayableHandle GetHandle();
        }

        interface IPlayableBehaviour
        {
            /*0x3907c14*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x3907c14*/ void OnGraphStop(UnityEngine.Playables.Playable playable);
            /*0x3907c14*/ void OnPlayableCreate(UnityEngine.Playables.Playable playable);
            /*0x3907c14*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x3907c14*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x3907c14*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x3907c14*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x3907c14*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
        }

        interface IPlayableOutput
        {
            /*0x3907c14*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
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

            static /*0x7e8c11c*/ Playable();
            static /*0x7e8bdb4*/ UnityEngine.Playables.Playable get_Null();
            static /*0x7e8be0c*/ UnityEngine.Playables.Playable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            /*0x7e8bf04*/ Playable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7e8bf0c*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7e8bf18*/ System.Type GetPlayableType();
            /*0x7e8c004*/ bool Equals(UnityEngine.Playables.Playable other);
        }

        interface IPlayableAsset
        {
            UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
            /*0x380b564*/ double get_duration();
        }

        class PlayableAsset : UnityEngine.ScriptableObject, UnityEngine.Playables.IPlayableAsset
        {
            static /*0x7e8c294*/ void Internal_CreatePlayable(UnityEngine.Playables.PlayableAsset asset, UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, nint ptr);
            static /*0x7e8c368*/ void Internal_GetPlayableAssetDuration(UnityEngine.Playables.PlayableAsset asset, nint ptrToDouble);
            /*0x7e8c390*/ PlayableAsset();
            UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
            /*0x7e8c1e4*/ double get_duration();
            /*0x7e8c23c*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
        }

        class PlayableBehaviour : UnityEngine.Playables.IPlayableBehaviour, System.ICloneable
        {
            /*0x7e8c398*/ PlayableBehaviour();
            /*0x7e8c3a0*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x7e8c3a4*/ void OnGraphStop(UnityEngine.Playables.Playable playable);
            /*0x7e8c3a8*/ void OnPlayableCreate(UnityEngine.Playables.Playable playable);
            /*0x7e8c3ac*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x7e8c3b0*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x7e8c3b4*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x7e8c3b8*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x7e8c3bc*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
            /*0x7e8c3c0*/ object Clone();
        }

        struct PlayableBinding
        {
            static /*0x0*/ UnityEngine.Playables.PlayableBinding[] None;
            static /*0x8*/ double DefaultDuration;
            /*0x10*/ string m_StreamName;
            /*0x18*/ UnityEngine.Object m_SourceObject;
            /*0x20*/ System.Type m_SourceBindingType;
            /*0x28*/ UnityEngine.Playables.PlayableBinding.CreateOutputMethod m_CreateOutputMethod;

            static /*0x7e8c54c*/ PlayableBinding();
            static /*0x7e8c4b8*/ UnityEngine.Playables.PlayableBinding CreateInternal(string name, UnityEngine.Object sourceObject, System.Type sourceType, UnityEngine.Playables.PlayableBinding.CreateOutputMethod createFunction);
            /*0x7e8c3c8*/ UnityEngine.Object get_sourceObject();
            /*0x7e8c3d0*/ UnityEngine.Playables.PlayableOutput CreateOutput(UnityEngine.Playables.PlayableGraph graph);

            class CreateOutputMethod : System.MulticastDelegate
            {
                /*0x7e8c5d4*/ CreateOutputMethod(object object, nint method);
                /*0x7e8c674*/ UnityEngine.Playables.PlayableOutput Invoke(UnityEngine.Playables.PlayableGraph graph, string name);
            }
        }

        enum PlayableTraversalMode
        {
            Mix = 0,
            Passthrough = 1,
        }

        class PlayableExtensions
        {
            static /*0x3907c14*/ bool IsValid<U>(U playable);
            static /*0x3907c14*/ UnityEngine.Playables.PlayState GetPlayState<U>(U playable);
            static /*0x3907c14*/ void Play<U>(U playable);
            static /*0x3907c14*/ void Pause<U>(U playable);
            static /*0x3907c14*/ void SetSpeed<U>(U playable, double value);
            static /*0x3907c14*/ void SetDuration<U>(U playable, double value);
            static /*0x3907c14*/ double GetDuration<U>(U playable);
            static /*0x3907c14*/ void SetTime<U>(U playable, double value);
            static /*0x3907c14*/ double GetTime<U>(U playable);
            static /*0x3907c14*/ bool IsDone<U>(U playable);
            static /*0x3907c14*/ void SetPropagateSetTime<U>(U playable, bool value);
            static /*0x3907c14*/ void SetInputCount<U>(U playable, int value);
            static /*0x3907c14*/ int GetInputCount<U>(U playable);
            static /*0x3907c14*/ UnityEngine.Playables.Playable GetInput<U>(U playable, int inputPort);
            static /*0x3907c14*/ UnityEngine.Playables.Playable GetOutput<U>(U playable, int outputPort);
            static /*0x3907c14*/ void SetInputWeight<U>(U playable, int inputIndex, float weight);
            static /*0x3907c14*/ void SetInputWeight<U, V>(U playable, V input, float weight);
            static /*0x3907c14*/ float GetInputWeight<U>(U playable, int inputIndex);
            static /*0x3907c14*/ void SetTraversalMode<U>(U playable, UnityEngine.Playables.PlayableTraversalMode mode);
            static /*0x3907c14*/ UnityEngine.Playables.DirectorWrapMode GetTimeWrapMode<U>(U playable);
            static /*0x3907c14*/ void SetTimeWrapMode<U>(U playable, UnityEngine.Playables.DirectorWrapMode value);
        }

        struct PlayableGraph
        {
            /*0x10*/ nint m_Handle;
            /*0x18*/ uint m_Version;

            static /*0x7e8c73c*/ void CreatePlayableHandle_Injected(ref UnityEngine.Playables.PlayableGraph _unity_self, ref UnityEngine.Playables.PlayableHandle ret);
            static /*0x7e8c8e4*/ bool CreateScriptOutputInternal_Injected(ref UnityEngine.Playables.PlayableGraph _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Playables.PlayableOutputHandle handle);
            static /*0x7e8c9ac*/ bool ConnectInternal_Injected(ref UnityEngine.Playables.PlayableGraph _unity_self, ref UnityEngine.Playables.PlayableHandle source, int sourceOutputPort, ref UnityEngine.Playables.PlayableHandle destination, int destinationInputPort);
            /*0x3907c14*/ bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort);
            /*0x7e8c688*/ bool IsValid();
            /*0x7e8c6c4*/ UnityEngine.IExposedPropertyTable GetResolver();
            /*0x7e8c700*/ int GetPlayableCount();
            /*0x7e8beb0*/ UnityEngine.Playables.PlayableHandle CreatePlayableHandle();
            /*0x7e8c780*/ bool CreateScriptOutputInternal(string name, ref UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x7e8c938*/ bool ConnectInternal(UnityEngine.Playables.PlayableHandle source, int sourceOutputPort, UnityEngine.Playables.PlayableHandle destination, int destinationInputPort);
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

            static /*0x7e8d830*/ PlayableHandle();
            static /*0x7e8c18c*/ UnityEngine.Playables.PlayableHandle get_Null();
            static /*0x7e8c09c*/ bool op_Equality(UnityEngine.Playables.PlayableHandle x, UnityEngine.Playables.PlayableHandle y);
            static /*0x7e8ce78*/ bool CompareVersion(UnityEngine.Playables.PlayableHandle lhs, UnityEngine.Playables.PlayableHandle rhs);
            static /*0x7e8d634*/ void SetInputWeight_Injected(ref UnityEngine.Playables.PlayableHandle _unity_self, ref UnityEngine.Playables.PlayableHandle input, float weight);
            static /*0x7e8d788*/ void GetInputHandle_Injected(ref UnityEngine.Playables.PlayableHandle _unity_self, int index, ref UnityEngine.Playables.PlayableHandle ret);
            static /*0x7e8d7dc*/ void GetOutputHandle_Injected(ref UnityEngine.Playables.PlayableHandle _unity_self, int index, ref UnityEngine.Playables.PlayableHandle ret);
            /*0x3907c14*/ T GetObject<T>();
            /*0x380b128*/ bool IsPlayableOfType<T>();
            /*0x7e8ca18*/ UnityEngine.Playables.Playable GetInput(int inputPort);
            /*0x7e8cb18*/ UnityEngine.Playables.Playable GetOutput(int outputPort);
            /*0x7e8cc18*/ bool SetInputWeight(int inputIndex, float weight);
            /*0x7e8cd94*/ float GetInputWeight(int inputIndex);
            /*0x7e8ce90*/ bool Equals(object p);
            /*0x7e8cf38*/ bool Equals(UnityEngine.Playables.PlayableHandle other);
            /*0x7e8cfb0*/ int GetHashCode();
            /*0x7e8ccd0*/ bool CheckInputBounds(int inputIndex);
            /*0x7e8cfe4*/ bool CheckInputBounds(int inputIndex, bool acceptAny);
            /*0x7e8d248*/ bool IsValid();
            /*0x7e8bfc8*/ System.Type GetPlayableType();
            /*0x7e8d284*/ void SetScriptInstance(object scriptInstance);
            /*0x7e8d2c8*/ UnityEngine.Playables.PlayState GetPlayState();
            /*0x7e8d304*/ void Play();
            /*0x7e8d340*/ void Pause();
            /*0x7e8d37c*/ void SetSpeed(double value);
            /*0x7e8d3c8*/ double GetTime();
            /*0x7e8d404*/ void SetTime(double value);
            /*0x7e8d450*/ bool IsDone();
            /*0x7e8d48c*/ double GetDuration();
            /*0x7e8d4c8*/ void SetDuration(double value);
            /*0x7e8d514*/ void SetPropagateSetTime(bool value);
            /*0x7e8d20c*/ int GetInputCount();
            /*0x7e8d558*/ void SetInputCount(int value);
            /*0x7e8d59c*/ void SetInputWeight(UnityEngine.Playables.PlayableHandle input, float weight);
            /*0x7e8d688*/ void SetTraversalMode(UnityEngine.Playables.PlayableTraversalMode mode);
            /*0x7e8d6cc*/ UnityEngine.Playables.DirectorWrapMode GetTimeWrapMode();
            /*0x7e8d708*/ void SetTimeWrapMode(UnityEngine.Playables.DirectorWrapMode mode);
            /*0x7e8d74c*/ object GetScriptInstance();
            /*0x7e8ca7c*/ UnityEngine.Playables.PlayableHandle GetInputHandle(int index);
            /*0x7e8cb7c*/ UnityEngine.Playables.PlayableHandle GetOutputHandle(int index);
            /*0x7e8cd40*/ void SetInputWeightFromIndex(int index, float weight);
            /*0x7e8ce34*/ float GetInputWeightFromIndex(int index);
        }

        struct PlayableOutput : UnityEngine.Playables.IPlayableOutput, System.IEquatable<UnityEngine.Playables.PlayableOutput>
        {
            static /*0x0*/ UnityEngine.Playables.PlayableOutput m_NullPlayableOutput;
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x7e8d9a4*/ PlayableOutput();
            static /*0x7e8c460*/ UnityEngine.Playables.PlayableOutput get_Null();
            /*0x7e8d878*/ PlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x7e8d880*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            /*0x380b128*/ bool IsPlayableOutputOfType<T>();
            /*0x7e8d88c*/ bool Equals(UnityEngine.Playables.PlayableOutput other);
        }

        class PlayableOutputExtensions
        {
            static /*0x3907c14*/ void SetReferenceObject<U>(U output, UnityEngine.Object value);
            static /*0x3907c14*/ UnityEngine.Object GetUserData<U>(U output);
            static /*0x3907c14*/ void SetUserData<U>(U output, UnityEngine.Object value);
            static /*0x3907c14*/ UnityEngine.Playables.Playable GetSourcePlayable<U>(U output);
            static /*0x3907c14*/ void SetSourcePlayable<U, V>(U output, V value, int port);
            static /*0x3907c14*/ int GetSourceOutputPort<U>(U output);
            static /*0x3907c14*/ void SetWeight<U>(U output, float value);
            static /*0x3907c14*/ void PushNotification<U>(U output, UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, object context);
            static /*0x3907c14*/ void AddNotificationReceiver<U>(U output, UnityEngine.Playables.INotificationReceiver receiver);
        }

        struct PlayableOutputHandle : System.IEquatable<UnityEngine.Playables.PlayableOutputHandle>
        {
            static /*0x0*/ UnityEngine.Playables.PlayableOutputHandle m_Null;
            /*0x10*/ nint m_Handle;
            /*0x18*/ uint m_Version;

            static /*0x7e8e1d8*/ PlayableOutputHandle();
            static /*0x7e8da14*/ UnityEngine.Playables.PlayableOutputHandle get_Null();
            static /*0x7e8d924*/ bool op_Equality(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs);
            static /*0x7e8daa0*/ bool CompareVersion(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs);
            static /*0x7e8dd00*/ void SetReferenceObject_Injected(ref UnityEngine.Playables.PlayableOutputHandle _unity_self, nint target);
            static /*0x7e8ddd4*/ nint GetUserData_Injected(ref UnityEngine.Playables.PlayableOutputHandle _unity_self);
            static /*0x7e8dee0*/ void GetSourcePlayable_Injected(ref UnityEngine.Playables.PlayableOutputHandle _unity_self, ref UnityEngine.Playables.PlayableHandle ret);
            static /*0x7e8dfbc*/ void SetSourcePlayable_Injected(ref UnityEngine.Playables.PlayableOutputHandle _unity_self, ref UnityEngine.Playables.PlayableHandle target, int port);
            static /*0x7e8e138*/ void PushNotification_Injected(ref UnityEngine.Playables.PlayableOutputHandle _unity_self, ref UnityEngine.Playables.PlayableHandle origin, UnityEngine.Playables.INotification notification, object context);
            /*0x380b128*/ bool IsPlayableOutputOfType<T>();
            /*0x7e8da6c*/ int GetHashCode();
            /*0x7e8dab8*/ bool Equals(object p);
            /*0x7e8db60*/ bool Equals(UnityEngine.Playables.PlayableOutputHandle other);
            /*0x7e8dbd8*/ bool IsValid();
            /*0x7e8dc14*/ System.Type GetPlayableOutputType();
            /*0x7e8dc50*/ void SetReferenceObject(UnityEngine.Object target);
            /*0x7e8dd44*/ UnityEngine.Object GetUserData();
            /*0x7e8de10*/ void SetUserData(UnityEngine.Object target);
            /*0x7e8de54*/ UnityEngine.Playables.PlayableHandle GetSourcePlayable();
            /*0x7e8df24*/ void SetSourcePlayable(UnityEngine.Playables.PlayableHandle target, int port);
            /*0x7e8e010*/ int GetSourceOutputPort();
            /*0x7e8e04c*/ void SetWeight(float weight);
            /*0x7e8e098*/ void PushNotification(UnityEngine.Playables.PlayableHandle origin, UnityEngine.Playables.INotification notification, object context);
            /*0x7e8e194*/ void AddNotificationReceiver(UnityEngine.Playables.INotificationReceiver receiver);
        }

        struct ScriptPlayable<T> : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Playables.ScriptPlayable<T>>
        {
            static /*0x0*/ UnityEngine.Playables.ScriptPlayable<T> m_NullPlayable;
            /*0x0*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x38358cc*/ ScriptPlayable();
            static /*0x3907c14*/ UnityEngine.Playables.ScriptPlayable<T> get_Null();
            static /*0x3907c14*/ UnityEngine.Playables.ScriptPlayable<T> Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x3907c14*/ UnityEngine.Playables.ScriptPlayable<T> Create(UnityEngine.Playables.PlayableGraph graph, T template, int inputCount);
            static /*0x3907c14*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, T template, int inputCount);
            static /*0x382dee4*/ object CreateScriptInstance();
            static /*0x382eaf0*/ object CloneScriptInstance(UnityEngine.Playables.IPlayableBehaviour source);
            static /*0x382eaf0*/ object CloneScriptInstanceFromEngineObject(UnityEngine.Object source);
            static /*0x382eaf0*/ object CloneScriptInstanceFromIClonable(System.ICloneable source);
            static /*0x3907c14*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Playables.ScriptPlayable<T> playable);
            static /*0x3907c14*/ UnityEngine.Playables.ScriptPlayable<T> op_Explicit(UnityEngine.Playables.Playable playable);
            /*0x3907c14*/ ScriptPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x3907c14*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x3907c14*/ T GetBehaviour();
            /*0x3907c14*/ bool Equals(UnityEngine.Playables.ScriptPlayable<T> other);
        }

        class ScriptPlayableBinding
        {
            static /*0x7e8e220*/ UnityEngine.Playables.PlayableBinding Create(string name, UnityEngine.Object key, System.Type type);
            static /*0x7e8e304*/ UnityEngine.Playables.PlayableOutput CreateScriptOutput(UnityEngine.Playables.PlayableGraph graph, string name);
        }

        struct ScriptPlayableOutput : UnityEngine.Playables.IPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x7e8e308*/ UnityEngine.Playables.ScriptPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, string name);
            static /*0x7e8e35c*/ UnityEngine.Playables.ScriptPlayableOutput get_Null();
            static /*0x7e8e358*/ UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Playables.ScriptPlayableOutput output);
            /*0x7e8e3d4*/ ScriptPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x7e8e4e0*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
        }
    }

    namespace Assertions
    {
        class Assert
        {
            static /*0x0*/ bool raiseExceptions;

            static /*0x7e8ef64*/ Assert();
            static /*0x7e8e4ec*/ void Fail(string message, string userMessage);
            static /*0x7e8e688*/ void IsTrue(bool condition);
            static /*0x7e8e6f4*/ void IsTrue(bool condition, string message);
            static /*0x7e8e814*/ void IsFalse(bool condition);
            static /*0x7e8e880*/ void IsFalse(bool condition, string message);
            static /*0x3907c14*/ void AreEqual<T>(T expected, T actual);
            static /*0x3907c14*/ void AreEqual<T>(T expected, T actual, string message);
            static /*0x3907c14*/ void AreEqual<T>(T expected, T actual, string message, System.Collections.Generic.IEqualityComparer<T> comparer);
            static /*0x7e8e900*/ void AreEqual(UnityEngine.Object expected, UnityEngine.Object actual, string message);
            static /*0x3907c14*/ void IsNull<T>(T value);
            static /*0x3907c14*/ void IsNull<T>(T value, string message);
            static /*0x7e8ebe8*/ void IsNull(UnityEngine.Object value, string message);
            static /*0x3907c14*/ void IsNotNull<T>(T value);
            static /*0x3907c14*/ void IsNotNull<T>(T value, string message);
            static /*0x7e8ee20*/ void IsNotNull(UnityEngine.Object value, string message);
            static /*0x7e8eed8*/ void AreEqual(int expected, int actual);
        }

        class AssertionException : System.Exception
        {
            /*0x90*/ string m_UserMessage;

            /*0x7e8e60c*/ AssertionException(string message, string userMessage);
            /*0x7e8efb0*/ string get_Message();
        }

        class AssertionMessageUtil
        {
            static /*0x7e8f024*/ string GetMessage(string failureMessage);
            static /*0x7e8f12c*/ string GetMessage(string failureMessage, string expected);
            static /*0x7e8e9c4*/ string GetEqualityMessage(object actual, object expected, bool expectEqual);
            static /*0x7e8eca0*/ string NullFailureMessage(object value, bool expectNull);
            static /*0x7e8e774*/ string BooleanFailureMessage(bool expected);
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

            /*0x7e8f2b8*/ AnalyticsEventBase(string eventName, int eventVersion, UnityEngine.Analytics.SendEventOptions sendEventOptions, string eventPrefix);
        }

        class BatchRenderGroupUsageAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ int maxBRGInstance;
            /*0x30*/ int maxMeshCount;
            /*0x34*/ int maxMaterialCount;
            /*0x38*/ int maxDrawCommandBatch;

            static /*0x7e8f384*/ UnityEngine.Analytics.BatchRenderGroupUsageAnalytic CreateBatchRenderGroupUsageAnalytic();
            /*0x7e8f314*/ BatchRenderGroupUsageAnalytic();
        }

        class UaaLApplicationLaunchAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ int launch_type;
            /*0x30*/ int launch_process_type;

            static /*0x7e8f444*/ UnityEngine.Analytics.UaaLApplicationLaunchAnalytic CreateUaaLApplicationLaunchAnalytic();
            /*0x7e8f3d4*/ UaaLApplicationLaunchAnalytic();
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

            static /*0x7e8f520*/ UnityEngine.Analytics.ShaderRuntimeInfoAnalytic CreateShaderRuntimeInfoAnalytic();
            /*0x7e8f494*/ ShaderRuntimeInfoAnalytic();
        }
    }

    namespace Rendering
    {
        class SortingGroup : UnityEngine.Behaviour
        {
            static /*0x7e8f570*/ int get_invalidSortingGroupID();
            static /*0x7e8f598*/ void UpdateAllSortingGroups();
            static /*0x7e8f5c0*/ UnityEngine.Rendering.SortingGroup GetSortingGroupByIndex(int index);
            static /*0x7e8f62c*/ nint GetSortingGroupByIndex_Injected(int index);
            static /*0x7e8f758*/ void get_sortingLayerName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x7e8f90c*/ void set_sortingLayerName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x7e8f9c4*/ int get_sortingLayerID_Injected(nint _unity_self);
            static /*0x7e8fa7c*/ void set_sortingLayerID_Injected(nint _unity_self, int value);
            static /*0x7e8fb34*/ int get_sortingOrder_Injected(nint _unity_self);
            static /*0x7e8fbec*/ void set_sortingOrder_Injected(nint _unity_self, int value);
            static /*0x7e8fca4*/ bool get_sortAtRoot_Injected(nint _unity_self);
            static /*0x7e8fd5c*/ void set_sortAtRoot_Injected(nint _unity_self, bool value);
            static /*0x7e8fe14*/ int get_sortingGroupID_Injected(nint _unity_self);
            static /*0x7e8fec4*/ int get_sortingGroupOrder_Injected(nint _unity_self);
            static /*0x7e8ff74*/ int get_index_Injected(nint _unity_self);
            static /*0x7e90024*/ uint get_sortingKey_Injected(nint _unity_self);
            /*0x7e90060*/ SortingGroup();
            /*0x7e8f668*/ string get_sortingLayerName();
            /*0x7e8f79c*/ void set_sortingLayerName(string value);
            /*0x7e8f950*/ int get_sortingLayerID();
            /*0x7e8fa00*/ void set_sortingLayerID(int value);
            /*0x7e8fac0*/ int get_sortingOrder();
            /*0x7e8fb70*/ void set_sortingOrder(int value);
            /*0x7e8fc30*/ bool get_sortAtRoot();
            /*0x7e8fce0*/ void set_sortAtRoot(bool value);
            /*0x7e8fda0*/ int get_sortingGroupID();
            /*0x7e8fe50*/ int get_sortingGroupOrder();
            /*0x7e8ff00*/ int get_index();
            /*0x7e8ffb0*/ uint get_sortingKey();
        }

        struct AsyncGPUReadbackRequest
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ int m_Version;

            static /*0x7e9030c*/ void InvokeCallback(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncGPUReadbackRequest obj);
            /*0x7e90068*/ void WaitForCompletion();
            /*0x3907c14*/ Unity.Collections.NativeArray<T> GetData<T>(int layer);
            /*0x7e900a4*/ bool get_done();
            /*0x7e9011c*/ bool get_hasError();
            /*0x7e90194*/ int get_layerCount();
            /*0x7e9020c*/ int get_layerDataSize();
            /*0x7e900e0*/ bool IsDone();
            /*0x7e90158*/ bool HasError();
            /*0x7e901d0*/ int GetLayerCount();
            /*0x7e90248*/ int GetLayerDataSize();
            /*0x7e90284*/ void SetScriptingCallback(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x7e902c8*/ nint GetDataRaw(int layer);
        }

        struct AsyncRequestNativeArrayData
        {
            /*0x10*/ void* nativeArrayBuffer;
            /*0x18*/ long lengthInBytes;

            static /*0x3907c14*/ UnityEngine.Rendering.AsyncRequestNativeArrayData CreateAndCheckAccess<T>(Unity.Collections.NativeArray<T> array);
        }

        class AsyncGPUReadback
        {
            static /*0x7e90330*/ UnityEngine.Rendering.AsyncGPUReadbackRequest Request(UnityEngine.GraphicsBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            static /*0x7e9043c*/ UnityEngine.Rendering.AsyncGPUReadbackRequest Request(UnityEngine.GraphicsBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            static /*0x7e90390*/ UnityEngine.Rendering.AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_1(UnityEngine.GraphicsBuffer buffer, UnityEngine.Rendering.AsyncRequestNativeArrayData* data);
            static /*0x7e9049c*/ UnityEngine.Rendering.AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_2(UnityEngine.GraphicsBuffer src, int size, int offset, UnityEngine.Rendering.AsyncRequestNativeArrayData* data);
            static /*0x7e90560*/ void Request_Internal_GraphicsBuffer_1_Injected(nint buffer, UnityEngine.Rendering.AsyncRequestNativeArrayData* data, ref UnityEngine.Rendering.AsyncGPUReadbackRequest ret);
            static /*0x7e905b4*/ void Request_Internal_GraphicsBuffer_2_Injected(nint src, int size, int offset, UnityEngine.Rendering.AsyncRequestNativeArrayData* data, ref UnityEngine.Rendering.AsyncGPUReadbackRequest ret);
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

        enum AmbientMode
        {
            Skybox = 0,
            Trilight = 1,
            Flat = 3,
            Custom = 4,
        }

        enum DefaultReflectionMode
        {
            Skybox = 0,
            Custom = 1,
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
            static /*0x7e90620*/ bool IsValid(UnityEngine.Rendering.CameraEvent value);
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
            ReservedCFE = 29,
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

            /*0x7e9062c*/ UnityEngine.Bounds get_bounds();
            /*0x7e90640*/ UnityEngine.MeshTopology get_topology();
            /*0x7e90648*/ int get_indexStart();
            /*0x7e90650*/ int get_indexCount();
            /*0x7e90658*/ int get_baseVertex();
            /*0x7e90660*/ int get_firstVertex();
            /*0x7e90668*/ int get_vertexCount();
            /*0x7e90670*/ string ToString();
        }

        struct VertexAttributeDescriptor : System.IEquatable<UnityEngine.Rendering.VertexAttributeDescriptor>
        {
            /*0x10*/ UnityEngine.Rendering.VertexAttribute <attribute>k__BackingField;
            /*0x14*/ UnityEngine.Rendering.VertexAttributeFormat <format>k__BackingField;
            /*0x18*/ int <dimension>k__BackingField;
            /*0x1c*/ int <stream>k__BackingField;

            /*0x7e90994*/ VertexAttributeDescriptor(UnityEngine.Rendering.VertexAttribute attribute, UnityEngine.Rendering.VertexAttributeFormat format, int dimension, int stream);
            /*0x7e90954*/ UnityEngine.Rendering.VertexAttribute get_attribute();
            /*0x7e9095c*/ void set_attribute(UnityEngine.Rendering.VertexAttribute value);
            /*0x7e90964*/ UnityEngine.Rendering.VertexAttributeFormat get_format();
            /*0x7e9096c*/ void set_format(UnityEngine.Rendering.VertexAttributeFormat value);
            /*0x7e90974*/ int get_dimension();
            /*0x7e9097c*/ void set_dimension(int value);
            /*0x7e90984*/ int get_stream();
            /*0x7e9098c*/ void set_stream(int value);
            /*0x7e909a0*/ string ToString();
            /*0x7e90b98*/ int GetHashCode();
            /*0x7e90bc0*/ bool Equals(object other);
            /*0x7e90c68*/ bool Equals(UnityEngine.Rendering.VertexAttributeDescriptor other);
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

            static /*0x7e90eac*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.BuiltinRenderTextureType type);
            static /*0x7e90ed0*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(string name);
            static /*0x7e90f00*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(int nameID);
            static /*0x7e90f1c*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Texture tex);
            static /*0x7e90f6c*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.RenderBuffer buf);
            static /*0x7e913c4*/ bool op_Equality(UnityEngine.Rendering.RenderTargetIdentifier lhs, UnityEngine.Rendering.RenderTargetIdentifier rhs);
            static /*0x7e913f4*/ bool op_Inequality(UnityEngine.Rendering.RenderTargetIdentifier lhs, UnityEngine.Rendering.RenderTargetIdentifier rhs);
            /*0x7e90cac*/ RenderTargetIdentifier(UnityEngine.Rendering.BuiltinRenderTextureType type);
            /*0x7e90ccc*/ RenderTargetIdentifier(string name);
            /*0x7e90d04*/ RenderTargetIdentifier(int nameID);
            /*0x7e90d24*/ RenderTargetIdentifier(int nameID, int mipLevel, UnityEngine.CubemapFace cubeFace, int depthSlice);
            /*0x7e90d40*/ RenderTargetIdentifier(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier, int mipLevel, UnityEngine.CubemapFace cubeFace, int depthSlice);
            /*0x7e90d6c*/ RenderTargetIdentifier(UnityEngine.Texture tex);
            /*0x7e90e8c*/ RenderTargetIdentifier(UnityEngine.RenderBuffer buf, int mipLevel, UnityEngine.CubemapFace cubeFace, int depthSlice);
            /*0x7e90f90*/ string ToString();
            /*0x7e9126c*/ int GetHashCode();
            /*0x7e912b8*/ bool Equals(UnityEngine.Rendering.RenderTargetIdentifier rhs);
            /*0x7e91334*/ bool Equals(object obj);
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

            /*0x7e91428*/ UnityEngine.Rendering.RenderTargetIdentifier[] get_colorRenderTargets();
            /*0x7e91430*/ UnityEngine.Rendering.RenderTargetIdentifier get_depthRenderTarget();
            /*0x7e91448*/ UnityEngine.Rendering.RenderBufferLoadAction[] get_colorLoadActions();
            /*0x7e91450*/ UnityEngine.Rendering.RenderBufferStoreAction[] get_colorStoreActions();
            /*0x7e91458*/ UnityEngine.Rendering.RenderBufferLoadAction get_depthLoadAction();
            /*0x7e91460*/ UnityEngine.Rendering.RenderBufferStoreAction get_depthStoreAction();
            /*0x7e91468*/ UnityEngine.Rendering.RenderTargetFlags get_flags();
        }

        enum ReflectionProbeUsage
        {
            Off = 0,
            BlendProbes = 1,
            BlendProbesAndSkybox = 2,
            Simple = 3,
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
            UNITY_PLATFORM_SUPPORTS_DEPTH_FETCH = 36,
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

            static /*0x7e91470*/ UnityEngine.Rendering.SynchronisationStageFlags TranslateSynchronizationStageToFlags(UnityEngine.Rendering.SynchronisationStage s);
            static /*0x7e91530*/ int GetVersionNumber(nint fencePtr);
            /*0x7e91480*/ void InitPostAllocation();
            /*0x7e9156c*/ bool IsFencePending();
            /*0x7e915c4*/ void Validate();
            /*0x7e91528*/ int GetPlatformNotSupportedVersion();
        }

        class GraphicsSettings : UnityEngine.Object
        {
            static /*0x0*/ System.Lazy<UnityEngine.Rendering.RenderPipelineGlobalSettings> s_CurrentRenderPipelineGlobalSettings;

            static /*0x7e92278*/ GraphicsSettings();
            static /*0x7e9163c*/ UnityEngine.Object Internal_GetSettingsForRenderPipeline(string renderpipelineName);
            static /*0x382dee4*/ UnityEngine.Rendering.RenderPipelineGlobalSettings GetSettingsForRenderPipeline<T>();
            static /*0x7e91864*/ UnityEngine.Rendering.RenderPipelineGlobalSettings Internal_GetCurrentRenderPipelineGlobalSettings();
            static /*0x7e91a0c*/ bool TryGetCurrentRenderPipelineGlobalSettings(ref UnityEngine.Rendering.RenderPipelineGlobalSettings asset);
            static /*0x3907c14*/ T GetRenderPipelineSettings<T>();
            static /*0x381ac0c*/ bool TryGetRenderPipelineSettings<T>(ref T settings);
            static /*0x7e91ad0*/ bool get_lightsUseLinearIntensity();
            static /*0x7e91af8*/ void set_lightsUseLinearIntensity(bool value);
            static /*0x7e91b34*/ void set_lightsUseColorTemperature(bool value);
            static /*0x7e91b70*/ bool get_useScriptableRenderPipelineBatching();
            static /*0x7e91b98*/ void set_useScriptableRenderPipelineBatching(bool value);
            static /*0x7e91bd4*/ bool HasShaderDefine(UnityEngine.Rendering.GraphicsTier tier, UnityEngine.Rendering.BuiltinShaderDefine defineHash);
            static /*0x7e91c18*/ bool HasShaderDefine(UnityEngine.Rendering.BuiltinShaderDefine defineHash);
            static /*0x7e91cc4*/ UnityEngine.ScriptableObject get_INTERNAL_currentRenderPipeline();
            static /*0x7e91970*/ UnityEngine.Rendering.RenderPipelineAsset get_currentRenderPipeline();
            static /*0x7e91d74*/ bool get_isScriptableRenderPipelineEnabled();
            static /*0x7e91dfc*/ System.Type get_currentRenderPipelineAssetType();
            static /*0x7e91e80*/ UnityEngine.Shader GetDefaultShader(UnityEngine.Rendering.DefaultShaderType type);
            static /*0x7e92080*/ UnityEngine.Material GetDefaultMaterial(UnityEngine.Rendering.DefaultMaterialType type);
            static /*0x7e91828*/ nint Internal_GetSettingsForRenderPipeline_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper renderpipelineName);
            static /*0x7e91d4c*/ nint get_INTERNAL_currentRenderPipeline_Injected();

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.GraphicsSettings.<> <>9;

                static /*0x7e92390*/ <>c();
                /*0x7e923f8*/ <>c();
                /*0x7e92400*/ UnityEngine.Rendering.RenderPipelineGlobalSettings <.cctor>b__93_0();
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
            /*0x380b6a0*/ int get_version();
            /*0x7e9244c*/ bool get_isAvailableInPlayerBuild();
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
            /*0x7e92454*/ ResourcePathsBaseAttribute(string[] paths, bool isField, UnityEngine.Rendering.SearchType location);
        }

        class ResourcePathAttribute : UnityEngine.Rendering.ResourcePathsBaseAttribute
        {
            /*0x7e9245c*/ ResourcePathAttribute(string path, UnityEngine.Rendering.SearchType location);
        }

        class OnDemandRendering
        {
            static /*0x0*/ int m_RenderFrameInterval;

            static /*0x7e92514*/ OnDemandRendering();
            static /*0x7e92464*/ int get_renderFrameInterval();
            static /*0x7e924bc*/ void GetRenderFrameInterval(ref int frameInterval);
        }

        class RayTracingAccelerationStructure : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x7e92654*/ void Destroy(UnityEngine.Rendering.RayTracingAccelerationStructure accelStruct);
            static /*0x7e9269c*/ void Destroy_Injected(nint accelStruct);
            /*0x7e92560*/ void Dispose();
            /*0x7e925fc*/ void Dispose(bool disposing);

            struct BuildSettings
            {
                /*0x10*/ UnityEngine.Rendering.RayTracingAccelerationStructureBuildFlags <buildFlags>k__BackingField;
                /*0x14*/ UnityEngine.Vector3 <relativeOrigin>k__BackingField;

                /*0x7e926ec*/ BuildSettings();
                /*0x7e926d8*/ void set_buildFlags(UnityEngine.Rendering.RayTracingAccelerationStructureBuildFlags value);
                /*0x7e926e0*/ void set_relativeOrigin(UnityEngine.Vector3 value);
            }

            class BindingsMarshaller
            {
                static /*0x7e92748*/ nint ConvertToNative(UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            }
        }

        class RenderPipelineGraphicsSettingsCollection
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> m_List;

            /*0x7e92768*/ RenderPipelineGraphicsSettingsCollection();
            /*0x7e92760*/ System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> get_settingsList();
        }

        class RenderPipelineGraphicsSettingsExtensions
        {
            static /*0x3907c14*/ void SetValueAndNotify<T>(UnityEngine.Rendering.IRenderPipelineGraphicsSettings settings, ref T currentPropertyValue, T newValue, string propertyName);
        }

        class RecreatePipelineOnChangeAttribute : System.Attribute
        {
            /*0x7e927f0*/ RecreatePipelineOnChangeAttribute();
        }

        class CommandBuffer : System.IDisposable
        {
            static /*0x0*/ bool ThrowOnSetRenderTarget;
            /*0x10*/ nint m_Ptr;

            static /*0x7e93830*/ nint InitBuffer();
            static /*0x7e9d1d0*/ void CheckThrowOnSetRenderTarget();
            static /*0x7e92908*/ void Internal_RequestAsyncReadback_1_Injected(nint _unity_self, nint src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7e92a8c*/ void Internal_RequestAsyncReadback_2_Injected(nint _unity_self, nint src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7e92c1c*/ void Internal_RequestAsyncReadback_3_Injected(nint _unity_self, nint src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7e92da4*/ void Internal_RequestAsyncReadback_4_Injected(nint _unity_self, nint src, int mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7e92f44*/ void Internal_RequestAsyncReadback_5_Injected(nint _unity_self, nint src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7e93124*/ void Internal_RequestAsyncReadback_6_Injected(nint _unity_self, nint src, int mipIndex, int x, int width, int y, int height, int z, int depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7e93338*/ void Internal_RequestAsyncReadback_7_Injected(nint _unity_self, nint src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7e93500*/ void Internal_RequestAsyncReadback_8_Injected(nint _unity_self, nint src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7e93684*/ void Internal_RequestAsyncReadback_9_Injected(nint _unity_self, nint src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7e93750*/ void SetInvertCulling_Injected(nint _unity_self, bool invertCulling);
            static /*0x7e937ec*/ void Internal_SetSinglePassStereo_Injected(nint _unity_self, UnityEngine.Rendering.SinglePassStereoMode mode);
            static /*0x7e938c0*/ nint CreateGPUFence_Internal_Injected(nint _unity_self, UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage);
            static /*0x7e9397c*/ void WaitOnGPUFence_Internal_Injected(nint _unity_self, nint fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage);
            static /*0x7e93a20*/ void ReleaseBuffer_Injected(nint _unity_self);
            static /*0x7e93b54*/ void SetComputeFloatParam_Injected(nint _unity_self, nint computeShader, int nameID, float val);
            static /*0x7e93ca8*/ void SetComputeIntParam_Injected(nint _unity_self, nint computeShader, int nameID, int val);
            static /*0x7e93e04*/ void SetComputeVectorParam_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Vector4 val);
            static /*0x7e93fc0*/ void SetComputeVectorArrayParam_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7e9410c*/ void SetComputeMatrixParam_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Matrix4x4 val);
            static /*0x7e942c8*/ void SetComputeMatrixArrayParam_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7e94484*/ void Internal_SetComputeFloats_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7e94640*/ void Internal_SetComputeInts_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7e947b4*/ void Internal_SetComputeTextureParam_Injected(nint _unity_self, nint computeShader, int kernelIndex, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            static /*0x7e94940*/ void Internal_SetComputeBufferParam_Injected(nint _unity_self, nint computeShader, int kernelIndex, int nameID, nint buffer);
            static /*0x7e94ab0*/ void Internal_SetComputeGraphicsBufferHandleParam_Injected(nint _unity_self, nint computeShader, int kernelIndex, int nameID, ref UnityEngine.GraphicsBufferHandle bufferHandle);
            static /*0x7e94c24*/ void Internal_SetComputeGraphicsBufferParam_Injected(nint _unity_self, nint computeShader, int kernelIndex, int nameID, nint buffer);
            static /*0x7e94da0*/ void Internal_SetComputeConstantComputeBufferParam_Injected(nint _unity_self, nint computeShader, int nameID, nint buffer, int offset, int size);
            static /*0x7e94f24*/ void Internal_SetComputeConstantGraphicsBufferParam_Injected(nint _unity_self, nint computeShader, int nameID, nint buffer, int offset, int size);
            static /*0x7e950a0*/ void Internal_DispatchCompute_Injected(nint _unity_self, nint computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            static /*0x7e9521c*/ void Internal_DispatchComputeIndirect_Injected(nint _unity_self, nint computeShader, int kernelIndex, nint indirectBuffer, uint argsOffset);
            static /*0x7e95390*/ void Internal_DispatchComputeIndirectGraphicsBuffer_Injected(nint _unity_self, nint computeShader, int kernelIndex, nint indirectBuffer, uint argsOffset);
            static /*0x7e954f4*/ void Internal_SetRayTracingComputeBufferParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, nint buffer);
            static /*0x7e95648*/ void Internal_SetRayTracingGraphicsBufferParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, nint buffer);
            static /*0x7e95798*/ void Internal_SetRayTracingGraphicsBufferHandleParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.GraphicsBufferHandle bufferHandle);
            static /*0x7e95904*/ void Internal_SetRayTracingConstantComputeBufferParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, nint buffer, int offset, int size);
            static /*0x7e95a88*/ void Internal_SetRayTracingConstantGraphicsBufferParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, nint buffer, int offset, int size);
            static /*0x7e95bec*/ void Internal_SetRayTracingTextureParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt);
            static /*0x7e95d40*/ void Internal_SetRayTracingFloatParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, float val);
            static /*0x7e95e94*/ void Internal_SetRayTracingIntParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, int val);
            static /*0x7e95ff0*/ void Internal_SetRayTracingVectorParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Vector4 val);
            static /*0x7e961ac*/ void Internal_SetRayTracingVectorArrayParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7e962f8*/ void Internal_SetRayTracingMatrixParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Matrix4x4 val);
            static /*0x7e964b4*/ void Internal_SetRayTracingMatrixArrayParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7e96670*/ void Internal_SetRayTracingFloats_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7e9682c*/ void Internal_SetRayTracingInts_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7e96968*/ void Internal_BuildRayTracingAccelerationStructure_Injected(nint _unity_self, nint accelerationStructure, ref UnityEngine.Rendering.RayTracingAccelerationStructure.BuildSettings buildSettings);
            static /*0x7e96afc*/ void Internal_SetRayTracingAccelerationStructure_Injected(nint _unity_self, nint rayTracingShader, int nameID, nint accelerationStructure);
            static /*0x7e96ca8*/ void Internal_SetComputeRayTracingAccelerationStructure_Injected(nint _unity_self, nint computeShader, int kernelIndex, int nameID, nint accelerationStructure);
            static /*0x7e96f78*/ void Internal_DispatchRays_Injected(nint _unity_self, nint rayTracingShader, ref UnityEngine.Bindings.ManagedSpanWrapper rayGenShaderName, uint width, uint height, uint depth, nint camera);
            static /*0x7e9707c*/ void CopyCounterValueCC_Injected(nint _unity_self, nint src, nint dst, uint dstOffsetBytes);
            static /*0x7e97158*/ void CopyCounterValueGC_Injected(nint _unity_self, nint src, nint dst, uint dstOffsetBytes);
            static /*0x7e97234*/ void CopyCounterValueCG_Injected(nint _unity_self, nint src, nint dst, uint dstOffsetBytes);
            static /*0x7e97310*/ void CopyCounterValueGG_Injected(nint _unity_self, nint src, nint dst, uint dstOffsetBytes);
            static /*0x7e97448*/ void get_name_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x7e9761c*/ void set_name_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x7e976b0*/ int get_sizeInBytes_Injected(nint _unity_self);
            static /*0x7e9773c*/ void Clear_Injected(nint _unity_self);
            static /*0x7e978c4*/ void Internal_DrawMesh_Injected(nint _unity_self, nint mesh, ref UnityEngine.Matrix4x4 matrix, nint material, int submeshIndex, int shaderPass, nint properties);
            static /*0x7e97b24*/ void Internal_DrawMultipleMeshes_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper matrices, UnityEngine.Mesh[] meshes, ref UnityEngine.Bindings.ManagedSpanWrapper subsetIndices, int count, nint material, int shaderPass, nint properties);
            static /*0x7e97cdc*/ void Internal_DrawRenderer_Injected(nint _unity_self, nint renderer, nint material, int submeshIndex, int shaderPass);
            static /*0x7e97da0*/ void Internal_DrawRendererList_Injected(nint _unity_self, ref UnityEngine.Rendering.RendererList rendererList);
            static /*0x7e97edc*/ void Internal_DrawProcedural_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, nint properties);
            static /*0x7e98078*/ void Internal_DrawProceduralIndexed_Injected(nint _unity_self, nint indexBuffer, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, nint properties);
            static /*0x7e98214*/ void Internal_DrawProceduralIndirect_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x7e983b8*/ void Internal_DrawProceduralIndexedIndirect_Injected(nint _unity_self, nint indexBuffer, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x7e98554*/ void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x7e986f8*/ void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(nint _unity_self, nint indexBuffer, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x7e98934*/ void Internal_DrawMeshInstanced_Injected(nint _unity_self, nint mesh, int submeshIndex, nint material, int shaderPass, ref UnityEngine.Bindings.ManagedSpanWrapper matrices, int count, nint properties);
            static /*0x7e98ad4*/ void Internal_DrawMeshInstancedProcedural_Injected(nint _unity_self, nint mesh, int submeshIndex, nint material, int shaderPass, int count, nint properties);
            static /*0x7e98c84*/ void Internal_DrawMeshInstancedIndirect_Injected(nint _unity_self, nint mesh, int submeshIndex, nint material, int shaderPass, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x7e98e3c*/ void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(nint _unity_self, nint mesh, int submeshIndex, nint material, int shaderPass, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x7e98f2c*/ void Internal_DrawOcclusionMesh_Injected(nint _unity_self, ref UnityEngine.RectInt normalizedCamViewport);
            static /*0x7e98fd8*/ void SetRandomWriteTarget_Texture_Injected(nint _unity_self, int index, ref UnityEngine.Rendering.RenderTargetIdentifier rt);
            static /*0x7e990a4*/ void SetRandomWriteTarget_GraphicsBuffer_Injected(nint _unity_self, int index, nint uav, bool preserveCounterValue);
            static /*0x7e99150*/ void ClearRandomWriteTargets_Injected(nint _unity_self);
            static /*0x7e991f4*/ void SetViewport_Injected(nint _unity_self, ref UnityEngine.Rect pixelRect);
            static /*0x7e992a0*/ void EnableScissorRect_Injected(nint _unity_self, ref UnityEngine.Rect scissor);
            static /*0x7e99334*/ void DisableScissorRect_Injected(nint _unity_self);
            static /*0x7e99480*/ void CopyTexture_Internal_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode);
            static /*0x7e99670*/ void Blit_Texture_Injected(nint _unity_self, nint source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, nint mat, int pass, ref UnityEngine.Vector2 scale, ref UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            static /*0x7e99808*/ void Blit_Identifier_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, nint mat, int pass, ref UnityEngine.Vector2 scale, ref UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            static /*0x7e999ac*/ void GetTemporaryRT_Injected(nint _unity_self, int nameID, int width, int height, UnityEngine.FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int antiAliasing, bool enableRandomWrite, UnityEngine.RenderTextureMemoryless memorylessMode, bool useDynamicScale, UnityEngine.Rendering.ShadowSamplingMode shadowSamplingMode);
            static /*0x7e99cdc*/ void GetTemporaryRTWithDescriptor_Injected(nint _unity_self, int nameID, ref UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter);
            static /*0x7e99dc4*/ void ReleaseTemporaryRT_Injected(nint _unity_self, int nameID);
            static /*0x7e9a314*/ void SetGlobalFloat_Injected(nint _unity_self, int nameID, float value);
            static /*0x7e9a3d0*/ void SetGlobalInt_Injected(nint _unity_self, int nameID, int value);
            static /*0x7e9a48c*/ void SetGlobalInteger_Injected(nint _unity_self, int nameID, int value);
            static /*0x7e9a550*/ void SetGlobalVector_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector4 value);
            static /*0x7e9a614*/ void SetGlobalColor_Injected(nint _unity_self, int nameID, ref UnityEngine.Color value);
            static /*0x7e9a6d0*/ void SetGlobalMatrix_Injected(nint _unity_self, int nameID, ref UnityEngine.Matrix4x4 value);
            static /*0x7e9a8b4*/ void EnableShaderKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            static /*0x7e9a95c*/ void EnableGlobalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.GlobalKeyword keyword);
            static /*0x7e9aa50*/ void EnableMaterialKeyword_Injected(nint _unity_self, nint material, ref UnityEngine.Rendering.LocalKeyword keyword);
            static /*0x7e9ab54*/ void EnableComputeKeyword_Injected(nint _unity_self, nint computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            static /*0x7e9ad9c*/ void DisableShaderKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            static /*0x7e9ae44*/ void DisableGlobalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.GlobalKeyword keyword);
            static /*0x7e9af38*/ void DisableMaterialKeyword_Injected(nint _unity_self, nint material, ref UnityEngine.Rendering.LocalKeyword keyword);
            static /*0x7e9b03c*/ void DisableComputeKeyword_Injected(nint _unity_self, nint computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            static /*0x7e9b160*/ void SetGlobalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            static /*0x7e9b274*/ void SetMaterialKeyword_Injected(nint _unity_self, nint material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            static /*0x7e9b390*/ void SetComputeKeyword_Injected(nint _unity_self, nint computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            static /*0x7e9b4c8*/ void SetViewProjectionMatrices_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 view, ref UnityEngine.Matrix4x4 proj);
            static /*0x7e9b584*/ void SetGlobalDepthBias_Injected(nint _unity_self, float bias, float slopeBias);
            static /*0x7e9b630*/ void SetExecutionFlags_Injected(nint _unity_self, UnityEngine.Rendering.CommandBufferExecutionFlags flags);
            static /*0x7e9b674*/ bool ValidateAgainstExecutionFlags_Injected(nint _unity_self, UnityEngine.Rendering.CommandBufferExecutionFlags requiredFlags, UnityEngine.Rendering.CommandBufferExecutionFlags invalidFlags);
            static /*0x7e9b730*/ void SetGlobalFloatArrayListImpl_Injected(nint _unity_self, int nameID, object values);
            static /*0x7e9b7ec*/ void SetGlobalVectorArrayListImpl_Injected(nint _unity_self, int nameID, object values);
            static /*0x7e9b8a8*/ void SetGlobalMatrixArrayListImpl_Injected(nint _unity_self, int nameID, object values);
            static /*0x7e9ba24*/ void SetGlobalFloatArray_Injected(nint _unity_self, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7e9bba0*/ void SetGlobalVectorArray_Injected(nint _unity_self, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7e9bd1c*/ void SetGlobalMatrixArray_Injected(nint _unity_self, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7e9be88*/ void SetLateLatchProjectionMatrices_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper projectionMat);
            static /*0x7e9bf34*/ void MarkLateLatchMatrixShaderPropertyID_Injected(nint _unity_self, UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            static /*0x7e9bfe0*/ void UnmarkLateLatchMatrix_Injected(nint _unity_self, UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            static /*0x7e9c094*/ void SetGlobalTexture_Impl_Injected(nint _unity_self, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderTextureSubElement element);
            static /*0x7e9c160*/ void SetGlobalBufferInternal_Injected(nint _unity_self, int nameID, nint value);
            static /*0x7e9c224*/ void SetGlobalGraphicsBufferInternal_Injected(nint _unity_self, int nameID, nint value);
            static /*0x7e9c2e0*/ void SetShadowSamplingMode_Impl_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            static /*0x7e9c39c*/ void IssuePluginEventInternal_Injected(nint _unity_self, nint callback, int eventID);
            static /*0x7e9c580*/ void BeginSample_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            static /*0x7e9c754*/ void EndSample_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            static /*0x7e9c938*/ void BeginSample_CustomSampler_Injected(nint _unity_self, nint sampler);
            static /*0x7e9c97c*/ void EndSample_CustomSampler_Injected(nint _unity_self, nint sampler);
            static /*0x7e9ca30*/ void IssuePluginEventAndDataInternal_Injected(nint _unity_self, nint callback, int eventID, nint data);
            static /*0x7e9cb24*/ void IssuePluginCustomBlitInternal_Injected(nint _unity_self, nint callback, uint command, ref UnityEngine.Rendering.RenderTargetIdentifier source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            static /*0x7e9cc70*/ void IssuePluginCustomTextureUpdateInternal_Injected(nint _unity_self, nint callback, nint targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2);
            static /*0x7e9cd64*/ void SetGlobalConstantBufferInternal_Injected(nint _unity_self, nint buffer, int nameID, int offset, int size);
            static /*0x7e9ce58*/ void SetGlobalConstantGraphicsBufferInternal_Injected(nint _unity_self, nint buffer, int nameID, int offset, int size);
            static /*0x7e9cf1c*/ void IncrementUpdateCount_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier dest);
            static /*0x7e9cfb8*/ void SetInstanceMultiplier_Injected(nint _unity_self, uint multiplier);
            static /*0x7e9d054*/ void SetFoveatedRenderingMode_Injected(nint _unity_self, UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            static /*0x7e9d0f0*/ void SetWireframe_Injected(nint _unity_self, bool enable);
            static /*0x7e9d18c*/ void ConfigureFoveatedRendering_Injected(nint _unity_self, nint platformData);
            static /*0x7e9ecd4*/ void ClearRenderTargetSingle_Internal_Injected(nint _unity_self, UnityEngine.Rendering.RTClearFlags clearFlags, ref UnityEngine.Color color, float depth, uint stencil);
            static /*0x7e9ed40*/ void ClearRenderTargetMulti_Internal_Injected(nint _unity_self, UnityEngine.Rendering.RTClearFlags clearFlags, ref UnityEngine.Bindings.ManagedSpanWrapper colors, float depth, uint stencil);
            static /*0x7e9edac*/ void SetRenderTargetSingle_Internal_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            static /*0x7e9ee20*/ void SetRenderTargetColorDepth_Internal_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier color, ref UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags);
            static /*0x7e9eeac*/ void SetRenderTargetMulti_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, ref UnityEngine.Rendering.RenderTargetIdentifier depth, ref UnityEngine.Bindings.ManagedSpanWrapper colorLoadActions, ref UnityEngine.Bindings.ManagedSpanWrapper colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags);
            static /*0x7e9ef38*/ void SetRenderTargetColorDepthSubtarget_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier color, ref UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7e9efdc*/ void SetRenderTargetMultiSubtarget_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, ref UnityEngine.Rendering.RenderTargetIdentifier depth, ref UnityEngine.Bindings.ManagedSpanWrapper colorLoadActions, ref UnityEngine.Bindings.ManagedSpanWrapper colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7e9f6f8*/ void InternalSetComputeBufferNativeData_Injected(nint _unity_self, nint buffer, nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            static /*0x7e9f77c*/ void InternalSetComputeBufferData_Injected(nint _unity_self, nint buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            static /*0x7e9f800*/ void InternalSetComputeBufferCounterValue_Injected(nint _unity_self, nint buffer, uint counterValue);
            static /*0x7e9fecc*/ void InternalSetGraphicsBufferNativeData_Injected(nint _unity_self, nint buffer, nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            static /*0x7e9ff50*/ void InternalSetGraphicsBufferData_Injected(nint _unity_self, nint buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            static /*0x7e9ffd4*/ void InternalSetGraphicsBufferCounterValue_Injected(nint _unity_self, nint buffer, uint counterValue);
            static /*0x7ea01dc*/ void BeginRenderPass_Internal_Injected(nint _unity_self, int width, int height, int volumeDepth, int samples, ref UnityEngine.Bindings.ManagedSpanWrapper attachments, int depthAttachmentIndex, ref UnityEngine.Bindings.ManagedSpanWrapper subPasses, ref UnityEngine.Bindings.ManagedSpanWrapper debugNameUtf8);
            static /*0x7ea03c8*/ void NextSubPass_Internal_Injected(nint _unity_self);
            static /*0x7ea0474*/ void EndRenderPass_Internal_Injected(nint _unity_self);
            static /*0x7ea05a8*/ void SetupCameraProperties_Internal_Injected(nint _unity_self, nint camera);
            static /*0x7ea066c*/ void InvokeOnRenderObjectCallbacks_Internal_Injected(nint _unity_self);
            /*0x7ea07dc*/ CommandBuffer();
            /*0x380da4c*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.ComputeBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.ComputeBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x380da4c*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.GraphicsBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.GraphicsBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x380da4c*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3907c14*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3907c14*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3907c14*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x7e927f8*/ void Internal_RequestAsyncReadback_1(UnityEngine.ComputeBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7e92964*/ void Internal_RequestAsyncReadback_2(UnityEngine.ComputeBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7e92b00*/ void Internal_RequestAsyncReadback_3(UnityEngine.Texture src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7e92c78*/ void Internal_RequestAsyncReadback_4(UnityEngine.Texture src, int mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7e92e10*/ void Internal_RequestAsyncReadback_5(UnityEngine.Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7e92fb8*/ void Internal_RequestAsyncReadback_6(UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7e931cc*/ void Internal_RequestAsyncReadback_7(UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7e933f0*/ void Internal_RequestAsyncReadback_8(UnityEngine.GraphicsBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7e9355c*/ void Internal_RequestAsyncReadback_9(UnityEngine.GraphicsBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7e936f8*/ void SetInvertCulling(bool invertCulling);
            /*0x7e93794*/ void Internal_SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x7e93858*/ nint CreateGPUFence_Internal(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x7e93914*/ void WaitOnGPUFence_Internal(nint fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x7e939d0*/ void ReleaseBuffer();
            /*0x7e93a5c*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, int nameID, float val);
            /*0x7e93bb8*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, int nameID, int val);
            /*0x7e93d04*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4 val);
            /*0x7e93e60*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4[] values);
            /*0x7e9401c*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x7e94168*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7e94324*/ void Internal_SetComputeFloats(UnityEngine.ComputeShader computeShader, int nameID, float[] values);
            /*0x7e944e0*/ void Internal_SetComputeInts(UnityEngine.ComputeShader computeShader, int nameID, int[] values);
            /*0x7e9469c*/ void Internal_SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7e94838*/ void Internal_SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7e949ac*/ void Internal_SetComputeGraphicsBufferHandleParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7e94b1c*/ void Internal_SetComputeGraphicsBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7e94c90*/ void Internal_SetComputeConstantComputeBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7e94e14*/ void Internal_SetComputeConstantGraphicsBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7e94f98*/ void Internal_DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x7e95114*/ void Internal_DispatchComputeIndirect(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset);
            /*0x7e95288*/ void Internal_DispatchComputeIndirectGraphicsBuffer(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset);
            /*0x7e953fc*/ void Internal_SetRayTracingComputeBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7e95550*/ void Internal_SetRayTracingGraphicsBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7e956a4*/ void Internal_SetRayTracingGraphicsBufferHandleParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7e957f4*/ void Internal_SetRayTracingConstantComputeBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7e95978*/ void Internal_SetRayTracingConstantGraphicsBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7e95afc*/ void Internal_SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7e95c48*/ void Internal_SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float val);
            /*0x7e95da4*/ void Internal_SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int val);
            /*0x7e95ef0*/ void Internal_SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4 val);
            /*0x7e9604c*/ void Internal_SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4[] values);
            /*0x7e96208*/ void Internal_SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x7e96354*/ void Internal_SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7e96510*/ void Internal_SetRayTracingFloats(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float[] values);
            /*0x7e966cc*/ void Internal_SetRayTracingInts(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int[] values);
            /*0x7e96888*/ void Internal_BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure, UnityEngine.Rendering.RayTracingAccelerationStructure.BuildSettings buildSettings);
            /*0x7e969bc*/ void Internal_SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x7e96b58*/ void Internal_SetComputeRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x7e96d14*/ void Internal_DispatchRays(UnityEngine.Rendering.RayTracingShader rayTracingShader, string rayGenShaderName, uint width, uint height, uint depth, UnityEngine.Camera camera);
            /*0x7e96ffc*/ void CopyCounterValueCC(UnityEngine.ComputeBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7e970d8*/ void CopyCounterValueGC(UnityEngine.GraphicsBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7e971b4*/ void CopyCounterValueCG(UnityEngine.ComputeBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7e97290*/ void CopyCounterValueGG(UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7e9736c*/ string get_name();
            /*0x7e9748c*/ void set_name(string value);
            /*0x7e97660*/ int get_sizeInBytes();
            /*0x7e976ec*/ void Clear();
            /*0x7e97778*/ void Internal_DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7e97948*/ void Internal_DrawMultipleMeshes(UnityEngine.Matrix4x4[] matrices, UnityEngine.Mesh[] meshes, int[] subsetIndices, int count, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7e97bb0*/ void Internal_DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x7e97d48*/ void Internal_DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x7e97de4*/ void Internal_DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7e97f68*/ void Internal_DrawProceduralIndexed(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7e98114*/ void Internal_DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7e982a0*/ void Internal_DrawProceduralIndexedIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7e98454*/ void Internal_DrawProceduralIndirectGraphicsBuffer(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7e985e0*/ void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7e98794*/ void Internal_DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7e989c0*/ void Internal_DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7e98b58*/ void Internal_DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7e98d10*/ void Internal_DrawMeshInstancedIndirectGraphicsBuffer(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7e98ec8*/ void Internal_DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
            /*0x7e98f70*/ void SetRandomWriteTarget_Texture(int index, ref UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7e9902c*/ void SetRandomWriteTarget_GraphicsBuffer(int index, UnityEngine.GraphicsBuffer uav, bool preserveCounterValue);
            /*0x7e99100*/ void ClearRandomWriteTargets();
            /*0x7e9918c*/ void SetViewport(UnityEngine.Rect pixelRect);
            /*0x7e99238*/ void EnableScissorRect(UnityEngine.Rect scissor);
            /*0x7e992e4*/ void DisableScissorRect();
            /*0x7e99370*/ void CopyTexture_Internal(ref UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode);
            /*0x7e99548*/ void Blit_Texture(UnityEngine.Texture source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Material mat, int pass, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            /*0x7e9970c*/ void Blit_Identifier(ref UnityEngine.Rendering.RenderTargetIdentifier source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Material mat, int pass, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            /*0x7e998a4*/ void GetTemporaryRT(int nameID, int width, int height, UnityEngine.FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int antiAliasing, bool enableRandomWrite, UnityEngine.RenderTextureMemoryless memorylessMode, bool useDynamicScale, UnityEngine.Rendering.ShadowSamplingMode shadowSamplingMode);
            /*0x7e99a68*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, UnityEngine.RenderTextureMemoryless memorylessMode, bool useDynamicScale);
            /*0x7e99b78*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, UnityEngine.RenderTextureMemoryless memorylessMode);
            /*0x7e99bb0*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite);
            /*0x7e99be4*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing);
            /*0x7e99c10*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
            /*0x7e99c3c*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.RenderTextureFormat format);
            /*0x7e99c6c*/ void GetTemporaryRTWithDescriptor(int nameID, UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter);
            /*0x7e99d38*/ void GetTemporaryRT(int nameID, UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter);
            /*0x7e99d6c*/ void ReleaseTemporaryRT(int nameID);
            /*0x7e99e08*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
            /*0x7e99eb4*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
            /*0x7e99e1c*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x7e99fbc*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x7e9a034*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color[] backgroundColors, float depth, uint stencil);
            /*0x7e9a2ac*/ void SetGlobalFloat(int nameID, float value);
            /*0x7e9a368*/ void SetGlobalInt(int nameID, int value);
            /*0x7e9a424*/ void SetGlobalInteger(int nameID, int value);
            /*0x7e9a4e0*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            /*0x7e9a5a4*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x7e9a668*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x7e9a724*/ void EnableShaderKeyword(string keyword);
            /*0x7e9a8f8*/ void EnableGlobalKeyword(UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7e9a9a0*/ void EnableMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7e9aaa4*/ void EnableComputeKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7e9aba8*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7e9abb4*/ void EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7e9abe0*/ void EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7e9ac0c*/ void DisableShaderKeyword(string keyword);
            /*0x7e9ade0*/ void DisableGlobalKeyword(UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7e9ae88*/ void DisableMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7e9af8c*/ void DisableComputeKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7e9b090*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7e9b09c*/ void DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7e9b0c8*/ void DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7e9b0f4*/ void SetGlobalKeyword(UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7e9b1b4*/ void SetMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7e9b2d0*/ void SetComputeKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7e9b3ec*/ void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7e9b400*/ void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7e9b430*/ void SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7e9b460*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            /*0x7e9b51c*/ void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x7e9b5d8*/ void SetExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags flags);
            /*0x7e99ec4*/ bool ValidateAgainstExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags requiredFlags, UnityEngine.Rendering.CommandBufferExecutionFlags invalidFlags);
            /*0x7e9b6c8*/ void SetGlobalFloatArrayListImpl(int nameID, object values);
            /*0x7e9b784*/ void SetGlobalVectorArrayListImpl(int nameID, object values);
            /*0x7e9b840*/ void SetGlobalMatrixArrayListImpl(int nameID, object values);
            /*0x7e9b8fc*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x7e9ba78*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x7e9bbf4*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7e9bd70*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x7e9becc*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x7e9bf88*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x7e9c024*/ void SetGlobalTexture_Impl(int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7e9c0f0*/ void SetGlobalBufferInternal(int nameID, UnityEngine.ComputeBuffer value);
            /*0x7e9c1b4*/ void SetGlobalGraphicsBufferInternal(int nameID, UnityEngine.GraphicsBuffer value);
            /*0x7e9c278*/ void SetShadowSamplingMode_Impl(ref UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x7e9c334*/ void IssuePluginEventInternal(nint callback, int eventID);
            /*0x7e9c3f0*/ void BeginSample(string name);
            /*0x7e9c5c4*/ void EndSample(string name);
            /*0x7e9c798*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7e9c868*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7e9c79c*/ void BeginSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7e9c86c*/ void EndSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7e9c9c0*/ void IssuePluginEventAndDataInternal(nint callback, int eventID, nint data);
            /*0x7e9ca8c*/ void IssuePluginCustomBlitInternal(nint callback, uint command, ref UnityEngine.Rendering.RenderTargetIdentifier source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x7e9cba8*/ void IssuePluginCustomTextureUpdateInternal(nint callback, UnityEngine.Texture targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2);
            /*0x7e9ccdc*/ void SetGlobalConstantBufferInternal(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x7e9cdd0*/ void SetGlobalConstantGraphicsBufferInternal(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x7e9cec4*/ void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x7e9cf60*/ void SetInstanceMultiplier(uint multiplier);
            /*0x7e9cffc*/ void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            /*0x7e9d098*/ void SetWireframe(bool enable);
            /*0x7e9d134*/ void ConfigureFoveatedRendering(nint platformData);
            /*0x7e9d264*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7e9d350*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction);
            /*0x7e9d414*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x7e9d4f0*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x7e9d5dc*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x7e9d6d4*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7e9d800*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x7e9d920*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel);
            /*0x7e9da38*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x7e9db4c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7e9dc9c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x7e9dd94*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x7e9e11c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7e9e4d8*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7e9e944*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding);
            /*0x7e99f2c*/ void ClearRenderTargetSingle_Internal(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color color, float depth, uint stencil);
            /*0x7e9a194*/ void ClearRenderTargetMulti_Internal(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color[] colors, float depth, uint stencil);
            /*0x7e9d2c8*/ void SetRenderTargetSingle_Internal(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x7e9d880*/ void SetRenderTargetColorDepth_Internal(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags);
            /*0x7e9df04*/ void SetRenderTargetMulti_Internal(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags);
            /*0x7e9e88c*/ void SetRenderTargetColorDepthSubtarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7e9e2b0*/ void SetRenderTargetMultiSubtarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7e9f080*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data);
            /*0x380d93c*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x7e9f2cc*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x7e9f50c*/ void SetBufferCounterValue(UnityEngine.ComputeBuffer buffer, uint counterValue);
            /*0x7e9f5ec*/ void InternalSetComputeBufferNativeData(UnityEngine.ComputeBuffer buffer, nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            /*0x7e9f1c0*/ void InternalSetComputeBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            /*0x7e9f510*/ void InternalSetComputeBufferCounterValue(UnityEngine.ComputeBuffer buffer, uint counterValue);
            /*0x7e9f854*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data);
            /*0x380d93c*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x7e9faa0*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3907c14*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x7e9fce0*/ void SetBufferCounterValue(UnityEngine.GraphicsBuffer buffer, uint counterValue);
            /*0x7e9fdc0*/ void InternalSetGraphicsBufferNativeData(UnityEngine.GraphicsBuffer buffer, nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            /*0x7e9f994*/ void InternalSetGraphicsBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            /*0x7e9fce4*/ void InternalSetGraphicsBufferCounterValue(UnityEngine.GraphicsBuffer buffer, uint counterValue);
            /*0x7ea0028*/ void BeginRenderPass_Internal(int width, int height, int volumeDepth, int samples, System.ReadOnlySpan<UnityEngine.Rendering.AttachmentDescriptor> attachments, int depthAttachmentIndex, System.ReadOnlySpan<UnityEngine.Rendering.SubPassDescriptor> subPasses, System.ReadOnlySpan<byte> debugNameUtf8);
            /*0x7ea0278*/ void BeginRenderPass(int width, int height, int volumeDepth, int samples, Unity.Collections.NativeArray<UnityEngine.Rendering.AttachmentDescriptor> attachments, int depthAttachmentIndex, Unity.Collections.NativeArray<UnityEngine.Rendering.SubPassDescriptor> subPasses, System.ReadOnlySpan<byte> debugNameUtf8);
            /*0x7ea0378*/ void NextSubPass_Internal();
            /*0x7ea0404*/ void NextSubPass();
            /*0x7ea0424*/ void EndRenderPass_Internal();
            /*0x7ea04b0*/ void EndRenderPass();
            /*0x7ea04d0*/ void SetupCameraProperties_Internal(UnityEngine.Camera camera);
            /*0x7ea05ec*/ void SetupCameraProperties(UnityEngine.Camera camera);
            /*0x7ea061c*/ void InvokeOnRenderObjectCallbacks_Internal();
            /*0x7ea06a8*/ void InvokeOnRenderObjectCallbacks();
            /*0x7ea06c8*/ void Finalize();
            /*0x7ea0778*/ void Dispose();
            /*0x7ea0760*/ void Dispose(bool disposing);
            /*0x7ea0824*/ void Release();
            /*0x7ea0828*/ UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence();
            /*0x7ea0834*/ UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x7ea086c*/ void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence);
            /*0x7ea0874*/ void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStage stage);
            /*0x7ea0884*/ void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x7ea0968*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, string name, float val);
            /*0x7ea09ac*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, string name, int val);
            /*0x7ea09e8*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4 val);
            /*0x7ea0a4c*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4[] values);
            /*0x7ea0a88*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4 val);
            /*0x7ea0ae0*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x7ea0b1c*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, string name, float[] values);
            /*0x7ea0b58*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, int nameID, float[] values);
            /*0x7ea0b5c*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, string name, int[] values);
            /*0x7ea0b98*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, int nameID, int[] values);
            /*0x7ea0b9c*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7ea0bf0*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7ea0bfc*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x7ea0c54*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x7ea0c5c*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7ea0cc0*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7ea0cc4*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7ea0cc8*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.ComputeBuffer buffer);
            /*0x7ea0d14*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7ea0d1c*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7ea0d68*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7ea0d6c*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x7ea0db8*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7ea0dbc*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7ea0e10*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7ea0e14*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7ea0e68*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x7ea0e6c*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset);
            /*0x7ea0f14*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset);
            /*0x7ea0fbc*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x7ea1020*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure, UnityEngine.Vector3 relativeOrigin);
            /*0x7ea1098*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7ea10d4*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7ea10d8*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7ea1124*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7ea1128*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer);
            /*0x7ea1164*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7ea1168*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x7ea11a4*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7ea11a8*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7ea11e4*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7ea11ec*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7ea11f0*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7ea1244*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7ea1248*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7ea129c*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7ea12d8*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7ea12dc*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float val);
            /*0x7ea1320*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float val);
            /*0x7ea1324*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float[] values);
            /*0x7ea1360*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float[] values);
            /*0x7ea1364*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int val);
            /*0x7ea13a0*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int val);
            /*0x7ea13a4*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int[] values);
            /*0x7ea13e0*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int[] values);
            /*0x7ea13e4*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4 val);
            /*0x7ea1448*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4 val);
            /*0x7ea144c*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4[] values);
            /*0x7ea1488*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4[] values);
            /*0x7ea148c*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4 val);
            /*0x7ea14e4*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x7ea1510*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x7ea154c*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7ea1550*/ void DispatchRays(UnityEngine.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, UnityEngine.Camera camera);
            /*0x7ea1554*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7ea178c*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x7ea17bc*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex);
            /*0x7ea17f0*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material);
            /*0x7ea1828*/ void DrawMultipleMeshes(UnityEngine.Matrix4x4[] matrices, UnityEngine.Mesh[] meshes, int[] subsetIndices, int count, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7ea18d0*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x7ea1a90*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex);
            /*0x7ea1a98*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material);
            /*0x7ea1aa4*/ void DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x7ea1ad0*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7ea1c04*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount);
            /*0x7ea1c34*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount);
            /*0x7ea1c68*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7ea1db0*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount);
            /*0x7ea1de0*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount);
            /*0x7ea1e14*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7ea1fa4*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7ea1fd4*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7ea2008*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7ea21b4*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7ea21e4*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7ea2218*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7ea23a8*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7ea23d8*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7ea240c*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7ea25b8*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7ea25e8*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7ea261c*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7ea29a0*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count);
            /*0x7ea29bc*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices);
            /*0x7ea29e4*/ void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7ea2c14*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7ea2e50*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7ea2e6c*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7ea2e8c*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7ea30c8*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7ea30e4*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7ea3104*/ void DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
            /*0x7ea3108*/ void SetRandomWriteTarget(int index, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7ea3140*/ void SetRandomWriteTarget(int index, UnityEngine.GraphicsBuffer buffer, bool preserveCounterValue);
            /*0x7ea3188*/ void SetRandomWriteTarget(int index, UnityEngine.GraphicsBuffer buffer);
            /*0x7ea31c4*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7ea31c8*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7ea31cc*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7ea31d0*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7ea31d4*/ void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier src, UnityEngine.Rendering.RenderTargetIdentifier dst);
            /*0x7ea3228*/ void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, int srcMip, UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement, int dstMip);
            /*0x7ea3274*/ void Blit(UnityEngine.Texture source, UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x7ea32d4*/ void Blit(UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x7ea3334*/ void Blit(UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Material mat, int pass);
            /*0x7ea33a4*/ void SetGlobalFloat(string name, float value);
            /*0x7ea33d8*/ void SetGlobalInt(string name, int value);
            /*0x7ea340c*/ void SetGlobalInteger(string name, int value);
            /*0x7ea3440*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
            /*0x7ea3494*/ void SetGlobalColor(string name, UnityEngine.Color value);
            /*0x7ea34e8*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x7ea3538*/ void SetGlobalFloatArray(string propertyName, System.Collections.Generic.List<float> values);
            /*0x7ea356c*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
            /*0x7ea3648*/ void SetGlobalFloatArray(string propertyName, float[] values);
            /*0x7ea367c*/ void SetGlobalVectorArray(string propertyName, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7ea36b0*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7ea378c*/ void SetGlobalVectorArray(string propertyName, UnityEngine.Vector4[] values);
            /*0x7ea37c0*/ void SetGlobalMatrixArray(string propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7ea37f4*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7ea38d0*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x7ea3904*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderTargetIdentifier value);
            /*0x7ea395c*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderTargetIdentifier value);
            /*0x7ea3964*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderTargetIdentifier value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7ea3958*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderTargetIdentifier value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7ea39bc*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
            /*0x7ea39f0*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x7ea39f4*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
            /*0x7ea3a28*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
            /*0x7ea3a2c*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x7ea3a30*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, string name, int offset, int size);
            /*0x7ea3a7c*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x7ea3a80*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x7ea3acc*/ void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x7ea3b04*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x7ea3b08*/ void IssuePluginEvent(nint callback, int eventID);
            /*0x7ea3b5c*/ void IssuePluginEventAndData(nint callback, int eventID, nint data);
            /*0x7ea3bf0*/ void IssuePluginCustomBlit(nint callback, uint command, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x7ea3c58*/ void IssuePluginCustomTextureUpdateV2(nint callback, UnityEngine.Texture targetTexture, uint userData);

            class BindingsMarshaller
            {
                static /*0x7ea3ca4*/ nint ConvertToNative(UnityEngine.Rendering.CommandBuffer commandBuffer);
            }
        }

        class CommandBufferExtensions
        {
            static /*0x7ea3cbc*/ void Internal_SwitchIntoFastMemory(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.FastMemoryFlags fastMemoryFlags, float residency, bool copyContents);
            static /*0x7ea3df4*/ void Internal_SwitchOutOfFastMemory(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.RenderTargetIdentifier rt, bool copyContents);
            static /*0x7ea3efc*/ void SwitchIntoFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rid, UnityEngine.Rendering.FastMemoryFlags fastMemoryFlags, float residency, bool copyContents);
            static /*0x7ea3f04*/ void SwitchOutOfFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rid, bool copyContents);
            static /*0x7ea3d88*/ void Internal_SwitchIntoFastMemory_Injected(nint cmd, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.FastMemoryFlags fastMemoryFlags, float residency, bool copyContents);
            static /*0x7ea3ea8*/ void Internal_SwitchOutOfFastMemory_Injected(nint cmd, ref UnityEngine.Rendering.RenderTargetIdentifier rt, bool copyContents);
        }

        class SupportedOnRenderPipelineAttribute : System.Attribute
        {
            static /*0x0*/ System.Lazy<System.Type[]> k_DefaultRenderPipelineAsset;
            /*0x10*/ System.Type[] <renderPipelineTypes>k__BackingField;

            static /*0x7ea44f8*/ SupportedOnRenderPipelineAttribute();
            static /*0x7ea4324*/ UnityEngine.Rendering.SupportedOnRenderPipelineAttribute.SupportedMode GetSupportedMode(System.Type[] renderPipelineTypes, System.Type renderPipelineAssetType);
            static /*0x7ea4484*/ bool IsTypeSupportedOnRenderPipeline(System.Type type, System.Type renderPipelineAssetType);
            /*0x7ea3f14*/ SupportedOnRenderPipelineAttribute(System.Type renderPipeline);
            /*0x7ea3fc0*/ SupportedOnRenderPipelineAttribute(System.Type[] renderPipeline);
            /*0x7ea3f0c*/ System.Type[] get_renderPipelineTypes();
            /*0x7ea42bc*/ UnityEngine.Rendering.SupportedOnRenderPipelineAttribute.SupportedMode GetSupportedMode(System.Type renderPipelineAssetType);

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

                static /*0x7ea4610*/ <>c();
                /*0x7ea4678*/ <>c();
                /*0x7ea4680*/ string <.ctor>b__6_0(System.Type t);
                /*0x7ea46a4*/ System.Type[] <.cctor>b__12_0();
            }
        }

        class Watermark
        {
            static /*0x7ea4780*/ bool IsVisible();
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

            static /*0x7ea4d14*/ bool op_Equality(UnityEngine.Rendering.SphericalHarmonicsL2 lhs, UnityEngine.Rendering.SphericalHarmonicsL2 rhs);
            static /*0x7ea4ed0*/ bool op_Inequality(UnityEngine.Rendering.SphericalHarmonicsL2 lhs, UnityEngine.Rendering.SphericalHarmonicsL2 rhs);
            /*0x7ea47a8*/ float get_Item(int rgb, int coefficient);
            /*0x7ea48f4*/ void set_Item(int rgb, int coefficient, float value);
            /*0x7ea4a40*/ int GetHashCode();
            /*0x7ea4c14*/ bool Equals(object other);
            /*0x7ea4ccc*/ bool Equals(UnityEngine.Rendering.SphericalHarmonicsL2 other);
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

            static /*0x7ea5358*/ bool op_Inequality(UnityEngine.Rendering.AttachmentDescriptor left, UnityEngine.Rendering.AttachmentDescriptor right);
            /*0x7ea5020*/ AttachmentDescriptor(UnityEngine.Experimental.Rendering.GraphicsFormat format);
            /*0x7ea4f1c*/ void set_loadAction(UnityEngine.Rendering.RenderBufferLoadAction value);
            /*0x7ea4f24*/ void set_storeAction(UnityEngine.Rendering.RenderBufferStoreAction value);
            /*0x7ea4f2c*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
            /*0x7ea4f34*/ UnityEngine.Rendering.RenderTargetIdentifier get_loadStoreTarget();
            /*0x7ea4f48*/ void set_loadStoreTarget(UnityEngine.Rendering.RenderTargetIdentifier value);
            /*0x7ea4f5c*/ void set_resolveTarget(UnityEngine.Rendering.RenderTargetIdentifier value);
            /*0x7ea4f74*/ void set_clearColor(UnityEngine.Color value);
            /*0x7ea4f80*/ void set_clearDepth(float value);
            /*0x7ea4f88*/ void set_clearStencil(uint value);
            /*0x7ea4f90*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier target, bool loadExistingContents, bool storeResults);
            /*0x7ea4fd4*/ void ConfigureResolveTarget(UnityEngine.Rendering.RenderTargetIdentifier target);
            /*0x7ea5004*/ void ConfigureClear(UnityEngine.Color clearColor, float clearDepth, uint clearStencil);
            /*0x7ea5070*/ bool Equals(UnityEngine.Rendering.AttachmentDescriptor other);
            /*0x7ea51d0*/ bool Equals(object obj);
            /*0x7ea5260*/ int GetHashCode();
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

            static /*0x7ea55ac*/ AttachmentIndexArray();
            /*0x7ea5390*/ AttachmentIndexArray(int numAttachments);
            /*0x7ea542c*/ int get_Item(int index);
            /*0x7ea54e8*/ void set_Item(int index, int value);
            /*0x7ea55a4*/ int get_Length();
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

            static /*0x7ea55fc*/ UnityEngine.Rendering.BlendState get_defaultValue();
            /*0x7ea5660*/ BlendState(bool separateMRTBlend, bool alphaToMask);
            /*0x7ea5744*/ void set_blendState0(UnityEngine.Rendering.RenderTargetBlendState value);
            /*0x7ea574c*/ bool Equals(UnityEngine.Rendering.BlendState other);
            /*0x7ea582c*/ bool Equals(object obj);
            /*0x7ea58bc*/ int GetHashCode();
        }

        struct CoreCameraValues : System.IEquatable<UnityEngine.Rendering.CoreCameraValues>
        {
            /*0x10*/ int filterMode;
            /*0x14*/ uint cullingMask;
            /*0x18*/ int instanceID;

            /*0x7ea5998*/ bool Equals(UnityEngine.Rendering.CoreCameraValues other);
            /*0x7ea59cc*/ bool Equals(object obj);
            /*0x7ea5a64*/ int GetHashCode();
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

            /*0x7ea5a84*/ UnityEngine.Plane GetShadowCullingPlane(int index);
            /*0x7ea5b60*/ UnityEngine.Plane GetCameraCullingPlane(int index);
            /*0x7ea5c3c*/ bool Equals(UnityEngine.Rendering.CameraProperties other);
            /*0x7ea62a4*/ bool Equals(object obj);
            /*0x7ea635c*/ int GetHashCode();

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

            static /*0x7ea7160*/ ScriptableCullingParameters();
            /*0x7ea67b4*/ void set_maximumVisibleLights(int value);
            /*0x7ea67bc*/ void set_conservativeEnclosingSphere(bool value);
            /*0x7ea67c8*/ void set_numIterationsEnclosingSphere(int value);
            /*0x7ea67d0*/ int get_cullingPlaneCount();
            /*0x7ea67d8*/ void set_shadowDistance(float value);
            /*0x7ea67e0*/ UnityEngine.Rendering.CullingOptions get_cullingOptions();
            /*0x7ea67e8*/ void set_cullingOptions(UnityEngine.Rendering.CullingOptions value);
            /*0x7ea67f0*/ void set_reflectionProbeSortingCriteria(UnityEngine.Rendering.ReflectionProbeSortingCriteria value);
            /*0x7ea67f8*/ void set_stereoViewMatrix(UnityEngine.Matrix4x4 value);
            /*0x7ea6810*/ UnityEngine.Matrix4x4 get_stereoProjectionMatrix();
            /*0x7ea6828*/ void set_stereoProjectionMatrix(UnityEngine.Matrix4x4 value);
            /*0x7ea6840*/ void set_stereoSeparationDistance(float value);
            /*0x7ea6848*/ float GetLayerCullingDistance(int layerIndex);
            /*0x7ea6918*/ UnityEngine.Plane GetCullingPlane(int index);
            /*0x7ea6a44*/ bool Equals(UnityEngine.Rendering.ScriptableCullingParameters other);
            /*0x7ea6e28*/ bool Equals(object obj);
            /*0x7ea6f10*/ int GetHashCode();

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

            static /*0x7ea71b0*/ int GetLightIndexCount(nint cullingResultsPtr);
            static /*0x7ea71ec*/ int GetReflectionProbeIndexCount(nint cullingResultsPtr);
            static /*0x7ea7228*/ void FillLightAndReflectionProbeIndices(nint cullingResultsPtr, UnityEngine.ComputeBuffer computeBuffer);
            static /*0x7ea72bc*/ int GetLightIndexMapSize(nint cullingResultsPtr);
            static /*0x7ea72f8*/ void FillLightIndexMap(nint cullingResultsPtr, nint indexMapPtr, int indexMapSize);
            static /*0x7ea734c*/ void SetLightIndexMap(nint cullingResultsPtr, nint indexMapPtr, int indexMapSize);
            static /*0x7ea73a0*/ bool GetShadowCasterBounds(nint cullingResultsPtr, int lightIndex, ref UnityEngine.Bounds bounds);
            static /*0x7ea73f4*/ bool ComputeSpotShadowMatricesAndCullingPrimitives(nint cullingResultsPtr, int activeLightIndex, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            static /*0x7ea7460*/ bool ComputePointShadowMatricesAndCullingPrimitives(nint cullingResultsPtr, int activeLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            static /*0x7ea74e4*/ bool ComputeDirectionalShadowMatricesAndCullingPrimitives(nint cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, UnityEngine.Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            static /*0x7ea7bb8*/ bool op_Equality(UnityEngine.Rendering.CullingResults left, UnityEngine.Rendering.CullingResults right);
            static /*0x7ea7278*/ void FillLightAndReflectionProbeIndices_Injected(nint cullingResultsPtr, nint computeBuffer);
            static /*0x7ea759c*/ bool ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(nint cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, ref UnityEngine.Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x7ea7648*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> get_visibleLights();
            /*0x7ea76a4*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleReflectionProbe> get_visibleReflectionProbes();
            /*0x3907c14*/ Unity.Collections.NativeArray<T> GetNativeArray<T>(void* dataPointer, int length);
            /*0x7ea7700*/ int get_lightAndReflectionProbeIndexCount();
            /*0x7ea7778*/ void FillLightAndReflectionProbeIndices(UnityEngine.ComputeBuffer computeBuffer);
            /*0x7ea77c8*/ Unity.Collections.NativeArray<int> GetLightIndexMap(Unity.Collections.Allocator allocator);
            /*0x7ea78d4*/ void SetLightIndexMap(Unity.Collections.NativeArray<int> lightIndexMap);
            /*0x7ea7970*/ bool GetShadowCasterBounds(int lightIndex, ref UnityEngine.Bounds outBounds);
            /*0x7ea79c4*/ bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x7ea7a30*/ bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x7ea7ab4*/ bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, UnityEngine.Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x7ea7abc*/ bool Equals(UnityEngine.Rendering.CullingResults other);
            /*0x7ea7b18*/ bool Equals(object obj);
            /*0x7ea7b90*/ int GetHashCode();
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

            static /*0x7ea7be4*/ UnityEngine.Rendering.DepthState get_defaultValue();
            /*0x7ea7c08*/ DepthState(bool writeEnabled, UnityEngine.Rendering.CompareFunction compareFunction);
            /*0x7ea7c7c*/ UnityEngine.Rendering.CompareFunction get_compareFunction();
            /*0x7ea7c84*/ bool Equals(UnityEngine.Rendering.DepthState other);
            /*0x7ea7cac*/ bool Equals(object obj);
            /*0x7ea7d34*/ int GetHashCode();
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

            static /*0x7ea8638*/ DrawingSettings();
            static /*0x7ea857c*/ bool op_Equality(UnityEngine.Rendering.DrawingSettings left, UnityEngine.Rendering.DrawingSettings right);
            /*0x7ea7d70*/ DrawingSettings(UnityEngine.Rendering.ShaderTagId shaderPassName, UnityEngine.Rendering.SortingSettings sortingSettings);
            /*0x7ea7e34*/ void set_perObjectData(UnityEngine.Rendering.PerObjectData value);
            /*0x7ea7e3c*/ void set_enableDynamicBatching(bool value);
            /*0x7ea7e4c*/ void set_enableInstancing(bool value);
            /*0x7ea7e6c*/ void set_overrideMaterial(UnityEngine.Material value);
            /*0x7ea7e98*/ void set_overrideShader(UnityEngine.Shader value);
            /*0x7ea7ec4*/ void set_overrideMaterialPassIndex(int value);
            /*0x7ea7ecc*/ void set_overrideShaderPassIndex(int value);
            /*0x7ea7ed4*/ void set_mainLightIndex(int value);
            /*0x7ea7edc*/ UnityEngine.Rendering.ShaderTagId GetShaderPassName(int index);
            /*0x7ea8020*/ void SetShaderPassName(int index, UnityEngine.Rendering.ShaderTagId shaderPassName);
            /*0x7ea8168*/ bool Equals(UnityEngine.Rendering.DrawingSettings other);
            /*0x7ea8380*/ bool Equals(object obj);
            /*0x7ea8468*/ int GetHashCode();

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

            static /*0x7ea89c4*/ bool op_Equality(UnityEngine.Rendering.FilteringSettings left, UnityEngine.Rendering.FilteringSettings right);
            /*0x7ea8684*/ FilteringSettings(System.Nullable<UnityEngine.Rendering.RenderQueueRange> renderQueueRange, int layerMask, uint renderingLayerMask, int excludeMotionVectorObjects);
            /*0x7ea8770*/ UnityEngine.Rendering.RenderQueueRange get_renderQueueRange();
            /*0x7ea8778*/ void set_batchLayerMask(uint value);
            /*0x7ea8780*/ void set_excludeMotionVectorObjects(bool value);
            /*0x7ea878c*/ void set_forceAllMotionVectorObjects(bool value);
            /*0x7ea8798*/ bool Equals(UnityEngine.Rendering.FilteringSettings other);
            /*0x7ea8894*/ bool Equals(object obj);
            /*0x7ea891c*/ int GetHashCode();
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

            /*0x7ea89ec*/ bool get_isOrthographic();
            /*0x7ea8a48*/ UnityEngine.Vector3 get_cameraPosition();
            /*0x7ea8a54*/ float get_fieldOfView();
            /*0x7ea8a5c*/ float get_orthoSize();
            /*0x7ea8a64*/ bool Equals(UnityEngine.Rendering.LODParameters other);
            /*0x7ea8b00*/ bool Equals(object obj);
            /*0x7ea8b90*/ int GetHashCode();
        }

        class ObjectIdRequest
        {
            /*0x10*/ UnityEngine.RenderTexture <destination>k__BackingField;

            /*0x7ea8c24*/ UnityEngine.RenderTexture get_destination();
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

            static /*0x7ea8e4c*/ RasterState();
            /*0x7ea8c2c*/ RasterState(UnityEngine.Rendering.CullMode cullingMode, int offsetUnits, float offsetFactor, bool depthClip);
            /*0x7ea8cd0*/ bool Equals(UnityEngine.Rendering.RasterState other);
            /*0x7ea8d44*/ bool Equals(object obj);
            /*0x7ea8dec*/ int GetHashCode();
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

            static /*0x7ea8ebc*/ void BeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x7ea9014*/ void BeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            static /*0x7ea9108*/ void EndContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x7ea9260*/ void EndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            /*0x7ea94e4*/ RenderPipeline();
            void Render(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera[] cameras);
            /*0x3907c14*/ void ProcessRenderRequests<RequestData>(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, RequestData renderRequest);
            /*0x3907c14*/ bool IsRenderRequestSupported<RequestData>(UnityEngine.Camera camera, RequestData data);
            /*0x7ea9354*/ void Render(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x7ea93cc*/ void InternalRender(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x3907c14*/ void InternalProcessRenderRequests<RequestData>(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, RequestData renderRequest);
            /*0x7ea944c*/ bool get_disposed();
            /*0x7ea9454*/ void set_disposed(bool value);
            /*0x7ea9460*/ void Dispose();
            /*0x7ea94d8*/ void Dispose(bool disposing);
            /*0x7ea94dc*/ UnityEngine.Rendering.RenderPipelineGlobalSettings get_defaultSettings();

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
            /*0x7ea9b2c*/ RenderPipelineAsset();
            /*0x7ea94ec*/ UnityEngine.Rendering.RenderPipeline InternalCreatePipeline();
            /*0x7ea95c8*/ UnityEngine.Material get_defaultMaterial();
            /*0x7ea95d0*/ UnityEngine.Shader get_autodeskInteractiveShader();
            /*0x7ea95d8*/ UnityEngine.Shader get_autodeskInteractiveTransparentShader();
            /*0x7ea95e0*/ UnityEngine.Shader get_autodeskInteractiveMaskedShader();
            /*0x7ea95e8*/ UnityEngine.Shader get_terrainDetailLitShader();
            /*0x7ea95f0*/ UnityEngine.Shader get_terrainDetailGrassShader();
            /*0x7ea95f8*/ UnityEngine.Shader get_terrainDetailGrassBillboardShader();
            /*0x7ea9600*/ UnityEngine.Material get_defaultParticleMaterial();
            /*0x7ea9608*/ UnityEngine.Material get_defaultLineMaterial();
            /*0x7ea9610*/ UnityEngine.Material get_defaultTerrainMaterial();
            /*0x7ea9618*/ UnityEngine.Material get_defaultUIMaterial();
            /*0x7ea9620*/ UnityEngine.Material get_defaultUIOverdrawMaterial();
            /*0x7ea9628*/ UnityEngine.Material get_defaultUIETC1SupportedMaterial();
            /*0x7ea9630*/ UnityEngine.Material get_default2DMaterial();
            /*0x7ea9638*/ UnityEngine.Material get_default2DMaskMaterial();
            /*0x7ea9640*/ UnityEngine.Shader get_defaultShader();
            /*0x7ea9648*/ UnityEngine.Shader get_defaultSpeedTree7Shader();
            /*0x7ea9650*/ UnityEngine.Shader get_defaultSpeedTree8Shader();
            /*0x7ea9658*/ UnityEngine.Shader get_defaultSpeedTree9Shader();
            /*0x7ea9660*/ string get_renderPipelineShaderTag();
            /*0x380b9e8*/ UnityEngine.Rendering.RenderPipeline CreatePipeline();
            /*0x7ea96e0*/ System.Type get_pipelineType();
            /*0x7ea9750*/ string get_pipelineTypeFullName();
            /*0x7ea9798*/ void EnsureGlobalSettings();
            /*0x7ea979c*/ void OnValidate();
            /*0x7ea98a8*/ void OnDisable();
            /*0x7ea9aac*/ System.Type get_renderPipelineType();
            /*0x7ea9b1c*/ string[] get_renderingLayerMaskNames();
            /*0x7ea9b24*/ string[] get_prefixedRenderingLayerMaskNames();
        }

        class RenderPipelineAsset<TRenderPipeline> : UnityEngine.Rendering.RenderPipelineAsset
        {
            /*0x380cb08*/ RenderPipelineAsset();
            /*0x380b9e8*/ System.Type get_pipelineType();
            /*0x380b9e8*/ string get_renderPipelineShaderTag();
            /*0x380b9e8*/ System.Type get_renderPipelineType();
        }

        class RenderPipelineGlobalSettings : UnityEngine.ScriptableObject, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x18*/ System.Collections.Generic.Dictionary<System.Type, int> <settingsMap>k__BackingField;

            /*0x7eaa020*/ RenderPipelineGlobalSettings();
            /*0x7ea9b34*/ System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> get_settingsList();
            /*0x7ea9d80*/ System.Collections.Generic.Dictionary<System.Type, int> get_settingsMap();
            /*0x7ea9d88*/ void RecreateSettingsMap();
            /*0x7ea9eb0*/ bool TryGet(System.Type type, ref UnityEngine.Rendering.IRenderPipelineGraphicsSettings settings);
            /*0x380b2f0*/ bool TryGetFirstSettingsImplementingInterface<TSettingsInterfaceType>(ref TSettingsInterfaceType settings);
            /*0x380b2f0*/ bool GetSettingsImplementingInterface<TSettingsInterfaceType>(ref System.Collections.Generic.List<TSettingsInterfaceType> settings);
            /*0x7ea9fa0*/ bool Contains(System.Type type);
            /*0x7eaa018*/ void OnBeforeSerialize();
            /*0x7eaa01c*/ void OnAfterDeserialize();
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

            static /*0x7eab33c*/ RenderPipelineManager();
            static /*0x7eaa0a8*/ UnityEngine.Rendering.RenderPipeline get_currentPipeline();
            static /*0x7eaa100*/ void set_currentPipeline(UnityEngine.Rendering.RenderPipeline value);
            static /*0x7eaa1b8*/ void add_beginContextRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> value);
            static /*0x7eaa2ac*/ void remove_beginContextRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> value);
            static /*0x7eaa3a0*/ void add_endContextRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> value);
            static /*0x7eaa494*/ void remove_endContextRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> value);
            static /*0x7eaa588*/ void add_beginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x7eaa67c*/ void remove_beginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x7eaa770*/ void add_endCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x7eaa864*/ void remove_endCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x7ea8f20*/ void BeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x7ea9078*/ void BeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            static /*0x7ea916c*/ void EndContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x7ea92c4*/ void EndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            static /*0x7eaa958*/ void OnActiveRenderPipelineTypeChanged();
            static /*0x7eaa9cc*/ void OnActiveRenderPipelineAssetChanged(UnityEngine.ScriptableObject from, UnityEngine.ScriptableObject to);
            static /*0x7eaaad8*/ void HandleRenderPipelineChange(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset);
            static /*0x7ea97f0*/ void RecreateCurrentPipeline(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset);
            static /*0x7ea98f4*/ void CleanupRenderPipeline();
            static /*0x7eaac7c*/ string GetCurrentPipelineAssetType();
            static /*0x7eaacd4*/ void DoRenderLoop_Internal(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset, nint loopPtr, UnityEngine.Object renderRequest);
            static /*0x7eaafe4*/ bool TryPrepareRenderPipeline(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset);
            static /*0x7eaab74*/ bool get_isCurrentPipelineValid();
            static /*0x7eab1f0*/ bool IsPipelineRequireCreation();
        }

        struct RenderQueueRange : System.IEquatable<UnityEngine.Rendering.RenderQueueRange>
        {
            static int k_MinimumBound = 0;
            static int k_MaximumBound = 5000;
            static /*0x0*/ int minimumBound;
            static /*0x4*/ int maximumBound;
            /*0x10*/ int m_LowerBound;
            /*0x14*/ int m_UpperBound;

            static /*0x7eab508*/ RenderQueueRange();
            static /*0x7ea8760*/ UnityEngine.Rendering.RenderQueueRange get_all();
            static /*0x7eab3b4*/ UnityEngine.Rendering.RenderQueueRange get_opaque();
            static /*0x7eab3bc*/ UnityEngine.Rendering.RenderQueueRange get_transparent();
            static /*0x7eab490*/ bool op_Equality(UnityEngine.Rendering.RenderQueueRange left, UnityEngine.Rendering.RenderQueueRange right);
            /*0x7eab3c8*/ int get_lowerBound();
            /*0x7eab3d0*/ int get_upperBound();
            /*0x7ea886c*/ bool Equals(UnityEngine.Rendering.RenderQueueRange other);
            /*0x7eab3d8*/ bool Equals(object obj);
            /*0x7ea89b0*/ int GetHashCode();
        }

        struct RenderStateBlock : System.IEquatable<UnityEngine.Rendering.RenderStateBlock>
        {
            /*0x10*/ UnityEngine.Rendering.BlendState m_BlendState;
            /*0x54*/ UnityEngine.Rendering.RasterState m_RasterState;
            /*0x64*/ UnityEngine.Rendering.DepthState m_DepthState;
            /*0x66*/ UnityEngine.Rendering.StencilState m_StencilState;
            /*0x74*/ int m_StencilReference;
            /*0x78*/ UnityEngine.Rendering.RenderStateMask m_Mask;

            /*0x7eab558*/ RenderStateBlock(UnityEngine.Rendering.RenderStateMask mask);
            /*0x7eab680*/ void set_blendState(UnityEngine.Rendering.BlendState value);
            /*0x7eab694*/ void set_rasterState(UnityEngine.Rendering.RasterState value);
            /*0x7eab6a0*/ UnityEngine.Rendering.DepthState get_depthState();
            /*0x7eab6a8*/ void set_depthState(UnityEngine.Rendering.DepthState value);
            /*0x7eab6b0*/ UnityEngine.Rendering.StencilState get_stencilState();
            /*0x7eab6c0*/ void set_stencilState(UnityEngine.Rendering.StencilState value);
            /*0x7eab6cc*/ int get_stencilReference();
            /*0x7eab6d4*/ void set_stencilReference(int value);
            /*0x7eab6dc*/ UnityEngine.Rendering.RenderStateMask get_mask();
            /*0x7eab6e4*/ void set_mask(UnityEngine.Rendering.RenderStateMask value);
            /*0x7eab6ec*/ bool Equals(UnityEngine.Rendering.RenderStateBlock other);
            /*0x7eab8a0*/ bool Equals(object obj);
            /*0x7eab930*/ int GetHashCode();
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

            static /*0x7eabaf0*/ UnityEngine.Rendering.RenderTargetBlendState get_defaultValue();
            /*0x7eabafc*/ RenderTargetBlendState(UnityEngine.Rendering.ColorWriteMask writeMask, UnityEngine.Rendering.BlendMode sourceColorBlendMode, UnityEngine.Rendering.BlendMode destinationColorBlendMode, UnityEngine.Rendering.BlendMode sourceAlphaBlendMode, UnityEngine.Rendering.BlendMode destinationAlphaBlendMode, UnityEngine.Rendering.BlendOp colorBlendOperation, UnityEngine.Rendering.BlendOp alphaBlendOperation);
            /*0x7eabb20*/ bool Equals(UnityEngine.Rendering.RenderTargetBlendState other);
            /*0x7eabb94*/ bool Equals(object obj);
            /*0x7eabc0c*/ int GetHashCode();
        }

        struct RendererList
        {
            static /*0x0*/ UnityEngine.Rendering.RendererList nullRendererList;
            /*0x10*/ nuint context;
            /*0x18*/ uint index;
            /*0x1c*/ uint frame;
            /*0x20*/ uint type;
            /*0x24*/ uint contextID;

            static /*0x7eabcf8*/ RendererList();
            /*0x7eabce8*/ RendererList(nuint ctx, uint indx);
            /*0x7eabcac*/ bool get_isValid();
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

            static /*0x7eac83c*/ RendererListParams();
            /*0x7eabd4c*/ RendererListParams(UnityEngine.Rendering.CullingResults cullingResults, UnityEngine.Rendering.DrawingSettings drawSettings, UnityEngine.Rendering.FilteringSettings filteringSettings);
            /*0x7eabdec*/ int get_numStateBlocks();
            /*0x7eabe58*/ nint get_stateBlocksPtr();
            /*0x7eabee8*/ nint get_tagsValuePtr();
            /*0x7eabf78*/ void Validate();
            /*0x7eac3c4*/ bool Equals(UnityEngine.Rendering.RendererListParams other);
            /*0x7eac610*/ bool Equals(object obj);
            /*0x7eac6f8*/ int GetHashCode();
        }

        struct ScriptableRenderContext : System.IEquatable<UnityEngine.Rendering.ScriptableRenderContext>
        {
            static /*0x0*/ UnityEngine.Rendering.ShaderTagId kRenderTypeTag;
            /*0x10*/ nint m_Ptr;

            static /*0x7eaf0c4*/ ScriptableRenderContext();
            static /*0x7eac888*/ void BeginRenderPass_Internal(nint self, int width, int height, int volumeDepth, int samples, nint colors, int colorCount, int depthAttachmentIndex);
            static /*0x7eac914*/ void BeginSubPass_Internal(nint self, nint colors, int colorCount, nint inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly);
            static /*0x7eac998*/ void EndSubPass_Internal(nint self);
            static /*0x7eac9d4*/ void EndRenderPass_Internal(nint self);
            static /*0x7eaca10*/ bool HasInvokeOnRenderObjectCallbacks_Internal();
            static /*0x7eaca38*/ void Internal_Cull(ref UnityEngine.Rendering.ScriptableCullingParameters parameters, UnityEngine.Rendering.ScriptableRenderContext renderLoop, nint results);
            static /*0x7eacb1c*/ void Internal_CullShadowCasters(UnityEngine.Rendering.ScriptableRenderContext renderLoop, nint context);
            static /*0x7eacbe8*/ void InitializeSortSettings(UnityEngine.Camera camera, ref UnityEngine.Rendering.SortingSettings sortingSettings);
            static /*0x7eacda8*/ void EmitGeometryForCamera(UnityEngine.Camera camera);
            static /*0x7eacac8*/ void Internal_Cull_Injected(ref UnityEngine.Rendering.ScriptableCullingParameters parameters, ref UnityEngine.Rendering.ScriptableRenderContext renderLoop, nint results);
            static /*0x7eacba4*/ void Internal_CullShadowCasters_Injected(ref UnityEngine.Rendering.ScriptableRenderContext renderLoop, nint context);
            static /*0x7eacc98*/ void InitializeSortSettings_Injected(nint camera, ref UnityEngine.Rendering.SortingSettings sortingSettings);
            static /*0x7eace48*/ void EmitGeometryForCamera_Injected(nint camera);
            static /*0x7eacf08*/ void ExecuteCommandBuffer_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint commandBuffer);
            static /*0x7eacfe0*/ void ExecuteCommandBufferAsync_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType);
            static /*0x7ead128*/ void SetupCameraProperties_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera, bool stereoSetup, int eye);
            static /*0x7ead260*/ void DrawWireOverlay_Impl_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera);
            static /*0x7ead3ac*/ void CreateRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.ShaderTagId tagName, bool isPassTagName, nint tagValues, nint stateBlocks, int stateCount, ref UnityEngine.Rendering.RendererList ret);
            static /*0x7ead500*/ void CreateShadowRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint shadowDrawinSettings, ref UnityEngine.Rendering.RendererList ret);
            static /*0x7ead698*/ void CreateSkyboxRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera, int mode, ref UnityEngine.Matrix4x4 proj, ref UnityEngine.Matrix4x4 view, ref UnityEngine.Matrix4x4 projR, ref UnityEngine.Matrix4x4 viewR, ref UnityEngine.Rendering.RendererList ret);
            static /*0x7ead838*/ void CreateGizmoRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera, UnityEngine.Rendering.GizmoSubset gizmoSubset, ref UnityEngine.Rendering.RendererList ret);
            static /*0x7ead9a8*/ void CreateUIOverlayRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera, UnityEngine.Rendering.UISubset uiSubset, ref UnityEngine.Rendering.RendererList ret);
            static /*0x7eadb0c*/ void CreateWireOverlayRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera, ref UnityEngine.Rendering.RendererList ret);
            static /*0x7eadc28*/ UnityEngine.Rendering.RendererListStatus QueryRendererListStatus_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, ref UnityEngine.Rendering.RendererList handle);
            /*0x7eab11c*/ ScriptableRenderContext(nint ptr);
            /*0x7eaccdc*/ void Submit_Internal();
            /*0x7eacd18*/ bool SubmitForRenderPassValidation_Internal();
            /*0x7eacd54*/ void GetCameras_Internal(System.Type listType, object resultList);
            /*0x7eace84*/ void ExecuteCommandBuffer_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer);
            /*0x7eacf4c*/ void ExecuteCommandBufferAsync_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType);
            /*0x7ead034*/ void SetupCameraProperties_Internal(UnityEngine.Camera camera, bool stereoSetup, int eye);
            /*0x7ead184*/ void DrawWireOverlay_Impl(UnityEngine.Camera camera);
            /*0x7ead2a4*/ nint Internal_GetPtr();
            /*0x7ead2ac*/ UnityEngine.Rendering.RendererList CreateRendererList_Internal(nint cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, UnityEngine.Rendering.ShaderTagId tagName, bool isPassTagName, nint tagValues, nint stateBlocks, int stateCount);
            /*0x7ead450*/ UnityEngine.Rendering.RendererList CreateShadowRendererList_Internal(nint shadowDrawinSettings);
            /*0x7ead554*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList_Internal(UnityEngine.Camera camera, int mode, UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 projR, UnityEngine.Matrix4x4 viewR);
            /*0x7ead724*/ UnityEngine.Rendering.RendererList CreateGizmoRendererList_Internal(UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset);
            /*0x7ead894*/ UnityEngine.Rendering.RendererList CreateUIOverlayRendererList_Internal(UnityEngine.Camera camera, UnityEngine.Rendering.UISubset uiSubset);
            /*0x7eada04*/ UnityEngine.Rendering.RendererList CreateWireOverlayRendererList_Internal(UnityEngine.Camera camera);
            /*0x7eadb60*/ void PrepareRendererListsAsync_Internal(object rendererLists);
            /*0x7eadba4*/ UnityEngine.Rendering.RendererListStatus QueryRendererListStatus_Internal(UnityEngine.Rendering.RendererList handle);
            /*0x7eadc6c*/ void BeginRenderPass(int width, int height, int samples, Unity.Collections.NativeArray<UnityEngine.Rendering.AttachmentDescriptor> attachments, int depthAttachmentIndex);
            /*0x7eadd6c*/ void BeginSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthStencilReadOnly);
            /*0x7eade78*/ void BeginSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthStencilReadOnly);
            /*0x7eadf58*/ void EndSubPass();
            /*0x7eadfd0*/ void EndRenderPass();
            /*0x7eae048*/ void Submit();
            /*0x7eae0bc*/ bool SubmitForRenderPassValidation();
            /*0x7eae130*/ bool HasInvokeOnRenderObjectCallbacks();
            /*0x7eab124*/ void GetCameras(System.Collections.Generic.List<UnityEngine.Camera> results);
            /*0x7eae198*/ void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer commandBuffer);
            /*0x7eae27c*/ void ExecuteCommandBufferAsync(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType);
            /*0x7eae370*/ void SetupCameraProperties(UnityEngine.Camera camera, bool stereoSetup);
            /*0x7eae3e0*/ void SetupCameraProperties(UnityEngine.Camera camera, bool stereoSetup, int eye);
            /*0x7eae45c*/ void DrawWireOverlay(UnityEngine.Camera camera);
            /*0x7eae4c0*/ UnityEngine.Rendering.CullingResults Cull(ref UnityEngine.Rendering.ScriptableCullingParameters parameters);
            /*0x7eae554*/ void CullShadowCasters(UnityEngine.Rendering.CullingResults cullingResults, UnityEngine.Rendering.ShadowCastersCullingInfos infos);
            /*0x7eae650*/ bool Equals(UnityEngine.Rendering.ScriptableRenderContext other);
            /*0x7eae694*/ bool Equals(object obj);
            /*0x7eae764*/ int GetHashCode();
            /*0x7eae76c*/ UnityEngine.Rendering.RendererList CreateRendererList(ref UnityEngine.Rendering.RendererListParams param);
            /*0x7eae88c*/ UnityEngine.Rendering.RendererList CreateShadowRendererList(ref UnityEngine.Rendering.ShadowDrawingSettings settings);
            /*0x7eae930*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrixL, UnityEngine.Matrix4x4 viewMatrixL, UnityEngine.Matrix4x4 projectionMatrixR, UnityEngine.Matrix4x4 viewMatrixR);
            /*0x7eaea84*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 viewMatrix);
            /*0x7eaebf0*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Camera camera);
            /*0x7eaed54*/ UnityEngine.Rendering.RendererList CreateGizmoRendererList(UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset);
            /*0x7eaedf0*/ UnityEngine.Rendering.RendererList CreateUIOverlayRendererList(UnityEngine.Camera camera);
            /*0x7eaee84*/ UnityEngine.Rendering.RendererList CreateUIOverlayRendererList(UnityEngine.Camera camera, UnityEngine.Rendering.UISubset uiSubset);
            /*0x7eaef20*/ UnityEngine.Rendering.RendererList CreateWireOverlayRendererList(UnityEngine.Camera camera);
            /*0x7eaefb0*/ void PrepareRendererListsAsync(System.Collections.Generic.List<UnityEngine.Rendering.RendererList> rendererLists);
            /*0x7eaf034*/ UnityEngine.Rendering.RendererListStatus QueryRendererListStatus(UnityEngine.Rendering.RendererList rendererList);

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

            static /*0x7eac604*/ bool op_Equality(UnityEngine.Rendering.ShaderTagId tag1, UnityEngine.Rendering.ShaderTagId tag2);
            static /*0x7eaf1c4*/ bool op_Inequality(UnityEngine.Rendering.ShaderTagId tag1, UnityEngine.Rendering.ShaderTagId tag2);
            /*0x7eaf12c*/ ShaderTagId(string name);
            /*0x7ea7e2c*/ int get_id();
            /*0x7ea8018*/ void set_id(int value);
            /*0x7eaf14c*/ bool Equals(object obj);
            /*0x7ea82a4*/ bool Equals(UnityEngine.Rendering.ShaderTagId other);
            /*0x7eac81c*/ int GetHashCode();
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

            /*0x7eaf1dc*/ ShadowDrawingSettings(UnityEngine.Rendering.CullingResults cullingResults, int lightIndex);
            /*0x7eaf1d0*/ void set_useRenderingLayerMaskTest(bool value);
            /*0x7eaf364*/ bool Equals(UnityEngine.Rendering.ShadowDrawingSettings other);
            /*0x7eaf65c*/ bool Equals(object obj);
            /*0x7eaf714*/ int GetHashCode();
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

            static /*0x7eafaa4*/ ShadowSplitData();
            /*0x7eaf860*/ int get_cullingPlaneCount();
            /*0x7eaf868*/ UnityEngine.Vector4 get_cullingSphere();
            /*0x7eaf280*/ void set_shadowCascadeBlendCullingFactor(float value);
            /*0x7eaf874*/ UnityEngine.Plane GetCullingPlane(int index);
            /*0x7eaf4e8*/ bool Equals(UnityEngine.Rendering.ShadowSplitData other);
            /*0x7eaf9bc*/ bool Equals(object obj);
            /*0x7eaf7e4*/ int GetHashCode();

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

            static /*0x7ea8768*/ UnityEngine.Rendering.SortingLayerRange get_all();
            /*0x7eafaf0*/ bool Equals(UnityEngine.Rendering.SortingLayerRange other);
            /*0x7eafb14*/ bool Equals(object obj);
            /*0x7eafb98*/ int GetHashCode();
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

            /*0x7eafba0*/ SortingSettings(UnityEngine.Camera camera);
            /*0x7eafc04*/ UnityEngine.Rendering.SortingCriteria get_criteria();
            /*0x7eafc0c*/ void set_criteria(UnityEngine.Rendering.SortingCriteria value);
            /*0x7ea82b4*/ bool Equals(UnityEngine.Rendering.SortingSettings other);
            /*0x7eafc14*/ bool Equals(object obj);
            /*0x7ea84c0*/ int GetHashCode();
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

            static /*0x7eab624*/ UnityEngine.Rendering.StencilState get_defaultValue();
            /*0x7eafca4*/ StencilState(bool enabled, byte readMask, byte writeMask, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.StencilOp passOperation, UnityEngine.Rendering.StencilOp failOperation, UnityEngine.Rendering.StencilOp zFailOperation);
            /*0x7eafcd0*/ StencilState(bool enabled, byte readMask, byte writeMask, UnityEngine.Rendering.CompareFunction compareFunctionFront, UnityEngine.Rendering.StencilOp passOperationFront, UnityEngine.Rendering.StencilOp failOperationFront, UnityEngine.Rendering.StencilOp zFailOperationFront, UnityEngine.Rendering.CompareFunction compareFunctionBack, UnityEngine.Rendering.StencilOp passOperationBack, UnityEngine.Rendering.StencilOp failOperationBack, UnityEngine.Rendering.StencilOp zFailOperationBack);
            /*0x7eafdb4*/ bool get_enabled();
            /*0x7eafe10*/ void set_enabled(bool value);
            /*0x7eafe7c*/ byte get_readMask();
            /*0x7eafe84*/ void set_readMask(byte value);
            /*0x7eafe8c*/ byte get_writeMask();
            /*0x7eafe94*/ void set_writeMask(byte value);
            /*0x7eafe9c*/ void SetCompareFunction(UnityEngine.Rendering.CompareFunction value);
            /*0x7eafeb8*/ void SetPassOperation(UnityEngine.Rendering.StencilOp value);
            /*0x7eafed4*/ void SetFailOperation(UnityEngine.Rendering.StencilOp value);
            /*0x7eafef0*/ void SetZFailOperation(UnityEngine.Rendering.StencilOp value);
            /*0x7eaff0c*/ UnityEngine.Rendering.CompareFunction get_compareFunctionFront();
            /*0x7eafea8*/ void set_compareFunctionFront(UnityEngine.Rendering.CompareFunction value);
            /*0x7eaff14*/ UnityEngine.Rendering.StencilOp get_passOperationFront();
            /*0x7eafec4*/ void set_passOperationFront(UnityEngine.Rendering.StencilOp value);
            /*0x7eaff1c*/ UnityEngine.Rendering.StencilOp get_failOperationFront();
            /*0x7eafee0*/ void set_failOperationFront(UnityEngine.Rendering.StencilOp value);
            /*0x7eaff24*/ UnityEngine.Rendering.StencilOp get_zFailOperationFront();
            /*0x7eafefc*/ void set_zFailOperationFront(UnityEngine.Rendering.StencilOp value);
            /*0x7eaff2c*/ UnityEngine.Rendering.CompareFunction get_compareFunctionBack();
            /*0x7eafeb0*/ void set_compareFunctionBack(UnityEngine.Rendering.CompareFunction value);
            /*0x7eaff34*/ UnityEngine.Rendering.StencilOp get_passOperationBack();
            /*0x7eafecc*/ void set_passOperationBack(UnityEngine.Rendering.StencilOp value);
            /*0x7eaff3c*/ UnityEngine.Rendering.StencilOp get_failOperationBack();
            /*0x7eafee8*/ void set_failOperationBack(UnityEngine.Rendering.StencilOp value);
            /*0x7eaff44*/ UnityEngine.Rendering.StencilOp get_zFailOperationBack();
            /*0x7eaff04*/ void set_zFailOperationBack(UnityEngine.Rendering.StencilOp value);
            /*0x7eab7f0*/ bool Equals(UnityEngine.Rendering.StencilState other);
            /*0x7eaff4c*/ bool Equals(object obj);
            /*0x7eaba00*/ int GetHashCode();
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

            static /*0x7eb0840*/ SupportedRenderingFeatures();
            static /*0x7eaffc8*/ UnityEngine.Rendering.SupportedRenderingFeatures get_active();
            static /*0x7eaac14*/ void set_active(UnityEngine.Rendering.SupportedRenderingFeatures value);
            static /*0x7eb018c*/ void FallbackMixedLightingModeByRef(nint fallbackModePtr);
            static /*0x7eb02c0*/ bool IsMixedLightingModeSupported(UnityEngine.MixedLightingMode mixedMode);
            static /*0x7eb032c*/ void IsMixedLightingModeSupportedByRef(UnityEngine.MixedLightingMode mixedMode, nint isSupportedPtr);
            static /*0x7eb0434*/ bool IsLightmapBakeTypeSupported(UnityEngine.LightmapBakeType bakeType);
            static /*0x7eb04a0*/ void IsLightmapBakeTypeSupportedByRef(UnityEngine.LightmapBakeType bakeType, nint isSupportedPtr);
            static /*0x7eb0590*/ void IsLightmapsModeSupportedByRef(UnityEngine.LightmapsMode mode, nint isSupportedPtr);
            static /*0x7eb061c*/ void IsLightmapperSupportedByRef(int lightmapper, nint isSupportedPtr);
            static /*0x7eb0644*/ void IsUIOverlayRenderedBySRP(nint isSupportedPtr);
            static /*0x7eb06bc*/ void IsAmbientProbeBakingSupported(nint isSupportedPtr);
            static /*0x7eb0734*/ void IsDefaultReflectionProbeBakingSupported(nint isSupportedPtr);
            static /*0x7eb07ac*/ void OverridesLightProbeSystem(nint overridesPtr);
            static /*0x7eb0824*/ void FallbackLightmapperByRef(nint lightmapperPtr);
            /*0x7eb0078*/ SupportedRenderingFeatures();
            /*0x7eb0114*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_defaultMixedLightingModes();
            /*0x7eb011c*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_mixedLightingModes();
            /*0x7eb0124*/ UnityEngine.LightmapBakeType get_lightmapBakeTypes();
            /*0x7eb012c*/ UnityEngine.LightmapsMode get_lightmapsModes();
            /*0x7eb0134*/ bool get_enlighten();
            /*0x7eb013c*/ void set_skyOcclusion(bool value);
            /*0x7eb0148*/ bool get_rendersUIOverlay();
            /*0x7eb0150*/ void set_rendersUIOverlay(bool value);
            /*0x7eb015c*/ bool get_ambientProbeBaking();
            /*0x7eb0164*/ bool get_defaultReflectionProbeBaking();
            /*0x7eb016c*/ bool get_overridesLightProbeSystem();
            /*0x7eb0174*/ void set_overridesLightProbeSystem(bool value);
            /*0x7eb0180*/ void set_supportsHDR(bool value);

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

            /*0x7eb08a4*/ UnityEngine.Light get_light();
            /*0x7eb0930*/ UnityEngine.LightType get_lightType();
            /*0x7eb0938*/ UnityEngine.Color get_finalColor();
            /*0x7eb0944*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
            /*0x7eb0960*/ float get_range();
            /*0x7eb0968*/ float get_spotAngle();
            /*0x7eb0970*/ bool Equals(UnityEngine.Rendering.VisibleLight other);
            /*0x7eb0b1c*/ bool Equals(object obj);
            /*0x7eb0bac*/ int GetHashCode();
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

            /*0x7eb0cb4*/ UnityEngine.Texture get_texture();
            /*0x7eb0d5c*/ UnityEngine.ReflectionProbe get_reflectionProbe();
            /*0x7eb0de8*/ UnityEngine.Bounds get_bounds();
            /*0x7eb0dfc*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
            /*0x7eb0e18*/ UnityEngine.Vector4 get_hdrData();
            /*0x7eb0e24*/ float get_blendDistance();
            /*0x7eb0e2c*/ int get_importance();
            /*0x7eb0e34*/ bool get_isBoxProjection();
            /*0x7eb0e90*/ bool Equals(UnityEngine.Rendering.VisibleReflectionProbe other);
            /*0x7eb1030*/ bool Equals(object obj);
            /*0x7eb10c0*/ int GetHashCode();
        }

        struct BatchID : System.IEquatable<UnityEngine.Rendering.BatchID>
        {
            static /*0x0*/ UnityEngine.Rendering.BatchID Null;
            /*0x10*/ uint value;

            static /*0x7eb1338*/ BatchID();
            /*0x7eb1278*/ int GetHashCode();
            /*0x7eb1280*/ bool Equals(object obj);
            /*0x7eb1328*/ bool Equals(UnityEngine.Rendering.BatchID other);
        }

        struct BatchMaterialID : System.IEquatable<UnityEngine.Rendering.BatchMaterialID>
        {
            static /*0x0*/ UnityEngine.Rendering.BatchMaterialID Null;
            /*0x10*/ uint value;

            static /*0x7eb14a4*/ BatchMaterialID();
            static /*0x7eb1440*/ bool op_Equality(UnityEngine.Rendering.BatchMaterialID a, UnityEngine.Rendering.BatchMaterialID b);
            /*0x7eb1380*/ int GetHashCode();
            /*0x7eb1388*/ bool Equals(object obj);
            /*0x7eb1430*/ bool Equals(UnityEngine.Rendering.BatchMaterialID other);
        }

        struct BatchMeshID : System.IEquatable<UnityEngine.Rendering.BatchMeshID>
        {
            static /*0x0*/ UnityEngine.Rendering.BatchMeshID Null;
            /*0x10*/ uint value;

            static /*0x7eb1610*/ BatchMeshID();
            static /*0x7eb15ac*/ bool op_Equality(UnityEngine.Rendering.BatchMeshID a, UnityEngine.Rendering.BatchMeshID b);
            /*0x7eb14ec*/ int GetHashCode();
            /*0x7eb14f4*/ bool Equals(object obj);
            /*0x7eb159c*/ bool Equals(UnityEngine.Rendering.BatchMeshID other);
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

            /*0x7eb1658*/ int GetHashCode();
            /*0x7eb1660*/ bool Equals(UnityEngine.Rendering.BatchPackedCullingViewID other);
            /*0x7eb1670*/ bool Equals(object obj);
            /*0x7eb16e8*/ int GetInstanceID();
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

            /*0x7eb16f0*/ void set_batchLayer(byte value);
            /*0x7eb16f8*/ void set_motionMode(UnityEngine.MotionVectorGenerationMode value);
            /*0x7eb1700*/ void set_shadowCastingMode(UnityEngine.Rendering.ShadowCastingMode value);
            /*0x7eb1708*/ void set_receiveShadows(bool value);
            /*0x7eb1714*/ void set_staticShadowCaster(bool value);
            /*0x7eb1720*/ void set_allDepthSorted(bool value);
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

            /*0x7eb172c*/ BatchCullingContext(Unity.Collections.NativeArray<UnityEngine.Plane> inCullingPlanes, Unity.Collections.NativeArray<UnityEngine.Rendering.CullingSplit> inCullingSplits, UnityEngine.Rendering.LODParameters inLodParameters, UnityEngine.Matrix4x4 inLocalToWorldMatrix, UnityEngine.Rendering.BatchCullingViewType inViewType, UnityEngine.Rendering.BatchCullingProjectionType inProjectionType, UnityEngine.Rendering.BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, byte inExclusionSplitMask, int inReceiverPlaneOffset, int inReceiverPlaneCount, nint inOcclusionBuffer);
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

            static /*0x7eb1fcc*/ UnityEngine.Rendering.BatchBufferTarget GetBufferTarget();
            static /*0x7eb1ff4*/ UnityEngine.Rendering.BatchBufferTarget get_BufferTarget();
            static /*0x7eb183c*/ nint Create(UnityEngine.Rendering.BatchRendererGroup group, void* userContext);
            static /*0x7eb18c8*/ void Destroy(nint groupHandle);
            static /*0x7eb201c*/ void InvokeOnPerformCulling(UnityEngine.Rendering.BatchRendererGroup group, ref UnityEngine.Rendering.BatchRendererCullingOutput context, ref UnityEngine.Rendering.LODParameters lodParameters, nint userContext);
            static /*0x7eb22ac*/ void InvokeOnFinishedCulling(UnityEngine.Rendering.BatchRendererGroup group, nint customCullingResult);
            static /*0x7eb2374*/ bool OcclusionTestAABB(nint occlusionBuffer, UnityEngine.Bounds aabb);
            static /*0x7eb19a4*/ void AddDrawCommandBatch_Injected(nint _unity_self, nint values, int count, ref UnityEngine.GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize, ref UnityEngine.Rendering.BatchID ret);
            static /*0x7eb1b18*/ void RemoveDrawCommandBatch_Injected(nint _unity_self, ref UnityEngine.Rendering.BatchID batchID);
            static /*0x7eb1ca4*/ void RegisterMaterials_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper materialID, ref UnityEngine.Bindings.ManagedSpanWrapper batchMaterialID);
            static /*0x7eb1d54*/ void UnregisterMaterial_Injected(nint _unity_self, ref UnityEngine.Rendering.BatchMaterialID material);
            static /*0x7eb1ed8*/ void RegisterMeshes_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper meshID, ref UnityEngine.Bindings.ManagedSpanWrapper batchMeshID);
            static /*0x7eb1f88*/ void UnregisterMesh_Injected(nint _unity_self, ref UnityEngine.Rendering.BatchMeshID mesh);
            static /*0x7eb23b8*/ bool OcclusionTestAABB_Injected(nint occlusionBuffer, ref UnityEngine.Bounds aabb);
            /*0x7eb17b0*/ BatchRendererGroup(UnityEngine.Rendering.BatchRendererGroupCreateInfo info);
            /*0x7eb1880*/ void Dispose();
            /*0x7eb1904*/ UnityEngine.Rendering.BatchID AddDrawCommandBatch(nint values, int count, UnityEngine.GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize);
            /*0x7eb1a28*/ UnityEngine.Rendering.BatchID AddBatch(Unity.Collections.NativeArray<UnityEngine.Rendering.MetadataValue> batchMetadata, UnityEngine.GraphicsBufferHandle buffer);
            /*0x7eb1abc*/ void RemoveDrawCommandBatch(UnityEngine.Rendering.BatchID batchID);
            /*0x7eb1b5c*/ void RemoveBatch(UnityEngine.Rendering.BatchID batchID);
            /*0x7eb1b64*/ void RegisterMaterials(System.ReadOnlySpan<int> materialID, System.Span<UnityEngine.Rendering.BatchMaterialID> batchMaterialID);
            /*0x7eb1cf8*/ void UnregisterMaterial(UnityEngine.Rendering.BatchMaterialID material);
            /*0x7eb1d98*/ void RegisterMeshes(System.ReadOnlySpan<int> meshID, System.Span<UnityEngine.Rendering.BatchMeshID> batchMeshID);
            /*0x7eb1f2c*/ void UnregisterMesh(UnityEngine.Rendering.BatchMeshID mesh);

            class OnPerformCulling : System.MulticastDelegate
            {
                /*0x7eb23fc*/ OnPerformCulling(object object, nint method);
                /*0x7eb2508*/ Unity.Jobs.JobHandle Invoke(UnityEngine.Rendering.BatchRendererGroup rendererGroup, UnityEngine.Rendering.BatchCullingContext cullingContext, UnityEngine.Rendering.BatchCullingOutput cullingOutput, nint userContext);
            }

            class OnFinishedCulling : System.MulticastDelegate
            {
                /*0x7eb2584*/ OnFinishedCulling(object object, nint method);
                /*0x7eb2624*/ void Invoke(nint customCullingResult);
            }

            class BindingsMarshaller
            {
                static /*0x7eb2638*/ nint ConvertToNative(UnityEngine.Rendering.BatchRendererGroup batchRendererGroup);
            }
        }

        class GPUDrivenLODGroupDataCallback : System.MulticastDelegate
        {
            /*0x7eb2650*/ GPUDrivenLODGroupDataCallback(object object, nint method);
            /*0x7eb2700*/ void Invoke(ref UnityEngine.Rendering.GPUDrivenLODGroupData lodGroupData);
        }

        class GPUDrivenLODGroupDataNativeCallback : System.MulticastDelegate
        {
            /*0x7eb2714*/ GPUDrivenLODGroupDataNativeCallback(object object, nint method);
            /*0x7eb27c8*/ void Invoke(ref UnityEngine.Rendering.GPUDrivenLODGroupDataNative lodGroupDataNative, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback callback);
        }

        class GPUDrivenRendererDataCallback : System.MulticastDelegate
        {
            /*0x7eb27dc*/ GPUDrivenRendererDataCallback(object object, nint method);
            /*0x7eb2890*/ void Invoke(ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, System.Collections.Generic.IList<UnityEngine.Mesh> meshes, System.Collections.Generic.IList<UnityEngine.Material> materials);
        }

        class GPUDrivenRendererDataNativeCallback : System.MulticastDelegate
        {
            /*0x7eb28a4*/ GPUDrivenRendererDataNativeCallback(object object, nint method);
            /*0x7eb2958*/ void Invoke(ref UnityEngine.Rendering.GPUDrivenRendererGroupDataNative rendererDataNative, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, UnityEngine.Rendering.GPUDrivenRendererDataCallback callback);
        }

        class GPUDrivenCallbacks
        {
            static /*0x7eb296c*/ void InvokeGPUDrivenLODGroupDataNativeCallback(UnityEngine.Rendering.GPUDrivenLODGroupDataNativeCallback callback, ref UnityEngine.Rendering.GPUDrivenLODGroupDataNative lodGroupDataNative, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback target);
            static /*0x7eb2990*/ void InvokeGPUDrivenRendererDataNativeCallback(UnityEngine.Rendering.GPUDrivenRendererDataNativeCallback callback, ref UnityEngine.Rendering.GPUDrivenRendererGroupDataNative rendererDataNative, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, UnityEngine.Rendering.GPUDrivenRendererDataCallback target);
        }

        class GPUDrivenProcessor
        {
            static /*0x0*/ UnityEngine.Rendering.GPUDrivenRendererDataNativeCallback s_NativeRendererCallback;
            static /*0x8*/ UnityEngine.Rendering.GPUDrivenLODGroupDataNativeCallback s_NativeLODGroupCallback;
            /*0x10*/ nint m_Ptr;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Mesh> <scratchMeshes>k__BackingField;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Material> <scratchMaterials>k__BackingField;

            static /*0x7eb36e0*/ GPUDrivenProcessor();
            static /*0x7eb2afc*/ nint Internal_Create();
            static /*0x7eb2cbc*/ void Internal_Destroy(nint ptr);
            static /*0x7eb3490*/ int FindUnsupportedMaterialsImpl(System.ReadOnlySpan<int> materialIDs, System.Span<int> unsupportedMaterialIDs);
            static /*0x7eb3614*/ int FindUnsupportedMaterialIDs(Unity.Collections.NativeArray<int> materialIDs, Unity.Collections.NativeArray<int> unsupportedMaterialIDs);
            static /*0x7eb2e2c*/ void EnableGPUDrivenRenderingAndDispatchRendererData_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper renderersID, UnityEngine.Rendering.GPUDrivenRendererDataNativeCallback callback, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, UnityEngine.Rendering.GPUDrivenRendererDataCallback param);
            static /*0x7eb309c*/ void DisableGPUDrivenRendering_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper renderersID);
            static /*0x7eb31fc*/ void DispatchLODGroupData_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper lodGroupID, UnityEngine.Rendering.GPUDrivenLODGroupDataNativeCallback callback, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback param);
            static /*0x7eb3380*/ void set_enablePartialRendering_Injected(nint _unity_self, bool value);
            static /*0x7eb3454*/ void ClearMaterialFilters_Injected(nint _unity_self);
            static /*0x7eb35d0*/ int FindUnsupportedMaterialsImpl_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper materialIDs, ref UnityEngine.Bindings.ManagedSpanWrapper unsupportedMaterialIDs);
            /*0x7eb29d4*/ GPUDrivenProcessor();
            /*0x7eb29b4*/ System.Collections.Generic.List<UnityEngine.Mesh> get_scratchMeshes();
            /*0x7eb29bc*/ void set_scratchMeshes(System.Collections.Generic.List<UnityEngine.Mesh> value);
            /*0x7eb29c4*/ System.Collections.Generic.List<UnityEngine.Material> get_scratchMaterials();
            /*0x7eb29cc*/ void set_scratchMaterials(System.Collections.Generic.List<UnityEngine.Material> value);
            /*0x7eb2b24*/ void Finalize();
            /*0x7eb2c3c*/ void Dispose();
            /*0x7eb2bb8*/ void Destroy();
            /*0x7eb2cf8*/ void EnableGPUDrivenRenderingAndDispatchRendererData(System.ReadOnlySpan<int> renderersID, UnityEngine.Rendering.GPUDrivenRendererDataNativeCallback callback, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, UnityEngine.Rendering.GPUDrivenRendererDataCallback param);
            /*0x7eb2ea0*/ void EnableGPUDrivenRenderingAndDispatchRendererData(System.ReadOnlySpan<int> renderersID, UnityEngine.Rendering.GPUDrivenRendererDataCallback callback);
            /*0x7eb2f98*/ void DisableGPUDrivenRendering(System.ReadOnlySpan<int> renderersID);
            /*0x7eb30e0*/ void DispatchLODGroupData(System.ReadOnlySpan<int> lodGroupID, UnityEngine.Rendering.GPUDrivenLODGroupDataNativeCallback callback, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback param);
            /*0x7eb3258*/ void DispatchLODGroupData(System.ReadOnlySpan<int> lodGroupID, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback callback);
            /*0x7eb32e0*/ void set_enablePartialRendering(bool value);
            /*0x7eb33c4*/ void ClearMaterialFilters();

            class BindingsMarshaller
            {
                static /*0x7eb3814*/ nint ConvertToNative(UnityEngine.Rendering.GPUDrivenProcessor obj);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.GPUDrivenProcessor.<> <>9;

                static /*0x7eb382c*/ <>c();
                /*0x7eb3894*/ <>c();
                /*0x7eb389c*/ void <.cctor>b__34_0(ref UnityEngine.Rendering.GPUDrivenRendererGroupDataNative nativeData, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, UnityEngine.Rendering.GPUDrivenRendererDataCallback callback);
                /*0x7eb3e74*/ void <.cctor>b__34_1(ref UnityEngine.Rendering.GPUDrivenLODGroupDataNative nativeData, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback callback);
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
            /*0x50*/ int lodGroupCount;
            /*0x58*/ int* invalidLODGroupID;
            /*0x60*/ int invalidLODGroupCount;
            /*0x68*/ short* lodRenderersCount;
            /*0x70*/ float* lodScreenRelativeTransitionHeight;
            /*0x78*/ float* lodFadeTransitionWidth;
            /*0x80*/ int lodDataCount;
        }

        struct GPUDrivenPackedRendererData
        {
            /*0x10*/ uint data;

            /*0x7eb4190*/ GPUDrivenPackedRendererData();
            /*0x7eb4130*/ bool get_staticShadowCaster();
            /*0x7eb413c*/ byte get_lodMask();
            /*0x7eb4148*/ UnityEngine.Rendering.ShadowCastingMode get_shadowCastingMode();
            /*0x7eb4154*/ UnityEngine.Rendering.LightProbeUsage get_lightProbeUsage();
            /*0x7eb4160*/ UnityEngine.MotionVectorGenerationMode get_motionVecGenMode();
            /*0x7eb416c*/ bool get_isPartOfStaticBatch();
            /*0x7eb4178*/ bool get_hasTree();
            /*0x7eb4184*/ bool get_smallMeshCulling();
        }

        struct GPUDrivenPackedMaterialData
        {
            /*0x10*/ uint data;

            /*0x7eb41bc*/ GPUDrivenPackedMaterialData();
            /*0x7eb4198*/ bool get_isTransparent();
            /*0x7eb41a4*/ bool get_isMotionVectorsPassEnabled();
            /*0x7eb41b0*/ bool get_isIndirectSupported();
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
            /*0x90*/ Unity.Collections.NativeArray<int> invalidLODGroupID;
            /*0xa0*/ Unity.Collections.NativeArray<short> lodRenderersCount;
            /*0xb0*/ Unity.Collections.NativeArray<float> lodScreenRelativeTransitionHeight;
            /*0xc0*/ Unity.Collections.NativeArray<float> lodFadeTransitionWidth;
        }

        struct GlobalKeyword
        {
            /*0x10*/ string m_Name;
            /*0x18*/ uint m_Index;

            static /*0x7eb41c4*/ uint GetGlobalKeywordCount();
            static /*0x7eb41ec*/ uint GetGlobalKeywordIndex(string keyword);
            static /*0x7eb4398*/ void CreateGlobalKeyword(string keyword);
            static /*0x7eb453c*/ UnityEngine.Rendering.GlobalKeyword Create(string name);
            static /*0x7eb435c*/ uint GetGlobalKeywordIndex_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            static /*0x7eb4500*/ void CreateGlobalKeyword_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            /*0x7eb456c*/ GlobalKeyword(string name);
            /*0x7eb46a4*/ string ToString();
        }

        struct LocalKeyword : System.IEquatable<UnityEngine.Rendering.LocalKeyword>
        {
            /*0x10*/ UnityEngine.Rendering.LocalKeywordSpace m_SpaceInfo;
            /*0x18*/ string m_Name;
            /*0x20*/ uint m_Index;

            static /*0x7eb46ac*/ uint GetShaderKeywordCount(UnityEngine.Shader shader);
            static /*0x7eb476c*/ uint GetShaderKeywordIndex(UnityEngine.Shader shader, string keyword);
            static /*0x7eb4960*/ uint GetComputeShaderKeywordCount(UnityEngine.ComputeShader shader);
            static /*0x7eb4a20*/ uint GetComputeShaderKeywordIndex(UnityEngine.ComputeShader shader, string keyword);
            static /*0x7eb4730*/ uint GetShaderKeywordCount_Injected(nint shader);
            static /*0x7eb491c*/ uint GetShaderKeywordIndex_Injected(nint shader, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            static /*0x7eb49e4*/ uint GetComputeShaderKeywordCount_Injected(nint shader);
            static /*0x7eb4bd0*/ uint GetComputeShaderKeywordIndex_Injected(nint shader, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            /*0x7eb4c14*/ LocalKeyword(UnityEngine.Shader shader, string name);
            /*0x7eb4dc0*/ LocalKeyword(UnityEngine.ComputeShader shader, string name);
            /*0x7eb4f6c*/ string ToString();
            /*0x7eb4f74*/ bool Equals(object o);
            /*0x7eb4ffc*/ bool Equals(UnityEngine.Rendering.LocalKeyword rhs);
            /*0x7eb5034*/ int GetHashCode();
        }

        struct LocalKeywordSpace : System.IEquatable<UnityEngine.Rendering.LocalKeywordSpace>
        {
            /*0x10*/ nint m_KeywordSpace;

            static /*0x7eb5028*/ bool op_Equality(UnityEngine.Rendering.LocalKeywordSpace lhs, UnityEngine.Rendering.LocalKeywordSpace rhs);
            /*0x7eb5074*/ bool Equals(object o);
            /*0x7eb50ec*/ bool Equals(UnityEngine.Rendering.LocalKeywordSpace rhs);
            /*0x7eb506c*/ int GetHashCode();
        }

        class RayTracingShader : UnityEngine.Object
        {
            /*0x7eb50fc*/ RayTracingShader();
        }

        struct ShaderKeyword
        {
            /*0x10*/ string m_Name;
            /*0x18*/ uint m_Index;
            /*0x1c*/ bool m_IsLocal;
            /*0x1d*/ bool m_IsCompute;
            /*0x1e*/ bool m_IsValid;

            static /*0x7eb5154*/ uint GetGlobalKeywordCount();
            static /*0x7eb517c*/ uint GetGlobalKeywordIndex(string keyword);
            static /*0x7eb5328*/ void CreateGlobalKeyword(string keyword);
            static /*0x7eb52ec*/ uint GetGlobalKeywordIndex_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            static /*0x7eb5490*/ void CreateGlobalKeyword_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            /*0x7eb54d4*/ ShaderKeyword(string keywordName);
            /*0x7eb54cc*/ string get_name();
            /*0x7eb555c*/ string ToString();
        }

        struct ShaderKeywordSet
        {
            /*0x10*/ nint m_KeywordState;
            /*0x18*/ nint m_Shader;
            /*0x20*/ nint m_ComputeShader;
            /*0x28*/ ulong m_StateIndex;

            static /*0x7eb5564*/ bool IsKeywordNameEnabled(UnityEngine.Rendering.ShaderKeywordSet state, string name);
            static /*0x7eb56e0*/ bool IsKeywordNameEnabled_Injected(ref UnityEngine.Rendering.ShaderKeywordSet state, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            /*0x7eb5724*/ void CheckKeywordCompatible(UnityEngine.Rendering.ShaderKeyword keyword);
            /*0x7eb57d8*/ bool IsEnabled(UnityEngine.Rendering.ShaderKeyword keyword);
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

                static /*0x7eb6078*/ RendererListDesc();
                static /*0x7eb595c*/ UnityEngine.Rendering.RendererListParams ConvertToParameters(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                /*0x7eb5818*/ uint get_batchLayerMask();
                /*0x7eb5820*/ UnityEngine.Rendering.CullingResults get_cullingResult();
                /*0x7eb582c*/ UnityEngine.Camera get_camera();
                /*0x7eb5834*/ UnityEngine.Rendering.ShaderTagId get_passName();
                /*0x7eb583c*/ UnityEngine.Rendering.ShaderTagId[] get_passNames();
                /*0x7eb5844*/ bool IsValid();
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

                static /*0x7eb62fc*/ UnityEngine.Experimental.GlobalIllumination.LinearColor Convert(UnityEngine.Color color, float intensity);
                static /*0x7eb65e0*/ UnityEngine.Experimental.GlobalIllumination.LinearColor Black();
                /*0x7eb60e0*/ float get_red();
                /*0x7eb60e8*/ void set_red(float value);
                /*0x7eb6194*/ float get_green();
                /*0x7eb619c*/ void set_green(float value);
                /*0x7eb6248*/ float get_blue();
                /*0x7eb6250*/ void set_blue(float value);
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

                static /*0x7eb65f4*/ UnityEngine.Experimental.GlobalIllumination.Cookie Defaults();
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

                /*0x7eb6600*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x7eb6674*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.PointLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x7eb66f0*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.SpotLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x7eb6770*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.RectangleLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x7eb67e8*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DiscLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x7eb6864*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight light);
                /*0x7eb68dc*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.PointLight light);
                /*0x7eb6950*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.SpotLight light);
                /*0x7eb6978*/ void InitNoBake(int lightInstanceID);
            }

            class LightmapperUtils
            {
                static /*0x7eb6988*/ UnityEngine.Experimental.GlobalIllumination.LightMode Extract(UnityEngine.LightmapBakeType baketype);
                static /*0x7eb69a8*/ UnityEngine.Experimental.GlobalIllumination.LinearColor ExtractIndirect(UnityEngine.Light l);
                static /*0x7eb6a20*/ float ExtractInnerCone(UnityEngine.Light l);
                static /*0x7eb6a74*/ UnityEngine.Color ExtractColorTemperature(UnityEngine.Light l);
                static /*0x7eb6b2c*/ void ApplyColorTemperature(UnityEngine.Color cct, ref UnityEngine.Experimental.GlobalIllumination.LinearColor lightColor);
                static /*0x7eb6b74*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight dir);
                static /*0x7eb6d0c*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.PointLight point);
                static /*0x7eb6ebc*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.SpotLight spot);
                static /*0x7eb7094*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.RectangleLight rect);
                static /*0x7eb7244*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.DiscLight disc);
                static /*0x7eb73f4*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
            }

            class Lightmapping
            {
                static /*0x0*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate s_DefaultDelegate;
                static /*0x8*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate s_RequestLightsDelegate;

                static /*0x7eb7734*/ Lightmapping();
                static /*0x7eb7538*/ void SetDelegate(UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate del);
                static /*0x7eb75b4*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate GetDelegate();
                static /*0x7eb760c*/ void ResetDelegate();
                static /*0x7eb7668*/ void RequestLights(UnityEngine.Light[] lights, nint outLightsPtr, int outLightsCount);

                class RequestLightsDelegate : System.MulticastDelegate
                {
                    /*0x7eb7814*/ RequestLightsDelegate(object object, nint method);
                    /*0x7eb78c8*/ void Invoke(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.<> <>9;

                    static /*0x7eb78dc*/ <>c();
                    /*0x7eb7944*/ <>c();
                    /*0x7eb794c*/ void <.cctor>b__7_0(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }
            }
        }

        namespace Playables
        {
            struct CameraPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Experimental.Playables.CameraPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x7eb7e5c*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x7eb7e68*/ bool Equals(UnityEngine.Experimental.Playables.CameraPlayable other);
            }

            struct MaterialEffectPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Experimental.Playables.MaterialEffectPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x7eb7ee0*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x7eb7eec*/ bool Equals(UnityEngine.Experimental.Playables.MaterialEffectPlayable other);
            }

            struct TextureMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Experimental.Playables.TextureMixerPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x7eb7f64*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x7eb7f70*/ bool Equals(UnityEngine.Experimental.Playables.TextureMixerPlayable other);
            }

            struct TexturePlayableOutput : UnityEngine.Playables.IPlayableOutput
            {
                /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

                /*0x7eb7fe8*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            }
        }

        namespace Rendering
        {
            class BuiltinRuntimeReflectionSystem : UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem, System.IDisposable
            {
                static /*0x7eb801c*/ bool BuiltinUpdate();
                static /*0x7eb804c*/ UnityEngine.Experimental.Rendering.BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New();
                /*0x7eb80a0*/ BuiltinRuntimeReflectionSystem();
                /*0x7eb7ff4*/ bool TickRealtimeProbes();
                /*0x7eb8044*/ void Dispose();
                /*0x7eb8048*/ void Dispose(bool disposing);
            }

            interface IScriptableRuntimeReflectionSystem : System.IDisposable
            {
                /*0x380b128*/ bool TickRealtimeProbes();
            }

            class ScriptableRuntimeReflectionSystemSettings
            {
                static /*0x0*/ UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper s_Instance;

                static /*0x7eb8274*/ ScriptableRuntimeReflectionSystemSettings();
                static /*0x7eb80a8*/ void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value);
                static /*0x7eb81f4*/ UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance();
                static /*0x7eb824c*/ void ScriptingDirtyReflectionSystemInstance();
            }

            class ScriptableRuntimeReflectionSystemWrapper
            {
                /*0x10*/ UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem <implementation>k__BackingField;

                /*0x7eb82f0*/ ScriptableRuntimeReflectionSystemWrapper();
                /*0x7eb82f8*/ UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem get_implementation();
                /*0x7eb8300*/ void set_implementation(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value);
                /*0x7eb8308*/ void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(ref bool result);
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

                static /*0x7eb9120*/ GraphicsFormatUtility();
                static /*0x7eb83c8*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Texture texture);
                static /*0x7eb84d0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.TextureFormat format, bool isSRGB);
                static /*0x7eb8554*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_TextureFormat(UnityEngine.TextureFormat format, bool isSRGB);
                static /*0x7eb8598*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, bool isSRGB);
                static /*0x7eb861c*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(UnityEngine.RenderTextureFormat format, bool isSRGB);
                static /*0x7eb8660*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
                static /*0x7eb86e8*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits);
                static /*0x7eb8724*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormat(int depthBits);
                static /*0x7eb8798*/ int GetDepthBits(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb87d4*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits);
                static /*0x7eb89cc*/ bool IsSRGBFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8a08*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetSRGBFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8a44*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetLinearFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8a80*/ UnityEngine.RenderTextureFormat GetRenderTextureFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8abc*/ uint GetAlphaComponentCount(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8af8*/ uint GetComponentCount(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8b34*/ string GetFormatString(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8c6c*/ bool IsCompressedFormat_Native_TextureFormat(UnityEngine.TextureFormat format);
                static /*0x7eb8ca8*/ bool IsCompressedFormat(UnityEngine.TextureFormat format);
                static /*0x7eb8d1c*/ bool CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, bool wholeImage);
                static /*0x7eb8d60*/ bool CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8dd8*/ bool IsAlphaOnlyFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8e14*/ bool HasAlphaChannel(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8e50*/ bool IsDepthFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8e8c*/ bool IsStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8ec8*/ bool IsDepthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8f04*/ bool IsFloatFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8f40*/ bool IsHalfFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8f7c*/ bool IsPVRTCFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8fb8*/ bool IsCrunchFormat(UnityEngine.TextureFormat format);
                static /*0x7eb8ff4*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleR(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb9030*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleG(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb906c*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleB(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb90a8*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleA(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb90e4*/ uint GetBlockSize(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7eb8494*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat_Injected(nint texture);
                static /*0x7eb8c28*/ void GetFormatString_Injected(UnityEngine.Experimental.Rendering.GraphicsFormat format, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
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
            static /*0x7eb9204*/ UnityEngine.Vector4 GetInnerUV(UnityEngine.Sprite sprite);
            static /*0x7eb9218*/ UnityEngine.Vector4 GetOuterUV(UnityEngine.Sprite sprite);
            static /*0x7eb922c*/ UnityEngine.Vector4 GetPadding(UnityEngine.Sprite sprite);
            static /*0x7eb9240*/ UnityEngine.Vector2 GetMinSize(UnityEngine.Sprite sprite);
        }
    }

    namespace U2D
    {
        class PixelPerfectRendering
        {
            static /*0x7eb92a0*/ void set_pixelSnapSpacing(float value);
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
        }

        class SpriteAtlasManager
        {
            static /*0x0*/ System.Action<string, System.Action<UnityEngine.U2D.SpriteAtlas>> atlasRequested;
            static /*0x8*/ System.Action<UnityEngine.U2D.SpriteAtlas> atlasRegistered;

            static /*0x7eb92d8*/ bool RequestAtlas(string tag);
            static /*0x7eb938c*/ void add_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value);
            static /*0x7eb945c*/ void remove_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value);
            static /*0x7eb952c*/ void PostRegisteredAtlas(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x7eb9598*/ void Register(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x7eb961c*/ void Register_Injected(nint spriteAtlas);
        }

        class SpriteAtlas : UnityEngine.Object
        {
            static /*0x7eb96d0*/ int get_spriteCount_Injected(nint _unity_self);
            static /*0x7eb97f0*/ bool CanBindTo_Injected(nint _unity_self, nint sprite);
            static /*0x7eb9a28*/ nint GetSprite_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            static /*0x7eb9af0*/ int GetSpritesScripting_Injected(nint _unity_self, UnityEngine.Sprite[] sprites);
            /*0x7eb9b34*/ SpriteAtlas();
            /*0x7eb9658*/ int get_spriteCount();
            /*0x7eb970c*/ bool CanBindTo(UnityEngine.Sprite sprite);
            /*0x7eb9834*/ UnityEngine.Sprite GetSprite(string name);
            /*0x7eb9a6c*/ int GetSprites(UnityEngine.Sprite[] sprites);
            /*0x7eb9a70*/ int GetSpritesScripting(UnityEngine.Sprite[] sprites);
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
