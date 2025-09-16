class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x72aa66c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x72aa760*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace NoaDebugger
{
    class ApiLogCollectorModel : NoaDebugger.LogCollectorModel
    {
        /*0x20*/ UnityEngine.Events.UnityAction<NoaDebugger.ApiLog> OnLogReceived;

        /*0x72aa8c8*/ ApiLogCollectorModel();
        /*0x72aa768*/ void add_OnLogReceived(UnityEngine.Events.UnityAction<NoaDebugger.ApiLog> value);
        /*0x72aa818*/ void remove_OnLogReceived(UnityEngine.Events.UnityAction<NoaDebugger.ApiLog> value);
        /*0x72aa9d4*/ void OnCollectEnabled();
        /*0x72aaa54*/ void OnCollectDisabled();
        /*0x72aaad4*/ void _ReceiveLog(NoaDebugger.ApiLog log);
    }

    class ApplicationOperateModel : NoaDebugger.ModelBase
    {
        /*0x10*/ System.Func<bool> <OnTransition>k__BackingField;
        /*0x18*/ UnityEngine.Events.UnityAction <OnFinishTransition>k__BackingField;

        /*0x72aac88*/ ApplicationOperateModel();
        /*0x72aaaf0*/ System.Func<bool> get_OnTransition();
        /*0x72aaaf8*/ void set_OnTransition(System.Func<bool> value);
        /*0x72aab00*/ UnityEngine.Events.UnityAction get_OnFinishTransition();
        /*0x72aab08*/ void set_OnFinishTransition(UnityEngine.Events.UnityAction value);
        /*0x72aab10*/ void TransitionToInitialScene();
        /*0x72aac08*/ System.Collections.IEnumerator _LoadFirstScene();

        class <_LoadFirstScene>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ UnityEngine.AsyncOperation <asyncLoad>5__2;

            /*0x72aac60*/ <_LoadFirstScene>d__9(int <>1__state);
            /*0x72aac98*/ void System.IDisposable.Dispose();
            /*0x72aac9c*/ bool MoveNext();
            /*0x72aad64*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72aad6c*/ void System.Collections.IEnumerator.Reset();
            /*0x72aada4*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class BatteryModel : NoaDebugger.ModelBase
    {
        static /*0x0*/ string BatteryModelOnUpdate;
        static /*0x8*/ float BatteryCheckIntervalSec;
        static /*0xc*/ int BatteryLevelAverageMinutes;
        static /*0x10*/ int BatteryDataLength;
        static /*0x14*/ bool DefaultIsProfiling;
        /*0x10*/ System.Collections.Generic.List<NoaDebugger.BatteryModel.BatteryLevelData> _batteryLevelDataList;
        /*0x18*/ float _timeSinceBatteryCheck;
        /*0x20*/ NoaDebugger.BatteryInfo <BatteryInfo>k__BackingField;
        /*0x28*/ UnityEngine.Events.UnityAction <OnBatteryInfoChanged>k__BackingField;

        static /*0x72ab650*/ BatteryModel();
        static /*0x72ab634*/ bool CanProfiling();
        /*0x72aadcc*/ BatteryModel();
        /*0x72aadac*/ NoaDebugger.BatteryInfo get_BatteryInfo();
        /*0x72aadb4*/ void set_BatteryInfo(NoaDebugger.BatteryInfo value);
        /*0x72aadbc*/ UnityEngine.Events.UnityAction get_OnBatteryInfoChanged();
        /*0x72aadc4*/ void set_OnBatteryInfoChanged(UnityEngine.Events.UnityAction value);
        /*0x72ab0dc*/ void Dispose();
        /*0x72ab138*/ void _OnUpdate();
        /*0x72aae70*/ void _ResetBatteryInfo();
        /*0x72ab5f8*/ void ChangeBatteryProfilingState(bool isProfiling);
        /*0x72aafc4*/ void _HandleOnUpdate(bool isProfiling);

        class BatteryLevelData
        {
            /*0x10*/ float _batteryLevelPercent;
            /*0x18*/ System.DateTime _checkTime;

            /*0x72ab5e4*/ BatteryLevelData();
        }
    }

    class ClipboardModel : NoaDebugger.ModelBase
    {
        static /*0x72ab730*/ void Initialize();
        static /*0x72ab734*/ void _Copy(string input);
        static /*0x72ab88c*/ void Copy(string input);
        /*0x72ab890*/ ClipboardModel();
    }

    class ConsoleLogCollectorModel : NoaDebugger.LogCollectorModel
    {
        /*0x20*/ UnityEngine.Events.UnityAction<string, string, UnityEngine.LogType> OnLogReceived;

        /*0x72ab9f8*/ ConsoleLogCollectorModel();
        /*0x72ab898*/ void add_OnLogReceived(UnityEngine.Events.UnityAction<string, string, UnityEngine.LogType> value);
        /*0x72ab948*/ void remove_OnLogReceived(UnityEngine.Events.UnityAction<string, string, UnityEngine.LogType> value);
        /*0x72aba58*/ void OnCollectEnabled();
        /*0x72abafc*/ void OnCollectDisabled();
        /*0x72abba0*/ void _ReceiveLog(string logString, string stackTrace, UnityEngine.LogType type);
    }

    class CustomInformationModel : NoaDebugger.ModelBase
    {
        /*0x10*/ System.Collections.Generic.List<NoaDebugger.InformationCustomGroup> _allGroups;

        /*0x72abbbc*/ CustomInformationModel();
        /*0x72abc44*/ void AddGroup(string groupName, string displayName, int order);
        /*0x72abd3c*/ bool _ExistsGroup(string name);
        /*0x72abe20*/ void _AddGroup(string name, string displayName, int order);
        /*0x72abfb4*/ bool _ExistsKey(string keyName);
        /*0x72abfd0*/ bool TryGetValue(string keyName, ref string val);
        /*0x72ac348*/ void AddKeyValues(string groupName, string keyName, System.Func<string> getValue, string displayName, int order);
        /*0x72ac51c*/ void _AddKeyValues(NoaDebugger.InformationCustomGroup groupInfo, string keyName, System.Func<string> getValue, string displayName, int order);
        /*0x72ac4cc*/ NoaDebugger.InformationCustomGroup _GetOrCreateGroup(string name, string displayName, int order);
        /*0x72ac65c*/ NoaDebugger.InformationCustomGroup GetGroup(string name);
        /*0x72ac74c*/ System.Collections.Generic.List<NoaDebugger.InformationCustomGroup> GetAllGroups();
        /*0x72ac754*/ void RemoveKeyValue(string keyName);
        /*0x72ac9f0*/ void RemoveGroup(string groupName);
        /*0x72acb38*/ void RemoveAll();
        /*0x72acba8*/ NoaDebugger.IKeyValueParser[] CreateExportData();

        class <>c
        {
            static /*0x0*/ NoaDebugger.CustomInformationModel.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.InformationCustomGroup, int> <>9__15_0;
            static /*0x10*/ System.Func<NoaDebugger.InformationCustomKeyValue, int> <>9__15_1;

            static /*0x72ad5b8*/ <>c();
            /*0x72ad620*/ <>c();
            /*0x72ad628*/ int <CreateExportData>b__15_0(NoaDebugger.InformationCustomGroup g);
            /*0x72ad640*/ int <CreateExportData>b__15_1(NoaDebugger.InformationCustomKeyValue kv);
        }

        class <>c__DisplayClass10_0
        {
            /*0x10*/ string name;

            /*0x72ac744*/ <>c__DisplayClass10_0();
            /*0x72ad658*/ bool <GetGroup>b__0(NoaDebugger.InformationCustomGroup g);
        }

        class <>c__DisplayClass12_0
        {
            /*0x10*/ string keyName;
            /*0x18*/ System.Predicate<NoaDebugger.InformationCustomKeyValue> <>9__0;

            /*0x72ac9e8*/ <>c__DisplayClass12_0();
            /*0x72ad67c*/ bool <RemoveKeyValue>b__0(NoaDebugger.InformationCustomKeyValue kv);
        }

        class <>c__DisplayClass13_0
        {
            /*0x10*/ string groupName;

            /*0x72acb30*/ <>c__DisplayClass13_0();
            /*0x72ad6a0*/ bool <RemoveGroup>b__0(NoaDebugger.InformationCustomGroup g);
        }

        class <>c__DisplayClass3_0
        {
            /*0x10*/ string name;

            /*0x72abfac*/ <>c__DisplayClass3_0();
            /*0x72ad6c4*/ bool <_ExistsGroup>b__0(NoaDebugger.InformationCustomGroup g);
        }

        class <>c__DisplayClass6_0
        {
            /*0x10*/ string keyName;
            /*0x18*/ System.Predicate<NoaDebugger.InformationCustomKeyValue> <>9__0;
            /*0x20*/ System.Func<NoaDebugger.InformationCustomKeyValue, bool> <>9__1;

            /*0x72ac340*/ <>c__DisplayClass6_0();
            /*0x72ad6e8*/ bool <TryGetValue>b__0(NoaDebugger.InformationCustomKeyValue kv);
            /*0x72ad70c*/ bool <TryGetValue>b__1(NoaDebugger.InformationCustomKeyValue g);
        }
    }

    class DataUnitConverterModel
    {
        static /*0x0*/ string[] SizeUnits;

        static /*0x72ad8a0*/ DataUnitConverterModel();
        static /*0x72ad730*/ float ByteToMB(float byteValue);
        static /*0x72ad744*/ float KBToByte(float kbValue);
        static /*0x72ad754*/ float MBToByte(float mbValue);
        static /*0x72ad768*/ string ToHumanReadableBytes(long bytes);
    }

    class DeviceModel : NoaDebugger.ModelBase
    {
        static /*0x72ada20*/ bool get_IsUserAgentAndroid();
        static /*0x72ada58*/ bool get_IsUserAgentWindows();
        static /*0x72adabc*/ bool get_IsUserAgentMac();
        static /*0x72adb20*/ bool get_IsUserAgentIOS();
        static /*0x72adb50*/ bool get_IsWindows();
        static /*0x72adbdc*/ bool get_IsMac();
        static /*0x72adc64*/ bool get_IsAndroid();
        static /*0x72adcec*/ bool get_IsIOS();
        /*0x72add74*/ DeviceModel();
    }

    class FpsModel : NoaDebugger.ModelBase
    {
        static /*0x0*/ string FpsModelOnUpdate;
        static /*0x8*/ string ProfilerModelOnChangedBackgroundState;
        static /*0x10*/ int IgnoreFrameCountOnStart;
        static /*0x14*/ int IgnoreFrameCountOnReturnFromBackground;
        /*0x10*/ bool _isBackground;
        /*0x14*/ int _currentFrameCount;
        /*0x18*/ float _time;
        /*0x1c*/ int _ignoreFrameCount;
        /*0x20*/ NoaDebugger.FpsInfo <FpsInfo>k__BackingField;
        /*0x28*/ UnityEngine.Events.UnityAction <OnFpsInfoChanged>k__BackingField;

        static /*0x72ae408*/ FpsModel();
        /*0x72add9c*/ FpsModel();
        /*0x72add7c*/ NoaDebugger.FpsInfo get_FpsInfo();
        /*0x72add84*/ void set_FpsInfo(NoaDebugger.FpsInfo value);
        /*0x72add8c*/ UnityEngine.Events.UnityAction get_OnFpsInfoChanged();
        /*0x72add94*/ void set_OnFpsInfoChanged(UnityEngine.Events.UnityAction value);
        /*0x72ae104*/ void Dispose();
        /*0x72ae174*/ void _OnUpdate();
        /*0x72adf28*/ void _ResetFpsInfo();
        /*0x72ae2b8*/ void _ResetCounter();
        /*0x72ae2c0*/ void _OnChangedBackgroundState(bool isBackground);
        /*0x72ae338*/ void ChangeFpsProfilingState(bool isProfiling);
        /*0x72ae008*/ void _HandleOnUpdate(bool isProfiling);
    }

    class FrameSteppingModel
    {
        static /*0x0*/ float PressActionFirstInterval;
        static /*0x4*/ float PressActionSecondInterval;
        static /*0x8*/ float FrameTimeSecondsAt60FPS;
        static /*0xc*/ bool _isStepping;

        static /*0x72ae610*/ FrameSteppingModel();
        static /*0x72ae4b8*/ bool get_IsApplyGameSpeedChange();
        static /*0x72ae4d8*/ System.Collections.IEnumerator FrameStepping(System.Action onFrameStepping);
        static /*0x72ae56c*/ System.Collections.IEnumerator StepFrame(System.Action onStepFrame, float timeScale);

        class <FrameStepping>d__6 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ System.Action onFrameStepping;

            /*0x72ae544*/ <FrameStepping>d__6(int <>1__state);
            /*0x72ae674*/ void System.IDisposable.Dispose();
            /*0x72ae678*/ bool MoveNext();
            /*0x72ae778*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72ae780*/ void System.Collections.IEnumerator.Reset();
            /*0x72ae7b8*/ object System.Collections.IEnumerator.get_Current();
        }

        class <StepFrame>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ float timeScale;
            /*0x28*/ System.Action onStepFrame;

            /*0x72ae5e8*/ <StepFrame>d__7(int <>1__state);
            /*0x72ae7c0*/ void System.IDisposable.Dispose();
            /*0x72ae7c4*/ bool MoveNext();
            /*0x72ae92c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72ae934*/ void System.Collections.IEnumerator.Reset();
            /*0x72ae96c*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class FrameTimeModel : NoaDebugger.ModelBase
    {
        static /*0x0*/ string OnChangedBackgroundState;
        /*0x10*/ NoaDebugger.FrameTimeInfo <FrameTimeInfo>k__BackingField;
        /*0x18*/ UnityEngine.Events.UnityAction <OnFrameTimeInfoChanged>k__BackingField;
        /*0x20*/ bool _isSuspended;
        /*0x21*/ bool _isResumed;

        static /*0x72af0c0*/ FrameTimeModel();
        /*0x72ae98c*/ FrameTimeModel();
        /*0x72ae974*/ NoaDebugger.FrameTimeInfo get_FrameTimeInfo();
        /*0x72ae97c*/ UnityEngine.Events.UnityAction get_OnFrameTimeInfoChanged();
        /*0x72ae984*/ void set_OnFrameTimeInfoChanged(UnityEngine.Events.UnityAction value);
        /*0x72aee80*/ void Dispose();
        /*0x72aef88*/ void ToggleEnabled(bool isEnabled);
        /*0x72af040*/ void ToggleActive(bool isActive);
        /*0x72aeb90*/ void OnToggleEnabled(bool isEnabled);
        /*0x72aed0c*/ void OnToggleActive(bool isActive);
        /*0x72af048*/ void OnUpdateFrameTime(double updateMilliseconds, double renderingMilliseconds, double othersMilliseconds);
        /*0x72af0a8*/ void OnBackgroundStateChanged(bool isBackground);
    }

    class GameSpeedModel
    {
        static /*0x0*/ float _gameSpeed;

        static /*0x72afb74*/ GameSpeedModel();
        static /*0x72af12c*/ float get_GameSpeed();
        static /*0x72af184*/ void set_GameSpeed(float value);
        static /*0x72af24c*/ float get_MinGameSpeed();
        static /*0x72af258*/ float get_MaxGameSpeed();
        static /*0x72af278*/ float get_DefaultGameSpeed();
        static /*0x72af280*/ bool get_IsGamePlaying();
        static /*0x72af29c*/ void Initialize();
        static /*0x72af3d8*/ void Reset();
        static /*0x72af494*/ void Increment();
        static /*0x72af6dc*/ void Maximize();
        static /*0x72af7a8*/ void Decrement();
        static /*0x72af9dc*/ void Minimize();
        static /*0x72afa9c*/ void Pause();
        static /*0x72afaec*/ void Resume();
        static /*0x72af394*/ void _ApplyGameSpeed(float gameSpeed);
    }

    class HierarchyModel : NoaDebugger.ModelBase
    {
        /*0x10*/ System.Collections.Generic.HashSet<int> _openObjectHashSet;
        /*0x18*/ System.Collections.Generic.HashSet<int> _checkedHashSet;
        /*0x20*/ int _selectObjectHashCode;
        /*0x28*/ NoaDebugger.HierarchyGameObjectEntry _selectObjectEntry;

        /*0x72b212c*/ HierarchyModel();
        /*0x72afbc0*/ System.Collections.Generic.List<UnityEngine.SceneManagement.Scene> _GetScenes();
        /*0x72afcfc*/ UnityEngine.SceneManagement.Scene _GetDontDestroyScene();
        /*0x72afda4*/ System.Collections.Generic.List<UnityEngine.Transform> _GetTransformsInScene(UnityEngine.SceneManagement.Scene scene);
        /*0x72afedc*/ System.ValueTuple<NoaDebugger.HierarchyModel.HierarchyInformation, NoaDebugger.HierarchyGameObjectEntry> GetHierarchy();
        /*0x72b03d4*/ System.Collections.Generic.List<NoaDebugger.HierarchyGameObjectEntry> _CreateGameObjectEntryList(System.Collections.Generic.List<UnityEngine.Transform> transforms, ref int goCount);
        /*0x72b0960*/ NoaDebugger.HierarchyGameObjectEntry _CreateGameObjectEntry(UnityEngine.Transform transform, ref int goCount);
        /*0x72b0e44*/ void AddOpenObjectHash(int hashCode);
        /*0x72b0e9c*/ void RemoveOpenObjectHash(int hashCode);
        /*0x72b05e0*/ bool _ContainsOpenObjectHash(int hashCode);
        /*0x72b0670*/ void _CleaningOpenObjectHash();
        /*0x72b0ef4*/ void SetSelectObjectHashCode(int hashCode);
        /*0x72b0efc*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> GetGameObjectDetailIEntryList(UnityEngine.GameObject gameObject);
        /*0x72b113c*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> _GetGameObjectDetailList(UnityEngine.GameObject gameObject);
        /*0x72b1510*/ NoaDebugger.GameObjectDetailEntry _GetComponentDetail(UnityEngine.Component component);
        /*0x72b18d4*/ NoaDebugger.GameObjectDetailEntry _GetComponentProperty(System.Reflection.PropertyInfo propertyInfo, UnityEngine.Component component);
        /*0x72b1b84*/ NoaDebugger.GameObjectDetailEntry _GetComponentField(System.Reflection.FieldInfo fieldInfo, UnityEngine.Component component);
        /*0x72b1ef8*/ NoaDebugger.GameObjectDetailEntry _GetAttachNameFromObject(System.Reflection.FieldInfo field, object obj);

        class HierarchyInformation
        {
            /*0x10*/ System.Collections.Generic.List<NoaDebugger.HierarchyGameObjectEntry> _hierarchySceneList;
            /*0x18*/ int _objectNum;

            /*0x72b03cc*/ HierarchyInformation();
        }

        class <>c
        {
            static /*0x0*/ NoaDebugger.HierarchyModel.<> <>9;
            static /*0x8*/ System.Func<UnityEngine.GameObject, UnityEngine.Transform> <>9__6_0;

            static /*0x72b21d8*/ <>c();
            /*0x72b2240*/ <>c();
            /*0x72b2248*/ UnityEngine.Transform <_GetTransformsInScene>b__6_0(UnityEngine.GameObject go);
        }
    }

    class LocalDataExportModel : NoaDebugger.ModelBase
    {
        static /*0x72b2260*/ void ExportText(string fileName, string text, UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo> onCompleted);
        /*0x72b2344*/ LocalDataExportModel();

        class <>c__DisplayClass0_0
        {
            /*0x10*/ UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo> onCompleted;

            /*0x72b233c*/ <>c__DisplayClass0_0();
            /*0x72b234c*/ void <ExportText>b__0(NoaDebugger.FileDownloader.DownloadInfo info);
        }
    }

    class LogCollectorModel : NoaDebugger.ModelBase
    {
        /*0x10*/ string _prefKey;
        /*0x18*/ bool <IsCollecting>k__BackingField;

        /*0x72aa928*/ LogCollectorModel(string prefKey);
        /*0x72b2368*/ void set_IsCollecting(bool value);
        /*0x72b2374*/ bool get_IsCollecting();
        /*0x72b2420*/ void ToggleCollect(bool isCollecting);
        /*0x72b2444*/ void OnCollectEnabled();
        /*0x72b2448*/ void OnCollectDisabled();
        /*0x72b237c*/ void OnCollectToggled();
        /*0x72b244c*/ void Destroy();
    }

    class LogModel
    {
        static string DEBUG_SYMBOL = "NOA_DEBUGGER_DEBUG";

        static /*0x72b2458*/ void DebugLog(string message);
        static /*0x72b24e4*/ void DebugLog(object message);
        static /*0x72b2570*/ void DebugLogWarning(string message);
        static /*0x72b25fc*/ void DebugLogWarning(string message, UnityEngine.Object context);
        static /*0x72b2690*/ void ThrowException(string message);
        static /*0x72b26d4*/ void Log(object message);
        static /*0x72b2760*/ void LogWarning(string message);
        static /*0x72ab800*/ void LogError(object message);
        static /*0x72b27ec*/ void Log(object message, UnityEngine.Object context);
        static /*0x72b2880*/ void LogWarning(string message, UnityEngine.Object context);
        static /*0x72b2914*/ void LogError(string message, UnityEngine.Object context);
        static /*0x72b29a8*/ void CollectNoaDebuggerErrorLog(string message, string stackTrace);
    }

    class MemoryModel : NoaDebugger.ModelBase
    {
        static /*0x0*/ System.Threading.SynchronizationContext _synchronizationContext;
        static /*0x8*/ System.Nullable<long> _currentMemByte;
        static /*0x18*/ int UpdateIntervalFrames;
        static /*0x20*/ string MemoryModelOnUpdate;
        /*0x10*/ int _framesSinceLastUpdate;
        /*0x18*/ long _totalUnityMemoryUsageMB;
        /*0x20*/ long _totalNativeMemoryUsageMB;
        /*0x28*/ long _totalMonoMemoryUsageMB;
        /*0x30*/ int _unityMemoryCheckCount;
        /*0x34*/ int _nativeMemoryCheckCount;
        /*0x38*/ int _monoMemoryCheckCount;
        /*0x40*/ NoaDebugger.MemoryInfo <MemoryInfo>k__BackingField;
        /*0x48*/ UnityEngine.Events.UnityAction <OnMemoryInfoChanged>k__BackingField;

        static /*0x72b4418*/ MemoryModel();
        static /*0x72b2b7c*/ long AndroidCurrentMemoryByte();
        static /*0x72b3620*/ void UpdeteCurrentMemory();
        static /*0x72b36b4*/ System.Nullable<long> _GetCurrentNativeMemoryByte();
        static /*0x72b4084*/ float GetRoundedMemoryMB(long memByte);
        /*0x72b3730*/ MemoryModel();
        /*0x72b3710*/ NoaDebugger.MemoryInfo get_MemoryInfo();
        /*0x72b3718*/ void set_MemoryInfo(NoaDebugger.MemoryInfo value);
        /*0x72b3720*/ UnityEngine.Events.UnityAction get_OnMemoryInfoChanged();
        /*0x72b3728*/ void set_OnMemoryInfoChanged(UnityEngine.Events.UnityAction value);
        /*0x72b3a14*/ void Dispose();
        /*0x72b3a70*/ void _OnUpdate();
        /*0x72b3b40*/ void _SetUnityMemoryInfo();
        /*0x72b3ce0*/ void _SetNativeMemoryInfo();
        /*0x72b3ee4*/ void _SetMonoMemoryInfo();
        /*0x72b4154*/ void _ResetMemoryInfo();
        /*0x72b41d8*/ void ChangeProfilingState(bool isProfiling);
        /*0x72b42a8*/ void ChangeGraphShowingState(bool isGraphShowing);
        /*0x72b4360*/ void ChangeProfilingType(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
        /*0x72b3918*/ void _HandleOnUpdate(bool isProfiling);

        class <>c
        {
            static /*0x0*/ NoaDebugger.MemoryModel.<> <>9;
            static /*0x8*/ System.Func<long> <>9__3_1;

            static /*0x72b4488*/ <>c();
            /*0x72b44f0*/ <>c();
            /*0x72b44f8*/ long <UpdeteCurrentMemory>b__3_1();
        }

        class <>c__DisplayClass3_0
        {
            /*0x10*/ long memory;

            /*0x72b4544*/ <>c__DisplayClass3_0();
            /*0x72b454c*/ void <UpdeteCurrentMemory>b__0(object _);
        }

        struct <UpdeteCurrentMemory>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
            /*0x38*/ NoaDebugger.MemoryModel.<> <>8__1;
            /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long> <>u__1;

            /*0x72b45fc*/ void MoveNext();
            /*0x72b4a3c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    class ModelBase
    {
        /*0x72aac90*/ ModelBase();
    }

    class RenderingModel : NoaDebugger.ModelBase
    {
        static /*0x0*/ string RenderingModelOnUpdate;
        /*0x10*/ Unity.Profiling.ProfilerRecorder _setPassCallsRecorder;
        /*0x18*/ Unity.Profiling.ProfilerRecorder _drawCallsRecorder;
        /*0x20*/ Unity.Profiling.ProfilerRecorder _batchesRecorder;
        /*0x28*/ Unity.Profiling.ProfilerRecorder _trianglesRecorder;
        /*0x30*/ Unity.Profiling.ProfilerRecorder _verticesRecorder;
        /*0x38*/ NoaDebugger.RenderingInfo <RenderingInfo>k__BackingField;
        /*0x40*/ UnityEngine.Events.UnityAction <OnRenderingInfoChanged>k__BackingField;

        static /*0x72b5268*/ RenderingModel();
        /*0x72b4a68*/ RenderingModel();
        /*0x72b4a48*/ NoaDebugger.RenderingInfo get_RenderingInfo();
        /*0x72b4a50*/ void set_RenderingInfo(NoaDebugger.RenderingInfo value);
        /*0x72b4a58*/ UnityEngine.Events.UnityAction get_OnRenderingInfoChanged();
        /*0x72b4a60*/ void set_OnRenderingInfoChanged(UnityEngine.Events.UnityAction value);
        /*0x72b4eb4*/ void Dispose();
        /*0x72b4f50*/ void _OnUpdate();
        /*0x72b4f54*/ void _OnUpdateRenderingCheck();
        /*0x72b5028*/ void ChangeProfilingState(bool isProfiling);
        /*0x72b50f8*/ void ChangeGraphShowingState(bool isGraphShowing);
        /*0x72b51b0*/ void SwitchGraphTarget(NoaDebugger.RenderingGraphTarget target);
        /*0x72b4d34*/ void _HandleOnUpdate(bool isProfiling);
    }

    class SnapshotModel : NoaDebugger.ModelBase
    {
        static /*0x0*/ string SnapshotModelOnUpdate;
        static /*0x8*/ int SnapshotLogCountLimit;
        /*0x10*/ int _logIdCounter;
        /*0x14*/ int _logNumberCounter;
        /*0x18*/ int _beforeHighlightedLogId;
        /*0x1c*/ int _firstToggleCheckedLogId;
        /*0x20*/ int _secondToggleCheckedLogId;
        /*0x28*/ NoaDebugger.SnapshotModel.SnapshotInformation <SnapshotInfo>k__BackingField;
        /*0x30*/ UnityEngine.Events.UnityAction <OnTimeDataUpdated>k__BackingField;

        static /*0x72b6680*/ SnapshotModel();
        /*0x72b52f4*/ SnapshotModel();
        /*0x72b52d4*/ NoaDebugger.SnapshotModel.SnapshotInformation get_SnapshotInfo();
        /*0x72b52dc*/ void set_SnapshotInfo(NoaDebugger.SnapshotModel.SnapshotInformation value);
        /*0x72b52e4*/ UnityEngine.Events.UnityAction get_OnTimeDataUpdated();
        /*0x72b52ec*/ void set_OnTimeDataUpdated(UnityEngine.Events.UnityAction value);
        /*0x72b5410*/ void Dispose();
        /*0x72b546c*/ void SetUpdateAction();
        /*0x72b5520*/ void DeleteUpdateAction();
        /*0x72b557c*/ void _OnUpdate();
        /*0x72b53d4*/ void UpdateProfilingStartTime();
        /*0x72b569c*/ void UpdateProfilingElapsedTime();
        /*0x72b56a0*/ void ChangeComparisonState(bool forceUpdate, bool isComparison);
        /*0x72b56d8*/ void InsertLog(NoaDebugger.ProfilerSnapshotData snapshotData, string label, System.Nullable<UnityEngine.Color> backgroundColor, System.Collections.Generic.Dictionary<string, NoaDebugger.NoaSnapshotCategory> additionalInfo);
        /*0x72b5b44*/ void RemoveAtLog(int index);
        /*0x72b5f30*/ void ClearAllLog();
        /*0x72b5fa4*/ void ClearAllLogSelected();
        /*0x72b6230*/ void ClearAllLogChecked();
        /*0x72b5a78*/ void _OnLogInfoUpdated();
        /*0x72b6398*/ void UpdateLogLabel(int logId, string text);
        /*0x72b64a0*/ void SetHighlightLogId(int logId);
        /*0x72b64e4*/ void SetSelectedLogId(int logId);
        /*0x72b5c18*/ void SetCheckedLogId(int logId);
        /*0x72b6114*/ void _SetLogHighlight(int logId, bool isHighlighted);
        /*0x72b6700*/ bool <SetCheckedLogId>b__32_0(NoaDebugger.SnapshotLogRecordInformation x);
        /*0x72b6724*/ bool <SetCheckedLogId>b__32_1(NoaDebugger.SnapshotLogRecordInformation x);

        enum ToggleState
        {
            None = 0,
            SelectedFirst = 1,
            SelectedSecond = 2,
            Disabled = 3,
        }

        class SnapshotInformation
        {
            /*0x10*/ bool _isComparison;
            /*0x14*/ float _profilingStartTime;
            /*0x18*/ int _elapsedTimeMilliseconds;
            /*0x20*/ System.TimeSpan _elapsedTime;
            /*0x28*/ System.Collections.Generic.List<NoaDebugger.SnapshotLogRecordInformation> _logList;

            /*0x72b53cc*/ SnapshotInformation();
        }

        class <>c__DisplayClass29_0
        {
            /*0x10*/ int logId;

            /*0x72b6498*/ <>c__DisplayClass29_0();
            /*0x72b6748*/ bool <UpdateLogLabel>b__0(NoaDebugger.SnapshotLogRecordInformation x);
        }

        class <>c__DisplayClass33_0
        {
            /*0x10*/ int logId;

            /*0x72b6678*/ <>c__DisplayClass33_0();
            /*0x72b676c*/ bool <_SetLogHighlight>b__0(NoaDebugger.SnapshotLogRecordInformation x);
        }
    }

    class SystemInformationModel : NoaDebugger.ModelBase
    {
        /*0x10*/ NoaDebugger.ApplicationInfo <ApplicationInfo>k__BackingField;
        /*0x18*/ NoaDebugger.DeviceInfo <DeviceInfo>k__BackingField;
        /*0x20*/ NoaDebugger.CpuInfo <CpuInfo>k__BackingField;
        /*0x28*/ NoaDebugger.GpuInfo <GpuInfo>k__BackingField;
        /*0x30*/ NoaDebugger.SystemMemoryInfo <SystemMemoryInfo>k__BackingField;
        /*0x38*/ NoaDebugger.DisplayInfo <DisplayInfo>k__BackingField;

        /*0x72b67f0*/ SystemInformationModel();
        /*0x72b6790*/ void set_ApplicationInfo(NoaDebugger.ApplicationInfo value);
        /*0x72b6798*/ NoaDebugger.ApplicationInfo get_ApplicationInfo();
        /*0x72b67a0*/ void set_DeviceInfo(NoaDebugger.DeviceInfo value);
        /*0x72b67a8*/ NoaDebugger.DeviceInfo get_DeviceInfo();
        /*0x72b67b0*/ void set_CpuInfo(NoaDebugger.CpuInfo value);
        /*0x72b67b8*/ NoaDebugger.CpuInfo get_CpuInfo();
        /*0x72b67c0*/ void set_GpuInfo(NoaDebugger.GpuInfo value);
        /*0x72b67c8*/ NoaDebugger.GpuInfo get_GpuInfo();
        /*0x72b67d0*/ void set_SystemMemoryInfo(NoaDebugger.SystemMemoryInfo value);
        /*0x72b67d8*/ NoaDebugger.SystemMemoryInfo get_SystemMemoryInfo();
        /*0x72b67e0*/ void set_DisplayInfo(NoaDebugger.DisplayInfo value);
        /*0x72b67e8*/ NoaDebugger.DisplayInfo get_DisplayInfo();
        /*0x72b69f4*/ void OnUpdate();
        /*0x72b6a10*/ NoaDebugger.IKeyValueParser[] CreateExportData();
    }

    class TargetFrameRateModel : NoaDebugger.ModelBase
    {
        static /*0x0*/ int[] PresetChoices;
        static /*0x8*/ string DefaultLabel;
        static /*0x10*/ string TargetFrameRateLabel;
        /*0x10*/ int _cachedTargetFrameRate;
        /*0x18*/ System.Collections.Generic.List<int> _targetFrameRateList;
        /*0x20*/ string[] _targetFrameRateChoicesArray;
        /*0x28*/ bool _isNeedUpdateList;

        static /*0x72b7384*/ TargetFrameRateModel();
        /*0x72b6d24*/ TargetFrameRateModel();
        /*0x72b6d4c*/ string[] GetChoicesArrayIfNeedUpdate();
        /*0x72b714c*/ int GetCurrentIndex();
        /*0x72b71f4*/ void SetTargetFrameRate(int targetFrameRateIndex);
        /*0x72b7284*/ string _GetTargetFrameRateText(int targetFrameRate);
        /*0x72b7350*/ void Dispose();
        /*0x72b706c*/ bool <GetChoicesArrayIfNeedUpdate>g__addListUnique|8_0(int value);

        class <>c
        {
            static /*0x0*/ NoaDebugger.TargetFrameRateModel.<> <>9;
            static /*0x8*/ System.Func<int, int> <>9__8_1;

            static /*0x72b747c*/ <>c();
            /*0x72b74e4*/ <>c();
            /*0x72b74ec*/ int <GetChoicesArrayIfNeedUpdate>b__8_1(int x);
        }
    }

    class ThermalModel : NoaDebugger.ModelBase
    {
        static /*0x0*/ string ThermalModelOnUpdate;
        static /*0x8*/ float ThermalCheckIntervalSec;
        static /*0xc*/ bool DefaultIsProfiling;
        /*0x10*/ float _timeSinceThermalCheck;
        /*0x14*/ float _totalTemperature;
        /*0x18*/ int _temperatureCount;
        /*0x20*/ NoaDebugger.ThermalInfo <ThermalInfo>k__BackingField;
        /*0x28*/ UnityEngine.Events.UnityAction <OnThermalInfoChanged>k__BackingField;

        static /*0x72b8474*/ ThermalModel();
        static /*0x72b7a28*/ bool CanProfiling();
        /*0x72b7514*/ ThermalModel();
        /*0x72b74f4*/ NoaDebugger.ThermalInfo get_ThermalInfo();
        /*0x72b74fc*/ void set_ThermalInfo(NoaDebugger.ThermalInfo value);
        /*0x72b7504*/ UnityEngine.Events.UnityAction get_OnThermalInfoChanged();
        /*0x72b750c*/ void set_OnThermalInfoChanged(UnityEngine.Events.UnityAction value);
        /*0x72b77c0*/ void Dispose();
        /*0x72b781c*/ void _OnUpdate();
        /*0x72b75b8*/ void _ResetThermalInfo();
        /*0x72b79ec*/ void ChangeProfilingState(bool isProfiling);
        /*0x72b76ac*/ void _HandleOnUpdate(bool isProfiling);
        /*0x72b7aac*/ float GetCurrentTemperature();
        /*0x72b78f0*/ void _OnUpdateThermalInfo();
    }

    class TimeUnitConverterModel
    {
        static /*0x72ab5ec*/ int MinutesToSeconds(int minutes);
        static /*0x72ab720*/ float SecondsToMinutes(float seconds);
        /*0x72b84f8*/ TimeUnitConverterModel();
    }

    class ToolDetailModel : NoaDebugger.ModelBase
    {
        static string OPERATIONAL_VALUE = "operational";
        /*0x10*/ NoaDebugger.ToolDetailInformation <ToolDetailInformation>k__BackingField;
        /*0x18*/ NoaDebugger.NoaDebuggerInfo _noaDebuggerInfo;

        /*0x72b8510*/ ToolDetailModel();
        /*0x72b8500*/ void set_ToolDetailInformation(NoaDebugger.ToolDetailInformation value);
        /*0x72b8508*/ NoaDebugger.ToolDetailInformation get_ToolDetailInformation();
        /*0x72b859c*/ void _LoadAsset();
        /*0x72b8704*/ void _LoadShortcutKeySettings();
        /*0x72b8658*/ void SetOperatingEnv(string osVersion, NoaDebugger.ToolDetailModel.OSType osType, string device, string unityVersion);
        /*0x72b8640*/ string get_OsVersion();
        /*0x72b8638*/ NoaDebugger.ToolDetailModel.OSType get_OsType();
        /*0x72b8990*/ bool _CheckSupported(string osVersion, NoaDebugger.ToolDetailModel.OSType osType, string device, string unityVersion);
        /*0x72b8a4c*/ string _SupportedVersionText(string osVersion, NoaDebugger.ToolDetailModel.OSType osType);
        /*0x72b8b98*/ string _GetSupportedBrowserText(string osVersion);
        /*0x72b8de4*/ string _SupportedBrowserTextFromSupportInfo(NoaDebugger.SupportBrowserInfo[] supportedBrowsersInfo, bool hasMobile);

        enum OSType
        {
            Unknown = 0,
            Editor = 1,
            Ios = 2,
            Android = 3,
            Standalone = 4,
            Webgl = 5,
        }

        class <>c
        {
            static /*0x0*/ NoaDebugger.ToolDetailModel.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.SupportBrowserInfo, string> <>9__18_0;
            static /*0x10*/ System.Func<NoaDebugger.SupportBrowserInfo, string> <>9__18_2;
            static /*0x18*/ System.Func<System.Linq.IGrouping<string, NoaDebugger.SupportBrowserInfo>, string> <>9__18_1;

            static /*0x72b9080*/ <>c();
            /*0x72b90e8*/ <>c();
            /*0x72b90f0*/ string <_SupportedBrowserTextFromSupportInfo>b__18_0(NoaDebugger.SupportBrowserInfo x);
            /*0x72b9108*/ string <_SupportedBrowserTextFromSupportInfo>b__18_1(System.Linq.IGrouping<string, NoaDebugger.SupportBrowserInfo> browserGroup);
            /*0x72b92fc*/ string <_SupportedBrowserTextFromSupportInfo>b__18_2(NoaDebugger.SupportBrowserInfo x);
        }
    }

    class ToolDetailInformation
    {
        /*0x10*/ string _operatingEnv;
        /*0x18*/ System.Collections.Generic.Dictionary<string, string> _shortcutKeyMappings;
        /*0x20*/ string _copyright;

        /*0x72b8988*/ ToolDetailInformation();
    }

    class UnityInformationModel : NoaDebugger.ModelBase
    {
        /*0x10*/ NoaDebugger.UnityInfo <UnityInfo>k__BackingField;
        /*0x18*/ NoaDebugger.RuntimeInfo <RuntimeInfo>k__BackingField;
        /*0x20*/ NoaDebugger.FeaturesInfo <FeaturesInfo>k__BackingField;
        /*0x28*/ NoaDebugger.GraphicsInfo <GraphicsInfo>k__BackingField;

        /*0x72b9354*/ UnityInformationModel();
        /*0x72b9314*/ void set_UnityInfo(NoaDebugger.UnityInfo value);
        /*0x72b931c*/ NoaDebugger.UnityInfo get_UnityInfo();
        /*0x72b9324*/ void set_RuntimeInfo(NoaDebugger.RuntimeInfo value);
        /*0x72b932c*/ NoaDebugger.RuntimeInfo get_RuntimeInfo();
        /*0x72b9334*/ void set_FeaturesInfo(NoaDebugger.FeaturesInfo value);
        /*0x72b933c*/ NoaDebugger.FeaturesInfo get_FeaturesInfo();
        /*0x72b9344*/ void set_GraphicsInfo(NoaDebugger.GraphicsInfo value);
        /*0x72b934c*/ NoaDebugger.GraphicsInfo get_GraphicsInfo();
        /*0x72b94f4*/ void OnUpdate();
        /*0x72b9534*/ void _ActiveSceneChanged(UnityEngine.SceneManagement.Scene thisScene, UnityEngine.SceneManagement.Scene nextScene);
        /*0x72b9550*/ NoaDebugger.IKeyValueParser[] CreateExportData();
    }

    class UserAgentModel : NoaDebugger.ModelBase
    {
        static /*0x72b9784*/ bool get_IsWebGLandiOSorMacSafari();
        static /*0x72ada50*/ bool IsMatchRegexPattern(string pattern);
        static /*0x72b978c*/ bool get_IsMobileBrowser();
        /*0x72b9794*/ UserAgentModel();
    }

    class ApiLogPresenter : NoaDebugger.LogPresenterBase<NoaDebugger.ApiLogEntry, NoaDebugger.ApiLog>, NoaDebugger.INoaDebuggerTool, NoaDebugger.INoaDebuggerOverlayTool
    {
        static int LOG_CATEGORY_COUNT = 2;
        static string DETAIL_HEADER_PREFIX = "[";
        static string DETAIL_HEADER_SUFFIX = "]";
        static string DETAIL_HEADER_GENERAL = "General";
        static string DETAIL_CONTENT_URL = "URL";
        static string DETAIL_CONTENT_REQUEST_METHOD = "Request Method";
        static string DETAIL_CONTENT_STATUS_CODE = "Status Code";
        static string DETAIL_HEADER_REQUEST_HEADERS = "Request Headers";
        static string DETAIL_HEADER_REQUEST_BODY = "Request Body";
        static string DETAIL_HEADER_RESPONSE_HEADERS = "Response Headers";
        static string DETAIL_HEADER_RESPONSE_BODY = "Response Body";
        /*0xd8*/ NoaDebugger.RingBuffer<NoaDebugger.ApiLogPresenter.ApiLogAttributes> _logAttributes;
        /*0xe0*/ int _requestCount;
        /*0xe8*/ long _totalReceivedBytes;
        /*0xf0*/ long _totalResponseTimeMilliSeconds;
        /*0xf8*/ NoaDebugger.ToolNotificationStatus _notifyStatus;
        /*0x100*/ NoaDebugger.RingBuffer<NoaDebugger.ApiLogEntry> _errorLogBuffer;
        /*0x108*/ NoaDebugger.RingBuffer<NoaDebugger.ApiLogEntry> _normalLogBuffer;
        /*0x110*/ UnityEngine.Events.UnityAction<NoaDebugger.ApiLogEntry> _onErrorLogReceived;
        /*0x118*/ UnityEngine.Events.UnityAction<NoaDebugger.ApiLogEntry, string> _onLogCopied;
        /*0x120*/ System.Func<string, string, bool> _onLogDownload;
        /*0x128*/ System.Func<string, System.Collections.Generic.List<NoaDebugger.ApiLogEntry>, bool> _onLogDownloadWithLogEntries;
        /*0x130*/ UnityEngine.Events.UnityAction<System.Collections.Generic.List<NoaDebugger.ApiLogEntry>> _onLogSend;
        /*0x138*/ int _logSerialNumberCounter;
        /*0x140*/ NoaDebugger.ApiLogPresenter.ApiLogMenuInfo _apiLogMenuInfo;

        static /*0x72bc0e4*/ string CreateLogDetailString(NoaDebugger.ApiLog log);
        static /*0x72bad90*/ System.Collections.Generic.List<NoaDebugger.IKeyValueParser> AddLogDetailParsers(System.Collections.Generic.List<NoaDebugger.IKeyValueParser> parsers, NoaDebugger.ApiLog logDetail);
        static /*0x72bc694*/ string <CreateLogDetailString>g__toHeaderString|57_0(string text);
        /*0x72bc7b8*/ ApiLogPresenter();
        /*0x72b979c*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x72b97a4*/ NoaDebugger.LogCollectorModel CreateLogCollectorModel();
        /*0x72b9858*/ int GetLogCapacity();
        /*0x72b9934*/ void SetLogPanelInfo(ref NoaDebugger.LogViewLinker.LogPanelInfo logPanelInfo, NoaDebugger.ApiLogEntry log);
        /*0x72b99e0*/ string GetStatusString();
        /*0x72b9ab8*/ void OnClearLog();
        /*0x72b9b44*/ void OnLogCopied(NoaDebugger.ApiLogEntry log, string clipboardText);
        /*0x72b9b60*/ System.Nullable<bool> OnLogDownload(string fileName, string json);
        /*0x72b9d14*/ string GetExportFilenamePrefix();
        /*0x72b9d54*/ void OnLogSend();
        /*0x72b9ea4*/ bool IsRegisteredSend();
        /*0x72b9eb4*/ string GetFilterSavePrefsKey();
        /*0x72b9f0c*/ NoaDebugger.LogOverlaySettingsDefaultGetter _CreateOverlaySettingsDefaultGetter();
        /*0x72b9f60*/ string GetOverlayPrefsKey();
        /*0x72b9fa0*/ NoaDebugger.KeyValueSerializer CreateLogKeyValueSerializer();
        /*0x72bb534*/ void Init();
        /*0x72bb69c*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x72bb718*/ void ShowView(UnityEngine.Transform parent);
        /*0x72bb770*/ bool GetPinStatus();
        /*0x72bb7b8*/ void TogglePin(UnityEngine.Transform parent);
        /*0x72bb810*/ void InitOverlay(UnityEngine.Transform parent);
        /*0x72bb888*/ bool GetSettingsStatus();
        /*0x72bb8d0*/ void ToggleOverlaySettings(UnityEngine.Transform parent);
        /*0x72bb940*/ void AlignmentUI(bool isReverse);
        /*0x72bb998*/ void OnHidden();
        /*0x72bb9e0*/ void OnToolDispose();
        /*0x72bba58*/ void _ReceiveLog(NoaDebugger.ApiLog log);
        /*0x72bbf18*/ NoaDebugger.ApiLogPresenter.ApiLogAttributes _GetApiLogAttribute(NoaDebugger.ApiLogEntry target, ref int index);
        /*0x72bc068*/ void _SetNotificationStatus(NoaDebugger.ToolNotificationStatus notifyStatus);
        /*0x72bc700*/ void OnDestroy();

        struct ApiLogAttributes
        {
            /*0x10*/ long _contentSize;
            /*0x18*/ long _responseTimeMilliSeconds;
            /*0x20*/ NoaDebugger.LogType _logType;
            /*0x28*/ long _totalResponseTimeMilliSeconds;
        }

        class ApiLogMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x72bb710*/ ApiLogMenuInfo();
            /*0x72bc800*/ string get_Name();
            /*0x72bc840*/ string get_MenuName();
            /*0x72bc880*/ int get_SortNo();
        }

        class <>c
        {
            static /*0x0*/ NoaDebugger.ApiLogPresenter.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.ApiLogEntry, bool> <>9__33_0;
            static /*0x10*/ System.Func<NoaDebugger.ApiLogEntry, bool> <>9__35_0;

            static /*0x72bc888*/ <>c();
            /*0x72bc8f0*/ <>c();
            /*0x72bc8f8*/ bool <OnLogDownload>b__33_0(NoaDebugger.ApiLogEntry log);
            /*0x72bc93c*/ bool <OnLogSend>b__35_0(NoaDebugger.ApiLogEntry log);
        }
    }

    class ConsoleLogPresenter : NoaDebugger.LogPresenterBase<NoaDebugger.ConsoleLogEntry, NoaDebugger.ConsoleLogDetail>, NoaDebugger.INoaDebuggerTool, NoaDebugger.INoaDebuggerOverlayTool
    {
        static int LOG_STACKTRACE_EXCEPTION_INDEX = 0;
        static int LOG_STACKTRACE_OTHER_INDEX = 0;
        /*0xd8*/ NoaDebugger.ToolNotificationStatus _notifyStatus;
        /*0xe0*/ NoaDebugger.RingBuffer<NoaDebugger.ConsoleLogEntry> _errorLogBuffer;
        /*0xe8*/ NoaDebugger.RingBuffer<NoaDebugger.ConsoleLogEntry> _warningLogBuffer;
        /*0xf0*/ NoaDebugger.RingBuffer<NoaDebugger.ConsoleLogEntry> _normalLogBuffer;
        /*0xf8*/ UnityEngine.Events.UnityAction<NoaDebugger.ConsoleLogEntry> _onErrorLogReceived;
        /*0x100*/ System.Func<NoaDebugger.ConsoleLogEntry, bool> _onFilterErrorNotification;
        /*0x108*/ UnityEngine.Events.UnityAction<NoaDebugger.ConsoleLogEntry, string> _onLogCopied;
        /*0x110*/ System.Func<string, string, bool> _onLogDownload;
        /*0x118*/ System.Func<string, System.Collections.Generic.List<NoaDebugger.ConsoleLogEntry>, bool> _onLogDownloadWithLogEntries;
        /*0x120*/ UnityEngine.Events.UnityAction<System.Collections.Generic.List<NoaDebugger.ConsoleLogEntry>> _onLogSend;
        /*0x128*/ int _logSerialNumberCounter;
        /*0x130*/ NoaDebugger.ConsoleLogPresenter.ConsoleLogMenuInfo _consoleLogMenuInfo;

        /*0x72be764*/ ConsoleLogPresenter();
        /*0x72bc980*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x72bc988*/ NoaDebugger.LogCollectorModel CreateLogCollectorModel();
        /*0x72bca3c*/ void ReceiveLogGenerateStackTraceFirstLine(string logString, string stackTrace, UnityEngine.LogType type);
        /*0x72bcfac*/ void _ReceiveLogGenerateStackTrace(string logString, string stackTrace, UnityEngine.LogType type);
        /*0x72bcbcc*/ void _ReceiveLog(string logString, NoaDebugger.ConsoleLogDetail logDetail, UnityEngine.LogType type, string stackTraceString);
        /*0x72bd12c*/ bool _IsMatchLog(NoaDebugger.ConsoleLogEntry target, NoaDebugger.ConsoleLogEntry source);
        /*0x72bd050*/ string _CreateStackTraceString(string stackTrace, UnityEngine.LogType type);
        /*0x72bcb5c*/ bool _IsStackTraceLogType(UnityEngine.LogType logType, UnityEngine.StackTraceLogType stackTraceLogType);
        /*0x72bd1a4*/ void _SetNotificationStatus(NoaDebugger.ToolNotificationStatus notifyStatus);
        /*0x72bd220*/ int GetLogCapacity();
        /*0x72bd2fc*/ void SetLogPanelInfo(ref NoaDebugger.LogViewLinker.LogPanelInfo logPanelInfo, NoaDebugger.ConsoleLogEntry log);
        /*0x72bd3a0*/ string GetStatusString();
        /*0x72bd3b8*/ void OnClearLog();
        /*0x72bd3bc*/ void OnLogCopied(NoaDebugger.ConsoleLogEntry log, string clipboardText);
        /*0x72bd3d8*/ System.Nullable<bool> OnLogDownload(string fileName, string json);
        /*0x72bd58c*/ string GetExportFilenamePrefix();
        /*0x72bd5cc*/ void OnLogSend();
        /*0x72bd71c*/ bool IsRegisteredSend();
        /*0x72bd72c*/ string GetFilterSavePrefsKey();
        /*0x72bd784*/ NoaDebugger.LogOverlaySettingsDefaultGetter _CreateOverlaySettingsDefaultGetter();
        /*0x72bd7d8*/ string GetOverlayPrefsKey();
        /*0x72bd818*/ NoaDebugger.KeyValueSerializer CreateLogKeyValueSerializer();
        /*0x72be1b8*/ void Init();
        /*0x72be2f0*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x72be36c*/ void ShowView(UnityEngine.Transform parent);
        /*0x72be3c4*/ bool GetPinStatus();
        /*0x72be40c*/ void TogglePin(UnityEngine.Transform parent);
        /*0x72be464*/ void InitOverlay(UnityEngine.Transform parent);
        /*0x72be4dc*/ bool GetSettingsStatus();
        /*0x72be524*/ void ToggleOverlaySettings(UnityEngine.Transform parent);
        /*0x72be594*/ void AlignmentUI(bool isReverse);
        /*0x72be5ec*/ void OnHidden();
        /*0x72be634*/ void OnToolDispose();
        /*0x72be6ac*/ void OnDestroy();

        class ConsoleLogMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x72be364*/ ConsoleLogMenuInfo();
            /*0x72be7ac*/ string get_Name();
            /*0x72be7ec*/ string get_MenuName();
            /*0x72be82c*/ int get_SortNo();
        }

        class <>c
        {
            static /*0x0*/ NoaDebugger.ConsoleLogPresenter.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.ConsoleLogEntry, bool> <>9__28_0;
            static /*0x10*/ System.Func<NoaDebugger.ConsoleLogEntry, bool> <>9__30_0;

            static /*0x72be834*/ <>c();
            /*0x72be89c*/ <>c();
            /*0x72be8a4*/ bool <OnLogDownload>b__28_0(NoaDebugger.ConsoleLogEntry log);
            /*0x72be8e8*/ bool <OnLogSend>b__30_0(NoaDebugger.ConsoleLogEntry log);
        }
    }

    class DownloadDialogPresenter : System.IDisposable
    {
        /*0x10*/ NoaDebugger.DownloadDialog _dialogPrefab;
        /*0x18*/ NoaDebugger.DownloadDialog _dialog;
        /*0x20*/ string _label;
        /*0x28*/ UnityEngine.Events.UnityAction<string, UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo>> OnExecDownload;

        /*0x72bea8c*/ DownloadDialogPresenter(NoaDebugger.DownloadDialog dialogPrefab);
        /*0x72be92c*/ void add_OnExecDownload(UnityEngine.Events.UnityAction<string, UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo>> value);
        /*0x72be9dc*/ void remove_OnExecDownload(UnityEngine.Events.UnityAction<string, UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo>> value);
        /*0x72beabc*/ void ShowDialog();
        /*0x72becc0*/ void _OnChangeExportLabel(string label);
        /*0x72becc8*/ void _OnExecDownload();
        /*0x72bed70*/ void _DownloadCompleted(NoaDebugger.FileDownloader.DownloadInfo info);
        /*0x72bedf8*/ void Dispose();
    }

    class FloatingWindowPresenter<TVIEW, TLINKER>
    {
        static /*0x0*/ string KeyPrefix;
        /*0x0*/ string _deviceOrientationKey;
        /*0x0*/ string _prefsKey;
        /*0x0*/ TVIEW _landscapeFloatingWindowPrefab;
        /*0x0*/ TVIEW _portraitFloatingWindowPrefab;
        /*0x0*/ TVIEW _floatingWindow;
        /*0x0*/ NoaDebugger.FloatingWindowInfo _floatingWindowInfo;
        /*0x0*/ string _toolName;
        /*0x0*/ UnityEngine.Events.UnityAction<TVIEW> OnInitAction;

        static /*0x38358cc*/ FloatingWindowPresenter();
        /*0x3907c14*/ FloatingWindowPresenter(TVIEW windowPrefab, string prefsKey, string toolName);
        /*0x3907c14*/ FloatingWindowPresenter(TVIEW landscapeWindowPrefab, TVIEW portraitWindowPrefab, string prefsKey, string toolName);
        /*0x380b128*/ bool get_IsActive();
        /*0x380d83c*/ void add_OnInitAction(UnityEngine.Events.UnityAction<TVIEW> value);
        /*0x380d83c*/ void remove_OnInitAction(UnityEngine.Events.UnityAction<TVIEW> value);
        /*0x380bb68*/ UnityEngine.GameObject InstantiateWindow(UnityEngine.Transform parent);
        /*0x3907c14*/ void ShowWindowView(TLINKER linker);
        /*0x380bb68*/ UnityEngine.GameObject ToggleActive(UnityEngine.Transform parent);
        /*0x380cdf0*/ void _OnToggleStateChangeToFloatingWindow(bool isShowDefault);
        /*0x380e304*/ void _OnDragFloatingWindow(UnityEngine.Vector2 screenPos);
        /*0x380e304*/ void _OnDragEndToFloatingWindow(UnityEngine.Vector2 screenPos);
        /*0x380cb08*/ void _OnCloseToFloatingWindow();
        void _OnRefreshFloatingWindow(bool isAutoRefresh, NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker linker);
        /*0x380d83c*/ void _OnLongTapRefreshButton(NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker linker);
        /*0x380cdf0*/ void _OnDeviceOrientation(bool isPortrait);
        /*0x380cb08*/ void DestroyWindow();
    }

    class HierarchyPresenter : NoaDebugger.NoaDebuggerToolBase, NoaDebugger.INoaDebuggerTool, NoaDebugger.INoaDebuggerFloatingTool
    {
        /*0x20*/ NoaDebugger.HierarchyView _mainViewPrefab;
        /*0x28*/ NoaDebugger.HierarchyView _mainView;
        /*0x30*/ NoaDebugger.HierarchyFloatingWindowView _floatingWindowPrefab;
        /*0x38*/ NoaDebugger.FloatingWindowPresenter<NoaDebugger.HierarchyFloatingWindowView, NoaDebugger.HierarchyViewLinker> _floatingWindowPresenter;
        /*0x40*/ NoaDebugger.HierarchyModel _hierarchyModel;
        /*0x48*/ NoaDebugger.HierarchyModel.HierarchyInformation _hierarchyInfo;
        /*0x50*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> _componentPropertyList;
        /*0x58*/ NoaDebugger.HierarchyGameObjectEntry _selectGameObjectEntry;
        /*0x60*/ bool _isLockSelectGameObject;
        /*0x61*/ bool _isSelectGameObjectPropertyChanged;
        /*0x68*/ NoaDebugger.HierarchyPresenter.HierarchyMenuInfo _menuInfo;

        /*0x72c022c*/ HierarchyPresenter();
        /*0x72beeb0*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x72bef28*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x72bef30*/ void Init();
        /*0x72bf130*/ void ShowView(UnityEngine.Transform parent);
        /*0x72bf234*/ void _InitView(NoaDebugger.HierarchyView view);
        /*0x72bf398*/ void _HiddenView();
        /*0x72bf42c*/ void _UpdateView();
        /*0x72bf378*/ void _RefreshHierarchy();
        /*0x72bf808*/ void _OnHierarchyToggleOpen(int hash, bool isOpen);
        /*0x72bf82c*/ void _OnDetailLock(bool isLock);
        /*0x72bf838*/ void _OnSwitchSelectedObjectActive(bool isActive);
        /*0x72bf910*/ void _SelectGameObject(NoaDebugger.HierarchyGameObjectEntry target);
        /*0x72bf9ec*/ void AlignmentUI(bool isReverse);
        /*0x72bfa10*/ bool GetPinStatus();
        /*0x72bfa60*/ void TogglePin(UnityEngine.Transform parent);
        /*0x72bfab8*/ void InitFloatingWindow(UnityEngine.Transform parent);
        /*0x72bfb44*/ void _InitFloatingWindow(NoaDebugger.HierarchyFloatingWindowView window);
        /*0x72bfc10*/ void OnHidden();
        /*0x72bfc14*/ void OnToolDispose();
        /*0x72bf568*/ NoaDebugger.HierarchyViewLinker _CreateLinker();
        /*0x72bfc64*/ System.Collections.Generic.List<NoaDebugger.HierarchyPanelData> _CreateHierarchyData();
        /*0x72bff5c*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailPanelData> _CreateComponentPanelData();
        /*0x72c0194*/ void OnDestroy();

        class HierarchyMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x72bef20*/ HierarchyMenuInfo();
            /*0x72c02bc*/ string get_Name();
            /*0x72c02fc*/ string get_MenuName();
            /*0x72c033c*/ int get_SortNo();
        }
    }

    class InformationPresenter : NoaDebugger.NoaDebuggerToolBase, NoaDebugger.INoaDebuggerTool
    {
        /*0x20*/ NoaDebugger.InformationView _mainViewPrefab;
        /*0x28*/ NoaDebugger.InformationView _mainView;
        /*0x30*/ NoaDebugger.DownloadDialog _dialogPrefab;
        /*0x38*/ NoaDebugger.DownloadDialogPresenter _downloadDialogPresenter;
        /*0x40*/ NoaDebugger.SystemInformationModel _systemInfoModel;
        /*0x48*/ NoaDebugger.UnityInformationModel _unityInfoModel;
        /*0x50*/ NoaDebugger.CustomInformationModel _customInfoModel;
        /*0x58*/ NoaDebugger.AutoRefreshSwitcher _autoRefreshSwitcher;
        /*0x60*/ UnityEngine.ScreenOrientation _lastOrientation;
        /*0x64*/ NoaDebugger.InformationView.ToggleTabType _tabType;
        /*0x68*/ System.Func<string, string, bool> _onDownload;
        /*0x70*/ NoaDebugger.InformationPresenter.InformationMenuInfo _informationMenuInfo;

        /*0x72c1c84*/ InformationPresenter();
        /*0x72c0344*/ bool get_IsShowView();
        /*0x72c03d8*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x72c03e0*/ void Init();
        /*0x72c05b0*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x72c0628*/ void ShowView(UnityEngine.Transform parent);
        /*0x72c06f8*/ void _InitView(NoaDebugger.InformationView view);
        /*0x72c0994*/ void AlignmentUI(bool isReverse);
        /*0x72c09b8*/ void AddCustomGroup(string groupName, string displayName, int order);
        /*0x72c09d0*/ void AddCustomGroupKeyValue(string groupName, string keyName, System.Func<string> getValue, string displayName, int order);
        /*0x72c09e8*/ void RefreshCustomView();
        /*0x72c09fc*/ string GetCustomValue(string keyName);
        /*0x72c0a24*/ NoaDebugger.NoaCustomInformationGroup GetNoaCustomGroup(string groupName);
        /*0x72c0ab4*/ System.Collections.Generic.List<NoaDebugger.NoaCustomInformationGroup> GetAllCustomGroups();
        /*0x72c0d1c*/ void RemoveCustomKeyValue(string keyName);
        /*0x72c0d34*/ void RemoveCustomGroup(string groupName);
        /*0x72c0d4c*/ void RemoveAllCustomGroup();
        /*0x72c0d64*/ void _OnHidden();
        /*0x72c0e04*/ void OnHidden();
        /*0x72c0e08*/ void OnToolDispose();
        /*0x72c0e48*/ void _OnClickTabButton(NoaDebugger.InformationView.ToggleTabType tabType);
        /*0x72c0e50*/ void _OnRefreshButton(bool isAutoRefresh);
        /*0x72c0e70*/ void _OnUpdateAutoRefreshState();
        /*0x72c0e98*/ void _OnAutoRefresh();
        /*0x72c0880*/ void _UpdateTabView();
        /*0x72c0ebc*/ NoaDebugger.SystemInformationViewLinker _GetSystemViewLinker();
        /*0x72c12b0*/ NoaDebugger.UnityInformationViewLinker _GetUnitySystemViewLinker();
        /*0x72c14e8*/ NoaDebugger.CustomInformationViewLinker _GetCustomViewLinker();
        /*0x72c1564*/ void _OnDownload();
        /*0x72c1654*/ void _OnExecDownload(string label, UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo> completed);
        /*0x72c17e4*/ string _CreateExportJsonString(string label);
        /*0x72c18a4*/ NoaDebugger.KeyValueSerializer _CreateInformationExportData();
        /*0x72c1b00*/ NoaDebugger.SystemInformation CreateSystemInformation();
        /*0x72c1b7c*/ NoaDebugger.UnityInformation CreateUnityInformation();
        /*0x72c1bec*/ void OnDestroy();

        class InformationExportData : NoaDebugger.IExportData
        {
            static string EXPORT_FILE_PREFIX = "information";
            /*0x10*/ NoaDebugger.DownloadInfo _downloadData;

            /*0x72c1758*/ InformationExportData();
            /*0x72c1c8c*/ NoaDebugger.DownloadInfo GetDownloadInfo();
        }

        class InformationMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x72c0620*/ InformationMenuInfo();
            /*0x72c1c94*/ string get_Name();
            /*0x72c1cd4*/ string get_MenuName();
            /*0x72c1d14*/ int get_SortNo();
        }
    }

    interface IMenuInfo
    {
        /*0x380b9e8*/ string get_Name();
        /*0x380b9e8*/ string get_MenuName();
        /*0x380b6a0*/ int get_SortNo();
    }

    enum ToolNotificationStatus
    {
        None = 0,
        Error = 1,
    }

    interface INoaDebuggerTool
    {
        /*0x380cb08*/ void Init();
        /*0x380b6a0*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x380b9e8*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x380d83c*/ void ShowView(UnityEngine.Transform parent);
        /*0x380cdf0*/ void AlignmentUI(bool isReverse);
        /*0x380cb08*/ void OnHidden();
        /*0x380cb08*/ void OnToolDispose();
    }

    interface INoaDebuggerOverlayTool
    {
        /*0x380b128*/ bool GetPinStatus();
        /*0x380d83c*/ void TogglePin(UnityEngine.Transform parent);
        /*0x380d83c*/ void InitOverlay(UnityEngine.Transform parent);
        /*0x380b128*/ bool GetSettingsStatus();
        /*0x380d83c*/ void ToggleOverlaySettings(UnityEngine.Transform parent);
    }

    interface INoaDebuggerFloatingTool
    {
        /*0x380b128*/ bool GetPinStatus();
        /*0x380d83c*/ void TogglePin(UnityEngine.Transform parent);
        /*0x380d83c*/ void InitFloatingWindow(UnityEngine.Transform parent);
    }

    class LogPresenterBase<TLogEntry, TLogDetail> : NoaDebugger.NoaDebuggerToolBase
    {
        /*0x0*/ System.Collections.Generic.LinkedList<TLogEntry> _logBuffer;
        /*0x0*/ NoaDebugger.LogViewBase _mainViewPrefab;
        /*0x0*/ NoaDebugger.LogViewBase _mainView;
        /*0x0*/ NoaDebugger.LogOverlayView _overlayPrefab;
        /*0x0*/ NoaDebugger.LogOverlaySettingsView _overlaySettingsPrefab;
        /*0x0*/ NoaDebugger.LogOverlayPresenter _overlayPresenter;
        /*0x0*/ NoaDebugger.DownloadDialog _dialogPrefab;
        /*0x0*/ NoaDebugger.DownloadDialogPresenter _downloadDialogPresenter;
        /*0x0*/ NoaDebugger.NoaDebuggerSettings _settings;
        /*0x0*/ System.Collections.Generic.Dictionary<NoaDebugger.LogType, int> _logCounts;
        /*0x0*/ int _selectLogIndex;
        /*0x0*/ System.Collections.Generic.List<NoaDebugger.LogViewLinker.LogPanelInfo> _panels;
        /*0x0*/ System.Collections.Generic.List<NoaDebugger.LogViewLinker.LogPanelInfo> _overlayPanels;
        /*0x0*/ NoaDebugger.LogViewLinker.LogPanelInfo[] _panelInstances;
        /*0x0*/ UnityEngine.Events.UnityAction<int> _onSelectLog;
        /*0x0*/ UnityEngine.Events.UnityAction<int> _onPointerDown;
        /*0x0*/ UnityEngine.Events.UnityAction _onLongTap;
        /*0x0*/ int _longTapStartLogIndex;
        /*0x0*/ System.Collections.Generic.Dictionary<NoaDebugger.LogType, bool> _showLogFlagDictionary;
        /*0x0*/ string _filterText;
        /*0x0*/ NoaDebugger.LogFilterRepository _filterRepository;
        /*0x0*/ NoaDebugger.LogCollectorModel _logModel;
        /*0x0*/ bool _scrollInitLock;
        /*0x0*/ bool _resetScroll;
        /*0x0*/ bool _hideLogDetailView;
        /*0x0*/ bool _isShow;
        /*0x0*/ bool _isSelectingModeValue;

        /*0x380cb08*/ LogPresenterBase();
        /*0x380b128*/ bool get_IsSelectingMode();
        /*0x380cdf0*/ void set_IsSelectingMode(bool value);
        /*0x380b9e8*/ NoaDebugger.LogCollectorModel CreateLogCollectorModel();
        /*0x380b6a0*/ int GetLogCapacity();
        /*0x3907c14*/ void SetLogPanelInfo(ref NoaDebugger.LogViewLinker.LogPanelInfo logPanelInfo, TLogEntry log);
        /*0x380b9e8*/ string GetStatusString();
        /*0x380cb08*/ void OnClearLog();
        /*0x3907c14*/ void OnLogCopied(TLogEntry log, string clipboardText);
        System.Nullable<bool> OnLogDownload(string fileName, string json);
        /*0x380b9e8*/ string GetExportFilenamePrefix();
        /*0x380cb08*/ void OnLogSend();
        /*0x380b128*/ bool IsRegisteredSend();
        /*0x380b9e8*/ string GetFilterSavePrefsKey();
        /*0x380b9e8*/ string GetOverlayPrefsKey();
        /*0x380b9e8*/ NoaDebugger.KeyValueSerializer CreateLogKeyValueSerializer();
        /*0x380cb08*/ void _Init();
        /*0x380cb08*/ void _UpdateView();
        /*0x380d83c*/ void _ShowView(UnityEngine.Transform parent);
        /*0x380d83c*/ void _InitView(NoaDebugger.LogViewBase view);
        /*0x380cb08*/ void _HideView();
        /*0x380cb08*/ void _DoUpdateView();
        /*0x380cffc*/ void _SetNotificationStatus(NoaDebugger.ToolNotificationStatus notifyStatus);
        /*0x380d93c*/ void _CreateLogViewInfos(ref int selectLogIndex, ref int selectingCount);
        /*0x380cdf0*/ void _AlignmentUI(bool isReverse);
        /*0x380cb08*/ void _OnRecord();
        /*0x380cb08*/ void _OnClearLogs();
        /*0x380cdf0*/ void OnSelectingMode(bool isSelecting);
        /*0x380cb08*/ void _OnSelectAll();
        /*0x380cb08*/ void _OnDeselectAll();
        /*0x380cb08*/ void _OnDownload();
        /*0x380cb08*/ void _OnLogSend();
        /*0x380d03c*/ void _OnSwitchByType(NoaDebugger.LogType logType, bool isOn);
        /*0x380d83c*/ void _OnChangeFilter(string text);
        /*0x380cffc*/ void _OnSelectLog(int index);
        /*0x380cffc*/ void _SaveLongTapStartLog(int index);
        /*0x380cb08*/ void _CopySavedLog();
        /*0x380d83c*/ void _CopyLog(NoaDebugger.ILogDetail logDetail);
        /*0x3907c14*/ TLogEntry _GetLog(int index);
        /*0x380d93c*/ void _OnExecDownload(string label, UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo> completed);
        /*0x380bb68*/ string _CreateExportJsonString(string label);
        /*0x380b9e8*/ NoaDebugger.LogOverlaySettingsDefaultGetter _CreateOverlaySettingsDefaultGetter();
        /*0x380b128*/ bool _GetPinStatus();
        /*0x380d83c*/ void _TogglePin(UnityEngine.Transform parent);
        /*0x380cb08*/ void _OnUpdateOverlaySettings();
        /*0x380d83c*/ void _OnInitOverlay(NoaDebugger.LogOverlayView overlay);
        /*0x380cb08*/ void _OnOverlayEnabled();
        /*0x380cb08*/ void _OnHidden();
        /*0x380cb08*/ void _OnDispose();
        /*0x380b9e8*/ System.Collections.Generic.LinkedList<TLogEntry> GetLogList();
        /*0x380cb08*/ void ClearLog();
        /*0x380cb08*/ void OnDestroy();

        class LogExportData<TLogEntry, TLogDetail> : NoaDebugger.IExportData
        {
            /*0x0*/ NoaDebugger.DownloadInfo _downloadData;

            /*0x380d83c*/ LogExportData(string exportFilenamePrefix);
            /*0x380b9e8*/ NoaDebugger.DownloadInfo GetDownloadInfo();
        }

        class <>c<TLogEntry, TLogDetail>
        {
            static /*0x0*/ NoaDebugger.LogPresenterBase.<>c<TLogEntry, TLogDetail> <>9;
            static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<NoaDebugger.LogType, bool>, bool> <>9__51_0;

            static /*0x38358cc*/ <>c();
            /*0x380cb08*/ <>c();
            bool <_CreateLogViewInfos>b__51_0(System.Collections.Generic.KeyValuePair<NoaDebugger.LogType, bool> kv);
        }
    }

    class LogOverlayPresenter : NoaDebugger.OverlayPresenterBase<NoaDebugger.LogOverlayView, NoaDebugger.LogOverlaySettingsView, NoaDebugger.LogOverlaySettings, NoaDebugger.LogOverlayViewLinker>
    {
        /*0x72c1d1c*/ LogOverlayPresenter(NoaDebugger.LogOverlayView overlayPrefab, NoaDebugger.LogOverlaySettingsView overlaySettingsPrefab, string prefsKeyPrefix, NoaDebugger.LogOverlaySettings overlayToolSettings);
    }

    class NoaDebuggerToolBase : UnityEngine.MonoBehaviour
    {
        /*0x72c02b4*/ NoaDebuggerToolBase();
    }

    class OverlayPresenterBase<TOverlayView, TOverlaySettingsView, TOverlayToolSettings, TViewLinker>
    {
        /*0x0*/ TOverlayView _overlayViewPrefab;
        /*0x0*/ TOverlayView _overlayView;
        /*0x0*/ UnityEngine.Transform _overlayViewRoot;
        /*0x0*/ TOverlaySettingsView _overlaySettingsViewPrefab;
        /*0x0*/ TOverlaySettingsView _overlaySettingsView;
        /*0x0*/ TOverlayToolSettings _overlayToolSettings;
        /*0x0*/ string _isOverlayEnablePrefsKey;
        /*0x0*/ bool _isOverlayEnable;
        /*0x0*/ bool _isOverlaySettingsEnable;
        /*0x0*/ bool _isNeedApplySettings;
        /*0x0*/ bool _cachedIsUIReverse;
        /*0x0*/ System.Action<TOverlayView> OnInitAction;
        /*0x0*/ System.Action OnUpdateSettings;

        /*0x3907c14*/ OverlayPresenterBase(TOverlayView overlayPrefab, TOverlaySettingsView overlaySettingsPrefab, string prefsKeyPrefix, TOverlayToolSettings overlayToolSettings);
        /*0x380d83c*/ void add_OnInitAction(System.Action<TOverlayView> value);
        /*0x380d83c*/ void remove_OnInitAction(System.Action<TOverlayView> value);
        /*0x380d83c*/ void add_OnUpdateSettings(System.Action value);
        /*0x380d83c*/ void remove_OnUpdateSettings(System.Action value);
        /*0x380b128*/ bool get_IsOverlayEnable();
        /*0x380cdf0*/ void set_IsOverlayEnable(bool value);
        /*0x380b128*/ bool get_IsShowOverlay();
        /*0x380b128*/ bool get_IsOverlaySettingsEnable();
        /*0x380d83c*/ void InstantiateOverlay(UnityEngine.Transform parent);
        /*0x3907c14*/ void ShowOverlayView(TViewLinker linker);
        /*0x380cb08*/ void _DestroyOverlay();
        /*0x380d83c*/ void ToggleActiveOverlayView(UnityEngine.Transform parent);
        /*0x380cdf0*/ void _OnOverlayRootActiveChanged(bool active);
        /*0x380d83c*/ void _InstantiateOverlaySettings(UnityEngine.Transform parent);
        /*0x380cb08*/ void DestroyOverlaySettings();
        /*0x380d93c*/ void ToggleActiveOverlaySettingsView(UnityEngine.GameObject mainViewObj, UnityEngine.Transform parent);
        /*0x380cb08*/ void _OnUpdateSettings();
        /*0x380cdf0*/ void AlignmentUI(bool isReverse);
    }

    class ProfilerPresenter : NoaDebugger.NoaDebuggerToolBase, NoaDebugger.INoaDebuggerTool, NoaDebugger.INoaDebuggerOverlayTool
    {
        /*0x20*/ NoaDebugger.ProfilerView _mainViewPrefab;
        /*0x28*/ NoaDebugger.ProfilerView _mainView;
        /*0x30*/ NoaDebugger.ProfilerOverlayView _overlayPrefab;
        /*0x38*/ NoaDebugger.ProfilerOverlaySettingsView _overlaySettingsPrefab;
        /*0x40*/ NoaDebugger.ProfilerOverlayPresenter _overlayPresenter;
        /*0x48*/ System.Func<bool> _onGcCollect;
        /*0x50*/ System.Func<bool> _onUnloadAsset;
        /*0x58*/ NoaDebugger.ProfilerPresenter.ProfilerMenuInfo _profilerMenuInfo;
        /*0x60*/ NoaDebugger.FpsModel <FpsModel>k__BackingField;
        /*0x68*/ NoaDebugger.FrameTimeModel <FrameTimeModel>k__BackingField;
        /*0x70*/ NoaDebugger.TargetFrameRateModel <TargetFrameRateModel>k__BackingField;
        /*0x78*/ NoaDebugger.MemoryModel <MemoryModel>k__BackingField;
        /*0x80*/ NoaDebugger.RenderingModel <RenderingModel>k__BackingField;
        /*0x88*/ NoaDebugger.BatteryModel <BatteryModel>k__BackingField;
        /*0x90*/ NoaDebugger.ThermalModel <ThermalModel>k__BackingField;

        static /*0x72c2c08*/ NoaDebugger.FpsUnchangingInfo CreateFpsViewInfo(NoaDebugger.FpsInfo info);
        static /*0x72c2c64*/ NoaDebugger.ProfilerFrameTimeViewInformation CreateFrameTimeInfo(NoaDebugger.FrameTimeInfo info);
        static /*0x72c2ce8*/ NoaDebugger.MemoryUnchangingInfo CreateMemoryViewInfo(NoaDebugger.MemoryInfo info);
        static /*0x72c2d44*/ NoaDebugger.RenderingUnchangingInfo CreateRenderingViewInfo(NoaDebugger.RenderingInfo info);
        static /*0x72c314c*/ NoaDebugger.BatteryUnchangingInfo CreateBatteryViewInfo(NoaDebugger.BatteryInfo info);
        static /*0x72c31a8*/ NoaDebugger.ThermalUnchangingInfo CreateThermalViewInfo(NoaDebugger.ThermalInfo info);
        /*0x72c3ac4*/ ProfilerPresenter();
        /*0x72c1d94*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x72c1d9c*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x72c1e14*/ NoaDebugger.FpsModel get_FpsModel();
        /*0x72c1e1c*/ void set_FpsModel(NoaDebugger.FpsModel value);
        /*0x72c1e24*/ NoaDebugger.FrameTimeModel get_FrameTimeModel();
        /*0x72c1e2c*/ void set_FrameTimeModel(NoaDebugger.FrameTimeModel value);
        /*0x72c1e34*/ NoaDebugger.TargetFrameRateModel get_TargetFrameRateModel();
        /*0x72c1e3c*/ void set_TargetFrameRateModel(NoaDebugger.TargetFrameRateModel value);
        /*0x72c1e44*/ NoaDebugger.MemoryModel get_MemoryModel();
        /*0x72c1e4c*/ void set_MemoryModel(NoaDebugger.MemoryModel value);
        /*0x72c1e54*/ NoaDebugger.RenderingModel get_RenderingModel();
        /*0x72c1e5c*/ void set_RenderingModel(NoaDebugger.RenderingModel value);
        /*0x72c1e64*/ NoaDebugger.BatteryModel get_BatteryModel();
        /*0x72c1e6c*/ void set_BatteryModel(NoaDebugger.BatteryModel value);
        /*0x72c1e74*/ NoaDebugger.ThermalModel get_ThermalModel();
        /*0x72c1e7c*/ void set_ThermalModel(NoaDebugger.ThermalModel value);
        /*0x72c1e84*/ void Init();
        /*0x72c233c*/ void ShowView(UnityEngine.Transform parent);
        /*0x72c245c*/ void _InitView(NoaDebugger.ProfilerView view);
        /*0x72c291c*/ void AlignmentUI(bool isReverse);
        /*0x72c2990*/ bool GetPinStatus();
        /*0x72c29d8*/ void TogglePin(UnityEngine.Transform parent);
        /*0x72c2a30*/ void InitOverlay(UnityEngine.Transform parent);
        /*0x72c2ab0*/ bool GetSettingsStatus();
        /*0x72c2af8*/ void ToggleOverlaySettings(UnityEngine.Transform parent);
        /*0x72c2b68*/ void _OnUpdateOverlaySettings();
        /*0x72c2b6c*/ void _OnInitOverlay(NoaDebugger.ProfilerOverlayView overlay);
        /*0x72c2c04*/ void _OnOverlayEnabled();
        /*0x72c2818*/ void _UpdateAllView();
        /*0x72c2da0*/ void _UpdateViewFromViewData(NoaDebugger.ProfilerViewLinker viewData);
        /*0x72c2f2c*/ void _UpdateFpsView();
        /*0x72c2fb4*/ void _UpdateFrameTimeView();
        /*0x72c303c*/ void _UpdateMemoryView();
        /*0x72c30c4*/ void _UpdateRenderingView();
        /*0x72c3204*/ void _OnFpsProfilingStateChanged(bool isProfiling);
        /*0x72c3250*/ void _OnFrameTimeProfilingStateChanged(bool isProfiling);
        /*0x72c3280*/ void _OnVSyncCountChanged(int vSyncCount);
        /*0x72c328c*/ void _OnMemoryProfilingStateChanged(bool isProfiling);
        /*0x72c32bc*/ void _OnMemoryGraphShowingStateChanged(bool isShowing);
        /*0x72c32e4*/ void _OnMemoryProfilingTypeChanged(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
        /*0x72c3308*/ void _OnGcCollectExecuted();
        /*0x72c3320*/ System.Collections.IEnumerator _ExecuteGcCollect();
        /*0x72c33b4*/ void _OnUnloadAssetExecuted();
        /*0x72c33cc*/ System.Collections.IEnumerator _ExecuteUnloadUnusedAssets();
        /*0x72c3460*/ void _OnRenderingProfilingStateChanged(bool isProfiling);
        /*0x72c3490*/ void _OnRenderingGraphShowingStateChanged(bool isShowing);
        /*0x72c34b8*/ void _OnRenderingGraphSelected(NoaDebugger.RenderingGraphTarget target);
        /*0x72c34f8*/ void _OnHidden();
        /*0x72c35b0*/ void OnHidden();
        /*0x72c35b4*/ void OnToolDispose();
        /*0x72c36d8*/ NoaDebugger.ProfilerSnapshotData CaptureSnapshot();
        /*0x72c3734*/ NoaDebugger.FpsInfo GetFpsInfo();
        /*0x72c3750*/ bool IsFpsProfiling();
        /*0x72c320c*/ void ChangeFpsProfiling(bool isProfiling);
        /*0x72c3258*/ void ChangeFrameTimeProfiling(bool isProfiling);
        /*0x72c3774*/ NoaDebugger.MemoryInfo GetMemoryInfo();
        /*0x72c3790*/ bool IsMemoryProfiling();
        /*0x72c3294*/ void ChangeMemoryProfiling(bool isProfiling);
        /*0x72c37b4*/ void ChangeMemoryProfilingType(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
        /*0x72c37d8*/ float GetTotalNativeMemoryMB();
        /*0x72c37fc*/ void SetTotalNativeMemoryMB(float totalMemoryMB);
        /*0x72c3820*/ NoaDebugger.RenderingInfo GetRenderingInfo();
        /*0x72c383c*/ bool IsRenderingProfiling();
        /*0x72c3468*/ void ChangeRenderingProfiling(bool isProfiling);
        /*0x72c3860*/ NoaDebugger.BatteryInfo GetBatteryInfo();
        /*0x72c387c*/ bool IsBatteryProfiling();
        /*0x72c38f8*/ void ChangeBatteryProfiling(bool isProfiling);
        /*0x72c3914*/ NoaDebugger.ThermalInfo GetThermalInfo();
        /*0x72c3930*/ bool IsThermalProfiling();
        /*0x72c39b0*/ void ChangeThermalProfiling(bool isProfiling);
        /*0x72c39cc*/ void OnDestroy();

        class ProfilerMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x72c1e0c*/ ProfilerMenuInfo();
            /*0x72c3acc*/ string get_Name();
            /*0x72c3b0c*/ string get_MenuName();
            /*0x72c3b4c*/ int get_SortNo();
        }

        class <_ExecuteGcCollect>d__71 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.ProfilerPresenter <>4__this;

            /*0x72c338c*/ <_ExecuteGcCollect>d__71(int <>1__state);
            /*0x72c3b54*/ void System.IDisposable.Dispose();
            /*0x72c3b58*/ bool MoveNext();
            /*0x72c3cb4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72c3cbc*/ void System.Collections.IEnumerator.Reset();
            /*0x72c3cf4*/ object System.Collections.IEnumerator.get_Current();
        }

        class <_ExecuteUnloadUnusedAssets>d__73 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.ProfilerPresenter <>4__this;
            /*0x28*/ UnityEngine.AsyncOperation <asyncOp>5__2;

            /*0x72c3438*/ <_ExecuteUnloadUnusedAssets>d__73(int <>1__state);
            /*0x72c3cfc*/ void System.IDisposable.Dispose();
            /*0x72c3d00*/ bool MoveNext();
            /*0x72c3e78*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72c3e80*/ void System.Collections.IEnumerator.Reset();
            /*0x72c3eb8*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class ProfilerOverlayPresenter : NoaDebugger.OverlayPresenterBase<NoaDebugger.ProfilerOverlayView, NoaDebugger.ProfilerOverlaySettingsView, NoaDebugger.ProfilerOverlaySettings, NoaDebugger.ProfilerViewLinker>
    {
        /*0x72c22c8*/ ProfilerOverlayPresenter(NoaDebugger.ProfilerOverlayView overlayPrefab, NoaDebugger.ProfilerOverlaySettingsView overlaySettingsPrefab, string prefsKeyPrefix);
    }

    class SnapshotPresenter : NoaDebugger.NoaDebuggerToolBase, NoaDebugger.INoaDebuggerTool
    {
        /*0x20*/ NoaDebugger.SnapshotView _mainViewPrefab;
        /*0x28*/ NoaDebugger.SnapshotView _mainView;
        /*0x30*/ NoaDebugger.DownloadDialog _dialogPrefab;
        /*0x38*/ NoaDebugger.DownloadDialogPresenter _downloadDialogPresenter;
        /*0x40*/ UnityEngine.Events.UnityAction<NoaDebugger.SnapshotLogRecordInformation, string> _onLogCopied;
        /*0x48*/ System.Func<string, string, bool> _onLogDownload;
        /*0x50*/ NoaDebugger.SnapshotModel <Model>k__BackingField;
        /*0x58*/ NoaDebugger.SnapshotPresenter.SnapshotMenuInfo _snapshotMenuInfo;

        static /*0x72c5f84*/ string ConvertCategoryName(string categoryName, bool isDownload);
        static /*0x72c5d50*/ string TimeSpanToHourTimeFormatString(System.TimeSpan time);
        /*0x72c61a4*/ SnapshotPresenter();
        /*0x72c3ec0*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x72c3ec8*/ NoaDebugger.SnapshotModel get_Model();
        /*0x72c3ed0*/ void set_Model(NoaDebugger.SnapshotModel value);
        /*0x72c3ed8*/ void Init();
        /*0x72c3fa0*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x72c4010*/ void ShowView(UnityEngine.Transform parent);
        /*0x72c4104*/ void _InitView(NoaDebugger.SnapshotView view);
        /*0x72c4460*/ void AlignmentUI(bool isReverse);
        /*0x72c43c4*/ void _UpdateView();
        /*0x72c45fc*/ void _UpdateByLinker(NoaDebugger.SnapshotViewLinker linker, bool onUpdate);
        /*0x72c46c8*/ void OnHidden();
        /*0x72c4794*/ void OnToolDispose();
        /*0x72c47ec*/ void ClearLogsAndTimer();
        /*0x72c482c*/ void CaptureLog(string label, System.Nullable<UnityEngine.Color> backgroundColor, bool hasNoaProfilerInfo, System.Collections.Generic.Dictionary<string, NoaDebugger.NoaSnapshotCategory> additionalInfo, bool updateProfilingElapsedTime);
        /*0x72c46f8*/ void _DestroyView();
        /*0x72c4564*/ void _OnActiveChanged();
        /*0x72c4484*/ void _SetViewLinkerFromTime(NoaDebugger.SnapshotViewLinker linker);
        /*0x72c4504*/ void _SetViewLinkerFromLogData(NoaDebugger.SnapshotViewLinker linker);
        /*0x72c4538*/ void _SetViewLinkerFromComparison(NoaDebugger.SnapshotViewLinker linker);
        /*0x72c4930*/ void _OnInsertLog();
        /*0x72c4a8c*/ void _OnToggleChanged(int id);
        /*0x72c4b28*/ void _OnClearAllLog();
        /*0x72c4b40*/ void _OnClickLog(int id);
        /*0x72c4b80*/ void _OnCopyLog(int id);
        /*0x72c4ab0*/ void _ReloadLogScroll();
        /*0x72c57c4*/ void _UpdateFromTime();
        /*0x72c5830*/ void _OnDownloadLog();
        /*0x72c5920*/ void _OnComparison();
        /*0x72c5958*/ void _OnExecDownload(string label, UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo> completed);
        /*0x72c5a60*/ string _CreateExportJsonString(string label);
        /*0x72c5b20*/ NoaDebugger.KeyValueSerializer _CreateSnapshotExportData();
        /*0x72c4d94*/ NoaDebugger.IKeyValueParser[] _CreateSnapshotLogExportData(NoaDebugger.SnapshotLogRecordInformation log);
        /*0x72c60f8*/ System.Collections.Generic.List<NoaDebugger.SnapshotLogRecordInformation> GetLogList();
        /*0x72c611c*/ void OnDestroy();

        class SnapshotExportData : NoaDebugger.IExportData
        {
            static string EXPORT_FILE_PREFIX = "snapshot";
            /*0x10*/ NoaDebugger.SnapshotModel.SnapshotInformation _snapshotInfo;
            /*0x18*/ NoaDebugger.DownloadInfo _downloadData;

            /*0x72c6dc8*/ SnapshotExportData();
            /*0x72c6dc0*/ NoaDebugger.DownloadInfo GetDownloadInfo();
        }

        class SnapshotMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x72c6f1c*/ SnapshotMenuInfo();
            /*0x72c6e94*/ string get_Name();
            /*0x72c6ed4*/ string get_MenuName();
            /*0x72c6f14*/ int get_SortNo();
        }

        class <>c__DisplayClass35_0
        {
            /*0x10*/ int id;

            /*0x72c6f24*/ <>c__DisplayClass35_0();
            /*0x72c6f2c*/ bool <_OnCopyLog>b__0(NoaDebugger.SnapshotLogRecordInformation log);
        }
    }

    class ToolDetailPresenter : NoaDebugger.NoaDebuggerToolBase, NoaDebugger.INoaDebuggerTool
    {
        /*0x20*/ NoaDebugger.ToolDetailView _mainViewPrefab;
        /*0x28*/ NoaDebugger.ToolDetailView _mainView;
        /*0x30*/ NoaDebugger.ToolDetailModel _model;
        /*0x38*/ bool _isDeviceOrientationChanged;
        /*0x40*/ NoaDebugger.ToolDetailPresenter.ToolDetailMenuInfo _toolDetailMenuInfo;

        /*0x72c73f8*/ ToolDetailPresenter();
        /*0x72c6f50*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x72c6f58*/ void Init();
        /*0x72c6fb8*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x72c7030*/ void ShowView(UnityEngine.Transform parent);
        /*0x72c7200*/ NoaDebugger.ToolDetailViewLinker get_Linker();
        /*0x72c7158*/ void _UpdateAllView();
        /*0x72c72a0*/ void AlignmentUI(bool isReverse);
        /*0x72c72c4*/ void _OnHidden();
        /*0x72c735c*/ void OnHidden();
        /*0x72c7360*/ void OnToolDispose();
        /*0x72c73b0*/ void OnDestroy();

        class ToolDetailMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x72c7028*/ ToolDetailMenuInfo();
            /*0x72c7400*/ string get_Name();
            /*0x72c7440*/ string get_MenuName();
            /*0x72c7480*/ int get_SortNo();
        }
    }

    class AssemblyUtils
    {
        static /*0x382dee4*/ System.Type[] GetInterfaces<T>();
        static /*0x382dee4*/ T[] CreateInterfaceInstances<T>();

        class <>c__0<T>
        {
            static /*0x0*/ NoaDebugger.AssemblyUtils.<>c__0<T> <>9;
            static /*0x0*/ System.Func<System.Type, bool> <>9__0_1;
            static /*0x0*/ System.Func<System.Type, bool> <>9__0_0;

            static /*0x38358cc*/ <>c__0();
            /*0x380cb08*/ <>c__0();
            /*0x380b2f0*/ bool <GetInterfaces>b__0_0(System.Type c);
            /*0x380b2f0*/ bool <GetInterfaces>b__0_1(System.Type t);
        }

        class <>c__<T>
        {
            static /*0x0*/ NoaDebugger.AssemblyUtils.<>c__1<T> <>9;
            static /*0x0*/ System.Func<System.Type, T> <>9__1_0;

            static /*0x38358cc*/ <>c__();
            /*0x380cb08*/ <>c__();
            /*0x3907c14*/ T <CreateInterfaceInstances>b__1_0(System.Type c);
        }
    }

    class AutoRefreshSwitcher
    {
        static /*0x0*/ string OnUpdatePrefix;
        /*0x10*/ string _onUpdateKey;
        /*0x18*/ bool <IsAutoRefresh>k__BackingField;
        /*0x1c*/ float _autoRefreshTimer;
        /*0x20*/ UnityEngine.Events.UnityAction _onUpdate;
        /*0x28*/ string _prefsKey;
        /*0x30*/ float _refreshInterval;

        static /*0x72c7978*/ AutoRefreshSwitcher();
        /*0x72c749c*/ AutoRefreshSwitcher(UnityEngine.Events.UnityAction onUpdate, string prefsKey, float refreshInterval);
        /*0x72c7488*/ bool get_IsAutoRefresh();
        /*0x72c7490*/ void set_IsAutoRefresh(bool value);
        /*0x72c7684*/ void UpdateAutoRefresh(bool isAutoRefresh);
        /*0x72c75d4*/ void _HandleOnUpdate(bool isAutoRefresh);
        /*0x72c7924*/ void _OnUpdate();
    }

    class AxisSwitchableLayoutGroup : UnityEngine.UI.HorizontalOrVerticalLayoutGroup
    {
        /*0x6c*/ NoaDebugger.AxisSwitchableLayoutGroup.AxisType <Axis>k__BackingField;

        /*0x72c7ac0*/ AxisSwitchableLayoutGroup();
        /*0x72c79e4*/ NoaDebugger.AxisSwitchableLayoutGroup.AxisType get_Axis();
        /*0x72c79ec*/ void set_Axis(NoaDebugger.AxisSwitchableLayoutGroup.AxisType value);
        /*0x72c79f4*/ void CalculateLayoutInputHorizontal();
        /*0x72c7a3c*/ void CalculateLayoutInputVertical();
        /*0x72c7a68*/ void SetLayoutHorizontal();
        /*0x72c7a94*/ void SetLayoutVertical();

        enum AxisType
        {
            Horizontal = 0,
            Vertical = 1,
        }
    }

    class ContentPanelPool
    {
        /*0x10*/ UnityEngine.GameObject _prefab;
        /*0x18*/ UnityEngine.Transform _contentRoot;
        /*0x20*/ System.Collections.Generic.List<UnityEngine.GameObject> _cacheList;

        /*0x72c7ad0*/ ContentPanelPool(UnityEngine.GameObject prefab, UnityEngine.Transform contentRoot);
        /*0x72c7b88*/ System.ValueTuple<UnityEngine.GameObject, int> GetObjectAndIndex();
        /*0x72c7c64*/ System.ValueTuple<UnityEngine.GameObject, int> _GetGameObjectAndIndex();
        /*0x72c7e34*/ void ReturnObject(int index);
    }

    class ContentSizeFitterByChildren : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.RectTransform _rect;

        /*0x72c839c*/ ContentSizeFitterByChildren();
        /*0x72c7e9c*/ void Start();
        /*0x72c7f2c*/ void _WidthFitterByChildren();
        /*0x72c8050*/ UnityEngine.Vector3 _GetRightmostWorldPosition(UnityEngine.RectTransform rect, UnityEngine.Vector3 rightmostWorldPosition);
    }

    class DeviceOrientationStretch : UnityEngine.MonoBehaviour
    {
        static string KEY = "DeviceOrientationStretch";
        /*0x20*/ UnityEngine.Vector2 _landscapeOffsetMin;
        /*0x28*/ UnityEngine.Vector2 _landscapeOffsetMax;
        /*0x30*/ UnityEngine.Vector2 _portraitOffsetMin;
        /*0x38*/ UnityEngine.Vector2 _portraitOffsetMax;
        /*0x40*/ UnityEngine.RectTransform _rectTransform;
        /*0x48*/ string _key;

        /*0x72c89fc*/ DeviceOrientationStretch();
        /*0x72c83a4*/ void Awake();
        /*0x72c8760*/ void _OnChangeDeviceOrientation(bool isPortrait);
        /*0x72c8838*/ void CopyToLandscapeOffset();
        /*0x72c88ac*/ void CopyToPortraitOffset();
        /*0x72c8920*/ void OnDestroy();
    }

    class EndOfUpdateListener : UnityEngine.MonoBehaviour
    {
        /*0x20*/ System.Action OnLateUpdate;

        /*0x72c8b58*/ EndOfUpdateListener();
        /*0x72c8a04*/ void add_OnLateUpdate(System.Action value);
        /*0x72c8aa0*/ void remove_OnLateUpdate(System.Action value);
        /*0x72c8b3c*/ void LateUpdate();
    }

    class InputTextAutoScroller : NoaDebugger.TextAutoScroller
    {
        /*0x40*/ NoaDebugger.NoaDebuggerScrollableInputComponent _inputComponent;

        /*0x72c9010*/ InputTextAutoScroller();
        /*0x72c8b60*/ void _OnInitialize();
        /*0x72c8d44*/ void SetText(string text);
        /*0x72c8e94*/ void _OnSelect(string text);
        /*0x72c8ec4*/ void _OnEndEdit(string text);
        /*0x72c8d90*/ void _SetTextAlpha(bool isInputMode);
        /*0x72c8f34*/ void SetOnSelect(UnityEngine.Events.UnityAction<string> action);
        /*0x72c8f94*/ void SetOnEndEdit(UnityEngine.Events.UnityAction<string> action);
        /*0x72c8ff4*/ void SetCharacterLimit(int num);
    }

    class NestedScrollRect : UnityEngine.UI.ScrollRect
    {
        /*0x130*/ bool _routeToParent;

        static /*0x383af28*/ void DoParentEventSystemHandler<T>(UnityEngine.Transform transform, System.Action<T> action);
        /*0x72c9590*/ NestedScrollRect();
        /*0x72c9070*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72c9184*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72c92a4*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72c9470*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);

        class <>c__DisplayClass1_0
        {
            /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x72c917c*/ <>c__DisplayClass1_0();
            /*0x72c9598*/ void <OnInitializePotentialDrag>b__0(UnityEngine.EventSystems.IInitializePotentialDragHandler parent);
        }

        class <>c__DisplayClass2_0
        {
            /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x72c929c*/ <>c__DisplayClass2_0();
            /*0x72c9640*/ void <OnDrag>b__0(UnityEngine.EventSystems.IDragHandler parent);
        }

        class <>c__DisplayClass3_0
        {
            /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x72c9468*/ <>c__DisplayClass3_0();
            /*0x72c96e8*/ void <OnBeginDrag>b__0(UnityEngine.EventSystems.IBeginDragHandler parent);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x72c9588*/ <>c__DisplayClass4_0();
            /*0x72c9790*/ void <OnEndDrag>b__0(UnityEngine.EventSystems.IEndDragHandler parent);
        }
    }

    class NoaDebuggerButtonVisualController : UnityEngine.MonoBehaviour
    {
        /*0x20*/ bool _isInitialized;
        /*0x28*/ NoaDebugger.NoaDebuggerSettings _noaDebuggerSettings;
        /*0x30*/ bool _isPlayingAnimation;
        /*0x38*/ System.ValueTuple<float, float> _alertAnimationParameters;
        /*0x40*/ NoaDebugger.NoaDebuggerButtonVisualController.ButtonType _buttonType;
        /*0x48*/ UnityEngine.UI.Image _bootButtonBackgroundImage;
        /*0x50*/ UnityEngine.CanvasGroup _bootButtonCanvasGroup;

        /*0x72ca354*/ NoaDebuggerButtonVisualController();
        /*0x72c9838*/ System.ValueTuple<float, float> get_CachedAlertAnimationParameters();
        /*0x72c99a4*/ bool get_IsPlayingAnimation();
        /*0x72c99ac*/ void Init();
        /*0x72c9a3c*/ void ResetButtonColor();
        /*0x72c9d70*/ void PlayOnErrorAnimation(System.Func<bool> breakCondition);
        /*0x72ca0ac*/ void PlayOnLocationAnimation(System.Func<bool> breakCondition);
        /*0x72ca2e8*/ void SetCanvasGroupAlpha(float alpha);
        /*0x72c9a1c*/ void _SetCanvasGroupEnabled(bool isEnabled);
        /*0x72c9f34*/ bool _IsActive();
        /*0x72c9ff4*/ System.Collections.IEnumerator _CanvasGroupAlphaAnimation(System.ValueTuple<float, float> parameters, System.Func<bool> breakCondition, System.Action onFinish);
        /*0x72c9fa0*/ void _SetActive(bool isActive, bool onError);
        /*0x72ca32c*/ void Dispose();
        /*0x72ca35c*/ void <PlayOnErrorAnimation>b__14_0();
        /*0x72ca374*/ void <PlayOnLocationAnimation>b__15_0();

        enum ButtonType
        {
            InScene = 0,
            InController = 1,
        }

        class <_CanvasGroupAlphaAnimation>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.NoaDebuggerButtonVisualController <>4__this;
            /*0x28*/ System.ValueTuple<float, float> parameters;
            /*0x30*/ System.Func<bool> breakCondition;
            /*0x38*/ System.Action onFinish;
            /*0x40*/ float <animationStartTime>5__2;
            /*0x44*/ float <totalElapsedTime>5__3;
            /*0x48*/ float <totalPhaseTime>5__4;
            /*0x50*/ System.ValueTuple<float, float> <>7__wrap4;
            /*0x58*/ int <>7__wrap5;
            /*0x5c*/ float <phaseTime>5__7;
            /*0x60*/ float <phaseTargetAlpha>5__8;
            /*0x64*/ float <phaseStartAlpha>5__9;
            /*0x68*/ float <totalPhaseTimeBefore>5__10;

            /*0x72ca304*/ <_CanvasGroupAlphaAnimation>d__19(int <>1__state);
            /*0x72ca38c*/ void System.IDisposable.Dispose();
            /*0x72ca390*/ bool MoveNext();
            /*0x72ca584*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72ca58c*/ void System.Collections.IEnumerator.Reset();
            /*0x72ca5c4*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class NoaDebuggerText : TMPro.TextMeshProUGUI
    {
        static /*0x0*/ TMPro.TMP_FontAsset _runtimeDefaultFontAsset;
        static /*0x8*/ UnityEngine.Material _runtimeDefaultFontMaterial;
        static /*0x10*/ float _runtimeDefaultFontSizeRate;
        static /*0x18*/ TMPro.TMP_FontAsset _fontAsset;
        static /*0x20*/ UnityEngine.Material _fontMaterial;
        static /*0x28*/ float _fontSizeRate;
        static /*0x2c*/ bool _isInit;
        /*0x7c0*/ bool _isApplied;
        /*0x7c4*/ System.Nullable<float> _defaultFontSize;
        /*0x7cc*/ System.Nullable<float> _defaultFontSizeMin;
        /*0x7d4*/ System.Nullable<float> _defaultFontSizeMax;

        static /*0x72ca5cc*/ void Init(NoaDebugger.NoaDebuggerSettings settings);
        static /*0x72ca67c*/ void ChangeFont(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material fontMaterial, float fontSizeRate);
        static /*0x72ca708*/ void ResetFont();
        static /*0x72ca754*/ bool get_HasFontAsset();
        static /*0x72ca7cc*/ string GetHasFontAssetString(TMPro.TMP_FontAsset targetFont, string text);
        static /*0x72caa38*/ string _DecodeUnicodeEscapedString(string input);
        static /*0x72cab64*/ string _GetUnicodeEscapeSequence(char character);
        /*0x72caf78*/ NoaDebuggerText();
        /*0x72cabdc*/ string get_text();
        /*0x72cabe4*/ void set_text(string value);
        /*0x72caf58*/ void Awake();
        /*0x72cac1c*/ void ApplyFont(bool isForce);
        /*0x72caef8*/ string _TruncateToMaxLength(string text);

        class <>c
        {
            static /*0x0*/ NoaDebugger.NoaDebuggerText.<> <>9;
            static /*0x8*/ System.Text.RegularExpressions.MatchEvaluator <>9__13_0;

            static /*0x72cafd0*/ <>c();
            /*0x72cb038*/ <>c();
            /*0x72cb040*/ string <_DecodeUnicodeEscapedString>b__13_0(System.Text.RegularExpressions.Match match);
        }
    }

    class ObjectPoolScroll : UnityEngine.UI.ScrollRect
    {
        static string SHOW_PANEL_NAME = "Panel";
        static string HIDE_PANEL_NAME = "Panel(Reserved)";
        /*0x130*/ UnityEngine.GameObject _panelPrefab;
        /*0x138*/ float _panelSpace;
        /*0x13c*/ float _leftPadding;
        /*0x140*/ float _rightPadding;
        /*0x144*/ float _topPadding;
        /*0x148*/ float _bottomPadding;
        /*0x14c*/ int _panelNum;
        /*0x150*/ System.Collections.Generic.Dictionary<int, NoaDebugger.ObjectPoolScroll.PanelData> _showingPanels;
        /*0x158*/ System.Collections.Generic.List<NoaDebugger.ObjectPoolScroll.PanelData> _reservedPanels;
        /*0x160*/ UnityEngine.Vector2 _panelSize;
        /*0x168*/ bool _isInit;
        /*0x169*/ bool _isOnEnable;
        /*0x16c*/ int _showTopIndex;
        /*0x170*/ int _showBottomIndex;
        /*0x178*/ UnityEngine.Events.UnityAction<int, UnityEngine.GameObject> _refreshPanel;
        /*0x180*/ UnityEngine.Events.UnityAction <OnScrolled>k__BackingField;

        /*0x72cc0a8*/ ObjectPoolScroll();
        /*0x72cb100*/ System.Collections.Generic.Dictionary<int, NoaDebugger.ObjectPoolScroll.PanelData> get_ShowingPanels();
        /*0x72cb17c*/ int get_VisiblePanelCountY();
        /*0x72cb210*/ bool get_IsShowBottomPanel();
        /*0x72cb228*/ UnityEngine.Events.UnityAction get_OnScrolled();
        /*0x72cb230*/ void set_OnScrolled(UnityEngine.Events.UnityAction value);
        /*0x72cb240*/ void Init(int panelNum, UnityEngine.Events.UnityAction<int, UnityEngine.GameObject> refreshPanel);
        /*0x72cb86c*/ void OnEnable();
        /*0x72cb88c*/ void LateUpdate();
        /*0x72cb8c4*/ void RefreshPanels();
        /*0x72cbbdc*/ void OverwriteContentWidth(float width, bool isPadding);
        /*0x72cb364*/ void _RefreshContent();
        /*0x72cb6ac*/ void _ShowPanelsWithinScrollRange(UnityEngine.Vector2 normalizedPos);
        /*0x72cbcd4*/ void _ShowPanel(int index);
        /*0x72cbe24*/ void _HidePanel(int index);
        /*0x72cbc74*/ void _PanelStretch(UnityEngine.RectTransform panelRect);
        /*0x72cb8cc*/ void _RefreshPanels(bool forceRefresh);
        /*0x72cb490*/ void _ResetPanels();

        class PanelData
        {
            /*0x10*/ UnityEngine.GameObject _gameObject;
            /*0x18*/ UnityEngine.CanvasGroup _canvasGroup;

            static /*0x72cbf94*/ NoaDebugger.ObjectPoolScroll.PanelData Instantiate(UnityEngine.GameObject prefab, UnityEngine.Transform content);
            /*0x72cc184*/ PanelData(UnityEngine.GameObject gameObject);
            /*0x72cc058*/ void SetActive(bool isActive);
        }
    }

    class OrientationAwareLayoutGroup : UnityEngine.UI.HorizontalOrVerticalLayoutGroup
    {
        /*0x6c*/ NoaDebugger.OrientationAwareLayoutGroup.LayoutType _portraitLayoutType;
        /*0x70*/ NoaDebugger.OrientationAwareLayoutGroup.LayoutType _landscapeLayoutType;
        /*0x74*/ bool _isPortrait;

        /*0x72cc400*/ OrientationAwareLayoutGroup();
        /*0x72cc27c*/ bool get_IsPortrait();
        /*0x72cc298*/ void CalculateLayoutInputHorizontal();
        /*0x72cc2f8*/ void CalculateLayoutInputVertical();
        /*0x72cc350*/ void SetLayoutHorizontal();
        /*0x72cc3a8*/ void SetLayoutVertical();

        enum LayoutType
        {
            Horizontal = 0,
            Vertical = 1,
        }
    }

    class OrientationLayoutRuntimeAdjuster : NoaDebugger.UIBehaviourComponent
    {
        static /*0x0*/ float SPACING_MIN;
        /*0x28*/ System.Collections.Generic.List<NoaDebugger.OrientationLayoutStyle> _layoutStyleList;
        /*0x30*/ NoaDebugger.OrientationLayoutStyle _layoutStyleFirst;
        /*0x38*/ NoaDebugger.OrientationLayoutStyle _layoutStyleSecond;
        /*0x40*/ NoaDebugger.OrientationLayoutRuntimeAdjusterHandle _handlePrefab;
        /*0x48*/ float _minWidthRatio;
        /*0x4c*/ float _minHeightRatio;
        /*0x50*/ UnityEngine.UI.HorizontalOrVerticalLayoutGroup _layoutGroup;
        /*0x58*/ UnityEngine.RectTransform _layoutGroupRect;

        static /*0x72cd198*/ OrientationLayoutRuntimeAdjuster();
        /*0x72cd178*/ OrientationLayoutRuntimeAdjuster();
        /*0x72cc408*/ void _OnValidateUI();
        /*0x72cc534*/ void Awake();
        /*0x72cc89c*/ void OnRectTransformDimensionsChange();
        /*0x72ccae4*/ void _OnEndDragHandle();
        /*0x72ccda0*/ void SetHandleTargetLayouts();

        class <>c
        {
            static /*0x0*/ NoaDebugger.OrientationLayoutRuntimeAdjuster.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.OrientationLayoutStyle, bool> <>9__13_0;

            static /*0x72cd1e4*/ <>c();
            /*0x72cd24c*/ <>c();
            /*0x72cd254*/ bool <SetHandleTargetLayouts>b__13_0(NoaDebugger.OrientationLayoutStyle x);
        }
    }

    class OrientationLayoutRuntimeAdjusterHandle : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler
    {
        /*0x20*/ bool _isHorizontal;
        /*0x28*/ UnityEngine.RectTransform _rect;
        /*0x30*/ NoaDebugger.OrientationLayoutStyle _formerLayoutStyle;
        /*0x38*/ NoaDebugger.OrientationLayoutStyle _latterLayoutStyle;
        /*0x40*/ UnityEngine.RectTransform _formerRect;
        /*0x48*/ UnityEngine.RectTransform _latterRect;
        /*0x50*/ UnityEngine.UI.HorizontalOrVerticalLayoutGroup _layoutGroup;
        /*0x58*/ float _size;
        /*0x5c*/ float _minWidth;
        /*0x60*/ float _minHeight;
        /*0x64*/ UnityEngine.Vector2 _dragStartPos;
        /*0x6c*/ UnityEngine.Vector2 _dragStartSizeFormer;
        /*0x74*/ UnityEngine.Vector2 _dragStartSizeLatter;
        /*0x7c*/ bool _isSetStyleBeforeInitialize;
        /*0x80*/ UnityEngine.Events.UnityAction OnEndDragHandle;

        /*0x72cda7c*/ OrientationLayoutRuntimeAdjusterHandle();
        /*0x72cc800*/ void add_OnEndDragHandle(UnityEngine.Events.UnityAction value);
        /*0x72cd27c*/ void remove_OnEndDragHandle(UnityEngine.Events.UnityAction value);
        /*0x72cd318*/ void Awake();
        /*0x72cd01c*/ void Initialize(NoaDebugger.OrientationLayoutStyle formerLayout, NoaDebugger.OrientationLayoutStyle latterLayout, UnityEngine.UI.HorizontalOrVerticalLayoutGroup layoutGroup, float minWidth, float minHeight);
        /*0x72cd398*/ void SetFromLayoutStyle();
        /*0x72cd6b4*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72cd7e8*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72cd948*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72cda40*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72cd854*/ UnityEngine.Vector2 _GetLocalPositionFromPointerEventData(UnityEngine.EventSystems.PointerEventData eventData);
    }

    class OrientationLayoutStyleModel
    {
        /*0x10*/ bool _ignoreLayout;
        /*0x14*/ float _minWidth;
        /*0x18*/ bool _minWidthFlag;
        /*0x1c*/ float _minHeight;
        /*0x20*/ bool _minHeightFlag;
        /*0x24*/ float _preferredWidth;
        /*0x28*/ bool _preferredWidthFlag;
        /*0x2c*/ float _preferredHeight;
        /*0x30*/ bool _preferredHeightFlag;
        /*0x34*/ float _flexibleWidth;
        /*0x38*/ bool _flexibleWidthFlag;
        /*0x3c*/ float _flexibleHeight;
        /*0x40*/ bool _flexibleHeightFlag;
        /*0x44*/ float _relativeWidth;
        /*0x48*/ bool _relativeWidthFlag;
        /*0x4c*/ float _relativeHeight;
        /*0x50*/ bool _relativeHeightFlag;
        /*0x54*/ int _layoutPriority;

        /*0x72cda84*/ OrientationLayoutStyleModel();
    }

    class OrientationLayoutStyle : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.OrientationLayoutStyleModel _portraitLayoutStyle;
        /*0x28*/ NoaDebugger.OrientationLayoutStyleModel _landscapeLayoutStyle;
        /*0x30*/ NoaDebugger.ProportionalLayoutElement _proportionalLayoutElement;
        /*0x38*/ NoaDebugger.OrientationAwareLayoutGroup _parentLayoutGroup;
        /*0x40*/ NoaDebugger.UIBehaviourComponent _parentUIBehaviour;
        /*0x48*/ UnityEngine.RectTransform _rectTransform;
        /*0x50*/ UnityEngine.RectTransform _parentRectTransform;
        /*0x58*/ bool _isInitialized;
        /*0x60*/ NoaDebugger.OrientationLayoutRuntimeAdjusterHandle <Handle>k__BackingField;

        /*0x72ce27c*/ OrientationLayoutStyle();
        /*0x72cdabc*/ NoaDebugger.OrientationLayoutRuntimeAdjusterHandle get_Handle();
        /*0x72cdac4*/ void set_Handle(NoaDebugger.OrientationLayoutRuntimeAdjusterHandle value);
        /*0x72cdacc*/ void Awake();
        /*0x72cde18*/ void Start();
        /*0x72cdea0*/ void OnEnable();
        /*0x72cdad0*/ void _Initialize();
        /*0x72cdff8*/ void _OnTargetRectTransformDimensionsChanged();
        /*0x72cdea4*/ void _SetDirty();
        /*0x72cde1c*/ void _ValueChanged();
        /*0x72ce074*/ void _SetLayoutStyle(NoaDebugger.OrientationLayoutStyleModel layoutStyle);
        /*0x72ccc4c*/ void OverwriteLayoutByCurrentSize(int layoutsCount);
        /*0x72cca3c*/ void SetHandleFromLayoutStyle();
        /*0x72cd674*/ NoaDebugger.OrientationLayoutStyleModel GetCurrentLayoutStyle();
    }

    class PointerEventComponent : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler
    {
        /*0x20*/ UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> OnPointerDownEvent;
        /*0x28*/ UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> OnPointerUpEvent;
        /*0x30*/ UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> OnPointerClickEvent;
        /*0x38*/ UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> OnPointerEnterEvent;
        /*0x40*/ UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> OnPointerExitEvent;

        /*0x72ce9f0*/ PointerEventComponent();
        /*0x72ce284*/ void add_OnPointerDownEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72ce334*/ void remove_OnPointerDownEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72ce3e4*/ void add_OnPointerUpEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72ce494*/ void remove_OnPointerUpEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72ce544*/ void add_OnPointerClickEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72ce5f4*/ void remove_OnPointerClickEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72ce6a4*/ void add_OnPointerEnterEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72ce754*/ void remove_OnPointerEnterEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72ce804*/ void add_OnPointerExitEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72ce8b4*/ void remove_OnPointerExitEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72ce964*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72ce980*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72ce99c*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72ce9b8*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72ce9d4*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
    }

    class ProportionalLayoutElement : UnityEngine.UI.LayoutElement
    {
        /*0x40*/ float _relativeWidth;
        /*0x44*/ bool _relativeWidthFlag;
        /*0x48*/ float _relativeHeight;
        /*0x4c*/ bool _relativeHeightFlag;
        /*0x50*/ UnityEngine.RectTransform _parentRectTransform;
        /*0x58*/ UnityEngine.RectTransform _rectTransform;

        /*0x72cee3c*/ ProportionalLayoutElement();
        /*0x72ce9f8*/ float get_RelativeWidth();
        /*0x72ce26c*/ void set_RelativeWidth(float value);
        /*0x72ceabc*/ bool get_RelativeWidthFlag();
        /*0x72ceac4*/ void set_RelativeWidthFlag(bool value);
        /*0x72cead0*/ float get_RelativeHeight();
        /*0x72ce274*/ void set_RelativeHeight(float value);
        /*0x72cead8*/ bool get_RelativeHeightFlag();
        /*0x72ceae0*/ void set_RelativeHeightFlag(bool value);
        /*0x72ceaec*/ void OnEnable();
        /*0x72cea00*/ void _SetDirty();
        /*0x72cebe4*/ void CalculateLayoutInputHorizontal();
        /*0x72cec94*/ void CalculateLayoutInputVertical();
        /*0x72ced44*/ void Update();
        /*0x72cedbc*/ void _SetLayoutStyle();
    }

    class RuntimeVersionChecker : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.UI.Image[] _unsupportedColorChangeTarget;
        /*0x28*/ NoaDebugger.NoaDebuggerInfo _noaDebuggerInfo;

        /*0x72cefb0*/ RuntimeVersionChecker();
        /*0x72cee50*/ void DoCheck(NoaDebugger.NoaDebuggerInfo noaDebuggerInfo);
        /*0x72ceebc*/ void _IndicateUnsupported(bool isUnsupported);
        /*0x72cee84*/ bool _CheckSupported();
    }

    class SafeAreaAdjuster : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.RectTransform _rect;

        /*0x72cf134*/ SafeAreaAdjuster();
        /*0x72cefb8*/ void Start();
        /*0x72cefbc*/ void Adjust();
        /*0x72cf084*/ void SetRect();
    }

    class ScrollRectHeightFitter : UnityEngine.EventSystems.UIBehaviour
    {
        /*0x20*/ UnityEngine.UI.ScrollRect _resizeTargetScrollRect;
        /*0x28*/ bool _layoutElementMinHeightIsTarget;
        /*0x30*/ UnityEngine.RectTransform _scrollRectTransform;
        /*0x38*/ UnityEngine.UI.LayoutElement _layoutElement;
        /*0x40*/ UnityEngine.RectTransform _selfTransform;
        /*0x48*/ float _horizontalScrollbarHeight;

        /*0x72cf454*/ ScrollRectHeightFitter();
        /*0x72cf13c*/ void Awake();
        /*0x72cf314*/ void OnRectTransformDimensionsChange();
    }

    class ScrollResetter : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.UI.ScrollRect _scroll;
        /*0x28*/ bool _once;

        /*0x72cf504*/ ScrollResetter();
        /*0x72cf45c*/ void Awake();
        /*0x72cf4b4*/ void OnEnable();
        /*0x72cf4fc*/ void OnDisable();
        /*0x72cf4d8*/ void ResetScroll();
    }

    class TextAutoScroller : UnityEngine.EventSystems.UIBehaviour
    {
        static /*0x0*/ float SCROLL_START_DELAY;
        static /*0x4*/ float SCROLL_END_DELAY;
        static /*0x8*/ float SCROLL_X_PER_SECOND;
        /*0x20*/ TMPro.TextMeshProUGUI _scrollText;
        /*0x28*/ UnityEngine.UI.RectMask2D _targetMask;
        /*0x30*/ NoaDebugger.TextAutoScroller.ScrollState _currentScrollState;
        /*0x34*/ bool _isScroll;
        /*0x35*/ bool _isInit;
        /*0x38*/ float _scrollStartPosX;
        /*0x3c*/ float _waitTime;

        static /*0x72cf95c*/ TextAutoScroller();
        /*0x72c9068*/ TextAutoScroller();
        /*0x72cf50c*/ UnityEngine.RectTransform get_ScrollTextRect();
        /*0x72cf528*/ UnityEngine.RectTransform get_TargetMaskRect();
        /*0x72cf544*/ void Update();
        /*0x72cf848*/ void OnRectTransformDimensionsChange();
        /*0x72cf6f8*/ void _Initialize();
        /*0x72c8d10*/ void _OnInitialize();
        /*0x72c8ea8*/ void SetIsScroll(bool isScroll);
        /*0x72cf900*/ void _ResetPosition();
        /*0x72cf84c*/ void _CalculateWidth();
        /*0x72cf734*/ float _GetEndPosX();
        /*0x72cf798*/ void _SetScrollState(NoaDebugger.TextAutoScroller.ScrollState state);
        /*0x72cf720*/ void _CheckWaitTime(NoaDebugger.TextAutoScroller.ScrollState nextState);
        /*0x72c8d8c*/ void SetText(string text);
        /*0x72c8f04*/ void _SetScrollTargetText(string text);

        enum ScrollState
        {
            StartWait = 0,
            Scroll = 1,
            EndWait = 2,
            Unnecessary = 3,
        }
    }

    class UIBehaviourComponent : UnityEngine.EventSystems.UIBehaviour
    {
        /*0x20*/ UnityEngine.Events.UnityAction OnRectTransformDimensionsChanged;

        /*0x72cd190*/ UIBehaviourComponent();
        /*0x72cdf5c*/ void add_OnRectTransformDimensionsChanged(UnityEngine.Events.UnityAction value);
        /*0x72cf9b4*/ void remove_OnRectTransformDimensionsChanged(UnityEngine.Events.UnityAction value);
        /*0x72cca08*/ void OnRectTransformDimensionsChange();
    }

    class BoolPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<bool>
    {
        /*0x72cfa50*/ BoolPropertyCommandDefinition(string categoryName, string displayName, System.Func<bool> getter, System.Action<bool> setter, System.Attribute[] attributes);
        /*0x72cfad8*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class BytePropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<byte>
    {
        /*0x72cfb88*/ BytePropertyCommandDefinition(string categoryName, string displayName, System.Func<byte> getter, System.Action<byte> setter, System.Attribute[] attributes);
        /*0x72cfc10*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class CharPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<char>
    {
        /*0x72cfcc0*/ CharPropertyCommandDefinition(string categoryName, string displayName, System.Func<char> getter, System.Action<char> setter, System.Attribute[] attributes);
        /*0x72cfd48*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class CommandDefinition
    {
        /*0x10*/ string <CategoryName>k__BackingField;
        /*0x18*/ string <DisplayName>k__BackingField;
        /*0x20*/ System.Attribute[] <Attributes>k__BackingField;

        /*0x72cfe10*/ CommandDefinition(string categoryName, string displayName, System.Attribute[] attributes);
        /*0x72cfdf8*/ string get_CategoryName();
        /*0x72cfe00*/ string get_DisplayName();
        /*0x72cfe08*/ System.Attribute[] get_Attributes();
        /*0x380b9e8*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class CoroutineCommandDefinition : NoaDebugger.CommandDefinition
    {
        /*0x28*/ System.Func<System.Collections.IEnumerator> <Coroutine>k__BackingField;

        /*0x72cfe78*/ CoroutineCommandDefinition(string categoryName, string displayName, System.Func<System.Collections.IEnumerator> coroutine, System.Attribute[] attributes);
        /*0x72cfe70*/ System.Func<System.Collections.IEnumerator> get_Coroutine();
        /*0x72cfea8*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class DecimalPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<decimal>
    {
        /*0x72cff34*/ DecimalPropertyCommandDefinition(string categoryName, string displayName, System.Func<decimal> getter, System.Action<decimal> setter, System.Attribute[] attributes);
        /*0x72cffbc*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class DoublePropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<double>
    {
        /*0x72d006c*/ DoublePropertyCommandDefinition(string categoryName, string displayName, System.Func<double> getter, System.Action<double> setter, System.Attribute[] attributes);
        /*0x72d00f4*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class EnumPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<System.Enum>
    {
        /*0x38*/ System.Type <EnumType>k__BackingField;

        /*0x72d01ac*/ EnumPropertyCommandDefinition(string categoryName, string displayName, System.Func<System.Enum> getter, System.Action<System.Enum> setter, System.Type enumType, System.Attribute[] attributes);
        /*0x72d01a4*/ System.Type get_EnumType();
        /*0x72d0248*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class FloatPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<float>
    {
        /*0x72d030c*/ FloatPropertyCommandDefinition(string categoryName, string displayName, System.Func<float> getter, System.Action<float> setter, System.Attribute[] attributes);
        /*0x72d0394*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class GetOnlyPropertyCommandDefinition : NoaDebugger.CommandDefinition
    {
        /*0x28*/ System.Func<object> <Getter>k__BackingField;

        /*0x72d044c*/ GetOnlyPropertyCommandDefinition(string categoryName, string displayName, System.Func<object> getter, System.Attribute[] attributes);
        /*0x72d0444*/ System.Func<object> get_Getter();
        /*0x72d047c*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class HandleMethodCommandDefinition : NoaDebugger.CommandDefinition
    {
        /*0x28*/ System.Func<NoaDebugger.MethodHandler> <Method>k__BackingField;

        /*0x72d0510*/ HandleMethodCommandDefinition(string categoryName, string displayName, System.Func<NoaDebugger.MethodHandler> method, System.Attribute[] attributes);
        /*0x72d0508*/ System.Func<NoaDebugger.MethodHandler> get_Method();
        /*0x72d0540*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class IntPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<int>
    {
        /*0x72d05cc*/ IntPropertyCommandDefinition(string categoryName, string displayName, System.Func<int> getter, System.Action<int> setter, System.Attribute[] attributes);
        /*0x72d0654*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class LongPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<long>
    {
        /*0x72d0704*/ LongPropertyCommandDefinition(string categoryName, string displayName, System.Func<long> getter, System.Action<long> setter, System.Attribute[] attributes);
        /*0x72d078c*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class MethodCommandDefinition : NoaDebugger.CommandDefinition
    {
        /*0x28*/ System.Action <Method>k__BackingField;

        /*0x72d0844*/ MethodCommandDefinition(string categoryName, string displayName, System.Action method, System.Attribute[] attributes);
        /*0x72d083c*/ System.Action get_Method();
        /*0x72d0874*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class MutablePropertyCommandDefinition<T> : NoaDebugger.CommandDefinition
    {
        /*0x0*/ System.Func<T> <Getter>k__BackingField;
        /*0x0*/ System.Action<T> <Setter>k__BackingField;

        /*0x380db04*/ MutablePropertyCommandDefinition(string categoryName, string displayName, System.Func<T> getter, System.Action<T> setter, System.Attribute[] attributes);
        /*0x380b9e8*/ System.Func<T> get_Getter();
        /*0x380b9e8*/ System.Action<T> get_Setter();
    }

    class SBytePropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<sbyte>
    {
        /*0x72d0900*/ SBytePropertyCommandDefinition(string categoryName, string displayName, System.Func<sbyte> getter, System.Action<sbyte> setter, System.Attribute[] attributes);
        /*0x72d0988*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class ShortPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<short>
    {
        /*0x72d0a38*/ ShortPropertyCommandDefinition(string categoryName, string displayName, System.Func<short> getter, System.Action<short> setter, System.Attribute[] attributes);
        /*0x72d0ac0*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class StringPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<string>
    {
        /*0x72d0b70*/ StringPropertyCommandDefinition(string categoryName, string displayName, System.Func<string> getter, System.Action<string> setter, System.Attribute[] attributes);
        /*0x72d0bf8*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class UIntPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<uint>
    {
        /*0x72d0ca8*/ UIntPropertyCommandDefinition(string categoryName, string displayName, System.Func<uint> getter, System.Action<uint> setter, System.Attribute[] attributes);
        /*0x72d0d30*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class ULongPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<ulong>
    {
        /*0x72d0de0*/ ULongPropertyCommandDefinition(string categoryName, string displayName, System.Func<ulong> getter, System.Action<ulong> setter, System.Attribute[] attributes);
        /*0x72d0e68*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class UShortPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<ushort>
    {
        /*0x72d0f18*/ UShortPropertyCommandDefinition(string categoryName, string displayName, System.Func<ushort> getter, System.Action<ushort> setter, System.Attribute[] attributes);
        /*0x72d0fa0*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    interface IExportData
    {
        /*0x380b9e8*/ NoaDebugger.DownloadInfo GetDownloadInfo();
    }

    class DownloadInfo
    {
        static string EXPORT_FILE_DATE_TIME_FORMAT = "yyyyMMdd-HHmmss";
        static string EXPORT_FILE_EXTENSION = "json";
        /*0x10*/ string _exportFilePrefix;

        /*0x72c6e64*/ DownloadInfo(string prefix);
        /*0x72d1050*/ string GetExportFileName(string label, System.DateTime date);

        class <>c
        {
            static /*0x0*/ NoaDebugger.DownloadInfo.<> <>9;
            static /*0x8*/ System.Predicate<string> <>9__4_0;

            static /*0x72d1360*/ <>c();
            /*0x72d13c8*/ <>c();
            /*0x72d13d0*/ bool <GetExportFileName>b__4_0(string s);
        }
    }

    class FileDownloader
    {
        static /*0x0*/ NoaDebugger.FileDownloader.Status _status;
        static /*0x4*/ bool _isOpened;
        static /*0x8*/ string _outputPath;

        static /*0x72d13dc*/ System.Collections.IEnumerator DownloadFileCompleted();
        static /*0x72d145c*/ void DownloadFile(string fileName, string textData, string mimeType, System.Action<NoaDebugger.FileDownloader.DownloadInfo> callback);
        static /*0x72d16b8*/ System.Collections.IEnumerator DownloadFileAsync(string fileName, string textData, string mimeType, System.Action<NoaDebugger.FileDownloader.DownloadInfo> callback);
        static /*0x72d186c*/ void DownloadFile(string fileName, string textData, string mimeType);
        static /*0x72d1c34*/ string GetMimeType(string extension);
        static /*0x72d1d1c*/ void OnDownloadFinished(NoaDebugger.FileDownloader.DownloadInfo info);
        static /*0x72d155c*/ bool CanDownload();

        enum Status
        {
            None = 0,
            Downloading = 1,
            Completed = 2,
            Canceled = 3,
            Error = 4,
        }

        struct DownloadInfo
        {
            /*0x10*/ NoaDebugger.FileDownloader.Status _status;
            /*0x18*/ string _outputPath;
        }

        class <DownloadFileAsync>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ string fileName;
            /*0x28*/ string textData;
            /*0x30*/ string mimeType;
            /*0x38*/ System.Action<NoaDebugger.FileDownloader.DownloadInfo> callback;

            /*0x72d1844*/ <DownloadFileAsync>d__7(int <>1__state);
            /*0x72d1f90*/ void System.IDisposable.Dispose();
            /*0x72d1f94*/ bool MoveNext();
            /*0x72d2094*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72d209c*/ void System.Collections.IEnumerator.Reset();
            /*0x72d20d4*/ object System.Collections.IEnumerator.get_Current();
        }

        class <DownloadFileCompleted>d__0 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ UnityEngine.AndroidJavaClass <fileDownloader>5__2;
            /*0x28*/ int <status>5__3;

            /*0x72d1434*/ <DownloadFileCompleted>d__0(int <>1__state);
            /*0x72d20dc*/ void System.IDisposable.Dispose();
            /*0x72d20f8*/ bool MoveNext();
            /*0x72d2344*/ void <>m__Finally1();
            /*0x72d23f4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72d23fc*/ void System.Collections.IEnumerator.Reset();
            /*0x72d2434*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class FrameTimeInfo
    {
        /*0x10*/ bool <IsEnabled>k__BackingField;
        /*0x11*/ bool <IsActive>k__BackingField;
        /*0x18*/ NoaDebugger.RingBuffer<System.Single[]> <HistoryBuffer>k__BackingField;
        /*0x20*/ System.Collections.Generic.List<System.Single[]> _historyValueBuffer;

        /*0x72d246c*/ FrameTimeInfo(int historyCapacity);
        /*0x72d243c*/ bool get_IsEnabled();
        /*0x72d2444*/ void set_IsEnabled(bool value);
        /*0x72d2450*/ bool get_IsActive();
        /*0x72d2458*/ void set_IsActive(bool value);
        /*0x72d2464*/ NoaDebugger.RingBuffer<System.Single[]> get_HistoryBuffer();
        /*0x72d262c*/ void AddHistory(float updateMilliseconds, float renderingMilliseconds, float othersMilliseconds);
        /*0x72d2764*/ void ClearHistory();
    }

    class ArrayParamCreator : NoaDebugger.IParamCreator
    {
        /*0x72d3218*/ ArrayParamCreator();
        /*0x72d27b4*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> CreateSubParameter(object obj, UnityEngine.Component component, int depth);
        /*0x72d2fc8*/ string GetValue(object obj, object component);
        /*0x72d291c*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> _GetGameObjectDetailEntryFromArray(System.Array array, UnityEngine.Component component, int depth);
        /*0x72d2c18*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> _GetGameObjectDetailEntryFromList(System.Collections.IList list, UnityEngine.Component component, int depth);
    }

    class ClassParamCreator : NoaDebugger.IParamCreator
    {
        /*0x72d384c*/ ClassParamCreator();
        /*0x72d3220*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> CreateSubParameter(object obj, UnityEngine.Component component, int depth);
        /*0x72d3844*/ string GetValue(object obj, object component);
    }

    class GameObjectDetailEntry
    {
        /*0x10*/ string _name;
        /*0x18*/ string _value;
        /*0x20*/ bool _isOpen;
        /*0x28*/ NoaDebugger.GameObjectDetailEntryCallback _callback;
        /*0x30*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> _subDetailList;

        /*0x72d3190*/ GameObjectDetailEntry();
        /*0x72d3854*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailPanelData> GetPanelDataListWithSubDetail(NoaDebugger.GameObjectDetailEntryCallback callback);
        /*0x72d38e0*/ void _AddPanelDataList(System.Collections.Generic.List<NoaDebugger.GameObjectDetailPanelData> list, NoaDebugger.GameObjectDetailEntryCallback callback, int depth);
        /*0x72d3b50*/ void _OnToggleOpen();
    }

    class GameObjectDetailEntryCallback
    {
        /*0x10*/ System.Action _onUpdateView;

        /*0x72d3b90*/ GameObjectDetailEntryCallback();
    }

    class HierarchyGameObjectEntry
    {
        /*0x10*/ int _hashCode;
        /*0x18*/ string _name;
        /*0x20*/ bool _isActive;
        /*0x21*/ bool _isOpen;
        /*0x22*/ bool _isSelected;
        /*0x28*/ NoaDebugger.HierarchyGameObjectEntryCallback _callback;
        /*0x30*/ UnityEngine.GameObject _gameObject;
        /*0x38*/ System.Collections.Generic.List<NoaDebugger.HierarchyGameObjectEntry> _children;

        /*0x72d3ef4*/ HierarchyGameObjectEntry();
        /*0x72d3b98*/ System.Collections.Generic.List<NoaDebugger.HierarchyPanelData> GetPanelDataListWithChildren(NoaDebugger.HierarchyGameObjectEntryCallback callback);
        /*0x72d3c24*/ void _AddPanelData(System.Collections.Generic.List<NoaDebugger.HierarchyPanelData> list, NoaDebugger.HierarchyGameObjectEntryCallback callback, int depth);
        /*0x72d3ea4*/ void _OnToggleOpen();
        /*0x72d3ea8*/ void SwitchToggle();
    }

    class HierarchyGameObjectEntryCallback
    {
        /*0x10*/ System.Action<NoaDebugger.HierarchyGameObjectEntry> _onSelect;
        /*0x18*/ System.Action<int, bool> _onToggleOpen;
        /*0x20*/ System.Action _onUpdateView;

        /*0x72d3f7c*/ HierarchyGameObjectEntryCallback();
    }

    class HierarchyModelHelper
    {
        static /*0x72d3f84*/ bool IsViewPropertyInfo(System.Reflection.PropertyInfo propertyInfo);
        static /*0x72d3584*/ bool IsViewFieldInfo(System.Reflection.FieldInfo fieldInfo);
        /*0x72d4120*/ HierarchyModelHelper();
    }

    interface IParamCreator
    {
        System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> CreateSubParameter(object obj, UnityEngine.Component component, int depth);
        /*0x380bcbc*/ string GetValue(object obj, object component);
    }

    class ParamCreatorFactory
    {
        static /*0x72d2fd0*/ NoaDebugger.IParamCreator ParamCreatorByType(System.Type type);
        /*0x72d4138*/ ParamCreatorFactory();
    }

    class PrimitiveParamCreator : NoaDebugger.IParamCreator
    {
        /*0x72d4130*/ PrimitiveParamCreator();
        /*0x72d4140*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> CreateSubParameter(object obj, UnityEngine.Component component, int depth);
        /*0x72d41a8*/ string GetValue(object obj, object component);
    }

    class StructParamCreator : NoaDebugger.IParamCreator
    {
        /*0x72d4128*/ StructParamCreator();
        /*0x72d42d8*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> CreateSubParameter(object obj, UnityEngine.Component component, int depth);
        /*0x72d463c*/ string GetValue(object obj, object component);
    }

    class InformationCustomGroup
    {
        /*0x10*/ string <Name>k__BackingField;
        /*0x18*/ string <DisplayName>k__BackingField;
        /*0x20*/ System.Collections.Generic.List<NoaDebugger.InformationCustomKeyValue> <KeyValues>k__BackingField;
        /*0x28*/ int <Order>k__BackingField;

        /*0x72d4664*/ InformationCustomGroup(string name, string displayName, System.Collections.Generic.List<NoaDebugger.InformationCustomKeyValue> keyValues, int order);
        /*0x72d4644*/ string get_Name();
        /*0x72d464c*/ string get_DisplayName();
        /*0x72d4654*/ System.Collections.Generic.List<NoaDebugger.InformationCustomKeyValue> get_KeyValues();
        /*0x72d465c*/ int get_Order();
        /*0x72d46d0*/ System.Collections.Generic.Dictionary<string, string> GetKeyValuesAsDictionary();

        class <>c__DisplayClass13_0
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, string> keyValues;

            /*0x72d4800*/ <>c__DisplayClass13_0();
            /*0x72d4808*/ void <GetKeyValuesAsDictionary>b__0(NoaDebugger.InformationCustomKeyValue kv);
        }
    }

    class InformationCustomKeyValue
    {
        /*0x10*/ string <Key>k__BackingField;
        /*0x18*/ System.Func<string> <GetValue>k__BackingField;
        /*0x20*/ string <DisplayName>k__BackingField;
        /*0x28*/ int <Order>k__BackingField;

        /*0x72d48a8*/ InformationCustomKeyValue(string keyName, System.Func<string> getValue, string displayName, int order);
        /*0x72d4888*/ string get_Key();
        /*0x72d4890*/ System.Func<string> get_GetValue();
        /*0x72d4898*/ string get_DisplayName();
        /*0x72d48a0*/ int get_Order();
    }

    class Input
    {
        static /*0x0*/ NoaDebugger.InputInternal Internal;

        static /*0x72d4aa4*/ Input();
        static /*0x72d4914*/ void Initialize();
        static /*0x72d4978*/ bool IsButtonUp();
        static /*0x72d49dc*/ bool IsButtonReleased();
        static /*0x72d4a40*/ UnityEngine.Vector2 GetCursorPosition();
    }

    class ShortcutInputCombination
    {
        /*0x10*/ bool isEnabled;
        /*0x18*/ NoaDebugger.ShortcutKeyboardBinding keyboard;

        /*0x72d4b20*/ ShortcutInputCombination();
    }

    class ShortcutAction
    {
        /*0x10*/ NoaDebugger.ShortcutActionType actionType;
        /*0x18*/ NoaDebugger.ShortcutInputCombination combination;

        /*0x72d4b38*/ ShortcutAction(NoaDebugger.ShortcutActionType type);
        /*0x72d4b30*/ NoaDebugger.ShortcutActionType get_Type();
        /*0x72d4bc0*/ string GetDisplayText(bool isRuntime);
        /*0x72d4c00*/ string GetDisplayText(bool isRuntime, bool isWindows, bool isMac);
        /*0x72d4f50*/ bool _TryGetModifierKey(NoaDebugger.ShortcutModifierKey modifier, bool isRuntime, bool isWindows, bool isMac, ref string modifierKey);
    }

    class ShortcutActionHandler : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.NoaDebuggerSettings _settings;
        /*0x28*/ bool _isPressed;
        /*0x2c*/ float _pressStartTime;
        /*0x30*/ float _lastHoldActionTime;
        /*0x34*/ NoaDebugger.ShortcutActionHandler.PressState _pressState;
        /*0x38*/ bool _hasProcessedLongPress;
        /*0x39*/ bool <IsShortcutsEnabled>k__BackingField;

        /*0x72d5cf4*/ ShortcutActionHandler();
        /*0x72d516c*/ bool get_IsShortcutsEnabled();
        /*0x72d5174*/ void set_IsShortcutsEnabled(bool value);
        /*0x72d5180*/ void Awake();
        /*0x72d524c*/ void Update();
        /*0x72d5458*/ System.ValueTuple<bool, bool, bool> _IsTrigger(NoaDebugger.ShortcutAction action);
        /*0x72d5778*/ void _ExecuteAction(NoaDebugger.ShortcutActionType actionType, bool shortPress, bool longPress, bool holdDown);

        enum PressState
        {
            None = 0,
            KeyDown = 1,
            Pressing = 2,
            PressingLoop = 3,
        }
    }

    class UnityInputUtils
    {
        static /*0x0*/ NoaDebugger.UnityInputUtilsInternal Internal;
        static /*0x8*/ bool IsEnableInputSystem;
        static /*0xc*/ float ScrollSensitivity;

        static /*0x72d5fb0*/ UnityInputUtils();
        static /*0x72d5cfc*/ void AddInputModule(UnityEngine.GameObject target);
        static /*0x72d51e8*/ void OnShortcutHandlerInitialize();
        static /*0x72d5b8c*/ bool IsShortcutKeyDown(NoaDebugger.ShortcutAction action);
        static /*0x72d5c04*/ bool IsShortcutKeyHeld(NoaDebugger.ShortcutAction action);
        static /*0x72d5c7c*/ bool IsShortcutKeyUp(NoaDebugger.ShortcutAction action);
        static /*0x72d5100*/ string GetKeyTextFromInt(int keyNum);
        static /*0x72d5d68*/ int GetCurrentDefaultKey(NoaDebugger.ShortcutActionType actionType);
        static /*0x72d5dd4*/ int GetDefaultShortcutKey(NoaDebugger.ShortcutActionType actionType, bool forInputSystem);
        static /*0x72d5eb0*/ int GetCurrentKey(UnityEngine.Event current);
        static /*0x72d5f1c*/ void CheckInputSystemAvailable();
    }

    class JsonFormatter
    {
        static string DEFAULT_INDENT_STRING = "  ";
        static NoaDebugger.JsonFormatter.NewLine DEFAULT_NEW_LINE = 1;

        static /*0x72d604c*/ string Format(string inputJson, string indentString, NoaDebugger.JsonFormatter.NewLine newLine);

        enum NewLine
        {
            Cr = 0,
            Lf = 1,
            CrLf = 2,
        }

        class Formatter : System.IDisposable
        {
            /*0x10*/ System.IO.StringReader _inputJsonReader;
            /*0x18*/ System.Text.StringBuilder _outputStringBuilder;
            /*0x20*/ string _indentString;
            /*0x28*/ string _newLineString;
            /*0x30*/ int _indentDepth;

            static /*0x72d653c*/ void ReportWarning(string message);
            /*0x72d61f8*/ Formatter(string inputJson, string indentString, NoaDebugger.JsonFormatter.NewLine newLine);
            /*0x72d63e0*/ void Dispose();
            /*0x72d638c*/ string Format();
            /*0x72d63fc*/ bool ReadValue();
            /*0x72d6604*/ bool ReadObject();
            /*0x72d69bc*/ bool ReadObjectMember();
            /*0x72d66dc*/ bool ReadArray();
            /*0x72d67b4*/ bool ReadNumber();
            /*0x72d6a40*/ bool ReadInteger();
            /*0x72d6aac*/ bool ReadFraction();
            /*0x72d6af4*/ bool ReadExponent();
            /*0x72d6b6c*/ bool ReadDigits();
            /*0x72d67e8*/ bool ReadString();
            /*0x72d6bd8*/ bool ReadEscapeSequence();
            /*0x72d6870*/ bool ReadLiteral(string expectedLiteral);
            /*0x72d690c*/ void ReadCharacter();
            /*0x72d6594*/ void SkipWhitespaces();
            /*0x72d6948*/ void IncreaseIndent();
            /*0x72d6a30*/ void DecreaseIndent();
            /*0x72d6958*/ void NextLine();
        }
    }

    class ConsoleLogQueue
    {
        static /*0x0*/ System.Collections.Concurrent.ConcurrentQueue<System.ValueTuple<UnityEngine.LogType, string, string>> <LogQueue>k__BackingField;

        static /*0x72d7024*/ ConsoleLogQueue();
        static /*0x72d6d1c*/ System.Collections.Concurrent.ConcurrentQueue<System.ValueTuple<UnityEngine.LogType, string, string>> get_LogQueue();
        static /*0x72d6d74*/ void EnqueueLog(UnityEngine.LogType type, string message, string stackTrace);
        static /*0x72d6e88*/ void FlushLog(System.Action<UnityEngine.LogType, string, string> logCallback);
        static /*0x72d6f74*/ void ClearLog();
        /*0x72d701c*/ ConsoleLogQueue();
    }

    class LogFilterRepository
    {
        /*0x10*/ string _prefsKey;

        /*0x72d70bc*/ LogFilterRepository(string prefsKey);
        /*0x72d70ec*/ void SaveFilter(System.Collections.Generic.Dictionary<NoaDebugger.LogType, bool> flagDictionary);
        /*0x72d7344*/ System.Collections.Generic.Dictionary<NoaDebugger.LogType, bool> LoadFilter(System.Collections.Generic.Dictionary<NoaDebugger.LogType, bool> flagDictionary);
        /*0x72d72ac*/ NoaDebugger.LogFilterRepository.InternalLogType _GetInternalLogTypeFrom(NoaDebugger.LogType logType);
        /*0x72d7588*/ bool _IsLogTypeTrue(NoaDebugger.LogType logType, NoaDebugger.LogFilterRepository.InternalLogType targetFlag);
        /*0x72d72a4*/ NoaDebugger.LogFilterRepository.InternalLogType _AllTrue();

        enum InternalLogType
        {
            Error = 1,
            Warning = 2,
            Log = 4,
        }
    }

    class ApplicationBackgroundManager : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ NoaDebugger.ApplicationBackgroundManager _instance;
        /*0x20*/ System.Collections.Generic.Dictionary<string, System.Action<bool>> _actionDic;
        /*0x28*/ bool <IsBackground>k__BackingField;

        static /*0x72d7610*/ void Instantiate(UnityEngine.Transform parent);
        static /*0x72d7700*/ void SetAction(string key, System.Action<bool> action, NoaDebugger.ApplicationBackgroundManager.SameKeyActionType type);
        static /*0x72d79a4*/ void DeleteAction(string key);
        /*0x72d7e44*/ ApplicationBackgroundManager();
        /*0x72d75a4*/ bool get_IsBackground();
        /*0x72d75ac*/ void set_IsBackground(bool value);
        /*0x72d75b8*/ void Awake();
        /*0x72d77d0*/ void _SetAction(string key, System.Action<bool> action, NoaDebugger.ApplicationBackgroundManager.SameKeyActionType type);
        /*0x72d7a58*/ void _DeleteAction(string key);
        /*0x72d7ae8*/ void OnApplicationPause(bool pauseStatus);
        /*0x72d7de4*/ void OnApplicationFocus(bool hasFocus);
        /*0x72d7af0*/ void _ChangeBackgroundStatus(bool isBackground);
        /*0x72d7df0*/ void OnDestroy();

        enum SameKeyActionType
        {
            None = 0,
            Add = 1,
            Override = 2,
            Error = 3,
        }
    }

    class DeviceOrientationManager : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ NoaDebugger.DeviceOrientationManager _instance;
        /*0x20*/ System.Collections.Generic.Dictionary<string, System.Action<bool>> _actionDic;
        /*0x28*/ System.Collections.Generic.List<string> _deleteActionKeyList;
        /*0x30*/ NoaDebugger.DeviceOrientationManager.Orientation _orientation;

        static /*0x72c869c*/ bool get_IsPortrait();
        static /*0x72d7ecc*/ void Init(UnityEngine.Transform parent);
        static /*0x72c8508*/ bool ContainsKey(string key);
        static /*0x72c85e0*/ void SetAction(string key, System.Action<bool> action);
        static /*0x72c8948*/ void DeleteAction(string key);
        /*0x72d8638*/ DeviceOrientationManager();
        /*0x72d7fb0*/ void _SetAction(string key, System.Action<bool> action);
        /*0x72d8018*/ void _DeleteAction(string key);
        /*0x72d80fc*/ void _WatchDeviceOrientation();
        /*0x72d85e0*/ void Update();
        /*0x72d85e4*/ void OnDestroy();

        enum Orientation
        {
            None = 0,
            Portrait = 1,
            Landscape = 2,
        }
    }

    class EventSystemManager : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ string EventSystemName;
        /*0x20*/ UnityEngine.GameObject _createdEventSystem;

        static /*0x72d8df0*/ EventSystemManager();
        static /*0x72d8714*/ void Init(UnityEngine.Transform parent);
        /*0x72d8de8*/ EventSystemManager();
        /*0x72d87c8*/ void Awake();
        /*0x72d88e4*/ void _OnLoadSceneAddOrDisabledEventSystem(UnityEngine.SceneManagement.Scene arg0, UnityEngine.SceneManagement.LoadSceneMode loadSceneMode);
        /*0x72d8d54*/ void _OnUnloadSceneDisableEventSystem(UnityEngine.SceneManagement.Scene arg0);
        /*0x72d8b74*/ void _AddEventSystem();
        /*0x72d8ddc*/ void OnDestroy();

        class <>c
        {
            static /*0x0*/ NoaDebugger.EventSystemManager.<> <>9;
            static /*0x8*/ System.Predicate<UnityEngine.EventSystems.EventSystem> <>9__4_0;

            static /*0x72d8e5c*/ <>c();
            /*0x72d8ec4*/ <>c();
            /*0x72d8ecc*/ bool <_OnLoadSceneAddOrDisabledEventSystem>b__4_0(UnityEngine.EventSystems.EventSystem e);
        }
    }

    class FrameTimeMeasurer : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ NoaDebugger.FrameTimeMeasurer _instance;
        /*0x20*/ System.Action<double, double, double> OnUpdateFrameTime;
        /*0x28*/ System.Diagnostics.Stopwatch _stopwatch;
        /*0x30*/ NoaDebugger.EndOfUpdateListener _endOfFrameListener;
        /*0x38*/ double _updateDuration;
        /*0x40*/ double _renderingStartTime;
        /*0x48*/ double _renderingDuration;
        /*0x50*/ bool _isRenderingStartedOnThisFrame;

        static /*0x72d90ac*/ void Instantiate(UnityEngine.Transform parent);
        static /*0x72d919c*/ NoaDebugger.FrameTimeMeasurer GetInstance();
        /*0x72d96e4*/ FrameTimeMeasurer();
        /*0x72d8f4c*/ void add_OnUpdateFrameTime(System.Action<double, double, double> value);
        /*0x72d8ffc*/ void remove_OnUpdateFrameTime(System.Action<double, double, double> value);
        /*0x72d91e4*/ void Awake();
        /*0x72d9400*/ void Update();
        /*0x72d94d4*/ void OnEndOfUpdate();
        /*0x72d9554*/ void OnCameraPreRender(UnityEngine.Camera _);
        /*0x72d95e4*/ void OnCameraPostRender(UnityEngine.Camera _);
        /*0x72d966c*/ void OnDestroy();
    }

    class GlobalCoroutine : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ NoaDebugger.GlobalCoroutine _instance;

        static /*0x72d9750*/ bool get_IsExecutable();
        static /*0x72d97c8*/ void Init(UnityEngine.Transform parent);
        static /*0x72d98b8*/ void Dispose();
        static /*0x72d1770*/ UnityEngine.Coroutine Run(System.Collections.IEnumerator routine, UnityEngine.Events.UnityAction onComplete);
        static /*0x72d99d0*/ void Stop(System.Collections.IEnumerator routine);
        /*0x72d9a88*/ GlobalCoroutine();
        /*0x72d990c*/ System.Collections.IEnumerator Routine(System.Collections.IEnumerator src, UnityEngine.Events.UnityAction onComplete);

        class <Routine>d__6 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.GlobalCoroutine <>4__this;
            /*0x28*/ System.Collections.IEnumerator src;
            /*0x30*/ UnityEngine.Events.UnityAction onComplete;

            /*0x72d99a8*/ <Routine>d__6(int <>1__state);
            /*0x72d9a90*/ void System.IDisposable.Dispose();
            /*0x72d9a94*/ bool MoveNext();
            /*0x72d9b14*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72d9b1c*/ void System.Collections.IEnumerator.Reset();
            /*0x72d9b54*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class OverlayManager : UnityEngine.EventSystems.UIBehaviour
    {
        /*0x20*/ UnityEngine.RectTransform _overlayParentTransform;
        /*0x28*/ UnityEngine.RectTransform _applySafeAreaRect;
        /*0x30*/ UnityEngine.RectTransform _unApplySafeAreaRect;
        /*0x38*/ UnityEngine.Transform _overlaySettingsParentTransform;
        /*0x40*/ System.Func<NoaDebugger.INoaDebuggerTool> _getCurrentTool;

        /*0x72da074*/ OverlayManager();
        /*0x72d9b5c*/ UnityEngine.Transform get_OverlayRoot();
        /*0x72d9b64*/ void Awake();
        /*0x72d9b68*/ void Initialize(UnityEngine.Transform overlaySettingsParent, System.Func<NoaDebugger.INoaDebuggerTool> getCurrentTool);
        /*0x72d9ba0*/ void ResetRootRectSize();
        /*0x72d9c88*/ void OnRectTransformDimensionsChange();
        /*0x72d9c8c*/ void PinOverlayTool();
        /*0x72d9d64*/ void ToggleOverlaySettings();
        /*0x72d9e3c*/ NoaDebugger.INoaDebuggerOverlayTool GetOverlayToolFromOverlayFeatures(NoaDebugger.NoaDebug.OverlayFeatures feature);
        /*0x72d9f2c*/ void SetOverlayEnabled(NoaDebugger.INoaDebuggerOverlayTool overlayTool, bool isEnabled, System.Action onChanged);
    }

    class UpdateManager : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ NoaDebugger.UpdateManager _instance;
        /*0x20*/ System.Collections.Concurrent.ConcurrentDictionary<string, System.Action> _actionDic;
        /*0x28*/ System.Collections.Concurrent.ConcurrentBag<string> _deleteActionKeyList;

        static /*0x72da0d4*/ void _Instantiate();
        static /*0x72c7704*/ bool ContainsKey(string key);
        static /*0x72c77cc*/ void SetAction(string key, System.Action action);
        static /*0x72da230*/ void AddOrOverwriteAction(string key, System.Action action);
        static /*0x72da348*/ void ReplaceAction(string key, System.Action action);
        static /*0x72c787c*/ void DeleteAction(string key);
        /*0x72dac18*/ UpdateManager();
        /*0x72da07c*/ void Awake();
        /*0x72da1c8*/ void _SetAction(string key, System.Action action);
        /*0x72da2e0*/ void _AddOrOverwriteAction(string key, System.Action action);
        /*0x72da3f8*/ void _ReplaceAction(string key, System.Action action);
        /*0x72da49c*/ void _DeleteAction(string key);
        /*0x72da52c*/ void Update();
    }

    class NoaControllerManager
    {
        static /*0x0*/ NoaDebugger.NoaControllerManager _instance;
        /*0x10*/ NoaDebugger.NoaControllerView _controllerView;
        /*0x18*/ NoaDebugger.ApplicationOperateModel _applicationOperateModel;
        /*0x20*/ System.Action _onShow;
        /*0x28*/ System.Action _onHide;
        /*0x30*/ NoaDebugger.NoaControllerManager.CustomActionSettings[] _customActionSettings;
        /*0x38*/ System.Action<bool> _onTogglePauseResume;
        /*0x40*/ System.Action<float> _onGameSpeedChanged;
        /*0x48*/ System.Func<bool> _onApplicationReset;
        /*0x50*/ System.Func<bool, bool> _onToggleNoaDebuggerUI;
        /*0x58*/ System.Func<NoaDebugger.NoaController.ScreenshotTarget> _onBeforeScreenshot;
        /*0x60*/ System.Func<bool> _onCaptureScreenshot;
        /*0x68*/ System.Action _onAfterScreenshot;
        /*0x70*/ System.Action _onFrameStepping;
        /*0x78*/ byte[] _capturedScreenshot;
        /*0x80*/ NoaDebugger.NoaDebuggerButtonEffectManager _buttonEffectManager;

        static /*0x72dacf4*/ System.Action get_OnShow();
        static /*0x72dad48*/ void set_OnShow(System.Action value);
        static /*0x72dada4*/ System.Action get_OnHide();
        static /*0x72dadf8*/ void set_OnHide(System.Action value);
        static /*0x72dae54*/ System.Action<bool> get_OnTogglePauseResume();
        static /*0x72daea8*/ void set_OnTogglePauseResume(System.Action<bool> value);
        static /*0x72daf04*/ System.Action<float> get_OnGameSpeedChanged();
        static /*0x72daf58*/ void set_OnGameSpeedChanged(System.Action<float> value);
        static /*0x72dafb4*/ System.Func<bool> get_OnApplicationReset();
        static /*0x72db008*/ void set_OnApplicationReset(System.Func<bool> value);
        static /*0x72db064*/ System.Func<NoaDebugger.NoaController.ScreenshotTarget> get_OnBeforeScreenshot();
        static /*0x72db0b8*/ void set_OnBeforeScreenshot(System.Func<NoaDebugger.NoaController.ScreenshotTarget> value);
        static /*0x72db114*/ System.Func<bool> get_OnCaptureScreenshot();
        static /*0x72db168*/ void set_OnCaptureScreenshot(System.Func<bool> value);
        static /*0x72db1c4*/ System.Action get_OnAfterScreenshot();
        static /*0x72db218*/ void set_OnAfterScreenshot(System.Action value);
        static /*0x72db274*/ System.Action get_OnFrameStepping();
        static /*0x72db2c8*/ void set_OnFrameStepping(System.Action value);
        static /*0x72db324*/ bool get_IsGamePlaying();
        static /*0x72db374*/ float get_GameSpeed();
        static /*0x72db3fc*/ void Initialize(NoaDebugger.NoaControllerView controllerView, NoaDebugger.NoaDebuggerButtonEffectManager buttonEffectManager);
        static /*0x72dbb08*/ void SetCustomTapAction(int buttonIndex, System.Action action, System.Func<string> messageFunc);
        static /*0x72dbd10*/ void SetCustomLongPressAction(int buttonIndex, System.Action action, System.Func<string> messageFunc);
        static /*0x72dbf18*/ void SetCustomToggleAction(int buttonIndex, System.Action<bool> action, System.Func<bool, string> messageFunc, System.Nullable<bool> initialState);
        static /*0x72dc35c*/ void SetCustomActionType(int buttonIndex, NoaDebugger.NoaController.CustomActionType actionType);
        static /*0x72dc438*/ NoaDebugger.NoaController.CustomActionType GetCustomActionType(int buttonIndex);
        static /*0x72dc4e8*/ void RunCustomTapAction(int buttonIndex);
        static /*0x72dc5ac*/ void RunCustomLongPressAction(int buttonIndex);
        static /*0x72dc670*/ void SetCustomToggle(int buttonIndex, bool isOn);
        static /*0x72dc6d8*/ bool GetCustomToggle(int buttonIndex);
        static /*0x72dc7a4*/ void TogglePauseResume();
        static /*0x72dc8d0*/ void IncreaseGameSpeed();
        static /*0x72dc97c*/ void DecreaseGameSpeed();
        static /*0x72dca28*/ void MinimizeGameSpeed();
        static /*0x72dcad4*/ void MaximizeGameSpeed();
        static /*0x72dcb80*/ void ResetGameSpeed();
        static /*0x72dcc2c*/ void FrameStepping();
        static /*0x72dcce0*/ void ResetApplication();
        static /*0x72dcd88*/ void CaptureScreenshot();
        static /*0x72dcdfc*/ byte[] GetCapturedScreenshot();
        static /*0x72dce50*/ void ClearCapturedScreenshot();
        static /*0x72dcea8*/ void TakeScreenshot(System.Action<System.Byte[]> callback);
        static /*0x72dd244*/ bool _IsButtonIndexInRange(int buttonIndex);
        static /*0x72dd9fc*/ byte[] CaptureScreenshotInternal();
        /*0x72db478*/ NoaControllerManager(NoaDebugger.NoaControllerView controllerView, NoaDebugger.NoaDebuggerButtonEffectManager buttonEffectManager);
        /*0x72dcf90*/ void _OnLoadScene(UnityEngine.SceneManagement.Scene _, UnityEngine.SceneManagement.LoadSceneMode __);
        /*0x72dcfd8*/ void _OnShow();
        /*0x72dd220*/ void _OnHide();
        /*0x72dbb78*/ void _SetCustomTapAction(int buttonIndex, System.Action action, System.Func<string> messageFunc);
        /*0x72dd2b4*/ void _NotifyCustomActionTapped(int buttonIndex);
        /*0x72dbd80*/ void _SetCustomLongPressAction(int buttonIndex, System.Action action, System.Func<string> messageFunc);
        /*0x72dd408*/ void _NotifyCustomActionLongPressed(int buttonIndex);
        /*0x72dc0c4*/ void _SetCustomToggleAction(int buttonIndex, System.Action<bool> action, System.Func<bool, string> messageFunc);
        /*0x72dc2f8*/ void _SetCustomToggleMessage(int buttonIndex, System.Func<bool, string> messageFunc);
        /*0x72dd55c*/ void _NotifyCustomActionToggled(int buttonIndex, bool isOn);
        /*0x72dc3c4*/ void _SetCustomActionType(int buttonIndex, NoaDebugger.NoaController.CustomActionType actionType);
        /*0x72dc490*/ NoaDebugger.NoaController.CustomActionType _GetCustomActionType(int buttonIndex);
        /*0x72dc540*/ void _RunCustomTapAction(int buttonIndex);
        /*0x72dc604*/ void _RunCustomLongPressAction(int buttonIndex);
        /*0x72dc238*/ void _SetCustomToggle(int buttonIndex, bool isOn);
        /*0x72dc730*/ bool _GetCustomToggle(int buttonIndex);
        /*0x72dc804*/ void _TogglePauseResume(bool isResume);
        /*0x72dc920*/ void _IncreaseGameSpeed();
        /*0x72dcb24*/ void _MaximizeGameSpeed();
        /*0x72dc9cc*/ void _DecreaseGameSpeed();
        /*0x72dca78*/ void _MinimizeGameSpeed();
        /*0x72dcbd0*/ void _ResetGameSpeed();
        /*0x72dd6d4*/ void _UpdateGameSpeed();
        /*0x72dcc7c*/ void _FrameStepping();
        /*0x72dd824*/ void _Close();
        /*0x72dcd30*/ void _ResetApplication();
        /*0x72dd830*/ void _OnFinishTransitionToInitialScene();
        /*0x72dd844*/ System.Collections.IEnumerator _OnFinishTransitionToInitialSceneRoutine();
        /*0x72dcde4*/ void _CaptureScreenshot();
        /*0x72dd8d8*/ void _ShowNoaDebugger();
        /*0x72dcf08*/ System.Collections.IEnumerator CaptureScreenshotCoroutine(System.Action<System.Byte[]> callback);
        /*0x72ddb0c*/ void <.ctor>b__70_0();

        struct CustomActionSettings
        {
            /*0x10*/ System.Action _onTap;
            /*0x18*/ System.Func<string> _onTapMessageFunc;
            /*0x20*/ System.Action _onLongPress;
            /*0x28*/ System.Func<string> _onLongPressMessageFunc;
            /*0x30*/ System.Action<bool> _onToggle;
            /*0x38*/ System.Func<bool, string> _onToggleMessageFunc;
            /*0x40*/ NoaDebugger.NoaController.CustomActionType _actionType;
        }

        class <>c
        {
            static /*0x0*/ NoaDebugger.NoaControllerManager.<> <>9;
            static /*0x8*/ System.Func<bool, string> <>9__51_0;

            static /*0x72ddbb0*/ <>c();
            /*0x72ddc18*/ <>c();
            /*0x72ddc20*/ string <SetCustomToggleAction>b__51_0(bool _);
        }

        class <>c__DisplayClass74_0
        {
            /*0x10*/ NoaDebugger.NoaControllerManager <>4__this;
            /*0x18*/ int buttonIndex;

            /*0x72dd23c*/ <>c__DisplayClass74_0();
            /*0x72ddc28*/ void <_SetCustomTapAction>b__0();
        }

        class <>c__DisplayClass76_0
        {
            /*0x10*/ NoaDebugger.NoaControllerManager <>4__this;
            /*0x18*/ int buttonIndex;

            /*0x72dd400*/ <>c__DisplayClass76_0();
            /*0x72ddc48*/ void <_SetCustomLongPressAction>b__0();
        }

        class <>c__DisplayClass78_0
        {
            /*0x10*/ System.Action<bool> action;
            /*0x18*/ NoaDebugger.NoaControllerManager <>4__this;
            /*0x20*/ int buttonIndex;

            /*0x72dd554*/ <>c__DisplayClass78_0();
            /*0x72ddc68*/ void <_SetCustomToggleAction>b__0(bool isOn);
        }

        class <CaptureScreenshotCoroutine>d__102 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.NoaControllerManager <>4__this;
            /*0x28*/ System.Action<System.Byte[]> callback;
            /*0x30*/ NoaDebugger.NoaDebuggerVisibilityManager.ScreenshotUIVisibilityManager <screenshotUIVisibilityManager>5__2;

            /*0x72dd9d4*/ <CaptureScreenshotCoroutine>d__102(int <>1__state);
            /*0x72ddcb4*/ void System.IDisposable.Dispose();
            /*0x72ddcb8*/ bool MoveNext();
            /*0x72ddefc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72ddf04*/ void System.Collections.IEnumerator.Reset();
            /*0x72ddf3c*/ object System.Collections.IEnumerator.get_Current();
        }

        class <_OnFinishTransitionToInitialSceneRoutine>d__99 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.NoaControllerManager <>4__this;

            /*0x72dd8b0*/ <_OnFinishTransitionToInitialSceneRoutine>d__99(int <>1__state);
            /*0x72ddf44*/ void System.IDisposable.Dispose();
            /*0x72ddf48*/ bool MoveNext();
            /*0x72de068*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72de070*/ void System.Collections.IEnumerator.Reset();
            /*0x72de0a8*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class NoaDebugger : UnityEngine.MonoBehaviour
    {
        static int TOOL_DETAIL_ACTIVE_INDEX = -1;
        static /*0x0*/ string DeviceOrientationKey;
        static /*0x8*/ NoaDebugger.NoaDebugger _instance;
        /*0x20*/ NoaDebugger.NoaDebuggerView _mainView;
        /*0x28*/ UnityEngine.Transform _presenterRoot;
        /*0x30*/ NoaDebugger.INoaDebuggerTool[] _allNoaDebuggerTools;
        /*0x38*/ NoaDebugger.INoaDebuggerTool[] _filteredNoaDebuggerTools;
        /*0x40*/ NoaDebugger.INoaDebuggerTool[] _noaDebuggerTools;
        /*0x48*/ System.Collections.Generic.List<string> _initializedNoaDebuggerToolNames;
        /*0x50*/ int _activeToolIndex;
        /*0x54*/ int _lastActiveToolIndex;
        /*0x58*/ bool _isSearchingToolWithoutError;
        /*0x60*/ NoaDebugger.ToolDetailPresenter _toolDetailPresenter;
        /*0x68*/ NoaDebugger.INoaDebuggerTool[] _allCustomNoaDebuggerTools;
        /*0x70*/ System.Collections.Generic.List<System.Type> _customMenuType;
        /*0x78*/ NoaDebugger.SafeAreaAdjuster _safeAreaRoot;
        /*0x80*/ UnityEngine.GameObject _floatingWindowRoot;
        /*0x88*/ UnityEngine.Transform _dialogRoot;
        /*0x90*/ UnityEngine.Transform _toastRoot;
        /*0x98*/ NoaDebugger.ToastView _toastPrefab;
        /*0xa0*/ NoaDebugger.ToastView _toastInstance;
        /*0xa8*/ NoaDebugger.OverlayManager _overlayManager;
        /*0xb0*/ NoaDebugger.NoaUIElementManager _noaUIElementManager;
        /*0xb8*/ NoaDebugger.RuntimeVersionChecker _runtimeVersionChecker;
        /*0xc0*/ UnityEngine.Transform _managerRoot;
        /*0xc8*/ bool _isShowCustomTab;
        /*0xc9*/ bool _isPortrait;
        /*0xd0*/ UnityEngine.RectTransform _rectTransform;
        /*0xd8*/ UnityEngine.Canvas _canvas;
        /*0xe0*/ UnityEngine.UI.CanvasScaler _canvasScaler;
        /*0xe8*/ NoaDebugger.ShortcutActionHandler _shortcutActionHandler;
        /*0xf0*/ System.Action<int> <OnShow>k__BackingField;
        /*0xf8*/ System.Action<int> <OnHide>k__BackingField;
        /*0x100*/ bool <IsInitialized>k__BackingField;
        /*0x108*/ System.Action<int, bool> _onMenuChanged;

        static /*0x72e13a4*/ NoaDebugger();
        static /*0x72de194*/ UnityEngine.Transform get_MainViewRoot();
        static /*0x72de200*/ UnityEngine.Transform get_FloatingWindowRoot();
        static /*0x72de26c*/ UnityEngine.Transform get_DialogRoot();
        static /*0x72de2d0*/ NoaDebugger.ToastView get_ToastInstance();
        static /*0x72de334*/ UnityEngine.Transform get_UIElementRoot();
        static /*0x72de3a0*/ UnityEngine.Transform get_OverlayRoot();
        static /*0x72e0720*/ bool IsShowTargetToolMainView(NoaDebugger.INoaDebuggerTool tool);
        static /*0x72e07f8*/ void ShowNoaDebugger(int index, System.Nullable<bool> isCustomMenu);
        static /*0x72dd93c*/ void ShowNoaDebuggerLastActiveTool();
        static /*0x72d1e3c*/ void ShowToast(NoaDebugger.ToastViewLinker linker);
        static /*0x3907c14*/ TPresenter GetPresenter<TPresenter>();
        static /*0x72e06bc*/ NoaDebugger.INoaDebuggerTool[] AllPresenters();
        static /*0x72e0a2c*/ NoaDebugger.INoaDebuggerTool[] AllCustomPresenters();
        static /*0x38358cc*/ void OnChangeNotificationStatus<TPresenter>();
        static /*0x72c9c2c*/ bool get_IsErrorNotice();
        static /*0x72e0a90*/ bool IsInternalError(string stackTrace);
        static /*0x72e0b88*/ bool ContainsCustomClassNameByText(string text);
        /*0x72e139c*/ NoaDebugger();
        /*0x72de0b0*/ System.Action<int> get_OnShow();
        /*0x72de0b8*/ void set_OnShow(System.Action<int> value);
        /*0x72de0c0*/ System.Action<int> get_OnHide();
        /*0x72de0c8*/ void set_OnHide(System.Action<int> value);
        /*0x72de0d0*/ bool get_IsInitialized();
        /*0x72de0d8*/ void set_IsInitialized(bool value);
        /*0x72de0e4*/ bool get_IsShortcutsEnabled();
        /*0x72de100*/ bool get_IsWorldSpaceRenderingEnabled();
        /*0x72de18c*/ NoaDebugger.NoaUIElementManager get_NoaUIElementManager();
        /*0x72de40c*/ void Awake();
        /*0x72de4cc*/ System.Action<int, bool> get_OnMenuChanged();
        /*0x72de4d4*/ void set_OnMenuChanged(System.Action<int, bool> value);
        /*0x72de4e4*/ void Init();
        /*0x72de4e8*/ void _Init();
        /*0x72df83c*/ void _InitNoaDebuggerTools();
        /*0x72dfc84*/ void _DestroyNoaDebugger();
        /*0x72dfeb8*/ void _OnDeviceOrientation(bool isPortrait);
        /*0x72debd0*/ NoaDebugger.INoaDebuggerTool[] _FindNoaDebuggerTools();
        /*0x72df01c*/ NoaDebugger.INoaDebuggerTool[] _FindCustomNoaDebuggerTools();
        /*0x72dff40*/ void _ChangeTool(int index, bool isMenuActive, bool isChangeMenu);
        /*0x72e014c*/ void _HideTool(int index);
        /*0x72e0234*/ void _ChangeToolButton(int index);
        /*0x72e0240*/ void _ShowToolDetail();
        /*0x72e034c*/ void CloseNoaDebugger();
        /*0x72e0394*/ void _SetLastActiveToolIndex();
        /*0x380b6a0*/ int _GetTargetToolIndex<T>();
        /*0x72e04bc*/ void _PinFloatingWindowTool();
        /*0x72e05e0*/ void _ShowController();
        /*0x72e063c*/ void _ChangeTab(bool isShowCustomTab);
        /*0x72e0470*/ void _SwitchShowTools(bool isShowCustom);
        /*0x72df41c*/ void _UpdateNoaDebuggerTools();
        /*0x72e06b0*/ void _SwitchNoaDebuggerTools();
        /*0x72e06a4*/ void _SwitchCustomNoaDebuggerTools();
        /*0x72e0594*/ NoaDebugger.INoaDebuggerTool _CurrentTool();
        /*0x72e0090*/ int _GetToolIndexAfterValidation(int index);
        /*0x72dfe5c*/ void _DisableNoaDebugger();
        /*0x72e0070*/ System.Collections.Generic.List<NoaDebugger.CustomMenuInfo> GetCustomMenuInfo();
        /*0x72e0d78*/ void SetOverlayEnabled(NoaDebugger.NoaDebug.OverlayFeatures feature, bool isEnabled);
        /*0x72e0e8c*/ bool GetOverlayEnabled(NoaDebugger.NoaDebug.OverlayFeatures feature);
        /*0x72e0f4c*/ void SetShortcutsEnabled(bool isEnabled);
        /*0x72e0fd4*/ void EnableWorldSpaceRendering(UnityEngine.Camera worldCamera);
        /*0x72e1090*/ void DisableWorldSpaceRendering();
        /*0x72e11ac*/ void Dispose();

        class <>c
        {
            static /*0x0*/ NoaDebugger.NoaDebugger.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.INoaDebuggerTool, bool> <>9__99_0;

            static /*0x72e1410*/ <>c();
            /*0x72e1478*/ <>c();
            /*0x72e1480*/ bool <get_IsErrorNotice>b__99_0(NoaDebugger.INoaDebuggerTool tool);
        }

        class <>c__DisplayClass103_0
        {
            /*0x10*/ NoaDebugger.NoaDebugger <>4__this;
            /*0x18*/ NoaDebugger.INoaDebuggerOverlayTool overlayTool;

            /*0x72e152c*/ <>c__DisplayClass103_0();
            /*0x72e1534*/ void <SetOverlayEnabled>b__0();
        }

        class <>c__DisplayClass84_0
        {
            /*0x10*/ NoaDebugger.MenuInfo menuSetting;

            /*0x72e1584*/ <>c__DisplayClass84_0();
            /*0x72e158c*/ bool <_UpdateNoaDebuggerTools>b__0(NoaDebugger.INoaDebuggerTool tool);
        }
    }

    class NoaDebuggerButtonEffectManager : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.NoaDebuggerButton _noaDebuggerButton;
        /*0x28*/ NoaDebugger.NoaDebuggerButtonInController _buttonInController;
        /*0x30*/ bool _isInitialized;

        /*0x72e190c*/ NoaDebuggerButtonEffectManager();
        /*0x72e16c0*/ NoaDebugger.NoaDebuggerButton get_NoaDebuggerButton();
        /*0x72e16c8*/ void Init();
        /*0x72e1710*/ void _OnValidateUI();
        /*0x72e1714*/ void PlayOnErrorAnimation();
        /*0x72e1808*/ void PlayOnLocationAnimation();
        /*0x72e1838*/ void ResetButtonColor();
        /*0x72e1874*/ bool IsPlayingAnimation();
        /*0x72e18b0*/ void Dispose();
    }

    class NoaDebuggerDefine
    {
        static NoaDebugger.ButtonPosition DEFAULT_START_BUTTON_POSITION = 5;
        static float DEFAULT_START_BUTTON_SCALE = 1;
        static NoaDebugger.ButtonMovementType DEFAULT_START_BUTTON_MOVEMENT_TYPE = 0;
        static bool DEFAULT_SAVE_START_BUTTON_POSITION = true;
        static float DEFAULT_TOOL_START_BUTTON_ALPHA = 0.6000000238418579;
        static float DEFAULT_CANVAS_ALPHA = 0.699999988079071;
        static float DEFAULT_CONTROLLER_BACKGROUND_ALPHA = 0.699999988079071;
        static int DEFAULT_NOA_DEBUGGER_CANVAS_SORT_ORDER = 1000;
        static bool DEFAULT_IS_UI_REVERSE_PORTRAIT = true;
        static bool DEFAULT_IS_SHOW_SIDE_MENU_CLOSE_BUTTON = true;
        static int DEFAULT_CONSOLE_LOG_COUNT = 999;
        static int DEFAULT_API_LOG_COUNT = 999;
        static bool DEFAULT_AUTO_CREATE_EVENT_SYSTEM = true;
        static NoaDebugger.ErrorNotificationType DEFAULT_ERROR_NOTIFICATION_TYPE = 0;
        static bool DEFAULT_AUTO_INITIALIZE = true;
        static bool DEFAULT_IS_CUSTOM_FONT_SETTINGS_ENABLED = false;
        static float DEFAULT_FONT_SIZE_RATE = 1;
        static int DEFAULT_HIERARCHY_LEVELS = 3;
        static NoaDebugger.DebugCommand.CommandDisplayFormat DEFAULT_COMMAND_FORMAT_LANDSCAPE = 0;
        static NoaDebugger.DebugCommand.CommandDisplayFormat DEFAULT_COMMAND_FORMAT_PORTRAIT = 1;
        static float DEFAULT_OVERLAY_BACKGROUND_OPACITY = 0.6000000238418579;
        static bool DEFAULT_OVERLAY_SAFE_AREA_APPLICABLE = true;
        static int DEFAULT_OVERLAY_PADDING_X = 0;
        static int DEFAULT_OVERLAY_PADDING_Y = 0;
        static NoaDebugger.NoaDebug.OverlayPosition DEFAULT_PROFILER_OVERLAY_POSITION = 2;
        static float DEFAULT_PROFILER_OVERLAY_SCALE = 1;
        static NoaDebugger.NoaProfiler.OverlayAxis DEFAULT_PROFILER_OVERLAY_AXIS = 1;
        static NoaDebugger.NoaDebug.OverlayPosition DEFAULT_LOG_OVERLAY_POSITION = 0;
        static float DEFAULT_LOG_OVERLAY_FONT_SCALE = 1;
        static int DEFAULT_LOG_OVERLAY_MAXIMUM_LOG_COUNT = 10;
        static float DEFAULT_LOG_OVERLAY_MINIMUM_OPACITY = 0.5;
        static float DEFAULT_LOG_OVERLAY_ACTIVE_DURATION = 3;
        static bool DEFAULT_LOG_OVERLAY_SHOW_TIMESTAMP = true;
        static bool DEFAULT_LOG_OVERLAY_SHOW_LOGS = false;
        static bool DEFAULT_UI_ELEMENT_SAFE_AREA_APPLICABLE = true;
        static int DEFAULT_UI_ELEMENT_PADDING_X = 0;
        static int DEFAULT_UI_ELEMENT_PADDING_Y = 0;
        static float DEFAULT_GAME_SPEED = 1;
        static float MIN_GAME_SPEED = 0.10000000149011612;
        static bool DEFAULT_GAME_SPEED_CHANGE_APPLICABLE = true;
        static float DEFAULT_GAME_SPEED_INCREMENT = 1;
        static float MIN_GAME_SPEED_INCREMENT = 0.10000000149011612;
        static float MAX_GAME_SPEED_INCREMENT = 1;
        static float DEFAULT_MAX_GAME_SPEED = 3;
        static float MIN_CONFIGURABLE_MAX_GAME_SPEED = 1;
        static float MAX_CONFIGURABLE_MAX_GAME_SPEED = 5;
        static int GAME_SPEED_SETTINGS_SIGNIFICANT_FRACTIONAL_DIGITS = 1;
        static bool DEFAULT_AUTO_SAVE = true;
        static bool DEFAULT_ENABLE_ALL_SHORTCUTS = true;
        static int NUMERIC_INPUT_DRAG_SENSITIVITY = 2;
        static string MISSING_VALUE = "Not Supported";
        static int INFORMATION_MENU_SORT_NO = 0;
        static int PROFILER_MENU_SORT_NO = 1;
        static int SNAPSHOT_MENU_SORT_NO = 2;
        static int CONSOLE_LOG_MENU_SORT_NO = 3;
        static int API_LOG_MENU_SORT_NO = 4;
        static int HIERARCHY_MENU_SORT_NO = 5;
        static int COMMAND_MENU_SORT_NO = 6;
        static int CUSTOM_MENU_SORT_NO = 0;
        static /*0x0*/ char[] NewLine;
        static /*0x8*/ string InternalErrorStacktraceRegexPattern;
        static /*0x10*/ string DebugCommandInvocationStacktraceRegexPattern;
        static /*0x18*/ string RootObjectName;
        static /*0x20*/ string EditorPrefsKeyPackageSettingsData;
        static /*0x28*/ float StartButtonScaleMin;
        static /*0x2c*/ float StartButtonScaleMax;
        static /*0x30*/ float ToolStartButtonAlphaMin;
        static /*0x34*/ float ToolStartButtonAlphaMax;
        static /*0x38*/ float CanvasAlphaMin;
        static /*0x3c*/ float CanvasAlphaMax;
        static /*0x40*/ float InformationAutoRefreshInterval;
        static /*0x44*/ int ProfilerChartHistoryCount;
        static /*0x48*/ string[] VSyncCountChoices;
        static /*0x50*/ int MaxNumberOfMatchingLogsToDisplay;
        static /*0x54*/ int ConsoleLogCountMin;
        static /*0x58*/ int ConsoleLogCountMax;
        static /*0x5c*/ int ConsoleLogSummaryStringLengthMax;
        static /*0x60*/ string UnavaliableStackTraceLabel;
        static /*0x68*/ int ApiLogCountMin;
        static /*0x6c*/ int ApiLogCountMax;
        static /*0x70*/ int SnapshotLogMaxLabelCharNum;
        static /*0x74*/ float PressTimeSeconds;
        static /*0x78*/ int PressActionIntervalChangeCount;
        static /*0x7c*/ float PressActionFirstInterval;
        static /*0x80*/ float PressActionSecondInterval;
        static /*0x84*/ float DragThresholdDistanceOnScreen;
        static /*0x88*/ int HierarchyLevelsMin;
        static /*0x8c*/ int HierarchyLevelsMax;
        static /*0x90*/ float DebugCommandAutoRefreshInterval;
        static /*0x94*/ bool DefaultOverlayEnabled;
        static /*0x98*/ float OverlayBackgroundOpacityMin;
        static /*0x9c*/ float OverlayBackgroundOpacityMax;
        static /*0xa0*/ float ProfilerOverlayScaleMin;
        static /*0xa4*/ float ProfilerOverlayScaleMax;
        static /*0xa8*/ float ProfilerOverlayScaleIncrement;
        static /*0xac*/ bool DefaultProfilerOverlayFeatureEnabled;
        static /*0xb0*/ NoaDebugger.NoaProfiler.OverlayTextType DefaultProfilerOverlayTextType;
        static /*0xb4*/ bool DefaultProfilerOverlayGraphEnabled;
        static /*0xb8*/ float LogOverlayFontScaleMin;
        static /*0xbc*/ float LogOverlayFontScaleMax;
        static /*0xc0*/ float LogOverlayFontScaleIncrement;
        static /*0xc4*/ int LogOverlayMaximumLogCountMin;
        static /*0xc8*/ int LogOverlayMaximumLogCountMax;
        static /*0xcc*/ int LogOverlayMaximumLogCountIncrement;
        static /*0xd0*/ float LogOverlayMinimumOpacityMin;
        static /*0xd4*/ float LogOverlayMinimumOpacityMax;
        static /*0xd8*/ float LogOverlayMinimumOpacityIncrement;
        static /*0xdc*/ float LogOverlayActiveDurationMin;
        static /*0xe0*/ float LogOverlayActiveDurationMax;
        static /*0xe4*/ float LogOverlayActiveDurationIncrement;
        static /*0xe8*/ string SupportedValue;
        static /*0xf0*/ string HyphenValue;
        static /*0xf8*/ char NoHasFontAssetReplacementCharacter;
        static /*0x100*/ string ClipboardCopiedText;
        static /*0x108*/ string ClipboardCopyFailedText;
        static /*0x110*/ string DownloadCompletedText;
        static /*0x118*/ string DownloadCanceledText;
        static /*0x120*/ string DownloadFailedText;
        static /*0x128*/ string DeleteSaveDataText;
        static /*0x130*/ string ShowErrorText;
        static /*0x138*/ string CaptureScreenshotText;
        static /*0x140*/ string SentText;
        static /*0x148*/ string HideNoaDebuggerUIText;
        static /*0x150*/ string TapCustomActionText;
        static /*0x158*/ string LongPressCustomActionText;
        static /*0x160*/ string ToggledOnCustomActionText;
        static /*0x168*/ string ToggledOffCustomActionText;
        static /*0x170*/ string TransitionToInitialSceneText;
        static /*0x178*/ string CustomApplicationResetText;
        static /*0x180*/ string UnmarkedSnapshotCategoryNameToSetAdditionalInfo;
        static /*0x188*/ string[] SnapshotDuplicateCategoryNames;
        static /*0x190*/ string[] SnapshotDownloadLogInfoLabels;
        static /*0x198*/ string SnapshotDuplicateCategoryNamePrefix;
        static /*0x1a0*/ char DecimalPoint;
        static /*0x1a4*/ int ShortcutInvalidKey;
        static /*0x1a8*/ NoaDebugger.ShortcutActionType[] SortedShortcutActionType;

        static /*0x72e1978*/ NoaDebuggerDefine();
        static /*0x72e1914*/ string get_Ellipsis();
        static /*0x72e1954*/ NoaDebugger.NoaDebuggerDefine.ShortCutTriggerType GetTriggerType(NoaDebugger.ShortcutActionType actionType);

        enum ShortCutTriggerType
        {
            ShortPress = 1,
            LongPress = 2,
            HoldDown = 4,
            ShortAndLongPress = 3,
            ShortAndHoldDown = 5,
        }

        struct TextColors
        {
            static /*0x0*/ UnityEngine.Color Default;
            static /*0x10*/ UnityEngine.Color Success;
            static /*0x20*/ UnityEngine.Color Warning;
            static /*0x30*/ UnityEngine.Color Dynamic;
            static /*0x40*/ UnityEngine.Color InProgress;
            static /*0x50*/ UnityEngine.Color ProfilerFps;
            static /*0x60*/ UnityEngine.Color ProfilerMemory;
            static /*0x70*/ UnityEngine.Color ProfilerRendering;
            static /*0x80*/ UnityEngine.Color LogGray;
            static /*0x90*/ UnityEngine.Color LogLightBlue;
            static /*0xa0*/ UnityEngine.Color LogOrange;
            static /*0xb0*/ UnityEngine.Color LogYellow;
            static /*0xc0*/ UnityEngine.Color LogBlue;
            static /*0xd0*/ UnityEngine.Color LogPurple;
            static /*0xe0*/ UnityEngine.Color LogGreen;
            static /*0xf0*/ UnityEngine.Color LogRed;
            static /*0x100*/ string StackTraceColorCode;

            static /*0x72e2330*/ TextColors();
        }

        struct ImageColors
        {
            static /*0x0*/ UnityEngine.Color Default;
            static /*0x10*/ UnityEngine.Color Disabled;
            static /*0x20*/ UnityEngine.Color Clear;
            static /*0x30*/ UnityEngine.Color Warning;
            static /*0x40*/ UnityEngine.Color SnapshotFirstSelected;
            static /*0x50*/ UnityEngine.Color SnapshotSecondSelected;

            static /*0x72e2494*/ ImageColors();
        }

        struct BackgroundColors
        {
            static /*0x0*/ UnityEngine.Color NoaDebuggerButtonAlert;
            static /*0x10*/ UnityEngine.Color NoaDebuggerButtonDefault;
            static /*0x20*/ UnityEngine.Color NoaDebuggerButtonInControllerDefault;
            static /*0x30*/ UnityEngine.Color LogBright;
            static /*0x40*/ UnityEngine.Color LogDark;
            static /*0x50*/ UnityEngine.Color LogBrown;
            static /*0x60*/ UnityEngine.Color LogDarkBrown;
            static /*0x70*/ UnityEngine.Color LogGreen;
            static /*0x80*/ UnityEngine.Color LogLightBlue;
            static /*0x90*/ UnityEngine.Color LogDarkPurple;
            static /*0xa0*/ UnityEngine.Color LogBlack;
            static /*0xb0*/ UnityEngine.Color LogDarkGreen;
            static /*0xc0*/ UnityEngine.Color LogYellowGreen;
            static /*0xd0*/ UnityEngine.Color LogBlue;
            static /*0xe0*/ UnityEngine.Color LogPurple;

            static /*0x72e2534*/ BackgroundColors();
        }

        enum LogType
        {
            Error = 0,
            Warning = 1,
            Log = 2,
        }

        struct LogColors
        {
            static /*0x0*/ UnityEngine.Color LogError;
            static /*0x10*/ UnityEngine.Color LogWarning;
            static /*0x20*/ UnityEngine.Color LogMessage;

            static /*0x72e2668*/ LogColors();
        }
    }

    enum ErrorNotificationType
    {
        Full = 0,
        Flashing = 1,
        None = 2,
    }

    class NoaDebuggerInfo : UnityEngine.ScriptableObject
    {
        /*0x18*/ string _noaDebuggerVersion;
        /*0x20*/ string _minimumUnityVersion;
        /*0x28*/ string _minimumUnityVersionForMobileBrowser;
        /*0x30*/ string _minimumIOSVersion;
        /*0x38*/ string _minimumAndroidVersion;
        /*0x40*/ string _minimumWindowsVersion;
        /*0x48*/ NoaDebugger.SupportBrowserInfo[] _supportedPCBrowsersInfo;
        /*0x50*/ NoaDebugger.SupportBrowserInfo[] _supportedMobileBrowsersInfo;
        /*0x58*/ UnityEngine.TextAsset _packageInfo;
        /*0x60*/ string _noaDebuggerCopyright;

        static /*0x72e2828*/ int CompareVersions(string version1, string version2);
        /*0x72e2a90*/ NoaDebuggerInfo();
        /*0x72e26dc*/ void OnValidate();
        /*0x72e27c4*/ string get_NoaDebuggerVersion();
        /*0x72e27cc*/ string get_MinimumUnityVersion();
        /*0x72e27d4*/ string get_MinimumUnityVersionForMobileBrowser();
        /*0x72e27dc*/ string get_MinimumIOSVersion();
        /*0x72e27e4*/ string get_MinimumAndroidVersion();
        /*0x72e27ec*/ string get_MinimumWindowsVersion();
        /*0x72e27f4*/ NoaDebugger.SupportBrowserInfo[] get_SupportedPCBrowsersInfo();
        /*0x72e27fc*/ NoaDebugger.SupportBrowserInfo[] get_SupportedMobileBrowsersInfo();
        /*0x72e2804*/ string get_NoaDebuggerCopyright();
        /*0x72e280c*/ bool IsSupportedUnityVersion(string version);
        /*0x72e287c*/ bool IsSupportedIOSVersion(string version);
        /*0x72e2898*/ bool IsSupportedAndroidVersion(string version);
        /*0x72e28b4*/ bool IsSupportedWindowsVersion(string version);
        /*0x72e28d0*/ bool IsSupportedBrowser(string browser, string operatingSystem, string unityVersion);
        /*0x72e29a0*/ bool _IsSupportedBrowser(string browser, string operatingSystem, NoaDebugger.SupportBrowserInfo[] supportedBrowsersInfo);

        struct UnityPackageInfo
        {
            /*0x10*/ string version;
            /*0x18*/ string unity;
        }
    }

    class SupportBrowserInfo
    {
        /*0x10*/ string[] _operatingSystemPrefixList;
        /*0x18*/ string _displayOperatingSystem;
        /*0x20*/ string _browser;

        /*0x72e2ab0*/ SupportBrowserInfo();
        /*0x72e2a98*/ string[] get_OperatingSystemPrefixList();
        /*0x72e2aa0*/ string get_DisplayOperatingSystem();
        /*0x72e2aa8*/ string get_Browser();
    }

    class NoaDebuggerInfoManager
    {
        static string TOOL_INFORMATION_ASSET_NAME = "NoaDebuggerInfo";
        static /*0x0*/ NoaDebugger.NoaDebuggerInfoManager _instance;
        /*0x10*/ NoaDebugger.NoaDebuggerInfo _noaDebuggerInfo;

        static /*0x72e2ab8*/ NoaDebugger.NoaDebuggerInfoManager get_Instance();
        static /*0x72e2b48*/ NoaDebugger.NoaDebuggerInfo GetNoaDebuggerInfo();
        static /*0x72e2c10*/ void Dispose();
        /*0x72e2b40*/ NoaDebuggerInfoManager();
        /*0x72e2b60*/ NoaDebugger.NoaDebuggerInfo _GetNoaDebuggerInfo();
    }

    class NoaDebuggerManager
    {
        static /*0x0*/ string PrefabPath;
        static /*0x8*/ string ErrorObserverKey;
        static /*0x10*/ string MonitorFontOnUpdateKey;
        static /*0x18*/ NoaDebugger.NoaDebugger _noaDebugger;
        static /*0x20*/ NoaDebugger.NoaDebuggerManager _instance;
        static /*0x28*/ int <MainThreadId>k__BackingField;
        /*0x10*/ bool _isError;
        /*0x11*/ bool _isInitializedOnce;
        /*0x18*/ NoaDebugger.NoaDebuggerButton _noaDebuggerButton;
        /*0x20*/ NoaDebugger.NoaDebuggerButtonEffectManager _buttonEffectManager;
        /*0x28*/ System.Action<int> _onShow;
        /*0x30*/ System.Action<int> _onHide;
        /*0x38*/ System.Action<int, bool> _onMenuChanged;

        static /*0x72e5648*/ NoaDebuggerManager();
        static /*0x72e2c64*/ System.Action<int> get_OnShow();
        static /*0x72e2cc8*/ void set_OnShow(System.Action<int> value);
        static /*0x72e2d34*/ System.Action<int> get_OnHide();
        static /*0x72e2d98*/ void set_OnHide(System.Action<int> value);
        static /*0x72e2e04*/ System.Action<int, bool> get_OnMenuChanged();
        static /*0x72e2e68*/ void set_OnMenuChanged(System.Action<int, bool> value);
        static /*0x72e2ed4*/ UnityEngine.Transform get_RootTransform();
        static /*0x72e302c*/ bool get_IsShortcutsEnabled();
        static /*0x72e30b8*/ bool get_IsWorldSpaceRenderingEnabled();
        static /*0x72e3144*/ UnityEngine.Transform get_MainViewRootTransform();
        static /*0x72e31d0*/ UnityEngine.Transform get_OverlayRootTransform();
        static /*0x72e325c*/ UnityEngine.Transform get_FloatingWindowRootTransform();
        static /*0x72e32e8*/ UnityEngine.Transform get_DialogRootTransform();
        static /*0x72e3374*/ UnityEngine.Transform get_UIElementRootTransform();
        static /*0x72e3400*/ int get_MainThreadId();
        static /*0x72e3458*/ void set_MainThreadId(int value);
        static /*0x72e34b4*/ void _Instantiate();
        static /*0x72e3a90*/ void _CloseNoaDebugger();
        static /*0x3837458*/ void OnChangeNotificationStatus<TPresenter>(NoaDebugger.ToolNotificationStatus notifyStatus);
        static /*0x72e3b94*/ void DetectError();
        static /*0x72e3c18*/ void InitializeDebugger(System.Action onInitComplete);
        static /*0x72e3dc4*/ void ShowDebugger(System.Nullable<int> index, System.Nullable<bool> isCustomMenu);
        static /*0x72e4038*/ void ShowDebugger(NoaDebugger.NoaDebug.MenuType menuType);
        static /*0x72e4110*/ NoaDebugger.MenuInfo _GetMenuInfoByMenuType(NoaDebugger.NoaDebug.MenuType menuType);
        static /*0x72e4250*/ void _ShowDebugger(System.Nullable<int> index, System.Nullable<bool> isCustomMenu);
        static /*0x72e437c*/ void HideDebugger();
        static /*0x72e442c*/ void SetOverlayEnabled(NoaDebugger.NoaDebug.OverlayFeatures feature, bool isEnabled);
        static /*0x72e4510*/ bool GetOverlayEnabled(NoaDebugger.NoaDebug.OverlayFeatures feature);
        static /*0x72e45e4*/ void SetFont(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material fontMaterial, float fontSizeRate);
        static /*0x72e484c*/ void _MonitorFontOnUpdate();
        static /*0x72e4728*/ void _ApplyFontToInstantiatedObjects();
        static /*0x72e48c0*/ void SetShortcutsEnabled(bool isEnabled);
        static /*0x72e4950*/ void EnableWorldSpaceRendering(UnityEngine.Camera worldCamera);
        static /*0x72e49e0*/ void DisableWorldSpaceRendering();
        static /*0x72e4a68*/ void CopyToClipboard(string text);
        static /*0x72e4b40*/ void DownloadText(string text, string fileName, string mimeType);
        static /*0x72e4bdc*/ void DestroyDebugger();
        static /*0x72e2f60*/ bool IsDebuggerInitialized();
        static /*0x72e4dd0*/ bool IsError();
        static /*0x72e4e34*/ void RunOnShow(int index);
        static /*0x72e4eac*/ void RunOnHide(int index);
        static /*0x72e4f24*/ void RunOnMenuChanged(int index, bool isCustomMenu);
        static /*0x72e4fb0*/ NoaDebugger.INoaUIElementView[] GetAllUIElements();
        static /*0x72e50a4*/ void RegisterUIElement(NoaDebugger.INoaUIElement element);
        static /*0x72e513c*/ void UnregisterUIElement(string key);
        static /*0x72e51d4*/ void UnregisterAllUIElements();
        static /*0x72e5264*/ bool IsUIElementRegistered(string key);
        static /*0x72e5300*/ void SetUIElementVisibility(string key, bool visible);
        static /*0x72e53ac*/ bool IsUIElementVisible(string key);
        static /*0x72e5510*/ void SetVerticalAlignment(NoaDebugger.AnchorType anchorType);
        static /*0x72e55a8*/ void SetHorizontalAlignment(NoaDebugger.AnchorType anchorType);
        /*0x72e5640*/ NoaDebuggerManager();
        /*0x72e3670*/ void _Init();
        /*0x72e3994*/ void _ErrorObserver();
        /*0x72e3af4*/ void _HandleException(string logString, string stackTrace, UnityEngine.LogType type);

        class InitializeNoaDebuggerBehaviour : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ System.Action <OnInitComplete>k__BackingField;

            static /*0x72e570c*/ System.Action get_OnInitComplete();
            static /*0x72e5754*/ void set_OnInitComplete(System.Action value);
            /*0x72e5860*/ InitializeNoaDebuggerBehaviour();
            /*0x72e57ac*/ void Awake();
            /*0x72e57cc*/ System.Collections.IEnumerator _Init();

            class <_Init>d__5 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ NoaDebugger.NoaDebuggerManager.InitializeNoaDebuggerBehaviour <>4__this;

                /*0x72e5838*/ <_Init>d__5(int <>1__state);
                /*0x72e5868*/ void System.IDisposable.Dispose();
                /*0x72e586c*/ bool MoveNext();
                /*0x72e5a04*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x72e5a0c*/ void System.Collections.IEnumerator.Reset();
                /*0x72e5a44*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class NoaDebuggerDestroyReceiver : UnityEngine.MonoBehaviour
        {
            /*0x72e5a98*/ NoaDebuggerDestroyReceiver();
            /*0x72e5a4c*/ void OnDestroy();
        }

        class <>c__DisplayClass49_0
        {
            /*0x10*/ System.Nullable<int> index;
            /*0x18*/ System.Nullable<bool> isCustomMenu;

            /*0x72e3ee4*/ <>c__DisplayClass49_0();
            /*0x72e3fa4*/ void <ShowDebugger>g__showDebugger|0();
        }

        class <>c__DisplayClass51_0
        {
            /*0x10*/ string targetName;

            /*0x72e4230*/ <>c__DisplayClass51_0();
            /*0x72e5aa0*/ bool <_GetMenuInfoByMenuType>b__0(NoaDebugger.MenuInfo menu);
        }
    }

    class NoaDebuggerPrefs
    {
        static /*0x0*/ string FileName;
        static /*0x8*/ NoaDebugger.NoaDebuggerPrefs _singletonValue;
        /*0x10*/ System.Collections.Generic.Dictionary<string, string> _prefsDictionary;

        static /*0x72e7d20*/ NoaDebuggerPrefs();
        static /*0x72e5b1c*/ NoaDebugger.NoaDebuggerPrefs get_Singleton();
        static /*0x72e655c*/ bool HasKey(string key);
        static /*0x72e65bc*/ System.Collections.Generic.List<string> GetKeyList();
        static /*0x72e6614*/ System.Collections.Generic.List<string> GetKeyListFilterAt(string prefix);
        static /*0x72e6748*/ System.Collections.Generic.List<string> GetKeyListForToolOnly();
        static /*0x72e68bc*/ string GetString(string key, string defaultValue);
        static /*0x72e692c*/ sbyte GetSByte(string key, sbyte defaultValue);
        static /*0x72e69c8*/ byte GetByte(string key, byte defaultValue);
        static /*0x72e6a64*/ short GetShort(string key, short defaultValue);
        static /*0x72e6b00*/ ushort GetUShort(string key, ushort defaultValue);
        static /*0x72e6b9c*/ int GetInt(string key, int defaultValue);
        static /*0x72e6c38*/ uint GetUInt(string key, uint defaultValue);
        static /*0x72e6cd4*/ long GetLong(string key, long defaultValue);
        static /*0x72e6d70*/ ulong GetULong(string key, ulong defaultValue);
        static /*0x72e6e0c*/ char GetChar(string key, char defaultValue);
        static /*0x72e6ec4*/ float GetFloat(string key, float defaultValue);
        static /*0x72e6f94*/ double GetDouble(string key, double defaultValue);
        static /*0x72e7064*/ decimal GetDecimal(string key, decimal defaultValue);
        static /*0x72e7188*/ bool GetBoolean(string key, bool defaultValue);
        static /*0x72e7244*/ void SetString(string key, string value);
        static /*0x72e72b4*/ void SetSByte(string key, sbyte value);
        static /*0x72e733c*/ void SetByte(string key, byte value);
        static /*0x72e73c4*/ void SetShort(string key, short value);
        static /*0x72e744c*/ void SetUShort(string key, ushort value);
        static /*0x72e74d4*/ void SetInt(string key, int value);
        static /*0x72e755c*/ void SetUInt(string key, uint value);
        static /*0x72e75e4*/ void SetLong(string key, long value);
        static /*0x72e766c*/ void SetULong(string key, ulong value);
        static /*0x72e76f4*/ void SetChar(string key, char value);
        static /*0x72e77d0*/ void SetFloat(string key, float value);
        static /*0x72e788c*/ void SetDouble(string key, double value);
        static /*0x72e7948*/ void SetDecimal(string key, decimal value);
        static /*0x72e7a58*/ void SetBoolean(string key, bool value);
        static /*0x72e5ac4*/ void Save();
        static /*0x72e7b00*/ void DeleteAt(string key);
        static /*0x72e7b60*/ void DeleteAllToolData();
        static /*0x72e7cc8*/ void DeleteAll();
        /*0x72e5bdc*/ NoaDebuggerPrefs();
        /*0x72e5e80*/ string get_CachePath();
        /*0x72e5f20*/ string _GetFilePath();
        /*0x72e5c64*/ void _Load();
        /*0x72e6124*/ void _SaveData();
        /*0x72e62b8*/ bool _HasKey(string key);
        /*0x72e6310*/ System.Collections.Generic.List<string> _GetKeyAll();
        /*0x72e637c*/ string _Get(string key, string defaultValue);
        /*0x72e6420*/ void _Set(string key, string value);
        /*0x72e6488*/ void _DeleteAt(string key);
        /*0x72e64e0*/ void _DeleteAll();

        class <>c__DisplayClass19_0
        {
            /*0x10*/ string prefix;

            /*0x72e6740*/ <>c__DisplayClass19_0();
            /*0x72e7d8c*/ bool <GetKeyListFilterAt>b__0(string key);
        }

        class <>c__DisplayClass20_0
        {
            /*0x10*/ string debugCommandPrefix;
            /*0x18*/ string noaPrefsPrefix;

            /*0x72e68b4*/ <>c__DisplayClass20_0();
            /*0x72e7db0*/ bool <GetKeyListForToolOnly>b__0(string key);
        }
    }

    class PrefsDictionary
    {
        /*0x10*/ System.Collections.Generic.List<string> keys;
        /*0x18*/ System.Collections.Generic.List<string> values;

        static /*0x72e617c*/ NoaDebugger.PrefsDictionary Serialize(System.Collections.Generic.Dictionary<string, string> dictionary);
        static /*0x72e5fb4*/ System.Collections.Generic.Dictionary<string, string> Deserialize(NoaDebugger.PrefsDictionary prefsDic);
        /*0x72e7e08*/ PrefsDictionary();
    }

    class NoaDebuggerPrefsBehaviour : UnityEngine.MonoBehaviour
    {
        static /*0x72e7e10*/ void Initialize(UnityEngine.Transform parent);
        /*0x72e7f80*/ NoaDebuggerPrefsBehaviour();
        /*0x72e7ed0*/ void OnApplicationPause(bool pauseStatus);
        /*0x72e7f34*/ void OnApplicationQuit();
    }

    class NoaDebuggerPrefsDefine
    {
        static /*0x0*/ string PrefsKeyStartButtonPortrait;
        static /*0x8*/ string PrefsKeyStartButtonLandscape;
        static /*0x10*/ string PrefsKeyInformationAutoRefresh;
        static /*0x18*/ System.Collections.Generic.KeyValuePair<string, bool> IsFpsProfilingKeyValue;
        static /*0x28*/ System.Collections.Generic.KeyValuePair<string, bool> IsFrameTimeProfilingKeyValue;
        static /*0x38*/ System.Collections.Generic.KeyValuePair<string, bool> IsMemoryProfilingKeyValue;
        static /*0x48*/ System.Collections.Generic.KeyValuePair<string, bool> IsMemoryGraphShowingKeyValue;
        static /*0x58*/ System.Collections.Generic.KeyValuePair<string, NoaDebugger.NoaProfiler.MemoryProfilingType> MemoryProfilingTypeKeyValue;
        static /*0x68*/ System.Collections.Generic.KeyValuePair<string, bool> IsRenderProfilingKeyValue;
        static /*0x78*/ System.Collections.Generic.KeyValuePair<string, bool> IsRenderGraphShowingKeyValue;
        static /*0x88*/ System.Collections.Generic.KeyValuePair<string, NoaDebugger.RenderingGraphTarget> RenderGraphTargetKeyValue;
        static /*0x98*/ string PrefsKeyIsProfilerWindowInfo;
        static /*0xa0*/ string PrefsKeyIsSnapshotWindowInfo;
        static /*0xa8*/ string PrefsKeyIsConsoleLogFilterFlags;
        static /*0xb0*/ string PrefsKeyIsApiLogFilterFlags;
        static /*0xb8*/ string PrefsKeyIsConsoleLogWindowInfo;
        static /*0xc0*/ string PrefsKeyIsApiLogWindowInfo;
        static /*0xc8*/ string PrefsKeyIsTimerWindowInfo;
        static /*0xd0*/ string PrefsKeyIsHierarchyWindowInfo;
        static /*0xd8*/ string PrefsKeyIsDebugCommandWindowInfo;
        static /*0xe0*/ string PrefsKeyLastDebugCommandCategoryName;
        static /*0xe8*/ string PrefsKeyDebugCommandGroupFilter;
        static /*0xf0*/ string PrefsKeyIsConsoleLogCollecting;
        static /*0xf8*/ string PrefsKeyIsApiLogCollecting;
        static /*0x100*/ string PrefsKeyDebugCommandAutoRefresh;
        static /*0x108*/ string PrefsKeySuffixOverlayEnabled;
        static /*0x110*/ string PrefsKeySuffixOverlaySettings;
        static /*0x118*/ string PrefsKeyDebugCommandPropertiesPrefix;
        static /*0x120*/ string PrefsKeyNoaPrefsDataPrefix;
        static /*0x128*/ string PrefsKeyDelimiter;
        static /*0x130*/ string PrefsKeyGameSpeed;

        static /*0x72e7f88*/ NoaDebuggerPrefsDefine();
    }

    class NoaDebuggerSettings : UnityEngine.ScriptableObject
    {
        /*0x18*/ NoaDebugger.ButtonPosition _startButtonPosition;
        /*0x1c*/ float _startButtonScale;
        /*0x20*/ NoaDebugger.ButtonMovementType _startButtonMovementType;
        /*0x24*/ bool _saveStartButtonPosition;
        /*0x28*/ float _toolStartButtonAlpha;
        /*0x2c*/ float _backgroundAlpha;
        /*0x30*/ float _floatingWindowAlpha;
        /*0x34*/ float _controllerBackgroundAlpha;
        /*0x38*/ int _noaDebuggerCanvasSortOrder;
        /*0x3c*/ bool _isUIReversePortrait;
        /*0x3d*/ bool _isShowSideMenuCloseButton;
        /*0x40*/ System.Collections.Generic.List<NoaDebugger.MenuInfo> _menuList;
        /*0x48*/ bool _autoCreateEventSystem;
        /*0x4c*/ NoaDebugger.ErrorNotificationType _errorNotificationType;
        /*0x50*/ bool _autoInitialize;
        /*0x58*/ System.Collections.Generic.List<NoaDebugger.CustomMenuInfo> _customMenuList;
        /*0x60*/ int _consoleLogCount;
        /*0x64*/ int _apiLogCount;
        /*0x68*/ bool _isCustomFontSettingsEnabled;
        /*0x70*/ TMPro.TMP_FontAsset _fontAsset;
        /*0x78*/ UnityEngine.Material _fontMaterial;
        /*0x80*/ float _fontSizeRate;
        /*0x84*/ int _hierarchyLevels;
        /*0x88*/ NoaDebugger.DebugCommand.CommandDisplayFormat _commandFormatLandscape;
        /*0x8c*/ NoaDebugger.DebugCommand.CommandDisplayFormat _commandFormatPortrait;
        /*0x90*/ float _overlayBackgroundOpacity;
        /*0x94*/ bool _appliesOverlaySafeArea;
        /*0x98*/ UnityEngine.Vector2 _overlayPadding;
        /*0xa0*/ NoaDebugger.NoaDebug.OverlayPosition _profilerOverlayPosition;
        /*0xa4*/ float _profilerOverlayScale;
        /*0xa8*/ NoaDebugger.NoaProfiler.OverlayAxis _profilerOverlayAxis;
        /*0xac*/ NoaDebugger.NoaDebug.OverlayPosition _consoleLogOverlayPosition;
        /*0xb0*/ float _consoleLogOverlayFontSize;
        /*0xb4*/ int _consoleLogOverlayMaximumLogCount;
        /*0xb8*/ float _consoleLogOverlayMinimumOpacity;
        /*0xbc*/ float _consoleLogOverlayActiveDuration;
        /*0xc0*/ bool _consoleLogOverlayShowTimestamp;
        /*0xc1*/ bool _consoleLogOverlayShowMessageLogs;
        /*0xc2*/ bool _consoleLogOverlayShowWarningLogs;
        /*0xc3*/ bool _consoleLogOverlayShowErrorLogs;
        /*0xc4*/ NoaDebugger.NoaDebug.OverlayPosition _apiLogOverlayPosition;
        /*0xc8*/ float _apiLogOverlayFontSize;
        /*0xcc*/ int _apiLogOverlayMaximumLogCount;
        /*0xd0*/ float _apiLogOverlayMinimumOpacity;
        /*0xd4*/ float _apiLogOverlayActiveDuration;
        /*0xd8*/ bool _apiLogOverlayShowTimestamp;
        /*0xd9*/ bool _apiLogOverlayShowMessageLogs;
        /*0xda*/ bool _apiLogOverlayShowErrorLogs;
        /*0xdb*/ bool _appliesUIElementSafeArea;
        /*0xdc*/ UnityEngine.Vector2 _uiElementPadding;
        /*0xe4*/ bool _appliesGameSpeedChange;
        /*0xe8*/ float _gameSpeedIncrement;
        /*0xec*/ float _maxGameSpeed;
        /*0xf0*/ bool _enableAllShortcuts;
        /*0xf8*/ System.Collections.Generic.List<NoaDebugger.ShortcutAction> _shortcutActionsOnInputManager;
        /*0x100*/ System.Collections.Generic.List<NoaDebugger.ShortcutAction> _shortcutActions;
        /*0x108*/ bool _autoSave;

        /*0x72e8b9c*/ NoaDebuggerSettings();
        /*0x72e8648*/ NoaDebugger.ButtonPosition get_StartButtonPosition();
        /*0x72e8650*/ void set_StartButtonPosition(NoaDebugger.ButtonPosition value);
        /*0x72e8658*/ float get_StartButtonScale();
        /*0x72e8660*/ void set_StartButtonScale(float value);
        /*0x72e8668*/ NoaDebugger.ButtonMovementType get_StartButtonMovementType();
        /*0x72e8670*/ void set_StartButtonMovementType(NoaDebugger.ButtonMovementType value);
        /*0x72e8678*/ bool get_SaveStartButtonPosition();
        /*0x72e8680*/ void set_SaveStartButtonPosition(bool value);
        /*0x72e868c*/ float get_ToolStartButtonAlpha();
        /*0x72e8694*/ void set_ToolStartButtonAlpha(float value);
        /*0x72e869c*/ float get_BackgroundAlpha();
        /*0x72e86a4*/ void set_BackgroundAlpha(float value);
        /*0x72e86ac*/ float get_FloatingWindowAlpha();
        /*0x72e86b4*/ void set_FloatingWindowAlpha(float value);
        /*0x72e86bc*/ float get_ControllerBackgroundAlpha();
        /*0x72e86c4*/ void set_ControllerBackgroundAlpha(float value);
        /*0x72e86cc*/ int get_NoaDebuggerCanvasSortOrder();
        /*0x72e86d4*/ void set_NoaDebuggerCanvasSortOrder(int value);
        /*0x72e86dc*/ bool get_IsUIReversePortrait();
        /*0x72e86e4*/ void set_IsUIReversePortrait(bool value);
        /*0x72e86f0*/ bool get_IsShowSideMenuCloseButton();
        /*0x72e86f8*/ void set_IsShowSideMenuCloseButton(bool value);
        /*0x72e8704*/ System.Collections.Generic.List<NoaDebugger.MenuInfo> get_MenuList();
        /*0x72e870c*/ void set_MenuList(System.Collections.Generic.List<NoaDebugger.MenuInfo> value);
        /*0x72e8714*/ bool get_AutoCreateEventSystem();
        /*0x72e871c*/ void set_AutoCreateEventSystem(bool value);
        /*0x72e8728*/ NoaDebugger.ErrorNotificationType get_ErrorNotificationType();
        /*0x72e8730*/ void set_ErrorNotificationType(NoaDebugger.ErrorNotificationType value);
        /*0x72e8738*/ bool get_AutoInitialize();
        /*0x72e8740*/ void set_AutoInitialize(bool value);
        /*0x72e874c*/ System.Collections.Generic.List<NoaDebugger.CustomMenuInfo> get_CustomMenuList();
        /*0x72e8754*/ void set_CustomMenuList(System.Collections.Generic.List<NoaDebugger.CustomMenuInfo> value);
        /*0x72e875c*/ int get_ConsoleLogCount();
        /*0x72e8764*/ void set_ConsoleLogCount(int value);
        /*0x72e876c*/ int get_ApiLogCount();
        /*0x72e8774*/ void set_ApiLogCount(int value);
        /*0x72e877c*/ bool get_IsCustomFontSpecified();
        /*0x72e87f4*/ bool get_IsCustomFontSettingsEnabled();
        /*0x72e87fc*/ void set_IsCustomFontSettingsEnabled(bool value);
        /*0x72e8808*/ TMPro.TMP_FontAsset get_FontAsset();
        /*0x72e8810*/ void set_FontAsset(TMPro.TMP_FontAsset value);
        /*0x72e8818*/ UnityEngine.Material get_FontMaterial();
        /*0x72e8820*/ void set_FontMaterial(UnityEngine.Material value);
        /*0x72e8828*/ float get_FontSizeRate();
        /*0x72e8830*/ void set_FontSizeRate(float value);
        /*0x72e8838*/ int get_HierarchyLevels();
        /*0x72e8840*/ void set_HierarchyLevels(int value);
        /*0x72e8848*/ NoaDebugger.DebugCommand.CommandDisplayFormat get_CommandFormatLandscape();
        /*0x72e8850*/ void set_CommandFormatLandscape(NoaDebugger.DebugCommand.CommandDisplayFormat value);
        /*0x72e8858*/ NoaDebugger.DebugCommand.CommandDisplayFormat get_CommandFormatPortrait();
        /*0x72e8860*/ void set_CommandFormatPortrait(NoaDebugger.DebugCommand.CommandDisplayFormat value);
        /*0x72e8868*/ float get_OverlayBackgroundOpacity();
        /*0x72e8870*/ void set_OverlayBackgroundOpacity(float value);
        /*0x72e8878*/ bool get_AppliesOverlaySafeArea();
        /*0x72e8880*/ void set_AppliesOverlaySafeArea(bool value);
        /*0x72e888c*/ UnityEngine.Vector2 get_OverlayPadding();
        /*0x72e8894*/ void set_OverlayPadding(UnityEngine.Vector2 value);
        /*0x72e889c*/ NoaDebugger.NoaDebug.OverlayPosition get_ProfilerOverlayPosition();
        /*0x72e88a4*/ void set_ProfilerOverlayPosition(NoaDebugger.NoaDebug.OverlayPosition value);
        /*0x72e88ac*/ float get_ProfilerOverlayScale();
        /*0x72e88b4*/ void set_ProfilerOverlayScale(float value);
        /*0x72e88bc*/ NoaDebugger.NoaProfiler.OverlayAxis get_ProfilerOverlayAxis();
        /*0x72e88c4*/ void set_ProfilerOverlayAxis(NoaDebugger.NoaProfiler.OverlayAxis value);
        /*0x72e88cc*/ NoaDebugger.NoaDebug.OverlayPosition get_ConsoleLogOverlayPosition();
        /*0x72e88d4*/ void set_ConsoleLogOverlayPosition(NoaDebugger.NoaDebug.OverlayPosition value);
        /*0x72e88dc*/ float get_ConsoleLogOverlayFontScale();
        /*0x72e88e4*/ void set_ConsoleLogOverlayFontScale(float value);
        /*0x72e88ec*/ int get_ConsoleLogOverlayMaximumLogCount();
        /*0x72e88f4*/ void set_ConsoleLogOverlayMaximumLogCount(int value);
        /*0x72e88fc*/ float get_ConsoleLogOverlayMinimumOpacity();
        /*0x72e8904*/ void set_ConsoleLogOverlayMinimumOpacity(float value);
        /*0x72e890c*/ float get_ConsoleLogOverlayActiveDuration();
        /*0x72e8914*/ void set_ConsoleLogOverlayActiveDuration(float value);
        /*0x72e891c*/ bool get_ConsoleLogOverlayShowTimestamp();
        /*0x72e8924*/ void set_ConsoleLogOverlayShowTimestamp(bool value);
        /*0x72e8930*/ bool get_ConsoleLogOverlayShowMessageLogs();
        /*0x72e8938*/ void set_ConsoleLogOverlayShowMessageLogs(bool value);
        /*0x72e8944*/ bool get_ConsoleLogOverlayShowWarningLogs();
        /*0x72e894c*/ void set_ConsoleLogOverlayShowWarningLogs(bool value);
        /*0x72e8958*/ bool get_ConsoleLogOverlayShowErrorLogs();
        /*0x72e8960*/ void set_ConsoleLogOverlayShowErrorLogs(bool value);
        /*0x72e896c*/ NoaDebugger.NoaDebug.OverlayPosition get_ApiLogOverlayPosition();
        /*0x72e8974*/ void set_ApiLogOverlayPosition(NoaDebugger.NoaDebug.OverlayPosition value);
        /*0x72e897c*/ float get_ApiLogOverlayFontScale();
        /*0x72e8984*/ void set_ApiLogOverlayFontScale(float value);
        /*0x72e898c*/ int get_ApiLogOverlayMaximumLogCount();
        /*0x72e8994*/ void set_ApiLogOverlayMaximumLogCount(int value);
        /*0x72e899c*/ float get_ApiLogOverlayMinimumOpacity();
        /*0x72e89a4*/ void set_ApiLogOverlayMinimumOpacity(float value);
        /*0x72e89ac*/ float get_ApiLogOverlayActiveDuration();
        /*0x72e89b4*/ void set_ApiLogOverlayActiveDuration(float value);
        /*0x72e89bc*/ bool get_ApiLogOverlayShowTimestamp();
        /*0x72e89c4*/ void set_ApiLogOverlayShowTimestamp(bool value);
        /*0x72e89d0*/ bool get_ApiLogOverlayShowMessageLogs();
        /*0x72e89d8*/ void set_ApiLogOverlayShowMessageLogs(bool value);
        /*0x72e89e4*/ bool get_ApiLogOverlayShowErrorLogs();
        /*0x72e89ec*/ void set_ApiLogOverlayShowErrorLogs(bool value);
        /*0x72e89f8*/ bool get_AppliesUIElementSafeArea();
        /*0x72e8a00*/ void set_AppliesUIElementSafeArea(bool value);
        /*0x72e8a0c*/ UnityEngine.Vector2 get_UIElementPadding();
        /*0x72e8a14*/ void set_UIElementPadding(UnityEngine.Vector2 value);
        /*0x72e8a1c*/ bool get_AppliesGameSpeedChange();
        /*0x72e8a24*/ void set_AppliesGameSpeedChange(bool value);
        /*0x72e8a30*/ float get_GameSpeedIncrement();
        /*0x72e8a38*/ void set_GameSpeedIncrement(float value);
        /*0x72e8a40*/ float get_MaxGameSpeed();
        /*0x72e8a48*/ void set_MaxGameSpeed(float value);
        /*0x72e8a50*/ bool get_EnableAllShortcuts();
        /*0x72e8a58*/ void set_EnableAllShortcuts(bool value);
        /*0x72e8a64*/ System.Collections.Generic.List<NoaDebugger.ShortcutAction> get_EnabledShortcutActions();
        /*0x72e8ad4*/ void set_EnabledShortcutActions(System.Collections.Generic.List<NoaDebugger.ShortcutAction> value);
        /*0x72e8b60*/ System.Collections.Generic.List<NoaDebugger.ShortcutAction> get_ShortcutActionsOnInputManager();
        /*0x72e8b68*/ void set_ShortcutActionsOnInputManager(System.Collections.Generic.List<NoaDebugger.ShortcutAction> value);
        /*0x72e8b70*/ System.Collections.Generic.List<NoaDebugger.ShortcutAction> get_ShortcutActions();
        /*0x72e8b78*/ void set_ShortcutActions(System.Collections.Generic.List<NoaDebugger.ShortcutAction> value);
        /*0x72e8b88*/ bool get_AutoSave();
        /*0x72e8b90*/ void set_AutoSave(bool value);
    }

    class MenuInfo
    {
        /*0x10*/ string Name;
        /*0x18*/ bool Enabled;
        /*0x1c*/ int SortNo;

        /*0x72e8c68*/ MenuInfo();
    }

    class CustomMenuInfo
    {
        /*0x10*/ int _sortNo;
        /*0x18*/ string _scriptName;

        /*0x72e8c70*/ CustomMenuInfo();
    }

    class JsonDictionary<TKey, TValue> : UnityEngine.ISerializationCallbackReceiver
    {
        /*0x0*/ NoaDebugger.JsonDictionary.KeyValuePair<TKey, TValue> dictionary;
        /*0x0*/ System.Collections.Generic.Dictionary<TKey, TValue> _dictionary;

        /*0x380d83c*/ JsonDictionary(System.Collections.Generic.Dictionary<TKey, TValue> dictionary);
        /*0x380b9e8*/ System.Collections.Generic.Dictionary<TKey, TValue> get_Dictionary();
        /*0x380cb08*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        /*0x380cb08*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();

        struct KeyValuePair<TKey, TValue>
        {
            /*0x0*/ TKey key;
            /*0x0*/ TValue value;

            /*0x3907c14*/ KeyValuePair(TKey key, TValue value);
            /*0x3907c14*/ TKey get_Key();
            /*0x3907c14*/ TValue get_Value();
        }

        class <>c<TKey, TValue>
        {
            static /*0x0*/ NoaDebugger.JsonDictionary.<>c<TKey, TValue> <>9;
            static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, NoaDebugger.JsonDictionary.KeyValuePair<TKey, TValue>> <>9__6_0;
            static /*0x0*/ System.Func<NoaDebugger.JsonDictionary.KeyValuePair<TKey, TValue>, TKey> <>9__7_0;
            static /*0x0*/ System.Func<NoaDebugger.JsonDictionary.KeyValuePair<TKey, TValue>, TValue> <>9__7_1;

            static /*0x38358cc*/ <>c();
            /*0x380cb08*/ <>c();
            /*0x3907c14*/ NoaDebugger.JsonDictionary.KeyValuePair<TKey, TValue> <UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize>b__6_0(System.Collections.Generic.KeyValuePair<TKey, TValue> x);
            /*0x3907c14*/ TKey <UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize>b__7_0(NoaDebugger.JsonDictionary.KeyValuePair<TKey, TValue> x);
            /*0x3907c14*/ TValue <UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize>b__7_1(NoaDebugger.JsonDictionary.KeyValuePair<TKey, TValue> x);
        }
    }

    class NoaDebuggerAutoSaveSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x72e8c78*/ NoaDebuggerAutoSaveSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72e8cd8*/ void Init();
    }

    class NoaDebuggerCommandSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x72e8cf8*/ NoaDebuggerCommandSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72e8d28*/ void Init();
    }

    class NoaDebuggerCustomMenuSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x72e8d4c*/ NoaDebuggerCustomMenuSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72e8d7c*/ void Init();
    }

    class NoaDebuggerDisplaySettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x72e8e04*/ NoaDebuggerDisplaySettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72e8e34*/ void Init();
    }

    class NoaDebuggerFontSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x72e8e80*/ NoaDebuggerFontSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72e8eb0*/ void Init();
    }

    class NoaDebuggerGameSpeedSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x72e8f00*/ NoaDebuggerGameSpeedSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72e8f30*/ void Init();
    }

    class NoaDebuggerHierarchySettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x72e8f5c*/ NoaDebuggerHierarchySettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72e8f8c*/ void Init();
    }

    class NoaDebuggerLoadingSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x72e8fac*/ NoaDebuggerLoadingSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72e8fdc*/ void Init();
    }

    class NoaDebuggerLogSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x72e8ffc*/ NoaDebuggerLogSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72e902c*/ void Init();
    }

    class NoaDebuggerMenuSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        static /*0x72e90a8*/ System.Collections.Generic.List<NoaDebugger.MenuInfo> GetDefaultMenuSettings();
        static /*0x72e9444*/ System.Collections.Generic.List<NoaDebugger.IMenuInfo> GetSortedIMenuInfoList();
        static /*0x72e97e0*/ System.Collections.Generic.List<NoaDebugger.MenuInfo> GetUpdatedMenuSettings(System.Collections.Generic.List<NoaDebugger.MenuInfo> baseList);
        /*0x72e9050*/ NoaDebuggerMenuSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72e9080*/ void Init();

        class <>c
        {
            static /*0x0*/ NoaDebugger.NoaDebuggerMenuSettings.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.INoaDebuggerTool, NoaDebugger.IMenuInfo> <>9__3_2;
            static /*0x10*/ System.Predicate<NoaDebugger.IMenuInfo> <>9__3_0;
            static /*0x18*/ System.Comparison<NoaDebugger.IMenuInfo> <>9__3_1;

            static /*0x72ea050*/ <>c();
            /*0x72ea0b8*/ <>c();
            /*0x72ea0c0*/ NoaDebugger.IMenuInfo <GetSortedIMenuInfoList>b__3_2(NoaDebugger.INoaDebuggerTool t);
            /*0x72ea160*/ bool <GetSortedIMenuInfoList>b__3_0(NoaDebugger.IMenuInfo m);
            /*0x72ea1cc*/ int <GetSortedIMenuInfoList>b__3_1(NoaDebugger.IMenuInfo a, NoaDebugger.IMenuInfo b);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ NoaDebugger.MenuInfo menu;

            /*0x72ea040*/ <>c__DisplayClass4_0();
            /*0x72ea2dc*/ bool <GetUpdatedMenuSettings>b__0(NoaDebugger.MenuInfo updateInfo);
            /*0x72ea308*/ bool <GetUpdatedMenuSettings>b__1(NoaDebugger.IMenuInfo defaultInfo);
        }

        class <>c__DisplayClass4_1
        {
            /*0x10*/ NoaDebugger.IMenuInfo defaultInfo;

            /*0x72ea048*/ <>c__DisplayClass4_1();
            /*0x72ea3c4*/ bool <GetUpdatedMenuSettings>b__2(NoaDebugger.MenuInfo customMenuInfo);
        }
    }

    class NoaDebuggerOtherSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x72ea488*/ NoaDebuggerOtherSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72ea4b8*/ void Init();
    }

    class NoaDebuggerOverlaySettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x72ea4dc*/ NoaDebuggerOverlaySettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72ea50c*/ void Init();
    }

    class NoaDebuggerSettingsBase
    {
        /*0x10*/ NoaDebugger.NoaDebuggerSettings _settings;

        /*0x72e8ca8*/ NoaDebuggerSettingsBase(NoaDebugger.NoaDebuggerSettings settings);
        /*0x380cb08*/ void Init();
    }

    class NoaDebuggerSettingsContainer
    {
        /*0x10*/ System.Collections.Generic.List<NoaDebugger.NoaDebuggerSettingsBase> _settings;

        /*0x72ea590*/ NoaDebuggerSettingsContainer(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72eaeb8*/ void Init();

        class <>c
        {
            static /*0x0*/ NoaDebugger.NoaDebuggerSettingsContainer.<> <>9;
            static /*0x8*/ System.Action<NoaDebugger.NoaDebuggerSettingsBase> <>9__2_0;

            static /*0x72eafbc*/ <>c();
            /*0x72eb024*/ <>c();
            /*0x72eb02c*/ void <Init>b__2_0(NoaDebugger.NoaDebuggerSettingsBase setting);
        }
    }

    class NoaDebuggerShortcutSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        static /*0x72eb10c*/ System.Collections.Generic.List<NoaDebugger.ShortcutAction> GetDefaultShortcutActions(System.Nullable<bool> forInputSystem);
        static /*0x72eb234*/ NoaDebugger.ShortcutInputCombination GetDefaultCombination(NoaDebugger.ShortcutActionType type, System.Nullable<bool> forInputSystem);
        static /*0x72eb494*/ System.Collections.Generic.List<NoaDebugger.ShortcutAction> GetUpdatedShortcutSettings(System.Collections.Generic.List<NoaDebugger.ShortcutAction> baseList, bool forInputSystem);
        static /*0x72eb7e8*/ bool CheckUpdateDirtyShortcutSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72eae88*/ NoaDebuggerShortcutSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72eb050*/ void Init();

        class <>c__DisplayClass2_0
        {
            /*0x10*/ System.Nullable<bool> forInputSystem;

            /*0x72eb22c*/ <>c__DisplayClass2_0();
            /*0x72eb9f8*/ NoaDebugger.ShortcutAction <GetDefaultShortcutActions>b__0(NoaDebugger.ShortcutActionType type);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ NoaDebugger.ShortcutActionType actionType;

            /*0x72eb7e0*/ <>c__DisplayClass4_0();
            /*0x72eba84*/ bool <GetUpdatedShortcutSettings>b__0(NoaDebugger.ShortcutAction customShortcutInfo);
        }
    }

    class NoaDebuggerUIElementSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x72eae58*/ NoaDebuggerUIElementSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x72ebb14*/ void Init();
    }

    class NoaDebuggerSettingsManager
    {
        static string TOOL_SETTINGS_ASSET_NAME = "NoaDebuggerSettings";
        static /*0x0*/ NoaDebugger.NoaDebuggerSettingsManager _instance;
        /*0x10*/ NoaDebugger.NoaDebuggerSettings _noaDebuggerSettings;

        static /*0x72ebb38*/ NoaDebugger.NoaDebuggerSettingsManager get_Instance();
        static /*0x72ebbc8*/ void ValidateMenuSettings(System.Collections.Generic.List<NoaDebugger.INoaDebuggerTool> allPresenters);
        static /*0x72e4238*/ NoaDebugger.NoaDebuggerSettings GetNoaDebuggerSettings();
        static /*0x72ec2c4*/ void Dispose();
        /*0x72ebbc0*/ NoaDebuggerSettingsManager();
        /*0x72ebbe8*/ void _ValidateMenuSettings(System.Collections.Generic.List<NoaDebugger.INoaDebuggerTool> allPresenters);
        /*0x72ec1ec*/ NoaDebugger.NoaDebuggerSettings _GetNoaDebuggerSettings();

        class <>c
        {
            static /*0x0*/ NoaDebugger.NoaDebuggerSettingsManager.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.MenuInfo, string> <>9__6_0;
            static /*0x10*/ System.Func<System.Linq.IGrouping<string, NoaDebugger.MenuInfo>, NoaDebugger.MenuInfo> <>9__6_1;

            static /*0x72ec318*/ <>c();
            /*0x72ec380*/ <>c();
            /*0x72ec388*/ string <_ValidateMenuSettings>b__6_0(NoaDebugger.MenuInfo x);
            /*0x72ec3a0*/ NoaDebugger.MenuInfo <_ValidateMenuSettings>b__6_1(System.Linq.IGrouping<string, NoaDebugger.MenuInfo> x);
        }

        class <>c__DisplayClass6_0
        {
            /*0x10*/ NoaDebugger.INoaDebuggerTool presenter;

            /*0x72ec1dc*/ <>c__DisplayClass6_0();
            /*0x72ec3e8*/ bool <_ValidateMenuSettings>b__2(NoaDebugger.MenuInfo info);
        }

        class <>c__DisplayClass6_1
        {
            /*0x10*/ NoaDebugger.MenuInfo menuInfo;

            /*0x72ec1e4*/ <>c__DisplayClass6_1();
            /*0x72ec524*/ bool <_ValidateMenuSettings>b__3(NoaDebugger.INoaDebuggerTool tool);
        }
    }

    class NoaDebuggerVisibilityManager : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ NoaDebugger.NoaDebuggerVisibilityManager _instance;
        static /*0x8*/ System.Func<bool, bool> _onToggleNoaDebuggerUI;
        /*0x20*/ NoaDebugger.NoaDebuggerVisibilityManager.MainViewVisibility _mainViewVisibility;
        /*0x28*/ NoaDebugger.NoaDebuggerVisibilityManager.OverlayVisibility _overlayVisibility;
        /*0x30*/ bool _isActiveOverlay;
        /*0x38*/ NoaDebugger.NoaDebuggerVisibilityManager.FloatingWindowVisibility _floatingWindowVisibility;
        /*0x40*/ bool _isActiveFloatingWindow;
        /*0x48*/ NoaDebugger.NoaDebuggerVisibilityManager.TriggerButtonVisibility _triggerButtonVisibility;
        /*0x50*/ bool _isActiveTriggerButton;
        /*0x58*/ NoaDebugger.NoaDebuggerVisibilityManager.ControllerVisibility _controllerVisibility;
        /*0x60*/ NoaDebugger.NoaDebuggerVisibilityManager.ToastVisibility _toastVisibility;
        /*0x68*/ NoaDebugger.NoaDebuggerVisibilityManager.AllUIElementVisibility _allUIElementVisibility;
        /*0x70*/ bool _isToggleAllHide;
        /*0x71*/ bool _isMainViewVisibleBeforeHidden;

        static /*0x72ec724*/ System.Func<bool, bool> get_OnToggleNoaDebuggerUI();
        static /*0x72ec76c*/ void set_OnToggleNoaDebuggerUI(System.Func<bool, bool> value);
        static /*0x72e3eec*/ bool get_IsMainViewActive();
        static /*0x72ec7d8*/ bool get_IsOverlayRootActive();
        static /*0x72ec8ac*/ bool get_IsOverlayVisible();
        static /*0x72ecc7c*/ bool get_IsFloatingWindowVisible();
        static /*0x72ed04c*/ bool get_IsTriggerButtonActive();
        static /*0x72e1750*/ bool get_IsControllerActive();
        static /*0x72e5464*/ bool get_IsAllUIElementActive();
        static /*0x72ed264*/ void ToggleNoaDebuggerUI();
        static /*0x72ed590*/ void SetMainViewVisible(bool visible);
        static /*0x72ed638*/ void AddOverlaySetActiveAction(System.Action<bool> onSetActive);
        static /*0x72ed7a4*/ void RemoveOverlaySetActiveAction(System.Action<bool> onSetActive);
        static /*0x72ed910*/ void SetOverlayVisible(bool visible);
        static /*0x72eda18*/ void SetOverlayVisibleSetting(bool visible);
        static /*0x72eda94*/ void SetFloatingWindowVisible(bool visible);
        static /*0x72ede84*/ void SetFloatingWindowVisibleSetting(bool visible);
        static /*0x72edf00*/ void AddTriggerButtonSetActiveAction(System.Action<bool> onSetActive);
        static /*0x72ee06c*/ void RemoveTriggerButtonSetActiveAction(System.Action<bool> onSetActive);
        static /*0x72ee1d8*/ void SetTriggerButtonVisible(bool visible);
        static /*0x72ee338*/ void SetTriggerButtonVisibleSetting(bool visible);
        static /*0x72ee3c0*/ void OnErrorTriggerButtonVisibility();
        static /*0x72ee4bc*/ void SetControllerVisible(bool visible);
        static /*0x72ee57c*/ void SetAllUIElementsVisible(bool visible);
        static /*0x72ee72c*/ void SetAllUIElementsVisibleSetting(bool visible);
        static /*0x72ee7a8*/ void SetToastVisible(bool visible);
        static /*0x72ee8e0*/ void OnInitNoaDebuggerVisibility();
        static /*0x72ee954*/ void OnShowMainViewVisibility();
        static /*0x72ee9fc*/ void OnHideMainViewVisibility();
        static /*0x72eeaa4*/ void OnDisableNoaDebugger();
        static /*0x72eeb3c*/ void OnVisibleButtonVisibility();
        static /*0x72eebf0*/ void OnEnableWorldSpaceVisibility();
        static /*0x72eecec*/ void OnDisableWorldSpaceVisibility();
        static /*0x72eedb4*/ void Dispose();
        /*0x72eef40*/ NoaDebuggerVisibilityManager();
        /*0x72ec658*/ void Awake();
        /*0x72ed2bc*/ void _ToggleNoaDebuggerUI();
        /*0x72ee3a4*/ void _SetTriggerButtonVisibleSetting(bool visible);
        /*0x72ee51c*/ void _SetControllerVisible(bool visible);
        /*0x72ee938*/ void _OnInitNoaDebuggerVisibility();
        /*0x72ee9ac*/ void _OnShowMainViewVisibility();
        /*0x72eea54*/ void _OnHideMainViewVisibility();
        /*0x72eeafc*/ void _OnDisableNoaDebugger();
        /*0x72eeb94*/ void _OnVisibleButtonVisibility();
        /*0x72eec48*/ void _OnEnableWorldSpaceVisibility();
        /*0x72eed44*/ void _OnDisableWorldSpaceVisibility();
        /*0x72eee30*/ void _Dispose();

        class ScreenshotUIVisibilityManager
        {
            /*0x10*/ NoaDebugger.NoaController.ScreenshotTarget _screenshotTarget;
            /*0x14*/ bool _originalIsMainViewVisible;
            /*0x15*/ bool _originalIsControllerVisible;
            /*0x16*/ bool _originalIsTriggerButtonVisible;
            /*0x17*/ bool _originalIsOverlayVisible;
            /*0x18*/ bool _originalIsFloatingWindowVisible;
            /*0x19*/ bool _originalIsUIElementVisible;

            /*0x72ef010*/ ScreenshotUIVisibilityManager(NoaDebugger.NoaController.ScreenshotTarget screenshotTarget);
            /*0x72ef038*/ void Before();
            /*0x72ef194*/ void After();
        }

        class MainViewVisibility
        {
            /*0x10*/ UnityEngine.GameObject _noaDebugger;
            /*0x18*/ UnityEngine.GameObject _background;

            /*0x72ef2ec*/ MainViewVisibility();
            /*0x72ec7bc*/ bool get_IsActive();
            /*0x72ed5fc*/ void SetVisible(bool visible);
            /*0x72eef0c*/ void OnEnableWorldSpaceVisibility();
            /*0x72eef14*/ void OnDisableWorldSpaceVisibility();
            /*0x72ef264*/ void _SetActiveBg(bool visible);
        }

        class OverlayVisibility
        {
            /*0x10*/ UnityEngine.GameObject _overlayRoot;
            /*0x18*/ bool _visibleSetting;
            /*0x20*/ System.Action<bool> OnSetActiveOverlay;

            /*0x72ef340*/ OverlayVisibility();
            /*0x72ec890*/ bool get_IsRootActive();
            /*0x72ec958*/ bool get_IsVisibility();
            /*0x72ed6f4*/ void add_OnSetActiveOverlay(System.Action<bool> value);
            /*0x72ed860*/ void remove_OnSetActiveOverlay(System.Action<bool> value);
            /*0x72ef2f4*/ void _SetOverlayActive(bool active);
            /*0x72ed97c*/ void SetVisible(bool visible);
            /*0x72eda88*/ void SetVisibleSetting(bool visible);
        }

        class FloatingWindowVisibility
        {
            /*0x10*/ UnityEngine.GameObject _floatingWindowRoot;
            /*0x18*/ bool _visibleSetting;

            /*0x72ef350*/ FloatingWindowVisibility();
            /*0x72ecd28*/ bool get_IsVisibility();
            /*0x72edb00*/ void SetVisible(bool visible);
            /*0x72edef4*/ void SetVisibleSetting(bool visible);
        }

        class TriggerButtonVisibility
        {
            /*0x10*/ UnityEngine.GameObject _triggerButton;
            /*0x18*/ UnityEngine.GameObject _visibleButton;
            /*0x20*/ bool _visibleSetting;
            /*0x28*/ System.Action<bool> OnSetActiveTriggerButton;

            /*0x72ef3ac*/ TriggerButtonVisibility();
            /*0x72ed104*/ bool get_IsActive();
            /*0x72edfbc*/ void add_OnSetActiveTriggerButton(System.Action<bool> value);
            /*0x72ee128*/ void remove_OnSetActiveTriggerButton(System.Action<bool> value);
            /*0x72ef360*/ void _SetTriggerButtonActive(bool active);
            /*0x72ee244*/ void SetVisible(bool visible);
            /*0x72eeee0*/ void InvalidateTriggerButton();
            /*0x72eeec8*/ void SetVisibleSetting(bool visible);
            /*0x72ee424*/ void OnErrorVisible();
        }

        class ControllerVisibility
        {
            /*0x10*/ UnityEngine.GameObject _controller;

            /*0x72ef3bc*/ ControllerVisibility();
            /*0x72ed120*/ bool get_IsActive();
            /*0x72eeea8*/ void SetVisible(bool visible);
        }

        class AllUIElementVisibility
        {
            /*0x10*/ bool _visibleSetting;

            /*0x72ef000*/ AllUIElementVisibility();
            /*0x72ed13c*/ bool get_IsActive();
            /*0x72ee5e8*/ void SetVisible(bool visible);
            /*0x72ee79c*/ void SetVisibleSetting(bool visible);

            class <>c
            {
                static /*0x0*/ NoaDebugger.NoaDebuggerVisibilityManager.AllUIElementVisibility.<> <>9;
                static /*0x8*/ System.Func<NoaDebugger.INoaUIElementView, bool> <>9__1_0;

                static /*0x72ef3c4*/ <>c();
                /*0x72ef42c*/ <>c();
                /*0x72ef434*/ bool <get_IsActive>b__1_0(NoaDebugger.INoaUIElementView elementView);
            }
        }

        class ToastVisibility
        {
            /*0x72eeff8*/ ToastVisibility();
            /*0x72ee814*/ void SetVisible(bool visible);
        }
    }

    class ApiLog : NoaDebugger.ILogDetail
    {
        /*0x10*/ System.Uri <Url>k__BackingField;
        /*0x18*/ string <Method>k__BackingField;
        /*0x20*/ int <StatusCode>k__BackingField;
        /*0x28*/ long <ContentSize>k__BackingField;
        /*0x30*/ long <ResponseTimeMilliSeconds>k__BackingField;
        /*0x38*/ System.Collections.Generic.Dictionary<string, string> <RequestHeaders>k__BackingField;
        /*0x40*/ string <RequestBody>k__BackingField;
        /*0x48*/ object <RequestBodyRawData>k__BackingField;
        /*0x50*/ System.Collections.Generic.Dictionary<string, string> <ResponseHeaders>k__BackingField;
        /*0x58*/ string <ResponseBody>k__BackingField;
        /*0x60*/ object <ResponseBodyRawData>k__BackingField;
        /*0x68*/ bool <PrettyPrint>k__BackingField;
        /*0x70*/ string prettyPrintedRequestBody;
        /*0x78*/ bool <IsRequestBodyPrettyPrinted>k__BackingField;
        /*0x80*/ string prettyPrintedResponseBody;
        /*0x88*/ bool <IsResponseBodyPrettyPrinted>k__BackingField;

        /*0x72ef804*/ ApiLog();
        /*0x72ef4e0*/ System.Uri get_Url();
        /*0x72ef4e8*/ void set_Url(System.Uri value);
        /*0x72ef4f0*/ string get_Method();
        /*0x72ef4f8*/ void set_Method(string value);
        /*0x72ef500*/ int get_StatusCode();
        /*0x72ef508*/ void set_StatusCode(int value);
        /*0x72ef510*/ long get_ContentSize();
        /*0x72ef518*/ void set_ContentSize(long value);
        /*0x72ef520*/ long get_ResponseTimeMilliSeconds();
        /*0x72ef528*/ void set_ResponseTimeMilliSeconds(long value);
        /*0x72ef530*/ System.Collections.Generic.Dictionary<string, string> get_RequestHeaders();
        /*0x72ef538*/ void set_RequestHeaders(System.Collections.Generic.Dictionary<string, string> value);
        /*0x72ef540*/ string get_RequestBody();
        /*0x72ef548*/ void set_RequestBody(string value);
        /*0x72ef550*/ object get_RequestBodyRawData();
        /*0x72ef558*/ void set_RequestBodyRawData(object value);
        /*0x72ef560*/ System.Collections.Generic.Dictionary<string, string> get_ResponseHeaders();
        /*0x72ef568*/ void set_ResponseHeaders(System.Collections.Generic.Dictionary<string, string> value);
        /*0x72ef570*/ string get_ResponseBody();
        /*0x72ef578*/ void set_ResponseBody(string value);
        /*0x72ef580*/ object get_ResponseBodyRawData();
        /*0x72ef588*/ void set_ResponseBodyRawData(object value);
        /*0x72ef590*/ bool get_IsSuccess();
        /*0x72ef5a4*/ bool get_PrettyPrint();
        /*0x72ef5ac*/ void set_PrettyPrint(bool value);
        /*0x72ef5b8*/ void set_IsRequestBodyPrettyPrinted(bool value);
        /*0x72ef5c4*/ bool get_IsRequestBodyPrettyPrinted();
        /*0x72ef5cc*/ string get_PrettyPrintedRequestBody();
        /*0x72ef6a0*/ void set_IsResponseBodyPrettyPrinted(bool value);
        /*0x72ef6ac*/ bool get_IsResponseBodyPrettyPrinted();
        /*0x72ef6b4*/ string get_PrettyPrintedResponseBody();
        /*0x72ef6e8*/ void ConvertBody();
        /*0x72ef7fc*/ string NoaDebugger.ILogDetail.GetClipboardText();
        /*0x72ef600*/ bool ToPrettyPrint(string text, ref string result);
    }

    class ApiLogger
    {
        static /*0x0*/ NoaDebugger.ApiLogger.LogCallback OnLogReceived;
        static /*0x8*/ System.Func<object, string> <OnConvertRequestBodyToString>k__BackingField;
        static /*0x10*/ System.Func<object, string> <OnConvertResponseBodyToString>k__BackingField;

        static /*0x72ef814*/ void add_OnLogReceived(NoaDebugger.ApiLogger.LogCallback value);
        static /*0x72ef8cc*/ void remove_OnLogReceived(NoaDebugger.ApiLogger.LogCallback value);
        static /*0x72ef984*/ System.Func<object, string> get_OnConvertRequestBodyToString();
        static /*0x72ef9cc*/ void set_OnConvertRequestBodyToString(System.Func<object, string> value);
        static /*0x72efa1c*/ System.Func<object, string> get_OnConvertResponseBodyToString();
        static /*0x72efa64*/ void set_OnConvertResponseBodyToString(System.Func<object, string> value);
        static /*0x72efab4*/ void Log(NoaDebugger.ApiLog log);

        class LogCallback : System.MulticastDelegate
        {
            /*0x72efbdc*/ LogCallback(object object, nint method);
            /*0x72efce4*/ void Invoke(NoaDebugger.ApiLog log);
            /*0x72efcf8*/ System.IAsyncResult BeginInvoke(NoaDebugger.ApiLog log, System.AsyncCallback callback, object object);
            /*0x72efd18*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class CommandCharacterLimitAttribute : System.Attribute
    {
        /*0x10*/ int _limit;

        /*0x72efd24*/ CommandCharacterLimitAttribute(int limit);
    }

    class CommandDescriptionAttribute : System.Attribute
    {
        /*0x10*/ string _text;

        /*0x72efd50*/ CommandDescriptionAttribute(string text);
    }

    class CommandExcludeAttribute : System.Attribute
    {
        /*0x72efd80*/ CommandExcludeAttribute();
    }

    class CommandGroupAttribute : System.Attribute
    {
        /*0x10*/ string _name;
        /*0x18*/ System.Nullable<int> _order;

        /*0x72efd88*/ CommandGroupAttribute(string name);
        /*0x72efdc0*/ CommandGroupAttribute(string name, int order);
    }

    class CommandIncrementAttribute : System.Attribute
    {
        /*0x10*/ object _increment;

        /*0x72efe50*/ CommandIncrementAttribute(object increment);
    }

    class CommandInputRangeAttribute : System.Attribute
    {
        /*0x10*/ object _min;
        /*0x18*/ object _max;

        /*0x72efe80*/ CommandInputRangeAttribute(object min, object max);
    }

    class CommandOrderAttribute : System.Attribute
    {
        /*0x10*/ int _order;

        /*0x72efec4*/ CommandOrderAttribute(int order);
    }

    class CommandTagAttribute : System.Attribute
    {
        /*0x10*/ string _tag;

        /*0x72efeec*/ CommandTagAttribute(string tag);
    }

    class DisplayNameAttribute : System.Attribute
    {
        /*0x10*/ string _name;

        /*0x72eff1c*/ DisplayNameAttribute(string name);
    }

    class SaveOnUpdateAttribute : System.Attribute
    {
        /*0x72eff4c*/ SaveOnUpdateAttribute();
    }

    class DebugCategoryBase
    {
        /*0x72eff54*/ DebugCategoryBase();
    }

    class DebugCommandRegister
    {
        static /*0x0*/ UnityEngine.Events.UnityAction OnAddCategory;
        static /*0x8*/ System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommandRegister.DebugCategory> <CategoryTypes>k__BackingField;
        static /*0x10*/ System.Collections.Generic.Dictionary<string, int> CategoryNameSuffixNumber;
        static /*0x18*/ NoaDebugger.DebugCommand.DebugCommandDefinitionRegister DebugCommandDefinitionRegister;

        static /*0x72f2970*/ DebugCommandRegister();
        static /*0x72eff5c*/ void add_OnAddCategory(UnityEngine.Events.UnityAction value);
        static /*0x72f0034*/ void remove_OnAddCategory(UnityEngine.Events.UnityAction value);
        static /*0x72f010c*/ System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommandRegister.DebugCategory> get_CategoryTypes();
        static /*0x72f0164*/ void Dispose();
        static /*0x383a19c*/ void AddCategory<T>(string categoryName, int order, string displayName);
        static /*0x3907c14*/ T GetCategoryInstance<T>(string categoryName);
        static /*0x72f026c*/ int _CountNameDuplication(string name);
        static /*0x72f0438*/ NoaDebugger.CommandDefinition CreateGetOnlyStringProperty(string categoryName, string displayName, System.Func<string> getter, System.Attribute[] attributes);
        static /*0x72f0508*/ NoaDebugger.CommandDefinition CreateGetOnlySByteProperty(string categoryName, string displayName, System.Func<sbyte> getter, System.Attribute[] attributes);
        static /*0x72f0620*/ NoaDebugger.CommandDefinition CreateGetOnlyByteProperty(string categoryName, string displayName, System.Func<byte> getter, System.Attribute[] attributes);
        static /*0x72f0738*/ NoaDebugger.CommandDefinition CreateGetOnlyShortProperty(string categoryName, string displayName, System.Func<short> getter, System.Attribute[] attributes);
        static /*0x72f0850*/ NoaDebugger.CommandDefinition CreateGetOnlyUShortProperty(string categoryName, string displayName, System.Func<ushort> getter, System.Attribute[] attributes);
        static /*0x72f0968*/ NoaDebugger.CommandDefinition CreateGetOnlyIntProperty(string categoryName, string displayName, System.Func<int> getter, System.Attribute[] attributes);
        static /*0x72f0a80*/ NoaDebugger.CommandDefinition CreateGetOnlyUIntProperty(string categoryName, string displayName, System.Func<uint> getter, System.Attribute[] attributes);
        static /*0x72f0b98*/ NoaDebugger.CommandDefinition CreateGetOnlyLongProperty(string categoryName, string displayName, System.Func<long> getter, System.Attribute[] attributes);
        static /*0x72f0cb0*/ NoaDebugger.CommandDefinition CreateGetOnlyULongProperty(string categoryName, string displayName, System.Func<ulong> getter, System.Attribute[] attributes);
        static /*0x72f0dc8*/ NoaDebugger.CommandDefinition CreateGetOnlyCharProperty(string categoryName, string displayName, System.Func<char> getter, System.Attribute[] attributes);
        static /*0x72f0ee0*/ NoaDebugger.CommandDefinition CreateGetOnlyFloatProperty(string categoryName, string displayName, System.Func<float> getter, System.Attribute[] attributes);
        static /*0x72f0ff8*/ NoaDebugger.CommandDefinition CreateGetOnlyDoubleProperty(string categoryName, string displayName, System.Func<double> getter, System.Attribute[] attributes);
        static /*0x72f1110*/ NoaDebugger.CommandDefinition CreateGetOnlyDecimalProperty(string categoryName, string displayName, System.Func<decimal> getter, System.Attribute[] attributes);
        static /*0x72f1228*/ NoaDebugger.CommandDefinition CreateGetOnlyBoolProperty(string categoryName, string displayName, System.Func<bool> getter, System.Attribute[] attributes);
        static /*0x72f1340*/ NoaDebugger.CommandDefinition CreateGetOnlyEnumProperty(string categoryName, string displayName, System.Func<System.Enum> getter, System.Attribute[] attributes);
        static /*0x72f1410*/ NoaDebugger.CommandDefinition CreateMutableStringProperty(string categoryName, string displayName, System.Func<string> getter, System.Action<string> setter, System.Attribute[] attributes);
        static /*0x72f149c*/ NoaDebugger.CommandDefinition CreateMutableSByteProperty(string categoryName, string displayName, System.Func<sbyte> getter, System.Action<sbyte> setter, System.Attribute[] attributes);
        static /*0x72f1528*/ NoaDebugger.CommandDefinition CreateMutableByteProperty(string categoryName, string displayName, System.Func<byte> getter, System.Action<byte> setter, System.Attribute[] attributes);
        static /*0x72f15b4*/ NoaDebugger.CommandDefinition CreateMutableShortProperty(string categoryName, string displayName, System.Func<short> getter, System.Action<short> setter, System.Attribute[] attributes);
        static /*0x72f1640*/ NoaDebugger.CommandDefinition CreateMutableUShortProperty(string categoryName, string displayName, System.Func<ushort> getter, System.Action<ushort> setter, System.Attribute[] attributes);
        static /*0x72f16cc*/ NoaDebugger.CommandDefinition CreateMutableIntProperty(string categoryName, string displayName, System.Func<int> getter, System.Action<int> setter, System.Attribute[] attributes);
        static /*0x72f1758*/ NoaDebugger.CommandDefinition CreateMutableUIntProperty(string categoryName, string displayName, System.Func<uint> getter, System.Action<uint> setter, System.Attribute[] attributes);
        static /*0x72f17e4*/ NoaDebugger.CommandDefinition CreateMutableLongProperty(string categoryName, string displayName, System.Func<long> getter, System.Action<long> setter, System.Attribute[] attributes);
        static /*0x72f1870*/ NoaDebugger.CommandDefinition CreateMutableULongProperty(string categoryName, string displayName, System.Func<ulong> getter, System.Action<ulong> setter, System.Attribute[] attributes);
        static /*0x72f18fc*/ NoaDebugger.CommandDefinition CreateMutableCharProperty(string categoryName, string displayName, System.Func<char> getter, System.Action<char> setter, System.Attribute[] attributes);
        static /*0x72f1988*/ NoaDebugger.CommandDefinition CreateMutableFloatProperty(string categoryName, string displayName, System.Func<float> getter, System.Action<float> setter, System.Attribute[] attributes);
        static /*0x72f1a14*/ NoaDebugger.CommandDefinition CreateMutableDoubleProperty(string categoryName, string displayName, System.Func<double> getter, System.Action<double> setter, System.Attribute[] attributes);
        static /*0x72f1aa0*/ NoaDebugger.CommandDefinition CreateMutableDecimalProperty(string categoryName, string displayName, System.Func<decimal> getter, System.Action<decimal> setter, System.Attribute[] attributes);
        static /*0x72f1b2c*/ NoaDebugger.CommandDefinition CreateMutableBoolProperty(string categoryName, string displayName, System.Func<bool> getter, System.Action<bool> setter, System.Attribute[] attributes);
        static /*0x3830cb0*/ NoaDebugger.CommandDefinition CreateMutableEnumProperty<T>(string categoryName, string displayName, System.Func<T> getter, System.Action<T> setter, System.Attribute[] attributes);
        static /*0x72f1bb8*/ NoaDebugger.CommandDefinition CreateMethod(string categoryName, string displayName, System.Action method, System.Attribute[] attributes);
        static /*0x72f1c3c*/ NoaDebugger.CommandDefinition CreateCoroutine(string categoryName, string displayName, System.Func<System.Collections.IEnumerator> coroutine, System.Attribute[] attributes);
        static /*0x72f1cc0*/ NoaDebugger.CommandDefinition CreateHandleMethod(string categoryName, string displayName, System.Func<NoaDebugger.MethodHandler> method, System.Attribute[] attributes);
        static /*0x72f1d44*/ void AddCommand(NoaDebugger.CommandDefinition commandDefinition);
        static /*0x72f1e1c*/ void RemoveCommand(NoaDebugger.CommandDefinition commandDefinition);
        static /*0x72f1ef4*/ void RefreshProperty();
        static /*0x72f1f44*/ void DeleteAllSavedProperties();
        static /*0x72f2280*/ void DeleteAllPropertiesInCategory(string categoryName);
        static /*0x72f25d4*/ void DeleteSavedProperty(string categoryName, string propertyName);
        static /*0x72f266c*/ string GetSavePropertyKey(string categoryName, string propertyName);
        static /*0x72f27b0*/ void SetInteractable(string categoryName, string commandTag, bool isInteractable);
        static /*0x72f2828*/ bool IsInteractable(string categoryName, string commandTag);
        static /*0x72f2890*/ void SetVisible(string categoryName, string commandTag, bool isVisible);
        static /*0x72f2908*/ bool IsVisible(string categoryName, string commandTag);

        struct DebugCategory
        {
            /*0x10*/ int _order;
            /*0x18*/ string _displayName;
            /*0x20*/ System.Type _type;

            /*0x72f2a94*/ DebugCategory(int order, string displayName, System.Type type);
        }

        class <>c__DisplayClass13_0
        {
            /*0x10*/ System.Func<sbyte> getter;

            /*0x72f0618*/ <>c__DisplayClass13_0();
            /*0x72f2acc*/ object <CreateGetOnlySByteProperty>b__0();
        }

        class <>c__DisplayClass14_0
        {
            /*0x10*/ System.Func<byte> getter;

            /*0x72f0730*/ <>c__DisplayClass14_0();
            /*0x72f2b10*/ object <CreateGetOnlyByteProperty>b__0();
        }

        class <>c__DisplayClass15_0
        {
            /*0x10*/ System.Func<short> getter;

            /*0x72f0848*/ <>c__DisplayClass15_0();
            /*0x72f2b54*/ object <CreateGetOnlyShortProperty>b__0();
        }

        class <>c__DisplayClass16_0
        {
            /*0x10*/ System.Func<ushort> getter;

            /*0x72f0960*/ <>c__DisplayClass16_0();
            /*0x72f2b98*/ object <CreateGetOnlyUShortProperty>b__0();
        }

        class <>c__DisplayClass17_0
        {
            /*0x10*/ System.Func<int> getter;

            /*0x72f0a78*/ <>c__DisplayClass17_0();
            /*0x72f2bdc*/ object <CreateGetOnlyIntProperty>b__0();
        }

        class <>c__DisplayClass18_0
        {
            /*0x10*/ System.Func<uint> getter;

            /*0x72f0b90*/ <>c__DisplayClass18_0();
            /*0x72f2c20*/ object <CreateGetOnlyUIntProperty>b__0();
        }

        class <>c__DisplayClass19_0
        {
            /*0x10*/ System.Func<long> getter;

            /*0x72f0ca8*/ <>c__DisplayClass19_0();
            /*0x72f2c64*/ object <CreateGetOnlyLongProperty>b__0();
        }

        class <>c__DisplayClass20_0
        {
            /*0x10*/ System.Func<ulong> getter;

            /*0x72f0dc0*/ <>c__DisplayClass20_0();
            /*0x72f2ca8*/ object <CreateGetOnlyULongProperty>b__0();
        }

        class <>c__DisplayClass21_0
        {
            /*0x10*/ System.Func<char> getter;

            /*0x72f0ed8*/ <>c__DisplayClass21_0();
            /*0x72f2cec*/ object <CreateGetOnlyCharProperty>b__0();
        }

        class <>c__DisplayClass22_0
        {
            /*0x10*/ System.Func<float> getter;

            /*0x72f0ff0*/ <>c__DisplayClass22_0();
            /*0x72f2d30*/ object <CreateGetOnlyFloatProperty>b__0();
        }

        class <>c__DisplayClass23_0
        {
            /*0x10*/ System.Func<double> getter;

            /*0x72f1108*/ <>c__DisplayClass23_0();
            /*0x72f2d70*/ object <CreateGetOnlyDoubleProperty>b__0();
        }

        class <>c__DisplayClass24_0
        {
            /*0x10*/ System.Func<decimal> getter;

            /*0x72f1220*/ <>c__DisplayClass24_0();
            /*0x72f2db0*/ object <CreateGetOnlyDecimalProperty>b__0();
        }

        class <>c__DisplayClass25_0
        {
            /*0x10*/ System.Func<bool> getter;

            /*0x72f1338*/ <>c__DisplayClass25_0();
            /*0x72f2e48*/ object <CreateGetOnlyBoolProperty>b__0();
        }

        class <>c__DisplayClass41_0<T>
        {
            /*0x0*/ System.Func<T> getter;
            /*0x0*/ System.Action<T> setter;

            /*0x380cb08*/ <>c__DisplayClass41_0();
            /*0x380b9e8*/ System.Enum <CreateMutableEnumProperty>b__0();
            /*0x380d83c*/ void <CreateMutableEnumProperty>b__1(System.Enum value);
        }
    }

    class MethodHandler
    {
        /*0x10*/ bool <IsDone>k__BackingField;

        /*0x72f2ea4*/ MethodHandler();
        /*0x72f2e90*/ bool get_IsDone();
        /*0x72f2e98*/ void set_IsDone(bool value);
    }

    class CustomInformationRegister
    {
        static /*0x72f2eac*/ void AddGroup(string name, string displayName, int order);
        static /*0x72f2f94*/ void AddKeyValue(string groupName, string keyName, System.Func<string> getValue, string displayName, int order);
        static /*0x72f3098*/ string GetCustomInformationValue(string keyName);
        static /*0x72f317c*/ NoaDebugger.NoaCustomInformationGroup GetCustomInformationGroup(string keyName);
        static /*0x72f324c*/ System.Collections.Generic.List<NoaDebugger.NoaCustomInformationGroup> GetCustomInformationAll();
        static /*0x72f3314*/ void RemoveKeyValue(string keyName);
        static /*0x72f33e0*/ void RemoveGroup(string groupName);
        static /*0x72f34ac*/ void RemoveAll();
        static /*0x72f3570*/ void RefreshView();
    }

    class NoaCustomInformationGroup
    {
        /*0x10*/ string <Name>k__BackingField;
        /*0x18*/ System.Collections.Generic.Dictionary<string, string> <KeyValues>k__BackingField;

        /*0x72f3644*/ NoaCustomInformationGroup(string groupName, System.Collections.Generic.Dictionary<string, string> keyValues);
        /*0x72f3634*/ string get_Name();
        /*0x72f363c*/ System.Collections.Generic.Dictionary<string, string> get_KeyValues();
    }

    class NoaInformation
    {
        static /*0x72f3688*/ NoaDebugger.SystemInformation get_SystemInformation();
        static /*0x72f3754*/ NoaDebugger.UnityInformation get_UnityInformation();
        static /*0x72f368c*/ NoaDebugger.SystemInformation _GetSystemInformation();
        static /*0x72f3758*/ NoaDebugger.UnityInformation _GetUnityInformation();
        static /*0x72f3820*/ System.Func<string, string, bool> get_OnDownload();
        static /*0x72f38dc*/ void set_OnDownload(System.Func<string, string, bool> value);
        /*0x72f3a30*/ NoaInformation();
    }

    class ApplicationInfo
    {
        /*0x10*/ string <Identification>k__BackingField;
        /*0x18*/ string <Version>k__BackingField;
        /*0x20*/ string <Language>k__BackingField;
        /*0x28*/ string <Platform>k__BackingField;

        /*0x72f3a78*/ ApplicationInfo();
        /*0x72f3a38*/ void set_Identification(string value);
        /*0x72f3a40*/ string get_Identification();
        /*0x72f3a48*/ void set_Version(string value);
        /*0x72f3a50*/ string get_Version();
        /*0x72f3a58*/ void set_Language(string value);
        /*0x72f3a60*/ string get_Language();
        /*0x72f3a68*/ void set_Platform(string value);
        /*0x72f3a70*/ string get_Platform();
    }

    class CpuInfo
    {
        /*0x10*/ string <Type>k__BackingField;
        /*0x18*/ string <Count>k__BackingField;

        /*0x72f3bc0*/ CpuInfo();
        /*0x72f3ba0*/ void set_Type(string value);
        /*0x72f3ba8*/ string get_Type();
        /*0x72f3bb0*/ void set_Count(string value);
        /*0x72f3bb8*/ string get_Count();
    }

    class DeviceInfo
    {
        /*0x10*/ string <OS>k__BackingField;
        /*0x18*/ string <Model>k__BackingField;
        /*0x20*/ string <Type>k__BackingField;
        /*0x28*/ string <Name>k__BackingField;

        /*0x72f3c64*/ DeviceInfo(string deviceType);
        /*0x72f3c24*/ void set_OS(string value);
        /*0x72f3c2c*/ string get_OS();
        /*0x72f3c34*/ void set_Model(string value);
        /*0x72f3c3c*/ string get_Model();
        /*0x72f3c44*/ void set_Type(string value);
        /*0x72f3c4c*/ string get_Type();
        /*0x72f3c54*/ void set_Name(string value);
        /*0x72f3c5c*/ string get_Name();
    }

    class DisplayInfo
    {
        static /*0x0*/ int AspectRatioValueDigits;
        static /*0x4*/ int AspectRatioXYDigits;
        static /*0x8*/ System.ValueTuple<int, int> CommonAspectRatios;
        /*0x10*/ int <RefreshRate>k__BackingField;
        /*0x14*/ int <ScreenWidth>k__BackingField;
        /*0x18*/ int <ScreenHeight>k__BackingField;
        /*0x1c*/ float <AspectRatioValue>k__BackingField;
        /*0x20*/ float <AspectX>k__BackingField;
        /*0x24*/ float <AspectY>k__BackingField;
        /*0x28*/ string <Dpi>k__BackingField;
        /*0x30*/ string <Orientation>k__BackingField;
        /*0x38*/ string <FullscreenMode>k__BackingField;

        static /*0x72f4330*/ DisplayInfo();
        /*0x72f3d6c*/ DisplayInfo();
        /*0x72f3cdc*/ void set_RefreshRate(int value);
        /*0x72f3ce4*/ int get_RefreshRate();
        /*0x72f3cec*/ void set_ScreenWidth(int value);
        /*0x72f3cf4*/ int get_ScreenWidth();
        /*0x72f3cfc*/ void set_ScreenHeight(int value);
        /*0x72f3d04*/ int get_ScreenHeight();
        /*0x72f3d0c*/ void set_AspectRatioValue(float value);
        /*0x72f3d14*/ float get_AspectRatioValue();
        /*0x72f3d1c*/ void set_AspectX(float value);
        /*0x72f3d24*/ float get_AspectX();
        /*0x72f3d2c*/ void set_AspectY(float value);
        /*0x72f3d34*/ float get_AspectY();
        /*0x72f3d3c*/ void set_Dpi(string value);
        /*0x72f3d44*/ string get_Dpi();
        /*0x72f3d4c*/ void set_Orientation(string value);
        /*0x72f3d54*/ string get_Orientation();
        /*0x72f3d5c*/ void set_FullscreenMode(string value);
        /*0x72f3d64*/ string get_FullscreenMode();
        /*0x72f3d88*/ void Refresh();
        /*0x72f3f30*/ System.ValueTuple<float, float, float> _GetAspectRatio(int screenWidth, int screenHeight);
        /*0x72f4220*/ float _GetRoundedAspectRatioValue(float top, float bottom);
        /*0x72f428c*/ float _GetRoundedValue(float value, int digits);
        /*0x72f41a8*/ string _GetScreenOrientationString();
        /*0x72f4210*/ string _GetFullscreenModeString();

        class <>c__DisplayClass41_0
        {
            /*0x10*/ NoaDebugger.DisplayInfo <>4__this;
            /*0x18*/ float aspectRatioValue;
            /*0x1c*/ System.ValueTuple<float, float> sameRatio;

            /*0x72f4218*/ <>c__DisplayClass41_0();
            /*0x72f4678*/ float <_GetAspectRatio>b__0(System.ValueTuple<int, int> common);
        }
    }

    class GpuInfo
    {
        /*0x10*/ string <DeviceName>k__BackingField;
        /*0x18*/ string <DeviceType>k__BackingField;
        /*0x20*/ string <DeviceVersion>k__BackingField;
        /*0x28*/ string <DeviceVendor>k__BackingField;
        /*0x30*/ float <DeviceSizeGB>k__BackingField;

        /*0x72f47a4*/ GpuInfo();
        /*0x72f4754*/ void set_DeviceName(string value);
        /*0x72f475c*/ string get_DeviceName();
        /*0x72f4764*/ void set_DeviceType(string value);
        /*0x72f476c*/ string get_DeviceType();
        /*0x72f4774*/ void set_DeviceVersion(string value);
        /*0x72f477c*/ string get_DeviceVersion();
        /*0x72f4784*/ void set_DeviceVendor(string value);
        /*0x72f478c*/ string get_DeviceVendor();
        /*0x72f4794*/ void set_DeviceSizeGB(float value);
        /*0x72f479c*/ float get_DeviceSizeGB();
    }

    class SystemInformation
    {
        /*0x10*/ NoaDebugger.ApplicationInfo <ApplicationInfo>k__BackingField;
        /*0x18*/ NoaDebugger.DeviceInfo <DeviceInfo>k__BackingField;
        /*0x20*/ NoaDebugger.CpuInfo <CpuInfo>k__BackingField;
        /*0x28*/ NoaDebugger.GpuInfo <GpuInfo>k__BackingField;
        /*0x30*/ NoaDebugger.SystemMemoryInfo <SystemMemoryInfo>k__BackingField;
        /*0x38*/ NoaDebugger.DisplayInfo <DisplayInfo>k__BackingField;

        /*0x72f48f0*/ SystemInformation(NoaDebugger.SystemInformationModel model);
        /*0x72f4890*/ void set_ApplicationInfo(NoaDebugger.ApplicationInfo value);
        /*0x72f4898*/ NoaDebugger.ApplicationInfo get_ApplicationInfo();
        /*0x72f48a0*/ void set_DeviceInfo(NoaDebugger.DeviceInfo value);
        /*0x72f48a8*/ NoaDebugger.DeviceInfo get_DeviceInfo();
        /*0x72f48b0*/ void set_CpuInfo(NoaDebugger.CpuInfo value);
        /*0x72f48b8*/ NoaDebugger.CpuInfo get_CpuInfo();
        /*0x72f48c0*/ void set_GpuInfo(NoaDebugger.GpuInfo value);
        /*0x72f48c8*/ NoaDebugger.GpuInfo get_GpuInfo();
        /*0x72f48d0*/ void set_SystemMemoryInfo(NoaDebugger.SystemMemoryInfo value);
        /*0x72f48d8*/ NoaDebugger.SystemMemoryInfo get_SystemMemoryInfo();
        /*0x72f48e0*/ void set_DisplayInfo(NoaDebugger.DisplayInfo value);
        /*0x72f48e8*/ NoaDebugger.DisplayInfo get_DisplayInfo();
    }

    class SystemMemoryInfo
    {
        /*0x10*/ float <MemorySizeMB>k__BackingField;

        /*0x72f4988*/ SystemMemoryInfo(float memorySizeMB);
        /*0x72f4978*/ void set_MemorySizeMB(float value);
        /*0x72f4980*/ float get_MemorySizeMB();
    }

    class FeaturesInfo
    {
        /*0x10*/ bool <Location>k__BackingField;
        /*0x11*/ bool <Accelerometer>k__BackingField;
        /*0x12*/ bool <Gyroscope>k__BackingField;
        /*0x13*/ bool <Vibration>k__BackingField;

        /*0x72f4a00*/ FeaturesInfo();
        /*0x72f49b0*/ void set_Location(bool value);
        /*0x72f49bc*/ bool get_Location();
        /*0x72f49c4*/ void set_Accelerometer(bool value);
        /*0x72f49d0*/ bool get_Accelerometer();
        /*0x72f49d8*/ void set_Gyroscope(bool value);
        /*0x72f49e4*/ bool get_Gyroscope();
        /*0x72f49ec*/ void set_Vibration(bool value);
        /*0x72f49f8*/ bool get_Vibration();
    }

    class GraphicsInfo
    {
        /*0x10*/ int <MaxTexSize>k__BackingField;
        /*0x14*/ UnityEngine.NPOTSupport <NpotSupport>k__BackingField;
        /*0x18*/ bool <ComputeShaders>k__BackingField;
        /*0x19*/ bool <Shadows>k__BackingField;
        /*0x1a*/ bool <SparseTextures>k__BackingField;

        /*0x72f4ab4*/ GraphicsInfo();
        /*0x72f4a58*/ void set_MaxTexSize(int value);
        /*0x72f4a60*/ int get_MaxTexSize();
        /*0x72f4a68*/ void set_NpotSupport(UnityEngine.NPOTSupport value);
        /*0x72f4a70*/ UnityEngine.NPOTSupport get_NpotSupport();
        /*0x72f4a78*/ void set_ComputeShaders(bool value);
        /*0x72f4a84*/ bool get_ComputeShaders();
        /*0x72f4a8c*/ void set_Shadows(bool value);
        /*0x72f4a98*/ bool get_Shadows();
        /*0x72f4aa0*/ void set_SparseTextures(bool value);
        /*0x72f4aac*/ bool get_SparseTextures();
    }

    class RuntimeInfo
    {
        /*0x10*/ float <PlayTime>k__BackingField;
        /*0x14*/ float <LevelPlayTime>k__BackingField;
        /*0x18*/ string <CurrentLevelSceneName>k__BackingField;
        /*0x20*/ int <CurrentLevelBuildIndex>k__BackingField;
        /*0x24*/ int <QualityLevel>k__BackingField;
        /*0x28*/ string <RenderPipeline>k__BackingField;
        /*0x30*/ string <SRPBatcher>k__BackingField;

        /*0x72f4b84*/ RuntimeInfo();
        /*0x72f4b14*/ void set_PlayTime(float value);
        /*0x72f4b1c*/ float get_PlayTime();
        /*0x72f4b24*/ void set_LevelPlayTime(float value);
        /*0x72f4b2c*/ float get_LevelPlayTime();
        /*0x72f4b34*/ void set_CurrentLevelSceneName(string value);
        /*0x72f4b3c*/ string get_CurrentLevelSceneName();
        /*0x72f4b44*/ void set_CurrentLevelBuildIndex(int value);
        /*0x72f4b4c*/ int get_CurrentLevelBuildIndex();
        /*0x72f4b54*/ void set_QualityLevel(int value);
        /*0x72f4b5c*/ int get_QualityLevel();
        /*0x72f4b64*/ void set_RenderPipeline(string value);
        /*0x72f4b6c*/ string get_RenderPipeline();
        /*0x72f4b74*/ void set_SRPBatcher(string value);
        /*0x72f4b7c*/ string get_SRPBatcher();
        /*0x72f4e3c*/ void RefreshTime();
        /*0x72f4e64*/ void RefreshScene();
        /*0x72f4c5c*/ void RefreshRenderPipelineSettings();
    }

    class UnityInfo
    {
        /*0x10*/ string <Version>k__BackingField;
        /*0x18*/ bool <Debug>k__BackingField;
        /*0x19*/ bool <IL2CPP>k__BackingField;
        /*0x1c*/ int <VSyncCount>k__BackingField;
        /*0x20*/ int <TargetFrameRate>k__BackingField;

        /*0x72f4f5c*/ UnityInfo();
        /*0x72f4f04*/ void set_Version(string value);
        /*0x72f4f0c*/ string get_Version();
        /*0x72f4f14*/ void set_Debug(bool value);
        /*0x72f4f20*/ bool get_Debug();
        /*0x72f4f28*/ void set_IL2CPP(bool value);
        /*0x72f4f34*/ bool get_IL2CPP();
        /*0x72f4f3c*/ void set_VSyncCount(int value);
        /*0x72f4f44*/ int get_VSyncCount();
        /*0x72f4f4c*/ void set_TargetFrameRate(int value);
        /*0x72f4f54*/ int get_TargetFrameRate();
        /*0x72f5024*/ void Refresh();
    }

    class UnityInformation
    {
        /*0x10*/ NoaDebugger.UnityInfo <UnityInfo>k__BackingField;
        /*0x18*/ NoaDebugger.RuntimeInfo <RuntimeInfo>k__BackingField;
        /*0x20*/ NoaDebugger.FeaturesInfo <FeaturesInfo>k__BackingField;
        /*0x28*/ NoaDebugger.GraphicsInfo <GraphicsInfo>k__BackingField;

        /*0x72f50cc*/ UnityInformation(NoaDebugger.UnityInformationModel model);
        /*0x72f508c*/ void set_UnityInfo(NoaDebugger.UnityInfo value);
        /*0x72f5094*/ NoaDebugger.UnityInfo get_UnityInfo();
        /*0x72f509c*/ void set_RuntimeInfo(NoaDebugger.RuntimeInfo value);
        /*0x72f50a4*/ NoaDebugger.RuntimeInfo get_RuntimeInfo();
        /*0x72f50ac*/ void set_FeaturesInfo(NoaDebugger.FeaturesInfo value);
        /*0x72f50b4*/ NoaDebugger.FeaturesInfo get_FeaturesInfo();
        /*0x72f50bc*/ void set_GraphicsInfo(NoaDebugger.GraphicsInfo value);
        /*0x72f50c4*/ NoaDebugger.GraphicsInfo get_GraphicsInfo();
    }

    class ApiLogEntry : NoaDebugger.LogEntry<NoaDebugger.ApiLog>
    {
        /*0x40*/ NoaDebugger.ApiLog <LogDetail>k__BackingField;

        /*0x72f5144*/ ApiLogEntry(int serialNumber, string logString, string logViewString, NoaDebugger.ApiLog logDetail, NoaDebugger.LogType logType, System.DateTime receivedAt);
        /*0x72f5134*/ void set_LogDetail(NoaDebugger.ApiLog value);
        /*0x72f513c*/ NoaDebugger.ApiLog get_LogDetail();
    }

    class ConsoleLogDetail : NoaDebugger.ILogDetail
    {
        /*0x10*/ string <LogDetailString>k__BackingField;
        /*0x18*/ string <LogDetailStringForDisplay>k__BackingField;
        /*0x20*/ bool <IsRegisteredApi>k__BackingField;

        /*0x72f51fc*/ ConsoleLogDetail(string logString, string stackTrace, bool isRegisteredApi);
        /*0x72f51e4*/ string get_LogDetailString();
        /*0x72f51ec*/ string get_LogDetailStringForDisplay();
        /*0x72f51f4*/ bool get_IsRegisteredApi();
        /*0x72f545c*/ string NoaDebugger.ILogDetail.GetClipboardText();
    }

    class ConsoleLogEntry : NoaDebugger.LogEntry<NoaDebugger.ConsoleLogDetail>
    {
        /*0x40*/ string <StackTraceString>k__BackingField;
        /*0x48*/ NoaDebugger.ConsoleLogDetail <LogDetail>k__BackingField;

        /*0x72f5498*/ ConsoleLogEntry(int serialNumber, string logString, string stackTraceString, string logViewString, NoaDebugger.ConsoleLogDetail logDetail, NoaDebugger.LogType logType, System.DateTime receivedAt);
        /*0x72f5478*/ void set_StackTraceString(string value);
        /*0x72f5480*/ string get_StackTraceString();
        /*0x72f5488*/ void set_LogDetail(NoaDebugger.ConsoleLogDetail value);
        /*0x72f5490*/ NoaDebugger.ConsoleLogDetail get_LogDetail();
    }

    interface ILogDetail
    {
        /*0x380b9e8*/ string GetClipboardText();
    }

    class LogEntry<TLogDetail>
    {
        /*0x0*/ string <LogString>k__BackingField;
        /*0x0*/ string <LogViewString>k__BackingField;
        /*0x0*/ bool <HasLoggedOnce>k__BackingField;
        /*0x0*/ NoaDebugger.LogType <LogType>k__BackingField;
        /*0x0*/ System.DateTime <ReceivedAt>k__BackingField;
        /*0x0*/ int <NumberOfMatchingLogs>k__BackingField;
        /*0x0*/ bool <IsSelecting>k__BackingField;
        /*0x0*/ int _serialNumber;

        /*0x3907c14*/ LogEntry(int serialNumber, string logString, string logViewString, NoaDebugger.LogType logType, System.DateTime receivedAt);
        /*0x380d83c*/ void set_LogString(string value);
        /*0x380b9e8*/ string get_LogString();
        /*0x380d83c*/ void set_LogViewString(string value);
        /*0x380b9e8*/ string get_LogViewString();
        /*0x380cdf0*/ void set_HasLoggedOnce(bool value);
        /*0x380b128*/ bool get_HasLoggedOnce();
        /*0x380cffc*/ void set_LogType(NoaDebugger.LogType value);
        /*0x380b6a0*/ NoaDebugger.LogType get_LogType();
        void set_ReceivedAt(System.DateTime value);
        /*0x380b538*/ System.DateTime get_ReceivedAt();
        /*0x3907c14*/ void set_LogDetail(TLogDetail value);
        /*0x3907c14*/ TLogDetail get_LogDetail();
        /*0x380cffc*/ void set_NumberOfMatchingLogs(int value);
        /*0x380b6a0*/ int get_NumberOfMatchingLogs();
        /*0x380cdf0*/ void set_IsSelecting(bool value);
        /*0x380b128*/ bool get_IsSelecting();
    }

    enum LogType
    {
        Error = 0,
        Warning = 1,
        Log = 2,
    }

    class NoaApiLog
    {
        static /*0x72f5554*/ System.Collections.Generic.LinkedList<NoaDebugger.ApiLogEntry> get_LogList();
        static /*0x72f5620*/ UnityEngine.Events.UnityAction<NoaDebugger.ApiLogEntry> get_OnError();
        static /*0x72f56dc*/ void set_OnError(UnityEngine.Events.UnityAction<NoaDebugger.ApiLogEntry> value);
        static /*0x72f5830*/ UnityEngine.Events.UnityAction<NoaDebugger.ApiLogEntry, string> get_OnLogCopied();
        static /*0x72f58ec*/ void set_OnLogCopied(UnityEngine.Events.UnityAction<NoaDebugger.ApiLogEntry, string> value);
        static /*0x72f5a40*/ System.Func<string, string, bool> get_OnLogDownload();
        static /*0x72f5afc*/ void set_OnLogDownload(System.Func<string, string, bool> value);
        static /*0x72f5c5c*/ System.Func<string, System.Collections.Generic.List<NoaDebugger.ApiLogEntry>, bool> get_OnLogDownloadWithLogEntries();
        static /*0x72f5d18*/ void set_OnLogDownloadWithLogEntries(System.Func<string, System.Collections.Generic.List<NoaDebugger.ApiLogEntry>, bool> value);
        static /*0x72f5e78*/ UnityEngine.Events.UnityAction<System.Collections.Generic.List<NoaDebugger.ApiLogEntry>> get_OnLogSend();
        static /*0x72f5f34*/ void set_OnLogSend(UnityEngine.Events.UnityAction<System.Collections.Generic.List<NoaDebugger.ApiLogEntry>> value);
        static /*0x72f5558*/ System.Collections.Generic.LinkedList<NoaDebugger.ApiLogEntry> _GetLogList();
        static /*0x72f6088*/ void Clear();
        /*0x72f6160*/ NoaApiLog();
    }

    class NoaConsoleLog
    {
        static /*0x72f6168*/ System.Collections.Generic.LinkedList<NoaDebugger.ConsoleLogEntry> get_LogList();
        static /*0x72f62b0*/ UnityEngine.Events.UnityAction<NoaDebugger.ConsoleLogEntry> get_OnError();
        static /*0x72f636c*/ void set_OnError(UnityEngine.Events.UnityAction<NoaDebugger.ConsoleLogEntry> value);
        static /*0x72f64c0*/ System.Func<NoaDebugger.ConsoleLogEntry, bool> get_OnFilterErrorNotification();
        static /*0x72f657c*/ void set_OnFilterErrorNotification(System.Func<NoaDebugger.ConsoleLogEntry, bool> value);
        static /*0x72f66d0*/ UnityEngine.Events.UnityAction<NoaDebugger.ConsoleLogEntry, string> get_OnLogCopied();
        static /*0x72f678c*/ void set_OnLogCopied(UnityEngine.Events.UnityAction<NoaDebugger.ConsoleLogEntry, string> value);
        static /*0x72f68e0*/ System.Func<string, string, bool> get_OnLogDownload();
        static /*0x72f699c*/ void set_OnLogDownload(System.Func<string, string, bool> value);
        static /*0x72f6afc*/ System.Func<string, System.Collections.Generic.List<NoaDebugger.ConsoleLogEntry>, bool> get_OnLogDownloadWithLogEntries();
        static /*0x72f6bb8*/ void set_OnLogDownloadWithLogEntries(System.Func<string, System.Collections.Generic.List<NoaDebugger.ConsoleLogEntry>, bool> value);
        static /*0x72f6d18*/ UnityEngine.Events.UnityAction<System.Collections.Generic.List<NoaDebugger.ConsoleLogEntry>> get_OnLogSend();
        static /*0x72f6dd4*/ void set_OnLogSend(UnityEngine.Events.UnityAction<System.Collections.Generic.List<NoaDebugger.ConsoleLogEntry>> value);
        static /*0x72f616c*/ System.Collections.Generic.LinkedList<NoaDebugger.ConsoleLogEntry> _GetLogList();
        static /*0x72f6f28*/ void _AddUnsafe(UnityEngine.LogType logType, string message, string stackTrace);
        static /*0x72f7044*/ void Add(UnityEngine.LogType logType, string message, string stackTrace);
        static /*0x72f7238*/ void Clear();
        /*0x72f733c*/ NoaConsoleLog();
    }

    class NoaController
    {
        static /*0x0*/ int CustomActionButtonCount;

        static /*0x72f7534*/ NoaController();
        static /*0x72f7344*/ System.Action get_OnShow();
        static /*0x72f734c*/ void set_OnShow(System.Action value);
        static /*0x72f7354*/ System.Action get_OnHide();
        static /*0x72f735c*/ void set_OnHide(System.Action value);
        static /*0x72f7364*/ System.Action<bool> get_OnTogglePauseResume();
        static /*0x72f736c*/ void set_OnTogglePauseResume(System.Action<bool> value);
        static /*0x72f7374*/ System.Action<float> get_OnGameSpeedChanged();
        static /*0x72f737c*/ void set_OnGameSpeedChanged(System.Action<float> value);
        static /*0x72f7384*/ System.Func<bool> get_OnApplicationReset();
        static /*0x72f738c*/ void set_OnApplicationReset(System.Func<bool> value);
        static /*0x72f7394*/ System.Func<bool, bool> get_OnToggleNoaDebuggerUI();
        static /*0x72f73d4*/ void set_OnToggleNoaDebuggerUI(System.Func<bool, bool> value);
        static /*0x72f7424*/ System.Func<NoaDebugger.NoaController.ScreenshotTarget> get_OnBeforeScreenshot();
        static /*0x72f742c*/ void set_OnBeforeScreenshot(System.Func<NoaDebugger.NoaController.ScreenshotTarget> value);
        static /*0x72f7434*/ System.Func<bool> get_OnCaptureScreenshot();
        static /*0x72f743c*/ void set_OnCaptureScreenshot(System.Func<bool> value);
        static /*0x72f7444*/ System.Action get_OnAfterScreenshot();
        static /*0x72f744c*/ void set_OnAfterScreenshot(System.Action value);
        static /*0x72f7454*/ System.Action get_OnFrameStepping();
        static /*0x72f745c*/ void set_OnFrameStepping(System.Action value);
        static /*0x72f7464*/ bool get_IsVisible();
        static /*0x72f7468*/ bool get_IsGamePlaying();
        static /*0x72f7470*/ float get_GameSpeed();
        static /*0x72f7478*/ void Show();
        static /*0x72f7480*/ void Hide();
        static /*0x72f7488*/ void SetCustomTapAction(int buttonIndex, System.Action action, System.Func<string> messageFunc);
        static /*0x72f7490*/ void SetCustomLongPressAction(int buttonIndex, System.Action action, System.Func<string> messageFunc);
        static /*0x72f7498*/ void SetCustomToggleAction(int buttonIndex, System.Action<bool> action, System.Func<bool, string> messageFunc, System.Nullable<bool> initialState);
        static /*0x72f74a4*/ void SetCustomActionType(int buttonIndex, NoaDebugger.NoaController.CustomActionType actionType);
        static /*0x72f74ac*/ NoaDebugger.NoaController.CustomActionType GetCustomActionType(int buttonIndex);
        static /*0x72f74b4*/ void RunCustomTapAction(int buttonIndex);
        static /*0x72f74bc*/ void RunCustomLongPressAction(int buttonIndex);
        static /*0x72f74c4*/ void SetCustomToggle(int buttonIndex, bool isOn);
        static /*0x72f74d0*/ bool GetCustomToggle(int buttonIndex);
        static /*0x72f74d8*/ void TogglePauseResume();
        static /*0x72f74e0*/ void IncreaseGameSpeed();
        static /*0x72f74e8*/ void DecreaseGameSpeed();
        static /*0x72f74f0*/ void MinimizeGameSpeed();
        static /*0x72f74f8*/ void MaximizeGameSpeed();
        static /*0x72f7500*/ void ResetGameSpeed();
        static /*0x72f7508*/ void FrameStepping();
        static /*0x72f7510*/ void ResetApplication();
        static /*0x72f7518*/ void ToggleNoaDebuggerUI();
        static /*0x72f751c*/ void CaptureScreenshot();
        static /*0x72f7524*/ byte[] GetCapturedScreenshot();
        static /*0x72f752c*/ void ClearCapturedScreenshot();

        enum CustomActionType
        {
            Button = 0,
            ToggleButton = 1,
            Default = 0,
        }

        enum ScreenshotTarget
        {
            None = 0,
            LaunchButton = 1,
            FloatingWindows = 2,
            UIElement = 4,
            MainView = 8,
            Overlays = 16,
            All = 31,
        }
    }

    class NoaCustomMenuBase : NoaDebugger.INoaDebuggerTool
    {
        /*0x10*/ UnityEngine.GameObject _viewObj;
        /*0x18*/ UnityEngine.GameObject _mainView;
        /*0x20*/ NoaDebugger.NoaCustomMenuBase.CustomMenuInfo _customMenuInfo;

        /*0x72f7a28*/ NoaCustomMenuBase();
        /*0x72f7580*/ NoaDebugger.ToolNotificationStatus NoaDebugger.INoaDebuggerTool.get_NotifyStatus();
        /*0x72f7588*/ void NoaDebugger.INoaDebuggerTool.Init();
        /*0x72f7604*/ NoaDebugger.IMenuInfo NoaDebugger.INoaDebuggerTool.MenuInfo();
        /*0x72f76dc*/ void NoaDebugger.INoaDebuggerTool.ShowView(UnityEngine.Transform parent);
        /*0x72f788c*/ void _ShowView(UnityEngine.GameObject view);
        /*0x72f78dc*/ void NoaDebugger.INoaDebuggerTool.AlignmentUI(bool isReverse);
        /*0x72f78e0*/ void NoaDebugger.INoaDebuggerTool.OnHidden();
        /*0x72f7984*/ void NoaDebugger.INoaDebuggerTool.OnToolDispose();
        /*0x72f7a18*/ void OnShow(UnityEngine.GameObject view);
        /*0x72f7a1c*/ void OnHide();
        /*0x72f7a20*/ void OnInitialize();
        /*0x72f7a24*/ void OnDispose();
        /*0x380b9e8*/ string get_ViewPrefabPath();
        /*0x380b9e8*/ string get_MenuName();

        class CustomMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x10*/ string <MenuName>k__BackingField;

            /*0x72f76ac*/ CustomMenuInfo(string menuName);
            /*0x72f7a48*/ CustomMenuInfo();
            /*0x72f7a30*/ string get_Name();
            /*0x72f7a38*/ string get_MenuName();
            /*0x72f7a40*/ int get_SortNo();
        }
    }

    class NoaDebug
    {
        static /*0x72f7a50*/ System.Action<int> get_OnShow();
        static /*0x72f7a9c*/ void set_OnShow(System.Action<int> value);
        static /*0x72f7af0*/ System.Action<int> get_OnHide();
        static /*0x72f7b3c*/ void set_OnHide(System.Action<int> value);
        static /*0x72f7b90*/ System.Action<int, bool> get_OnMenuChanged();
        static /*0x72f7bdc*/ void set_OnMenuChanged(System.Action<int, bool> value);
        static /*0x72f7c30*/ UnityEngine.Transform get_RootTransform();
        static /*0x72f7c7c*/ bool get_IsInitialized();
        static /*0x72f7cc8*/ bool get_IsShortcutsEnabled();
        static /*0x72f7d14*/ bool get_IsWorldSpaceRenderingEnabled();
        static /*0x72f7d60*/ bool get_IsDebuggerVisible();
        static /*0x72f7d64*/ bool get_IsTriggerButtonVisible();
        static /*0x72f7d68*/ bool get_IsOverlayVisible();
        static /*0x72f7d6c*/ bool get_IsFloatingWindowVisible();
        static /*0x72f7d70*/ void Initialize();
        static /*0x72f7dc0*/ void Show();
        static /*0x72f7e14*/ void Show(System.Nullable<int> index, bool isCustomMenu);
        static /*0x72f7eac*/ void Show(NoaDebugger.NoaDebug.MenuType menuType);
        static /*0x72f7f00*/ void Hide();
        static /*0x72f7f4c*/ void SetDebuggerActive(bool isActive);
        static /*0x72f7f54*/ void SetOverlayActive(bool isActive);
        static /*0x72f7f5c*/ void SetOverlayEnabled(NoaDebugger.NoaDebug.OverlayFeatures feature, bool isEnabled);
        static /*0x72f7fc0*/ bool GetOverlayEnabled(NoaDebugger.NoaDebug.OverlayFeatures feature);
        static /*0x72f8014*/ void SetFloatingWindowActive(bool isActive);
        static /*0x72f801c*/ void SetTriggerButtonActive(bool isActive);
        static /*0x72f8024*/ void SetFont(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material fontMaterial, float fontSizeRate);
        static /*0x72f8098*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, NoaDebugger.NoaDebug.HierarchyLevelGroup group);
        static /*0x72f82a8*/ void SetShortcutsEnabled(bool isEnabled);
        static /*0x72f82fc*/ void EnableWorldSpaceRendering(UnityEngine.Camera worldCamera);
        static /*0x72f8350*/ void DisableWorldSpaceRendering();
        static /*0x72f839c*/ void CopyToClipboard(string text);
        static /*0x72f83f0*/ void DownloadText(string text, string fileName, string mimeType);
        static /*0x72f845c*/ void Destroy();
        static /*0x72f84a8*/ void TakeScreenshot(System.Action<System.Byte[]> callback);

        enum HierarchyLevelGroup
        {
            FloatingWindow = 0,
            UIElement = 1,
            MainView = 2,
            Dialog = 3,
            Overlay = 4,
        }

        enum OverlayFeatures
        {
            Profiler = 1,
            ConsoleLog = 3,
            ApiLog = 4,
        }

        enum OverlayPosition
        {
            UpperLeft = 0,
            UpperCenter = 1,
            UpperRight = 2,
            MiddleLeft = 3,
            MiddleRight = 4,
            LowerLeft = 5,
            LowerCenter = 6,
            LowerRight = 7,
        }

        enum MenuType
        {
            Information = 0,
            Profiler = 1,
            Snapshot = 2,
            ConsoleLog = 3,
            APILog = 4,
            Hierarchy = 5,
            Command = 6,
        }
    }

    class NoaPrefs
    {
        static /*0x72f84b0*/ void SetString(string key, string value);
        static /*0x72f8588*/ void SetSByte(string key, sbyte value);
        static /*0x72f85fc*/ void SetByte(string key, byte value);
        static /*0x72f8670*/ void SetShort(string key, short value);
        static /*0x72f86e4*/ void SetUShort(string key, ushort value);
        static /*0x72f8758*/ void SetInt(string key, int value);
        static /*0x72f87cc*/ void SetUInt(string key, uint value);
        static /*0x72f8840*/ void SetLong(string key, long value);
        static /*0x72f88b4*/ void SetULong(string key, ulong value);
        static /*0x72f8928*/ void SetChar(string key, char value);
        static /*0x72f899c*/ void SetFloat(string key, float value);
        static /*0x72f8a10*/ void SetDouble(string key, double value);
        static /*0x72f8a84*/ void SetDecimal(string key, decimal value);
        static /*0x72f8b00*/ void SetBoolean(string key, bool value);
        static /*0x72f8b74*/ string GetString(string key, string defaultValue);
        static /*0x72f8be8*/ sbyte GetSByte(string key, sbyte defaultValue);
        static /*0x72f8c5c*/ byte GetByte(string key, byte defaultValue);
        static /*0x72f8cd0*/ short GetShort(string key, short defaultValue);
        static /*0x72f8d44*/ ushort GetUShort(string key, ushort defaultValue);
        static /*0x72f8db8*/ int GetInt(string key, int defaultValue);
        static /*0x72f8e2c*/ uint GetUInt(string key, uint defaultValue);
        static /*0x72f8ea0*/ long GetLong(string key, long defaultValue);
        static /*0x72f8f14*/ ulong GetULong(string key, ulong defaultValue);
        static /*0x72f8f88*/ char GetChar(string key, char defaultValue);
        static /*0x72f8ffc*/ float GetFloat(string key, float defaultValue);
        static /*0x72f9070*/ double GetDouble(string key, double defaultValue);
        static /*0x72f90e4*/ decimal GetDecimal(string key, decimal defaultValue);
        static /*0x72f9160*/ bool GetBoolean(string key, bool defaultValue);
        static /*0x72f91d4*/ void DeleteAt(string key);
        static /*0x72f9238*/ void DeleteAllSaveData();
        static /*0x72f93d8*/ void DeleteAllToolData();
        static /*0x72f8524*/ string _GetSaveKey(string key);
        /*0x72f9424*/ NoaPrefs();
    }

    class NoaUIElement
    {
        static /*0x72f942c*/ void RegisterUIElement(NoaDebugger.INoaUIElement element);
        static /*0x72f9480*/ void UnregisterUIElement(string key);
        static /*0x72f94d4*/ void UnregisterAllUIElements();
        static /*0x72f9520*/ bool IsUIElementRegistered(string key);
        static /*0x72f9574*/ void SetUIElementVisibility(string key, bool visible);
        static /*0x72f95d8*/ void SetAllUIElementsVisibility(bool visible);
        static /*0x72f95e0*/ bool IsUIElementVisible(string key);
        static /*0x72f9634*/ void SetVerticalAlignment(NoaDebugger.AnchorType anchorType);
        static /*0x72f9688*/ void SetHorizontalAlignment(NoaDebugger.AnchorType anchorType);
    }

    enum AnchorType
    {
        UpperLeft = 0,
        UpperCenter = 1,
        UpperRight = 2,
        MiddleLeft = 3,
        MiddleCenter = 4,
        MiddleRight = 5,
        LowerLeft = 6,
        LowerCenter = 7,
        LowerRight = 8,
    }

    interface INoaUIElement
    {
        /*0x380b9e8*/ string get_Key();
        /*0x380b6a0*/ NoaDebugger.AnchorType get_AnchorType();
        /*0x380b9e8*/ UnityEngine.RectTransform get_Parent();
    }

    interface IUpdatableNoaUIElement : NoaDebugger.INoaUIElement
    {
        /*0x380c2e4*/ float get_UpdateInterval();
        /*0x380b9e8*/ string UpdateValue();
    }

    class NoaUIObjectElement : NoaDebugger.INoaUIElement
    {
        /*0x10*/ string _key;
        /*0x18*/ NoaDebugger.AnchorType _anchorType;
        /*0x20*/ UnityEngine.RectTransform _parent;
        /*0x28*/ UnityEngine.GameObject _prefab;
        /*0x30*/ System.Action<UnityEngine.GameObject> _onObjectCreated;
        /*0x38*/ float _width;
        /*0x3c*/ float _height;

        static /*0x72f9714*/ NoaDebugger.NoaUIObjectElement Create(string key, UnityEngine.GameObject prefab, System.Action<UnityEngine.GameObject> onObjectCreated, NoaDebugger.AnchorType anchorType, float width, float height);
        static /*0x72f97e0*/ NoaDebugger.NoaUIObjectElement Create(string key, UnityEngine.GameObject prefab, System.Action<UnityEngine.GameObject> onObjectCreated, UnityEngine.RectTransform parent, float width, float height);
        /*0x72f97d8*/ NoaUIObjectElement();
        /*0x72f96dc*/ string get_Key();
        /*0x72f96e4*/ NoaDebugger.AnchorType get_AnchorType();
        /*0x72f96ec*/ UnityEngine.RectTransform get_Parent();
        /*0x72f96f4*/ UnityEngine.GameObject get_Prefab();
        /*0x72f96fc*/ System.Action<UnityEngine.GameObject> get_OnObjectCreated();
        /*0x72f9704*/ float get_Width();
        /*0x72f970c*/ float get_Height();
    }

    class NoaUITextElement : NoaDebugger.IUpdatableNoaUIElement, NoaDebugger.INoaUIElement
    {
        /*0x10*/ string _key;
        /*0x18*/ NoaDebugger.AnchorType _anchorType;
        /*0x20*/ UnityEngine.RectTransform _parent;
        /*0x28*/ System.Func<string> _value;
        /*0x30*/ float _updateInterval;

        static /*0x72f98d0*/ NoaDebugger.NoaUITextElement Create(string key, System.Func<string> value, NoaDebugger.AnchorType anchorType, float updateInterval);
        static /*0x72f997c*/ NoaDebugger.NoaUITextElement Create(string key, System.Func<string> value, UnityEngine.RectTransform parent, float updateInterval);
        static /*0x72f9a2c*/ NoaDebugger.NoaUITextElement Create(string key, string value, NoaDebugger.AnchorType anchorType, float updateInterval);
        static /*0x72f9b60*/ NoaDebugger.NoaUITextElement Create(string key, string value, UnityEngine.RectTransform parent, float updateInterval);
        /*0x72f9974*/ NoaUITextElement();
        /*0x72f98b0*/ string get_Key();
        /*0x72f98b8*/ NoaDebugger.AnchorType get_AnchorType();
        /*0x72f98c0*/ UnityEngine.RectTransform get_Parent();
        /*0x72f98c8*/ float get_UpdateInterval();
        /*0x72f9ca0*/ string UpdateValue();

        class <>c__DisplayClass15_0
        {
            /*0x10*/ string value;

            /*0x72f9b58*/ <>c__DisplayClass15_0();
            /*0x72f9cc4*/ string <Create>b__0();
        }

        class <>c__DisplayClass16_0
        {
            /*0x10*/ string value;

            /*0x72f9c98*/ <>c__DisplayClass16_0();
            /*0x72f9ccc*/ string <Create>b__0();
        }
    }

    class NoaUIButtonElement : NoaDebugger.INoaUIElement
    {
        /*0x10*/ string _key;
        /*0x18*/ NoaDebugger.AnchorType _anchorType;
        /*0x20*/ UnityEngine.RectTransform _parent;
        /*0x28*/ string _label;
        /*0x30*/ UnityEngine.Events.UnityAction _onClick;

        static /*0x72f9cfc*/ NoaDebugger.NoaUIButtonElement Create(string key, string label, UnityEngine.Events.UnityAction onClick, NoaDebugger.AnchorType anchorType);
        static /*0x72f9db4*/ NoaDebugger.NoaUIButtonElement Create(string key, string label, UnityEngine.Events.UnityAction onClick, UnityEngine.RectTransform parent);
        /*0x72f9dac*/ NoaUIButtonElement();
        /*0x72f9cd4*/ string get_Key();
        /*0x72f9cdc*/ NoaDebugger.AnchorType get_AnchorType();
        /*0x72f9ce4*/ UnityEngine.RectTransform get_Parent();
        /*0x72f9cec*/ string get_Label();
        /*0x72f9cf4*/ UnityEngine.Events.UnityAction get_OnClick();
    }

    class BatteryInfo
    {
        /*0x10*/ NoaDebugger.BatteryStatus <Status>k__BackingField;
        /*0x14*/ float <CurrentLevelPercent>k__BackingField;
        /*0x18*/ float <ConsumptionPerMinute>k__BackingField;
        /*0x1c*/ int <OperatingTimeSec>k__BackingField;
        /*0x20*/ bool <IsProfiling>k__BackingField;
        /*0x21*/ bool <IsStartProfiling>k__BackingField;

        /*0x72f9f88*/ BatteryInfo();
        /*0x72f9e70*/ void set_Status(NoaDebugger.BatteryStatus value);
        /*0x72f9e78*/ NoaDebugger.BatteryStatus get_Status();
        /*0x72f9e80*/ void set_CurrentLevelPercent(float value);
        /*0x72f9e88*/ float get_CurrentLevelPercent();
        /*0x72f9e90*/ void set_ConsumptionPerMinute(float value);
        /*0x72f9e98*/ float get_ConsumptionPerMinute();
        /*0x72f9ea0*/ void set_OperatingTimeSec(int value);
        /*0x72f9ea8*/ int get_OperatingTimeSec();
        /*0x72f9eb0*/ void set_IsProfiling(bool value);
        /*0x72f9ebc*/ bool get_IsProfiling();
        /*0x72f9ec4*/ void set_IsStartProfiling(bool value);
        /*0x72f9ed0*/ bool get_IsStartProfiling();
        /*0x72f9ed8*/ void Refresh(UnityEngine.BatteryStatus batteryStatus, float currentLevelPercent, float consumptionPerMinute, int operatingTimeSec);
        /*0x72f9f34*/ void StartProfiling();
        /*0x72f9f40*/ void SetIsProfiling(bool isProfiling);
        /*0x72f9f4c*/ void StatusUpdate(UnityEngine.BatteryStatus batteryStatus);
        /*0x72f9ef8*/ NoaDebugger.BatteryStatus StatusCheck(UnityEngine.BatteryStatus batteryStatus);
    }

    enum BatteryStatus
    {
        Unknown = 0,
        Default = 1,
        Profiling = 2,
        Charging = 3,
    }

    class BatteryUnchangingInfo
    {
        /*0x10*/ NoaDebugger.BatteryStatus <Status>k__BackingField;
        /*0x14*/ float <CurrentLevelPercent>k__BackingField;
        /*0x18*/ float <ConsumptionPerMinute>k__BackingField;
        /*0x1c*/ int <OperatingTimeSec>k__BackingField;
        /*0x20*/ bool <IsProfiling>k__BackingField;
        /*0x21*/ bool <IsViewHyphen>k__BackingField;

        /*0x72f9fc0*/ BatteryUnchangingInfo(NoaDebugger.BatteryInfo info);
        /*0x72f9f90*/ NoaDebugger.BatteryStatus get_Status();
        /*0x72f9f98*/ float get_CurrentLevelPercent();
        /*0x72f9fa0*/ float get_ConsumptionPerMinute();
        /*0x72f9fa8*/ int get_OperatingTimeSec();
        /*0x72f9fb0*/ bool get_IsProfiling();
        /*0x72f9fb8*/ bool get_IsViewHyphen();
    }

    class FpsInfo
    {
        /*0x10*/ int <CurrentFps>k__BackingField;
        /*0x14*/ float <ElapsedTime>k__BackingField;
        /*0x18*/ int <Max>k__BackingField;
        /*0x20*/ string <MaxStr>k__BackingField;
        /*0x28*/ int <Min>k__BackingField;
        /*0x30*/ string <MinStr>k__BackingField;
        /*0x38*/ int <TotalFrames>k__BackingField;
        /*0x3c*/ float <TotalSeconds>k__BackingField;
        /*0x40*/ bool <IsProfiling>k__BackingField;
        /*0x41*/ bool <IsStartProfiling>k__BackingField;

        /*0x72fa1d0*/ FpsInfo();
        /*0x72fa074*/ void set_CurrentFps(int value);
        /*0x72fa07c*/ int get_CurrentFps();
        /*0x72fa084*/ void set_ElapsedTime(float value);
        /*0x72fa08c*/ float get_ElapsedTime();
        /*0x72fa094*/ void set_Max(int value);
        /*0x72fa09c*/ int get_Max();
        /*0x72fa0a4*/ void set_MaxStr(string value);
        /*0x72fa0ac*/ string get_MaxStr();
        /*0x72fa0b4*/ void set_Min(int value);
        /*0x72fa0bc*/ int get_Min();
        /*0x72fa0c4*/ void set_MinStr(string value);
        /*0x72fa0cc*/ string get_MinStr();
        /*0x72fa0d4*/ void set_TotalFrames(int value);
        /*0x72fa0dc*/ int get_TotalFrames();
        /*0x72fa0e4*/ void set_TotalSeconds(float value);
        /*0x72fa0ec*/ float get_TotalSeconds();
        /*0x72fa0f4*/ void set_IsProfiling(bool value);
        /*0x72fa100*/ bool get_IsProfiling();
        /*0x72fa108*/ void set_IsStartProfiling(bool value);
        /*0x72fa114*/ bool get_IsStartProfiling();
        /*0x72fa11c*/ void Refresh(int currentFps, float elapsedTime, int totalFrames, float totalSeconds);
        /*0x72fa1b8*/ void StartProfiling();
        /*0x72fa1c4*/ void SetIsProfiling(bool isProfiling);
    }

    class FpsUnchangingInfo
    {
        /*0x10*/ int <CurrentFps>k__BackingField;
        /*0x14*/ float <ElapsedTime>k__BackingField;
        /*0x18*/ int <Max>k__BackingField;
        /*0x20*/ string <MaxStr>k__BackingField;
        /*0x28*/ int <Min>k__BackingField;
        /*0x30*/ string <MinStr>k__BackingField;
        /*0x38*/ int <AverageFps>k__BackingField;
        /*0x3c*/ bool <IsProfiling>k__BackingField;
        /*0x3d*/ bool <IsViewHyphen>k__BackingField;

        /*0x72fa290*/ FpsUnchangingInfo(NoaDebugger.FpsInfo info);
        /*0x72fa248*/ int get_CurrentFps();
        /*0x72fa250*/ float get_ElapsedTime();
        /*0x72fa258*/ int get_Max();
        /*0x72fa260*/ string get_MaxStr();
        /*0x72fa268*/ int get_Min();
        /*0x72fa270*/ string get_MinStr();
        /*0x72fa278*/ int get_AverageFps();
        /*0x72fa280*/ bool get_IsProfiling();
        /*0x72fa288*/ bool get_IsViewHyphen();
    }

    class MemoryInfo
    {
        static /*0x0*/ float DefaultTotalNativeMemoryMB;
        /*0x10*/ float <CurrentReservedMemoryMB>k__BackingField;
        /*0x14*/ float <MaxReservedMemoryMB>k__BackingField;
        /*0x18*/ float <CurrentAllocatedMemoryMB>k__BackingField;
        /*0x1c*/ float <MaxAllocatedMemoryMB>k__BackingField;
        /*0x20*/ float <MinAllocatedMemoryMB>k__BackingField;
        /*0x24*/ float <AverageAllocatedMemoryMB>k__BackingField;
        /*0x28*/ float <TotalNativeMemoryMB>k__BackingField;
        /*0x2c*/ float <CurrentNativeMemoryMB>k__BackingField;
        /*0x30*/ float <MaxNativeMemoryMB>k__BackingField;
        /*0x34*/ float <MinNativeMemoryMB>k__BackingField;
        /*0x38*/ float <AverageNativeMemoryMB>k__BackingField;
        /*0x3c*/ float <CurrentMonoHeapSizeMB>k__BackingField;
        /*0x40*/ float <MaxMonoHeapSizeMB>k__BackingField;
        /*0x44*/ float <CurrentMonoUsedSizeMB>k__BackingField;
        /*0x48*/ float <MaxMonoUsedSizeMB>k__BackingField;
        /*0x4c*/ float <MinMonoUsedSizeMB>k__BackingField;
        /*0x50*/ float <AverageMonoUsedSizeMB>k__BackingField;
        /*0x54*/ bool <IsProfiling>k__BackingField;
        /*0x58*/ NoaDebugger.NoaProfiler.MemoryProfilingType <ProfilingType>k__BackingField;
        /*0x60*/ NoaDebugger.RingBuffer<System.Single[]> <CurrentMemoryHistory>k__BackingField;
        /*0x68*/ System.Collections.Generic.List<System.Single[]> _currentMemoryHistoryValueBuffer;
        /*0x70*/ bool <IsGraphShowing>k__BackingField;
        /*0x71*/ bool <IsStartProfiling>k__BackingField;

        static /*0x72fab5c*/ MemoryInfo();
        /*0x72fa540*/ MemoryInfo();
        /*0x72fa3ac*/ void set_CurrentReservedMemoryMB(float value);
        /*0x72fa3b4*/ float get_CurrentReservedMemoryMB();
        /*0x72fa3bc*/ void set_MaxReservedMemoryMB(float value);
        /*0x72fa3c4*/ float get_MaxReservedMemoryMB();
        /*0x72fa3cc*/ void set_CurrentAllocatedMemoryMB(float value);
        /*0x72fa3d4*/ float get_CurrentAllocatedMemoryMB();
        /*0x72fa3dc*/ void set_MaxAllocatedMemoryMB(float value);
        /*0x72fa3e4*/ float get_MaxAllocatedMemoryMB();
        /*0x72fa3ec*/ void set_MinAllocatedMemoryMB(float value);
        /*0x72fa3f4*/ float get_MinAllocatedMemoryMB();
        /*0x72fa3fc*/ void set_AverageAllocatedMemoryMB(float value);
        /*0x72fa404*/ float get_AverageAllocatedMemoryMB();
        /*0x72fa40c*/ void set_TotalNativeMemoryMB(float value);
        /*0x72fa414*/ float get_TotalNativeMemoryMB();
        /*0x72fa41c*/ float get_TotalMemoryMB();
        /*0x72fa424*/ void set_CurrentNativeMemoryMB(float value);
        /*0x72fa42c*/ float get_CurrentNativeMemoryMB();
        /*0x72fa434*/ float get_CurrentMemoryMB();
        /*0x72fa43c*/ void set_MaxNativeMemoryMB(float value);
        /*0x72fa444*/ float get_MaxNativeMemoryMB();
        /*0x72fa44c*/ float get_MaxMemoryMB();
        /*0x72fa454*/ void set_MinNativeMemoryMB(float value);
        /*0x72fa45c*/ float get_MinNativeMemoryMB();
        /*0x72fa464*/ float get_MinMemoryMB();
        /*0x72fa46c*/ void set_AverageNativeMemoryMB(float value);
        /*0x72fa474*/ float get_AverageNativeMemoryMB();
        /*0x72fa47c*/ float get_AverageMemoryMB();
        /*0x72fa484*/ void set_CurrentMonoHeapSizeMB(float value);
        /*0x72fa48c*/ float get_CurrentMonoHeapSizeMB();
        /*0x72fa494*/ void set_MaxMonoHeapSizeMB(float value);
        /*0x72fa49c*/ float get_MaxMonoHeapSizeMB();
        /*0x72fa4a4*/ void set_CurrentMonoUsedSizeMB(float value);
        /*0x72fa4ac*/ float get_CurrentMonoUsedSizeMB();
        /*0x72fa4b4*/ void set_MaxMonoUsedSizeMB(float value);
        /*0x72fa4bc*/ float get_MaxMonoUsedSizeMB();
        /*0x72fa4c4*/ void set_MinMonoUsedSizeMB(float value);
        /*0x72fa4cc*/ float get_MinMonoUsedSizeMB();
        /*0x72fa4d4*/ void set_AverageMonoUsedSizeMB(float value);
        /*0x72fa4dc*/ float get_AverageMonoUsedSizeMB();
        /*0x72fa4e4*/ void set_IsProfiling(bool value);
        /*0x72fa4f0*/ bool get_IsProfiling();
        /*0x72fa4f8*/ void set_ProfilingType(NoaDebugger.NoaProfiler.MemoryProfilingType value);
        /*0x72fa500*/ NoaDebugger.NoaProfiler.MemoryProfilingType get_ProfilingType();
        /*0x72fa508*/ void set_CurrentMemoryHistory(NoaDebugger.RingBuffer<System.Single[]> value);
        /*0x72fa510*/ NoaDebugger.RingBuffer<System.Single[]> get_CurrentMemoryHistory();
        /*0x72fa518*/ void set_IsGraphShowing(bool value);
        /*0x72fa524*/ bool get_IsGraphShowing();
        /*0x72fa52c*/ void set_IsStartProfiling(bool value);
        /*0x72fa538*/ bool get_IsStartProfiling();
        /*0x72fa7f0*/ void SetTotalNativeMemoryMB(float totalMemoryMB);
        /*0x72fa86c*/ void ResetProfiledValue();
        /*0x72fa89c*/ void RefreshUnityMemory(float currentReservedMemoryMB, float currentAllocatedMemoryMB, float averageAllocatedMemoryMB);
        /*0x72fa9ec*/ void RefreshNativeMemory(float currentMemoryMB, float averageMemoryMB);
        /*0x72faa28*/ void RefreshMonoMemory(float currentMonoHeapSizeMB, float currentMonoUsedSizeMB, float averageMonoUsedSizeMB);
        /*0x72faa6c*/ void StartProfiling();
        /*0x72faa78*/ void ToggleProfiling(bool isProfiling);
        /*0x72faa84*/ void ToggleGraphShowing(bool isShowing);
        /*0x72faaf0*/ void ChangeProfilingType(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
        /*0x72fab20*/ bool IsValid();
        /*0x72fa5d8*/ void _InitializeHistoryBuffer();
        /*0x72fa8dc*/ void _AddHistory(float currentMemoryCapacityMB, float currentMemoryUsageMB);
    }

    class MemoryUnchangingInfo
    {
        /*0x10*/ float <CurrentReservedMemoryMB>k__BackingField;
        /*0x14*/ float <MaxReservedMemoryMB>k__BackingField;
        /*0x18*/ float <CurrentAllocatedMemoryMB>k__BackingField;
        /*0x1c*/ float <MaxAllocatedMemoryMB>k__BackingField;
        /*0x20*/ float <MinAllocatedMemoryMB>k__BackingField;
        /*0x24*/ float <AverageAllocatedMemoryMB>k__BackingField;
        /*0x28*/ float <TotalNativeMemoryMB>k__BackingField;
        /*0x2c*/ float <TotalMemoryMB>k__BackingField;
        /*0x30*/ float <CurrentNativeMemoryMB>k__BackingField;
        /*0x34*/ float <CurrentMemoryMB>k__BackingField;
        /*0x38*/ float <MaxNativeMemoryMB>k__BackingField;
        /*0x3c*/ float <MaxMemoryMB>k__BackingField;
        /*0x40*/ float <MinNativeMemoryMB>k__BackingField;
        /*0x44*/ float <MinMemoryMB>k__BackingField;
        /*0x48*/ float <AverageNativeMemoryMB>k__BackingField;
        /*0x4c*/ float <AverageMemoryMB>k__BackingField;
        /*0x50*/ float <CurrentMonoHeapSizeMB>k__BackingField;
        /*0x54*/ float <MaxMonoHeapSizeMB>k__BackingField;
        /*0x58*/ float <CurrentMonoUsedSizeMB>k__BackingField;
        /*0x5c*/ float <MaxMonoUsedSizeMB>k__BackingField;
        /*0x60*/ float <MinMonoUsedSizeMB>k__BackingField;
        /*0x64*/ float <AverageMonoUsedSizeMB>k__BackingField;
        /*0x68*/ bool <IsProfiling>k__BackingField;
        /*0x6c*/ NoaDebugger.NoaProfiler.MemoryProfilingType <ProfilingType>k__BackingField;
        /*0x70*/ NoaDebugger.RingBuffer<System.Single[]> <CurrentMemoryHistory>k__BackingField;
        /*0x78*/ bool <IsGraphShowing>k__BackingField;
        /*0x79*/ bool <IsViewHyphen>k__BackingField;
        /*0x7a*/ bool <IsValid>k__BackingField;

        /*0x72fac90*/ MemoryUnchangingInfo(NoaDebugger.MemoryInfo info);
        /*0x72fabb0*/ float get_CurrentReservedMemoryMB();
        /*0x72fabb8*/ float get_MaxReservedMemoryMB();
        /*0x72fabc0*/ float get_CurrentAllocatedMemoryMB();
        /*0x72fabc8*/ float get_MaxAllocatedMemoryMB();
        /*0x72fabd0*/ float get_MinAllocatedMemoryMB();
        /*0x72fabd8*/ float get_AverageAllocatedMemoryMB();
        /*0x72fabe0*/ float get_TotalNativeMemoryMB();
        /*0x72fabe8*/ float get_TotalMemoryMB();
        /*0x72fabf0*/ float get_CurrentNativeMemoryMB();
        /*0x72fabf8*/ float get_CurrentMemoryMB();
        /*0x72fac00*/ float get_MaxNativeMemoryMB();
        /*0x72fac08*/ float get_MaxMemoryMB();
        /*0x72fac10*/ float get_MinNativeMemoryMB();
        /*0x72fac18*/ float get_MinMemoryMB();
        /*0x72fac20*/ float get_AverageNativeMemoryMB();
        /*0x72fac28*/ float get_AverageMemoryMB();
        /*0x72fac30*/ float get_CurrentMonoHeapSizeMB();
        /*0x72fac38*/ float get_MaxMonoHeapSizeMB();
        /*0x72fac40*/ float get_CurrentMonoUsedSizeMB();
        /*0x72fac48*/ float get_MaxMonoUsedSizeMB();
        /*0x72fac50*/ float get_MinMonoUsedSizeMB();
        /*0x72fac58*/ float get_AverageMonoUsedSizeMB();
        /*0x72fac60*/ bool get_IsProfiling();
        /*0x72fac68*/ NoaDebugger.NoaProfiler.MemoryProfilingType get_ProfilingType();
        /*0x72fac70*/ NoaDebugger.RingBuffer<System.Single[]> get_CurrentMemoryHistory();
        /*0x72fac78*/ bool get_IsGraphShowing();
        /*0x72fac80*/ bool get_IsViewHyphen();
        /*0x72fac88*/ bool get_IsValid();
    }

    class NoaProfiler
    {
        static /*0x72fada8*/ void SetMemoryProfilingType(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
        static /*0x72fae74*/ NoaDebugger.ProfilerInfo get_ProfilerInfo();
        static /*0x72faf58*/ NoaDebugger.FpsInfo get_LatestFpsInfo();
        static /*0x72fb024*/ NoaDebugger.MemoryInfo get_LatestMemoryInfo();
        static /*0x72fb0f0*/ NoaDebugger.RenderingInfo get_LatestRenderingInfo();
        static /*0x72fb1bc*/ NoaDebugger.BatteryInfo get_LatestBatteryInfo();
        static /*0x72fb288*/ NoaDebugger.ThermalInfo get_LatestThermalInfo();
        static /*0x72fb354*/ bool get_IsFpsProfiling();
        static /*0x72fb420*/ void set_IsFpsProfiling(bool value);
        static /*0x72fb4f4*/ bool get_IsMemoryProfiling();
        static /*0x72fb5c0*/ void set_IsMemoryProfiling(bool value);
        static /*0x72fb694*/ float get_TotalNativeMemoryMB();
        static /*0x72fb760*/ void set_TotalNativeMemoryMB(float value);
        static /*0x72fb83c*/ float get_TotalMemoryMB();
        static /*0x72fb840*/ void set_TotalMemoryMB(float value);
        static /*0x72fb844*/ bool get_IsRenderingProfiling();
        static /*0x72fb910*/ void set_IsRenderingProfiling(bool value);
        static /*0x72fb9e4*/ bool get_IsBatteryProfiling();
        static /*0x72fbab0*/ void set_IsBatteryProfiling(bool value);
        static /*0x72fbb84*/ bool get_IsThermalProfiling();
        static /*0x72fbc50*/ void set_IsThermalProfiling(bool value);
        static /*0x72fbd24*/ System.Func<bool> get_OnGcCollect();
        static /*0x72fbde0*/ void set_OnGcCollect(System.Func<bool> value);
        static /*0x72fbf34*/ System.Func<bool> get_OnUnloadAssets();
        static /*0x72fbff0*/ void set_OnUnloadAssets(System.Func<bool> value);
        static /*0x72fae78*/ NoaDebugger.ProfilerInfo _GetProfilerInfo();
        static /*0x72faf5c*/ NoaDebugger.FpsInfo _GetLatestFpsInfo();
        static /*0x72fb358*/ bool _IsFpsProfiling();
        static /*0x72fb428*/ void _ChangeFpsProfiling(bool isProfiling);
        static /*0x72fb028*/ NoaDebugger.MemoryInfo _GetLatestMemoryInfo();
        static /*0x72fb4f8*/ bool _IsMemoryProfiling();
        static /*0x72fb5c8*/ void _ChangeMemoryProfiling(bool isProfiling);
        static /*0x72fb698*/ float _GetTotalNativeMemoryMB();
        static /*0x72fb764*/ void _SetTotalNativeMemoryMB(float totalMemoryMB);
        static /*0x72fb0f4*/ NoaDebugger.RenderingInfo _GetLatestRenderingInfo();
        static /*0x72fb848*/ bool _IsRenderingProfiling();
        static /*0x72fb918*/ void _ChangeRenderingProfiling(bool isProfiling);
        static /*0x72fb1c0*/ NoaDebugger.BatteryInfo _GetLatestBatteryInfo();
        static /*0x72fb9e8*/ bool _IsBatteryProfiling();
        static /*0x72fbab8*/ void _ChangeBatteryProfiling(bool isProfiling);
        static /*0x72fb28c*/ NoaDebugger.ThermalInfo _GetLatestThermalInfo();
        static /*0x72fbb88*/ bool _IsThermalProfiling();
        static /*0x72fbc58*/ void _ChangeThermalProfiling(bool isProfiling);
        /*0x72fc144*/ NoaProfiler();

        enum FeatureType
        {
            Fps = 0,
            Memory = 1,
            Rendering = 2,
        }

        enum MemoryProfilingType
        {
            Unity = 0,
            Native = 1,
            Mono = 2,
        }

        enum OverlayAxis
        {
            Horizontal = 0,
            Vertical = 1,
        }

        enum OverlayTextType
        {
            Simple = 0,
            Full = 1,
        }
    }

    class ProfilerInfo
    {
        /*0x10*/ NoaDebugger.FpsInfo <FpsInfo>k__BackingField;
        /*0x18*/ NoaDebugger.MemoryInfo <MemoryInfo>k__BackingField;
        /*0x20*/ NoaDebugger.RenderingInfo <RenderingInfo>k__BackingField;
        /*0x28*/ NoaDebugger.BatteryInfo <BatteryInfo>k__BackingField;
        /*0x30*/ NoaDebugger.ThermalInfo <ThermalInfo>k__BackingField;

        /*0x72fc19c*/ ProfilerInfo(NoaDebugger.ProfilerPresenter presenter);
        /*0x72fc14c*/ void set_FpsInfo(NoaDebugger.FpsInfo value);
        /*0x72fc154*/ NoaDebugger.FpsInfo get_FpsInfo();
        /*0x72fc15c*/ void set_MemoryInfo(NoaDebugger.MemoryInfo value);
        /*0x72fc164*/ NoaDebugger.MemoryInfo get_MemoryInfo();
        /*0x72fc16c*/ void set_RenderingInfo(NoaDebugger.RenderingInfo value);
        /*0x72fc174*/ NoaDebugger.RenderingInfo get_RenderingInfo();
        /*0x72fc17c*/ void set_BatteryInfo(NoaDebugger.BatteryInfo value);
        /*0x72fc184*/ NoaDebugger.BatteryInfo get_BatteryInfo();
        /*0x72fc18c*/ void set_ThermalInfo(NoaDebugger.ThermalInfo value);
        /*0x72fc194*/ NoaDebugger.ThermalInfo get_ThermalInfo();
    }

    class ProfilerSnapshotData
    {
        /*0x10*/ NoaDebugger.FpsUnchangingInfo <FpsInfo>k__BackingField;
        /*0x18*/ NoaDebugger.MemoryUnchangingInfo <MemoryInfo>k__BackingField;
        /*0x20*/ NoaDebugger.RenderingUnchangingInfo <RenderingInfo>k__BackingField;
        /*0x28*/ NoaDebugger.BatteryUnchangingInfo <BatteryInfo>k__BackingField;
        /*0x30*/ NoaDebugger.ThermalUnchangingInfo <ThermalInfo>k__BackingField;

        /*0x72fc264*/ ProfilerSnapshotData(NoaDebugger.ProfilerPresenter profiler);
        /*0x72fc23c*/ NoaDebugger.FpsUnchangingInfo get_FpsInfo();
        /*0x72fc244*/ NoaDebugger.MemoryUnchangingInfo get_MemoryInfo();
        /*0x72fc24c*/ NoaDebugger.RenderingUnchangingInfo get_RenderingInfo();
        /*0x72fc254*/ NoaDebugger.BatteryUnchangingInfo get_BatteryInfo();
        /*0x72fc25c*/ NoaDebugger.ThermalUnchangingInfo get_ThermalInfo();
    }

    class RenderingInfo
    {
        /*0x10*/ long <CurrentSetPassCalls>k__BackingField;
        /*0x18*/ long <MaxSetPassCalls>k__BackingField;
        /*0x20*/ string <MaxSetPassCallsStr>k__BackingField;
        /*0x28*/ long <CurrentDrawCalls>k__BackingField;
        /*0x30*/ long <MaxDrawCalls>k__BackingField;
        /*0x38*/ string <MaxDrawCallsStr>k__BackingField;
        /*0x40*/ long <CurrentBatches>k__BackingField;
        /*0x48*/ long <MaxBatches>k__BackingField;
        /*0x50*/ string <MaxBatchesStr>k__BackingField;
        /*0x58*/ long <CurrentTriangles>k__BackingField;
        /*0x60*/ long <MaxTriangles>k__BackingField;
        /*0x68*/ string <MaxTrianglesStr>k__BackingField;
        /*0x70*/ long <CurrentVertices>k__BackingField;
        /*0x78*/ long <MaxVertices>k__BackingField;
        /*0x80*/ string <MaxVerticesStr>k__BackingField;
        /*0x88*/ bool <IsProfiling>k__BackingField;
        /*0x90*/ NoaDebugger.RingBuffer<System.Single[]> <CurrentValueHistory>k__BackingField;
        /*0x98*/ System.Collections.Generic.List<System.Single[]> _currentValueHistoryValueBuffer;
        /*0xa0*/ NoaDebugger.RenderingGraphTarget <GraphTarget>k__BackingField;
        /*0xa4*/ bool <IsGraphShowing>k__BackingField;
        /*0xa5*/ bool <IsStartProfiling>k__BackingField;

        /*0x72fc48c*/ RenderingInfo();
        /*0x72fc340*/ void set_CurrentSetPassCalls(long value);
        /*0x72fc348*/ long get_CurrentSetPassCalls();
        /*0x72fc350*/ void set_MaxSetPassCalls(long value);
        /*0x72fc358*/ long get_MaxSetPassCalls();
        /*0x72fc360*/ void set_MaxSetPassCallsStr(string value);
        /*0x72fc368*/ string get_MaxSetPassCallsStr();
        /*0x72fc370*/ void set_CurrentDrawCalls(long value);
        /*0x72fc378*/ long get_CurrentDrawCalls();
        /*0x72fc380*/ void set_MaxDrawCalls(long value);
        /*0x72fc388*/ long get_MaxDrawCalls();
        /*0x72fc390*/ void set_MaxDrawCallsStr(string value);
        /*0x72fc398*/ string get_MaxDrawCallsStr();
        /*0x72fc3a0*/ void set_CurrentBatches(long value);
        /*0x72fc3a8*/ long get_CurrentBatches();
        /*0x72fc3b0*/ void set_MaxBatches(long value);
        /*0x72fc3b8*/ long get_MaxBatches();
        /*0x72fc3c0*/ void set_MaxBatchesStr(string value);
        /*0x72fc3c8*/ string get_MaxBatchesStr();
        /*0x72fc3d0*/ void set_CurrentTriangles(long value);
        /*0x72fc3d8*/ long get_CurrentTriangles();
        /*0x72fc3e0*/ void set_MaxTriangles(long value);
        /*0x72fc3e8*/ long get_MaxTriangles();
        /*0x72fc3f0*/ void set_MaxTrianglesStr(string value);
        /*0x72fc3f8*/ string get_MaxTrianglesStr();
        /*0x72fc400*/ void set_CurrentVertices(long value);
        /*0x72fc408*/ long get_CurrentVertices();
        /*0x72fc410*/ void set_MaxVertices(long value);
        /*0x72fc418*/ long get_MaxVertices();
        /*0x72fc420*/ void set_MaxVerticesStr(string value);
        /*0x72fc428*/ string get_MaxVerticesStr();
        /*0x72fc430*/ void set_IsProfiling(bool value);
        /*0x72fc43c*/ bool get_IsProfiling();
        /*0x72fc444*/ void set_CurrentValueHistory(NoaDebugger.RingBuffer<System.Single[]> value);
        /*0x72fc44c*/ NoaDebugger.RingBuffer<System.Single[]> get_CurrentValueHistory();
        /*0x72fc454*/ void set_GraphTarget(NoaDebugger.RenderingGraphTarget value);
        /*0x72fc45c*/ NoaDebugger.RenderingGraphTarget get_GraphTarget();
        /*0x72fc464*/ void set_IsGraphShowing(bool value);
        /*0x72fc470*/ bool get_IsGraphShowing();
        /*0x72fc478*/ void set_IsStartProfiling(bool value);
        /*0x72fc484*/ bool get_IsStartProfiling();
        /*0x72fc724*/ void ResetProfiledValue();
        /*0x72fc7e8*/ void RefreshCurrent(long currentSetPassCalls, long currentDrawCalls, long currentBatches, long currentTriangles, long currentVertices);
        /*0x72fca48*/ void StartProfiling();
        /*0x72fca54*/ void ToggleProfiling(bool isProfiling);
        /*0x72fca60*/ void ToggleGraphShowing(bool isShowing);
        /*0x72fcacc*/ void SwitchGraphTarget(NoaDebugger.RenderingGraphTarget target);
        /*0x72fc544*/ void _InitializeHistoryBuffer();
    }

    class RenderingUnchangingInfo
    {
        /*0x10*/ long <CurrentSetPassCalls>k__BackingField;
        /*0x18*/ long <MaxSetPassCalls>k__BackingField;
        /*0x20*/ string <MaxSetPassCallsStr>k__BackingField;
        /*0x28*/ long <CurrentDrawCalls>k__BackingField;
        /*0x30*/ long <MaxDrawCalls>k__BackingField;
        /*0x38*/ string <MaxDrawCallsStr>k__BackingField;
        /*0x40*/ long <CurrentBatches>k__BackingField;
        /*0x48*/ long <MaxBatches>k__BackingField;
        /*0x50*/ string <MaxBatchesStr>k__BackingField;
        /*0x58*/ long <CurrentTriangles>k__BackingField;
        /*0x60*/ long <MaxTriangles>k__BackingField;
        /*0x68*/ string <MaxTrianglesStr>k__BackingField;
        /*0x70*/ long <CurrentVertices>k__BackingField;
        /*0x78*/ long <MaxVertices>k__BackingField;
        /*0x80*/ string <MaxVerticesStr>k__BackingField;
        /*0x88*/ bool <IsProfiling>k__BackingField;
        /*0x90*/ NoaDebugger.RingBuffer<System.Single[]> <CurrentValueHistory>k__BackingField;
        /*0x98*/ NoaDebugger.RenderingGraphTarget <GraphTarget>k__BackingField;
        /*0x9c*/ bool <IsGraphShowing>k__BackingField;
        /*0x9d*/ bool <IsViewHyphen>k__BackingField;

        /*0x72fcb9c*/ RenderingUnchangingInfo(NoaDebugger.RenderingInfo info);
        /*0x72fcafc*/ long get_CurrentSetPassCalls();
        /*0x72fcb04*/ long get_MaxSetPassCalls();
        /*0x72fcb0c*/ string get_MaxSetPassCallsStr();
        /*0x72fcb14*/ long get_CurrentDrawCalls();
        /*0x72fcb1c*/ long get_MaxDrawCalls();
        /*0x72fcb24*/ string get_MaxDrawCallsStr();
        /*0x72fcb2c*/ long get_CurrentBatches();
        /*0x72fcb34*/ long get_MaxBatches();
        /*0x72fcb3c*/ string get_MaxBatchesStr();
        /*0x72fcb44*/ long get_CurrentTriangles();
        /*0x72fcb4c*/ long get_MaxTriangles();
        /*0x72fcb54*/ string get_MaxTrianglesStr();
        /*0x72fcb5c*/ long get_CurrentVertices();
        /*0x72fcb64*/ long get_MaxVertices();
        /*0x72fcb6c*/ string get_MaxVerticesStr();
        /*0x72fcb74*/ bool get_IsProfiling();
        /*0x72fcb7c*/ NoaDebugger.RingBuffer<System.Single[]> get_CurrentValueHistory();
        /*0x72fcb84*/ NoaDebugger.RenderingGraphTarget get_GraphTarget();
        /*0x72fcb8c*/ bool get_IsGraphShowing();
        /*0x72fcb94*/ bool get_IsViewHyphen();
    }

    class ThermalInfo
    {
        /*0x10*/ float <CurrentTemperature>k__BackingField;
        /*0x14*/ NoaDebugger.ThermalStatus <CurrentThermalStatus>k__BackingField;
        /*0x18*/ float <MaxTemperature>k__BackingField;
        /*0x1c*/ NoaDebugger.ThermalStatus <MaxThermalStatus>k__BackingField;
        /*0x20*/ float <MinTemperature>k__BackingField;
        /*0x24*/ NoaDebugger.ThermalStatus <MinThermalStatus>k__BackingField;
        /*0x28*/ float <AverageTemperature>k__BackingField;
        /*0x2c*/ bool <IsProfiling>k__BackingField;
        /*0x2d*/ bool <IsStartProfiling>k__BackingField;

        /*0x72fcd90*/ ThermalInfo();
        /*0x72fcc8c*/ void set_CurrentTemperature(float value);
        /*0x72fcc94*/ float get_CurrentTemperature();
        /*0x72fcc9c*/ void set_CurrentThermalStatus(NoaDebugger.ThermalStatus value);
        /*0x72fcca4*/ NoaDebugger.ThermalStatus get_CurrentThermalStatus();
        /*0x72fccac*/ void set_MaxTemperature(float value);
        /*0x72fccb4*/ float get_MaxTemperature();
        /*0x72fccbc*/ void set_MaxThermalStatus(NoaDebugger.ThermalStatus value);
        /*0x72fccc4*/ NoaDebugger.ThermalStatus get_MaxThermalStatus();
        /*0x72fcccc*/ void set_MinTemperature(float value);
        /*0x72fccd4*/ float get_MinTemperature();
        /*0x72fccdc*/ void set_MinThermalStatus(NoaDebugger.ThermalStatus value);
        /*0x72fcce4*/ NoaDebugger.ThermalStatus get_MinThermalStatus();
        /*0x72fccec*/ void set_AverageTemperature(float value);
        /*0x72fccf4*/ float get_AverageTemperature();
        /*0x72fccfc*/ void set_IsProfiling(bool value);
        /*0x72fcd08*/ bool get_IsProfiling();
        /*0x72fcd10*/ void set_IsStartProfiling(bool value);
        /*0x72fcd1c*/ bool get_IsStartProfiling();
        /*0x72fcd24*/ void RefreshTemperature(float currentTemperature, float averageTemperature);
        /*0x72fcd50*/ void RefreshThermalStatus(NoaDebugger.ThermalStatus currentStatus);
        /*0x72fcd78*/ void StartProfiling();
        /*0x72fcd84*/ void SetIsProfiling(bool isProfiling);
    }

    enum ThermalStatus
    {
        Unknown = 0,
        Nominal = 1,
        Fair = 2,
        Serious = 3,
        Critical = 4,
    }

    class ThermalUnchangingInfo
    {
        /*0x10*/ float <CurrentTemperature>k__BackingField;
        /*0x14*/ NoaDebugger.ThermalStatus <CurrentThermalStatus>k__BackingField;
        /*0x18*/ float <MaxTemperature>k__BackingField;
        /*0x1c*/ NoaDebugger.ThermalStatus <MaxThermalStatus>k__BackingField;
        /*0x20*/ float <MinTemperature>k__BackingField;
        /*0x24*/ NoaDebugger.ThermalStatus <MinThermalStatus>k__BackingField;
        /*0x28*/ float <AverageTemperature>k__BackingField;
        /*0x2c*/ bool <IsProfiling>k__BackingField;
        /*0x2d*/ bool <IsViewHyphen>k__BackingField;

        static /*0x72fced4*/ string ConvertThermalStatusText(NoaDebugger.ThermalStatus status);
        /*0x72fce00*/ ThermalUnchangingInfo(NoaDebugger.ThermalInfo info);
        /*0x72fcdb8*/ float get_CurrentTemperature();
        /*0x72fcdc0*/ NoaDebugger.ThermalStatus get_CurrentThermalStatus();
        /*0x72fcdc8*/ float get_MaxTemperature();
        /*0x72fcdd0*/ NoaDebugger.ThermalStatus get_MaxThermalStatus();
        /*0x72fcdd8*/ float get_MinTemperature();
        /*0x72fcde0*/ NoaDebugger.ThermalStatus get_MinThermalStatus();
        /*0x72fcde8*/ float get_AverageTemperature();
        /*0x72fcdf0*/ bool get_IsProfiling();
        /*0x72fcdf8*/ bool get_IsViewHyphen();
    }

    class NoaSnapshot
    {
        static /*0x72fcf64*/ System.Collections.Generic.List<NoaDebugger.SnapshotLogRecordInformation> get_LogList();
        static /*0x72fd030*/ UnityEngine.Events.UnityAction<NoaDebugger.SnapshotLogRecordInformation, string> get_OnLogCopied();
        static /*0x72fd0ec*/ void set_OnLogCopied(UnityEngine.Events.UnityAction<NoaDebugger.SnapshotLogRecordInformation, string> value);
        static /*0x72fd240*/ System.Func<string, string, bool> get_OnLogDownload();
        static /*0x72fd2fc*/ void set_OnLogDownload(System.Func<string, string, bool> value);
        static /*0x72fd450*/ void ClearLogsAndTimer();
        static /*0x72fd514*/ void CaptureLog(string label, System.Nullable<NoaDebugger.NoaSnapshot.BgColor> backgroundColor, bool hasNoaProfilerInfo, System.Collections.Generic.Dictionary<string, NoaDebugger.NoaSnapshotCategory> additionalInfo);
        static /*0x72fcf68*/ System.Collections.Generic.List<NoaDebugger.SnapshotLogRecordInformation> _GetLogList();
        /*0x72fd8ac*/ NoaSnapshot();

        enum BgColor
        {
            Default = 0,
            Brown = 1,
            DarkBrown = 2,
            Green = 3,
            LightBlue = 4,
            DarkPurple = 5,
            Black = 6,
            DarkGreen = 7,
            YellowGreen = 8,
            Blue = 9,
            Purple = 10,
        }

        enum FontColor
        {
            White = 0,
            Black = 1,
            Gray = 2,
            LightBlue = 3,
            Orange = 4,
            Yellow = 5,
            Blue = 6,
            Purple = 7,
            Green = 8,
            Red = 9,
        }
    }

    class NoaSnapshotCategory
    {
        /*0x10*/ System.Collections.Generic.List<NoaDebugger.NoaSnapshotCategoryItem> _categoryItems;

        /*0x72fd8bc*/ NoaSnapshotCategory();
        /*0x72fd8b4*/ System.Collections.Generic.List<NoaDebugger.NoaSnapshotCategoryItem> get_CategoryItems();
        /*0x72fd944*/ void Add(NoaDebugger.NoaSnapshotCategoryItem item);

        class <>c__DisplayClass4_0
        {
            /*0x10*/ NoaDebugger.NoaSnapshotCategoryItem item;

            /*0x72fdadc*/ <>c__DisplayClass4_0();
            /*0x72fdae4*/ bool <Add>b__0(NoaDebugger.NoaSnapshotCategoryItem categoryItem);
        }
    }

    class NoaSnapshotCategoryItem
    {
        /*0x10*/ string <Key>k__BackingField;
        /*0x18*/ string <Value>k__BackingField;
        /*0x20*/ NoaDebugger.NoaSnapshot.FontColor <Color>k__BackingField;

        /*0x72fdb0c*/ NoaSnapshotCategoryItem(string key, string value, NoaDebugger.NoaSnapshot.FontColor color);
        /*0x72fdb64*/ string get_Key();
        /*0x72fdb6c*/ string get_Value();
        /*0x72fdb74*/ NoaDebugger.NoaSnapshot.FontColor get_Color();
    }

    class SnapshotLogRecordInformation
    {
        /*0x10*/ int <Id>k__BackingField;
        /*0x18*/ string <Label>k__BackingField;
        /*0x20*/ System.TimeSpan <Time>k__BackingField;
        /*0x28*/ System.TimeSpan <ElapsedTime>k__BackingField;
        /*0x30*/ bool <IsHighlighted>k__BackingField;
        /*0x31*/ bool <IsSelected>k__BackingField;
        /*0x34*/ NoaDebugger.SnapshotModel.ToggleState <ToggleState>k__BackingField;
        /*0x38*/ NoaDebugger.ProfilerSnapshotData <Snapshot>k__BackingField;
        /*0x40*/ System.Nullable<UnityEngine.Color> <BackgroundColor>k__BackingField;
        /*0x58*/ System.Collections.Generic.Dictionary<string, NoaDebugger.NoaSnapshotCategory> <AdditionalInfo>k__BackingField;

        /*0x72fdc3c*/ SnapshotLogRecordInformation(int id, string label, System.TimeSpan time, System.TimeSpan elapsedTime, NoaDebugger.ProfilerSnapshotData snapshotData, System.Nullable<UnityEngine.Color> backgroundColor, System.Collections.Generic.Dictionary<string, NoaDebugger.NoaSnapshotCategory> additionalInfo);
        /*0x72fdb7c*/ int get_Id();
        /*0x72fdb84*/ void set_Id(int value);
        /*0x72fdb8c*/ string get_Label();
        /*0x72fdb94*/ void set_Label(string value);
        /*0x72fdb9c*/ System.TimeSpan get_Time();
        /*0x72fdba4*/ void set_Time(System.TimeSpan value);
        /*0x72fdbac*/ System.TimeSpan get_ElapsedTime();
        /*0x72fdbb4*/ void set_ElapsedTime(System.TimeSpan value);
        /*0x72fdbbc*/ bool get_IsHighlighted();
        /*0x72fdbc4*/ void set_IsHighlighted(bool value);
        /*0x72fdbd0*/ bool get_IsSelected();
        /*0x72fdbd8*/ void set_IsSelected(bool value);
        /*0x72fdbe4*/ NoaDebugger.SnapshotModel.ToggleState get_ToggleState();
        /*0x72fdbec*/ void set_ToggleState(NoaDebugger.SnapshotModel.ToggleState value);
        /*0x72fdbf4*/ NoaDebugger.ProfilerSnapshotData get_Snapshot();
        /*0x72fdbfc*/ void set_Snapshot(NoaDebugger.ProfilerSnapshotData value);
        /*0x72fdc04*/ System.Nullable<UnityEngine.Color> get_BackgroundColor();
        /*0x72fdc18*/ void set_BackgroundColor(System.Nullable<UnityEngine.Color> value);
        /*0x72fdc2c*/ System.Collections.Generic.Dictionary<string, NoaDebugger.NoaSnapshotCategory> get_AdditionalInfo();
        /*0x72fdc34*/ void set_AdditionalInfo(System.Collections.Generic.Dictionary<string, NoaDebugger.NoaSnapshotCategory> value);
        /*0x72fdcd4*/ void SetHighlighted(bool highlighted);
        /*0x72fdce0*/ void SetSelected(bool selected);
        /*0x72fdcec*/ void SetToggleState(NoaDebugger.SnapshotModel.ToggleState state);
        /*0x72fdcf4*/ void SetLabel(string text);
    }

    enum RenderingGraphTarget
    {
        SetPassCalls = 0,
        DrawCalls = 1,
        Batches = 2,
        Triangles = 3,
        Vertices = 4,
    }

    class RingBuffer<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        /*0x0*/ T[] _buffer;
        /*0x0*/ int <Count>k__BackingField;
        /*0x0*/ int <Top>k__BackingField;
        /*0x0*/ int <Tail>k__BackingField;

        /*0x380cffc*/ RingBuffer(int capacity);
        /*0x380b6a0*/ int get_Count();
        /*0x380cffc*/ void set_Count(int value);
        /*0x380b6a0*/ int get_Capacity();
        /*0x380b128*/ bool get_IsEmpty();
        /*0x380b128*/ bool get_IsFull();
        /*0x380b6a0*/ int get_Top();
        /*0x380cffc*/ void set_Top(int value);
        /*0x380b6a0*/ int get_Tail();
        /*0x380cffc*/ void set_Tail(int value);
        /*0x3907c14*/ void Append(T element);
        /*0x380cb08*/ void Clear();
        /*0x380cffc*/ void Remove(int index);
        /*0x3907c14*/ T At(int index);
        /*0x380b6cc*/ int NextPosition(int current);
        /*0x380b9e8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        /*0x380b9e8*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();

        struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ NoaDebugger.RingBuffer<T> _target;
            /*0x0*/ int _current;
            /*0x0*/ int _count;

            /*0x380d83c*/ Enumerator(NoaDebugger.RingBuffer<T> target);
            /*0x380cb08*/ void Dispose();
            /*0x380b128*/ bool MoveNext();
            /*0x380cb08*/ void Reset();
            /*0x3907c14*/ T get_Current();
            /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    struct SemanticVersion : System.IComparable<NoaDebugger.SemanticVersion>
    {
        static string VERSION_PATTERN = "\d+(\.\d+){0,2}";
        static int MAX_DIGIT_COUNT = 3;
        /*0x10*/ int major;
        /*0x14*/ int minor;
        /*0x18*/ int patch;

        static /*0x72fdcfc*/ string ExtractSemanticVersionString(string input);
        static /*0x72fdd80*/ NoaDebugger.SemanticVersion Parse(string input);
        static /*0x72fdf10*/ bool op_Equality(NoaDebugger.SemanticVersion one, NoaDebugger.SemanticVersion another);
        static /*0x72fdf44*/ bool op_Inequality(NoaDebugger.SemanticVersion one, NoaDebugger.SemanticVersion another);
        static /*0x72fdf70*/ bool op_LessThan(NoaDebugger.SemanticVersion one, NoaDebugger.SemanticVersion another);
        static /*0x72fdfac*/ bool op_GreaterThan(NoaDebugger.SemanticVersion one, NoaDebugger.SemanticVersion another);
        static /*0x72fdfe8*/ bool op_LessThanOrEqual(NoaDebugger.SemanticVersion one, NoaDebugger.SemanticVersion another);
        static /*0x72fe024*/ bool op_GreaterThanOrEqual(NoaDebugger.SemanticVersion one, NoaDebugger.SemanticVersion another);
        /*0x72fdec8*/ int CompareTo(NoaDebugger.SemanticVersion another);
        /*0x72fe060*/ int GetHashCode();
        /*0x72fe104*/ bool Equals(object another);
    }

    class ArrayParser : NoaDebugger.IKeyValueParser
    {
        /*0x10*/ string _key;
        /*0x18*/ string[] _values;

        /*0x72fe230*/ ArrayParser(string key, string[] values);
        /*0x72fe274*/ string ToJsonString();
    }

    class JsonObjectParser : NoaDebugger.IKeyValueParser
    {
        /*0x10*/ string _key;
        /*0x18*/ string _json;

        /*0x72fe648*/ JsonObjectParser(string key, string json);
        /*0x72fe68c*/ string ToJsonString();
    }

    class KeyObjectParser : NoaDebugger.IKeyValueParser
    {
        /*0x10*/ string _key;
        /*0x18*/ NoaDebugger.IKeyValueParser[] _elements;

        static /*0x3907c14*/ NoaDebugger.KeyObjectParser CreateFromClass<T>(T viewInfo, string name);
        /*0x72fe748*/ KeyObjectParser(string key, NoaDebugger.IKeyValueParser[] elements);
        /*0x72fe78c*/ string ToJsonString();
    }

    class KeyValueArrayParser : NoaDebugger.IKeyValueParser
    {
        /*0x10*/ string _key;
        /*0x18*/ NoaDebugger.KeyValueArrayParser.ObjectParser[] _values;

        /*0x72fe978*/ KeyValueArrayParser(string key, NoaDebugger.KeyValueArrayParser.ObjectParser[] parser);
        /*0x72fe9bc*/ string ToJsonString();

        class ObjectParser
        {
            /*0x10*/ NoaDebugger.IKeyValueParser[] _values;

            /*0x72fecf4*/ ObjectParser(NoaDebugger.IKeyValueParser[] values);
            /*0x72feb40*/ string ToJsonString();
        }
    }

    class KeyValueParser : NoaDebugger.IKeyValueParser
    {
        /*0x10*/ string _key;
        /*0x18*/ string _value;

        /*0x72fed24*/ KeyValueParser(string key, string value);
        /*0x72fed68*/ string ToJsonString();
    }

    interface IKeyValueParser
    {
        /*0x380b9e8*/ string ToJsonString();
    }

    class KeyValueSerializer
    {
        /*0x10*/ string _key;
        /*0x18*/ NoaDebugger.IKeyValueParser[] _parsers;

        static /*0x72ff140*/ string SerializeToJson(NoaDebugger.KeyValueSerializer[] targetDatas);
        static /*0x72fe4e8*/ System.Text.StringBuilder InsertTabs(System.Text.StringBuilder builder, string prefix, string suffix);
        static /*0x72fe460*/ System.Text.StringBuilder AppendAndJoinJson(System.Text.StringBuilder builder, string[] targetStrings);
        static /*0x72ff284*/ NoaDebugger.KeyValueSerializer CreateSubData(string label, NoaDebugger.IKeyValueParser[] addValues);
        static /*0x3907c14*/ NoaDebugger.KeyValueSerializer CreateFromClass<T>(T viewInfo, string name);
        /*0x72fef10*/ KeyValueSerializer(string key, NoaDebugger.IKeyValueParser[] parsers);
        /*0x72fef54*/ string SerializeToJson();
    }

    interface INoaUIElementView
    {
        /*0x380b9e8*/ NoaDebugger.INoaUIElement get_Element();
        /*0x380b9e8*/ UnityEngine.GameObject get_GameObject();
        /*0x380b128*/ bool get_IsDisposed();
    }

    class NoaUIButtonElementView : NoaDebugger.NoaUIElementViewBase<NoaDebugger.NoaUIButtonElement>
    {
        /*0x30*/ UnityEngine.UI.Button _button;
        /*0x38*/ TMPro.TextMeshProUGUI _labelText;

        /*0x72ff530*/ NoaUIButtonElementView();
        /*0x72ff44c*/ void OnInitialize(NoaDebugger.NoaUIButtonElement element);
    }

    class NoaUIElementManager : UnityEngine.EventSystems.UIBehaviour
    {
        /*0x20*/ UnityEngine.RectTransform _applySafeAreaRect;
        /*0x28*/ UnityEngine.RectTransform _unApplySafeAreaRect;
        /*0x30*/ UnityEngine.RectTransform _uiElementRootPosition;
        /*0x38*/ UnityEngine.Transform _upperLeftPosition;
        /*0x40*/ UnityEngine.Transform _upperCenterPosition;
        /*0x48*/ UnityEngine.Transform _upperRightPosition;
        /*0x50*/ UnityEngine.Transform _middleLeftPosition;
        /*0x58*/ UnityEngine.Transform _middleCenterPosition;
        /*0x60*/ UnityEngine.Transform _middleRightPosition;
        /*0x68*/ UnityEngine.Transform _lowerLeftPosition;
        /*0x70*/ UnityEngine.Transform _lowerCenterPosition;
        /*0x78*/ UnityEngine.Transform _lowerRightPosition;
        /*0x80*/ UnityEngine.GameObject _textElementPrefab;
        /*0x88*/ UnityEngine.GameObject _buttonElementPrefab;
        /*0x90*/ System.Collections.Generic.Dictionary<NoaDebugger.AnchorType, bool> _doingAlignmentFlags;
        /*0x98*/ System.Collections.Generic.Dictionary<string, NoaDebugger.INoaUIElementView> _registeredElements;

        /*0x73016c8*/ NoaUIElementManager();
        /*0x72ff578*/ UnityEngine.Transform get_RootTransform();
        /*0x72ff580*/ NoaDebugger.INoaUIElementView[] get_RegisteredElements();
        /*0x72ff658*/ void ResetRootRectSize();
        /*0x72ff74c*/ void OnRectTransformDimensionsChange();
        /*0x72ff750*/ void Update();
        /*0x72ff754*/ void _CleanUpRegisteredElements();
        /*0x72ffb20*/ void RegisterUIElement(NoaDebugger.INoaUIElement element);
        /*0x73004a0*/ void UnregisterUIElement(string key);
        /*0x73007d0*/ void UnregisterAllUIElements();
        /*0x7300a08*/ bool IsUIElementRegistered(string key);
        /*0x7300ab8*/ void SetUIElementVisibility(string key, bool visible);
        /*0x7300c4c*/ bool IsUIElementVisible(string key);
        /*0x7300d74*/ void SetVerticalAlignment(NoaDebugger.AnchorType anchorType);
        /*0x7300dd8*/ void SetHorizontalAlignment(NoaDebugger.AnchorType anchorType);
        /*0x380ba90*/ System.Collections.IEnumerator _SetAlignment<T>(NoaDebugger.AnchorType anchorType);
        /*0x73006e0*/ void _CreateUIElement(NoaDebugger.INoaUIElement element);
        /*0x7300e3c*/ NoaDebugger.INoaUIElementView _CreatePrefabForElementView(NoaDebugger.INoaUIElement element);
        /*0x72ffef4*/ void _InitializeUIElement(NoaDebugger.INoaUIElement element, NoaDebugger.INoaUIElementView elementView);
        /*0x730114c*/ void _SetParentLayoutComponents(NoaDebugger.INoaUIElement element);
        /*0x73010d4*/ UnityEngine.Transform _GetAnchorTransform(NoaDebugger.AnchorType anchorType);
        /*0x7301420*/ void OnDestroy();

        class <_SetAlignment>d__32<T> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ NoaDebugger.NoaUIElementManager <>4__this;
            /*0x0*/ NoaDebugger.AnchorType anchorType;
            /*0x0*/ System.Type <verticalType>5__2;
            /*0x0*/ System.Type <horizontalType>5__3;
            /*0x0*/ UnityEngine.Transform <anchorTransform>5__4;
            /*0x0*/ System.Type <applyType>5__5;
            /*0x0*/ UnityEngine.TextAnchor <childAlignment>5__6;

            /*0x380cffc*/ <_SetAlignment>d__32(int <>1__state);
            /*0x380cb08*/ void System.IDisposable.Dispose();
            /*0x380b128*/ bool MoveNext();
            /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
            /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class NoaUIElementViewBase<T> : UnityEngine.MonoBehaviour, NoaDebugger.INoaUIElementView
    {
        /*0x0*/ T _element;
        /*0x0*/ bool _isDisposed;

        /*0x380cb08*/ NoaUIElementViewBase();
        /*0x380b9e8*/ NoaDebugger.INoaUIElement get_Element();
        /*0x380b9e8*/ UnityEngine.GameObject get_GameObject();
        /*0x380b128*/ bool get_IsDisposed();
        /*0x3907c14*/ void Initialize(T element);
        /*0x380cb08*/ void Update();
        /*0x380cb08*/ void OnDestroy();
        /*0x3907c14*/ void OnInitialize(T element);
        /*0x380cb08*/ void OnUpdate();
        /*0x380cb08*/ void Dispose();
    }

    class NoaUIObjectElementView : NoaDebugger.NoaUIElementViewBase<NoaDebugger.NoaUIObjectElement>
    {
        /*0x30*/ UnityEngine.GameObject _gameObject;

        /*0x7301b28*/ NoaUIObjectElementView();
        /*0x73017a4*/ void OnInitialize(NoaDebugger.NoaUIObjectElement element);
        /*0x73019f4*/ void OnUpdate();
        /*0x7301a94*/ void Dispose();
    }

    class NoaUITextElementView : NoaDebugger.NoaUIElementViewBase<NoaDebugger.NoaUITextElement>
    {
        /*0x30*/ TMPro.TextMeshProUGUI _textComponent;
        /*0x38*/ float _nextUpdateTime;

        /*0x7301cc0*/ NoaUITextElementView();
        /*0x7301b70*/ void OnInitialize(NoaDebugger.NoaUITextElement element);
        /*0x7301c74*/ void OnUpdate();
        /*0x7301b90*/ void _UpdateValue();
    }

    class BlockableScrollRect : UnityEngine.UI.ScrollRect
    {
        /*0x130*/ bool _canMoveScroll;

        /*0x7301d38*/ BlockableScrollRect();
        /*0x7301d08*/ void _Init();
        /*0x7301d14*/ void ResetScrollPosition();
        /*0x7301d24*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
    }

    class ChartLegend : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.ChartLegendElement _elementTemplate;
        /*0x28*/ System.Collections.Generic.List<NoaDebugger.ChartLegendElement> _elements;

        /*0x7302118*/ ChartLegend();
        /*0x7301d48*/ void Awake();
        /*0x7301d74*/ int AddElement(string text, UnityEngine.Color color);
        /*0x7301f70*/ void UpdateText(int index, string text);
        /*0x7301ff4*/ void UpdateColor(int index, UnityEngine.Color color);
        /*0x7302098*/ void ToggleShow(int index, bool shows);
    }

    class ChartLegendElement : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.NoaDebuggerText _label;
        /*0x28*/ UnityEngine.UI.Image _icon;

        /*0x7302214*/ ChartLegendElement();
        /*0x73021a0*/ void Awake();
        /*0x73021a4*/ string get_Text();
        /*0x7301f28*/ void set_Text(string value);
        /*0x73021c8*/ UnityEngine.Color get_Color();
        /*0x7301f4c*/ void set_Color(UnityEngine.Color value);
        /*0x73021ec*/ void OnDestroy();
    }

    class ContextPanelView : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<char, float> _charWidthCache;
        /*0x20*/ TMPro.TextMeshProUGUI _header;
        /*0x28*/ TMPro.TextMeshProUGUI _context;
        /*0x30*/ UnityEngine.Color _keyContextColor;
        /*0x40*/ UnityEngine.Color _valueContextColor;
        /*0x50*/ float _valuePosition;
        /*0x54*/ float _keyValueSpace;
        /*0x58*/ bool _keyContextWrap;
        /*0x60*/ UnityEngine.UI.LayoutElement _lineLayoutElement;
        /*0x68*/ TMPro.TextMeshProUGUI _wrapCheckText;

        static /*0x7302fc8*/ ContextPanelView();
        /*0x7302fb4*/ ContextPanelView();
        /*0x730221c*/ void set_KeyContextColor(UnityEngine.Color value);
        /*0x7302228*/ void set_ValueContextColor(UnityEngine.Color value);
        /*0x7302234*/ void Start();
        /*0x730226c*/ void SetText(string header, System.Collections.Generic.Dictionary<string, string> context, string prefix, string suffix, string missingValue);
        /*0x73022f4*/ string _ConvertContext(System.Collections.Generic.Dictionary<string, string> contextList, string prefix, string suffix, string missingValue);
        /*0x7302d9c*/ string _GetWrapText(string text, float width);
        /*0x7302a88*/ string _GetSubstringTextByWidth(string text, float targetWidth, ref int endIndex);
        /*0x7302d38*/ string _ConvertLabel(string label, string missingValue);
        /*0x7302ef0*/ bool _IsAcquireLabel(string label);
        /*0x7302f60*/ void SetMinWidthForLine(float width);
        /*0x7302f84*/ void SetActiveLine(bool active);
    }

    class DisableButtonBase : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.Events.UnityEvent _onClick;
        /*0x28*/ UnityEngine.UI.Button _component;

        /*0x73032f0*/ DisableButtonBase();
        /*0x7303060*/ bool get_Interactable();
        /*0x7303114*/ void set_Interactable(bool value);
        /*0x73031e0*/ void Awake();
        /*0x73032b4*/ void _OnClick();
        /*0x380cb08*/ void _Refresh();
        /*0x73032c8*/ void OnDestroy();
    }

    class DisableColorButton : NoaDebugger.DisableButtonBase
    {
        /*0x30*/ UnityEngine.Color _enable;
        /*0x40*/ UnityEngine.Color _disable;
        /*0x50*/ UnityEngine.UI.Graphic[] _targetGraphics;

        /*0x73033d8*/ DisableColorButton();
        /*0x73032f8*/ void Awake();
        /*0x7303310*/ void _Refresh();
    }

    class DisableObjectButton : NoaDebugger.DisableButtonBase
    {
        /*0x30*/ UnityEngine.GameObject _enable;
        /*0x38*/ UnityEngine.GameObject _disable;

        /*0x73034a8*/ DisableObjectButton();
        /*0x730344c*/ void Awake();
        /*0x7303450*/ void _Refresh();
    }

    class DraggableNumericInputSlider : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler
    {
        static /*0x0*/ float DragDirectionCheckDistance;
        /*0x20*/ NoaDebugger.DraggableNumericInputSlider.DragState _dragState;
        /*0x24*/ UnityEngine.Vector2 _beginCursorPos;
        /*0x30*/ UnityEngine.EventSystems.PointerEventData _pointerEventData;
        /*0x38*/ NoaDebugger.BlockableScrollRect _parentScroll;
        /*0x40*/ NoaDebugger.NoaDebuggerScrollableInputComponent _numericInput;
        /*0x48*/ NoaDebugger.DraggableNumericInputSlider.DragSliderEvent OnSliding;
        /*0x50*/ UnityEngine.Events.UnityEvent OnBeginSlider;
        /*0x58*/ UnityEngine.Events.UnityEvent OnEndSlider;

        static /*0x7303b04*/ DraggableNumericInputSlider();
        /*0x73039f0*/ DraggableNumericInputSlider();
        /*0x73034b0*/ void Initialize(NoaDebugger.BlockableScrollRect parentScroll, NoaDebugger.NoaDebuggerScrollableInputComponent numericInput);
        /*0x7303730*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x730376c*/ void OnButtonUp();
        /*0x7303800*/ void Update();
        /*0x7303958*/ void _OnInputModeChanged(bool isInputMode);
        /*0x73038d0*/ void _CheckDragDirection(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7303984*/ bool _IsNeedCheckDirection(float distance);

        enum DragState
        {
            None = 0,
            PointerDown = 1,
            HorizontalDrag = 2,
            VerticalDrag = 3,
        }

        class DragSliderEvent : UnityEngine.Events.UnityEvent<float>
        {
            /*0x7303abc*/ DragSliderEvent();
        }
    }

    class GaugeChart : UnityEngine.EventSystems.UIBehaviour
    {
        /*0x20*/ UnityEngine.RectTransform _gaugeMeter;
        /*0x28*/ UnityEngine.RectTransform _gaugeFrame;
        /*0x30*/ float _maxValue;
        /*0x34*/ float _value;

        /*0x7303cf8*/ GaugeChart();
        /*0x7303b50*/ float get_MaxValue();
        /*0x7303b58*/ void set_MaxValue(float value);
        /*0x7303c4c*/ float get_Value();
        /*0x7303c54*/ void set_Value(float value);
        /*0x7303cf0*/ void Awake();
        /*0x7303cf4*/ void OnRectTransformDimensionsChange();
        /*0x7303bf4*/ void _UpdateGaugeTransform();
    }

    class LongPressButton : UnityEngine.UI.Button
    {
        /*0x108*/ NoaDebugger.LongPressButton.DisableTarget[] _disableTargets;
        /*0x110*/ NoaDebugger.LongPressButton.PressState _pressState;
        /*0x114*/ float _lastCheckedTime;
        /*0x118*/ float _currentInterval;
        /*0x11c*/ int _pressingActionCount;
        /*0x120*/ bool _isNeedSpeedUp;
        /*0x124*/ float _pressTimeSeconds;
        /*0x128*/ float _pressActionFirstInterval;
        /*0x12c*/ float _pressActionIntervalChangeCount;
        /*0x130*/ float _pressActionSecondInterval;
        /*0x138*/ UnityEngine.Events.UnityAction _onEnabled;
        /*0x140*/ UnityEngine.UI.Button.ButtonClickedEvent _onPointerDown;
        /*0x148*/ UnityEngine.UI.Button.ButtonClickedEvent _onLongPress;
        /*0x150*/ NoaDebugger.LongPressButton.PointerExitEvent _onPointerExit;
        /*0x158*/ UnityEngine.UI.Button.ButtonClickedEvent _onPointerUp;
        /*0x160*/ UnityEngine.Events.UnityAction _onClick;

        /*0x73042ac*/ LongPressButton();
        /*0x7303d00*/ void Awake();
        /*0x7303ea0*/ void OnEnable();
        /*0x7303ed4*/ void _OnClick();
        /*0x7303ef0*/ void _OnReset();
        /*0x7303ef4*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7303f44*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7303fb4*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7303e74*/ void SetActionIntervalSettings(NoaDebugger.LongPressButtonActionIntervalSettings setting);
        /*0x7304058*/ void ResetButtonState();
        /*0x730406c*/ void Update();
        /*0x7304160*/ bool _IsOverThresholdTime(float thresholdTime);
        /*0x7304194*/ void _InvokeLongPressAction();
        /*0x73041c0*/ void SetInteractable(bool isInteractable);
        /*0x7304298*/ bool IsLongPress();

        class DisableTarget
        {
            /*0x10*/ UnityEngine.UI.Image _image;
            /*0x18*/ UnityEngine.Color _normalColor;
            /*0x28*/ UnityEngine.Color _disabledColor;

            /*0x73042b4*/ DisableTarget();
            /*0x7304238*/ void SetColor(bool isEnable);
        }

        enum PressState
        {
            None = 0,
            PointerDown = 1,
            Pressing = 2,
            PressingLoop = 3,
            PressingSpeedUp = 4,
        }

        class PointerExitEvent : UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>
        {
            /*0x73042bc*/ PointerExitEvent();
        }

        class ButtonResetEvent : UnityEngine.Events.UnityEvent
        {
            /*0x7304304*/ ButtonResetEvent();
        }
    }

    class LongPressButtonActionIntervalSettings
    {
        /*0x10*/ bool _isNeedSpeedUp;
        /*0x14*/ float _firstInterval;
        /*0x18*/ float _secondInterval;

        /*0x7303e04*/ LongPressButtonActionIntervalSettings();
    }

    class LongPressToggleColorButton : NoaDebugger.LongPressButton
    {
        /*0x168*/ NoaDebugger.LongPressButton _component;
        /*0x170*/ UnityEngine.Color _off;
        /*0x180*/ UnityEngine.Color _on;
        /*0x190*/ UnityEngine.Color _disable;
        /*0x1a0*/ bool _isUseDisable;
        /*0x1a8*/ UnityEngine.UI.Graphic[] _targetGraphics;
        /*0x1b0*/ bool _isOn;
        /*0x1b1*/ bool _clickEventEnabled;

        /*0x73044dc*/ LongPressToggleColorButton();
        /*0x730430c*/ void Awake();
        /*0x7304418*/ void _OnReset();
        /*0x7304448*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7304454*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7304488*/ void _OnClick();
        /*0x73044ac*/ void _InvokeLongPressAction();
        /*0x7304434*/ void _Toggle();
        /*0x7304330*/ void _Refresh();

        class ToggleEvent : UnityEngine.Events.UnityEvent<bool>
        {
            /*0x7304564*/ ToggleEvent();
        }
    }

    class LongTapButton : UnityEngine.UI.Button
    {
        /*0x108*/ bool _isPressing;
        /*0x10c*/ float _pressedTime;
        /*0x110*/ bool _isLongTap;
        /*0x118*/ NoaDebugger.LongTapButton.PointerExitEvent _onPointerExit;
        /*0x120*/ UnityEngine.UI.Button.ButtonClickedEvent _onPointerDown;
        /*0x128*/ UnityEngine.UI.Button.ButtonClickedEvent _onLongTap;

        /*0x73047a4*/ LongTapButton();
        /*0x73045ac*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x73045f4*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7304664*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x73046f8*/ void Update();

        class PointerExitEvent : UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>
        {
            /*0x73047ac*/ PointerExitEvent();
        }
    }

    class LongTapToggleColorButton : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.LongTapButton _component;
        /*0x28*/ UnityEngine.Color _off;
        /*0x38*/ UnityEngine.Color _on;
        /*0x48*/ UnityEngine.Color _disable;
        /*0x58*/ bool _isUseDisable;
        /*0x60*/ UnityEngine.UI.Graphic[] _targetGraphics;
        /*0x68*/ bool <IsOn>k__BackingField;
        /*0x70*/ UnityEngine.UI.Button.ButtonClickedEvent OnPointerDown;
        /*0x78*/ UnityEngine.UI.Button.ButtonClickedEvent OnClick;
        /*0x80*/ NoaDebugger.LongTapToggleColorButton.ToggleEvent OnToggle;
        /*0x88*/ bool _clickEventEnabled;

        /*0x7304d08*/ LongTapToggleColorButton();
        /*0x73047f4*/ void set_IsOn(bool value);
        /*0x7304800*/ bool get_IsOn();
        /*0x7304808*/ NoaDebugger.LongTapButton get_LongTapButton();
        /*0x73048b0*/ bool get_Interactable();
        /*0x73048cc*/ void set_Interactable(bool value);
        /*0x73049f4*/ void Awake();
        /*0x7304bc4*/ void Init(bool isOn);
        /*0x7304bd0*/ void Clear();
        /*0x7304c2c*/ void _OnPointerDown();
        /*0x7304c54*/ void _OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7304c80*/ void _OnClick();
        /*0x7304c9c*/ void _Toggle();
        /*0x7304904*/ void _Refresh();

        class ToggleEvent : UnityEngine.Events.UnityEvent<bool>
        {
            /*0x7304dec*/ ToggleEvent();
        }
    }

    class NoaDebuggerInputField : TMPro.TMP_InputField
    {
        /*0x2f8*/ TMPro.TMP_InputField.OnValidateInput _validate;
        /*0x300*/ bool _activateOnPointerDown;
        /*0x308*/ UnityEngine.GameObject _dragTarget;

        /*0x7305574*/ NoaDebuggerInputField();
        /*0x7304e34*/ void SetActivateOnPointerDown(bool activate);
        /*0x7304e40*/ void SetDragTarget(UnityEngine.GameObject dragTarget);
        /*0x7304e50*/ void Awake();
        /*0x73050c4*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x73050d8*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x73051a4*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x73052b8*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x73053cc*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x730502c*/ void UseCustomValidation(TMPro.TMP_InputField.OnValidateInput validate);
        /*0x73054e0*/ void UseContentType(TMPro.TMP_InputField.ContentType newContentType, TMPro.TMP_InputField.InputType newInputType, UnityEngine.TouchScreenKeyboardType newKeyboardType, TMPro.TMP_InputField.CharacterValidation newCharacterValidation);
        /*0x7305554*/ char _OnValidateInput(string text, int charIndex, char addedChar);

        class <>c
        {
            static /*0x0*/ NoaDebugger.NoaDebuggerInputField.<> <>9;
            static /*0x8*/ UnityEngine.Events.UnityAction<string> <>9__5_0;
            static /*0x10*/ UnityEngine.Events.UnityAction<string> <>9__5_1;

            static /*0x73055d4*/ <>c();
            /*0x730563c*/ <>c();
            /*0x7305644*/ void <Awake>b__5_0(string _);
            /*0x7305698*/ void <Awake>b__5_1(string _);
        }
    }

    class NoaDebuggerScrollableInputComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.NoaDebuggerInputField _targetInput;
        /*0x28*/ NoaDebugger.PointerEventComponent _pointerEventComponent;
        /*0x30*/ bool _isInputMode;
        /*0x31*/ bool _isInputModeBeforeOnEndEdit;
        /*0x34*/ int _onEndEditFrame;
        /*0x38*/ int _onPointerDownFrame;
        /*0x3c*/ bool _isMobile;
        /*0x40*/ UnityEngine.Events.UnityAction<bool> OnInputModeChanged;
        /*0x48*/ TMPro.TMP_InputField.OnChangeEvent _onValueChanged;
        /*0x50*/ TMPro.TMP_InputField.SelectionEvent _onSelect;
        /*0x58*/ TMPro.TMP_InputField.SubmitEvent _onEndEdit;

        /*0x7305c24*/ NoaDebuggerScrollableInputComponent();
        /*0x73056ec*/ bool get_IsInputMode();
        /*0x73056f4*/ string get_Text();
        /*0x7305710*/ void set_Text(string value);
        /*0x730572c*/ TMPro.TMP_Text get_TextComponent();
        /*0x7305748*/ void set_CharacterLimit(int value);
        /*0x7303680*/ void add_OnInputModeChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x73035d0*/ void remove_OnInputModeChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x7305764*/ void Awake();
        /*0x7305980*/ void UpdateValidation(TMPro.TMP_InputField.OnValidateInput validate);
        /*0x7305998*/ void UpdateContentType(TMPro.TMP_InputField.ContentType contentType, TMPro.TMP_InputField.InputType inputType, UnityEngine.TouchScreenKeyboardType keyboardType, TMPro.TMP_InputField.CharacterValidation characterValidation);
        /*0x73037dc*/ void Select();
        /*0x73059b0*/ void _OnValueChanged(string text);
        /*0x7305a10*/ void _OnSelect(string text);
        /*0x7305ab8*/ void _OnEndEdit(string text);
        /*0x7305a94*/ void _ChangeInputMode(bool isInputMode);
        /*0x7305bb8*/ void _OnDownInputAreaForMobile(UnityEngine.EventSystems.PointerEventData pointerEventData);
        /*0x7305bd4*/ void _OnClickInputAreaForMobile(UnityEngine.EventSystems.PointerEventData pointerEventData);
    }

    class NoaInputFieldEventConfigurator : UnityEngine.MonoBehaviour
    {
        /*0x20*/ bool _activateOnPointerDown;
        /*0x28*/ UnityEngine.GameObject _dragTarget;
        /*0x30*/ NoaDebugger.NoaDebuggerInputField _inputField;

        /*0x7305c98*/ NoaInputFieldEventConfigurator();
        /*0x7305c2c*/ void Start();
    }

    class ScrollRectHandler : UnityEngine.MonoBehaviour
    {
        /*0x7305d78*/ ScrollRectHandler();
        /*0x7305ca8*/ void Awake();
    }

    class StackedAreaChart : UnityEngine.UI.MaskableGraphic
    {
        static int MINIMUM_HISTORY_CAPACITY = 2;
        static int MINIMUM_STACK_COUNT = 1;
        static int VERTEX_COUNT_PER_HISTORY = 2;
        static int INDEX_COUNT_BETWEEN_HISTORIES = 6;
        /*0xd8*/ NoaDebugger.StackedAreaChart.StackDisplayAttributes[] _stackDisplayAttributes;
        /*0xe0*/ NoaDebugger.ChartLegend _legend;
        /*0xe8*/ int _rulerCount;
        /*0xf0*/ NoaDebugger.StackedAreaChartRuler _rulerTemplate;
        /*0xf8*/ UnityEngine.Transform _rulerRoot;
        /*0x100*/ System.Collections.Generic.List<UnityEngine.UIVertex> _vertices;
        /*0x108*/ System.Collections.Generic.List<int> _indices;
        /*0x110*/ NoaDebugger.RingBuffer<System.Single[]> _valueHistories;
        /*0x118*/ NoaDebugger.StackedAreaChartRuler[] _rulers;
        /*0x120*/ float[] _rulerPositions;
        /*0x128*/ string[] _rulerLabels;
        /*0x130*/ System.Action<float, System.Single[], System.String[]> _onUpdateRulers;

        /*0x7307b58*/ StackedAreaChart();
        /*0x7305d80*/ void SetUpdateRulersCallback(System.Action<float, System.Single[], System.String[]> callback);
        /*0x7305d90*/ void SetValueHistoryBuffer(NoaDebugger.RingBuffer<System.Single[]> buffer);
        /*0x7306990*/ void ToggleStacksShown(bool[] shows);
        /*0x7306a58*/ void SetStackDisplayAttributesText(int index, string text);
        /*0x7306ab8*/ void SetStackDisplayAttributesColor(int index, UnityEngine.Color newColor);
        /*0x7306af8*/ void SetStackDisplayAttributesShows(int index, bool shows);
        /*0x7306b3c*/ void Awake();
        /*0x7306dac*/ bool get_CanPopulateMesh();
        /*0x7306a3c*/ int get_StackCount();
        /*0x7305f34*/ void InitializeVertices();
        /*0x7306ea0*/ void Update();
        /*0x7307018*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
        /*0x7307128*/ void UpdateVertices();
        /*0x7307078*/ void HideRulers();
        /*0x7306e34*/ int GetFirstVertexOf(int history, int stack);
        /*0x7307ac0*/ float GetHorizontalPositionOf(int history);

        struct StackDisplayAttributes
        {
            /*0x10*/ string _text;
            /*0x18*/ UnityEngine.Color _color;
            /*0x28*/ bool _shows;
        }
    }

    class StackedAreaChartRuler : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.NoaDebuggerText _label;
        /*0x28*/ UnityEngine.RectTransform _rectTransform;

        /*0x7307bf0*/ StackedAreaChartRuler();
        /*0x7307b68*/ void Awake();
        /*0x7307bc0*/ UnityEngine.RectTransform get_RectTransform();
        /*0x7306fd0*/ string get_Text();
        /*0x7306ff4*/ void set_Text(string value);
        /*0x7307bc8*/ void OnDestroy();
    }

    class ToggleButtonBase : UnityEngine.MonoBehaviour
    {
        /*0x20*/ bool <IsOn>k__BackingField;
        /*0x28*/ NoaDebugger.ToggleButtonBase.ToggleClickEvent _onClick;
        /*0x30*/ UnityEngine.UI.Button _component;
        /*0x38*/ NoaDebugger.ToggleButtonGroup _group;

        /*0x73083b4*/ ToggleButtonBase();
        /*0x7307bf8*/ void set_IsOn(bool value);
        /*0x7307c04*/ bool get_IsOn();
        /*0x7307c0c*/ bool get_Interactable();
        /*0x7307cc0*/ void set_Interactable(bool value);
        /*0x7307d8c*/ void Awake();
        /*0x7307e60*/ void OnEnable();
        /*0x7307f90*/ void OnDisable();
        /*0x730806c*/ void Init(bool isOn);
        /*0x7308080*/ void Clear();
        /*0x73080e4*/ void _Toggle();
        /*0x380cb08*/ void _Refresh();
        /*0x730837c*/ void OnDestroy();

        class ToggleClickEvent : UnityEngine.Events.UnityEvent<bool>
        {
            /*0x73083bc*/ ToggleClickEvent();
        }
    }

    class ToggleButtonGroup : UnityEngine.MonoBehaviour
    {
        /*0x20*/ System.Collections.Generic.List<NoaDebugger.ToggleButtonBase> _toggles;

        /*0x7308404*/ ToggleButtonGroup();
        /*0x7307ee4*/ void Add(NoaDebugger.ToggleButtonBase toggle);
        /*0x7308014*/ void Remove(NoaDebugger.ToggleButtonBase toggle);
        /*0x73081ec*/ void Select(NoaDebugger.ToggleButtonBase toggle);
    }

    class ToggleColorButton : NoaDebugger.ToggleButtonBase
    {
        /*0x40*/ UnityEngine.Color _off;
        /*0x50*/ UnityEngine.Color _on;
        /*0x60*/ UnityEngine.Color _disable;
        /*0x70*/ bool _isUseDisable;
        /*0x78*/ UnityEngine.UI.Graphic[] _targetGraphics;

        /*0x7308594*/ ToggleColorButton();
        /*0x730848c*/ void Awake();
        /*0x73084a4*/ void _Refresh();
    }

    class ToggleObjectButton : NoaDebugger.ToggleButtonBase
    {
        /*0x40*/ UnityEngine.GameObject _off;
        /*0x48*/ UnityEngine.GameObject _on;
        /*0x50*/ UnityEngine.GameObject _disable;

        /*0x7308744*/ ToggleObjectButton();
        /*0x7308614*/ void Awake();
        /*0x7308618*/ void _Refresh();
    }

    class UIReverseComponents
    {
        /*0x10*/ UnityEngine.UI.HorizontalOrVerticalLayoutGroup[] _reverseTargetLayouts;
        /*0x18*/ UnityEngine.GameObject[] _normalArrangementObjects;
        /*0x20*/ UnityEngine.GameObject[] _reverseArrangementObjects;

        /*0x7308858*/ UIReverseComponents();
        /*0x730874c*/ void Alignment(bool isReverse);
    }

    class DebugCommandDetailsAreaView : UnityEngine.EventSystems.UIBehaviour
    {
        /*0x20*/ UnityEngine.GameObject _groupNameRoot;
        /*0x28*/ TMPro.TextMeshProUGUI _groupName;
        /*0x30*/ UnityEngine.UI.ScrollRect _scroll;
        /*0x38*/ NoaDebugger.ContextPanelView _panel;
        /*0x40*/ UnityEngine.GameObject _unselectedLabel;
        /*0x48*/ UnityEngine.RectTransform _scrollRectTransform;
        /*0x50*/ UnityEngine.UI.VerticalLayoutGroup _contentLayout;
        /*0x58*/ UnityEngine.RectTransform _verticalScrollbarRect;
        /*0x60*/ System.Collections.Generic.List<NoaDebugger.ContextPanelView> _instantiatedPanels;
        /*0x68*/ bool _isInit;

        /*0x7309104*/ DebugCommandDetailsAreaView();
        /*0x7308860*/ void _OnValidateUI();
        /*0x7308864*/ void Init();
        /*0x730893c*/ void OnRectTransformDimensionsChange();
        /*0x7308b5c*/ void Show(NoaDebugger.DebugCommand.DebugCommandViewLinker linker);
        /*0x7308abc*/ float _GetLineMinWidth();
        /*0x7308f88*/ void Hide();
    }

    class DebugCommandPanel : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.DebugCommand.ICommand _command;
        /*0x28*/ UnityEngine.GameObject _actions;
        /*0x30*/ UnityEngine.UI.LayoutGroup _nameLayout;
        /*0x38*/ TMPro.TextMeshProUGUI _displayName;
        /*0x40*/ UnityEngine.UI.Button _button;
        /*0x48*/ NoaDebugger.ToggleButtonBase _toggleButton;
        /*0x50*/ NoaDebugger.NoaDebuggerScrollableInputComponent _inputField;
        /*0x58*/ TMPro.TMP_Dropdown _dropdown;
        /*0x60*/ NoaDebugger.DraggableNumericInputSlider _swipe;
        /*0x68*/ NoaDebugger.NoaDebuggerScrollableInputComponent _inputSwipeInput;
        /*0x70*/ NoaDebugger.LongPressButton _leftArrowButton;
        /*0x78*/ NoaDebugger.LongPressButton _rightArrowButton;
        /*0x80*/ NoaDebugger.NoaDebuggerText _valueText;
        /*0x88*/ UnityEngine.GameObject _grayOut;
        /*0x90*/ NoaDebugger.ToggleButtonBase _detailToggleButton;
        /*0x98*/ UnityEngine.UI.Image _background;
        /*0xa0*/ NoaDebugger.DebugCommandPanel.BackgroundColors _backgroundColors;
        /*0xc0*/ UnityEngine.GameObject _toggle;
        /*0xc8*/ UnityEngine.GameObject _inputRoot;
        /*0xd0*/ UnityEngine.GameObject _inputSwipeRoot;
        /*0xd8*/ UnityEngine.GameObject _valueRoot;
        /*0xe0*/ NoaDebugger.DebugCommand.ICommandPanel _commandPanel;
        /*0xe8*/ UnityEngine.Events.UnityAction<NoaDebugger.DebugCommand.ICommand, bool> _onClickDetail;
        /*0xf0*/ NoaDebugger.DebugCommand.CommandScroll <ParentScroll>k__BackingField;

        static /*0x7309604*/ NoaDebugger.DebugCommand.ICommandPanel _CreateCommandPanel(NoaDebugger.DebugCommand.ICommand type, NoaDebugger.DebugCommandPanel panel, float maxContentWidth);
        /*0x7309d18*/ DebugCommandPanel();
        /*0x730918c*/ NoaDebugger.DebugCommand.CommandScroll get_ParentScroll();
        /*0x7309194*/ void set_ParentScroll(NoaDebugger.DebugCommand.CommandScroll value);
        /*0x730919c*/ void Awake();
        /*0x7309260*/ void Init(NoaDebugger.DebugCommand.ICommand command, float maxContentWidth, NoaDebugger.DebugCommand.DetailToggleInfo detailToggleInfo, NoaDebugger.DebugCommand.CommandScroll scrollRect);
        /*0x730941c*/ void _ResetActionActive();
        /*0x7309580*/ void _SetInteractable(bool interactable);
        /*0x7309760*/ void _SetDetailInfo(NoaDebugger.DebugCommand.ICommand command, NoaDebugger.DebugCommand.DetailToggleInfo detailToggleInfo);
        /*0x73098c4*/ void OnUpdateWidth(float maxContentWidth);
        /*0x7309974*/ void Refresh();
        /*0x7309a18*/ void UpdateData(NoaDebugger.DebugCommand.ICommand command, NoaDebugger.DebugCommand.DetailToggleInfo detailToggleInfo);
        /*0x7309b44*/ void _OnClickDetailToggle(bool isOn);
        /*0x7309bc0*/ void OnDestroy();

        struct BackgroundColors
        {
            /*0x10*/ UnityEngine.Color interactable;
            /*0x20*/ UnityEngine.Color nonInteractable;
        }

        class CommandPanelVisitor : NoaDebugger.DebugCommand.ICommandVisitor
        {
            /*0x10*/ NoaDebugger.DebugCommandPanel _panel;
            /*0x18*/ float _maxContentWidth;
            /*0x20*/ NoaDebugger.DebugCommand.ICommandPanel <Result>k__BackingField;

            /*0x7309b6c*/ CommandPanelVisitor(NoaDebugger.DebugCommandPanel panel, float maxContentWidth);
            /*0x7309d20*/ NoaDebugger.DebugCommand.ICommandPanel get_Result();
            /*0x7309d28*/ void set_Result(NoaDebugger.DebugCommand.ICommandPanel value);
            /*0x7309bb0*/ bool get_IsSuccess();
            /*0x7309d30*/ void Visit(NoaDebugger.DebugCommand.GetOnlyPropertyCommand command);
            /*0x7309da8*/ void Visit(NoaDebugger.DebugCommand.StringPropertyCommand command);
            /*0x7309e20*/ void Visit(NoaDebugger.DebugCommand.ShortPropertyCommand command);
            /*0x7309e88*/ void Visit(NoaDebugger.DebugCommand.UShortPropertyCommand command);
            /*0x7309ef0*/ void Visit(NoaDebugger.DebugCommand.IntPropertyCommand command);
            /*0x7309f58*/ void Visit(NoaDebugger.DebugCommand.UIntPropertyCommand command);
            /*0x7309fc0*/ void Visit(NoaDebugger.DebugCommand.BytePropertyCommand command);
            /*0x730a028*/ void Visit(NoaDebugger.DebugCommand.SBytePropertyCommand command);
            /*0x730a090*/ void Visit(NoaDebugger.DebugCommand.LongPropertyCommand command);
            /*0x730a0f8*/ void Visit(NoaDebugger.DebugCommand.ULongPropertyCommand command);
            /*0x730a160*/ void Visit(NoaDebugger.DebugCommand.CharPropertyCommand command);
            /*0x730a1c8*/ void Visit(NoaDebugger.DebugCommand.FloatPropertyCommand command);
            /*0x730a230*/ void Visit(NoaDebugger.DebugCommand.DoublePropertyCommand command);
            /*0x730a298*/ void Visit(NoaDebugger.DebugCommand.DecimalPropertyCommand command);
            /*0x730a310*/ void Visit(NoaDebugger.DebugCommand.BoolPropertyCommand command);
            /*0x730a378*/ void Visit(NoaDebugger.DebugCommand.EnumPropertyCommand command);
            /*0x730a3f0*/ void Visit(NoaDebugger.DebugCommand.MethodCommand command);
            /*0x730a458*/ void Visit(NoaDebugger.DebugCommand.CoroutineCommand command);
            /*0x730a4c0*/ void Visit(NoaDebugger.DebugCommand.HandleMethodCommand command);
        }
    }

    class DebugCommandScrollAreaView : NoaDebugger.ViewBase<NoaDebugger.DebugCommand.DebugCommandViewLinker>
    {
        /*0x20*/ NoaDebugger.DebugCommand.CommandScroll _scroll;
        /*0x28*/ UnityEngine.GameObject _noCategoriesLabel;
        /*0x30*/ UnityEngine.GameObject _noCommandsLabel;

        /*0x730a874*/ DebugCommandScrollAreaView();
        /*0x730a528*/ void _OnValidateUI();
        /*0x730a52c*/ void _Init();
        /*0x730a530*/ void _OnShow(NoaDebugger.DebugCommand.DebugCommandViewLinker linker);
        /*0x730a660*/ void _UpdateScroll(NoaDebugger.DebugCommand.DebugCommandViewLinker linker);
        /*0x730a6c8*/ System.Collections.IEnumerator _WaitSetScrollPosition();
        /*0x730a75c*/ void ResetScrollPosition();
        /*0x730a780*/ void RefreshCommandPanels();
        /*0x730a79c*/ void AlignmentUI(bool isReverse);
        /*0x730a818*/ void OnDestroy();

        class <_WaitSetScrollPosition>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.DebugCommandScrollAreaView <>4__this;

            /*0x730a734*/ <_WaitSetScrollPosition>d__7(int <>1__state);
            /*0x730a8bc*/ void System.IDisposable.Dispose();
            /*0x730a8c0*/ bool MoveNext();
            /*0x730a920*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x730a928*/ void System.Collections.IEnumerator.Reset();
            /*0x730a960*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class DialogBase<T> : NoaDebugger.ViewBase<T>
    {
        /*0x0*/ UnityEngine.GameObject _targetView;
        /*0x0*/ TMPro.TextMeshProUGUI _caption;
        /*0x0*/ UnityEngine.UI.Button _closeButton;
        /*0x0*/ UnityEngine.UI.Button _alternativeCloseButton;

        /*0x380cb08*/ DialogBase();
        /*0x380cb08*/ void _Init();
        /*0x3907c14*/ void _OnShow(T linker);
        /*0x380cb08*/ void _OnHide();
    }

    class DialogBaseViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ string _caption;

        /*0x730a968*/ DialogBaseViewLinker();
    }

    class DownloadDialog : NoaDebugger.DialogBase<NoaDebugger.DownloadDialog.DownloadDialogLinker>
    {
        static string CAPTION = "Download";
        static int MAX_LABEL_CHAR_NUM = 20;
        static /*0x0*/ char[] InvalidCharacters;
        /*0x40*/ NoaDebugger.NoaDebuggerInputField _labelInput;
        /*0x48*/ UnityEngine.UI.Button _downloadButton;

        static /*0x730ac1c*/ DownloadDialog();
        /*0x730abd4*/ DownloadDialog();
        /*0x730a970*/ void _OnShow(NoaDebugger.DownloadDialog.DownloadDialogLinker linker);
        /*0x730aad4*/ void _OnHide();
        /*0x730ab50*/ char _LabelValidate(string text, int charIndex, char addedChar);

        class DownloadDialogLinker : NoaDebugger.DialogBaseViewLinker
        {
            /*0x18*/ string _initialLabel;
            /*0x20*/ UnityEngine.Events.UnityAction _onDownload;
            /*0x28*/ UnityEngine.Events.UnityAction<string> _onChangeLabel;

            /*0x730acbc*/ DownloadDialogLinker();
        }
    }

    class GameObjectDetailPanel : NoaDebugger.HierarchyPanelBase<NoaDebugger.GameObjectDetailPanelData>
    {
        static string NAME_VALUE_FORMAT = "{0} :    {1}";
        static string NAME_ONLY_FORMAT = "{0}";
        /*0x68*/ TMPro.TextMeshProUGUI _keyValueLabel;
        /*0x70*/ UnityEngine.UI.Button _headerToggle;

        /*0x730ae18*/ GameObjectDetailPanel();
        /*0x730acc4*/ void _Draw(NoaDebugger.GameObjectDetailPanelData panelData);
        /*0x730adf4*/ float _GetLabelLength();
    }

    class GameObjectDetailPanelData : NoaDebugger.HierarchyPanelDataBase
    {
        /*0x28*/ string _itemName;
        /*0x30*/ string _itemValue;

        /*0x730ae60*/ GameObjectDetailPanelData(NoaDebugger.GameObjectDetailEntry entry, int depth, System.Action onToggle);
    }

    class GameObjectDetailView : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.ObjectPoolScroll _componentScroll;
        /*0x28*/ TMPro.TextMeshProUGUI _componentCountLabel;
        /*0x30*/ NoaDebugger.ToggleButtonBase _detailLockToggle;
        /*0x38*/ UnityEngine.GameObject _noSelectedLabel;
        /*0x40*/ NoaDebugger.ToggleButtonBase _activeSwitchToggle;
        /*0x48*/ NoaDebugger.HierarchyPanelScrollHelper<NoaDebugger.GameObjectDetailPanel, NoaDebugger.GameObjectDetailPanelData> _scrollHelper;
        /*0x50*/ System.Action<bool> OnDetailLock;
        /*0x58*/ System.Action<bool> OnSwitchSelectedObjectActive;

        /*0x730b5e0*/ GameObjectDetailView();
        /*0x730af1c*/ void add_OnDetailLock(System.Action<bool> value);
        /*0x730afcc*/ void remove_OnDetailLock(System.Action<bool> value);
        /*0x730b07c*/ void add_OnSwitchSelectedObjectActive(System.Action<bool> value);
        /*0x730b12c*/ void remove_OnSwitchSelectedObjectActive(System.Action<bool> value);
        /*0x730b1dc*/ void _OnValidateUI();
        /*0x730b27c*/ void Show(NoaDebugger.GameObjectDetail detail);
        /*0x730b5a0*/ void _OnDetailLock(bool isLock);
        /*0x730b5c0*/ void _OnSwitchSelectedObjectActive(bool isActive);
    }

    class HierarchyFloatingWindowView : NoaDebugger.FloatingWindowViewBase<NoaDebugger.HierarchyViewLinker>
    {
        /*0x80*/ TMPro.TextMeshProUGUI _sceneCountLabel;
        /*0x88*/ NoaDebugger.HierarchyTreeView _hierarchyTreeView;
        /*0x90*/ TMPro.TextMeshProUGUI _objectCountLabel;
        /*0x98*/ UnityEngine.UI.Button _refreshButton;
        /*0xa0*/ NoaDebugger.HierarchyPanelScrollHelper<NoaDebugger.HierarchyPanel, NoaDebugger.HierarchyPanelData> _scrollHelper;
        /*0xa8*/ System.Action OnRefreshHierarchy;

        /*0x730b9dc*/ HierarchyFloatingWindowView();
        /*0x730b5e8*/ void add_OnRefreshHierarchy(System.Action value);
        /*0x730b684*/ void remove_OnRefreshHierarchy(System.Action value);
        /*0x730b720*/ void _OnValidateUI();
        /*0x730b724*/ void _OnShow(NoaDebugger.HierarchyViewLinker linker);
        /*0x730b9c0*/ void _OnRefresh();
    }

    class HierarchyPanelBase<T> : UnityEngine.MonoBehaviour
    {
        static int PADDING_PER_DEPTH = 10;
        /*0x0*/ UnityEngine.Color DefaultColor;
        /*0x0*/ UnityEngine.UI.Image _background;
        /*0x0*/ UnityEngine.UI.LayoutElement _layoutElement;
        /*0x0*/ UnityEngine.UI.LayoutGroup _depthPaddingTarget;
        /*0x0*/ UnityEngine.UI.Button _toggle;
        /*0x0*/ UnityEngine.RectTransform _toggleIcon;
        /*0x0*/ UnityEngine.RectTransform _rectTransform;
        /*0x0*/ T _data;

        /*0x380cb08*/ HierarchyPanelBase();
        /*0x3907c14*/ void Draw(T panelData);
        /*0x3907c14*/ void _Draw(T panelData);
        /*0x380c2e4*/ float GetPanelWidth();
        /*0x380c2e4*/ float GetLabelLength();
        /*0x380c2e4*/ float _GetLabelLength();
        /*0x380e050*/ void SetPanelWidth(float width);
        /*0x380cb08*/ void _RefreshToggleIcon();
        /*0x380cb08*/ void _OnToggleButton();
        /*0x380cb08*/ void <Draw>b__9_0();
    }

    class HierarchyPanelDataBase
    {
        /*0x10*/ int _depth;
        /*0x14*/ bool _isActive;
        /*0x15*/ bool _isOpen;
        /*0x16*/ bool _isSelected;
        /*0x17*/ bool _hasChildren;
        /*0x18*/ System.Action _toggleOpen;
        /*0x20*/ System.Action _onUpdateView;

        /*0x730af14*/ HierarchyPanelDataBase();
    }

    class HierarchyPanelScrollHelper<TPanel, TData>
    {
        /*0x0*/ NoaDebugger.ObjectPoolScroll _scroll;
        /*0x0*/ System.Collections.Generic.List<TData> _dataList;
        /*0x0*/ bool _isRunningSetPanelWidthCoroutine;
        /*0x0*/ float _maxLabelLength;

        /*0x380d83c*/ HierarchyPanelScrollHelper(NoaDebugger.ObjectPoolScroll scroll);
        /*0x380d83c*/ void RefreshScroll(System.Collections.Generic.List<TData> dataList);
        /*0x380b9e8*/ System.Collections.IEnumerator _WaitAfterSetPanelWidth();
        /*0x380d170*/ void _OnRefreshPanel(int index, UnityEngine.GameObject target);

        class <>c<TPanel, TData>
        {
            static /*0x0*/ NoaDebugger.HierarchyPanelScrollHelper.<>c<TPanel, TData> <>9;
            static /*0x0*/ System.Func<NoaDebugger.ObjectPoolScroll.PanelData, TPanel> <>9__6_0;

            static /*0x38358cc*/ <>c();
            /*0x380cb08*/ <>c();
            /*0x3907c14*/ TPanel <_WaitAfterSetPanelWidth>b__6_0(NoaDebugger.ObjectPoolScroll.PanelData showPanel);
        }

        class <_WaitAfterSetPanelWidth>d__6<TPanel, TData> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ NoaDebugger.HierarchyPanelScrollHelper<TPanel, TData> <>4__this;

            /*0x380cffc*/ <_WaitAfterSetPanelWidth>d__6(int <>1__state);
            /*0x380cb08*/ void System.IDisposable.Dispose();
            /*0x380b128*/ bool MoveNext();
            /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
            /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class HierarchyView : NoaDebugger.NoaDebuggerToolViewBase<NoaDebugger.HierarchyViewLinker>
    {
        /*0x28*/ NoaDebugger.GameObjectDetailView _gameObjectDetail;
        /*0x30*/ NoaDebugger.HierarchyTreeView _hierarchyTree;

        /*0x730ba64*/ HierarchyView();
        /*0x730ba24*/ void _OnShow(NoaDebugger.HierarchyViewLinker linker);
    }

    class HierarchyViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ NoaDebugger.HierarchyViewData _hierarchyViewData;
        /*0x20*/ NoaDebugger.GameObjectDetail _selectGameObjectDetail;

        /*0x730baac*/ HierarchyViewLinker();
    }

    struct HierarchyViewData
    {
        /*0x10*/ System.Collections.Generic.List<NoaDebugger.HierarchyPanelData> _hierarchyPanelList;
        /*0x18*/ int _sceneNum;
        /*0x1c*/ int _objectNum;
    }

    struct GameObjectDetail
    {
        /*0x10*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailPanelData> _componentPanelList;
        /*0x18*/ int _componentNum;
        /*0x1c*/ bool _isLock;
        /*0x1d*/ bool _isActive;
    }

    class FloatingHierarchyPanel : NoaDebugger.HierarchyPanel
    {
        /*0x730bdf0*/ FloatingHierarchyPanel();
        /*0x730bab4*/ void _Draw(NoaDebugger.HierarchyPanelData panelData);
        /*0x730bcdc*/ void _OnSelectButton();
    }

    class HierarchyPanel : NoaDebugger.HierarchyPanelBase<NoaDebugger.HierarchyPanelData>
    {
        /*0x68*/ TMPro.TextMeshProUGUI _nameLabel;
        /*0x70*/ UnityEngine.UI.Button _selectButton;
        /*0x78*/ UnityEngine.GameObject _selectIcon;

        /*0x730bdf4*/ HierarchyPanel();
        /*0x730bb6c*/ void _Draw(NoaDebugger.HierarchyPanelData panelData);
        /*0x730be3c*/ float _GetLabelLength();
        /*0x730bdb8*/ void _OnSelect();
    }

    class HierarchyPanelData : NoaDebugger.HierarchyPanelDataBase
    {
        /*0x28*/ string _gameObjectName;
        /*0x30*/ NoaDebugger.HierarchyGameObjectEntry _entry;
        /*0x38*/ System.Action<NoaDebugger.HierarchyGameObjectEntry> _onSelect;

        /*0x730be60*/ HierarchyPanelData(NoaDebugger.HierarchyGameObjectEntry entry, int depth, System.Action onToggle);
    }

    class HierarchyTreeView : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _sceneCountLabel;
        /*0x28*/ TMPro.TextMeshProUGUI _objectCountLabel;
        /*0x30*/ NoaDebugger.ObjectPoolScroll _hierarchyScroll;
        /*0x38*/ UnityEngine.UI.Button _refreshButton;
        /*0x40*/ NoaDebugger.HierarchyPanelScrollHelper<NoaDebugger.HierarchyPanel, NoaDebugger.HierarchyPanelData> _scrollHelper;
        /*0x48*/ System.Action OnRefreshHierarchy;

        /*0x730c148*/ HierarchyTreeView();
        /*0x730bf54*/ void add_OnRefreshHierarchy(System.Action value);
        /*0x730bff0*/ void remove_OnRefreshHierarchy(System.Action value);
        /*0x730c08c*/ void _OnValidateUI();
        /*0x730b868*/ void Show(NoaDebugger.HierarchyViewData hierarchyData);
        /*0x730c12c*/ void _OnRefresh();
    }

    class CustomInformationScrollDrawer : UnityEngine.EventSystems.UIBehaviour
    {
        /*0x20*/ NoaDebugger.ContextPanelView _customPanelView;
        /*0x28*/ System.Collections.Generic.List<NoaDebugger.CustomInformationScrollDrawer.PanelObject> _poolPanelObjects;
        /*0x30*/ UnityEngine.UI.ScrollRect _scroll;
        /*0x38*/ UnityEngine.RectTransform _scrollRectTransform;
        /*0x40*/ UnityEngine.UI.VerticalLayoutGroup _contentLayout;
        /*0x48*/ UnityEngine.RectTransform _verticalScrollbarRect;
        /*0x50*/ NoaDebugger.ContentPanelPool _panelPool;
        /*0x58*/ bool _isInit;

        /*0x730cdf8*/ CustomInformationScrollDrawer();
        /*0x730c150*/ void Awake();
        /*0x730c31c*/ void Draw(System.Collections.Generic.List<NoaDebugger.InformationCustomGroup> groups);
        /*0x730c550*/ void _CreateContextPanel();
        /*0x730c67c*/ void _DrawContextPanel(NoaDebugger.ContextPanelView panel, NoaDebugger.InformationCustomGroup groupInfo);
        /*0x730cc6c*/ void SetLineWidth();
        /*0x730cde8*/ void OnRectTransformDimensionsChange();
        /*0x730cbcc*/ float _GetLineMinWidth();

        class PanelObject
        {
            /*0x10*/ NoaDebugger.ContextPanelView _panel;
            /*0x18*/ int _index;

            /*0x730cb90*/ PanelObject(NoaDebugger.ContextPanelView panel, int index);
        }

        class <>c
        {
            static /*0x0*/ NoaDebugger.CustomInformationScrollDrawer.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.InformationCustomGroup, int> <>9__10_0;
            static /*0x10*/ System.Func<NoaDebugger.InformationCustomKeyValue, int> <>9__12_0;

            static /*0x730ce00*/ <>c();
            /*0x730ce68*/ <>c();
            /*0x730ce70*/ int <Draw>b__10_0(NoaDebugger.InformationCustomGroup g);
            /*0x730ce88*/ int <_DrawContextPanel>b__12_0(NoaDebugger.InformationCustomKeyValue kv);
        }
    }

    class CustomInformationView : NoaDebugger.ViewBase<NoaDebugger.CustomInformationViewLinker>
    {
        /*0x20*/ NoaDebugger.CustomInformationScrollDrawer _drawer;
        /*0x28*/ UnityEngine.GameObject _noDataLabel;

        /*0x730cf54*/ CustomInformationView();
        /*0x730cea0*/ void _OnShow(NoaDebugger.CustomInformationViewLinker linker);
        /*0x730cf30*/ void _OnHide();
    }

    class CustomInformationViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ System.Collections.Generic.List<NoaDebugger.InformationCustomGroup> _groups;

        /*0x730cf9c*/ CustomInformationViewLinker();
    }

    class InformationView : NoaDebugger.NoaDebuggerToolViewBase<NoaDebugger.InformationViewLinker>
    {
        /*0x28*/ NoaDebugger.ToggleButtonBase _systemButton;
        /*0x30*/ NoaDebugger.ToggleButtonBase _unityButton;
        /*0x38*/ NoaDebugger.ToggleButtonBase _customButton;
        /*0x40*/ NoaDebugger.LongTapToggleColorButton _refreshButton;
        /*0x48*/ NoaDebugger.DisableButtonBase _downloadButton;
        /*0x50*/ NoaDebugger.SystemInformationView _systemInfoView;
        /*0x58*/ NoaDebugger.UnityInformationView _unityInfoView;
        /*0x60*/ NoaDebugger.CustomInformationView _customInfoView;
        /*0x68*/ UnityEngine.Events.UnityAction<NoaDebugger.InformationView.ToggleTabType> OnClickTab;
        /*0x70*/ UnityEngine.Events.UnityAction<bool> OnTapRefreshButton;
        /*0x78*/ UnityEngine.Events.UnityAction OnLongTapRefreshButton;
        /*0x80*/ UnityEngine.Events.UnityAction OnClickDownload;

        /*0x730db44*/ InformationView();
        /*0x730cfa4*/ void add_OnClickTab(UnityEngine.Events.UnityAction<NoaDebugger.InformationView.ToggleTabType> value);
        /*0x730d054*/ void remove_OnClickTab(UnityEngine.Events.UnityAction<NoaDebugger.InformationView.ToggleTabType> value);
        /*0x730d104*/ void add_OnTapRefreshButton(UnityEngine.Events.UnityAction<bool> value);
        /*0x730d1b4*/ void remove_OnTapRefreshButton(UnityEngine.Events.UnityAction<bool> value);
        /*0x730d264*/ void add_OnLongTapRefreshButton(UnityEngine.Events.UnityAction value);
        /*0x730d300*/ void remove_OnLongTapRefreshButton(UnityEngine.Events.UnityAction value);
        /*0x730d39c*/ void add_OnClickDownload(UnityEngine.Events.UnityAction value);
        /*0x730d438*/ void remove_OnClickDownload(UnityEngine.Events.UnityAction value);
        /*0x730d4d4*/ void _Init();
        /*0x730d810*/ void _OnShow(NoaDebugger.InformationViewLinker linker);
        /*0x730da68*/ void _OnClickSystemTab(bool isOn);
        /*0x730da8c*/ void _OnClickUnityTab(bool isOn);
        /*0x730dab0*/ void _OnClickCustomTab(bool isOn);
        /*0x730dad4*/ void _OnClickReload();
        /*0x730db0c*/ void _OnLongTapRefreshButton(bool isToggleOn);
        /*0x730db28*/ void _OnClickDownload();

        enum ToggleTabType
        {
            System = 0,
            Unity = 1,
            Custom = 2,
        }
    }

    class InformationViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ NoaDebugger.SystemInformationViewLinker _systemInformationViewLinker;
        /*0x18*/ NoaDebugger.UnityInformationViewLinker _unityInformationViewLinker;
        /*0x20*/ NoaDebugger.CustomInformationViewLinker _customInformationViewLinker;
        /*0x28*/ NoaDebugger.InformationView.ToggleTabType _tabType;
        /*0x2c*/ bool _isAutoRefresh;

        /*0x730db8c*/ InformationViewLinker();
    }

    class SystemInformationView : NoaDebugger.ViewBase<NoaDebugger.SystemInformationViewLinker>
    {
        /*0x20*/ NoaDebugger.ContextPanelView _contextPanelView;
        /*0x28*/ NoaDebugger.ContextPanelView _applicationPanelView;
        /*0x30*/ NoaDebugger.ContextPanelView _devicePanelView;
        /*0x38*/ NoaDebugger.ContextPanelView _cpuPanelView;
        /*0x40*/ NoaDebugger.ContextPanelView _gpuPanelView;
        /*0x48*/ NoaDebugger.ContextPanelView _memoryPanelView;
        /*0x50*/ NoaDebugger.ContextPanelView _displayPanelView;

        /*0x730e6ac*/ SystemInformationView();
        /*0x730db94*/ void _OnStart();
        /*0x730dc00*/ void _OnShow(NoaDebugger.SystemInformationViewLinker linker);
        /*0x730e688*/ void _OnHide();
    }

    class SystemInformationViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ string _identification;
        /*0x18*/ string _version;
        /*0x20*/ string _language;
        /*0x28*/ string _platform;
        /*0x30*/ string _os;
        /*0x38*/ string _deviceModel;
        /*0x40*/ string _deviceType;
        /*0x48*/ string _deviceName;
        /*0x50*/ string _cpuType;
        /*0x58*/ string _cpuCount;
        /*0x60*/ string _gpuDeviceName;
        /*0x68*/ string _gpuDeviceType;
        /*0x70*/ string _gpuDeviceVersion;
        /*0x78*/ string _gpuDeviceVendor;
        /*0x80*/ string _gpuDeviceSize;
        /*0x88*/ string _memorySize;
        /*0x90*/ string _refreshRate;
        /*0x98*/ string _resolution;
        /*0xa0*/ string _aspect;
        /*0xa8*/ string _dpi;
        /*0xb0*/ string _orientation;
        /*0xb8*/ string _fullscreenMode;

        /*0x730e6f4*/ SystemInformationViewLinker();
    }

    class UnityInformationView : NoaDebugger.ViewBase<NoaDebugger.UnityInformationViewLinker>
    {
        /*0x20*/ TMPro.TextMeshProUGUI _version;
        /*0x28*/ UnityEngine.GameObject _debugCheck;
        /*0x30*/ UnityEngine.GameObject _debugCross;
        /*0x38*/ UnityEngine.GameObject _il2CppCheck;
        /*0x40*/ UnityEngine.GameObject _il2CppCross;
        /*0x48*/ TMPro.TextMeshProUGUI _vSyncCount;
        /*0x50*/ TMPro.TextMeshProUGUI _targetFrameRate;
        /*0x58*/ TMPro.TextMeshProUGUI _playTime;
        /*0x60*/ TMPro.TextMeshProUGUI _levelPlayTime;
        /*0x68*/ TMPro.TextMeshProUGUI _currentLevel;
        /*0x70*/ TMPro.TextMeshProUGUI _qualityLevel;
        /*0x78*/ TMPro.TextMeshProUGUI _srpBatcher;
        /*0x80*/ TMPro.TextMeshProUGUI _renderPipeline;
        /*0x88*/ TMPro.TextMeshProUGUI _location;
        /*0x90*/ TMPro.TextMeshProUGUI _accelerometer;
        /*0x98*/ TMPro.TextMeshProUGUI _gyroscope;
        /*0xa0*/ TMPro.TextMeshProUGUI _vibration;
        /*0xa8*/ TMPro.TextMeshProUGUI _maxTexSize;
        /*0xb0*/ TMPro.TextMeshProUGUI _npotSupport;
        /*0xb8*/ TMPro.TextMeshProUGUI _computeShaders;
        /*0xc0*/ TMPro.TextMeshProUGUI _shadows;
        /*0xc8*/ TMPro.TextMeshProUGUI _sparseTextures;

        /*0x730f4d4*/ UnityInformationView();
        /*0x730e6fc*/ void _OnShow(NoaDebugger.UnityInformationViewLinker linker);
        /*0x730f32c*/ void _OnHide();
        /*0x730e778*/ void _OnShowUnityInfo(NoaDebugger.UnityInformationViewLinker.UnityInfo info);
        /*0x730e910*/ void _OnShowRuntime(NoaDebugger.UnityInformationViewLinker.Runtime info);
        /*0x730edac*/ void _OnShowFeatures(NoaDebugger.UnityInformationViewLinker.Features info);
        /*0x730f068*/ void _OnShowGraphics(NoaDebugger.UnityInformationViewLinker.Graphics info);
        /*0x730f350*/ string _ConvertLabel(string label);
        /*0x730f3c4*/ string _ConvertFlag(bool flag);
        /*0x730f464*/ bool _IsAcquireLabel(string label);
    }

    class UnityInformationViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ NoaDebugger.UnityInformationViewLinker.UnityInfo _unityInfo;
        /*0x18*/ NoaDebugger.UnityInformationViewLinker.Runtime _runtimeInfo;
        /*0x20*/ NoaDebugger.UnityInformationViewLinker.Features _featuresInfo;
        /*0x28*/ NoaDebugger.UnityInformationViewLinker.Graphics _graphicsInfo;

        /*0x730f51c*/ UnityInformationViewLinker();

        class UnityInfo
        {
            /*0x10*/ string _version;
            /*0x18*/ bool _debug;
            /*0x19*/ bool _il2CPP;
            /*0x1c*/ int _vSyncCount;
            /*0x20*/ int _targetFrameRate;

            /*0x730f524*/ UnityInfo();
        }

        class Runtime
        {
            /*0x10*/ float _playTime;
            /*0x14*/ float _levelPlayTime;
            /*0x18*/ string _currentLevelSceneName;
            /*0x20*/ int _currentLevelBuildIndex;
            /*0x24*/ int _qualityLevel;
            /*0x28*/ string _renderPipeline;
            /*0x30*/ string _srpBatcher;

            /*0x730f52c*/ Runtime();
        }

        class Features
        {
            /*0x10*/ bool _location;
            /*0x11*/ bool _accelerometer;
            /*0x12*/ bool _gyroscope;
            /*0x13*/ bool _vibration;

            /*0x730f534*/ Features();
        }

        class Graphics
        {
            /*0x10*/ int _maxTexSize;
            /*0x14*/ UnityEngine.NPOTSupport _npotSupport;
            /*0x18*/ bool _computeShaders;
            /*0x19*/ bool _shadows;
            /*0x1a*/ bool _sparseTextures;

            /*0x730f53c*/ Graphics();
        }
    }

    class ApiLogDetailView : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.ApiLogDetailView.TabbedContent _request;
        /*0x30*/ NoaDebugger.ApiLogDetailView.TabbedContent _response;
        /*0x40*/ NoaDebugger.ContextPanelView _apiDetailPanel;
        /*0x48*/ NoaDebugger.ContextPanelView _requestHeaderPanel;
        /*0x50*/ NoaDebugger.ContextPanelView _requestBodyPanel;
        /*0x58*/ NoaDebugger.ContextPanelView _responseHeaderPanel;
        /*0x60*/ NoaDebugger.ContextPanelView _responseBodyPanel;
        /*0x68*/ UnityEngine.UI.Button _copyButton;
        /*0x70*/ UnityEngine.Events.UnityAction _onClickCopyButton;

        /*0x731005c*/ ApiLogDetailView();
        /*0x730f544*/ void Awake();
        /*0x730f748*/ void ResetContent();
        /*0x730f808*/ void SetCopyButton(UnityEngine.Events.UnityAction onClick);
        /*0x730f844*/ void UpdateRequestTab(NoaDebugger.ApiLog log);
        /*0x730fc98*/ void UpdateResponseTab(NoaDebugger.ApiLog log);
        /*0x730ffd4*/ void _OnShowRequest(bool showsContent);
        /*0x730fff4*/ void _OnShowResponse(bool showsContent);
        /*0x7310014*/ void _OnCopy();

        struct TabbedContent
        {
            /*0x10*/ NoaDebugger.ToggleButtonBase _tabButton;
            /*0x18*/ UnityEngine.GameObject _viewRoot;
        }
    }

    class ApiLogOverlaySettingsDefaultGetter : NoaDebugger.LogOverlaySettingsDefaultGetter
    {
        /*0x7310064*/ ApiLogOverlaySettingsDefaultGetter();
        /*0x7310094*/ NoaDebugger.NoaDebug.OverlayPosition get_DefaultPosition();
        /*0x73100b0*/ float get_DefaultFontScale();
        /*0x73100cc*/ int get_DefaultMaximumLogCount();
        /*0x73100e8*/ float get_DefaultMinimumOpacity();
        /*0x7310104*/ float get_DefaultActiveDuration();
        /*0x7310120*/ bool get_DefaultShowTimestamp();
        /*0x731013c*/ bool get_DefaultShowMessageLogs();
        /*0x7310158*/ bool get_DefaultShowWarningLogs();
        /*0x7310160*/ bool get_DefaultShowErrorLogs();
    }

    class ApiLogView : NoaDebugger.LogViewBase
    {
        /*0xe0*/ NoaDebugger.ApiLogDetailView _logDetail;
        /*0xe8*/ NoaDebugger.OrientationLayoutRuntimeAdjuster _layoutAdjuster;

        /*0x7310390*/ ApiLogView();
        /*0x731017c*/ void _OnInit();
        /*0x7310180*/ void _OnShow(NoaDebugger.LogViewLinker linker);
        /*0x73101a8*/ void _OnUpdateDetail(NoaDebugger.ILogDetail detail);
        /*0x7310360*/ void _UpdateRequestTab(NoaDebugger.ApiLog log);
        /*0x7310378*/ void _UpdateResponseTab(NoaDebugger.ApiLog log);

        class <>c__DisplayClass4_0
        {
            /*0x10*/ NoaDebugger.ApiLogView <>4__this;
            /*0x18*/ NoaDebugger.ApiLog log;

            /*0x7310358*/ <>c__DisplayClass4_0();
            /*0x7310398*/ void <_OnUpdateDetail>b__0();
        }
    }

    class ConsoleLogOverlaySettingsDefaultGetter : NoaDebugger.LogOverlaySettingsDefaultGetter
    {
        /*0x73103c8*/ ConsoleLogOverlaySettingsDefaultGetter();
        /*0x73103cc*/ NoaDebugger.NoaDebug.OverlayPosition get_DefaultPosition();
        /*0x73103e8*/ float get_DefaultFontScale();
        /*0x7310404*/ int get_DefaultMaximumLogCount();
        /*0x7310420*/ float get_DefaultMinimumOpacity();
        /*0x731043c*/ float get_DefaultActiveDuration();
        /*0x7310458*/ bool get_DefaultShowTimestamp();
        /*0x7310474*/ bool get_DefaultShowMessageLogs();
        /*0x7310490*/ bool get_DefaultShowWarningLogs();
        /*0x73104ac*/ bool get_DefaultShowErrorLogs();
    }

    class ConsoleLogView : NoaDebugger.LogViewBase
    {
        /*0xe0*/ NoaDebugger.ConsoleLogDetailView _logDetail;

        /*0x73106d4*/ ConsoleLogView();
        /*0x73104c8*/ void _OnInit();
        /*0x73104cc*/ void _OnUpdateDetail(NoaDebugger.ILogDetail detail);

        class <>c__DisplayClass2_0
        {
            /*0x10*/ NoaDebugger.ConsoleLogView <>4__this;
            /*0x18*/ NoaDebugger.ConsoleLogDetail log;

            /*0x7310658*/ <>c__DisplayClass2_0();
            /*0x73106dc*/ void <_OnUpdateDetail>b__0();
        }
    }

    class ConsoleLogDetailView : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _logDetailText;
        /*0x28*/ UnityEngine.UI.Button _copyButton;
        /*0x30*/ UnityEngine.Events.UnityAction _onClickCopyButton;

        /*0x7310834*/ ConsoleLogDetailView();
        /*0x731070c*/ void Awake();
        /*0x7310660*/ void SetLogDetailText(string text);
        /*0x7310698*/ void SetCopyButton(UnityEngine.Events.UnityAction onClick);
        /*0x73107b4*/ void _OnCopy();
        /*0x73107fc*/ void OnDestroy();
    }

    class LogOverlaySettingsDefaultGetter
    {
        /*0x10*/ NoaDebugger.NoaDebuggerSettings _settings;

        /*0x7310068*/ LogOverlaySettingsDefaultGetter();
        /*0x380b6a0*/ NoaDebugger.NoaDebug.OverlayPosition get_DefaultPosition();
        /*0x380c2e4*/ float get_DefaultFontScale();
        /*0x380b6a0*/ int get_DefaultMaximumLogCount();
        /*0x380c2e4*/ float get_DefaultMinimumOpacity();
        /*0x380c2e4*/ float get_DefaultActiveDuration();
        /*0x380b128*/ bool get_DefaultShowTimestamp();
        /*0x380b128*/ bool get_DefaultShowMessageLogs();
        /*0x380b128*/ bool get_DefaultShowWarningLogs();
        /*0x380b128*/ bool get_DefaultShowErrorLogs();
    }

    class LogOverlaySettingsView : NoaDebugger.OverlaySettingsViewBase<NoaDebugger.LogOverlaySettings>
    {
        /*0x38*/ NoaDebugger.OverlayEnumSettingsPanel _position;
        /*0x40*/ NoaDebugger.OverlayFloatSettingsPanel _fontScale;
        /*0x48*/ NoaDebugger.OverlayIntSettingsPanel _maximumLogCount;
        /*0x50*/ NoaDebugger.OverlayFloatSettingsPanel _minimumOpacity;
        /*0x58*/ NoaDebugger.OverlayFloatSettingsPanel _activeDuration;
        /*0x60*/ NoaDebugger.OverlayBoolSettingsPanel _showTimestamp;
        /*0x68*/ NoaDebugger.OverlayBoolSettingsPanel _showMessageLogs;
        /*0x70*/ NoaDebugger.OverlayBoolSettingsPanel _showWarningLogs;
        /*0x78*/ NoaDebugger.OverlayBoolSettingsPanel _showErrorLogs;

        /*0x7310a84*/ LogOverlaySettingsView();
        /*0x731083c*/ void _OnValidateUI();
        /*0x7310840*/ void _Init();
        /*0x7310888*/ void _OnShow(NoaDebugger.LogOverlaySettings linker);
        /*0x73109c0*/ void Refresh();
    }

    class LogOverlaySettings : NoaDebugger.OverlayToolSettingsBase
    {
        /*0x30*/ NoaDebugger.OverlayFloatSettings _fontScale;
        /*0x38*/ NoaDebugger.OverlayIntSettings _maximumLogCount;
        /*0x40*/ NoaDebugger.OverlayFloatSettings _minimumOpacity;
        /*0x48*/ NoaDebugger.OverlayFloatSettings _activeDuration;
        /*0x50*/ NoaDebugger.OverlayBoolSettings _showTimestamp;
        /*0x58*/ NoaDebugger.OverlayBoolSettings _showMessageLogs;
        /*0x60*/ NoaDebugger.OverlayBoolSettings _showWarningLogs;
        /*0x68*/ NoaDebugger.OverlayBoolSettings _showErrorLogs;
        /*0x70*/ NoaDebugger.LogOverlaySettingsDefaultGetter _defaultGetter;

        /*0x73112ec*/ LogOverlaySettings();
        /*0x7310acc*/ NoaDebugger.NoaDebug.OverlayPosition get_DefaultPosition();
        /*0x7310b38*/ NoaDebugger.OverlayFloatSettings get_FontScale();
        /*0x7310b40*/ NoaDebugger.OverlayIntSettings get_MaximumLogCount();
        /*0x7310b48*/ NoaDebugger.OverlayFloatSettings get_MinimumOpacity();
        /*0x7310b50*/ NoaDebugger.OverlayFloatSettings get_ActiveDuration();
        /*0x7310b58*/ NoaDebugger.OverlayBoolSettings get_ShowTimestamp();
        /*0x7310b60*/ NoaDebugger.OverlayBoolSettings get_ShowMessageLogs();
        /*0x7310b68*/ NoaDebugger.OverlayBoolSettings get_ShowWarningLogs();
        /*0x7310b70*/ NoaDebugger.OverlayBoolSettings get_ShowErrorLogs();
        /*0x7310b78*/ void ReceiveDefaultGetter(NoaDebugger.LogOverlaySettingsDefaultGetter defaultGetter);
        /*0x7310b80*/ void _InitializeSettings();
        /*0x7311070*/ void _LoadSettings(string overlayPrefsJson);
        /*0x7311234*/ void _ResetSettings();
    }

    class LogOverlayView : NoaDebugger.OverlayViewBase<NoaDebugger.LogOverlaySettings, NoaDebugger.LogOverlayViewLinker>
    {
        static float FADE_TIME = 1;
        static string DEVICE_ORIENTATION_KEY_PREFIX = "LogOverlayViewDeviceOrientation";
        /*0x38*/ UnityEngine.RectTransform _root;
        /*0x40*/ UnityEngine.CanvasGroup _canvasGroup;
        /*0x48*/ NoaDebugger.UIBehaviourComponent _uiBehaviour;
        /*0x50*/ TMPro.TextMeshProUGUI _logCounter;
        /*0x58*/ TMPro.TextMeshProUGUI _warningCounter;
        /*0x60*/ TMPro.TextMeshProUGUI _errorCounter;
        /*0x68*/ UnityEngine.GameObject _logEntryPrefab;
        /*0x70*/ UnityEngine.RectTransform _logEntryParent;
        /*0x78*/ UnityEngine.RectOffset _logEntryParentLayoutPadding;
        /*0x80*/ float _logEntryParentLayoutSpacing;
        /*0x88*/ NoaDebugger.OverlayLogPanel _logEntryReference;
        /*0x90*/ System.Collections.Generic.Queue<NoaDebugger.OverlayLogPanel> _displayedLogEntryList;
        /*0x98*/ System.Collections.Generic.Stack<NoaDebugger.OverlayLogPanel> _reservedLogEntryList;
        /*0xa0*/ float beforeMinimumOpacity;
        /*0xa8*/ System.Collections.IEnumerator _hideCoroutine;
        /*0xb0*/ System.Collections.IEnumerator _fadeOutCoroutine;
        /*0xb8*/ float _tmpFontScale;
        /*0xbc*/ int _tmpMaximumLogCount;
        /*0xc0*/ System.Action OnEnabledAction;

        /*0x7313848*/ LogOverlayView();
        /*0x73115b8*/ string get_DeviceOrientationKey();
        /*0x7311624*/ void add_OnEnabledAction(System.Action value);
        /*0x73116c0*/ void remove_OnEnabledAction(System.Action value);
        /*0x731175c*/ void _OnValidateUI();
        /*0x7311760*/ void _Init();
        /*0x7311b80*/ void OnEnable();
        /*0x7311bb4*/ System.Collections.IEnumerator OnEnableDelay();
        /*0x7311c48*/ void OnUpdateSettings(NoaDebugger.LogOverlaySettings settings);
        /*0x7311d74*/ void OnUpdate(NoaDebugger.LogOverlayViewLinker linker);
        /*0x7312554*/ void _OnTargetRectTransformDimensionsChanged();
        /*0x7312574*/ void _OnDeviceOrientation(bool isPortrait);
        /*0x7311ad0*/ void _RefreshWindowWidth(bool isPortrait);
        /*0x7312084*/ void _RefreshFontScale();
        /*0x7312664*/ void _RefreshWindowHeight();
        /*0x7311ffc*/ void _RefreshLogEntries(System.Collections.Generic.List<NoaDebugger.LogViewLinker.LogPanelInfo> allLogs);
        /*0x7312784*/ void _InstantiateLogEntries(int logNum);
        /*0x7312cf0*/ void _DisplayNewLogEntry(System.Collections.Generic.List<NoaDebugger.LogViewLinker.LogPanelInfo> logs, bool isShowTimestamp);
        /*0x73128d4*/ void _HideExistLogEntries(System.Collections.Generic.List<NoaDebugger.LogViewLinker.LogPanelInfo> logs);
        /*0x7311924*/ void _InstantiateReferenceLogEntry();
        /*0x7312478*/ void _ManagedHideDelay();
        /*0x73135e8*/ System.Collections.IEnumerator _HideAfterDelay(float delayTime);
        /*0x731368c*/ System.Collections.IEnumerator _FadeOut();
        /*0x7311d18*/ void ApplyMinimumOpacitySetting();
        /*0x7313720*/ void OnDestroy();

        class <>c
        {
            static /*0x0*/ NoaDebugger.LogOverlayView.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.LogViewLinker.LogPanelInfo, bool> <>9__30_0;
            static /*0x10*/ System.Func<NoaDebugger.OverlayLogPanel, int> <>9__38_0;

            static /*0x7313980*/ <>c();
            /*0x73139e8*/ <>c();
            /*0x73139f0*/ bool <OnUpdate>b__30_0(NoaDebugger.LogViewLinker.LogPanelInfo log);
            /*0x7313a10*/ int <_DisplayNewLogEntry>b__38_0(NoaDebugger.OverlayLogPanel panel);
        }

        class <OnEnableDelay>d__28 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.LogOverlayView <>4__this;

            /*0x7311c20*/ <OnEnableDelay>d__28(int <>1__state);
            /*0x7313a4c*/ void System.IDisposable.Dispose();
            /*0x7313a50*/ bool MoveNext();
            /*0x7313b08*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x7313b10*/ void System.Collections.IEnumerator.Reset();
            /*0x7313b48*/ object System.Collections.IEnumerator.get_Current();
        }

        class <_FadeOut>d__43 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.LogOverlayView <>4__this;
            /*0x28*/ float <startTime>5__2;
            /*0x2c*/ float <elapsedTime>5__3;
            /*0x30*/ float <minimumOpacity>5__4;

            /*0x73136f8*/ <_FadeOut>d__43(int <>1__state);
            /*0x7313b50*/ void System.IDisposable.Dispose();
            /*0x7313b54*/ bool MoveNext();
            /*0x7313c80*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x7313c88*/ void System.Collections.IEnumerator.Reset();
            /*0x7313cc0*/ object System.Collections.IEnumerator.get_Current();
        }

        class <_HideAfterDelay>d__42 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ float delayTime;
            /*0x28*/ NoaDebugger.LogOverlayView <>4__this;
            /*0x30*/ float <startTime>5__2;
            /*0x34*/ float <elapsedTime>5__3;

            /*0x7313664*/ <_HideAfterDelay>d__42(int <>1__state);
            /*0x7313cc8*/ void System.IDisposable.Dispose();
            /*0x7313ccc*/ bool MoveNext();
            /*0x7313da4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x7313dac*/ void System.Collections.IEnumerator.Reset();
            /*0x7313de4*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class LogOverlayViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ System.Collections.Generic.List<NoaDebugger.LogViewLinker.LogPanelInfo> _logs;
        /*0x18*/ NoaDebugger.LogViewLinker.LogTypeToggles _logTypeToggles;

        /*0x7313dec*/ LogOverlayViewLinker();
    }

    class LogPanel : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.GameObject _select;
        /*0x28*/ UnityEngine.UI.Image _logType;
        /*0x30*/ TMPro.TextMeshProUGUI _logString;
        /*0x38*/ NoaDebugger.LongTapButton _selfButton;
        /*0x40*/ UnityEngine.GameObject _logCounterRoot;
        /*0x48*/ TMPro.TextMeshProUGUI _logCounter;
        /*0x50*/ UnityEngine.UI.Image _backGround;
        /*0x58*/ NoaDebugger.LogPanelCommonDisplayProcessing _displayProcessing;
        /*0x60*/ int _index;
        /*0x68*/ UnityEngine.Events.UnityAction<int> _onClick;
        /*0x70*/ UnityEngine.Events.UnityAction<int> _onPointerDown;
        /*0x78*/ UnityEngine.Events.UnityAction _onLongTap;

        /*0x7314420*/ LogPanel();
        /*0x7313df4*/ void _OnValidateUI();
        /*0x7313df8*/ void Awake();
        /*0x7313f78*/ void Draw(NoaDebugger.LogViewLinker.LogPanelInfo logInfo, bool isSelect);
        /*0x731430c*/ void _OnClick();
        /*0x731432c*/ void _OnPointerDown();
        /*0x731434c*/ void _OnLongTap();
        /*0x7314368*/ void OnDestroy();
    }

    class LogPanelCommonDisplayProcessing
    {
        /*0x10*/ UnityEngine.UI.Image _logType;
        /*0x18*/ TMPro.TextMeshProUGUI _logString;
        /*0x20*/ UnityEngine.GameObject _logCounterRoot;
        /*0x28*/ TMPro.TextMeshProUGUI _logCounter;

        static /*0x7314428*/ UnityEngine.Color _GetLogTypeColor(NoaDebugger.LogType type);
        /*0x7314108*/ LogPanelCommonDisplayProcessing(UnityEngine.UI.Image logType, TMPro.TextMeshProUGUI logString, UnityEngine.GameObject logCounterRoot, TMPro.TextMeshProUGUI logCounter);
        /*0x731417c*/ void RefreshLogType(NoaDebugger.LogViewLinker.LogPanelInfo logInfo);
        /*0x73141b0*/ void RefreshLogString(NoaDebugger.LogViewLinker.LogPanelInfo logInfo);
        /*0x7314518*/ void RefreshLogString(string logString);
        /*0x73141c8*/ void RefreshLogCounter(NoaDebugger.LogViewLinker.LogPanelInfo logInfo);
    }

    class LogScrollDrawer : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.GameObject _scrollContent;
        /*0x28*/ NoaDebugger.ObjectPoolScroll _logScroll;
        /*0x30*/ UnityEngine.UI.Button _scrollDown;
        /*0x38*/ UnityEngine.GameObject _noDataLabel;
        /*0x40*/ UnityEngine.GameObject _filterContent;
        /*0x48*/ TMPro.TMP_InputField _filterInput;
        /*0x50*/ UnityEngine.UI.Button _clearFilter;
        /*0x58*/ System.Collections.Generic.List<NoaDebugger.LogViewLinker.LogPanelInfo> _logInfos;
        /*0x60*/ bool _isFloatingWindow;
        /*0x61*/ bool _isSelectingMode;
        /*0x62*/ bool _isEnable;
        /*0x68*/ UnityEngine.Events.UnityAction<string> OnChangeFilterText;

        /*0x7314d2c*/ LogScrollDrawer();
        /*0x7314550*/ void add_OnChangeFilterText(UnityEngine.Events.UnityAction<string> value);
        /*0x7314600*/ void remove_OnChangeFilterText(UnityEngine.Events.UnityAction<string> value);
        /*0x73146b0*/ void _OnValidateUI();
        /*0x73146b4*/ void Awake();
        /*0x731485c*/ void OnEnable();
        /*0x7314868*/ void Draw(NoaDebugger.LogViewLinker linker, bool isFloatingWindow);
        /*0x7314ab0*/ void SwitchFilterContent(bool isShow);
        /*0x7314ad0*/ void _OnScrolled();
        /*0x7314b1c*/ void _OnScrollDownToBottom();
        /*0x7314b3c*/ void _OnChangeFilterInput(string text);
        /*0x7314b58*/ void _OnResetFilterText();
        /*0x7314b88*/ void _OnRefreshPanel(int index, UnityEngine.GameObject target);
        /*0x7314cf4*/ bool _IsSelect(NoaDebugger.LogViewLinker.LogPanelInfo log);
    }

    class LogSwitchToggleDrawer : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.LogTypeToggle _messageLogToggle;
        /*0x28*/ NoaDebugger.LogTypeToggle _warningLogToggle;
        /*0x30*/ NoaDebugger.LogTypeToggle _errorLogToggle;
        /*0x38*/ UnityEngine.Events.UnityAction<NoaDebugger.LogType, bool> OnSwitchByLogType;

        /*0x7315258*/ LogSwitchToggleDrawer();
        /*0x7314d34*/ void add_OnSwitchByLogType(UnityEngine.Events.UnityAction<NoaDebugger.LogType, bool> value);
        /*0x7314de4*/ void remove_OnSwitchByLogType(UnityEngine.Events.UnityAction<NoaDebugger.LogType, bool> value);
        /*0x7314e94*/ void _OnValidateUI();
        /*0x7314e98*/ void Awake();
        /*0x7315024*/ void Draw(NoaDebugger.LogViewLinker.LogTypeToggles linker);
        /*0x73151a4*/ void _OnSwitchMessage(bool isOn);
        /*0x73151c8*/ void _OnSwitchWarning(bool isOn);
        /*0x73151ec*/ void _OnSwitchError(bool isOn);
        /*0x7315210*/ void OnDestroy();
    }

    class LogTypeToggle : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.ToggleButtonBase _toggle;
        /*0x28*/ TMPro.TextMeshProUGUI _logCountOnDisabled;
        /*0x30*/ TMPro.TextMeshProUGUI _logCountOnEnabled;

        /*0x7315298*/ LogTypeToggle();
        /*0x73150e8*/ void set_LogCount(int value);
        /*0x73150c8*/ void set_IsOn(bool value);
        /*0x7314fac*/ void set_Listener(UnityEngine.Events.UnityAction<bool> value);
        /*0x7315260*/ void OnDestroy();
    }

    class LogViewBase : NoaDebugger.NoaDebuggerToolViewBase<NoaDebugger.LogViewLinker>
    {
        /*0x28*/ UnityEngine.GameObject _logStatusRoot;
        /*0x30*/ TMPro.TextMeshProUGUI _logStatus;
        /*0x38*/ UnityEngine.GameObject _logDetailScroll;
        /*0x40*/ NoaDebugger.ToggleButtonBase _record;
        /*0x48*/ NoaDebugger.DisableButtonBase _clear;
        /*0x50*/ NoaDebugger.ToggleColorButton _selection;
        /*0x58*/ TMPro.TextMeshProUGUI _selectionCount;
        /*0x60*/ NoaDebugger.ToggleColorButton _search;
        /*0x68*/ NoaDebugger.LogScrollDrawer _logScrollDrawer;
        /*0x70*/ NoaDebugger.LogSwitchToggleDrawer _logSwitchToggleDrawer;
        /*0x78*/ UnityEngine.GameObject _footer;
        /*0x80*/ UnityEngine.UI.Button _selectAll;
        /*0x88*/ UnityEngine.UI.Button _deselectAll;
        /*0x90*/ NoaDebugger.DisableButtonBase _download;
        /*0x98*/ NoaDebugger.DisableButtonBase _send;
        /*0xa0*/ UnityEngine.Events.UnityAction OnRecord;
        /*0xa8*/ UnityEngine.Events.UnityAction OnClear;
        /*0xb0*/ UnityEngine.Events.UnityAction<bool> OnSelectingMode;
        /*0xb8*/ UnityEngine.Events.UnityAction OnSelectAll;
        /*0xc0*/ UnityEngine.Events.UnityAction OnDeselectAll;
        /*0xc8*/ UnityEngine.Events.UnityAction OnDownload;
        /*0xd0*/ UnityEngine.Events.UnityAction OnSend;
        /*0xd8*/ UnityEngine.Events.UnityAction<NoaDebugger.ILogDetail> <OnCopy>k__BackingField;

        /*0x731649c*/ LogViewBase();
        /*0x73152a0*/ void add_OnRecord(UnityEngine.Events.UnityAction value);
        /*0x731533c*/ void remove_OnRecord(UnityEngine.Events.UnityAction value);
        /*0x73153d8*/ void add_OnClear(UnityEngine.Events.UnityAction value);
        /*0x7315474*/ void remove_OnClear(UnityEngine.Events.UnityAction value);
        /*0x7315510*/ void add_OnSelectingMode(UnityEngine.Events.UnityAction<bool> value);
        /*0x73155c0*/ void remove_OnSelectingMode(UnityEngine.Events.UnityAction<bool> value);
        /*0x7315670*/ void add_OnSelectAll(UnityEngine.Events.UnityAction value);
        /*0x731570c*/ void remove_OnSelectAll(UnityEngine.Events.UnityAction value);
        /*0x73157a8*/ void add_OnDeselectAll(UnityEngine.Events.UnityAction value);
        /*0x7315844*/ void remove_OnDeselectAll(UnityEngine.Events.UnityAction value);
        /*0x73158e0*/ void add_OnDownload(UnityEngine.Events.UnityAction value);
        /*0x731597c*/ void remove_OnDownload(UnityEngine.Events.UnityAction value);
        /*0x7315a18*/ void add_OnSend(UnityEngine.Events.UnityAction value);
        /*0x7315ab4*/ void remove_OnSend(UnityEngine.Events.UnityAction value);
        /*0x7315b50*/ UnityEngine.Events.UnityAction<NoaDebugger.ILogDetail> get_OnCopy();
        /*0x7315b58*/ void set_OnCopy(UnityEngine.Events.UnityAction<NoaDebugger.ILogDetail> value);
        /*0x7315b60*/ void _OnValidateUI();
        /*0x7315b64*/ void _Init();
        /*0x7315f5c*/ void _OnInit();
        /*0x7315f60*/ void _OnUpdateDetail(NoaDebugger.ILogDetail detail);
        /*0x7315f64*/ void _OnShow(NoaDebugger.LogViewLinker linker);
        /*0x7316154*/ void _RefreshLogDetailView(bool isView);
        /*0x7316184*/ void AlignmentUI(bool isReverse);
        /*0x7316238*/ void _OnRecord(bool isOn);
        /*0x7316254*/ void _OnClear();
        /*0x7316270*/ void _OnSelection(bool isOn);
        /*0x73162bc*/ void _OnSearch(bool isOn);
        /*0x73162e4*/ void _OnSelectAll();
        /*0x7316308*/ void _OnDeselectAll();
        /*0x731632c*/ void _OnDownload();
        /*0x7316348*/ void _OnSend();
        /*0x7316364*/ void OnDestroy();
    }

    class LogViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ bool _forceUpdate;
        /*0x18*/ System.Collections.Generic.List<NoaDebugger.LogViewLinker.LogPanelInfo> _logs;
        /*0x20*/ string _logStatus;
        /*0x28*/ int _selectLogIndex;
        /*0x2c*/ bool _isCollecting;
        /*0x30*/ int _selectionCount;
        /*0x34*/ bool _isSelectingMode;
        /*0x38*/ NoaDebugger.LogViewLinker.LogTypeToggles _logTypeToggles;
        /*0x48*/ bool _resetScrollPos;
        /*0x49*/ bool _isViewLogDetail;
        /*0x50*/ string _filterText;
        /*0x58*/ bool _isValidSend;

        /*0x73164e4*/ LogViewLinker();

        struct LogTypeToggles
        {
            /*0x10*/ bool _messageToggle;
            /*0x11*/ bool _warningToggle;
            /*0x12*/ bool _errorToggle;
            /*0x14*/ int _messageNum;
            /*0x18*/ int _warningNum;
            /*0x1c*/ int _errorNum;
        }

        class LogPanelInfo
        {
            /*0x10*/ int <_index>k__BackingField;
            /*0x14*/ int <_viewIndex>k__BackingField;
            /*0x18*/ bool <_isSelect>k__BackingField;
            /*0x19*/ bool <_isPicOut>k__BackingField;
            /*0x1a*/ bool <_hasLoggedOnce>k__BackingField;
            /*0x20*/ string <_logString>k__BackingField;
            /*0x28*/ string <_stackTraceString>k__BackingField;
            /*0x30*/ NoaDebugger.ILogDetail <_logDetail>k__BackingField;
            /*0x38*/ NoaDebugger.LogType <_logType>k__BackingField;
            /*0x40*/ System.DateTime <_receivedTime>k__BackingField;
            /*0x48*/ UnityEngine.Events.UnityAction<int> _onClick;
            /*0x50*/ UnityEngine.Events.UnityAction<int> _onPointerDown;
            /*0x58*/ UnityEngine.Events.UnityAction _onLongTap;
            /*0x60*/ int <_numberOfMatchingLogs>k__BackingField;
            /*0x64*/ int <_serialNumber>k__BackingField;

            /*0x731664c*/ LogPanelInfo();
            /*0x73164ec*/ void set__index(int value);
            /*0x73164f4*/ int get__index();
            /*0x73164fc*/ void set__viewIndex(int value);
            /*0x7316504*/ int get__viewIndex();
            /*0x731650c*/ void set__isSelect(bool value);
            /*0x7316518*/ bool get__isSelect();
            /*0x7316520*/ void set__isPicOut(bool value);
            /*0x731652c*/ bool get__isPicOut();
            /*0x7316534*/ void set__hasLoggedOnce(bool value);
            /*0x7316540*/ bool get__hasLoggedOnce();
            /*0x7316548*/ void set__logString(string value);
            /*0x7316550*/ string get__logString();
            /*0x7316558*/ void set__stackTraceString(string value);
            /*0x7316560*/ string get__stackTraceString();
            /*0x7316568*/ void set__logDetail(NoaDebugger.ILogDetail value);
            /*0x7316570*/ NoaDebugger.ILogDetail get__logDetail();
            /*0x7316578*/ void set__logType(NoaDebugger.LogType value);
            /*0x7316580*/ NoaDebugger.LogType get__logType();
            /*0x7316588*/ void set__receivedTime(System.DateTime value);
            /*0x7316590*/ System.DateTime get__receivedTime();
            /*0x7316598*/ void set__numberOfMatchingLogs(int value);
            /*0x73165a0*/ int get__numberOfMatchingLogs();
            /*0x73165a8*/ void set__serialNumber(int value);
            /*0x73165b0*/ int get__serialNumber();
            /*0x73165b8*/ void UpdateLogData(string logString, string stackTrace, NoaDebugger.ILogDetail logDetail, NoaDebugger.LogType logType, System.DateTime receivedAt, int serialNumber);
            /*0x7316628*/ void UpdateViewData(int index, int viewIndex, bool isSelect, bool isPicOut, bool hasLoggedOnce, int numberOfMatchingLogs);
        }
    }

    class OverlayLogFontScaler : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.RectTransform _logType;
        /*0x28*/ UnityEngine.Vector2 _originalLogTypeSize;
        /*0x30*/ UnityEngine.RectTransform _logCounterTextRect;
        /*0x38*/ float _originalLogCounterTextWidth;
        /*0x40*/ UnityEngine.UI.HorizontalOrVerticalLayoutGroup _logLayout;
        /*0x48*/ float _paddingLeftFixedValue;
        /*0x50*/ TMPro.TextMeshProUGUI[] _targetTexts;
        /*0x58*/ System.Collections.Generic.Dictionary<TMPro.TextMeshProUGUI, float> _originalFontSizes;

        /*0x7316a40*/ OverlayLogFontScaler();
        /*0x7316654*/ void _OnValidateUI();
        /*0x7316658*/ void Awake();
        /*0x7316790*/ void ChangeFontScale(float fontScale);
        /*0x731699c*/ void OnDestroy();
    }

    class OverlayLogPanel : UnityEngine.MonoBehaviour
    {
        static float HIGHLIGHT_TIME = 1;
        static /*0x0*/ float _opacityRate;
        static /*0x4*/ UnityEngine.Color _defaultColor;
        /*0x20*/ UnityEngine.UI.Image _logBackground;
        /*0x28*/ UnityEngine.UI.Image _logType;
        /*0x30*/ TMPro.TextMeshProUGUI _logString;
        /*0x38*/ UnityEngine.GameObject _logCounterRoot;
        /*0x40*/ TMPro.TextMeshProUGUI _logCounter;
        /*0x48*/ NoaDebugger.OverlayLogFontScaler _fontScaler;
        /*0x50*/ UnityEngine.Color _highlightColor;
        /*0x60*/ NoaDebugger.LogPanelCommonDisplayProcessing _displayProcessing;
        /*0x68*/ NoaDebugger.LogViewLinker.LogPanelInfo _logInfo;
        /*0x70*/ int _logHashCode;
        /*0x78*/ System.Collections.IEnumerator _highlightCoroutine;
        /*0x80*/ UnityEngine.RectTransform _rectTransform;

        static /*0x7316e00*/ OverlayLogPanel();
        /*0x7316df8*/ OverlayLogPanel();
        /*0x7312594*/ UnityEngine.RectTransform get_RectTransform();
        /*0x7313a30*/ int get_LogIndex();
        /*0x7316ac8*/ void _OnValidateUI();
        /*0x7316acc*/ void OnDestroy();
        /*0x7316ba8*/ void Start();
        /*0x73133a4*/ void Draw(NoaDebugger.LogViewLinker.LogPanelInfo logInfo, bool isShowTimestamp);
        /*0x7316bac*/ void _RefreshLogString(NoaDebugger.LogViewLinker.LogPanelInfo logInfo, bool isShowTimestamp);
        /*0x731257c*/ void ChangeFontScale(float fontScale);
        /*0x73135dc*/ void ResetHashCode();
        /*0x7313380*/ bool Equal(NoaDebugger.LogViewLinker.LogPanelInfo logPanelInfo);
        /*0x7316d64*/ System.Collections.IEnumerator _HighlightTemporarily();
        /*0x7316cc0*/ void _ChangeLogBackgroundColor(UnityEngine.Color changeColor);

        class <_HighlightTemporarily>d__27 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.OverlayLogPanel <>4__this;
            /*0x28*/ float <startTime>5__2;
            /*0x2c*/ float <elapsedTime>5__3;

            /*0x7316dd0*/ <_HighlightTemporarily>d__27(int <>1__state);
            /*0x7316e4c*/ void System.IDisposable.Dispose();
            /*0x7316e50*/ bool MoveNext();
            /*0x7316f50*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x7316f58*/ void System.Collections.IEnumerator.Reset();
            /*0x7316f90*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    enum ButtonPosition
    {
        UpperLeft = 0,
        UpperCenter = 1,
        UpperRight = 2,
        MiddleLeft = 3,
        MiddleRight = 4,
        LowerLeft = 5,
        LowerCenter = 6,
        LowerRight = 7,
    }

    enum ButtonMovementType
    {
        Draggable = 0,
        Fixed = 1,
    }

    class NoaDebuggerButton : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ string DeviceOrientationKey;
        /*0x20*/ NoaDebugger.DragBehaviour _dragBehaviour;
        /*0x28*/ NoaDebugger.PointerEventComponent _bootButton;
        /*0x30*/ NoaDebugger.NoaDebuggerButtonVisualController _buttonVisualController;
        /*0x38*/ NoaDebugger.PointerEventComponent _visibleButton;
        /*0x40*/ NoaDebugger.NoaControllerView _controllerView;
        /*0x48*/ System.Action <OnShowController>k__BackingField;
        /*0x50*/ bool _isInitialized;
        /*0x54*/ NoaDebugger.NoaDebuggerButton.TapState _tapState;
        /*0x58*/ float _pressStartTime;
        /*0x5c*/ System.Nullable<UnityEngine.Vector2> _pressStartPos;
        /*0x68*/ bool _isShowNoaDebugger;
        /*0x70*/ NoaDebugger.NoaDebuggerSettings _noaDebuggerSettings;
        /*0x78*/ UnityEngine.RectTransform _rootRect;

        static /*0x73183d0*/ NoaDebuggerButton();
        /*0x73183c8*/ NoaDebuggerButton();
        /*0x7316f98*/ NoaDebugger.NoaControllerView get_ControllerView();
        /*0x7316fa0*/ System.Action get_OnShowController();
        /*0x7316fa8*/ void set_OnShowController(System.Action value);
        /*0x7316fb0*/ UnityEngine.RectTransform get_CachedRootRect();
        /*0x7317038*/ bool get_IsPlayingAnimation();
        /*0x7317054*/ void _OnValidateUI();
        /*0x7317058*/ void Init();
        /*0x7317224*/ void PlayOnLocationAnimation();
        /*0x73172e4*/ void PlayOnErrorAnimation();
        /*0x7317374*/ void ResetButtonColor();
        /*0x7317390*/ bool _IsAnimationBreak();
        /*0x73173a8*/ void _OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7317220*/ void _UpdateSettings();
        /*0x7317448*/ void _OnStartButtonSetActive(bool active);
        /*0x7317470*/ void Update();
        /*0x73174f4*/ void _UpdateButton();
        /*0x7317540*/ void _UpdateTapStateOnPressing(float pressingTime);
        /*0x7317708*/ void _UpdateButtonFromTapState(float pressingTime);
        /*0x7317808*/ void _UpdateButtonAlphaOnPressing(float pressingTime);
        /*0x7317530*/ void _Reset();
        /*0x7317ab0*/ void _SetActiveUI();
        /*0x7317ab8*/ void _LoadPosition(bool isPortrait);
        /*0x7317910*/ void _SavePosition(bool isPortrait);
        /*0x7317eec*/ UnityEngine.Vector3 _GetPositionPrefsData(bool isPortrait);
        /*0x7318020*/ UnityEngine.Vector3 _DeserializeVector3(string value);
        /*0x731825c*/ void OnRectTransformDimensionsChange();
        /*0x73180ec*/ bool _IsOutOfScreen(UnityEngine.Vector3 buttonPosition);
        /*0x7317b90*/ UnityEngine.Vector3 _SetupButtonPosition();
        /*0x73182d8*/ void Dispose();
        /*0x731843c*/ void <Init>b__25_0(UnityEngine.EventSystems.PointerEventData _);

        enum TapState
        {
            None = 0,
            Tap = 1,
            Drag = 2,
        }
    }

    class NoaDebuggerButtonInController : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.NoaDebuggerButtonVisualController _buttonVisualController;
        /*0x28*/ bool _isInitialized;

        /*0x73185d8*/ NoaDebuggerButtonInController();
        /*0x7318444*/ bool get_IsPlayingAnimation();
        /*0x7318460*/ void Init();
        /*0x7318498*/ void _OnValidateUI();
        /*0x731849c*/ void PlayOnErrorAnimation();
        /*0x731858c*/ void ResetButtonColor();
        /*0x73185a8*/ void Dispose();

        class <>c
        {
            static /*0x0*/ NoaDebugger.NoaDebuggerButtonInController.<> <>9;
            static /*0x8*/ System.Func<bool> <>9__6_0;

            static /*0x73185e0*/ <>c();
            /*0x7318648*/ <>c();
            /*0x7318650*/ bool <PlayOnErrorAnimation>b__6_0();
        }
    }

    class ControllerCustomActionButton : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.NoaController.CustomActionType <ActionType>k__BackingField;
        /*0x28*/ NoaDebugger.LongTapButton _longTapButton;
        /*0x30*/ NoaDebugger.ToggleButtonBase _toggleButton;
        /*0x38*/ System.Action _onTap;
        /*0x40*/ System.Action _onLongTap;
        /*0x48*/ System.Action<bool> _onToggle;

        /*0x7318a24*/ ControllerCustomActionButton();
        /*0x731866c*/ System.Action get_OnTap();
        /*0x7318674*/ void set_OnTap(System.Action value);
        /*0x73186cc*/ System.Action get_OnLongTap();
        /*0x73186d4*/ void set_OnLongTap(System.Action value);
        /*0x73186f0*/ System.Action<bool> get_OnToggle();
        /*0x73186f8*/ void set_OnToggle(System.Action<bool> value);
        /*0x7318740*/ bool get_IsToggleOn();
        /*0x731875c*/ void set_IsToggleOn(bool value);
        /*0x731877c*/ NoaDebugger.NoaController.CustomActionType get_ActionType();
        /*0x7318784*/ void set_ActionType(NoaDebugger.NoaController.CustomActionType value);
        /*0x731878c*/ void Awake();
        /*0x73188f8*/ void SetCustomActionType(NoaDebugger.NoaController.CustomActionType actionType);
        /*0x7318690*/ void _SetLongTapButtonInteractable();
        /*0x7318714*/ void _SetToggleButtonInteractable();
        /*0x7318a2c*/ void <Awake>b__21_0();
        /*0x7318a48*/ void <Awake>b__21_1();
        /*0x7318a64*/ void <Awake>b__21_2(bool isOn);
    }

    class NoaControllerView : UnityEngine.MonoBehaviour
    {
        /*0x20*/ System.Action OnShow;
        /*0x28*/ System.Action OnHide;
        /*0x30*/ System.Action<bool> OnTogglePauseResume;
        /*0x38*/ System.Action OnGameSpeedDecrement;
        /*0x40*/ System.Action OnGameSpeedMinimize;
        /*0x48*/ System.Action OnGameSpeedIncrement;
        /*0x50*/ System.Action OnGameSpeedMaximize;
        /*0x58*/ System.Action OnGameSpeedReset;
        /*0x60*/ System.Action OnFrameSteppingButtonEnabled;
        /*0x68*/ System.Action OnFrameStepping;
        /*0x70*/ System.Action OnResetApplication;
        /*0x78*/ System.Action OnHideNoaDebuggerUI;
        /*0x80*/ System.Action OnCaptureScreenshot;
        /*0x88*/ System.Action OnShowNoaDebugger;
        /*0x90*/ System.Action OnClose;
        /*0x98*/ UnityEngine.RectTransform _controllerViewTransform;
        /*0xa0*/ UnityEngine.RectTransform _noaDebuggerButtonTransform;
        /*0xa8*/ NoaDebugger.ControllerCustomActionButton[] _customActionButtons;
        /*0xb0*/ NoaDebugger.ToggleButtonBase _pauseResumeButton;
        /*0xb8*/ NoaDebugger.LongTapButton _gameSpeedDecrementButton;
        /*0xc0*/ NoaDebugger.DisableButtonBase _gameSpeedDecrementDisableButton;
        /*0xc8*/ NoaDebugger.LongTapButton _gameSpeedIncrementButton;
        /*0xd0*/ NoaDebugger.DisableButtonBase _gameSpeedIncrementDisableButton;
        /*0xd8*/ NoaDebugger.LongTapButton _gameSpeedResetButton;
        /*0xe0*/ TMPro.TextMeshProUGUI _gameSpeedText;
        /*0xe8*/ NoaDebugger.LongPressToggleColorButton _frameSteppingButton;
        /*0xf0*/ UnityEngine.UI.Button _closeButton;
        /*0xf8*/ NoaDebugger.LongTapButton _resetAppButton;
        /*0x100*/ UnityEngine.UI.Button _hideNoaDebuggerUIButton;
        /*0x108*/ UnityEngine.UI.Button _screenshotButton;
        /*0x110*/ UnityEngine.UI.Button _bootButton;
        /*0x118*/ UnityEngine.RectTransform[] _controllerOrderForLowerLeft;
        /*0x120*/ UnityEngine.RectTransform[] _controllerOrderForUpperLeft;
        /*0x128*/ UnityEngine.RectTransform[] _controllerOrderForUpperRight;
        /*0x130*/ UnityEngine.RectTransform[] _controllerOrderForLowerRight;
        /*0x138*/ UnityEngine.UI.Image[] _opacityTargetImages;

        /*0x731a98c*/ NoaControllerView();
        /*0x7318a84*/ void add_OnShow(System.Action value);
        /*0x7318b20*/ void remove_OnShow(System.Action value);
        /*0x7318bbc*/ void add_OnHide(System.Action value);
        /*0x7318c58*/ void remove_OnHide(System.Action value);
        /*0x7318cf4*/ void add_OnTogglePauseResume(System.Action<bool> value);
        /*0x7318da4*/ void remove_OnTogglePauseResume(System.Action<bool> value);
        /*0x7318e54*/ void add_OnGameSpeedDecrement(System.Action value);
        /*0x7318ef0*/ void remove_OnGameSpeedDecrement(System.Action value);
        /*0x7318f8c*/ void add_OnGameSpeedMinimize(System.Action value);
        /*0x7319028*/ void remove_OnGameSpeedMinimize(System.Action value);
        /*0x73190c4*/ void add_OnGameSpeedIncrement(System.Action value);
        /*0x7319160*/ void remove_OnGameSpeedIncrement(System.Action value);
        /*0x73191fc*/ void add_OnGameSpeedMaximize(System.Action value);
        /*0x7319298*/ void remove_OnGameSpeedMaximize(System.Action value);
        /*0x7319334*/ void add_OnGameSpeedReset(System.Action value);
        /*0x73193d0*/ void remove_OnGameSpeedReset(System.Action value);
        /*0x731946c*/ void add_OnFrameSteppingButtonEnabled(System.Action value);
        /*0x7319508*/ void remove_OnFrameSteppingButtonEnabled(System.Action value);
        /*0x73195a4*/ void add_OnFrameStepping(System.Action value);
        /*0x7319640*/ void remove_OnFrameStepping(System.Action value);
        /*0x73196dc*/ void add_OnResetApplication(System.Action value);
        /*0x7319778*/ void remove_OnResetApplication(System.Action value);
        /*0x7319814*/ void add_OnHideNoaDebuggerUI(System.Action value);
        /*0x73198b0*/ void remove_OnHideNoaDebuggerUI(System.Action value);
        /*0x731994c*/ void add_OnCaptureScreenshot(System.Action value);
        /*0x73199e8*/ void remove_OnCaptureScreenshot(System.Action value);
        /*0x7319a84*/ void add_OnShowNoaDebugger(System.Action value);
        /*0x7319b20*/ void remove_OnShowNoaDebugger(System.Action value);
        /*0x7319bbc*/ void add_OnClose(System.Action value);
        /*0x7319c58*/ void remove_OnClose(System.Action value);
        /*0x7319cf4*/ bool get_IsProcessFrameStepping();
        /*0x7319d10*/ void Awake();
        /*0x731a2f0*/ void OnEnable();
        /*0x731a564*/ void OnDisable();
        /*0x731a580*/ void SetCustomTapAction(int buttonIndex, System.Action action);
        /*0x731a5c8*/ void SetCustomLongPressAction(int buttonIndex, System.Action action);
        /*0x731a610*/ void SetCustomToggleAction(int buttonIndex, System.Action<bool> action);
        /*0x731a658*/ void SetCustomToggle(int buttonIndex, bool isOn);
        /*0x731a69c*/ bool GetCustomToggle(int buttonIndex);
        /*0x731a6dc*/ void SetCustomActionType(int buttonIndex, NoaDebugger.NoaController.CustomActionType actionType);
        /*0x731a714*/ void TogglePauseResume(bool isPlaying);
        /*0x731a734*/ void UpdateGameSpeed(float gameSpeed, float minGameSpeed, float maxGameSpeed);
        /*0x731a810*/ void SetResetAppButtonInteractable(bool interactable);
        /*0x731a830*/ void SetLongPressButtonActionIntervalSettings(NoaDebugger.LongPressButtonActionIntervalSettings setting);
        /*0x731a84c*/ void ReSetFrameSteppingButtonState();
        /*0x7319d30*/ void _ValidateFields();
        /*0x731a868*/ void _ValidateControllerOrder(System.Collections.Generic.IReadOnlyList<UnityEngine.RectTransform> order);
        /*0x7319d5c*/ void _ApplyNoaDebuggerSettings();
        /*0x731a918*/ void _SetImageOpacity(UnityEngine.UI.Image image);
        /*0x7319e30*/ void _InitializeCallbacks();
        /*0x731a320*/ void _ReorderButtons();
        /*0x731a994*/ void <_InitializeCallbacks>b__86_0(bool isPlaying);
        /*0x731a9b4*/ void <_InitializeCallbacks>b__86_1();
        /*0x731a9d0*/ void <_InitializeCallbacks>b__86_2();
        /*0x731a9ec*/ void <_InitializeCallbacks>b__86_3();
        /*0x731aa08*/ void <_InitializeCallbacks>b__86_4();
        /*0x731aa24*/ void <_InitializeCallbacks>b__86_5();
        /*0x731aa40*/ void <_InitializeCallbacks>b__86_6();
        /*0x731aa5c*/ void <_InitializeCallbacks>b__86_7();
        /*0x731aa78*/ void <_InitializeCallbacks>b__86_8();
        /*0x731aa94*/ void <_InitializeCallbacks>b__86_9();
        /*0x731aab0*/ void <_InitializeCallbacks>b__86_10();
        /*0x731aacc*/ void <_InitializeCallbacks>b__86_11();
        /*0x731aae8*/ void <_InitializeCallbacks>b__86_12();
        /*0x731ab04*/ void <_InitializeCallbacks>b__86_13();
    }

    class DragBehaviour : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler
    {
        /*0x20*/ UnityEngine.RectTransform _rect;
        /*0x28*/ UnityEngine.Vector2 _originalPivot;
        /*0x30*/ bool <CanMove>k__BackingField;
        /*0x31*/ bool <isDragging>k__BackingField;
        /*0x38*/ UnityEngine.Events.UnityAction<UnityEngine.Vector2> OnDragging;
        /*0x40*/ UnityEngine.Events.UnityAction<UnityEngine.Vector2> OnDragEnd;

        /*0x731b4a0*/ DragBehaviour();
        /*0x731ab20*/ bool get_CanMove();
        /*0x731ab28*/ void set_CanMove(bool value);
        /*0x731ab34*/ bool get_isDragging();
        /*0x731ab3c*/ void set_isDragging(bool value);
        /*0x731ab48*/ void add_OnDragging(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x731abf8*/ void remove_OnDragging(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x731aca8*/ void add_OnDragEnd(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x731ad58*/ void remove_OnDragEnd(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x731ae08*/ void Start();
        /*0x731aeb4*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731b26c*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731b370*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
    }

    class DragBehaviourFitWithInScreen : NoaDebugger.DragBehaviour
    {
        /*0x48*/ UnityEngine.RectTransform[] _fitWithInScreenRects;

        /*0x731b8a8*/ DragBehaviourFitWithInScreen();
        /*0x731b4a8*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731b664*/ UnityEngine.Vector3[] _GetOutermostPositions();
    }

    class FloatingWindowViewBase<T> : NoaDebugger.ViewBase<T>, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler
    {
        /*0x0*/ NoaDebugger.ToggleButtonBase _toggleButton;
        /*0x0*/ NoaDebugger.DragBehaviour _dragBehaviour;
        /*0x0*/ UnityEngine.UI.Button _closeButton;
        /*0x0*/ bool _isShowDefaultInfo;
        /*0x0*/ UnityEngine.GameObject _defaultInfo;
        /*0x0*/ UnityEngine.GameObject _smallInfo;
        /*0x0*/ UnityEngine.UI.Image[] _backgrounds;
        /*0x0*/ string <ToolName>k__BackingField;
        /*0x0*/ UnityEngine.Events.UnityAction<bool> OnToggleStateChange;
        /*0x0*/ UnityEngine.Events.UnityAction<UnityEngine.Vector2> OnDrag;
        /*0x0*/ UnityEngine.Events.UnityAction<UnityEngine.Vector2> OnDragEnd;
        /*0x0*/ UnityEngine.Events.UnityAction OnClose;

        /*0x380cb08*/ FloatingWindowViewBase();
        /*0x380b9e8*/ string get_ToolName();
        /*0x380d83c*/ void set_ToolName(string value);
        /*0x380d83c*/ void add_OnToggleStateChange(UnityEngine.Events.UnityAction<bool> value);
        /*0x380d83c*/ void remove_OnToggleStateChange(UnityEngine.Events.UnityAction<bool> value);
        /*0x380d83c*/ void add_OnDrag(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x380d83c*/ void remove_OnDrag(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x380d83c*/ void add_OnDragEnd(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x380d83c*/ void remove_OnDragEnd(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x380d83c*/ void add_OnClose(UnityEngine.Events.UnityAction value);
        /*0x380d83c*/ void remove_OnClose(UnityEngine.Events.UnityAction value);
        /*0x380cb08*/ void _OnValidateUI();
        /*0x380cb08*/ void _Init();
        /*0x380e304*/ void SetScreenPos(UnityEngine.Vector2 screenPos);
        /*0x380cdf0*/ void SetState(bool isShowDefault);
        /*0x380d83c*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x380d83c*/ void _SetBackgroundColor(UnityEngine.UI.Image target);
        /*0x380cb08*/ void _ChangeWindowOrder();
        /*0x380cdf0*/ void _OnToggleChange(bool isOn);
        /*0x380cb08*/ void _ChangeState();
        /*0x380e304*/ void _OnDrag(UnityEngine.Vector2 screenPos);
        /*0x380e304*/ void _OnDragEnd(UnityEngine.Vector2 screenPos);
        /*0x380cb08*/ void _Close();
    }

    class FloatingWindowInfo
    {
        /*0x10*/ string _playerPrefsKey;
        /*0x18*/ bool _isActiveValue;
        /*0x19*/ bool _isShowDefaultInfoVale;
        /*0x1c*/ UnityEngine.Vector2 _screenPositionPortraitValue;
        /*0x24*/ UnityEngine.Vector2 _screenPositionLandscapeValue;

        /*0x731b96c*/ FloatingWindowInfo(string prefsKey);
        /*0x731b8b0*/ bool get__isActive();
        /*0x731b8b8*/ void set__isActive(bool value);
        /*0x731b938*/ bool get__isShowDefaultInfo();
        /*0x731b940*/ void set__isShowDefaultInfo(bool value);
        /*0x731b94c*/ UnityEngine.Vector2 get_ScreenPositionPortrait();
        /*0x731b954*/ void set_ScreenPositionPortrait(UnityEngine.Vector2 value);
        /*0x731b95c*/ UnityEngine.Vector2 get_ScreenPositionLandscape();
        /*0x731b964*/ void set_ScreenPositionLandscape(UnityEngine.Vector2 value);
        /*0x731ba7c*/ void Reset();
        /*0x731b8c4*/ void _Save();
    }

    class MenuTabComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.UI.Button _tabButton;
        /*0x28*/ TMPro.TextMeshProUGUI _label;
        /*0x30*/ UnityEngine.GameObject _selectLine;
        /*0x38*/ UnityEngine.UI.Image _allow;
        /*0x40*/ UnityEngine.GameObject _badge;
        /*0x48*/ NoaDebugger.UIReverseComponents _reverseComponents;

        /*0x731bc48*/ MenuTabComponent();
        /*0x731bae0*/ void Awake();
        /*0x731bae4*/ void _OnValidateUI();
        /*0x731bae8*/ void ChangeTabSelect(bool isSelect);
        /*0x731bbac*/ void ShowNoticeBadge(NoaDebugger.ToolNotificationStatus notificationStatus);
        /*0x731bbd0*/ void OnDestroy();
        /*0x731bc28*/ void AlignmentUI(bool isReverse);
    }

    class NoaDebuggerView : NoaDebugger.ViewBase<NoaDebugger.NoaDebuggerViewLinker>
    {
        /*0x20*/ System.Action<int> ChangeToolListener;
        /*0x28*/ System.Action OnToolDetailButton;
        /*0x30*/ System.Action OnCloseButton;
        /*0x38*/ System.Action OnFloatingWindowPinButton;
        /*0x40*/ System.Action OnOverlayPinButton;
        /*0x48*/ System.Action OnOverlaySettingsButton;
        /*0x50*/ System.Action OnControllerButton;
        /*0x58*/ System.Action<bool> OnChangeButton;
        /*0x60*/ bool <RequiresRebuildSideMenu>k__BackingField;
        /*0x68*/ UnityEngine.Transform _content;
        /*0x70*/ UnityEngine.UI.Image _background;
        /*0x78*/ UnityEngine.UI.HorizontalLayoutGroup _sideMenuLayoutGroup;
        /*0x80*/ UnityEngine.UI.LayoutElement _contentLayoutElement;
        /*0x88*/ UnityEngine.UI.Button _toolDetailButton;
        /*0x90*/ UnityEngine.UI.Button _closeButton;
        /*0x98*/ NoaDebugger.ToggleButtonBase _floatingWindowPinButton;
        /*0xa0*/ UnityEngine.GameObject _overlayPinRoot;
        /*0xa8*/ NoaDebugger.ToggleButtonBase _overlayPinButton;
        /*0xb0*/ NoaDebugger.ToggleButtonBase _overlaySettingsButton;
        /*0xb8*/ UnityEngine.UI.Button _controllerButton;
        /*0xc0*/ NoaDebugger.ToggleColorButton _changeButton;
        /*0xc8*/ UnityEngine.UI.Button _sideMenuCloseButton;
        /*0xd0*/ TMPro.TextMeshProUGUI _toolName;
        /*0xd8*/ TMPro.TextMeshProUGUI _noaDebuggerVersion;
        /*0xe0*/ UnityEngine.GameObject _headerSelectLine;
        /*0xe8*/ UnityEngine.UI.ScrollRect _tabScroll;
        /*0xf0*/ NoaDebugger.MenuTabComponent _tabBase;
        /*0xf8*/ NoaDebugger.MenuTabComponent[] _tabs;
        /*0x100*/ bool _createdTabs;
        /*0x108*/ UnityEngine.RectTransform _rootContent;
        /*0x110*/ UnityEngine.RectTransform _sideMenu;
        /*0x118*/ UnityEngine.UI.Button _sideMenuShowButton;
        /*0x120*/ UnityEngine.UI.Button _sideMenuHideButton;
        /*0x128*/ UnityEngine.GameObject _sideMenuSpace;
        /*0x130*/ UnityEngine.UI.Image _menuViewHeader;
        /*0x138*/ UnityEngine.GameObject _menuViewHeaderLine;
        /*0x140*/ NoaDebugger.UIReverseComponents _reverseComponents;
        /*0x148*/ bool _isUIReversePortrait;
        /*0x150*/ NoaDebugger.NoaDebuggerSettings _settings;

        /*0x731e24c*/ NoaDebuggerView();
        /*0x731bc50*/ void add_ChangeToolListener(System.Action<int> value);
        /*0x731bd00*/ void remove_ChangeToolListener(System.Action<int> value);
        /*0x731bdb0*/ void add_OnToolDetailButton(System.Action value);
        /*0x731be4c*/ void remove_OnToolDetailButton(System.Action value);
        /*0x731bee8*/ void add_OnCloseButton(System.Action value);
        /*0x731bf84*/ void remove_OnCloseButton(System.Action value);
        /*0x731c020*/ void add_OnFloatingWindowPinButton(System.Action value);
        /*0x731c0bc*/ void remove_OnFloatingWindowPinButton(System.Action value);
        /*0x731c158*/ void add_OnOverlayPinButton(System.Action value);
        /*0x731c1f4*/ void remove_OnOverlayPinButton(System.Action value);
        /*0x731c290*/ void add_OnOverlaySettingsButton(System.Action value);
        /*0x731c32c*/ void remove_OnOverlaySettingsButton(System.Action value);
        /*0x731c3c8*/ void add_OnControllerButton(System.Action value);
        /*0x731c464*/ void remove_OnControllerButton(System.Action value);
        /*0x731c500*/ void add_OnChangeButton(System.Action<bool> value);
        /*0x731c5b0*/ void remove_OnChangeButton(System.Action<bool> value);
        /*0x731c660*/ bool get_RequiresRebuildSideMenu();
        /*0x731c668*/ void set_RequiresRebuildSideMenu(bool value);
        /*0x731c674*/ UnityEngine.Transform get_ContentRoot();
        /*0x731c67c*/ UnityEngine.Transform get_UIParent();
        /*0x731c698*/ void _Init();
        /*0x731ca30*/ void _OnStart();
        /*0x731cb7c*/ void _OnShow(NoaDebugger.NoaDebuggerViewLinker linker);
        /*0x731d528*/ void _AlignmentUI(bool isPortrait, NoaDebugger.INoaDebuggerTool target);
        /*0x731d804*/ void _ShowPinArea(NoaDebugger.INoaDebuggerTool target);
        /*0x731da10*/ void RefreshOverlayButtons(NoaDebugger.INoaDebuggerOverlayTool overlayTool);
        /*0x731d9a4*/ System.Collections.IEnumerator _SetScrollPosition();
        /*0x731d6cc*/ void UpdateMenu(NoaDebugger.NoaDebuggerViewLinker linker);
        /*0x731db6c*/ void _OnChangeTool(int index);
        /*0x731db88*/ void HideContents();
        /*0x731de64*/ void SetChangeButtonInteractable(bool interactable);
        /*0x731de84*/ void _DestroyAllMenuButton();
        /*0x731ce20*/ void CreateMenu(NoaDebugger.INoaDebuggerTool[] tools, bool forceCreate);
        /*0x731df88*/ void InitTabs();
        /*0x731d268*/ void _EnableSideMenuVerticalParts();
        /*0x731d424*/ void _DisableSideMenuVerticalParts();
        /*0x731d300*/ void _ShowSideMenu();
        /*0x731d3b0*/ void _HideSideMenu();
        /*0x731dfe8*/ void _OnHide();
        /*0x731e054*/ void OnDestroy();
        /*0x731e29c*/ void <_Init>b__62_0();
        /*0x731e2b8*/ void <_Init>b__62_1();
        /*0x731e2d4*/ void <_Init>b__62_2(bool isOn);
        /*0x731e2f0*/ void <_Init>b__62_3(bool isOn);
        /*0x731e30c*/ void <_Init>b__62_4(bool isOn);
        /*0x731e328*/ void <_Init>b__62_5();
        /*0x731e344*/ void <_Init>b__62_6(bool isOn);
        /*0x731e364*/ void <_Init>b__62_7();

        class <>c__DisplayClass74_0
        {
            /*0x10*/ int index;
            /*0x18*/ NoaDebugger.NoaDebuggerView <>4__this;

            /*0x731df80*/ <>c__DisplayClass74_0();
            /*0x731e380*/ void <CreateMenu>b__0();
        }

        class <_SetScrollPosition>d__68 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.NoaDebuggerView <>4__this;

            /*0x731db44*/ <_SetScrollPosition>d__68(int <>1__state);
            /*0x731e3b8*/ void System.IDisposable.Dispose();
            /*0x731e3bc*/ bool MoveNext();
            /*0x731e42c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x731e434*/ void System.Collections.IEnumerator.Reset();
            /*0x731e46c*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class NoaDebuggerViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ NoaDebugger.INoaDebuggerTool[] _targetTools;
        /*0x18*/ int _activeToolIndex;
        /*0x1c*/ bool _isCustom;
        /*0x1d*/ bool _isPortrait;
        /*0x1e*/ bool _isMenuActive;
        /*0x20*/ NoaDebugger.INoaDebuggerTool _forceTargetTool;

        /*0x731e474*/ NoaDebuggerViewLinker();
    }

    class OverlayBoolSettings : NoaDebugger.OverlaySettingsBase<bool>
    {
        /*0x731e47c*/ OverlayBoolSettings(bool defaultValue, bool isSaveEnabledAlways, System.Action save);
    }

    class OverlayEnumSettings : NoaDebugger.OverlaySettingsBase<System.Enum>
    {
        /*0x38*/ string _valueStr;
        /*0x40*/ System.Type _enumType;
        /*0x48*/ string[] _enumNames;
        /*0x50*/ System.Enum[] _enumValues;

        /*0x731e4ec*/ OverlayEnumSettings(System.Enum defaultValue, bool isSaveEnabledAlways, System.Action save);
        /*0x731e610*/ void ApplySavedSettings(NoaDebugger.OverlaySettingsBase<System.Enum> savedSettings);
        /*0x731e75c*/ void ResetSettings();
        /*0x731e7cc*/ void ChangeAndSaveValue(System.Enum value);
    }

    class OverlayFloatSettings : NoaDebugger.OverlayNumericSettingsBase<float>
    {
        /*0x34*/ int _needDigits;

        /*0x731e844*/ OverlayFloatSettings(float defaultValue, bool isSaveEnabledAlways, System.Action save, float inputRangeMin, float inputRangeMax, float increment);
        /*0x731e978*/ float FromString(string textValue);
        /*0x731ea48*/ bool IsEqualOrUnderMin(float value);
        /*0x731ea58*/ bool IsEqualOrOverMax(float value);
        /*0x731ea68*/ float ValidateValueForFluctuation(float value, int magnification);
        /*0x731eb08*/ float _ValidateValue(float value);
    }

    class OverlayIntSettings : NoaDebugger.OverlayNumericSettingsBase<int>
    {
        /*0x731ebe8*/ OverlayIntSettings(int defaultValue, bool isSaveEnabledAlways, System.Action save, int inputRangeMin, int inputRangeMax, int increment);
        /*0x731ec78*/ int FromString(string textValue);
        /*0x731ed3c*/ bool IsEqualOrUnderMin(int value);
        /*0x731ed4c*/ bool IsEqualOrOverMax(int value);
        /*0x731ed5c*/ int ValidateValueForFluctuation(int value, int magnification);
        /*0x731ed74*/ int _ValidateValue(int value);
    }

    class OverlayNumericSettingsBase<T> : NoaDebugger.OverlaySettingsBase<T>
    {
        /*0x0*/ T _inputRangeMin;
        /*0x0*/ T _inputRangeMax;
        /*0x0*/ T _increment;

        /*0x3907c14*/ OverlayNumericSettingsBase(T defaultValue, bool isSaveEnabledAlways, System.Action save, T inputRangeMin, T inputRangeMax, T increment);
        /*0x3907c14*/ T FromString(string textValue);
        /*0x3907c14*/ bool IsEqualOrUnderMin(T value);
        /*0x3907c14*/ bool IsEqualOrOverMax(T value);
        /*0x3907c14*/ T ValidateValueForFluctuation(T value, int magnification);
        /*0x3907c14*/ T _ValidateValue(T value);
        /*0x3907c14*/ void ChangeAndSaveValue(T value);
        /*0x380b2f0*/ bool IsNotNumeric(string text);
    }

    class OverlaySettingsBase<T>
    {
        /*0x0*/ T _value;
        /*0x0*/ bool _isSaved;
        /*0x0*/ T _defaultValue;
        /*0x0*/ bool _isSaveEnabledAlways;
        /*0x0*/ System.Action _save;

        /*0x3907c14*/ OverlaySettingsBase(T defaultValue, bool isSaveEnabledAlways, System.Action save);
        /*0x3907c14*/ T get_Value();
        /*0x380b128*/ bool get_IsSaved();
        /*0x380d83c*/ void ApplySavedSettings(NoaDebugger.OverlaySettingsBase<T> savedSettings);
        /*0x380cb08*/ void ResetSettings();
        /*0x3907c14*/ void ChangeAndSaveValue(T value);
    }

    class OverlayBoolSettingsPanel : NoaDebugger.OverlaySettingsPanelBase<bool>
    {
        /*0x30*/ NoaDebugger.ToggleButtonBase _toggleButton;
        /*0x38*/ UnityEngine.UI.Graphic _clickTarget;

        /*0x731f024*/ OverlayBoolSettingsPanel();
        /*0x731ee40*/ void Initialize(NoaDebugger.OverlaySettingsBase<bool> settings);
        /*0x731ef30*/ void Refresh();
        /*0x731ef84*/ void SetEnabled(bool isEnabled);
        /*0x731f000*/ void _OnToggleChange(bool isOn);
    }

    class OverlayEnumSettingsPanel : NoaDebugger.OverlaySettingsPanelBase<System.Enum>
    {
        /*0x30*/ TMPro.TMP_Dropdown _dropdown;
        /*0x38*/ NoaDebugger.OverlayEnumSettings _enumSettings;
        /*0x40*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> _optionDataList;

        /*0x731f420*/ OverlayEnumSettingsPanel();
        /*0x731f06c*/ void Initialize(NoaDebugger.OverlaySettingsBase<System.Enum> settings);
        /*0x731f124*/ void _InitializeUI();
        /*0x731f35c*/ void Refresh();
        /*0x731f3d8*/ void _OnChangeDropdown(int index);
    }

    class OverlayFloatSettingsPanel : NoaDebugger.OverlayNumericSettingsPanelBase<float>
    {
        /*0x731f468*/ OverlayFloatSettingsPanel();
    }

    class OverlayIntSettingsPanel : NoaDebugger.OverlayNumericSettingsPanelBase<int>
    {
        /*0x731f4b0*/ OverlayIntSettingsPanel();
    }

    class OverlayNumericSettingsPanelBase<T> : NoaDebugger.OverlaySettingsPanelBase<T>
    {
        /*0x0*/ NoaDebugger.DraggableNumericInputSlider _swipe;
        /*0x0*/ NoaDebugger.NoaDebuggerScrollableInputComponent _input;
        /*0x0*/ NoaDebugger.LongPressButton _leftArrowButton;
        /*0x0*/ NoaDebugger.LongPressButton _rightArrowButton;
        /*0x0*/ NoaDebugger.BlockableScrollRect _parentScroll;
        /*0x0*/ T _tmpValue;
        /*0x0*/ T _beginDragValue;
        /*0x0*/ NoaDebugger.OverlayNumericSettingsBase<T> _numericSettings;

        /*0x380cb08*/ OverlayNumericSettingsPanelBase();
        /*0x380d83c*/ void Initialize(NoaDebugger.OverlaySettingsBase<T> settings);
        /*0x380cb08*/ void _InitializeUI();
        /*0x380cb08*/ void Refresh();
        /*0x380d83c*/ void _OnEndInputEdit(string text);
        /*0x380cb08*/ void _OnBeginDrag();
        /*0x380e050*/ void _OnSliding(float distance);
        /*0x380cb08*/ void _OnDownArrowButton();
        /*0x380d83c*/ void _OnExitArrowButton(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x380cb08*/ void _OnClickLeftArrowButton();
        /*0x380cb08*/ void _DecrementValue();
        /*0x380cb08*/ void _OnClickRightArrowButton();
        /*0x380cb08*/ void _IncrementValue();
        /*0x3907c14*/ void _FluctuateValue(T beginValue, int count);
        /*0x380cb08*/ void _SetValue();
        int _DelimitDistance(float distance);
    }

    class OverlaySettingsPanelBase<T> : UnityEngine.MonoBehaviour
    {
        /*0x0*/ UnityEngine.GameObject _disableObject;
        /*0x0*/ NoaDebugger.OverlaySettingsBase<T> _settings;

        /*0x380cb08*/ OverlaySettingsPanelBase();
        /*0x380d83c*/ void Initialize(NoaDebugger.OverlaySettingsBase<T> settings);
        /*0x380cb08*/ void Refresh();
        /*0x380cdf0*/ void SetEnabled(bool isEnabled);
    }

    class OverlaySettingsViewBase<TOverlayToolSettings> : NoaDebugger.ViewBase<TOverlayToolSettings>
    {
        /*0x0*/ NoaDebugger.BlockableScrollRect _scroll;
        /*0x0*/ UnityEngine.UI.Button _resetButton;
        /*0x0*/ TOverlayToolSettings _overlayToolSettings;

        /*0x380cb08*/ OverlaySettingsViewBase();
        /*0x380cb08*/ void _Init();
        /*0x3907c14*/ void _OnShow(TOverlayToolSettings linker);
        /*0x380cb08*/ void _OnHide();
        /*0x380cdf0*/ void AlignmentUI(bool isReverse);
        /*0x380b9e8*/ System.Collections.IEnumerator _WaitSetScrollPosition();
        /*0x380cb08*/ void _OnResetButton();
        /*0x380cb08*/ void Refresh();

        class <_WaitSetScrollPosition>d__7<TOverlayToolSettings> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ NoaDebugger.OverlaySettingsViewBase<TOverlayToolSettings> <>4__this;

            /*0x380cffc*/ <_WaitSetScrollPosition>d__7(int <>1__state);
            /*0x380cb08*/ void System.IDisposable.Dispose();
            /*0x380b128*/ bool MoveNext();
            /*0x380b9e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x380cb08*/ void System.Collections.IEnumerator.Reset();
            /*0x380b9e8*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class OverlayToolSettingsBase : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ System.Action OnUpdateSettings;
        /*0x18*/ NoaDebugger.NoaDebuggerSettings _noaDebuggerSettings;
        /*0x20*/ string _playerPrefsKey;
        /*0x28*/ NoaDebugger.OverlayEnumSettings _position;

        /*0x731f910*/ OverlayToolSettingsBase();
        /*0x731f4f8*/ void add_OnUpdateSettings(System.Action value);
        /*0x731f594*/ void remove_OnUpdateSettings(System.Action value);
        /*0x380b6a0*/ NoaDebugger.NoaDebug.OverlayPosition get_DefaultPosition();
        /*0x731f630*/ NoaDebugger.OverlayEnumSettings get_Position();
        /*0x731f638*/ void Initialize(string prefsKey);
        /*0x731f758*/ void _InitializeSettings();
        /*0x380d83c*/ void _LoadSettings(string overlayPrefsJson);
        /*0x731f738*/ void Reset();
        /*0x731f8f0*/ void _ResetSettings();
        /*0x731f858*/ void _Save();
    }

    class OverlayViewBase<TOverlayToolSettings, TViewLinker> : NoaDebugger.ViewBase<NoaDebugger.OverlayViewLinker<TOverlayToolSettings, TViewLinker>>
    {
        /*0x0*/ UnityEngine.UI.Graphic[] _opacityChangeTargets;
        /*0x0*/ TOverlayToolSettings _settings;
        /*0x0*/ UnityEngine.RectTransform _rootRect;

        /*0x380cb08*/ OverlayViewBase();
        /*0x380cb08*/ void _OnValidateUI();
        /*0x380cb08*/ void _Init();
        /*0x380d83c*/ void _OnShow(NoaDebugger.OverlayViewLinker<TOverlayToolSettings, TViewLinker> linker);
        /*0x3907c14*/ void OnUpdateSettings(TOverlayToolSettings settings);
        /*0x3907c14*/ void OnUpdate(TViewLinker linker);
        /*0x380cffc*/ void _SetPosition(NoaDebugger.NoaDebug.OverlayPosition position);
    }

    class OverlayViewLinker<TOverlayToolSettings, TViewLinker> : NoaDebugger.ViewLinkerBase
    {
        /*0x0*/ TOverlayToolSettings <OverlayToolSettings>k__BackingField;
        /*0x0*/ TViewLinker <ViewLinker>k__BackingField;

        /*0x3907c14*/ OverlayViewLinker(TOverlayToolSettings overlayToolSettings, TViewLinker viewLinker);
        /*0x3907c14*/ TOverlayToolSettings get_OverlayToolSettings();
        /*0x3907c14*/ TViewLinker get_ViewLinker();
    }

    class NoaDebuggerToolViewBase<T> : NoaDebugger.ViewBase<T>
    {
        /*0x0*/ NoaDebugger.UIReverseComponents _reverseComponents;

        /*0x380cb08*/ NoaDebuggerToolViewBase();
        /*0x380cdf0*/ void AlignmentUI(bool isReverse);
    }

    class FpsOverlayView : NoaDebugger.ProfilerOverlayFeatureViewBase<System.ValueTuple<NoaDebugger.FpsUnchangingInfo, NoaDebugger.ProfilerFrameTimeViewInformation>, NoaDebugger.FrameTimeChartDrawerComponent>
    {
        /*0x58*/ UnityEngine.GameObject _simpleTextArea;
        /*0x60*/ TMPro.TextMeshProUGUI _simpleCurrentFpsText;
        /*0x68*/ UnityEngine.GameObject _fullTextArea;
        /*0x70*/ UnityEngine.UI.LayoutElement _fullTextAreaLayout;
        /*0x78*/ NoaDebugger.FpsOverlayView.FullTextArea _fullAverageFpsText;
        /*0x80*/ NoaDebugger.FpsOverlayView.FullTextArea _fullMaxFpsText;
        /*0x88*/ NoaDebugger.FpsOverlayView.FullTextArea _fullMinFpsText;
        /*0x90*/ NoaDebugger.FpsOverlayView.FullTextArea _fullCurrentFpsText;

        /*0x73202c4*/ FpsOverlayView();
        /*0x731f918*/ UnityEngine.Color get_TextColor();
        /*0x731f974*/ void OnInitialize();
        /*0x731f978*/ void UpdateView(System.ValueTuple<NoaDebugger.FpsUnchangingInfo, NoaDebugger.ProfilerFrameTimeViewInformation> data);
        /*0x731ff98*/ bool _IsShowGraph();
        /*0x7320060*/ void SetWidth(float width, bool isForce);
        /*0x731f9d4*/ void _UpdateText(NoaDebugger.FpsUnchangingInfo fpsInfo);
        /*0x731ff48*/ void _UpdateGraph(System.ValueTuple<NoaDebugger.FpsUnchangingInfo, NoaDebugger.ProfilerFrameTimeViewInformation> data);
        /*0x73201fc*/ void OnDestroy();

        class FullTextArea
        {
            /*0x10*/ TMPro.TextMeshProUGUI _text;
            /*0x18*/ UnityEngine.UI.LayoutElement _layout;

            /*0x732030c*/ FullTextArea();
            /*0x7320120*/ void SetText(string valueText);
        }
    }

    class MemoryOverlayView : NoaDebugger.ProfilerOverlayFeatureViewBase<NoaDebugger.MemoryUnchangingInfo, NoaDebugger.MemoryChartDrawerComponent>
    {
        /*0x58*/ TMPro.TextMeshProUGUI _memoryLabelsText;
        /*0x60*/ TMPro.TextMeshProUGUI _memoryValuesText;
        /*0x68*/ TMPro.TextMeshProUGUI _graphLabelText;

        /*0x7320fcc*/ MemoryOverlayView();
        /*0x7320314*/ UnityEngine.Color get_TextColor();
        /*0x7320370*/ void OnInitialize();
        /*0x7320374*/ void UpdateView(NoaDebugger.MemoryUnchangingInfo data);
        /*0x7320c88*/ bool _IsShowGraph();
        /*0x73203cc*/ void _UpdateText(NoaDebugger.MemoryUnchangingInfo data);
        /*0x7320ba0*/ void _UpdateGraph(NoaDebugger.MemoryUnchangingInfo data);
        /*0x7320e14*/ string _GetValueText(float value, NoaDebugger.MemoryUnchangingInfo data);
        /*0x7320f54*/ void OnDestroy();

        class <>c__DisplayClass8_0
        {
            /*0x10*/ NoaDebugger.MemoryOverlayView <>4__this;
            /*0x18*/ NoaDebugger.MemoryUnchangingInfo data;

            /*0x7320d50*/ <>c__DisplayClass8_0();
            /*0x7321014*/ string <_UpdateText>b__0(System.ValueTuple<string, float> x);
            /*0x732106c*/ string <_UpdateText>b__1(System.ValueTuple<string, float> x);
        }
    }

    class ProfilerOverlayFeatureViewBase<TData, TChartComponent> : UnityEngine.EventSystems.UIBehaviour
    {
        /*0x0*/ UnityEngine.GameObject _rootObject;
        /*0x0*/ TChartComponent _graph;
        /*0x0*/ UnityEngine.UI.LayoutElement _textAreaLayout;
        /*0x0*/ UnityEngine.UI.LayoutElement _graphLayout;
        /*0x0*/ UnityEngine.RectTransform _textAreaRect;
        /*0x0*/ string _textColorCode;
        /*0x0*/ NoaDebugger.NoaProfiler.OverlayTextType _textType;
        /*0x0*/ bool _isShowGraphOnOverlay;

        /*0x380cb08*/ ProfilerOverlayFeatureViewBase();
        /*0x380b4bc*/ UnityEngine.Color get_TextColor();
        /*0x380cb08*/ void Awake();
        /*0x380cb08*/ void OnRectTransformDimensionsChange();
        /*0x380cb08*/ void OnInitialize();
        /*0x3907c14*/ void ShowView(TData data, NoaDebugger.ProfilerOverlayFeatureSettings settings);
        /*0x3907c14*/ void UpdateView(TData data);
        /*0x380b128*/ bool _IsShowGraph();
        void SetWidth(float width, bool isForce);
        /*0x380cdf0*/ void _SetActive(bool isActive);
        /*0x380bb68*/ string _GetLabelText(string label);
        string _GetValueText(object value, bool isViewHyphen, bool isValid);
        /*0x380cb08*/ void OnDestroy();
    }

    class ProfilerOverlaySettingsGroupPanel : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.ToggleButtonBase _enableToggle;
        /*0x28*/ NoaDebugger.OverlayEnumSettingsPanel _textType;
        /*0x30*/ NoaDebugger.OverlayBoolSettingsPanel _graphToggle;
        /*0x38*/ NoaDebugger.ProfilerOverlayFeatureSettings _settingsCache;

        /*0x732131c*/ ProfilerOverlaySettingsGroupPanel();
        /*0x7321090*/ void Awake();
        /*0x732114c*/ void Initialize(NoaDebugger.ProfilerOverlayFeatureSettings settings);
        /*0x7321244*/ void Refresh();
        /*0x73211c4*/ void _DisplayEnableToggle();
        /*0x73212cc*/ void _OnEnableToggleChange(bool isOn);
        /*0x7321280*/ void _SetUIEnabled(bool isEnabled);
    }

    class ProfilerOverlayFeatureSettings
    {
        /*0x10*/ NoaDebugger.OverlayBoolSettings _isEnable;
        /*0x18*/ NoaDebugger.OverlayEnumSettings _textType;
        /*0x20*/ NoaDebugger.OverlayBoolSettings _isShowGraph;

        /*0x732133c*/ ProfilerOverlayFeatureSettings(System.Action save);
        /*0x7321324*/ NoaDebugger.OverlayBoolSettings get_IsEnable();
        /*0x732132c*/ NoaDebugger.OverlayEnumSettings get_TextType();
        /*0x7321334*/ NoaDebugger.OverlayBoolSettings get_IsShowGraph();
        /*0x73214b0*/ void ApplySavedSettings(NoaDebugger.ProfilerOverlayFeatureSettings savedSettings);
        /*0x7321534*/ void ResetSettings();
    }

    class ProfilerOverlaySettingsView : NoaDebugger.OverlaySettingsViewBase<NoaDebugger.ProfilerOverlaySettings>
    {
        /*0x38*/ NoaDebugger.ProfilerOverlaySettingsGroupPanel _fpsGroup;
        /*0x40*/ NoaDebugger.ProfilerOverlaySettingsGroupPanel _memoryGroup;
        /*0x48*/ NoaDebugger.ProfilerOverlaySettingsGroupPanel _renderingGroup;
        /*0x50*/ NoaDebugger.OverlayEnumSettingsPanel _position;
        /*0x58*/ NoaDebugger.OverlayFloatSettingsPanel _scale;
        /*0x60*/ NoaDebugger.OverlayEnumSettingsPanel _axis;

        /*0x7321714*/ ProfilerOverlaySettingsView();
        /*0x7321580*/ void _OnValidateUI();
        /*0x7321584*/ void _Init();
        /*0x73215cc*/ void _OnShow(NoaDebugger.ProfilerOverlaySettings linker);
        /*0x73216a4*/ void Refresh();
    }

    class ProfilerOverlaySettings : NoaDebugger.OverlayToolSettingsBase
    {
        /*0x30*/ NoaDebugger.ProfilerOverlayFeatureSettings _fpsSettings;
        /*0x38*/ NoaDebugger.ProfilerOverlayFeatureSettings _memorySettings;
        /*0x40*/ NoaDebugger.ProfilerOverlayFeatureSettings _renderingSettings;
        /*0x48*/ NoaDebugger.OverlayEnumSettings _axis;
        /*0x50*/ NoaDebugger.OverlayFloatSettings _scale;

        /*0x7321c14*/ ProfilerOverlaySettings();
        /*0x732175c*/ NoaDebugger.NoaDebug.OverlayPosition get_DefaultPosition();
        /*0x7321778*/ NoaDebugger.ProfilerOverlayFeatureSettings get_FpsSettings();
        /*0x7321780*/ NoaDebugger.ProfilerOverlayFeatureSettings get_MemorySettings();
        /*0x7321788*/ NoaDebugger.ProfilerOverlayFeatureSettings get_RenderingSettings();
        /*0x7321790*/ NoaDebugger.OverlayFloatSettings get_Scale();
        /*0x7321798*/ NoaDebugger.OverlayEnumSettings get_Axis();
        /*0x73217a0*/ void _InitializeSettings();
        /*0x7321a38*/ void _LoadSettings(string overlayPrefsJson);
        /*0x7321b6c*/ void _ResetSettings();
        /*0x7321bdc*/ NoaDebugger.ProfilerOverlayFeatureSettings GetFeatureSettings(NoaDebugger.NoaProfiler.FeatureType featureType);
    }

    class ProfilerOverlayView : NoaDebugger.OverlayViewBase<NoaDebugger.ProfilerOverlaySettings, NoaDebugger.ProfilerViewLinker>
    {
        /*0x38*/ NoaDebugger.FpsOverlayView _fpsView;
        /*0x40*/ NoaDebugger.MemoryOverlayView _memoryView;
        /*0x48*/ NoaDebugger.RenderingOverlayView _renderingView;
        /*0x50*/ NoaDebugger.AxisSwitchableLayoutGroup _layoutGroup;
        /*0x58*/ UnityEngine.UI.ContentSizeFitter _contentSizeFitter;
        /*0x60*/ UnityEngine.RectTransform _rect;
        /*0x68*/ System.Action OnEnabledAction;

        /*0x73224fc*/ ProfilerOverlayView();
        /*0x7321c1c*/ void add_OnEnabledAction(System.Action value);
        /*0x7321cb8*/ void remove_OnEnabledAction(System.Action value);
        /*0x7321d54*/ void _OnValidateUI();
        /*0x7321ddc*/ void _Init();
        /*0x7321e2c*/ void OnEnable();
        /*0x7321e60*/ System.Collections.IEnumerator OnEnableDelay();
        /*0x7321ef4*/ void OnUpdateSettings(NoaDebugger.ProfilerOverlaySettings settings);
        /*0x73221a4*/ void OnUpdate(NoaDebugger.ProfilerViewLinker linker);
        /*0x73222d8*/ void _SetPosition(NoaDebugger.NoaDebug.OverlayPosition position);
        /*0x7321fd0*/ void _ApplyAxis(NoaDebugger.NoaProfiler.OverlayAxis axis);
        /*0x7322180*/ void _ApplyScale(float scale);
        /*0x7322494*/ void OnDestroy();

        class <OnEnableDelay>d__12 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.ProfilerOverlayView <>4__this;

            /*0x7321ecc*/ <OnEnableDelay>d__12(int <>1__state);
            /*0x7322544*/ void System.IDisposable.Dispose();
            /*0x7322548*/ bool MoveNext();
            /*0x7322664*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x732266c*/ void System.Collections.IEnumerator.Reset();
            /*0x73226a4*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class RenderingOverlayView : NoaDebugger.ProfilerOverlayFeatureViewBase<NoaDebugger.RenderingUnchangingInfo, NoaDebugger.RenderingChartDrawerComponent>
    {
        /*0x58*/ TMPro.TextMeshProUGUI _renderingLabelsText;
        /*0x60*/ TMPro.TextMeshProUGUI _renderingValuesText;
        /*0x68*/ TMPro.TextMeshProUGUI _graphLabelText;

        /*0x73232b8*/ RenderingOverlayView();
        /*0x73226ac*/ UnityEngine.Color get_TextColor();
        /*0x7322708*/ void OnInitialize();
        /*0x732270c*/ void UpdateView(NoaDebugger.RenderingUnchangingInfo data);
        /*0x7322ea4*/ bool _IsShowGraph();
        /*0x7322764*/ void _UpdateText(NoaDebugger.RenderingUnchangingInfo data);
        /*0x7322d2c*/ void _UpdateGraph(NoaDebugger.RenderingUnchangingInfo data);
        /*0x7322f74*/ System.ValueTuple<string, long, string> _GetTextInfoFromRenderingGraphTarget(NoaDebugger.RenderingUnchangingInfo data, NoaDebugger.RenderingGraphTarget target);
        /*0x7323168*/ string _GetValueText(long currentValue, string maxValueStr, NoaDebugger.RenderingUnchangingInfo data);
        /*0x7323240*/ void OnDestroy();

        class <>c__DisplayClass8_0
        {
            /*0x10*/ NoaDebugger.RenderingOverlayView <>4__this;
            /*0x18*/ NoaDebugger.RenderingUnchangingInfo data;

            /*0x7322f6c*/ <>c__DisplayClass8_0();
            /*0x7323300*/ string <_UpdateText>b__0(System.ValueTuple<string, long, string> x);
            /*0x7323358*/ string <_UpdateText>b__1(System.ValueTuple<string, long, string> x);
        }
    }

    class BatteryTextDrawerComponent : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ string InProgressLabel;
        static /*0x8*/ string ChargingLabel;
        /*0x20*/ TMPro.TextMeshProUGUI _currentBatteryAndMinute;
        /*0x28*/ TMPro.TextMeshProUGUI _operatingTime;

        static /*0x73237a8*/ BatteryTextDrawerComponent();
        /*0x73237a0*/ BatteryTextDrawerComponent();
        /*0x732337c*/ void Awake();
        /*0x7323380*/ void OnShowBatteryText(NoaDebugger.BatteryUnchangingInfo info, System.Nullable<UnityEngine.Color> enableTextColor);
        /*0x7323778*/ void OnDestroy();
    }

    class ChartDrawerComponentBase : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.GameObject _rootObject;
        /*0x28*/ NoaDebugger.StackedAreaChart _chart;

        /*0x73238d4*/ ChartDrawerComponentBase();
        /*0x7323844*/ void Awake();
        /*0x380cb08*/ void OnInitialize();
        /*0x7323850*/ void SetActiveChart(bool isActive);
        /*0x73238ac*/ void OnDestroy();
    }

    class FpsGaugeDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.GaugeChart _fpsGauge;

        /*0x7323a0c*/ FpsGaugeDrawerComponent();
        /*0x73238dc*/ void Awake();
        /*0x73238e0*/ void OnShowFpsGauge(NoaDebugger.FpsUnchangingInfo info);
        /*0x7323a00*/ void OnDestroy();
    }

    class FpsTextDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _currentFps;
        /*0x28*/ TMPro.TextMeshProUGUI _maxAndMinAndAverageFps;
        /*0x30*/ TMPro.TextMeshProUGUI _refreshRate;

        /*0x7323db4*/ FpsTextDrawerComponent();
        /*0x7323a14*/ void Awake();
        /*0x7323a18*/ void OnShowFpsText(NoaDebugger.FpsUnchangingInfo info, System.Nullable<UnityEngine.Color> enableTextColor);
        /*0x7323d7c*/ void OnDestroy();
    }

    class FrameTimeChartDrawerComponent : NoaDebugger.ChartDrawerComponentBase
    {
        static /*0x0*/ float[] FrameTimeChartFpsRulerValues;
        static /*0x8*/ System.Collections.Generic.Dictionary<float, string> FrameTimeRulerStringCache;

        static /*0x7324268*/ FrameTimeChartDrawerComponent();
        static /*0x7323e74*/ void CreateFrameTimeRulerStringCache();
        static /*0x7324064*/ void OnUpdateFrameTimeChartRulers(float maxValue, float[] positions, string[] labels);
        static /*0x732404c*/ float FpsToFrameTimeMilliseconds(float fps);
        /*0x7324260*/ FrameTimeChartDrawerComponent();
        /*0x7323dbc*/ void OnInitialize();
        /*0x73201d8*/ void OnShowFrameTime(NoaDebugger.ProfilerFrameTimeViewInformation info);
    }

    class MemoryChartDrawerComponent : NoaDebugger.ChartDrawerComponentBase
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<float, string> MemoryRulerStringCache;
        /*0x30*/ System.Nullable<NoaDebugger.NoaProfiler.MemoryProfilingType> _cachedProfilingType;

        static /*0x73247c0*/ MemoryChartDrawerComponent();
        static /*0x7324530*/ void OnUpdateMemoryChartRulers(float maxValue, float[] positions, string[] labels);
        static /*0x7324644*/ string <OnUpdateMemoryChartRulers>g__toRulerText|5_0(float value);
        /*0x73247b8*/ MemoryChartDrawerComponent();
        /*0x7324360*/ void OnInitialize();
        /*0x7320d58*/ void OnShowMemoryChart(NoaDebugger.MemoryUnchangingInfo info);
        /*0x73243f0*/ void _SetStackDisplayAttributes(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
    }

    class MemoryGaugeDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.GaugeChart _memoryGauge;

        /*0x7324950*/ MemoryGaugeDrawerComponent();
        /*0x7324858*/ void Awake();
        /*0x732485c*/ void OnShowMemoryGauge(NoaDebugger.MemoryUnchangingInfo info);
        /*0x7324944*/ void OnDestroy();
    }

    class MemoryTextDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _memoryCapacityLabel;
        /*0x28*/ TMPro.TextMeshProUGUI _memoryCapacity;
        /*0x30*/ TMPro.TextMeshProUGUI _currentMemoryLabel;
        /*0x38*/ TMPro.TextMeshProUGUI _currentMemory;
        /*0x40*/ TMPro.TextMeshProUGUI _maxAndMinAndAverageMemory;

        /*0x732511c*/ MemoryTextDrawerComponent();
        /*0x7324958*/ void Awake();
        /*0x732495c*/ void OnShowMemoryText(NoaDebugger.MemoryUnchangingInfo info, System.Nullable<UnityEngine.Color> enableTextColor);
        /*0x7324c14*/ void _ShowUnityMemory(NoaDebugger.MemoryUnchangingInfo info);
        /*0x7324db4*/ void _ShowNativeMemory(NoaDebugger.MemoryUnchangingInfo info);
        /*0x7324f24*/ void _ShowMonoMemory(NoaDebugger.MemoryUnchangingInfo info);
        /*0x73250c4*/ void OnDestroy();
    }

    class RenderingChartDrawerComponent : NoaDebugger.ChartDrawerComponentBase
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<float, string> IntegerValueRulerStringCache;

        static /*0x7325480*/ RenderingChartDrawerComponent();
        static /*0x73251d8*/ void OnUpdateRenderingChartRulers(float maxValue, float[] positions, string[] labels);
        static /*0x7325348*/ string <OnUpdateRenderingChartRulers>g__toRulerText|3_0(float value);
        /*0x7325478*/ RenderingChartDrawerComponent();
        /*0x7325124*/ void OnInitialize();
        /*0x73251b4*/ void OnShowRenderingChart(NoaDebugger.RenderingUnchangingInfo info);
    }

    class RenderingTextDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _setPassCalls;
        /*0x28*/ TMPro.TextMeshProUGUI _drawCalls;
        /*0x30*/ TMPro.TextMeshProUGUI _batches;
        /*0x38*/ TMPro.TextMeshProUGUI _triangles;
        /*0x40*/ TMPro.TextMeshProUGUI _vertices;

        /*0x73259a4*/ RenderingTextDrawerComponent();
        /*0x7325518*/ void Awake();
        /*0x732551c*/ void OnShowRenderingText(NoaDebugger.RenderingUnchangingInfo info, System.Nullable<UnityEngine.Color> enableTextColor);
        /*0x732594c*/ void OnDestroy();
    }

    class ThermalTextDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _currentThermal;
        /*0x28*/ TMPro.TextMeshProUGUI _maxAndMinThermal;
        /*0x30*/ TMPro.TextMeshProUGUI _averageThermal;

        /*0x7325f2c*/ ThermalTextDrawerComponent();
        /*0x73259ac*/ void Awake();
        /*0x73259b0*/ void OnShowThermalText(NoaDebugger.ThermalUnchangingInfo info, System.Nullable<UnityEngine.Color> enableTextColor);
        /*0x7325ef4*/ void OnDestroy();
    }

    class ProfilerDrawerHelper
    {
        static /*0x0*/ string CurrentLabel;
        static /*0x8*/ string MaxLabel;
        static /*0x10*/ string MinLabel;
        static /*0x18*/ string AverageLabel;
        static /*0x20*/ string DefaultMemoryChartLabel;
        static /*0x28*/ string DefaultTotalMemoryLabel;
        static /*0x30*/ string ReservedLabel;
        static /*0x38*/ string MaxReservedLabel;
        static /*0x40*/ string AllocatedLabel;
        static /*0x48*/ string MonoHeapLabel;
        static /*0x50*/ string MaxMonoHeapLabel;
        static /*0x58*/ string MonoUsedLabel;
        static /*0x60*/ string SetPassCallsLabel;
        static /*0x68*/ string DrawCallsLabel;
        static /*0x70*/ string BatchesLabel;
        static /*0x78*/ string TrianglesLabel;
        static /*0x80*/ string VerticesLabel;
        static /*0x88*/ string FpsUnits;
        static /*0x90*/ string ElapsedTimeUnits;
        static /*0x98*/ string MemoryUsageUnits;
        static /*0xa0*/ string DegreesCelsiusUnits;

        static /*0x7326464*/ ProfilerDrawerHelper();
        static /*0x7325814*/ void ShowHyphenValue(TMPro.TextMeshProUGUI target);
        static /*0x7325d4c*/ void ShowMissingValue(TMPro.TextMeshProUGUI target);
        static /*0x7325f34*/ string GetFpsText(int value);
        static /*0x7325fdc*/ string GetElapsedTimeText(float value);
        static /*0x7326084*/ string GetTotalMemoryLabelText(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
        static /*0x7326178*/ string GetCurrentMemoryLabelText(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
        static /*0x7326250*/ string GetMemoryMBText(float value);
        static /*0x73258d0*/ string GetRenderingValueText(long current, string max);
        static /*0x7325e4c*/ string GetTemperatureText(float value);
        static /*0x7325df0*/ string GetMaxMinText(string max, string min);
        static /*0x73262f8*/ string GetMaxMinAvgText(string max, string min, string avg);
        static /*0x7326418*/ string GetMemoryProfilingTypeText(object profilingType);
        static /*0x7325308*/ float ToRulerValue(float value);
    }

    class ProfilerView : NoaDebugger.NoaDebuggerToolViewBase<NoaDebugger.ProfilerViewLinker>
    {
        /*0x28*/ NoaDebugger.ToggleButtonBase _fpsProfilingButton;
        /*0x30*/ NoaDebugger.FpsTextDrawerComponent _fpsTextComponent;
        /*0x38*/ NoaDebugger.FpsGaugeDrawerComponent _fpsGaugeComponent;
        /*0x40*/ TMPro.TMP_Dropdown _vSyncCountDropdown;
        /*0x48*/ TMPro.TMP_Dropdown _targetFrameRateDropdown;
        /*0x50*/ NoaDebugger.ToggleButtonBase _frameTimeProfilingButton;
        /*0x58*/ NoaDebugger.FrameTimeChartDrawerComponent _frameTimeChartComponent;
        /*0x60*/ NoaDebugger.ToggleButtonBase _memoryProfilingButton;
        /*0x68*/ NoaDebugger.ToggleButtonBase _memoryGraphButton;
        /*0x70*/ NoaDebugger.MemoryTextDrawerComponent _memoryTextComponent;
        /*0x78*/ NoaDebugger.MemoryChartDrawerComponent _memoryChartComponent;
        /*0x80*/ NoaDebugger.MemoryGaugeDrawerComponent _memoryGaugeComponent;
        /*0x88*/ UnityEngine.UI.Button _gcCollectButton;
        /*0x90*/ UnityEngine.UI.Button _unloadAssetButton;
        /*0x98*/ TMPro.TMP_Dropdown _memoryProfilingTypeDropdown;
        /*0xa0*/ NoaDebugger.ToggleButtonBase _renderingProfilingButton;
        /*0xa8*/ NoaDebugger.ToggleButtonBase _renderingGraphButton;
        /*0xb0*/ NoaDebugger.RenderingTextDrawerComponent _renderingTextComponent;
        /*0xb8*/ NoaDebugger.RenderingChartDrawerComponent _renderingChartComponent;
        /*0xc0*/ NoaDebugger.ToggleButtonGroup _renderingValueOptionGroup;
        /*0xc8*/ NoaDebugger.ToggleButtonBase _renderingValueOptionSetPassCalls;
        /*0xd0*/ NoaDebugger.ToggleButtonBase _renderingValueOptionDrawCalls;
        /*0xd8*/ NoaDebugger.ToggleButtonBase _renderingValueOptionBatches;
        /*0xe0*/ NoaDebugger.ToggleButtonBase _renderingValueOptionTriangles;
        /*0xe8*/ NoaDebugger.ToggleButtonBase _renderingValueOptionVertices;
        /*0xf0*/ UnityEngine.Events.UnityAction<bool> OnFpsProfilingStateChanged;
        /*0xf8*/ UnityEngine.Events.UnityAction<bool> OnFrameTimeProfilingStateChanged;
        /*0x100*/ UnityEngine.Events.UnityAction<int> OnVSyncCountChanged;
        /*0x108*/ UnityEngine.Events.UnityAction<int> OnTargetFrameRateChanged;
        /*0x110*/ UnityEngine.Events.UnityAction<bool> OnMemoryProfilingStateChanged;
        /*0x118*/ UnityEngine.Events.UnityAction<bool> OnMemoryGraphStateChanged;
        /*0x120*/ UnityEngine.Events.UnityAction<NoaDebugger.NoaProfiler.MemoryProfilingType> OnMemoryProfilingTypeChanged;
        /*0x128*/ UnityEngine.Events.UnityAction OnGcCollectExecuted;
        /*0x130*/ UnityEngine.Events.UnityAction OnUnloadAssetExecuted;
        /*0x138*/ UnityEngine.Events.UnityAction<bool> OnRenderingProfilingStateChanged;
        /*0x140*/ UnityEngine.Events.UnityAction<bool> OnRenderingGraphStateChanged;
        /*0x148*/ UnityEngine.Events.UnityAction<NoaDebugger.RenderingGraphTarget> OnRenderingGraphSelected;

        /*0x7328d28*/ ProfilerView();
        /*0x7326810*/ void add_OnFpsProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x73268c0*/ void remove_OnFpsProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x7326970*/ void add_OnFrameTimeProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x7326a20*/ void remove_OnFrameTimeProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x7326ad0*/ void add_OnVSyncCountChanged(UnityEngine.Events.UnityAction<int> value);
        /*0x7326b84*/ void remove_OnVSyncCountChanged(UnityEngine.Events.UnityAction<int> value);
        /*0x7326c38*/ void add_OnTargetFrameRateChanged(UnityEngine.Events.UnityAction<int> value);
        /*0x7326cec*/ void remove_OnTargetFrameRateChanged(UnityEngine.Events.UnityAction<int> value);
        /*0x7326da0*/ void add_OnMemoryProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x7326e54*/ void remove_OnMemoryProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x7326f08*/ void add_OnMemoryGraphStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x7326fbc*/ void remove_OnMemoryGraphStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x7327070*/ void add_OnMemoryProfilingTypeChanged(UnityEngine.Events.UnityAction<NoaDebugger.NoaProfiler.MemoryProfilingType> value);
        /*0x7327124*/ void remove_OnMemoryProfilingTypeChanged(UnityEngine.Events.UnityAction<NoaDebugger.NoaProfiler.MemoryProfilingType> value);
        /*0x73271d8*/ void add_OnGcCollectExecuted(UnityEngine.Events.UnityAction value);
        /*0x7327278*/ void remove_OnGcCollectExecuted(UnityEngine.Events.UnityAction value);
        /*0x7327318*/ void add_OnUnloadAssetExecuted(UnityEngine.Events.UnityAction value);
        /*0x73273b8*/ void remove_OnUnloadAssetExecuted(UnityEngine.Events.UnityAction value);
        /*0x7327458*/ void add_OnRenderingProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x732750c*/ void remove_OnRenderingProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x73275c0*/ void add_OnRenderingGraphStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x7327674*/ void remove_OnRenderingGraphStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x7327728*/ void add_OnRenderingGraphSelected(UnityEngine.Events.UnityAction<NoaDebugger.RenderingGraphTarget> value);
        /*0x73277dc*/ void remove_OnRenderingGraphSelected(UnityEngine.Events.UnityAction<NoaDebugger.RenderingGraphTarget> value);
        /*0x7327890*/ void _Init();
        /*0x7327894*/ void _OnStart();
        /*0x7328140*/ void _OnShow(NoaDebugger.ProfilerViewLinker linker);
        /*0x7328220*/ void _OnShowFps(NoaDebugger.FpsUnchangingInfo info);
        /*0x7328318*/ void _OnShowFrameTime(NoaDebugger.ProfilerFrameTimeViewInformation info);
        /*0x7328384*/ void _OnShowMemory(NoaDebugger.MemoryUnchangingInfo info);
        /*0x7328540*/ void _OnShowRendering(NoaDebugger.RenderingUnchangingInfo info);
        /*0x7328878*/ void _OnClickFpsProfiling(bool isOn);
        /*0x7328898*/ void _OnClickFrameTimeProfiling(bool isOn);
        /*0x73288b8*/ void _OnVSyncCountChangedChanged(int index);
        /*0x73288d4*/ void _OnTargetFrameRateChanged(int index);
        /*0x73288f0*/ void _OnClickMemoryProfiling(bool isOn);
        /*0x7328910*/ void _OnClickMemoryGraph(bool isOn);
        /*0x7328930*/ void _OnClickGcCollect();
        /*0x732894c*/ void _OnClickUnloadAsset();
        /*0x7328968*/ void _OnMemoryProfilingTypeChanged(int index);
        /*0x7328984*/ void _OnClickRenderProfiling(bool isOn);
        /*0x73289a4*/ void _OnClickRenderGraph(bool isOn);
        /*0x73289c4*/ void _OnClickRenderingCheckbox(bool isOn, NoaDebugger.RenderingGraphTarget target);
        /*0x73289ec*/ void _OnClickRenderingSetPassCalls(bool isOn);
        /*0x7328a10*/ void _OnClickRenderingDrawCalls(bool isOn);
        /*0x7328a34*/ void _OnClickRenderingBatches(bool isOn);
        /*0x7328a58*/ void _OnClickRenderingTriangles(bool isOn);
        /*0x7328a7c*/ void _OnClickRenderingVertices(bool isOn);
        /*0x73280b4*/ void _SetDropdown(string[] optionNames, TMPro.TMP_Dropdown target, UnityEngine.Events.UnityAction<int> onChanged, int defaultIndex);
        /*0x73286e4*/ void _SetDropdownOptions(string[] optionNames, TMPro.TMP_Dropdown target, int defaultIndex);
        /*0x7328aa0*/ void SetGcCollectButtonInteractable(bool interactable);
        /*0x7328ac0*/ void SetUnloadAssetButtonInteractable(bool interactable);
        /*0x7328ae0*/ void OnDestroy();
    }

    class ProfilerViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ NoaDebugger.FpsUnchangingInfo _fpsInfo;
        /*0x18*/ NoaDebugger.ProfilerFrameTimeViewInformation _frameTimeInfo;
        /*0x20*/ NoaDebugger.MemoryUnchangingInfo _memoryInfo;
        /*0x28*/ NoaDebugger.RenderingUnchangingInfo _renderingInfo;
        /*0x30*/ System.Nullable<int> _vSyncCountIndex;
        /*0x38*/ string[] _targetFrameRateChoices;
        /*0x40*/ int _defaultTargetFrameRateIndex;

        /*0x7328d70*/ ProfilerViewLinker();
    }

    class ProfilerFrameTimeViewInformation
    {
        /*0x10*/ NoaDebugger.RingBuffer<System.Single[]> _histories;
        /*0x18*/ bool _isEnabled;
        /*0x19*/ bool _isActive;

        /*0x7328d80*/ ProfilerFrameTimeViewInformation();
    }

    class CategoryKeyValue : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.NoaDebuggerText _key;
        /*0x28*/ NoaDebugger.NoaDebuggerText _value;

        /*0x7328ffc*/ CategoryKeyValue();
        /*0x7328d88*/ void Init(NoaDebugger.NoaSnapshotCategoryItem item);
        /*0x7328e1c*/ UnityEngine.Color _LogFontColorToColor(NoaDebugger.NoaSnapshot.FontColor color);
        /*0x7328fd4*/ void OnDestroy();
    }

    class SnapshotAdditionalInfoView : NoaDebugger.ViewBase<NoaDebugger.SnapshotAdditionalInfoViewLinker>
    {
        /*0x20*/ NoaDebugger.NoaDebuggerText _category;
        /*0x28*/ UnityEngine.GameObject _keyValueRoot;
        /*0x30*/ NoaDebugger.CategoryKeyValue _keyValuePrefab;

        /*0x7329318*/ SnapshotAdditionalInfoView();
        /*0x7329004*/ void _OnShow(NoaDebugger.SnapshotAdditionalInfoViewLinker linker);
        /*0x7329278*/ void _OnHide();
        /*0x73292e0*/ void OnDestroy();
    }

    class SnapshotAdditionalInfoViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ string _category;
        /*0x18*/ System.Collections.Generic.List<NoaDebugger.NoaSnapshotCategoryItem> _categoryItems;

        /*0x7329360*/ SnapshotAdditionalInfoViewLinker();
    }

    class SnapshotFpsTextDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _currentFps;
        /*0x28*/ TMPro.TextMeshProUGUI _maxAndMinFps;
        /*0x30*/ TMPro.TextMeshProUGUI _averageFps;

        /*0x7329658*/ SnapshotFpsTextDrawerComponent();
        /*0x7329368*/ void Awake();
        /*0x732936c*/ void OnShowFpsText(NoaDebugger.FpsUnchangingInfo info, System.Nullable<UnityEngine.Color> enableTextColor);
        /*0x7329620*/ void OnDestroy();
    }

    class SnapshotLogCellView : NoaDebugger.ViewBase<NoaDebugger.SnapshotLogCellViewLinker>
    {
        /*0x20*/ UnityEngine.GameObject _highlightedObject;
        /*0x28*/ NoaDebugger.LongTapButton _cellButton;
        /*0x30*/ NoaDebugger.InputTextAutoScroller _cellLabel;
        /*0x38*/ TMPro.TextMeshProUGUI _timeText;
        /*0x40*/ TMPro.TextMeshProUGUI _elapsedText;
        /*0x48*/ NoaDebugger.ToggleButtonBase _toggleButton;
        /*0x50*/ UnityEngine.UI.Image _backGround;
        /*0x58*/ UnityEngine.UI.Image _checkMark;
        /*0x60*/ NoaDebugger.SnapshotLogCellViewLinker _linker;

        /*0x7329dc0*/ SnapshotLogCellView();
        /*0x7329660*/ void _Init();
        /*0x7329998*/ void _OnShow(NoaDebugger.SnapshotLogCellViewLinker linker);
        /*0x7329cf4*/ void _OnClickCell();
        /*0x7329d1c*/ void _OnClickCellLabel(string text);
        /*0x7329d44*/ void _OnLongTapCell();
        /*0x7329d6c*/ void _OnUpdateLabel(string text);
        /*0x7329d98*/ void _OnToggleChange(bool isOn);
    }

    class SnapshotLogCellViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ int _id;
        /*0x14*/ int _viewIndex;
        /*0x18*/ string _label;
        /*0x20*/ System.TimeSpan _time;
        /*0x28*/ System.TimeSpan _elapsedTime;
        /*0x30*/ bool _isHighlighted;
        /*0x38*/ UnityEngine.Events.UnityAction<int> _onClickCell;
        /*0x40*/ UnityEngine.Events.UnityAction<int> _onLongTapCell;
        /*0x48*/ UnityEngine.Events.UnityAction<int, string> _onUpdateLabel;
        /*0x50*/ UnityEngine.Events.UnityAction<int> _onToggleChanged;
        /*0x58*/ NoaDebugger.SnapshotModel.ToggleState _toggleState;
        /*0x5c*/ System.Nullable<UnityEngine.Color> _backgroundColor;

        /*0x7329e08*/ SnapshotLogCellViewLinker();
    }

    class SnapshotLogDetailView : NoaDebugger.ViewBase<NoaDebugger.SnapshotViewLinker>
    {
        /*0x20*/ UnityEngine.GameObject _header;
        /*0x28*/ UnityEngine.UI.Image _icon;
        /*0x30*/ UnityEngine.Transform _drawersParent;
        /*0x38*/ NoaDebugger.SnapshotFpsTextDrawerComponent _fpsComponent;
        /*0x40*/ NoaDebugger.SnapshotMemoryTextDrawerComponent _memoryComponent;
        /*0x48*/ NoaDebugger.RenderingTextDrawerComponent _renderingComponent;
        /*0x50*/ NoaDebugger.BatteryTextDrawerComponent _batteryComponent;
        /*0x58*/ NoaDebugger.ThermalTextDrawerComponent _thermalComponent;
        /*0x60*/ NoaDebugger.NoaDebuggerText _label;
        /*0x68*/ NoaDebugger.SnapshotModel.ToggleState _toggleState;
        /*0x70*/ UnityEngine.UI.ScrollRect _profilingViewRoot;
        /*0x78*/ NoaDebugger.NoaDebuggerText _emptyText;
        /*0x80*/ NoaDebugger.SnapshotAdditionalInfoView _additionalInfoView;
        /*0x88*/ System.Collections.Generic.List<NoaDebugger.SnapshotAdditionalInfoView> _additionalInfoViewPrev;
        /*0x90*/ System.Collections.Generic.List<NoaDebugger.SnapshotAdditionalInfoView> _additionalInfoViewAfter;
        /*0x98*/ UnityEngine.UI.Button _copyButton;
        /*0xa0*/ UnityEngine.Events.UnityAction<int> <OnClickCopyButton>k__BackingField;
        /*0xa8*/ NoaDebugger.SnapshotLogRecordInformation _selectedLog;

        /*0x732adcc*/ SnapshotLogDetailView();
        /*0x7329e10*/ UnityEngine.Events.UnityAction<int> get_OnClickCopyButton();
        /*0x7329e18*/ void set_OnClickCopyButton(UnityEngine.Events.UnityAction<int> value);
        /*0x7329e20*/ void Awake();
        /*0x7329ec8*/ void _OnShow(NoaDebugger.SnapshotViewLinker linker);
        /*0x732a8ac*/ void _OnShowProfilingInfo(NoaDebugger.ProfilerSnapshotData snapshotData);
        /*0x732ac78*/ void OnDestroy();
        /*0x732ad70*/ void _OnCopy();

        class <>c__DisplayClass22_0
        {
            /*0x10*/ bool isComparison;
            /*0x18*/ NoaDebugger.SnapshotLogDetailView <>4__this;

            /*0x732a8a4*/ <>c__DisplayClass22_0();
            /*0x732ae14*/ bool <_OnShow>b__0(NoaDebugger.SnapshotLogRecordInformation logData);
        }
    }

    class SnapshotMemoryTextDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _memoryCapacityLabel;
        /*0x28*/ TMPro.TextMeshProUGUI _memoryCapacity;
        /*0x30*/ TMPro.TextMeshProUGUI _currentMemory;
        /*0x38*/ TMPro.TextMeshProUGUI _maxAndMinMemory;
        /*0x40*/ TMPro.TextMeshProUGUI _averageMemory;

        /*0x732b31c*/ SnapshotMemoryTextDrawerComponent();
        /*0x732ae60*/ void Awake();
        /*0x732a9d0*/ void OnShowMemoryText(NoaDebugger.MemoryUnchangingInfo info, System.Nullable<UnityEngine.Color> enableTextColor);
        /*0x732ae64*/ void _ShowUnityMemory(NoaDebugger.MemoryUnchangingInfo info);
        /*0x732afdc*/ void _ShowNativeMemory(NoaDebugger.MemoryUnchangingInfo info);
        /*0x732b14c*/ void _ShowMonoMemory(NoaDebugger.MemoryUnchangingInfo info);
        /*0x732b2c4*/ void OnDestroy();
    }

    class SnapshotView : NoaDebugger.NoaDebuggerToolViewBase<NoaDebugger.SnapshotViewLinker>
    {
        static int TOGGLE_SELECTABLE_MAX_COUNT = 2;
        /*0x28*/ NoaDebugger.DisableButtonBase _allClearButton;
        /*0x30*/ NoaDebugger.DisableButtonBase _downloadButton;
        /*0x38*/ TMPro.TextMeshProUGUI _elapsedTimeText;
        /*0x40*/ UnityEngine.UI.Button _takeButton;
        /*0x48*/ NoaDebugger.DisableButtonBase _comparisonButton;
        /*0x50*/ NoaDebugger.ObjectPoolScroll _scroll;
        /*0x58*/ UnityEngine.GameObject _scrollEmptyObject;
        /*0x60*/ UnityEngine.GameObject _logDetailsArea;
        /*0x68*/ UnityEngine.GameObject _dummy;
        /*0x70*/ NoaDebugger.SnapshotLogDetailView _logDetailA;
        /*0x78*/ NoaDebugger.SnapshotLogDetailView _logDetailB;
        /*0x80*/ int _currentListCount;
        /*0x88*/ System.Collections.Generic.List<NoaDebugger.SnapshotLogRecordInformation> _logDataList;
        /*0x90*/ UnityEngine.Events.UnityAction OnInsertLog;
        /*0x98*/ UnityEngine.Events.UnityAction<int> OnToggleChanged;
        /*0xa0*/ UnityEngine.Events.UnityAction OnClearAllLog;
        /*0xa8*/ UnityEngine.Events.UnityAction<int, string> OnUpdateLogLabel;
        /*0xb0*/ UnityEngine.Events.UnityAction<int> OnClickLog;
        /*0xb8*/ UnityEngine.Events.UnityAction<int> OnLongTapLog;
        /*0xc0*/ UnityEngine.Events.UnityAction OnDownloadLog;
        /*0xc8*/ UnityEngine.Events.UnityAction OnComparison;
        /*0xd0*/ UnityEngine.Events.UnityAction<int> OnClickCopyButton;

        /*0x732cb08*/ SnapshotView();
        /*0x732b324*/ void add_OnInsertLog(UnityEngine.Events.UnityAction value);
        /*0x732b3c0*/ void remove_OnInsertLog(UnityEngine.Events.UnityAction value);
        /*0x732b45c*/ void add_OnToggleChanged(UnityEngine.Events.UnityAction<int> value);
        /*0x732b50c*/ void remove_OnToggleChanged(UnityEngine.Events.UnityAction<int> value);
        /*0x732b5bc*/ void add_OnClearAllLog(UnityEngine.Events.UnityAction value);
        /*0x732b658*/ void remove_OnClearAllLog(UnityEngine.Events.UnityAction value);
        /*0x732b6f4*/ void add_OnUpdateLogLabel(UnityEngine.Events.UnityAction<int, string> value);
        /*0x732b7a4*/ void remove_OnUpdateLogLabel(UnityEngine.Events.UnityAction<int, string> value);
        /*0x732b854*/ void add_OnClickLog(UnityEngine.Events.UnityAction<int> value);
        /*0x732b904*/ void remove_OnClickLog(UnityEngine.Events.UnityAction<int> value);
        /*0x732b9b4*/ void add_OnLongTapLog(UnityEngine.Events.UnityAction<int> value);
        /*0x732ba64*/ void remove_OnLongTapLog(UnityEngine.Events.UnityAction<int> value);
        /*0x732bb14*/ void add_OnDownloadLog(UnityEngine.Events.UnityAction value);
        /*0x732bbb0*/ void remove_OnDownloadLog(UnityEngine.Events.UnityAction value);
        /*0x732bc4c*/ void add_OnComparison(UnityEngine.Events.UnityAction value);
        /*0x732bce8*/ void remove_OnComparison(UnityEngine.Events.UnityAction value);
        /*0x732bd84*/ void add_OnClickCopyButton(UnityEngine.Events.UnityAction<int> value);
        /*0x732be34*/ void remove_OnClickCopyButton(UnityEngine.Events.UnityAction<int> value);
        /*0x732bee4*/ void _Init();
        /*0x732c1a8*/ void _OnShow(NoaDebugger.SnapshotViewLinker linker);
        /*0x732c778*/ void ShowOnUpdate(NoaDebugger.SnapshotViewLinker linker);
        /*0x732c10c*/ void _RefreshLogDetailView(bool isView);
        /*0x732c5bc*/ void UpdateSnapshotDetail(NoaDebugger.SnapshotViewLinker linker, bool isComparison);
        /*0x732c830*/ void _OnClickAllClearButton();
        /*0x732c84c*/ void _OnClickDownloadButton();
        /*0x732c868*/ void _OnClickTakeButton();
        /*0x732c884*/ void _OnClickComparisonButton();
        /*0x732c8a0*/ void _RefreshPanel(int index, UnityEngine.GameObject target);
        /*0x732ca6c*/ NoaDebugger.SnapshotModel.ToggleState _ToggleState(NoaDebugger.SnapshotLogRecordInformation record);
        /*0x732c7f8*/ void _ShowByElapsedTime(System.TimeSpan elapsedTime);
        /*0x732c428*/ void _ShowByLogDataList(System.Collections.Generic.List<NoaDebugger.SnapshotLogRecordInformation> logDataList, bool isNeedResetScrollPos);
        /*0x732c670*/ bool _IsToggleSelectMax();

        class <>c
        {
            static /*0x0*/ NoaDebugger.SnapshotView.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.SnapshotLogRecordInformation, bool> <>9__42_0;
            static /*0x10*/ System.Func<NoaDebugger.SnapshotLogRecordInformation, bool> <>9__54_0;

            static /*0x732cb58*/ <>c();
            /*0x732cbc0*/ <>c();
            /*0x732cbc8*/ bool <_OnShow>b__42_0(NoaDebugger.SnapshotLogRecordInformation logData);
            /*0x732cbe0*/ bool <_IsToggleSelectMax>b__54_0(NoaDebugger.SnapshotLogRecordInformation log);
        }
    }

    class SnapshotViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ int _index;
        /*0x14*/ System.Nullable<bool> _isSpan;
        /*0x18*/ System.Nullable<System.TimeSpan> _elapsedTime;
        /*0x28*/ System.Collections.Generic.List<NoaDebugger.SnapshotLogRecordInformation> _logList;
        /*0x30*/ System.DateTime _captureTime;
        /*0x38*/ NoaDebugger.ProfilerSnapshotData _snapshot;
        /*0x40*/ UnityEngine.Vector2 _scrollPosition;
        /*0x48*/ bool _isNeedResetScrollPos;
        /*0x49*/ bool _isComparison;

        /*0x732cc04*/ SnapshotViewLinker();
    }

    class ToastView : NoaDebugger.ViewBase<NoaDebugger.ToastViewLinker>
    {
        /*0x20*/ TMPro.TextMeshProUGUI _label;
        /*0x28*/ UnityEngine.Animator _animator;
        /*0x30*/ UnityEngine.CanvasGroup _canvasGroup;
        /*0x38*/ bool _playAnim;

        /*0x732cebc*/ ToastView();
        /*0x732cc20*/ void SetVisibility(bool visible);
        /*0x732cc70*/ void _Init();
        /*0x732ccc8*/ void _OnShow(NoaDebugger.ToastViewLinker linker);
        /*0x732cd70*/ void _OnHide();
        /*0x732cdfc*/ void Update();
    }

    class ToastViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ string _label;

        /*0x732cf04*/ ToastViewLinker();
    }

    class SaveDataContent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.Transform _keyRoot;
        /*0x28*/ NoaDebugger.SaveDataKeyPanel _keyPanel;
        /*0x30*/ UnityEngine.UI.Button _allClearButton;
        /*0x38*/ System.Collections.Generic.List<NoaDebugger.SaveDataKeyPanel> _keyPanels;

        /*0x732d964*/ SaveDataContent();
        /*0x732cf0c*/ void _OnValidate();
        /*0x732cf10*/ void Show(string[] targetKeys);
        /*0x732d4b4*/ void _RemoveAt(NoaDebugger.SaveDataKeyPanel panel);
        /*0x732d6cc*/ void _RemoveAllKeys();
        /*0x732d630*/ void _RefreshPanels();
        /*0x732d154*/ void _DestroyPanels();
        /*0x732d91c*/ void OnDestroy();
    }

    class SaveDataKeyPanel : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _keyLabel;
        /*0x28*/ NoaDebugger.LongTapButton _removeButton;
        /*0x30*/ UnityEngine.GameObject _background;
        /*0x38*/ string <Key>k__BackingField;
        /*0x40*/ System.Action<NoaDebugger.SaveDataKeyPanel> OnRemove;

        /*0x732db28*/ SaveDataKeyPanel();
        /*0x732d9ec*/ void set_Key(string value);
        /*0x732d9f4*/ string get_Key();
        /*0x732d308*/ void add_OnRemove(System.Action<NoaDebugger.SaveDataKeyPanel> value);
        /*0x732d9fc*/ void remove_OnRemove(System.Action<NoaDebugger.SaveDataKeyPanel> value);
        /*0x732daac*/ void _OnValidate();
        /*0x732d3b8*/ void Show(string key, bool isShowBackground);
        /*0x732d8fc*/ void Refresh(bool isShowBackground);
        /*0x732dab0*/ void _OnRemoveLongTap();
        /*0x732dad0*/ void OnDestroy();
    }

    class ToolDetailView : NoaDebugger.NoaDebuggerToolViewBase<NoaDebugger.ToolDetailViewLinker>
    {
        /*0x28*/ NoaDebugger.TextAutoScroller _operatingEnv;
        /*0x30*/ UnityEngine.GameObject _shortcutPanelRootContent;
        /*0x38*/ NoaDebugger.ContextPanelView _shortcutPanelView;
        /*0x40*/ TMPro.TextMeshProUGUI _copyright;
        /*0x48*/ NoaDebugger.SaveDataContent _noaPrefsSaveData;
        /*0x50*/ NoaDebugger.SaveDataContent _debugCommandPropertySaveData;
        /*0x58*/ NoaDebugger.SaveDataContent _toolSaveData;

        /*0x732dee8*/ ToolDetailView();
        /*0x732db30*/ void _OnShow(NoaDebugger.ToolDetailViewLinker linker);
        /*0x732dc58*/ void _ShowNoaPrefsSaveDataContent();
        /*0x732dd1c*/ void _ShowDebugCommandPropertySaveDataContent();
        /*0x732dde0*/ void _ShowToolSaveDataContent();
        /*0x732de6c*/ void _OnHide();
        /*0x732de90*/ void OnDestroy();
    }

    class ToolDetailViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ string _operatingEnv;
        /*0x18*/ System.Collections.Generic.Dictionary<string, string> _shortcutKeyMappings;
        /*0x20*/ string _copyright;

        /*0x732df30*/ ToolDetailViewLinker();
    }

    class ViewBase<T> : UnityEngine.MonoBehaviour
    {
        static string DESTROY_TARGET_VIEW = "FloatingWindow";

        /*0x380cb08*/ ViewBase();
        /*0x380cb08*/ void Awake();
        /*0x380cb08*/ void Start();
        /*0x380cb08*/ void _Init();
        /*0x380cb08*/ void _OnStart();
        /*0x3907c14*/ void Show(T linker);
        /*0x3907c14*/ void _OnShow(T linker);
        /*0x380cb08*/ void Hide();
        /*0x380cb08*/ void _OnHide();
        /*0x380d83c*/ void _CaughtThrow(System.Exception e);
    }

    class ViewLinkerBase
    {
        /*0x7328d78*/ ViewLinkerBase();
    }

    namespace DebugCommand
    {
        class DebugCommandModel
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommand.DebugCommandModel.CommandCategory> _categories;
            /*0x18*/ bool _shouldRefreshFirst;
            /*0x20*/ UnityEngine.Events.UnityAction OnAutoRefresh;
            /*0x28*/ UnityEngine.Events.UnityAction<bool> OnAutoRefreshStateChanged;
            /*0x30*/ NoaDebugger.AutoRefreshSwitcher _autoRefreshSwitcher;

            static /*0x7331a10*/ NoaDebugger.DebugCommand.DebugCommandModel.CommandCategory _CreateCommandCategory(System.Collections.Generic.IEnumerable<NoaDebugger.DebugCommand.ICommand> commands, string displayName, object instance);
            /*0x732e0e0*/ DebugCommandModel();
            /*0x732df38*/ string[] get_CategoryNames();
            /*0x732dfa4*/ string[] get_CategoryDisplayNames();
            /*0x732e0c4*/ bool get_IsAutoRefresh();
            /*0x732e2cc*/ void Dispose();
            /*0x732e3a0*/ void _OnAddCategory();
            /*0x732f518*/ System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommand.CommandGroupData> GetGroupsForCategory(string categoryName);
            /*0x732f5dc*/ object GetInstance(string categoryName);
            /*0x732f660*/ void RefreshCategoryFirst();
            /*0x732f68c*/ void SetInteractable(string categoryName, string commandTag, bool isInteractable);
            /*0x732f984*/ bool IsInteractable(string categoryName, string commandTag);
            /*0x732fad0*/ void SetVisible(string categoryName, string commandTag, bool isVisible);
            /*0x732fdc8*/ bool IsVisible(string categoryName, string commandTag);
            /*0x732ff14*/ void UpdateAutoRefresh(bool isAutoRefresh);
            /*0x732ff6c*/ void _OnUpdate();
            /*0x732e3b8*/ void _AddMemberInfoCommands();
            /*0x732ee50*/ void _AddDynamicCommands();

            class CommandCategory
            {
                /*0x10*/ string _displayName;
                /*0x18*/ System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommand.CommandGroupData> _groupedCommands;
                /*0x20*/ System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommand.CommandGroupData> _taggedCommands;
                /*0x28*/ System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommand.DebugCommandModel.TaggedCommandState> _taggedCommandStates;
                /*0x30*/ object _categoryInstance;

                /*0x73326cc*/ CommandCategory();
            }

            class TaggedCommandState
            {
                /*0x10*/ bool <IsInteractable>k__BackingField;
                /*0x11*/ bool <IsVisible>k__BackingField;

                /*0x73327d4*/ TaggedCommandState();
                /*0x73327e4*/ bool get_IsInteractable();
                /*0x73327ec*/ void set_IsInteractable(bool value);
                /*0x73327f8*/ bool get_IsVisible();
                /*0x7332800*/ void set_IsVisible(bool value);
            }

            class <>c
            {
                static /*0x0*/ NoaDebugger.DebugCommand.DebugCommandModel.<> <>9;
                static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommand.DebugCommandModel.CommandCategory>, string> <>9__7_0;
                static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommand.DebugCommandModel.CommandCategory>, string> <>9__25_0;
                static /*0x18*/ System.Func<System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommand.DebugCommandModel.CommandCategory>, NoaDebugger.DebugCommand.DebugCommandModel.CommandCategory> <>9__25_1;
                static /*0x20*/ System.Func<System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommandRegister.DebugCategory>, int> <>9__25_2;
                static /*0x28*/ System.Func<NoaDebugger.CommandDefinition, NoaDebugger.DebugCommand.ICommand> <>9__26_0;
                static /*0x30*/ System.Func<NoaDebugger.DebugCommand.ICommand, bool> <>9__26_1;
                static /*0x38*/ System.Func<NoaDebugger.DebugCommand.ICommand, int> <>9__27_0;

                static /*0x733280c*/ <>c();
                /*0x7332874*/ <>c();
                /*0x733287c*/ string <get_CategoryDisplayNames>b__7_0(System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommand.DebugCommandModel.CommandCategory> x);
                /*0x73328c0*/ string <_AddMemberInfoCommands>b__25_0(System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommand.DebugCommandModel.CommandCategory> entry);
                /*0x73328fc*/ NoaDebugger.DebugCommand.DebugCommandModel.CommandCategory <_AddMemberInfoCommands>b__25_1(System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommand.DebugCommandModel.CommandCategory> entry);
                /*0x7332938*/ int <_AddMemberInfoCommands>b__25_2(System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommandRegister.DebugCategory> category);
                /*0x7332974*/ NoaDebugger.DebugCommand.ICommand <_AddDynamicCommands>b__26_0(NoaDebugger.CommandDefinition commandDefinition);
                /*0x7332998*/ bool <_AddDynamicCommands>b__26_1(NoaDebugger.DebugCommand.ICommand command);
                /*0x73329a4*/ int <_CreateCommandCategory>b__27_0(NoaDebugger.DebugCommand.ICommand command);
            }
        }

        class CommandGroupData
        {
            /*0x10*/ bool _isCollapsed;
            /*0x14*/ System.Nullable<int> _order;
            /*0x20*/ System.Collections.Generic.List<NoaDebugger.DebugCommand.ICommand> _commandList;

            /*0x73327cc*/ CommandGroupData();
        }

        enum CommandDisplayFormat
        {
            Panel = 0,
            List = 1,
        }

        class DebugCommandPresenter : NoaDebugger.NoaDebuggerToolBase, NoaDebugger.INoaDebuggerTool, NoaDebugger.INoaDebuggerFloatingTool
        {
            static /*0x0*/ string DebugCommandPresenterUpdate;
            static /*0x8*/ NoaDebugger.DebugCommand.DebugCommandPresenter _instance;
            static /*0x10*/ NoaDebugger.DebugCommand.CommandDisplayFormat _landscapeFormat;
            static /*0x14*/ NoaDebugger.DebugCommand.CommandDisplayFormat _portraitFormat;
            static /*0x18*/ System.Action OnRefreshProperty;
            /*0x20*/ System.Collections.Generic.Dictionary<string, System.String[]> _floatingRemoveGroups;
            /*0x28*/ NoaDebugger.DebugCommand.DebugCommandView _mainViewPrefab;
            /*0x30*/ NoaDebugger.DebugCommand.DebugCommandView _mainView;
            /*0x38*/ NoaDebugger.DebugCommand.DebugCommandFloatingWindowView _landscapeFloatingWindowPrefab;
            /*0x40*/ NoaDebugger.DebugCommand.DebugCommandFloatingWindowView _portraitFloatingWindowPrefab;
            /*0x48*/ NoaDebugger.FloatingWindowPresenter<NoaDebugger.DebugCommand.DebugCommandFloatingWindowView, NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker> _floatingWindowPresenter;
            /*0x50*/ NoaDebugger.DebugCommand.DebugCommandModel _model;
            /*0x58*/ int _selectCategoryIndex;
            /*0x5c*/ bool _isDetailMode;
            /*0x60*/ string _selectedGroupForDetail;
            /*0x68*/ string _selectedCommandForDetail;
            /*0x70*/ NoaDebugger.DebugCommand.ICommand[] _selectedCommands;
            /*0x78*/ NoaDebugger.DebugCommand.DebugCommandPresenter.CommandMenuInfo _commandMenuInfo;

            static /*0x7336660*/ DebugCommandPresenter();
            static /*0x7332a4c*/ bool get_IsAutoRefresh();
            static /*0x7332b4c*/ void set_IsAutoRefresh(bool value);
            static /*0x7332d28*/ void add_OnRefreshProperty(System.Action value);
            static /*0x7332e04*/ void remove_OnRefreshProperty(System.Action value);
            static /*0x7335bd4*/ void RefreshView();
            static /*0x7335d08*/ void RefreshProperty();
            static /*0x7335fc8*/ object GetCategoryInstance(string categoryName);
            static /*0x7336038*/ string[] GetCategoryNames();
            static /*0x7336108*/ string[] GetDisplayCategoryNames();
            static /*0x73361d8*/ System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommand.CommandGroupData> GetCategoryGroup(string categoryName);
            static /*0x73362b0*/ void SetCommandInteractable(string categoryName, string commandTag, bool isInteractable);
            static /*0x7336338*/ bool IsCommandInteractable(string categoryName, string commandTag);
            static /*0x73363b8*/ void SetCommandVisible(string categoryName, string commandTag, bool isVisible);
            static /*0x7336440*/ bool IsCommandVisible(string categoryName, string commandTag);
            static /*0x73364c0*/ NoaDebugger.DebugCommand.CommandDisplayFormat GetCurrentFormat();
            /*0x73365d0*/ DebugCommandPresenter();
            /*0x7332a44*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
            /*0x7332ee0*/ void Init();
            /*0x7333354*/ NoaDebugger.IMenuInfo MenuInfo();
            /*0x73333cc*/ void ShowView(UnityEngine.Transform parent);
            /*0x73334c8*/ void _InitView(NoaDebugger.DebugCommand.DebugCommandView view);
            /*0x7333690*/ void _HiddenView();
            /*0x7333724*/ void _RefreshViewOnUpdate();
            /*0x7332c60*/ void _UpdateView(NoaDebugger.DebugCommand.CommandViewUpdateTarget updateTarget, bool isUpdateMainView);
            /*0x73338b0*/ void _UpdateMainView(string category, NoaDebugger.DebugCommand.CommandViewUpdateTarget updateTarget);
            /*0x7333a78*/ void _UpdateFloatingWindow(string category, NoaDebugger.DebugCommand.CommandViewUpdateTarget updateTarget);
            /*0x7333794*/ int _GetCategoryIndex();
            /*0x7333eb8*/ NoaDebugger.DebugCommand.GroupPanelInfo[] _CreateGroups(string category, System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommand.CommandGroupData> groupDic);
            /*0x73346e8*/ void _OnSelectCategory(int index);
            /*0x7334814*/ void _OnRefreshView(bool isAutoRefresh);
            /*0x73348c0*/ void _OnAutoRefreshView();
            /*0x7334894*/ void _OnUpdateAutoRefreshState();
            /*0x7334910*/ void _OnAutoRefreshStateChanged(bool isAutoRefresh);
            /*0x7334a50*/ void _OnSelectGroupForCollapse(string group, bool isOn);
            /*0x7334b08*/ void _OnSelectGroupForFloatingWindow(string group, bool isOn);
            /*0x7335150*/ void _OnSelectAllGroupForFloatingWindow(bool isOn);
            /*0x7335368*/ void _OnDisplayDetailsToggle(bool isOn);
            /*0x733537c*/ void _OnSelectGroupForDetail(NoaDebugger.DebugCommand.GroupPanelInfo group, bool isOn);
            /*0x7335518*/ void _OnSelectCommandForDetail(NoaDebugger.DebugCommand.ICommand command, bool isOn);
            /*0x7335454*/ void _UpdateDetailInfo(string groupName, string commandName, NoaDebugger.DebugCommand.ICommand[] commands, System.Nullable<NoaDebugger.DebugCommand.CommandViewUpdateTarget> updateTarget);
            /*0x7334800*/ void _ResetDetailInfo(System.Nullable<NoaDebugger.DebugCommand.CommandViewUpdateTarget> updateTarget);
            /*0x7335804*/ void AlignmentUI(bool isReverse);
            /*0x7335828*/ bool GetPinStatus();
            /*0x7335878*/ void TogglePin(UnityEngine.Transform parent);
            /*0x73358e0*/ void InitFloatingWindow(UnityEngine.Transform parent);
            /*0x733596c*/ void _InitFloatingWindow(NoaDebugger.DebugCommand.DebugCommandFloatingWindowView window);
            /*0x7335a0c*/ void OnHidden();
            /*0x7335b3c*/ void OnToolDispose();
            /*0x7335a84*/ void _OnHiddenPresenter();
            /*0x7334e30*/ void _SaveFilter();
            /*0x73331a0*/ void _LoadFilter();
            /*0x7336548*/ void OnDestroy();

            class CommandMenuInfo : NoaDebugger.IMenuInfo
            {
                /*0x73333c4*/ CommandMenuInfo();
                /*0x73366cc*/ string get_Name();
                /*0x733670c*/ string get_MenuName();
                /*0x733674c*/ int get_SortNo();
            }

            class GroupFilter
            {
                /*0x10*/ string _categoryName;
                /*0x18*/ string[] _removeGroupsJson;

                /*0x7336540*/ GroupFilter();
            }

            class GroupFilterArray
            {
                /*0x10*/ string[] _groupFilterJson;

                /*0x7336538*/ GroupFilterArray();
            }

            class <>c
            {
                static /*0x0*/ NoaDebugger.DebugCommand.DebugCommandPresenter.<> <>9;
                static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommand.CommandGroupData>, int> <>9__36_0;

                static /*0x7336754*/ <>c();
                /*0x73367bc*/ <>c();
                /*0x73367c4*/ int <_CreateGroups>b__36_0(System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommand.CommandGroupData> x);
            }

            class <>c__DisplayClass43_0
            {
                /*0x10*/ string group;

                /*0x7334e28*/ <>c__DisplayClass43_0();
                /*0x733682c*/ bool <_OnSelectGroupForFloatingWindow>b__0(string target);
            }
        }

        class BoolPropertyCommandBuilder : NoaDebugger.DebugCommand.MutablePropertyCommandBuilderBase<bool>
        {
            /*0x7336840*/ BoolPropertyCommandBuilder(string categoryName, string displayName, System.Func<bool> getter, System.Action<bool> setter, System.Attribute[] attributes, string saveKey);
            /*0x73368d0*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class BytePropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<byte>
        {
            /*0x7336b28*/ BytePropertyCommandBuilder(string categoryName, string displayName, System.Func<byte> getter, System.Action<byte> setter, System.Attribute[] attributes, string saveKey);
            /*0x7336bb8*/ void PeekAttribute(System.Attribute attribute);
            /*0x7336d10*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x7337090*/ System.Nullable<byte> TryParse(object value);
        }

        class CharPropertyCommandBuilder : NoaDebugger.DebugCommand.MutablePropertyCommandBuilderBase<char>
        {
            /*0x7337120*/ CharPropertyCommandBuilder(string categoryName, string displayName, System.Func<char> getter, System.Action<char> setter, System.Attribute[] attributes, string saveKey);
            /*0x73371b0*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class CommandBuilderBase
        {
            /*0x10*/ string <CategoryName>k__BackingField;
            /*0x18*/ string <DisplayName>k__BackingField;
            /*0x20*/ string <GroupName>k__BackingField;
            /*0x28*/ System.Nullable<int> <GroupOrder>k__BackingField;
            /*0x30*/ string <TagName>k__BackingField;
            /*0x38*/ string <Description>k__BackingField;
            /*0x40*/ System.Nullable<int> <Order>k__BackingField;
            /*0x48*/ System.Attribute[] _attributes;

            /*0x7337468*/ CommandBuilderBase(string categoryName, string displayName, System.Attribute[] attributes);
            /*0x7337408*/ string get_CategoryName();
            /*0x7337410*/ string get_DisplayName();
            /*0x7337418*/ string get_GroupName();
            /*0x7337420*/ void set_GroupName(string value);
            /*0x7337428*/ System.Nullable<int> get_GroupOrder();
            /*0x7337430*/ void set_GroupOrder(System.Nullable<int> value);
            /*0x7337438*/ string get_TagName();
            /*0x7337440*/ void set_TagName(string value);
            /*0x7337448*/ string get_Description();
            /*0x7337450*/ void set_Description(string value);
            /*0x7337458*/ System.Nullable<int> get_Order();
            /*0x7337460*/ void set_Order(System.Nullable<int> value);
            /*0x73374c8*/ NoaDebugger.DebugCommand.ICommand Build();
            /*0x7337704*/ void PeekAttribute(System.Attribute attribute);
            /*0x380b9e8*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class CoroutineCommandBuilder : NoaDebugger.DebugCommand.CommandBuilderBase
        {
            /*0x50*/ System.Func<System.Collections.IEnumerator> _coroutine;

            /*0x7337708*/ CoroutineCommandBuilder(string categoryName, string displayName, System.Func<System.Collections.IEnumerator> coroutine, System.Attribute[] attributes);
            /*0x7337738*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class DecimalPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<decimal>
        {
            /*0xb0*/ int _needDigits;

            /*0x7337834*/ DecimalPropertyCommandBuilder(string categoryName, string displayName, System.Func<decimal> getter, System.Action<decimal> setter, System.Attribute[] attributes, string saveKey);
            /*0x73378c4*/ void PeekAttribute(System.Attribute attribute);
            /*0x7337a40*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x7337ec8*/ System.Nullable<decimal> TryParse(object value);
        }

        class DoublePropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<double>
        {
            /*0x98*/ int _needDigits;

            /*0x7338050*/ DoublePropertyCommandBuilder(string categoryName, string displayName, System.Func<double> getter, System.Action<double> setter, System.Attribute[] attributes, string saveKey);
            /*0x73380e0*/ void PeekAttribute(System.Attribute attribute);
            /*0x73381f0*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x7338594*/ System.Nullable<double> TryParse(object value);
        }

        class EnumPropertyCommandBuilder : NoaDebugger.DebugCommand.MutablePropertyCommandBuilderBase<System.Enum>
        {
            /*0x68*/ System.Type _enumType;

            /*0x73386c0*/ EnumPropertyCommandBuilder(string categoryName, string displayName, System.Func<System.Enum> getter, System.Action<System.Enum> setter, System.Type type, System.Attribute[] attributes, string saveKey);
            /*0x733876c*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class FloatPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<float>
        {
            /*0x80*/ int _needDigits;

            /*0x7338a24*/ FloatPropertyCommandBuilder(string categoryName, string displayName, System.Func<float> getter, System.Action<float> setter, System.Attribute[] attributes, string saveKey);
            /*0x7338ab4*/ void PeekAttribute(System.Attribute attribute);
            /*0x7338bbc*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x7338f38*/ System.Nullable<float> TryParse(object value);
        }

        class GetOnlyPropertyCommandBuilder : NoaDebugger.DebugCommand.CommandBuilderBase
        {
            /*0x50*/ System.Func<object> _getter;

            /*0x7339068*/ GetOnlyPropertyCommandBuilder(string categoryName, string displayName, System.Func<object> getter, System.Attribute[] attributes);
            /*0x7339098*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class HandleMethodCommandBuilder : NoaDebugger.DebugCommand.CommandBuilderBase
        {
            /*0x50*/ System.Func<NoaDebugger.MethodHandler> _method;

            /*0x733918c*/ HandleMethodCommandBuilder(string categoryName, string displayName, System.Func<NoaDebugger.MethodHandler> method, System.Attribute[] attributes);
            /*0x73391bc*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class IntPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<int>
        {
            /*0x73392b8*/ IntPropertyCommandBuilder(string categoryName, string displayName, System.Func<int> getter, System.Action<int> setter, System.Attribute[] attributes, string saveKey);
            /*0x7339348*/ void PeekAttribute(System.Attribute attribute);
            /*0x733944c*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x73397bc*/ System.Nullable<int> TryParse(object value);
        }

        class LongPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<long>
        {
            /*0x7339854*/ LongPropertyCommandBuilder(string categoryName, string displayName, System.Func<long> getter, System.Action<long> setter, System.Attribute[] attributes, string saveKey);
            /*0x73398e4*/ void PeekAttribute(System.Attribute attribute);
            /*0x73399f4*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x7339afc*/ System.Nullable<long> TryParse(object value);
        }

        class MethodCommandBuilder : NoaDebugger.DebugCommand.CommandBuilderBase
        {
            /*0x50*/ System.Action _method;

            /*0x7339b90*/ MethodCommandBuilder(string categoryName, string displayName, System.Action method, System.Attribute[] attributes);
            /*0x7339bc0*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class MutableNumericPropertyCommandBuilderBase<T> : NoaDebugger.DebugCommand.MutablePropertyCommandBuilderBase<T>
        {
            /*0x0*/ System.Nullable<T> _inputRangeMin;
            /*0x0*/ System.Nullable<T> _inputRangeMax;
            /*0x0*/ System.Nullable<T> _increment;

            /*0x380db40*/ MutableNumericPropertyCommandBuilderBase(string categoryName, string displayName, System.Func<T> getter, System.Action<T> setter, System.Attribute[] attributes, string saveKey);
            /*0x380d83c*/ void PeekAttribute(System.Attribute attribute);
            /*0x3907c14*/ System.Nullable<T> TryParse(object value);
            /*0x380cb08*/ void SendIncrementWarning();
        }

        class MutablePropertyCommandBuilderBase<T> : NoaDebugger.DebugCommand.CommandBuilderBase
        {
            /*0x0*/ System.Func<T> <Getter>k__BackingField;
            /*0x0*/ System.Action<T> <Setter>k__BackingField;
            /*0x0*/ string <SaveKey>k__BackingField;

            /*0x380db40*/ MutablePropertyCommandBuilderBase(string categoryName, string displayName, System.Func<T> getter, System.Action<T> setter, System.Attribute[] attributes, string saveKey);
            /*0x380b9e8*/ System.Func<T> get_Getter();
            /*0x380b9e8*/ System.Action<T> get_Setter();
            /*0x380b9e8*/ string get_SaveKey();
        }

        class SBytePropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<sbyte>
        {
            /*0x7339c64*/ SBytePropertyCommandBuilder(string categoryName, string displayName, System.Func<sbyte> getter, System.Action<sbyte> setter, System.Attribute[] attributes, string saveKey);
            /*0x7339cf4*/ void PeekAttribute(System.Attribute attribute);
            /*0x7339e4c*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x7339f3c*/ System.Nullable<sbyte> TryParse(object value);
        }

        class ShortPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<short>
        {
            /*0x7339fcc*/ ShortPropertyCommandBuilder(string categoryName, string displayName, System.Func<short> getter, System.Action<short> setter, System.Attribute[] attributes, string saveKey);
            /*0x733a05c*/ void PeekAttribute(System.Attribute attribute);
            /*0x733a1b4*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x733a2a0*/ System.Nullable<short> TryParse(object value);
        }

        class StringPropertyCommandBuilder : NoaDebugger.DebugCommand.MutablePropertyCommandBuilderBase<string>
        {
            /*0x68*/ System.Nullable<int> _characterLimit;

            /*0x733a330*/ StringPropertyCommandBuilder(string categoryName, string displayName, System.Func<string> getter, System.Action<string> setter, System.Attribute[] attributes, string saveKey);
            /*0x733a3c0*/ void PeekAttribute(System.Attribute attribute);
            /*0x733a46c*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class UIntPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<uint>
        {
            /*0x733a54c*/ UIntPropertyCommandBuilder(string categoryName, string displayName, System.Func<uint> getter, System.Action<uint> setter, System.Attribute[] attributes, string saveKey);
            /*0x733a5dc*/ void PeekAttribute(System.Attribute attribute);
            /*0x733a6e0*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x733a7cc*/ System.Nullable<uint> TryParse(object value);
        }

        class ULongPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<ulong>
        {
            /*0x733a864*/ ULongPropertyCommandBuilder(string categoryName, string displayName, System.Func<ulong> getter, System.Action<ulong> setter, System.Attribute[] attributes, string saveKey);
            /*0x733a8f4*/ void PeekAttribute(System.Attribute attribute);
            /*0x733aa00*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x733ab08*/ System.Nullable<ulong> TryParse(object value);
        }

        class UShortPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<ushort>
        {
            /*0x733ab9c*/ UShortPropertyCommandBuilder(string categoryName, string displayName, System.Func<ushort> getter, System.Action<ushort> setter, System.Attribute[] attributes, string saveKey);
            /*0x733ac2c*/ void PeekAttribute(System.Attribute attribute);
            /*0x733ad84*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x733ae70*/ System.Nullable<ushort> TryParse(object value);
        }

        class CommandFactory
        {
            static /*0x7330394*/ NoaDebugger.DebugCommand.ICommand CreateCommand(object obj, System.Reflection.PropertyInfo property, string categoryName);
            static /*0x732ff88*/ NoaDebugger.DebugCommand.ICommand CreateCommand(object obj, System.Reflection.MethodInfo method, string categoryName);
            static /*0x733af08*/ string GetDisplayName(System.Reflection.MemberInfo member);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ System.Reflection.PropertyInfo property;
                /*0x18*/ object obj;

                /*0x733af00*/ <>c__DisplayClass0_0();
                /*0x733aff0*/ object <CreateCommand>b__0();
                /*0x733b014*/ string <CreateCommand>b__1();
                /*0x733b05c*/ void <CreateCommand>b__2(string value);
                /*0x733b084*/ sbyte <CreateCommand>b__3();
                /*0x733b0dc*/ void <CreateCommand>b__4(sbyte value);
                /*0x733b128*/ byte <CreateCommand>b__5();
                /*0x733b180*/ void <CreateCommand>b__6(byte value);
                /*0x733b1cc*/ short <CreateCommand>b__7();
                /*0x733b224*/ void <CreateCommand>b__8(short value);
                /*0x733b270*/ ushort <CreateCommand>b__9();
                /*0x733b2c8*/ void <CreateCommand>b__10(ushort value);
                /*0x733b314*/ int <CreateCommand>b__11();
                /*0x733b36c*/ void <CreateCommand>b__12(int value);
                /*0x733b3b8*/ uint <CreateCommand>b__13();
                /*0x733b410*/ void <CreateCommand>b__14(uint value);
                /*0x733b45c*/ long <CreateCommand>b__15();
                /*0x733b4b4*/ void <CreateCommand>b__16(long value);
                /*0x733b500*/ ulong <CreateCommand>b__17();
                /*0x733b558*/ void <CreateCommand>b__18(ulong value);
                /*0x733b5a4*/ char <CreateCommand>b__19();
                /*0x733b5fc*/ void <CreateCommand>b__20(char value);
                /*0x733b648*/ float <CreateCommand>b__21();
                /*0x733b6a0*/ void <CreateCommand>b__22(float value);
                /*0x733b6ec*/ double <CreateCommand>b__23();
                /*0x733b744*/ void <CreateCommand>b__24(double value);
                /*0x733b790*/ decimal <CreateCommand>b__25();
                /*0x733b814*/ void <CreateCommand>b__26(decimal value);
                /*0x733b8c4*/ bool <CreateCommand>b__27();
                /*0x733b91c*/ void <CreateCommand>b__28(bool value);
                /*0x733b96c*/ System.Enum <CreateCommand>b__29();
                /*0x733b9d0*/ void <CreateCommand>b__30(System.Enum value);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ System.Reflection.MethodInfo method;
                /*0x18*/ object obj;

                /*0x733afe8*/ <>c__DisplayClass1_0();
                /*0x733b9f8*/ void <CreateCommand>b__0();
                /*0x733ba20*/ System.Collections.IEnumerator <CreateCommand>b__1();
                /*0x733baa0*/ NoaDebugger.MethodHandler <CreateCommand>b__2();
            }
        }

        class BoolPropertyCommand : NoaDebugger.DebugCommand.MutablePropertyCommandBase<bool>
        {
            /*0x73369a4*/ BoolPropertyCommand(string displayName, System.Func<bool> getter, System.Action<bool> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey);
            /*0x733bb30*/ string get_TypeName();
            /*0x733bc88*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x733bb70*/ bool GetValue();
            /*0x733bbb8*/ void SetValue(bool value);
        }

        class BytePropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<byte>
        {
            static /*0x0*/ byte DEFAULT_INPUT_RANGE_MIN;
            static /*0x1*/ byte DEFAULT_INPUT_RANGE_MAX;
            static /*0x2*/ byte DEFAULT_INCREMENT;

            static /*0x733c1b8*/ BytePropertyCommand();
            /*0x7336e00*/ BytePropertyCommand(string displayName, System.Func<byte> getter, System.Action<byte> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<byte> inputRangeMin, System.Nullable<byte> inputRangeMax, System.Nullable<byte> increment);
            /*0x733bd30*/ string get_TypeName();
            /*0x733bd70*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x733be18*/ byte GetValue();
            /*0x733bf3c*/ void SetValue(byte value);
            /*0x733c01c*/ byte FromString(string textValue);
            /*0x733c0d0*/ bool IsEqualOrUnderMin(byte value);
            /*0x733c0e0*/ bool IsEqualOrOverMax(byte value);
            /*0x733c0f0*/ byte ValidateValueForFluctuation(byte value, int magnification);
            /*0x733be6c*/ byte _ValidateValue(byte value);
        }

        class CharPropertyCommand : NoaDebugger.DebugCommand.MutablePropertyCommandBase<char>
        {
            /*0x7337284*/ CharPropertyCommand(string displayName, System.Func<char> getter, System.Action<char> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey);
            /*0x733c20c*/ string get_TypeName();
            /*0x733c364*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x733c24c*/ char GetValue();
            /*0x733c294*/ void SetValue(char value);
        }

        class CommandBase
        {
            static string DEFAULT_GROUP_NAME = "Others";
            static int DEFAULT_ORDER = 2147483647;
            /*0x10*/ string <DisplayName>k__BackingField;
            /*0x18*/ string <GroupName>k__BackingField;
            /*0x20*/ System.Nullable<int> <GroupOrder>k__BackingField;
            /*0x28*/ string <TagName>k__BackingField;
            /*0x30*/ string <Description>k__BackingField;
            /*0x38*/ int <Order>k__BackingField;

            /*0x733c43c*/ CommandBase(string displayName, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order);
            /*0x733c40c*/ string get_DisplayName();
            /*0x733c414*/ string get_GroupName();
            /*0x733c41c*/ System.Nullable<int> get_GroupOrder();
            /*0x733c424*/ string get_TagName();
            /*0x733c42c*/ string get_Description();
            /*0x733c434*/ int get_Order();
            /*0x380b9e8*/ string get_TypeName();
            /*0x733c530*/ System.Collections.Generic.Dictionary<string, string> CreateDetailContext();
        }

        class CoroutineCommand : NoaDebugger.DebugCommand.CommandBase, NoaDebugger.DebugCommand.ICommand
        {
            /*0x3c*/ bool <IsVisible>k__BackingField;
            /*0x40*/ System.Func<System.Collections.IEnumerator> _coroutine;
            /*0x48*/ bool _isInteractable;
            /*0x49*/ bool _isCoroutineWaiting;
            /*0x50*/ UnityEngine.Events.UnityAction _completeCallback;

            /*0x73377e8*/ CoroutineCommand(string displayName, System.Func<System.Collections.IEnumerator> coroutine, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order);
            /*0x733c69c*/ bool get_IsInteractable();
            /*0x733c6bc*/ void set_IsInteractable(bool value);
            /*0x733c6c8*/ bool get_IsVisible();
            /*0x733c6d0*/ void set_IsVisible(bool value);
            /*0x733c6dc*/ string get_TypeName();
            /*0x733c71c*/ void Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x733c7c4*/ void Invoke(UnityEngine.Events.UnityAction onComplete);
            /*0x733c908*/ void _OnComplete();
        }

        class DecimalPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<decimal>
        {
            static /*0x0*/ decimal DEFAULT_INPUT_RANGE_MIN;
            static /*0x10*/ decimal DEFAULT_INPUT_RANGE_MAX;
            static /*0x20*/ decimal DEFAULT_INCREMENT;
            /*0x90*/ int _needDigits;

            static /*0x733d1cc*/ DecimalPropertyCommand();
            /*0x7337b90*/ DecimalPropertyCommand(string displayName, System.Func<decimal> getter, System.Action<decimal> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<decimal> inputRangeMin, System.Nullable<decimal> inputRangeMax, System.Nullable<decimal> increment, int needDigits);
            /*0x733c928*/ string get_TypeName();
            /*0x733c968*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x733ca10*/ decimal GetValue();
            /*0x733cafc*/ void SetValue(decimal value);
            /*0x733cbfc*/ decimal FromString(string textValue);
            /*0x733cd4c*/ bool IsEqualOrUnderMin(decimal value);
            /*0x733cdc4*/ bool IsEqualOrOverMax(decimal value);
            /*0x733ce3c*/ decimal ValidateValueForFluctuation(decimal value, int magnification);
            /*0x733ca70*/ decimal _ValidateValue(decimal value);
        }

        class DoublePropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<double>
        {
            static /*0x0*/ double DEFAULT_INPUT_RANGE_MIN;
            static /*0x8*/ double DEFAULT_INPUT_RANGE_MAX;
            static /*0x10*/ double DEFAULT_INCREMENT;
            /*0x78*/ int _needDigits;

            static /*0x733d828*/ DoublePropertyCommand();
            /*0x73382fc*/ DoublePropertyCommand(string displayName, System.Func<double> getter, System.Action<double> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<double> inputRangeMin, System.Nullable<double> inputRangeMax, System.Nullable<double> increment, int needDigits);
            /*0x733d2e0*/ string get_TypeName();
            /*0x733d320*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x733d3c8*/ double GetValue();
            /*0x733d4f8*/ void SetValue(double value);
            /*0x733d5e0*/ double FromString(string textValue);
            /*0x733d6a0*/ bool IsEqualOrUnderMin(double value);
            /*0x733d6b0*/ bool IsEqualOrOverMax(double value);
            /*0x733d6c0*/ double ValidateValueForFluctuation(double value, int magnification);
            /*0x733d418*/ double _ValidateValue(double value);
        }

        class EnumPropertyCommand : NoaDebugger.DebugCommand.MutablePropertyCommandBase<System.Enum>
        {
            /*0x58*/ System.Type _enumType;
            /*0x60*/ string[] _enumNames;

            /*0x733884c*/ EnumPropertyCommand(string displayName, System.Func<System.Enum> getter, System.Action<System.Enum> setter, System.Type type, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey);
            /*0x733d880*/ string get_TypeName();
            /*0x733da50*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x733daf8*/ string[] GetNames();
            /*0x733d8c0*/ string GetValue();
            /*0x733d91c*/ void SetValue(string valueName);
        }

        class FloatPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<float>
        {
            static /*0x0*/ float DEFAULT_INPUT_RANGE_MIN;
            static /*0x4*/ float DEFAULT_INPUT_RANGE_MAX;
            static /*0x8*/ float DEFAULT_INCREMENT;
            /*0x68*/ int _needDigits;

            static /*0x733e048*/ FloatPropertyCommand();
            /*0x7338cb4*/ FloatPropertyCommand(string displayName, System.Func<float> getter, System.Action<float> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<float> inputRangeMin, System.Nullable<float> inputRangeMax, System.Nullable<float> increment, int needDigits);
            /*0x733db00*/ string get_TypeName();
            /*0x733db40*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x733dbe8*/ float GetValue();
            /*0x733dd18*/ void SetValue(float value);
            /*0x733de00*/ float FromString(string textValue);
            /*0x733dec0*/ bool IsEqualOrUnderMin(float value);
            /*0x733ded0*/ bool IsEqualOrOverMax(float value);
            /*0x733dee0*/ float ValidateValueForFluctuation(float value, int magnification);
            /*0x733dc38*/ float _ValidateValue(float value);
        }

        class GetOnlyPropertyCommand : NoaDebugger.DebugCommand.CommandBase, NoaDebugger.DebugCommand.ICommand
        {
            /*0x3c*/ bool <IsVisible>k__BackingField;
            /*0x40*/ System.Func<object> _getter;

            /*0x7339144*/ GetOnlyPropertyCommand(string displayName, System.Func<object> getter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order);
            /*0x733e0a0*/ bool get_IsInteractable();
            /*0x733e0a8*/ void set_IsInteractable(bool value);
            /*0x733e0ac*/ bool get_IsVisible();
            /*0x733e0b4*/ void set_IsVisible(bool value);
            /*0x733e0c0*/ string get_TypeName();
            /*0x733e100*/ void Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x733e1a4*/ string GetValue();
            /*0x733e274*/ System.Collections.Generic.Dictionary<string, string> CreateDetailContext();
        }

        class HandleMethodCommand : NoaDebugger.DebugCommand.CommandBase, NoaDebugger.DebugCommand.ICommand
        {
            /*0x3c*/ bool <IsVisible>k__BackingField;
            /*0x40*/ System.Func<NoaDebugger.MethodHandler> _method;
            /*0x48*/ bool _isInteractable;
            /*0x49*/ bool _isWaiting;
            /*0x50*/ UnityEngine.Events.UnityAction _completeCallback;
            /*0x58*/ NoaDebugger.MethodHandler _handler;

            /*0x733926c*/ HandleMethodCommand(string displayName, System.Func<NoaDebugger.MethodHandler> method, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order);
            /*0x733e318*/ bool get_IsInteractable();
            /*0x733e338*/ void set_IsInteractable(bool value);
            /*0x733e344*/ bool get_IsVisible();
            /*0x733e34c*/ void set_IsVisible(bool value);
            /*0x733e358*/ string get_TypeName();
            /*0x733e398*/ void Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x733e440*/ void Invoke(UnityEngine.Events.UnityAction onComplete);
            /*0x733e56c*/ System.Collections.IEnumerator _WatchHandler();
            /*0x733e600*/ void _OnComplete();

            class <_WatchHandler>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ NoaDebugger.DebugCommand.HandleMethodCommand <>4__this;

                /*0x733e5d8*/ <_WatchHandler>d__17(int <>1__state);
                /*0x733e640*/ void System.IDisposable.Dispose();
                /*0x733e644*/ bool MoveNext();
                /*0x733e6a8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x733e6b0*/ void System.Collections.IEnumerator.Reset();
                /*0x733e6e8*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class IntPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<int>
        {
            static /*0x0*/ int DEFAULT_INPUT_RANGE_MIN;
            static /*0x4*/ int DEFAULT_INPUT_RANGE_MAX;
            static /*0x8*/ int DEFAULT_INCREMENT;

            static /*0x733ebcc*/ IntPropertyCommand();
            /*0x7339538*/ IntPropertyCommand(string displayName, System.Func<int> getter, System.Action<int> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<int> inputRangeMin, System.Nullable<int> inputRangeMax, System.Nullable<int> increment);
            /*0x733e6f0*/ string get_TypeName();
            /*0x733e730*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x733e7d8*/ int GetValue();
            /*0x733e8f8*/ void SetValue(int value);
            /*0x733e9d8*/ int FromString(string textValue);
            /*0x733ea90*/ bool IsEqualOrUnderMin(int value);
            /*0x733eaa0*/ bool IsEqualOrOverMax(int value);
            /*0x733eab0*/ int ValidateValueForFluctuation(int value, int magnification);
            /*0x733e82c*/ int _ValidateValue(int value);
        }

        class LongPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<long>
        {
            static /*0x0*/ long DEFAULT_INPUT_RANGE_MIN;
            static /*0x8*/ long DEFAULT_INPUT_RANGE_MAX;
            static /*0x10*/ long DEFAULT_INCREMENT;

            static /*0x733f4dc*/ LongPropertyCommand();
            /*0x733edb0*/ LongPropertyCommand(string displayName, System.Func<long> getter, System.Action<long> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<long> inputRangeMin, System.Nullable<long> inputRangeMax, System.Nullable<long> increment);
            /*0x733ed70*/ string get_TypeName();
            /*0x733f040*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x733f0e8*/ long GetValue();
            /*0x733f208*/ void SetValue(long value);
            /*0x733f2e8*/ long FromString(string textValue);
            /*0x733f3a0*/ bool IsEqualOrUnderMin(long value);
            /*0x733f3b0*/ bool IsEqualOrOverMax(long value);
            /*0x733f3c0*/ long ValidateValueForFluctuation(long value, int magnification);
            /*0x733f13c*/ long _ValidateValue(long value);
        }

        class MethodCommand : NoaDebugger.DebugCommand.CommandBase, NoaDebugger.DebugCommand.ICommand
        {
            /*0x3c*/ bool <IsInteractable>k__BackingField;
            /*0x3d*/ bool <IsVisible>k__BackingField;
            /*0x40*/ System.Action _method;

            /*0x733f59c*/ MethodCommand(string displayName, System.Action method, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order);
            /*0x733f534*/ bool get_IsInteractable();
            /*0x733f53c*/ void set_IsInteractable(bool value);
            /*0x733f548*/ bool get_IsVisible();
            /*0x733f550*/ void set_IsVisible(bool value);
            /*0x733f55c*/ string get_TypeName();
            /*0x733f5e8*/ void Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x733f690*/ void Invoke();
        }

        class MutableNumericPropertyCommandBase<T> : NoaDebugger.DebugCommand.MutablePropertyCommandBase<T>
        {
            /*0x0*/ T _inputRangeMin;
            /*0x0*/ T _inputRangeMax;
            /*0x0*/ bool _isSetRange;
            /*0x0*/ T <Increment>k__BackingField;

            /*0x3907c14*/ MutableNumericPropertyCommandBase(string displayName, System.Func<T> getter, System.Action<T> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<T> inputRangeMin, System.Nullable<T> inputRangeMax, System.Nullable<T> increment);
            /*0x3907c14*/ T get_Increment();
            /*0x3907c14*/ void set_Increment(T value);
            /*0x380b9e8*/ System.Collections.Generic.Dictionary<string, string> CreateDetailContext();
            /*0x3907c14*/ T GetValue();
            /*0x3907c14*/ void SetValue(T value);
            /*0x3907c14*/ T FromString(string textValue);
            /*0x3907c14*/ bool IsEqualOrUnderMin(T value);
            /*0x3907c14*/ bool IsEqualOrOverMax(T value);
            /*0x3907c14*/ T ValidateValueForFluctuation(T value, int magnification);
            /*0x380b2f0*/ bool IsNotNumeric(string text);
        }

        class MutablePropertyCommandBase<T> : NoaDebugger.DebugCommand.CommandBase, NoaDebugger.DebugCommand.ICommand
        {
            /*0x0*/ bool <IsInteractable>k__BackingField;
            /*0x0*/ bool <IsVisible>k__BackingField;
            /*0x0*/ System.Func<T> _getter;
            /*0x0*/ System.Action<T> _setter;
            /*0x0*/ string <SaveKey>k__BackingField;

            /*0x3907c14*/ MutablePropertyCommandBase(string displayName, System.Func<T> getter, System.Action<T> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey);
            /*0x380b128*/ bool get_IsInteractable();
            /*0x380cdf0*/ void set_IsInteractable(bool value);
            /*0x380b128*/ bool get_IsVisible();
            /*0x380cdf0*/ void set_IsVisible(bool value);
            /*0x380b9e8*/ string get_SaveKey();
            /*0x380b128*/ bool get_SavesOnUpdate();
            /*0x380d83c*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x380d83c*/ void Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x380b9e8*/ System.Collections.Generic.Dictionary<string, string> CreateDetailContext();
            /*0x3907c14*/ T InvokeGetter();
            /*0x3907c14*/ void InvokeSetter(T value);
        }

        class SBytePropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<sbyte>
        {
            static /*0x0*/ sbyte DEFAULT_INPUT_RANGE_MIN;
            static /*0x1*/ sbyte DEFAULT_INPUT_RANGE_MAX;
            static /*0x2*/ sbyte DEFAULT_INCREMENT;

            static /*0x733fec0*/ SBytePropertyCommand();
            /*0x733f770*/ SBytePropertyCommand(string displayName, System.Func<sbyte> getter, System.Action<sbyte> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<sbyte> inputRangeMin, System.Nullable<sbyte> inputRangeMax, System.Nullable<sbyte> increment);
            /*0x733f730*/ string get_TypeName();
            /*0x733fa00*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x733faa8*/ sbyte GetValue();
            /*0x733fbcc*/ void SetValue(sbyte value);
            /*0x733fcac*/ sbyte FromString(string textValue);
            /*0x733fd64*/ bool IsEqualOrUnderMin(sbyte value);
            /*0x733fd74*/ bool IsEqualOrOverMax(sbyte value);
            /*0x733fd84*/ sbyte ValidateValueForFluctuation(sbyte value, int magnification);
            /*0x733fafc*/ sbyte _ValidateValue(sbyte value);
        }

        class ShortPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<short>
        {
            static /*0x0*/ short DEFAULT_INPUT_RANGE_MIN;
            static /*0x2*/ short DEFAULT_INPUT_RANGE_MAX;
            static /*0x4*/ short DEFAULT_INCREMENT;

            static /*0x73406a4*/ ShortPropertyCommand();
            /*0x733ff54*/ ShortPropertyCommand(string displayName, System.Func<short> getter, System.Action<short> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<short> inputRangeMin, System.Nullable<short> inputRangeMax, System.Nullable<short> increment);
            /*0x733ff14*/ string get_TypeName();
            /*0x73401e4*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x734028c*/ short GetValue();
            /*0x73403b0*/ void SetValue(short value);
            /*0x7340490*/ short FromString(string textValue);
            /*0x7340548*/ bool IsEqualOrUnderMin(short value);
            /*0x7340558*/ bool IsEqualOrOverMax(short value);
            /*0x7340568*/ short ValidateValueForFluctuation(short value, int magnification);
            /*0x73402e0*/ short _ValidateValue(short value);
        }

        class StringPropertyCommand : NoaDebugger.DebugCommand.MutablePropertyCommandBase<string>
        {
            /*0x58*/ int _unlimited;
            /*0x5c*/ int <CharacterLimit>k__BackingField;

            /*0x7340750*/ StringPropertyCommand(string displayName, System.Func<string> getter, System.Action<string> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<int> characterLimit);
            /*0x73406f8*/ bool get_IsUnlimited();
            /*0x7340708*/ int get_CharacterLimit();
            /*0x7340710*/ string get_TypeName();
            /*0x7340a3c*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7340914*/ string GetValue();
            /*0x734095c*/ void SetValue(string value);
            /*0x7340ae4*/ string ValidateValue(string value);
            /*0x7340b28*/ System.Collections.Generic.Dictionary<string, string> CreateDetailContext();
        }

        class UIntPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<uint>
        {
            static /*0x0*/ uint DEFAULT_INPUT_RANGE_MIN;
            static /*0x4*/ uint DEFAULT_INPUT_RANGE_MAX;
            static /*0x8*/ uint DEFAULT_INCREMENT;

            static /*0x7341340*/ UIntPropertyCommand();
            /*0x7340c74*/ UIntPropertyCommand(string displayName, System.Func<uint> getter, System.Action<uint> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<uint> inputRangeMin, System.Nullable<uint> inputRangeMax, System.Nullable<uint> increment);
            /*0x7340c34*/ string get_TypeName();
            /*0x7340ef8*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7340fa0*/ uint GetValue();
            /*0x73410c0*/ void SetValue(uint value);
            /*0x73411a0*/ uint FromString(string textValue);
            /*0x7341254*/ bool IsEqualOrUnderMin(uint value);
            /*0x7341264*/ bool IsEqualOrOverMax(uint value);
            /*0x7341274*/ uint ValidateValueForFluctuation(uint value, int magnification);
            /*0x7340ff4*/ uint _ValidateValue(uint value);
        }

        class ULongPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<ulong>
        {
            static /*0x0*/ ulong DEFAULT_INPUT_RANGE_MIN;
            static /*0x8*/ ulong DEFAULT_INPUT_RANGE_MAX;
            static /*0x10*/ ulong DEFAULT_INCREMENT;

            static /*0x7341ac0*/ ULongPropertyCommand();
            /*0x73413d4*/ ULongPropertyCommand(string displayName, System.Func<ulong> getter, System.Action<ulong> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<ulong> inputRangeMin, System.Nullable<ulong> inputRangeMax, System.Nullable<ulong> increment);
            /*0x7341394*/ string get_TypeName();
            /*0x7341664*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x734170c*/ ulong GetValue();
            /*0x734182c*/ void SetValue(ulong value);
            /*0x734190c*/ ulong FromString(string textValue);
            /*0x73419c0*/ bool IsEqualOrUnderMin(ulong value);
            /*0x73419d0*/ bool IsEqualOrOverMax(ulong value);
            /*0x73419e0*/ ulong ValidateValueForFluctuation(ulong value, int magnification);
            /*0x7341760*/ ulong _ValidateValue(ulong value);
        }

        class UShortPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<ushort>
        {
            static /*0x0*/ ushort DEFAULT_INPUT_RANGE_MIN;
            static /*0x2*/ ushort DEFAULT_INPUT_RANGE_MAX;
            static /*0x4*/ ushort DEFAULT_INCREMENT;

            static /*0x7342230*/ UShortPropertyCommand();
            /*0x7341b58*/ UShortPropertyCommand(string displayName, System.Func<ushort> getter, System.Action<ushort> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<ushort> inputRangeMin, System.Nullable<ushort> inputRangeMax, System.Nullable<ushort> increment);
            /*0x7341b18*/ string get_TypeName();
            /*0x7341de8*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7341e90*/ ushort GetValue();
            /*0x7341fb4*/ void SetValue(ushort value);
            /*0x7342094*/ ushort FromString(string textValue);
            /*0x7342148*/ bool IsEqualOrUnderMin(ushort value);
            /*0x7342158*/ bool IsEqualOrOverMax(ushort value);
            /*0x7342168*/ ushort ValidateValueForFluctuation(ushort value, int magnification);
            /*0x7341ee4*/ ushort _ValidateValue(ushort value);
        }

        class DebugCommandDefinitionRegister
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<NoaDebugger.CommandDefinition>> <CommandDefinitions>k__BackingField;

            /*0x7342578*/ DebugCommandDefinitionRegister();
            /*0x7342284*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<NoaDebugger.CommandDefinition>> get_CommandDefinitions();
            /*0x734228c*/ void Dispose();
            /*0x73422dc*/ bool Add(NoaDebugger.CommandDefinition commandDefinition);
            /*0x7342400*/ bool Remove(NoaDebugger.CommandDefinition commandDefinition);
            /*0x7342520*/ bool RemoveCategory(string categoryName);
        }

        interface ICommand
        {
            /*0x380b9e8*/ string get_DisplayName();
            /*0x380b9e8*/ string get_GroupName();
            /*0x380a924*/ System.Nullable<int> get_GroupOrder();
            /*0x380b9e8*/ string get_TagName();
            /*0x380b9e8*/ string get_Description();
            /*0x380b6a0*/ int get_Order();
            /*0x380b128*/ bool get_IsInteractable();
            /*0x380cdf0*/ void set_IsInteractable(bool value);
            /*0x380b128*/ bool get_IsVisible();
            /*0x380cdf0*/ void set_IsVisible(bool value);
            /*0x380d83c*/ void Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x380b9e8*/ System.Collections.Generic.Dictionary<string, string> CreateDetailContext();
            /*0x7342600*/ string GetDetailSuffix();
        }

        interface ICommandVisitor
        {
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.GetOnlyPropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.StringPropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.ShortPropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.UShortPropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.IntPropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.UIntPropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.BytePropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.SBytePropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.LongPropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.ULongPropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.CharPropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.FloatPropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.DoublePropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.DecimalPropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.BoolPropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.EnumPropertyCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.MethodCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.CoroutineCommand command);
            /*0x380d83c*/ void Visit(NoaDebugger.DebugCommand.HandleMethodCommand command);
        }

        class DebugCommandCategoryView : NoaDebugger.ViewBase<NoaDebugger.DebugCommand.DebugCommandViewLinker>
        {
            /*0x20*/ TMPro.TextMeshProUGUI _categoryLabel;
            /*0x28*/ UnityEngine.GameObject _categorySelect;
            /*0x30*/ NoaDebugger.DisableButtonBase _categorySelectButton;
            /*0x38*/ NoaDebugger.MenuTabComponent _categoryTab;
            /*0x40*/ UnityEngine.UI.ScrollRect _tabScroll;
            /*0x48*/ NoaDebugger.MenuTabComponent[] _tabs;
            /*0x50*/ string[] _categoryNames;
            /*0x58*/ UnityEngine.Events.UnityAction<int> OnSelectCategory;

            /*0x7342ff8*/ DebugCommandCategoryView();
            /*0x734272c*/ void add_OnSelectCategory(UnityEngine.Events.UnityAction<int> value);
            /*0x73427dc*/ void remove_OnSelectCategory(UnityEngine.Events.UnityAction<int> value);
            /*0x734288c*/ void _OnValidateUI();
            /*0x7342890*/ void _Init();
            /*0x734294c*/ void _OnShow(NoaDebugger.DebugCommand.DebugCommandViewLinker linker);
            /*0x7342ddc*/ void AlignmentUI(bool isReverse);
            /*0x7342eb4*/ System.Collections.IEnumerator _SetScrollPosition();
            /*0x7342abc*/ void _CreateCategoryMenu(string[] categoryNames);
            /*0x7342f50*/ void _OnClickCategorySelect();
            /*0x7342fbc*/ void _OnCategoryTab(int index);

            class <>c__DisplayClass15_0
            {
                /*0x10*/ int index;
                /*0x18*/ NoaDebugger.DebugCommand.DebugCommandCategoryView <>4__this;

                /*0x7342f48*/ <>c__DisplayClass15_0();
                /*0x7343040*/ void <_CreateCategoryMenu>b__0();
            }

            class <_SetScrollPosition>d__14 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ NoaDebugger.DebugCommand.DebugCommandCategoryView <>4__this;

                /*0x7342f20*/ <_SetScrollPosition>d__14(int <>1__state);
                /*0x7343060*/ void System.IDisposable.Dispose();
                /*0x7343064*/ bool MoveNext();
                /*0x73430d4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x73430dc*/ void System.Collections.IEnumerator.Reset();
                /*0x7343114*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class DebugCommandFloatingWindowView : NoaDebugger.FloatingWindowViewBase<NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker>
        {
            /*0x80*/ NoaDebugger.DebugCommandScrollAreaView _scrollArea;
            /*0x88*/ NoaDebugger.DebugCommand.DebugCommandCategoryView _defaultViewCategorySelect;
            /*0x90*/ NoaDebugger.LongTapToggleColorButton _refreshButton;
            /*0x98*/ NoaDebugger.DebugCommand.DebugCommandCategoryView _smallView;
            /*0xa0*/ UnityEngine.Events.UnityAction<int> OnSelectCategory;
            /*0xa8*/ UnityEngine.Events.UnityAction<bool, NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker> OnTapRefreshButton;
            /*0xb0*/ UnityEngine.Events.UnityAction<NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker> OnLongTapRefreshButton;
            /*0xb8*/ NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker _linker;

            /*0x73438c4*/ DebugCommandFloatingWindowView();
            /*0x734311c*/ void add_OnSelectCategory(UnityEngine.Events.UnityAction<int> value);
            /*0x73431cc*/ void remove_OnSelectCategory(UnityEngine.Events.UnityAction<int> value);
            /*0x734327c*/ void add_OnTapRefreshButton(UnityEngine.Events.UnityAction<bool, NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker> value);
            /*0x734332c*/ void remove_OnTapRefreshButton(UnityEngine.Events.UnityAction<bool, NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker> value);
            /*0x73433dc*/ void add_OnLongTapRefreshButton(UnityEngine.Events.UnityAction<NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker> value);
            /*0x734348c*/ void remove_OnLongTapRefreshButton(UnityEngine.Events.UnityAction<NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker> value);
            /*0x734353c*/ void _OnValidateUI();
            /*0x7343540*/ void _Init();
            /*0x7343728*/ void _OnShow(NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker linker);
            /*0x7343830*/ void _OnCategoryTab(int index);
            /*0x7343868*/ void _OnTapRefreshButton();
            /*0x73438a4*/ void _OnLongTapRefreshButton(bool isToggleOn);
        }

        class DebugCommandFloatingWindowViewLinker : NoaDebugger.ViewLinkerBase
        {
            /*0x10*/ NoaDebugger.DebugCommand.DebugCommandViewLinker _viewLinker;
            /*0x18*/ bool _refreshCommandPanelsOnly;
            /*0x20*/ UnityEngine.Events.UnityAction _onLongTapRefreshButton;

            /*0x734390c*/ DebugCommandFloatingWindowViewLinker();
        }

        class CommandGroupPanel : UnityEngine.EventSystems.UIBehaviour
        {
            /*0x20*/ UnityEngine.RectTransform _root;
            /*0x28*/ UnityEngine.UI.VerticalLayoutGroup _rootLayout;
            /*0x30*/ UnityEngine.RectTransform _headerRoot;
            /*0x38*/ TMPro.TextMeshProUGUI _groupName;
            /*0x40*/ NoaDebugger.ToggleButtonBase _collapseToggle;
            /*0x48*/ NoaDebugger.ToggleButtonBase _floatingToggle;
            /*0x50*/ NoaDebugger.ToggleButtonBase _detailToggle;
            /*0x58*/ NoaDebugger.DebugCommand.CommandPanelsParent _panelFormatCommandPanelsParent;
            /*0x60*/ NoaDebugger.DebugCommand.CommandPanelsParent _listFormatCommandPanelsParent;
            /*0x68*/ UnityEngine.GameObject _groupEndLineObject;
            /*0x70*/ float _verticalSpace;
            /*0x74*/ float _horizontalSpace;
            /*0x78*/ UnityEngine.Vector2 _space;
            /*0x80*/ UnityEngine.Vector2 _panelsAnchor;
            /*0x88*/ NoaDebugger.DebugCommand.GroupPanelInfo _group;
            /*0x90*/ bool <IsNeedAlign>k__BackingField;
            /*0x91*/ bool _isInit;

            /*0x7345054*/ CommandGroupPanel();
            /*0x7343914*/ float get_MaxContentWidth();
            /*0x7343938*/ float get_ParentWidth();
            /*0x7343954*/ bool get_IsNeedAlign();
            /*0x734395c*/ void set_IsNeedAlign(bool value);
            /*0x7343968*/ void _Init();
            /*0x7343c70*/ void OnRectTransformDimensionsChange();
            /*0x7343c7c*/ void AlignmentPanels();
            /*0x7343fbc*/ void _AlignmentPanels(UnityEngine.RectTransform parent, System.Collections.Generic.List<UnityEngine.RectTransform> targets, bool isForceExpand);
            /*0x7344324*/ void _FitHeight(UnityEngine.RectTransform targetPanelsParent);
            /*0x73443d4*/ void RefreshPanels();
            /*0x7344534*/ void RefreshPanelsStatus(NoaDebugger.DebugCommand.GroupPanelInfo group);
            /*0x7344618*/ void RefreshHeader(NoaDebugger.DebugCommand.GroupPanelInfo group, bool isFloatingWindow, float headerHeight);
            /*0x7343f50*/ NoaDebugger.DebugCommand.CommandPanelsParent _GetCurrentPanelsParent();
            /*0x73447c8*/ void InstantiateGroup(NoaDebugger.DebugCommand.GroupPanelInfo group, bool isFloatingWindow, float headerHeight, bool isLast, NoaDebugger.DebugCommand.CommandScroll scrollRect);
            /*0x7344ccc*/ void _SetMaxWidth(NoaDebugger.DebugCommandPanel target);
            /*0x7344c30*/ void _CollapseCommands(bool isCollapse);
            /*0x7344d80*/ void _OnClickCollapseToggle(bool isOn);
            /*0x7344de0*/ void _OnClickFloatingToggle(bool isOn);
            /*0x7344e30*/ void _OnClickDetailToggle(bool isOn);
            /*0x7344e74*/ void DestroyPanels();

            class <>c
            {
                static /*0x0*/ NoaDebugger.DebugCommand.CommandGroupPanel.<> <>9;
                static /*0x8*/ System.Func<NoaDebugger.DebugCommandPanel, UnityEngine.RectTransform> <>9__26_0;

                static /*0x7345068*/ <>c();
                /*0x73450d0*/ <>c();
                /*0x73450d8*/ UnityEngine.RectTransform <AlignmentPanels>b__26_0(NoaDebugger.DebugCommandPanel panel);
            }
        }

        class CommandPanelsParent
        {
            /*0x10*/ UnityEngine.RectTransform _rootTransform;
            /*0x18*/ NoaDebugger.DebugCommandPanel _panelPrefab;
            /*0x20*/ NoaDebugger.ContentPanelPool _panelPool;
            /*0x28*/ System.Collections.Generic.List<NoaDebugger.DebugCommandPanel> _commandComponents;
            /*0x30*/ System.Collections.Generic.List<int> _panelPoolIndexes;

            /*0x7345150*/ CommandPanelsParent();
            /*0x7345140*/ UnityEngine.RectTransform get_RootTransform();
            /*0x7345148*/ System.Collections.Generic.List<NoaDebugger.DebugCommandPanel> get_CommandComponents();
            /*0x7343b38*/ void Init();
            /*0x73443ec*/ void RefreshPanels();
            /*0x7344554*/ void RefreshPanelsStatus(NoaDebugger.DebugCommand.GroupPanelInfo group);
            /*0x734499c*/ void InstantiateCommands(NoaDebugger.DebugCommand.GroupPanelInfo group, float maxContentWidth, NoaDebugger.DebugCommand.CommandScroll scrollRect, System.Action<NoaDebugger.DebugCommandPanel> onInit);
            /*0x7344e9c*/ void DestroyPanels();
        }

        class CommandScroll : NoaDebugger.BlockableScrollRect
        {
            /*0x131*/ bool _isFloatingWindow;
            /*0x134*/ float _groupHeaderHeight;
            /*0x138*/ UnityEngine.UI.VerticalLayoutGroup _groupLayout;
            /*0x140*/ NoaDebugger.DebugCommand.CommandGroupPanel _groupPanelPrefab;
            /*0x148*/ NoaDebugger.ContentPanelPool _groupPanelPool;
            /*0x150*/ System.Collections.Generic.List<NoaDebugger.DebugCommand.CommandGroupPanel> _groupPanelComponents;
            /*0x158*/ System.Collections.Generic.List<int> _groupPanelPoolIndexes;
            /*0x160*/ bool _isInit;

            /*0x7345ec4*/ CommandScroll();
            /*0x7345158*/ void _Init();
            /*0x73452ac*/ void Reset(NoaDebugger.DebugCommand.GroupPanelInfo[] groups);
            /*0x7345790*/ void LateUpdate();
            /*0x7345a78*/ void UpdatePanelsStatus(NoaDebugger.DebugCommand.DebugCommandViewLinker linker);
            /*0x7345d24*/ void RefreshPanels();
            /*0x73455bc*/ void _InstantiateGroups(NoaDebugger.DebugCommand.GroupPanelInfo[] groups);
            /*0x73452f4*/ void _DestroyPanels();
            /*0x7345e68*/ void Dispose();
            /*0x7345ecc*/ void <UpdatePanelsStatus>b__11_0(NoaDebugger.DebugCommand.CommandGroupPanel panel, NoaDebugger.DebugCommand.GroupPanelInfo info);

            class <>c
            {
                static /*0x0*/ NoaDebugger.DebugCommand.CommandScroll.<> <>9;
                static /*0x8*/ System.Action<NoaDebugger.DebugCommand.CommandGroupPanel, NoaDebugger.DebugCommand.GroupPanelInfo> <>9__11_1;

                static /*0x7345ef4*/ <>c();
                /*0x7345f5c*/ <>c();
                /*0x7345f64*/ void <UpdatePanelsStatus>b__11_1(NoaDebugger.DebugCommand.CommandGroupPanel panel, NoaDebugger.DebugCommand.GroupPanelInfo info);
            }
        }

        class GroupPanelInfo
        {
            /*0x10*/ string _name;
            /*0x18*/ NoaDebugger.DebugCommand.ICommand[] _commands;
            /*0x20*/ NoaDebugger.DebugCommand.GroupCollapseToggleInfo _collapseToggleInfo;
            /*0x28*/ NoaDebugger.DebugCommand.GroupFloatingToggleInfo _floatingToggleInfo;
            /*0x30*/ NoaDebugger.DebugCommand.DetailToggleInfo _detailToggleInfo;

            /*0x7345fd4*/ GroupPanelInfo(string name, NoaDebugger.DebugCommand.GroupCollapseToggleInfo collapseToggleInfo, NoaDebugger.DebugCommand.GroupFloatingToggleInfo floatingToggleInfo, NoaDebugger.DebugCommand.DetailToggleInfo detailToggleInfo);
            /*0x73447a4*/ bool IsShowGroupDetail();
        }

        class GroupCollapseToggleInfo
        {
            /*0x10*/ bool _isOn;
            /*0x18*/ UnityEngine.Events.UnityAction<string, bool> _onChange;

            /*0x7346048*/ GroupCollapseToggleInfo(bool isOn, UnityEngine.Events.UnityAction<string, bool> onChange);
        }

        class GroupFloatingToggleInfo
        {
            /*0x10*/ bool _isOn;
            /*0x11*/ bool _isActive;
            /*0x18*/ UnityEngine.Events.UnityAction<string, bool> _onChange;

            /*0x7346080*/ GroupFloatingToggleInfo(bool isOn, bool isActive, UnityEngine.Events.UnityAction<string, bool> onChange);
        }

        class DetailToggleInfo
        {
            /*0x10*/ bool _isDetailMode;
            /*0x18*/ string _selectedGroup;
            /*0x20*/ string _selectedCommand;
            /*0x28*/ UnityEngine.Events.UnityAction<NoaDebugger.DebugCommand.GroupPanelInfo, bool> _onSelectGroup;
            /*0x30*/ UnityEngine.Events.UnityAction<NoaDebugger.DebugCommand.ICommand, bool> _onSelectCommand;

            /*0x73460c8*/ DetailToggleInfo(bool isDetailMode, string selectedGroup, string selectedCommand, UnityEngine.Events.UnityAction<NoaDebugger.DebugCommand.GroupPanelInfo, bool> onSelectGroup, UnityEngine.Events.UnityAction<NoaDebugger.DebugCommand.ICommand, bool> onSelectCommand);
            /*0x7345f7c*/ bool IsShowDetail(string groupName, string commandName);
        }

        class DebugCommandView : NoaDebugger.NoaDebuggerToolViewBase<NoaDebugger.DebugCommand.DebugCommandViewLinker>
        {
            /*0x28*/ NoaDebugger.ToggleButtonBase _displayDetailsToggle;
            /*0x30*/ NoaDebugger.LongTapToggleColorButton _refreshButton;
            /*0x38*/ NoaDebugger.DebugCommandScrollAreaView _scrollArea;
            /*0x40*/ UnityEngine.GameObject _floatingSelectFooter;
            /*0x48*/ UnityEngine.UI.Button _floatingSelectAllButton;
            /*0x50*/ UnityEngine.UI.Button _floatingDeselectAllButton;
            /*0x58*/ NoaDebugger.DebugCommandDetailsAreaView _detailsArea;
            /*0x60*/ NoaDebugger.DebugCommand.DebugCommandCategoryView _categorySelect;
            /*0x68*/ UnityEngine.Events.UnityAction<int> OnSelectCategory;
            /*0x70*/ UnityEngine.Events.UnityAction<bool> OnDisplayDetailsToggle;
            /*0x78*/ UnityEngine.Events.UnityAction<bool> OnTapRefreshButton;
            /*0x80*/ UnityEngine.Events.UnityAction OnLongTapRefreshButton;
            /*0x88*/ UnityEngine.Events.UnityAction<bool> OnFloatingSelectAllButton;

            /*0x7346db0*/ DebugCommandView();
            /*0x734614c*/ void add_OnSelectCategory(UnityEngine.Events.UnityAction<int> value);
            /*0x73461fc*/ void remove_OnSelectCategory(UnityEngine.Events.UnityAction<int> value);
            /*0x73462ac*/ void add_OnDisplayDetailsToggle(UnityEngine.Events.UnityAction<bool> value);
            /*0x734635c*/ void remove_OnDisplayDetailsToggle(UnityEngine.Events.UnityAction<bool> value);
            /*0x734640c*/ void add_OnTapRefreshButton(UnityEngine.Events.UnityAction<bool> value);
            /*0x73464bc*/ void remove_OnTapRefreshButton(UnityEngine.Events.UnityAction<bool> value);
            /*0x734656c*/ void add_OnLongTapRefreshButton(UnityEngine.Events.UnityAction value);
            /*0x7346608*/ void remove_OnLongTapRefreshButton(UnityEngine.Events.UnityAction value);
            /*0x73466a4*/ void add_OnFloatingSelectAllButton(UnityEngine.Events.UnityAction<bool> value);
            /*0x7346754*/ void remove_OnFloatingSelectAllButton(UnityEngine.Events.UnityAction<bool> value);
            /*0x7346804*/ void _OnValidateUI();
            /*0x7346808*/ void _Init();
            /*0x7346af0*/ void _OnShow(NoaDebugger.DebugCommand.DebugCommandViewLinker linker);
            /*0x7346c24*/ void AlignmentUI(bool isReverse);
            /*0x7346ca8*/ void RefreshCommandPanels();
            /*0x7346cc4*/ void _OnCategoryTab(int index);
            /*0x7346cfc*/ void _OnDisplayDetailsToggle(bool isOn);
            /*0x7346d1c*/ void _OnTapRefreshButton();
            /*0x7346d54*/ void _OnLongTapRefreshButton(bool isToggleOn);
            /*0x7346d70*/ void _OnTapFloatingSelectAllButton();
            /*0x7346d90*/ void _OnTapFloatingDeselectAllButton();
        }

        class DebugCommandViewLinker : NoaDebugger.ViewLinkerBase
        {
            /*0x10*/ string[] _categoryNames;
            /*0x18*/ NoaDebugger.DebugCommand.GroupPanelInfo[] _groups;
            /*0x20*/ int _selectCategoryIndex;
            /*0x24*/ bool _isActiveFloatingWindow;
            /*0x25*/ bool _isDetailMode;
            /*0x26*/ bool _isSelectGroupForDetail;
            /*0x28*/ string _selectedGroupForDetail;
            /*0x30*/ NoaDebugger.DebugCommand.ICommand[] _displayDetailCommands;
            /*0x38*/ bool _isAutoRefresh;
            /*0x3c*/ NoaDebugger.DebugCommand.CommandViewUpdateTarget _updateTarget;

            /*0x7346df8*/ DebugCommandViewLinker();
            /*0x7343820*/ bool IsMatchUpdateTarget(NoaDebugger.DebugCommand.CommandViewUpdateTarget target);
        }

        enum CommandViewUpdateTarget
        {
            CategorySelect = 1,
            GroupHeader = 2,
            CommandStatus = 4,
            CommandPanel = 8,
            DetailArea = 16,
            Buttons = 32,
            All = 63,
        }

        class DragSliderHelper
        {
            static int SENSITIVITY = 2;

            /*0x7346e7c*/ DragSliderHelper();
            /*0x7346e08*/ int Delimit(float distance);
        }

        class CommandPanelBase<TCommand> : NoaDebugger.DebugCommand.ICommandPanel
        {
            /*0x0*/ NoaDebugger.DebugCommandPanel _panel;
            /*0x0*/ TCommand _command;
            /*0x0*/ TMPro.TextAlignmentOptions _alignmentOptionCenter;
            /*0x0*/ TMPro.TextAlignmentOptions _alignmentOptionLeft;

            /*0x380d83c*/ CommandPanelBase(NoaDebugger.DebugCommandPanel panel);
            /*0x380e050*/ void OnUpdateWidth(float maxContentWidth);
            /*0x380d83c*/ void UpdateData(NoaDebugger.DebugCommand.ICommand command);
            /*0x380cb08*/ void Refresh();
            /*0x380b6a0*/ TMPro.TextAlignmentOptions GetDisplayNameAlignmentFromDisplayFormat();
            /*0x3907c14*/ void SetPreferredWidthFromText(UnityEngine.UI.LayoutElement targetLayout, float horizontalPadding, TMPro.TMP_Text textComponent, float maxWidth);
        }

        class CommandPanelBoolProperty : NoaDebugger.DebugCommand.CommandPanelBase<NoaDebugger.DebugCommand.BoolPropertyCommand>
        {
            /*0x7346e84*/ CommandPanelBoolProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x7347054*/ void Refresh();
            /*0x7347090*/ void _OnToggleChange(bool isOn);
        }

        class CommandPanelByteProperty : NoaDebugger.DebugCommand.CommandPanelUnsignedNumberPropertyBase<NoaDebugger.DebugCommand.BytePropertyCommand, byte>
        {
            /*0x73470b0*/ CommandPanelByteProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x7347118*/ void OnEndInputEdit(string text);
        }

        class CommandPanelCharProperty : NoaDebugger.DebugCommand.CommandPanelSimpleInputPropertyBase<NoaDebugger.DebugCommand.CharPropertyCommand>
        {
            /*0x7347170*/ CommandPanelCharProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x73471f4*/ string GetValueString();
            /*0x7347244*/ void OnEndInputEdit(string text);
        }

        class CommandPanelCoroutine : NoaDebugger.DebugCommand.CommandPanelMethodBase<NoaDebugger.DebugCommand.CoroutineCommand>
        {
            /*0x73472b8*/ CommandPanelCoroutine(NoaDebugger.DebugCommandPanel panel);
            /*0x7347320*/ void Refresh();
            /*0x734739c*/ void OnClick();
        }

        class CommandPanelDecimalProperty : NoaDebugger.DebugCommand.CommandPanelFloatingPointNumberPropertyBase<NoaDebugger.DebugCommand.DecimalPropertyCommand, decimal>
        {
            /*0x7347424*/ CommandPanelDecimalProperty(NoaDebugger.DebugCommandPanel panel, float maxContentWidth);
            /*0x73474ac*/ void OnEndInputEdit(string text);
        }

        class CommandPanelDoubleProperty : NoaDebugger.DebugCommand.CommandPanelFloatingPointNumberPropertyBase<NoaDebugger.DebugCommand.DoublePropertyCommand, double>
        {
            /*0x734750c*/ CommandPanelDoubleProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x7347574*/ void OnEndInputEdit(string text);
        }

        class CommandPanelEnumProperty : NoaDebugger.DebugCommand.CommandPanelBase<NoaDebugger.DebugCommand.EnumPropertyCommand>
        {
            /*0x28*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> _optionDataList;
            /*0x30*/ string _longestName;
            /*0x38*/ UnityEngine.UI.LayoutElement _layoutElement;
            /*0x40*/ float _horizontalPadding;

            /*0x73475c4*/ CommandPanelEnumProperty(NoaDebugger.DebugCommandPanel panel, float maxContentWidth);
            /*0x7347950*/ void OnUpdateWidth(float maxContentWidth);
            /*0x7347aa4*/ void Refresh();
            /*0x7347af8*/ int _GetEnumIndex(string value);
            /*0x7347b7c*/ void _OnChangeDropdown(int index);
        }

        class CommandPanelFloatingPointNumberPropertyBase<TCommand, TNumericType> : NoaDebugger.DebugCommand.CommandPanelNumericInputPropertyBase<TCommand, TNumericType>
        {
            /*0x380d83c*/ CommandPanelFloatingPointNumberPropertyBase(NoaDebugger.DebugCommandPanel panel);
        }

        class CommandPanelFloatProperty : NoaDebugger.DebugCommand.CommandPanelFloatingPointNumberPropertyBase<NoaDebugger.DebugCommand.FloatPropertyCommand, float>
        {
            /*0x7347bb8*/ CommandPanelFloatProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x7347c20*/ void OnEndInputEdit(string text);
        }

        class CommandPanelGetOnlyProperty : NoaDebugger.DebugCommand.CommandPanelBase<NoaDebugger.DebugCommand.GetOnlyPropertyCommand>
        {
            /*0x28*/ UnityEngine.UI.LayoutElement _layoutElement;
            /*0x30*/ float _horizontalPadding;

            /*0x7347c70*/ CommandPanelGetOnlyProperty(NoaDebugger.DebugCommandPanel panel, float maxContentWidth);
            /*0x7347e4c*/ void OnUpdateWidth(float maxContentWidth);
            /*0x7347f1c*/ void Refresh();
        }

        class CommandPanelHandleMethod : NoaDebugger.DebugCommand.CommandPanelMethodBase<NoaDebugger.DebugCommand.HandleMethodCommand>
        {
            /*0x7347f88*/ CommandPanelHandleMethod(NoaDebugger.DebugCommandPanel panel);
            /*0x7347ff0*/ void Refresh();
            /*0x734806c*/ void OnClick();
        }

        class CommandPanelIntProperty : NoaDebugger.DebugCommand.CommandPanelSignedNumberPropertyBase<NoaDebugger.DebugCommand.IntPropertyCommand, int>
        {
            /*0x73480f4*/ CommandPanelIntProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x734815c*/ void OnEndInputEdit(string text);
        }

        class CommandPanelLongProperty : NoaDebugger.DebugCommand.CommandPanelSignedNumberPropertyBase<NoaDebugger.DebugCommand.LongPropertyCommand, long>
        {
            /*0x73481b4*/ CommandPanelLongProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x734821c*/ void OnEndInputEdit(string text);
        }

        class CommandPanelMethod : NoaDebugger.DebugCommand.CommandPanelMethodBase<NoaDebugger.DebugCommand.MethodCommand>
        {
            /*0x7348274*/ CommandPanelMethod(NoaDebugger.DebugCommandPanel panel);
            /*0x73482dc*/ void OnClick();
        }

        class CommandPanelMethodBase<TCommand> : NoaDebugger.DebugCommand.CommandPanelBase<TCommand>
        {
            /*0x380d83c*/ CommandPanelMethodBase(NoaDebugger.DebugCommandPanel panel);
            /*0x380cb08*/ void OnClick();
        }

        class CommandPanelNumericInputPropertyBase<TCommand, TNumericType> : NoaDebugger.DebugCommand.CommandPanelBase<TCommand>
        {
            /*0x0*/ UnityEngine.UI.LayoutElement _layoutElement;
            /*0x0*/ float _horizontalPadding;
            /*0x0*/ TNumericType _tmpValue;
            /*0x0*/ TNumericType _beginDragValue;

            /*0x380d83c*/ CommandPanelNumericInputPropertyBase(NoaDebugger.DebugCommandPanel panel);
            /*0x380e050*/ void OnUpdateWidth(float maxContentWidth);
            /*0x380cb08*/ void Refresh();
            /*0x380d83c*/ void OnEndInputEdit(string text);
            /*0x380cb08*/ void _OnBeginDrag();
            /*0x380e050*/ void _OnSliding(float distance);
            /*0x380cb08*/ void _OnDownArrowButton();
            /*0x380d83c*/ void _OnExitArrowButton(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x380cb08*/ void _OnClickLeftArrowButton();
            /*0x380cb08*/ void _DecrementValue();
            /*0x380cb08*/ void _OnClickRightArrowButton();
            /*0x380cb08*/ void _IncrementValue();
            /*0x3907c14*/ void _FluctuateValue(TNumericType beginValue, int count);
            /*0x380cb08*/ void _SetValue();
            int _DelimitDistance(float distance);
        }

        class CommandPanelSByteProperty : NoaDebugger.DebugCommand.CommandPanelSignedNumberPropertyBase<NoaDebugger.DebugCommand.SBytePropertyCommand, sbyte>
        {
            /*0x73482f4*/ CommandPanelSByteProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x734835c*/ void OnEndInputEdit(string text);
        }

        class CommandPanelShortProperty : NoaDebugger.DebugCommand.CommandPanelSignedNumberPropertyBase<NoaDebugger.DebugCommand.ShortPropertyCommand, short>
        {
            /*0x73483b4*/ CommandPanelShortProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x734841c*/ void OnEndInputEdit(string text);
        }

        class CommandPanelSignedNumberPropertyBase<TCommand, TNumericType> : NoaDebugger.DebugCommand.CommandPanelNumericInputPropertyBase<TCommand, TNumericType>
        {
            /*0x380d83c*/ CommandPanelSignedNumberPropertyBase(NoaDebugger.DebugCommandPanel panel);
        }

        class CommandPanelSimpleInputPropertyBase<TCommand> : NoaDebugger.DebugCommand.CommandPanelBase<TCommand>
        {
            /*0x380d83c*/ CommandPanelSimpleInputPropertyBase(NoaDebugger.DebugCommandPanel panel);
            /*0x380cb08*/ void Refresh();
            /*0x380b9e8*/ string GetValueString();
            /*0x380d83c*/ void OnEndInputEdit(string text);
        }

        class CommandPanelStringProperty : NoaDebugger.DebugCommand.CommandPanelSimpleInputPropertyBase<NoaDebugger.DebugCommand.StringPropertyCommand>
        {
            /*0x28*/ UnityEngine.UI.LayoutElement _layoutElement;
            /*0x30*/ float _horizontalPadding;

            /*0x7348474*/ CommandPanelStringProperty(NoaDebugger.DebugCommandPanel panel, float maxContentWidth);
            /*0x73485f0*/ void OnUpdateWidth(float maxContentWidth);
            /*0x73486d0*/ string GetValueString();
            /*0x73486e8*/ void OnEndInputEdit(string text);
        }

        class CommandPanelUIntProperty : NoaDebugger.DebugCommand.CommandPanelUnsignedNumberPropertyBase<NoaDebugger.DebugCommand.UIntPropertyCommand, uint>
        {
            /*0x7348714*/ CommandPanelUIntProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x734877c*/ void OnEndInputEdit(string text);
        }

        class CommandPanelULongProperty : NoaDebugger.DebugCommand.CommandPanelUnsignedNumberPropertyBase<NoaDebugger.DebugCommand.ULongPropertyCommand, ulong>
        {
            /*0x73487d4*/ CommandPanelULongProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x734883c*/ void OnEndInputEdit(string text);
        }

        class CommandPanelUnsignedNumberPropertyBase<TCommand, TNumericType> : NoaDebugger.DebugCommand.CommandPanelNumericInputPropertyBase<TCommand, TNumericType>
        {
            /*0x380d83c*/ CommandPanelUnsignedNumberPropertyBase(NoaDebugger.DebugCommandPanel panel);
            char ValidateUnsignedInput(string text, int charIndex, char addedChar);
        }

        class CommandPanelUShortProperty : NoaDebugger.DebugCommand.CommandPanelUnsignedNumberPropertyBase<NoaDebugger.DebugCommand.UShortPropertyCommand, ushort>
        {
            /*0x7348894*/ CommandPanelUShortProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x73488fc*/ void OnEndInputEdit(string text);
        }

        interface ICommandPanel
        {
            /*0x380e050*/ void OnUpdateWidth(float maxContentWidth);
            /*0x380d83c*/ void UpdateData(NoaDebugger.DebugCommand.ICommand command);
            /*0x380cb08*/ void Refresh();
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 01E2C93279CF2C9847FEBFCABE5214AD1045A799F1A006EEE582A8278C31BE51;
    static /*0xa063*/ <PrivateImplementationDetails> 140B247A531B2710CADC0A5AE05204E459BA9C548871BD988BECCAA00BDD2EFE;
    static /*0xa093*/ <PrivateImplementationDetails> 1742BC37026663CB2D2B245160749D7C81B3EA518594DC8B63D5D07CB038C3A1;
    static /*0xa0d7*/ <PrivateImplementationDetails> C8C4CB20711FA1F45BB6C0BAE78DD26851ABD93895A8FA266CCA1818207F15C0;
    static /*0xa0eb*/ <PrivateImplementationDetails> CC8EB2D05D557C71A482571288C168C0BAD328B9603FB62F0641F5E6058E8AFF;
    static /*0xa133*/ <PrivateImplementationDetails> CDE023DA9843AC4329B1B24F3552561E3B53225BC9511F76CC4449F59EA5451F;

    struct __StaticArrayInitTypeSize=20
    {
    }

    struct __StaticArrayInitTypeSize=48
    {
    }

    struct __StaticArrayInitTypeSize=68
    {
    }

    struct __StaticArrayInitTypeSize=72
    {
    }

    struct __StaticArrayInitTypeSize=22487
    {
    }

    struct __StaticArrayInitTypeSize=41059
    {
    }
}
