class <Module>
{
}

enum MultiPositionTypeLabel
{
    Simple_Mode = 0,
    Large_Mode = 1,
    MultiPosition_Mode = 2,
}

class AkMultiPosEvent
{
    /*0x10*/ bool eventIsPlaying;
    /*0x18*/ System.Collections.Generic.List<AkAmbient> list;

    /*0x21447cc*/ AkMultiPosEvent();
    /*0x21447c4*/ void FinishedPlaying(object in_cookie, AkCallbackType in_type, object in_info);
}

class AkAmbient : AkEvent
{
    static /*0x0*/ System.Collections.Generic.Dictionary<uint, AkMultiPosEvent> multiPosEventTree;
    static /*0x8*/ UnityEngine.Color SPHERE_DEFAULT_COLOR;
    /*0x90*/ AkMultiPositionType MultiPositionType;
    /*0x94*/ MultiPositionTypeLabel multiPositionTypeLabel;
    /*0x98*/ UnityEngine.Color attenuationSphereColor;
    /*0xa8*/ AkAmbientLargeModePositioner[] LargeModePositions;
    /*0xb0*/ System.Collections.Generic.List<UnityEngine.Vector3> multiPositionArray;

    static /*0x2145a58*/ AkAmbient();
    /*0x2145928*/ AkAmbient();
    /*0x2144854*/ void OnEnable();
    /*0x2144d70*/ void Start();
    /*0x2145200*/ void OnDisable();
    /*0x2145400*/ void HandleEvent(UnityEngine.GameObject in_gameObject);
    /*0x2145844*/ void OnDrawGizmosSelected();
    /*0x2144b4c*/ AkPositionArray BuildMultiDirectionArray(AkMultiPosEvent eventPosList);
    /*0x2144f58*/ AkPositionArray BuildAkPositionArray();
}

class AkAmbientLargeModePositioner : UnityEngine.MonoBehaviour
{
    /*0x2145b08*/ AkAmbientLargeModePositioner();
    /*0x21458c8*/ UnityEngine.Vector3 get_Position();
    /*0x21458e8*/ UnityEngine.Vector3 get_Forward();
    /*0x2145908*/ UnityEngine.Vector3 get_Up();
}

class AkAudioListener : UnityEngine.MonoBehaviour
{
    static /*0x0*/ AkAudioListener.DefaultListenerList defaultListeners;
    /*0x20*/ ulong akGameObjectID;
    /*0x28*/ System.Collections.Generic.List<AkGameObj> EmittersToStartListeningTo;
    /*0x30*/ System.Collections.Generic.List<AkGameObj> EmittersToStopListeningTo;
    /*0x38*/ bool isDefaultListener;
    /*0x3c*/ int listenerId;

    static /*0x21464ac*/ AkAudioListener();
    static /*0x2145b10*/ AkAudioListener.DefaultListenerList get_DefaultListeners();
    /*0x21463f0*/ AkAudioListener();
    /*0x2145b68*/ void StartListeningToEmitter(AkGameObj emitter);
    /*0x2145be8*/ void StopListeningToEmitter(AkGameObj emitter);
    /*0x2145c68*/ void SetIsDefaultListener(bool isDefault);
    /*0x2145d90*/ void Awake();
    /*0x2145f5c*/ void OnEnable();
    /*0x2146010*/ void OnDisable();
    /*0x21460c4*/ void OnDestroy();
    /*0x2146130*/ void Update();
    /*0x2146328*/ ulong GetAkGameObjectID();
    /*0x2146330*/ void Migrate14();

    class BaseListenerList
    {
        /*0x10*/ System.Collections.Generic.List<ulong> listenerIdList;
        /*0x18*/ System.Collections.Generic.List<AkAudioListener> listenerList;

        /*0x214676c*/ BaseListenerList();
        /*0x2146528*/ System.Collections.Generic.List<AkAudioListener> get_ListenerList();
        /*0x2146530*/ bool Add(AkAudioListener listener);
        /*0x214663c*/ bool Remove(AkAudioListener listener);
        /*0x214671c*/ ulong[] GetListenerIds();
    }

    class DefaultListenerList : AkAudioListener.BaseListenerList
    {
        /*0x2146524*/ DefaultListenerList();
        /*0x2146848*/ bool Add(AkAudioListener listener);
        /*0x21468f8*/ bool Remove(AkAudioListener listener);
    }
}

class AkBank : AkTriggerHandler
{
    /*0x38*/ AK.Wwise.Bank data;
    /*0x40*/ bool decodeBank;
    /*0x41*/ bool overrideLoadSetting;
    /*0x42*/ bool loadAsynchronous;
    /*0x43*/ bool saveDecodedBank;
    /*0x48*/ System.Collections.Generic.List<int> unloadTriggerList;
    /*0x50*/ string bankNameInternal;
    /*0x58*/ byte[] valueGuidInternal;

    /*0x21478f8*/ AkBank();
    /*0x21469a8*/ void Awake();
    /*0x21470a4*/ void Start();
    /*0x21471b8*/ void HandleEvent(UnityEngine.GameObject in_gameObject);
    /*0x2147268*/ void HandleEvent();
    /*0x21471a0*/ void UnloadBank(UnityEngine.GameObject in_gameObject);
    /*0x2147290*/ void OnDestroy();
    /*0x2147818*/ string get_bankName();
    /*0x2147844*/ byte[] get_valueGuid();
}

class AkEarlyReflections : UnityEngine.MonoBehaviour
{
    /*0x20*/ AK.Wwise.AuxBus reflectionsAuxBus;
    /*0x28*/ float reflectionsVolume;

    /*0x2147c4c*/ AkEarlyReflections();
    /*0x2147ae0*/ void OnEnable();
    /*0x2147bbc*/ void SetEarlyReflectionsVolume(float volume);
}

class AkEmitterObstructionOcclusion : AkObstructionOcclusion
{
    /*0x50*/ AkGameObj m_gameObj;

    /*0x2148480*/ AkEmitterObstructionOcclusion();
    /*0x2147cc0*/ void Awake();
    /*0x2147d98*/ void UpdateCurrentListenerList();
    /*0x21480ac*/ void SetObstructionOcclusion(System.Collections.Generic.KeyValuePair<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue> ObsOccPair);
}

