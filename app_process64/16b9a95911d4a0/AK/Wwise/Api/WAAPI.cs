class <Module>
{
}

class AkWaapiClient
{
    /*0x10*/ Wamp wamp;
    /*0x18*/ Wamp.DisconnectedHandler Disconnected;

    /*0x20cf698*/ AkWaapiClient();
    /*0x20cef4c*/ void add_Disconnected(Wamp.DisconnectedHandler value);
    /*0x20cefe8*/ void remove_Disconnected(Wamp.DisconnectedHandler value);
    /*0x20cf084*/ System.Threading.Tasks.Task Connect(string uri, int timeout);
    /*0x20cf180*/ void Wamp_Disconnected();
    /*0x20cf19c*/ System.Threading.Tasks.Task Close(int timeout);
    /*0x20cf288*/ bool IsConnected();
    /*0x20cf2e8*/ System.Threading.Tasks.Task<string> Call(string uri, string args, string options, int timeout);
    /*0x20cf448*/ System.Threading.Tasks.Task<uint> Subscribe(string topic, string options, Wamp.PublishHandler publishHandler, int timeout);
    /*0x20cf5a8*/ System.Threading.Tasks.Task Unsubscribe(uint subscriptionId, int timeout);

    struct <Call>d__8 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string> <>t__builder;
        /*0x30*/ AkWaapiClient <>4__this;
        /*0x38*/ string args;
        /*0x40*/ string options;
        /*0x48*/ string uri;
        /*0x50*/ int timeout;
        /*0x58*/ System.Runtime.CompilerServices.TaskAwaiter<string> <>u__1;

        /*0x20cf6a0*/ void MoveNext();
        /*0x20cfb88*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <Close>d__6 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
        /*0x30*/ AkWaapiClient <>4__this;
        /*0x38*/ int timeout;
        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

        /*0x20cfc04*/ void MoveNext();
        /*0x20d0104*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <Connect>d__4 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
        /*0x30*/ AkWaapiClient <>4__this;
        /*0x38*/ string uri;
        /*0x40*/ int timeout;
        /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

        /*0x20d016c*/ void MoveNext();
        /*0x20d06dc*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <Subscribe>d__9 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<uint> <>t__builder;
        /*0x30*/ AkWaapiClient <>4__this;
        /*0x38*/ string options;
        /*0x40*/ string topic;
        /*0x48*/ Wamp.PublishHandler publishHandler;
        /*0x50*/ int timeout;
        /*0x58*/ System.Runtime.CompilerServices.TaskAwaiter<uint> <>u__1;

        /*0x20d0744*/ void MoveNext();
        /*0x20d0ba8*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <Unsubscribe>d__10 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
        /*0x30*/ AkWaapiClient <>4__this;
        /*0x38*/ uint subscriptionId;
        /*0x3c*/ int timeout;
        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

        /*0x20d0c24*/ void MoveNext();
        /*0x20d0f60*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

class JsonSerializable
{
    static /*0x20d0fc8*/ string op_Implicit(JsonSerializable o);
    /*0x20d0fd0*/ JsonSerializable();
}

class Args : JsonSerializable
{
    /*0x20d0fd8*/ Args();
}

class WaqlArgs : Args
{
    /*0x10*/ string waql;

    /*0x20d0fe0*/ WaqlArgs(string query);
}

class ArgsObject : Args
{
    /*0x10*/ string object;

    /*0x20d1010*/ ArgsObject(string objectId);
}

class ArgsRename : Args
{
    /*0x10*/ string object;
    /*0x18*/ string value;

    /*0x20d1040*/ ArgsRename(string objectId, string value);
}

class ArgsDisplayName : Args
{
    /*0x10*/ string displayName;

    /*0x20d1084*/ ArgsDisplayName(string displayName);
}

class ArgsCommand : Args
{
    /*0x10*/ string[] objects;
    /*0x18*/ string command;

    /*0x20d10b4*/ ArgsCommand(string c, string[] objectIds);
}

class ArgsPlay : Args
{
    /*0x10*/ string action;
    /*0x18*/ int transport;

    /*0x20d10f8*/ ArgsPlay(string a, int t);
}

class ArgsTransport : Args
{
    /*0x10*/ int transport;

    /*0x20d1134*/ ArgsTransport(int t);
}

class Options : JsonSerializable
{
    /*0x20d115c*/ Options();
}

