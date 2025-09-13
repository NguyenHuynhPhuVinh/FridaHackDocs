class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x1e122e4*/ EmbeddedAttribute();
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
                /*0x1e14e38*/ IsReadOnlyAttribute();
            }
        }
    }
}

namespace AOT
{
    class MonoPInvokeCallbackAttribute : System.Attribute
    {
        /*0x1e1f698*/ MonoPInvokeCallbackAttribute(System.Type type);
    }
}

namespace UnityEngineInternal
{
    struct MathfInternal
    {
        static /*0x0*/ float FloatMinNormal;
        static /*0x4*/ float FloatMinDenormal;
        static /*0x8*/ bool IsFlushToZeroEnabled;

        static /*0x1e1b1ec*/ MathfInternal();
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

        /*0x1892654*/ TypeInferenceRuleAttribute(UnityEngineInternal.TypeInferenceRules rule);
        /*0x18926ec*/ TypeInferenceRuleAttribute(string rule);
        /*0x1892718*/ string ToString();
    }

    class GenericStack : System.Collections.Stack
    {
        /*0x1e12e04*/ GenericStack();
    }
}

namespace Unity
{
    namespace Profiling
    {
        struct ProfilerMarker
        {
            /*0x10*/ nint m_Ptr;

            /*0xacbf5c*/ ProfilerMarker(string name);
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
            }

            namespace Unsafe
            {
                class ProfilerUnsafeUtility
                {
                    static /*0x187e8bc*/ nint CreateMarker(string name, ushort categoryId, Unity.Profiling.LowLevel.MarkerFlags flags, int metadataCount);
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

            static /*0x1e0aebc*/ void ScheduleBatchedJobs();
        }

        namespace LowLevel
        {
            namespace Unsafe
            {
                class JobsUtility
                {
                    static /*0x0*/ Unity.Jobs.LowLevel.Unsafe.JobsUtility.PanicFunction_ PanicFunction;

                    static /*0x1e14e40*/ void InvokePanicFunction();

                    class PanicFunction_ : System.MulticastDelegate
                    {
                        /*0x2a957c4*/ PanicFunction_(object object, nint method);
                        /*0x2a95824*/ void Invoke();
                        /*0x2a95a30*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                        /*0x2a95a5c*/ void EndInvoke(System.IAsyncResult result);
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
                /*0x1e1462c*/ Il2CppEagerStaticClassConstructionAttribute();
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

        enum Allocator
        {
            Invalid = 0,
            None = 1,
            Temp = 2,
            TempJob = 3,
            Persistent = 4,
            AudioKernel = 5,
        }

        class NativeLeakDetection
        {
            static /*0x0*/ int s_NativeLeakDetectionMode;

            static /*0x1e1f748*/ void Initialize();
        }

        struct NativeArray<T> : System.IDisposable, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.IEquatable<Unity.Collections.NativeArray<T>>
        {
            /*0x0*/ void* m_Buffer;
            /*0x0*/ int m_Length;
            /*0x0*/ Unity.Collections.Allocator m_AllocatorLabel;

            int get_Length();
            T get_Item(int index);
            void set_Item(int index, T value);
            void Dispose();
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

        namespace LowLevel
        {
            namespace Unsafe
            {
                class NativeContainerAttribute : System.Attribute
                {
                    /*0x1e1f720*/ NativeContainerAttribute();
                }

                class NativeContainerIsReadOnlyAttribute : System.Attribute
                {
                }

                class NativeContainerIsAtomicWriteOnlyAttribute : System.Attribute
                {
                }

                class NativeContainerSupportsMinMaxWriteRestrictionAttribute : System.Attribute
                {
                    /*0x1e1f738*/ NativeContainerSupportsMinMaxWriteRestrictionAttribute();
                }

                class NativeContainerSupportsDeallocateOnJobCompletionAttribute : System.Attribute
                {
                    /*0x1e1f728*/ NativeContainerSupportsDeallocateOnJobCompletionAttribute();
                }

                class NativeContainerSupportsDeferredConvertListToArray : System.Attribute
                {
                    /*0x1e1f730*/ NativeContainerSupportsDeferredConvertListToArray();
                }

                class NativeSetThreadIndexAttribute : System.Attribute
                {
                }

                class NativeContainerNeedsThreadIndexAttribute : System.Attribute
                {
                }

                class WriteAccessRequiredAttribute : System.Attribute
                {
                    /*0x2a94030*/ WriteAccessRequiredAttribute();
                }

                class NativeDisableUnsafePtrRestrictionAttribute : System.Attribute
                {
                    /*0x1e1f740*/ NativeDisableUnsafePtrRestrictionAttribute();
                }

                class NativeDisableContainerSafetyRestrictionAttribute : System.Attribute
                {
                }

                class NativeSetClassTypeToNullOnScheduleAttribute : System.Attribute
                {
                }

                class NativeArrayUnsafeUtility
                {
                    static Unity.Collections.NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Unity.Collections.Allocator allocator);
                }

                class UnsafeUtility
                {
                    static /*0x1894228*/ void Free(void* memory, Unity.Collections.Allocator allocator);
                    static T ReadArrayElement<T>(void* source, int index);
                    static void WriteArrayElement<T>(void* destination, int index, T value);
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
            /*0x1e0d21c*/ CanBeNullAttribute();
        }

        class NotNullAttribute : System.Attribute
        {
            /*0x18788ac*/ NotNullAttribute();
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

    struct SortingLayer
    {
        /*0x10*/ int m_Id;

        static /*0x18899e4*/ int GetLayerValueFromID(int id);
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

        /*0xadd8ec*/ Keyframe(float time, float value);
        /*0xadd8fc*/ Keyframe(float time, float value, float inTangent, float outTangent);
        /*0xadd910*/ float get_time();
        /*0xadd918*/ void set_time(float value);
        /*0xadd920*/ float get_value();
        /*0xadd928*/ void set_value(float value);
        /*0xadd930*/ float get_inTangent();
        /*0xadd938*/ void set_inTangent(float value);
        /*0xadd940*/ float get_outTangent();
        /*0xadd948*/ void set_outTangent(float value);
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

        static /*0x1e08358*/ void Internal_Destroy(nint ptr);
        static /*0x1e08398*/ nint Internal_Create(UnityEngine.Keyframe[] keys);
        static /*0x1e08898*/ UnityEngine.AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd);
        /*0x1e089f0*/ AnimationCurve(UnityEngine.Keyframe[] keys);
        /*0x1e08b80*/ AnimationCurve();
        /*0x1e083d8*/ bool Internal_Equals(nint other);
        /*0x1e08428*/ void Finalize();
        /*0x1e084c4*/ float Evaluate(float time);
        /*0x1e08514*/ UnityEngine.Keyframe[] get_keys();
        /*0x1e08594*/ void set_keys(UnityEngine.Keyframe[] value);
        /*0x1e08634*/ int MoveKey(int index, UnityEngine.Keyframe key);
        /*0x1e086e4*/ UnityEngine.Keyframe get_Item(int index);
        /*0x1e08800*/ int get_length();
        /*0x1e085e4*/ void SetKeys(UnityEngine.Keyframe[] keys);
        /*0x1e08780*/ UnityEngine.Keyframe GetKey(int index);
        /*0x1e08554*/ UnityEngine.Keyframe[] GetKeys();
        /*0x1e08a60*/ UnityEngine.WrapMode get_preWrapMode();
        /*0x1e08aa0*/ void set_preWrapMode(UnityEngine.WrapMode value);
        /*0x1e08af0*/ UnityEngine.WrapMode get_postWrapMode();
        /*0x1e08b30*/ void set_postWrapMode(UnityEngine.WrapMode value);
        /*0x1e08bd0*/ bool Equals(object o);
        /*0x1e08ca8*/ bool Equals(UnityEngine.AnimationCurve other);
        /*0x1e08d74*/ int GetHashCode();
        /*0x1e0868c*/ int MoveKey_Injected(int index, ref UnityEngine.Keyframe key);
        /*0x1e08840*/ void GetKey_Injected(int index, ref UnityEngine.Keyframe ret);
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
        static /*0x40*/ UnityEngine.Application.LogCallback s_RegisterLogCallbackDeprecated;

        static /*0x1e08d80*/ void Quit(int exitCode);
        static /*0x1e08dc0*/ void Quit();
        static /*0x1e08dfc*/ bool get_isPlaying();
        static /*0x1e08e30*/ bool get_isFocused();
        static /*0x1e08e64*/ string get_buildGUID();
        static /*0x1e08e98*/ bool get_isBatchMode();
        static /*0x1e08ecc*/ string get_dataPath();
        static /*0x1e08f00*/ string get_streamingAssetsPath();
        static /*0x1e08f34*/ string get_persistentDataPath();
        static /*0x1e08f68*/ string get_temporaryCachePath();
        static /*0x1e08f9c*/ string get_unityVersion();
        static /*0x1e08fd0*/ string get_version();
        static /*0x1e09004*/ string get_identifier();
        static /*0x1e09038*/ UnityEngine.ApplicationInstallMode get_installMode();
        static /*0x1e0906c*/ string get_productName();
        static /*0x1e090a0*/ string get_cloudProjectId();
        static /*0x1e090d4*/ void OpenURL(string url);
        static /*0x1e09114*/ int get_targetFrameRate();
        static /*0x1e09148*/ void set_targetFrameRate(int value);
        static /*0x1e09188*/ void SetLogCallbackDefined(bool defined);
        static /*0x1e091c8*/ UnityEngine.StackTraceLogType GetStackTraceLogType(UnityEngine.LogType logType);
        static /*0x1e09208*/ bool get_genuine();
        static /*0x1e0923c*/ bool get_genuineCheckAvailable();
        static /*0x1e09270*/ UnityEngine.RuntimePlatform get_platform();
        static /*0x1e092a4*/ UnityEngine.SystemLanguage get_systemLanguage();
        static /*0x1e092d8*/ UnityEngine.NetworkReachability get_internetReachability();
        static /*0x1e0930c*/ void CallLowMemory();
        static /*0x1e0936c*/ void add_logMessageReceived(UnityEngine.Application.LogCallback value);
        static /*0x1e09424*/ void remove_logMessageReceived(UnityEngine.Application.LogCallback value);
        static /*0x1e094b8*/ void add_logMessageReceivedThreaded(UnityEngine.Application.LogCallback value);
        static /*0x1e09570*/ void remove_logMessageReceivedThreaded(UnityEngine.Application.LogCallback value);
        static /*0x1e09604*/ void CallLogCallback(string logString, string stackTrace, UnityEngine.LogType type, bool invokedOnMainThread);
        static /*0x1e096c8*/ bool Internal_ApplicationWantsToQuit();
        static /*0x1e09a2c*/ void Internal_ApplicationQuit();
        static /*0x1e09a8c*/ void Internal_ApplicationUnload();
        static /*0x1e09aec*/ void InvokeOnBeforeRender();
        static /*0x1e09ce4*/ void InvokeFocusChanged(bool focus);
        static /*0x1e09d60*/ void InvokeDeepLinkActivated(string url);
        static /*0x1e09ddc*/ void RegisterLogCallback(UnityEngine.Application.LogCallback handler);
        static /*0x1e09de4*/ void RegisterLogCallback(UnityEngine.Application.LogCallback handler, bool threaded);
        static /*0x1e09eb4*/ bool get_isEditor();

        class LowMemoryCallback : System.MulticastDelegate
        {
            /*0x2a944f8*/ LowMemoryCallback(object object, nint method);
            /*0x2a94558*/ void Invoke();
            /*0x2a94764*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x2a94790*/ void EndInvoke(System.IAsyncResult result);
        }

        class LogCallback : System.MulticastDelegate
        {
            /*0x2a94038*/ LogCallback(object object, nint method);
            /*0x2a94098*/ void Invoke(string condition, string stackTrace, UnityEngine.LogType type);
            /*0x2a94450*/ System.IAsyncResult BeginInvoke(string condition, string stackTrace, UnityEngine.LogType type, System.AsyncCallback callback, object object);
            /*0x2a944ec*/ void EndInvoke(System.IAsyncResult result);
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

    class BootConfigData
    {
        /*0x10*/ nint m_Ptr;

        static /*0x1e0b0b0*/ UnityEngine.BootConfigData WrapBootConfigData(nint nativeHandle);
        /*0x1e0b10c*/ BootConfigData(nint nativeHandle);
    }

    class Camera : UnityEngine.Behaviour
    {
        static /*0x0*/ UnityEngine.Camera.CameraCallback onPreCull;
        static /*0x8*/ UnityEngine.Camera.CameraCallback onPreRender;
        static /*0x10*/ UnityEngine.Camera.CameraCallback onPostRender;

        static /*0x1e0ce9c*/ UnityEngine.Camera get_main();
        static /*0x1e0ced0*/ int GetAllCamerasCount();
        static /*0x1e0cf04*/ int GetAllCamerasImpl(UnityEngine.Camera[] cam);
        static /*0x1e0cf44*/ int get_allCamerasCount();
        static /*0x1e0cf78*/ int GetAllCameras(UnityEngine.Camera[] cameras);
        static /*0x1e0d054*/ void FireOnPreCull(UnityEngine.Camera cam);
        static /*0x1e0d0bc*/ void FireOnPreRender(UnityEngine.Camera cam);
        static /*0x1e0d124*/ void FireOnPostRender(UnityEngine.Camera cam);
        /*0x1e0bc90*/ Camera();
        /*0x1e0bc94*/ float get_nearClipPlane();
        /*0x1e0bcd4*/ void set_nearClipPlane(float value);
        /*0x1e0bd24*/ float get_farClipPlane();
        /*0x1e0bd64*/ void set_farClipPlane(float value);
        /*0x1e0bdb4*/ float get_fieldOfView();
        /*0x1e0bdf4*/ void set_fieldOfView(float value);
        /*0x1e0be44*/ bool get_allowHDR();
        /*0x1e0be84*/ float get_orthographicSize();
        /*0x1e0bec4*/ void set_orthographicSize(float value);
        /*0x1e0bf14*/ void set_orthographic(bool value);
        /*0x1e0bf64*/ float get_depth();
        /*0x1e0bfa4*/ void set_depth(float value);
        /*0x1e0bff4*/ float get_aspect();
        /*0x1e0c034*/ void set_aspect(float value);
        /*0x1e0c084*/ int get_cullingMask();
        /*0x1e0c0c4*/ int get_eventMask();
        /*0x1e0c104*/ UnityEngine.Color get_backgroundColor();
        /*0x1e0c1b0*/ void set_backgroundColor(UnityEngine.Color value);
        /*0x1e0c258*/ UnityEngine.CameraClearFlags get_clearFlags();
        /*0x1e0c298*/ UnityEngine.DepthTextureMode get_depthTextureMode();
        /*0x1e0c2d8*/ void set_depthTextureMode(UnityEngine.DepthTextureMode value);
        /*0x1e0c328*/ UnityEngine.Rect get_rect();
        /*0x1e0c3d4*/ void set_rect(UnityEngine.Rect value);
        /*0x1e0c47c*/ UnityEngine.Rect get_pixelRect();
        /*0x1e0c528*/ void set_pixelRect(UnityEngine.Rect value);
        /*0x1e0c5d0*/ UnityEngine.RenderTexture get_targetTexture();
        /*0x1e0c610*/ int get_targetDisplay();
        /*0x1e0c650*/ UnityEngine.Matrix4x4 get_worldToCameraMatrix();
        /*0x1e0c718*/ UnityEngine.Matrix4x4 get_projectionMatrix();
        /*0x1e0c7e0*/ UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x1e0c8c4*/ UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x1e0c9a8*/ UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x1e0ca8c*/ UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x1e0cb70*/ UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Vector3 position);
        /*0x1e0cb78*/ UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Vector3 position);
        /*0x1e0cb80*/ UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Vector3 position);
        /*0x1e0cb88*/ UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Vector3 position);
        /*0x1e0cb90*/ UnityEngine.Vector3 ScreenToViewportPoint(UnityEngine.Vector3 position);
        /*0x1e0cc54*/ UnityEngine.Vector3 ViewportToScreenPoint(UnityEngine.Vector3 position);
        /*0x1e0cd18*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x1e0ce04*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye);
        /*0x1e0ce44*/ UnityEngine.Ray ScreenPointToRay(UnityEngine.Vector3 pos);
        /*0x1e0c160*/ void get_backgroundColor_Injected(ref UnityEngine.Color ret);
        /*0x1e0c208*/ void set_backgroundColor_Injected(ref UnityEngine.Color value);
        /*0x1e0c384*/ void get_rect_Injected(ref UnityEngine.Rect ret);
        /*0x1e0c42c*/ void set_rect_Injected(ref UnityEngine.Rect value);
        /*0x1e0c4d8*/ void get_pixelRect_Injected(ref UnityEngine.Rect ret);
        /*0x1e0c580*/ void set_pixelRect_Injected(ref UnityEngine.Rect value);
        /*0x1e0c6c8*/ void get_worldToCameraMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        /*0x1e0c790*/ void get_projectionMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        /*0x1e0c85c*/ void WorldToScreenPoint_Injected(ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        /*0x1e0c940*/ void WorldToViewportPoint_Injected(ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        /*0x1e0ca24*/ void ViewportToWorldPoint_Injected(ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        /*0x1e0cb08*/ void ScreenToWorldPoint_Injected(ref UnityEngine.Vector3 position, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Vector3 ret);
        /*0x1e0cbfc*/ void ScreenToViewportPoint_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        /*0x1e0ccc0*/ void ViewportToScreenPoint_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        /*0x1e0cd9c*/ void ScreenPointToRay_Injected(ref UnityEngine.Vector2 pos, UnityEngine.Camera.MonoOrStereoscopicEye eye, ref UnityEngine.Ray ret);

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
            /*0x2a94dd8*/ CameraCallback(object object, nint method);
            /*0x2a94e38*/ void Invoke(UnityEngine.Camera cam);
            /*0x2a951b0*/ System.IAsyncResult BeginInvoke(UnityEngine.Camera cam, System.AsyncCallback callback, object object);
            /*0x2a951d4*/ void EndInvoke(System.IAsyncResult result);
        }
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

        static /*0x1e0fbb8*/ void SendEvents(UnityEngine.CullingGroup cullingGroup, nint eventsPtr, int count);

        class StateChanged : System.MulticastDelegate
        {
            /*0x2a951e0*/ StateChanged(object object, nint method);
            /*0x2a95240*/ void Invoke(UnityEngine.CullingGroupEvent sphere);
            /*0x2a9548c*/ System.IAsyncResult BeginInvoke(UnityEngine.CullingGroupEvent sphere, System.AsyncCallback callback, object object);
            /*0x2a95514*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class ReflectionProbe : UnityEngine.Behaviour
    {
        static /*0x0*/ System.Action<UnityEngine.ReflectionProbe, UnityEngine.ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged;
        static /*0x8*/ System.Action<UnityEngine.Cubemap> defaultReflectionSet;

        static /*0x1882408*/ void CallReflectionProbeEvent(UnityEngine.ReflectionProbe probe, UnityEngine.ReflectionProbe.ReflectionProbeEvent probeEvent);
        static /*0x1882498*/ void CallSetDefaultReflection(UnityEngine.Cubemap defaultReflectionCubemap);

        enum ReflectionProbeEvent
        {
            ReflectionProbeAdded = 0,
            ReflectionProbeRemoved = 1,
        }
    }

    class DebugLogHandler : UnityEngine.ILogHandler
    {
        static /*0x1e11708*/ void Internal_Log(UnityEngine.LogType level, UnityEngine.LogOption options, string msg, UnityEngine.Object obj);
        static /*0x1e11770*/ void Internal_LogException(System.Exception ex, UnityEngine.Object obj);
        /*0x1e116c4*/ DebugLogHandler();
        /*0x1e117c0*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
        /*0x1e1182c*/ void LogException(System.Exception exception, UnityEngine.Object context);
    }

    class Debug
    {
        static /*0x0*/ UnityEngine.ILogger s_DefaultLogger;
        static /*0x8*/ UnityEngine.ILogger s_Logger;

        static /*0x1e115bc*/ Debug();
        static /*0x1e0fe20*/ UnityEngine.ILogger get_unityLogger();
        static /*0x1e0fe84*/ void DrawLine(UnityEngine.Vector3 start, UnityEngine.Vector3 end, UnityEngine.Color color, float duration, bool depthTest);
        static /*0x1e0ffbc*/ void Break();
        static /*0x1e0fff0*/ int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder);
        static /*0x1e10048*/ void Log(object message);
        static /*0x1e10174*/ void Log(object message, UnityEngine.Object context);
        static /*0x1e102a8*/ void LogFormat(string format, object[] args);
        static /*0x1e103dc*/ void LogError(object message);
        static /*0x1e10508*/ void LogError(object message, UnityEngine.Object context);
        static /*0x1e1063c*/ void LogErrorFormat(string format, object[] args);
        static /*0x1e10770*/ void LogErrorFormat(UnityEngine.Object context, string format, object[] args);
        static /*0x1e09900*/ void LogException(System.Exception exception);
        static /*0x1e108b0*/ void LogException(System.Exception exception, UnityEngine.Object context);
        static /*0x1e109e0*/ void LogWarning(object message);
        static /*0x1e10b0c*/ void LogWarning(object message, UnityEngine.Object context);
        static /*0x1e10c40*/ void LogWarningFormat(string format, object[] args);
        static /*0x1e10d74*/ void LogWarningFormat(UnityEngine.Object context, string format, object[] args);
        static /*0x1e10eb4*/ bool get_isDebugBuild();
        static /*0x1e10ee8*/ bool CallOverridenDebugHandler(System.Exception exception, UnityEngine.Object obj);
        static /*0x1e11354*/ bool IsLoggingEnabled();
        static /*0x1e0ff44*/ void DrawLine_Injected(ref UnityEngine.Vector3 start, ref UnityEngine.Vector3 end, ref UnityEngine.Color color, float duration, bool depthTest);
    }

    class LightingSettings : UnityEngine.Object
    {
        /*0x1e15914*/ void LightingSettingsDontStripMe();
    }

    struct Bounds : System.IEquatable<UnityEngine.Bounds>, System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3 m_Center;
        /*0x1c*/ UnityEngine.Vector3 m_Extents;

        static /*0x1e0b404*/ bool op_Equality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs);
        static /*0x1e0b464*/ bool op_Inequality(UnityEngine.Bounds lhs, UnityEngine.Bounds rhs);
        /*0xadd144*/ Bounds(UnityEngine.Vector3 center, UnityEngine.Vector3 size);
        /*0xadd164*/ int GetHashCode();
        /*0xadd16c*/ bool Equals(object other);
        /*0xadd174*/ bool Equals(UnityEngine.Bounds other);
        /*0xadd1ac*/ UnityEngine.Vector3 get_center();
        /*0xadd1b8*/ void set_center(UnityEngine.Vector3 value);
        /*0xadd1c4*/ UnityEngine.Vector3 get_size();
        /*0xadd1dc*/ void set_size(UnityEngine.Vector3 value);
        /*0xadd1f8*/ UnityEngine.Vector3 get_extents();
        /*0xadd204*/ void set_extents(UnityEngine.Vector3 value);
        /*0xadd210*/ UnityEngine.Vector3 get_min();
        /*0xadd230*/ UnityEngine.Vector3 get_max();
        /*0xadd250*/ void SetMinMax(UnityEngine.Vector3 min, UnityEngine.Vector3 max);
        /*0xadd288*/ void Encapsulate(UnityEngine.Vector3 point);
        /*0xadd290*/ void Encapsulate(UnityEngine.Bounds bounds);
        /*0xadd2c4*/ string ToString();
        /*0xadd2cc*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct BoundsInt : System.IEquatable<UnityEngine.BoundsInt>, System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3Int m_Position;
        /*0x1c*/ UnityEngine.Vector3Int m_Size;

        /*0xadd30c*/ BoundsInt(UnityEngine.Vector3Int position, UnityEngine.Vector3Int size);
        /*0xadd2d4*/ UnityEngine.Vector3Int get_position();
        /*0xadd2e4*/ void set_position(UnityEngine.Vector3Int value);
        /*0xadd2f0*/ UnityEngine.Vector3Int get_size();
        /*0xadd300*/ void set_size(UnityEngine.Vector3Int value);
        /*0xadd320*/ string ToString();
        /*0xadd328*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0xadd330*/ bool Equals(object other);
        /*0xadd338*/ bool Equals(UnityEngine.BoundsInt other);
        /*0xadd370*/ int GetHashCode();
    }

    class GeometryUtility
    {
        static /*0x1e12e0c*/ UnityEngine.Plane[] CalculateFrustumPlanes(UnityEngine.Camera camera);
        static /*0x1e12e70*/ void CalculateFrustumPlanes(UnityEngine.Camera camera, UnityEngine.Plane[] planes);
        static /*0x1e13010*/ void CalculateFrustumPlanes(UnityEngine.Matrix4x4 worldToProjectionMatrix, UnityEngine.Plane[] planes);
        static /*0x1e13160*/ bool TestPlanesAABB(UnityEngine.Plane[] planes, UnityEngine.Bounds bounds);
        static /*0x1e13110*/ void Internal_ExtractPlanes(UnityEngine.Plane[] planes, UnityEngine.Matrix4x4 worldToProjectionMatrix);
        static /*0x1e131b0*/ bool TestPlanesAABB_Injected(UnityEngine.Plane[] planes, ref UnityEngine.Bounds bounds);
        static /*0x1e13200*/ void Internal_ExtractPlanes_Injected(UnityEngine.Plane[] planes, ref UnityEngine.Matrix4x4 worldToProjectionMatrix);
    }

    struct Plane : System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3 m_Normal;
        /*0x1c*/ float m_Distance;

        /*0xacbc2c*/ Plane(UnityEngine.Vector3 inNormal, UnityEngine.Vector3 inPoint);
        /*0xacbc8c*/ bool Raycast(UnityEngine.Ray ray, ref float enter);
        /*0xacbcc4*/ string ToString();
        /*0xacbccc*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Ray : System.IFormattable
    {
        /*0x10*/ UnityEngine.Vector3 m_Origin;
        /*0x1c*/ UnityEngine.Vector3 m_Direction;

        /*0xacc014*/ Ray(UnityEngine.Vector3 origin, UnityEngine.Vector3 direction);
        /*0xacc01c*/ UnityEngine.Vector3 get_origin();
        /*0xacc028*/ UnityEngine.Vector3 get_direction();
        /*0xacc034*/ UnityEngine.Vector3 GetPoint(float distance);
        /*0xacc05c*/ string ToString();
        /*0xacc064*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Rect : System.IEquatable<UnityEngine.Rect>, System.IFormattable
    {
        /*0x10*/ float m_XMin;
        /*0x14*/ float m_YMin;
        /*0x18*/ float m_Width;
        /*0x1c*/ float m_Height;