class AkEnvironment : UnityEngine.MonoBehaviour
{
    static int MAX_NB_ENVIRONMENTS = 4;
    static /*0x0*/ AkEnvironment.AkEnvironment_CompareByPriority s_compareByPriority;
    static /*0x8*/ AkEnvironment.AkEnvironment_CompareBySelectionAlgorithm s_compareBySelectionAlgorithm;
    /*0x20*/ bool excludeOthers;
    /*0x21*/ bool isDefault;
    /*0x28*/ AK.Wwise.AuxBus data;
    /*0x30*/ UnityEngine.Collider <Collider>k__BackingField;
    /*0x38*/ int priority;
    /*0x3c*/ int auxBusIdInternal;
    /*0x40*/ byte[] valueGuidInternal;

    static /*0x2148774*/ AkEnvironment();
    /*0x2148708*/ AkEnvironment();
    /*0x21485a8*/ UnityEngine.Collider get_Collider();
    /*0x21485b0*/ void set_Collider(UnityEngine.Collider value);
    /*0x21485b8*/ void Awake();
    /*0x2148620*/ int get_m_auxBusID();
    /*0x2148634*/ byte[] get_valueGuid();
    /*0x21486e8*/ uint GetAuxBusID();
    /*0x2148700*/ UnityEngine.Collider GetCollider();

    class AkEnvironment_CompareByPriority : System.Collections.Generic.IComparer<AkEnvironment>
    {
        /*0x2148834*/ AkEnvironment_CompareByPriority();
        /*0x2148844*/ int Compare(AkEnvironment a, AkEnvironment b);
    }

    class AkEnvironment_CompareBySelectionAlgorithm : AkEnvironment.AkEnvironment_CompareByPriority
    {
        /*0x214883c*/ AkEnvironment_CompareBySelectionAlgorithm();
        /*0x21488cc*/ int Compare(AkEnvironment a, AkEnvironment b);
    }
}

class AkEnvironmentPortal : UnityEngine.MonoBehaviour
{
    static int MAX_ENVIRONMENTS_PER_PORTAL = 2;
    /*0x20*/ UnityEngine.Vector3 axis;
    /*0x30*/ AkEnvironment[] environments;
    /*0x38*/ UnityEngine.BoxCollider m_BoxCollider;

    /*0x2148da0*/ AkEnvironmentPortal();
    /*0x214892c*/ UnityEngine.BoxCollider get_BoxCollider();
    /*0x21489d4*/ bool get_EnvironmentsShareAuxBus();
    /*0x2148b68*/ float GetAuxSendValueForPosition(UnityEngine.Vector3 in_position, int index);
}

class AkEventCallbackMsg
{
    /*0x10*/ AkCallbackInfo info;
    /*0x18*/ UnityEngine.GameObject sender;
    /*0x20*/ AkCallbackType type;

    /*0x2148e44*/ AkEventCallbackMsg();
}

class AkEvent : AkDragDropTriggerHandler
{
    /*0x34*/ AkActionOnEventType actionOnEventType;
    /*0x38*/ AkCurveInterpolation curveInterpolation;
    /*0x3c*/ bool enableActionOnEvent;
    /*0x40*/ AK.Wwise.Event data;
    /*0x48*/ bool useCallbacks;
    /*0x50*/ System.Collections.Generic.List<AkEvent.CallbackData> Callbacks;
    /*0x58*/ uint playingId;
    /*0x60*/ UnityEngine.GameObject soundEmitterObject;
    /*0x68*/ float transitionDuration;
    /*0x70*/ AkEventCallbackMsg EventCallbackMsg;
    /*0x78*/ int eventIdInternal;
    /*0x80*/ byte[] valueGuidInternal;
    /*0x88*/ AkEventCallbackData m_callbackDataInternal;

    /*0x2145994*/ AkEvent();
    /*0x2148e4c*/ AK.Wwise.BaseType get_WwiseType();
    /*0x2148e54*/ void Awake();
    /*0x2144ea8*/ void Start();
    /*0x2148e60*/ void Callback(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info);
    /*0x21455fc*/ void HandleEvent(UnityEngine.GameObject in_gameObject);
    /*0x2148fc4*/ void Stop(int _transitionDuration);
    /*0x2148fcc*/ void Stop(int _transitionDuration, AkCurveInterpolation _curveInterpolation);
    /*0x2149074*/ int get_eventID();
    /*0x2149088*/ byte[] get_valueGuid();
    /*0x214913c*/ AkEventCallbackData get_m_callbackData();

    class CallbackData
    {
        /*0x10*/ AK.Wwise.CallbackFlags Flags;
        /*0x18*/ string FunctionName;
        /*0x20*/ UnityEngine.GameObject GameObject;

        /*0x2149198*/ CallbackData();
        /*0x2148f1c*/ void CallFunction(AkEventCallbackMsg eventCallbackMsg);
    }
}

class AkEventCallbackData : UnityEngine.ScriptableObject
{
    /*0x18*/ System.Collections.Generic.List<int> callbackFlags;
    /*0x20*/ System.Collections.Generic.List<string> callbackFunc;
    /*0x28*/ System.Collections.Generic.List<UnityEngine.GameObject> callbackGameObj;
    /*0x30*/ int uFlags;

    /*0x21491a0*/ AkEventCallbackData();
}

class AkGameObj : UnityEngine.MonoBehaviour
{
    static int AK_NUM_LISTENERS = 8;
    /*0x20*/ AkGameObjListenerList m_listeners;
    /*0x28*/ bool isEnvironmentAware;
    /*0x29*/ bool isStaticObject;
    /*0x30*/ UnityEngine.Collider m_Collider;
    /*0x38*/ AkGameObjEnvironmentData m_envData;
    /*0x40*/ AkGameObjPositionData m_posData;
    /*0x48*/ AkGameObjPositionOffsetData m_positionOffsetData;
    /*0x50*/ float scalingFactor;
    /*0x54*/ bool isRegistered;
    /*0x58*/ AkGameObjPosOffsetData m_posOffsetData;
    /*0x60*/ int listenerMask;

