class <Module>
{
}

struct NimbleBridge_Map
{
    /*0x10*/ int length;
    /*0x18*/ nint keys;
    /*0x20*/ nint values;
}

class MarshalUtility
{
    static /*0x2bbe37c*/ System.Collections.Generic.Dictionary<string, string> ConvertMapToDictionary(NimbleBridge_Map map, MarshalUtility.MarshalType marshalType);
    static /*0x2bbe56c*/ nint StringToCoTaskMemUtf8(string managedString);
    static /*0x2bbe62c*/ NimbleBridge_Map ConvertDictionaryToMap(System.Collections.Generic.Dictionary<string, string> dictionary);
    static /*0x2bbeae0*/ string[] ConvertPtrToStringArray(nint ptr, MarshalUtility.MarshalType marshalType);
    static /*0x2bbecb0*/ nint ConvertArrayToPtr(System.Collections.Generic.ICollection<string> array);
    static /*0x1ffc854*/ T[] ConvertPtrToArray<T>(nint ptr, System.Func<nint, T> factory);
    static /*0x1ffc854*/ T[] ConvertPtrToArray<T>(int length, nint arrayPtr, MarshalUtility.MarshalType marshalType);
    static /*0x2bbf0fc*/ double DateTimeToUnixTimeStamp(System.DateTime dateTime);

    enum MarshalType
    {
        ReturnValue = 0,
        CallbackParam = 1,
        OutParam = 2,
    }
}

class NimbleBridge_ApplicationConfiguration
{
    static /*0x2bbf20c*/ void NimbleBridge_ApplicationConfiguration_loadConfig(string jsonString);
    static /*0x2bbf210*/ void LoadConfig(string jsonString);
}

class NimbleBridge_ApplicationLifeCycle
{
    static /*0x2bbf214*/ void NimbleBridge_ApplicationLifeCycle_notifyApplicationLaunch(NimbleBridge_Map launchOptions);
    static /*0x2bbf218*/ void NimbleBridge_ApplicationLifeCycle_notifyApplicationSuspend();
    static /*0x2bbf21c*/ void NimbleBridge_ApplicationLifeCycle_notifyApplicationResume();
    static /*0x2bbf220*/ void NimbleBridge_ApplicationLifeCycle_notifyApplicationQuit();
    static /*0x2bbf224*/ NimbleBridge_ApplicationLifeCycle GetComponent();
    /*0x2bbf278*/ NimbleBridge_ApplicationLifeCycle();
    /*0x2bbf280*/ void NotifyApplicationLaunch(System.Collections.Generic.Dictionary<string, string> launchOptions);
    /*0x2bbf300*/ void NotifyApplicationSuspend();
    /*0x2bbf304*/ void NotifyApplicationResume();
    /*0x2bbf308*/ void NotifyApplicationQuit();
}

class NimbleBridge_CallbackHelper : UnityEngine.MonoBehaviour
{
    static /*0x0*/ NimbleBridge_CallbackHelper s_instance;
    /*0x20*/ System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<nint, System.Action>> m_pendingCallbacks;
    /*0x28*/ System.Collections.Generic.HashSet<nint> m_validCallbackSet;
    /*0x30*/ System.Collections.Generic.List<nint> m_deletedCallbackList;

    static /*0x2bbf598*/ void NimbleBridge_setInvalidateCallback(NimbleBridge_CallbackHelper.BridgeIntPtrCallback callback);
    static /*0x2bbf618*/ void NimbleBridge_setDisposeCallbackOnMainThread(NimbleBridge_CallbackHelper.BridgeIntPtrCallback callback);
    static /*0x2bbf698*/ void NimbleBridge_notifyApplicationQuit();
    static /*0x2bbf778*/ NimbleBridge_CallbackHelper Get();
    static /*0x2bbf30c*/ void InvalidateCallback(nint userInfoPtr);
    static /*0x2bbf454*/ void DisposeCallbackOnMainThread(nint userInfoPtr);
    /*0x2bc06cc*/ NimbleBridge_CallbackHelper();
    /*0x2bbf6fc*/ void Awake();
    /*0x2bbf9a8*/ nint MakeCallbackData(object data);
    /*0x2bbfad0*/ object GetData(nint dataPtr);
    /*0x2bbfb4c*/ void RunOnMainThread(nint callbackData, System.Action action);
    /*0x2bbfc94*/ void Update();
    /*0x2bc06c8*/ void OnApplicationQuit();

