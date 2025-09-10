class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x175969c*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsReadOnlyAttribute : System.Attribute
            {
                /*0x17596a4*/ IsReadOnlyAttribute();
            }
        }
    }
}

namespace AOT
{
    class MonoPInvokeCallbackAttribute : System.Attribute
    {
        /*0x17596ac*/ MonoPInvokeCallbackAttribute(System.Type type);
    }
}

namespace UnityEngineInternal
{
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

        /*0x17596b4*/ TypeInferenceRuleAttribute(UnityEngineInternal.TypeInferenceRules rule);
        /*0x1759738*/ TypeInferenceRuleAttribute(string rule);
        /*0x1759760*/ string ToString();
    }

    class GenericStack : System.Collections.Stack
    {
        /*0x1759768*/ GenericStack();
    }

    struct MathfInternal
    {
        static /*0x0*/ float FloatMinNormal;
        static /*0x4*/ float FloatMinDenormal;
        static /*0x8*/ bool IsFlushToZeroEnabled;

        static /*0x1759770*/ MathfInternal();
    }
}

namespace Unity
{
    namespace Profiling
    {
        struct ProfilerMarker
        {
            /*0x10*/ nint m_Ptr;

            /*0x1759808*/ ProfilerMarker(string name);
            /*0x17598b8*/ Unity.Profiling.ProfilerMarker.AutoScope Auto();

            struct AutoScope : System.IDisposable
            {
                /*0x10*/ nint m_Ptr;

                /*0x17598fc*/ AutoScope(nint markerPtr);
                /*0x1759978*/ void Dispose();
            }
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
                Warning = 16,
                Counter = 128,
                SampleGPU = 256,
            }