    /*0x214a2e4*/ AkGameObj();
    /*0x21492d0*/ float get_ScalingFactor();
    /*0x21492d8*/ void set_ScalingFactor(float value);
    /*0x214807c*/ bool get_IsUsingDefaultListeners();
    /*0x2148094*/ System.Collections.Generic.List<AkAudioListener> get_ListenerList();
    /*0x21462f0*/ void AddListener(AkAudioListener listener);
    /*0x214630c*/ void RemoveListener(AkAudioListener listener);
    /*0x2145e78*/ AKRESULT Register();
    /*0x21492ec*/ void UnregisterGameObject();
    /*0x2149358*/ AKRESULT Unregister();
    /*0x2149424*/ void SetPosition();
    /*0x2149604*/ void Awake();
    /*0x21496b4*/ void RegisterGameObject();
    /*0x2149d2c*/ void CheckStaticStatus();
    /*0x2149d30*/ void OnEnable();
    /*0x2149d34*/ void OnDestroy();
    /*0x2149ed0*/ void Update();
    /*0x2149f40*/ UnityEngine.Vector3 GetPosition();
    /*0x2149fe0*/ UnityEngine.Vector3 GetForward();
    /*0x214a000*/ UnityEngine.Vector3 GetUpward();
    /*0x214a020*/ void OnTriggerEnter(UnityEngine.Collider other);
    /*0x214a038*/ void OnTriggerExit(UnityEngine.Collider other);
}

class AkGameObjEnvironmentData
{
    /*0x10*/ System.Collections.Generic.List<AkEnvironment> activeEnvironments;
    /*0x18*/ System.Collections.Generic.List<AkEnvironment> activeEnvironmentsFromPortals;
    /*0x20*/ System.Collections.Generic.List<AkEnvironmentPortal> activePortals;
    /*0x28*/ AkAuxSendArray auxSendValues;
    /*0x30*/ UnityEngine.Vector3 lastPosition;
    /*0x3c*/ bool hasEnvironmentListChanged;
    /*0x3d*/ bool hasActivePortalListChanged;
    /*0x3e*/ bool hasSentZero;

    /*0x214986c*/ AkGameObjEnvironmentData();
    /*0x214a3ec*/ void AddHighestPriorityEnvironmentsFromPortals(UnityEngine.Vector3 position);
    /*0x214a6e4*/ void AddHighestPriorityEnvironments(UnityEngine.Vector3 position);
    /*0x2149b34*/ void UpdateAuxSend(UnityEngine.GameObject gameObject, UnityEngine.Vector3 position);
    /*0x214a818*/ void TryAddEnvironment(AkEnvironment env);
    /*0x214a980*/ void RemoveEnvironment(AkEnvironment env);
    /*0x21499ec*/ void AddAkEnvironment(UnityEngine.Collider environmentCollider, UnityEngine.Collider gameObjectCollider);
    /*0x214a9f8*/ bool AkEnvironmentBelongsToActivePortals(AkEnvironment env);
    /*0x214a058*/ void RemoveAkEnvironment(UnityEngine.Collider environmentCollider, UnityEngine.Collider gameObjectCollider);
}

class AkGameObjListenerList : AkAudioListener.BaseListenerList
{
    /*0x20*/ AkGameObj akGameObj;
    /*0x28*/ System.Collections.Generic.List<AkAudioListener> initialListenerList;
    /*0x30*/ bool useDefaultListeners;

    /*0x214a360*/ AkGameObjListenerList();
    /*0x214ab20*/ void SetUseDefaultListeners(bool useDefault);
    /*0x2149c20*/ void Init(AkGameObj akGameObj);
    /*0x214ace0*/ bool Add(AkAudioListener listener);
    /*0x214adb0*/ bool Remove(AkAudioListener listener);
}

class AkGameObjPositionData
{
    /*0x10*/ UnityEngine.Vector3 forward;
    /*0x1c*/ UnityEngine.Vector3 position;
    /*0x28*/ UnityEngine.Vector3 up;

    /*0x21496ac*/ AkGameObjPositionData();
}

class AkGameObjPositionOffsetData
{
    /*0x10*/ bool KeepMe;
    /*0x14*/ UnityEngine.Vector3 positionOffset;

    /*0x214ae80*/ AkGameObjPositionOffsetData(bool IReallyWantToBeConstructed);
}

class AkGameObjPosOffsetData : UnityEngine.ScriptableObject
{
    /*0x18*/ UnityEngine.Vector3 positionOffset;

    /*0x214aea8*/ AkGameObjPosOffsetData();
}

class AkInitializer : UnityEngine.MonoBehaviour
{
    static /*0x0*/ AkInitializer ms_Instance;
    static /*0x8*/ AkSurfaceReflector.GeometryData CubeGeometryData;
    static /*0x30*/ AkSurfaceReflector.GeometryData SphereGeometryData;
    /*0x20*/ AkWwiseInitializationSettings InitializationSettings;

    static /*0x214bdc4*/ UnityEngine.GameObject GetAkInitializerGameObject();
    /*0x214c3dc*/ AkInitializer();
    /*0x214aeb0*/ void CreateRoomGeometryData();
    /*0x214bc04*/ void Awake();
    /*0x214bce8*/ bool IsInstance();
    /*0x214beb0*/ void OnEnable();
    /*0x214beec*/ void InitializeInitializationSettings();
    /*0x214c17c*/ void OnDisable();
    /*0x214c1a0*/ void OnDestroy();
    /*0x214c210*/ void OnApplicationPause(bool pauseStatus);
    /*0x214c258*/ void OnApplicationFocus(bool focus);
    /*0x214c27c*/ void OnApplicationQuit();
    /*0x214c2e0*/ void LateUpdate();
}

class AkListenerDistanceProbe : UnityEngine.MonoBehaviour
{
    /*0x20*/ AkGameObj distanceProbe;

    /*0x214c540*/ AkListenerDistanceProbe();
    /*0x214c3e4*/ void OnEnable();
    /*0x214c4c8*/ void OnDisable();
}

class AkMemBankLoader : UnityEngine.MonoBehaviour
{
    static int WaitMs = 50;
    static long AK_BANK_PLATFORM_DATA_ALIGNMENT = 16;
    static long AK_BANK_PLATFORM_DATA_ALIGNMENT_MASK = 15;
    /*0x20*/ string bankName;
    /*0x28*/ bool isLocalizedBank;
    /*0x30*/ string m_bankPath;
    /*0x38*/ uint ms_bankID;
    /*0x40*/ nint ms_pInMemoryBankPtr;
    /*0x48*/ System.Runtime.InteropServices.GCHandle ms_pinnedArray;
    /*0x50*/ UnityEngine.Networking.UnityWebRequest ms_www;