    class BridgeIntPtrCallback : System.MulticastDelegate
    {
        /*0x2bbf908*/ BridgeIntPtrCallback(object object, nint method);
        /*0x2bc07fc*/ void Invoke(nint userInfoPtr);
    }
}

class NimbleBridge_Error : System.Runtime.InteropServices.SafeHandle
{
    static /*0x2bc0810*/ void NimbleBridge_Error_Dispose(nint errorWrapper);
    static /*0x2bc088c*/ bool NimbleBridge_Error_isNull(NimbleBridge_Error errorWrapper);
    static /*0x2bc0954*/ int NimbleBridge_Error_getCode(NimbleBridge_Error errorWrapper);
    static /*0x2bc0a18*/ string NimbleBridge_Error_getReason(NimbleBridge_Error errorWrapper);
    static /*0x2bc0aec*/ NimbleBridge_Error NimbleBridge_Error_getCause(NimbleBridge_Error errorWrapper);
    static /*0x2bc0c0c*/ string NimbleBridge_Error_getDomain(NimbleBridge_Error errorWrapper);
    /*0x2bc0bfc*/ NimbleBridge_Error();
    /*0x2bc0ce0*/ NimbleBridge_Error(nint handle);
    /*0x2bc0d10*/ bool get_IsInvalid();
    /*0x2bc0d20*/ bool ReleaseHandle();
    /*0x2bc0d38*/ bool IsNull();
    /*0x2bc0d3c*/ NimbleBridge_Error.Code GetCode();
    /*0x2bc0d40*/ string GetReason();
    /*0x2bc0d44*/ NimbleBridge_Error GetCause();
    /*0x2bc0d48*/ string GetDomain();
    /*0x2bc0d4c*/ string ToString();

    enum Code
    {
        UNKNOWN = 0,
        SYSTEM_UNEXPECTED = 100,
        NOT_READY = 101,
        UNSUPPORTED = 102,
        NOT_AVAILABLE = 103,
        NOT_IMPLEMENTED = 104,
        INVALID_ARGUMENT = 300,
        MISSING_CALLBACK = 301,
        NETWORK_UNSUPPORTED_CONNECTION_TYPE = 1001,
        NETWORK_NO_CONNECTION = 1002,
        NETWORK_UNREACHABLE = 1003,
        NETWORK_OVERSIZE_DATA = 1004,
        NETWORK_OPERATION_CANCELLED = 1005,
        NETWORK_INVALID_SERVER_RESPONSE = 1006,
        NETWORK_TIMEOUT = 1007,
        NETWORK_CONNECTION_ERROR = 1010,
        SYNERGY_SERVER_FULL = 2001,
        SYNERGY_GET_DIRECTION_TIMED_OUT = 2002,
        SYNERGY_GET_EA_DEVICE_ID_FAILURE = 2003,
        SYNERGY_VALIDATE_EA_DEVICE_ID_FAILURE = 2004,
        SYNERGY_GET_ANONYMOUS_ID_FAILURE = 2005,
        SYNERGY_ENVIRONMENT_UPDATE_FAILURE = 2006,
        SYNERGY_PURCHASE_VERIFICATION_FAILURE = 2007,
        SYNERGY_GET_NONCE_FAILURE = 2008,
        NOT_A_ERROR = -2147483648,
    }
}

