class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x72c1a9c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x72c1b90*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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

        /*0x72c1cf8*/ ApiLogCollectorModel();
        /*0x72c1b98*/ void add_OnLogReceived(UnityEngine.Events.UnityAction<NoaDebugger.ApiLog> value);
        /*0x72c1c48*/ void remove_OnLogReceived(UnityEngine.Events.UnityAction<NoaDebugger.ApiLog> value);
        /*0x72c1e04*/ void OnCollectEnabled();
        /*0x72c1e84*/ void OnCollectDisabled();
        /*0x72c1f04*/ void _ReceiveLog(NoaDebugger.ApiLog log);
    }

    class ApplicationOperateModel : NoaDebugger.ModelBase
    {
        /*0x10*/ System.Func<bool> <OnTransition>k__BackingField;
        /*0x18*/ UnityEngine.Events.UnityAction <OnFinishTransition>k__BackingField;

        /*0x72c20b8*/ ApplicationOperateModel();
        /*0x72c1f20*/ System.Func<bool> get_OnTransition();
        /*0x72c1f28*/ void set_OnTransition(System.Func<bool> value);
        /*0x72c1f30*/ UnityEngine.Events.UnityAction get_OnFinishTransition();
        /*0x72c1f38*/ void set_OnFinishTransition(UnityEngine.Events.UnityAction value);
        /*0x72c1f40*/ void TransitionToInitialScene();
        /*0x72c2038*/ System.Collections.IEnumerator _LoadFirstScene();

        class <_LoadFirstScene>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ UnityEngine.AsyncOperation <asyncLoad>5__2;

            /*0x72c2090*/ <_LoadFirstScene>d__9(int <>1__state);
            /*0x72c20c8*/ void System.IDisposable.Dispose();
            /*0x72c20cc*/ bool MoveNext();
            /*0x72c2194*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72c219c*/ void System.Collections.IEnumerator.Reset();
            /*0x72c21d4*/ object System.Collections.IEnumerator.get_Current();
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

        static /*0x72c2a80*/ BatteryModel();
        static /*0x72c2a64*/ bool CanProfiling();
        /*0x72c21fc*/ BatteryModel();
        /*0x72c21dc*/ NoaDebugger.BatteryInfo get_BatteryInfo();
        /*0x72c21e4*/ void set_BatteryInfo(NoaDebugger.BatteryInfo value);
        /*0x72c21ec*/ UnityEngine.Events.UnityAction get_OnBatteryInfoChanged();
        /*0x72c21f4*/ void set_OnBatteryInfoChanged(UnityEngine.Events.UnityAction value);
        /*0x72c250c*/ void Dispose();
        /*0x72c2568*/ void _OnUpdate();
        /*0x72c22a0*/ void _ResetBatteryInfo();
        /*0x72c2a28*/ void ChangeBatteryProfilingState(bool isProfiling);
        /*0x72c23f4*/ void _HandleOnUpdate(bool isProfiling);

        class BatteryLevelData
        {
            /*0x10*/ float _batteryLevelPercent;
            /*0x18*/ System.DateTime _checkTime;

            /*0x72c2a14*/ BatteryLevelData();
        }
    }

    class ClipboardModel : NoaDebugger.ModelBase
    {
        static /*0x72c2b60*/ void Initialize();
        static /*0x72c2b64*/ void _Copy(string input);
        static /*0x72c2cbc*/ void Copy(string input);
        /*0x72c2cc0*/ ClipboardModel();
    }

    class ConsoleLogCollectorModel : NoaDebugger.LogCollectorModel
    {
        /*0x20*/ UnityEngine.Events.UnityAction<string, string, UnityEngine.LogType> OnLogReceived;

        /*0x72c2e28*/ ConsoleLogCollectorModel();
        /*0x72c2cc8*/ void add_OnLogReceived(UnityEngine.Events.UnityAction<string, string, UnityEngine.LogType> value);
        /*0x72c2d78*/ void remove_OnLogReceived(UnityEngine.Events.UnityAction<string, string, UnityEngine.LogType> value);
        /*0x72c2e88*/ void OnCollectEnabled();
        /*0x72c2f2c*/ void OnCollectDisabled();
        /*0x72c2fd0*/ void _ReceiveLog(string logString, string stackTrace, UnityEngine.LogType type);
    }

    class CustomInformationModel : NoaDebugger.ModelBase
    {
        /*0x10*/ System.Collections.Generic.List<NoaDebugger.InformationCustomGroup> _allGroups;

        /*0x72c2fec*/ CustomInformationModel();
        /*0x72c3074*/ void AddGroup(string groupName, string displayName, int order);
        /*0x72c316c*/ bool _ExistsGroup(string name);
        /*0x72c3250*/ void _AddGroup(string name, string displayName, int order);
        /*0x72c33e4*/ bool _ExistsKey(string keyName);
        /*0x72c3400*/ bool TryGetValue(string keyName, ref string val);
        /*0x72c3778*/ void AddKeyValues(string groupName, string keyName, System.Func<string> getValue, string displayName, int order);
        /*0x72c394c*/ void _AddKeyValues(NoaDebugger.InformationCustomGroup groupInfo, string keyName, System.Func<string> getValue, string displayName, int order);
        /*0x72c38fc*/ NoaDebugger.InformationCustomGroup _GetOrCreateGroup(string name, string displayName, int order);
        /*0x72c3a8c*/ NoaDebugger.InformationCustomGroup GetGroup(string name);
        /*0x72c3b7c*/ System.Collections.Generic.List<NoaDebugger.InformationCustomGroup> GetAllGroups();
        /*0x72c3b84*/ void RemoveKeyValue(string keyName);
        /*0x72c3e20*/ void RemoveGroup(string groupName);
        /*0x72c3f68*/ void RemoveAll();
        /*0x72c3fd8*/ NoaDebugger.IKeyValueParser[] CreateExportData();

        class <>c
        {
            static /*0x0*/ NoaDebugger.CustomInformationModel.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.InformationCustomGroup, int> <>9__15_0;
            static /*0x10*/ System.Func<NoaDebugger.InformationCustomKeyValue, int> <>9__15_1;

            static /*0x72c49e8*/ <>c();
            /*0x72c4a50*/ <>c();
            /*0x72c4a58*/ int <CreateExportData>b__15_0(NoaDebugger.InformationCustomGroup g);
            /*0x72c4a70*/ int <CreateExportData>b__15_1(NoaDebugger.InformationCustomKeyValue kv);
        }

        class <>c__DisplayClass10_0
        {
            /*0x10*/ string name;

            /*0x72c3b74*/ <>c__DisplayClass10_0();
            /*0x72c4a88*/ bool <GetGroup>b__0(NoaDebugger.InformationCustomGroup g);
        }

        class <>c__DisplayClass12_0
        {
            /*0x10*/ string keyName;
            /*0x18*/ System.Predicate<NoaDebugger.InformationCustomKeyValue> <>9__0;

            /*0x72c3e18*/ <>c__DisplayClass12_0();
            /*0x72c4aac*/ bool <RemoveKeyValue>b__0(NoaDebugger.InformationCustomKeyValue kv);
        }

        class <>c__DisplayClass13_0
        {
            /*0x10*/ string groupName;

            /*0x72c3f60*/ <>c__DisplayClass13_0();
            /*0x72c4ad0*/ bool <RemoveGroup>b__0(NoaDebugger.InformationCustomGroup g);
        }

        class <>c__DisplayClass3_0
        {
            /*0x10*/ string name;

            /*0x72c33dc*/ <>c__DisplayClass3_0();
            /*0x72c4af4*/ bool <_ExistsGroup>b__0(NoaDebugger.InformationCustomGroup g);
        }

        class <>c__DisplayClass6_0
        {
            /*0x10*/ string keyName;
            /*0x18*/ System.Predicate<NoaDebugger.InformationCustomKeyValue> <>9__0;
            /*0x20*/ System.Func<NoaDebugger.InformationCustomKeyValue, bool> <>9__1;

            /*0x72c3770*/ <>c__DisplayClass6_0();
            /*0x72c4b18*/ bool <TryGetValue>b__0(NoaDebugger.InformationCustomKeyValue kv);
            /*0x72c4b3c*/ bool <TryGetValue>b__1(NoaDebugger.InformationCustomKeyValue g);
        }
    }

    class DataUnitConverterModel
    {
        static /*0x0*/ string[] SizeUnits;

        static /*0x72c4cd0*/ DataUnitConverterModel();
        static /*0x72c4b60*/ float ByteToMB(float byteValue);
        static /*0x72c4b74*/ float KBToByte(float kbValue);
        static /*0x72c4b84*/ float MBToByte(float mbValue);
        static /*0x72c4b98*/ string ToHumanReadableBytes(long bytes);
    }

    class DeviceModel : NoaDebugger.ModelBase
    {
        static /*0x72c4e50*/ bool get_IsUserAgentAndroid();
        static /*0x72c4e88*/ bool get_IsUserAgentWindows();
        static /*0x72c4eec*/ bool get_IsUserAgentMac();
        static /*0x72c4f50*/ bool get_IsUserAgentIOS();
        static /*0x72c4f80*/ bool get_IsWindows();
        static /*0x72c500c*/ bool get_IsMac();
        static /*0x72c5094*/ bool get_IsAndroid();
        static /*0x72c511c*/ bool get_IsIOS();
        /*0x72c51a4*/ DeviceModel();
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

        static /*0x72c5838*/ FpsModel();
        /*0x72c51cc*/ FpsModel();
        /*0x72c51ac*/ NoaDebugger.FpsInfo get_FpsInfo();
        /*0x72c51b4*/ void set_FpsInfo(NoaDebugger.FpsInfo value);
        /*0x72c51bc*/ UnityEngine.Events.UnityAction get_OnFpsInfoChanged();
        /*0x72c51c4*/ void set_OnFpsInfoChanged(UnityEngine.Events.UnityAction value);
        /*0x72c5534*/ void Dispose();
        /*0x72c55a4*/ void _OnUpdate();
        /*0x72c5358*/ void _ResetFpsInfo();
        /*0x72c56e8*/ void _ResetCounter();
        /*0x72c56f0*/ void _OnChangedBackgroundState(bool isBackground);
        /*0x72c5768*/ void ChangeFpsProfilingState(bool isProfiling);
        /*0x72c5438*/ void _HandleOnUpdate(bool isProfiling);
    }

    class FrameSteppingModel
    {
        static /*0x0*/ float PressActionFirstInterval;
        static /*0x4*/ float PressActionSecondInterval;
        static /*0x8*/ float FrameTimeSecondsAt60FPS;
        static /*0xc*/ bool _isStepping;

        static /*0x72c5a40*/ FrameSteppingModel();
        static /*0x72c58e8*/ bool get_IsApplyGameSpeedChange();
        static /*0x72c5908*/ System.Collections.IEnumerator FrameStepping(System.Action onFrameStepping);
        static /*0x72c599c*/ System.Collections.IEnumerator StepFrame(System.Action onStepFrame, float timeScale);

        class <FrameStepping>d__6 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ System.Action onFrameStepping;

            /*0x72c5974*/ <FrameStepping>d__6(int <>1__state);
            /*0x72c5aa4*/ void System.IDisposable.Dispose();
            /*0x72c5aa8*/ bool MoveNext();
            /*0x72c5ba8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72c5bb0*/ void System.Collections.IEnumerator.Reset();
            /*0x72c5be8*/ object System.Collections.IEnumerator.get_Current();
        }

        class <StepFrame>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ float timeScale;
            /*0x28*/ System.Action onStepFrame;

            /*0x72c5a18*/ <StepFrame>d__7(int <>1__state);
            /*0x72c5bf0*/ void System.IDisposable.Dispose();
            /*0x72c5bf4*/ bool MoveNext();
            /*0x72c5d5c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72c5d64*/ void System.Collections.IEnumerator.Reset();
            /*0x72c5d9c*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class FrameTimeModel : NoaDebugger.ModelBase
    {
        static /*0x0*/ string OnChangedBackgroundState;
        /*0x10*/ NoaDebugger.FrameTimeInfo <FrameTimeInfo>k__BackingField;
        /*0x18*/ UnityEngine.Events.UnityAction <OnFrameTimeInfoChanged>k__BackingField;
        /*0x20*/ bool _isSuspended;
        /*0x21*/ bool _isResumed;

        static /*0x72c64f0*/ FrameTimeModel();
        /*0x72c5dbc*/ FrameTimeModel();
        /*0x72c5da4*/ NoaDebugger.FrameTimeInfo get_FrameTimeInfo();
        /*0x72c5dac*/ UnityEngine.Events.UnityAction get_OnFrameTimeInfoChanged();
        /*0x72c5db4*/ void set_OnFrameTimeInfoChanged(UnityEngine.Events.UnityAction value);
        /*0x72c62b0*/ void Dispose();
        /*0x72c63b8*/ void ToggleEnabled(bool isEnabled);
        /*0x72c6470*/ void ToggleActive(bool isActive);
        /*0x72c5fc0*/ void OnToggleEnabled(bool isEnabled);
        /*0x72c613c*/ void OnToggleActive(bool isActive);
        /*0x72c6478*/ void OnUpdateFrameTime(double updateMilliseconds, double renderingMilliseconds, double othersMilliseconds);
        /*0x72c64d8*/ void OnBackgroundStateChanged(bool isBackground);
    }

    class GameSpeedModel
    {
        static /*0x0*/ float _gameSpeed;

        static /*0x72c6fa4*/ GameSpeedModel();
        static /*0x72c655c*/ float get_GameSpeed();
        static /*0x72c65b4*/ void set_GameSpeed(float value);
        static /*0x72c667c*/ float get_MinGameSpeed();
        static /*0x72c6688*/ float get_MaxGameSpeed();
        static /*0x72c66a8*/ float get_DefaultGameSpeed();
        static /*0x72c66b0*/ bool get_IsGamePlaying();
        static /*0x72c66cc*/ void Initialize();
        static /*0x72c6808*/ void Reset();
        static /*0x72c68c4*/ void Increment();
        static /*0x72c6b0c*/ void Maximize();
        static /*0x72c6bd8*/ void Decrement();
        static /*0x72c6e0c*/ void Minimize();
        static /*0x72c6ecc*/ void Pause();
        static /*0x72c6f1c*/ void Resume();
        static /*0x72c67c4*/ void _ApplyGameSpeed(float gameSpeed);
    }

    class HierarchyModel : NoaDebugger.ModelBase
    {
        /*0x10*/ System.Collections.Generic.HashSet<int> _openObjectHashSet;
        /*0x18*/ System.Collections.Generic.HashSet<int> _checkedHashSet;
        /*0x20*/ int _selectObjectHashCode;
        /*0x28*/ NoaDebugger.HierarchyGameObjectEntry _selectObjectEntry;

        /*0x72c955c*/ HierarchyModel();
        /*0x72c6ff0*/ System.Collections.Generic.List<UnityEngine.SceneManagement.Scene> _GetScenes();
        /*0x72c712c*/ UnityEngine.SceneManagement.Scene _GetDontDestroyScene();
        /*0x72c71d4*/ System.Collections.Generic.List<UnityEngine.Transform> _GetTransformsInScene(UnityEngine.SceneManagement.Scene scene);
        /*0x72c730c*/ System.ValueTuple<NoaDebugger.HierarchyModel.HierarchyInformation, NoaDebugger.HierarchyGameObjectEntry> GetHierarchy();
        /*0x72c7804*/ System.Collections.Generic.List<NoaDebugger.HierarchyGameObjectEntry> _CreateGameObjectEntryList(System.Collections.Generic.List<UnityEngine.Transform> transforms, ref int goCount);
        /*0x72c7d90*/ NoaDebugger.HierarchyGameObjectEntry _CreateGameObjectEntry(UnityEngine.Transform transform, ref int goCount);
        /*0x72c8274*/ void AddOpenObjectHash(int hashCode);
        /*0x72c82cc*/ void RemoveOpenObjectHash(int hashCode);
        /*0x72c7a10*/ bool _ContainsOpenObjectHash(int hashCode);
        /*0x72c7aa0*/ void _CleaningOpenObjectHash();
        /*0x72c8324*/ void SetSelectObjectHashCode(int hashCode);
        /*0x72c832c*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> GetGameObjectDetailIEntryList(UnityEngine.GameObject gameObject);
        /*0x72c856c*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> _GetGameObjectDetailList(UnityEngine.GameObject gameObject);
        /*0x72c8940*/ NoaDebugger.GameObjectDetailEntry _GetComponentDetail(UnityEngine.Component component);
        /*0x72c8d04*/ NoaDebugger.GameObjectDetailEntry _GetComponentProperty(System.Reflection.PropertyInfo propertyInfo, UnityEngine.Component component);
        /*0x72c8fb4*/ NoaDebugger.GameObjectDetailEntry _GetComponentField(System.Reflection.FieldInfo fieldInfo, UnityEngine.Component component);
        /*0x72c9328*/ NoaDebugger.GameObjectDetailEntry _GetAttachNameFromObject(System.Reflection.FieldInfo field, object obj);

        class HierarchyInformation
        {
            /*0x10*/ System.Collections.Generic.List<NoaDebugger.HierarchyGameObjectEntry> _hierarchySceneList;
            /*0x18*/ int _objectNum;

            /*0x72c77fc*/ HierarchyInformation();
        }

        class <>c
        {
            static /*0x0*/ NoaDebugger.HierarchyModel.<> <>9;
            static /*0x8*/ System.Func<UnityEngine.GameObject, UnityEngine.Transform> <>9__6_0;

            static /*0x72c9608*/ <>c();
            /*0x72c9670*/ <>c();
            /*0x72c9678*/ UnityEngine.Transform <_GetTransformsInScene>b__6_0(UnityEngine.GameObject go);
        }
    }

    class LocalDataExportModel : NoaDebugger.ModelBase
    {
        static /*0x72c9690*/ void ExportText(string fileName, string text, UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo> onCompleted);
        /*0x72c9774*/ LocalDataExportModel();

        class <>c__DisplayClass0_0
        {
            /*0x10*/ UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo> onCompleted;

            /*0x72c976c*/ <>c__DisplayClass0_0();
            /*0x72c977c*/ void <ExportText>b__0(NoaDebugger.FileDownloader.DownloadInfo info);
        }
    }

    class LogCollectorModel : NoaDebugger.ModelBase
    {
        /*0x10*/ string _prefKey;
        /*0x18*/ bool <IsCollecting>k__BackingField;

        /*0x72c1d58*/ LogCollectorModel(string prefKey);
        /*0x72c9798*/ void set_IsCollecting(bool value);
        /*0x72c97a4*/ bool get_IsCollecting();
        /*0x72c9850*/ void ToggleCollect(bool isCollecting);
        /*0x72c9874*/ void OnCollectEnabled();
        /*0x72c9878*/ void OnCollectDisabled();
        /*0x72c97ac*/ void OnCollectToggled();
        /*0x72c987c*/ void Destroy();
    }

    class LogModel
    {
        static string DEBUG_SYMBOL = "NOA_DEBUGGER_DEBUG";

        static /*0x72c9888*/ void DebugLog(string message);
        static /*0x72c9914*/ void DebugLog(object message);
        static /*0x72c99a0*/ void DebugLogWarning(string message);
        static /*0x72c9a2c*/ void DebugLogWarning(string message, UnityEngine.Object context);
        static /*0x72c9ac0*/ void ThrowException(string message);
        static /*0x72c9b04*/ void Log(object message);
        static /*0x72c9b90*/ void LogWarning(string message);
        static /*0x72c2c30*/ void LogError(object message);
        static /*0x72c9c1c*/ void Log(object message, UnityEngine.Object context);
        static /*0x72c9cb0*/ void LogWarning(string message, UnityEngine.Object context);
        static /*0x72c9d44*/ void LogError(string message, UnityEngine.Object context);
        static /*0x72c9dd8*/ void CollectNoaDebuggerErrorLog(string message, string stackTrace);
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

        static /*0x72cb848*/ MemoryModel();
        static /*0x72c9fac*/ long AndroidCurrentMemoryByte();
        static /*0x72caa50*/ void UpdeteCurrentMemory();
        static /*0x72caae4*/ System.Nullable<long> _GetCurrentNativeMemoryByte();
        static /*0x72cb4b4*/ float GetRoundedMemoryMB(long memByte);
        /*0x72cab60*/ MemoryModel();
        /*0x72cab40*/ NoaDebugger.MemoryInfo get_MemoryInfo();
        /*0x72cab48*/ void set_MemoryInfo(NoaDebugger.MemoryInfo value);
        /*0x72cab50*/ UnityEngine.Events.UnityAction get_OnMemoryInfoChanged();
        /*0x72cab58*/ void set_OnMemoryInfoChanged(UnityEngine.Events.UnityAction value);
        /*0x72cae44*/ void Dispose();
        /*0x72caea0*/ void _OnUpdate();
        /*0x72caf70*/ void _SetUnityMemoryInfo();
        /*0x72cb110*/ void _SetNativeMemoryInfo();
        /*0x72cb314*/ void _SetMonoMemoryInfo();
        /*0x72cb584*/ void _ResetMemoryInfo();
        /*0x72cb608*/ void ChangeProfilingState(bool isProfiling);
        /*0x72cb6d8*/ void ChangeGraphShowingState(bool isGraphShowing);
        /*0x72cb790*/ void ChangeProfilingType(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
        /*0x72cad48*/ void _HandleOnUpdate(bool isProfiling);

        class <>c
        {
            static /*0x0*/ NoaDebugger.MemoryModel.<> <>9;
            static /*0x8*/ System.Func<long> <>9__3_1;

            static /*0x72cb8b8*/ <>c();
            /*0x72cb920*/ <>c();
            /*0x72cb928*/ long <UpdeteCurrentMemory>b__3_1();
        }

        class <>c__DisplayClass3_0
        {
            /*0x10*/ long memory;

            /*0x72cb974*/ <>c__DisplayClass3_0();
            /*0x72cb97c*/ void <UpdeteCurrentMemory>b__0(object _);
        }

        struct <UpdeteCurrentMemory>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
            /*0x38*/ NoaDebugger.MemoryModel.<> <>8__1;
            /*0x40*/ System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<long> <>u__1;

            /*0x72cba2c*/ void MoveNext();
            /*0x72cbe6c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
        }
    }

    class ModelBase
    {
        /*0x72c20c0*/ ModelBase();
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

        static /*0x72cc698*/ RenderingModel();
        /*0x72cbe98*/ RenderingModel();
        /*0x72cbe78*/ NoaDebugger.RenderingInfo get_RenderingInfo();
        /*0x72cbe80*/ void set_RenderingInfo(NoaDebugger.RenderingInfo value);
        /*0x72cbe88*/ UnityEngine.Events.UnityAction get_OnRenderingInfoChanged();
        /*0x72cbe90*/ void set_OnRenderingInfoChanged(UnityEngine.Events.UnityAction value);
        /*0x72cc2e4*/ void Dispose();
        /*0x72cc380*/ void _OnUpdate();
        /*0x72cc384*/ void _OnUpdateRenderingCheck();
        /*0x72cc458*/ void ChangeProfilingState(bool isProfiling);
        /*0x72cc528*/ void ChangeGraphShowingState(bool isGraphShowing);
        /*0x72cc5e0*/ void SwitchGraphTarget(NoaDebugger.RenderingGraphTarget target);
        /*0x72cc164*/ void _HandleOnUpdate(bool isProfiling);
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

        static /*0x72cdab0*/ SnapshotModel();
        /*0x72cc724*/ SnapshotModel();
        /*0x72cc704*/ NoaDebugger.SnapshotModel.SnapshotInformation get_SnapshotInfo();
        /*0x72cc70c*/ void set_SnapshotInfo(NoaDebugger.SnapshotModel.SnapshotInformation value);
        /*0x72cc714*/ UnityEngine.Events.UnityAction get_OnTimeDataUpdated();
        /*0x72cc71c*/ void set_OnTimeDataUpdated(UnityEngine.Events.UnityAction value);
        /*0x72cc840*/ void Dispose();
        /*0x72cc89c*/ void SetUpdateAction();
        /*0x72cc950*/ void DeleteUpdateAction();
        /*0x72cc9ac*/ void _OnUpdate();
        /*0x72cc804*/ void UpdateProfilingStartTime();
        /*0x72ccacc*/ void UpdateProfilingElapsedTime();
        /*0x72ccad0*/ void ChangeComparisonState(bool forceUpdate, bool isComparison);
        /*0x72ccb08*/ void InsertLog(NoaDebugger.ProfilerSnapshotData snapshotData, string label, System.Nullable<UnityEngine.Color> backgroundColor, System.Collections.Generic.Dictionary<string, NoaDebugger.NoaSnapshotCategory> additionalInfo);
        /*0x72ccf74*/ void RemoveAtLog(int index);
        /*0x72cd360*/ void ClearAllLog();
        /*0x72cd3d4*/ void ClearAllLogSelected();
        /*0x72cd660*/ void ClearAllLogChecked();
        /*0x72ccea8*/ void _OnLogInfoUpdated();
        /*0x72cd7c8*/ void UpdateLogLabel(int logId, string text);
        /*0x72cd8d0*/ void SetHighlightLogId(int logId);
        /*0x72cd914*/ void SetSelectedLogId(int logId);
        /*0x72cd048*/ void SetCheckedLogId(int logId);
        /*0x72cd544*/ void _SetLogHighlight(int logId, bool isHighlighted);
        /*0x72cdb30*/ bool <SetCheckedLogId>b__32_0(NoaDebugger.SnapshotLogRecordInformation x);
        /*0x72cdb54*/ bool <SetCheckedLogId>b__32_1(NoaDebugger.SnapshotLogRecordInformation x);

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

            /*0x72cc7fc*/ SnapshotInformation();
        }

        class <>c__DisplayClass29_0
        {
            /*0x10*/ int logId;

            /*0x72cd8c8*/ <>c__DisplayClass29_0();
            /*0x72cdb78*/ bool <UpdateLogLabel>b__0(NoaDebugger.SnapshotLogRecordInformation x);
        }

        class <>c__DisplayClass33_0
        {
            /*0x10*/ int logId;

            /*0x72cdaa8*/ <>c__DisplayClass33_0();
            /*0x72cdb9c*/ bool <_SetLogHighlight>b__0(NoaDebugger.SnapshotLogRecordInformation x);
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

        /*0x72cdc20*/ SystemInformationModel();
        /*0x72cdbc0*/ void set_ApplicationInfo(NoaDebugger.ApplicationInfo value);
        /*0x72cdbc8*/ NoaDebugger.ApplicationInfo get_ApplicationInfo();
        /*0x72cdbd0*/ void set_DeviceInfo(NoaDebugger.DeviceInfo value);
        /*0x72cdbd8*/ NoaDebugger.DeviceInfo get_DeviceInfo();
        /*0x72cdbe0*/ void set_CpuInfo(NoaDebugger.CpuInfo value);
        /*0x72cdbe8*/ NoaDebugger.CpuInfo get_CpuInfo();
        /*0x72cdbf0*/ void set_GpuInfo(NoaDebugger.GpuInfo value);
        /*0x72cdbf8*/ NoaDebugger.GpuInfo get_GpuInfo();
        /*0x72cdc00*/ void set_SystemMemoryInfo(NoaDebugger.SystemMemoryInfo value);
        /*0x72cdc08*/ NoaDebugger.SystemMemoryInfo get_SystemMemoryInfo();
        /*0x72cdc10*/ void set_DisplayInfo(NoaDebugger.DisplayInfo value);
        /*0x72cdc18*/ NoaDebugger.DisplayInfo get_DisplayInfo();
        /*0x72cde24*/ void OnUpdate();
        /*0x72cde40*/ NoaDebugger.IKeyValueParser[] CreateExportData();
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

        static /*0x72ce7b4*/ TargetFrameRateModel();
        /*0x72ce154*/ TargetFrameRateModel();
        /*0x72ce17c*/ string[] GetChoicesArrayIfNeedUpdate();
        /*0x72ce57c*/ int GetCurrentIndex();
        /*0x72ce624*/ void SetTargetFrameRate(int targetFrameRateIndex);
        /*0x72ce6b4*/ string _GetTargetFrameRateText(int targetFrameRate);
        /*0x72ce780*/ void Dispose();
        /*0x72ce49c*/ bool <GetChoicesArrayIfNeedUpdate>g__addListUnique|8_0(int value);

        class <>c
        {
            static /*0x0*/ NoaDebugger.TargetFrameRateModel.<> <>9;
            static /*0x8*/ System.Func<int, int> <>9__8_1;

            static /*0x72ce8ac*/ <>c();
            /*0x72ce914*/ <>c();
            /*0x72ce91c*/ int <GetChoicesArrayIfNeedUpdate>b__8_1(int x);
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

        static /*0x72cf8a4*/ ThermalModel();
        static /*0x72cee58*/ bool CanProfiling();
        /*0x72ce944*/ ThermalModel();
        /*0x72ce924*/ NoaDebugger.ThermalInfo get_ThermalInfo();
        /*0x72ce92c*/ void set_ThermalInfo(NoaDebugger.ThermalInfo value);
        /*0x72ce934*/ UnityEngine.Events.UnityAction get_OnThermalInfoChanged();
        /*0x72ce93c*/ void set_OnThermalInfoChanged(UnityEngine.Events.UnityAction value);
        /*0x72cebf0*/ void Dispose();
        /*0x72cec4c*/ void _OnUpdate();
        /*0x72ce9e8*/ void _ResetThermalInfo();
        /*0x72cee1c*/ void ChangeProfilingState(bool isProfiling);
        /*0x72ceadc*/ void _HandleOnUpdate(bool isProfiling);
        /*0x72ceedc*/ float GetCurrentTemperature();
        /*0x72ced20*/ void _OnUpdateThermalInfo();
    }

    class TimeUnitConverterModel
    {
        static /*0x72c2a1c*/ int MinutesToSeconds(int minutes);
        static /*0x72c2b50*/ float SecondsToMinutes(float seconds);
        /*0x72cf928*/ TimeUnitConverterModel();
    }

    class ToolDetailModel : NoaDebugger.ModelBase
    {
        static string OPERATIONAL_VALUE = "operational";
        /*0x10*/ NoaDebugger.ToolDetailInformation <ToolDetailInformation>k__BackingField;
        /*0x18*/ NoaDebugger.NoaDebuggerInfo _noaDebuggerInfo;

        /*0x72cf940*/ ToolDetailModel();
        /*0x72cf930*/ void set_ToolDetailInformation(NoaDebugger.ToolDetailInformation value);
        /*0x72cf938*/ NoaDebugger.ToolDetailInformation get_ToolDetailInformation();
        /*0x72cf9cc*/ void _LoadAsset();
        /*0x72cfb34*/ void _LoadShortcutKeySettings();
        /*0x72cfa88*/ void SetOperatingEnv(string osVersion, NoaDebugger.ToolDetailModel.OSType osType, string device, string unityVersion);
        /*0x72cfa70*/ string get_OsVersion();
        /*0x72cfa68*/ NoaDebugger.ToolDetailModel.OSType get_OsType();
        /*0x72cfdc0*/ bool _CheckSupported(string osVersion, NoaDebugger.ToolDetailModel.OSType osType, string device, string unityVersion);
        /*0x72cfe7c*/ string _SupportedVersionText(string osVersion, NoaDebugger.ToolDetailModel.OSType osType);
        /*0x72cffc8*/ string _GetSupportedBrowserText(string osVersion);
        /*0x72d0214*/ string _SupportedBrowserTextFromSupportInfo(NoaDebugger.SupportBrowserInfo[] supportedBrowsersInfo, bool hasMobile);

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

            static /*0x72d04b0*/ <>c();
            /*0x72d0518*/ <>c();
            /*0x72d0520*/ string <_SupportedBrowserTextFromSupportInfo>b__18_0(NoaDebugger.SupportBrowserInfo x);
            /*0x72d0538*/ string <_SupportedBrowserTextFromSupportInfo>b__18_1(System.Linq.IGrouping<string, NoaDebugger.SupportBrowserInfo> browserGroup);
            /*0x72d072c*/ string <_SupportedBrowserTextFromSupportInfo>b__18_2(NoaDebugger.SupportBrowserInfo x);
        }
    }

    class ToolDetailInformation
    {
        /*0x10*/ string _operatingEnv;
        /*0x18*/ System.Collections.Generic.Dictionary<string, string> _shortcutKeyMappings;
        /*0x20*/ string _copyright;

        /*0x72cfdb8*/ ToolDetailInformation();
    }

    class UnityInformationModel : NoaDebugger.ModelBase
    {
        /*0x10*/ NoaDebugger.UnityInfo <UnityInfo>k__BackingField;
        /*0x18*/ NoaDebugger.RuntimeInfo <RuntimeInfo>k__BackingField;
        /*0x20*/ NoaDebugger.FeaturesInfo <FeaturesInfo>k__BackingField;
        /*0x28*/ NoaDebugger.GraphicsInfo <GraphicsInfo>k__BackingField;

        /*0x72d0784*/ UnityInformationModel();
        /*0x72d0744*/ void set_UnityInfo(NoaDebugger.UnityInfo value);
        /*0x72d074c*/ NoaDebugger.UnityInfo get_UnityInfo();
        /*0x72d0754*/ void set_RuntimeInfo(NoaDebugger.RuntimeInfo value);
        /*0x72d075c*/ NoaDebugger.RuntimeInfo get_RuntimeInfo();
        /*0x72d0764*/ void set_FeaturesInfo(NoaDebugger.FeaturesInfo value);
        /*0x72d076c*/ NoaDebugger.FeaturesInfo get_FeaturesInfo();
        /*0x72d0774*/ void set_GraphicsInfo(NoaDebugger.GraphicsInfo value);
        /*0x72d077c*/ NoaDebugger.GraphicsInfo get_GraphicsInfo();
        /*0x72d0924*/ void OnUpdate();
        /*0x72d0964*/ void _ActiveSceneChanged(UnityEngine.SceneManagement.Scene thisScene, UnityEngine.SceneManagement.Scene nextScene);
        /*0x72d0980*/ NoaDebugger.IKeyValueParser[] CreateExportData();
    }

    class UserAgentModel : NoaDebugger.ModelBase
    {
        static /*0x72d0bb4*/ bool get_IsWebGLandiOSorMacSafari();
        static /*0x72c4e80*/ bool IsMatchRegexPattern(string pattern);
        static /*0x72d0bbc*/ bool get_IsMobileBrowser();
        /*0x72d0bc4*/ UserAgentModel();
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

        static /*0x72d3514*/ string CreateLogDetailString(NoaDebugger.ApiLog log);
        static /*0x72d21c0*/ System.Collections.Generic.List<NoaDebugger.IKeyValueParser> AddLogDetailParsers(System.Collections.Generic.List<NoaDebugger.IKeyValueParser> parsers, NoaDebugger.ApiLog logDetail);
        static /*0x72d3ac4*/ string <CreateLogDetailString>g__toHeaderString|57_0(string text);
        /*0x72d3be8*/ ApiLogPresenter();
        /*0x72d0bcc*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x72d0bd4*/ NoaDebugger.LogCollectorModel CreateLogCollectorModel();
        /*0x72d0c88*/ int GetLogCapacity();
        /*0x72d0d64*/ void SetLogPanelInfo(ref NoaDebugger.LogViewLinker.LogPanelInfo logPanelInfo, NoaDebugger.ApiLogEntry log);
        /*0x72d0e10*/ string GetStatusString();
        /*0x72d0ee8*/ void OnClearLog();
        /*0x72d0f74*/ void OnLogCopied(NoaDebugger.ApiLogEntry log, string clipboardText);
        /*0x72d0f90*/ System.Nullable<bool> OnLogDownload(string fileName, string json);
        /*0x72d1144*/ string GetExportFilenamePrefix();
        /*0x72d1184*/ void OnLogSend();
        /*0x72d12d4*/ bool IsRegisteredSend();
        /*0x72d12e4*/ string GetFilterSavePrefsKey();
        /*0x72d133c*/ NoaDebugger.LogOverlaySettingsDefaultGetter _CreateOverlaySettingsDefaultGetter();
        /*0x72d1390*/ string GetOverlayPrefsKey();
        /*0x72d13d0*/ NoaDebugger.KeyValueSerializer CreateLogKeyValueSerializer();
        /*0x72d2964*/ void Init();
        /*0x72d2acc*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x72d2b48*/ void ShowView(UnityEngine.Transform parent);
        /*0x72d2ba0*/ bool GetPinStatus();
        /*0x72d2be8*/ void TogglePin(UnityEngine.Transform parent);
        /*0x72d2c40*/ void InitOverlay(UnityEngine.Transform parent);
        /*0x72d2cb8*/ bool GetSettingsStatus();
        /*0x72d2d00*/ void ToggleOverlaySettings(UnityEngine.Transform parent);
        /*0x72d2d70*/ void AlignmentUI(bool isReverse);
        /*0x72d2dc8*/ void OnHidden();
        /*0x72d2e10*/ void OnToolDispose();
        /*0x72d2e88*/ void _ReceiveLog(NoaDebugger.ApiLog log);
        /*0x72d3348*/ NoaDebugger.ApiLogPresenter.ApiLogAttributes _GetApiLogAttribute(NoaDebugger.ApiLogEntry target, ref int index);
        /*0x72d3498*/ void _SetNotificationStatus(NoaDebugger.ToolNotificationStatus notifyStatus);
        /*0x72d3b30*/ void OnDestroy();

        struct ApiLogAttributes
        {
            /*0x10*/ long _contentSize;
            /*0x18*/ long _responseTimeMilliSeconds;
            /*0x20*/ NoaDebugger.LogType _logType;
            /*0x28*/ long _totalResponseTimeMilliSeconds;
        }

        class ApiLogMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x72d2b40*/ ApiLogMenuInfo();
            /*0x72d3c30*/ string get_Name();
            /*0x72d3c70*/ string get_MenuName();
            /*0x72d3cb0*/ int get_SortNo();
        }

        class <>c
        {
            static /*0x0*/ NoaDebugger.ApiLogPresenter.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.ApiLogEntry, bool> <>9__33_0;
            static /*0x10*/ System.Func<NoaDebugger.ApiLogEntry, bool> <>9__35_0;

            static /*0x72d3cb8*/ <>c();
            /*0x72d3d20*/ <>c();
            /*0x72d3d28*/ bool <OnLogDownload>b__33_0(NoaDebugger.ApiLogEntry log);
            /*0x72d3d6c*/ bool <OnLogSend>b__35_0(NoaDebugger.ApiLogEntry log);
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

        /*0x72d5b94*/ ConsoleLogPresenter();
        /*0x72d3db0*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x72d3db8*/ NoaDebugger.LogCollectorModel CreateLogCollectorModel();
        /*0x72d3e6c*/ void ReceiveLogGenerateStackTraceFirstLine(string logString, string stackTrace, UnityEngine.LogType type);
        /*0x72d43dc*/ void _ReceiveLogGenerateStackTrace(string logString, string stackTrace, UnityEngine.LogType type);
        /*0x72d3ffc*/ void _ReceiveLog(string logString, NoaDebugger.ConsoleLogDetail logDetail, UnityEngine.LogType type, string stackTraceString);
        /*0x72d455c*/ bool _IsMatchLog(NoaDebugger.ConsoleLogEntry target, NoaDebugger.ConsoleLogEntry source);
        /*0x72d4480*/ string _CreateStackTraceString(string stackTrace, UnityEngine.LogType type);
        /*0x72d3f8c*/ bool _IsStackTraceLogType(UnityEngine.LogType logType, UnityEngine.StackTraceLogType stackTraceLogType);
        /*0x72d45d4*/ void _SetNotificationStatus(NoaDebugger.ToolNotificationStatus notifyStatus);
        /*0x72d4650*/ int GetLogCapacity();
        /*0x72d472c*/ void SetLogPanelInfo(ref NoaDebugger.LogViewLinker.LogPanelInfo logPanelInfo, NoaDebugger.ConsoleLogEntry log);
        /*0x72d47d0*/ string GetStatusString();
        /*0x72d47e8*/ void OnClearLog();
        /*0x72d47ec*/ void OnLogCopied(NoaDebugger.ConsoleLogEntry log, string clipboardText);
        /*0x72d4808*/ System.Nullable<bool> OnLogDownload(string fileName, string json);
        /*0x72d49bc*/ string GetExportFilenamePrefix();
        /*0x72d49fc*/ void OnLogSend();
        /*0x72d4b4c*/ bool IsRegisteredSend();
        /*0x72d4b5c*/ string GetFilterSavePrefsKey();
        /*0x72d4bb4*/ NoaDebugger.LogOverlaySettingsDefaultGetter _CreateOverlaySettingsDefaultGetter();
        /*0x72d4c08*/ string GetOverlayPrefsKey();
        /*0x72d4c48*/ NoaDebugger.KeyValueSerializer CreateLogKeyValueSerializer();
        /*0x72d55e8*/ void Init();
        /*0x72d5720*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x72d579c*/ void ShowView(UnityEngine.Transform parent);
        /*0x72d57f4*/ bool GetPinStatus();
        /*0x72d583c*/ void TogglePin(UnityEngine.Transform parent);
        /*0x72d5894*/ void InitOverlay(UnityEngine.Transform parent);
        /*0x72d590c*/ bool GetSettingsStatus();
        /*0x72d5954*/ void ToggleOverlaySettings(UnityEngine.Transform parent);
        /*0x72d59c4*/ void AlignmentUI(bool isReverse);
        /*0x72d5a1c*/ void OnHidden();
        /*0x72d5a64*/ void OnToolDispose();
        /*0x72d5adc*/ void OnDestroy();

        class ConsoleLogMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x72d5794*/ ConsoleLogMenuInfo();
            /*0x72d5bdc*/ string get_Name();
            /*0x72d5c1c*/ string get_MenuName();
            /*0x72d5c5c*/ int get_SortNo();
        }

        class <>c
        {
            static /*0x0*/ NoaDebugger.ConsoleLogPresenter.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.ConsoleLogEntry, bool> <>9__28_0;
            static /*0x10*/ System.Func<NoaDebugger.ConsoleLogEntry, bool> <>9__30_0;

            static /*0x72d5c64*/ <>c();
            /*0x72d5ccc*/ <>c();
            /*0x72d5cd4*/ bool <OnLogDownload>b__28_0(NoaDebugger.ConsoleLogEntry log);
            /*0x72d5d18*/ bool <OnLogSend>b__30_0(NoaDebugger.ConsoleLogEntry log);
        }
    }

    class DownloadDialogPresenter : System.IDisposable
    {
        /*0x10*/ NoaDebugger.DownloadDialog _dialogPrefab;
        /*0x18*/ NoaDebugger.DownloadDialog _dialog;
        /*0x20*/ string _label;
        /*0x28*/ UnityEngine.Events.UnityAction<string, UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo>> OnExecDownload;

        /*0x72d5ebc*/ DownloadDialogPresenter(NoaDebugger.DownloadDialog dialogPrefab);
        /*0x72d5d5c*/ void add_OnExecDownload(UnityEngine.Events.UnityAction<string, UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo>> value);
        /*0x72d5e0c*/ void remove_OnExecDownload(UnityEngine.Events.UnityAction<string, UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo>> value);
        /*0x72d5eec*/ void ShowDialog();
        /*0x72d60f0*/ void _OnChangeExportLabel(string label);
        /*0x72d60f8*/ void _OnExecDownload();
        /*0x72d61a0*/ void _DownloadCompleted(NoaDebugger.FileDownloader.DownloadInfo info);
        /*0x72d6228*/ void Dispose();
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

        static /*0x383e7a0*/ FloatingWindowPresenter();
        /*0x3910ae8*/ FloatingWindowPresenter(TVIEW windowPrefab, string prefsKey, string toolName);
        /*0x3910ae8*/ FloatingWindowPresenter(TVIEW landscapeWindowPrefab, TVIEW portraitWindowPrefab, string prefsKey, string toolName);
        /*0x3813ffc*/ bool get_IsActive();
        /*0x3816710*/ void add_OnInitAction(UnityEngine.Events.UnityAction<TVIEW> value);
        /*0x3816710*/ void remove_OnInitAction(UnityEngine.Events.UnityAction<TVIEW> value);
        /*0x3814a3c*/ UnityEngine.GameObject InstantiateWindow(UnityEngine.Transform parent);
        /*0x3910ae8*/ void ShowWindowView(TLINKER linker);
        /*0x3814a3c*/ UnityEngine.GameObject ToggleActive(UnityEngine.Transform parent);
        /*0x3815cc4*/ void _OnToggleStateChangeToFloatingWindow(bool isShowDefault);
        /*0x38171d8*/ void _OnDragFloatingWindow(UnityEngine.Vector2 screenPos);
        /*0x38171d8*/ void _OnDragEndToFloatingWindow(UnityEngine.Vector2 screenPos);
        /*0x38159dc*/ void _OnCloseToFloatingWindow();
        void _OnRefreshFloatingWindow(bool isAutoRefresh, NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker linker);
        /*0x3816710*/ void _OnLongTapRefreshButton(NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker linker);
        /*0x3815cc4*/ void _OnDeviceOrientation(bool isPortrait);
        /*0x38159dc*/ void DestroyWindow();
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

        /*0x72d765c*/ HierarchyPresenter();
        /*0x72d62e0*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x72d6358*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x72d6360*/ void Init();
        /*0x72d6560*/ void ShowView(UnityEngine.Transform parent);
        /*0x72d6664*/ void _InitView(NoaDebugger.HierarchyView view);
        /*0x72d67c8*/ void _HiddenView();
        /*0x72d685c*/ void _UpdateView();
        /*0x72d67a8*/ void _RefreshHierarchy();
        /*0x72d6c38*/ void _OnHierarchyToggleOpen(int hash, bool isOpen);
        /*0x72d6c5c*/ void _OnDetailLock(bool isLock);
        /*0x72d6c68*/ void _OnSwitchSelectedObjectActive(bool isActive);
        /*0x72d6d40*/ void _SelectGameObject(NoaDebugger.HierarchyGameObjectEntry target);
        /*0x72d6e1c*/ void AlignmentUI(bool isReverse);
        /*0x72d6e40*/ bool GetPinStatus();
        /*0x72d6e90*/ void TogglePin(UnityEngine.Transform parent);
        /*0x72d6ee8*/ void InitFloatingWindow(UnityEngine.Transform parent);
        /*0x72d6f74*/ void _InitFloatingWindow(NoaDebugger.HierarchyFloatingWindowView window);
        /*0x72d7040*/ void OnHidden();
        /*0x72d7044*/ void OnToolDispose();
        /*0x72d6998*/ NoaDebugger.HierarchyViewLinker _CreateLinker();
        /*0x72d7094*/ System.Collections.Generic.List<NoaDebugger.HierarchyPanelData> _CreateHierarchyData();
        /*0x72d738c*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailPanelData> _CreateComponentPanelData();
        /*0x72d75c4*/ void OnDestroy();

        class HierarchyMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x72d6350*/ HierarchyMenuInfo();
            /*0x72d76ec*/ string get_Name();
            /*0x72d772c*/ string get_MenuName();
            /*0x72d776c*/ int get_SortNo();
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

        /*0x72d90b4*/ InformationPresenter();
        /*0x72d7774*/ bool get_IsShowView();
        /*0x72d7808*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x72d7810*/ void Init();
        /*0x72d79e0*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x72d7a58*/ void ShowView(UnityEngine.Transform parent);
        /*0x72d7b28*/ void _InitView(NoaDebugger.InformationView view);
        /*0x72d7dc4*/ void AlignmentUI(bool isReverse);
        /*0x72d7de8*/ void AddCustomGroup(string groupName, string displayName, int order);
        /*0x72d7e00*/ void AddCustomGroupKeyValue(string groupName, string keyName, System.Func<string> getValue, string displayName, int order);
        /*0x72d7e18*/ void RefreshCustomView();
        /*0x72d7e2c*/ string GetCustomValue(string keyName);
        /*0x72d7e54*/ NoaDebugger.NoaCustomInformationGroup GetNoaCustomGroup(string groupName);
        /*0x72d7ee4*/ System.Collections.Generic.List<NoaDebugger.NoaCustomInformationGroup> GetAllCustomGroups();
        /*0x72d814c*/ void RemoveCustomKeyValue(string keyName);
        /*0x72d8164*/ void RemoveCustomGroup(string groupName);
        /*0x72d817c*/ void RemoveAllCustomGroup();
        /*0x72d8194*/ void _OnHidden();
        /*0x72d8234*/ void OnHidden();
        /*0x72d8238*/ void OnToolDispose();
        /*0x72d8278*/ void _OnClickTabButton(NoaDebugger.InformationView.ToggleTabType tabType);
        /*0x72d8280*/ void _OnRefreshButton(bool isAutoRefresh);
        /*0x72d82a0*/ void _OnUpdateAutoRefreshState();
        /*0x72d82c8*/ void _OnAutoRefresh();
        /*0x72d7cb0*/ void _UpdateTabView();
        /*0x72d82ec*/ NoaDebugger.SystemInformationViewLinker _GetSystemViewLinker();
        /*0x72d86e0*/ NoaDebugger.UnityInformationViewLinker _GetUnitySystemViewLinker();
        /*0x72d8918*/ NoaDebugger.CustomInformationViewLinker _GetCustomViewLinker();
        /*0x72d8994*/ void _OnDownload();
        /*0x72d8a84*/ void _OnExecDownload(string label, UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo> completed);
        /*0x72d8c14*/ string _CreateExportJsonString(string label);
        /*0x72d8cd4*/ NoaDebugger.KeyValueSerializer _CreateInformationExportData();
        /*0x72d8f30*/ NoaDebugger.SystemInformation CreateSystemInformation();
        /*0x72d8fac*/ NoaDebugger.UnityInformation CreateUnityInformation();
        /*0x72d901c*/ void OnDestroy();

        class InformationExportData : NoaDebugger.IExportData
        {
            static string EXPORT_FILE_PREFIX = "information";
            /*0x10*/ NoaDebugger.DownloadInfo _downloadData;

            /*0x72d8b88*/ InformationExportData();
            /*0x72d90bc*/ NoaDebugger.DownloadInfo GetDownloadInfo();
        }

        class InformationMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x72d7a50*/ InformationMenuInfo();
            /*0x72d90c4*/ string get_Name();
            /*0x72d9104*/ string get_MenuName();
            /*0x72d9144*/ int get_SortNo();
        }
    }

    interface IMenuInfo
    {
        /*0x38148bc*/ string get_Name();
        /*0x38148bc*/ string get_MenuName();
        /*0x3814574*/ int get_SortNo();
    }

    enum ToolNotificationStatus
    {
        None = 0,
        Error = 1,
    }

    interface INoaDebuggerTool
    {
        /*0x38159dc*/ void Init();
        /*0x3814574*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x38148bc*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x3816710*/ void ShowView(UnityEngine.Transform parent);
        /*0x3815cc4*/ void AlignmentUI(bool isReverse);
        /*0x38159dc*/ void OnHidden();
        /*0x38159dc*/ void OnToolDispose();
    }

    interface INoaDebuggerOverlayTool
    {
        /*0x3813ffc*/ bool GetPinStatus();
        /*0x3816710*/ void TogglePin(UnityEngine.Transform parent);
        /*0x3816710*/ void InitOverlay(UnityEngine.Transform parent);
        /*0x3813ffc*/ bool GetSettingsStatus();
        /*0x3816710*/ void ToggleOverlaySettings(UnityEngine.Transform parent);
    }

    interface INoaDebuggerFloatingTool
    {
        /*0x3813ffc*/ bool GetPinStatus();
        /*0x3816710*/ void TogglePin(UnityEngine.Transform parent);
        /*0x3816710*/ void InitFloatingWindow(UnityEngine.Transform parent);
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

        /*0x38159dc*/ LogPresenterBase();
        /*0x3813ffc*/ bool get_IsSelectingMode();
        /*0x3815cc4*/ void set_IsSelectingMode(bool value);
        /*0x38148bc*/ NoaDebugger.LogCollectorModel CreateLogCollectorModel();
        /*0x3814574*/ int GetLogCapacity();
        /*0x3910ae8*/ void SetLogPanelInfo(ref NoaDebugger.LogViewLinker.LogPanelInfo logPanelInfo, TLogEntry log);
        /*0x38148bc*/ string GetStatusString();
        /*0x38159dc*/ void OnClearLog();
        /*0x3910ae8*/ void OnLogCopied(TLogEntry log, string clipboardText);
        System.Nullable<bool> OnLogDownload(string fileName, string json);
        /*0x38148bc*/ string GetExportFilenamePrefix();
        /*0x38159dc*/ void OnLogSend();
        /*0x3813ffc*/ bool IsRegisteredSend();
        /*0x38148bc*/ string GetFilterSavePrefsKey();
        /*0x38148bc*/ string GetOverlayPrefsKey();
        /*0x38148bc*/ NoaDebugger.KeyValueSerializer CreateLogKeyValueSerializer();
        /*0x38159dc*/ void _Init();
        /*0x38159dc*/ void _UpdateView();
        /*0x3816710*/ void _ShowView(UnityEngine.Transform parent);
        /*0x3816710*/ void _InitView(NoaDebugger.LogViewBase view);
        /*0x38159dc*/ void _HideView();
        /*0x38159dc*/ void _DoUpdateView();
        /*0x3815ed0*/ void _SetNotificationStatus(NoaDebugger.ToolNotificationStatus notifyStatus);
        /*0x3816810*/ void _CreateLogViewInfos(ref int selectLogIndex, ref int selectingCount);
        /*0x3815cc4*/ void _AlignmentUI(bool isReverse);
        /*0x38159dc*/ void _OnRecord();
        /*0x38159dc*/ void _OnClearLogs();
        /*0x3815cc4*/ void OnSelectingMode(bool isSelecting);
        /*0x38159dc*/ void _OnSelectAll();
        /*0x38159dc*/ void _OnDeselectAll();
        /*0x38159dc*/ void _OnDownload();
        /*0x38159dc*/ void _OnLogSend();
        /*0x3815f10*/ void _OnSwitchByType(NoaDebugger.LogType logType, bool isOn);
        /*0x3816710*/ void _OnChangeFilter(string text);
        /*0x3815ed0*/ void _OnSelectLog(int index);
        /*0x3815ed0*/ void _SaveLongTapStartLog(int index);
        /*0x38159dc*/ void _CopySavedLog();
        /*0x3816710*/ void _CopyLog(NoaDebugger.ILogDetail logDetail);
        /*0x3910ae8*/ TLogEntry _GetLog(int index);
        /*0x3816810*/ void _OnExecDownload(string label, UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo> completed);
        /*0x3814a3c*/ string _CreateExportJsonString(string label);
        /*0x38148bc*/ NoaDebugger.LogOverlaySettingsDefaultGetter _CreateOverlaySettingsDefaultGetter();
        /*0x3813ffc*/ bool _GetPinStatus();
        /*0x3816710*/ void _TogglePin(UnityEngine.Transform parent);
        /*0x38159dc*/ void _OnUpdateOverlaySettings();
        /*0x3816710*/ void _OnInitOverlay(NoaDebugger.LogOverlayView overlay);
        /*0x38159dc*/ void _OnOverlayEnabled();
        /*0x38159dc*/ void _OnHidden();
        /*0x38159dc*/ void _OnDispose();
        /*0x38148bc*/ System.Collections.Generic.LinkedList<TLogEntry> GetLogList();
        /*0x38159dc*/ void ClearLog();
        /*0x38159dc*/ void OnDestroy();

        class LogExportData<TLogEntry, TLogDetail> : NoaDebugger.IExportData
        {
            /*0x0*/ NoaDebugger.DownloadInfo _downloadData;

            /*0x3816710*/ LogExportData(string exportFilenamePrefix);
            /*0x38148bc*/ NoaDebugger.DownloadInfo GetDownloadInfo();
        }

        class <>c<TLogEntry, TLogDetail>
        {
            static /*0x0*/ NoaDebugger.LogPresenterBase.<>c<TLogEntry, TLogDetail> <>9;
            static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<NoaDebugger.LogType, bool>, bool> <>9__51_0;

            static /*0x383e7a0*/ <>c();
            /*0x38159dc*/ <>c();
            bool <_CreateLogViewInfos>b__51_0(System.Collections.Generic.KeyValuePair<NoaDebugger.LogType, bool> kv);
        }
    }

    class LogOverlayPresenter : NoaDebugger.OverlayPresenterBase<NoaDebugger.LogOverlayView, NoaDebugger.LogOverlaySettingsView, NoaDebugger.LogOverlaySettings, NoaDebugger.LogOverlayViewLinker>
    {
        /*0x72d914c*/ LogOverlayPresenter(NoaDebugger.LogOverlayView overlayPrefab, NoaDebugger.LogOverlaySettingsView overlaySettingsPrefab, string prefsKeyPrefix, NoaDebugger.LogOverlaySettings overlayToolSettings);
    }

    class NoaDebuggerToolBase : UnityEngine.MonoBehaviour
    {
        /*0x72d76e4*/ NoaDebuggerToolBase();
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

        /*0x3910ae8*/ OverlayPresenterBase(TOverlayView overlayPrefab, TOverlaySettingsView overlaySettingsPrefab, string prefsKeyPrefix, TOverlayToolSettings overlayToolSettings);
        /*0x3816710*/ void add_OnInitAction(System.Action<TOverlayView> value);
        /*0x3816710*/ void remove_OnInitAction(System.Action<TOverlayView> value);
        /*0x3816710*/ void add_OnUpdateSettings(System.Action value);
        /*0x3816710*/ void remove_OnUpdateSettings(System.Action value);
        /*0x3813ffc*/ bool get_IsOverlayEnable();
        /*0x3815cc4*/ void set_IsOverlayEnable(bool value);
        /*0x3813ffc*/ bool get_IsShowOverlay();
        /*0x3813ffc*/ bool get_IsOverlaySettingsEnable();
        /*0x3816710*/ void InstantiateOverlay(UnityEngine.Transform parent);
        /*0x3910ae8*/ void ShowOverlayView(TViewLinker linker);
        /*0x38159dc*/ void _DestroyOverlay();
        /*0x3816710*/ void ToggleActiveOverlayView(UnityEngine.Transform parent);
        /*0x3815cc4*/ void _OnOverlayRootActiveChanged(bool active);
        /*0x3816710*/ void _InstantiateOverlaySettings(UnityEngine.Transform parent);
        /*0x38159dc*/ void DestroyOverlaySettings();
        /*0x3816810*/ void ToggleActiveOverlaySettingsView(UnityEngine.GameObject mainViewObj, UnityEngine.Transform parent);
        /*0x38159dc*/ void _OnUpdateSettings();
        /*0x3815cc4*/ void AlignmentUI(bool isReverse);
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

        static /*0x72da038*/ NoaDebugger.FpsUnchangingInfo CreateFpsViewInfo(NoaDebugger.FpsInfo info);
        static /*0x72da094*/ NoaDebugger.ProfilerFrameTimeViewInformation CreateFrameTimeInfo(NoaDebugger.FrameTimeInfo info);
        static /*0x72da118*/ NoaDebugger.MemoryUnchangingInfo CreateMemoryViewInfo(NoaDebugger.MemoryInfo info);
        static /*0x72da174*/ NoaDebugger.RenderingUnchangingInfo CreateRenderingViewInfo(NoaDebugger.RenderingInfo info);
        static /*0x72da57c*/ NoaDebugger.BatteryUnchangingInfo CreateBatteryViewInfo(NoaDebugger.BatteryInfo info);
        static /*0x72da5d8*/ NoaDebugger.ThermalUnchangingInfo CreateThermalViewInfo(NoaDebugger.ThermalInfo info);
        /*0x72daef4*/ ProfilerPresenter();
        /*0x72d91c4*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x72d91cc*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x72d9244*/ NoaDebugger.FpsModel get_FpsModel();
        /*0x72d924c*/ void set_FpsModel(NoaDebugger.FpsModel value);
        /*0x72d9254*/ NoaDebugger.FrameTimeModel get_FrameTimeModel();
        /*0x72d925c*/ void set_FrameTimeModel(NoaDebugger.FrameTimeModel value);
        /*0x72d9264*/ NoaDebugger.TargetFrameRateModel get_TargetFrameRateModel();
        /*0x72d926c*/ void set_TargetFrameRateModel(NoaDebugger.TargetFrameRateModel value);
        /*0x72d9274*/ NoaDebugger.MemoryModel get_MemoryModel();
        /*0x72d927c*/ void set_MemoryModel(NoaDebugger.MemoryModel value);
        /*0x72d9284*/ NoaDebugger.RenderingModel get_RenderingModel();
        /*0x72d928c*/ void set_RenderingModel(NoaDebugger.RenderingModel value);
        /*0x72d9294*/ NoaDebugger.BatteryModel get_BatteryModel();
        /*0x72d929c*/ void set_BatteryModel(NoaDebugger.BatteryModel value);
        /*0x72d92a4*/ NoaDebugger.ThermalModel get_ThermalModel();
        /*0x72d92ac*/ void set_ThermalModel(NoaDebugger.ThermalModel value);
        /*0x72d92b4*/ void Init();
        /*0x72d976c*/ void ShowView(UnityEngine.Transform parent);
        /*0x72d988c*/ void _InitView(NoaDebugger.ProfilerView view);
        /*0x72d9d4c*/ void AlignmentUI(bool isReverse);
        /*0x72d9dc0*/ bool GetPinStatus();
        /*0x72d9e08*/ void TogglePin(UnityEngine.Transform parent);
        /*0x72d9e60*/ void InitOverlay(UnityEngine.Transform parent);
        /*0x72d9ee0*/ bool GetSettingsStatus();
        /*0x72d9f28*/ void ToggleOverlaySettings(UnityEngine.Transform parent);
        /*0x72d9f98*/ void _OnUpdateOverlaySettings();
        /*0x72d9f9c*/ void _OnInitOverlay(NoaDebugger.ProfilerOverlayView overlay);
        /*0x72da034*/ void _OnOverlayEnabled();
        /*0x72d9c48*/ void _UpdateAllView();
        /*0x72da1d0*/ void _UpdateViewFromViewData(NoaDebugger.ProfilerViewLinker viewData);
        /*0x72da35c*/ void _UpdateFpsView();
        /*0x72da3e4*/ void _UpdateFrameTimeView();
        /*0x72da46c*/ void _UpdateMemoryView();
        /*0x72da4f4*/ void _UpdateRenderingView();
        /*0x72da634*/ void _OnFpsProfilingStateChanged(bool isProfiling);
        /*0x72da680*/ void _OnFrameTimeProfilingStateChanged(bool isProfiling);
        /*0x72da6b0*/ void _OnVSyncCountChanged(int vSyncCount);
        /*0x72da6bc*/ void _OnMemoryProfilingStateChanged(bool isProfiling);
        /*0x72da6ec*/ void _OnMemoryGraphShowingStateChanged(bool isShowing);
        /*0x72da714*/ void _OnMemoryProfilingTypeChanged(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
        /*0x72da738*/ void _OnGcCollectExecuted();
        /*0x72da750*/ System.Collections.IEnumerator _ExecuteGcCollect();
        /*0x72da7e4*/ void _OnUnloadAssetExecuted();
        /*0x72da7fc*/ System.Collections.IEnumerator _ExecuteUnloadUnusedAssets();
        /*0x72da890*/ void _OnRenderingProfilingStateChanged(bool isProfiling);
        /*0x72da8c0*/ void _OnRenderingGraphShowingStateChanged(bool isShowing);
        /*0x72da8e8*/ void _OnRenderingGraphSelected(NoaDebugger.RenderingGraphTarget target);
        /*0x72da928*/ void _OnHidden();
        /*0x72da9e0*/ void OnHidden();
        /*0x72da9e4*/ void OnToolDispose();
        /*0x72dab08*/ NoaDebugger.ProfilerSnapshotData CaptureSnapshot();
        /*0x72dab64*/ NoaDebugger.FpsInfo GetFpsInfo();
        /*0x72dab80*/ bool IsFpsProfiling();
        /*0x72da63c*/ void ChangeFpsProfiling(bool isProfiling);
        /*0x72da688*/ void ChangeFrameTimeProfiling(bool isProfiling);
        /*0x72daba4*/ NoaDebugger.MemoryInfo GetMemoryInfo();
        /*0x72dabc0*/ bool IsMemoryProfiling();
        /*0x72da6c4*/ void ChangeMemoryProfiling(bool isProfiling);
        /*0x72dabe4*/ void ChangeMemoryProfilingType(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
        /*0x72dac08*/ float GetTotalNativeMemoryMB();
        /*0x72dac2c*/ void SetTotalNativeMemoryMB(float totalMemoryMB);
        /*0x72dac50*/ NoaDebugger.RenderingInfo GetRenderingInfo();
        /*0x72dac6c*/ bool IsRenderingProfiling();
        /*0x72da898*/ void ChangeRenderingProfiling(bool isProfiling);
        /*0x72dac90*/ NoaDebugger.BatteryInfo GetBatteryInfo();
        /*0x72dacac*/ bool IsBatteryProfiling();
        /*0x72dad28*/ void ChangeBatteryProfiling(bool isProfiling);
        /*0x72dad44*/ NoaDebugger.ThermalInfo GetThermalInfo();
        /*0x72dad60*/ bool IsThermalProfiling();
        /*0x72dade0*/ void ChangeThermalProfiling(bool isProfiling);
        /*0x72dadfc*/ void OnDestroy();

        class ProfilerMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x72d923c*/ ProfilerMenuInfo();
            /*0x72daefc*/ string get_Name();
            /*0x72daf3c*/ string get_MenuName();
            /*0x72daf7c*/ int get_SortNo();
        }

        class <_ExecuteGcCollect>d__71 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.ProfilerPresenter <>4__this;

            /*0x72da7bc*/ <_ExecuteGcCollect>d__71(int <>1__state);
            /*0x72daf84*/ void System.IDisposable.Dispose();
            /*0x72daf88*/ bool MoveNext();
            /*0x72db0e4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72db0ec*/ void System.Collections.IEnumerator.Reset();
            /*0x72db124*/ object System.Collections.IEnumerator.get_Current();
        }

        class <_ExecuteUnloadUnusedAssets>d__73 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.ProfilerPresenter <>4__this;
            /*0x28*/ UnityEngine.AsyncOperation <asyncOp>5__2;

            /*0x72da868*/ <_ExecuteUnloadUnusedAssets>d__73(int <>1__state);
            /*0x72db12c*/ void System.IDisposable.Dispose();
            /*0x72db130*/ bool MoveNext();
            /*0x72db2a8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72db2b0*/ void System.Collections.IEnumerator.Reset();
            /*0x72db2e8*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class ProfilerOverlayPresenter : NoaDebugger.OverlayPresenterBase<NoaDebugger.ProfilerOverlayView, NoaDebugger.ProfilerOverlaySettingsView, NoaDebugger.ProfilerOverlaySettings, NoaDebugger.ProfilerViewLinker>
    {
        /*0x72d96f8*/ ProfilerOverlayPresenter(NoaDebugger.ProfilerOverlayView overlayPrefab, NoaDebugger.ProfilerOverlaySettingsView overlaySettingsPrefab, string prefsKeyPrefix);
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

        static /*0x72dd3b4*/ string ConvertCategoryName(string categoryName, bool isDownload);
        static /*0x72dd180*/ string TimeSpanToHourTimeFormatString(System.TimeSpan time);
        /*0x72dd5d4*/ SnapshotPresenter();
        /*0x72db2f0*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x72db2f8*/ NoaDebugger.SnapshotModel get_Model();
        /*0x72db300*/ void set_Model(NoaDebugger.SnapshotModel value);
        /*0x72db308*/ void Init();
        /*0x72db3d0*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x72db440*/ void ShowView(UnityEngine.Transform parent);
        /*0x72db534*/ void _InitView(NoaDebugger.SnapshotView view);
        /*0x72db890*/ void AlignmentUI(bool isReverse);
        /*0x72db7f4*/ void _UpdateView();
        /*0x72dba2c*/ void _UpdateByLinker(NoaDebugger.SnapshotViewLinker linker, bool onUpdate);
        /*0x72dbaf8*/ void OnHidden();
        /*0x72dbbc4*/ void OnToolDispose();
        /*0x72dbc1c*/ void ClearLogsAndTimer();
        /*0x72dbc5c*/ void CaptureLog(string label, System.Nullable<UnityEngine.Color> backgroundColor, bool hasNoaProfilerInfo, System.Collections.Generic.Dictionary<string, NoaDebugger.NoaSnapshotCategory> additionalInfo, bool updateProfilingElapsedTime);
        /*0x72dbb28*/ void _DestroyView();
        /*0x72db994*/ void _OnActiveChanged();
        /*0x72db8b4*/ void _SetViewLinkerFromTime(NoaDebugger.SnapshotViewLinker linker);
        /*0x72db934*/ void _SetViewLinkerFromLogData(NoaDebugger.SnapshotViewLinker linker);
        /*0x72db968*/ void _SetViewLinkerFromComparison(NoaDebugger.SnapshotViewLinker linker);
        /*0x72dbd60*/ void _OnInsertLog();
        /*0x72dbebc*/ void _OnToggleChanged(int id);
        /*0x72dbf58*/ void _OnClearAllLog();
        /*0x72dbf70*/ void _OnClickLog(int id);
        /*0x72dbfb0*/ void _OnCopyLog(int id);
        /*0x72dbee0*/ void _ReloadLogScroll();
        /*0x72dcbf4*/ void _UpdateFromTime();
        /*0x72dcc60*/ void _OnDownloadLog();
        /*0x72dcd50*/ void _OnComparison();
        /*0x72dcd88*/ void _OnExecDownload(string label, UnityEngine.Events.UnityAction<NoaDebugger.FileDownloader.DownloadInfo> completed);
        /*0x72dce90*/ string _CreateExportJsonString(string label);
        /*0x72dcf50*/ NoaDebugger.KeyValueSerializer _CreateSnapshotExportData();
        /*0x72dc1c4*/ NoaDebugger.IKeyValueParser[] _CreateSnapshotLogExportData(NoaDebugger.SnapshotLogRecordInformation log);
        /*0x72dd528*/ System.Collections.Generic.List<NoaDebugger.SnapshotLogRecordInformation> GetLogList();
        /*0x72dd54c*/ void OnDestroy();

        class SnapshotExportData : NoaDebugger.IExportData
        {
            static string EXPORT_FILE_PREFIX = "snapshot";
            /*0x10*/ NoaDebugger.SnapshotModel.SnapshotInformation _snapshotInfo;
            /*0x18*/ NoaDebugger.DownloadInfo _downloadData;

            /*0x72de1f8*/ SnapshotExportData();
            /*0x72de1f0*/ NoaDebugger.DownloadInfo GetDownloadInfo();
        }

        class SnapshotMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x72de34c*/ SnapshotMenuInfo();
            /*0x72de2c4*/ string get_Name();
            /*0x72de304*/ string get_MenuName();
            /*0x72de344*/ int get_SortNo();
        }

        class <>c__DisplayClass35_0
        {
            /*0x10*/ int id;

            /*0x72de354*/ <>c__DisplayClass35_0();
            /*0x72de35c*/ bool <_OnCopyLog>b__0(NoaDebugger.SnapshotLogRecordInformation log);
        }
    }

    class ToolDetailPresenter : NoaDebugger.NoaDebuggerToolBase, NoaDebugger.INoaDebuggerTool
    {
        /*0x20*/ NoaDebugger.ToolDetailView _mainViewPrefab;
        /*0x28*/ NoaDebugger.ToolDetailView _mainView;
        /*0x30*/ NoaDebugger.ToolDetailModel _model;
        /*0x38*/ bool _isDeviceOrientationChanged;
        /*0x40*/ NoaDebugger.ToolDetailPresenter.ToolDetailMenuInfo _toolDetailMenuInfo;

        /*0x72de828*/ ToolDetailPresenter();
        /*0x72de380*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
        /*0x72de388*/ void Init();
        /*0x72de3e8*/ NoaDebugger.IMenuInfo MenuInfo();
        /*0x72de460*/ void ShowView(UnityEngine.Transform parent);
        /*0x72de630*/ NoaDebugger.ToolDetailViewLinker get_Linker();
        /*0x72de588*/ void _UpdateAllView();
        /*0x72de6d0*/ void AlignmentUI(bool isReverse);
        /*0x72de6f4*/ void _OnHidden();
        /*0x72de78c*/ void OnHidden();
        /*0x72de790*/ void OnToolDispose();
        /*0x72de7e0*/ void OnDestroy();

        class ToolDetailMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x72de458*/ ToolDetailMenuInfo();
            /*0x72de830*/ string get_Name();
            /*0x72de870*/ string get_MenuName();
            /*0x72de8b0*/ int get_SortNo();
        }
    }

    class AssemblyUtils
    {
        static /*0x3836db8*/ System.Type[] GetInterfaces<T>();
        static /*0x3836db8*/ T[] CreateInterfaceInstances<T>();

        class <>c__0<T>
        {
            static /*0x0*/ NoaDebugger.AssemblyUtils.<>c__0<T> <>9;
            static /*0x0*/ System.Func<System.Type, bool> <>9__0_1;
            static /*0x0*/ System.Func<System.Type, bool> <>9__0_0;

            static /*0x383e7a0*/ <>c__0();
            /*0x38159dc*/ <>c__0();
            /*0x38141c4*/ bool <GetInterfaces>b__0_0(System.Type c);
            /*0x38141c4*/ bool <GetInterfaces>b__0_1(System.Type t);
        }

        class <>c__<T>
        {
            static /*0x0*/ NoaDebugger.AssemblyUtils.<>c__1<T> <>9;
            static /*0x0*/ System.Func<System.Type, T> <>9__1_0;

            static /*0x383e7a0*/ <>c__();
            /*0x38159dc*/ <>c__();
            /*0x3910ae8*/ T <CreateInterfaceInstances>b__1_0(System.Type c);
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

        static /*0x72deda8*/ AutoRefreshSwitcher();
        /*0x72de8cc*/ AutoRefreshSwitcher(UnityEngine.Events.UnityAction onUpdate, string prefsKey, float refreshInterval);
        /*0x72de8b8*/ bool get_IsAutoRefresh();
        /*0x72de8c0*/ void set_IsAutoRefresh(bool value);
        /*0x72deab4*/ void UpdateAutoRefresh(bool isAutoRefresh);
        /*0x72dea04*/ void _HandleOnUpdate(bool isAutoRefresh);
        /*0x72ded54*/ void _OnUpdate();
    }

    class AxisSwitchableLayoutGroup : UnityEngine.UI.HorizontalOrVerticalLayoutGroup
    {
        /*0x6c*/ NoaDebugger.AxisSwitchableLayoutGroup.AxisType <Axis>k__BackingField;

        /*0x72deef0*/ AxisSwitchableLayoutGroup();
        /*0x72dee14*/ NoaDebugger.AxisSwitchableLayoutGroup.AxisType get_Axis();
        /*0x72dee1c*/ void set_Axis(NoaDebugger.AxisSwitchableLayoutGroup.AxisType value);
        /*0x72dee24*/ void CalculateLayoutInputHorizontal();
        /*0x72dee6c*/ void CalculateLayoutInputVertical();
        /*0x72dee98*/ void SetLayoutHorizontal();
        /*0x72deec4*/ void SetLayoutVertical();

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

        /*0x72def00*/ ContentPanelPool(UnityEngine.GameObject prefab, UnityEngine.Transform contentRoot);
        /*0x72defb8*/ System.ValueTuple<UnityEngine.GameObject, int> GetObjectAndIndex();
        /*0x72df094*/ System.ValueTuple<UnityEngine.GameObject, int> _GetGameObjectAndIndex();
        /*0x72df264*/ void ReturnObject(int index);
    }

    class ContentSizeFitterByChildren : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.RectTransform _rect;

        /*0x72df7cc*/ ContentSizeFitterByChildren();
        /*0x72df2cc*/ void Start();
        /*0x72df35c*/ void _WidthFitterByChildren();
        /*0x72df480*/ UnityEngine.Vector3 _GetRightmostWorldPosition(UnityEngine.RectTransform rect, UnityEngine.Vector3 rightmostWorldPosition);
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

        /*0x72dfe2c*/ DeviceOrientationStretch();
        /*0x72df7d4*/ void Awake();
        /*0x72dfb90*/ void _OnChangeDeviceOrientation(bool isPortrait);
        /*0x72dfc68*/ void CopyToLandscapeOffset();
        /*0x72dfcdc*/ void CopyToPortraitOffset();
        /*0x72dfd50*/ void OnDestroy();
    }

    class EndOfUpdateListener : UnityEngine.MonoBehaviour
    {
        /*0x20*/ System.Action OnLateUpdate;

        /*0x72dff88*/ EndOfUpdateListener();
        /*0x72dfe34*/ void add_OnLateUpdate(System.Action value);
        /*0x72dfed0*/ void remove_OnLateUpdate(System.Action value);
        /*0x72dff6c*/ void LateUpdate();
    }

    class InputTextAutoScroller : NoaDebugger.TextAutoScroller
    {
        /*0x40*/ NoaDebugger.NoaDebuggerScrollableInputComponent _inputComponent;

        /*0x72e0440*/ InputTextAutoScroller();
        /*0x72dff90*/ void _OnInitialize();
        /*0x72e0174*/ void SetText(string text);
        /*0x72e02c4*/ void _OnSelect(string text);
        /*0x72e02f4*/ void _OnEndEdit(string text);
        /*0x72e01c0*/ void _SetTextAlpha(bool isInputMode);
        /*0x72e0364*/ void SetOnSelect(UnityEngine.Events.UnityAction<string> action);
        /*0x72e03c4*/ void SetOnEndEdit(UnityEngine.Events.UnityAction<string> action);
        /*0x72e0424*/ void SetCharacterLimit(int num);
    }

    class NestedScrollRect : UnityEngine.UI.ScrollRect
    {
        /*0x130*/ bool _routeToParent;

        static /*0x3843dfc*/ void DoParentEventSystemHandler<T>(UnityEngine.Transform transform, System.Action<T> action);
        /*0x72e09c0*/ NestedScrollRect();
        /*0x72e04a0*/ void OnInitializePotentialDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72e05b4*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72e06d4*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72e08a0*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);

        class <>c__DisplayClass1_0
        {
            /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x72e05ac*/ <>c__DisplayClass1_0();
            /*0x72e09c8*/ void <OnInitializePotentialDrag>b__0(UnityEngine.EventSystems.IInitializePotentialDragHandler parent);
        }

        class <>c__DisplayClass2_0
        {
            /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x72e06cc*/ <>c__DisplayClass2_0();
            /*0x72e0a70*/ void <OnDrag>b__0(UnityEngine.EventSystems.IDragHandler parent);
        }

        class <>c__DisplayClass3_0
        {
            /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x72e0898*/ <>c__DisplayClass3_0();
            /*0x72e0b18*/ void <OnBeginDrag>b__0(UnityEngine.EventSystems.IBeginDragHandler parent);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ UnityEngine.EventSystems.PointerEventData eventData;

            /*0x72e09b8*/ <>c__DisplayClass4_0();
            /*0x72e0bc0*/ void <OnEndDrag>b__0(UnityEngine.EventSystems.IEndDragHandler parent);
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

        /*0x72e1784*/ NoaDebuggerButtonVisualController();
        /*0x72e0c68*/ System.ValueTuple<float, float> get_CachedAlertAnimationParameters();
        /*0x72e0dd4*/ bool get_IsPlayingAnimation();
        /*0x72e0ddc*/ void Init();
        /*0x72e0e6c*/ void ResetButtonColor();
        /*0x72e11a0*/ void PlayOnErrorAnimation(System.Func<bool> breakCondition);
        /*0x72e14dc*/ void PlayOnLocationAnimation(System.Func<bool> breakCondition);
        /*0x72e1718*/ void SetCanvasGroupAlpha(float alpha);
        /*0x72e0e4c*/ void _SetCanvasGroupEnabled(bool isEnabled);
        /*0x72e1364*/ bool _IsActive();
        /*0x72e1424*/ System.Collections.IEnumerator _CanvasGroupAlphaAnimation(System.ValueTuple<float, float> parameters, System.Func<bool> breakCondition, System.Action onFinish);
        /*0x72e13d0*/ void _SetActive(bool isActive, bool onError);
        /*0x72e175c*/ void Dispose();
        /*0x72e178c*/ void <PlayOnErrorAnimation>b__14_0();
        /*0x72e17a4*/ void <PlayOnLocationAnimation>b__15_0();

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

            /*0x72e1734*/ <_CanvasGroupAlphaAnimation>d__19(int <>1__state);
            /*0x72e17bc*/ void System.IDisposable.Dispose();
            /*0x72e17c0*/ bool MoveNext();
            /*0x72e19b4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72e19bc*/ void System.Collections.IEnumerator.Reset();
            /*0x72e19f4*/ object System.Collections.IEnumerator.get_Current();
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

        static /*0x72e19fc*/ void Init(NoaDebugger.NoaDebuggerSettings settings);
        static /*0x72e1aac*/ void ChangeFont(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material fontMaterial, float fontSizeRate);
        static /*0x72e1b38*/ void ResetFont();
        static /*0x72e1b84*/ bool get_HasFontAsset();
        static /*0x72e1bfc*/ string GetHasFontAssetString(TMPro.TMP_FontAsset targetFont, string text);
        static /*0x72e1e68*/ string _DecodeUnicodeEscapedString(string input);
        static /*0x72e1f94*/ string _GetUnicodeEscapeSequence(char character);
        /*0x72e23a8*/ NoaDebuggerText();
        /*0x72e200c*/ string get_text();
        /*0x72e2014*/ void set_text(string value);
        /*0x72e2388*/ void Awake();
        /*0x72e204c*/ void ApplyFont(bool isForce);
        /*0x72e2328*/ string _TruncateToMaxLength(string text);

        class <>c
        {
            static /*0x0*/ NoaDebugger.NoaDebuggerText.<> <>9;
            static /*0x8*/ System.Text.RegularExpressions.MatchEvaluator <>9__13_0;

            static /*0x72e2400*/ <>c();
            /*0x72e2468*/ <>c();
            /*0x72e2470*/ string <_DecodeUnicodeEscapedString>b__13_0(System.Text.RegularExpressions.Match match);
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

        /*0x72e34d8*/ ObjectPoolScroll();
        /*0x72e2530*/ System.Collections.Generic.Dictionary<int, NoaDebugger.ObjectPoolScroll.PanelData> get_ShowingPanels();
        /*0x72e25ac*/ int get_VisiblePanelCountY();
        /*0x72e2640*/ bool get_IsShowBottomPanel();
        /*0x72e2658*/ UnityEngine.Events.UnityAction get_OnScrolled();
        /*0x72e2660*/ void set_OnScrolled(UnityEngine.Events.UnityAction value);
        /*0x72e2670*/ void Init(int panelNum, UnityEngine.Events.UnityAction<int, UnityEngine.GameObject> refreshPanel);
        /*0x72e2c9c*/ void OnEnable();
        /*0x72e2cbc*/ void LateUpdate();
        /*0x72e2cf4*/ void RefreshPanels();
        /*0x72e300c*/ void OverwriteContentWidth(float width, bool isPadding);
        /*0x72e2794*/ void _RefreshContent();
        /*0x72e2adc*/ void _ShowPanelsWithinScrollRange(UnityEngine.Vector2 normalizedPos);
        /*0x72e3104*/ void _ShowPanel(int index);
        /*0x72e3254*/ void _HidePanel(int index);
        /*0x72e30a4*/ void _PanelStretch(UnityEngine.RectTransform panelRect);
        /*0x72e2cfc*/ void _RefreshPanels(bool forceRefresh);
        /*0x72e28c0*/ void _ResetPanels();

        class PanelData
        {
            /*0x10*/ UnityEngine.GameObject _gameObject;
            /*0x18*/ UnityEngine.CanvasGroup _canvasGroup;

            static /*0x72e33c4*/ NoaDebugger.ObjectPoolScroll.PanelData Instantiate(UnityEngine.GameObject prefab, UnityEngine.Transform content);
            /*0x72e35b4*/ PanelData(UnityEngine.GameObject gameObject);
            /*0x72e3488*/ void SetActive(bool isActive);
        }
    }

    class OrientationAwareLayoutGroup : UnityEngine.UI.HorizontalOrVerticalLayoutGroup
    {
        /*0x6c*/ NoaDebugger.OrientationAwareLayoutGroup.LayoutType _portraitLayoutType;
        /*0x70*/ NoaDebugger.OrientationAwareLayoutGroup.LayoutType _landscapeLayoutType;
        /*0x74*/ bool _isPortrait;

        /*0x72e3830*/ OrientationAwareLayoutGroup();
        /*0x72e36ac*/ bool get_IsPortrait();
        /*0x72e36c8*/ void CalculateLayoutInputHorizontal();
        /*0x72e3728*/ void CalculateLayoutInputVertical();
        /*0x72e3780*/ void SetLayoutHorizontal();
        /*0x72e37d8*/ void SetLayoutVertical();

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

        static /*0x72e45c8*/ OrientationLayoutRuntimeAdjuster();
        /*0x72e45a8*/ OrientationLayoutRuntimeAdjuster();
        /*0x72e3838*/ void _OnValidateUI();
        /*0x72e3964*/ void Awake();
        /*0x72e3ccc*/ void OnRectTransformDimensionsChange();
        /*0x72e3f14*/ void _OnEndDragHandle();
        /*0x72e41d0*/ void SetHandleTargetLayouts();

        class <>c
        {
            static /*0x0*/ NoaDebugger.OrientationLayoutRuntimeAdjuster.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.OrientationLayoutStyle, bool> <>9__13_0;

            static /*0x72e4614*/ <>c();
            /*0x72e467c*/ <>c();
            /*0x72e4684*/ bool <SetHandleTargetLayouts>b__13_0(NoaDebugger.OrientationLayoutStyle x);
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

        /*0x72e4eac*/ OrientationLayoutRuntimeAdjusterHandle();
        /*0x72e3c30*/ void add_OnEndDragHandle(UnityEngine.Events.UnityAction value);
        /*0x72e46ac*/ void remove_OnEndDragHandle(UnityEngine.Events.UnityAction value);
        /*0x72e4748*/ void Awake();
        /*0x72e444c*/ void Initialize(NoaDebugger.OrientationLayoutStyle formerLayout, NoaDebugger.OrientationLayoutStyle latterLayout, UnityEngine.UI.HorizontalOrVerticalLayoutGroup layoutGroup, float minWidth, float minHeight);
        /*0x72e47c8*/ void SetFromLayoutStyle();
        /*0x72e4ae4*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72e4c18*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72e4d78*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72e4e70*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72e4c84*/ UnityEngine.Vector2 _GetLocalPositionFromPointerEventData(UnityEngine.EventSystems.PointerEventData eventData);
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

        /*0x72e4eb4*/ OrientationLayoutStyleModel();
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

        /*0x72e56ac*/ OrientationLayoutStyle();
        /*0x72e4eec*/ NoaDebugger.OrientationLayoutRuntimeAdjusterHandle get_Handle();
        /*0x72e4ef4*/ void set_Handle(NoaDebugger.OrientationLayoutRuntimeAdjusterHandle value);
        /*0x72e4efc*/ void Awake();
        /*0x72e5248*/ void Start();
        /*0x72e52d0*/ void OnEnable();
        /*0x72e4f00*/ void _Initialize();
        /*0x72e5428*/ void _OnTargetRectTransformDimensionsChanged();
        /*0x72e52d4*/ void _SetDirty();
        /*0x72e524c*/ void _ValueChanged();
        /*0x72e54a4*/ void _SetLayoutStyle(NoaDebugger.OrientationLayoutStyleModel layoutStyle);
        /*0x72e407c*/ void OverwriteLayoutByCurrentSize(int layoutsCount);
        /*0x72e3e6c*/ void SetHandleFromLayoutStyle();
        /*0x72e4aa4*/ NoaDebugger.OrientationLayoutStyleModel GetCurrentLayoutStyle();
    }

    class PointerEventComponent : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IPointerExitHandler
    {
        /*0x20*/ UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> OnPointerDownEvent;
        /*0x28*/ UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> OnPointerUpEvent;
        /*0x30*/ UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> OnPointerClickEvent;
        /*0x38*/ UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> OnPointerEnterEvent;
        /*0x40*/ UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> OnPointerExitEvent;

        /*0x72e5e20*/ PointerEventComponent();
        /*0x72e56b4*/ void add_OnPointerDownEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72e5764*/ void remove_OnPointerDownEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72e5814*/ void add_OnPointerUpEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72e58c4*/ void remove_OnPointerUpEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72e5974*/ void add_OnPointerClickEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72e5a24*/ void remove_OnPointerClickEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72e5ad4*/ void add_OnPointerEnterEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72e5b84*/ void remove_OnPointerEnterEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72e5c34*/ void add_OnPointerExitEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72e5ce4*/ void remove_OnPointerExitEvent(UnityEngine.Events.UnityAction<UnityEngine.EventSystems.PointerEventData> value);
        /*0x72e5d94*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72e5db0*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72e5dcc*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72e5de8*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x72e5e04*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
    }

    class ProportionalLayoutElement : UnityEngine.UI.LayoutElement
    {
        /*0x40*/ float _relativeWidth;
        /*0x44*/ bool _relativeWidthFlag;
        /*0x48*/ float _relativeHeight;
        /*0x4c*/ bool _relativeHeightFlag;
        /*0x50*/ UnityEngine.RectTransform _parentRectTransform;
        /*0x58*/ UnityEngine.RectTransform _rectTransform;

        /*0x72e626c*/ ProportionalLayoutElement();
        /*0x72e5e28*/ float get_RelativeWidth();
        /*0x72e569c*/ void set_RelativeWidth(float value);
        /*0x72e5eec*/ bool get_RelativeWidthFlag();
        /*0x72e5ef4*/ void set_RelativeWidthFlag(bool value);
        /*0x72e5f00*/ float get_RelativeHeight();
        /*0x72e56a4*/ void set_RelativeHeight(float value);
        /*0x72e5f08*/ bool get_RelativeHeightFlag();
        /*0x72e5f10*/ void set_RelativeHeightFlag(bool value);
        /*0x72e5f1c*/ void OnEnable();
        /*0x72e5e30*/ void _SetDirty();
        /*0x72e6014*/ void CalculateLayoutInputHorizontal();
        /*0x72e60c4*/ void CalculateLayoutInputVertical();
        /*0x72e6174*/ void Update();
        /*0x72e61ec*/ void _SetLayoutStyle();
    }

    class RuntimeVersionChecker : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.UI.Image[] _unsupportedColorChangeTarget;
        /*0x28*/ NoaDebugger.NoaDebuggerInfo _noaDebuggerInfo;

        /*0x72e63e0*/ RuntimeVersionChecker();
        /*0x72e6280*/ void DoCheck(NoaDebugger.NoaDebuggerInfo noaDebuggerInfo);
        /*0x72e62ec*/ void _IndicateUnsupported(bool isUnsupported);
        /*0x72e62b4*/ bool _CheckSupported();
    }

    class SafeAreaAdjuster : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.RectTransform _rect;

        /*0x72e6564*/ SafeAreaAdjuster();
        /*0x72e63e8*/ void Start();
        /*0x72e63ec*/ void Adjust();
        /*0x72e64b4*/ void SetRect();
    }

    class ScrollRectHeightFitter : UnityEngine.EventSystems.UIBehaviour
    {
        /*0x20*/ UnityEngine.UI.ScrollRect _resizeTargetScrollRect;
        /*0x28*/ bool _layoutElementMinHeightIsTarget;
        /*0x30*/ UnityEngine.RectTransform _scrollRectTransform;
        /*0x38*/ UnityEngine.UI.LayoutElement _layoutElement;
        /*0x40*/ UnityEngine.RectTransform _selfTransform;
        /*0x48*/ float _horizontalScrollbarHeight;

        /*0x72e6884*/ ScrollRectHeightFitter();
        /*0x72e656c*/ void Awake();
        /*0x72e6744*/ void OnRectTransformDimensionsChange();
    }

    class ScrollResetter : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.UI.ScrollRect _scroll;
        /*0x28*/ bool _once;

        /*0x72e6934*/ ScrollResetter();
        /*0x72e688c*/ void Awake();
        /*0x72e68e4*/ void OnEnable();
        /*0x72e692c*/ void OnDisable();
        /*0x72e6908*/ void ResetScroll();
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

        static /*0x72e6d8c*/ TextAutoScroller();
        /*0x72e0498*/ TextAutoScroller();
        /*0x72e693c*/ UnityEngine.RectTransform get_ScrollTextRect();
        /*0x72e6958*/ UnityEngine.RectTransform get_TargetMaskRect();
        /*0x72e6974*/ void Update();
        /*0x72e6c78*/ void OnRectTransformDimensionsChange();
        /*0x72e6b28*/ void _Initialize();
        /*0x72e0140*/ void _OnInitialize();
        /*0x72e02d8*/ void SetIsScroll(bool isScroll);
        /*0x72e6d30*/ void _ResetPosition();
        /*0x72e6c7c*/ void _CalculateWidth();
        /*0x72e6b64*/ float _GetEndPosX();
        /*0x72e6bc8*/ void _SetScrollState(NoaDebugger.TextAutoScroller.ScrollState state);
        /*0x72e6b50*/ void _CheckWaitTime(NoaDebugger.TextAutoScroller.ScrollState nextState);
        /*0x72e01bc*/ void SetText(string text);
        /*0x72e0334*/ void _SetScrollTargetText(string text);

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

        /*0x72e45c0*/ UIBehaviourComponent();
        /*0x72e538c*/ void add_OnRectTransformDimensionsChanged(UnityEngine.Events.UnityAction value);
        /*0x72e6de4*/ void remove_OnRectTransformDimensionsChanged(UnityEngine.Events.UnityAction value);
        /*0x72e3e38*/ void OnRectTransformDimensionsChange();
    }

    class BoolPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<bool>
    {
        /*0x72e6e80*/ BoolPropertyCommandDefinition(string categoryName, string displayName, System.Func<bool> getter, System.Action<bool> setter, System.Attribute[] attributes);
        /*0x72e6f08*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class BytePropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<byte>
    {
        /*0x72e6fb8*/ BytePropertyCommandDefinition(string categoryName, string displayName, System.Func<byte> getter, System.Action<byte> setter, System.Attribute[] attributes);
        /*0x72e7040*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class CharPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<char>
    {
        /*0x72e70f0*/ CharPropertyCommandDefinition(string categoryName, string displayName, System.Func<char> getter, System.Action<char> setter, System.Attribute[] attributes);
        /*0x72e7178*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class CommandDefinition
    {
        /*0x10*/ string <CategoryName>k__BackingField;
        /*0x18*/ string <DisplayName>k__BackingField;
        /*0x20*/ System.Attribute[] <Attributes>k__BackingField;

        /*0x72e7240*/ CommandDefinition(string categoryName, string displayName, System.Attribute[] attributes);
        /*0x72e7228*/ string get_CategoryName();
        /*0x72e7230*/ string get_DisplayName();
        /*0x72e7238*/ System.Attribute[] get_Attributes();
        /*0x38148bc*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class CoroutineCommandDefinition : NoaDebugger.CommandDefinition
    {
        /*0x28*/ System.Func<System.Collections.IEnumerator> <Coroutine>k__BackingField;

        /*0x72e72a8*/ CoroutineCommandDefinition(string categoryName, string displayName, System.Func<System.Collections.IEnumerator> coroutine, System.Attribute[] attributes);
        /*0x72e72a0*/ System.Func<System.Collections.IEnumerator> get_Coroutine();
        /*0x72e72d8*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class DecimalPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<decimal>
    {
        /*0x72e7364*/ DecimalPropertyCommandDefinition(string categoryName, string displayName, System.Func<decimal> getter, System.Action<decimal> setter, System.Attribute[] attributes);
        /*0x72e73ec*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class DoublePropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<double>
    {
        /*0x72e749c*/ DoublePropertyCommandDefinition(string categoryName, string displayName, System.Func<double> getter, System.Action<double> setter, System.Attribute[] attributes);
        /*0x72e7524*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class EnumPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<System.Enum>
    {
        /*0x38*/ System.Type <EnumType>k__BackingField;

        /*0x72e75dc*/ EnumPropertyCommandDefinition(string categoryName, string displayName, System.Func<System.Enum> getter, System.Action<System.Enum> setter, System.Type enumType, System.Attribute[] attributes);
        /*0x72e75d4*/ System.Type get_EnumType();
        /*0x72e7678*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class FloatPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<float>
    {
        /*0x72e773c*/ FloatPropertyCommandDefinition(string categoryName, string displayName, System.Func<float> getter, System.Action<float> setter, System.Attribute[] attributes);
        /*0x72e77c4*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class GetOnlyPropertyCommandDefinition : NoaDebugger.CommandDefinition
    {
        /*0x28*/ System.Func<object> <Getter>k__BackingField;

        /*0x72e787c*/ GetOnlyPropertyCommandDefinition(string categoryName, string displayName, System.Func<object> getter, System.Attribute[] attributes);
        /*0x72e7874*/ System.Func<object> get_Getter();
        /*0x72e78ac*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class HandleMethodCommandDefinition : NoaDebugger.CommandDefinition
    {
        /*0x28*/ System.Func<NoaDebugger.MethodHandler> <Method>k__BackingField;

        /*0x72e7940*/ HandleMethodCommandDefinition(string categoryName, string displayName, System.Func<NoaDebugger.MethodHandler> method, System.Attribute[] attributes);
        /*0x72e7938*/ System.Func<NoaDebugger.MethodHandler> get_Method();
        /*0x72e7970*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class IntPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<int>
    {
        /*0x72e79fc*/ IntPropertyCommandDefinition(string categoryName, string displayName, System.Func<int> getter, System.Action<int> setter, System.Attribute[] attributes);
        /*0x72e7a84*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class LongPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<long>
    {
        /*0x72e7b34*/ LongPropertyCommandDefinition(string categoryName, string displayName, System.Func<long> getter, System.Action<long> setter, System.Attribute[] attributes);
        /*0x72e7bbc*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class MethodCommandDefinition : NoaDebugger.CommandDefinition
    {
        /*0x28*/ System.Action <Method>k__BackingField;

        /*0x72e7c74*/ MethodCommandDefinition(string categoryName, string displayName, System.Action method, System.Attribute[] attributes);
        /*0x72e7c6c*/ System.Action get_Method();
        /*0x72e7ca4*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class MutablePropertyCommandDefinition<T> : NoaDebugger.CommandDefinition
    {
        /*0x0*/ System.Func<T> <Getter>k__BackingField;
        /*0x0*/ System.Action<T> <Setter>k__BackingField;

        /*0x38169d8*/ MutablePropertyCommandDefinition(string categoryName, string displayName, System.Func<T> getter, System.Action<T> setter, System.Attribute[] attributes);
        /*0x38148bc*/ System.Func<T> get_Getter();
        /*0x38148bc*/ System.Action<T> get_Setter();
    }

    class SBytePropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<sbyte>
    {
        /*0x72e7d30*/ SBytePropertyCommandDefinition(string categoryName, string displayName, System.Func<sbyte> getter, System.Action<sbyte> setter, System.Attribute[] attributes);
        /*0x72e7db8*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class ShortPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<short>
    {
        /*0x72e7e68*/ ShortPropertyCommandDefinition(string categoryName, string displayName, System.Func<short> getter, System.Action<short> setter, System.Attribute[] attributes);
        /*0x72e7ef0*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class StringPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<string>
    {
        /*0x72e7fa0*/ StringPropertyCommandDefinition(string categoryName, string displayName, System.Func<string> getter, System.Action<string> setter, System.Attribute[] attributes);
        /*0x72e8028*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class UIntPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<uint>
    {
        /*0x72e80d8*/ UIntPropertyCommandDefinition(string categoryName, string displayName, System.Func<uint> getter, System.Action<uint> setter, System.Attribute[] attributes);
        /*0x72e8160*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class ULongPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<ulong>
    {
        /*0x72e8210*/ ULongPropertyCommandDefinition(string categoryName, string displayName, System.Func<ulong> getter, System.Action<ulong> setter, System.Attribute[] attributes);
        /*0x72e8298*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    class UShortPropertyCommandDefinition : NoaDebugger.MutablePropertyCommandDefinition<ushort>
    {
        /*0x72e8348*/ UShortPropertyCommandDefinition(string categoryName, string displayName, System.Func<ushort> getter, System.Action<ushort> setter, System.Attribute[] attributes);
        /*0x72e83d0*/ NoaDebugger.DebugCommand.ICommand CreateCommand();
    }

    interface IExportData
    {
        /*0x38148bc*/ NoaDebugger.DownloadInfo GetDownloadInfo();
    }

    class DownloadInfo
    {
        static string EXPORT_FILE_DATE_TIME_FORMAT = "yyyyMMdd-HHmmss";
        static string EXPORT_FILE_EXTENSION = "json";
        /*0x10*/ string _exportFilePrefix;

        /*0x72de294*/ DownloadInfo(string prefix);
        /*0x72e8480*/ string GetExportFileName(string label, System.DateTime date);

        class <>c
        {
            static /*0x0*/ NoaDebugger.DownloadInfo.<> <>9;
            static /*0x8*/ System.Predicate<string> <>9__4_0;

            static /*0x72e8790*/ <>c();
            /*0x72e87f8*/ <>c();
            /*0x72e8800*/ bool <GetExportFileName>b__4_0(string s);
        }
    }

    class FileDownloader
    {
        static /*0x0*/ NoaDebugger.FileDownloader.Status _status;
        static /*0x4*/ bool _isOpened;
        static /*0x8*/ string _outputPath;

        static /*0x72e880c*/ System.Collections.IEnumerator DownloadFileCompleted();
        static /*0x72e888c*/ void DownloadFile(string fileName, string textData, string mimeType, System.Action<NoaDebugger.FileDownloader.DownloadInfo> callback);
        static /*0x72e8ae8*/ System.Collections.IEnumerator DownloadFileAsync(string fileName, string textData, string mimeType, System.Action<NoaDebugger.FileDownloader.DownloadInfo> callback);
        static /*0x72e8c9c*/ void DownloadFile(string fileName, string textData, string mimeType);
        static /*0x72e9064*/ string GetMimeType(string extension);
        static /*0x72e914c*/ void OnDownloadFinished(NoaDebugger.FileDownloader.DownloadInfo info);
        static /*0x72e898c*/ bool CanDownload();

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

            /*0x72e8c74*/ <DownloadFileAsync>d__7(int <>1__state);
            /*0x72e93c0*/ void System.IDisposable.Dispose();
            /*0x72e93c4*/ bool MoveNext();
            /*0x72e94c4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72e94cc*/ void System.Collections.IEnumerator.Reset();
            /*0x72e9504*/ object System.Collections.IEnumerator.get_Current();
        }

        class <DownloadFileCompleted>d__0 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ UnityEngine.AndroidJavaClass <fileDownloader>5__2;
            /*0x28*/ int <status>5__3;

            /*0x72e8864*/ <DownloadFileCompleted>d__0(int <>1__state);
            /*0x72e950c*/ void System.IDisposable.Dispose();
            /*0x72e9528*/ bool MoveNext();
            /*0x72e9774*/ void <>m__Finally1();
            /*0x72e9824*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72e982c*/ void System.Collections.IEnumerator.Reset();
            /*0x72e9864*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class FrameTimeInfo
    {
        /*0x10*/ bool <IsEnabled>k__BackingField;
        /*0x11*/ bool <IsActive>k__BackingField;
        /*0x18*/ NoaDebugger.RingBuffer<System.Single[]> <HistoryBuffer>k__BackingField;
        /*0x20*/ System.Collections.Generic.List<System.Single[]> _historyValueBuffer;

        /*0x72e989c*/ FrameTimeInfo(int historyCapacity);
        /*0x72e986c*/ bool get_IsEnabled();
        /*0x72e9874*/ void set_IsEnabled(bool value);
        /*0x72e9880*/ bool get_IsActive();
        /*0x72e9888*/ void set_IsActive(bool value);
        /*0x72e9894*/ NoaDebugger.RingBuffer<System.Single[]> get_HistoryBuffer();
        /*0x72e9a5c*/ void AddHistory(float updateMilliseconds, float renderingMilliseconds, float othersMilliseconds);
        /*0x72e9b94*/ void ClearHistory();
    }

    class ArrayParamCreator : NoaDebugger.IParamCreator
    {
        /*0x72ea648*/ ArrayParamCreator();
        /*0x72e9be4*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> CreateSubParameter(object obj, UnityEngine.Component component, int depth);
        /*0x72ea3f8*/ string GetValue(object obj, object component);
        /*0x72e9d4c*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> _GetGameObjectDetailEntryFromArray(System.Array array, UnityEngine.Component component, int depth);
        /*0x72ea048*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> _GetGameObjectDetailEntryFromList(System.Collections.IList list, UnityEngine.Component component, int depth);
    }

    class ClassParamCreator : NoaDebugger.IParamCreator
    {
        /*0x72eac7c*/ ClassParamCreator();
        /*0x72ea650*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> CreateSubParameter(object obj, UnityEngine.Component component, int depth);
        /*0x72eac74*/ string GetValue(object obj, object component);
    }

    class GameObjectDetailEntry
    {
        /*0x10*/ string _name;
        /*0x18*/ string _value;
        /*0x20*/ bool _isOpen;
        /*0x28*/ NoaDebugger.GameObjectDetailEntryCallback _callback;
        /*0x30*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> _subDetailList;

        /*0x72ea5c0*/ GameObjectDetailEntry();
        /*0x72eac84*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailPanelData> GetPanelDataListWithSubDetail(NoaDebugger.GameObjectDetailEntryCallback callback);
        /*0x72ead10*/ void _AddPanelDataList(System.Collections.Generic.List<NoaDebugger.GameObjectDetailPanelData> list, NoaDebugger.GameObjectDetailEntryCallback callback, int depth);
        /*0x72eaf80*/ void _OnToggleOpen();
    }

    class GameObjectDetailEntryCallback
    {
        /*0x10*/ System.Action _onUpdateView;

        /*0x72eafc0*/ GameObjectDetailEntryCallback();
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

        /*0x72eb324*/ HierarchyGameObjectEntry();
        /*0x72eafc8*/ System.Collections.Generic.List<NoaDebugger.HierarchyPanelData> GetPanelDataListWithChildren(NoaDebugger.HierarchyGameObjectEntryCallback callback);
        /*0x72eb054*/ void _AddPanelData(System.Collections.Generic.List<NoaDebugger.HierarchyPanelData> list, NoaDebugger.HierarchyGameObjectEntryCallback callback, int depth);
        /*0x72eb2d4*/ void _OnToggleOpen();
        /*0x72eb2d8*/ void SwitchToggle();
    }

    class HierarchyGameObjectEntryCallback
    {
        /*0x10*/ System.Action<NoaDebugger.HierarchyGameObjectEntry> _onSelect;
        /*0x18*/ System.Action<int, bool> _onToggleOpen;
        /*0x20*/ System.Action _onUpdateView;

        /*0x72eb3ac*/ HierarchyGameObjectEntryCallback();
    }

    class HierarchyModelHelper
    {
        static /*0x72eb3b4*/ bool IsViewPropertyInfo(System.Reflection.PropertyInfo propertyInfo);
        static /*0x72ea9b4*/ bool IsViewFieldInfo(System.Reflection.FieldInfo fieldInfo);
        /*0x72eb550*/ HierarchyModelHelper();
    }

    interface IParamCreator
    {
        System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> CreateSubParameter(object obj, UnityEngine.Component component, int depth);
        /*0x3814b90*/ string GetValue(object obj, object component);
    }

    class ParamCreatorFactory
    {
        static /*0x72ea400*/ NoaDebugger.IParamCreator ParamCreatorByType(System.Type type);
        /*0x72eb568*/ ParamCreatorFactory();
    }

    class PrimitiveParamCreator : NoaDebugger.IParamCreator
    {
        /*0x72eb560*/ PrimitiveParamCreator();
        /*0x72eb570*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> CreateSubParameter(object obj, UnityEngine.Component component, int depth);
        /*0x72eb5d8*/ string GetValue(object obj, object component);
    }

    class StructParamCreator : NoaDebugger.IParamCreator
    {
        /*0x72eb558*/ StructParamCreator();
        /*0x72eb708*/ System.Collections.Generic.List<NoaDebugger.GameObjectDetailEntry> CreateSubParameter(object obj, UnityEngine.Component component, int depth);
        /*0x72eba6c*/ string GetValue(object obj, object component);
    }

    class InformationCustomGroup
    {
        /*0x10*/ string <Name>k__BackingField;
        /*0x18*/ string <DisplayName>k__BackingField;
        /*0x20*/ System.Collections.Generic.List<NoaDebugger.InformationCustomKeyValue> <KeyValues>k__BackingField;
        /*0x28*/ int <Order>k__BackingField;

        /*0x72eba94*/ InformationCustomGroup(string name, string displayName, System.Collections.Generic.List<NoaDebugger.InformationCustomKeyValue> keyValues, int order);
        /*0x72eba74*/ string get_Name();
        /*0x72eba7c*/ string get_DisplayName();
        /*0x72eba84*/ System.Collections.Generic.List<NoaDebugger.InformationCustomKeyValue> get_KeyValues();
        /*0x72eba8c*/ int get_Order();
        /*0x72ebb00*/ System.Collections.Generic.Dictionary<string, string> GetKeyValuesAsDictionary();

        class <>c__DisplayClass13_0
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, string> keyValues;

            /*0x72ebc30*/ <>c__DisplayClass13_0();
            /*0x72ebc38*/ void <GetKeyValuesAsDictionary>b__0(NoaDebugger.InformationCustomKeyValue kv);
        }
    }

    class InformationCustomKeyValue
    {
        /*0x10*/ string <Key>k__BackingField;
        /*0x18*/ System.Func<string> <GetValue>k__BackingField;
        /*0x20*/ string <DisplayName>k__BackingField;
        /*0x28*/ int <Order>k__BackingField;

        /*0x72ebcd8*/ InformationCustomKeyValue(string keyName, System.Func<string> getValue, string displayName, int order);
        /*0x72ebcb8*/ string get_Key();
        /*0x72ebcc0*/ System.Func<string> get_GetValue();
        /*0x72ebcc8*/ string get_DisplayName();
        /*0x72ebcd0*/ int get_Order();
    }

    class Input
    {
        static /*0x0*/ NoaDebugger.InputInternal Internal;

        static /*0x72ebed4*/ Input();
        static /*0x72ebd44*/ void Initialize();
        static /*0x72ebda8*/ bool IsButtonUp();
        static /*0x72ebe0c*/ bool IsButtonReleased();
        static /*0x72ebe70*/ UnityEngine.Vector2 GetCursorPosition();
    }

    class ShortcutInputCombination
    {
        /*0x10*/ bool isEnabled;
        /*0x18*/ NoaDebugger.ShortcutKeyboardBinding keyboard;

        /*0x72ebf50*/ ShortcutInputCombination();
    }

    class ShortcutAction
    {
        /*0x10*/ NoaDebugger.ShortcutActionType actionType;
        /*0x18*/ NoaDebugger.ShortcutInputCombination combination;

        /*0x72ebf68*/ ShortcutAction(NoaDebugger.ShortcutActionType type);
        /*0x72ebf60*/ NoaDebugger.ShortcutActionType get_Type();
        /*0x72ebff0*/ string GetDisplayText(bool isRuntime);
        /*0x72ec030*/ string GetDisplayText(bool isRuntime, bool isWindows, bool isMac);
        /*0x72ec380*/ bool _TryGetModifierKey(NoaDebugger.ShortcutModifierKey modifier, bool isRuntime, bool isWindows, bool isMac, ref string modifierKey);
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

        /*0x72ed124*/ ShortcutActionHandler();
        /*0x72ec59c*/ bool get_IsShortcutsEnabled();
        /*0x72ec5a4*/ void set_IsShortcutsEnabled(bool value);
        /*0x72ec5b0*/ void Awake();
        /*0x72ec67c*/ void Update();
        /*0x72ec888*/ System.ValueTuple<bool, bool, bool> _IsTrigger(NoaDebugger.ShortcutAction action);
        /*0x72ecba8*/ void _ExecuteAction(NoaDebugger.ShortcutActionType actionType, bool shortPress, bool longPress, bool holdDown);

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

        static /*0x72ed3e0*/ UnityInputUtils();
        static /*0x72ed12c*/ void AddInputModule(UnityEngine.GameObject target);
        static /*0x72ec618*/ void OnShortcutHandlerInitialize();
        static /*0x72ecfbc*/ bool IsShortcutKeyDown(NoaDebugger.ShortcutAction action);
        static /*0x72ed034*/ bool IsShortcutKeyHeld(NoaDebugger.ShortcutAction action);
        static /*0x72ed0ac*/ bool IsShortcutKeyUp(NoaDebugger.ShortcutAction action);
        static /*0x72ec530*/ string GetKeyTextFromInt(int keyNum);
        static /*0x72ed198*/ int GetCurrentDefaultKey(NoaDebugger.ShortcutActionType actionType);
        static /*0x72ed204*/ int GetDefaultShortcutKey(NoaDebugger.ShortcutActionType actionType, bool forInputSystem);
        static /*0x72ed2e0*/ int GetCurrentKey(UnityEngine.Event current);
        static /*0x72ed34c*/ void CheckInputSystemAvailable();
    }

    class JsonFormatter
    {
        static string DEFAULT_INDENT_STRING = "  ";
        static NoaDebugger.JsonFormatter.NewLine DEFAULT_NEW_LINE = 1;

        static /*0x72ed47c*/ string Format(string inputJson, string indentString, NoaDebugger.JsonFormatter.NewLine newLine);

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

            static /*0x72ed96c*/ void ReportWarning(string message);
            /*0x72ed628*/ Formatter(string inputJson, string indentString, NoaDebugger.JsonFormatter.NewLine newLine);
            /*0x72ed810*/ void Dispose();
            /*0x72ed7bc*/ string Format();
            /*0x72ed82c*/ bool ReadValue();
            /*0x72eda34*/ bool ReadObject();
            /*0x72eddec*/ bool ReadObjectMember();
            /*0x72edb0c*/ bool ReadArray();
            /*0x72edbe4*/ bool ReadNumber();
            /*0x72ede70*/ bool ReadInteger();
            /*0x72ededc*/ bool ReadFraction();
            /*0x72edf24*/ bool ReadExponent();
            /*0x72edf9c*/ bool ReadDigits();
            /*0x72edc18*/ bool ReadString();
            /*0x72ee008*/ bool ReadEscapeSequence();
            /*0x72edca0*/ bool ReadLiteral(string expectedLiteral);
            /*0x72edd3c*/ void ReadCharacter();
            /*0x72ed9c4*/ void SkipWhitespaces();
            /*0x72edd78*/ void IncreaseIndent();
            /*0x72ede60*/ void DecreaseIndent();
            /*0x72edd88*/ void NextLine();
        }
    }

    class ConsoleLogQueue
    {
        static /*0x0*/ System.Collections.Concurrent.ConcurrentQueue<System.ValueTuple<UnityEngine.LogType, string, string>> <LogQueue>k__BackingField;

        static /*0x72ee454*/ ConsoleLogQueue();
        static /*0x72ee14c*/ System.Collections.Concurrent.ConcurrentQueue<System.ValueTuple<UnityEngine.LogType, string, string>> get_LogQueue();
        static /*0x72ee1a4*/ void EnqueueLog(UnityEngine.LogType type, string message, string stackTrace);
        static /*0x72ee2b8*/ void FlushLog(System.Action<UnityEngine.LogType, string, string> logCallback);
        static /*0x72ee3a4*/ void ClearLog();
        /*0x72ee44c*/ ConsoleLogQueue();
    }

    class LogFilterRepository
    {
        /*0x10*/ string _prefsKey;

        /*0x72ee4ec*/ LogFilterRepository(string prefsKey);
        /*0x72ee51c*/ void SaveFilter(System.Collections.Generic.Dictionary<NoaDebugger.LogType, bool> flagDictionary);
        /*0x72ee774*/ System.Collections.Generic.Dictionary<NoaDebugger.LogType, bool> LoadFilter(System.Collections.Generic.Dictionary<NoaDebugger.LogType, bool> flagDictionary);
        /*0x72ee6dc*/ NoaDebugger.LogFilterRepository.InternalLogType _GetInternalLogTypeFrom(NoaDebugger.LogType logType);
        /*0x72ee9b8*/ bool _IsLogTypeTrue(NoaDebugger.LogType logType, NoaDebugger.LogFilterRepository.InternalLogType targetFlag);
        /*0x72ee6d4*/ NoaDebugger.LogFilterRepository.InternalLogType _AllTrue();

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

        static /*0x72eea40*/ void Instantiate(UnityEngine.Transform parent);
        static /*0x72eeb30*/ void SetAction(string key, System.Action<bool> action, NoaDebugger.ApplicationBackgroundManager.SameKeyActionType type);
        static /*0x72eedd4*/ void DeleteAction(string key);
        /*0x72ef274*/ ApplicationBackgroundManager();
        /*0x72ee9d4*/ bool get_IsBackground();
        /*0x72ee9dc*/ void set_IsBackground(bool value);
        /*0x72ee9e8*/ void Awake();
        /*0x72eec00*/ void _SetAction(string key, System.Action<bool> action, NoaDebugger.ApplicationBackgroundManager.SameKeyActionType type);
        /*0x72eee88*/ void _DeleteAction(string key);
        /*0x72eef18*/ void OnApplicationPause(bool pauseStatus);
        /*0x72ef214*/ void OnApplicationFocus(bool hasFocus);
        /*0x72eef20*/ void _ChangeBackgroundStatus(bool isBackground);
        /*0x72ef220*/ void OnDestroy();

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

        static /*0x72dfacc*/ bool get_IsPortrait();
        static /*0x72ef2fc*/ void Init(UnityEngine.Transform parent);
        static /*0x72df938*/ bool ContainsKey(string key);
        static /*0x72dfa10*/ void SetAction(string key, System.Action<bool> action);
        static /*0x72dfd78*/ void DeleteAction(string key);
        /*0x72efa68*/ DeviceOrientationManager();
        /*0x72ef3e0*/ void _SetAction(string key, System.Action<bool> action);
        /*0x72ef448*/ void _DeleteAction(string key);
        /*0x72ef52c*/ void _WatchDeviceOrientation();
        /*0x72efa10*/ void Update();
        /*0x72efa14*/ void OnDestroy();

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

        static /*0x72f0220*/ EventSystemManager();
        static /*0x72efb44*/ void Init(UnityEngine.Transform parent);
        /*0x72f0218*/ EventSystemManager();
        /*0x72efbf8*/ void Awake();
        /*0x72efd14*/ void _OnLoadSceneAddOrDisabledEventSystem(UnityEngine.SceneManagement.Scene arg0, UnityEngine.SceneManagement.LoadSceneMode loadSceneMode);
        /*0x72f0184*/ void _OnUnloadSceneDisableEventSystem(UnityEngine.SceneManagement.Scene arg0);
        /*0x72effa4*/ void _AddEventSystem();
        /*0x72f020c*/ void OnDestroy();

        class <>c
        {
            static /*0x0*/ NoaDebugger.EventSystemManager.<> <>9;
            static /*0x8*/ System.Predicate<UnityEngine.EventSystems.EventSystem> <>9__4_0;

            static /*0x72f028c*/ <>c();
            /*0x72f02f4*/ <>c();
            /*0x72f02fc*/ bool <_OnLoadSceneAddOrDisabledEventSystem>b__4_0(UnityEngine.EventSystems.EventSystem e);
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

        static /*0x72f04dc*/ void Instantiate(UnityEngine.Transform parent);
        static /*0x72f05cc*/ NoaDebugger.FrameTimeMeasurer GetInstance();
        /*0x72f0b14*/ FrameTimeMeasurer();
        /*0x72f037c*/ void add_OnUpdateFrameTime(System.Action<double, double, double> value);
        /*0x72f042c*/ void remove_OnUpdateFrameTime(System.Action<double, double, double> value);
        /*0x72f0614*/ void Awake();
        /*0x72f0830*/ void Update();
        /*0x72f0904*/ void OnEndOfUpdate();
        /*0x72f0984*/ void OnCameraPreRender(UnityEngine.Camera _);
        /*0x72f0a14*/ void OnCameraPostRender(UnityEngine.Camera _);
        /*0x72f0a9c*/ void OnDestroy();
    }

    class GlobalCoroutine : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ NoaDebugger.GlobalCoroutine _instance;

        static /*0x72f0b80*/ bool get_IsExecutable();
        static /*0x72f0bf8*/ void Init(UnityEngine.Transform parent);
        static /*0x72f0ce8*/ void Dispose();
        static /*0x72e8ba0*/ UnityEngine.Coroutine Run(System.Collections.IEnumerator routine, UnityEngine.Events.UnityAction onComplete);
        static /*0x72f0e00*/ void Stop(System.Collections.IEnumerator routine);
        /*0x72f0eb8*/ GlobalCoroutine();
        /*0x72f0d3c*/ System.Collections.IEnumerator Routine(System.Collections.IEnumerator src, UnityEngine.Events.UnityAction onComplete);

        class <Routine>d__6 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.GlobalCoroutine <>4__this;
            /*0x28*/ System.Collections.IEnumerator src;
            /*0x30*/ UnityEngine.Events.UnityAction onComplete;

            /*0x72f0dd8*/ <Routine>d__6(int <>1__state);
            /*0x72f0ec0*/ void System.IDisposable.Dispose();
            /*0x72f0ec4*/ bool MoveNext();
            /*0x72f0f44*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72f0f4c*/ void System.Collections.IEnumerator.Reset();
            /*0x72f0f84*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class OverlayManager : UnityEngine.EventSystems.UIBehaviour
    {
        /*0x20*/ UnityEngine.RectTransform _overlayParentTransform;
        /*0x28*/ UnityEngine.RectTransform _applySafeAreaRect;
        /*0x30*/ UnityEngine.RectTransform _unApplySafeAreaRect;
        /*0x38*/ UnityEngine.Transform _overlaySettingsParentTransform;
        /*0x40*/ System.Func<NoaDebugger.INoaDebuggerTool> _getCurrentTool;

        /*0x72f14a4*/ OverlayManager();
        /*0x72f0f8c*/ UnityEngine.Transform get_OverlayRoot();
        /*0x72f0f94*/ void Awake();
        /*0x72f0f98*/ void Initialize(UnityEngine.Transform overlaySettingsParent, System.Func<NoaDebugger.INoaDebuggerTool> getCurrentTool);
        /*0x72f0fd0*/ void ResetRootRectSize();
        /*0x72f10b8*/ void OnRectTransformDimensionsChange();
        /*0x72f10bc*/ void PinOverlayTool();
        /*0x72f1194*/ void ToggleOverlaySettings();
        /*0x72f126c*/ NoaDebugger.INoaDebuggerOverlayTool GetOverlayToolFromOverlayFeatures(NoaDebugger.NoaDebug.OverlayFeatures feature);
        /*0x72f135c*/ void SetOverlayEnabled(NoaDebugger.INoaDebuggerOverlayTool overlayTool, bool isEnabled, System.Action onChanged);
    }

    class UpdateManager : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ NoaDebugger.UpdateManager _instance;
        /*0x20*/ System.Collections.Concurrent.ConcurrentDictionary<string, System.Action> _actionDic;
        /*0x28*/ System.Collections.Concurrent.ConcurrentBag<string> _deleteActionKeyList;

        static /*0x72f1504*/ void _Instantiate();
        static /*0x72deb34*/ bool ContainsKey(string key);
        static /*0x72debfc*/ void SetAction(string key, System.Action action);
        static /*0x72f1660*/ void AddOrOverwriteAction(string key, System.Action action);
        static /*0x72f1778*/ void ReplaceAction(string key, System.Action action);
        static /*0x72decac*/ void DeleteAction(string key);
        /*0x72f2048*/ UpdateManager();
        /*0x72f14ac*/ void Awake();
        /*0x72f15f8*/ void _SetAction(string key, System.Action action);
        /*0x72f1710*/ void _AddOrOverwriteAction(string key, System.Action action);
        /*0x72f1828*/ void _ReplaceAction(string key, System.Action action);
        /*0x72f18cc*/ void _DeleteAction(string key);
        /*0x72f195c*/ void Update();
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

        static /*0x72f2124*/ System.Action get_OnShow();
        static /*0x72f2178*/ void set_OnShow(System.Action value);
        static /*0x72f21d4*/ System.Action get_OnHide();
        static /*0x72f2228*/ void set_OnHide(System.Action value);
        static /*0x72f2284*/ System.Action<bool> get_OnTogglePauseResume();
        static /*0x72f22d8*/ void set_OnTogglePauseResume(System.Action<bool> value);
        static /*0x72f2334*/ System.Action<float> get_OnGameSpeedChanged();
        static /*0x72f2388*/ void set_OnGameSpeedChanged(System.Action<float> value);
        static /*0x72f23e4*/ System.Func<bool> get_OnApplicationReset();
        static /*0x72f2438*/ void set_OnApplicationReset(System.Func<bool> value);
        static /*0x72f2494*/ System.Func<NoaDebugger.NoaController.ScreenshotTarget> get_OnBeforeScreenshot();
        static /*0x72f24e8*/ void set_OnBeforeScreenshot(System.Func<NoaDebugger.NoaController.ScreenshotTarget> value);
        static /*0x72f2544*/ System.Func<bool> get_OnCaptureScreenshot();
        static /*0x72f2598*/ void set_OnCaptureScreenshot(System.Func<bool> value);
        static /*0x72f25f4*/ System.Action get_OnAfterScreenshot();
        static /*0x72f2648*/ void set_OnAfterScreenshot(System.Action value);
        static /*0x72f26a4*/ System.Action get_OnFrameStepping();
        static /*0x72f26f8*/ void set_OnFrameStepping(System.Action value);
        static /*0x72f2754*/ bool get_IsGamePlaying();
        static /*0x72f27a4*/ float get_GameSpeed();
        static /*0x72f282c*/ void Initialize(NoaDebugger.NoaControllerView controllerView, NoaDebugger.NoaDebuggerButtonEffectManager buttonEffectManager);
        static /*0x72f2f38*/ void SetCustomTapAction(int buttonIndex, System.Action action, System.Func<string> messageFunc);
        static /*0x72f3140*/ void SetCustomLongPressAction(int buttonIndex, System.Action action, System.Func<string> messageFunc);
        static /*0x72f3348*/ void SetCustomToggleAction(int buttonIndex, System.Action<bool> action, System.Func<bool, string> messageFunc, System.Nullable<bool> initialState);
        static /*0x72f378c*/ void SetCustomActionType(int buttonIndex, NoaDebugger.NoaController.CustomActionType actionType);
        static /*0x72f3868*/ NoaDebugger.NoaController.CustomActionType GetCustomActionType(int buttonIndex);
        static /*0x72f3918*/ void RunCustomTapAction(int buttonIndex);
        static /*0x72f39dc*/ void RunCustomLongPressAction(int buttonIndex);
        static /*0x72f3aa0*/ void SetCustomToggle(int buttonIndex, bool isOn);
        static /*0x72f3b08*/ bool GetCustomToggle(int buttonIndex);
        static /*0x72f3bd4*/ void TogglePauseResume();
        static /*0x72f3d00*/ void IncreaseGameSpeed();
        static /*0x72f3dac*/ void DecreaseGameSpeed();
        static /*0x72f3e58*/ void MinimizeGameSpeed();
        static /*0x72f3f04*/ void MaximizeGameSpeed();
        static /*0x72f3fb0*/ void ResetGameSpeed();
        static /*0x72f405c*/ void FrameStepping();
        static /*0x72f4110*/ void ResetApplication();
        static /*0x72f41b8*/ void CaptureScreenshot();
        static /*0x72f422c*/ byte[] GetCapturedScreenshot();
        static /*0x72f4280*/ void ClearCapturedScreenshot();
        static /*0x72f42d8*/ void TakeScreenshot(System.Action<System.Byte[]> callback);
        static /*0x72f4674*/ bool _IsButtonIndexInRange(int buttonIndex);
        static /*0x72f4e2c*/ byte[] CaptureScreenshotInternal();
        /*0x72f28a8*/ NoaControllerManager(NoaDebugger.NoaControllerView controllerView, NoaDebugger.NoaDebuggerButtonEffectManager buttonEffectManager);
        /*0x72f43c0*/ void _OnLoadScene(UnityEngine.SceneManagement.Scene _, UnityEngine.SceneManagement.LoadSceneMode __);
        /*0x72f4408*/ void _OnShow();
        /*0x72f4650*/ void _OnHide();
        /*0x72f2fa8*/ void _SetCustomTapAction(int buttonIndex, System.Action action, System.Func<string> messageFunc);
        /*0x72f46e4*/ void _NotifyCustomActionTapped(int buttonIndex);
        /*0x72f31b0*/ void _SetCustomLongPressAction(int buttonIndex, System.Action action, System.Func<string> messageFunc);
        /*0x72f4838*/ void _NotifyCustomActionLongPressed(int buttonIndex);
        /*0x72f34f4*/ void _SetCustomToggleAction(int buttonIndex, System.Action<bool> action, System.Func<bool, string> messageFunc);
        /*0x72f3728*/ void _SetCustomToggleMessage(int buttonIndex, System.Func<bool, string> messageFunc);
        /*0x72f498c*/ void _NotifyCustomActionToggled(int buttonIndex, bool isOn);
        /*0x72f37f4*/ void _SetCustomActionType(int buttonIndex, NoaDebugger.NoaController.CustomActionType actionType);
        /*0x72f38c0*/ NoaDebugger.NoaController.CustomActionType _GetCustomActionType(int buttonIndex);
        /*0x72f3970*/ void _RunCustomTapAction(int buttonIndex);
        /*0x72f3a34*/ void _RunCustomLongPressAction(int buttonIndex);
        /*0x72f3668*/ void _SetCustomToggle(int buttonIndex, bool isOn);
        /*0x72f3b60*/ bool _GetCustomToggle(int buttonIndex);
        /*0x72f3c34*/ void _TogglePauseResume(bool isResume);
        /*0x72f3d50*/ void _IncreaseGameSpeed();
        /*0x72f3f54*/ void _MaximizeGameSpeed();
        /*0x72f3dfc*/ void _DecreaseGameSpeed();
        /*0x72f3ea8*/ void _MinimizeGameSpeed();
        /*0x72f4000*/ void _ResetGameSpeed();
        /*0x72f4b04*/ void _UpdateGameSpeed();
        /*0x72f40ac*/ void _FrameStepping();
        /*0x72f4c54*/ void _Close();
        /*0x72f4160*/ void _ResetApplication();
        /*0x72f4c60*/ void _OnFinishTransitionToInitialScene();
        /*0x72f4c74*/ System.Collections.IEnumerator _OnFinishTransitionToInitialSceneRoutine();
        /*0x72f4214*/ void _CaptureScreenshot();
        /*0x72f4d08*/ void _ShowNoaDebugger();
        /*0x72f4338*/ System.Collections.IEnumerator CaptureScreenshotCoroutine(System.Action<System.Byte[]> callback);
        /*0x72f4f3c*/ void <.ctor>b__70_0();

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

            static /*0x72f4fe0*/ <>c();
            /*0x72f5048*/ <>c();
            /*0x72f5050*/ string <SetCustomToggleAction>b__51_0(bool _);
        }

        class <>c__DisplayClass74_0
        {
            /*0x10*/ NoaDebugger.NoaControllerManager <>4__this;
            /*0x18*/ int buttonIndex;

            /*0x72f466c*/ <>c__DisplayClass74_0();
            /*0x72f5058*/ void <_SetCustomTapAction>b__0();
        }

        class <>c__DisplayClass76_0
        {
            /*0x10*/ NoaDebugger.NoaControllerManager <>4__this;
            /*0x18*/ int buttonIndex;

            /*0x72f4830*/ <>c__DisplayClass76_0();
            /*0x72f5078*/ void <_SetCustomLongPressAction>b__0();
        }

        class <>c__DisplayClass78_0
        {
            /*0x10*/ System.Action<bool> action;
            /*0x18*/ NoaDebugger.NoaControllerManager <>4__this;
            /*0x20*/ int buttonIndex;

            /*0x72f4984*/ <>c__DisplayClass78_0();
            /*0x72f5098*/ void <_SetCustomToggleAction>b__0(bool isOn);
        }

        class <CaptureScreenshotCoroutine>d__102 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.NoaControllerManager <>4__this;
            /*0x28*/ System.Action<System.Byte[]> callback;
            /*0x30*/ NoaDebugger.NoaDebuggerVisibilityManager.ScreenshotUIVisibilityManager <screenshotUIVisibilityManager>5__2;

            /*0x72f4e04*/ <CaptureScreenshotCoroutine>d__102(int <>1__state);
            /*0x72f50e4*/ void System.IDisposable.Dispose();
            /*0x72f50e8*/ bool MoveNext();
            /*0x72f532c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72f5334*/ void System.Collections.IEnumerator.Reset();
            /*0x72f536c*/ object System.Collections.IEnumerator.get_Current();
        }

        class <_OnFinishTransitionToInitialSceneRoutine>d__99 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.NoaControllerManager <>4__this;

            /*0x72f4ce0*/ <_OnFinishTransitionToInitialSceneRoutine>d__99(int <>1__state);
            /*0x72f5374*/ void System.IDisposable.Dispose();
            /*0x72f5378*/ bool MoveNext();
            /*0x72f5498*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x72f54a0*/ void System.Collections.IEnumerator.Reset();
            /*0x72f54d8*/ object System.Collections.IEnumerator.get_Current();
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

        static /*0x72f87d4*/ NoaDebugger();
        static /*0x72f55c4*/ UnityEngine.Transform get_MainViewRoot();
        static /*0x72f5630*/ UnityEngine.Transform get_FloatingWindowRoot();
        static /*0x72f569c*/ UnityEngine.Transform get_DialogRoot();
        static /*0x72f5700*/ NoaDebugger.ToastView get_ToastInstance();
        static /*0x72f5764*/ UnityEngine.Transform get_UIElementRoot();
        static /*0x72f57d0*/ UnityEngine.Transform get_OverlayRoot();
        static /*0x72f7b50*/ bool IsShowTargetToolMainView(NoaDebugger.INoaDebuggerTool tool);
        static /*0x72f7c28*/ void ShowNoaDebugger(int index, System.Nullable<bool> isCustomMenu);
        static /*0x72f4d6c*/ void ShowNoaDebuggerLastActiveTool();
        static /*0x72e926c*/ void ShowToast(NoaDebugger.ToastViewLinker linker);
        static /*0x3910ae8*/ TPresenter GetPresenter<TPresenter>();
        static /*0x72f7aec*/ NoaDebugger.INoaDebuggerTool[] AllPresenters();
        static /*0x72f7e5c*/ NoaDebugger.INoaDebuggerTool[] AllCustomPresenters();
        static /*0x383e7a0*/ void OnChangeNotificationStatus<TPresenter>();
        static /*0x72e105c*/ bool get_IsErrorNotice();
        static /*0x72f7ec0*/ bool IsInternalError(string stackTrace);
        static /*0x72f7fb8*/ bool ContainsCustomClassNameByText(string text);
        /*0x72f87cc*/ NoaDebugger();
        /*0x72f54e0*/ System.Action<int> get_OnShow();
        /*0x72f54e8*/ void set_OnShow(System.Action<int> value);
        /*0x72f54f0*/ System.Action<int> get_OnHide();
        /*0x72f54f8*/ void set_OnHide(System.Action<int> value);
        /*0x72f5500*/ bool get_IsInitialized();
        /*0x72f5508*/ void set_IsInitialized(bool value);
        /*0x72f5514*/ bool get_IsShortcutsEnabled();
        /*0x72f5530*/ bool get_IsWorldSpaceRenderingEnabled();
        /*0x72f55bc*/ NoaDebugger.NoaUIElementManager get_NoaUIElementManager();
        /*0x72f583c*/ void Awake();
        /*0x72f58fc*/ System.Action<int, bool> get_OnMenuChanged();
        /*0x72f5904*/ void set_OnMenuChanged(System.Action<int, bool> value);
        /*0x72f5914*/ void Init();
        /*0x72f5918*/ void _Init();
        /*0x72f6c6c*/ void _InitNoaDebuggerTools();
        /*0x72f70b4*/ void _DestroyNoaDebugger();
        /*0x72f72e8*/ void _OnDeviceOrientation(bool isPortrait);
        /*0x72f6000*/ NoaDebugger.INoaDebuggerTool[] _FindNoaDebuggerTools();
        /*0x72f644c*/ NoaDebugger.INoaDebuggerTool[] _FindCustomNoaDebuggerTools();
        /*0x72f7370*/ void _ChangeTool(int index, bool isMenuActive, bool isChangeMenu);
        /*0x72f757c*/ void _HideTool(int index);
        /*0x72f7664*/ void _ChangeToolButton(int index);
        /*0x72f7670*/ void _ShowToolDetail();
        /*0x72f777c*/ void CloseNoaDebugger();
        /*0x72f77c4*/ void _SetLastActiveToolIndex();
        /*0x3814574*/ int _GetTargetToolIndex<T>();
        /*0x72f78ec*/ void _PinFloatingWindowTool();
        /*0x72f7a10*/ void _ShowController();
        /*0x72f7a6c*/ void _ChangeTab(bool isShowCustomTab);
        /*0x72f78a0*/ void _SwitchShowTools(bool isShowCustom);
        /*0x72f684c*/ void _UpdateNoaDebuggerTools();
        /*0x72f7ae0*/ void _SwitchNoaDebuggerTools();
        /*0x72f7ad4*/ void _SwitchCustomNoaDebuggerTools();
        /*0x72f79c4*/ NoaDebugger.INoaDebuggerTool _CurrentTool();
        /*0x72f74c0*/ int _GetToolIndexAfterValidation(int index);
        /*0x72f728c*/ void _DisableNoaDebugger();
        /*0x72f74a0*/ System.Collections.Generic.List<NoaDebugger.CustomMenuInfo> GetCustomMenuInfo();
        /*0x72f81a8*/ void SetOverlayEnabled(NoaDebugger.NoaDebug.OverlayFeatures feature, bool isEnabled);
        /*0x72f82bc*/ bool GetOverlayEnabled(NoaDebugger.NoaDebug.OverlayFeatures feature);
        /*0x72f837c*/ void SetShortcutsEnabled(bool isEnabled);
        /*0x72f8404*/ void EnableWorldSpaceRendering(UnityEngine.Camera worldCamera);
        /*0x72f84c0*/ void DisableWorldSpaceRendering();
        /*0x72f85dc*/ void Dispose();

        class <>c
        {
            static /*0x0*/ NoaDebugger.NoaDebugger.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.INoaDebuggerTool, bool> <>9__99_0;

            static /*0x72f8840*/ <>c();
            /*0x72f88a8*/ <>c();
            /*0x72f88b0*/ bool <get_IsErrorNotice>b__99_0(NoaDebugger.INoaDebuggerTool tool);
        }

        class <>c__DisplayClass103_0
        {
            /*0x10*/ NoaDebugger.NoaDebugger <>4__this;
            /*0x18*/ NoaDebugger.INoaDebuggerOverlayTool overlayTool;

            /*0x72f895c*/ <>c__DisplayClass103_0();
            /*0x72f8964*/ void <SetOverlayEnabled>b__0();
        }

        class <>c__DisplayClass84_0
        {
            /*0x10*/ NoaDebugger.MenuInfo menuSetting;

            /*0x72f89b4*/ <>c__DisplayClass84_0();
            /*0x72f89bc*/ bool <_UpdateNoaDebuggerTools>b__0(NoaDebugger.INoaDebuggerTool tool);
        }
    }

    class NoaDebuggerButtonEffectManager : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.NoaDebuggerButton _noaDebuggerButton;
        /*0x28*/ NoaDebugger.NoaDebuggerButtonInController _buttonInController;
        /*0x30*/ bool _isInitialized;

        /*0x72f8d3c*/ NoaDebuggerButtonEffectManager();
        /*0x72f8af0*/ NoaDebugger.NoaDebuggerButton get_NoaDebuggerButton();
        /*0x72f8af8*/ void Init();
        /*0x72f8b40*/ void _OnValidateUI();
        /*0x72f8b44*/ void PlayOnErrorAnimation();
        /*0x72f8c38*/ void PlayOnLocationAnimation();
        /*0x72f8c68*/ void ResetButtonColor();
        /*0x72f8ca4*/ bool IsPlayingAnimation();
        /*0x72f8ce0*/ void Dispose();
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

        static /*0x72f8da8*/ NoaDebuggerDefine();
        static /*0x72f8d44*/ string get_Ellipsis();
        static /*0x72f8d84*/ NoaDebugger.NoaDebuggerDefine.ShortCutTriggerType GetTriggerType(NoaDebugger.ShortcutActionType actionType);

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

            static /*0x72f9760*/ TextColors();
        }

        struct ImageColors
        {
            static /*0x0*/ UnityEngine.Color Default;
            static /*0x10*/ UnityEngine.Color Disabled;
            static /*0x20*/ UnityEngine.Color Clear;
            static /*0x30*/ UnityEngine.Color Warning;
            static /*0x40*/ UnityEngine.Color SnapshotFirstSelected;
            static /*0x50*/ UnityEngine.Color SnapshotSecondSelected;

            static /*0x72f98c4*/ ImageColors();
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

            static /*0x72f9964*/ BackgroundColors();
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

            static /*0x72f9a98*/ LogColors();
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

        static /*0x72f9c58*/ int CompareVersions(string version1, string version2);
        /*0x72f9ec0*/ NoaDebuggerInfo();
        /*0x72f9b0c*/ void OnValidate();
        /*0x72f9bf4*/ string get_NoaDebuggerVersion();
        /*0x72f9bfc*/ string get_MinimumUnityVersion();
        /*0x72f9c04*/ string get_MinimumUnityVersionForMobileBrowser();
        /*0x72f9c0c*/ string get_MinimumIOSVersion();
        /*0x72f9c14*/ string get_MinimumAndroidVersion();
        /*0x72f9c1c*/ string get_MinimumWindowsVersion();
        /*0x72f9c24*/ NoaDebugger.SupportBrowserInfo[] get_SupportedPCBrowsersInfo();
        /*0x72f9c2c*/ NoaDebugger.SupportBrowserInfo[] get_SupportedMobileBrowsersInfo();
        /*0x72f9c34*/ string get_NoaDebuggerCopyright();
        /*0x72f9c3c*/ bool IsSupportedUnityVersion(string version);
        /*0x72f9cac*/ bool IsSupportedIOSVersion(string version);
        /*0x72f9cc8*/ bool IsSupportedAndroidVersion(string version);
        /*0x72f9ce4*/ bool IsSupportedWindowsVersion(string version);
        /*0x72f9d00*/ bool IsSupportedBrowser(string browser, string operatingSystem, string unityVersion);
        /*0x72f9dd0*/ bool _IsSupportedBrowser(string browser, string operatingSystem, NoaDebugger.SupportBrowserInfo[] supportedBrowsersInfo);

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

        /*0x72f9ee0*/ SupportBrowserInfo();
        /*0x72f9ec8*/ string[] get_OperatingSystemPrefixList();
        /*0x72f9ed0*/ string get_DisplayOperatingSystem();
        /*0x72f9ed8*/ string get_Browser();
    }

    class NoaDebuggerInfoManager
    {
        static string TOOL_INFORMATION_ASSET_NAME = "NoaDebuggerInfo";
        static /*0x0*/ NoaDebugger.NoaDebuggerInfoManager _instance;
        /*0x10*/ NoaDebugger.NoaDebuggerInfo _noaDebuggerInfo;

        static /*0x72f9ee8*/ NoaDebugger.NoaDebuggerInfoManager get_Instance();
        static /*0x72f9f78*/ NoaDebugger.NoaDebuggerInfo GetNoaDebuggerInfo();
        static /*0x72fa040*/ void Dispose();
        /*0x72f9f70*/ NoaDebuggerInfoManager();
        /*0x72f9f90*/ NoaDebugger.NoaDebuggerInfo _GetNoaDebuggerInfo();
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

        static /*0x72fca78*/ NoaDebuggerManager();
        static /*0x72fa094*/ System.Action<int> get_OnShow();
        static /*0x72fa0f8*/ void set_OnShow(System.Action<int> value);
        static /*0x72fa164*/ System.Action<int> get_OnHide();
        static /*0x72fa1c8*/ void set_OnHide(System.Action<int> value);
        static /*0x72fa234*/ System.Action<int, bool> get_OnMenuChanged();
        static /*0x72fa298*/ void set_OnMenuChanged(System.Action<int, bool> value);
        static /*0x72fa304*/ UnityEngine.Transform get_RootTransform();
        static /*0x72fa45c*/ bool get_IsShortcutsEnabled();
        static /*0x72fa4e8*/ bool get_IsWorldSpaceRenderingEnabled();
        static /*0x72fa574*/ UnityEngine.Transform get_MainViewRootTransform();
        static /*0x72fa600*/ UnityEngine.Transform get_OverlayRootTransform();
        static /*0x72fa68c*/ UnityEngine.Transform get_FloatingWindowRootTransform();
        static /*0x72fa718*/ UnityEngine.Transform get_DialogRootTransform();
        static /*0x72fa7a4*/ UnityEngine.Transform get_UIElementRootTransform();
        static /*0x72fa830*/ int get_MainThreadId();
        static /*0x72fa888*/ void set_MainThreadId(int value);
        static /*0x72fa8e4*/ void _Instantiate();
        static /*0x72faec0*/ void _CloseNoaDebugger();
        static /*0x384032c*/ void OnChangeNotificationStatus<TPresenter>(NoaDebugger.ToolNotificationStatus notifyStatus);
        static /*0x72fafc4*/ void DetectError();
        static /*0x72fb048*/ void InitializeDebugger(System.Action onInitComplete);
        static /*0x72fb1f4*/ void ShowDebugger(System.Nullable<int> index, System.Nullable<bool> isCustomMenu);
        static /*0x72fb468*/ void ShowDebugger(NoaDebugger.NoaDebug.MenuType menuType);
        static /*0x72fb540*/ NoaDebugger.MenuInfo _GetMenuInfoByMenuType(NoaDebugger.NoaDebug.MenuType menuType);
        static /*0x72fb680*/ void _ShowDebugger(System.Nullable<int> index, System.Nullable<bool> isCustomMenu);
        static /*0x72fb7ac*/ void HideDebugger();
        static /*0x72fb85c*/ void SetOverlayEnabled(NoaDebugger.NoaDebug.OverlayFeatures feature, bool isEnabled);
        static /*0x72fb940*/ bool GetOverlayEnabled(NoaDebugger.NoaDebug.OverlayFeatures feature);
        static /*0x72fba14*/ void SetFont(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material fontMaterial, float fontSizeRate);
        static /*0x72fbc7c*/ void _MonitorFontOnUpdate();
        static /*0x72fbb58*/ void _ApplyFontToInstantiatedObjects();
        static /*0x72fbcf0*/ void SetShortcutsEnabled(bool isEnabled);
        static /*0x72fbd80*/ void EnableWorldSpaceRendering(UnityEngine.Camera worldCamera);
        static /*0x72fbe10*/ void DisableWorldSpaceRendering();
        static /*0x72fbe98*/ void CopyToClipboard(string text);
        static /*0x72fbf70*/ void DownloadText(string text, string fileName, string mimeType);
        static /*0x72fc00c*/ void DestroyDebugger();
        static /*0x72fa390*/ bool IsDebuggerInitialized();
        static /*0x72fc200*/ bool IsError();
        static /*0x72fc264*/ void RunOnShow(int index);
        static /*0x72fc2dc*/ void RunOnHide(int index);
        static /*0x72fc354*/ void RunOnMenuChanged(int index, bool isCustomMenu);
        static /*0x72fc3e0*/ NoaDebugger.INoaUIElementView[] GetAllUIElements();
        static /*0x72fc4d4*/ void RegisterUIElement(NoaDebugger.INoaUIElement element);
        static /*0x72fc56c*/ void UnregisterUIElement(string key);
        static /*0x72fc604*/ void UnregisterAllUIElements();
        static /*0x72fc694*/ bool IsUIElementRegistered(string key);
        static /*0x72fc730*/ void SetUIElementVisibility(string key, bool visible);
        static /*0x72fc7dc*/ bool IsUIElementVisible(string key);
        static /*0x72fc940*/ void SetVerticalAlignment(NoaDebugger.AnchorType anchorType);
        static /*0x72fc9d8*/ void SetHorizontalAlignment(NoaDebugger.AnchorType anchorType);
        /*0x72fca70*/ NoaDebuggerManager();
        /*0x72faaa0*/ void _Init();
        /*0x72fadc4*/ void _ErrorObserver();
        /*0x72faf24*/ void _HandleException(string logString, string stackTrace, UnityEngine.LogType type);

        class InitializeNoaDebuggerBehaviour : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ System.Action <OnInitComplete>k__BackingField;

            static /*0x72fcb3c*/ System.Action get_OnInitComplete();
            static /*0x72fcb84*/ void set_OnInitComplete(System.Action value);
            /*0x72fcc90*/ InitializeNoaDebuggerBehaviour();
            /*0x72fcbdc*/ void Awake();
            /*0x72fcbfc*/ System.Collections.IEnumerator _Init();

            class <_Init>d__5 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ NoaDebugger.NoaDebuggerManager.InitializeNoaDebuggerBehaviour <>4__this;

                /*0x72fcc68*/ <_Init>d__5(int <>1__state);
                /*0x72fcc98*/ void System.IDisposable.Dispose();
                /*0x72fcc9c*/ bool MoveNext();
                /*0x72fce34*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x72fce3c*/ void System.Collections.IEnumerator.Reset();
                /*0x72fce74*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class NoaDebuggerDestroyReceiver : UnityEngine.MonoBehaviour
        {
            /*0x72fcec8*/ NoaDebuggerDestroyReceiver();
            /*0x72fce7c*/ void OnDestroy();
        }

        class <>c__DisplayClass49_0
        {
            /*0x10*/ System.Nullable<int> index;
            /*0x18*/ System.Nullable<bool> isCustomMenu;

            /*0x72fb314*/ <>c__DisplayClass49_0();
            /*0x72fb3d4*/ void <ShowDebugger>g__showDebugger|0();
        }

        class <>c__DisplayClass51_0
        {
            /*0x10*/ string targetName;

            /*0x72fb660*/ <>c__DisplayClass51_0();
            /*0x72fced0*/ bool <_GetMenuInfoByMenuType>b__0(NoaDebugger.MenuInfo menu);
        }
    }

    class NoaDebuggerPrefs
    {
        static /*0x0*/ string FileName;
        static /*0x8*/ NoaDebugger.NoaDebuggerPrefs _singletonValue;
        /*0x10*/ System.Collections.Generic.Dictionary<string, string> _prefsDictionary;

        static /*0x72ff150*/ NoaDebuggerPrefs();
        static /*0x72fcf4c*/ NoaDebugger.NoaDebuggerPrefs get_Singleton();
        static /*0x72fd98c*/ bool HasKey(string key);
        static /*0x72fd9ec*/ System.Collections.Generic.List<string> GetKeyList();
        static /*0x72fda44*/ System.Collections.Generic.List<string> GetKeyListFilterAt(string prefix);
        static /*0x72fdb78*/ System.Collections.Generic.List<string> GetKeyListForToolOnly();
        static /*0x72fdcec*/ string GetString(string key, string defaultValue);
        static /*0x72fdd5c*/ sbyte GetSByte(string key, sbyte defaultValue);
        static /*0x72fddf8*/ byte GetByte(string key, byte defaultValue);
        static /*0x72fde94*/ short GetShort(string key, short defaultValue);
        static /*0x72fdf30*/ ushort GetUShort(string key, ushort defaultValue);
        static /*0x72fdfcc*/ int GetInt(string key, int defaultValue);
        static /*0x72fe068*/ uint GetUInt(string key, uint defaultValue);
        static /*0x72fe104*/ long GetLong(string key, long defaultValue);
        static /*0x72fe1a0*/ ulong GetULong(string key, ulong defaultValue);
        static /*0x72fe23c*/ char GetChar(string key, char defaultValue);
        static /*0x72fe2f4*/ float GetFloat(string key, float defaultValue);
        static /*0x72fe3c4*/ double GetDouble(string key, double defaultValue);
        static /*0x72fe494*/ decimal GetDecimal(string key, decimal defaultValue);
        static /*0x72fe5b8*/ bool GetBoolean(string key, bool defaultValue);
        static /*0x72fe674*/ void SetString(string key, string value);
        static /*0x72fe6e4*/ void SetSByte(string key, sbyte value);
        static /*0x72fe76c*/ void SetByte(string key, byte value);
        static /*0x72fe7f4*/ void SetShort(string key, short value);
        static /*0x72fe87c*/ void SetUShort(string key, ushort value);
        static /*0x72fe904*/ void SetInt(string key, int value);
        static /*0x72fe98c*/ void SetUInt(string key, uint value);
        static /*0x72fea14*/ void SetLong(string key, long value);
        static /*0x72fea9c*/ void SetULong(string key, ulong value);
        static /*0x72feb24*/ void SetChar(string key, char value);
        static /*0x72fec00*/ void SetFloat(string key, float value);
        static /*0x72fecbc*/ void SetDouble(string key, double value);
        static /*0x72fed78*/ void SetDecimal(string key, decimal value);
        static /*0x72fee88*/ void SetBoolean(string key, bool value);
        static /*0x72fcef4*/ void Save();
        static /*0x72fef30*/ void DeleteAt(string key);
        static /*0x72fef90*/ void DeleteAllToolData();
        static /*0x72ff0f8*/ void DeleteAll();
        /*0x72fd00c*/ NoaDebuggerPrefs();
        /*0x72fd2b0*/ string get_CachePath();
        /*0x72fd350*/ string _GetFilePath();
        /*0x72fd094*/ void _Load();
        /*0x72fd554*/ void _SaveData();
        /*0x72fd6e8*/ bool _HasKey(string key);
        /*0x72fd740*/ System.Collections.Generic.List<string> _GetKeyAll();
        /*0x72fd7ac*/ string _Get(string key, string defaultValue);
        /*0x72fd850*/ void _Set(string key, string value);
        /*0x72fd8b8*/ void _DeleteAt(string key);
        /*0x72fd910*/ void _DeleteAll();

        class <>c__DisplayClass19_0
        {
            /*0x10*/ string prefix;

            /*0x72fdb70*/ <>c__DisplayClass19_0();
            /*0x72ff1bc*/ bool <GetKeyListFilterAt>b__0(string key);
        }

        class <>c__DisplayClass20_0
        {
            /*0x10*/ string debugCommandPrefix;
            /*0x18*/ string noaPrefsPrefix;

            /*0x72fdce4*/ <>c__DisplayClass20_0();
            /*0x72ff1e0*/ bool <GetKeyListForToolOnly>b__0(string key);
        }
    }

    class PrefsDictionary
    {
        /*0x10*/ System.Collections.Generic.List<string> keys;
        /*0x18*/ System.Collections.Generic.List<string> values;

        static /*0x72fd5ac*/ NoaDebugger.PrefsDictionary Serialize(System.Collections.Generic.Dictionary<string, string> dictionary);
        static /*0x72fd3e4*/ System.Collections.Generic.Dictionary<string, string> Deserialize(NoaDebugger.PrefsDictionary prefsDic);
        /*0x72ff238*/ PrefsDictionary();
    }

    class NoaDebuggerPrefsBehaviour : UnityEngine.MonoBehaviour
    {
        static /*0x72ff240*/ void Initialize(UnityEngine.Transform parent);
        /*0x72ff3b0*/ NoaDebuggerPrefsBehaviour();
        /*0x72ff300*/ void OnApplicationPause(bool pauseStatus);
        /*0x72ff364*/ void OnApplicationQuit();
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

        static /*0x72ff3b8*/ NoaDebuggerPrefsDefine();
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

        /*0x72fffcc*/ NoaDebuggerSettings();
        /*0x72ffa78*/ NoaDebugger.ButtonPosition get_StartButtonPosition();
        /*0x72ffa80*/ void set_StartButtonPosition(NoaDebugger.ButtonPosition value);
        /*0x72ffa88*/ float get_StartButtonScale();
        /*0x72ffa90*/ void set_StartButtonScale(float value);
        /*0x72ffa98*/ NoaDebugger.ButtonMovementType get_StartButtonMovementType();
        /*0x72ffaa0*/ void set_StartButtonMovementType(NoaDebugger.ButtonMovementType value);
        /*0x72ffaa8*/ bool get_SaveStartButtonPosition();
        /*0x72ffab0*/ void set_SaveStartButtonPosition(bool value);
        /*0x72ffabc*/ float get_ToolStartButtonAlpha();
        /*0x72ffac4*/ void set_ToolStartButtonAlpha(float value);
        /*0x72ffacc*/ float get_BackgroundAlpha();
        /*0x72ffad4*/ void set_BackgroundAlpha(float value);
        /*0x72ffadc*/ float get_FloatingWindowAlpha();
        /*0x72ffae4*/ void set_FloatingWindowAlpha(float value);
        /*0x72ffaec*/ float get_ControllerBackgroundAlpha();
        /*0x72ffaf4*/ void set_ControllerBackgroundAlpha(float value);
        /*0x72ffafc*/ int get_NoaDebuggerCanvasSortOrder();
        /*0x72ffb04*/ void set_NoaDebuggerCanvasSortOrder(int value);
        /*0x72ffb0c*/ bool get_IsUIReversePortrait();
        /*0x72ffb14*/ void set_IsUIReversePortrait(bool value);
        /*0x72ffb20*/ bool get_IsShowSideMenuCloseButton();
        /*0x72ffb28*/ void set_IsShowSideMenuCloseButton(bool value);
        /*0x72ffb34*/ System.Collections.Generic.List<NoaDebugger.MenuInfo> get_MenuList();
        /*0x72ffb3c*/ void set_MenuList(System.Collections.Generic.List<NoaDebugger.MenuInfo> value);
        /*0x72ffb44*/ bool get_AutoCreateEventSystem();
        /*0x72ffb4c*/ void set_AutoCreateEventSystem(bool value);
        /*0x72ffb58*/ NoaDebugger.ErrorNotificationType get_ErrorNotificationType();
        /*0x72ffb60*/ void set_ErrorNotificationType(NoaDebugger.ErrorNotificationType value);
        /*0x72ffb68*/ bool get_AutoInitialize();
        /*0x72ffb70*/ void set_AutoInitialize(bool value);
        /*0x72ffb7c*/ System.Collections.Generic.List<NoaDebugger.CustomMenuInfo> get_CustomMenuList();
        /*0x72ffb84*/ void set_CustomMenuList(System.Collections.Generic.List<NoaDebugger.CustomMenuInfo> value);
        /*0x72ffb8c*/ int get_ConsoleLogCount();
        /*0x72ffb94*/ void set_ConsoleLogCount(int value);
        /*0x72ffb9c*/ int get_ApiLogCount();
        /*0x72ffba4*/ void set_ApiLogCount(int value);
        /*0x72ffbac*/ bool get_IsCustomFontSpecified();
        /*0x72ffc24*/ bool get_IsCustomFontSettingsEnabled();
        /*0x72ffc2c*/ void set_IsCustomFontSettingsEnabled(bool value);
        /*0x72ffc38*/ TMPro.TMP_FontAsset get_FontAsset();
        /*0x72ffc40*/ void set_FontAsset(TMPro.TMP_FontAsset value);
        /*0x72ffc48*/ UnityEngine.Material get_FontMaterial();
        /*0x72ffc50*/ void set_FontMaterial(UnityEngine.Material value);
        /*0x72ffc58*/ float get_FontSizeRate();
        /*0x72ffc60*/ void set_FontSizeRate(float value);
        /*0x72ffc68*/ int get_HierarchyLevels();
        /*0x72ffc70*/ void set_HierarchyLevels(int value);
        /*0x72ffc78*/ NoaDebugger.DebugCommand.CommandDisplayFormat get_CommandFormatLandscape();
        /*0x72ffc80*/ void set_CommandFormatLandscape(NoaDebugger.DebugCommand.CommandDisplayFormat value);
        /*0x72ffc88*/ NoaDebugger.DebugCommand.CommandDisplayFormat get_CommandFormatPortrait();
        /*0x72ffc90*/ void set_CommandFormatPortrait(NoaDebugger.DebugCommand.CommandDisplayFormat value);
        /*0x72ffc98*/ float get_OverlayBackgroundOpacity();
        /*0x72ffca0*/ void set_OverlayBackgroundOpacity(float value);
        /*0x72ffca8*/ bool get_AppliesOverlaySafeArea();
        /*0x72ffcb0*/ void set_AppliesOverlaySafeArea(bool value);
        /*0x72ffcbc*/ UnityEngine.Vector2 get_OverlayPadding();
        /*0x72ffcc4*/ void set_OverlayPadding(UnityEngine.Vector2 value);
        /*0x72ffccc*/ NoaDebugger.NoaDebug.OverlayPosition get_ProfilerOverlayPosition();
        /*0x72ffcd4*/ void set_ProfilerOverlayPosition(NoaDebugger.NoaDebug.OverlayPosition value);
        /*0x72ffcdc*/ float get_ProfilerOverlayScale();
        /*0x72ffce4*/ void set_ProfilerOverlayScale(float value);
        /*0x72ffcec*/ NoaDebugger.NoaProfiler.OverlayAxis get_ProfilerOverlayAxis();
        /*0x72ffcf4*/ void set_ProfilerOverlayAxis(NoaDebugger.NoaProfiler.OverlayAxis value);
        /*0x72ffcfc*/ NoaDebugger.NoaDebug.OverlayPosition get_ConsoleLogOverlayPosition();
        /*0x72ffd04*/ void set_ConsoleLogOverlayPosition(NoaDebugger.NoaDebug.OverlayPosition value);
        /*0x72ffd0c*/ float get_ConsoleLogOverlayFontScale();
        /*0x72ffd14*/ void set_ConsoleLogOverlayFontScale(float value);
        /*0x72ffd1c*/ int get_ConsoleLogOverlayMaximumLogCount();
        /*0x72ffd24*/ void set_ConsoleLogOverlayMaximumLogCount(int value);
        /*0x72ffd2c*/ float get_ConsoleLogOverlayMinimumOpacity();
        /*0x72ffd34*/ void set_ConsoleLogOverlayMinimumOpacity(float value);
        /*0x72ffd3c*/ float get_ConsoleLogOverlayActiveDuration();
        /*0x72ffd44*/ void set_ConsoleLogOverlayActiveDuration(float value);
        /*0x72ffd4c*/ bool get_ConsoleLogOverlayShowTimestamp();
        /*0x72ffd54*/ void set_ConsoleLogOverlayShowTimestamp(bool value);
        /*0x72ffd60*/ bool get_ConsoleLogOverlayShowMessageLogs();
        /*0x72ffd68*/ void set_ConsoleLogOverlayShowMessageLogs(bool value);
        /*0x72ffd74*/ bool get_ConsoleLogOverlayShowWarningLogs();
        /*0x72ffd7c*/ void set_ConsoleLogOverlayShowWarningLogs(bool value);
        /*0x72ffd88*/ bool get_ConsoleLogOverlayShowErrorLogs();
        /*0x72ffd90*/ void set_ConsoleLogOverlayShowErrorLogs(bool value);
        /*0x72ffd9c*/ NoaDebugger.NoaDebug.OverlayPosition get_ApiLogOverlayPosition();
        /*0x72ffda4*/ void set_ApiLogOverlayPosition(NoaDebugger.NoaDebug.OverlayPosition value);
        /*0x72ffdac*/ float get_ApiLogOverlayFontScale();
        /*0x72ffdb4*/ void set_ApiLogOverlayFontScale(float value);
        /*0x72ffdbc*/ int get_ApiLogOverlayMaximumLogCount();
        /*0x72ffdc4*/ void set_ApiLogOverlayMaximumLogCount(int value);
        /*0x72ffdcc*/ float get_ApiLogOverlayMinimumOpacity();
        /*0x72ffdd4*/ void set_ApiLogOverlayMinimumOpacity(float value);
        /*0x72ffddc*/ float get_ApiLogOverlayActiveDuration();
        /*0x72ffde4*/ void set_ApiLogOverlayActiveDuration(float value);
        /*0x72ffdec*/ bool get_ApiLogOverlayShowTimestamp();
        /*0x72ffdf4*/ void set_ApiLogOverlayShowTimestamp(bool value);
        /*0x72ffe00*/ bool get_ApiLogOverlayShowMessageLogs();
        /*0x72ffe08*/ void set_ApiLogOverlayShowMessageLogs(bool value);
        /*0x72ffe14*/ bool get_ApiLogOverlayShowErrorLogs();
        /*0x72ffe1c*/ void set_ApiLogOverlayShowErrorLogs(bool value);
        /*0x72ffe28*/ bool get_AppliesUIElementSafeArea();
        /*0x72ffe30*/ void set_AppliesUIElementSafeArea(bool value);
        /*0x72ffe3c*/ UnityEngine.Vector2 get_UIElementPadding();
        /*0x72ffe44*/ void set_UIElementPadding(UnityEngine.Vector2 value);
        /*0x72ffe4c*/ bool get_AppliesGameSpeedChange();
        /*0x72ffe54*/ void set_AppliesGameSpeedChange(bool value);
        /*0x72ffe60*/ float get_GameSpeedIncrement();
        /*0x72ffe68*/ void set_GameSpeedIncrement(float value);
        /*0x72ffe70*/ float get_MaxGameSpeed();
        /*0x72ffe78*/ void set_MaxGameSpeed(float value);
        /*0x72ffe80*/ bool get_EnableAllShortcuts();
        /*0x72ffe88*/ void set_EnableAllShortcuts(bool value);
        /*0x72ffe94*/ System.Collections.Generic.List<NoaDebugger.ShortcutAction> get_EnabledShortcutActions();
        /*0x72fff04*/ void set_EnabledShortcutActions(System.Collections.Generic.List<NoaDebugger.ShortcutAction> value);
        /*0x72fff90*/ System.Collections.Generic.List<NoaDebugger.ShortcutAction> get_ShortcutActionsOnInputManager();
        /*0x72fff98*/ void set_ShortcutActionsOnInputManager(System.Collections.Generic.List<NoaDebugger.ShortcutAction> value);
        /*0x72fffa0*/ System.Collections.Generic.List<NoaDebugger.ShortcutAction> get_ShortcutActions();
        /*0x72fffa8*/ void set_ShortcutActions(System.Collections.Generic.List<NoaDebugger.ShortcutAction> value);
        /*0x72fffb8*/ bool get_AutoSave();
        /*0x72fffc0*/ void set_AutoSave(bool value);
    }

    class MenuInfo
    {
        /*0x10*/ string Name;
        /*0x18*/ bool Enabled;
        /*0x1c*/ int SortNo;

        /*0x7300098*/ MenuInfo();
    }

    class CustomMenuInfo
    {
        /*0x10*/ int _sortNo;
        /*0x18*/ string _scriptName;

        /*0x73000a0*/ CustomMenuInfo();
    }

    class JsonDictionary<TKey, TValue> : UnityEngine.ISerializationCallbackReceiver
    {
        /*0x0*/ NoaDebugger.JsonDictionary.KeyValuePair<TKey, TValue> dictionary;
        /*0x0*/ System.Collections.Generic.Dictionary<TKey, TValue> _dictionary;

        /*0x3816710*/ JsonDictionary(System.Collections.Generic.Dictionary<TKey, TValue> dictionary);
        /*0x38148bc*/ System.Collections.Generic.Dictionary<TKey, TValue> get_Dictionary();
        /*0x38159dc*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
        /*0x38159dc*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();

        struct KeyValuePair<TKey, TValue>
        {
            /*0x0*/ TKey key;
            /*0x0*/ TValue value;

            /*0x3910ae8*/ KeyValuePair(TKey key, TValue value);
            /*0x3910ae8*/ TKey get_Key();
            /*0x3910ae8*/ TValue get_Value();
        }

        class <>c<TKey, TValue>
        {
            static /*0x0*/ NoaDebugger.JsonDictionary.<>c<TKey, TValue> <>9;
            static /*0x0*/ System.Func<System.Collections.Generic.KeyValuePair<TKey, TValue>, NoaDebugger.JsonDictionary.KeyValuePair<TKey, TValue>> <>9__6_0;
            static /*0x0*/ System.Func<NoaDebugger.JsonDictionary.KeyValuePair<TKey, TValue>, TKey> <>9__7_0;
            static /*0x0*/ System.Func<NoaDebugger.JsonDictionary.KeyValuePair<TKey, TValue>, TValue> <>9__7_1;

            static /*0x383e7a0*/ <>c();
            /*0x38159dc*/ <>c();
            /*0x3910ae8*/ NoaDebugger.JsonDictionary.KeyValuePair<TKey, TValue> <UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize>b__6_0(System.Collections.Generic.KeyValuePair<TKey, TValue> x);
            /*0x3910ae8*/ TKey <UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize>b__7_0(NoaDebugger.JsonDictionary.KeyValuePair<TKey, TValue> x);
            /*0x3910ae8*/ TValue <UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize>b__7_1(NoaDebugger.JsonDictionary.KeyValuePair<TKey, TValue> x);
        }
    }

    class NoaDebuggerAutoSaveSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x73000a8*/ NoaDebuggerAutoSaveSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x7300108*/ void Init();
    }

    class NoaDebuggerCommandSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x7300128*/ NoaDebuggerCommandSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x7300158*/ void Init();
    }

    class NoaDebuggerCustomMenuSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x730017c*/ NoaDebuggerCustomMenuSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x73001ac*/ void Init();
    }

    class NoaDebuggerDisplaySettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x7300234*/ NoaDebuggerDisplaySettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x7300264*/ void Init();
    }

    class NoaDebuggerFontSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x73002b0*/ NoaDebuggerFontSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x73002e0*/ void Init();
    }

    class NoaDebuggerGameSpeedSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x7300330*/ NoaDebuggerGameSpeedSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x7300360*/ void Init();
    }

    class NoaDebuggerHierarchySettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x730038c*/ NoaDebuggerHierarchySettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x73003bc*/ void Init();
    }

    class NoaDebuggerLoadingSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x73003dc*/ NoaDebuggerLoadingSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x730040c*/ void Init();
    }

    class NoaDebuggerLogSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x730042c*/ NoaDebuggerLogSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x730045c*/ void Init();
    }

    class NoaDebuggerMenuSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        static /*0x73004d8*/ System.Collections.Generic.List<NoaDebugger.MenuInfo> GetDefaultMenuSettings();
        static /*0x7300874*/ System.Collections.Generic.List<NoaDebugger.IMenuInfo> GetSortedIMenuInfoList();
        static /*0x7300c10*/ System.Collections.Generic.List<NoaDebugger.MenuInfo> GetUpdatedMenuSettings(System.Collections.Generic.List<NoaDebugger.MenuInfo> baseList);
        /*0x7300480*/ NoaDebuggerMenuSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x73004b0*/ void Init();

        class <>c
        {
            static /*0x0*/ NoaDebugger.NoaDebuggerMenuSettings.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.INoaDebuggerTool, NoaDebugger.IMenuInfo> <>9__3_2;
            static /*0x10*/ System.Predicate<NoaDebugger.IMenuInfo> <>9__3_0;
            static /*0x18*/ System.Comparison<NoaDebugger.IMenuInfo> <>9__3_1;

            static /*0x7301480*/ <>c();
            /*0x73014e8*/ <>c();
            /*0x73014f0*/ NoaDebugger.IMenuInfo <GetSortedIMenuInfoList>b__3_2(NoaDebugger.INoaDebuggerTool t);
            /*0x7301590*/ bool <GetSortedIMenuInfoList>b__3_0(NoaDebugger.IMenuInfo m);
            /*0x73015fc*/ int <GetSortedIMenuInfoList>b__3_1(NoaDebugger.IMenuInfo a, NoaDebugger.IMenuInfo b);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ NoaDebugger.MenuInfo menu;

            /*0x7301470*/ <>c__DisplayClass4_0();
            /*0x730170c*/ bool <GetUpdatedMenuSettings>b__0(NoaDebugger.MenuInfo updateInfo);
            /*0x7301738*/ bool <GetUpdatedMenuSettings>b__1(NoaDebugger.IMenuInfo defaultInfo);
        }

        class <>c__DisplayClass4_1
        {
            /*0x10*/ NoaDebugger.IMenuInfo defaultInfo;

            /*0x7301478*/ <>c__DisplayClass4_1();
            /*0x73017f4*/ bool <GetUpdatedMenuSettings>b__2(NoaDebugger.MenuInfo customMenuInfo);
        }
    }

    class NoaDebuggerOtherSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x73018b8*/ NoaDebuggerOtherSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x73018e8*/ void Init();
    }

    class NoaDebuggerOverlaySettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x730190c*/ NoaDebuggerOverlaySettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x730193c*/ void Init();
    }

    class NoaDebuggerSettingsBase
    {
        /*0x10*/ NoaDebugger.NoaDebuggerSettings _settings;

        /*0x73000d8*/ NoaDebuggerSettingsBase(NoaDebugger.NoaDebuggerSettings settings);
        /*0x38159dc*/ void Init();
    }

    class NoaDebuggerSettingsContainer
    {
        /*0x10*/ System.Collections.Generic.List<NoaDebugger.NoaDebuggerSettingsBase> _settings;

        /*0x73019c0*/ NoaDebuggerSettingsContainer(NoaDebugger.NoaDebuggerSettings settings);
        /*0x73022e8*/ void Init();

        class <>c
        {
            static /*0x0*/ NoaDebugger.NoaDebuggerSettingsContainer.<> <>9;
            static /*0x8*/ System.Action<NoaDebugger.NoaDebuggerSettingsBase> <>9__2_0;

            static /*0x73023ec*/ <>c();
            /*0x7302454*/ <>c();
            /*0x730245c*/ void <Init>b__2_0(NoaDebugger.NoaDebuggerSettingsBase setting);
        }
    }

    class NoaDebuggerShortcutSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        static /*0x730253c*/ System.Collections.Generic.List<NoaDebugger.ShortcutAction> GetDefaultShortcutActions(System.Nullable<bool> forInputSystem);
        static /*0x7302664*/ NoaDebugger.ShortcutInputCombination GetDefaultCombination(NoaDebugger.ShortcutActionType type, System.Nullable<bool> forInputSystem);
        static /*0x73028c4*/ System.Collections.Generic.List<NoaDebugger.ShortcutAction> GetUpdatedShortcutSettings(System.Collections.Generic.List<NoaDebugger.ShortcutAction> baseList, bool forInputSystem);
        static /*0x7302c18*/ bool CheckUpdateDirtyShortcutSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x73022b8*/ NoaDebuggerShortcutSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x7302480*/ void Init();

        class <>c__DisplayClass2_0
        {
            /*0x10*/ System.Nullable<bool> forInputSystem;

            /*0x730265c*/ <>c__DisplayClass2_0();
            /*0x7302e28*/ NoaDebugger.ShortcutAction <GetDefaultShortcutActions>b__0(NoaDebugger.ShortcutActionType type);
        }

        class <>c__DisplayClass4_0
        {
            /*0x10*/ NoaDebugger.ShortcutActionType actionType;

            /*0x7302c10*/ <>c__DisplayClass4_0();
            /*0x7302eb4*/ bool <GetUpdatedShortcutSettings>b__0(NoaDebugger.ShortcutAction customShortcutInfo);
        }
    }

    class NoaDebuggerUIElementSettings : NoaDebugger.NoaDebuggerSettingsBase
    {
        /*0x7302288*/ NoaDebuggerUIElementSettings(NoaDebugger.NoaDebuggerSettings settings);
        /*0x7302f44*/ void Init();
    }

    class NoaDebuggerSettingsManager
    {
        static string TOOL_SETTINGS_ASSET_NAME = "NoaDebuggerSettings";
        static /*0x0*/ NoaDebugger.NoaDebuggerSettingsManager _instance;
        /*0x10*/ NoaDebugger.NoaDebuggerSettings _noaDebuggerSettings;

        static /*0x7302f68*/ NoaDebugger.NoaDebuggerSettingsManager get_Instance();
        static /*0x7302ff8*/ void ValidateMenuSettings(System.Collections.Generic.List<NoaDebugger.INoaDebuggerTool> allPresenters);
        static /*0x72fb668*/ NoaDebugger.NoaDebuggerSettings GetNoaDebuggerSettings();
        static /*0x73036f4*/ void Dispose();
        /*0x7302ff0*/ NoaDebuggerSettingsManager();
        /*0x7303018*/ void _ValidateMenuSettings(System.Collections.Generic.List<NoaDebugger.INoaDebuggerTool> allPresenters);
        /*0x730361c*/ NoaDebugger.NoaDebuggerSettings _GetNoaDebuggerSettings();

        class <>c
        {
            static /*0x0*/ NoaDebugger.NoaDebuggerSettingsManager.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.MenuInfo, string> <>9__6_0;
            static /*0x10*/ System.Func<System.Linq.IGrouping<string, NoaDebugger.MenuInfo>, NoaDebugger.MenuInfo> <>9__6_1;

            static /*0x7303748*/ <>c();
            /*0x73037b0*/ <>c();
            /*0x73037b8*/ string <_ValidateMenuSettings>b__6_0(NoaDebugger.MenuInfo x);
            /*0x73037d0*/ NoaDebugger.MenuInfo <_ValidateMenuSettings>b__6_1(System.Linq.IGrouping<string, NoaDebugger.MenuInfo> x);
        }

        class <>c__DisplayClass6_0
        {
            /*0x10*/ NoaDebugger.INoaDebuggerTool presenter;

            /*0x730360c*/ <>c__DisplayClass6_0();
            /*0x7303818*/ bool <_ValidateMenuSettings>b__2(NoaDebugger.MenuInfo info);
        }

        class <>c__DisplayClass6_1
        {
            /*0x10*/ NoaDebugger.MenuInfo menuInfo;

            /*0x7303614*/ <>c__DisplayClass6_1();
            /*0x7303954*/ bool <_ValidateMenuSettings>b__3(NoaDebugger.INoaDebuggerTool tool);
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

        static /*0x7303b54*/ System.Func<bool, bool> get_OnToggleNoaDebuggerUI();
        static /*0x7303b9c*/ void set_OnToggleNoaDebuggerUI(System.Func<bool, bool> value);
        static /*0x72fb31c*/ bool get_IsMainViewActive();
        static /*0x7303c08*/ bool get_IsOverlayRootActive();
        static /*0x7303cdc*/ bool get_IsOverlayVisible();
        static /*0x73040ac*/ bool get_IsFloatingWindowVisible();
        static /*0x730447c*/ bool get_IsTriggerButtonActive();
        static /*0x72f8b80*/ bool get_IsControllerActive();
        static /*0x72fc894*/ bool get_IsAllUIElementActive();
        static /*0x7304694*/ void ToggleNoaDebuggerUI();
        static /*0x73049c0*/ void SetMainViewVisible(bool visible);
        static /*0x7304a68*/ void AddOverlaySetActiveAction(System.Action<bool> onSetActive);
        static /*0x7304bd4*/ void RemoveOverlaySetActiveAction(System.Action<bool> onSetActive);
        static /*0x7304d40*/ void SetOverlayVisible(bool visible);
        static /*0x7304e48*/ void SetOverlayVisibleSetting(bool visible);
        static /*0x7304ec4*/ void SetFloatingWindowVisible(bool visible);
        static /*0x73052b4*/ void SetFloatingWindowVisibleSetting(bool visible);
        static /*0x7305330*/ void AddTriggerButtonSetActiveAction(System.Action<bool> onSetActive);
        static /*0x730549c*/ void RemoveTriggerButtonSetActiveAction(System.Action<bool> onSetActive);
        static /*0x7305608*/ void SetTriggerButtonVisible(bool visible);
        static /*0x7305768*/ void SetTriggerButtonVisibleSetting(bool visible);
        static /*0x73057f0*/ void OnErrorTriggerButtonVisibility();
        static /*0x73058ec*/ void SetControllerVisible(bool visible);
        static /*0x73059ac*/ void SetAllUIElementsVisible(bool visible);
        static /*0x7305b5c*/ void SetAllUIElementsVisibleSetting(bool visible);
        static /*0x7305bd8*/ void SetToastVisible(bool visible);
        static /*0x7305d10*/ void OnInitNoaDebuggerVisibility();
        static /*0x7305d84*/ void OnShowMainViewVisibility();
        static /*0x7305e2c*/ void OnHideMainViewVisibility();
        static /*0x7305ed4*/ void OnDisableNoaDebugger();
        static /*0x7305f6c*/ void OnVisibleButtonVisibility();
        static /*0x7306020*/ void OnEnableWorldSpaceVisibility();
        static /*0x730611c*/ void OnDisableWorldSpaceVisibility();
        static /*0x73061e4*/ void Dispose();
        /*0x7306370*/ NoaDebuggerVisibilityManager();
        /*0x7303a88*/ void Awake();
        /*0x73046ec*/ void _ToggleNoaDebuggerUI();
        /*0x73057d4*/ void _SetTriggerButtonVisibleSetting(bool visible);
        /*0x730594c*/ void _SetControllerVisible(bool visible);
        /*0x7305d68*/ void _OnInitNoaDebuggerVisibility();
        /*0x7305ddc*/ void _OnShowMainViewVisibility();
        /*0x7305e84*/ void _OnHideMainViewVisibility();
        /*0x7305f2c*/ void _OnDisableNoaDebugger();
        /*0x7305fc4*/ void _OnVisibleButtonVisibility();
        /*0x7306078*/ void _OnEnableWorldSpaceVisibility();
        /*0x7306174*/ void _OnDisableWorldSpaceVisibility();
        /*0x7306260*/ void _Dispose();

        class ScreenshotUIVisibilityManager
        {
            /*0x10*/ NoaDebugger.NoaController.ScreenshotTarget _screenshotTarget;
            /*0x14*/ bool _originalIsMainViewVisible;
            /*0x15*/ bool _originalIsControllerVisible;
            /*0x16*/ bool _originalIsTriggerButtonVisible;
            /*0x17*/ bool _originalIsOverlayVisible;
            /*0x18*/ bool _originalIsFloatingWindowVisible;
            /*0x19*/ bool _originalIsUIElementVisible;

            /*0x7306440*/ ScreenshotUIVisibilityManager(NoaDebugger.NoaController.ScreenshotTarget screenshotTarget);
            /*0x7306468*/ void Before();
            /*0x73065c4*/ void After();
        }

        class MainViewVisibility
        {
            /*0x10*/ UnityEngine.GameObject _noaDebugger;
            /*0x18*/ UnityEngine.GameObject _background;

            /*0x730671c*/ MainViewVisibility();
            /*0x7303bec*/ bool get_IsActive();
            /*0x7304a2c*/ void SetVisible(bool visible);
            /*0x730633c*/ void OnEnableWorldSpaceVisibility();
            /*0x7306344*/ void OnDisableWorldSpaceVisibility();
            /*0x7306694*/ void _SetActiveBg(bool visible);
        }

        class OverlayVisibility
        {
            /*0x10*/ UnityEngine.GameObject _overlayRoot;
            /*0x18*/ bool _visibleSetting;
            /*0x20*/ System.Action<bool> OnSetActiveOverlay;

            /*0x7306770*/ OverlayVisibility();
            /*0x7303cc0*/ bool get_IsRootActive();
            /*0x7303d88*/ bool get_IsVisibility();
            /*0x7304b24*/ void add_OnSetActiveOverlay(System.Action<bool> value);
            /*0x7304c90*/ void remove_OnSetActiveOverlay(System.Action<bool> value);
            /*0x7306724*/ void _SetOverlayActive(bool active);
            /*0x7304dac*/ void SetVisible(bool visible);
            /*0x7304eb8*/ void SetVisibleSetting(bool visible);
        }

        class FloatingWindowVisibility
        {
            /*0x10*/ UnityEngine.GameObject _floatingWindowRoot;
            /*0x18*/ bool _visibleSetting;

            /*0x7306780*/ FloatingWindowVisibility();
            /*0x7304158*/ bool get_IsVisibility();
            /*0x7304f30*/ void SetVisible(bool visible);
            /*0x7305324*/ void SetVisibleSetting(bool visible);
        }

        class TriggerButtonVisibility
        {
            /*0x10*/ UnityEngine.GameObject _triggerButton;
            /*0x18*/ UnityEngine.GameObject _visibleButton;
            /*0x20*/ bool _visibleSetting;
            /*0x28*/ System.Action<bool> OnSetActiveTriggerButton;

            /*0x73067dc*/ TriggerButtonVisibility();
            /*0x7304534*/ bool get_IsActive();
            /*0x73053ec*/ void add_OnSetActiveTriggerButton(System.Action<bool> value);
            /*0x7305558*/ void remove_OnSetActiveTriggerButton(System.Action<bool> value);
            /*0x7306790*/ void _SetTriggerButtonActive(bool active);
            /*0x7305674*/ void SetVisible(bool visible);
            /*0x7306310*/ void InvalidateTriggerButton();
            /*0x73062f8*/ void SetVisibleSetting(bool visible);
            /*0x7305854*/ void OnErrorVisible();
        }

        class ControllerVisibility
        {
            /*0x10*/ UnityEngine.GameObject _controller;

            /*0x73067ec*/ ControllerVisibility();
            /*0x7304550*/ bool get_IsActive();
            /*0x73062d8*/ void SetVisible(bool visible);
        }

        class AllUIElementVisibility
        {
            /*0x10*/ bool _visibleSetting;

            /*0x7306430*/ AllUIElementVisibility();
            /*0x730456c*/ bool get_IsActive();
            /*0x7305a18*/ void SetVisible(bool visible);
            /*0x7305bcc*/ void SetVisibleSetting(bool visible);

            class <>c
            {
                static /*0x0*/ NoaDebugger.NoaDebuggerVisibilityManager.AllUIElementVisibility.<> <>9;
                static /*0x8*/ System.Func<NoaDebugger.INoaUIElementView, bool> <>9__1_0;

                static /*0x73067f4*/ <>c();
                /*0x730685c*/ <>c();
                /*0x7306864*/ bool <get_IsActive>b__1_0(NoaDebugger.INoaUIElementView elementView);
            }
        }

        class ToastVisibility
        {
            /*0x7306428*/ ToastVisibility();
            /*0x7305c44*/ void SetVisible(bool visible);
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

        /*0x7306c34*/ ApiLog();
        /*0x7306910*/ System.Uri get_Url();
        /*0x7306918*/ void set_Url(System.Uri value);
        /*0x7306920*/ string get_Method();
        /*0x7306928*/ void set_Method(string value);
        /*0x7306930*/ int get_StatusCode();
        /*0x7306938*/ void set_StatusCode(int value);
        /*0x7306940*/ long get_ContentSize();
        /*0x7306948*/ void set_ContentSize(long value);
        /*0x7306950*/ long get_ResponseTimeMilliSeconds();
        /*0x7306958*/ void set_ResponseTimeMilliSeconds(long value);
        /*0x7306960*/ System.Collections.Generic.Dictionary<string, string> get_RequestHeaders();
        /*0x7306968*/ void set_RequestHeaders(System.Collections.Generic.Dictionary<string, string> value);
        /*0x7306970*/ string get_RequestBody();
        /*0x7306978*/ void set_RequestBody(string value);
        /*0x7306980*/ object get_RequestBodyRawData();
        /*0x7306988*/ void set_RequestBodyRawData(object value);
        /*0x7306990*/ System.Collections.Generic.Dictionary<string, string> get_ResponseHeaders();
        /*0x7306998*/ void set_ResponseHeaders(System.Collections.Generic.Dictionary<string, string> value);
        /*0x73069a0*/ string get_ResponseBody();
        /*0x73069a8*/ void set_ResponseBody(string value);
        /*0x73069b0*/ object get_ResponseBodyRawData();
        /*0x73069b8*/ void set_ResponseBodyRawData(object value);
        /*0x73069c0*/ bool get_IsSuccess();
        /*0x73069d4*/ bool get_PrettyPrint();
        /*0x73069dc*/ void set_PrettyPrint(bool value);
        /*0x73069e8*/ void set_IsRequestBodyPrettyPrinted(bool value);
        /*0x73069f4*/ bool get_IsRequestBodyPrettyPrinted();
        /*0x73069fc*/ string get_PrettyPrintedRequestBody();
        /*0x7306ad0*/ void set_IsResponseBodyPrettyPrinted(bool value);
        /*0x7306adc*/ bool get_IsResponseBodyPrettyPrinted();
        /*0x7306ae4*/ string get_PrettyPrintedResponseBody();
        /*0x7306b18*/ void ConvertBody();
        /*0x7306c2c*/ string NoaDebugger.ILogDetail.GetClipboardText();
        /*0x7306a30*/ bool ToPrettyPrint(string text, ref string result);
    }

    class ApiLogger
    {
        static /*0x0*/ NoaDebugger.ApiLogger.LogCallback OnLogReceived;
        static /*0x8*/ System.Func<object, string> <OnConvertRequestBodyToString>k__BackingField;
        static /*0x10*/ System.Func<object, string> <OnConvertResponseBodyToString>k__BackingField;

        static /*0x7306c44*/ void add_OnLogReceived(NoaDebugger.ApiLogger.LogCallback value);
        static /*0x7306cfc*/ void remove_OnLogReceived(NoaDebugger.ApiLogger.LogCallback value);
        static /*0x7306db4*/ System.Func<object, string> get_OnConvertRequestBodyToString();
        static /*0x7306dfc*/ void set_OnConvertRequestBodyToString(System.Func<object, string> value);
        static /*0x7306e4c*/ System.Func<object, string> get_OnConvertResponseBodyToString();
        static /*0x7306e94*/ void set_OnConvertResponseBodyToString(System.Func<object, string> value);
        static /*0x7306ee4*/ void Log(NoaDebugger.ApiLog log);

        class LogCallback : System.MulticastDelegate
        {
            /*0x730700c*/ LogCallback(object object, nint method);
            /*0x7307114*/ void Invoke(NoaDebugger.ApiLog log);
            /*0x7307128*/ System.IAsyncResult BeginInvoke(NoaDebugger.ApiLog log, System.AsyncCallback callback, object object);
            /*0x7307148*/ void EndInvoke(System.IAsyncResult result);
        }
    }

    class CommandCharacterLimitAttribute : System.Attribute
    {
        /*0x10*/ int _limit;

        /*0x7307154*/ CommandCharacterLimitAttribute(int limit);
    }

    class CommandDescriptionAttribute : System.Attribute
    {
        /*0x10*/ string _text;

        /*0x7307180*/ CommandDescriptionAttribute(string text);
    }

    class CommandExcludeAttribute : System.Attribute
    {
        /*0x73071b0*/ CommandExcludeAttribute();
    }

    class CommandGroupAttribute : System.Attribute
    {
        /*0x10*/ string _name;
        /*0x18*/ System.Nullable<int> _order;

        /*0x73071b8*/ CommandGroupAttribute(string name);
        /*0x73071f0*/ CommandGroupAttribute(string name, int order);
    }

    class CommandIncrementAttribute : System.Attribute
    {
        /*0x10*/ object _increment;

        /*0x7307280*/ CommandIncrementAttribute(object increment);
    }

    class CommandInputRangeAttribute : System.Attribute
    {
        /*0x10*/ object _min;
        /*0x18*/ object _max;

        /*0x73072b0*/ CommandInputRangeAttribute(object min, object max);
    }

    class CommandOrderAttribute : System.Attribute
    {
        /*0x10*/ int _order;

        /*0x73072f4*/ CommandOrderAttribute(int order);
    }

    class CommandTagAttribute : System.Attribute
    {
        /*0x10*/ string _tag;

        /*0x730731c*/ CommandTagAttribute(string tag);
    }

    class DisplayNameAttribute : System.Attribute
    {
        /*0x10*/ string _name;

        /*0x730734c*/ DisplayNameAttribute(string name);
    }

    class SaveOnUpdateAttribute : System.Attribute
    {
        /*0x730737c*/ SaveOnUpdateAttribute();
    }

    class DebugCategoryBase
    {
        /*0x7307384*/ DebugCategoryBase();
    }

    class DebugCommandRegister
    {
        static /*0x0*/ UnityEngine.Events.UnityAction OnAddCategory;
        static /*0x8*/ System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommandRegister.DebugCategory> <CategoryTypes>k__BackingField;
        static /*0x10*/ System.Collections.Generic.Dictionary<string, int> CategoryNameSuffixNumber;
        static /*0x18*/ NoaDebugger.DebugCommand.DebugCommandDefinitionRegister DebugCommandDefinitionRegister;

        static /*0x7309da0*/ DebugCommandRegister();
        static /*0x730738c*/ void add_OnAddCategory(UnityEngine.Events.UnityAction value);
        static /*0x7307464*/ void remove_OnAddCategory(UnityEngine.Events.UnityAction value);
        static /*0x730753c*/ System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommandRegister.DebugCategory> get_CategoryTypes();
        static /*0x7307594*/ void Dispose();
        static /*0x3843070*/ void AddCategory<T>(string categoryName, int order, string displayName);
        static /*0x3910ae8*/ T GetCategoryInstance<T>(string categoryName);
        static /*0x730769c*/ int _CountNameDuplication(string name);
        static /*0x7307868*/ NoaDebugger.CommandDefinition CreateGetOnlyStringProperty(string categoryName, string displayName, System.Func<string> getter, System.Attribute[] attributes);
        static /*0x7307938*/ NoaDebugger.CommandDefinition CreateGetOnlySByteProperty(string categoryName, string displayName, System.Func<sbyte> getter, System.Attribute[] attributes);
        static /*0x7307a50*/ NoaDebugger.CommandDefinition CreateGetOnlyByteProperty(string categoryName, string displayName, System.Func<byte> getter, System.Attribute[] attributes);
        static /*0x7307b68*/ NoaDebugger.CommandDefinition CreateGetOnlyShortProperty(string categoryName, string displayName, System.Func<short> getter, System.Attribute[] attributes);
        static /*0x7307c80*/ NoaDebugger.CommandDefinition CreateGetOnlyUShortProperty(string categoryName, string displayName, System.Func<ushort> getter, System.Attribute[] attributes);
        static /*0x7307d98*/ NoaDebugger.CommandDefinition CreateGetOnlyIntProperty(string categoryName, string displayName, System.Func<int> getter, System.Attribute[] attributes);
        static /*0x7307eb0*/ NoaDebugger.CommandDefinition CreateGetOnlyUIntProperty(string categoryName, string displayName, System.Func<uint> getter, System.Attribute[] attributes);
        static /*0x7307fc8*/ NoaDebugger.CommandDefinition CreateGetOnlyLongProperty(string categoryName, string displayName, System.Func<long> getter, System.Attribute[] attributes);
        static /*0x73080e0*/ NoaDebugger.CommandDefinition CreateGetOnlyULongProperty(string categoryName, string displayName, System.Func<ulong> getter, System.Attribute[] attributes);
        static /*0x73081f8*/ NoaDebugger.CommandDefinition CreateGetOnlyCharProperty(string categoryName, string displayName, System.Func<char> getter, System.Attribute[] attributes);
        static /*0x7308310*/ NoaDebugger.CommandDefinition CreateGetOnlyFloatProperty(string categoryName, string displayName, System.Func<float> getter, System.Attribute[] attributes);
        static /*0x7308428*/ NoaDebugger.CommandDefinition CreateGetOnlyDoubleProperty(string categoryName, string displayName, System.Func<double> getter, System.Attribute[] attributes);
        static /*0x7308540*/ NoaDebugger.CommandDefinition CreateGetOnlyDecimalProperty(string categoryName, string displayName, System.Func<decimal> getter, System.Attribute[] attributes);
        static /*0x7308658*/ NoaDebugger.CommandDefinition CreateGetOnlyBoolProperty(string categoryName, string displayName, System.Func<bool> getter, System.Attribute[] attributes);
        static /*0x7308770*/ NoaDebugger.CommandDefinition CreateGetOnlyEnumProperty(string categoryName, string displayName, System.Func<System.Enum> getter, System.Attribute[] attributes);
        static /*0x7308840*/ NoaDebugger.CommandDefinition CreateMutableStringProperty(string categoryName, string displayName, System.Func<string> getter, System.Action<string> setter, System.Attribute[] attributes);
        static /*0x73088cc*/ NoaDebugger.CommandDefinition CreateMutableSByteProperty(string categoryName, string displayName, System.Func<sbyte> getter, System.Action<sbyte> setter, System.Attribute[] attributes);
        static /*0x7308958*/ NoaDebugger.CommandDefinition CreateMutableByteProperty(string categoryName, string displayName, System.Func<byte> getter, System.Action<byte> setter, System.Attribute[] attributes);
        static /*0x73089e4*/ NoaDebugger.CommandDefinition CreateMutableShortProperty(string categoryName, string displayName, System.Func<short> getter, System.Action<short> setter, System.Attribute[] attributes);
        static /*0x7308a70*/ NoaDebugger.CommandDefinition CreateMutableUShortProperty(string categoryName, string displayName, System.Func<ushort> getter, System.Action<ushort> setter, System.Attribute[] attributes);
        static /*0x7308afc*/ NoaDebugger.CommandDefinition CreateMutableIntProperty(string categoryName, string displayName, System.Func<int> getter, System.Action<int> setter, System.Attribute[] attributes);
        static /*0x7308b88*/ NoaDebugger.CommandDefinition CreateMutableUIntProperty(string categoryName, string displayName, System.Func<uint> getter, System.Action<uint> setter, System.Attribute[] attributes);
        static /*0x7308c14*/ NoaDebugger.CommandDefinition CreateMutableLongProperty(string categoryName, string displayName, System.Func<long> getter, System.Action<long> setter, System.Attribute[] attributes);
        static /*0x7308ca0*/ NoaDebugger.CommandDefinition CreateMutableULongProperty(string categoryName, string displayName, System.Func<ulong> getter, System.Action<ulong> setter, System.Attribute[] attributes);
        static /*0x7308d2c*/ NoaDebugger.CommandDefinition CreateMutableCharProperty(string categoryName, string displayName, System.Func<char> getter, System.Action<char> setter, System.Attribute[] attributes);
        static /*0x7308db8*/ NoaDebugger.CommandDefinition CreateMutableFloatProperty(string categoryName, string displayName, System.Func<float> getter, System.Action<float> setter, System.Attribute[] attributes);
        static /*0x7308e44*/ NoaDebugger.CommandDefinition CreateMutableDoubleProperty(string categoryName, string displayName, System.Func<double> getter, System.Action<double> setter, System.Attribute[] attributes);
        static /*0x7308ed0*/ NoaDebugger.CommandDefinition CreateMutableDecimalProperty(string categoryName, string displayName, System.Func<decimal> getter, System.Action<decimal> setter, System.Attribute[] attributes);
        static /*0x7308f5c*/ NoaDebugger.CommandDefinition CreateMutableBoolProperty(string categoryName, string displayName, System.Func<bool> getter, System.Action<bool> setter, System.Attribute[] attributes);
        static /*0x3839b84*/ NoaDebugger.CommandDefinition CreateMutableEnumProperty<T>(string categoryName, string displayName, System.Func<T> getter, System.Action<T> setter, System.Attribute[] attributes);
        static /*0x7308fe8*/ NoaDebugger.CommandDefinition CreateMethod(string categoryName, string displayName, System.Action method, System.Attribute[] attributes);
        static /*0x730906c*/ NoaDebugger.CommandDefinition CreateCoroutine(string categoryName, string displayName, System.Func<System.Collections.IEnumerator> coroutine, System.Attribute[] attributes);
        static /*0x73090f0*/ NoaDebugger.CommandDefinition CreateHandleMethod(string categoryName, string displayName, System.Func<NoaDebugger.MethodHandler> method, System.Attribute[] attributes);
        static /*0x7309174*/ void AddCommand(NoaDebugger.CommandDefinition commandDefinition);
        static /*0x730924c*/ void RemoveCommand(NoaDebugger.CommandDefinition commandDefinition);
        static /*0x7309324*/ void RefreshProperty();
        static /*0x7309374*/ void DeleteAllSavedProperties();
        static /*0x73096b0*/ void DeleteAllPropertiesInCategory(string categoryName);
        static /*0x7309a04*/ void DeleteSavedProperty(string categoryName, string propertyName);
        static /*0x7309a9c*/ string GetSavePropertyKey(string categoryName, string propertyName);
        static /*0x7309be0*/ void SetInteractable(string categoryName, string commandTag, bool isInteractable);
        static /*0x7309c58*/ bool IsInteractable(string categoryName, string commandTag);
        static /*0x7309cc0*/ void SetVisible(string categoryName, string commandTag, bool isVisible);
        static /*0x7309d38*/ bool IsVisible(string categoryName, string commandTag);

        struct DebugCategory
        {
            /*0x10*/ int _order;
            /*0x18*/ string _displayName;
            /*0x20*/ System.Type _type;

            /*0x7309ec4*/ DebugCategory(int order, string displayName, System.Type type);
        }

        class <>c__DisplayClass13_0
        {
            /*0x10*/ System.Func<sbyte> getter;

            /*0x7307a48*/ <>c__DisplayClass13_0();
            /*0x7309efc*/ object <CreateGetOnlySByteProperty>b__0();
        }

        class <>c__DisplayClass14_0
        {
            /*0x10*/ System.Func<byte> getter;

            /*0x7307b60*/ <>c__DisplayClass14_0();
            /*0x7309f40*/ object <CreateGetOnlyByteProperty>b__0();
        }

        class <>c__DisplayClass15_0
        {
            /*0x10*/ System.Func<short> getter;

            /*0x7307c78*/ <>c__DisplayClass15_0();
            /*0x7309f84*/ object <CreateGetOnlyShortProperty>b__0();
        }

        class <>c__DisplayClass16_0
        {
            /*0x10*/ System.Func<ushort> getter;

            /*0x7307d90*/ <>c__DisplayClass16_0();
            /*0x7309fc8*/ object <CreateGetOnlyUShortProperty>b__0();
        }

        class <>c__DisplayClass17_0
        {
            /*0x10*/ System.Func<int> getter;

            /*0x7307ea8*/ <>c__DisplayClass17_0();
            /*0x730a00c*/ object <CreateGetOnlyIntProperty>b__0();
        }

        class <>c__DisplayClass18_0
        {
            /*0x10*/ System.Func<uint> getter;

            /*0x7307fc0*/ <>c__DisplayClass18_0();
            /*0x730a050*/ object <CreateGetOnlyUIntProperty>b__0();
        }

        class <>c__DisplayClass19_0
        {
            /*0x10*/ System.Func<long> getter;

            /*0x73080d8*/ <>c__DisplayClass19_0();
            /*0x730a094*/ object <CreateGetOnlyLongProperty>b__0();
        }

        class <>c__DisplayClass20_0
        {
            /*0x10*/ System.Func<ulong> getter;

            /*0x73081f0*/ <>c__DisplayClass20_0();
            /*0x730a0d8*/ object <CreateGetOnlyULongProperty>b__0();
        }

        class <>c__DisplayClass21_0
        {
            /*0x10*/ System.Func<char> getter;

            /*0x7308308*/ <>c__DisplayClass21_0();
            /*0x730a11c*/ object <CreateGetOnlyCharProperty>b__0();
        }

        class <>c__DisplayClass22_0
        {
            /*0x10*/ System.Func<float> getter;

            /*0x7308420*/ <>c__DisplayClass22_0();
            /*0x730a160*/ object <CreateGetOnlyFloatProperty>b__0();
        }

        class <>c__DisplayClass23_0
        {
            /*0x10*/ System.Func<double> getter;

            /*0x7308538*/ <>c__DisplayClass23_0();
            /*0x730a1a0*/ object <CreateGetOnlyDoubleProperty>b__0();
        }

        class <>c__DisplayClass24_0
        {
            /*0x10*/ System.Func<decimal> getter;

            /*0x7308650*/ <>c__DisplayClass24_0();
            /*0x730a1e0*/ object <CreateGetOnlyDecimalProperty>b__0();
        }

        class <>c__DisplayClass25_0
        {
            /*0x10*/ System.Func<bool> getter;

            /*0x7308768*/ <>c__DisplayClass25_0();
            /*0x730a278*/ object <CreateGetOnlyBoolProperty>b__0();
        }

        class <>c__DisplayClass41_0<T>
        {
            /*0x0*/ System.Func<T> getter;
            /*0x0*/ System.Action<T> setter;

            /*0x38159dc*/ <>c__DisplayClass41_0();
            /*0x38148bc*/ System.Enum <CreateMutableEnumProperty>b__0();
            /*0x3816710*/ void <CreateMutableEnumProperty>b__1(System.Enum value);
        }
    }

    class MethodHandler
    {
        /*0x10*/ bool <IsDone>k__BackingField;

        /*0x730a2d4*/ MethodHandler();
        /*0x730a2c0*/ bool get_IsDone();
        /*0x730a2c8*/ void set_IsDone(bool value);
    }

    class CustomInformationRegister
    {
        static /*0x730a2dc*/ void AddGroup(string name, string displayName, int order);
        static /*0x730a3c4*/ void AddKeyValue(string groupName, string keyName, System.Func<string> getValue, string displayName, int order);
        static /*0x730a4c8*/ string GetCustomInformationValue(string keyName);
        static /*0x730a5ac*/ NoaDebugger.NoaCustomInformationGroup GetCustomInformationGroup(string keyName);
        static /*0x730a67c*/ System.Collections.Generic.List<NoaDebugger.NoaCustomInformationGroup> GetCustomInformationAll();
        static /*0x730a744*/ void RemoveKeyValue(string keyName);
        static /*0x730a810*/ void RemoveGroup(string groupName);
        static /*0x730a8dc*/ void RemoveAll();
        static /*0x730a9a0*/ void RefreshView();
    }

    class NoaCustomInformationGroup
    {
        /*0x10*/ string <Name>k__BackingField;
        /*0x18*/ System.Collections.Generic.Dictionary<string, string> <KeyValues>k__BackingField;

        /*0x730aa74*/ NoaCustomInformationGroup(string groupName, System.Collections.Generic.Dictionary<string, string> keyValues);
        /*0x730aa64*/ string get_Name();
        /*0x730aa6c*/ System.Collections.Generic.Dictionary<string, string> get_KeyValues();
    }

    class NoaInformation
    {
        static /*0x730aab8*/ NoaDebugger.SystemInformation get_SystemInformation();
        static /*0x730ab84*/ NoaDebugger.UnityInformation get_UnityInformation();
        static /*0x730aabc*/ NoaDebugger.SystemInformation _GetSystemInformation();
        static /*0x730ab88*/ NoaDebugger.UnityInformation _GetUnityInformation();
        static /*0x730ac50*/ System.Func<string, string, bool> get_OnDownload();
        static /*0x730ad0c*/ void set_OnDownload(System.Func<string, string, bool> value);
        /*0x730ae60*/ NoaInformation();
    }

    class ApplicationInfo
    {
        /*0x10*/ string <Identification>k__BackingField;
        /*0x18*/ string <Version>k__BackingField;
        /*0x20*/ string <Language>k__BackingField;
        /*0x28*/ string <Platform>k__BackingField;

        /*0x730aea8*/ ApplicationInfo();
        /*0x730ae68*/ void set_Identification(string value);
        /*0x730ae70*/ string get_Identification();
        /*0x730ae78*/ void set_Version(string value);
        /*0x730ae80*/ string get_Version();
        /*0x730ae88*/ void set_Language(string value);
        /*0x730ae90*/ string get_Language();
        /*0x730ae98*/ void set_Platform(string value);
        /*0x730aea0*/ string get_Platform();
    }

    class CpuInfo
    {
        /*0x10*/ string <Type>k__BackingField;
        /*0x18*/ string <Count>k__BackingField;

        /*0x730aff0*/ CpuInfo();
        /*0x730afd0*/ void set_Type(string value);
        /*0x730afd8*/ string get_Type();
        /*0x730afe0*/ void set_Count(string value);
        /*0x730afe8*/ string get_Count();
    }

    class DeviceInfo
    {
        /*0x10*/ string <OS>k__BackingField;
        /*0x18*/ string <Model>k__BackingField;
        /*0x20*/ string <Type>k__BackingField;
        /*0x28*/ string <Name>k__BackingField;

        /*0x730b094*/ DeviceInfo(string deviceType);
        /*0x730b054*/ void set_OS(string value);
        /*0x730b05c*/ string get_OS();
        /*0x730b064*/ void set_Model(string value);
        /*0x730b06c*/ string get_Model();
        /*0x730b074*/ void set_Type(string value);
        /*0x730b07c*/ string get_Type();
        /*0x730b084*/ void set_Name(string value);
        /*0x730b08c*/ string get_Name();
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

        static /*0x730b760*/ DisplayInfo();
        /*0x730b19c*/ DisplayInfo();
        /*0x730b10c*/ void set_RefreshRate(int value);
        /*0x730b114*/ int get_RefreshRate();
        /*0x730b11c*/ void set_ScreenWidth(int value);
        /*0x730b124*/ int get_ScreenWidth();
        /*0x730b12c*/ void set_ScreenHeight(int value);
        /*0x730b134*/ int get_ScreenHeight();
        /*0x730b13c*/ void set_AspectRatioValue(float value);
        /*0x730b144*/ float get_AspectRatioValue();
        /*0x730b14c*/ void set_AspectX(float value);
        /*0x730b154*/ float get_AspectX();
        /*0x730b15c*/ void set_AspectY(float value);
        /*0x730b164*/ float get_AspectY();
        /*0x730b16c*/ void set_Dpi(string value);
        /*0x730b174*/ string get_Dpi();
        /*0x730b17c*/ void set_Orientation(string value);
        /*0x730b184*/ string get_Orientation();
        /*0x730b18c*/ void set_FullscreenMode(string value);
        /*0x730b194*/ string get_FullscreenMode();
        /*0x730b1b8*/ void Refresh();
        /*0x730b360*/ System.ValueTuple<float, float, float> _GetAspectRatio(int screenWidth, int screenHeight);
        /*0x730b650*/ float _GetRoundedAspectRatioValue(float top, float bottom);
        /*0x730b6bc*/ float _GetRoundedValue(float value, int digits);
        /*0x730b5d8*/ string _GetScreenOrientationString();
        /*0x730b640*/ string _GetFullscreenModeString();

        class <>c__DisplayClass41_0
        {
            /*0x10*/ NoaDebugger.DisplayInfo <>4__this;
            /*0x18*/ float aspectRatioValue;
            /*0x1c*/ System.ValueTuple<float, float> sameRatio;

            /*0x730b648*/ <>c__DisplayClass41_0();
            /*0x730baa8*/ float <_GetAspectRatio>b__0(System.ValueTuple<int, int> common);
        }
    }

    class GpuInfo
    {
        /*0x10*/ string <DeviceName>k__BackingField;
        /*0x18*/ string <DeviceType>k__BackingField;
        /*0x20*/ string <DeviceVersion>k__BackingField;
        /*0x28*/ string <DeviceVendor>k__BackingField;
        /*0x30*/ float <DeviceSizeGB>k__BackingField;

        /*0x730bbd4*/ GpuInfo();
        /*0x730bb84*/ void set_DeviceName(string value);
        /*0x730bb8c*/ string get_DeviceName();
        /*0x730bb94*/ void set_DeviceType(string value);
        /*0x730bb9c*/ string get_DeviceType();
        /*0x730bba4*/ void set_DeviceVersion(string value);
        /*0x730bbac*/ string get_DeviceVersion();
        /*0x730bbb4*/ void set_DeviceVendor(string value);
        /*0x730bbbc*/ string get_DeviceVendor();
        /*0x730bbc4*/ void set_DeviceSizeGB(float value);
        /*0x730bbcc*/ float get_DeviceSizeGB();
    }

    class SystemInformation
    {
        /*0x10*/ NoaDebugger.ApplicationInfo <ApplicationInfo>k__BackingField;
        /*0x18*/ NoaDebugger.DeviceInfo <DeviceInfo>k__BackingField;
        /*0x20*/ NoaDebugger.CpuInfo <CpuInfo>k__BackingField;
        /*0x28*/ NoaDebugger.GpuInfo <GpuInfo>k__BackingField;
        /*0x30*/ NoaDebugger.SystemMemoryInfo <SystemMemoryInfo>k__BackingField;
        /*0x38*/ NoaDebugger.DisplayInfo <DisplayInfo>k__BackingField;

        /*0x730bd20*/ SystemInformation(NoaDebugger.SystemInformationModel model);
        /*0x730bcc0*/ void set_ApplicationInfo(NoaDebugger.ApplicationInfo value);
        /*0x730bcc8*/ NoaDebugger.ApplicationInfo get_ApplicationInfo();
        /*0x730bcd0*/ void set_DeviceInfo(NoaDebugger.DeviceInfo value);
        /*0x730bcd8*/ NoaDebugger.DeviceInfo get_DeviceInfo();
        /*0x730bce0*/ void set_CpuInfo(NoaDebugger.CpuInfo value);
        /*0x730bce8*/ NoaDebugger.CpuInfo get_CpuInfo();
        /*0x730bcf0*/ void set_GpuInfo(NoaDebugger.GpuInfo value);
        /*0x730bcf8*/ NoaDebugger.GpuInfo get_GpuInfo();
        /*0x730bd00*/ void set_SystemMemoryInfo(NoaDebugger.SystemMemoryInfo value);
        /*0x730bd08*/ NoaDebugger.SystemMemoryInfo get_SystemMemoryInfo();
        /*0x730bd10*/ void set_DisplayInfo(NoaDebugger.DisplayInfo value);
        /*0x730bd18*/ NoaDebugger.DisplayInfo get_DisplayInfo();
    }

    class SystemMemoryInfo
    {
        /*0x10*/ float <MemorySizeMB>k__BackingField;

        /*0x730bdb8*/ SystemMemoryInfo(float memorySizeMB);
        /*0x730bda8*/ void set_MemorySizeMB(float value);
        /*0x730bdb0*/ float get_MemorySizeMB();
    }

    class FeaturesInfo
    {
        /*0x10*/ bool <Location>k__BackingField;
        /*0x11*/ bool <Accelerometer>k__BackingField;
        /*0x12*/ bool <Gyroscope>k__BackingField;
        /*0x13*/ bool <Vibration>k__BackingField;

        /*0x730be30*/ FeaturesInfo();
        /*0x730bde0*/ void set_Location(bool value);
        /*0x730bdec*/ bool get_Location();
        /*0x730bdf4*/ void set_Accelerometer(bool value);
        /*0x730be00*/ bool get_Accelerometer();
        /*0x730be08*/ void set_Gyroscope(bool value);
        /*0x730be14*/ bool get_Gyroscope();
        /*0x730be1c*/ void set_Vibration(bool value);
        /*0x730be28*/ bool get_Vibration();
    }

    class GraphicsInfo
    {
        /*0x10*/ int <MaxTexSize>k__BackingField;
        /*0x14*/ UnityEngine.NPOTSupport <NpotSupport>k__BackingField;
        /*0x18*/ bool <ComputeShaders>k__BackingField;
        /*0x19*/ bool <Shadows>k__BackingField;
        /*0x1a*/ bool <SparseTextures>k__BackingField;

        /*0x730bee4*/ GraphicsInfo();
        /*0x730be88*/ void set_MaxTexSize(int value);
        /*0x730be90*/ int get_MaxTexSize();
        /*0x730be98*/ void set_NpotSupport(UnityEngine.NPOTSupport value);
        /*0x730bea0*/ UnityEngine.NPOTSupport get_NpotSupport();
        /*0x730bea8*/ void set_ComputeShaders(bool value);
        /*0x730beb4*/ bool get_ComputeShaders();
        /*0x730bebc*/ void set_Shadows(bool value);
        /*0x730bec8*/ bool get_Shadows();
        /*0x730bed0*/ void set_SparseTextures(bool value);
        /*0x730bedc*/ bool get_SparseTextures();
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

        /*0x730bfb4*/ RuntimeInfo();
        /*0x730bf44*/ void set_PlayTime(float value);
        /*0x730bf4c*/ float get_PlayTime();
        /*0x730bf54*/ void set_LevelPlayTime(float value);
        /*0x730bf5c*/ float get_LevelPlayTime();
        /*0x730bf64*/ void set_CurrentLevelSceneName(string value);
        /*0x730bf6c*/ string get_CurrentLevelSceneName();
        /*0x730bf74*/ void set_CurrentLevelBuildIndex(int value);
        /*0x730bf7c*/ int get_CurrentLevelBuildIndex();
        /*0x730bf84*/ void set_QualityLevel(int value);
        /*0x730bf8c*/ int get_QualityLevel();
        /*0x730bf94*/ void set_RenderPipeline(string value);
        /*0x730bf9c*/ string get_RenderPipeline();
        /*0x730bfa4*/ void set_SRPBatcher(string value);
        /*0x730bfac*/ string get_SRPBatcher();
        /*0x730c26c*/ void RefreshTime();
        /*0x730c294*/ void RefreshScene();
        /*0x730c08c*/ void RefreshRenderPipelineSettings();
    }

    class UnityInfo
    {
        /*0x10*/ string <Version>k__BackingField;
        /*0x18*/ bool <Debug>k__BackingField;
        /*0x19*/ bool <IL2CPP>k__BackingField;
        /*0x1c*/ int <VSyncCount>k__BackingField;
        /*0x20*/ int <TargetFrameRate>k__BackingField;

        /*0x730c38c*/ UnityInfo();
        /*0x730c334*/ void set_Version(string value);
        /*0x730c33c*/ string get_Version();
        /*0x730c344*/ void set_Debug(bool value);
        /*0x730c350*/ bool get_Debug();
        /*0x730c358*/ void set_IL2CPP(bool value);
        /*0x730c364*/ bool get_IL2CPP();
        /*0x730c36c*/ void set_VSyncCount(int value);
        /*0x730c374*/ int get_VSyncCount();
        /*0x730c37c*/ void set_TargetFrameRate(int value);
        /*0x730c384*/ int get_TargetFrameRate();
        /*0x730c454*/ void Refresh();
    }

    class UnityInformation
    {
        /*0x10*/ NoaDebugger.UnityInfo <UnityInfo>k__BackingField;
        /*0x18*/ NoaDebugger.RuntimeInfo <RuntimeInfo>k__BackingField;
        /*0x20*/ NoaDebugger.FeaturesInfo <FeaturesInfo>k__BackingField;
        /*0x28*/ NoaDebugger.GraphicsInfo <GraphicsInfo>k__BackingField;

        /*0x730c4fc*/ UnityInformation(NoaDebugger.UnityInformationModel model);
        /*0x730c4bc*/ void set_UnityInfo(NoaDebugger.UnityInfo value);
        /*0x730c4c4*/ NoaDebugger.UnityInfo get_UnityInfo();
        /*0x730c4cc*/ void set_RuntimeInfo(NoaDebugger.RuntimeInfo value);
        /*0x730c4d4*/ NoaDebugger.RuntimeInfo get_RuntimeInfo();
        /*0x730c4dc*/ void set_FeaturesInfo(NoaDebugger.FeaturesInfo value);
        /*0x730c4e4*/ NoaDebugger.FeaturesInfo get_FeaturesInfo();
        /*0x730c4ec*/ void set_GraphicsInfo(NoaDebugger.GraphicsInfo value);
        /*0x730c4f4*/ NoaDebugger.GraphicsInfo get_GraphicsInfo();
    }

    class ApiLogEntry : NoaDebugger.LogEntry<NoaDebugger.ApiLog>
    {
        /*0x40*/ NoaDebugger.ApiLog <LogDetail>k__BackingField;

        /*0x730c574*/ ApiLogEntry(int serialNumber, string logString, string logViewString, NoaDebugger.ApiLog logDetail, NoaDebugger.LogType logType, System.DateTime receivedAt);
        /*0x730c564*/ void set_LogDetail(NoaDebugger.ApiLog value);
        /*0x730c56c*/ NoaDebugger.ApiLog get_LogDetail();
    }

    class ConsoleLogDetail : NoaDebugger.ILogDetail
    {
        /*0x10*/ string <LogDetailString>k__BackingField;
        /*0x18*/ string <LogDetailStringForDisplay>k__BackingField;
        /*0x20*/ bool <IsRegisteredApi>k__BackingField;

        /*0x730c62c*/ ConsoleLogDetail(string logString, string stackTrace, bool isRegisteredApi);
        /*0x730c614*/ string get_LogDetailString();
        /*0x730c61c*/ string get_LogDetailStringForDisplay();
        /*0x730c624*/ bool get_IsRegisteredApi();
        /*0x730c88c*/ string NoaDebugger.ILogDetail.GetClipboardText();
    }

    class ConsoleLogEntry : NoaDebugger.LogEntry<NoaDebugger.ConsoleLogDetail>
    {
        /*0x40*/ string <StackTraceString>k__BackingField;
        /*0x48*/ NoaDebugger.ConsoleLogDetail <LogDetail>k__BackingField;

        /*0x730c8c8*/ ConsoleLogEntry(int serialNumber, string logString, string stackTraceString, string logViewString, NoaDebugger.ConsoleLogDetail logDetail, NoaDebugger.LogType logType, System.DateTime receivedAt);
        /*0x730c8a8*/ void set_StackTraceString(string value);
        /*0x730c8b0*/ string get_StackTraceString();
        /*0x730c8b8*/ void set_LogDetail(NoaDebugger.ConsoleLogDetail value);
        /*0x730c8c0*/ NoaDebugger.ConsoleLogDetail get_LogDetail();
    }

    interface ILogDetail
    {
        /*0x38148bc*/ string GetClipboardText();
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

        /*0x3910ae8*/ LogEntry(int serialNumber, string logString, string logViewString, NoaDebugger.LogType logType, System.DateTime receivedAt);
        /*0x3816710*/ void set_LogString(string value);
        /*0x38148bc*/ string get_LogString();
        /*0x3816710*/ void set_LogViewString(string value);
        /*0x38148bc*/ string get_LogViewString();
        /*0x3815cc4*/ void set_HasLoggedOnce(bool value);
        /*0x3813ffc*/ bool get_HasLoggedOnce();
        /*0x3815ed0*/ void set_LogType(NoaDebugger.LogType value);
        /*0x3814574*/ NoaDebugger.LogType get_LogType();
        void set_ReceivedAt(System.DateTime value);
        /*0x381440c*/ System.DateTime get_ReceivedAt();
        /*0x3910ae8*/ void set_LogDetail(TLogDetail value);
        /*0x3910ae8*/ TLogDetail get_LogDetail();
        /*0x3815ed0*/ void set_NumberOfMatchingLogs(int value);
        /*0x3814574*/ int get_NumberOfMatchingLogs();
        /*0x3815cc4*/ void set_IsSelecting(bool value);
        /*0x3813ffc*/ bool get_IsSelecting();
    }

    enum LogType
    {
        Error = 0,
        Warning = 1,
        Log = 2,
    }

    class NoaApiLog
    {
        static /*0x730c984*/ System.Collections.Generic.LinkedList<NoaDebugger.ApiLogEntry> get_LogList();
        static /*0x730ca50*/ UnityEngine.Events.UnityAction<NoaDebugger.ApiLogEntry> get_OnError();
        static /*0x730cb0c*/ void set_OnError(UnityEngine.Events.UnityAction<NoaDebugger.ApiLogEntry> value);
        static /*0x730cc60*/ UnityEngine.Events.UnityAction<NoaDebugger.ApiLogEntry, string> get_OnLogCopied();
        static /*0x730cd1c*/ void set_OnLogCopied(UnityEngine.Events.UnityAction<NoaDebugger.ApiLogEntry, string> value);
        static /*0x730ce70*/ System.Func<string, string, bool> get_OnLogDownload();
        static /*0x730cf2c*/ void set_OnLogDownload(System.Func<string, string, bool> value);
        static /*0x730d08c*/ System.Func<string, System.Collections.Generic.List<NoaDebugger.ApiLogEntry>, bool> get_OnLogDownloadWithLogEntries();
        static /*0x730d148*/ void set_OnLogDownloadWithLogEntries(System.Func<string, System.Collections.Generic.List<NoaDebugger.ApiLogEntry>, bool> value);
        static /*0x730d2a8*/ UnityEngine.Events.UnityAction<System.Collections.Generic.List<NoaDebugger.ApiLogEntry>> get_OnLogSend();
        static /*0x730d364*/ void set_OnLogSend(UnityEngine.Events.UnityAction<System.Collections.Generic.List<NoaDebugger.ApiLogEntry>> value);
        static /*0x730c988*/ System.Collections.Generic.LinkedList<NoaDebugger.ApiLogEntry> _GetLogList();
        static /*0x730d4b8*/ void Clear();
        /*0x730d590*/ NoaApiLog();
    }

    class NoaConsoleLog
    {
        static /*0x730d598*/ System.Collections.Generic.LinkedList<NoaDebugger.ConsoleLogEntry> get_LogList();
        static /*0x730d6e0*/ UnityEngine.Events.UnityAction<NoaDebugger.ConsoleLogEntry> get_OnError();
        static /*0x730d79c*/ void set_OnError(UnityEngine.Events.UnityAction<NoaDebugger.ConsoleLogEntry> value);
        static /*0x730d8f0*/ System.Func<NoaDebugger.ConsoleLogEntry, bool> get_OnFilterErrorNotification();
        static /*0x730d9ac*/ void set_OnFilterErrorNotification(System.Func<NoaDebugger.ConsoleLogEntry, bool> value);
        static /*0x730db00*/ UnityEngine.Events.UnityAction<NoaDebugger.ConsoleLogEntry, string> get_OnLogCopied();
        static /*0x730dbbc*/ void set_OnLogCopied(UnityEngine.Events.UnityAction<NoaDebugger.ConsoleLogEntry, string> value);
        static /*0x730dd10*/ System.Func<string, string, bool> get_OnLogDownload();
        static /*0x730ddcc*/ void set_OnLogDownload(System.Func<string, string, bool> value);
        static /*0x730df2c*/ System.Func<string, System.Collections.Generic.List<NoaDebugger.ConsoleLogEntry>, bool> get_OnLogDownloadWithLogEntries();
        static /*0x730dfe8*/ void set_OnLogDownloadWithLogEntries(System.Func<string, System.Collections.Generic.List<NoaDebugger.ConsoleLogEntry>, bool> value);
        static /*0x730e148*/ UnityEngine.Events.UnityAction<System.Collections.Generic.List<NoaDebugger.ConsoleLogEntry>> get_OnLogSend();
        static /*0x730e204*/ void set_OnLogSend(UnityEngine.Events.UnityAction<System.Collections.Generic.List<NoaDebugger.ConsoleLogEntry>> value);
        static /*0x730d59c*/ System.Collections.Generic.LinkedList<NoaDebugger.ConsoleLogEntry> _GetLogList();
        static /*0x730e358*/ void _AddUnsafe(UnityEngine.LogType logType, string message, string stackTrace);
        static /*0x730e474*/ void Add(UnityEngine.LogType logType, string message, string stackTrace);
        static /*0x730e668*/ void Clear();
        /*0x730e76c*/ NoaConsoleLog();
    }

    class NoaController
    {
        static /*0x0*/ int CustomActionButtonCount;

        static /*0x730e964*/ NoaController();
        static /*0x730e774*/ System.Action get_OnShow();
        static /*0x730e77c*/ void set_OnShow(System.Action value);
        static /*0x730e784*/ System.Action get_OnHide();
        static /*0x730e78c*/ void set_OnHide(System.Action value);
        static /*0x730e794*/ System.Action<bool> get_OnTogglePauseResume();
        static /*0x730e79c*/ void set_OnTogglePauseResume(System.Action<bool> value);
        static /*0x730e7a4*/ System.Action<float> get_OnGameSpeedChanged();
        static /*0x730e7ac*/ void set_OnGameSpeedChanged(System.Action<float> value);
        static /*0x730e7b4*/ System.Func<bool> get_OnApplicationReset();
        static /*0x730e7bc*/ void set_OnApplicationReset(System.Func<bool> value);
        static /*0x730e7c4*/ System.Func<bool, bool> get_OnToggleNoaDebuggerUI();
        static /*0x730e804*/ void set_OnToggleNoaDebuggerUI(System.Func<bool, bool> value);
        static /*0x730e854*/ System.Func<NoaDebugger.NoaController.ScreenshotTarget> get_OnBeforeScreenshot();
        static /*0x730e85c*/ void set_OnBeforeScreenshot(System.Func<NoaDebugger.NoaController.ScreenshotTarget> value);
        static /*0x730e864*/ System.Func<bool> get_OnCaptureScreenshot();
        static /*0x730e86c*/ void set_OnCaptureScreenshot(System.Func<bool> value);
        static /*0x730e874*/ System.Action get_OnAfterScreenshot();
        static /*0x730e87c*/ void set_OnAfterScreenshot(System.Action value);
        static /*0x730e884*/ System.Action get_OnFrameStepping();
        static /*0x730e88c*/ void set_OnFrameStepping(System.Action value);
        static /*0x730e894*/ bool get_IsVisible();
        static /*0x730e898*/ bool get_IsGamePlaying();
        static /*0x730e8a0*/ float get_GameSpeed();
        static /*0x730e8a8*/ void Show();
        static /*0x730e8b0*/ void Hide();
        static /*0x730e8b8*/ void SetCustomTapAction(int buttonIndex, System.Action action, System.Func<string> messageFunc);
        static /*0x730e8c0*/ void SetCustomLongPressAction(int buttonIndex, System.Action action, System.Func<string> messageFunc);
        static /*0x730e8c8*/ void SetCustomToggleAction(int buttonIndex, System.Action<bool> action, System.Func<bool, string> messageFunc, System.Nullable<bool> initialState);
        static /*0x730e8d4*/ void SetCustomActionType(int buttonIndex, NoaDebugger.NoaController.CustomActionType actionType);
        static /*0x730e8dc*/ NoaDebugger.NoaController.CustomActionType GetCustomActionType(int buttonIndex);
        static /*0x730e8e4*/ void RunCustomTapAction(int buttonIndex);
        static /*0x730e8ec*/ void RunCustomLongPressAction(int buttonIndex);
        static /*0x730e8f4*/ void SetCustomToggle(int buttonIndex, bool isOn);
        static /*0x730e900*/ bool GetCustomToggle(int buttonIndex);
        static /*0x730e908*/ void TogglePauseResume();
        static /*0x730e910*/ void IncreaseGameSpeed();
        static /*0x730e918*/ void DecreaseGameSpeed();
        static /*0x730e920*/ void MinimizeGameSpeed();
        static /*0x730e928*/ void MaximizeGameSpeed();
        static /*0x730e930*/ void ResetGameSpeed();
        static /*0x730e938*/ void FrameStepping();
        static /*0x730e940*/ void ResetApplication();
        static /*0x730e948*/ void ToggleNoaDebuggerUI();
        static /*0x730e94c*/ void CaptureScreenshot();
        static /*0x730e954*/ byte[] GetCapturedScreenshot();
        static /*0x730e95c*/ void ClearCapturedScreenshot();

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

        /*0x730ee58*/ NoaCustomMenuBase();
        /*0x730e9b0*/ NoaDebugger.ToolNotificationStatus NoaDebugger.INoaDebuggerTool.get_NotifyStatus();
        /*0x730e9b8*/ void NoaDebugger.INoaDebuggerTool.Init();
        /*0x730ea34*/ NoaDebugger.IMenuInfo NoaDebugger.INoaDebuggerTool.MenuInfo();
        /*0x730eb0c*/ void NoaDebugger.INoaDebuggerTool.ShowView(UnityEngine.Transform parent);
        /*0x730ecbc*/ void _ShowView(UnityEngine.GameObject view);
        /*0x730ed0c*/ void NoaDebugger.INoaDebuggerTool.AlignmentUI(bool isReverse);
        /*0x730ed10*/ void NoaDebugger.INoaDebuggerTool.OnHidden();
        /*0x730edb4*/ void NoaDebugger.INoaDebuggerTool.OnToolDispose();
        /*0x730ee48*/ void OnShow(UnityEngine.GameObject view);
        /*0x730ee4c*/ void OnHide();
        /*0x730ee50*/ void OnInitialize();
        /*0x730ee54*/ void OnDispose();
        /*0x38148bc*/ string get_ViewPrefabPath();
        /*0x38148bc*/ string get_MenuName();

        class CustomMenuInfo : NoaDebugger.IMenuInfo
        {
            /*0x10*/ string <MenuName>k__BackingField;

            /*0x730eadc*/ CustomMenuInfo(string menuName);
            /*0x730ee78*/ CustomMenuInfo();
            /*0x730ee60*/ string get_Name();
            /*0x730ee68*/ string get_MenuName();
            /*0x730ee70*/ int get_SortNo();
        }
    }

    class NoaDebug
    {
        static /*0x730ee80*/ System.Action<int> get_OnShow();
        static /*0x730eecc*/ void set_OnShow(System.Action<int> value);
        static /*0x730ef20*/ System.Action<int> get_OnHide();
        static /*0x730ef6c*/ void set_OnHide(System.Action<int> value);
        static /*0x730efc0*/ System.Action<int, bool> get_OnMenuChanged();
        static /*0x730f00c*/ void set_OnMenuChanged(System.Action<int, bool> value);
        static /*0x730f060*/ UnityEngine.Transform get_RootTransform();
        static /*0x730f0ac*/ bool get_IsInitialized();
        static /*0x730f0f8*/ bool get_IsShortcutsEnabled();
        static /*0x730f144*/ bool get_IsWorldSpaceRenderingEnabled();
        static /*0x730f190*/ bool get_IsDebuggerVisible();
        static /*0x730f194*/ bool get_IsTriggerButtonVisible();
        static /*0x730f198*/ bool get_IsOverlayVisible();
        static /*0x730f19c*/ bool get_IsFloatingWindowVisible();
        static /*0x730f1a0*/ void Initialize();
        static /*0x730f1f0*/ void Show();
        static /*0x730f244*/ void Show(System.Nullable<int> index, bool isCustomMenu);
        static /*0x730f2dc*/ void Show(NoaDebugger.NoaDebug.MenuType menuType);
        static /*0x730f330*/ void Hide();
        static /*0x730f37c*/ void SetDebuggerActive(bool isActive);
        static /*0x730f384*/ void SetOverlayActive(bool isActive);
        static /*0x730f38c*/ void SetOverlayEnabled(NoaDebugger.NoaDebug.OverlayFeatures feature, bool isEnabled);
        static /*0x730f3f0*/ bool GetOverlayEnabled(NoaDebugger.NoaDebug.OverlayFeatures feature);
        static /*0x730f444*/ void SetFloatingWindowActive(bool isActive);
        static /*0x730f44c*/ void SetTriggerButtonActive(bool isActive);
        static /*0x730f454*/ void SetFont(TMPro.TMP_FontAsset fontAsset, UnityEngine.Material fontMaterial, float fontSizeRate);
        static /*0x730f4c8*/ UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab, NoaDebugger.NoaDebug.HierarchyLevelGroup group);
        static /*0x730f6d8*/ void SetShortcutsEnabled(bool isEnabled);
        static /*0x730f72c*/ void EnableWorldSpaceRendering(UnityEngine.Camera worldCamera);
        static /*0x730f780*/ void DisableWorldSpaceRendering();
        static /*0x730f7cc*/ void CopyToClipboard(string text);
        static /*0x730f820*/ void DownloadText(string text, string fileName, string mimeType);
        static /*0x730f88c*/ void Destroy();
        static /*0x730f8d8*/ void TakeScreenshot(System.Action<System.Byte[]> callback);

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
        static /*0x730f8e0*/ void SetString(string key, string value);
        static /*0x730f9b8*/ void SetSByte(string key, sbyte value);
        static /*0x730fa2c*/ void SetByte(string key, byte value);
        static /*0x730faa0*/ void SetShort(string key, short value);
        static /*0x730fb14*/ void SetUShort(string key, ushort value);
        static /*0x730fb88*/ void SetInt(string key, int value);
        static /*0x730fbfc*/ void SetUInt(string key, uint value);
        static /*0x730fc70*/ void SetLong(string key, long value);
        static /*0x730fce4*/ void SetULong(string key, ulong value);
        static /*0x730fd58*/ void SetChar(string key, char value);
        static /*0x730fdcc*/ void SetFloat(string key, float value);
        static /*0x730fe40*/ void SetDouble(string key, double value);
        static /*0x730feb4*/ void SetDecimal(string key, decimal value);
        static /*0x730ff30*/ void SetBoolean(string key, bool value);
        static /*0x730ffa4*/ string GetString(string key, string defaultValue);
        static /*0x7310018*/ sbyte GetSByte(string key, sbyte defaultValue);
        static /*0x731008c*/ byte GetByte(string key, byte defaultValue);
        static /*0x7310100*/ short GetShort(string key, short defaultValue);
        static /*0x7310174*/ ushort GetUShort(string key, ushort defaultValue);
        static /*0x73101e8*/ int GetInt(string key, int defaultValue);
        static /*0x731025c*/ uint GetUInt(string key, uint defaultValue);
        static /*0x73102d0*/ long GetLong(string key, long defaultValue);
        static /*0x7310344*/ ulong GetULong(string key, ulong defaultValue);
        static /*0x73103b8*/ char GetChar(string key, char defaultValue);
        static /*0x731042c*/ float GetFloat(string key, float defaultValue);
        static /*0x73104a0*/ double GetDouble(string key, double defaultValue);
        static /*0x7310514*/ decimal GetDecimal(string key, decimal defaultValue);
        static /*0x7310590*/ bool GetBoolean(string key, bool defaultValue);
        static /*0x7310604*/ void DeleteAt(string key);
        static /*0x7310668*/ void DeleteAllSaveData();
        static /*0x7310808*/ void DeleteAllToolData();
        static /*0x730f954*/ string _GetSaveKey(string key);
        /*0x7310854*/ NoaPrefs();
    }

    class NoaUIElement
    {
        static /*0x731085c*/ void RegisterUIElement(NoaDebugger.INoaUIElement element);
        static /*0x73108b0*/ void UnregisterUIElement(string key);
        static /*0x7310904*/ void UnregisterAllUIElements();
        static /*0x7310950*/ bool IsUIElementRegistered(string key);
        static /*0x73109a4*/ void SetUIElementVisibility(string key, bool visible);
        static /*0x7310a08*/ void SetAllUIElementsVisibility(bool visible);
        static /*0x7310a10*/ bool IsUIElementVisible(string key);
        static /*0x7310a64*/ void SetVerticalAlignment(NoaDebugger.AnchorType anchorType);
        static /*0x7310ab8*/ void SetHorizontalAlignment(NoaDebugger.AnchorType anchorType);
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
        /*0x38148bc*/ string get_Key();
        /*0x3814574*/ NoaDebugger.AnchorType get_AnchorType();
        /*0x38148bc*/ UnityEngine.RectTransform get_Parent();
    }

    interface IUpdatableNoaUIElement : NoaDebugger.INoaUIElement
    {
        /*0x38151b8*/ float get_UpdateInterval();
        /*0x38148bc*/ string UpdateValue();
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

        static /*0x7310b44*/ NoaDebugger.NoaUIObjectElement Create(string key, UnityEngine.GameObject prefab, System.Action<UnityEngine.GameObject> onObjectCreated, NoaDebugger.AnchorType anchorType, float width, float height);
        static /*0x7310c10*/ NoaDebugger.NoaUIObjectElement Create(string key, UnityEngine.GameObject prefab, System.Action<UnityEngine.GameObject> onObjectCreated, UnityEngine.RectTransform parent, float width, float height);
        /*0x7310c08*/ NoaUIObjectElement();
        /*0x7310b0c*/ string get_Key();
        /*0x7310b14*/ NoaDebugger.AnchorType get_AnchorType();
        /*0x7310b1c*/ UnityEngine.RectTransform get_Parent();
        /*0x7310b24*/ UnityEngine.GameObject get_Prefab();
        /*0x7310b2c*/ System.Action<UnityEngine.GameObject> get_OnObjectCreated();
        /*0x7310b34*/ float get_Width();
        /*0x7310b3c*/ float get_Height();
    }

    class NoaUITextElement : NoaDebugger.IUpdatableNoaUIElement, NoaDebugger.INoaUIElement
    {
        /*0x10*/ string _key;
        /*0x18*/ NoaDebugger.AnchorType _anchorType;
        /*0x20*/ UnityEngine.RectTransform _parent;
        /*0x28*/ System.Func<string> _value;
        /*0x30*/ float _updateInterval;

        static /*0x7310d00*/ NoaDebugger.NoaUITextElement Create(string key, System.Func<string> value, NoaDebugger.AnchorType anchorType, float updateInterval);
        static /*0x7310dac*/ NoaDebugger.NoaUITextElement Create(string key, System.Func<string> value, UnityEngine.RectTransform parent, float updateInterval);
        static /*0x7310e5c*/ NoaDebugger.NoaUITextElement Create(string key, string value, NoaDebugger.AnchorType anchorType, float updateInterval);
        static /*0x7310f90*/ NoaDebugger.NoaUITextElement Create(string key, string value, UnityEngine.RectTransform parent, float updateInterval);
        /*0x7310da4*/ NoaUITextElement();
        /*0x7310ce0*/ string get_Key();
        /*0x7310ce8*/ NoaDebugger.AnchorType get_AnchorType();
        /*0x7310cf0*/ UnityEngine.RectTransform get_Parent();
        /*0x7310cf8*/ float get_UpdateInterval();
        /*0x73110d0*/ string UpdateValue();

        class <>c__DisplayClass15_0
        {
            /*0x10*/ string value;

            /*0x7310f88*/ <>c__DisplayClass15_0();
            /*0x73110f4*/ string <Create>b__0();
        }

        class <>c__DisplayClass16_0
        {
            /*0x10*/ string value;

            /*0x73110c8*/ <>c__DisplayClass16_0();
            /*0x73110fc*/ string <Create>b__0();
        }
    }

    class NoaUIButtonElement : NoaDebugger.INoaUIElement
    {
        /*0x10*/ string _key;
        /*0x18*/ NoaDebugger.AnchorType _anchorType;
        /*0x20*/ UnityEngine.RectTransform _parent;
        /*0x28*/ string _label;
        /*0x30*/ UnityEngine.Events.UnityAction _onClick;

        static /*0x731112c*/ NoaDebugger.NoaUIButtonElement Create(string key, string label, UnityEngine.Events.UnityAction onClick, NoaDebugger.AnchorType anchorType);
        static /*0x73111e4*/ NoaDebugger.NoaUIButtonElement Create(string key, string label, UnityEngine.Events.UnityAction onClick, UnityEngine.RectTransform parent);
        /*0x73111dc*/ NoaUIButtonElement();
        /*0x7311104*/ string get_Key();
        /*0x731110c*/ NoaDebugger.AnchorType get_AnchorType();
        /*0x7311114*/ UnityEngine.RectTransform get_Parent();
        /*0x731111c*/ string get_Label();
        /*0x7311124*/ UnityEngine.Events.UnityAction get_OnClick();
    }

    class BatteryInfo
    {
        /*0x10*/ NoaDebugger.BatteryStatus <Status>k__BackingField;
        /*0x14*/ float <CurrentLevelPercent>k__BackingField;
        /*0x18*/ float <ConsumptionPerMinute>k__BackingField;
        /*0x1c*/ int <OperatingTimeSec>k__BackingField;
        /*0x20*/ bool <IsProfiling>k__BackingField;
        /*0x21*/ bool <IsStartProfiling>k__BackingField;

        /*0x73113b8*/ BatteryInfo();
        /*0x73112a0*/ void set_Status(NoaDebugger.BatteryStatus value);
        /*0x73112a8*/ NoaDebugger.BatteryStatus get_Status();
        /*0x73112b0*/ void set_CurrentLevelPercent(float value);
        /*0x73112b8*/ float get_CurrentLevelPercent();
        /*0x73112c0*/ void set_ConsumptionPerMinute(float value);
        /*0x73112c8*/ float get_ConsumptionPerMinute();
        /*0x73112d0*/ void set_OperatingTimeSec(int value);
        /*0x73112d8*/ int get_OperatingTimeSec();
        /*0x73112e0*/ void set_IsProfiling(bool value);
        /*0x73112ec*/ bool get_IsProfiling();
        /*0x73112f4*/ void set_IsStartProfiling(bool value);
        /*0x7311300*/ bool get_IsStartProfiling();
        /*0x7311308*/ void Refresh(UnityEngine.BatteryStatus batteryStatus, float currentLevelPercent, float consumptionPerMinute, int operatingTimeSec);
        /*0x7311364*/ void StartProfiling();
        /*0x7311370*/ void SetIsProfiling(bool isProfiling);
        /*0x731137c*/ void StatusUpdate(UnityEngine.BatteryStatus batteryStatus);
        /*0x7311328*/ NoaDebugger.BatteryStatus StatusCheck(UnityEngine.BatteryStatus batteryStatus);
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

        /*0x73113f0*/ BatteryUnchangingInfo(NoaDebugger.BatteryInfo info);
        /*0x73113c0*/ NoaDebugger.BatteryStatus get_Status();
        /*0x73113c8*/ float get_CurrentLevelPercent();
        /*0x73113d0*/ float get_ConsumptionPerMinute();
        /*0x73113d8*/ int get_OperatingTimeSec();
        /*0x73113e0*/ bool get_IsProfiling();
        /*0x73113e8*/ bool get_IsViewHyphen();
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

        /*0x7311600*/ FpsInfo();
        /*0x73114a4*/ void set_CurrentFps(int value);
        /*0x73114ac*/ int get_CurrentFps();
        /*0x73114b4*/ void set_ElapsedTime(float value);
        /*0x73114bc*/ float get_ElapsedTime();
        /*0x73114c4*/ void set_Max(int value);
        /*0x73114cc*/ int get_Max();
        /*0x73114d4*/ void set_MaxStr(string value);
        /*0x73114dc*/ string get_MaxStr();
        /*0x73114e4*/ void set_Min(int value);
        /*0x73114ec*/ int get_Min();
        /*0x73114f4*/ void set_MinStr(string value);
        /*0x73114fc*/ string get_MinStr();
        /*0x7311504*/ void set_TotalFrames(int value);
        /*0x731150c*/ int get_TotalFrames();
        /*0x7311514*/ void set_TotalSeconds(float value);
        /*0x731151c*/ float get_TotalSeconds();
        /*0x7311524*/ void set_IsProfiling(bool value);
        /*0x7311530*/ bool get_IsProfiling();
        /*0x7311538*/ void set_IsStartProfiling(bool value);
        /*0x7311544*/ bool get_IsStartProfiling();
        /*0x731154c*/ void Refresh(int currentFps, float elapsedTime, int totalFrames, float totalSeconds);
        /*0x73115e8*/ void StartProfiling();
        /*0x73115f4*/ void SetIsProfiling(bool isProfiling);
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

        /*0x73116c0*/ FpsUnchangingInfo(NoaDebugger.FpsInfo info);
        /*0x7311678*/ int get_CurrentFps();
        /*0x7311680*/ float get_ElapsedTime();
        /*0x7311688*/ int get_Max();
        /*0x7311690*/ string get_MaxStr();
        /*0x7311698*/ int get_Min();
        /*0x73116a0*/ string get_MinStr();
        /*0x73116a8*/ int get_AverageFps();
        /*0x73116b0*/ bool get_IsProfiling();
        /*0x73116b8*/ bool get_IsViewHyphen();
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

        static /*0x7311f8c*/ MemoryInfo();
        /*0x7311970*/ MemoryInfo();
        /*0x73117dc*/ void set_CurrentReservedMemoryMB(float value);
        /*0x73117e4*/ float get_CurrentReservedMemoryMB();
        /*0x73117ec*/ void set_MaxReservedMemoryMB(float value);
        /*0x73117f4*/ float get_MaxReservedMemoryMB();
        /*0x73117fc*/ void set_CurrentAllocatedMemoryMB(float value);
        /*0x7311804*/ float get_CurrentAllocatedMemoryMB();
        /*0x731180c*/ void set_MaxAllocatedMemoryMB(float value);
        /*0x7311814*/ float get_MaxAllocatedMemoryMB();
        /*0x731181c*/ void set_MinAllocatedMemoryMB(float value);
        /*0x7311824*/ float get_MinAllocatedMemoryMB();
        /*0x731182c*/ void set_AverageAllocatedMemoryMB(float value);
        /*0x7311834*/ float get_AverageAllocatedMemoryMB();
        /*0x731183c*/ void set_TotalNativeMemoryMB(float value);
        /*0x7311844*/ float get_TotalNativeMemoryMB();
        /*0x731184c*/ float get_TotalMemoryMB();
        /*0x7311854*/ void set_CurrentNativeMemoryMB(float value);
        /*0x731185c*/ float get_CurrentNativeMemoryMB();
        /*0x7311864*/ float get_CurrentMemoryMB();
        /*0x731186c*/ void set_MaxNativeMemoryMB(float value);
        /*0x7311874*/ float get_MaxNativeMemoryMB();
        /*0x731187c*/ float get_MaxMemoryMB();
        /*0x7311884*/ void set_MinNativeMemoryMB(float value);
        /*0x731188c*/ float get_MinNativeMemoryMB();
        /*0x7311894*/ float get_MinMemoryMB();
        /*0x731189c*/ void set_AverageNativeMemoryMB(float value);
        /*0x73118a4*/ float get_AverageNativeMemoryMB();
        /*0x73118ac*/ float get_AverageMemoryMB();
        /*0x73118b4*/ void set_CurrentMonoHeapSizeMB(float value);
        /*0x73118bc*/ float get_CurrentMonoHeapSizeMB();
        /*0x73118c4*/ void set_MaxMonoHeapSizeMB(float value);
        /*0x73118cc*/ float get_MaxMonoHeapSizeMB();
        /*0x73118d4*/ void set_CurrentMonoUsedSizeMB(float value);
        /*0x73118dc*/ float get_CurrentMonoUsedSizeMB();
        /*0x73118e4*/ void set_MaxMonoUsedSizeMB(float value);
        /*0x73118ec*/ float get_MaxMonoUsedSizeMB();
        /*0x73118f4*/ void set_MinMonoUsedSizeMB(float value);
        /*0x73118fc*/ float get_MinMonoUsedSizeMB();
        /*0x7311904*/ void set_AverageMonoUsedSizeMB(float value);
        /*0x731190c*/ float get_AverageMonoUsedSizeMB();
        /*0x7311914*/ void set_IsProfiling(bool value);
        /*0x7311920*/ bool get_IsProfiling();
        /*0x7311928*/ void set_ProfilingType(NoaDebugger.NoaProfiler.MemoryProfilingType value);
        /*0x7311930*/ NoaDebugger.NoaProfiler.MemoryProfilingType get_ProfilingType();
        /*0x7311938*/ void set_CurrentMemoryHistory(NoaDebugger.RingBuffer<System.Single[]> value);
        /*0x7311940*/ NoaDebugger.RingBuffer<System.Single[]> get_CurrentMemoryHistory();
        /*0x7311948*/ void set_IsGraphShowing(bool value);
        /*0x7311954*/ bool get_IsGraphShowing();
        /*0x731195c*/ void set_IsStartProfiling(bool value);
        /*0x7311968*/ bool get_IsStartProfiling();
        /*0x7311c20*/ void SetTotalNativeMemoryMB(float totalMemoryMB);
        /*0x7311c9c*/ void ResetProfiledValue();
        /*0x7311ccc*/ void RefreshUnityMemory(float currentReservedMemoryMB, float currentAllocatedMemoryMB, float averageAllocatedMemoryMB);
        /*0x7311e1c*/ void RefreshNativeMemory(float currentMemoryMB, float averageMemoryMB);
        /*0x7311e58*/ void RefreshMonoMemory(float currentMonoHeapSizeMB, float currentMonoUsedSizeMB, float averageMonoUsedSizeMB);
        /*0x7311e9c*/ void StartProfiling();
        /*0x7311ea8*/ void ToggleProfiling(bool isProfiling);
        /*0x7311eb4*/ void ToggleGraphShowing(bool isShowing);
        /*0x7311f20*/ void ChangeProfilingType(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
        /*0x7311f50*/ bool IsValid();
        /*0x7311a08*/ void _InitializeHistoryBuffer();
        /*0x7311d0c*/ void _AddHistory(float currentMemoryCapacityMB, float currentMemoryUsageMB);
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

        /*0x73120c0*/ MemoryUnchangingInfo(NoaDebugger.MemoryInfo info);
        /*0x7311fe0*/ float get_CurrentReservedMemoryMB();
        /*0x7311fe8*/ float get_MaxReservedMemoryMB();
        /*0x7311ff0*/ float get_CurrentAllocatedMemoryMB();
        /*0x7311ff8*/ float get_MaxAllocatedMemoryMB();
        /*0x7312000*/ float get_MinAllocatedMemoryMB();
        /*0x7312008*/ float get_AverageAllocatedMemoryMB();
        /*0x7312010*/ float get_TotalNativeMemoryMB();
        /*0x7312018*/ float get_TotalMemoryMB();
        /*0x7312020*/ float get_CurrentNativeMemoryMB();
        /*0x7312028*/ float get_CurrentMemoryMB();
        /*0x7312030*/ float get_MaxNativeMemoryMB();
        /*0x7312038*/ float get_MaxMemoryMB();
        /*0x7312040*/ float get_MinNativeMemoryMB();
        /*0x7312048*/ float get_MinMemoryMB();
        /*0x7312050*/ float get_AverageNativeMemoryMB();
        /*0x7312058*/ float get_AverageMemoryMB();
        /*0x7312060*/ float get_CurrentMonoHeapSizeMB();
        /*0x7312068*/ float get_MaxMonoHeapSizeMB();
        /*0x7312070*/ float get_CurrentMonoUsedSizeMB();
        /*0x7312078*/ float get_MaxMonoUsedSizeMB();
        /*0x7312080*/ float get_MinMonoUsedSizeMB();
        /*0x7312088*/ float get_AverageMonoUsedSizeMB();
        /*0x7312090*/ bool get_IsProfiling();
        /*0x7312098*/ NoaDebugger.NoaProfiler.MemoryProfilingType get_ProfilingType();
        /*0x73120a0*/ NoaDebugger.RingBuffer<System.Single[]> get_CurrentMemoryHistory();
        /*0x73120a8*/ bool get_IsGraphShowing();
        /*0x73120b0*/ bool get_IsViewHyphen();
        /*0x73120b8*/ bool get_IsValid();
    }

    class NoaProfiler
    {
        static /*0x73121d8*/ void SetMemoryProfilingType(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
        static /*0x73122a4*/ NoaDebugger.ProfilerInfo get_ProfilerInfo();
        static /*0x7312388*/ NoaDebugger.FpsInfo get_LatestFpsInfo();
        static /*0x7312454*/ NoaDebugger.MemoryInfo get_LatestMemoryInfo();
        static /*0x7312520*/ NoaDebugger.RenderingInfo get_LatestRenderingInfo();
        static /*0x73125ec*/ NoaDebugger.BatteryInfo get_LatestBatteryInfo();
        static /*0x73126b8*/ NoaDebugger.ThermalInfo get_LatestThermalInfo();
        static /*0x7312784*/ bool get_IsFpsProfiling();
        static /*0x7312850*/ void set_IsFpsProfiling(bool value);
        static /*0x7312924*/ bool get_IsMemoryProfiling();
        static /*0x73129f0*/ void set_IsMemoryProfiling(bool value);
        static /*0x7312ac4*/ float get_TotalNativeMemoryMB();
        static /*0x7312b90*/ void set_TotalNativeMemoryMB(float value);
        static /*0x7312c6c*/ float get_TotalMemoryMB();
        static /*0x7312c70*/ void set_TotalMemoryMB(float value);
        static /*0x7312c74*/ bool get_IsRenderingProfiling();
        static /*0x7312d40*/ void set_IsRenderingProfiling(bool value);
        static /*0x7312e14*/ bool get_IsBatteryProfiling();
        static /*0x7312ee0*/ void set_IsBatteryProfiling(bool value);
        static /*0x7312fb4*/ bool get_IsThermalProfiling();
        static /*0x7313080*/ void set_IsThermalProfiling(bool value);
        static /*0x7313154*/ System.Func<bool> get_OnGcCollect();
        static /*0x7313210*/ void set_OnGcCollect(System.Func<bool> value);
        static /*0x7313364*/ System.Func<bool> get_OnUnloadAssets();
        static /*0x7313420*/ void set_OnUnloadAssets(System.Func<bool> value);
        static /*0x73122a8*/ NoaDebugger.ProfilerInfo _GetProfilerInfo();
        static /*0x731238c*/ NoaDebugger.FpsInfo _GetLatestFpsInfo();
        static /*0x7312788*/ bool _IsFpsProfiling();
        static /*0x7312858*/ void _ChangeFpsProfiling(bool isProfiling);
        static /*0x7312458*/ NoaDebugger.MemoryInfo _GetLatestMemoryInfo();
        static /*0x7312928*/ bool _IsMemoryProfiling();
        static /*0x73129f8*/ void _ChangeMemoryProfiling(bool isProfiling);
        static /*0x7312ac8*/ float _GetTotalNativeMemoryMB();
        static /*0x7312b94*/ void _SetTotalNativeMemoryMB(float totalMemoryMB);
        static /*0x7312524*/ NoaDebugger.RenderingInfo _GetLatestRenderingInfo();
        static /*0x7312c78*/ bool _IsRenderingProfiling();
        static /*0x7312d48*/ void _ChangeRenderingProfiling(bool isProfiling);
        static /*0x73125f0*/ NoaDebugger.BatteryInfo _GetLatestBatteryInfo();
        static /*0x7312e18*/ bool _IsBatteryProfiling();
        static /*0x7312ee8*/ void _ChangeBatteryProfiling(bool isProfiling);
        static /*0x73126bc*/ NoaDebugger.ThermalInfo _GetLatestThermalInfo();
        static /*0x7312fb8*/ bool _IsThermalProfiling();
        static /*0x7313088*/ void _ChangeThermalProfiling(bool isProfiling);
        /*0x7313574*/ NoaProfiler();

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

        /*0x73135cc*/ ProfilerInfo(NoaDebugger.ProfilerPresenter presenter);
        /*0x731357c*/ void set_FpsInfo(NoaDebugger.FpsInfo value);
        /*0x7313584*/ NoaDebugger.FpsInfo get_FpsInfo();
        /*0x731358c*/ void set_MemoryInfo(NoaDebugger.MemoryInfo value);
        /*0x7313594*/ NoaDebugger.MemoryInfo get_MemoryInfo();
        /*0x731359c*/ void set_RenderingInfo(NoaDebugger.RenderingInfo value);
        /*0x73135a4*/ NoaDebugger.RenderingInfo get_RenderingInfo();
        /*0x73135ac*/ void set_BatteryInfo(NoaDebugger.BatteryInfo value);
        /*0x73135b4*/ NoaDebugger.BatteryInfo get_BatteryInfo();
        /*0x73135bc*/ void set_ThermalInfo(NoaDebugger.ThermalInfo value);
        /*0x73135c4*/ NoaDebugger.ThermalInfo get_ThermalInfo();
    }

    class ProfilerSnapshotData
    {
        /*0x10*/ NoaDebugger.FpsUnchangingInfo <FpsInfo>k__BackingField;
        /*0x18*/ NoaDebugger.MemoryUnchangingInfo <MemoryInfo>k__BackingField;
        /*0x20*/ NoaDebugger.RenderingUnchangingInfo <RenderingInfo>k__BackingField;
        /*0x28*/ NoaDebugger.BatteryUnchangingInfo <BatteryInfo>k__BackingField;
        /*0x30*/ NoaDebugger.ThermalUnchangingInfo <ThermalInfo>k__BackingField;

        /*0x7313694*/ ProfilerSnapshotData(NoaDebugger.ProfilerPresenter profiler);
        /*0x731366c*/ NoaDebugger.FpsUnchangingInfo get_FpsInfo();
        /*0x7313674*/ NoaDebugger.MemoryUnchangingInfo get_MemoryInfo();
        /*0x731367c*/ NoaDebugger.RenderingUnchangingInfo get_RenderingInfo();
        /*0x7313684*/ NoaDebugger.BatteryUnchangingInfo get_BatteryInfo();
        /*0x731368c*/ NoaDebugger.ThermalUnchangingInfo get_ThermalInfo();
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

        /*0x73138bc*/ RenderingInfo();
        /*0x7313770*/ void set_CurrentSetPassCalls(long value);
        /*0x7313778*/ long get_CurrentSetPassCalls();
        /*0x7313780*/ void set_MaxSetPassCalls(long value);
        /*0x7313788*/ long get_MaxSetPassCalls();
        /*0x7313790*/ void set_MaxSetPassCallsStr(string value);
        /*0x7313798*/ string get_MaxSetPassCallsStr();
        /*0x73137a0*/ void set_CurrentDrawCalls(long value);
        /*0x73137a8*/ long get_CurrentDrawCalls();
        /*0x73137b0*/ void set_MaxDrawCalls(long value);
        /*0x73137b8*/ long get_MaxDrawCalls();
        /*0x73137c0*/ void set_MaxDrawCallsStr(string value);
        /*0x73137c8*/ string get_MaxDrawCallsStr();
        /*0x73137d0*/ void set_CurrentBatches(long value);
        /*0x73137d8*/ long get_CurrentBatches();
        /*0x73137e0*/ void set_MaxBatches(long value);
        /*0x73137e8*/ long get_MaxBatches();
        /*0x73137f0*/ void set_MaxBatchesStr(string value);
        /*0x73137f8*/ string get_MaxBatchesStr();
        /*0x7313800*/ void set_CurrentTriangles(long value);
        /*0x7313808*/ long get_CurrentTriangles();
        /*0x7313810*/ void set_MaxTriangles(long value);
        /*0x7313818*/ long get_MaxTriangles();
        /*0x7313820*/ void set_MaxTrianglesStr(string value);
        /*0x7313828*/ string get_MaxTrianglesStr();
        /*0x7313830*/ void set_CurrentVertices(long value);
        /*0x7313838*/ long get_CurrentVertices();
        /*0x7313840*/ void set_MaxVertices(long value);
        /*0x7313848*/ long get_MaxVertices();
        /*0x7313850*/ void set_MaxVerticesStr(string value);
        /*0x7313858*/ string get_MaxVerticesStr();
        /*0x7313860*/ void set_IsProfiling(bool value);
        /*0x731386c*/ bool get_IsProfiling();
        /*0x7313874*/ void set_CurrentValueHistory(NoaDebugger.RingBuffer<System.Single[]> value);
        /*0x731387c*/ NoaDebugger.RingBuffer<System.Single[]> get_CurrentValueHistory();
        /*0x7313884*/ void set_GraphTarget(NoaDebugger.RenderingGraphTarget value);
        /*0x731388c*/ NoaDebugger.RenderingGraphTarget get_GraphTarget();
        /*0x7313894*/ void set_IsGraphShowing(bool value);
        /*0x73138a0*/ bool get_IsGraphShowing();
        /*0x73138a8*/ void set_IsStartProfiling(bool value);
        /*0x73138b4*/ bool get_IsStartProfiling();
        /*0x7313b54*/ void ResetProfiledValue();
        /*0x7313c18*/ void RefreshCurrent(long currentSetPassCalls, long currentDrawCalls, long currentBatches, long currentTriangles, long currentVertices);
        /*0x7313e78*/ void StartProfiling();
        /*0x7313e84*/ void ToggleProfiling(bool isProfiling);
        /*0x7313e90*/ void ToggleGraphShowing(bool isShowing);
        /*0x7313efc*/ void SwitchGraphTarget(NoaDebugger.RenderingGraphTarget target);
        /*0x7313974*/ void _InitializeHistoryBuffer();
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

        /*0x7313fcc*/ RenderingUnchangingInfo(NoaDebugger.RenderingInfo info);
        /*0x7313f2c*/ long get_CurrentSetPassCalls();
        /*0x7313f34*/ long get_MaxSetPassCalls();
        /*0x7313f3c*/ string get_MaxSetPassCallsStr();
        /*0x7313f44*/ long get_CurrentDrawCalls();
        /*0x7313f4c*/ long get_MaxDrawCalls();
        /*0x7313f54*/ string get_MaxDrawCallsStr();
        /*0x7313f5c*/ long get_CurrentBatches();
        /*0x7313f64*/ long get_MaxBatches();
        /*0x7313f6c*/ string get_MaxBatchesStr();
        /*0x7313f74*/ long get_CurrentTriangles();
        /*0x7313f7c*/ long get_MaxTriangles();
        /*0x7313f84*/ string get_MaxTrianglesStr();
        /*0x7313f8c*/ long get_CurrentVertices();
        /*0x7313f94*/ long get_MaxVertices();
        /*0x7313f9c*/ string get_MaxVerticesStr();
        /*0x7313fa4*/ bool get_IsProfiling();
        /*0x7313fac*/ NoaDebugger.RingBuffer<System.Single[]> get_CurrentValueHistory();
        /*0x7313fb4*/ NoaDebugger.RenderingGraphTarget get_GraphTarget();
        /*0x7313fbc*/ bool get_IsGraphShowing();
        /*0x7313fc4*/ bool get_IsViewHyphen();
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

        /*0x73141c0*/ ThermalInfo();
        /*0x73140bc*/ void set_CurrentTemperature(float value);
        /*0x73140c4*/ float get_CurrentTemperature();
        /*0x73140cc*/ void set_CurrentThermalStatus(NoaDebugger.ThermalStatus value);
        /*0x73140d4*/ NoaDebugger.ThermalStatus get_CurrentThermalStatus();
        /*0x73140dc*/ void set_MaxTemperature(float value);
        /*0x73140e4*/ float get_MaxTemperature();
        /*0x73140ec*/ void set_MaxThermalStatus(NoaDebugger.ThermalStatus value);
        /*0x73140f4*/ NoaDebugger.ThermalStatus get_MaxThermalStatus();
        /*0x73140fc*/ void set_MinTemperature(float value);
        /*0x7314104*/ float get_MinTemperature();
        /*0x731410c*/ void set_MinThermalStatus(NoaDebugger.ThermalStatus value);
        /*0x7314114*/ NoaDebugger.ThermalStatus get_MinThermalStatus();
        /*0x731411c*/ void set_AverageTemperature(float value);
        /*0x7314124*/ float get_AverageTemperature();
        /*0x731412c*/ void set_IsProfiling(bool value);
        /*0x7314138*/ bool get_IsProfiling();
        /*0x7314140*/ void set_IsStartProfiling(bool value);
        /*0x731414c*/ bool get_IsStartProfiling();
        /*0x7314154*/ void RefreshTemperature(float currentTemperature, float averageTemperature);
        /*0x7314180*/ void RefreshThermalStatus(NoaDebugger.ThermalStatus currentStatus);
        /*0x73141a8*/ void StartProfiling();
        /*0x73141b4*/ void SetIsProfiling(bool isProfiling);
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

        static /*0x7314304*/ string ConvertThermalStatusText(NoaDebugger.ThermalStatus status);
        /*0x7314230*/ ThermalUnchangingInfo(NoaDebugger.ThermalInfo info);
        /*0x73141e8*/ float get_CurrentTemperature();
        /*0x73141f0*/ NoaDebugger.ThermalStatus get_CurrentThermalStatus();
        /*0x73141f8*/ float get_MaxTemperature();
        /*0x7314200*/ NoaDebugger.ThermalStatus get_MaxThermalStatus();
        /*0x7314208*/ float get_MinTemperature();
        /*0x7314210*/ NoaDebugger.ThermalStatus get_MinThermalStatus();
        /*0x7314218*/ float get_AverageTemperature();
        /*0x7314220*/ bool get_IsProfiling();
        /*0x7314228*/ bool get_IsViewHyphen();
    }

    class NoaSnapshot
    {
        static /*0x7314394*/ System.Collections.Generic.List<NoaDebugger.SnapshotLogRecordInformation> get_LogList();
        static /*0x7314460*/ UnityEngine.Events.UnityAction<NoaDebugger.SnapshotLogRecordInformation, string> get_OnLogCopied();
        static /*0x731451c*/ void set_OnLogCopied(UnityEngine.Events.UnityAction<NoaDebugger.SnapshotLogRecordInformation, string> value);
        static /*0x7314670*/ System.Func<string, string, bool> get_OnLogDownload();
        static /*0x731472c*/ void set_OnLogDownload(System.Func<string, string, bool> value);
        static /*0x7314880*/ void ClearLogsAndTimer();
        static /*0x7314944*/ void CaptureLog(string label, System.Nullable<NoaDebugger.NoaSnapshot.BgColor> backgroundColor, bool hasNoaProfilerInfo, System.Collections.Generic.Dictionary<string, NoaDebugger.NoaSnapshotCategory> additionalInfo);
        static /*0x7314398*/ System.Collections.Generic.List<NoaDebugger.SnapshotLogRecordInformation> _GetLogList();
        /*0x7314cdc*/ NoaSnapshot();

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

        /*0x7314cec*/ NoaSnapshotCategory();
        /*0x7314ce4*/ System.Collections.Generic.List<NoaDebugger.NoaSnapshotCategoryItem> get_CategoryItems();
        /*0x7314d74*/ void Add(NoaDebugger.NoaSnapshotCategoryItem item);

        class <>c__DisplayClass4_0
        {
            /*0x10*/ NoaDebugger.NoaSnapshotCategoryItem item;

            /*0x7314f0c*/ <>c__DisplayClass4_0();
            /*0x7314f14*/ bool <Add>b__0(NoaDebugger.NoaSnapshotCategoryItem categoryItem);
        }
    }

    class NoaSnapshotCategoryItem
    {
        /*0x10*/ string <Key>k__BackingField;
        /*0x18*/ string <Value>k__BackingField;
        /*0x20*/ NoaDebugger.NoaSnapshot.FontColor <Color>k__BackingField;

        /*0x7314f3c*/ NoaSnapshotCategoryItem(string key, string value, NoaDebugger.NoaSnapshot.FontColor color);
        /*0x7314f94*/ string get_Key();
        /*0x7314f9c*/ string get_Value();
        /*0x7314fa4*/ NoaDebugger.NoaSnapshot.FontColor get_Color();
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

        /*0x731506c*/ SnapshotLogRecordInformation(int id, string label, System.TimeSpan time, System.TimeSpan elapsedTime, NoaDebugger.ProfilerSnapshotData snapshotData, System.Nullable<UnityEngine.Color> backgroundColor, System.Collections.Generic.Dictionary<string, NoaDebugger.NoaSnapshotCategory> additionalInfo);
        /*0x7314fac*/ int get_Id();
        /*0x7314fb4*/ void set_Id(int value);
        /*0x7314fbc*/ string get_Label();
        /*0x7314fc4*/ void set_Label(string value);
        /*0x7314fcc*/ System.TimeSpan get_Time();
        /*0x7314fd4*/ void set_Time(System.TimeSpan value);
        /*0x7314fdc*/ System.TimeSpan get_ElapsedTime();
        /*0x7314fe4*/ void set_ElapsedTime(System.TimeSpan value);
        /*0x7314fec*/ bool get_IsHighlighted();
        /*0x7314ff4*/ void set_IsHighlighted(bool value);
        /*0x7315000*/ bool get_IsSelected();
        /*0x7315008*/ void set_IsSelected(bool value);
        /*0x7315014*/ NoaDebugger.SnapshotModel.ToggleState get_ToggleState();
        /*0x731501c*/ void set_ToggleState(NoaDebugger.SnapshotModel.ToggleState value);
        /*0x7315024*/ NoaDebugger.ProfilerSnapshotData get_Snapshot();
        /*0x731502c*/ void set_Snapshot(NoaDebugger.ProfilerSnapshotData value);
        /*0x7315034*/ System.Nullable<UnityEngine.Color> get_BackgroundColor();
        /*0x7315048*/ void set_BackgroundColor(System.Nullable<UnityEngine.Color> value);
        /*0x731505c*/ System.Collections.Generic.Dictionary<string, NoaDebugger.NoaSnapshotCategory> get_AdditionalInfo();
        /*0x7315064*/ void set_AdditionalInfo(System.Collections.Generic.Dictionary<string, NoaDebugger.NoaSnapshotCategory> value);
        /*0x7315104*/ void SetHighlighted(bool highlighted);
        /*0x7315110*/ void SetSelected(bool selected);
        /*0x731511c*/ void SetToggleState(NoaDebugger.SnapshotModel.ToggleState state);
        /*0x7315124*/ void SetLabel(string text);
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

        /*0x3815ed0*/ RingBuffer(int capacity);
        /*0x3814574*/ int get_Count();
        /*0x3815ed0*/ void set_Count(int value);
        /*0x3814574*/ int get_Capacity();
        /*0x3813ffc*/ bool get_IsEmpty();
        /*0x3813ffc*/ bool get_IsFull();
        /*0x3814574*/ int get_Top();
        /*0x3815ed0*/ void set_Top(int value);
        /*0x3814574*/ int get_Tail();
        /*0x3815ed0*/ void set_Tail(int value);
        /*0x3910ae8*/ void Append(T element);
        /*0x38159dc*/ void Clear();
        /*0x3815ed0*/ void Remove(int index);
        /*0x3910ae8*/ T At(int index);
        /*0x38145a0*/ int NextPosition(int current);
        /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        /*0x38148bc*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();

        struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ NoaDebugger.RingBuffer<T> _target;
            /*0x0*/ int _current;
            /*0x0*/ int _count;

            /*0x3816710*/ Enumerator(NoaDebugger.RingBuffer<T> target);
            /*0x38159dc*/ void Dispose();
            /*0x3813ffc*/ bool MoveNext();
            /*0x38159dc*/ void Reset();
            /*0x3910ae8*/ T get_Current();
            /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    struct SemanticVersion : System.IComparable<NoaDebugger.SemanticVersion>
    {
        static string VERSION_PATTERN = "\d+(\.\d+){0,2}";
        static int MAX_DIGIT_COUNT = 3;
        /*0x10*/ int major;
        /*0x14*/ int minor;
        /*0x18*/ int patch;

        static /*0x731512c*/ string ExtractSemanticVersionString(string input);
        static /*0x73151b0*/ NoaDebugger.SemanticVersion Parse(string input);
        static /*0x7315340*/ bool op_Equality(NoaDebugger.SemanticVersion one, NoaDebugger.SemanticVersion another);
        static /*0x7315374*/ bool op_Inequality(NoaDebugger.SemanticVersion one, NoaDebugger.SemanticVersion another);
        static /*0x73153a0*/ bool op_LessThan(NoaDebugger.SemanticVersion one, NoaDebugger.SemanticVersion another);
        static /*0x73153dc*/ bool op_GreaterThan(NoaDebugger.SemanticVersion one, NoaDebugger.SemanticVersion another);
        static /*0x7315418*/ bool op_LessThanOrEqual(NoaDebugger.SemanticVersion one, NoaDebugger.SemanticVersion another);
        static /*0x7315454*/ bool op_GreaterThanOrEqual(NoaDebugger.SemanticVersion one, NoaDebugger.SemanticVersion another);
        /*0x73152f8*/ int CompareTo(NoaDebugger.SemanticVersion another);
        /*0x7315490*/ int GetHashCode();
        /*0x7315534*/ bool Equals(object another);
    }

    class ArrayParser : NoaDebugger.IKeyValueParser
    {
        /*0x10*/ string _key;
        /*0x18*/ string[] _values;

        /*0x7315660*/ ArrayParser(string key, string[] values);
        /*0x73156a4*/ string ToJsonString();
    }

    class JsonObjectParser : NoaDebugger.IKeyValueParser
    {
        /*0x10*/ string _key;
        /*0x18*/ string _json;

        /*0x7315a78*/ JsonObjectParser(string key, string json);
        /*0x7315abc*/ string ToJsonString();
    }

    class KeyObjectParser : NoaDebugger.IKeyValueParser
    {
        /*0x10*/ string _key;
        /*0x18*/ NoaDebugger.IKeyValueParser[] _elements;

        static /*0x3910ae8*/ NoaDebugger.KeyObjectParser CreateFromClass<T>(T viewInfo, string name);
        /*0x7315b78*/ KeyObjectParser(string key, NoaDebugger.IKeyValueParser[] elements);
        /*0x7315bbc*/ string ToJsonString();
    }

    class KeyValueArrayParser : NoaDebugger.IKeyValueParser
    {
        /*0x10*/ string _key;
        /*0x18*/ NoaDebugger.KeyValueArrayParser.ObjectParser[] _values;

        /*0x7315da8*/ KeyValueArrayParser(string key, NoaDebugger.KeyValueArrayParser.ObjectParser[] parser);
        /*0x7315dec*/ string ToJsonString();

        class ObjectParser
        {
            /*0x10*/ NoaDebugger.IKeyValueParser[] _values;

            /*0x7316124*/ ObjectParser(NoaDebugger.IKeyValueParser[] values);
            /*0x7315f70*/ string ToJsonString();
        }
    }

    class KeyValueParser : NoaDebugger.IKeyValueParser
    {
        /*0x10*/ string _key;
        /*0x18*/ string _value;

        /*0x7316154*/ KeyValueParser(string key, string value);
        /*0x7316198*/ string ToJsonString();
    }

    interface IKeyValueParser
    {
        /*0x38148bc*/ string ToJsonString();
    }

    class KeyValueSerializer
    {
        /*0x10*/ string _key;
        /*0x18*/ NoaDebugger.IKeyValueParser[] _parsers;

        static /*0x7316570*/ string SerializeToJson(NoaDebugger.KeyValueSerializer[] targetDatas);
        static /*0x7315918*/ System.Text.StringBuilder InsertTabs(System.Text.StringBuilder builder, string prefix, string suffix);
        static /*0x7315890*/ System.Text.StringBuilder AppendAndJoinJson(System.Text.StringBuilder builder, string[] targetStrings);
        static /*0x73166b4*/ NoaDebugger.KeyValueSerializer CreateSubData(string label, NoaDebugger.IKeyValueParser[] addValues);
        static /*0x3910ae8*/ NoaDebugger.KeyValueSerializer CreateFromClass<T>(T viewInfo, string name);
        /*0x7316340*/ KeyValueSerializer(string key, NoaDebugger.IKeyValueParser[] parsers);
        /*0x7316384*/ string SerializeToJson();
    }

    interface INoaUIElementView
    {
        /*0x38148bc*/ NoaDebugger.INoaUIElement get_Element();
        /*0x38148bc*/ UnityEngine.GameObject get_GameObject();
        /*0x3813ffc*/ bool get_IsDisposed();
    }

    class NoaUIButtonElementView : NoaDebugger.NoaUIElementViewBase<NoaDebugger.NoaUIButtonElement>
    {
        /*0x30*/ UnityEngine.UI.Button _button;
        /*0x38*/ TMPro.TextMeshProUGUI _labelText;

        /*0x7316960*/ NoaUIButtonElementView();
        /*0x731687c*/ void OnInitialize(NoaDebugger.NoaUIButtonElement element);
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

        /*0x7318af8*/ NoaUIElementManager();
        /*0x73169a8*/ UnityEngine.Transform get_RootTransform();
        /*0x73169b0*/ NoaDebugger.INoaUIElementView[] get_RegisteredElements();
        /*0x7316a88*/ void ResetRootRectSize();
        /*0x7316b7c*/ void OnRectTransformDimensionsChange();
        /*0x7316b80*/ void Update();
        /*0x7316b84*/ void _CleanUpRegisteredElements();
        /*0x7316f50*/ void RegisterUIElement(NoaDebugger.INoaUIElement element);
        /*0x73178d0*/ void UnregisterUIElement(string key);
        /*0x7317c00*/ void UnregisterAllUIElements();
        /*0x7317e38*/ bool IsUIElementRegistered(string key);
        /*0x7317ee8*/ void SetUIElementVisibility(string key, bool visible);
        /*0x731807c*/ bool IsUIElementVisible(string key);
        /*0x73181a4*/ void SetVerticalAlignment(NoaDebugger.AnchorType anchorType);
        /*0x7318208*/ void SetHorizontalAlignment(NoaDebugger.AnchorType anchorType);
        /*0x3814964*/ System.Collections.IEnumerator _SetAlignment<T>(NoaDebugger.AnchorType anchorType);
        /*0x7317b10*/ void _CreateUIElement(NoaDebugger.INoaUIElement element);
        /*0x731826c*/ NoaDebugger.INoaUIElementView _CreatePrefabForElementView(NoaDebugger.INoaUIElement element);
        /*0x7317324*/ void _InitializeUIElement(NoaDebugger.INoaUIElement element, NoaDebugger.INoaUIElementView elementView);
        /*0x731857c*/ void _SetParentLayoutComponents(NoaDebugger.INoaUIElement element);
        /*0x7318504*/ UnityEngine.Transform _GetAnchorTransform(NoaDebugger.AnchorType anchorType);
        /*0x7318850*/ void OnDestroy();

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

            /*0x3815ed0*/ <_SetAlignment>d__32(int <>1__state);
            /*0x38159dc*/ void System.IDisposable.Dispose();
            /*0x3813ffc*/ bool MoveNext();
            /*0x38148bc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
            /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class NoaUIElementViewBase<T> : UnityEngine.MonoBehaviour, NoaDebugger.INoaUIElementView
    {
        /*0x0*/ T _element;
        /*0x0*/ bool _isDisposed;

        /*0x38159dc*/ NoaUIElementViewBase();
        /*0x38148bc*/ NoaDebugger.INoaUIElement get_Element();
        /*0x38148bc*/ UnityEngine.GameObject get_GameObject();
        /*0x3813ffc*/ bool get_IsDisposed();
        /*0x3910ae8*/ void Initialize(T element);
        /*0x38159dc*/ void Update();
        /*0x38159dc*/ void OnDestroy();
        /*0x3910ae8*/ void OnInitialize(T element);
        /*0x38159dc*/ void OnUpdate();
        /*0x38159dc*/ void Dispose();
    }

    class NoaUIObjectElementView : NoaDebugger.NoaUIElementViewBase<NoaDebugger.NoaUIObjectElement>
    {
        /*0x30*/ UnityEngine.GameObject _gameObject;

        /*0x7318f58*/ NoaUIObjectElementView();
        /*0x7318bd4*/ void OnInitialize(NoaDebugger.NoaUIObjectElement element);
        /*0x7318e24*/ void OnUpdate();
        /*0x7318ec4*/ void Dispose();
    }

    class NoaUITextElementView : NoaDebugger.NoaUIElementViewBase<NoaDebugger.NoaUITextElement>
    {
        /*0x30*/ TMPro.TextMeshProUGUI _textComponent;
        /*0x38*/ float _nextUpdateTime;

        /*0x73190f0*/ NoaUITextElementView();
        /*0x7318fa0*/ void OnInitialize(NoaDebugger.NoaUITextElement element);
        /*0x73190a4*/ void OnUpdate();
        /*0x7318fc0*/ void _UpdateValue();
    }

    class BlockableScrollRect : UnityEngine.UI.ScrollRect
    {
        /*0x130*/ bool _canMoveScroll;

        /*0x7319168*/ BlockableScrollRect();
        /*0x7319138*/ void _Init();
        /*0x7319144*/ void ResetScrollPosition();
        /*0x7319154*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
    }

    class ChartLegend : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.ChartLegendElement _elementTemplate;
        /*0x28*/ System.Collections.Generic.List<NoaDebugger.ChartLegendElement> _elements;

        /*0x7319548*/ ChartLegend();
        /*0x7319178*/ void Awake();
        /*0x73191a4*/ int AddElement(string text, UnityEngine.Color color);
        /*0x73193a0*/ void UpdateText(int index, string text);
        /*0x7319424*/ void UpdateColor(int index, UnityEngine.Color color);
        /*0x73194c8*/ void ToggleShow(int index, bool shows);
    }

    class ChartLegendElement : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.NoaDebuggerText _label;
        /*0x28*/ UnityEngine.UI.Image _icon;

        /*0x7319644*/ ChartLegendElement();
        /*0x73195d0*/ void Awake();
        /*0x73195d4*/ string get_Text();
        /*0x7319358*/ void set_Text(string value);
        /*0x73195f8*/ UnityEngine.Color get_Color();
        /*0x731937c*/ void set_Color(UnityEngine.Color value);
        /*0x731961c*/ void OnDestroy();
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

        static /*0x731a3f8*/ ContextPanelView();
        /*0x731a3e4*/ ContextPanelView();
        /*0x731964c*/ void set_KeyContextColor(UnityEngine.Color value);
        /*0x7319658*/ void set_ValueContextColor(UnityEngine.Color value);
        /*0x7319664*/ void Start();
        /*0x731969c*/ void SetText(string header, System.Collections.Generic.Dictionary<string, string> context, string prefix, string suffix, string missingValue);
        /*0x7319724*/ string _ConvertContext(System.Collections.Generic.Dictionary<string, string> contextList, string prefix, string suffix, string missingValue);
        /*0x731a1cc*/ string _GetWrapText(string text, float width);
        /*0x7319eb8*/ string _GetSubstringTextByWidth(string text, float targetWidth, ref int endIndex);
        /*0x731a168*/ string _ConvertLabel(string label, string missingValue);
        /*0x731a320*/ bool _IsAcquireLabel(string label);
        /*0x731a390*/ void SetMinWidthForLine(float width);
        /*0x731a3b4*/ void SetActiveLine(bool active);
    }

    class DisableButtonBase : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.Events.UnityEvent _onClick;
        /*0x28*/ UnityEngine.UI.Button _component;

        /*0x731a720*/ DisableButtonBase();
        /*0x731a490*/ bool get_Interactable();
        /*0x731a544*/ void set_Interactable(bool value);
        /*0x731a610*/ void Awake();
        /*0x731a6e4*/ void _OnClick();
        /*0x38159dc*/ void _Refresh();
        /*0x731a6f8*/ void OnDestroy();
    }

    class DisableColorButton : NoaDebugger.DisableButtonBase
    {
        /*0x30*/ UnityEngine.Color _enable;
        /*0x40*/ UnityEngine.Color _disable;
        /*0x50*/ UnityEngine.UI.Graphic[] _targetGraphics;

        /*0x731a808*/ DisableColorButton();
        /*0x731a728*/ void Awake();
        /*0x731a740*/ void _Refresh();
    }

    class DisableObjectButton : NoaDebugger.DisableButtonBase
    {
        /*0x30*/ UnityEngine.GameObject _enable;
        /*0x38*/ UnityEngine.GameObject _disable;

        /*0x731a8d8*/ DisableObjectButton();
        /*0x731a87c*/ void Awake();
        /*0x731a880*/ void _Refresh();
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

        static /*0x731af34*/ DraggableNumericInputSlider();
        /*0x731ae20*/ DraggableNumericInputSlider();
        /*0x731a8e0*/ void Initialize(NoaDebugger.BlockableScrollRect parentScroll, NoaDebugger.NoaDebuggerScrollableInputComponent numericInput);
        /*0x731ab60*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731ab9c*/ void OnButtonUp();
        /*0x731ac30*/ void Update();
        /*0x731ad88*/ void _OnInputModeChanged(bool isInputMode);
        /*0x731ad00*/ void _CheckDragDirection(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731adb4*/ bool _IsNeedCheckDirection(float distance);

        enum DragState
        {
            None = 0,
            PointerDown = 1,
            HorizontalDrag = 2,
            VerticalDrag = 3,
        }

        class DragSliderEvent : UnityEngine.Events.UnityEvent<float>
        {
            /*0x731aeec*/ DragSliderEvent();
        }
    }

    class GaugeChart : UnityEngine.EventSystems.UIBehaviour
    {
        /*0x20*/ UnityEngine.RectTransform _gaugeMeter;
        /*0x28*/ UnityEngine.RectTransform _gaugeFrame;
        /*0x30*/ float _maxValue;
        /*0x34*/ float _value;

        /*0x731b128*/ GaugeChart();
        /*0x731af80*/ float get_MaxValue();
        /*0x731af88*/ void set_MaxValue(float value);
        /*0x731b07c*/ float get_Value();
        /*0x731b084*/ void set_Value(float value);
        /*0x731b120*/ void Awake();
        /*0x731b124*/ void OnRectTransformDimensionsChange();
        /*0x731b024*/ void _UpdateGaugeTransform();
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

        /*0x731b6dc*/ LongPressButton();
        /*0x731b130*/ void Awake();
        /*0x731b2d0*/ void OnEnable();
        /*0x731b304*/ void _OnClick();
        /*0x731b320*/ void _OnReset();
        /*0x731b324*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731b374*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731b3e4*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731b2a4*/ void SetActionIntervalSettings(NoaDebugger.LongPressButtonActionIntervalSettings setting);
        /*0x731b488*/ void ResetButtonState();
        /*0x731b49c*/ void Update();
        /*0x731b590*/ bool _IsOverThresholdTime(float thresholdTime);
        /*0x731b5c4*/ void _InvokeLongPressAction();
        /*0x731b5f0*/ void SetInteractable(bool isInteractable);
        /*0x731b6c8*/ bool IsLongPress();

        class DisableTarget
        {
            /*0x10*/ UnityEngine.UI.Image _image;
            /*0x18*/ UnityEngine.Color _normalColor;
            /*0x28*/ UnityEngine.Color _disabledColor;

            /*0x731b6e4*/ DisableTarget();
            /*0x731b668*/ void SetColor(bool isEnable);
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
            /*0x731b6ec*/ PointerExitEvent();
        }

        class ButtonResetEvent : UnityEngine.Events.UnityEvent
        {
            /*0x731b734*/ ButtonResetEvent();
        }
    }

    class LongPressButtonActionIntervalSettings
    {
        /*0x10*/ bool _isNeedSpeedUp;
        /*0x14*/ float _firstInterval;
        /*0x18*/ float _secondInterval;

        /*0x731b234*/ LongPressButtonActionIntervalSettings();
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

        /*0x731b90c*/ LongPressToggleColorButton();
        /*0x731b73c*/ void Awake();
        /*0x731b848*/ void _OnReset();
        /*0x731b878*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731b884*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731b8b8*/ void _OnClick();
        /*0x731b8dc*/ void _InvokeLongPressAction();
        /*0x731b864*/ void _Toggle();
        /*0x731b760*/ void _Refresh();

        class ToggleEvent : UnityEngine.Events.UnityEvent<bool>
        {
            /*0x731b994*/ ToggleEvent();
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

        /*0x731bbd4*/ LongTapButton();
        /*0x731b9dc*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731ba24*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731ba94*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731bb28*/ void Update();

        class PointerExitEvent : UnityEngine.Events.UnityEvent<UnityEngine.EventSystems.PointerEventData>
        {
            /*0x731bbdc*/ PointerExitEvent();
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

        /*0x731c138*/ LongTapToggleColorButton();
        /*0x731bc24*/ void set_IsOn(bool value);
        /*0x731bc30*/ bool get_IsOn();
        /*0x731bc38*/ NoaDebugger.LongTapButton get_LongTapButton();
        /*0x731bce0*/ bool get_Interactable();
        /*0x731bcfc*/ void set_Interactable(bool value);
        /*0x731be24*/ void Awake();
        /*0x731bff4*/ void Init(bool isOn);
        /*0x731c000*/ void Clear();
        /*0x731c05c*/ void _OnPointerDown();
        /*0x731c084*/ void _OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731c0b0*/ void _OnClick();
        /*0x731c0cc*/ void _Toggle();
        /*0x731bd34*/ void _Refresh();

        class ToggleEvent : UnityEngine.Events.UnityEvent<bool>
        {
            /*0x731c21c*/ ToggleEvent();
        }
    }

    class NoaDebuggerInputField : TMPro.TMP_InputField
    {
        /*0x2f8*/ TMPro.TMP_InputField.OnValidateInput _validate;
        /*0x300*/ bool _activateOnPointerDown;
        /*0x308*/ UnityEngine.GameObject _dragTarget;

        /*0x731c9a4*/ NoaDebuggerInputField();
        /*0x731c264*/ void SetActivateOnPointerDown(bool activate);
        /*0x731c270*/ void SetDragTarget(UnityEngine.GameObject dragTarget);
        /*0x731c280*/ void Awake();
        /*0x731c4f4*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731c508*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731c5d4*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731c6e8*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731c7fc*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x731c45c*/ void UseCustomValidation(TMPro.TMP_InputField.OnValidateInput validate);
        /*0x731c910*/ void UseContentType(TMPro.TMP_InputField.ContentType newContentType, TMPro.TMP_InputField.InputType newInputType, UnityEngine.TouchScreenKeyboardType newKeyboardType, TMPro.TMP_InputField.CharacterValidation newCharacterValidation);
        /*0x731c984*/ char _OnValidateInput(string text, int charIndex, char addedChar);

        class <>c
        {
            static /*0x0*/ NoaDebugger.NoaDebuggerInputField.<> <>9;
            static /*0x8*/ UnityEngine.Events.UnityAction<string> <>9__5_0;
            static /*0x10*/ UnityEngine.Events.UnityAction<string> <>9__5_1;

            static /*0x731ca04*/ <>c();
            /*0x731ca6c*/ <>c();
            /*0x731ca74*/ void <Awake>b__5_0(string _);
            /*0x731cac8*/ void <Awake>b__5_1(string _);
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

        /*0x731d054*/ NoaDebuggerScrollableInputComponent();
        /*0x731cb1c*/ bool get_IsInputMode();
        /*0x731cb24*/ string get_Text();
        /*0x731cb40*/ void set_Text(string value);
        /*0x731cb5c*/ TMPro.TMP_Text get_TextComponent();
        /*0x731cb78*/ void set_CharacterLimit(int value);
        /*0x731aab0*/ void add_OnInputModeChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x731aa00*/ void remove_OnInputModeChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x731cb94*/ void Awake();
        /*0x731cdb0*/ void UpdateValidation(TMPro.TMP_InputField.OnValidateInput validate);
        /*0x731cdc8*/ void UpdateContentType(TMPro.TMP_InputField.ContentType contentType, TMPro.TMP_InputField.InputType inputType, UnityEngine.TouchScreenKeyboardType keyboardType, TMPro.TMP_InputField.CharacterValidation characterValidation);
        /*0x731ac0c*/ void Select();
        /*0x731cde0*/ void _OnValueChanged(string text);
        /*0x731ce40*/ void _OnSelect(string text);
        /*0x731cee8*/ void _OnEndEdit(string text);
        /*0x731cec4*/ void _ChangeInputMode(bool isInputMode);
        /*0x731cfe8*/ void _OnDownInputAreaForMobile(UnityEngine.EventSystems.PointerEventData pointerEventData);
        /*0x731d004*/ void _OnClickInputAreaForMobile(UnityEngine.EventSystems.PointerEventData pointerEventData);
    }

    class NoaInputFieldEventConfigurator : UnityEngine.MonoBehaviour
    {
        /*0x20*/ bool _activateOnPointerDown;
        /*0x28*/ UnityEngine.GameObject _dragTarget;
        /*0x30*/ NoaDebugger.NoaDebuggerInputField _inputField;

        /*0x731d0c8*/ NoaInputFieldEventConfigurator();
        /*0x731d05c*/ void Start();
    }

    class ScrollRectHandler : UnityEngine.MonoBehaviour
    {
        /*0x731d1a8*/ ScrollRectHandler();
        /*0x731d0d8*/ void Awake();
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

        /*0x731ef88*/ StackedAreaChart();
        /*0x731d1b0*/ void SetUpdateRulersCallback(System.Action<float, System.Single[], System.String[]> callback);
        /*0x731d1c0*/ void SetValueHistoryBuffer(NoaDebugger.RingBuffer<System.Single[]> buffer);
        /*0x731ddc0*/ void ToggleStacksShown(bool[] shows);
        /*0x731de88*/ void SetStackDisplayAttributesText(int index, string text);
        /*0x731dee8*/ void SetStackDisplayAttributesColor(int index, UnityEngine.Color newColor);
        /*0x731df28*/ void SetStackDisplayAttributesShows(int index, bool shows);
        /*0x731df6c*/ void Awake();
        /*0x731e1dc*/ bool get_CanPopulateMesh();
        /*0x731de6c*/ int get_StackCount();
        /*0x731d364*/ void InitializeVertices();
        /*0x731e2d0*/ void Update();
        /*0x731e448*/ void OnPopulateMesh(UnityEngine.UI.VertexHelper vh);
        /*0x731e558*/ void UpdateVertices();
        /*0x731e4a8*/ void HideRulers();
        /*0x731e264*/ int GetFirstVertexOf(int history, int stack);
        /*0x731eef0*/ float GetHorizontalPositionOf(int history);

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

        /*0x731f020*/ StackedAreaChartRuler();
        /*0x731ef98*/ void Awake();
        /*0x731eff0*/ UnityEngine.RectTransform get_RectTransform();
        /*0x731e400*/ string get_Text();
        /*0x731e424*/ void set_Text(string value);
        /*0x731eff8*/ void OnDestroy();
    }

    class ToggleButtonBase : UnityEngine.MonoBehaviour
    {
        /*0x20*/ bool <IsOn>k__BackingField;
        /*0x28*/ NoaDebugger.ToggleButtonBase.ToggleClickEvent _onClick;
        /*0x30*/ UnityEngine.UI.Button _component;
        /*0x38*/ NoaDebugger.ToggleButtonGroup _group;

        /*0x731f7e4*/ ToggleButtonBase();
        /*0x731f028*/ void set_IsOn(bool value);
        /*0x731f034*/ bool get_IsOn();
        /*0x731f03c*/ bool get_Interactable();
        /*0x731f0f0*/ void set_Interactable(bool value);
        /*0x731f1bc*/ void Awake();
        /*0x731f290*/ void OnEnable();
        /*0x731f3c0*/ void OnDisable();
        /*0x731f49c*/ void Init(bool isOn);
        /*0x731f4b0*/ void Clear();
        /*0x731f514*/ void _Toggle();
        /*0x38159dc*/ void _Refresh();
        /*0x731f7ac*/ void OnDestroy();

        class ToggleClickEvent : UnityEngine.Events.UnityEvent<bool>
        {
            /*0x731f7ec*/ ToggleClickEvent();
        }
    }

    class ToggleButtonGroup : UnityEngine.MonoBehaviour
    {
        /*0x20*/ System.Collections.Generic.List<NoaDebugger.ToggleButtonBase> _toggles;

        /*0x731f834*/ ToggleButtonGroup();
        /*0x731f314*/ void Add(NoaDebugger.ToggleButtonBase toggle);
        /*0x731f444*/ void Remove(NoaDebugger.ToggleButtonBase toggle);
        /*0x731f61c*/ void Select(NoaDebugger.ToggleButtonBase toggle);
    }

    class ToggleColorButton : NoaDebugger.ToggleButtonBase
    {
        /*0x40*/ UnityEngine.Color _off;
        /*0x50*/ UnityEngine.Color _on;
        /*0x60*/ UnityEngine.Color _disable;
        /*0x70*/ bool _isUseDisable;
        /*0x78*/ UnityEngine.UI.Graphic[] _targetGraphics;

        /*0x731f9c4*/ ToggleColorButton();
        /*0x731f8bc*/ void Awake();
        /*0x731f8d4*/ void _Refresh();
    }

    class ToggleObjectButton : NoaDebugger.ToggleButtonBase
    {
        /*0x40*/ UnityEngine.GameObject _off;
        /*0x48*/ UnityEngine.GameObject _on;
        /*0x50*/ UnityEngine.GameObject _disable;

        /*0x731fb74*/ ToggleObjectButton();
        /*0x731fa44*/ void Awake();
        /*0x731fa48*/ void _Refresh();
    }

    class UIReverseComponents
    {
        /*0x10*/ UnityEngine.UI.HorizontalOrVerticalLayoutGroup[] _reverseTargetLayouts;
        /*0x18*/ UnityEngine.GameObject[] _normalArrangementObjects;
        /*0x20*/ UnityEngine.GameObject[] _reverseArrangementObjects;

        /*0x731fc88*/ UIReverseComponents();
        /*0x731fb7c*/ void Alignment(bool isReverse);
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

        /*0x7320534*/ DebugCommandDetailsAreaView();
        /*0x731fc90*/ void _OnValidateUI();
        /*0x731fc94*/ void Init();
        /*0x731fd6c*/ void OnRectTransformDimensionsChange();
        /*0x731ff8c*/ void Show(NoaDebugger.DebugCommand.DebugCommandViewLinker linker);
        /*0x731feec*/ float _GetLineMinWidth();
        /*0x73203b8*/ void Hide();
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

        static /*0x7320a34*/ NoaDebugger.DebugCommand.ICommandPanel _CreateCommandPanel(NoaDebugger.DebugCommand.ICommand type, NoaDebugger.DebugCommandPanel panel, float maxContentWidth);
        /*0x7321148*/ DebugCommandPanel();
        /*0x73205bc*/ NoaDebugger.DebugCommand.CommandScroll get_ParentScroll();
        /*0x73205c4*/ void set_ParentScroll(NoaDebugger.DebugCommand.CommandScroll value);
        /*0x73205cc*/ void Awake();
        /*0x7320690*/ void Init(NoaDebugger.DebugCommand.ICommand command, float maxContentWidth, NoaDebugger.DebugCommand.DetailToggleInfo detailToggleInfo, NoaDebugger.DebugCommand.CommandScroll scrollRect);
        /*0x732084c*/ void _ResetActionActive();
        /*0x73209b0*/ void _SetInteractable(bool interactable);
        /*0x7320b90*/ void _SetDetailInfo(NoaDebugger.DebugCommand.ICommand command, NoaDebugger.DebugCommand.DetailToggleInfo detailToggleInfo);
        /*0x7320cf4*/ void OnUpdateWidth(float maxContentWidth);
        /*0x7320da4*/ void Refresh();
        /*0x7320e48*/ void UpdateData(NoaDebugger.DebugCommand.ICommand command, NoaDebugger.DebugCommand.DetailToggleInfo detailToggleInfo);
        /*0x7320f74*/ void _OnClickDetailToggle(bool isOn);
        /*0x7320ff0*/ void OnDestroy();

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

            /*0x7320f9c*/ CommandPanelVisitor(NoaDebugger.DebugCommandPanel panel, float maxContentWidth);
            /*0x7321150*/ NoaDebugger.DebugCommand.ICommandPanel get_Result();
            /*0x7321158*/ void set_Result(NoaDebugger.DebugCommand.ICommandPanel value);
            /*0x7320fe0*/ bool get_IsSuccess();
            /*0x7321160*/ void Visit(NoaDebugger.DebugCommand.GetOnlyPropertyCommand command);
            /*0x73211d8*/ void Visit(NoaDebugger.DebugCommand.StringPropertyCommand command);
            /*0x7321250*/ void Visit(NoaDebugger.DebugCommand.ShortPropertyCommand command);
            /*0x73212b8*/ void Visit(NoaDebugger.DebugCommand.UShortPropertyCommand command);
            /*0x7321320*/ void Visit(NoaDebugger.DebugCommand.IntPropertyCommand command);
            /*0x7321388*/ void Visit(NoaDebugger.DebugCommand.UIntPropertyCommand command);
            /*0x73213f0*/ void Visit(NoaDebugger.DebugCommand.BytePropertyCommand command);
            /*0x7321458*/ void Visit(NoaDebugger.DebugCommand.SBytePropertyCommand command);
            /*0x73214c0*/ void Visit(NoaDebugger.DebugCommand.LongPropertyCommand command);
            /*0x7321528*/ void Visit(NoaDebugger.DebugCommand.ULongPropertyCommand command);
            /*0x7321590*/ void Visit(NoaDebugger.DebugCommand.CharPropertyCommand command);
            /*0x73215f8*/ void Visit(NoaDebugger.DebugCommand.FloatPropertyCommand command);
            /*0x7321660*/ void Visit(NoaDebugger.DebugCommand.DoublePropertyCommand command);
            /*0x73216c8*/ void Visit(NoaDebugger.DebugCommand.DecimalPropertyCommand command);
            /*0x7321740*/ void Visit(NoaDebugger.DebugCommand.BoolPropertyCommand command);
            /*0x73217a8*/ void Visit(NoaDebugger.DebugCommand.EnumPropertyCommand command);
            /*0x7321820*/ void Visit(NoaDebugger.DebugCommand.MethodCommand command);
            /*0x7321888*/ void Visit(NoaDebugger.DebugCommand.CoroutineCommand command);
            /*0x73218f0*/ void Visit(NoaDebugger.DebugCommand.HandleMethodCommand command);
        }
    }

    class DebugCommandScrollAreaView : NoaDebugger.ViewBase<NoaDebugger.DebugCommand.DebugCommandViewLinker>
    {
        /*0x20*/ NoaDebugger.DebugCommand.CommandScroll _scroll;
        /*0x28*/ UnityEngine.GameObject _noCategoriesLabel;
        /*0x30*/ UnityEngine.GameObject _noCommandsLabel;

        /*0x7321ca4*/ DebugCommandScrollAreaView();
        /*0x7321958*/ void _OnValidateUI();
        /*0x732195c*/ void _Init();
        /*0x7321960*/ void _OnShow(NoaDebugger.DebugCommand.DebugCommandViewLinker linker);
        /*0x7321a90*/ void _UpdateScroll(NoaDebugger.DebugCommand.DebugCommandViewLinker linker);
        /*0x7321af8*/ System.Collections.IEnumerator _WaitSetScrollPosition();
        /*0x7321b8c*/ void ResetScrollPosition();
        /*0x7321bb0*/ void RefreshCommandPanels();
        /*0x7321bcc*/ void AlignmentUI(bool isReverse);
        /*0x7321c48*/ void OnDestroy();

        class <_WaitSetScrollPosition>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.DebugCommandScrollAreaView <>4__this;

            /*0x7321b64*/ <_WaitSetScrollPosition>d__7(int <>1__state);
            /*0x7321cec*/ void System.IDisposable.Dispose();
            /*0x7321cf0*/ bool MoveNext();
            /*0x7321d50*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x7321d58*/ void System.Collections.IEnumerator.Reset();
            /*0x7321d90*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class DialogBase<T> : NoaDebugger.ViewBase<T>
    {
        /*0x0*/ UnityEngine.GameObject _targetView;
        /*0x0*/ TMPro.TextMeshProUGUI _caption;
        /*0x0*/ UnityEngine.UI.Button _closeButton;
        /*0x0*/ UnityEngine.UI.Button _alternativeCloseButton;

        /*0x38159dc*/ DialogBase();
        /*0x38159dc*/ void _Init();
        /*0x3910ae8*/ void _OnShow(T linker);
        /*0x38159dc*/ void _OnHide();
    }

    class DialogBaseViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ string _caption;

        /*0x7321d98*/ DialogBaseViewLinker();
    }

    class DownloadDialog : NoaDebugger.DialogBase<NoaDebugger.DownloadDialog.DownloadDialogLinker>
    {
        static string CAPTION = "Download";
        static int MAX_LABEL_CHAR_NUM = 20;
        static /*0x0*/ char[] InvalidCharacters;
        /*0x40*/ NoaDebugger.NoaDebuggerInputField _labelInput;
        /*0x48*/ UnityEngine.UI.Button _downloadButton;

        static /*0x732204c*/ DownloadDialog();
        /*0x7322004*/ DownloadDialog();
        /*0x7321da0*/ void _OnShow(NoaDebugger.DownloadDialog.DownloadDialogLinker linker);
        /*0x7321f04*/ void _OnHide();
        /*0x7321f80*/ char _LabelValidate(string text, int charIndex, char addedChar);

        class DownloadDialogLinker : NoaDebugger.DialogBaseViewLinker
        {
            /*0x18*/ string _initialLabel;
            /*0x20*/ UnityEngine.Events.UnityAction _onDownload;
            /*0x28*/ UnityEngine.Events.UnityAction<string> _onChangeLabel;

            /*0x73220ec*/ DownloadDialogLinker();
        }
    }

    class GameObjectDetailPanel : NoaDebugger.HierarchyPanelBase<NoaDebugger.GameObjectDetailPanelData>
    {
        static string NAME_VALUE_FORMAT = "{0} :    {1}";
        static string NAME_ONLY_FORMAT = "{0}";
        /*0x68*/ TMPro.TextMeshProUGUI _keyValueLabel;
        /*0x70*/ UnityEngine.UI.Button _headerToggle;

        /*0x7322248*/ GameObjectDetailPanel();
        /*0x73220f4*/ void _Draw(NoaDebugger.GameObjectDetailPanelData panelData);
        /*0x7322224*/ float _GetLabelLength();
    }

    class GameObjectDetailPanelData : NoaDebugger.HierarchyPanelDataBase
    {
        /*0x28*/ string _itemName;
        /*0x30*/ string _itemValue;

        /*0x7322290*/ GameObjectDetailPanelData(NoaDebugger.GameObjectDetailEntry entry, int depth, System.Action onToggle);
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

        /*0x7322a10*/ GameObjectDetailView();
        /*0x732234c*/ void add_OnDetailLock(System.Action<bool> value);
        /*0x73223fc*/ void remove_OnDetailLock(System.Action<bool> value);
        /*0x73224ac*/ void add_OnSwitchSelectedObjectActive(System.Action<bool> value);
        /*0x732255c*/ void remove_OnSwitchSelectedObjectActive(System.Action<bool> value);
        /*0x732260c*/ void _OnValidateUI();
        /*0x73226ac*/ void Show(NoaDebugger.GameObjectDetail detail);
        /*0x73229d0*/ void _OnDetailLock(bool isLock);
        /*0x73229f0*/ void _OnSwitchSelectedObjectActive(bool isActive);
    }

    class HierarchyFloatingWindowView : NoaDebugger.FloatingWindowViewBase<NoaDebugger.HierarchyViewLinker>
    {
        /*0x80*/ TMPro.TextMeshProUGUI _sceneCountLabel;
        /*0x88*/ NoaDebugger.HierarchyTreeView _hierarchyTreeView;
        /*0x90*/ TMPro.TextMeshProUGUI _objectCountLabel;
        /*0x98*/ UnityEngine.UI.Button _refreshButton;
        /*0xa0*/ NoaDebugger.HierarchyPanelScrollHelper<NoaDebugger.HierarchyPanel, NoaDebugger.HierarchyPanelData> _scrollHelper;
        /*0xa8*/ System.Action OnRefreshHierarchy;

        /*0x7322e0c*/ HierarchyFloatingWindowView();
        /*0x7322a18*/ void add_OnRefreshHierarchy(System.Action value);
        /*0x7322ab4*/ void remove_OnRefreshHierarchy(System.Action value);
        /*0x7322b50*/ void _OnValidateUI();
        /*0x7322b54*/ void _OnShow(NoaDebugger.HierarchyViewLinker linker);
        /*0x7322df0*/ void _OnRefresh();
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

        /*0x38159dc*/ HierarchyPanelBase();
        /*0x3910ae8*/ void Draw(T panelData);
        /*0x3910ae8*/ void _Draw(T panelData);
        /*0x38151b8*/ float GetPanelWidth();
        /*0x38151b8*/ float GetLabelLength();
        /*0x38151b8*/ float _GetLabelLength();
        /*0x3816f24*/ void SetPanelWidth(float width);
        /*0x38159dc*/ void _RefreshToggleIcon();
        /*0x38159dc*/ void _OnToggleButton();
        /*0x38159dc*/ void <Draw>b__9_0();
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

        /*0x7322344*/ HierarchyPanelDataBase();
    }

    class HierarchyPanelScrollHelper<TPanel, TData>
    {
        /*0x0*/ NoaDebugger.ObjectPoolScroll _scroll;
        /*0x0*/ System.Collections.Generic.List<TData> _dataList;
        /*0x0*/ bool _isRunningSetPanelWidthCoroutine;
        /*0x0*/ float _maxLabelLength;

        /*0x3816710*/ HierarchyPanelScrollHelper(NoaDebugger.ObjectPoolScroll scroll);
        /*0x3816710*/ void RefreshScroll(System.Collections.Generic.List<TData> dataList);
        /*0x38148bc*/ System.Collections.IEnumerator _WaitAfterSetPanelWidth();
        /*0x3816044*/ void _OnRefreshPanel(int index, UnityEngine.GameObject target);

        class <>c<TPanel, TData>
        {
            static /*0x0*/ NoaDebugger.HierarchyPanelScrollHelper.<>c<TPanel, TData> <>9;
            static /*0x0*/ System.Func<NoaDebugger.ObjectPoolScroll.PanelData, TPanel> <>9__6_0;

            static /*0x383e7a0*/ <>c();
            /*0x38159dc*/ <>c();
            /*0x3910ae8*/ TPanel <_WaitAfterSetPanelWidth>b__6_0(NoaDebugger.ObjectPoolScroll.PanelData showPanel);
        }

        class <_WaitAfterSetPanelWidth>d__6<TPanel, TData> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ NoaDebugger.HierarchyPanelScrollHelper<TPanel, TData> <>4__this;

            /*0x3815ed0*/ <_WaitAfterSetPanelWidth>d__6(int <>1__state);
            /*0x38159dc*/ void System.IDisposable.Dispose();
            /*0x3813ffc*/ bool MoveNext();
            /*0x38148bc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
            /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class HierarchyView : NoaDebugger.NoaDebuggerToolViewBase<NoaDebugger.HierarchyViewLinker>
    {
        /*0x28*/ NoaDebugger.GameObjectDetailView _gameObjectDetail;
        /*0x30*/ NoaDebugger.HierarchyTreeView _hierarchyTree;

        /*0x7322e94*/ HierarchyView();
        /*0x7322e54*/ void _OnShow(NoaDebugger.HierarchyViewLinker linker);
    }

    class HierarchyViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ NoaDebugger.HierarchyViewData _hierarchyViewData;
        /*0x20*/ NoaDebugger.GameObjectDetail _selectGameObjectDetail;

        /*0x7322edc*/ HierarchyViewLinker();
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
        /*0x7323220*/ FloatingHierarchyPanel();
        /*0x7322ee4*/ void _Draw(NoaDebugger.HierarchyPanelData panelData);
        /*0x732310c*/ void _OnSelectButton();
    }

    class HierarchyPanel : NoaDebugger.HierarchyPanelBase<NoaDebugger.HierarchyPanelData>
    {
        /*0x68*/ TMPro.TextMeshProUGUI _nameLabel;
        /*0x70*/ UnityEngine.UI.Button _selectButton;
        /*0x78*/ UnityEngine.GameObject _selectIcon;

        /*0x7323224*/ HierarchyPanel();
        /*0x7322f9c*/ void _Draw(NoaDebugger.HierarchyPanelData panelData);
        /*0x732326c*/ float _GetLabelLength();
        /*0x73231e8*/ void _OnSelect();
    }

    class HierarchyPanelData : NoaDebugger.HierarchyPanelDataBase
    {
        /*0x28*/ string _gameObjectName;
        /*0x30*/ NoaDebugger.HierarchyGameObjectEntry _entry;
        /*0x38*/ System.Action<NoaDebugger.HierarchyGameObjectEntry> _onSelect;

        /*0x7323290*/ HierarchyPanelData(NoaDebugger.HierarchyGameObjectEntry entry, int depth, System.Action onToggle);
    }

    class HierarchyTreeView : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _sceneCountLabel;
        /*0x28*/ TMPro.TextMeshProUGUI _objectCountLabel;
        /*0x30*/ NoaDebugger.ObjectPoolScroll _hierarchyScroll;
        /*0x38*/ UnityEngine.UI.Button _refreshButton;
        /*0x40*/ NoaDebugger.HierarchyPanelScrollHelper<NoaDebugger.HierarchyPanel, NoaDebugger.HierarchyPanelData> _scrollHelper;
        /*0x48*/ System.Action OnRefreshHierarchy;

        /*0x7323578*/ HierarchyTreeView();
        /*0x7323384*/ void add_OnRefreshHierarchy(System.Action value);
        /*0x7323420*/ void remove_OnRefreshHierarchy(System.Action value);
        /*0x73234bc*/ void _OnValidateUI();
        /*0x7322c98*/ void Show(NoaDebugger.HierarchyViewData hierarchyData);
        /*0x732355c*/ void _OnRefresh();
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

        /*0x7324228*/ CustomInformationScrollDrawer();
        /*0x7323580*/ void Awake();
        /*0x732374c*/ void Draw(System.Collections.Generic.List<NoaDebugger.InformationCustomGroup> groups);
        /*0x7323980*/ void _CreateContextPanel();
        /*0x7323aac*/ void _DrawContextPanel(NoaDebugger.ContextPanelView panel, NoaDebugger.InformationCustomGroup groupInfo);
        /*0x732409c*/ void SetLineWidth();
        /*0x7324218*/ void OnRectTransformDimensionsChange();
        /*0x7323ffc*/ float _GetLineMinWidth();

        class PanelObject
        {
            /*0x10*/ NoaDebugger.ContextPanelView _panel;
            /*0x18*/ int _index;

            /*0x7323fc0*/ PanelObject(NoaDebugger.ContextPanelView panel, int index);
        }

        class <>c
        {
            static /*0x0*/ NoaDebugger.CustomInformationScrollDrawer.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.InformationCustomGroup, int> <>9__10_0;
            static /*0x10*/ System.Func<NoaDebugger.InformationCustomKeyValue, int> <>9__12_0;

            static /*0x7324230*/ <>c();
            /*0x7324298*/ <>c();
            /*0x73242a0*/ int <Draw>b__10_0(NoaDebugger.InformationCustomGroup g);
            /*0x73242b8*/ int <_DrawContextPanel>b__12_0(NoaDebugger.InformationCustomKeyValue kv);
        }
    }

    class CustomInformationView : NoaDebugger.ViewBase<NoaDebugger.CustomInformationViewLinker>
    {
        /*0x20*/ NoaDebugger.CustomInformationScrollDrawer _drawer;
        /*0x28*/ UnityEngine.GameObject _noDataLabel;

        /*0x7324384*/ CustomInformationView();
        /*0x73242d0*/ void _OnShow(NoaDebugger.CustomInformationViewLinker linker);
        /*0x7324360*/ void _OnHide();
    }

    class CustomInformationViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ System.Collections.Generic.List<NoaDebugger.InformationCustomGroup> _groups;

        /*0x73243cc*/ CustomInformationViewLinker();
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

        /*0x7324f74*/ InformationView();
        /*0x73243d4*/ void add_OnClickTab(UnityEngine.Events.UnityAction<NoaDebugger.InformationView.ToggleTabType> value);
        /*0x7324484*/ void remove_OnClickTab(UnityEngine.Events.UnityAction<NoaDebugger.InformationView.ToggleTabType> value);
        /*0x7324534*/ void add_OnTapRefreshButton(UnityEngine.Events.UnityAction<bool> value);
        /*0x73245e4*/ void remove_OnTapRefreshButton(UnityEngine.Events.UnityAction<bool> value);
        /*0x7324694*/ void add_OnLongTapRefreshButton(UnityEngine.Events.UnityAction value);
        /*0x7324730*/ void remove_OnLongTapRefreshButton(UnityEngine.Events.UnityAction value);
        /*0x73247cc*/ void add_OnClickDownload(UnityEngine.Events.UnityAction value);
        /*0x7324868*/ void remove_OnClickDownload(UnityEngine.Events.UnityAction value);
        /*0x7324904*/ void _Init();
        /*0x7324c40*/ void _OnShow(NoaDebugger.InformationViewLinker linker);
        /*0x7324e98*/ void _OnClickSystemTab(bool isOn);
        /*0x7324ebc*/ void _OnClickUnityTab(bool isOn);
        /*0x7324ee0*/ void _OnClickCustomTab(bool isOn);
        /*0x7324f04*/ void _OnClickReload();
        /*0x7324f3c*/ void _OnLongTapRefreshButton(bool isToggleOn);
        /*0x7324f58*/ void _OnClickDownload();

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

        /*0x7324fbc*/ InformationViewLinker();
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

        /*0x7325adc*/ SystemInformationView();
        /*0x7324fc4*/ void _OnStart();
        /*0x7325030*/ void _OnShow(NoaDebugger.SystemInformationViewLinker linker);
        /*0x7325ab8*/ void _OnHide();
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

        /*0x7325b24*/ SystemInformationViewLinker();
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

        /*0x7326904*/ UnityInformationView();
        /*0x7325b2c*/ void _OnShow(NoaDebugger.UnityInformationViewLinker linker);
        /*0x732675c*/ void _OnHide();
        /*0x7325ba8*/ void _OnShowUnityInfo(NoaDebugger.UnityInformationViewLinker.UnityInfo info);
        /*0x7325d40*/ void _OnShowRuntime(NoaDebugger.UnityInformationViewLinker.Runtime info);
        /*0x73261dc*/ void _OnShowFeatures(NoaDebugger.UnityInformationViewLinker.Features info);
        /*0x7326498*/ void _OnShowGraphics(NoaDebugger.UnityInformationViewLinker.Graphics info);
        /*0x7326780*/ string _ConvertLabel(string label);
        /*0x73267f4*/ string _ConvertFlag(bool flag);
        /*0x7326894*/ bool _IsAcquireLabel(string label);
    }

    class UnityInformationViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ NoaDebugger.UnityInformationViewLinker.UnityInfo _unityInfo;
        /*0x18*/ NoaDebugger.UnityInformationViewLinker.Runtime _runtimeInfo;
        /*0x20*/ NoaDebugger.UnityInformationViewLinker.Features _featuresInfo;
        /*0x28*/ NoaDebugger.UnityInformationViewLinker.Graphics _graphicsInfo;

        /*0x732694c*/ UnityInformationViewLinker();

        class UnityInfo
        {
            /*0x10*/ string _version;
            /*0x18*/ bool _debug;
            /*0x19*/ bool _il2CPP;
            /*0x1c*/ int _vSyncCount;
            /*0x20*/ int _targetFrameRate;

            /*0x7326954*/ UnityInfo();
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

            /*0x732695c*/ Runtime();
        }

        class Features
        {
            /*0x10*/ bool _location;
            /*0x11*/ bool _accelerometer;
            /*0x12*/ bool _gyroscope;
            /*0x13*/ bool _vibration;

            /*0x7326964*/ Features();
        }

        class Graphics
        {
            /*0x10*/ int _maxTexSize;
            /*0x14*/ UnityEngine.NPOTSupport _npotSupport;
            /*0x18*/ bool _computeShaders;
            /*0x19*/ bool _shadows;
            /*0x1a*/ bool _sparseTextures;

            /*0x732696c*/ Graphics();
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

        /*0x732748c*/ ApiLogDetailView();
        /*0x7326974*/ void Awake();
        /*0x7326b78*/ void ResetContent();
        /*0x7326c38*/ void SetCopyButton(UnityEngine.Events.UnityAction onClick);
        /*0x7326c74*/ void UpdateRequestTab(NoaDebugger.ApiLog log);
        /*0x73270c8*/ void UpdateResponseTab(NoaDebugger.ApiLog log);
        /*0x7327404*/ void _OnShowRequest(bool showsContent);
        /*0x7327424*/ void _OnShowResponse(bool showsContent);
        /*0x7327444*/ void _OnCopy();

        struct TabbedContent
        {
            /*0x10*/ NoaDebugger.ToggleButtonBase _tabButton;
            /*0x18*/ UnityEngine.GameObject _viewRoot;
        }
    }

    class ApiLogOverlaySettingsDefaultGetter : NoaDebugger.LogOverlaySettingsDefaultGetter
    {
        /*0x7327494*/ ApiLogOverlaySettingsDefaultGetter();
        /*0x73274c4*/ NoaDebugger.NoaDebug.OverlayPosition get_DefaultPosition();
        /*0x73274e0*/ float get_DefaultFontScale();
        /*0x73274fc*/ int get_DefaultMaximumLogCount();
        /*0x7327518*/ float get_DefaultMinimumOpacity();
        /*0x7327534*/ float get_DefaultActiveDuration();
        /*0x7327550*/ bool get_DefaultShowTimestamp();
        /*0x732756c*/ bool get_DefaultShowMessageLogs();
        /*0x7327588*/ bool get_DefaultShowWarningLogs();
        /*0x7327590*/ bool get_DefaultShowErrorLogs();
    }

    class ApiLogView : NoaDebugger.LogViewBase
    {
        /*0xe0*/ NoaDebugger.ApiLogDetailView _logDetail;
        /*0xe8*/ NoaDebugger.OrientationLayoutRuntimeAdjuster _layoutAdjuster;

        /*0x73277c0*/ ApiLogView();
        /*0x73275ac*/ void _OnInit();
        /*0x73275b0*/ void _OnShow(NoaDebugger.LogViewLinker linker);
        /*0x73275d8*/ void _OnUpdateDetail(NoaDebugger.ILogDetail detail);
        /*0x7327790*/ void _UpdateRequestTab(NoaDebugger.ApiLog log);
        /*0x73277a8*/ void _UpdateResponseTab(NoaDebugger.ApiLog log);

        class <>c__DisplayClass4_0
        {
            /*0x10*/ NoaDebugger.ApiLogView <>4__this;
            /*0x18*/ NoaDebugger.ApiLog log;

            /*0x7327788*/ <>c__DisplayClass4_0();
            /*0x73277c8*/ void <_OnUpdateDetail>b__0();
        }
    }

    class ConsoleLogOverlaySettingsDefaultGetter : NoaDebugger.LogOverlaySettingsDefaultGetter
    {
        /*0x73277f8*/ ConsoleLogOverlaySettingsDefaultGetter();
        /*0x73277fc*/ NoaDebugger.NoaDebug.OverlayPosition get_DefaultPosition();
        /*0x7327818*/ float get_DefaultFontScale();
        /*0x7327834*/ int get_DefaultMaximumLogCount();
        /*0x7327850*/ float get_DefaultMinimumOpacity();
        /*0x732786c*/ float get_DefaultActiveDuration();
        /*0x7327888*/ bool get_DefaultShowTimestamp();
        /*0x73278a4*/ bool get_DefaultShowMessageLogs();
        /*0x73278c0*/ bool get_DefaultShowWarningLogs();
        /*0x73278dc*/ bool get_DefaultShowErrorLogs();
    }

    class ConsoleLogView : NoaDebugger.LogViewBase
    {
        /*0xe0*/ NoaDebugger.ConsoleLogDetailView _logDetail;

        /*0x7327b04*/ ConsoleLogView();
        /*0x73278f8*/ void _OnInit();
        /*0x73278fc*/ void _OnUpdateDetail(NoaDebugger.ILogDetail detail);

        class <>c__DisplayClass2_0
        {
            /*0x10*/ NoaDebugger.ConsoleLogView <>4__this;
            /*0x18*/ NoaDebugger.ConsoleLogDetail log;

            /*0x7327a88*/ <>c__DisplayClass2_0();
            /*0x7327b0c*/ void <_OnUpdateDetail>b__0();
        }
    }

    class ConsoleLogDetailView : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _logDetailText;
        /*0x28*/ UnityEngine.UI.Button _copyButton;
        /*0x30*/ UnityEngine.Events.UnityAction _onClickCopyButton;

        /*0x7327c64*/ ConsoleLogDetailView();
        /*0x7327b3c*/ void Awake();
        /*0x7327a90*/ void SetLogDetailText(string text);
        /*0x7327ac8*/ void SetCopyButton(UnityEngine.Events.UnityAction onClick);
        /*0x7327be4*/ void _OnCopy();
        /*0x7327c2c*/ void OnDestroy();
    }

    class LogOverlaySettingsDefaultGetter
    {
        /*0x10*/ NoaDebugger.NoaDebuggerSettings _settings;

        /*0x7327498*/ LogOverlaySettingsDefaultGetter();
        /*0x3814574*/ NoaDebugger.NoaDebug.OverlayPosition get_DefaultPosition();
        /*0x38151b8*/ float get_DefaultFontScale();
        /*0x3814574*/ int get_DefaultMaximumLogCount();
        /*0x38151b8*/ float get_DefaultMinimumOpacity();
        /*0x38151b8*/ float get_DefaultActiveDuration();
        /*0x3813ffc*/ bool get_DefaultShowTimestamp();
        /*0x3813ffc*/ bool get_DefaultShowMessageLogs();
        /*0x3813ffc*/ bool get_DefaultShowWarningLogs();
        /*0x3813ffc*/ bool get_DefaultShowErrorLogs();
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

        /*0x7327eb4*/ LogOverlaySettingsView();
        /*0x7327c6c*/ void _OnValidateUI();
        /*0x7327c70*/ void _Init();
        /*0x7327cb8*/ void _OnShow(NoaDebugger.LogOverlaySettings linker);
        /*0x7327df0*/ void Refresh();
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

        /*0x732871c*/ LogOverlaySettings();
        /*0x7327efc*/ NoaDebugger.NoaDebug.OverlayPosition get_DefaultPosition();
        /*0x7327f68*/ NoaDebugger.OverlayFloatSettings get_FontScale();
        /*0x7327f70*/ NoaDebugger.OverlayIntSettings get_MaximumLogCount();
        /*0x7327f78*/ NoaDebugger.OverlayFloatSettings get_MinimumOpacity();
        /*0x7327f80*/ NoaDebugger.OverlayFloatSettings get_ActiveDuration();
        /*0x7327f88*/ NoaDebugger.OverlayBoolSettings get_ShowTimestamp();
        /*0x7327f90*/ NoaDebugger.OverlayBoolSettings get_ShowMessageLogs();
        /*0x7327f98*/ NoaDebugger.OverlayBoolSettings get_ShowWarningLogs();
        /*0x7327fa0*/ NoaDebugger.OverlayBoolSettings get_ShowErrorLogs();
        /*0x7327fa8*/ void ReceiveDefaultGetter(NoaDebugger.LogOverlaySettingsDefaultGetter defaultGetter);
        /*0x7327fb0*/ void _InitializeSettings();
        /*0x73284a0*/ void _LoadSettings(string overlayPrefsJson);
        /*0x7328664*/ void _ResetSettings();
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

        /*0x732ac78*/ LogOverlayView();
        /*0x73289e8*/ string get_DeviceOrientationKey();
        /*0x7328a54*/ void add_OnEnabledAction(System.Action value);
        /*0x7328af0*/ void remove_OnEnabledAction(System.Action value);
        /*0x7328b8c*/ void _OnValidateUI();
        /*0x7328b90*/ void _Init();
        /*0x7328fb0*/ void OnEnable();
        /*0x7328fe4*/ System.Collections.IEnumerator OnEnableDelay();
        /*0x7329078*/ void OnUpdateSettings(NoaDebugger.LogOverlaySettings settings);
        /*0x73291a4*/ void OnUpdate(NoaDebugger.LogOverlayViewLinker linker);
        /*0x7329984*/ void _OnTargetRectTransformDimensionsChanged();
        /*0x73299a4*/ void _OnDeviceOrientation(bool isPortrait);
        /*0x7328f00*/ void _RefreshWindowWidth(bool isPortrait);
        /*0x73294b4*/ void _RefreshFontScale();
        /*0x7329a94*/ void _RefreshWindowHeight();
        /*0x732942c*/ void _RefreshLogEntries(System.Collections.Generic.List<NoaDebugger.LogViewLinker.LogPanelInfo> allLogs);
        /*0x7329bb4*/ void _InstantiateLogEntries(int logNum);
        /*0x732a120*/ void _DisplayNewLogEntry(System.Collections.Generic.List<NoaDebugger.LogViewLinker.LogPanelInfo> logs, bool isShowTimestamp);
        /*0x7329d04*/ void _HideExistLogEntries(System.Collections.Generic.List<NoaDebugger.LogViewLinker.LogPanelInfo> logs);
        /*0x7328d54*/ void _InstantiateReferenceLogEntry();
        /*0x73298a8*/ void _ManagedHideDelay();
        /*0x732aa18*/ System.Collections.IEnumerator _HideAfterDelay(float delayTime);
        /*0x732aabc*/ System.Collections.IEnumerator _FadeOut();
        /*0x7329148*/ void ApplyMinimumOpacitySetting();
        /*0x732ab50*/ void OnDestroy();

        class <>c
        {
            static /*0x0*/ NoaDebugger.LogOverlayView.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.LogViewLinker.LogPanelInfo, bool> <>9__30_0;
            static /*0x10*/ System.Func<NoaDebugger.OverlayLogPanel, int> <>9__38_0;

            static /*0x732adb0*/ <>c();
            /*0x732ae18*/ <>c();
            /*0x732ae20*/ bool <OnUpdate>b__30_0(NoaDebugger.LogViewLinker.LogPanelInfo log);
            /*0x732ae40*/ int <_DisplayNewLogEntry>b__38_0(NoaDebugger.OverlayLogPanel panel);
        }

        class <OnEnableDelay>d__28 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.LogOverlayView <>4__this;

            /*0x7329050*/ <OnEnableDelay>d__28(int <>1__state);
            /*0x732ae7c*/ void System.IDisposable.Dispose();
            /*0x732ae80*/ bool MoveNext();
            /*0x732af38*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x732af40*/ void System.Collections.IEnumerator.Reset();
            /*0x732af78*/ object System.Collections.IEnumerator.get_Current();
        }

        class <_FadeOut>d__43 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.LogOverlayView <>4__this;
            /*0x28*/ float <startTime>5__2;
            /*0x2c*/ float <elapsedTime>5__3;
            /*0x30*/ float <minimumOpacity>5__4;

            /*0x732ab28*/ <_FadeOut>d__43(int <>1__state);
            /*0x732af80*/ void System.IDisposable.Dispose();
            /*0x732af84*/ bool MoveNext();
            /*0x732b0b0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x732b0b8*/ void System.Collections.IEnumerator.Reset();
            /*0x732b0f0*/ object System.Collections.IEnumerator.get_Current();
        }

        class <_HideAfterDelay>d__42 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ float delayTime;
            /*0x28*/ NoaDebugger.LogOverlayView <>4__this;
            /*0x30*/ float <startTime>5__2;
            /*0x34*/ float <elapsedTime>5__3;

            /*0x732aa94*/ <_HideAfterDelay>d__42(int <>1__state);
            /*0x732b0f8*/ void System.IDisposable.Dispose();
            /*0x732b0fc*/ bool MoveNext();
            /*0x732b1d4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x732b1dc*/ void System.Collections.IEnumerator.Reset();
            /*0x732b214*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class LogOverlayViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ System.Collections.Generic.List<NoaDebugger.LogViewLinker.LogPanelInfo> _logs;
        /*0x18*/ NoaDebugger.LogViewLinker.LogTypeToggles _logTypeToggles;

        /*0x732b21c*/ LogOverlayViewLinker();
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

        /*0x732b850*/ LogPanel();
        /*0x732b224*/ void _OnValidateUI();
        /*0x732b228*/ void Awake();
        /*0x732b3a8*/ void Draw(NoaDebugger.LogViewLinker.LogPanelInfo logInfo, bool isSelect);
        /*0x732b73c*/ void _OnClick();
        /*0x732b75c*/ void _OnPointerDown();
        /*0x732b77c*/ void _OnLongTap();
        /*0x732b798*/ void OnDestroy();
    }

    class LogPanelCommonDisplayProcessing
    {
        /*0x10*/ UnityEngine.UI.Image _logType;
        /*0x18*/ TMPro.TextMeshProUGUI _logString;
        /*0x20*/ UnityEngine.GameObject _logCounterRoot;
        /*0x28*/ TMPro.TextMeshProUGUI _logCounter;

        static /*0x732b858*/ UnityEngine.Color _GetLogTypeColor(NoaDebugger.LogType type);
        /*0x732b538*/ LogPanelCommonDisplayProcessing(UnityEngine.UI.Image logType, TMPro.TextMeshProUGUI logString, UnityEngine.GameObject logCounterRoot, TMPro.TextMeshProUGUI logCounter);
        /*0x732b5ac*/ void RefreshLogType(NoaDebugger.LogViewLinker.LogPanelInfo logInfo);
        /*0x732b5e0*/ void RefreshLogString(NoaDebugger.LogViewLinker.LogPanelInfo logInfo);
        /*0x732b948*/ void RefreshLogString(string logString);
        /*0x732b5f8*/ void RefreshLogCounter(NoaDebugger.LogViewLinker.LogPanelInfo logInfo);
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

        /*0x732c15c*/ LogScrollDrawer();
        /*0x732b980*/ void add_OnChangeFilterText(UnityEngine.Events.UnityAction<string> value);
        /*0x732ba30*/ void remove_OnChangeFilterText(UnityEngine.Events.UnityAction<string> value);
        /*0x732bae0*/ void _OnValidateUI();
        /*0x732bae4*/ void Awake();
        /*0x732bc8c*/ void OnEnable();
        /*0x732bc98*/ void Draw(NoaDebugger.LogViewLinker linker, bool isFloatingWindow);
        /*0x732bee0*/ void SwitchFilterContent(bool isShow);
        /*0x732bf00*/ void _OnScrolled();
        /*0x732bf4c*/ void _OnScrollDownToBottom();
        /*0x732bf6c*/ void _OnChangeFilterInput(string text);
        /*0x732bf88*/ void _OnResetFilterText();
        /*0x732bfb8*/ void _OnRefreshPanel(int index, UnityEngine.GameObject target);
        /*0x732c124*/ bool _IsSelect(NoaDebugger.LogViewLinker.LogPanelInfo log);
    }

    class LogSwitchToggleDrawer : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.LogTypeToggle _messageLogToggle;
        /*0x28*/ NoaDebugger.LogTypeToggle _warningLogToggle;
        /*0x30*/ NoaDebugger.LogTypeToggle _errorLogToggle;
        /*0x38*/ UnityEngine.Events.UnityAction<NoaDebugger.LogType, bool> OnSwitchByLogType;

        /*0x732c688*/ LogSwitchToggleDrawer();
        /*0x732c164*/ void add_OnSwitchByLogType(UnityEngine.Events.UnityAction<NoaDebugger.LogType, bool> value);
        /*0x732c214*/ void remove_OnSwitchByLogType(UnityEngine.Events.UnityAction<NoaDebugger.LogType, bool> value);
        /*0x732c2c4*/ void _OnValidateUI();
        /*0x732c2c8*/ void Awake();
        /*0x732c454*/ void Draw(NoaDebugger.LogViewLinker.LogTypeToggles linker);
        /*0x732c5d4*/ void _OnSwitchMessage(bool isOn);
        /*0x732c5f8*/ void _OnSwitchWarning(bool isOn);
        /*0x732c61c*/ void _OnSwitchError(bool isOn);
        /*0x732c640*/ void OnDestroy();
    }

    class LogTypeToggle : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.ToggleButtonBase _toggle;
        /*0x28*/ TMPro.TextMeshProUGUI _logCountOnDisabled;
        /*0x30*/ TMPro.TextMeshProUGUI _logCountOnEnabled;

        /*0x732c6c8*/ LogTypeToggle();
        /*0x732c518*/ void set_LogCount(int value);
        /*0x732c4f8*/ void set_IsOn(bool value);
        /*0x732c3dc*/ void set_Listener(UnityEngine.Events.UnityAction<bool> value);
        /*0x732c690*/ void OnDestroy();
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

        /*0x732d8cc*/ LogViewBase();
        /*0x732c6d0*/ void add_OnRecord(UnityEngine.Events.UnityAction value);
        /*0x732c76c*/ void remove_OnRecord(UnityEngine.Events.UnityAction value);
        /*0x732c808*/ void add_OnClear(UnityEngine.Events.UnityAction value);
        /*0x732c8a4*/ void remove_OnClear(UnityEngine.Events.UnityAction value);
        /*0x732c940*/ void add_OnSelectingMode(UnityEngine.Events.UnityAction<bool> value);
        /*0x732c9f0*/ void remove_OnSelectingMode(UnityEngine.Events.UnityAction<bool> value);
        /*0x732caa0*/ void add_OnSelectAll(UnityEngine.Events.UnityAction value);
        /*0x732cb3c*/ void remove_OnSelectAll(UnityEngine.Events.UnityAction value);
        /*0x732cbd8*/ void add_OnDeselectAll(UnityEngine.Events.UnityAction value);
        /*0x732cc74*/ void remove_OnDeselectAll(UnityEngine.Events.UnityAction value);
        /*0x732cd10*/ void add_OnDownload(UnityEngine.Events.UnityAction value);
        /*0x732cdac*/ void remove_OnDownload(UnityEngine.Events.UnityAction value);
        /*0x732ce48*/ void add_OnSend(UnityEngine.Events.UnityAction value);
        /*0x732cee4*/ void remove_OnSend(UnityEngine.Events.UnityAction value);
        /*0x732cf80*/ UnityEngine.Events.UnityAction<NoaDebugger.ILogDetail> get_OnCopy();
        /*0x732cf88*/ void set_OnCopy(UnityEngine.Events.UnityAction<NoaDebugger.ILogDetail> value);
        /*0x732cf90*/ void _OnValidateUI();
        /*0x732cf94*/ void _Init();
        /*0x732d38c*/ void _OnInit();
        /*0x732d390*/ void _OnUpdateDetail(NoaDebugger.ILogDetail detail);
        /*0x732d394*/ void _OnShow(NoaDebugger.LogViewLinker linker);
        /*0x732d584*/ void _RefreshLogDetailView(bool isView);
        /*0x732d5b4*/ void AlignmentUI(bool isReverse);
        /*0x732d668*/ void _OnRecord(bool isOn);
        /*0x732d684*/ void _OnClear();
        /*0x732d6a0*/ void _OnSelection(bool isOn);
        /*0x732d6ec*/ void _OnSearch(bool isOn);
        /*0x732d714*/ void _OnSelectAll();
        /*0x732d738*/ void _OnDeselectAll();
        /*0x732d75c*/ void _OnDownload();
        /*0x732d778*/ void _OnSend();
        /*0x732d794*/ void OnDestroy();
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

        /*0x732d914*/ LogViewLinker();

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

            /*0x732da7c*/ LogPanelInfo();
            /*0x732d91c*/ void set__index(int value);
            /*0x732d924*/ int get__index();
            /*0x732d92c*/ void set__viewIndex(int value);
            /*0x732d934*/ int get__viewIndex();
            /*0x732d93c*/ void set__isSelect(bool value);
            /*0x732d948*/ bool get__isSelect();
            /*0x732d950*/ void set__isPicOut(bool value);
            /*0x732d95c*/ bool get__isPicOut();
            /*0x732d964*/ void set__hasLoggedOnce(bool value);
            /*0x732d970*/ bool get__hasLoggedOnce();
            /*0x732d978*/ void set__logString(string value);
            /*0x732d980*/ string get__logString();
            /*0x732d988*/ void set__stackTraceString(string value);
            /*0x732d990*/ string get__stackTraceString();
            /*0x732d998*/ void set__logDetail(NoaDebugger.ILogDetail value);
            /*0x732d9a0*/ NoaDebugger.ILogDetail get__logDetail();
            /*0x732d9a8*/ void set__logType(NoaDebugger.LogType value);
            /*0x732d9b0*/ NoaDebugger.LogType get__logType();
            /*0x732d9b8*/ void set__receivedTime(System.DateTime value);
            /*0x732d9c0*/ System.DateTime get__receivedTime();
            /*0x732d9c8*/ void set__numberOfMatchingLogs(int value);
            /*0x732d9d0*/ int get__numberOfMatchingLogs();
            /*0x732d9d8*/ void set__serialNumber(int value);
            /*0x732d9e0*/ int get__serialNumber();
            /*0x732d9e8*/ void UpdateLogData(string logString, string stackTrace, NoaDebugger.ILogDetail logDetail, NoaDebugger.LogType logType, System.DateTime receivedAt, int serialNumber);
            /*0x732da58*/ void UpdateViewData(int index, int viewIndex, bool isSelect, bool isPicOut, bool hasLoggedOnce, int numberOfMatchingLogs);
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

        /*0x732de70*/ OverlayLogFontScaler();
        /*0x732da84*/ void _OnValidateUI();
        /*0x732da88*/ void Awake();
        /*0x732dbc0*/ void ChangeFontScale(float fontScale);
        /*0x732ddcc*/ void OnDestroy();
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

        static /*0x732e230*/ OverlayLogPanel();
        /*0x732e228*/ OverlayLogPanel();
        /*0x73299c4*/ UnityEngine.RectTransform get_RectTransform();
        /*0x732ae60*/ int get_LogIndex();
        /*0x732def8*/ void _OnValidateUI();
        /*0x732defc*/ void OnDestroy();
        /*0x732dfd8*/ void Start();
        /*0x732a7d4*/ void Draw(NoaDebugger.LogViewLinker.LogPanelInfo logInfo, bool isShowTimestamp);
        /*0x732dfdc*/ void _RefreshLogString(NoaDebugger.LogViewLinker.LogPanelInfo logInfo, bool isShowTimestamp);
        /*0x73299ac*/ void ChangeFontScale(float fontScale);
        /*0x732aa0c*/ void ResetHashCode();
        /*0x732a7b0*/ bool Equal(NoaDebugger.LogViewLinker.LogPanelInfo logPanelInfo);
        /*0x732e194*/ System.Collections.IEnumerator _HighlightTemporarily();
        /*0x732e0f0*/ void _ChangeLogBackgroundColor(UnityEngine.Color changeColor);

        class <_HighlightTemporarily>d__27 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.OverlayLogPanel <>4__this;
            /*0x28*/ float <startTime>5__2;
            /*0x2c*/ float <elapsedTime>5__3;

            /*0x732e200*/ <_HighlightTemporarily>d__27(int <>1__state);
            /*0x732e27c*/ void System.IDisposable.Dispose();
            /*0x732e280*/ bool MoveNext();
            /*0x732e380*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x732e388*/ void System.Collections.IEnumerator.Reset();
            /*0x732e3c0*/ object System.Collections.IEnumerator.get_Current();
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

        static /*0x732f800*/ NoaDebuggerButton();
        /*0x732f7f8*/ NoaDebuggerButton();
        /*0x732e3c8*/ NoaDebugger.NoaControllerView get_ControllerView();
        /*0x732e3d0*/ System.Action get_OnShowController();
        /*0x732e3d8*/ void set_OnShowController(System.Action value);
        /*0x732e3e0*/ UnityEngine.RectTransform get_CachedRootRect();
        /*0x732e468*/ bool get_IsPlayingAnimation();
        /*0x732e484*/ void _OnValidateUI();
        /*0x732e488*/ void Init();
        /*0x732e654*/ void PlayOnLocationAnimation();
        /*0x732e714*/ void PlayOnErrorAnimation();
        /*0x732e7a4*/ void ResetButtonColor();
        /*0x732e7c0*/ bool _IsAnimationBreak();
        /*0x732e7d8*/ void _OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x732e650*/ void _UpdateSettings();
        /*0x732e878*/ void _OnStartButtonSetActive(bool active);
        /*0x732e8a0*/ void Update();
        /*0x732e924*/ void _UpdateButton();
        /*0x732e970*/ void _UpdateTapStateOnPressing(float pressingTime);
        /*0x732eb38*/ void _UpdateButtonFromTapState(float pressingTime);
        /*0x732ec38*/ void _UpdateButtonAlphaOnPressing(float pressingTime);
        /*0x732e960*/ void _Reset();
        /*0x732eee0*/ void _SetActiveUI();
        /*0x732eee8*/ void _LoadPosition(bool isPortrait);
        /*0x732ed40*/ void _SavePosition(bool isPortrait);
        /*0x732f31c*/ UnityEngine.Vector3 _GetPositionPrefsData(bool isPortrait);
        /*0x732f450*/ UnityEngine.Vector3 _DeserializeVector3(string value);
        /*0x732f68c*/ void OnRectTransformDimensionsChange();
        /*0x732f51c*/ bool _IsOutOfScreen(UnityEngine.Vector3 buttonPosition);
        /*0x732efc0*/ UnityEngine.Vector3 _SetupButtonPosition();
        /*0x732f708*/ void Dispose();
        /*0x732f86c*/ void <Init>b__25_0(UnityEngine.EventSystems.PointerEventData _);

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

        /*0x732fa08*/ NoaDebuggerButtonInController();
        /*0x732f874*/ bool get_IsPlayingAnimation();
        /*0x732f890*/ void Init();
        /*0x732f8c8*/ void _OnValidateUI();
        /*0x732f8cc*/ void PlayOnErrorAnimation();
        /*0x732f9bc*/ void ResetButtonColor();
        /*0x732f9d8*/ void Dispose();

        class <>c
        {
            static /*0x0*/ NoaDebugger.NoaDebuggerButtonInController.<> <>9;
            static /*0x8*/ System.Func<bool> <>9__6_0;

            static /*0x732fa10*/ <>c();
            /*0x732fa78*/ <>c();
            /*0x732fa80*/ bool <PlayOnErrorAnimation>b__6_0();
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

        /*0x732fe54*/ ControllerCustomActionButton();
        /*0x732fa9c*/ System.Action get_OnTap();
        /*0x732faa4*/ void set_OnTap(System.Action value);
        /*0x732fafc*/ System.Action get_OnLongTap();
        /*0x732fb04*/ void set_OnLongTap(System.Action value);
        /*0x732fb20*/ System.Action<bool> get_OnToggle();
        /*0x732fb28*/ void set_OnToggle(System.Action<bool> value);
        /*0x732fb70*/ bool get_IsToggleOn();
        /*0x732fb8c*/ void set_IsToggleOn(bool value);
        /*0x732fbac*/ NoaDebugger.NoaController.CustomActionType get_ActionType();
        /*0x732fbb4*/ void set_ActionType(NoaDebugger.NoaController.CustomActionType value);
        /*0x732fbbc*/ void Awake();
        /*0x732fd28*/ void SetCustomActionType(NoaDebugger.NoaController.CustomActionType actionType);
        /*0x732fac0*/ void _SetLongTapButtonInteractable();
        /*0x732fb44*/ void _SetToggleButtonInteractable();
        /*0x732fe5c*/ void <Awake>b__21_0();
        /*0x732fe78*/ void <Awake>b__21_1();
        /*0x732fe94*/ void <Awake>b__21_2(bool isOn);
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

        /*0x7331dbc*/ NoaControllerView();
        /*0x732feb4*/ void add_OnShow(System.Action value);
        /*0x732ff50*/ void remove_OnShow(System.Action value);
        /*0x732ffec*/ void add_OnHide(System.Action value);
        /*0x7330088*/ void remove_OnHide(System.Action value);
        /*0x7330124*/ void add_OnTogglePauseResume(System.Action<bool> value);
        /*0x73301d4*/ void remove_OnTogglePauseResume(System.Action<bool> value);
        /*0x7330284*/ void add_OnGameSpeedDecrement(System.Action value);
        /*0x7330320*/ void remove_OnGameSpeedDecrement(System.Action value);
        /*0x73303bc*/ void add_OnGameSpeedMinimize(System.Action value);
        /*0x7330458*/ void remove_OnGameSpeedMinimize(System.Action value);
        /*0x73304f4*/ void add_OnGameSpeedIncrement(System.Action value);
        /*0x7330590*/ void remove_OnGameSpeedIncrement(System.Action value);
        /*0x733062c*/ void add_OnGameSpeedMaximize(System.Action value);
        /*0x73306c8*/ void remove_OnGameSpeedMaximize(System.Action value);
        /*0x7330764*/ void add_OnGameSpeedReset(System.Action value);
        /*0x7330800*/ void remove_OnGameSpeedReset(System.Action value);
        /*0x733089c*/ void add_OnFrameSteppingButtonEnabled(System.Action value);
        /*0x7330938*/ void remove_OnFrameSteppingButtonEnabled(System.Action value);
        /*0x73309d4*/ void add_OnFrameStepping(System.Action value);
        /*0x7330a70*/ void remove_OnFrameStepping(System.Action value);
        /*0x7330b0c*/ void add_OnResetApplication(System.Action value);
        /*0x7330ba8*/ void remove_OnResetApplication(System.Action value);
        /*0x7330c44*/ void add_OnHideNoaDebuggerUI(System.Action value);
        /*0x7330ce0*/ void remove_OnHideNoaDebuggerUI(System.Action value);
        /*0x7330d7c*/ void add_OnCaptureScreenshot(System.Action value);
        /*0x7330e18*/ void remove_OnCaptureScreenshot(System.Action value);
        /*0x7330eb4*/ void add_OnShowNoaDebugger(System.Action value);
        /*0x7330f50*/ void remove_OnShowNoaDebugger(System.Action value);
        /*0x7330fec*/ void add_OnClose(System.Action value);
        /*0x7331088*/ void remove_OnClose(System.Action value);
        /*0x7331124*/ bool get_IsProcessFrameStepping();
        /*0x7331140*/ void Awake();
        /*0x7331720*/ void OnEnable();
        /*0x7331994*/ void OnDisable();
        /*0x73319b0*/ void SetCustomTapAction(int buttonIndex, System.Action action);
        /*0x73319f8*/ void SetCustomLongPressAction(int buttonIndex, System.Action action);
        /*0x7331a40*/ void SetCustomToggleAction(int buttonIndex, System.Action<bool> action);
        /*0x7331a88*/ void SetCustomToggle(int buttonIndex, bool isOn);
        /*0x7331acc*/ bool GetCustomToggle(int buttonIndex);
        /*0x7331b0c*/ void SetCustomActionType(int buttonIndex, NoaDebugger.NoaController.CustomActionType actionType);
        /*0x7331b44*/ void TogglePauseResume(bool isPlaying);
        /*0x7331b64*/ void UpdateGameSpeed(float gameSpeed, float minGameSpeed, float maxGameSpeed);
        /*0x7331c40*/ void SetResetAppButtonInteractable(bool interactable);
        /*0x7331c60*/ void SetLongPressButtonActionIntervalSettings(NoaDebugger.LongPressButtonActionIntervalSettings setting);
        /*0x7331c7c*/ void ReSetFrameSteppingButtonState();
        /*0x7331160*/ void _ValidateFields();
        /*0x7331c98*/ void _ValidateControllerOrder(System.Collections.Generic.IReadOnlyList<UnityEngine.RectTransform> order);
        /*0x733118c*/ void _ApplyNoaDebuggerSettings();
        /*0x7331d48*/ void _SetImageOpacity(UnityEngine.UI.Image image);
        /*0x7331260*/ void _InitializeCallbacks();
        /*0x7331750*/ void _ReorderButtons();
        /*0x7331dc4*/ void <_InitializeCallbacks>b__86_0(bool isPlaying);
        /*0x7331de4*/ void <_InitializeCallbacks>b__86_1();
        /*0x7331e00*/ void <_InitializeCallbacks>b__86_2();
        /*0x7331e1c*/ void <_InitializeCallbacks>b__86_3();
        /*0x7331e38*/ void <_InitializeCallbacks>b__86_4();
        /*0x7331e54*/ void <_InitializeCallbacks>b__86_5();
        /*0x7331e70*/ void <_InitializeCallbacks>b__86_6();
        /*0x7331e8c*/ void <_InitializeCallbacks>b__86_7();
        /*0x7331ea8*/ void <_InitializeCallbacks>b__86_8();
        /*0x7331ec4*/ void <_InitializeCallbacks>b__86_9();
        /*0x7331ee0*/ void <_InitializeCallbacks>b__86_10();
        /*0x7331efc*/ void <_InitializeCallbacks>b__86_11();
        /*0x7331f18*/ void <_InitializeCallbacks>b__86_12();
        /*0x7331f34*/ void <_InitializeCallbacks>b__86_13();
    }

    class DragBehaviour : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEndDragHandler
    {
        /*0x20*/ UnityEngine.RectTransform _rect;
        /*0x28*/ UnityEngine.Vector2 _originalPivot;
        /*0x30*/ bool <CanMove>k__BackingField;
        /*0x31*/ bool <isDragging>k__BackingField;
        /*0x38*/ UnityEngine.Events.UnityAction<UnityEngine.Vector2> OnDragging;
        /*0x40*/ UnityEngine.Events.UnityAction<UnityEngine.Vector2> OnDragEnd;

        /*0x73328d0*/ DragBehaviour();
        /*0x7331f50*/ bool get_CanMove();
        /*0x7331f58*/ void set_CanMove(bool value);
        /*0x7331f64*/ bool get_isDragging();
        /*0x7331f6c*/ void set_isDragging(bool value);
        /*0x7331f78*/ void add_OnDragging(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x7332028*/ void remove_OnDragging(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x73320d8*/ void add_OnDragEnd(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x7332188*/ void remove_OnDragEnd(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x7332238*/ void Start();
        /*0x73322e4*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x733269c*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x73327a0*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
    }

    class DragBehaviourFitWithInScreen : NoaDebugger.DragBehaviour
    {
        /*0x48*/ UnityEngine.RectTransform[] _fitWithInScreenRects;

        /*0x7332cd8*/ DragBehaviourFitWithInScreen();
        /*0x73328d8*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x7332a94*/ UnityEngine.Vector3[] _GetOutermostPositions();
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

        /*0x38159dc*/ FloatingWindowViewBase();
        /*0x38148bc*/ string get_ToolName();
        /*0x3816710*/ void set_ToolName(string value);
        /*0x3816710*/ void add_OnToggleStateChange(UnityEngine.Events.UnityAction<bool> value);
        /*0x3816710*/ void remove_OnToggleStateChange(UnityEngine.Events.UnityAction<bool> value);
        /*0x3816710*/ void add_OnDrag(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x3816710*/ void remove_OnDrag(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x3816710*/ void add_OnDragEnd(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x3816710*/ void remove_OnDragEnd(UnityEngine.Events.UnityAction<UnityEngine.Vector2> value);
        /*0x3816710*/ void add_OnClose(UnityEngine.Events.UnityAction value);
        /*0x3816710*/ void remove_OnClose(UnityEngine.Events.UnityAction value);
        /*0x38159dc*/ void _OnValidateUI();
        /*0x38159dc*/ void _Init();
        /*0x38171d8*/ void SetScreenPos(UnityEngine.Vector2 screenPos);
        /*0x3815cc4*/ void SetState(bool isShowDefault);
        /*0x3816710*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x3816710*/ void _SetBackgroundColor(UnityEngine.UI.Image target);
        /*0x38159dc*/ void _ChangeWindowOrder();
        /*0x3815cc4*/ void _OnToggleChange(bool isOn);
        /*0x38159dc*/ void _ChangeState();
        /*0x38171d8*/ void _OnDrag(UnityEngine.Vector2 screenPos);
        /*0x38171d8*/ void _OnDragEnd(UnityEngine.Vector2 screenPos);
        /*0x38159dc*/ void _Close();
    }

    class FloatingWindowInfo
    {
        /*0x10*/ string _playerPrefsKey;
        /*0x18*/ bool _isActiveValue;
        /*0x19*/ bool _isShowDefaultInfoVale;
        /*0x1c*/ UnityEngine.Vector2 _screenPositionPortraitValue;
        /*0x24*/ UnityEngine.Vector2 _screenPositionLandscapeValue;

        /*0x7332d9c*/ FloatingWindowInfo(string prefsKey);
        /*0x7332ce0*/ bool get__isActive();
        /*0x7332ce8*/ void set__isActive(bool value);
        /*0x7332d68*/ bool get__isShowDefaultInfo();
        /*0x7332d70*/ void set__isShowDefaultInfo(bool value);
        /*0x7332d7c*/ UnityEngine.Vector2 get_ScreenPositionPortrait();
        /*0x7332d84*/ void set_ScreenPositionPortrait(UnityEngine.Vector2 value);
        /*0x7332d8c*/ UnityEngine.Vector2 get_ScreenPositionLandscape();
        /*0x7332d94*/ void set_ScreenPositionLandscape(UnityEngine.Vector2 value);
        /*0x7332eac*/ void Reset();
        /*0x7332cf4*/ void _Save();
    }

    class MenuTabComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.UI.Button _tabButton;
        /*0x28*/ TMPro.TextMeshProUGUI _label;
        /*0x30*/ UnityEngine.GameObject _selectLine;
        /*0x38*/ UnityEngine.UI.Image _allow;
        /*0x40*/ UnityEngine.GameObject _badge;
        /*0x48*/ NoaDebugger.UIReverseComponents _reverseComponents;

        /*0x7333078*/ MenuTabComponent();
        /*0x7332f10*/ void Awake();
        /*0x7332f14*/ void _OnValidateUI();
        /*0x7332f18*/ void ChangeTabSelect(bool isSelect);
        /*0x7332fdc*/ void ShowNoticeBadge(NoaDebugger.ToolNotificationStatus notificationStatus);
        /*0x7333000*/ void OnDestroy();
        /*0x7333058*/ void AlignmentUI(bool isReverse);
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

        /*0x733567c*/ NoaDebuggerView();
        /*0x7333080*/ void add_ChangeToolListener(System.Action<int> value);
        /*0x7333130*/ void remove_ChangeToolListener(System.Action<int> value);
        /*0x73331e0*/ void add_OnToolDetailButton(System.Action value);
        /*0x733327c*/ void remove_OnToolDetailButton(System.Action value);
        /*0x7333318*/ void add_OnCloseButton(System.Action value);
        /*0x73333b4*/ void remove_OnCloseButton(System.Action value);
        /*0x7333450*/ void add_OnFloatingWindowPinButton(System.Action value);
        /*0x73334ec*/ void remove_OnFloatingWindowPinButton(System.Action value);
        /*0x7333588*/ void add_OnOverlayPinButton(System.Action value);
        /*0x7333624*/ void remove_OnOverlayPinButton(System.Action value);
        /*0x73336c0*/ void add_OnOverlaySettingsButton(System.Action value);
        /*0x733375c*/ void remove_OnOverlaySettingsButton(System.Action value);
        /*0x73337f8*/ void add_OnControllerButton(System.Action value);
        /*0x7333894*/ void remove_OnControllerButton(System.Action value);
        /*0x7333930*/ void add_OnChangeButton(System.Action<bool> value);
        /*0x73339e0*/ void remove_OnChangeButton(System.Action<bool> value);
        /*0x7333a90*/ bool get_RequiresRebuildSideMenu();
        /*0x7333a98*/ void set_RequiresRebuildSideMenu(bool value);
        /*0x7333aa4*/ UnityEngine.Transform get_ContentRoot();
        /*0x7333aac*/ UnityEngine.Transform get_UIParent();
        /*0x7333ac8*/ void _Init();
        /*0x7333e60*/ void _OnStart();
        /*0x7333fac*/ void _OnShow(NoaDebugger.NoaDebuggerViewLinker linker);
        /*0x7334958*/ void _AlignmentUI(bool isPortrait, NoaDebugger.INoaDebuggerTool target);
        /*0x7334c34*/ void _ShowPinArea(NoaDebugger.INoaDebuggerTool target);
        /*0x7334e40*/ void RefreshOverlayButtons(NoaDebugger.INoaDebuggerOverlayTool overlayTool);
        /*0x7334dd4*/ System.Collections.IEnumerator _SetScrollPosition();
        /*0x7334afc*/ void UpdateMenu(NoaDebugger.NoaDebuggerViewLinker linker);
        /*0x7334f9c*/ void _OnChangeTool(int index);
        /*0x7334fb8*/ void HideContents();
        /*0x7335294*/ void SetChangeButtonInteractable(bool interactable);
        /*0x73352b4*/ void _DestroyAllMenuButton();
        /*0x7334250*/ void CreateMenu(NoaDebugger.INoaDebuggerTool[] tools, bool forceCreate);
        /*0x73353b8*/ void InitTabs();
        /*0x7334698*/ void _EnableSideMenuVerticalParts();
        /*0x7334854*/ void _DisableSideMenuVerticalParts();
        /*0x7334730*/ void _ShowSideMenu();
        /*0x73347e0*/ void _HideSideMenu();
        /*0x7335418*/ void _OnHide();
        /*0x7335484*/ void OnDestroy();
        /*0x73356cc*/ void <_Init>b__62_0();
        /*0x73356e8*/ void <_Init>b__62_1();
        /*0x7335704*/ void <_Init>b__62_2(bool isOn);
        /*0x7335720*/ void <_Init>b__62_3(bool isOn);
        /*0x733573c*/ void <_Init>b__62_4(bool isOn);
        /*0x7335758*/ void <_Init>b__62_5();
        /*0x7335774*/ void <_Init>b__62_6(bool isOn);
        /*0x7335794*/ void <_Init>b__62_7();

        class <>c__DisplayClass74_0
        {
            /*0x10*/ int index;
            /*0x18*/ NoaDebugger.NoaDebuggerView <>4__this;

            /*0x73353b0*/ <>c__DisplayClass74_0();
            /*0x73357b0*/ void <CreateMenu>b__0();
        }

        class <_SetScrollPosition>d__68 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.NoaDebuggerView <>4__this;

            /*0x7334f74*/ <_SetScrollPosition>d__68(int <>1__state);
            /*0x73357e8*/ void System.IDisposable.Dispose();
            /*0x73357ec*/ bool MoveNext();
            /*0x733585c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x7335864*/ void System.Collections.IEnumerator.Reset();
            /*0x733589c*/ object System.Collections.IEnumerator.get_Current();
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

        /*0x73358a4*/ NoaDebuggerViewLinker();
    }

    class OverlayBoolSettings : NoaDebugger.OverlaySettingsBase<bool>
    {
        /*0x73358ac*/ OverlayBoolSettings(bool defaultValue, bool isSaveEnabledAlways, System.Action save);
    }

    class OverlayEnumSettings : NoaDebugger.OverlaySettingsBase<System.Enum>
    {
        /*0x38*/ string _valueStr;
        /*0x40*/ System.Type _enumType;
        /*0x48*/ string[] _enumNames;
        /*0x50*/ System.Enum[] _enumValues;

        /*0x733591c*/ OverlayEnumSettings(System.Enum defaultValue, bool isSaveEnabledAlways, System.Action save);
        /*0x7335a40*/ void ApplySavedSettings(NoaDebugger.OverlaySettingsBase<System.Enum> savedSettings);
        /*0x7335b8c*/ void ResetSettings();
        /*0x7335bfc*/ void ChangeAndSaveValue(System.Enum value);
    }

    class OverlayFloatSettings : NoaDebugger.OverlayNumericSettingsBase<float>
    {
        /*0x34*/ int _needDigits;

        /*0x7335c74*/ OverlayFloatSettings(float defaultValue, bool isSaveEnabledAlways, System.Action save, float inputRangeMin, float inputRangeMax, float increment);
        /*0x7335da8*/ float FromString(string textValue);
        /*0x7335e78*/ bool IsEqualOrUnderMin(float value);
        /*0x7335e88*/ bool IsEqualOrOverMax(float value);
        /*0x7335e98*/ float ValidateValueForFluctuation(float value, int magnification);
        /*0x7335f38*/ float _ValidateValue(float value);
    }

    class OverlayIntSettings : NoaDebugger.OverlayNumericSettingsBase<int>
    {
        /*0x7336018*/ OverlayIntSettings(int defaultValue, bool isSaveEnabledAlways, System.Action save, int inputRangeMin, int inputRangeMax, int increment);
        /*0x73360a8*/ int FromString(string textValue);
        /*0x733616c*/ bool IsEqualOrUnderMin(int value);
        /*0x733617c*/ bool IsEqualOrOverMax(int value);
        /*0x733618c*/ int ValidateValueForFluctuation(int value, int magnification);
        /*0x73361a4*/ int _ValidateValue(int value);
    }

    class OverlayNumericSettingsBase<T> : NoaDebugger.OverlaySettingsBase<T>
    {
        /*0x0*/ T _inputRangeMin;
        /*0x0*/ T _inputRangeMax;
        /*0x0*/ T _increment;

        /*0x3910ae8*/ OverlayNumericSettingsBase(T defaultValue, bool isSaveEnabledAlways, System.Action save, T inputRangeMin, T inputRangeMax, T increment);
        /*0x3910ae8*/ T FromString(string textValue);
        /*0x3910ae8*/ bool IsEqualOrUnderMin(T value);
        /*0x3910ae8*/ bool IsEqualOrOverMax(T value);
        /*0x3910ae8*/ T ValidateValueForFluctuation(T value, int magnification);
        /*0x3910ae8*/ T _ValidateValue(T value);
        /*0x3910ae8*/ void ChangeAndSaveValue(T value);
        /*0x38141c4*/ bool IsNotNumeric(string text);
    }

    class OverlaySettingsBase<T>
    {
        /*0x0*/ T _value;
        /*0x0*/ bool _isSaved;
        /*0x0*/ T _defaultValue;
        /*0x0*/ bool _isSaveEnabledAlways;
        /*0x0*/ System.Action _save;

        /*0x3910ae8*/ OverlaySettingsBase(T defaultValue, bool isSaveEnabledAlways, System.Action save);
        /*0x3910ae8*/ T get_Value();
        /*0x3813ffc*/ bool get_IsSaved();
        /*0x3816710*/ void ApplySavedSettings(NoaDebugger.OverlaySettingsBase<T> savedSettings);
        /*0x38159dc*/ void ResetSettings();
        /*0x3910ae8*/ void ChangeAndSaveValue(T value);
    }

    class OverlayBoolSettingsPanel : NoaDebugger.OverlaySettingsPanelBase<bool>
    {
        /*0x30*/ NoaDebugger.ToggleButtonBase _toggleButton;
        /*0x38*/ UnityEngine.UI.Graphic _clickTarget;

        /*0x7336454*/ OverlayBoolSettingsPanel();
        /*0x7336270*/ void Initialize(NoaDebugger.OverlaySettingsBase<bool> settings);
        /*0x7336360*/ void Refresh();
        /*0x73363b4*/ void SetEnabled(bool isEnabled);
        /*0x7336430*/ void _OnToggleChange(bool isOn);
    }

    class OverlayEnumSettingsPanel : NoaDebugger.OverlaySettingsPanelBase<System.Enum>
    {
        /*0x30*/ TMPro.TMP_Dropdown _dropdown;
        /*0x38*/ NoaDebugger.OverlayEnumSettings _enumSettings;
        /*0x40*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> _optionDataList;

        /*0x7336850*/ OverlayEnumSettingsPanel();
        /*0x733649c*/ void Initialize(NoaDebugger.OverlaySettingsBase<System.Enum> settings);
        /*0x7336554*/ void _InitializeUI();
        /*0x733678c*/ void Refresh();
        /*0x7336808*/ void _OnChangeDropdown(int index);
    }

    class OverlayFloatSettingsPanel : NoaDebugger.OverlayNumericSettingsPanelBase<float>
    {
        /*0x7336898*/ OverlayFloatSettingsPanel();
    }

    class OverlayIntSettingsPanel : NoaDebugger.OverlayNumericSettingsPanelBase<int>
    {
        /*0x73368e0*/ OverlayIntSettingsPanel();
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

        /*0x38159dc*/ OverlayNumericSettingsPanelBase();
        /*0x3816710*/ void Initialize(NoaDebugger.OverlaySettingsBase<T> settings);
        /*0x38159dc*/ void _InitializeUI();
        /*0x38159dc*/ void Refresh();
        /*0x3816710*/ void _OnEndInputEdit(string text);
        /*0x38159dc*/ void _OnBeginDrag();
        /*0x3816f24*/ void _OnSliding(float distance);
        /*0x38159dc*/ void _OnDownArrowButton();
        /*0x3816710*/ void _OnExitArrowButton(UnityEngine.EventSystems.PointerEventData eventData);
        /*0x38159dc*/ void _OnClickLeftArrowButton();
        /*0x38159dc*/ void _DecrementValue();
        /*0x38159dc*/ void _OnClickRightArrowButton();
        /*0x38159dc*/ void _IncrementValue();
        /*0x3910ae8*/ void _FluctuateValue(T beginValue, int count);
        /*0x38159dc*/ void _SetValue();
        int _DelimitDistance(float distance);
    }

    class OverlaySettingsPanelBase<T> : UnityEngine.MonoBehaviour
    {
        /*0x0*/ UnityEngine.GameObject _disableObject;
        /*0x0*/ NoaDebugger.OverlaySettingsBase<T> _settings;

        /*0x38159dc*/ OverlaySettingsPanelBase();
        /*0x3816710*/ void Initialize(NoaDebugger.OverlaySettingsBase<T> settings);
        /*0x38159dc*/ void Refresh();
        /*0x3815cc4*/ void SetEnabled(bool isEnabled);
    }

    class OverlaySettingsViewBase<TOverlayToolSettings> : NoaDebugger.ViewBase<TOverlayToolSettings>
    {
        /*0x0*/ NoaDebugger.BlockableScrollRect _scroll;
        /*0x0*/ UnityEngine.UI.Button _resetButton;
        /*0x0*/ TOverlayToolSettings _overlayToolSettings;

        /*0x38159dc*/ OverlaySettingsViewBase();
        /*0x38159dc*/ void _Init();
        /*0x3910ae8*/ void _OnShow(TOverlayToolSettings linker);
        /*0x38159dc*/ void _OnHide();
        /*0x3815cc4*/ void AlignmentUI(bool isReverse);
        /*0x38148bc*/ System.Collections.IEnumerator _WaitSetScrollPosition();
        /*0x38159dc*/ void _OnResetButton();
        /*0x38159dc*/ void Refresh();

        class <_WaitSetScrollPosition>d__7<TOverlayToolSettings> : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ int <>1__state;
            /*0x0*/ object <>2__current;
            /*0x0*/ NoaDebugger.OverlaySettingsViewBase<TOverlayToolSettings> <>4__this;

            /*0x3815ed0*/ <_WaitSetScrollPosition>d__7(int <>1__state);
            /*0x38159dc*/ void System.IDisposable.Dispose();
            /*0x3813ffc*/ bool MoveNext();
            /*0x38148bc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
            /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class OverlayToolSettingsBase : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ System.Action OnUpdateSettings;
        /*0x18*/ NoaDebugger.NoaDebuggerSettings _noaDebuggerSettings;
        /*0x20*/ string _playerPrefsKey;
        /*0x28*/ NoaDebugger.OverlayEnumSettings _position;

        /*0x7336d40*/ OverlayToolSettingsBase();
        /*0x7336928*/ void add_OnUpdateSettings(System.Action value);
        /*0x73369c4*/ void remove_OnUpdateSettings(System.Action value);
        /*0x3814574*/ NoaDebugger.NoaDebug.OverlayPosition get_DefaultPosition();
        /*0x7336a60*/ NoaDebugger.OverlayEnumSettings get_Position();
        /*0x7336a68*/ void Initialize(string prefsKey);
        /*0x7336b88*/ void _InitializeSettings();
        /*0x3816710*/ void _LoadSettings(string overlayPrefsJson);
        /*0x7336b68*/ void Reset();
        /*0x7336d20*/ void _ResetSettings();
        /*0x7336c88*/ void _Save();
    }

    class OverlayViewBase<TOverlayToolSettings, TViewLinker> : NoaDebugger.ViewBase<NoaDebugger.OverlayViewLinker<TOverlayToolSettings, TViewLinker>>
    {
        /*0x0*/ UnityEngine.UI.Graphic[] _opacityChangeTargets;
        /*0x0*/ TOverlayToolSettings _settings;
        /*0x0*/ UnityEngine.RectTransform _rootRect;

        /*0x38159dc*/ OverlayViewBase();
        /*0x38159dc*/ void _OnValidateUI();
        /*0x38159dc*/ void _Init();
        /*0x3816710*/ void _OnShow(NoaDebugger.OverlayViewLinker<TOverlayToolSettings, TViewLinker> linker);
        /*0x3910ae8*/ void OnUpdateSettings(TOverlayToolSettings settings);
        /*0x3910ae8*/ void OnUpdate(TViewLinker linker);
        /*0x3815ed0*/ void _SetPosition(NoaDebugger.NoaDebug.OverlayPosition position);
    }

    class OverlayViewLinker<TOverlayToolSettings, TViewLinker> : NoaDebugger.ViewLinkerBase
    {
        /*0x0*/ TOverlayToolSettings <OverlayToolSettings>k__BackingField;
        /*0x0*/ TViewLinker <ViewLinker>k__BackingField;

        /*0x3910ae8*/ OverlayViewLinker(TOverlayToolSettings overlayToolSettings, TViewLinker viewLinker);
        /*0x3910ae8*/ TOverlayToolSettings get_OverlayToolSettings();
        /*0x3910ae8*/ TViewLinker get_ViewLinker();
    }

    class NoaDebuggerToolViewBase<T> : NoaDebugger.ViewBase<T>
    {
        /*0x0*/ NoaDebugger.UIReverseComponents _reverseComponents;

        /*0x38159dc*/ NoaDebuggerToolViewBase();
        /*0x3815cc4*/ void AlignmentUI(bool isReverse);
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

        /*0x73376f4*/ FpsOverlayView();
        /*0x7336d48*/ UnityEngine.Color get_TextColor();
        /*0x7336da4*/ void OnInitialize();
        /*0x7336da8*/ void UpdateView(System.ValueTuple<NoaDebugger.FpsUnchangingInfo, NoaDebugger.ProfilerFrameTimeViewInformation> data);
        /*0x73373c8*/ bool _IsShowGraph();
        /*0x7337490*/ void SetWidth(float width, bool isForce);
        /*0x7336e04*/ void _UpdateText(NoaDebugger.FpsUnchangingInfo fpsInfo);
        /*0x7337378*/ void _UpdateGraph(System.ValueTuple<NoaDebugger.FpsUnchangingInfo, NoaDebugger.ProfilerFrameTimeViewInformation> data);
        /*0x733762c*/ void OnDestroy();

        class FullTextArea
        {
            /*0x10*/ TMPro.TextMeshProUGUI _text;
            /*0x18*/ UnityEngine.UI.LayoutElement _layout;

            /*0x733773c*/ FullTextArea();
            /*0x7337550*/ void SetText(string valueText);
        }
    }

    class MemoryOverlayView : NoaDebugger.ProfilerOverlayFeatureViewBase<NoaDebugger.MemoryUnchangingInfo, NoaDebugger.MemoryChartDrawerComponent>
    {
        /*0x58*/ TMPro.TextMeshProUGUI _memoryLabelsText;
        /*0x60*/ TMPro.TextMeshProUGUI _memoryValuesText;
        /*0x68*/ TMPro.TextMeshProUGUI _graphLabelText;

        /*0x73383fc*/ MemoryOverlayView();
        /*0x7337744*/ UnityEngine.Color get_TextColor();
        /*0x73377a0*/ void OnInitialize();
        /*0x73377a4*/ void UpdateView(NoaDebugger.MemoryUnchangingInfo data);
        /*0x73380b8*/ bool _IsShowGraph();
        /*0x73377fc*/ void _UpdateText(NoaDebugger.MemoryUnchangingInfo data);
        /*0x7337fd0*/ void _UpdateGraph(NoaDebugger.MemoryUnchangingInfo data);
        /*0x7338244*/ string _GetValueText(float value, NoaDebugger.MemoryUnchangingInfo data);
        /*0x7338384*/ void OnDestroy();

        class <>c__DisplayClass8_0
        {
            /*0x10*/ NoaDebugger.MemoryOverlayView <>4__this;
            /*0x18*/ NoaDebugger.MemoryUnchangingInfo data;

            /*0x7338180*/ <>c__DisplayClass8_0();
            /*0x7338444*/ string <_UpdateText>b__0(System.ValueTuple<string, float> x);
            /*0x733849c*/ string <_UpdateText>b__1(System.ValueTuple<string, float> x);
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

        /*0x38159dc*/ ProfilerOverlayFeatureViewBase();
        /*0x3814390*/ UnityEngine.Color get_TextColor();
        /*0x38159dc*/ void Awake();
        /*0x38159dc*/ void OnRectTransformDimensionsChange();
        /*0x38159dc*/ void OnInitialize();
        /*0x3910ae8*/ void ShowView(TData data, NoaDebugger.ProfilerOverlayFeatureSettings settings);
        /*0x3910ae8*/ void UpdateView(TData data);
        /*0x3813ffc*/ bool _IsShowGraph();
        void SetWidth(float width, bool isForce);
        /*0x3815cc4*/ void _SetActive(bool isActive);
        /*0x3814a3c*/ string _GetLabelText(string label);
        string _GetValueText(object value, bool isViewHyphen, bool isValid);
        /*0x38159dc*/ void OnDestroy();
    }

    class ProfilerOverlaySettingsGroupPanel : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.ToggleButtonBase _enableToggle;
        /*0x28*/ NoaDebugger.OverlayEnumSettingsPanel _textType;
        /*0x30*/ NoaDebugger.OverlayBoolSettingsPanel _graphToggle;
        /*0x38*/ NoaDebugger.ProfilerOverlayFeatureSettings _settingsCache;

        /*0x733874c*/ ProfilerOverlaySettingsGroupPanel();
        /*0x73384c0*/ void Awake();
        /*0x733857c*/ void Initialize(NoaDebugger.ProfilerOverlayFeatureSettings settings);
        /*0x7338674*/ void Refresh();
        /*0x73385f4*/ void _DisplayEnableToggle();
        /*0x73386fc*/ void _OnEnableToggleChange(bool isOn);
        /*0x73386b0*/ void _SetUIEnabled(bool isEnabled);
    }

    class ProfilerOverlayFeatureSettings
    {
        /*0x10*/ NoaDebugger.OverlayBoolSettings _isEnable;
        /*0x18*/ NoaDebugger.OverlayEnumSettings _textType;
        /*0x20*/ NoaDebugger.OverlayBoolSettings _isShowGraph;

        /*0x733876c*/ ProfilerOverlayFeatureSettings(System.Action save);
        /*0x7338754*/ NoaDebugger.OverlayBoolSettings get_IsEnable();
        /*0x733875c*/ NoaDebugger.OverlayEnumSettings get_TextType();
        /*0x7338764*/ NoaDebugger.OverlayBoolSettings get_IsShowGraph();
        /*0x73388e0*/ void ApplySavedSettings(NoaDebugger.ProfilerOverlayFeatureSettings savedSettings);
        /*0x7338964*/ void ResetSettings();
    }

    class ProfilerOverlaySettingsView : NoaDebugger.OverlaySettingsViewBase<NoaDebugger.ProfilerOverlaySettings>
    {
        /*0x38*/ NoaDebugger.ProfilerOverlaySettingsGroupPanel _fpsGroup;
        /*0x40*/ NoaDebugger.ProfilerOverlaySettingsGroupPanel _memoryGroup;
        /*0x48*/ NoaDebugger.ProfilerOverlaySettingsGroupPanel _renderingGroup;
        /*0x50*/ NoaDebugger.OverlayEnumSettingsPanel _position;
        /*0x58*/ NoaDebugger.OverlayFloatSettingsPanel _scale;
        /*0x60*/ NoaDebugger.OverlayEnumSettingsPanel _axis;

        /*0x7338b44*/ ProfilerOverlaySettingsView();
        /*0x73389b0*/ void _OnValidateUI();
        /*0x73389b4*/ void _Init();
        /*0x73389fc*/ void _OnShow(NoaDebugger.ProfilerOverlaySettings linker);
        /*0x7338ad4*/ void Refresh();
    }

    class ProfilerOverlaySettings : NoaDebugger.OverlayToolSettingsBase
    {
        /*0x30*/ NoaDebugger.ProfilerOverlayFeatureSettings _fpsSettings;
        /*0x38*/ NoaDebugger.ProfilerOverlayFeatureSettings _memorySettings;
        /*0x40*/ NoaDebugger.ProfilerOverlayFeatureSettings _renderingSettings;
        /*0x48*/ NoaDebugger.OverlayEnumSettings _axis;
        /*0x50*/ NoaDebugger.OverlayFloatSettings _scale;

        /*0x7339044*/ ProfilerOverlaySettings();
        /*0x7338b8c*/ NoaDebugger.NoaDebug.OverlayPosition get_DefaultPosition();
        /*0x7338ba8*/ NoaDebugger.ProfilerOverlayFeatureSettings get_FpsSettings();
        /*0x7338bb0*/ NoaDebugger.ProfilerOverlayFeatureSettings get_MemorySettings();
        /*0x7338bb8*/ NoaDebugger.ProfilerOverlayFeatureSettings get_RenderingSettings();
        /*0x7338bc0*/ NoaDebugger.OverlayFloatSettings get_Scale();
        /*0x7338bc8*/ NoaDebugger.OverlayEnumSettings get_Axis();
        /*0x7338bd0*/ void _InitializeSettings();
        /*0x7338e68*/ void _LoadSettings(string overlayPrefsJson);
        /*0x7338f9c*/ void _ResetSettings();
        /*0x733900c*/ NoaDebugger.ProfilerOverlayFeatureSettings GetFeatureSettings(NoaDebugger.NoaProfiler.FeatureType featureType);
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

        /*0x733992c*/ ProfilerOverlayView();
        /*0x733904c*/ void add_OnEnabledAction(System.Action value);
        /*0x73390e8*/ void remove_OnEnabledAction(System.Action value);
        /*0x7339184*/ void _OnValidateUI();
        /*0x733920c*/ void _Init();
        /*0x733925c*/ void OnEnable();
        /*0x7339290*/ System.Collections.IEnumerator OnEnableDelay();
        /*0x7339324*/ void OnUpdateSettings(NoaDebugger.ProfilerOverlaySettings settings);
        /*0x73395d4*/ void OnUpdate(NoaDebugger.ProfilerViewLinker linker);
        /*0x7339708*/ void _SetPosition(NoaDebugger.NoaDebug.OverlayPosition position);
        /*0x7339400*/ void _ApplyAxis(NoaDebugger.NoaProfiler.OverlayAxis axis);
        /*0x73395b0*/ void _ApplyScale(float scale);
        /*0x73398c4*/ void OnDestroy();

        class <OnEnableDelay>d__12 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ NoaDebugger.ProfilerOverlayView <>4__this;

            /*0x73392fc*/ <OnEnableDelay>d__12(int <>1__state);
            /*0x7339974*/ void System.IDisposable.Dispose();
            /*0x7339978*/ bool MoveNext();
            /*0x7339a94*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x7339a9c*/ void System.Collections.IEnumerator.Reset();
            /*0x7339ad4*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class RenderingOverlayView : NoaDebugger.ProfilerOverlayFeatureViewBase<NoaDebugger.RenderingUnchangingInfo, NoaDebugger.RenderingChartDrawerComponent>
    {
        /*0x58*/ TMPro.TextMeshProUGUI _renderingLabelsText;
        /*0x60*/ TMPro.TextMeshProUGUI _renderingValuesText;
        /*0x68*/ TMPro.TextMeshProUGUI _graphLabelText;

        /*0x733a6e8*/ RenderingOverlayView();
        /*0x7339adc*/ UnityEngine.Color get_TextColor();
        /*0x7339b38*/ void OnInitialize();
        /*0x7339b3c*/ void UpdateView(NoaDebugger.RenderingUnchangingInfo data);
        /*0x733a2d4*/ bool _IsShowGraph();
        /*0x7339b94*/ void _UpdateText(NoaDebugger.RenderingUnchangingInfo data);
        /*0x733a15c*/ void _UpdateGraph(NoaDebugger.RenderingUnchangingInfo data);
        /*0x733a3a4*/ System.ValueTuple<string, long, string> _GetTextInfoFromRenderingGraphTarget(NoaDebugger.RenderingUnchangingInfo data, NoaDebugger.RenderingGraphTarget target);
        /*0x733a598*/ string _GetValueText(long currentValue, string maxValueStr, NoaDebugger.RenderingUnchangingInfo data);
        /*0x733a670*/ void OnDestroy();

        class <>c__DisplayClass8_0
        {
            /*0x10*/ NoaDebugger.RenderingOverlayView <>4__this;
            /*0x18*/ NoaDebugger.RenderingUnchangingInfo data;

            /*0x733a39c*/ <>c__DisplayClass8_0();
            /*0x733a730*/ string <_UpdateText>b__0(System.ValueTuple<string, long, string> x);
            /*0x733a788*/ string <_UpdateText>b__1(System.ValueTuple<string, long, string> x);
        }
    }

    class BatteryTextDrawerComponent : UnityEngine.MonoBehaviour
    {
        static /*0x0*/ string InProgressLabel;
        static /*0x8*/ string ChargingLabel;
        /*0x20*/ TMPro.TextMeshProUGUI _currentBatteryAndMinute;
        /*0x28*/ TMPro.TextMeshProUGUI _operatingTime;

        static /*0x733abd8*/ BatteryTextDrawerComponent();
        /*0x733abd0*/ BatteryTextDrawerComponent();
        /*0x733a7ac*/ void Awake();
        /*0x733a7b0*/ void OnShowBatteryText(NoaDebugger.BatteryUnchangingInfo info, System.Nullable<UnityEngine.Color> enableTextColor);
        /*0x733aba8*/ void OnDestroy();
    }

    class ChartDrawerComponentBase : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.GameObject _rootObject;
        /*0x28*/ NoaDebugger.StackedAreaChart _chart;

        /*0x733ad04*/ ChartDrawerComponentBase();
        /*0x733ac74*/ void Awake();
        /*0x38159dc*/ void OnInitialize();
        /*0x733ac80*/ void SetActiveChart(bool isActive);
        /*0x733acdc*/ void OnDestroy();
    }

    class FpsGaugeDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.GaugeChart _fpsGauge;

        /*0x733ae3c*/ FpsGaugeDrawerComponent();
        /*0x733ad0c*/ void Awake();
        /*0x733ad10*/ void OnShowFpsGauge(NoaDebugger.FpsUnchangingInfo info);
        /*0x733ae30*/ void OnDestroy();
    }

    class FpsTextDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _currentFps;
        /*0x28*/ TMPro.TextMeshProUGUI _maxAndMinAndAverageFps;
        /*0x30*/ TMPro.TextMeshProUGUI _refreshRate;

        /*0x733b1e4*/ FpsTextDrawerComponent();
        /*0x733ae44*/ void Awake();
        /*0x733ae48*/ void OnShowFpsText(NoaDebugger.FpsUnchangingInfo info, System.Nullable<UnityEngine.Color> enableTextColor);
        /*0x733b1ac*/ void OnDestroy();
    }

    class FrameTimeChartDrawerComponent : NoaDebugger.ChartDrawerComponentBase
    {
        static /*0x0*/ float[] FrameTimeChartFpsRulerValues;
        static /*0x8*/ System.Collections.Generic.Dictionary<float, string> FrameTimeRulerStringCache;

        static /*0x733b698*/ FrameTimeChartDrawerComponent();
        static /*0x733b2a4*/ void CreateFrameTimeRulerStringCache();
        static /*0x733b494*/ void OnUpdateFrameTimeChartRulers(float maxValue, float[] positions, string[] labels);
        static /*0x733b47c*/ float FpsToFrameTimeMilliseconds(float fps);
        /*0x733b690*/ FrameTimeChartDrawerComponent();
        /*0x733b1ec*/ void OnInitialize();
        /*0x7337608*/ void OnShowFrameTime(NoaDebugger.ProfilerFrameTimeViewInformation info);
    }

    class MemoryChartDrawerComponent : NoaDebugger.ChartDrawerComponentBase
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<float, string> MemoryRulerStringCache;
        /*0x30*/ System.Nullable<NoaDebugger.NoaProfiler.MemoryProfilingType> _cachedProfilingType;

        static /*0x733bbf0*/ MemoryChartDrawerComponent();
        static /*0x733b960*/ void OnUpdateMemoryChartRulers(float maxValue, float[] positions, string[] labels);
        static /*0x733ba74*/ string <OnUpdateMemoryChartRulers>g__toRulerText|5_0(float value);
        /*0x733bbe8*/ MemoryChartDrawerComponent();
        /*0x733b790*/ void OnInitialize();
        /*0x7338188*/ void OnShowMemoryChart(NoaDebugger.MemoryUnchangingInfo info);
        /*0x733b820*/ void _SetStackDisplayAttributes(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
    }

    class MemoryGaugeDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.GaugeChart _memoryGauge;

        /*0x733bd80*/ MemoryGaugeDrawerComponent();
        /*0x733bc88*/ void Awake();
        /*0x733bc8c*/ void OnShowMemoryGauge(NoaDebugger.MemoryUnchangingInfo info);
        /*0x733bd74*/ void OnDestroy();
    }

    class MemoryTextDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _memoryCapacityLabel;
        /*0x28*/ TMPro.TextMeshProUGUI _memoryCapacity;
        /*0x30*/ TMPro.TextMeshProUGUI _currentMemoryLabel;
        /*0x38*/ TMPro.TextMeshProUGUI _currentMemory;
        /*0x40*/ TMPro.TextMeshProUGUI _maxAndMinAndAverageMemory;

        /*0x733c54c*/ MemoryTextDrawerComponent();
        /*0x733bd88*/ void Awake();
        /*0x733bd8c*/ void OnShowMemoryText(NoaDebugger.MemoryUnchangingInfo info, System.Nullable<UnityEngine.Color> enableTextColor);
        /*0x733c044*/ void _ShowUnityMemory(NoaDebugger.MemoryUnchangingInfo info);
        /*0x733c1e4*/ void _ShowNativeMemory(NoaDebugger.MemoryUnchangingInfo info);
        /*0x733c354*/ void _ShowMonoMemory(NoaDebugger.MemoryUnchangingInfo info);
        /*0x733c4f4*/ void OnDestroy();
    }

    class RenderingChartDrawerComponent : NoaDebugger.ChartDrawerComponentBase
    {
        static /*0x0*/ System.Collections.Generic.Dictionary<float, string> IntegerValueRulerStringCache;

        static /*0x733c8b0*/ RenderingChartDrawerComponent();
        static /*0x733c608*/ void OnUpdateRenderingChartRulers(float maxValue, float[] positions, string[] labels);
        static /*0x733c778*/ string <OnUpdateRenderingChartRulers>g__toRulerText|3_0(float value);
        /*0x733c8a8*/ RenderingChartDrawerComponent();
        /*0x733c554*/ void OnInitialize();
        /*0x733c5e4*/ void OnShowRenderingChart(NoaDebugger.RenderingUnchangingInfo info);
    }

    class RenderingTextDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _setPassCalls;
        /*0x28*/ TMPro.TextMeshProUGUI _drawCalls;
        /*0x30*/ TMPro.TextMeshProUGUI _batches;
        /*0x38*/ TMPro.TextMeshProUGUI _triangles;
        /*0x40*/ TMPro.TextMeshProUGUI _vertices;

        /*0x733cdd4*/ RenderingTextDrawerComponent();
        /*0x733c948*/ void Awake();
        /*0x733c94c*/ void OnShowRenderingText(NoaDebugger.RenderingUnchangingInfo info, System.Nullable<UnityEngine.Color> enableTextColor);
        /*0x733cd7c*/ void OnDestroy();
    }

    class ThermalTextDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _currentThermal;
        /*0x28*/ TMPro.TextMeshProUGUI _maxAndMinThermal;
        /*0x30*/ TMPro.TextMeshProUGUI _averageThermal;

        /*0x733d35c*/ ThermalTextDrawerComponent();
        /*0x733cddc*/ void Awake();
        /*0x733cde0*/ void OnShowThermalText(NoaDebugger.ThermalUnchangingInfo info, System.Nullable<UnityEngine.Color> enableTextColor);
        /*0x733d324*/ void OnDestroy();
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

        static /*0x733d894*/ ProfilerDrawerHelper();
        static /*0x733cc44*/ void ShowHyphenValue(TMPro.TextMeshProUGUI target);
        static /*0x733d17c*/ void ShowMissingValue(TMPro.TextMeshProUGUI target);
        static /*0x733d364*/ string GetFpsText(int value);
        static /*0x733d40c*/ string GetElapsedTimeText(float value);
        static /*0x733d4b4*/ string GetTotalMemoryLabelText(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
        static /*0x733d5a8*/ string GetCurrentMemoryLabelText(NoaDebugger.NoaProfiler.MemoryProfilingType profilingType);
        static /*0x733d680*/ string GetMemoryMBText(float value);
        static /*0x733cd00*/ string GetRenderingValueText(long current, string max);
        static /*0x733d27c*/ string GetTemperatureText(float value);
        static /*0x733d220*/ string GetMaxMinText(string max, string min);
        static /*0x733d728*/ string GetMaxMinAvgText(string max, string min, string avg);
        static /*0x733d848*/ string GetMemoryProfilingTypeText(object profilingType);
        static /*0x733c738*/ float ToRulerValue(float value);
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

        /*0x7340158*/ ProfilerView();
        /*0x733dc40*/ void add_OnFpsProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x733dcf0*/ void remove_OnFpsProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x733dda0*/ void add_OnFrameTimeProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x733de50*/ void remove_OnFrameTimeProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x733df00*/ void add_OnVSyncCountChanged(UnityEngine.Events.UnityAction<int> value);
        /*0x733dfb4*/ void remove_OnVSyncCountChanged(UnityEngine.Events.UnityAction<int> value);
        /*0x733e068*/ void add_OnTargetFrameRateChanged(UnityEngine.Events.UnityAction<int> value);
        /*0x733e11c*/ void remove_OnTargetFrameRateChanged(UnityEngine.Events.UnityAction<int> value);
        /*0x733e1d0*/ void add_OnMemoryProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x733e284*/ void remove_OnMemoryProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x733e338*/ void add_OnMemoryGraphStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x733e3ec*/ void remove_OnMemoryGraphStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x733e4a0*/ void add_OnMemoryProfilingTypeChanged(UnityEngine.Events.UnityAction<NoaDebugger.NoaProfiler.MemoryProfilingType> value);
        /*0x733e554*/ void remove_OnMemoryProfilingTypeChanged(UnityEngine.Events.UnityAction<NoaDebugger.NoaProfiler.MemoryProfilingType> value);
        /*0x733e608*/ void add_OnGcCollectExecuted(UnityEngine.Events.UnityAction value);
        /*0x733e6a8*/ void remove_OnGcCollectExecuted(UnityEngine.Events.UnityAction value);
        /*0x733e748*/ void add_OnUnloadAssetExecuted(UnityEngine.Events.UnityAction value);
        /*0x733e7e8*/ void remove_OnUnloadAssetExecuted(UnityEngine.Events.UnityAction value);
        /*0x733e888*/ void add_OnRenderingProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x733e93c*/ void remove_OnRenderingProfilingStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x733e9f0*/ void add_OnRenderingGraphStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x733eaa4*/ void remove_OnRenderingGraphStateChanged(UnityEngine.Events.UnityAction<bool> value);
        /*0x733eb58*/ void add_OnRenderingGraphSelected(UnityEngine.Events.UnityAction<NoaDebugger.RenderingGraphTarget> value);
        /*0x733ec0c*/ void remove_OnRenderingGraphSelected(UnityEngine.Events.UnityAction<NoaDebugger.RenderingGraphTarget> value);
        /*0x733ecc0*/ void _Init();
        /*0x733ecc4*/ void _OnStart();
        /*0x733f570*/ void _OnShow(NoaDebugger.ProfilerViewLinker linker);
        /*0x733f650*/ void _OnShowFps(NoaDebugger.FpsUnchangingInfo info);
        /*0x733f748*/ void _OnShowFrameTime(NoaDebugger.ProfilerFrameTimeViewInformation info);
        /*0x733f7b4*/ void _OnShowMemory(NoaDebugger.MemoryUnchangingInfo info);
        /*0x733f970*/ void _OnShowRendering(NoaDebugger.RenderingUnchangingInfo info);
        /*0x733fca8*/ void _OnClickFpsProfiling(bool isOn);
        /*0x733fcc8*/ void _OnClickFrameTimeProfiling(bool isOn);
        /*0x733fce8*/ void _OnVSyncCountChangedChanged(int index);
        /*0x733fd04*/ void _OnTargetFrameRateChanged(int index);
        /*0x733fd20*/ void _OnClickMemoryProfiling(bool isOn);
        /*0x733fd40*/ void _OnClickMemoryGraph(bool isOn);
        /*0x733fd60*/ void _OnClickGcCollect();
        /*0x733fd7c*/ void _OnClickUnloadAsset();
        /*0x733fd98*/ void _OnMemoryProfilingTypeChanged(int index);
        /*0x733fdb4*/ void _OnClickRenderProfiling(bool isOn);
        /*0x733fdd4*/ void _OnClickRenderGraph(bool isOn);
        /*0x733fdf4*/ void _OnClickRenderingCheckbox(bool isOn, NoaDebugger.RenderingGraphTarget target);
        /*0x733fe1c*/ void _OnClickRenderingSetPassCalls(bool isOn);
        /*0x733fe40*/ void _OnClickRenderingDrawCalls(bool isOn);
        /*0x733fe64*/ void _OnClickRenderingBatches(bool isOn);
        /*0x733fe88*/ void _OnClickRenderingTriangles(bool isOn);
        /*0x733feac*/ void _OnClickRenderingVertices(bool isOn);
        /*0x733f4e4*/ void _SetDropdown(string[] optionNames, TMPro.TMP_Dropdown target, UnityEngine.Events.UnityAction<int> onChanged, int defaultIndex);
        /*0x733fb14*/ void _SetDropdownOptions(string[] optionNames, TMPro.TMP_Dropdown target, int defaultIndex);
        /*0x733fed0*/ void SetGcCollectButtonInteractable(bool interactable);
        /*0x733fef0*/ void SetUnloadAssetButtonInteractable(bool interactable);
        /*0x733ff10*/ void OnDestroy();
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

        /*0x73401a0*/ ProfilerViewLinker();
    }

    class ProfilerFrameTimeViewInformation
    {
        /*0x10*/ NoaDebugger.RingBuffer<System.Single[]> _histories;
        /*0x18*/ bool _isEnabled;
        /*0x19*/ bool _isActive;

        /*0x73401b0*/ ProfilerFrameTimeViewInformation();
    }

    class CategoryKeyValue : UnityEngine.MonoBehaviour
    {
        /*0x20*/ NoaDebugger.NoaDebuggerText _key;
        /*0x28*/ NoaDebugger.NoaDebuggerText _value;

        /*0x734042c*/ CategoryKeyValue();
        /*0x73401b8*/ void Init(NoaDebugger.NoaSnapshotCategoryItem item);
        /*0x734024c*/ UnityEngine.Color _LogFontColorToColor(NoaDebugger.NoaSnapshot.FontColor color);
        /*0x7340404*/ void OnDestroy();
    }

    class SnapshotAdditionalInfoView : NoaDebugger.ViewBase<NoaDebugger.SnapshotAdditionalInfoViewLinker>
    {
        /*0x20*/ NoaDebugger.NoaDebuggerText _category;
        /*0x28*/ UnityEngine.GameObject _keyValueRoot;
        /*0x30*/ NoaDebugger.CategoryKeyValue _keyValuePrefab;

        /*0x7340748*/ SnapshotAdditionalInfoView();
        /*0x7340434*/ void _OnShow(NoaDebugger.SnapshotAdditionalInfoViewLinker linker);
        /*0x73406a8*/ void _OnHide();
        /*0x7340710*/ void OnDestroy();
    }

    class SnapshotAdditionalInfoViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ string _category;
        /*0x18*/ System.Collections.Generic.List<NoaDebugger.NoaSnapshotCategoryItem> _categoryItems;

        /*0x7340790*/ SnapshotAdditionalInfoViewLinker();
    }

    class SnapshotFpsTextDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _currentFps;
        /*0x28*/ TMPro.TextMeshProUGUI _maxAndMinFps;
        /*0x30*/ TMPro.TextMeshProUGUI _averageFps;

        /*0x7340a88*/ SnapshotFpsTextDrawerComponent();
        /*0x7340798*/ void Awake();
        /*0x734079c*/ void OnShowFpsText(NoaDebugger.FpsUnchangingInfo info, System.Nullable<UnityEngine.Color> enableTextColor);
        /*0x7340a50*/ void OnDestroy();
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

        /*0x73411f0*/ SnapshotLogCellView();
        /*0x7340a90*/ void _Init();
        /*0x7340dc8*/ void _OnShow(NoaDebugger.SnapshotLogCellViewLinker linker);
        /*0x7341124*/ void _OnClickCell();
        /*0x734114c*/ void _OnClickCellLabel(string text);
        /*0x7341174*/ void _OnLongTapCell();
        /*0x734119c*/ void _OnUpdateLabel(string text);
        /*0x73411c8*/ void _OnToggleChange(bool isOn);
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

        /*0x7341238*/ SnapshotLogCellViewLinker();
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

        /*0x73421fc*/ SnapshotLogDetailView();
        /*0x7341240*/ UnityEngine.Events.UnityAction<int> get_OnClickCopyButton();
        /*0x7341248*/ void set_OnClickCopyButton(UnityEngine.Events.UnityAction<int> value);
        /*0x7341250*/ void Awake();
        /*0x73412f8*/ void _OnShow(NoaDebugger.SnapshotViewLinker linker);
        /*0x7341cdc*/ void _OnShowProfilingInfo(NoaDebugger.ProfilerSnapshotData snapshotData);
        /*0x73420a8*/ void OnDestroy();
        /*0x73421a0*/ void _OnCopy();

        class <>c__DisplayClass22_0
        {
            /*0x10*/ bool isComparison;
            /*0x18*/ NoaDebugger.SnapshotLogDetailView <>4__this;

            /*0x7341cd4*/ <>c__DisplayClass22_0();
            /*0x7342244*/ bool <_OnShow>b__0(NoaDebugger.SnapshotLogRecordInformation logData);
        }
    }

    class SnapshotMemoryTextDrawerComponent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _memoryCapacityLabel;
        /*0x28*/ TMPro.TextMeshProUGUI _memoryCapacity;
        /*0x30*/ TMPro.TextMeshProUGUI _currentMemory;
        /*0x38*/ TMPro.TextMeshProUGUI _maxAndMinMemory;
        /*0x40*/ TMPro.TextMeshProUGUI _averageMemory;

        /*0x734274c*/ SnapshotMemoryTextDrawerComponent();
        /*0x7342290*/ void Awake();
        /*0x7341e00*/ void OnShowMemoryText(NoaDebugger.MemoryUnchangingInfo info, System.Nullable<UnityEngine.Color> enableTextColor);
        /*0x7342294*/ void _ShowUnityMemory(NoaDebugger.MemoryUnchangingInfo info);
        /*0x734240c*/ void _ShowNativeMemory(NoaDebugger.MemoryUnchangingInfo info);
        /*0x734257c*/ void _ShowMonoMemory(NoaDebugger.MemoryUnchangingInfo info);
        /*0x73426f4*/ void OnDestroy();
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

        /*0x7343f38*/ SnapshotView();
        /*0x7342754*/ void add_OnInsertLog(UnityEngine.Events.UnityAction value);
        /*0x73427f0*/ void remove_OnInsertLog(UnityEngine.Events.UnityAction value);
        /*0x734288c*/ void add_OnToggleChanged(UnityEngine.Events.UnityAction<int> value);
        /*0x734293c*/ void remove_OnToggleChanged(UnityEngine.Events.UnityAction<int> value);
        /*0x73429ec*/ void add_OnClearAllLog(UnityEngine.Events.UnityAction value);
        /*0x7342a88*/ void remove_OnClearAllLog(UnityEngine.Events.UnityAction value);
        /*0x7342b24*/ void add_OnUpdateLogLabel(UnityEngine.Events.UnityAction<int, string> value);
        /*0x7342bd4*/ void remove_OnUpdateLogLabel(UnityEngine.Events.UnityAction<int, string> value);
        /*0x7342c84*/ void add_OnClickLog(UnityEngine.Events.UnityAction<int> value);
        /*0x7342d34*/ void remove_OnClickLog(UnityEngine.Events.UnityAction<int> value);
        /*0x7342de4*/ void add_OnLongTapLog(UnityEngine.Events.UnityAction<int> value);
        /*0x7342e94*/ void remove_OnLongTapLog(UnityEngine.Events.UnityAction<int> value);
        /*0x7342f44*/ void add_OnDownloadLog(UnityEngine.Events.UnityAction value);
        /*0x7342fe0*/ void remove_OnDownloadLog(UnityEngine.Events.UnityAction value);
        /*0x734307c*/ void add_OnComparison(UnityEngine.Events.UnityAction value);
        /*0x7343118*/ void remove_OnComparison(UnityEngine.Events.UnityAction value);
        /*0x73431b4*/ void add_OnClickCopyButton(UnityEngine.Events.UnityAction<int> value);
        /*0x7343264*/ void remove_OnClickCopyButton(UnityEngine.Events.UnityAction<int> value);
        /*0x7343314*/ void _Init();
        /*0x73435d8*/ void _OnShow(NoaDebugger.SnapshotViewLinker linker);
        /*0x7343ba8*/ void ShowOnUpdate(NoaDebugger.SnapshotViewLinker linker);
        /*0x734353c*/ void _RefreshLogDetailView(bool isView);
        /*0x73439ec*/ void UpdateSnapshotDetail(NoaDebugger.SnapshotViewLinker linker, bool isComparison);
        /*0x7343c60*/ void _OnClickAllClearButton();
        /*0x7343c7c*/ void _OnClickDownloadButton();
        /*0x7343c98*/ void _OnClickTakeButton();
        /*0x7343cb4*/ void _OnClickComparisonButton();
        /*0x7343cd0*/ void _RefreshPanel(int index, UnityEngine.GameObject target);
        /*0x7343e9c*/ NoaDebugger.SnapshotModel.ToggleState _ToggleState(NoaDebugger.SnapshotLogRecordInformation record);
        /*0x7343c28*/ void _ShowByElapsedTime(System.TimeSpan elapsedTime);
        /*0x7343858*/ void _ShowByLogDataList(System.Collections.Generic.List<NoaDebugger.SnapshotLogRecordInformation> logDataList, bool isNeedResetScrollPos);
        /*0x7343aa0*/ bool _IsToggleSelectMax();

        class <>c
        {
            static /*0x0*/ NoaDebugger.SnapshotView.<> <>9;
            static /*0x8*/ System.Func<NoaDebugger.SnapshotLogRecordInformation, bool> <>9__42_0;
            static /*0x10*/ System.Func<NoaDebugger.SnapshotLogRecordInformation, bool> <>9__54_0;

            static /*0x7343f88*/ <>c();
            /*0x7343ff0*/ <>c();
            /*0x7343ff8*/ bool <_OnShow>b__42_0(NoaDebugger.SnapshotLogRecordInformation logData);
            /*0x7344010*/ bool <_IsToggleSelectMax>b__54_0(NoaDebugger.SnapshotLogRecordInformation log);
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

        /*0x7344034*/ SnapshotViewLinker();
    }

    class ToastView : NoaDebugger.ViewBase<NoaDebugger.ToastViewLinker>
    {
        /*0x20*/ TMPro.TextMeshProUGUI _label;
        /*0x28*/ UnityEngine.Animator _animator;
        /*0x30*/ UnityEngine.CanvasGroup _canvasGroup;
        /*0x38*/ bool _playAnim;

        /*0x73442ec*/ ToastView();
        /*0x7344050*/ void SetVisibility(bool visible);
        /*0x73440a0*/ void _Init();
        /*0x73440f8*/ void _OnShow(NoaDebugger.ToastViewLinker linker);
        /*0x73441a0*/ void _OnHide();
        /*0x734422c*/ void Update();
    }

    class ToastViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ string _label;

        /*0x7344334*/ ToastViewLinker();
    }

    class SaveDataContent : UnityEngine.MonoBehaviour
    {
        /*0x20*/ UnityEngine.Transform _keyRoot;
        /*0x28*/ NoaDebugger.SaveDataKeyPanel _keyPanel;
        /*0x30*/ UnityEngine.UI.Button _allClearButton;
        /*0x38*/ System.Collections.Generic.List<NoaDebugger.SaveDataKeyPanel> _keyPanels;

        /*0x7344d94*/ SaveDataContent();
        /*0x734433c*/ void _OnValidate();
        /*0x7344340*/ void Show(string[] targetKeys);
        /*0x73448e4*/ void _RemoveAt(NoaDebugger.SaveDataKeyPanel panel);
        /*0x7344afc*/ void _RemoveAllKeys();
        /*0x7344a60*/ void _RefreshPanels();
        /*0x7344584*/ void _DestroyPanels();
        /*0x7344d4c*/ void OnDestroy();
    }

    class SaveDataKeyPanel : UnityEngine.MonoBehaviour
    {
        /*0x20*/ TMPro.TextMeshProUGUI _keyLabel;
        /*0x28*/ NoaDebugger.LongTapButton _removeButton;
        /*0x30*/ UnityEngine.GameObject _background;
        /*0x38*/ string <Key>k__BackingField;
        /*0x40*/ System.Action<NoaDebugger.SaveDataKeyPanel> OnRemove;

        /*0x7344f58*/ SaveDataKeyPanel();
        /*0x7344e1c*/ void set_Key(string value);
        /*0x7344e24*/ string get_Key();
        /*0x7344738*/ void add_OnRemove(System.Action<NoaDebugger.SaveDataKeyPanel> value);
        /*0x7344e2c*/ void remove_OnRemove(System.Action<NoaDebugger.SaveDataKeyPanel> value);
        /*0x7344edc*/ void _OnValidate();
        /*0x73447e8*/ void Show(string key, bool isShowBackground);
        /*0x7344d2c*/ void Refresh(bool isShowBackground);
        /*0x7344ee0*/ void _OnRemoveLongTap();
        /*0x7344f00*/ void OnDestroy();
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

        /*0x7345318*/ ToolDetailView();
        /*0x7344f60*/ void _OnShow(NoaDebugger.ToolDetailViewLinker linker);
        /*0x7345088*/ void _ShowNoaPrefsSaveDataContent();
        /*0x734514c*/ void _ShowDebugCommandPropertySaveDataContent();
        /*0x7345210*/ void _ShowToolSaveDataContent();
        /*0x734529c*/ void _OnHide();
        /*0x73452c0*/ void OnDestroy();
    }

    class ToolDetailViewLinker : NoaDebugger.ViewLinkerBase
    {
        /*0x10*/ string _operatingEnv;
        /*0x18*/ System.Collections.Generic.Dictionary<string, string> _shortcutKeyMappings;
        /*0x20*/ string _copyright;

        /*0x7345360*/ ToolDetailViewLinker();
    }

    class ViewBase<T> : UnityEngine.MonoBehaviour
    {
        static string DESTROY_TARGET_VIEW = "FloatingWindow";

        /*0x38159dc*/ ViewBase();
        /*0x38159dc*/ void Awake();
        /*0x38159dc*/ void Start();
        /*0x38159dc*/ void _Init();
        /*0x38159dc*/ void _OnStart();
        /*0x3910ae8*/ void Show(T linker);
        /*0x3910ae8*/ void _OnShow(T linker);
        /*0x38159dc*/ void Hide();
        /*0x38159dc*/ void _OnHide();
        /*0x3816710*/ void _CaughtThrow(System.Exception e);
    }

    class ViewLinkerBase
    {
        /*0x73401a8*/ ViewLinkerBase();
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

            static /*0x7348e40*/ NoaDebugger.DebugCommand.DebugCommandModel.CommandCategory _CreateCommandCategory(System.Collections.Generic.IEnumerable<NoaDebugger.DebugCommand.ICommand> commands, string displayName, object instance);
            /*0x7345510*/ DebugCommandModel();
            /*0x7345368*/ string[] get_CategoryNames();
            /*0x73453d4*/ string[] get_CategoryDisplayNames();
            /*0x73454f4*/ bool get_IsAutoRefresh();
            /*0x73456fc*/ void Dispose();
            /*0x73457d0*/ void _OnAddCategory();
            /*0x7346948*/ System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommand.CommandGroupData> GetGroupsForCategory(string categoryName);
            /*0x7346a0c*/ object GetInstance(string categoryName);
            /*0x7346a90*/ void RefreshCategoryFirst();
            /*0x7346abc*/ void SetInteractable(string categoryName, string commandTag, bool isInteractable);
            /*0x7346db4*/ bool IsInteractable(string categoryName, string commandTag);
            /*0x7346f00*/ void SetVisible(string categoryName, string commandTag, bool isVisible);
            /*0x73471f8*/ bool IsVisible(string categoryName, string commandTag);
            /*0x7347344*/ void UpdateAutoRefresh(bool isAutoRefresh);
            /*0x734739c*/ void _OnUpdate();
            /*0x73457e8*/ void _AddMemberInfoCommands();
            /*0x7346280*/ void _AddDynamicCommands();

            class CommandCategory
            {
                /*0x10*/ string _displayName;
                /*0x18*/ System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommand.CommandGroupData> _groupedCommands;
                /*0x20*/ System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommand.CommandGroupData> _taggedCommands;
                /*0x28*/ System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommand.DebugCommandModel.TaggedCommandState> _taggedCommandStates;
                /*0x30*/ object _categoryInstance;

                /*0x7349afc*/ CommandCategory();
            }

            class TaggedCommandState
            {
                /*0x10*/ bool <IsInteractable>k__BackingField;
                /*0x11*/ bool <IsVisible>k__BackingField;

                /*0x7349c04*/ TaggedCommandState();
                /*0x7349c14*/ bool get_IsInteractable();
                /*0x7349c1c*/ void set_IsInteractable(bool value);
                /*0x7349c28*/ bool get_IsVisible();
                /*0x7349c30*/ void set_IsVisible(bool value);
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

                static /*0x7349c3c*/ <>c();
                /*0x7349ca4*/ <>c();
                /*0x7349cac*/ string <get_CategoryDisplayNames>b__7_0(System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommand.DebugCommandModel.CommandCategory> x);
                /*0x7349cf0*/ string <_AddMemberInfoCommands>b__25_0(System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommand.DebugCommandModel.CommandCategory> entry);
                /*0x7349d2c*/ NoaDebugger.DebugCommand.DebugCommandModel.CommandCategory <_AddMemberInfoCommands>b__25_1(System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommand.DebugCommandModel.CommandCategory> entry);
                /*0x7349d68*/ int <_AddMemberInfoCommands>b__25_2(System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommandRegister.DebugCategory> category);
                /*0x7349da4*/ NoaDebugger.DebugCommand.ICommand <_AddDynamicCommands>b__26_0(NoaDebugger.CommandDefinition commandDefinition);
                /*0x7349dc8*/ bool <_AddDynamicCommands>b__26_1(NoaDebugger.DebugCommand.ICommand command);
                /*0x7349dd4*/ int <_CreateCommandCategory>b__27_0(NoaDebugger.DebugCommand.ICommand command);
            }
        }

        class CommandGroupData
        {
            /*0x10*/ bool _isCollapsed;
            /*0x14*/ System.Nullable<int> _order;
            /*0x20*/ System.Collections.Generic.List<NoaDebugger.DebugCommand.ICommand> _commandList;

            /*0x7349bfc*/ CommandGroupData();
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

            static /*0x734da90*/ DebugCommandPresenter();
            static /*0x7349e7c*/ bool get_IsAutoRefresh();
            static /*0x7349f7c*/ void set_IsAutoRefresh(bool value);
            static /*0x734a158*/ void add_OnRefreshProperty(System.Action value);
            static /*0x734a234*/ void remove_OnRefreshProperty(System.Action value);
            static /*0x734d004*/ void RefreshView();
            static /*0x734d138*/ void RefreshProperty();
            static /*0x734d3f8*/ object GetCategoryInstance(string categoryName);
            static /*0x734d468*/ string[] GetCategoryNames();
            static /*0x734d538*/ string[] GetDisplayCategoryNames();
            static /*0x734d608*/ System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommand.CommandGroupData> GetCategoryGroup(string categoryName);
            static /*0x734d6e0*/ void SetCommandInteractable(string categoryName, string commandTag, bool isInteractable);
            static /*0x734d768*/ bool IsCommandInteractable(string categoryName, string commandTag);
            static /*0x734d7e8*/ void SetCommandVisible(string categoryName, string commandTag, bool isVisible);
            static /*0x734d870*/ bool IsCommandVisible(string categoryName, string commandTag);
            static /*0x734d8f0*/ NoaDebugger.DebugCommand.CommandDisplayFormat GetCurrentFormat();
            /*0x734da00*/ DebugCommandPresenter();
            /*0x7349e74*/ NoaDebugger.ToolNotificationStatus get_NotifyStatus();
            /*0x734a310*/ void Init();
            /*0x734a784*/ NoaDebugger.IMenuInfo MenuInfo();
            /*0x734a7fc*/ void ShowView(UnityEngine.Transform parent);
            /*0x734a8f8*/ void _InitView(NoaDebugger.DebugCommand.DebugCommandView view);
            /*0x734aac0*/ void _HiddenView();
            /*0x734ab54*/ void _RefreshViewOnUpdate();
            /*0x734a090*/ void _UpdateView(NoaDebugger.DebugCommand.CommandViewUpdateTarget updateTarget, bool isUpdateMainView);
            /*0x734ace0*/ void _UpdateMainView(string category, NoaDebugger.DebugCommand.CommandViewUpdateTarget updateTarget);
            /*0x734aea8*/ void _UpdateFloatingWindow(string category, NoaDebugger.DebugCommand.CommandViewUpdateTarget updateTarget);
            /*0x734abc4*/ int _GetCategoryIndex();
            /*0x734b2e8*/ NoaDebugger.DebugCommand.GroupPanelInfo[] _CreateGroups(string category, System.Collections.Generic.Dictionary<string, NoaDebugger.DebugCommand.CommandGroupData> groupDic);
            /*0x734bb18*/ void _OnSelectCategory(int index);
            /*0x734bc44*/ void _OnRefreshView(bool isAutoRefresh);
            /*0x734bcf0*/ void _OnAutoRefreshView();
            /*0x734bcc4*/ void _OnUpdateAutoRefreshState();
            /*0x734bd40*/ void _OnAutoRefreshStateChanged(bool isAutoRefresh);
            /*0x734be80*/ void _OnSelectGroupForCollapse(string group, bool isOn);
            /*0x734bf38*/ void _OnSelectGroupForFloatingWindow(string group, bool isOn);
            /*0x734c580*/ void _OnSelectAllGroupForFloatingWindow(bool isOn);
            /*0x734c798*/ void _OnDisplayDetailsToggle(bool isOn);
            /*0x734c7ac*/ void _OnSelectGroupForDetail(NoaDebugger.DebugCommand.GroupPanelInfo group, bool isOn);
            /*0x734c948*/ void _OnSelectCommandForDetail(NoaDebugger.DebugCommand.ICommand command, bool isOn);
            /*0x734c884*/ void _UpdateDetailInfo(string groupName, string commandName, NoaDebugger.DebugCommand.ICommand[] commands, System.Nullable<NoaDebugger.DebugCommand.CommandViewUpdateTarget> updateTarget);
            /*0x734bc30*/ void _ResetDetailInfo(System.Nullable<NoaDebugger.DebugCommand.CommandViewUpdateTarget> updateTarget);
            /*0x734cc34*/ void AlignmentUI(bool isReverse);
            /*0x734cc58*/ bool GetPinStatus();
            /*0x734cca8*/ void TogglePin(UnityEngine.Transform parent);
            /*0x734cd10*/ void InitFloatingWindow(UnityEngine.Transform parent);
            /*0x734cd9c*/ void _InitFloatingWindow(NoaDebugger.DebugCommand.DebugCommandFloatingWindowView window);
            /*0x734ce3c*/ void OnHidden();
            /*0x734cf6c*/ void OnToolDispose();
            /*0x734ceb4*/ void _OnHiddenPresenter();
            /*0x734c260*/ void _SaveFilter();
            /*0x734a5d0*/ void _LoadFilter();
            /*0x734d978*/ void OnDestroy();

            class CommandMenuInfo : NoaDebugger.IMenuInfo
            {
                /*0x734a7f4*/ CommandMenuInfo();
                /*0x734dafc*/ string get_Name();
                /*0x734db3c*/ string get_MenuName();
                /*0x734db7c*/ int get_SortNo();
            }

            class GroupFilter
            {
                /*0x10*/ string _categoryName;
                /*0x18*/ string[] _removeGroupsJson;

                /*0x734d970*/ GroupFilter();
            }

            class GroupFilterArray
            {
                /*0x10*/ string[] _groupFilterJson;

                /*0x734d968*/ GroupFilterArray();
            }

            class <>c
            {
                static /*0x0*/ NoaDebugger.DebugCommand.DebugCommandPresenter.<> <>9;
                static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommand.CommandGroupData>, int> <>9__36_0;

                static /*0x734db84*/ <>c();
                /*0x734dbec*/ <>c();
                /*0x734dbf4*/ int <_CreateGroups>b__36_0(System.Collections.Generic.KeyValuePair<string, NoaDebugger.DebugCommand.CommandGroupData> x);
            }

            class <>c__DisplayClass43_0
            {
                /*0x10*/ string group;

                /*0x734c258*/ <>c__DisplayClass43_0();
                /*0x734dc5c*/ bool <_OnSelectGroupForFloatingWindow>b__0(string target);
            }
        }

        class BoolPropertyCommandBuilder : NoaDebugger.DebugCommand.MutablePropertyCommandBuilderBase<bool>
        {
            /*0x734dc70*/ BoolPropertyCommandBuilder(string categoryName, string displayName, System.Func<bool> getter, System.Action<bool> setter, System.Attribute[] attributes, string saveKey);
            /*0x734dd00*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class BytePropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<byte>
        {
            /*0x734df58*/ BytePropertyCommandBuilder(string categoryName, string displayName, System.Func<byte> getter, System.Action<byte> setter, System.Attribute[] attributes, string saveKey);
            /*0x734dfe8*/ void PeekAttribute(System.Attribute attribute);
            /*0x734e140*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x734e4c0*/ System.Nullable<byte> TryParse(object value);
        }

        class CharPropertyCommandBuilder : NoaDebugger.DebugCommand.MutablePropertyCommandBuilderBase<char>
        {
            /*0x734e550*/ CharPropertyCommandBuilder(string categoryName, string displayName, System.Func<char> getter, System.Action<char> setter, System.Attribute[] attributes, string saveKey);
            /*0x734e5e0*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
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

            /*0x734e898*/ CommandBuilderBase(string categoryName, string displayName, System.Attribute[] attributes);
            /*0x734e838*/ string get_CategoryName();
            /*0x734e840*/ string get_DisplayName();
            /*0x734e848*/ string get_GroupName();
            /*0x734e850*/ void set_GroupName(string value);
            /*0x734e858*/ System.Nullable<int> get_GroupOrder();
            /*0x734e860*/ void set_GroupOrder(System.Nullable<int> value);
            /*0x734e868*/ string get_TagName();
            /*0x734e870*/ void set_TagName(string value);
            /*0x734e878*/ string get_Description();
            /*0x734e880*/ void set_Description(string value);
            /*0x734e888*/ System.Nullable<int> get_Order();
            /*0x734e890*/ void set_Order(System.Nullable<int> value);
            /*0x734e8f8*/ NoaDebugger.DebugCommand.ICommand Build();
            /*0x734eb34*/ void PeekAttribute(System.Attribute attribute);
            /*0x38148bc*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class CoroutineCommandBuilder : NoaDebugger.DebugCommand.CommandBuilderBase
        {
            /*0x50*/ System.Func<System.Collections.IEnumerator> _coroutine;

            /*0x734eb38*/ CoroutineCommandBuilder(string categoryName, string displayName, System.Func<System.Collections.IEnumerator> coroutine, System.Attribute[] attributes);
            /*0x734eb68*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class DecimalPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<decimal>
        {
            /*0xb0*/ int _needDigits;

            /*0x734ec64*/ DecimalPropertyCommandBuilder(string categoryName, string displayName, System.Func<decimal> getter, System.Action<decimal> setter, System.Attribute[] attributes, string saveKey);
            /*0x734ecf4*/ void PeekAttribute(System.Attribute attribute);
            /*0x734ee70*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x734f2f8*/ System.Nullable<decimal> TryParse(object value);
        }

        class DoublePropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<double>
        {
            /*0x98*/ int _needDigits;

            /*0x734f480*/ DoublePropertyCommandBuilder(string categoryName, string displayName, System.Func<double> getter, System.Action<double> setter, System.Attribute[] attributes, string saveKey);
            /*0x734f510*/ void PeekAttribute(System.Attribute attribute);
            /*0x734f620*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x734f9c4*/ System.Nullable<double> TryParse(object value);
        }

        class EnumPropertyCommandBuilder : NoaDebugger.DebugCommand.MutablePropertyCommandBuilderBase<System.Enum>
        {
            /*0x68*/ System.Type _enumType;

            /*0x734faf0*/ EnumPropertyCommandBuilder(string categoryName, string displayName, System.Func<System.Enum> getter, System.Action<System.Enum> setter, System.Type type, System.Attribute[] attributes, string saveKey);
            /*0x734fb9c*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class FloatPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<float>
        {
            /*0x80*/ int _needDigits;

            /*0x734fe54*/ FloatPropertyCommandBuilder(string categoryName, string displayName, System.Func<float> getter, System.Action<float> setter, System.Attribute[] attributes, string saveKey);
            /*0x734fee4*/ void PeekAttribute(System.Attribute attribute);
            /*0x734ffec*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x7350368*/ System.Nullable<float> TryParse(object value);
        }

        class GetOnlyPropertyCommandBuilder : NoaDebugger.DebugCommand.CommandBuilderBase
        {
            /*0x50*/ System.Func<object> _getter;

            /*0x7350498*/ GetOnlyPropertyCommandBuilder(string categoryName, string displayName, System.Func<object> getter, System.Attribute[] attributes);
            /*0x73504c8*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class HandleMethodCommandBuilder : NoaDebugger.DebugCommand.CommandBuilderBase
        {
            /*0x50*/ System.Func<NoaDebugger.MethodHandler> _method;

            /*0x73505bc*/ HandleMethodCommandBuilder(string categoryName, string displayName, System.Func<NoaDebugger.MethodHandler> method, System.Attribute[] attributes);
            /*0x73505ec*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class IntPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<int>
        {
            /*0x73506e8*/ IntPropertyCommandBuilder(string categoryName, string displayName, System.Func<int> getter, System.Action<int> setter, System.Attribute[] attributes, string saveKey);
            /*0x7350778*/ void PeekAttribute(System.Attribute attribute);
            /*0x735087c*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x7350bec*/ System.Nullable<int> TryParse(object value);
        }

        class LongPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<long>
        {
            /*0x7350c84*/ LongPropertyCommandBuilder(string categoryName, string displayName, System.Func<long> getter, System.Action<long> setter, System.Attribute[] attributes, string saveKey);
            /*0x7350d14*/ void PeekAttribute(System.Attribute attribute);
            /*0x7350e24*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x7350f2c*/ System.Nullable<long> TryParse(object value);
        }

        class MethodCommandBuilder : NoaDebugger.DebugCommand.CommandBuilderBase
        {
            /*0x50*/ System.Action _method;

            /*0x7350fc0*/ MethodCommandBuilder(string categoryName, string displayName, System.Action method, System.Attribute[] attributes);
            /*0x7350ff0*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class MutableNumericPropertyCommandBuilderBase<T> : NoaDebugger.DebugCommand.MutablePropertyCommandBuilderBase<T>
        {
            /*0x0*/ System.Nullable<T> _inputRangeMin;
            /*0x0*/ System.Nullable<T> _inputRangeMax;
            /*0x0*/ System.Nullable<T> _increment;

            /*0x3816a14*/ MutableNumericPropertyCommandBuilderBase(string categoryName, string displayName, System.Func<T> getter, System.Action<T> setter, System.Attribute[] attributes, string saveKey);
            /*0x3816710*/ void PeekAttribute(System.Attribute attribute);
            /*0x3910ae8*/ System.Nullable<T> TryParse(object value);
            /*0x38159dc*/ void SendIncrementWarning();
        }

        class MutablePropertyCommandBuilderBase<T> : NoaDebugger.DebugCommand.CommandBuilderBase
        {
            /*0x0*/ System.Func<T> <Getter>k__BackingField;
            /*0x0*/ System.Action<T> <Setter>k__BackingField;
            /*0x0*/ string <SaveKey>k__BackingField;

            /*0x3816a14*/ MutablePropertyCommandBuilderBase(string categoryName, string displayName, System.Func<T> getter, System.Action<T> setter, System.Attribute[] attributes, string saveKey);
            /*0x38148bc*/ System.Func<T> get_Getter();
            /*0x38148bc*/ System.Action<T> get_Setter();
            /*0x38148bc*/ string get_SaveKey();
        }

        class SBytePropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<sbyte>
        {
            /*0x7351094*/ SBytePropertyCommandBuilder(string categoryName, string displayName, System.Func<sbyte> getter, System.Action<sbyte> setter, System.Attribute[] attributes, string saveKey);
            /*0x7351124*/ void PeekAttribute(System.Attribute attribute);
            /*0x735127c*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x735136c*/ System.Nullable<sbyte> TryParse(object value);
        }

        class ShortPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<short>
        {
            /*0x73513fc*/ ShortPropertyCommandBuilder(string categoryName, string displayName, System.Func<short> getter, System.Action<short> setter, System.Attribute[] attributes, string saveKey);
            /*0x735148c*/ void PeekAttribute(System.Attribute attribute);
            /*0x73515e4*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x73516d0*/ System.Nullable<short> TryParse(object value);
        }

        class StringPropertyCommandBuilder : NoaDebugger.DebugCommand.MutablePropertyCommandBuilderBase<string>
        {
            /*0x68*/ System.Nullable<int> _characterLimit;

            /*0x7351760*/ StringPropertyCommandBuilder(string categoryName, string displayName, System.Func<string> getter, System.Action<string> setter, System.Attribute[] attributes, string saveKey);
            /*0x73517f0*/ void PeekAttribute(System.Attribute attribute);
            /*0x735189c*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
        }

        class UIntPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<uint>
        {
            /*0x735197c*/ UIntPropertyCommandBuilder(string categoryName, string displayName, System.Func<uint> getter, System.Action<uint> setter, System.Attribute[] attributes, string saveKey);
            /*0x7351a0c*/ void PeekAttribute(System.Attribute attribute);
            /*0x7351b10*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x7351bfc*/ System.Nullable<uint> TryParse(object value);
        }

        class ULongPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<ulong>
        {
            /*0x7351c94*/ ULongPropertyCommandBuilder(string categoryName, string displayName, System.Func<ulong> getter, System.Action<ulong> setter, System.Attribute[] attributes, string saveKey);
            /*0x7351d24*/ void PeekAttribute(System.Attribute attribute);
            /*0x7351e30*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x7351f38*/ System.Nullable<ulong> TryParse(object value);
        }

        class UShortPropertyCommandBuilder : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBuilderBase<ushort>
        {
            /*0x7351fcc*/ UShortPropertyCommandBuilder(string categoryName, string displayName, System.Func<ushort> getter, System.Action<ushort> setter, System.Attribute[] attributes, string saveKey);
            /*0x735205c*/ void PeekAttribute(System.Attribute attribute);
            /*0x73521b4*/ NoaDebugger.DebugCommand.ICommand BuildCommand();
            /*0x73522a0*/ System.Nullable<ushort> TryParse(object value);
        }

        class CommandFactory
        {
            static /*0x73477c4*/ NoaDebugger.DebugCommand.ICommand CreateCommand(object obj, System.Reflection.PropertyInfo property, string categoryName);
            static /*0x73473b8*/ NoaDebugger.DebugCommand.ICommand CreateCommand(object obj, System.Reflection.MethodInfo method, string categoryName);
            static /*0x7352338*/ string GetDisplayName(System.Reflection.MemberInfo member);

            class <>c__DisplayClass0_0
            {
                /*0x10*/ System.Reflection.PropertyInfo property;
                /*0x18*/ object obj;

                /*0x7352330*/ <>c__DisplayClass0_0();
                /*0x7352420*/ object <CreateCommand>b__0();
                /*0x7352444*/ string <CreateCommand>b__1();
                /*0x735248c*/ void <CreateCommand>b__2(string value);
                /*0x73524b4*/ sbyte <CreateCommand>b__3();
                /*0x735250c*/ void <CreateCommand>b__4(sbyte value);
                /*0x7352558*/ byte <CreateCommand>b__5();
                /*0x73525b0*/ void <CreateCommand>b__6(byte value);
                /*0x73525fc*/ short <CreateCommand>b__7();
                /*0x7352654*/ void <CreateCommand>b__8(short value);
                /*0x73526a0*/ ushort <CreateCommand>b__9();
                /*0x73526f8*/ void <CreateCommand>b__10(ushort value);
                /*0x7352744*/ int <CreateCommand>b__11();
                /*0x735279c*/ void <CreateCommand>b__12(int value);
                /*0x73527e8*/ uint <CreateCommand>b__13();
                /*0x7352840*/ void <CreateCommand>b__14(uint value);
                /*0x735288c*/ long <CreateCommand>b__15();
                /*0x73528e4*/ void <CreateCommand>b__16(long value);
                /*0x7352930*/ ulong <CreateCommand>b__17();
                /*0x7352988*/ void <CreateCommand>b__18(ulong value);
                /*0x73529d4*/ char <CreateCommand>b__19();
                /*0x7352a2c*/ void <CreateCommand>b__20(char value);
                /*0x7352a78*/ float <CreateCommand>b__21();
                /*0x7352ad0*/ void <CreateCommand>b__22(float value);
                /*0x7352b1c*/ double <CreateCommand>b__23();
                /*0x7352b74*/ void <CreateCommand>b__24(double value);
                /*0x7352bc0*/ decimal <CreateCommand>b__25();
                /*0x7352c44*/ void <CreateCommand>b__26(decimal value);
                /*0x7352cf4*/ bool <CreateCommand>b__27();
                /*0x7352d4c*/ void <CreateCommand>b__28(bool value);
                /*0x7352d9c*/ System.Enum <CreateCommand>b__29();
                /*0x7352e00*/ void <CreateCommand>b__30(System.Enum value);
            }

            class <>c__DisplayClass1_0
            {
                /*0x10*/ System.Reflection.MethodInfo method;
                /*0x18*/ object obj;

                /*0x7352418*/ <>c__DisplayClass1_0();
                /*0x7352e28*/ void <CreateCommand>b__0();
                /*0x7352e50*/ System.Collections.IEnumerator <CreateCommand>b__1();
                /*0x7352ed0*/ NoaDebugger.MethodHandler <CreateCommand>b__2();
            }
        }

        class BoolPropertyCommand : NoaDebugger.DebugCommand.MutablePropertyCommandBase<bool>
        {
            /*0x734ddd4*/ BoolPropertyCommand(string displayName, System.Func<bool> getter, System.Action<bool> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey);
            /*0x7352f60*/ string get_TypeName();
            /*0x73530b8*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7352fa0*/ bool GetValue();
            /*0x7352fe8*/ void SetValue(bool value);
        }

        class BytePropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<byte>
        {
            static /*0x0*/ byte DEFAULT_INPUT_RANGE_MIN;
            static /*0x1*/ byte DEFAULT_INPUT_RANGE_MAX;
            static /*0x2*/ byte DEFAULT_INCREMENT;

            static /*0x73535e8*/ BytePropertyCommand();
            /*0x734e230*/ BytePropertyCommand(string displayName, System.Func<byte> getter, System.Action<byte> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<byte> inputRangeMin, System.Nullable<byte> inputRangeMax, System.Nullable<byte> increment);
            /*0x7353160*/ string get_TypeName();
            /*0x73531a0*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7353248*/ byte GetValue();
            /*0x735336c*/ void SetValue(byte value);
            /*0x735344c*/ byte FromString(string textValue);
            /*0x7353500*/ bool IsEqualOrUnderMin(byte value);
            /*0x7353510*/ bool IsEqualOrOverMax(byte value);
            /*0x7353520*/ byte ValidateValueForFluctuation(byte value, int magnification);
            /*0x735329c*/ byte _ValidateValue(byte value);
        }

        class CharPropertyCommand : NoaDebugger.DebugCommand.MutablePropertyCommandBase<char>
        {
            /*0x734e6b4*/ CharPropertyCommand(string displayName, System.Func<char> getter, System.Action<char> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey);
            /*0x735363c*/ string get_TypeName();
            /*0x7353794*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x735367c*/ char GetValue();
            /*0x73536c4*/ void SetValue(char value);
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

            /*0x735386c*/ CommandBase(string displayName, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order);
            /*0x735383c*/ string get_DisplayName();
            /*0x7353844*/ string get_GroupName();
            /*0x735384c*/ System.Nullable<int> get_GroupOrder();
            /*0x7353854*/ string get_TagName();
            /*0x735385c*/ string get_Description();
            /*0x7353864*/ int get_Order();
            /*0x38148bc*/ string get_TypeName();
            /*0x7353960*/ System.Collections.Generic.Dictionary<string, string> CreateDetailContext();
        }

        class CoroutineCommand : NoaDebugger.DebugCommand.CommandBase, NoaDebugger.DebugCommand.ICommand
        {
            /*0x3c*/ bool <IsVisible>k__BackingField;
            /*0x40*/ System.Func<System.Collections.IEnumerator> _coroutine;
            /*0x48*/ bool _isInteractable;
            /*0x49*/ bool _isCoroutineWaiting;
            /*0x50*/ UnityEngine.Events.UnityAction _completeCallback;

            /*0x734ec18*/ CoroutineCommand(string displayName, System.Func<System.Collections.IEnumerator> coroutine, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order);
            /*0x7353acc*/ bool get_IsInteractable();
            /*0x7353aec*/ void set_IsInteractable(bool value);
            /*0x7353af8*/ bool get_IsVisible();
            /*0x7353b00*/ void set_IsVisible(bool value);
            /*0x7353b0c*/ string get_TypeName();
            /*0x7353b4c*/ void Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7353bf4*/ void Invoke(UnityEngine.Events.UnityAction onComplete);
            /*0x7353d38*/ void _OnComplete();
        }

        class DecimalPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<decimal>
        {
            static /*0x0*/ decimal DEFAULT_INPUT_RANGE_MIN;
            static /*0x10*/ decimal DEFAULT_INPUT_RANGE_MAX;
            static /*0x20*/ decimal DEFAULT_INCREMENT;
            /*0x90*/ int _needDigits;

            static /*0x73545fc*/ DecimalPropertyCommand();
            /*0x734efc0*/ DecimalPropertyCommand(string displayName, System.Func<decimal> getter, System.Action<decimal> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<decimal> inputRangeMin, System.Nullable<decimal> inputRangeMax, System.Nullable<decimal> increment, int needDigits);
            /*0x7353d58*/ string get_TypeName();
            /*0x7353d98*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7353e40*/ decimal GetValue();
            /*0x7353f2c*/ void SetValue(decimal value);
            /*0x735402c*/ decimal FromString(string textValue);
            /*0x735417c*/ bool IsEqualOrUnderMin(decimal value);
            /*0x73541f4*/ bool IsEqualOrOverMax(decimal value);
            /*0x735426c*/ decimal ValidateValueForFluctuation(decimal value, int magnification);
            /*0x7353ea0*/ decimal _ValidateValue(decimal value);
        }

        class DoublePropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<double>
        {
            static /*0x0*/ double DEFAULT_INPUT_RANGE_MIN;
            static /*0x8*/ double DEFAULT_INPUT_RANGE_MAX;
            static /*0x10*/ double DEFAULT_INCREMENT;
            /*0x78*/ int _needDigits;

            static /*0x7354c58*/ DoublePropertyCommand();
            /*0x734f72c*/ DoublePropertyCommand(string displayName, System.Func<double> getter, System.Action<double> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<double> inputRangeMin, System.Nullable<double> inputRangeMax, System.Nullable<double> increment, int needDigits);
            /*0x7354710*/ string get_TypeName();
            /*0x7354750*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x73547f8*/ double GetValue();
            /*0x7354928*/ void SetValue(double value);
            /*0x7354a10*/ double FromString(string textValue);
            /*0x7354ad0*/ bool IsEqualOrUnderMin(double value);
            /*0x7354ae0*/ bool IsEqualOrOverMax(double value);
            /*0x7354af0*/ double ValidateValueForFluctuation(double value, int magnification);
            /*0x7354848*/ double _ValidateValue(double value);
        }

        class EnumPropertyCommand : NoaDebugger.DebugCommand.MutablePropertyCommandBase<System.Enum>
        {
            /*0x58*/ System.Type _enumType;
            /*0x60*/ string[] _enumNames;

            /*0x734fc7c*/ EnumPropertyCommand(string displayName, System.Func<System.Enum> getter, System.Action<System.Enum> setter, System.Type type, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey);
            /*0x7354cb0*/ string get_TypeName();
            /*0x7354e80*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7354f28*/ string[] GetNames();
            /*0x7354cf0*/ string GetValue();
            /*0x7354d4c*/ void SetValue(string valueName);
        }

        class FloatPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<float>
        {
            static /*0x0*/ float DEFAULT_INPUT_RANGE_MIN;
            static /*0x4*/ float DEFAULT_INPUT_RANGE_MAX;
            static /*0x8*/ float DEFAULT_INCREMENT;
            /*0x68*/ int _needDigits;

            static /*0x7355478*/ FloatPropertyCommand();
            /*0x73500e4*/ FloatPropertyCommand(string displayName, System.Func<float> getter, System.Action<float> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<float> inputRangeMin, System.Nullable<float> inputRangeMax, System.Nullable<float> increment, int needDigits);
            /*0x7354f30*/ string get_TypeName();
            /*0x7354f70*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7355018*/ float GetValue();
            /*0x7355148*/ void SetValue(float value);
            /*0x7355230*/ float FromString(string textValue);
            /*0x73552f0*/ bool IsEqualOrUnderMin(float value);
            /*0x7355300*/ bool IsEqualOrOverMax(float value);
            /*0x7355310*/ float ValidateValueForFluctuation(float value, int magnification);
            /*0x7355068*/ float _ValidateValue(float value);
        }

        class GetOnlyPropertyCommand : NoaDebugger.DebugCommand.CommandBase, NoaDebugger.DebugCommand.ICommand
        {
            /*0x3c*/ bool <IsVisible>k__BackingField;
            /*0x40*/ System.Func<object> _getter;

            /*0x7350574*/ GetOnlyPropertyCommand(string displayName, System.Func<object> getter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order);
            /*0x73554d0*/ bool get_IsInteractable();
            /*0x73554d8*/ void set_IsInteractable(bool value);
            /*0x73554dc*/ bool get_IsVisible();
            /*0x73554e4*/ void set_IsVisible(bool value);
            /*0x73554f0*/ string get_TypeName();
            /*0x7355530*/ void Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x73555d4*/ string GetValue();
            /*0x73556a4*/ System.Collections.Generic.Dictionary<string, string> CreateDetailContext();
        }

        class HandleMethodCommand : NoaDebugger.DebugCommand.CommandBase, NoaDebugger.DebugCommand.ICommand
        {
            /*0x3c*/ bool <IsVisible>k__BackingField;
            /*0x40*/ System.Func<NoaDebugger.MethodHandler> _method;
            /*0x48*/ bool _isInteractable;
            /*0x49*/ bool _isWaiting;
            /*0x50*/ UnityEngine.Events.UnityAction _completeCallback;
            /*0x58*/ NoaDebugger.MethodHandler _handler;

            /*0x735069c*/ HandleMethodCommand(string displayName, System.Func<NoaDebugger.MethodHandler> method, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order);
            /*0x7355748*/ bool get_IsInteractable();
            /*0x7355768*/ void set_IsInteractable(bool value);
            /*0x7355774*/ bool get_IsVisible();
            /*0x735577c*/ void set_IsVisible(bool value);
            /*0x7355788*/ string get_TypeName();
            /*0x73557c8*/ void Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7355870*/ void Invoke(UnityEngine.Events.UnityAction onComplete);
            /*0x735599c*/ System.Collections.IEnumerator _WatchHandler();
            /*0x7355a30*/ void _OnComplete();

            class <_WatchHandler>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ NoaDebugger.DebugCommand.HandleMethodCommand <>4__this;

                /*0x7355a08*/ <_WatchHandler>d__17(int <>1__state);
                /*0x7355a70*/ void System.IDisposable.Dispose();
                /*0x7355a74*/ bool MoveNext();
                /*0x7355ad8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x7355ae0*/ void System.Collections.IEnumerator.Reset();
                /*0x7355b18*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class IntPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<int>
        {
            static /*0x0*/ int DEFAULT_INPUT_RANGE_MIN;
            static /*0x4*/ int DEFAULT_INPUT_RANGE_MAX;
            static /*0x8*/ int DEFAULT_INCREMENT;

            static /*0x7355ffc*/ IntPropertyCommand();
            /*0x7350968*/ IntPropertyCommand(string displayName, System.Func<int> getter, System.Action<int> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<int> inputRangeMin, System.Nullable<int> inputRangeMax, System.Nullable<int> increment);
            /*0x7355b20*/ string get_TypeName();
            /*0x7355b60*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7355c08*/ int GetValue();
            /*0x7355d28*/ void SetValue(int value);
            /*0x7355e08*/ int FromString(string textValue);
            /*0x7355ec0*/ bool IsEqualOrUnderMin(int value);
            /*0x7355ed0*/ bool IsEqualOrOverMax(int value);
            /*0x7355ee0*/ int ValidateValueForFluctuation(int value, int magnification);
            /*0x7355c5c*/ int _ValidateValue(int value);
        }

        class LongPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<long>
        {
            static /*0x0*/ long DEFAULT_INPUT_RANGE_MIN;
            static /*0x8*/ long DEFAULT_INPUT_RANGE_MAX;
            static /*0x10*/ long DEFAULT_INCREMENT;

            static /*0x735690c*/ LongPropertyCommand();
            /*0x73561e0*/ LongPropertyCommand(string displayName, System.Func<long> getter, System.Action<long> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<long> inputRangeMin, System.Nullable<long> inputRangeMax, System.Nullable<long> increment);
            /*0x73561a0*/ string get_TypeName();
            /*0x7356470*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7356518*/ long GetValue();
            /*0x7356638*/ void SetValue(long value);
            /*0x7356718*/ long FromString(string textValue);
            /*0x73567d0*/ bool IsEqualOrUnderMin(long value);
            /*0x73567e0*/ bool IsEqualOrOverMax(long value);
            /*0x73567f0*/ long ValidateValueForFluctuation(long value, int magnification);
            /*0x735656c*/ long _ValidateValue(long value);
        }

        class MethodCommand : NoaDebugger.DebugCommand.CommandBase, NoaDebugger.DebugCommand.ICommand
        {
            /*0x3c*/ bool <IsInteractable>k__BackingField;
            /*0x3d*/ bool <IsVisible>k__BackingField;
            /*0x40*/ System.Action _method;

            /*0x73569cc*/ MethodCommand(string displayName, System.Action method, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order);
            /*0x7356964*/ bool get_IsInteractable();
            /*0x735696c*/ void set_IsInteractable(bool value);
            /*0x7356978*/ bool get_IsVisible();
            /*0x7356980*/ void set_IsVisible(bool value);
            /*0x735698c*/ string get_TypeName();
            /*0x7356a18*/ void Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7356ac0*/ void Invoke();
        }

        class MutableNumericPropertyCommandBase<T> : NoaDebugger.DebugCommand.MutablePropertyCommandBase<T>
        {
            /*0x0*/ T _inputRangeMin;
            /*0x0*/ T _inputRangeMax;
            /*0x0*/ bool _isSetRange;
            /*0x0*/ T <Increment>k__BackingField;

            /*0x3910ae8*/ MutableNumericPropertyCommandBase(string displayName, System.Func<T> getter, System.Action<T> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<T> inputRangeMin, System.Nullable<T> inputRangeMax, System.Nullable<T> increment);
            /*0x3910ae8*/ T get_Increment();
            /*0x3910ae8*/ void set_Increment(T value);
            /*0x38148bc*/ System.Collections.Generic.Dictionary<string, string> CreateDetailContext();
            /*0x3910ae8*/ T GetValue();
            /*0x3910ae8*/ void SetValue(T value);
            /*0x3910ae8*/ T FromString(string textValue);
            /*0x3910ae8*/ bool IsEqualOrUnderMin(T value);
            /*0x3910ae8*/ bool IsEqualOrOverMax(T value);
            /*0x3910ae8*/ T ValidateValueForFluctuation(T value, int magnification);
            /*0x38141c4*/ bool IsNotNumeric(string text);
        }

        class MutablePropertyCommandBase<T> : NoaDebugger.DebugCommand.CommandBase, NoaDebugger.DebugCommand.ICommand
        {
            /*0x0*/ bool <IsInteractable>k__BackingField;
            /*0x0*/ bool <IsVisible>k__BackingField;
            /*0x0*/ System.Func<T> _getter;
            /*0x0*/ System.Action<T> _setter;
            /*0x0*/ string <SaveKey>k__BackingField;

            /*0x3910ae8*/ MutablePropertyCommandBase(string displayName, System.Func<T> getter, System.Action<T> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey);
            /*0x3813ffc*/ bool get_IsInteractable();
            /*0x3815cc4*/ void set_IsInteractable(bool value);
            /*0x3813ffc*/ bool get_IsVisible();
            /*0x3815cc4*/ void set_IsVisible(bool value);
            /*0x38148bc*/ string get_SaveKey();
            /*0x3813ffc*/ bool get_SavesOnUpdate();
            /*0x3816710*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x3816710*/ void Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x38148bc*/ System.Collections.Generic.Dictionary<string, string> CreateDetailContext();
            /*0x3910ae8*/ T InvokeGetter();
            /*0x3910ae8*/ void InvokeSetter(T value);
        }

        class SBytePropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<sbyte>
        {
            static /*0x0*/ sbyte DEFAULT_INPUT_RANGE_MIN;
            static /*0x1*/ sbyte DEFAULT_INPUT_RANGE_MAX;
            static /*0x2*/ sbyte DEFAULT_INCREMENT;

            static /*0x73572f0*/ SBytePropertyCommand();
            /*0x7356ba0*/ SBytePropertyCommand(string displayName, System.Func<sbyte> getter, System.Action<sbyte> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<sbyte> inputRangeMin, System.Nullable<sbyte> inputRangeMax, System.Nullable<sbyte> increment);
            /*0x7356b60*/ string get_TypeName();
            /*0x7356e30*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7356ed8*/ sbyte GetValue();
            /*0x7356ffc*/ void SetValue(sbyte value);
            /*0x73570dc*/ sbyte FromString(string textValue);
            /*0x7357194*/ bool IsEqualOrUnderMin(sbyte value);
            /*0x73571a4*/ bool IsEqualOrOverMax(sbyte value);
            /*0x73571b4*/ sbyte ValidateValueForFluctuation(sbyte value, int magnification);
            /*0x7356f2c*/ sbyte _ValidateValue(sbyte value);
        }

        class ShortPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<short>
        {
            static /*0x0*/ short DEFAULT_INPUT_RANGE_MIN;
            static /*0x2*/ short DEFAULT_INPUT_RANGE_MAX;
            static /*0x4*/ short DEFAULT_INCREMENT;

            static /*0x7357ad4*/ ShortPropertyCommand();
            /*0x7357384*/ ShortPropertyCommand(string displayName, System.Func<short> getter, System.Action<short> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<short> inputRangeMin, System.Nullable<short> inputRangeMax, System.Nullable<short> increment);
            /*0x7357344*/ string get_TypeName();
            /*0x7357614*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x73576bc*/ short GetValue();
            /*0x73577e0*/ void SetValue(short value);
            /*0x73578c0*/ short FromString(string textValue);
            /*0x7357978*/ bool IsEqualOrUnderMin(short value);
            /*0x7357988*/ bool IsEqualOrOverMax(short value);
            /*0x7357998*/ short ValidateValueForFluctuation(short value, int magnification);
            /*0x7357710*/ short _ValidateValue(short value);
        }

        class StringPropertyCommand : NoaDebugger.DebugCommand.MutablePropertyCommandBase<string>
        {
            /*0x58*/ int _unlimited;
            /*0x5c*/ int <CharacterLimit>k__BackingField;

            /*0x7357b80*/ StringPropertyCommand(string displayName, System.Func<string> getter, System.Action<string> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<int> characterLimit);
            /*0x7357b28*/ bool get_IsUnlimited();
            /*0x7357b38*/ int get_CharacterLimit();
            /*0x7357b40*/ string get_TypeName();
            /*0x7357e6c*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7357d44*/ string GetValue();
            /*0x7357d8c*/ void SetValue(string value);
            /*0x7357f14*/ string ValidateValue(string value);
            /*0x7357f58*/ System.Collections.Generic.Dictionary<string, string> CreateDetailContext();
        }

        class UIntPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<uint>
        {
            static /*0x0*/ uint DEFAULT_INPUT_RANGE_MIN;
            static /*0x4*/ uint DEFAULT_INPUT_RANGE_MAX;
            static /*0x8*/ uint DEFAULT_INCREMENT;

            static /*0x7358770*/ UIntPropertyCommand();
            /*0x73580a4*/ UIntPropertyCommand(string displayName, System.Func<uint> getter, System.Action<uint> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<uint> inputRangeMin, System.Nullable<uint> inputRangeMax, System.Nullable<uint> increment);
            /*0x7358064*/ string get_TypeName();
            /*0x7358328*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x73583d0*/ uint GetValue();
            /*0x73584f0*/ void SetValue(uint value);
            /*0x73585d0*/ uint FromString(string textValue);
            /*0x7358684*/ bool IsEqualOrUnderMin(uint value);
            /*0x7358694*/ bool IsEqualOrOverMax(uint value);
            /*0x73586a4*/ uint ValidateValueForFluctuation(uint value, int magnification);
            /*0x7358424*/ uint _ValidateValue(uint value);
        }

        class ULongPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<ulong>
        {
            static /*0x0*/ ulong DEFAULT_INPUT_RANGE_MIN;
            static /*0x8*/ ulong DEFAULT_INPUT_RANGE_MAX;
            static /*0x10*/ ulong DEFAULT_INCREMENT;

            static /*0x7358ef0*/ ULongPropertyCommand();
            /*0x7358804*/ ULongPropertyCommand(string displayName, System.Func<ulong> getter, System.Action<ulong> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<ulong> inputRangeMin, System.Nullable<ulong> inputRangeMax, System.Nullable<ulong> increment);
            /*0x73587c4*/ string get_TypeName();
            /*0x7358a94*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x7358b3c*/ ulong GetValue();
            /*0x7358c5c*/ void SetValue(ulong value);
            /*0x7358d3c*/ ulong FromString(string textValue);
            /*0x7358df0*/ bool IsEqualOrUnderMin(ulong value);
            /*0x7358e00*/ bool IsEqualOrOverMax(ulong value);
            /*0x7358e10*/ ulong ValidateValueForFluctuation(ulong value, int magnification);
            /*0x7358b90*/ ulong _ValidateValue(ulong value);
        }

        class UShortPropertyCommand : NoaDebugger.DebugCommand.MutableNumericPropertyCommandBase<ushort>
        {
            static /*0x0*/ ushort DEFAULT_INPUT_RANGE_MIN;
            static /*0x2*/ ushort DEFAULT_INPUT_RANGE_MAX;
            static /*0x4*/ ushort DEFAULT_INCREMENT;

            static /*0x7359660*/ UShortPropertyCommand();
            /*0x7358f88*/ UShortPropertyCommand(string displayName, System.Func<ushort> getter, System.Action<ushort> setter, string groupName, System.Nullable<int> groupOrder, string tagName, string description, System.Nullable<int> order, string saveKey, System.Nullable<ushort> inputRangeMin, System.Nullable<ushort> inputRangeMax, System.Nullable<ushort> increment);
            /*0x7358f48*/ string get_TypeName();
            /*0x7359218*/ void _Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x73592c0*/ ushort GetValue();
            /*0x73593e4*/ void SetValue(ushort value);
            /*0x73594c4*/ ushort FromString(string textValue);
            /*0x7359578*/ bool IsEqualOrUnderMin(ushort value);
            /*0x7359588*/ bool IsEqualOrOverMax(ushort value);
            /*0x7359598*/ ushort ValidateValueForFluctuation(ushort value, int magnification);
            /*0x7359314*/ ushort _ValidateValue(ushort value);
        }

        class DebugCommandDefinitionRegister
        {
            /*0x10*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<NoaDebugger.CommandDefinition>> <CommandDefinitions>k__BackingField;

            /*0x73599a8*/ DebugCommandDefinitionRegister();
            /*0x73596b4*/ System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<NoaDebugger.CommandDefinition>> get_CommandDefinitions();
            /*0x73596bc*/ void Dispose();
            /*0x735970c*/ bool Add(NoaDebugger.CommandDefinition commandDefinition);
            /*0x7359830*/ bool Remove(NoaDebugger.CommandDefinition commandDefinition);
            /*0x7359950*/ bool RemoveCategory(string categoryName);
        }

        interface ICommand
        {
            /*0x38148bc*/ string get_DisplayName();
            /*0x38148bc*/ string get_GroupName();
            /*0x38137f8*/ System.Nullable<int> get_GroupOrder();
            /*0x38148bc*/ string get_TagName();
            /*0x38148bc*/ string get_Description();
            /*0x3814574*/ int get_Order();
            /*0x3813ffc*/ bool get_IsInteractable();
            /*0x3815cc4*/ void set_IsInteractable(bool value);
            /*0x3813ffc*/ bool get_IsVisible();
            /*0x3815cc4*/ void set_IsVisible(bool value);
            /*0x3816710*/ void Accept(NoaDebugger.DebugCommand.ICommandVisitor visitor);
            /*0x38148bc*/ System.Collections.Generic.Dictionary<string, string> CreateDetailContext();
            /*0x7359a30*/ string GetDetailSuffix();
        }

        interface ICommandVisitor
        {
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.GetOnlyPropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.StringPropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.ShortPropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.UShortPropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.IntPropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.UIntPropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.BytePropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.SBytePropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.LongPropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.ULongPropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.CharPropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.FloatPropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.DoublePropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.DecimalPropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.BoolPropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.EnumPropertyCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.MethodCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.CoroutineCommand command);
            /*0x3816710*/ void Visit(NoaDebugger.DebugCommand.HandleMethodCommand command);
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

            /*0x735a428*/ DebugCommandCategoryView();
            /*0x7359b5c*/ void add_OnSelectCategory(UnityEngine.Events.UnityAction<int> value);
            /*0x7359c0c*/ void remove_OnSelectCategory(UnityEngine.Events.UnityAction<int> value);
            /*0x7359cbc*/ void _OnValidateUI();
            /*0x7359cc0*/ void _Init();
            /*0x7359d7c*/ void _OnShow(NoaDebugger.DebugCommand.DebugCommandViewLinker linker);
            /*0x735a20c*/ void AlignmentUI(bool isReverse);
            /*0x735a2e4*/ System.Collections.IEnumerator _SetScrollPosition();
            /*0x7359eec*/ void _CreateCategoryMenu(string[] categoryNames);
            /*0x735a380*/ void _OnClickCategorySelect();
            /*0x735a3ec*/ void _OnCategoryTab(int index);

            class <>c__DisplayClass15_0
            {
                /*0x10*/ int index;
                /*0x18*/ NoaDebugger.DebugCommand.DebugCommandCategoryView <>4__this;

                /*0x735a378*/ <>c__DisplayClass15_0();
                /*0x735a470*/ void <_CreateCategoryMenu>b__0();
            }

            class <_SetScrollPosition>d__14 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ NoaDebugger.DebugCommand.DebugCommandCategoryView <>4__this;

                /*0x735a350*/ <_SetScrollPosition>d__14(int <>1__state);
                /*0x735a490*/ void System.IDisposable.Dispose();
                /*0x735a494*/ bool MoveNext();
                /*0x735a504*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x735a50c*/ void System.Collections.IEnumerator.Reset();
                /*0x735a544*/ object System.Collections.IEnumerator.get_Current();
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

            /*0x735acf4*/ DebugCommandFloatingWindowView();
            /*0x735a54c*/ void add_OnSelectCategory(UnityEngine.Events.UnityAction<int> value);
            /*0x735a5fc*/ void remove_OnSelectCategory(UnityEngine.Events.UnityAction<int> value);
            /*0x735a6ac*/ void add_OnTapRefreshButton(UnityEngine.Events.UnityAction<bool, NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker> value);
            /*0x735a75c*/ void remove_OnTapRefreshButton(UnityEngine.Events.UnityAction<bool, NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker> value);
            /*0x735a80c*/ void add_OnLongTapRefreshButton(UnityEngine.Events.UnityAction<NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker> value);
            /*0x735a8bc*/ void remove_OnLongTapRefreshButton(UnityEngine.Events.UnityAction<NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker> value);
            /*0x735a96c*/ void _OnValidateUI();
            /*0x735a970*/ void _Init();
            /*0x735ab58*/ void _OnShow(NoaDebugger.DebugCommand.DebugCommandFloatingWindowViewLinker linker);
            /*0x735ac60*/ void _OnCategoryTab(int index);
            /*0x735ac98*/ void _OnTapRefreshButton();
            /*0x735acd4*/ void _OnLongTapRefreshButton(bool isToggleOn);
        }

        class DebugCommandFloatingWindowViewLinker : NoaDebugger.ViewLinkerBase
        {
            /*0x10*/ NoaDebugger.DebugCommand.DebugCommandViewLinker _viewLinker;
            /*0x18*/ bool _refreshCommandPanelsOnly;
            /*0x20*/ UnityEngine.Events.UnityAction _onLongTapRefreshButton;

            /*0x735ad3c*/ DebugCommandFloatingWindowViewLinker();
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

            /*0x735c484*/ CommandGroupPanel();
            /*0x735ad44*/ float get_MaxContentWidth();
            /*0x735ad68*/ float get_ParentWidth();
            /*0x735ad84*/ bool get_IsNeedAlign();
            /*0x735ad8c*/ void set_IsNeedAlign(bool value);
            /*0x735ad98*/ void _Init();
            /*0x735b0a0*/ void OnRectTransformDimensionsChange();
            /*0x735b0ac*/ void AlignmentPanels();
            /*0x735b3ec*/ void _AlignmentPanels(UnityEngine.RectTransform parent, System.Collections.Generic.List<UnityEngine.RectTransform> targets, bool isForceExpand);
            /*0x735b754*/ void _FitHeight(UnityEngine.RectTransform targetPanelsParent);
            /*0x735b804*/ void RefreshPanels();
            /*0x735b964*/ void RefreshPanelsStatus(NoaDebugger.DebugCommand.GroupPanelInfo group);
            /*0x735ba48*/ void RefreshHeader(NoaDebugger.DebugCommand.GroupPanelInfo group, bool isFloatingWindow, float headerHeight);
            /*0x735b380*/ NoaDebugger.DebugCommand.CommandPanelsParent _GetCurrentPanelsParent();
            /*0x735bbf8*/ void InstantiateGroup(NoaDebugger.DebugCommand.GroupPanelInfo group, bool isFloatingWindow, float headerHeight, bool isLast, NoaDebugger.DebugCommand.CommandScroll scrollRect);
            /*0x735c0fc*/ void _SetMaxWidth(NoaDebugger.DebugCommandPanel target);
            /*0x735c060*/ void _CollapseCommands(bool isCollapse);
            /*0x735c1b0*/ void _OnClickCollapseToggle(bool isOn);
            /*0x735c210*/ void _OnClickFloatingToggle(bool isOn);
            /*0x735c260*/ void _OnClickDetailToggle(bool isOn);
            /*0x735c2a4*/ void DestroyPanels();

            class <>c
            {
                static /*0x0*/ NoaDebugger.DebugCommand.CommandGroupPanel.<> <>9;
                static /*0x8*/ System.Func<NoaDebugger.DebugCommandPanel, UnityEngine.RectTransform> <>9__26_0;

                static /*0x735c498*/ <>c();
                /*0x735c500*/ <>c();
                /*0x735c508*/ UnityEngine.RectTransform <AlignmentPanels>b__26_0(NoaDebugger.DebugCommandPanel panel);
            }
        }

        class CommandPanelsParent
        {
            /*0x10*/ UnityEngine.RectTransform _rootTransform;
            /*0x18*/ NoaDebugger.DebugCommandPanel _panelPrefab;
            /*0x20*/ NoaDebugger.ContentPanelPool _panelPool;
            /*0x28*/ System.Collections.Generic.List<NoaDebugger.DebugCommandPanel> _commandComponents;
            /*0x30*/ System.Collections.Generic.List<int> _panelPoolIndexes;

            /*0x735c580*/ CommandPanelsParent();
            /*0x735c570*/ UnityEngine.RectTransform get_RootTransform();
            /*0x735c578*/ System.Collections.Generic.List<NoaDebugger.DebugCommandPanel> get_CommandComponents();
            /*0x735af68*/ void Init();
            /*0x735b81c*/ void RefreshPanels();
            /*0x735b984*/ void RefreshPanelsStatus(NoaDebugger.DebugCommand.GroupPanelInfo group);
            /*0x735bdcc*/ void InstantiateCommands(NoaDebugger.DebugCommand.GroupPanelInfo group, float maxContentWidth, NoaDebugger.DebugCommand.CommandScroll scrollRect, System.Action<NoaDebugger.DebugCommandPanel> onInit);
            /*0x735c2cc*/ void DestroyPanels();
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

            /*0x735d2f4*/ CommandScroll();
            /*0x735c588*/ void _Init();
            /*0x735c6dc*/ void Reset(NoaDebugger.DebugCommand.GroupPanelInfo[] groups);
            /*0x735cbc0*/ void LateUpdate();
            /*0x735cea8*/ void UpdatePanelsStatus(NoaDebugger.DebugCommand.DebugCommandViewLinker linker);
            /*0x735d154*/ void RefreshPanels();
            /*0x735c9ec*/ void _InstantiateGroups(NoaDebugger.DebugCommand.GroupPanelInfo[] groups);
            /*0x735c724*/ void _DestroyPanels();
            /*0x735d298*/ void Dispose();
            /*0x735d2fc*/ void <UpdatePanelsStatus>b__11_0(NoaDebugger.DebugCommand.CommandGroupPanel panel, NoaDebugger.DebugCommand.GroupPanelInfo info);

            class <>c
            {
                static /*0x0*/ NoaDebugger.DebugCommand.CommandScroll.<> <>9;
                static /*0x8*/ System.Action<NoaDebugger.DebugCommand.CommandGroupPanel, NoaDebugger.DebugCommand.GroupPanelInfo> <>9__11_1;

                static /*0x735d324*/ <>c();
                /*0x735d38c*/ <>c();
                /*0x735d394*/ void <UpdatePanelsStatus>b__11_1(NoaDebugger.DebugCommand.CommandGroupPanel panel, NoaDebugger.DebugCommand.GroupPanelInfo info);
            }
        }

        class GroupPanelInfo
        {
            /*0x10*/ string _name;
            /*0x18*/ NoaDebugger.DebugCommand.ICommand[] _commands;
            /*0x20*/ NoaDebugger.DebugCommand.GroupCollapseToggleInfo _collapseToggleInfo;
            /*0x28*/ NoaDebugger.DebugCommand.GroupFloatingToggleInfo _floatingToggleInfo;
            /*0x30*/ NoaDebugger.DebugCommand.DetailToggleInfo _detailToggleInfo;

            /*0x735d404*/ GroupPanelInfo(string name, NoaDebugger.DebugCommand.GroupCollapseToggleInfo collapseToggleInfo, NoaDebugger.DebugCommand.GroupFloatingToggleInfo floatingToggleInfo, NoaDebugger.DebugCommand.DetailToggleInfo detailToggleInfo);
            /*0x735bbd4*/ bool IsShowGroupDetail();
        }

        class GroupCollapseToggleInfo
        {
            /*0x10*/ bool _isOn;
            /*0x18*/ UnityEngine.Events.UnityAction<string, bool> _onChange;

            /*0x735d478*/ GroupCollapseToggleInfo(bool isOn, UnityEngine.Events.UnityAction<string, bool> onChange);
        }

        class GroupFloatingToggleInfo
        {
            /*0x10*/ bool _isOn;
            /*0x11*/ bool _isActive;
            /*0x18*/ UnityEngine.Events.UnityAction<string, bool> _onChange;

            /*0x735d4b0*/ GroupFloatingToggleInfo(bool isOn, bool isActive, UnityEngine.Events.UnityAction<string, bool> onChange);
        }

        class DetailToggleInfo
        {
            /*0x10*/ bool _isDetailMode;
            /*0x18*/ string _selectedGroup;
            /*0x20*/ string _selectedCommand;
            /*0x28*/ UnityEngine.Events.UnityAction<NoaDebugger.DebugCommand.GroupPanelInfo, bool> _onSelectGroup;
            /*0x30*/ UnityEngine.Events.UnityAction<NoaDebugger.DebugCommand.ICommand, bool> _onSelectCommand;

            /*0x735d4f8*/ DetailToggleInfo(bool isDetailMode, string selectedGroup, string selectedCommand, UnityEngine.Events.UnityAction<NoaDebugger.DebugCommand.GroupPanelInfo, bool> onSelectGroup, UnityEngine.Events.UnityAction<NoaDebugger.DebugCommand.ICommand, bool> onSelectCommand);
            /*0x735d3ac*/ bool IsShowDetail(string groupName, string commandName);
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

            /*0x735e1e0*/ DebugCommandView();
            /*0x735d57c*/ void add_OnSelectCategory(UnityEngine.Events.UnityAction<int> value);
            /*0x735d62c*/ void remove_OnSelectCategory(UnityEngine.Events.UnityAction<int> value);
            /*0x735d6dc*/ void add_OnDisplayDetailsToggle(UnityEngine.Events.UnityAction<bool> value);
            /*0x735d78c*/ void remove_OnDisplayDetailsToggle(UnityEngine.Events.UnityAction<bool> value);
            /*0x735d83c*/ void add_OnTapRefreshButton(UnityEngine.Events.UnityAction<bool> value);
            /*0x735d8ec*/ void remove_OnTapRefreshButton(UnityEngine.Events.UnityAction<bool> value);
            /*0x735d99c*/ void add_OnLongTapRefreshButton(UnityEngine.Events.UnityAction value);
            /*0x735da38*/ void remove_OnLongTapRefreshButton(UnityEngine.Events.UnityAction value);
            /*0x735dad4*/ void add_OnFloatingSelectAllButton(UnityEngine.Events.UnityAction<bool> value);
            /*0x735db84*/ void remove_OnFloatingSelectAllButton(UnityEngine.Events.UnityAction<bool> value);
            /*0x735dc34*/ void _OnValidateUI();
            /*0x735dc38*/ void _Init();
            /*0x735df20*/ void _OnShow(NoaDebugger.DebugCommand.DebugCommandViewLinker linker);
            /*0x735e054*/ void AlignmentUI(bool isReverse);
            /*0x735e0d8*/ void RefreshCommandPanels();
            /*0x735e0f4*/ void _OnCategoryTab(int index);
            /*0x735e12c*/ void _OnDisplayDetailsToggle(bool isOn);
            /*0x735e14c*/ void _OnTapRefreshButton();
            /*0x735e184*/ void _OnLongTapRefreshButton(bool isToggleOn);
            /*0x735e1a0*/ void _OnTapFloatingSelectAllButton();
            /*0x735e1c0*/ void _OnTapFloatingDeselectAllButton();
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

            /*0x735e228*/ DebugCommandViewLinker();
            /*0x735ac50*/ bool IsMatchUpdateTarget(NoaDebugger.DebugCommand.CommandViewUpdateTarget target);
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

            /*0x735e2ac*/ DragSliderHelper();
            /*0x735e238*/ int Delimit(float distance);
        }

        class CommandPanelBase<TCommand> : NoaDebugger.DebugCommand.ICommandPanel
        {
            /*0x0*/ NoaDebugger.DebugCommandPanel _panel;
            /*0x0*/ TCommand _command;
            /*0x0*/ TMPro.TextAlignmentOptions _alignmentOptionCenter;
            /*0x0*/ TMPro.TextAlignmentOptions _alignmentOptionLeft;

            /*0x3816710*/ CommandPanelBase(NoaDebugger.DebugCommandPanel panel);
            /*0x3816f24*/ void OnUpdateWidth(float maxContentWidth);
            /*0x3816710*/ void UpdateData(NoaDebugger.DebugCommand.ICommand command);
            /*0x38159dc*/ void Refresh();
            /*0x3814574*/ TMPro.TextAlignmentOptions GetDisplayNameAlignmentFromDisplayFormat();
            /*0x3910ae8*/ void SetPreferredWidthFromText(UnityEngine.UI.LayoutElement targetLayout, float horizontalPadding, TMPro.TMP_Text textComponent, float maxWidth);
        }

        class CommandPanelBoolProperty : NoaDebugger.DebugCommand.CommandPanelBase<NoaDebugger.DebugCommand.BoolPropertyCommand>
        {
            /*0x735e2b4*/ CommandPanelBoolProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x735e484*/ void Refresh();
            /*0x735e4c0*/ void _OnToggleChange(bool isOn);
        }

        class CommandPanelByteProperty : NoaDebugger.DebugCommand.CommandPanelUnsignedNumberPropertyBase<NoaDebugger.DebugCommand.BytePropertyCommand, byte>
        {
            /*0x735e4e0*/ CommandPanelByteProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x735e548*/ void OnEndInputEdit(string text);
        }

        class CommandPanelCharProperty : NoaDebugger.DebugCommand.CommandPanelSimpleInputPropertyBase<NoaDebugger.DebugCommand.CharPropertyCommand>
        {
            /*0x735e5a0*/ CommandPanelCharProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x735e624*/ string GetValueString();
            /*0x735e674*/ void OnEndInputEdit(string text);
        }

        class CommandPanelCoroutine : NoaDebugger.DebugCommand.CommandPanelMethodBase<NoaDebugger.DebugCommand.CoroutineCommand>
        {
            /*0x735e6e8*/ CommandPanelCoroutine(NoaDebugger.DebugCommandPanel panel);
            /*0x735e750*/ void Refresh();
            /*0x735e7cc*/ void OnClick();
        }

        class CommandPanelDecimalProperty : NoaDebugger.DebugCommand.CommandPanelFloatingPointNumberPropertyBase<NoaDebugger.DebugCommand.DecimalPropertyCommand, decimal>
        {
            /*0x735e854*/ CommandPanelDecimalProperty(NoaDebugger.DebugCommandPanel panel, float maxContentWidth);
            /*0x735e8dc*/ void OnEndInputEdit(string text);
        }

        class CommandPanelDoubleProperty : NoaDebugger.DebugCommand.CommandPanelFloatingPointNumberPropertyBase<NoaDebugger.DebugCommand.DoublePropertyCommand, double>
        {
            /*0x735e93c*/ CommandPanelDoubleProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x735e9a4*/ void OnEndInputEdit(string text);
        }

        class CommandPanelEnumProperty : NoaDebugger.DebugCommand.CommandPanelBase<NoaDebugger.DebugCommand.EnumPropertyCommand>
        {
            /*0x28*/ System.Collections.Generic.List<TMPro.TMP_Dropdown.OptionData> _optionDataList;
            /*0x30*/ string _longestName;
            /*0x38*/ UnityEngine.UI.LayoutElement _layoutElement;
            /*0x40*/ float _horizontalPadding;

            /*0x735e9f4*/ CommandPanelEnumProperty(NoaDebugger.DebugCommandPanel panel, float maxContentWidth);
            /*0x735ed80*/ void OnUpdateWidth(float maxContentWidth);
            /*0x735eed4*/ void Refresh();
            /*0x735ef28*/ int _GetEnumIndex(string value);
            /*0x735efac*/ void _OnChangeDropdown(int index);
        }

        class CommandPanelFloatingPointNumberPropertyBase<TCommand, TNumericType> : NoaDebugger.DebugCommand.CommandPanelNumericInputPropertyBase<TCommand, TNumericType>
        {
            /*0x3816710*/ CommandPanelFloatingPointNumberPropertyBase(NoaDebugger.DebugCommandPanel panel);
        }

        class CommandPanelFloatProperty : NoaDebugger.DebugCommand.CommandPanelFloatingPointNumberPropertyBase<NoaDebugger.DebugCommand.FloatPropertyCommand, float>
        {
            /*0x735efe8*/ CommandPanelFloatProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x735f050*/ void OnEndInputEdit(string text);
        }

        class CommandPanelGetOnlyProperty : NoaDebugger.DebugCommand.CommandPanelBase<NoaDebugger.DebugCommand.GetOnlyPropertyCommand>
        {
            /*0x28*/ UnityEngine.UI.LayoutElement _layoutElement;
            /*0x30*/ float _horizontalPadding;

            /*0x735f0a0*/ CommandPanelGetOnlyProperty(NoaDebugger.DebugCommandPanel panel, float maxContentWidth);
            /*0x735f27c*/ void OnUpdateWidth(float maxContentWidth);
            /*0x735f34c*/ void Refresh();
        }

        class CommandPanelHandleMethod : NoaDebugger.DebugCommand.CommandPanelMethodBase<NoaDebugger.DebugCommand.HandleMethodCommand>
        {
            /*0x735f3b8*/ CommandPanelHandleMethod(NoaDebugger.DebugCommandPanel panel);
            /*0x735f420*/ void Refresh();
            /*0x735f49c*/ void OnClick();
        }

        class CommandPanelIntProperty : NoaDebugger.DebugCommand.CommandPanelSignedNumberPropertyBase<NoaDebugger.DebugCommand.IntPropertyCommand, int>
        {
            /*0x735f524*/ CommandPanelIntProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x735f58c*/ void OnEndInputEdit(string text);
        }

        class CommandPanelLongProperty : NoaDebugger.DebugCommand.CommandPanelSignedNumberPropertyBase<NoaDebugger.DebugCommand.LongPropertyCommand, long>
        {
            /*0x735f5e4*/ CommandPanelLongProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x735f64c*/ void OnEndInputEdit(string text);
        }

        class CommandPanelMethod : NoaDebugger.DebugCommand.CommandPanelMethodBase<NoaDebugger.DebugCommand.MethodCommand>
        {
            /*0x735f6a4*/ CommandPanelMethod(NoaDebugger.DebugCommandPanel panel);
            /*0x735f70c*/ void OnClick();
        }

        class CommandPanelMethodBase<TCommand> : NoaDebugger.DebugCommand.CommandPanelBase<TCommand>
        {
            /*0x3816710*/ CommandPanelMethodBase(NoaDebugger.DebugCommandPanel panel);
            /*0x38159dc*/ void OnClick();
        }

        class CommandPanelNumericInputPropertyBase<TCommand, TNumericType> : NoaDebugger.DebugCommand.CommandPanelBase<TCommand>
        {
            /*0x0*/ UnityEngine.UI.LayoutElement _layoutElement;
            /*0x0*/ float _horizontalPadding;
            /*0x0*/ TNumericType _tmpValue;
            /*0x0*/ TNumericType _beginDragValue;

            /*0x3816710*/ CommandPanelNumericInputPropertyBase(NoaDebugger.DebugCommandPanel panel);
            /*0x3816f24*/ void OnUpdateWidth(float maxContentWidth);
            /*0x38159dc*/ void Refresh();
            /*0x3816710*/ void OnEndInputEdit(string text);
            /*0x38159dc*/ void _OnBeginDrag();
            /*0x3816f24*/ void _OnSliding(float distance);
            /*0x38159dc*/ void _OnDownArrowButton();
            /*0x3816710*/ void _OnExitArrowButton(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x38159dc*/ void _OnClickLeftArrowButton();
            /*0x38159dc*/ void _DecrementValue();
            /*0x38159dc*/ void _OnClickRightArrowButton();
            /*0x38159dc*/ void _IncrementValue();
            /*0x3910ae8*/ void _FluctuateValue(TNumericType beginValue, int count);
            /*0x38159dc*/ void _SetValue();
            int _DelimitDistance(float distance);
        }

        class CommandPanelSByteProperty : NoaDebugger.DebugCommand.CommandPanelSignedNumberPropertyBase<NoaDebugger.DebugCommand.SBytePropertyCommand, sbyte>
        {
            /*0x735f724*/ CommandPanelSByteProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x735f78c*/ void OnEndInputEdit(string text);
        }

        class CommandPanelShortProperty : NoaDebugger.DebugCommand.CommandPanelSignedNumberPropertyBase<NoaDebugger.DebugCommand.ShortPropertyCommand, short>
        {
            /*0x735f7e4*/ CommandPanelShortProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x735f84c*/ void OnEndInputEdit(string text);
        }

        class CommandPanelSignedNumberPropertyBase<TCommand, TNumericType> : NoaDebugger.DebugCommand.CommandPanelNumericInputPropertyBase<TCommand, TNumericType>
        {
            /*0x3816710*/ CommandPanelSignedNumberPropertyBase(NoaDebugger.DebugCommandPanel panel);
        }

        class CommandPanelSimpleInputPropertyBase<TCommand> : NoaDebugger.DebugCommand.CommandPanelBase<TCommand>
        {
            /*0x3816710*/ CommandPanelSimpleInputPropertyBase(NoaDebugger.DebugCommandPanel panel);
            /*0x38159dc*/ void Refresh();
            /*0x38148bc*/ string GetValueString();
            /*0x3816710*/ void OnEndInputEdit(string text);
        }

        class CommandPanelStringProperty : NoaDebugger.DebugCommand.CommandPanelSimpleInputPropertyBase<NoaDebugger.DebugCommand.StringPropertyCommand>
        {
            /*0x28*/ UnityEngine.UI.LayoutElement _layoutElement;
            /*0x30*/ float _horizontalPadding;

            /*0x735f8a4*/ CommandPanelStringProperty(NoaDebugger.DebugCommandPanel panel, float maxContentWidth);
            /*0x735fa20*/ void OnUpdateWidth(float maxContentWidth);
            /*0x735fb00*/ string GetValueString();
            /*0x735fb18*/ void OnEndInputEdit(string text);
        }

        class CommandPanelUIntProperty : NoaDebugger.DebugCommand.CommandPanelUnsignedNumberPropertyBase<NoaDebugger.DebugCommand.UIntPropertyCommand, uint>
        {
            /*0x735fb44*/ CommandPanelUIntProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x735fbac*/ void OnEndInputEdit(string text);
        }

        class CommandPanelULongProperty : NoaDebugger.DebugCommand.CommandPanelUnsignedNumberPropertyBase<NoaDebugger.DebugCommand.ULongPropertyCommand, ulong>
        {
            /*0x735fc04*/ CommandPanelULongProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x735fc6c*/ void OnEndInputEdit(string text);
        }

        class CommandPanelUnsignedNumberPropertyBase<TCommand, TNumericType> : NoaDebugger.DebugCommand.CommandPanelNumericInputPropertyBase<TCommand, TNumericType>
        {
            /*0x3816710*/ CommandPanelUnsignedNumberPropertyBase(NoaDebugger.DebugCommandPanel panel);
            char ValidateUnsignedInput(string text, int charIndex, char addedChar);
        }

        class CommandPanelUShortProperty : NoaDebugger.DebugCommand.CommandPanelUnsignedNumberPropertyBase<NoaDebugger.DebugCommand.UShortPropertyCommand, ushort>
        {
            /*0x735fcc4*/ CommandPanelUShortProperty(NoaDebugger.DebugCommandPanel panel);
            /*0x735fd2c*/ void OnEndInputEdit(string text);
        }

        interface ICommandPanel
        {
            /*0x3816f24*/ void OnUpdateWidth(float maxContentWidth);
            /*0x3816710*/ void UpdateData(NoaDebugger.DebugCommand.ICommand command);
            /*0x38159dc*/ void Refresh();
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