class ReturnOptions : Options
{
    /*0x10*/ string[] return;

    /*0x20d1164*/ ReturnOptions(string[] infokeys);
}

class TransportOptions : Options
{
    /*0x10*/ int transport;

    /*0x20d1194*/ TransportOptions(int id);
}

class ReturnTransport : JsonSerializable
{
    /*0x10*/ int transport;

    /*0x20d11bc*/ ReturnTransport();
}

class TransportState : JsonSerializable
{
    /*0x10*/ string gameObject;
    /*0x18*/ string state;
    /*0x20*/ string object;
    /*0x28*/ int transport;

    /*0x20d11c4*/ TransportState();
}

class ErrorMessage : JsonSerializable
{
    /*0x10*/ string message;
    /*0x18*/ ErrorDetails details;

    /*0x20d11cc*/ ErrorMessage();
}

class ErrorDetails : JsonSerializable
{
    /*0x10*/ string[] reasons;
    /*0x18*/ string procedureUri;

    /*0x20d11d4*/ ErrorDetails();
}

class ReturnWwiseObjects : JsonSerializable
{
    /*0x10*/ System.Collections.Generic.List<WwiseObjectInfoJsonObject> return;

    /*0x20d11dc*/ ReturnWwiseObjects();
}

class ReturnWwiseObjects<T> : JsonSerializable
{
    /*0x0*/ System.Collections.Generic.List<T> return;

    /*0x1f309e4*/ ReturnWwiseObjects();
}

class SelectedWwiseObjects : JsonSerializable
{
    /*0x10*/ System.Collections.Generic.List<WwiseObjectInfoJsonObject> objects;

    /*0x20d11e4*/ SelectedWwiseObjects();
}

class WwiseRenameInfo : JsonSerializable
{
    /*0x10*/ WwiseObjectInfoJsonObject object;
    /*0x18*/ string newName;
    /*0x20*/ string oldName;
    /*0x28*/ WwiseObjectInfo objectInfo;

    /*0x20d1258*/ WwiseRenameInfo();
    /*0x20d11ec*/ void ParseInfo();
}

class WwiseChildModifiedInfo : JsonSerializable
{
    /*0x10*/ WwiseObjectInfoJsonObject parent;
    /*0x18*/ WwiseObjectInfoJsonObject child;
    /*0x20*/ WwiseObjectInfo parentInfo;
    /*0x70*/ WwiseObjectInfo childInfo;

    /*0x20d12c4*/ WwiseChildModifiedInfo();
    /*0x20d1260*/ void ParseInfo();
}

class WwiseObjectInfoJsonObject
{
    /*0x10*/ string id;
    /*0x18*/ WwiseObjectInfoParent parent;
    /*0x20*/ string name;
    /*0x28*/ string type;
    /*0x30*/ int childrenCount;
    /*0x38*/ string path;
    /*0x40*/ string filePath;
    /*0x48*/ string workunitType;
    /*0x50*/ string soundbankBnkFilePath;

    static /*0x20d1228*/ WwiseObjectInfo op_Implicit(WwiseObjectInfoJsonObject info);
    static /*0x20d12cc*/ WwiseObjectInfo ToObjectInfo(WwiseObjectInfoJsonObject info);
    /*0x20d1648*/ WwiseObjectInfoJsonObject();
}

class WwiseObjectInfoParent
{
    /*0x10*/ string id;

    /*0x20d1650*/ WwiseObjectInfoParent();
}

struct WwiseObjectInfo
{
    /*0x10*/ System.Guid objectGUID;
    /*0x20*/ System.Guid parentID;
    /*0x30*/ string name;
    /*0x38*/ WwiseObjectType type;
    /*0x3c*/ int childrenCount;
    /*0x40*/ string path;
    /*0x48*/ string workUnitType;
    /*0x50*/ string filePath;
    /*0x58*/ string soundbankBnkFilePath;
}

class WaapiHelper
{
    static /*0x20d1480*/ WwiseObjectType GetWwiseObjectTypeFromString(string typeString, string workUnitType);
}