class NimbleBridge_LifeCycleHelper : UnityEngine.MonoBehaviour
{
    /*0x20*/ string bundleId;
    /*0x28*/ string appName;
    /*0x30*/ string appVersion;
    /*0x38*/ string serverEnvironment;
    /*0x40*/ string releaseType;
    /*0x48*/ string platformOverride;
    /*0x50*/ string pinLintLevel;
    /*0x58*/ string arubaAPIVersion;
    /*0x60*/ string companyName;
    /*0x68*/ string defaultTrackingEnableFlag;
    /*0x70*/ string defaultTrackingPostFlag;
    /*0x78*/ string storagePath;
    /*0x80*/ string logLevel;
    /*0x88*/ string logFile;
    /*0x90*/ int logMaxFileSize;
    /*0x94*/ bool m_paused;

    /*0x2bc17b8*/ NimbleBridge_LifeCycleHelper();
    /*0x2bc0e80*/ void Awake();
    /*0x2bc1414*/ void OnApplicationFocus(bool focusStatus);
    /*0x2bc169c*/ void OnApplicationPause(bool pauseStatus);
    /*0x2bc1504*/ void OnPause(bool paused);
    /*0x2bc1750*/ void OnApplicationQuit();

    class <>c
    {
        static /*0x0*/ NimbleBridge_LifeCycleHelper.<> <>9;
        static /*0x8*/ System.Threading.ThreadStart <>9__19_0;

        static /*0x2bc17c8*/ <>c();
        /*0x2bc1830*/ <>c();
        /*0x2bc1838*/ void <OnPause>b__19_0();
    }
}

class NimbleBridge_Log
{
    static /*0x2bc18a0*/ void NimbleBridge_Log_setThreshold(int level);
    static /*0x2bc191c*/ int NimbleBridge_Log_getThresholdLevel();
    static /*0x2bc1980*/ void NimbleBridge_Log_writeWithTitle(int level, string title, string message);
    static /*0x2bc1a44*/ NimbleBridge_Log GetComponent();
    static /*0x2bc14d0*/ void LOGVS(string title, string message);
    static /*0x2bc0694*/ void LOGWS(string title, string message);
    static /*0x2bc1b70*/ void LOGES(string title, string message);
    /*0x2bc1a3c*/ NimbleBridge_Log();
    /*0x2bc1a98*/ void WriteWithSource(NimbleBridge_Log.NimbleBridge_Log_Level level, NimbleBridge_LogSource source, string message);
    /*0x2bc1b54*/ void WriteWithTitle(NimbleBridge_Log.NimbleBridge_Log_Level level, string title, string message);
    /*0x2bc1b64*/ int GetThreshold();
    /*0x2bc1b68*/ void SetThreshold(int level);

    enum NimbleBridge_Log_Level
    {
        LEVEL_ALL = 0,
        LEVEL_VERBOSE = 100,
        LEVEL_DEBUG = 200,
        LEVEL_INFO = 300,
        LEVEL_WARN = 400,
        LEVEL_ERROR = 500,
        LEVEL_FATAL = 600,
    }
}

interface NimbleBridge_LogSource
{
    /*0x1f30214*/ string GetLogSourceTitle();
}

class NimbleBridge_ModuleLoader
{
    static /*0x2bc13f8*/ void LoadBase();
    static /*0x2bc13fc*/ void LoadTracking2();
    static /*0x2bc1400*/ void LoadSocialConnector();
    static /*0x2bc1404*/ void LoadNexus2();
    static /*0x2bc1408*/ void LoadMessaging();
    static /*0x2bc140c*/ void LoadFriends2();
    static /*0x2bc1410*/ void LoadAruba();
}

class NimbleBridge_Network
{
    enum NimbleBridge_Network_Status
    {
        STATUS_UNKNOWN = 0,
        STATUS_NONE = 1,
        STATUS_DEAD = 2,
        STATUS_OK = 3,
    }
}

class NimbleBridge_PersistenceService
{
    static /*0x2bc1ba4*/ void NimbleBridge_PersistenceService_wipeAllDataAndForceTerminate();
    static /*0x2bc1c10*/ NimbleBridge_PersistenceService GetComponent();
    /*0x2bc1c08*/ NimbleBridge_PersistenceService();
    /*0x2bc1c64*/ void WipeAllDataAndForceTerminate();
}