    /*0x214cad4*/ AkMemBankLoader();
    /*0x214c548*/ void Start();
    /*0x214c674*/ void LoadNonLocalizedBank(string in_bankFilename);
    /*0x214c55c*/ void LoadLocalizedBank(string in_bankFilename);
    /*0x214c778*/ uint AllocateAlignedBuffer(byte[] data);
    /*0x214c9b8*/ System.Collections.IEnumerator LoadFile();
    /*0x214c74c*/ void DoLoadBank(string in_bankPath);
    /*0x214ca4c*/ void OnDestroy();

    class <LoadFile>d__14 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ AkMemBankLoader <>4__this;

        /*0x214ca24*/ <LoadFile>d__14(int <>1__state);
        /*0x214cb30*/ void System.IDisposable.Dispose();
        /*0x214cb34*/ bool MoveNext();
        /*0x214ccfc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x214cd04*/ void System.Collections.IEnumerator.Reset();
        /*0x214cd3c*/ object System.Collections.IEnumerator.get_Current();
    }
}

class AkObstructionOcclusion : UnityEngine.MonoBehaviour
{
    /*0x20*/ System.Collections.Generic.List<AkAudioListener> listenersToRemove;
    /*0x28*/ System.Collections.Generic.List<AkAudioListener> currentListenerList;
    /*0x30*/ System.Collections.Generic.Dictionary<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue> ObstructionOcclusionValues;
    /*0x38*/ float fadeRate;
    /*0x3c*/ float fadeTime;
    /*0x40*/ UnityEngine.LayerMask LayerMask;
    /*0x44*/ float maxDistance;
    /*0x48*/ float refreshInterval;
    /*0x4c*/ float refreshTime;

    /*0x2148484*/ AkObstructionOcclusion();
    /*0x2147d54*/ void InitIntervalsAndFadeRates();
    /*0x1f309e4*/ void UpdateCurrentListenerList();
    /*0x214cd44*/ void UpdateObstructionOcclusionValues();
    /*0x214d244*/ void CastRays();
    void SetObstructionOcclusion(System.Collections.Generic.KeyValuePair<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue> ObsOccPair);
    /*0x214d71c*/ void Update();

    class ObstructionOcclusionValue
    {
        /*0x10*/ float currentValue;
        /*0x14*/ float targetValue;

        /*0x214d23c*/ ObstructionOcclusionValue();
        /*0x214da1c*/ bool Update(float fadeRate);
    }
}

class AkRadialEmitter : UnityEngine.MonoBehaviour
{
    /*0x20*/ float outerRadius;
    /*0x24*/ float innerRadius;
    /*0x28*/ float previousOuterRadius;
    /*0x2c*/ float previousInnerRadius;

    /*0x214ddc8*/ AkRadialEmitter();
    /*0x214db08*/ void SetGameObjectOuterRadius(float in_outerRadius);
    /*0x214dba0*/ void SetGameObjectInnerRadius(float in_innerRadius);
    /*0x214dc38*/ void SetGameObjectRadius(float in_outerRadius, float in_innerRadius);
    /*0x214dcd0*/ void SetGameObjectRadius();
    /*0x214dd54*/ void SetGameObjectRadius(UnityEngine.GameObject in_gameObject);
    /*0x214ddc4*/ void OnEnable();
}

class AkReverbZone : UnityEngine.MonoBehaviour
{
    /*0x20*/ AkRoom ReverbZone;
    /*0x28*/ AkRoom ParentRoom;
    /*0x30*/ float TransitionRegionWidth;
    /*0x34*/ bool needsUpdate;

    static /*0x214ddd0*/ void SetReverbZone(AkRoom reverbZone, AkRoom parentRoom, float transitionRegionWidth);
    static /*0x214e01c*/ void RemoveReverbZone(AkRoom reverbZone);
    /*0x214e2bc*/ AkReverbZone();
    /*0x214e148*/ void SetReverbZone();
    /*0x214e16c*/ void RemoveReverbZone();
    /*0x214e174*/ void OnEnable();
    /*0x214e198*/ void OnDisable();
    /*0x214e1a0*/ void OnValidate();
    /*0x214e288*/ void Update();
}

class AkRoom : AkTriggerHandler
{
    static /*0x0*/ ulong INVALID_ROOM_ID;
    static /*0x8*/ int <RoomCount>k__BackingField;
    /*0x34*/ int priority;
    /*0x38*/ AK.Wwise.AuxBus reverbAuxBus;
    /*0x40*/ float reverbLevel;
    /*0x44*/ float transmissionLoss;
    /*0x48*/ AK.Wwise.Event roomToneEvent;
    /*0x50*/ float roomToneAuxSend;
    /*0x58*/ System.Collections.Generic.List<AkRoomAwareObject> roomAwareObjectsEntered;
    /*0x60*/ System.Collections.Generic.List<AkRoomAwareObject> roomAwareObjectsDetectedWhileDisabled;
    /*0x68*/ UnityEngine.Collider roomCollider;
    /*0x70*/ int previousRoomState;
    /*0x74*/ int previousTransformState;
    /*0x78*/ int previousGeometryState;
    /*0x7c*/ bool bSentToWwise;
    /*0x80*/ ulong geometryID;
    /*0x88*/ bool bGeometrySetByRoom;
    /*0x89*/ bool _isAReverbZoneInWwise;
    /*0x90*/ ulong _parentRoomID;