class WaapiKeywords
{
    static string ACTION = "action";
    static string ANCESTORS = "ancestors";
    static string AT = "@";
    static string AUX_BUSSES = "auxBusses";
    static string BACK_SLASH = "\";
    static string BANK_DATA = "bankData";
    static string BANK_INFO = "bankInfo";
    static string CHILD = "child";
    static string CHILDREN = "children";
    static string CHILDREN_COUNT = "childrenCount";
    static string CLASSID = "classId";
    static string COMMAND = "command";
    static string DATA = "data";
    static string DELETE_ITEMS = "Delete Items";
    static string DESCENDANTS = "descendants";
    static string DISPLAY_NAME = "displayName";
    static string DRAG_DROP_ITEMS = "Drag Drop Items";
    static string EVENT = "event";
    static string EVENTS = "events";
    static string FILEPATH = "filePath";
    static string FIND_IN_PROJECT_EXPLORER = "FindInProjectExplorerSyncGroup1";
    static string FOLDER = "Folder";
    static string FROM = "from";
    static string ID = "id";
    static string INCLUSIONS = "inclusions";
    static string INFO_FILE = "infoFile";
    static string IS_CONNECTED = "isConnected";
    static string LANGUAGE = "language";
    static string LANGUAGES = "languages";
    static string MAX = "max";
    static string MAX_RADIUS_ATTENUATION = "audioSource:maxRadiusAttenuation";
    static string MESSSAGE = "message";
    static string MIN = "min";
    static string NAME = "name";
    static string NAMECONTAINS = "name:contains";
    static string NEW = "new";
    static string NEW_NAME = "newName";
    static string NOTES = "notes";
    static string OBJECT = "object";
    static string OBJECTS = "objects";
    static string OF_TYPE = "ofType";
    static string OLD_NAME = "oldName";
    static string PARENT = "parent";
    static string PATH = "path";
    static string PHYSICAL_FOLDER = "PhysicalFolder";
    static string PLATFORM = "platform";
    static string PLATFORMS = "platforms";
    static string PLAY = "play";
    static string PLAYING = "playing";
    static string PLAYSTOP = "playStop";
    static string PLUGININFO_OPTIONS = "pluginInfo";
    static string PLUGININFO_RESPONSE = "PluginInfo";
    static string PROJECT = "Project";
    static string PROPERTY = "property";
    static string RADIUS = "radius";
    static string RANGE = "range";
    static string REBUILD = "rebuild";
    static string REDO = "Redo";
    static string RESTRICTION = "restriction";
    static string RETURN = "return";
    static string SEARCH = "search";
    static string SELECT = "select";
    static string SIZE = "size";
    static string SKIP_LANGUAGES = "skipLanguages";
    static string SOUNDBANK = "soundbank";
    static string SOUNDBANKS = "soundbanks";
    static string STATE = "state";
    static string STOP = "stop";
    static string STOPPED = "stopped";
    static string STRUCTURE = "structure";
    static string TRANSFORM = "transform";
    static string TRANSPORT = "transport";
    static string TYPE = "type";
    static string UI = "ui";
    static string UNDO = "Undo";
    static string VALUE = "value";
    static string VOLUME = "Volume";
    static string WHERE = "where";
    static string WORKUNIT_TYPE = "workunit:type";
    static string OPEN_SOUNDBANK_FOLDER = "OpenContainingFolderSoundbank";
    static string OPEN_WORKUNIT_FOLDER = "OpenContainingFolderWorkUnit";
    static string OPEN_WAV_FOLDER = "OpenContainingFolderWAV";
    static /*0x0*/ System.Collections.ObjectModel.ReadOnlyDictionary<WwiseObjectType, string> WwiseObjectTypeStrings;
    static /*0x8*/ System.Collections.ObjectModel.ReadOnlyDictionary<string, string> FolderDisplaynames;
    static /*0x10*/ System.Collections.ObjectModel.ReadOnlyDictionary<string, WwiseObjectType> typeStringDict;

    static /*0x20d1660*/ WaapiKeywords();
    /*0x20d1658*/ WaapiKeywords();
}

class ak
{
    /*0x20d1fd0*/ ak();