        static /*0x187fb3c*/ UnityEngine.Rect get_zero();
        static /*0x187fd10*/ UnityEngine.Rect OrderMinMax(UnityEngine.Rect rect);
        static /*0x187fe1c*/ bool op_Inequality(UnityEngine.Rect lhs, UnityEngine.Rect rhs);
        static /*0x187fe50*/ bool op_Equality(UnityEngine.Rect lhs, UnityEngine.Rect rhs);
        /*0xacc06c*/ Rect(float x, float y, float width, float height);
        /*0xacc078*/ Rect(UnityEngine.Vector2 position, UnityEngine.Vector2 size);
        /*0xacc084*/ Rect(UnityEngine.Rect source);
        /*0xacc090*/ void Set(float x, float y, float width, float height);
        /*0xacc09c*/ float get_x();
        /*0xacc0a4*/ void set_x(float value);
        /*0xacc0ac*/ float get_y();
        /*0xacc0b4*/ void set_y(float value);
        /*0xacc0bc*/ UnityEngine.Vector2 get_position();
        /*0xacc0c4*/ UnityEngine.Vector2 get_center();
        /*0xacc0dc*/ void set_center(UnityEngine.Vector2 value);
        /*0xacc0f8*/ UnityEngine.Vector2 get_min();
        /*0xacc100*/ UnityEngine.Vector2 get_max();
        /*0xacc110*/ float get_width();
        /*0xacc118*/ void set_width(float value);
        /*0xacc120*/ float get_height();
        /*0xacc128*/ void set_height(float value);
        /*0xacc130*/ UnityEngine.Vector2 get_size();
        /*0xacc138*/ void set_size(UnityEngine.Vector2 value);
        /*0xacc140*/ float get_xMin();
        /*0xacc148*/ void set_xMin(float value);
        /*0xacc164*/ float get_yMin();
        /*0xacc16c*/ void set_yMin(float value);
        /*0xacc188*/ float get_xMax();
        /*0xacc198*/ void set_xMax(float value);
        /*0xacc1a8*/ float get_yMax();
        /*0xacc1b8*/ void set_yMax(float value);
        /*0xacc1c8*/ bool Contains(UnityEngine.Vector2 point);
        /*0xacc20c*/ bool Contains(UnityEngine.Vector3 point);
        /*0xacc250*/ bool Overlaps(UnityEngine.Rect other);
        /*0xacc258*/ bool Overlaps(UnityEngine.Rect other, bool allowInverse);
        /*0xacc264*/ int GetHashCode();
        /*0xacc26c*/ bool Equals(object other);
        /*0xacc274*/ bool Equals(UnityEngine.Rect other);
        /*0xacc27c*/ string ToString();
        /*0xacc284*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct RectInt : System.IEquatable<UnityEngine.RectInt>, System.IFormattable
    {
        /*0x10*/ int m_XMin;
        /*0x14*/ int m_YMin;
        /*0x18*/ int m_Width;
        /*0x1c*/ int m_Height;

        /*0xacc2cc*/ RectInt(int xMin, int yMin, int width, int height);
        /*0xacc28c*/ int get_x();
        /*0xacc294*/ void set_x(int value);
        /*0xacc29c*/ int get_y();
        /*0xacc2a4*/ void set_y(int value);
        /*0xacc2ac*/ int get_width();
        /*0xacc2b4*/ void set_width(int value);
        /*0xacc2bc*/ int get_height();
        /*0xacc2c4*/ void set_height(int value);
        /*0xacc2d8*/ string ToString();
        /*0xacc2e0*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0xacc2e8*/ bool Equals(UnityEngine.RectInt other);
    }

    class RectOffset : System.IFormattable
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ object m_SourceStyle;

        static /*0x188060c*/ nint InternalCreate();
        static /*0x1880db4*/ void InternalDestroy(nint ptr);
        /*0x18805c0*/ RectOffset();
        /*0x1880640*/ RectOffset(object sourceStyle, nint source);
        /*0x1880774*/ RectOffset(int left, int right, int top, int bottom);
        /*0x1880678*/ void Finalize();
        /*0x18809cc*/ string ToString();
        /*0x1880a54*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0x18806ec*/ void Destroy();
        /*0x1880cb4*/ int get_left();
        /*0x188088c*/ void set_left(int value);
        /*0x1880cf4*/ int get_right();
        /*0x18808dc*/ void set_right(int value);
        /*0x1880d34*/ int get_top();
        /*0x188092c*/ void set_top(int value);
        /*0x1880d74*/ int get_bottom();
        /*0x188097c*/ void set_bottom(int value);
        /*0x1880df4*/ int get_horizontal();
        /*0x1880e34*/ int get_vertical();
        /*0x1880e74*/ UnityEngine.Rect Remove(UnityEngine.Rect rect);
        /*0x1880edc*/ void Remove_Injected(ref UnityEngine.Rect rect, ref UnityEngine.Rect ret);
    }

    class Gizmos
    {
        static /*0x1e13250*/ void DrawLine(UnityEngine.Vector3 from, UnityEngine.Vector3 to);
        static /*0x1e132fc*/ void DrawWireSphere(UnityEngine.Vector3 center, float radius);
        static /*0x1e133ac*/ void DrawSphere(UnityEngine.Vector3 center, float radius);
        static /*0x1e1345c*/ void set_color(UnityEngine.Color value);
        static /*0x1e132ac*/ void DrawLine_Injected(ref UnityEngine.Vector3 from, ref UnityEngine.Vector3 to);
        static /*0x1e1335c*/ void DrawWireSphere_Injected(ref UnityEngine.Vector3 center, float radius);
        static /*0x1e1340c*/ void DrawSphere_Injected(ref UnityEngine.Vector3 center, float radius);
        static /*0x1e134ac*/ void set_color_Injected(ref UnityEngine.Color value);
    }

    class BeforeRenderHelper
    {
        static /*0x0*/ System.Collections.Generic.List<UnityEngine.BeforeRenderHelper.OrderBlock> s_OrderBlocks;

        static /*0x1e0aef0*/ BeforeRenderHelper();
        static /*0x1e09b44*/ void Invoke();

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

        static /*0x1e0fc54*/ void InvokeOnTextureLoaded_Internal(UnityEngine.CustomRenderTexture source);
        static /*0x1e0fcd0*/ void InvokeOnTextureUnloaded_Internal(UnityEngine.CustomRenderTexture source);
    }

    class Display
    {
        static /*0x0*/ UnityEngine.Display[] displays;
        static /*0x8*/ UnityEngine.Display _mainDisplay;
        static /*0x10*/ int m_ActiveEditorGameViewTarget;
        static /*0x18*/ UnityEngine.Display.DisplaysUpdatedDelegate onDisplaysUpdated;
        /*0x10*/ nint nativeDisplay;

        static /*0x1e121b8*/ Display();
        static /*0x1e11dac*/ UnityEngine.Vector3 RelativeMouseAt(UnityEngine.Vector3 inputMouseCoordinates);
        static /*0x1e11f04*/ UnityEngine.Display get_main();
        static /*0x1e11f68*/ void RecreateDisplayList(nint[] nativeDisplay);
        static /*0x1e12114*/ void FireDisplaysUpdated();
        static /*0x1e11cb4*/ void GetSystemExtImpl(nint nativeDisplay, ref int w, ref int h);
        static /*0x1e11b1c*/ void GetRenderingExtImpl(nint nativeDisplay, ref int w, ref int h);
        static /*0x1e11e9c*/ int RelativeMouseAtImpl(int x, int y, ref int rx, ref int ry);
        /*0x1e11a10*/ Display();
        /*0x1e11a50*/ Display(nint nativeDisplay);
        /*0x1e11a7c*/ int get_renderingWidth();
        /*0x1e11b74*/ int get_renderingHeight();
        /*0x1e11c14*/ int get_systemWidth();
        /*0x1e11d0c*/ int get_systemHeight();

        class DisplaysUpdatedDelegate : System.MulticastDelegate
        {
            /*0x2a95520*/ DisplaysUpdatedDelegate(object object, nint method);
            /*0x2a95580*/ void Invoke();
            /*0x2a9578c*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x2a957b8*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class Screen
    {
        static /*0x1888a80*/ int get_width();
        static /*0x1888ab4*/ int get_height();
        static /*0x1888ae8*/ float get_dpi();
        static /*0x1888b1c*/ UnityEngine.ScreenOrientation GetScreenOrientation();
        static /*0x1888b50*/ UnityEngine.ScreenOrientation get_orientation();
        static /*0x1888b84*/ void set_sleepTimeout(int value);
        static /*0x1888bc4*/ UnityEngine.Resolution get_currentResolution();
        static /*0x1888c5c*/ bool get_fullScreen();
        static /*0x1888c90*/ UnityEngine.Rect get_safeArea();
        static /*0x1888c1c*/ void get_currentResolution_Injected(ref UnityEngine.Resolution ret);
        static /*0x1888ce4*/ void get_safeArea_Injected(ref UnityEngine.Rect ret);
    }

    class Graphics
    {
        static /*0x0*/ int kMaxDrawMeshInstanceCount;

        static /*0x1e13f34*/ Graphics();
        static /*0x1e13acc*/ int Internal_GetMaxDrawMeshInstanceCount();
        static /*0x1e13b00*/ void CopyTexture_Region(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, UnityEngine.Texture dst, int dstElement, int dstMip, int dstX, int dstY);
        static /*0x1e13bc4*/ void Internal_BlitMaterial5(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, int pass, bool setRT);
        static /*0x1e13c34*/ void Blit2(UnityEngine.Texture source, UnityEngine.RenderTexture dest);
        static /*0x1e13c84*/ void CopyTexture(UnityEngine.Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, UnityEngine.Texture dst, int dstElement, int dstMip, int dstX, int dstY);
        static /*0x1e13d7c*/ void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest);
        static /*0x1e13e0c*/ void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat, int pass);
        static /*0x1e13eb8*/ void Blit(UnityEngine.Texture source, UnityEngine.RenderTexture dest, UnityEngine.Material mat);
    }

    class GL
    {
        static /*0x1e12348*/ void Vertex3(float x, float y, float z);
        static /*0x1e123a4*/ void TexCoord3(float x, float y, float z);
        static /*0x1e12400*/ void TexCoord2(float x, float y);
        static /*0x1e12450*/ void PushMatrix();
        static /*0x1e12484*/ void PopMatrix();
        static /*0x1e124b8*/ void LoadOrtho();
        static /*0x1e124ec*/ void Begin(int mode);
        static /*0x1e1252c*/ void End();
        static /*0x1e12560*/ void ClearWithSkybox(bool clearDepth, UnityEngine.Camera camera);
    }

    class LightmapSettings : UnityEngine.Object
    {
    }

    class LightProbes : UnityEngine.Object
    {
        static /*0x0*/ System.Action tetrahedralizationCompleted;
        static /*0x8*/ System.Action needsRetetrahedralization;

        static /*0x1e15854*/ void Internal_CallTetrahedralizationCompletedFunction();
        static /*0x1e158b4*/ void Internal_CallNeedsRetetrahedralizationFunction();
    }

    struct Resolution
    {
        /*0x10*/ int m_Width;
        /*0x14*/ int m_Height;
        /*0x18*/ int m_RefreshRate;

        /*0xacc6ec*/ int get_width();
        /*0xacc6f4*/ int get_height();
        /*0xacc6fc*/ int get_refreshRate();
        /*0xacc704*/ string ToString();
    }

    class QualitySettings : UnityEngine.Object
    {
        static /*0x187e92c*/ int get_vSyncCount();
        static /*0x187e960*/ void set_vSyncCount(int value);
        static /*0x187e9a0*/ UnityEngine.ColorSpace get_activeColorSpace();
    }

    class TrailRenderer : UnityEngine.Renderer
    {
        /*0x1890e0c*/ float get_time();
        /*0x1890e4c*/ void set_time(float value);
        /*0x1890e9c*/ float get_startWidth();
        /*0x1890edc*/ void set_startWidth(float value);
        /*0x1890f2c*/ float get_endWidth();
        /*0x1890f6c*/ void set_endWidth(float value);
    }

    class LineRenderer : UnityEngine.Renderer
    {
        /*0x1e1707c*/ void SetColors(UnityEngine.Color start, UnityEngine.Color end);
        /*0x1e170d0*/ void set_startColor(UnityEngine.Color value);
        /*0x1e17128*/ void set_endColor(UnityEngine.Color value);
        /*0x1e17180*/ void set_startColor_Injected(ref UnityEngine.Color value);
        /*0x1e171d0*/ void set_endColor_Injected(ref UnityEngine.Color value);
    }

    class MaterialPropertyBlock
    {
        /*0x10*/ nint m_Ptr;

        static /*0x1e1a210*/ nint CreateImpl();
        static /*0x1e1a244*/ void DestroyImpl(nint mpb);
        /*0x1e1a358*/ MaterialPropertyBlock();
        /*0x1e19ec8*/ float GetFloatImpl(int name);
        /*0x1e19f18*/ UnityEngine.Vector4 GetVectorImpl(int name);
        /*0x1e19fdc*/ UnityEngine.Color GetColorImpl(int name);
        /*0x1e1a0a0*/ UnityEngine.Texture GetTextureImpl(int name);
        /*0x1e1a0f0*/ void SetFloatImpl(int name, float value);
        /*0x1e1a150*/ void SetColorImpl(int name, UnityEngine.Color value);
        /*0x1e1a284*/ bool get_isEmpty();
        /*0x1e1a2c4*/ void Clear(bool keepMemory);
        /*0x1e1a314*/ void Clear();
        /*0x1e1a3a4*/ void Finalize();
        /*0x1e1a40c*/ void Dispose();
        /*0x1e1a4c8*/ void SetFloat(int nameID, float value);
        /*0x1e1a528*/ void SetColor(string name, UnityEngine.Color value);
        /*0x1e1a588*/ float GetFloat(int nameID);
        /*0x1e1a5d8*/ UnityEngine.Vector4 GetVector(int nameID);
        /*0x1e1a5dc*/ UnityEngine.Color GetColor(int nameID);
        /*0x1e1a5e0*/ UnityEngine.Texture GetTexture(int nameID);
        /*0x1e19f84*/ void GetVectorImpl_Injected(int name, ref UnityEngine.Vector4 ret);
        /*0x1e1a048*/ void GetColorImpl_Injected(int name, ref UnityEngine.Color ret);
        /*0x1e1a1b8*/ void SetColorImpl_Injected(int name, ref UnityEngine.Color value);
    }

    class Renderer : UnityEngine.Component
    {
        /*0x18858b8*/ UnityEngine.Bounds get_bounds();
        /*0x1885974*/ UnityEngine.Material GetMaterial();
        /*0x18859b4*/ UnityEngine.Material GetSharedMaterial();
        /*0x18859f4*/ void SetMaterial(UnityEngine.Material m);
        /*0x1885a44*/ void CopySharedMaterialArray(UnityEngine.Material[] m);
        /*0x1885a94*/ void SetMaterialArray(UnityEngine.Material[] m);
        /*0x1885ae4*/ void Internal_SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties);
        /*0x1885b34*/ void Internal_GetPropertyBlock(UnityEngine.MaterialPropertyBlock dest);
        /*0x1885b84*/ void Internal_SetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock properties, int materialIndex);
        /*0x1885bdc*/ void Internal_GetPropertyBlockMaterialIndex(UnityEngine.MaterialPropertyBlock dest, int materialIndex);
        /*0x1885c34*/ bool HasPropertyBlock();
        /*0x1885c74*/ void SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties);
        /*0x1885cc4*/ void SetPropertyBlock(UnityEngine.MaterialPropertyBlock properties, int materialIndex);
        /*0x1885d1c*/ void GetPropertyBlock(UnityEngine.MaterialPropertyBlock properties);
        /*0x1885d6c*/ void GetPropertyBlock(UnityEngine.MaterialPropertyBlock properties, int materialIndex);
        /*0x1885dc4*/ bool get_enabled();
        /*0x1885e04*/ void set_enabled(bool value);
        /*0x1885e54*/ UnityEngine.Rendering.ShadowCastingMode get_shadowCastingMode();
        /*0x1885e94*/ void set_shadowCastingMode(UnityEngine.Rendering.ShadowCastingMode value);
        /*0x1885ee4*/ bool get_receiveShadows();
        /*0x1885f24*/ void set_receiveShadows(bool value);
        /*0x1885f74*/ UnityEngine.MotionVectorGenerationMode get_motionVectorGenerationMode();
        /*0x1885fb4*/ void set_motionVectorGenerationMode(UnityEngine.MotionVectorGenerationMode value);
        /*0x1886004*/ UnityEngine.Rendering.LightProbeUsage get_lightProbeUsage();
        /*0x1886044*/ void set_lightProbeUsage(UnityEngine.Rendering.LightProbeUsage value);
        /*0x1886094*/ UnityEngine.Rendering.ReflectionProbeUsage get_reflectionProbeUsage();
        /*0x18860d4*/ void set_reflectionProbeUsage(UnityEngine.Rendering.ReflectionProbeUsage value);
        /*0x1886124*/ int get_sortingLayerID();
        /*0x1886164*/ void set_sortingLayerID(int value);
        /*0x18861b4*/ int get_sortingOrder();
        /*0x18861f4*/ void set_sortingOrder(int value);
        /*0x1886244*/ UnityEngine.Transform get_probeAnchor();
        /*0x1886284*/ void set_probeAnchor(UnityEngine.Transform value);
        /*0x18862d4*/ int GetMaterialCount();
        /*0x1886314*/ UnityEngine.Material[] GetSharedMaterialArray();
        /*0x1886354*/ void set_materials(UnityEngine.Material[] value);
        /*0x18863a4*/ UnityEngine.Material get_material();
        /*0x18863e4*/ void set_material(UnityEngine.Material value);
        /*0x1886434*/ UnityEngine.Material get_sharedMaterial();
        /*0x1886474*/ UnityEngine.Material[] get_sharedMaterials();
        /*0x18864b4*/ void set_sharedMaterials(UnityEngine.Material[] value);
        /*0x1886504*/ void GetSharedMaterials(System.Collections.Generic.List<UnityEngine.Material> m);
        /*0x1885924*/ void get_bounds_Injected(ref UnityEngine.Bounds ret);
    }

    class RenderSettings : UnityEngine.Object
    {
        static /*0x18835f0*/ float get_ambientIntensity();
        static /*0x1883624*/ void set_ambientIntensity(float value);
        static /*0x1883668*/ UnityEngine.Color get_ambientLight();
        static /*0x18836fc*/ void set_ambientLight(UnityEngine.Color value);
        static /*0x18836bc*/ void get_ambientLight_Injected(ref UnityEngine.Color ret);
        static /*0x188374c*/ void set_ambientLight_Injected(ref UnityEngine.Color value);
    }

    class Shader : UnityEngine.Object
    {
        static /*0x1889748*/ UnityEngine.Shader Find(string name);
        static /*0x18897fc*/ int TagToID(string name);
        static /*0x188983c*/ int PropertyToID(string name);
        /*0x188987c*/ Shader();
        /*0x18897bc*/ bool get_isSupported();
    }

    class Material : UnityEngine.Object
    {
        static /*0x1e185b4*/ void CreateWithShader(UnityEngine.Material self, UnityEngine.Shader shader);
        static /*0x1e18604*/ void CreateWithMaterial(UnityEngine.Material self, UnityEngine.Material source);
        static /*0x1e18654*/ void CreateWithString(UnityEngine.Material self);
        /*0x1e18694*/ Material(UnityEngine.Shader shader);
        /*0x1e18730*/ Material(UnityEngine.Material source);
        /*0x1e187cc*/ Material(string contents);
        /*0x1e18858*/ UnityEngine.Shader get_shader();
        /*0x1e18898*/ void set_shader(UnityEngine.Shader value);
        /*0x1e188e8*/ UnityEngine.Color get_color();
        /*0x1e189f8*/ void set_color(UnityEngine.Color value);
        /*0x1e18b14*/ UnityEngine.Texture get_mainTexture();
        /*0x1e18c80*/ void set_mainTexture(UnityEngine.Texture value);
        /*0x1e18e08*/ UnityEngine.Vector2 get_mainTextureOffset();
        /*0x1e18ef8*/ void set_mainTextureOffset(UnityEngine.Vector2 value);
        /*0x1e18fe4*/ UnityEngine.Vector2 get_mainTextureScale();
        /*0x1e190a4*/ void set_mainTextureScale(UnityEngine.Vector2 value);
        /*0x1e18974*/ int GetFirstPropertyNameIdByAttribute(UnityEngine.Rendering.ShaderPropertyFlags attributeFlag);
        /*0x1e19190*/ bool HasProperty(int nameID);
        /*0x1e191e0*/ bool HasProperty(string name);
        /*0x1e1923c*/ int get_renderQueue();
        /*0x1e1927c*/ void EnableKeyword(string keyword);
        /*0x1e192cc*/ void DisableKeyword(string keyword);
        /*0x1e1931c*/ void set_enableInstancing(bool value);
        /*0x1e1936c*/ int get_passCount();
        /*0x1e193ac*/ bool SetPass(int pass);
        /*0x1e193fc*/ void CopyPropertiesFromMaterial(UnityEngine.Material mat);
        /*0x1e1944c*/ string[] GetShaderKeywords();
        /*0x1e1948c*/ void SetShaderKeywords(string[] names);
        /*0x1e194dc*/ string[] get_shaderKeywords();
        /*0x1e1951c*/ void set_shaderKeywords(string[] value);
        /*0x1e1956c*/ void SetFloatImpl(int name, float value);
        /*0x1e195cc*/ void SetColorImpl(int name, UnityEngine.Color value);
        /*0x1e1968c*/ void SetMatrixImpl(int name, UnityEngine.Matrix4x4 value);
        /*0x1e1973c*/ void SetTextureImpl(int name, UnityEngine.Texture value);
        /*0x1e19794*/ float GetFloatImpl(int name);
        /*0x1e197e4*/ UnityEngine.Color GetColorImpl(int name);
        /*0x1e198a8*/ UnityEngine.Texture GetTextureImpl(int name);
        /*0x1e198f8*/ UnityEngine.Vector4 GetTextureScaleAndOffsetImpl(int name);
        /*0x1e199bc*/ void SetTextureOffsetImpl(int name, UnityEngine.Vector2 offset);
        /*0x1e19a70*/ void SetTextureScaleImpl(int name, UnityEngine.Vector2 scale);
        /*0x1e19b24*/ void SetFloat(string name, float value);
        /*0x1e19b90*/ void SetFloat(int nameID, float value);
        /*0x1e19bf0*/ void SetInt(string name, int value);
        /*0x1e18ab4*/ void SetColor(string name, UnityEngine.Color value);
        /*0x1e18ab0*/ void SetColor(int nameID, UnityEngine.Color value);
        /*0x1e19c60*/ void SetVector(string name, UnityEngine.Vector4 value);
        /*0x1e19cc0*/ void SetVector(int nameID, UnityEngine.Vector4 value);
        /*0x1e19cc4*/ void SetMatrix(string name, UnityEngine.Matrix4x4 value);
        /*0x1e18da4*/ void SetTexture(string name, UnityEngine.Texture value);
        /*0x1e18d4c*/ void SetTexture(int nameID, UnityEngine.Texture value);
        /*0x1e19d44*/ float GetFloat(string name);
        /*0x1e19da0*/ float GetFloat(int nameID);
        /*0x1e189c8*/ UnityEngine.Color GetColor(string name);
        /*0x1e189c4*/ UnityEngine.Color GetColor(int nameID);
        /*0x1e19df0*/ UnityEngine.Vector4 GetVector(string name);
        /*0x1e19e24*/ UnityEngine.Vector4 GetVector(int nameID);
        /*0x1e18c24*/ UnityEngine.Texture GetTexture(string name);
        /*0x1e18bd4*/ UnityEngine.Texture GetTexture(int nameID);
        /*0x1e18f9c*/ void SetTextureOffset(string name, UnityEngine.Vector2 value);
        /*0x1e18f98*/ void SetTextureOffset(int nameID, UnityEngine.Vector2 value);
        /*0x1e19148*/ void SetTextureScale(string name, UnityEngine.Vector2 value);
        /*0x1e19144*/ void SetTextureScale(int nameID, UnityEngine.Vector2 value);
        /*0x1e18ebc*/ UnityEngine.Vector2 GetTextureOffset(string name);
        /*0x1e18ea0*/ UnityEngine.Vector2 GetTextureOffset(int nameID);
        /*0x1e19074*/ UnityEngine.Vector2 GetTextureScale(string name);
        /*0x1e19070*/ UnityEngine.Vector2 GetTextureScale(int nameID);
        /*0x1e19634*/ void SetColorImpl_Injected(int name, ref UnityEngine.Color value);
        /*0x1e196e4*/ void SetMatrixImpl_Injected(int name, ref UnityEngine.Matrix4x4 value);
        /*0x1e19850*/ void GetColorImpl_Injected(int name, ref UnityEngine.Color ret);
        /*0x1e19964*/ void GetTextureScaleAndOffsetImpl_Injected(int name, ref UnityEngine.Vector4 ret);
        /*0x1e19a18*/ void SetTextureOffsetImpl_Injected(int name, ref UnityEngine.Vector2 offset);
        /*0x1e19acc*/ void SetTextureScaleImpl_Injected(int name, ref UnityEngine.Vector2 scale);
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

        /*0x1e150d0*/ UnityEngine.LightType get_type();
        /*0x1e15110*/ float get_spotAngle();
        /*0x1e15150*/ UnityEngine.Color get_color();
        /*0x1e151fc*/ void set_color(UnityEngine.Color value);
        /*0x1e152a4*/ float get_intensity();
        /*0x1e152e4*/ void set_intensity(float value);
        /*0x1e15334*/ float get_bounceIntensity();
        /*0x1e15374*/ float get_range();
        /*0x1e153b4*/ UnityEngine.LightBakingOutput get_bakingOutput();
        /*0x1e15478*/ UnityEngine.LightShadows get_shadows();
        /*0x1e154b8*/ float get_shadowStrength();
        /*0x1e154f8*/ void set_shadowStrength(float value);
        /*0x1e15548*/ float get_cookieSize();
        /*0x1e15588*/ UnityEngine.Texture get_cookie();
        /*0x1e151ac*/ void get_color_Injected(ref UnityEngine.Color ret);
        /*0x1e15254*/ void set_color_Injected(ref UnityEngine.Color value);
        /*0x1e15428*/ void get_bakingOutput_Injected(ref UnityEngine.LightBakingOutput ret);
    }

    class MeshFilter : UnityEngine.Component
    {
        /*0x1e1e91c*/ void DontStripMeshFilter();
        /*0x1e1e920*/ void set_sharedMesh(UnityEngine.Mesh value);
        /*0x1e1e970*/ void set_mesh(UnityEngine.Mesh value);
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

    enum ScreenOrientation
    {
        Unknown = 0,
        Portrait = 1,
        PortraitUpsideDown = 2,
        LandscapeLeft = 3,
        LandscapeRight = 4,
        AutoRotation = 5,
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