    static /*0x2151378*/ AkRoom();
    static /*0x214e2cc*/ ulong GetAkRoomID(AkRoom room);
    static /*0x214e3e4*/ int get_RoomCount();
    static /*0x214e43c*/ void set_RoomCount(int value);
    /*0x21511c8*/ AkRoom();
    /*0x214e498*/ bool get_IsAReverbZoneInWwise();
    /*0x214e4a0*/ ulong get_ParentRoomID();
    /*0x214e4a8*/ int GetRoomState();
    /*0x214e680*/ int GetTransformState();
    /*0x214ed30*/ int GetGeometryState();
    /*0x214ef18*/ bool TryEnter(AkRoomAwareObject roomAwareObject);
    /*0x214f02c*/ void Exit(AkRoomAwareObject roomAwareObject);
    /*0x214e378*/ ulong GetID();
    /*0x214ec98*/ bool IsAssociatedGeometryFromCollider();
    /*0x214f0e4*/ void SetGeometryFromCollider();
    /*0x214f5ec*/ void SetGeometryInstanceFromCollider();
    /*0x21500fc*/ void SetRoom();
    /*0x2150380*/ void SetRoom(ulong id);
    /*0x2150414*/ bool UsesGeometry(ulong id);
    /*0x2150424*/ void Update();
    /*0x214ecb4*/ UnityEngine.Vector3 GetCubeScaleFromCapsule(UnityEngine.Vector3 capsuleScale, float capsuleRadius, float capsuleHeight, int capsuleDirection);
    /*0x215070c*/ void OnEnable();
    /*0x2150a58*/ void OnDisable();
    /*0x2150e28*/ void OnDestroy();
    /*0x2150eb8*/ void OnTriggerEnter(UnityEngine.Collider in_other);
    /*0x2150ff8*/ void OnTriggerExit(UnityEngine.Collider in_other);
    /*0x2151138*/ void PostRoomTone();
    /*0x21511a4*/ void HandleEvent(UnityEngine.GameObject in_gameObject);
    /*0x214deb4*/ void SetReverbZone(AkRoom parentRoom, float transitionRegionWidth);
    /*0x214e0d8*/ void RemoveReverbZone();
    /*0x21511a8*/ float get_wallOcclusion();
    /*0x21511b0*/ void set_wallOcclusion(float value);
    /*0x21511b8*/ ulong GetGeometryID();
    /*0x21511c0*/ void SetGeometryID(ulong id);

    class PriorityList
    {
        static /*0x0*/ AkRoom.PriorityList.CompareByPriority s_compareByPriority;
        /*0x10*/ System.Collections.Generic.List<AkRoom> rooms;

        static /*0x215191c*/ PriorityList();
        /*0x2151894*/ PriorityList();
        /*0x21513c4*/ ulong GetHighestPriorityActiveAndEnabledRoomID();
        /*0x2151428*/ AkRoom GetHighestPriorityActiveAndEnabledRoom();
        /*0x21514ec*/ int get_Count();
        /*0x2151534*/ void Clear();
        /*0x21515d0*/ void Add(AkRoom room);
        /*0x2151728*/ void Remove(AkRoom room);
        /*0x2151780*/ bool Contains(AkRoom room);
        /*0x215164c*/ int BinarySearch(AkRoom room);
        /*0x2151828*/ AkRoom get_Item(int index);

        class CompareByPriority : System.Collections.Generic.IComparer<AkRoom>
        {
            /*0x2151998*/ CompareByPriority();
            /*0x21519a0*/ int Compare(AkRoom a, AkRoom b);
        }
    }
}

class AkRoomAwareManager
{
    static /*0x0*/ System.Collections.Generic.HashSet<AkRoomAwareObject> m_RoomAwareObjects;
    static /*0x8*/ System.Collections.Generic.HashSet<AkRoomAwareObject> m_RoomAwareObjectToUpdate;

    static /*0x2151f98*/ AkRoomAwareManager();
    static /*0x2151a38*/ void RegisterRoomAwareObject(AkRoomAwareObject roomAwareObject);
    static /*0x2151ac0*/ void UnregisterRoomAwareObject(AkRoomAwareObject roomAwareObject);
    static /*0x2150da8*/ void RegisterRoomAwareObjectForUpdate(AkRoomAwareObject roomAwareObject);
    static /*0x2150f1c*/ void ObjectEnteredRoom(UnityEngine.Collider collider, AkRoom room);
    static /*0x2150968*/ void ObjectEnteredRoom(AkRoomAwareObject roomAwareObject, AkRoom room);
    static /*0x215105c*/ void ObjectExitedRoom(UnityEngine.Collider collider, AkRoom room);
    static /*0x2151c10*/ void ObjectExitedRoom(AkRoomAwareObject roomAwareObject, AkRoom room);
    static /*0x2151cfc*/ void UpdateRoomAwareObjects();
}

class AkRoomAwareObject : UnityEngine.MonoBehaviour
{
    static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.Collider, AkRoomAwareObject> ColliderToRoomAwareObjectMap;
    /*0x20*/ UnityEngine.Collider m_Collider;
    /*0x28*/ AkRoom.PriorityList roomPriorityList;

    static /*0x2152488*/ AkRoomAwareObject();
    static /*0x2151b5c*/ AkRoomAwareObject GetAkRoomAwareObjectFromCollider(UnityEngine.Collider collider);
    /*0x2152420*/ AkRoomAwareObject();
    /*0x2152058*/ void Awake();
    /*0x215215c*/ void OnEnable();
    /*0x21521f8*/ void OnDisable();
    /*0x2152358*/ void OnDestroy();
    /*0x2151f70*/ void SetGameObjectInHighestPriorityActiveAndEnabledRoom();
    /*0x21522a8*/ void SetGameObjectInRoom(AkRoom room);
    /*0x2151bfc*/ void EnteredRoom(AkRoom room);
    /*0x2150d94*/ void ExitedRoom(AkRoom room);
}

class AkRoomManager
{
    static /*0x0*/ AkRoomManager m_Instance;
    /*0x10*/ System.Collections.Generic.List<AkRoomPortal> m_Portals;
    /*0x18*/ System.Collections.Generic.List<AkRoomPortal> m_PortalsToUpdate;
    /*0x20*/ System.Collections.Generic.List<AkSurfaceReflector> m_Reflectors;
    /*0x28*/ System.Collections.Generic.List<AkSurfaceReflector> m_ReflectorsToUpdate;

    static /*0x2152520*/ void Init();
    static /*0x21526c0*/ void Terminate();
    static /*0x2152728*/ void RegisterPortal(AkRoomPortal portal);
    static /*0x215283c*/ void UnregisterPortal(AkRoomPortal portal);
    static /*0x21528e4*/ void RegisterReflector(AkSurfaceReflector reflector);
    static /*0x21529f8*/ void UnregisterReflector(AkSurfaceReflector reflector);
    static /*0x2152aa0*/ void RegisterPortalUpdate(AkRoomPortal portal);
    static /*0x2150534*/ void RegisterRoomUpdate(AkRoom room);
    static /*0x2152c50*/ void Update();
    /*0x215259c*/ AkRoomManager();
}

