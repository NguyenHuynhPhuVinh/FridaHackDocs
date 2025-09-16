class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x7e094b8*/ EmbeddedAttribute();
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
                /*0x7e094c0*/ IsUnmanagedAttribute();
            }
        }
    }
}

namespace AOT
{
    class MonoPInvokeCallbackAttribute : System.Attribute
    {
        /*0x7e094c8*/ MonoPInvokeCallbackAttribute(System.Type type);
    }
}

namespace UnityEngineInternal
{
    struct MathfInternal
    {
        static /*0x0*/ float FloatMinNormal;
        static /*0x4*/ float FloatMinDenormal;
        static /*0x8*/ bool IsFlushToZeroEnabled;

        static /*0x7e094d0*/ MathfInternal();
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

        /*0x7e09568*/ TypeInferenceRuleAttribute(UnityEngineInternal.TypeInferenceRules rule);
        /*0x7e095f8*/ TypeInferenceRuleAttribute(string rule);
        /*0x7e09628*/ string ToString();
    }

    class GenericStack : System.Collections.Stack
    {
        /*0x7e09630*/ GenericStack();
    }
}

namespace Unity
{
    namespace Jobs
    {
        interface IJob
        {
            /*0x38159dc*/ void Execute();
        }

        class IJobExtensions
        {
            static /*0x383e7a0*/ void EarlyJobInit<T>();
            static nint GetReflectionData<T>();
            static /*0x3910ae8*/ Unity.Jobs.JobHandle Schedule<T>(T jobData, Unity.Jobs.JobHandle dependsOn);
            static /*0x3910ae8*/ void Run<T>(T jobData);

            struct JobStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x383e7a0*/ JobStruct();
                static /*0x383e7a0*/ void Initialize();
                static /*0x3843798*/ void Execute(ref T data, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

                class ExecuteJobFunction<T> : System.MulticastDelegate
                {
                    ExecuteJobFunction(object object, nint method);
                    void Invoke(ref T data, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);
                }
            }
        }

        interface IJobFor
        {
            /*0x3815ed0*/ void Execute(int index);
        }

        class IJobForExtensions
        {
            static /*0x383e7a0*/ void EarlyJobInit<T>();
            static nint GetReflectionData<T>();
            static /*0x3910ae8*/ Unity.Jobs.JobHandle ScheduleParallel<T>(T jobData, int arrayLength, int innerloopBatchCount, Unity.Jobs.JobHandle dependency);

            struct ForJobStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x383e7a0*/ ForJobStruct();
                static /*0x383e7a0*/ void Initialize();
                static /*0x3843798*/ void Execute(ref T jobData, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

                class ExecuteJobFunction<T> : System.MulticastDelegate
                {
                    ExecuteJobFunction(object object, nint method);
                    void Invoke(ref T data, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);
                }
            }
        }

        interface IJobParallelFor
        {
            /*0x3815ed0*/ void Execute(int index);
        }

        class IJobParallelForExtensions
        {
            static /*0x383e7a0*/ void EarlyJobInit<T>();
            static nint GetReflectionData<T>();
            static /*0x3910ae8*/ Unity.Jobs.JobHandle Schedule<T>(T jobData, int arrayLength, int innerloopBatchCount, Unity.Jobs.JobHandle dependsOn);
            static /*0x3910ae8*/ void Run<T>(T jobData, int arrayLength);

            struct ParallelForJobStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x383e7a0*/ ParallelForJobStruct();
                static /*0x383e7a0*/ void Initialize();
                static /*0x3843798*/ void Execute(ref T jobData, nint additionalPtr, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

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

            static /*0x7e0973c*/ void ScheduleBatchedJobs();
            static /*0x7e09688*/ void ScheduleBatchedJobsAndComplete(ref Unity.Jobs.JobHandle job);
            static /*0x7e09700*/ bool ScheduleBatchedJobsAndIsCompleted(ref Unity.Jobs.JobHandle job);
            static /*0x7e09764*/ Unity.Jobs.JobHandle CombineDependencies(Unity.Jobs.JobHandle job0, Unity.Jobs.JobHandle job1);
            static /*0x7e097e8*/ Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeArray<Unity.Jobs.JobHandle> jobs);
            static /*0x7e098a4*/ Unity.Jobs.JobHandle CombineDependencies(Unity.Collections.NativeSlice<Unity.Jobs.JobHandle> jobs);
            static /*0x7e0978c*/ Unity.Jobs.JobHandle CombineDependenciesInternal2(ref Unity.Jobs.JobHandle job0, ref Unity.Jobs.JobHandle job1);
            static /*0x7e09848*/ Unity.Jobs.JobHandle CombineDependenciesInternalPtr(void* jobs, int count);
            static /*0x7e0993c*/ void CombineDependenciesInternal2_Injected(ref Unity.Jobs.JobHandle job0, ref Unity.Jobs.JobHandle job1, ref Unity.Jobs.JobHandle ret);
            static /*0x7e09990*/ void CombineDependenciesInternalPtr_Injected(void* jobs, int count, ref Unity.Jobs.JobHandle ret);
            /*0x7e09638*/ void Complete();
            /*0x7e096c4*/ bool get_IsCompleted();
            /*0x7e099e4*/ bool Equals(Unity.Jobs.JobHandle other);
        }

        namespace LowLevel
        {
            namespace Unsafe
            {
                class JobProducerTypeAttribute : System.Attribute
                {
                    /*0x10*/ System.Type <ProducerType>k__BackingField;

                    /*0x7e099f4*/ JobProducerTypeAttribute(System.Type producerType);
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

                    static /*0x7e09a24*/ void GetJobRange(ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex, ref int beginIndex, ref int endIndex);
                    static /*0x7e09a6c*/ bool GetWorkStealingRange(ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex, ref int beginIndex, ref int endIndex);
                    static /*0x7e09ac8*/ Unity.Jobs.JobHandle Schedule(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters);
                    static /*0x7e09b60*/ Unity.Jobs.JobHandle ScheduleParallelFor(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount);
                    static /*0x7e09c28*/ Unity.Jobs.JobHandle ScheduleParallelForTransform(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, nint transfromAccesssArray);
                    static /*0x7e09cd8*/ nint CreateJobReflectionData(System.Type wrapperJobType, System.Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2);
                    static /*0x7e09d44*/ nint CreateJobReflectionData(System.Type type, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2);
                    static /*0x7e09da4*/ bool get_IsExecutingJob();
                    static /*0x7e09dcc*/ void set_JobCompilerEnabled(bool value);
                    static /*0x7e09e08*/ int GetJobQueueWorkerThreadCount();
                    static /*0x7e09e30*/ int get_JobWorkerCount();
                    static /*0x7e09e58*/ int get_ThreadIndex();
                    static /*0x7e09e80*/ int get_ThreadIndexCount();
                    static /*0x7e09ea8*/ void InvokePanicFunction();
                    static /*0x7e09b1c*/ void Schedule_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, ref Unity.Jobs.JobHandle ret);
                    static /*0x7e09bcc*/ void ScheduleParallelFor_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, int arrayLength, int innerloopBatchCount, ref Unity.Jobs.JobHandle ret);
                    static /*0x7e09c84*/ void ScheduleParallelForTransform_Injected(ref Unity.Jobs.LowLevel.Unsafe.JobsUtility.JobScheduleParameters parameters, nint transfromAccesssArray, ref Unity.Jobs.JobHandle ret);

                    struct JobScheduleParameters
                    {
                        /*0x10*/ Unity.Jobs.JobHandle Dependency;
                        /*0x20*/ int ScheduleMode;
                        /*0x28*/ nint ReflectionData;
                        /*0x30*/ nint JobDataPtr;

                        /*0x7e09f0c*/ JobScheduleParameters(void* i_jobData, nint i_reflectionData, Unity.Jobs.JobHandle i_dependency, Unity.Jobs.LowLevel.Unsafe.ScheduleMode i_scheduleMode);
                    }

                    class PanicFunction_ : System.MulticastDelegate
                    {
                        /*0x7e09f44*/ PanicFunction_(object object, nint method);
                        /*0x7e09fe0*/ void Invoke();
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

            static /*0x7e0a4c0*/ DiscreteTime();
            static /*0x7e0a1d8*/ Unity.IntegerTime.DiscreteTime FromTicks(long v);
            static /*0x7e0a1dc*/ float op_Explicit(Unity.IntegerTime.DiscreteTime d);
            static /*0x7e0a1f4*/ double op_Explicit(Unity.IntegerTime.DiscreteTime d);
            static /*0x7e0a208*/ bool op_Inequality(Unity.IntegerTime.DiscreteTime lhs, Unity.IntegerTime.DiscreteTime rhs);
            static /*0x7e0a214*/ bool op_GreaterThan(Unity.IntegerTime.DiscreteTime lhs, Unity.IntegerTime.DiscreteTime rhs);
            static /*0x7e0a220*/ bool op_GreaterThanOrEqual(Unity.IntegerTime.DiscreteTime lhs, Unity.IntegerTime.DiscreteTime rhs);
            static /*0x7e0a22c*/ Unity.IntegerTime.DiscreteTime op_Addition(Unity.IntegerTime.DiscreteTime lhs, Unity.IntegerTime.DiscreteTime rhs);
            static /*0x7e0a28c*/ Unity.IntegerTime.DiscreteTime op_Subtraction(Unity.IntegerTime.DiscreteTime lhs, Unity.IntegerTime.DiscreteTime rhs);
            /*0x7e09ff4*/ DiscreteTime(float v);
            /*0x7e0a0e4*/ DiscreteTime(double v);
            /*0x7e0a1d0*/ DiscreteTime(long v, int _);
            /*0x7e0a2ec*/ bool Equals(Unity.IntegerTime.DiscreteTime rhs);
            /*0x7e0a2fc*/ bool Equals(object o);
            /*0x7e0a398*/ int GetHashCode();
            /*0x7e0a3a0*/ string ToString();
            /*0x7e0a420*/ string ToString(string format, System.IFormatProvider formatProvider);
            /*0x7e0a4b8*/ int CompareTo(Unity.IntegerTime.DiscreteTime other);
        }

        struct RationalTime
        {
            /*0x10*/ long m_Count;
            /*0x18*/ Unity.IntegerTime.RationalTime.TicksPerSecond m_TicksPerSecond;

            static /*0x7e0a608*/ Unity.IntegerTime.DiscreteTime op_Explicit(Unity.IntegerTime.RationalTime t);
            /*0x7e0a600*/ long get_Count();

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

                static /*0x7e0a980*/ TicksPerSecond();
                static /*0x7e0a774*/ void Simplify(ref uint num, ref uint den);
                static /*0x7e0a954*/ uint Gcd(uint a, uint b);
                /*0x7e0a700*/ TicksPerSecond(uint num, uint den);
                /*0x7e0a81c*/ bool Equals(Unity.IntegerTime.RationalTime.TicksPerSecond rhs);
                /*0x7e0a844*/ bool Equals(object rhs);
                /*0x7e0a8e0*/ int GetHashCode();
            }
        }

        class RationalTimeExtensions
        {
            static /*0x7e0a6ac*/ Unity.IntegerTime.RationalTime Convert(Unity.IntegerTime.RationalTime time, Unity.IntegerTime.RationalTime.TicksPerSecond rate);
            static /*0x7e0aba4*/ void Convert_Injected(ref Unity.IntegerTime.RationalTime time, ref Unity.IntegerTime.RationalTime.TicksPerSecond rate, ref Unity.IntegerTime.RationalTime ret);
        }
    }

    namespace IL2CPP
    {
        namespace CompilerServices
        {
            class Il2CppEagerStaticClassConstructionAttribute : System.Attribute
            {
                /*0x7e0abf8*/ Il2CppEagerStaticClassConstructionAttribute();
            }
        }
    }

    namespace Profiling
    {
        class IgnoredByDeepProfilerAttribute : System.Attribute
        {
            /*0x7e0ac00*/ IgnoredByDeepProfilerAttribute();
        }

        struct ProfilerCategory
        {
            /*0x10*/ ushort m_CategoryId;

            static /*0x7e0afa8*/ Unity.Profiling.ProfilerCategory get_Render();
            static /*0x7e0afb0*/ Unity.Profiling.ProfilerCategory get_Scripts();
            static /*0x7e0afb8*/ Unity.Profiling.ProfilerCategory get_Loading();
            static /*0x7e0afc0*/ ushort op_Implicit(Unity.Profiling.ProfilerCategory category);
            /*0x7e0ac08*/ ProfilerCategory(string categoryName, Unity.Profiling.ProfilerCategoryColor color);
            /*0x7e0ada0*/ ProfilerCategory(ushort category);
            /*0x7e0ada8*/ string get_Name();
            /*0x7e0afa4*/ string ToString();
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

            /*0x7e0afc4*/ ProfilerMarker(string name);
            /*0x7e0b180*/ ProfilerMarker(Unity.Profiling.ProfilerCategory category, string name);
            /*0x7e0b1a4*/ Unity.Profiling.ProfilerMarker.AutoScope Auto();

            struct AutoScope : System.IDisposable
            {
                /*0x10*/ nint m_Ptr;

                /*0x7e0b1ec*/ AutoScope(nint markerPtr);
                /*0x7e0b278*/ void Dispose();
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

            /*0x7e0b300*/ long get_Count();
        }

        struct ProfilerRecorder : System.IDisposable
        {
            static Unity.Profiling.ProfilerRecorderOptions SharedRecorder = 128;
            /*0x10*/ ulong handle;

            static /*0x7e0b3cc*/ Unity.Profiling.ProfilerRecorder StartNew(Unity.Profiling.ProfilerCategory category, string statName, int capacity, Unity.Profiling.ProfilerRecorderOptions options);
            static /*0x7e0b348*/ Unity.Profiling.ProfilerRecorder Create(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int maxSampleCount, Unity.Profiling.ProfilerRecorderOptions options);
            static /*0x7e0b568*/ void Control(Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.ControlOptions options);
            static /*0x7e0b64c*/ long GetLastValue(Unity.Profiling.ProfilerRecorder handle);
            static /*0x7e0b6dc*/ int GetCount(Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.CountOptions countOptions);
            static /*0x7e0b478*/ bool GetValid(Unity.Profiling.ProfilerRecorder handle);
            static /*0x7e0b774*/ bool GetRunning(Unity.Profiling.ProfilerRecorder handle);
            static /*0x7e0b80c*/ Unity.Profiling.ProfilerRecorderSample GetSampleInternal(Unity.Profiling.ProfilerRecorder handle, int index);
            static /*0x7e0b878*/ void Create_Injected(ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int maxSampleCount, Unity.Profiling.ProfilerRecorderOptions options, ref Unity.Profiling.ProfilerRecorder ret);
            static /*0x7e0b8d4*/ void Control_Injected(ref Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.ControlOptions options);
            static /*0x7e0b918*/ long GetLastValue_Injected(ref Unity.Profiling.ProfilerRecorder handle);
            static /*0x7e0b954*/ int GetCount_Injected(ref Unity.Profiling.ProfilerRecorder handle, Unity.Profiling.ProfilerRecorder.CountOptions countOptions);
            static /*0x7e0b998*/ bool GetValid_Injected(ref Unity.Profiling.ProfilerRecorder handle);
            static /*0x7e0b9d4*/ bool GetRunning_Injected(ref Unity.Profiling.ProfilerRecorder handle);
            static /*0x7e0ba10*/ void GetSampleInternal_Injected(ref Unity.Profiling.ProfilerRecorder handle, int index, ref Unity.Profiling.ProfilerRecorderSample ret);
            /*0x7e0b308*/ ProfilerRecorder(Unity.Profiling.ProfilerCategory category, char* statName, int statNameLen, int capacity, Unity.Profiling.ProfilerRecorderOptions options);
            /*0x7e0b3a8*/ ProfilerRecorder(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle statHandle, int capacity, Unity.Profiling.ProfilerRecorderOptions options);
            /*0x7e0b424*/ bool get_Valid();
            /*0x7e0b4bc*/ void Start();
            /*0x7e0b5b0*/ void Stop();
            /*0x7e0b600*/ long get_LastValue();
            /*0x7e0b68c*/ int get_Count();
            /*0x7e0b724*/ bool get_IsRunning();
            /*0x7e0b7b8*/ Unity.Profiling.ProfilerRecorderSample GetSample(int index);
            /*0x7e0ba64*/ void Dispose();
            /*0x7e0b50c*/ void CheckInitializedAndThrow();

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

            /*0x7e0bab8*/ void set_RawImageDataReference(Unity.Collections.NativeArray<byte> value);
            /*0x7e0bac0*/ void set_ImageFormat(UnityEngine.TextureFormat value);
            /*0x7e0bac8*/ void set_Width(int value);
            /*0x7e0bad0*/ void set_Height(int value);
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

                    /*0x7e0bad8*/ Unity.Profiling.LowLevel.MarkerFlags get_Flags();
                }

                struct ProfilerRecorderHandle
                {
                    /*0x10*/ ulong handle;

                    static /*0x7e0bafc*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescription(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle);
                    static /*0x7e0bc48*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName__Unmanaged(Unity.Profiling.ProfilerCategory category, byte* name, int nameLen);
                    static /*0x7e0bd08*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName(Unity.Profiling.ProfilerCategory category, char* name, int nameLen);
                    static /*0x7e0bd10*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle GetByName_Unsafe(Unity.Profiling.ProfilerCategory category, char* name, int nameLen);
                    static /*0x7e0bbc4*/ Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription GetDescriptionInternal(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle);
                    static /*0x7e0bcac*/ void GetByName__Unmanaged_Injected(ref Unity.Profiling.ProfilerCategory category, byte* name, int nameLen, ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ret);
                    static /*0x7e0bd74*/ void GetByName_Unsafe_Injected(ref Unity.Profiling.ProfilerCategory category, char* name, int nameLen, ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle ret);
                    static /*0x7e0bdd0*/ void GetDescriptionInternal_Injected(ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle, ref Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription ret);
                    /*0x7e0bae0*/ ProfilerRecorderHandle(ulong handle);
                    /*0x7e0bae8*/ bool get_Valid();
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
                    static /*0x7e0ac28*/ ushort CreateCategory(string name, Unity.Profiling.ProfilerCategoryColor colorIndex);
                    static /*0x7e0be58*/ ushort CreateCategory__Unmanaged(byte* name, int nameLen, Unity.Profiling.ProfilerCategoryColor colorIndex);
                    static /*0x7e0ae28*/ Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription GetCategoryDescription(ushort categoryId);
                    static /*0x7e0aff0*/ nint CreateMarker(string name, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, int metadataCount);
                    static /*0x7e0bf4c*/ nint CreateMarker__Unmanaged(byte* name, int nameLen, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, int metadataCount);
                    static /*0x7e0bfb8*/ void SetMarkerMetadata__Unmanaged(nint markerPtr, int index, byte* name, int nameLen, byte type, byte unit);
                    static /*0x7e0b23c*/ void BeginSample(nint markerPtr);
                    static /*0x7e0b2c4*/ void EndSample(nint markerPtr);
                    static /*0x7e0c02c*/ void* CreateCounterValue__Unmanaged(ref nint counterPtr, byte* name, int nameLen, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, byte dataType, byte dataUnit, int dataSize, Unity.Profiling.ProfilerCounterOptions counterOptions);
                    static /*0x7e0aeb8*/ string Utf8ToString(byte* chars, int charsLen);
                    static /*0x7e0be14*/ ushort CreateCategory_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, Unity.Profiling.ProfilerCategoryColor colorIndex);
                    static /*0x7e0beac*/ void GetCategoryDescription_Injected(ushort categoryId, ref Unity.Profiling.LowLevel.Unsafe.ProfilerCategoryDescription ret);
                    static /*0x7e0bef0*/ nint CreateMarker_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, int metadataCount);
                }
            }
        }

        namespace Memory
        {
            class MemorySnapshotMetadata
            {
                /*0x10*/ string <Description>k__BackingField;
                /*0x18*/ byte[] <Data>k__BackingField;

                /*0x7e0c0e0*/ MemorySnapshotMetadata();
                /*0x7e0c0c8*/ string get_Description();
                /*0x7e0c0d0*/ void set_Description(string value);
                /*0x7e0c0d8*/ byte[] get_Data();
            }

            class MemoryProfiler
            {
                static /*0x0*/ System.Action<string, bool> m_SnapshotFinished;
                static /*0x8*/ System.Action<string, bool, Unity.Profiling.DebugScreenCapture> m_SaveScreenshotToDisk;
                static /*0x10*/ System.Action<Unity.Profiling.Memory.MemorySnapshotMetadata> CreatingMetadata;

                static /*0x7e0c0e8*/ byte[] PrepareMetadata();
                static /*0x7e0c2f0*/ int WriteIntToByteArray(byte[] array, int offset, int value);
                static /*0x7e0c37c*/ int WriteStringToByteArray(byte[] array, int offset, string value);
                static /*0x7e0c46c*/ void FinalizeSnapshot(string path, bool result);
                static /*0x7e0c500*/ void SaveScreenshotToDisk(string path, bool result, nint pixelsPtr, int pixelsCount, UnityEngine.TextureFormat format, int width, int height);
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

                    static /*0x7e0c694*/ bool IsFileHandleValid(ref Unity.IO.LowLevel.Unsafe.FileHandle handle);
                    static /*0x7e0c6d0*/ Unity.Jobs.JobHandle GetJobHandle_Internal(ref Unity.IO.LowLevel.Unsafe.FileHandle handle);
                    static /*0x7e0c864*/ void GetJobHandle_Internal_Injected(ref Unity.IO.LowLevel.Unsafe.FileHandle handle, ref Unity.Jobs.JobHandle ret);
                    /*0x7e0c604*/ Unity.Jobs.JobHandle get_JobHandle();
                    /*0x7e0c724*/ bool IsValid();
                    /*0x7e0c760*/ Unity.Jobs.JobHandle Close(Unity.Jobs.JobHandle dependency);
                }

                struct ReadHandle : System.IDisposable
                {
                    /*0x10*/ nint ptr;
                    /*0x18*/ int version;

                    static /*0x7e0caac*/ void CancelInternal(Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7e0cbe0*/ Unity.IO.LowLevel.Unsafe.ReadStatus GetReadStatus(Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7e0ca00*/ void ReleaseReadHandle(Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7e0c8b4*/ bool IsReadHandleValid(Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7e0cb94*/ Unity.Jobs.JobHandle GetJobHandle(Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7e0caec*/ void CancelInternal_Injected(ref Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7e0cc20*/ Unity.IO.LowLevel.Unsafe.ReadStatus GetReadStatus_Injected(ref Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7e0cc5c*/ void ReleaseReadHandle_Injected(ref Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7e0cc98*/ bool IsReadHandleValid_Injected(ref Unity.IO.LowLevel.Unsafe.ReadHandle handle);
                    static /*0x7e0ccd4*/ void GetJobHandle_Injected(ref Unity.IO.LowLevel.Unsafe.ReadHandle handle, ref Unity.Jobs.JobHandle ret);
                    /*0x7e0c8a8*/ bool IsValid();
                    /*0x7e0c8f8*/ void Dispose();
                    /*0x7e0ca40*/ void Cancel();
                    /*0x7e0cb28*/ Unity.Jobs.JobHandle get_JobHandle();
                    /*0x7e0c994*/ Unity.IO.LowLevel.Unsafe.ReadStatus get_Status();
                }

                class AsyncReadManager
                {
                    static /*0x7e0cd18*/ Unity.IO.LowLevel.Unsafe.ReadHandle GetFileInfoInternal(string filename, void* cmd);
                    static /*0x7e0cf04*/ Unity.IO.LowLevel.Unsafe.ReadHandle GetFileInfo(string filename, Unity.IO.LowLevel.Unsafe.FileInfoResult* result);
                    static /*0x7e0cf58*/ Unity.IO.LowLevel.Unsafe.ReadHandle ReadWithHandlesInternal_NativeCopy(ref Unity.IO.LowLevel.Unsafe.FileHandle fileHandle, void* readCmdArray);
                    static /*0x7e0d008*/ Unity.IO.LowLevel.Unsafe.ReadHandle Read(ref Unity.IO.LowLevel.Unsafe.FileHandle fileHandle, Unity.IO.LowLevel.Unsafe.ReadCommandArray readCmdArray);
                    static /*0x7e0d0ac*/ Unity.IO.LowLevel.Unsafe.FileHandle OpenFileAsync_Internal(string fileName);
                    static /*0x7e0d280*/ Unity.IO.LowLevel.Unsafe.FileHandle OpenFileAsync(string fileName);
                    static /*0x7e0c808*/ Unity.Jobs.JobHandle CloseFileAsync(ref Unity.IO.LowLevel.Unsafe.FileHandle fileHandle, Unity.Jobs.JobHandle dependency);
                    static /*0x7e0ceb0*/ void GetFileInfoInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper filename, void* cmd, ref Unity.IO.LowLevel.Unsafe.ReadHandle ret);
                    static /*0x7e0cfb4*/ void ReadWithHandlesInternal_NativeCopy_Injected(ref Unity.IO.LowLevel.Unsafe.FileHandle fileHandle, void* readCmdArray, ref Unity.IO.LowLevel.Unsafe.ReadHandle ret);
                    static /*0x7e0d23c*/ void OpenFileAsync_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper fileName, ref Unity.IO.LowLevel.Unsafe.FileHandle ret);
                    static /*0x7e0d2e4*/ void CloseFileAsync_Injected(ref Unity.IO.LowLevel.Unsafe.FileHandle fileHandle, ref Unity.Jobs.JobHandle dependency, ref Unity.Jobs.JobHandle ret);
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
            static /*0x38395d4*/ string SerializedView<T>(System.Collections.Generic.IEnumerable<T> collection, System.Func<T, string> serializeElement);

            class <>c__DisplayClass3_0<T>
            {
                /*0x0*/ System.Func<T, string> serializeElement;

                /*0x38159dc*/ <>c__DisplayClass3_0();
                /*0x3910ae8*/ string <SerializedView>b__0(T t);
            }
        }

        class ReadOnlyAttribute : System.Attribute
        {
            /*0x7e0d338*/ ReadOnlyAttribute();
        }

        class WriteOnlyAttribute : System.Attribute
        {
            /*0x7e0d340*/ WriteOnlyAttribute();
        }

        class DeallocateOnJobCompletionAttribute : System.Attribute
        {
            /*0x7e0d348*/ DeallocateOnJobCompletionAttribute();
        }

        class NativeFixedLengthAttribute : System.Attribute
        {
        }

        class NativeMatchesParallelForLengthAttribute : System.Attribute
        {
        }

        class NativeDisableParallelForRestrictionAttribute : System.Attribute
        {
            /*0x7e0d350*/ NativeDisableParallelForRestrictionAttribute();
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
            static /*0x3910ae8*/ bool op_Equality(Unity.Collections.NativeArray<T> left, Unity.Collections.NativeArray<T> right);
            static /*0x3910ae8*/ void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst);
            static /*0x3910ae8*/ void Copy(T[] src, Unity.Collections.NativeArray<T> dst);
            static /*0x3910ae8*/ void Copy(Unity.Collections.NativeArray<T> src, T[] dst);
            static /*0x3910ae8*/ void Copy(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst, int length);
            static /*0x3910ae8*/ void Copy(Unity.Collections.NativeArray<T> src, T[] dst, int length);
            static /*0x3910ae8*/ void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
            static /*0x3910ae8*/ void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length);
            static /*0x3910ae8*/ void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
            static /*0x3910ae8*/ void CopySafe(T[] src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
            static /*0x3910ae8*/ void CopySafe(Unity.Collections.NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length);
            static /*0x3910ae8*/ System.Span<T> op_Implicit(ref Unity.Collections.NativeArray<T> source);
            static /*0x3910ae8*/ System.ReadOnlySpan<T> op_Implicit(ref Unity.Collections.NativeArray<T> source);
            NativeArray(int length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options);
            /*0x381678c*/ NativeArray(T[] array, Unity.Collections.Allocator allocator);
            /*0x3910ae8*/ NativeArray(Unity.Collections.NativeArray<T> array, Unity.Collections.Allocator allocator);
            /*0x3814574*/ int get_Length();
            /*0x3910ae8*/ T get_Item(int index);
            /*0x3910ae8*/ void set_Item(int index, T value);
            /*0x3813ffc*/ bool get_IsCreated();
            /*0x38159dc*/ void Dispose();
            /*0x3910ae8*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
            /*0x3816710*/ void CopyFrom(T[] array);
            /*0x3910ae8*/ void CopyFrom(Unity.Collections.NativeArray<T> array);
            /*0x3816710*/ void CopyTo(T[] array);
            /*0x38148bc*/ T[] ToArray();
            /*0x3910ae8*/ Unity.Collections.NativeArray.Enumerator<T> GetEnumerator();
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x3910ae8*/ bool Equals(Unity.Collections.NativeArray<T> other);
            /*0x38141c4*/ bool Equals(object obj);
            /*0x3814574*/ int GetHashCode();
            /*0x3910ae8*/ Unity.Collections.NativeArray<U> InternalReinterpret<U>(int length);
            /*0x3910ae8*/ Unity.Collections.NativeArray<U> Reinterpret<U>();
            /*0x3910ae8*/ Unity.Collections.NativeArray<U> Reinterpret<U>(int expectedTypeSize);
            /*0x3910ae8*/ Unity.Collections.NativeArray<T> GetSubArray(int start, int length);
            /*0x3910ae8*/ Unity.Collections.NativeArray.ReadOnly<T> AsReadOnly();
            /*0x3910ae8*/ System.Span<T> AsSpan();
            /*0x3910ae8*/ System.ReadOnlySpan<T> AsReadOnlySpan();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.NativeArray<T> m_Array;
                /*0x0*/ int m_Index;
                /*0x0*/ T value;

                /*0x3816710*/ Enumerator(ref Unity.Collections.NativeArray<T> array);
                /*0x38159dc*/ void Dispose();
                /*0x3813ffc*/ bool MoveNext();
                /*0x38159dc*/ void Reset();
                /*0x3910ae8*/ T get_Current();
                /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
            }

            struct ReadOnly<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
            {
                /*0x0*/ void* m_Buffer;
                /*0x0*/ int m_Length;

                static /*0x3910ae8*/ System.ReadOnlySpan<T> op_Implicit(ref Unity.Collections.NativeArray.ReadOnly<T> source);
                /*0x3910ae8*/ ReadOnly(void* buffer, int length);
                /*0x3814574*/ int get_Length();
                /*0x3910ae8*/ T get_Item(int index);
                /*0x3814964*/ ref T UnsafeElementAt(int index);
                /*0x3910ae8*/ Unity.Collections.NativeArray.ReadOnly.Enumerator<T> GetEnumerator();
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x3910ae8*/ System.ReadOnlySpan<T> AsReadOnlySpan();

                struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ Unity.Collections.NativeArray.ReadOnly<T> m_Array;
                    /*0x0*/ int m_Index;
                    /*0x0*/ T value;

                    /*0x3816710*/ Enumerator(ref Unity.Collections.NativeArray.ReadOnly<T> array);
                    /*0x38159dc*/ void Dispose();
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x38159dc*/ void Reset();
                    /*0x3910ae8*/ T get_Current();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                }
            }
        }

        struct NativeArrayDispose
        {
            /*0x10*/ void* m_Buffer;
            /*0x18*/ Unity.Collections.Allocator m_AllocatorLabel;

            /*0x7e0d358*/ void Dispose();
        }

        struct NativeArrayDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ Unity.Collections.NativeArrayDispose Data;

            static /*0x7e0d424*/ void RegisterNativeArrayDisposeJobReflectionData();
            /*0x7e0d3e0*/ void Execute();
        }

        class NativeArrayDebugView<T>
        {
        }

        class NativeArrayReadOnlyDebugView<T>
        {
        }

        class NativeSliceExtensions
        {
            static /*0x3910ae8*/ Unity.Collections.NativeSlice<T> Slice<T>(Unity.Collections.NativeArray<T> thisArray, int start, int length);
            static /*0x3910ae8*/ Unity.Collections.NativeSlice<T> Slice<T>(Unity.Collections.NativeSlice<T> thisSlice, int start, int length);
        }

        struct NativeSlice<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.NativeSlice<T>>
        {
            /*0x0*/ byte* m_Buffer;
            /*0x0*/ int m_Stride;
            /*0x0*/ int m_Length;

            static /*0x3910ae8*/ Unity.Collections.NativeSlice<T> op_Implicit(Unity.Collections.NativeArray<T> array);
            /*0x3910ae8*/ NativeSlice(Unity.Collections.NativeSlice<T> slice, int start, int length);
            /*0x3910ae8*/ NativeSlice(Unity.Collections.NativeArray<T> array);
            /*0x3910ae8*/ NativeSlice(Unity.Collections.NativeArray<T> array, int start, int length);
            /*0x3910ae8*/ T get_Item(int index);
            /*0x3910ae8*/ void set_Item(int index, T value);
            /*0x3910ae8*/ void CopyFrom(Unity.Collections.NativeSlice<T> slice);
            /*0x3814574*/ int get_Stride();
            /*0x3814574*/ int get_Length();
            /*0x3910ae8*/ Unity.Collections.NativeSlice.Enumerator<T> GetEnumerator();
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x3910ae8*/ bool Equals(Unity.Collections.NativeSlice<T> other);
            /*0x38141c4*/ bool Equals(object obj);
            /*0x3814574*/ int GetHashCode();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.NativeSlice<T> m_Array;
                /*0x0*/ int m_Index;

                /*0x3816710*/ Enumerator(ref Unity.Collections.NativeSlice<T> array);
                /*0x38159dc*/ void Dispose();
                /*0x3813ffc*/ bool MoveNext();
                /*0x38159dc*/ void Reset();
                /*0x3910ae8*/ T get_Current();
                /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
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

                        static /*0x3910ae8*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<T> GetOrCreate<TContext>(uint alignment);
                        /*0x3910ae8*/ SharedStatic(void* buffer);
                        /*0x38148bc*/ ref T get_Data();
                    }

                    class SharedStatic
                    {
                        static /*0x7e0d464*/ void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment);
                    }
                }

                class BurstRuntime
                {
                    static /*0x3835328*/ long GetHashCode64<T>();
                    static /*0x7e0d52c*/ long HashStringWithFNV1A64(string text);

                    struct HashCode64<T>
                    {
                        static /*0x0*/ long Value;

                        static /*0x383e7a0*/ HashCode64();
                    }
                }

                class NativeContainerAttribute : System.Attribute
                {
                    /*0x7e0d5b8*/ NativeContainerAttribute();
                }

                class NativeContainerIsReadOnlyAttribute : System.Attribute
                {
                    /*0x7e0d5c0*/ NativeContainerIsReadOnlyAttribute();
                }

                class NativeContainerIsAtomicWriteOnlyAttribute : System.Attribute
                {
                    /*0x7e0d5c8*/ NativeContainerIsAtomicWriteOnlyAttribute();
                }

                class NativeContainerSupportsMinMaxWriteRestrictionAttribute : System.Attribute
                {
                    /*0x7e0d5d0*/ NativeContainerSupportsMinMaxWriteRestrictionAttribute();
                }

                class NativeContainerSupportsDeallocateOnJobCompletionAttribute : System.Attribute
                {
                    /*0x7e0d5d8*/ NativeContainerSupportsDeallocateOnJobCompletionAttribute();
                }

                class NativeContainerSupportsDeferredConvertListToArray : System.Attribute
                {
                    /*0x7e0d5e0*/ NativeContainerSupportsDeferredConvertListToArray();
                }

                class NativeSetThreadIndexAttribute : System.Attribute
                {
                    /*0x7e0d5e8*/ NativeSetThreadIndexAttribute();
                }

                class NativeContainerNeedsThreadIndexAttribute : System.Attribute
                {
                }

                class WriteAccessRequiredAttribute : System.Attribute
                {
                    /*0x7e0d5f0*/ WriteAccessRequiredAttribute();
                }

                class NativeDisableUnsafePtrRestrictionAttribute : System.Attribute
                {
                    /*0x7e0d5f8*/ NativeDisableUnsafePtrRestrictionAttribute();
                }

                class NativeDisableContainerSafetyRestrictionAttribute : System.Attribute
                {
                    /*0x7e0d600*/ NativeDisableContainerSafetyRestrictionAttribute();
                }

                class NativeSetClassTypeToNullOnScheduleAttribute : System.Attribute
                {
                }

                class NativeArrayUnsafeUtility
                {
                    static /*0x3910ae8*/ Unity.Collections.NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Unity.Collections.Allocator allocator);
                    static /*0x3910ae8*/ void* GetUnsafePtr<T>(Unity.Collections.NativeArray<T> nativeArray);
                    static /*0x3910ae8*/ void* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeArray<T> nativeArray);
                    static /*0x3910ae8*/ void* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeArray.ReadOnly<T> nativeArray);
                    static /*0x3910ae8*/ void* GetUnsafeBufferPointerWithoutChecks<T>(Unity.Collections.NativeArray<T> nativeArray);
                }

                class NativeSliceUnsafeUtility
                {
                    static /*0x3910ae8*/ Unity.Collections.NativeSlice<T> ConvertExistingDataToNativeSlice<T>(void* dataPointer, int stride, int length);
                    static /*0x3910ae8*/ void* GetUnsafePtr<T>(Unity.Collections.NativeSlice<T> nativeSlice);
                    static /*0x3910ae8*/ void* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeSlice<T> nativeSlice);
                }

                class UnsafeUtility
                {
                    static /*0x3821564*/ bool IsBlittable<T>();
                    static /*0x7e0d608*/ int LeakRecord(nint handle, Unity.Collections.LeakCategory category, int callstacksToSkip);
                    static /*0x7e0d65c*/ int LeakErase(nint handle, Unity.Collections.LeakCategory category);
                    static /*0x7e0d6a0*/ void* MallocTracked(long size, int alignment, Unity.Collections.Allocator allocator, int callstacksToSkip);
                    static /*0x7e0d39c*/ void FreeTracked(void* memory, Unity.Collections.Allocator allocator);
                    static /*0x7e0d6fc*/ void* Malloc(long size, int alignment, Unity.Collections.Allocator allocator);
                    static /*0x7e0d750*/ void Free(void* memory, Unity.Collections.Allocator allocator);
                    static /*0x7e0c418*/ void MemCpy(void* destination, void* source, long size);
                    static /*0x7e0d794*/ void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count);
                    static /*0x7e0d808*/ void MemMove(void* destination, void* source, long size);
                    static /*0x7e0d85c*/ void MemSet(void* destination, byte value, long size);
                    static /*0x7e0d8b0*/ void MemClear(void* destination, long size);
                    static /*0x7e0d8f8*/ int MemCmp(void* ptr1, void* ptr2, long size);
                    static /*0x7e0d94c*/ int SizeOf(System.Type type);
                    static /*0x7e0d988*/ bool IsBlittable(System.Type type);
                    static /*0x7e0d9c4*/ bool IsBlittableValueType(System.Type t);
                    static /*0x7e0da24*/ string GetReasonForTypeNonBlittableImpl(System.Type t, string name);
                    static /*0x7e0dbe0*/ bool IsArrayBlittable(System.Array arr);
                    static /*0x3821564*/ bool IsGenericListBlittable<T>();
                    static /*0x7e0dc10*/ string GetReasonForArrayNonBlittable(System.Array arr);
                    static /*0x3836db8*/ string GetReasonForGenericListNonBlittable<T>();
                    static /*0x382ad0c*/ int AlignOf<T>();
                    static /*0x3910ae8*/ void CopyPtrToStructure<T>(void* ptr, ref T output);
                    static /*0x3910ae8*/ void InternalCopyPtrToStructure<T>(void* ptr, ref T output);
                    static /*0x3910ae8*/ T ReadArrayElement<T>(void* source, int index);
                    static /*0x3910ae8*/ T ReadArrayElementWithStride<T>(void* source, int index, int stride);
                    static /*0x3910ae8*/ void WriteArrayElement<T>(void* destination, int index, T value);
                    static /*0x3910ae8*/ void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value);
                    static /*0x3910ae8*/ void* AddressOf<T>(ref T output);
                    static /*0x382ad0c*/ int SizeOf<T>();
                    static /*0x38379c4*/ ref T As<U, T>(ref U from);
                    static /*0x3910ae8*/ T As<T>(object from);
                    static /*0x3910ae8*/ ref T AsRef<T>(void* ptr);
                    static /*0x3910ae8*/ ref T ArrayElementAsRef<T>(void* ptr, int index);
                    static /*0x3910ae8*/ int EnumToInt<T>(T enumValue);
                    static /*0x3843dfc*/ void InternalEnumToInt<T>(ref T enumValue, ref int intValue);
                    static /*0x3910ae8*/ bool EnumEquals<T>(T lhs, T rhs);

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
            /*0x7e0dc5c*/ BurstAuthorizedExternalMethodAttribute();
        }

        class BurstDiscardAttribute : System.Attribute
        {
            /*0x7e0dc64*/ BurstDiscardAttribute();
        }

        namespace LowLevel
        {
            class BurstCompilerService
            {
                static /*0x7e0dc6c*/ int CompileAsyncDelegateMethod(object delegateMethod, string compilerOptions);
                static /*0x7e0de28*/ void* GetAsyncCompiledAsyncDelegateMethod(int userID);
                static /*0x7e0d4d8*/ void* GetOrCreateSharedMemory(ref UnityEngine.Hash128 key, uint size_of, uint alignment);
                static /*0x7e0de64*/ void Log(void* userData, Unity.Burst.LowLevel.BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber);
                static /*0x7e0ded0*/ void RuntimeLog(void* userData, Unity.Burst.LowLevel.BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber);
                static /*0x7e0dde4*/ int CompileAsyncDelegateMethod_Injected(object delegateMethod, ref UnityEngine.Bindings.ManagedSpanWrapper compilerOptions);

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
            /*0x7e0df3c*/ CanBeNullAttribute();
        }

        class NotNullAttribute : System.Attribute
        {
            /*0x7e0df44*/ NotNullAttribute();
        }

        class UsedImplicitlyAttribute : System.Attribute
        {
            /*0x10*/ JetBrains.Annotations.ImplicitUseKindFlags <UseKindFlags>k__BackingField;
            /*0x14*/ JetBrains.Annotations.ImplicitUseTargetFlags <TargetFlags>k__BackingField;

            /*0x7e0df4c*/ UsedImplicitlyAttribute();
            /*0x7e0df70*/ UsedImplicitlyAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, JetBrains.Annotations.ImplicitUseTargetFlags targetFlags);
        }

        class MeansImplicitUseAttribute : System.Attribute
        {
            /*0x10*/ JetBrains.Annotations.ImplicitUseKindFlags <UseKindFlags>k__BackingField;
            /*0x14*/ JetBrains.Annotations.ImplicitUseTargetFlags <TargetFlags>k__BackingField;

            /*0x7e0df9c*/ MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags);
            /*0x7e0dfc8*/ MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, JetBrains.Annotations.ImplicitUseTargetFlags targetFlags);
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
            /*0x7e0dff4*/ PureAttribute();
        }

        class MustUseReturnValueAttribute : System.Attribute
        {
            /*0x7e0dffc*/ MustUseReturnValueAttribute();
        }

        class CollectionAccessAttribute : System.Attribute
        {
            /*0x10*/ JetBrains.Annotations.CollectionAccessType <CollectionAccessType>k__BackingField;

            /*0x7e0e004*/ CollectionAccessAttribute(JetBrains.Annotations.CollectionAccessType collectionAccessType);
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

        static /*0x7e0e470*/ bool get_shouldSupportTiling_Injected(nint _unity_self);
        static /*0x7e0e524*/ bool get_hasSpriteChangeEvents_Injected(nint _unity_self);
        static /*0x7e0e560*/ void set_hasSpriteChangeEvents_Injected(nint _unity_self, bool value);
        static /*0x7e0e638*/ nint get_sprite_Injected(nint _unity_self);
        static /*0x7e0e728*/ void set_sprite_Injected(nint _unity_self, nint value);
        static /*0x7e0e7e4*/ UnityEngine.SpriteDrawMode get_drawMode_Injected(nint _unity_self);
        static /*0x7e0e8a0*/ void set_drawMode_Injected(nint _unity_self, UnityEngine.SpriteDrawMode value);
        static /*0x7e0e96c*/ void get_size_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e0ea34*/ void set_size_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e0eaf0*/ float get_adaptiveModeThreshold_Injected(nint _unity_self);
        static /*0x7e0ebb4*/ void set_adaptiveModeThreshold_Injected(nint _unity_self, float value);
        static /*0x7e0ec78*/ UnityEngine.SpriteTileMode get_tileMode_Injected(nint _unity_self);
        static /*0x7e0ed34*/ void set_tileMode_Injected(nint _unity_self, UnityEngine.SpriteTileMode value);
        static /*0x7e0ee0c*/ void get_color_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x7e0eee0*/ void set_color_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x7e0ef9c*/ UnityEngine.SpriteMaskInteraction get_maskInteraction_Injected(nint _unity_self);
        static /*0x7e0f058*/ void set_maskInteraction_Injected(nint _unity_self, UnityEngine.SpriteMaskInteraction value);
        static /*0x7e0f114*/ bool get_flipX_Injected(nint _unity_self);
        static /*0x7e0f1d0*/ void set_flipX_Injected(nint _unity_self, bool value);
        static /*0x7e0f28c*/ bool get_flipY_Injected(nint _unity_self);
        static /*0x7e0f348*/ void set_flipY_Injected(nint _unity_self, bool value);
        static /*0x7e0f404*/ UnityEngine.SpriteSortPoint get_spriteSortPoint_Injected(nint _unity_self);
        static /*0x7e0f4c0*/ void set_spriteSortPoint_Injected(nint _unity_self, UnityEngine.SpriteSortPoint value);
        static /*0x7e0f57c*/ nint GetCurrentMeshDataPtr_Injected(nint _unity_self);
        static /*0x7e0f6c4*/ void Internal_GetSpriteBounds_Injected(nint _unity_self, UnityEngine.SpriteDrawMode mode, ref UnityEngine.Bounds ret);
        static /*0x7e0f7f0*/ void GetSecondaryTextureProperties_Injected(nint _unity_self, nint mbp);
        /*0x7e0f87c*/ SpriteRenderer();
        /*0x7e0e02c*/ void RegisterSpriteChangeCallback(UnityEngine.Events.UnityAction<UnityEngine.SpriteRenderer> callback);
        /*0x7e0e170*/ void UnregisterSpriteChangeCallback(UnityEngine.Events.UnityAction<UnityEngine.SpriteRenderer> callback);
        /*0x7e0e1f4*/ void InvokeSpriteChanged();
        /*0x7e0e3f8*/ bool get_shouldSupportTiling();
        /*0x7e0e4ac*/ bool get_hasSpriteChangeEvents();
        /*0x7e0e0f0*/ void set_hasSpriteChangeEvents(bool value);
        /*0x7e0e5a4*/ UnityEngine.Sprite get_sprite();
        /*0x7e0e674*/ void set_sprite(UnityEngine.Sprite value);
        /*0x7e0e76c*/ UnityEngine.SpriteDrawMode get_drawMode();
        /*0x7e0e820*/ void set_drawMode(UnityEngine.SpriteDrawMode value);
        /*0x7e0e8e4*/ UnityEngine.Vector2 get_size();
        /*0x7e0e9b0*/ void set_size(UnityEngine.Vector2 value);
        /*0x7e0ea78*/ float get_adaptiveModeThreshold();
        /*0x7e0eb2c*/ void set_adaptiveModeThreshold(float value);
        /*0x7e0ec00*/ UnityEngine.SpriteTileMode get_tileMode();
        /*0x7e0ecb4*/ void set_tileMode(UnityEngine.SpriteTileMode value);
        /*0x7e0ed78*/ UnityEngine.Color get_color();
        /*0x7e0ee50*/ void set_color(UnityEngine.Color value);
        /*0x7e0ef24*/ UnityEngine.SpriteMaskInteraction get_maskInteraction();
        /*0x7e0efd8*/ void set_maskInteraction(UnityEngine.SpriteMaskInteraction value);
        /*0x7e0f09c*/ bool get_flipX();
        /*0x7e0f150*/ void set_flipX(bool value);
        /*0x7e0f214*/ bool get_flipY();
        /*0x7e0f2c8*/ void set_flipY(bool value);
        /*0x7e0f38c*/ UnityEngine.SpriteSortPoint get_spriteSortPoint();
        /*0x7e0f440*/ void set_spriteSortPoint(UnityEngine.SpriteSortPoint value);
        /*0x7e0f504*/ nint GetCurrentMeshDataPtr();
        /*0x7e0f5b8*/ UnityEngine.Mesh.MeshDataArray GetCurrentMeshData();
        /*0x7e0f614*/ UnityEngine.Bounds Internal_GetSpriteBounds(UnityEngine.SpriteDrawMode mode);
        /*0x7e0f718*/ void GetSecondaryTextureProperties(UnityEngine.MaterialPropertyBlock mbp);
        /*0x7e0f834*/ UnityEngine.Bounds GetSpriteBounds();
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
        static /*0x7e0ff24*/ UnityEngine.Sprite CreateSpriteWithoutTextureScripting(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsToUnits, UnityEngine.Texture2D texture);
        static /*0x7e10058*/ UnityEngine.Sprite CreateSprite(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[] secondaryTexture);
        static /*0x7e11570*/ void GetPhysicsShapeImpl(UnityEngine.Sprite sprite, int shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2> physicsShape);
        static /*0x7e11b98*/ void OverridePhysicsShapeCount(UnityEngine.Sprite sprite, int physicsShapeCount);
        static /*0x7e11c2c*/ void OverridePhysicsShape(UnityEngine.Sprite sprite, UnityEngine.Vector2[] physicsShape, int idx);
        static /*0x7e1202c*/ UnityEngine.Sprite Create(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsToUnits, UnityEngine.Texture2D texture);
        static /*0x7e12030*/ UnityEngine.Sprite Create(UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsToUnits);
        static /*0x7e12038*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape);
        static /*0x7e1204c*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[] secondaryTextures);
        static /*0x7e124b8*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border);
        static /*0x7e124cc*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType);
        static /*0x7e125b4*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude);
        static /*0x7e125bc*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit);
        static /*0x7e125c8*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot);
        static /*0x7e0f954*/ int GetPackingMode_Injected(nint _unity_self);
        static /*0x7e0fa08*/ int GetPackingRotation_Injected(nint _unity_self);
        static /*0x7e0fabc*/ int GetPacked_Injected(nint _unity_self);
        static /*0x7e0fb8c*/ void GetTextureRect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x7e0fc58*/ void GetTextureRectOffset_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e0fd30*/ void GetInnerUVs_Injected(nint _unity_self, ref UnityEngine.Vector4 ret);
        static /*0x7e0fe08*/ void GetOuterUVs_Injected(nint _unity_self, ref UnityEngine.Vector4 ret);
        static /*0x7e0fee0*/ void GetPadding_Injected(nint _unity_self, ref UnityEngine.Vector4 ret);
        static /*0x7e0fff4*/ nint CreateSpriteWithoutTextureScripting_Injected(ref UnityEngine.Rect rect, ref UnityEngine.Vector2 pivot, float pixelsToUnits, nint texture);
        static /*0x7e10164*/ nint CreateSprite_Injected(nint texture, ref UnityEngine.Rect rect, ref UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, ref UnityEngine.Vector4 border, bool generateFallbackPhysicsShape, UnityEngine.SecondarySpriteTexture[] secondaryTexture);
        static /*0x7e102a4*/ void get_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x7e1037c*/ void get_rect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x7e10454*/ void get_border_Injected(nint _unity_self, ref UnityEngine.Vector4 ret);
        static /*0x7e1052c*/ nint get_texture_Injected(nint _unity_self);
        static /*0x7e1060c*/ nint GetSecondaryTexture_Injected(nint _unity_self, int index);
        static /*0x7e106c8*/ int GetSecondaryTextureCount_Injected(nint _unity_self);
        static /*0x7e107b4*/ int GetSecondaryTextures_Injected(nint _unity_self, UnityEngine.SecondarySpriteTexture[] secondaryTexture);
        static /*0x7e10870*/ float get_pixelsPerUnit_Injected(nint _unity_self);
        static /*0x7e10924*/ float get_spriteAtlasTextureScale_Injected(nint _unity_self);
        static /*0x7e109f4*/ nint get_associatedAlphaSplitTexture_Injected(nint _unity_self);
        static /*0x7e10ab8*/ void get_pivot_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e10b9c*/ UnityEngine.Vector2[] get_vertices_Injected(nint _unity_self);
        static /*0x7e10c50*/ ushort[] get_triangles_Injected(nint _unity_self);
        static /*0x7e10d04*/ UnityEngine.Vector2[] get_uv_Injected(nint _unity_self);
        static /*0x7e10db8*/ int GetPhysicsShapeCount_Injected(nint _unity_self);
        static /*0x7e10e6c*/ uint GetScriptableObjectsCount_Injected(nint _unity_self);
        static /*0x7e10f58*/ uint GetScriptableObjects_Injected(nint _unity_self, UnityEngine.ScriptableObject[] scriptableObjects);
        static /*0x7e11080*/ bool AddScriptableObject_Injected(nint _unity_self, nint obj);
        static /*0x7e11144*/ bool RemoveScriptableObjectAt_Injected(nint _unity_self, uint i);
        static /*0x7e1127c*/ bool SetScriptableObjectAt_Injected(nint _unity_self, nint obj, uint i);
        static /*0x7e11420*/ int Internal_GetPhysicsShapePointCount_Injected(nint _unity_self, int shapeIdx);
        static /*0x7e11770*/ void GetPhysicsShapeImpl_Injected(nint sprite, int shapeIdx, ref UnityEngine.Bindings.BlittableListWrapper physicsShape);
        static /*0x7e11d6c*/ void OverridePhysicsShapeCount_Injected(nint sprite, int physicsShapeCount);
        static /*0x7e11db0*/ void OverridePhysicsShape_Injected(nint sprite, ref UnityEngine.Bindings.ManagedSpanWrapper physicsShape, int idx);
        static /*0x7e11fd8*/ void OverrideGeometry_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper vertices, ref UnityEngine.Bindings.ManagedSpanWrapper triangles);
        /*0x7e0f884*/ Sprite();
        /*0x7e0f8dc*/ int GetPackingMode();
        /*0x7e0f990*/ int GetPackingRotation();
        /*0x7e0fa44*/ int GetPacked();
        /*0x7e0faf8*/ UnityEngine.Rect GetTextureRect();
        /*0x7e0fbd0*/ UnityEngine.Vector2 GetTextureRectOffset();
        /*0x7e0fc9c*/ UnityEngine.Vector4 GetInnerUVs();
        /*0x7e0fd74*/ UnityEngine.Vector4 GetOuterUVs();
        /*0x7e0fe4c*/ UnityEngine.Vector4 GetPadding();
        /*0x7e10200*/ UnityEngine.Bounds get_bounds();
        /*0x7e102e8*/ UnityEngine.Rect get_rect();
        /*0x7e103c0*/ UnityEngine.Vector4 get_border();
        /*0x7e10498*/ UnityEngine.Texture2D get_texture();
        /*0x7e10568*/ UnityEngine.Texture2D GetSecondaryTexture(int index);
        /*0x7e10650*/ int GetSecondaryTextureCount();
        /*0x7e10704*/ int GetSecondaryTextures(UnityEngine.SecondarySpriteTexture[] secondaryTexture);
        /*0x7e107f8*/ float get_pixelsPerUnit();
        /*0x7e108ac*/ float get_spriteAtlasTextureScale();
        /*0x7e10960*/ UnityEngine.Texture2D get_associatedAlphaSplitTexture();
        /*0x7e10a30*/ UnityEngine.Vector2 get_pivot();
        /*0x7e10afc*/ bool get_packed();
        /*0x7e10b14*/ UnityEngine.SpritePackingMode get_packingMode();
        /*0x7e10b18*/ UnityEngine.SpritePackingRotation get_packingRotation();
        /*0x7e10b1c*/ UnityEngine.Rect get_textureRect();
        /*0x7e10b20*/ UnityEngine.Vector2 get_textureRectOffset();
        /*0x7e10b24*/ UnityEngine.Vector2[] get_vertices();
        /*0x7e10bd8*/ ushort[] get_triangles();
        /*0x7e10c8c*/ UnityEngine.Vector2[] get_uv();
        /*0x7e10d40*/ int GetPhysicsShapeCount();
        /*0x7e10df4*/ uint GetScriptableObjectsCount();
        /*0x7e10ea8*/ uint GetScriptableObjects(UnityEngine.ScriptableObject[] scriptableObjects);
        /*0x7e10f9c*/ bool AddScriptableObject(UnityEngine.ScriptableObject obj);
        /*0x7e110c4*/ bool RemoveScriptableObjectAt(uint i);
        /*0x7e11188*/ bool SetScriptableObjectAt(UnityEngine.ScriptableObject obj, uint i);
        /*0x7e112d0*/ int GetPhysicsShapePointCount(int shapeIdx);
        /*0x7e113a0*/ int Internal_GetPhysicsShapePointCount(int shapeIdx);
        /*0x7e11464*/ int GetPhysicsShape(int shapeIdx, System.Collections.Generic.List<UnityEngine.Vector2> physicsShape);
        /*0x7e117c4*/ void OverridePhysicsShape(System.Collections.Generic.IList<UnityEngine.Vector2[]> physicsShapes);
        /*0x7e11e04*/ void OverrideGeometry(UnityEngine.Vector2[] vertices, ushort[] triangles);
    }

    struct SortingLayer
    {
        /*0x10*/ int m_Id;

        static /*0x7e125dc*/ int GetLayerValueFromID(int id);
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

        /*0x7e12618*/ Keyframe(float time, float value);
        /*0x7e12628*/ Keyframe(float time, float value, float inTangent, float outTangent);
        /*0x7e1263c*/ float get_time();
        /*0x7e12644*/ void set_time(float value);
        /*0x7e1264c*/ float get_value();
        /*0x7e12654*/ void set_value(float value);
        /*0x7e1265c*/ float get_inTangent();
        /*0x7e12664*/ void set_inTangent(float value);
        /*0x7e1266c*/ float get_outTangent();
        /*0x7e12674*/ void set_outTangent(float value);
        /*0x7e1267c*/ float get_inWeight();
        /*0x7e12684*/ void set_inWeight(float value);
        /*0x7e1268c*/ float get_outWeight();
        /*0x7e12694*/ void set_outWeight(float value);
        /*0x7e1269c*/ UnityEngine.WeightedMode get_weightedMode();
        /*0x7e126a4*/ void set_weightedMode(UnityEngine.WeightedMode value);
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

        static /*0x7e126ac*/ void Internal_Destroy(nint ptr);
        static /*0x7e126e8*/ nint Internal_Create(UnityEngine.Keyframe[] keys);
        static /*0x7e13390*/ UnityEngine.AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd);
        static /*0x7e13518*/ UnityEngine.AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd);
        static /*0x7e127b4*/ nint Internal_Create_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keys);
        static /*0x7e12848*/ bool Internal_Equals_Injected(nint _unity_self, nint other);
        static /*0x7e128e4*/ void Internal_CopyFrom_Injected(nint _unity_self, nint other);
        static /*0x7e12a4c*/ float Evaluate_Injected(nint _unity_self, float time);
        static /*0x7e12d14*/ int AddKey_Injected(nint _unity_self, float time, float value);
        static /*0x7e12dec*/ int AddKey_Internal_Injected(nint _unity_self, ref UnityEngine.Keyframe key);
        static /*0x7e12e98*/ int MoveKey_Injected(nint _unity_self, int index, ref UnityEngine.Keyframe key);
        static /*0x7e12f3c*/ void ClearKeys_Injected(nint _unity_self);
        static /*0x7e12fd0*/ void RemoveKey_Injected(nint _unity_self, int index);
        static /*0x7e13130*/ int get_length_Injected(nint _unity_self);
        static /*0x7e1316c*/ void SetKeys_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keys);
        static /*0x7e131b0*/ void GetKey_Injected(nint _unity_self, int index, ref UnityEngine.Keyframe ret);
        static /*0x7e13204*/ void GetKeys_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e13298*/ int GetHashCode_Injected(nint _unity_self);
        static /*0x7e1333c*/ void SmoothTangents_Injected(nint _unity_self, int index, float weight);
        /*0x7e134e0*/ AnimationCurve(UnityEngine.Keyframe[] keys);
        /*0x7e1365c*/ AnimationCurve();
        /*0x7e13688*/ AnimationCurve(nint ptr, bool ownMemory);
        /*0x7e127f0*/ bool Internal_Equals(nint other);
        /*0x7e1288c*/ void Internal_CopyFrom(nint other);
        /*0x7e12928*/ void Finalize();
        /*0x7e129ec*/ float Evaluate(float time);
        /*0x7e12a98*/ UnityEngine.Keyframe[] get_keys();
        /*0x7e12bb8*/ void set_keys(UnityEngine.Keyframe[] value);
        /*0x7e12cac*/ int AddKey(float time, float value);
        /*0x7e12d68*/ int AddKey(UnityEngine.Keyframe key);
        /*0x7e12d94*/ int AddKey_Internal(UnityEngine.Keyframe key);
        /*0x7e12e30*/ int MoveKey(int index, UnityEngine.Keyframe key);
        /*0x7e12eec*/ void ClearKeys();
        /*0x7e12f78*/ void RemoveKey(int index);
        /*0x7e13014*/ UnityEngine.Keyframe get_Item(int index);
        /*0x7e130e0*/ int get_length();
        /*0x7e12bbc*/ void SetKeys(UnityEngine.Keyframe[] keys);
        /*0x7e13050*/ UnityEngine.Keyframe GetKey(int index);
        /*0x7e12a9c*/ UnityEngine.Keyframe[] GetKeys();
        /*0x7e13248*/ int GetHashCode();
        /*0x7e132d4*/ void SmoothTangents(int index, float weight);
        /*0x7e136b8*/ bool Equals(object o);
        /*0x7e137b8*/ bool Equals(UnityEngine.AnimationCurve other);
        /*0x7e1383c*/ void CopyFrom(UnityEngine.AnimationCurve other);

        class BindingsMarshaller
        {
            static /*0x7e13854*/ nint ConvertToNative(UnityEngine.AnimationCurve animationCurve);
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

        static /*0x7e15a40*/ Application();
        static /*0x7e1386c*/ void Quit(int exitCode);
        static /*0x7e138a8*/ void Quit();
        static /*0x7e13918*/ bool get_isPlaying();
        static /*0x7e13940*/ bool IsPlaying(UnityEngine.Object obj);
        static /*0x7e13a48*/ bool get_isFocused();
        static /*0x7e13a70*/ bool get_runInBackground();
        static /*0x7e13a98*/ bool get_isBatchMode();
        static /*0x7e13ac0*/ string get_dataPath();
        static /*0x7e13be8*/ string get_streamingAssetsPath();
        static /*0x7e13d10*/ string get_persistentDataPath();
        static /*0x7e13e38*/ string get_unityVersion();
        static /*0x7e13f60*/ string get_version();
        static /*0x7e14088*/ string get_identifier();
        static /*0x7e141b0*/ string get_productName();
        static /*0x7e142d8*/ string get_cloudProjectId();
        static /*0x7e14400*/ void OpenURL(string url);
        static /*0x7e145c8*/ int get_targetFrameRate();
        static /*0x7e145f0*/ void set_targetFrameRate(int value);
        static /*0x7e1462c*/ void SetLogCallbackDefined(bool defined);
        static /*0x7e14668*/ UnityEngine.StackTraceLogType GetStackTraceLogType(UnityEngine.LogType logType);
        static /*0x7e146a4*/ UnityEngine.RuntimePlatform get_platform();
        static /*0x7e146cc*/ bool get_isMobilePlatform();
        static /*0x7e14790*/ UnityEngine.SystemLanguage get_systemLanguage();
        static /*0x7e147b8*/ void add_lowMemory(UnityEngine.Application.LowMemoryCallback value);
        static /*0x7e14890*/ void remove_lowMemory(UnityEngine.Application.LowMemoryCallback value);
        static /*0x7e14968*/ void CallLowMemory(UnityEngine.ApplicationMemoryUsage usage);
        static /*0x7e14aa0*/ bool HasLogCallback();
        static /*0x7e14b24*/ void add_logMessageReceived(UnityEngine.Application.LogCallback value);
        static /*0x7e14c10*/ void remove_logMessageReceived(UnityEngine.Application.LogCallback value);
        static /*0x7e14cd4*/ void CallLogCallback(string logString, string stackTrace, UnityEngine.LogType type, bool invokedOnMainThread);
        static /*0x7e14db0*/ void add_focusChanged(System.Action<bool> value);
        static /*0x7e14ea4*/ void remove_focusChanged(System.Action<bool> value);
        static /*0x7e14f98*/ void add_wantsToQuit(System.Func<bool> value);
        static /*0x7e1508c*/ void remove_wantsToQuit(System.Func<bool> value);
        static /*0x7e15180*/ void add_quitting(System.Action value);
        static /*0x7e1525c*/ void remove_quitting(System.Action value);
        static /*0x7e15338*/ bool Internal_ApplicationWantsToQuit();
        static /*0x7e1563c*/ void Internal_InitializeExitCancellationToken();
        static /*0x7e1571c*/ void Internal_RaiseExitCancellationToken();
        static /*0x7e15788*/ void Internal_ApplicationQuit();
        static /*0x7e1581c*/ void Internal_ApplicationUnload();
        static /*0x7e158b0*/ void InvokeOnBeforeRender();
        static /*0x7e15900*/ void InvokeFocusChanged(bool focus);
        static /*0x7e1599c*/ void InvokeDeepLinkActivated(string url);
        static /*0x7e15a38*/ bool get_isEditor();
        static /*0x7e13a0c*/ bool IsPlaying_Injected(nint obj);
        static /*0x7e13bac*/ void get_dataPath_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e13cd4*/ void get_streamingAssetsPath_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e13dfc*/ void get_persistentDataPath_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e13f24*/ void get_unityVersion_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e1404c*/ void get_version_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e14174*/ void get_identifier_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e1429c*/ void get_productName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e143c4*/ void get_cloudProjectId_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e1458c*/ void OpenURL_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper url);

        class LowMemoryCallback : System.MulticastDelegate
        {
            /*0x7e15ab4*/ LowMemoryCallback(object object, nint method);
            /*0x7e15b50*/ void Invoke();
        }

        class MemoryUsageChangedCallback : System.MulticastDelegate
        {
            /*0x7e15b64*/ MemoryUsageChangedCallback(object object, nint method);
            /*0x7e15c14*/ void Invoke(ref UnityEngine.ApplicationMemoryUsageChange usage);
        }

        class LogCallback : System.MulticastDelegate
        {
            /*0x7e15c28*/ LogCallback(object object, nint method);
            /*0x7e15cdc*/ void Invoke(string condition, string stackTrace, UnityEngine.LogType type);
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

        /*0x7e14a98*/ ApplicationMemoryUsageChange(UnityEngine.ApplicationMemoryUsage usage);
        /*0x7e15cf0*/ void set_memoryUsage(UnityEngine.ApplicationMemoryUsage value);
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

        static /*0x7e15cf8*/ UnityEngine.BootConfigData WrapBootConfigData(nint nativeHandle);
        /*0x7e15d50*/ BootConfigData(nint nativeHandle);
    }

    struct CachedAssetBundle
    {
        /*0x10*/ string m_Name;
        /*0x18*/ UnityEngine.Hash128 m_Hash;

        /*0x7e15dc4*/ CachedAssetBundle(string name, UnityEngine.Hash128 hash);
        /*0x7e15df0*/ string get_name();
        /*0x7e15df8*/ UnityEngine.Hash128 get_hash();
    }

    struct Cache : System.IEquatable<UnityEngine.Cache>
    {
        /*0x10*/ int m_Handle;

        static /*0x7e15ed8*/ bool Cache_IsValid(int handle);
        static /*0x7e15f1c*/ string Cache_GetPath(int handle);
        static /*0x7e16060*/ void Cache_SetMaximumDiskSpaceAvailable(int handle, long value);
        static /*0x7e160e8*/ void Cache_SetExpirationDelay(int handle, int value);
        static /*0x7e15fd8*/ void Cache_GetPath_Injected(int handle, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        /*0x7e15e04*/ int get_handle();
        /*0x7e15e0c*/ int GetHashCode();
        /*0x7e15e14*/ bool Equals(object other);
        /*0x7e15e8c*/ bool Equals(UnityEngine.Cache other);
        /*0x7e15e9c*/ bool get_valid();
        /*0x7e15f14*/ string get_path();
        /*0x7e1601c*/ void set_maximumAvailableStorageSpace(long value);
        /*0x7e160a4*/ void set_expirationDelay(int value);
    }

    class Caching
    {
        static /*0x7e1612c*/ void set_compressionEnabled(bool value);
        static /*0x7e16168*/ bool get_ready();
        static /*0x7e16190*/ bool ClearCache();
        static /*0x7e161b8*/ bool ClearCachedVersion(string assetBundleName, UnityEngine.Hash128 hash);
        static /*0x7e16238*/ bool ClearCachedVersionInternal(string assetBundleName, UnityEngine.Hash128 hash);
        static /*0x7e163f8*/ bool ClearOtherCachedVersions(string assetBundleName, UnityEngine.Hash128 hash);
        static /*0x7e16600*/ bool ClearAllCachedVersions(string assetBundleName);
        static /*0x7e1647c*/ bool ClearCachedVersions(string assetBundleName, UnityEngine.Hash128 hash, bool keepInputVersion);
        static /*0x7e166c8*/ bool IsVersionCached(UnityEngine.CachedAssetBundle cachedBundle);
        static /*0x7e1676c*/ bool IsVersionCached(string url, string assetBundleName, UnityEngine.Hash128 hash);
        static /*0x7e16a04*/ UnityEngine.Cache AddCache(string cachePath);
        static /*0x7e16da0*/ UnityEngine.Cache AddCache(string cachePath, bool isReadonly);
        static /*0x7e16c28*/ UnityEngine.Cache GetCacheByPath(string cachePath);
        static /*0x7e16fb8*/ UnityEngine.Cache get_defaultCache();
        static /*0x7e17038*/ UnityEngine.Cache get_currentCacheForWriting();
        static /*0x7e170b8*/ void set_currentCacheForWriting(UnityEngine.Cache value);
        static /*0x7e163b4*/ bool ClearCachedVersionInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper assetBundleName, ref UnityEngine.Hash128 hash);
        static /*0x7e16674*/ bool ClearCachedVersions_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper assetBundleName, ref UnityEngine.Hash128 hash, bool keepInputVersion);
        static /*0x7e169b0*/ bool IsVersionCached_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper url, ref UnityEngine.Bindings.ManagedSpanWrapper assetBundleName, ref UnityEngine.Hash128 hash);
        static /*0x7e16f20*/ void AddCache_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper cachePath, bool isReadonly, ref UnityEngine.Cache ret);
        static /*0x7e16f74*/ void GetCacheByPath_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper cachePath, ref UnityEngine.Cache ret);
        static /*0x7e16ffc*/ void get_defaultCache_Injected(ref UnityEngine.Cache ret);
        static /*0x7e1707c*/ void get_currentCacheForWriting_Injected(ref UnityEngine.Cache ret);
        static /*0x7e170f8*/ void set_currentCacheForWriting_Injected(ref UnityEngine.Cache value);
    }

    class BatchRendererGroupRuntimeAnalytic : UnityEngine.Analytics.AnalyticsEventBase
    {
        /*0x2c*/ int brgRuntimeStatus;

        static /*0x7e171a8*/ UnityEngine.BatchRendererGroupRuntimeAnalytic CreateBatchRendererGroupRuntimeAnalytic();
        /*0x7e17134*/ BatchRendererGroupRuntimeAnalytic();
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

        static /*0x7e19bd8*/ int get_PreviewCullingLayer();
        static /*0x7e1e47c*/ void CalculateProjectionMatrixFromPhysicalPropertiesInternal(ref UnityEngine.Matrix4x4 output, float focalLength, UnityEngine.Vector2 sensorSize, UnityEngine.Vector2 lensShift, float nearClip, float farClip, float gateAspect, UnityEngine.Camera.GateFitMode gateFitMode);
        static /*0x7e1e598*/ void CalculateProjectionMatrixFromPhysicalProperties(ref UnityEngine.Matrix4x4 output, float focalLength, UnityEngine.Vector2 sensorSize, UnityEngine.Vector2 lensShift, float nearClip, float farClip, UnityEngine.Camera.GateFitParameters gateFitParameters);
        static /*0x7e1e5a4*/ float FocalLengthToFieldOfView(float focalLength, float sensorSize);
        static /*0x7e1e5e4*/ float FieldOfViewToFocalLength(float fieldOfView, float sensorSize);
        static /*0x7e1e624*/ float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio);
        static /*0x7e1e664*/ float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio);
        static /*0x7e1e6a4*/ UnityEngine.Camera get_main();
        static /*0x7e1e730*/ UnityEngine.Camera get_current();
        static /*0x7e1e734*/ UnityEngine.Camera get_currentInternal();
        static /*0x7e1f800*/ int GetAllCamerasCount();
        static /*0x7e1f828*/ int GetAllCamerasImpl(UnityEngine.Camera[] cam);
        static /*0x7e1f8dc*/ int get_allCamerasCount();
        static /*0x7e1f904*/ UnityEngine.Camera[] get_allCameras();
        static /*0x7e1f980*/ int GetAllCameras(UnityEngine.Camera[] cameras);
        static /*0x7e205a4*/ void SetupCurrent(UnityEngine.Camera cur);
        static /*0x7e216bc*/ void FireOnPreCull(UnityEngine.Camera cam);
        static /*0x7e21728*/ void FireOnPreRender(UnityEngine.Camera cam);
        static /*0x7e21794*/ void FireOnPostRender(UnityEngine.Camera cam);
        static /*0x7e21800*/ void BumpNonSerializedVersion(UnityEngine.Camera cam);
        static /*0x7e21838*/ bool GetCullingParameters_Internal(UnityEngine.Camera camera, bool stereoAware, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, int managedCullingParametersSize);
        static /*0x7e17278*/ float get_nearClipPlane_Injected(nint _unity_self);
        static /*0x7e1733c*/ void set_nearClipPlane_Injected(nint _unity_self, float value);
        static /*0x7e17400*/ float get_farClipPlane_Injected(nint _unity_self);
        static /*0x7e174c4*/ void set_farClipPlane_Injected(nint _unity_self, float value);
        static /*0x7e17588*/ float get_fieldOfView_Injected(nint _unity_self);
        static /*0x7e1764c*/ void set_fieldOfView_Injected(nint _unity_self, float value);
        static /*0x7e17710*/ UnityEngine.RenderingPath get_renderingPath_Injected(nint _unity_self);
        static /*0x7e177cc*/ void set_renderingPath_Injected(nint _unity_self, UnityEngine.RenderingPath value);
        static /*0x7e17888*/ UnityEngine.RenderingPath get_actualRenderingPath_Injected(nint _unity_self);
        static /*0x7e1793c*/ void Reset_Injected(nint _unity_self);
        static /*0x7e179f0*/ bool get_allowHDR_Injected(nint _unity_self);
        static /*0x7e17aac*/ void set_allowHDR_Injected(nint _unity_self, bool value);
        static /*0x7e17b68*/ bool get_allowMSAA_Injected(nint _unity_self);
        static /*0x7e17c24*/ void set_allowMSAA_Injected(nint _unity_self, bool value);
        static /*0x7e17ce0*/ bool get_allowDynamicResolution_Injected(nint _unity_self);
        static /*0x7e17d9c*/ void set_allowDynamicResolution_Injected(nint _unity_self, bool value);
        static /*0x7e17e58*/ bool get_forceIntoRenderTexture_Injected(nint _unity_self);
        static /*0x7e17f14*/ void set_forceIntoRenderTexture_Injected(nint _unity_self, bool value);
        static /*0x7e17fd0*/ float get_orthographicSize_Injected(nint _unity_self);
        static /*0x7e18094*/ void set_orthographicSize_Injected(nint _unity_self, float value);
        static /*0x7e18158*/ bool get_orthographic_Injected(nint _unity_self);
        static /*0x7e18214*/ void set_orthographic_Injected(nint _unity_self, bool value);
        static /*0x7e182d0*/ UnityEngine.Rendering.OpaqueSortMode get_opaqueSortMode_Injected(nint _unity_self);
        static /*0x7e1838c*/ void set_opaqueSortMode_Injected(nint _unity_self, UnityEngine.Rendering.OpaqueSortMode value);
        static /*0x7e18448*/ UnityEngine.TransparencySortMode get_transparencySortMode_Injected(nint _unity_self);
        static /*0x7e18504*/ void set_transparencySortMode_Injected(nint _unity_self, UnityEngine.TransparencySortMode value);
        static /*0x7e185e0*/ void get_transparencySortAxis_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e186b4*/ void set_transparencySortAxis_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7e18770*/ void ResetTransparencySortSettings_Injected(nint _unity_self);
        static /*0x7e18824*/ float get_depth_Injected(nint _unity_self);
        static /*0x7e188e8*/ void set_depth_Injected(nint _unity_self, float value);
        static /*0x7e189ac*/ float get_aspect_Injected(nint _unity_self);
        static /*0x7e18a70*/ void set_aspect_Injected(nint _unity_self, float value);
        static /*0x7e18b34*/ void ResetAspect_Injected(nint _unity_self);
        static /*0x7e18c08*/ void get_velocity_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e18cc4*/ int get_cullingMask_Injected(nint _unity_self);
        static /*0x7e18d80*/ void set_cullingMask_Injected(nint _unity_self, int value);
        static /*0x7e18e3c*/ int get_eventMask_Injected(nint _unity_self);
        static /*0x7e18ef8*/ void set_eventMask_Injected(nint _unity_self, int value);
        static /*0x7e1922c*/ bool get_layerCullSphericalInternal_Injected(nint _unity_self);
        static /*0x7e19268*/ void set_layerCullSphericalInternal_Injected(nint _unity_self, bool value);
        static /*0x7e19324*/ UnityEngine.CameraType get_cameraType_Injected(nint _unity_self);
        static /*0x7e193e0*/ void set_cameraType_Injected(nint _unity_self, UnityEngine.CameraType value);
        static /*0x7e194b8*/ nint get_skyboxMaterial_Injected(nint _unity_self);
        static /*0x7e1956c*/ ulong get_overrideSceneCullingMask_Injected(nint _unity_self);
        static /*0x7e19628*/ void set_overrideSceneCullingMask_Injected(nint _unity_self, ulong value);
        static /*0x7e196e4*/ ulong get_sceneCullingMask_Injected(nint _unity_self);
        static /*0x7e19798*/ bool get_useInteractiveLightBakingData_Injected(nint _unity_self);
        static /*0x7e19854*/ void set_useInteractiveLightBakingData_Injected(nint _unity_self, bool value);
        static /*0x7e199c0*/ void GetLayerCullDistances_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e19b28*/ void SetLayerCullDistances_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper d);
        static /*0x7e19c58*/ bool get_useOcclusionCulling_Injected(nint _unity_self);
        static /*0x7e19d14*/ void set_useOcclusionCulling_Injected(nint _unity_self, bool value);
        static /*0x7e19e00*/ void get_cullingMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e19ec4*/ void set_cullingMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
        static /*0x7e19f80*/ void ResetCullingMatrix_Injected(nint _unity_self);
        static /*0x7e1a050*/ void get_backgroundColor_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x7e1a124*/ void set_backgroundColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x7e1a1e0*/ UnityEngine.CameraClearFlags get_clearFlags_Injected(nint _unity_self);
        static /*0x7e1a29c*/ void set_clearFlags_Injected(nint _unity_self, UnityEngine.CameraClearFlags value);
        static /*0x7e1a358*/ UnityEngine.DepthTextureMode get_depthTextureMode_Injected(nint _unity_self);
        static /*0x7e1a414*/ void set_depthTextureMode_Injected(nint _unity_self, UnityEngine.DepthTextureMode value);
        static /*0x7e1a4d0*/ bool get_clearStencilAfterLightingPass_Injected(nint _unity_self);
        static /*0x7e1a58c*/ void set_clearStencilAfterLightingPass_Injected(nint _unity_self, bool value);
        static /*0x7e1a7ac*/ void SetReplacementShader_Injected(nint _unity_self, nint shader, ref UnityEngine.Bindings.ManagedSpanWrapper replacementTag);
        static /*0x7e1a878*/ void ResetReplacementShader_Injected(nint _unity_self);
        static /*0x7e1a92c*/ UnityEngine.Camera.ProjectionMatrixMode get_projectionMatrixMode_Injected(nint _unity_self);
        static /*0x7e1a9e0*/ bool get_usePhysicalProperties_Injected(nint _unity_self);
        static /*0x7e1aa9c*/ void set_usePhysicalProperties_Injected(nint _unity_self, bool value);
        static /*0x7e1ab58*/ int get_iso_Injected(nint _unity_self);
        static /*0x7e1ac14*/ void set_iso_Injected(nint _unity_self, int value);
        static /*0x7e1acd0*/ float get_shutterSpeed_Injected(nint _unity_self);
        static /*0x7e1ad94*/ void set_shutterSpeed_Injected(nint _unity_self, float value);
        static /*0x7e1ae58*/ float get_aperture_Injected(nint _unity_self);
        static /*0x7e1af1c*/ void set_aperture_Injected(nint _unity_self, float value);
        static /*0x7e1afe0*/ float get_focusDistance_Injected(nint _unity_self);
        static /*0x7e1b0a4*/ void set_focusDistance_Injected(nint _unity_self, float value);
        static /*0x7e1b168*/ float get_focalLength_Injected(nint _unity_self);
        static /*0x7e1b22c*/ void set_focalLength_Injected(nint _unity_self, float value);
        static /*0x7e1b2f0*/ int get_bladeCount_Injected(nint _unity_self);
        static /*0x7e1b3ac*/ void set_bladeCount_Injected(nint _unity_self, int value);
        static /*0x7e1b478*/ void get_curvature_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e1b540*/ void set_curvature_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e1b5fc*/ float get_barrelClipping_Injected(nint _unity_self);
        static /*0x7e1b6c0*/ void set_barrelClipping_Injected(nint _unity_self, float value);
        static /*0x7e1b784*/ float get_anamorphism_Injected(nint _unity_self);
        static /*0x7e1b848*/ void set_anamorphism_Injected(nint _unity_self, float value);
        static /*0x7e1b91c*/ void get_sensorSize_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e1b9e4*/ void set_sensorSize_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e1bab0*/ void get_lensShift_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e1bb78*/ void set_lensShift_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e1bc34*/ UnityEngine.Camera.GateFitMode get_gateFit_Injected(nint _unity_self);
        static /*0x7e1bcf0*/ void set_gateFit_Injected(nint _unity_self, UnityEngine.Camera.GateFitMode value);
        static /*0x7e1bdac*/ float GetGateFittedFieldOfView_Injected(nint _unity_self);
        static /*0x7e1be70*/ void GetGateFittedLensShift_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e1bf4c*/ void GetLocalSpaceAim_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e1c024*/ void get_rect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x7e1c0f8*/ void set_rect_Injected(nint _unity_self, ref UnityEngine.Rect value);
        static /*0x7e1c1d0*/ void get_pixelRect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x7e1c2a4*/ void set_pixelRect_Injected(nint _unity_self, ref UnityEngine.Rect value);
        static /*0x7e1c360*/ int get_pixelWidth_Injected(nint _unity_self);
        static /*0x7e1c414*/ int get_pixelHeight_Injected(nint _unity_self);
        static /*0x7e1c4c8*/ int get_scaledPixelWidth_Injected(nint _unity_self);
        static /*0x7e1c57c*/ int get_scaledPixelHeight_Injected(nint _unity_self);
        static /*0x7e1c64c*/ nint get_targetTexture_Injected(nint _unity_self);
        static /*0x7e1c73c*/ void set_targetTexture_Injected(nint _unity_self, nint value);
        static /*0x7e1c814*/ nint get_activeTexture_Injected(nint _unity_self);
        static /*0x7e1c8c8*/ int get_targetDisplay_Injected(nint _unity_self);
        static /*0x7e1c984*/ void set_targetDisplay_Injected(nint _unity_self, int value);
        static /*0x7e1ca5c*/ void SetTargetBuffersImpl_Injected(nint _unity_self, ref UnityEngine.RenderBuffer color, ref UnityEngine.RenderBuffer depth);
        static /*0x7e1cbb8*/ void SetTargetBuffersMRTImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper color, ref UnityEngine.RenderBuffer depth);
        static /*0x7e1cc88*/ string[] GetCameraBufferWarnings_Injected(nint _unity_self);
        static /*0x7e1cd6c*/ void get_cameraToWorldMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e1ce58*/ void get_worldToCameraMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e1cf1c*/ void set_worldToCameraMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
        static /*0x7e1d008*/ void get_projectionMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e1d0cc*/ void set_projectionMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
        static /*0x7e1d1b8*/ void get_nonJitteredProjectionMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e1d27c*/ void set_nonJitteredProjectionMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
        static /*0x7e1d338*/ bool get_useJitteredProjectionMatrixForTransparentRendering_Injected(nint _unity_self);
        static /*0x7e1d3f4*/ void set_useJitteredProjectionMatrixForTransparentRendering_Injected(nint _unity_self, bool value);
        static /*0x7e1d4e0*/ void get_previousViewProjectionMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e1d59c*/ void ResetWorldToCameraMatrix_Injected(nint _unity_self);
        static /*0x7e1d650*/ void ResetProjectionMatrix_Injected(nint _unity_self);
        static /*0x7e1d740*/ void CalculateObliqueMatrix_Injected(nint _unity_self, ref UnityEngine.Vector4 clipPlane, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e1d840*/ void WorldToScreenPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        static /*0x7e1d948*/ void WorldToViewportPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        static /*0x7e1da50*/ void ViewportToWorldPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        static /*0x7e1db58*/ void ScreenToWorldPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        static /*0x7e1dc78*/ void ScreenToViewportPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x7e1dd70*/ void ViewportToScreenPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x7e1de64*/ void GetFrustumPlaneSizeAt_Injected(nint _unity_self, float distance, ref UnityEngine.Vector2 ret);
        static /*0x7e1df70*/ void ViewportPointToRay_Injected(nint _unity_self, ref UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Ray ret);
        static /*0x7e1e104*/ void ScreenPointToRay_Injected(nint _unity_self, ref UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Ray ret);
        static /*0x7e1e35c*/ void CalculateFrustumCornersInternal_Injected(nint _unity_self, ref UnityEngine.Rect viewport, float z, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Bindings.BlittableArrayWrapper outCorners);
        static /*0x7e1e50c*/ void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(ref UnityEngine.Matrix4x4 output, float focalLength, ref UnityEngine.Vector2 sensorSize, ref UnityEngine.Vector2 lensShift, float nearClip, float farClip, float gateAspect, UnityEngine.Camera.GateFitMode gateFitMode);
        static /*0x7e1e708*/ nint get_main_Injected();
        static /*0x7e1e798*/ nint get_currentInternal_Injected();
        static /*0x7e1e848*/ void get_scene_Injected(nint _unity_self, ref UnityEngine.SceneManagement.Scene ret);
        static /*0x7e1e910*/ void set_scene_Injected(nint _unity_self, ref UnityEngine.SceneManagement.Scene value);
        static /*0x7e1e9cc*/ bool get_stereoEnabled_Injected(nint _unity_self);
        static /*0x7e1ea80*/ float get_stereoSeparation_Injected(nint _unity_self);
        static /*0x7e1eb44*/ void set_stereoSeparation_Injected(nint _unity_self, float value);
        static /*0x7e1ec08*/ float get_stereoConvergence_Injected(nint _unity_self);
        static /*0x7e1eccc*/ void set_stereoConvergence_Injected(nint _unity_self, float value);
        static /*0x7e1ed90*/ bool get_areVRStereoViewMatricesWithinSingleCullTolerance_Injected(nint _unity_self);
        static /*0x7e1efb4*/ UnityEngine.StereoTargetEyeMask get_stereoTargetEyeInternal_Injected(nint _unity_self);
        static /*0x7e1eff0*/ void set_stereoTargetEyeInternal_Injected(nint _unity_self, UnityEngine.StereoTargetEyeMask value);
        static /*0x7e1f0ac*/ UnityEngine.Camera.MonoOrStereoscopicEye get_stereoActiveEye_Injected(nint _unity_self);
        static /*0x7e1f1a0*/ void GetStereoNonJitteredProjectionMatrix_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e1f2ac*/ void GetStereoViewMatrix_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e1f380*/ void CopyStereoDeviceProjectionMatrixToNonJittered_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye);
        static /*0x7e1f47c*/ void GetStereoProjectionMatrix_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e1f560*/ void SetStereoProjectionMatrix_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 matrix);
        static /*0x7e1f62c*/ void ResetStereoProjectionMatrices_Injected(nint _unity_self);
        static /*0x7e1f6f8*/ void SetStereoViewMatrix_Injected(nint _unity_self, UnityEngine.Camera.StereoscopicEye eye, ref UnityEngine.Matrix4x4 matrix);
        static /*0x7e1f7c4*/ void ResetStereoViewMatrices_Injected(nint _unity_self);
        static /*0x7e1f8a0*/ int GetAllCamerasImpl_Injected(UnityEngine.Camera[] cam);
        static /*0x7e1faf4*/ bool RenderToCubemapImpl_Injected(nint _unity_self, nint tex, int faceMask);
        static /*0x7e1fbd8*/ int GetFilterMode_Injected(nint _unity_self);
        static /*0x7e1fc90*/ bool get_renderCloudsInSceneView_Injected(nint _unity_self);
        static /*0x7e1fd4c*/ void set_renderCloudsInSceneView_Injected(nint _unity_self, bool value);
        static /*0x7e1fe5c*/ bool RenderToCubemapEyeImpl_Injected(nint _unity_self, nint cubemap, int faceMask, UnityEngine.Camera.MonoOrStereoscopicEye stereoEye);
        static /*0x7e1ff34*/ void Render_Injected(nint _unity_self);
        static /*0x7e2014c*/ void RenderWithShader_Injected(nint _unity_self, nint shader, ref UnityEngine.Bindings.ManagedSpanWrapper replacementTag);
        static /*0x7e20218*/ void RenderDontRestore_Injected(nint _unity_self);
        static /*0x7e20420*/ void SubmitRenderRequestsInternal_Injected(nint _unity_self, object requests);
        static /*0x7e20538*/ UnityEngine.Object[] SubmitBuiltInObjectIDRenderRequest_Injected(nint _unity_self, nint target, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
        static /*0x7e20628*/ void SetupCurrent_Injected(nint cur);
        static /*0x7e20718*/ void CopyFrom_Injected(nint _unity_self, nint other);
        static /*0x7e207d4*/ int get_commandBufferCount_Injected(nint _unity_self);
        static /*0x7e20890*/ void RemoveCommandBuffersImpl_Injected(nint _unity_self, UnityEngine.Rendering.CameraEvent evt);
        static /*0x7e2094c*/ void RemoveAllCommandBuffersImpl_Injected(nint _unity_self);
        static /*0x7e20c54*/ void AddCommandBufferImpl_Injected(nint _unity_self, UnityEngine.Rendering.CameraEvent evt, nint buffer);
        static /*0x7e20d98*/ void AddCommandBufferAsyncImpl_Injected(nint _unity_self, UnityEngine.Rendering.CameraEvent evt, nint buffer, UnityEngine.Rendering.ComputeQueueType queueType);
        static /*0x7e20edc*/ void RemoveCommandBufferImpl_Injected(nint _unity_self, UnityEngine.Rendering.CameraEvent evt, nint buffer);
        static /*0x7e21678*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffersImpl_Injected(nint _unity_self, UnityEngine.Rendering.CameraEvent evt);
        static /*0x7e218f0*/ bool GetCullingParameters_Internal_Injected(nint camera, bool stereoAware, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, int managedCullingParametersSize);
        /*0x7e171f8*/ Camera();
        /*0x7e17200*/ float get_nearClipPlane();
        /*0x7e172b4*/ void set_nearClipPlane(float value);
        /*0x7e17388*/ float get_farClipPlane();
        /*0x7e1743c*/ void set_farClipPlane(float value);
        /*0x7e17510*/ float get_fieldOfView();
        /*0x7e175c4*/ void set_fieldOfView(float value);
        /*0x7e17698*/ UnityEngine.RenderingPath get_renderingPath();
        /*0x7e1774c*/ void set_renderingPath(UnityEngine.RenderingPath value);
        /*0x7e17810*/ UnityEngine.RenderingPath get_actualRenderingPath();
        /*0x7e178c4*/ void Reset();
        /*0x7e17978*/ bool get_allowHDR();
        /*0x7e17a2c*/ void set_allowHDR(bool value);
        /*0x7e17af0*/ bool get_allowMSAA();
        /*0x7e17ba4*/ void set_allowMSAA(bool value);
        /*0x7e17c68*/ bool get_allowDynamicResolution();
        /*0x7e17d1c*/ void set_allowDynamicResolution(bool value);
        /*0x7e17de0*/ bool get_forceIntoRenderTexture();
        /*0x7e17e94*/ void set_forceIntoRenderTexture(bool value);
        /*0x7e17f58*/ float get_orthographicSize();
        /*0x7e1800c*/ void set_orthographicSize(float value);
        /*0x7e180e0*/ bool get_orthographic();
        /*0x7e18194*/ void set_orthographic(bool value);
        /*0x7e18258*/ UnityEngine.Rendering.OpaqueSortMode get_opaqueSortMode();
        /*0x7e1830c*/ void set_opaqueSortMode(UnityEngine.Rendering.OpaqueSortMode value);
        /*0x7e183d0*/ UnityEngine.TransparencySortMode get_transparencySortMode();
        /*0x7e18484*/ void set_transparencySortMode(UnityEngine.TransparencySortMode value);
        /*0x7e18548*/ UnityEngine.Vector3 get_transparencySortAxis();
        /*0x7e18624*/ void set_transparencySortAxis(UnityEngine.Vector3 value);
        /*0x7e186f8*/ void ResetTransparencySortSettings();
        /*0x7e187ac*/ float get_depth();
        /*0x7e18860*/ void set_depth(float value);
        /*0x7e18934*/ float get_aspect();
        /*0x7e189e8*/ void set_aspect(float value);
        /*0x7e18abc*/ void ResetAspect();
        /*0x7e18b70*/ UnityEngine.Vector3 get_velocity();
        /*0x7e18c4c*/ int get_cullingMask();
        /*0x7e18d00*/ void set_cullingMask(int value);
        /*0x7e18dc4*/ int get_eventMask();
        /*0x7e18e78*/ void set_eventMask(int value);
        /*0x7e18f3c*/ bool get_layerCullSpherical();
        /*0x7e18fb8*/ void set_layerCullSpherical(bool value);
        /*0x7e18f40*/ bool get_layerCullSphericalInternal();
        /*0x7e191ac*/ void set_layerCullSphericalInternal(bool value);
        /*0x7e192ac*/ UnityEngine.CameraType get_cameraType();
        /*0x7e19360*/ void set_cameraType(UnityEngine.CameraType value);
        /*0x7e19424*/ UnityEngine.Material get_skyboxMaterial();
        /*0x7e194f4*/ ulong get_overrideSceneCullingMask();
        /*0x7e195a8*/ void set_overrideSceneCullingMask(ulong value);
        /*0x7e1966c*/ ulong get_sceneCullingMask();
        /*0x7e19720*/ bool get_useInteractiveLightBakingData();
        /*0x7e197d4*/ void set_useInteractiveLightBakingData(bool value);
        /*0x7e19898*/ float[] GetLayerCullDistances();
        /*0x7e19a04*/ void SetLayerCullDistances(float[] d);
        /*0x7e19b6c*/ float[] get_layerCullDistances();
        /*0x7e19b70*/ void set_layerCullDistances(float[] value);
        /*0x7e19be0*/ bool get_useOcclusionCulling();
        /*0x7e19c94*/ void set_useOcclusionCulling(bool value);
        /*0x7e19d58*/ UnityEngine.Matrix4x4 get_cullingMatrix();
        /*0x7e19e44*/ void set_cullingMatrix(UnityEngine.Matrix4x4 value);
        /*0x7e19f08*/ void ResetCullingMatrix();
        /*0x7e19fbc*/ UnityEngine.Color get_backgroundColor();
        /*0x7e1a094*/ void set_backgroundColor(UnityEngine.Color value);
        /*0x7e1a168*/ UnityEngine.CameraClearFlags get_clearFlags();
        /*0x7e1a21c*/ void set_clearFlags(UnityEngine.CameraClearFlags value);
        /*0x7e1a2e0*/ UnityEngine.DepthTextureMode get_depthTextureMode();
        /*0x7e1a394*/ void set_depthTextureMode(UnityEngine.DepthTextureMode value);
        /*0x7e1a458*/ bool get_clearStencilAfterLightingPass();
        /*0x7e1a50c*/ void set_clearStencilAfterLightingPass(bool value);
        /*0x7e1a5d0*/ void SetReplacementShader(UnityEngine.Shader shader, string replacementTag);
        /*0x7e1a800*/ void ResetReplacementShader();
        /*0x7e1a8b4*/ UnityEngine.Camera.ProjectionMatrixMode get_projectionMatrixMode();
        /*0x7e1a968*/ bool get_usePhysicalProperties();
        /*0x7e1aa1c*/ void set_usePhysicalProperties(bool value);
        /*0x7e1aae0*/ int get_iso();
        /*0x7e1ab94*/ void set_iso(int value);
        /*0x7e1ac58*/ float get_shutterSpeed();
        /*0x7e1ad0c*/ void set_shutterSpeed(float value);
        /*0x7e1ade0*/ float get_aperture();
        /*0x7e1ae94*/ void set_aperture(float value);
        /*0x7e1af68*/ float get_focusDistance();
        /*0x7e1b01c*/ void set_focusDistance(float value);
        /*0x7e1b0f0*/ float get_focalLength();
        /*0x7e1b1a4*/ void set_focalLength(float value);
        /*0x7e1b278*/ int get_bladeCount();
        /*0x7e1b32c*/ void set_bladeCount(int value);
        /*0x7e1b3f0*/ UnityEngine.Vector2 get_curvature();
        /*0x7e1b4bc*/ void set_curvature(UnityEngine.Vector2 value);
        /*0x7e1b584*/ float get_barrelClipping();
        /*0x7e1b638*/ void set_barrelClipping(float value);
        /*0x7e1b70c*/ float get_anamorphism();
        /*0x7e1b7c0*/ void set_anamorphism(float value);
        /*0x7e1b894*/ UnityEngine.Vector2 get_sensorSize();
        /*0x7e1b960*/ void set_sensorSize(UnityEngine.Vector2 value);
        /*0x7e1ba28*/ UnityEngine.Vector2 get_lensShift();
        /*0x7e1baf4*/ void set_lensShift(UnityEngine.Vector2 value);
        /*0x7e1bbbc*/ UnityEngine.Camera.GateFitMode get_gateFit();
        /*0x7e1bc70*/ void set_gateFit(UnityEngine.Camera.GateFitMode value);
        /*0x7e1bd34*/ float GetGateFittedFieldOfView();
        /*0x7e1bde8*/ UnityEngine.Vector2 GetGateFittedLensShift();
        /*0x7e1beb4*/ UnityEngine.Vector3 GetLocalSpaceAim();
        /*0x7e1bf90*/ UnityEngine.Rect get_rect();
        /*0x7e1c068*/ void set_rect(UnityEngine.Rect value);
        /*0x7e1c13c*/ UnityEngine.Rect get_pixelRect();
        /*0x7e1c214*/ void set_pixelRect(UnityEngine.Rect value);
        /*0x7e1c2e8*/ int get_pixelWidth();
        /*0x7e1c39c*/ int get_pixelHeight();
        /*0x7e1c450*/ int get_scaledPixelWidth();
        /*0x7e1c504*/ int get_scaledPixelHeight();
        /*0x7e1c5b8*/ UnityEngine.RenderTexture get_targetTexture();
        /*0x7e1c688*/ void set_targetTexture(UnityEngine.RenderTexture value);
        /*0x7e1c780*/ UnityEngine.RenderTexture get_activeTexture();
        /*0x7e1c850*/ int get_targetDisplay();
        /*0x7e1c904*/ void set_targetDisplay(int value);
        /*0x7e1c9c8*/ void SetTargetBuffersImpl(UnityEngine.RenderBuffer color, UnityEngine.RenderBuffer depth);
        /*0x7e1cab0*/ void SetTargetBuffers(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer);
        /*0x7e1cab4*/ void SetTargetBuffersMRTImpl(UnityEngine.RenderBuffer[] color, UnityEngine.RenderBuffer depth);
        /*0x7e1cc0c*/ void SetTargetBuffers(UnityEngine.RenderBuffer[] colorBuffer, UnityEngine.RenderBuffer depthBuffer);
        /*0x7e1cc10*/ string[] GetCameraBufferWarnings();
        /*0x7e1ccc4*/ UnityEngine.Matrix4x4 get_cameraToWorldMatrix();
        /*0x7e1cdb0*/ UnityEngine.Matrix4x4 get_worldToCameraMatrix();
        /*0x7e1ce9c*/ void set_worldToCameraMatrix(UnityEngine.Matrix4x4 value);
        /*0x7e1cf60*/ UnityEngine.Matrix4x4 get_projectionMatrix();
        /*0x7e1d04c*/ void set_projectionMatrix(UnityEngine.Matrix4x4 value);
        /*0x7e1d110*/ UnityEngine.Matrix4x4 get_nonJitteredProjectionMatrix();
        /*0x7e1d1fc*/ void set_nonJitteredProjectionMatrix(UnityEngine.Matrix4x4 value);
        /*0x7e1d2c0*/ bool get_useJitteredProjectionMatrixForTransparentRendering();
        /*0x7e1d374*/ void set_useJitteredProjectionMatrixForTransparentRendering(bool value);
        /*0x7e1d438*/ UnityEngine.Matrix4x4 get_previousViewProjectionMatrix();
        /*0x7e1d524*/ void ResetWorldToCameraMatrix();
        /*0x7e1d5d8*/ void ResetProjectionMatrix();
        /*0x7e1d68c*/ UnityEngine.Matrix4x4 CalculateObliqueMatrix(UnityEngine.Vector4 clipPlane);
        /*0x7e1d794*/ UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e1d89c*/ UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e1d9a4*/ UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e1daac*/ UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e1dbb4*/ UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position);
        /*0x7e1dbbc*/ UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position);
        /*0x7e1dbc4*/ UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position);
        /*0x7e1dbcc*/ UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position);
        /*0x7e1dbd4*/ UnityEngine.Vector3 ScreenToViewportPoint(UnityEngine.Vector3 position);
        /*0x7e1dccc*/ UnityEngine.Vector3 ViewportToScreenPoint(UnityEngine.Vector3 position);
        /*0x7e1ddc4*/ UnityEngine.Vector2 GetFrustumPlaneSizeAt(float distance);
        /*0x7e1deb8*/ UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e1dfcc*/ UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e1e004*/ UnityEngine.Ray ViewportPointToRay(UnityEngine.Vector3 pos);
        /*0x7e1e04c*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e1e160*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x7e1e198*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos);
        /*0x7e1e1e0*/ void CalculateFrustumCornersInternal(UnityEngine.Rect viewport, float z, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3[] outCorners);
        /*0x7e1e3c8*/ void CalculateFrustumCorners(UnityEngine.Rect viewport, float z, UnityEngine.Camera.MonoOrStereoscopicEye eye, UnityEngine.Vector3[] outCorners);
        /*0x7e1e7c0*/ UnityEngine.SceneManagement.Scene get_scene();
        /*0x7e1e88c*/ void set_scene(UnityEngine.SceneManagement.Scene value);
        /*0x7e1e954*/ bool get_stereoEnabled();
        /*0x7e1ea08*/ float get_stereoSeparation();
        /*0x7e1eabc*/ void set_stereoSeparation(float value);
        /*0x7e1eb90*/ float get_stereoConvergence();
        /*0x7e1ec44*/ void set_stereoConvergence(float value);
        /*0x7e1ed18*/ bool get_areVRStereoViewMatricesWithinSingleCullTolerance();
        /*0x7e1edcc*/ UnityEngine.StereoTargetEyeMask get_stereoTargetEye();
        /*0x7e1ee48*/ void set_stereoTargetEye(UnityEngine.StereoTargetEyeMask value);
        /*0x7e1edd0*/ UnityEngine.StereoTargetEyeMask get_stereoTargetEyeInternal();
        /*0x7e1ef34*/ void set_stereoTargetEyeInternal(UnityEngine.StereoTargetEyeMask value);
        /*0x7e1f034*/ UnityEngine.Camera.MonoOrStereoscopicEye get_stereoActiveEye();
        /*0x7e1f0e8*/ UnityEngine.Matrix4x4 GetStereoNonJitteredProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye);
        /*0x7e1f1f4*/ UnityEngine.Matrix4x4 GetStereoViewMatrix(UnityEngine.Camera.StereoscopicEye eye);
        /*0x7e1f300*/ void CopyStereoDeviceProjectionMatrixToNonJittered(UnityEngine.Camera.StereoscopicEye eye);
        /*0x7e1f3c4*/ UnityEngine.Matrix4x4 GetStereoProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye);
        /*0x7e1f4d0*/ void SetStereoProjectionMatrix(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4 matrix);
        /*0x7e1f5b4*/ void ResetStereoProjectionMatrices();
        /*0x7e1f668*/ void SetStereoViewMatrix(UnityEngine.Camera.StereoscopicEye eye, UnityEngine.Matrix4x4 matrix);
        /*0x7e1f74c*/ void ResetStereoViewMatrices();
        /*0x7e1fa38*/ bool RenderToCubemapImpl(UnityEngine.Texture tex, int faceMask);
        /*0x7e1fb48*/ bool RenderToCubemap(UnityEngine.Cubemap cubemap, int faceMask);
        /*0x7e1fb4c*/ bool RenderToCubemap(UnityEngine.Cubemap cubemap);
        /*0x7e1fb54*/ bool RenderToCubemap(UnityEngine.RenderTexture cubemap, int faceMask);
        /*0x7e1fb58*/ bool RenderToCubemap(UnityEngine.RenderTexture cubemap);
        /*0x7e1fb60*/ int GetFilterMode();
        /*0x7e1fc14*/ UnityEngine.Camera.SceneViewFilterMode get_sceneViewFilterMode();
        /*0x7e1fc18*/ bool get_renderCloudsInSceneView();
        /*0x7e1fccc*/ void set_renderCloudsInSceneView(bool value);
        /*0x7e1fd90*/ bool RenderToCubemapEyeImpl(UnityEngine.RenderTexture cubemap, int faceMask, UnityEngine.Camera.MonoOrStereoscopicEye stereoEye);
        /*0x7e1feb8*/ bool RenderToCubemap(UnityEngine.RenderTexture cubemap, int faceMask, UnityEngine.Camera.MonoOrStereoscopicEye stereoEye);
        /*0x7e1febc*/ void Render();
        /*0x7e1ff70*/ void RenderWithShader(UnityEngine.Shader shader, string replacementTag);
        /*0x7e201a0*/ void RenderDontRestore();
        /*0x7e20254*/ void SubmitRenderRequests(System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests);
        /*0x3910ae8*/ void SubmitRenderRequest<RequestData>(RequestData renderRequest);
        /*0x7e203a0*/ void SubmitRenderRequestsInternal(object requests);
        /*0x7e20464*/ UnityEngine.Object[] SubmitBuiltInObjectIDRenderRequest(UnityEngine.RenderTexture target, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
        /*0x7e20664*/ void CopyFrom(UnityEngine.Camera other);
        /*0x7e2075c*/ int get_commandBufferCount();
        /*0x7e20810*/ void RemoveCommandBuffersImpl(UnityEngine.Rendering.CameraEvent evt);
        /*0x7e208d4*/ void RemoveAllCommandBuffersImpl();
        /*0x7e20988*/ void RemoveCommandBuffers(UnityEngine.Rendering.CameraEvent evt);
        /*0x7e20a84*/ void RemoveAllCommandBuffers();
        /*0x7e20b6c*/ void AddCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x7e20ca8*/ void AddCommandBufferAsyncImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType);
        /*0x7e20df4*/ void RemoveCommandBufferImpl(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x7e20f30*/ void AddCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x7e21124*/ void AddCommandBufferAsync(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType);
        /*0x7e21320*/ void RemoveCommandBuffer(UnityEngine.Rendering.CameraEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x7e21514*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.CameraEvent evt);
        /*0x7e215f8*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffersImpl(UnityEngine.Rendering.CameraEvent evt);
        /*0x7e21820*/ void OnlyUsedForTesting1();
        /*0x7e21824*/ void OnlyUsedForTesting2();
        /*0x7e21828*/ bool TryGetCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters);
        /*0x7e218e4*/ bool TryGetCullingParameters(bool stereoAware, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters);

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

            /*0x7e2194c*/ UnityEngine.Camera.GateFitMode get_mode();
            /*0x7e21954*/ float get_aspect();
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
            /*0x7e2195c*/ CameraCallback(object object, nint method);
            /*0x7e21a0c*/ void Invoke(UnityEngine.Camera cam);
        }
    }

    struct BoundingSphere
    {
        /*0x10*/ UnityEngine.Vector3 position;
        /*0x1c*/ float radius;

        /*0x7e21a20*/ BoundingSphere(UnityEngine.Vector3 pos, float rad);
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

        static /*0x7e2220c*/ void SendEvents(UnityEngine.CullingGroup cullingGroup, nint eventsPtr, int count);
        static /*0x7e21a88*/ nint Init(object scripting);
        static /*0x7e21c04*/ void DisposeInternal_Injected(nint _unity_self);
        static /*0x7e21d00*/ void set_targetCamera_Injected(nint _unity_self, nint value);
        static /*0x7e21d9c*/ void SetBoundingSpheres_Injected(nint _unity_self, UnityEngine.BoundingSphere[] array);
        static /*0x7e21e38*/ void SetBoundingSphereCount_Injected(nint _unity_self, int count);
        static /*0x7e21fb4*/ int QueryIndices_Injected(nint _unity_self, bool visible, int distanceIndex, UnityEngine.CullingQueryOptions options, ref UnityEngine.Bindings.ManagedSpanWrapper result, int firstIndex);
        static /*0x7e22118*/ void SetBoundingDistances_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper distances);
        static /*0x7e221c4*/ void SetDistanceReferencePoint_InternalVector3_Injected(nint _unity_self, ref UnityEngine.Vector3 point);
        static /*0x7e22268*/ void FinalizerFailure_Injected(nint _unity_self);
        /*0x7e21a2c*/ CullingGroup();
        /*0x7e21ac4*/ void Finalize();
        /*0x7e21bb4*/ void DisposeInternal();
        /*0x7e21c40*/ void Dispose();
        /*0x7e21c58*/ void set_targetCamera(UnityEngine.Camera value);
        /*0x7e21d44*/ void SetBoundingSpheres(UnityEngine.BoundingSphere[] array);
        /*0x7e21de0*/ void SetBoundingSphereCount(int count);
        /*0x7e21e7c*/ int QueryIndices(bool visible, int[] result, int firstIndex);
        /*0x7e21e94*/ int QueryIndices(bool visible, int distanceIndex, UnityEngine.CullingQueryOptions options, int[] result, int firstIndex);
        /*0x7e22028*/ void SetBoundingDistances(float[] distances);
        /*0x7e2215c*/ void SetDistanceReferencePoint_InternalVector3(UnityEngine.Vector3 point);
        /*0x7e22208*/ void SetDistanceReferencePoint(UnityEngine.Vector3 point);
        /*0x7e21b64*/ void FinalizerFailure();

        class StateChanged : System.MulticastDelegate
        {
            /*0x7e222a4*/ StateChanged(object object, nint method);
            /*0x7e22344*/ void Invoke(UnityEngine.CullingGroupEvent sphere);
        }

        class BindingsMarshaller
        {
            static /*0x7e22358*/ nint ConvertToNative(UnityEngine.CullingGroup cullingGroup);
        }
    }

    class ReflectionProbe : UnityEngine.Behaviour
    {
        static /*0x0*/ System.Action<UnityEngine.ReflectionProbe, UnityEngine.ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged;
        static /*0x8*/ System.Collections.Generic.Dictionary<int, System.Action<UnityEngine.Texture>> registeredDefaultReflectionSetActions;
        static /*0x10*/ System.Collections.Generic.List<System.Action<UnityEngine.Texture>> registeredDefaultReflectionTextureActions;

        static /*0x7e227d0*/ ReflectionProbe();
        static /*0x7e22448*/ UnityEngine.Vector4 get_defaultTextureHDRDecodeValues();
        static /*0x7e2250c*/ UnityEngine.Texture get_defaultTexture();
        static /*0x7e225bc*/ void CallReflectionProbeEvent(UnityEngine.ReflectionProbe probe, UnityEngine.ReflectionProbe.ReflectionProbeEvent probeEvent);
        static /*0x7e2264c*/ void CallSetDefaultReflection(UnityEngine.Texture defaultReflectionCubemap);
        static /*0x7e2240c*/ UnityEngine.Rendering.ReflectionProbeRefreshMode get_refreshMode_Injected(nint _unity_self);
        static /*0x7e224d0*/ void get_defaultTextureHDRDecodeValues_Injected(ref UnityEngine.Vector4 ret);
        static /*0x7e22594*/ nint get_defaultTexture_Injected();
        /*0x7e22370*/ UnityEngine.Rendering.ReflectionProbeRefreshMode get_refreshMode();

        enum ReflectionProbeEvent
        {
            ReflectionProbeAdded = 0,
            ReflectionProbeRemoved = 1,
        }
    }

    class DebugLogHandler : UnityEngine.ILogHandler
    {
        static /*0x7e228b8*/ void Internal_Log(UnityEngine.LogType level, UnityEngine.LogOption options, string msg, UnityEngine.Object obj);
        static /*0x7e22ac8*/ void Internal_LogException(System.Exception ex, UnityEngine.Object obj);
        static /*0x7e22a6c*/ void Internal_Log_Injected(UnityEngine.LogType level, UnityEngine.LogOption options, ref UnityEngine.Bindings.ManagedSpanWrapper msg, nint obj);
        static /*0x7e22b5c*/ void Internal_LogException_Injected(System.Exception ex, nint obj);
        /*0x7e22c78*/ DebugLogHandler();
        /*0x7e22ba0*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
        /*0x7e22bdc*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.LogOption logOptions, UnityEngine.Object context, string format, object[] args);
        /*0x7e22c1c*/ void LogException(System.Exception exception, UnityEngine.Object context);
    }

    class Debug
    {
        static /*0x0*/ UnityEngine.ILogger s_DefaultLogger;
        static /*0x8*/ UnityEngine.ILogger s_Logger;

        static /*0x7e24950*/ Debug();
        static /*0x7e22c80*/ UnityEngine.ILogger get_unityLogger();
        static /*0x7e22cd8*/ void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color);
        static /*0x7e22dc0*/ void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, float duration, bool depthTest);
        static /*0x7e22ee0*/ int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder);
        static /*0x7e230e4*/ void Log(object message);
        static /*0x7e231ec*/ void Log(object message, UnityEngine.Object context);
        static /*0x7e23304*/ void LogFormat(string format, object[] args);
        static /*0x7e2341c*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.LogOption logOptions, UnityEngine.Object context, string format, object[] args);
        static /*0x7e23700*/ void LogError(object message);
        static /*0x7e23808*/ void LogError(object message, UnityEngine.Object context);
        static /*0x7e23920*/ void LogErrorFormat(string format, object[] args);
        static /*0x7e23a38*/ void LogErrorFormat(UnityEngine.Object context, string format, object[] args);
        static /*0x7e15534*/ void LogException(System.Exception exception);
        static /*0x7e0e2e4*/ void LogException(System.Exception exception, UnityEngine.Object context);
        static /*0x7e190a4*/ void LogWarning(object message);
        static /*0x7e23b54*/ void LogWarning(object message, UnityEngine.Object context);
        static /*0x7e23c6c*/ void LogWarningFormat(string format, object[] args);
        static /*0x7e23d84*/ void LogWarningFormat(UnityEngine.Object context, string format, object[] args);
        static /*0x7e23ea0*/ void Assert(bool condition);
        static /*0x7e23fd0*/ void Assert(bool condition, string message);
        static /*0x7e240ec*/ void LogAssertion(object message);
        static /*0x7e241f4*/ void LogAssertionFormat(string format, object[] args);
        static /*0x7e2430c*/ bool get_isDebugBuild();
        static /*0x7e24334*/ bool CallOverridenDebugHandler(System.Exception exception, UnityEngine.Object obj);
        static /*0x7e2472c*/ bool IsLoggingEnabled();
        static /*0x7e22e74*/ void DrawLine_Injected(ref UnityEngine.Vector3 start, ref UnityEngine.Vector3 end, ref UnityEngine.Color color, float duration, bool depthTest);
        static /*0x7e23090*/ int ExtractStackTraceNoAlloc_Injected(byte* buffer, int bufferMax, ref UnityEngine.Bindings.ManagedSpanWrapper projectFolder);
    }

    struct ExposedReference<T>
    {
        /*0x0*/ UnityEngine.PropertyName exposedName;
        /*0x0*/ UnityEngine.Object defaultValue;

        /*0x3910ae8*/ T Resolve(UnityEngine.IExposedPropertyTable resolver);
    }

    interface IExposedPropertyTable
    {
        UnityEngine.Object GetReferenceValue(UnityEngine.PropertyName id, ref bool idValid);
    }

    class ExpressionEvaluator
    {
        static /*0x0*/ UnityEngine.ExpressionEvaluator.PcgRandom s_Random;
        static /*0x10*/ System.Collections.Generic.Dictionary<string, UnityEngine.ExpressionEvaluator.Operator> s_Operators;

        static /*0x7e261ec*/ ExpressionEvaluator();
        static /*0x3825c3c*/ bool Evaluate<T>(string expression, ref T value, ref UnityEngine.ExpressionEvaluator.Expression delayed);
        static /*0x3910ae8*/ bool EvaluateTokens<T>(string[] tokens, ref T value, int index, int count);
        static /*0x7e24a40*/ bool EvaluateDouble(string[] tokens, ref double value, int index, int count);
        static /*0x7e25498*/ string[] InfixToRPN(string[] tokens);
        static /*0x7e25904*/ bool NeedToPop(System.Collections.Generic.Stack<string> operatorStack, UnityEngine.ExpressionEvaluator.Operator newOperator);
        static /*0x7e259ec*/ string[] ExpressionToTokens(string expression, ref bool hasVariables);
        static /*0x7e25030*/ bool IsCommand(string token);
        static /*0x7e25430*/ bool IsVariable(string token);
        static /*0x7e25898*/ bool IsDelayedFunction(string token);
        static /*0x7e24f10*/ bool IsOperator(string token);
        static /*0x7e24f90*/ UnityEngine.ExpressionEvaluator.Operator TokenToOperator(string token);
        static /*0x7e25e3c*/ string PreFormatExpression(string expression);
        static /*0x7e2601c*/ string[] FixUnaryOperators(string[] tokens);
        static /*0x7e250dc*/ double EvaluateOp(double[] values, UnityEngine.ExpressionEvaluator.Op op, int index, int count);
        static /*0x3825b78*/ bool TryParse<T>(string expression, ref T result);

        class Expression
        {
            /*0x10*/ string[] rpnTokens;
            /*0x18*/ bool hasVariables;

            /*0x7e267c8*/ Expression(string expression);
            bool Evaluate<T>(ref T value, int index, int count);
        }

        struct PcgRandom
        {
            /*0x10*/ ulong increment;
            /*0x18*/ ulong state;

            static /*0x7e2688c*/ uint RotateRight(uint v, int rot);
            static /*0x7e26874*/ uint XshRr(ulong s);
            /*0x7e26760*/ PcgRandom(ulong state, ulong sequence);
            /*0x7e261b4*/ uint GetUInt();
            /*0x7e26854*/ void Step();
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

            /*0x7e26788*/ Operator(UnityEngine.ExpressionEvaluator.Op op, int precedence, int inputs, UnityEngine.ExpressionEvaluator.Associativity associativity);
        }

        class <>c
        {
            static /*0x0*/ UnityEngine.ExpressionEvaluator.<> <>9;
            static /*0x8*/ System.Func<string, bool> <>9__14_0;

            static /*0x7e26894*/ <>c();
            /*0x7e268fc*/ <>c();
            /*0x7e26904*/ bool <ExpressionToTokens>b__14_0(string f);
        }
    }

    class LightingSettings : UnityEngine.Object
    {
        static /*0x7e26a08*/ void Internal_Create(UnityEngine.LightingSettings self);
        static /*0x7e26abc*/ bool get_bakedGI_Injected(nint _unity_self);
        static /*0x7e26b78*/ void set_bakedGI_Injected(nint _unity_self, bool value);
        static /*0x7e26c34*/ bool get_realtimeGI_Injected(nint _unity_self);
        static /*0x7e26cf0*/ void set_realtimeGI_Injected(nint _unity_self, bool value);
        static /*0x7e26dac*/ bool get_realtimeEnvironmentLighting_Injected(nint _unity_self);
        static /*0x7e26e68*/ void set_realtimeEnvironmentLighting_Injected(nint _unity_self, bool value);
        /*0x7e26988*/ LightingSettings();
        /*0x7e26984*/ void LightingSettingsDontStripMe();
        /*0x7e26a44*/ bool get_bakedGI();
        /*0x7e26af8*/ void set_bakedGI(bool value);
        /*0x7e26bbc*/ bool get_realtimeGI();
        /*0x7e26c70*/ void set_realtimeGI(bool value);
        /*0x7e26d34*/ bool get_realtimeEnvironmentLighting();
        /*0x7e26de8*/ void set_realtimeEnvironmentLighting(bool value);
    }

    struct Bounds : System.IEquatable<UnityEngine.Bounds>, System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3 m_Center;
        /*0x1c*/ UnityEngine.Vector3 m_Extents;

        static /*0x7e27224*/ bool op_Equality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs);
        static /*0x7e272a0*/ bool op_Inequality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs);
        /*0x7e26eac*/ Bounds(UnityEngine.Vector3 center, UnityEngine.Vector3 size);
        /*0x7e26ecc*/ int GetHashCode();
        /*0x7e26fa4*/ bool Equals(object other);
        /*0x7e27074*/ bool Equals(UnityEngine.Bounds other);
        /*0x7e270e0*/ UnityEngine.Vector3 get_center();
        /*0x7e270ec*/ void set_center(UnityEngine.Vector3 value);
        /*0x7e270f8*/ UnityEngine.Vector3 get_size();
        /*0x7e27110*/ void set_size(UnityEngine.Vector3 value);
        /*0x7e2712c*/ UnityEngine.Vector3 get_extents();
        /*0x7e27138*/ void set_extents(UnityEngine.Vector3 value);
        /*0x7e27144*/ UnityEngine.Vector3 get_min();
        /*0x7e27164*/ void set_min(UnityEngine.Vector3 value);
        /*0x7e271b4*/ UnityEngine.Vector3 get_max();
        /*0x7e271d4*/ void set_max(UnityEngine.Vector3 value);
        /*0x7e2731c*/ void SetMinMax(UnityEngine.Vector3 min, UnityEngine.Vector3 max);
        /*0x7e27354*/ void Encapsulate(UnityEngine.Vector3 point);
        /*0x7e273cc*/ void Encapsulate(UnityEngine.Bounds bounds);
        /*0x7e274c8*/ bool Intersects(UnityEngine.Bounds bounds);
        /*0x7e27568*/ string ToString();
        /*0x7e27578*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct BoundsInt : System.IEquatable<UnityEngine.BoundsInt>, System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3Int m_Position;
        /*0x1c*/ UnityEngine.Vector3Int m_Size;

        /*0x7e27750*/ BoundsInt(UnityEngine.Vector3Int position, UnityEngine.Vector3Int size);
        /*0x7e27718*/ UnityEngine.Vector3Int get_position();
        /*0x7e27728*/ void set_position(UnityEngine.Vector3Int value);
        /*0x7e27734*/ UnityEngine.Vector3Int get_size();
        /*0x7e27744*/ void set_size(UnityEngine.Vector3Int value);
        /*0x7e27764*/ string ToString();
        /*0x7e27774*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x7e278e8*/ bool Equals(object other);
        /*0x7e279bc*/ bool Equals(UnityEngine.BoundsInt other);
        /*0x7e27a34*/ int GetHashCode();
    }

    class GeometryUtility
    {
        static /*0x7e27b10*/ void CalculateFrustumPlanes(UnityEngine.Camera camera, UnityEngine.Plane[] planes);
        static /*0x7e27b90*/ void CalculateFrustumPlanes(UnityEngine.Matrix4x4 worldToProjectionMatrix, UnityEngine.Plane[] planes);
        static /*0x7e27d90*/ bool TestPlanesAABB(UnityEngine.Plane[] planes, UnityEngine.Bounds bounds);
        static /*0x7e27c6c*/ void Internal_ExtractPlanes(UnityEngine.Plane[] planes, UnityEngine.Matrix4x4 worldToProjectionMatrix);
        static /*0x7e27e68*/ bool TestPlanesAABB_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper planes, ref UnityEngine.Bounds bounds);
        static /*0x7e27eac*/ void Internal_ExtractPlanes_Injected(ref UnityEngine.Bindings.BlittableArrayWrapper planes, ref UnityEngine.Matrix4x4 worldToProjectionMatrix);
    }

    struct Plane : System.IFormattable
    {
        static int size = 16;
        /*0x10*/ UnityEngine.Vector3 m_Normal;
        /*0x1c*/ float m_Distance;

        /*0x7e27f04*/ Plane(UnityEngine.Vector3 inNormal, UnityEngine.Vector3 inPoint);
        /*0x7e28014*/ Plane(UnityEngine.Vector3 inNormal, float d);
        /*0x7e280fc*/ Plane(UnityEngine.Vector3 a, UnityEngine.Vector3 b, UnityEngine.Vector3 c);
        /*0x7e27ef0*/ UnityEngine.Vector3 get_normal();
        /*0x7e27efc*/ float get_distance();
        /*0x7e28274*/ float GetDistanceToPoint(UnityEngine.Vector3 point);
        /*0x7e28298*/ bool Raycast(UnityEngine.Ray ray, ref float enter);
        /*0x7e28398*/ string ToString();
        /*0x7e283a8*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Ray : System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3 m_Origin;
        /*0x1c*/ UnityEngine.Vector3 m_Direction;

        /*0x7e28548*/ Ray(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        /*0x7e28634*/ UnityEngine.Vector3 get_origin();
        /*0x7e28640*/ UnityEngine.Vector3 get_direction();
        /*0x7e2864c*/ UnityEngine.Vector3 GetPoint(float distance);
        /*0x7e28674*/ string ToString();
        /*0x7e28684*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Rect : System.IEquatable<UnityEngine.Rect>, System.IFormattable
    {
        /*0x10*/ float m_XMin;
        /*0x14*/ float m_YMin;
        /*0x18*/ float m_Width;
        /*0x1c*/ float m_Height;

        static /*0x7e28848*/ UnityEngine.Rect get_zero();
        static /*0x7e2885c*/ UnityEngine.Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax);
        static /*0x7e28a54*/ UnityEngine.Rect OrderMinMax(UnityEngine.Rect rect);
        static /*0x7e28b60*/ bool op_Inequality(UnityEngine.Rect lhs, UnityEngine.Rect rhs);
        static /*0x7e28b94*/ bool op_Equality(UnityEngine.Rect lhs, UnityEngine.Rect rhs);
        /*0x7e28824*/ Rect(float x, float y, float width, float height);
        /*0x7e28830*/ Rect(UnityEngine.Vector2 position, UnityEngine.Vector2 size);
        /*0x7e2883c*/ Rect(UnityEngine.Rect source);
        /*0x7e28868*/ float get_x();
        /*0x7e28870*/ void set_x(float value);
        /*0x7e28878*/ float get_y();
        /*0x7e28880*/ void set_y(float value);
        /*0x7e28888*/ UnityEngine.Vector2 get_position();
        /*0x7e28890*/ void set_position(UnityEngine.Vector2 value);
        /*0x7e28898*/ UnityEngine.Vector2 get_center();
        /*0x7e288b0*/ void set_center(UnityEngine.Vector2 value);
        /*0x7e288cc*/ UnityEngine.Vector2 get_min();
        /*0x7e288d4*/ void set_min(UnityEngine.Vector2 value);
        /*0x7e288f0*/ UnityEngine.Vector2 get_max();
        /*0x7e28900*/ void set_max(UnityEngine.Vector2 value);
        /*0x7e28914*/ float get_width();
        /*0x7e2891c*/ void set_width(float value);
        /*0x7e28924*/ float get_height();
        /*0x7e2892c*/ void set_height(float value);
        /*0x7e28934*/ UnityEngine.Vector2 get_size();
        /*0x7e2893c*/ void set_size(UnityEngine.Vector2 value);
        /*0x7e28944*/ float get_xMin();
        /*0x7e2894c*/ void set_xMin(float value);
        /*0x7e28968*/ float get_yMin();
        /*0x7e28970*/ void set_yMin(float value);
        /*0x7e2898c*/ float get_xMax();
        /*0x7e2899c*/ void set_xMax(float value);
        /*0x7e289ac*/ float get_yMax();
        /*0x7e289bc*/ void set_yMax(float value);
        /*0x7e289cc*/ bool Contains(UnityEngine.Vector2 point);
        /*0x7e28a10*/ bool Contains(UnityEngine.Vector3 point);
        /*0x7e28a80*/ bool Overlaps(UnityEngine.Rect other);
        /*0x7e28acc*/ bool Overlaps(UnityEngine.Rect other, bool allowInverse);
        /*0x7e28bc8*/ int GetHashCode();
        /*0x7e28c54*/ bool Equals(object other);
        /*0x7e28d4c*/ bool Equals(UnityEngine.Rect other);
        /*0x7e28df8*/ string ToString();
        /*0x7e28e04*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct RectInt : System.IEquatable<UnityEngine.RectInt>, System.IFormattable
    {
        /*0x10*/ int m_XMin;
        /*0x14*/ int m_YMin;
        /*0x18*/ int m_Width;
        /*0x1c*/ int m_Height;

        /*0x7e29ecc*/ RectInt(int xMin, int yMin, int width, int height);
        /*0x7e29cfc*/ int get_x();
        /*0x7e29d04*/ void set_x(int value);
        /*0x7e29d0c*/ int get_y();
        /*0x7e29d14*/ void set_y(int value);
        /*0x7e29d1c*/ int get_width();
        /*0x7e29d24*/ void set_width(int value);
        /*0x7e29d2c*/ int get_height();
        /*0x7e29d34*/ void set_height(int value);
        /*0x7e29d3c*/ int get_xMin();
        /*0x7e29da0*/ int get_yMin();
        /*0x7e29e04*/ int get_xMax();
        /*0x7e29e68*/ int get_yMax();
        /*0x7e29ed8*/ bool Overlaps(UnityEngine.RectInt other);
        /*0x7e2a178*/ string ToString();
        /*0x7e2a188*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x7e2a3c4*/ int GetHashCode();
        /*0x7e2a45c*/ bool Equals(object other);
        /*0x7e2a504*/ bool Equals(UnityEngine.RectInt other);
    }

    class RectOffset : System.IFormattable
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ object m_SourceStyle;

        static /*0x7e2a590*/ nint InternalCreate();
        static /*0x7e2ac9c*/ void InternalDestroy(nint ptr);
        static /*0x7e2acd8*/ int get_left_Injected(nint _unity_self);
        static /*0x7e2ad14*/ void set_left_Injected(nint _unity_self, int value);
        static /*0x7e2ad58*/ int get_right_Injected(nint _unity_self);
        static /*0x7e2ad94*/ void set_right_Injected(nint _unity_self, int value);
        static /*0x7e2add8*/ int get_top_Injected(nint _unity_self);
        static /*0x7e2ae14*/ void set_top_Injected(nint _unity_self, int value);
        static /*0x7e2ae58*/ int get_bottom_Injected(nint _unity_self);
        static /*0x7e2ae94*/ void set_bottom_Injected(nint _unity_self, int value);
        static /*0x7e2af28*/ int get_horizontal_Injected(nint _unity_self);
        static /*0x7e2afb4*/ int get_vertical_Injected(nint _unity_self);
        static /*0x7e2b068*/ void Remove_Injected(nint _unity_self, ref UnityEngine.Rect rect, ref UnityEngine.Rect ret);
        /*0x7e2a548*/ RectOffset();
        /*0x7e2a5b8*/ RectOffset(object sourceStyle, nint source);
        /*0x7e2a70c*/ RectOffset(int left, int right, int top, int bottom);
        /*0x7e2a5f4*/ void Finalize();
        /*0x7e2a900*/ string ToString();
        /*0x7e2a910*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x7e2a6c0*/ void Destroy();
        /*0x7e2ab5c*/ int get_left();
        /*0x7e2a7a0*/ void set_left(int value);
        /*0x7e2abac*/ int get_right();
        /*0x7e2a7f8*/ void set_right(int value);
        /*0x7e2abfc*/ int get_top();
        /*0x7e2a850*/ void set_top(int value);
        /*0x7e2ac4c*/ int get_bottom();
        /*0x7e2a8a8*/ void set_bottom(int value);
        /*0x7e2aed8*/ int get_horizontal();
        /*0x7e2af64*/ int get_vertical();
        /*0x7e2aff0*/ UnityEngine.Rect Remove(UnityEngine.Rect rect);

        class BindingsMarshaller
        {
            static /*0x7e2b0bc*/ nint ConvertToNative(UnityEngine.RectOffset rectOffset);
        }
    }

    class Gizmos
    {
        static /*0x7e2b0d4*/ void DrawLine(UnityEngine.Vector3 from, UnityEngine.Vector3 to);
        static /*0x7e2b168*/ void DrawWireSphere(UnityEngine.Vector3 center, float radius);
        static /*0x7e2b208*/ void DrawSphere(UnityEngine.Vector3 center, float radius);
        static /*0x7e2b2a8*/ void DrawWireCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size);
        static /*0x7e2b33c*/ void DrawCube(UnityEngine.Vector3 center, UnityEngine.Vector3 size);
        static /*0x7e2b3d0*/ void DrawMesh(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale);
        static /*0x7e2b508*/ void DrawWireMesh(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale);
        static /*0x7e2b640*/ void DrawIcon(UnityEngine.Vector3 center, string name, bool allowScaling, UnityEngine.Color tint);
        static /*0x7e2b824*/ void set_color(UnityEngine.Color value);
        static /*0x7e2b8a4*/ void set_matrix(UnityEngine.Matrix4x4 value);
        static /*0x7e2b91c*/ void DrawMesh(UnityEngine.Mesh mesh);
        static /*0x7e2ba20*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale);
        static /*0x7e2ba38*/ void DrawWireMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Vector3 scale);
        static /*0x7e2b124*/ void DrawLine_Injected(ref UnityEngine.Vector3 from, ref UnityEngine.Vector3 to);
        static /*0x7e2b1bc*/ void DrawWireSphere_Injected(ref UnityEngine.Vector3 center, float radius);
        static /*0x7e2b25c*/ void DrawSphere_Injected(ref UnityEngine.Vector3 center, float radius);
        static /*0x7e2b2f8*/ void DrawWireCube_Injected(ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 size);
        static /*0x7e2b38c*/ void DrawCube_Injected(ref UnityEngine.Vector3 center, ref UnityEngine.Vector3 size);
        static /*0x7e2b49c*/ void DrawMesh_Injected(nint mesh, int submeshIndex, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 scale);
        static /*0x7e2b5d4*/ void DrawWireMesh_Injected(nint mesh, int submeshIndex, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 scale);
        static /*0x7e2b7c8*/ void DrawIcon_Injected(ref UnityEngine.Vector3 center, ref UnityEngine.Bindings.ManagedSpanWrapper name, bool allowScaling, ref UnityEngine.Color tint);
        static /*0x7e2b868*/ void set_color_Injected(ref UnityEngine.Color value);
        static /*0x7e2b8e0*/ void set_matrix_Injected(ref UnityEngine.Matrix4x4 value);
    }

    class BeforeRenderHelper
    {
        static /*0x0*/ System.Collections.Generic.List<UnityEngine.BeforeRenderHelper.OrderBlock> s_OrderBlocks;

        static /*0x7e2bbfc*/ BeforeRenderHelper();
        static /*0x7e2ba50*/ void Invoke();

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

        static /*0x7e2bc94*/ void InvokeOnTextureLoaded_Internal(UnityEngine.CustomRenderTexture source);
        static /*0x7e2bd00*/ void InvokeOnTextureUnloaded_Internal(UnityEngine.CustomRenderTexture source);
        static /*0x7e2bd6c*/ void InvokeTriggerUpdate(UnityEngine.CustomRenderTexture crt, int updateCount);
        static /*0x7e2bdec*/ void InvokeTriggerInitialize(UnityEngine.CustomRenderTexture crt);
    }

    class Display
    {
        static /*0x0*/ UnityEngine.Display[] displays;
        static /*0x8*/ UnityEngine.Display _mainDisplay;
        static /*0x10*/ int m_ActiveEditorGameViewTarget;
        static /*0x18*/ UnityEngine.Display.DisplaysUpdatedDelegate onDisplaysUpdated;
        /*0x10*/ nint nativeDisplay;

        static /*0x7e2c6ec*/ Display();
        static /*0x7e2c354*/ UnityEngine.Vector3 RelativeMouseAt(UnityEngine.Vector3 inputMouseCoordinates);
        static /*0x7e2c470*/ UnityEngine.Display get_main();
        static /*0x7e2c4c8*/ void RecreateDisplayList(nint[] nativeDisplay);
        static /*0x7e2c658*/ void FireDisplaysUpdated();
        static /*0x7e2c0cc*/ void GetSystemExtImpl(nint nativeDisplay, ref int w, ref int h);
        static /*0x7e2bf50*/ void GetRenderingExtImpl(nint nativeDisplay, ref int w, ref int h);
        static /*0x7e2c24c*/ void GetRenderingBuffersImpl(nint nativeDisplay, ref UnityEngine.RenderBuffer color, ref UnityEngine.RenderBuffer depth);
        static /*0x7e2c414*/ int RelativeMouseAtImpl(int x, int y, ref int rx, ref int ry);
        static /*0x7e2c318*/ bool RequiresSrgbBlitToBackbufferImpl(nint nativeDisplay);
        /*0x7e2be58*/ Display();
        /*0x7e2be94*/ Display(nint nativeDisplay);
        /*0x7e2bebc*/ int get_renderingWidth();
        /*0x7e2bfa4*/ int get_renderingHeight();
        /*0x7e2c038*/ int get_systemWidth();
        /*0x7e2c120*/ int get_systemHeight();
        /*0x7e2c1b4*/ UnityEngine.RenderBuffer get_colorBuffer();
        /*0x7e2c2a0*/ bool get_requiresSrgbBlitToBackbuffer();

        class DisplaysUpdatedDelegate : System.MulticastDelegate
        {
            /*0x7e2c828*/ DisplaysUpdatedDelegate(object object, nint method);
            /*0x7e2c8c4*/ void Invoke();
        }
    }

    struct LightProbesQuery : System.IDisposable
    {
        /*0x10*/ nint m_LightProbeContextWrapper;
        /*0x18*/ Unity.Collections.Allocator m_AllocatorLabel;

        static /*0x7e2c92c*/ nint Create();
        static /*0x7e2ca40*/ void Destroy(nint lightProbeContextWrapper);
        static /*0x7e2cdac*/ void CalculateInterpolatedLightAndOcclusionProbes(nint lightProbeContextWrapper, nint positions, nint tetrahedronIndices, nint lightProbes, nint occlusionProbes, int count);
        /*0x7e2c8d8*/ LightProbesQuery(Unity.Collections.Allocator allocator);
        /*0x7e2c954*/ void Dispose();
        /*0x7e2ca7c*/ Unity.Jobs.JobHandle Dispose(Unity.Jobs.JobHandle inputDeps);
        /*0x7e2cb74*/ void CalculateInterpolatedLightAndOcclusionProbes(Unity.Collections.NativeArray<UnityEngine.Vector3> positions, Unity.Collections.NativeArray<int> tetrahedronIndices, Unity.Collections.NativeArray<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, Unity.Collections.NativeArray<UnityEngine.Vector4> occlusionProbes);

        struct LightProbesQueryDispose
        {
            /*0x10*/ nint m_LightProbeContextWrapper;

            /*0x7e2ce20*/ void Dispose();
        }

        struct LightProbesQueryDisposeJob : Unity.Jobs.IJob
        {
            /*0x10*/ UnityEngine.LightProbesQuery.LightProbesQueryDispose Data;

            /*0x7e2ce70*/ void Execute();
        }
    }

    struct RefreshRate : System.IEquatable<UnityEngine.RefreshRate>, System.IComparable<UnityEngine.RefreshRate>
    {
        /*0x10*/ uint numerator;
        /*0x14*/ uint denominator;

        /*0x7e2ce74*/ double get_value();
        /*0x7e2ce88*/ bool Equals(UnityEngine.RefreshRate other);
        /*0x7e2cec4*/ int CompareTo(UnityEngine.RefreshRate other);
        /*0x7e2cf18*/ string ToString();
    }

    class Screen
    {
        static /*0x7e2cfb8*/ int get_width();
        static /*0x7e2cfe0*/ int get_height();
        static /*0x7e2d008*/ float get_dpi();
        static /*0x7e2d030*/ UnityEngine.ScreenOrientation GetScreenOrientation();
        static /*0x7e2d058*/ UnityEngine.ScreenOrientation get_orientation();
        static /*0x7e2d080*/ void set_sleepTimeout(int value);
        static /*0x7e2d0bc*/ UnityEngine.Resolution get_currentResolution();
        static /*0x7e2d13c*/ bool get_fullScreen();
        static /*0x7e2d164*/ UnityEngine.Rect get_safeArea();
        static /*0x7e2d1e8*/ void SetMSAASamples(int numSamples);
        static /*0x7e2d224*/ int GetMSAASamples();
        static /*0x7e2d24c*/ int get_msaaSamples();
        static /*0x7e2d100*/ void get_currentResolution_Injected(ref UnityEngine.Resolution ret);
        static /*0x7e2d1ac*/ void get_safeArea_Injected(ref UnityEngine.Rect ret);
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

        static /*0x7e2f244*/ Graphics();
        static /*0x7e2d274*/ int Internal_GetMaxDrawMeshInstanceCount();
        static /*0x7e2d29c*/ UnityEngine.Rendering.GraphicsTier get_activeTier();
        static /*0x7e2d2c4*/ void set_activeTier(UnityEngine.Rendering.GraphicsTier value);
        static /*0x7e2d300*/ bool GetPreserveFramebufferAlpha();
        static /*0x7e2d328*/ bool get_preserveFramebufferAlpha();
        static /*0x7e2d390*/ UnityEngine.Rendering.OpenGLESVersion GetMinOpenGLESVersion();
        static /*0x7e2d3b8*/ UnityEngine.Rendering.OpenGLESVersion get_minOpenGLESVersion();
        static /*0x7e2d420*/ void Internal_SetNullRT();
        static /*0x7e2d448*/ void Internal_SetRTSimple(UnityEngine.RenderBuffer color, UnityEngine.RenderBuffer depth, int mip, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x7e2d55c*/ void ClearRandomWriteTargets();
        static /*0x7e2d584*/ void CopyTexture_Slice(UnityEngine.Texture src, int srcElement, int srcMip, UnityEngine.Texture dst, int dstElement, int dstMip);
        static /*0x7e2d6f8*/ void CopyTexture_Region(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, UnityEngine.Texture dst, int dstElement, int dstMip, int dstX, int dstY);
        static /*0x7e2d8f0*/ void Internal_DrawMesh(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int layer, UnityEngine.Camera camera, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x7e2db94*/ void Internal_DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x7e2defc*/ void Blit2(UnityEngine.Texture source, UnityEngine.RenderTexture dest);
        static /*0x7e2e01c*/ void Blit4(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset);
        static /*0x7e2e170*/ void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer buffer);
        static /*0x7e2e26c*/ void SetRenderTargetImpl(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, int mipLevel, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x7e2e308*/ void SetRenderTargetImpl(UnityEngine.RenderTexture rt, int mipLevel, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x7e2e43c*/ void SetRenderTarget(UnityEngine.RenderTexture rt, int mipLevel, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x7e2e4b8*/ void CopyTexture(UnityEngine.Texture src, int srcElement, int srcMip, UnityEngine.Texture dst, int dstElement, int dstMip);
        static /*0x7e2e54c*/ void CopyTexture(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, UnityEngine.Texture dst, int dstElement, int dstMip, int dstX, int dstY);
        static /*0x7e2e664*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int layer, UnityEngine.Camera camera, int submeshIndex, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, UnityEngine.Transform probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x7e2e7fc*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, UnityEngine.Camera camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, UnityEngine.LightProbeProxyVolume lightProbeProxyVolume);
        static /*0x7e2ed54*/ void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest);
        static /*0x7e2edb8*/ void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset);
        static /*0x7e2ee4c*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Material material, int layer, UnityEngine.Camera camera);
        static /*0x7e2efbc*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int layer, UnityEngine.Camera camera, int submeshIndex, UnityEngine.MaterialPropertyBlock properties);
        static /*0x7e2f0a4*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, UnityEngine.Camera camera);
        static /*0x7e2f178*/ void SetRenderTarget(UnityEngine.RenderTexture rt);
        static /*0x7e2f1d8*/ void SetRenderTarget(UnityEngine.RenderTexture rt, int mipLevel);
        static /*0x7e2d4f0*/ void Internal_SetRTSimple_Injected(ref UnityEngine.RenderBuffer color, ref UnityEngine.RenderBuffer depth, int mip, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x7e2d684*/ void CopyTexture_Slice_Injected(nint src, int srcElement, int srcMip, nint dst, int dstElement, int dstMip);
        static /*0x7e2d830*/ void CopyTexture_Region_Injected(nint src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, nint dst, int dstElement, int dstMip, int dstX, int dstY);
        static /*0x7e2dad4*/ void Internal_DrawMesh_Injected(nint mesh, int submeshIndex, ref UnityEngine.Matrix4x4 matrix, nint material, int layer, nint camera, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, nint probeAnchor, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume);
        static /*0x7e2de3c*/ void Internal_DrawMeshInstanced_Injected(nint mesh, int submeshIndex, nint material, ref UnityEngine.Bindings.ManagedSpanWrapper matrices, int count, nint properties, UnityEngine.Rendering.ShadowCastingMode castShadows, bool receiveShadows, int layer, nint camera, UnityEngine.Rendering.LightProbeUsage lightProbeUsage, nint lightProbeProxyVolume);
        static /*0x7e2dfd8*/ void Blit2_Injected(nint source, nint dest);
        static /*0x7e2e114*/ void Blit4_Injected(nint source, nint dest, ref UnityEngine.Vector2 scale, ref UnityEngine.Vector2 offset);
        static /*0x7e2e230*/ void ExecuteCommandBuffer_Injected(nint buffer);
    }

    class GL
    {
        static /*0x7e2f304*/ void Vertex3(float x, float y, float z);
        static /*0x7e2f354*/ void TexCoord3(float x, float y, float z);
        static /*0x7e2f3a4*/ void TexCoord2(float x, float y);
        static /*0x7e2f3e8*/ void ImmediateColor(float r, float g, float b, float a);
        static /*0x7e2f440*/ void Color(UnityEngine.Color c);
        static /*0x7e2f498*/ bool get_wireframe();
        static /*0x7e2f4c0*/ void SetViewMatrix(UnityEngine.Matrix4x4 m);
        static /*0x7e2f538*/ void set_modelview(UnityEngine.Matrix4x4 value);
        static /*0x7e2f584*/ void PushMatrix();
        static /*0x7e2f5ac*/ void PopMatrix();
        static /*0x7e2f5d4*/ void LoadOrtho();
        static /*0x7e2f5fc*/ void LoadProjectionMatrix(UnityEngine.Matrix4x4 mat);
        static /*0x7e2f674*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(UnityEngine.Matrix4x4 proj, bool renderIntoTexture);
        static /*0x7e2f744*/ void GLLoadPixelMatrixScript(float left, float right, float bottom, float top);
        static /*0x7e2f79c*/ void LoadPixelMatrix(float left, float right, float bottom, float top);
        static /*0x7e2f7f4*/ void Begin(int mode);
        static /*0x7e2f830*/ void End();
        static /*0x7e2f858*/ void GLClear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
        static /*0x7e2f928*/ void Clear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
        static /*0x7e2f934*/ void Clear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
        static /*0x7e2f944*/ void Viewport(UnityEngine.Rect pixelRect);
        static /*0x7e2f4fc*/ void SetViewMatrix_Injected(ref UnityEngine.Matrix4x4 m);
        static /*0x7e2f638*/ void LoadProjectionMatrix_Injected(ref UnityEngine.Matrix4x4 mat);
        static /*0x7e2f6f0*/ void GetGPUProjectionMatrix_Injected(ref UnityEngine.Matrix4x4 proj, bool renderIntoTexture, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e2f8c4*/ void GLClear_Injected(bool clearDepth, bool clearColor, ref UnityEngine.Color backgroundColor, float depth);
        static /*0x7e2f988*/ void Viewport_Injected(ref UnityEngine.Rect pixelRect);
    }

    class ScalableBufferManager
    {
        static /*0x7e2f9c4*/ float get_widthScaleFactor();
        static /*0x7e2f9ec*/ float get_heightScaleFactor();
        static /*0x7e2fa14*/ void ResizeBuffers(float widthScale, float heightScale);
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
        static /*0x7e2fa54*/ void CaptureFrameTimings();
        static /*0x7e2fa7c*/ uint GetLatestTimings(uint numFrames, UnityEngine.FrameTiming[] timings);
        static /*0x7e2fb50*/ uint GetLatestTimings_Injected(uint numFrames, ref UnityEngine.Bindings.ManagedSpanWrapper timings);
    }

    class LightmapData
    {
        /*0x10*/ UnityEngine.Texture2D m_Light;
        /*0x18*/ UnityEngine.Texture2D m_Dir;
        /*0x20*/ UnityEngine.Texture2D m_ShadowMask;

        /*0x7e2fb94*/ LightmapData();
    }

    class LightmapSettings : UnityEngine.Object
    {
        static /*0x7e2fbf4*/ UnityEngine.LightmapData[] get_lightmaps();
        static /*0x7e2fc1c*/ void set_lightmaps(UnityEngine.LightmapData[] value);
        static /*0x7e2fc58*/ UnityEngine.LightmapsMode get_lightmapsMode();
        static /*0x7e2fc80*/ void set_lightmapsMode(UnityEngine.LightmapsMode value);
        static /*0x7e2fcbc*/ UnityEngine.LightProbes get_lightProbes();
        static /*0x7e2fd48*/ void set_lightProbes(UnityEngine.LightProbes value);
        static /*0x7e2fe08*/ void Reset();
        static /*0x7e2fe30*/ UnityEngine.LightmapsModeLegacy get_lightmapsModeLegacy();
        static /*0x7e2fe38*/ void set_lightmapsModeLegacy(UnityEngine.LightmapsModeLegacy value);
        static /*0x7e2fe3c*/ UnityEngine.ColorSpace get_bakedColorSpace();
        static /*0x7e2fe8c*/ void set_bakedColorSpace(UnityEngine.ColorSpace value);
        static /*0x7e2fd20*/ nint get_lightProbes_Injected();
        static /*0x7e2fdcc*/ void set_lightProbes_Injected(nint value);
        /*0x7e2fb9c*/ LightmapSettings();
    }

    class LightProbes : UnityEngine.Object
    {
        static /*0x0*/ System.Action lightProbesUpdated;
        static /*0x8*/ System.Action tetrahedralizationCompleted;
        static /*0x10*/ System.Action needsRetetrahedralization;

        static /*0x7e2fee8*/ void add_lightProbesUpdated(System.Action value);
        static /*0x7e2ffa0*/ void remove_lightProbesUpdated(System.Action value);
        static /*0x7e30058*/ void Internal_CallLightProbesUpdatedFunction();
        static /*0x7e300bc*/ void add_tetrahedralizationCompleted(System.Action value);
        static /*0x7e30178*/ void remove_tetrahedralizationCompleted(System.Action value);
        static /*0x7e30234*/ void Internal_CallTetrahedralizationCompletedFunction();
        static /*0x7e30298*/ void add_needsRetetrahedralization(System.Action value);
        static /*0x7e30354*/ void remove_needsRetetrahedralization(System.Action value);
        static /*0x7e30410*/ void Internal_CallNeedsRetetrahedralizationFunction();
        static /*0x7e30474*/ void Tetrahedralize();
        static /*0x7e3049c*/ void TetrahedralizeAsync();
        static /*0x7e304c4*/ void GetInterpolatedProbe(UnityEngine.Vector3 position, UnityEngine.Renderer renderer, ref UnityEngine.Rendering.SphericalHarmonicsL2 probe);
        static /*0x7e305c4*/ bool AreLightProbesAllowed(UnityEngine.Renderer renderer);
        static /*0x7e30684*/ void CalculateInterpolatedLightAndOcclusionProbes(UnityEngine.Vector3[] positions, UnityEngine.Rendering.SphericalHarmonicsL2[] lightProbes, UnityEngine.Vector4[] occlusionProbes);
        static /*0x7e30998*/ void CalculateInterpolatedLightAndOcclusionProbes(System.Collections.Generic.List<UnityEngine.Vector3> positions, System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> lightProbes, System.Collections.Generic.List<UnityEngine.Vector4> occlusionProbes);
        static /*0x7e307cc*/ void CalculateInterpolatedLightAndOcclusionProbes_Internal(UnityEngine.Vector3[] positions, int positionsCount, UnityEngine.Rendering.SphericalHarmonicsL2[] lightProbes, UnityEngine.Vector4[] occlusionProbes);
        static /*0x7e30c04*/ UnityEngine.LightProbes GetSharedLightProbesForScene(UnityEngine.SceneManagement.Scene scene);
        static /*0x7e30cb0*/ UnityEngine.LightProbes GetInstantiatedLightProbesForScene(UnityEngine.SceneManagement.Scene scene);
        static /*0x7e31714*/ int GetCount();
        static /*0x7e30570*/ void GetInterpolatedProbe_Injected(ref UnityEngine.Vector3 position, nint renderer, ref UnityEngine.Rendering.SphericalHarmonicsL2 probe);
        static /*0x7e30648*/ bool AreLightProbesAllowed_Injected(nint renderer);
        static /*0x7e30ba8*/ void CalculateInterpolatedLightAndOcclusionProbes_Internal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper positions, int positionsCount, ref UnityEngine.Bindings.ManagedSpanWrapper lightProbes, ref UnityEngine.Bindings.ManagedSpanWrapper occlusionProbes);
        static /*0x7e30c74*/ nint GetSharedLightProbesForScene_Injected(ref UnityEngine.SceneManagement.Scene scene);
        static /*0x7e30d20*/ nint GetInstantiatedLightProbesForScene_Injected(ref UnityEngine.SceneManagement.Scene scene);
        static /*0x7e30e84*/ void get_positions_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e30ff0*/ void GetPositionsSelf_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e31144*/ bool SetPositionsSelf_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper positions, bool checkForDuplicatePositions);
        static /*0x7e312c0*/ void get_bakedProbes_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e31400*/ void set_bakedProbes_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7e314bc*/ int get_count_Injected(nint _unity_self);
        static /*0x7e31570*/ int get_countSelf_Injected(nint _unity_self);
        static /*0x7e31624*/ int get_cellCount_Injected(nint _unity_self);
        static /*0x7e316d8*/ int get_cellCountSelf_Injected(nint _unity_self);
        /*0x7e2fe90*/ LightProbes();
        /*0x7e30d5c*/ UnityEngine.Vector3[] get_positions();
        /*0x7e30ec8*/ UnityEngine.Vector3[] GetPositionsSelf();
        /*0x7e31034*/ bool SetPositionsSelf(UnityEngine.Vector3[] positions, bool checkForDuplicatePositions);
        /*0x7e31198*/ UnityEngine.Rendering.SphericalHarmonicsL2[] get_bakedProbes();
        /*0x7e31304*/ void set_bakedProbes(UnityEngine.Rendering.SphericalHarmonicsL2[] value);
        /*0x7e31444*/ int get_count();
        /*0x7e314f8*/ int get_countSelf();
        /*0x7e315ac*/ int get_cellCount();
        /*0x7e31660*/ int get_cellCountSelf();
        /*0x7e3173c*/ void GetInterpolatedLightProbe(UnityEngine.Vector3 position, UnityEngine.Renderer renderer, float[] coefficients);
        /*0x7e31740*/ float[] get_coefficients();
        /*0x7e31784*/ void set_coefficients(float[] value);
    }

    class HDROutputSettings
    {
        static /*0x0*/ UnityEngine.HDROutputSettings[] displays;
        static /*0x8*/ UnityEngine.HDROutputSettings _mainDisplay;
        /*0x10*/ int m_DisplayIndex;

        static /*0x7e320c4*/ HDROutputSettings();
        static /*0x7e317cc*/ UnityEngine.HDROutputSettings get_main();
        static /*0x7e3189c*/ bool GetActive(int displayIndex);
        static /*0x7e31950*/ bool GetAvailable(int displayIndex);
        static /*0x7e31a04*/ bool GetAutomaticHDRTonemapping(int displayIndex);
        static /*0x7e31ac8*/ void SetAutomaticHDRTonemapping(int displayIndex, bool scripted);
        static /*0x7e31b84*/ UnityEngine.ColorGamut GetDisplayColorGamut(int displayIndex);
        static /*0x7e31c38*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(int displayIndex);
        static /*0x7e31cec*/ float GetPaperWhiteNits(int displayIndex);
        static /*0x7e31da0*/ int GetMaxFullFrameToneMapLuminance(int displayIndex);
        static /*0x7e31e54*/ int GetMaxToneMapLuminance(int displayIndex);
        static /*0x7e31f08*/ int GetMinToneMapLuminance(int displayIndex);
        static /*0x7e31fbc*/ bool GetHDRModeChangeRequested(int displayIndex);
        static /*0x7e32080*/ void RequestHDRModeChangeInternal(int displayIndex, bool enabled);
        /*0x7e31788*/ HDROutputSettings();
        /*0x7e317a4*/ HDROutputSettings(int displayIndex);
        /*0x7e31824*/ bool get_active();
        /*0x7e318d8*/ bool get_available();
        /*0x7e3198c*/ bool get_automaticHDRTonemapping();
        /*0x7e31a40*/ void set_automaticHDRTonemapping(bool value);
        /*0x7e31b0c*/ UnityEngine.ColorGamut get_displayColorGamut();
        /*0x7e31bc0*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x7e31c74*/ float get_paperWhiteNits();
        /*0x7e31d28*/ int get_maxFullFrameToneMapLuminance();
        /*0x7e31ddc*/ int get_maxToneMapLuminance();
        /*0x7e31e90*/ int get_minToneMapLuminance();
        /*0x7e31f44*/ bool get_HDRModeChangeRequested();
        /*0x7e31ff8*/ void RequestHDRModeChange(bool enabled);
    }

    class ColorGamutUtility
    {
        static /*0x7e321c0*/ UnityEngine.ColorPrimaries GetColorPrimaries(UnityEngine.ColorGamut gamut);
        static /*0x7e321fc*/ UnityEngine.WhitePoint GetWhitePoint(UnityEngine.ColorGamut gamut);
        static /*0x7e32238*/ UnityEngine.TransferFunction GetTransferFunction(UnityEngine.ColorGamut gamut);
    }

    struct Resolution
    {
        /*0x10*/ int m_Width;
        /*0x14*/ int m_Height;
        /*0x18*/ UnityEngine.RefreshRate m_RefreshRate;

        /*0x7e32274*/ UnityEngine.RefreshRate get_refreshRateRatio();
        /*0x7e3227c*/ string ToString();
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

        static /*0x7e32414*/ void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel);
        static /*0x7e32494*/ int get_pixelLightCount();
        static /*0x7e324bc*/ void set_pixelLightCount(int value);
        static /*0x7e324f8*/ UnityEngine.ShadowmaskMode get_shadowmaskMode();
        static /*0x7e32520*/ float get_lodBias();
        static /*0x7e32548*/ int get_maximumLODLevel();
        static /*0x7e32570*/ void set_enableLODCrossFade(bool value);
        static /*0x7e325ac*/ int get_vSyncCount();
        static /*0x7e325d4*/ void set_vSyncCount(int value);
        static /*0x7e32610*/ int get_antiAliasing();
        static /*0x7e32638*/ void set_antiAliasing(int value);
        static /*0x7e32674*/ bool get_billboardsFaceCameraPosition();
        static /*0x7e3269c*/ int GetQualityLevel();
        static /*0x7e326c4*/ string[] get_names();
        static /*0x7e2fe64*/ UnityEngine.ColorSpace get_desiredColorSpace();
        static /*0x7e326ec*/ UnityEngine.ColorSpace get_activeColorSpace();
    }

    class ImageEffectAllowedInSceneView : System.Attribute
    {
        /*0x7e32714*/ ImageEffectAllowedInSceneView();
    }

    class ImageEffectUsesCommandBuffer : System.Attribute
    {
        /*0x7e3271c*/ ImageEffectUsesCommandBuffer();
    }

    enum LightmapsModeLegacy
    {
        Single = 0,
        Dual = 1,
        Directional = 2,
    }

    class TrailRenderer : UnityEngine.Renderer
    {
        static /*0x7e3279c*/ float get_time_Injected(nint _unity_self);
        static /*0x7e32860*/ void set_time_Injected(nint _unity_self, float value);
        static /*0x7e32924*/ float get_startWidth_Injected(nint _unity_self);
        static /*0x7e329e8*/ void set_startWidth_Injected(nint _unity_self, float value);
        static /*0x7e32aac*/ float get_endWidth_Injected(nint _unity_self);
        static /*0x7e32b70*/ void set_endWidth_Injected(nint _unity_self, float value);
        /*0x7e32724*/ float get_time();
        /*0x7e327d8*/ void set_time(float value);
        /*0x7e328ac*/ float get_startWidth();
        /*0x7e32960*/ void set_startWidth(float value);
        /*0x7e32a34*/ float get_endWidth();
        /*0x7e32ae8*/ void set_endWidth(float value);
    }

    class LineRenderer : UnityEngine.Renderer
    {
        static /*0x7e32c4c*/ void set_startColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x7e32d20*/ void set_endColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        /*0x7e32bbc*/ void set_startColor(UnityEngine.Color value);
        /*0x7e32c90*/ void set_endColor(UnityEngine.Color value);
    }

    class MaterialPropertyBlock
    {
        /*0x10*/ nint m_Ptr;

        static /*0x7e33af0*/ nint CreateImpl();
        static /*0x7e33b18*/ void DestroyImpl(nint mpb);
        static /*0x7e32dbc*/ float GetFloatImpl_Injected(nint _unity_self, int name);
        static /*0x7e32e74*/ void GetColorImpl_Injected(nint _unity_self, int name, ref UnityEngine.Color ret);
        static /*0x7e32f30*/ void SetIntImpl_Injected(nint _unity_self, int name, int value);
        static /*0x7e32fec*/ void SetFloatImpl_Injected(nint _unity_self, int name, float value);
        static /*0x7e330b0*/ void SetVectorImpl_Injected(nint _unity_self, int name, ref UnityEngine.Vector4 value);
        static /*0x7e33174*/ void SetColorImpl_Injected(nint _unity_self, int name, ref UnityEngine.Color value);
        static /*0x7e33230*/ void SetMatrixImpl_Injected(nint _unity_self, int name, ref UnityEngine.Matrix4x4 value);
        static /*0x7e3336c*/ void SetTextureImpl_Injected(nint _unity_self, int name, nint value);
        static /*0x7e334b0*/ void SetRenderTextureImpl_Injected(nint _unity_self, int name, nint value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x7e3357c*/ void SetBufferImpl_Injected(nint _unity_self, int name, nint value);
        static /*0x7e33658*/ void SetConstantBufferImpl_Injected(nint _unity_self, int name, nint value, int offset, int size);
        static /*0x7e337cc*/ void SetFloatArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e33930*/ void SetVectorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e33a94*/ void SetMatrixArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e33bac*/ void Clear_Injected(nint _unity_self, bool keepMemory);
        /*0x7e33e2c*/ MaterialPropertyBlock();
        /*0x7e32d64*/ float GetFloatImpl(int name);
        /*0x7e32e00*/ UnityEngine.Color GetColorImpl(int name);
        /*0x7e32ec8*/ void SetIntImpl(int name, int value);
        /*0x7e32f84*/ void SetFloatImpl(int name, float value);
        /*0x7e33040*/ void SetVectorImpl(int name, UnityEngine.Vector4 value);
        /*0x7e33104*/ void SetColorImpl(int name, UnityEngine.Color value);
        /*0x7e331c8*/ void SetMatrixImpl(int name, UnityEngine.Matrix4x4 value);
        /*0x7e33284*/ void SetTextureImpl(int name, UnityEngine.Texture value);
        /*0x7e333c0*/ void SetRenderTextureImpl(int name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x7e3350c*/ void SetBufferImpl(int name, UnityEngine.ComputeBuffer value);
        /*0x7e335d0*/ void SetConstantBufferImpl(int name, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x7e336c4*/ void SetFloatArrayImpl(int name, float[] values, int count);
        /*0x7e33828*/ void SetVectorArrayImpl(int name, UnityEngine.Vector4[] values, int count);
        /*0x7e3398c*/ void SetMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x7e33b54*/ void Clear(bool keepMemory);
        /*0x7e33bf0*/ void Clear();
        /*0x7e33bf8*/ void SetFloatArray(int name, float[] values, int count);
        /*0x7e33cb4*/ void SetVectorArray(int name, UnityEngine.Vector4[] values, int count);
        /*0x7e33d70*/ void SetMatrixArray(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x7e33e74*/ void Finalize();
        /*0x7e33f08*/ void Dispose();
        /*0x7e33f9c*/ void SetInt(string name, int value);
        /*0x7e3413c*/ void SetInt(int nameID, int value);
        /*0x7e34144*/ void SetFloat(string name, float value);
        /*0x7e34174*/ void SetFloat(int nameID, float value);
        /*0x7e34178*/ void SetInteger(int nameID, int value);
        /*0x7e3417c*/ void SetVector(string name, UnityEngine.Vector4 value);
        /*0x7e341cc*/ void SetVector(int nameID, UnityEngine.Vector4 value);
        /*0x7e341d0*/ void SetColor(string name, UnityEngine.Color value);
        /*0x7e34220*/ void SetColor(int nameID, UnityEngine.Color value);
        /*0x7e34224*/ void SetMatrix(string name, UnityEngine.Matrix4x4 value);
        /*0x7e34270*/ void SetMatrix(int nameID, UnityEngine.Matrix4x4 value);
        /*0x7e3429c*/ void SetBuffer(string name, UnityEngine.ComputeBuffer value);
        /*0x7e342cc*/ void SetBuffer(int nameID, UnityEngine.ComputeBuffer value);
        /*0x7e342d0*/ void SetTexture(string name, UnityEngine.Texture value);
        /*0x7e34300*/ void SetTexture(int nameID, UnityEngine.Texture value);
        /*0x7e34304*/ void SetTexture(int nameID, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x7e34308*/ void SetConstantBuffer(int nameID, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x7e3430c*/ void SetFloatArray(string name, float[] values);
        /*0x7e34348*/ void SetVectorArray(string name, UnityEngine.Vector4[] values);
        /*0x7e34384*/ void SetVectorArray(int nameID, UnityEngine.Vector4[] values);
        /*0x7e3439c*/ void SetMatrixArray(string name, UnityEngine.Matrix4x4[] values);
        /*0x7e343d8*/ float GetFloat(string name);
        /*0x7e343f8*/ UnityEngine.Color GetColor(string name);

        class BindingsMarshaller
        {
            static /*0x7e34418*/ nint ConvertToNative(UnityEngine.MaterialPropertyBlock materialPropertyBlock);
        }
    }

    class Renderer : UnityEngine.Component
    {
        static /*0x7e344b0*/ void set_localBounds_Injected(nint _unity_self, ref UnityEngine.Bounds value);
        static /*0x7e34588*/ nint GetMaterial_Injected(nint _unity_self);
        static /*0x7e34658*/ nint GetSharedMaterial_Injected(nint _unity_self);
        static /*0x7e34748*/ void SetMaterial_Injected(nint _unity_self, nint m);
        static /*0x7e3480c*/ void CopyMaterialArray_Injected(nint _unity_self, UnityEngine.Material[] m);
        static /*0x7e34910*/ void SetMaterialArray_Injected(nint _unity_self, UnityEngine.Material[] m, int length);
        static /*0x7e34a10*/ void Internal_SetPropertyBlock_Injected(nint _unity_self, nint properties);
        static /*0x7e34b2c*/ void Internal_GetPropertyBlock_Injected(nint _unity_self, nint dest);
        static /*0x7e34c08*/ void Internal_SetPropertyBlockMaterialIndex_Injected(nint _unity_self, nint properties, int materialIndex);
        static /*0x7e34d44*/ void Internal_GetPropertyBlockMaterialIndex_Injected(nint _unity_self, nint dest, int materialIndex);
        static /*0x7e34e10*/ bool HasPropertyBlock_Injected(nint _unity_self);
        static /*0x7e34ed4*/ bool get_enabled_Injected(nint _unity_self);
        static /*0x7e34f90*/ void set_enabled_Injected(nint _unity_self, bool value);
        static /*0x7e3504c*/ bool get_isVisible_Injected(nint _unity_self);
        static /*0x7e35100*/ UnityEngine.Rendering.ShadowCastingMode get_shadowCastingMode_Injected(nint _unity_self);
        static /*0x7e351bc*/ void set_shadowCastingMode_Injected(nint _unity_self, UnityEngine.Rendering.ShadowCastingMode value);
        static /*0x7e35278*/ bool get_receiveShadows_Injected(nint _unity_self);
        static /*0x7e35334*/ void set_receiveShadows_Injected(nint _unity_self, bool value);
        static /*0x7e353f0*/ UnityEngine.MotionVectorGenerationMode get_motionVectorGenerationMode_Injected(nint _unity_self);
        static /*0x7e354ac*/ void set_motionVectorGenerationMode_Injected(nint _unity_self, UnityEngine.MotionVectorGenerationMode value);
        static /*0x7e35568*/ UnityEngine.Rendering.LightProbeUsage get_lightProbeUsage_Injected(nint _unity_self);
        static /*0x7e35624*/ void set_lightProbeUsage_Injected(nint _unity_self, UnityEngine.Rendering.LightProbeUsage value);
        static /*0x7e356e0*/ UnityEngine.Rendering.ReflectionProbeUsage get_reflectionProbeUsage_Injected(nint _unity_self);
        static /*0x7e3579c*/ void set_reflectionProbeUsage_Injected(nint _unity_self, UnityEngine.Rendering.ReflectionProbeUsage value);
        static /*0x7e35858*/ int get_sortingLayerID_Injected(nint _unity_self);
        static /*0x7e35914*/ void set_sortingLayerID_Injected(nint _unity_self, int value);
        static /*0x7e359d0*/ int get_sortingOrder_Injected(nint _unity_self);
        static /*0x7e35a8c*/ void set_sortingOrder_Injected(nint _unity_self, int value);
        static /*0x7e35b48*/ int get_sortingGroupID_Injected(nint _unity_self);
        static /*0x7e35bfc*/ int get_sortingGroupOrder_Injected(nint _unity_self);
        static /*0x7e35ccc*/ nint get_probeAnchor_Injected(nint _unity_self);
        static /*0x7e35dbc*/ void set_probeAnchor_Injected(nint _unity_self, nint value);
        static /*0x7e35e78*/ int GetMaterialCount_Injected(nint _unity_self);
        static /*0x7e35f2c*/ UnityEngine.Material[] GetSharedMaterialArray_Injected(nint _unity_self);
        /*0x7e36178*/ Renderer();
        /*0x7e34430*/ void set_localBounds(UnityEngine.Bounds value);
        /*0x7e344f4*/ UnityEngine.Material GetMaterial();
        /*0x7e345c4*/ UnityEngine.Material GetSharedMaterial();
        /*0x7e34694*/ void SetMaterial(UnityEngine.Material m);
        /*0x7e3478c*/ void CopyMaterialArray(UnityEngine.Material[] m);
        /*0x7e34850*/ void SetMaterialArray(UnityEngine.Material[] m, int length);
        /*0x7e34964*/ void SetMaterialArray(UnityEngine.Material[] m);
        /*0x7e34988*/ void Internal_SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties);
        /*0x7e34a54*/ void Internal_GetPropertyBlock(UnityEngine.MaterialPropertyBlock dest);
        /*0x7e34b70*/ void Internal_SetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock properties, int materialIndex);
        /*0x7e34c5c*/ void Internal_GetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock dest, int materialIndex);
        /*0x7e34d98*/ bool HasPropertyBlock();
        /*0x7e34e4c*/ void SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties);
        /*0x7e34e50*/ void SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties, int materialIndex);
        /*0x7e34e54*/ void GetPropertyBlock(UnityEngine.MaterialPropertyBlock properties);
        /*0x7e34e58*/ void GetPropertyBlock(UnityEngine.MaterialPropertyBlock properties, int materialIndex);
        /*0x7e34e5c*/ bool get_enabled();
        /*0x7e34f10*/ void set_enabled(bool value);
        /*0x7e34fd4*/ bool get_isVisible();
        /*0x7e35088*/ UnityEngine.Rendering.ShadowCastingMode get_shadowCastingMode();
        /*0x7e3513c*/ void set_shadowCastingMode(UnityEngine.Rendering.ShadowCastingMode value);
        /*0x7e35200*/ bool get_receiveShadows();
        /*0x7e352b4*/ void set_receiveShadows(bool value);
        /*0x7e35378*/ UnityEngine.MotionVectorGenerationMode get_motionVectorGenerationMode();
        /*0x7e3542c*/ void set_motionVectorGenerationMode(UnityEngine.MotionVectorGenerationMode value);
        /*0x7e354f0*/ UnityEngine.Rendering.LightProbeUsage get_lightProbeUsage();
        /*0x7e355a4*/ void set_lightProbeUsage(UnityEngine.Rendering.LightProbeUsage value);
        /*0x7e35668*/ UnityEngine.Rendering.ReflectionProbeUsage get_reflectionProbeUsage();
        /*0x7e3571c*/ void set_reflectionProbeUsage(UnityEngine.Rendering.ReflectionProbeUsage value);
        /*0x7e357e0*/ int get_sortingLayerID();
        /*0x7e35894*/ void set_sortingLayerID(int value);
        /*0x7e35958*/ int get_sortingOrder();
        /*0x7e35a0c*/ void set_sortingOrder(int value);
        /*0x7e35ad0*/ int get_sortingGroupID();
        /*0x7e35b84*/ int get_sortingGroupOrder();
        /*0x7e35c38*/ UnityEngine.Transform get_probeAnchor();
        /*0x7e35d08*/ void set_probeAnchor(UnityEngine.Transform value);
        /*0x7e35e00*/ int GetMaterialCount();
        /*0x7e35eb4*/ UnityEngine.Material[] GetSharedMaterialArray();
        /*0x7e35f68*/ void set_materials(UnityEngine.Material[] value);
        /*0x7e35f6c*/ UnityEngine.Material get_material();
        /*0x7e35f70*/ void set_material(UnityEngine.Material value);
        /*0x7e35f74*/ UnityEngine.Material get_sharedMaterial();
        /*0x7e35f78*/ void set_sharedMaterial(UnityEngine.Material value);
        /*0x7e35f7c*/ UnityEngine.Material[] get_sharedMaterials();
        /*0x7e35f80*/ void set_sharedMaterials(UnityEngine.Material[] value);
        /*0x7e35f84*/ void GetMaterials(System.Collections.Generic.List<UnityEngine.Material> m);
        /*0x7e36090*/ void SetMaterials(System.Collections.Generic.List<UnityEngine.Material> materials);
    }

    class RenderSettings : UnityEngine.Object
    {
        static /*0x7e36180*/ float get_ambientSkyboxAmount();
        static /*0x7e361d0*/ void set_ambientSkyboxAmount(float value);
        static /*0x7e36298*/ bool get_fog();
        static /*0x7e362c0*/ void set_fog(bool value);
        static /*0x7e362fc*/ float get_fogStartDistance();
        static /*0x7e36324*/ void set_fogStartDistance(float value);
        static /*0x7e3635c*/ float get_fogEndDistance();
        static /*0x7e36384*/ void set_fogEndDistance(float value);
        static /*0x7e363bc*/ UnityEngine.FogMode get_fogMode();
        static /*0x7e363e4*/ void set_fogMode(UnityEngine.FogMode value);
        static /*0x7e36420*/ UnityEngine.Color get_fogColor();
        static /*0x7e364a4*/ void set_fogColor(UnityEngine.Color value);
        static /*0x7e36524*/ float get_fogDensity();
        static /*0x7e3654c*/ void set_fogDensity(float value);
        static /*0x7e36584*/ UnityEngine.Rendering.AmbientMode get_ambientMode();
        static /*0x7e365ac*/ void set_ambientMode(UnityEngine.Rendering.AmbientMode value);
        static /*0x7e365e8*/ UnityEngine.Color get_ambientSkyColor();
        static /*0x7e3666c*/ void set_ambientSkyColor(UnityEngine.Color value);
        static /*0x7e366ec*/ UnityEngine.Color get_ambientEquatorColor();
        static /*0x7e36770*/ void set_ambientEquatorColor(UnityEngine.Color value);
        static /*0x7e367f0*/ UnityEngine.Color get_ambientGroundColor();
        static /*0x7e36874*/ void set_ambientGroundColor(UnityEngine.Color value);
        static /*0x7e361a8*/ float get_ambientIntensity();
        static /*0x7e36208*/ void set_ambientIntensity(float value);
        static /*0x7e368f4*/ UnityEngine.Color get_ambientLight();
        static /*0x7e36978*/ void set_ambientLight(UnityEngine.Color value);
        static /*0x7e369f8*/ UnityEngine.Color get_subtractiveShadowColor();
        static /*0x7e36a7c*/ void set_subtractiveShadowColor(UnityEngine.Color value);
        static /*0x7e36afc*/ UnityEngine.Material get_skybox();
        static /*0x7e36b88*/ void set_skybox(UnityEngine.Material value);
        static /*0x7e36c48*/ UnityEngine.Light get_sun();
        static /*0x7e36cd4*/ void set_sun(UnityEngine.Light value);
        static /*0x7e36d94*/ UnityEngine.Rendering.SphericalHarmonicsL2 get_ambientProbe();
        static /*0x7e36e3c*/ void set_ambientProbe(UnityEngine.Rendering.SphericalHarmonicsL2 value);
        static /*0x7e36eb4*/ UnityEngine.Cubemap get_customReflection();
        static /*0x7e36fac*/ void set_customReflection(UnityEngine.Cubemap value);
        static /*0x7e36f48*/ UnityEngine.Texture get_customReflectionTexture();
        static /*0x7e36fb0*/ void set_customReflectionTexture(UnityEngine.Texture value);
        static /*0x7e37098*/ float get_reflectionIntensity();
        static /*0x7e370c0*/ void set_reflectionIntensity(float value);
        static /*0x7e370f8*/ int get_reflectionBounces();
        static /*0x7e37120*/ void set_reflectionBounces(int value);
        static /*0x7e3715c*/ UnityEngine.Cubemap get_defaultReflection();
        static /*0x7e371e8*/ UnityEngine.Rendering.DefaultReflectionMode get_defaultReflectionMode();
        static /*0x7e37210*/ void set_defaultReflectionMode(UnityEngine.Rendering.DefaultReflectionMode value);
        static /*0x7e3724c*/ int get_defaultReflectionResolution();
        static /*0x7e37274*/ void set_defaultReflectionResolution(int value);
        static /*0x7e372b0*/ float get_haloStrength();
        static /*0x7e372d8*/ void set_haloStrength(float value);
        static /*0x7e37310*/ float get_flareStrength();
        static /*0x7e37338*/ void set_flareStrength(float value);
        static /*0x7e37370*/ float get_flareFadeSpeed();
        static /*0x7e37398*/ void set_flareFadeSpeed(float value);
        static /*0x7e373d0*/ UnityEngine.Object GetRenderSettings();
        static /*0x7e3745c*/ void Reset();
        static /*0x7e36468*/ void get_fogColor_Injected(ref UnityEngine.Color ret);
        static /*0x7e364e8*/ void set_fogColor_Injected(ref UnityEngine.Color value);
        static /*0x7e36630*/ void get_ambientSkyColor_Injected(ref UnityEngine.Color ret);
        static /*0x7e366b0*/ void set_ambientSkyColor_Injected(ref UnityEngine.Color value);
        static /*0x7e36734*/ void get_ambientEquatorColor_Injected(ref UnityEngine.Color ret);
        static /*0x7e367b4*/ void set_ambientEquatorColor_Injected(ref UnityEngine.Color value);
        static /*0x7e36838*/ void get_ambientGroundColor_Injected(ref UnityEngine.Color ret);
        static /*0x7e368b8*/ void set_ambientGroundColor_Injected(ref UnityEngine.Color value);
        static /*0x7e3693c*/ void get_ambientLight_Injected(ref UnityEngine.Color ret);
        static /*0x7e369bc*/ void set_ambientLight_Injected(ref UnityEngine.Color value);
        static /*0x7e36a40*/ void get_subtractiveShadowColor_Injected(ref UnityEngine.Color ret);
        static /*0x7e36ac0*/ void set_subtractiveShadowColor_Injected(ref UnityEngine.Color value);
        static /*0x7e36b60*/ nint get_skybox_Injected();
        static /*0x7e36c0c*/ void set_skybox_Injected(nint value);
        static /*0x7e36cac*/ nint get_sun_Injected();
        static /*0x7e36d58*/ void set_sun_Injected(nint value);
        static /*0x7e36e00*/ void get_ambientProbe_Injected(ref UnityEngine.Rendering.SphericalHarmonicsL2 ret);
        static /*0x7e36e78*/ void set_ambientProbe_Injected(ref UnityEngine.Rendering.SphericalHarmonicsL2 value);
        static /*0x7e37034*/ nint get_customReflectionTexture_Injected();
        static /*0x7e3705c*/ void set_customReflectionTexture_Injected(nint value);
        static /*0x7e371c0*/ nint get_defaultReflection_Injected();
        static /*0x7e37434*/ nint GetRenderSettings_Injected();
        /*0x7e36240*/ RenderSettings();
    }

    class Shader : UnityEngine.Object
    {
        static /*0x7e37484*/ UnityEngine.Rendering.ShaderHardwareTier get_globalShaderHardwareTier();
        static /*0x7e374ec*/ void set_globalShaderHardwareTier(UnityEngine.Rendering.ShaderHardwareTier value);
        static /*0x7e37560*/ UnityEngine.Shader Find(string name);
        static /*0x7e375cc*/ UnityEngine.Shader FindBuiltin(string name);
        static /*0x7e377cc*/ int get_maximumChunksOverride();
        static /*0x7e377f4*/ void set_maximumChunksOverride(int value);
        static /*0x7e379a8*/ int get_globalMaximumLOD();
        static /*0x7e379d0*/ void set_globalMaximumLOD(int value);
        static /*0x7e37ac0*/ string get_globalRenderPipeline();
        static /*0x7e37bb0*/ void set_globalRenderPipeline(string value);
        static /*0x7e37d54*/ UnityEngine.Rendering.GlobalKeyword[] get_enabledGlobalKeywords();
        static /*0x7e37da4*/ UnityEngine.Rendering.GlobalKeyword[] get_globalKeywords();
        static /*0x7e37d7c*/ UnityEngine.Rendering.GlobalKeyword[] GetEnabledGlobalKeywords();
        static /*0x7e37dcc*/ UnityEngine.Rendering.GlobalKeyword[] GetAllGlobalKeywords();
        static /*0x7e37ec0*/ void EnableKeyword(string keyword);
        static /*0x7e38064*/ void DisableKeyword(string keyword);
        static /*0x7e38208*/ bool IsKeywordEnabled(string keyword);
        static /*0x7e383b8*/ void EnableKeywordFast(UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e38434*/ void DisableKeywordFast(UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e384b0*/ void SetKeywordFast(UnityEngine.Rendering.GlobalKeyword keyword, bool value);
        static /*0x7e38544*/ bool IsKeywordEnabledFast(UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e385c4*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e385d0*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e385dc*/ void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
        static /*0x7e385f0*/ bool IsKeywordEnabled(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e38764*/ void WarmupAllShaders();
        static /*0x7e3878c*/ int TagToID(string name);
        static /*0x7e38938*/ string IDToTag(int name);
        static /*0x7e33fcc*/ int PropertyToID(string name);
        static /*0x7e3944c*/ void SetGlobalIntImpl(int name, int value);
        static /*0x7e39490*/ void SetGlobalFloatImpl(int name, float value);
        static /*0x7e394dc*/ void SetGlobalVectorImpl(int name, UnityEngine.Vector4 value);
        static /*0x7e39574*/ void SetGlobalMatrixImpl(int name, UnityEngine.Matrix4x4 value);
        static /*0x7e395fc*/ void SetGlobalTextureImpl(int name, UnityEngine.Texture value);
        static /*0x7e396d4*/ void SetGlobalRenderTextureImpl(int name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x7e397c4*/ void SetGlobalBufferImpl(int name, UnityEngine.ComputeBuffer value);
        static /*0x7e39858*/ void SetGlobalGraphicsBufferImpl(int name, UnityEngine.GraphicsBuffer value);
        static /*0x7e398ec*/ void SetGlobalConstantBufferImpl(int name, UnityEngine.ComputeBuffer value, int offset, int size);
        static /*0x7e399b0*/ void SetGlobalConstantGraphicsBufferImpl(int name, UnityEngine.GraphicsBuffer value, int offset, int size);
        static /*0x7e39a74*/ void SetGlobalRayTracingAccelerationStructureImpl(int name, UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
        static /*0x7e39b08*/ int GetGlobalIntImpl(int name);
        static /*0x7e39b44*/ float GetGlobalFloatImpl(int name);
        static /*0x7e39b80*/ UnityEngine.Vector4 GetGlobalVectorImpl(int name);
        static /*0x7e39c1c*/ UnityEngine.Matrix4x4 GetGlobalMatrixImpl(int name);
        static /*0x7e39ccc*/ UnityEngine.Texture GetGlobalTextureImpl(int name);
        static /*0x7e39d74*/ void SetGlobalFloatArrayImpl(int name, float[] values, int count);
        static /*0x7e39eac*/ void SetGlobalVectorArrayImpl(int name, UnityEngine.Vector4[] values, int count);
        static /*0x7e39fe4*/ void SetGlobalMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] values, int count);
        static /*0x7e3a11c*/ float[] GetGlobalFloatArrayImpl(int name);
        static /*0x7e3a25c*/ UnityEngine.Vector4[] GetGlobalVectorArrayImpl(int name);
        static /*0x7e3a39c*/ UnityEngine.Matrix4x4[] GetGlobalMatrixArrayImpl(int name);
        static /*0x7e3a4dc*/ int GetGlobalFloatArrayCountImpl(int name);
        static /*0x7e3a518*/ int GetGlobalVectorArrayCountImpl(int name);
        static /*0x7e3a554*/ int GetGlobalMatrixArrayCountImpl(int name);
        static /*0x7e3a590*/ void ExtractGlobalFloatArrayImpl(int name, float[] val);
        static /*0x7e3a6f8*/ void ExtractGlobalVectorArrayImpl(int name, UnityEngine.Vector4[] val);
        static /*0x7e3a860*/ void ExtractGlobalMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] val);
        static /*0x7e3a9c8*/ void SetGlobalFloatArray(int name, float[] values, int count);
        static /*0x7e3aa84*/ void SetGlobalVectorArray(int name, UnityEngine.Vector4[] values, int count);
        static /*0x7e3ab40*/ void SetGlobalMatrixArray(int name, UnityEngine.Matrix4x4[] values, int count);
        static /*0x7e3abfc*/ void ExtractGlobalFloatArray(int name, System.Collections.Generic.List<float> values);
        static /*0x7e3ad38*/ void ExtractGlobalVectorArray(int name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        static /*0x7e3ae74*/ void ExtractGlobalMatrixArray(int name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        static /*0x7e3afb0*/ void SetGlobalInt(string name, int value);
        static /*0x7e3aff8*/ void SetGlobalInt(int nameID, int value);
        static /*0x7e3b03c*/ void SetGlobalFloat(string name, float value);
        static /*0x7e3b08c*/ void SetGlobalFloat(int nameID, float value);
        static /*0x7e3b0d8*/ void SetGlobalInteger(string name, int value);
        static /*0x7e3b120*/ void SetGlobalInteger(int nameID, int value);
        static /*0x7e3b164*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
        static /*0x7e3b1a4*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
        static /*0x7e3b1a8*/ void SetGlobalColor(string name, UnityEngine.Color value);
        static /*0x7e3b1e8*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
        static /*0x7e3b1ec*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
        static /*0x7e3b250*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
        static /*0x7e3b2ac*/ void SetGlobalTexture(string name, UnityEngine.Texture value);
        static /*0x7e3b2c4*/ void SetGlobalTexture(int nameID, UnityEngine.Texture value);
        static /*0x7e3b2c8*/ void SetGlobalTexture(string name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x7e3b2f0*/ void SetGlobalTexture(int nameID, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x7e3b2f4*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
        static /*0x7e3b344*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
        static /*0x7e3b394*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
        static /*0x7e3b3e4*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
        static /*0x7e3b434*/ void SetGlobalConstantBuffer(string name, UnityEngine.ComputeBuffer value, int offset, int size);
        static /*0x7e3b49c*/ void SetGlobalConstantBuffer(int nameID, UnityEngine.ComputeBuffer value, int offset, int size);
        static /*0x7e3b504*/ void SetGlobalConstantBuffer(string name, UnityEngine.GraphicsBuffer value, int offset, int size);
        static /*0x7e3b56c*/ void SetGlobalConstantBuffer(int nameID, UnityEngine.GraphicsBuffer value, int offset, int size);
        static /*0x7e3b5d4*/ void SetGlobalRayTracingAccelerationStructure(string name, UnityEngine.Rendering.RayTracingAccelerationStructure value);
        static /*0x7e3b624*/ void SetGlobalRayTracingAccelerationStructure(int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure value);
        static /*0x7e3b674*/ void SetGlobalFloatArray(string name, System.Collections.Generic.List<float> values);
        static /*0x7e3b714*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
        static /*0x7e3b7a8*/ void SetGlobalFloatArray(string name, float[] values);
        static /*0x7e3b7cc*/ void SetGlobalFloatArray(int nameID, float[] values);
        static /*0x7e3b7e4*/ void SetGlobalVectorArray(string name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        static /*0x7e3b884*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
        static /*0x7e3b918*/ void SetGlobalVectorArray(string name, UnityEngine.Vector4[] values);
        static /*0x7e3b93c*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
        static /*0x7e3b954*/ void SetGlobalMatrixArray(string name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        static /*0x7e3b9f4*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        static /*0x7e3ba88*/ void SetGlobalMatrixArray(string name, UnityEngine.Matrix4x4[] values);
        static /*0x7e3baac*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
        static /*0x7e3bac4*/ int GetGlobalInt(string name);
        static /*0x7e3bb20*/ int GetGlobalInt(int nameID);
        static /*0x7e3bb78*/ float GetGlobalFloat(string name);
        static /*0x7e3bbb8*/ float GetGlobalFloat(int nameID);
        static /*0x7e3bbf4*/ int GetGlobalInteger(string name);
        static /*0x7e3bc34*/ int GetGlobalInteger(int nameID);
        static /*0x7e3bc70*/ UnityEngine.Vector4 GetGlobalVector(string name);
        static /*0x7e3bc80*/ UnityEngine.Vector4 GetGlobalVector(int nameID);
        static /*0x7e3bc84*/ UnityEngine.Color GetGlobalColor(string name);
        static /*0x7e3bc94*/ UnityEngine.Color GetGlobalColor(int nameID);
        static /*0x7e3bc98*/ UnityEngine.Matrix4x4 GetGlobalMatrix(string name);
        static /*0x7e3bd1c*/ UnityEngine.Matrix4x4 GetGlobalMatrix(int nameID);
        static /*0x7e3bd98*/ UnityEngine.Texture GetGlobalTexture(string name);
        static /*0x7e3bda8*/ UnityEngine.Texture GetGlobalTexture(int nameID);
        static /*0x7e3bdac*/ float[] GetGlobalFloatArray(string name);
        static /*0x7e3bdbc*/ float[] GetGlobalFloatArray(int nameID);
        static /*0x7e3be14*/ UnityEngine.Vector4[] GetGlobalVectorArray(string name);
        static /*0x7e3be24*/ UnityEngine.Vector4[] GetGlobalVectorArray(int nameID);
        static /*0x7e3be7c*/ UnityEngine.Matrix4x4[] GetGlobalMatrixArray(string name);
        static /*0x7e3be8c*/ UnityEngine.Matrix4x4[] GetGlobalMatrixArray(int nameID);
        static /*0x7e3bee4*/ void GetGlobalFloatArray(string name, System.Collections.Generic.List<float> values);
        static /*0x7e3befc*/ void GetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
        static /*0x7e3bf00*/ void GetGlobalVectorArray(string name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        static /*0x7e3bf18*/ void GetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
        static /*0x7e3bf1c*/ void GetGlobalMatrixArray(string name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        static /*0x7e3bf34*/ void GetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        static /*0x7e3bf90*/ string GetPropertyName(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e3c11c*/ int GetPropertyNameId(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e3c210*/ UnityEngine.Rendering.ShaderPropertyType GetPropertyType(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e3c304*/ string GetPropertyDescription(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e3c490*/ UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e3c584*/ string[] GetPropertyAttributes(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e3c678*/ int GetPropertyDefaultIntValue(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e3c76c*/ UnityEngine.Vector4 GetPropertyDefaultValue(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e3c88c*/ UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e3c980*/ string GetPropertyTextureDefaultName(UnityEngine.Shader shader, int propertyIndex);
        static /*0x7e3cb0c*/ bool FindTextureStackImpl(UnityEngine.Shader s, int propertyIdx, ref string stackName, ref int layerIndex);
        static /*0x7e3cce0*/ void CheckPropertyIndex(UnityEngine.Shader s, int propertyIndex);
        static /*0x7e37790*/ nint FindBuiltin_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e378a8*/ int get_maximumLOD_Injected(nint _unity_self);
        static /*0x7e37964*/ void set_maximumLOD_Injected(nint _unity_self, int value);
        static /*0x7e37a84*/ bool get_isSupported_Injected(nint _unity_self);
        static /*0x7e37b74*/ void get_globalRenderPipeline_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e37d18*/ void set_globalRenderPipeline_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7e37e7c*/ void get_keywordSpace_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeywordSpace ret);
        static /*0x7e38028*/ void EnableKeyword_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e381cc*/ void DisableKeyword_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e3837c*/ bool IsKeywordEnabled_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e383f8*/ void EnableKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e38474*/ void DisableKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e38500*/ void SetKeywordFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
        static /*0x7e38588*/ bool IsKeywordEnabledFast_Injected(ref UnityEngine.Rendering.GlobalKeyword keyword);
        static /*0x7e38674*/ int get_renderQueue_Injected(nint _unity_self);
        static /*0x7e38728*/ UnityEngine.DisableBatchingType get_disableBatching_Injected(nint _unity_self);
        static /*0x7e388fc*/ int TagToID_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e389f4*/ void IDToTag_Injected(int name, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e38a38*/ int PropertyToID_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e38c68*/ nint GetDependency_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e38d24*/ int get_passCount_Injected(nint _unity_self);
        static /*0x7e38dd8*/ int get_subshaderCount_Injected(nint _unity_self);
        static /*0x7e38e94*/ int GetPassCountInSubshader_Injected(nint _unity_self, int subshaderIndex);
        static /*0x7e39348*/ int Internal_FindPassTagValue_Injected(nint _unity_self, int passIndex, int tagName);
        static /*0x7e3939c*/ int Internal_FindPassTagValueInSubShader_Injected(nint _unity_self, int subShaderIndex, int passIndex, int tagName);
        static /*0x7e393f8*/ int Internal_FindSubshaderTagValue_Injected(nint _unity_self, int subShaderIndex, int tagName);
        static /*0x7e39530*/ void SetGlobalVectorImpl_Injected(int name, ref UnityEngine.Vector4 value);
        static /*0x7e395b8*/ void SetGlobalMatrixImpl_Injected(int name, ref UnityEngine.Matrix4x4 value);
        static /*0x7e39690*/ void SetGlobalTextureImpl_Injected(int name, nint value);
        static /*0x7e39770*/ void SetGlobalRenderTextureImpl_Injected(int name, nint value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x7e39814*/ void SetGlobalBufferImpl_Injected(int name, nint value);
        static /*0x7e398a8*/ void SetGlobalGraphicsBufferImpl_Injected(int name, nint value);
        static /*0x7e39954*/ void SetGlobalConstantBufferImpl_Injected(int name, nint value, int offset, int size);
        static /*0x7e39a18*/ void SetGlobalConstantGraphicsBufferImpl_Injected(int name, nint value, int offset, int size);
        static /*0x7e39ac4*/ void SetGlobalRayTracingAccelerationStructureImpl_Injected(int name, nint accelerationStructure);
        static /*0x7e39bd8*/ void GetGlobalVectorImpl_Injected(int name, ref UnityEngine.Vector4 ret);
        static /*0x7e39c88*/ void GetGlobalMatrixImpl_Injected(int name, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e39d38*/ nint GetGlobalTextureImpl_Injected(int name);
        static /*0x7e39e58*/ void SetGlobalFloatArrayImpl_Injected(int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e39f90*/ void SetGlobalVectorArrayImpl_Injected(int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e3a0c8*/ void SetGlobalMatrixArrayImpl_Injected(int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e3a218*/ void GetGlobalFloatArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e3a358*/ void GetGlobalVectorArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e3a498*/ void GetGlobalMatrixArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e3a6b4*/ void ExtractGlobalFloatArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x7e3a81c*/ void ExtractGlobalVectorArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x7e3a984*/ void ExtractGlobalMatrixArrayImpl_Injected(int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x7e3c0c8*/ void GetPropertyName_Injected(nint shader, int propertyIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e3c1cc*/ int GetPropertyNameId_Injected(nint shader, int propertyIndex);
        static /*0x7e3c2c0*/ UnityEngine.Rendering.ShaderPropertyType GetPropertyType_Injected(nint shader, int propertyIndex);
        static /*0x7e3c43c*/ void GetPropertyDescription_Injected(nint shader, int propertyIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e3c540*/ UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags_Injected(nint shader, int propertyIndex);
        static /*0x7e3c634*/ string[] GetPropertyAttributes_Injected(nint shader, int propertyIndex);
        static /*0x7e3c728*/ int GetPropertyDefaultIntValue_Injected(nint shader, int propertyIndex);
        static /*0x7e3c838*/ void GetPropertyDefaultValue_Injected(nint shader, int propertyIndex, ref UnityEngine.Vector4 ret);
        static /*0x7e3c93c*/ UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension_Injected(nint shader, int propertyIndex);
        static /*0x7e3cab8*/ void GetPropertyTextureDefaultName_Injected(nint shader, int propertyIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e3cc84*/ bool FindTextureStackImpl_Injected(nint s, int propertyIdx, ref UnityEngine.Bindings.ManagedSpanWrapper stackName, ref int layerIndex);
        static /*0x7e3cdc8*/ int GetPropertyCount_Injected(nint _unity_self);
        static /*0x7e3cfac*/ int FindPropertyIndex_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper propertyName);
        /*0x7e3bf38*/ Shader();
        /*0x7e37830*/ int get_maximumLOD();
        /*0x7e378e4*/ void set_maximumLOD(int value);
        /*0x7e37a0c*/ bool get_isSupported();
        /*0x7e37df4*/ UnityEngine.Rendering.LocalKeywordSpace get_keywordSpace();
        /*0x7e385fc*/ int get_renderQueue();
        /*0x7e386b0*/ UnityEngine.DisableBatchingType get_disableBatching();
        /*0x7e38a74*/ UnityEngine.Shader GetDependency(string name);
        /*0x7e38cac*/ int get_passCount();
        /*0x7e38d60*/ int get_subshaderCount();
        /*0x7e38e14*/ int GetPassCountInSubshader(int subshaderIndex);
        /*0x7e38ed8*/ UnityEngine.Rendering.ShaderTagId FindPassTagValue(int passIndex, UnityEngine.Rendering.ShaderTagId tagName);
        /*0x7e39020*/ UnityEngine.Rendering.ShaderTagId FindPassTagValue(int subshaderIndex, int passIndex, UnityEngine.Rendering.ShaderTagId tagName);
        /*0x7e391b0*/ UnityEngine.Rendering.ShaderTagId FindSubshaderTagValue(int subshaderIndex, UnityEngine.Rendering.ShaderTagId tagName);
        /*0x7e38f90*/ int Internal_FindPassTagValue(int passIndex, int tagName);
        /*0x7e39118*/ int Internal_FindPassTagValueInSubShader(int subShaderIndex, int passIndex, int tagName);
        /*0x7e392b8*/ int Internal_FindSubshaderTagValue(int subShaderIndex, int tagName);
        /*0x7e3cd50*/ int GetPropertyCount();
        /*0x7e3ce04*/ int FindPropertyIndex(string propertyName);
        /*0x7e3cff0*/ string GetPropertyName(int propertyIndex);
        /*0x7e3d018*/ int GetPropertyNameId(int propertyIndex);
        /*0x7e3d040*/ UnityEngine.Rendering.ShaderPropertyType GetPropertyType(int propertyIndex);
        /*0x7e3d068*/ string GetPropertyDescription(int propertyIndex);
        /*0x7e3d090*/ UnityEngine.Rendering.ShaderPropertyFlags GetPropertyFlags(int propertyIndex);
        /*0x7e3d0b8*/ string[] GetPropertyAttributes(int propertyIndex);
        /*0x7e3d0e0*/ float GetPropertyDefaultFloatValue(int propertyIndex);
        /*0x7e3d174*/ UnityEngine.Vector4 GetPropertyDefaultVectorValue(int propertyIndex);
        /*0x7e3d204*/ UnityEngine.Vector2 GetPropertyRangeLimits(int propertyIndex);
        /*0x7e3d2a0*/ int GetPropertyDefaultIntValue(int propertyIndex);
        /*0x7e3d330*/ UnityEngine.Rendering.TextureDimension GetPropertyTextureDimension(int propertyIndex);
        /*0x7e3d3c0*/ string GetPropertyTextureDefaultName(int propertyIndex);
        /*0x7e3d450*/ bool FindTextureStack(int propertyIndex, ref string stackName, ref int layerIndex);
    }

    class Material : UnityEngine.Object
    {
        static /*0x0*/ int k_ColorId;
        static /*0x4*/ int k_MainTexId;

        static /*0x7e4604c*/ Material();
        static /*0x7e3d4f8*/ UnityEngine.Material Create(string scriptContents);
        static /*0x7e3d5ec*/ void CreateWithShader(UnityEngine.Material self, UnityEngine.Shader shader);
        static /*0x7e3d70c*/ void CreateWithMaterial(UnityEngine.Material self, UnityEngine.Material source);
        static /*0x7e3d82c*/ void CreateWithString(UnityEngine.Material self);
        static /*0x7e3d990*/ UnityEngine.Material GetDefaultMaterial();
        static /*0x7e3da40*/ UnityEngine.Material GetDefaultParticleMaterial();
        static /*0x7e3daf0*/ UnityEngine.Material GetDefaultLineMaterial();
        static /*0x7e3d6c8*/ void CreateWithShader_Injected(UnityEngine.Material self, nint shader);
        static /*0x7e3d7e8*/ void CreateWithMaterial_Injected(UnityEngine.Material self, nint source);
        static /*0x7e3da18*/ nint GetDefaultMaterial_Injected();
        static /*0x7e3dac8*/ nint GetDefaultParticleMaterial_Injected();
        static /*0x7e3db78*/ nint GetDefaultLineMaterial_Injected();
        static /*0x7e3dc58*/ nint get_shader_Injected(nint _unity_self);
        static /*0x7e3dd6c*/ void set_shader_Injected(nint _unity_self, nint value);
        static /*0x7e3e2a4*/ int GetFirstPropertyNameIdByAttribute_Injected(nint _unity_self, UnityEngine.Rendering.ShaderPropertyFlags attributeFlag);
        static /*0x7e3e394*/ bool HasProperty_Injected(nint _unity_self, int nameID);
        static /*0x7e3e4a4*/ bool HasFloatImpl_Injected(nint _unity_self, int name);
        static /*0x7e3e5dc*/ bool HasIntImpl_Injected(nint _unity_self, int name);
        static /*0x7e3e6f0*/ bool HasTextureImpl_Injected(nint _unity_self, int name);
        static /*0x7e3e804*/ bool HasMatrixImpl_Injected(nint _unity_self, int name);
        static /*0x7e3e918*/ bool HasVectorImpl_Injected(nint _unity_self, int name);
        static /*0x7e3ea50*/ bool HasBufferImpl_Injected(nint _unity_self, int name);
        static /*0x7e3eb64*/ bool HasConstantBufferImpl_Injected(nint _unity_self, int name);
        static /*0x7e3ec68*/ int get_renderQueue_Injected(nint _unity_self);
        static /*0x7e3ed50*/ void set_renderQueue_Injected(nint _unity_self, int value);
        static /*0x7e3ee30*/ int get_rawRenderQueue_Injected(nint _unity_self);
        static /*0x7e3f02c*/ void EnableKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e3f230*/ void DisableKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e3f444*/ bool IsKeywordEnabled_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e3f534*/ void EnableLocalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeyword keyword);
        static /*0x7e3f624*/ void DisableLocalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeyword keyword);
        static /*0x7e3f71c*/ void SetLocalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
        static /*0x7e3f81c*/ bool IsLocalKeywordEnabled_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeyword keyword);
        static /*0x7e3f9b4*/ UnityEngine.Rendering.LocalKeyword[] GetEnabledKeywords_Injected(nint _unity_self);
        static /*0x7e3fa9c*/ void SetEnabledKeywords_Injected(nint _unity_self, UnityEngine.Rendering.LocalKeyword[] keywords);
        static /*0x7e3fb84*/ UnityEngine.MaterialGlobalIlluminationFlags get_globalIlluminationFlags_Injected(nint _unity_self);
        static /*0x7e3fc6c*/ void set_globalIlluminationFlags_Injected(nint _unity_self, UnityEngine.MaterialGlobalIlluminationFlags value);
        static /*0x7e3fd4c*/ bool get_doubleSidedGI_Injected(nint _unity_self);
        static /*0x7e3fe34*/ void set_doubleSidedGI_Injected(nint _unity_self, bool value);
        static /*0x7e3fe78*/ bool get_enableInstancing_Injected(nint _unity_self);
        static /*0x7e3ff60*/ void set_enableInstancing_Injected(nint _unity_self, bool value);
        static /*0x7e40040*/ int get_passCount_Injected(nint _unity_self);
        static /*0x7e40250*/ void SetShaderPassEnabled_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper passName, bool enabled);
        static /*0x7e40474*/ bool GetShaderPassEnabled_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper passName);
        static /*0x7e405e4*/ void GetPassName_Injected(nint _unity_self, int pass, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e40804*/ int FindPass_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper passName);
        static /*0x7e40ad8*/ void SetOverrideTag_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper tag, ref UnityEngine.Bindings.ManagedSpanWrapper val);
        static /*0x7e40e04*/ void GetTagImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper tag, bool currentSubShaderOnly, ref UnityEngine.Bindings.ManagedSpanWrapper defaultValue, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e40fe8*/ void Lerp_Injected(nint _unity_self, nint start, nint end, float t);
        static /*0x7e410f8*/ bool SetPass_Injected(nint _unity_self, int pass);
        static /*0x7e41214*/ void CopyPropertiesFromMaterial_Injected(nint _unity_self, nint mat);
        static /*0x7e41330*/ void CopyMatchingPropertiesFromMaterial_Injected(nint _unity_self, nint mat);
        static /*0x7e41410*/ string[] GetShaderKeywords_Injected(nint _unity_self);
        static /*0x7e414f8*/ void SetShaderKeywords_Injected(nint _unity_self, string[] names);
        static /*0x7e415f0*/ string[] GetPropertyNamesImpl_Injected(nint _unity_self, int propertyType);
        static /*0x7e416d0*/ int ComputeCRC_Injected(nint _unity_self);
        static /*0x7e417a8*/ string[] GetTexturePropertyNames_Injected(nint _unity_self);
        static /*0x7e41930*/ void GetTexturePropertyNameIDs_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e41a20*/ void GetTexturePropertyNamesInternal_Injected(nint _unity_self, object outNames);
        static /*0x7e41b10*/ void GetTexturePropertyNameIDsInternal_Injected(nint _unity_self, object outNames);
        static /*0x7e41cb0*/ void SetIntImpl_Injected(nint _unity_self, int name, int value);
        static /*0x7e41dc0*/ void SetFloatImpl_Injected(nint _unity_self, int name, float value);
        static /*0x7e41ed8*/ void SetColorImpl_Injected(nint _unity_self, int name, ref UnityEngine.Color value);
        static /*0x7e41fe0*/ void SetMatrixImpl_Injected(nint _unity_self, int name, ref UnityEngine.Matrix4x4 value);
        static /*0x7e42114*/ void SetTextureImpl_Injected(nint _unity_self, int name, nint value);
        static /*0x7e42258*/ void SetRenderTextureImpl_Injected(nint _unity_self, int name, nint value, UnityEngine.Rendering.RenderTextureSubElement element);
        static /*0x7e42370*/ void SetBufferImpl_Injected(nint _unity_self, int name, nint value);
        static /*0x7e42480*/ void SetGraphicsBufferImpl_Injected(nint _unity_self, int name, nint value);
        static /*0x7e425a8*/ void SetConstantBufferImpl_Injected(nint _unity_self, int name, nint value, int offset, int size);
        static /*0x7e426e8*/ void SetConstantGraphicsBufferImpl_Injected(nint _unity_self, int name, nint value, int offset, int size);
        static /*0x7e42800*/ int GetIntImpl_Injected(nint _unity_self, int name);
        static /*0x7e428f0*/ float GetFloatImpl_Injected(nint _unity_self, int name);
        static /*0x7e429fc*/ void GetColorImpl_Injected(nint _unity_self, int name, ref UnityEngine.Color ret);
        static /*0x7e42b2c*/ void GetMatrixImpl_Injected(nint _unity_self, int name, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e42c48*/ nint GetTextureImpl_Injected(nint _unity_self, int name);
        static /*0x7e42d48*/ void GetBufferImpl_Injected(nint _unity_self, int name, ref UnityEngine.GraphicsBufferHandle ret);
        static /*0x7e42e58*/ void GetConstantBufferImpl_Injected(nint _unity_self, int name, ref UnityEngine.GraphicsBufferHandle ret);
        static /*0x7e42fe4*/ void SetFloatArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e43178*/ void SetVectorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e4330c*/ void SetColorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e434a0*/ void SetMatrixArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.ManagedSpanWrapper values, int count);
        static /*0x7e43658*/ void GetFloatArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e43808*/ void GetVectorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e439b8*/ void GetColorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e43b68*/ void GetMatrixArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e43c68*/ int GetFloatArrayCountImpl_Injected(nint _unity_self, int name);
        static /*0x7e43d58*/ int GetVectorArrayCountImpl_Injected(nint _unity_self, int name);
        static /*0x7e43e48*/ int GetColorArrayCountImpl_Injected(nint _unity_self, int name);
        static /*0x7e43f38*/ int GetMatrixArrayCountImpl_Injected(nint _unity_self, int name);
        static /*0x7e44100*/ void ExtractFloatArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x7e442d8*/ void ExtractVectorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x7e444b0*/ void ExtractColorArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x7e44688*/ void ExtractMatrixArrayImpl_Injected(nint _unity_self, int name, ref UnityEngine.Bindings.BlittableArrayWrapper val);
        static /*0x7e447a4*/ void GetTextureScaleAndOffsetImpl_Injected(nint _unity_self, int name, ref UnityEngine.Vector4 ret);
        static /*0x7e448b0*/ void SetTextureOffsetImpl_Injected(nint _unity_self, int name, ref UnityEngine.Vector2 offset);
        static /*0x7e449bc*/ void SetTextureScaleImpl_Injected(nint _unity_self, int name, ref UnityEngine.Vector2 scale);
        /*0x7e3d868*/ Material(UnityEngine.Shader shader);
        /*0x7e3d8fc*/ Material(UnityEngine.Material source);
        /*0x7e3d548*/ Material(string contents);
        /*0x7e3dba0*/ UnityEngine.Shader get_shader();
        /*0x7e3dc94*/ void set_shader(UnityEngine.Shader value);
        /*0x7e3ddb0*/ UnityEngine.Color get_color();
        /*0x7e3ded4*/ void set_color(UnityEngine.Color value);
        /*0x7e3df7c*/ UnityEngine.Texture get_mainTexture();
        /*0x7e3dff4*/ void set_mainTexture(UnityEngine.Texture value);
        /*0x7e3e074*/ UnityEngine.Vector2 get_mainTextureOffset();
        /*0x7e3e10c*/ void set_mainTextureOffset(UnityEngine.Vector2 value);
        /*0x7e3e19c*/ UnityEngine.Vector2 get_mainTextureScale();
        /*0x7e3e214*/ void set_mainTextureScale(UnityEngine.Vector2 value);
        /*0x7e3de24*/ int GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags attributeFlag);
        /*0x7e3e2e8*/ bool HasProperty(int nameID);
        /*0x7e3e3d8*/ bool HasProperty(string name);
        /*0x7e3e3f8*/ bool HasFloatImpl(int name);
        /*0x7e3e4e8*/ bool HasFloat(string name);
        /*0x7e3e508*/ bool HasFloat(int nameID);
        /*0x7e3e50c*/ bool HasInt(string name);
        /*0x7e3e52c*/ bool HasInt(int nameID);
        /*0x7e3e530*/ bool HasIntImpl(int name);
        /*0x7e3e620*/ bool HasInteger(string name);
        /*0x7e3e640*/ bool HasInteger(int nameID);
        /*0x7e3e644*/ bool HasTextureImpl(int name);
        /*0x7e3e734*/ bool HasTexture(string name);
        /*0x7e3e754*/ bool HasTexture(int nameID);
        /*0x7e3e758*/ bool HasMatrixImpl(int name);
        /*0x7e3e848*/ bool HasMatrix(string name);
        /*0x7e3e868*/ bool HasMatrix(int nameID);
        /*0x7e3e86c*/ bool HasVectorImpl(int name);
        /*0x7e3e95c*/ bool HasVector(string name);
        /*0x7e3e97c*/ bool HasVector(int nameID);
        /*0x7e3e980*/ bool HasColor(string name);
        /*0x7e3e9a0*/ bool HasColor(int nameID);
        /*0x7e3e9a4*/ bool HasBufferImpl(int name);
        /*0x7e3ea94*/ bool HasBuffer(string name);
        /*0x7e3eab4*/ bool HasBuffer(int nameID);
        /*0x7e3eab8*/ bool HasConstantBufferImpl(int name);
        /*0x7e3eba8*/ bool HasConstantBuffer(string name);
        /*0x7e3ebc8*/ bool HasConstantBuffer(int nameID);
        /*0x7e3ebcc*/ int get_renderQueue();
        /*0x7e3eca4*/ void set_renderQueue(int value);
        /*0x7e3ed94*/ int get_rawRenderQueue();
        /*0x7e3ee6c*/ void EnableKeyword(string keyword);
        /*0x7e3f070*/ void DisableKeyword(string keyword);
        /*0x7e3f274*/ bool IsKeywordEnabled(string keyword);
        /*0x7e3f488*/ void EnableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword);
        /*0x7e3f578*/ void DisableLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword);
        /*0x7e3f668*/ void SetLocalKeyword(UnityEngine.Rendering.LocalKeyword keyword, bool value);
        /*0x7e3f770*/ bool IsLocalKeywordEnabled(UnityEngine.Rendering.LocalKeyword keyword);
        /*0x7e3f860*/ void EnableKeyword(ref UnityEngine.Rendering.LocalKeyword keyword);
        /*0x7e3f88c*/ void DisableKeyword(ref UnityEngine.Rendering.LocalKeyword keyword);
        /*0x7e3f8b8*/ void SetKeyword(ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
        /*0x7e3f8e8*/ bool IsKeywordEnabled(ref UnityEngine.Rendering.LocalKeyword keyword);
        /*0x7e3f918*/ UnityEngine.Rendering.LocalKeyword[] GetEnabledKeywords();
        /*0x7e3f9f0*/ void SetEnabledKeywords(UnityEngine.Rendering.LocalKeyword[] keywords);
        /*0x7e3fae0*/ UnityEngine.Rendering.LocalKeyword[] get_enabledKeywords();
        /*0x7e3fae4*/ void set_enabledKeywords(UnityEngine.Rendering.LocalKeyword[] value);
        /*0x7e3fae8*/ UnityEngine.MaterialGlobalIlluminationFlags get_globalIlluminationFlags();
        /*0x7e3fbc0*/ void set_globalIlluminationFlags(UnityEngine.MaterialGlobalIlluminationFlags value);
        /*0x7e3fcb0*/ bool get_doubleSidedGI();
        /*0x7e3fd88*/ void set_doubleSidedGI(bool value);
        /*0x7e2ecb8*/ bool get_enableInstancing();
        /*0x7e3feb4*/ void set_enableInstancing(bool value);
        /*0x7e3ffa4*/ int get_passCount();
        /*0x7e4007c*/ void SetShaderPassEnabled(string passName, bool enabled);
        /*0x7e402a4*/ bool GetShaderPassEnabled(string passName);
        /*0x7e404b8*/ string GetPassName(int pass);
        /*0x7e40638*/ int FindPass(string passName);
        /*0x7e40848*/ void SetOverrideTag(string tag, string val);
        /*0x7e40b2c*/ string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue);
        /*0x7e40e70*/ string GetTag(string tag, bool searchFallbacks, string defaultValue);
        /*0x7e40e7c*/ string GetTag(string tag, bool searchFallbacks);
        /*0x7e40ee0*/ void Lerp(UnityEngine.Material start, UnityEngine.Material end, float t);
        /*0x7e4104c*/ bool SetPass(int pass);
        /*0x7e4113c*/ void CopyPropertiesFromMaterial(UnityEngine.Material mat);
        /*0x7e41258*/ void CopyMatchingPropertiesFromMaterial(UnityEngine.Material mat);
        /*0x7e41374*/ string[] GetShaderKeywords();
        /*0x7e4144c*/ void SetShaderKeywords(string[] names);
        /*0x7e4153c*/ string[] get_shaderKeywords();
        /*0x7e41540*/ void set_shaderKeywords(string[] value);
        /*0x7e41544*/ string[] GetPropertyNamesImpl(int propertyType);
        /*0x7e41634*/ int ComputeCRC();
        /*0x7e4170c*/ string[] GetTexturePropertyNames();
        /*0x7e417e4*/ int[] GetTexturePropertyNameIDs();
        /*0x7e41974*/ void GetTexturePropertyNamesInternal(object outNames);
        /*0x7e41a64*/ void GetTexturePropertyNameIDsInternal(object outNames);
        /*0x7e41b54*/ void GetTexturePropertyNames(System.Collections.Generic.List<string> outNames);
        /*0x7e41ba8*/ void GetTexturePropertyNameIDs(System.Collections.Generic.List<int> outNames);
        /*0x7e41bfc*/ void SetIntImpl(int name, int value);
        /*0x7e41d04*/ void SetFloatImpl(int name, float value);
        /*0x7e41e14*/ void SetColorImpl(int name, UnityEngine.Color value);
        /*0x7e41f2c*/ void SetMatrixImpl(int name, UnityEngine.Matrix4x4 value);
        /*0x7e42034*/ void SetTextureImpl(int name, UnityEngine.Texture value);
        /*0x7e42168*/ void SetRenderTextureImpl(int name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x7e422b4*/ void SetBufferImpl(int name, UnityEngine.ComputeBuffer value);
        /*0x7e423c4*/ void SetGraphicsBufferImpl(int name, UnityEngine.GraphicsBuffer value);
        /*0x7e424d4*/ void SetConstantBufferImpl(int name, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x7e42614*/ void SetConstantGraphicsBufferImpl(int name, UnityEngine.GraphicsBuffer value, int offset, int size);
        /*0x7e42754*/ int GetIntImpl(int name);
        /*0x7e42844*/ float GetFloatImpl(int name);
        /*0x7e42934*/ UnityEngine.Color GetColorImpl(int name);
        /*0x7e42a50*/ UnityEngine.Matrix4x4 GetMatrixImpl(int name);
        /*0x7e42b80*/ UnityEngine.Texture GetTextureImpl(int name);
        /*0x7e42c8c*/ UnityEngine.GraphicsBufferHandle GetBufferImpl(int name);
        /*0x7e42d9c*/ UnityEngine.GraphicsBufferHandle GetConstantBufferImpl(int name);
        /*0x7e42eac*/ void SetFloatArrayImpl(int name, float[] values, int count);
        /*0x7e43040*/ void SetVectorArrayImpl(int name, UnityEngine.Vector4[] values, int count);
        /*0x7e431d4*/ void SetColorArrayImpl(int name, UnityEngine.Color[] values, int count);
        /*0x7e43368*/ void SetMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x7e434fc*/ float[] GetFloatArrayImpl(int name);
        /*0x7e436ac*/ UnityEngine.Vector4[] GetVectorArrayImpl(int name);
        /*0x7e4385c*/ UnityEngine.Color[] GetColorArrayImpl(int name);
        /*0x7e43a0c*/ UnityEngine.Matrix4x4[] GetMatrixArrayImpl(int name);
        /*0x7e43bbc*/ int GetFloatArrayCountImpl(int name);
        /*0x7e43cac*/ int GetVectorArrayCountImpl(int name);
        /*0x7e43d9c*/ int GetColorArrayCountImpl(int name);
        /*0x7e43e8c*/ int GetMatrixArrayCountImpl(int name);
        /*0x7e43f7c*/ void ExtractFloatArrayImpl(int name, float[] val);
        /*0x7e44154*/ void ExtractVectorArrayImpl(int name, UnityEngine.Vector4[] val);
        /*0x7e4432c*/ void ExtractColorArrayImpl(int name, UnityEngine.Color[] val);
        /*0x7e44504*/ void ExtractMatrixArrayImpl(int name, UnityEngine.Matrix4x4[] val);
        /*0x7e446dc*/ UnityEngine.Vector4 GetTextureScaleAndOffsetImpl(int name);
        /*0x7e447f8*/ void SetTextureOffsetImpl(int name, UnityEngine.Vector2 offset);
        /*0x7e44904*/ void SetTextureScaleImpl(int name, UnityEngine.Vector2 scale);
        /*0x7e44a10*/ void SetFloatArray(int name, float[] values, int count);
        /*0x7e44acc*/ void SetVectorArray(int name, UnityEngine.Vector4[] values, int count);
        /*0x7e44b88*/ void SetColorArray(int name, UnityEngine.Color[] values, int count);
        /*0x7e44c44*/ void SetMatrixArray(int name, UnityEngine.Matrix4x4[] values, int count);
        /*0x7e44d00*/ void ExtractFloatArray(int name, System.Collections.Generic.List<float> values);
        /*0x7e44e34*/ void ExtractVectorArray(int name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        /*0x7e44f68*/ void ExtractColorArray(int name, System.Collections.Generic.List<UnityEngine.Color> values);
        /*0x7e4509c*/ void ExtractMatrixArray(int name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        /*0x7e451d0*/ void SetInt(string name, int value);
        /*0x7e45200*/ void SetInt(int nameID, int value);
        /*0x7e45208*/ void SetFloat(string name, float value);
        /*0x7e45238*/ void SetFloat(int nameID, float value);
        /*0x7e4523c*/ void SetInteger(string name, int value);
        /*0x7e4526c*/ void SetInteger(int nameID, int value);
        /*0x7e45270*/ void SetColor(string name, UnityEngine.Color value);
        /*0x7e3df78*/ void SetColor(int nameID, UnityEngine.Color value);
        /*0x7e452c0*/ void SetVector(string name, UnityEngine.Vector4 value);
        /*0x7e45310*/ void SetVector(int nameID, UnityEngine.Vector4 value);
        /*0x7e45314*/ void SetMatrix(string name, UnityEngine.Matrix4x4 value);
        /*0x7e45360*/ void SetMatrix(int nameID, UnityEngine.Matrix4x4 value);
        /*0x7e4538c*/ void SetTexture(string name, UnityEngine.Texture value);
        /*0x7e3e070*/ void SetTexture(int nameID, UnityEngine.Texture value);
        /*0x7e453bc*/ void SetTexture(string name, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x7e453f4*/ void SetTexture(int nameID, UnityEngine.RenderTexture value, UnityEngine.Rendering.RenderTextureSubElement element);
        /*0x7e453f8*/ void SetBuffer(string name, UnityEngine.ComputeBuffer value);
        /*0x7e45428*/ void SetBuffer(int nameID, UnityEngine.ComputeBuffer value);
        /*0x7e4542c*/ void SetBuffer(string name, UnityEngine.GraphicsBuffer value);
        /*0x7e4545c*/ void SetBuffer(int nameID, UnityEngine.GraphicsBuffer value);
        /*0x7e45460*/ void SetConstantBuffer(string name, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x7e454a8*/ void SetConstantBuffer(int nameID, UnityEngine.ComputeBuffer value, int offset, int size);
        /*0x7e454ac*/ void SetConstantBuffer(string name, UnityEngine.GraphicsBuffer value, int offset, int size);
        /*0x7e454f4*/ void SetConstantBuffer(int nameID, UnityEngine.GraphicsBuffer value, int offset, int size);
        /*0x7e454f8*/ void SetFloatArray(string name, System.Collections.Generic.List<float> values);
        /*0x7e455a0*/ void SetFloatArray(int nameID, System.Collections.Generic.List<float> values);
        /*0x7e4563c*/ void SetFloatArray(string name, float[] values);
        /*0x7e45678*/ void SetFloatArray(int nameID, float[] values);
        /*0x7e45690*/ void SetColorArray(string name, System.Collections.Generic.List<UnityEngine.Color> values);
        /*0x7e45738*/ void SetColorArray(int nameID, System.Collections.Generic.List<UnityEngine.Color> values);
        /*0x7e457d4*/ void SetColorArray(string name, UnityEngine.Color[] values);
        /*0x7e45810*/ void SetColorArray(int nameID, UnityEngine.Color[] values);
        /*0x7e45828*/ void SetVectorArray(string name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        /*0x7e458d0*/ void SetVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
        /*0x7e4596c*/ void SetVectorArray(string name, UnityEngine.Vector4[] values);
        /*0x7e459a8*/ void SetVectorArray(int nameID, UnityEngine.Vector4[] values);
        /*0x7e459c0*/ void SetMatrixArray(string name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        /*0x7e45a68*/ void SetMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        /*0x7e45b04*/ void SetMatrixArray(string name, UnityEngine.Matrix4x4[] values);
        /*0x7e45b40*/ void SetMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
        /*0x7e45b58*/ int GetInt(string name);
        /*0x7e45b94*/ int GetInt(int nameID);
        /*0x7e45bbc*/ float GetFloat(string name);
        /*0x7e45bdc*/ float GetFloat(int nameID);
        /*0x7e45be0*/ int GetInteger(string name);
        /*0x7e45c00*/ int GetInteger(int nameID);
        /*0x7e45c04*/ UnityEngine.Color GetColor(string name);
        /*0x7e3ded0*/ UnityEngine.Color GetColor(int nameID);
        /*0x7e45c24*/ UnityEngine.Vector4 GetVector(string name);
        /*0x7e45c44*/ UnityEngine.Vector4 GetVector(int nameID);
        /*0x7e45c48*/ UnityEngine.Matrix4x4 GetMatrix(string name);
        /*0x7e45ca0*/ UnityEngine.Matrix4x4 GetMatrix(int nameID);
        /*0x7e45cdc*/ UnityEngine.Texture GetTexture(string name);
        /*0x7e3dff0*/ UnityEngine.Texture GetTexture(int nameID);
        /*0x7e45cfc*/ UnityEngine.GraphicsBufferHandle GetBuffer(string name);
        /*0x7e45d24*/ UnityEngine.GraphicsBufferHandle GetConstantBuffer(string name);
        /*0x7e45d4c*/ float[] GetFloatArray(string name);
        /*0x7e45d6c*/ float[] GetFloatArray(int nameID);
        /*0x7e45da8*/ UnityEngine.Color[] GetColorArray(string name);
        /*0x7e45dc8*/ UnityEngine.Color[] GetColorArray(int nameID);
        /*0x7e45e04*/ UnityEngine.Vector4[] GetVectorArray(string name);
        /*0x7e45e24*/ UnityEngine.Vector4[] GetVectorArray(int nameID);
        /*0x7e45e60*/ UnityEngine.Matrix4x4[] GetMatrixArray(string name);
        /*0x7e45e80*/ UnityEngine.Matrix4x4[] GetMatrixArray(int nameID);
        /*0x7e45ebc*/ void GetFloatArray(string name, System.Collections.Generic.List<float> values);
        /*0x7e45eec*/ void GetFloatArray(int nameID, System.Collections.Generic.List<float> values);
        /*0x7e45ef0*/ void GetColorArray(string name, System.Collections.Generic.List<UnityEngine.Color> values);
        /*0x7e45f20*/ void GetColorArray(int nameID, System.Collections.Generic.List<UnityEngine.Color> values);
        /*0x7e45f24*/ void GetVectorArray(string name, System.Collections.Generic.List<UnityEngine.Vector4> values);
        /*0x7e45f54*/ void GetVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
        /*0x7e45f58*/ void GetMatrixArray(string name, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        /*0x7e45f88*/ void GetMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
        /*0x7e45f8c*/ void SetTextureOffset(string name, UnityEngine.Vector2 value);
        /*0x7e3e198*/ void SetTextureOffset(int nameID, UnityEngine.Vector2 value);
        /*0x7e45fc4*/ void SetTextureScale(string name, UnityEngine.Vector2 value);
        /*0x7e3e2a0*/ void SetTextureScale(int nameID, UnityEngine.Vector2 value);
        /*0x7e45ffc*/ UnityEngine.Vector2 GetTextureOffset(string name);
        /*0x7e3e0f4*/ UnityEngine.Vector2 GetTextureOffset(int nameID);
        /*0x7e46028*/ UnityEngine.Vector2 GetTextureScale(string name);
        /*0x7e3e210*/ UnityEngine.Vector2 GetTextureScale(int nameID);
        /*0x7e46048*/ string[] GetPropertyNames(UnityEngine.MaterialPropertyType type);
    }

    struct GraphicsBufferHandle : System.IEquatable<UnityEngine.GraphicsBufferHandle>
    {
        /*0x10*/ uint value;

        /*0x7e460e0*/ int GetHashCode();
        /*0x7e460e8*/ bool Equals(object obj);
        /*0x7e46160*/ bool Equals(UnityEngine.GraphicsBufferHandle other);
    }

    class GraphicsBuffer : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;

        static /*0x7e46374*/ bool RequiresCompute(UnityEngine.GraphicsBuffer.Target target);
        static /*0x7e46380*/ bool IsVertexIndexOrCopyOnly(UnityEngine.GraphicsBuffer.Target target);
        static /*0x7e4638c*/ nint InitBuffer(UnityEngine.GraphicsBuffer.Target target, UnityEngine.GraphicsBuffer.UsageFlags usageFlags, int count, int stride);
        static /*0x7e4632c*/ void DestroyBuffer(UnityEngine.GraphicsBuffer buf);
        static /*0x7e467e0*/ bool IsValidBuffer(UnityEngine.GraphicsBuffer buf);
        static /*0x7e463e8*/ void DestroyBuffer_Injected(nint buf);
        static /*0x7e46828*/ bool IsValidBuffer_Injected(nint buf);
        static /*0x7e46904*/ int get_count_Injected(nint _unity_self);
        static /*0x7e46990*/ int get_stride_Injected(nint _unity_self);
        static /*0x7e46a1c*/ UnityEngine.GraphicsBuffer.UsageFlags GetUsageFlags_Injected(nint _unity_self);
        static /*0x7e46abc*/ void get_bufferHandle_Injected(nint _unity_self, ref UnityEngine.GraphicsBufferHandle ret);
        static /*0x7e46e48*/ void InternalSetNativeData_Injected(nint _unity_self, nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
        static /*0x7e46ebc*/ void InternalSetData_Injected(nint _unity_self, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
        static /*0x7e46f98*/ void* BeginBufferWrite_Injected(nint _unity_self, int offset, int size);
        static /*0x7e47044*/ void EndBufferWrite_Injected(nint _unity_self, int bytesWritten);
        static /*0x7e4721c*/ void SetName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        /*0x7e46424*/ GraphicsBuffer(nint ptr);
        /*0x7e4644c*/ GraphicsBuffer(UnityEngine.GraphicsBuffer.Target target, int count, int stride);
        /*0x7e46790*/ GraphicsBuffer(UnityEngine.GraphicsBuffer.Target target, UnityEngine.GraphicsBuffer.UsageFlags usageFlags, int count, int stride);
        /*0x7e46170*/ void Finalize();
        /*0x7e462c8*/ void Dispose();
        /*0x7e46208*/ void Dispose(bool disposing);
        /*0x7e46498*/ void InternalInitialization(UnityEngine.GraphicsBuffer.Target target, UnityEngine.GraphicsBuffer.UsageFlags usageFlags, int count, int stride);
        /*0x7e467dc*/ void Release();
        /*0x7e46864*/ bool IsValid();
        /*0x7e468b4*/ int get_count();
        /*0x7e46940*/ int get_stride();
        /*0x7e469cc*/ UnityEngine.GraphicsBuffer.UsageFlags GetUsageFlags();
        /*0x7e46a58*/ UnityEngine.GraphicsBuffer.UsageFlags get_usageFlags();
        /*0x7e46a5c*/ UnityEngine.GraphicsBufferHandle get_bufferHandle();
        /*0x3910ae8*/ void SetData<T>(Unity.Collections.NativeArray<T> data);
        /*0x7e46b00*/ void SetData(System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
        /*0x3910ae8*/ void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
        /*0x7e46dc0*/ void InternalSetNativeData(nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
        /*0x7e46d38*/ void InternalSetData(System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
        /*0x7e46f30*/ void* BeginBufferWrite(int offset, int size);
        /*0x3910ae8*/ Unity.Collections.NativeArray<T> LockBufferForWrite<T>(int bufferStartIndex, int count);
        /*0x7e46fec*/ void EndBufferWrite(int bytesWritten);
        /*0x3815ed0*/ void UnlockBufferAfterWrite<T>(int countWritten);
        /*0x7e47088*/ void set_name(string value);
        /*0x7e4708c*/ void SetName(string name);

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
            static /*0x7e47260*/ UnityEngine.GraphicsBuffer ConvertToManaged(nint ptr);
            static /*0x7e472bc*/ nint ConvertToNative(UnityEngine.GraphicsBuffer graphicsBuffer);
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

        static /*0x7e4b708*/ int get_pixelLightCount();
        static /*0x7e4b730*/ void set_pixelLightCount(int value);
        static /*0x7e4b76c*/ UnityEngine.Light[] GetLights(UnityEngine.LightType type, int layer);
        static /*0x7e4734c*/ UnityEngine.LightType get_type_Injected(nint _unity_self);
        static /*0x7e47408*/ void set_type_Injected(nint _unity_self, UnityEngine.LightType value);
        static /*0x7e474d4*/ float get_spotAngle_Injected(nint _unity_self);
        static /*0x7e47598*/ void set_spotAngle_Injected(nint _unity_self, float value);
        static /*0x7e4765c*/ float get_innerSpotAngle_Injected(nint _unity_self);
        static /*0x7e47720*/ void set_innerSpotAngle_Injected(nint _unity_self, float value);
        static /*0x7e47800*/ void get_color_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x7e478d4*/ void set_color_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x7e47990*/ float get_colorTemperature_Injected(nint _unity_self);
        static /*0x7e47a54*/ void set_colorTemperature_Injected(nint _unity_self, float value);
        static /*0x7e47b18*/ bool get_useColorTemperature_Injected(nint _unity_self);
        static /*0x7e47bd4*/ void set_useColorTemperature_Injected(nint _unity_self, bool value);
        static /*0x7e47c90*/ float get_intensity_Injected(nint _unity_self);
        static /*0x7e47d54*/ void set_intensity_Injected(nint _unity_self, float value);
        static /*0x7e47e18*/ float get_bounceIntensity_Injected(nint _unity_self);
        static /*0x7e47edc*/ void set_bounceIntensity_Injected(nint _unity_self, float value);
        static /*0x7e47fa0*/ UnityEngine.Rendering.LightUnit get_lightUnit_Injected(nint _unity_self);
        static /*0x7e4805c*/ void set_lightUnit_Injected(nint _unity_self, UnityEngine.Rendering.LightUnit value);
        static /*0x7e48118*/ float get_luxAtDistance_Injected(nint _unity_self);
        static /*0x7e481dc*/ void set_luxAtDistance_Injected(nint _unity_self, float value);
        static /*0x7e482a0*/ bool get_enableSpotReflector_Injected(nint _unity_self);
        static /*0x7e4835c*/ void set_enableSpotReflector_Injected(nint _unity_self, bool value);
        static /*0x7e48418*/ bool get_useBoundingSphereOverride_Injected(nint _unity_self);
        static /*0x7e484d4*/ void set_useBoundingSphereOverride_Injected(nint _unity_self, bool value);
        static /*0x7e485ac*/ void get_boundingSphereOverride_Injected(nint _unity_self, ref UnityEngine.Vector4 ret);
        static /*0x7e48680*/ void set_boundingSphereOverride_Injected(nint _unity_self, ref UnityEngine.Vector4 value);
        static /*0x7e4873c*/ bool get_useViewFrustumForShadowCasterCull_Injected(nint _unity_self);
        static /*0x7e487f8*/ void set_useViewFrustumForShadowCasterCull_Injected(nint _unity_self, bool value);
        static /*0x7e488b4*/ bool get_forceVisible_Injected(nint _unity_self);
        static /*0x7e48970*/ void set_forceVisible_Injected(nint _unity_self, bool value);
        static /*0x7e48a2c*/ int get_shadowCustomResolution_Injected(nint _unity_self);
        static /*0x7e48ae8*/ void set_shadowCustomResolution_Injected(nint _unity_self, int value);
        static /*0x7e48ba4*/ float get_shadowBias_Injected(nint _unity_self);
        static /*0x7e48c68*/ void set_shadowBias_Injected(nint _unity_self, float value);
        static /*0x7e48d2c*/ float get_shadowNormalBias_Injected(nint _unity_self);
        static /*0x7e48df0*/ void set_shadowNormalBias_Injected(nint _unity_self, float value);
        static /*0x7e48eb4*/ float get_shadowNearPlane_Injected(nint _unity_self);
        static /*0x7e48f78*/ void set_shadowNearPlane_Injected(nint _unity_self, float value);
        static /*0x7e4903c*/ bool get_useShadowMatrixOverride_Injected(nint _unity_self);
        static /*0x7e490f8*/ void set_useShadowMatrixOverride_Injected(nint _unity_self, bool value);
        static /*0x7e491e4*/ void get_shadowMatrixOverride_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e492a8*/ void set_shadowMatrixOverride_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 value);
        static /*0x7e49364*/ float get_range_Injected(nint _unity_self);
        static /*0x7e49428*/ void set_range_Injected(nint _unity_self, float value);
        static /*0x7e494ec*/ float get_dilatedRange_Injected(nint _unity_self);
        static /*0x7e495bc*/ nint get_flare_Injected(nint _unity_self);
        static /*0x7e496ac*/ void set_flare_Injected(nint _unity_self, nint value);
        static /*0x7e49794*/ void get_bakingOutput_Injected(nint _unity_self, ref UnityEngine.LightBakingOutput ret);
        static /*0x7e49858*/ void set_bakingOutput_Injected(nint _unity_self, ref UnityEngine.LightBakingOutput value);
        static /*0x7e49914*/ int get_cullingMask_Injected(nint _unity_self);
        static /*0x7e499d0*/ void set_cullingMask_Injected(nint _unity_self, int value);
        static /*0x7e49a8c*/ int get_renderingLayerMask_Injected(nint _unity_self);
        static /*0x7e49b48*/ void set_renderingLayerMask_Injected(nint _unity_self, int value);
        static /*0x7e49c04*/ UnityEngine.LightShadowCasterMode get_lightShadowCasterMode_Injected(nint _unity_self);
        static /*0x7e49cc0*/ void set_lightShadowCasterMode_Injected(nint _unity_self, UnityEngine.LightShadowCasterMode value);
        static /*0x7e49d7c*/ void Reset_Injected(nint _unity_self);
        static /*0x7e49e30*/ UnityEngine.LightShadows get_shadows_Injected(nint _unity_self);
        static /*0x7e49eec*/ void set_shadows_Injected(nint _unity_self, UnityEngine.LightShadows value);
        static /*0x7e49fa8*/ float get_shadowStrength_Injected(nint _unity_self);
        static /*0x7e4a06c*/ void set_shadowStrength_Injected(nint _unity_self, float value);
        static /*0x7e4a130*/ UnityEngine.Rendering.LightShadowResolution get_shadowResolution_Injected(nint _unity_self);
        static /*0x7e4a1ec*/ void set_shadowResolution_Injected(nint _unity_self, UnityEngine.Rendering.LightShadowResolution value);
        static /*0x7e4a370*/ void get_layerShadowCullDistances_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e4a4b0*/ void set_layerShadowCullDistances_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7e4a56c*/ float get_cookieSize_Injected(nint _unity_self);
        static /*0x7e4a630*/ void set_cookieSize_Injected(nint _unity_self, float value);
        static /*0x7e4a710*/ nint get_cookie_Injected(nint _unity_self);
        static /*0x7e4a800*/ void set_cookie_Injected(nint _unity_self, nint value);
        static /*0x7e4a8bc*/ UnityEngine.LightRenderMode get_renderMode_Injected(nint _unity_self);
        static /*0x7e4a978*/ void set_renderMode_Injected(nint _unity_self, UnityEngine.LightRenderMode value);
        static /*0x7e4aa54*/ void get_areaSize_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e4ab1c*/ void set_areaSize_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e4ad08*/ void AddCommandBufferInternal_Injected(nint _unity_self, UnityEngine.Rendering.LightEvent evt, nint buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask);
        static /*0x7e4af28*/ void AddCommandBufferAsyncInternal_Injected(nint _unity_self, UnityEngine.Rendering.LightEvent evt, nint buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType);
        static /*0x7e4b11c*/ void RemoveCommandBufferInternal_Injected(nint _unity_self, UnityEngine.Rendering.LightEvent evt, nint buffer);
        static /*0x7e4b2d8*/ void RemoveCommandBuffersInternal_Injected(nint _unity_self, UnityEngine.Rendering.LightEvent evt);
        static /*0x7e4b46c*/ void RemoveAllCommandBuffersInternal_Injected(nint _unity_self);
        static /*0x7e4b610*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffersInternal_Injected(nint _unity_self, UnityEngine.Rendering.LightEvent evt);
        static /*0x7e4b6cc*/ int get_commandBufferCount_Injected(nint _unity_self);
        /*0x7e4b7d4*/ Light();
        /*0x7e472d4*/ UnityEngine.LightType get_type();
        /*0x7e47388*/ void set_type(UnityEngine.LightType value);
        /*0x7e4744c*/ UnityEngine.LightShape get_shape();
        /*0x7e47454*/ void set_shape(UnityEngine.LightShape value);
        /*0x7e4745c*/ float get_spotAngle();
        /*0x7e47510*/ void set_spotAngle(float value);
        /*0x7e475e4*/ float get_innerSpotAngle();
        /*0x7e47698*/ void set_innerSpotAngle(float value);
        /*0x7e4776c*/ UnityEngine.Color get_color();
        /*0x7e47844*/ void set_color(UnityEngine.Color value);
        /*0x7e47918*/ float get_colorTemperature();
        /*0x7e479cc*/ void set_colorTemperature(float value);
        /*0x7e47aa0*/ bool get_useColorTemperature();
        /*0x7e47b54*/ void set_useColorTemperature(bool value);
        /*0x7e47c18*/ float get_intensity();
        /*0x7e47ccc*/ void set_intensity(float value);
        /*0x7e47da0*/ float get_bounceIntensity();
        /*0x7e47e54*/ void set_bounceIntensity(float value);
        /*0x7e47f28*/ UnityEngine.Rendering.LightUnit get_lightUnit();
        /*0x7e47fdc*/ void set_lightUnit(UnityEngine.Rendering.LightUnit value);
        /*0x7e480a0*/ float get_luxAtDistance();
        /*0x7e48154*/ void set_luxAtDistance(float value);
        /*0x7e48228*/ bool get_enableSpotReflector();
        /*0x7e482dc*/ void set_enableSpotReflector(bool value);
        /*0x7e483a0*/ bool get_useBoundingSphereOverride();
        /*0x7e48454*/ void set_useBoundingSphereOverride(bool value);
        /*0x7e48518*/ UnityEngine.Vector4 get_boundingSphereOverride();
        /*0x7e485f0*/ void set_boundingSphereOverride(UnityEngine.Vector4 value);
        /*0x7e486c4*/ bool get_useViewFrustumForShadowCasterCull();
        /*0x7e48778*/ void set_useViewFrustumForShadowCasterCull(bool value);
        /*0x7e4883c*/ bool get_forceVisible();
        /*0x7e488f0*/ void set_forceVisible(bool value);
        /*0x7e489b4*/ int get_shadowCustomResolution();
        /*0x7e48a68*/ void set_shadowCustomResolution(int value);
        /*0x7e48b2c*/ float get_shadowBias();
        /*0x7e48be0*/ void set_shadowBias(float value);
        /*0x7e48cb4*/ float get_shadowNormalBias();
        /*0x7e48d68*/ void set_shadowNormalBias(float value);
        /*0x7e48e3c*/ float get_shadowNearPlane();
        /*0x7e48ef0*/ void set_shadowNearPlane(float value);
        /*0x7e48fc4*/ bool get_useShadowMatrixOverride();
        /*0x7e49078*/ void set_useShadowMatrixOverride(bool value);
        /*0x7e4913c*/ UnityEngine.Matrix4x4 get_shadowMatrixOverride();
        /*0x7e49228*/ void set_shadowMatrixOverride(UnityEngine.Matrix4x4 value);
        /*0x7e492ec*/ float get_range();
        /*0x7e493a0*/ void set_range(float value);
        /*0x7e49474*/ float get_dilatedRange();
        /*0x7e49528*/ UnityEngine.Flare get_flare();
        /*0x7e495f8*/ void set_flare(UnityEngine.Flare value);
        /*0x7e496f0*/ UnityEngine.LightBakingOutput get_bakingOutput();
        /*0x7e497d8*/ void set_bakingOutput(UnityEngine.LightBakingOutput value);
        /*0x7e4989c*/ int get_cullingMask();
        /*0x7e49950*/ void set_cullingMask(int value);
        /*0x7e49a14*/ int get_renderingLayerMask();
        /*0x7e49ac8*/ void set_renderingLayerMask(int value);
        /*0x7e49b8c*/ UnityEngine.LightShadowCasterMode get_lightShadowCasterMode();
        /*0x7e49c40*/ void set_lightShadowCasterMode(UnityEngine.LightShadowCasterMode value);
        /*0x7e49d04*/ void Reset();
        /*0x7e49db8*/ UnityEngine.LightShadows get_shadows();
        /*0x7e49e6c*/ void set_shadows(UnityEngine.LightShadows value);
        /*0x7e49f30*/ float get_shadowStrength();
        /*0x7e49fe4*/ void set_shadowStrength(float value);
        /*0x7e4a0b8*/ UnityEngine.Rendering.LightShadowResolution get_shadowResolution();
        /*0x7e4a16c*/ void set_shadowResolution(UnityEngine.Rendering.LightShadowResolution value);
        /*0x7e4a230*/ float get_shadowSoftness();
        /*0x7e4a238*/ void set_shadowSoftness(float value);
        /*0x7e4a23c*/ float get_shadowSoftnessFade();
        /*0x7e4a244*/ void set_shadowSoftnessFade(float value);
        /*0x7e4a248*/ float[] get_layerShadowCullDistances();
        /*0x7e4a3b4*/ void set_layerShadowCullDistances(float[] value);
        /*0x7e4a4f4*/ float get_cookieSize();
        /*0x7e4a5a8*/ void set_cookieSize(float value);
        /*0x7e4a67c*/ UnityEngine.Texture get_cookie();
        /*0x7e4a74c*/ void set_cookie(UnityEngine.Texture value);
        /*0x7e4a844*/ UnityEngine.LightRenderMode get_renderMode();
        /*0x7e4a8f8*/ void set_renderMode(UnityEngine.LightRenderMode value);
        /*0x7e4a9bc*/ int get_bakedIndex();
        /*0x7e4a9c4*/ void set_bakedIndex(int value);
        /*0x7e4a9cc*/ UnityEngine.Vector2 get_areaSize();
        /*0x7e4aa98*/ void set_areaSize(UnityEngine.Vector2 value);
        /*0x7e4ab60*/ void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x7e4ab68*/ void AddCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask);
        /*0x7e4ac68*/ void AddCommandBufferInternal(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask);
        /*0x7e4ad64*/ void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ComputeQueueType queueType);
        /*0x7e4ad70*/ void AddCommandBufferAsync(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType);
        /*0x7e4ae78*/ void AddCommandBufferAsyncInternal(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer, UnityEngine.Rendering.ShadowMapPass shadowPassMask, UnityEngine.Rendering.ComputeQueueType queueType);
        /*0x7e4af94*/ void RemoveCommandBuffer(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x7e4b084*/ void RemoveCommandBufferInternal(UnityEngine.Rendering.LightEvent evt, UnityEngine.Rendering.CommandBuffer buffer);
        /*0x7e4b170*/ void RemoveCommandBuffers(UnityEngine.Rendering.LightEvent evt);
        /*0x7e4b258*/ void RemoveCommandBuffersInternal(UnityEngine.Rendering.LightEvent evt);
        /*0x7e4b31c*/ void RemoveAllCommandBuffers();
        /*0x7e4b3f4*/ void RemoveAllCommandBuffersInternal();
        /*0x7e4b4a8*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Rendering.LightEvent evt);
        /*0x7e4b590*/ UnityEngine.Rendering.CommandBuffer[] GetCommandBuffersInternal(UnityEngine.Rendering.LightEvent evt);
        /*0x7e4b654*/ int get_commandBufferCount();
        /*0x7e4b7b0*/ float get_shadowConstantBias();
        /*0x7e4b7b8*/ void set_shadowConstantBias(float value);
        /*0x7e4b7bc*/ float get_shadowObjectSizeBias();
        /*0x7e4b7c4*/ void set_shadowObjectSizeBias(float value);
        /*0x7e4b7c8*/ bool get_attenuate();
        /*0x7e4b7d0*/ void set_attenuate(bool value);
    }

    class Skybox : UnityEngine.Behaviour
    {
        static /*0x7e4b870*/ nint get_material_Injected(nint _unity_self);
        /*0x7e4b7dc*/ UnityEngine.Material get_material();
    }

    class MeshFilter : UnityEngine.Component
    {
        static /*0x7e4b944*/ nint get_sharedMesh_Injected(nint _unity_self);
        static /*0x7e4ba34*/ void set_sharedMesh_Injected(nint _unity_self, nint value);
        static /*0x7e4bb0c*/ nint get_mesh_Injected(nint _unity_self);
        static /*0x7e4bbfc*/ void set_mesh_Injected(nint _unity_self, nint value);
        /*0x7e4bc40*/ MeshFilter();
        /*0x7e4b8ac*/ void DontStripMeshFilter();
        /*0x7e4b8b0*/ UnityEngine.Mesh get_sharedMesh();
        /*0x7e4b980*/ void set_sharedMesh(UnityEngine.Mesh value);
        /*0x7e4ba78*/ UnityEngine.Mesh get_mesh();
        /*0x7e4bb48*/ void set_mesh(UnityEngine.Mesh value);
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
        static /*0x7e4bce0*/ nint get_additionalVertexStreams_Injected(nint _unity_self);
        static /*0x7e4bdd0*/ void set_additionalVertexStreams_Injected(nint _unity_self, nint value);
        static /*0x7e4bea8*/ nint get_enlightenVertexStream_Injected(nint _unity_self);
        static /*0x7e4bf98*/ void set_enlightenVertexStream_Injected(nint _unity_self, nint value);
        static /*0x7e4c054*/ int get_subMeshStartIndex_Injected(nint _unity_self);
        /*0x7e4c090*/ MeshRenderer();
        /*0x7e4bc48*/ void DontStripMeshRenderer();
        /*0x7e4bc4c*/ UnityEngine.Mesh get_additionalVertexStreams();
        /*0x7e4bd1c*/ void set_additionalVertexStreams(UnityEngine.Mesh value);
        /*0x7e4be14*/ UnityEngine.Mesh get_enlightenVertexStream();
        /*0x7e4bee4*/ void set_enlightenVertexStream(UnityEngine.Mesh value);
        /*0x7e4bfdc*/ int get_subMeshStartIndex();
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
        static /*0x7e4c098*/ void Internal_Create(UnityEngine.Mesh mono);
        static /*0x7e4c154*/ UnityEngine.Mesh FromInstanceID(int id);
        static /*0x7e52aa0*/ UnityEngine.Rendering.VertexAttribute GetUVChannel(int uvIndex);
        static /*0x7e52b14*/ int DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute channel);
        static /*0x7e54f50*/ UnityEngine.Mesh.MeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh mesh);
        static /*0x7e54f84*/ UnityEngine.Mesh.MeshDataArray AcquireReadOnlyMeshData(UnityEngine.Mesh[] meshes);
        static /*0x7e55024*/ UnityEngine.Mesh.MeshDataArray AcquireReadOnlyMeshData(System.Collections.Generic.List<UnityEngine.Mesh> meshes);
        static /*0x7e55128*/ UnityEngine.Mesh.MeshDataArray AllocateWritableMeshData(int meshCount);
        static /*0x7e55154*/ UnityEngine.Mesh.MeshDataArray AllocateWritableMeshData(UnityEngine.Mesh mesh);
        static /*0x7e55188*/ UnityEngine.Mesh.MeshDataArray AllocateWritableMeshData(UnityEngine.Mesh[] meshes);
        static /*0x7e55228*/ UnityEngine.Mesh.MeshDataArray AllocateWritableMeshData(System.Collections.Generic.List<UnityEngine.Mesh> meshes);
        static /*0x7e5532c*/ void ApplyAndDisposeWritableMeshData(UnityEngine.Mesh.MeshDataArray data, UnityEngine.Mesh mesh, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e554ac*/ void ApplyAndDisposeWritableMeshData(UnityEngine.Mesh.MeshDataArray data, UnityEngine.Mesh[] meshes, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e555fc*/ void ApplyAndDisposeWritableMeshData(UnityEngine.Mesh.MeshDataArray data, System.Collections.Generic.List<UnityEngine.Mesh> meshes, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e4c1c0*/ nint FromInstanceID_Injected(int id);
        static /*0x7e4c274*/ UnityEngine.Rendering.IndexFormat get_indexFormat_Injected(nint _unity_self);
        static /*0x7e4c330*/ void set_indexFormat_Injected(nint _unity_self, UnityEngine.Rendering.IndexFormat value);
        static /*0x7e4c3ec*/ uint GetTotalIndexCount_Injected(nint _unity_self);
        static /*0x7e4c4b8*/ void SetIndexBufferParams_Injected(nint _unity_self, int indexCount, UnityEngine.Rendering.IndexFormat format);
        static /*0x7e4c5cc*/ void InternalSetIndexBufferData_Injected(nint _unity_self, nint data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e4c710*/ void InternalSetIndexBufferDataFromArray_Injected(nint _unity_self, System.Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e4c82c*/ void SetVertexBufferParamsFromPtr_Injected(nint _unity_self, int vertexCount, nint attributesPtr, int attributesCount);
        static /*0x7e4c994*/ void SetVertexBufferParamsFromArray_Injected(nint _unity_self, int vertexCount, ref UnityEngine.Bindings.ManagedSpanWrapper attributes);
        static /*0x7e4cab0*/ void InternalSetVertexBufferData_Injected(nint _unity_self, int stream, nint data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e4cc04*/ void InternalSetVertexBufferDataFromArray_Injected(nint _unity_self, int stream, System.Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e4cd08*/ System.Array GetVertexAttributesAlloc_Injected(nint _unity_self);
        static /*0x7e4ce68*/ int GetVertexAttributesArray_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper attributes);
        static /*0x7e4d0b4*/ int GetVertexAttributesList_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableListWrapper attributes);
        static /*0x7e4d170*/ int GetVertexAttributeCountImpl_Injected(nint _unity_self);
        static /*0x7e4d244*/ void GetVertexAttribute_Injected(nint _unity_self, int index, ref UnityEngine.Rendering.VertexAttributeDescriptor ret);
        static /*0x7e4d318*/ uint GetIndexStartImpl_Injected(nint _unity_self, int submesh);
        static /*0x7e4d3dc*/ uint GetIndexCountImpl_Injected(nint _unity_self, int submesh);
        static /*0x7e4d4a0*/ uint GetTrianglesCountImpl_Injected(nint _unity_self, int submesh);
        static /*0x7e4d564*/ uint GetBaseVertexImpl_Injected(nint _unity_self, int submesh);
        static /*0x7e4d6ec*/ void GetTrianglesImpl_Injected(nint _unity_self, int submesh, bool applyBaseVertex, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e4d88c*/ void GetIndicesImpl_Injected(nint _unity_self, int submesh, bool applyBaseVertex, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e4d9c0*/ void SetIndicesImpl_Injected(nint _unity_self, int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        static /*0x7e4db34*/ void SetIndicesNativeArrayImpl_Injected(nint _unity_self, int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, nint indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        static /*0x7e4dd44*/ void GetTrianglesNonAllocImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values, int submesh, bool applyBaseVertex);
        static /*0x7e4df14*/ void GetTrianglesNonAllocImpl16_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values, int submesh, bool applyBaseVertex);
        static /*0x7e4e0e4*/ void GetIndicesNonAllocImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values, int submesh, bool applyBaseVertex);
        static /*0x7e4e2b4*/ void GetIndicesNonAllocImpl16_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values, int submesh, bool applyBaseVertex);
        static /*0x7e4e390*/ void PrintErrorCantAccessChannel_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute ch);
        static /*0x7e4e454*/ bool HasVertexAttribute_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute attr);
        static /*0x7e4e518*/ int GetVertexAttributeDimension_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute attr);
        static /*0x7e4e5dc*/ UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute attr);
        static /*0x7e4e6a0*/ int GetVertexAttributeStream_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute attr);
        static /*0x7e4e764*/ int GetVertexAttributeOffset_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute attr);
        static /*0x7e4e880*/ void SetArrayForChannelImpl_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e4e9f4*/ void SetNativeArrayForChannelImpl_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, nint values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e4eb28*/ System.Array GetAllocArrayFromChannelImpl_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim);
        static /*0x7e4ec2c*/ void GetArrayFromChannelImpl_Injected(nint _unity_self, UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values);
        static /*0x7e4ed10*/ int get_vertexBufferCount_Injected(nint _unity_self);
        static /*0x7e4edcc*/ int GetVertexBufferStride_Injected(nint _unity_self, int stream);
        static /*0x7e4ee90*/ nint GetNativeVertexBufferPtr_Injected(nint _unity_self, int index);
        static /*0x7e4ef4c*/ nint GetNativeIndexBufferPtr_Injected(nint _unity_self);
        static /*0x7e4f01c*/ nint GetVertexBufferImpl_Injected(nint _unity_self, int index);
        static /*0x7e4f0ec*/ nint GetIndexBufferImpl_Injected(nint _unity_self);
        static /*0x7e4f1bc*/ nint GetBoneWeightBufferImpl_Injected(nint _unity_self, int bonesPerVertex);
        static /*0x7e4f294*/ nint GetBlendShapeBufferImpl_Injected(nint _unity_self, int layout);
        static /*0x7e4f350*/ UnityEngine.GraphicsBuffer.Target get_vertexBufferTarget_Injected(nint _unity_self);
        static /*0x7e4f40c*/ void set_vertexBufferTarget_Injected(nint _unity_self, UnityEngine.GraphicsBuffer.Target value);
        static /*0x7e4f4c8*/ UnityEngine.GraphicsBuffer.Target get_indexBufferTarget_Injected(nint _unity_self);
        static /*0x7e4f584*/ void set_indexBufferTarget_Injected(nint _unity_self, UnityEngine.GraphicsBuffer.Target value);
        static /*0x7e4f640*/ int get_blendShapeCount_Injected(nint _unity_self);
        static /*0x7e4f6f4*/ void ClearBlendShapes_Injected(nint _unity_self);
        static /*0x7e4f838*/ void GetBlendShapeName_Injected(nint _unity_self, int shapeIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e4fa34*/ int GetBlendShapeIndex_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper blendShapeName);
        static /*0x7e4faf8*/ int GetBlendShapeFrameCount_Injected(nint _unity_self, int shapeIndex);
        static /*0x7e4fbcc*/ float GetBlendShapeFrameWeight_Injected(nint _unity_self, int shapeIndex, int frameIndex);
        static /*0x7e4fdd4*/ void GetBlendShapeFrameVertices_Injected(nint _unity_self, int shapeIndex, int frameIndex, ref UnityEngine.Bindings.ManagedSpanWrapper deltaVertices, ref UnityEngine.Bindings.ManagedSpanWrapper deltaNormals, ref UnityEngine.Bindings.ManagedSpanWrapper deltaTangents);
        static /*0x7e5012c*/ void AddBlendShapeFrame_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper shapeName, float frameWeight, ref UnityEngine.Bindings.ManagedSpanWrapper deltaVertices, ref UnityEngine.Bindings.ManagedSpanWrapper deltaNormals, ref UnityEngine.Bindings.ManagedSpanWrapper deltaTangents);
        static /*0x7e50248*/ void GetBlendShapeOffsetInternal_Injected(nint _unity_self, int index, ref UnityEngine.BlendShape ret);
        static /*0x7e50314*/ bool HasBoneWeights_Injected(nint _unity_self);
        static /*0x7e50478*/ void GetBoneWeightsImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e505b8*/ void SetBoneWeightsImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper weights);
        static /*0x7e50768*/ void InternalSetBoneWeights_Injected(nint _unity_self, nint bonesPerVertex, int bonesPerVertexSize, nint weights, int weightsSize);
        static /*0x7e50a9c*/ int GetAllBoneWeightsArraySize_Injected(nint _unity_self);
        static /*0x7e50b50*/ int GetBoneWeightBufferLayoutInternal_Injected(nint _unity_self);
        static /*0x7e50b8c*/ nint GetAllBoneWeightsArray_Injected(nint _unity_self);
        static /*0x7e50bc8*/ nint GetBonesPerVertexArray_Injected(nint _unity_self);
        static /*0x7e50c7c*/ int get_bindposeCount_Injected(nint _unity_self);
        static /*0x7e50de0*/ void get_bindposes_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e50f20*/ void set_bindposes_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7e511bc*/ void SetBindposesFromScript_NativeArray_Injected(nint _unity_self, nint posesPtr, int posesCount);
        static /*0x7e51210*/ nint GetBindposesArray_Injected(nint _unity_self);
        static /*0x7e513a4*/ void GetBoneWeightsNonAllocImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values);
        static /*0x7e51540*/ void GetBindposesNonAllocImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper values);
        static /*0x7e515fc*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x7e516b0*/ bool get_canAccess_Injected(nint _unity_self);
        static /*0x7e516ec*/ int get_vertexCount_Injected(nint _unity_self);
        static /*0x7e51728*/ int get_subMeshCount_Injected(nint _unity_self);
        static /*0x7e517e4*/ void set_subMeshCount_Injected(nint _unity_self, int value);
        static /*0x7e518c0*/ void SetSubMesh_Injected(nint _unity_self, int index, ref UnityEngine.Rendering.SubMeshDescriptor desc, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e519d4*/ void GetSubMesh_Injected(nint _unity_self, int index, ref UnityEngine.Rendering.SubMeshDescriptor ret);
        static /*0x7e51b4c*/ void SetAllSubMeshesAtOnceFromArray_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e51c60*/ void SetAllSubMeshesAtOnceFromNativeArray_Injected(nint _unity_self, nint desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e51d70*/ void get_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds ret);
        static /*0x7e51e34*/ void set_bounds_Injected(nint _unity_self, ref UnityEngine.Bounds value);
        static /*0x7e51ef8*/ void ClearImpl_Injected(nint _unity_self, bool keepVertexLayout);
        static /*0x7e51fbc*/ void RecalculateBoundsImpl_Injected(nint _unity_self, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e52080*/ void RecalculateNormalsImpl_Injected(nint _unity_self, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e52144*/ void RecalculateTangentsImpl_Injected(nint _unity_self, UnityEngine.Rendering.MeshUpdateFlags flags);
        static /*0x7e52200*/ void MarkDynamicImpl_Injected(nint _unity_self);
        static /*0x7e522b4*/ void MarkModified_Injected(nint _unity_self);
        static /*0x7e52370*/ void UploadMeshDataImpl_Injected(nint _unity_self, bool markNoLongerReadable);
        static /*0x7e52434*/ UnityEngine.MeshTopology GetTopologyImpl_Injected(nint _unity_self, int submesh);
        static /*0x7e52508*/ void RecalculateUVDistributionMetricImpl_Injected(nint _unity_self, int uvSetIndex, float uvAreaThreshold);
        static /*0x7e525e4*/ void RecalculateUVDistributionMetricsImpl_Injected(nint _unity_self, float uvAreaThreshold);
        static /*0x7e526b0*/ float GetUVDistributionMetric_Injected(nint _unity_self, int uvSetIndex);
        static /*0x7e52818*/ void CombineMeshesImpl_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData);
        static /*0x7e528fc*/ void OptimizeImpl_Injected(nint _unity_self);
        static /*0x7e529b0*/ void OptimizeIndexBuffersImpl_Injected(nint _unity_self);
        static /*0x7e52a64*/ void OptimizeReorderVertexBufferImpl_Injected(nint _unity_self);
        /*0x7e4c0d4*/ Mesh();
        /*0x7e4c1fc*/ UnityEngine.Rendering.IndexFormat get_indexFormat();
        /*0x7e4c2b0*/ void set_indexFormat(UnityEngine.Rendering.IndexFormat value);
        /*0x7e4c374*/ uint GetTotalIndexCount();
        /*0x7e4c428*/ void SetIndexBufferParams(int indexCount, UnityEngine.Rendering.IndexFormat format);
        /*0x7e4c50c*/ void InternalSetIndexBufferData(nint data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e4c650*/ void InternalSetIndexBufferDataFromArray(System.Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e4c794*/ void SetVertexBufferParamsFromPtr(int vertexCount, nint attributesPtr, int attributesCount);
        /*0x7e4c888*/ void SetVertexBufferParamsFromArray(int vertexCount, UnityEngine.Rendering.VertexAttributeDescriptor[] attributes);
        /*0x7e4c9e8*/ void InternalSetVertexBufferData(int stream, nint data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e4cb3c*/ void InternalSetVertexBufferDataFromArray(int stream, System.Array data, int dataStart, int meshBufferStart, int count, int elemSize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e4cc90*/ System.Array GetVertexAttributesAlloc();
        /*0x7e4cd44*/ int GetVertexAttributesArray(UnityEngine.Rendering.VertexAttributeDescriptor[] attributes);
        /*0x7e4ceac*/ int GetVertexAttributesList(System.Collections.Generic.List<UnityEngine.Rendering.VertexAttributeDescriptor> attributes);
        /*0x7e4d0f8*/ int GetVertexAttributeCountImpl();
        /*0x7e4d1ac*/ UnityEngine.Rendering.VertexAttributeDescriptor GetVertexAttribute(int index);
        /*0x7e4d298*/ uint GetIndexStartImpl(int submesh);
        /*0x7e4d35c*/ uint GetIndexCountImpl(int submesh);
        /*0x7e4d420*/ uint GetTrianglesCountImpl(int submesh);
        /*0x7e4d4e4*/ uint GetBaseVertexImpl(int submesh);
        /*0x7e4d5a8*/ int[] GetTrianglesImpl(int submesh, bool applyBaseVertex);
        /*0x7e4d748*/ int[] GetIndicesImpl(int submesh, bool applyBaseVertex);
        /*0x7e4d8e8*/ void SetIndicesImpl(int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        /*0x7e4da5c*/ void SetIndicesNativeArrayImpl(int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, nint indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        /*0x7e4dbd0*/ void GetTrianglesNonAllocImpl(int[] values, int submesh, bool applyBaseVertex);
        /*0x7e4dda0*/ void GetTrianglesNonAllocImpl16(ushort[] values, int submesh, bool applyBaseVertex);
        /*0x7e4df70*/ void GetIndicesNonAllocImpl(int[] values, int submesh, bool applyBaseVertex);
        /*0x7e4e140*/ void GetIndicesNonAllocImpl16(ushort[] values, int submesh, bool applyBaseVertex);
        /*0x7e4e310*/ void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute ch);
        /*0x7e4e3d4*/ bool HasVertexAttribute(UnityEngine.Rendering.VertexAttribute attr);
        /*0x7e4e498*/ int GetVertexAttributeDimension(UnityEngine.Rendering.VertexAttribute attr);
        /*0x7e4e55c*/ UnityEngine.Rendering.VertexAttributeFormat GetVertexAttributeFormat(UnityEngine.Rendering.VertexAttribute attr);
        /*0x7e4e620*/ int GetVertexAttributeStream(UnityEngine.Rendering.VertexAttribute attr);
        /*0x7e4e6e4*/ int GetVertexAttributeOffset(UnityEngine.Rendering.VertexAttribute attr);
        /*0x7e4e7a8*/ void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e4e91c*/ void SetNativeArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, nint values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e4ea90*/ System.Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim);
        /*0x7e4eb84*/ void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values);
        /*0x7e4ec98*/ int get_vertexBufferCount();
        /*0x7e4ed4c*/ int GetVertexBufferStride(int stream);
        /*0x7e4ee10*/ nint GetNativeVertexBufferPtr(int index);
        /*0x7e4eed4*/ nint GetNativeIndexBufferPtr();
        /*0x7e4ef88*/ UnityEngine.GraphicsBuffer GetVertexBufferImpl(int index);
        /*0x7e4f060*/ UnityEngine.GraphicsBuffer GetIndexBufferImpl();
        /*0x7e4f128*/ UnityEngine.GraphicsBuffer GetBoneWeightBufferImpl(int bonesPerVertex);
        /*0x7e4f200*/ UnityEngine.GraphicsBuffer GetBlendShapeBufferImpl(int layout);
        /*0x7e4f2d8*/ UnityEngine.GraphicsBuffer.Target get_vertexBufferTarget();
        /*0x7e4f38c*/ void set_vertexBufferTarget(UnityEngine.GraphicsBuffer.Target value);
        /*0x7e4f450*/ UnityEngine.GraphicsBuffer.Target get_indexBufferTarget();
        /*0x7e4f504*/ void set_indexBufferTarget(UnityEngine.GraphicsBuffer.Target value);
        /*0x7e4f5c8*/ int get_blendShapeCount();
        /*0x7e4f67c*/ void ClearBlendShapes();
        /*0x7e4f730*/ string GetBlendShapeName(int shapeIndex);
        /*0x7e4f88c*/ int GetBlendShapeIndex(string blendShapeName);
        /*0x7e4fa78*/ int GetBlendShapeFrameCount(int shapeIndex);
        /*0x7e4fb3c*/ float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex);
        /*0x7e4fc20*/ void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, UnityEngine.Vector3[] deltaVertices, UnityEngine.Vector3[] deltaNormals, UnityEngine.Vector3[] deltaTangents);
        /*0x7e4fe48*/ void AddBlendShapeFrame(string shapeName, float frameWeight, UnityEngine.Vector3[] deltaVertices, UnityEngine.Vector3[] deltaNormals, UnityEngine.Vector3[] deltaTangents);
        /*0x7e501a8*/ UnityEngine.BlendShape GetBlendShapeOffsetInternal(int index);
        /*0x7e5029c*/ bool HasBoneWeights();
        /*0x7e50350*/ UnityEngine.BoneWeight[] GetBoneWeightsImpl();
        /*0x7e504bc*/ void SetBoneWeightsImpl(UnityEngine.BoneWeight[] weights);
        /*0x7e505fc*/ void SetBoneWeights(Unity.Collections.NativeArray<byte> bonesPerVertex, Unity.Collections.NativeArray<UnityEngine.BoneWeight1> weights);
        /*0x7e506c0*/ void InternalSetBoneWeights(nint bonesPerVertex, int bonesPerVertexSize, nint weights, int weightsSize);
        /*0x7e507d4*/ Unity.Collections.NativeArray<UnityEngine.BoneWeight1> GetAllBoneWeights();
        /*0x7e50930*/ Unity.Collections.NativeArray<byte> GetBonesPerVertex();
        /*0x7e508b8*/ int GetAllBoneWeightsArraySize();
        /*0x7e50ad8*/ int GetBoneWeightBufferLayoutInternal();
        /*0x7e50840*/ nint GetAllBoneWeightsArray();
        /*0x7e50a24*/ nint GetBonesPerVertexArray();
        /*0x7e50c04*/ int get_bindposeCount();
        /*0x7e50cb8*/ UnityEngine.Matrix4x4[] get_bindposes();
        /*0x7e50e24*/ void set_bindposes(UnityEngine.Matrix4x4[] value);
        /*0x7e50f64*/ Unity.Collections.NativeArray<UnityEngine.Matrix4x4> GetBindposes();
        /*0x7e51048*/ void SetBindposes(Unity.Collections.NativeArray<UnityEngine.Matrix4x4> poses);
        /*0x7e5112c*/ void SetBindposesFromScript_NativeArray(nint posesPtr, int posesCount);
        /*0x7e50fd0*/ nint GetBindposesArray();
        /*0x7e5124c*/ void GetBoneWeightsNonAllocImpl(UnityEngine.BoneWeight[] values);
        /*0x7e513e8*/ void GetBindposesNonAllocImpl(UnityEngine.Matrix4x4[] values);
        /*0x7e51584*/ bool get_isReadable();
        /*0x7e51638*/ bool get_canAccess();
        /*0x7e509ac*/ int get_vertexCount();
        /*0x7e2ec40*/ int get_subMeshCount();
        /*0x7e51764*/ void set_subMeshCount(int value);
        /*0x7e51828*/ void SetSubMesh(int index, UnityEngine.Rendering.SubMeshDescriptor desc, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e5191c*/ UnityEngine.Rendering.SubMeshDescriptor GetSubMesh(int index);
        /*0x7e51a28*/ void SetAllSubMeshesAtOnceFromArray(UnityEngine.Rendering.SubMeshDescriptor[] desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e51bb8*/ void SetAllSubMeshesAtOnceFromNativeArray(nint desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e51ccc*/ UnityEngine.Bounds get_bounds();
        /*0x7e51db4*/ void set_bounds(UnityEngine.Bounds value);
        /*0x7e51e78*/ void ClearImpl(bool keepVertexLayout);
        /*0x7e51f3c*/ void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e52000*/ void RecalculateNormalsImpl(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e520c4*/ void RecalculateTangentsImpl(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e52188*/ void MarkDynamicImpl();
        /*0x7e5223c*/ void MarkModified();
        /*0x7e522f0*/ void UploadMeshDataImpl(bool markNoLongerReadable);
        /*0x7e523b4*/ UnityEngine.MeshTopology GetTopologyImpl(int submesh);
        /*0x7e52478*/ void RecalculateUVDistributionMetricImpl(int uvSetIndex, float uvAreaThreshold);
        /*0x7e5255c*/ void RecalculateUVDistributionMetricsImpl(float uvAreaThreshold);
        /*0x7e52630*/ float GetUVDistributionMetric(int uvSetIndex);
        /*0x7e526f4*/ void CombineMeshesImpl(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData);
        /*0x7e52884*/ void OptimizeImpl();
        /*0x7e52938*/ void OptimizeIndexBuffersImpl();
        /*0x7e529ec*/ void OptimizeReorderVertexBufferImpl();
        T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim);
        /*0x3814964*/ T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel);
        /*0x7e52bb0*/ void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e52ddc*/ void SetSizedNativeArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, nint values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Collections.Generic.List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, System.Collections.Generic.List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        void GetListForChannel<T>(System.Collections.Generic.List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim);
        /*0x3910ae8*/ void GetListForChannel<T>(System.Collections.Generic.List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim, UnityEngine.Rendering.VertexAttributeFormat channelType);
        /*0x7e53004*/ UnityEngine.Vector3[] get_vertices();
        /*0x7e53050*/ void set_vertices(UnityEngine.Vector3[] value);
        /*0x7e530b0*/ UnityEngine.Vector3[] get_normals();
        /*0x7e530fc*/ void set_normals(UnityEngine.Vector3[] value);
        /*0x7e5315c*/ UnityEngine.Vector4[] get_tangents();
        /*0x7e531a8*/ void set_tangents(UnityEngine.Vector4[] value);
        /*0x7e53208*/ UnityEngine.Vector2[] get_uv();
        /*0x7e53254*/ void set_uv(UnityEngine.Vector2[] value);
        /*0x7e532b4*/ UnityEngine.Vector2[] get_uv2();
        /*0x7e53300*/ void set_uv2(UnityEngine.Vector2[] value);
        /*0x7e53360*/ UnityEngine.Vector2[] get_uv3();
        /*0x7e533ac*/ void set_uv3(UnityEngine.Vector2[] value);
        /*0x7e5340c*/ UnityEngine.Vector2[] get_uv4();
        /*0x7e53458*/ void set_uv4(UnityEngine.Vector2[] value);
        /*0x7e534b8*/ UnityEngine.Vector2[] get_uv5();
        /*0x7e53504*/ void set_uv5(UnityEngine.Vector2[] value);
        /*0x7e53564*/ UnityEngine.Vector2[] get_uv6();
        /*0x7e535b0*/ void set_uv6(UnityEngine.Vector2[] value);
        /*0x7e53610*/ UnityEngine.Vector2[] get_uv7();
        /*0x7e5365c*/ void set_uv7(UnityEngine.Vector2[] value);
        /*0x7e536bc*/ UnityEngine.Vector2[] get_uv8();
        /*0x7e53708*/ void set_uv8(UnityEngine.Vector2[] value);
        /*0x7e53768*/ UnityEngine.Color[] get_colors();
        /*0x7e537b4*/ void set_colors(UnityEngine.Color[] value);
        /*0x7e53814*/ UnityEngine.Color32[] get_colors32();
        /*0x7e53868*/ void set_colors32(UnityEngine.Color32[] value);
        /*0x7e538d0*/ void GetVertices(System.Collections.Generic.List<UnityEngine.Vector3> vertices);
        /*0x7e53994*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices);
        /*0x7e53a00*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length);
        /*0x7e53a08*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e53a84*/ void SetVertices(UnityEngine.Vector3[] inVertices);
        /*0x7e53aec*/ void SetVertices(UnityEngine.Vector3[] inVertices, int start, int length);
        /*0x7e53b54*/ void SetVertices(UnityEngine.Vector3[] inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices);
        /*0x3910ae8*/ void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length);
        /*0x3910ae8*/ void SetVertices<T>(Unity.Collections.NativeArray<T> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e53bc0*/ void GetNormals(System.Collections.Generic.List<UnityEngine.Vector3> normals);
        /*0x7e53c84*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals);
        /*0x7e53cf0*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length);
        /*0x7e53cf8*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e53d74*/ void SetNormals(UnityEngine.Vector3[] inNormals);
        /*0x7e53ddc*/ void SetNormals(UnityEngine.Vector3[] inNormals, int start, int length);
        /*0x7e53e44*/ void SetNormals(UnityEngine.Vector3[] inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals);
        /*0x3910ae8*/ void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length);
        /*0x3910ae8*/ void SetNormals<T>(Unity.Collections.NativeArray<T> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e53eb0*/ void GetTangents(System.Collections.Generic.List<UnityEngine.Vector4> tangents);
        /*0x7e53f74*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents);
        /*0x7e53fe0*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length);
        /*0x7e53fe8*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e54064*/ void SetTangents(UnityEngine.Vector4[] inTangents);
        /*0x7e540cc*/ void SetTangents(UnityEngine.Vector4[] inTangents, int start, int length);
        /*0x7e54134*/ void SetTangents(UnityEngine.Vector4[] inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents);
        /*0x3910ae8*/ void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length);
        /*0x3910ae8*/ void SetTangents<T>(Unity.Collections.NativeArray<T> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e541a0*/ void GetColors(System.Collections.Generic.List<UnityEngine.Color> colors);
        /*0x7e54264*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors);
        /*0x7e542d0*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors, int start, int length);
        /*0x7e542d8*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e54354*/ void SetColors(UnityEngine.Color[] inColors);
        /*0x7e543bc*/ void SetColors(UnityEngine.Color[] inColors, int start, int length);
        /*0x7e54424*/ void SetColors(UnityEngine.Color[] inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e54490*/ void GetColors(System.Collections.Generic.List<UnityEngine.Color32> colors);
        /*0x7e54558*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors);
        /*0x7e545c4*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length);
        /*0x7e545cc*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e54660*/ void SetColors(UnityEngine.Color32[] inColors);
        /*0x7e546c8*/ void SetColors(UnityEngine.Color32[] inColors, int start, int length);
        /*0x7e54730*/ void SetColors(UnityEngine.Color32[] inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetColors<T>(Unity.Collections.NativeArray<T> inColors);
        /*0x3910ae8*/ void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length);
        /*0x3910ae8*/ void SetColors<T>(Unity.Collections.NativeArray<T> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetUvsImpl<T>(int uvIndex, int dim, System.Collections.Generic.List<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e5479c*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs);
        /*0x7e54818*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs);
        /*0x7e54894*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs);
        /*0x7e54810*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, int start, int length);
        /*0x7e54910*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e5488c*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs, int start, int length);
        /*0x7e5499c*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e54908*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length);
        /*0x7e54a28*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e54ab4*/ void SetUvsImpl(int uvIndex, int dim, System.Array uvs, int arrayStart, int arraySize, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e54bbc*/ void SetUVs(int channel, UnityEngine.Vector2[] uvs);
        /*0x7e54c1c*/ void SetUVs(int channel, UnityEngine.Vector3[] uvs);
        /*0x7e54c7c*/ void SetUVs(int channel, UnityEngine.Vector4[] uvs);
        /*0x7e54c04*/ void SetUVs(int channel, UnityEngine.Vector2[] uvs, int start, int length);
        /*0x7e54cdc*/ void SetUVs(int channel, UnityEngine.Vector2[] uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e54c64*/ void SetUVs(int channel, UnityEngine.Vector3[] uvs, int start, int length);
        /*0x7e54cf4*/ void SetUVs(int channel, UnityEngine.Vector3[] uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e54cc4*/ void SetUVs(int channel, UnityEngine.Vector4[] uvs, int start, int length);
        /*0x7e54d0c*/ void SetUVs(int channel, UnityEngine.Vector4[] uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs);
        /*0x3910ae8*/ void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length);
        /*0x3910ae8*/ void SetUVs<T>(int channel, Unity.Collections.NativeArray<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void GetUVsImpl<T>(int uvIndex, System.Collections.Generic.List<T> uvs, int dim);
        /*0x7e54d24*/ void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs);
        /*0x7e54d88*/ void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector3> uvs);
        /*0x7e54dec*/ void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs);
        /*0x7e54e50*/ int get_vertexAttributeCount();
        /*0x7e54e54*/ UnityEngine.Rendering.VertexAttributeDescriptor[] GetVertexAttributes();
        /*0x7e54ec0*/ int GetVertexAttributes(UnityEngine.Rendering.VertexAttributeDescriptor[] attributes);
        /*0x7e54ec4*/ int GetVertexAttributes(System.Collections.Generic.List<UnityEngine.Rendering.VertexAttributeDescriptor> attributes);
        /*0x7e54ec8*/ void SetVertexBufferParams(int vertexCount, UnityEngine.Rendering.VertexAttributeDescriptor[] attributes);
        /*0x7e54ecc*/ void SetVertexBufferParams(int vertexCount, Unity.Collections.NativeArray<UnityEngine.Rendering.VertexAttributeDescriptor> attributes);
        /*0x3910ae8*/ void SetVertexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetVertexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, int stream, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetVertexBufferData<T>(System.Collections.Generic.List<T> data, int dataStart, int meshBufferStart, int count, int stream, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e557c8*/ UnityEngine.GraphicsBuffer GetVertexBuffer(int index);
        /*0x7e55874*/ UnityEngine.GraphicsBuffer GetIndexBuffer();
        /*0x7e55910*/ UnityEngine.GraphicsBuffer GetBoneWeightBuffer(UnityEngine.SkinWeights layout);
        /*0x7e55bb8*/ UnityEngine.GraphicsBuffer GetBlendShapeBuffer(UnityEngine.Rendering.BlendShapeBufferLayout layout);
        /*0x7e55cc8*/ UnityEngine.GraphicsBuffer GetBlendShapeBuffer();
        /*0x7e55dc8*/ UnityEngine.BlendShapeBufferRange GetBlendShapeBufferRange(int blendShapeIndex);
        /*0x7e55ecc*/ void PrintErrorCantAccessIndices();
        /*0x7e55f68*/ bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles);
        /*0x7e5606c*/ bool CheckCanAccessSubmeshTriangles(int submesh);
        /*0x7e56074*/ bool CheckCanAccessSubmeshIndices(int submesh);
        /*0x7e5607c*/ int[] get_triangles();
        /*0x7e560f0*/ void set_triangles(int[] value);
        /*0x7e56214*/ int[] GetTriangles(int submesh);
        /*0x7e5621c*/ int[] GetTriangles(int submesh, bool applyBaseVertex);
        /*0x7e562a4*/ void GetTriangles(System.Collections.Generic.List<int> triangles, int submesh);
        /*0x7e562ac*/ void GetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool applyBaseVertex);
        /*0x7e5641c*/ void GetTriangles(System.Collections.Generic.List<ushort> triangles, int submesh, bool applyBaseVertex);
        /*0x7e5658c*/ int[] GetIndices(int submesh);
        /*0x7e56594*/ int[] GetIndices(int submesh, bool applyBaseVertex);
        /*0x7e5661c*/ void GetIndices(System.Collections.Generic.List<int> indices, int submesh);
        /*0x7e56624*/ void GetIndices(System.Collections.Generic.List<int> indices, int submesh, bool applyBaseVertex);
        /*0x7e56810*/ void GetIndices(System.Collections.Generic.List<ushort> indices, int submesh, bool applyBaseVertex);
        /*0x3910ae8*/ void SetIndexBufferData<T>(Unity.Collections.NativeArray<T> data, int dataStart, int meshBufferStart, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetIndexBufferData<T>(T[] data, int dataStart, int meshBufferStart, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetIndexBufferData<T>(System.Collections.Generic.List<T> data, int dataStart, int meshBufferStart, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e56980*/ uint GetIndexStart(int submesh);
        /*0x7e56794*/ uint GetIndexCount(int submesh);
        /*0x7e569fc*/ uint GetBaseVertex(int submesh);
        /*0x7e56a78*/ void CheckIndicesArrayRange(int valuesLength, int start, int length);
        /*0x7e56194*/ void SetTrianglesImpl(int submesh, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex);
        /*0x7e56c14*/ void SetTriangles(int[] triangles, int submesh);
        /*0x7e56cb4*/ void SetTriangles(int[] triangles, int submesh, bool calculateBounds);
        /*0x7e56c5c*/ void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e56d08*/ void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e56da4*/ void SetTriangles(ushort[] triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e56dfc*/ void SetTriangles(ushort[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e56e98*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh);
        /*0x7e56f2c*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds);
        /*0x7e56ea4*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e56f38*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e5705c*/ void SetTriangles(System.Collections.Generic.List<ushort> triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e570e4*/ void SetTriangles(System.Collections.Generic.List<ushort> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e57208*/ void SetIndices(int[] indices, UnityEngine.MeshTopology topology, int submesh);
        /*0x7e572e0*/ void SetIndices(int[] indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds);
        /*0x7e5726c*/ void SetIndices(int[] indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e57348*/ void SetIndices(int[] indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e573f0*/ void SetIndices(ushort[] indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e57464*/ void SetIndices(ushort[] indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x3910ae8*/ void SetIndices<T>(Unity.Collections.NativeArray<T> indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x3910ae8*/ void SetIndices<T>(Unity.Collections.NativeArray<T> indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e5750c*/ void SetIndices(System.Collections.Generic.List<int> indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e575b0*/ void SetIndices(System.Collections.Generic.List<int> indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e576d8*/ void SetIndices(System.Collections.Generic.List<ushort> indices, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e5777c*/ void SetIndices(System.Collections.Generic.List<ushort> indices, int indicesStart, int indicesLength, UnityEngine.MeshTopology topology, int submesh, bool calculateBounds, int baseVertex);
        /*0x7e578a4*/ void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[] desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e57b08*/ void SetSubMeshes(UnityEngine.Rendering.SubMeshDescriptor[] desc, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e57b34*/ void SetSubMeshes(System.Collections.Generic.List<UnityEngine.Rendering.SubMeshDescriptor> desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e57be4*/ void SetSubMeshes(System.Collections.Generic.List<UnityEngine.Rendering.SubMeshDescriptor> desc, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, int start, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x3910ae8*/ void SetSubMeshes<T>(Unity.Collections.NativeArray<T> desc, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e57c98*/ void GetBindposes(System.Collections.Generic.List<UnityEngine.Matrix4x4> bindposes);
        /*0x7e57da4*/ void GetBoneWeights(System.Collections.Generic.List<UnityEngine.BoneWeight> boneWeights);
        /*0x7e57eb4*/ UnityEngine.BoneWeight[] get_boneWeights();
        /*0x7e57eb8*/ void set_boneWeights(UnityEngine.BoneWeight[] value);
        /*0x7e57ebc*/ UnityEngine.SkinWeights get_skinWeightBufferLayout();
        /*0x7e57ec0*/ void Clear(bool keepVertexLayout);
        /*0x7e57ec8*/ void Clear();
        /*0x7e57ed0*/ void RecalculateBounds();
        /*0x7e57f90*/ void RecalculateNormals();
        /*0x7e58050*/ void RecalculateTangents();
        /*0x7e57ed8*/ void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e57f98*/ void RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e58058*/ void RecalculateTangents(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x7e58110*/ void RecalculateUVDistributionMetric(int uvSetIndex, float uvAreaThreshold);
        /*0x7e581dc*/ void RecalculateUVDistributionMetrics(float uvAreaThreshold);
        /*0x7e582a0*/ void MarkDynamic();
        /*0x7e582c4*/ void UploadMeshData(bool markNoLongerReadable);
        /*0x7e582fc*/ void Optimize();
        /*0x7e583ac*/ void OptimizeIndexBuffers();
        /*0x7e5845c*/ void OptimizeReorderVertexBuffer();
        /*0x7e5850c*/ UnityEngine.MeshTopology GetTopology(int submesh);
        /*0x7e585b0*/ void CombineMeshes(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData);
        /*0x7e585c0*/ void CombineMeshes(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices);
        /*0x7e585d0*/ void CombineMeshes(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes);
        /*0x7e585e0*/ void CombineMeshes(UnityEngine.CombineInstance[] combine);

        struct MeshData
        {
            /*0x10*/ nint m_Ptr;
        }

        struct MeshDataArray : System.IDisposable
        {
            /*0x10*/ nint* m_Ptrs;
            /*0x18*/ int m_Length;

            static /*0x7e598b4*/ void AcquireReadOnlyMeshData(UnityEngine.Mesh mesh, nint* datas);
            static /*0x7e599a8*/ void AcquireReadOnlyMeshDatas(UnityEngine.Mesh[] meshes, nint* datas, int count);
            static /*0x7e59a8c*/ void AcquireMeshDataCopy(UnityEngine.Mesh mesh, nint* datas);
            static /*0x7e59b80*/ void AcquireMeshDatasCopy(UnityEngine.Mesh[] meshes, nint* datas, int count);
            static /*0x7e59c64*/ void ReleaseMeshDatas(nint* datas, int count);
            static /*0x7e59ca8*/ void CreateNewMeshDatas(nint* datas, int count);
            static /*0x7e59cec*/ void ApplyToMeshesImpl(UnityEngine.Mesh[] meshes, nint* datas, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
            static /*0x7e59de0*/ void ApplyToMeshImpl(UnityEngine.Mesh mesh, nint data, UnityEngine.Rendering.MeshUpdateFlags flags);
            static /*0x7e59964*/ void AcquireReadOnlyMeshData_Injected(nint mesh, nint* datas);
            static /*0x7e59a38*/ void AcquireReadOnlyMeshDatas_Injected(UnityEngine.Mesh[] meshes, nint* datas, int count);
            static /*0x7e59b3c*/ void AcquireMeshDataCopy_Injected(nint mesh, nint* datas);
            static /*0x7e59c10*/ void AcquireMeshDatasCopy_Injected(UnityEngine.Mesh[] meshes, nint* datas, int count);
            static /*0x7e59d84*/ void ApplyToMeshesImpl_Injected(UnityEngine.Mesh[] meshes, nint* datas, int count, UnityEngine.Rendering.MeshUpdateFlags flags);
            static /*0x7e59ea0*/ void ApplyToMeshImpl_Injected(nint mesh, nint data, UnityEngine.Rendering.MeshUpdateFlags flags);
            /*0x7e5a240*/ MeshDataArray(UnityEngine.Mesh mesh, bool checkReadWrite, bool createAsCopy);
            /*0x7e5a434*/ MeshDataArray(UnityEngine.Mesh[] meshes, int meshesCount, bool checkReadWrite, bool createAsCopy);
            /*0x7e5a6f8*/ MeshDataArray(int meshesCount);
            /*0x7e59ef4*/ int get_Length();
            /*0x7e59efc*/ void Dispose();
            /*0x7e59f84*/ void ApplyToMeshAndDispose(UnityEngine.Mesh mesh, UnityEngine.Rendering.MeshUpdateFlags flags);
            /*0x7e5a058*/ void ApplyToMeshesAndDispose(UnityEngine.Mesh[] meshes, UnityEngine.Rendering.MeshUpdateFlags flags);
        }
    }

    struct BlendShape
    {
        /*0x10*/ uint m_FirstVertex;
        /*0x14*/ uint m_VertexCount;
        /*0x18*/ bool m_HasNormals;
        /*0x19*/ bool m_HasTangents;

        /*0x7e5a818*/ uint get_firstVertex();
        /*0x7e5a820*/ uint get_vertexCount();
    }

    struct BlendShapeBufferRange
    {
        /*0x10*/ uint m_StartIndex;
        /*0x14*/ uint m_EndIndex;

        /*0x7e5a828*/ void set_startIndex(uint value);
        /*0x7e5a830*/ void set_endIndex(uint value);
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

        /*0x7e5a838*/ float get_weight0();
        /*0x7e5a840*/ float get_weight1();
        /*0x7e5a848*/ float get_weight2();
        /*0x7e5a850*/ float get_weight3();
        /*0x7e5a858*/ int get_boneIndex0();
        /*0x7e5a860*/ int get_boneIndex1();
        /*0x7e5a868*/ int get_boneIndex2();
        /*0x7e5a870*/ int get_boneIndex3();
        /*0x7e5a878*/ int GetHashCode();
        /*0x7e5a984*/ bool Equals(object other);
        /*0x7e5aa0c*/ bool Equals(UnityEngine.BoneWeight other);
    }

    struct BoneWeight1 : System.IEquatable<UnityEngine.BoneWeight1>
    {
        /*0x10*/ float m_Weight;
        /*0x14*/ int m_BoneIndex;

        /*0x7e5aaf0*/ float get_weight();
        /*0x7e5aaf8*/ int get_boneIndex();
        /*0x7e5ab00*/ bool Equals(object other);
        /*0x7e5ab78*/ bool Equals(UnityEngine.BoneWeight1 other);
        /*0x7e5abd8*/ int GetHashCode();
    }

    struct CombineInstance
    {
        /*0x10*/ int m_MeshInstanceID;
        /*0x14*/ int m_SubMeshIndex;
        /*0x18*/ UnityEngine.Matrix4x4 m_Transform;
        /*0x58*/ UnityEngine.Vector4 m_LightmapScaleOffset;
        /*0x68*/ UnityEngine.Vector4 m_RealtimeLightmapScaleOffset;

        /*0x7e5ac24*/ void set_mesh(UnityEngine.Mesh value);
        /*0x7e5acb4*/ void set_subMeshIndex(int value);
        /*0x7e5acbc*/ void set_transform(UnityEngine.Matrix4x4 value);
    }

    class Texture : UnityEngine.Object
    {
        static /*0x0*/ int GenerateAllMips;

        static /*0x7e5c840*/ Texture();
        static /*0x7e5c004*/ void SetStreamingTextureMaterialDebugPropertiesWithSlot(int materialTextureSlot);
        static /*0x7e5c040*/ void SetStreamingTextureMaterialDebugProperties(int materialTextureSlot);
        static /*0x7e5c0b4*/ bool get_streamingTextureDiscardUnusedMips();
        static /*0x7e5c0dc*/ void set_streamingTextureDiscardUnusedMips(bool value);
        static /*0x7e5adcc*/ int get_mipmapCount_Injected(nint _unity_self);
        static /*0x7e5aefc*/ int GetDataWidth_Injected(nint _unity_self);
        static /*0x7e5afd4*/ int GetDataHeight_Injected(nint _unity_self);
        static /*0x7e5b0ac*/ UnityEngine.Rendering.TextureDimension GetDimension_Injected(nint _unity_self);
        static /*0x7e5b238*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x7e5b310*/ UnityEngine.TextureWrapMode get_wrapMode_Injected(nint _unity_self);
        static /*0x7e5b3f8*/ void set_wrapMode_Injected(nint _unity_self, UnityEngine.TextureWrapMode value);
        static /*0x7e5b4e8*/ void set_wrapModeU_Injected(nint _unity_self, UnityEngine.TextureWrapMode value);
        static /*0x7e5b5d8*/ void set_wrapModeV_Injected(nint _unity_self, UnityEngine.TextureWrapMode value);
        static /*0x7e5b6c8*/ void set_wrapModeW_Injected(nint _unity_self, UnityEngine.TextureWrapMode value);
        static /*0x7e5b7a8*/ UnityEngine.FilterMode get_filterMode_Injected(nint _unity_self);
        static /*0x7e5b890*/ void set_filterMode_Injected(nint _unity_self, UnityEngine.FilterMode value);
        static /*0x7e5b970*/ int get_anisoLevel_Injected(nint _unity_self);
        static /*0x7e5ba58*/ void set_anisoLevel_Injected(nint _unity_self, int value);
        static /*0x7e5bb38*/ float get_mipMapBias_Injected(nint _unity_self);
        static /*0x7e5bc20*/ void set_mipMapBias_Injected(nint _unity_self, float value);
        static /*0x7e5bd20*/ void get_texelSize_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e5be00*/ uint get_updateCount_Injected(nint _unity_self);
        static /*0x7e5bed8*/ void IncrementUpdateCount_Injected(nint _unity_self);
        static /*0x7e5bfb0*/ int Internal_GetActiveTextureColorSpace_Injected(nint _unity_self);
        static /*0x7e5c1cc*/ ulong GetPixelDataSize_Injected(nint _unity_self, int mipLevel, int element);
        static /*0x7e5c2d4*/ ulong GetPixelDataOffset_Injected(nint _unity_self, int mipLevel, int element);
        /*0x7e5acd8*/ Texture();
        /*0x7e5ad30*/ int get_mipmapCount();
        /*0x7e5ae08*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x7e5ae60*/ int GetDataWidth();
        /*0x7e5af38*/ int GetDataHeight();
        /*0x7e5b010*/ UnityEngine.Rendering.TextureDimension GetDimension();
        /*0x7e5b0e8*/ int get_width();
        /*0x7e5b0ec*/ void set_width(int value);
        /*0x7e5b124*/ int get_height();
        /*0x7e5b128*/ void set_height(int value);
        /*0x7e5b160*/ UnityEngine.Rendering.TextureDimension get_dimension();
        /*0x7e5b164*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
        /*0x7e5b19c*/ bool get_isReadable();
        /*0x7e5b274*/ UnityEngine.TextureWrapMode get_wrapMode();
        /*0x7e5b34c*/ void set_wrapMode(UnityEngine.TextureWrapMode value);
        /*0x7e5b43c*/ void set_wrapModeU(UnityEngine.TextureWrapMode value);
        /*0x7e5b52c*/ void set_wrapModeV(UnityEngine.TextureWrapMode value);
        /*0x7e5b61c*/ void set_wrapModeW(UnityEngine.TextureWrapMode value);
        /*0x7e5b70c*/ UnityEngine.FilterMode get_filterMode();
        /*0x7e5b7e4*/ void set_filterMode(UnityEngine.FilterMode value);
        /*0x7e5b8d4*/ int get_anisoLevel();
        /*0x7e5b9ac*/ void set_anisoLevel(int value);
        /*0x7e5ba9c*/ float get_mipMapBias();
        /*0x7e5bb74*/ void set_mipMapBias(float value);
        /*0x7e5bc6c*/ UnityEngine.Vector2 get_texelSize();
        /*0x7e5bd64*/ uint get_updateCount();
        /*0x7e5be3c*/ void IncrementUpdateCount();
        /*0x7e5bf14*/ int Internal_GetActiveTextureColorSpace();
        /*0x7e5bfec*/ UnityEngine.ColorSpace get_activeTextureColorSpace();
        /*0x7e5c118*/ ulong GetPixelDataSize(int mipLevel, int element);
        /*0x7e5c220*/ ulong GetPixelDataOffset(int mipLevel, int element);
        /*0x7e5c328*/ UnityEngine.TextureColorSpace GetTextureColorSpace(bool linear);
        /*0x7e5c334*/ UnityEngine.TextureColorSpace GetTextureColorSpace(UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x7e5c394*/ bool ValidateFormat(UnityEngine.TextureFormat format);
        /*0x7e5c55c*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.GraphicsFormatUsage usage);
        /*0x7e5c694*/ UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture t);
        /*0x7e5c734*/ UnityEngine.UnityException IgnoreMipmapLimitCannotBeToggledException(UnityEngine.Texture t);
        /*0x7e5c7d4*/ UnityEngine.UnityException CreateNativeArrayLengthOverflowException();
    }

    class Texture2D : UnityEngine.Texture
    {
        static int streamingMipmapsPriorityMin = -128;
        static int streamingMipmapsPriorityMax = 127;

        static /*0x7e5ccac*/ UnityEngine.Texture2D get_whiteTexture();
        static /*0x7e5cd38*/ UnityEngine.Texture2D get_blackTexture();
        static /*0x7e5cdc4*/ UnityEngine.Texture2D get_redTexture();
        static /*0x7e5ce50*/ UnityEngine.Texture2D get_grayTexture();
        static /*0x7e5cedc*/ UnityEngine.Texture2D get_linearGrayTexture();
        static /*0x7e5cf68*/ UnityEngine.Texture2D get_normalTexture();
        static /*0x7e5d0b8*/ bool Internal_CreateEmptyImpl(UnityEngine.Texture2D mono);
        static /*0x7e5d0f4*/ bool Internal_CreateImpl(UnityEngine.Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        static /*0x7e5d380*/ void Internal_Create(UnityEngine.Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        static /*0x7e5e5c8*/ void GenerateAtlasImpl(UnityEngine.Vector2[] sizes, int padding, int atlasSize, UnityEngine.Rect[] rect);
        static /*0x7e60bb0*/ UnityEngine.Texture2D CreateExternalTexture(int width, int height, UnityEngine.TextureFormat format, bool mipChain, bool linear, nint nativeTex);
        static /*0x7e6156c*/ bool GenerateAtlas(UnityEngine.Vector2[] sizes, int padding, int atlasSize, System.Collections.Generic.List<UnityEngine.Rect> results);
        static /*0x7e5c904*/ UnityEngine.TextureFormat get_format_Injected(nint _unity_self);
        static /*0x7e5c9b8*/ bool IgnoreMipmapLimit_Injected(nint _unity_self);
        static /*0x7e5ca74*/ void SetIgnoreMipmapLimitAndReload_Injected(nint _unity_self, bool value);
        static /*0x7e5cbb4*/ void get_mipmapLimitGroup_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e5cc70*/ int get_activeMipmapLimit_Injected(nint _unity_self);
        static /*0x7e5cd10*/ nint get_whiteTexture_Injected();
        static /*0x7e5cd9c*/ nint get_blackTexture_Injected();
        static /*0x7e5ce28*/ nint get_redTexture_Injected();
        static /*0x7e5ceb4*/ nint get_grayTexture_Injected();
        static /*0x7e5cf40*/ nint get_linearGrayTexture_Injected();
        static /*0x7e5cfcc*/ nint get_normalTexture_Injected();
        static /*0x7e5d074*/ void Compress_Injected(nint _unity_self, bool highQuality);
        static /*0x7e5d2d8*/ bool Internal_CreateImpl_Injected(UnityEngine.Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex, bool ignoreMipmapLimit, ref UnityEngine.Bindings.ManagedSpanWrapper mipmapLimitGroupName);
        static /*0x7e5d470*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x7e5d524*/ bool get_vtOnly_Injected(nint _unity_self);
        static /*0x7e5d5f0*/ void ApplyImpl_Injected(nint _unity_self, bool updateMipmaps, bool makeNoLongerReadable);
        static /*0x7e5d6d4*/ bool ReinitializeImpl_Injected(nint _unity_self, int width, int height);
        static /*0x7e5d7e8*/ void SetPixelImpl_Injected(nint _unity_self, int image, int mip, int x, int y, ref UnityEngine.Color color);
        static /*0x7e5d920*/ void GetPixelImpl_Injected(nint _unity_self, int image, int mip, int x, int y, ref UnityEngine.Color ret);
        static /*0x7e5da58*/ void GetPixelBilinearImpl_Injected(nint _unity_self, int image, int mip, float u, float v, ref UnityEngine.Color ret);
        static /*0x7e5db74*/ bool ReinitializeWithFormatImpl_Injected(nint _unity_self, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap);
        static /*0x7e5dc88*/ bool ReinitializeWithTextureFormatImpl_Injected(nint _unity_self, int width, int height, UnityEngine.TextureFormat textureFormat, bool hasMipMap);
        static /*0x7e5dda4*/ void ReadPixelsImpl_Injected(nint _unity_self, ref UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps);
        static /*0x7e5df54*/ void SetPixelsImpl_Injected(nint _unity_self, int x, int y, int w, int h, ref UnityEngine.Bindings.ManagedSpanWrapper pixel, int miplevel, int frame);
        static /*0x7e5e070*/ bool LoadRawTextureDataImpl_Injected(nint _unity_self, nint data, ulong size);
        static /*0x7e5e1c4*/ bool LoadRawTextureDataImplArray_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper data);
        static /*0x7e5e2b8*/ bool SetPixelDataImplArray_Injected(nint _unity_self, System.Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);
        static /*0x7e5e3dc*/ bool SetPixelDataImpl_Injected(nint _unity_self, nint data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);
        static /*0x7e5e4d0*/ nint GetWritableImageData_Injected(nint _unity_self, int frame);
        static /*0x7e5e58c*/ ulong GetImageDataSize_Injected(nint _unity_self);
        static /*0x7e5e77c*/ void GenerateAtlasImpl_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper sizes, int padding, int atlasSize, ref UnityEngine.Bindings.BlittableArrayWrapper rect);
        static /*0x7e5e850*/ bool get_isPreProcessed_Injected(nint _unity_self);
        static /*0x7e5e904*/ bool get_streamingMipmaps_Injected(nint _unity_self);
        static /*0x7e5e9b8*/ int get_streamingMipmapsPriority_Injected(nint _unity_self);
        static /*0x7e5ea6c*/ int get_requestedMipmapLevel_Injected(nint _unity_self);
        static /*0x7e5eb28*/ void set_requestedMipmapLevel_Injected(nint _unity_self, int value);
        static /*0x7e5ebe4*/ int get_minimumMipmapLevel_Injected(nint _unity_self);
        static /*0x7e5eca0*/ void set_minimumMipmapLevel_Injected(nint _unity_self, int value);
        static /*0x7e5ed5c*/ bool get_loadAllMips_Injected(nint _unity_self);
        static /*0x7e5ee18*/ void set_loadAllMips_Injected(nint _unity_self, bool value);
        static /*0x7e5eed4*/ int get_calculatedMipmapLevel_Injected(nint _unity_self);
        static /*0x7e5ef88*/ int get_desiredMipmapLevel_Injected(nint _unity_self);
        static /*0x7e5f03c*/ int get_loadingMipmapLevel_Injected(nint _unity_self);
        static /*0x7e5f0f0*/ int get_loadedMipmapLevel_Injected(nint _unity_self);
        static /*0x7e5f1a4*/ void ClearRequestedMipmapLevel_Injected(nint _unity_self);
        static /*0x7e5f258*/ bool IsRequestedMipmapLevelLoaded_Injected(nint _unity_self);
        static /*0x7e5f30c*/ void ClearMinimumMipmapLevel_Injected(nint _unity_self);
        static /*0x7e5f3c8*/ void UpdateExternalTexture_Injected(nint _unity_self, nint nativeTex);
        static /*0x7e5f518*/ void SetAllPixels32_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, int miplevel);
        static /*0x7e5f6a8*/ void SetBlockOfPixels32_Injected(nint _unity_self, int x, int y, int blockWidth, int blockHeight, ref UnityEngine.Bindings.ManagedSpanWrapper colors, int miplevel);
        static /*0x7e5f7a4*/ byte[] GetRawTextureData_Injected(nint _unity_self);
        static /*0x7e5f890*/ UnityEngine.Color[] GetPixels_Injected(nint _unity_self, int x, int y, int blockWidth, int blockHeight, int miplevel);
        static /*0x7e5f98c*/ UnityEngine.Color32[] GetPixels32_Injected(nint _unity_self, int miplevel);
        static /*0x7e5fa80*/ UnityEngine.Rect[] PackTextures_Injected(nint _unity_self, UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable);
        static /*0x7e5fbb4*/ void CopyPixels_Full_Injected(nint _unity_self, nint src);
        static /*0x7e5fccc*/ void CopyPixels_Slice_Injected(nint _unity_self, nint src, int srcElement, int srcMip, int dstMip);
        static /*0x7e5fe4c*/ void CopyPixels_Region_Injected(nint _unity_self, nint src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY);
        /*0x7e60114*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount, nint nativeTex, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e60230*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e60320*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.DefaultFormat format, int mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e60388*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.DefaultFormat format, int mipCount, string mipmapLimitGroupName, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e60434*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.DefaultFormat format, int mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e6027c*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e604ac*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e604d8*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount, string mipmapLimitGroupName, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e60560*/ Texture2D(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e6058c*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, nint nativeTex, bool createUninitialized, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e60734*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x7e6075c*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized);
        /*0x7e60784*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e6079c*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        /*0x7e60830*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x7e608ec*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized);
        /*0x7e609b4*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x7e60a6c*/ Texture2D(int width, int height);
        /*0x7e5c88c*/ UnityEngine.TextureFormat get_format();
        /*0x7e5c940*/ bool IgnoreMipmapLimit();
        /*0x7e5c9f4*/ void SetIgnoreMipmapLimitAndReload(bool value);
        /*0x7e5cab8*/ string get_mipmapLimitGroup();
        /*0x7e5cbf8*/ int get_activeMipmapLimit();
        /*0x7e5cff4*/ void Compress(bool highQuality);
        /*0x7e5d3f8*/ bool get_isReadable();
        /*0x7e5d4ac*/ bool get_vtOnly();
        /*0x7e5d560*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e5d644*/ bool ReinitializeImpl(int width, int height);
        /*0x7e5d728*/ void SetPixelImpl(int image, int mip, int x, int y, UnityEngine.Color color);
        /*0x7e5d85c*/ UnityEngine.Color GetPixelImpl(int image, int mip, int x, int y);
        /*0x7e5d994*/ UnityEngine.Color GetPixelBilinearImpl(int image, int mip, float u, float v);
        /*0x7e5dacc*/ bool ReinitializeWithFormatImpl(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap);
        /*0x7e5dbe0*/ bool ReinitializeWithTextureFormatImpl(int width, int height, UnityEngine.TextureFormat textureFormat, bool hasMipMap);
        /*0x7e5dcf4*/ void ReadPixelsImpl(UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps);
        /*0x7e5de10*/ void SetPixelsImpl(int x, int y, int w, int h, UnityEngine.Color[] pixel, int miplevel, int frame);
        /*0x7e5dfe0*/ bool LoadRawTextureDataImpl(nint data, ulong size);
        /*0x7e5e0c4*/ bool LoadRawTextureDataImplArray(byte[] data);
        /*0x7e5e208*/ bool SetPixelDataImplArray(System.Array data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);
        /*0x7e5e32c*/ bool SetPixelDataImpl(nint data, int mipLevel, int elementSize, int dataArraySize, int sourceDataStartIndex);
        /*0x7e5e450*/ nint GetWritableImageData(int frame);
        /*0x7e5e514*/ ulong GetImageDataSize();
        /*0x7e5e7d8*/ bool get_isPreProcessed();
        /*0x7e5e88c*/ bool get_streamingMipmaps();
        /*0x7e5e940*/ int get_streamingMipmapsPriority();
        /*0x7e5e9f4*/ int get_requestedMipmapLevel();
        /*0x7e5eaa8*/ void set_requestedMipmapLevel(int value);
        /*0x7e5eb6c*/ int get_minimumMipmapLevel();
        /*0x7e5ec20*/ void set_minimumMipmapLevel(int value);
        /*0x7e5ece4*/ bool get_loadAllMips();
        /*0x7e5ed98*/ void set_loadAllMips(bool value);
        /*0x7e5ee5c*/ int get_calculatedMipmapLevel();
        /*0x7e5ef10*/ int get_desiredMipmapLevel();
        /*0x7e5efc4*/ int get_loadingMipmapLevel();
        /*0x7e5f078*/ int get_loadedMipmapLevel();
        /*0x7e5f12c*/ void ClearRequestedMipmapLevel();
        /*0x7e5f1e0*/ bool IsRequestedMipmapLevelLoaded();
        /*0x7e5f294*/ void ClearMinimumMipmapLevel();
        /*0x7e5f348*/ void UpdateExternalTexture(nint nativeTex);
        /*0x7e5f40c*/ void SetAllPixels32(UnityEngine.Color32[] colors, int miplevel);
        /*0x7e5f56c*/ void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color32[] colors, int miplevel);
        /*0x7e5f72c*/ byte[] GetRawTextureData();
        /*0x7e5f7e0*/ UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel);
        /*0x7e5f904*/ UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight);
        /*0x7e5f90c*/ UnityEngine.Color32[] GetPixels32(int miplevel);
        /*0x7e5f9d0*/ UnityEngine.Color32[] GetPixels32();
        /*0x7e5f9d8*/ UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable);
        /*0x7e5faec*/ UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize);
        /*0x7e5faf4*/ UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, int padding);
        /*0x7e5fb00*/ void CopyPixels_Full(UnityEngine.Texture src);
        /*0x7e5fbf8*/ void CopyPixels_Slice(UnityEngine.Texture src, int srcElement, int srcMip, int dstMip);
        /*0x7e5fd38*/ void CopyPixels_Region(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY);
        /*0x7e5fefc*/ bool ValidateFormat(UnityEngine.TextureFormat format, int width, int height);
        /*0x7e5ffdc*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height);
        /*0x7e60ca8*/ void SetPixel(int x, int y, UnityEngine.Color color);
        /*0x7e60d44*/ void SetPixel(int x, int y, UnityEngine.Color color, int mipLevel);
        /*0x7e60dec*/ void SetPixels(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color[] colors, int miplevel);
        /*0x7e60e90*/ void SetPixels(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color[] colors);
        /*0x7e60e98*/ void SetPixels(UnityEngine.Color[] colors, int miplevel);
        /*0x7e60f10*/ void SetPixels(UnityEngine.Color[] colors);
        /*0x7e60f6c*/ UnityEngine.Color GetPixel(int x, int y);
        /*0x7e60fd8*/ UnityEngine.Color GetPixel(int x, int y, int mipLevel);
        /*0x7e61050*/ UnityEngine.Color GetPixelBilinear(float u, float v);
        /*0x7e610b8*/ UnityEngine.Color GetPixelBilinear(float u, float v, int mipLevel);
        /*0x7e6112c*/ void LoadRawTextureData(nint data, int size);
        /*0x7e61244*/ void LoadRawTextureData(byte[] data);
        /*0x3910ae8*/ void LoadRawTextureData<T>(Unity.Collections.NativeArray<T> data);
        void SetPixelData<T>(T[] data, int mipLevel, int sourceDataStartIndex);
        /*0x3910ae8*/ void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, int sourceDataStartIndex);
        /*0x3910ae8*/ Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel);
        /*0x3910ae8*/ Unity.Collections.NativeArray<T> GetRawTextureData<T>();
        /*0x7e6134c*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e613b0*/ void Apply(bool updateMipmaps);
        /*0x7e613bc*/ void Apply();
        /*0x7e613c8*/ bool Reinitialize(int width, int height);
        /*0x7e6142c*/ bool Reinitialize(int width, int height, UnityEngine.TextureFormat format, bool hasMipMap);
        /*0x7e61434*/ bool Reinitialize(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap);
        /*0x7e614b0*/ bool Resize(int width, int height);
        /*0x7e614b4*/ bool Resize(int width, int height, UnityEngine.TextureFormat format, bool hasMipMap);
        /*0x7e614bc*/ bool Resize(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap);
        /*0x7e614c4*/ void ReadPixels(UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps);
        /*0x7e61564*/ void ReadPixels(UnityEngine.Rect source, int destX, int destY);
        /*0x7e6171c*/ void SetPixels32(UnityEngine.Color32[] colors, int miplevel);
        /*0x7e61720*/ void SetPixels32(UnityEngine.Color32[] colors);
        /*0x7e61728*/ void SetPixels32(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color32[] colors, int miplevel);
        /*0x7e6172c*/ void SetPixels32(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color32[] colors);
        /*0x7e61734*/ UnityEngine.Color[] GetPixels(int miplevel);
        /*0x7e6179c*/ UnityEngine.Color[] GetPixels();
        /*0x7e617a4*/ void CopyPixels(UnityEngine.Texture src);
        /*0x7e61824*/ void CopyPixels(UnityEngine.Texture src, int srcElement, int srcMip, int dstMip);
        /*0x7e618c4*/ void CopyPixels(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstMip, int dstX, int dstY);
        /*0x7e619ac*/ bool get_ignoreMipmapLimit();
        /*0x7e619b0*/ void set_ignoreMipmapLimit(bool value);
    }

    class Cubemap : UnityEngine.Texture
    {
        static /*0x7e61ac0*/ bool Internal_CreateImpl(UnityEngine.Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x7e61b44*/ void Internal_Create(UnityEngine.Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x7e63af0*/ UnityEngine.Cubemap CreateExternalTexture(int width, UnityEngine.TextureFormat format, bool mipmap, nint nativeTex);
        static /*0x7e637f4*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x7e61a84*/ UnityEngine.TextureFormat get_format_Injected(nint _unity_self);
        static /*0x7e61ca8*/ void ApplyImpl_Injected(nint _unity_self, bool updateMipmaps, bool makeNoLongerReadable);
        static /*0x7e61d7c*/ void UpdateExternalTexture_Injected(nint _unity_self, nint nativeTexture);
        static /*0x7e61e38*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x7e61f34*/ void SetPixelImpl_Injected(nint _unity_self, int image, int mip, int x, int y, ref UnityEngine.Color color);
        static /*0x7e6206c*/ void GetPixelImpl_Injected(nint _unity_self, int image, int mip, int x, int y, ref UnityEngine.Color ret);
        static /*0x7e62160*/ void SmoothEdges_Injected(nint _unity_self, int smoothRegionWidthInPixels);
        static /*0x7e6223c*/ UnityEngine.Color[] GetPixels_Injected(nint _unity_self, UnityEngine.CubemapFace face, int miplevel);
        static /*0x7e623ac*/ void SetPixels_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, UnityEngine.CubemapFace face, int miplevel);
        static /*0x7e624c8*/ bool SetPixelDataImplArray_Injected(nint _unity_self, System.Array data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);
        static /*0x7e6260c*/ bool SetPixelDataImpl_Injected(nint _unity_self, nint data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);
        static /*0x7e6274c*/ void CopyPixels_Full_Injected(nint _unity_self, nint src);
        static /*0x7e62874*/ void CopyPixels_Slice_Injected(nint _unity_self, nint src, int srcElement, int srcMip, int dstFace, int dstMip);
        static /*0x7e62a04*/ void CopyPixels_Region_Injected(nint _unity_self, nint src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstFace, int dstMip, int dstX, int dstY);
        static /*0x7e62b44*/ nint GetWritableImageData_Injected(nint _unity_self, int frame);
        static /*0x7e62c00*/ bool get_isPreProcessed_Injected(nint _unity_self);
        static /*0x7e62cb4*/ bool get_streamingMipmaps_Injected(nint _unity_self);
        static /*0x7e62d68*/ int get_streamingMipmapsPriority_Injected(nint _unity_self);
        static /*0x7e62e1c*/ int get_requestedMipmapLevel_Injected(nint _unity_self);
        static /*0x7e62ed8*/ void set_requestedMipmapLevel_Injected(nint _unity_self, int value);
        static /*0x7e62f94*/ bool get_loadAllMips_Injected(nint _unity_self);
        static /*0x7e63050*/ void set_loadAllMips_Injected(nint _unity_self, bool value);
        static /*0x7e6310c*/ int get_desiredMipmapLevel_Injected(nint _unity_self);
        static /*0x7e631c0*/ int get_loadingMipmapLevel_Injected(nint _unity_self);
        static /*0x7e63274*/ int get_loadedMipmapLevel_Injected(nint _unity_self);
        static /*0x7e63328*/ void ClearRequestedMipmapLevel_Injected(nint _unity_self);
        static /*0x7e633dc*/ bool IsRequestedMipmapLevelLoaded_Injected(nint _unity_self);
        /*0x7e63608*/ Cubemap(int width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e636cc*/ Cubemap(int width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e63644*/ Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e63718*/ Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e63848*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex, bool createUninitialized);
        /*0x7e639a4*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x7e63a38*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, bool mipChain, bool createUninitialized);
        /*0x7e63ad8*/ Cubemap(int width, UnityEngine.TextureFormat format, int mipCount);
        /*0x7e63ae4*/ Cubemap(int width, UnityEngine.TextureFormat format, int mipCount, bool createUninitialized);
        /*0x7e61a0c*/ UnityEngine.TextureFormat get_format();
        /*0x7e61c18*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e61cfc*/ void UpdateExternalTexture(nint nativeTexture);
        /*0x7e61dc0*/ bool get_isReadable();
        /*0x7e61e74*/ void SetPixelImpl(int image, int mip, int x, int y, UnityEngine.Color color);
        /*0x7e61fa8*/ UnityEngine.Color GetPixelImpl(int image, int mip, int x, int y);
        /*0x7e620e0*/ void SmoothEdges(int smoothRegionWidthInPixels);
        /*0x7e621a4*/ void SmoothEdges();
        /*0x7e621ac*/ UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace face, int miplevel);
        /*0x7e62290*/ UnityEngine.Color[] GetPixels(UnityEngine.CubemapFace face);
        /*0x7e62298*/ void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, int miplevel);
        /*0x7e62408*/ bool SetPixelDataImplArray(System.Array data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);
        /*0x7e6254c*/ bool SetPixelDataImpl(nint data, int mipLevel, int face, int elementSize, int dataArraySize, int sourceDataStartIndex);
        /*0x7e62690*/ void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face);
        /*0x7e62698*/ void CopyPixels_Full(UnityEngine.Texture src);
        /*0x7e62790*/ void CopyPixels_Slice(UnityEngine.Texture src, int srcElement, int srcMip, int dstFace, int dstMip);
        /*0x7e628e8*/ void CopyPixels_Region(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, int dstFace, int dstMip, int dstX, int dstY);
        /*0x7e62ac4*/ nint GetWritableImageData(int frame);
        /*0x7e62b88*/ bool get_isPreProcessed();
        /*0x7e62c3c*/ bool get_streamingMipmaps();
        /*0x7e62cf0*/ int get_streamingMipmapsPriority();
        /*0x7e62da4*/ int get_requestedMipmapLevel();
        /*0x7e62e58*/ void set_requestedMipmapLevel(int value);
        /*0x7e62f1c*/ bool get_loadAllMips();
        /*0x7e62fd0*/ void set_loadAllMips(bool value);
        /*0x7e63094*/ int get_desiredMipmapLevel();
        /*0x7e63148*/ int get_loadingMipmapLevel();
        /*0x7e631fc*/ int get_loadedMipmapLevel();
        /*0x7e632b0*/ void ClearRequestedMipmapLevel();
        /*0x7e63364*/ bool IsRequestedMipmapLevelLoaded();
        /*0x7e63418*/ bool ValidateFormat(UnityEngine.TextureFormat format, int width);
        /*0x7e634ec*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width);
        void SetPixelData<T>(T[] data, int mipLevel, UnityEngine.CubemapFace face, int sourceDataStartIndex);
        /*0x3910ae8*/ void SetPixelData<T>(Unity.Collections.NativeArray<T> data, int mipLevel, UnityEngine.CubemapFace face, int sourceDataStartIndex);
        /*0x3910ae8*/ Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel, UnityEngine.CubemapFace face);
        /*0x7e63bf4*/ void SetPixel(UnityEngine.CubemapFace face, int x, int y, UnityEngine.Color color);
        /*0x7e63bfc*/ void SetPixel(UnityEngine.CubemapFace face, int x, int y, UnityEngine.Color color, int mip);
        /*0x7e63ca8*/ UnityEngine.Color GetPixel(UnityEngine.CubemapFace face, int x, int y);
        /*0x7e63cb0*/ UnityEngine.Color GetPixel(UnityEngine.CubemapFace face, int x, int y, int mip);
        /*0x7e63d2c*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e63d90*/ void Apply(bool updateMipmaps);
        /*0x7e63d9c*/ void Apply();
        /*0x7e63da8*/ void CopyPixels(UnityEngine.Texture src);
        /*0x7e63e28*/ void CopyPixels(UnityEngine.Texture src, int srcElement, int srcMip, UnityEngine.CubemapFace dstFace, int dstMip);
        /*0x7e63ed8*/ void CopyPixels(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, UnityEngine.CubemapFace dstFace, int dstMip, int dstX, int dstY);
    }

    class Texture3D : UnityEngine.Texture
    {
        static /*0x7e6426c*/ bool Internal_CreateImpl(UnityEngine.Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x7e64308*/ void Internal_Create(UnityEngine.Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x7e64938*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x7e64048*/ int get_depth_Injected(nint _unity_self);
        static /*0x7e640fc*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x7e641f8*/ void SetPixelImpl_Injected(nint _unity_self, int mip, int x, int y, int z, ref UnityEngine.Color color);
        static /*0x7e6448c*/ void ApplyImpl_Injected(nint _unity_self, bool updateMipmaps, bool makeNoLongerReadable);
        static /*0x7e645ec*/ void SetPixels_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, int miplevel);
        static /*0x7e646b8*/ nint GetImageData_Injected(nint _unity_self);
        /*0x7e646f4*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e647e8*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e64748*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e6484c*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e6498c*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount);
        /*0x7e649ac*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex);
        /*0x7e649c8*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex, bool createUninitialized);
        /*0x7e64b2c*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x7e64be4*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, bool createUninitialized);
        /*0x7e64ca8*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, nint nativeTex);
        /*0x7e63fd0*/ int get_depth();
        /*0x7e64084*/ bool get_isReadable();
        /*0x7e64138*/ void SetPixelImpl(int mip, int x, int y, int z, UnityEngine.Color color);
        /*0x7e643fc*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e644e0*/ void SetPixels(UnityEngine.Color[] colors, int miplevel);
        /*0x7e64640*/ nint GetImageData();
        /*0x7e64d6c*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e64dd0*/ void Apply(bool updateMipmaps);
        /*0x7e64ddc*/ void Apply();
        /*0x7e64de8*/ void SetPixel(int x, int y, int z, UnityEngine.Color color, int mipLevel);
        /*0x3910ae8*/ Unity.Collections.NativeArray<T> GetPixelData<T>(int mipLevel);
    }

    class Texture2DArray : UnityEngine.Texture
    {
        static /*0x7e64e94*/ int get_allSlices();
        static /*0x7e64f70*/ bool Internal_CreateImpl(UnityEngine.Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        static /*0x7e651fc*/ void Internal_Create(UnityEngine.Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName);
        static /*0x7e657b0*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x7e64f34*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x7e65154*/ bool Internal_CreateImpl_Injected(UnityEngine.Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, bool ignoreMipmapLimit, ref UnityEngine.Bindings.ManagedSpanWrapper mipmapLimitGroupName);
        /*0x7e6548c*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e65590*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e65620*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e654e0*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e65604*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e65694*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e65804*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, UnityEngine.MipmapLimitDescriptor mipmapLimitDescriptor);
        /*0x7e659b0*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized);
        /*0x7e659d4*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x7e659f8*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized);
        /*0x7e65ac4*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x7e65b8c*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x7e64ebc*/ bool get_isReadable();
        /*0x7e65274*/ bool ValidateFormat(UnityEngine.TextureFormat format, int width, int height);
        /*0x7e65354*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height);
    }

    class CubemapArray : UnityEngine.Texture
    {
        static /*0x7e65cfc*/ bool Internal_CreateImpl(UnityEngine.CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x7e65d80*/ void Internal_Create(UnityEngine.CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.TextureColorSpace colorSpace, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x7e662ec*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x7e65cc0*/ bool get_isReadable_Injected(nint _unity_self);
        static /*0x7e65ee4*/ void ApplyImpl_Injected(nint _unity_self, bool updateMipmaps, bool makeNoLongerReadable);
        static /*0x7e6605c*/ void SetPixels_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, UnityEngine.CubemapFace face, int arrayElement, int miplevel);
        /*0x7e660d0*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e661ac*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e6611c*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x7e66200*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x7e66340*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized);
        /*0x7e664ac*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x7e664b8*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized);
        /*0x7e6656c*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x7e66614*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x7e65c48*/ bool get_isReadable();
        /*0x7e65e54*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e65f38*/ void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, int arrayElement, int miplevel);
        /*0x7e660c8*/ void SetPixels(UnityEngine.Color[] colors, UnityEngine.CubemapFace face, int arrayElement);
        /*0x7e666b8*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x7e6671c*/ void Apply();
    }

    class RenderTexture : UnityEngine.Texture
    {
        static /*0x7e67a28*/ UnityEngine.RenderTexture GetActive();
        static /*0x7e67ab4*/ void SetActive(UnityEngine.RenderTexture rt);
        static /*0x7e67b74*/ UnityEngine.RenderTexture get_active();
        static /*0x7e67b78*/ void set_active(UnityEngine.RenderTexture value);
        static /*0x7e68194*/ void Internal_Create(UnityEngine.RenderTexture rt);
        static /*0x7e682d8*/ UnityEngine.RenderTexture GetTemporary_Internal(UnityEngine.RenderTextureDescriptor desc);
        static /*0x7e68380*/ void ReleaseTemporary(UnityEngine.RenderTexture temp);
        static /*0x7e69014*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat);
        static /*0x7e69550*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.RenderTextureFormat format, bool disableFallback);
        static /*0x7e69774*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Experimental.Rendering.DefaultFormat format);
        static /*0x7e69780*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Rendering.ShadowSamplingMode shadowSamplingMode);
        static /*0x7e6959c*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap);
        static /*0x7e68554*/ void ValidateRenderTextureDesc(ref UnityEngine.RenderTextureDescriptor desc);
        static /*0x7e68c24*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultColorFormat(UnityEngine.Experimental.Rendering.DefaultFormat format);
        static /*0x7e68c40*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDefaultDepthStencilFormat(UnityEngine.Experimental.Rendering.DefaultFormat format, int depth);
        static /*0x7e6958c*/ UnityEngine.Rendering.ShadowSamplingMode GetShadowSamplingModeForFormat(UnityEngine.RenderTextureFormat format);
        static /*0x7e68de8*/ UnityEngine.Rendering.ShadowSamplingMode GetShadowSamplingModeForFormat(UnityEngine.Experimental.Rendering.DefaultFormat format);
        static /*0x7e696b4*/ void WarnAboutFallbackTo16BitsDepth(UnityEngine.RenderTextureFormat format);
        static /*0x7e693fc*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.RenderTextureFormat renderTextureFormat, UnityEngine.RenderTextureReadWrite readWrite);
        static /*0x7e69810*/ UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc);
        static /*0x7e69874*/ UnityEngine.RenderTexture GetTemporaryImpl(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale, UnityEngine.Rendering.ShadowSamplingMode shadowSamplingMode);
        static /*0x7e69a18*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale);
        static /*0x7e69a98*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage);
        static /*0x7e69b14*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode);
        static /*0x7e69b84*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing);
        static /*0x7e69bf0*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format);
        static /*0x7e69c50*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale);
        static /*0x7e69cf4*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage);
        static /*0x7e69d10*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode);
        static /*0x7e69d30*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing);
        static /*0x7e69d54*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
        static /*0x7e69d7c*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format);
        static /*0x7e667a0*/ int get_width_Injected(nint _unity_self);
        static /*0x7e6685c*/ void set_width_Injected(nint _unity_self, int value);
        static /*0x7e66918*/ int get_height_Injected(nint _unity_self);
        static /*0x7e669d4*/ void set_height_Injected(nint _unity_self, int value);
        static /*0x7e66a90*/ UnityEngine.Rendering.TextureDimension get_dimension_Injected(nint _unity_self);
        static /*0x7e66b4c*/ void set_dimension_Injected(nint _unity_self, UnityEngine.Rendering.TextureDimension value);
        static /*0x7e66c10*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetColorFormat_Injected(nint _unity_self, bool suppressWarnings);
        static /*0x7e66cd4*/ void SetColorFormat_Injected(nint _unity_self, UnityEngine.Experimental.Rendering.GraphicsFormat format);
        static /*0x7e66d9c*/ bool get_useMipMap_Injected(nint _unity_self);
        static /*0x7e66e58*/ void set_useMipMap_Injected(nint _unity_self, bool value);
        static /*0x7e66f14*/ bool get_sRGB_Injected(nint _unity_self);
        static /*0x7e6712c*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat_Injected(nint _unity_self);
        static /*0x7e671e8*/ void set_depthStencilFormat_Injected(nint _unity_self, UnityEngine.Experimental.Rendering.GraphicsFormat value);
        static /*0x7e672ac*/ void set_autoGenerateMips_Injected(nint _unity_self, bool value);
        static /*0x7e67368*/ int get_volumeDepth_Injected(nint _unity_self);
        static /*0x7e67424*/ void set_volumeDepth_Injected(nint _unity_self, int value);
        static /*0x7e674e0*/ int get_antiAliasing_Injected(nint _unity_self);
        static /*0x7e67594*/ bool get_bindTextureMS_Injected(nint _unity_self);
        static /*0x7e67648*/ bool get_enableRandomWrite_Injected(nint _unity_self);
        static /*0x7e67704*/ void set_enableRandomWrite_Injected(nint _unity_self, bool value);
        static /*0x7e677c0*/ bool get_useDynamicScale_Injected(nint _unity_self);
        static /*0x7e6787c*/ void set_useDynamicScale_Injected(nint _unity_self, bool value);
        static /*0x7e67938*/ bool get_useDynamicScaleExplicit_Injected(nint _unity_self);
        static /*0x7e679ec*/ void ApplyDynamicScale_Injected(nint _unity_self);
        static /*0x7e67a8c*/ nint GetActive_Injected();
        static /*0x7e67b38*/ void SetActive_Injected(nint rt);
        static /*0x7e67c0c*/ void GetColorBuffer_Injected(nint _unity_self, ref UnityEngine.RenderBuffer ret);
        static /*0x7e67ce0*/ void GetDepthBuffer_Injected(nint _unity_self, ref UnityEngine.RenderBuffer ret);
        static /*0x7e67da4*/ void SetMipMapCount_Injected(nint _unity_self, int count);
        static /*0x7e67e68*/ void SetShadowSamplingMode_Injected(nint _unity_self, UnityEngine.Rendering.ShadowSamplingMode samplingMode);
        static /*0x7e67f2c*/ bool Create_Injected(nint _unity_self);
        static /*0x7e67fe0*/ void Release_Injected(nint _unity_self);
        static /*0x7e68094*/ bool IsCreated_Injected(nint _unity_self);
        static /*0x7e68150*/ void SetSRGBReadWrite_Injected(nint _unity_self, bool srgb);
        static /*0x7e68250*/ void SetRenderTextureDescriptor_Injected(nint _unity_self, ref UnityEngine.RenderTextureDescriptor desc);
        static /*0x7e68294*/ void GetDescriptor_Injected(nint _unity_self, ref UnityEngine.RenderTextureDescriptor ret);
        static /*0x7e68344*/ nint GetTemporary_Internal_Injected(ref UnityEngine.RenderTextureDescriptor desc);
        static /*0x7e68404*/ void ReleaseTemporary_Injected(nint temp);
        /*0x7e68440*/ RenderTexture();
        /*0x7e68494*/ RenderTexture(UnityEngine.RenderTextureDescriptor desc);
        /*0x7e6891c*/ RenderTexture(UnityEngine.RenderTexture textureToCopy);
        /*0x7e68af0*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format);
        /*0x7e68df8*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x7e68e88*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount);
        /*0x7e68c68*/ RenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount);
        /*0x7e6901c*/ RenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
        /*0x7e690ac*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
        /*0x7e692c4*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format);
        /*0x7e693f4*/ RenderTexture(int width, int height, int depth);
        /*0x7e69354*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format, int mipCount);
        /*0x7e66728*/ int get_width();
        /*0x7e667dc*/ void set_width(int value);
        /*0x7e668a0*/ int get_height();
        /*0x7e66954*/ void set_height(int value);
        /*0x7e66a18*/ UnityEngine.Rendering.TextureDimension get_dimension();
        /*0x7e66acc*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
        /*0x7e66b90*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetColorFormat(bool suppressWarnings);
        /*0x7e66c54*/ void SetColorFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x7e66d18*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x7e66d20*/ void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x7e66d24*/ bool get_useMipMap();
        /*0x7e66dd8*/ void set_useMipMap(bool value);
        /*0x7e66e9c*/ bool get_sRGB();
        /*0x7e66f50*/ UnityEngine.RenderTextureFormat get_format();
        /*0x7e670b4*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat();
        /*0x7e67168*/ void set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x7e6722c*/ void set_autoGenerateMips(bool value);
        /*0x7e672f0*/ int get_volumeDepth();
        /*0x7e673a4*/ void set_volumeDepth(int value);
        /*0x7e67468*/ int get_antiAliasing();
        /*0x7e6751c*/ bool get_bindTextureMS();
        /*0x7e675d0*/ bool get_enableRandomWrite();
        /*0x7e67684*/ void set_enableRandomWrite(bool value);
        /*0x7e67748*/ bool get_useDynamicScale();
        /*0x7e677fc*/ void set_useDynamicScale(bool value);
        /*0x7e678c0*/ bool get_useDynamicScaleExplicit();
        /*0x7e67974*/ void ApplyDynamicScale();
        /*0x7e67b7c*/ UnityEngine.RenderBuffer GetColorBuffer();
        /*0x7e67c50*/ UnityEngine.RenderBuffer GetDepthBuffer();
        /*0x7e67d24*/ void SetMipMapCount(int count);
        /*0x7e67de8*/ void SetShadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode samplingMode);
        /*0x7e67eac*/ UnityEngine.RenderBuffer get_colorBuffer();
        /*0x7e67eb0*/ UnityEngine.RenderBuffer get_depthBuffer();
        /*0x7e67eb4*/ bool Create();
        /*0x7e67f68*/ void Release();
        /*0x7e6801c*/ bool IsCreated();
        /*0x7e680d0*/ void SetSRGBReadWrite(bool srgb);
        /*0x7e681d0*/ void SetRenderTextureDescriptor(UnityEngine.RenderTextureDescriptor desc);
        /*0x7e67000*/ UnityEngine.RenderTextureDescriptor GetDescriptor();
        /*0x7e69154*/ void Initialize(int width, int height, int depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int mipCount);
        /*0x7e68aa8*/ UnityEngine.RenderTextureDescriptor get_descriptor();
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
        static /*0x7e69da8*/ void Internal_CreateCustomRenderTexture(UnityEngine.CustomRenderTexture rt);
        static /*0x7e69e64*/ void TriggerUpdate_Injected(nint _unity_self, int count);
        static /*0x7e69f70*/ void TriggerInitialization_Injected(nint _unity_self);
        static /*0x7e6a040*/ void ClearUpdateZones_Injected(nint _unity_self);
        static /*0x7e6a110*/ nint get_material_Injected(nint _unity_self);
        static /*0x7e6a200*/ void set_material_Injected(nint _unity_self, nint value);
        static /*0x7e6a2d8*/ nint get_initializationMaterial_Injected(nint _unity_self);
        static /*0x7e6a3c8*/ void set_initializationMaterial_Injected(nint _unity_self, nint value);
        static /*0x7e6a4a0*/ nint get_initializationTexture_Injected(nint _unity_self);
        static /*0x7e6a590*/ void set_initializationTexture_Injected(nint _unity_self, nint value);
        static /*0x7e6a684*/ void GetUpdateZonesInternal_Injected(nint _unity_self, object updateZones);
        static /*0x7e6a7c8*/ void SetUpdateZonesInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper updateZones);
        static /*0x7e6a8a0*/ nint GetDoubleBufferRenderTexture_Injected(nint _unity_self);
        static /*0x7e6a954*/ void EnsureDoubleBufferConsistency_Injected(nint _unity_self);
        static /*0x7e6aa5c*/ UnityEngine.CustomRenderTextureInitializationSource get_initializationSource_Injected(nint _unity_self);
        static /*0x7e6ab18*/ void set_initializationSource_Injected(nint _unity_self, UnityEngine.CustomRenderTextureInitializationSource value);
        static /*0x7e6abf0*/ void get_initializationColor_Injected(nint _unity_self, ref UnityEngine.Color ret);
        static /*0x7e6acc4*/ void set_initializationColor_Injected(nint _unity_self, ref UnityEngine.Color value);
        static /*0x7e6ad80*/ UnityEngine.CustomRenderTextureUpdateMode get_updateMode_Injected(nint _unity_self);
        static /*0x7e6ae3c*/ void set_updateMode_Injected(nint _unity_self, UnityEngine.CustomRenderTextureUpdateMode value);
        static /*0x7e6aef8*/ UnityEngine.CustomRenderTextureUpdateMode get_initializationMode_Injected(nint _unity_self);
        static /*0x7e6afb4*/ void set_initializationMode_Injected(nint _unity_self, UnityEngine.CustomRenderTextureUpdateMode value);
        static /*0x7e6b070*/ UnityEngine.CustomRenderTextureUpdateZoneSpace get_updateZoneSpace_Injected(nint _unity_self);
        static /*0x7e6b12c*/ void set_updateZoneSpace_Injected(nint _unity_self, UnityEngine.CustomRenderTextureUpdateZoneSpace value);
        static /*0x7e6b1e8*/ int get_shaderPass_Injected(nint _unity_self);
        static /*0x7e6b2a4*/ void set_shaderPass_Injected(nint _unity_self, int value);
        static /*0x7e6b360*/ uint get_cubemapFaceMask_Injected(nint _unity_self);
        static /*0x7e6b41c*/ void set_cubemapFaceMask_Injected(nint _unity_self, uint value);
        static /*0x7e6b4d8*/ bool get_doubleBuffered_Injected(nint _unity_self);
        static /*0x7e6b594*/ void set_doubleBuffered_Injected(nint _unity_self, bool value);
        static /*0x7e6b650*/ bool get_wrapUpdateZones_Injected(nint _unity_self);
        static /*0x7e6b70c*/ void set_wrapUpdateZones_Injected(nint _unity_self, bool value);
        static /*0x7e6b7c8*/ float get_updatePeriod_Injected(nint _unity_self);
        static /*0x7e6b88c*/ void set_updatePeriod_Injected(nint _unity_self, float value);
        /*0x7e6b8d8*/ CustomRenderTexture(int width, int height, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
        /*0x7e6bab0*/ CustomRenderTexture(int width, int height, UnityEngine.RenderTextureFormat format);
        /*0x7e6bab8*/ CustomRenderTexture(int width, int height);
        /*0x7e6baf4*/ CustomRenderTexture(int width, int height, UnityEngine.Experimental.Rendering.DefaultFormat defaultFormat);
        /*0x7e6b9a0*/ CustomRenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x7e69de4*/ void TriggerUpdate(int count);
        /*0x7e69ea8*/ void Update(int count);
        /*0x7e69ed4*/ void Update();
        /*0x7e69ef8*/ void TriggerInitialization();
        /*0x7e69fac*/ void Initialize();
        /*0x7e69fc8*/ void ClearUpdateZones();
        /*0x7e6a07c*/ UnityEngine.Material get_material();
        /*0x7e6a14c*/ void set_material(UnityEngine.Material value);
        /*0x7e6a244*/ UnityEngine.Material get_initializationMaterial();
        /*0x7e6a314*/ void set_initializationMaterial(UnityEngine.Material value);
        /*0x7e6a40c*/ UnityEngine.Texture get_initializationTexture();
        /*0x7e6a4dc*/ void set_initializationTexture(UnityEngine.Texture value);
        /*0x7e6a5d4*/ void GetUpdateZonesInternal(object updateZones);
        /*0x7e6a6c8*/ void GetUpdateZones(System.Collections.Generic.List<UnityEngine.CustomRenderTextureUpdateZone> updateZones);
        /*0x7e6a6cc*/ void SetUpdateZonesInternal(UnityEngine.CustomRenderTextureUpdateZone[] updateZones);
        /*0x7e6a80c*/ UnityEngine.RenderTexture GetDoubleBufferRenderTexture();
        /*0x7e6a8dc*/ void EnsureDoubleBufferConsistency();
        /*0x7e6a990*/ void SetUpdateZones(UnityEngine.CustomRenderTextureUpdateZone[] updateZones);
        /*0x7e6a9e4*/ UnityEngine.CustomRenderTextureInitializationSource get_initializationSource();
        /*0x7e6aa98*/ void set_initializationSource(UnityEngine.CustomRenderTextureInitializationSource value);
        /*0x7e6ab5c*/ UnityEngine.Color get_initializationColor();
        /*0x7e6ac34*/ void set_initializationColor(UnityEngine.Color value);
        /*0x7e6ad08*/ UnityEngine.CustomRenderTextureUpdateMode get_updateMode();
        /*0x7e6adbc*/ void set_updateMode(UnityEngine.CustomRenderTextureUpdateMode value);
        /*0x7e6ae80*/ UnityEngine.CustomRenderTextureUpdateMode get_initializationMode();
        /*0x7e6af34*/ void set_initializationMode(UnityEngine.CustomRenderTextureUpdateMode value);
        /*0x7e6aff8*/ UnityEngine.CustomRenderTextureUpdateZoneSpace get_updateZoneSpace();
        /*0x7e6b0ac*/ void set_updateZoneSpace(UnityEngine.CustomRenderTextureUpdateZoneSpace value);
        /*0x7e6b170*/ int get_shaderPass();
        /*0x7e6b224*/ void set_shaderPass(int value);
        /*0x7e6b2e8*/ uint get_cubemapFaceMask();
        /*0x7e6b39c*/ void set_cubemapFaceMask(uint value);
        /*0x7e6b460*/ bool get_doubleBuffered();
        /*0x7e6b514*/ void set_doubleBuffered(bool value);
        /*0x7e6b5d8*/ bool get_wrapUpdateZones();
        /*0x7e6b68c*/ void set_wrapUpdateZones(bool value);
        /*0x7e6b750*/ float get_updatePeriod();
        /*0x7e6b804*/ void set_updatePeriod(float value);
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

        /*0x7e6bf28*/ RenderTextureDescriptor(int width, int height);
        /*0x7e6bf34*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat);
        /*0x7e6bf3c*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits);
        /*0x7e6bfd8*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits);
        /*0x7e6bfd0*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits, int mipCount);
        /*0x7e6c0d4*/ RenderTextureDescriptor(int width, int height, UnityEngine.RenderTextureFormat colorFormat, int depthBufferBits, int mipCount, UnityEngine.RenderTextureReadWrite readWrite);
        /*0x7e6c068*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits, int mipCount);
        /*0x7e69938*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
        /*0x7e6c1ac*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount);
        /*0x7e6bb94*/ int get_width();
        /*0x7e6bb9c*/ void set_width(int value);
        /*0x7e6bba4*/ int get_height();
        /*0x7e6bbac*/ void set_height(int value);
        /*0x7e6bbb4*/ int get_msaaSamples();
        /*0x7e6bbbc*/ void set_msaaSamples(int value);
        /*0x7e6bbc4*/ int get_volumeDepth();
        /*0x7e6bbcc*/ void set_volumeDepth(int value);
        /*0x7e6bbd4*/ int get_mipCount();
        /*0x7e6bbdc*/ void set_mipCount(int value);
        /*0x7e6978c*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x7e6bbe4*/ void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x7e6bc88*/ void set_stencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x7e6bc90*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat();
        /*0x7e6bc98*/ void set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x7e69794*/ UnityEngine.RenderTextureFormat get_colorFormat();
        /*0x7e6bca0*/ void set_colorFormat(UnityEngine.RenderTextureFormat value);
        /*0x7e6bd60*/ bool get_sRGB();
        /*0x7e6be18*/ void set_sRGB(bool value);
        /*0x7e6bdbc*/ int get_depthBufferBits();
        /*0x7e6bebc*/ void set_depthBufferBits(int value);
        /*0x7e6bee8*/ UnityEngine.Rendering.TextureDimension get_dimension();
        /*0x7e6bef0*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
        /*0x7e6bef8*/ UnityEngine.Rendering.ShadowSamplingMode get_shadowSamplingMode();
        /*0x7e6bf00*/ void set_shadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode value);
        /*0x7e6bf08*/ UnityEngine.VRTextureUsage get_vrUsage();
        /*0x7e6bf10*/ void set_vrUsage(UnityEngine.VRTextureUsage value);
        /*0x7e6bf18*/ UnityEngine.RenderTextureMemoryless get_memoryless();
        /*0x7e6bf20*/ void set_memoryless(UnityEngine.RenderTextureMemoryless value);
        /*0x7e6bc6c*/ void SetOrClearRenderTextureCreationFlag(bool value, UnityEngine.RenderTextureCreationFlags flag);
        /*0x7e6c20c*/ bool get_useMipMap();
        /*0x7e6c218*/ void set_useMipMap(bool value);
        /*0x7e6c228*/ bool get_autoGenerateMips();
        /*0x7e6c234*/ void set_autoGenerateMips(bool value);
        /*0x7e6c254*/ bool get_enableRandomWrite();
        /*0x7e6c260*/ void set_enableRandomWrite(bool value);
        /*0x7e6c280*/ bool get_bindMS();
        /*0x7e6c28c*/ void set_bindMS(bool value);
        /*0x7e69854*/ void set_createdFromScript(bool value);
        /*0x7e6c2ac*/ bool get_useDynamicScale();
        /*0x7e699f8*/ void set_useDynamicScale(bool value);
        /*0x7e6c2b8*/ bool get_useDynamicScaleExplicit();
        /*0x7e6c2c4*/ void set_useDynamicScaleExplicit(bool value);
    }

    struct MipmapLimitDescriptor
    {
        /*0x10*/ bool <useMipmapLimit>k__BackingField;
        /*0x18*/ string <groupName>k__BackingField;

        /*0x7e60420*/ MipmapLimitDescriptor(bool useMipmapLimit, string groupName);
        /*0x7e6c2e4*/ bool get_useMipmapLimit();
        /*0x7e6c2ec*/ string get_groupName();
    }

    struct Hash128 : System.IComparable, System.IComparable<UnityEngine.Hash128>, System.IEquatable<UnityEngine.Hash128>
    {
        static ulong kConst = 16045690984833335023;
        /*0x10*/ ulong u64_0;
        /*0x18*/ ulong u64_1;

        static /*0x7e6c4a4*/ UnityEngine.Hash128 Parse(string hashString);
        static /*0x7e6c3e8*/ string Hash128ToStringImpl(UnityEngine.Hash128 hash);
        static /*0x7e6c6a0*/ void ComputeFromString(string data, ref UnityEngine.Hash128 hash);
        static /*0x7e6c854*/ void ComputeFromPtr(nint data, int start, int count, int elemSize, ref UnityEngine.Hash128 hash);
        static /*0x7e6c8c0*/ UnityEngine.Hash128 Compute(string data);
        static UnityEngine.Hash128 Compute<T>(ref T val);
        static /*0x7e6c8e4*/ UnityEngine.Hash128 Compute(int val);
        static /*0x7e6ca18*/ bool op_Equality(UnityEngine.Hash128 hash1, UnityEngine.Hash128 hash2);
        static /*0x7e6cb3c*/ bool op_Inequality(UnityEngine.Hash128 hash1, UnityEngine.Hash128 hash2);
        static /*0x7e6c388*/ bool op_LessThan(UnityEngine.Hash128 x, UnityEngine.Hash128 y);
        static /*0x7e6c3a0*/ bool op_GreaterThan(UnityEngine.Hash128 x, UnityEngine.Hash128 y);
        static /*0x7e6cb54*/ void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3);
        static /*0x7e6cce8*/ void Rot64(ref ulong x, int k);
        static /*0x7e6c618*/ void Parse_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper hashString, ref UnityEngine.Hash128 ret);
        static /*0x7e6c65c*/ void Hash128ToStringImpl_Injected(ref UnityEngine.Hash128 hash, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e6c810*/ void ComputeFromString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper data, ref UnityEngine.Hash128 hash);
        /*0x7e6c2f4*/ Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3);
        /*0x7e6c30c*/ Hash128(ulong u64_0, ulong u64_1);
        /*0x7e6c314*/ bool get_isValid();
        /*0x7e6c334*/ int CompareTo(UnityEngine.Hash128 rhs);
        /*0x7e6c3dc*/ string ToString();
        /*0x7e6c910*/ void Append(string data);
        /*0x3816710*/ void Append<T>(ref T val);
        /*0x7e6c90c*/ void Append(int val);
        /*0x7e6c994*/ bool Equals(object obj);
        /*0x7e6ca30*/ bool Equals(UnityEngine.Hash128 obj);
        /*0x7e6ca4c*/ int GetHashCode();
        /*0x7e6ca80*/ int CompareTo(object obj);
        /*0x7e6c920*/ void ShortHash4(uint data);
    }

    class HashUtilities
    {
        static /*0x7e6ccfc*/ void AppendHash(ref UnityEngine.Hash128 inHash, ref UnityEngine.Hash128 outHash);
    }

    class HashUnsafeUtilities
    {
        static /*0x7e6cd4c*/ void ComputeHash128(void* data, ulong dataSize, ulong* hash1, ulong* hash2);
        static /*0x7e6cd08*/ void ComputeHash128(void* data, ulong dataSize, UnityEngine.Hash128* hash);
    }

    class SpookyHash
    {
        static /*0x0*/ bool AllowUnalignedRead;

        static /*0x7e6e364*/ SpookyHash();
        static /*0x7e6d0e8*/ bool AttemptDetectAllowUnalignedRead();
        static /*0x7e6cdc8*/ void Hash(void* message, ulong length, ulong* hash1, ulong* hash2);
        static /*0x7e6da34*/ void End(ulong* data, ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11);
        static /*0x7e6dca0*/ void EndPartial(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11);
        static /*0x7e6df38*/ void Rot64(ref ulong x, int k);
        static /*0x7e6d170*/ void Short(void* message, ulong length, ulong* hash1, ulong* hash2);
        static /*0x7e6df4c*/ void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3);
        static /*0x7e6e168*/ void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3);
        static /*0x7e6d510*/ void Mix(ulong* data, ref ulong s0, ref ulong s1, ref ulong s2, ref ulong s3, ref ulong s4, ref ulong s5, ref ulong s6, ref ulong s7, ref ulong s8, ref ulong s9, ref ulong s10, ref ulong s11);
        static /*0x7e6d95c*/ void memset(void* dst, int value, ulong numberOfBytes);

        struct U
        {
            /*0x10*/ byte* p8;
            /*0x10*/ uint* p32;
            /*0x10*/ ulong* p64;
            /*0x10*/ ulong i;

            /*0x7e6d508*/ U(ushort* p8);
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
        static /*0x7e6e3b4*/ void SetCursor(UnityEngine.Texture2D texture, UnityEngine.Vector2 hotspot, UnityEngine.CursorMode cursorMode);
        static /*0x7e6e4a8*/ UnityEngine.CursorLockMode get_lockState();
        static /*0x7e6e454*/ void SetCursor_Injected(nint texture, ref UnityEngine.Vector2 hotspot, UnityEngine.CursorMode cursorMode);
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
        /*0x3816810*/ void LogException(System.Exception exception, UnityEngine.Object context);
    }

    interface ILogger : UnityEngine.ILogHandler
    {
        /*0x38148bc*/ UnityEngine.ILogHandler get_logHandler();
        /*0x3813ffc*/ bool get_logEnabled();
        /*0x3815ed0*/ void set_filterLogType(UnityEngine.LogType value);
        /*0x38140fc*/ bool IsLogTypeAllowed(UnityEngine.LogType logType);
        /*0x3816044*/ void Log(UnityEngine.LogType logType, object message);
        void Log(UnityEngine.LogType logType, object message, UnityEngine.Object context);
        void Log(UnityEngine.LogType logType, string tag, object message);
        /*0x3816810*/ void Log(string tag, object message);
        /*0x3816810*/ void LogWarning(string tag, object message);
        /*0x3816810*/ void LogError(string tag, object message);
        void LogFormat(UnityEngine.LogType logType, string format, object[] args);
        /*0x3816710*/ void LogException(System.Exception exception);
    }

    class Logger : UnityEngine.ILogger, UnityEngine.ILogHandler
    {
        /*0x10*/ UnityEngine.ILogHandler <logHandler>k__BackingField;
        /*0x18*/ bool <logEnabled>k__BackingField;
        /*0x1c*/ UnityEngine.LogType <filterLogType>k__BackingField;

        static /*0x7e6e580*/ string GetString(object message);
        /*0x7e6e4d0*/ Logger(UnityEngine.ILogHandler logHandler);
        /*0x7e6e514*/ UnityEngine.ILogHandler get_logHandler();
        /*0x7e6e51c*/ void set_logHandler(UnityEngine.ILogHandler value);
        /*0x7e6e524*/ bool get_logEnabled();
        /*0x7e6e52c*/ void set_logEnabled(bool value);
        /*0x7e6e538*/ UnityEngine.LogType get_filterLogType();
        /*0x7e6e540*/ void set_filterLogType(UnityEngine.LogType value);
        /*0x7e6e548*/ bool IsLogTypeAllowed(UnityEngine.LogType logType);
        /*0x7e6e6a0*/ void Log(UnityEngine.LogType logType, object message);
        /*0x7e6e824*/ void Log(UnityEngine.LogType logType, object message, UnityEngine.Object context);
        /*0x7e6e9ac*/ void Log(UnityEngine.LogType logType, string tag, object message);
        /*0x7e6eb68*/ void Log(string tag, object message);
        /*0x7e6ed14*/ void LogWarning(string tag, object message);
        /*0x7e6eec0*/ void LogError(string tag, object message);
        /*0x7e6f068*/ void LogException(System.Exception exception);
        /*0x7e6f12c*/ void LogException(System.Exception exception, UnityEngine.Object context);
        /*0x7e6f200*/ void LogFormat(UnityEngine.LogType logType, string format, object[] args);
        /*0x7e6f2fc*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
    }

    class UnityLogWriter : System.IO.TextWriter
    {
        static /*0x7e6f408*/ void WriteStringToUnityLog(string s);
        static /*0x7e6f414*/ void WriteStringToUnityLogImpl(string s);
        static /*0x7e6f5b8*/ void Init();
        static /*0x7e6f57c*/ void WriteStringToUnityLogImpl_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper s);
        /*0x7e6f674*/ UnityLogWriter();
        /*0x7e6f6cc*/ System.Text.Encoding get_Encoding();
        /*0x7e6f6d4*/ void Write(char value);
        /*0x7e6f710*/ void Write(string s);
        /*0x7e6f720*/ void Write(char[] buffer, int index, int count);
    }

    struct Color : System.IEquatable<UnityEngine.Color>, System.IFormattable
    {
        /*0x10*/ float r;
        /*0x14*/ float g;
        /*0x18*/ float b;
        /*0x1c*/ float a;

        static /*0x7e6fb7c*/ UnityEngine.Color op_Addition(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x7e6fb90*/ UnityEngine.Color op_Subtraction(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x7e6fba4*/ UnityEngine.Color op_Multiply(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x7e6fbb8*/ UnityEngine.Color op_Multiply(UnityEngine.Color a, float b);
        static /*0x7e6fbcc*/ bool op_Equality(UnityEngine.Color lhs, UnityEngine.Color rhs);
        static /*0x7e6fc0c*/ bool op_Inequality(UnityEngine.Color lhs, UnityEngine.Color rhs);
        static /*0x7e6fc4c*/ UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, float t);
        static /*0x7e6fc98*/ UnityEngine.Color LerpUnclamped(UnityEngine.Color a, UnityEngine.Color b, float t);
        static /*0x7e6fcec*/ UnityEngine.Color get_red();
        static /*0x7e6fd00*/ UnityEngine.Color get_green();
        static /*0x7e6fd14*/ UnityEngine.Color get_blue();
        static /*0x7e6fd28*/ UnityEngine.Color get_white();
        static /*0x7e6fd3c*/ UnityEngine.Color get_black();
        static /*0x7e6fd50*/ UnityEngine.Color get_yellow();
        static /*0x7e6fd6c*/ UnityEngine.Color get_magenta();
        static /*0x7e6fd80*/ UnityEngine.Color get_gray();
        static /*0x7e6fd94*/ UnityEngine.Color get_grey();
        static /*0x7e6fda8*/ UnityEngine.Color get_clear();
        static /*0x7e6fe90*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Color c);
        static /*0x7e6fe94*/ UnityEngine.Color op_Implicit(UnityEngine.Vector4 v);
        /*0x7e6f738*/ Color(float r, float g, float b, float a);
        /*0x7e6f744*/ Color(float r, float g, float b);
        /*0x7e6f758*/ string ToString();
        /*0x7e6f768*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x7e6f9a0*/ int GetHashCode();
        /*0x7e6fa28*/ bool Equals(object other);
        /*0x7e6fafc*/ bool Equals(UnityEngine.Color other);
        /*0x7e6fcd0*/ UnityEngine.Color RGBMultiplied(float multiplier);
        /*0x7e6fdbc*/ UnityEngine.Color get_linear();
        /*0x7e6fe18*/ UnityEngine.Color get_gamma();
        /*0x7e6fe74*/ float get_maxColorComponent();
    }

    struct Color32 : System.IEquatable<UnityEngine.Color32>, System.IFormattable
    {
        /*0x10*/ int rgba;
        /*0x10*/ byte r;
        /*0x11*/ byte g;
        /*0x12*/ byte b;
        /*0x13*/ byte a;

        static /*0x7e6feb0*/ UnityEngine.Color32 op_Implicit(UnityEngine.Color c);
        static /*0x7e70174*/ UnityEngine.Color op_Implicit(UnityEngine.Color32 c);
        /*0x7e6fe98*/ Color32(byte r, byte g, byte b, byte a);
        /*0x7e701b0*/ int GetHashCode();
        /*0x7e701b8*/ bool Equals(object other);
        /*0x7e70230*/ bool Equals(UnityEngine.Color32 other);
        /*0x7e70240*/ string ToString();
        /*0x7e70250*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    class ColorUtility
    {
        static /*0x7e7045c*/ bool DoTryParseHtmlColor(string htmlString, ref UnityEngine.Color32 color);
        static /*0x7e7061c*/ bool TryParseHtmlString(string htmlString, ref UnityEngine.Color color);
        static /*0x7e70680*/ string ToHtmlStringRGB(UnityEngine.Color color);
        static /*0x7e705d8*/ bool DoTryParseHtmlColor_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper htmlString, ref UnityEngine.Color32 color);
    }

    struct GradientColorKey
    {
        /*0x10*/ UnityEngine.Color color;
        /*0x20*/ float time;

        /*0x7e70a80*/ GradientColorKey(UnityEngine.Color col, float time);
    }

    struct GradientAlphaKey
    {
        /*0x10*/ float alpha;
        /*0x14*/ float time;

        /*0x7e70a90*/ GradientAlphaKey(float alpha, float time);
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

        static /*0x7e70a98*/ nint Init();
        static /*0x7e70b10*/ void Cleanup_Injected(nint _unity_self);
        static /*0x7e70ba4*/ bool Internal_Equals_Injected(nint _unity_self, nint other);
        static /*0x7e70d80*/ void Evaluate_Injected(nint _unity_self, float time, ref UnityEngine.Color ret);
        static /*0x7e70ef0*/ void get_colorKeys_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e71050*/ void get_alphaKeys_Injected(nint _unity_self, ref UnityEngine.Bindings.BlittableArrayWrapper ret);
        static /*0x7e710e4*/ UnityEngine.GradientMode get_mode_Injected(nint _unity_self);
        static /*0x7e71178*/ void set_mode_Injected(nint _unity_self, UnityEngine.GradientMode value);
        static /*0x7e7120c*/ UnityEngine.ColorSpace get_colorSpace_Injected(nint _unity_self);
        static /*0x7e712a0*/ void set_colorSpace_Injected(nint _unity_self, UnityEngine.ColorSpace value);
        static /*0x7e71454*/ void SetKeys_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colorKeys, ref UnityEngine.Bindings.ManagedSpanWrapper alphaKeys);
        /*0x7e70be8*/ Gradient();
        /*0x7e70c38*/ Gradient(nint ptr);
        /*0x7e70ac0*/ void Cleanup();
        /*0x7e70b4c*/ bool Internal_Equals(nint other);
        /*0x7e70c64*/ void Finalize();
        /*0x7e70d04*/ UnityEngine.Color Evaluate(float time);
        /*0x7e70dd4*/ UnityEngine.GradientColorKey[] get_colorKeys();
        /*0x7e70f34*/ UnityEngine.GradientAlphaKey[] get_alphaKeys();
        /*0x7e71094*/ UnityEngine.GradientMode get_mode();
        /*0x7e71120*/ void set_mode(UnityEngine.GradientMode value);
        /*0x7e711bc*/ UnityEngine.ColorSpace get_colorSpace();
        /*0x7e71248*/ void set_colorSpace(UnityEngine.ColorSpace value);
        /*0x7e712e4*/ void SetKeys(UnityEngine.GradientColorKey[] colorKeys, UnityEngine.GradientAlphaKey[] alphaKeys);
        /*0x7e714a8*/ bool Equals(object o);
        /*0x7e715a8*/ bool Equals(UnityEngine.Gradient other);
        /*0x7e7162c*/ int GetHashCode();

        class BindingsMarshaller
        {
            static /*0x7e71638*/ nint ConvertToNative(UnityEngine.Gradient graident);
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

        static /*0x7e7350c*/ Matrix4x4();
        static /*0x7e718b4*/ UnityEngine.Matrix4x4 TRS(UnityEngine.Vector3 pos, UnityEngine.Quaternion q, UnityEngine.Vector3 s);
        static /*0x7e719a0*/ bool Inverse3DAffine(UnityEngine.Matrix4x4 input, ref UnityEngine.Matrix4x4 result);
        static /*0x7e71a28*/ UnityEngine.Matrix4x4 Inverse(UnityEngine.Matrix4x4 m);
        static /*0x7e71b60*/ UnityEngine.Matrix4x4 Transpose(UnityEngine.Matrix4x4 m);
        static /*0x7e71c98*/ UnityEngine.Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar);
        static /*0x7e71dc8*/ UnityEngine.Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar);
        static /*0x7e71ec8*/ UnityEngine.Matrix4x4 LookAt(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 up);
        static /*0x7e71fb4*/ UnityEngine.Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar);
        static /*0x7e720e4*/ UnityEngine.Matrix4x4 Frustum(UnityEngine.FrustumPlanes fp);
        static /*0x7e7289c*/ UnityEngine.Matrix4x4 op_Multiply(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs);
        static /*0x7e72994*/ UnityEngine.Vector4 op_Multiply(UnityEngine.Matrix4x4 lhs, UnityEngine.Vector4 vector);
        static /*0x7e729c8*/ bool op_Equality(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs);
        static /*0x7e72d8c*/ UnityEngine.Matrix4x4 Scale(UnityEngine.Vector3 vector);
        static /*0x7e72db8*/ UnityEngine.Matrix4x4 Translate(UnityEngine.Vector3 vector);
        static /*0x7e72dec*/ UnityEngine.Matrix4x4 Rotate(UnityEngine.Quaternion q);
        static /*0x7e72e84*/ UnityEngine.Matrix4x4 get_zero();
        static /*0x7e72edc*/ UnityEngine.Matrix4x4 get_identity();
        static /*0x7e716a8*/ void GetRotation_Injected(ref UnityEngine.Matrix4x4 _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7e71748*/ void GetLossyScale_Injected(ref UnityEngine.Matrix4x4 _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e717f4*/ void DecomposeProjection_Injected(ref UnityEngine.Matrix4x4 _unity_self, ref UnityEngine.FrustumPlanes ret);
        static /*0x7e71944*/ void TRS_Injected(ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion q, ref UnityEngine.Vector3 s, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e719e4*/ bool Inverse3DAffine_Injected(ref UnityEngine.Matrix4x4 input, ref UnityEngine.Matrix4x4 result);
        static /*0x7e71a94*/ void Inverse_Injected(ref UnityEngine.Matrix4x4 m, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e71bcc*/ void Transpose_Injected(ref UnityEngine.Matrix4x4 m, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e71d44*/ void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e71e5c*/ void Perspective_Injected(float fov, float aspect, float zNear, float zFar, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e71f58*/ void LookAt_Injected(ref UnityEngine.Vector3 from, ref UnityEngine.Vector3 to, ref UnityEngine.Vector3 up, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e72060*/ void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, ref UnityEngine.Matrix4x4 ret);
        /*0x7e72194*/ Matrix4x4(UnityEngine.Vector4 column0, UnityEngine.Vector4 column1, UnityEngine.Vector4 column2, UnityEngine.Vector4 column3);
        /*0x7e71650*/ UnityEngine.Quaternion GetRotation();
        /*0x7e716ec*/ UnityEngine.Vector3 GetLossyScale();
        /*0x7e7178c*/ UnityEngine.FrustumPlanes DecomposeProjection();
        /*0x7e71838*/ UnityEngine.Quaternion get_rotation();
        /*0x7e7183c*/ UnityEngine.Vector3 get_lossyScale();
        /*0x7e71840*/ UnityEngine.FrustumPlanes get_decomposeProjection();
        /*0x7e71ad8*/ UnityEngine.Matrix4x4 get_inverse();
        /*0x7e71c10*/ UnityEngine.Matrix4x4 get_transpose();
        /*0x7e721b0*/ float get_Item(int row, int column);
        /*0x7e722a8*/ void set_Item(int row, int column, float value);
        /*0x7e721b8*/ float get_Item(int index);
        /*0x7e722b0*/ void set_Item(int index, float value);
        /*0x7e723a0*/ int GetHashCode();
        /*0x7e72620*/ bool Equals(object other);
        /*0x7e72794*/ bool Equals(UnityEngine.Matrix4x4 other);
        /*0x7e7254c*/ UnityEngine.Vector4 GetColumn(int index);
        /*0x7e72aac*/ UnityEngine.Vector4 GetRow(int index);
        /*0x7e72b80*/ UnityEngine.Vector3 GetPosition();
        /*0x7e72b8c*/ void SetColumn(int index, UnityEngine.Vector4 column);
        /*0x7e72c04*/ void SetRow(int index, UnityEngine.Vector4 row);
        /*0x7e72c6c*/ UnityEngine.Vector3 MultiplyPoint(UnityEngine.Vector3 point);
        /*0x7e72cec*/ UnityEngine.Vector3 MultiplyPoint3x4(UnityEngine.Vector3 point);
        /*0x7e72d44*/ UnityEngine.Vector3 MultiplyVector(UnityEngine.Vector3 vector);
        /*0x7e72f34*/ string ToString();
        /*0x7e72f44*/ string ToString(string format, System.IFormatProvider formatProvider);
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

        static /*0x7e757f0*/ Vector3();
        static /*0x7e74328*/ UnityEngine.Vector3 Slerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, float t);
        static /*0x7e74400*/ UnityEngine.Vector3 Lerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, float t);
        static /*0x7e7443c*/ UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3 a, UnityEngine.Vector3 b, float t);
        static /*0x7e74464*/ UnityEngine.Vector3 SmoothDamp(UnityEngine.Vector3 current, UnityEngine.Vector3 target, ref UnityEngine.Vector3 currentVelocity, float smoothTime, float maxSpeed, float deltaTime);
        static /*0x7e747c8*/ UnityEngine.Vector3 Cross(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x7e74900*/ UnityEngine.Vector3 Normalize(UnityEngine.Vector3 value);
        static /*0x7e74b84*/ float Dot(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x7e74b9c*/ UnityEngine.Vector3 Project(UnityEngine.Vector3 vector, UnityEngine.Vector3 onNormal);
        static /*0x7e74c98*/ UnityEngine.Vector3 ProjectOnPlane(UnityEngine.Vector3 vector, UnityEngine.Vector3 planeNormal);
        static /*0x7e74d70*/ float Angle(UnityEngine.Vector3 from, UnityEngine.Vector3 to);
        static /*0x7e74e8c*/ float SignedAngle(UnityEngine.Vector3 from, UnityEngine.Vector3 to, UnityEngine.Vector3 axis);
        static /*0x7e75004*/ float Distance(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x7e750a4*/ UnityEngine.Vector3 ClampMagnitude(UnityEngine.Vector3 vector, float maxLength);
        static /*0x7e75158*/ float Magnitude(UnityEngine.Vector3 vector);
        static /*0x7e75258*/ float SqrMagnitude(UnityEngine.Vector3 vector);
        static /*0x7e75290*/ UnityEngine.Vector3 Min(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x7e752ac*/ UnityEngine.Vector3 Max(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x7e752c8*/ UnityEngine.Vector3 get_zero();
        static /*0x7e75314*/ UnityEngine.Vector3 get_one();
        static /*0x7e75360*/ UnityEngine.Vector3 get_forward();
        static /*0x7e753ac*/ UnityEngine.Vector3 get_back();
        static /*0x7e753f8*/ UnityEngine.Vector3 get_up();
        static /*0x7e75444*/ UnityEngine.Vector3 get_down();
        static /*0x7e75490*/ UnityEngine.Vector3 get_left();
        static /*0x7e754dc*/ UnityEngine.Vector3 get_right();
        static /*0x7e75528*/ UnityEngine.Vector3 op_Addition(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x7e75538*/ UnityEngine.Vector3 op_Subtraction(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x7e75548*/ UnityEngine.Vector3 op_UnaryNegation(UnityEngine.Vector3 a);
        static /*0x7e75558*/ UnityEngine.Vector3 op_Multiply(UnityEngine.Vector3 a, float d);
        static /*0x7e75568*/ UnityEngine.Vector3 op_Multiply(float d, UnityEngine.Vector3 a);
        static /*0x7e7557c*/ UnityEngine.Vector3 op_Division(UnityEngine.Vector3 a, float d);
        static /*0x7e7558c*/ bool op_Equality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x7e755c0*/ bool op_Inequality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x7e7439c*/ void Slerp_Injected(ref UnityEngine.Vector3 a, ref UnityEngine.Vector3 b, float t, ref UnityEngine.Vector3 ret);
        /*0x7e74790*/ Vector3(float x, float y, float z);
        /*0x7e7479c*/ Vector3(float x, float y);
        /*0x7e746a0*/ float get_Item(int index);
        /*0x7e74718*/ void set_Item(int index, float value);
        /*0x7e747a8*/ void Scale(UnityEngine.Vector3 scale);
        /*0x7e747f0*/ int GetHashCode();
        /*0x7e74838*/ bool Equals(object other);
        /*0x7e748d0*/ bool Equals(UnityEngine.Vector3 other);
        /*0x7e749d0*/ void Normalize();
        /*0x7e74ab8*/ UnityEngine.Vector3 get_normalized();
        /*0x7e751d8*/ float get_magnitude();
        /*0x7e75270*/ float get_sqrMagnitude();
        /*0x7e755f4*/ string ToString();
        /*0x7e75604*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Quaternion : System.IEquatable<UnityEngine.Quaternion>, System.IFormattable
    {
        static float kEpsilon = 9.999999974752427e-7;
        static /*0x0*/ UnityEngine.Quaternion identityQuaternion;
        /*0x10*/ float x;
        /*0x14*/ float y;
        /*0x18*/ float z;
        /*0x1c*/ float w;

        static /*0x7e768c0*/ Quaternion();
        static /*0x7e758ec*/ UnityEngine.Quaternion FromToRotation(UnityEngine.Vector3 fromDirection, UnityEngine.Vector3 toDirection);
        static /*0x7e759a0*/ UnityEngine.Quaternion Inverse(UnityEngine.Quaternion rotation);
        static /*0x7e75a38*/ UnityEngine.Quaternion Slerp(UnityEngine.Quaternion a, UnityEngine.Quaternion b, float t);
        static /*0x7e75b0c*/ UnityEngine.Quaternion SlerpUnclamped(UnityEngine.Quaternion a, UnityEngine.Quaternion b, float t);
        static /*0x7e75be0*/ UnityEngine.Quaternion Internal_FromEulerRad(UnityEngine.Vector3 euler);
        static /*0x7e75c78*/ UnityEngine.Vector3 Internal_ToEulerRad(UnityEngine.Quaternion rotation);
        static /*0x7e75d14*/ void Internal_ToAxisAngleRad(UnityEngine.Quaternion q, ref UnityEngine.Vector3 axis, ref float angle);
        static /*0x7e75dc4*/ UnityEngine.Quaternion AngleAxis(float angle, UnityEngine.Vector3 axis);
        static /*0x7e75e7c*/ UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 forward, UnityEngine.Vector3 upwards);
        static /*0x7e75f30*/ UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 forward);
        static /*0x7e75fa8*/ UnityEngine.Quaternion get_identity();
        static /*0x7e75ff4*/ UnityEngine.Quaternion op_Multiply(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x7e76068*/ UnityEngine.Vector3 op_Multiply(UnityEngine.Quaternion rotation, UnityEngine.Vector3 point);
        static /*0x7e7610c*/ bool IsEqualUsingDot(float dot);
        static /*0x7e76120*/ bool op_Equality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x7e76150*/ bool op_Inequality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x7e76180*/ float Dot(UnityEngine.Quaternion a, UnityEngine.Quaternion b);
        static /*0x7e761a0*/ float Angle(UnityEngine.Quaternion a, UnityEngine.Quaternion b);
        static /*0x7e76200*/ UnityEngine.Vector3 Internal_MakePositive(UnityEngine.Vector3 euler);
        static /*0x7e762b4*/ UnityEngine.Quaternion Euler(float x, float y, float z);
        static /*0x7e762cc*/ UnityEngine.Quaternion Euler(UnityEngine.Vector3 euler);
        static /*0x7e76318*/ UnityEngine.Quaternion Normalize(UnityEngine.Quaternion q);
        static /*0x7e7594c*/ void FromToRotation_Injected(ref UnityEngine.Vector3 fromDirection, ref UnityEngine.Vector3 toDirection, ref UnityEngine.Quaternion ret);
        static /*0x7e759f4*/ void Inverse_Injected(ref UnityEngine.Quaternion rotation, ref UnityEngine.Quaternion ret);
        static /*0x7e75aa8*/ void Slerp_Injected(ref UnityEngine.Quaternion a, ref UnityEngine.Quaternion b, float t, ref UnityEngine.Quaternion ret);
        static /*0x7e75b7c*/ void SlerpUnclamped_Injected(ref UnityEngine.Quaternion a, ref UnityEngine.Quaternion b, float t, ref UnityEngine.Quaternion ret);
        static /*0x7e75c34*/ void Internal_FromEulerRad_Injected(ref UnityEngine.Vector3 euler, ref UnityEngine.Quaternion ret);
        static /*0x7e75cd0*/ void Internal_ToEulerRad_Injected(ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 ret);
        static /*0x7e75d70*/ void Internal_ToAxisAngleRad_Injected(ref UnityEngine.Quaternion q, ref UnityEngine.Vector3 axis, ref float angle);
        static /*0x7e75e28*/ void AngleAxis_Injected(float angle, ref UnityEngine.Vector3 axis, ref UnityEngine.Quaternion ret);
        static /*0x7e75edc*/ void LookRotation_Injected(ref UnityEngine.Vector3 forward, ref UnityEngine.Vector3 upwards, ref UnityEngine.Quaternion ret);
        /*0x7e75f9c*/ Quaternion(float x, float y, float z, float w);
        /*0x7e76288*/ UnityEngine.Vector3 get_eulerAngles();
        /*0x7e762e4*/ void ToAngleAxis(ref float angle, ref UnityEngine.Vector3 axis);
        /*0x7e763f4*/ UnityEngine.Quaternion get_normalized();
        /*0x7e764c0*/ int GetHashCode();
        /*0x7e76524*/ bool Equals(object other);
        /*0x7e765f8*/ bool Equals(UnityEngine.Quaternion other);
        /*0x7e76678*/ string ToString();
        /*0x7e76688*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Mathf
    {
        static /*0x0*/ float Epsilon;

        static /*0x7e77a80*/ Mathf();
        static /*0x7e76910*/ float GammaToLinearSpace(float value);
        static /*0x7e76948*/ float LinearToGammaSpace(float value);
        static /*0x7e76980*/ UnityEngine.Color CorrelatedColorTemperatureToRGB(float kelvin);
        static /*0x7e76a24*/ ushort FloatToHalf(float val);
        static /*0x7e76a5c*/ float PerlinNoise(float x, float y);
        static /*0x7e76a9c*/ float Sin(float f);
        static /*0x7e76b00*/ float Cos(float f);
        static /*0x7e76b64*/ float Tan(float f);
        static /*0x7e76bc8*/ float Asin(float f);
        static /*0x7e76c2c*/ float Acos(float f);
        static /*0x7e76c90*/ float Atan(float f);
        static /*0x7e76cf4*/ float Atan2(float y, float x);
        static /*0x7e76d60*/ float Sqrt(float f);
        static /*0x7e76dbc*/ float Abs(float f);
        static /*0x7e76e18*/ int Abs(int value);
        static /*0x7e76e70*/ float Min(float a, float b);
        static /*0x7e76e7c*/ float Min(float[] values);
        static /*0x7e76ecc*/ int Min(int a, int b);
        static /*0x7e76ed8*/ float Max(float a, float b);
        static /*0x7e76ee4*/ int Max(int a, int b);
        static /*0x7e76ef0*/ float Pow(float f, float p);
        static /*0x7e76f60*/ float Exp(float power);
        static /*0x7e76fc4*/ float Log(float f, float p);
        static /*0x7e77034*/ float Log(float f);
        static /*0x7e77098*/ float Log10(float f);
        static /*0x7e770fc*/ float Ceil(float f);
        static /*0x7e77158*/ float Floor(float f);
        static /*0x7e771b4*/ float Round(float f);
        static /*0x7e7727c*/ int CeilToInt(float f);
        static /*0x7e772f0*/ int FloorToInt(float f);
        static /*0x7e77364*/ int RoundToInt(float f);
        static /*0x7e77440*/ float Sign(float f);
        static /*0x7e77454*/ float Clamp(float value, float min, float max);
        static /*0x7e77470*/ int Clamp(int value, int min, int max);
        static /*0x7e7748c*/ float Clamp01(float value);
        static /*0x7e774a8*/ float Lerp(float a, float b, float t);
        static /*0x7e774cc*/ float LerpUnclamped(float a, float b, float t);
        static /*0x7e774dc*/ float LerpAngle(float a, float b, float t);
        static /*0x7e77540*/ bool Approximately(float a, float b);
        static /*0x7e775d0*/ float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime);
        static /*0x7e7769c*/ float Repeat(float t, float length);
        static /*0x7e776c4*/ float InverseLerp(float a, float b, float value);
        static /*0x7e776f4*/ float ClampToFloat(double value);
        static /*0x7e77760*/ int ClampToInt(long value);
        static /*0x7e77788*/ uint ClampToUInt(long value);
        static /*0x7e777a4*/ int GetNumberOfDecimalsForMinimumDifference(double minDifference);
        static /*0x7e77830*/ double RoundBasedOnMinimumDifference(double valueToRound, double minDifference);
        static /*0x7e778bc*/ double DiscardLeastSignificantDecimal(double v);
        static /*0x7e77a1c*/ int NextPowerOfTwo(int value);
        static /*0x7e77a3c*/ int ClosestPowerOfTwo(int value);
        static /*0x7e77a70*/ bool IsPowerOfTwo(int value);
        static /*0x7e769d8*/ void CorrelatedColorTemperatureToRGB_Injected(float kelvin, ref UnityEngine.Color ret);
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

        static /*0x7e78658*/ Vector2();
        static /*0x7e77c14*/ UnityEngine.Vector2 Lerp(UnityEngine.Vector2 a, UnityEngine.Vector2 b, float t);
        static /*0x7e77c44*/ UnityEngine.Vector2 LerpUnclamped(UnityEngine.Vector2 a, UnityEngine.Vector2 b, float t);
        static /*0x7e77c60*/ UnityEngine.Vector2 Scale(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x7e78084*/ float Dot(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x7e78114*/ float Angle(UnityEngine.Vector2 from, UnityEngine.Vector2 to);
        static /*0x7e78208*/ float Distance(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x7e7828c*/ UnityEngine.Vector2 ClampMagnitude(UnityEngine.Vector2 vector, float maxLength);
        static /*0x7e78320*/ float SqrMagnitude(UnityEngine.Vector2 a);
        static /*0x7e78330*/ UnityEngine.Vector2 Min(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x7e78344*/ UnityEngine.Vector2 Max(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x7e78358*/ UnityEngine.Vector2 op_Addition(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x7e78364*/ UnityEngine.Vector2 op_Subtraction(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x7e78370*/ UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x7e7837c*/ UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x7e78388*/ UnityEngine.Vector2 op_UnaryNegation(UnityEngine.Vector2 a);
        static /*0x7e78394*/ UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, float d);
        static /*0x7e783a0*/ UnityEngine.Vector2 op_Multiply(float d, UnityEngine.Vector2 a);
        static /*0x7e783b0*/ UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, float d);
        static /*0x7e783bc*/ bool op_Equality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x7e783e4*/ bool op_Inequality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x7e7840c*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector3 v);
        static /*0x7e78410*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector2 v);
        static /*0x7e78418*/ UnityEngine.Vector2 get_zero();
        static /*0x7e78460*/ UnityEngine.Vector2 get_one();
        static /*0x7e784a8*/ UnityEngine.Vector2 get_up();
        static /*0x7e784f0*/ UnityEngine.Vector2 get_down();
        static /*0x7e78538*/ UnityEngine.Vector2 get_left();
        static /*0x7e78580*/ UnityEngine.Vector2 get_right();
        static /*0x7e785c8*/ UnityEngine.Vector2 get_positiveInfinity();
        static /*0x7e78610*/ UnityEngine.Vector2 get_negativeInfinity();
        /*0x7e77c0c*/ Vector2(float x, float y);
        /*0x7e77b3c*/ float get_Item(int index);
        /*0x7e77ba4*/ void set_Item(int index, float value);
        /*0x7e77c6c*/ void Scale(UnityEngine.Vector2 scale);
        /*0x7e77c80*/ void Normalize();
        /*0x7e77d44*/ UnityEngine.Vector2 get_normalized();
        /*0x7e77df4*/ string ToString();
        /*0x7e77e04*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x7e77fa4*/ int GetHashCode();
        /*0x7e77fd8*/ bool Equals(object other);
        /*0x7e78060*/ bool Equals(UnityEngine.Vector2 other);
        /*0x7e78094*/ float get_magnitude();
        /*0x7e78100*/ float get_sqrMagnitude();
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

        static /*0x7e78bd0*/ Vector2Int();
        static /*0x7e7874c*/ UnityEngine.Vector2Int Max(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs);
        static /*0x7e7876c*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector2Int v);
        static /*0x7e7877c*/ UnityEngine.Vector2Int FloorToInt(UnityEngine.Vector2 v);
        static /*0x7e78844*/ UnityEngine.Vector2Int op_Addition(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b);
        static /*0x7e7885c*/ UnityEngine.Vector2Int op_Multiply(int a, UnityEngine.Vector2Int b);
        static /*0x7e78874*/ UnityEngine.Vector2Int op_Division(UnityEngine.Vector2Int a, int b);
        static /*0x7e78888*/ bool op_Equality(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs);
        static /*0x7e788a8*/ bool op_Inequality(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs);
        static /*0x7e78b40*/ UnityEngine.Vector2Int get_zero();
        static /*0x7e78b88*/ UnityEngine.Vector2Int get_one();
        /*0x7e7872c*/ Vector2Int(int x, int y);
        /*0x7e7870c*/ int get_x();
        /*0x7e78714*/ void set_x(int value);
        /*0x7e7871c*/ int get_y();
        /*0x7e78724*/ void set_y(int value);
        /*0x7e78734*/ float get_magnitude();
        /*0x7e788c8*/ bool Equals(object other);
        /*0x7e78950*/ bool Equals(UnityEngine.Vector2Int other);
        /*0x7e78978*/ int GetHashCode();
        /*0x7e7899c*/ string ToString();
        /*0x7e789ac*/ string ToString(string format, System.IFormatProvider formatProvider);
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

        static /*0x7e79178*/ Vector3Int();
        static /*0x7e78c94*/ UnityEngine.Vector3Int Min(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs);
        static /*0x7e78cc0*/ UnityEngine.Vector3Int Max(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs);
        static /*0x7e78cec*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector3Int v);
        static /*0x7e78d00*/ UnityEngine.Vector3Int op_Addition(UnityEngine.Vector3Int a, UnityEngine.Vector3Int b);
        static /*0x7e78d1c*/ UnityEngine.Vector3Int op_Subtraction(UnityEngine.Vector3Int a, UnityEngine.Vector3Int b);
        static /*0x7e78d38*/ UnityEngine.Vector3Int op_Multiply(UnityEngine.Vector3Int a, int b);
        static /*0x7e78d50*/ UnityEngine.Vector3Int op_Division(UnityEngine.Vector3Int a, int b);
        static /*0x7e78d68*/ bool op_Equality(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs);
        static /*0x7e790e0*/ UnityEngine.Vector3Int get_zero();
        static /*0x7e7912c*/ UnityEngine.Vector3Int get_one();
        /*0x7e78c88*/ Vector3Int(int x, int y, int z);
        /*0x7e78c58*/ int get_x();
        /*0x7e78c60*/ void set_x(int value);
        /*0x7e78c68*/ int get_y();
        /*0x7e78c70*/ void set_y(int value);
        /*0x7e78c78*/ int get_z();
        /*0x7e78c80*/ void set_z(int value);
        /*0x7e78d98*/ bool Equals(object other);
        /*0x7e78e34*/ bool Equals(UnityEngine.Vector3Int other);
        /*0x7e78e6c*/ int GetHashCode();
        /*0x7e78ee8*/ string ToString();
        /*0x7e78ef8*/ string ToString(string format, System.IFormatProvider formatProvider);
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

        static /*0x7e79c54*/ Vector4();
        static /*0x7e79398*/ UnityEngine.Vector4 Lerp(UnityEngine.Vector4 a, UnityEngine.Vector4 b, float t);
        static /*0x7e79548*/ UnityEngine.Vector4 Normalize(UnityEngine.Vector4 a);
        static /*0x7e79700*/ float Dot(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x7e79720*/ float Magnitude(UnityEngine.Vector4 a);
        static /*0x7e7985c*/ UnityEngine.Vector4 get_zero();
        static /*0x7e798a8*/ UnityEngine.Vector4 get_one();
        static /*0x7e798f4*/ UnityEngine.Vector4 op_Addition(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x7e79908*/ UnityEngine.Vector4 op_Subtraction(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x7e7991c*/ UnityEngine.Vector4 op_UnaryNegation(UnityEngine.Vector4 a);
        static /*0x7e79930*/ UnityEngine.Vector4 op_Multiply(UnityEngine.Vector4 a, float d);
        static /*0x7e79944*/ UnityEngine.Vector4 op_Multiply(float d, UnityEngine.Vector4 a);
        static /*0x7e7995c*/ UnityEngine.Vector4 op_Division(UnityEngine.Vector4 a, float d);
        static /*0x7e79970*/ bool op_Equality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs);
        static /*0x7e799b0*/ bool op_Inequality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs);
        static /*0x7e799f0*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Vector3 v);
        static /*0x7e799f8*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector4 v);
        static /*0x7e799fc*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Vector2 v);
        static /*0x7e79a08*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector4 v);
        /*0x7e79364*/ Vector4(float x, float y, float z, float w);
        /*0x7e79370*/ Vector4(float x, float y, float z);
        /*0x7e79380*/ Vector4(float x, float y);
        /*0x7e79244*/ float get_Item(int index);
        /*0x7e792d4*/ void set_Item(int index, float value);
        /*0x7e7938c*/ void Set(float newX, float newY, float newZ, float newW);
        /*0x7e793e4*/ void Scale(UnityEngine.Vector4 scale);
        /*0x7e79400*/ int GetHashCode();
        /*0x7e79464*/ bool Equals(object other);
        /*0x7e7950c*/ bool Equals(UnityEngine.Vector4 other);
        /*0x7e79628*/ UnityEngine.Vector4 get_normalized();
        /*0x7e797ac*/ float get_magnitude();
        /*0x7e79834*/ float get_sqrMagnitude();
        /*0x7e79a0c*/ string ToString();
        /*0x7e79a1c*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct TypeDispatchData : System.IDisposable
    {
        /*0x10*/ UnityEngine.Object[] changed;
        /*0x18*/ Unity.Collections.NativeArray<int> changedID;
        /*0x28*/ Unity.Collections.NativeArray<int> destroyedID;

        /*0x7e79cc8*/ void Dispose();
    }

    struct TransformDispatchData : System.IDisposable
    {
        /*0x10*/ Unity.Collections.NativeArray<int> transformedID;
        /*0x20*/ Unity.Collections.NativeArray<int> parentID;
        /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Matrix4x4> localToWorldMatrices;
        /*0x40*/ Unity.Collections.NativeArray<UnityEngine.Vector3> positions;
        /*0x50*/ Unity.Collections.NativeArray<UnityEngine.Quaternion> rotations;
        /*0x60*/ Unity.Collections.NativeArray<UnityEngine.Vector3> scales;

        /*0x7e79d30*/ void Dispose();
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

        static /*0x7e7ab50*/ ObjectDispatcher();
        static /*0x7e79fa8*/ nint CreateDispatchSystemHandle();
        static /*0x7e7a150*/ void DestroyDispatchSystemHandle(nint ptr);
        static /*0x7e7a9a8*/ void EnableTypeTracking(nint ptr, System.Type type, UnityEngine.ObjectDispatcher.TypeTrackingFlags typeTrackingMask);
        static /*0x7e7aafc*/ void EnableTransformTracking(nint ptr, System.Type type, UnityEngine.ObjectDispatcher.TransformTrackingType trackingType);
        static /*0x7e7a688*/ void DispatchTypeChangesAndClear(nint ptr, System.Type type, System.Action<UnityEngine.Object[], nint, nint, int, int, System.Action<UnityEngine.TypeDispatchData>> callback, bool sortByInstanceID, bool noScriptingArray, System.Action<UnityEngine.TypeDispatchData> param);
        static /*0x7e7a7bc*/ void DispatchTransformDataChangesAndClear(nint ptr, System.Type type, UnityEngine.ObjectDispatcher.TransformTrackingType trackingType, System.Action<nint, nint, nint, nint, nint, nint, int, System.Action<UnityEngine.TransformDispatchData>> callback, System.Action<UnityEngine.TransformDispatchData> param);
        /*0x7e79e10*/ ObjectDispatcher();
        /*0x7e79e00*/ bool get_valid();
        /*0x7e79fd0*/ void Finalize();
        /*0x7e7a0ec*/ void Dispose();
        /*0x7e7a068*/ void Dispose(bool disposing);
        /*0x7e7a18c*/ void ValidateSystemHandleAndThrow();
        /*0x7e7a1e8*/ void ValidateTypeAndThrow(System.Type type);
        /*0x7e7a2bc*/ void ValidateComponentTypeAndThrow(System.Type type);
        /*0x7e7a390*/ void DispatchCallback(UnityEngine.TypeDispatchData data);
        /*0x7e7a444*/ void DispatchCallback(UnityEngine.TransformDispatchData data);
        /*0x7e7a5b8*/ void DispatchCallback(UnityEngine.Component[] components);
        /*0x7e7a5c0*/ void DispatchTypeChangesAndClear(System.Type type, System.Action<UnityEngine.TypeDispatchData> callback, bool sortByInstanceID, bool noScriptingArray);
        /*0x7e7a6fc*/ void DispatchTransformChangesAndClear(System.Type type, UnityEngine.ObjectDispatcher.TransformTrackingType trackingType, System.Action<UnityEngine.TransformDispatchData> callback);
        /*0x7e7a828*/ UnityEngine.TypeDispatchData GetTypeChangesAndClear(System.Type type, Unity.Collections.Allocator allocator, bool sortByInstanceID, bool noScriptingArray);
        /*0x7e7a86c*/ UnityEngine.TransformDispatchData GetTransformChangesAndClear(System.Type type, UnityEngine.ObjectDispatcher.TransformTrackingType trackingType, Unity.Collections.Allocator allocator);
        /*0x7e7a8a8*/ void EnableTypeTracking(UnityEngine.ObjectDispatcher.TypeTrackingFlags typeTrackingMask, System.Type[] types);
        /*0x7e7a9fc*/ void EnableTransformTracking(UnityEngine.ObjectDispatcher.TransformTrackingType trackingType, System.Type[] types);
        /*0x3910ae8*/ UnityEngine.TypeDispatchData GetTypeChangesAndClear<T>(Unity.Collections.Allocator allocator, bool sortByInstanceID, bool noScriptingArray);
        /*0x3910ae8*/ UnityEngine.TransformDispatchData GetTransformChangesAndClear<T>(UnityEngine.ObjectDispatcher.TransformTrackingType trackingType, Unity.Collections.Allocator allocator);
        /*0x3815ed0*/ void EnableTypeTracking<T>(UnityEngine.ObjectDispatcher.TypeTrackingFlags typeTrackingMask);
        /*0x3815ed0*/ void EnableTransformTracking<T>(UnityEngine.ObjectDispatcher.TransformTrackingType trackingType);

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

            static /*0x7e7ac8c*/ <>c();
            /*0x7e7acf4*/ <>c();
            /*0x7e7acfc*/ void <.cctor>b__64_0(UnityEngine.Object[] changed, nint changedID, nint destroyedID, int changedCount, int destroyedCount, System.Action<UnityEngine.TypeDispatchData> callback);
            /*0x7e7ae10*/ void <.cctor>b__64_1(nint transformed, nint parents, nint localToWorldMatrices, nint positions, nint rotations, nint scales, int count, System.Action<UnityEngine.TransformDispatchData> callback);
        }
    }

    class NumericFieldDraggerUtility
    {
        static /*0x0*/ bool s_UseYSign;

        static /*0x7e7afc4*/ float Acceleration(bool shiftPressed, bool altPressed);
        static /*0x7e7afe8*/ float NiceDelta(UnityEngine.Vector2 deviceDelta, float acceleration);
        static /*0x7e7b140*/ double CalculateFloatDragSensitivity(double value);
        static /*0x7e7b1d0*/ double CalculateFloatDragSensitivity(double value, double minValue, double maxValue);
        static /*0x7e7b260*/ long CalculateIntDragSensitivity(long value);
        static /*0x7e7b308*/ ulong CalculateIntDragSensitivity(ulong value);
        static /*0x7e7b28c*/ double CalculateIntDragSensitivity(double value);
        static /*0x7e7b32c*/ long CalculateIntDragSensitivity(long value, long minValue, long maxValue);
    }

    interface IPlayerEditorConnectionNative
    {
        /*0x38159dc*/ void Initialize();
        /*0x38159dc*/ void DisconnectAll();
        void SendMessage(System.Guid messageId, byte[] data, int playerId);
        bool TrySendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x38159dc*/ void Poll();
        void RegisterInternal(System.Guid messageId);
        void UnregisterInternal(System.Guid messageId);
        /*0x3813ffc*/ bool IsConnected();
    }

    class PlayerConnectionInternal : UnityEngine.IPlayerEditorConnectionNative
    {
        static /*0x7e7be1c*/ bool IsConnected();
        static /*0x7e7bdcc*/ void Initialize();
        static /*0x7e7ba78*/ void RegisterInternal(string messageId);
        static /*0x7e7bc3c*/ void UnregisterInternal(string messageId);
        static /*0x7e7b4cc*/ void SendMessage(string messageId, byte[] data, int playerId);
        static /*0x7e7b7c8*/ bool TrySendMessage(string messageId, byte[] data, int playerId);
        static /*0x7e7b9f4*/ void PollInternal();
        static /*0x7e7be6c*/ void DisconnectAll();
        static /*0x7e7be94*/ void RegisterInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper messageId);
        static /*0x7e7bed0*/ void UnregisterInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper messageId);
        static /*0x7e7bf0c*/ void SendMessage_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper messageId, ref UnityEngine.Bindings.ManagedSpanWrapper data, int playerId);
        static /*0x7e7bf60*/ bool TrySendMessage_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper messageId, ref UnityEngine.Bindings.ManagedSpanWrapper data, int playerId);
        /*0x7e7bfb4*/ PlayerConnectionInternal();
        /*0x7e7b3cc*/ void UnityEngine.IPlayerEditorConnectionNative.SendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x7e7b6c4*/ bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x7e7b9cc*/ void UnityEngine.IPlayerEditorConnectionNative.Poll();
        /*0x7e7ba1c*/ void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(System.Guid messageId);
        /*0x7e7bbe0*/ void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(System.Guid messageId);
        /*0x7e7bda4*/ void UnityEngine.IPlayerEditorConnectionNative.Initialize();
        /*0x7e7bdf4*/ bool UnityEngine.IPlayerEditorConnectionNative.IsConnected();
        /*0x7e7be44*/ void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll();
    }

    class PlayerPrefsException : System.Exception
    {
        /*0x7e7bfbc*/ PlayerPrefsException(string error);
    }

    class PlayerPrefs
    {
        static /*0x7e7c024*/ bool TrySetInt(string key, int value);
        static /*0x7e7c1e4*/ bool TrySetSetString(string key, string value);
        static /*0x7e7c464*/ void SetInt(string key, int value);
        static /*0x7e7c4bc*/ int GetInt(string key, int defaultValue);
        static /*0x7e7c678*/ int GetInt(string key);
        static /*0x7e7c680*/ void SetString(string key, string value);
        static /*0x7e7c6d8*/ string GetString(string key, string defaultValue);
        static /*0x7e7c99c*/ string GetString(string key);
        static /*0x7e7c9e4*/ bool HasKey(string key);
        static /*0x7e7cb94*/ void DeleteKey(string key);
        static /*0x7e7cd38*/ void Save();
        static /*0x7e7c1a0*/ bool TrySetInt_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key, int value);
        static /*0x7e7c420*/ bool TrySetSetString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7e7c634*/ int GetInt_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key, int defaultValue);
        static /*0x7e7c948*/ void GetString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key, ref UnityEngine.Bindings.ManagedSpanWrapper defaultValue, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e7cb58*/ bool HasKey_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key);
        static /*0x7e7ccfc*/ void DeleteKey_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper key);
    }

    class PropertyAttribute : System.Attribute
    {
        /*0x10*/ int <order>k__BackingField;
        /*0x14*/ bool <applyToCollection>k__BackingField;

        /*0x7e7cd60*/ PropertyAttribute();
        /*0x7e7cd7c*/ PropertyAttribute(bool applyToCollection);
    }

    class InspectorNameAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ string displayName;

        /*0x7e7cda4*/ InspectorNameAttribute(string displayName);
    }

    class TooltipAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ string tooltip;

        /*0x7e7cdd8*/ TooltipAttribute(string tooltip);
    }

    class SpaceAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ float height;

        /*0x7e7ce0c*/ SpaceAttribute();
        /*0x7e7ce30*/ SpaceAttribute(float height);
    }

    class HeaderAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ string header;

        /*0x7e7ce5c*/ HeaderAttribute(string header);
    }

    class RangeAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ float min;
        /*0x1c*/ float max;

        /*0x7e7ce90*/ RangeAttribute(float min, float max);
    }

    class MinAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ float min;

        /*0x7e7cec0*/ MinAttribute(float min);
    }

    class MultilineAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ int lines;

        /*0x7e7ceec*/ MultilineAttribute();
    }

    class TextAreaAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ int minLines;
        /*0x1c*/ int maxLines;

        /*0x7e7cf10*/ TextAreaAttribute(int minLines, int maxLines);
    }

    class ColorUsageAttribute : UnityEngine.PropertyAttribute
    {
        /*0x15*/ bool showAlpha;
        /*0x16*/ bool hdr;
        /*0x18*/ float minBrightness;
        /*0x1c*/ float maxBrightness;
        /*0x20*/ float minExposureValue;
        /*0x24*/ float maxExposureValue;

        /*0x7e7cf40*/ ColorUsageAttribute(bool showAlpha);
        /*0x7e7cf80*/ ColorUsageAttribute(bool showAlpha, bool hdr);
    }

    class DelayedAttribute : UnityEngine.PropertyAttribute
    {
        /*0x7e7cfc8*/ DelayedAttribute();
    }

    class NonReorderableAttribute : UnityEngine.PropertyAttribute
    {
        /*0x7e7cfe4*/ NonReorderableAttribute();
    }

    class PropertyNameUtils
    {
        static /*0x7e7d000*/ UnityEngine.PropertyName PropertyNameFromString(string name);
        static /*0x7e7d178*/ void PropertyNameFromString_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.PropertyName ret);
    }

    struct PropertyName : System.IEquatable<UnityEngine.PropertyName>
    {
        /*0x10*/ int id;

        static /*0x7e7d1e0*/ bool IsNullOrEmpty(UnityEngine.PropertyName prop);
        static /*0x7e7d1ec*/ bool op_Equality(UnityEngine.PropertyName lhs, UnityEngine.PropertyName rhs);
        static /*0x7e7d288*/ UnityEngine.PropertyName op_Implicit(string name);
        /*0x7e7d1bc*/ PropertyName(string name);
        /*0x7e7d1d8*/ PropertyName(UnityEngine.PropertyName other);
        /*0x7e7d1f8*/ int GetHashCode();
        /*0x7e7d200*/ bool Equals(object other);
        /*0x7e7d278*/ bool Equals(UnityEngine.PropertyName other);
        /*0x7e7d29c*/ string ToString();
    }

    class Random
    {
        static /*0x7e7d314*/ void InitState(int seed);
        static /*0x7e7d350*/ UnityEngine.Random.State get_state();
        static /*0x7e7d3d0*/ void set_state(UnityEngine.Random.State value);
        static /*0x7e7d44c*/ float Range(float minInclusive, float maxInclusive);
        static /*0x7e7d48c*/ int Range(int minInclusive, int maxExclusive);
        static /*0x7e7d4d0*/ int RandomRangeInt(int minInclusive, int maxExclusive);
        static /*0x7e7d514*/ float get_value();
        static /*0x7e7d53c*/ void GetRandomUnitCircle(ref UnityEngine.Vector2 output);
        static /*0x7e7d578*/ UnityEngine.Vector2 get_insideUnitCircle();
        static /*0x7e7d394*/ void get_state_Injected(ref UnityEngine.Random.State ret);
        static /*0x7e7d410*/ void set_state_Injected(ref UnityEngine.Random.State value);

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

        static /*0x7e7d80c*/ RenderingLayerMask();
        static /*0x7e7d5bc*/ uint op_Implicit(UnityEngine.RenderingLayerMask mask);
        static /*0x7e7d5c0*/ int NameToRenderingLayer(string layerName);
        static /*0x7e7d794*/ uint GetDefinedRenderingLayersCombinedMaskValue();
        static /*0x7e7d7bc*/ string[] GetDefinedRenderingLayerNames();
        static /*0x7e7d7e4*/ int GetRenderingLayerCount();
        static /*0x7e7d758*/ int NameToRenderingLayer_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper layerName);
    }

    class ResourceRequest : UnityEngine.AsyncOperation
    {
        /*0x20*/ string m_Path;
        /*0x28*/ System.Type m_Type;

        /*0x7e7d8dc*/ ResourceRequest(nint ptr);
        /*0x7e7d858*/ UnityEngine.Object GetResult();
    }

    class ResourcesAPIInternal
    {
        static /*0x7e7d934*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type);
        static /*0x7e7d970*/ UnityEngine.Shader FindShaderByName(string name);
        static /*0x7e7db70*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        static /*0x7e7db34*/ nint FindShaderByName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e7dd5c*/ nint Load_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper path, System.Type systemTypeInstance);
    }

    class ResourcesAPI
    {
        static /*0x0*/ UnityEngine.ResourcesAPI s_DefaultAPI;
        static /*0x8*/ UnityEngine.ResourcesAPI <overrideAPI>k__BackingField;

        static /*0x7e7def8*/ ResourcesAPI();
        static /*0x7e7dda0*/ UnityEngine.ResourcesAPI get_ActiveAPI();
        static /*0x7e7de48*/ UnityEngine.ResourcesAPI get_overrideAPI();
        /*0x7e7dea0*/ ResourcesAPI();
        /*0x7e7dea8*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type systemTypeInstance);
        /*0x7e7dee4*/ UnityEngine.Shader FindShaderByName(string name);
        /*0x7e7deec*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
    }

    class Resources
    {
        static /*0x38379c4*/ T[] ConvertObjects<T>(UnityEngine.Object[] rawObjects);
        static /*0x7e7df60*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type);
        static /*0x3836db8*/ T[] FindObjectsOfTypeAll<T>();
        static /*0x7e7dfc8*/ UnityEngine.Object Load(string path);
        static /*0x3910ae8*/ T Load<T>(string path);
        static /*0x7e7d864*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        static /*0x7e7e038*/ UnityEngine.Object GetBuiltinResource(System.Type type, string path);
        static /*0x3910ae8*/ T GetBuiltinResource<T>(string path);
        static /*0x7e7e268*/ UnityEngine.AsyncOperation UnloadUnusedAssets();
        static /*0x7e7e224*/ nint GetBuiltinResource_Injected(System.Type type, ref UnityEngine.Bindings.ManagedSpanWrapper path);
        static /*0x7e7e2a4*/ nint UnloadUnusedAssets_Injected();
    }

    class AsyncInstantiateOperation : UnityEngine.AsyncOperation
    {
        /*0x20*/ UnityEngine.Object[] m_Result;
        /*0x28*/ System.Threading.CancellationToken m_CancellationToken;

        /*0x7e7e324*/ AsyncInstantiateOperation(nint ptr, System.Threading.CancellationToken cancellationToken);
        /*0x7e7e350*/ bool IsCancellationRequested();
        /*0x7e7e3a8*/ UnityEngine.Object[] CreateResultArray(int size);
    }

    class AsyncInstantiateOperation<T> : UnityEngine.AsyncInstantiateOperation
    {
        /*0x3910ae8*/ AsyncInstantiateOperation(nint ptr, System.Threading.CancellationToken cancellationToken);
        /*0x3814964*/ UnityEngine.Object[] CreateResultArray(int size);
    }

    class AsyncInstantiateOperationHelper
    {
        static /*0x7e7e414*/ UnityEngine.Object[] CreateAsyncInstantiateOperationResultArray(UnityEngine.AsyncInstantiateOperation op, int size);
    }

    class AsyncOperation : UnityEngine.YieldInstruction
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ System.Action<UnityEngine.AsyncOperation> m_completeCallback;

        static /*0x7e7e430*/ void InternalDestroy(nint ptr);
        static /*0x7e7e46c*/ void InternalSetManagedObject(nint ptr, UnityEngine.AsyncOperation self);
        static /*0x7e7e500*/ bool get_isDone_Injected(nint _unity_self);
        static /*0x7e7e58c*/ float get_progress_Injected(nint _unity_self);
        static /*0x7e7e620*/ void set_priority_Injected(nint _unity_self, int value);
        static /*0x7e7e6b4*/ bool get_allowSceneActivation_Injected(nint _unity_self);
        static /*0x7e7e748*/ void set_allowSceneActivation_Injected(nint _unity_self, bool value);
        /*0x7e7d8e0*/ AsyncOperation(nint ptr);
        /*0x7e7e4b0*/ bool get_isDone();
        /*0x7e7e53c*/ float get_progress();
        /*0x7e7e5c8*/ void set_priority(int value);
        /*0x7e7e664*/ bool get_allowSceneActivation();
        /*0x7e7e6f0*/ void set_allowSceneActivation(bool value);
        /*0x7e7e78c*/ void Finalize();
        /*0x7e7e848*/ void InvokeCompletionEvent();
        /*0x7e7e898*/ void add_completed(System.Action<UnityEngine.AsyncOperation> value);
        /*0x7e7e974*/ void remove_completed(System.Action<UnityEngine.AsyncOperation> value);

        class BindingsMarshaller
        {
            static /*0x7e7e2cc*/ UnityEngine.AsyncOperation ConvertToManaged(nint ptr);
            static /*0x7e7ea1c*/ nint ConvertToNative(UnityEngine.AsyncOperation asyncOperation);
        }
    }

    class AttributeHelperEngine
    {
        static /*0x0*/ UnityEngine.DisallowMultipleComponent[] _disallowMultipleComponentArray;
        static /*0x8*/ UnityEngine.ExecuteInEditMode[] _executeInEditModeArray;
        static /*0x10*/ UnityEngine.RequireComponent[] _requireComponentArray;

        static /*0x7e7f2e0*/ AttributeHelperEngine();
        static /*0x7e7ea34*/ System.Type GetParentTypeDisallowingMultipleInclusion(System.Type type);
        static /*0x7e7eb5c*/ System.Type[] GetRequiredComponents(System.Type klass);
        static /*0x7e7f05c*/ int GetExecuteMode(System.Type klass);
        static /*0x7e7f15c*/ int CheckIsEditorScript(System.Type klass);
        static /*0x7e7f260*/ int GetDefaultExecutionOrderFor(System.Type klass);
        static /*0x3910ae8*/ T GetCustomAttributeOfType<T>(System.Type klass);
    }

    class DisallowMultipleComponent : System.Attribute
    {
        /*0x7e7f3cc*/ DisallowMultipleComponent();
    }

    class RequireComponent : System.Attribute
    {
        /*0x10*/ System.Type m_Type0;
        /*0x18*/ System.Type m_Type1;
        /*0x20*/ System.Type m_Type2;

        /*0x7e7f3d4*/ RequireComponent(System.Type requiredComponent);
        /*0x7e7f404*/ RequireComponent(System.Type requiredComponent, System.Type requiredComponent2);
        /*0x7e7f448*/ RequireComponent(System.Type requiredComponent, System.Type requiredComponent2, System.Type requiredComponent3);
    }

    class AddComponentMenu : System.Attribute
    {
        /*0x10*/ string m_AddComponentMenu;
        /*0x18*/ int m_Ordering;

        /*0x7e7f4a8*/ AddComponentMenu(string menuName);
        /*0x7e7f4e0*/ AddComponentMenu(string menuName, int order);
    }

    class CreateAssetMenuAttribute : System.Attribute
    {
        /*0x10*/ string <menuName>k__BackingField;
        /*0x18*/ string <fileName>k__BackingField;
        /*0x20*/ int <order>k__BackingField;

        /*0x7e7f534*/ CreateAssetMenuAttribute();
        /*0x7e7f51c*/ void set_menuName(string value);
        /*0x7e7f524*/ void set_fileName(string value);
        /*0x7e7f52c*/ void set_order(int value);
    }

    class ContextMenu : System.Attribute
    {
        /*0x10*/ string menuItem;
        /*0x18*/ bool validate;
        /*0x1c*/ int priority;

        /*0x7e7f53c*/ ContextMenu(string itemName);
        /*0x7e7f580*/ ContextMenu(string itemName, bool isValidateFunction);
        /*0x7e7f5c8*/ ContextMenu(string itemName, bool isValidateFunction, int priority);
    }

    class ExecuteInEditMode : System.Attribute
    {
        /*0x7e7f614*/ ExecuteInEditMode();
    }

    class ExecuteAlways : System.Attribute
    {
        /*0x7e7f61c*/ ExecuteAlways();
    }

    class HideInInspector : System.Attribute
    {
        /*0x7e7f624*/ HideInInspector();
    }

    class HelpURLAttribute : System.Attribute
    {
        /*0x10*/ string m_Url;
        /*0x18*/ bool m_Dispatcher;
        /*0x20*/ string m_DispatchingFieldName;

        /*0x7e7f62c*/ HelpURLAttribute(string url);
        /*0x7e7f6a8*/ string get_URL();
    }

    class DefaultExecutionOrder : System.Attribute
    {
        /*0x10*/ int m_Order;

        /*0x7e7f6b0*/ DefaultExecutionOrder(int order);
        /*0x7e7f2d8*/ int get_order();
    }

    class AssemblyIsEditorAssembly : System.Attribute
    {
    }

    class ExcludeFromPresetAttribute : System.Attribute
    {
        /*0x7e7f6d8*/ ExcludeFromPresetAttribute();
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

        static /*0x7e80d5c*/ Awaitable();
        static /*0x7e7f958*/ void ReleaseNativeAwaitable(nint nativeAwaitable);
        static /*0x7e7f994*/ int IsNativeAwaitableCompleted(nint nativeAwaitable);
        static /*0x7e7f9d0*/ void OnDelayedCallManagerCleared();
        static /*0x7e7fab8*/ void OnUpdate();
        static /*0x7e7fe18*/ void OnEndOfFrame();
        static /*0x7e7fe78*/ void SetSynchronizationContext(UnityEngine.UnitySynchronizationContext synchronizationContext);
        static /*0x7e7ff00*/ bool MatchCompletionThreadAffinity(UnityEngine.Awaitable.AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity);
        static /*0x7e8014c*/ void DoRunContinuationOnSynchonizationContext(object continuation);
        /*0x7e7fef4*/ Awaitable();
        /*0x7e7f6e0*/ void SetExceptionFromNative(System.Exception ex);
        /*0x7e7f810*/ void RunContinuation();
        /*0x7e7ffe8*/ void RunOrScheduleContinuation(UnityEngine.Awaitable.AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity, System.Action continuation);
        /*0x7e801b8*/ void RaiseManagedCompletion();
        /*0x7e8031c*/ void PropagateExceptionAndRelease();
        /*0x7e8073c*/ bool get_IsCompletedNoLock();
        /*0x7e808c4*/ bool get_IsCompleted();
        /*0x7e809e8*/ bool get_IsDettachedOrCompleted();
        /*0x7e80c78*/ UnityEngine.Awaitable.AwaitableHandle CheckPointerValidity();
        /*0x7e80d1c*/ bool System.Collections.IEnumerator.MoveNext();
        /*0x7e80d50*/ void System.Collections.IEnumerator.Reset();
        /*0x7e80d54*/ object System.Collections.IEnumerator.get_Current();

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

            /*0x7e80f90*/ UnityEngine.Awaitable get_Awaitable();
            /*0x7e80f98*/ int get_FrameIndex();
        }

        class DoubleBufferedAwaitableList
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Awaitable.AwaitableAndFrameIndex> _awaitables;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Awaitable.AwaitableAndFrameIndex> _scratch;

            /*0x7e80ee4*/ DoubleBufferedAwaitableList();
            /*0x7e7fb18*/ void SwapAndComplete();
            /*0x7e7fa48*/ void Clear();
        }

        struct AwaitableHandle
        {
            static /*0x0*/ UnityEngine.Awaitable.AwaitableHandle ManagedHandle;
            static /*0x8*/ UnityEngine.Awaitable.AwaitableHandle NullHandle;
            /*0x10*/ nint _handle;

            static /*0x7e80fac*/ AwaitableHandle();
            static /*0x7e80fa8*/ nint op_Implicit(UnityEngine.Awaitable.AwaitableHandle handle);
            /*0x7e80fa0*/ AwaitableHandle(nint handle);
            /*0x7e8072c*/ bool get_IsNull();
            /*0x7e806c4*/ bool get_IsManaged();
        }

        class <>c
        {
            static /*0x0*/ UnityEngine.Awaitable.<> <>9;
            static /*0x8*/ System.Func<UnityEngine.Awaitable> <>9__76_1;

            static /*0x7e8100c*/ <>c();
            /*0x7e81074*/ <>c();
            /*0x7e8107c*/ UnityEngine.Pool.ObjectPool<UnityEngine.Awaitable> <.cctor>b__76_0();
            /*0x7e811b8*/ UnityEngine.Awaitable <.cctor>b__76_1();
        }
    }

    class Behaviour : UnityEngine.Component
    {
        static /*0x7e81288*/ bool get_enabled_Injected(nint _unity_self);
        static /*0x7e81344*/ void set_enabled_Injected(nint _unity_self, bool value);
        static /*0x7e81400*/ bool get_isActiveAndEnabled_Injected(nint _unity_self);
        /*0x7e8143c*/ Behaviour();
        /*0x7e81210*/ bool get_enabled();
        /*0x7e812c4*/ void set_enabled(bool value);
        /*0x7e81388*/ bool get_isActiveAndEnabled();
    }

    struct CastHelper<T>
    {
        /*0x0*/ T t;
        /*0x0*/ nint onePointerFurtherThanT;
    }

    class ClassLibraryInitializer
    {
        static /*0x7e81498*/ void Init();
    }

    struct AssemblyVersion
    {
        /*0x10*/ ushort major;
        /*0x12*/ ushort minor;
        /*0x14*/ ushort build;
        /*0x16*/ ushort revision;

        static /*0x7e814a0*/ bool op_Equality(UnityEngine.AssemblyVersion lhs, UnityEngine.AssemblyVersion rhs);
        /*0x7e814d0*/ string ToString();
        /*0x7e816a0*/ bool Equals(object other);
        /*0x7e81748*/ int GetHashCode();
    }

    struct AssemblyFullName
    {
        /*0x10*/ string Name;
        /*0x18*/ UnityEngine.AssemblyVersion Version;
        /*0x20*/ string PublicKeyToken;
        /*0x28*/ string Culture;

        /*0x7e817d8*/ bool Equals(object other);
        /*0x7e818b0*/ int GetHashCode();
        /*0x7e81938*/ string ToString();
    }

    class Component : UnityEngine.Object
    {
        static /*0x7e81b9c*/ nint get_transform_Injected(nint _unity_self);
        static /*0x7e81c6c*/ nint get_gameObject_Injected(nint _unity_self);
        static /*0x7e81dfc*/ void GetComponentFastPath_Injected(nint _unity_self, System.Type type, nint oneFurtherThanResultValue);
        static /*0x7e82154*/ void GetComponentsForListInternal_Injected(nint _unity_self, System.Type searchType, object resultList);
        static /*0x7e82658*/ void SendMessage_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object value, UnityEngine.SendMessageOptions options);
        static /*0x7e8286c*/ void BroadcastMessage_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object parameter, UnityEngine.SendMessageOptions options);
        /*0x7e81440*/ Component();
        /*0x7e81b08*/ UnityEngine.Transform get_transform();
        /*0x7e81bd8*/ UnityEngine.GameObject get_gameObject();
        /*0x7e81ca8*/ UnityEngine.Component GetComponent(System.Type type);
        /*0x7e81d6c*/ void GetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x3910ae8*/ T GetComponent<T>();
        /*0x7e81e50*/ bool TryGetComponent(System.Type type, ref UnityEngine.Component component);
        /*0x38141c4*/ bool TryGetComponent<T>(ref T component);
        /*0x7e81f0c*/ UnityEngine.Component GetComponentInChildren(System.Type t, bool includeInactive);
        /*0x3910ae8*/ T GetComponentInChildren<T>(bool includeInactive);
        /*0x3910ae8*/ T GetComponentInChildren<T>();
        T[] GetComponentsInChildren<T>(bool includeInactive);
        void GetComponentsInChildren<T>(bool includeInactive, System.Collections.Generic.List<T> result);
        /*0x38148bc*/ T[] GetComponentsInChildren<T>();
        /*0x3816710*/ void GetComponentsInChildren<T>(System.Collections.Generic.List<T> results);
        /*0x7e81fe8*/ UnityEngine.Component GetComponentInParent(System.Type t, bool includeInactive);
        /*0x3910ae8*/ T GetComponentInParent<T>();
        T[] GetComponentsInParent<T>(bool includeInactive);
        void GetComponentsInParent<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        /*0x38148bc*/ T[] GetComponentsInParent<T>();
        /*0x7e820c4*/ void GetComponentsForListInternal(System.Type searchType, object resultList);
        /*0x7e821a8*/ void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results);
        /*0x3816710*/ void GetComponents<T>(System.Collections.Generic.List<T> results);
        /*0x7e821ac*/ string get_tag();
        /*0x7e822c0*/ void set_tag(string value);
        /*0x38148bc*/ T[] GetComponents<T>();
        /*0x7e8247c*/ bool CompareTag(string tag);
        /*0x7e824a0*/ void SendMessage(string methodName, object value, UnityEngine.SendMessageOptions options);
        /*0x7e826b4*/ void BroadcastMessage(string methodName, object parameter, UnityEngine.SendMessageOptions options);
    }

    class Coroutine : UnityEngine.YieldInstruction
    {
        /*0x10*/ nint m_Ptr;

        static /*0x7e8298c*/ void ReleaseCoroutine(nint ptr);
        /*0x7e828c8*/ Coroutine();
        /*0x7e828d0*/ void Finalize();

        class BindingsMarshaller
        {
            static /*0x7e829c8*/ nint ConvertToNative(UnityEngine.Coroutine coroutine);
        }
    }

    class SetupCoroutine
    {
        static /*0x7e829e0*/ void InvokeMoveNext(System.Collections.IEnumerator enumerator, nint returnValueAddress);
        static /*0x7e82afc*/ object InvokeMember(object behaviour, string name, object variable);
    }

    class CustomYieldInstruction : System.Collections.IEnumerator
    {
        /*0x7e82c14*/ CustomYieldInstruction();
        /*0x3813ffc*/ bool get_keepWaiting();
        /*0x7e82bfc*/ object get_Current();
        /*0x7e82c04*/ bool MoveNext();
        /*0x7e82c10*/ void Reset();
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

        static /*0x7e844a0*/ EnumDataUtility();
        static /*0x7e82c1c*/ UnityEngine.EnumData GetCachedEnumData(System.Type enumType, UnityEngine.EnumDataUtility.CachedType cachedType, System.Func<string, string> nicifyName);
        static /*0x7e83c64*/ void HandleInspectorOrderAttribute(System.Type enumType, ref UnityEngine.EnumData enumData);
        static /*0x7e83b50*/ bool CheckObsoleteAddition(System.Reflection.FieldInfo field, UnityEngine.EnumDataUtility.CachedType cachedType);
        static /*0x7e84150*/ string EnumTooltipFromEnumField(System.Reflection.FieldInfo field);
        static /*0x7e84260*/ string EnumNameFromEnumField(System.Reflection.FieldInfo field, System.Func<string, string> nicifyName);
        static /*0x7e84450*/ string <EnumNameFromEnumField>g__NicifyName|8_0(ref UnityEngine.EnumDataUtility.<> );

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

            static /*0x7e84538*/ <>c();
            /*0x7e845a0*/ <>c();
            /*0x7e845a8*/ int <GetCachedEnumData>b__2_5(System.Reflection.FieldInfo f);
            /*0x7e845d0*/ string <GetCachedEnumData>b__2_1(System.Reflection.FieldInfo f);
            /*0x7e84624*/ System.Enum <GetCachedEnumData>b__2_2(System.Reflection.FieldInfo f);
            /*0x7e8468c*/ int <GetCachedEnumData>b__2_3(System.Enum v);
            /*0x7e846e8*/ int <GetCachedEnumData>b__2_4(System.Enum v);
        }

        class <>c__DisplayClass2_0
        {
            /*0x10*/ System.Func<string, string> nicifyName;

            /*0x7e83b48*/ <>c__DisplayClass2_0();
            /*0x7e84744*/ string <GetCachedEnumData>b__0(System.Reflection.FieldInfo f);
        }

        struct <>c__DisplayClass8_0
        {
            /*0x10*/ System.Func<string, string> nicifyName;
            /*0x18*/ System.Reflection.FieldInfo field;
        }
    }

    class ExcludeFromObjectFactoryAttribute : System.Attribute
    {
        /*0x7e847ac*/ ExcludeFromObjectFactoryAttribute();
    }

    class ExtensionOfNativeClassAttribute : System.Attribute
    {
        /*0x7e847b4*/ ExtensionOfNativeClassAttribute();
    }

    class FailedToLoadScriptObject : UnityEngine.Object
    {
    }

    class GameObject : UnityEngine.Object
    {
        static /*0x7e847bc*/ UnityEngine.GameObject CreatePrimitive(UnityEngine.PrimitiveType type);
        static /*0x7e853b8*/ UnityEngine.GameObject FindWithTag(string tag);
        static /*0x7e85580*/ void FindGameObjectsWithTagForListInternal(string tag, object results);
        static /*0x7e85734*/ void FindGameObjectsWithTag(string tag, System.Collections.Generic.List<UnityEngine.GameObject> results);
        static /*0x7e853bc*/ UnityEngine.GameObject FindGameObjectWithTag(string tag);
        static /*0x7e86f30*/ UnityEngine.GameObject[] FindGameObjectsWithTag(string tag);
        static /*0x7e8729c*/ void Internal_CreateGameObject(UnityEngine.GameObject self, string name);
        static /*0x7e87574*/ UnityEngine.GameObject Find(string name);
        static /*0x7e87774*/ void SetGameObjectsActive(nint instanceIds, int instanceCount, bool active);
        static /*0x7e877c8*/ void SetGameObjectsActive(Unity.Collections.NativeArray<int> instanceIDs, bool active);
        static /*0x7e878e0*/ void SetGameObjectsActive(System.ReadOnlySpan<int> instanceIDs, bool active);
        static /*0x7e87994*/ void InstantiateGameObjects(int sourceInstanceID, nint newInstanceIDs, nint newTransformInstanceIDs, int count, UnityEngine.SceneManagement.Scene destinationScene);
        static /*0x7e87a70*/ void InstantiateGameObjects(int sourceInstanceID, int count, Unity.Collections.NativeArray<int> newInstanceIDs, Unity.Collections.NativeArray<int> newTransformInstanceIDs, UnityEngine.SceneManagement.Scene destinationScene);
        static /*0x7e87c3c*/ UnityEngine.SceneManagement.Scene GetScene(int instanceID);
        static /*0x7e84828*/ nint CreatePrimitive_Injected(UnityEngine.PrimitiveType type);
        static /*0x7e84864*/ nint GetComponent_Injected(nint _unity_self, System.Type type);
        static /*0x7e84938*/ void GetComponentFastPath_Injected(nint _unity_self, System.Type type, nint oneFurtherThanResultValue);
        static /*0x7e84b80*/ nint GetComponentByName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper type);
        static /*0x7e84dc0*/ nint GetComponentByNameWithCase_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper type, bool caseSensitive);
        static /*0x7e84e18*/ nint GetComponentInChildren_Injected(nint _unity_self, System.Type type, bool includeInactive);
        static /*0x7e84e74*/ nint GetComponentInParent_Injected(nint _unity_self, System.Type type, bool includeInactive);
        static /*0x7e84f90*/ System.Array GetComponentsInternal_Injected(nint _unity_self, System.Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList);
        static /*0x7e85290*/ nint TryGetComponentInternal_Injected(nint _unity_self, System.Type type);
        static /*0x7e85364*/ void TryGetComponentFastPath_Injected(nint _unity_self, System.Type type, nint oneFurtherThanResultValue);
        static /*0x7e856f0*/ void FindGameObjectsWithTagForListInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper tag, object results);
        static /*0x7e85e78*/ nint AddComponentInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper className);
        static /*0x7e85f60*/ nint Internal_AddComponentWithType_Injected(nint _unity_self, System.Type componentType);
        static /*0x7e86020*/ int GetComponentCount_Injected(nint _unity_self);
        static /*0x7e86100*/ nint QueryComponentAtIndex_Injected(nint _unity_self, int index);
        static /*0x7e86288*/ int GetComponentIndex_Injected(nint _unity_self, nint component);
        static /*0x7e86360*/ nint get_transform_Injected(nint _unity_self);
        static /*0x7e86414*/ int get_layer_Injected(nint _unity_self);
        static /*0x7e864d0*/ void set_layer_Injected(nint _unity_self, int value);
        static /*0x7e8658c*/ bool get_active_Injected(nint _unity_self);
        static /*0x7e86648*/ void set_active_Injected(nint _unity_self, bool value);
        static /*0x7e8670c*/ void SetActive_Injected(nint _unity_self, bool value);
        static /*0x7e867c8*/ bool get_activeSelf_Injected(nint _unity_self);
        static /*0x7e8687c*/ bool get_activeInHierarchy_Injected(nint _unity_self);
        static /*0x7e86938*/ void SetActiveRecursively_Injected(nint _unity_self, bool state);
        static /*0x7e869f4*/ bool get_isStatic_Injected(nint _unity_self);
        static /*0x7e86ab0*/ void set_isStatic_Injected(nint _unity_self, bool value);
        static /*0x7e86b6c*/ bool get_isStaticBatchable_Injected(nint _unity_self);
        static /*0x7e86ba8*/ void get_tag_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e86bec*/ void set_tag_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7e86e6c*/ bool CompareTag_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper tag);
        static /*0x7e86eb0*/ bool CompareTagHandle_Internal_Injected(nint _unity_self, ref UnityEngine.TagHandle tag);
        static /*0x7e86ef4*/ nint FindGameObjectWithTag_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper tag);
        static /*0x7e870a0*/ UnityEngine.GameObject[] FindGameObjectsWithTag_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper tag);
        static /*0x7e870dc*/ void SendMessageUpwards_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object value, UnityEngine.SendMessageOptions options);
        static /*0x7e8714c*/ void SendMessage_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object value, UnityEngine.SendMessageOptions options);
        static /*0x7e871bc*/ void BroadcastMessage_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object parameter, UnityEngine.SendMessageOptions options);
        static /*0x7e87530*/ void Internal_CreateGameObject_Injected(UnityEngine.GameObject self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e87738*/ nint Find_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e87a04*/ void InstantiateGameObjects_Injected(int sourceInstanceID, nint newInstanceIDs, nint newTransformInstanceIDs, int count, ref UnityEngine.SceneManagement.Scene destinationScene);
        static /*0x7e87c88*/ void GetScene_Injected(int instanceID, ref UnityEngine.SceneManagement.Scene ret);
        static /*0x7e87d54*/ void get_scene_Injected(nint _unity_self, ref UnityEngine.SceneManagement.Scene ret);
        static /*0x7e87e10*/ ulong get_sceneCullingMask_Injected(nint _unity_self);
        /*0x7e8722c*/ GameObject(string name);
        /*0x7e8740c*/ GameObject();
        /*0x7e87470*/ GameObject(string name, System.Type[] components);
        /*0x3910ae8*/ T GetComponent<T>();
        /*0x7e81cc8*/ UnityEngine.Component GetComponent(System.Type type);
        /*0x7e848a8*/ void GetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x7e8498c*/ UnityEngine.Component GetComponentByName(string type);
        /*0x7e84bc4*/ UnityEngine.Component GetComponentByNameWithCase(string type, bool caseSensitive);
        /*0x7e84e14*/ UnityEngine.Component GetComponent(string type);
        /*0x7e81f3c*/ UnityEngine.Component GetComponentInChildren(System.Type type, bool includeInactive);
        /*0x7e84e6c*/ UnityEngine.Component GetComponentInChildren(System.Type type);
        /*0x3910ae8*/ T GetComponentInChildren<T>();
        /*0x3910ae8*/ T GetComponentInChildren<T>(bool includeInactive);
        /*0x7e82018*/ UnityEngine.Component GetComponentInParent(System.Type type, bool includeInactive);
        /*0x7e84ec8*/ UnityEngine.Component GetComponentInParent(System.Type type);
        /*0x3910ae8*/ T GetComponentInParent<T>();
        /*0x3910ae8*/ T GetComponentInParent<T>(bool includeInactive);
        /*0x7e84ed0*/ System.Array GetComponentsInternal(System.Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList);
        /*0x7e85014*/ UnityEngine.Component[] GetComponents(System.Type type);
        /*0x38148bc*/ T[] GetComponents<T>();
        /*0x7e8509c*/ void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results);
        /*0x3816710*/ void GetComponents<T>(System.Collections.Generic.List<T> results);
        /*0x7e850b4*/ UnityEngine.Component[] GetComponentsInChildren(System.Type type);
        /*0x7e850bc*/ UnityEngine.Component[] GetComponentsInChildren(System.Type type, bool includeInactive);
        T[] GetComponentsInChildren<T>(bool includeInactive);
        void GetComponentsInChildren<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        /*0x38148bc*/ T[] GetComponentsInChildren<T>();
        /*0x3816710*/ void GetComponentsInChildren<T>(System.Collections.Generic.List<T> results);
        /*0x7e85150*/ UnityEngine.Component[] GetComponentsInParent(System.Type type);
        /*0x7e85158*/ UnityEngine.Component[] GetComponentsInParent(System.Type type, bool includeInactive);
        void GetComponentsInParent<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        T[] GetComponentsInParent<T>(bool includeInactive);
        /*0x38148bc*/ T[] GetComponentsInParent<T>();
        /*0x38141c4*/ bool TryGetComponent<T>(ref T component);
        /*0x7e81e80*/ bool TryGetComponent(System.Type type, ref UnityEngine.Component component);
        /*0x7e851ec*/ UnityEngine.Component TryGetComponentInternal(System.Type type);
        /*0x7e852d4*/ void TryGetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x7e85738*/ void SendMessageUpwards(string methodName, UnityEngine.SendMessageOptions options);
        /*0x7e858fc*/ void SendMessage(string methodName, UnityEngine.SendMessageOptions options);
        /*0x7e85ac0*/ void BroadcastMessage(string methodName, UnityEngine.SendMessageOptions options);
        /*0x7e85c84*/ UnityEngine.Component AddComponentInternal(string className);
        /*0x7e85ebc*/ UnityEngine.Component Internal_AddComponentWithType(System.Type componentType);
        /*0x7e85fa4*/ UnityEngine.Component AddComponent(System.Type componentType);
        /*0x3910ae8*/ T AddComponent<T>();
        /*0x7e85fa8*/ int GetComponentCount();
        /*0x7e8605c*/ UnityEngine.Component QueryComponentAtIndex(int index);
        /*0x7e86144*/ UnityEngine.Component GetComponentAtIndex(int index);
        /*0x3910ae8*/ T GetComponentAtIndex<T>(int index);
        /*0x7e861d4*/ int GetComponentIndex(UnityEngine.Component component);
        /*0x7e862cc*/ UnityEngine.Transform get_transform();
        /*0x7e8639c*/ int get_layer();
        /*0x7e86450*/ void set_layer(int value);
        /*0x7e86514*/ bool get_active();
        /*0x7e865c8*/ void set_active(bool value);
        /*0x7e8668c*/ void SetActive(bool value);
        /*0x7e86750*/ bool get_activeSelf();
        /*0x7e86804*/ bool get_activeInHierarchy();
        /*0x7e868b8*/ void SetActiveRecursively(bool state);
        /*0x7e8697c*/ bool get_isStatic();
        /*0x7e86a30*/ void set_isStatic(bool value);
        /*0x7e86af4*/ bool get_isStaticBatchable();
        /*0x7e821c4*/ string get_tag();
        /*0x7e822e0*/ void set_tag(string value);
        /*0x7e8249c*/ bool CompareTag(string tag);
        /*0x7e86ddc*/ bool CompareTag(UnityEngine.TagHandle tag);
        /*0x7e86c30*/ bool CompareTag_Internal(string tag);
        /*0x7e86de4*/ bool CompareTagHandle_Internal(UnityEngine.TagHandle tag);
        /*0x7e85744*/ void SendMessageUpwards(string methodName, object value, UnityEngine.SendMessageOptions options);
        /*0x7e87138*/ void SendMessageUpwards(string methodName, object value);
        /*0x7e87140*/ void SendMessageUpwards(string methodName);
        /*0x7e85908*/ void SendMessage(string methodName, object value, UnityEngine.SendMessageOptions options);
        /*0x7e871a8*/ void SendMessage(string methodName, object value);
        /*0x7e871b0*/ void SendMessage(string methodName);
        /*0x7e85acc*/ void BroadcastMessage(string methodName, object parameter, UnityEngine.SendMessageOptions options);
        /*0x7e87218*/ void BroadcastMessage(string methodName, object parameter);
        /*0x7e87220*/ void BroadcastMessage(string methodName);
        /*0x7e87ccc*/ UnityEngine.SceneManagement.Scene get_scene();
        /*0x7e87d98*/ ulong get_sceneCullingMask();
        /*0x7e87e4c*/ UnityEngine.GameObject get_gameObject();
    }

    class InspectorOrderAttribute : UnityEngine.PropertyAttribute
    {
        /*0x18*/ UnityEngine.InspectorSort <m_inspectorSort>k__BackingField;
        /*0x1c*/ UnityEngine.InspectorSortDirection <m_sortDirection>k__BackingField;

        /*0x7e87e50*/ UnityEngine.InspectorSort get_m_inspectorSort();
        /*0x7e87e58*/ UnityEngine.InspectorSortDirection get_m_sortDirection();
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

        static /*0x7e87e60*/ int op_Implicit(UnityEngine.LayerMask mask);
        static /*0x7e87e64*/ UnityEngine.LayerMask op_Implicit(int intVal);
        static /*0x7e87e74*/ int NameToLayer(string layerName);
        static /*0x7e88020*/ int GetMask(string[] layerNames);
        static /*0x7e87fe4*/ int NameToLayer_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper layerName);
        /*0x7e87e6c*/ int get_value();
    }

    struct LazyLoadReference<T>
    {
        static int kInstanceID_None = 0;
        /*0x0*/ int m_InstanceID;

        static /*0x3910ae8*/ UnityEngine.LazyLoadReference<T> op_Implicit(T asset);
        /*0x3813ffc*/ bool get_isSet();
        /*0x3910ae8*/ T get_asset();
        /*0x3910ae8*/ void set_asset(T value);
    }

    class ManagedStreamHelpers
    {
        static /*0x7e880ec*/ void ValidateLoadFromStream(System.IO.Stream stream);
        static /*0x7e881f0*/ void ManagedStreamRead(byte[] buffer, int offset, int count, System.IO.Stream stream, nint returnValueAddress);
        static /*0x7e882c4*/ void ManagedStreamSeek(long offset, uint origin, System.IO.Stream stream, nint returnValueAddress);
        static /*0x7e88390*/ void ManagedStreamLength(System.IO.Stream stream, nint returnValueAddress);
    }

    class MonoBehaviour : UnityEngine.Behaviour
    {
        /*0x18*/ System.Threading.CancellationTokenSource m_CancellationTokenSource;

        static /*0x7e89968*/ void print(object message);
        static /*0x7e88680*/ void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self);
        static /*0x7e885d4*/ bool Internal_IsInvokingAll(UnityEngine.MonoBehaviour self);
        static /*0x7e88730*/ void InvokeDelayed(UnityEngine.MonoBehaviour self, string methodName, float time, float repeatRate);
        static /*0x7e88988*/ void CancelInvoke(UnityEngine.MonoBehaviour self, string methodName);
        static /*0x7e88b5c*/ bool IsInvoking(UnityEngine.MonoBehaviour self, string methodName);
        static /*0x7e88e04*/ bool IsObjectMonoBehaviour(UnityEngine.Object obj);
        static /*0x7e89590*/ void StopCoroutine_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName);
        static /*0x7e8964c*/ void StopAllCoroutines_Injected(nint _unity_self);
        static /*0x7e89700*/ bool get_useGUILayout_Injected(nint _unity_self);
        static /*0x7e897bc*/ void set_useGUILayout_Injected(nint _unity_self, bool value);
        static /*0x7e89878*/ bool get_didStart_Injected(nint _unity_self);
        static /*0x7e8992c*/ bool get_didAwake_Injected(nint _unity_self);
        static /*0x7e899c0*/ void Internal_CancelInvokeAll_Injected(nint self);
        static /*0x7e899fc*/ bool Internal_IsInvokingAll_Injected(nint self);
        static /*0x7e89a38*/ void InvokeDelayed_Injected(nint self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, float time, float repeatRate);
        static /*0x7e89a94*/ void CancelInvoke_Injected(nint self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName);
        static /*0x7e89ad8*/ bool IsInvoking_Injected(nint self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName);
        static /*0x7e89b1c*/ bool IsObjectMonoBehaviour_Injected(nint obj);
        static /*0x7e89b58*/ UnityEngine.Coroutine StartCoroutineManaged_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper methodName, object value);
        static /*0x7e89bac*/ UnityEngine.Coroutine StartCoroutineManaged2_Injected(nint _unity_self, System.Collections.IEnumerator enumerator);
        static /*0x7e89bf0*/ void StopCoroutineManaged_Injected(nint _unity_self, nint routine);
        static /*0x7e89c34*/ void StopCoroutineFromEnumeratorManaged_Injected(nint _unity_self, System.Collections.IEnumerator routine);
        static /*0x7e89d74*/ void GetScriptClassName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e89db8*/ void OnCancellationTokenCreated_Injected(nint _unity_self);
        /*0x7e89df4*/ MonoBehaviour();
        /*0x7e8843c*/ System.Threading.CancellationToken get_destroyCancellationToken();
        /*0x7e885bc*/ void RaiseCancellation();
        /*0x7e885d0*/ bool IsInvoking();
        /*0x7e8867c*/ void CancelInvoke();
        /*0x7e88728*/ void Invoke(string methodName, float time);
        /*0x7e88918*/ void InvokeRepeating(string methodName, float time, float repeatRate);
        /*0x7e88984*/ void CancelInvoke(string methodName);
        /*0x7e88b58*/ bool IsInvoking(string methodName);
        /*0x7e88d38*/ UnityEngine.Coroutine StartCoroutine(string methodName);
        /*0x7e88d40*/ UnityEngine.Coroutine StartCoroutine(string methodName, object value);
        /*0x7e89064*/ UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine);
        /*0x7e89190*/ UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine);
        /*0x7e89194*/ void StopCoroutine(System.Collections.IEnumerator routine);
        /*0x7e892c0*/ void StopCoroutine(UnityEngine.Coroutine routine);
        /*0x7e893f4*/ void StopCoroutine(string methodName);
        /*0x7e895d4*/ void StopAllCoroutines();
        /*0x7e89688*/ bool get_useGUILayout();
        /*0x7e8973c*/ void set_useGUILayout(bool value);
        /*0x7e89800*/ bool get_didStart();
        /*0x7e898b4*/ bool get_didAwake();
        /*0x7e88eac*/ UnityEngine.Coroutine StartCoroutineManaged(string methodName, object value);
        /*0x7e89110*/ UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator);
        /*0x7e8936c*/ void StopCoroutineManaged(UnityEngine.Coroutine routine);
        /*0x7e89240*/ void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine);
        /*0x7e89c78*/ string GetScriptClassName();
        /*0x7e88544*/ void OnCancellationTokenCreated();
    }

    class NoAllocHelpers
    {
        static /*0x3842d2c*/ void EnsureListElemCount<T>(System.Collections.Generic.List<T> list, int count);
        static /*0x7e89df8*/ int SafeLength(System.Array values);
        static /*0x382da78*/ int SafeLength<T>(System.Collections.Generic.List<T> values);
        static /*0x38379c4*/ T[] ExtractArrayFromList<T>(System.Collections.Generic.List<T> list);
        static /*0x3910ae8*/ void ResetListContents<T>(System.Collections.Generic.List<T> list, System.ReadOnlySpan<T> span);
        static /*0x3842d2c*/ void ResetListSize<T>(System.Collections.Generic.List<T> list, int size);

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

        /*0x7e89e14*/ RangeInt(int start, int length);
        /*0x7e89e08*/ int get_end();
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

        /*0x7e89e1c*/ RuntimeInitializeOnLoadMethodAttribute();
        /*0x7e89e40*/ RuntimeInitializeOnLoadMethodAttribute(UnityEngine.RuntimeInitializeLoadType loadType);
        /*0x7e89e38*/ void set_loadType(UnityEngine.RuntimeInitializeLoadType value);
    }

    class ScriptableObject : UnityEngine.Object
    {
        static /*0x7e89f24*/ UnityEngine.ScriptableObject CreateInstance(System.Type type);
        static /*0x3910ae8*/ T CreateInstance<T>();
        static /*0x7e89ee8*/ void CreateScriptableObject(UnityEngine.ScriptableObject self);
        static /*0x7e89f2c*/ UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromType(System.Type type, bool applyDefaultsAndReset);
        static /*0x7e89fa8*/ nint CreateScriptableObjectInstanceFromType_Injected(System.Type type, bool applyDefaultsAndReset);
        /*0x7e89e68*/ ScriptableObject();
    }

    class ScriptingRuntime
    {
        static /*0x7e89fec*/ string[] GetAllUserAssemblies();
    }

    class ScriptingUtility
    {
        static /*0x7e8a014*/ bool IsManagedCodeWorking();
        static /*0x7e8a01c*/ void SetupCallbacks(nint p);

        struct TestClass
        {
            /*0x10*/ int value;
        }
    }

    class SelectionBaseAttribute : System.Attribute
    {
        /*0x7e8a020*/ SelectionBaseAttribute();
    }

    class StackTraceUtility
    {
        static /*0x0*/ string projectFolder;

        static /*0x7e8ad04*/ StackTraceUtility();
        static /*0x7e8a028*/ void SetProjectFolder(string folder);
        static /*0x7e8a12c*/ string ExtractStackTrace();
        static /*0x7e8a988*/ void ExtractStringFromExceptionInternal(object exceptiono, ref string message, ref string stackTrace);
        static /*0x7e8a288*/ string ExtractFormattedStackTrace(System.Diagnostics.StackTrace stackTrace);
    }

    class UnityException : System.Exception
    {
        /*0x7e8afbc*/ UnityException();
        /*0x7e8b03c*/ UnityException(string message);
        /*0x7e8b0b4*/ UnityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    }

    class MissingReferenceException : System.Exception
    {
        /*0x7e8b134*/ MissingReferenceException();
        /*0x7e8b1b4*/ MissingReferenceException(string message);
        /*0x7e8b22c*/ MissingReferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    }

    struct TagHandle
    {
        /*0x10*/ uint _tagIndex;

        static /*0x7e8b2b4*/ string TagToString(uint tagIndex);
        static /*0x7e8b368*/ void TagToString_Injected(uint tagIndex, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        /*0x7e8b2ac*/ string ToString();
    }

    class TextAsset : UnityEngine.Object
    {
        static /*0x7e8b560*/ void Internal_CreateInstance(UnityEngine.TextAsset self, string text);
        static /*0x7e8b6f8*/ void Internal_CreateInstanceFromBytes(UnityEngine.TextAsset self, System.ReadOnlySpan<byte> bytes);
        static /*0x7e8b98c*/ string DecodeString(byte[] bytes);
        static /*0x7e8b464*/ byte[] get_bytes_Injected(nint _unity_self);
        static /*0x7e8b51c*/ byte[] GetPreviewBytes_Injected(nint _unity_self, int maxByteCount);
        static /*0x7e8b6b4*/ void Internal_CreateInstance_Injected(UnityEngine.TextAsset self, ref UnityEngine.Bindings.ManagedSpanWrapper text);
        static /*0x7e8b7ac*/ void Internal_CreateInstanceFromBytes_Injected(UnityEngine.TextAsset self, ref UnityEngine.Bindings.ManagedSpanWrapper bytes);
        static /*0x7e8b864*/ nint GetDataPtr_Injected(nint _unity_self);
        static /*0x7e8b914*/ long GetDataSize_Injected(nint _unity_self);
        /*0x7e8bc18*/ TextAsset();
        /*0x7e8bcb0*/ TextAsset(string text);
        /*0x7e8bcbc*/ TextAsset(System.ReadOnlySpan<byte> bytes);
        /*0x7e8bc24*/ TextAsset(UnityEngine.TextAsset.CreateOptions options, string text);
        /*0x7e8bccc*/ TextAsset(UnityEngine.TextAsset.CreateOptions options, System.ReadOnlySpan<byte> bytes);
        /*0x7e8b3ac*/ byte[] get_bytes();
        /*0x7e8b4a0*/ byte[] GetPreviewBytes(int maxByteCount);
        /*0x7e8b7f0*/ nint GetDataPtr();
        /*0x7e8b8a0*/ long GetDataSize();
        /*0x7e8b950*/ string get_text();
        /*0x7e8bc10*/ long get_dataSize();
        /*0x7e8bc14*/ string ToString();
        /*0x3910ae8*/ Unity.Collections.NativeArray<T> GetData<T>();
        /*0x7e8bd74*/ string GetPreview(int maxChars);

        enum CreateOptions
        {
            None = 0,
            CreateNativeObject = 1,
        }

        class EncodingUtility
        {
            static /*0x0*/ System.Collections.Generic.KeyValuePair<System.Byte[], System.Text.Encoding> encodingLookup;
            static /*0x8*/ System.Text.Encoding targetEncoding;

            static /*0x7e8bd88*/ EncodingUtility();
        }
    }

    class TrackedReference
    {
        /*0x10*/ nint m_Ptr;

        static /*0x7e8c160*/ bool op_Equality(UnityEngine.TrackedReference x, UnityEngine.TrackedReference y);
        /*0x7e8c158*/ TrackedReference();
        /*0x7e8c1b0*/ bool Equals(object o);
        /*0x7e8c230*/ int GetHashCode();
    }

    class UnhandledExceptionHandler
    {
        static /*0x7e8c23c*/ void RegisterUECatcher();

        class <>c
        {
            static /*0x0*/ UnityEngine.UnhandledExceptionHandler.<> <>9;
            static /*0x8*/ System.UnhandledExceptionEventHandler <>9__0_0;

            static /*0x7e8c338*/ <>c();
            /*0x7e8c3a0*/ <>c();
            /*0x7e8c3a8*/ void <RegisterUECatcher>b__0_0(object sender, System.UnhandledExceptionEventArgs e);
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

        static /*0x7e8ef94*/ Object();
        static /*0x7e8c6e4*/ bool op_Implicit(UnityEngine.Object exists);
        static /*0x7e8c63c*/ bool CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs);
        static /*0x7e8c748*/ bool IsNativeObjectAlive(UnityEngine.Object o);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, UnityEngine.Transform parent);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Transform parent);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Transform parent, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, System.Threading.CancellationToken cancellationToken);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Transform parent, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Transform parent, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations, System.Threading.CancellationToken cancellationToken);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, UnityEngine.InstantiateParameters parameters, System.Threading.CancellationToken cancellationToken);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.InstantiateParameters parameters, System.Threading.CancellationToken cancellationToken);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters, System.Threading.CancellationToken cancellationToken);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters, System.Threading.CancellationToken cancellationToken);
        static /*0x3910ae8*/ UnityEngine.AsyncInstantiateOperation<T> InstantiateAsync<T>(T original, int count, System.ReadOnlySpan<UnityEngine.Vector3> positions, System.ReadOnlySpan<UnityEngine.Quaternion> rotations, UnityEngine.InstantiateParameters parameters, System.Threading.CancellationToken cancellationToken);
        static /*0x7e8cb04*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x7e8cdec*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        static /*0x7e8d0e0*/ UnityEngine.Object Instantiate(UnityEngine.Object original);
        static /*0x7e8d278*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.SceneManagement.Scene scene);
        static /*0x3910ae8*/ T Instantiate<T>(T original, UnityEngine.InstantiateParameters parameters);
        static /*0x3910ae8*/ T Instantiate<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters);
        static /*0x7e8d434*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent);
        static /*0x7e8d49c*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, bool instantiateInWorldSpace);
        static /*0x3910ae8*/ T Instantiate<T>(T original);
        static /*0x3910ae8*/ T Instantiate<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x3910ae8*/ T Instantiate<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
        static /*0x3910ae8*/ T Instantiate<T>(T original, UnityEngine.Transform parent);
        static /*0x3910ae8*/ T Instantiate<T>(T original, UnityEngine.Transform parent, bool worldPositionStays);
        static /*0x7e8d6f8*/ void Destroy(UnityEngine.Object obj, float t);
        static /*0x7e8d7f4*/ void Destroy(UnityEngine.Object obj);
        static /*0x7e8d84c*/ void DestroyImmediate(UnityEngine.Object obj, bool allowDestroyingAssets);
        static /*0x7e8d940*/ void DestroyImmediate(UnityEngine.Object obj);
        static /*0x7e8d998*/ UnityEngine.Object[] FindObjectsOfType(System.Type type);
        static /*0x7e8da10*/ UnityEngine.Object[] FindObjectsOfType(System.Type type, bool includeInactive);
        static /*0x7e8da54*/ UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsSortMode sortMode);
        static /*0x7e8dadc*/ UnityEngine.Object[] FindObjectsByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);
        static /*0x7e8db30*/ void DontDestroyOnLoad(UnityEngine.Object target);
        static /*0x7e8de20*/ void DestroyObject(UnityEngine.Object obj, float t);
        static /*0x7e8de84*/ void DestroyObject(UnityEngine.Object obj);
        static /*0x7e8dedc*/ UnityEngine.Object[] FindSceneObjectsOfType(System.Type type);
        static /*0x7e8df30*/ UnityEngine.Object[] FindObjectsOfTypeIncludingAssets(System.Type type);
        static /*0x3836db8*/ T[] FindObjectsOfType<T>();
        static /*0x38377f4*/ T[] FindObjectsByType<T>(UnityEngine.FindObjectsSortMode sortMode);
        static /*0x383768c*/ T[] FindObjectsOfType<T>(bool includeInactive);
        static /*0x383782c*/ T[] FindObjectsByType<T>(UnityEngine.FindObjectsInactive findObjectsInactive, UnityEngine.FindObjectsSortMode sortMode);
        static /*0x3910ae8*/ T FindObjectOfType<T>();
        static /*0x3910ae8*/ T FindObjectOfType<T>(bool includeInactive);
        static /*0x3910ae8*/ T FindFirstObjectByType<T>();
        static /*0x3910ae8*/ T FindAnyObjectByType<T>();
        static /*0x3910ae8*/ T FindFirstObjectByType<T>(UnityEngine.FindObjectsInactive findObjectsInactive);
        static /*0x3910ae8*/ T FindAnyObjectByType<T>(UnityEngine.FindObjectsInactive findObjectsInactive);
        static /*0x7e8df6c*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type);
        static /*0x7e8ccb4*/ void CheckNullArgument(object arg, string message);
        static /*0x7e8df74*/ UnityEngine.Object FindObjectOfType(System.Type type);
        static /*0x7e8e00c*/ UnityEngine.Object FindFirstObjectByType(System.Type type);
        static /*0x7e8e0b0*/ UnityEngine.Object FindAnyObjectByType(System.Type type);
        static /*0x7e8e154*/ UnityEngine.Object FindObjectOfType(System.Type type, bool includeInactive);
        static /*0x7e8e1f8*/ UnityEngine.Object FindFirstObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive);
        static /*0x7e8e2a8*/ UnityEngine.Object FindAnyObjectByType(System.Type type, UnityEngine.FindObjectsInactive findObjectsInactive);
        static /*0x7e8c5d8*/ bool op_Equality(UnityEngine.Object x, UnityEngine.Object y);
        static /*0x7e8e4c4*/ bool op_Inequality(UnityEngine.Object x, UnityEngine.Object y);
        static /*0x7e8e534*/ int GetOffsetOfInstanceIDInCPlusPlusObject();
        static /*0x7e8c824*/ bool CurrentThreadIsMainThread();
        static /*0x7e8d1b0*/ UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data);
        static /*0x7e8d358*/ UnityEngine.Object Internal_CloneSingleWithScene(UnityEngine.Object data, UnityEngine.SceneManagement.Scene scene);
        static /*0x7e8e5dc*/ UnityEngine.Object Internal_CloneSingleWithParams(UnityEngine.Object data, UnityEngine.InstantiateParameters parameters);
        static /*0x7e8e6fc*/ UnityEngine.Object Internal_InstantiateSingleWithParams(UnityEngine.Object data, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.InstantiateParameters parameters);
        static /*0x7e8d5c4*/ UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, bool worldPositionStays);
        static /*0x7e8e8a0*/ nint Internal_InstantiateAsyncWithParams(UnityEngine.Object original, int count, UnityEngine.InstantiateParameters parameters, nint positions, int positionsCount, nint rotations, int rotationsCount, bool hasManagedCancellationToken);
        static /*0x7e8cd00*/ UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
        static /*0x7e8cf90*/ UnityEngine.Object Internal_InstantiateSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
        static /*0x7e8e3ac*/ string ToString(UnityEngine.Object obj);
        static /*0x7e8eb6c*/ bool IsPersistent(UnityEngine.Object obj);
        static /*0x7e8ec98*/ bool DoesObjectWithInstanceIDExist(int instanceID);
        static /*0x7e8ecd4*/ UnityEngine.Object FindObjectFromInstanceID(int instanceID);
        static /*0x7e8eda0*/ nint GetPtrFromInstanceID(int instanceID, System.Type objectType, ref bool isMonoBehaviour);
        static /*0x7e8edf4*/ UnityEngine.Object ForceLoadFromInstanceID(int instanceID);
        static /*0x7e8d7a8*/ void Destroy_Injected(nint obj, float t);
        static /*0x7e8d8fc*/ void DestroyImmediate_Injected(nint obj, bool allowDestroyingAssets);
        static /*0x7e8dc2c*/ void DontDestroyOnLoad_Injected(nint target);
        static /*0x7e8dd00*/ UnityEngine.HideFlags get_hideFlags_Injected(nint _unity_self);
        static /*0x7e8dddc*/ void set_hideFlags_Injected(nint _unity_self, UnityEngine.HideFlags value);
        static /*0x7e8e55c*/ nint Internal_CloneSingle_Injected(nint data);
        static /*0x7e8e598*/ nint Internal_CloneSingleWithScene_Injected(nint data, ref UnityEngine.SceneManagement.Scene scene);
        static /*0x7e8e6b8*/ nint Internal_CloneSingleWithParams_Injected(nint data, ref UnityEngine.InstantiateParameters parameters);
        static /*0x7e8e7f0*/ nint Internal_InstantiateSingleWithParams_Injected(nint data, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation, ref UnityEngine.InstantiateParameters parameters);
        static /*0x7e8e84c*/ nint Internal_CloneSingleWithParent_Injected(nint data, nint parent, bool worldPositionStays);
        static /*0x7e8e9a8*/ nint Internal_InstantiateAsyncWithParams_Injected(nint original, int count, ref UnityEngine.InstantiateParameters parameters, nint positions, int positionsCount, nint rotations, int rotationsCount, bool hasManagedCancellationToken);
        static /*0x7e8ea34*/ nint Internal_InstantiateSingle_Injected(nint data, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
        static /*0x7e8ea88*/ nint Internal_InstantiateSingleWithParent_Injected(nint data, nint parent, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
        static /*0x7e8eae4*/ void ToString_Injected(nint obj, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e8eb28*/ void GetName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e8ec18*/ bool IsPersistent_Injected(nint obj);
        static /*0x7e8ec54*/ void SetName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e8ed64*/ nint FindObjectFromInstanceID_Injected(int instanceID);
        static /*0x7e8ee84*/ nint ForceLoadFromInstanceID_Injected(int instanceID);
        static /*0x7e8ef58*/ void MarkDirty_Injected(nint _unity_self);
        /*0x7e8bd6c*/ Object();
        /*0x7e8c45c*/ int GetInstanceID();
        /*0x7e8c4d4*/ int GetHashCode();
        /*0x7e8c4dc*/ bool Equals(object other);
        /*0x7e8c768*/ void EnsureRunningOnMainThread();
        /*0x7e8c84c*/ nint GetCachedPtr();
        /*0x7e8c854*/ string get_name();
        /*0x7e8c96c*/ void set_name(string value);
        /*0x7e8dc68*/ UnityEngine.HideFlags get_hideFlags();
        /*0x7e8dd3c*/ void set_hideFlags(UnityEngine.HideFlags value);
        /*0x7e8e358*/ string ToString();
        /*0x7e8c858*/ string GetName();
        /*0x7e8c970*/ void SetName(string name);
        /*0x7e8eec0*/ void MarkDirty();

        class MarshalledUnityObject
        {
            static /*0x3910ae8*/ nint Marshal<T>(T obj);
            static /*0x3910ae8*/ nint MarshalNotNull<T>(T obj);
            static /*0x7e8f000*/ void TryThrowEditorNullExceptionObject(UnityEngine.Object unityObj, string paramterName);
        }
    }

    class UnitySynchronizationContext : System.Threading.SynchronizationContext
    {
        /*0x18*/ System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue;
        /*0x20*/ System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork;
        /*0x28*/ int m_MainThreadID;
        /*0x2c*/ int m_TrackedCount;

        static /*0x7e8fa50*/ void InitializeSynchronizationContext();
        static /*0x7e8faf8*/ void ExecuteTasks();
        static /*0x7e8fb50*/ bool ExecutePendingTasks(long millisecondsTimeout);
        /*0x7e8f00c*/ UnitySynchronizationContext(int mainThreadID);
        /*0x7e8f0d0*/ UnitySynchronizationContext(System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> queue, int mainThreadID);
        /*0x7e8f004*/ int get_MainThreadId();
        /*0x7e8f188*/ void Send(System.Threading.SendOrPostCallback callback, object state);
        /*0x7e8f534*/ void OperationStarted();
        /*0x7e8f540*/ void OperationCompleted();
        /*0x7e8f54c*/ void Post(System.Threading.SendOrPostCallback callback, object state);
        /*0x7e8f6fc*/ System.Threading.SynchronizationContext CreateCopy();
        /*0x7e8f760*/ void Exec();
        /*0x7e8f9f0*/ bool HasPendingTasks();

        struct WorkRequest
        {
            /*0x10*/ System.Threading.SendOrPostCallback m_DelagateCallback;
            /*0x18*/ object m_DelagateState;
            /*0x20*/ System.Threading.ManualResetEvent m_WaitHandle;

            /*0x7e8f4f0*/ WorkRequest(System.Threading.SendOrPostCallback callback, object state, System.Threading.ManualResetEvent waitHandle);
            /*0x7e8f944*/ void Invoke();
        }
    }

    class WaitForEndOfFrame : UnityEngine.YieldInstruction
    {
        /*0x7e8fc3c*/ WaitForEndOfFrame();
    }

    class WaitForFixedUpdate : UnityEngine.YieldInstruction
    {
        /*0x7e8fc4c*/ WaitForFixedUpdate();
    }

    class WaitForSeconds : UnityEngine.YieldInstruction
    {
        /*0x10*/ float m_Seconds;

        /*0x7e8fc54*/ WaitForSeconds(float seconds);
    }

    class WaitForSecondsRealtime : UnityEngine.CustomYieldInstruction
    {
        /*0x10*/ float <waitTime>k__BackingField;
        /*0x14*/ float m_WaitUntilTime;

        /*0x7e8fd50*/ WaitForSecondsRealtime(float time);
        /*0x7e8fc7c*/ float get_waitTime();
        /*0x7e8fc84*/ void set_waitTime(float value);
        /*0x7e8fc8c*/ bool get_keepWaiting();
        /*0x7e8fd80*/ void Reset();
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

        /*0x7e8fe50*/ WaitUntil(System.Func<bool> predicate);
        /*0x7e8fd8c*/ bool get_keepWaiting();
        /*0x7e8fe88*/ double GetTime();
    }

    class YieldInstruction
    {
        /*0x7e8fc44*/ YieldInstruction();
    }

    class SerializeField : System.Attribute
    {
        /*0x7e8ff2c*/ SerializeField();
    }

    class SerializeReference : System.Attribute
    {
        /*0x7e8ff34*/ SerializeReference();
    }

    class PreferBinarySerialization : System.Attribute
    {
        /*0x7e8ff3c*/ PreferBinarySerialization();
    }

    interface ISerializationCallbackReceiver
    {
        /*0x38159dc*/ void OnBeforeSerialize();
        /*0x38159dc*/ void OnAfterDeserialize();
    }

    class ComputeBuffer : System.IDisposable
    {
        /*0x10*/ nint m_Ptr;

        static /*0x7e90148*/ nint InitBuffer(int count, int stride, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage);
        static /*0x7e90100*/ void DestroyBuffer(UnityEngine.ComputeBuffer buf);
        static /*0x7e901a4*/ void DestroyBuffer_Injected(nint buf);
        static /*0x7e90448*/ int get_count_Injected(nint _unity_self);
        static /*0x7e904d0*/ int get_stride_Injected(nint _unity_self);
        static /*0x7e90744*/ void InternalSetNativeData_Injected(nint _unity_self, nint data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);
        static /*0x7e907b8*/ void InternalSetData_Injected(nint _unity_self, System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);
        /*0x7e901e0*/ ComputeBuffer(int count, int stride);
        /*0x7e903c8*/ ComputeBuffer(int count, int stride, UnityEngine.ComputeBufferType type);
        /*0x7e901ec*/ ComputeBuffer(int count, int stride, UnityEngine.ComputeBufferType type, UnityEngine.ComputeBufferMode usage, int stackDepth);
        /*0x7e8ff44*/ void Finalize();
        /*0x7e9009c*/ void Dispose();
        /*0x7e8ffdc*/ void Dispose(bool disposing);
        /*0x7e903f8*/ void Release();
        /*0x7e903fc*/ int get_count();
        /*0x7e90484*/ int get_stride();
        /*0x7e9050c*/ void SetData(System.Array data);
        /*0x3910ae8*/ void SetData<T>(Unity.Collections.NativeArray<T> data);
        /*0x3910ae8*/ void SetData<T>(Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int computeBufferStartIndex, int count);
        /*0x7e906c0*/ void InternalSetNativeData(nint data, int nativeBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);
        /*0x7e9063c*/ void InternalSetData(System.Array data, int managedBufferStartIndex, int computeBufferStartIndex, int count, int elemSize);

        class BindingsMarshaller
        {
            static /*0x7e9082c*/ nint ConvertToNative(UnityEngine.ComputeBuffer computeBuffer);
        }
    }

    class ComputeShader : UnityEngine.Object
    {
        static /*0x7e909c0*/ int FindKernel_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
        static /*0x7e90a90*/ void SetInt_Injected(nint _unity_self, int nameID, int val);
        static /*0x7e90be4*/ void SetIntArray_Injected(nint _unity_self, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
        static /*0x7e90d08*/ void Internal_SetBuffer_Injected(nint _unity_self, int kernelIndex, int nameID, nint buffer);
        static /*0x7e90e34*/ void Internal_SetGraphicsBuffer_Injected(nint _unity_self, int kernelIndex, int nameID, nint buffer);
        static /*0x7e90f78*/ void SetConstantComputeBuffer_Injected(nint _unity_self, int nameID, nint buffer, int offset, int size);
        static /*0x7e91088*/ void GetKernelThreadGroupSizes_Injected(nint _unity_self, int kernelIndex, ref uint x, ref uint y, ref uint z);
        static /*0x7e91198*/ void Dispatch_Injected(nint _unity_self, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
        static /*0x7e91288*/ void get_keywordSpace_Injected(nint _unity_self, ref UnityEngine.Rendering.LocalKeywordSpace ret);
        static /*0x7e9143c*/ void EnableKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e915f0*/ void DisableKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
        static /*0x7e916b0*/ void SetShaderKeywords_Injected(nint _unity_self, string[] names);
        /*0x7e916f8*/ ComputeShader();
        /*0x7e90844*/ int FindKernel(string name);
        /*0x7e90a04*/ void SetInt(int nameID, int val);
        /*0x7e90ae4*/ void SetIntArray(int nameID, int[] values);
        /*0x7e90c38*/ void Internal_SetBuffer(int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
        /*0x7e90d64*/ void Internal_SetGraphicsBuffer(int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
        /*0x7e90e90*/ void SetBuffer(int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
        /*0x7e90e94*/ void SetBuffer(int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
        /*0x7e90e98*/ void SetConstantComputeBuffer(int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
        /*0x7e90fe4*/ void GetKernelThreadGroupSizes(int kernelIndex, ref uint x, ref uint y, ref uint z);
        /*0x7e910f4*/ void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
        /*0x7e91204*/ UnityEngine.Rendering.LocalKeywordSpace get_keywordSpace();
        /*0x7e912cc*/ void EnableKeyword(string keyword);
        /*0x7e91480*/ void DisableKeyword(string keyword);
        /*0x7e91634*/ void SetShaderKeywords(string[] names);
        /*0x7e916f4*/ void set_shaderKeywords(string[] value);
        /*0x7e91750*/ void SetInts(int nameID, int[] values);
        /*0x7e91754*/ void SetConstantBuffer(int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
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
        /*0x7e91758*/ void LowerResBlitTextureDontStripMe();
    }

    class PreloadData : UnityEngine.Object
    {
        /*0x7e9175c*/ void PreloadDataDontStripMe();
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
        static /*0x7e91760*/ float get_batteryLevel();
        static /*0x7e917b0*/ UnityEngine.BatteryStatus get_batteryStatus();
        static /*0x7e91800*/ string get_operatingSystem();
        static /*0x7e918b0*/ UnityEngine.OperatingSystemFamily get_operatingSystemFamily();
        static /*0x7e91900*/ string get_processorType();
        static /*0x7e919b0*/ int get_processorCount();
        static /*0x7e91a00*/ int get_systemMemorySize();
        static /*0x7e91a50*/ string get_deviceUniqueIdentifier();
        static /*0x7e91b00*/ string get_deviceName();
        static /*0x7e91bb0*/ string get_deviceModel();
        static /*0x7e91c60*/ bool get_supportsAccelerometer();
        static /*0x7e91cb0*/ bool get_supportsGyroscope();
        static /*0x7e91d00*/ bool get_supportsLocationService();
        static /*0x7e91d50*/ bool get_supportsVibration();
        static /*0x7e91da0*/ UnityEngine.DeviceType get_deviceType();
        static /*0x7e91df0*/ int get_graphicsMemorySize();
        static /*0x7e91e40*/ string get_graphicsDeviceName();
        static /*0x7e91ef0*/ string get_graphicsDeviceVendor();
        static /*0x7e91fa0*/ int get_graphicsDeviceVendorID();
        static /*0x7e91ff0*/ UnityEngine.Rendering.GraphicsDeviceType get_graphicsDeviceType();
        static /*0x7e92040*/ bool get_graphicsUVStartsAtTop();
        static /*0x7e92090*/ string get_graphicsDeviceVersion();
        static /*0x7e92140*/ int get_graphicsShaderLevel();
        static /*0x7e92190*/ UnityEngine.Rendering.FoveatedRenderingCaps get_foveatedRenderingCaps();
        static /*0x7e921e0*/ bool get_hasHiddenSurfaceRemovalOnGPU();
        static /*0x7e92230*/ bool get_supportsShadows();
        static /*0x7e92280*/ bool get_supportsMotionVectors();
        static /*0x7e922d0*/ bool get_supports3DRenderTextures();
        static /*0x7e92320*/ UnityEngine.Rendering.CopyTextureSupport get_copyTextureSupport();
        static /*0x7e92370*/ bool get_supportsComputeShaders();
        static /*0x7e923c0*/ bool get_supportsRenderTargetArrayIndexFromVertexShader();
        static /*0x7e92410*/ bool get_supportsInstancing();
        static /*0x7e92460*/ bool get_supportsSparseTextures();
        static /*0x7e924b0*/ int get_supportedRenderTargetCount();
        static /*0x7e92500*/ int get_supportsMultisampledTextures();
        static /*0x7e92550*/ bool get_supportsMultisampledBackBuffer();
        static /*0x7e925a0*/ bool get_supportsMultisampleAutoResolve();
        static /*0x7e925f0*/ bool get_usesReversedZBuffer();
        static /*0x7e92640*/ bool IsValidEnumValue(System.Enum value);
        static /*0x7e92694*/ bool SupportsRenderTextureFormat(UnityEngine.RenderTextureFormat format);
        static /*0x7e927a4*/ bool SupportsTextureFormat(UnityEngine.TextureFormat format);
        static /*0x7e928b4*/ UnityEngine.NPOTSupport get_npotSupport();
        static /*0x7e92904*/ int get_maxTextureSize();
        static /*0x7e92954*/ int get_maxRenderTextureSize();
        static /*0x7e929a4*/ bool get_supportsGraphicsFence();
        static /*0x7e903d0*/ long get_maxGraphicsBufferSize();
        static /*0x7e92a1c*/ bool get_usesLoadStoreActions();
        static /*0x7e92a6c*/ UnityEngine.HDRDisplaySupportFlags get_hdrDisplaySupportFlags();
        static /*0x7e92abc*/ bool get_supportsMultiview();
        static /*0x7e92b0c*/ bool get_supportsStoreAndResolveAction();
        static /*0x7e92b5c*/ bool get_supportsMultisampleResolveDepth();
        static /*0x7e92bac*/ bool get_supportsMultisampleResolveStencil();
        static /*0x7e92bfc*/ bool get_supportsIndirectArgumentsBuffer();
        static /*0x7e91788*/ float GetBatteryLevel();
        static /*0x7e917d8*/ UnityEngine.BatteryStatus GetBatteryStatus();
        static /*0x7e91804*/ string GetOperatingSystem();
        static /*0x7e918d8*/ UnityEngine.OperatingSystemFamily GetOperatingSystemFamily();
        static /*0x7e91904*/ string GetProcessorType();
        static /*0x7e919d8*/ int GetProcessorCount();
        static /*0x7e91a28*/ int GetPhysicalMemoryMB();
        static /*0x7e91a54*/ string GetDeviceUniqueIdentifier();
        static /*0x7e91b04*/ string GetDeviceName();
        static /*0x7e91bb4*/ string GetDeviceModel();
        static /*0x7e91c88*/ bool SupportsAccelerometer();
        static /*0x7e91cd8*/ bool IsGyroAvailable();
        static /*0x7e91d28*/ bool SupportsLocationService();
        static /*0x7e91d78*/ bool SupportsVibration();
        static /*0x7e91dc8*/ UnityEngine.DeviceType GetDeviceType();
        static /*0x7e91e18*/ int GetGraphicsMemorySize();
        static /*0x7e91e44*/ string GetGraphicsDeviceName();
        static /*0x7e91ef4*/ string GetGraphicsDeviceVendor();
        static /*0x7e91fc8*/ int GetGraphicsDeviceVendorID();
        static /*0x7e92018*/ UnityEngine.Rendering.GraphicsDeviceType GetGraphicsDeviceType();
        static /*0x7e92068*/ bool GetGraphicsUVStartsAtTop();
        static /*0x7e92094*/ string GetGraphicsDeviceVersion();
        static /*0x7e92168*/ int GetGraphicsShaderLevel();
        static /*0x7e921b8*/ UnityEngine.Rendering.FoveatedRenderingCaps GetFoveatedRenderingCaps();
        static /*0x7e92208*/ bool HasHiddenSurfaceRemovalOnGPU();
        static /*0x7e92258*/ bool SupportsShadows();
        static /*0x7e922a8*/ bool SupportsMotionVectors();
        static /*0x7e922f8*/ bool Supports3DRenderTextures();
        static /*0x7e92348*/ UnityEngine.Rendering.CopyTextureSupport GetCopyTextureSupport();
        static /*0x7e92398*/ bool SupportsComputeShaders();
        static /*0x7e923e8*/ bool SupportsRenderTargetArrayIndexFromVertexShader();
        static /*0x7e92438*/ bool SupportsInstancing();
        static /*0x7e92488*/ bool SupportsSparseTextures();
        static /*0x7e924d8*/ int SupportedRenderTargetCount();
        static /*0x7e92528*/ int SupportsMultisampledTextures();
        static /*0x7e92578*/ bool SupportsMultisampledBackBuffer();
        static /*0x7e925c8*/ bool SupportsMultisampleAutoResolve();
        static /*0x7e92618*/ bool UsesReversedZBuffer();
        static /*0x7e92768*/ bool HasRenderTextureNative(UnityEngine.RenderTextureFormat format);
        static /*0x7e92878*/ bool SupportsTextureFormatNative(UnityEngine.TextureFormat format);
        static /*0x7e928dc*/ UnityEngine.NPOTSupport GetNPOTSupport();
        static /*0x7e9292c*/ int GetMaxTextureSize();
        static /*0x7e9297c*/ int GetMaxRenderTextureSize();
        static /*0x7e929cc*/ bool SupportsGPUFence();
        static /*0x7e929f4*/ long MaxGraphicsBufferSize();
        static /*0x7e92e2c*/ bool IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.GraphicsFormatUsage usage);
        static /*0x7e92e70*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.GraphicsFormatUsage usage);
        static /*0x7e92eb4*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat format);
        static /*0x7e92ef0*/ int GetRenderTextureSupportedMSAASampleCount(UnityEngine.RenderTextureDescriptor desc);
        static /*0x7e92a44*/ bool UsesLoadStoreActions();
        static /*0x7e92a94*/ UnityEngine.HDRDisplaySupportFlags GetHDRDisplaySupportFlags();
        static /*0x7e92ae4*/ bool SupportsMultiview();
        static /*0x7e92b34*/ bool SupportsStoreAndResolveAction();
        static /*0x7e92b84*/ bool SupportsMultisampleResolveDepth();
        static /*0x7e92bd4*/ bool SupportsMultisampleResolveStencil();
        static /*0x7e92c24*/ bool SupportsIndirectArgumentsBuffer();
        static /*0x7e92c4c*/ void GetOperatingSystem_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e92c88*/ void GetProcessorType_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e92cc4*/ void GetDeviceUniqueIdentifier_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e92d00*/ void GetDeviceName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e92d3c*/ void GetDeviceModel_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e92d78*/ void GetGraphicsDeviceName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e92db4*/ void GetGraphicsDeviceVendor_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e92df0*/ void GetGraphicsDeviceVersion_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e92f2c*/ int GetRenderTextureSupportedMSAASampleCount_Injected(ref UnityEngine.RenderTextureDescriptor desc);
    }

    class SystemClock
    {
        static /*0x0*/ System.DateTime s_Epoch;

        static /*0x7e92fb8*/ SystemClock();
        static /*0x7e92f68*/ System.DateTime get_now();
    }

    class Time
    {
        static /*0x7e93034*/ float get_time();
        static /*0x7e8ff04*/ double get_timeAsDouble();
        static /*0x7e9305c*/ Unity.IntegerTime.RationalTime get_timeAsRational();
        static /*0x7e930dc*/ float get_timeSinceLevelLoad();
        static /*0x7e93104*/ float get_deltaTime();
        static /*0x7e9312c*/ float get_fixedTime();
        static /*0x7e93154*/ float get_unscaledTime();
        static /*0x7e9317c*/ float get_fixedUnscaledTime();
        static /*0x7e931a4*/ float get_unscaledDeltaTime();
        static /*0x7e931cc*/ float get_fixedDeltaTime();
        static /*0x7e931f4*/ float get_smoothDeltaTime();
        static /*0x7e9321c*/ float get_timeScale();
        static /*0x7e93244*/ void set_timeScale(float value);
        static /*0x7e9327c*/ int get_frameCount();
        static /*0x7e932a4*/ int get_renderedFrameCount();
        static /*0x7e8fd28*/ float get_realtimeSinceStartup();
        static /*0x7e8fedc*/ double get_realtimeSinceStartupAsDouble();
        static /*0x7e932cc*/ bool get_inFixedTimeStep();
        static /*0x7e930a0*/ void get_timeAsRational_Injected(ref Unity.IntegerTime.RationalTime ret);
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

        static /*0x7e932f4*/ void Internal_Destroy(nint ptr);
        static /*0x7e9359c*/ nint TouchScreenKeyboard_InternalConstructorHelper(ref UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder);
        static /*0x7e937ec*/ bool get_isSupported();
        static /*0x7e938b0*/ bool get_disableInPlaceEditing();
        static /*0x7e938f8*/ bool get_isInPlaceEditingAllowed();
        static /*0x7e93964*/ bool IsInPlaceEditingAllowed();
        static /*0x7e9398c*/ UnityEngine.TouchScreenKeyboard Open(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit);
        static /*0x7e93a44*/ UnityEngine.TouchScreenKeyboard Open(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure);
        static /*0x7e93d8c*/ void set_hideInput(bool value);
        static /*0x7e93dc8*/ UnityEngine.TouchScreenKeyboard.InputFieldAppearance get_inputFieldAppearance();
        static /*0x7e9418c*/ void GetSelection(ref int start, ref int length);
        static /*0x7e94294*/ void SetSelection(int start, int length);
        static /*0x7e93798*/ nint TouchScreenKeyboard_InternalConstructorHelper_Injected(ref UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments arguments, ref UnityEngine.Bindings.ManagedSpanWrapper text, ref UnityEngine.Bindings.ManagedSpanWrapper textPlaceholder);
        static /*0x7e93ba0*/ void get_text_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7e93d48*/ void set_text_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
        static /*0x7e93e3c*/ bool get_active_Injected(nint _unity_self);
        static /*0x7e93ecc*/ void set_active_Injected(nint _unity_self, bool value);
        static /*0x7e93f5c*/ UnityEngine.TouchScreenKeyboard.Status get_status_Injected(nint _unity_self);
        static /*0x7e93fec*/ void set_characterLimit_Injected(nint _unity_self, int value);
        static /*0x7e9407c*/ bool get_canGetSelection_Injected(nint _unity_self);
        static /*0x7e94104*/ bool get_canSetSelection_Injected(nint _unity_self);
        /*0x7e93458*/ TouchScreenKeyboard(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit);
        /*0x7e93330*/ void Destroy();
        /*0x7e933c4*/ void Finalize();
        /*0x7e93ad0*/ string get_text();
        /*0x7e93be4*/ void set_text(string value);
        /*0x7e93df0*/ bool get_active();
        /*0x7e93e78*/ void set_active(bool value);
        /*0x7e93f10*/ UnityEngine.TouchScreenKeyboard.Status get_status();
        /*0x7e93f98*/ void set_characterLimit(int value);
        /*0x7e94030*/ bool get_canGetSelection();
        /*0x7e940b8*/ bool get_canSetSelection();
        /*0x7e94140*/ UnityEngine.RangeInt get_selection();
        /*0x7e941d0*/ void set_selection(UnityEngine.RangeInt value);

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
            static /*0x7e942d8*/ nint ConvertToNative(UnityEngine.TouchScreenKeyboard touchScreenKeyboard);
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

        static /*0x7e94a70*/ UINumericFieldsUtils();
        static /*0x7e942f0*/ bool TryConvertStringToDouble(string str, ref double value, ref UnityEngine.ExpressionEvaluator.Expression expr);
        static /*0x7e9448c*/ bool TryConvertStringToDouble(string str, string initialValueAsString, ref double value);
        static /*0x7e94594*/ bool TryConvertStringToFloat(string str, string initialValueAsString, ref float value);
        static /*0x7e94628*/ bool TryConvertStringToLong(string str, ref long value, ref UnityEngine.ExpressionEvaluator.Expression expr);
        static /*0x7e946ac*/ bool TryConvertStringToLong(string str, string initialValueAsString, ref long value);
        static /*0x7e947b0*/ bool TryConvertStringToULong(string str, ref ulong value, ref UnityEngine.ExpressionEvaluator.Expression expr);
        static /*0x7e94834*/ bool TryConvertStringToULong(string str, string initialValueAsString, ref ulong value);
        static /*0x7e94938*/ bool TryConvertStringToInt(string str, string initialValueAsString, ref int value);
        static /*0x7e949d4*/ bool TryConvertStringToUInt(string str, string initialValueAsString, ref uint value);
    }

    class NameFormatter
    {
        static /*0x7e94b8c*/ string FormatVariableName(string name);
        static /*0x7e94d04*/ void FormatVariableName_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
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
        /*0x7e94d48*/ void Add(UnityEngine.Object driver, UnityEngine.RectTransform rectTransform, UnityEngine.DrivenTransformProperties drivenProperties);
        /*0x7e94d4c*/ void Clear();
    }

    class RectTransform : UnityEngine.Transform
    {
        static /*0x0*/ UnityEngine.RectTransform.ReapplyDrivenProperties reapplyDrivenProperties;

        static /*0x7e94d50*/ void add_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value);
        static /*0x7e94e08*/ void remove_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value);
        static /*0x7e96510*/ void SendReapplyDrivenProperties(UnityEngine.RectTransform driven);
        static /*0x7e94f50*/ void get_rect_Injected(nint _unity_self, ref UnityEngine.Rect ret);
        static /*0x7e95018*/ void get_anchorMin_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e950dc*/ void set_anchorMin_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e951a4*/ void get_anchorMax_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e95268*/ void set_anchorMax_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e95330*/ void get_anchoredPosition_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e953f4*/ void set_anchoredPosition_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e954bc*/ void get_sizeDelta_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e95580*/ void set_sizeDelta_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e95648*/ void get_pivot_Injected(nint _unity_self, ref UnityEngine.Vector2 ret);
        static /*0x7e9570c*/ void set_pivot_Injected(nint _unity_self, ref UnityEngine.Vector2 value);
        static /*0x7e95c48*/ nint get_drivenByObject_Injected(nint _unity_self);
        static /*0x7e95d2c*/ void set_drivenByObject_Injected(nint _unity_self, nint value);
        static /*0x7e95de4*/ UnityEngine.DrivenTransformProperties get_drivenProperties_Injected(nint _unity_self);
        static /*0x7e95e9c*/ void set_drivenProperties_Injected(nint _unity_self, UnityEngine.DrivenTransformProperties value);
        static /*0x7e95f54*/ void ForceUpdateRectTransforms_Injected(nint _unity_self);
        /*0x7e966f8*/ RectTransform();
        /*0x7e94ec0*/ UnityEngine.Rect get_rect();
        /*0x7e94f94*/ UnityEngine.Vector2 get_anchorMin();
        /*0x7e9505c*/ void set_anchorMin(UnityEngine.Vector2 value);
        /*0x7e95120*/ UnityEngine.Vector2 get_anchorMax();
        /*0x7e951e8*/ void set_anchorMax(UnityEngine.Vector2 value);
        /*0x7e952ac*/ UnityEngine.Vector2 get_anchoredPosition();
        /*0x7e95374*/ void set_anchoredPosition(UnityEngine.Vector2 value);
        /*0x7e95438*/ UnityEngine.Vector2 get_sizeDelta();
        /*0x7e95500*/ void set_sizeDelta(UnityEngine.Vector2 value);
        /*0x7e955c4*/ UnityEngine.Vector2 get_pivot();
        /*0x7e9568c*/ void set_pivot(UnityEngine.Vector2 value);
        /*0x7e95750*/ UnityEngine.Vector3 get_anchoredPosition3D();
        /*0x7e95818*/ void set_anchoredPosition3D(UnityEngine.Vector3 value);
        /*0x7e958d4*/ UnityEngine.Vector2 get_offsetMin();
        /*0x7e95928*/ void set_offsetMin(UnityEngine.Vector2 value);
        /*0x7e95a1c*/ UnityEngine.Vector2 get_offsetMax();
        /*0x7e95abc*/ void set_offsetMax(UnityEngine.Vector2 value);
        /*0x7e95bb8*/ UnityEngine.Object get_drivenByObject();
        /*0x7e95c84*/ void set_drivenByObject(UnityEngine.Object value);
        /*0x7e95d70*/ UnityEngine.DrivenTransformProperties get_drivenProperties();
        /*0x7e95e20*/ void set_drivenProperties(UnityEngine.DrivenTransformProperties value);
        /*0x7e95ee0*/ void ForceUpdateRectTransforms();
        /*0x7e95f90*/ void GetLocalCorners(UnityEngine.Vector3[] fourCornersArray);
        /*0x7e96070*/ void GetWorldCorners(UnityEngine.Vector3[] fourCornersArray);
        /*0x7e96224*/ void SetInsetAndSizeFromParentEdge(UnityEngine.RectTransform.Edge edge, float inset, float size);
        /*0x7e96334*/ void SetSizeWithCurrentAnchors(UnityEngine.RectTransform.Axis axis, float size);
        /*0x7e9657c*/ UnityEngine.Rect GetRectInParentSpace();
        /*0x7e9642c*/ UnityEngine.Vector2 GetParentSize();

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
            /*0x7e96708*/ ReapplyDrivenProperties(object object, nint method);
            /*0x7e967b8*/ void Invoke(UnityEngine.RectTransform driven);
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
        static /*0x7e96860*/ void get_position_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e96930*/ void set_position_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7e96974*/ void get_localPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e969b8*/ void set_localPosition_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7e96a98*/ void GetLocalEulerAngles_Injected(nint _unity_self, UnityEngine.RotationOrder order, ref UnityEngine.Vector3 ret);
        static /*0x7e96b80*/ void SetLocalEulerAngles_Injected(nint _unity_self, ref UnityEngine.Vector3 euler, UnityEngine.RotationOrder order);
        static /*0x7e96c60*/ void SetLocalEulerHint_Injected(nint _unity_self, ref UnityEngine.Vector3 euler);
        static /*0x7e97234*/ void get_rotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7e97278*/ void set_rotation_Injected(nint _unity_self, ref UnityEngine.Quaternion value);
        static /*0x7e972bc*/ void get_localRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion ret);
        static /*0x7e97300*/ void set_localRotation_Injected(nint _unity_self, ref UnityEngine.Quaternion value);
        static /*0x7e9743c*/ int GetRotationOrderInternal_Injected(nint _unity_self);
        static /*0x7e97478*/ void SetRotationOrderInternal_Injected(nint _unity_self, UnityEngine.RotationOrder rotationOrder);
        static /*0x7e97550*/ void get_localScale_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e97620*/ void set_localScale_Injected(nint _unity_self, ref UnityEngine.Vector3 value);
        static /*0x7e977b4*/ nint GetParent_Injected(nint _unity_self);
        static /*0x7e978a8*/ void SetParent_Injected(nint _unity_self, nint parent, bool worldPositionStays);
        static /*0x7e979a0*/ void get_worldToLocalMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e979e4*/ void get_localToWorldMatrix_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 ret);
        static /*0x7e97ac0*/ void SetPositionAndRotation_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
        static /*0x7e97bac*/ void SetLocalPositionAndRotation_Injected(nint _unity_self, ref UnityEngine.Vector3 localPosition, ref UnityEngine.Quaternion localRotation);
        static /*0x7e97c8c*/ void GetPositionAndRotation_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
        static /*0x7e97d6c*/ void GetLocalPositionAndRotation_Injected(nint _unity_self, ref UnityEngine.Vector3 localPosition, ref UnityEngine.Quaternion localRotation);
        static /*0x7e98318*/ void RotateAroundInternal_Injected(nint _unity_self, ref UnityEngine.Vector3 axis, float angle);
        static /*0x7e9878c*/ void Internal_LookAt_Injected(nint _unity_self, ref UnityEngine.Vector3 worldPosition, ref UnityEngine.Vector3 worldUp);
        static /*0x7e987e0*/ void TransformDirection_Injected(nint _unity_self, ref UnityEngine.Vector3 direction, ref UnityEngine.Vector3 ret);
        static /*0x7e98968*/ void TransformDirectionsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper directions, ref UnityEngine.Bindings.ManagedSpanWrapper transformedDirections);
        static /*0x7e98ba0*/ void InverseTransformDirection_Injected(nint _unity_self, ref UnityEngine.Vector3 direction, ref UnityEngine.Vector3 ret);
        static /*0x7e98d28*/ void InverseTransformDirectionsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper directions, ref UnityEngine.Bindings.ManagedSpanWrapper transformedDirections);
        static /*0x7e98f60*/ void TransformVector_Injected(nint _unity_self, ref UnityEngine.Vector3 vector, ref UnityEngine.Vector3 ret);
        static /*0x7e990e8*/ void TransformVectorsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper vectors, ref UnityEngine.Bindings.ManagedSpanWrapper transformedVectors);
        static /*0x7e99320*/ void InverseTransformVector_Injected(nint _unity_self, ref UnityEngine.Vector3 vector, ref UnityEngine.Vector3 ret);
        static /*0x7e994a8*/ void InverseTransformVectorsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper vectors, ref UnityEngine.Bindings.ManagedSpanWrapper transformedVectors);
        static /*0x7e996e0*/ void TransformPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x7e99868*/ void TransformPointsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper positions, ref UnityEngine.Bindings.ManagedSpanWrapper transformedPositions);
        static /*0x7e99aa0*/ void InverseTransformPoint_Injected(nint _unity_self, ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        static /*0x7e99c28*/ void InverseTransformPointsInternal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper positions, ref UnityEngine.Bindings.ManagedSpanWrapper transformedPositions);
        static /*0x7e99e54*/ nint GetRoot_Injected(nint _unity_self);
        static /*0x7e99f04*/ int get_childCount_Injected(nint _unity_self);
        static /*0x7e99fb4*/ void DetachChildren_Injected(nint _unity_self);
        static /*0x7e9a064*/ void SetAsFirstSibling_Injected(nint _unity_self);
        static /*0x7e9a114*/ void SetAsLastSibling_Injected(nint _unity_self);
        static /*0x7e9a1cc*/ void SetSiblingIndex_Injected(nint _unity_self, int index);
        static /*0x7e9a2c8*/ void MoveAfterSibling_Injected(nint _unity_self, nint transform, bool notifyEditorAndMarkDirty);
        static /*0x7e9a390*/ int GetSiblingIndex_Injected(nint _unity_self);
        static /*0x7e9a59c*/ nint FindRelativeTransformWithPath_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper path, bool isActiveOnly);
        static /*0x7e9a6bc*/ void SendTransformChangedScale_Injected(nint _unity_self);
        static /*0x7e9a78c*/ void get_lossyScale_Injected(nint _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x7e9a888*/ bool IsChildOf_Injected(nint _unity_self, nint parent);
        static /*0x7e9a940*/ bool get_hasChanged_Injected(nint _unity_self);
        static /*0x7e9a9f8*/ void set_hasChanged_Injected(nint _unity_self, bool value);
        static /*0x7e9ab84*/ void RotateAround_Injected(nint _unity_self, ref UnityEngine.Vector3 axis, float angle);
        static /*0x7e9ac74*/ void RotateAroundLocal_Injected(nint _unity_self, ref UnityEngine.Vector3 axis, float angle);
        static /*0x7e9ad68*/ nint GetChild_Injected(nint _unity_self, int index);
        static /*0x7e9ae20*/ int GetChildCount_Injected(nint _unity_self);
        static /*0x7e9af54*/ int internal_getHierarchyCapacity_Injected(nint _unity_self);
        static /*0x7e9af90*/ void internal_setHierarchyCapacity_Injected(nint _unity_self, int value);
        static /*0x7e9b04c*/ int internal_getHierarchyCount_Injected(nint _unity_self);
        static /*0x7e9b0fc*/ bool IsNonUniformScaleTransform_Injected(nint _unity_self);
        static /*0x7e9b234*/ void SetConstrainProportionsScale_Injected(nint _unity_self, bool isLinked);
        static /*0x7e9b278*/ bool IsConstrainProportionsScale_Injected(nint _unity_self);
        /*0x7e96700*/ Transform();
        /*0x7e967cc*/ UnityEngine.Vector3 get_position();
        /*0x7e968a4*/ void set_position(UnityEngine.Vector3 value);
        /*0x7e95784*/ UnityEngine.Vector3 get_localPosition();
        /*0x7e95848*/ void set_localPosition(UnityEngine.Vector3 value);
        /*0x7e969fc*/ UnityEngine.Vector3 GetLocalEulerAngles(UnityEngine.RotationOrder order);
        /*0x7e96aec*/ void SetLocalEulerAngles(UnityEngine.Vector3 euler, UnityEngine.RotationOrder order);
        /*0x7e96bd4*/ void SetLocalEulerHint(UnityEngine.Vector3 euler);
        /*0x7e96ca4*/ UnityEngine.Vector3 get_eulerAngles();
        /*0x7e96d64*/ void set_eulerAngles(UnityEngine.Vector3 value);
        /*0x7e96e20*/ UnityEngine.Vector3 get_localEulerAngles();
        /*0x7e96ee0*/ void set_localEulerAngles(UnityEngine.Vector3 value);
        /*0x7e96f9c*/ UnityEngine.Vector3 get_right();
        /*0x7e97018*/ void set_right(UnityEngine.Vector3 value);
        /*0x7e9709c*/ UnityEngine.Vector3 get_up();
        /*0x7e97118*/ void set_up(UnityEngine.Vector3 value);
        /*0x7e9719c*/ UnityEngine.Vector3 get_forward();
        /*0x7e97218*/ void set_forward(UnityEngine.Vector3 value);
        /*0x7e96cd4*/ UnityEngine.Quaternion get_rotation();
        /*0x7e96d94*/ void set_rotation(UnityEngine.Quaternion value);
        /*0x7e96e50*/ UnityEngine.Quaternion get_localRotation();
        /*0x7e96f10*/ void set_localRotation(UnityEngine.Quaternion value);
        /*0x7e97344*/ UnityEngine.RotationOrder get_rotationOrder();
        /*0x7e973bc*/ void set_rotationOrder(UnityEngine.RotationOrder value);
        /*0x7e97348*/ int GetRotationOrderInternal();
        /*0x7e973c0*/ void SetRotationOrderInternal(UnityEngine.RotationOrder rotationOrder);
        /*0x7e974bc*/ UnityEngine.Vector3 get_localScale();
        /*0x7e97594*/ void set_localScale(UnityEngine.Vector3 value);
        /*0x7e966f4*/ UnityEngine.Transform get_parent();
        /*0x7e97668*/ void set_parent(UnityEngine.Transform value);
        /*0x7e97664*/ UnityEngine.Transform get_parentInternal();
        /*0x7e97714*/ void set_parentInternal(UnityEngine.Transform value);
        /*0x7e9771c*/ UnityEngine.Transform GetParent();
        /*0x7e977ac*/ void SetParent(UnityEngine.Transform p);
        /*0x7e977f0*/ void SetParent(UnityEngine.Transform parent, bool worldPositionStays);
        /*0x7e978fc*/ UnityEngine.Matrix4x4 get_worldToLocalMatrix();
        /*0x7e96180*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
        /*0x7e97a28*/ void SetPositionAndRotation(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        /*0x7e97b14*/ void SetLocalPositionAndRotation(UnityEngine.Vector3 localPosition, UnityEngine.Quaternion localRotation);
        /*0x7e97c00*/ void GetPositionAndRotation(ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
        /*0x7e97ce0*/ void GetLocalPositionAndRotation(ref UnityEngine.Vector3 localPosition, ref UnityEngine.Quaternion localRotation);
        /*0x7e97dc0*/ void Translate(UnityEngine.Vector3 translation, UnityEngine.Space relativeTo);
        /*0x7e97ee8*/ void Translate(UnityEngine.Vector3 translation);
        /*0x7e97ef0*/ void Translate(float x, float y, float z, UnityEngine.Space relativeTo);
        /*0x7e97ef4*/ void Translate(float x, float y, float z);
        /*0x7e97efc*/ void Translate(UnityEngine.Vector3 translation, UnityEngine.Transform relativeTo);
        /*0x7e97fdc*/ void Translate(float x, float y, float z, UnityEngine.Transform relativeTo);
        /*0x7e97fe0*/ void Rotate(UnityEngine.Vector3 eulers, UnityEngine.Space relativeTo);
        /*0x7e98268*/ void Rotate(UnityEngine.Vector3 eulers);
        /*0x7e98270*/ void Rotate(float xAngle, float yAngle, float zAngle, UnityEngine.Space relativeTo);
        /*0x7e98274*/ void Rotate(float xAngle, float yAngle, float zAngle);
        /*0x7e9827c*/ void RotateAroundInternal(UnityEngine.Vector3 axis, float angle);
        /*0x7e9836c*/ void Rotate(UnityEngine.Vector3 axis, float angle, UnityEngine.Space relativeTo);
        /*0x7e983f8*/ void Rotate(UnityEngine.Vector3 axis, float angle);
        /*0x7e98400*/ void RotateAround(UnityEngine.Vector3 point, UnityEngine.Vector3 axis, float angle);
        /*0x7e984c4*/ void LookAt(UnityEngine.Transform target, UnityEngine.Vector3 worldUp);
        /*0x7e98584*/ void LookAt(UnityEngine.Transform target);
        /*0x7e98580*/ void LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp);
        /*0x7e98710*/ void LookAt(UnityEngine.Vector3 worldPosition);
        /*0x7e98678*/ void Internal_LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp);
        /*0x7e97e48*/ UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3 direction);
        /*0x7e98834*/ UnityEngine.Vector3 TransformDirection(float x, float y, float z);
        /*0x7e98838*/ void TransformDirectionsInternal(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections);
        /*0x7e989bc*/ void TransformDirections(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections);
        /*0x7e98a84*/ void TransformDirections(System.Span<UnityEngine.Vector3> directions);
        /*0x7e98b00*/ UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3 direction);
        /*0x7e98bf4*/ UnityEngine.Vector3 InverseTransformDirection(float x, float y, float z);
        /*0x7e98bf8*/ void InverseTransformDirectionsInternal(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections);
        /*0x7e98d7c*/ void InverseTransformDirections(System.ReadOnlySpan<UnityEngine.Vector3> directions, System.Span<UnityEngine.Vector3> transformedDirections);
        /*0x7e98e44*/ void InverseTransformDirections(System.Span<UnityEngine.Vector3> directions);
        /*0x7e98ec0*/ UnityEngine.Vector3 TransformVector(UnityEngine.Vector3 vector);
        /*0x7e98fb4*/ UnityEngine.Vector3 TransformVector(float x, float y, float z);
        /*0x7e98fb8*/ void TransformVectorsInternal(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors);
        /*0x7e9913c*/ void TransformVectors(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors);
        /*0x7e99204*/ void TransformVectors(System.Span<UnityEngine.Vector3> vectors);
        /*0x7e99280*/ UnityEngine.Vector3 InverseTransformVector(UnityEngine.Vector3 vector);
        /*0x7e99374*/ UnityEngine.Vector3 InverseTransformVector(float x, float y, float z);
        /*0x7e99378*/ void InverseTransformVectorsInternal(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors);
        /*0x7e994fc*/ void InverseTransformVectors(System.ReadOnlySpan<UnityEngine.Vector3> vectors, System.Span<UnityEngine.Vector3> transformedVectors);
        /*0x7e995c4*/ void InverseTransformVectors(System.Span<UnityEngine.Vector3> vectors);
        /*0x7e99640*/ UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 position);
        /*0x7e99734*/ UnityEngine.Vector3 TransformPoint(float x, float y, float z);
        /*0x7e99738*/ void TransformPointsInternal(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions);
        /*0x7e998bc*/ void TransformPoints(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions);
        /*0x7e99984*/ void TransformPoints(System.Span<UnityEngine.Vector3> positions);
        /*0x7e99a00*/ UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 position);
        /*0x7e99af4*/ UnityEngine.Vector3 InverseTransformPoint(float x, float y, float z);
        /*0x7e99af8*/ void InverseTransformPointsInternal(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions);
        /*0x7e99c7c*/ void InverseTransformPoints(System.ReadOnlySpan<UnityEngine.Vector3> positions, System.Span<UnityEngine.Vector3> transformedPositions);
        /*0x7e99d44*/ void InverseTransformPoints(System.Span<UnityEngine.Vector3> positions);
        /*0x7e99dc0*/ UnityEngine.Transform get_root();
        /*0x7e99dc4*/ UnityEngine.Transform GetRoot();
        /*0x7e99e90*/ int get_childCount();
        /*0x7e99f40*/ void DetachChildren();
        /*0x7e99ff0*/ void SetAsFirstSibling();
        /*0x7e9a0a0*/ void SetAsLastSibling();
        /*0x7e9a150*/ void SetSiblingIndex(int index);
        /*0x7e9a210*/ void MoveAfterSibling(UnityEngine.Transform transform, bool notifyEditorAndMarkDirty);
        /*0x7e9a31c*/ int GetSiblingIndex();
        /*0x7e9a3cc*/ UnityEngine.Transform FindRelativeTransformWithPath(string path, bool isActiveOnly);
        /*0x7e9a5f0*/ UnityEngine.Transform Find(string n);
        /*0x7e9a648*/ void SendTransformChangedScale();
        /*0x7e9a6f8*/ UnityEngine.Vector3 get_lossyScale();
        /*0x7e9a7d0*/ bool IsChildOf(UnityEngine.Transform parent);
        /*0x7e9a8cc*/ bool get_hasChanged();
        /*0x7e9a97c*/ void set_hasChanged(bool value);
        /*0x7e9aa3c*/ UnityEngine.Transform FindChild(string n);
        /*0x7e9aa40*/ System.Collections.IEnumerator GetEnumerator();
        /*0x7e9aae8*/ void RotateAround(UnityEngine.Vector3 axis, float angle);
        /*0x7e9abd8*/ void RotateAroundLocal(UnityEngine.Vector3 axis, float angle);
        /*0x7e9acc8*/ UnityEngine.Transform GetChild(int index);
        /*0x7e9adac*/ int GetChildCount();
        /*0x7e9ae5c*/ int get_hierarchyCapacity();
        /*0x7e9aed4*/ void set_hierarchyCapacity(int value);
        /*0x7e9ae60*/ int internal_getHierarchyCapacity();
        /*0x7e9aed8*/ void internal_setHierarchyCapacity(int value);
        /*0x7e9afd4*/ int get_hierarchyCount();
        /*0x7e9afd8*/ int internal_getHierarchyCount();
        /*0x7e9b088*/ bool IsNonUniformScaleTransform();
        /*0x7e9b138*/ bool get_constrainProportionsScale();
        /*0x7e9b1b0*/ void set_constrainProportionsScale(bool value);
        /*0x7e9b1b8*/ void SetConstrainProportionsScale(bool isLinked);
        /*0x7e9b13c*/ bool IsConstrainProportionsScale();

        class Enumerator : System.Collections.IEnumerator
        {
            /*0x10*/ UnityEngine.Transform outer;
            /*0x18*/ int currentIndex;

            /*0x7e9aab0*/ Enumerator(UnityEngine.Transform outer);
            /*0x7e9b2b4*/ object get_Current();
            /*0x7e9b2d4*/ bool MoveNext();
            /*0x7e9b308*/ void Reset();
        }
    }

    namespace _Scripting
    {
        namespace APIUpdating
        {
            class APIUpdaterRuntimeHelpers
            {
                static /*0x7e9b314*/ bool GetMovedFromAttributeDataForType(System.Type sourceType, ref string assembly, ref string nsp, ref string klass);
                static /*0x7e9b484*/ bool GetObsoleteTypeRedirection(System.Type sourceType, ref string assemblyName, ref string nsp, ref string className);
            }
        }
    }

    namespace Profiling
    {
        class Profiler
        {
            static /*0x7e9b79c*/ bool get_enabled();
            static /*0x7e9b7c4*/ long GetRuntimeMemorySizeLong(UnityEngine.Object o);
            static /*0x7e9b888*/ long GetMonoHeapSizeLong();
            static /*0x7e9b8b0*/ long GetMonoUsedSizeLong();
            static /*0x7e9b8d8*/ long GetTotalAllocatedMemoryLong();
            static /*0x7e9b900*/ long GetTotalReservedMemoryLong();
            static /*0x7e9b84c*/ long GetRuntimeMemorySizeLong_Injected(nint o);
        }

        class Recorder
        {
            static Unity.Profiling.ProfilerRecorderOptions s_RecorderDefaultOptions = 153;
            static /*0x0*/ UnityEngine.Profiling.Recorder s_InvalidRecorder;
            /*0x10*/ Unity.Profiling.ProfilerRecorder m_RecorderCPU;
            /*0x18*/ Unity.Profiling.ProfilerRecorder m_RecorderGPU;

            static /*0x7e9bc38*/ Recorder();
            /*0x7e9b928*/ Recorder();
            /*0x7e9b930*/ Recorder(Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle handle);
            /*0x7e9b9e8*/ void Finalize();
            /*0x7e9ba94*/ bool get_enabled();
            /*0x7e9baa0*/ void set_enabled(bool value);
            /*0x7e9bb18*/ long get_elapsedNanoseconds();
            /*0x7e9bb4c*/ long get_gpuElapsedNanoseconds();
            /*0x7e9bb80*/ int get_sampleBlockCount();
            /*0x7e9bbdc*/ int get_gpuSampleBlockCount();
            /*0x7e9baa8*/ void SetEnabled(bool state);
        }

        class Sampler
        {
            static /*0x0*/ UnityEngine.Profiling.Sampler s_InvalidSampler;
            /*0x10*/ nint m_Ptr;

            static /*0x7e9bd64*/ Sampler();
            /*0x7e9bca0*/ Sampler();
            /*0x7e9bca8*/ Sampler(nint ptr);
            /*0x7e9bcd0*/ bool get_isValid();
            /*0x7e9bce0*/ UnityEngine.Profiling.Recorder GetRecorder();
        }

        class CustomSampler : UnityEngine.Profiling.Sampler
        {
            static /*0x0*/ UnityEngine.Profiling.CustomSampler s_InvalidCustomSampler;

            static /*0x7e9bf44*/ CustomSampler();
            static /*0x7e9be90*/ UnityEngine.Profiling.CustomSampler Create(string name, bool collectGpuData);
            /*0x7e9bdcc*/ CustomSampler();
            /*0x7e9be24*/ CustomSampler(nint ptr);

            class BindingsMarshaller
            {
                static /*0x7e9bfa8*/ nint ConvertToNative(UnityEngine.Profiling.CustomSampler customSampler);
            }
        }
    }

    namespace Jobs
    {
        interface IJobParallelForTransform
        {
            /*0x3910ae8*/ void Execute(int index, UnityEngine.Jobs.TransformAccess transform);
        }

        class IJobParallelForTransformExtensions
        {
            static nint GetReflectionData<T>();
            static /*0x3910ae8*/ Unity.Jobs.JobHandle Schedule<T>(T jobData, UnityEngine.Jobs.TransformAccessArray transforms, Unity.Jobs.JobHandle dependsOn);

            struct TransformParallelForLoopStruct<T>
            {
                static /*0x0*/ Unity.Collections.LowLevel.Unsafe.BurstLike.SharedStatic<nint> jobReflectionData;

                static /*0x383e7a0*/ TransformParallelForLoopStruct();
                static /*0x383e7a0*/ void Initialize();
                static /*0x3843798*/ void Execute(ref T jobData, nint jobData2, nint bufferRangePatchData, ref Unity.Jobs.LowLevel.Unsafe.JobRanges ranges, int jobIndex);

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

            static /*0x7e9c01c*/ void GetPosition(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Vector3 p);
            static /*0x7e9c0b8*/ void GetRotation(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Quaternion r);
            static /*0x7e9c158*/ void GetLocalScale(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Vector3 r);
            static /*0x7e9c208*/ void GetLocalToWorldMatrix(ref UnityEngine.Jobs.TransformAccess access, ref UnityEngine.Matrix4x4 m);
            /*0x7e9bfc0*/ UnityEngine.Vector3 get_position();
            /*0x7e9c060*/ UnityEngine.Quaternion get_rotation();
            /*0x7e9c0fc*/ UnityEngine.Vector3 get_localScale();
            /*0x7e9c19c*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
        }

        struct TransformAccessArray : System.IDisposable
        {
            /*0x10*/ nint m_TransformArray;

            static /*0x7e9c260*/ void Allocate(int capacity, int desiredJobCount, ref UnityEngine.Jobs.TransformAccessArray array);
            static /*0x7e9c2c4*/ nint Create(int capacity, int desiredJobCount);
            static /*0x7e9c370*/ void DestroyTransformAccessArray(nint transformArray);
            static /*0x7e9c4b8*/ void Add(nint transformArrayIntPtr, UnityEngine.Transform transform);
            static /*0x7e9c590*/ void RemoveAtSwapBack(nint transformArrayIntPtr, int index);
            static /*0x7e9c618*/ nint GetSortedTransformAccess(nint transformArrayIntPtr);
            static /*0x7e9c654*/ nint GetSortedToUserIndex(nint transformArrayIntPtr);
            static /*0x7e9c474*/ int GetLength(nint transformArrayIntPtr);
            static /*0x7e9c3bc*/ UnityEngine.Transform GetTransform(nint transformArrayIntPtr, int index);
            static /*0x7e9c5d4*/ void Add_Injected(nint transformArrayIntPtr, nint transform);
            static /*0x7e9c690*/ nint GetTransform_Injected(nint transformArrayIntPtr, int index);
            /*0x7e9c24c*/ TransformAccessArray(int capacity, int desiredJobCount);
            /*0x7e9c308*/ bool get_isCreated();
            /*0x7e9c318*/ void Dispose();
            /*0x7e9c3ac*/ nint GetTransformAccessArrayForSchedule();
            /*0x7e9c3b4*/ UnityEngine.Transform get_Item(int index);
            /*0x7e9c438*/ int get_length();
            /*0x7e9c4b0*/ void Add(UnityEngine.Transform transform);
            /*0x7e9c54c*/ void RemoveAtSwapBack(int index);
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
            static /*0x7e9c6d4*/ string TidyAssemblyTypeName(string assemblyTypeName);
        }

        class ArgumentCache : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Object m_ObjectArgument;
            /*0x18*/ string m_ObjectArgumentAssemblyTypeName;
            /*0x20*/ int m_IntArgument;
            /*0x24*/ float m_FloatArgument;
            /*0x28*/ string m_StringArgument;
            /*0x30*/ bool m_BoolArgument;

            /*0x7e9c978*/ ArgumentCache();
            /*0x7e9c900*/ UnityEngine.Object get_unityObjectArgument();
            /*0x7e9c908*/ string get_unityObjectArgumentAssemblyTypeName();
            /*0x7e9c910*/ int get_intArgument();
            /*0x7e9c918*/ float get_floatArgument();
            /*0x7e9c920*/ string get_stringArgument();
            /*0x7e9c928*/ bool get_boolArgument();
            /*0x7e9c930*/ void OnBeforeSerialize();
            /*0x7e9c954*/ void OnAfterDeserialize();
        }

        class BaseInvokableCall
        {
            static /*0x3840c74*/ void ThrowOnInvalidArg<T>(object arg);
            static /*0x7e9ca7c*/ bool AllowInvoke(System.Delegate delegate);
            /*0x7e9c980*/ BaseInvokableCall();
            /*0x7e9c988*/ BaseInvokableCall(object target, System.Reflection.MethodInfo function);
            /*0x3816710*/ void Invoke(object[] args);
            /*0x3814200*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall : UnityEngine.Events.BaseInvokableCall
        {
            /*0x10*/ UnityEngine.Events.UnityAction Delegate;

            /*0x7e9cc58*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x7e9cd2c*/ InvokableCall(UnityEngine.Events.UnityAction action);
            /*0x7e9cb20*/ void add_Delegate(UnityEngine.Events.UnityAction value);
            /*0x7e9cbbc*/ void remove_Delegate(UnityEngine.Events.UnityAction value);
            /*0x7e9cd58*/ void Invoke(object[] args);
            /*0x7e9cd94*/ void Invoke();
            /*0x7e9cdd0*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1> Delegate;

            /*0x3816810*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x3816710*/ InvokableCall(UnityEngine.Events.UnityAction<T1> action);
            /*0x3816710*/ void add_Delegate(UnityEngine.Events.UnityAction<T1> value);
            /*0x3816710*/ void remove_Delegate(UnityEngine.Events.UnityAction<T1> value);
            /*0x3816710*/ void Invoke(object[] args);
            /*0x3910ae8*/ void Invoke(T1 args0);
            /*0x3814200*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2> Delegate;

            /*0x3816810*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x3816710*/ InvokableCall(UnityEngine.Events.UnityAction<T1, T2> action);
            /*0x3816710*/ void add_Delegate(UnityEngine.Events.UnityAction<T1, T2> value);
            /*0x3816710*/ void remove_Delegate(UnityEngine.Events.UnityAction<T1, T2> value);
            /*0x3816710*/ void Invoke(object[] args);
            /*0x3910ae8*/ void Invoke(T1 args0, T2 args1);
            /*0x3814200*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2, T3> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2, T3> Delegate;

            /*0x3816810*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x3816710*/ InvokableCall(UnityEngine.Events.UnityAction<T1, T2, T3> action);
            /*0x3816710*/ void add_Delegate(UnityEngine.Events.UnityAction<T1, T2, T3> value);
            /*0x3816710*/ void remove_Delegate(UnityEngine.Events.UnityAction<T1, T2, T3> value);
            /*0x3816710*/ void Invoke(object[] args);
            /*0x3910ae8*/ void Invoke(T1 args0, T2 args1, T3 args2);
            /*0x3814200*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2, T3, T4> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2, T3, T4> Delegate;

            /*0x3816810*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x3816710*/ InvokableCall(UnityEngine.Events.UnityAction<T1, T2, T3, T4> action);
            /*0x3816710*/ void add_Delegate(UnityEngine.Events.UnityAction<T1, T2, T3, T4> value);
            /*0x3816710*/ void remove_Delegate(UnityEngine.Events.UnityAction<T1, T2, T3, T4> value);
            /*0x3816710*/ void Invoke(object[] args);
            /*0x3814200*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class CachedInvokableCall<T> : UnityEngine.Events.InvokableCall<T>
        {
            /*0x0*/ T m_Arg1;

            /*0x3910ae8*/ CachedInvokableCall(UnityEngine.Object target, System.Reflection.MethodInfo theFunction, T argument);
            /*0x3816710*/ void Invoke(object[] args);
            /*0x3910ae8*/ void Invoke(T arg0);
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

            static /*0x7e9d3d8*/ UnityEngine.Events.BaseInvokableCall GetObjectCall(UnityEngine.Object target, System.Reflection.MethodInfo method, UnityEngine.Events.ArgumentCache arguments);
            /*0x7e9d894*/ PersistentCall();
            /*0x7e9ce1c*/ UnityEngine.Object get_target();
            /*0x7e9ce24*/ string get_targetAssemblyTypeName();
            /*0x7e9cedc*/ string get_methodName();
            /*0x7e9cee4*/ UnityEngine.Events.PersistentListenerMode get_mode();
            /*0x7e9ceec*/ UnityEngine.Events.ArgumentCache get_arguments();
            /*0x7e9cef4*/ bool IsValid();
            /*0x7e9cf30*/ UnityEngine.Events.BaseInvokableCall GetRuntimeCall(UnityEngine.Events.UnityEventBase theEvent);
            /*0x7e9d84c*/ void OnBeforeSerialize();
            /*0x7e9d870*/ void OnAfterDeserialize();
        }

        class PersistentCallGroup
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Events.PersistentCall> m_Calls;

            /*0x7e9d90c*/ PersistentCallGroup();
            /*0x7e9d994*/ void Initialize(UnityEngine.Events.InvokableCallList invokableList, UnityEngine.Events.UnityEventBase unityEventBase);
        }

        class InvokableCallList
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_PersistentCalls;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_RuntimeCalls;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_ExecutingCalls;
            /*0x28*/ bool m_NeedsUpdate;

            /*0x7e9e1a8*/ InvokableCallList();
            /*0x7e9dbd8*/ int get_Count();
            /*0x7e9db24*/ void AddPersistentInvokableCall(UnityEngine.Events.BaseInvokableCall call);
            /*0x7e9dc30*/ void AddListener(UnityEngine.Events.BaseInvokableCall call);
            /*0x7e9dce4*/ void RemoveListener(object targetObj, System.Reflection.MethodInfo method);
            /*0x7e9df64*/ void Clear();
            /*0x7e9e02c*/ void ClearPersistent();
            /*0x7e9e0f4*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke();
        }

        class UnityEventBase : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Events.InvokableCallList m_Calls;
            /*0x18*/ UnityEngine.Events.PersistentCallGroup m_PersistentCalls;
            /*0x20*/ bool m_CallsDirty;

            static /*0x7e9e5fc*/ System.Reflection.MethodInfo GetValidMethodInfo(System.Type objectType, string functionName, System.Type[] argumentTypes);
            /*0x7e9e280*/ UnityEventBase();
            /*0x7e9e32c*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x7e9e358*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x3814b90*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x3814b90*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x7e9d218*/ System.Reflection.MethodInfo FindMethod(UnityEngine.Events.PersistentCall call);
            /*0x7e9e35c*/ System.Reflection.MethodInfo FindMethod(string name, System.Type listenerType, UnityEngine.Events.PersistentListenerMode mode, System.Type argumentType);
            /*0x7e9e7a8*/ int GetCallsCount();
            /*0x7e9e330*/ void DirtyPersistentCalls();
            /*0x7e9e7c0*/ void RebuildPersistentCallsIfNeeded();
            /*0x7e9e7f4*/ void AddCall(UnityEngine.Events.BaseInvokableCall call);
            /*0x7e9e80c*/ void RemoveListener(object targetObj, System.Reflection.MethodInfo method);
            /*0x7e9e824*/ void RemoveAllListeners();
            /*0x7e9e83c*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke();
            /*0x7e9e85c*/ string ToString();
        }

        class UnityAction : System.MulticastDelegate
        {
            /*0x7e9e8e0*/ UnityAction(object object, nint method);
            /*0x7e9e97c*/ void Invoke();
        }

        class UnityEvent : UnityEngine.Events.UnityEventBase
        {
            /*0x28*/ object[] m_InvokeArray;

            static /*0x7e9e9dc*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction action);
            /*0x7e9e990*/ UnityEvent();
            /*0x7e9e9b0*/ void AddListener(UnityEngine.Events.UnityAction call);
            /*0x7e9ea40*/ void RemoveListener(UnityEngine.Events.UnityAction call);
            /*0x7e9ea84*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x7e9eae8*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x7e9eb50*/ void Invoke();
        }

        class UnityAction<T0> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x3910ae8*/ void Invoke(T0 arg0);
        }

        class UnityEvent<T0> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            static /*0x38379c4*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0> action);
            /*0x38159dc*/ UnityEvent();
            /*0x3816710*/ void AddListener(UnityEngine.Events.UnityAction<T0> call);
            /*0x3816710*/ void RemoveListener(UnityEngine.Events.UnityAction<T0> call);
            /*0x3814b90*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x3814b90*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x3910ae8*/ void Invoke(T0 arg0);
        }

        class UnityAction<T0, T1> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x3910ae8*/ void Invoke(T0 arg0, T1 arg1);
        }

        class UnityEvent<T0, T1> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            static /*0x38379c4*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0, T1> action);
            /*0x38159dc*/ UnityEvent();
            /*0x3816710*/ void AddListener(UnityEngine.Events.UnityAction<T0, T1> call);
            /*0x3816710*/ void RemoveListener(UnityEngine.Events.UnityAction<T0, T1> call);
            /*0x3814b90*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x3814b90*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x3910ae8*/ void Invoke(T0 arg0, T1 arg1);
        }

        class UnityAction<T0, T1, T2> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x3910ae8*/ void Invoke(T0 arg0, T1 arg1, T2 arg2);
        }

        class UnityEvent<T0, T1, T2> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            static /*0x38379c4*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0, T1, T2> action);
            /*0x38159dc*/ UnityEvent();
            /*0x3816710*/ void AddListener(UnityEngine.Events.UnityAction<T0, T1, T2> call);
            /*0x3816710*/ void RemoveListener(UnityEngine.Events.UnityAction<T0, T1, T2> call);
            /*0x3814b90*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x3814b90*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x3910ae8*/ void Invoke(T0 arg0, T1 arg1, T2 arg2);
        }

        class UnityAction<T0, T1, T2, T3> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            /*0x3910ae8*/ void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3);
        }

        class UnityEvent<T0, T1, T2, T3> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            static /*0x38379c4*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0, T1, T2, T3> action);
            /*0x38159dc*/ UnityEvent();
            /*0x3816710*/ void AddListener(UnityEngine.Events.UnityAction<T0, T1, T2, T3> call);
            /*0x3816710*/ void RemoveListener(UnityEngine.Events.UnityAction<T0, T1, T2, T3> call);
            /*0x3814b90*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x3814b90*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
        }
    }

    namespace Serialization
    {
        class FormerlySerializedAsAttribute : System.Attribute
        {
            /*0x10*/ string m_oldName;

            /*0x7e9ece4*/ FormerlySerializedAsAttribute(string oldName);
        }
    }

    namespace Categorization
    {
        class ElementInfoAttribute : System.Attribute
        {
            /*0x10*/ int <Order>k__BackingField;
            /*0x18*/ string <Name>k__BackingField;

            /*0x7e9ed1c*/ ElementInfoAttribute();
            /*0x7e9ed14*/ void set_Order(int value);
        }

        class CategoryInfoAttribute : System.Attribute
        {
            /*0x10*/ int <Order>k__BackingField;
            /*0x18*/ string <Name>k__BackingField;

            /*0x7e9ed58*/ CategoryInfoAttribute();
            /*0x7e9ed48*/ void set_Order(int value);
            /*0x7e9ed50*/ void set_Name(string value);
        }
    }

    namespace Bindings
    {
        struct Unmarshal
        {
            static /*0x3910ae8*/ T UnmarshalUnityObject<T>(nint gcHandlePtr);
            static /*0x7e9ed84*/ System.Runtime.InteropServices.GCHandle FromIntPtrUnsafe(nint gcHandle);
        }

        class ThrowHelper
        {
            static /*0x7e8dbdc*/ void ThrowArgumentNullException(object obj, string parameterName);
            static /*0x7e8b420*/ void ThrowNullReferenceException(object obj);
        }

        class BindingsAllocator
        {
            static /*0x7e9edc0*/ void Free(void* ptr);
            static /*0x7e9edfc*/ void FreeNativeOwnedMemory(void* ptr);
            static /*0x7e9ee38*/ void* GetNativeOwnedDataPointer(void* ptr);

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

            /*0x7e9ee50*/ BlittableArrayWrapper(void* data, int size);
            /*0x3816710*/ void Unmarshal<T>(ref T[] array);

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

            /*0x7e9ee5c*/ BlittableListWrapper(UnityEngine.Bindings.BlittableArrayWrapper arrayWrapper, int listSize);
            /*0x3816710*/ void Unmarshal<T>(System.Collections.Generic.List<T> list);
        }

        class ExceptionMarshaller
        {
            [ThreadStatic] static System.Exception s_pendingException;

            static /*0x7e9ee68*/ void SetPendingException(System.Exception ex);
        }

        struct ManagedSpanWrapper
        {
            /*0x10*/ void* begin;
            /*0x18*/ int length;

            /*0x7e8b6a8*/ ManagedSpanWrapper(void* begin, int length);
        }

        class StringMarshaller
        {
            static /*0x7e9eec0*/ bool TryMarshalEmptyOrNullString(string s, ref UnityEngine.Bindings.ManagedSpanWrapper managedSpanWrapper);
        }

        struct OutStringMarshaller
        {
            static /*0x7e9ef18*/ string GetStringAndDispose(UnityEngine.Bindings.ManagedSpanWrapper managedSpan);
        }
    }

    namespace Scripting
    {
        class AlwaysLinkAssemblyAttribute : System.Attribute
        {
            /*0x7e9efa0*/ AlwaysLinkAssemblyAttribute();
        }

        class GarbageCollector
        {
            static /*0x7e9efa8*/ UnityEngine.Scripting.GarbageCollector.Mode get_GCMode();
            static /*0x7e9efd0*/ UnityEngine.Scripting.GarbageCollector.Mode GetMode();

            enum Mode
            {
                Disabled = 0,
                Enabled = 1,
                Manual = 2,
            }
        }

        class PreserveAttribute : System.Attribute
        {
            /*0x7e9eff8*/ PreserveAttribute();
        }

        class RequiredMemberAttribute : System.Attribute
        {
            /*0x7e9f000*/ RequiredMemberAttribute();
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

                /*0x7e9f008*/ void Set(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName);
            }

            class MovedFromAttribute : System.Attribute
            {
                /*0x10*/ UnityEngine.Scripting.APIUpdating.MovedFromAttributeData data;

                /*0x7e9f098*/ MovedFromAttribute(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName);
                /*0x7e9f0e4*/ MovedFromAttribute(string sourceNamespace);
            }
        }
    }

    namespace SceneManagement
    {
        struct Scene
        {
            /*0x10*/ int m_Handle;

            static /*0x7e9f11c*/ bool IsValidInternal(int sceneHandle);
            static /*0x7e9f158*/ string GetPathInternal(int sceneHandle);
            static /*0x7e9f250*/ string GetNameInternal(int sceneHandle);
            static /*0x7e9f348*/ string GetGUIDInternal(int sceneHandle);
            static /*0x7e9f440*/ bool GetIsLoadedInternal(int sceneHandle);
            static /*0x7e9f47c*/ int GetBuildIndexInternal(int sceneHandle);
            static /*0x7e9f4b8*/ int GetRootCountInternal(int sceneHandle);
            static /*0x7e9f4f4*/ void GetRootGameObjectsInternal(int sceneHandle, object resultRootList);
            static /*0x7e9f994*/ bool op_Equality(UnityEngine.SceneManagement.Scene lhs, UnityEngine.SceneManagement.Scene rhs);
            static /*0x7e9f20c*/ void GetPathInternal_Injected(int sceneHandle, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x7e9f304*/ void GetNameInternal_Injected(int sceneHandle, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x7e9f3fc*/ void GetGUIDInternal_Injected(int sceneHandle, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            /*0x7e9f538*/ int get_handle();
            /*0x7e9f540*/ string get_guid();
            /*0x7e9f548*/ bool IsValid();
            /*0x7e9f584*/ string get_path();
            /*0x7e9f58c*/ string get_name();
            /*0x7e9f594*/ bool get_isLoaded();
            /*0x7e9f5d0*/ int get_buildIndex();
            /*0x7e9f60c*/ int get_rootCount();
            /*0x7e9f648*/ UnityEngine.GameObject[] GetRootGameObjects();
            /*0x7e9f720*/ void GetRootGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> rootGameObjects);
            /*0x7e9f9a0*/ int GetHashCode();
            /*0x7e9f9a8*/ bool Equals(object other);
        }

        class SceneManagerAPIInternal
        {
            static /*0x7e9fa20*/ UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            static /*0x7e9fb90*/ nint LoadSceneAsyncNameIndexInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper sceneName, int sceneBuildIndex, ref UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
        }

        class SceneManagerAPI
        {
            static /*0x0*/ UnityEngine.SceneManagement.SceneManagerAPI s_DefaultAPI;
            static /*0x8*/ UnityEngine.SceneManagement.SceneManagerAPI <overrideAPI>k__BackingField;

            static /*0x7e9fd14*/ SceneManagerAPI();
            static /*0x7e9fbec*/ UnityEngine.SceneManagement.SceneManagerAPI get_ActiveAPI();
            static /*0x7e9fc94*/ UnityEngine.SceneManagement.SceneManagerAPI get_overrideAPI();
            /*0x7e9fcec*/ SceneManagerAPI();
            /*0x7e9fcf4*/ UnityEngine.AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            /*0x7e9fd0c*/ UnityEngine.AsyncOperation LoadFirstScene(bool mustLoadAsync);
        }

        class SceneManager
        {
            static /*0x0*/ bool s_AllowLoadScene;
            static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> sceneLoaded;
            static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> sceneUnloaded;
            static /*0x18*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> activeSceneChanged;

            static /*0x7ea0b78*/ SceneManager();
            static /*0x7e9fd7c*/ int get_sceneCount();
            static /*0x7e9fda4*/ int get_loadedSceneCount();
            static /*0x7e9fdcc*/ UnityEngine.SceneManagement.Scene GetActiveScene();
            static /*0x7e9fe84*/ bool SetActiveScene(UnityEngine.SceneManagement.Scene scene);
            static /*0x7e9ff3c*/ UnityEngine.SceneManagement.Scene GetSceneAt(int index);
            static /*0x7ea000c*/ UnityEngine.AsyncOperation UnloadSceneAsyncInternal(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.UnloadSceneOptions options);
            static /*0x7ea00e4*/ UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            static /*0x7ea01c0*/ UnityEngine.AsyncOperation LoadFirstScene_Internal(bool async);
            static /*0x7ea0228*/ void add_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> value);
            static /*0x7ea031c*/ void remove_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> value);
            static /*0x7ea0410*/ void add_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value);
            static /*0x7ea0504*/ void remove_sceneUnloaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> value);
            static /*0x7ea05f8*/ void add_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> value);
            static /*0x7ea06ec*/ void remove_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> value);
            static /*0x7ea07e0*/ UnityEngine.AsyncOperation LoadSceneAsync(int sceneBuildIndex);
            static /*0x7ea0840*/ UnityEngine.AsyncOperation LoadSceneAsync(int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters);
            static /*0x7ea08ac*/ UnityEngine.AsyncOperation LoadSceneAsync(string sceneName, UnityEngine.SceneManagement.LoadSceneParameters parameters);
            static /*0x7ea0918*/ UnityEngine.AsyncOperation UnloadSceneAsync(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.UnloadSceneOptions options);
            static /*0x7ea097c*/ void Internal_SceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            static /*0x7ea0a2c*/ void Internal_SceneUnloaded(UnityEngine.SceneManagement.Scene scene);
            static /*0x7ea0ac8*/ void Internal_ActiveSceneChanged(UnityEngine.SceneManagement.Scene previousActiveScene, UnityEngine.SceneManagement.Scene newActiveScene);
            static /*0x7e9fe48*/ void GetActiveScene_Injected(ref UnityEngine.SceneManagement.Scene ret);
            static /*0x7e9ff00*/ bool SetActiveScene_Injected(ref UnityEngine.SceneManagement.Scene scene);
            static /*0x7e9ffc8*/ void GetSceneAt_Injected(int index, ref UnityEngine.SceneManagement.Scene ret);
            static /*0x7ea00a0*/ nint UnloadSceneAsyncInternal_Injected(ref UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.UnloadSceneOptions options);
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

            /*0x7ea0838*/ LoadSceneParameters(UnityEngine.SceneManagement.LoadSceneMode mode);
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

            /*0x7ea0bc4*/ string ToString();

            class UpdateFunction : System.MulticastDelegate
            {
                /*0x7ea0be4*/ UpdateFunction(object object, nint method);
                /*0x7ea0c80*/ void Invoke();
            }
        }

        class PlayerLoop
        {
            static /*0x7ea0c94*/ UnityEngine.LowLevel.PlayerLoopSystem GetCurrentPlayerLoop();
            static /*0x7ea0fe4*/ void SetPlayerLoop(UnityEngine.LowLevel.PlayerLoopSystem loop);
            static /*0x7ea10d0*/ int PlayerLoopSystemToInternal(UnityEngine.LowLevel.PlayerLoopSystem sys, ref System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystemInternal> internalSys);
            static /*0x7ea0d30*/ UnityEngine.LowLevel.PlayerLoopSystem InternalToPlayerLoopSystem(UnityEngine.LowLevel.PlayerLoopSystemInternal[] internalSys, ref int offset);
            static /*0x7ea0d08*/ UnityEngine.LowLevel.PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal();
            static /*0x7ea12d8*/ void SetPlayerLoopInternal(UnityEngine.LowLevel.PlayerLoopSystemInternal[] loop);
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

            static /*0x383e7a0*/ CollectionPool();
            static /*0x3910ae8*/ TCollection Get();
            static /*0x3910ae8*/ UnityEngine.Pool.PooledObject<TCollection> Get(ref TCollection value);
            static /*0x3910ae8*/ void Release(TCollection toRelease);

            class <>c<TCollection, TItem>
            {
                static /*0x0*/ UnityEngine.Pool.CollectionPool.<>c<TCollection, TItem> <>9;

                static /*0x383e7a0*/ <>c();
                /*0x38159dc*/ <>c();
                /*0x3910ae8*/ TCollection <.cctor>b__5_0();
                /*0x3910ae8*/ void <.cctor>b__5_1(TCollection l);
            }
        }

        class GenericPool<T>
        {
            static /*0x0*/ UnityEngine.Pool.ObjectPool<T> s_Pool;

            static /*0x383e7a0*/ GenericPool();
            static /*0x3910ae8*/ T Get();
            static /*0x3910ae8*/ UnityEngine.Pool.PooledObject<T> Get(ref T value);
            static /*0x3910ae8*/ void Release(T toRelease);

            class <>c<T>
            {
                static /*0x0*/ UnityEngine.Pool.GenericPool.<>c<T> <>9;

                static /*0x383e7a0*/ <>c();
                /*0x38159dc*/ <>c();
                /*0x3910ae8*/ T <.cctor>b__5_0();
            }
        }

        interface IObjectPool<T>
        {
            /*0x3910ae8*/ void Release(T element);
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

            /*0x3910ae8*/ ObjectPool(System.Func<T> createFunc, System.Action<T> actionOnGet, System.Action<T> actionOnRelease, System.Action<T> actionOnDestroy, bool collectionCheck, int defaultCapacity, int maxSize);
            /*0x3814574*/ int get_CountAll();
            /*0x3815ed0*/ void set_CountAll(int value);
            /*0x3814574*/ int get_CountInactive();
            /*0x3910ae8*/ T Get();
            /*0x3910ae8*/ UnityEngine.Pool.PooledObject<T> Get(ref T v);
            /*0x3910ae8*/ void Release(T element);
            /*0x38159dc*/ void Clear();
            /*0x38159dc*/ void Dispose();
        }

        struct PooledObject<T> : System.IDisposable
        {
            /*0x0*/ T m_ToReturn;
            /*0x0*/ UnityEngine.Pool.IObjectPool<T> m_Pool;

            /*0x3910ae8*/ PooledObject(T value, UnityEngine.Pool.IObjectPool<T> pool);
            /*0x38159dc*/ void System.IDisposable.Dispose();
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

                /*0x7ea1314*/ MessageEventArgs();
            }

            interface IEditorPlayerConnection
            {
                void Register(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);
                /*0x3816710*/ void RegisterConnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x3816710*/ void RegisterDisconnection(UnityEngine.Events.UnityAction<int> callback);
                void Send(System.Guid messageId, byte[] data);
            }

            class PlayerConnection : UnityEngine.ScriptableObject, UnityEngine.Networking.PlayerConnection.IEditorPlayerConnection
            {
                static /*0x0*/ UnityEngine.IPlayerEditorConnectionNative connectionNative;
                static /*0x8*/ UnityEngine.Networking.PlayerConnection.PlayerConnection s_Instance;
                /*0x18*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents;
                /*0x20*/ System.Collections.Generic.List<int> m_connectedPlayers;
                /*0x28*/ bool m_IsInitilized;

                static /*0x7ea131c*/ UnityEngine.Networking.PlayerConnection.PlayerConnection get_instance();
                static /*0x7ea13b0*/ UnityEngine.Networking.PlayerConnection.PlayerConnection CreateInstance();
                static /*0x7ea2548*/ void MessageCallbackInternal(nint data, ulong size, ulong guid, string messageId);
                static /*0x7ea27e0*/ void ConnectedCallbackInternal(int playerId);
                static /*0x7ea28b8*/ void DisconnectedCallback(int playerId);
                /*0x7ea294c*/ PlayerConnection();
                /*0x7ea1448*/ bool get_isConnected();
                /*0x7ea155c*/ void OnEnable();
                /*0x7ea14e4*/ UnityEngine.IPlayerEditorConnectionNative GetConnectionNativeApi();
                /*0x7ea161c*/ void Register(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);
                /*0x7ea1a28*/ void Unregister(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);
                /*0x7ea1d00*/ void RegisterConnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x7ea1ea0*/ void RegisterDisconnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x7ea1f00*/ void UnregisterConnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x7ea1f60*/ void UnregisterDisconnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x7ea1fc0*/ void Send(System.Guid messageId, byte[] data);
                /*0x7ea2118*/ bool TrySend(System.Guid messageId, byte[] data);
                /*0x7ea2270*/ bool BlockUntilRecvMsg(System.Guid messageId, int timeout);
                /*0x7ea24ac*/ void DisconnectAll();

                class <>c__DisplayClass12_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x7ea1858*/ <>c__DisplayClass12_0();
                    /*0x7ea2ae4*/ bool <Register>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x7ea1bcc*/ <>c__DisplayClass13_0();
                    /*0x7ea2b58*/ bool <Unregister>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ bool msgReceived;

                    /*0x7ea24a4*/ <>c__DisplayClass20_0();
                    /*0x7ea2ba0*/ void <BlockUntilRecvMsg>b__0(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
                }
            }

            class PlayerEditorConnectionEvents
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> m_MessageTypeSubscribers;
                /*0x18*/ System.Collections.Generic.Dictionary<System.Guid, UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> m_SubscriberLookup;
                /*0x20*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent;
                /*0x28*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent;

                /*0x7ea2a08*/ PlayerEditorConnectionEvents();
                /*0x7ea2bac*/ System.Collections.Generic.IReadOnlyList<UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> get_messageTypeSubscribers();
                /*0x7ea2bb4*/ void BuildLookup();
                /*0x7ea2660*/ void InvokeMessageIdSubscribers(System.Guid messageId, byte[] data, int playerId);
                /*0x7ea1860*/ UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs> AddAndCreate(System.Guid messageId);
                /*0x7ea1bd4*/ void UnregisterManagedCallback(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);

                class MessageEvent : UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs>
                {
                    /*0x7ea2fec*/ MessageEvent();
                }

                class ConnectionChangeEvent : UnityEngine.Events.UnityEvent<int>
                {
                    /*0x7ea3034*/ ConnectionChangeEvent();
                }

                class MessageTypeSubscribers
                {
                    /*0x10*/ string m_messageTypeId;
                    /*0x18*/ int subscriberCount;
                    /*0x20*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageEvent messageCallback;

                    /*0x7ea2f48*/ MessageTypeSubscribers();
                    /*0x7ea2b2c*/ System.Guid get_MessageTypeId();
                    /*0x7ea2fb4*/ void set_MessageTypeId(System.Guid value);
                }
            }
        }
    }

    namespace Internal
    {
        class DefaultValueAttribute : System.Attribute
        {
            /*0x10*/ object DefaultValue;

            /*0x7ea307c*/ DefaultValueAttribute(string value);
            /*0x7ea30ac*/ object get_Value();
            /*0x7ea30b4*/ bool Equals(object obj);
            /*0x7ea316c*/ int GetHashCode();
        }

        class ExcludeFromDocsAttribute : System.Attribute
        {
            /*0x7ea3190*/ ExcludeFromDocsAttribute();
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

            /*0x7ea3198*/ bool HasFlags(UnityEngine.Playables.FrameData.Flags flag);
            /*0x7ea31a8*/ float get_deltaTime();
            /*0x7ea31b4*/ float get_effectiveSpeed();
            /*0x7ea31bc*/ UnityEngine.Playables.FrameData.EvaluationType get_evaluationType();
            /*0x7ea31cc*/ bool get_timeLooped();
            /*0x7ea31d8*/ UnityEngine.Playables.PlayableOutput get_output();

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
            /*0x3910ae8*/ void OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, object context);
        }

        interface IPlayable
        {
            /*0x3910ae8*/ UnityEngine.Playables.PlayableHandle GetHandle();
        }

        interface IPlayableBehaviour
        {
            /*0x3910ae8*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x3910ae8*/ void OnGraphStop(UnityEngine.Playables.Playable playable);
            /*0x3910ae8*/ void OnPlayableCreate(UnityEngine.Playables.Playable playable);
            /*0x3910ae8*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x3910ae8*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x3910ae8*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x3910ae8*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x3910ae8*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
        }

        interface IPlayableOutput
        {
            /*0x3910ae8*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
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

            static /*0x7ea354c*/ Playable();
            static /*0x7ea31e4*/ UnityEngine.Playables.Playable get_Null();
            static /*0x7ea323c*/ UnityEngine.Playables.Playable Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            /*0x7ea3334*/ Playable(UnityEngine.Playables.PlayableHandle handle);
            /*0x7ea333c*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x7ea3348*/ System.Type GetPlayableType();
            /*0x7ea3434*/ bool Equals(UnityEngine.Playables.Playable other);
        }

        interface IPlayableAsset
        {
            UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
            /*0x3814438*/ double get_duration();
        }

        class PlayableAsset : UnityEngine.ScriptableObject, UnityEngine.Playables.IPlayableAsset
        {
            static /*0x7ea36c4*/ void Internal_CreatePlayable(UnityEngine.Playables.PlayableAsset asset, UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, nint ptr);
            static /*0x7ea3798*/ void Internal_GetPlayableAssetDuration(UnityEngine.Playables.PlayableAsset asset, nint ptrToDouble);
            /*0x7ea37c0*/ PlayableAsset();
            UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
            /*0x7ea3614*/ double get_duration();
            /*0x7ea366c*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
        }

        class PlayableBehaviour : UnityEngine.Playables.IPlayableBehaviour, System.ICloneable
        {
            /*0x7ea37c8*/ PlayableBehaviour();
            /*0x7ea37d0*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x7ea37d4*/ void OnGraphStop(UnityEngine.Playables.Playable playable);
            /*0x7ea37d8*/ void OnPlayableCreate(UnityEngine.Playables.Playable playable);
            /*0x7ea37dc*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x7ea37e0*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x7ea37e4*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x7ea37e8*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x7ea37ec*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
            /*0x7ea37f0*/ object Clone();
        }

        struct PlayableBinding
        {
            static /*0x0*/ UnityEngine.Playables.PlayableBinding[] None;
            static /*0x8*/ double DefaultDuration;
            /*0x10*/ string m_StreamName;
            /*0x18*/ UnityEngine.Object m_SourceObject;
            /*0x20*/ System.Type m_SourceBindingType;
            /*0x28*/ UnityEngine.Playables.PlayableBinding.CreateOutputMethod m_CreateOutputMethod;

            static /*0x7ea397c*/ PlayableBinding();
            static /*0x7ea38e8*/ UnityEngine.Playables.PlayableBinding CreateInternal(string name, UnityEngine.Object sourceObject, System.Type sourceType, UnityEngine.Playables.PlayableBinding.CreateOutputMethod createFunction);
            /*0x7ea37f8*/ UnityEngine.Object get_sourceObject();
            /*0x7ea3800*/ UnityEngine.Playables.PlayableOutput CreateOutput(UnityEngine.Playables.PlayableGraph graph);

            class CreateOutputMethod : System.MulticastDelegate
            {
                /*0x7ea3a04*/ CreateOutputMethod(object object, nint method);
                /*0x7ea3aa4*/ UnityEngine.Playables.PlayableOutput Invoke(UnityEngine.Playables.PlayableGraph graph, string name);
            }
        }

        enum PlayableTraversalMode
        {
            Mix = 0,
            Passthrough = 1,
        }

        class PlayableExtensions
        {
            static /*0x3910ae8*/ bool IsValid<U>(U playable);
            static /*0x3910ae8*/ UnityEngine.Playables.PlayState GetPlayState<U>(U playable);
            static /*0x3910ae8*/ void Play<U>(U playable);
            static /*0x3910ae8*/ void Pause<U>(U playable);
            static /*0x3910ae8*/ void SetSpeed<U>(U playable, double value);
            static /*0x3910ae8*/ void SetDuration<U>(U playable, double value);
            static /*0x3910ae8*/ double GetDuration<U>(U playable);
            static /*0x3910ae8*/ void SetTime<U>(U playable, double value);
            static /*0x3910ae8*/ double GetTime<U>(U playable);
            static /*0x3910ae8*/ bool IsDone<U>(U playable);
            static /*0x3910ae8*/ void SetPropagateSetTime<U>(U playable, bool value);
            static /*0x3910ae8*/ void SetInputCount<U>(U playable, int value);
            static /*0x3910ae8*/ int GetInputCount<U>(U playable);
            static /*0x3910ae8*/ UnityEngine.Playables.Playable GetInput<U>(U playable, int inputPort);
            static /*0x3910ae8*/ UnityEngine.Playables.Playable GetOutput<U>(U playable, int outputPort);
            static /*0x3910ae8*/ void SetInputWeight<U>(U playable, int inputIndex, float weight);
            static /*0x3910ae8*/ void SetInputWeight<U, V>(U playable, V input, float weight);
            static /*0x3910ae8*/ float GetInputWeight<U>(U playable, int inputIndex);
            static /*0x3910ae8*/ void SetTraversalMode<U>(U playable, UnityEngine.Playables.PlayableTraversalMode mode);
            static /*0x3910ae8*/ UnityEngine.Playables.DirectorWrapMode GetTimeWrapMode<U>(U playable);
            static /*0x3910ae8*/ void SetTimeWrapMode<U>(U playable, UnityEngine.Playables.DirectorWrapMode value);
        }

        struct PlayableGraph
        {
            /*0x10*/ nint m_Handle;
            /*0x18*/ uint m_Version;

            static /*0x7ea3b6c*/ void CreatePlayableHandle_Injected(ref UnityEngine.Playables.PlayableGraph _unity_self, ref UnityEngine.Playables.PlayableHandle ret);
            static /*0x7ea3d14*/ bool CreateScriptOutputInternal_Injected(ref UnityEngine.Playables.PlayableGraph _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name, ref UnityEngine.Playables.PlayableOutputHandle handle);
            static /*0x7ea3ddc*/ bool ConnectInternal_Injected(ref UnityEngine.Playables.PlayableGraph _unity_self, ref UnityEngine.Playables.PlayableHandle source, int sourceOutputPort, ref UnityEngine.Playables.PlayableHandle destination, int destinationInputPort);
            /*0x3910ae8*/ bool Connect<U, V>(U source, int sourceOutputPort, V destination, int destinationInputPort);
            /*0x7ea3ab8*/ bool IsValid();
            /*0x7ea3af4*/ UnityEngine.IExposedPropertyTable GetResolver();
            /*0x7ea3b30*/ int GetPlayableCount();
            /*0x7ea32e0*/ UnityEngine.Playables.PlayableHandle CreatePlayableHandle();
            /*0x7ea3bb0*/ bool CreateScriptOutputInternal(string name, ref UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x7ea3d68*/ bool ConnectInternal(UnityEngine.Playables.PlayableHandle source, int sourceOutputPort, UnityEngine.Playables.PlayableHandle destination, int destinationInputPort);
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

            static /*0x7ea4c60*/ PlayableHandle();
            static /*0x7ea35bc*/ UnityEngine.Playables.PlayableHandle get_Null();
            static /*0x7ea34cc*/ bool op_Equality(UnityEngine.Playables.PlayableHandle x, UnityEngine.Playables.PlayableHandle y);
            static /*0x7ea42a8*/ bool CompareVersion(UnityEngine.Playables.PlayableHandle lhs, UnityEngine.Playables.PlayableHandle rhs);
            static /*0x7ea4a64*/ void SetInputWeight_Injected(ref UnityEngine.Playables.PlayableHandle _unity_self, ref UnityEngine.Playables.PlayableHandle input, float weight);
            static /*0x7ea4bb8*/ void GetInputHandle_Injected(ref UnityEngine.Playables.PlayableHandle _unity_self, int index, ref UnityEngine.Playables.PlayableHandle ret);
            static /*0x7ea4c0c*/ void GetOutputHandle_Injected(ref UnityEngine.Playables.PlayableHandle _unity_self, int index, ref UnityEngine.Playables.PlayableHandle ret);
            /*0x3910ae8*/ T GetObject<T>();
            /*0x3813ffc*/ bool IsPlayableOfType<T>();
            /*0x7ea3e48*/ UnityEngine.Playables.Playable GetInput(int inputPort);
            /*0x7ea3f48*/ UnityEngine.Playables.Playable GetOutput(int outputPort);
            /*0x7ea4048*/ bool SetInputWeight(int inputIndex, float weight);
            /*0x7ea41c4*/ float GetInputWeight(int inputIndex);
            /*0x7ea42c0*/ bool Equals(object p);
            /*0x7ea4368*/ bool Equals(UnityEngine.Playables.PlayableHandle other);
            /*0x7ea43e0*/ int GetHashCode();
            /*0x7ea4100*/ bool CheckInputBounds(int inputIndex);
            /*0x7ea4414*/ bool CheckInputBounds(int inputIndex, bool acceptAny);
            /*0x7ea4678*/ bool IsValid();
            /*0x7ea33f8*/ System.Type GetPlayableType();
            /*0x7ea46b4*/ void SetScriptInstance(object scriptInstance);
            /*0x7ea46f8*/ UnityEngine.Playables.PlayState GetPlayState();
            /*0x7ea4734*/ void Play();
            /*0x7ea4770*/ void Pause();
            /*0x7ea47ac*/ void SetSpeed(double value);
            /*0x7ea47f8*/ double GetTime();
            /*0x7ea4834*/ void SetTime(double value);
            /*0x7ea4880*/ bool IsDone();
            /*0x7ea48bc*/ double GetDuration();
            /*0x7ea48f8*/ void SetDuration(double value);
            /*0x7ea4944*/ void SetPropagateSetTime(bool value);
            /*0x7ea463c*/ int GetInputCount();
            /*0x7ea4988*/ void SetInputCount(int value);
            /*0x7ea49cc*/ void SetInputWeight(UnityEngine.Playables.PlayableHandle input, float weight);
            /*0x7ea4ab8*/ void SetTraversalMode(UnityEngine.Playables.PlayableTraversalMode mode);
            /*0x7ea4afc*/ UnityEngine.Playables.DirectorWrapMode GetTimeWrapMode();
            /*0x7ea4b38*/ void SetTimeWrapMode(UnityEngine.Playables.DirectorWrapMode mode);
            /*0x7ea4b7c*/ object GetScriptInstance();
            /*0x7ea3eac*/ UnityEngine.Playables.PlayableHandle GetInputHandle(int index);
            /*0x7ea3fac*/ UnityEngine.Playables.PlayableHandle GetOutputHandle(int index);
            /*0x7ea4170*/ void SetInputWeightFromIndex(int index, float weight);
            /*0x7ea4264*/ float GetInputWeightFromIndex(int index);
        }

        struct PlayableOutput : UnityEngine.Playables.IPlayableOutput, System.IEquatable<UnityEngine.Playables.PlayableOutput>
        {
            static /*0x0*/ UnityEngine.Playables.PlayableOutput m_NullPlayableOutput;
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x7ea4dd4*/ PlayableOutput();
            static /*0x7ea3890*/ UnityEngine.Playables.PlayableOutput get_Null();
            /*0x7ea4ca8*/ PlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x7ea4cb0*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            /*0x3813ffc*/ bool IsPlayableOutputOfType<T>();
            /*0x7ea4cbc*/ bool Equals(UnityEngine.Playables.PlayableOutput other);
        }

        class PlayableOutputExtensions
        {
            static /*0x3910ae8*/ void SetReferenceObject<U>(U output, UnityEngine.Object value);
            static /*0x3910ae8*/ UnityEngine.Object GetUserData<U>(U output);
            static /*0x3910ae8*/ void SetUserData<U>(U output, UnityEngine.Object value);
            static /*0x3910ae8*/ UnityEngine.Playables.Playable GetSourcePlayable<U>(U output);
            static /*0x3910ae8*/ void SetSourcePlayable<U, V>(U output, V value, int port);
            static /*0x3910ae8*/ int GetSourceOutputPort<U>(U output);
            static /*0x3910ae8*/ void SetWeight<U>(U output, float value);
            static /*0x3910ae8*/ void PushNotification<U>(U output, UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, object context);
            static /*0x3910ae8*/ void AddNotificationReceiver<U>(U output, UnityEngine.Playables.INotificationReceiver receiver);
        }

        struct PlayableOutputHandle : System.IEquatable<UnityEngine.Playables.PlayableOutputHandle>
        {
            static /*0x0*/ UnityEngine.Playables.PlayableOutputHandle m_Null;
            /*0x10*/ nint m_Handle;
            /*0x18*/ uint m_Version;

            static /*0x7ea5608*/ PlayableOutputHandle();
            static /*0x7ea4e44*/ UnityEngine.Playables.PlayableOutputHandle get_Null();
            static /*0x7ea4d54*/ bool op_Equality(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs);
            static /*0x7ea4ed0*/ bool CompareVersion(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs);
            static /*0x7ea5130*/ void SetReferenceObject_Injected(ref UnityEngine.Playables.PlayableOutputHandle _unity_self, nint target);
            static /*0x7ea5204*/ nint GetUserData_Injected(ref UnityEngine.Playables.PlayableOutputHandle _unity_self);
            static /*0x7ea5310*/ void GetSourcePlayable_Injected(ref UnityEngine.Playables.PlayableOutputHandle _unity_self, ref UnityEngine.Playables.PlayableHandle ret);
            static /*0x7ea53ec*/ void SetSourcePlayable_Injected(ref UnityEngine.Playables.PlayableOutputHandle _unity_self, ref UnityEngine.Playables.PlayableHandle target, int port);
            static /*0x7ea5568*/ void PushNotification_Injected(ref UnityEngine.Playables.PlayableOutputHandle _unity_self, ref UnityEngine.Playables.PlayableHandle origin, UnityEngine.Playables.INotification notification, object context);
            /*0x3813ffc*/ bool IsPlayableOutputOfType<T>();
            /*0x7ea4e9c*/ int GetHashCode();
            /*0x7ea4ee8*/ bool Equals(object p);
            /*0x7ea4f90*/ bool Equals(UnityEngine.Playables.PlayableOutputHandle other);
            /*0x7ea5008*/ bool IsValid();
            /*0x7ea5044*/ System.Type GetPlayableOutputType();
            /*0x7ea5080*/ void SetReferenceObject(UnityEngine.Object target);
            /*0x7ea5174*/ UnityEngine.Object GetUserData();
            /*0x7ea5240*/ void SetUserData(UnityEngine.Object target);
            /*0x7ea5284*/ UnityEngine.Playables.PlayableHandle GetSourcePlayable();
            /*0x7ea5354*/ void SetSourcePlayable(UnityEngine.Playables.PlayableHandle target, int port);
            /*0x7ea5440*/ int GetSourceOutputPort();
            /*0x7ea547c*/ void SetWeight(float weight);
            /*0x7ea54c8*/ void PushNotification(UnityEngine.Playables.PlayableHandle origin, UnityEngine.Playables.INotification notification, object context);
            /*0x7ea55c4*/ void AddNotificationReceiver(UnityEngine.Playables.INotificationReceiver receiver);
        }

        struct ScriptPlayable<T> : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Playables.ScriptPlayable<T>>
        {
            static /*0x0*/ UnityEngine.Playables.ScriptPlayable<T> m_NullPlayable;
            /*0x0*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x383e7a0*/ ScriptPlayable();
            static /*0x3910ae8*/ UnityEngine.Playables.ScriptPlayable<T> get_Null();
            static /*0x3910ae8*/ UnityEngine.Playables.ScriptPlayable<T> Create(UnityEngine.Playables.PlayableGraph graph, int inputCount);
            static /*0x3910ae8*/ UnityEngine.Playables.ScriptPlayable<T> Create(UnityEngine.Playables.PlayableGraph graph, T template, int inputCount);
            static /*0x3910ae8*/ UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, T template, int inputCount);
            static /*0x3836db8*/ object CreateScriptInstance();
            static /*0x38379c4*/ object CloneScriptInstance(UnityEngine.Playables.IPlayableBehaviour source);
            static /*0x38379c4*/ object CloneScriptInstanceFromEngineObject(UnityEngine.Object source);
            static /*0x38379c4*/ object CloneScriptInstanceFromIClonable(System.ICloneable source);
            static /*0x3910ae8*/ UnityEngine.Playables.Playable op_Implicit(UnityEngine.Playables.ScriptPlayable<T> playable);
            static /*0x3910ae8*/ UnityEngine.Playables.ScriptPlayable<T> op_Explicit(UnityEngine.Playables.Playable playable);
            /*0x3910ae8*/ ScriptPlayable(UnityEngine.Playables.PlayableHandle handle);
            /*0x3910ae8*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x3910ae8*/ T GetBehaviour();
            /*0x3910ae8*/ bool Equals(UnityEngine.Playables.ScriptPlayable<T> other);
        }

        class ScriptPlayableBinding
        {
            static /*0x7ea5650*/ UnityEngine.Playables.PlayableBinding Create(string name, UnityEngine.Object key, System.Type type);
            static /*0x7ea5734*/ UnityEngine.Playables.PlayableOutput CreateScriptOutput(UnityEngine.Playables.PlayableGraph graph, string name);
        }

        struct ScriptPlayableOutput : UnityEngine.Playables.IPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x7ea5738*/ UnityEngine.Playables.ScriptPlayableOutput Create(UnityEngine.Playables.PlayableGraph graph, string name);
            static /*0x7ea578c*/ UnityEngine.Playables.ScriptPlayableOutput get_Null();
            static /*0x7ea5788*/ UnityEngine.Playables.PlayableOutput op_Implicit(UnityEngine.Playables.ScriptPlayableOutput output);
            /*0x7ea5804*/ ScriptPlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x7ea5910*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
        }
    }

    namespace Assertions
    {
        class Assert
        {
            static /*0x0*/ bool raiseExceptions;

            static /*0x7ea6394*/ Assert();
            static /*0x7ea591c*/ void Fail(string message, string userMessage);
            static /*0x7ea5ab8*/ void IsTrue(bool condition);
            static /*0x7ea5b24*/ void IsTrue(bool condition, string message);
            static /*0x7ea5c44*/ void IsFalse(bool condition);
            static /*0x7ea5cb0*/ void IsFalse(bool condition, string message);
            static /*0x3910ae8*/ void AreEqual<T>(T expected, T actual);
            static /*0x3910ae8*/ void AreEqual<T>(T expected, T actual, string message);
            static /*0x3910ae8*/ void AreEqual<T>(T expected, T actual, string message, System.Collections.Generic.IEqualityComparer<T> comparer);
            static /*0x7ea5d30*/ void AreEqual(UnityEngine.Object expected, UnityEngine.Object actual, string message);
            static /*0x3910ae8*/ void IsNull<T>(T value);
            static /*0x3910ae8*/ void IsNull<T>(T value, string message);
            static /*0x7ea6018*/ void IsNull(UnityEngine.Object value, string message);
            static /*0x3910ae8*/ void IsNotNull<T>(T value);
            static /*0x3910ae8*/ void IsNotNull<T>(T value, string message);
            static /*0x7ea6250*/ void IsNotNull(UnityEngine.Object value, string message);
            static /*0x7ea6308*/ void AreEqual(int expected, int actual);
        }

        class AssertionException : System.Exception
        {
            /*0x90*/ string m_UserMessage;

            /*0x7ea5a3c*/ AssertionException(string message, string userMessage);
            /*0x7ea63e0*/ string get_Message();
        }

        class AssertionMessageUtil
        {
            static /*0x7ea6454*/ string GetMessage(string failureMessage);
            static /*0x7ea655c*/ string GetMessage(string failureMessage, string expected);
            static /*0x7ea5df4*/ string GetEqualityMessage(object actual, object expected, bool expectEqual);
            static /*0x7ea60d0*/ string NullFailureMessage(object value, bool expectNull);
            static /*0x7ea5ba4*/ string BooleanFailureMessage(bool expected);
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

            /*0x7ea66e8*/ AnalyticsEventBase(string eventName, int eventVersion, UnityEngine.Analytics.SendEventOptions sendEventOptions, string eventPrefix);
        }

        class BatchRenderGroupUsageAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ int maxBRGInstance;
            /*0x30*/ int maxMeshCount;
            /*0x34*/ int maxMaterialCount;
            /*0x38*/ int maxDrawCommandBatch;

            static /*0x7ea67b4*/ UnityEngine.Analytics.BatchRenderGroupUsageAnalytic CreateBatchRenderGroupUsageAnalytic();
            /*0x7ea6744*/ BatchRenderGroupUsageAnalytic();
        }

        class UaaLApplicationLaunchAnalytic : UnityEngine.Analytics.AnalyticsEventBase
        {
            /*0x2c*/ int launch_type;
            /*0x30*/ int launch_process_type;

            static /*0x7ea6874*/ UnityEngine.Analytics.UaaLApplicationLaunchAnalytic CreateUaaLApplicationLaunchAnalytic();
            /*0x7ea6804*/ UaaLApplicationLaunchAnalytic();
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

            static /*0x7ea6950*/ UnityEngine.Analytics.ShaderRuntimeInfoAnalytic CreateShaderRuntimeInfoAnalytic();
            /*0x7ea68c4*/ ShaderRuntimeInfoAnalytic();
        }
    }

    namespace Rendering
    {
        class SortingGroup : UnityEngine.Behaviour
        {
            static /*0x7ea69a0*/ int get_invalidSortingGroupID();
            static /*0x7ea69c8*/ void UpdateAllSortingGroups();
            static /*0x7ea69f0*/ UnityEngine.Rendering.SortingGroup GetSortingGroupByIndex(int index);
            static /*0x7ea6a5c*/ nint GetSortingGroupByIndex_Injected(int index);
            static /*0x7ea6b88*/ void get_sortingLayerName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x7ea6d3c*/ void set_sortingLayerName_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x7ea6df4*/ int get_sortingLayerID_Injected(nint _unity_self);
            static /*0x7ea6eac*/ void set_sortingLayerID_Injected(nint _unity_self, int value);
            static /*0x7ea6f64*/ int get_sortingOrder_Injected(nint _unity_self);
            static /*0x7ea701c*/ void set_sortingOrder_Injected(nint _unity_self, int value);
            static /*0x7ea70d4*/ bool get_sortAtRoot_Injected(nint _unity_self);
            static /*0x7ea718c*/ void set_sortAtRoot_Injected(nint _unity_self, bool value);
            static /*0x7ea7244*/ int get_sortingGroupID_Injected(nint _unity_self);
            static /*0x7ea72f4*/ int get_sortingGroupOrder_Injected(nint _unity_self);
            static /*0x7ea73a4*/ int get_index_Injected(nint _unity_self);
            static /*0x7ea7454*/ uint get_sortingKey_Injected(nint _unity_self);
            /*0x7ea7490*/ SortingGroup();
            /*0x7ea6a98*/ string get_sortingLayerName();
            /*0x7ea6bcc*/ void set_sortingLayerName(string value);
            /*0x7ea6d80*/ int get_sortingLayerID();
            /*0x7ea6e30*/ void set_sortingLayerID(int value);
            /*0x7ea6ef0*/ int get_sortingOrder();
            /*0x7ea6fa0*/ void set_sortingOrder(int value);
            /*0x7ea7060*/ bool get_sortAtRoot();
            /*0x7ea7110*/ void set_sortAtRoot(bool value);
            /*0x7ea71d0*/ int get_sortingGroupID();
            /*0x7ea7280*/ int get_sortingGroupOrder();
            /*0x7ea7330*/ int get_index();
            /*0x7ea73e0*/ uint get_sortingKey();
        }

        struct AsyncGPUReadbackRequest
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ int m_Version;

            static /*0x7ea773c*/ void InvokeCallback(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncGPUReadbackRequest obj);
            /*0x7ea7498*/ void WaitForCompletion();
            /*0x3910ae8*/ Unity.Collections.NativeArray<T> GetData<T>(int layer);
            /*0x7ea74d4*/ bool get_done();
            /*0x7ea754c*/ bool get_hasError();
            /*0x7ea75c4*/ int get_layerCount();
            /*0x7ea763c*/ int get_layerDataSize();
            /*0x7ea7510*/ bool IsDone();
            /*0x7ea7588*/ bool HasError();
            /*0x7ea7600*/ int GetLayerCount();
            /*0x7ea7678*/ int GetLayerDataSize();
            /*0x7ea76b4*/ void SetScriptingCallback(System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x7ea76f8*/ nint GetDataRaw(int layer);
        }

        struct AsyncRequestNativeArrayData
        {
            /*0x10*/ void* nativeArrayBuffer;
            /*0x18*/ long lengthInBytes;

            static /*0x3910ae8*/ UnityEngine.Rendering.AsyncRequestNativeArrayData CreateAndCheckAccess<T>(Unity.Collections.NativeArray<T> array);
        }

        class AsyncGPUReadback
        {
            static /*0x7ea7760*/ UnityEngine.Rendering.AsyncGPUReadbackRequest Request(UnityEngine.GraphicsBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            static /*0x7ea786c*/ UnityEngine.Rendering.AsyncGPUReadbackRequest Request(UnityEngine.GraphicsBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            static /*0x7ea77c0*/ UnityEngine.Rendering.AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_1(UnityEngine.GraphicsBuffer buffer, UnityEngine.Rendering.AsyncRequestNativeArrayData* data);
            static /*0x7ea78cc*/ UnityEngine.Rendering.AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_2(UnityEngine.GraphicsBuffer src, int size, int offset, UnityEngine.Rendering.AsyncRequestNativeArrayData* data);
            static /*0x7ea7990*/ void Request_Internal_GraphicsBuffer_1_Injected(nint buffer, UnityEngine.Rendering.AsyncRequestNativeArrayData* data, ref UnityEngine.Rendering.AsyncGPUReadbackRequest ret);
            static /*0x7ea79e4*/ void Request_Internal_GraphicsBuffer_2_Injected(nint src, int size, int offset, UnityEngine.Rendering.AsyncRequestNativeArrayData* data, ref UnityEngine.Rendering.AsyncGPUReadbackRequest ret);
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
            static /*0x7ea7a50*/ bool IsValid(UnityEngine.Rendering.CameraEvent value);
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

            /*0x7ea7a5c*/ UnityEngine.Bounds get_bounds();
            /*0x7ea7a70*/ UnityEngine.MeshTopology get_topology();
            /*0x7ea7a78*/ int get_indexStart();
            /*0x7ea7a80*/ int get_indexCount();
            /*0x7ea7a88*/ int get_baseVertex();
            /*0x7ea7a90*/ int get_firstVertex();
            /*0x7ea7a98*/ int get_vertexCount();
            /*0x7ea7aa0*/ string ToString();
        }

        struct VertexAttributeDescriptor : System.IEquatable<UnityEngine.Rendering.VertexAttributeDescriptor>
        {
            /*0x10*/ UnityEngine.Rendering.VertexAttribute <attribute>k__BackingField;
            /*0x14*/ UnityEngine.Rendering.VertexAttributeFormat <format>k__BackingField;
            /*0x18*/ int <dimension>k__BackingField;
            /*0x1c*/ int <stream>k__BackingField;

            /*0x7ea7dc4*/ VertexAttributeDescriptor(UnityEngine.Rendering.VertexAttribute attribute, UnityEngine.Rendering.VertexAttributeFormat format, int dimension, int stream);
            /*0x7ea7d84*/ UnityEngine.Rendering.VertexAttribute get_attribute();
            /*0x7ea7d8c*/ void set_attribute(UnityEngine.Rendering.VertexAttribute value);
            /*0x7ea7d94*/ UnityEngine.Rendering.VertexAttributeFormat get_format();
            /*0x7ea7d9c*/ void set_format(UnityEngine.Rendering.VertexAttributeFormat value);
            /*0x7ea7da4*/ int get_dimension();
            /*0x7ea7dac*/ void set_dimension(int value);
            /*0x7ea7db4*/ int get_stream();
            /*0x7ea7dbc*/ void set_stream(int value);
            /*0x7ea7dd0*/ string ToString();
            /*0x7ea7fc8*/ int GetHashCode();
            /*0x7ea7ff0*/ bool Equals(object other);
            /*0x7ea8098*/ bool Equals(UnityEngine.Rendering.VertexAttributeDescriptor other);
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

            static /*0x7ea82dc*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Rendering.BuiltinRenderTextureType type);
            static /*0x7ea8300*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(string name);
            static /*0x7ea8330*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(int nameID);
            static /*0x7ea834c*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.Texture tex);
            static /*0x7ea839c*/ UnityEngine.Rendering.RenderTargetIdentifier op_Implicit(UnityEngine.RenderBuffer buf);
            static /*0x7ea87f4*/ bool op_Equality(UnityEngine.Rendering.RenderTargetIdentifier lhs, UnityEngine.Rendering.RenderTargetIdentifier rhs);
            static /*0x7ea8824*/ bool op_Inequality(UnityEngine.Rendering.RenderTargetIdentifier lhs, UnityEngine.Rendering.RenderTargetIdentifier rhs);
            /*0x7ea80dc*/ RenderTargetIdentifier(UnityEngine.Rendering.BuiltinRenderTextureType type);
            /*0x7ea80fc*/ RenderTargetIdentifier(string name);
            /*0x7ea8134*/ RenderTargetIdentifier(int nameID);
            /*0x7ea8154*/ RenderTargetIdentifier(int nameID, int mipLevel, UnityEngine.CubemapFace cubeFace, int depthSlice);
            /*0x7ea8170*/ RenderTargetIdentifier(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier, int mipLevel, UnityEngine.CubemapFace cubeFace, int depthSlice);
            /*0x7ea819c*/ RenderTargetIdentifier(UnityEngine.Texture tex);
            /*0x7ea82bc*/ RenderTargetIdentifier(UnityEngine.RenderBuffer buf, int mipLevel, UnityEngine.CubemapFace cubeFace, int depthSlice);
            /*0x7ea83c0*/ string ToString();
            /*0x7ea869c*/ int GetHashCode();
            /*0x7ea86e8*/ bool Equals(UnityEngine.Rendering.RenderTargetIdentifier rhs);
            /*0x7ea8764*/ bool Equals(object obj);
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

            /*0x7ea8858*/ UnityEngine.Rendering.RenderTargetIdentifier[] get_colorRenderTargets();
            /*0x7ea8860*/ UnityEngine.Rendering.RenderTargetIdentifier get_depthRenderTarget();
            /*0x7ea8878*/ UnityEngine.Rendering.RenderBufferLoadAction[] get_colorLoadActions();
            /*0x7ea8880*/ UnityEngine.Rendering.RenderBufferStoreAction[] get_colorStoreActions();
            /*0x7ea8888*/ UnityEngine.Rendering.RenderBufferLoadAction get_depthLoadAction();
            /*0x7ea8890*/ UnityEngine.Rendering.RenderBufferStoreAction get_depthStoreAction();
            /*0x7ea8898*/ UnityEngine.Rendering.RenderTargetFlags get_flags();
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

            static /*0x7ea88a0*/ UnityEngine.Rendering.SynchronisationStageFlags TranslateSynchronizationStageToFlags(UnityEngine.Rendering.SynchronisationStage s);
            static /*0x7ea8960*/ int GetVersionNumber(nint fencePtr);
            /*0x7ea88b0*/ void InitPostAllocation();
            /*0x7ea899c*/ bool IsFencePending();
            /*0x7ea89f4*/ void Validate();
            /*0x7ea8958*/ int GetPlatformNotSupportedVersion();
        }

        class GraphicsSettings : UnityEngine.Object
        {
            static /*0x0*/ System.Lazy<UnityEngine.Rendering.RenderPipelineGlobalSettings> s_CurrentRenderPipelineGlobalSettings;

            static /*0x7ea96a8*/ GraphicsSettings();
            static /*0x7ea8a6c*/ UnityEngine.Object Internal_GetSettingsForRenderPipeline(string renderpipelineName);
            static /*0x3836db8*/ UnityEngine.Rendering.RenderPipelineGlobalSettings GetSettingsForRenderPipeline<T>();
            static /*0x7ea8c94*/ UnityEngine.Rendering.RenderPipelineGlobalSettings Internal_GetCurrentRenderPipelineGlobalSettings();
            static /*0x7ea8e3c*/ bool TryGetCurrentRenderPipelineGlobalSettings(ref UnityEngine.Rendering.RenderPipelineGlobalSettings asset);
            static /*0x3910ae8*/ T GetRenderPipelineSettings<T>();
            static /*0x3823ae0*/ bool TryGetRenderPipelineSettings<T>(ref T settings);
            static /*0x7ea8f00*/ bool get_lightsUseLinearIntensity();
            static /*0x7ea8f28*/ void set_lightsUseLinearIntensity(bool value);
            static /*0x7ea8f64*/ void set_lightsUseColorTemperature(bool value);
            static /*0x7ea8fa0*/ bool get_useScriptableRenderPipelineBatching();
            static /*0x7ea8fc8*/ void set_useScriptableRenderPipelineBatching(bool value);
            static /*0x7ea9004*/ bool HasShaderDefine(UnityEngine.Rendering.GraphicsTier tier, UnityEngine.Rendering.BuiltinShaderDefine defineHash);
            static /*0x7ea9048*/ bool HasShaderDefine(UnityEngine.Rendering.BuiltinShaderDefine defineHash);
            static /*0x7ea90f4*/ UnityEngine.ScriptableObject get_INTERNAL_currentRenderPipeline();
            static /*0x7ea8da0*/ UnityEngine.Rendering.RenderPipelineAsset get_currentRenderPipeline();
            static /*0x7ea91a4*/ bool get_isScriptableRenderPipelineEnabled();
            static /*0x7ea922c*/ System.Type get_currentRenderPipelineAssetType();
            static /*0x7ea92b0*/ UnityEngine.Shader GetDefaultShader(UnityEngine.Rendering.DefaultShaderType type);
            static /*0x7ea94b0*/ UnityEngine.Material GetDefaultMaterial(UnityEngine.Rendering.DefaultMaterialType type);
            static /*0x7ea8c58*/ nint Internal_GetSettingsForRenderPipeline_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper renderpipelineName);
            static /*0x7ea917c*/ nint get_INTERNAL_currentRenderPipeline_Injected();

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.GraphicsSettings.<> <>9;

                static /*0x7ea97c0*/ <>c();
                /*0x7ea9828*/ <>c();
                /*0x7ea9830*/ UnityEngine.Rendering.RenderPipelineGlobalSettings <.cctor>b__93_0();
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
            /*0x3814574*/ int get_version();
            /*0x7ea987c*/ bool get_isAvailableInPlayerBuild();
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
            /*0x7ea9884*/ ResourcePathsBaseAttribute(string[] paths, bool isField, UnityEngine.Rendering.SearchType location);
        }

        class ResourcePathAttribute : UnityEngine.Rendering.ResourcePathsBaseAttribute
        {
            /*0x7ea988c*/ ResourcePathAttribute(string path, UnityEngine.Rendering.SearchType location);
        }

        class OnDemandRendering
        {
            static /*0x0*/ int m_RenderFrameInterval;

            static /*0x7ea9944*/ OnDemandRendering();
            static /*0x7ea9894*/ int get_renderFrameInterval();
            static /*0x7ea98ec*/ void GetRenderFrameInterval(ref int frameInterval);
        }

        class RayTracingAccelerationStructure : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;

            static /*0x7ea9a84*/ void Destroy(UnityEngine.Rendering.RayTracingAccelerationStructure accelStruct);
            static /*0x7ea9acc*/ void Destroy_Injected(nint accelStruct);
            /*0x7ea9990*/ void Dispose();
            /*0x7ea9a2c*/ void Dispose(bool disposing);

            struct BuildSettings
            {
                /*0x10*/ UnityEngine.Rendering.RayTracingAccelerationStructureBuildFlags <buildFlags>k__BackingField;
                /*0x14*/ UnityEngine.Vector3 <relativeOrigin>k__BackingField;

                /*0x7ea9b1c*/ BuildSettings();
                /*0x7ea9b08*/ void set_buildFlags(UnityEngine.Rendering.RayTracingAccelerationStructureBuildFlags value);
                /*0x7ea9b10*/ void set_relativeOrigin(UnityEngine.Vector3 value);
            }

            class BindingsMarshaller
            {
                static /*0x7ea9b78*/ nint ConvertToNative(UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            }
        }

        class RenderPipelineGraphicsSettingsCollection
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> m_List;

            /*0x7ea9b98*/ RenderPipelineGraphicsSettingsCollection();
            /*0x7ea9b90*/ System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> get_settingsList();
        }

        class RenderPipelineGraphicsSettingsExtensions
        {
            static /*0x3910ae8*/ void SetValueAndNotify<T>(UnityEngine.Rendering.IRenderPipelineGraphicsSettings settings, ref T currentPropertyValue, T newValue, string propertyName);
        }

        class RecreatePipelineOnChangeAttribute : System.Attribute
        {
            /*0x7ea9c20*/ RecreatePipelineOnChangeAttribute();
        }

        class CommandBuffer : System.IDisposable
        {
            static /*0x0*/ bool ThrowOnSetRenderTarget;
            /*0x10*/ nint m_Ptr;

            static /*0x7eaac60*/ nint InitBuffer();
            static /*0x7eb4600*/ void CheckThrowOnSetRenderTarget();
            static /*0x7ea9d38*/ void Internal_RequestAsyncReadback_1_Injected(nint _unity_self, nint src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7ea9ebc*/ void Internal_RequestAsyncReadback_2_Injected(nint _unity_self, nint src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7eaa04c*/ void Internal_RequestAsyncReadback_3_Injected(nint _unity_self, nint src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7eaa1d4*/ void Internal_RequestAsyncReadback_4_Injected(nint _unity_self, nint src, int mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7eaa374*/ void Internal_RequestAsyncReadback_5_Injected(nint _unity_self, nint src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7eaa554*/ void Internal_RequestAsyncReadback_6_Injected(nint _unity_self, nint src, int mipIndex, int x, int width, int y, int height, int z, int depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7eaa768*/ void Internal_RequestAsyncReadback_7_Injected(nint _unity_self, nint src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7eaa930*/ void Internal_RequestAsyncReadback_8_Injected(nint _unity_self, nint src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7eaaab4*/ void Internal_RequestAsyncReadback_9_Injected(nint _unity_self, nint src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            static /*0x7eaab80*/ void SetInvertCulling_Injected(nint _unity_self, bool invertCulling);
            static /*0x7eaac1c*/ void Internal_SetSinglePassStereo_Injected(nint _unity_self, UnityEngine.Rendering.SinglePassStereoMode mode);
            static /*0x7eaacf0*/ nint CreateGPUFence_Internal_Injected(nint _unity_self, UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage);
            static /*0x7eaadac*/ void WaitOnGPUFence_Internal_Injected(nint _unity_self, nint fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage);
            static /*0x7eaae50*/ void ReleaseBuffer_Injected(nint _unity_self);
            static /*0x7eaaf84*/ void SetComputeFloatParam_Injected(nint _unity_self, nint computeShader, int nameID, float val);
            static /*0x7eab0d8*/ void SetComputeIntParam_Injected(nint _unity_self, nint computeShader, int nameID, int val);
            static /*0x7eab234*/ void SetComputeVectorParam_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Vector4 val);
            static /*0x7eab3f0*/ void SetComputeVectorArrayParam_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7eab53c*/ void SetComputeMatrixParam_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Matrix4x4 val);
            static /*0x7eab6f8*/ void SetComputeMatrixArrayParam_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7eab8b4*/ void Internal_SetComputeFloats_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7eaba70*/ void Internal_SetComputeInts_Injected(nint _unity_self, nint computeShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7eabbe4*/ void Internal_SetComputeTextureParam_Injected(nint _unity_self, nint computeShader, int kernelIndex, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            static /*0x7eabd70*/ void Internal_SetComputeBufferParam_Injected(nint _unity_self, nint computeShader, int kernelIndex, int nameID, nint buffer);
            static /*0x7eabee0*/ void Internal_SetComputeGraphicsBufferHandleParam_Injected(nint _unity_self, nint computeShader, int kernelIndex, int nameID, ref UnityEngine.GraphicsBufferHandle bufferHandle);
            static /*0x7eac054*/ void Internal_SetComputeGraphicsBufferParam_Injected(nint _unity_self, nint computeShader, int kernelIndex, int nameID, nint buffer);
            static /*0x7eac1d0*/ void Internal_SetComputeConstantComputeBufferParam_Injected(nint _unity_self, nint computeShader, int nameID, nint buffer, int offset, int size);
            static /*0x7eac354*/ void Internal_SetComputeConstantGraphicsBufferParam_Injected(nint _unity_self, nint computeShader, int nameID, nint buffer, int offset, int size);
            static /*0x7eac4d0*/ void Internal_DispatchCompute_Injected(nint _unity_self, nint computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            static /*0x7eac64c*/ void Internal_DispatchComputeIndirect_Injected(nint _unity_self, nint computeShader, int kernelIndex, nint indirectBuffer, uint argsOffset);
            static /*0x7eac7c0*/ void Internal_DispatchComputeIndirectGraphicsBuffer_Injected(nint _unity_self, nint computeShader, int kernelIndex, nint indirectBuffer, uint argsOffset);
            static /*0x7eac924*/ void Internal_SetRayTracingComputeBufferParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, nint buffer);
            static /*0x7eaca78*/ void Internal_SetRayTracingGraphicsBufferParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, nint buffer);
            static /*0x7eacbc8*/ void Internal_SetRayTracingGraphicsBufferHandleParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.GraphicsBufferHandle bufferHandle);
            static /*0x7eacd34*/ void Internal_SetRayTracingConstantComputeBufferParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, nint buffer, int offset, int size);
            static /*0x7eaceb8*/ void Internal_SetRayTracingConstantGraphicsBufferParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, nint buffer, int offset, int size);
            static /*0x7ead01c*/ void Internal_SetRayTracingTextureParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt);
            static /*0x7ead170*/ void Internal_SetRayTracingFloatParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, float val);
            static /*0x7ead2c4*/ void Internal_SetRayTracingIntParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, int val);
            static /*0x7ead420*/ void Internal_SetRayTracingVectorParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Vector4 val);
            static /*0x7ead5dc*/ void Internal_SetRayTracingVectorArrayParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7ead728*/ void Internal_SetRayTracingMatrixParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Matrix4x4 val);
            static /*0x7ead8e4*/ void Internal_SetRayTracingMatrixArrayParam_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7eadaa0*/ void Internal_SetRayTracingFloats_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7eadc5c*/ void Internal_SetRayTracingInts_Injected(nint _unity_self, nint rayTracingShader, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7eadd98*/ void Internal_BuildRayTracingAccelerationStructure_Injected(nint _unity_self, nint accelerationStructure, ref UnityEngine.Rendering.RayTracingAccelerationStructure.BuildSettings buildSettings);
            static /*0x7eadf2c*/ void Internal_SetRayTracingAccelerationStructure_Injected(nint _unity_self, nint rayTracingShader, int nameID, nint accelerationStructure);
            static /*0x7eae0d8*/ void Internal_SetComputeRayTracingAccelerationStructure_Injected(nint _unity_self, nint computeShader, int kernelIndex, int nameID, nint accelerationStructure);
            static /*0x7eae3a8*/ void Internal_DispatchRays_Injected(nint _unity_self, nint rayTracingShader, ref UnityEngine.Bindings.ManagedSpanWrapper rayGenShaderName, uint width, uint height, uint depth, nint camera);
            static /*0x7eae4ac*/ void CopyCounterValueCC_Injected(nint _unity_self, nint src, nint dst, uint dstOffsetBytes);
            static /*0x7eae588*/ void CopyCounterValueGC_Injected(nint _unity_self, nint src, nint dst, uint dstOffsetBytes);
            static /*0x7eae664*/ void CopyCounterValueCG_Injected(nint _unity_self, nint src, nint dst, uint dstOffsetBytes);
            static /*0x7eae740*/ void CopyCounterValueGG_Injected(nint _unity_self, nint src, nint dst, uint dstOffsetBytes);
            static /*0x7eae878*/ void get_name_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
            static /*0x7eaea4c*/ void set_name_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper value);
            static /*0x7eaeae0*/ int get_sizeInBytes_Injected(nint _unity_self);
            static /*0x7eaeb6c*/ void Clear_Injected(nint _unity_self);
            static /*0x7eaecf4*/ void Internal_DrawMesh_Injected(nint _unity_self, nint mesh, ref UnityEngine.Matrix4x4 matrix, nint material, int submeshIndex, int shaderPass, nint properties);
            static /*0x7eaef54*/ void Internal_DrawMultipleMeshes_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper matrices, UnityEngine.Mesh[] meshes, ref UnityEngine.Bindings.ManagedSpanWrapper subsetIndices, int count, nint material, int shaderPass, nint properties);
            static /*0x7eaf10c*/ void Internal_DrawRenderer_Injected(nint _unity_self, nint renderer, nint material, int submeshIndex, int shaderPass);
            static /*0x7eaf1d0*/ void Internal_DrawRendererList_Injected(nint _unity_self, ref UnityEngine.Rendering.RendererList rendererList);
            static /*0x7eaf30c*/ void Internal_DrawProcedural_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, nint properties);
            static /*0x7eaf4a8*/ void Internal_DrawProceduralIndexed_Injected(nint _unity_self, nint indexBuffer, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, nint properties);
            static /*0x7eaf644*/ void Internal_DrawProceduralIndirect_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x7eaf7e8*/ void Internal_DrawProceduralIndexedIndirect_Injected(nint _unity_self, nint indexBuffer, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x7eaf984*/ void Internal_DrawProceduralIndirectGraphicsBuffer_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x7eafb28*/ void Internal_DrawProceduralIndexedIndirectGraphicsBuffer_Injected(nint _unity_self, nint indexBuffer, ref UnityEngine.Matrix4x4 matrix, nint material, int shaderPass, UnityEngine.MeshTopology topology, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x7eafd64*/ void Internal_DrawMeshInstanced_Injected(nint _unity_self, nint mesh, int submeshIndex, nint material, int shaderPass, ref UnityEngine.Bindings.ManagedSpanWrapper matrices, int count, nint properties);
            static /*0x7eaff04*/ void Internal_DrawMeshInstancedProcedural_Injected(nint _unity_self, nint mesh, int submeshIndex, nint material, int shaderPass, int count, nint properties);
            static /*0x7eb00b4*/ void Internal_DrawMeshInstancedIndirect_Injected(nint _unity_self, nint mesh, int submeshIndex, nint material, int shaderPass, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x7eb026c*/ void Internal_DrawMeshInstancedIndirectGraphicsBuffer_Injected(nint _unity_self, nint mesh, int submeshIndex, nint material, int shaderPass, nint bufferWithArgs, int argsOffset, nint properties);
            static /*0x7eb035c*/ void Internal_DrawOcclusionMesh_Injected(nint _unity_self, ref UnityEngine.RectInt normalizedCamViewport);
            static /*0x7eb0408*/ void SetRandomWriteTarget_Texture_Injected(nint _unity_self, int index, ref UnityEngine.Rendering.RenderTargetIdentifier rt);
            static /*0x7eb04d4*/ void SetRandomWriteTarget_GraphicsBuffer_Injected(nint _unity_self, int index, nint uav, bool preserveCounterValue);
            static /*0x7eb0580*/ void ClearRandomWriteTargets_Injected(nint _unity_self);
            static /*0x7eb0624*/ void SetViewport_Injected(nint _unity_self, ref UnityEngine.Rect pixelRect);
            static /*0x7eb06d0*/ void EnableScissorRect_Injected(nint _unity_self, ref UnityEngine.Rect scissor);
            static /*0x7eb0764*/ void DisableScissorRect_Injected(nint _unity_self);
            static /*0x7eb08b0*/ void CopyTexture_Internal_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode);
            static /*0x7eb0aa0*/ void Blit_Texture_Injected(nint _unity_self, nint source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, nint mat, int pass, ref UnityEngine.Vector2 scale, ref UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            static /*0x7eb0c38*/ void Blit_Identifier_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, nint mat, int pass, ref UnityEngine.Vector2 scale, ref UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            static /*0x7eb0ddc*/ void GetTemporaryRT_Injected(nint _unity_self, int nameID, int width, int height, UnityEngine.FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int antiAliasing, bool enableRandomWrite, UnityEngine.RenderTextureMemoryless memorylessMode, bool useDynamicScale, UnityEngine.Rendering.ShadowSamplingMode shadowSamplingMode);
            static /*0x7eb110c*/ void GetTemporaryRTWithDescriptor_Injected(nint _unity_self, int nameID, ref UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter);
            static /*0x7eb11f4*/ void ReleaseTemporaryRT_Injected(nint _unity_self, int nameID);
            static /*0x7eb1744*/ void SetGlobalFloat_Injected(nint _unity_self, int nameID, float value);
            static /*0x7eb1800*/ void SetGlobalInt_Injected(nint _unity_self, int nameID, int value);
            static /*0x7eb18bc*/ void SetGlobalInteger_Injected(nint _unity_self, int nameID, int value);
            static /*0x7eb1980*/ void SetGlobalVector_Injected(nint _unity_self, int nameID, ref UnityEngine.Vector4 value);
            static /*0x7eb1a44*/ void SetGlobalColor_Injected(nint _unity_self, int nameID, ref UnityEngine.Color value);
            static /*0x7eb1b00*/ void SetGlobalMatrix_Injected(nint _unity_self, int nameID, ref UnityEngine.Matrix4x4 value);
            static /*0x7eb1ce4*/ void EnableShaderKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            static /*0x7eb1d8c*/ void EnableGlobalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.GlobalKeyword keyword);
            static /*0x7eb1e80*/ void EnableMaterialKeyword_Injected(nint _unity_self, nint material, ref UnityEngine.Rendering.LocalKeyword keyword);
            static /*0x7eb1f84*/ void EnableComputeKeyword_Injected(nint _unity_self, nint computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            static /*0x7eb21cc*/ void DisableShaderKeyword_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            static /*0x7eb2274*/ void DisableGlobalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.GlobalKeyword keyword);
            static /*0x7eb2368*/ void DisableMaterialKeyword_Injected(nint _unity_self, nint material, ref UnityEngine.Rendering.LocalKeyword keyword);
            static /*0x7eb246c*/ void DisableComputeKeyword_Injected(nint _unity_self, nint computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            static /*0x7eb2590*/ void SetGlobalKeyword_Injected(nint _unity_self, ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            static /*0x7eb26a4*/ void SetMaterialKeyword_Injected(nint _unity_self, nint material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            static /*0x7eb27c0*/ void SetComputeKeyword_Injected(nint _unity_self, nint computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            static /*0x7eb28f8*/ void SetViewProjectionMatrices_Injected(nint _unity_self, ref UnityEngine.Matrix4x4 view, ref UnityEngine.Matrix4x4 proj);
            static /*0x7eb29b4*/ void SetGlobalDepthBias_Injected(nint _unity_self, float bias, float slopeBias);
            static /*0x7eb2a60*/ void SetExecutionFlags_Injected(nint _unity_self, UnityEngine.Rendering.CommandBufferExecutionFlags flags);
            static /*0x7eb2aa4*/ bool ValidateAgainstExecutionFlags_Injected(nint _unity_self, UnityEngine.Rendering.CommandBufferExecutionFlags requiredFlags, UnityEngine.Rendering.CommandBufferExecutionFlags invalidFlags);
            static /*0x7eb2b60*/ void SetGlobalFloatArrayListImpl_Injected(nint _unity_self, int nameID, object values);
            static /*0x7eb2c1c*/ void SetGlobalVectorArrayListImpl_Injected(nint _unity_self, int nameID, object values);
            static /*0x7eb2cd8*/ void SetGlobalMatrixArrayListImpl_Injected(nint _unity_self, int nameID, object values);
            static /*0x7eb2e54*/ void SetGlobalFloatArray_Injected(nint _unity_self, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7eb2fd0*/ void SetGlobalVectorArray_Injected(nint _unity_self, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7eb314c*/ void SetGlobalMatrixArray_Injected(nint _unity_self, int nameID, ref UnityEngine.Bindings.ManagedSpanWrapper values);
            static /*0x7eb32b8*/ void SetLateLatchProjectionMatrices_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper projectionMat);
            static /*0x7eb3364*/ void MarkLateLatchMatrixShaderPropertyID_Injected(nint _unity_self, UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            static /*0x7eb3410*/ void UnmarkLateLatchMatrix_Injected(nint _unity_self, UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            static /*0x7eb34c4*/ void SetGlobalTexture_Impl_Injected(nint _unity_self, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderTextureSubElement element);
            static /*0x7eb3590*/ void SetGlobalBufferInternal_Injected(nint _unity_self, int nameID, nint value);
            static /*0x7eb3654*/ void SetGlobalGraphicsBufferInternal_Injected(nint _unity_self, int nameID, nint value);
            static /*0x7eb3710*/ void SetShadowSamplingMode_Impl_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            static /*0x7eb37cc*/ void IssuePluginEventInternal_Injected(nint _unity_self, nint callback, int eventID);
            static /*0x7eb39b0*/ void BeginSample_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            static /*0x7eb3b84*/ void EndSample_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            static /*0x7eb3d68*/ void BeginSample_CustomSampler_Injected(nint _unity_self, nint sampler);
            static /*0x7eb3dac*/ void EndSample_CustomSampler_Injected(nint _unity_self, nint sampler);
            static /*0x7eb3e60*/ void IssuePluginEventAndDataInternal_Injected(nint _unity_self, nint callback, int eventID, nint data);
            static /*0x7eb3f54*/ void IssuePluginCustomBlitInternal_Injected(nint _unity_self, nint callback, uint command, ref UnityEngine.Rendering.RenderTargetIdentifier source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            static /*0x7eb40a0*/ void IssuePluginCustomTextureUpdateInternal_Injected(nint _unity_self, nint callback, nint targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2);
            static /*0x7eb4194*/ void SetGlobalConstantBufferInternal_Injected(nint _unity_self, nint buffer, int nameID, int offset, int size);
            static /*0x7eb4288*/ void SetGlobalConstantGraphicsBufferInternal_Injected(nint _unity_self, nint buffer, int nameID, int offset, int size);
            static /*0x7eb434c*/ void IncrementUpdateCount_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier dest);
            static /*0x7eb43e8*/ void SetInstanceMultiplier_Injected(nint _unity_self, uint multiplier);
            static /*0x7eb4484*/ void SetFoveatedRenderingMode_Injected(nint _unity_self, UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            static /*0x7eb4520*/ void SetWireframe_Injected(nint _unity_self, bool enable);
            static /*0x7eb45bc*/ void ConfigureFoveatedRendering_Injected(nint _unity_self, nint platformData);
            static /*0x7eb6104*/ void ClearRenderTargetSingle_Internal_Injected(nint _unity_self, UnityEngine.Rendering.RTClearFlags clearFlags, ref UnityEngine.Color color, float depth, uint stencil);
            static /*0x7eb6170*/ void ClearRenderTargetMulti_Internal_Injected(nint _unity_self, UnityEngine.Rendering.RTClearFlags clearFlags, ref UnityEngine.Bindings.ManagedSpanWrapper colors, float depth, uint stencil);
            static /*0x7eb61dc*/ void SetRenderTargetSingle_Internal_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            static /*0x7eb6250*/ void SetRenderTargetColorDepth_Internal_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier color, ref UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags);
            static /*0x7eb62dc*/ void SetRenderTargetMulti_Internal_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, ref UnityEngine.Rendering.RenderTargetIdentifier depth, ref UnityEngine.Bindings.ManagedSpanWrapper colorLoadActions, ref UnityEngine.Bindings.ManagedSpanWrapper colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags);
            static /*0x7eb6368*/ void SetRenderTargetColorDepthSubtarget_Injected(nint _unity_self, ref UnityEngine.Rendering.RenderTargetIdentifier color, ref UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7eb640c*/ void SetRenderTargetMultiSubtarget_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper colors, ref UnityEngine.Rendering.RenderTargetIdentifier depth, ref UnityEngine.Bindings.ManagedSpanWrapper colorLoadActions, ref UnityEngine.Bindings.ManagedSpanWrapper colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            static /*0x7eb6b28*/ void InternalSetComputeBufferNativeData_Injected(nint _unity_self, nint buffer, nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            static /*0x7eb6bac*/ void InternalSetComputeBufferData_Injected(nint _unity_self, nint buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            static /*0x7eb6c30*/ void InternalSetComputeBufferCounterValue_Injected(nint _unity_self, nint buffer, uint counterValue);
            static /*0x7eb72fc*/ void InternalSetGraphicsBufferNativeData_Injected(nint _unity_self, nint buffer, nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            static /*0x7eb7380*/ void InternalSetGraphicsBufferData_Injected(nint _unity_self, nint buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            static /*0x7eb7404*/ void InternalSetGraphicsBufferCounterValue_Injected(nint _unity_self, nint buffer, uint counterValue);
            static /*0x7eb760c*/ void BeginRenderPass_Internal_Injected(nint _unity_self, int width, int height, int volumeDepth, int samples, ref UnityEngine.Bindings.ManagedSpanWrapper attachments, int depthAttachmentIndex, ref UnityEngine.Bindings.ManagedSpanWrapper subPasses, ref UnityEngine.Bindings.ManagedSpanWrapper debugNameUtf8);
            static /*0x7eb77f8*/ void NextSubPass_Internal_Injected(nint _unity_self);
            static /*0x7eb78a4*/ void EndRenderPass_Internal_Injected(nint _unity_self);
            static /*0x7eb79d8*/ void SetupCameraProperties_Internal_Injected(nint _unity_self, nint camera);
            static /*0x7eb7a9c*/ void InvokeOnRenderObjectCallbacks_Internal_Injected(nint _unity_self);
            /*0x7eb7c0c*/ CommandBuffer();
            /*0x3816920*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.ComputeBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.ComputeBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3816920*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.GraphicsBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.GraphicsBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3816920*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3910ae8*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3910ae8*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.TextureFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x3910ae8*/ void RequestAsyncReadbackIntoNativeArray<T>(ref Unity.Collections.NativeArray<T> output, UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback);
            /*0x7ea9c28*/ void Internal_RequestAsyncReadback_1(UnityEngine.ComputeBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7ea9d94*/ void Internal_RequestAsyncReadback_2(UnityEngine.ComputeBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7ea9f30*/ void Internal_RequestAsyncReadback_3(UnityEngine.Texture src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7eaa0a8*/ void Internal_RequestAsyncReadback_4(UnityEngine.Texture src, int mipIndex, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7eaa240*/ void Internal_RequestAsyncReadback_5(UnityEngine.Texture src, int mipIndex, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7eaa3e8*/ void Internal_RequestAsyncReadback_6(UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7eaa5fc*/ void Internal_RequestAsyncReadback_7(UnityEngine.Texture src, int mipIndex, int x, int width, int y, int height, int z, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat dstFormat, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7eaa820*/ void Internal_RequestAsyncReadback_8(UnityEngine.GraphicsBuffer src, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7eaa98c*/ void Internal_RequestAsyncReadback_9(UnityEngine.GraphicsBuffer src, int size, int offset, System.Action<UnityEngine.Rendering.AsyncGPUReadbackRequest> callback, UnityEngine.Rendering.AsyncRequestNativeArrayData* nativeArrayData);
            /*0x7eaab28*/ void SetInvertCulling(bool invertCulling);
            /*0x7eaabc4*/ void Internal_SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x7eaac88*/ nint CreateGPUFence_Internal(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x7eaad44*/ void WaitOnGPUFence_Internal(nint fencePtr, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x7eaae00*/ void ReleaseBuffer();
            /*0x7eaae8c*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, int nameID, float val);
            /*0x7eaafe8*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, int nameID, int val);
            /*0x7eab134*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4 val);
            /*0x7eab290*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Vector4[] values);
            /*0x7eab44c*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x7eab598*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7eab754*/ void Internal_SetComputeFloats(UnityEngine.ComputeShader computeShader, int nameID, float[] values);
            /*0x7eab910*/ void Internal_SetComputeInts(UnityEngine.ComputeShader computeShader, int nameID, int[] values);
            /*0x7eabacc*/ void Internal_SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7eabc68*/ void Internal_SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7eabddc*/ void Internal_SetComputeGraphicsBufferHandleParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7eabf4c*/ void Internal_SetComputeGraphicsBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7eac0c0*/ void Internal_SetComputeConstantComputeBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7eac244*/ void Internal_SetComputeConstantGraphicsBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7eac3c8*/ void Internal_DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x7eac544*/ void Internal_DispatchComputeIndirect(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset);
            /*0x7eac6b8*/ void Internal_DispatchComputeIndirectGraphicsBuffer(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset);
            /*0x7eac82c*/ void Internal_SetRayTracingComputeBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7eac980*/ void Internal_SetRayTracingGraphicsBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7eacad4*/ void Internal_SetRayTracingGraphicsBufferHandleParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7eacc24*/ void Internal_SetRayTracingConstantComputeBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7eacda8*/ void Internal_SetRayTracingConstantGraphicsBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7eacf2c*/ void Internal_SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7ead078*/ void Internal_SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float val);
            /*0x7ead1d4*/ void Internal_SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int val);
            /*0x7ead320*/ void Internal_SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4 val);
            /*0x7ead47c*/ void Internal_SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4[] values);
            /*0x7ead638*/ void Internal_SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x7ead784*/ void Internal_SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7ead940*/ void Internal_SetRayTracingFloats(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float[] values);
            /*0x7eadafc*/ void Internal_SetRayTracingInts(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int[] values);
            /*0x7eadcb8*/ void Internal_BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure, UnityEngine.Rendering.RayTracingAccelerationStructure.BuildSettings buildSettings);
            /*0x7eaddec*/ void Internal_SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x7eadf88*/ void Internal_SetComputeRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x7eae144*/ void Internal_DispatchRays(UnityEngine.Rendering.RayTracingShader rayTracingShader, string rayGenShaderName, uint width, uint height, uint depth, UnityEngine.Camera camera);
            /*0x7eae42c*/ void CopyCounterValueCC(UnityEngine.ComputeBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7eae508*/ void CopyCounterValueGC(UnityEngine.GraphicsBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7eae5e4*/ void CopyCounterValueCG(UnityEngine.ComputeBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7eae6c0*/ void CopyCounterValueGG(UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7eae79c*/ string get_name();
            /*0x7eae8bc*/ void set_name(string value);
            /*0x7eaea90*/ int get_sizeInBytes();
            /*0x7eaeb1c*/ void Clear();
            /*0x7eaeba8*/ void Internal_DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eaed78*/ void Internal_DrawMultipleMeshes(UnityEngine.Matrix4x4[] matrices, UnityEngine.Mesh[] meshes, int[] subsetIndices, int count, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eaefe0*/ void Internal_DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x7eaf178*/ void Internal_DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x7eaf214*/ void Internal_DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eaf398*/ void Internal_DrawProceduralIndexed(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eaf544*/ void Internal_DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eaf6d0*/ void Internal_DrawProceduralIndexedIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eaf884*/ void Internal_DrawProceduralIndirectGraphicsBuffer(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eafa10*/ void Internal_DrawProceduralIndexedIndirectGraphicsBuffer(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eafbc4*/ void Internal_DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eafdf0*/ void Internal_DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eaff88*/ void Internal_DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eb0140*/ void Internal_DrawMeshInstancedIndirectGraphicsBuffer(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eb02f8*/ void Internal_DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
            /*0x7eb03a0*/ void SetRandomWriteTarget_Texture(int index, ref UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7eb045c*/ void SetRandomWriteTarget_GraphicsBuffer(int index, UnityEngine.GraphicsBuffer uav, bool preserveCounterValue);
            /*0x7eb0530*/ void ClearRandomWriteTargets();
            /*0x7eb05bc*/ void SetViewport(UnityEngine.Rect pixelRect);
            /*0x7eb0668*/ void EnableScissorRect(UnityEngine.Rect scissor);
            /*0x7eb0714*/ void DisableScissorRect();
            /*0x7eb07a0*/ void CopyTexture_Internal(ref UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, ref UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement, int dstMip, int dstX, int dstY, int mode);
            /*0x7eb0978*/ void Blit_Texture(UnityEngine.Texture source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Material mat, int pass, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            /*0x7eb0b3c*/ void Blit_Identifier(ref UnityEngine.Rendering.RenderTargetIdentifier source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Material mat, int pass, UnityEngine.Vector2 scale, UnityEngine.Vector2 offset, int sourceDepthSlice, int destDepthSlice);
            /*0x7eb0cd4*/ void GetTemporaryRT(int nameID, int width, int height, UnityEngine.FilterMode filter, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int antiAliasing, bool enableRandomWrite, UnityEngine.RenderTextureMemoryless memorylessMode, bool useDynamicScale, UnityEngine.Rendering.ShadowSamplingMode shadowSamplingMode);
            /*0x7eb0e98*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, UnityEngine.RenderTextureMemoryless memorylessMode, bool useDynamicScale);
            /*0x7eb0fa8*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite, UnityEngine.RenderTextureMemoryless memorylessMode);
            /*0x7eb0fe0*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing, bool enableRandomWrite);
            /*0x7eb1014*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int antiAliasing);
            /*0x7eb1040*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
            /*0x7eb106c*/ void GetTemporaryRT(int nameID, int width, int height, int depthBuffer, UnityEngine.FilterMode filter, UnityEngine.RenderTextureFormat format);
            /*0x7eb109c*/ void GetTemporaryRTWithDescriptor(int nameID, UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter);
            /*0x7eb1168*/ void GetTemporaryRT(int nameID, UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filter);
            /*0x7eb119c*/ void ReleaseTemporaryRT(int nameID);
            /*0x7eb1238*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor);
            /*0x7eb12e4*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
            /*0x7eb124c*/ void ClearRenderTarget(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x7eb13ec*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color backgroundColor, float depth, uint stencil);
            /*0x7eb1464*/ void ClearRenderTarget(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color[] backgroundColors, float depth, uint stencil);
            /*0x7eb16dc*/ void SetGlobalFloat(int nameID, float value);
            /*0x7eb1798*/ void SetGlobalInt(int nameID, int value);
            /*0x7eb1854*/ void SetGlobalInteger(int nameID, int value);
            /*0x7eb1910*/ void SetGlobalVector(int nameID, UnityEngine.Vector4 value);
            /*0x7eb19d4*/ void SetGlobalColor(int nameID, UnityEngine.Color value);
            /*0x7eb1a98*/ void SetGlobalMatrix(int nameID, UnityEngine.Matrix4x4 value);
            /*0x7eb1b54*/ void EnableShaderKeyword(string keyword);
            /*0x7eb1d28*/ void EnableGlobalKeyword(UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7eb1dd0*/ void EnableMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7eb1ed4*/ void EnableComputeKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7eb1fd8*/ void EnableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7eb1fe4*/ void EnableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7eb2010*/ void EnableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7eb203c*/ void DisableShaderKeyword(string keyword);
            /*0x7eb2210*/ void DisableGlobalKeyword(UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7eb22b8*/ void DisableMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7eb23bc*/ void DisableComputeKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7eb24c0*/ void DisableKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword);
            /*0x7eb24cc*/ void DisableKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7eb24f8*/ void DisableKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword);
            /*0x7eb2524*/ void SetGlobalKeyword(UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7eb25e4*/ void SetMaterialKeyword(UnityEngine.Material material, UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7eb2700*/ void SetComputeKeyword(UnityEngine.ComputeShader computeShader, UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7eb281c*/ void SetKeyword(ref UnityEngine.Rendering.GlobalKeyword keyword, bool value);
            /*0x7eb2830*/ void SetKeyword(UnityEngine.Material material, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7eb2860*/ void SetKeyword(UnityEngine.ComputeShader computeShader, ref UnityEngine.Rendering.LocalKeyword keyword, bool value);
            /*0x7eb2890*/ void SetViewProjectionMatrices(UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 proj);
            /*0x7eb294c*/ void SetGlobalDepthBias(float bias, float slopeBias);
            /*0x7eb2a08*/ void SetExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags flags);
            /*0x7eb12f4*/ bool ValidateAgainstExecutionFlags(UnityEngine.Rendering.CommandBufferExecutionFlags requiredFlags, UnityEngine.Rendering.CommandBufferExecutionFlags invalidFlags);
            /*0x7eb2af8*/ void SetGlobalFloatArrayListImpl(int nameID, object values);
            /*0x7eb2bb4*/ void SetGlobalVectorArrayListImpl(int nameID, object values);
            /*0x7eb2c70*/ void SetGlobalMatrixArrayListImpl(int nameID, object values);
            /*0x7eb2d2c*/ void SetGlobalFloatArray(int nameID, float[] values);
            /*0x7eb2ea8*/ void SetGlobalVectorArray(int nameID, UnityEngine.Vector4[] values);
            /*0x7eb3024*/ void SetGlobalMatrixArray(int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7eb31a0*/ void SetLateLatchProjectionMatrices(UnityEngine.Matrix4x4[] projectionMat);
            /*0x7eb32fc*/ void MarkLateLatchMatrixShaderPropertyID(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType, int shaderPropertyID);
            /*0x7eb33b8*/ void UnmarkLateLatchMatrix(UnityEngine.Rendering.CameraLateLatchMatrixType matrixPropertyType);
            /*0x7eb3454*/ void SetGlobalTexture_Impl(int nameID, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7eb3520*/ void SetGlobalBufferInternal(int nameID, UnityEngine.ComputeBuffer value);
            /*0x7eb35e4*/ void SetGlobalGraphicsBufferInternal(int nameID, UnityEngine.GraphicsBuffer value);
            /*0x7eb36a8*/ void SetShadowSamplingMode_Impl(ref UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x7eb3764*/ void IssuePluginEventInternal(nint callback, int eventID);
            /*0x7eb3820*/ void BeginSample(string name);
            /*0x7eb39f4*/ void EndSample(string name);
            /*0x7eb3bc8*/ void BeginSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7eb3c98*/ void EndSample(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7eb3bcc*/ void BeginSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7eb3c9c*/ void EndSample_CustomSampler(UnityEngine.Profiling.CustomSampler sampler);
            /*0x7eb3df0*/ void IssuePluginEventAndDataInternal(nint callback, int eventID, nint data);
            /*0x7eb3ebc*/ void IssuePluginCustomBlitInternal(nint callback, uint command, ref UnityEngine.Rendering.RenderTargetIdentifier source, ref UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x7eb3fd8*/ void IssuePluginCustomTextureUpdateInternal(nint callback, UnityEngine.Texture targetTexture, uint userData, bool useNewUnityRenderingExtTextureUpdateParamsV2);
            /*0x7eb410c*/ void SetGlobalConstantBufferInternal(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x7eb4200*/ void SetGlobalConstantGraphicsBufferInternal(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x7eb42f4*/ void IncrementUpdateCount(UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x7eb4390*/ void SetInstanceMultiplier(uint multiplier);
            /*0x7eb442c*/ void SetFoveatedRenderingMode(UnityEngine.Rendering.FoveatedRenderingMode foveatedRenderingMode);
            /*0x7eb44c8*/ void SetWireframe(bool enable);
            /*0x7eb4564*/ void ConfigureFoveatedRendering(nint platformData);
            /*0x7eb4694*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7eb4780*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction);
            /*0x7eb4844*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x7eb4920*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x7eb4a0c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x7eb4b04*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7eb4c30*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x7eb4d50*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel);
            /*0x7eb4e68*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace);
            /*0x7eb4f7c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7eb50cc*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x7eb51c4*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth);
            /*0x7eb554c*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7eb5908*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7eb5d74*/ void SetRenderTarget(UnityEngine.Rendering.RenderTargetBinding binding);
            /*0x7eb135c*/ void ClearRenderTargetSingle_Internal(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color color, float depth, uint stencil);
            /*0x7eb15c4*/ void ClearRenderTargetMulti_Internal(UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color[] colors, float depth, uint stencil);
            /*0x7eb46f8*/ void SetRenderTargetSingle_Internal(UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
            /*0x7eb4cb0*/ void SetRenderTargetColorDepth_Internal(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags);
            /*0x7eb5334*/ void SetRenderTargetMulti_Internal(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.RenderTargetFlags flags);
            /*0x7eb5cbc*/ void SetRenderTargetColorDepthSubtarget(UnityEngine.Rendering.RenderTargetIdentifier color, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7eb56e0*/ void SetRenderTargetMultiSubtarget(UnityEngine.Rendering.RenderTargetIdentifier[] colors, UnityEngine.Rendering.RenderTargetIdentifier depth, UnityEngine.Rendering.RenderBufferLoadAction[] colorLoadActions, UnityEngine.Rendering.RenderBufferStoreAction[] colorStoreActions, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, int mipLevel, UnityEngine.CubemapFace cubemapFace, int depthSlice);
            /*0x7eb64b0*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data);
            /*0x3816810*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x7eb66fc*/ void SetBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.ComputeBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x7eb693c*/ void SetBufferCounterValue(UnityEngine.ComputeBuffer buffer, uint counterValue);
            /*0x7eb6a1c*/ void InternalSetComputeBufferNativeData(UnityEngine.ComputeBuffer buffer, nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            /*0x7eb65f0*/ void InternalSetComputeBufferData(UnityEngine.ComputeBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            /*0x7eb6940*/ void InternalSetComputeBufferCounterValue(UnityEngine.ComputeBuffer buffer, uint counterValue);
            /*0x7eb6c84*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data);
            /*0x3816810*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data);
            /*0x7eb6ed0*/ void SetBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, System.Collections.Generic.List<T> data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x3910ae8*/ void SetBufferData<T>(UnityEngine.GraphicsBuffer buffer, Unity.Collections.NativeArray<T> data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count);
            /*0x7eb7110*/ void SetBufferCounterValue(UnityEngine.GraphicsBuffer buffer, uint counterValue);
            /*0x7eb71f0*/ void InternalSetGraphicsBufferNativeData(UnityEngine.GraphicsBuffer buffer, nint data, int nativeBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            /*0x7eb6dc4*/ void InternalSetGraphicsBufferData(UnityEngine.GraphicsBuffer buffer, System.Array data, int managedBufferStartIndex, int graphicsBufferStartIndex, int count, int elemSize);
            /*0x7eb7114*/ void InternalSetGraphicsBufferCounterValue(UnityEngine.GraphicsBuffer buffer, uint counterValue);
            /*0x7eb7458*/ void BeginRenderPass_Internal(int width, int height, int volumeDepth, int samples, System.ReadOnlySpan<UnityEngine.Rendering.AttachmentDescriptor> attachments, int depthAttachmentIndex, System.ReadOnlySpan<UnityEngine.Rendering.SubPassDescriptor> subPasses, System.ReadOnlySpan<byte> debugNameUtf8);
            /*0x7eb76a8*/ void BeginRenderPass(int width, int height, int volumeDepth, int samples, Unity.Collections.NativeArray<UnityEngine.Rendering.AttachmentDescriptor> attachments, int depthAttachmentIndex, Unity.Collections.NativeArray<UnityEngine.Rendering.SubPassDescriptor> subPasses, System.ReadOnlySpan<byte> debugNameUtf8);
            /*0x7eb77a8*/ void NextSubPass_Internal();
            /*0x7eb7834*/ void NextSubPass();
            /*0x7eb7854*/ void EndRenderPass_Internal();
            /*0x7eb78e0*/ void EndRenderPass();
            /*0x7eb7900*/ void SetupCameraProperties_Internal(UnityEngine.Camera camera);
            /*0x7eb7a1c*/ void SetupCameraProperties(UnityEngine.Camera camera);
            /*0x7eb7a4c*/ void InvokeOnRenderObjectCallbacks_Internal();
            /*0x7eb7ad8*/ void InvokeOnRenderObjectCallbacks();
            /*0x7eb7af8*/ void Finalize();
            /*0x7eb7ba8*/ void Dispose();
            /*0x7eb7b90*/ void Dispose(bool disposing);
            /*0x7eb7c54*/ void Release();
            /*0x7eb7c58*/ UnityEngine.Rendering.GraphicsFence CreateAsyncGraphicsFence();
            /*0x7eb7c64*/ UnityEngine.Rendering.GraphicsFence CreateGraphicsFence(UnityEngine.Rendering.GraphicsFenceType fenceType, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x7eb7c9c*/ void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence);
            /*0x7eb7ca4*/ void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStage stage);
            /*0x7eb7cb4*/ void WaitOnAsyncGraphicsFence(UnityEngine.Rendering.GraphicsFence fence, UnityEngine.Rendering.SynchronisationStageFlags stage);
            /*0x7eb7d98*/ void SetComputeFloatParam(UnityEngine.ComputeShader computeShader, string name, float val);
            /*0x7eb7ddc*/ void SetComputeIntParam(UnityEngine.ComputeShader computeShader, string name, int val);
            /*0x7eb7e18*/ void SetComputeVectorParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4 val);
            /*0x7eb7e7c*/ void SetComputeVectorArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Vector4[] values);
            /*0x7eb7eb8*/ void SetComputeMatrixParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4 val);
            /*0x7eb7f10*/ void SetComputeMatrixArrayParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x7eb7f4c*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, string name, float[] values);
            /*0x7eb7f88*/ void SetComputeFloatParams(UnityEngine.ComputeShader computeShader, int nameID, float[] values);
            /*0x7eb7f8c*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, string name, int[] values);
            /*0x7eb7fc8*/ void SetComputeIntParams(UnityEngine.ComputeShader computeShader, int nameID, int[] values);
            /*0x7eb7fcc*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7eb8020*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7eb802c*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x7eb8084*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel);
            /*0x7eb808c*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7eb80f0*/ void SetComputeTextureParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RenderTargetIdentifier rt, int mipLevel, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7eb80f4*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7eb80f8*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.ComputeBuffer buffer);
            /*0x7eb8144*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7eb814c*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7eb8198*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7eb819c*/ void SetComputeBufferParam(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x7eb81e8*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7eb81ec*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7eb8240*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7eb8244*/ void SetComputeConstantBufferParam(UnityEngine.ComputeShader computeShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7eb8298*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ);
            /*0x7eb829c*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.ComputeBuffer indirectBuffer, uint argsOffset);
            /*0x7eb8344*/ void DispatchCompute(UnityEngine.ComputeShader computeShader, int kernelIndex, UnityEngine.GraphicsBuffer indirectBuffer, uint argsOffset);
            /*0x7eb83ec*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure);
            /*0x7eb8450*/ void BuildRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingAccelerationStructure accelerationStructure, UnityEngine.Vector3 relativeOrigin);
            /*0x7eb84c8*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7eb8504*/ void SetRayTracingAccelerationStructure(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7eb8508*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, string name, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7eb8554*/ void SetRayTracingAccelerationStructure(UnityEngine.ComputeShader computeShader, int kernelIndex, int nameID, UnityEngine.Rendering.RayTracingAccelerationStructure rayTracingAccelerationStructure);
            /*0x7eb8558*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer);
            /*0x7eb8594*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer);
            /*0x7eb8598*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer);
            /*0x7eb85d4*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer);
            /*0x7eb85d8*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7eb8614*/ void SetRayTracingBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBufferHandle bufferHandle);
            /*0x7eb861c*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7eb8620*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.ComputeBuffer buffer, int offset, int size);
            /*0x7eb8674*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7eb8678*/ void SetRayTracingConstantBufferParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.GraphicsBuffer buffer, int offset, int size);
            /*0x7eb86cc*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7eb8708*/ void SetRayTracingTextureParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7eb870c*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float val);
            /*0x7eb8750*/ void SetRayTracingFloatParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float val);
            /*0x7eb8754*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, float[] values);
            /*0x7eb8790*/ void SetRayTracingFloatParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, float[] values);
            /*0x7eb8794*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int val);
            /*0x7eb87d0*/ void SetRayTracingIntParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int val);
            /*0x7eb87d4*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, int[] values);
            /*0x7eb8810*/ void SetRayTracingIntParams(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, int[] values);
            /*0x7eb8814*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4 val);
            /*0x7eb8878*/ void SetRayTracingVectorParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4 val);
            /*0x7eb887c*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Vector4[] values);
            /*0x7eb88b8*/ void SetRayTracingVectorArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Vector4[] values);
            /*0x7eb88bc*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4 val);
            /*0x7eb8914*/ void SetRayTracingMatrixParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4 val);
            /*0x7eb8940*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, string name, UnityEngine.Matrix4x4[] values);
            /*0x7eb897c*/ void SetRayTracingMatrixArrayParam(UnityEngine.Rendering.RayTracingShader rayTracingShader, int nameID, UnityEngine.Matrix4x4[] values);
            /*0x7eb8980*/ void DispatchRays(UnityEngine.Rendering.RayTracingShader rayTracingShader, string rayGenName, uint width, uint height, uint depth, UnityEngine.Camera camera);
            /*0x7eb8984*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eb8bbc*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x7eb8bec*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int submeshIndex);
            /*0x7eb8c20*/ void DrawMesh(UnityEngine.Mesh mesh, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material);
            /*0x7eb8c58*/ void DrawMultipleMeshes(UnityEngine.Matrix4x4[] matrices, UnityEngine.Mesh[] meshes, int[] subsetIndices, int count, UnityEngine.Material material, int shaderPass, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eb8d00*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex, int shaderPass);
            /*0x7eb8ec0*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material, int submeshIndex);
            /*0x7eb8ec8*/ void DrawRenderer(UnityEngine.Renderer renderer, UnityEngine.Material material);
            /*0x7eb8ed4*/ void DrawRendererList(UnityEngine.Rendering.RendererList rendererList);
            /*0x7eb8f00*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eb9034*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount, int instanceCount);
            /*0x7eb9064*/ void DrawProcedural(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int vertexCount);
            /*0x7eb9098*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eb91e0*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount, int instanceCount);
            /*0x7eb9210*/ void DrawProcedural(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, int indexCount);
            /*0x7eb9244*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eb93d4*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7eb9404*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7eb9438*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eb95e4*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7eb9614*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7eb9648*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eb97d8*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7eb9808*/ void DrawProceduralIndirect(UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7eb983c*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eb99e8*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7eb9a18*/ void DrawProceduralIndirect(UnityEngine.GraphicsBuffer indexBuffer, UnityEngine.Matrix4x4 matrix, UnityEngine.Material material, int shaderPass, UnityEngine.MeshTopology topology, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7eb9a4c*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eb9dd0*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices, int count);
            /*0x7eb9dec*/ void DrawMeshInstanced(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.Matrix4x4[] matrices);
            /*0x7eb9e14*/ void DrawMeshInstancedProcedural(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, int count, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eba044*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eba280*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs, int argsOffset);
            /*0x7eba29c*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.ComputeBuffer bufferWithArgs);
            /*0x7eba2bc*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset, UnityEngine.MaterialPropertyBlock properties);
            /*0x7eba4f8*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs, int argsOffset);
            /*0x7eba514*/ void DrawMeshInstancedIndirect(UnityEngine.Mesh mesh, int submeshIndex, UnityEngine.Material material, int shaderPass, UnityEngine.GraphicsBuffer bufferWithArgs);
            /*0x7eba534*/ void DrawOcclusionMesh(UnityEngine.RectInt normalizedCamViewport);
            /*0x7eba538*/ void SetRandomWriteTarget(int index, UnityEngine.Rendering.RenderTargetIdentifier rt);
            /*0x7eba570*/ void SetRandomWriteTarget(int index, UnityEngine.GraphicsBuffer buffer, bool preserveCounterValue);
            /*0x7eba5b8*/ void SetRandomWriteTarget(int index, UnityEngine.GraphicsBuffer buffer);
            /*0x7eba5f4*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7eba5f8*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.ComputeBuffer dst, uint dstOffsetBytes);
            /*0x7eba5fc*/ void CopyCounterValue(UnityEngine.ComputeBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7eba600*/ void CopyCounterValue(UnityEngine.GraphicsBuffer src, UnityEngine.GraphicsBuffer dst, uint dstOffsetBytes);
            /*0x7eba604*/ void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier src, UnityEngine.Rendering.RenderTargetIdentifier dst);
            /*0x7eba658*/ void CopyTexture(UnityEngine.Rendering.RenderTargetIdentifier src, int srcElement, int srcMip, UnityEngine.Rendering.RenderTargetIdentifier dst, int dstElement, int dstMip);
            /*0x7eba6a4*/ void Blit(UnityEngine.Texture source, UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x7eba704*/ void Blit(UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest);
            /*0x7eba764*/ void Blit(UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, UnityEngine.Material mat, int pass);
            /*0x7eba7d4*/ void SetGlobalFloat(string name, float value);
            /*0x7eba808*/ void SetGlobalInt(string name, int value);
            /*0x7eba83c*/ void SetGlobalInteger(string name, int value);
            /*0x7eba870*/ void SetGlobalVector(string name, UnityEngine.Vector4 value);
            /*0x7eba8c4*/ void SetGlobalColor(string name, UnityEngine.Color value);
            /*0x7eba918*/ void SetGlobalMatrix(string name, UnityEngine.Matrix4x4 value);
            /*0x7eba968*/ void SetGlobalFloatArray(string propertyName, System.Collections.Generic.List<float> values);
            /*0x7eba99c*/ void SetGlobalFloatArray(int nameID, System.Collections.Generic.List<float> values);
            /*0x7ebaa78*/ void SetGlobalFloatArray(string propertyName, float[] values);
            /*0x7ebaaac*/ void SetGlobalVectorArray(string propertyName, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7ebaae0*/ void SetGlobalVectorArray(int nameID, System.Collections.Generic.List<UnityEngine.Vector4> values);
            /*0x7ebabbc*/ void SetGlobalVectorArray(string propertyName, UnityEngine.Vector4[] values);
            /*0x7ebabf0*/ void SetGlobalMatrixArray(string propertyName, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7ebac24*/ void SetGlobalMatrixArray(int nameID, System.Collections.Generic.List<UnityEngine.Matrix4x4> values);
            /*0x7ebad00*/ void SetGlobalMatrixArray(string propertyName, UnityEngine.Matrix4x4[] values);
            /*0x7ebad34*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderTargetIdentifier value);
            /*0x7ebad8c*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderTargetIdentifier value);
            /*0x7ebad94*/ void SetGlobalTexture(string name, UnityEngine.Rendering.RenderTargetIdentifier value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7ebad88*/ void SetGlobalTexture(int nameID, UnityEngine.Rendering.RenderTargetIdentifier value, UnityEngine.Rendering.RenderTextureSubElement element);
            /*0x7ebadec*/ void SetGlobalBuffer(string name, UnityEngine.ComputeBuffer value);
            /*0x7ebae20*/ void SetGlobalBuffer(int nameID, UnityEngine.ComputeBuffer value);
            /*0x7ebae24*/ void SetGlobalBuffer(string name, UnityEngine.GraphicsBuffer value);
            /*0x7ebae58*/ void SetGlobalBuffer(int nameID, UnityEngine.GraphicsBuffer value);
            /*0x7ebae5c*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, int nameID, int offset, int size);
            /*0x7ebae60*/ void SetGlobalConstantBuffer(UnityEngine.ComputeBuffer buffer, string name, int offset, int size);
            /*0x7ebaeac*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, int nameID, int offset, int size);
            /*0x7ebaeb0*/ void SetGlobalConstantBuffer(UnityEngine.GraphicsBuffer buffer, string name, int offset, int size);
            /*0x7ebaefc*/ void SetShadowSamplingMode(UnityEngine.Rendering.RenderTargetIdentifier shadowmap, UnityEngine.Rendering.ShadowSamplingMode mode);
            /*0x7ebaf34*/ void SetSinglePassStereo(UnityEngine.Rendering.SinglePassStereoMode mode);
            /*0x7ebaf38*/ void IssuePluginEvent(nint callback, int eventID);
            /*0x7ebaf8c*/ void IssuePluginEventAndData(nint callback, int eventID, nint data);
            /*0x7ebb020*/ void IssuePluginCustomBlit(nint callback, uint command, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier dest, uint commandParam, uint commandFlags);
            /*0x7ebb088*/ void IssuePluginCustomTextureUpdateV2(nint callback, UnityEngine.Texture targetTexture, uint userData);

            class BindingsMarshaller
            {
                static /*0x7ebb0d4*/ nint ConvertToNative(UnityEngine.Rendering.CommandBuffer commandBuffer);
            }
        }

        class CommandBufferExtensions
        {
            static /*0x7ebb0ec*/ void Internal_SwitchIntoFastMemory(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.FastMemoryFlags fastMemoryFlags, float residency, bool copyContents);
            static /*0x7ebb224*/ void Internal_SwitchOutOfFastMemory(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.RenderTargetIdentifier rt, bool copyContents);
            static /*0x7ebb32c*/ void SwitchIntoFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rid, UnityEngine.Rendering.FastMemoryFlags fastMemoryFlags, float residency, bool copyContents);
            static /*0x7ebb334*/ void SwitchOutOfFastMemory(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier rid, bool copyContents);
            static /*0x7ebb1b8*/ void Internal_SwitchIntoFastMemory_Injected(nint cmd, ref UnityEngine.Rendering.RenderTargetIdentifier rt, UnityEngine.Rendering.FastMemoryFlags fastMemoryFlags, float residency, bool copyContents);
            static /*0x7ebb2d8*/ void Internal_SwitchOutOfFastMemory_Injected(nint cmd, ref UnityEngine.Rendering.RenderTargetIdentifier rt, bool copyContents);
        }

        class SupportedOnRenderPipelineAttribute : System.Attribute
        {
            static /*0x0*/ System.Lazy<System.Type[]> k_DefaultRenderPipelineAsset;
            /*0x10*/ System.Type[] <renderPipelineTypes>k__BackingField;

            static /*0x7ebb928*/ SupportedOnRenderPipelineAttribute();
            static /*0x7ebb754*/ UnityEngine.Rendering.SupportedOnRenderPipelineAttribute.SupportedMode GetSupportedMode(System.Type[] renderPipelineTypes, System.Type renderPipelineAssetType);
            static /*0x7ebb8b4*/ bool IsTypeSupportedOnRenderPipeline(System.Type type, System.Type renderPipelineAssetType);
            /*0x7ebb344*/ SupportedOnRenderPipelineAttribute(System.Type renderPipeline);
            /*0x7ebb3f0*/ SupportedOnRenderPipelineAttribute(System.Type[] renderPipeline);
            /*0x7ebb33c*/ System.Type[] get_renderPipelineTypes();
            /*0x7ebb6ec*/ UnityEngine.Rendering.SupportedOnRenderPipelineAttribute.SupportedMode GetSupportedMode(System.Type renderPipelineAssetType);

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

                static /*0x7ebba40*/ <>c();
                /*0x7ebbaa8*/ <>c();
                /*0x7ebbab0*/ string <.ctor>b__6_0(System.Type t);
                /*0x7ebbad4*/ System.Type[] <.cctor>b__12_0();
            }
        }

        class Watermark
        {
            static /*0x7ebbbb0*/ bool IsVisible();
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

            static /*0x7ebc144*/ bool op_Equality(UnityEngine.Rendering.SphericalHarmonicsL2 lhs, UnityEngine.Rendering.SphericalHarmonicsL2 rhs);
            static /*0x7ebc300*/ bool op_Inequality(UnityEngine.Rendering.SphericalHarmonicsL2 lhs, UnityEngine.Rendering.SphericalHarmonicsL2 rhs);
            /*0x7ebbbd8*/ float get_Item(int rgb, int coefficient);
            /*0x7ebbd24*/ void set_Item(int rgb, int coefficient, float value);
            /*0x7ebbe70*/ int GetHashCode();
            /*0x7ebc044*/ bool Equals(object other);
            /*0x7ebc0fc*/ bool Equals(UnityEngine.Rendering.SphericalHarmonicsL2 other);
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

            static /*0x7ebc788*/ bool op_Inequality(UnityEngine.Rendering.AttachmentDescriptor left, UnityEngine.Rendering.AttachmentDescriptor right);
            /*0x7ebc450*/ AttachmentDescriptor(UnityEngine.Experimental.Rendering.GraphicsFormat format);
            /*0x7ebc34c*/ void set_loadAction(UnityEngine.Rendering.RenderBufferLoadAction value);
            /*0x7ebc354*/ void set_storeAction(UnityEngine.Rendering.RenderBufferStoreAction value);
            /*0x7ebc35c*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
            /*0x7ebc364*/ UnityEngine.Rendering.RenderTargetIdentifier get_loadStoreTarget();
            /*0x7ebc378*/ void set_loadStoreTarget(UnityEngine.Rendering.RenderTargetIdentifier value);
            /*0x7ebc38c*/ void set_resolveTarget(UnityEngine.Rendering.RenderTargetIdentifier value);
            /*0x7ebc3a4*/ void set_clearColor(UnityEngine.Color value);
            /*0x7ebc3b0*/ void set_clearDepth(float value);
            /*0x7ebc3b8*/ void set_clearStencil(uint value);
            /*0x7ebc3c0*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier target, bool loadExistingContents, bool storeResults);
            /*0x7ebc404*/ void ConfigureResolveTarget(UnityEngine.Rendering.RenderTargetIdentifier target);
            /*0x7ebc434*/ void ConfigureClear(UnityEngine.Color clearColor, float clearDepth, uint clearStencil);
            /*0x7ebc4a0*/ bool Equals(UnityEngine.Rendering.AttachmentDescriptor other);
            /*0x7ebc600*/ bool Equals(object obj);
            /*0x7ebc690*/ int GetHashCode();
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

            static /*0x7ebc9dc*/ AttachmentIndexArray();
            /*0x7ebc7c0*/ AttachmentIndexArray(int numAttachments);
            /*0x7ebc85c*/ int get_Item(int index);
            /*0x7ebc918*/ void set_Item(int index, int value);
            /*0x7ebc9d4*/ int get_Length();
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

            static /*0x7ebca2c*/ UnityEngine.Rendering.BlendState get_defaultValue();
            /*0x7ebca90*/ BlendState(bool separateMRTBlend, bool alphaToMask);
            /*0x7ebcb74*/ void set_blendState0(UnityEngine.Rendering.RenderTargetBlendState value);
            /*0x7ebcb7c*/ bool Equals(UnityEngine.Rendering.BlendState other);
            /*0x7ebcc5c*/ bool Equals(object obj);
            /*0x7ebccec*/ int GetHashCode();
        }

        struct CoreCameraValues : System.IEquatable<UnityEngine.Rendering.CoreCameraValues>
        {
            /*0x10*/ int filterMode;
            /*0x14*/ uint cullingMask;
            /*0x18*/ int instanceID;

            /*0x7ebcdc8*/ bool Equals(UnityEngine.Rendering.CoreCameraValues other);
            /*0x7ebcdfc*/ bool Equals(object obj);
            /*0x7ebce94*/ int GetHashCode();
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

            /*0x7ebceb4*/ UnityEngine.Plane GetShadowCullingPlane(int index);
            /*0x7ebcf90*/ UnityEngine.Plane GetCameraCullingPlane(int index);
            /*0x7ebd06c*/ bool Equals(UnityEngine.Rendering.CameraProperties other);
            /*0x7ebd6d4*/ bool Equals(object obj);
            /*0x7ebd78c*/ int GetHashCode();

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

            static /*0x7ebe590*/ ScriptableCullingParameters();
            /*0x7ebdbe4*/ void set_maximumVisibleLights(int value);
            /*0x7ebdbec*/ void set_conservativeEnclosingSphere(bool value);
            /*0x7ebdbf8*/ void set_numIterationsEnclosingSphere(int value);
            /*0x7ebdc00*/ int get_cullingPlaneCount();
            /*0x7ebdc08*/ void set_shadowDistance(float value);
            /*0x7ebdc10*/ UnityEngine.Rendering.CullingOptions get_cullingOptions();
            /*0x7ebdc18*/ void set_cullingOptions(UnityEngine.Rendering.CullingOptions value);
            /*0x7ebdc20*/ void set_reflectionProbeSortingCriteria(UnityEngine.Rendering.ReflectionProbeSortingCriteria value);
            /*0x7ebdc28*/ void set_stereoViewMatrix(UnityEngine.Matrix4x4 value);
            /*0x7ebdc40*/ UnityEngine.Matrix4x4 get_stereoProjectionMatrix();
            /*0x7ebdc58*/ void set_stereoProjectionMatrix(UnityEngine.Matrix4x4 value);
            /*0x7ebdc70*/ void set_stereoSeparationDistance(float value);
            /*0x7ebdc78*/ float GetLayerCullingDistance(int layerIndex);
            /*0x7ebdd48*/ UnityEngine.Plane GetCullingPlane(int index);
            /*0x7ebde74*/ bool Equals(UnityEngine.Rendering.ScriptableCullingParameters other);
            /*0x7ebe258*/ bool Equals(object obj);
            /*0x7ebe340*/ int GetHashCode();

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

            static /*0x7ebe5e0*/ int GetLightIndexCount(nint cullingResultsPtr);
            static /*0x7ebe61c*/ int GetReflectionProbeIndexCount(nint cullingResultsPtr);
            static /*0x7ebe658*/ void FillLightAndReflectionProbeIndices(nint cullingResultsPtr, UnityEngine.ComputeBuffer computeBuffer);
            static /*0x7ebe6ec*/ int GetLightIndexMapSize(nint cullingResultsPtr);
            static /*0x7ebe728*/ void FillLightIndexMap(nint cullingResultsPtr, nint indexMapPtr, int indexMapSize);
            static /*0x7ebe77c*/ void SetLightIndexMap(nint cullingResultsPtr, nint indexMapPtr, int indexMapSize);
            static /*0x7ebe7d0*/ bool GetShadowCasterBounds(nint cullingResultsPtr, int lightIndex, ref UnityEngine.Bounds bounds);
            static /*0x7ebe824*/ bool ComputeSpotShadowMatricesAndCullingPrimitives(nint cullingResultsPtr, int activeLightIndex, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            static /*0x7ebe890*/ bool ComputePointShadowMatricesAndCullingPrimitives(nint cullingResultsPtr, int activeLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            static /*0x7ebe914*/ bool ComputeDirectionalShadowMatricesAndCullingPrimitives(nint cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, UnityEngine.Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            static /*0x7ebefe8*/ bool op_Equality(UnityEngine.Rendering.CullingResults left, UnityEngine.Rendering.CullingResults right);
            static /*0x7ebe6a8*/ void FillLightAndReflectionProbeIndices_Injected(nint cullingResultsPtr, nint computeBuffer);
            static /*0x7ebe9cc*/ bool ComputeDirectionalShadowMatricesAndCullingPrimitives_Injected(nint cullingResultsPtr, int activeLightIndex, int splitIndex, int splitCount, ref UnityEngine.Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x7ebea78*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> get_visibleLights();
            /*0x7ebead4*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleReflectionProbe> get_visibleReflectionProbes();
            /*0x3910ae8*/ Unity.Collections.NativeArray<T> GetNativeArray<T>(void* dataPointer, int length);
            /*0x7ebeb30*/ int get_lightAndReflectionProbeIndexCount();
            /*0x7ebeba8*/ void FillLightAndReflectionProbeIndices(UnityEngine.ComputeBuffer computeBuffer);
            /*0x7ebebf8*/ Unity.Collections.NativeArray<int> GetLightIndexMap(Unity.Collections.Allocator allocator);
            /*0x7ebed04*/ void SetLightIndexMap(Unity.Collections.NativeArray<int> lightIndexMap);
            /*0x7ebeda0*/ bool GetShadowCasterBounds(int lightIndex, ref UnityEngine.Bounds outBounds);
            /*0x7ebedf4*/ bool ComputeSpotShadowMatricesAndCullingPrimitives(int activeLightIndex, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x7ebee60*/ bool ComputePointShadowMatricesAndCullingPrimitives(int activeLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x7ebeee4*/ bool ComputeDirectionalShadowMatricesAndCullingPrimitives(int activeLightIndex, int splitIndex, int splitCount, UnityEngine.Vector3 splitRatio, int shadowResolution, float shadowNearPlaneOffset, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData shadowSplitData);
            /*0x7ebeeec*/ bool Equals(UnityEngine.Rendering.CullingResults other);
            /*0x7ebef48*/ bool Equals(object obj);
            /*0x7ebefc0*/ int GetHashCode();
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

            static /*0x7ebf014*/ UnityEngine.Rendering.DepthState get_defaultValue();
            /*0x7ebf038*/ DepthState(bool writeEnabled, UnityEngine.Rendering.CompareFunction compareFunction);
            /*0x7ebf0ac*/ UnityEngine.Rendering.CompareFunction get_compareFunction();
            /*0x7ebf0b4*/ bool Equals(UnityEngine.Rendering.DepthState other);
            /*0x7ebf0dc*/ bool Equals(object obj);
            /*0x7ebf164*/ int GetHashCode();
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

            static /*0x7ebfa68*/ DrawingSettings();
            static /*0x7ebf9ac*/ bool op_Equality(UnityEngine.Rendering.DrawingSettings left, UnityEngine.Rendering.DrawingSettings right);
            /*0x7ebf1a0*/ DrawingSettings(UnityEngine.Rendering.ShaderTagId shaderPassName, UnityEngine.Rendering.SortingSettings sortingSettings);
            /*0x7ebf264*/ void set_perObjectData(UnityEngine.Rendering.PerObjectData value);
            /*0x7ebf26c*/ void set_enableDynamicBatching(bool value);
            /*0x7ebf27c*/ void set_enableInstancing(bool value);
            /*0x7ebf29c*/ void set_overrideMaterial(UnityEngine.Material value);
            /*0x7ebf2c8*/ void set_overrideShader(UnityEngine.Shader value);
            /*0x7ebf2f4*/ void set_overrideMaterialPassIndex(int value);
            /*0x7ebf2fc*/ void set_overrideShaderPassIndex(int value);
            /*0x7ebf304*/ void set_mainLightIndex(int value);
            /*0x7ebf30c*/ UnityEngine.Rendering.ShaderTagId GetShaderPassName(int index);
            /*0x7ebf450*/ void SetShaderPassName(int index, UnityEngine.Rendering.ShaderTagId shaderPassName);
            /*0x7ebf598*/ bool Equals(UnityEngine.Rendering.DrawingSettings other);
            /*0x7ebf7b0*/ bool Equals(object obj);
            /*0x7ebf898*/ int GetHashCode();

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

            static /*0x7ebfdf4*/ bool op_Equality(UnityEngine.Rendering.FilteringSettings left, UnityEngine.Rendering.FilteringSettings right);
            /*0x7ebfab4*/ FilteringSettings(System.Nullable<UnityEngine.Rendering.RenderQueueRange> renderQueueRange, int layerMask, uint renderingLayerMask, int excludeMotionVectorObjects);
            /*0x7ebfba0*/ UnityEngine.Rendering.RenderQueueRange get_renderQueueRange();
            /*0x7ebfba8*/ void set_batchLayerMask(uint value);
            /*0x7ebfbb0*/ void set_excludeMotionVectorObjects(bool value);
            /*0x7ebfbbc*/ void set_forceAllMotionVectorObjects(bool value);
            /*0x7ebfbc8*/ bool Equals(UnityEngine.Rendering.FilteringSettings other);
            /*0x7ebfcc4*/ bool Equals(object obj);
            /*0x7ebfd4c*/ int GetHashCode();
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

            /*0x7ebfe1c*/ bool get_isOrthographic();
            /*0x7ebfe78*/ UnityEngine.Vector3 get_cameraPosition();
            /*0x7ebfe84*/ float get_fieldOfView();
            /*0x7ebfe8c*/ float get_orthoSize();
            /*0x7ebfe94*/ bool Equals(UnityEngine.Rendering.LODParameters other);
            /*0x7ebff30*/ bool Equals(object obj);
            /*0x7ebffc0*/ int GetHashCode();
        }

        class ObjectIdRequest
        {
            /*0x10*/ UnityEngine.RenderTexture <destination>k__BackingField;

            /*0x7ec0054*/ UnityEngine.RenderTexture get_destination();
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

            static /*0x7ec027c*/ RasterState();
            /*0x7ec005c*/ RasterState(UnityEngine.Rendering.CullMode cullingMode, int offsetUnits, float offsetFactor, bool depthClip);
            /*0x7ec0100*/ bool Equals(UnityEngine.Rendering.RasterState other);
            /*0x7ec0174*/ bool Equals(object obj);
            /*0x7ec021c*/ int GetHashCode();
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

            static /*0x7ec02ec*/ void BeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x7ec0444*/ void BeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            static /*0x7ec0538*/ void EndContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x7ec0690*/ void EndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            /*0x7ec0914*/ RenderPipeline();
            void Render(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera[] cameras);
            /*0x3910ae8*/ void ProcessRenderRequests<RequestData>(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, RequestData renderRequest);
            /*0x3910ae8*/ bool IsRenderRequestSupported<RequestData>(UnityEngine.Camera camera, RequestData data);
            /*0x7ec0784*/ void Render(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x7ec07fc*/ void InternalRender(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x3910ae8*/ void InternalProcessRenderRequests<RequestData>(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, RequestData renderRequest);
            /*0x7ec087c*/ bool get_disposed();
            /*0x7ec0884*/ void set_disposed(bool value);
            /*0x7ec0890*/ void Dispose();
            /*0x7ec0908*/ void Dispose(bool disposing);
            /*0x7ec090c*/ UnityEngine.Rendering.RenderPipelineGlobalSettings get_defaultSettings();

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
            /*0x7ec0f5c*/ RenderPipelineAsset();
            /*0x7ec091c*/ UnityEngine.Rendering.RenderPipeline InternalCreatePipeline();
            /*0x7ec09f8*/ UnityEngine.Material get_defaultMaterial();
            /*0x7ec0a00*/ UnityEngine.Shader get_autodeskInteractiveShader();
            /*0x7ec0a08*/ UnityEngine.Shader get_autodeskInteractiveTransparentShader();
            /*0x7ec0a10*/ UnityEngine.Shader get_autodeskInteractiveMaskedShader();
            /*0x7ec0a18*/ UnityEngine.Shader get_terrainDetailLitShader();
            /*0x7ec0a20*/ UnityEngine.Shader get_terrainDetailGrassShader();
            /*0x7ec0a28*/ UnityEngine.Shader get_terrainDetailGrassBillboardShader();
            /*0x7ec0a30*/ UnityEngine.Material get_defaultParticleMaterial();
            /*0x7ec0a38*/ UnityEngine.Material get_defaultLineMaterial();
            /*0x7ec0a40*/ UnityEngine.Material get_defaultTerrainMaterial();
            /*0x7ec0a48*/ UnityEngine.Material get_defaultUIMaterial();
            /*0x7ec0a50*/ UnityEngine.Material get_defaultUIOverdrawMaterial();
            /*0x7ec0a58*/ UnityEngine.Material get_defaultUIETC1SupportedMaterial();
            /*0x7ec0a60*/ UnityEngine.Material get_default2DMaterial();
            /*0x7ec0a68*/ UnityEngine.Material get_default2DMaskMaterial();
            /*0x7ec0a70*/ UnityEngine.Shader get_defaultShader();
            /*0x7ec0a78*/ UnityEngine.Shader get_defaultSpeedTree7Shader();
            /*0x7ec0a80*/ UnityEngine.Shader get_defaultSpeedTree8Shader();
            /*0x7ec0a88*/ UnityEngine.Shader get_defaultSpeedTree9Shader();
            /*0x7ec0a90*/ string get_renderPipelineShaderTag();
            /*0x38148bc*/ UnityEngine.Rendering.RenderPipeline CreatePipeline();
            /*0x7ec0b10*/ System.Type get_pipelineType();
            /*0x7ec0b80*/ string get_pipelineTypeFullName();
            /*0x7ec0bc8*/ void EnsureGlobalSettings();
            /*0x7ec0bcc*/ void OnValidate();
            /*0x7ec0cd8*/ void OnDisable();
            /*0x7ec0edc*/ System.Type get_renderPipelineType();
            /*0x7ec0f4c*/ string[] get_renderingLayerMaskNames();
            /*0x7ec0f54*/ string[] get_prefixedRenderingLayerMaskNames();
        }

        class RenderPipelineAsset<TRenderPipeline> : UnityEngine.Rendering.RenderPipelineAsset
        {
            /*0x38159dc*/ RenderPipelineAsset();
            /*0x38148bc*/ System.Type get_pipelineType();
            /*0x38148bc*/ string get_renderPipelineShaderTag();
            /*0x38148bc*/ System.Type get_renderPipelineType();
        }

        class RenderPipelineGlobalSettings : UnityEngine.ScriptableObject, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x18*/ System.Collections.Generic.Dictionary<System.Type, int> <settingsMap>k__BackingField;

            /*0x7ec1450*/ RenderPipelineGlobalSettings();
            /*0x7ec0f64*/ System.Collections.Generic.List<UnityEngine.Rendering.IRenderPipelineGraphicsSettings> get_settingsList();
            /*0x7ec11b0*/ System.Collections.Generic.Dictionary<System.Type, int> get_settingsMap();
            /*0x7ec11b8*/ void RecreateSettingsMap();
            /*0x7ec12e0*/ bool TryGet(System.Type type, ref UnityEngine.Rendering.IRenderPipelineGraphicsSettings settings);
            /*0x38141c4*/ bool TryGetFirstSettingsImplementingInterface<TSettingsInterfaceType>(ref TSettingsInterfaceType settings);
            /*0x38141c4*/ bool GetSettingsImplementingInterface<TSettingsInterfaceType>(ref System.Collections.Generic.List<TSettingsInterfaceType> settings);
            /*0x7ec13d0*/ bool Contains(System.Type type);
            /*0x7ec1448*/ void OnBeforeSerialize();
            /*0x7ec144c*/ void OnAfterDeserialize();
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

            static /*0x7ec276c*/ RenderPipelineManager();
            static /*0x7ec14d8*/ UnityEngine.Rendering.RenderPipeline get_currentPipeline();
            static /*0x7ec1530*/ void set_currentPipeline(UnityEngine.Rendering.RenderPipeline value);
            static /*0x7ec15e8*/ void add_beginContextRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> value);
            static /*0x7ec16dc*/ void remove_beginContextRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> value);
            static /*0x7ec17d0*/ void add_endContextRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> value);
            static /*0x7ec18c4*/ void remove_endContextRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, System.Collections.Generic.List<UnityEngine.Camera>> value);
            static /*0x7ec19b8*/ void add_beginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x7ec1aac*/ void remove_beginCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x7ec1ba0*/ void add_endCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x7ec1c94*/ void remove_endCameraRendering(System.Action<UnityEngine.Rendering.ScriptableRenderContext, UnityEngine.Camera> value);
            static /*0x7ec0350*/ void BeginContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x7ec04a8*/ void BeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            static /*0x7ec059c*/ void EndContextRendering(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            static /*0x7ec06f4*/ void EndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
            static /*0x7ec1d88*/ void OnActiveRenderPipelineTypeChanged();
            static /*0x7ec1dfc*/ void OnActiveRenderPipelineAssetChanged(UnityEngine.ScriptableObject from, UnityEngine.ScriptableObject to);
            static /*0x7ec1f08*/ void HandleRenderPipelineChange(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset);
            static /*0x7ec0c20*/ void RecreateCurrentPipeline(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset);
            static /*0x7ec0d24*/ void CleanupRenderPipeline();
            static /*0x7ec20ac*/ string GetCurrentPipelineAssetType();
            static /*0x7ec2104*/ void DoRenderLoop_Internal(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset, nint loopPtr, UnityEngine.Object renderRequest);
            static /*0x7ec2414*/ bool TryPrepareRenderPipeline(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset);
            static /*0x7ec1fa4*/ bool get_isCurrentPipelineValid();
            static /*0x7ec2620*/ bool IsPipelineRequireCreation();
        }

        struct RenderQueueRange : System.IEquatable<UnityEngine.Rendering.RenderQueueRange>
        {
            static int k_MinimumBound = 0;
            static int k_MaximumBound = 5000;
            static /*0x0*/ int minimumBound;
            static /*0x4*/ int maximumBound;
            /*0x10*/ int m_LowerBound;
            /*0x14*/ int m_UpperBound;

            static /*0x7ec2938*/ RenderQueueRange();
            static /*0x7ebfb90*/ UnityEngine.Rendering.RenderQueueRange get_all();
            static /*0x7ec27e4*/ UnityEngine.Rendering.RenderQueueRange get_opaque();
            static /*0x7ec27ec*/ UnityEngine.Rendering.RenderQueueRange get_transparent();
            static /*0x7ec28c0*/ bool op_Equality(UnityEngine.Rendering.RenderQueueRange left, UnityEngine.Rendering.RenderQueueRange right);
            /*0x7ec27f8*/ int get_lowerBound();
            /*0x7ec2800*/ int get_upperBound();
            /*0x7ebfc9c*/ bool Equals(UnityEngine.Rendering.RenderQueueRange other);
            /*0x7ec2808*/ bool Equals(object obj);
            /*0x7ebfde0*/ int GetHashCode();
        }

        struct RenderStateBlock : System.IEquatable<UnityEngine.Rendering.RenderStateBlock>
        {
            /*0x10*/ UnityEngine.Rendering.BlendState m_BlendState;
            /*0x54*/ UnityEngine.Rendering.RasterState m_RasterState;
            /*0x64*/ UnityEngine.Rendering.DepthState m_DepthState;
            /*0x66*/ UnityEngine.Rendering.StencilState m_StencilState;
            /*0x74*/ int m_StencilReference;
            /*0x78*/ UnityEngine.Rendering.RenderStateMask m_Mask;

            /*0x7ec2988*/ RenderStateBlock(UnityEngine.Rendering.RenderStateMask mask);
            /*0x7ec2ab0*/ void set_blendState(UnityEngine.Rendering.BlendState value);
            /*0x7ec2ac4*/ void set_rasterState(UnityEngine.Rendering.RasterState value);
            /*0x7ec2ad0*/ UnityEngine.Rendering.DepthState get_depthState();
            /*0x7ec2ad8*/ void set_depthState(UnityEngine.Rendering.DepthState value);
            /*0x7ec2ae0*/ UnityEngine.Rendering.StencilState get_stencilState();
            /*0x7ec2af0*/ void set_stencilState(UnityEngine.Rendering.StencilState value);
            /*0x7ec2afc*/ int get_stencilReference();
            /*0x7ec2b04*/ void set_stencilReference(int value);
            /*0x7ec2b0c*/ UnityEngine.Rendering.RenderStateMask get_mask();
            /*0x7ec2b14*/ void set_mask(UnityEngine.Rendering.RenderStateMask value);
            /*0x7ec2b1c*/ bool Equals(UnityEngine.Rendering.RenderStateBlock other);
            /*0x7ec2cd0*/ bool Equals(object obj);
            /*0x7ec2d60*/ int GetHashCode();
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

            static /*0x7ec2f20*/ UnityEngine.Rendering.RenderTargetBlendState get_defaultValue();
            /*0x7ec2f2c*/ RenderTargetBlendState(UnityEngine.Rendering.ColorWriteMask writeMask, UnityEngine.Rendering.BlendMode sourceColorBlendMode, UnityEngine.Rendering.BlendMode destinationColorBlendMode, UnityEngine.Rendering.BlendMode sourceAlphaBlendMode, UnityEngine.Rendering.BlendMode destinationAlphaBlendMode, UnityEngine.Rendering.BlendOp colorBlendOperation, UnityEngine.Rendering.BlendOp alphaBlendOperation);
            /*0x7ec2f50*/ bool Equals(UnityEngine.Rendering.RenderTargetBlendState other);
            /*0x7ec2fc4*/ bool Equals(object obj);
            /*0x7ec303c*/ int GetHashCode();
        }

        struct RendererList
        {
            static /*0x0*/ UnityEngine.Rendering.RendererList nullRendererList;
            /*0x10*/ nuint context;
            /*0x18*/ uint index;
            /*0x1c*/ uint frame;
            /*0x20*/ uint type;
            /*0x24*/ uint contextID;

            static /*0x7ec3128*/ RendererList();
            /*0x7ec3118*/ RendererList(nuint ctx, uint indx);
            /*0x7ec30dc*/ bool get_isValid();
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

            static /*0x7ec3c6c*/ RendererListParams();
            /*0x7ec317c*/ RendererListParams(UnityEngine.Rendering.CullingResults cullingResults, UnityEngine.Rendering.DrawingSettings drawSettings, UnityEngine.Rendering.FilteringSettings filteringSettings);
            /*0x7ec321c*/ int get_numStateBlocks();
            /*0x7ec3288*/ nint get_stateBlocksPtr();
            /*0x7ec3318*/ nint get_tagsValuePtr();
            /*0x7ec33a8*/ void Validate();
            /*0x7ec37f4*/ bool Equals(UnityEngine.Rendering.RendererListParams other);
            /*0x7ec3a40*/ bool Equals(object obj);
            /*0x7ec3b28*/ int GetHashCode();
        }

        struct ScriptableRenderContext : System.IEquatable<UnityEngine.Rendering.ScriptableRenderContext>
        {
            static /*0x0*/ UnityEngine.Rendering.ShaderTagId kRenderTypeTag;
            /*0x10*/ nint m_Ptr;

            static /*0x7ec64f4*/ ScriptableRenderContext();
            static /*0x7ec3cb8*/ void BeginRenderPass_Internal(nint self, int width, int height, int volumeDepth, int samples, nint colors, int colorCount, int depthAttachmentIndex);
            static /*0x7ec3d44*/ void BeginSubPass_Internal(nint self, nint colors, int colorCount, nint inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly);
            static /*0x7ec3dc8*/ void EndSubPass_Internal(nint self);
            static /*0x7ec3e04*/ void EndRenderPass_Internal(nint self);
            static /*0x7ec3e40*/ bool HasInvokeOnRenderObjectCallbacks_Internal();
            static /*0x7ec3e68*/ void Internal_Cull(ref UnityEngine.Rendering.ScriptableCullingParameters parameters, UnityEngine.Rendering.ScriptableRenderContext renderLoop, nint results);
            static /*0x7ec3f4c*/ void Internal_CullShadowCasters(UnityEngine.Rendering.ScriptableRenderContext renderLoop, nint context);
            static /*0x7ec4018*/ void InitializeSortSettings(UnityEngine.Camera camera, ref UnityEngine.Rendering.SortingSettings sortingSettings);
            static /*0x7ec41d8*/ void EmitGeometryForCamera(UnityEngine.Camera camera);
            static /*0x7ec3ef8*/ void Internal_Cull_Injected(ref UnityEngine.Rendering.ScriptableCullingParameters parameters, ref UnityEngine.Rendering.ScriptableRenderContext renderLoop, nint results);
            static /*0x7ec3fd4*/ void Internal_CullShadowCasters_Injected(ref UnityEngine.Rendering.ScriptableRenderContext renderLoop, nint context);
            static /*0x7ec40c8*/ void InitializeSortSettings_Injected(nint camera, ref UnityEngine.Rendering.SortingSettings sortingSettings);
            static /*0x7ec4278*/ void EmitGeometryForCamera_Injected(nint camera);
            static /*0x7ec4338*/ void ExecuteCommandBuffer_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint commandBuffer);
            static /*0x7ec4410*/ void ExecuteCommandBufferAsync_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType);
            static /*0x7ec4558*/ void SetupCameraProperties_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera, bool stereoSetup, int eye);
            static /*0x7ec4690*/ void DrawWireOverlay_Impl_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera);
            static /*0x7ec47dc*/ void CreateRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.ShaderTagId tagName, bool isPassTagName, nint tagValues, nint stateBlocks, int stateCount, ref UnityEngine.Rendering.RendererList ret);
            static /*0x7ec4930*/ void CreateShadowRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint shadowDrawinSettings, ref UnityEngine.Rendering.RendererList ret);
            static /*0x7ec4ac8*/ void CreateSkyboxRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera, int mode, ref UnityEngine.Matrix4x4 proj, ref UnityEngine.Matrix4x4 view, ref UnityEngine.Matrix4x4 projR, ref UnityEngine.Matrix4x4 viewR, ref UnityEngine.Rendering.RendererList ret);
            static /*0x7ec4c68*/ void CreateGizmoRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera, UnityEngine.Rendering.GizmoSubset gizmoSubset, ref UnityEngine.Rendering.RendererList ret);
            static /*0x7ec4dd8*/ void CreateUIOverlayRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera, UnityEngine.Rendering.UISubset uiSubset, ref UnityEngine.Rendering.RendererList ret);
            static /*0x7ec4f3c*/ void CreateWireOverlayRendererList_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, nint camera, ref UnityEngine.Rendering.RendererList ret);
            static /*0x7ec5058*/ UnityEngine.Rendering.RendererListStatus QueryRendererListStatus_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, ref UnityEngine.Rendering.RendererList handle);
            /*0x7ec254c*/ ScriptableRenderContext(nint ptr);
            /*0x7ec410c*/ void Submit_Internal();
            /*0x7ec4148*/ bool SubmitForRenderPassValidation_Internal();
            /*0x7ec4184*/ void GetCameras_Internal(System.Type listType, object resultList);
            /*0x7ec42b4*/ void ExecuteCommandBuffer_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer);
            /*0x7ec437c*/ void ExecuteCommandBufferAsync_Internal(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType);
            /*0x7ec4464*/ void SetupCameraProperties_Internal(UnityEngine.Camera camera, bool stereoSetup, int eye);
            /*0x7ec45b4*/ void DrawWireOverlay_Impl(UnityEngine.Camera camera);
            /*0x7ec46d4*/ nint Internal_GetPtr();
            /*0x7ec46dc*/ UnityEngine.Rendering.RendererList CreateRendererList_Internal(nint cullResults, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, UnityEngine.Rendering.ShaderTagId tagName, bool isPassTagName, nint tagValues, nint stateBlocks, int stateCount);
            /*0x7ec4880*/ UnityEngine.Rendering.RendererList CreateShadowRendererList_Internal(nint shadowDrawinSettings);
            /*0x7ec4984*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList_Internal(UnityEngine.Camera camera, int mode, UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view, UnityEngine.Matrix4x4 projR, UnityEngine.Matrix4x4 viewR);
            /*0x7ec4b54*/ UnityEngine.Rendering.RendererList CreateGizmoRendererList_Internal(UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset);
            /*0x7ec4cc4*/ UnityEngine.Rendering.RendererList CreateUIOverlayRendererList_Internal(UnityEngine.Camera camera, UnityEngine.Rendering.UISubset uiSubset);
            /*0x7ec4e34*/ UnityEngine.Rendering.RendererList CreateWireOverlayRendererList_Internal(UnityEngine.Camera camera);
            /*0x7ec4f90*/ void PrepareRendererListsAsync_Internal(object rendererLists);
            /*0x7ec4fd4*/ UnityEngine.Rendering.RendererListStatus QueryRendererListStatus_Internal(UnityEngine.Rendering.RendererList handle);
            /*0x7ec509c*/ void BeginRenderPass(int width, int height, int samples, Unity.Collections.NativeArray<UnityEngine.Rendering.AttachmentDescriptor> attachments, int depthAttachmentIndex);
            /*0x7ec519c*/ void BeginSubPass(Unity.Collections.NativeArray<int> colors, Unity.Collections.NativeArray<int> inputs, bool isDepthStencilReadOnly);
            /*0x7ec52a8*/ void BeginSubPass(Unity.Collections.NativeArray<int> colors, bool isDepthStencilReadOnly);
            /*0x7ec5388*/ void EndSubPass();
            /*0x7ec5400*/ void EndRenderPass();
            /*0x7ec5478*/ void Submit();
            /*0x7ec54ec*/ bool SubmitForRenderPassValidation();
            /*0x7ec5560*/ bool HasInvokeOnRenderObjectCallbacks();
            /*0x7ec2554*/ void GetCameras(System.Collections.Generic.List<UnityEngine.Camera> results);
            /*0x7ec55c8*/ void ExecuteCommandBuffer(UnityEngine.Rendering.CommandBuffer commandBuffer);
            /*0x7ec56ac*/ void ExecuteCommandBufferAsync(UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.ComputeQueueType queueType);
            /*0x7ec57a0*/ void SetupCameraProperties(UnityEngine.Camera camera, bool stereoSetup);
            /*0x7ec5810*/ void SetupCameraProperties(UnityEngine.Camera camera, bool stereoSetup, int eye);
            /*0x7ec588c*/ void DrawWireOverlay(UnityEngine.Camera camera);
            /*0x7ec58f0*/ UnityEngine.Rendering.CullingResults Cull(ref UnityEngine.Rendering.ScriptableCullingParameters parameters);
            /*0x7ec5984*/ void CullShadowCasters(UnityEngine.Rendering.CullingResults cullingResults, UnityEngine.Rendering.ShadowCastersCullingInfos infos);
            /*0x7ec5a80*/ bool Equals(UnityEngine.Rendering.ScriptableRenderContext other);
            /*0x7ec5ac4*/ bool Equals(object obj);
            /*0x7ec5b94*/ int GetHashCode();
            /*0x7ec5b9c*/ UnityEngine.Rendering.RendererList CreateRendererList(ref UnityEngine.Rendering.RendererListParams param);
            /*0x7ec5cbc*/ UnityEngine.Rendering.RendererList CreateShadowRendererList(ref UnityEngine.Rendering.ShadowDrawingSettings settings);
            /*0x7ec5d60*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrixL, UnityEngine.Matrix4x4 viewMatrixL, UnityEngine.Matrix4x4 projectionMatrixR, UnityEngine.Matrix4x4 viewMatrixR);
            /*0x7ec5eb4*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Camera camera, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 viewMatrix);
            /*0x7ec6020*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Camera camera);
            /*0x7ec6184*/ UnityEngine.Rendering.RendererList CreateGizmoRendererList(UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset);
            /*0x7ec6220*/ UnityEngine.Rendering.RendererList CreateUIOverlayRendererList(UnityEngine.Camera camera);
            /*0x7ec62b4*/ UnityEngine.Rendering.RendererList CreateUIOverlayRendererList(UnityEngine.Camera camera, UnityEngine.Rendering.UISubset uiSubset);
            /*0x7ec6350*/ UnityEngine.Rendering.RendererList CreateWireOverlayRendererList(UnityEngine.Camera camera);
            /*0x7ec63e0*/ void PrepareRendererListsAsync(System.Collections.Generic.List<UnityEngine.Rendering.RendererList> rendererLists);
            /*0x7ec6464*/ UnityEngine.Rendering.RendererListStatus QueryRendererListStatus(UnityEngine.Rendering.RendererList rendererList);

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

            static /*0x7ec3a34*/ bool op_Equality(UnityEngine.Rendering.ShaderTagId tag1, UnityEngine.Rendering.ShaderTagId tag2);
            static /*0x7ec65f4*/ bool op_Inequality(UnityEngine.Rendering.ShaderTagId tag1, UnityEngine.Rendering.ShaderTagId tag2);
            /*0x7ec655c*/ ShaderTagId(string name);
            /*0x7ebf25c*/ int get_id();
            /*0x7ebf448*/ void set_id(int value);
            /*0x7ec657c*/ bool Equals(object obj);
            /*0x7ebf6d4*/ bool Equals(UnityEngine.Rendering.ShaderTagId other);
            /*0x7ec3c4c*/ int GetHashCode();
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

            /*0x7ec660c*/ ShadowDrawingSettings(UnityEngine.Rendering.CullingResults cullingResults, int lightIndex);
            /*0x7ec6600*/ void set_useRenderingLayerMaskTest(bool value);
            /*0x7ec6794*/ bool Equals(UnityEngine.Rendering.ShadowDrawingSettings other);
            /*0x7ec6a8c*/ bool Equals(object obj);
            /*0x7ec6b44*/ int GetHashCode();
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

            static /*0x7ec6ed4*/ ShadowSplitData();
            /*0x7ec6c90*/ int get_cullingPlaneCount();
            /*0x7ec6c98*/ UnityEngine.Vector4 get_cullingSphere();
            /*0x7ec66b0*/ void set_shadowCascadeBlendCullingFactor(float value);
            /*0x7ec6ca4*/ UnityEngine.Plane GetCullingPlane(int index);
            /*0x7ec6918*/ bool Equals(UnityEngine.Rendering.ShadowSplitData other);
            /*0x7ec6dec*/ bool Equals(object obj);
            /*0x7ec6c14*/ int GetHashCode();

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

            static /*0x7ebfb98*/ UnityEngine.Rendering.SortingLayerRange get_all();
            /*0x7ec6f20*/ bool Equals(UnityEngine.Rendering.SortingLayerRange other);
            /*0x7ec6f44*/ bool Equals(object obj);
            /*0x7ec6fc8*/ int GetHashCode();
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

            /*0x7ec6fd0*/ SortingSettings(UnityEngine.Camera camera);
            /*0x7ec7034*/ UnityEngine.Rendering.SortingCriteria get_criteria();
            /*0x7ec703c*/ void set_criteria(UnityEngine.Rendering.SortingCriteria value);
            /*0x7ebf6e4*/ bool Equals(UnityEngine.Rendering.SortingSettings other);
            /*0x7ec7044*/ bool Equals(object obj);
            /*0x7ebf8f0*/ int GetHashCode();
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

            static /*0x7ec2a54*/ UnityEngine.Rendering.StencilState get_defaultValue();
            /*0x7ec70d4*/ StencilState(bool enabled, byte readMask, byte writeMask, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.StencilOp passOperation, UnityEngine.Rendering.StencilOp failOperation, UnityEngine.Rendering.StencilOp zFailOperation);
            /*0x7ec7100*/ StencilState(bool enabled, byte readMask, byte writeMask, UnityEngine.Rendering.CompareFunction compareFunctionFront, UnityEngine.Rendering.StencilOp passOperationFront, UnityEngine.Rendering.StencilOp failOperationFront, UnityEngine.Rendering.StencilOp zFailOperationFront, UnityEngine.Rendering.CompareFunction compareFunctionBack, UnityEngine.Rendering.StencilOp passOperationBack, UnityEngine.Rendering.StencilOp failOperationBack, UnityEngine.Rendering.StencilOp zFailOperationBack);
            /*0x7ec71e4*/ bool get_enabled();
            /*0x7ec7240*/ void set_enabled(bool value);
            /*0x7ec72ac*/ byte get_readMask();
            /*0x7ec72b4*/ void set_readMask(byte value);
            /*0x7ec72bc*/ byte get_writeMask();
            /*0x7ec72c4*/ void set_writeMask(byte value);
            /*0x7ec72cc*/ void SetCompareFunction(UnityEngine.Rendering.CompareFunction value);
            /*0x7ec72e8*/ void SetPassOperation(UnityEngine.Rendering.StencilOp value);
            /*0x7ec7304*/ void SetFailOperation(UnityEngine.Rendering.StencilOp value);
            /*0x7ec7320*/ void SetZFailOperation(UnityEngine.Rendering.StencilOp value);
            /*0x7ec733c*/ UnityEngine.Rendering.CompareFunction get_compareFunctionFront();
            /*0x7ec72d8*/ void set_compareFunctionFront(UnityEngine.Rendering.CompareFunction value);
            /*0x7ec7344*/ UnityEngine.Rendering.StencilOp get_passOperationFront();
            /*0x7ec72f4*/ void set_passOperationFront(UnityEngine.Rendering.StencilOp value);
            /*0x7ec734c*/ UnityEngine.Rendering.StencilOp get_failOperationFront();
            /*0x7ec7310*/ void set_failOperationFront(UnityEngine.Rendering.StencilOp value);
            /*0x7ec7354*/ UnityEngine.Rendering.StencilOp get_zFailOperationFront();
            /*0x7ec732c*/ void set_zFailOperationFront(UnityEngine.Rendering.StencilOp value);
            /*0x7ec735c*/ UnityEngine.Rendering.CompareFunction get_compareFunctionBack();
            /*0x7ec72e0*/ void set_compareFunctionBack(UnityEngine.Rendering.CompareFunction value);
            /*0x7ec7364*/ UnityEngine.Rendering.StencilOp get_passOperationBack();
            /*0x7ec72fc*/ void set_passOperationBack(UnityEngine.Rendering.StencilOp value);
            /*0x7ec736c*/ UnityEngine.Rendering.StencilOp get_failOperationBack();
            /*0x7ec7318*/ void set_failOperationBack(UnityEngine.Rendering.StencilOp value);
            /*0x7ec7374*/ UnityEngine.Rendering.StencilOp get_zFailOperationBack();
            /*0x7ec7334*/ void set_zFailOperationBack(UnityEngine.Rendering.StencilOp value);
            /*0x7ec2c20*/ bool Equals(UnityEngine.Rendering.StencilState other);
            /*0x7ec737c*/ bool Equals(object obj);
            /*0x7ec2e30*/ int GetHashCode();
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

            static /*0x7ec7c70*/ SupportedRenderingFeatures();
            static /*0x7ec73f8*/ UnityEngine.Rendering.SupportedRenderingFeatures get_active();
            static /*0x7ec2044*/ void set_active(UnityEngine.Rendering.SupportedRenderingFeatures value);
            static /*0x7ec75bc*/ void FallbackMixedLightingModeByRef(nint fallbackModePtr);
            static /*0x7ec76f0*/ bool IsMixedLightingModeSupported(UnityEngine.MixedLightingMode mixedMode);
            static /*0x7ec775c*/ void IsMixedLightingModeSupportedByRef(UnityEngine.MixedLightingMode mixedMode, nint isSupportedPtr);
            static /*0x7ec7864*/ bool IsLightmapBakeTypeSupported(UnityEngine.LightmapBakeType bakeType);
            static /*0x7ec78d0*/ void IsLightmapBakeTypeSupportedByRef(UnityEngine.LightmapBakeType bakeType, nint isSupportedPtr);
            static /*0x7ec79c0*/ void IsLightmapsModeSupportedByRef(UnityEngine.LightmapsMode mode, nint isSupportedPtr);
            static /*0x7ec7a4c*/ void IsLightmapperSupportedByRef(int lightmapper, nint isSupportedPtr);
            static /*0x7ec7a74*/ void IsUIOverlayRenderedBySRP(nint isSupportedPtr);
            static /*0x7ec7aec*/ void IsAmbientProbeBakingSupported(nint isSupportedPtr);
            static /*0x7ec7b64*/ void IsDefaultReflectionProbeBakingSupported(nint isSupportedPtr);
            static /*0x7ec7bdc*/ void OverridesLightProbeSystem(nint overridesPtr);
            static /*0x7ec7c54*/ void FallbackLightmapperByRef(nint lightmapperPtr);
            /*0x7ec74a8*/ SupportedRenderingFeatures();
            /*0x7ec7544*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_defaultMixedLightingModes();
            /*0x7ec754c*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_mixedLightingModes();
            /*0x7ec7554*/ UnityEngine.LightmapBakeType get_lightmapBakeTypes();
            /*0x7ec755c*/ UnityEngine.LightmapsMode get_lightmapsModes();
            /*0x7ec7564*/ bool get_enlighten();
            /*0x7ec756c*/ void set_skyOcclusion(bool value);
            /*0x7ec7578*/ bool get_rendersUIOverlay();
            /*0x7ec7580*/ void set_rendersUIOverlay(bool value);
            /*0x7ec758c*/ bool get_ambientProbeBaking();
            /*0x7ec7594*/ bool get_defaultReflectionProbeBaking();
            /*0x7ec759c*/ bool get_overridesLightProbeSystem();
            /*0x7ec75a4*/ void set_overridesLightProbeSystem(bool value);
            /*0x7ec75b0*/ void set_supportsHDR(bool value);

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

            /*0x7ec7cd4*/ UnityEngine.Light get_light();
            /*0x7ec7d60*/ UnityEngine.LightType get_lightType();
            /*0x7ec7d68*/ UnityEngine.Color get_finalColor();
            /*0x7ec7d74*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
            /*0x7ec7d90*/ float get_range();
            /*0x7ec7d98*/ float get_spotAngle();
            /*0x7ec7da0*/ bool Equals(UnityEngine.Rendering.VisibleLight other);
            /*0x7ec7f4c*/ bool Equals(object obj);
            /*0x7ec7fdc*/ int GetHashCode();
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

            /*0x7ec80e4*/ UnityEngine.Texture get_texture();
            /*0x7ec818c*/ UnityEngine.ReflectionProbe get_reflectionProbe();
            /*0x7ec8218*/ UnityEngine.Bounds get_bounds();
            /*0x7ec822c*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
            /*0x7ec8248*/ UnityEngine.Vector4 get_hdrData();
            /*0x7ec8254*/ float get_blendDistance();
            /*0x7ec825c*/ int get_importance();
            /*0x7ec8264*/ bool get_isBoxProjection();
            /*0x7ec82c0*/ bool Equals(UnityEngine.Rendering.VisibleReflectionProbe other);
            /*0x7ec8460*/ bool Equals(object obj);
            /*0x7ec84f0*/ int GetHashCode();
        }

        struct BatchID : System.IEquatable<UnityEngine.Rendering.BatchID>
        {
            static /*0x0*/ UnityEngine.Rendering.BatchID Null;
            /*0x10*/ uint value;

            static /*0x7ec8768*/ BatchID();
            /*0x7ec86a8*/ int GetHashCode();
            /*0x7ec86b0*/ bool Equals(object obj);
            /*0x7ec8758*/ bool Equals(UnityEngine.Rendering.BatchID other);
        }

        struct BatchMaterialID : System.IEquatable<UnityEngine.Rendering.BatchMaterialID>
        {
            static /*0x0*/ UnityEngine.Rendering.BatchMaterialID Null;
            /*0x10*/ uint value;

            static /*0x7ec88d4*/ BatchMaterialID();
            static /*0x7ec8870*/ bool op_Equality(UnityEngine.Rendering.BatchMaterialID a, UnityEngine.Rendering.BatchMaterialID b);
            /*0x7ec87b0*/ int GetHashCode();
            /*0x7ec87b8*/ bool Equals(object obj);
            /*0x7ec8860*/ bool Equals(UnityEngine.Rendering.BatchMaterialID other);
        }

        struct BatchMeshID : System.IEquatable<UnityEngine.Rendering.BatchMeshID>
        {
            static /*0x0*/ UnityEngine.Rendering.BatchMeshID Null;
            /*0x10*/ uint value;

            static /*0x7ec8a40*/ BatchMeshID();
            static /*0x7ec89dc*/ bool op_Equality(UnityEngine.Rendering.BatchMeshID a, UnityEngine.Rendering.BatchMeshID b);
            /*0x7ec891c*/ int GetHashCode();
            /*0x7ec8924*/ bool Equals(object obj);
            /*0x7ec89cc*/ bool Equals(UnityEngine.Rendering.BatchMeshID other);
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

            /*0x7ec8a88*/ int GetHashCode();
            /*0x7ec8a90*/ bool Equals(UnityEngine.Rendering.BatchPackedCullingViewID other);
            /*0x7ec8aa0*/ bool Equals(object obj);
            /*0x7ec8b18*/ int GetInstanceID();
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

            /*0x7ec8b20*/ void set_batchLayer(byte value);
            /*0x7ec8b28*/ void set_motionMode(UnityEngine.MotionVectorGenerationMode value);
            /*0x7ec8b30*/ void set_shadowCastingMode(UnityEngine.Rendering.ShadowCastingMode value);
            /*0x7ec8b38*/ void set_receiveShadows(bool value);
            /*0x7ec8b44*/ void set_staticShadowCaster(bool value);
            /*0x7ec8b50*/ void set_allDepthSorted(bool value);
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

            /*0x7ec8b5c*/ BatchCullingContext(Unity.Collections.NativeArray<UnityEngine.Plane> inCullingPlanes, Unity.Collections.NativeArray<UnityEngine.Rendering.CullingSplit> inCullingSplits, UnityEngine.Rendering.LODParameters inLodParameters, UnityEngine.Matrix4x4 inLocalToWorldMatrix, UnityEngine.Rendering.BatchCullingViewType inViewType, UnityEngine.Rendering.BatchCullingProjectionType inProjectionType, UnityEngine.Rendering.BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, byte inExclusionSplitMask, int inReceiverPlaneOffset, int inReceiverPlaneCount, nint inOcclusionBuffer);
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

            static /*0x7ec93fc*/ UnityEngine.Rendering.BatchBufferTarget GetBufferTarget();
            static /*0x7ec9424*/ UnityEngine.Rendering.BatchBufferTarget get_BufferTarget();
            static /*0x7ec8c6c*/ nint Create(UnityEngine.Rendering.BatchRendererGroup group, void* userContext);
            static /*0x7ec8cf8*/ void Destroy(nint groupHandle);
            static /*0x7ec944c*/ void InvokeOnPerformCulling(UnityEngine.Rendering.BatchRendererGroup group, ref UnityEngine.Rendering.BatchRendererCullingOutput context, ref UnityEngine.Rendering.LODParameters lodParameters, nint userContext);
            static /*0x7ec96dc*/ void InvokeOnFinishedCulling(UnityEngine.Rendering.BatchRendererGroup group, nint customCullingResult);
            static /*0x7ec97a4*/ bool OcclusionTestAABB(nint occlusionBuffer, UnityEngine.Bounds aabb);
            static /*0x7ec8dd4*/ void AddDrawCommandBatch_Injected(nint _unity_self, nint values, int count, ref UnityEngine.GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize, ref UnityEngine.Rendering.BatchID ret);
            static /*0x7ec8f48*/ void RemoveDrawCommandBatch_Injected(nint _unity_self, ref UnityEngine.Rendering.BatchID batchID);
            static /*0x7ec90d4*/ void RegisterMaterials_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper materialID, ref UnityEngine.Bindings.ManagedSpanWrapper batchMaterialID);
            static /*0x7ec9184*/ void UnregisterMaterial_Injected(nint _unity_self, ref UnityEngine.Rendering.BatchMaterialID material);
            static /*0x7ec9308*/ void RegisterMeshes_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper meshID, ref UnityEngine.Bindings.ManagedSpanWrapper batchMeshID);
            static /*0x7ec93b8*/ void UnregisterMesh_Injected(nint _unity_self, ref UnityEngine.Rendering.BatchMeshID mesh);
            static /*0x7ec97e8*/ bool OcclusionTestAABB_Injected(nint occlusionBuffer, ref UnityEngine.Bounds aabb);
            /*0x7ec8be0*/ BatchRendererGroup(UnityEngine.Rendering.BatchRendererGroupCreateInfo info);
            /*0x7ec8cb0*/ void Dispose();
            /*0x7ec8d34*/ UnityEngine.Rendering.BatchID AddDrawCommandBatch(nint values, int count, UnityEngine.GraphicsBufferHandle buffer, uint bufferOffset, uint windowSize);
            /*0x7ec8e58*/ UnityEngine.Rendering.BatchID AddBatch(Unity.Collections.NativeArray<UnityEngine.Rendering.MetadataValue> batchMetadata, UnityEngine.GraphicsBufferHandle buffer);
            /*0x7ec8eec*/ void RemoveDrawCommandBatch(UnityEngine.Rendering.BatchID batchID);
            /*0x7ec8f8c*/ void RemoveBatch(UnityEngine.Rendering.BatchID batchID);
            /*0x7ec8f94*/ void RegisterMaterials(System.ReadOnlySpan<int> materialID, System.Span<UnityEngine.Rendering.BatchMaterialID> batchMaterialID);
            /*0x7ec9128*/ void UnregisterMaterial(UnityEngine.Rendering.BatchMaterialID material);
            /*0x7ec91c8*/ void RegisterMeshes(System.ReadOnlySpan<int> meshID, System.Span<UnityEngine.Rendering.BatchMeshID> batchMeshID);
            /*0x7ec935c*/ void UnregisterMesh(UnityEngine.Rendering.BatchMeshID mesh);

            class OnPerformCulling : System.MulticastDelegate
            {
                /*0x7ec982c*/ OnPerformCulling(object object, nint method);
                /*0x7ec9938*/ Unity.Jobs.JobHandle Invoke(UnityEngine.Rendering.BatchRendererGroup rendererGroup, UnityEngine.Rendering.BatchCullingContext cullingContext, UnityEngine.Rendering.BatchCullingOutput cullingOutput, nint userContext);
            }

            class OnFinishedCulling : System.MulticastDelegate
            {
                /*0x7ec99b4*/ OnFinishedCulling(object object, nint method);
                /*0x7ec9a54*/ void Invoke(nint customCullingResult);
            }

            class BindingsMarshaller
            {
                static /*0x7ec9a68*/ nint ConvertToNative(UnityEngine.Rendering.BatchRendererGroup batchRendererGroup);
            }
        }

        class GPUDrivenLODGroupDataCallback : System.MulticastDelegate
        {
            /*0x7ec9a80*/ GPUDrivenLODGroupDataCallback(object object, nint method);
            /*0x7ec9b30*/ void Invoke(ref UnityEngine.Rendering.GPUDrivenLODGroupData lodGroupData);
        }

        class GPUDrivenLODGroupDataNativeCallback : System.MulticastDelegate
        {
            /*0x7ec9b44*/ GPUDrivenLODGroupDataNativeCallback(object object, nint method);
            /*0x7ec9bf8*/ void Invoke(ref UnityEngine.Rendering.GPUDrivenLODGroupDataNative lodGroupDataNative, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback callback);
        }

        class GPUDrivenRendererDataCallback : System.MulticastDelegate
        {
            /*0x7ec9c0c*/ GPUDrivenRendererDataCallback(object object, nint method);
            /*0x7ec9cc0*/ void Invoke(ref UnityEngine.Rendering.GPUDrivenRendererGroupData rendererData, System.Collections.Generic.IList<UnityEngine.Mesh> meshes, System.Collections.Generic.IList<UnityEngine.Material> materials);
        }

        class GPUDrivenRendererDataNativeCallback : System.MulticastDelegate
        {
            /*0x7ec9cd4*/ GPUDrivenRendererDataNativeCallback(object object, nint method);
            /*0x7ec9d88*/ void Invoke(ref UnityEngine.Rendering.GPUDrivenRendererGroupDataNative rendererDataNative, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, UnityEngine.Rendering.GPUDrivenRendererDataCallback callback);
        }

        class GPUDrivenCallbacks
        {
            static /*0x7ec9d9c*/ void InvokeGPUDrivenLODGroupDataNativeCallback(UnityEngine.Rendering.GPUDrivenLODGroupDataNativeCallback callback, ref UnityEngine.Rendering.GPUDrivenLODGroupDataNative lodGroupDataNative, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback target);
            static /*0x7ec9dc0*/ void InvokeGPUDrivenRendererDataNativeCallback(UnityEngine.Rendering.GPUDrivenRendererDataNativeCallback callback, ref UnityEngine.Rendering.GPUDrivenRendererGroupDataNative rendererDataNative, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, UnityEngine.Rendering.GPUDrivenRendererDataCallback target);
        }

        class GPUDrivenProcessor
        {
            static /*0x0*/ UnityEngine.Rendering.GPUDrivenRendererDataNativeCallback s_NativeRendererCallback;
            static /*0x8*/ UnityEngine.Rendering.GPUDrivenLODGroupDataNativeCallback s_NativeLODGroupCallback;
            /*0x10*/ nint m_Ptr;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Mesh> <scratchMeshes>k__BackingField;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Material> <scratchMaterials>k__BackingField;

            static /*0x7ecab10*/ GPUDrivenProcessor();
            static /*0x7ec9f2c*/ nint Internal_Create();
            static /*0x7eca0ec*/ void Internal_Destroy(nint ptr);
            static /*0x7eca8c0*/ int FindUnsupportedMaterialsImpl(System.ReadOnlySpan<int> materialIDs, System.Span<int> unsupportedMaterialIDs);
            static /*0x7ecaa44*/ int FindUnsupportedMaterialIDs(Unity.Collections.NativeArray<int> materialIDs, Unity.Collections.NativeArray<int> unsupportedMaterialIDs);
            static /*0x7eca25c*/ void EnableGPUDrivenRenderingAndDispatchRendererData_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper renderersID, UnityEngine.Rendering.GPUDrivenRendererDataNativeCallback callback, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, UnityEngine.Rendering.GPUDrivenRendererDataCallback param);
            static /*0x7eca4cc*/ void DisableGPUDrivenRendering_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper renderersID);
            static /*0x7eca62c*/ void DispatchLODGroupData_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper lodGroupID, UnityEngine.Rendering.GPUDrivenLODGroupDataNativeCallback callback, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback param);
            static /*0x7eca7b0*/ void set_enablePartialRendering_Injected(nint _unity_self, bool value);
            static /*0x7eca884*/ void ClearMaterialFilters_Injected(nint _unity_self);
            static /*0x7ecaa00*/ int FindUnsupportedMaterialsImpl_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper materialIDs, ref UnityEngine.Bindings.ManagedSpanWrapper unsupportedMaterialIDs);
            /*0x7ec9e04*/ GPUDrivenProcessor();
            /*0x7ec9de4*/ System.Collections.Generic.List<UnityEngine.Mesh> get_scratchMeshes();
            /*0x7ec9dec*/ void set_scratchMeshes(System.Collections.Generic.List<UnityEngine.Mesh> value);
            /*0x7ec9df4*/ System.Collections.Generic.List<UnityEngine.Material> get_scratchMaterials();
            /*0x7ec9dfc*/ void set_scratchMaterials(System.Collections.Generic.List<UnityEngine.Material> value);
            /*0x7ec9f54*/ void Finalize();
            /*0x7eca06c*/ void Dispose();
            /*0x7ec9fe8*/ void Destroy();
            /*0x7eca128*/ void EnableGPUDrivenRenderingAndDispatchRendererData(System.ReadOnlySpan<int> renderersID, UnityEngine.Rendering.GPUDrivenRendererDataNativeCallback callback, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, UnityEngine.Rendering.GPUDrivenRendererDataCallback param);
            /*0x7eca2d0*/ void EnableGPUDrivenRenderingAndDispatchRendererData(System.ReadOnlySpan<int> renderersID, UnityEngine.Rendering.GPUDrivenRendererDataCallback callback);
            /*0x7eca3c8*/ void DisableGPUDrivenRendering(System.ReadOnlySpan<int> renderersID);
            /*0x7eca510*/ void DispatchLODGroupData(System.ReadOnlySpan<int> lodGroupID, UnityEngine.Rendering.GPUDrivenLODGroupDataNativeCallback callback, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback param);
            /*0x7eca688*/ void DispatchLODGroupData(System.ReadOnlySpan<int> lodGroupID, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback callback);
            /*0x7eca710*/ void set_enablePartialRendering(bool value);
            /*0x7eca7f4*/ void ClearMaterialFilters();

            class BindingsMarshaller
            {
                static /*0x7ecac44*/ nint ConvertToNative(UnityEngine.Rendering.GPUDrivenProcessor obj);
            }

            class <>c
            {
                static /*0x0*/ UnityEngine.Rendering.GPUDrivenProcessor.<> <>9;

                static /*0x7ecac5c*/ <>c();
                /*0x7ecacc4*/ <>c();
                /*0x7ecaccc*/ void <.cctor>b__34_0(ref UnityEngine.Rendering.GPUDrivenRendererGroupDataNative nativeData, System.Collections.Generic.List<UnityEngine.Mesh> meshes, System.Collections.Generic.List<UnityEngine.Material> materials, UnityEngine.Rendering.GPUDrivenRendererDataCallback callback);
                /*0x7ecb2a4*/ void <.cctor>b__34_1(ref UnityEngine.Rendering.GPUDrivenLODGroupDataNative nativeData, UnityEngine.Rendering.GPUDrivenLODGroupDataCallback callback);
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

            /*0x7ecb5c0*/ GPUDrivenPackedRendererData();
            /*0x7ecb560*/ bool get_staticShadowCaster();
            /*0x7ecb56c*/ byte get_lodMask();
            /*0x7ecb578*/ UnityEngine.Rendering.ShadowCastingMode get_shadowCastingMode();
            /*0x7ecb584*/ UnityEngine.Rendering.LightProbeUsage get_lightProbeUsage();
            /*0x7ecb590*/ UnityEngine.MotionVectorGenerationMode get_motionVecGenMode();
            /*0x7ecb59c*/ bool get_isPartOfStaticBatch();
            /*0x7ecb5a8*/ bool get_hasTree();
            /*0x7ecb5b4*/ bool get_smallMeshCulling();
        }

        struct GPUDrivenPackedMaterialData
        {
            /*0x10*/ uint data;

            /*0x7ecb5ec*/ GPUDrivenPackedMaterialData();
            /*0x7ecb5c8*/ bool get_isTransparent();
            /*0x7ecb5d4*/ bool get_isMotionVectorsPassEnabled();
            /*0x7ecb5e0*/ bool get_isIndirectSupported();
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

            static /*0x7ecb5f4*/ uint GetGlobalKeywordCount();
            static /*0x7ecb61c*/ uint GetGlobalKeywordIndex(string keyword);
            static /*0x7ecb7c8*/ void CreateGlobalKeyword(string keyword);
            static /*0x7ecb96c*/ UnityEngine.Rendering.GlobalKeyword Create(string name);
            static /*0x7ecb78c*/ uint GetGlobalKeywordIndex_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            static /*0x7ecb930*/ void CreateGlobalKeyword_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            /*0x7ecb99c*/ GlobalKeyword(string name);
            /*0x7ecbad4*/ string ToString();
        }

        struct LocalKeyword : System.IEquatable<UnityEngine.Rendering.LocalKeyword>
        {
            /*0x10*/ UnityEngine.Rendering.LocalKeywordSpace m_SpaceInfo;
            /*0x18*/ string m_Name;
            /*0x20*/ uint m_Index;

            static /*0x7ecbadc*/ uint GetShaderKeywordCount(UnityEngine.Shader shader);
            static /*0x7ecbb9c*/ uint GetShaderKeywordIndex(UnityEngine.Shader shader, string keyword);
            static /*0x7ecbd90*/ uint GetComputeShaderKeywordCount(UnityEngine.ComputeShader shader);
            static /*0x7ecbe50*/ uint GetComputeShaderKeywordIndex(UnityEngine.ComputeShader shader, string keyword);
            static /*0x7ecbb60*/ uint GetShaderKeywordCount_Injected(nint shader);
            static /*0x7ecbd4c*/ uint GetShaderKeywordIndex_Injected(nint shader, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            static /*0x7ecbe14*/ uint GetComputeShaderKeywordCount_Injected(nint shader);
            static /*0x7ecc000*/ uint GetComputeShaderKeywordIndex_Injected(nint shader, ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            /*0x7ecc044*/ LocalKeyword(UnityEngine.Shader shader, string name);
            /*0x7ecc1f0*/ LocalKeyword(UnityEngine.ComputeShader shader, string name);
            /*0x7ecc39c*/ string ToString();
            /*0x7ecc3a4*/ bool Equals(object o);
            /*0x7ecc42c*/ bool Equals(UnityEngine.Rendering.LocalKeyword rhs);
            /*0x7ecc464*/ int GetHashCode();
        }

        struct LocalKeywordSpace : System.IEquatable<UnityEngine.Rendering.LocalKeywordSpace>
        {
            /*0x10*/ nint m_KeywordSpace;

            static /*0x7ecc458*/ bool op_Equality(UnityEngine.Rendering.LocalKeywordSpace lhs, UnityEngine.Rendering.LocalKeywordSpace rhs);
            /*0x7ecc4a4*/ bool Equals(object o);
            /*0x7ecc51c*/ bool Equals(UnityEngine.Rendering.LocalKeywordSpace rhs);
            /*0x7ecc49c*/ int GetHashCode();
        }

        class RayTracingShader : UnityEngine.Object
        {
            /*0x7ecc52c*/ RayTracingShader();
        }

        struct ShaderKeyword
        {
            /*0x10*/ string m_Name;
            /*0x18*/ uint m_Index;
            /*0x1c*/ bool m_IsLocal;
            /*0x1d*/ bool m_IsCompute;
            /*0x1e*/ bool m_IsValid;

            static /*0x7ecc584*/ uint GetGlobalKeywordCount();
            static /*0x7ecc5ac*/ uint GetGlobalKeywordIndex(string keyword);
            static /*0x7ecc758*/ void CreateGlobalKeyword(string keyword);
            static /*0x7ecc71c*/ uint GetGlobalKeywordIndex_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            static /*0x7ecc8c0*/ void CreateGlobalKeyword_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper keyword);
            /*0x7ecc904*/ ShaderKeyword(string keywordName);
            /*0x7ecc8fc*/ string get_name();
            /*0x7ecc98c*/ string ToString();
        }

        struct ShaderKeywordSet
        {
            /*0x10*/ nint m_KeywordState;
            /*0x18*/ nint m_Shader;
            /*0x20*/ nint m_ComputeShader;
            /*0x28*/ ulong m_StateIndex;

            static /*0x7ecc994*/ bool IsKeywordNameEnabled(UnityEngine.Rendering.ShaderKeywordSet state, string name);
            static /*0x7eccb10*/ bool IsKeywordNameEnabled_Injected(ref UnityEngine.Rendering.ShaderKeywordSet state, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            /*0x7eccb54*/ void CheckKeywordCompatible(UnityEngine.Rendering.ShaderKeyword keyword);
            /*0x7eccc08*/ bool IsEnabled(UnityEngine.Rendering.ShaderKeyword keyword);
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

                static /*0x7ecd4a8*/ RendererListDesc();
                static /*0x7eccd8c*/ UnityEngine.Rendering.RendererListParams ConvertToParameters(ref UnityEngine.Rendering.RendererUtils.RendererListDesc desc);
                /*0x7eccc48*/ uint get_batchLayerMask();
                /*0x7eccc50*/ UnityEngine.Rendering.CullingResults get_cullingResult();
                /*0x7eccc5c*/ UnityEngine.Camera get_camera();
                /*0x7eccc64*/ UnityEngine.Rendering.ShaderTagId get_passName();
                /*0x7eccc6c*/ UnityEngine.Rendering.ShaderTagId[] get_passNames();
                /*0x7eccc74*/ bool IsValid();
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

                static /*0x7ecd72c*/ UnityEngine.Experimental.GlobalIllumination.LinearColor Convert(UnityEngine.Color color, float intensity);
                static /*0x7ecda10*/ UnityEngine.Experimental.GlobalIllumination.LinearColor Black();
                /*0x7ecd510*/ float get_red();
                /*0x7ecd518*/ void set_red(float value);
                /*0x7ecd5c4*/ float get_green();
                /*0x7ecd5cc*/ void set_green(float value);
                /*0x7ecd678*/ float get_blue();
                /*0x7ecd680*/ void set_blue(float value);
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

                static /*0x7ecda24*/ UnityEngine.Experimental.GlobalIllumination.Cookie Defaults();
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

                /*0x7ecda30*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x7ecdaa4*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.PointLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x7ecdb20*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.SpotLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x7ecdba0*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.RectangleLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x7ecdc18*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DiscLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x7ecdc94*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight light);
                /*0x7ecdd0c*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.PointLight light);
                /*0x7ecdd80*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.SpotLight light);
                /*0x7ecdda8*/ void InitNoBake(int lightInstanceID);
            }

            class LightmapperUtils
            {
                static /*0x7ecddb8*/ UnityEngine.Experimental.GlobalIllumination.LightMode Extract(UnityEngine.LightmapBakeType baketype);
                static /*0x7ecddd8*/ UnityEngine.Experimental.GlobalIllumination.LinearColor ExtractIndirect(UnityEngine.Light l);
                static /*0x7ecde50*/ float ExtractInnerCone(UnityEngine.Light l);
                static /*0x7ecdea4*/ UnityEngine.Color ExtractColorTemperature(UnityEngine.Light l);
                static /*0x7ecdf5c*/ void ApplyColorTemperature(UnityEngine.Color cct, ref UnityEngine.Experimental.GlobalIllumination.LinearColor lightColor);
                static /*0x7ecdfa4*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight dir);
                static /*0x7ece13c*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.PointLight point);
                static /*0x7ece2ec*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.SpotLight spot);
                static /*0x7ece4c4*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.RectangleLight rect);
                static /*0x7ece674*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.DiscLight disc);
                static /*0x7ece824*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
            }

            class Lightmapping
            {
                static /*0x0*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate s_DefaultDelegate;
                static /*0x8*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate s_RequestLightsDelegate;

                static /*0x7eceb64*/ Lightmapping();
                static /*0x7ece968*/ void SetDelegate(UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate del);
                static /*0x7ece9e4*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate GetDelegate();
                static /*0x7ecea3c*/ void ResetDelegate();
                static /*0x7ecea98*/ void RequestLights(UnityEngine.Light[] lights, nint outLightsPtr, int outLightsCount);

                class RequestLightsDelegate : System.MulticastDelegate
                {
                    /*0x7ecec44*/ RequestLightsDelegate(object object, nint method);
                    /*0x7ececf8*/ void Invoke(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.<> <>9;

                    static /*0x7eced0c*/ <>c();
                    /*0x7eced74*/ <>c();
                    /*0x7eced7c*/ void <.cctor>b__7_0(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }
            }
        }

        namespace Playables
        {
            struct CameraPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Experimental.Playables.CameraPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x7ecf28c*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x7ecf298*/ bool Equals(UnityEngine.Experimental.Playables.CameraPlayable other);
            }

            struct MaterialEffectPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Experimental.Playables.MaterialEffectPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x7ecf310*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x7ecf31c*/ bool Equals(UnityEngine.Experimental.Playables.MaterialEffectPlayable other);
            }

            struct TextureMixerPlayable : UnityEngine.Playables.IPlayable, System.IEquatable<UnityEngine.Experimental.Playables.TextureMixerPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x7ecf394*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x7ecf3a0*/ bool Equals(UnityEngine.Experimental.Playables.TextureMixerPlayable other);
            }

            struct TexturePlayableOutput : UnityEngine.Playables.IPlayableOutput
            {
                /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

                /*0x7ecf418*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            }
        }

        namespace Rendering
        {
            class BuiltinRuntimeReflectionSystem : UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem, System.IDisposable
            {
                static /*0x7ecf44c*/ bool BuiltinUpdate();
                static /*0x7ecf47c*/ UnityEngine.Experimental.Rendering.BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New();
                /*0x7ecf4d0*/ BuiltinRuntimeReflectionSystem();
                /*0x7ecf424*/ bool TickRealtimeProbes();
                /*0x7ecf474*/ void Dispose();
                /*0x7ecf478*/ void Dispose(bool disposing);
            }

            interface IScriptableRuntimeReflectionSystem : System.IDisposable
            {
                /*0x3813ffc*/ bool TickRealtimeProbes();
            }

            class ScriptableRuntimeReflectionSystemSettings
            {
                static /*0x0*/ UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper s_Instance;

                static /*0x7ecf6a4*/ ScriptableRuntimeReflectionSystemSettings();
                static /*0x7ecf4d8*/ void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value);
                static /*0x7ecf624*/ UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance();
                static /*0x7ecf67c*/ void ScriptingDirtyReflectionSystemInstance();
            }

            class ScriptableRuntimeReflectionSystemWrapper
            {
                /*0x10*/ UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem <implementation>k__BackingField;

                /*0x7ecf720*/ ScriptableRuntimeReflectionSystemWrapper();
                /*0x7ecf728*/ UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem get_implementation();
                /*0x7ecf730*/ void set_implementation(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value);
                /*0x7ecf738*/ void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(ref bool result);
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

                static /*0x7ed0550*/ GraphicsFormatUtility();
                static /*0x7ecf7f8*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Texture texture);
                static /*0x7ecf900*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.TextureFormat format, bool isSRGB);
                static /*0x7ecf984*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_TextureFormat(UnityEngine.TextureFormat format, bool isSRGB);
                static /*0x7ecf9c8*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, bool isSRGB);
                static /*0x7ecfa4c*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(UnityEngine.RenderTextureFormat format, bool isSRGB);
                static /*0x7ecfa90*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
                static /*0x7ecfb18*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits);
                static /*0x7ecfb54*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormat(int depthBits);
                static /*0x7ecfbc8*/ int GetDepthBits(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ecfc04*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits);
                static /*0x7ecfdfc*/ bool IsSRGBFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ecfe38*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetSRGBFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ecfe74*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetLinearFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ecfeb0*/ UnityEngine.RenderTextureFormat GetRenderTextureFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ecfeec*/ uint GetAlphaComponentCount(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ecff28*/ uint GetComponentCount(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ecff64*/ string GetFormatString(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ed009c*/ bool IsCompressedFormat_Native_TextureFormat(UnityEngine.TextureFormat format);
                static /*0x7ed00d8*/ bool IsCompressedFormat(UnityEngine.TextureFormat format);
                static /*0x7ed014c*/ bool CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, bool wholeImage);
                static /*0x7ed0190*/ bool CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ed0208*/ bool IsAlphaOnlyFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ed0244*/ bool HasAlphaChannel(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ed0280*/ bool IsDepthFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ed02bc*/ bool IsStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ed02f8*/ bool IsDepthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ed0334*/ bool IsFloatFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ed0370*/ bool IsHalfFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ed03ac*/ bool IsPVRTCFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ed03e8*/ bool IsCrunchFormat(UnityEngine.TextureFormat format);
                static /*0x7ed0424*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleR(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ed0460*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleG(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ed049c*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleB(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ed04d8*/ UnityEngine.Rendering.FormatSwizzle GetSwizzleA(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ed0514*/ uint GetBlockSize(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x7ecf8c4*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat_Injected(nint texture);
                static /*0x7ed0058*/ void GetFormatString_Injected(UnityEngine.Experimental.Rendering.GraphicsFormat format, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
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
            static /*0x7ed0634*/ UnityEngine.Vector4 GetInnerUV(UnityEngine.Sprite sprite);
            static /*0x7ed0648*/ UnityEngine.Vector4 GetOuterUV(UnityEngine.Sprite sprite);
            static /*0x7ed065c*/ UnityEngine.Vector4 GetPadding(UnityEngine.Sprite sprite);
            static /*0x7ed0670*/ UnityEngine.Vector2 GetMinSize(UnityEngine.Sprite sprite);
        }
    }

    namespace U2D
    {
        class PixelPerfectRendering
        {
            static /*0x7ed06d0*/ void set_pixelSnapSpacing(float value);
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

            static /*0x7ed0708*/ bool RequestAtlas(string tag);
            static /*0x7ed07bc*/ void add_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value);
            static /*0x7ed088c*/ void remove_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value);
            static /*0x7ed095c*/ void PostRegisteredAtlas(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x7ed09c8*/ void Register(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x7ed0a4c*/ void Register_Injected(nint spriteAtlas);
        }

        class SpriteAtlas : UnityEngine.Object
        {
            static /*0x7ed0b00*/ int get_spriteCount_Injected(nint _unity_self);
            static /*0x7ed0c20*/ bool CanBindTo_Injected(nint _unity_self, nint sprite);
            static /*0x7ed0e58*/ nint GetSprite_Injected(nint _unity_self, ref UnityEngine.Bindings.ManagedSpanWrapper name);
            static /*0x7ed0f20*/ int GetSpritesScripting_Injected(nint _unity_self, UnityEngine.Sprite[] sprites);
            /*0x7ed0f64*/ SpriteAtlas();
            /*0x7ed0a88*/ int get_spriteCount();
            /*0x7ed0b3c*/ bool CanBindTo(UnityEngine.Sprite sprite);
            /*0x7ed0c64*/ UnityEngine.Sprite GetSprite(string name);
            /*0x7ed0e9c*/ int GetSprites(UnityEngine.Sprite[] sprites);
            /*0x7ed0ea0*/ int GetSpritesScripting(UnityEngine.Sprite[] sprites);
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