    class soundengine
    {
        static string setMultiplePositions = "ak.soundengine.setMultiplePositions";
        static string setScalingFactor = "ak.soundengine.setScalingFactor";
        static string postEvent = "ak.soundengine.postEvent";
        static string setRTPCValue = "ak.soundengine.setRTPCValue";
        static string setObjectObstructionAndOcclusion = "ak.soundengine.setObjectObstructionAndOcclusion";
        static string setListeners = "ak.soundengine.setListeners";
        static string executeActionOnEvent = "ak.soundengine.executeActionOnEvent";
        static string setListenerSpatialization = "ak.soundengine.setListenerSpatialization";
        static string resetRTPCValue = "ak.soundengine.resetRTPCValue";
        static string unregisterGameObj = "ak.soundengine.unregisterGameObj";
        static string stopPlayingID = "ak.soundengine.stopPlayingID";
        static string setGameObjectAuxSendValues = "ak.soundengine.setGameObjectAuxSendValues";
        static string seekOnEvent = "ak.soundengine.seekOnEvent";
        static string registerGameObj = "ak.soundengine.registerGameObj";
        static string setDefaultListeners = "ak.soundengine.setDefaultListeners";
        static string setPosition = "ak.soundengine.setPosition";
        static string postMsgMonitor = "ak.soundengine.postMsgMonitor";
        static string setGameObjectOutputBusVolume = "ak.soundengine.setGameObjectOutputBusVolume";
        static string setSwitch = "ak.soundengine.setSwitch";
        static string stopAll = "ak.soundengine.stopAll";
        static string postTrigger = "ak.soundengine.postTrigger";

        /*0x20d1fd8*/ soundengine();

        class error
        {
            static string invalid_playing_id = "ak.soundengine.invalid_playing_id";
            static string wrong_volumeOffsets_length = "ak.soundengine.wrong_volumeOffsets_length";

            /*0x20d1fe0*/ error();
        }
    }

    class wwise
    {
        /*0x20d1fe8*/ wwise();

        class error
        {
            static string invalid_arguments = "ak.wwise.invalid_arguments";
            static string invalid_options = "ak.wwise.invalid_options";
            static string invalid_json = "ak.wwise.invalid_json";
            static string invalid_object = "ak.wwise.invalid_object";
            static string invalid_property = "ak.wwise.invalid_property";
            static string invalid_reference = "ak.wwise.invalid_reference";
            static string invalid_query = "ak.wwise.query.invalid_query";
            static string file_error = "ak.wwise.file_error";
            static string unavailable = "ak.wwise.unavailable";
            static string unexpected_error = "ak.wwise.unexpected_error";
            static string locked = "ak.wwise.locked";
            static string connection_failed = "ak.wwise.connection_failed";
            static string already_connected = "ak.wwise.already_connected";
            static string wwise_console = "ak.wwise.wwise_console";

            /*0x20d1ff0*/ error();
        }

        class debug
        {
            static string testAssert = "ak.wwise.debug.testAssert";
            static string assertFailed = "ak.wwise.debug.assertFailed";
            static string enableAutomationMode = "ak.wwise.debug.enableAutomationMode";
            static string enableAsserts = "ak.wwise.debug.enableAsserts";

            /*0x20d1ff8*/ debug();
        }

        class core
        {
            static string getInfo = "ak.wwise.core.getInfo";

            /*0x20d2000*/ core();

            class audioSourcePeaks
            {
                static string getMinMaxPeaksInRegion = "ak.wwise.core.audioSourcePeaks.getMinMaxPeaksInRegion";
                static string getMinMaxPeaksInTrimmedRegion = "ak.wwise.core.audioSourcePeaks.getMinMaxPeaksInTrimmedRegion";

                /*0x20d2008*/ audioSourcePeaks();
            }

            class remote
            {
                static string getConnectionStatus = "ak.wwise.core.remote.getConnectionStatus";
                static string getAvailableConsoles = "ak.wwise.core.remote.getAvailableConsoles";
                static string disconnect = "ak.wwise.core.remote.disconnect";
                static string connect = "ak.wwise.core.remote.connect";

                /*0x20d2010*/ remote();
            }

            class log
            {
                static string itemAdded = "ak.wwise.core.log.itemAdded";
                static string get = "ak.wwise.core.log.get";

                /*0x20d2018*/ log();
            }