    enum MotionVectorGenerationMode
    {
        Camera = 0,
        Object = 1,
        ForceNoMotion = 2,
    }

    class MeshRenderer : UnityEngine.Renderer
    {
        /*0x1e1e9c0*/ void DontStripMeshRenderer();
    }

    class Mesh : UnityEngine.Object
    {
        static /*0x1e1c630*/ void Internal_Create(UnityEngine.Mesh mono);
        static /*0x1e0e768*/ UnityEngine.Mesh FromInstanceID(int id);
        static /*0x1e1ce18*/ UnityEngine.Rendering.VertexAttribute GetUVChannel(int uvIndex);
        static /*0x1e1ce90*/ int DefaultDimensionForChannel(UnityEngine.Rendering.VertexAttribute channel);
        /*0x1e1c670*/ Mesh();
        /*0x1e1c6fc*/ int[] GetIndicesImpl(int submesh, bool applyBaseVertex);
        /*0x1e1c754*/ void SetIndicesImpl(int submesh, UnityEngine.MeshTopology topology, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex);
        /*0x1e1c7f4*/ void PrintErrorCantAccessChannel(UnityEngine.Rendering.VertexAttribute ch);
        /*0x1e1c844*/ bool HasVertexAttribute(UnityEngine.Rendering.VertexAttribute attr);
        /*0x1e1c894*/ void SetArrayForChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values, int arraySize, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1e1c934*/ System.Array GetAllocArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim);
        /*0x1e1c99c*/ void GetArrayFromChannelImpl(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values);
        /*0x1e1ca0c*/ bool get_canAccess();
        /*0x1e1ca4c*/ int get_vertexCount();
        /*0x1e1ca8c*/ int get_subMeshCount();
        /*0x1e1cacc*/ void set_subMeshCount(int value);
        /*0x1e1cb1c*/ UnityEngine.Bounds get_bounds();
        /*0x1e1cbd8*/ void set_bounds(UnityEngine.Bounds value);
        /*0x1e1cc78*/ void ClearImpl(bool keepVertexLayout);
        /*0x1e1ccc8*/ void RecalculateBoundsImpl(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1e1cd18*/ void RecalculateNormalsImpl(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1e1cd68*/ void MarkDynamicImpl();
        /*0x1e1cda8*/ void CombineMeshesImpl(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData);
        T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim);
        T[] GetAllocArrayFromChannel<T>(UnityEngine.Rendering.VertexAttribute channel);
        /*0x1e1cf30*/ void SetSizedArrayForChannel(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Array values, int valuesArrayLength, int valuesStart, int valuesCount, UnityEngine.Rendering.MeshUpdateFlags flags);
        void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags);
        void SetArrayForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, T[] values, UnityEngine.Rendering.MeshUpdateFlags flags);
        void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, UnityEngine.Rendering.VertexAttributeFormat format, int dim, System.Collections.Generic.List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        void SetListForChannel<T>(UnityEngine.Rendering.VertexAttribute channel, System.Collections.Generic.List<T> values, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        void GetListForChannel<T>(System.Collections.Generic.List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim);
        void GetListForChannel<T>(System.Collections.Generic.List<T> buffer, int capacity, UnityEngine.Rendering.VertexAttribute channel, int dim, UnityEngine.Rendering.VertexAttributeFormat channelType);
        /*0x1e1d1d4*/ UnityEngine.Vector3[] get_vertices();
        /*0x1e1d224*/ void set_vertices(UnityEngine.Vector3[] value);
        /*0x1e1d288*/ UnityEngine.Vector3[] get_normals();
        /*0x1e1d2d8*/ void set_normals(UnityEngine.Vector3[] value);
        /*0x1e1d33c*/ UnityEngine.Vector4[] get_tangents();
        /*0x1e1d38c*/ void set_tangents(UnityEngine.Vector4[] value);
        /*0x1e1d3f0*/ void set_uv(UnityEngine.Vector2[] value);
        /*0x1e1d454*/ void set_uv2(UnityEngine.Vector2[] value);
        /*0x1e1d4b8*/ void set_uv3(UnityEngine.Vector2[] value);
        /*0x1e1d51c*/ void set_colors(UnityEngine.Color[] value);
        /*0x1e1d580*/ UnityEngine.Color32[] get_colors32();
        /*0x1e1d5d8*/ void set_colors32(UnityEngine.Color32[] value);
        /*0x1e1d644*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices);
        /*0x1e1d6b4*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length);
        /*0x1e1d6bc*/ void SetVertices(System.Collections.Generic.List<UnityEngine.Vector3> inVertices, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1e1d73c*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals);
        /*0x1e1d7ac*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length);
        /*0x1e1d7b4*/ void SetNormals(System.Collections.Generic.List<UnityEngine.Vector3> inNormals, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1e1d834*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents);
        /*0x1e1d8a4*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length);
        /*0x1e1d8ac*/ void SetTangents(System.Collections.Generic.List<UnityEngine.Vector4> inTangents, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1e1d92c*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors);
        /*0x1e1d99c*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length);
        /*0x1e1d9a4*/ void SetColors(System.Collections.Generic.List<UnityEngine.Color32> inColors, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        void SetUvsImpl<T>(int uvIndex, int dim, System.Collections.Generic.List<T> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1e1da3c*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs);
        /*0x1e1dabc*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs);
        /*0x1e1dab4*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, int start, int length);
        /*0x1e1db3c*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector2> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1e1db34*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length);
        /*0x1e1dbcc*/ void SetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs, int start, int length, UnityEngine.Rendering.MeshUpdateFlags flags);
        void GetUVsImpl<T>(int uvIndex, System.Collections.Generic.List<T> uvs, int dim);
        /*0x1e1dc5c*/ void GetUVs(int channel, System.Collections.Generic.List<UnityEngine.Vector4> uvs);
        /*0x1e1dcc4*/ void PrintErrorCantAccessIndices();
        /*0x1e1dd60*/ bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles);
        /*0x1e1deac*/ bool CheckCanAccessSubmeshTriangles(int submesh);
        /*0x1e1deb4*/ bool CheckCanAccessSubmeshIndices(int submesh);
        /*0x1e1debc*/ void set_triangles(int[] value);
        /*0x1e1e040*/ int[] GetIndices(int submesh);
        /*0x1e1e048*/ int[] GetIndices(int submesh, bool applyBaseVertex);
        /*0x1e1e0f4*/ void CheckIndicesArrayRange(int valuesLength, int start, int length);
        /*0x1e1df94*/ void SetTrianglesImpl(int submesh, UnityEngine.Rendering.IndexFormat indicesFormat, System.Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex);
        /*0x1e1e294*/ void SetTriangles(int[] triangles, int submesh, bool calculateBounds);
        /*0x1e1e2a0*/ void SetTriangles(int[] triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x1e1e310*/ void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x1e1e3b4*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh);
        /*0x1e1e3c0*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int submesh, bool calculateBounds, int baseVertex);
        /*0x1e1e44c*/ void SetTriangles(System.Collections.Generic.List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds, int baseVertex);
        /*0x1e1e57c*/ void Clear(bool keepVertexLayout);
        /*0x1e1e5cc*/ void Clear();
        /*0x1e1e610*/ void RecalculateBounds();
        /*0x1e1e724*/ void RecalculateNormals();
        /*0x1e1e618*/ void RecalculateBounds(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1e1e72c*/ void RecalculateNormals(UnityEngine.Rendering.MeshUpdateFlags flags);
        /*0x1e1e838*/ void MarkDynamic();
        /*0x1e1e8b0*/ void CombineMeshes(UnityEngine.CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices);
        /*0x1e1cb88*/ void get_bounds_Injected(ref UnityEngine.Bounds ret);
        /*0x1e1cc28*/ void set_bounds_Injected(ref UnityEngine.Bounds value);

        struct MeshData
        {
            /*0x10*/ nint m_Ptr;
        }
    }

    struct CombineInstance
    {
        /*0x10*/ int m_MeshInstanceID;
        /*0x14*/ int m_SubMeshIndex;
        /*0x18*/ UnityEngine.Matrix4x4 m_Transform;
        /*0x58*/ UnityEngine.Vector4 m_LightmapScaleOffset;
        /*0x68*/ UnityEngine.Vector4 m_RealtimeLightmapScaleOffset;

        /*0xadd4ac*/ UnityEngine.Mesh get_mesh();
        /*0xadd4ec*/ void set_mesh(UnityEngine.Mesh value);
        /*0xadd4f4*/ UnityEngine.Matrix4x4 get_transform();
        /*0xadd510*/ void set_transform(UnityEngine.Matrix4x4 value);
    }

    class Texture : UnityEngine.Object
    {
        static /*0x0*/ int GenerateAllMips;

        static /*0x188e010*/ Texture();
        /*0x188426c*/ Texture();
        /*0x188d7a8*/ int GetDataWidth();
        /*0x188d7e8*/ int GetDataHeight();
        /*0x188d828*/ int get_width();
        /*0x188d868*/ void set_width(int value);
        /*0x188d8a8*/ int get_height();
        /*0x188d8e8*/ void set_height(int value);
        /*0x188d928*/ bool get_isReadable();
        /*0x188d968*/ UnityEngine.TextureWrapMode get_wrapMode();
        /*0x188d9a8*/ void set_wrapMode(UnityEngine.TextureWrapMode value);
        /*0x188d9f8*/ UnityEngine.TextureWrapMode get_wrapModeU();
        /*0x188da38*/ void set_wrapModeU(UnityEngine.TextureWrapMode value);
        /*0x188da88*/ UnityEngine.TextureWrapMode get_wrapModeV();
        /*0x188dac8*/ void set_wrapModeV(UnityEngine.TextureWrapMode value);
        /*0x188db18*/ UnityEngine.TextureWrapMode get_wrapModeW();
        /*0x188db58*/ void set_wrapModeW(UnityEngine.TextureWrapMode value);
        /*0x188dba8*/ UnityEngine.FilterMode get_filterMode();
        /*0x188dbe8*/ void set_filterMode(UnityEngine.FilterMode value);
        /*0x188dc38*/ int get_anisoLevel();
        /*0x188dc78*/ void set_anisoLevel(int value);
        /*0x188dcc8*/ void set_mipMapBias(float value);
        /*0x188dd18*/ UnityEngine.Vector2 get_texelSize();
        /*0x188ddc0*/ bool ValidateFormat(UnityEngine.TextureFormat format);
        /*0x1884b14*/ bool ValidateFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage);
        /*0x188df74*/ UnityEngine.UnityException CreateNonReadableException(UnityEngine.Texture t);
        /*0x188dd70*/ void get_texelSize_Injected(ref UnityEngine.Vector2 ret);
    }