class AkRoomPortal : AkTriggerHandler
{
    static int MAX_ROOMS_PER_PORTAL = 2;
    /*0x34*/ AkRoomPortal.State initialState;
    /*0x38*/ bool active;
    /*0x40*/ System.Collections.Generic.List<int> closePortalTriggerList;
    /*0x48*/ AkRoom[] rooms;
    /*0x50*/ AkRoom.PriorityList[] roomList;
    /*0x58*/ AkTransform portalTransform;
    /*0x60*/ UnityEngine.BoxCollider portalCollider;
    /*0x68*/ bool portalSet;
    /*0x69*/ bool portalNeedsUpdate;
    /*0x6c*/ UnityEngine.Vector3 previousPosition;
    /*0x78*/ UnityEngine.Vector3 previousScale;
    /*0x84*/ UnityEngine.Quaternion previousRotation;

    /*0x21540f0*/ AkRoomPortal();
    /*0x2152e9c*/ bool get_portalActive();
    /*0x2152ea4*/ void set_portalActive(bool value);
    /*0x2152eb4*/ ulong get_frontRoomID();
    /*0x2152fc4*/ ulong get_backRoomID();
    /*0x2153050*/ AkRoom GetRoom(int index);
    /*0x2152b88*/ AkRoom get_frontRoom();
    /*0x2152bb4*/ AkRoom get_backRoom();
    /*0x2153080*/ bool isSetInWwise();
    /*0x2153088*/ void SetRoomPortal();
    /*0x2152e64*/ void UpdateRoomPortal();
    /*0x2152bdc*/ bool Overlaps(AkRoom room);
    /*0x2153384*/ bool get_IsValid();
    /*0x21534c4*/ ulong GetID();
    /*0x21537a0*/ void Awake();
    /*0x2153940*/ void Start();
    /*0x21539d4*/ void HandleEvent(UnityEngine.GameObject in_gameObject);
    /*0x21539c4*/ void ClosePortal(UnityEngine.GameObject in_gameObject);
    /*0x2153a04*/ void OnDestroy();
    /*0x2153a98*/ void OnEnable();
    /*0x2153ab0*/ void OnDisable();
    /*0x2153b34*/ void Update();
    /*0x2152f40*/ bool IsRoomActive(AkRoom in_room);
    /*0x21539e4*/ void Open();
    /*0x21539f4*/ void Close();
    /*0x215361c*/ void FindOverlappingRooms(AkRoom.PriorityList[] roomList);
    /*0x2153ca8*/ void FillRoomList(UnityEngine.Vector3 position, AkRoom.PriorityList list);
    /*0x21534dc*/ bool UpdateRooms();
    /*0x2153e54*/ void SetRoom(int in_roomIndex, AkRoom in_room);
    /*0x2153f30*/ void SetFrontRoom(AkRoom room);
    /*0x215400c*/ void SetBackRoom(AkRoom room);
    /*0x21540e8*/ void UpdateSoundEngineRoomIDs();
    /*0x21540ec*/ void UpdateOverlappingRooms();

    enum State
    {
        Closed = 0,
        Open = 1,
    }
}

class AkRoomPortalObstruction : AkObstructionOcclusion
{
    /*0x50*/ AkRoomPortal m_portal;

    /*0x2154514*/ AkRoomPortalObstruction();
    /*0x21542c0*/ void Awake();
    /*0x2154354*/ void UpdateCurrentListenerList();
    /*0x21543d4*/ void SetObstructionOcclusion(System.Collections.Generic.KeyValuePair<AkAudioListener, AkObstructionOcclusion.ObstructionOcclusionValue> ObsOccPair);
}

class AkSoundEngineController
{
    static /*0x0*/ AkSoundEngineController ms_Instance;

    static /*0x214bf50*/ AkSoundEngineController get_Instance();
    /*0x2154518*/ AkSoundEngineController();
    /*0x2154520*/ void Finalize();
    /*0x214c308*/ void LateUpdate();
    /*0x21545fc*/ AkWwiseInitializationSettings GetInitSettingsInstance();
    /*0x214bfd8*/ void Init(AkInitializer akInitializer);
    /*0x214c19c*/ void OnDisable();
    /*0x214c2bc*/ void Terminate();
    /*0x214c248*/ void OnApplicationPause(bool pauseStatus);
    /*0x214c278*/ void OnApplicationFocus(bool focus);
    /*0x215464c*/ void ActivateAudio(bool activate, bool renderAnyway);
}

class AkSpatialAudioDebugDraw : UnityEngine.MonoBehaviour
{
    /*0x2154750*/ AkSpatialAudioDebugDraw();
}

class AkSpatialAudioEmitter : UnityEngine.MonoBehaviour
{
    /*0x20*/ AK.Wwise.AuxBus reflectAuxBus;
    /*0x28*/ float reflectionMaxPathLength;
    /*0x2c*/ float reflectionsAuxBusGain;
    /*0x30*/ uint reflectionsOrder;
    /*0x34*/ float roomReverbAuxBusGain;
    /*0x38*/ uint diffractionMaxEdges;
    /*0x3c*/ uint diffractionMaxPaths;
    /*0x40*/ uint diffractionMaxPathLength;

    /*0x2154758*/ AkSpatialAudioEmitter();
}

class AkSpatialAudioListener : UnityEngine.MonoBehaviour
{
    static /*0x0*/ AkSpatialAudioListener s_SpatialAudioListener;
    static /*0x8*/ AkSpatialAudioListener.SpatialAudioListenerList spatialAudioListeners;
    /*0x20*/ AkAudioListener AkAudioListener;

    static /*0x2154b04*/ AkSpatialAudioListener();
    static /*0x2147fb8*/ AkAudioListener get_TheSpatialAudioListener();
    static /*0x21547dc*/ AkSpatialAudioListener.SpatialAudioListenerList get_SpatialAudioListeners();
    /*0x2154afc*/ AkSpatialAudioListener();
    /*0x2154834*/ void Awake();
    /*0x215489c*/ void OnEnable();
    /*0x21549e0*/ void OnDisable();