            class object
            {
                static string referenceChanged = "ak.wwise.core.object.referenceChanged";
                static string move = "ak.wwise.core.object.move";
                static string attenuationCurveLinkChanged = "ak.wwise.core.object.attenuationCurveLinkChanged";
                static string childAdded = "ak.wwise.core.object.childAdded";
                static string getTypes = "ak.wwise.core.object.getTypes";
                static string propertyChanged = "ak.wwise.core.object.propertyChanged";
                static string create = "ak.wwise.core.object.create";
                static string get = "ak.wwise.core.object.get";
                static string preDeleted = "ak.wwise.core.object.preDeleted";
                static string nameChanged = "ak.wwise.core.object.nameChanged";
                static string postDeleted = "ak.wwise.core.object.postDeleted";
                static string notesChanged = "ak.wwise.core.object.notesChanged";
                static string getPropertyInfo = "ak.wwise.core.object.getPropertyInfo";
                static string setName = "ak.wwise.core.object.setName";
                static string setNotes = "ak.wwise.core.object.setNotes";
                static string setAttenuationCurve = "ak.wwise.core.object.setAttenuationCurve";
                static string setProperty = "ak.wwise.core.object.setProperty";
                static string copy = "ak.wwise.core.object.copy";
                static string isPropertyEnabled = "ak.wwise.core.object.isPropertyEnabled";
                static string setRandomizer = "ak.wwise.core.object.setRandomizer";
                static string setReference = "ak.wwise.core.object.setReference";
                static string attenuationCurveChanged = "ak.wwise.core.object.attenuationCurveChanged";
                static string created = "ak.wwise.core.object.created";
                static string childRemoved = "ak.wwise.core.object.childRemoved";
                static string getPropertyNames = "ak.wwise.core.object.getPropertyNames";
                static string getAttenuationCurve = "ak.wwise.core.object.getAttenuationCurve";
                static string curveChanged = "ak.wwise.core.object.curveChanged";
                static string delete = "ak.wwise.core.object.delete";
                static string getPropertyAndReferenceNames = "ak.wwise.core.object.getPropertyAndReferenceNames";

                /*0x20d2020*/ object();
            }

            class undo
            {
                static string endGroup = "ak.wwise.core.undo.endGroup";
                static string cancelGroup = "ak.wwise.core.undo.cancelGroup";
                static string beginGroup = "ak.wwise.core.undo.beginGroup";

                /*0x20d2028*/ undo();
            }

            class profiler
            {
                static string getCursorTime = "ak.wwise.core.profiler.getCursorTime";
                static string startCapture = "ak.wwise.core.profiler.startCapture";
                static string getVoiceContributions = "ak.wwise.core.profiler.getVoiceContributions";
                static string getVoices = "ak.wwise.core.profiler.getVoices";
                static string getBusses = "ak.wwise.core.profiler.getBusses";
                static string stopCapture = "ak.wwise.core.profiler.stopCapture";

                /*0x20d2030*/ profiler();
            }

            class project
            {
                static string postClosed = "ak.wwise.core.project.postClosed";
                static string loaded = "ak.wwise.core.project.loaded";
                static string preClosed = "ak.wwise.core.project.preClosed";
                static string save = "ak.wwise.core.project.save";
                static string saved = "ak.wwise.core.project.saved";

                /*0x20d2038*/ project();
            }

            class transport
            {
                static string getState = "ak.wwise.core.transport.getState";
                static string stateChanged = "ak.wwise.core.transport.stateChanged";
                static string create = "ak.wwise.core.transport.create";
                static string getList = "ak.wwise.core.transport.getList";
                static string destroy = "ak.wwise.core.transport.destroy";
                static string executeAction = "ak.wwise.core.transport.executeAction";

                /*0x20d2040*/ transport();
            }

            class soundbank
            {
                static string getInclusions = "ak.wwise.core.soundbank.getInclusions";
                static string generated = "ak.wwise.core.soundbank.generated";
                static string setInclusions = "ak.wwise.core.soundbank.setInclusions";

                /*0x20d2048*/ soundbank();
            }

            class audio
            {
                static string import = "ak.wwise.core.audio.import";
                static string importTabDelimited = "ak.wwise.core.audio.importTabDelimited";
                static string imported = "ak.wwise.core.audio.imported";

                /*0x20d2050*/ audio();
            }

            class switchContainer
            {
                static string removeAssignment = "ak.wwise.core.switchContainer.removeAssignment";
                static string getAssignments = "ak.wwise.core.switchContainer.getAssignments";
                static string assignmentRemoved = "ak.wwise.core.switchContainer.assignmentRemoved";
                static string addAssignment = "ak.wwise.core.switchContainer.addAssignment";
                static string assignmentAdded = "ak.wwise.core.switchContainer.assignmentAdded";