    class Texture2D : UnityEngine.Texture
    {
        static /*0x188e060*/ UnityEngine.Texture2D get_whiteTexture();
        static /*0x188e094*/ bool Internal_CreateImpl(UnityEngine.Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x188e11c*/ void Internal_Create(UnityEngine.Texture2D mono, int w, int h, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        /*0x188ea30*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear, nint nativeTex);
        /*0x188eb3c*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x188ebd0*/ Texture2D(int width, int height, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x188ec58*/ Texture2D(int width, int height);
        /*0x188e1f0*/ bool get_isReadable();
        /*0x188e230*/ void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x188e288*/ void SetPixelImpl(int image, int mip, int x, int y, UnityEngine.Color color);
        /*0x188e390*/ UnityEngine.Color GetPixelImpl(int image, int mip, int x, int y);
        /*0x188e49c*/ UnityEngine.Color GetPixelBilinearImpl(int image, int mip, float u, float v);
        /*0x188e5a8*/ void ReadPixelsImpl(UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps);
        /*0x188e698*/ void SetPixelsImpl(int x, int y, int w, int h, UnityEngine.Color[] pixel, int miplevel, int frame);
        /*0x188e730*/ bool LoadRawTextureDataImplArray(byte[] data);
        /*0x188e780*/ void SetAllPixels32(UnityEngine.Color32[] colors, int miplevel);
        /*0x188e7d8*/ void SetBlockOfPixels32(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color32[] colors, int miplevel);
        /*0x188e860*/ UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel);
        /*0x188e8e0*/ UnityEngine.Color[] GetPixels(int x, int y, int blockWidth, int blockHeight);
        /*0x188e954*/ UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable);
        /*0x188e9c4*/ UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D[] textures, int padding, int maximumAtlasSize);
        /*0x188ecf4*/ void SetPixel(int x, int y, UnityEngine.Color color);
        /*0x188ed9c*/ void SetPixels(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color[] colors, int miplevel);
        /*0x188ee60*/ void SetPixels(UnityEngine.Color[] colors);
        /*0x188eec8*/ UnityEngine.Color GetPixel(int x, int y);
        /*0x188ef40*/ UnityEngine.Color GetPixelBilinear(float u, float v);
        /*0x188efb4*/ void LoadRawTextureData(byte[] data);
        /*0x188f0f0*/ void Apply(bool updateMipmaps, bool makeNoLongerReadable);
        /*0x188f180*/ void Apply();
        /*0x188f18c*/ void ReadPixels(UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps);
        /*0x188f230*/ void ReadPixels(UnityEngine.Rect source, int destX, int destY);
        /*0x188f238*/ void SetPixels32(UnityEngine.Color32[] colors, int miplevel);
        /*0x188f290*/ void SetPixels32(UnityEngine.Color32[] colors);
        /*0x188f2e4*/ void SetPixels32(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color32[] colors, int miplevel);
        /*0x188f36c*/ void SetPixels32(int x, int y, int blockWidth, int blockHeight, UnityEngine.Color32[] colors);
        /*0x188f3f0*/ UnityEngine.Color[] GetPixels(int miplevel);
        /*0x188f490*/ UnityEngine.Color[] GetPixels();
        /*0x188e310*/ void SetPixelImpl_Injected(int image, int mip, int x, int y, ref UnityEngine.Color color);
        /*0x188e41c*/ void GetPixelImpl_Injected(int image, int mip, int x, int y, ref UnityEngine.Color ret);
        /*0x188e528*/ void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, ref UnityEngine.Color ret);
        /*0x188e628*/ void ReadPixelsImpl_Injected(ref UnityEngine.Rect source, int destX, int destY, bool recalculateMipMaps);
    }

    class Cubemap : UnityEngine.Texture
    {
        static /*0x1e0efdc*/ bool Internal_CreateImpl(UnityEngine.Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x1e0f05c*/ void Internal_Create(UnityEngine.Cubemap mono, int ext, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x1e0f514*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x1e0f16c*/ Cubemap(int width, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x1e0f1b4*/ Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x1e0f2a8*/ Cubemap(int width, UnityEngine.TextureFormat format, int mipCount);
        /*0x1e0f434*/ Cubemap(int width, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x1e0f314*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex);
        /*0x1e0f5e4*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, bool mipChain, nint nativeTex);
        /*0x1e0f604*/ Cubemap(int width, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x1e0f12c*/ bool get_isReadable();
    }

    class Texture3D : UnityEngine.Texture
    {
        static /*0x188fa48*/ bool Internal_CreateImpl(UnityEngine.Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x188fae0*/ void Internal_Create(UnityEngine.Texture3D mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, nint nativeTex);
        static /*0x188fde0*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x188fbc4*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x188fc4c*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x188fcf8*/ Texture3D(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x188fe3c*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount);
        /*0x188ff50*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, nint nativeTex);
        /*0x1890064*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x1890084*/ Texture3D(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, nint nativeTex);
        /*0x188fa08*/ bool get_isReadable();
    }

    class Texture2DArray : UnityEngine.Texture
    {
        static /*0x188f4d8*/ bool Internal_CreateImpl(UnityEngine.Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x188f560*/ void Internal_Create(UnityEngine.Texture2DArray mono, int w, int h, int d, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x188f84c*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x188f634*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x188f6bc*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x188f768*/ Texture2DArray(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x188f8a8*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x188f9c0*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x188f9e4*/ Texture2DArray(int width, int height, int depth, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x188f498*/ bool get_isReadable();
    }

    class CubemapArray : UnityEngine.Texture
    {
        static /*0x1e0f6c0*/ bool Internal_CreateImpl(UnityEngine.CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x1e0f740*/ void Internal_Create(UnityEngine.CubemapArray mono, int ext, int count, int mipCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        static /*0x1e0f9e0*/ void ValidateIsNotCrunched(UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x1e0f810*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.DefaultFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x1e0f860*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags);
        /*0x1e0f8fc*/ CubemapArray(int width, int cubemapCount, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.TextureCreationFlags flags, int mipCount);
        /*0x1e0fa3c*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, int mipCount, bool linear);
        /*0x1e0fb70*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain, bool linear);
        /*0x1e0fb94*/ CubemapArray(int width, int cubemapCount, UnityEngine.TextureFormat textureFormat, bool mipChain);
        /*0x1e0f680*/ bool get_isReadable();
    }

    class RenderTexture : UnityEngine.Texture
    {
        static /*0x1883dc8*/ UnityEngine.RenderTexture GetActive();
        static /*0x1883dfc*/ void SetActive(UnityEngine.RenderTexture rt);
        static /*0x1883e3c*/ UnityEngine.RenderTexture get_active();
        static /*0x1883e70*/ void set_active(UnityEngine.RenderTexture value);
        static /*0x1883f40*/ void Internal_Create(UnityEngine.RenderTexture rt);
        static /*0x18840fc*/ UnityEngine.RenderTexture GetTemporary_Internal(UnityEngine.RenderTextureDescriptor desc);
        static /*0x188417c*/ void ReleaseTemporary(UnityEngine.RenderTexture temp);
        static /*0x18843d4*/ void ValidateRenderTextureDesc(UnityEngine.RenderTextureDescriptor desc);
        static /*0x1885044*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.RenderTextureFormat renderTextureFormat, UnityEngine.RenderTextureReadWrite readWrite);
        static /*0x1885400*/ UnityEngine.RenderTexture GetTemporary(UnityEngine.RenderTextureDescriptor desc);
        static /*0x18854a8*/ UnityEngine.RenderTexture GetTemporaryImpl(int width, int height, int depthBuffer, UnityEngine.Experimental.Rendering.GraphicsFormat format, int antiAliasing, UnityEngine.RenderTextureMemoryless memorylessMode, UnityEngine.VRTextureUsage vrUsage, bool useDynamicScale);
        static /*0x1885600*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer, UnityEngine.RenderTextureFormat format);
        static /*0x1885664*/ UnityEngine.RenderTexture GetTemporary(int width, int height, int depthBuffer);
        static /*0x18856c8*/ UnityEngine.RenderTexture GetTemporary(int width, int height);
        static /*0x188413c*/ UnityEngine.RenderTexture GetTemporary_Internal_Injected(ref UnityEngine.RenderTextureDescriptor desc);
        /*0x188420c*/ RenderTexture();
        /*0x18842d0*/ RenderTexture(UnityEngine.RenderTextureDescriptor desc);
        /*0x1884684*/ RenderTexture(UnityEngine.RenderTexture textureToCopy);
        /*0x18848ac*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.DefaultFormat format);
        /*0x1884964*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format);
        /*0x1884c9c*/ RenderTexture(int width, int height, int depth, UnityEngine.Experimental.Rendering.GraphicsFormat format, int mipCount);
        /*0x1884ff4*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
        /*0x18851c4*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format);
        /*0x1885214*/ RenderTexture(int width, int height, int depth);
        /*0x1885264*/ RenderTexture(int width, int height, int depth, UnityEngine.RenderTextureFormat format, int mipCount);
        /*0x1883bd0*/ int get_width();
        /*0x1883c10*/ void set_width(int value);
        /*0x1883c60*/ int get_height();
        /*0x1883ca0*/ void set_height(int value);
        /*0x1883cf0*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0x1883d30*/ void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0x1883d80*/ UnityEngine.RenderTextureFormat get_format();
        /*0x1883eb0*/ void MarkRestoreExpected();
        /*0x1883ef0*/ void SetSRGBReadWrite(bool srgb);
        /*0x1883f80*/ void SetRenderTextureDescriptor(UnityEngine.RenderTextureDescriptor desc);
        /*0x1884020*/ UnityEngine.RenderTextureDescriptor GetDescriptor();
        /*0x18841bc*/ void set_depth(int value);
        /*0x18847fc*/ UnityEngine.RenderTextureDescriptor get_descriptor();
        /*0x1884f68*/ void set_descriptor(UnityEngine.RenderTextureDescriptor value);
        /*0x1883fd0*/ void SetRenderTextureDescriptor_Injected(ref UnityEngine.RenderTextureDescriptor desc);
        /*0x18840ac*/ void GetDescriptor_Injected(ref UnityEngine.RenderTextureDescriptor ret);
    }

    class CustomRenderTexture : UnityEngine.RenderTexture
    {
    }

    struct RenderTextureDescriptor
    {
        static /*0x0*/ int[] depthFormatBits;
        /*0x10*/ int <width>k__BackingField;
        /*0x14*/ int <height>k__BackingField;
        /*0x18*/ int <msaaSamples>k__BackingField;
        /*0x1c*/ int <volumeDepth>k__BackingField;
        /*0x20*/ int <mipCount>k__BackingField;
        /*0x24*/ UnityEngine.Experimental.Rendering.GraphicsFormat _graphicsFormat;
        /*0x28*/ UnityEngine.Experimental.Rendering.GraphicsFormat <stencilFormat>k__BackingField;
        /*0x2c*/ int _depthBufferBits;
        /*0x30*/ UnityEngine.Rendering.TextureDimension <dimension>k__BackingField;
        /*0x34*/ UnityEngine.Rendering.ShadowSamplingMode <shadowSamplingMode>k__BackingField;
        /*0x38*/ UnityEngine.VRTextureUsage <vrUsage>k__BackingField;
        /*0x3c*/ UnityEngine.RenderTextureCreationFlags _flags;
        /*0x40*/ UnityEngine.RenderTextureMemoryless <memoryless>k__BackingField;

        static /*0x1885814*/ RenderTextureDescriptor();
        /*0xacc688*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits);
        /*0xacc690*/ RenderTextureDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat colorFormat, int depthBufferBits, int mipCount);
        /*0xacc5a0*/ int get_width();
        /*0xacc5a8*/ void set_width(int value);
        /*0xacc5b0*/ int get_height();
        /*0xacc5b8*/ void set_height(int value);
        /*0xacc5c0*/ int get_msaaSamples();
        /*0xacc5c8*/ void set_msaaSamples(int value);
        /*0xacc5d0*/ int get_volumeDepth();
        /*0xacc5d8*/ void set_volumeDepth(int value);
        /*0xacc5e0*/ void set_mipCount(int value);
        /*0xacc5e8*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_graphicsFormat();
        /*0xacc5f0*/ void set_graphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat value);
        /*0xacc634*/ int get_depthBufferBits();
        /*0xacc63c*/ void set_depthBufferBits(int value);
        /*0xacc668*/ void set_dimension(UnityEngine.Rendering.TextureDimension value);
        /*0xacc670*/ void set_shadowSamplingMode(UnityEngine.Rendering.ShadowSamplingMode value);
        /*0xacc678*/ void set_vrUsage(UnityEngine.VRTextureUsage value);
        /*0xacc680*/ void set_memoryless(UnityEngine.RenderTextureMemoryless value);
        /*0xacc698*/ void SetOrClearRenderTextureCreationFlag(bool value, UnityEngine.RenderTextureCreationFlags flag);
        /*0xacc6b4*/ void set_createdFromScript(bool value);
        /*0xacc6d0*/ void set_useDynamicScale(bool value);
    }

    struct Hash128 : System.IComparable, System.IComparable<UnityEngine.Hash128>, System.IEquatable<UnityEngine.Hash128>
    {
        static ulong kConst = 16045690984833335023;
        /*0x10*/ ulong u64_0;
        /*0x18*/ ulong u64_1;

        static /*0x1e14354*/ string Hash128ToStringImpl(UnityEngine.Hash128 hash);
        static /*0x1e14470*/ bool op_Equality(UnityEngine.Hash128 hash1, UnityEngine.Hash128 hash2);
        static /*0x1e142fc*/ bool op_LessThan(UnityEngine.Hash128 x, UnityEngine.Hash128 y);
        static /*0x1e14314*/ bool op_GreaterThan(UnityEngine.Hash128 x, UnityEngine.Hash128 y);
        static /*0x1e143a0*/ string Hash128ToStringImpl_Injected(ref UnityEngine.Hash128 hash);
        /*0xadd804*/ Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3);
        /*0xadd81c*/ bool get_isValid();
        /*0xadd83c*/ int CompareTo(UnityEngine.Hash128 rhs);
        /*0xadd878*/ string ToString();
        /*0xadd884*/ bool Equals(object obj);
        /*0xadd88c*/ bool Equals(UnityEngine.Hash128 obj);
        /*0xadd8a8*/ int GetHashCode();
        /*0xadd8e4*/ int CompareTo(object obj);
    }

    enum CursorLockMode
    {
        None = 0,
        Locked = 1,
        Confined = 2,
    }

    class Cursor
    {
        static /*0x1e0fc20*/ UnityEngine.CursorLockMode get_lockState();
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
        LeftCommand = 310,
        LeftApple = 310,
        LeftWindows = 311,
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

    interface ILogHandler
    {
        void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
        void LogException(System.Exception exception, UnityEngine.Object context);
    }

    interface ILogger : UnityEngine.ILogHandler
    {
        UnityEngine.ILogHandler get_logHandler();
        bool get_logEnabled();
        void Log(UnityEngine.LogType logType, object message);
        void Log(UnityEngine.LogType logType, object message, UnityEngine.Object context);
        void Log(UnityEngine.LogType logType, string tag, object message);
        void Log(string tag, object message);
        void LogWarning(string tag, object message);
        void LogError(string tag, object message);
        void LogFormat(UnityEngine.LogType logType, string format, object[] args);
        void LogException(System.Exception exception);
    }

    class Logger : UnityEngine.ILogger, UnityEngine.ILogHandler
    {
        /*0x10*/ UnityEngine.ILogHandler <logHandler>k__BackingField;
        /*0x18*/ bool <logEnabled>k__BackingField;
        /*0x1c*/ UnityEngine.LogType <filterLogType>k__BackingField;

        static /*0x1e172ac*/ string GetString(object message);
        /*0x1e116cc*/ Logger(UnityEngine.ILogHandler logHandler);
        /*0x1e1723c*/ UnityEngine.ILogHandler get_logHandler();
        /*0x1e17244*/ void set_logHandler(UnityEngine.ILogHandler value);
        /*0x1e1724c*/ bool get_logEnabled();
        /*0x1e17254*/ void set_logEnabled(bool value);
        /*0x1e17260*/ UnityEngine.LogType get_filterLogType();
        /*0x1e17268*/ void set_filterLogType(UnityEngine.LogType value);
        /*0x1e17270*/ bool IsLogTypeAllowed(UnityEngine.LogType logType);
        /*0x1e173f0*/ void Log(UnityEngine.LogType logType, object message);
        /*0x1e17578*/ void Log(UnityEngine.LogType logType, object message, UnityEngine.Object context);
        /*0x1e17710*/ void Log(UnityEngine.LogType logType, string tag, object message);
        /*0x1e178d0*/ void Log(string tag, object message);
        /*0x1e17a78*/ void LogWarning(string tag, object message);
        /*0x1e17c20*/ void LogError(string tag, object message);
        /*0x1e17dc4*/ void LogException(System.Exception exception);
        /*0x1e17ea0*/ void LogException(System.Exception exception, UnityEngine.Object context);
        /*0x1e17f80*/ void LogFormat(UnityEngine.LogType logType, string format, object[] args);
        /*0x1e18090*/ void LogFormat(UnityEngine.LogType logType, UnityEngine.Object context, string format, object[] args);
    }

    class UnityLogWriter : System.IO.TextWriter
    {
        static /*0x1893664*/ void WriteStringToUnityLog(string s);
        static /*0x18936ac*/ void WriteStringToUnityLogImpl(string s);
        static /*0x18936ec*/ void Init();
        /*0x1893770*/ UnityLogWriter();
        /*0x18937d4*/ System.Text.Encoding get_Encoding();
        /*0x18937dc*/ void Write(char value);
        /*0x189383c*/ void Write(string s);
        /*0x1893884*/ void Write(char[] buffer, int index, int count);
    }

    struct Color : System.IEquatable<UnityEngine.Color>, System.IFormattable
    {
        /*0x10*/ float r;
        /*0x14*/ float g;
        /*0x18*/ float b;
        /*0x1c*/ float a;

        static /*0x1e0d630*/ UnityEngine.Color op_Addition(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x1e0d644*/ UnityEngine.Color op_Subtraction(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x1e0d658*/ UnityEngine.Color op_Multiply(UnityEngine.Color a, UnityEngine.Color b);
        static /*0x1e0d66c*/ UnityEngine.Color op_Multiply(UnityEngine.Color a, float b);
        static /*0x1e0d680*/ UnityEngine.Color op_Division(UnityEngine.Color a, float b);
        static /*0x1e0d694*/ bool op_Equality(UnityEngine.Color lhs, UnityEngine.Color rhs);
        static /*0x1e0d738*/ bool op_Inequality(UnityEngine.Color lhs, UnityEngine.Color rhs);
        static /*0x1e0d754*/ UnityEngine.Color Lerp(UnityEngine.Color a, UnityEngine.Color b, float t);
        static /*0x1e0d7bc*/ UnityEngine.Color LerpUnclamped(UnityEngine.Color a, UnityEngine.Color b, float t);
        static /*0x1e0d810*/ UnityEngine.Color get_red();
        static /*0x1e0d824*/ UnityEngine.Color get_green();
        static /*0x1e0d838*/ UnityEngine.Color get_blue();
        static /*0x1e0d84c*/ UnityEngine.Color get_white();
        static /*0x1e0d860*/ UnityEngine.Color get_black();
        static /*0x1e0d874*/ UnityEngine.Color get_yellow();
        static /*0x1e0d890*/ UnityEngine.Color get_cyan();
        static /*0x1e0d8a4*/ UnityEngine.Color get_magenta();
        static /*0x1e0d8b8*/ UnityEngine.Color get_gray();
        static /*0x1e0d8cc*/ UnityEngine.Color get_grey();
        static /*0x1e0d8e0*/ UnityEngine.Color get_clear();
        static /*0x1e0d4e4*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Color c);
        static /*0x1e0db44*/ UnityEngine.Color op_Implicit(UnityEngine.Vector4 v);
        static /*0x1e0db48*/ void RGBToHSV(UnityEngine.Color rgbColor, ref float H, ref float S, ref float V);
        static /*0x1e0dc60*/ void RGBToHSVHelper(float offset, float dominantcolor, float colorone, float colortwo, ref float H, ref float S, ref float V);
        /*0xadd3c0*/ Color(float r, float g, float b, float a);
        /*0xadd3cc*/ Color(float r, float g, float b);
        /*0xadd3e0*/ string ToString();
        /*0xadd3e8*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0xadd3f0*/ int GetHashCode();
        /*0xadd3f8*/ bool Equals(object other);
        /*0xadd400*/ bool Equals(UnityEngine.Color other);
        /*0xadd408*/ UnityEngine.Color RGBMultiplied(float multiplier);
        /*0xadd424*/ float get_grayscale();
        /*0xadd45c*/ UnityEngine.Color get_linear();
        /*0xadd464*/ UnityEngine.Color get_gamma();
        /*0xadd46c*/ float get_maxColorComponent();
    }

    struct Color32 : System.IFormattable
    {
        /*0x10*/ int rgba;
        /*0x10*/ byte r;
        /*0x11*/ byte g;
        /*0x12*/ byte b;
        /*0x13*/ byte a;

        static /*0x1e0dce4*/ UnityEngine.Color32 op_Implicit(UnityEngine.Color c);
        static /*0x1e0dfb8*/ UnityEngine.Color op_Implicit(UnityEngine.Color32 c);
        static /*0x1e0dff4*/ UnityEngine.Color32 Lerp(UnityEngine.Color32 a, UnityEngine.Color32 b, float t);
        /*0xadd488*/ Color32(byte r, byte g, byte b, byte a);
        /*0xadd49c*/ string ToString();
        /*0xadd4a4*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    class ColorUtility
    {
        static /*0x1e0e344*/ bool DoTryParseHtmlColor(string htmlString, ref UnityEngine.Color32 color);
        static /*0x1e0e394*/ bool TryParseHtmlString(string htmlString, ref UnityEngine.Color color);
        static /*0x1e0e44c*/ string ToHtmlStringRGB(UnityEngine.Color color);
    }

    struct GradientColorKey
    {
        /*0x10*/ UnityEngine.Color color;
        /*0x20*/ float time;

        /*0xadd7f4*/ GradientColorKey(UnityEngine.Color col, float time);
    }

    struct GradientAlphaKey
    {
        /*0x10*/ float alpha;
        /*0x14*/ float time;

        /*0xadd7ec*/ GradientAlphaKey(float alpha, float time);
    }

    enum GradientMode
    {
        Blend = 0,
        Fixed = 1,
    }

    class Gradient : System.IEquatable<UnityEngine.Gradient>
    {
        /*0x10*/ nint m_Ptr;

        static /*0x1e134ec*/ nint Init();
        /*0x1e135b0*/ Gradient();
        /*0x1e13520*/ void Cleanup();
        /*0x1e13560*/ bool Internal_Equals(nint other);
        /*0x1e135fc*/ void Finalize();
        /*0x1e13688*/ UnityEngine.Color Evaluate(float time);
        /*0x1e13754*/ UnityEngine.GradientColorKey[] get_colorKeys();
        /*0x1e13794*/ void set_colorKeys(UnityEngine.GradientColorKey[] value);
        /*0x1e137e4*/ UnityEngine.GradientAlphaKey[] get_alphaKeys();
        /*0x1e13824*/ void set_alphaKeys(UnityEngine.GradientAlphaKey[] value);
        /*0x1e13874*/ UnityEngine.GradientMode get_mode();
        /*0x1e138b4*/ void set_mode(UnityEngine.GradientMode value);
        /*0x1e13904*/ bool Equals(object o);
        /*0x1e139dc*/ bool Equals(UnityEngine.Gradient other);
        /*0x1e13aa8*/ int GetHashCode();
        /*0x1e136f4*/ void Evaluate_Injected(float time, ref UnityEngine.Color ret);
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

        static /*0x1e1c024*/ Matrix4x4();
        static /*0x1e1b29c*/ UnityEngine.Matrix4x4 TRS(UnityEngine.Vector3 pos, UnityEngine.Quaternion q, UnityEngine.Vector3 s);
        static /*0x1e1b398*/ UnityEngine.Matrix4x4 Inverse(UnityEngine.Matrix4x4 m);
        static /*0x1e12f64*/ UnityEngine.Matrix4x4 op_Multiply(UnityEngine.Matrix4x4 lhs, UnityEngine.Matrix4x4 rhs);
        static /*0x1e1b970*/ UnityEngine.Matrix4x4 Scale(UnityEngine.Vector3 vector);
        static /*0x1e1b99c*/ UnityEngine.Matrix4x4 Translate(UnityEngine.Vector3 vector);
        static /*0x1e1b9d0*/ UnityEngine.Matrix4x4 Rotate(UnityEngine.Quaternion q);
        static /*0x1e1ba68*/ UnityEngine.Matrix4x4 get_identity();
        static /*0x1e1b330*/ void TRS_Injected(ref UnityEngine.Vector3 pos, ref UnityEngine.Quaternion q, ref UnityEngine.Vector3 s, ref UnityEngine.Matrix4x4 ret);
        static /*0x1e1b410*/ void Inverse_Injected(ref UnityEngine.Matrix4x4 m, ref UnityEngine.Matrix4x4 ret);
        /*0xaddaec*/ Matrix4x4(UnityEngine.Vector4 column0, UnityEngine.Vector4 column1, UnityEngine.Vector4 column2, UnityEngine.Vector4 column3);
        /*0xaddaac*/ UnityEngine.Matrix4x4 get_inverse();
        /*0xaddafc*/ int GetHashCode();
        /*0xaddb04*/ bool Equals(object other);
        /*0xaddb0c*/ bool Equals(UnityEngine.Matrix4x4 other);
        /*0xaddb44*/ UnityEngine.Vector4 GetColumn(int index);
        /*0xaddb4c*/ UnityEngine.Vector3 MultiplyPoint(UnityEngine.Vector3 point);
        /*0xaddb54*/ UnityEngine.Vector3 MultiplyPoint3x4(UnityEngine.Vector3 point);
        /*0xaddb5c*/ string ToString();
        /*0xaddb64*/ string ToString(string format, System.IFormatProvider formatProvider);
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

        static /*0x2a9317c*/ Vector3();
        static /*0x2a921e0*/ UnityEngine.Vector3 Lerp(UnityEngine.Vector3 a, UnityEngine.Vector3 b, float t);
        static /*0x2a92250*/ UnityEngine.Vector3 LerpUnclamped(UnityEngine.Vector3 a, UnityEngine.Vector3 b, float t);
        static /*0x2a92278*/ UnityEngine.Vector3 MoveTowards(UnityEngine.Vector3 current, UnityEngine.Vector3 target, float maxDistanceDelta);
        static /*0x2a924d0*/ UnityEngine.Vector3 Scale(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x2a924e0*/ UnityEngine.Vector3 Cross(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x2a92630*/ UnityEngine.Vector3 Normalize(UnityEngine.Vector3 value);
        static /*0x2a92820*/ float Dot(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x2a92838*/ float Distance(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x2a92908*/ UnityEngine.Vector3 ClampMagnitude(UnityEngine.Vector3 vector, float maxLength);
        static /*0x2a92a00*/ float Magnitude(UnityEngine.Vector3 vector);
        static /*0x2a92b58*/ float SqrMagnitude(UnityEngine.Vector3 vector);
        static /*0x2a92b70*/ UnityEngine.Vector3 Min(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x2a92be8*/ UnityEngine.Vector3 Max(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x2a926f0*/ UnityEngine.Vector3 get_zero();
        static /*0x2a92c60*/ UnityEngine.Vector3 get_one();
        static /*0x2a92cb0*/ UnityEngine.Vector3 get_forward();
        static /*0x2a92d00*/ UnityEngine.Vector3 get_back();
        static /*0x2a92d50*/ UnityEngine.Vector3 get_up();
        static /*0x2a92da0*/ UnityEngine.Vector3 get_down();
        static /*0x2a92df0*/ UnityEngine.Vector3 get_left();
        static /*0x2a92e40*/ UnityEngine.Vector3 get_right();
        static /*0x2a92e90*/ UnityEngine.Vector3 op_Addition(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x2a92ea0*/ UnityEngine.Vector3 op_Subtraction(UnityEngine.Vector3 a, UnityEngine.Vector3 b);
        static /*0x2a92eb0*/ UnityEngine.Vector3 op_UnaryNegation(UnityEngine.Vector3 a);
        static /*0x2a92ec0*/ UnityEngine.Vector3 op_Multiply(UnityEngine.Vector3 a, float d);
        static /*0x2a92ed0*/ UnityEngine.Vector3 op_Multiply(float d, UnityEngine.Vector3 a);
        static /*0x2a92ee4*/ UnityEngine.Vector3 op_Division(UnityEngine.Vector3 a, float d);
        static /*0x2a92ef4*/ bool op_Equality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        static /*0x2a92f28*/ bool op_Inequality(UnityEngine.Vector3 lhs, UnityEngine.Vector3 rhs);
        /*0xb20a24*/ Vector3(float x, float y, float z);
        /*0xb20a30*/ Vector3(float x, float y);
        /*0xb20a14*/ float get_Item(int index);
        /*0xb20a1c*/ void set_Item(int index, float value);
        /*0xb20a3c*/ void Set(float newX, float newY, float newZ);
        /*0xb20a48*/ int GetHashCode();
        /*0xb20a50*/ bool Equals(object other);
        /*0xb20a58*/ bool Equals(UnityEngine.Vector3 other);
        /*0xb20a88*/ void Normalize();
        /*0xb20a90*/ UnityEngine.Vector3 get_normalized();
        /*0xb20a9c*/ float get_magnitude();
        /*0xb20aa4*/ float get_sqrMagnitude();
        /*0xb20ac4*/ string ToString();
        /*0xb20acc*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Quaternion : System.IEquatable<UnityEngine.Quaternion>, System.IFormattable
    {
        static float kEpsilon = 9.999999974752427e-7;
        static /*0x0*/ UnityEngine.Quaternion identityQuaternion;
        /*0x10*/ float x;
        /*0x14*/ float y;
        /*0x18*/ float z;
        /*0x1c*/ float w;

        static /*0x187f6b4*/ Quaternion();
        static /*0x187e9d4*/ UnityEngine.Quaternion Inverse(UnityEngine.Quaternion rotation);
        static /*0x187ea84*/ UnityEngine.Quaternion Slerp(UnityEngine.Quaternion a, UnityEngine.Quaternion b, float t);
        static /*0x187eb68*/ UnityEngine.Quaternion Lerp(UnityEngine.Quaternion a, UnityEngine.Quaternion b, float t);
        static /*0x187ec4c*/ UnityEngine.Quaternion Internal_FromEulerRad(UnityEngine.Vector3 euler);
        static /*0x187ecfc*/ UnityEngine.Vector3 Internal_ToEulerRad(UnityEngine.Quaternion rotation);
        static /*0x187edb0*/ UnityEngine.Quaternion AngleAxis(float angle, UnityEngine.Vector3 axis);
        static /*0x187ee80*/ UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 forward, UnityEngine.Vector3 upwards);
        static /*0x187ef44*/ UnityEngine.Quaternion LookRotation(UnityEngine.Vector3 forward);
        static /*0x187ef9c*/ UnityEngine.Quaternion get_identity();
        static /*0x187efec*/ UnityEngine.Quaternion op_Multiply(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x187f060*/ UnityEngine.Vector3 op_Multiply(UnityEngine.Quaternion rotation, UnityEngine.Vector3 point);
        static /*0x187f104*/ bool IsEqualUsingDot(float dot);
        static /*0x187f118*/ bool op_Equality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x187f168*/ bool op_Inequality(UnityEngine.Quaternion lhs, UnityEngine.Quaternion rhs);
        static /*0x187f148*/ float Dot(UnityEngine.Quaternion a, UnityEngine.Quaternion b);
        static /*0x187f198*/ UnityEngine.Vector3 Internal_MakePositive(UnityEngine.Vector3 euler);
        static /*0x187f2a0*/ UnityEngine.Quaternion Euler(float x, float y, float z);
        static /*0x187f2b8*/ UnityEngine.Quaternion Euler(UnityEngine.Vector3 euler);
        static /*0x187ea34*/ void Inverse_Injected(ref UnityEngine.Quaternion rotation, ref UnityEngine.Quaternion ret);
        static /*0x187eb00*/ void Slerp_Injected(ref UnityEngine.Quaternion a, ref UnityEngine.Quaternion b, float t, ref UnityEngine.Quaternion ret);
        static /*0x187ebe4*/ void Lerp_Injected(ref UnityEngine.Quaternion a, ref UnityEngine.Quaternion b, float t, ref UnityEngine.Quaternion ret);
        static /*0x187ecac*/ void Internal_FromEulerRad_Injected(ref UnityEngine.Vector3 euler, ref UnityEngine.Quaternion ret);
        static /*0x187ed60*/ void Internal_ToEulerRad_Injected(ref UnityEngine.Quaternion rotation, ref UnityEngine.Vector3 ret);
        static /*0x187ee20*/ void AngleAxis_Injected(float angle, ref UnityEngine.Vector3 axis, ref UnityEngine.Quaternion ret);
        static /*0x187eeec*/ void LookRotation_Injected(ref UnityEngine.Vector3 forward, ref UnityEngine.Vector3 upwards, ref UnityEngine.Quaternion ret);
        /*0xacbfbc*/ Quaternion(float x, float y, float z, float w);
        /*0xacbfc8*/ UnityEngine.Vector3 get_eulerAngles();
        /*0xacbfd0*/ void set_eulerAngles(UnityEngine.Vector3 value);
        /*0xacbfd8*/ int GetHashCode();
        /*0xacbfe0*/ bool Equals(object other);
        /*0xacbfe8*/ bool Equals(UnityEngine.Quaternion other);
        /*0xacbff0*/ string ToString();
        /*0xacbff8*/ string ToString(string format, System.IFormatProvider formatProvider);
    }

    struct Mathf
    {
        static /*0x0*/ float Epsilon;

        static /*0x1e1b164*/ Mathf();
        static /*0x1e1a630*/ int NextPowerOfTwo(int value);
        static /*0x1e0d9e0*/ float GammaToLinearSpace(float value);
        static /*0x1e0dad8*/ float LinearToGammaSpace(float value);
        static /*0x1e1a670*/ float Sin(float f);
        static /*0x1e1a6e0*/ float Cos(float f);
        static /*0x1e1a750*/ float Tan(float f);
        static /*0x1e1a7c0*/ float Asin(float f);
        static /*0x1e1a830*/ float Atan(float f);
        static /*0x1e1a8a0*/ float Atan2(float y, float x);
        static /*0x1e1a918*/ float Sqrt(float f);
        static /*0x1e1a99c*/ float Abs(float f);
        static /*0x1e1aa04*/ int Abs(int value);
        static /*0x1e1aa68*/ float Min(float a, float b);
        static /*0x1e1aa74*/ float Min(float[] values);
        static /*0x1e1aac8*/ int Min(int a, int b);
        static /*0x1e0db38*/ float Max(float a, float b);
        static /*0x1e1aad4*/ int Max(int a, int b);
        static /*0x1e1aae0*/ float Pow(float f, float p);
        static /*0x1e1ab5c*/ float Log(float f, float p);
        static /*0x1e1abd8*/ float Log(float f);
        static /*0x1e1ac48*/ float Ceil(float f);
        static /*0x1e1acb0*/ float Floor(float f);
        static /*0x1e1ad18*/ float Round(float f);
        static /*0x1e1adec*/ int CeilToInt(float f);
        static /*0x1e1ae70*/ int FloorToInt(float f);
        static /*0x1e0e624*/ int RoundToInt(float f);
        static /*0x1e1aef4*/ float Sign(float f);
        static /*0x1e1af08*/ float Clamp(float value, float min, float max);
        static /*0x1e0e70c*/ int Clamp(int value, int min, int max);
        static /*0x1e0d7a0*/ float Clamp01(float value);
        static /*0x1e1af24*/ float Lerp(float a, float b, float t);
        static /*0x1e1af48*/ float LerpAngle(float a, float b, float t);
        static /*0x1e1afd4*/ bool Approximately(float a, float b);
        static /*0x1e1b068*/ float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime);
        static /*0x1e1afac*/ float Repeat(float t, float length);
        static /*0x1e1b134*/ float InverseLerp(float a, float b, float value);
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

        static /*0x1894b38*/ Vector2();
        static /*0x1894288*/ UnityEngine.Vector2 Lerp(UnityEngine.Vector2 a, UnityEngine.Vector2 b, float t);
        static /*0x18942dc*/ UnityEngine.Vector2 Scale(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x1894708*/ float Dot(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x189472c*/ float Angle(UnityEngine.Vector2 from, UnityEngine.Vector2 to);
        static /*0x1894848*/ float Distance(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x18948f8*/ UnityEngine.Vector2 Max(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x1894948*/ UnityEngine.Vector2 op_Addition(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x1894954*/ UnityEngine.Vector2 op_Subtraction(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x1894960*/ UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x189496c*/ UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, UnityEngine.Vector2 b);
        static /*0x1894978*/ UnityEngine.Vector2 op_UnaryNegation(UnityEngine.Vector2 a);
        static /*0x1894984*/ UnityEngine.Vector2 op_Multiply(UnityEngine.Vector2 a, float d);
        static /*0x1894990*/ UnityEngine.Vector2 op_Multiply(float d, UnityEngine.Vector2 a);
        static /*0x18949a0*/ UnityEngine.Vector2 op_Division(UnityEngine.Vector2 a, float d);
        static /*0x18949ac*/ bool op_Equality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x18949d4*/ bool op_Inequality(UnityEngine.Vector2 lhs, UnityEngine.Vector2 rhs);
        static /*0x18949fc*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector3 v);
        static /*0x1894a00*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector2 v);
        static /*0x18823bc*/ UnityEngine.Vector2 get_zero();
        static /*0x1881a60*/ UnityEngine.Vector2 get_one();
        static /*0x1894a08*/ UnityEngine.Vector2 get_up();
        static /*0x1894a54*/ UnityEngine.Vector2 get_down();
        static /*0x1894aa0*/ UnityEngine.Vector2 get_left();
        static /*0x1894aec*/ UnityEngine.Vector2 get_right();
        /*0xaccb90*/ Vector2(float x, float y);
        /*0xaccb80*/ float get_Item(int index);
        /*0xaccb88*/ void set_Item(int index, float value);
        /*0xaccb98*/ void Set(float newX, float newY);
        /*0xaccba0*/ void Scale(UnityEngine.Vector2 scale);
        /*0xaccbb4*/ void Normalize();
        /*0xaccbbc*/ UnityEngine.Vector2 get_normalized();
        /*0xaccbe8*/ string ToString();
        /*0xaccbf0*/ string ToString(string format, System.IFormatProvider formatProvider);
        /*0xaccbf8*/ int GetHashCode();
        /*0xaccc34*/ bool Equals(object other);
        /*0xaccc3c*/ bool Equals(UnityEngine.Vector2 other);
        /*0xaccc60*/ float get_magnitude();
        /*0xaccc68*/ float get_sqrMagnitude();
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

        static /*0x2a92154*/ Vector2Int();
        static /*0x2a91cf0*/ float Distance(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b);
        static /*0x2a91db4*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector2Int v);
        static /*0x2a91dc4*/ UnityEngine.Vector2Int op_Addition(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b);
        static /*0x2a91ddc*/ UnityEngine.Vector2Int op_Subtraction(UnityEngine.Vector2Int a, UnityEngine.Vector2Int b);
        static /*0x2a91df4*/ bool op_Equality(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs);
        static /*0x2a91e14*/ bool op_Inequality(UnityEngine.Vector2Int lhs, UnityEngine.Vector2Int rhs);
        static /*0x2a92108*/ UnityEngine.Vector2Int get_zero();
        /*0xb20930*/ Vector2Int(int x, int y);
        /*0xb20910*/ int get_x();
        /*0xb20918*/ void set_x(int value);
        /*0xb20920*/ int get_y();
        /*0xb20928*/ void set_y(int value);
        /*0xb20938*/ bool Equals(object other);
        /*0xb209d4*/ bool Equals(UnityEngine.Vector2Int other);
        /*0xb209fc*/ int GetHashCode();
        /*0xb20a04*/ string ToString();
        /*0xb20a0c*/ string ToString(string format, System.IFormatProvider formatProvider);
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

        static /*0x2a93650*/ Vector3Int();
        static /*0x2a932b8*/ bool op_Equality(UnityEngine.Vector3Int lhs, UnityEngine.Vector3Int rhs);
        /*0xb20b04*/ Vector3Int(int x, int y, int z);
        /*0xb20ad4*/ int get_x();
        /*0xb20adc*/ void set_x(int value);
        /*0xb20ae4*/ int get_y();
        /*0xb20aec*/ void set_y(int value);
        /*0xb20af4*/ int get_z();
        /*0xb20afc*/ void set_z(int value);
        /*0xb20b10*/ bool Equals(object other);
        /*0xb20bc0*/ bool Equals(UnityEngine.Vector3Int other);
        /*0xb20bf8*/ int GetHashCode();
        /*0xb20c00*/ string ToString();
        /*0xb20c08*/ string ToString(string format, System.IFormatProvider formatProvider);
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

        static /*0x2a93e1c*/ Vector4();
        static /*0x2a93990*/ float Dot(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x2a93a80*/ UnityEngine.Vector4 get_zero();
        static /*0x2a93ad0*/ UnityEngine.Vector4 op_Addition(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x2a93ae4*/ UnityEngine.Vector4 op_Subtraction(UnityEngine.Vector4 a, UnityEngine.Vector4 b);
        static /*0x2a93af8*/ UnityEngine.Vector4 op_Multiply(UnityEngine.Vector4 a, float d);
        static /*0x2a93b0c*/ UnityEngine.Vector4 op_Division(UnityEngine.Vector4 a, float d);
        static /*0x2a93b20*/ bool op_Equality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs);
        static /*0x2a93b60*/ bool op_Inequality(UnityEngine.Vector4 lhs, UnityEngine.Vector4 rhs);
        static /*0x2a93ba0*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Vector3 v);
        static /*0x2a93ba8*/ UnityEngine.Vector3 op_Implicit(UnityEngine.Vector4 v);
        static /*0x2a93bac*/ UnityEngine.Vector4 op_Implicit(UnityEngine.Vector2 v);
        static /*0x2a93bb8*/ UnityEngine.Vector2 op_Implicit(UnityEngine.Vector4 v);
        /*0xb20c20*/ Vector4(float x, float y, float z, float w);
        /*0xb20c10*/ float get_Item(int index);
        /*0xb20c18*/ void set_Item(int index, float value);
        /*0xb20c2c*/ int GetHashCode();
        /*0xb20c34*/ bool Equals(object other);
        /*0xb20c3c*/ bool Equals(UnityEngine.Vector4 other);
        /*0xb20c78*/ float get_magnitude();
        /*0xb20c80*/ float get_sqrMagnitude();
        /*0xb20ca8*/ string ToString();
        /*0xb20cb0*/ string ToString(string format, System.IFormatProvider formatProvider);
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
        static /*0x187dc04*/ bool IsConnected();
        static /*0x187db9c*/ void Initialize();
        static /*0x187da60*/ void RegisterInternal(string messageId);
        static /*0x187db28*/ void UnregisterInternal(string messageId);
        static /*0x187d778*/ void SendMessage(string messageId, byte[] data, int playerId);
        static /*0x187d918*/ bool TrySendMessage(string messageId, byte[] data, int playerId);
        static /*0x187d9a4*/ void PollInternal();
        static /*0x187dc6c*/ void DisconnectAll();
        /*0x187bdf0*/ PlayerConnectionInternal();
        /*0x187d634*/ void UnityEngine.IPlayerEditorConnectionNative.SendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x187d7d0*/ bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(System.Guid messageId, byte[] data, int playerId);
        /*0x187d970*/ void UnityEngine.IPlayerEditorConnectionNative.Poll();
        /*0x187d9d8*/ void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(System.Guid messageId);
        /*0x187daa0*/ void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(System.Guid messageId);
        /*0x187db68*/ void UnityEngine.IPlayerEditorConnectionNative.Initialize();
        /*0x187dbd0*/ bool UnityEngine.IPlayerEditorConnectionNative.IsConnected();
        /*0x187dc38*/ void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll();
    }

    class PlayerPrefsException : System.Exception
    {
        /*0x187e330*/ PlayerPrefsException(string error);
    }

    class PlayerPrefs
    {
        static /*0x187e1a4*/ bool TrySetInt(string key, int value);
        static /*0x187e1f4*/ bool TrySetFloat(string key, float value);
        static /*0x187e244*/ bool TrySetSetString(string key, string value);
        static /*0x187e294*/ void SetInt(string key, int value);
        static /*0x187e3a4*/ int GetInt(string key, int defaultValue);
        static /*0x187e3f4*/ int GetInt(string key);
        static /*0x187e438*/ void SetFloat(string key, float value);
        static /*0x187e4d4*/ float GetFloat(string key, float defaultValue);
        static /*0x187e524*/ float GetFloat(string key);
        static /*0x187e568*/ void SetString(string key, string value);
        static /*0x187e604*/ string GetString(string key, string defaultValue);
        static /*0x187e654*/ string GetString(string key);
        static /*0x187e6cc*/ bool HasKey(string key);
        static /*0x187e70c*/ void DeleteKey(string key);
        static /*0x187e74c*/ void DeleteAll();
        static /*0x187e780*/ void Save();
    }

    class PropertyAttribute : System.Attribute
    {
        /*0x187e924*/ PropertyAttribute();
    }

    class TooltipAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ string tooltip;

        /*0x1890348*/ TooltipAttribute(string tooltip);
    }

    class SpaceAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ float height;

        /*0x1889a24*/ SpaceAttribute();
        /*0x1889a50*/ SpaceAttribute(float height);
    }

    class HeaderAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ string header;

        /*0x1e1458c*/ HeaderAttribute(string header);
    }

    class RangeAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ float min;
        /*0x14*/ float max;

        /*0x187f87c*/ RangeAttribute(float min, float max);
    }

    class TextAreaAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ int minLines;
        /*0x14*/ int maxLines;

        /*0x188d3c4*/ TextAreaAttribute();
        /*0x188d3f0*/ TextAreaAttribute(int minLines, int maxLines);
    }

    class ColorUsageAttribute : UnityEngine.PropertyAttribute
    {
        /*0x10*/ bool showAlpha;
        /*0x11*/ bool hdr;
        /*0x14*/ float minBrightness;
        /*0x18*/ float maxBrightness;
        /*0x1c*/ float minExposureValue;
        /*0x20*/ float maxExposureValue;

        /*0x1e0e300*/ ColorUsageAttribute(bool showAlpha);
    }

    class Random
    {
        static /*0x187f708*/ float Range(float minInclusive, float maxInclusive);
        static /*0x187f754*/ int Range(int minInclusive, int maxExclusive);
        static /*0x187f7a4*/ int RandomRangeInt(int minInclusive, int maxExclusive);
        static /*0x187f7f4*/ void GetRandomUnitCircle(ref UnityEngine.Vector2 output);
        static /*0x187f834*/ UnityEngine.Vector2 get_insideUnitCircle();
    }

    class ResourceRequest : UnityEngine.AsyncOperation
    {
        /*0x20*/ string m_Path;
        /*0x28*/ System.Type m_Type;

        /*0x1886908*/ ResourceRequest();
        /*0x188686c*/ UnityEngine.Object GetResult();
        /*0x18868fc*/ UnityEngine.Object get_asset();
    }

    class ResourcesAPIInternal
    {
        static /*0x1886c84*/ UnityEngine.Shader FindShaderByName(string name);
        static /*0x1886d14*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        static /*0x1886dc4*/ UnityEngine.ResourceRequest LoadAsyncInternal(string path, System.Type type);
        static /*0x1886e54*/ void UnloadAsset(UnityEngine.Object assetToUnload);
    }

    class ResourcesAPI
    {
        static /*0x0*/ UnityEngine.ResourcesAPI s_DefaultAPI;
        static /*0x8*/ UnityEngine.ResourcesAPI <overrideAPI>k__BackingField;

        static /*0x1886e94*/ ResourcesAPI();
        static /*0x1886998*/ UnityEngine.ResourcesAPI get_ActiveAPI();
        static /*0x1886bd8*/ UnityEngine.ResourcesAPI get_overrideAPI();
        /*0x1886c3c*/ ResourcesAPI();
        /*0x1886c44*/ UnityEngine.Shader FindShaderByName(string name);
        /*0x1886cc4*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        /*0x1886d64*/ UnityEngine.ResourceRequest LoadAsync(string path, System.Type systemTypeInstance);
        /*0x1886e14*/ void UnloadAsset(UnityEngine.Object assetToUnload);
    }

    class Resources
    {
        static T[] ConvertObjects<T>(UnityEngine.Object[] rawObjects);
        static /*0x1886910*/ UnityEngine.Object Load(string path);
        static T Load<T>(string path);
        static /*0x1886878*/ UnityEngine.Object Load(string path, System.Type systemTypeInstance);
        static UnityEngine.ResourceRequest LoadAsync<T>(string path);
        static /*0x1886a5c*/ UnityEngine.ResourceRequest LoadAsync(string path, System.Type type);
        static /*0x1886ae0*/ UnityEngine.Object GetBuiltinResource(System.Type type, string path);
        static T GetBuiltinResource<T>(string path);
        static /*0x1886b30*/ void UnloadAsset(UnityEngine.Object assetToUnload);
        static /*0x1886ba4*/ UnityEngine.AsyncOperation UnloadUnusedAssets();
    }

    class AsyncOperation : UnityEngine.YieldInstruction
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ System.Action<UnityEngine.AsyncOperation> m_completeCallback;

        static /*0x1e09f4c*/ void InternalDestroy(nint ptr);
        /*0x1e0a2b0*/ AsyncOperation();
        /*0x1e09f8c*/ bool get_isDone();
        /*0x1e09fcc*/ float get_progress();
        /*0x1e0a00c*/ void set_allowSceneActivation(bool value);
        /*0x1e0a05c*/ void Finalize();
        /*0x1e0a0f8*/ void InvokeCompletionEvent();
        /*0x1e0a154*/ void add_completed(System.Action<UnityEngine.AsyncOperation> value);
        /*0x1e0a234*/ void remove_completed(System.Action<UnityEngine.AsyncOperation> value);
    }

    class AttributeHelperEngine
    {
        static /*0x0*/ UnityEngine.DisallowMultipleComponent[] _disallowMultipleComponentArray;
        static /*0x8*/ UnityEngine.ExecuteInEditMode[] _executeInEditModeArray;
        static /*0x10*/ UnityEngine.RequireComponent[] _requireComponentArray;

        static /*0x1e0a9e4*/ AttributeHelperEngine();
        static /*0x1e0a2b8*/ System.Type GetParentTypeDisallowingMultipleInclusion(System.Type type);
        static /*0x1e0a3cc*/ System.Type[] GetRequiredComponents(System.Type klass);
        static /*0x1e0a73c*/ int GetExecuteMode(System.Type klass);
        static /*0x1e0a85c*/ int CheckIsEditorScript(System.Type klass);
        static /*0x1e0a958*/ int GetDefaultExecutionOrderFor(System.Type klass);
        static T GetCustomAttributeOfType<T>(System.Type klass);
    }

    class DisallowMultipleComponent : System.Attribute
    {
        /*0x1e11a08*/ DisallowMultipleComponent();
    }

    class RequireComponent : System.Attribute
    {
        /*0x10*/ System.Type m_Type0;
        /*0x18*/ System.Type m_Type1;
        /*0x20*/ System.Type m_Type2;

        /*0x1886638*/ RequireComponent(System.Type requiredComponent);
        /*0x1886664*/ RequireComponent(System.Type requiredComponent, System.Type requiredComponent2);
        /*0x188669c*/ RequireComponent(System.Type requiredComponent, System.Type requiredComponent2, System.Type requiredComponent3);
    }

    class AddComponentMenu : System.Attribute
    {
        /*0x10*/ string m_AddComponentMenu;
        /*0x18*/ int m_Ordering;

        /*0x1e082e4*/ AddComponentMenu(string menuName);
        /*0x1e08314*/ AddComponentMenu(string menuName, int order);
    }

    class CreateAssetMenuAttribute : System.Attribute
    {
        /*0x10*/ string <menuName>k__BackingField;
        /*0x18*/ string <fileName>k__BackingField;
        /*0x20*/ int <order>k__BackingField;

        /*0x1e0efd4*/ CreateAssetMenuAttribute();
        /*0x1e0efbc*/ void set_menuName(string value);
        /*0x1e0efc4*/ void set_fileName(string value);
        /*0x1e0efcc*/ void set_order(int value);
    }

    class ContextMenu : System.Attribute
    {
        /*0x10*/ string menuItem;
        /*0x18*/ bool validate;
        /*0x1c*/ int priority;

        /*0x1e0ee08*/ ContextMenu(string itemName);
        /*0x1e0ee44*/ ContextMenu(string itemName, bool isValidateFunction);
        /*0x1e0ee90*/ ContextMenu(string itemName, bool isValidateFunction, int priority);
    }

    class ExecuteInEditMode : System.Attribute
    {
        /*0x1e1230c*/ ExecuteInEditMode();
    }

    class ExecuteAlways : System.Attribute
    {
        /*0x1e12304*/ ExecuteAlways();
    }

    class HideInInspector : System.Attribute
    {
        /*0x1e14624*/ HideInInspector();
    }

    class HelpURLAttribute : System.Attribute
    {
        /*0x10*/ string m_Url;
        /*0x18*/ bool m_Dispatcher;
        /*0x20*/ string m_DispatchingFieldName;

        /*0x1e145b8*/ HelpURLAttribute(string url);
    }

    class DefaultExecutionOrder : System.Attribute
    {
        /*0x10*/ int m_Order;

        /*0x1e0a9dc*/ int get_order();
    }

    class AssemblyIsEditorAssembly : System.Attribute
    {
    }

    class ExcludeFromPresetAttribute : System.Attribute
    {
        /*0x1e122fc*/ ExcludeFromPresetAttribute();
    }

    class Behaviour : UnityEngine.Component
    {
        /*0x1e0b048*/ Behaviour();
        /*0x1e0af78*/ bool get_enabled();
        /*0x1e0afb8*/ void set_enabled(bool value);
        /*0x1e0b008*/ bool get_isActiveAndEnabled();
    }

    struct CastHelper<T>
    {
        /*0x0*/ T t;
        /*0x0*/ nint onePointerFurtherThanT;
    }

    class ClassLibraryInitializer
    {
        static /*0x1e0d224*/ void Init();
    }

    class Component : UnityEngine.Object
    {
        /*0x1e0b04c*/ Component();
        /*0x1e0e87c*/ UnityEngine.Transform get_transform();
        /*0x1e0e8bc*/ UnityEngine.GameObject get_gameObject();
        /*0x1e0e8fc*/ UnityEngine.Component GetComponent(System.Type type);
        /*0x1e0e9d0*/ void GetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        T GetComponent<T>();
        bool TryGetComponent<T>(ref T component);
        /*0x1e0ea28*/ UnityEngine.Component GetComponentInChildren(System.Type t, bool includeInactive);
        T GetComponentInChildren<T>();
        T[] GetComponentsInChildren<T>(bool includeInactive);
        void GetComponentsInChildren<T>(bool includeInactive, System.Collections.Generic.List<T> result);
        T[] GetComponentsInChildren<T>();
        void GetComponentsInChildren<T>(System.Collections.Generic.List<T> results);
        /*0x1e0eb0c*/ UnityEngine.Component GetComponentInParent(System.Type t);
        T GetComponentInParent<T>();
        T[] GetComponentsInParent<T>(bool includeInactive);
        void GetComponentsInParent<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        T[] GetComponentsInParent<T>();
        /*0x1e0ebe8*/ void GetComponentsForListInternal(System.Type searchType, object resultList);
        /*0x1e0ec40*/ void GetComponents(System.Type type, System.Collections.Generic.List<UnityEngine.Component> results);
        void GetComponents<T>(System.Collections.Generic.List<T> results);
        T[] GetComponents<T>();
        /*0x1e0ec98*/ void SendMessage(string methodName, object value);
        /*0x1e0ecf4*/ void SendMessage(string methodName, object value, UnityEngine.SendMessageOptions options);
        /*0x1e0ed5c*/ void SendMessage(string methodName, UnityEngine.SendMessageOptions options);
    }

    class Coroutine : UnityEngine.YieldInstruction
    {
        /*0x10*/ nint m_Ptr;

        static /*0x1e0ef7c*/ void ReleaseCoroutine(nint ptr);
        /*0x1e0eed8*/ Coroutine();
        /*0x1e0eee0*/ void Finalize();
    }

    class SetupCoroutine
    {
        static /*0x18894fc*/ void InvokeMoveNext(System.Collections.IEnumerator enumerator, nint returnValueAddress);
        static /*0x1889648*/ object InvokeMember(object behaviour, string name, object variable);
    }

    class CustomYieldInstruction : System.Collections.IEnumerator
    {
        /*0x1e0fd64*/ CustomYieldInstruction();
        bool get_keepWaiting();
        /*0x1e0fd4c*/ object get_Current();
        /*0x1e0fd54*/ bool MoveNext();
        /*0x1e0fd60*/ void Reset();
    }

    class ExcludeFromObjectFactoryAttribute : System.Attribute
    {
        /*0x1e122f4*/ ExcludeFromObjectFactoryAttribute();
    }

    class ExtensionOfNativeClassAttribute : System.Attribute
    {
        /*0x1e12314*/ ExtensionOfNativeClassAttribute();
    }

    class FailedToLoadScriptObject : UnityEngine.Object
    {
    }

    class GameObject : UnityEngine.Object
    {
        static /*0x1e12bb4*/ void Internal_CreateGameObject(UnityEngine.GameObject self, string name);
        static /*0x1e12dc0*/ UnityEngine.GameObject Find(string name);
        /*0x1e12b18*/ GameObject(string name);
        /*0x1e12c04*/ GameObject();
        /*0x1e12c94*/ GameObject(string name, System.Type[] components);
        T GetComponent<T>();
        /*0x1e0e980*/ UnityEngine.Component GetComponent(System.Type type);
        /*0x1e125b0*/ void GetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x1e12608*/ UnityEngine.Component GetComponentByName(string type);
        /*0x1e12658*/ UnityEngine.Component GetComponent(string type);
        /*0x1e0eab4*/ UnityEngine.Component GetComponentInChildren(System.Type type, bool includeInactive);
        T GetComponentInChildren<T>();
        T GetComponentInChildren<T>(bool includeInactive);
        /*0x1e126a8*/ UnityEngine.Component GetComponentInParent(System.Type type, bool includeInactive);
        /*0x1e0eb94*/ UnityEngine.Component GetComponentInParent(System.Type type);
        T GetComponentInParent<T>();
        T GetComponentInParent<T>(bool includeInactive);
        /*0x1e12700*/ System.Array GetComponentsInternal(System.Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList);
        T[] GetComponents<T>();
        void GetComponents<T>(System.Collections.Generic.List<T> results);
        T[] GetComponentsInChildren<T>(bool includeInactive);
        void GetComponentsInChildren<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        T[] GetComponentsInChildren<T>();
        void GetComponentsInChildren<T>(System.Collections.Generic.List<T> results);
        void GetComponentsInParent<T>(bool includeInactive, System.Collections.Generic.List<T> results);
        T[] GetComponentsInParent<T>(bool includeInactive);
        bool TryGetComponent<T>(ref T component);
        /*0x1e12788*/ void TryGetComponentFastPath(System.Type type, nint oneFurtherThanResultValue);
        /*0x1e127e0*/ UnityEngine.Component Internal_AddComponentWithType(System.Type componentType);
        /*0x1e12830*/ UnityEngine.Component AddComponent(System.Type componentType);
        T AddComponent<T>();
        /*0x1e12880*/ UnityEngine.Transform get_transform();
        /*0x1e128c0*/ int get_layer();
        /*0x1e12900*/ void set_layer(int value);
        /*0x1e12950*/ void SetActive(bool value);
        /*0x1e129a0*/ bool get_activeSelf();
        /*0x1e129e0*/ bool get_activeInHierarchy();
        /*0x1e12a20*/ string get_tag();
        /*0x1e12a60*/ void set_tag(string value);
        /*0x1e12ab0*/ void SendMessage(string methodName, object value, UnityEngine.SendMessageOptions options);
        /*0x1e12e00*/ UnityEngine.GameObject get_gameObject();
    }

    struct LayerMask
    {
        /*0x10*/ int m_Mask;

        static /*0x1e15074*/ int op_Implicit(UnityEngine.LayerMask mask);
        static /*0x1e15078*/ UnityEngine.LayerMask op_Implicit(int intVal);
        static /*0x1e15090*/ int NameToLayer(string layerName);
        /*0xadd998*/ int get_value();
        /*0xadd9a0*/ void set_value(int value);
    }

    class ManagedStreamHelpers
    {
        static /*0x1e181a8*/ void ValidateLoadFromStream(System.IO.Stream stream);
        static /*0x1e182b0*/ void ManagedStreamRead(byte[] buffer, int offset, int count, System.IO.Stream stream, nint returnValueAddress);
        static /*0x1e183c0*/ void ManagedStreamSeek(long offset, uint origin, System.IO.Stream stream, nint returnValueAddress);
        static /*0x1e184c8*/ void ManagedStreamLength(System.IO.Stream stream, nint returnValueAddress);
    }

    class MonoBehaviour : UnityEngine.Behaviour
    {
        static /*0x1e1f5f4*/ void print(object message);
        static /*0x1e1ec28*/ void Internal_CancelInvokeAll(UnityEngine.MonoBehaviour self);
        static /*0x1e1eba8*/ bool Internal_IsInvokingAll(UnityEngine.MonoBehaviour self);
        static /*0x1e1eccc*/ void InvokeDelayed(UnityEngine.MonoBehaviour self, string methodName, float time, float repeatRate);
        static /*0x1e1ee4c*/ void CancelInvoke(UnityEngine.MonoBehaviour self, string methodName);
        static /*0x1e1eeec*/ bool IsInvoking(UnityEngine.MonoBehaviour self, string methodName);
        static /*0x1e1f054*/ bool IsObjectMonoBehaviour(UnityEngine.Object obj);
        /*0x1e1f694*/ MonoBehaviour();
        /*0x1e1eb68*/ bool IsInvoking();
        /*0x1e1ebe8*/ void CancelInvoke();
        /*0x1e1ec68*/ void Invoke(string methodName, float time);
        /*0x1e1ed34*/ void InvokeRepeating(string methodName, float time, float repeatRate);
        /*0x1e1edfc*/ void CancelInvoke(string methodName);
        /*0x1e1ee9c*/ bool IsInvoking(string methodName);
        /*0x1e1ef3c*/ UnityEngine.Coroutine StartCoroutine(string methodName);
        /*0x1e1ef44*/ UnityEngine.Coroutine StartCoroutine(string methodName, object value);
        /*0x1e1f0ec*/ UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator routine);
        /*0x1e1f238*/ UnityEngine.Coroutine StartCoroutine_Auto(System.Collections.IEnumerator routine);
        /*0x1e1f23c*/ void StopCoroutine(System.Collections.IEnumerator routine);
        /*0x1e1f388*/ void StopCoroutine(UnityEngine.Coroutine routine);
        /*0x1e1f4d4*/ void StopCoroutine(string methodName);
        /*0x1e1f524*/ void StopAllCoroutines();
        /*0x1e1f564*/ bool get_useGUILayout();
        /*0x1e1f5a4*/ void set_useGUILayout(bool value);
        /*0x1e1f094*/ UnityEngine.Coroutine StartCoroutineManaged(string methodName, object value);
        /*0x1e1f1e8*/ UnityEngine.Coroutine StartCoroutineManaged2(System.Collections.IEnumerator enumerator);
        /*0x1e1f484*/ void StopCoroutineManaged(UnityEngine.Coroutine routine);
        /*0x1e1f338*/ void StopCoroutineFromEnumeratorManaged(System.Collections.IEnumerator routine);
        /*0x1e1f654*/ string GetScriptClassName();
    }

    class NoAllocHelpers
    {
        static void ResizeList<T>(System.Collections.Generic.List<T> list, int size);
        static void EnsureListElemCount<T>(System.Collections.Generic.List<T> list, int count);
        static /*0x1e1df84*/ int SafeLength(System.Array values);
        static int SafeLength<T>(System.Collections.Generic.List<T> values);
        static T[] ExtractArrayFromListT<T>(System.Collections.Generic.List<T> list);
        static /*0x1e1f798*/ void Internal_ResizeList(object list, int size);
        static /*0x1e1e53c*/ System.Array ExtractArrayFromList(object list);
    }

    struct RangeInt
    {
        /*0x10*/ int start;
        /*0x14*/ int length;

        /*0xacc00c*/ RangeInt(int start, int length);
        /*0xacc000*/ int get_end();
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

        /*0x1886ef4*/ RuntimeInitializeOnLoadMethodAttribute();
        /*0x1886f24*/ RuntimeInitializeOnLoadMethodAttribute(UnityEngine.RuntimeInitializeLoadType loadType);
        /*0x1886f1c*/ void set_loadType(UnityEngine.RuntimeInitializeLoadType value);
    }

    class ScriptableObject : UnityEngine.Object
    {
        static /*0x1888d64*/ UnityEngine.ScriptableObject CreateInstance(System.Type type);
        static T CreateInstance<T>();
        static /*0x1888d24*/ void CreateScriptableObject(UnityEngine.ScriptableObject self);
        static /*0x1888da8*/ UnityEngine.ScriptableObject CreateScriptableObjectInstanceFromType(System.Type type, bool applyDefaultsAndReset);
        /*0x187b240*/ ScriptableObject();
    }

    class ScriptingUtility
    {
        static /*0x18894e4*/ bool IsManagedCodeWorking();

        struct TestClass
        {
            /*0x10*/ int value;
        }
    }

    class SelectionBaseAttribute : System.Attribute
    {
        /*0x18894ec*/ SelectionBaseAttribute();
    }

    class StackTraceUtility
    {
        static /*0x0*/ string projectFolder;

        static /*0x188be08*/ StackTraceUtility();
        static /*0x188b174*/ void SetProjectFolder(string folder);
        static /*0x188b264*/ string ExtractStackTrace();
        static /*0x188ba90*/ void ExtractStringFromExceptionInternal(object exceptiono, ref string message, ref string stackTrace);
        static /*0x188b3b4*/ string ExtractFormattedStackTrace(System.Diagnostics.StackTrace stackTrace);
    }

    class UnityException : System.Exception
    {
        /*0x189354c*/ UnityException();
        /*0x1879068*/ UnityException(string message);
        /*0x18935d8*/ UnityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    }

    class MissingReferenceException : System.Exception
    {
        /*0x1e1e9cc*/ MissingReferenceException();
        /*0x1e1ea58*/ MissingReferenceException(string message);
        /*0x1e1eadc*/ MissingReferenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
    }

    class TextAsset : UnityEngine.Object
    {
        static /*0x188d4ac*/ string DecodeString(byte[] bytes);
        /*0x188d428*/ byte[] get_bytes();
        /*0x188d468*/ string get_text();
        /*0x188d7a4*/ string ToString();

        class EncodingUtility
        {
            static /*0x0*/ System.Collections.Generic.KeyValuePair<System.Byte[], System.Text.Encoding> encodingLookup;
            static /*0x8*/ System.Text.Encoding targetEncoding;

            static /*0x2a97160*/ EncodingUtility();
        }
    }

    class TrackedReference
    {
        /*0x10*/ nint m_Ptr;
    }

    class UnhandledExceptionHandler
    {
        static /*0x1892720*/ void RegisterUECatcher();

        class <>c
        {
            static /*0x0*/ UnityEngine.UnhandledExceptionHandler.<> <>9;
            static /*0x8*/ System.UnhandledExceptionEventHandler <>9__0_0;

            static /*0x2a97584*/ <>c();
            /*0x2a975e4*/ <>c();
            /*0x2a975ec*/ void <RegisterUECatcher>b__0_0(object sender, System.UnhandledExceptionEventArgs e);
        }
    }

    class UnityAPICompatibilityVersionAttribute : System.Attribute
    {
        /*0x10*/ string _version;
        /*0x18*/ string[] _configurationAssembliesHashes;

        /*0x1892828*/ UnityAPICompatibilityVersionAttribute(string version, string[] configurationAssembliesHashes);
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

        static /*0x18798d0*/ Object();
        static /*0x1878c74*/ bool op_Implicit(UnityEngine.Object exists);
        static /*0x1878bb0*/ bool CompareBaseObjects(UnityEngine.Object lhs, UnityEngine.Object rhs);
        static /*0x1878ce4*/ bool IsNativeObjectAlive(UnityEngine.Object o);
        static /*0x1878edc*/ UnityEngine.Object Instantiate(UnityEngine.Object original);
        static /*0x18790ec*/ UnityEngine.Object Instantiate(UnityEngine.Object original, UnityEngine.Transform parent, bool instantiateInWorldSpace);
        static T Instantiate<T>(T original);
        static T Instantiate<T>(T original, UnityEngine.Transform parent);
        static T Instantiate<T>(T original, UnityEngine.Transform parent, bool worldPositionStays);
        static /*0x18792ac*/ void Destroy(UnityEngine.Object obj, float t);
        static /*0x18792fc*/ void Destroy(UnityEngine.Object obj);
        static /*0x1879380*/ void DestroyImmediate(UnityEngine.Object obj, bool allowDestroyingAssets);
        static /*0x18793d0*/ void DestroyImmediate(UnityEngine.Object obj);
        static /*0x1879454*/ UnityEngine.Object[] FindObjectsOfType(System.Type type);
        static /*0x18794d8*/ UnityEngine.Object[] FindObjectsOfType(System.Type type, bool includeInactive);
        static /*0x1879528*/ void DontDestroyOnLoad(UnityEngine.Object target);
        static T[] FindObjectsOfType<T>();
        static T FindObjectOfType<T>();
        static /*0x1878fd8*/ void CheckNullArgument(object arg, string message);
        static /*0x18795f8*/ UnityEngine.Object FindObjectOfType(System.Type type);
        static /*0x187969c*/ UnityEngine.Object FindObjectOfType(System.Type type, bool includeInactive);
        static /*0x1878b40*/ bool op_Equality(UnityEngine.Object x, UnityEngine.Object y);
        static /*0x187980c*/ bool op_Inequality(UnityEngine.Object x, UnityEngine.Object y);
        static /*0x18789f4*/ int GetOffsetOfInstanceIDInCPlusPlusObject();
        static /*0x1879028*/ UnityEngine.Object Internal_CloneSingle(UnityEngine.Object data);
        static /*0x1879254*/ UnityEngine.Object Internal_CloneSingleWithParent(UnityEngine.Object data, UnityEngine.Transform parent, bool worldPositionStays);
        static /*0x18797cc*/ string ToString(UnityEngine.Object obj);
        static /*0x1878dbc*/ string GetName(UnityEngine.Object obj);
        static /*0x1878e8c*/ void SetName(UnityEngine.Object obj, string name);
        static /*0x1879888*/ UnityEngine.Object FindObjectFromInstanceID(int instanceID);
        /*0x18798c8*/ Object();
        /*0x18788b4*/ int GetInstanceID();
        /*0x1878a28*/ int GetHashCode();
        /*0x1878a30*/ bool Equals(object other);
        /*0x1878d34*/ nint GetCachedPtr();
        /*0x1878d3c*/ string get_name();
        /*0x1878dfc*/ void set_name(string value);
        /*0x1879568*/ UnityEngine.HideFlags get_hideFlags();
        /*0x18795a8*/ void set_hideFlags(UnityEngine.HideFlags value);
        /*0x187974c*/ string ToString();
    }

    class UnitySynchronizationContext : System.Threading.SynchronizationContext
    {
        /*0x18*/ System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue;
        /*0x20*/ System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork;
        /*0x28*/ int m_MainThreadID;
        /*0x2c*/ int m_TrackedCount;

        static /*0x1894040*/ void InitializeSynchronizationContext();
        static /*0x18940bc*/ void ExecuteTasks();
        static /*0x1894130*/ bool ExecutePendingTasks(long millisecondsTimeout);
        /*0x18938d0*/ UnitySynchronizationContext(int mainThreadID);
        /*0x1893988*/ UnitySynchronizationContext(System.Collections.Generic.List<UnityEngine.UnitySynchronizationContext.WorkRequest> queue, int mainThreadID);
        /*0x1893a24*/ void Send(System.Threading.SendOrPostCallback callback, object state);
        /*0x1893cd8*/ void OperationStarted();
        /*0x1893ce4*/ void OperationCompleted();
        /*0x1893cf0*/ void Post(System.Threading.SendOrPostCallback callback, object state);
        /*0x1893de8*/ System.Threading.SynchronizationContext CreateCopy();
        /*0x1893e58*/ void Exec();
        /*0x1893fdc*/ bool HasPendingTasks();

        struct WorkRequest
        {
            /*0x10*/ System.Threading.SendOrPostCallback m_DelagateCallback;
            /*0x18*/ object m_DelagateState;
            /*0x20*/ System.Threading.ManualResetEvent m_WaitHandle;

            /*0xb20efc*/ WorkRequest(System.Threading.SendOrPostCallback callback, object state, System.Threading.ManualResetEvent waitHandle);
            /*0xb20f08*/ void Invoke();
        }
    }

    class WaitForEndOfFrame : UnityEngine.YieldInstruction
    {
        /*0x2a93e94*/ WaitForEndOfFrame();
    }

    class WaitForFixedUpdate : UnityEngine.YieldInstruction
    {
    }

    class WaitForSeconds : UnityEngine.YieldInstruction
    {
        /*0x10*/ float m_Seconds;

        /*0x2a93ea4*/ WaitForSeconds(float seconds);
    }

    class WaitForSecondsRealtime : UnityEngine.CustomYieldInstruction
    {
        /*0x10*/ float <waitTime>k__BackingField;
        /*0x14*/ float m_WaitUntilTime;

        /*0x2a93f5c*/ WaitForSecondsRealtime(float time);
        /*0x2a93ed8*/ float get_waitTime();
        /*0x2a93ee0*/ void set_waitTime(float value);
        /*0x2a93ee8*/ bool get_keepWaiting();
        /*0x2a93f98*/ void Reset();
    }

    class WaitUntil : UnityEngine.CustomYieldInstruction
    {
        /*0x10*/ System.Func<bool> m_Predicate;

        /*0x2a94004*/ WaitUntil(System.Func<bool> predicate);
        /*0x2a93fa4*/ bool get_keepWaiting();
    }

    class YieldInstruction
    {
        /*0x2a93e9c*/ YieldInstruction();
    }

    class SerializeField : System.Attribute
    {
        /*0x18894f4*/ SerializeField();
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

    class ComputeShader : UnityEngine.Object
    {
        /*0x1e0edb8*/ int FindKernel(string name);
    }

    class LowerResBlitTexture : UnityEngine.Object
    {
        /*0x1e181a4*/ void LowerResBlitTextureDontStripMe();
    }

    class PreloadData : UnityEngine.Object
    {
        /*0x187e7b4*/ void PreloadDataDontStripMe();
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
        static /*0x188c820*/ float get_batteryLevel();
        static /*0x188c888*/ string get_operatingSystem();
        static /*0x188c8f0*/ UnityEngine.OperatingSystemFamily get_operatingSystemFamily();
        static /*0x188c958*/ string get_processorType();
        static /*0x188c9c0*/ int get_processorFrequency();
        static /*0x188ca28*/ int get_processorCount();
        static /*0x188ca90*/ int get_systemMemorySize();
        static /*0x188caf8*/ string get_deviceUniqueIdentifier();
        static /*0x188cb60*/ string get_deviceName();
        static /*0x188cbc8*/ string get_deviceModel();
        static /*0x188cc30*/ UnityEngine.DeviceType get_deviceType();
        static /*0x188cc98*/ int get_graphicsMemorySize();
        static /*0x188cd00*/ string get_graphicsDeviceName();
        static /*0x188cd68*/ string get_graphicsDeviceVendor();
        static /*0x188cdd0*/ int get_graphicsDeviceID();
        static /*0x188ce38*/ int get_graphicsDeviceVendorID();
        static /*0x188cea0*/ UnityEngine.Rendering.GraphicsDeviceType get_graphicsDeviceType();
        static /*0x188cf08*/ string get_graphicsDeviceVersion();
        static /*0x188cf70*/ int get_graphicsShaderLevel();
        static /*0x188cfd8*/ UnityEngine.Rendering.CopyTextureSupport get_copyTextureSupport();
        static /*0x188d040*/ int get_supportedRenderTargetCount();
        static /*0x188d0a8*/ bool IsValidEnumValue(System.Enum value);
        static /*0x188d12c*/ bool SupportsRenderTextureFormat(UnityEngine.RenderTextureFormat format);
        static /*0x188d244*/ bool SupportsTextureFormat(UnityEngine.TextureFormat format);
        static /*0x188d35c*/ int get_maxTextureSize();
        static /*0x188c854*/ float GetBatteryLevel();
        static /*0x188c8bc*/ string GetOperatingSystem();
        static /*0x188c924*/ UnityEngine.OperatingSystemFamily GetOperatingSystemFamily();
        static /*0x188c98c*/ string GetProcessorType();
        static /*0x188c9f4*/ int GetProcessorFrequencyMHz();
        static /*0x188ca5c*/ int GetProcessorCount();
        static /*0x188cac4*/ int GetPhysicalMemoryMB();
        static /*0x188cb2c*/ string GetDeviceUniqueIdentifier();
        static /*0x188cb94*/ string GetDeviceName();
        static /*0x188cbfc*/ string GetDeviceModel();
        static /*0x188cc64*/ UnityEngine.DeviceType GetDeviceType();
        static /*0x188cccc*/ int GetGraphicsMemorySize();
        static /*0x188cd34*/ string GetGraphicsDeviceName();
        static /*0x188cd9c*/ string GetGraphicsDeviceVendor();
        static /*0x188ce04*/ int GetGraphicsDeviceID();
        static /*0x188ce6c*/ int GetGraphicsDeviceVendorID();
        static /*0x188ced4*/ UnityEngine.Rendering.GraphicsDeviceType GetGraphicsDeviceType();
        static /*0x188cf3c*/ string GetGraphicsDeviceVersion();
        static /*0x188cfa4*/ int GetGraphicsShaderLevel();
        static /*0x188d00c*/ UnityEngine.Rendering.CopyTextureSupport GetCopyTextureSupport();
        static /*0x188d074*/ int SupportedRenderTargetCount();
        static /*0x188d204*/ bool HasRenderTextureNative(UnityEngine.RenderTextureFormat format);
        static /*0x188d31c*/ bool SupportsTextureFormatNative(UnityEngine.TextureFormat format);
        static /*0x188d390*/ int GetMaxTextureSize();
        static /*0x18852cc*/ bool IsFormatSupported(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage);
        static /*0x18853b0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetCompatibleFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage);
        static /*0x1884924*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.Experimental.Rendering.DefaultFormat format);
    }

    class SystemClock
    {
        static /*0x0*/ System.DateTime s_Epoch;

        static /*0x188c79c*/ SystemClock();
        static /*0x188c740*/ System.DateTime get_now();
    }

    class Time
    {
        static /*0x1890130*/ float get_time();
        static /*0x1890164*/ float get_deltaTime();
        static /*0x1890198*/ float get_unscaledTime();
        static /*0x18901cc*/ float get_unscaledDeltaTime();
        static /*0x1890200*/ float get_fixedDeltaTime();
        static /*0x1890234*/ float get_smoothDeltaTime();
        static /*0x1890268*/ float get_timeScale();
        static /*0x189029c*/ void set_timeScale(float value);
        static /*0x18902e0*/ int get_frameCount();
        static /*0x1890314*/ float get_realtimeSinceStartup();
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

        static /*0x1890374*/ void Internal_Destroy(nint ptr);
        static /*0x1890644*/ nint TouchScreenKeyboard_InternalConstructorHelper(ref UnityEngine.TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder);
        static /*0x189069c*/ bool get_isSupported();
        static /*0x18906f8*/ bool get_disableInPlaceEditing();
        static /*0x1890744*/ bool get_isInPlaceEditingAllowed();
        static /*0x18907c0*/ bool IsInPlaceEditingAllowed();
        static /*0x18907f4*/ bool get_isRequiredToForceOpen();
        static /*0x1890828*/ bool IsRequiredToForceOpen();
        static /*0x189085c*/ UnityEngine.TouchScreenKeyboard Open(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit);
        static /*0x1890918*/ UnityEngine.TouchScreenKeyboard Open(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure);
        static /*0x1890a38*/ void set_hideInput(bool value);
        static /*0x1890c74*/ void GetSelection(ref int start, ref int length);
        static /*0x1890dbc*/ void SetSelection(int start, int length);
        /*0x18904d8*/ TouchScreenKeyboard(string text, UnityEngine.TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit);
        /*0x18903b4*/ void Destroy();
        /*0x1890470*/ void Finalize();
        /*0x18909a8*/ string get_text();
        /*0x18909e8*/ void set_text(string value);
        /*0x1890a78*/ bool get_active();
        /*0x1890ab8*/ void set_active(bool value);
        /*0x1890b08*/ UnityEngine.TouchScreenKeyboard.Status get_status();
        /*0x1890b48*/ void set_characterLimit(int value);
        /*0x1890b98*/ bool get_canGetSelection();
        /*0x1890bd8*/ bool get_canSetSelection();
        /*0x1890c18*/ UnityEngine.RangeInt get_selection();
        /*0x1890cc4*/ void set_selection(UnityEngine.RangeInt value);

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
        /*0xadd7ac*/ void Add(UnityEngine.Object driver, UnityEngine.RectTransform rectTransform, UnityEngine.DrivenTransformProperties drivenProperties);
        /*0xadd7b0*/ void Clear();
    }

    class RectTransform : UnityEngine.Transform
    {
        static /*0x0*/ UnityEngine.RectTransform.ReapplyDrivenProperties reapplyDrivenProperties;

        static /*0x1880f34*/ void add_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value);
        static /*0x1880ff0*/ void remove_reapplyDrivenProperties(UnityEngine.RectTransform.ReapplyDrivenProperties value);
        static /*0x1882314*/ void SendReapplyDrivenProperties(UnityEngine.RectTransform driven);
        /*0x18810ac*/ UnityEngine.Rect get_rect();
        /*0x1881158*/ UnityEngine.Vector2 get_anchorMin();
        /*0x1881200*/ void set_anchorMin(UnityEngine.Vector2 value);
        /*0x18812a4*/ UnityEngine.Vector2 get_anchorMax();
        /*0x188134c*/ void set_anchorMax(UnityEngine.Vector2 value);
        /*0x18813f0*/ UnityEngine.Vector2 get_anchoredPosition();
        /*0x1881498*/ void set_anchoredPosition(UnityEngine.Vector2 value);
        /*0x188153c*/ UnityEngine.Vector2 get_sizeDelta();
        /*0x18815e4*/ void set_sizeDelta(UnityEngine.Vector2 value);
        /*0x1881688*/ UnityEngine.Vector2 get_pivot();
        /*0x1881730*/ void set_pivot(UnityEngine.Vector2 value);
        /*0x18817d4*/ UnityEngine.Vector3 get_anchoredPosition3D();
        /*0x1881874*/ void set_anchoredPosition3D(UnityEngine.Vector3 value);
        /*0x1881908*/ UnityEngine.Vector2 get_offsetMin();
        /*0x1881968*/ void set_offsetMin(UnityEngine.Vector2 value);
        /*0x1881aac*/ UnityEngine.Vector2 get_offsetMax();
        /*0x1881b50*/ void set_offsetMax(UnityEngine.Vector2 value);
        /*0x1881c50*/ void GetLocalCorners(UnityEngine.Vector3[] fourCornersArray);
        /*0x1881d50*/ void GetWorldCorners(UnityEngine.Vector3[] fourCornersArray);
        /*0x1881f3c*/ void SetInsetAndSizeFromParentEdge(UnityEngine.RectTransform.Edge edge, float inset, float size);
        /*0x188214c*/ void SetSizeWithCurrentAnchors(UnityEngine.RectTransform.Axis axis, float size);
        /*0x1882204*/ UnityEngine.Vector2 GetParentSize();
        /*0x1881108*/ void get_rect_Injected(ref UnityEngine.Rect ret);
        /*0x18811b0*/ void get_anchorMin_Injected(ref UnityEngine.Vector2 ret);
        /*0x1881254*/ void set_anchorMin_Injected(ref UnityEngine.Vector2 value);
        /*0x18812fc*/ void get_anchorMax_Injected(ref UnityEngine.Vector2 ret);
        /*0x18813a0*/ void set_anchorMax_Injected(ref UnityEngine.Vector2 value);
        /*0x1881448*/ void get_anchoredPosition_Injected(ref UnityEngine.Vector2 ret);
        /*0x18814ec*/ void set_anchoredPosition_Injected(ref UnityEngine.Vector2 value);
        /*0x1881594*/ void get_sizeDelta_Injected(ref UnityEngine.Vector2 ret);
        /*0x1881638*/ void set_sizeDelta_Injected(ref UnityEngine.Vector2 value);
        /*0x18816e0*/ void get_pivot_Injected(ref UnityEngine.Vector2 ret);
        /*0x1881784*/ void set_pivot_Injected(ref UnityEngine.Vector2 value);

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
            /*0x2a96d58*/ ReapplyDrivenProperties(object object, nint method);
            /*0x2a96db8*/ void Invoke(UnityEngine.RectTransform driven);
            /*0x2a97130*/ System.IAsyncResult BeginInvoke(UnityEngine.RectTransform driven, System.AsyncCallback callback, object object);
            /*0x2a97154*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class Transform : UnityEngine.Component, System.Collections.IEnumerable
    {
        static /*0x18923ac*/ UnityEngine.Transform FindRelativeTransformWithPath(UnityEngine.Transform transform, string path, bool isActiveOnly);
        /*0x1890fbc*/ Transform();
        /*0x1890fc4*/ UnityEngine.Vector3 get_position();
        /*0x1891074*/ void set_position(UnityEngine.Vector3 value);
        /*0x1881814*/ UnityEngine.Vector3 get_localPosition();
        /*0x18818b0*/ void set_localPosition(UnityEngine.Vector3 value);
        /*0x18911bc*/ UnityEngine.Vector3 get_eulerAngles();
        /*0x1891244*/ void set_eulerAngles(UnityEngine.Vector3 value);
        /*0x18912d4*/ UnityEngine.Vector3 get_localEulerAngles();
        /*0x189135c*/ void set_localEulerAngles(UnityEngine.Vector3 value);
        /*0x18913ec*/ UnityEngine.Vector3 get_up();
        /*0x1891444*/ UnityEngine.Vector3 get_forward();
        /*0x189149c*/ void set_forward(UnityEngine.Vector3 value);
        /*0x18911e8*/ UnityEngine.Quaternion get_rotation();
        /*0x189127c*/ void set_rotation(UnityEngine.Quaternion value);
        /*0x1891300*/ UnityEngine.Quaternion get_localRotation();
        /*0x1891394*/ void set_localRotation(UnityEngine.Quaternion value);
        /*0x189163c*/ UnityEngine.Vector3 get_localScale();
        /*0x18916ec*/ void set_localScale(UnityEngine.Vector3 value);
        /*0x188237c*/ UnityEngine.Transform get_parent();
        /*0x18917d4*/ void set_parent(UnityEngine.Transform value);
        /*0x1891794*/ UnityEngine.Transform get_parentInternal();
        /*0x18918b4*/ void set_parentInternal(UnityEngine.Transform value);
        /*0x1891908*/ UnityEngine.Transform GetParent();
        /*0x1891948*/ void SetParent(UnityEngine.Transform p);
        /*0x189199c*/ void SetParent(UnityEngine.Transform parent, bool worldPositionStays);
        /*0x18919f4*/ UnityEngine.Matrix4x4 get_worldToLocalMatrix();
        /*0x1881ec4*/ UnityEngine.Matrix4x4 get_localToWorldMatrix();
        /*0x1891b0c*/ void SetPositionAndRotation(UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
        /*0x1891bc8*/ void Translate(UnityEngine.Vector3 translation, UnityEngine.Space relativeTo);
        /*0x1891cc0*/ void Translate(UnityEngine.Vector3 translation);
        /*0x1891cc8*/ void Rotate(UnityEngine.Vector3 eulers, UnityEngine.Space relativeTo);
        /*0x1891e0c*/ void Rotate(UnityEngine.Vector3 eulers);
        /*0x1891e14*/ void Rotate(float xAngle, float yAngle, float zAngle, UnityEngine.Space relativeTo);
        /*0x1891e18*/ void Rotate(float xAngle, float yAngle, float zAngle);
        /*0x1891e20*/ void LookAt(UnityEngine.Vector3 worldPosition);
        /*0x1891e7c*/ void Internal_LookAt(UnityEngine.Vector3 worldPosition, UnityEngine.Vector3 worldUp);
        /*0x1891c54*/ UnityEngine.Vector3 TransformDirection(UnityEngine.Vector3 direction);
        /*0x1891f90*/ UnityEngine.Vector3 InverseTransformDirection(UnityEngine.Vector3 direction);
        /*0x1892054*/ UnityEngine.Vector3 TransformPoint(UnityEngine.Vector3 position);
        /*0x1892118*/ UnityEngine.Vector3 InverseTransformPoint(UnityEngine.Vector3 position);
        /*0x18921dc*/ UnityEngine.Transform get_root();
        /*0x189221c*/ UnityEngine.Transform GetRoot();
        /*0x189225c*/ int get_childCount();
        /*0x189229c*/ void SetAsFirstSibling();
        /*0x18922dc*/ void SetAsLastSibling();
        /*0x189231c*/ void SetSiblingIndex(int index);
        /*0x189236c*/ int GetSiblingIndex();
        /*0x1892404*/ UnityEngine.Transform Find(string n);
        /*0x18924a4*/ UnityEngine.Vector3 get_lossyScale();
        /*0x1892554*/ bool IsChildOf(UnityEngine.Transform parent);
        /*0x18925a4*/ System.Collections.IEnumerator GetEnumerator();
        /*0x1892604*/ UnityEngine.Transform GetChild(int index);
        /*0x1891024*/ void get_position_Injected(ref UnityEngine.Vector3 ret);
        /*0x18910cc*/ void set_position_Injected(ref UnityEngine.Vector3 value);
        /*0x189111c*/ void get_localPosition_Injected(ref UnityEngine.Vector3 ret);
        /*0x189116c*/ void set_localPosition_Injected(ref UnityEngine.Vector3 value);
        /*0x18914fc*/ void get_rotation_Injected(ref UnityEngine.Quaternion ret);
        /*0x189154c*/ void set_rotation_Injected(ref UnityEngine.Quaternion value);
        /*0x189159c*/ void get_localRotation_Injected(ref UnityEngine.Quaternion ret);
        /*0x18915ec*/ void set_localRotation_Injected(ref UnityEngine.Quaternion value);
        /*0x189169c*/ void get_localScale_Injected(ref UnityEngine.Vector3 ret);
        /*0x1891744*/ void set_localScale_Injected(ref UnityEngine.Vector3 value);
        /*0x1891a6c*/ void get_worldToLocalMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        /*0x1891abc*/ void get_localToWorldMatrix_Injected(ref UnityEngine.Matrix4x4 ret);
        /*0x1891b70*/ void SetPositionAndRotation_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Quaternion rotation);
        /*0x1891ee0*/ void Internal_LookAt_Injected(ref UnityEngine.Vector3 worldPosition, ref UnityEngine.Vector3 worldUp);
        /*0x1891f38*/ void TransformDirection_Injected(ref UnityEngine.Vector3 direction, ref UnityEngine.Vector3 ret);
        /*0x1891ffc*/ void InverseTransformDirection_Injected(ref UnityEngine.Vector3 direction, ref UnityEngine.Vector3 ret);
        /*0x18920c0*/ void TransformPoint_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        /*0x1892184*/ void InverseTransformPoint_Injected(ref UnityEngine.Vector3 position, ref UnityEngine.Vector3 ret);
        /*0x1892504*/ void get_lossyScale_Injected(ref UnityEngine.Vector3 ret);

        class Enumerator : System.Collections.IEnumerator
        {
            /*0x10*/ UnityEngine.Transform outer;
            /*0x18*/ int currentIndex;

            /*0x2a974dc*/ Enumerator(UnityEngine.Transform outer);
            /*0x2a97510*/ object get_Current();
            /*0x2a97534*/ bool MoveNext();
            /*0x2a97578*/ void Reset();
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
        /*0x188aee8*/ UnityEngine.Sprite get_sprite();
        /*0x188af28*/ void set_sprite(UnityEngine.Sprite value);
        /*0x188af78*/ UnityEngine.Vector2 get_size();
        /*0x188b020*/ UnityEngine.Color get_color();
        /*0x188b0cc*/ void set_color(UnityEngine.Color value);
        /*0x188afd0*/ void get_size_Injected(ref UnityEngine.Vector2 ret);
        /*0x188b07c*/ void get_color_Injected(ref UnityEngine.Color ret);
        /*0x188b124*/ void set_color_Injected(ref UnityEngine.Color value);
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
        static /*0x1889e58*/ UnityEngine.Sprite CreateSprite(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape);
        static /*0x188a530*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border, bool generateFallbackPhysicsShape);
        static /*0x188a91c*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, UnityEngine.Vector4 border);
        static /*0x188a92c*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType);
        static /*0x188a9dc*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude);
        static /*0x188a9e4*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot, float pixelsPerUnit);
        static /*0x188a9f0*/ UnityEngine.Sprite Create(UnityEngine.Texture2D texture, UnityEngine.Rect rect, UnityEngine.Vector2 pivot);
        static /*0x1889efc*/ UnityEngine.Sprite CreateSprite_Injected(UnityEngine.Texture2D texture, ref UnityEngine.Rect rect, ref UnityEngine.Vector2 pivot, float pixelsPerUnit, uint extrude, UnityEngine.SpriteMeshType meshType, ref UnityEngine.Vector4 border, bool generateFallbackPhysicsShape);
        /*0x1889a84*/ Sprite();
        /*0x1889ae8*/ int GetPackingMode();
        /*0x1889b28*/ int GetPackingRotation();
        /*0x1889b68*/ int GetPacked();
        /*0x1889ba8*/ UnityEngine.Rect GetTextureRect();
        /*0x1889c54*/ UnityEngine.Vector4 GetInnerUVs();
        /*0x1889d00*/ UnityEngine.Vector4 GetOuterUVs();
        /*0x1889dac*/ UnityEngine.Vector4 GetPadding();
        /*0x1889f94*/ UnityEngine.Bounds get_bounds();
        /*0x188a050*/ UnityEngine.Rect get_rect();
        /*0x188a0fc*/ UnityEngine.Vector4 get_border();
        /*0x188a1a8*/ UnityEngine.Texture2D get_texture();
        /*0x188a1e8*/ float get_pixelsPerUnit();
        /*0x188a228*/ UnityEngine.Texture2D get_associatedAlphaSplitTexture();
        /*0x188a268*/ UnityEngine.Vector2 get_pivot();
        /*0x188a310*/ bool get_packed();
        /*0x188a35c*/ UnityEngine.SpritePackingMode get_packingMode();
        /*0x188a39c*/ UnityEngine.SpritePackingRotation get_packingRotation();
        /*0x188a3dc*/ UnityEngine.Rect get_textureRect();
        /*0x188a470*/ UnityEngine.Vector2[] get_vertices();
        /*0x188a4b0*/ ushort[] get_triangles();
        /*0x188a4f0*/ UnityEngine.Vector2[] get_uv();
        /*0x1889c04*/ void GetTextureRect_Injected(ref UnityEngine.Rect ret);
        /*0x1889cb0*/ void GetInnerUVs_Injected(ref UnityEngine.Vector4 ret);
        /*0x1889d5c*/ void GetOuterUVs_Injected(ref UnityEngine.Vector4 ret);
        /*0x1889e08*/ void GetPadding_Injected(ref UnityEngine.Vector4 ret);
        /*0x188a000*/ void get_bounds_Injected(ref UnityEngine.Bounds ret);
        /*0x188a0ac*/ void get_rect_Injected(ref UnityEngine.Rect ret);
        /*0x188a158*/ void get_border_Injected(ref UnityEngine.Vector4 ret);
        /*0x188a2c0*/ void get_pivot_Injected(ref UnityEngine.Vector2 ret);
    }

    namespace _Scripting
    {
        namespace APIUpdating
        {
            class APIUpdaterRuntimeHelpers
            {
                static /*0x1e07ed8*/ bool GetMovedFromAttributeDataForType(System.Type sourceType, ref string assembly, ref string nsp, ref string klass);
                static /*0x1e08020*/ bool GetObsoleteTypeRedirection(System.Type sourceType, ref string assemblyName, ref string nsp, ref string className);
            }
        }
    }

    namespace Sprites
    {
        class DataUtility
        {
            static /*0x1e0fd6c*/ UnityEngine.Vector4 GetInnerUV(UnityEngine.Sprite sprite);
            static /*0x1e0fd84*/ UnityEngine.Vector4 GetOuterUV(UnityEngine.Sprite sprite);
            static /*0x1e0fd9c*/ UnityEngine.Vector4 GetPadding(UnityEngine.Sprite sprite);
            static /*0x1e0fdb4*/ UnityEngine.Vector2 GetMinSize(UnityEngine.Sprite sprite);
        }
    }

    namespace U2D
    {
        struct SpriteBone
        {
            /*0x10*/ string m_Name;
            /*0x18*/ UnityEngine.Vector3 m_Position;
            /*0x24*/ UnityEngine.Quaternion m_Rotation;
            /*0x34*/ float m_Length;
            /*0x38*/ int m_ParentId;
        }

        class SpriteAtlasManager
        {
            static /*0x0*/ System.Action<string, System.Action<UnityEngine.U2D.SpriteAtlas>> atlasRequested;
            static /*0x8*/ System.Action<UnityEngine.U2D.SpriteAtlas> atlasRegistered;

            static /*0x188ae90*/ SpriteAtlasManager();
            static /*0x188aaa4*/ bool RequestAtlas(string tag);
            static /*0x188abcc*/ void add_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value);
            static /*0x188acc4*/ void remove_atlasRegistered(System.Action<UnityEngine.U2D.SpriteAtlas> value);
            static /*0x188adbc*/ void PostRegisteredAtlas(UnityEngine.U2D.SpriteAtlas spriteAtlas);
            static /*0x188ae50*/ void Register(UnityEngine.U2D.SpriteAtlas spriteAtlas);
        }

        class SpriteAtlas : UnityEngine.Object
        {
            /*0x188aa04*/ bool CanBindTo(UnityEngine.Sprite sprite);
            /*0x188aa54*/ UnityEngine.Sprite GetSprite(string name);
        }
    }

    namespace Profiling
    {
        class Profiler
        {
            static /*0x187e7c0*/ long GetTotalAllocatedMemoryLong();
            static /*0x187e7f4*/ long GetTotalUnusedReservedMemoryLong();
            static /*0x187e828*/ long GetTotalReservedMemoryLong();
        }

        namespace Experimental
        {
            struct DebugScreenCapture
            {
                /*0x10*/ Unity.Collections.NativeArray<byte> <rawImageDataReference>k__BackingField;
                /*0x20*/ UnityEngine.TextureFormat <imageFormat>k__BackingField;
                /*0x24*/ int <width>k__BackingField;
                /*0x28*/ int <height>k__BackingField;

                /*0xadd5e4*/ void set_rawImageDataReference(Unity.Collections.NativeArray<byte> value);
                /*0xadd5ec*/ void set_imageFormat(UnityEngine.TextureFormat value);
                /*0xadd5f4*/ void set_width(int value);
                /*0xadd5fc*/ void set_height(int value);
            }
        }

        namespace Memory
        {
            namespace Experimental
            {
                class MetaData
                {
                    /*0x10*/ string content;
                    /*0x18*/ string platform;

                    /*0x1e1c340*/ MetaData();
                }

                class MemoryProfiler
                {
                    static /*0x0*/ System.Action<string, bool> m_SnapshotFinished;
                    static /*0x8*/ System.Action<string, bool, UnityEngine.Profiling.Experimental.DebugScreenCapture> m_SaveScreenshotToDisk;
                    static /*0x10*/ System.Action<UnityEngine.Profiling.Memory.Experimental.MetaData> createMetaData;

                    static /*0x1e1c1ac*/ byte[] PrepareMetadata();
                    static /*0x1e1c348*/ int WriteIntToByteArray(byte[] array, int offset, int value);
                    static /*0x1e1c3e8*/ int WriteStringToByteArray(byte[] array, int offset, string value);
                    static /*0x1e1c490*/ void FinalizeSnapshot(string path, bool result);
                    static /*0x1e1c524*/ void SaveScreenshotToDisk(string path, bool result, nint pixelsPtr, int pixelsCount, UnityEngine.TextureFormat format, int width, int height);
                }
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
            static /*0x1879ba0*/ string TidyAssemblyTypeName(string assemblyTypeName);
        }

        class ArgumentCache : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Object m_ObjectArgument;
            /*0x18*/ string m_ObjectArgumentAssemblyTypeName;
            /*0x20*/ int m_IntArgument;
            /*0x24*/ float m_FloatArgument;
            /*0x28*/ string m_StringArgument;
            /*0x30*/ bool m_BoolArgument;

            /*0x1e09f44*/ ArgumentCache();
            /*0x1e09ebc*/ UnityEngine.Object get_unityObjectArgument();
            /*0x1e09ec4*/ string get_unityObjectArgumentAssemblyTypeName();
            /*0x1e09ecc*/ int get_intArgument();
            /*0x1e09ed4*/ float get_floatArgument();
            /*0x1e09edc*/ string get_stringArgument();
            /*0x1e09ee4*/ bool get_boolArgument();
            /*0x1e09eec*/ void OnBeforeSerialize();
            /*0x1e09f18*/ void OnAfterDeserialize();
        }

        class BaseInvokableCall
        {
            static void ThrowOnInvalidArg<T>(object arg);
            static /*0x1e0ab74*/ bool AllowInvoke(System.Delegate delegate);
            /*0x1e0aaa8*/ BaseInvokableCall();
            /*0x1e0aab0*/ BaseInvokableCall(object target, System.Reflection.MethodInfo function);
            void Invoke(object[] args);
            bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall : UnityEngine.Events.BaseInvokableCall
        {
            /*0x10*/ UnityEngine.Events.UnityAction Delegate;

            /*0x1e14774*/ InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            /*0x1e14860*/ InvokableCall(UnityEngine.Events.UnityAction action);
            /*0x1e14634*/ void add_Delegate(UnityEngine.Events.UnityAction value);
            /*0x1e146d4*/ void remove_Delegate(UnityEngine.Events.UnityAction value);
            /*0x1e14890*/ void Invoke(object[] args);
            /*0x1e148d4*/ void Invoke();
            /*0x1e14918*/ bool Find(object targetObj, System.Reflection.MethodInfo method);
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
            InvokableCall(UnityEngine.Events.UnityAction<T1, T2> action);
            void add_Delegate(UnityEngine.Events.UnityAction<T1, T2> value);
            void remove_Delegate(UnityEngine.Events.UnityAction<T1, T2> value);
            void Invoke(object[] args);
            void Invoke(T1 args0, T2 args1);
            bool Find(object targetObj, System.Reflection.MethodInfo method);
        }

        class InvokableCall<T1, T2, T3> : UnityEngine.Events.BaseInvokableCall
        {
            /*0x0*/ UnityEngine.Events.UnityAction<T1, T2, T3> Delegate;

            InvokableCall(object target, System.Reflection.MethodInfo theFunction);
            InvokableCall(UnityEngine.Events.UnityAction<T1, T2, T3> action);
            void add_Delegate(UnityEngine.Events.UnityAction<T1, T2, T3> value);
            void remove_Delegate(UnityEngine.Events.UnityAction<T1, T2, T3> value);
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

            static /*0x187a378*/ UnityEngine.Events.BaseInvokableCall GetObjectCall(UnityEngine.Object target, System.Reflection.MethodInfo method, UnityEngine.Events.ArgumentCache arguments);
            /*0x187a84c*/ PersistentCall();
            /*0x1879ae4*/ UnityEngine.Object get_target();
            /*0x1879aec*/ string get_targetAssemblyTypeName();
            /*0x1879df4*/ string get_methodName();
            /*0x1879dfc*/ UnityEngine.Events.PersistentListenerMode get_mode();
            /*0x1879e04*/ UnityEngine.Events.ArgumentCache get_arguments();
            /*0x1879e0c*/ bool IsValid();
            /*0x1879e54*/ UnityEngine.Events.BaseInvokableCall GetRuntimeCall(UnityEngine.Events.UnityEventBase theEvent);
            /*0x187a7fc*/ void OnBeforeSerialize();
            /*0x187a824*/ void OnAfterDeserialize();
        }

        class PersistentCallGroup
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Events.PersistentCall> m_Calls;

            /*0x187a8bc*/ PersistentCallGroup();
            /*0x187a938*/ int get_Count();
            /*0x187a984*/ void Initialize(UnityEngine.Events.InvokableCallList invokableList, UnityEngine.Events.UnityEventBase unityEventBase);
        }

        class InvokableCallList
        {
            /*0x10*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_PersistentCalls;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_RuntimeCalls;
            /*0x20*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> m_ExecutingCalls;
            /*0x28*/ bool m_NeedsUpdate;

            /*0x1e14d80*/ InvokableCallList();
            /*0x1e14974*/ void AddPersistentInvokableCall(UnityEngine.Events.BaseInvokableCall call);
            /*0x1e149e4*/ void AddListener(UnityEngine.Events.BaseInvokableCall call);
            /*0x1e14a54*/ void RemoveListener(object targetObj, System.Reflection.MethodInfo method);
            /*0x1e14c1c*/ void Clear();
            /*0x1e14c7c*/ void ClearPersistent();
            /*0x1e14cdc*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke();
        }

        class UnityEventBase : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ UnityEngine.Events.InvokableCallList m_Calls;
            /*0x18*/ UnityEngine.Events.PersistentCallGroup m_PersistentCalls;
            /*0x20*/ bool m_CallsDirty;

            static /*0x1892d2c*/ System.Reflection.MethodInfo GetValidMethodInfo(System.Type objectType, string functionName, System.Type[] argumentTypes);
            /*0x1892b0c*/ UnityEventBase();
            /*0x189312c*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x1893168*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x187a168*/ System.Reflection.MethodInfo FindMethod(UnityEngine.Events.PersistentCall call);
            /*0x189316c*/ System.Reflection.MethodInfo FindMethod(string name, System.Type listenerType, UnityEngine.Events.PersistentListenerMode mode, System.Type argumentType);
            /*0x1893450*/ int GetPersistentEventCount();
            /*0x1893130*/ void DirtyPersistentCalls();
            /*0x1893468*/ void RebuildPersistentCallsIfNeeded();
            /*0x1892c40*/ void AddCall(UnityEngine.Events.BaseInvokableCall call);
            /*0x1892ca8*/ void RemoveListener(object targetObj, System.Reflection.MethodInfo method);
            /*0x18934a8*/ void RemoveAllListeners();
            /*0x18930fc*/ System.Collections.Generic.List<UnityEngine.Events.BaseInvokableCall> PrepareInvoke();
            /*0x18934c4*/ string ToString();
        }

        class UnityAction : System.MulticastDelegate
        {
            /*0x1892860*/ UnityAction(object object, nint method);
            /*0x18928c0*/ void Invoke();
            /*0x1892acc*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x1892af8*/ void EndInvoke(System.IAsyncResult result);
        }

        class UnityEvent : UnityEngine.Events.UnityEventBase
        {
            /*0x28*/ object[] m_InvokeArray;

            static /*0x1892be0*/ UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction action);
            /*0x1892b04*/ UnityEvent();
            /*0x1892ba4*/ void AddListener(UnityEngine.Events.UnityAction call);
            /*0x1892c5c*/ void RemoveListener(UnityEngine.Events.UnityAction call);
            /*0x1892cc4*/ System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            /*0x1892edc*/ UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            /*0x1892f4c*/ void Invoke();
        }

        class UnityAction<T0> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            void Invoke(T0 arg0);
            System.IAsyncResult BeginInvoke(T0 arg0, System.AsyncCallback callback, object object);
            void EndInvoke(System.IAsyncResult result);
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

        class UnityAction<T0, T1> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            void Invoke(T0 arg0, T1 arg1);
            System.IAsyncResult BeginInvoke(T0 arg0, T1 arg1, System.AsyncCallback callback, object object);
            void EndInvoke(System.IAsyncResult result);
        }

        class UnityEvent<T0, T1> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            static UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0, T1> action);
            UnityEvent();
            void AddListener(UnityEngine.Events.UnityAction<T0, T1> call);
            void RemoveListener(UnityEngine.Events.UnityAction<T0, T1> call);
            System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            void Invoke(T0 arg0, T1 arg1);
        }

        class UnityAction<T0, T1, T2> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            void Invoke(T0 arg0, T1 arg1, T2 arg2);
            System.IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, System.AsyncCallback callback, object object);
            void EndInvoke(System.IAsyncResult result);
        }

        class UnityEvent<T0, T1, T2> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            static UnityEngine.Events.BaseInvokableCall GetDelegate(UnityEngine.Events.UnityAction<T0, T1, T2> action);
            UnityEvent();
            void AddListener(UnityEngine.Events.UnityAction<T0, T1, T2> call);
            void RemoveListener(UnityEngine.Events.UnityAction<T0, T1, T2> call);
            System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
            void Invoke(T0 arg0, T1 arg1, T2 arg2);
        }

        class UnityAction<T0, T1, T2, T3> : System.MulticastDelegate
        {
            UnityAction(object object, nint method);
            void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3);
            System.IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, System.AsyncCallback callback, object object);
            void EndInvoke(System.IAsyncResult result);
        }

        class UnityEvent<T0, T1, T2, T3> : UnityEngine.Events.UnityEventBase
        {
            /*0x0*/ object[] m_InvokeArray;

            UnityEvent();
            System.Reflection.MethodInfo FindMethod_Impl(string name, System.Type targetObjType);
            UnityEngine.Events.BaseInvokableCall GetDelegate(object target, System.Reflection.MethodInfo theFunction);
        }
    }

    namespace Serialization
    {
        class FormerlySerializedAsAttribute : System.Attribute
        {
            /*0x10*/ string m_oldName;

            /*0x1e1231c*/ FormerlySerializedAsAttribute(string oldName);
        }
    }

    namespace Scripting
    {
        class AlwaysLinkAssemblyAttribute : System.Attribute
        {
            /*0x1e08350*/ AlwaysLinkAssemblyAttribute();
        }

        class PreserveAttribute : System.Attribute
        {
            /*0x187e7b8*/ PreserveAttribute();
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

                /*0xaddc94*/ void Set(bool autoUpdateAPI, string sourceNamespace, string sourceAssembly, string sourceClassName);
            }

            class MovedFromAttribute : System.Attribute
            {
                /*0x10*/ UnityEngine.Scripting.APIUpdating.MovedFromAttributeData data;

                /*0x1e1f6a0*/ MovedFromAttribute(string sourceNamespace);
            }
        }
    }

    namespace SceneManagement
    {
        struct Scene
        {
            /*0x10*/ int m_Handle;

            static /*0x1886f50*/ bool IsValidInternal(int sceneHandle);
            static /*0x1886f90*/ string GetNameInternal(int sceneHandle);
            static /*0x1886fd0*/ bool GetIsLoadedInternal(int sceneHandle);
            static /*0x1887010*/ int GetRootCountInternal(int sceneHandle);
            static /*0x1887050*/ void GetRootGameObjectsInternal(int sceneHandle, object resultRootList);
            /*0xacc748*/ int get_handle();
            /*0xacc750*/ bool IsValid();
            /*0xacc790*/ string get_name();
            /*0xacc7d0*/ bool get_isLoaded();
            /*0xacc810*/ int get_rootCount();
            /*0xacc850*/ UnityEngine.GameObject[] GetRootGameObjects();
            /*0xacc858*/ void GetRootGameObjects(System.Collections.Generic.List<UnityEngine.GameObject> rootGameObjects);
            /*0xacc860*/ int GetHashCode();
            /*0xacc868*/ bool Equals(object other);
        }

        class SceneManagerAPIInternal
        {
            static /*0x1888864*/ UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            static /*0x1888940*/ UnityEngine.AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnityEngine.SceneManagement.UnloadSceneOptions options, ref bool outSuccess);
            static /*0x1888a18*/ UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
        }

        class SceneManagerAPI
        {
            static /*0x0*/ UnityEngine.SceneManagement.SceneManagerAPI s_DefaultAPI;
            static /*0x8*/ UnityEngine.SceneManagement.SceneManagerAPI <overrideAPI>k__BackingField;

            static /*0x18889b8*/ SceneManagerAPI();
            static /*0x1887834*/ UnityEngine.SceneManagement.SceneManagerAPI get_ActiveAPI();
            static /*0x188878c*/ UnityEngine.SceneManagement.SceneManagerAPI get_overrideAPI();
            /*0x18887f0*/ SceneManagerAPI();
            /*0x18887f8*/ UnityEngine.AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            /*0x18888d0*/ UnityEngine.AsyncOperation UnloadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, bool immediately, UnityEngine.SceneManagement.UnloadSceneOptions options, ref bool outSuccess);
            /*0x18889b0*/ UnityEngine.AsyncOperation LoadFirstScene(bool mustLoadAsync);
        }

        class SceneManager
        {
            static /*0x0*/ bool s_AllowLoadScene;
            static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> sceneLoaded;
            static /*0x10*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> sceneUnloaded;
            static /*0x18*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> activeSceneChanged;

            static /*0x188873c*/ SceneManager();
            static /*0x1887560*/ int get_sceneCount();
            static /*0x1887594*/ UnityEngine.SceneManagement.Scene GetActiveScene();
            static /*0x188765c*/ UnityEngine.SceneManagement.Scene GetSceneAt(int index);
            static /*0x1887744*/ UnityEngine.AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters, bool mustCompleteNextFrame);
            static /*0x18878f8*/ UnityEngine.AsyncOperation UnloadSceneNameIndexInternal(string sceneName, int sceneBuildIndex, bool immediately, UnityEngine.SceneManagement.UnloadSceneOptions options, ref bool outSuccess);
            static /*0x18879f4*/ UnityEngine.AsyncOperation LoadFirstScene_Internal(bool async);
            static /*0x1887a68*/ void add_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> value);
            static /*0x1887b60*/ void remove_sceneLoaded(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> value);
            static /*0x1887c58*/ void add_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> value);
            static /*0x1887d50*/ void remove_activeSceneChanged(UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene> value);
            static /*0x1887e48*/ void LoadScene(string sceneName, UnityEngine.SceneManagement.LoadSceneMode mode);
            static /*0x1887f80*/ void LoadScene(string sceneName);
            static /*0x1887ed4*/ UnityEngine.SceneManagement.Scene LoadScene(string sceneName, UnityEngine.SceneManagement.LoadSceneParameters parameters);
            static /*0x1888008*/ void LoadScene(int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneMode mode);
            static /*0x1888140*/ void LoadScene(int sceneBuildIndex);
            static /*0x1888094*/ UnityEngine.SceneManagement.Scene LoadScene(int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters);
            static /*0x18881c8*/ UnityEngine.AsyncOperation LoadSceneAsync(int sceneBuildIndex);
            static /*0x1888250*/ UnityEngine.AsyncOperation LoadSceneAsync(int sceneBuildIndex, UnityEngine.SceneManagement.LoadSceneParameters parameters);
            static /*0x18882c8*/ UnityEngine.AsyncOperation LoadSceneAsync(string sceneName, UnityEngine.SceneManagement.LoadSceneMode mode);
            static /*0x18883cc*/ UnityEngine.AsyncOperation LoadSceneAsync(string sceneName);
            static /*0x1888354*/ UnityEngine.AsyncOperation LoadSceneAsync(string sceneName, UnityEngine.SceneManagement.LoadSceneParameters parameters);
            static /*0x1888454*/ UnityEngine.AsyncOperation UnloadSceneAsync(string sceneName);
            static /*0x18884d4*/ void Internal_SceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            static /*0x18885a8*/ void Internal_SceneUnloaded(UnityEngine.SceneManagement.Scene scene);
            static /*0x1888668*/ void Internal_ActiveSceneChanged(UnityEngine.SceneManagement.Scene previousActiveScene, UnityEngine.SceneManagement.Scene newActiveScene);
            static /*0x188761c*/ void GetActiveScene_Injected(ref UnityEngine.SceneManagement.Scene ret);
            static /*0x18876f4*/ void GetSceneAt_Injected(int index, ref UnityEngine.SceneManagement.Scene ret);
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

            /*0xadda90*/ LoadSceneParameters(UnityEngine.SceneManagement.LoadSceneMode mode);
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

            /*0xacbe2c*/ string ToString();

            class UpdateFunction : System.MulticastDelegate
            {
                /*0x2a96ab4*/ UpdateFunction(object object, nint method);
                /*0x2a96b14*/ void Invoke();
                /*0x2a96d20*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x2a96d4c*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class PlayerLoop
        {
            static /*0x187dca0*/ UnityEngine.LowLevel.PlayerLoopSystem GetCurrentPlayerLoop();
            static /*0x187df00*/ void SetPlayerLoop(UnityEngine.LowLevel.PlayerLoopSystem loop);
            static /*0x187dfe8*/ int PlayerLoopSystemToInternal(UnityEngine.LowLevel.PlayerLoopSystem sys, ref System.Collections.Generic.List<UnityEngine.LowLevel.PlayerLoopSystemInternal> internalSys);
            static /*0x187dd4c*/ UnityEngine.LowLevel.PlayerLoopSystem InternalToPlayerLoopSystem(UnityEngine.LowLevel.PlayerLoopSystemInternal[] internalSys, ref int offset);
            static /*0x187dd18*/ UnityEngine.LowLevel.PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal();
            static /*0x187e144*/ void SetPlayerLoopInternal(UnityEngine.LowLevel.PlayerLoopSystemInternal[] loop);
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

            struct ProfilerStartFrame
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

    namespace Networking
    {
        namespace PlayerConnection
        {
            class MessageEventArgs
            {
                /*0x10*/ int playerId;
                /*0x18*/ byte[] data;

                /*0x1e1e9c4*/ MessageEventArgs();
            }

            class PlayerConnection : UnityEngine.ScriptableObject
            {
                static /*0x0*/ UnityEngine.IPlayerEditorConnectionNative connectionNative;
                static /*0x8*/ UnityEngine.Networking.PlayerConnection.PlayerConnection s_Instance;
                /*0x18*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents;
                /*0x20*/ System.Collections.Generic.List<int> m_connectedPlayers;
                /*0x28*/ bool m_IsInitilized;

                static /*0x187baa0*/ UnityEngine.Networking.PlayerConnection.PlayerConnection get_instance();
                static /*0x187bb40*/ UnityEngine.Networking.PlayerConnection.PlayerConnection CreateInstance();
                static /*0x187cdf4*/ void MessageCallbackInternal(nint data, ulong size, ulong guid, string messageId);
                static /*0x187d3a4*/ void ConnectedCallbackInternal(int playerId);
                static /*0x187d43c*/ void DisconnectedCallback(int playerId);
                /*0x187d4d4*/ PlayerConnection();
                /*0x187bbf8*/ bool get_isConnected();
                /*0x187bd24*/ void OnEnable();
                /*0x187bca8*/ UnityEngine.IPlayerEditorConnectionNative GetConnectionNativeApi();
                /*0x187bdf8*/ void Register(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);
                /*0x187c20c*/ void Unregister(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);
                /*0x187c550*/ void RegisterConnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x187c6cc*/ void RegisterDisconnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x187c738*/ void UnregisterConnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x187c7a4*/ void UnregisterDisconnection(UnityEngine.Events.UnityAction<int> callback);
                /*0x187c810*/ void Send(System.Guid messageId, byte[] data);
                /*0x187c98c*/ bool TrySend(System.Guid messageId, byte[] data);
                /*0x187cb08*/ bool BlockUntilRecvMsg(System.Guid messageId, int timeout);
                /*0x187cd44*/ void DisconnectAll();

                class <>c__DisplayClass12_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x2a965a4*/ <>c__DisplayClass12_0();
                    /*0x2a965ac*/ bool <Register>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x2a9668c*/ <>c__DisplayClass13_0();
                    /*0x2a96694*/ bool <Unregister>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass20_0
                {
                    /*0x10*/ bool msgReceived;

                    /*0x2a96744*/ <>c__DisplayClass20_0();
                    /*0x2a9674c*/ void <BlockUntilRecvMsg>b__0(UnityEngine.Networking.PlayerConnection.MessageEventArgs args);
                }
            }

            class PlayerEditorConnectionEvents
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers;
                /*0x18*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent;
                /*0x20*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent;

                /*0x187d570*/ PlayerEditorConnectionEvents();
                /*0x187cf20*/ void InvokeMessageIdSubscribers(System.Guid messageId, byte[] data, int playerId);
                /*0x187c06c*/ UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs> AddAndCreate(System.Guid messageId);
                /*0x187c3d0*/ void UnregisterManagedCallback(System.Guid messageId, UnityEngine.Events.UnityAction<UnityEngine.Networking.PlayerConnection.MessageEventArgs> callback);

                class MessageEvent : UnityEngine.Events.UnityEvent<UnityEngine.Networking.PlayerConnection.MessageEventArgs>
                {
                    /*0x2a969cc*/ MessageEvent();
                }

                class ConnectionChangeEvent : UnityEngine.Events.UnityEvent<int>
                {
                    /*0x2a96980*/ ConnectionChangeEvent();
                }

                class MessageTypeSubscribers
                {
                    /*0x10*/ string m_messageTypeId;
                    /*0x18*/ int subscriberCount;
                    /*0x20*/ UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageEvent messageCallback;

                    /*0x2a96a50*/ MessageTypeSubscribers();
                    /*0x2a9665c*/ System.Guid get_MessageTypeId();
                    /*0x2a96a18*/ void set_MessageTypeId(System.Guid value);
                }

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x2a96758*/ <>c__DisplayClass6_0();
                    /*0x2a96760*/ bool <InvokeMessageIdSubscribers>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x2a96810*/ <>c__DisplayClass7_0();
                    /*0x2a96818*/ bool <AddAndCreate>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }

                class <>c__DisplayClass8_0
                {
                    /*0x10*/ System.Guid messageId;

                    /*0x2a968c8*/ <>c__DisplayClass8_0();
                    /*0x2a968d0*/ bool <UnregisterManagedCallback>b__0(UnityEngine.Networking.PlayerConnection.PlayerEditorConnectionEvents.MessageTypeSubscribers x);
                }
            }
        }
    }

    namespace Internal
    {
        class DefaultValueAttribute : System.Attribute
        {
            /*0x10*/ object DefaultValue;

            /*0x1e118e8*/ DefaultValueAttribute(string value);
            /*0x1e11914*/ object get_Value();
            /*0x1e1191c*/ bool Equals(object obj);
            /*0x1e119e4*/ int GetHashCode();
        }

        class ExcludeFromDocsAttribute : System.Attribute
        {
            /*0x1e122ec*/ ExcludeFromDocsAttribute();
        }
    }

    namespace Rendering
    {
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

        struct RenderTargetIdentifier : System.IEquatable<UnityEngine.Rendering.RenderTargetIdentifier>
        {
            /*0x10*/ UnityEngine.Rendering.BuiltinRenderTextureType m_Type;
            /*0x14*/ int m_NameID;
            /*0x18*/ int m_InstanceID;
            /*0x20*/ nint m_BufferPointer;
            /*0x28*/ int m_MipLevel;
            /*0x2c*/ UnityEngine.CubemapFace m_CubeFace;
            /*0x30*/ int m_DepthSlice;

            /*0xacc550*/ string ToString();
            /*0xacc558*/ int GetHashCode();
            /*0xacc560*/ bool Equals(UnityEngine.Rendering.RenderTargetIdentifier rhs);
            /*0xacc598*/ bool Equals(object obj);
        }

        enum ReflectionProbeUsage
        {
            Off = 0,
            BlendProbes = 1,
            BlendProbesAndSkybox = 2,
            Simple = 3,
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

        class GraphicsSettings : UnityEngine.Object
        {
            static /*0x1e14258*/ bool get_lightsUseLinearIntensity();
        }

        class OnDemandRendering
        {
            static /*0x0*/ int m_RenderFrameInterval;

            static /*0x1879a94*/ OnDemandRendering();
            static /*0x1879920*/ int get_renderFrameInterval();
            static /*0x1879984*/ void set_renderFrameInterval(int value);
            static /*0x1879a30*/ void GetRenderFrameInterval(ref int frameInterval);
        }

        struct LODParameters : System.IEquatable<UnityEngine.Rendering.LODParameters>
        {
            /*0x10*/ int m_IsOrthographic;
            /*0x14*/ UnityEngine.Vector3 m_CameraPosition;
            /*0x20*/ float m_FieldOfView;
            /*0x24*/ float m_OrthoSize;
            /*0x28*/ int m_CameraPixelHeight;

            /*0xadd950*/ bool Equals(UnityEngine.Rendering.LODParameters other);
            /*0xadd988*/ bool Equals(object obj);
            /*0xadd990*/ int GetHashCode();
        }

        class RenderPipeline
        {
            /*0x10*/ bool <disposed>k__BackingField;

            void Render(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera[] cameras);
            /*0x1882514*/ void ProcessRenderRequests(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests);
            /*0x1882518*/ void InternalRender(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera[] cameras);
            /*0x1882594*/ void InternalRenderWithRequests(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera[] cameras, System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests);
            /*0x1882640*/ bool get_disposed();
            /*0x1882648*/ void set_disposed(bool value);
            /*0x1882654*/ void Dispose();
            /*0x18826d8*/ void Dispose(bool disposing);
        }

        class RenderPipelineAsset : UnityEngine.ScriptableObject
        {
            /*0x1883008*/ RenderPipelineAsset();
            /*0x18826dc*/ UnityEngine.Rendering.RenderPipeline InternalCreatePipeline();
            /*0x1882a10*/ string[] get_renderingLayerMaskNames();
            /*0x1882a18*/ UnityEngine.Material get_defaultMaterial();
            /*0x1882a20*/ UnityEngine.Shader get_autodeskInteractiveShader();
            /*0x1882a28*/ UnityEngine.Shader get_autodeskInteractiveTransparentShader();
            /*0x1882a30*/ UnityEngine.Shader get_autodeskInteractiveMaskedShader();
            /*0x1882a38*/ UnityEngine.Shader get_terrainDetailLitShader();
            /*0x1882a40*/ UnityEngine.Shader get_terrainDetailGrassShader();
            /*0x1882a48*/ UnityEngine.Shader get_terrainDetailGrassBillboardShader();
            /*0x1882a50*/ UnityEngine.Material get_defaultParticleMaterial();
            /*0x1882a58*/ UnityEngine.Material get_defaultLineMaterial();
            /*0x1882a60*/ UnityEngine.Material get_defaultTerrainMaterial();
            /*0x1882a68*/ UnityEngine.Material get_defaultUIMaterial();
            /*0x1882a70*/ UnityEngine.Material get_defaultUIOverdrawMaterial();
            /*0x1882a78*/ UnityEngine.Material get_defaultUIETC1SupportedMaterial();
            /*0x1882a80*/ UnityEngine.Material get_default2DMaterial();
            /*0x1882a88*/ UnityEngine.Shader get_defaultShader();
            /*0x1882a90*/ UnityEngine.Shader get_defaultSpeedTree7Shader();
            /*0x1882a98*/ UnityEngine.Shader get_defaultSpeedTree8Shader();
            UnityEngine.Rendering.RenderPipeline CreatePipeline();
            /*0x1882aa0*/ void OnValidate();
            /*0x1882fb0*/ void OnDisable();
        }

        class RenderPipelineManager
        {
            static /*0x0*/ UnityEngine.Rendering.RenderPipelineAsset s_CurrentPipelineAsset;
            static /*0x8*/ UnityEngine.Camera[] s_Cameras;
            static /*0x10*/ int s_CameraCapacity;
            static /*0x18*/ UnityEngine.Rendering.RenderPipeline <currentPipeline>k__BackingField;

            static /*0x188357c*/ RenderPipelineManager();
            static /*0x188300c*/ UnityEngine.Rendering.RenderPipeline get_currentPipeline();
            static /*0x1883070*/ void set_currentPipeline(UnityEngine.Rendering.RenderPipeline value);
            static /*0x1882b80*/ void CleanupRenderPipeline();
            static /*0x18831d4*/ void GetCameras(UnityEngine.Rendering.ScriptableRenderContext context);
            static /*0x1883360*/ void DoRenderLoop_Internal(UnityEngine.Rendering.RenderPipelineAsset pipe, nint loopPtr, System.Collections.Generic.List<UnityEngine.Camera.RenderRequest> renderRequests);
            static /*0x1882d7c*/ void PrepareRenderPipeline(UnityEngine.Rendering.RenderPipelineAsset pipelineAsset);
        }

        struct ScriptableRenderContext : System.IEquatable<UnityEngine.Rendering.ScriptableRenderContext>
        {
            static /*0x0*/ UnityEngine.Rendering.ShaderTagId kRenderTypeTag;
            /*0x10*/ nint m_Ptr;

            static /*0x188909c*/ ScriptableRenderContext();
            static /*0x1888e78*/ int GetNumberOfCameras_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self);
            static /*0x1888f48*/ UnityEngine.Camera GetCamera_Internal_Injected(ref UnityEngine.Rendering.ScriptableRenderContext _unity_self, int index);
            /*0xacc89c*/ ScriptableRenderContext(nint ptr);
            /*0xacc88c*/ int GetNumberOfCameras_Internal();
            /*0xacc894*/ UnityEngine.Camera GetCamera_Internal(int index);
            /*0xacc8a4*/ int GetNumberOfCameras();
            /*0xacc8ac*/ UnityEngine.Camera GetCamera(int index);
            /*0xacc8b4*/ bool Equals(UnityEngine.Rendering.ScriptableRenderContext other);
            /*0xacc8bc*/ bool Equals(object obj);
            /*0xacc8c4*/ int GetHashCode();
        }

        struct ShaderTagId : System.IEquatable<UnityEngine.Rendering.ShaderTagId>
        {
            static /*0x0*/ UnityEngine.Rendering.ShaderTagId none;
            /*0x10*/ int m_Id;

            static /*0x1889998*/ ShaderTagId();
            /*0xacc8d0*/ ShaderTagId(string name);
            /*0xacc924*/ bool Equals(object obj);
            /*0xacc92c*/ bool Equals(UnityEngine.Rendering.ShaderTagId other);
            /*0xacc93c*/ int GetHashCode();
        }

        class SupportedRenderingFeatures
        {
            static /*0x0*/ UnityEngine.Rendering.SupportedRenderingFeatures s_Active;
            /*0x10*/ UnityEngine.Rendering.SupportedRenderingFeatures.ReflectionProbeModes <reflectionProbeModes>k__BackingField;
            /*0x14*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField;
            /*0x18*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes <mixedLightingModes>k__BackingField;
            /*0x1c*/ UnityEngine.LightmapBakeType <lightmapBakeTypes>k__BackingField;
            /*0x20*/ UnityEngine.LightmapsMode <lightmapsModes>k__BackingField;
            /*0x24*/ bool <enlighten>k__BackingField;
            /*0x25*/ bool <lightProbeProxyVolumes>k__BackingField;
            /*0x26*/ bool <motionVectors>k__BackingField;
            /*0x27*/ bool <receiveShadows>k__BackingField;
            /*0x28*/ bool <reflectionProbes>k__BackingField;
            /*0x29*/ bool <rendererPriority>k__BackingField;
            /*0x2a*/ bool <terrainDetailUnsupported>k__BackingField;
            /*0x2b*/ bool <rendersUIOverlay>k__BackingField;
            /*0x2c*/ bool <overridesEnvironmentLighting>k__BackingField;
            /*0x2d*/ bool <overridesFog>k__BackingField;
            /*0x2e*/ bool <overridesRealtimeReflectionProbes>k__BackingField;
            /*0x2f*/ bool <overridesOtherLightingSettings>k__BackingField;
            /*0x30*/ bool <editableMaterialRenderQueue>k__BackingField;
            /*0x31*/ bool <overridesLODBias>k__BackingField;
            /*0x32*/ bool <overridesMaximumLODLevel>k__BackingField;
            /*0x33*/ bool <rendererProbes>k__BackingField;
            /*0x34*/ bool <particleSystemInstancing>k__BackingField;
            /*0x35*/ bool <autoAmbientProbeBaking>k__BackingField;
            /*0x36*/ bool <autoDefaultReflectionProbeBaking>k__BackingField;
            /*0x37*/ bool <overridesShadowmask>k__BackingField;
            /*0x38*/ string <overrideShadowmaskMessage>k__BackingField;

            static /*0x188c6e4*/ SupportedRenderingFeatures();
            static /*0x188be6c*/ UnityEngine.Rendering.SupportedRenderingFeatures get_active();
            static /*0x188316c*/ void set_active(UnityEngine.Rendering.SupportedRenderingFeatures value);
            static /*0x188bf68*/ void FallbackMixedLightingModeByRef(nint fallbackModePtr);
            static /*0x188c0c8*/ bool IsMixedLightingModeSupported(UnityEngine.MixedLightingMode mixedMode);
            static /*0x188c140*/ void IsMixedLightingModeSupportedByRef(UnityEngine.MixedLightingMode mixedMode, nint isSupportedPtr);
            static /*0x188c26c*/ bool IsLightmapBakeTypeSupported(UnityEngine.LightmapBakeType bakeType);
            static /*0x188c2e4*/ void IsLightmapBakeTypeSupportedByRef(UnityEngine.LightmapBakeType bakeType, nint isSupportedPtr);
            static /*0x188c408*/ void IsLightmapsModeSupportedByRef(UnityEngine.LightmapsMode mode, nint isSupportedPtr);
            static /*0x188c4a0*/ void IsLightmapperSupportedByRef(int lightmapper, nint isSupportedPtr);
            static /*0x188c538*/ void IsUIOverlayRenderedBySRP(nint isSupportedPtr);
            static /*0x188c5bc*/ void IsAutoAmbientProbeBakingSupported(nint isSupportedPtr);
            static /*0x188c640*/ void IsAutoDefaultReflectionProbeBakingSupported(nint isSupportedPtr);
            static /*0x188c6c4*/ void FallbackLightmapperByRef(nint lightmapperPtr);
            /*0x18830d8*/ SupportedRenderingFeatures();
            /*0x188bf28*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_defaultMixedLightingModes();
            /*0x188bf30*/ UnityEngine.Rendering.SupportedRenderingFeatures.LightmapMixedBakeModes get_mixedLightingModes();
            /*0x188bf38*/ UnityEngine.LightmapBakeType get_lightmapBakeTypes();
            /*0x188bf40*/ UnityEngine.LightmapsMode get_lightmapsModes();
            /*0x188bf48*/ bool get_enlighten();
            /*0x188bf50*/ bool get_rendersUIOverlay();
            /*0x188bf58*/ bool get_autoAmbientProbeBaking();
            /*0x188bf60*/ bool get_autoDefaultReflectionProbeBaking();

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

            /*0xadd098*/ BatchCullingContext(Unity.Collections.NativeArray<UnityEngine.Plane> inCullingPlanes, Unity.Collections.NativeArray<UnityEngine.Rendering.BatchVisibility> inOutBatchVisibility, Unity.Collections.NativeArray<int> outVisibleIndices, Unity.Collections.NativeArray<int> outVisibleIndicesY, UnityEngine.Rendering.LODParameters inLodParameters, UnityEngine.Matrix4x4 inCullingMatrix, float inNearPlane);
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

            static /*0x1e0ac7c*/ void InvokeOnPerformCulling(UnityEngine.Rendering.BatchRendererGroup group, ref UnityEngine.Rendering.BatchRendererCullingOutput context, ref UnityEngine.Rendering.LODParameters lodParameters);

            class OnPerformCulling : System.MulticastDelegate
            {
                /*0x2a9479c*/ OnPerformCulling(object object, nint method);
                /*0x2a947fc*/ Unity.Jobs.JobHandle Invoke(UnityEngine.Rendering.BatchRendererGroup rendererGroup, UnityEngine.Rendering.BatchCullingContext cullingContext);
                /*0x2a94d10*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.BatchRendererGroup rendererGroup, UnityEngine.Rendering.BatchCullingContext cullingContext, System.AsyncCallback callback, object object);
                /*0x2a94da8*/ Unity.Jobs.JobHandle EndInvoke(System.IAsyncResult result);
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
            void OnNotify(UnityEngine.Playables.Playable origin, UnityEngine.Playables.INotification notification, object context);
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

        struct Playable : System.IEquatable<UnityEngine.Playables.Playable>
        {
            static /*0x0*/ UnityEngine.Playables.Playable m_NullPlayable;
            /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

            static /*0x187af78*/ Playable();
            static /*0x187adec*/ UnityEngine.Playables.Playable get_Null();
            /*0xacbcd4*/ Playable(UnityEngine.Playables.PlayableHandle handle);
            /*0xacbcdc*/ UnityEngine.Playables.PlayableHandle GetHandle();
            /*0xacbce8*/ bool Equals(UnityEngine.Playables.Playable other);
        }

        class PlayableAsset : UnityEngine.ScriptableObject
        {
            static /*0x187b120*/ void Internal_CreatePlayable(UnityEngine.Playables.PlayableAsset asset, UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject go, nint ptr);
            static /*0x187b208*/ void Internal_GetPlayableAssetDuration(UnityEngine.Playables.PlayableAsset asset, nint ptrToDouble);
            /*0x187b23c*/ PlayableAsset();
            UnityEngine.Playables.Playable CreatePlayable(UnityEngine.Playables.PlayableGraph graph, UnityEngine.GameObject owner);
            /*0x187b058*/ double get_duration();
            /*0x187b0bc*/ System.Collections.Generic.IEnumerable<UnityEngine.Playables.PlayableBinding> get_outputs();
        }

        class PlayableBehaviour : UnityEngine.Playables.IPlayableBehaviour, System.ICloneable
        {
            /*0x187b2cc*/ PlayableBehaviour();
            /*0x187b2d4*/ void OnGraphStart(UnityEngine.Playables.Playable playable);
            /*0x187b2d8*/ void OnGraphStop(UnityEngine.Playables.Playable playable);
            /*0x187b2dc*/ void OnPlayableCreate(UnityEngine.Playables.Playable playable);
            /*0x187b2e0*/ void OnPlayableDestroy(UnityEngine.Playables.Playable playable);
            /*0x187b2e4*/ void OnBehaviourPlay(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x187b2e8*/ void OnBehaviourPause(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x187b2ec*/ void PrepareFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info);
            /*0x187b2f0*/ void ProcessFrame(UnityEngine.Playables.Playable playable, UnityEngine.Playables.FrameData info, object playerData);
            /*0x187b2f4*/ object Clone();
        }

        struct PlayableBinding
        {
            static /*0x0*/ UnityEngine.Playables.PlayableBinding[] None;
            static /*0x8*/ double DefaultDuration;
            /*0x10*/ string m_StreamName;
            /*0x18*/ UnityEngine.Object m_SourceObject;
            /*0x20*/ System.Type m_SourceBindingType;
            /*0x28*/ UnityEngine.Playables.PlayableBinding.CreateOutputMethod m_CreateOutputMethod;

            static /*0x187b2fc*/ PlayableBinding();

            class CreateOutputMethod : System.MulticastDelegate
            {
                /*0x2a961f0*/ CreateOutputMethod(object object, nint method);
                /*0x2a96250*/ UnityEngine.Playables.PlayableOutput Invoke(UnityEngine.Playables.PlayableGraph graph, string name);
                /*0x2a964e0*/ System.IAsyncResult BeginInvoke(UnityEngine.Playables.PlayableGraph graph, string name, System.AsyncCallback callback, object object);
                /*0x2a96574*/ UnityEngine.Playables.PlayableOutput EndInvoke(System.IAsyncResult result);
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

            static /*0x187b67c*/ PlayableHandle();
            static /*0x187aff4*/ UnityEngine.Playables.PlayableHandle get_Null();
            static /*0x187aee4*/ bool op_Equality(UnityEngine.Playables.PlayableHandle x, UnityEngine.Playables.PlayableHandle y);
            static /*0x187b378*/ bool CompareVersion(UnityEngine.Playables.PlayableHandle lhs, UnityEngine.Playables.PlayableHandle rhs);
            static /*0x187b57c*/ bool IsValid_Injected(ref UnityEngine.Playables.PlayableHandle _unity_self);
            static /*0x187b63c*/ System.Type GetPlayableType_Injected(ref UnityEngine.Playables.PlayableHandle _unity_self);
            bool IsPlayableOfType<T>();
            /*0xacbd2c*/ bool Equals(object p);
            /*0xacbd34*/ bool Equals(UnityEngine.Playables.PlayableHandle other);
            /*0xacbd3c*/ int GetHashCode();
            /*0xacbd78*/ bool IsValid();
            /*0xacbd80*/ System.Type GetPlayableType();
        }

        struct PlayableOutput : System.IEquatable<UnityEngine.Playables.PlayableOutput>
        {
            static /*0x0*/ UnityEngine.Playables.PlayableOutput m_NullPlayableOutput;
            /*0x10*/ UnityEngine.Playables.PlayableOutputHandle m_Handle;

            static /*0x187b7f0*/ PlayableOutput();
            /*0xacbd88*/ PlayableOutput(UnityEngine.Playables.PlayableOutputHandle handle);
            /*0xacbd90*/ UnityEngine.Playables.PlayableOutputHandle GetHandle();
            /*0xacbd9c*/ bool Equals(UnityEngine.Playables.PlayableOutput other);
        }

        struct PlayableOutputHandle : System.IEquatable<UnityEngine.Playables.PlayableOutputHandle>
        {
            static /*0x0*/ UnityEngine.Playables.PlayableOutputHandle m_Null;
            /*0x10*/ nint m_Handle;
            /*0x18*/ uint m_Version;

            static /*0x187ba54*/ PlayableOutputHandle();
            static /*0x187b86c*/ UnityEngine.Playables.PlayableOutputHandle get_Null();
            static /*0x187b75c*/ bool op_Equality(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs);
            static /*0x187b908*/ bool CompareVersion(UnityEngine.Playables.PlayableOutputHandle lhs, UnityEngine.Playables.PlayableOutputHandle rhs);
            /*0xacbda4*/ int GetHashCode();
            /*0xacbde0*/ bool Equals(object p);
            /*0xacbde8*/ bool Equals(UnityEngine.Playables.PlayableOutputHandle other);
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

                static /*0x1e159f0*/ UnityEngine.Experimental.GlobalIllumination.LinearColor Convert(UnityEngine.Color color, float intensity);
                static /*0x1e17220*/ UnityEngine.Experimental.GlobalIllumination.LinearColor Black();
                /*0xadda60*/ float get_red();
                /*0xadda68*/ void set_red(float value);
                /*0xadda70*/ float get_green();
                /*0xadda78*/ void set_green(float value);
                /*0xadda80*/ float get_blue();
                /*0xadda88*/ void set_blue(float value);
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

                /*0xadda0c*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0xadda14*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.PointLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0xadda1c*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.SpotLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0xadda24*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.RectangleLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0xadda2c*/ void Init(ref UnityEngine.Experimental.GlobalIllumination.DiscLight light, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
                /*0xadda34*/ void InitNoBake(int lightInstanceID);
            }

            class LightmapperUtils
            {
                static /*0x1e15918*/ UnityEngine.Experimental.GlobalIllumination.LightMode Extract(UnityEngine.LightmapBakeType baketype);
                static /*0x1e15938*/ UnityEngine.Experimental.GlobalIllumination.LinearColor ExtractIndirect(UnityEngine.Light l);
                static /*0x1e15d20*/ float ExtractInnerCone(UnityEngine.Light l);
                static /*0x1e15da4*/ UnityEngine.Color ExtractColorTemperature(UnityEngine.Light l);
                static /*0x1e15db8*/ void ApplyColorTemperature(UnityEngine.Color cct, ref UnityEngine.Experimental.GlobalIllumination.LinearColor lightColor);
                static /*0x1e1604c*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.DirectionalLight dir);
                static /*0x1e16258*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.PointLight point);
                static /*0x1e16498*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.SpotLight spot);
                static /*0x1e1671c*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.RectangleLight rect);
                static /*0x1e1695c*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.DiscLight disc);
                static /*0x1e16b9c*/ void Extract(UnityEngine.Light l, ref UnityEngine.Experimental.GlobalIllumination.Cookie cookie);
            }

            class Lightmapping
            {
                static /*0x0*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate s_DefaultDelegate;
                static /*0x8*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate s_RequestLightsDelegate;

                static /*0x1e16fa4*/ Lightmapping();
                static /*0x1e16d84*/ void SetDelegate(UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate del);
                static /*0x1e16e10*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate GetDelegate();
                static /*0x1e16e74*/ void ResetDelegate();
                static /*0x1e16edc*/ void RequestLights(UnityEngine.Light[] lights, nint outLightsPtr, int outLightsCount);

                class RequestLightsDelegate : System.MulticastDelegate
                {
                    /*0x2a95d34*/ RequestLightsDelegate(object object, nint method);
                    /*0x2a95d94*/ void Invoke(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                    /*0x2a9614c*/ System.IAsyncResult BeginInvoke(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput, System.AsyncCallback callback, object object);
                    /*0x2a961e4*/ void EndInvoke(System.IAsyncResult result);
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.<> <>9;

                    static /*0x2a95a68*/ <>c();
                    /*0x2a95ac8*/ <>c();
                    /*0x2a95ad0*/ void <.cctor>b__7_0(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }
            }
        }

        namespace Playables
        {
            struct CameraPlayable : System.IEquatable<UnityEngine.Experimental.Playables.CameraPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0xadd3ac*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0xadd3b8*/ bool Equals(UnityEngine.Experimental.Playables.CameraPlayable other);
            }

            struct MaterialEffectPlayable : System.IEquatable<UnityEngine.Experimental.Playables.MaterialEffectPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0xadda98*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0xaddaa4*/ bool Equals(UnityEngine.Experimental.Playables.MaterialEffectPlayable other);
            }

            struct TextureMixerPlayable : System.IEquatable<UnityEngine.Experimental.Playables.TextureMixerPlayable>
            {
                /*0x10*/ UnityEngine.Playables.PlayableHandle m_Handle;

                /*0xaccb44*/ UnityEngine.Playables.PlayableHandle GetHandle();
                /*0xaccb50*/ bool Equals(UnityEngine.Experimental.Playables.TextureMixerPlayable other);
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
                static /*0x1e0bbf4*/ bool BuiltinUpdate();
                static /*0x1e0bc30*/ UnityEngine.Experimental.Rendering.BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New();
                /*0x1e0bc88*/ BuiltinRuntimeReflectionSystem();
                /*0x1e0bbc0*/ bool TickRealtimeProbes();
                /*0x1e0bc28*/ void Dispose();
                /*0x1e0bc2c*/ void Dispose(bool disposing);
            }

            interface IScriptableRuntimeReflectionSystem : System.IDisposable
            {
                bool TickRealtimeProbes();
            }

            class ScriptableRuntimeReflectionSystemSettings
            {
                static /*0x0*/ UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper s_Instance;

                static /*0x1889390*/ ScriptableRuntimeReflectionSystemSettings();
                static /*0x188917c*/ void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value);
                static /*0x18892f8*/ UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance();
                static /*0x188935c*/ void ScriptingDirtyReflectionSystemInstance();
            }

            class ScriptableRuntimeReflectionSystemWrapper
            {
                /*0x10*/ UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem <implementation>k__BackingField;

                /*0x1889404*/ ScriptableRuntimeReflectionSystemWrapper();
                /*0x188940c*/ UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem get_implementation();
                /*0x1889414*/ void set_implementation(UnityEngine.Experimental.Rendering.IScriptableRuntimeReflectionSystem value);
                /*0x188941c*/ void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(ref bool result);
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
                RGBA_ASTC4X4_UFloat = 145,
                RGBA_ASTC5X5_UFloat = 146,
                RGBA_ASTC6X6_UFloat = 147,
                RGBA_ASTC8X8_UFloat = 148,
                RGBA_ASTC10X10_UFloat = 149,
                RGBA_ASTC12X12_UFloat = 150,
            }

            class GraphicsFormatUtility
            {
                static /*0x1e0f570*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.TextureFormat format, bool isSRGB);
                static /*0x1e13fa4*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_TextureFormat(UnityEngine.TextureFormat format, bool isSRGB);
                static /*0x1e13ff4*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, bool isSRGB);
                static /*0x1e14044*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(UnityEngine.RenderTextureFormat format, bool isSRGB);
                static /*0x1e14094*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(UnityEngine.RenderTextureFormat format, UnityEngine.RenderTextureReadWrite readWrite);
                static /*0x1e14104*/ bool IsSRGBFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1e14144*/ UnityEngine.RenderTextureFormat GetRenderTextureFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1e14184*/ bool IsCompressedTextureFormat(UnityEngine.TextureFormat format);
                static /*0x1e141c4*/ bool CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, bool wholeImage);
                static /*0x1e14214*/ bool CanDecompressFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format);
                static /*0x1e0f5c0*/ bool IsCrunchFormat(UnityEngine.TextureFormat format);
            }
        }
    }
}