    class SpatialAudioListenerList
    {
        /*0x10*/ System.Collections.Generic.List<AkSpatialAudioListener> listenerList;

        /*0x2154b74*/ SpatialAudioListenerList();
        /*0x2154bfc*/ System.Collections.Generic.List<AkSpatialAudioListener> get_ListenerList();
        /*0x2154904*/ bool Add(AkSpatialAudioListener listener);
        /*0x2154a48*/ bool Remove(AkSpatialAudioListener listener);
        /*0x2154c04*/ void Refresh();
    }
}

class AkState : AkDragDropTriggerHandler
{
    /*0x38*/ AK.Wwise.State data;
    /*0x40*/ int valueIdInternal;
    /*0x44*/ int groupIdInternal;
    /*0x48*/ byte[] valueGuidInternal;
    /*0x50*/ byte[] groupGuidInternal;

    /*0x2155050*/ AkState();
    /*0x2154ea0*/ AK.Wwise.BaseType get_WwiseType();
    /*0x2154ea8*/ void Awake();
    /*0x2154eac*/ void HandleEvent(UnityEngine.GameObject in_gameObject);
    /*0x2154ec4*/ int get_valueID();
    /*0x2154ed8*/ int get_groupID();
    /*0x2154eec*/ byte[] get_valueGuid();
    /*0x2154fa0*/ byte[] get_groupGuid();
}

class AkSurfaceReflector : UnityEngine.MonoBehaviour
{
    static /*0x0*/ ulong INVALID_GEOMETRY_ID;
    /*0x20*/ UnityEngine.Mesh Mesh;
    /*0x28*/ AK.Wwise.AcousticTexture[] AcousticTextures;
    /*0x30*/ float[] TransmissionLossValues;
    /*0x38*/ bool EnableDiffraction;
    /*0x39*/ bool EnableDiffractionOnBoundaryEdges;
    /*0x40*/ AkRoom AssociatedRoom;
    /*0x48*/ int PreviousTransformState;
    /*0x4c*/ int PreviousGeometryState;
    /*0x50*/ int PreviousAssociatedRoomState;
    /*0x54*/ bool isGeometrySetInWwise;
    /*0x58*/ AK.Wwise.AcousticTexture AcousticTextureInternal;

    static /*0x21555ac*/ bool SetGeometryFromMesh(UnityEngine.Mesh mesh, ulong geometryID, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges, AK.Wwise.AcousticTexture[] acousticTextures, float[] transmissionLossValues, string name);
    static /*0x214b020*/ void GetGeometryDataFromMesh(UnityEngine.Mesh mesh, ref AkSurfaceReflector.GeometryData geometryData, AK.Wwise.AcousticTexture[] acousticTextures, float[] transmissionLossValues, string name);
    static /*0x214ff50*/ void SetGeometryInstance(ulong geometryInstanceID, ulong geometryID, ulong associatedRoomID, UnityEngine.Transform transform, bool useForReflectionAndDiffraction);
    static /*0x2156058*/ ulong GetAkGeometrySetID(UnityEngine.MeshFilter meshFilter);
    static /*0x2156078*/ void AddGeometrySet(AK.Wwise.AcousticTexture acousticTexture, UnityEngine.MeshFilter meshFilter, ulong roomID, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges, bool enableTriangles);
    static /*0x2156518*/ void RemoveGeometrySet(UnityEngine.MeshFilter meshFilter);
    static /*0x21565e0*/ void SetGeometryFromMesh(UnityEngine.Mesh mesh, UnityEngine.Transform transform, ulong geometryID, ulong associatedRoomID, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges, bool enableTriangles, AK.Wwise.AcousticTexture[] acousticTextures, float[] transmissionLossValues, string name);
    static /*0x2156694*/ void SetGeometryFromMesh(UnityEngine.Mesh mesh, ulong geometryID, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges, bool enableTriangles, AK.Wwise.AcousticTexture[] acousticTextures, float[] transmissionLossValues, string name);
    static /*0x215671c*/ void SetGeometryInstance(ulong geometryInstanceID, ulong geometryID, ulong associatedRoomID, UnityEngine.Transform transform);
    /*0x2156724*/ AkSurfaceReflector();
    /*0x21550b8*/ int GetTransformState();
    /*0x2155280*/ int GetGeometryState();
    /*0x21554d4*/ int GetAssociatedRoomState();
    /*0x2150950*/ ulong GetID();
    /*0x21557a0*/ void SetAssociatedRoom(AkRoom room);
    /*0x215583c*/ void UpdateAssociatedRoom();
    /*0x21558c0*/ void SetGeometry();
    /*0x2155aa0*/ void SetGeometryInstance();
    /*0x2152e98*/ void UpdateGeometry();
    /*0x2155bac*/ void RemoveGeometry();
    /*0x2155c18*/ void RemoveGeometryInstance();
    /*0x2155c84*/ void Awake();
    /*0x2155d68*/ void OnEnable();
    /*0x2155ebc*/ void OnDisable();
    /*0x2155fbc*/ void OnDestroy();
    /*0x2155fcc*/ void Update();
    /*0x2156350*/ AK.Wwise.AcousticTexture get_AcousticTexture();
    /*0x2156374*/ void set_AcousticTexture(AK.Wwise.AcousticTexture value);
    /*0x21565d0*/ float[] get_OcclusionValues();
    /*0x21565d8*/ void set_OcclusionValues(float[] value);

    struct GeometryData
    {
        /*0x10*/ UnityEngine.Vector3[] vertices;
        /*0x18*/ AkTriangleArray triangles;
        /*0x20*/ AkAcousticSurfaceArray surfaces;
        /*0x28*/ uint numVertices;
        /*0x2c*/ uint numTriangles;
        /*0x30*/ uint numSurfaces;
    }
}

class AkSwitch : AkDragDropTriggerHandler
{
    /*0x38*/ AK.Wwise.Switch data;
    /*0x40*/ int valueIdInternal;
    /*0x44*/ int groupIdInternal;
    /*0x48*/ byte[] valueGuidInternal;
    /*0x50*/ byte[] groupGuidInternal;