                /*0x20d2058*/ switchContainer();
            }

            class plugin
            {
                static string getList = "ak.wwise.core.plugin.getList";
                static string getProperty = "ak.wwise.core.plugin.getProperty";
                static string getProperties = "ak.wwise.core.plugin.getProperties";

                /*0x20d2060*/ plugin();
            }
        }

        class ui
        {
            static string bringToForeground = "ak.wwise.ui.bringToForeground";
            static string getSelectedObjects = "ak.wwise.ui.getSelectedObjects";
            static string selectionChanged = "ak.wwise.ui.selectionChanged";

            /*0x20d2068*/ ui();

            class project
            {
                static string close = "ak.wwise.ui.project.close";
                static string open = "ak.wwise.ui.project.open";

                /*0x20d2070*/ project();
            }

            class commands
            {
                static string unregister = "ak.wwise.ui.commands.unregister";
                static string executed = "ak.wwise.ui.commands.executed";
                static string execute = "ak.wwise.ui.commands.execute";
                static string register = "ak.wwise.ui.commands.register";
                static string getCommands = "ak.wwise.ui.commands.getCommands";

                /*0x20d2078*/ commands();
            }
        }

        class waapi
        {
            static string getTopics = "ak.wwise.waapi.getTopics";
            static string getFunctions = "ak.wwise.waapi.getFunctions";
            static string getSchema = "ak.wwise.waapi.getSchema";

            /*0x20d2080*/ waapi();
        }
    }
}

class Wamp
{
    /*0x10*/ Wamp.DisconnectedHandler Disconnected;
    /*0x18*/ System.Net.WebSockets.ClientWebSocket ws;
    /*0x20*/ int sessionId;
    /*0x24*/ int currentRequestId;
    /*0x28*/ System.Threading.CancellationTokenSource stopServerTokenSource;
    /*0x30*/ System.Threading.Tasks.TaskCompletionSource<Wamp.Response> taskCompletion;
    /*0x38*/ System.Collections.Concurrent.ConcurrentDictionary<uint, Wamp.PublishHandler> subscriptions;

    static /*0x20d2ba0*/ Wamp.Response ParseResult(string msg);
    static /*0x20d2678*/ Wamp.Response ParseSubscribed(string msg);
    static /*0x20d281c*/ Wamp.Response ParseUnsubscribed(string msg);
    static /*0x20d2548*/ Wamp.Response ParseGoodbye(string msg);
    static /*0x20d23d8*/ Wamp.Response ParseWelcome(string msg);
    static /*0x20d2988*/ Wamp.Response ParseEvent(string msg);
    /*0x20d042c*/ Wamp();
    /*0x20d0540*/ void add_Disconnected(Wamp.DisconnectedHandler value);
    /*0x20d0068*/ void remove_Disconnected(Wamp.DisconnectedHandler value);
    /*0x20d2088*/ System.Threading.Tasks.Task Send(string msg, int timeout);
    /*0x20d2188*/ Wamp.Response Parse(string msg);
    /*0x20d314c*/ System.Threading.Tasks.Task<Wamp.Response> ReceiveMessage();
    /*0x20d3258*/ System.Threading.Tasks.Task<Wamp.Response> Receive(int timeout);
    /*0x20d336c*/ System.Threading.Tasks.Task<Wamp.Response> ReceiveExpect(Wamp.Messages message, int requestId, int timeout);
    /*0x20d05dc*/ System.Threading.Tasks.Task Connect(string host, int timeout);
    /*0x20cf2c0*/ bool IsConnected();
    /*0x20d3490*/ System.Net.WebSockets.WebSocketState SocketState();
    /*0x20cfee0*/ System.Threading.Tasks.Task Close(int timeout);
    /*0x20d34a8*/ void ProcessEvent(Wamp.Response message);
    /*0x20d3588*/ void StartListen();
    /*0x20d36f0*/ void OnDisconnect();
    /*0x20cfa24*/ System.Threading.Tasks.Task<string> Call(string uri, string args, string options, int timeout);
    /*0x20d0a48*/ System.Threading.Tasks.Task<uint> Subscribe(string topic, string options, Wamp.PublishHandler publishEvent, int timeout);
    /*0x20d0e70*/ System.Threading.Tasks.Task Unsubscribe(uint subscriptionId, int timeout);