            namespace Unsafe
            {
                class ProfilerUnsafeUtility
                {
                    static /*0x175985c*/ nint CreateMarker(string name, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, int metadataCount);
                    static /*0x175993c*/ void BeginSample(nint markerPtr);
                    static /*0x17599b4*/ void EndSample(nint markerPtr);
                }
            }
        }
    }

    namespace Jobs
    {
        struct JobHandle
        {
            /*0x10*/ nint jobGroup;
            /*0x18*/ int version;

            static /*0x17599f0*/ void ScheduleBatchedJobs();
        }

        namespace LowLevel
        {
            namespace Unsafe
            {
                class JobsUtility
                {
                    static /*0x0*/ Unity.Jobs.LowLevel.Unsafe.JobsUtility.PanicFunction_ PanicFunction;

                    static /*0x1759a18*/ void InvokePanicFunction();

                    class PanicFunction_ : System.MulticastDelegate
                    {
                        /*0x1759a7c*/ PanicFunction_(object object, nint method);
                        /*0x1759b38*/ void Invoke();
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
                /*0x1759b4c*/ Il2CppEagerStaticClassConstructionAttribute();
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
    }

    namespace Collections
    {
        class NativeSliceExtensions
        {
            static Unity.Collections.NativeSlice<T> Slice<T>(Unity.Collections.NativeArray<T> thisArray, int start, int length);
            static Unity.Collections.NativeSlice<T> Slice<T>(Unity.Collections.NativeSlice<T> thisSlice, int start, int length);
        }

        struct NativeSlice<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.NativeSlice<T>>
        {
            /*0x0*/ byte* m_Buffer;
            /*0x0*/ int m_Stride;
            /*0x0*/ int m_Length;

            static Unity.Collections.NativeSlice<T> op_Implicit(Unity.Collections.NativeArray<T> array);
            static bool op_Inequality(Unity.Collections.NativeSlice<T> left, Unity.Collections.NativeSlice<T> right);
            NativeSlice(Unity.Collections.NativeSlice<T> slice, int start, int length);
            NativeSlice(Unity.Collections.NativeArray<T> array);
            NativeSlice(Unity.Collections.NativeArray<T> array, int start, int length);
            T get_Item(int index);
            void set_Item(int index, T value);
            void CopyFrom(Unity.Collections.NativeSlice<T> slice);
            void CopyFrom(T[] array);
            int get_Stride();
            int get_Length();
            Unity.Collections.NativeSlice.Enumerator<T> GetEnumerator();
            System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            bool Equals(Unity.Collections.NativeSlice<T> other);
            bool Equals(object obj);
            int GetHashCode();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.NativeSlice<T> m_Array;
                /*0x0*/ int m_Index;

                Enumerator(ref Unity.Collections.NativeSlice<T> array);
                void Dispose();
                bool MoveNext();
                void Reset();
                T get_Current();
                object System.Collections.IEnumerator.get_Current();
            }
        }

        class NativeSliceDebugView<T>
        {
        }

        class NativeLeakDetection
        {
            static /*0x0*/ int s_NativeLeakDetectionMode;

            static /*0x1759b54*/ void Initialize();
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
            static void Copy(T[] src, Unity.Collections.NativeArray<T> dst);
            static void Copy(Unity.Collections.NativeArray<T> src, T[] dst, int length);
            static void Copy(T[] src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
            static void Copy(Unity.Collections.NativeArray<T> src, int srcIndex, T[] dst, int dstIndex, int length);
            NativeArray(int length, Unity.Collections.Allocator allocator, Unity.Collections.NativeArrayOptions options);
            NativeArray(T[] array, Unity.Collections.Allocator allocator);
            int get_Length();
            T get_Item(int index);
            void set_Item(int index, T value);
            bool get_IsCreated();
            void Dispose();
            T[] ToArray();
            Unity.Collections.NativeArray.Enumerator<T> GetEnumerator();
            System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            bool Equals(Unity.Collections.NativeArray<T> other);
            bool Equals(object obj);
            int GetHashCode();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Collections.NativeArray<T> m_Array;
                /*0x0*/ int m_Index;

                Enumerator(ref Unity.Collections.NativeArray<T> array);
                void Dispose();
                bool MoveNext();
                void Reset();
                T get_Current();
                object System.Collections.IEnumerator.get_Current();
            }
        }

        class NativeArrayDebugView<T>
        {
        }

        enum Allocator
        {
            Invalid = 0,
            None = 1,
            Temp = 2,
            TempJob = 3,
            Persistent = 4,
            AudioKernel = 5,
        }

        class ReadOnlyAttribute : System.Attribute
        {
        }

        class WriteOnlyAttribute : System.Attribute
        {
        }

        class DeallocateOnJobCompletionAttribute : System.Attribute
        {
        }

        class NativeFixedLengthAttribute : System.Attribute
        {
        }

        class NativeMatchesParallelForLengthAttribute : System.Attribute
        {
        }

        class NativeDisableParallelForRestrictionAttribute : System.Attribute
        {
        }

        namespace LowLevel
        {
            namespace Unsafe
            {
                class UnsafeUtility
                {
                    static T ReadArrayElement<T>(void* source, int index);
                    static T ReadArrayElementWithStride<T>(void* source, int index, int stride);
                    static void WriteArrayElement<T>(void* destination, int index, T value);
                    static void WriteArrayElementWithStride<T>(void* destination, int index, int stride, T value);
                    static int SizeOf<T>();
                    static int EnumToInt<T>(T enumValue);
                    static void InternalEnumToInt<T>(ref T enumValue, ref int intValue);
                    static bool EnumEquals<T>(T lhs, T rhs);
                    static int AlignOf<T>();
                    static /*0x1759ba0*/ void* Malloc(long size, int alignment, Unity.Collections.Allocator allocator);
                    static /*0x1759bf4*/ void Free(void* memory, Unity.Collections.Allocator allocator);
                    static /*0x1759c38*/ void MemCpy(void* destination, void* source, long size);
                    static /*0x1759c8c*/ void MemCpyStride(void* destination, int destinationStride, void* source, int sourceStride, int elementSize, int count);
                    static /*0x1759d00*/ void MemSet(void* destination, byte value, long size);
                    static /*0x1759d54*/ void MemClear(void* destination, long size);

                    struct AlignOfHelper<T>
                    {
                        /*0x0*/ byte dummy;
                        /*0x0*/ T data;
                    }
                }

                class NativeSliceUnsafeUtility
                {
                    static Unity.Collections.NativeSlice<T> ConvertExistingDataToNativeSlice<T>(void* dataPointer, int stride, int length);
                    static void* GetUnsafePtr<T>(Unity.Collections.NativeSlice<T> nativeSlice);
                    static void* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeSlice<T> nativeSlice);
                }

                class NativeArrayUnsafeUtility
                {
                    static Unity.Collections.NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Unity.Collections.Allocator allocator);
                    static void* GetUnsafePtr<T>(Unity.Collections.NativeArray<T> nativeArray);
                    static void* GetUnsafeReadOnlyPtr<T>(Unity.Collections.NativeArray<T> nativeArray);
                }

                class NativeContainerAttribute : System.Attribute
                {
                    /*0x1759d9c*/ NativeContainerAttribute();
                }

                class NativeContainerIsReadOnlyAttribute : System.Attribute
                {
                }

                class NativeContainerIsAtomicWriteOnlyAttribute : System.Attribute
                {
                }

                class NativeContainerSupportsMinMaxWriteRestrictionAttribute : System.Attribute
                {
                    /*0x1759da4*/ NativeContainerSupportsMinMaxWriteRestrictionAttribute();
                }

                class NativeContainerSupportsDeallocateOnJobCompletionAttribute : System.Attribute
                {
                    /*0x1759dac*/ NativeContainerSupportsDeallocateOnJobCompletionAttribute();
                }

                class NativeContainerSupportsDeferredConvertListToArray : System.Attribute
                {
                    /*0x1759db4*/ NativeContainerSupportsDeferredConvertListToArray();
                }

                class NativeSetThreadIndexAttribute : System.Attribute
                {
                }

                class NativeContainerNeedsThreadIndexAttribute : System.Attribute
                {
                }

                class WriteAccessRequiredAttribute : System.Attribute
                {
                    /*0x1759dbc*/ WriteAccessRequiredAttribute();
                }

                class NativeDisableUnsafePtrRestrictionAttribute : System.Attribute
                {
                    /*0x1759dc4*/ NativeDisableUnsafePtrRestrictionAttribute();
                }

                class NativeDisableContainerSafetyRestrictionAttribute : System.Attribute
                {
                }

                class NativeSetClassTypeToNullOnScheduleAttribute : System.Attribute
                {
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
            /*0x1759dcc*/ CanBeNullAttribute();
        }

        class NotNullAttribute : System.Attribute
        {
            /*0x1759dd4*/ NotNullAttribute();
        }

        class PureAttribute : System.Attribute
        {
            /*0x1759ddc*/ PureAttribute();
        }
    }
}

namespace UnityEngine
{
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
        Unknown = 42,
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

    class PlayerPrefsException : System.Exception
    {
        /*0x1759de4*/ PlayerPrefsException(string error);
    }

    class PlayerPrefs
    {
        static /*0x1759e4c*/ bool TrySetInt(string key, int value);
        static /*0x1759e90*/ bool TrySetFloat(string key, float value);
        static /*0x1759edc*/ bool TrySetSetString(string key, string value);
        static /*0x1759f20*/ void SetInt(string key, int value);
        static /*0x1759fb4*/ int GetInt(string key, int defaultValue);
        static /*0x1759ff8*/ int GetInt(string key);
        static /*0x175a038*/ void SetFloat(string key, float value);
        static /*0x175a0d4*/ float GetFloat(string key, float defaultValue);
        static /*0x175a120*/ void SetString(string key, string value);
        static /*0x175a1b4*/ string GetString(string key, string defaultValue);
        static /*0x175a1f8*/ string GetString(string key);
        static /*0x175a264*/ bool HasKey(string key);
        static /*0x175a2a0*/ void DeleteKey(string key);
        static /*0x175a2dc*/ void DeleteAll();
        static /*0x175a304*/ void Save();
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
    }

    class AnimationCurve : System.IEquatable<UnityEngine.AnimationCurve>
    {
        /*0x10*/ nint m_Ptr;

        static /*0x175a32c*/ void Internal_Destroy(nint ptr);
        static /*0x175a368*/ nint Internal_Create(UnityEngine.Keyframe[] keys);
        /*0x175a4f0*/ AnimationCurve(UnityEngine.Keyframe[] keys);
        /*0x175a540*/ AnimationCurve();
        /*0x175a3a4*/ bool Internal_Equals(nint other);
        /*0x175a3e8*/ void Finalize();
        /*0x175a4a4*/ float Evaluate(float time);
        /*0x175a58c*/ bool Equals(object o);
        /*0x175a654*/ bool Equals(UnityEngine.AnimationCurve other);
        /*0x175a71c*/ int GetHashCode();
    }

    class DebugLogHandler : UnityEngine.ILogHandler
    {
        static /*0x175a728*/ void Internal_Log(UnityEngine.LogType level, UnityEngine.LogOption options, string msg, UnityEngine.Object obj);
        static /*0x175a784*/ void Internal_LogException(System.Exception ex, UnityEngine.Object obj);
        /*0x175a8c4*/ DebugLogHandler();
        /*0x175a7c8*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
        /*0x175a830*/ void LogException(System.Exception exception, UnityEngine.Object context);
    }

    class Debug
    {
        static /*0x0*/ UnityEngine.ILogger s_DefaultLogger;
        static /*0x8*/ UnityEngine.ILogger s_Logger;

        static /*0x175c10c*/ Debug();
        static /*0x175a8cc*/ UnityEngine.ILogger get_unityLogger();
        static /*0x175a924*/ int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder);
        static /*0x175a978*/ void Log(object message);
        static /*0x175aa80*/ void Log(object message, UnityEngine.Object context);
        static /*0x175ab98*/ void LogError(object message);
        static /*0x175aca0*/ void LogError(object message, UnityEngine.Object context);
        static /*0x175adb8*/ void LogErrorFormat(string format, object[] args);
        static /*0x175aed0*/ void LogErrorFormat(UnityEngine.Object context, string format, object[] args);
        static /*0x175afec*/ void LogException(System.Exception exception);
        static /*0x175b0f4*/ void LogException(System.Exception exception, UnityEngine.Object context);
        static /*0x175b208*/ void LogWarning(object message);
        static /*0x175b310*/ void LogWarning(object message, UnityEngine.Object context);
        static /*0x175b428*/ void LogWarningFormat(string format, object[] args);
        static /*0x175b540*/ void LogWarningFormat(UnityEngine.Object context, string format, object[] args);
        static /*0x175b65c*/ void Assert(bool condition);
        static /*0x175b78c*/ void Assert(bool condition, string message);
        static /*0x175b8a8*/ void LogAssertion(object message);
        static /*0x175b9b0*/ void LogAssertionFormat(string format, object[] args);
        static /*0x175bac8*/ bool get_isDebugBuild();
        static /*0x175baf0*/ bool CallOverridenDebugHandler(System.Exception exception, UnityEngine.Object obj);
        static /*0x175bee8*/ bool IsLoggingEnabled();
    }

    class SerializeField : System.Attribute
    {
        /*0x175c254*/ SerializeField();
    }

    class SerializeReference : System.Attribute
    {
    }

    class PreferBinarySerialization : System.Attribute
    {
    }

    interface ISerializationCallbackReceiver
    {
        void OnBeforeSerialize();
        void OnAfterDeserialize();
    }

    class UnityLogWriter : System.IO.TextWriter
    {
        static /*0x175c25c*/ void WriteStringToUnityLog(string s);
        static /*0x175c2a0*/ void WriteStringToUnityLogImpl(string s);
        static /*0x175c2dc*/ void Init();
        /*0x175c35c*/ UnityLogWriter();
        /*0x175c3b4*/ System.Text.Encoding get_Encoding();
        /*0x175c3bc*/ void Write(char value);
        /*0x175c410*/ void Write(string s);
        /*0x175c454*/ void Write(char[] buffer, int index, int count);
    }

    interface ILogger : UnityEngine.ILogHandler
    {
        UnityEngine.ILogHandler get_logHandler();
        bool get_logEnabled();
        void Log(UnityEngine.LogType logType, object message);
        void Log(UnityEngine.LogType logType, object message, UnityEngine.Object context);
        void Log(UnityEngine.LogType logType, string tag, object message);
        void Log(object message);
        void Log(string tag, object message);
        void LogWarning(string tag, object message);
        void LogError(string tag, object message);
        void LogFormat(UnityEngine.LogType logType, string format, object[] args);
        void LogException(System.Exception exception);
    }

    interface ILogHandler
    {
        void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
        void LogException(System.Exception exception, UnityEngine.Object context);
    }

    class Logger : UnityEngine.ILogger, UnityEngine.ILogHandler
    {
        /*0x10*/ UnityEngine.ILogHandler <logHandler>k__BackingField;
        /*0x18*/ bool <logEnabled>k__BackingField;
        /*0x1c*/ UnityEngine.LogType <filterLogType>k__BackingField;

        static /*0x175c50c*/ string GetString(object message);
        /*0x175c21c*/ Logger(UnityEngine.ILogHandler logHandler);
        /*0x175c49c*/ UnityEngine.ILogHandler get_logHandler();
        /*0x175c4a4*/ void set_logHandler(UnityEngine.ILogHandler value);
        /*0x175c4ac*/ bool get_logEnabled();
        /*0x175c4b4*/ void set_logEnabled(bool value);
        /*0x175c4c0*/ UnityEngine.LogType get_filterLogType();
        /*0x175c4c8*/ void set_filterLogType(UnityEngine.LogType value);
        /*0x175c4d0*/ bool IsLogTypeAllowed(UnityEngine.LogType logType);
        /*0x175c62c*/ void Log(UnityEngine.LogType logType, object message);
        /*0x175c7a0*/ void Log(UnityEngine.LogType logType, object message, UnityEngine.Object context);
        /*0x175c918*/ void Log(UnityEngine.LogType logType, string tag, object message);
        /*0x175cab8*/ void Log(object message);
        /*0x175cc14*/ void Log(string tag, object message);
        /*0x175cda8*/ void LogWarning(string tag, object message);
        /*0x175cf3c*/ void LogError(string tag, object message);
        /*0x175d0cc*/ void LogException(System.Exception exception);
        /*0x175d190*/ void LogException(System.Exception exception, UnityEngine.Object context);
        /*0x175d264*/ void LogFormat(UnityEngine.LogType logType, string format, object[] args);
        /*0x175d35c*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
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
        static /*0x175d464*/ void SetCursor(UnityEngine.Texture2D texture, UnityEngine.Vector2 hotspot, UnityEngine.CursorMode cursorMode);
        static /*0x175d510*/ UnityEngine.CursorLockMode get_lockState();
        static /*0x175d4bc*/ void SetCursor_Injected(UnityEngine.Texture2D texture, ref UnityEngine.Vector2 hotspot, UnityEngine.CursorMode cursorMode);
    }

    class Light : UnityEngine.Behaviour
    {
        /*0x18*/ int m_BakedIndex;

        /*0x175d538*/ UnityEngine.LightShadows get_shadows();
        /*0x175d574*/ float get_cookieSize();
        /*0x175d5b0*/ UnityEngine.Texture get_cookie();
        /*0x175d5ec*/ UnityEngine.LightType get_type();
        /*0x175d628*/ float get_spotAngle();
        /*0x175d664*/ UnityEngine.Color get_color();
        /*0x175d700*/ void set_color(UnityEngine.Color value);
        /*0x175d798*/ float get_colorTemperature();
        /*0x175d7d4*/ bool get_useColorTemperature();
        /*0x175d810*/ float get_intensity();
        /*0x175d84c*/ void set_intensity(float value);
        /*0x175d898*/ float get_bounceIntensity();
        /*0x175d8d4*/ float get_range();
        /*0x175d910*/ UnityEngine.LightBakingOutput get_bakingOutput();
        /*0x175d6bc*/ void get_color_Injected(ref UnityEngine.Color ret);
        /*0x175d754*/ void set_color_Injected(ref UnityEngine.Color value);
        /*0x175d978*/ void get_bakingOutput_Injected(ref UnityEngine.LightBakingOutput ret);
    }

    class Renderer : UnityEngine.Component
    {
        /*0x175d9bc*/ UnityEngine.Material GetMaterial();
        /*0x175d9f8*/ UnityEngine.Material GetSharedMaterial();
        /*0x175da34*/ void SetMaterial(UnityEngine.Material m);
        /*0x175da78*/ UnityEngine.Material[] GetMaterialArray();
        /*0x175dab4*/ void SetMaterialArray(UnityEngine.Material[] m);
        /*0x175daf8*/ bool get_enabled();
        /*0x175db34*/ void set_enabled(bool value);
        /*0x175db78*/ bool get_isVisible();
        /*0x175dbb4*/ void set_shadowCastingMode(UnityEngine.Rendering.ShadowCastingMode value);
        /*0x175dbf8*/ void set_receiveShadows(bool value);
        /*0x175dc3c*/ int get_sortingLayerID();
        /*0x175dc78*/ void set_sortingLayerID(int value);
        /*0x175dcbc*/ int get_sortingOrder();
        /*0x175dcf8*/ void set_sortingOrder(int value);
        /*0x175dd3c*/ UnityEngine.Material[] get_materials();
        /*0x175dd78*/ void set_materials(UnityEngine.Material[] value);
        /*0x175ddbc*/ UnityEngine.Material get_material();
        /*0x175ddf8*/ void set_material(UnityEngine.Material value);
        /*0x175de3c*/ UnityEngine.Material get_sharedMaterial();
        /*0x175de78*/ void set_sharedMaterial(UnityEngine.Material value);
    }

    class TrailRenderer : UnityEngine.Renderer
    {
        /*0x175debc*/ float get_time();
        /*0x175def8*/ void set_time(float value);
    }

    class LineRenderer : UnityEngine.Renderer
    {
        /*0x175df44*/ void SetPosition(int index, UnityEngine.Vector3 position);
        /*0x175dfa0*/ void SetPosition_Injected(int index, ref UnityEngine.Vector3 position);
    }

    class SkinnedMeshRenderer : UnityEngine.Renderer
    {
    }

    class MeshRenderer : UnityEngine.Renderer
    {
        /*0x175dff4*/ void DontStripMeshRenderer();
    }

    class Mesh : UnityEngine.Object
    {
        static /*0x175dff8*/ void Internal_Create(UnityEngine.Mesh mono);
        static /*0x175e644*/ UnityEngine.Rendering.VertexAttribute GetUVChannel(int uvIndex);
        static /*0x175e6bc*/ int DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute channel);
        /*0x175e034*/ Mesh();
        /*0x175e0bc*/ int[] GetIndicesImpl(int submesh, bool applyBaseVertex);
        /*0x175e110*/ void SetIndicesImpl(int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        /*0x175e1ac*/ void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute ch);
        /*0x175e1f0*/ bool HasVertexAttribute(UnityEngine.Rendering.VertexAttribute attr);
        /*0x175e234*/ void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x175e2d0*/ System.Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim);
        /*0x175e32c*/ void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values);
        /*0x175e398*/ bool get_canAccess();
        /*0x175e3d4*/ int get_vertexCount();
        /*0x175e410*/ int get_subMeshCount();
        /*0x175e44c*/ UnityEngine.Bounds get_bounds();
        /*0x175e4f8*/ void set_bounds(UnityEngine.Bounds value);
        /*0x175e580*/ void ClearImpl(bool keepVertexLayout);
        /*0x175e5c4*/ void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x175e608*/ void MarkDynamicImpl();
        T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim);
        T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel);
        /*0x175e75c*/ void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags);
        void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags);
        void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Collections.Generic.List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, System.Collections.Generic.List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        void GetListForChannel<T>(System.Collections.Generic.List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim);
        void GetListForChannel<T>(System.Collections.Generic.List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim, UnityEngine.Rendering.VertexAttributeFormat channelType);
        /*0x175ea00*/ UnityEngine.Vector3[] get_vertices();
        /*0x175ea4c*/ void set_vertices(UnityEngine.Vector3[] value);
        /*0x175eaac*/ UnityEngine.Vector3[] get_normals();
        /*0x175eaf8*/ void set_normals(UnityEngine.Vector3[] value);
        /*0x175eb58*/ UnityEngine.Vector4[] get_tangents();
        /*0x175eba4*/ void set_tangents(UnityEngine.Vector4[] value);
        /*0x175ec04*/ void set_uv(UnityEngine.Vector2[] value);
        /*0x175ec64*/ void set_uv2(UnityEngine.Vector2[] value);
        /*0x175ecc4*/ UnityEngine.Color32[] get_colors32();
        /*0x175ed18*/ void set_colors32(UnityEngine.Color32[] value);
        /*0x175ed80*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices);
        /*0x175edec*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length);
        /*0x175edf4*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x175ee70*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals);
        /*0x175eedc*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length);
        /*0x175eee4*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x175ef60*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents);
        /*0x175efcc*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length);
        /*0x175efd4*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x175f050*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors);
        /*0x175f0bc*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length);
        /*0x175f0c4*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        void SetUvsImpl<T>(int uvIndex, int dim, System.Collections.Generic.List<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x175f158*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs);
        /*0x175f1cc*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length);
        /*0x175f1d4*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        void GetUVsImpl<T>(int uvIndex, System.Collections.Generic.List<T> uvs, int dim);
        /*0x175f260*/ void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs);
        /*0x175f2c4*/ void PrintErrorCantAccessIndices();
        /*0x175f3cc*/ bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles);
        /*0x175f50c*/ bool CheckCanAccessSubmeshTriangles(int submesh);
        /*0x175f514*/ bool CheckCanAccessSubmeshIndices(int submesh);
        /*0x175f51c*/ void set_triangles(int[] value);
        /*0x175f684*/ int[] GetIndices(int submesh);
        /*0x175f68c*/ int[] GetIndices(int submesh, bool applyBaseVertex);
        /*0x175f734*/ void CheckIndicesArrayRange(int valuesLength, int start, int length);
        /*0x175f5e4*/ void SetTrianglesImpl(int submesh, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex);
        /*0x175f8e0*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh);
        /*0x175f8ec*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x175f974*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x175fa9c*/ void Clear();
        /*0x175fadc*/ void RecalculateBounds();
        /*0x175fae4*/ void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x175fbd4*/ void MarkDynamic();
        /*0x175e4b4*/ void get_bounds_Injected(ref UnityEngine.Bounds ret);
        /*0x175e53c*/ void set_bounds_Injected(ref UnityEngine.Bounds value);

        struct MeshData
        {
            /*0x10*/ nint m_Ptr;
        }
    }

    class Texture : UnityEngine.Object
    {
        static /*0x0*/ int GenerateAllMips;

        static /*0x1760610*/ Texture();
        /*0x175fc48*/ Texture();
        /*0x175fca0*/ int GetDataWidth();
        /*0x175fcdc*/ int GetDataHeight();
        /*0x175fd18*/ int get_width();
        /*0x175fd54*/ void set_width(int value);
        /*0x175fd94*/ int get_height();
        /*0x175fdd0*/ void set_height(int value);
        /*0x175fe10*/ bool get_isReadable();
        /*0x175fe4c*/ UnityEngine.TextureWrapMode get_wrapMode();
        /*0x175fe88*/ void set_wrapMode(UnityEngine.TextureWrapMode value);
        /*0x175fecc*/ UnityEngine.FilterMode get_filterMode();
        /*0x175ff08*/ void set_filterMode(UnityEngine.FilterMode value);
        /*0x175ff4c*/ UnityEngine.Vector2 get_texelSize();
        /*0x175ffdc*/ int Internal_GetActiveTextureColorSpace();
        /*0x1760018*/ UnityEngine.ColorSpace get_activeTextureColorSpace();
        /*0x1760060*/ bool ValidateFormat(UnityEngine.TextureFormat format);
        /*0x17602ec*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage);
        /*0x17604fc*/ UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture t);
        /*0x175ff98*/ void get_texelSize_Injected(ref UnityEngine.Vector2 ret);
    }

    class Texture2D : UnityEngine.Texture
    {
        static int streamingMipmapsPriorityMin = -128;
        static int streamingMipmapsPriorityMax = 127;

        static /*0x1760698*/ UnityEngine.Texture2D get_whiteTexture();
        static /*0x17606c0*/ UnityEngine.Texture2D get_blackTexture();
        static /*0x17606e8*/ bool Internal_CreateImpl(UnityEngine.Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x176076c*/ void Internal_Create(UnityEngine.Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        /*0x1760fa4*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, nint nativeTex);
        /*0x17610e0*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x1761170*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x17611fc*/ Texture2D(int width, int height);
        /*0x176065c*/ UnityEngine.TextureFormat get_format();
        /*0x1760840*/ bool get_isReadable();
        /*0x176087c*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x17608d0*/ bool ReinitializeImpl(int width, int height);
        /*0x1760924*/ void SetPixelImpl(int image, int mip, int x, int y, UnityEngine.Color color);
        /*0x1760a1c*/ UnityEngine.Color GetPixelImpl(int image, int mip, int x, int y);
        /*0x1760b18*/ UnityEngine.Color GetPixelBilinearImpl(int image, int mip, float u, float v);
        /*0x1760c14*/ bool ReinitializeWithFormatImpl(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, bool hasMipMap);
        /*0x1760c80*/ void ReadPixelsImpl(UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps);
        /*0x1760d60*/ void SetPixelsImpl(int x, int y, int w, int h, UnityEngine.Color[] pixel, int miplevel, int frame);
        /*0x1760dec*/ nint GetWritableImageData(int frame);
        /*0x1760e30*/ long GetRawImageDataSize();
        /*0x1760e6c*/ void SetAllPixels32(UnityEngine.Color32[] colors, int miplevel);
        /*0x1760ec0*/ bool ValidateFormat(UnityEngine.TextureFormat format, int width, int height);
        /*0x176129c*/ void SetPixel(int x, int y, UnityEngine.Color color);
        /*0x1761338*/ void SetPixels(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color[] colors, int miplevel);
        /*0x17613f8*/ void SetPixels(UnityEngine.Color[] colors, int miplevel);
        /*0x1761470*/ void SetPixels(UnityEngine.Color[] colors);
        /*0x17614cc*/ UnityEngine.Color GetPixel(int x, int y);
        /*0x1761538*/ UnityEngine.Color GetPixelBilinear(float u, float v);
        Unity.Collections.NativeArray<T> GetRawTextureData<T>();
        /*0x17615a0*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x176162c*/ void Apply();
        /*0x1761638*/ bool Reinitialize(int width, int height);
        /*0x17616c4*/ bool Reinitialize(int width, int height, UnityEngine.TextureFormat format, bool hasMipMap);
        /*0x17617b0*/ bool Resize(int width, int height);
        /*0x17617b4*/ bool Resize(int width, int height, UnityEngine.TextureFormat format, bool hasMipMap);
        /*0x17617bc*/ void ReadPixels(UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps);
        /*0x176185c*/ void ReadPixels(UnityEngine.Rect source, int destX, int destY);
        /*0x1761864*/ void SetPixels32(UnityEngine.Color32[] colors, int miplevel);
        /*0x17618b8*/ void SetPixels32(UnityEngine.Color32[] colors);
        /*0x17609a8*/ void SetPixelImpl_Injected(int image, int mip, int x, int y, ref UnityEngine.Color color);
        /*0x1760aa4*/ void GetPixelImpl_Injected(int image, int mip, int x, int y, ref UnityEngine.Color ret);
        /*0x1760ba0*/ void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, ref UnityEngine.Color ret);
        /*0x1760cf4*/ void ReadPixelsImpl_Injected(ref UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps);
    }

    class Cubemap : UnityEngine.Texture
    {
        static /*0x1761900*/ bool Internal_CreateImpl(UnityEngine.Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x1761974*/ void Internal_Create(UnityEngine.Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x176206c*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x1761c68*/ Cubemap(int width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x1761d08*/ Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x1761df0*/ Cubemap(int width, UnityEngine.TextureFormat format, int mipCount);
        /*0x1761f90*/ Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x1761e68*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex);
        /*0x17620c4*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, bool mipChain, nint nativeTex);
        /*0x17620d4*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x1761a38*/ bool get_isReadable();
        /*0x1761a74*/ bool ValidateFormat(UnityEngine.TextureFormat format, int width);
        /*0x1761b44*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width);
    }

    class Texture3D : UnityEngine.Texture
    {
        static /*0x1762190*/ bool Internal_CreateImpl(UnityEngine.Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x176221c*/ void Internal_Create(UnityEngine.Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x1762500*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x17622f8*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x1762374*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x1762414*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x1762558*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount);
        /*0x17626a4*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex);
        /*0x17627d8*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x17627e8*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, nint nativeTex);
        /*0x1762154*/ bool get_isReadable();
    }

    class Texture2DArray : UnityEngine.Texture
    {
        static /*0x1762834*/ bool Internal_CreateImpl(UnityEngine.Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x17628b8*/ void Internal_Create(UnityEngine.Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x1762d98*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x1762ba0*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x1762c1c*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x1762cbc*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x1762df0*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x1762f38*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x1762f4c*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x17627f8*/ bool get_isReadable();
        /*0x176298c*/ bool ValidateFormat(UnityEngine.TextureFormat format, int width, int height);
        /*0x1762a70*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, int width, int height);
    }

    class CubemapArray : UnityEngine.Texture
    {
        static /*0x1762f9c*/ bool Internal_CreateImpl(UnityEngine.CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x1763010*/ void Internal_Create(UnityEngine.CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x17632a8*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x17630d4*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x1763148*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x17631d8*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x1763300*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x1763438*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x176344c*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x1762f60*/ bool get_isReadable();
    }

    class RenderTexture : UnityEngine.Texture
    {
        static /*0x176362c*/ UnityEngine.RenderTexture GetActive();
        static /*0x1763654*/ void SetActive(UnityEngine.RenderTexture rt);
        static /*0x1763690*/ UnityEngine.RenderTexture get_active();
        static /*0x17636b8*/ void set_active(UnityEngine.RenderTexture value);
        static /*0x1763a00*/ void Internal_Create(UnityEngine.RenderTexture rt);
        static /*0x1763b80*/ UnityEngine.RenderTexture GetTemporary_Internal(UnityEngine.RenderTextureDescriptor desc);
        static /*0x1763bf8*/ void ReleaseTemporary(UnityEngine.RenderTexture temp);
        static /*0x1764758*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat);
        static /*0x1763d80*/ void ValidateRenderTextureDesc(UnityEngine.RenderTextureDescriptor desc);
        static /*0x1764e2c*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.RenderTextureFormat renderTextureFormat, UnityEngine.RenderTextureReadWrite readWrite);
        static /*0x1764ff4*/ UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc);
        static /*0x1765090*/ UnityEngine.RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale);
        static /*0x1765220*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format);
        static /*0x1763bbc*/ UnityEngine.RenderTexture GetTemporary_Internal_Injected(ref UnityEngine.RenderTextureDescriptor desc);
        /*0x1763c34*/ RenderTexture();
        /*0x1763c88*/ RenderTexture(UnityEngine.RenderTextureDescriptor desc);
        /*0x17641f8*/ RenderTexture(UnityEngine.RenderTexture textureToCopy);
        /*0x1764454*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format);
        /*0x17644c8*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x1764558*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount);
        /*0x17647dc*/ RenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount);
        /*0x17649e0*/ RenderTexture(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
        /*0x1764a70*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
        /*0x1764cf4*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format);
        /*0x1764e24*/ RenderTexture(int width, int height, int depth);
        /*0x1764d84*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format, int mipCount);
        /*0x1763460*/ int get_width();
        /*0x176349c*/ void set_width(int value);
        /*0x17634e0*/ int get_height();
        /*0x176351c*/ void set_height(int value);
        /*0x1763560*/ void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x17635a4*/ void set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x17635e8*/ void set_autoGenerateMips(bool value);
        /*0x17636f4*/ UnityEngine.RenderBuffer GetColorBuffer();
        /*0x176378c*/ UnityEngine.RenderBuffer GetDepthBuffer();
        /*0x1763824*/ void SetMipMapCount(int count);
        /*0x1763868*/ UnityEngine.RenderBuffer get_colorBuffer();
        /*0x176386c*/ UnityEngine.RenderBuffer get_depthBuffer();
        /*0x1763870*/ void DiscardContents(bool discardColor, bool discardDepth);
        /*0x17638c4*/ void DiscardContents();
        /*0x1763908*/ bool Create();
        /*0x1763944*/ void Release();
        /*0x1763980*/ bool IsCreated();
        /*0x17639bc*/ void SetSRGBReadWrite(bool srgb);
        /*0x1763a3c*/ void SetRenderTextureDescriptor(UnityEngine.RenderTextureDescriptor desc);
        /*0x1763ac4*/ UnityEngine.RenderTextureDescriptor GetDescriptor();
        /*0x1764b18*/ void Initialize(int width, int height, int depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite, int mipCount);
        /*0x17643c4*/ UnityEngine.RenderTextureDescriptor get_descriptor();
        /*0x1763748*/ void GetColorBuffer_Injected(ref UnityEngine.RenderBuffer ret);
        /*0x17637e0*/ void GetDepthBuffer_Injected(ref UnityEngine.RenderBuffer ret);
        /*0x1763a80*/ void SetRenderTextureDescriptor_Injected(ref UnityEngine.RenderTextureDescriptor desc);
        /*0x1763b3c*/ void GetDescriptor_Injected(ref UnityEngine.RenderTextureDescriptor ret);
    }

    class CustomRenderTexture : UnityEngine.RenderTexture
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

    class MeshFilter : UnityEngine.Component
    {
        /*0x1765278*/ void DontStripMeshFilter();
        /*0x176527c*/ void set_sharedMesh(UnityEngine.Mesh value);
        /*0x17652c0*/ void set_mesh(UnityEngine.Mesh value);
    }

    class Halo : UnityEngine.Behaviour
    {
    }

    class Graphics
    {
        static /*0x0*/ int kMaxDrawMeshInstanceCount;

        static /*0x17657a0*/ Graphics();
        static /*0x1765304*/ void SetRenderTarget(UnityEngine.RenderTexture rt);
        static /*0x17653e0*/ void SetRenderTargetImpl(UnityEngine.RenderBuffer colorBuffer, UnityEngine.RenderBuffer depthBuffer, int mipLevel, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x1765524*/ void SetRenderTargetImpl(UnityEngine.RenderTexture rt, int mipLevel, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x1765364*/ void SetRenderTarget(UnityEngine.RenderTexture rt, int mipLevel, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x17656d0*/ int Internal_GetMaxDrawMeshInstanceCount();
        static /*0x17656a8*/ void Internal_SetNullRT();
        static /*0x176547c*/ void Internal_SetRTSimple(UnityEngine.RenderBuffer color, UnityEngine.RenderBuffer depth, int mip, UnityEngine.CubemapFace face, int depthSlice);
        static /*0x1765764*/ void Internal_DrawTexture(ref UnityEngine.Internal_DrawTextureArguments args);
        static /*0x17656f8*/ void Internal_SetRTSimple_Injected(ref UnityEngine.RenderBuffer color, ref UnityEngine.RenderBuffer depth, int mip, UnityEngine.CubemapFace face, int depthSlice);
    }

    struct Resolution
    {
        /*0x10*/ int m_Width;
        /*0x14*/ int m_Height;
        /*0x18*/ int m_RefreshRate;

        /*0x176580c*/ string ToString();
    }

    struct RenderBuffer
    {
        /*0x10*/ int m_RenderTextureInstanceID;
        /*0x18*/ nint m_BufferPtr;
    }

    struct Internal_DrawTextureArguments
    {
        /*0x10*/ UnityEngine.Rect screenRect;
        /*0x20*/ UnityEngine.Rect sourceRect;
        /*0x30*/ int leftBorder;
        /*0x34*/ int rightBorder;
        /*0x38*/ int topBorder;
        /*0x3c*/ int bottomBorder;
        /*0x40*/ UnityEngine.Color leftBorderColor;
        /*0x50*/ UnityEngine.Color rightBorderColor;
        /*0x60*/ UnityEngine.Color topBorderColor;
        /*0x70*/ UnityEngine.Color bottomBorderColor;
        /*0x80*/ UnityEngine.Color color;
        /*0x90*/ UnityEngine.Vector4 borderWidths;
        /*0xa0*/ UnityEngine.Vector4 cornerRadiuses;
        /*0xb0*/ bool smoothCorners;
        /*0xb4*/ int pass;
        /*0xb8*/ UnityEngine.Texture texture;
        /*0xc0*/ UnityEngine.Material mat;
    }

    class QualitySettings : UnityEngine.Object
    {
        static /*0x1765978*/ void set_vSyncCount(int value);
        static /*0x17659b4*/ UnityEngine.ColorSpace get_activeColorSpace();
    }

    class RenderSettings : UnityEngine.Object
    {
        static /*0x17659dc*/ void set_fogColor(UnityEngine.Color value);
        static /*0x1765a5c*/ void set_ambientSkyColor(UnityEngine.Color value);
        static /*0x1765adc*/ void set_customReflection(UnityEngine.Texture value);
        static /*0x1765a20*/ void set_fogColor_Injected(ref UnityEngine.Color value);
        static /*0x1765aa0*/ void set_ambientSkyColor_Injected(ref UnityEngine.Color value);
    }

    class CustomRenderTextureManager
    {
        static /*0x0*/ System.Action<UnityEngine.CustomRenderTexture> textureLoaded;
        static /*0x8*/ System.Action<UnityEngine.CustomRenderTexture> textureUnloaded;

        static /*0x1765b18*/ void InvokeOnTextureLoaded_Internal(UnityEngine.CustomRenderTexture source);
        static /*0x1765b84*/ void InvokeOnTextureUnloaded_Internal(UnityEngine.CustomRenderTexture source);
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

        /*0x1765148*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat);
        /*0x1765da4*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat, int mipCount);
        /*0x1765bf0*/ int get_width();
        /*0x1765bf8*/ void set_width(int value);
        /*0x1765c00*/ int get_height();
        /*0x1765c08*/ void set_height(int value);
        /*0x1765c10*/ int get_msaaSamples();
        /*0x1765c18*/ void set_msaaSamples(int value);
        /*0x1765c20*/ int get_volumeDepth();
        /*0x1765c28*/ void set_volumeDepth(int value);
        /*0x1765c30*/ void set_mipCount(int value);
        /*0x1764fa8*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x1765c38*/ void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x1765d6c*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_depthStencilFormat();
        /*0x1765d74*/ void set_depthStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x1765cec*/ int get_depthBufferBits();
        /*0x1765d48*/ void set_depthBufferBits(int value);
        /*0x1765d7c*/ UnityEngine.Rendering.TextureDimension get_dimension();
        /*0x1765d84*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
        /*0x1765d8c*/ void set_shadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode value);
        /*0x1765d94*/ void set_vrUsage(UnityEngine.VRTextureUsage value);
        /*0x1765d9c*/ void set_memoryless(UnityEngine.RenderTextureMemoryless value);
        /*0x1765cd0*/ void SetOrClearRenderTextureCreationFlag(bool value, UnityEngine.RenderTextureCreationFlags flag);
        /*0x1765074*/ void set_createdFromScript(bool value);
        /*0x1765204*/ void set_useDynamicScale(bool value);
    }

    class LightmapSettings : UnityEngine.Object
    {
    }

    class LightProbes : UnityEngine.Object
    {
        static /*0x0*/ System.Action tetrahedralizationCompleted;
        static /*0x8*/ System.Action needsRetetrahedralization;

        static /*0x1765e00*/ void Internal_CallTetrahedralizationCompletedFunction();
        static /*0x1765e64*/ void Internal_CallNeedsRetetrahedralizationFunction();
    }

    class MaterialPropertyBlock
    {
        /*0x10*/ nint m_Ptr;

        static /*0x1766084*/ nint CreateImpl();
        static /*0x176620c*/ void DestroyImpl(nint mpb);
        /*0x176603c*/ MaterialPropertyBlock();
        /*0x1765ec8*/ void SetVectorArray(int name, UnityEngine.Vector4[] values, int count);
        /*0x17660ac*/ void Finalize();
        /*0x1766140*/ void Dispose();
        /*0x1766248*/ void SetFloat(int nameID, float value);
        /*0x17662f0*/ void SetVector(int nameID, UnityEngine.Vector4 value);
        /*0x1766350*/ void SetTexture(int nameID, UnityEngine.Texture value);
        /*0x17663f8*/ void SetVectorArray(int nameID, UnityEngine.Vector4[] values);
        /*0x176629c*/ void SetFloatImpl(int name, float value);
        /*0x17662f4*/ void SetVectorImpl(int name, UnityEngine.Vector4 value);
        /*0x17663a4*/ void SetTextureImpl(int name, UnityEngine.Texture value);
        /*0x1765fe0*/ void SetVectorArrayImpl(int name, UnityEngine.Vector4[] values, int count);
        /*0x1766464*/ void Clear(bool keepMemory);
        /*0x17664a8*/ void Clear();
        /*0x1766410*/ void SetVectorImpl_Injected(int name, ref UnityEngine.Vector4 value);
    }

    class Screen
    {
        static /*0x17664e8*/ int get_width();
        static /*0x1766510*/ int get_height();
        static /*0x1766538*/ float get_dpi();
        static /*0x1766560*/ UnityEngine.ScreenOrientation GetScreenOrientation();
        static /*0x1766588*/ UnityEngine.ScreenOrientation get_orientation();
        static /*0x17665b0*/ void set_sleepTimeout(int value);
        static /*0x17665ec*/ bool get_fullScreen();
        static /*0x1766614*/ UnityEngine.Rect get_safeArea();
        static /*0x1766698*/ void SetResolution(int width, int height, UnityEngine.FullScreenMode fullscreenMode, int preferredRefreshRate);
        static /*0x17666f4*/ void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate);
        static /*0x1766758*/ void SetResolution(int width, int height, bool fullscreen);
        static /*0x176665c*/ void get_safeArea_Injected(ref UnityEngine.Rect ret);
    }

    class Shader : UnityEngine.Object
    {
        static /*0x17667b8*/ UnityEngine.Shader Find(string name);
        static /*0x1766860*/ int TagToID(string name);
        static /*0x176689c*/ int PropertyToID(string name);
        /*0x17668d8*/ Shader();
        /*0x1766824*/ bool get_isSupported();
    }

    class Material : UnityEngine.Object
    {
        static /*0x1766930*/ void CreateWithShader(UnityEngine.Material self, UnityEngine.Shader shader);
        static /*0x1766974*/ void CreateWithMaterial(UnityEngine.Material self, UnityEngine.Material source);
        static /*0x17669b8*/ void CreateWithString(UnityEngine.Material self);
        /*0x17669f4*/ Material(UnityEngine.Shader shader);
        /*0x1766a84*/ Material(UnityEngine.Material source);
        /*0x1766b14*/ Material(string contents);
        /*0x1766b94*/ void set_shader(UnityEngine.Shader value);
        /*0x1766bd8*/ UnityEngine.Color get_color();
        /*0x1766cf8*/ void set_color(UnityEngine.Color value);
        /*0x1766e4c*/ UnityEngine.Texture get_mainTexture();
        /*0x1766fb0*/ void set_mainTexture(UnityEngine.Texture value);
        /*0x1766c64*/ int GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags attributeFlag);
        /*0x176714c*/ bool HasProperty(int nameID);
        /*0x1767190*/ bool HasProperty(string name);
        /*0x1767200*/ void set_renderQueue(int value);
        /*0x1767244*/ void EnableKeyword(string keyword);
        /*0x1767288*/ void DisableKeyword(string keyword);
        /*0x17672cc*/ int get_passCount();
        /*0x1767308*/ string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue);
        /*0x1767364*/ string GetTag(string tag, bool searchFallbacks);
        /*0x17673ec*/ bool SetPass(int pass);
        /*0x1767430*/ void CopyPropertiesFromMaterial(UnityEngine.Material mat);
        /*0x1767474*/ string[] GetShaderKeywords();
        /*0x17674b0*/ void SetShaderKeywords(string[] names);
        /*0x17674f4*/ string[] get_shaderKeywords();
        /*0x1767530*/ void set_shaderKeywords(string[] value);
        /*0x1767574*/ int ComputeCRC();
        /*0x17675b0*/ void SetFloatImpl(int name, float value);
        /*0x1767604*/ void SetColorImpl(int name, UnityEngine.Color value);
        /*0x17676b4*/ void SetMatrixImpl(int name, UnityEngine.Matrix4x4 value);
        /*0x176775c*/ void SetTextureImpl(int name, UnityEngine.Texture value);
        /*0x17677b0*/ float GetFloatImpl(int name);
        /*0x17677f4*/ UnityEngine.Color GetColorImpl(int name);
        /*0x17678a8*/ UnityEngine.Texture GetTextureImpl(int name);
        /*0x17678ec*/ void SetTextureOffsetImpl(int name, UnityEngine.Vector2 offset);
        /*0x1767998*/ void SetFloat(string name, float value);
        /*0x1767a18*/ void SetFloat(int nameID, float value);
        /*0x1766dd0*/ void SetColor(string name, UnityEngine.Color value);
        /*0x1766dcc*/ void SetColor(int nameID, UnityEngine.Color value);
        /*0x1767a6c*/ void SetVector(int nameID, UnityEngine.Vector4 value);
        /*0x1767a70*/ void SetMatrix(int nameID, UnityEngine.Matrix4x4 value);
        /*0x17670cc*/ void SetTexture(string name, UnityEngine.Texture value);
        /*0x1767078*/ void SetTexture(int nameID, UnityEngine.Texture value);
        /*0x1767ad4*/ float GetFloat(string name);
        /*0x1767b44*/ float GetFloat(int nameID);
        /*0x1766cac*/ UnityEngine.Color GetColor(string name);
        /*0x1766ca8*/ UnityEngine.Color GetColor(int nameID);
        /*0x1767b88*/ UnityEngine.Vector4 GetVector(int nameID);
        /*0x1766f40*/ UnityEngine.Texture GetTexture(string name);
        /*0x1766efc*/ UnityEngine.Texture GetTexture(int nameID);
        /*0x1767b8c*/ void SetTextureOffset(string name, UnityEngine.Vector2 value);
        /*0x1767660*/ void SetColorImpl_Injected(int name, ref UnityEngine.Color value);
        /*0x1767708*/ void SetMatrixImpl_Injected(int name, ref UnityEngine.Matrix4x4 value);
        /*0x1767854*/ void GetColorImpl_Injected(int name, ref UnityEngine.Color ret);
        /*0x1767944*/ void SetTextureOffsetImpl_Injected(int name, ref UnityEngine.Vector2 offset);
    }

    class BeforeRenderHelper
    {
        static /*0x0*/ System.Collections.Generic.List<UnityEngine.BeforeRenderHelper.OrderBlock> s_OrderBlocks;

        static /*0x1767d8c*/ BeforeRenderHelper();
        static /*0x1767bf0*/ void Invoke();

        struct OrderBlock
        {
            /*0x10*/ int order;
            /*0x18*/ UnityEngine.Events.UnityAction callback;
        }
    }

    enum RenderingPath
    {
        UsePlayerSettings = -1,
        VertexLit = 0,
        Forward = 1,
        DeferredLighting = 2,
        DeferredShading = 3,
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

    enum CameraClearFlags
    {
        Skybox = 1,
        Color = 2,
        SolidColor = 2,
        Depth = 3,
        Nothing = 4,
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

    enum ScreenOrientation
    {
        Unknown = 0,
        Landscape = 3,
        Portrait = 1,
        PortraitUpsideDown = 2,
        LandscapeLeft = 3,
        LandscapeRight = 4,
        AutoRotation = 5,
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

    enum LightmapsMode
    {
        NonDirectional = 0,
        CombinedDirectional = 1,
    }

    class Display
    {
        static /*0x0*/ UnityEngine.Display[] displays;
        static /*0x8*/ UnityEngine.Display _mainDisplay;
        static /*0x10*/ int m_ActiveEditorGameViewTarget;
        static /*0x18*/ UnityEngine.Display.DisplaysUpdatedDelegate onDisplaysUpdated;
        /*0x10*/ nint nativeDisplay;

        static /*0x17684d8*/ Display();
        static /*0x1768174*/ UnityEngine.Vector3 RelativeMouseAt(UnityEngine.Vector3 inputMouseCoordinates);
        static /*0x17682a0*/ UnityEngine.Display get_main();
        static /*0x17682f8*/ void RecreateDisplayList(nint[] nativeDisplay);
        static /*0x1768444*/ void FireDisplaysUpdated();
        static /*0x176808c*/ void GetSystemExtImpl(nint nativeDisplay, ref int w, ref int h);
        static /*0x1767f10*/ void GetRenderingExtImpl(nint nativeDisplay, ref int w, ref int h);
        static /*0x1768244*/ int RelativeMouseAtImpl(int x, int y, ref int rx, ref int ry);
        /*0x1767e18*/ Display();
        /*0x1767e54*/ Display(nint nativeDisplay);
        /*0x1767e7c*/ int get_renderingWidth();
        /*0x1767f64*/ int get_renderingHeight();
        /*0x1767ff8*/ int get_systemWidth();
        /*0x17680e0*/ int get_systemHeight();

        class DisplaysUpdatedDelegate : System.MulticastDelegate
        {
            /*0x17685e8*/ DisplaysUpdatedDelegate(object object, nint method);
            /*0x17686a4*/ void Invoke();
        }
    }

    enum FullScreenMode
    {
        ExclusiveFullScreen = 0,
        FullScreenWindow = 1,
        MaximizedWindow = 2,
        Windowed = 3,
    }

    class GL
    {
        static /*0x17686b8*/ void Vertex3(float x, float y, float z);
        static /*0x1768708*/ void TexCoord3(float x, float y, float z);
        static /*0x1768758*/ void TexCoord2(float x, float y);
        static /*0x176879c*/ void ImmediateColor(float r, float g, float b, float a);
        static /*0x17687f4*/ void Color(UnityEngine.Color c);
        static /*0x176884c*/ void SetViewMatrix(UnityEngine.Matrix4x4 m);
        static /*0x17688c4*/ void set_modelview(UnityEngine.Matrix4x4 value);
        static /*0x1768910*/ void PushMatrix();
        static /*0x1768938*/ void PopMatrix();
        static /*0x1768960*/ void LoadOrtho();
        static /*0x1768988*/ void LoadProjectionMatrix(UnityEngine.Matrix4x4 mat);
        static /*0x1768a00*/ void GLLoadPixelMatrixScript(float left, float right, float bottom, float top);
        static /*0x1768a58*/ void LoadPixelMatrix(float left, float right, float bottom, float top);
        static /*0x1768ab0*/ void Begin(int mode);
        static /*0x1768aec*/ void End();
        static /*0x1768b14*/ void GLClear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
        static /*0x1768be4*/ void Clear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor, float depth);
        static /*0x1768bf0*/ void Viewport(UnityEngine.Rect pixelRect);
        static /*0x1768888*/ void SetViewMatrix_Injected(ref UnityEngine.Matrix4x4 m);
        static /*0x17689c4*/ void LoadProjectionMatrix_Injected(ref UnityEngine.Matrix4x4 mat);
        static /*0x1768b80*/ void GLClear_Injected(bool clearDepth, bool clearColor, ref UnityEngine.Color backgroundColor, float depth);
        static /*0x1768c34*/ void Viewport_Injected(ref UnityEngine.Rect pixelRect);
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
        static /*0x1768c70*/ float get_batteryLevel();
        static /*0x1768cc0*/ string get_operatingSystem();
        static /*0x1768d10*/ UnityEngine.OperatingSystemFamily get_operatingSystemFamily();
        static /*0x1768d60*/ string get_processorType();
        static /*0x1768db0*/ int get_processorCount();
        static /*0x1768e00*/ int get_systemMemorySize();
        static /*0x1768e50*/ string get_deviceUniqueIdentifier();
        static /*0x1768ea0*/ string get_deviceName();
        static /*0x1768ef0*/ string get_deviceModel();
        static /*0x1768f40*/ UnityEngine.DeviceType get_deviceType();
        static /*0x1768f90*/ string get_graphicsDeviceName();
        static /*0x1768fe0*/ UnityEngine.Rendering.GraphicsDeviceType get_graphicsDeviceType();
        static /*0x1769030*/ bool IsValidEnumValue(System.Enum value);
        static /*0x1760214*/ bool SupportsTextureFormat(UnityEngine.TextureFormat format);
        static /*0x17690e4*/ int get_maxTextureSize();
        static /*0x1769134*/ int get_maxRenderTextureSize();
        static /*0x1768c98*/ float GetBatteryLevel();
        static /*0x1768ce8*/ string GetOperatingSystem();
        static /*0x1768d38*/ UnityEngine.OperatingSystemFamily GetOperatingSystemFamily();
        static /*0x1768d88*/ string GetProcessorType();
        static /*0x1768dd8*/ int GetProcessorCount();
        static /*0x1768e28*/ int GetPhysicalMemoryMB();
        static /*0x1768e78*/ string GetDeviceUniqueIdentifier();
        static /*0x1768ec8*/ string GetDeviceName();
        static /*0x1768f18*/ string GetDeviceModel();
        static /*0x1768f68*/ UnityEngine.DeviceType GetDeviceType();
        static /*0x1768fb8*/ string GetGraphicsDeviceName();
        static /*0x1769008*/ UnityEngine.Rendering.GraphicsDeviceType GetGraphicsDeviceType();
        static /*0x17690a8*/ bool SupportsTextureFormatNative(UnityEngine.TextureFormat format);
        static /*0x176910c*/ int GetMaxTextureSize();
        static /*0x176915c*/ int GetMaxRenderTextureSize();
        static /*0x17604b8*/ bool IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage);
        static /*0x1764fb0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage);
        static /*0x1761ccc*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat format);
    }

    class Random
    {
        static /*0x1769184*/ float Range(float minInclusive, float maxInclusive);
        static /*0x17691c4*/ int Range(int minInclusive, int maxExclusive);
        static /*0x1769208*/ int RandomRangeInt(int minInclusive, int maxExclusive);
        static /*0x176924c*/ float get_value();
        static /*0x1769274*/ UnityEngine.Vector3 get_insideUnitSphere();
        static /*0x17692fc*/ void GetRandomUnitCircle(ref UnityEngine.Vector2 output);
        static /*0x1769338*/ UnityEngine.Vector2 get_insideUnitCircle();
        static /*0x17692c0*/ void get_insideUnitSphere_Injected(ref UnityEngine.Vector3 ret);
    }

    interface IPlayerEditorConnectionNative
    {
        void Initialize();
        void DisconnectAll();
        void SendMessage(System.Guid messageId, byte[] data, int playerId);
        bool TrySendMessage(System.Guid messageId, byte[] data, int playerId);
        void Poll();
        void RegisterInternal(System.Guid messageId);
        void UnregisterInternal(System.Guid messageId);
        bool IsConnected();
    }

    class PlayerConnectionInternal : UnityEngine.IPlayerEditorConnectionNative
    {
        static /*0x17698c8*/ bool IsConnected();
        static /*0x1769878*/ void Initialize();
        static /*0x1769754*/ void RegisterInternal(string messageId);
        static /*0x1769814*/ void UnregisterInternal(string messageId);
        static /*0x17694a8*/ void SendMessage(string messageId, byte[] data, int playerId);
        static /*0x176962c*/ bool TrySendMessage(string messageId, byte[] data, int playerId);
        static /*0x17696a8*/ void PollInternal();
        static /*0x1769918*/ void DisconnectAll();
        /*0x1769940*/ PlayerConnectionInternal();
        /*0x176937c*/ void UnityEngine.IPlayerEditorConnectionNative.SendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x17694fc*/ bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x1769680*/ void UnityEngine.IPlayerEditorConnectionNative.Poll();
        /*0x17696d0*/ void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(System.Guid messageId);
        /*0x1769790*/ void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(System.Guid messageId);
        /*0x1769850*/ void UnityEngine.IPlayerEditorConnectionNative.Initialize();
        /*0x17698a0*/ bool UnityEngine.IPlayerEditorConnectionNative.IsConnected();
        /*0x17698f0*/ void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll();
    }

    class FlareLayer : UnityEngine.Behaviour
    {
    }

    struct CullingGroupEvent
    {
        /*0x10*/ int m_Index;
        /*0x14*/ byte m_PrevState;
        /*0x15*/ byte m_ThisState;
    }

    class CullingGroup
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.CullingGroup.StateChanged m_OnStateChanged;

        static /*0x1769948*/ void SendEvents(UnityEngine.CullingGroup cullingGroup, nint eventsPtr, int count);

        class StateChanged : System.MulticastDelegate
        {
            /*0x17699a4*/ StateChanged(object object, nint method);
            /*0x1769a68*/ void Invoke(UnityEngine.CullingGroupEvent sphere);
        }
    }

    class ReflectionProbe : UnityEngine.Behaviour
    {
        static /*0x0*/ System.Action<UnityEngine.ReflectionProbe, UnityEngine.ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged;
        static /*0x8*/ System.Action<UnityEngine.Texture> defaultReflectionTexture;

        static /*0x1769a7c*/ void CallReflectionProbeEvent(UnityEngine.ReflectionProbe probe, UnityEngine.ReflectionProbe.ReflectionProbeEvent probeEvent);
        static /*0x1769afc*/ void CallSetDefaultReflection(UnityEngine.Texture defaultReflectionCubemap);

        enum ReflectionProbeEvent
        {
            ReflectionProbeAdded = 0,
            ReflectionProbeRemoved = 1,
        }
    }

    class Camera : UnityEngine.Behaviour
    {
        static /*0x0*/ UnityEngine.Camera.CameraCallback onPreCull;
        static /*0x8*/ UnityEngine.Camera.CameraCallback onPreRender;
        static /*0x10*/ UnityEngine.Camera.CameraCallback onPostRender;

        static /*0x176a710*/ UnityEngine.Camera get_main();
        static /*0x176a738*/ UnityEngine.Camera get_current();
        static /*0x176a760*/ int GetAllCamerasCount();
        static /*0x176a788*/ int GetAllCamerasImpl(UnityEngine.Camera[] cam);
        static /*0x176a7c4*/ int get_allCamerasCount();
        static /*0x176a7ec*/ int GetAllCameras(UnityEngine.Camera[] cameras);
        static /*0x176a9a8*/ void FireOnPreCull(UnityEngine.Camera cam);
        static /*0x176aa14*/ void FireOnPreRender(UnityEngine.Camera cam);
        static /*0x176aa80*/ void FireOnPostRender(UnityEngine.Camera cam);
        /*0x1769b68*/ Camera();
        /*0x1769b70*/ float get_nearClipPlane();
        /*0x1769bac*/ void set_nearClipPlane(float value);
        /*0x1769bf8*/ float get_farClipPlane();
        /*0x1769c34*/ void set_farClipPlane(float value);
        /*0x1769c80*/ void set_renderingPath(UnityEngine.RenderingPath value);
        /*0x1769cc4*/ void set_allowHDR(bool value);
        /*0x1769d08*/ void set_orthographicSize(float value);
        /*0x1769d54*/ void set_orthographic(bool value);
        /*0x1769d98*/ float get_depth();
        /*0x1769dd4*/ void set_depth(float value);
        /*0x1769e20*/ int get_cullingMask();
        /*0x1769e5c*/ int get_eventMask();
        /*0x1769e98*/ void set_useOcclusionCulling(bool value);
        /*0x1769edc*/ UnityEngine.Color get_backgroundColor();
        /*0x1769f78*/ void set_backgroundColor(UnityEngine.Color value);
        /*0x176a010*/ UnityEngine.CameraClearFlags get_clearFlags();
        /*0x176a04c*/ void set_clearFlags(UnityEngine.CameraClearFlags value);
        /*0x176a090*/ void set_rect(UnityEngine.Rect value);
        /*0x176a128*/ UnityEngine.Rect get_pixelRect();
        /*0x176a1c4*/ UnityEngine.RenderTexture get_targetTexture();
        /*0x176a200*/ void set_targetTexture(UnityEngine.RenderTexture value);
        /*0x176a244*/ int get_targetDisplay();
        /*0x176a280*/ UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x176a34c*/ UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x176a418*/ UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x176a4e4*/ UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position);
        /*0x176a4ec*/ UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position);
        /*0x176a4f4*/ UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position);
        /*0x176a4fc*/ UnityEngine.Vector3 ScreenToViewportPoint(UnityEngine.Vector3 position);
        /*0x176a5b8*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x176a68c*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x176a6c4*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos);
        /*0x176a8d0*/ bool RenderToCubemapImpl(UnityEngine.Texture tex, int faceMask);
        /*0x176a924*/ bool RenderToCubemap(UnityEngine.Cubemap cubemap);
        /*0x176a96c*/ void Render();
        /*0x1769f34*/ void get_backgroundColor_Injected(ref UnityEngine.Color ret);
        /*0x1769fcc*/ void set_backgroundColor_Injected(ref UnityEngine.Color value);
        /*0x176a0e4*/ void set_rect_Injected(ref UnityEngine.Rect value);
        /*0x176a180*/ void get_pixelRect_Injected(ref UnityEngine.Rect ret);
        /*0x176a2f0*/ void WorldToScreenPoint_Injected(ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        /*0x176a3bc*/ void WorldToViewportPoint_Injected(ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        /*0x176a488*/ void ScreenToWorldPoint_Injected(ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        /*0x176a564*/ void ScreenToViewportPoint_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        /*0x176a630*/ void ScreenPointToRay_Injected(ref UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Ray ret);

        enum MonoOrStereoscopicEye
        {
            Left = 0,
            Right = 1,
            Mono = 2,
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
            /*0x176aaec*/ CameraCallback(object object, nint method);
            /*0x176abc0*/ void Invoke(UnityEngine.Camera cam);
        }
    }

    class LightingSettings : UnityEngine.Object
    {
        /*0x176abd4*/ void LightingSettingsDontStripMe();
    }

    struct PropertyName : System.IEquatable<UnityEngine.PropertyName>
    {
        /*0x10*/ int id;

        static /*0x176ac88*/ bool IsNullOrEmpty(UnityEngine.PropertyName prop);
        static /*0x176ac94*/ bool op_Equality(UnityEngine.PropertyName lhs, UnityEngine.PropertyName rhs);
        static /*0x176ad30*/ UnityEngine.PropertyName op_Implicit(string name);
        /*0x176abd8*/ PropertyName(string name);
        /*0x176ac80*/ PropertyName(UnityEngine.PropertyName other);
        /*0x176aca0*/ int GetHashCode();
        /*0x176aca8*/ bool Equals(object other);
        /*0x176ad20*/ bool Equals(UnityEngine.PropertyName other);
        /*0x176ad7c*/ string ToString();
    }

    class PropertyNameUtils
    {
        static /*0x176ac34*/ UnityEngine.PropertyName PropertyNameFromString(string name);
        static /*0x176ae00*/ void PropertyNameFromString_Injected(string name, ref UnityEngine.PropertyName ret);
    }

    class RectOffset : System.IFormattable
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ object m_SourceStyle;

        static /*0x176ae8c*/ nint InternalCreate();
        static /*0x176b5dc*/ void InternalDestroy(nint ptr);
        /*0x176ae44*/ RectOffset();
        /*0x176aeb4*/ RectOffset(object sourceStyle, nint source);
        /*0x176b020*/ RectOffset(int left, int right, int top, int bottom);
        /*0x176aee0*/ void Finalize();
        /*0x176b244*/ string ToString();
        /*0x176b250*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x176af80*/ void Destroy();
        /*0x176b4ec*/ int get_left();
        /*0x176b134*/ void set_left(int value);
        /*0x176b528*/ int get_right();
        /*0x176b178*/ void set_right(int value);
        /*0x176b564*/ int get_top();
        /*0x176b1bc*/ void set_top(int value);
        /*0x176b5a0*/ int get_bottom();
        /*0x176b200*/ void set_bottom(int value);
        /*0x176b618*/ int get_horizontal();
        /*0x176b654*/ int get_vertical();
        /*0x176b690*/ UnityEngine.Rect Remove(UnityEngine.Rect rect);
        /*0x176b6f4*/ void Remove_Injected(ref UnityEngine.Rect rect, ref UnityEngine.Rect ret);
    }

    struct RectInt : System.IEquatable<UnityEngine.RectInt>, System.IFormattable
    {
        /*0x10*/ int m_XMin;
        /*0x14*/ int m_YMin;
        /*0x18*/ int m_Width;
        /*0x1c*/ int m_Height;

        /*0x176b918*/ RectInt(int xMin, int yMin, int width, int height);
        /*0x176b748*/ int get_x();
        /*0x176b750*/ void set_x(int value);
        /*0x176b758*/ int get_y();
        /*0x176b760*/ void set_y(int value);
        /*0x176b768*/ int get_width();
        /*0x176b770*/ void set_width(int value);
        /*0x176b778*/ int get_height();
        /*0x176b780*/ void set_height(int value);
        /*0x176b788*/ int get_xMin();
        /*0x176b7ec*/ int get_yMin();
        /*0x176b850*/ int get_xMax();
        /*0x176b8b4*/ int get_yMax();
        /*0x176b924*/ bool Overlaps(UnityEngine.RectInt other);
        /*0x176b9c0*/ string ToString();
        /*0x176b9cc*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x176bbd8*/ bool Equals(UnityEngine.RectInt other);
    }

    struct Plane : System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3 m_Normal;
        /*0x1c*/ float m_Distance;

        /*0x176bc28*/ Plane(UnityEngine.Vector3 inNormal, UnityEngine.Vector3 inPoint);
        /*0x176bc1c*/ UnityEngine.Vector3 get_normal();
        /*0x176bd38*/ bool Raycast(UnityEngine.Ray ray, ref float enter);
        /*0x176be50*/ string ToString();
        /*0x176be5c*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Bounds : System.IEquatable<UnityEngine.Bounds>, System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3 m_Center;
        /*0x1c*/ UnityEngine.Vector3 m_Extents;

        static /*0x176c2b4*/ bool op_Equality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs);
        static /*0x176c330*/ bool op_Inequality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs);
        /*0x176bfe4*/ Bounds(UnityEngine.Vector3 center, UnityEngine.Vector3 size);
        /*0x176c004*/ int GetHashCode();
        /*0x176c0ec*/ bool Equals(object other);
        /*0x176c1bc*/ bool Equals(UnityEngine.Bounds other);
        /*0x176c0d4*/ UnityEngine.Vector3 get_center();
        /*0x176c228*/ void set_center(UnityEngine.Vector3 value);
        /*0x176c234*/ UnityEngine.Vector3 get_size();
        /*0x176c24c*/ void set_size(UnityEngine.Vector3 value);
        /*0x176c0e0*/ UnityEngine.Vector3 get_extents();
        /*0x176c268*/ void set_extents(UnityEngine.Vector3 value);
        /*0x176c274*/ UnityEngine.Vector3 get_min();
        /*0x176c294*/ UnityEngine.Vector3 get_max();
        /*0x176c378*/ void SetMinMax(UnityEngine.Vector3 min, UnityEngine.Vector3 max);
        /*0x176c3b0*/ void Encapsulate(UnityEngine.Vector3 point);
        /*0x176c428*/ string ToString();
        /*0x176c434*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Rect : System.IEquatable<UnityEngine.Rect>, System.IFormattable
    {
        /*0x10*/ float m_XMin;
        /*0x14*/ float m_YMin;
        /*0x18*/ float m_Width;
        /*0x1c*/ float m_Height;

        static /*0x176c5e0*/ UnityEngine.Rect get_zero();
        static /*0x176c5f4*/ UnityEngine.Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax);
        static /*0x176c7ec*/ UnityEngine.Rect OrderMinMax(UnityEngine.Rect rect);
        static /*0x176c8f8*/ bool op_Inequality(UnityEngine.Rect lhs, UnityEngine.Rect rhs);
        static /*0x176c92c*/ bool op_Equality(UnityEngine.Rect lhs, UnityEngine.Rect rhs);
        /*0x176c5bc*/ Rect(float x, float y, float width, float height);
        /*0x176c5c8*/ Rect(UnityEngine.Vector2 position, UnityEngine.Vector2 size);
        /*0x176c5d4*/ Rect(UnityEngine.Rect source);
        /*0x176c600*/ float get_x();
        /*0x176c608*/ void set_x(float value);
        /*0x176c610*/ float get_y();
        /*0x176c618*/ void set_y(float value);
        /*0x176c620*/ UnityEngine.Vector2 get_position();
        /*0x176c628*/ void set_position(UnityEngine.Vector2 value);
        /*0x176c630*/ UnityEngine.Vector2 get_center();
        /*0x176c648*/ void set_center(UnityEngine.Vector2 value);
        /*0x176c664*/ UnityEngine.Vector2 get_min();
        /*0x176c67c*/ void set_min(UnityEngine.Vector2 value);
        /*0x176c6d0*/ UnityEngine.Vector2 get_max();
        /*0x176c700*/ void set_max(UnityEngine.Vector2 value);
        /*0x176c734*/ float get_width();
        /*0x176c73c*/ void set_width(float value);
        /*0x176c744*/ float get_height();
        /*0x176c74c*/ void set_height(float value);
        /*0x176c754*/ UnityEngine.Vector2 get_size();
        /*0x176c75c*/ void set_size(UnityEngine.Vector2 value);
        /*0x176c66c*/ float get_xMin();
        /*0x176c698*/ void set_xMin(float value);
        /*0x176c674*/ float get_yMin();
        /*0x176c6b4*/ void set_yMin(float value);
        /*0x176c6e0*/ float get_xMax();
        /*0x176c714*/ void set_xMax(float value);
        /*0x176c6f0*/ float get_yMax();
        /*0x176c724*/ void set_yMax(float value);
        /*0x176c764*/ bool Contains(UnityEngine.Vector2 point);
        /*0x176c7a8*/ bool Contains(UnityEngine.Vector3 point);
        /*0x176c818*/ bool Overlaps(UnityEngine.Rect other);
        /*0x176c864*/ bool Overlaps(UnityEngine.Rect other, bool allowInverse);
        /*0x176c960*/ int GetHashCode();
        /*0x176c9e8*/ bool Equals(object other);
        /*0x176ca64*/ bool Equals(UnityEngine.Rect other);
        /*0x176cb04*/ string ToString();
        /*0x176cb10*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Ray : System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3 m_Origin;
        /*0x1c*/ UnityEngine.Vector3 m_Direction;

        /*0x176cd48*/ Ray(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        /*0x176be44*/ UnityEngine.Vector3 get_origin();
        /*0x176be38*/ UnityEngine.Vector3 get_direction();
        /*0x176ce34*/ UnityEngine.Vector3 GetPoint(float distance);
        /*0x176ce5c*/ string ToString();
        /*0x176ce68*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    class PropertyAttribute : System.Attribute
    {
        /*0x176cff0*/ PropertyAttribute();
    }

    class TooltipAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ string tooltip;

        /*0x176cff8*/ TooltipAttribute(string tooltip);
    }

    class SpaceAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ float height;

        /*0x176d020*/ SpaceAttribute();
        /*0x176d040*/ SpaceAttribute(float height);
    }

    class HeaderAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ string header;

        /*0x176d068*/ HeaderAttribute(string header);
    }

    class RangeAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ float min;
        /*0x14*/ float max;

        /*0x176d090*/ RangeAttribute(float min, float max);
    }

    class MultilineAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ int lines;

        /*0x176d0bc*/ MultilineAttribute();
    }

    class TextAreaAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ int minLines;
        /*0x14*/ int maxLines;

        /*0x176d0dc*/ TextAreaAttribute(int minLines, int maxLines);
    }

    class Time
    {
        static /*0x176d108*/ float get_time();
        static /*0x176d130*/ float get_deltaTime();
        static /*0x176d158*/ float get_unscaledTime();
        static /*0x176d180*/ float get_unscaledDeltaTime();
        static /*0x176d1a8*/ void set_timeScale(float value);
        static /*0x176d1e0*/ float get_realtimeSinceStartup();
    }

    class SystemClock
    {
        static /*0x0*/ System.DateTime s_Epoch;

        static /*0x176d258*/ SystemClock();
        static /*0x176d208*/ System.DateTime get_now();
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

        static /*0x176d2d4*/ void Internal_Destroy(nint ptr);
        static /*0x176d5cc*/ nint TouchScreenKeyboard_InternalConstructorHelper(ref UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder);
        static /*0x176d620*/ bool get_isSupported();
        static /*0x176d678*/ bool get_disableInPlaceEditing();
        static /*0x176d6c0*/ bool get_isInPlaceEditingAllowed();
        static /*0x176d72c*/ bool IsInPlaceEditingAllowed();
        static /*0x176d754*/ bool get_isRequiredToForceOpen();
        static /*0x176d77c*/ bool IsRequiredToForceOpen();
        static /*0x176d7a4*/ UnityEngine.TouchScreenKeyboard Open(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit);
        static /*0x176d864*/ UnityEngine.TouchScreenKeyboard Open(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure);
        static /*0x176d970*/ void set_hideInput(bool value);
        static /*0x176db74*/ void GetSelection(ref int start, ref int length);
        static /*0x176dcb0*/ void SetSelection(int start, int length);
        /*0x176d470*/ TouchScreenKeyboard(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit);
        /*0x176d310*/ void Destroy();
        /*0x176d3dc*/ void Finalize();
        /*0x176d8f0*/ string get_text();
        /*0x176d92c*/ void set_text(string value);
        /*0x176d9ac*/ bool get_active();
        /*0x176d9e8*/ void set_active(bool value);
        /*0x176da2c*/ UnityEngine.TouchScreenKeyboard.Status get_status();
        /*0x176da68*/ void set_characterLimit(int value);
        /*0x176daac*/ bool get_canGetSelection();
        /*0x176dae8*/ bool get_canSetSelection();
        /*0x176db24*/ UnityEngine.RangeInt get_selection();
        /*0x176dbb8*/ void set_selection(UnityEngine.RangeInt value);

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

    class Handheld
    {
        static /*0x176dcf4*/ void Vibrate();
    }

    class BootConfigData
    {
        /*0x10*/ nint m_Ptr;

        static /*0x176dd1c*/ UnityEngine.BootConfigData WrapBootConfigData(nint nativeHandle);
        /*0x176dd7c*/ BootConfigData(nint nativeHandle);
    }

    class Behaviour : UnityEngine.Component
    {
        /*0x1769b6c*/ Behaviour();
        /*0x176de40*/ bool get_enabled();
        /*0x176de7c*/ void set_enabled(bool value);
        /*0x176dec0*/ bool get_isActiveAndEnabled();
    }

    class ClassLibraryInitializer
    {
        static /*0x176df54*/ void Init();
    }

    class WaitForEndOfFrame : UnityEngine.YieldInstruction
    {
        /*0x176df58*/ WaitForEndOfFrame();
    }

    class SelectionBaseAttribute : System.Attribute
    {
        /*0x176df68*/ SelectionBaseAttribute();
    }

    class YieldInstruction
    {
        /*0x176df60*/ YieldInstruction();
    }

    class WaitForSeconds : UnityEngine.YieldInstruction
    {
        /*0x10*/ float m_Seconds;

        /*0x176df70*/ WaitForSeconds(float seconds);
    }

    class AttributeHelperEngine
    {
        static /*0x0*/ UnityEngine.DisallowMultipleComponent[] _disallowMultipleComponentArray;
        static /*0x8*/ UnityEngine.ExecuteInEditMode[] _executeInEditModeArray;
        static /*0x10*/ UnityEngine.RequireComponent[] _requireComponentArray;

        static /*0x176e748*/ AttributeHelperEngine();
        static /*0x176df98*/ System.Type GetParentTypeDisallowingMultipleInclusion(System.Type type);
        static /*0x176e098*/ System.Type[] GetRequiredComponents(System.Type klass);
        static /*0x176e4d4*/ int GetExecuteMode(System.Type klass);
        static /*0x176e5e8*/ int CheckIsEditorScript(System.Type klass);
        static /*0x176e6c8*/ int GetDefaultExecutionOrderFor(System.Type klass);
        static T GetCustomAttributeOfType<T>(System.Type klass);
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

        /*0x176e810*/ RuntimeInitializeOnLoadMethodAttribute();
        /*0x176e834*/ RuntimeInitializeOnLoadMethodAttribute(UnityEngine.RuntimeInitializeLoadType loadType);
        /*0x176e82c*/ void set_loadType(UnityEngine.RuntimeInitializeLoadType value);
    }

    class GameObject : UnityEngine.Object
    {
        static /*0x176e85c*/ UnityEngine.GameObject CreatePrimitive(UnityEngine.PrimitiveType type);
        static /*0x176ecb0*/ UnityEngine.GameObject FindGameObjectWithTag(string tag);
        static /*0x176edd8*/ void Internal_CreateGameObject(UnityEngine.GameObject self, string name);
        static /*0x176efb0*/ UnityEngine.GameObject Find(string name);
        /*0x176ed48*/ GameObject(string name);
        /*0x176ee1c*/ GameObject();
        /*0x176eea0*/ GameObject(string name, System.Type[] components);
        T GetComponent<T>();
        /*0x176e898*/ UnityEngine.Component GetComponent(System.Type type);
        /*0x176e8dc*/ void GetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x176e930*/ UnityEngine.Component GetComponentInChildren(System.Type type, bool includeInactive);
        T GetComponentInChildren<T>();
        T GetComponentInChildren<T>(bool includeInactive);
        /*0x176e984*/ UnityEngine.Component GetComponentInParent(System.Type type, bool includeInactive);
        T GetComponentInParent<T>();
        T GetComponentInParent<T>(bool includeInactive);
        /*0x176e9d8*/ System.Array GetComponentsInternal(System.Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList);
        T[] GetComponents<T>();
        void GetComponents<T>(System.Collections.Generic.List<T> results);
        T[] GetComponentsInChildren<T>(bool includeInactive);
        void GetComponentsInChildren<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        T[] GetComponentsInChildren<T>();
        void GetComponentsInParent<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        T[] GetComponentsInParent<T>(bool includeInactive);
        bool TryGetComponent<T>(ref T component);
        /*0x176ea5c*/ void TryGetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x176eab0*/ UnityEngine.Component Internal_AddComponentWithType(System.Type componentType);
        /*0x176eaf4*/ UnityEngine.Component AddComponent(System.Type componentType);
        T AddComponent<T>();
        /*0x176eb38*/ UnityEngine.Transform get_transform();
        /*0x176eb74*/ int get_layer();
        /*0x176ebb0*/ void set_layer(int value);
        /*0x176ebf4*/ void SetActive(bool value);
        /*0x176ec38*/ bool get_activeSelf();
        /*0x176ec74*/ bool get_activeInHierarchy();
        /*0x176ecec*/ void SendMessage(string methodName, object value, UnityEngine.SendMessageOptions options);
        /*0x176efec*/ UnityEngine.GameObject get_gameObject();
    }

    struct RangeInt
    {
        /*0x10*/ int start;
        /*0x14*/ int length;

        /*0x176effc*/ RangeInt(int start, int length);
        /*0x176eff0*/ int get_end();
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

        static /*0x176fe24*/ Object();
        static /*0x1765644*/ bool op_Implicit(UnityEngine.Object exists);
        static /*0x176f264*/ bool CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs);
        static /*0x176f304*/ bool IsNativeObjectAlive(UnityEngine.Object o);
        static /*0x176f46c*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x176f710*/ UnityEngine.Object Instantiate(UnityEngine.Object original);
        static T Instantiate<T>(T original);
        static T Instantiate<T>(T original, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        static /*0x176f840*/ void Destroy(UnityEngine.Object obj, float t);
        static /*0x176f88c*/ void Destroy(UnityEngine.Object obj);
        static /*0x176f904*/ void DestroyImmediate(UnityEngine.Object obj, bool allowDestroyingAssets);
        static /*0x176f948*/ void DestroyImmediate(UnityEngine.Object obj);
        static /*0x176f9c0*/ UnityEngine.Object[] FindObjectsOfType(System.Type type);
        static /*0x176fa38*/ UnityEngine.Object[] FindObjectsOfType(System.Type type, bool includeInactive);
        static /*0x176fa7c*/ void DontDestroyOnLoad(UnityEngine.Object target);
        static T[] FindObjectsOfType<T>();
        static T FindObjectOfType<T>();
        static /*0x176f624*/ void CheckNullArgument(object arg, string message);
        static /*0x176fb38*/ UnityEngine.Object FindObjectOfType(System.Type type);
        static /*0x176fbd0*/ UnityEngine.Object FindObjectOfType(System.Type type, bool includeInactive);
        static /*0x1764360*/ bool op_Equality(UnityEngine.Object x, UnityEngine.Object y);
        static /*0x176fd24*/ bool op_Inequality(UnityEngine.Object x, UnityEngine.Object y);
        static /*0x176f138*/ int GetOffsetOfInstanceIDInCPlusPlusObject();
        static /*0x176f804*/ UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data);
        static /*0x176f678*/ UnityEngine.Object Internal_InstantiateSingle(UnityEngine.Object data, UnityEngine.Vector3 pos, UnityEngine.Quaternion rot);
        static /*0x176fce8*/ string ToString(UnityEngine.Object obj);
        static /*0x176f368*/ string GetName(UnityEngine.Object obj);
        static /*0x176f428*/ void SetName(UnityEngine.Object obj, string name);
        static /*0x176fde8*/ UnityEngine.Object FindObjectFromInstanceID(int instanceID);
        static /*0x176fd94*/ UnityEngine.Object Internal_InstantiateSingle_Injected(UnityEngine.Object data, ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion rot);
        /*0x175e0b4*/ Object();
        /*0x176f004*/ int GetInstanceID();
        /*0x176f160*/ int GetHashCode();
        /*0x176f168*/ bool Equals(object other);
        /*0x176f360*/ nint GetCachedPtr();
        /*0x175f358*/ string get_name();
        /*0x176f3a4*/ void set_name(string value);
        /*0x176fab8*/ UnityEngine.HideFlags get_hideFlags();
        /*0x176faf4*/ void set_hideFlags(UnityEngine.HideFlags value);
        /*0x176fc74*/ string ToString();
    }

    class AsyncOperation : UnityEngine.YieldInstruction
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ System.Action<UnityEngine.AsyncOperation> m_completeCallback;

        static /*0x176ff2c*/ void InternalDestroy(nint ptr);
        /*0x1770178*/ AsyncOperation();
        /*0x176fe70*/ void Finalize();
        /*0x176ff68*/ void InvokeCompletionEvent();
        /*0x176ff98*/ void add_completed(System.Action<UnityEngine.AsyncOperation> value);
        /*0x17700d0*/ void remove_completed(System.Action<UnityEngine.AsyncOperation> value);
        /*0x1770094*/ bool get_isDone();
    }

    class ScriptingRuntime
    {
        static /*0x1770180*/ string[] GetAllUserAssemblies();
    }

    class SetupCoroutine
    {
        static /*0x17701a8*/ void InvokeMoveNext(System.Collections.IEnumerator enumerator, nint returnValueAddress);
        static /*0x17702fc*/ object InvokeMember(object behaviour, string name, object variable);
    }

    struct LayerMask
    {
        /*0x10*/ int m_Mask;

        static /*0x17703f0*/ int op_Implicit(UnityEngine.LayerMask mask);
        static /*0x17703f4*/ UnityEngine.LayerMask op_Implicit(int intVal);
        static /*0x17703fc*/ int NameToLayer(string layerName);
        static /*0x1770438*/ int GetMask(string[] layerNames);
    }

    struct CastHelper<T>
    {
        /*0x0*/ T t;
        /*0x0*/ nint onePointerFurtherThanT;
    }

    class TextAsset : UnityEngine.Object
    {
        static /*0x17705bc*/ string DecodeString(byte[] bytes);
        /*0x1770540*/ byte[] get_bytes();
        /*0x177057c*/ string get_text();
        /*0x1770840*/ string ToString();

        class EncodingUtility
        {
            static /*0x0*/ System.Collections.Generic.KeyValuePair<System.Byte[], System.Text.Encoding> encodingLookup;
            static /*0x8*/ System.Text.Encoding targetEncoding;

            static /*0x1770844*/ EncodingUtility();
        }
    }

    class TrackedReference
    {
        /*0x10*/ nint m_Ptr;
    }

    class ScriptableObject : UnityEngine.Object
    {
        static /*0x1770c78*/ UnityEngine.ScriptableObject CreateInstance(System.Type type);
        static T CreateInstance<T>();
        static /*0x1770c3c*/ void CreateScriptableObject(UnityEngine.ScriptableObject self);
        static /*0x1770cb8*/ UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromType(System.Type type, bool applyDefaultsAndReset);
        /*0x1770bbc*/ ScriptableObject();
    }

    class StackTraceUtility
    {
        static /*0x0*/ string projectFolder;

        static /*0x1771970*/ StackTraceUtility();
        static /*0x1770cfc*/ void SetProjectFolder(string folder);
        static /*0x1770dd8*/ string ExtractStackTrace();
        static /*0x1771608*/ void ExtractStringFromExceptionInternal(object exceptiono, ref string message, ref string stackTrace);
        static /*0x1770f60*/ string ExtractFormattedStackTrace(System.Diagnostics.StackTrace stackTrace);
    }

    class UnityException : System.Exception
    {
        /*0x17719d0*/ UnityException();
        /*0x1760598*/ UnityException(string message);
        /*0x1771a50*/ UnityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    }

    class DisallowMultipleComponent : System.Attribute
    {
        /*0x1771ad0*/ DisallowMultipleComponent();
    }

    class RequireComponent : System.Attribute
    {
        /*0x10*/ System.Type m_Type0;
        /*0x18*/ System.Type m_Type1;
        /*0x20*/ System.Type m_Type2;

        /*0x1771ad8*/ RequireComponent(System.Type requiredComponent);
    }

    class AddComponentMenu : System.Attribute
    {
        /*0x10*/ string m_AddComponentMenu;
        /*0x18*/ int m_Ordering;

        /*0x1771b00*/ AddComponentMenu(string menuName);
        /*0x1771b2c*/ AddComponentMenu(string menuName, int order);
    }

    class ContextMenu : System.Attribute
    {
        /*0x10*/ string menuItem;
        /*0x18*/ bool validate;
        /*0x1c*/ int priority;

        /*0x1771b5c*/ ContextMenu(string itemName);
        /*0x1771b94*/ ContextMenu(string itemName, bool isValidateFunction);
        /*0x1771bd0*/ ContextMenu(string itemName, bool isValidateFunction, int priority);
    }

    class ExecuteInEditMode : System.Attribute
    {
        /*0x1771c10*/ ExecuteInEditMode();
    }

    class ExecuteAlways : System.Attribute
    {
        /*0x1771c18*/ ExecuteAlways();
    }

    class HideInInspector : System.Attribute
    {
        /*0x1771c20*/ HideInInspector();
    }

    class HelpURLAttribute : System.Attribute
    {
        /*0x10*/ string m_Url;
        /*0x18*/ bool m_Dispatcher;
        /*0x20*/ string m_DispatchingFieldName;

        /*0x1771c28*/ HelpURLAttribute(string url);
    }

    class DefaultExecutionOrder : System.Attribute
    {
        /*0x10*/ int m_Order;

        /*0x1771c90*/ DefaultExecutionOrder(int order);
        /*0x176e740*/ int get_order();
    }

    class AssemblyIsEditorAssembly : System.Attribute
    {
    }

    class ExcludeFromPresetAttribute : System.Attribute
    {
        /*0x1771cb8*/ ExcludeFromPresetAttribute();
    }

    class MonoBehaviour : UnityEngine.Behaviour
    {
        static /*0x1772694*/ void print(object message);
        static /*0x1771d74*/ void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self);
        static /*0x1771cfc*/ bool Internal_IsInvokingAll(UnityEngine.MonoBehaviour self);
        static /*0x1771e08*/ void InvokeDelayed(UnityEngine.MonoBehaviour self, string methodName, float time, float repeatRate);
        static /*0x1771f64*/ void CancelInvoke(UnityEngine.MonoBehaviour self, string methodName);
        static /*0x1771fec*/ bool IsInvoking(UnityEngine.MonoBehaviour self, string methodName);
        static /*0x177214c*/ bool IsObjectMonoBehaviour(UnityEngine.Object obj);
        /*0x1772724*/ MonoBehaviour();
        /*0x1771cc0*/ bool IsInvoking();
        /*0x1771d38*/ void CancelInvoke();
        /*0x1771db0*/ void Invoke(string methodName, float time);
        /*0x1771e64*/ void InvokeRepeating(string methodName, float time, float repeatRate);
        /*0x1771f20*/ void CancelInvoke(string methodName);
        /*0x1771fa8*/ bool IsInvoking(string methodName);
        /*0x1772030*/ UnityEngine.Coroutine StartCoroutine(string methodName);
        /*0x1772038*/ UnityEngine.Coroutine StartCoroutine(string methodName, object value);
        /*0x17721dc*/ UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine);
        /*0x1772318*/ UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine);
        /*0x177231c*/ void StopCoroutine(System.Collections.IEnumerator routine);
        /*0x1772458*/ void StopCoroutine(UnityEngine.Coroutine routine);
        /*0x1772594*/ void StopCoroutine(string methodName);
        /*0x17725d8*/ void StopAllCoroutines();
        /*0x1772614*/ bool get_useGUILayout();
        /*0x1772650*/ void set_useGUILayout(bool value);
        /*0x1772188*/ UnityEngine.Coroutine StartCoroutineManaged(string methodName, object value);
        /*0x17722d4*/ UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator);
        /*0x1772550*/ void StopCoroutineManaged(UnityEngine.Coroutine routine);
        /*0x1772414*/ void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine);
        /*0x17726e8*/ string GetScriptClassName();
    }

    class UnhandledExceptionHandler
    {
        static /*0x1772728*/ void RegisterUECatcher();

        class <>c
        {
            static /*0x0*/ UnityEngine.UnhandledExceptionHandler.<> <>9;
            static /*0x8*/ System.UnhandledExceptionEventHandler <>9__0_0;

            static /*0x1772820*/ <>c();
            /*0x1772884*/ <>c();
            /*0x177288c*/ void <RegisterUECatcher>b__0_0(object sender, System.UnhandledExceptionEventArgs e);
        }
    }

    class ScriptingUtility
    {
        static /*0x177293c*/ bool IsManagedCodeWorking();

        struct TestClass
        {
            /*0x10*/ int value;
        }
    }

    class WaitForFixedUpdate : UnityEngine.YieldInstruction
    {
    }

    class ExcludeFromObjectFactoryAttribute : System.Attribute
    {
        /*0x1772944*/ ExcludeFromObjectFactoryAttribute();
    }

    class Coroutine : UnityEngine.YieldInstruction
    {
        /*0x10*/ nint m_Ptr;

        static /*0x1772a10*/ void ReleaseCoroutine(nint ptr);
        /*0x177294c*/ Coroutine();
        /*0x1772954*/ void Finalize();
    }

    class ExtensionOfNativeClassAttribute : System.Attribute
    {
        /*0x1772a4c*/ ExtensionOfNativeClassAttribute();
    }

    class WaitForSecondsRealtime : UnityEngine.CustomYieldInstruction
    {
        /*0x10*/ float <waitTime>k__BackingField;
        /*0x14*/ float m_WaitUntilTime;

        /*0x1772b00*/ WaitForSecondsRealtime(float time);
        /*0x1772a54*/ float get_waitTime();
        /*0x1772a5c*/ void set_waitTime(float value);
        /*0x1772a64*/ bool get_keepWaiting();
        /*0x1772b38*/ void Reset();
    }

    class ManagedStreamHelpers
    {
        static /*0x1772b44*/ void ValidateLoadFromStream(System.IO.Stream stream);
        static /*0x1772c54*/ void ManagedStreamRead(byte[] buffer, int offset, int count, System.IO.Stream stream, nint returnValueAddress);
        static /*0x1772d74*/ void ManagedStreamSeek(long offset, uint origin, System.IO.Stream stream, nint returnValueAddress);
        static /*0x1772e8c*/ void ManagedStreamLength(System.IO.Stream stream, nint returnValueAddress);
    }

    class NoAllocHelpers
    {
        static void ResizeList<T>(System.Collections.Generic.List<T> list, int size);
        static void EnsureListElemCount<T>(System.Collections.Generic.List<T> list, int count);
        static /*0x175f5d4*/ int SafeLength(System.Array values);
        static int SafeLength<T>(System.Collections.Generic.List<T> values);
        static /*0x1772f88*/ void Internal_ResizeList(object list, int size);
        static /*0x175fa60*/ System.Array ExtractArrayFromList(object list);
    }

    class Component : UnityEngine.Object
    {
        /*0x176defc*/ Component();
        /*0x1772fcc*/ UnityEngine.Transform get_transform();
        /*0x1773008*/ UnityEngine.GameObject get_gameObject();
        /*0x1773044*/ UnityEngine.Component GetComponent(System.Type type);
        /*0x17730bc*/ void GetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        T GetComponent<T>();
        /*0x1773110*/ UnityEngine.Component GetComponentInChildren(System.Type t, bool includeInactive);
        T GetComponentInChildren<T>();
        T[] GetComponentsInChildren<T>(bool includeInactive);
        void GetComponentsInChildren<T>(bool includeInactive, System.Collections.Generic.List<T> result);
        T[] GetComponentsInChildren<T>();
        void GetComponentsInChildren<T>(System.Collections.Generic.List<T> results);
        /*0x1773198*/ UnityEngine.Component GetComponentInParent(System.Type t, bool includeInactive);
        T GetComponentInParent<T>();
        T[] GetComponentsInParent<T>(bool includeInactive);
        void GetComponentsInParent<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        T[] GetComponentsInParent<T>();
        /*0x1773220*/ void GetComponentsForListInternal(System.Type searchType, object resultList);
        /*0x1773274*/ void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results);
        void GetComponents<T>(System.Collections.Generic.List<T> results);
        T[] GetComponents<T>();
        /*0x17732c8*/ void SendMessage(string methodName, object value);
        /*0x1773320*/ void SendMessage(string methodName, object value, UnityEngine.SendMessageOptions options);
        /*0x177337c*/ void BroadcastMessage(string methodName, object parameter, UnityEngine.SendMessageOptions options);
        /*0x17733d8*/ void BroadcastMessage(string methodName);
    }

    class UnitySynchronizationContext : System.Threading.SynchronizationContext
    {
        /*0x18*/ System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue;
        /*0x20*/ System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork;
        /*0x28*/ int m_MainThreadID;
        /*0x2c*/ int m_TrackedCount;

        static /*0x1773d2c*/ void InitializeSynchronizationContext();
        static /*0x1773da8*/ void ExecuteTasks();
        static /*0x1773e0c*/ bool ExecutePendingTasks(long millisecondsTimeout);
        /*0x1773424*/ UnitySynchronizationContext(int mainThreadID);
        /*0x17734dc*/ UnitySynchronizationContext(System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> queue, int mainThreadID);
        /*0x177357c*/ void Send(System.Threading.SendOrPostCallback callback, object state);
        /*0x177388c*/ void OperationStarted();
        /*0x1773898*/ void OperationCompleted();
        /*0x17738a4*/ void Post(System.Threading.SendOrPostCallback callback, object state);
        /*0x17739f4*/ System.Threading.SynchronizationContext CreateCopy();
        /*0x1773a60*/ void Exec();
        /*0x1773ccc*/ bool HasPendingTasks();

        struct WorkRequest
        {
            /*0x10*/ System.Threading.SendOrPostCallback m_DelagateCallback;
            /*0x18*/ object m_DelagateState;
            /*0x20*/ System.Threading.ManualResetEvent m_WaitHandle;

            /*0x1773880*/ WorkRequest(System.Threading.SendOrPostCallback callback, object state, System.Threading.ManualResetEvent waitHandle);
            /*0x1773c20*/ void Invoke();
        }
    }

    class FailedToLoadScriptObject : UnityEngine.Object
    {
    }

    class UnityAPICompatibilityVersionAttribute : System.Attribute
    {
        /*0x10*/ string _version;
        /*0x18*/ string[] _configurationAssembliesHashes;

        /*0x1773efc*/ UnityAPICompatibilityVersionAttribute(string version, string[] configurationAssembliesHashes);
    }

    class CustomYieldInstruction : System.Collections.IEnumerator
    {
        /*0x1772b30*/ CustomYieldInstruction();
        bool get_keepWaiting();
        /*0x1773f28*/ object get_Current();
        /*0x1773f30*/ bool MoveNext();
        /*0x1773f3c*/ void Reset();
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

        static /*0x17747d0*/ Vector2();
        static /*0x1774020*/ UnityEngine.Vector2 Lerp(UnityEngine.Vector2 a, UnityEngine.Vector2 b, float t);
        static /*0x1774050*/ UnityEngine.Vector2 LerpUnclamped(UnityEngine.Vector2 a, UnityEngine.Vector2 b, float t);
        static /*0x177406c*/ UnityEngine.Vector2 Scale(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x177446c*/ float Dot(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x17744fc*/ float Distance(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x1774580*/ UnityEngine.Vector2 Min(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x1774594*/ UnityEngine.Vector2 Max(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x17745a8*/ UnityEngine.Vector2 op_Addition(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x17745b4*/ UnityEngine.Vector2 op_Subtraction(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x17745c0*/ UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x17745cc*/ UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x17745d8*/ UnityEngine.Vector2 op_UnaryNegation(UnityEngine.Vector2 a);
        static /*0x17745e4*/ UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, float d);
        static /*0x17745f0*/ UnityEngine.Vector2 op_Multiply(float d, UnityEngine.Vector2 a);
        static /*0x1774600*/ UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, float d);
        static /*0x177460c*/ bool op_Equality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x1774634*/ bool op_Inequality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x177465c*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector3 v);
        static /*0x1774660*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector2 v);
        static /*0x1774668*/ UnityEngine.Vector2 get_zero();
        static /*0x17746b0*/ UnityEngine.Vector2 get_one();
        static /*0x17746f8*/ UnityEngine.Vector2 get_up();
        static /*0x1774740*/ UnityEngine.Vector2 get_down();
        static /*0x1774788*/ UnityEngine.Vector2 get_right();
        /*0x1774018*/ Vector2(float x, float y);
        /*0x1773f40*/ float get_Item(int index);
        /*0x1773fac*/ void set_Item(int index, float value);
        /*0x1774078*/ void Normalize();
        /*0x1774140*/ UnityEngine.Vector2 get_normalized();
        /*0x17741f0*/ string ToString();
        /*0x1774384*/ string ToString(string format);
        /*0x17741fc*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x177438c*/ int GetHashCode();
        /*0x17743c0*/ bool Equals(object other);
        /*0x1774448*/ bool Equals(UnityEngine.Vector2 other);
        /*0x177447c*/ float get_magnitude();
        /*0x17744e8*/ float get_sqrMagnitude();
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

        static /*0x1774c54*/ Vector2Int();
        static /*0x17748ac*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector2Int v);
        static /*0x17748bc*/ UnityEngine.Vector2Int FloorToInt(UnityEngine.Vector2 v);
        static /*0x17749b4*/ bool op_Equality(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs);
        /*0x17748a4*/ Vector2Int(int x, int y);
        /*0x1774884*/ int get_x();
        /*0x177488c*/ void set_x(int value);
        /*0x1774894*/ int get_y();
        /*0x177489c*/ void set_y(int value);
        /*0x17749d4*/ bool Equals(object other);
        /*0x1774a5c*/ bool Equals(UnityEngine.Vector2Int other);
        /*0x1774a84*/ int GetHashCode();
        /*0x1774acc*/ string ToString();
        /*0x1774ad8*/ string ToString(string format, System.IFormatProvider formatProvider);
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

        static /*0x1776024*/ Matrix4x4();
        static /*0x17753c8*/ UnityEngine.Matrix4x4 op_Multiply(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs);
        static /*0x1775768*/ UnityEngine.Matrix4x4 get_identity();
        static /*0x1775d78*/ UnityEngine.Matrix4x4 TRS(UnityEngine.Vector3 pos, UnityEngine.Quaternion q, UnityEngine.Vector3 s);
        static /*0x1775e64*/ bool Inverse3DAffine(UnityEngine.Matrix4x4 input, ref UnityEngine.Matrix4x4 result);
        static /*0x1775eec*/ UnityEngine.Matrix4x4 Inverse(UnityEngine.Matrix4x4 m);
        static /*0x1775d30*/ void GetLossyScale_Injected(ref UnityEngine.Matrix4x4 _unity_self, ref UnityEngine.Vector3 ret);
        static /*0x1775e08*/ void TRS_Injected(ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion q, ref UnityEngine.Vector3 s, ref UnityEngine.Matrix4x4 ret);
        static /*0x1775ea8*/ bool Inverse3DAffine_Injected(ref UnityEngine.Matrix4x4 input, ref UnityEngine.Matrix4x4 result);
        static /*0x1775f58*/ void Inverse_Injected(ref UnityEngine.Matrix4x4 m, ref UnityEngine.Matrix4x4 ret);
        /*0x1774cdc*/ Matrix4x4(UnityEngine.Vector4 column0, UnityEngine.Vector4 column1, UnityEngine.Vector4 column2, UnityEngine.Vector4 column3);
        /*0x1774cf8*/ float get_Item(int index);
        /*0x1774dec*/ void set_Item(int index, float value);
        /*0x1774ee0*/ int GetHashCode();
        /*0x177514c*/ bool Equals(object other);
        /*0x17752c0*/ bool Equals(UnityEngine.Matrix4x4 other);
        /*0x1775074*/ UnityEngine.Vector4 GetColumn(int index);
        /*0x1775570*/ UnityEngine.Vector4 GetRow(int index);
        /*0x1775648*/ UnityEngine.Vector3 MultiplyPoint(UnityEngine.Vector3 point);
        /*0x17756c8*/ UnityEngine.Vector3 MultiplyPoint3x4(UnityEngine.Vector3 point);
        /*0x1775720*/ UnityEngine.Vector3 MultiplyVector(UnityEngine.Vector3 vector);
        /*0x17757c0*/ string ToString();
        /*0x17757cc*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x1775cd4*/ UnityEngine.Vector3 GetLossyScale();
        /*0x1775d74*/ UnityEngine.Vector3 get_lossyScale();
        /*0x1775f9c*/ UnityEngine.Matrix4x4 get_inverse();
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

        static /*0x17870b0*/ Vector4();
        static /*0x1786ce8*/ float Dot(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x1786d30*/ UnityEngine.Vector4 get_zero();
        static /*0x1786d7c*/ UnityEngine.Vector4 get_one();
        static /*0x1786dc8*/ UnityEngine.Vector4 op_Addition(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x1786ddc*/ UnityEngine.Vector4 op_Multiply(UnityEngine.Vector4 a, float d);
        static /*0x1786df0*/ UnityEngine.Vector4 op_Division(UnityEngine.Vector4 a, float d);
        static /*0x1786e04*/ bool op_Equality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs);
        static /*0x1786e44*/ bool op_Inequality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs);
        static /*0x1786e84*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Vector3 v);
        static /*0x1786e8c*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector4 v);
        static /*0x1786e90*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Vector2 v);
        /*0x1786b94*/ Vector4(float x, float y, float z, float w);
        /*0x1786a6c*/ float get_Item(int index);
        /*0x1786b00*/ void set_Item(int index, float value);
        /*0x1786ba0*/ int GetHashCode();
        /*0x1786c04*/ bool Equals(object other);
        /*0x1786cac*/ bool Equals(UnityEngine.Vector4 other);
        /*0x1786d08*/ float get_sqrMagnitude();
        /*0x1786e9c*/ string ToString();
        /*0x1786ea8*/ string ToString(string format, System.IFormatProvider formatProvider);
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

        static /*0x1787cb4*/ Vector3();
        static /*0x1787124*/ UnityEngine.Vector3 Lerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, float t);
        static /*0x1787160*/ UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3 a, UnityEngine.Vector3 b, float t);
        static /*0x1787298*/ UnityEngine.Vector3 Scale(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x17872c8*/ UnityEngine.Vector3 Cross(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x1787400*/ UnityEngine.Vector3 Normalize(UnityEngine.Vector3 value);
        static /*0x178759c*/ float Dot(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x17875b4*/ float Distance(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x1787654*/ float Magnitude(UnityEngine.Vector3 vector);
        static /*0x1787774*/ UnityEngine.Vector3 Min(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x1787790*/ UnityEngine.Vector3 Max(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x17877ac*/ UnityEngine.Vector3 get_zero();
        static /*0x17877f8*/ UnityEngine.Vector3 get_one();
        static /*0x1787844*/ UnityEngine.Vector3 get_forward();
        static /*0x1787890*/ UnityEngine.Vector3 get_back();
        static /*0x17878dc*/ UnityEngine.Vector3 get_up();
        static /*0x1787928*/ UnityEngine.Vector3 get_down();
        static /*0x1787974*/ UnityEngine.Vector3 get_left();
        static /*0x17879c0*/ UnityEngine.Vector3 get_right();
        static /*0x1787a0c*/ UnityEngine.Vector3 op_Addition(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x1787a1c*/ UnityEngine.Vector3 op_Subtraction(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x1787a2c*/ UnityEngine.Vector3 op_UnaryNegation(UnityEngine.Vector3 a);
        static /*0x1787a3c*/ UnityEngine.Vector3 op_Multiply(UnityEngine.Vector3 a, float d);
        static /*0x1787a4c*/ UnityEngine.Vector3 op_Multiply(float d, UnityEngine.Vector3 a);
        static /*0x1787a60*/ UnityEngine.Vector3 op_Division(UnityEngine.Vector3 a, float d);
        static /*0x1787a70*/ bool op_Equality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x1787aa4*/ bool op_Inequality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        /*0x1787280*/ Vector3(float x, float y, float z);
        /*0x178728c*/ Vector3(float x, float y);
        /*0x1787188*/ float get_Item(int index);
        /*0x1787204*/ void set_Item(int index, float value);
        /*0x17872a8*/ void Scale(UnityEngine.Vector3 scale);
        /*0x17872f0*/ int GetHashCode();
        /*0x1787338*/ bool Equals(object other);
        /*0x17873d0*/ bool Equals(UnityEngine.Vector3 other);
        /*0x17874d0*/ UnityEngine.Vector3 get_normalized();
        /*0x17876d4*/ float get_magnitude();
        /*0x1787754*/ float get_sqrMagnitude();
        /*0x1787ad8*/ string ToString();
        /*0x1787cac*/ string ToString(string format);
        /*0x1787ae4*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Color32 : System.IFormattable
    {
        /*0x10*/ int rgba;
        /*0x10*/ byte r;
        /*0x11*/ byte g;
        /*0x12*/ byte b;
        /*0x13*/ byte a;

        static /*0x1787dc4*/ UnityEngine.Color32 op_Implicit(UnityEngine.Color c);
        static /*0x1788088*/ UnityEngine.Color op_Implicit(UnityEngine.Color32 c);
        /*0x1787db0*/ Color32(byte r, byte g, byte b, byte a);
        /*0x17880c4*/ string ToString();
        /*0x17880d0*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Color : System.IEquatable<UnityEngine.Color>, System.IFormattable
    {
        /*0x10*/ float r;
        /*0x14*/ float g;
        /*0x18*/ float b;
        /*0x1c*/ float a;

        static /*0x17886b8*/ UnityEngine.Color op_Addition(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x17886cc*/ UnityEngine.Color op_Subtraction(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x17886e0*/ UnityEngine.Color op_Multiply(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x17886f4*/ UnityEngine.Color op_Multiply(UnityEngine.Color a, float b);
        static /*0x1788708*/ bool op_Equality(UnityEngine.Color lhs, UnityEngine.Color rhs);
        static /*0x1788748*/ bool op_Inequality(UnityEngine.Color lhs, UnityEngine.Color rhs);
        static /*0x1788788*/ UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, float t);
        static /*0x17887d4*/ UnityEngine.Color LerpUnclamped(UnityEngine.Color a, UnityEngine.Color b, float t);
        static /*0x1788828*/ UnityEngine.Color get_red();
        static /*0x178883c*/ UnityEngine.Color get_green();
        static /*0x1788850*/ UnityEngine.Color get_blue();
        static /*0x1788864*/ UnityEngine.Color get_white();
        static /*0x1788878*/ UnityEngine.Color get_black();
        static /*0x178888c*/ UnityEngine.Color get_yellow();
        static /*0x17888a8*/ UnityEngine.Color get_grey();
        static /*0x17888bc*/ UnityEngine.Color get_clear();
        static /*0x17889d4*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Color c);
        static /*0x17889d8*/ UnityEngine.Color op_Implicit(UnityEngine.Vector4 v);
        /*0x17882ac*/ Color(float r, float g, float b, float a);
        /*0x17882b8*/ Color(float r, float g, float b);
        /*0x17882cc*/ string ToString();
        /*0x17882d8*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x17884e0*/ int GetHashCode();
        /*0x1788564*/ bool Equals(object other);
        /*0x1788638*/ bool Equals(UnityEngine.Color other);
        /*0x178880c*/ UnityEngine.Color RGBMultiplied(float multiplier);
        /*0x17888d0*/ UnityEngine.Color get_linear();
        /*0x17889b8*/ float get_maxColorComponent();
    }

    struct Quaternion : System.IEquatable<UnityEngine.Quaternion>, System.IFormattable
    {
        static float kEpsilon = 9.999999974752427e-7;
        static /*0x0*/ UnityEngine.Quaternion identityQuaternion;
        /*0x10*/ float x;
        /*0x14*/ float y;
        /*0x18*/ float z;
        /*0x1c*/ float w;

        static /*0x178931c*/ Quaternion();
        static /*0x17889dc*/ UnityEngine.Quaternion Inverse(UnityEngine.Quaternion rotation);
        static /*0x1788a74*/ UnityEngine.Quaternion Internal_FromEulerRad(UnityEngine.Vector3 euler);
        static /*0x1788b0c*/ UnityEngine.Vector3 Internal_ToEulerRad(UnityEngine.Quaternion rotation);
        static /*0x1788ba8*/ UnityEngine.Quaternion AngleAxis(float angle, UnityEngine.Vector3 axis);
        static /*0x1788c6c*/ UnityEngine.Quaternion get_identity();
        static /*0x1788cb8*/ UnityEngine.Quaternion op_Multiply(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x1788d2c*/ UnityEngine.Vector3 op_Multiply(UnityEngine.Quaternion rotation, UnityEngine.Vector3 point);
        static /*0x1788dd0*/ bool IsEqualUsingDot(float dot);
        static /*0x1788de4*/ bool op_Equality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x1788e14*/ bool op_Inequality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x1788e44*/ float Dot(UnityEngine.Quaternion a, UnityEngine.Quaternion b);
        static /*0x1788e64*/ UnityEngine.Vector3 Internal_MakePositive(UnityEngine.Vector3 euler);
        static /*0x1788f18*/ UnityEngine.Quaternion Euler(float x, float y, float z);
        static /*0x1788f30*/ UnityEngine.Quaternion Euler(UnityEngine.Vector3 euler);
        static /*0x1788a30*/ void Inverse_Injected(ref UnityEngine.Quaternion rotation, ref UnityEngine.Quaternion ret);
        static /*0x1788ac8*/ void Internal_FromEulerRad_Injected(ref UnityEngine.Vector3 euler, ref UnityEngine.Quaternion ret);
        static /*0x1788b64*/ void Internal_ToEulerRad_Injected(ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 ret);
        static /*0x1788c0c*/ void AngleAxis_Injected(float angle, ref UnityEngine.Vector3 axis, ref UnityEngine.Quaternion ret);
        /*0x1788c60*/ Quaternion(float x, float y, float z, float w);
        /*0x1788eec*/ UnityEngine.Vector3 get_eulerAngles();
        /*0x1788f48*/ int GetHashCode();
        /*0x1788fac*/ bool Equals(object other);
        /*0x1789080*/ bool Equals(UnityEngine.Quaternion other);
        /*0x1789100*/ string ToString();
        /*0x1789314*/ string ToString(string format);
        /*0x178910c*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Mathf
    {
        static /*0x0*/ float Epsilon;

        static /*0x178a0f0*/ Mathf();
        static /*0x178936c*/ bool IsPowerOfTwo(int value);
        static /*0x17893a8*/ int NextPowerOfTwo(int value);
        static /*0x1788980*/ float GammaToLinearSpace(float value);
        static /*0x17893e4*/ float LinearToGammaSpace(float value);
        static /*0x178941c*/ UnityEngine.Color CorrelatedColorTemperatureToRGB(float kelvin);
        static /*0x17894c0*/ float Sin(float f);
        static /*0x1789524*/ float Cos(float f);
        static /*0x1789588*/ float Tan(float f);
        static /*0x17895ec*/ float Asin(float f);
        static /*0x1789650*/ float Atan(float f);
        static /*0x17896b4*/ float Atan2(float y, float x);
        static /*0x1789720*/ float Sqrt(float f);
        static /*0x178977c*/ float Abs(float f);
        static /*0x17897d8*/ int Abs(int value);
        static /*0x1789830*/ float Min(float a, float b);
        static /*0x178983c*/ int Min(int a, int b);
        static /*0x1789848*/ float Max(float a, float b);
        static /*0x1789854*/ int Max(int a, int b);
        static /*0x1789860*/ float Pow(float f, float p);
        static /*0x17898d0*/ float Log(float f, float p);
        static /*0x1789940*/ float Log10(float f);
        static /*0x17899a4*/ float Ceil(float f);
        static /*0x1789a00*/ float Floor(float f);
        static /*0x1789a5c*/ float Round(float f);
        static /*0x1789b24*/ int CeilToInt(float f);
        static /*0x1789b98*/ int FloorToInt(float f);
        static /*0x1789c0c*/ int RoundToInt(float f);
        static /*0x1789ce8*/ float Sign(float f);
        static /*0x1789cfc*/ float Clamp(float value, float min, float max);
        static /*0x1789d18*/ int Clamp(int value, int min, int max);
        static /*0x1789d34*/ float Clamp01(float value);
        static /*0x1789d50*/ float Lerp(float a, float b, float t);
        static /*0x1789d74*/ float LerpUnclamped(float a, float b, float t);
        static /*0x1789d84*/ bool Approximately(float a, float b);
        static /*0x1789e14*/ float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime);
        static /*0x1789e64*/ float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime);
        static /*0x1789f30*/ float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime);
        static /*0x1789fc8*/ float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime);
        static /*0x178a018*/ float Repeat(float t, float length);
        static /*0x178a040*/ float PingPong(float t, float length);
        static /*0x178a074*/ float InverseLerp(float a, float b, float value);
        static /*0x178a0a4*/ float DeltaAngle(float current, float target);
        static /*0x1789474*/ void CorrelatedColorTemperatureToRGB_Injected(float kelvin, ref UnityEngine.Color ret);
    }

    class Gradient : System.IEquatable<UnityEngine.Gradient>
    {
        /*0x10*/ nint m_Ptr;

        static /*0x178a16c*/ nint Init();
        /*0x178a214*/ Gradient();
        /*0x178a194*/ void Cleanup();
        /*0x178a1d0*/ bool Internal_Equals(nint other);
        /*0x178a25c*/ void Finalize();
        /*0x178a314*/ bool Equals(object o);
        /*0x178a3dc*/ bool Equals(UnityEngine.Gradient other);
        /*0x178a4a4*/ int GetHashCode();
    }

    class ComputeShader : UnityEngine.Object
    {
        /*0x178a4b0*/ int FindKernel(string name);
    }

    class ResourceRequest : UnityEngine.AsyncOperation
    {
        /*0x20*/ string m_Path;
        /*0x28*/ System.Type m_Type;
    }

    class ResourcesAPIInternal
    {
        static /*0x178a4f4*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type);
        static /*0x178a530*/ UnityEngine.Shader FindShaderByName(string name);
        static /*0x178a56c*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        static /*0x178a5b0*/ UnityEngine.Object[] LoadAll(string path, System.Type systemTypeInstance);
        static /*0x178a5f4*/ void UnloadAsset(UnityEngine.Object assetToUnload);
    }

    class ResourcesAPI
    {
        static /*0x0*/ UnityEngine.ResourcesAPI s_DefaultAPI;
        static /*0x8*/ UnityEngine.ResourcesAPI <overrideAPI>k__BackingField;

        static /*0x178a874*/ ResourcesAPI();
        static /*0x178a630*/ UnityEngine.ResourcesAPI get_ActiveAPI();
        static /*0x178a6d8*/ UnityEngine.ResourcesAPI get_overrideAPI();
        /*0x178a730*/ ResourcesAPI();
        /*0x178a738*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type systemTypeInstance);
        /*0x178a774*/ UnityEngine.Shader FindShaderByName(string name);
        /*0x178a7b0*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        /*0x178a7f4*/ UnityEngine.Object[] LoadAll(string path, System.Type systemTypeInstance);
        /*0x178a838*/ void UnloadAsset(UnityEngine.Object assetToUnload);
    }

    class Resources
    {
        static T[] ConvertObjects<T>(UnityEngine.Object[] rawObjects);
        static /*0x178a8d8*/ UnityEngine.Object[] FindObjectsOfTypeAll(System.Type type);
        static /*0x178a940*/ UnityEngine.Object Load(string path);
        static T Load<T>(string path);
        static /*0x178a9c4*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        static /*0x178aa3c*/ UnityEngine.Object[] LoadAll(string path, System.Type systemTypeInstance);
        static T[] LoadAll<T>(string path);
        static /*0x178aab4*/ UnityEngine.Object GetBuiltinResource(System.Type type, string path);
        static T GetBuiltinResource<T>(string path);
        static /*0x178aaf8*/ void UnloadAsset(UnityEngine.Object assetToUnload);
        static /*0x178ab60*/ UnityEngine.AsyncOperation UnloadUnusedAssets();
    }

    struct SortingLayer
    {
        /*0x10*/ int m_Id;

        static /*0x178ab88*/ int GetLayerValueFromID(int id);
    }

    class Gizmos
    {
        static /*0x178abc4*/ void DrawLine(UnityEngine.Vector3 from, UnityEngine.Vector3 to);
        static /*0x178ac58*/ void set_color(UnityEngine.Color value);
        static /*0x178ac14*/ void DrawLine_Injected(ref UnityEngine.Vector3 from, ref UnityEngine.Vector3 to);
        static /*0x178ac9c*/ void set_color_Injected(ref UnityEngine.Color value);
    }

    class Application
    {
        static /*0x0*/ UnityEngine.Application.LowMemoryCallback lowMemory;
        static /*0x8*/ UnityEngine.Application.LogCallback s_LogCallbackHandler;
        static /*0x10*/ UnityEngine.Application.LogCallback s_LogCallbackHandlerThreaded;
        static /*0x18*/ System.Action<bool> focusChanged;
        static /*0x20*/ System.Action<string> deepLinkActivated;
        static /*0x28*/ System.Func<bool> wantsToQuit;
        static /*0x30*/ System.Action quitting;
        static /*0x38*/ System.Action unloading;

        static /*0x178acd8*/ void Quit(int exitCode);
        static /*0x178ad14*/ void Quit();
        static /*0x178ad44*/ bool get_isPlaying();
        static /*0x178ad6c*/ bool get_isFocused();
        static /*0x178ad94*/ string get_buildGUID();
        static /*0x178adbc*/ bool get_isBatchMode();
        static /*0x178ade4*/ string get_dataPath();
        static /*0x178ae0c*/ string get_streamingAssetsPath();
        static /*0x178ae34*/ string get_persistentDataPath();
        static /*0x178ae5c*/ string get_unityVersion();
        static /*0x178ae84*/ string get_version();
        static /*0x178aeac*/ string get_identifier();
        static /*0x178aed4*/ UnityEngine.ApplicationInstallMode get_installMode();
        static /*0x178aefc*/ string get_productName();
        static /*0x178af24*/ string get_cloudProjectId();
        static /*0x178af4c*/ void OpenURL(string url);
        static /*0x178af88*/ int get_targetFrameRate();
        static /*0x178afb0*/ void set_targetFrameRate(int value);
        static /*0x178afec*/ UnityEngine.StackTraceLogType GetStackTraceLogType(UnityEngine.LogType logType);
        static /*0x178b028*/ bool get_genuine();
        static /*0x178b050*/ bool get_genuineCheckAvailable();
        static /*0x178b078*/ UnityEngine.RuntimePlatform get_platform();
        static /*0x178b0a0*/ UnityEngine.SystemLanguage get_systemLanguage();
        static /*0x178b0c8*/ UnityEngine.NetworkReachability get_internetReachability();
        static /*0x178b0f0*/ void CallLowMemory();
        static /*0x178b154*/ void CallLogCallback(string logString, string stackTrace, UnityEngine.LogType type, bool invokedOnMainThread);
        static /*0x178b210*/ bool Internal_ApplicationWantsToQuit();
        static /*0x178b3d4*/ void Internal_ApplicationQuit();
        static /*0x178b438*/ void Internal_ApplicationUnload();
        static /*0x178b49c*/ void InvokeOnBeforeRender();
        static /*0x178b4ec*/ void InvokeFocusChanged(bool focus);
        static /*0x178b558*/ void InvokeDeepLinkActivated(string url);
        static /*0x178b5c4*/ void LoadLevel(int index);
        static /*0x178b684*/ bool get_isEditor();

        class LowMemoryCallback : System.MulticastDelegate
        {
            /*0x178b68c*/ LowMemoryCallback(object object, nint method);
            /*0x178b748*/ void Invoke();
        }

        class LogCallback : System.MulticastDelegate
        {
            /*0x178b75c*/ LogCallback(object object, nint method);
            /*0x178b834*/ void Invoke(string condition, string stackTrace, UnityEngine.LogType type);
        }
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

    enum ApplicationInstallMode
    {
        Unknown = 0,
        Store = 1,
        DeveloperBuild = 2,
        Adhoc = 3,
        Enterprise = 4,
        Editor = 5,
    }

    class LowerResBlitTexture : UnityEngine.Object
    {
        /*0x178b848*/ void LowerResBlitTextureDontStripMe();
    }

    class PreloadData : UnityEngine.Object
    {
        /*0x178b84c*/ void PreloadDataDontStripMe();
    }

    class Transform : UnityEngine.Component, System.Collections.IEnumerable
    {
        static /*0x178ce34*/ UnityEngine.Transform FindRelativeTransformWithPath(UnityEngine.Transform transform, string path, bool isActiveOnly);
        /*0x178b850*/ Transform();
        /*0x178b858*/ UnityEngine.Vector3 get_position();
        /*0x178b8f8*/ void set_position(UnityEngine.Vector3 value);
        /*0x178b990*/ UnityEngine.Vector3 get_localPosition();
        /*0x178ba30*/ void set_localPosition(UnityEngine.Vector3 value);
        /*0x178bac8*/ UnityEngine.Vector3 get_eulerAngles();
        /*0x178bb48*/ void set_eulerAngles(UnityEngine.Vector3 value);
        /*0x178bbc8*/ UnityEngine.Vector3 get_localEulerAngles();
        /*0x178bc48*/ void set_localEulerAngles(UnityEngine.Vector3 value);
        /*0x178bcc8*/ UnityEngine.Vector3 get_forward();
        /*0x178baf0*/ UnityEngine.Quaternion get_rotation();
        /*0x178bb74*/ void set_rotation(UnityEngine.Quaternion value);
        /*0x178bbf0*/ UnityEngine.Quaternion get_localRotation();
        /*0x178bc74*/ void set_localRotation(UnityEngine.Quaternion value);
        /*0x178be50*/ UnityEngine.Vector3 get_localScale();
        /*0x178bef0*/ void set_localScale(UnityEngine.Vector3 value);
        /*0x178bf88*/ UnityEngine.Transform get_parent();
        /*0x178c000*/ void set_parent(UnityEngine.Transform value);
        /*0x178bfc4*/ UnityEngine.Transform get_parentInternal();
        /*0x178c0cc*/ void set_parentInternal(UnityEngine.Transform value);
        /*0x178c114*/ UnityEngine.Transform GetParent();
        /*0x178c150*/ void SetParent(UnityEngine.Transform p);
        /*0x178c198*/ void SetParent(UnityEngine.Transform parent, bool worldPositionStays);
        /*0x178c1ec*/ UnityEngine.Matrix4x4 get_worldToLocalMatrix();
        /*0x178c29c*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
        /*0x178c34c*/ void Translate(UnityEngine.Vector3 translation, UnityEngine.Space relativeTo);
        /*0x178c43c*/ void Translate(UnityEngine.Vector3 translation);
        /*0x178c444*/ void Rotate(UnityEngine.Vector3 eulers, UnityEngine.Space relativeTo);
        /*0x178c6c4*/ void Rotate(UnityEngine.Vector3 eulers);
        /*0x178c6cc*/ void Rotate(float xAngle, float yAngle, float zAngle);
        /*0x178c6d4*/ void RotateAroundInternal(UnityEngine.Vector3 axis, float angle);
        /*0x178c78c*/ void RotateAround(UnityEngine.Vector3 point, UnityEngine.Vector3 axis, float angle);
        /*0x178c848*/ void LookAt(UnityEngine.Transform target, UnityEngine.Vector3 worldUp);
        /*0x178c90c*/ void LookAt(UnityEngine.Transform target);
        /*0x178c908*/ void LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp);
        /*0x178ca64*/ void LookAt(UnityEngine.Vector3 worldPosition);
        /*0x178ca04*/ void Internal_LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp);
        /*0x178c3d4*/ UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3 direction);
        /*0x178cb88*/ UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 position);
        /*0x178cc44*/ UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 position);
        /*0x178cd00*/ int get_childCount();
        /*0x178cd3c*/ void SetAsFirstSibling();
        /*0x178cd78*/ void SetAsLastSibling();
        /*0x178cdb4*/ void SetSiblingIndex(int index);
        /*0x178cdf8*/ int GetSiblingIndex();
        /*0x178ce88*/ UnityEngine.Transform Find(string n);
        /*0x178cf20*/ UnityEngine.Vector3 get_lossyScale();
        /*0x178cfc0*/ bool IsChildOf(UnityEngine.Transform parent);
        /*0x178d004*/ void set_hasChanged(bool value);
        /*0x178d048*/ System.Collections.IEnumerator GetEnumerator();
        /*0x178d0e4*/ UnityEngine.Transform GetChild(int index);
        /*0x178b8b4*/ void get_position_Injected(ref UnityEngine.Vector3 ret);
        /*0x178b94c*/ void set_position_Injected(ref UnityEngine.Vector3 value);
        /*0x178b9ec*/ void get_localPosition_Injected(ref UnityEngine.Vector3 ret);
        /*0x178ba84*/ void set_localPosition_Injected(ref UnityEngine.Vector3 value);
        /*0x178bd40*/ void get_rotation_Injected(ref UnityEngine.Quaternion ret);
        /*0x178bd84*/ void set_rotation_Injected(ref UnityEngine.Quaternion value);
        /*0x178bdc8*/ void get_localRotation_Injected(ref UnityEngine.Quaternion ret);
        /*0x178be0c*/ void set_localRotation_Injected(ref UnityEngine.Quaternion value);
        /*0x178beac*/ void get_localScale_Injected(ref UnityEngine.Vector3 ret);
        /*0x178bf44*/ void set_localScale_Injected(ref UnityEngine.Vector3 value);
        /*0x178c258*/ void get_worldToLocalMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        /*0x178c308*/ void get_localToWorldMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        /*0x178c738*/ void RotateAroundInternal_Injected(ref UnityEngine.Vector3 axis, float angle);
        /*0x178cae0*/ void Internal_LookAt_Injected(ref UnityEngine.Vector3 worldPosition, ref UnityEngine.Vector3 worldUp);
        /*0x178cb34*/ void TransformDirection_Injected(ref UnityEngine.Vector3 direction, ref UnityEngine.Vector3 ret);
        /*0x178cbf0*/ void TransformPoint_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        /*0x178ccac*/ void InverseTransformPoint_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        /*0x178cf7c*/ void get_lossyScale_Injected(ref UnityEngine.Vector3 ret);

        class Enumerator : System.Collections.IEnumerator
        {
            /*0x10*/ UnityEngine.Transform outer;
            /*0x18*/ int currentIndex;

            /*0x178d0b4*/ Enumerator(UnityEngine.Transform outer);
            /*0x178d128*/ object get_Current();
            /*0x178d174*/ bool MoveNext();
            /*0x178d1d4*/ void Reset();
        }
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
        /*0x178d1e0*/ void Add(UnityEngine.Object driver, UnityEngine.RectTransform rectTransform, UnityEngine.DrivenTransformProperties drivenProperties);
        /*0x178d1e4*/ void Clear();
    }

    class RectTransform : UnityEngine.Transform
    {
        static /*0x0*/ UnityEngine.RectTransform.ReapplyDrivenProperties reapplyDrivenProperties;

        static /*0x178d1e8*/ void add_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value);
        static /*0x178d2a0*/ void remove_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value);
        static /*0x178e110*/ void SendReapplyDrivenProperties(UnityEngine.RectTransform driven);
        /*0x178d358*/ UnityEngine.Rect get_rect();
        /*0x178d3f4*/ UnityEngine.Vector2 get_anchorMin();
        /*0x178d484*/ void set_anchorMin(UnityEngine.Vector2 value);
        /*0x178d510*/ UnityEngine.Vector2 get_anchorMax();
        /*0x178d5a0*/ void set_anchorMax(UnityEngine.Vector2 value);
        /*0x178d62c*/ UnityEngine.Vector2 get_anchoredPosition();
        /*0x178d6bc*/ void set_anchoredPosition(UnityEngine.Vector2 value);
        /*0x178d748*/ UnityEngine.Vector2 get_sizeDelta();
        /*0x178d7d8*/ void set_sizeDelta(UnityEngine.Vector2 value);
        /*0x178d864*/ UnityEngine.Vector2 get_pivot();
        /*0x178d8f4*/ void set_pivot(UnityEngine.Vector2 value);
        /*0x178d980*/ UnityEngine.Vector2 get_offsetMin();
        /*0x178d9d4*/ void set_offsetMin(UnityEngine.Vector2 value);
        /*0x178dac8*/ UnityEngine.Vector2 get_offsetMax();
        /*0x178db68*/ void set_offsetMax(UnityEngine.Vector2 value);
        /*0x178dc64*/ void GetLocalCorners(UnityEngine.Vector3[] fourCornersArray);
        /*0x178dd98*/ void GetWorldCorners(UnityEngine.Vector3[] fourCornersArray);
        /*0x178def4*/ void SetSizeWithCurrentAnchors(UnityEngine.RectTransform.Axis axis, float size);
        /*0x178dff0*/ UnityEngine.Vector2 GetParentSize();
        /*0x178d3b0*/ void get_rect_Injected(ref UnityEngine.Rect ret);
        /*0x178d440*/ void get_anchorMin_Injected(ref UnityEngine.Vector2 ret);
        /*0x178d4cc*/ void set_anchorMin_Injected(ref UnityEngine.Vector2 value);
        /*0x178d55c*/ void get_anchorMax_Injected(ref UnityEngine.Vector2 ret);
        /*0x178d5e8*/ void set_anchorMax_Injected(ref UnityEngine.Vector2 value);
        /*0x178d678*/ void get_anchoredPosition_Injected(ref UnityEngine.Vector2 ret);
        /*0x178d704*/ void set_anchoredPosition_Injected(ref UnityEngine.Vector2 value);
        /*0x178d794*/ void get_sizeDelta_Injected(ref UnityEngine.Vector2 ret);
        /*0x178d820*/ void set_sizeDelta_Injected(ref UnityEngine.Vector2 value);
        /*0x178d8b0*/ void get_pivot_Injected(ref UnityEngine.Vector2 ret);
        /*0x178d93c*/ void set_pivot_Injected(ref UnityEngine.Vector2 value);

        enum Axis
        {
            Horizontal = 0,
            Vertical = 1,
        }

        class ReapplyDrivenProperties : System.MulticastDelegate
        {
            /*0x178e17c*/ ReapplyDrivenProperties(object object, nint method);
            /*0x178e250*/ void Invoke(UnityEngine.RectTransform driven);
        }
    }

    class SpriteRenderer : UnityEngine.Renderer
    {
        /*0x18*/ UnityEngine.Events.UnityEvent<UnityEngine.SpriteRenderer> m_SpriteChangeEvent;

        /*0x178e264*/ void InvokeSpriteChanged();
        /*0x178e358*/ void set_color(UnityEngine.Color value);
        /*0x178e3ac*/ void set_color_Injected(ref UnityEngine.Color value);
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

    class Sprite : UnityEngine.Object
    {
        static /*0x178e76c*/ UnityEngine.Sprite CreateSprite(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape);
        static /*0x178edc0*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape);
        static /*0x178f1ac*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border);
        static /*0x178f1bc*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType);
        static /*0x178f2a0*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude);
        static /*0x178f2a8*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit);
        static /*0x178e804*/ UnityEngine.Sprite CreateSprite_Injected(UnityEngine.Texture2D texture, ref UnityEngine.Rect rect, ref UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, ref UnityEngine.Vector4 border, bool generateFallbackPhysicsShape);
        /*0x178e3f0*/ Sprite();
        /*0x178e448*/ int GetPackingMode();
        /*0x178e484*/ int GetPackingRotation();
        /*0x178e4c0*/ int GetPacked();
        /*0x178e4fc*/ UnityEngine.Rect GetTextureRect();
        /*0x178e598*/ UnityEngine.Vector4 GetInnerUVs();
        /*0x178e634*/ UnityEngine.Vector4 GetOuterUVs();
        /*0x178e6d0*/ UnityEngine.Vector4 GetPadding();
        /*0x178e898*/ UnityEngine.Bounds get_bounds();
        /*0x178e944*/ UnityEngine.Rect get_rect();
        /*0x178e9e0*/ UnityEngine.Vector4 get_border();
        /*0x178ea7c*/ UnityEngine.Texture2D get_texture();
        /*0x178eab8*/ float get_pixelsPerUnit();
        /*0x178eaf4*/ UnityEngine.Texture2D get_associatedAlphaSplitTexture();
        /*0x178eb30*/ UnityEngine.Vector2 get_pivot();
        /*0x178ebc0*/ bool get_packed();
        /*0x178ec08*/ UnityEngine.SpritePackingMode get_packingMode();
        /*0x178ec44*/ UnityEngine.SpritePackingRotation get_packingRotation();
        /*0x178ec80*/ UnityEngine.Rect get_textureRect();
        /*0x178ed0c*/ UnityEngine.Vector2[] get_vertices();
        /*0x178ed48*/ ushort[] get_triangles();
        /*0x178ed84*/ UnityEngine.Vector2[] get_uv();
        /*0x178e554*/ void GetTextureRect_Injected(ref UnityEngine.Rect ret);
        /*0x178e5f0*/ void GetInnerUVs_Injected(ref UnityEngine.Vector4 ret);
        /*0x178e68c*/ void GetOuterUVs_Injected(ref UnityEngine.Vector4 ret);
        /*0x178e728*/ void GetPadding_Injected(ref UnityEngine.Vector4 ret);
        /*0x178e900*/ void get_bounds_Injected(ref UnityEngine.Bounds ret);
        /*0x178e99c*/ void get_rect_Injected(ref UnityEngine.Rect ret);
        /*0x178ea38*/ void get_border_Injected(ref UnityEngine.Vector4 ret);
        /*0x178eb7c*/ void get_pivot_Injected(ref UnityEngine.Vector2 ret);
    }

    namespace _Scripting
    {
        namespace APIUpdating
        {
            class APIUpdaterRuntimeHelpers
            {
                static /*0x178f2b4*/ bool GetMovedFromAttributeDataForType(System.Type sourceType, ref string assembly, ref string nsp, ref string klass);
                static /*0x178f3f4*/ bool GetObsoleteTypeRedirection(System.Type sourceType, ref string assemblyName, ref string nsp, ref string className);
            }
        }
    }

    namespace Sprites
    {
        class DataUtility
        {
            static /*0x178f6b0*/ UnityEngine.Vector4 GetInnerUV(UnityEngine.Sprite sprite);
            static /*0x178f6c0*/ UnityEngine.Vector4 GetOuterUV(UnityEngine.Sprite sprite);
            static /*0x178f6d0*/ UnityEngine.Vector4 GetPadding(UnityEngine.Sprite sprite);
            static /*0x178f6e0*/ UnityEngine.Vector2 GetMinSize(UnityEngine.Sprite sprite);
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
        }

        class SpriteAtlasManager
        {
            static /*0x0*/ System.Action<string, System.Action<UnityEngine.U2D.SpriteAtlas>> atlasRequested;
            static /*0x8*/ System.Action<UnityEngine.U2D.SpriteAtlas> atlasRegistered;

            static /*0x178f730*/ bool RequestAtlas(string tag);
            static /*0x178f7f0*/ void add_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value);
            static /*0x178f8c0*/ void remove_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value);
            static /*0x178f990*/ void PostRegisteredAtlas(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x178f9fc*/ void Register(UnityEngine.U2D.SpriteAtlas spriteAtlas);
        }

        class SpriteAtlas : UnityEngine.Object
        {
            /*0x178fa38*/ bool CanBindTo(UnityEngine.Sprite sprite);
        }
    }

    namespace Profiling
    {
        class Profiler
        {
            static /*0x178fa7c*/ void set_enabled(bool value);
            static /*0x178fab8*/ int GetRuntimeMemorySize(UnityEngine.Object o);
            static /*0x178faf8*/ long GetRuntimeMemorySizeLong(UnityEngine.Object o);
            static /*0x178fb34*/ uint GetMonoHeapSize();
            static /*0x178fb64*/ long GetMonoHeapSizeLong();
            static /*0x178fb8c*/ uint GetMonoUsedSize();
            static /*0x178fbbc*/ long GetMonoUsedSizeLong();
            static /*0x178fbe4*/ uint GetTotalAllocatedMemory();
            static /*0x178fc14*/ long GetTotalAllocatedMemoryLong();
            static /*0x178fc3c*/ uint GetTotalUnusedReservedMemory();
            static /*0x178fc6c*/ long GetTotalUnusedReservedMemoryLong();
            static /*0x178fc94*/ uint GetTotalReservedMemory();
            static /*0x178fcc4*/ long GetTotalReservedMemoryLong();
        }

        namespace Memory
        {
            namespace Experimental
            {
                class MetaData
                {
                    /*0x10*/ string content;
                    /*0x18*/ string platform;

                    /*0x178fcec*/ MetaData();
                }

                class MemoryProfiler
                {
                    static /*0x0*/ System.Action<string, bool> m_SnapshotFinished;
                    static /*0x8*/ System.Action<string, bool, UnityEngine.Profiling.Experimental.DebugScreenCapture> m_SaveScreenshotToDisk;
                    static /*0x10*/ System.Action<UnityEngine.Profiling.Memory.Experimental.MetaData> createMetaData;

                    static /*0x178fcf4*/ byte[] PrepareMetadata();
                    static /*0x178fe68*/ int WriteIntToByteArray(byte[] array, int offset, int value);
                    static /*0x178fef4*/ int WriteStringToByteArray(byte[] array, int offset, string value);
                    static /*0x178ff8c*/ void FinalizeSnapshot(string path, bool result);
                    static /*0x1790010*/ void SaveScreenshotToDisk(string path, bool result, nint pixelsPtr, int pixelsCount, UnityEngine.TextureFormat format, int width, int height);
                }
            }
        }

        namespace Experimental
        {
            struct DebugScreenCapture
            {
                /*0x10*/ Unity.Collections.NativeArray<byte> <rawImageDataReference>k__BackingField;
                /*0x20*/ UnityEngine.TextureFormat <imageFormat>k__BackingField;
                /*0x24*/ int <width>k__BackingField;
                /*0x28*/ int <height>k__BackingField;

                /*0x179010c*/ void set_rawImageDataReference(Unity.Collections.NativeArray<byte> value);
                /*0x1790114*/ void set_imageFormat(UnityEngine.TextureFormat value);
                /*0x179011c*/ void set_width(int value);
                /*0x1790124*/ void set_height(int value);
            }
        }
    }

    namespace Networking
    {
        namespace PlayerConnection
        {
            class PlayerEditorConnectionEvents
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers;
                /*0x18*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent;
                /*0x20*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent;

                /*0x1790a18*/ PlayerEditorConnectionEvents();
                /*0x179012c*/ void InvokeMessageIdSubscribers(System.Guid messageId, byte[] data, int playerId);
                /*0x17905e0*/ UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs> AddAndCreate(System.Guid messageId);
                /*0x17908a4*/ void UnregisterManagedCallback(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);

                class MessageEvent : UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs>
                {
                    /*0x179085c*/ MessageEvent();
                }

                class ConnectionChangeEvent : UnityEngine.Events.UnityEvent<int>
                {
                    /*0x1790ad8*/ ConnectionChangeEvent();
                }

                class MessageTypeSubscribers
                {
                    /*0x10*/ string m_messageTypeId;
                    /*0x18*/ int subscriberCount;
                    /*0x20*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageEvent messageCallback;

                    /*0x17907c8*/ MessageTypeSubscribers();
                    /*0x1790b20*/ System.Guid get_MessageTypeId();
                    /*0x1790830*/ void set_MessageTypeId(System.Guid value);
                }

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x17905d0*/ <>c__DisplayClass6_0();
                    /*0x1790b4c*/ bool <InvokeMessageIdSubscribers>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x17907c0*/ <>c__DisplayClass7_0();
                    /*0x1790b94*/ bool <AddAndCreate>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass8_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x1790a10*/ <>c__DisplayClass8_0();
                    /*0x1790bdc*/ bool <UnregisterManagedCallback>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }
            }

            class PlayerConnection : UnityEngine.ScriptableObject
            {
                static /*0x0*/ UnityEngine.IPlayerEditorConnectionNative connectionNative;
                static /*0x8*/ UnityEngine.Networking.PlayerConnection.PlayerConnection s_Instance;
                /*0x18*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents;
                /*0x20*/ System.Collections.Generic.List<int> m_connectedPlayers;
                /*0x28*/ bool m_IsInitilized;

                static /*0x1790c24*/ UnityEngine.Networking.PlayerConnection.PlayerConnection get_instance();
                static /*0x1790cbc*/ UnityEngine.Networking.PlayerConnection.PlayerConnection CreateInstance();
                static /*0x1791b34*/ void MessageCallbackInternal(nint data, ulong size, ulong guid, string messageId);
                static /*0x1791c4c*/ void ConnectedCallbackInternal(int playerId);
                static /*0x1791d28*/ void DisconnectedCallback(int playerId);
                /*0x1791dbc*/ PlayerConnection();
                /*0x1790d40*/ bool get_isConnected();
                /*0x1790e5c*/ void OnEnable();
                /*0x1790ddc*/ UnityEngine.IPlayerEditorConnectionNative GetConnectionNativeApi();
                /*0x1790f1c*/ void Register(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);
                /*0x1791168*/ void Unregister(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);
                /*0x1791318*/ void RegisterConnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x17914b8*/ void RegisterDisconnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x1791518*/ void UnregisterConnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x1791578*/ void UnregisterDisconnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x17915d8*/ void Send(System.Guid messageId, byte[] data);
                /*0x1791734*/ bool TrySend(System.Guid messageId, byte[] data);
                /*0x1791890*/ bool BlockUntilRecvMsg(System.Guid messageId, int timeout);
                /*0x1791a98*/ void DisconnectAll();

                class <>c__DisplayClass12_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x1791160*/ <>c__DisplayClass12_0();
                    /*0x1791e64*/ bool <Register>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x1791310*/ <>c__DisplayClass13_0();
                    /*0x1791eac*/ bool <Unregister>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ bool msgReceived;

                    /*0x1791a90*/ <>c__DisplayClass20_0();
                    /*0x1791ef4*/ void <BlockUntilRecvMsg>b__0(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
                }
            }

            class MessageEventArgs
            {
                /*0x10*/ int playerId;
                /*0x18*/ byte[] data;

                /*0x17905d8*/ MessageEventArgs();
            }
        }
    }

    namespace Assertions
    {
        class Assert
        {
            static /*0x0*/ bool raiseExceptions;

            static /*0x1792988*/ Assert();
            static /*0x1791f00*/ void IsTrue(bool condition);
            static /*0x1791f6c*/ void IsTrue(bool condition, string message);
            static /*0x17921a4*/ void IsFalse(bool condition, string message);
            static void IsNull<T>(T value);
            static void IsNull<T>(T value, string message);
            static /*0x1792224*/ void IsNull(UnityEngine.Object value, string message);
            static void IsNotNull<T>(T value);
            static void IsNotNull<T>(T value, string message);
            static /*0x1792448*/ void IsNotNull(UnityEngine.Object value, string message);
            static /*0x179207c*/ void Fail(string message, string userMessage);
            static void AreEqual<T>(T expected, T actual);
            static void AreEqual<T>(T expected, T actual, string message);
            static void AreEqual<T>(T expected, T actual, string message, System.Collections.Generic.IEqualityComparer<T> comparer);
            static /*0x1792578*/ void AreEqual(UnityEngine.Object expected, UnityEngine.Object actual, string message);
            static void AreNotEqual<T>(T expected, T actual);
            static void AreNotEqual<T>(T expected, T actual, string message);
            static void AreNotEqual<T>(T expected, T actual, string message, System.Collections.Generic.IEqualityComparer<T> comparer);
            static /*0x1792834*/ void AreNotEqual(UnityEngine.Object expected, UnityEngine.Object actual, string message);
            static /*0x17928fc*/ void AreEqual(int expected, int actual);
        }

        class AssertionMessageUtil
        {
            static /*0x17929d4*/ string GetMessage(string failureMessage);
            static /*0x1792ac0*/ string GetMessage(string failureMessage, string expected);
            static /*0x1792640*/ string GetEqualityMessage(object actual, object expected, bool expectEqual);
            static /*0x17922e0*/ string NullFailureMessage(object value, bool expectNull);
            static /*0x1791fec*/ string BooleanFailureMessage(bool expected);
        }

        class AssertionException : System.Exception
        {
            /*0x90*/ string m_UserMessage;

            /*0x1792504*/ AssertionException(string message, string userMessage);
            /*0x1792c18*/ string get_Message();
        }
    }

    namespace Scripting
    {
        class PreserveAttribute : System.Attribute
        {
            /*0x1792c8c*/ PreserveAttribute();
        }

        class RequireImplementorsAttribute : System.Attribute
        {
            /*0x1792c94*/ RequireImplementorsAttribute();
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

                /*0x1792c9c*/ void Set(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName);
            }

            class MovedFromAttribute : System.Attribute
            {
                /*0x10*/ UnityEngine.Scripting.APIUpdating.MovedFromAttributeData data;

                /*0x1792cd4*/ MovedFromAttribute(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName);
                /*0x1792d40*/ MovedFromAttribute(string sourceNamespace);
            }
        }
    }

    namespace Internal
    {
        class ExcludeFromDocsAttribute : System.Attribute
        {
            /*0x1792d84*/ ExcludeFromDocsAttribute();
        }

        class DefaultValueAttribute : System.Attribute
        {
            /*0x10*/ object DefaultValue;

            /*0x1792d8c*/ DefaultValueAttribute(string value);
            /*0x1792db4*/ object get_Value();
            /*0x1792dbc*/ bool Equals(object obj);
            /*0x1792e74*/ int GetHashCode();
        }
    }

    namespace Rendering
    {
        class OnDemandRendering
        {
            static /*0x0*/ int m_RenderFrameInterval;

            static /*0x1792f48*/ OnDemandRendering();
            static /*0x1792e98*/ int get_renderFrameInterval();
            static /*0x1792ef0*/ void GetRenderFrameInterval(ref int frameInterval);
        }

        class GraphicsSettings : UnityEngine.Object
        {
            static /*0x1792f94*/ bool get_lightsUseLinearIntensity();
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

        enum ShadowCastingMode
        {
            Off = 0,
            On = 1,
            TwoSided = 2,
            ShadowsOnly = 3,
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

        struct VertexAttributeDescriptor : System.IEquatable<UnityEngine.Rendering.VertexAttributeDescriptor>
        {
            /*0x10*/ UnityEngine.Rendering.VertexAttribute <attribute>k__BackingField;
            /*0x14*/ UnityEngine.Rendering.VertexAttributeFormat <format>k__BackingField;
            /*0x18*/ int <dimension>k__BackingField;
            /*0x1c*/ int <stream>k__BackingField;

            /*0x1792ffc*/ VertexAttributeDescriptor(UnityEngine.Rendering.VertexAttribute attribute, UnityEngine.Rendering.VertexAttributeFormat format, int dimension, int stream);
            /*0x1792fbc*/ UnityEngine.Rendering.VertexAttribute get_attribute();
            /*0x1792fc4*/ void set_attribute(UnityEngine.Rendering.VertexAttribute value);
            /*0x1792fcc*/ UnityEngine.Rendering.VertexAttributeFormat get_format();
            /*0x1792fd4*/ void set_format(UnityEngine.Rendering.VertexAttributeFormat value);
            /*0x1792fdc*/ int get_dimension();
            /*0x1792fe4*/ void set_dimension(int value);
            /*0x1792fec*/ int get_stream();
            /*0x1792ff4*/ void set_stream(int value);
            /*0x1793008*/ string ToString();
            /*0x17931dc*/ int GetHashCode();
            /*0x1793204*/ bool Equals(object other);
            /*0x17932ac*/ bool Equals(UnityEngine.Rendering.VertexAttributeDescriptor other);
        }

        enum ShadowSamplingMode
        {
            CompareDepths = 0,
            RawDepth = 1,
            None = 2,
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

        class RenderPipelineManager
        {
            static /*0x0*/ UnityEngine.Rendering.RenderPipelineAsset s_CurrentPipelineAsset;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.Camera> s_Cameras;
            static /*0x10*/ string s_currentPipelineType;
            static /*0x18*/ string s_builtinPipelineName;
            static /*0x20*/ UnityEngine.Rendering.RenderPipeline s_currentPipeline;
            static /*0x28*/ System.Action activeRenderPipelineTypeChanged;

            static /*0x1794078*/ RenderPipelineManager();
            static /*0x17932f0*/ UnityEngine.Rendering.RenderPipeline get_currentPipeline();
            static /*0x1793348*/ void set_currentPipeline(UnityEngine.Rendering.RenderPipeline value);
            static /*0x17933f8*/ void OnActiveRenderPipelineTypeChanged();
            static /*0x179346c*/ void HandleRenderPipelineChange(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset);
            static /*0x17934ec*/ void CleanupRenderPipeline();
            static /*0x17937d8*/ string GetCurrentPipelineAssetType();
            static /*0x1793830*/ void DoRenderLoop_Internal(UnityEngine.Rendering.RenderPipelineAsset pipe, nint loopPtr, System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests);
            static /*0x17939f8*/ void PrepareRenderPipeline(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset);
        }

        struct LODParameters : System.IEquatable<UnityEngine.Rendering.LODParameters>
        {
            /*0x10*/ int m_IsOrthographic;
            /*0x14*/ UnityEngine.Vector3 m_CameraPosition;
            /*0x20*/ float m_FieldOfView;
            /*0x24*/ float m_OrthoSize;
            /*0x28*/ int m_CameraPixelHeight;

            /*0x1794120*/ bool Equals(UnityEngine.Rendering.LODParameters other);
            /*0x17941bc*/ bool Equals(object obj);
            /*0x179424c*/ int GetHashCode();
        }

        struct ShaderTagId : System.IEquatable<UnityEngine.Rendering.ShaderTagId>
        {
            /*0x10*/ int m_Id;

            /*0x17942e0*/ ShaderTagId(string name);
            /*0x1794300*/ bool Equals(object obj);
            /*0x1794378*/ bool Equals(UnityEngine.Rendering.ShaderTagId other);
            /*0x1794388*/ int GetHashCode();
        }

        class RenderPipelineAsset : UnityEngine.ScriptableObject
        {
            /*0x1794550*/ RenderPipelineAsset();
            /*0x1793d80*/ UnityEngine.Rendering.RenderPipeline InternalCreatePipeline();
            /*0x17943a8*/ string[] get_renderingLayerMaskNames();
            /*0x17943b0*/ string[] get_prefixedRenderingLayerMaskNames();
            /*0x17943b8*/ UnityEngine.Material get_defaultMaterial();
            /*0x17943c0*/ UnityEngine.Shader get_autodeskInteractiveShader();
            /*0x17943c8*/ UnityEngine.Shader get_autodeskInteractiveTransparentShader();
            /*0x17943d0*/ UnityEngine.Shader get_autodeskInteractiveMaskedShader();
            /*0x17943d8*/ UnityEngine.Shader get_terrainDetailLitShader();
            /*0x17943e0*/ UnityEngine.Shader get_terrainDetailGrassShader();
            /*0x17943e8*/ UnityEngine.Shader get_terrainDetailGrassBillboardShader();
            /*0x17943f0*/ UnityEngine.Material get_defaultParticleMaterial();
            /*0x17943f8*/ UnityEngine.Material get_defaultLineMaterial();
            /*0x1794400*/ UnityEngine.Material get_defaultTerrainMaterial();
            /*0x1794408*/ UnityEngine.Material get_defaultUIMaterial();
            /*0x1794410*/ UnityEngine.Material get_defaultUIOverdrawMaterial();
            /*0x1794418*/ UnityEngine.Material get_defaultUIETC1SupportedMaterial();
            /*0x1794420*/ UnityEngine.Material get_default2DMaterial();
            /*0x1794428*/ UnityEngine.Material get_default2DMaskMaterial();
            /*0x1794430*/ UnityEngine.Shader get_defaultShader();
            /*0x1794438*/ UnityEngine.Shader get_defaultSpeedTree7Shader();
            /*0x1794440*/ UnityEngine.Shader get_defaultSpeedTree8Shader();
            UnityEngine.Rendering.RenderPipeline CreatePipeline();
            /*0x1794448*/ void OnValidate();
            /*0x1794504*/ void OnDisable();
        }

        class RenderPipeline
        {
            /*0x10*/ bool <disposed>k__BackingField;

            void Render(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera[] cameras);
            /*0x1794558*/ void ProcessRenderRequests(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests);
            /*0x179455c*/ void Render(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x1793bf8*/ void InternalRender(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras);
            /*0x1793c80*/ void InternalRenderWithRequests(UnityEngine.Rendering.ScriptableRenderContext context, System.Collections.Generic.List<UnityEngine.Camera> cameras, System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests);
            /*0x17945d4*/ bool get_disposed();
            /*0x17945dc*/ void set_disposed(bool value);
            /*0x1793674*/ void Dispose();
            /*0x17945e8*/ void Dispose(bool disposing);
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

            /*0x17945ec*/ void set_enabled(bool value);
            /*0x1794658*/ void set_readMask(byte value);
            /*0x1794660*/ void set_writeMask(byte value);
            /*0x1794668*/ void set_compareFunctionFront(UnityEngine.Rendering.CompareFunction value);
            /*0x1794670*/ void set_passOperationFront(UnityEngine.Rendering.StencilOp value);
            /*0x1794678*/ void set_failOperationFront(UnityEngine.Rendering.StencilOp value);
            /*0x1794680*/ void set_zFailOperationFront(UnityEngine.Rendering.StencilOp value);
            /*0x1794688*/ void set_compareFunctionBack(UnityEngine.Rendering.CompareFunction value);
            /*0x1794690*/ void set_passOperationBack(UnityEngine.Rendering.StencilOp value);
            /*0x1794698*/ void set_failOperationBack(UnityEngine.Rendering.StencilOp value);
            /*0x17946a0*/ void set_zFailOperationBack(UnityEngine.Rendering.StencilOp value);
            /*0x17946a8*/ bool Equals(UnityEngine.Rendering.StencilState other);
            /*0x1794758*/ bool Equals(object obj);
            /*0x17947d4*/ int GetHashCode();
        }

        struct ScriptableRenderContext : System.IEquatable<UnityEngine.Rendering.ScriptableRenderContext>
        {
            static /*0x0*/ UnityEngine.Rendering.ShaderTagId kRenderTypeTag;
            /*0x10*/ nint m_Ptr;

            static /*0x1794a94*/ ScriptableRenderContext();
            static /*0x1794a40*/ void GetCameras_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, System.Type listType, object resultList);
            /*0x1793b64*/ ScriptableRenderContext(nint ptr);
            /*0x1793b6c*/ void GetCameras(System.Collections.Generic.List<UnityEngine.Camera> results);
            /*0x1794950*/ bool Equals(UnityEngine.Rendering.ScriptableRenderContext other);
            /*0x17949c0*/ bool Equals(object obj);
            /*0x1794a38*/ int GetHashCode();
            /*0x17948c4*/ void GetCameras_Internal(System.Type listType, object resultList);
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
            /*0x34*/ bool <rendererProbes>k__BackingField;
            /*0x35*/ bool <particleSystemInstancing>k__BackingField;
            /*0x36*/ bool <autoAmbientProbeBaking>k__BackingField;
            /*0x37*/ bool <autoDefaultReflectionProbeBaking>k__BackingField;
            /*0x38*/ bool <overridesShadowmask>k__BackingField;
            /*0x40*/ string <overrideShadowmaskMessage>k__BackingField;

            static /*0x1795284*/ SupportedRenderingFeatures();
            static /*0x1794afc*/ UnityEngine.Rendering.SupportedRenderingFeatures get_active();
            static /*0x179377c*/ void set_active(UnityEngine.Rendering.SupportedRenderingFeatures value);
            static /*0x1794bec*/ void FallbackMixedLightingModeByRef(nint fallbackModePtr);
            static /*0x1794d20*/ bool IsMixedLightingModeSupported(UnityEngine.MixedLightingMode mixedMode);
            static /*0x1794d8c*/ void IsMixedLightingModeSupportedByRef(UnityEngine.MixedLightingMode mixedMode, nint isSupportedPtr);
            static /*0x1794e94*/ bool IsLightmapBakeTypeSupported(UnityEngine.LightmapBakeType bakeType);
            static /*0x1794f00*/ void IsLightmapBakeTypeSupportedByRef(UnityEngine.LightmapBakeType bakeType, nint isSupportedPtr);
            static /*0x1794ff0*/ void IsLightmapsModeSupportedByRef(UnityEngine.LightmapsMode mode, nint isSupportedPtr);
            static /*0x179507c*/ void IsLightmapperSupportedByRef(int lightmapper, nint isSupportedPtr);
            static /*0x1795100*/ void IsUIOverlayRenderedBySRP(nint isSupportedPtr);
            static /*0x1795178*/ void IsAutoAmbientProbeBakingSupported(nint isSupportedPtr);
            static /*0x17951f0*/ void IsAutoDefaultReflectionProbeBakingSupported(nint isSupportedPtr);
            static /*0x1795268*/ void FallbackLightmapperByRef(nint lightmapperPtr);
            /*0x17936ec*/ SupportedRenderingFeatures();
            /*0x1794ba4*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_defaultMixedLightingModes();
            /*0x1794bac*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_mixedLightingModes();
            /*0x1794bb4*/ UnityEngine.LightmapBakeType get_lightmapBakeTypes();
            /*0x1794bbc*/ UnityEngine.LightmapsMode get_lightmapsModes();
            /*0x1794bc4*/ bool get_enlightenLightmapper();
            /*0x1794bcc*/ bool get_enlighten();
            /*0x1794bd4*/ bool get_rendersUIOverlay();
            /*0x1794bdc*/ bool get_autoAmbientProbeBaking();
            /*0x1794be4*/ bool get_autoDefaultReflectionProbeBaking();

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

        struct BatchVisibility
        {
            /*0x10*/ int offset;
            /*0x14*/ int instancesCount;
            /*0x18*/ int visibleCount;
        }

        struct BatchCullingContext
        {
            /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Plane> cullingPlanes;
            /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.BatchVisibility> batchVisibility;
            /*0x30*/ Unity.Collections.NativeArray<int> visibleIndices;
            /*0x40*/ Unity.Collections.NativeArray<int> visibleIndicesY;
            /*0x50*/ UnityEngine.Rendering.LODParameters lodParameters;
            /*0x6c*/ UnityEngine.Matrix4x4 cullingMatrix;
            /*0xac*/ float nearPlane;

            /*0x17952e4*/ BatchCullingContext(Unity.Collections.NativeArray<UnityEngine.Plane> inCullingPlanes, Unity.Collections.NativeArray<UnityEngine.Rendering.BatchVisibility> inOutBatchVisibility, Unity.Collections.NativeArray<int> outVisibleIndices, Unity.Collections.NativeArray<int> outVisibleIndicesY, UnityEngine.Rendering.LODParameters inLodParameters, UnityEngine.Matrix4x4 inCullingMatrix, float inNearPlane);
        }

        struct BatchRendererCullingOutput
        {
            /*0x10*/ Unity.Jobs.JobHandle cullingJobsFence;
            /*0x20*/ UnityEngine.Matrix4x4 cullingMatrix;
            /*0x60*/ UnityEngine.Plane* cullingPlanes;
            /*0x68*/ UnityEngine.Rendering.BatchVisibility* batchVisibility;
            /*0x70*/ int* visibleIndices;
            /*0x78*/ int* visibleIndicesY;
            /*0x80*/ int cullingPlanesCount;
            /*0x84*/ int batchVisibilityCount;
            /*0x88*/ int visibleIndicesCount;
            /*0x8c*/ float nearPlane;
        }

        class BatchRendererGroup
        {
            /*0x10*/ nint m_GroupHandle;
            /*0x18*/ UnityEngine.Rendering.BatchRendererGroup.OnPerformCulling m_PerformCulling;

            static /*0x1795338*/ void InvokeOnPerformCulling(UnityEngine.Rendering.BatchRendererGroup group, ref UnityEngine.Rendering.BatchRendererCullingOutput context, ref UnityEngine.Rendering.LODParameters lodParameters);

            class OnPerformCulling : System.MulticastDelegate
            {
                /*0x1795558*/ OnPerformCulling(object object, nint method);
                /*0x1795688*/ Unity.Jobs.JobHandle Invoke(UnityEngine.Rendering.BatchRendererGroup rendererGroup, UnityEngine.Rendering.BatchCullingContext cullingContext);
            }
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
    }

    namespace SceneManagement
    {
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

            /*0x17956e4*/ LoadSceneParameters(UnityEngine.SceneManagement.LoadSceneMode mode);
        }

        class SceneManager
        {
            static /*0x0*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> sceneLoaded;
            static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> sceneUnloaded;
            static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> activeSceneChanged;
            static /*0x18*/ bool s_AllowLoadScene;

            static /*0x17960ec*/ SceneManager();
            static /*0x17956ec*/ void add_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> value);
            static /*0x17957dc*/ void remove_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> value);
            static /*0x17958cc*/ void add_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> value);
            static /*0x17959c0*/ void remove_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> value);
            static /*0x178b61c*/ void LoadScene(int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneMode mode);
            static /*0x1795ab4*/ UnityEngine.SceneManagement.Scene LoadScene(int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters);
            static /*0x1795ce4*/ void Internal_SceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            static /*0x1795d94*/ void Internal_SceneUnloaded(UnityEngine.SceneManagement.Scene scene);
            static /*0x1795e30*/ void Internal_ActiveSceneChanged(UnityEngine.SceneManagement.Scene previousActiveScene, UnityEngine.SceneManagement.Scene newActiveScene);
            static /*0x1795c30*/ int get_sceneCount();
            static /*0x1795ee0*/ UnityEngine.SceneManagement.Scene GetActiveScene();
            static /*0x1795c58*/ UnityEngine.SceneManagement.Scene GetSceneAt(int index);
            static /*0x1795b54*/ UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            static /*0x1796084*/ UnityEngine.AsyncOperation LoadFirstScene_Internal(bool async);
            static /*0x1795f5c*/ void GetActiveScene_Injected(ref UnityEngine.SceneManagement.Scene ret);
            static /*0x1795f98*/ void GetSceneAt_Injected(int index, ref UnityEngine.SceneManagement.Scene ret);
        }

        struct Scene
        {
            /*0x10*/ int m_Handle;

            static /*0x1796138*/ bool IsValidInternal(int sceneHandle);
            static /*0x1796174*/ string GetNameInternal(int sceneHandle);
            static /*0x17961b0*/ bool GetIsLoadedInternal(int sceneHandle);
            static /*0x17961ec*/ int GetRootCountInternal(int sceneHandle);
            static /*0x1796228*/ void GetRootGameObjectsInternal(int sceneHandle, object resultRootList);
            /*0x179626c*/ int get_handle();
            /*0x1796274*/ bool IsValid();
            /*0x17962b0*/ string get_name();
            /*0x17962ec*/ bool get_isLoaded();
            /*0x1796328*/ int get_rootCount();
            /*0x1796364*/ UnityEngine.GameObject[] GetRootGameObjects();
            /*0x179643c*/ void GetRootGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> rootGameObjects);
            /*0x17966b0*/ int GetHashCode();
            /*0x17966b8*/ bool Equals(object other);
        }

        class SceneManagerAPIInternal
        {
            static /*0x1796730*/ UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            static /*0x1796790*/ UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
        }

        class SceneManagerAPI
        {
            static /*0x0*/ UnityEngine.SceneManagement.SceneManagerAPI s_DefaultAPI;
            static /*0x8*/ UnityEngine.SceneManagement.SceneManagerAPI <overrideAPI>k__BackingField;

            static /*0x17968b4*/ SceneManagerAPI();
            static /*0x1795fdc*/ UnityEngine.SceneManagement.SceneManagerAPI get_ActiveAPI();
            static /*0x17967ec*/ UnityEngine.SceneManagement.SceneManagerAPI get_overrideAPI();
            /*0x1796844*/ SceneManagerAPI();
            /*0x179684c*/ UnityEngine.AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            /*0x17968ac*/ UnityEngine.AsyncOperation LoadFirstScene(bool mustLoadAsync);
        }
    }

    namespace Serialization
    {
        class FormerlySerializedAsAttribute : System.Attribute
        {
            /*0x10*/ string m_oldName;

            /*0x1796918*/ FormerlySerializedAsAttribute(string oldName);
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

                static /*0x1796b74*/ UnityEngine.Experimental.GlobalIllumination.LinearColor Convert(UnityEngine.Color color, float intensity);
                static /*0x1796f48*/ UnityEngine.Experimental.GlobalIllumination.LinearColor Black();
                /*0x1796940*/ float get_red();
                /*0x1796948*/ void set_red(float value);
                /*0x17969fc*/ float get_green();
                /*0x1796a04*/ void set_green(float value);
                /*0x1796ab8*/ float get_blue();
                /*0x1796ac0*/ void set_blue(float value);
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

                /*0x1796f5c*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x1796fc4*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.PointLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x1797034*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.SpotLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x17970ac*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.RectangleLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x179711c*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DiscLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0x179718c*/ void InitNoBake(int lightInstanceID);
            }

            class LightmapperUtils
            {
                static /*0x179719c*/ UnityEngine.Experimental.GlobalIllumination.LightMode Extract(UnityEngine.LightmapBakeType baketype);
                static /*0x17971bc*/ UnityEngine.Experimental.GlobalIllumination.LinearColor ExtractIndirect(UnityEngine.Light l);
                static /*0x1797234*/ float ExtractInnerCone(UnityEngine.Light l);
                static /*0x1797288*/ UnityEngine.Color ExtractColorTemperature(UnityEngine.Light l);
                static /*0x179731c*/ void ApplyColorTemperature(UnityEngine.Color cct, ref UnityEngine.Experimental.GlobalIllumination.LinearColor lightColor);
                static /*0x1797364*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight dir);
                static /*0x17974f4*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.PointLight point);
                static /*0x179769c*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.SpotLight spot);
                static /*0x179786c*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.RectangleLight rect);
                static /*0x1797a14*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.DiscLight disc);
                static /*0x1797bbc*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
            }

            class Lightmapping
            {
                static /*0x0*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate s_DefaultDelegate;
                static /*0x8*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate s_RequestLightsDelegate;

                static /*0x1797ef8*/ Lightmapping();
                static /*0x1797d00*/ void SetDelegate(UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate del);
                static /*0x1797d78*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate GetDelegate();
                static /*0x1797dd0*/ void ResetDelegate();
                static /*0x1797e2c*/ void RequestLights(UnityEngine.Light[] lights, nint outLightsPtr, int outLightsCount);

                class RequestLightsDelegate : System.MulticastDelegate
                {
                    /*0x1797fc8*/ RequestLightsDelegate(object object, nint method);
                    /*0x17980a0*/ void Invoke(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.<> <>9;

                    static /*0x17980b4*/ <>c();
                    /*0x1798118*/ <>c();
                    /*0x1798120*/ void <.cctor>b__7_0(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }
            }
        }

        namespace Rendering
        {
            class GraphicsFormatUtility
            {
                static /*0x0*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] tableNoStencil;
                static /*0x8*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] tableStencil;

                static /*0x1798ce4*/ GraphicsFormatUtility();
                static /*0x17985e0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.TextureFormat format, bool isSRGB);
                static /*0x1798664*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_TextureFormat(UnityEngine.TextureFormat format, bool isSRGB);
                static /*0x17986a8*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, bool isSRGB);
                static /*0x179872c*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(UnityEngine.RenderTextureFormat format, bool isSRGB);
                static /*0x1798770*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
                static /*0x17987f8*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits);
                static /*0x1798834*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormat(int minimumDepthBits);
                static /*0x17988a8*/ int GetDepthBits(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x17988e4*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits);
                static /*0x1798ad8*/ bool IsSRGBFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1798b14*/ bool IsCompressedTextureFormat(UnityEngine.TextureFormat format);
                static /*0x1798b50*/ bool CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, bool wholeImage);
                static /*0x1798b94*/ bool CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1798c0c*/ bool IsDepthFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1798c48*/ bool IsStencilFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1798c84*/ bool IsPVRTCFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1798cc0*/ bool IsCrunchFormat(UnityEngine.TextureFormat format);
            }

            enum TextureCreationFlags
            {
                None = 0,
                MipChain = 1,
                Crunch = 64,
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
            }

            class ScriptableRuntimeReflectionSystemSettings
            {
                static /*0x0*/ UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper s_Instance;

                static /*0x1798fbc*/ ScriptableRuntimeReflectionSystemSettings();
                static /*0x1798df4*/ void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value);
                static /*0x1798f3c*/ UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance();
                static /*0x1798f94*/ void ScriptingDirtyReflectionSystemInstance();
            }

            interface IScriptableRuntimeReflectionSystem : System.IDisposable
            {
                bool TickRealtimeProbes();
            }

            class ScriptableRuntimeReflectionSystemWrapper
            {
                /*0x10*/ UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem <implementation>k__BackingField;

                /*0x1799034*/ ScriptableRuntimeReflectionSystemWrapper();
                /*0x179903c*/ UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem get_implementation();
                /*0x1799044*/ void set_implementation(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value);
                /*0x179904c*/ void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(ref bool result);
            }

            class BuiltinRuntimeReflectionSystem : UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem, System.IDisposable
            {
                static /*0x1799128*/ bool BuiltinUpdate();
                static /*0x1799158*/ UnityEngine.Experimental.Rendering.BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New();
                /*0x17991b4*/ BuiltinRuntimeReflectionSystem();
                /*0x1799100*/ bool TickRealtimeProbes();
                /*0x1799150*/ void Dispose();
                /*0x1799154*/ void Dispose(bool disposing);
            }
        }

        namespace Playables
        {
            struct MaterialEffectPlayable : System.IEquatable<UnityEngine.Experimental.Playables.MaterialEffectPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x17991bc*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x17991c8*/ bool Equals(UnityEngine.Experimental.Playables.MaterialEffectPlayable other);
            }

            struct CameraPlayable : System.IEquatable<UnityEngine.Experimental.Playables.CameraPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x17992c4*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x17992d0*/ bool Equals(UnityEngine.Experimental.Playables.CameraPlayable other);
            }

            struct TexturePlayableOutput
            {
                /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;
            }

            struct TextureMixerPlayable : System.IEquatable<UnityEngine.Experimental.Playables.TextureMixerPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0x1799344*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0x1799350*/ bool Equals(UnityEngine.Experimental.Playables.TextureMixerPlayable other);
            }
        }
    }

    namespace Playables
    {
        struct PlayableOutputHandle : System.IEquatable<UnityEngine.Playables.PlayableOutputHandle>
        {
            static /*0x0*/ UnityEngine.Playables.PlayableOutputHandle m_Null;
            /*0x10*/ nint m_Handle;
            /*0x18*/ uint m_Version;

            static /*0x1799604*/ PlayableOutputHandle();
            static /*0x17993c4*/ UnityEngine.Playables.PlayableOutputHandle get_Null();
            static /*0x1799450*/ bool op_Equality(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs);
            static /*0x17994d8*/ bool CompareVersion(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs);
            /*0x179941c*/ int GetHashCode();
            /*0x179950c*/ bool Equals(object p);
            /*0x1799584*/ bool Equals(UnityEngine.Playables.PlayableOutputHandle other);
        }

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

        class PlayableAsset : UnityEngine.ScriptableObject
        {
            static /*0x17996fc*/ void Internal_CreatePlayable(UnityEngine.Playables.PlayableAsset asset, UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, nint ptr);
            static /*0x179982c*/ void Internal_GetPlayableAssetDuration(UnityEngine.Playables.PlayableAsset asset, nint ptrToDouble);
            /*0x1799854*/ PlayableAsset();
            UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
            /*0x179964c*/ double get_duration();
            /*0x17996a4*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
        }

        struct ScriptPlayableOutput
        {
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;
        }

        class PlayableBehaviour : UnityEngine.Playables.IPlayableBehaviour, System.ICloneable
        {
            /*0x179985c*/ PlayableBehaviour();
            /*0x1799864*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x1799868*/ void OnGraphStop(UnityEngine.Playables.Playable playable);
            /*0x179986c*/ void OnPlayableCreate(UnityEngine.Playables.Playable playable);
            /*0x1799870*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x1799874*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x1799878*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x179987c*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x1799880*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
            /*0x1799884*/ object Clone();
        }

        struct Playable : System.IEquatable<UnityEngine.Playables.Playable>
        {
            static /*0x0*/ UnityEngine.Playables.Playable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x1799914*/ Playable();
            static /*0x17997d4*/ UnityEngine.Playables.Playable get_Null();
            /*0x179988c*/ Playable(UnityEngine.Playables.PlayableHandle handle);
            /*0x1799894*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0x17998a0*/ bool Equals(UnityEngine.Playables.Playable other);
        }

        struct PlayableBinding
        {
            static /*0x0*/ UnityEngine.Playables.PlayableBinding[] None;
            static /*0x8*/ double DefaultDuration;
            /*0x10*/ string m_StreamName;
            /*0x18*/ UnityEngine.Object m_SourceObject;
            /*0x20*/ System.Type m_SourceBindingType;
            /*0x28*/ UnityEngine.Playables.PlayableBinding.CreateOutputMethod m_CreateOutputMethod;

            static /*0x17999dc*/ PlayableBinding();

            class CreateOutputMethod : System.MulticastDelegate
            {
                /*0x1799a54*/ CreateOutputMethod(object object, nint method);
                /*0x1799b18*/ UnityEngine.Playables.PlayableOutput Invoke(UnityEngine.Playables.PlayableGraph graph, string name);
            }
        }

        struct PlayableGraph
        {
            /*0x10*/ nint m_Handle;
            /*0x18*/ uint m_Version;
        }

        interface INotificationReceiver
        {
            void OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, object context);
        }

        struct PlayableOutput : System.IEquatable<UnityEngine.Playables.PlayableOutput>
        {
            static /*0x0*/ UnityEngine.Playables.PlayableOutput m_NullPlayableOutput;
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x1799bb4*/ PlayableOutput();
            /*0x1799b2c*/ PlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0x1799b34*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            /*0x1799b40*/ bool Equals(UnityEngine.Playables.PlayableOutput other);
        }

        struct PlayableHandle : System.IEquatable<UnityEngine.Playables.PlayableHandle>
        {
            static /*0x0*/ UnityEngine.Playables.PlayableHandle m_Null;
            /*0x10*/ nint m_Handle;
            /*0x18*/ uint m_Version;

            static /*0x1799ee4*/ PlayableHandle();
            static /*0x1799984*/ UnityEngine.Playables.PlayableHandle get_Null();
            static /*0x179923c*/ bool op_Equality(UnityEngine.Playables.PlayableHandle x, UnityEngine.Playables.PlayableHandle y);
            static /*0x1799c24*/ bool CompareVersion(UnityEngine.Playables.PlayableHandle lhs, UnityEngine.Playables.PlayableHandle rhs);
            static /*0x1799df8*/ bool IsValid_Injected(ref UnityEngine.Playables.PlayableHandle _unity_self);
            static /*0x1799ea8*/ System.Type GetPlayableType_Injected(ref UnityEngine.Playables.PlayableHandle _unity_self);
            bool IsPlayableOfType<T>();
            /*0x1799c58*/ bool Equals(object p);
            /*0x1799cd0*/ bool Equals(UnityEngine.Playables.PlayableHandle other);
            /*0x1799d50*/ int GetHashCode();
            /*0x1799d84*/ bool IsValid();
            /*0x1799e34*/ System.Type GetPlayableType();
        }

        interface IPlayableBehaviour
        {
            void OnGraphStart(UnityEngine.Playables.Playable playable);
            void OnGraphStop(UnityEngine.Playables.Playable playable);
            void OnPlayableCreate(UnityEngine.Playables.Playable playable);
            void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
        }
    }

    namespace Pool
    {
        class CollectionPool<TCollection, TItem>
        {
            static /*0x0*/ UnityEngine.Pool.ObjectPool<TCollection> s_Pool;

            static CollectionPool();
            static TCollection Get();
            static void Release(TCollection toRelease);

            class <>c<TCollection, TItem>
            {
                static /*0x0*/ UnityEngine.Pool.CollectionPool.<>c<TCollection, TItem> <>9;

                static <>c();
                <>c();
                TCollection <.cctor>b__5_0();
                void <.cctor>b__5_1(TCollection l);
            }
        }

        class ObjectPool<T> : System.IDisposable
        {
            /*0x0*/ System.Collections.Generic.Stack<T> m_Stack;
            /*0x0*/ System.Func<T> m_CreateFunc;
            /*0x0*/ System.Action<T> m_ActionOnGet;
            /*0x0*/ System.Action<T> m_ActionOnRelease;
            /*0x0*/ System.Action<T> m_ActionOnDestroy;
            /*0x0*/ int m_MaxSize;
            /*0x0*/ bool m_CollectionCheck;
            /*0x0*/ int <CountAll>k__BackingField;

            ObjectPool(System.Func<T> createFunc, System.Action<T> actionOnGet, System.Action<T> actionOnRelease, System.Action<T> actionOnDestroy, bool collectionCheck, int defaultCapacity, int maxSize);
            int get_CountAll();
            void set_CountAll(int value);
            int get_CountInactive();
            T Get();
            void Release(T element);
            void Clear();
            void Dispose();
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
            static /*0x1799f2c*/ string TidyAssemblyTypeName(string assemblyTypeName);
        }

        class ArgumentCache : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Object m_ObjectArgument;
            /*0x18*/ string m_ObjectArgumentAssemblyTypeName;
            /*0x20*/ int m_IntArgument;
            /*0x24*/ float m_FloatArgument;
            /*0x28*/ string m_StringArgument;
            /*0x30*/ bool m_BoolArgument;

            /*0x179a1bc*/ ArgumentCache();
            /*0x179a154*/ UnityEngine.Object get_unityObjectArgument();
            /*0x179a15c*/ string get_unityObjectArgumentAssemblyTypeName();
            /*0x179a164*/ int get_intArgument();
            /*0x179a16c*/ float get_floatArgument();
            /*0x179a174*/ string get_stringArgument();
            /*0x179a17c*/ bool get_boolArgument();
            /*0x179a184*/ void OnBeforeSerialize();
            /*0x179a1a0*/ void OnAfterDeserialize();
        }

        class BaseInvokableCall
        {
            static void ThrowOnInvalidArg<T>(object arg);
            static /*0x179a2b4*/ bool AllowInvoke(System.Delegate delegate);
            /*0x179a1c4*/ BaseInvokableCall();
            /*0x179a1cc*/ BaseInvokableCall(object target, System.Reflection.MethodInfo function);
            void Invoke(object[] args);
            bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall : UnityEngine.Events.BaseInvokableCall
        {
            /*0x10*/ UnityEngine.Events.UnityAction Delegate;

            /*0x179a494*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x179a57c*/ InvokableCall(UnityEngine.Events.UnityAction action);
            /*0x179a35c*/ void add_Delegate(UnityEngine.Events.UnityAction value);
            /*0x179a3f8*/ void remove_Delegate(UnityEngine.Events.UnityAction value);
            /*0x179a5a8*/ void Invoke(object[] args);
            /*0x179a5e4*/ void Invoke();
            /*0x179a620*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1> Delegate;

            InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            InvokableCall(UnityEngine.Events.UnityAction<T1> action);
            void add_Delegate(UnityEngine.Events.UnityAction<T1> value);
            void remove_Delegate(UnityEngine.Events.UnityAction<T1> value);
            void Invoke(object[] args);
            void Invoke(T1 args0);
            bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2> Delegate;

            InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            void Invoke(object[] args);
            bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2, T3> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2, T3> Delegate;

            InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            void Invoke(object[] args);
            void Invoke(T1 args0, T2 args1, T3 args2);
            bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2, T3, T4> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2, T3, T4> Delegate;

            InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            void Invoke(object[] args);
            bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class CachedInvokableCall<T> : UnityEngine.Events.InvokableCall<T>
        {
            /*0x0*/ T m_Arg1;

            CachedInvokableCall(UnityEngine.Object target, System.Reflection.MethodInfo theFunction, T argument);
            void Invoke(object[] args);
            void Invoke(T arg0);
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

            static /*0x179ac24*/ UnityEngine.Events.BaseInvokableCall GetObjectCall(UnityEngine.Object target, System.Reflection.MethodInfo method, UnityEngine.Events.ArgumentCache arguments);
            /*0x179b08c*/ PersistentCall();
            /*0x179a66c*/ UnityEngine.Object get_target();
            /*0x179a674*/ string get_targetAssemblyTypeName();
            /*0x179a720*/ string get_methodName();
            /*0x179a728*/ UnityEngine.Events.PersistentListenerMode get_mode();
            /*0x179a730*/ UnityEngine.Events.ArgumentCache get_arguments();
            /*0x179a738*/ bool IsValid();
            /*0x179a774*/ UnityEngine.Events.BaseInvokableCall GetRuntimeCall(UnityEngine.Events.UnityEventBase theEvent);
            /*0x179b054*/ void OnBeforeSerialize();
            /*0x179b070*/ void OnAfterDeserialize();
        }

        class PersistentCallGroup
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Events.PersistentCall> m_Calls;

            /*0x179b100*/ PersistentCallGroup();
            /*0x179b180*/ void Initialize(UnityEngine.Events.InvokableCallList invokableList, UnityEngine.Events.UnityEventBase unityEventBase);
        }

        class InvokableCallList
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_PersistentCalls;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_RuntimeCalls;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_ExecutingCalls;
            /*0x28*/ bool m_NeedsUpdate;

            /*0x179b900*/ InvokableCallList();
            /*0x179b310*/ void AddPersistentInvokableCall(UnityEngine.Events.BaseInvokableCall call);
            /*0x179b3bc*/ void AddListener(UnityEngine.Events.BaseInvokableCall call);
            /*0x179b468*/ void RemoveListener(object targetObj, System.Reflection.MethodInfo method);
            /*0x179b6dc*/ void Clear();
            /*0x179b794*/ void ClearPersistent();
            /*0x179b84c*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke();
        }

        class UnityEventBase : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Events.InvokableCallList m_Calls;
            /*0x18*/ UnityEngine.Events.PersistentCallGroup m_PersistentCalls;
            /*0x20*/ bool m_CallsDirty;

            static /*0x179bcf0*/ System.Reflection.MethodInfo GetValidMethodInfo(System.Type objectType, string functionName, System.Type[] argumentTypes);
            /*0x179b9c4*/ UnityEventBase();
            /*0x179ba60*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x179ba8c*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x179aa5c*/ System.Reflection.MethodInfo FindMethod(UnityEngine.Events.PersistentCall call);
            /*0x179ba90*/ System.Reflection.MethodInfo FindMethod(string name, System.Type listenerType, UnityEngine.Events.PersistentListenerMode mode, System.Type argumentType);
            /*0x179ba64*/ void DirtyPersistentCalls();
            /*0x179be94*/ void RebuildPersistentCallsIfNeeded();
            /*0x179bec8*/ void AddCall(UnityEngine.Events.BaseInvokableCall call);
            /*0x179bee0*/ void RemoveListener(object targetObj, System.Reflection.MethodInfo method);
            /*0x179bef8*/ void RemoveAllListeners();
            /*0x179bf10*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke();
            /*0x179bf30*/ string ToString();
        }

        class UnityAction<T0, T1> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            void Invoke(T0 arg0, T1 arg1);
        }

        class UnityEvent<T0, T1> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            UnityEvent();
            System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
        }

        class UnityAction<T0> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            void Invoke(T0 arg0);
        }

        class UnityEvent<T0> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            static UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0> action);
            UnityEvent();
            void AddListener(UnityEngine.Events.UnityAction<T0> call);
            void RemoveListener(UnityEngine.Events.UnityAction<T0> call);
            System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            void Invoke(T0 arg0);
        }

        class UnityAction<T0, T1, T2> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            void Invoke(T0 arg0, T1 arg1, T2 arg2);
        }

        class UnityEvent<T0, T1, T2> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            UnityEvent();
            System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            void Invoke(T0 arg0, T1 arg1, T2 arg2);
        }

        class UnityAction<T0, T1, T2, T3> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3);
        }

        class UnityEvent<T0, T1, T2, T3> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            UnityEvent();
            System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
        }

        class UnityAction : System.MulticastDelegate
        {
            /*0x18b140c*/ UnityAction(object object, nint method);
            /*0x18b14c8*/ void Invoke();
        }

        class UnityEvent : UnityEngine.Events.UnityEventBase
        {
            /*0x28*/ object[] m_InvokeArray;

            static /*0x18b150c*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction action);
            /*0x18b14dc*/ UnityEvent();
            /*0x18b14e8*/ void AddListener(UnityEngine.Events.UnityAction call);
            /*0x18b1570*/ void RemoveListener(UnityEngine.Events.UnityAction call);
            /*0x18b15b0*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x18b1618*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x18b168c*/ void Invoke();
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

            /*0x18b1814*/ string ToString();

            class UpdateFunction : System.MulticastDelegate
            {
                /*0x18b1834*/ UpdateFunction(object object, nint method);
                /*0x18b18f0*/ void Invoke();
            }
        }

        class PlayerLoop
        {
            static /*0x18b1904*/ UnityEngine.LowLevel.PlayerLoopSystem GetCurrentPlayerLoop();
            static /*0x18b1ba0*/ void SetPlayerLoop(UnityEngine.LowLevel.PlayerLoopSystem loop);
            static /*0x18b1c84*/ int PlayerLoopSystemToInternal(UnityEngine.LowLevel.PlayerLoopSystem sys, ref System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystemInternal> internalSys);
            static /*0x18b19a0*/ UnityEngine.LowLevel.PlayerLoopSystem InternalToPlayerLoopSystem(UnityEngine.LowLevel.PlayerLoopSystemInternal[] internalSys, ref int offset);
            static /*0x18b1978*/ UnityEngine.LowLevel.PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal();
            static /*0x18b1e28*/ void SetPlayerLoopInternal(UnityEngine.LowLevel.PlayerLoopSystemInternal[] loop);
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

            struct UNetUpdate
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
        }
    }
}