    /*0x2156a4c*/ AkSwitch();
    /*0x215681c*/ AK.Wwise.BaseType get_WwiseType();
    /*0x2156824*/ void Awake();
    /*0x2156828*/ void HandleEvent(UnityEngine.GameObject in_gameObject);
    /*0x21568c0*/ int get_valueID();
    /*0x21568d4*/ int get_groupID();
    /*0x21568e8*/ byte[] get_valueGuid();
    /*0x215699c*/ byte[] get_groupGuid();
}

class AkTerminator : UnityEngine.MonoBehaviour
{
    /*0x2156ab4*/ AkTerminator();
}

class AkTriggerBase : UnityEngine.MonoBehaviour
{
    /*0x20*/ AkTriggerBase.Trigger triggerDelegate;

    static /*0x2156abc*/ System.Collections.Generic.Dictionary<uint, string> GetAllDerivedTypes();
    /*0x2156dcc*/ AkTriggerBase();

    class Trigger : System.MulticastDelegate
    {
        /*0x2146aa0*/ Trigger(object object, nint method);
        /*0x2156dd4*/ void Invoke(UnityEngine.GameObject in_gameObject);
        /*0x2156de8*/ System.IAsyncResult BeginInvoke(UnityEngine.GameObject in_gameObject, System.AsyncCallback callback, object object);
        /*0x2156e08*/ void EndInvoke(System.IAsyncResult result);
    }
}

class AkTriggerCollisionEnter : AkTriggerBase
{
    /*0x28*/ UnityEngine.GameObject triggerObject;

    /*0x215700c*/ AkTriggerCollisionEnter();
    /*0x2156e14*/ void OnCollisionEnter(UnityEngine.Collision in_other);
    /*0x2156f10*/ void OnTriggerEnter(UnityEngine.Collider in_other);
}

class AkTriggerCollisionExit : AkTriggerBase
{
    /*0x28*/ UnityEngine.GameObject triggerObject;

    /*0x2157110*/ AkTriggerCollisionExit();
    /*0x2157014*/ void OnCollisionExit(UnityEngine.Collision in_other);
}

class AkTriggerDisable : AkTriggerBase
{
    /*0x2157138*/ AkTriggerDisable();
    /*0x2157118*/ void OnDisable();
}

class AkTriggerEnable : AkTriggerBase
{
    /*0x2157140*/ AkTriggerEnable();
}

class AkTriggerEnter : AkTriggerBase
{
    /*0x28*/ UnityEngine.GameObject triggerObject;

    /*0x2157244*/ AkTriggerEnter();
    /*0x2157148*/ void OnTriggerEnter(UnityEngine.Collider in_other);
}

class AkTriggerExit : AkTriggerBase
{
    /*0x28*/ UnityEngine.GameObject triggerObject;

    /*0x2157348*/ AkTriggerExit();
    /*0x215724c*/ void OnTriggerExit(UnityEngine.Collider in_other);
}

class AkTriggerHandler : UnityEngine.MonoBehaviour
{
    static int AWAKE_TRIGGER_ID = 1151176110;
    static int START_TRIGGER_ID = 1281810935;
    static int DESTROY_TRIGGER_ID = -358577003;
    static int ON_ENABLE_TRIGGER_ID = -320808462;
    static int ON_DISABLE_TRIGGER_ID = 716467161;
    static int MAX_NB_TRIGGERS = 32;
    static /*0x0*/ System.Collections.Generic.Dictionary<uint, string> triggerTypes;
    /*0x20*/ bool didDestroy;
    /*0x28*/ System.Collections.Generic.List<int> triggerList;
    /*0x30*/ bool useOtherObject;

    static /*0x2157350*/ AkTriggerHandler();
    /*0x2147a1c*/ AkTriggerHandler();
    /*0x1f30ebc*/ void HandleEvent(UnityEngine.GameObject in_gameObject);
    /*0x2146a34*/ void Awake();
    /*0x2147124*/ void Start();
    /*0x2147324*/ void OnDestroy();
    /*0x2149e58*/ void DoDestroy();
    /*0x2144cf4*/ void OnEnable();
    /*0x2146b50*/ void RegisterTriggers(System.Collections.Generic.List<int> in_triggerList, AkTriggerBase.Trigger in_delegate);
    /*0x2147334*/ void UnregisterTriggers(System.Collections.Generic.List<int> in_triggerList, AkTriggerBase.Trigger in_delegate);
}

class AkDragDropTriggerHandler : AkTriggerHandler
{
    /*0x2149144*/ AkDragDropTriggerHandler();
    /*0x1f30214*/ AK.Wwise.BaseType get_WwiseType();
    /*0x2148e58*/ void Awake();
    /*0x2148e5c*/ void Start();
    /*0x21573a8*/ void OnDestroy();
}

class AkTriggerMouseDown : AkTriggerBase
{
    /*0x21573d8*/ AkTriggerMouseDown();
    /*0x21573b8*/ void OnMouseDown();
}

class AkTriggerMouseEnter : AkTriggerBase
{
    /*0x2157400*/ AkTriggerMouseEnter();
    /*0x21573e0*/ void OnMouseEnter();
}

class AkTriggerMouseExit : AkTriggerBase
{
    /*0x2157428*/ AkTriggerMouseExit();
    /*0x2157408*/ void OnMouseExit();
}

class AkTriggerMouseUp : AkTriggerBase
{
    /*0x2157450*/ AkTriggerMouseUp();
    /*0x2157430*/ void OnMouseUp();
}

class AkWwiseTrigger : AkDragDropTriggerHandler
{
    /*0x38*/ AK.Wwise.Trigger data;

    /*0x21574fc*/ AkWwiseTrigger();
    /*0x2157458*/ AK.Wwise.BaseType get_WwiseType();
    /*0x2157460*/ void Awake();
    /*0x2157464*/ void Start();
    /*0x2157468*/ void HandleEvent(UnityEngine.GameObject in_gameObject);
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x2157564*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x2157658*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 4096F705705566C17DBFB58134F10CE891ACDDFF4B3D186E24333840545C86AF;
    static /*0x64f*/ <PrivateImplementationDetails> A3AFCA2BA164D6BA029EFA18042EE4890664FF6A429B8BEC55555C9884C984F6;

    struct __StaticArrayInitTypeSize=1615
    {
    }

    struct __StaticArrayInitTypeSize=3130
    {
    }
}