    class TimeoutException : System.Exception
    {
        /*0x20d370c*/ TimeoutException(string message);
    }

    class WampNotConnectedException : System.Exception
    {
        /*0x20cf9bc*/ WampNotConnectedException(string message);
    }

    class ErrorException : System.Exception
    {
        /*0x90*/ string <Json>k__BackingField;
        /*0x98*/ Wamp.Messages <MessageId>k__BackingField;
        /*0x9c*/ int <RequestId>k__BackingField;
        /*0xa0*/ string <Uri>k__BackingField;

        static /*0x20d2d90*/ Wamp.ErrorException FromResponse(string response);
        /*0x20d2370*/ ErrorException(string message);
        /*0x20d3774*/ string get_Json();
        /*0x20d377c*/ void set_Json(string value);
        /*0x20d3784*/ Wamp.Messages get_MessageId();
        /*0x20d378c*/ void set_MessageId(Wamp.Messages value);
        /*0x20d3794*/ int get_RequestId();
        /*0x20d379c*/ void set_RequestId(int value);
        /*0x20d37a4*/ string get_Uri();
        /*0x20d37ac*/ void set_Uri(string value);
    }

    enum Messages
    {
        HELLO = 1,
        WELCOME = 2,
        GOODBYE = 6,
        ERROR = 8,
        SUBSCRIBE = 32,
        SUBSCRIBED = 33,
        UNSUBSCRIBE = 34,
        UNSUBSCRIBED = 35,
        EVENT = 36,
        CALL = 48,
        RESULT = 50,
    }

    class Response
    {
        /*0x10*/ Wamp.Messages <MessageId>k__BackingField;
        /*0x14*/ int <RequestId>k__BackingField;
        /*0x18*/ int <ContextSpecificResultId>k__BackingField;
        /*0x1c*/ uint <SubscriptionId>k__BackingField;
        /*0x20*/ string <Json>k__BackingField;

        /*0x20d3144*/ Response();
        /*0x20d37b4*/ Wamp.Messages get_MessageId();
        /*0x20d37bc*/ void set_MessageId(Wamp.Messages value);
        /*0x20d37c4*/ int get_RequestId();
        /*0x20d37cc*/ void set_RequestId(int value);
        /*0x20d37d4*/ int get_ContextSpecificResultId();
        /*0x20d37dc*/ void set_ContextSpecificResultId(int value);
        /*0x20d37e4*/ uint get_SubscriptionId();
        /*0x20d37ec*/ void set_SubscriptionId(uint value);
        /*0x20d37f4*/ string get_Json();
        /*0x20d37fc*/ void set_Json(string value);
    }

    class PublishHandler : System.MulticastDelegate
    {
        /*0x20d3804*/ PublishHandler(object object, nint method);
        /*0x20d38b4*/ void Invoke(string json);
        /*0x20d38c8*/ System.IAsyncResult BeginInvoke(string json, System.AsyncCallback callback, object object);
        /*0x20d38e8*/ void EndInvoke(System.IAsyncResult result);
    }

    class DisconnectedHandler : System.MulticastDelegate
    {
        /*0x20cffcc*/ DisconnectedHandler(object object, nint method);
        /*0x20d38f4*/ void Invoke();
        /*0x20d3908*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
        /*0x20d3924*/ void EndInvoke(System.IAsyncResult result);
    }

    class <>c
    {
        static /*0x0*/ Wamp.<> <>9;
        static /*0x8*/ System.Func<System.Collections.Generic.IEnumerable<byte>, System.Collections.Generic.IEnumerable<byte>> <>9__24_0;

        static /*0x20d3930*/ <>c();
        /*0x20d3998*/ <>c();
        /*0x20d39a0*/ System.Collections.Generic.IEnumerable<byte> <ReceiveMessage>b__24_0(System.Collections.Generic.IEnumerable<byte> t);
    }

    class <>c__DisplayClass32_0
    {
        /*0x10*/ System.Threading.CancellationToken ct;
        /*0x18*/ Wamp <>4__this;

        /*0x20d36e8*/ <>c__DisplayClass32_0();
        /*0x20d39a8*/ void <StartListen>b__0();
    }

    struct <Call>d__34 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string> <>t__builder;
        /*0x30*/ Wamp <>4__this;
        /*0x38*/ string options;
        /*0x40*/ string uri;
        /*0x48*/ string args;
        /*0x50*/ int timeout;
        /*0x54*/ int <requestId>5__2;
        /*0x58*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;
        /*0x60*/ System.Runtime.CompilerServices.TaskAwaiter<Wamp.Response> <>u__2;

        /*0x20d3da8*/ void MoveNext();
        /*0x20d4320*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <Close>d__30 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
        /*0x30*/ Wamp <>4__this;
        /*0x38*/ int timeout;
        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;
        /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter<Wamp.Response> <>u__2;
        /*0x50*/ System.Threading.CancellationTokenSource <cts>5__2;

        /*0x20d439c*/ void MoveNext();
        /*0x20d4b0c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <Connect>d__27 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
        /*0x30*/ string host;
        /*0x38*/ Wamp <>4__this;
        /*0x40*/ int timeout;
        /*0x48*/ System.Threading.CancellationTokenSource <cts>5__2;
        /*0x50*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;
        /*0x58*/ System.Runtime.CompilerServices.TaskAwaiter<Wamp.Response> <>u__2;

        /*0x20d4b74*/ void MoveNext();
        /*0x20d543c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <Receive>d__25 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Wamp.Response> <>t__builder;
        /*0x30*/ Wamp <>4__this;
        /*0x38*/ int timeout;
        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter<System.Threading.Tasks.Task> <>u__1;

        /*0x20d54a4*/ void MoveNext();
        /*0x20d5a78*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <ReceiveExpect>d__26 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Wamp.Response> <>t__builder;
        /*0x30*/ Wamp <>4__this;
        /*0x38*/ int timeout;
        /*0x3c*/ Wamp.Messages message;
        /*0x40*/ int requestId;
        /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter<Wamp.Response> <>u__1;

        /*0x20d5af4*/ void MoveNext();
        /*0x20d5ea4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <ReceiveMessage>d__24 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<Wamp.Response> <>t__builder;
        /*0x30*/ Wamp <>4__this;
        /*0x38*/ System.Collections.Generic.List<System.Collections.Generic.IEnumerable<byte>> <segments>5__2;
        /*0x40*/ System.ArraySegment<byte> <segment>5__3;
        /*0x50*/ System.Runtime.CompilerServices.TaskAwaiter<System.Net.WebSockets.WebSocketReceiveResult> <>u__1;

        /*0x20d5f20*/ void MoveNext();
        /*0x20d6758*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <Send>d__16 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
        /*0x30*/ int timeout;
        /*0x38*/ string msg;
        /*0x40*/ Wamp <>4__this;
        /*0x48*/ System.Threading.CancellationTokenSource <cts>5__2;
        /*0x50*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

        /*0x20d67d4*/ void MoveNext();
        /*0x20d6d30*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <Subscribe>d__35 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder<uint> <>t__builder;
        /*0x30*/ Wamp <>4__this;
        /*0x38*/ string options;
        /*0x40*/ string topic;
        /*0x48*/ int timeout;
        /*0x50*/ Wamp.PublishHandler publishEvent;
        /*0x58*/ int <requestId>5__2;
        /*0x60*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;
        /*0x68*/ System.Runtime.CompilerServices.TaskAwaiter<Wamp.Response> <>u__2;

        /*0x20d6d98*/ void MoveNext();
        /*0x20d731c*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    struct <Unsubscribe>d__36 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncTaskMethodBuilder <>t__builder;
        /*0x30*/ Wamp <>4__this;
        /*0x38*/ uint subscriptionId;
        /*0x3c*/ int timeout;
        /*0x40*/ int <requestId>5__2;
        /*0x48*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;
        /*0x50*/ System.Runtime.CompilerServices.TaskAwaiter<Wamp.Response> <>u__2;

        /*0x20d7398*/ void MoveNext();
        /*0x20d77b4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x20d781c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x20d7910*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
    static /*0x0*/ <PrivateImplementationDetails> 2812219612B37F3DBAF20C2B3A5C7A32DB50C82D169203163DE943C25C9E7EF7;
    static /*0xfd*/ <PrivateImplementationDetails> 3A914FBB2614DD4B3529C65A89B34B2704A2C0379D79CBCDF92FE25B3FE8F996;

    struct __StaticArrayInitTypeSize=253
    {
    }

    struct __StaticArrayInitTypeSize=1178
    {
    }
}
