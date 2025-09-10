class <Module>
{
}

class DestroyOnChinaBuild : UnityEngine.MonoBehaviour
{
    /*0xdad6c0*/ DestroyOnChinaBuild();
    /*0xdad6bc*/ void Start();
}

class DestroyOnGlobalBuild : UnityEngine.MonoBehaviour
{
    /*0xdad734*/ DestroyOnGlobalBuild();
    /*0xdad6c8*/ void Start();
}

class force_test : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject explosion_center;
    /*0x20*/ float force_amount;
    /*0x24*/ float force_radius;
    /*0x28*/ UnityEngine.Rigidbody rigid;
    /*0x30*/ UnityEngine.Vector3 initial_position;
    /*0x3c*/ UnityEngine.Quaternion initial_rot;

    /*0xdad960*/ force_test();
    /*0xdad73c*/ void Start();
    /*0xdad7e0*/ void Update();
}

class GarlicNoticeTest : UnityEngine.MonoBehaviour
{
    /*0xdad9d8*/ GarlicNoticeTest();
    /*0xdad974*/ void Get_Notice();
}

class GarlicParallelTest : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Text dimensionText;

    /*0xdadad8*/ GarlicParallelTest();
    /*0xdad9e0*/ void SwitchParallel();
    /*0xdada54*/ void Update();
}

class FrameDropper : UnityEngine.MonoBehaviour
{
    /*0x18*/ int targetFrame;

    /*0xdadb40*/ FrameDropper();
    /*0xdadae0*/ void Awake();
    /*0xdadb00*/ void Update();
}

class GarlicMemoryLogger : UnityEngine.MonoBehaviour
{
    /*0x18*/ bool RunProfiler;

    static /*0xdaeab4*/ string megaBytesString(uint memorySizeByte);
    static /*0xdaea94*/ double ConvertBytesToMegabytes(uint bytes);
    static /*0xdaea78*/ double ConvertBytesToKilobytes(uint bytes);
    /*0xdaeec8*/ GarlicMemoryLogger();
    /*0xdadb50*/ void Start();
    /*0xdadb68*/ void SaveTextureMemoryProfilerFile(string fileNameTag);
    /*0xdae58c*/ void SaveUnityObjectProfilerFile(string fileNameTag);
    /*0xdae4b0*/ void writeStringToFile(string path, string str);
    /*0xdaddd4*/ string getTextureString();
    /*0xdae1dc*/ string getMemoryLogString();
    /*0xdae7fc*/ string getUnityObjectLogString();
    /*0xdaeb34*/ System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, GarlicMemoryLogger.IntPair>> getUnityObjectPair();

    struct IntPair
    {
        /*0x10*/ int objCount;
        /*0x18*/ double objMemCount;
    }

    class <>c
    {
        static /*0x0*/ GarlicMemoryLogger.<> <>9;
        static /*0x8*/ System.Comparison<UnityEngine.Texture2D> <>9__5_0;
        static /*0x10*/ System.Comparison<System.Collections.Generic.KeyValuePair<string, GarlicMemoryLogger.IntPair>> <>9__9_0;

        static /*0xdaeed0*/ <>c();
        /*0xdaef34*/ <>c();
        /*0xdaef3c*/ int <getTextureString>b__5_0(UnityEngine.Texture2D a, UnityEngine.Texture2D b);
        /*0xdaef80*/ int <getUnityObjectPair>b__9_0(System.Collections.Generic.KeyValuePair<string, GarlicMemoryLogger.IntPair> firstPair, System.Collections.Generic.KeyValuePair<string, GarlicMemoryLogger.IntPair> nextPair);
    }
}

class TimeScaleDebugHelper : UnityEngine.MonoBehaviour
{
    /*0x18*/ float timeScale;

    /*0xdaeff8*/ TimeScaleDebugHelper();
    /*0xdaefe0*/ void Awake();
    /*0xdaefec*/ void Update();
}

class OneShotParticleInactivator : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.ParticleSystem myParticle;
    /*0x20*/ bool destroy;

    /*0xdaf134*/ OneShotParticleInactivator();
    /*0xdaf008*/ void Start();
    /*0xdaf058*/ void Update();
}

class GPGSIds
{
    static string achievement_warrior = "CgkIh--s0tQMEAIQEw";
    static string achievement_sea_dragon = "CgkIh--s0tQMEAIQDg";
    static string achievement_butter_squid = "CgkIh--s0tQMEAIQCQ";
    static string achievement_trident = "CgkIh--s0tQMEAIQGA";
    static string achievement_viking_shell = "CgkIh--s0tQMEAIQFQ";
    static string achievement_ = "CgkIh--s0tQMEAIQJQ";
    static string achievement_margarglsum = "CgkIh--s0tQMEAIQLw";
    static string achievement_totem_fish = "CgkIh--s0tQMEAIQEg";
    static string achievement_baked_yam = "CgkIh--s0tQMEAIQMQ";
    static string achievement_first_skin = "CgkIh--s0tQMEAIQAg";
    static string achievement_venom = "CgkIh--s0tQMEAIQLA";
    static string achievement_bitedog = "CgkIh--s0tQMEAIQKg";
    static string achievement_saw_stingray = "CgkIh--s0tQMEAIQDA";
    static string achievement_sushi_shark = "CgkIh--s0tQMEAIQBA";
    static string achievement_haunted_ship = "CgkIh--s0tQMEAIQGQ";
    static string achievement_mjlnir_shark = "CgkIh--s0tQMEAIQFA";
    static string leaderboard_achieve_the_highest_level_new = "CgkIh--s0tQMEAIQMA";
    static string achievement_rock_eater = "CgkIh--s0tQMEAIQEA";
    static string achievement_pine_turtle = "CgkIh--s0tQMEAIQCA";
    static string achievement_sea_cobra = "CgkIh--s0tQMEAIQDw";
    static string achievement_hamburgurtle = "CgkIh--s0tQMEAIQGg";
    static string achievement_undavalena = "CgkIh--s0tQMEAIQNg";
    static string achievement_angelic_jellyfish = "CgkIh--s0tQMEAIQCw";
    static string achievement_dead_cage = "CgkIh--s0tQMEAIQHw";
    static string achievement_first_blood = "CgkIh--s0tQMEAIQAQ";
    static string achievement_taiyaking = "CgkIh--s0tQMEAIQAw";
    static string achievement_skull_squid = "CgkIh--s0tQMEAIQHQ";
    static string leaderboard_fishing_best_record = "CgkIh--s0tQMEAIQOQ";
    static string achievement_little_penguin = "CgkIh--s0tQMEAIQDQ";
    static string achievement_deep_one = "CgkIh--s0tQMEAIQIQ";
    static string achievement_dark_ammonite = "CgkIh--s0tQMEAIQHg";
    static string event_check = "CgkIh--s0tQMEAIQNw";
    static string achievement_pumpkin_whale = "CgkIh--s0tQMEAIQKw";
    static string achievement_unicorn = "CgkIh--s0tQMEAIQGw";
    static string achievement_seal = "CgkIh--s0tQMEAIQFg";
    static string achievement_voodoo_fish = "CgkIh--s0tQMEAIQEQ";
    static string achievement_ice_breeder = "CgkIh--s0tQMEAIQMw";
    static string leaderboard_playtime = "CgkIh--s0tQMEAIQOA";
    static string achievement_king_crab = "CgkIh--s0tQMEAIQCg";
    static string achievement_damus = "CgkIh--s0tQMEAIQLg";
    static string achievement_rampley = "CgkIh--s0tQMEAIQLQ";
    static string achievement_guardian = "CgkIh--s0tQMEAIQNA";
    static string achievement_superball = "CgkIh--s0tQMEAIQHA";
    static string achievement_evil_blowfish = "CgkIh--s0tQMEAIQIA";
    static string achievement_ocean_king = "CgkIh--s0tQMEAIQNQ";
    static string achievement_mega_hot_king_crab = "CgkIh--s0tQMEAIQMg";
    static string achievement_takoyaki = "CgkIh--s0tQMEAIQBQ";
    static string achievement_qthulhu = "CgkIh--s0tQMEAIQIg";
    static string achievement_ice_shark = "CgkIh--s0tQMEAIQFw";
}

class MiniJson
{
    static /*0xdaf13c*/ object Deserialize(string json);
    static /*0xdaf2e4*/ string Serialize(object obj);

    class Parser : System.IDisposable
    {
        static string WORD_BREAK = "{}[],:"";
        /*0x10*/ System.IO.StringReader json;

        static /*0xdaf35c*/ bool IsWordBreak(char c);
        static /*0xdaf148*/ object Parse(string jsonString);
        /*0xdaf3f8*/ Parser(string jsonString);
        /*0xdaf490*/ void Dispose();
        /*0xdaf4b8*/ System.Collections.Generic.Dictionary<string, object> ParseObject();
        /*0xdafa00*/ System.Collections.Generic.List<object> ParseArray();
        /*0xdaf474*/ object ParseValue();
        /*0xdafb24*/ object ParseByToken(MiniJson.Parser.TOKEN token);
        /*0xdaf7a0*/ string ParseString();
        /*0xdafc0c*/ object ParseNumber();
        /*0xdafe34*/ void EatWhitespace();
        /*0xdafed8*/ char get_PeekChar();
        /*0xdafd10*/ char get_NextChar();
        /*0xdafd88*/ string get_NextWord();
        /*0xdaf5dc*/ MiniJson.Parser.TOKEN get_NextToken();

        enum TOKEN
        {
            NONE = 0,
            CURLY_OPEN = 1,
            CURLY_CLOSE = 2,
            SQUARED_OPEN = 3,
            SQUARED_CLOSE = 4,
            COLON = 5,
            COMMA = 6,
            STRING = 7,
            NUMBER = 8,
            TRUE = 9,
            FALSE = 10,
            NULL = 11,
        }
    }

    class Serializer
    {
        /*0x10*/ System.Text.StringBuilder builder;

        static /*0xdaf2e8*/ string Serialize(object obj);
        /*0xdaff50*/ Serializer();
        /*0xdaffbc*/ void SerializeValue(object value);
        /*0xdb07a8*/ void SerializeObject(System.Collections.IDictionary obj);
        /*0xdb0448*/ void SerializeArray(System.Collections.IList anArray);
        /*0xdb018c*/ void SerializeString(string str);
        /*0xdb0c34*/ void SerializeOther(object value);
    }
}

class editor_map : UnityEngine.MonoBehaviour
{
    /*0x18*/ SimplePool<data_place_element> pool_place;
    /*0x20*/ SimplePool<data_hidden_element> pool_hidden;
    /*0x28*/ UnityEngine.GameObject prefab_place;
    /*0x30*/ UnityEngine.GameObject prefab_hidden;
    /*0x38*/ UnityEngine.Transform parent_place;
    /*0x40*/ UnityEngine.Transform parent_hidden;
    /*0x48*/ System.Collections.Generic.List<data_place_element> place;
    /*0x50*/ System.Collections.Generic.List<data_hidden_element> hidden;
    /*0x58*/ UnityEngine.UI.Slider slider_rank;
    /*0x60*/ UnityEngine.UI.Text text_rank;

    /*0xdb1374*/ editor_map();
    /*0xdb0eb0*/ void Awake();
    /*0xdb10e0*/ void Refresh();
    /*0xdb1328*/ void Save();

    class <>c__DisplayClass11_0
    {
        /*0x10*/ int rank;

        /*0xdb1320*/ <>c__DisplayClass11_0();
        /*0xdb137c*/ bool <Refresh>b__0(data_place_element p);
        /*0xdb13fc*/ bool <Refresh>b__1(data_hidden_element p);
    }
}

class editor_map_hidden : SimplePool_element<data_hidden_element>
{
    /*0x28*/ UnityEngine.UI.Image img_icon;

    /*0xdb164c*/ editor_map_hidden();
    /*0xdb1478*/ void Instantiate();
}

class editor_map_place : SimplePool_element<data_place_element>
{
    /*0x28*/ UnityEngine.UI.Image img_icon;
    /*0x30*/ UnityEngine.UI.Text text_name;

    /*0xdb1888*/ editor_map_place();
    /*0xdb1694*/ void Instantiate();
}

class CFX2_AutoRotate : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Vector3 speed;

    /*0xdb192c*/ CFX2_AutoRotate();
    /*0xdb18d0*/ void Update();
}

class CFX_AutoDestructShuriken : UnityEngine.MonoBehaviour
{
    /*0x18*/ bool OnlyDeactivate;

    /*0xdb1a20*/ CFX_AutoDestructShuriken();
    /*0xdb1944*/ void OnEnable();
    /*0xdb1990*/ System.Collections.IEnumerator CheckIfAlive();

    class <CheckIfAlive>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ CFX_AutoDestructShuriken <>4__this;
        /*0x28*/ UnityEngine.ParticleSystem <ps>5__2;

        /*0xdb19f8*/ <CheckIfAlive>d__2(int <>1__state);
        /*0xdb1a28*/ void System.IDisposable.Dispose();
        /*0xdb1a2c*/ bool MoveNext();
        /*0xdb1ba0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb1ba8*/ void System.Collections.IEnumerator.Reset();
        /*0xdb1be8*/ object System.Collections.IEnumerator.get_Current();
    }
}

class CFX_AutodestructWhenNoChildren : UnityEngine.MonoBehaviour
{
    /*0xdb1c88*/ CFX_AutodestructWhenNoChildren();
    /*0xdb1bf0*/ void Update();
}

class CFX_InspectorHelp : UnityEngine.MonoBehaviour
{
    /*0x18*/ bool Locked;
    /*0x20*/ string Title;
    /*0x28*/ string HelpText;
    /*0x30*/ int MsgType;

    /*0xdb1c98*/ CFX_InspectorHelp();
    /*0xdb1c90*/ void Unlock();
}

class CFX_LightIntensityFade : UnityEngine.MonoBehaviour
{
    /*0x18*/ float duration;
    /*0x1c*/ float delay;
    /*0x20*/ float finalIntensity;
    /*0x24*/ float baseIntensity;
    /*0x28*/ bool autodestruct;
    /*0x2c*/ float p_lifetime;
    /*0x30*/ float p_delay;

    /*0xdb1ee0*/ CFX_LightIntensityFade();
    /*0xdb1ca0*/ void Start();
    /*0xdb1d00*/ void OnEnable();
    /*0xdb1d7c*/ void Update();
}

class CFX_ShurikenThreadFix : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.ParticleSystem[] systems;

    /*0xdb205c*/ CFX_ShurikenThreadFix();
    /*0xdb1ef0*/ void OnEnable();
    /*0xdb1fcc*/ System.Collections.IEnumerator WaitFrame();

    class <WaitFrame>d__2 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ CFX_ShurikenThreadFix <>4__this;

        /*0xdb2034*/ <WaitFrame>d__2(int <>1__state);
        /*0xdb2064*/ void System.IDisposable.Dispose();
        /*0xdb2068*/ bool MoveNext();
        /*0xdb2104*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb210c*/ void System.Collections.IEnumerator.Reset();
        /*0xdb214c*/ object System.Collections.IEnumerator.get_Current();
    }
}

class CFX_SpawnSystem : UnityEngine.MonoBehaviour
{
    static /*0x0*/ CFX_SpawnSystem instance;
    /*0x18*/ UnityEngine.GameObject[] objectsToPreload;
    /*0x20*/ int[] objectsToPreloadTimes;
    /*0x28*/ bool hideObjectsInHierarchy;
    /*0x29*/ bool allObjectsLoaded;
    /*0x30*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.GameObject>> instantiatedObjects;
    /*0x38*/ System.Collections.Generic.Dictionary<int, int> poolCursors;

    static /*0xdb2154*/ UnityEngine.GameObject GetNextObject(UnityEngine.GameObject sourceObj, bool activateObject);
    static /*0xdb2554*/ void PreloadObject(UnityEngine.GameObject sourceObj, int poolSize);
    static /*0xdb28bc*/ void UnloadObjects(UnityEngine.GameObject sourceObj);
    static /*0xdb2ca0*/ bool get_AllObjectsLoaded();
    /*0xdb2e50*/ CFX_SpawnSystem();
    /*0xdb25bc*/ void addObjectToPool(UnityEngine.GameObject sourceObject, int number);
    /*0xdb2914*/ void removeObjectsFromPool(UnityEngine.GameObject sourceObject);
    /*0xdb2cf4*/ void Awake();
    /*0xdb2dd0*/ void Start();
}

class BuildHelper_Asset : UnityEngine.ScriptableObject
{
    /*0x18*/ float Version;
    /*0x1c*/ int BundleVersion;
    /*0x20*/ bool Development_Build;
    /*0x21*/ bool China_Build;
    /*0x22*/ bool Attatch_Profiler;
    /*0x23*/ bool Godmod;
    /*0x24*/ bool TesterMod;
    /*0x25*/ bool Debug_Log;
    /*0x28*/ BuildHelper_Asset.AndroidExportType androidExportType;
    /*0x2c*/ bool androidTargetARM64;
    /*0x2d*/ bool androidTargetARMv7;
    /*0x2e*/ bool BuildAndRun;
    /*0x2f*/ bool UseIL2CPP;
    /*0x30*/ int iosBuildTargetArchitecture;
    /*0x34*/ BuildHelper_Asset.iOSProvisioningProfileType _iOSProvisioningProfileType;

    /*0xdb2f60*/ BuildHelper_Asset();

    enum AndroidExportType
    {
        APK = 0,
        AppBundle = 1,
        AndroidStudioProject = 2,
    }

    enum iOSProvisioningProfileType
    {
        Dev = 0,
        Release = 1,
    }
}

class cutscene_03_bgm : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.AudioSource audiosource;

    /*0xdb2f94*/ cutscene_03_bgm();
    /*0xdb2f78*/ void Play_Audio();
}

class GarlicCreditController : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicScreenFader screenFader;
    /*0x20*/ UnityEngine.UI.RawImage[] creditImages;
    /*0x28*/ GarlicText.UI.HyperText creditText;
    /*0x30*/ int creditSeason;
    /*0x38*/ System.Action onCreditStarted;
    /*0x40*/ System.Action onCreditFinished;
    /*0x48*/ string creditTextIDPrefix;
    /*0x50*/ string[] creditTextIDs;
    /*0x58*/ UnityEngine.Coroutine creditCoroutine;
    /*0x60*/ bool fadeFinished;

    /*0xdb33f4*/ GarlicCreditController();
    /*0xdb2f9c*/ void Awake();
    /*0xdb3024*/ void Update();
    /*0xdb3050*/ void startCreditCutscene();
    /*0xdb30a8*/ System.Collections.IEnumerator CreditCoroutine();
    /*0xdb3138*/ System.Collections.IEnumerator showCreditImages();
    /*0xdb31c8*/ void onCreditImageFadeOutFinished();
    /*0xdb3258*/ void hideAllImages();
    /*0xdb32c8*/ System.Collections.IEnumerator waitForFadeIn();
    /*0xdb3358*/ System.Collections.IEnumerator waitForFadeOut();
    /*0xdb33e8*/ void onFadeFinished();

    class <CreditCoroutine>d__12 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ GarlicCreditController <>4__this;

        /*0xdb3110*/ <CreditCoroutine>d__12(int <>1__state);
        /*0xdb344c*/ void System.IDisposable.Dispose();
        /*0xdb3450*/ bool MoveNext();
        /*0xdb3558*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb3560*/ void System.Collections.IEnumerator.Reset();
        /*0xdb35a0*/ object System.Collections.IEnumerator.get_Current();
    }

    class <showCreditImages>d__13 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ GarlicCreditController <>4__this;
        /*0x28*/ int <i>5__2;
        /*0x30*/ GarlicUIImageFader <fader>5__3;

        /*0xdb31a0*/ <showCreditImages>d__13(int <>1__state);
        /*0xdb35a8*/ void System.IDisposable.Dispose();
        /*0xdb35ac*/ bool MoveNext();
        /*0xdb38c0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb38c8*/ void System.Collections.IEnumerator.Reset();
        /*0xdb3908*/ object System.Collections.IEnumerator.get_Current();
    }

    class <waitForFadeIn>d__16 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ GarlicCreditController <>4__this;

        /*0xdb3330*/ <waitForFadeIn>d__16(int <>1__state);
        /*0xdb3910*/ void System.IDisposable.Dispose();
        /*0xdb3914*/ bool MoveNext();
        /*0xdb3a68*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb3a70*/ void System.Collections.IEnumerator.Reset();
        /*0xdb3ab0*/ object System.Collections.IEnumerator.get_Current();
    }

    class <waitForFadeOut>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ GarlicCreditController <>4__this;

        /*0xdb33c0*/ <waitForFadeOut>d__17(int <>1__state);
        /*0xdb3ab8*/ void System.IDisposable.Dispose();
        /*0xdb3abc*/ bool MoveNext();
        /*0xdb3c10*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb3c18*/ void System.Collections.IEnumerator.Reset();
        /*0xdb3c58*/ object System.Collections.IEnumerator.get_Current();
    }
}

class CutsceneAnimSfx : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicCutsceneAudioPlayer audioPlayer;

    /*0xdb3ca0*/ CutsceneAnimSfx();
    /*0xdb3c60*/ void Play_Sfx_Clip(UnityEngine.AudioClip clip);
}

class Cutscene_05_Core_Attatched : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Transform attatch_target;
    /*0x20*/ bool attatched;

    /*0xdb3d3c*/ Cutscene_05_Core_Attatched();
    /*0xdb3ca8*/ void Attatch();
    /*0xdb3d38*/ void Update();
}

class Cutscene_05_Lastboss_AnimEvent : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject core;

    /*0xdb3d9c*/ Cutscene_05_Lastboss_AnimEvent();
    /*0xdb3d44*/ void Attatch_Core_To_Hand();
}

class cutscene_event_00 : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject Player;
    /*0x20*/ GarlicCutsceneController cutsceneController;
    /*0x28*/ UnityEngine.Animator playerAnim;

    /*0xdb3f00*/ cutscene_event_00();
    /*0xdb3da4*/ void Awake();
    /*0xdb3dfc*/ void event_01();
    /*0xdb3e50*/ void event_10();
    /*0xdb3e70*/ System.Collections.IEnumerator event10Coroutine();

    class <event10Coroutine>d__6 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ cutscene_event_00 <>4__this;

        /*0xdb3ed8*/ <event10Coroutine>d__6(int <>1__state);
        /*0xdb3f08*/ void System.IDisposable.Dispose();
        /*0xdb3f0c*/ bool MoveNext();
        /*0xdb406c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb4074*/ void System.Collections.IEnumerator.Reset();
        /*0xdb40b4*/ object System.Collections.IEnumerator.get_Current();
    }
}

class cutscene_event_01 : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject Player;
    /*0x20*/ GarlicCutsceneController cutsceneController;
    /*0x28*/ GarlicCutsceneAudioPlayer cutsceneAudioPlayer;
    /*0x30*/ UnityEngine.GameObject monument_outer;
    /*0x38*/ UnityEngine.GameObject monument_inner_normal;
    /*0x40*/ UnityEngine.GameObject monument_inner_break;
    /*0x48*/ UnityEngine.Camera cutsceneMainCamera;
    /*0x50*/ GarlicScreenFlasher screenFlasher;
    /*0x58*/ UnityEngine.GameObject monumentParticleEffect;
    /*0x60*/ UnityEngine.GameObject campath_ev_03;
    /*0x68*/ UnityEngine.GameObject becky;
    /*0x70*/ UnityEngine.GameObject shirinkParticle;
    /*0x78*/ UnityEngine.GameObject burstParticle;
    /*0x80*/ UnityEngine.GameObject boss;
    /*0x88*/ float monument_inner_targetY;
    /*0x8c*/ float monumentInnerYBefore;
    /*0x90*/ bool monumentMoveDone;
    /*0x98*/ UnityEngine.GameObject[] octoNPCs;

    /*0xdb5d0c*/ cutscene_event_01();
    /*0xdb40bc*/ void Awake();
    /*0xdb40c0*/ void setupMonument();
    /*0xdb412c*/ void scene_05_after_script();
    /*0xdb414c*/ System.Collections.IEnumerator scene05_after_coroutine();
    /*0xdb41dc*/ void beckyCloseEye();
    /*0xdb4250*/ void octoStartPray();
    /*0xdb4354*/ System.Collections.IEnumerator moveMonumentInnerCoroutine();
    /*0xdb43e4*/ void iTweenMoveCamera(float moveTime);
    /*0xdb4960*/ void iTweenMoveMonumentInner(float moveTime);
    /*0xdb4d08*/ void onMonumentInnerMoveComplete();
    /*0xdb4d14*/ void scene_11_before_script();
    /*0xdb512c*/ void shakeMonumentInner();
    /*0xdb4dbc*/ void activateParticleColorPingpong();
    /*0xdb51b0*/ void setMonumentInnerEmissiveColor(UnityEngine.Color targetColor);
    /*0xdb5230*/ void showShirinkParticle();
    /*0xdb52cc*/ System.Collections.IEnumerator warmupParticleSpeed();
    /*0xdb535c*/ void setMonumentParticleSpeed(float targetSpeed);
    /*0xdb56f4*/ void scene_15_after_script();
    /*0xdb5714*/ System.Collections.IEnumerator scene15_after_script_coroutine();
    /*0xdb57a4*/ System.Collections.IEnumerator shirinkBeckyCoroutine();
    /*0xdb5834*/ void octoNPCsExplodeAway();
    /*0xdb5948*/ void turnOffOuterMonumentEmissive();
    /*0xdb5c98*/ void scene_17_before_script();

    class <scene05_after_coroutine>d__18 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ cutscene_event_01 <>4__this;

        /*0xdb41b4*/ <scene05_after_coroutine>d__18(int <>1__state);
        /*0xdb5d1c*/ void System.IDisposable.Dispose();
        /*0xdb5d20*/ bool MoveNext();
        /*0xdb5e54*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb5e5c*/ void System.Collections.IEnumerator.Reset();
        /*0xdb5e9c*/ object System.Collections.IEnumerator.get_Current();
    }

    class <moveMonumentInnerCoroutine>d__22 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ cutscene_event_01 <>4__this;

        /*0xdb43bc*/ <moveMonumentInnerCoroutine>d__22(int <>1__state);
        /*0xdb5ea4*/ void System.IDisposable.Dispose();
        /*0xdb5ea8*/ bool MoveNext();
        /*0xdb5f84*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb5f8c*/ void System.Collections.IEnumerator.Reset();
        /*0xdb5fcc*/ object System.Collections.IEnumerator.get_Current();
    }

    class <warmupParticleSpeed>d__32 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ cutscene_event_01 <>4__this;
        /*0x28*/ float <currentSpeed>5__2;
        /*0x2c*/ float <targetSpeed>5__3;
        /*0x30*/ float <startTime>5__4;

        /*0xdb5334*/ <warmupParticleSpeed>d__32(int <>1__state);
        /*0xdb5fd4*/ void System.IDisposable.Dispose();
        /*0xdb5fd8*/ bool MoveNext();
        /*0xdb6094*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb609c*/ void System.Collections.IEnumerator.Reset();
        /*0xdb60dc*/ object System.Collections.IEnumerator.get_Current();
    }

    class <scene15_after_script_coroutine>d__36 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ cutscene_event_01 <>4__this;

        /*0xdb577c*/ <scene15_after_script_coroutine>d__36(int <>1__state);
        /*0xdb60e4*/ void System.IDisposable.Dispose();
        /*0xdb60e8*/ bool MoveNext();
        /*0xdb63f0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb63f8*/ void System.Collections.IEnumerator.Reset();
        /*0xdb6438*/ object System.Collections.IEnumerator.get_Current();
    }

    class <shirinkBeckyCoroutine>d__37 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ cutscene_event_01 <>4__this;

        /*0xdb580c*/ <shirinkBeckyCoroutine>d__37(int <>1__state);
        /*0xdb6440*/ void System.IDisposable.Dispose();
        /*0xdb6444*/ bool MoveNext();
        /*0xdb65c0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb65c8*/ void System.Collections.IEnumerator.Reset();
        /*0xdb6608*/ object System.Collections.IEnumerator.get_Current();
    }
}

class cutscene_event_02 : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject Player;
    /*0x20*/ GarlicCutsceneController cutsceneController;
    /*0x28*/ GarlicCutsceneAudioPlayer cutsceneAudioPlayer;
    /*0x30*/ UnityEngine.Camera cutsceneMainCamera;
    /*0x38*/ UnityEngine.GameObject campath_zoomout_to;
    /*0x40*/ UnityEngine.GameObject becky;
    /*0x48*/ UnityEngine.Animator playerAnim;
    /*0x50*/ float camZoomoutTime;

    /*0xdb71c4*/ cutscene_event_02();
    /*0xdb6610*/ void Awake();
    /*0xdb67f8*/ void scene_01_before_script();
    /*0xdb6818*/ System.Collections.IEnumerator scene_01_before_coroutine();
    /*0xdb6784*/ void beckyCloseEye();
    /*0xdb68a8*/ void beckyFall();
    /*0xdb6c48*/ void onBeckyFallComplete();
    /*0xdb6c4c*/ void iTweenMoveCamera();

    class <scene_01_before_coroutine>d__10 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ cutscene_event_02 <>4__this;

        /*0xdb6880*/ <scene_01_before_coroutine>d__10(int <>1__state);
        /*0xdb71d4*/ void System.IDisposable.Dispose();
        /*0xdb71d8*/ bool MoveNext();
        /*0xdb728c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb7294*/ void System.Collections.IEnumerator.Reset();
        /*0xdb72d4*/ object System.Collections.IEnumerator.get_Current();
    }
}

class cutscene_event_03 : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicCutsceneController cutsceneController;
    /*0x20*/ GarlicCutsceneAudioPlayer cutsceneAudioPlayer;
    /*0x28*/ UnityEngine.UI.Image[] creditImages;
    /*0x30*/ GarlicText.UI.HyperText creditText;
    /*0x38*/ int creditSeason;
    /*0x3c*/ float creditImagePlayTime;
    /*0x40*/ float creditImageFadeTime;
    /*0x48*/ System.Action onCreditStarted;
    /*0x50*/ System.Action onCreditFinished;
    /*0x58*/ string creditTextIDPrefix;
    /*0x60*/ string[] creditTextIDs;
    /*0x68*/ UnityEngine.Coroutine creditCoroutine;
    /*0x70*/ UnityEngine.Animator endingAnimator;

    /*0xdb75c8*/ cutscene_event_03();
    /*0xdb72dc*/ void Awake();
    /*0xdb7364*/ void startCreditCutscene();
    /*0xdb73a8*/ System.Collections.IEnumerator CreditCoroutine();
    /*0xdb7438*/ System.Collections.IEnumerator showCreditImages();
    /*0xdb74c8*/ void onCreditImageFadeOutFinished();
    /*0xdb7558*/ void hideAllImages();

    class <CreditCoroutine>d__14 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ cutscene_event_03 <>4__this;

        /*0xdb7410*/ <CreditCoroutine>d__14(int <>1__state);
        /*0xdb762c*/ void System.IDisposable.Dispose();
        /*0xdb7630*/ bool MoveNext();
        /*0xdb76f4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb76fc*/ void System.Collections.IEnumerator.Reset();
        /*0xdb773c*/ object System.Collections.IEnumerator.get_Current();
    }

    class <showCreditImages>d__16 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ cutscene_event_03 <>4__this;

        /*0xdb74a0*/ <showCreditImages>d__16(int <>1__state);
        /*0xdb7744*/ void System.IDisposable.Dispose();
        /*0xdb7748*/ bool MoveNext();
        /*0xdb7810*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb7818*/ void System.Collections.IEnumerator.Reset();
        /*0xdb7858*/ object System.Collections.IEnumerator.get_Current();
    }
}

class cutscene_event_04 : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicCutsceneController cutsceneController;
    /*0x20*/ GarlicCutsceneAudioPlayer cutsceneAudioPlayer;
    /*0x28*/ UnityEngine.Animator lastboss_animator;

    /*0xdb795c*/ cutscene_event_04();
    /*0xdb7860*/ void lastboss_hello();
    /*0xdb78b4*/ void lastboss_frightened();
    /*0xdb7908*/ void lastboss_bye();
}

class cutscene_event_05 : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicCutsceneController cutsceneController;
    /*0x20*/ GarlicCutsceneAudioPlayer cutsceneAudioPlayer;
    /*0x28*/ GarlicScreenFlasher screenFlasher;
    /*0x30*/ Explosion_Manager explosion_manager;
    /*0x38*/ UnityEngine.Animator lastboss_animator;
    /*0x40*/ UnityEngine.GameObject main_camera;
    /*0x48*/ UnityEngine.GameObject obj_default;
    /*0x50*/ UnityEngine.GameObject obj_breakable;
    /*0x58*/ UnityEngine.GameObject core_object;
    /*0x60*/ UnityEngine.GameObject burst_particle;
    /*0x68*/ UnityEngine.GameObject dust_particle;
    /*0x70*/ UnityEngine.Transform core_to;

    /*0xdb7bbc*/ cutscene_event_05();
    /*0xdb7964*/ void begin_heart_explode_coroutine();
    /*0xdb7984*/ System.Collections.IEnumerator heart_explode_coroutine();
    /*0xdb7a14*/ void lastboss_hello();
    /*0xdb7a94*/ void lastboss_idle();
    /*0xdb7ae8*/ void lastboss_idle_angry();
    /*0xdb7b3c*/ void lastboss_bye();

    class <heart_explode_coroutine>d__13 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ cutscene_event_05 <>4__this;
        /*0x28*/ GarlicLoopingShake <shaker>5__2;

        /*0xdb79ec*/ <heart_explode_coroutine>d__13(int <>1__state);
        /*0xdb7bc4*/ void System.IDisposable.Dispose();
        /*0xdb7bc8*/ bool MoveNext();
        /*0xdb8450*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb8458*/ void System.Collections.IEnumerator.Reset();
        /*0xdb8498*/ object System.Collections.IEnumerator.get_Current();
    }
}

class cutscene_event_06 : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicCutsceneController cutsceneController;
    /*0x20*/ GarlicCutsceneAudioPlayer cutsceneAudioPlayer;
    /*0x28*/ UnityEngine.Animator lastboss_animator;
    /*0x30*/ UnityEngine.GameObject main_camera;
    /*0x38*/ UnityEngine.Transform Cam_Zoom;
    /*0x40*/ UnityEngine.Vector3 cam_initial_pos;
    /*0x4c*/ UnityEngine.Quaternion cam_initial_rot;

    /*0xdb8828*/ cutscene_event_06();
    /*0xdb84a0*/ void Start();
    /*0xdb84fc*/ void laydown_to_idle();
    /*0xdb857c*/ void wait_recovery();
    /*0xdb85d4*/ void babaam();
    /*0xdb85f4*/ System.Collections.IEnumerator babaam_coroutine();
    /*0xdb8684*/ void babaam_to_smile();
    /*0xdb86d8*/ void smile_to_question();
    /*0xdb872c*/ void idle_smile();
    /*0xdb8780*/ void idle_question();
    /*0xdb87d4*/ void smile_to_ahem();

    class <babaam_coroutine>d__11 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ cutscene_event_06 <>4__this;

        /*0xdb865c*/ <babaam_coroutine>d__11(int <>1__state);
        /*0xdb8830*/ void System.IDisposable.Dispose();
        /*0xdb8834*/ bool MoveNext();
        /*0xdb8cd8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdb8ce0*/ void System.Collections.IEnumerator.Reset();
        /*0xdb8d20*/ object System.Collections.IEnumerator.get_Current();
    }
}

class cutscene_event_holder_00 : UnityEngine.MonoBehaviour
{
    /*0xdb8f58*/ cutscene_event_holder_00();
    /*0xdb8d28*/ void event_01();
    /*0xdb8e3c*/ void event_02();
    /*0xdb8e80*/ void event_03();
    /*0xdb8ec4*/ void event_10();
    /*0xdb8dac*/ cutscene_event_00 getActualCutEventScript();
}

class cutscene_event_holder_01 : UnityEngine.MonoBehaviour
{
    /*0xdb9220*/ cutscene_event_holder_01();
    /*0xdb8f60*/ void scene_05_after_script();
    /*0xdb9084*/ void scene_11_before_script();
    /*0xdb9108*/ void scene_15_after_script();
    /*0xdb919c*/ void scene_17_before_script();
    /*0xdb8ff4*/ cutscene_event_01 getActualCutEventScript();
}

class cutscene_event_holder_02 : UnityEngine.MonoBehaviour
{
    /*0xdb934c*/ cutscene_event_holder_02();
    /*0xdb9228*/ void scene_01_before_script();
    /*0xdb92bc*/ cutscene_event_02 getActualCutEventScript();
}

class cutscene_event_holder_03 : UnityEngine.MonoBehaviour
{
    /*0xdb9468*/ cutscene_event_holder_03();
    /*0xdb9354*/ void startCredit();
    /*0xdb93d8*/ cutscene_event_03 getActualCutEventScript();
}

class cutscene_event_holder_04 : UnityEngine.MonoBehaviour
{
    /*0xdb968c*/ cutscene_event_holder_04();
    /*0xdb9470*/ void lastboss_hello();
    /*0xdb9584*/ void lastboss_frightened();
    /*0xdb9608*/ void lastboss_bye();
    /*0xdb94f4*/ cutscene_event_04 getActualCutEventScript();
}

class cutscene_event_holder_05 : UnityEngine.MonoBehaviour
{
    /*0xdb99c8*/ cutscene_event_holder_05();
    /*0xdb9694*/ void heart_begin_explosion();
    /*0xdb97b8*/ void lastboss_hello();
    /*0xdb983c*/ void lastboss_idle();
    /*0xdb98c0*/ void lastboss_idle_angry();
    /*0xdb9944*/ void lastboss_bye();
    /*0xdb9728*/ cutscene_event_05 getActualCutEventScript();
}

class cutscene_event_holder_06 : UnityEngine.MonoBehaviour
{
    /*0xdb9e90*/ cutscene_event_holder_06();
    /*0xdb99d0*/ void laydown_to_idle();
    /*0xdb9ae4*/ void wait_recovery();
    /*0xdb9b68*/ void babaam();
    /*0xdb9bfc*/ void babaam_to_smile();
    /*0xdb9c80*/ void smile_to_question();
    /*0xdb9d04*/ void idle_smile();
    /*0xdb9d88*/ void idle_question();
    /*0xdb9e0c*/ void smile_to_ahem();
    /*0xdb9a54*/ cutscene_event_06 getActualCutEventScript();
}

class Explosion_Manager : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject explosion_center;
    /*0x20*/ float force_amount;
    /*0x24*/ float force_radius;
    /*0x28*/ UnityEngine.Rigidbody[] objects_to_explode;
    /*0x30*/ UnityEngine.Vector3 initial_position;
    /*0x3c*/ UnityEngine.Quaternion initial_rot;

    /*0xdb9ee8*/ Explosion_Manager();
    /*0xdb9e98*/ void Start();
    /*0xdb8398*/ void explode();
}

class cutscene_skin : UnityEngine.MonoBehaviour
{
    /*0x18*/ prefab_ship ship_info;
    /*0x20*/ UnityEngine.SkinnedMeshRenderer rod_front;
    /*0x28*/ UnityEngine.SkinnedMeshRenderer rod_back;
    /*0x30*/ UnityEngine.SkinnedMeshRenderer body_front;
    /*0x38*/ UnityEngine.SkinnedMeshRenderer body_back;
    /*0x40*/ UnityEngine.Transform hat_parent;
    /*0x48*/ UnityEngine.Transform pos_character;
    /*0x50*/ UnityEngine.Transform pos_pet;
    /*0x58*/ UnityEngine.Transform[] pos_turrets;
    /*0x60*/ UnityEngine.Vector3 offset_character;
    /*0x6c*/ UnityEngine.Vector3 offset_pet;
    /*0x78*/ UnityEngine.Camera mainCam;

    /*0xdbb134*/ cutscene_skin();
    /*0xdb9efc*/ void Start();
    /*0xdba058*/ void Set_Ship();
    /*0xdba27c*/ void Set_inven();
    /*0xdba46c*/ void Set_skill();
    /*0xdbaae4*/ void Set_turret();
    /*0xdbae3c*/ void Set_pet();
    /*0xdba65c*/ void Set_character();
    /*0xdbaf5c*/ void LateUpdate();
}

class cutscene_letterbox_controller : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.RectTransform rectTransform;
    /*0x20*/ UnityEngine.Coroutine showCoroutine;
    /*0x28*/ UnityEngine.Coroutine hideCoroutine;

    /*0xdbb3c8*/ cutscene_letterbox_controller();
    /*0xdbb13c*/ void Awake();
    /*0xdbb18c*/ void showLetterbox(float spawnTime);
    /*0xdbb2a0*/ void hideLetterbox(float spawnTime);
    /*0xdbb1ec*/ void stopLetterboxCoroutine();
    /*0xdbb228*/ System.Collections.IEnumerator showLetterboxCoroutine(float spawnTime);
    /*0xdbb300*/ System.Collections.IEnumerator hideLetterboxCoroutine(float spawnTime);

    class <showLetterboxCoroutine>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ cutscene_letterbox_controller <>4__this;
        /*0x28*/ float spawnTime;
        /*0x2c*/ float <letterboxSpawnTimeCount>5__2;

        /*0xdbb378*/ <showLetterboxCoroutine>d__7(int <>1__state);
        /*0xdbb3d0*/ void System.IDisposable.Dispose();
        /*0xdbb3d4*/ bool MoveNext();
        /*0xdbb520*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdbb528*/ void System.Collections.IEnumerator.Reset();
        /*0xdbb568*/ object System.Collections.IEnumerator.get_Current();
    }

    class <hideLetterboxCoroutine>d__8 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ cutscene_letterbox_controller <>4__this;
        /*0x28*/ float spawnTime;
        /*0x2c*/ float <letterboxSpawnTimeCount>5__2;

        /*0xdbb3a0*/ <hideLetterboxCoroutine>d__8(int <>1__state);
        /*0xdbb570*/ void System.IDisposable.Dispose();
        /*0xdbb574*/ bool MoveNext();
        /*0xdbb6ec*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdbb6f4*/ void System.Collections.IEnumerator.Reset();
        /*0xdbb734*/ object System.Collections.IEnumerator.get_Current();
    }
}

class cutscene_mgr : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Events.UnityEvent OnCutsceneStarted;

    /*0xdbb780*/ cutscene_mgr();
    /*0xdbb73c*/ void Update();
}

enum GarlicNextScriptConditionType
{
    AnyKeyDown = 0,
    ScriptFinished = 1,
    WaitForEvent = 2,
}

class GarlicCutscene_Cut
{
    /*0x10*/ int cutIndex;
    /*0x18*/ string script_code;
    /*0x20*/ string portraitName;
    /*0x28*/ UnityEngine.Sprite portraitSprite;
    /*0x30*/ float scriptSpeed;
    /*0x34*/ GarlicNextScriptConditionType printNextScriptCondition;
    /*0x38*/ bool resume_animator;
    /*0x40*/ UnityEngine.Events.UnityEvent eventBeforeScript;
    /*0x48*/ UnityEngine.Events.UnityEvent eventAfterScript;

    /*0xdbb788*/ GarlicCutscene_Cut();
    /*0xdbb7f0*/ string get_script();
}

class GarlicCutscene_Cutscene : UnityEngine.ScriptableObject
{
    /*0x18*/ UnityEngine.TextAsset cutsceneJSONAsset;
    /*0x20*/ int cutscene_number;
    /*0x28*/ System.Collections.Generic.List<GarlicCutscene_Cut> cuts;

    /*0xdbb84c*/ GarlicCutscene_Cutscene();
}

class GarlicCutsceneAudioPlayer : UnityEngine.MonoBehaviour
{
    /*0x18*/ string audioSourcePath;
    /*0x20*/ UnityEngine.AudioClip[] audioClips;
    /*0x28*/ UnityEngine.AudioSource audioSource;
    /*0x30*/ System.Collections.Generic.Dictionary<string, UnityEngine.AudioSource> audioLoopChannels;
    /*0x38*/ System.Collections.Generic.Dictionary<string, UnityEngine.AudioClip> audioClipDict;

    /*0xdbbfe4*/ GarlicCutsceneAudioPlayer();
    /*0xdbb854*/ void Start();
    /*0xdbb9cc*/ void Play(UnityEngine.AudioClip clip, bool loop, bool fadeIn);
    /*0xdbbae0*/ UnityEngine.AudioSource Play_Channel(string chan, string clip_name, bool loop);
    /*0xdbbba4*/ UnityEngine.AudioSource Get_Channel(string chan);
    /*0xdbba78*/ System.Collections.IEnumerator audioSourceFadeIn(UnityEngine.AudioSource audioSource);
    /*0xdbbd94*/ System.Collections.IEnumerator audioSourceFadeOut(UnityEngine.AudioSource audioSource);
    /*0xdb3c84*/ void Play_sfx(UnityEngine.AudioClip clip);
    /*0xdb5250*/ void Play(string clipName, bool loop, bool fadeIn);
    /*0xdbbe24*/ void initAudioNames(string path);
    /*0xdbbe74*/ void fadeOutAll();
    /*0xdbb8cc*/ void setupAudioDict();

    class <audioSourceFadeIn>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UnityEngine.AudioSource audioSource;
        /*0x28*/ float <fadeInTime>5__2;
        /*0x2c*/ float <fadeTimeCount>5__3;

        /*0xdbbd6c*/ <audioSourceFadeIn>d__9(int <>1__state);
        /*0xdbbfec*/ void System.IDisposable.Dispose();
        /*0xdbbff0*/ bool MoveNext();
        /*0xdbc0b8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdbc0c0*/ void System.Collections.IEnumerator.Reset();
        /*0xdbc100*/ object System.Collections.IEnumerator.get_Current();
    }

    class <audioSourceFadeOut>d__10 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UnityEngine.AudioSource audioSource;
        /*0x28*/ float <fadeInTime>5__2;
        /*0x2c*/ float <fadeTimeCount>5__3;

        /*0xdbbdfc*/ <audioSourceFadeOut>d__10(int <>1__state);
        /*0xdbc108*/ void System.IDisposable.Dispose();
        /*0xdbc10c*/ bool MoveNext();
        /*0xdbc1dc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdbc1e4*/ void System.Collections.IEnumerator.Reset();
        /*0xdbc224*/ object System.Collections.IEnumerator.get_Current();
    }
}

class GarlicCutsceneController : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicScreenFader screenFader;
    /*0x20*/ cutscene_letterbox_controller letterboxBottom;
    /*0x28*/ cutscene_letterbox_controller letterboxTop;
    /*0x30*/ float letterboxSpawnTime;
    /*0x38*/ GarlicCutscene_Cutscene cutscene;
    /*0x40*/ UnityEngine.GameObject cutsceneEventObject;
    /*0x48*/ UnityEngine.GameObject scriptPanelObject;
    /*0x50*/ UnityEngine.UI.Image cutscenePortraitUI;
    /*0x58*/ GarlicText.UI.HyperText cutsceneTextUI;
    /*0x60*/ GarlicCutsceneAudioPlayer audioPlayer;
    /*0x68*/ float letterToPrintPerSecond;
    /*0x70*/ System.Action onCutsceneStarted;
    /*0x78*/ UnityEngine.Animator cutsceneControlAnimator;
    /*0x80*/ GarlicStringAdapterInterface languageStaringAdapter;
    /*0x88*/ UnityEngine.Coroutine cutsceneCoroutine;
    /*0x90*/ bool fadeFinished;
    /*0x91*/ bool printNextScript;

    /*0xdbc9b4*/ GarlicCutsceneController();
    /*0xdbc22c*/ void Awake();
    /*0xdbc350*/ void showLetterbox();
    /*0xdbc380*/ void hideLetterbox();
    /*0xdbc3b0*/ void startCutscene();
    /*0xdbc408*/ System.Collections.IEnumerator CutsceneCoroutine();
    /*0xdbc498*/ System.Collections.IEnumerator waitForFadeIn();
    /*0xdbc528*/ System.Collections.IEnumerator waitForFadeOut();
    /*0xdbc5b8*/ void onFadeFinished();
    /*0xdbc5c4*/ void hideScriptPanel();
    /*0xdbc5e4*/ void showScriptPanel();
    /*0xdbc604*/ System.Collections.IEnumerator ScriptPlayCoroutine();
    /*0xdbc694*/ System.Collections.IEnumerator beginCutCoroutine(GarlicCutscene_Cut currentCut);
    /*0xdbc730*/ System.Collections.IEnumerator WaitForAnyKey();
    /*0xdb4060*/ void PrintNextScript();
    /*0xdbc7b8*/ System.Collections.IEnumerator WaitForEvent();
    /*0xdbc848*/ void activateScriptUIs();
    /*0xdbc874*/ void clearScriptUI();
    /*0xdbc8e4*/ void inactivateScriptUIs();
    /*0xdbc910*/ void pauseAndPrintNextScript();
    /*0xdbc2c0*/ void pauseCutsceneAnimator();
    /*0xdbc92c*/ void resumeCutsceneAnimator();

    class <CutsceneCoroutine>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ GarlicCutsceneController <>4__this;

        /*0xdbc470*/ <CutsceneCoroutine>d__19(int <>1__state);
        /*0xdbc9cc*/ void System.IDisposable.Dispose();
        /*0xdbc9d0*/ bool MoveNext();
        /*0xdbcbe8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdbcbf0*/ void System.Collections.IEnumerator.Reset();
        /*0xdbcc30*/ object System.Collections.IEnumerator.get_Current();
    }

    class <waitForFadeIn>d__20 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ GarlicCutsceneController <>4__this;

        /*0xdbc500*/ <waitForFadeIn>d__20(int <>1__state);
        /*0xdbcc38*/ void System.IDisposable.Dispose();
        /*0xdbcc3c*/ bool MoveNext();
        /*0xdbcd24*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdbcd2c*/ void System.Collections.IEnumerator.Reset();
        /*0xdbcd6c*/ object System.Collections.IEnumerator.get_Current();
    }

    class <waitForFadeOut>d__21 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ GarlicCutsceneController <>4__this;

        /*0xdbc590*/ <waitForFadeOut>d__21(int <>1__state);
        /*0xdbcd74*/ void System.IDisposable.Dispose();
        /*0xdbcd78*/ bool MoveNext();
        /*0xdbce60*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdbce68*/ void System.Collections.IEnumerator.Reset();
        /*0xdbcea8*/ object System.Collections.IEnumerator.get_Current();
    }

    class <ScriptPlayCoroutine>d__26 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ GarlicCutsceneController <>4__this;
        /*0x28*/ System.Collections.Generic.List<GarlicCutscene_Cut> <cuts>5__2;
        /*0x30*/ int <i>5__3;
        /*0x38*/ GarlicCutscene_Cut <currentCut>5__4;

        /*0xdbc66c*/ <ScriptPlayCoroutine>d__26(int <>1__state);
        /*0xdbceb0*/ void System.IDisposable.Dispose();
        /*0xdbceb4*/ bool MoveNext();
        /*0xdbd120*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdbd128*/ void System.Collections.IEnumerator.Reset();
        /*0xdbd168*/ object System.Collections.IEnumerator.get_Current();
    }

    class <beginCutCoroutine>d__27 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ GarlicCutscene_Cut currentCut;
        /*0x28*/ GarlicCutsceneController <>4__this;
        /*0x30*/ string <cutText>5__2;
        /*0x38*/ string <currentText>5__3;
        /*0x40*/ float <letterPrintTime>5__4;
        /*0x44*/ float <letterPrintTimeCount>5__5;
        /*0x48*/ int <cutTextLetterIndex>5__6;

        /*0xdbc708*/ <beginCutCoroutine>d__27(int <>1__state);
        /*0xdbd170*/ void System.IDisposable.Dispose();
        /*0xdbd174*/ bool MoveNext();
        /*0xdbd400*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdbd408*/ void System.Collections.IEnumerator.Reset();
        /*0xdbd448*/ object System.Collections.IEnumerator.get_Current();
    }

    class <WaitForAnyKey>d__28 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;

        /*0xdbc790*/ <WaitForAnyKey>d__28(int <>1__state);
        /*0xdbd450*/ void System.IDisposable.Dispose();
        /*0xdbd454*/ bool MoveNext();
        /*0xdbd4f8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdbd500*/ void System.Collections.IEnumerator.Reset();
        /*0xdbd540*/ object System.Collections.IEnumerator.get_Current();
    }

    class <WaitForEvent>d__31 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ GarlicCutsceneController <>4__this;

        /*0xdbc820*/ <WaitForEvent>d__31(int <>1__state);
        /*0xdbd548*/ void System.IDisposable.Dispose();
        /*0xdbd54c*/ bool MoveNext();
        /*0xdbd5a4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdbd5ac*/ void System.Collections.IEnumerator.Reset();
        /*0xdbd5ec*/ object System.Collections.IEnumerator.get_Current();
    }
}

class GarlicCutsceneUIEnabler : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<UnityEngine.GameObject> enabledOnAwake;
    /*0x20*/ System.Collections.Generic.List<UnityEngine.GameObject> disabledOnAwake;

    /*0xdbd7a8*/ GarlicCutsceneUIEnabler();
    /*0xdbd5f4*/ void Awake();
    /*0xdbd618*/ void GOListSetActive(System.Collections.Generic.List<UnityEngine.GameObject> targets, bool active);
}

class GarlicObjectCopier
{
    static T Clone<T>(T source);
}

class GarlicParticleSpeedSetter : UnityEngine.MonoBehaviour
{
    /*0x18*/ float targetSpeed;
    /*0x20*/ UnityEngine.ParticleSystem ps;

    /*0xdbd868*/ GarlicParticleSpeedSetter();
    /*0xdbd7b0*/ void Start();
    /*0xdb56d8*/ void setParticlePlaybackSpeed(float targetSpeed);
}

class GarlicParticleSystemColorPingpong : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Color from;
    /*0x28*/ UnityEngine.Color to;
    /*0x38*/ float pingTime;
    /*0x40*/ UnityEngine.ParticleSystem ps;
    /*0x48*/ UnityEngine.ParticleSystem.Particle[] particles;

    /*0xdbdd4c*/ GarlicParticleSystemColorPingpong();
    /*0xdbd870*/ void Start();
    /*0xdbd8f8*/ void Update();
}

class GarlicPortraitSpriteHolder : UnityEngine.ScriptableObject
{
    /*0x18*/ UnityEngine.Sprite[] portraits;

    /*0xdbde50*/ GarlicPortraitSpriteHolder();
    /*0xdbdd5c*/ void Setup();
    /*0xdbddc8*/ UnityEngine.Sprite getPortraitSprite(string portraitName);
}

class GarlicScreenFader : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Image faderUIImage;
    /*0x20*/ GarlicScreenFader.FadeMode fadeMode;
    /*0x24*/ bool startFade;
    /*0x28*/ float fadeTime;
    /*0x2c*/ float fadeTimeCount;
    /*0x30*/ System.Action onFadeFinished;

    /*0xdbdf6c*/ GarlicScreenFader();
    /*0xdb39fc*/ void fadeIn(float fadeTime, System.Action onFadeFinished);
    /*0xdb3ba4*/ void fadeOut(float fadeTime, System.Action onFadeFinished);
    /*0xdbde58*/ void Update();
    /*0xdbdf40*/ void fadeFinished();

    enum FadeMode
    {
        FadeIn = 0,
        FadeOut = 1,
    }
}

class GarlicScreenFlasher : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Image flashImage;
    /*0x20*/ UnityEngine.Color flashColor;
    /*0x30*/ UnityEngine.Coroutine flashRoutine;

    /*0xdbe0bc*/ GarlicScreenFlasher();
    /*0xdb63e4*/ void Flash(float flashTime);
    /*0xdbdf74*/ void Flash(float flashTime, UnityEngine.Color targetColor);
    /*0xdbdff4*/ System.Collections.IEnumerator flashCoroutine(float flashTime, UnityEngine.Color targetColor);

    class <flashCoroutine>d__5 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ GarlicScreenFlasher <>4__this;
        /*0x28*/ UnityEngine.Color targetColor;
        /*0x38*/ float flashTime;

        /*0xdbe094*/ <flashCoroutine>d__5(int <>1__state);
        /*0xdbe0c4*/ void System.IDisposable.Dispose();
        /*0xdbe0c8*/ bool MoveNext();
        /*0xdbe1d4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdbe1dc*/ void System.Collections.IEnumerator.Reset();
        /*0xdbe21c*/ object System.Collections.IEnumerator.get_Current();
    }
}

interface GarlicStringAdapterInterface
{
    string get_language(string code);
}

class StringAdapterMain : GarlicStringAdapterInterface
{
    /*0xdbc348*/ StringAdapterMain();
    /*0xdbe224*/ string get_language(string code);
}

class StringAdapterTemporary : GarlicStringAdapterInterface
{
    /*0x10*/ UnityEngine.TextAsset textJsonAsset;
    /*0x18*/ GarlicSimpleJSON.JSONNode json;

    /*0xdbe27c*/ StringAdapterTemporary(UnityEngine.TextAsset targetAsset);
    /*0xdbe2a8*/ void setTextAsset(UnityEngine.TextAsset textAsset);
    /*0xdbe2dc*/ string get_language(string code);
}

class GarlicUIImageFader : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicUIImageFader.FadeMode fadeMode;
    /*0x1c*/ bool startFade;
    /*0x20*/ float fadeTime;
    /*0x24*/ float fadeTimeCount;
    /*0x28*/ System.Action onFadeFinished;
    /*0x30*/ UnityEngine.UI.RawImage uiImage;
    /*0x38*/ UnityEngine.Color baseColor;

    /*0xdbe4f4*/ GarlicUIImageFader();
    /*0xdbe378*/ void Awake();
    /*0xdb3858*/ void fadeOut(float fadeTime, System.Action onFadeFinished);
    /*0xdb37f0*/ void fadeIn(float fadeTime, System.Action onFadeFinished);
    /*0xdbe3e8*/ void Update();
    /*0xdbe4c8*/ void fadeFinished();

    enum FadeMode
    {
        FadeOut = 0,
        FadeIn = 1,
    }
}

class cutscene_s2ending : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Animator myAnim;
    /*0x20*/ UnityEngine.AudioSource bgm;

    /*0xdbe858*/ cutscene_s2ending();
    /*0xdbe4fc*/ void startCutscene();
    /*0xdbe550*/ void Play_BGM();
    /*0xdbe56c*/ void Set_Ambient(anim_ambient.LockState state, float time);
    /*0xdbe6a4*/ void Set_Ambient_00();
    /*0xdbe6b4*/ void Set_Ambient_01();
    /*0xdbe6c4*/ void Set_Ambient_02();
    /*0xdbe6d0*/ void Set_Ambient_03();
    /*0xdbe6e0*/ void Set_Ambient_04();
    /*0xdbe6f0*/ void OnFinished();
}

class cutscene_s2ending_cam : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Camera mainCam;
    /*0x20*/ UnityEngine.Transform trans_lookAt;

    /*0xdbe930*/ cutscene_s2ending_cam();
    /*0xdbe860*/ void LateUpdate();
}

class GarlicLoopingShake : UnityEngine.MonoBehaviour
{
    /*0x18*/ float shakeAmount;
    /*0x1c*/ UnityEngine.Vector3 originalPos;

    static /*0xdb8220*/ GarlicLoopingShake AttatchScript(UnityEngine.GameObject target);
    static /*0xdb82e0*/ void DetatchScript(UnityEngine.GameObject target);
    /*0xdbea00*/ GarlicLoopingShake();
    /*0xdbe938*/ void Start();
    /*0xdbe968*/ void Update();
}

class GarlicOctoFlyAway : UnityEngine.MonoBehaviour
{
    /*0x18*/ float startTime;
    /*0x1c*/ UnityEngine.Vector3 axisMask;

    /*0xdbec94*/ GarlicOctoFlyAway();
    /*0xdbea14*/ void Start();
    /*0xdbeb34*/ void explode();
    /*0xdbec10*/ void Update();
}

class GarlicSetEmissiveByScript : UnityEngine.MonoBehaviour
{
    /*0x18*/ float targetEmissiveValue;
    /*0x20*/ UnityEngine.Renderer myRenderer;
    /*0x28*/ UnityEngine.Color baseColor;

    /*0xdbed80*/ GarlicSetEmissiveByScript();
    /*0xdbec9c*/ void Start();
}

class GarlicSlowEmissive : UnityEngine.MonoBehaviour
{
    /*0x18*/ float emissiveMin;
    /*0x1c*/ float emissiveMax;
    /*0x20*/ float emissiveCycleTime;
    /*0x24*/ UnityEngine.Color baseColor;
    /*0x38*/ UnityEngine.Renderer myRenderer;
    /*0x40*/ float startTime;

    /*0xdbef24*/ GarlicSlowEmissive();
    /*0xdbed90*/ void Start();
    /*0xdbedec*/ void Update();
    /*0xdbeec0*/ float getCurrentEmissiveValue();
}

class GarlicSlowFloat : UnityEngine.MonoBehaviour
{
    /*0x18*/ float floatAmount;
    /*0x1c*/ float floatCycleTime;
    /*0x20*/ UnityEngine.Vector3 originalPos;
    /*0x2c*/ float startTime;

    /*0xdbf01c*/ GarlicSlowFloat();
    /*0xdbef40*/ void Start();
    /*0xdbef7c*/ void Update();
}

class StardustSpawner : UnityEngine.MonoBehaviour
{
    static /*0x0*/ StardustSpawner ins;
    /*0x18*/ UnityEngine.GameObject stardust_prefab;
    /*0x20*/ int min_spawn_count;
    /*0x24*/ int max_spawn_count;
    /*0x28*/ float min_spawn_interval;
    /*0x2c*/ float max_spawn_interval;
    /*0x30*/ UnityEngine.BoxCollider spawnBox;
    /*0x38*/ SimplePool<UnityEngine.Vector3> pool;
    /*0x40*/ float spawn_time_count;
    /*0x44*/ float next_spawn_time_interval;
    /*0x48*/ bool isOn;

    /*0xdbf438*/ StardustSpawner();
    /*0xdbf030*/ void Awake();
    /*0xdbf154*/ void Start();
    /*0xdbf1c0*/ void Update();
    /*0xdbf22c*/ void spawn_dust(int spawn_count);
    /*0xdbf420*/ void on();
    /*0xdbf42c*/ void off();
}

class Stardust_Mover : SimplePool_element<UnityEngine.Vector3>
{
    /*0x30*/ UnityEngine.AnimationCurve scale_curve;
    /*0x38*/ UnityEngine.AnimationCurve speed_curve;
    /*0x40*/ float max_speed;
    /*0x44*/ float max_size;
    /*0x48*/ float reach_max_speed_time;
    /*0x4c*/ float reach_max_size_time;
    /*0x50*/ float y_destroy;
    /*0x58*/ UnityEngine.SpriteRenderer sprite;
    /*0x60*/ UnityEngine.TrailRenderer trail;
    /*0x68*/ float trail_timeOrigin;
    /*0x6c*/ float time;
    /*0x70*/ bool isActive;

    /*0xdbf7f0*/ Stardust_Mover();
    /*0xdbf454*/ void Instantiate();
    /*0xdbf514*/ void Awake();
    /*0xdbf53c*/ void Update();
    /*0xdbf5a0*/ void set_scale(float percentage);
    /*0xdbf638*/ void set_speed(float percentage);
    /*0xdbf710*/ void check_to_destroy();
    /*0xdbf760*/ System.Collections.IEnumerator IE_Destroy();

    class <IE_Destroy>d__18 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Stardust_Mover <>4__this;
        /*0x28*/ float <time_Destroy>5__2;

        /*0xdbf7c8*/ <IE_Destroy>d__18(int <>1__state);
        /*0xdbf844*/ void System.IDisposable.Dispose();
        /*0xdbf848*/ bool MoveNext();
        /*0xdbf90c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdbf914*/ void System.Collections.IEnumerator.Reset();
        /*0xdbf954*/ object System.Collections.IEnumerator.get_Current();
    }
}

class ActivateBySystemLanguage : UnityEngine.MonoBehaviour
{
    /*0x18*/ ActivateBySystemLanguage.mode activation_mode;
    /*0x20*/ ActivateBySystemLanguage.LanguageGameObjPair[] activation_infos;

    /*0xdbfd88*/ ActivateBySystemLanguage();
    /*0xdbf95c*/ void OnEnable();
    /*0xdbfcd0*/ void OnDisable();
    /*0xdbfa60*/ void Refresh_UI();

    enum mode
    {
        deactivate_others = 0,
        juse_activate = 1,
    }

    class LanguageGameObjPair
    {
        /*0x10*/ stringFormat.lang_type lang_type;
        /*0x18*/ UnityEngine.GameObject obj_to_activate;

        /*0xdbfd90*/ LanguageGameObjPair();
    }
}

class ActivateBySystemLanguage_krOnly : UnityEngine.MonoBehaviour
{
    /*0xdbfee0*/ ActivateBySystemLanguage_krOnly();
    /*0xdbfd98*/ void Awake();
    /*0xdbfe9c*/ void Refresh_UI();
}

class addon : UnityEngine.MonoBehaviour
{
    static /*0x0*/ addon ins;
    /*0x18*/ addon_review review;
    /*0x20*/ addon_social social;
    /*0x28*/ addon_admob admob;
    /*0x30*/ addon_admob_interstitial admob_interstitial;
    /*0x38*/ addon_ads ads;
    /*0x40*/ addon_iap iap;
    /*0x48*/ addon_sendbird_v3 sendbird;
    /*0x50*/ addon_www www;
    /*0x58*/ addon_daeri daeri;
    /*0x60*/ addon_igaworks igaworks;
    /*0x68*/ addon_setting setting;
    /*0x70*/ addon_gc gc;
    /*0x78*/ addon_android android;
    /*0x80*/ addon_url url;
    /*0x88*/ addon_eu_gdpr eu_gdpr;
    /*0x90*/ addon_firebase firebase;
    /*0x98*/ addon_facebook _facebook;
    /*0xa0*/ addon_fontchanger font_changer;

    /*0xdc03d4*/ addon();
    /*0xdbfee8*/ void Awake();
    /*0xdbffa8*/ void Initialize();
    /*0xdc0330*/ addon_facebook get_facebook();
}

class addon_admob : UnityEngine.MonoBehaviour
{
    /*0x18*/ GoogleMobileAds.Api.BannerView banner;
    /*0x20*/ UnityEngine.TextAsset txt_exceptions;

    /*0xdc06d4*/ addon_admob();
    /*0xdc01f4*/ void Initialize();
    /*0xdc03dc*/ void RequestBannerAd();
    /*0xdc05b0*/ void Show();
    /*0xdc0628*/ void Hide();
    /*0xdc06a0*/ void OnAdLoaded(object sender, System.EventArgs args);
    /*0xdc06ac*/ void OnAdFailedToLoad(object sender, GoogleMobileAds.Api.AdFailedToLoadEventArgs args);

    class <>c
    {
        static /*0x0*/ addon_admob.<> <>9;
        static /*0x8*/ System.Action<GoogleMobileAds.Api.InitializationStatus> <>9__2_0;

        static /*0xdc06dc*/ <>c();
        /*0xdc0740*/ <>c();
        /*0xdc0748*/ void <Initialize>b__2_0(GoogleMobileAds.Api.InitializationStatus initStatus);
    }
}

class addon_admob_interstitial : UnityEngine.MonoBehaviour
{
    static float COOLTIME = 420;
    /*0x18*/ addon_admob_interstitial_impl ad_loader;
    /*0x20*/ float <cooltime_now>k__BackingField;

    /*0xdc1304*/ addon_admob_interstitial();
    /*0xdc074c*/ bool get_IsAdReady();
    /*0xdc07f4*/ float get_cooltime_now();
    /*0xdc07fc*/ void set_cooltime_now(float value);
    /*0xdc0804*/ void Start();
    /*0xdc0b58*/ void Update();
    /*0xdc0de0*/ void OnInterstitialLoaded(object sender, System.EventArgs args);
    /*0xdc0e24*/ void OnInterstitialFailedToLoad(object sender, GoogleMobileAds.Api.AdFailedToLoadEventArgs args);
    /*0xdc0ee4*/ void OnInterstitialClosed(object sender, System.EventArgs args);
    /*0xdc0f58*/ void Debug_Force_Interstitial();
    /*0xdc11f4*/ void OnInterstitialLoaded_Debug(object sender, System.EventArgs args);
    /*0xdc128c*/ void ShowInterstitial();
}

class addon_admob_interstitial_impl : IGarlicInterstitialAdInterface
{
    /*0x10*/ System.EventHandler<System.EventArgs> OnInterstitialLoaded;
    /*0x18*/ System.EventHandler<System.EventArgs> OnInterstitialClosed;
    /*0x20*/ System.EventHandler<GoogleMobileAds.Api.AdFailedToLoadEventArgs> OnInterstitialFailedToLoad;
    /*0x28*/ GoogleMobileAds.Api.InterstitialAd <interstitial>k__BackingField;

    /*0xdc097c*/ addon_admob_interstitial_impl(System.Action<object, System.EventArgs> OnInterstitialLoaded, System.Action<object, GoogleMobileAds.Api.AdFailedToLoadEventArgs> OnInterstitialFailedToLoad, System.Action<object, System.EventArgs> OninterstitialClosed);
    /*0xdc07d4*/ bool get_IsAdReady();
    /*0xdc1314*/ GoogleMobileAds.Api.InterstitialAd get_interstitial();
    /*0xdc131c*/ void set_interstitial(GoogleMobileAds.Api.InterstitialAd value);
    /*0xdc0ad8*/ void Initialize();
    /*0xdc0ce0*/ void RequestAd();
    /*0xdc1324*/ GoogleMobileAds.Api.AdRequest CreateAdRequest();
    /*0xdc10a8*/ bool Show(System.Action OnShowSuccess, System.Action OnShowSkipped, System.Action OnShowFailed);
    /*0xdc0ec0*/ void DestroyInterstitial();
    /*0xdc1384*/ void <Initialize>b__10_0(GoogleMobileAds.Api.InitializationStatus initializeStatus);

    class <>c__DisplayClass3_0
    {
        /*0x10*/ System.Action<object, System.EventArgs> OnInterstitialLoaded;
        /*0x18*/ System.Action<object, System.EventArgs> OninterstitialClosed;
        /*0x20*/ System.Action<object, GoogleMobileAds.Api.AdFailedToLoadEventArgs> OnInterstitialFailedToLoad;

        /*0xdc130c*/ <>c__DisplayClass3_0();
        /*0xdc1388*/ void <.ctor>b__0(object o, System.EventArgs ea);
        /*0xdc13ac*/ void <.ctor>b__1(object o, System.EventArgs ea);
        /*0xdc13d0*/ void <.ctor>b__2(object o, GoogleMobileAds.Api.AdFailedToLoadEventArgs afea);
    }
}

class addon_ads : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<IGarlicInterstitialAdInterface> ad_interfaces;
    /*0x20*/ bool showing;

    /*0xdc1aa8*/ addon_ads();
    /*0xdc0014*/ void Initialize();
    /*0xdc13fc*/ void Show(System.Action onShowSuccess, bool rewardAnyway, bool showAlert);
    /*0xdc14e0*/ System.Collections.IEnumerator IE_Show(System.Action onShowSuccess, bool rewardAnyway, bool showAlert);
    /*0xdc15a0*/ IGarlicInterstitialAdInterface get_valid_ad();
    /*0xdc16c8*/ void setShowingFalse();
    /*0xdc16d0*/ void Debug_Show();
    /*0xdc1828*/ void Debug_Unity();
    T get_interface_of<T>();
    /*0xdc1aa4*/ void Debug_Admob_Popup();

    class <IE_Show>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ addon_ads <>4__this;
        /*0x28*/ bool showAlert;
        /*0x29*/ bool rewardAnyway;
        /*0x30*/ System.Action onShowSuccess;

        /*0xdc1578*/ <IE_Show>d__4(int <>1__state);
        /*0xdc1ab0*/ void System.IDisposable.Dispose();
        /*0xdc1ab4*/ bool MoveNext();
        /*0xdc1ddc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdc1de4*/ void System.Collections.IEnumerator.Reset();
        /*0xdc1e24*/ object System.Collections.IEnumerator.get_Current();
    }

    class <>c
    {
        static /*0x0*/ addon_ads.<> <>9;
        static /*0x8*/ System.Action <>9__7_0;
        static /*0x10*/ System.Action <>9__8_0;
        static /*0x18*/ System.Action <>9__8_1;

        static /*0xdc1e2c*/ <>c();
        /*0xdc1e90*/ <>c();
        /*0xdc1e98*/ void <Debug_Show>b__7_0();
        /*0xdc1f10*/ void <Debug_Unity>b__8_0();
        /*0xdc1f88*/ void <Debug_Unity>b__8_1();
    }
}

class addon_ads_unity : IGarlicInterstitialAdInterface, UnityEngine.Advertisements.IUnityAdsLoadListener, UnityEngine.Advertisements.IUnityAdsShowListener, UnityEngine.Advertisements.IUnityAdsInitializationListener
{
    static string UNITYADS_ID = "130090";
    static string UNITYADS_ZONE = "rewardedshow";
    /*0x10*/ bool _adLoaded;
    /*0x18*/ System.Action OnShowSuccess;
    /*0x20*/ System.Action OnShowSkipped;
    /*0x28*/ System.Action OnShowFailed;

    /*0xdc13f4*/ addon_ads_unity();
    /*0xdc2000*/ void OnInitializationComplete();
    /*0xdc2078*/ void LoadAd();
    /*0xdc20ec*/ void OnInitializationFailed(UnityEngine.Advertisements.UnityAdsInitializationError error, string message);
    /*0xdc21e0*/ void OnUnityAdsAdLoaded(string placementId);
    /*0xdc2294*/ void OnUnityAdsFailedToLoad(string placementId, UnityEngine.Advertisements.UnityAdsLoadError error, string message);
    /*0xdc2398*/ void OnUnityAdsShowFailure(string placementId, UnityEngine.Advertisements.UnityAdsShowError error, string message);
    /*0xdc248c*/ void OnUnityAdsShowStart(string placementId);
    /*0xdc24f4*/ void OnUnityAdsShowClick(string placementId);
    /*0xdc255c*/ void OnUnityAdsShowComplete(string placementId, UnityEngine.Advertisements.UnityAdsShowCompletionState showCompletionState);
    /*0xdc2828*/ bool get_IsAdReady();
    /*0xdc2898*/ void Initialize();
    /*0xdc1a08*/ bool Show(System.Action OnShowSuccess, System.Action OnShowSkipped, System.Action OnShowFailed);
    /*0xdc266c*/ void OnShown(UnityEngine.Advertisements.UnityAdsShowCompletionState result);
}

class addon_android : UnityEngine.MonoBehaviour
{
    /*0x18*/ string string_prefix;
    /*0x20*/ string[] _permissionNames;
    /*0x28*/ bool isDone;

    /*0xdc3658*/ addon_android();
    /*0xdc2988*/ System.Collections.IEnumerator IE_Check();
    /*0xdc2a18*/ void requestPermission();
    /*0xdc2afc*/ System.Collections.Generic.List<string> checkPermission(string[] permissionNames);
    /*0xdc2c58*/ System.Collections.Generic.List<string> getNeedDescriptionPermission(System.Collections.Generic.List<string> requestPermissionNames);
    /*0xdc3360*/ void requestPermission(System.Collections.Generic.List<string> requestPermissionNames);
    /*0xdc2c44*/ void onRequestPermissionResult(bool success, string[] failPermission);
    /*0xdc2f64*/ void showPermissionDescription(System.Collections.Generic.List<string> needPermission);
    /*0xdc348c*/ void showGameNotiQuit();

    class <IE_Check>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ addon_android <>4__this;

        /*0xdc29f0*/ <IE_Check>d__3(int <>1__state);
        /*0xdc36d4*/ void System.IDisposable.Dispose();
        /*0xdc36d8*/ bool MoveNext();
        /*0xdc37e4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0xdc37ec*/ void System.Collections.IEnumerator.Reset();
        /*0xdc382c*/ object System.Collections.IEnumerator.get_Current();
    }

    class <>c__DisplayClass9_0
    {
        /*0x10*/ addon_android <>4__this;
        /*0x18*/ System.Collections.Generic.List<string> needPermission;

        /*0xdc3650*/ <>c__DisplayClass9_0();
        /*0xdc3834*/ void <showPermissionDescription>b__1();
        /*0xdc3854*/ void <showPermissionDescription>b__0();
    }

    class <>c
    {
        static /*0x0*/ addon_android.<> <>9;
        static /*0x8*/ System.Action <>9__10_0;

        static /*0xdc3874*/ <>c();
        /*0xdc38d8*/ <>c();
        /*0xdc38e0*/ void <showGameNotiQuit>b__10_0();
    }
}

class addon_daeri : UnityEngine.MonoBehaviour
{
    static string daeri_url = "https://pf.daerisoft.com";
    static int ivSize = 32;
    static string serviceName = "girlAdrift";
    static string daeriKey = "girlAdriftTapas";
    static string SAVEKEY = "TAPASSAVER";
    static float COOLTIME = 300;
    /*0x18*/ System.Collections.Generic.Dictionary<int, System.Action<int, string>> request_dict;
    /*0x20*/ System.Collections.IEnumerator cor;
    /*0x28*/ addon_daeri_notice notice;
    /*0x30*/ string Notice_URL;
    /*0x38*/ float cooltime_now;

    /*0xdc59f4*/ addon_daeri();
    /*0xdc38e8*/ void Post(int id, string funcName, string jsonStr, System.Action<int, string> action);
    /*0xdc3b94*/ void Get(string url, System.Action<int, string> action);
    /*0xdc3d20*/ void Result(int id, int responseStatusCode, string resJson);
    /*0xdc3f00*/ void Result_Notice(int id, int responseStatusCode, string resJson);
    /*0xdc3ff0*/ void Cloud_Save_Warn();
    /*0xdc42f8*/ void Cloud_Save_Auto();
    /*0xdc4448*/ void Cloud_Save(bool alert, bool show_interstitial_after_save);
    /*0xdc4910*/ void Cloud_Load_Warn(string user_id_to_load);
    /*0xdc4a08*/ void Cloud_Load(string user_id_to_load);
    /*0xdc4c88*/ void Coupon_Request(string coupon, bool alert);
    /*0xdc50dc*/ void Mail_Request();
    /*0xdc5388*/ void Ban_Request();
    /*0xdc558c*/ void Get_Notice(System.Action<SimpleJSON_Ex.JSONNode> onNoticeReceiveSuccess, System.Action onNoticeReceiveFail);
    /*0xdc5698*/ void Awake();
    /*0xdc5750*/ void Refresh_Init();
    /*0xdc5758*/ void Update();
    /*0xdc5994*/ void OnApplicationQuit();
    /*0xdc5ab8*/ void <Cloud_Save_Warn>b__11_0();

    class <>c__DisplayClass13_0
    {
        /*0x10*/ bool alert;

        /*0x170b590*/ <>c__DisplayClass13_0();
        /*0x170b598*/ void <Cloud_Save>b__0(int response_status_code, string www_data);
    }

    class <>c__DisplayClass15_0
    {
        /*0x10*/ string data_load;

        /*0x170b714*/ <>c__DisplayClass15_0();
        /*0x170b71c*/ void <Cloud_Load>b__1();
    }

    class <>c
    {
        static /*0x0*/ addon_daeri.<> <>9;
        static /*0x8*/ System.Action<int, string> <>9__15_0;
        static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<string, SimpleJSON_2020.JSONNode>, string> <>9__17_2;
        static /*0x18*/ System.Action <>9__18_1;
        static /*0x20*/ System.Action<int, string> <>9__18_0;

        static /*0x170b778*/ <>c();
        /*0x170b7dc*/ <>c();
        /*0x170b7e4*/ void <Cloud_Load>b__15_0(int response_status_code, string www_data);
        /*0x170be7c*/ string <Mail_Request>b__17_2(System.Collections.Generic.KeyValuePair<string, SimpleJSON_2020.JSONNode> pair);
        /*0x170beb8*/ void <Ban_Request>b__18_0(int response_status_code, string www_data);
        /*0x170c1b4*/ void <Ban_Request>b__18_1();
    }

    class <>c__DisplayClass16_0
    {
        /*0x10*/ bool alert;

        /*0x170c1bc*/ <>c__DisplayClass16_0();
        /*0x170c1c4*/ void <Coupon_Request>b__0(int response_status_code, string www_data);
    }

    class <>c__DisplayClass17_0
    {
        /*0x10*/ SimpleJSON_2020.JSONObject json;
        /*0x18*/ addon_daeri <>4__this;

        /*0x170c6f8*/ <>c__DisplayClass17_0();
        /*0x170c700*/ void <Mail_Request>b__0(int response_status_code, string www_data);
    }

    class <>c__DisplayClass17_1
    {
        /*0x10*/ System.Action action_reward;

        /*0x170d214*/ <>c__DisplayClass17_1();
        /*0x170d224*/ void <Mail_Request>b__1(int _response_status_code, string www_data2);
    }

    class <>c__DisplayClass17_2
    {
        /*0x10*/ CurNumPair pair;
        /*0x18*/ string message;

        /*0x170d21c*/ <>c__DisplayClass17_2();
        /*0x170d3ac*/ void <Mail_Request>b__3();
    }

    class <>c__DisplayClass21_0
    {
        /*0x10*/ System.Action<SimpleJSON_Ex.JSONNode> onNoticeReceiveSuccess;
        /*0x18*/ System.Action onNoticeReceiveFail;

        /*0x170d410*/ <>c__DisplayClass21_0();
        /*0x170d418*/ void <Get_Notice>b__0(int response_status_code, string www_data);
    }
}

class addon_daeri_notice
{
    /*0x170e090*/ addon_daeri_notice();
    /*0x170d4e8*/ void Connect();
    /*0x170d59c*/ void parse_notice(SimpleJSON_Ex.JSONNode notice_root);
    /*0x170d5b0*/ SimpleJSON_Ex.JSONNode get_platform_notice(SimpleJSON_Ex.JSONNode notice_root);
    /*0x170d6a8*/ void receive_gift(SimpleJSON_Ex.JSONNode notice);
}

class addon_eu_gdpr : UnityEngine.MonoBehaviour
{
    static string GDPR_PRF = "addon_gdpr";
    /*0x18*/ string[] eu_countries;

    /*0x170e2a4*/ addon_eu_gdpr();
    /*0x170e098*/ bool IsEURegion();
    /*0x170e148*/ bool get_accepted();
    /*0x170e1c0*/ void set_accepted(bool value);
    /*0x170e214*/ System.Collections.IEnumerator IE_Check();

    class <IE_Check>d__6 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ addon_eu_gdpr <>4__this;

        /*0x170e27c*/ <IE_Check>d__6(int <>1__state);
        /*0x170ea20*/ void System.IDisposable.Dispose();
        /*0x170ea24*/ bool MoveNext();
        /*0x170eb1c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x170eb24*/ void System.Collections.IEnumerator.Reset();
        /*0x170eb64*/ object System.Collections.IEnumerator.get_Current();
    }
}

class addon_facebook : UnityEngine.MonoBehaviour
{
    /*0x18*/ bool mIsFaceBookActivation;

    /*0x170f284*/ addon_facebook();
    /*0x170eb6c*/ void Initialize();
    /*0x170eca8*/ void InitCallback();
    /*0x170ed5c*/ void OnHideUnity(bool isGameShown);
    /*0x170ed74*/ void LogPurchase(data_iap_element iap);
    /*0x170ee3c*/ void LogRank();
    /*0x170f06c*/ void LogRank(int rank_achieved);
}

class addon_firebase : UnityEngine.MonoBehaviour
{
    /*0x170f3bc*/ addon_firebase();
    /*0x170f28c*/ void Initialize();

    class <>c
    {
        static /*0x0*/ addon_firebase.<> <>9;
        static /*0x8*/ System.Action<System.Threading.Tasks.Task<Firebase.DependencyStatus>> <>9__0_0;

        static /*0x170f3c4*/ <>c();
        /*0x170f428*/ <>c();
        /*0x170f430*/ void <Initialize>b__0_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> task);
    }
}

class addon_fontchanger : UnityEngine.MonoBehaviour
{
    /*0x18*/ addon_fontchanger.OnFontShouldChangeEvent _onFontShouldChangeEvents;

    /*0x170f664*/ addon_fontchanger();
    /*0x170f548*/ void set_font(stringFormat.lang_type language_type);
    /*0x170f564*/ void add_listener(addon_fontchanger.OnFontShouldChangeEvent onFontShouldChangeEvent);
    /*0x170f5e4*/ void remove_listener(addon_fontchanger.OnFontShouldChangeEvent onFontShouldChangeEvent);

    class OnFontShouldChangeEvent : System.MulticastDelegate
    {
        /*0x170f66c*/ OnFontShouldChangeEvent(object object, nint method);
        /*0x170f730*/ void Invoke(stringFormat.lang_type changedLanguage);
        /*0x170f744*/ System.IAsyncResult BeginInvoke(stringFormat.lang_type changedLanguage, System.AsyncCallback callback, object object);
        /*0x170f7c8*/ void EndInvoke(System.IAsyncResult result);
    }
}

class addon_gc : UnityEngine.MonoBehaviour
{
    static float TIME_REFRESH_MAX = 900;
    static float time_refresh_min = 300;
    /*0x18*/ GarlicMemoryLogger memoryLogger;
    /*0x20*/ int fish_num;
    /*0x24*/ float time_now;
    /*0x28*/ float time_min;

    /*0x170f9a8*/ addon_gc();
    /*0x170f7d4*/ void Update();
    /*0x170f85c*/ void GC();
    /*0x170f918*/ System.Collections.IEnumerator GCCoroutine();

    class <GCCoroutine>d__8 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ addon_gc <>4__this;

        /*0x170f980*/ <GCCoroutine>d__8(int <>1__state);
        /*0x170f9b0*/ void System.IDisposable.Dispose();
        /*0x170f9b4*/ bool MoveNext();
        /*0x170fb3c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x170fb44*/ void System.Collections.IEnumerator.Reset();
        /*0x170fb84*/ object System.Collections.IEnumerator.get_Current();
    }
}

class addon_iap : UnityEngine.MonoBehaviour
{
    /*0x18*/ IGarlicIapInterface <iap_interface>k__BackingField;
    /*0x20*/ bool isInitialized;

    /*0x170ff44*/ addon_iap();
    /*0x170fb8c*/ IGarlicIapInterface get_iap_interface();
    /*0x170fb94*/ void set_iap_interface(IGarlicIapInterface value);
    /*0x170fb9c*/ void Awake();
    /*0x170fbfc*/ void Initialize();
    /*0x170fc9c*/ void Purchase(data_iap_element product);
    /*0x170fd48*/ string localizedPriceString(string name_withoutPrefix);
    /*0x170fdf4*/ decimal localizedPrice(string name_withoutPrefix);
    /*0x170fea0*/ void tryRestore();
}

class addon_iap_unity : UnityEngine.MonoBehaviour, UnityEngine.Purchasing.IStoreListener, IGarlicIapInterface
{
    /*0x18*/ UnityEngine.Purchasing.IStoreController controller;
    /*0x20*/ bool isPendingProcessDone;
    /*0x24*/ addon_iap_unity.State <state>k__BackingField;
    /*0x28*/ System.Collections.Generic.List<System.Action> ProcessPurchaseActions;
    /*0x30*/ System.Collections.IEnumerator cor;
    /*0x38*/ bool isMyPurchaseProcessing;

    /*0x1711ec8*/ addon_iap_unity();
    /*0x170ff4c*/ addon_iap_unity.State get_state();
    /*0x170ff54*/ void set_state(addon_iap_unity.State value);
    /*0x170ff5c*/ System.Collections.IEnumerator IE_Update();
    /*0x170ffec*/ void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions);
    /*0x17100a4*/ void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error);
    /*0x1710140*/ UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
    /*0x17102c0*/ void MyProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs e);
    /*0x17108a8*/ void OnPurchaseFailed(UnityEngine.Purchasing.Product i, UnityEngine.Purchasing.PurchaseFailureReason p);
    /*0x1710964*/ string localizedPriceString(string iap_item_name_withoutPrefix);
    /*0x1710ad0*/ decimal localizedPrice(string iap_item_name_withoutPrefix);
    /*0x1710c58*/ void initialize();
    /*0x1710eac*/ void Purchase(data_iap_element product);
    /*0x1711374*/ void onPurchaseSuccess(data_iap_element product);
    /*0x1711ebc*/ void onPurchaseFailed(data_iap_element product);
    /*0x1711ec0*/ void tryRestore();
    /*0x1711ec4*/ void doRestore();

    enum State
    {
        processPending = 0,
        newPurchaseReady = 1,
        newPurchasing = 2,
        newPurchaseBanned = 3,
    }

    class <IE_Update>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ addon_iap_unity <>4__this;

        /*0x170ffc4*/ <IE_Update>d__9(int <>1__state);
        /*0x1711f44*/ void System.IDisposable.Dispose();
        /*0x1711f48*/ bool MoveNext();
        /*0x1712150*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1712158*/ void System.Collections.IEnumerator.Reset();
        /*0x1712198*/ object System.Collections.IEnumerator.get_Current();
    }

    class <>c__DisplayClass12_0
    {
        /*0x10*/ addon_iap_unity <>4__this;
        /*0x18*/ UnityEngine.Purchasing.PurchaseEventArgs e;

        /*0x17102b8*/ <>c__DisplayClass12_0();
        /*0x17121a0*/ void <ProcessPurchase>b__0();
    }

    class <>c__DisplayClass14_0
    {
        /*0x10*/ addon_iap_unity <>4__this;
        /*0x18*/ data_iap_element product;
        /*0x20*/ UnityEngine.Purchasing.PurchaseEventArgs e;

        /*0x17108a0*/ <>c__DisplayClass14_0();
        /*0x17121c0*/ void <MyProcessPurchase>b__0(int response_status_code, string www_data);
    }
}

class addon_igaworks : UnityEngine.MonoBehaviour
{
    /*0x1712594*/ addon_igaworks();
}

class addon_review : UnityEngine.MonoBehaviour
{
    /*0x18*/ float time_term;
    /*0x1c*/ float time_left;
    /*0x20*/ int num_max;
    /*0x24*/ int num;
    /*0x28*/ bool isloaded;

    /*0x1712b58*/ addon_review();
    /*0x171259c*/ void Awake();
    /*0x1712690*/ void Refresh_init();
    /*0x1712734*/ void OnApplicationQuit();
    /*0x171279c*/ void OnApplicationPause();
    /*0x1712804*/ void Update();
    /*0x17128ec*/ void Show();

    class <>c
    {
        static /*0x0*/ addon_review.<> <>9;
        static /*0x8*/ System.Action <>9__10_0;

        static /*0x1712b70*/ <>c();
        /*0x1712bd4*/ <>c();
        /*0x1712bdc*/ void <Show>b__10_0();
    }
}

class addon_sendbird : UnityEngine.MonoBehaviour
{
    /*0x1712c38*/ addon_sendbird();
}

class addon_sendbird_ban
{
    /*0x10*/ string id;
    /*0x18*/ string nickname;

    /*0x1712c40*/ addon_sendbird_ban(string id, string nickname);
    /*0x1712c6c*/ addon_sendbird_ban(SimpleJSON_Ex.JSONNode json);
    /*0x1712d28*/ SimpleJSON_Ex.JSONNode get_toJson();
}

struct addon_sendbird_message
{
    /*0x10*/ string id;
    /*0x18*/ string nickname;
    /*0x20*/ string text;

    /*0x1712e00*/ addon_sendbird_message(string id, string nickname, string text);
}

class addon_sendbird_v3 : UnityEngine.MonoBehaviour
{
    static string CHANNEL_HANDLER_ID = "default";
    static string APP_ID = "821060C7-4428-4883-8F56-DF61BA5A9D3B";
    static string KOREAN = "korean_android";
    static string KOREAN_EVENT = "korean_event";
    static string GMONLY = "<GMONLY>";
    static string QNA = "#QNA";
    /*0x18*/ int list_ban_max;
    /*0x20*/ SendBird.OpenChannel <channel>k__BackingField;
    /*0x28*/ addon_sendbird_v3.State <state>k__BackingField;
    /*0x30*/ string <room>k__BackingField;
    /*0x38*/ int randomId;
    /*0x40*/ System.Collections.Generic.List<addon_sendbird_ban> list_ban;
    /*0x48*/ int <ver>k__BackingField;
    /*0x4c*/ int list_message_max;
    /*0x50*/ System.Collections.Generic.List<addon_sendbird_message> list_message;
    /*0x58*/ bool networkState_passCheck;
    /*0x5c*/ UnityEngine.NetworkReachability networkState;

    /*0x17147d8*/ addon_sendbird_v3();
    /*0x1712e0c*/ SendBird.OpenChannel get_channel();
    /*0x1712e14*/ void set_channel(SendBird.OpenChannel value);
    /*0x1712e1c*/ addon_sendbird_v3.State get_state();
    /*0x1712e24*/ void set_state(addon_sendbird_v3.State value);
    /*0x1712e2c*/ string get_room();
    /*0x1712e34*/ void set_room(string value);
    /*0x1712e3c*/ bool get_isConnected();
    /*0x1712e4c*/ bool get_isConnecting();
    /*0x1712e5c*/ string get_id();
    /*0x1712eb4*/ void Start();
    /*0x17130a4*/ void InitializeSendbird();
    /*0x17131b0*/ void OnApplicationQuit();
    /*0x1713404*/ void OnApplicationPause(bool isPaused);
    /*0x1712ee8*/ void Load();
    /*0x17131c8*/ void Save();
    /*0x1713410*/ void Connect(System.Action OnConnected, System.Action<string> OnConnectionError);
    /*0x17132d8*/ void Disconnect();
    /*0x17135e8*/ void EnterChannel(string room, string channel);
    /*0x17137e4*/ void OnConnectChannel(SendBird.OpenChannel channel, string room);
    /*0x171393c*/ void Send(string message);
    /*0x1713bb8*/ void OnMessageRecieved(SendBird.BaseChannel channel, SendBird.BaseMessage message);
    /*0x1713d14*/ void OnUserMessageReceived(SendBird.UserMessage message);
    /*0x1714014*/ void OnAdminMessageReceived(SendBird.AdminMessage adminMessage);
    /*0x17143a0*/ int get_ver();
    /*0x17143a8*/ void set_ver(int value);
    /*0x1713584*/ void Add_Text(string text);
    /*0x171426c*/ void Add_Text(string text, string id, string nickname);
    /*0x1713148*/ System.Collections.IEnumerator checkNetworkConnection();
    /*0x17143d8*/ void Add_Ban(string id, string nickname);
    /*0x1714590*/ void Remove_Ban(string id);
    /*0x17140b0*/ bool Has_Ban(string id);
    /*0x17148a0*/ void <Disconnect>b__35_0();
    /*0x17148e8*/ void <Send>b__38_0(SendBird.UserMessage userMessage, SendBird.SendBirdException exception);
    /*0x1714980*/ void <Send>b__38_1(SendBird.UserMessage userMessage, SendBird.SendBirdException exception);

    enum State
    {
        Disconnected = 0,
        Connecting = 1,
        Connected = 2,
    }

    class <>c__DisplayClass34_0
    {
        /*0x10*/ addon_sendbird_v3 <>4__this;
        /*0x18*/ System.Action<string> OnConnectionError;
        /*0x20*/ System.Action OnConnected;
        /*0x28*/ SendBird.SendBirdClient.UserInfoUpdateHandler <>9__1;

        /*0x171357c*/ <>c__DisplayClass34_0();
        /*0x1714a18*/ void <Connect>b__0(SendBird.User user, SendBird.SendBirdException connectionError);
        /*0x1714b8c*/ void <Connect>b__1(SendBird.SendBirdException userInfoError);
    }

    class <>c__DisplayClass36_0
    {
        /*0x10*/ addon_sendbird_v3 <>4__this;
        /*0x18*/ string room;
        /*0x20*/ SendBird.SendBirdClient.ChannelHandler.OnChannelDeletedDelegate <>9__2;

        /*0x17137a8*/ <>c__DisplayClass36_0();
        /*0x1714c70*/ void <EnterChannel>b__0(SendBird.OpenChannel openChannel, SendBird.SendBirdException getChannelException);
        /*0x1714d90*/ void <EnterChannel>b__2(string url, SendBird.BaseChannel.ChannelType type);
    }

    class <>c__DisplayClass36_1
    {
        /*0x10*/ SendBird.OpenChannel openChannel;
        /*0x18*/ addon_sendbird_v3.<> CS$<>8__locals1;

        /*0x1714d88*/ <>c__DisplayClass36_1();
        /*0x1714da8*/ void <EnterChannel>b__1(SendBird.SendBirdException enterChannelException);
    }

    class <checkNetworkConnection>d__52 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ addon_sendbird_v3 <>4__this;

        /*0x17143b0*/ <checkNetworkConnection>d__52(int <>1__state);
        /*0x1714ffc*/ void System.IDisposable.Dispose();
        /*0x1715000*/ bool MoveNext();
        /*0x17150e4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x17150ec*/ void System.Collections.IEnumerator.Reset();
        /*0x171512c*/ object System.Collections.IEnumerator.get_Current();
    }
}

class addon_setting : UnityEngine.MonoBehaviour
{
    static string PRF_KEY = "addon_setting";
    static /*0x0*/ SimpleJSON_Ex.JSONNode _json;
    /*0x18*/ UnityEngine.Rect default_resolution;
    /*0x28*/ bool isLoaded;

    static /*0x1715134*/ SimpleJSON_Ex.JSONNode get_json();
    static /*0x17154bc*/ stringFormat.lang_type get_language();
    static /*0x17155b0*/ void set_language(stringFormat.lang_type value);
    static /*0x170e02c*/ string get_lang_type_string();
    /*0x17169a4*/ addon_setting();
    /*0x1715244*/ string get_GUID_ID();
    /*0x17152f4*/ void Awake();
    /*0x17153f4*/ void Start();
    /*0x1716380*/ void Refresh_UI();
    /*0x17163f0*/ void OnApplicationQuit();
    /*0x1716464*/ void OnApplicationPause();
    /*0x1716474*/ void Set_Language(int lang);
    /*0x1715cf8*/ anim_water.Quality get_water();
    /*0x1715d98*/ void set_water(anim_water.Quality value);
    /*0x171656c*/ void Set_Water(int water);
    /*0x1715674*/ int get_resolution();
    /*0x1715708*/ void set_resolution(int value);
    /*0x1715884*/ int get_fps();
    /*0x1715934*/ void set_fps(int value);
    /*0x1716570*/ bool get_item_effect();
    /*0x1716604*/ void set_item_effect(bool value);
    /*0x1716674*/ bool get_skill_effect();
    /*0x1716708*/ void set_skill_effect(bool value);
    /*0x17159c8*/ bool get_vibrate();
    /*0x1715a5c*/ void set_vibrate(bool value);
    /*0x1715acc*/ bool get_mute();
    /*0x1715b60*/ void set_mute(bool value);
    /*0x1716778*/ bool get_autosave();
    /*0x171680c*/ void set_autosave(bool value);
    /*0x171687c*/ bool get_fast_upgrade();
    /*0x1716910*/ void set_fast_upgrade(bool value);
    /*0x1715be8*/ int get_tip();
    /*0x1715c7c*/ void set_tip(int value);
    /*0x1715e3c*/ addon_setting.PopupType get_popup();
    /*0x1715f64*/ void set_popup(addon_setting.PopupType value);
    /*0x1716980*/ void Set_Popup(int no);
    /*0x1715fd4*/ bool get_damage();
    /*0x1716068*/ void set_damage(bool value);
    /*0x17160d8*/ bool get_sound_sonar();
    /*0x171616c*/ void set_sound_sonar(bool value);
    /*0x17161dc*/ float Get_volume(sound.group_type type);
    /*0x17162a8*/ void Set_volume(sound.group_type type, float volume);
    /*0x1716984*/ void Vibrate_Play();
    /*0x1716400*/ void Save();

    enum PopupType
    {
        off = 0,
        all = 1,
        half = 2,
    }
}

class addon_social : UnityEngine.MonoBehaviour
{
    /*0x18*/ int _nickname_china_num;
    /*0x1c*/ bool isSaving;

    /*0x1718400*/ addon_social();
    /*0x17169ac*/ void Initialize();
    /*0x171136c*/ void SignIn();
    /*0x1716a58*/ void SignInWithAction(System.Action<bool> action);
    /*0x1716b68*/ void SignOut();
    /*0x171134c*/ bool get_isConnected();
    /*0x170c180*/ string get_id();
    /*0x1716b88*/ string get_iOSTeamPlayerId();
    /*0x17137b0*/ string get_nickname();
    /*0x1716bd8*/ void Achievement_ui();
    /*0x1716c6c*/ void Achievement_progress(string code, double progress);
    /*0x1716dc0*/ void Achievement_progress(string code_gpgs, string code_gc, double progress);
    /*0x1716dc4*/ void Achievement_progress_fishes();
    /*0x1716f34*/ void Leaderboard_ui();
    /*0x1716fc8*/ void Leaderboard_score(string code, long score);
    /*0x171710c*/ void Leaderboard_score(string code_gpgs, string code_gc, long score);
    /*0x1717114*/ void Leaderboard_score_Lv();
    /*0x17171e8*/ void Leaderboard_score_Playtime();
    /*0x17172d4*/ void Leaderboard_score_bestFish();
    /*0x171739c*/ void Savedgames_ui();
    /*0x1717510*/ void SavedGameSelected(GooglePlayGames.BasicApi.SavedGame.SelectUIStatus _status, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata _game);
    /*0x1717880*/ void SavedGameOpened(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus _status, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata _game);
    /*0x1717fc0*/ void SavedGameLoaded(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus _status, byte[] _data);
    /*0x1718258*/ void SavedGameWritten(GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus _status, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata _game);
    /*0x1718408*/ void <SignInWithAction>b__2_0(bool success);
    /*0x17185a0*/ void <Achievement_ui>b__13_0(bool success);
    /*0x17185bc*/ void <Leaderboard_ui>b__17_0(bool success);
    /*0x17185ec*/ void <Savedgames_ui>b__24_0();

    class <>c__DisplayClass14_0
    {
        /*0x10*/ string code;
        /*0x18*/ double progress;

        /*0x1716db8*/ <>c__DisplayClass14_0();
        /*0x1718760*/ void <Achievement_progress>b__0(bool success);
    }

    class <>c
    {
        static /*0x0*/ addon_social.<> <>9;
        static /*0x8*/ System.Action<bool> <>9__14_1;
        static /*0x10*/ System.Action<bool> <>9__18_1;

        static /*0x1718874*/ <>c();
        /*0x17188d8*/ <>c();
        /*0x17188e0*/ void <Achievement_progress>b__14_1(bool success2);
        /*0x17188e4*/ void <Leaderboard_score>b__18_1(bool success2);
    }

    class <>c__DisplayClass18_0
    {
        /*0x10*/ long score;
        /*0x18*/ string code;

        /*0x1717104*/ <>c__DisplayClass18_0();
        /*0x17188e8*/ void <Leaderboard_score>b__0(bool success);
    }

    class <>c__DisplayClass27_0
    {
        /*0x10*/ string data;

        /*0x1718250*/ <>c__DisplayClass27_0();
        /*0x17189ec*/ void <SavedGameLoaded>b__0();
    }
}

class addon_tapjoy : UnityEngine.MonoBehaviour
{
    /*0x1718a48*/ addon_tapjoy();
}

class addon_unity_analytics : UnityEngine.MonoBehaviour
{
    /*0x1718c34*/ addon_unity_analytics();
    /*0x1718a50*/ void LogRank(int rank_achieved);
}

class addon_url : UnityEngine.MonoBehaviour
{
    /*0x1718cf4*/ addon_url();
    /*0x1718c3c*/ void Open(string url);
    /*0x1718c48*/ void Open(string url_android, string url_ios);
    /*0x1718c54*/ void Open_Daeri();
    /*0x1718ca4*/ void Open_Market();
}

class addon_www : UnityEngine.MonoBehaviour
{
    static float COOLTIME = 60;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool <isConnected>k__BackingField;
    /*0x28*/ System.DateTime <time>k__BackingField;
    /*0x30*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat <version>k__BackingField;
    /*0x48*/ addon_www.UpdateState <updateState>k__BackingField;
    /*0x50*/ System.Collections.Generic.List<data_events_element> events;
    /*0x58*/ bool updateCanceled;
    /*0x60*/ string url_lastSuccess;
    /*0x68*/ float cooltime;

    /*0x17193bc*/ addon_www();
    /*0x1718cfc*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_isConnected();
    /*0x1718d0c*/ void set_isConnected(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value);
    /*0x1718d18*/ System.DateTime get_time();
    /*0x1718d20*/ void set_time(System.DateTime value);
    /*0x1718d28*/ int get_time_in_seconds();
    /*0x1718da4*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat get_version();
    /*0x1718db8*/ void set_version(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat value);
    /*0x1718dcc*/ addon_www.UpdateState get_updateState();
    /*0x1718dd4*/ void set_updateState(addon_www.UpdateState value);
    /*0x1718ddc*/ int get_date();
    /*0x1711da4*/ data_events_element get_events_skin();
    /*0x1718e54*/ data_quest_element get_events_quest();
    /*0x1719028*/ string get_url();
    /*0x1719100*/ string get_url2();
    /*0x17191d8*/ void Connect(bool alert, bool refresh);
    /*0x171920c*/ System.Collections.IEnumerator IE_Connect(bool alert, bool refresh);
    /*0x17192bc*/ void Update();
    /*0x1719358*/ System.DateTime UnixTimeStampToDateTime(double unixTimeStamp);
    /*0x1719438*/ void <IE_Connect>b__33_0();
    /*0x171961c*/ void <IE_Connect>b__33_1();

    enum UpdateState
    {
        none = 0,
        soft = 1,
        hard = 2,
    }

    class <>c
    {
        static /*0x0*/ addon_www.<> <>9;
        static /*0x8*/ System.Func<data_events_element, bool> <>9__23_0;
        static /*0x10*/ System.Func<data_events_element, bool> <>9__25_0;
        static /*0x18*/ System.Func<data_events_element, data_quest_element> <>9__25_1;
        static /*0x20*/ System.Action <>9__33_2;

        static /*0x17196d8*/ <>c();
        /*0x171973c*/ <>c();
        /*0x1719744*/ bool <get_events_skin>b__23_0(data_events_element events);
        /*0x17197ac*/ bool <get_events_quest>b__25_0(data_events_element events);
        /*0x1719814*/ data_quest_element <get_events_quest>b__25_1(data_events_element events);
        /*0x171982c*/ void <IE_Connect>b__33_2();
    }

    class <IE_Connect>d__33 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ addon_www <>4__this;
        /*0x28*/ bool alert;
        /*0x29*/ bool refresh;
        /*0x30*/ UnityEngine.WWW <www>5__2;
        /*0x38*/ string <url_now>5__3;
        /*0x40*/ bool <isConnected_before>5__4;

        /*0x1719294*/ <IE_Connect>d__33(int <>1__state);
        /*0x1719884*/ void System.IDisposable.Dispose();
        /*0x1719888*/ bool MoveNext();
        /*0x1719f20*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1719f28*/ void System.Collections.IEnumerator.Reset();
        /*0x1719f68*/ object System.Collections.IEnumerator.get_Current();
    }
}

interface IGarlicIapInterface
{
    void initialize();
    void Purchase(data_iap_element product);
    void onPurchaseSuccess(data_iap_element product);
    void onPurchaseFailed(data_iap_element product);
    void tryRestore();
    string localizedPriceString(string iap_item_name_withoutPrefix);
    decimal localizedPrice(string iap_item_name_withoutPrefix);
}

interface IGarlicInterstitialAdInterface
{
    bool get_IsAdReady();
    void Initialize();
    bool Show(System.Action OnShowSuccess, System.Action OnShowSkipped, System.Action OnShowFailed);
}

class anim : UnityEngine.MonoBehaviour
{
    static /*0x0*/ anim ins;
    /*0x18*/ anim_ambient _ambient;
    /*0x20*/ anim_character character;
    /*0x28*/ anim_fish fish;
    /*0x30*/ anim_turret[] turret;
    /*0x38*/ anim_ship ship;
    /*0x40*/ anim_inven inven;
    /*0x48*/ anim_skill skill;
    /*0x50*/ anim_place place;
    /*0x58*/ anim_particle particle;
    /*0x60*/ anim_water water;
    /*0x68*/ anim_pet pet;

    /*0x171a0c4*/ anim();
    /*0x1719f70*/ void Awake();
    /*0x171a030*/ anim_ambient get_ambient();
}

class anim_ambient : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Animator myAnim;
    /*0x20*/ float time_day;
    /*0x24*/ UnityEngine.Rect rect_foggy;
    /*0x34*/ UnityEngine.Rect rect_cold;
    /*0x44*/ UnityEngine.Rect rect_dark;
    /*0x54*/ UnityEngine.Rect rect_endplace;
    /*0x68*/ UnityEngine.ParticleSystem particle_coldfog;
    /*0x70*/ UnityEngine.ParticleSystem particle_dark;
    /*0x78*/ UnityEngine.ParticleSystem particle_snow;
    /*0x80*/ anim_ambient.LockState <lockState>k__BackingField;

    /*0x171b010*/ anim_ambient();
    /*0x171a0cc*/ void Awake();
    /*0x171a1dc*/ void State_Normal();
    /*0x171a314*/ void State_Legend();
    /*0x171a44c*/ void State_Foggy();
    /*0x171a584*/ void State_Cold();
    /*0x171a6bc*/ void State_Dark();
    /*0x171a7f4*/ void State_Dimension();
    /*0x171a92c*/ void State_Snow();
    /*0x171aa64*/ void Refresh_Sec();
    /*0x171aea4*/ anim_ambient.LockState get_lockState();
    /*0x171aeac*/ void set_lockState(anim_ambient.LockState value);
    /*0x171aeb4*/ void Set_LockState(anim_ambient.LockState lockState, float time);
    /*0x171afe8*/ void Unset_LockState();

    enum LockState
    {
        off = 0,
        normal = 1,
        legend = 2,
        foggy = 3,
        cold = 4,
        dark = 5,
        dimension = 6,
        snow = 7,
    }
}

class anim_ambient_manualChanger : UnityEngine.MonoBehaviour
{
    /*0x18*/ anim_ambient animAmbient;
    /*0x20*/ anim_ambient.LockState state;
    /*0x24*/ float time;

    /*0x171b044*/ anim_ambient_manualChanger();
    /*0x171b020*/ void Update();
}

class anim_character : UnityEngine.MonoBehaviour
{
    /*0x18*/ bool isFront;
    /*0x1c*/ UnityEngine.Vector3 euler_right;
    /*0x28*/ UnityEngine.Vector3 euler_left;
    /*0x38*/ UnityEngine.Animator animator;
    /*0x40*/ float offset_target_x;
    /*0x44*/ UnityEngine.Vector3 offset;
    /*0x50*/ float roam_speed;
    /*0x58*/ System.Collections.IEnumerator cor_roam;
    /*0x60*/ data_skin_element skin_rod;
    /*0x68*/ data_skin_element skin_hat;
    /*0x70*/ data_skin_element skin_hair;
    /*0x78*/ data_skin_element skin_body;
    /*0x80*/ UnityEngine.SkinnedMeshRenderer rod_front;
    /*0x88*/ UnityEngine.SkinnedMeshRenderer rod_back;
    /*0x90*/ UnityEngine.SkinnedMeshRenderer body_front;
    /*0x98*/ UnityEngine.SkinnedMeshRenderer body_back;
    /*0xa0*/ UnityEngine.Transform hat_parent;
    /*0xa8*/ UnityEngine.GameObject hat_object;
    /*0xb0*/ prefab_hat hat_prefab;
    /*0xb8*/ UnityEngine.LineRenderer rod_line;
    /*0xc0*/ UnityEngine.Transform rod_position;
    /*0xc8*/ UnityEngine.Vector3 rod_pos_base;
    /*0xd8*/ System.Collections.ArrayList _rod_states;
    /*0xe0*/ UnityEngine.ParticleSystem particle_lvUp;

    /*0x171c00c*/ anim_character();
    /*0x171b04c*/ void Awake();
    /*0x171b1b4*/ void LateUpdate();
    /*0x171b3cc*/ void Set_Side(bool isFront);
    /*0x171b478*/ void LookAt(UnityEngine.Vector3 target);
    /*0x171b47c*/ void LookAt(float target);
    /*0x171b4e4*/ void Anim_Play(anim_character.state animation);
    /*0x171b63c*/ float get_Anim_Length();
    /*0x171b684*/ void Anim_Set_tps(float num);
    /*0x171b6e8*/ void Anim_Set_charge(float num);
    /*0x171b74c*/ void Refresh_Init();
    /*0x171b5d4*/ System.Collections.IEnumerator IE_idle_roam();
    /*0x171b77c*/ void Refresh_Skin();
    /*0x171bdc4*/ System.Collections.ArrayList get_rod_states();
    /*0x171bf48*/ void Refresh_UI();

    enum state
    {
        sleep = 0,
        sleep_to_idle = 1,
        idle = 2,
        charge = 3,
        shot = 4,
        found = 5,
        initiate_success = 6,
        initiate_fail = 7,
        fight = 8,
        fight_success = 9,
        fight_fail = 10,
        done_success = 11,
        done_fail = 12,
        wait_to_idle = 13,
    }

    class <IE_idle_roam>d__20 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ anim_character <>4__this;
        /*0x28*/ int <dir>5__2;

        /*0x171b754*/ <IE_idle_roam>d__20(int <>1__state);
        /*0x171c088*/ void System.IDisposable.Dispose();
        /*0x171c08c*/ bool MoveNext();
        /*0x171c23c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x171c244*/ void System.Collections.IEnumerator.Reset();
        /*0x171c284*/ object System.Collections.IEnumerator.get_Current();
    }
}

class anim_character_body : UnityEngine.MonoBehaviour
{
    /*0x18*/ anim_character my_Anim;

    /*0x171c394*/ anim_character_body();
    /*0x171c28c*/ void OnEnable();
    /*0x171c310*/ void OnDisable();
}

class anim_character_skillEffect : UnityEngine.MonoBehaviour
{
    /*0x18*/ data_skill_element skill;
    /*0x20*/ UnityEngine.GameObject particle;

    /*0x171c4d0*/ anim_character_skillEffect();
    /*0x171c39c*/ void Update();
}

class anim_cloud : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject[] prefabs;
    /*0x20*/ System.Collections.Generic.List<UnityEngine.Material> materials;
    /*0x28*/ UnityEngine.Transform pos_start;
    /*0x30*/ UnityEngine.Transform pos_end;
    /*0x38*/ float term_min;
    /*0x3c*/ float term_max;
    /*0x40*/ float speed;
    /*0x44*/ UnityEngine.Color color;
    /*0x54*/ float time;
    /*0x58*/ int type_last;
    /*0x60*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.Queue<UnityEngine.GameObject>> pool;

    /*0x171ccc0*/ anim_cloud();
    /*0x171c4d8*/ float get_speed_mult();
    /*0x171c570*/ System.Collections.Generic.KeyValuePair<int, UnityEngine.GameObject> Add_Cloud();
    /*0x171c824*/ void Remove_Cloud(System.Collections.Generic.KeyValuePair<int, UnityEngine.GameObject> cloud);
    /*0x171c8d8*/ void Start();
    /*0x171cb38*/ void Update();
    /*0x171cac0*/ System.Collections.IEnumerator IE_Play(float x);

    class <IE_Play>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ anim_cloud <>4__this;
        /*0x28*/ float x;
        /*0x30*/ System.Collections.Generic.KeyValuePair<int, UnityEngine.GameObject> <cloud>5__2;

        /*0x171cc98*/ <IE_Play>d__17(int <>1__state);
        /*0x171cd44*/ void System.IDisposable.Dispose();
        /*0x171cd48*/ bool MoveNext();
        /*0x171cfc8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x171cfd0*/ void System.Collections.IEnumerator.Reset();
        /*0x171d010*/ object System.Collections.IEnumerator.get_Current();
    }
}

class anim_fish : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject obj;
    /*0x20*/ UnityEngine.Animator animator;
    /*0x28*/ data_fish_element fish;
    /*0x30*/ prefab_fish <prefab>k__BackingField;
    /*0x38*/ UnityEngine.ParticleSystem particle_water_cam;
    /*0x40*/ UnityEngine.ParticleSystem particle_water_small;
    /*0x48*/ UnityEngine.ParticleSystem particle_water_big;

    /*0x171d4a0*/ anim_fish();
    /*0x171d018*/ void Awake();
    /*0x171d0d0*/ void Refresh_Init();
    /*0x171d250*/ prefab_fish get_prefab();
    /*0x171d258*/ void set_prefab(prefab_fish value);
    /*0x171d188*/ void Anim_Play(anim_fish.state trigger);
    /*0x171d260*/ void Anim_Touch();
    /*0x171d2fc*/ float get_Anim_Length();
    /*0x171d344*/ void Set_Fish(data_fish_element fish);
    /*0x171d0ec*/ void UnSet_Fish();
    /*0x171d43c*/ void Play_Particle_Water(bool active);

    enum state
    {
        idle = 0,
        initiate_fight = 1,
        fight = 2,
        fight_success = 3,
        fight_fail = 4,
        auto_fail = 5,
        auto_success = 6,
    }
}

class anim_inven : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject myObj;
    /*0x20*/ data_skin_element mySkin;

    /*0x171d87c*/ anim_inven();
    /*0x171d4a8*/ void Awake();
    /*0x171d560*/ void LateUpdate();
    /*0x171d640*/ void Refresh_Skin();
}

class anim_particle : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<UnityEngine.GameObject> prefabs;
    /*0x20*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.ParticleSystem>> dic;

    /*0x171de7c*/ anim_particle();
    /*0x171d884*/ void Play(UnityEngine.Vector3 position, string name);
    /*0x171d9e8*/ void Play(UnityEngine.Vector3 position, int index);

    class <>c__DisplayClass2_0
    {
        /*0x10*/ string name;

        /*0x171d9e0*/ <>c__DisplayClass2_0();
        /*0x171def8*/ bool <Play>b__0(UnityEngine.GameObject pair);
    }
}

class anim_pet : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject obj;
    /*0x20*/ UnityEngine.Animator animator;
    /*0x28*/ UnityEngine.ParticleSystem particle_lvUp;
    /*0x30*/ UnityEngine.Renderer[] _skinedRenderers;
    /*0x38*/ bool isActive;
    /*0x3c*/ UnityEngine.Vector3 offset_pet;
    /*0x48*/ float offset_target_x;
    /*0x4c*/ UnityEngine.Vector3 offset;
    /*0x58*/ float roam_speed;
    /*0x5c*/ UnityEngine.Vector3 euler_right;
    /*0x68*/ UnityEngine.Vector3 euler_left;
    /*0x78*/ data_skin_element skin;
    /*0x80*/ float time_roam;

    /*0x171e9b0*/ anim_pet();
    /*0x171df24*/ UnityEngine.Renderer[] get_skinedRenderers();
    /*0x171df80*/ bool get_sleeping();
    /*0x171dfec*/ void set_sleeping(bool value);
    /*0x171e05c*/ bool get_walking();
    /*0x171e0c8*/ void set_walking(bool value);
    /*0x171e138*/ bool get_fighting();
    /*0x171e1a4*/ void set_fighting(bool value);
    /*0x171e214*/ void fighting_success();
    /*0x171e280*/ void fighting_fail();
    /*0x171e2ec*/ void Upgrade();
    /*0x171e308*/ void Awake();
    /*0x171e3c0*/ void Refresh_Skin();
    /*0x171e578*/ void Update();
    /*0x171e6e4*/ void LookAt(float target);
    /*0x171e74c*/ void LateUpdate();
    /*0x171e8a0*/ void ResetAndSleep();
}

class anim_place : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject obj_place;
    /*0x20*/ data_place_element place_now;
    /*0x28*/ UnityEngine.Vector3 pos_target;
    /*0x34*/ UnityEngine.Vector3 pos_start;
    /*0x40*/ UnityEngine.Vector3 pos_center;
    /*0x4c*/ UnityEngine.Vector3 pos_end;
    /*0x58*/ float speed_move;
    /*0x5c*/ float speed_scale;

    /*0x171f4ec*/ anim_place();
    /*0x171ea34*/ bool get_arrived();
    /*0x171eb90*/ void Awake();
    /*0x171ec48*/ void Start();
    /*0x171ece8*/ void Update();
    /*0x171ed00*/ void Update_Main();
    /*0x171f3c8*/ void Update_Pos();
    /*0x171ec4c*/ void Reset();
}

class anim_ship : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject myObj;
    /*0x20*/ data_skin_element mySkin;
    /*0x28*/ UnityEngine.Animator myObj_animator;
    /*0x30*/ prefab_ship <myObj_prefab>k__BackingField;

    /*0x171f99c*/ anim_ship();
    /*0x171f4f4*/ prefab_ship get_myObj_prefab();
    /*0x171f4fc*/ void set_myObj_prefab(prefab_ship value);
    /*0x171f504*/ void Anim_Move();
    /*0x171f594*/ void Awake();
    /*0x171f6fc*/ void Refresh_Initiate();
    /*0x171f700*/ void Refresh_Place();
    /*0x171f704*/ void Refresh_Skin();
}

class anim_skill : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.ParticleSystem particle_skill;
    /*0x20*/ UnityEngine.GameObject myObj;
    /*0x28*/ data_skin_element mySkin;
    /*0x30*/ UnityEngine.Transform pos_light;

    /*0x171fe78*/ anim_skill();
    /*0x171f9a4*/ void LateUpdate();
    /*0x171faf8*/ void Awake();
    /*0x171fbb0*/ void Refresh_Skin();
}

class anim_turret : UnityEngine.MonoBehaviour
{
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt no;
    /*0x28*/ data_skin.Type type;
    /*0x30*/ prefab_turret prefab;
    /*0x38*/ data_skin_element skin;

    /*0x1720434*/ anim_turret();
    /*0x171fe80*/ void Awake();
    /*0x171ff38*/ void Refresh_Skin();
    /*0x172025c*/ void Anim_Play(anim_turret.State state);
    /*0x17202f4*/ void LateUpdate();

    enum State
    {
        attack = 0,
        upgrade = 1,
    }
}

class anim_turret_projectile : UnityEngine.MonoBehaviour
{
    /*0x18*/ Projectile projectile;

    /*0x17204b0*/ anim_turret_projectile();
    /*0x172043c*/ void Shot();
}

class anim_water : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<UnityEngine.Transform> waters;
    /*0x20*/ int waters_cnt;
    /*0x24*/ float speed;
    /*0x28*/ float water_offset;
    /*0x30*/ UnityEngine.Material mat_low;
    /*0x38*/ UnityEngine.Material mat_high;
    /*0x40*/ System.Collections.Generic.List<UnityEngine.SkinnedMeshRenderer> waters_renderer;

    /*0x1720a30*/ anim_water();
    /*0x17204b8*/ void Awake();
    /*0x1720508*/ void Reset();
    /*0x172063c*/ void Update();
    /*0x171647c*/ void Set_Quality(anim_water.Quality quality);

    enum Quality
    {
        high = 0,
        low = 1,
    }

    class <>c
    {
        static /*0x0*/ anim_water.<> <>9;
        static /*0x8*/ System.Func<UnityEngine.Transform, float> <>9__10_0;
        static /*0x10*/ System.Func<UnityEngine.Transform, UnityEngine.Vector3> <>9__10_1;

        static /*0x1720a38*/ <>c();
        /*0x1720a9c*/ <>c();
        /*0x1720aa4*/ float <Update>b__10_0(UnityEngine.Transform water);
        /*0x1720abc*/ UnityEngine.Vector3 <Update>b__10_1(UnityEngine.Transform water);
    }
}

class BlockOnClickInTesterMode : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler
{
    /*0x18*/ UnityEngine.UI.Button button;

    /*0x1720c6c*/ BlockOnClickInTesterMode();
    /*0x1720ad4*/ void Start();
    /*0x1720bf4*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
}

class cam : UnityEngine.MonoBehaviour
{
    static /*0x0*/ cam ins;
    /*0x18*/ UnityEngine.GameObject main;
    /*0x20*/ UnityEngine.GameObject mainUI;
    /*0x28*/ UnityEngine.GameObject globalUI;
    /*0x30*/ UnityEngine.GameObject ScreenSaver;
    /*0x38*/ UnityEngine.GameObject effectUI;
    /*0x40*/ UnityEngine.UI.GraphicRaycaster ray_main;
    /*0x48*/ UnityEngine.UI.GraphicRaycaster ray_map;
    /*0x50*/ UnityEngine.UI.GraphicRaycaster ray_global;
    /*0x58*/ cam_game game;
    /*0x60*/ cam_map map;
    /*0x68*/ UnityEngine.GameObject map_place_icon_holder;
    /*0x70*/ cam.mode mode_now;
    /*0x78*/ UnityEngine.Coroutine map_icon_activator_coroutine;
    /*0x80*/ UnityEngine.Camera[] _Cams;

    /*0x1721fb8*/ cam();
    /*0x1720c74*/ void Awake();
    /*0x1721450*/ void Set_Mod(int no);
    /*0x1721454*/ void Set_Mod(string st);
    /*0x1721554*/ void Set_Mod();
    /*0x1720d34*/ void Set_Mod(cam.mode mode_target);
    /*0x1721898*/ void Activate_Map_Icons();
    /*0x17218c8*/ System.Collections.IEnumerator cor_map_icon_activator();
    /*0x1721930*/ System.Collections.Generic.List<UnityEngine.GameObject> sort_place_icons_by_distance();
    /*0x1721564*/ void Deactivate_Map_Icons();
    /*0x1721da4*/ UnityEngine.Camera[] get_Cams();
    /*0x1721e00*/ void Set_Admob(bool isAcitve);
    /*0x1721f8c*/ float dpToPx(int dp);

    enum mode
    {
        main = 0,
        map = 1,
        preview = 2,
        cutscene = 3,
        screensaver_uiOnly = 4,
        screensaver_hideAll = 5,
    }

    class <cor_map_icon_activator>d__21 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ cam <>4__this;
        /*0x28*/ System.Collections.Generic.List<UnityEngine.GameObject> <place_icons>5__2;
        /*0x30*/ int <load_at_once_count>5__3;
        /*0x34*/ int <iterate_count>5__4;
        /*0x38*/ int <i>5__5;

        /*0x1877ae0*/ <cor_map_icon_activator>d__21(int <>1__state);
        /*0x1877b08*/ void System.IDisposable.Dispose();
        /*0x1877b0c*/ bool MoveNext();
        /*0x1877cf0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1877cf8*/ void System.Collections.IEnumerator.Reset();
        /*0x1877d38*/ object System.Collections.IEnumerator.get_Current();
    }

    class <>c
    {
        static /*0x0*/ cam.<> <>9;
        static /*0x8*/ System.Func<UnityEngine.GameObject, float> <>9__22_0;

        static /*0x1877d40*/ <>c();
        /*0x1877da4*/ <>c();
        /*0x1877dac*/ float <sort_place_icons_by_distance>b__22_0(UnityEngine.GameObject go);
    }
}

class cam_game : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Transform[] pos_cam;
    /*0x20*/ UnityEngine.Transform pos_start;
    /*0x28*/ UnityEngine.Transform pos_idle;
    /*0x30*/ UnityEngine.Transform pos_fight_normal;
    /*0x38*/ UnityEngine.Transform pos_fight_boss;
    /*0x40*/ UnityEngine.Transform pos_fight_legend;
    /*0x48*/ UnityEngine.Transform pos_target;
    /*0x50*/ bool pausePosLerp;

    /*0x187821c*/ cam_game();
    /*0x1877ef8*/ void Awake();
    /*0x1877fd0*/ void Update();
    /*0x1877f00*/ void Set_Pos(UnityEngine.Transform pos_target);
    /*0x1878194*/ void pausePositionLerp();
    /*0x18781a0*/ void restartPositionLerp();
    /*0x18781a8*/ void Set_State(cam_game.State state);

    enum State
    {
        start = 0,
        idle = 1,
        fight_normal = 2,
        fight_boss = 3,
        fight_legend = 4,
    }
}

class cam_map : UnityEngine.MonoBehaviour
{
    /*0x18*/ float move_speed;
    /*0x1c*/ float move_margin;
    /*0x20*/ UnityEngine.RectTransform rect_parent;
    /*0x28*/ map_background[] _rects;
    /*0x30*/ UnityEngine.Vector3 cam_targetPos;
    /*0x3c*/ float move_min;
    /*0x40*/ float move_max;
    /*0x44*/ UnityEngine.Vector3 pos_origin;

    /*0x18789d0*/ cam_map();
    /*0x1878224*/ map_background[] get_rects();
    /*0x1878288*/ void Awake();
    /*0x18782a4*/ void OnEnable();
    /*0x18785d0*/ void OnDisable();
    /*0x1878454*/ void Refresh_UI();
    /*0x1878688*/ void Update();
    /*0x1878884*/ void Touch_Move();
    /*0x18787c8*/ void Mouse_Move();
    /*0x18785b4*/ void Set_Target(float x);
    /*0x18789a8*/ bool get_isMin();
    /*0x18789bc*/ bool get_isMax();
}

class cam_screensaver : UnityEngine.MonoBehaviour
{
    /*0x1878a30*/ cam_screensaver();
    /*0x18789d8*/ void OnClick();
}

class cam_touchEffect : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject prefab;
    /*0x20*/ System.Collections.Generic.List<UnityEngine.ParticleSystem> particles;
    /*0x28*/ UnityEngine.Camera _myCam;

    /*0x1878f44*/ cam_touchEffect();
    /*0x1878a38*/ UnityEngine.Camera get_myCam();
    /*0x1878acc*/ void Update();
    /*0x1878c30*/ void Play(UnityEngine.Vector3 position);
}

class cam_wideshot : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Camera[] cams_toHide;
    /*0x20*/ bool now;

    /*0x187904c*/ cam_wideshot();
    /*0x1878fc0*/ void Update();
}

class data : UnityEngine.MonoBehaviour
{
    static /*0x0*/ data ins;
    /*0x18*/ data_place place;
    /*0x20*/ data_fish fish;
    /*0x28*/ data_item item;
    /*0x30*/ data_skin skin;
    /*0x38*/ data_skill skill;
    /*0x40*/ data_currency currecny;
    /*0x48*/ data_record record;
    /*0x50*/ data_sprite sprite;
    /*0x58*/ data_tutorial tutorial;
    /*0x60*/ data_mastery mastery;
    /*0x68*/ data_quest quest;
    /*0x70*/ data_npc npc;
    /*0x78*/ data_hidden hidden;
    /*0x80*/ data_craft craft;
    /*0x88*/ data_farm farm;
    /*0x90*/ data_iap iap;
    /*0x98*/ data_cutscene cutscene;
    /*0xa0*/ data_events events;
    /*0xa8*/ data_relic relic;
    /*0xb0*/ data_enhance enhance;
    /*0xb8*/ data_setting setting;
    /*0xc0*/ data_rank_unlock_info_holder rank_unlock_info;

    /*0x187b798*/ data();
    /*0x1879054*/ void Awake();
}

class data_craft
{
    /*0x10*/ System.Collections.Generic.List<data_craft_element> elements;

    /*0x187bbf4*/ data_craft();
    /*0x187afb8*/ void LoadAll();
    /*0x187beac*/ data_craft_element Get_element(string name, bool withPrefix);
    /*0x187bf1c*/ data_craft_element Get_element(string name);

    class <>c__DisplayClass3_0
    {
        /*0x10*/ string name;

        /*0x187c010*/ <>c__DisplayClass3_0();
        /*0x187c018*/ bool <Get_element>b__0(data_craft_element l);
    }
}

class data_craft_element : UnityEngine.ScriptableObject
{
    /*0x18*/ System.Collections.Generic.List<ItemNumPair_List> needs;

    /*0x187c1a8*/ data_craft_element();
    /*0x187c044*/ UnityEngine.Sprite get_icon();
    /*0x187c134*/ string get_name_withoutPrefix();
}

class data_craft_element_farm : data_craft_element
{
    /*0x187c3f0*/ data_craft_element_farm();
    /*0x187c1b0*/ UnityEngine.Sprite get_icon();
    /*0x187c1c8*/ data_farm_element get_farm_element();
}

class data_craft_element_special : data_craft_element
{
    /*0x20*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat mult;

    /*0x187c648*/ data_craft_element_special();
    /*0x187c3f8*/ UnityEngine.Sprite get_icon();
    /*0x187c410*/ data_farm_element get_farm_element();
    /*0x187c4a0*/ string Get_Status_text(int lv);
}

class data_currency
{
    /*0x10*/ System.Collections.Generic.Dictionary<string, data_currency_element> <dic>k__BackingField;

    /*0x187bbb4*/ data_currency();
    /*0x187c650*/ System.Collections.Generic.Dictionary<string, data_currency_element> get_dic();
    /*0x187c658*/ void set_dic(System.Collections.Generic.Dictionary<string, data_currency_element> value);
    /*0x1879224*/ void Set_Dic();
    /*0x187c660*/ data_currency_element Get_Dic(string name);
    /*0x187c6f4*/ data_currency_element get_diamond();
    /*0x187c75c*/ data_currency_element get_potion();
    /*0x187c7c4*/ data_currency_element get_autosell();
    /*0x187c82c*/ data_currency_element get_gem();
    /*0x187c894*/ data_currency_element get_gold();
    /*0x187c8fc*/ data_currency_element get_buff();
    /*0x187c964*/ data_currency_element get_amber();
    /*0x187c9cc*/ data_currency_element get_dimension();
    /*0x187ca34*/ data_currency_element get_mastery();
    /*0x187ca9c*/ data_currency_element get_mana();
    /*0x187cb04*/ data_currency_element get_essence();
    /*0x187cb6c*/ data_currency_element get_trace();
    /*0x187cbd4*/ data_currency_element get_vip();
}

class data_currency_element : UnityEngine.ScriptableObject
{
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool constant;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble min;
    /*0x48*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble max;
    /*0x68*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble init;
    /*0x88*/ UnityEngine.Sprite icon;
    /*0x90*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt rank;
    /*0xa0*/ data_quest_element quest_need;
    /*0xa8*/ data_events_element event_need;
    /*0xb0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool ignoreUnlockConditionOnAdd;
    /*0xbc*/ data_currency_element.Format format;

    /*0x187d234*/ data_currency_element();
    /*0x187cc3c*/ string get_quad();
    /*0x187cc94*/ string get_name_withoutPrefix();
    /*0x187cd08*/ string toStringFormat(double num, bool withIcon);
    /*0x187ce28*/ string toStringFormat(double num, bool withIcon, bool withColor);
    /*0x187cf98*/ bool check_currency_unlocked();
    /*0x187cfc8*/ bool check_quest_condition();
    /*0x187d0c4*/ bool check_rank_condition();

    enum Format
    {
        none = 0,
        bigInt = 1,
        time = 2,
    }
}

class data_cutscene
{
    /*0x10*/ System.Collections.Generic.List<data_cutscene_element> elements;

    /*0x187be8c*/ data_cutscene();
    /*0x187b258*/ void LoadAll();
    /*0x187d2a0*/ data_cutscene_element Get_element(string name, bool withPrefix);
    /*0x187d310*/ data_cutscene_element Get_element(string name);

    class <>c__DisplayClass3_0
    {
        /*0x10*/ string name;

        /*0x187d404*/ <>c__DisplayClass3_0();
        /*0x187d40c*/ bool <Get_element>b__0(data_cutscene_element l);
    }
}

class data_cutscene_element : UnityEngine.ScriptableObject
{
    /*0x187d59c*/ data_cutscene_element();
    /*0x187d438*/ UnityEngine.GameObject get_prefab();
    /*0x187d528*/ string get_name_withoutPrefix();
}

class data_enhance
{
    /*0x10*/ System.Collections.Generic.List<data_enhance_element> <list>k__BackingField;

    /*0x187bea4*/ data_enhance();
    /*0x187d5a4*/ System.Collections.Generic.List<data_enhance_element> get_list();
    /*0x187d5ac*/ void set_list(System.Collections.Generic.List<data_enhance_element> value);
    /*0x187b5d8*/ void LoadAll();

    class <>c
    {
        static /*0x0*/ data_enhance.<> <>9;
        static /*0x8*/ System.Func<data_enhance_element, int> <>9__4_0;

        static /*0x187d5b4*/ <>c();
        /*0x187d618*/ <>c();
        /*0x187d620*/ int <LoadAll>b__4_0(data_enhance_element x);
    }
}

class data_enhance_element : UnityEngine.ScriptableObject
{
    /*0x18*/ string info_editorOnly;
    /*0x20*/ UnityEngine.Sprite icon;
    /*0x28*/ int order;
    /*0x30*/ UpgradeManager upgrade_manager;

    /*0x187d6ac*/ data_enhance_element();
    /*0x187d638*/ string get_name_withoutPrefix();
}

class data_events
{
    /*0x10*/ System.Collections.Generic.List<data_events_element> list;

    /*0x187be94*/ data_events();
    /*0x187b338*/ void LoadAll();
    /*0x187d6b4*/ data_events_element Get_element(string name, bool withPrefix);
    /*0x187d724*/ data_events_element Get_element(string name);
    /*0x187d820*/ System.Collections.Generic.List<data_events_element> Get_element_byDate(System.DateTime datetime);

    class <>c
    {
        static /*0x0*/ data_events.<> <>9;
        static /*0x8*/ System.Func<data_events_element, bool> <>9__1_0;

        static /*0x187d91c*/ <>c();
        /*0x187d980*/ <>c();
        /*0x187d988*/ bool <LoadAll>b__1_0(data_events_element element);
    }

    class <>c__DisplayClass3_0
    {
        /*0x10*/ string name;

        /*0x187d818*/ <>c__DisplayClass3_0();
        /*0x187d9a8*/ bool <Get_element>b__0(data_events_element l);
    }

    class <>c__DisplayClass4_0
    {
        /*0x10*/ System.DateTime datetime;

        /*0x187d914*/ <>c__DisplayClass4_0();
        /*0x187d9d4*/ bool <Get_element_byDate>b__0(data_events_element l);
    }
}

class data_events_element : UnityEngine.ScriptableObject
{
    /*0x18*/ string discription;
    /*0x20*/ bool prevent_load;
    /*0x28*/ MonthDatePair date_start;
    /*0x30*/ MonthDatePair date_end;
    /*0x38*/ data_quest_element quest;
    /*0x40*/ data_currency_element currency;
    /*0x48*/ System.Collections.Generic.List<data_skin_element> _skins;
    /*0x50*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble skin_price;
    /*0x70*/ data_tutorial_element tutorial;

    /*0x187e0e0*/ data_events_element();
    /*0x187daf4*/ UnityEngine.GameObject get_prefab_button();
    /*0x187dbe4*/ UnityEngine.GameObject get_prefab_ui();
    /*0x187dcd4*/ string get_name_withoutPrefix();
    /*0x187d9f4*/ bool isOn(System.DateTime date);
    /*0x187dd48*/ System.Collections.Generic.List<data_skin_element> get_skins();
    /*0x187e164*/ bool <get_skins>b__15_0(data_skin_element skin);

    class <>c
    {
        static /*0x0*/ data_events_element.<> <>9;
        static /*0x8*/ System.Func<data_skin_element, data_skin.Type> <>9__15_1;

        static /*0x187e1d0*/ <>c();
        /*0x187e234*/ <>c();
        /*0x187e23c*/ data_skin.Type <get_skins>b__15_1(data_skin_element skin);
    }
}

class data_farm
{
    /*0x10*/ System.Collections.Generic.List<data_farm_element> elements;
    /*0x18*/ System.Collections.Generic.Dictionary<data_farm.Type, CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat> status;
    /*0x20*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble portal_time_base;
    /*0x40*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble reward_time_max_base;
    /*0x60*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble reward_time_min;
    /*0x80*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat reward_mult_base;

    /*0x187bbfc*/ data_farm();
    /*0x187b098*/ void LoadAll();
    /*0x187c380*/ data_farm_element Get_element(string name, bool withPrefix);
    /*0x187e254*/ data_farm_element Get_element(string name);
    /*0x187e350*/ UnityEngine.GameObject prefab_default(data_farm.Type type);

    enum Type
    {
        main = 0,
        sub = 1,
        dock = 2,
        gold = 3,
    }

    class <>c__DisplayClass4_0
    {
        /*0x10*/ string name;

        /*0x187e348*/ <>c__DisplayClass4_0();
        /*0x187e460*/ bool <Get_element>b__0(data_farm_element l);
    }
}

class data_farm_element : UnityEngine.ScriptableObject
{
    /*0x18*/ data_farm.Type type;

    /*0x187e69c*/ data_farm_element();
    /*0x187e48c*/ string get_name_withoutPrefix();
    /*0x187e500*/ data_craft_element get_craft();
    /*0x187c258*/ UnityEngine.Sprite get_icon();
    /*0x187e574*/ UnityEngine.GameObject get_prefab();
}

class data_fish
{
    /*0x10*/ System.Collections.Generic.List<data_fish_element> list;
    /*0x18*/ System.Collections.Generic.Dictionary<string, data_fish_element> <dic>k__BackingField;

    /*0x187bb94*/ data_fish();
    /*0x187e6a4*/ System.Collections.Generic.Dictionary<string, data_fish_element> get_dic();
    /*0x187e6ac*/ void set_dic(System.Collections.Generic.Dictionary<string, data_fish_element> value);
    /*0x1879c18*/ void Set_Dic();

    enum Type
    {
        nor = 0,
        rare = 1,
        boss = 2,
        legend = 3,
        hidden = 4,
        infinite = 5,
    }
}

class data_fish_element : UnityEngine.ScriptableObject
{
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt rank_min;
    /*0x28*/ data_fish.Type type;
    /*0x30*/ data_place_element_field need_place;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool prevent_load;
    /*0x44*/ Dimension_Type appear_dimension;
    /*0x48*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool deceived_by_fake_dimension;
    /*0x58*/ data_cutscene_element cutscene;
    /*0x60*/ data_item_element reward_item;
    /*0x68*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat time_mult;
    /*0x80*/ UnityEngine.AudioClip bgm;
    /*0x88*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredString gpgs_acheivement;
    /*0x90*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredString gc_acheivement;

    /*0x187ee70*/ data_fish_element();
    /*0x187e6b4*/ UnityEngine.GameObject get_prefab();
    /*0x187e7dc*/ UnityEngine.Sprite get_icon();
    /*0x187e904*/ UnityEngine.Sprite get_icon_big();
    /*0x187ea2c*/ string get_PREFIX();
    /*0x187eac4*/ string get_name_noPrefix();
    /*0x187eb34*/ bool get_resides_in_right_dimension();
    /*0x187ebec*/ float get_time();
}

class data_fish_infinite_element : data_fish_element
{
    /*0x98*/ System.Collections.Generic.List<data_fish_infinite_element.LvRewardPair> reward_list;
    /*0xa0*/ System.Collections.Generic.List<int> _reward_level_info;

    /*0x187f4c0*/ data_fish_infinite_element();
    /*0x187ef34*/ System.Collections.Generic.List<int> get_reward_level_info();
    /*0x187efbc*/ void init_reward_level_info();
    /*0x187f0dc*/ void check_reward();
    /*0x187f268*/ void player_receive_reward(data_fish_infinite_element.LvRewardPair reward_info);
    /*0x187f28c*/ void receive_reward_item(data_skin_element reward);
    /*0x187f334*/ void receive_reward_currency(System.Collections.Generic.List<CurNumPair> reward_currency);
    /*0x187f3c0*/ void editor_sort_reward_info();

    class LvRewardPair
    {
        /*0x10*/ data_skin_element reward;
        /*0x18*/ System.Collections.Generic.List<CurNumPair> reward_currency;
        /*0x20*/ int target_level;

        /*0x187f4c4*/ LvRewardPair();
    }

    class <>c
    {
        static /*0x0*/ data_fish_infinite_element.<> <>9;
        static /*0x8*/ System.Comparison<data_fish_infinite_element.LvRewardPair> <>9__10_0;

        static /*0x187f4cc*/ <>c();
        /*0x187f530*/ <>c();
        /*0x187f538*/ int <editor_sort_reward_info>b__10_0(data_fish_infinite_element.LvRewardPair a, data_fish_infinite_element.LvRewardPair b);
    }
}

class data_hidden
{
    /*0x10*/ System.Collections.Generic.List<data_hidden_element> elements;
    /*0x18*/ System.Collections.Generic.List<data_hidden_group> groups;

    /*0x187bbec*/ data_hidden();
    /*0x187ae58*/ void LoadAll();
    /*0x187f56c*/ data_hidden_element Get_element(string name, bool withPrefix);
    /*0x187f5dc*/ data_hidden_element Get_element(string name);

    class <>c__DisplayClass4_0
    {
        /*0x10*/ string name;

        /*0x187f6d0*/ <>c__DisplayClass4_0();
        /*0x187f6d8*/ bool <Get_element>b__0(data_hidden_element l);
    }
}

class data_hidden_element : UnityEngine.ScriptableObject
{
    static string PREFIX = "hidden_";
    /*0x18*/ data_fish_element fish;
    /*0x20*/ data_hidden_group group;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt rank;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 position;

    /*0x187f778*/ data_hidden_element();
    /*0x187f704*/ string get_name_withoutPrefix();
}

class data_hidden_group : UnityEngine.ScriptableObject
{
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat num_mult_inGroup;

    /*0x187fa0c*/ data_hidden_group();
    /*0x187f780*/ string get_name_withoutPrefix();
    /*0x187f7f4*/ System.Collections.Generic.List<data_hidden_element> get_elements();
    /*0x187f8e0*/ System.Collections.Generic.List<data_hidden_element> elements_canUse(int rank);
    /*0x187fa14*/ bool <get_elements>b__4_0(data_hidden_element el);

    class <>c__DisplayClass5_0
    {
        /*0x10*/ data_hidden_group <>4__this;
        /*0x18*/ int rank;

        /*0x187fa04*/ <>c__DisplayClass5_0();
        /*0x187fa80*/ bool <elements_canUse>b__0(data_hidden_element el);
    }
}

class data_iap
{
    /*0x10*/ System.Collections.Generic.List<data_iap_element> elements;

    /*0x187be84*/ data_iap();
    /*0x187b178*/ void LoadAll();
    /*0x187fb4c*/ data_iap_element Get_element(string name, bool withPrefix);
    /*0x187fbbc*/ data_iap_element Get_element(string name);

    class <>c__DisplayClass3_0
    {
        /*0x10*/ string name;

        /*0x187fcb0*/ <>c__DisplayClass3_0();
        /*0x187fcb8*/ bool <Get_element>b__0(data_iap_element l);
    }
}

class data_iap_element : UnityEngine.ScriptableObject
{
    /*0x18*/ System.Collections.Generic.List<CurNumPair> reward;
    /*0x20*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool OnlyOnce;
    /*0x2c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt price;
    /*0x3c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt china_price;
    /*0x4c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt paymentwall_item_id;

    /*0x187fef0*/ data_iap_element();
    /*0x187fce4*/ bool get_isPurchasable();
    /*0x187fd9c*/ string get_localizedPriceString();
    /*0x187fe80*/ decimal get_localizedPrice();
    /*0x187fe0c*/ string get_name_withoutPrefix();
}

class data_item
{
    /*0x10*/ System.Collections.Generic.List<data_item_element> <list>k__BackingField;

    /*0x187bb9c*/ data_item();
    /*0x187fef8*/ System.Collections.Generic.List<data_item_element> get_list();
    /*0x187ff00*/ void set_list(System.Collections.Generic.List<data_item_element> value);
    /*0x1879f1c*/ void Load();
    /*0x187ff08*/ data_item_element Get_element(string name, bool withPrefix);

    class <>c__DisplayClass5_0
    {
        /*0x10*/ string name;

        /*0x1880050*/ <>c__DisplayClass5_0();
        /*0x1880058*/ bool <Get_element>b__0(data_item_element item);
        /*0x1880084*/ bool <Get_element>b__1(data_item_element item);
    }
}

class data_item_element : UnityEngine.ScriptableObject
{
    static string PREFIX = "item_";
    /*0x18*/ UnityEngine.Sprite icon;
    /*0x20*/ System.Collections.Generic.List<CurNumPair> reward;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool stackable;

    /*0x18802e0*/ data_item_element();
    /*0x1880120*/ double get_Get_Reward_NumSum();
    /*0x18800ac*/ string get_name_noPrefix();
}

class data_mastery
{
    /*0x10*/ System.Collections.Generic.Dictionary<string, data_mastery_element> <dic>k__BackingField;

    /*0x187bbd4*/ data_mastery();
    /*0x18802e8*/ System.Collections.Generic.Dictionary<string, data_mastery_element> get_dic();
    /*0x18802f0*/ void set_dic(System.Collections.Generic.Dictionary<string, data_mastery_element> value);
    /*0x187a768*/ void Set_Dic();

    class <>c
    {
        static /*0x0*/ data_mastery.<> <>9;
        static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<string, data_mastery_element>, int> <>9__4_0;
        static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<string, data_mastery_element>, string> <>9__4_1;
        static /*0x18*/ System.Func<System.Collections.Generic.KeyValuePair<string, data_mastery_element>, data_mastery_element> <>9__4_2;

        static /*0x18802f8*/ <>c();
        /*0x188035c*/ <>c();
        /*0x1880364*/ int <Set_Dic>b__4_0(System.Collections.Generic.KeyValuePair<string, data_mastery_element> item);
        /*0x18803a8*/ string <Set_Dic>b__4_1(System.Collections.Generic.KeyValuePair<string, data_mastery_element> v);
        /*0x18803e4*/ data_mastery_element <Set_Dic>b__4_2(System.Collections.Generic.KeyValuePair<string, data_mastery_element> v);
    }
}

class data_mastery_element : UnityEngine.ScriptableObject
{
    /*0x18*/ UnityEngine.Sprite icon;
    /*0x20*/ data_mastery_element.level[] levels;
    /*0x28*/ int order;
    /*0x2c*/ int need_rank;
    /*0x30*/ data_tutorial_element tutorial;
    /*0x38*/ bool isSeriesLevel;

    /*0x1880514*/ data_mastery_element();
    /*0x1880420*/ data_tutorial_element Get_tutorial(int lv_now);
    /*0x18804f8*/ int get_lv_max();

    struct level
    {
        /*0x10*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt price;
        /*0x20*/ data_tutorial_element tutorial;
    }
}

class data_npc
{
    /*0x10*/ System.Collections.Generic.List<data_npc_element> list;
    /*0x18*/ System.Collections.Generic.Dictionary<string, data_npc_element> <dic>k__BackingField;

    /*0x187bbe4*/ data_npc();
    /*0x188051c*/ System.Collections.Generic.Dictionary<string, data_npc_element> get_dic();
    /*0x1880524*/ void set_dic(System.Collections.Generic.Dictionary<string, data_npc_element> value);
    /*0x187ab9c*/ void Set_Dic();
    /*0x188052c*/ data_npc_element Get_Dic(string name);
    /*0x18805c0*/ data_npc_element get_Get_Default();
}

class data_npc_element : UnityEngine.ScriptableObject
{
    /*0x18*/ System.Collections.Generic.List<string> _dialogue_id_list;

    static /*0x1880e54*/ bool validity_check(string key, string data_npc_elem_name);
    static /*0x1880e6c*/ string[] parse_rank_and_index(string key, string data_npc_elem_name);
    static /*0x1880f48*/ int parse_rank(string key, string data_npc_elem_name);
    /*0x1880f7c*/ data_npc_element();
    /*0x1880608*/ UnityEngine.Sprite get_icon_small();
    /*0x1880728*/ UnityEngine.Sprite get_icon_big();
    /*0x18806cc*/ string get_icon_small_load_path();
    /*0x18807ec*/ string get_icon_big_load_path();
    /*0x1880848*/ System.Collections.Generic.List<string> get_dialogues_by_rank(int minRank);
    /*0x1880a24*/ System.Collections.Generic.List<string> get_dialogue_id_list();

    class <>c__DisplayClass8_0
    {
        /*0x10*/ data_npc_element <>4__this;
        /*0x18*/ int minRank;

        /*0x1880a1c*/ <>c__DisplayClass8_0();
        /*0x1880f84*/ bool <get_dialogues_by_rank>b__0(string dialog);
    }

    class <>c
    {
        static /*0x0*/ data_npc_element.<> <>9;
        static /*0x8*/ System.Func<string, string> <>9__8_1;

        static /*0x1880fcc*/ <>c();
        /*0x1881030*/ <>c();
        /*0x1881038*/ string <get_dialogues_by_rank>b__8_1(string dialog);
    }
}

class data_place
{
    /*0x10*/ System.Collections.Generic.List<data_place_element> <list>k__BackingField;
    /*0x18*/ System.Collections.Generic.Dictionary<string, data_place_element> <dic>k__BackingField;

    /*0x187bb8c*/ data_place();
    /*0x1881040*/ System.Collections.Generic.List<data_place_element> get_list();
    /*0x1881048*/ void set_list(System.Collections.Generic.List<data_place_element> value);
    /*0x1881050*/ System.Collections.Generic.Dictionary<string, data_place_element> get_dic();
    /*0x1881058*/ void set_dic(System.Collections.Generic.Dictionary<string, data_place_element> value);
    /*0x18798e0*/ void Set_Dic();

    enum Type
    {
        harbor = 0,
        field = 1,
        special = 2,
        monument = 3,
        legend = 4,
        farm = 5,
    }
}

class data_quest
{
    /*0x10*/ System.Collections.Generic.List<data_quest_group_element> <quest_group_list>k__BackingField;
    /*0x18*/ System.Collections.Generic.Dictionary<string, data_quest_element> <quest_dic>k__BackingField;

    static /*0x1881d84*/ int Quest_Enum_Order(data_quest.Type type);
    /*0x187bbdc*/ data_quest();
    /*0x1881060*/ System.Collections.Generic.List<data_quest_group_element> get_quest_group_list();
    /*0x1881068*/ void set_quest_group_list(System.Collections.Generic.List<data_quest_group_element> value);
    /*0x1881070*/ System.Collections.Generic.Dictionary<string, data_quest_element> get_quest_dic();
    /*0x1881078*/ void set_quest_dic(System.Collections.Generic.Dictionary<string, data_quest_element> value);
    /*0x1881080*/ System.Collections.Generic.IEnumerable<data_quest_element> get_quest_list();
    /*0x187ab84*/ void Set_Dic();
    /*0x18810d0*/ void Set_Quest_Dic();
    /*0x18812d0*/ void Set_Quest_Group_List();
    /*0x188154c*/ data_quest_element Get_Quest_Element(string name, bool withprefix);
    /*0x188161c*/ data_quest_group_element Get_Quest_Group_Element(string name, bool withprefix);
    /*0x18817d4*/ System.Collections.Generic.List<data_quest_element> Get_Next_Quest_list(data_quest_element quest_done);
    /*0x18819b8*/ System.Collections.Generic.List<data_quest_element> Get_Place_Quest_List(data_place_element place);
    /*0x1881b9c*/ System.Collections.Generic.List<data_quest_element> Get_Current_Rank_Quest_List();
    /*0x1881d80*/ System.Collections.Generic.List<data_quest_element> Get_Uncleared_Quest_List();

    enum Type
    {
        main = 0,
        sub = 1,
        encount = 2,
        journal = 3,
    }

    class <>c
    {
        static /*0x0*/ data_quest.<> <>9;
        static /*0x8*/ System.Func<data_quest_group_element, data_quest_group_element.Type> <>9__13_0;
        static /*0x10*/ System.Func<data_quest_group_element, int> <>9__13_1;
        static /*0x18*/ System.Func<data_quest_element, bool> <>9__16_0;
        static /*0x20*/ System.Func<data_quest_element, int> <>9__16_1;
        static /*0x28*/ System.Func<data_quest_element, bool> <>9__17_0;
        static /*0x30*/ System.Func<data_quest_element, int> <>9__17_1;
        static /*0x38*/ System.Func<data_quest_element, bool> <>9__18_0;
        static /*0x40*/ System.Func<data_quest_element, int> <>9__18_1;

        static /*0x1881da4*/ <>c();
        /*0x1881e08*/ <>c();
        /*0x1881e10*/ data_quest_group_element.Type <Set_Quest_Group_List>b__13_0(data_quest_group_element quest_group);
        /*0x1881e28*/ int <Set_Quest_Group_List>b__13_1(data_quest_group_element quest_group);
        /*0x1881e40*/ bool <Get_Next_Quest_list>b__16_0(data_quest_element quest);
        /*0x1881ea4*/ int <Get_Next_Quest_list>b__16_1(data_quest_element quest);
        /*0x1881ed8*/ bool <Get_Place_Quest_List>b__17_0(data_quest_element quest);
        /*0x1881f0c*/ int <Get_Place_Quest_List>b__17_1(data_quest_element quest);
        /*0x1881f40*/ bool <Get_Current_Rank_Quest_List>b__18_0(data_quest_element quest);
        /*0x1881f74*/ int <Get_Current_Rank_Quest_List>b__18_1(data_quest_element quest);
    }
}

enum Dimension_Type
{
    Both = 0,
    Base = 1,
    Parallel = 2,
}

class data_quest_element : UnityEngine.ScriptableObject
{
    /*0x18*/ data_quest_group_element parent_group;
    /*0x20*/ QuestInitCondition init_condition;
    /*0x28*/ data_quest.Type info_type;
    /*0x30*/ data_npc_element info_npc;
    /*0x38*/ data_quest_element_task task;
    /*0x40*/ data_tutorial_element tutorial_after_quest_done;
    /*0x48*/ data_place_element reward_place;
    /*0x50*/ Dimension_Type reward_dimension;
    /*0x54*/ int reward_dimension_difficulty;
    /*0x58*/ System.Collections.Generic.List<CurNumPair> reward;
    /*0x60*/ System.Collections.Generic.List<data_skin_element> reward_skin;
    /*0x68*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool reward_disabled;
    /*0x78*/ data_cutscene_element reward_cutscene;

    /*0x18822dc*/ data_quest_element();
    /*0x1881fa8*/ bool get_player_in_target_dimension();
    /*0x188200c*/ data_place_element get_target_now();
    /*0x1882150*/ string get_name_withoutPrefix();
    /*0x18821c4*/ data_quest_element.Status get_currentStatus();

    enum Status
    {
        Hidden = 0,
        Doing = 1,
        Completed = 2,
        Done = 3,
    }
}

class QuestInitCondition
{
    /*0x10*/ QuestInitCondition.QuestInitType init_type;
    /*0x18*/ DimensionalConditionChecker condition_checker;

    /*0x18825f4*/ QuestInitCondition();
    /*0x18822e4*/ data_quest_element get_init_quest();
    /*0x188246c*/ data_place_element get_init_place();
    /*0x1881e74*/ bool checkCondition();

    enum QuestInitType
    {
        Manual = 0,
        Achieve_Rank = 1,
        Arrive_Place = 2,
        Prev_Quest = 3,
        Random_Encount = 4,
        Server_Event = 5,
    }
}

class data_quest_element_task
{
    /*0x10*/ UnityEngine.ScriptableObject so;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt num;
    /*0x28*/ data_place_element place;
    /*0x30*/ Dimension_Type task_active_dimension;
    /*0x34*/ int task_active_dimension_difficulty;

    /*0x1882e98*/ data_quest_element_task();
    /*0x18825fc*/ bool get_isExist();
    /*0x188265c*/ string Get_Language(int now);
    /*0x1882e34*/ bool get_player_in_target_dimension();
}

class data_quest_group_element : UnityEngine.ScriptableObject
{
    /*0x18*/ data_quest_group_element.Type type;
    /*0x1c*/ int order;
    /*0x20*/ CurNumPair quest_group_reward;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat reward_status_mult;
    /*0x40*/ System.Collections.Generic.List<data_quest_element> _child_quest_elements;

    /*0x1883618*/ data_quest_group_element();
    /*0x1882ea0*/ bool get_isActivated();
    /*0x188300c*/ System.Collections.Generic.List<data_quest_element> get_child_quest_elements();
    /*0x18831e0*/ int get_total_child_quest_count();
    /*0x188322c*/ int get_completed_child_quest_count();
    /*0x18833c4*/ string get_name_withoutPrefix();
    /*0x1883438*/ data_quest_group_element.Status get_currentStatus();
    /*0x1883620*/ bool <get_child_quest_elements>b__10_0(data_quest_element quest);

    enum Status
    {
        Hidden = 0,
        Doing = 1,
        Completed = 2,
        Done = 3,
    }

    enum Type
    {
        Main = 0,
        Story = 1,
        Parallel = 2,
        Journal = 3,
        Contents_Unlock = 4,
    }

    class <>c
    {
        static /*0x0*/ data_quest_group_element.<> <>9;
        static /*0x8*/ System.Func<data_quest_element, data_quest.Type> <>9__10_1;

        static /*0x188368c*/ <>c();
        /*0x18836f0*/ <>c();
        /*0x18836f8*/ data_quest.Type <get_child_quest_elements>b__10_1(data_quest_element quest);
    }
}

class data_rank_unlock_info_holder : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.List<RankUnlockObject>> rank_contents_pair;
    /*0x20*/ System.Collections.Generic.List<data_rank_unlock_info_holder.ManualRankUnlockObject> unlockables_manual;

    /*0x1884b58*/ data_rank_unlock_info_holder();
    /*0x1883710*/ void Awake();
    /*0x1883814*/ void initiate_datas();
    /*0x1884564*/ void LogRankContentsData();
    /*0x18838a8*/ void init_place_datas();
    /*0x1883b64*/ void init_turret_datas();
    /*0x1883d20*/ void init_skill_datas();
    /*0x1883fe8*/ void init_currency_datas();
    /*0x1884334*/ void init_manuals();
    /*0x18849ac*/ System.Collections.Generic.List<RankUnlockObject> get_or_init_dict_by_rank(int rank_key);

    class ManualRankUnlockObject
    {
        /*0x10*/ int target_rank;
        /*0x18*/ UnityEngine.Sprite icon;

        /*0x1884b60*/ ManualRankUnlockObject();
    }
}

class RankUnlockObject
{
    /*0x10*/ RankUnlockObject.Type type;
    /*0x18*/ UnityEngine.Object obj;
    /*0x20*/ int turret_no;
    /*0x28*/ UnityEngine.Sprite icon;

    /*0x1884aa8*/ RankUnlockObject(RankUnlockObject.Type type, UnityEngine.Object obj, UnityEngine.Sprite icon);
    /*0x1884ae8*/ RankUnlockObject(RankUnlockObject.Type type, int turret_no, UnityEngine.Sprite icon);
    /*0x1884b28*/ RankUnlockObject(RankUnlockObject.Type type, UnityEngine.Sprite icon);

    enum Type
    {
        Place = 0,
        Turret = 1,
        Skill = 2,
        Currency = 3,
        Manual = 4,
    }
}

class data_record
{
    /*0x10*/ System.Collections.Generic.Dictionary<string, data_record_element> <dic>k__BackingField;

    /*0x187bbbc*/ data_record();
    /*0x1884b68*/ System.Collections.Generic.Dictionary<string, data_record_element> get_dic();
    /*0x1884b70*/ void set_dic(System.Collections.Generic.Dictionary<string, data_record_element> value);
    /*0x18796e0*/ void Set_Dic();
    /*0x1884b78*/ data_record_element Get_Dic(string name);
}

class data_record_element : UnityEngine.ScriptableObject
{
    /*0x18*/ data_record_element.NeedRewardPair[] reward;
    /*0x20*/ data_record_element.NeedRewardPair reward_term;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt reward_term_rank_max;

    /*0x1884e98*/ data_record_element();
    /*0x1884c0c*/ int reward_need_now(int rank);
    /*0x1884d34*/ int get_reward_need_max();
    /*0x1884da0*/ CurNumPair reward_now(int rank);

    struct NeedRewardPair
    {
        /*0x10*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt need;
        /*0x20*/ CurNumPair reward;
    }
}

class data_relic
{
    /*0x10*/ System.Collections.Generic.List<data_relic_element> <list>k__BackingField;

    /*0x187be9c*/ data_relic();
    /*0x1884ea0*/ System.Collections.Generic.List<data_relic_element> get_list();
    /*0x1884ea8*/ void set_list(System.Collections.Generic.List<data_relic_element> value);
    /*0x187b4f8*/ void LoadAll();
}

class data_relic_element : UnityEngine.ScriptableObject
{
    /*0x18*/ string info;
    /*0x20*/ UnityEngine.Sprite icon;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt lv_max;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt need_rank;
    /*0x48*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt need_base;
    /*0x58*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat need_mult;
    /*0x70*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat stat_mult;
    /*0x88*/ ItemNumPair needItem;

    /*0x1885060*/ data_relic_element();
    /*0x1884eb0*/ int Get_needNum(int lv_now);
    /*0x1884fec*/ string get_name_withoutPrefix();
}

class data_setting : UnityEngine.ScriptableObject
{
    static float dps_base = 30;
    static float dps_mult = 1.0099999904632568;
    static float gold_base = 10;
    static float gold_mult = 1.0199999809265137;
    static float EXP_NEED_BASE = 4.800000190734863;
    static float EXP_NEED_MULT = 1.0049999952316284;
    static float rod_gold_base = 8;
    static float rod_gold_mult = 1.0080000162124634;
    static float lvMax_mult = 1.100000023841858;
    static float fish_life_mult_base = 0.800000011920929;
    static float fish_life_mult = 1.00600004196167;
    static int TPS_MAX = 5;
    static int TPS_OVER = 2;
    static double skill_potion_mana_base = 30;
    static int MAX_RANK = 47;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 default_position;
    /*0x30*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat rod_dps_mult;
    /*0x48*/ data_setting_turret[] turret;
    /*0x50*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat time_wait_min;
    /*0x68*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat time_wait_max;
    /*0x80*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat time_found;
    /*0x98*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat time_done;
    /*0xb0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt rampage_need_rank;
    /*0xc0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt mastery_need_rank;
    /*0xd0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt amber_need_rank;
    /*0xe0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat place_special_002_min;
    /*0xf8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat place_special_002_mult;
    /*0x110*/ data_quest_element pet_need_quest;
    /*0x118*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat pet_dps_mult;
    /*0x130*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat sonar_distance_base;
    /*0x148*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat sonar_distance_mult;
    /*0x160*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt sonar_rank;
    /*0x170*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat sonar_reach_base;
    /*0x188*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat sonar_reach_mult;
    /*0x1a0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat portal_need_mana_rate;
    /*0x1b8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt portal_rank;

    /*0x18857e8*/ data_setting();
    /*0x1885068*/ double Get_dps_base(int lv);
    /*0x18850a0*/ double Get_gold(int lv);
    /*0x18850c8*/ int get_exp_lvDiff_max();
    /*0x18853a0*/ float Get_exp(int lv, int lv_character);
    /*0x18853e8*/ double rod_gold_need(int lv);
    /*0x1885288*/ int Get_lvMax(int rank);
    /*0x1885314*/ int Get_lvMin(int rank);
    /*0x188548c*/ double Get_fish_life_base(int lv);
    /*0x18854e8*/ double get_skill_potion_correction();
    /*0x18855bc*/ double get_skill_potion_mana();
    /*0x18855dc*/ int get_max_lv();
    /*0x188567c*/ float get_place_special_002_rate();
}

class data_setting_turret
{
    /*0x10*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat attack_term;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt attack_split;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat dps_base;
    /*0x50*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat dps_mult;
    /*0x68*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt need_rank;
    /*0x78*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat gold_base;
    /*0x90*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat gold_mult;
    /*0xa8*/ data_enhance_element enhance;
    /*0xb0*/ UnityEngine.Sprite icon;

    /*0x1885a20*/ data_setting_turret();
    /*0x1885880*/ double gold_need(int lv);
    /*0x18859a4*/ int get_no();
}

class data_skill
{
    /*0x10*/ System.Collections.Generic.List<data_skill_element> list;
    /*0x18*/ System.Collections.Generic.Dictionary<string, data_skill_element> <dic>k__BackingField;

    /*0x187bbac*/ data_skill();
    /*0x1885a28*/ System.Collections.Generic.Dictionary<string, data_skill_element> get_dic();
    /*0x1885a30*/ void set_dic(System.Collections.Generic.Dictionary<string, data_skill_element> value);
    /*0x1879424*/ void Set_Dic();
    /*0x1885a38*/ data_skill_element Get_Dic(string name);
    /*0x1885acc*/ data_skill_element get_fish();
    /*0x1885b14*/ data_skill_element get_speed();
    /*0x1885b5c*/ data_skill_element get_haste();
}

class data_skill_element : UnityEngine.ScriptableObject
{
    /*0x18*/ UnityEngine.Sprite icon;
    /*0x20*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt need_mana;
    /*0x30*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt need_rank;
    /*0x40*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt time;
    /*0x50*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat mult;
    /*0x68*/ data_mastery_element mastery;
    /*0x70*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat boost_mult_base;
    /*0x88*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat boost_mult;

    /*0x1885c18*/ data_skill_element();
    /*0x1885ba4*/ string get_name_withoutPrefix();
}

class data_skin
{
    /*0x10*/ System.Collections.Generic.List<data_skin_element> _list;
    /*0x18*/ System.Collections.Generic.Dictionary<data_skin.Type, System.Collections.Generic.Dictionary<string, data_skin_element>> _dic;

    /*0x187bba4*/ data_skin();
    /*0x187df24*/ System.Collections.Generic.List<data_skin_element> get_list();
    /*0x1885c20*/ System.Collections.Generic.Dictionary<data_skin.Type, System.Collections.Generic.Dictionary<string, data_skin_element>> get_dic();
    /*0x1885fb0*/ data_skin_element Get_Default(data_skin.Type type);
    /*0x188603c*/ data_skin_element Get_dic(data_skin.Type type, string name, bool withPrefix);
    /*0x188618c*/ data_skin_element Get_item(string name);

    enum Type
    {
        rod = 0,
        hat = 1,
        hair = 2,
        body = 3,
        ship = 4,
        inven = 5,
        skill = 6,
        pet = 7,
        turret_00 = 8,
        turret_01 = 9,
        turret_02 = 10,
        turret_03 = 11,
    }

    class <>c
    {
        static /*0x0*/ data_skin.<> <>9;
        static /*0x8*/ System.Func<data_skin_element, bool> <>9__3_0;

        static /*0x1886294*/ <>c();
        /*0x18862f8*/ <>c();
        /*0x1886300*/ bool <get_list>b__3_0(data_skin_element skin);
    }

    class <>c__DisplayClass9_0
    {
        /*0x10*/ string name;

        /*0x188628c*/ <>c__DisplayClass9_0();
        /*0x1886320*/ bool <Get_item>b__0(data_skin_element item);
    }
}

class data_skin_element : UnityEngine.ScriptableObject
{
    /*0x18*/ data_skin.Type type;
    /*0x1c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt rank_min;
    /*0x2c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt rank_max;
    /*0x40*/ CurNumPair price;
    /*0x48*/ data_events_element events;
    /*0x50*/ bool prevent_load;
    /*0x51*/ bool prevent_shop;
    /*0x58*/ data_place_element _place;

    /*0x1886e4c*/ data_skin_element();
    /*0x188634c*/ CurNumPair price_upgrade(int rank_now);
    /*0x188649c*/ UnityEngine.Sprite get_icon();
    /*0x18865c4*/ UnityEngine.GameObject get_prefab();
    /*0x18866ec*/ UnityEngine.Material get_material();
    /*0x1886838*/ UnityEngine.Material get_material_sub();
    /*0x1886984*/ data_place_element get_place();
    /*0x1886abc*/ string get_from();
    /*0x1886d74*/ string get_name_withoutPrefix();
    /*0x1886eb8*/ bool <get_place>b__18_0(data_place_element place);
}

class data_sprite
{
    /*0x10*/ System.Collections.Generic.List<UnityEngine.Sprite> list;
    /*0x18*/ System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> <dic>k__BackingField;

    /*0x187bbc4*/ data_sprite();
    /*0x1886f64*/ System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> get_dic();
    /*0x1886f6c*/ void set_dic(System.Collections.Generic.Dictionary<string, UnityEngine.Sprite> value);
    /*0x1879ffc*/ void Set_Dic();
}

class data_tutorial
{
    /*0x10*/ System.Collections.Generic.Dictionary<string, data_tutorial_element> <dic>k__BackingField;

    /*0x187bbcc*/ data_tutorial();
    /*0x1886f74*/ System.Collections.Generic.Dictionary<string, data_tutorial_element> get_dic();
    /*0x1886f7c*/ void set_dic(System.Collections.Generic.Dictionary<string, data_tutorial_element> value);
    /*0x187a228*/ void Set_Dic();
    /*0x1886f84*/ UnityEngine.GameObject Get_Dic(string name);
    /*0x1887110*/ System.Collections.Generic.List<data_tutorial_element> Get_Reached_Rank_Tutorial(int rank_reached);

    class <>c
    {
        static /*0x0*/ data_tutorial.<> <>9;
        static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<string, data_tutorial_element>, int> <>9__4_0;
        static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<string, data_tutorial_element>, string> <>9__4_1;
        static /*0x18*/ System.Func<System.Collections.Generic.KeyValuePair<string, data_tutorial_element>, data_tutorial_element> <>9__4_2;
        static /*0x20*/ System.Func<data_tutorial_element, int> <>9__6_1;

        static /*0x1887304*/ <>c();
        /*0x1887368*/ <>c();
        /*0x1887370*/ int <Set_Dic>b__4_0(System.Collections.Generic.KeyValuePair<string, data_tutorial_element> item);
        /*0x18873b4*/ string <Set_Dic>b__4_1(System.Collections.Generic.KeyValuePair<string, data_tutorial_element> v);
        /*0x18873f0*/ data_tutorial_element <Set_Dic>b__4_2(System.Collections.Generic.KeyValuePair<string, data_tutorial_element> v);
        /*0x188742c*/ int <Get_Reached_Rank_Tutorial>b__6_1(data_tutorial_element item);
    }

    class <>c__DisplayClass6_0
    {
        /*0x10*/ int rank_reached;

        /*0x18872fc*/ <>c__DisplayClass6_0();
        /*0x1887444*/ bool <Get_Reached_Rank_Tutorial>b__0(data_tutorial_element item);
    }
}

class data_tutorial_element : UnityEngine.ScriptableObject
{
    /*0x18*/ int need_rank;
    /*0x1c*/ bool activate_on_rank_reached;
    /*0x20*/ int popup_rank;
    /*0x24*/ Dimension_Type target_popup_dimension;
    /*0x28*/ int order;
    /*0x2c*/ int group;
    /*0x30*/ data_events_element need_event;

    /*0x1887694*/ data_tutorial_element();
    /*0x1887020*/ UnityEngine.GameObject get_prefab();
    /*0x1887480*/ bool get_popup_in_right_dimension();
    /*0x1887544*/ bool get_menu_visible();
}

class BuffStatFormular : GarlicFormularInterface<float>
{
    /*0x10*/ BuffStatFormular.OperationType op_type;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat initial_value;
    /*0x30*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat factor;

    /*0x18876a4*/ BuffStatFormular(BuffStatFormular.OperationType op_type, float initial_value, float factor);
    /*0x1887778*/ float Calculate(int level);

    enum OperationType
    {
        sum = 0,
        pow = 1,
    }
}

interface GarlicFormularInterface<T>
{
    T Calculate(int lvevl);
}

class UpgradeCostFormular : GarlicFormularInterface<double>
{
    /*0x10*/ data_currency_element currency_type;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt initial_cost;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat multiplier;
    /*0x40*/ bool refundable;
    /*0x44*/ float refund_rate;

    /*0x1887958*/ UpgradeCostFormular(data_currency_element currency_type, int initial_cost, float multiplier, bool refundable, float refund_rate);
    /*0x1887a54*/ double Calculate(int level);
    /*0x1887b78*/ CurNumPair getUpgradeCost(int level);
    /*0x1887c08*/ CurNumPair getRefundCost(int level);
}

class UpgradeManager
{
    /*0x10*/ bool limit_max_level;
    /*0x11*/ bool use_base_rank;
    /*0x18*/ LimitLevelByRankInfoHolder max_level_limits;
    /*0x20*/ UpgradeCostFormular upgrade_cost_formular;
    /*0x28*/ BuffStatFormular buff_stat_formular;

    /*0x18880fc*/ UpgradeManager();
    /*0x1887cc4*/ int get_lv_max_now();
    /*0x1887f48*/ int get_next_rank_needed();
}

class LimitLevelByRankInfoHolder
{
    /*0x10*/ System.Collections.Generic.List<RankLvPair> limit_max_level_by_rank;

    /*0x1888104*/ LimitLevelByRankInfoHolder();
}

class data_place_element : UnityEngine.ScriptableObject
{
    /*0x18*/ System.Collections.Generic.List<DimensionalConditionChecker> visibility_checker;
    /*0x20*/ data_place.Type type;
    /*0x24*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 position;
    /*0x3c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt rank;
    /*0x4c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool prevent_load;
    /*0x58*/ UnityEngine.Sprite icon;
    /*0x60*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool freePortal;
    /*0x70*/ data_cutscene_element cutscene;
    /*0x78*/ bool constant;
    /*0x7c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt charge_time;
    /*0x8c*/ bool upgradable_place;
    /*0x90*/ UpgradeManager upgrade_manager;

    /*0x188871c*/ data_place_element();
    /*0x188810c*/ UnityEngine.GameObject get_prefab();
    /*0x1888248*/ bool get_chargeable_place();
    /*0x18882b8*/ double charge_time_now();
    /*0x1888324*/ bool get_isInteractable();
    /*0x18883f4*/ bool get_isVisible();
    /*0x1888568*/ bool get_isCurrentBoss();
    /*0x188863c*/ string get_name_noPrefix();
}

class data_place_element_field : data_place_element
{
    /*0x98*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool boss_once;
    /*0xa8*/ System.Collections.Generic.List<data_place_element_field.FishRankPair> another_fish_list;

    /*0x1888cd8*/ data_place_element_field();
    /*0x1888790*/ bool get_multiple_boss();
    /*0x18887e4*/ data_fish_element get_fish_rare();
    /*0x18888f8*/ data_fish_element get_fish_boss();
    /*0x18889ac*/ data_fish_element get_another_avaliable_boss();

    class FishRankPair
    {
        /*0x10*/ data_fish_element fish;
        /*0x18*/ int rank;
        /*0x1c*/ bool appear_only_same_rank;
        /*0x20*/ data_quest_element need_quest;

        /*0x1888cdc*/ FishRankPair();
    }

    class <>c
    {
        static /*0x0*/ data_place_element_field.<> <>9;
        static /*0x8*/ System.Comparison<data_place_element_field.FishRankPair> <>9__10_0;

        static /*0x1888ce4*/ <>c();
        /*0x1888d48*/ <>c();
        /*0x1888d50*/ int <get_another_avaliable_boss>b__10_0(data_place_element_field.FishRankPair a, data_place_element_field.FishRankPair b);
    }
}

class data_place_element_harbor : data_place_element
{
    /*0x98*/ System.Collections.Generic.List<data_skin_element> skin;

    /*0x1888d84*/ data_place_element_harbor();
}

class data_place_element_special : data_place_element
{
    /*0x98*/ data_craft_element crafts_for_upgrade;

    /*0x188900c*/ data_place_element_special();
    /*0x1888d88*/ double charge_time_now();
    /*0x1888f1c*/ int get_craft_lv();
}

class DeActivateOnChinaBuild : UnityEngine.MonoBehaviour
{
    /*0x1889014*/ DeActivateOnChinaBuild();
    /*0x1889010*/ void Awake();
}

class DestroyOnTesterMode : UnityEngine.MonoBehaviour
{
    /*0x1889114*/ DestroyOnTesterMode();
    /*0x188901c*/ void Start();
}

class DragThresholdInitializer : UnityEngine.MonoBehaviour
{
    static float inchToCm = 2.5399999618530273;
    /*0x18*/ float dragThresholdCM;

    /*0x18891c0*/ DragThresholdInitializer();
    /*0x188911c*/ void Start();
}

class game : UnityEngine.MonoBehaviour
{
    static /*0x0*/ game ins;
    /*0x18*/ bool <started>k__BackingField;
    /*0x19*/ bool _fish_notice;
    /*0x20*/ game_fish fish;
    /*0x28*/ game_fish_legend fish_legend;
    /*0x30*/ game_fish_infinite fish_infinite;
    /*0x38*/ game_turret[] turret;
    /*0x40*/ game_character character;
    /*0x48*/ game_balloon balloon;
    /*0x50*/ game_sonar sonar;
    /*0x58*/ game_automove automove;
    /*0x60*/ game_helper helper;
    /*0x68*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt <tps>k__BackingField;
    /*0x78*/ bool forceIdle;
    /*0x79*/ bool forceShot;
    /*0x7c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool <auto>k__BackingField;
    /*0x88*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool <success>k__BackingField;
    /*0x94*/ float <charge_now>k__BackingField;
    /*0x98*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat time_left;
    /*0xb0*/ double <life_left>k__BackingField;
    /*0xb8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat crit_now;
    /*0xd0*/ game.state <state_now>k__BackingField;
    /*0xd8*/ System.Collections.IEnumerator coroutine;

    /*0x188aa34*/ game();
    /*0x18891d4*/ void Awake();
    /*0x1889318*/ void Update();
    /*0x18898c4*/ bool get_started();
    /*0x18898cc*/ void set_started(bool value);
    /*0x18898d8*/ bool get_fish_notice();
    /*0x18898e0*/ void set_fish_notice(bool value);
    /*0x18898ec*/ void Refresh_Initiate();
    /*0x1889ac8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_tps();
    /*0x1889ad4*/ void set_tps(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
    /*0x1889adc*/ float get_tps_rate();
    /*0x1889b4c*/ System.Collections.IEnumerator IE_Add_tps();
    /*0x1889bdc*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_auto();
    /*0x1889bec*/ void set_auto(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value);
    /*0x1889bf8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_success();
    /*0x1889c08*/ void set_success(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value);
    /*0x1889c14*/ float get_charge_now();
    /*0x1889c1c*/ void set_charge_now(float value);
    /*0x1889c24*/ float get_charge_max();
    /*0x1889d4c*/ double get_life_left();
    /*0x1889d54*/ void set_life_left(double value);
    /*0x1889d5c*/ game.state get_state_now();
    /*0x1889d64*/ void set_state_now(game.state value);
    /*0x1889d6c*/ bool get_Is_Fighting_Legend();
    /*0x1889e28*/ bool get_isFighting();
    /*0x1889978*/ void Set_State(game.state targetState);
    /*0x1889e50*/ System.Collections.IEnumerator IE_Sleep();
    /*0x1889eb8*/ System.Collections.IEnumerator IE_SleepToIdle();
    /*0x1889f20*/ System.Collections.IEnumerator IE_Idle();
    /*0x1889f88*/ System.Collections.IEnumerator IE_Charge();
    /*0x1889ff0*/ System.Collections.IEnumerator IE_Shot();
    /*0x188a058*/ System.Collections.IEnumerator IE_Wait();
    /*0x188a0c0*/ System.Collections.IEnumerator IE_WaitToIdle();
    /*0x188a128*/ System.Collections.IEnumerator IE_Found();
    /*0x188a190*/ System.Collections.IEnumerator IE_Initiate();
    /*0x188a1f8*/ System.Collections.IEnumerator IE_Fight();
    /*0x188a260*/ System.Collections.IEnumerator IE_FightDone();
    /*0x188a2c8*/ System.Collections.IEnumerator IE_Done();
    /*0x1889394*/ void PointerDown();
    /*0x188a608*/ void PointerUp();
    /*0x188a510*/ void Fight_Attack(double damage, bool isCrit);
    /*0x188a678*/ void Fight_Giveup();
    /*0x188a700*/ void Force_Idle();
    /*0x188a718*/ void Force_Idle_cancel();
    /*0x188a720*/ void Start_Game(bool started);
    /*0x188a93c*/ void Force_Shot();

    enum state
    {
        sleep = 0,
        sleepToIdle = 1,
        idle = 2,
        charge = 3,
        shot = 4,
        wait = 5,
        waitToIdle = 6,
        found = 7,
        initiate = 8,
        fight = 9,
        fightDone = 10,
        done = 11,
    }

    class <IE_Add_tps>d__27 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game <>4__this;

        /*0x1889bb4*/ <IE_Add_tps>d__27(int <>1__state);
        /*0x188aa3c*/ void System.IDisposable.Dispose();
        /*0x188aa40*/ bool MoveNext();
        /*0x188ac58*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x188ac60*/ void System.Collections.IEnumerator.Reset();
        /*0x188aca0*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_Sleep>d__61 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game <>4__this;

        /*0x188a330*/ <IE_Sleep>d__61(int <>1__state);
        /*0x188aca8*/ void System.IDisposable.Dispose();
        /*0x188acac*/ bool MoveNext();
        /*0x188ad74*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x188ad7c*/ void System.Collections.IEnumerator.Reset();
        /*0x188adbc*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_SleepToIdle>d__62 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game <>4__this;

        /*0x188a358*/ <IE_SleepToIdle>d__62(int <>1__state);
        /*0x188adc4*/ void System.IDisposable.Dispose();
        /*0x188adc8*/ bool MoveNext();
        /*0x188b160*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x188b168*/ void System.Collections.IEnumerator.Reset();
        /*0x188b1a8*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_Idle>d__63 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game <>4__this;

        /*0x188a380*/ <IE_Idle>d__63(int <>1__state);
        /*0x188b1b0*/ void System.IDisposable.Dispose();
        /*0x188b1b4*/ bool MoveNext();
        /*0x188b3a8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x188b3b0*/ void System.Collections.IEnumerator.Reset();
        /*0x188b3f0*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_Charge>d__64 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game <>4__this;

        /*0x188a3a8*/ <IE_Charge>d__64(int <>1__state);
        /*0x188b3f8*/ void System.IDisposable.Dispose();
        /*0x188b3fc*/ bool MoveNext();
        /*0x188b690*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x188b698*/ void System.Collections.IEnumerator.Reset();
        /*0x188b6d8*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_Shot>d__65 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game <>4__this;

        /*0x188a3d0*/ <IE_Shot>d__65(int <>1__state);
        /*0x188b6e0*/ void System.IDisposable.Dispose();
        /*0x188b6e4*/ bool MoveNext();
        /*0x188b9b8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x188b9c0*/ void System.Collections.IEnumerator.Reset();
        /*0x188ba00*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_Wait>d__66 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game <>4__this;

        /*0x188a3f8*/ <IE_Wait>d__66(int <>1__state);
        /*0x188ba08*/ void System.IDisposable.Dispose();
        /*0x188ba0c*/ bool MoveNext();
        /*0x188bd0c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x188bd14*/ void System.Collections.IEnumerator.Reset();
        /*0x188bd54*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_WaitToIdle>d__67 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game <>4__this;

        /*0x188a420*/ <IE_WaitToIdle>d__67(int <>1__state);
        /*0x188bd5c*/ void System.IDisposable.Dispose();
        /*0x188bd60*/ bool MoveNext();
        /*0x188c014*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x188c01c*/ void System.Collections.IEnumerator.Reset();
        /*0x188c05c*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_Found>d__68 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game <>4__this;

        /*0x188a448*/ <IE_Found>d__68(int <>1__state);
        /*0x188c064*/ void System.IDisposable.Dispose();
        /*0x188c068*/ bool MoveNext();
        /*0x188c7e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x188c7f0*/ void System.Collections.IEnumerator.Reset();
        /*0x188c830*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_Initiate>d__69 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game <>4__this;

        /*0x188a470*/ <IE_Initiate>d__69(int <>1__state);
        /*0x188c838*/ void System.IDisposable.Dispose();
        /*0x188c83c*/ bool MoveNext();
        /*0x188d884*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x188d88c*/ void System.Collections.IEnumerator.Reset();
        /*0x188d8cc*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_Fight>d__70 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game <>4__this;

        /*0x188a498*/ <IE_Fight>d__70(int <>1__state);
        /*0x188d8d4*/ void System.IDisposable.Dispose();
        /*0x188d8d8*/ bool MoveNext();
        /*0x188e320*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x188e328*/ void System.Collections.IEnumerator.Reset();
        /*0x188e368*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_FightDone>d__71 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game <>4__this;

        /*0x188a4c0*/ <IE_FightDone>d__71(int <>1__state);
        /*0x188e370*/ void System.IDisposable.Dispose();
        /*0x188e374*/ bool MoveNext();
        /*0x188e724*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x188e72c*/ void System.Collections.IEnumerator.Reset();
        /*0x188e76c*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_Done>d__72 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game <>4__this;

        /*0x188a4e8*/ <IE_Done>d__72(int <>1__state);
        /*0x188e774*/ void System.IDisposable.Dispose();
        /*0x188e778*/ bool MoveNext();
        /*0x188ebf8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x188ec00*/ void System.Collections.IEnumerator.Reset();
        /*0x188ec40*/ object System.Collections.IEnumerator.get_Current();
    }
}

class game_automove : UnityEngine.MonoBehaviour
{
    /*0x18*/ bool target_gem;
    /*0x19*/ bool target_mastery;
    /*0x1a*/ bool target_amber;
    /*0x1b*/ bool target_boss;
    /*0x1c*/ bool autoSell;
    /*0x20*/ game_automove.State state_now;

    /*0x188fee8*/ game_automove();
    /*0x188ec48*/ void Awake();
    /*0x188ed00*/ bool get_canUse_autoSell();
    /*0x188edd8*/ void Play(bool gem, bool mastery, bool amber, bool boss, bool autoSell, game_automove.State state);
    /*0x188ef64*/ void Stop();
    /*0x188f034*/ void Refresh_UI();
    /*0x188f304*/ void Set_Harbor(ref bool success);
    /*0x188f594*/ void Set_Amber(ref bool success);
    /*0x188f9cc*/ void Set_Boss(ref bool success);
    /*0x188f684*/ void Set_Mastery(ref bool success);
    /*0x188fba0*/ void Set_Gem(ref bool success);

    enum State
    {
        off = 0,
        near = 1,
        rare = 2,
    }

    class <>c
    {
        static /*0x0*/ game_automove.<> <>9;
        static /*0x8*/ System.Func<data_place_element, bool> <>9__13_0;
        static /*0x10*/ System.Func<data_place_element, float> <>9__13_1;
        static /*0x18*/ System.Func<data_place_element, bool> <>9__15_0;
        static /*0x20*/ System.Func<data_place_element, bool> <>9__16_0;
        static /*0x28*/ System.Func<data_place_element, float> <>9__16_1;
        static /*0x30*/ System.Func<data_place_element, int> <>9__16_2;
        static /*0x38*/ System.Func<data_place_element, bool> <>9__17_0;
        static /*0x40*/ System.Func<data_place_element, float> <>9__17_1;
        static /*0x48*/ System.Func<data_place_element, int> <>9__17_2;

        static /*0x188fef0*/ <>c();
        /*0x188ff54*/ <>c();
        /*0x188ff5c*/ bool <Set_Harbor>b__13_0(data_place_element place);
        /*0x188ff88*/ float <Set_Harbor>b__13_1(data_place_element place);
        /*0x18900d8*/ bool <Set_Boss>b__15_0(data_place_element item);
        /*0x189010c*/ bool <Set_Mastery>b__16_0(data_place_element item);
        /*0x18901a8*/ float <Set_Mastery>b__16_1(data_place_element item);
        /*0x18902f8*/ int <Set_Mastery>b__16_2(data_place_element item);
        /*0x1890364*/ bool <Set_Gem>b__17_0(data_place_element item);
        /*0x189047c*/ float <Set_Gem>b__17_1(data_place_element item);
        /*0x18905cc*/ int <Set_Gem>b__17_2(data_place_element item);
    }
}

class game_balloon : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler
{
    static float COOLTIME = 40;
    static float TIME_ROAM = 60;
    /*0x18*/ UnityEngine.Animator myAnim;
    /*0x20*/ UnityEngine.GameObject[] icons;
    /*0x28*/ UnityEngine.Transform pos_effect;
    /*0x30*/ UnityEngine.BoxCollider myCollider;
    /*0x38*/ UnityEngine.Vector3 pos_target;
    /*0x44*/ game_balloon.State _state_now;
    /*0x48*/ float speed;
    /*0x4c*/ float pos_start;
    /*0x50*/ float pos_end;
    /*0x54*/ float pos_roam_min;
    /*0x58*/ float pos_roam_max;
    /*0x5c*/ bool pause;
    /*0x60*/ System.Collections.IEnumerator cor;
    /*0x68*/ UnityEngine.Events.UnityEvent OnAutoActivated;
    /*0x70*/ float <cooltime_auto>k__BackingField;

    /*0x1890fdc*/ game_balloon();
    /*0x1890638*/ void Awake();
    /*0x1890710*/ void Refresh_init();
    /*0x1890808*/ void Set_Icon(game_balloon.State state);
    /*0x1890888*/ game_balloon.State get_state_now();
    /*0x1890890*/ void set_state_now(game_balloon.State value);
    /*0x1890758*/ void Reset();
    /*0x1890904*/ bool MoveTo();
    /*0x18907a0*/ System.Collections.IEnumerator IE_Play();
    /*0x1890acc*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x1890ad0*/ void Reward();
    /*0x1890eb0*/ float get_cooltime_auto();
    /*0x1890eb8*/ void set_cooltime_auto(float value);
    /*0x1890ec0*/ void Update();

    enum State
    {
        gold = 0,
        mana = 1,
        disabled = 2,
    }

    class <IE_Play>d__24 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game_balloon <>4__this;
        /*0x28*/ float <time_left>5__2;

        /*0x18b3854*/ <IE_Play>d__24(int <>1__state);
        /*0x18b387c*/ void System.IDisposable.Dispose();
        /*0x18b3880*/ bool MoveNext();
        /*0x18b3db8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x18b3dc0*/ void System.Collections.IEnumerator.Reset();
        /*0x18b3e00*/ object System.Collections.IEnumerator.get_Current();
    }
}

class game_character : UnityEngine.MonoBehaviour
{
    static float RAMPAGE_TIME = 180;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt <rampage_lv>k__BackingField;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat <rampage_time>k__BackingField;
    /*0x40*/ bool autofight;

    /*0x18b44a0*/ game_character();
    /*0x18b3e08*/ void Awake();
    /*0x18b3ec0*/ void Refresher_Init();
    /*0x18b3f74*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_rampage_lv();
    /*0x18b3f80*/ void set_rampage_lv(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
    /*0x18b3f88*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat get_rampage_time();
    /*0x18b3f9c*/ void set_rampage_time(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat value);
    /*0x18b3fb0*/ void Add_rampage();
    /*0x18b417c*/ void Update();
    /*0x18b4338*/ bool get_autofight_enabled();
    /*0x18b4410*/ void Set_autofight(bool on);
}

class game_fish : UnityEngine.MonoBehaviour
{
    static float TIME_LEGEND_BONUS_MAX = 60;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool <rank_add>k__BackingField;
    /*0x24*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt <lv>k__BackingField;
    /*0x38*/ data_fish_element <fish>k__BackingField;
    /*0x40*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat <time>k__BackingField;
    /*0x58*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble <life>k__BackingField;
    /*0x78*/ data_place_element <now_place>k__BackingField;
    /*0x80*/ data_hidden_element <now_hidden>k__BackingField;
    /*0x88*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool <canAuto>k__BackingField;
    /*0x98*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat time_legend_bonus;

    /*0x18b9c50*/ game_fish();
    /*0x18b44a8*/ void Awake();
    /*0x18b4560*/ void Refresh_Init();
    /*0x18b46a0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_rank_add();
    /*0x18b46b0*/ void set_rank_add(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value);
    /*0x18b46bc*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_lv();
    /*0x18b46cc*/ void set_lv(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
    /*0x18b46d8*/ data_fish_element get_fish();
    /*0x18b46e0*/ void set_fish(data_fish_element value);
    /*0x18b46e8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat get_time();
    /*0x18b46fc*/ void set_time(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat value);
    /*0x18b4710*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble get_life();
    /*0x18b4720*/ void set_life(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble value);
    /*0x18b4730*/ data_place_element get_now_place();
    /*0x18b4738*/ void set_now_place(data_place_element value);
    /*0x18b4740*/ data_hidden_element get_now_hidden();
    /*0x18b4748*/ void set_now_hidden(data_hidden_element value);
    /*0x18b4750*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_canAuto();
    /*0x18b4760*/ void set_canAuto(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value);
    /*0x18b476c*/ void Update();
    /*0x18b4874*/ void Set_Fish(float charge);
    /*0x18b5cd8*/ void Finish_Fish(bool success);
    /*0x18b4564*/ void Reset_Fish();

    class <>c
    {
        static /*0x0*/ game_fish.<> <>9;
        static /*0x8*/ System.Func<data_fish_element, bool> <>9__37_0;

        static /*0x18b9c58*/ <>c();
        /*0x18b9cbc*/ <>c();
        /*0x18b9cc4*/ bool <Set_Fish>b__37_0(data_fish_element normals);
    }
}

class game_fish_infinite : UnityEngine.MonoBehaviour
{
    static double LV_MULT = 1.0007;
    /*0x18*/ int rate_now;
    /*0x20*/ double life_target_rate_before;
    /*0x28*/ double life_target_rate;
    /*0x30*/ int lv_now;
    /*0x38*/ double life_target_lv;
    /*0x40*/ System.Collections.IEnumerator cor;

    /*0x18b9e70*/ game_fish_infinite();
    /*0x18b9da0*/ void Play();
    /*0x18b9de0*/ System.Collections.IEnumerator IE_Play();

    class <IE_Play>d__8 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game_fish_infinite <>4__this;

        /*0x18b9e48*/ <IE_Play>d__8(int <>1__state);
        /*0x18b9e78*/ void System.IDisposable.Dispose();
        /*0x18b9e7c*/ bool MoveNext();
        /*0x18ba084*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x18ba08c*/ void System.Collections.IEnumerator.Reset();
        /*0x18ba0cc*/ object System.Collections.IEnumerator.get_Current();
    }
}

class game_fish_legend : UnityEngine.MonoBehaviour
{
    static double LV_MULT = 1.0007;
    /*0x18*/ int rate_now;
    /*0x20*/ double life_target_rate_before;
    /*0x28*/ double life_target_rate;
    /*0x30*/ int lv_now;
    /*0x38*/ double life_target_lv;
    /*0x40*/ double amber_num;
    /*0x48*/ System.Collections.IEnumerator cor;

    /*0x18ba1a4*/ game_fish_legend();
    /*0x18ba0d4*/ void Play();
    /*0x18ba114*/ System.Collections.IEnumerator IE_Play();

    class <IE_Play>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game_fish_legend <>4__this;

        /*0x18ba17c*/ <IE_Play>d__9(int <>1__state);
        /*0x18ba1ac*/ void System.IDisposable.Dispose();
        /*0x18ba1b0*/ bool MoveNext();
        /*0x18ba514*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x18ba51c*/ void System.Collections.IEnumerator.Reset();
        /*0x18ba55c*/ object System.Collections.IEnumerator.get_Current();
    }
}

class game_helper : UnityEngine.MonoBehaviour
{
    /*0x18*/ int stat_charge_low;
    /*0x1c*/ int stat_hard;
    /*0x20*/ int stat_autoFail;
    /*0x24*/ int stat_needMove;
    /*0x28*/ data_tutorial_element tuto_charge_low;
    /*0x30*/ data_tutorial_element tuto_hard;
    /*0x38*/ data_tutorial_element tuto_autoFail;
    /*0x40*/ data_tutorial_element tuto_needMove;

    /*0x18ba7a0*/ game_helper();
    /*0x18ba564*/ data_tutorial_element get_tutorial_now();
    /*0x18ba5c0*/ void Show_Tutorial();
}

class game_input_esc : UnityEngine.MonoBehaviour
{
    /*0x18bab40*/ game_input_esc();
    /*0x18ba7a8*/ void Update();

    class <>c
    {
        static /*0x0*/ game_input_esc.<> <>9;
        static /*0x8*/ System.Action <>9__0_0;

        static /*0x18bab48*/ <>c();
        /*0x18babac*/ <>c();
        /*0x18babb4*/ void <Update>b__0_0();
    }
}

class game_input_touch : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler
{
    /*0x18*/ bool isTouching;

    /*0x18bae08*/ game_input_touch();
    /*0x18babbc*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x18bad14*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
}

class game_sonar : UnityEngine.MonoBehaviour
{
    static /*0x0*/ System.Action Refresh_Sonar;
    /*0x18*/ float time_sonar;
    /*0x1c*/ bool _isActive;
    /*0x20*/ float time_sonar_now;

    /*0x18baf7c*/ game_sonar();
    /*0x18b5bf4*/ bool get_isActive();
    /*0x18bae10*/ void set_isActive(bool value);
    /*0x18bae1c*/ void Awake();
    /*0x18bae28*/ void Update();
}

class game_turret : UnityEngine.MonoBehaviour
{
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt no;
    /*0x28*/ System.Action action_attack;
    /*0x30*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat crit_now;
    /*0x48*/ System.Collections.IEnumerator cor;

    /*0x18bb2dc*/ game_turret();
    /*0x18baf8c*/ void Awake();
    /*0x18bb044*/ void Refresh_Init();
    /*0x18bb0c4*/ void Init_Fight();
    /*0x18bb1bc*/ System.Collections.IEnumerator IE_fight();
    /*0x18bb24c*/ System.Collections.IEnumerator IE_attack();

    class <IE_fight>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game_turret <>4__this;
        /*0x28*/ float <wait_time>5__2;

        /*0x18bb224*/ <IE_fight>d__7(int <>1__state);
        /*0x18bb2e4*/ void System.IDisposable.Dispose();
        /*0x18bb2e8*/ bool MoveNext();
        /*0x18bb5d0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x18bb5d8*/ void System.Collections.IEnumerator.Reset();
        /*0x18bb618*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_attack>d__8 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ game_turret <>4__this;
        /*0x28*/ int <attack_times>5__2;
        /*0x30*/ double <dmg>5__3;

        /*0x18bb2b4*/ <IE_attack>d__8(int <>1__state);
        /*0x18bb620*/ void System.IDisposable.Dispose();
        /*0x18bb624*/ bool MoveNext();
        /*0x18bb994*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x18bb99c*/ void System.Collections.IEnumerator.Reset();
        /*0x18bb9dc*/ object System.Collections.IEnumerator.get_Current();
    }
}

class ConditionalEnumShowAttribute : UnityEngine.PropertyAttribute
{
    /*0x10*/ string ConditionalSourceField;
    /*0x18*/ bool HideInInspector;
    /*0x20*/ System.Enum[] targetEnums;

    /*0x18bb9e4*/ ConditionalEnumShowAttribute(string conditionalSourceField, object[] targetEnums);
    /*0x18bbbb0*/ ConditionalEnumShowAttribute(string conditionalSourceField, bool hideInInspector, object[] targetEnums);
    /*0x18bba5c*/ System.Enum[] castEnums(object[] enums);
}

class ConditionalHideAttribute : UnityEngine.PropertyAttribute
{
    /*0x10*/ string ConditionalSourceField;
    /*0x18*/ bool HideInInspector;

    /*0x18bbc34*/ ConditionalHideAttribute(string conditionalSourceField);
    /*0x18bbc9c*/ ConditionalHideAttribute(string conditionalSourceField, bool hideInInspector);
}

class ConditionalShowAttribute : UnityEngine.PropertyAttribute
{
    /*0x10*/ string ConditionalSourceField;
    /*0x18*/ bool HideInInspector;

    /*0x18bbd08*/ ConditionalShowAttribute(string conditionalSourceField);
    /*0x18bbd70*/ ConditionalShowAttribute(string conditionalSourceField, bool hideInInspector);
}

class godmod : UnityEngine.MonoBehaviour
{
    static /*0x0*/ godmod ins;
    /*0x18*/ string GPGS_ID;
    /*0x20*/ string GPGS_NICKNAME;
    /*0x28*/ float time_rate;
    /*0x2c*/ float _time_mult;
    /*0x30*/ float speed_rate;
    /*0x34*/ float _speed_mult;
    /*0x38*/ float haste_rate;
    /*0x3c*/ float _haste_mult;
    /*0x40*/ UnityEngine.GameObject ui_addon;
    /*0x48*/ bool block_unity_ads;
    /*0x49*/ bool <show_map_charge_time>k__BackingField;

    /*0x18bef1c*/ godmod();
    /*0x18bbddc*/ void Awake();
    /*0x18bbe9c*/ bool get_isGodmod();
    /*0x18bbf0c*/ void set_time_mult(float value);
    /*0x18bbf98*/ float get_time_mult();
    /*0x18bbfc8*/ void set_speed_mult(float value);
    /*0x18bc04c*/ float get_speed_mult();
    /*0x18bc07c*/ void set_haste_mult(float value);
    /*0x18bc130*/ float get_haste_mult();
    /*0x18bc160*/ void Set_Rank(int rank);
    /*0x18bc344*/ void Set_AllLvMax();
    /*0x18bc964*/ void Set_BaseLvMax();
    /*0x18bcb18*/ void Set_AllLvMax_Over();
    /*0x18bcce8*/ void Add_Currency(data_currency_element currency);
    /*0x18bd008*/ void Add_Currency_Event();
    /*0x18bd364*/ void Add_ItemRand();
    /*0x18bd3e8*/ void Remove_ItemAll();
    /*0x18bd46c*/ void Admob_off();
    /*0x18bd4f0*/ void Admon_on();
    /*0x18bd588*/ void Set_AllFish();
    /*0x18bd648*/ void Set_AllSkin();
    /*0x18bd708*/ void Set_AllCraft();
    /*0x18bdad0*/ void Hide_AddonUI();
    /*0x18bdb6c*/ void Fish_OnePunch();
    /*0x18bdc04*/ void Quest_Dond(data_quest_element quest);
    /*0x18bdc9c*/ void Quest_All();
    /*0x18bdd20*/ void Show_Ads();
    /*0x18bddb8*/ void Block_Unity_Ads_Clicked();
    /*0x18bde30*/ void Reset_Data();
    /*0x18bdfec*/ void Craft_Full();
    /*0x18be368*/ void Mastery_Max();
    /*0x18be7c8*/ bool is_mastery_max();
    /*0x18beab8*/ void Relic_Max();
    /*0x18bed68*/ bool is_relic_max();
    /*0x18beef0*/ bool get_show_map_charge_time();
    /*0x18beef8*/ void set_show_map_charge_time(bool value);
    /*0x18bef04*/ void Toggle_Show_Map_Charge_Time();
    /*0x18bef14*/ void reset_player_pref();

    class <>c
    {
        static /*0x0*/ godmod.<> <>9;
        static /*0x8*/ System.Func<data_events_element, bool> <>9__26_0;
        static /*0x10*/ System.Func<data_events_element, data_currency_element> <>9__26_1;
        static /*0x18*/ System.Action <>9__42_0;

        static /*0x18bef3c*/ <>c();
        /*0x18befa0*/ <>c();
        /*0x18befa8*/ bool <Add_Currency_Event>b__26_0(data_events_element events);
        /*0x18bf010*/ data_currency_element <Add_Currency_Event>b__26_1(data_events_element events);
        /*0x18bf028*/ void <Reset_Data>b__42_0();
    }
}

class InitializeUnityServices : UnityEngine.MonoBehaviour
{
    /*0x18*/ string environment;

    /*0x18bf1e4*/ InitializeUnityServices();
    /*0x18bf150*/ void Start();

    struct <Start>d__1 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
        /*0x38*/ InitializeUnityServices <>4__this;
        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

        /*0x18bf234*/ void MoveNext();
        /*0x18bf4ac*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }
}

class Main : UnityEngine.MonoBehaviour
{
    static /*0x0*/ Main ins;
    /*0x18*/ BuildHelper_Asset BuildOptions;
    /*0x20*/ bool ch_check_done;

    /*0x18bf730*/ Main();
    /*0x18bf4b8*/ void Awake();
    /*0x18bf578*/ void Start();
    /*0x18bf60c*/ System.Collections.IEnumerator IE_Start();
    /*0x18bf69c*/ void IOS_PopupAdTracking();
    /*0x18bf6a0*/ System.Collections.IEnumerator CH_Check();
    /*0x18bf738*/ void <CH_Check>b__7_0();

    struct <Start>d__3 : System.Runtime.CompilerServices.IAsyncStateMachine
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ System.Runtime.CompilerServices.AsyncVoidMethodBuilder <>t__builder;
        /*0x38*/ Main <>4__this;
        /*0x40*/ System.Runtime.CompilerServices.TaskAwaiter <>u__1;

        /*0x18bf7e0*/ void MoveNext();
        /*0x18bfba4*/ void SetStateMachine(System.Runtime.CompilerServices.IAsyncStateMachine stateMachine);
    }

    class <IE_Start>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Main <>4__this;

        /*0x18bf674*/ <IE_Start>d__4(int <>1__state);
        /*0x18bfbb0*/ void System.IDisposable.Dispose();
        /*0x18bfbb4*/ bool MoveNext();
        /*0x18c0054*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x18c005c*/ void System.Collections.IEnumerator.Reset();
        /*0x18c009c*/ object System.Collections.IEnumerator.get_Current();
    }

    class <CH_Check>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Main <>4__this;

        /*0x18bf708*/ <CH_Check>d__7(int <>1__state);
        /*0x18c00a4*/ void System.IDisposable.Dispose();
        /*0x18c00a8*/ bool MoveNext();
        /*0x18c0264*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x18c026c*/ void System.Collections.IEnumerator.Reset();
        /*0x18c02ac*/ object System.Collections.IEnumerator.get_Current();
    }
}

class map : UnityEngine.MonoBehaviour
{
    static /*0x0*/ map ins;
    /*0x18*/ UnityEngine.GameObject prefab_map_place;
    /*0x20*/ UnityEngine.GameObject prefab_map_hidden;
    /*0x28*/ UnityEngine.Transform parent_place;
    /*0x30*/ UnityEngine.Transform parent_hidden;
    /*0x38*/ SimplePool<data_place_element> pool_place;
    /*0x40*/ SimplePool<data_hidden_element> pool_hidden;
    /*0x48*/ map.State _state;

    /*0x18c05b0*/ map();
    /*0x18c02b4*/ void Awake();
    /*0x18c0420*/ void Start();
    /*0x18c04a0*/ void Refresh_Hidden();
    /*0x18c0520*/ void set_state(map.State value);
    /*0x18c05a8*/ map.State get_state();

    enum State
    {
        normal = 0,
        portal = 1,
    }
}

class map_background : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.RectTransform _rectTransform;
    /*0x20*/ UnityEngine.Vector3[] _corners;
    /*0x28*/ System.Collections.Generic.IEnumerable<float> _poses;
    /*0x30*/ UnityEngine.UI.RawImage _rawImage;
    /*0x38*/ data_place_element place;
    /*0x40*/ Dimension_Type target_Dimension;

    /*0x18c09e0*/ map_background();
    /*0x18c05b8*/ UnityEngine.RectTransform get_rectTransform();
    /*0x18c064c*/ UnityEngine.Vector3[] get_corners();
    /*0x18c06c4*/ System.Collections.Generic.IEnumerable<float> get_poses();
    /*0x18c07e0*/ UnityEngine.UI.RawImage get_rawImage();
    /*0x18c0874*/ bool get_visible();

    class <>c
    {
        static /*0x0*/ map_background.<> <>9;
        static /*0x8*/ System.Func<UnityEngine.Vector3, float> <>9__8_0;

        static /*0x18c09e8*/ <>c();
        /*0x18c0a4c*/ <>c();
        /*0x18c0a54*/ float <get_poses>b__8_0(UnityEngine.Vector3 corner);
    }
}

class map_player : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.LineRenderer myLine;
    /*0x20*/ UnityEngine.GameObject obj_moving;
    /*0x28*/ UnityEngine.Vector3 pos_player;
    /*0x34*/ UnityEngine.Vector3 pos_target;
    /*0x40*/ UnityEngine.Vector3 offset;
    /*0x50*/ UnityEngine.Transform transform_sonar;
    /*0x58*/ UnityEngine.Animator animator;
    /*0x60*/ UnityEngine.UI.Image img_reach;

    /*0x18c1028*/ map_player();
    /*0x18c0a58*/ void Awake();
    /*0x18c0bf4*/ void Update();
    /*0x18c0ea8*/ void Refresh_Sonar();
    /*0x18c0f04*/ void Refresh_UI();
}

class player : UnityEngine.MonoBehaviour
{
    static string EMAIL_FOR_PAYMENTWALL = "emailForPaymentwall";
    static /*0x0*/ player ins;
    static /*0x8*/ bool <isLoaded>k__BackingField;
    /*0x18*/ player_dimension dimension;
    /*0x20*/ player_time time;
    /*0x28*/ player_character character;
    /*0x30*/ player_pet pet;
    /*0x38*/ player_inven inven;
    /*0x40*/ player_ship ship;
    /*0x48*/ player_turret[] turret;
    /*0x50*/ player_skin skin;
    /*0x58*/ player_skill skill;
    /*0x60*/ player_currency currency;
    /*0x68*/ player_place place;
    /*0x70*/ player_fish fish;
    /*0x78*/ player_record record;
    /*0x80*/ player_setting setting;
    /*0x88*/ player_mastery mastery;
    /*0x90*/ player_relic relic;
    /*0x98*/ player_enhance enhance;
    /*0xa0*/ player_quest quest;
    /*0xa8*/ player_quest_group quest_group;
    /*0xb0*/ player_www www;
    /*0xb8*/ player_iap iap;
    /*0xc0*/ player_mail mail;
    /*0xc8*/ player_hidden hidden;
    /*0xd0*/ player_farm farm;
    /*0xd8*/ player_craft craft;
    /*0xe0*/ player_cutscene cutscene;
    /*0xe8*/ player_status status;
    /*0xf0*/ player.share_state sharestate;
    /*0xf4*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool isCheated;
    /*0x100*/ SimpleJSON_Ex.JSONNode json;

    static /*0x18c17a0*/ bool get_isLoaded();
    static /*0x18c17e8*/ void set_isLoaded(bool value);
    /*0x18c19ac*/ player();
    /*0x18c1048*/ void Awake();
    /*0x18c1424*/ void OnApplicationQuit();
    /*0x18c170c*/ void OnApplicationPause(bool pause);
    /*0x18c1364*/ void Awake_Ins();
    /*0x18c1710*/ string get_player_data();
    /*0x18c1428*/ void Save();
    /*0x18bfd40*/ void Load();
    /*0x18bf078*/ void Reset();
    /*0x18c1834*/ void LoadCloud(string data);
    /*0x18c18ec*/ string loadEmail();
    /*0x18c1960*/ void saveEmail(string strEmail);

    enum share_state
    {
        before_share = 0,
        share_cancelled = 1,
        shared = 2,
    }
}

class player_character : UnityEngine.MonoBehaviour
{
    /*0x18*/ player_character.info info_base;
    /*0x20*/ player_character.info info_parallel;

    /*0x18c35d8*/ player_character();
    /*0x18b3d50*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_rank();
    /*0x18c1adc*/ void set_rank(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
    /*0x18b8ddc*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_lv();
    /*0x18c1b08*/ void set_lv(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
    /*0x18c1b34*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_rod_lv();
    /*0x18c1b54*/ void set_rod_lv(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
    /*0x18c1b80*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat get_exp();
    /*0x18c1bac*/ void set_exp(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat value);
    /*0x18b3d34*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_base_rank();
    /*0x18c1bf0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_base_lv();
    /*0x18c1c0c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_base_rod_lv();
    /*0x18c1c28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat get_base_exp();
    /*0x18c1c50*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_parallel_rank();
    /*0x18c1c6c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_parallel_lv();
    /*0x18c1c88*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_parallel_rod_lv();
    /*0x18c1ca4*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat get_parallel_exp();
    /*0x18c1a44*/ player_character.info get_current_info();
    /*0x18c1d4c*/ void Awake();
    /*0x18c1eb4*/ void Save();
    /*0x18c1f24*/ void save_info_class(player_character.info target, string key);
    /*0x18c2254*/ void Load();
    /*0x18c23f4*/ void load_info_class(player_character.info target, string key);
    /*0x18c28c4*/ void reset_parallel_character();
    /*0x18c28ec*/ double get_dps_total();
    /*0x18c2980*/ double get_dps_character();
    /*0x18c2a74*/ double dps_rod(int rodLv);
    /*0x18c2b2c*/ float dps_rod_mult(int rodLv);
    /*0x18c2c64*/ float get_exp_need();
    /*0x18c2cf0*/ bool get_rod_canUpgrade();
    /*0x18b8dfc*/ void Add_Exp(float exp_input);
    /*0x18c3100*/ void rod_Upgrade();
    /*0x18c3488*/ void Set_Skin_hat();
    /*0x18c351c*/ void Set_Skin_rod();
    /*0x18b96b8*/ void Add_Rank();
    /*0x18c2f24*/ void Add_Lv();
    /*0x18bc1f4*/ void Godmod_Set_Rank(int rank);
    /*0x18bc514*/ void Godmod_Set_Lv_Max();
    /*0x18bc690*/ void Godmod_Rod_Max();

    class info
    {
        /*0x10*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt rank;
        /*0x20*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt lv;
        /*0x30*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt rod_lv;
        /*0x40*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat exp;

        /*0x18c1eac*/ info();
        /*0x18c22f8*/ void set(int rank, int lv, int rod_lv, float exp);
    }
}

class player_craft : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<player_craft_element> elements;

    /*0x18c4218*/ player_craft();
    /*0x18c35e0*/ void Awake();
    /*0x18c36f4*/ void Load();
    /*0x18c3bd4*/ void Save();
    /*0x18be1a0*/ player_craft_element Get_element(data_craft_element element);
    /*0x18c3f64*/ player_craft_element Get_element(string name);
    /*0x18c4060*/ int Get_level_sum(System.Collections.Generic.List<data_craft_element> list);
    /*0x18bd7c4*/ void Godmod_All();

    class <>c__DisplayClass4_0
    {
        /*0x10*/ data_craft_element element;

        /*0x18c3f5c*/ <>c__DisplayClass4_0();
        /*0x18c4220*/ bool <Get_element>b__0(player_craft_element el);
    }

    class <>c__DisplayClass5_0
    {
        /*0x10*/ string name;

        /*0x18c4058*/ <>c__DisplayClass5_0();
        /*0x18c4290*/ bool <Get_element>b__0(player_craft_element el);
    }

    class <>c__DisplayClass6_0
    {
        /*0x10*/ System.Collections.Generic.List<data_craft_element> list;

        /*0x18c4210*/ <>c__DisplayClass6_0();
        /*0x18c42c0*/ bool <Get_level_sum>b__0(player_craft_element element);
    }

    class <>c
    {
        static /*0x0*/ player_craft.<> <>9;
        static /*0x8*/ System.Func<player_craft_element, int> <>9__6_1;

        static /*0x18c431c*/ <>c();
        /*0x18c4380*/ <>c();
        /*0x18c4388*/ int <Get_level_sum>b__6_1(player_craft_element element);
    }
}

class player_craft_element
{
    /*0x10*/ data_craft_element element;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt lv;
    /*0x28*/ ItemNumPair_List items;

    /*0x18c3a20*/ player_craft_element(data_craft_element data, SimpleJSON_Ex.JSONNode json);
    /*0x18c3e34*/ SimpleJSON_Ex.JSONNode toJson();
    /*0x18c43f0*/ bool Need_item(data_item_element item);
    /*0x18c4528*/ void Add_item(data_item_element item);
    /*0x18c461c*/ void Done();
    /*0x18c4734*/ bool get_isFull();
    /*0x18c499c*/ ItemNumPair_List Get_Needs();
    /*0x18c4a9c*/ System.Collections.Generic.List<ItemNeedOwnPair> Get_NeedOwnPairs(ref float rate);
    /*0x18be294*/ void Godmod_Full();
}

class player_currency : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.Dictionary<string, player_currency_element> dic;

    /*0x18c7108*/ player_currency();
    /*0x18c4de4*/ void Awake();
    /*0x18b9364*/ player_currency_element Get_dic(string name);
    /*0x18b9028*/ player_currency_element get_gold();
    /*0x18c5068*/ player_currency_element get_gem();
    /*0x18c50b0*/ player_currency_element get_diamond();
    /*0x18c50f8*/ player_currency_element get_potion();
    /*0x18b3d70*/ player_currency_element get_mana();
    /*0x18c5140*/ player_currency_element get_mastery();
    /*0x18b9670*/ player_currency_element get_amber();
    /*0x18b9b9c*/ player_currency_element get_dimension();
    /*0x18c5188*/ player_currency_element get_autosell();
    /*0x18b931c*/ player_currency_element get_trace();
    /*0x18b92d4*/ player_currency_element get_essence();
    /*0x18c51d0*/ player_currency_element get_vip();
    /*0x18c4ef8*/ player_currency_element get_currency(string key);
    /*0x18c5218*/ void Load();
    /*0x18c54b4*/ void add_currency_to_dic(string key);
    /*0x18c578c*/ void add_parallel_currency_to_dic(string key);
    /*0x18c5ba0*/ void Save();
    /*0x18c5eb4*/ void reset_parallel_currency();
    /*0x18c61dc*/ bool Can_Add(CurNumPair pair);
    /*0x18c6348*/ void Add(CurNumPair pair, System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos);
    /*0x18c6424*/ void Add_Mail(CurNumPair pair, System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos, string overflow);
    /*0x18c66cc*/ bool Can_Adds(System.Collections.Generic.List<CurNumPair> list);
    /*0x18c681c*/ void Adds(System.Collections.Generic.List<CurNumPair> pair_list);
    /*0x18c682c*/ void Adds(System.Collections.Generic.List<CurNumPair> pair_list, System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos);
    /*0x18c6a3c*/ void Adds_Mail(System.Collections.Generic.List<CurNumPair> pair_list, System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos, string overflow);
    /*0x18c6c5c*/ bool Can_Use(CurNumPair pair);
    /*0x18c6d14*/ void Use(CurNumPair pair);
    /*0x18c6dc8*/ bool Can_Uses(System.Collections.Generic.List<CurNumPair> pair_list);
    /*0x18c6fcc*/ void Uses(System.Collections.Generic.List<CurNumPair> pair_list);
}

class player_currency_element
{
    /*0x10*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble <num>k__BackingField;
    /*0x30*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble <num_used>k__BackingField;
    /*0x50*/ data_currency_element <element>k__BackingField;

    /*0x18c5a8c*/ player_currency_element(string element_name, double num, double num_used);
    /*0x18c7184*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble get_num();
    /*0x18c7190*/ void set_num(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble value);
    /*0x18c719c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble get_num_used();
    /*0x18c71a8*/ void set_num_used(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble value);
    /*0x18c71b4*/ data_currency_element get_element();
    /*0x18c71bc*/ void set_element(data_currency_element value);
    /*0x18c6294*/ bool Can_Add(double num);
    /*0x18c71c4*/ void Add(double num);
    /*0x18b9070*/ void Add(double num, System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos);
    /*0x18c6508*/ void Add_Mail(double num, System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos, string overflow);
    /*0x18c2e70*/ bool Can_Use(double num);
    /*0x18b93dc*/ void Use(double num);
    /*0x18c6150*/ void Reset();
    /*0x18bce30*/ bool get_isFull();
    /*0x18c71d4*/ string toStringFormat(bool withIcon);
    /*0x18bcedc*/ void Godmod_GetMax();
    /*0x18c7270*/ void Godmod_RemoveAll();
}

class player_cutscene : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<data_cutscene_element> <list>k__BackingField;
    /*0x20*/ System.Action onCutsceneFinished;

    /*0x18c7c54*/ player_cutscene();
    /*0x18c7374*/ void Awake();
    /*0x18c7488*/ System.Collections.Generic.List<data_cutscene_element> get_list();
    /*0x18c7490*/ void set_list(System.Collections.Generic.List<data_cutscene_element> value);
    /*0x18c7498*/ void Load();
    /*0x18c7714*/ void Save();
    /*0x18b9c48*/ void Show(data_cutscene_element cutscene);
    /*0x18c7988*/ void Show(data_cutscene_element cutscene, System.Action action);
    /*0x18c7a8c*/ System.Collections.IEnumerator IE_Show(data_cutscene_element cutscene, System.Action action);
    /*0x18c7b30*/ System.Collections.IEnumerator IE_Finish();
    /*0x18c7bb8*/ void Godmod_Show(data_cutscene_element cutscene);

    class <>c__DisplayClass10_0
    {
        /*0x10*/ UnityEngine.GameObject obj_cutscene;
        /*0x18*/ player_cutscene <>4__this;
        /*0x20*/ data_cutscene_element cutscene;
        /*0x28*/ System.Action action;

        /*0x18c7c5c*/ <>c__DisplayClass10_0();
        /*0x18c7c64*/ void <IE_Show>b__0();
    }

    class <IE_Show>d__10 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ player_cutscene <>4__this;
        /*0x28*/ data_cutscene_element cutscene;
        /*0x30*/ System.Action action;
        /*0x38*/ player_cutscene.<> <>8__1;
        /*0x40*/ UnityEngine.UI.Image <fader>5__2;
        /*0x48*/ UnityEngine.Color <color_target>5__3;
        /*0x58*/ float <time>5__4;

        /*0x18c7b08*/ <IE_Show>d__10(int <>1__state);
        /*0x18c7db0*/ void System.IDisposable.Dispose();
        /*0x18c7db4*/ bool MoveNext();
        /*0x18c81a4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x18c81ac*/ void System.Collections.IEnumerator.Reset();
        /*0x18c81ec*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_Finish>d__11 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UnityEngine.UI.Image <fader>5__2;
        /*0x28*/ UnityEngine.Color <color_target>5__3;
        /*0x38*/ float <time>5__4;

        /*0x18c7b90*/ <IE_Finish>d__11(int <>1__state);
        /*0x18c81f4*/ void System.IDisposable.Dispose();
        /*0x18c81f8*/ bool MoveNext();
        /*0x18c8488*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x18c8490*/ void System.Collections.IEnumerator.Reset();
        /*0x18c84d0*/ object System.Collections.IEnumerator.get_Current();
    }
}

class player_dimension : UnityEngine.MonoBehaviour
{
    static int ANY_DIMENSION_DIFFICULTY = 0;
    static int MAX_DIFFICULTY = 8;
    static float fish_hp_mult_factor = 1.0002299547195435;
    /*0x18*/ int solid_current_dimension;
    /*0x20*/ System.Collections.Generic.List<Dimension_Difficulty_Unlock_Pair> difficulty_unlock_conditions;
    /*0x28*/ int current_dimension_difficulty;
    /*0x2c*/ int highest_cleared_dimension;
    /*0x30*/ System.Collections.Generic.Dictionary<int, int> dimension_cleared_count;
    /*0x38*/ bool <dimension_door_active>k__BackingField;
    /*0x3c*/ float dimension_currency_factor_a;
    /*0x40*/ float dimension_currency_factor_b;
    /*0x48*/ data_quest_element portal_quest_need;

    /*0x18c9ac0*/ player_dimension();
    /*0x18c84d8*/ int get_solid_other_dimension();
    /*0x18b9b4c*/ bool is_base_dimension(bool deceived_by_fake_dimension);
    /*0x18c84e8*/ bool is_in_target_dimension(Dimension_Type target, int target_dimension_difficulty);
    /*0x18c0960*/ bool is_in_target_dimension(Dimension_Type target, bool deceived_by_fake_dimension, int target_dimension_difficulty);
    /*0x18c84f4*/ int get_max_possible_difficulty();
    /*0x18c85d0*/ int get_dimension_cleared_count(int difficulty);
    /*0x18c1ccc*/ player_dimension.Dimension_State get_dimension_state();
    /*0x18c8664*/ bool get_dimension_door_active();
    /*0x18c866c*/ void set_dimension_door_active(bool value);
    /*0x18b5c6c*/ float get_fish_hp_mult(int lv);
    /*0x18b9be4*/ float get_dimension_currency_mult(int boss_fish_lv);
    /*0x18c8678*/ void Awake();
    /*0x18c878c*/ void Save();
    /*0x18c8d4c*/ void Load();
    /*0x18c9220*/ void move_dimension(int nextDimension);
    /*0x18c9228*/ void set_difficulty(int target_difficulty);
    /*0x18c9230*/ void init_parallel_infos();
    /*0x18c9398*/ void open_dimension_door(int target_difficulty);
    /*0x18c9418*/ void switch_dimension();
    /*0x18c9428*/ void moveto_parallel_dimension();
    /*0x18c94ec*/ void moveto_base_dimension();
    /*0x18c35b0*/ void clear_dimension();
    /*0x18c95ac*/ void add_clear_count();
    /*0x18c96f8*/ void onEnterFakeDimension();
    /*0x18c9774*/ void onExitFakeDimension();
    /*0x18c97f0*/ bool get_portal_unlocked();
    /*0x18c98bc*/ void enter_portal();
    /*0x18c992c*/ void open_portal();
    /*0x18c99f0*/ void lower_difficulty();
    /*0x18c968c*/ void close_portal();

    enum Dimension_State
    {
        Base = 0,
        Parallel = 1,
        Fake_Base = 2,
    }
}

class Dimension_Difficulty_Unlock_Pair
{
    /*0x10*/ int difficulty;
    /*0x18*/ DimensionalConditionChecker conditionChecker;

    /*0x18c9ad4*/ Dimension_Difficulty_Unlock_Pair();
}

class player_enhance : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<player_enhance_element> <list>k__BackingField;

    /*0x18ca398*/ player_enhance();
    /*0x18c9adc*/ void Awake();
    /*0x18c9bf0*/ System.Collections.Generic.List<player_enhance_element> get_list();
    /*0x18c9bf8*/ void set_list(System.Collections.Generic.List<player_enhance_element> value);
    /*0x18c9c00*/ void Load();
    /*0x18c9f30*/ void Save();
    /*0x18ca194*/ float Get_stat_now(data_enhance_element element);
    /*0x18c2c48*/ float Get_stat_now(string element);
    /*0x18ca1b0*/ player_enhance_element Get_element(data_enhance_element element);
    /*0x18ca2a4*/ player_enhance_element Get_element(string name);
    /*0x18bc778*/ void Godmod_AllMax();

    class <>c__DisplayClass9_0
    {
        /*0x10*/ data_enhance_element element;

        /*0x1ba5d0c*/ <>c__DisplayClass9_0();
        /*0x1ba5d14*/ bool <Get_element>b__0(player_enhance_element el);
    }

    class <>c__DisplayClass10_0
    {
        /*0x10*/ string name;

        /*0x1ba5d84*/ <>c__DisplayClass10_0();
        /*0x1ba5d8c*/ bool <Get_element>b__0(player_enhance_element el);
    }
}

class player_enhance_element
{
    /*0x10*/ data_enhance_element <element>k__BackingField;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt lv;

    /*0x1ba5dcc*/ player_enhance_element(data_enhance_element data, SimpleJSON_Ex.JSONNode json);
    /*0x1ba5dbc*/ data_enhance_element get_element();
    /*0x1ba5dc4*/ void set_element(data_enhance_element value);
    /*0x1ba5edc*/ SimpleJSON_Ex.JSONNode toJson();
    /*0x1ba5fc8*/ bool get_isLvMax();
    /*0x1ba6054*/ CurNumPair get_Upgrade_need();
    /*0x1ba60e0*/ void Upgrade();
    /*0x1ba62a8*/ CurNumPair get_Refund_need();
    /*0x1ba6334*/ void Refund();
    /*0x1ba6528*/ float Get_stat_now();
    /*0x1ba65b4*/ string Get_Stat_Info();
}

class player_farm : UnityEngine.MonoBehaviour
{
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble time_gold;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble time_portal;
    /*0x58*/ data_craft_element craft;
    /*0x60*/ System.Collections.Generic.Dictionary<data_farm.Type, data_farm_element> selected;

    /*0x1ba9054*/ player_farm();
    /*0x1ba672c*/ void Awake();
    /*0x1ba6840*/ void Load();
    /*0x1ba719c*/ void Save();
    /*0x1ba7924*/ int Get_level_sum(data_farm.Type type);
    /*0x1ba7b50*/ float Get_status_sum(data_farm.Type type);
    /*0x1ba7c44*/ string Get_status_sum_text(data_farm.Type type);
    /*0x1ba7df4*/ int Get_level(data_farm_element element);
    /*0x1ba7eac*/ float Get_status(data_farm_element element);
    /*0x1ba7fa4*/ string Get_status_text(data_farm_element element);
    /*0x1ba8104*/ bool get_portal_isReady();
    /*0x1ba8284*/ double get_portal_time_left();
    /*0x1ba81e4*/ double get_portal_time_cool();
    /*0x1ba8360*/ void portal_use();
    /*0x1ba83d8*/ bool get_reward_canGet();
    /*0x1ba84f4*/ bool get_reward_isFull();
    /*0x1ba85d4*/ double get_reward_time_max();
    /*0x1ba8698*/ double get_reward_time_need();
    /*0x1ba877c*/ void Get_reward(System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos);
    /*0x1ba8d18*/ void Set_selected(data_farm_element element);
    /*0x1ba8e7c*/ UnityEngine.GameObject Get_selected_prefab(data_farm.Type type);
    /*0x1ba8f80*/ string Get_selected_name(data_farm.Type type);

    class <>c__DisplayClass7_0
    {
        /*0x10*/ data_farm.Type type;

        /*0x1ba7b48*/ <>c__DisplayClass7_0();
        /*0x1ba90d0*/ bool <Get_level_sum>b__0(data_farm_element element);
    }

    class <>c
    {
        static /*0x0*/ player_farm.<> <>9;
        static /*0x8*/ System.Func<data_farm_element, data_craft_element> <>9__7_1;

        static /*0x1ba90f4*/ <>c();
        /*0x1ba9158*/ <>c();
        /*0x1ba9160*/ data_craft_element <Get_level_sum>b__7_1(data_farm_element element);
    }
}

class player_fish : UnityEngine.MonoBehaviour
{
    static string DIMENSION_BASE = "base";
    static string DIMENSION_PARALLEL = "parallel";
    /*0x18*/ System.Collections.Generic.Dictionary<data_fish_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> dic_base;
    /*0x20*/ System.Collections.Generic.Dictionary<data_fish_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> dic_parallel;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt <bestRecord_base>k__BackingField;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt <bestRecord_parallel>k__BackingField;

    /*0x1bab550*/ player_fish();
    /*0x1ba9178*/ void Awake();
    /*0x1ba928c*/ System.Collections.Generic.Dictionary<data_fish_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> get_dic();
    /*0x1ba9304*/ System.Collections.Generic.List<string> get_Achievement_Fishes();
    /*0x1ba93c8*/ System.Collections.Generic.List<string> get_achievement_fishes(System.Collections.Generic.Dictionary<data_fish_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> dict_to_check);
    /*0x1ba8c70*/ int get_bestRecord();
    /*0x1ba96d8*/ void set_bestRecord(int value);
    /*0x1ba979c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_bestRecord_base();
    /*0x1ba97a8*/ void set_bestRecord_base(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
    /*0x1ba97b0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_bestRecord_parallel();
    /*0x1ba97bc*/ void set_bestRecord_parallel(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
    /*0x1ba97c4*/ void Save();
    /*0x1ba97dc*/ void save_base();
    /*0x1ba9824*/ void save_parallel();
    /*0x1ba986c*/ void save_by_key(System.Collections.Generic.Dictionary<data_fish_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> target_dict, string dimension_key);
    /*0x1ba9b78*/ void Load();
    /*0x1ba9fd8*/ void reset_parallel_fish();
    /*0x1ba9b98*/ void load_base();
    /*0x1ba9c28*/ void load_parallel();
    /*0x1baa060*/ void load_by_key(System.Collections.Generic.Dictionary<data_fish_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> target_dict, string dimension_key);
    /*0x1ba9cb8*/ void load_bestRecord();
    /*0x1baa5a8*/ void Add_fish(data_fish_element fish, int lv, bool show_popup);
    /*0x1baabbc*/ bool Auto_Success(data_fish_element fish, int lv);
    /*0x1baae28*/ bool isNew(data_fish_element fish);
    /*0x1baaf04*/ int get_fish_bestrecord(string fish_name);
    /*0x1bab07c*/ void Godmod_AllFish();
    /*0x1bab340*/ void Godmod_Add_fish(data_fish_element fish, int lv);

    class <>c
    {
        static /*0x0*/ player_fish.<> <>9;
        static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<data_fish_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>, int> <>9__30_0;
        static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<data_fish_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> <>9__30_1;
        static /*0x18*/ System.Func<System.Collections.Generic.KeyValuePair<data_fish_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>, int> <>9__30_2;
        static /*0x20*/ System.Func<System.Collections.Generic.KeyValuePair<data_fish_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> <>9__30_3;

        static /*0x1bab558*/ <>c();
        /*0x1bab5bc*/ <>c();
        /*0x1bab5c4*/ int <load_bestRecord>b__30_0(System.Collections.Generic.KeyValuePair<data_fish_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> value);
        /*0x1bab630*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt <load_bestRecord>b__30_1(System.Collections.Generic.KeyValuePair<data_fish_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> value);
        /*0x1bab66c*/ int <load_bestRecord>b__30_2(System.Collections.Generic.KeyValuePair<data_fish_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> value);
        /*0x1bab6d8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt <load_bestRecord>b__30_3(System.Collections.Generic.KeyValuePair<data_fish_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> value);
    }
}

class player_hidden : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<data_hidden_element> <elements>k__BackingField;
    /*0x20*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat <rand>k__BackingField;

    /*0x1bacbdc*/ player_hidden();
    /*0x1bab714*/ void Awake();
    /*0x1bab8c4*/ System.Collections.Generic.List<data_hidden_element> get_elements();
    /*0x1bab8cc*/ void set_elements(System.Collections.Generic.List<data_hidden_element> value);
    /*0x1bab8d4*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat get_rand();
    /*0x1bab8e8*/ void set_rand(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat value);
    /*0x1bab8fc*/ void Load();
    /*0x1babcd4*/ void Save();
    /*0x1bac060*/ void Initiate();
    /*0x1bac1f4*/ void Use_element(data_hidden_element element);
    /*0x1bac064*/ void Set_elements();
    /*0x1bac2c0*/ void Set_elements(data_hidden_group group);
    /*0x1bac724*/ System.Collections.Generic.List<data_hidden_element> Get_elements_inReach();
    /*0x1bac850*/ System.Collections.Generic.List<data_hidden_element> Get_elements_inSight();
    /*0x1bac97c*/ float Get_Distance(data_hidden_element element);
    /*0x1bacb5c*/ bool Get_isInSight(data_hidden_element element);

    class <>c__DisplayClass14_0
    {
        /*0x10*/ data_hidden_group group;

        /*0x1bac71c*/ <>c__DisplayClass14_0();
        /*0x1bacbe4*/ bool <Set_elements>b__0(data_hidden_element el);
    }

    class <>c__DisplayClass15_0
    {
        /*0x10*/ float distance;

        /*0x1bac848*/ <>c__DisplayClass15_0();
        /*0x1bacc54*/ bool <Get_elements_inReach>b__0(data_hidden_element el);
    }

    class <>c__DisplayClass16_0
    {
        /*0x10*/ float distance;

        /*0x1bac974*/ <>c__DisplayClass16_0();
        /*0x1bacdb0*/ bool <Get_elements_inSight>b__0(data_hidden_element el);
    }
}

class player_iap : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<player_iap_element> purchased;
    /*0x20*/ System.Collections.Generic.List<player_iap.VerifyInfo> <verifyInfos>k__BackingField;

    /*0x1bae204*/ player_iap();
    /*0x1bacf0c*/ void Awake();
    /*0x1bad068*/ System.Collections.Generic.List<player_iap.VerifyInfo> get_verifyInfos();
    /*0x1bad070*/ void set_verifyInfos(System.Collections.Generic.List<player_iap.VerifyInfo> value);
    /*0x1bad078*/ void Load();
    /*0x1bad7c0*/ void Save();
    /*0x1badd34*/ bool bought_item(data_iap_element iap_data);
    /*0x1baded8*/ void add_verifyinfo_xsolla(string payload);
    /*0x1bae0dc*/ void remove_verifyinfo_xsolla(string payload);
    /*0x1bae02c*/ int verifyinfos_contains_payload(string payload);
    /*0x1bae154*/ int verifyinfos_contains_receipt(string receipt);

    class VerifyInfo
    {
        /*0x10*/ string payload;
        /*0x18*/ string product_id;
        /*0x20*/ string receipt;

        /*0x1bad734*/ VerifyInfo(string payload, string product_id, string receipt);
        /*0x1bae280*/ data_iap_element get_product();
    }
}

class player_iap_element
{
    /*0x10*/ data_iap_element <iap_data>k__BackingField;
    /*0x18*/ bool rewarded;

    /*0x1bad704*/ player_iap_element(data_iap_element iap_data, bool rewarded);
    /*0x1bae308*/ data_iap_element get_iap_data();
    /*0x1bae310*/ void set_iap_data(data_iap_element value);
}

class player_inven : UnityEngine.MonoBehaviour
{
    static int SIZE_BASE = 6;
    /*0x18*/ System.Collections.Generic.List<player_inven_element> <item_list>k__BackingField;
    /*0x20*/ bool autolock;

    /*0x1bb1b08*/ player_inven();
    /*0x1bae318*/ void Awake();
    /*0x1bae42c*/ System.Collections.Generic.List<player_inven_element> get_item_list();
    /*0x1bae434*/ void set_item_list(System.Collections.Generic.List<player_inven_element> value);
    /*0x1bae43c*/ int get_size_max();
    /*0x1bae510*/ bool get_isFull();
    /*0x1bae564*/ int get_stack_max();
    /*0x1bae630*/ void Load();
    /*0x1baeaf0*/ void Save();
    /*0x1baee20*/ void Add(data_item_element item_add, System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos);
    /*0x1baf2a4*/ void Sell(player_inven_element item, System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos);
    /*0x1bb03c4*/ void Sell_All_Button_Clicked(System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos);
    /*0x1bb0dd0*/ void Sell_All_Autosell(System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos);
    /*0x1bb0460*/ bool Sell_All(System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos);
    /*0x1bafff0*/ void Consume(player_inven_element item);
    /*0x1bb11ec*/ void Consume(ItemNumPair itemNumPair);
    /*0x1bb1330*/ void Consume(data_item_element item);
    /*0x1bb12a4*/ bool Can_Consume(ItemNumPair itemNumPair);
    /*0x1bb160c*/ bool Can_SellAnyItems();
    /*0x1bb1744*/ System.Collections.Generic.List<data_item_element> get_item_list_itemOnly();
    /*0x1bb134c*/ player_inven_element Get_Last(data_item_element item);
    /*0x1baf158*/ player_inven_element Get_first_Stackable(data_item_element item);
    /*0x1bb1440*/ int Get_num(data_item_element item);
    /*0x1bb1874*/ void Godmod_ItemRand();
    /*0x1bb1a2c*/ void Godmod_RemoveAll();

    class <>c__DisplayClass16_0
    {
        /*0x10*/ System.Nullable<UnityEngine.Vector3> effect_pos;
        /*0x20*/ bool isWorldPos;
        /*0x28*/ player_inven <>4__this;
        /*0x30*/ player_inven_element item;
        /*0x38*/ player_place_element place;
        /*0x40*/ double mastery_num;

        /*0x1bafd44*/ <>c__DisplayClass16_0();
        /*0x1bb1b10*/ void <Sell>b__0();
    }

    class <>c
    {
        static /*0x0*/ player_inven.<> <>9;
        static /*0x8*/ System.Func<player_inven_element, bool> <>9__19_0;
        static /*0x10*/ System.Func<player_inven_element, bool> <>9__24_0;
        static /*0x18*/ System.Func<player_inven_element, data_item_element> <>9__26_0;
        static /*0x20*/ System.Func<player_inven_element, int> <>9__29_1;

        static /*0x1bb1cc0*/ <>c();
        /*0x1bb1d24*/ <>c();
        /*0x1bb1d2c*/ bool <Sell_All>b__19_0(player_inven_element i);
        /*0x1bb1d4c*/ bool <Can_SellAnyItems>b__24_0(player_inven_element i);
        /*0x1bb1d6c*/ data_item_element <get_item_list_itemOnly>b__26_0(player_inven_element item);
        /*0x1bb1d84*/ int <Get_num>b__29_1(player_inven_element i);
    }

    class <>c__DisplayClass27_0
    {
        /*0x10*/ data_item_element item;

        /*0x1bb185c*/ <>c__DisplayClass27_0();
        /*0x1bb1d98*/ bool <Get_Last>b__0(player_inven_element i);
    }

    class <>c__DisplayClass28_0
    {
        /*0x10*/ data_item_element item;
        /*0x18*/ player_inven <>4__this;

        /*0x1bb1864*/ <>c__DisplayClass28_0();
        /*0x1bb1e08*/ bool <Get_first_Stackable>b__0(player_inven_element i);
    }

    class <>c__DisplayClass29_0
    {
        /*0x10*/ data_item_element item;

        /*0x1bb186c*/ <>c__DisplayClass29_0();
        /*0x1bb1ee0*/ bool <Get_num>b__0(player_inven_element i);
    }
}

class player_inven_element
{
    static string KEY_ELEMENT = "e";
    static string KEY_LOCKED = "l";
    static string KEY_STACK = "s";
    /*0x10*/ bool locked;
    /*0x18*/ data_item_element element;
    /*0x20*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt stack;

    /*0x1bae96c*/ player_inven_element(SimpleJSON_Ex.JSONNode json);
    /*0x1bb1f50*/ player_inven_element(data_item_element item);
    /*0x1baf0d4*/ player_inven_element(data_item_element item, bool locked);
    /*0x1bb1fd0*/ player_inven_element(data_item_element item, bool locked, int stack);
    /*0x1bb2060*/ void Set_Locked();
    /*0x1baecb0*/ SimpleJSON_Ex.JSONNode get_json();
    /*0x1bb0dd8*/ System.Collections.Generic.List<CurNumPair> Get_Reward_sum();
    /*0x1bb10ec*/ int Get_num();
}

class player_mail : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<player_mail_element> list;

    /*0x1bb2dc0*/ player_mail();
    /*0x1bb2070*/ void Awake();
    /*0x1bb2184*/ void Load();
    /*0x1bb2684*/ void Save();
    /*0x1bb2a18*/ void Add(CurNumPair reward, string text);
    /*0x1bb2b78*/ void Use(player_mail_element element, System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos);
}

class player_mail_element
{
    /*0x10*/ CurNumPair reward;
    /*0x18*/ string text;
    /*0x20*/ System.DateTime time;

    /*0x1bb23b0*/ player_mail_element(SimpleJSON_Ex.JSONNode json);
    /*0x1bb2b3c*/ player_mail_element(CurNumPair reward, string text, System.DateTime time);
    /*0x1bb27f4*/ SimpleJSON_Ex.JSONNode toJson();
}

class player_mastery : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> <dic>k__BackingField;

    /*0x1bb397c*/ player_mastery();
    /*0x1bb2e3c*/ void Awake();
    /*0x1bb2f50*/ System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> get_dic();
    /*0x1bb2f58*/ void set_dic(System.Collections.Generic.Dictionary<string, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> value);
    /*0x1bb2f60*/ void Load();
    /*0x1bb3320*/ void Save();
    /*0x1bb3580*/ void Add(data_mastery_element element);
}

class player_pet : UnityEngine.MonoBehaviour
{
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt lv_base;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt lv_parallel;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat exp_base;
    /*0x50*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat exp_parallel;

    /*0x1bb4df4*/ player_pet();
    /*0x1bb3984*/ void Awake();
    /*0x1bb3a98*/ void Load();
    /*0x1bb3ab0*/ void load_base();
    /*0x1bb3dd4*/ void load_parallel();
    /*0x1bb40f8*/ void Save();
    /*0x1bb4434*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_lv();
    /*0x1bb44e0*/ void set_lv(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
    /*0x1bb4598*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat get_exp();
    /*0x1bb4650*/ void set_exp(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat value);
    /*0x1bb4708*/ float get_exp_need();
    /*0x1bb4794*/ bool get_isActivated();
    /*0x1bb483c*/ float get_dps_mult();
    /*0x1bb49ac*/ void reset_parallel_pet();
    /*0x1bb4a60*/ void Add_Exp(float exp_input);
    /*0x1bb4c38*/ void Add_Lv();
    /*0x1bb4d08*/ void Godmod_Lv_Max();
}

class player_place : UnityEngine.MonoBehaviour
{
    static int LEGEND_ESSENCE_NUM = 250;
    static int LEGEND_ESSENCE_LV = 8;
    /*0x18*/ System.Collections.Generic.Dictionary<string, player_place_element> <dic>k__BackingField;
    /*0x20*/ data_place_element _place_legend;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt place_legend_next;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool place_legend_upgrade;

    /*0x1bb6be4*/ player_place();
    /*0x1bb4dfc*/ void Awake();
    /*0x1bb4f10*/ System.Collections.Generic.Dictionary<string, player_place_element> get_dic();
    /*0x1bb4f18*/ void set_dic(System.Collections.Generic.Dictionary<string, player_place_element> value);
    /*0x1bafe48*/ player_place_element Get_dic(string name);
    /*0x1bb025c*/ player_place_element Get_dic(data_place_element place);
    /*0x1bb4f20*/ data_place_element get_place_legend();
    /*0x1bb5258*/ bool get_legend_canUpgrade();
    /*0x1bb54d4*/ void Upgrade_Legend();
    /*0x1bb575c*/ void Load();
    /*0x1bb5c88*/ void load_by_key(string key);
    /*0x1bb5f40*/ void load_by_key_parallel(string key);
    /*0x1bb6334*/ void Save();
    /*0x1bafde0*/ player_place_element get_special_002();
    /*0x1bb6940*/ player_place_element get_farm();
    /*0x1bb69a8*/ void Godmod_LvAll();

    class <>c
    {
        static /*0x0*/ player_place.<> <>9;
        static /*0x8*/ System.Func<data_place_element, bool> <>9__9_0;
        static /*0x10*/ System.Action <>9__16_0;

        static /*0x1bb6bec*/ <>c();
        /*0x1bb6c50*/ <>c();
        /*0x1bb6c58*/ bool <get_place_legend>b__9_0(data_place_element p);
        /*0x1bb6d2c*/ void <Upgrade_Legend>b__16_0();
    }
}

class player_place_element
{
    /*0x10*/ data_place_element <place>k__BackingField;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt <time_charge_next>k__BackingField;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt <rand>k__BackingField;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt lv;
    /*0x48*/ float refund_rate;

    /*0x1bb6220*/ player_place_element(string name, int time_charge_next, int rand, int lv);
    /*0x1bb6fa4*/ data_place_element get_place();
    /*0x1bb6fac*/ void set_place(data_place_element value);
    /*0x1bb6fb4*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_time_charge_next();
    /*0x1bb6fc0*/ void set_time_charge_next(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
    /*0x1bb6fc8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_rand();
    /*0x1bb6fd4*/ void set_rand(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
    /*0x1bb6fdc*/ int get_lv_now();
    /*0x1bafedc*/ bool get_charge_isReady();
    /*0x1bb7098*/ int get_charge_time_left();
    /*0x1bb71f8*/ void Use_charge(bool ignoreChargeIsReady);
    /*0x1bb1cb8*/ void Use_charge();
    /*0x1bb1c30*/ void Set_Rand_int(int min, int max);
    /*0x1bb7324*/ CurNumPair get_Upgrade_need();
    /*0x1bb73b0*/ void Upgrade();
    /*0x1bb74dc*/ CurNumPair get_Refund_need();
    /*0x1bb7568*/ void Refund();
    /*0x1bb775c*/ float Get_Stat_Sum();
    /*0x1bb7794*/ string Get_Stat_Info();
    /*0x1bb02fc*/ data_craft_element get_craft();
    /*0x1bb79a8*/ int get_craft_lv();
    /*0x1bb6b30*/ void Godmod_LvMax();
}

class player_quest : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.Dictionary<data_quest_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> <doing>k__BackingField;
    /*0x20*/ System.Collections.Generic.List<data_quest_element> <done>k__BackingField;
    /*0x28*/ System.Collections.Generic.List<data_place_element> <doing_place>k__BackingField;

    /*0x1bba09c*/ player_quest();
    /*0x1bb7ae0*/ void Awake();
    /*0x1bb7bf4*/ System.Collections.Generic.Dictionary<data_quest_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> get_doing();
    /*0x1bb7bfc*/ void set_doing(System.Collections.Generic.Dictionary<data_quest_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> value);
    /*0x1bb7c04*/ System.Collections.Generic.List<data_quest_element> get_done();
    /*0x1bb7c0c*/ void set_done(System.Collections.Generic.List<data_quest_element> value);
    /*0x1bb7c14*/ System.Collections.Generic.List<data_place_element> get_doing_place();
    /*0x1bb7c1c*/ void set_doing_place(System.Collections.Generic.List<data_place_element> value);
    /*0x1bb7c24*/ void Load();
    /*0x1bb85c4*/ void Save();
    /*0x1bb83b8*/ void Set_Doing_Place();
    /*0x1bb8a40*/ bool Is_Completed_Quest(data_quest_element quest);
    /*0x1bb8a98*/ int Get_task_num(data_quest_element quest);
    /*0x1bb8ccc*/ float Get_task_Finish_rate(data_quest_element quest);
    /*0x1bb8dc8*/ bool Get_task_Finished(data_quest_element quest);
    /*0x1bb8ed4*/ bool Get_Can_Reward(data_quest_element quest);
    /*0x1bb8fac*/ bool Player_At_Quest_Reward_Place(data_quest_element quest);
    /*0x1bb912c*/ void Add_Quest_List(System.Collections.Generic.List<data_quest_element> quest_list);
    /*0x1bb9268*/ void Add_Quest(data_quest_element quest);
    /*0x1bb9688*/ void Add_Encount_Quest();
    /*0x1bb9480*/ void Finish_Quest(data_quest_element quest, UnityEngine.Vector3 effect_pos);
    /*0x1baa920*/ void Add_Task(string code, int num);
    /*0x1bb99bc*/ bool Has_Task(string code, ref bool allDone);
    /*0x1bb9c14*/ bool Has_Tasks(System.Collections.Generic.List<string> codes, ref bool allDone);
    /*0x1bb9e6c*/ void Godmod_TaskDone(data_quest_element quest);
    /*0x1bb9f8c*/ void Godmod_QuestAll();

    class <>c
    {
        static /*0x0*/ player_quest.<> <>9;
        static /*0x8*/ System.Func<data_quest_element, bool> <>9__24_0;

        static /*0x1bba0a4*/ <>c();
        /*0x1bba108*/ <>c();
        /*0x1bba110*/ bool <Add_Encount_Quest>b__24_0(data_quest_element que);
    }

    class <>c__DisplayClass25_0
    {
        /*0x10*/ data_quest_element quest;
        /*0x18*/ UnityEngine.Vector3 effect_pos;
        /*0x28*/ player_quest <>4__this;

        /*0x1bb99ac*/ <>c__DisplayClass25_0();
        /*0x1bba148*/ void <Finish_Quest>b__0();
    }

    class <>c__DisplayClass26_0
    {
        /*0x10*/ string code;

        /*0x1bb99b4*/ <>c__DisplayClass26_0();
        /*0x1bba6c0*/ bool <Add_Task>b__0(data_quest_element key);
    }

    class <>c__DisplayClass27_0
    {
        /*0x10*/ string code;

        /*0x1bb9c0c*/ <>c__DisplayClass27_0();
        /*0x1bba780*/ bool <Has_Task>b__0(data_quest_element key);
    }

    class <>c__DisplayClass28_0
    {
        /*0x10*/ System.Collections.Generic.List<string> codes;

        /*0x1bb9e64*/ <>c__DisplayClass28_0();
        /*0x1bba840*/ bool <Has_Tasks>b__0(data_quest_element key);
    }
}

class player_quest_group : UnityEngine.MonoBehaviour
{
    /*0x18*/ data_quest_group_element initial_quest_group;
    /*0x20*/ System.Collections.Generic.List<data_quest_group_element> <doing>k__BackingField;
    /*0x28*/ System.Collections.Generic.List<data_quest_group_element> <done>k__BackingField;

    /*0x1bbb4dc*/ player_quest_group();
    /*0x1bba920*/ System.Collections.Generic.List<data_quest_group_element> get_doing();
    /*0x1bba928*/ void set_doing(System.Collections.Generic.List<data_quest_group_element> value);
    /*0x1bba930*/ System.Collections.Generic.List<data_quest_group_element> get_done();
    /*0x1bba938*/ void set_done(System.Collections.Generic.List<data_quest_group_element> value);
    /*0x1bba940*/ void Awake();
    /*0x1bbaa54*/ void Load();
    /*0x1bbad30*/ void Save();
    /*0x1bbae54*/ SimpleJSON_Ex.JSONNode quest_group_list_to_JSONArray(System.Collections.Generic.List<data_quest_group_element> questGroupList);
    /*0x1bbab64*/ System.Collections.Generic.List<data_quest_group_element> JSONArray_to_quest_group_list(SimpleJSON_Ex.JSONNode quest_group_array_node);
    /*0x1bba508*/ void Refresh_Quest_List();
    /*0x1bbaffc*/ float Get_Buff_Stat_Sum();
    /*0x1bbb1ec*/ void tryInitialize();
    /*0x1bbb1f0*/ void Finish_Quest_Group(data_quest_group_element quest_group_to_finish, UnityEngine.Vector3 pos_effect);
    /*0x1bbb388*/ bool Has_completedGroup();

    class <>c
    {
        static /*0x0*/ player_quest_group.<> <>9;
        static /*0x8*/ System.Func<data_quest_group_element, bool> <>9__18_0;

        static /*0x1bbb4e4*/ <>c();
        /*0x1bbb548*/ <>c();
        /*0x1bbb550*/ bool <Has_completedGroup>b__18_0(data_quest_group_element groups);
    }
}

class player_record : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.Dictionary<string, player_record_element> <dic>k__BackingField;

    /*0x1bbc344*/ player_record();
    /*0x1bbb578*/ void Awake();
    /*0x1bbb68c*/ System.Collections.Generic.Dictionary<string, player_record_element> get_dic();
    /*0x1bbb694*/ void set_dic(System.Collections.Generic.Dictionary<string, player_record_element> value);
    /*0x1bbb69c*/ bool get_Has_Can_reward();
    /*0x1bbb92c*/ void Load();
    /*0x1bbbe88*/ void Save();
    /*0x1bb00d8*/ void Add_num(string code, int num);
    /*0x1bbc1bc*/ player_record_element Get_Dic(string code);
    /*0x1bbc250*/ int Get_num(string code);
}

class player_record_element
{
    /*0x10*/ data_record_element <element>k__BackingField;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt num;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt <rank>k__BackingField;

    /*0x1bbbcc8*/ player_record_element(string element_name, SimpleJSON_Ex.JSONNode json);
    /*0x1bbc34c*/ data_record_element get_element();
    /*0x1bbc354*/ void set_element(data_record_element value);
    /*0x1bbc35c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_rank();
    /*0x1bbc368*/ void set_rank(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
    /*0x1bbc370*/ bool get_isZero();
    /*0x1bbc414*/ float get_Get_reward_progress();
    /*0x1bbb868*/ bool get_Can_reward();
    /*0x1bbc4f0*/ void Add_reward(UnityEngine.Vector3 effect_pos);
}

class player_relic : UnityEngine.MonoBehaviour
{
    static int RANDOM_NUM = 10;
    static int RANDOM_PRICE = 30;
    /*0x18*/ System.Collections.Generic.List<player_relic_element> <list>k__BackingField;

    /*0x1bbd938*/ player_relic();
    /*0x1bbc6b4*/ void Awake();
    /*0x1bbc7c8*/ bool get_is_all_relic_max();
    /*0x1bbc938*/ System.Collections.Generic.List<player_relic_element> get_list();
    /*0x1bbc940*/ void set_list(System.Collections.Generic.List<player_relic_element> value);
    /*0x1bbc948*/ void Load();
    /*0x1bbce2c*/ void Save();
    /*0x1bbd1d0*/ float Get_stat_now(data_relic_element element);
    /*0x1bbd3b8*/ float Get_stat_now(string element);
    /*0x1bbd1e8*/ player_relic_element Get_element(data_relic_element element);
    /*0x1bbd3d0*/ player_relic_element Get_element(string name);
    /*0x1bbd4d4*/ void Add_Randoms(UnityEngine.Vector3 pos_effect, bool isWorldPos);
    /*0x1bbc820*/ System.Collections.Generic.List<player_relic_element> avaliable_relics();

    class <>c__DisplayClass11_0
    {
        /*0x10*/ data_relic_element element;

        /*0x1bbd4c4*/ <>c__DisplayClass11_0();
        /*0x1bbd940*/ bool <Get_element>b__0(player_relic_element el);
    }

    class <>c__DisplayClass12_0
    {
        /*0x10*/ string name;

        /*0x1bbd4cc*/ <>c__DisplayClass12_0();
        /*0x1bbd9b0*/ bool <Get_element>b__0(player_relic_element el);
    }

    class <>c
    {
        static /*0x0*/ player_relic.<> <>9;
        static /*0x8*/ System.Func<player_relic_element, bool> <>9__16_0;

        static /*0x1bbd9e0*/ <>c();
        /*0x1bbda44*/ <>c();
        /*0x1bbda4c*/ bool <avaliable_relics>b__16_0(player_relic_element el);
    }
}

class player_relic_element
{
    /*0x10*/ data_relic_element <element>k__BackingField;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt <lv>k__BackingField;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt <num>k__BackingField;

    /*0x1bbcc74*/ player_relic_element(data_relic_element data, SimpleJSON_Ex.JSONNode json);
    /*0x1bbdba4*/ data_relic_element get_element();
    /*0x1bbdbac*/ void set_element(data_relic_element value);
    /*0x1bbdbb4*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_lv();
    /*0x1bbdbc0*/ void set_lv(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
    /*0x1bbdbc8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_num();
    /*0x1bbdbd4*/ void set_num(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
    /*0x1bbd08c*/ SimpleJSON_Ex.JSONNode toJson();
    /*0x1bbdb1c*/ bool get_isLvMax();
    /*0x1bbd70c*/ void Add(int num, UnityEngine.Vector3 effect_pos, bool isWorldPos);
    /*0x1bbdbdc*/ void Add_withItem(UnityEngine.Vector3 effect_pos, bool isWorldPos);
    /*0x1bbd2dc*/ float Get_stat_now();
    /*0x1bbdd18*/ void godmod_set_max_level();
    /*0x1bbdd38*/ void godmod_reset_level();
}

class player_setting : UnityEngine.MonoBehaviour
{
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredString <gpgs_id>k__BackingField;
    /*0x20*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool <removeAd>k__BackingField;
    /*0x2c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool <reviewed>k__BackingField;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool <godmod>k__BackingField;
    /*0x44*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool reward_twitter;
    /*0x50*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool reward_facebook;

    /*0x1bbedac*/ player_setting();
    /*0x1bbdd98*/ void Awake();
    /*0x1bbdf00*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredString get_gpgs_id();
    /*0x1bbdf08*/ void set_gpgs_id(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value);
    /*0x1bbdf10*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_removeAd();
    /*0x1bbdf20*/ void set_removeAd(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value);
    /*0x1bbdf2c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_reviewed();
    /*0x1bbdf3c*/ void set_reviewed(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value);
    /*0x1bbdf48*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool get_godmod();
    /*0x1bbdf58*/ void set_godmod(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value);
    /*0x1bbdf64*/ void Load();
    /*0x1bbe5f4*/ void Save();
    /*0x1bbe9d4*/ void Refresh_Init();
    /*0x1bbe9d8*/ void Set_Admob();
    /*0x1bbea34*/ bool Check_GPGS_id(string id);
    /*0x1bbeb30*/ void Set_RemoveAD();
    /*0x1bbebd8*/ void Set_Reviewed();
    /*0x1bbecb4*/ void Set_Godmod();
}

class player_ship : UnityEngine.MonoBehaviour
{
    static float SPEED_BASE = 1;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 base_position;
    /*0x30*/ data_place_element base_place;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 parallel_position;
    /*0x50*/ data_place_element parallel_place;
    /*0x58*/ System.Collections.IEnumerator cor_portal;

    /*0x1bc2374*/ player_ship();
    /*0x1bbedb4*/ void Awake();
    /*0x1bbeec8*/ void Update();
    /*0x1bacac8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 get_position();
    /*0x1bbf108*/ void set_position(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 value);
    /*0x1bbf19c*/ data_place_element get_place();
    /*0x1bbf218*/ void set_place(data_place_element value);
    /*0x1bbf2a0*/ float get_speed();
    /*0x1bbf30c*/ float get_speed_mult();
    /*0x1bbf468*/ bool get_moving();
    /*0x1bb1154*/ bool get_isHarbor();
    /*0x1bbf598*/ bool get_isStartPos();
    /*0x1bbf69c*/ bool get_isOcean();
    /*0x1bbf724*/ bool get_isUnFishable();
    /*0x1bbf808*/ bool get_isUseful();
    /*0x1bb90a0*/ bool isPlace(data_place_element place);
    /*0x1bbf8f0*/ bool isType(data_place.Type type);
    /*0x1bafd4c*/ data_place_element get_place_now();
    /*0x1bbf994*/ bool get_Entered_Fake_Base_Dimension();
    /*0x1bbfa2c*/ void Save();
    /*0x1bbfac8*/ void Save_By_Dimension(string key, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 position, data_place_element place);
    /*0x1bbfe68*/ void Load();
    /*0x1bbfee0*/ void Load_By_Dimension(string key, ref CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 pos_ref, ref data_place_element place_ref);
    /*0x1bc02fc*/ void reset_parallel_ship();
    /*0x1bc0368*/ float get_distance();
    /*0x1bbeecc*/ void Update_Move();
    /*0x1bc0484*/ void OnArrive(data_place_element place);
    /*0x1bc07f4*/ void OnArrivePoint(UnityEngine.Vector2 target_point);
    /*0x1bc0970*/ void On_Parallel_FirstArrive(UnityEngine.Vector2 position);
    /*0x1bc0ae0*/ void UnSet_Place();
    /*0x1bc0e28*/ void Set_Place(data_place_element place_target);
    /*0x1bc0b4c*/ void Set_Place(data_place_element place_target, bool isAuto);
    /*0x1bc0e30*/ void SmartMove(data_place_element place_target);
    /*0x1bc1248*/ void Portal(int target_dimension);
    /*0x1bc1538*/ void Portal(data_place_element place_target, int target_dimension);
    /*0x1bc1494*/ void Portal(UnityEngine.Vector2 point_target, int target_dimension);
    /*0x1bc0fdc*/ void Portal(data_place_element place_target);
    /*0x1bc1778*/ void Portal(UnityEngine.Vector2 point_target);
    /*0x1bc15c8*/ void Portal_Dimension(data_place_element place_target);
    /*0x1bc1698*/ void Portal_Dimension(UnityEngine.Vector2 point_target);
    /*0x1bc18b4*/ void Portal(int mana_need, System.Action on_arrive_action);
    /*0x1bc199c*/ void Portal_Dimension(int mana_need, System.Action on_arrive_action);
    /*0x1bc10b8*/ void Portal_farm();
    /*0x1bc1ad4*/ void Show_Portal_Warning(System.Action onClickContinue, string warning_text_id, bool show_warning, int opt_mana_need);
    /*0x1bc1c40*/ bool onPortalWarningClickContinue(int mana_need, bool changing_dimension, System.Action on_arrive_action);
    /*0x1bc205c*/ bool onPortalWarningClickContinue_Farm(System.Action on_arrive_action);
    /*0x1bc1fdc*/ System.Collections.IEnumerator IE_Portal(System.Action onArriveAction, int mana_need);
    /*0x1bc2128*/ void preparePortal(int mana_need);
    /*0x1bc2210*/ void onArriveAction(data_place_element target);
    /*0x1bc22a8*/ void onArriveAction(UnityEngine.Vector2 target);
    /*0x1bc22ac*/ void wrapupPortal();
    /*0x1bc22b4*/ System.Collections.IEnumerator fadeOut();
    /*0x1bc2314*/ System.Collections.IEnumerator fadeIn();

    class <>c__DisplayClass53_0
    {
        /*0x10*/ player_ship <>4__this;
        /*0x18*/ data_place_element place_target;

        /*0x1c53994*/ <>c__DisplayClass53_0();
        /*0x1c5399c*/ void <Portal>b__0();
    }

    class <>c__DisplayClass54_0
    {
        /*0x10*/ player_ship <>4__this;
        /*0x18*/ UnityEngine.Vector2 point_target;

        /*0x1c539c0*/ <>c__DisplayClass54_0();
        /*0x1c539c8*/ void <Portal>b__0();
    }

    class <>c__DisplayClass55_0
    {
        /*0x10*/ player_ship <>4__this;
        /*0x18*/ data_place_element place_target;

        /*0x1c539ec*/ <>c__DisplayClass55_0();
        /*0x1c539f4*/ void <Portal_Dimension>b__0();
    }

    class <>c__DisplayClass56_0
    {
        /*0x10*/ player_ship <>4__this;
        /*0x18*/ UnityEngine.Vector2 point_target;

        /*0x1c53a68*/ <>c__DisplayClass56_0();
        /*0x1c53a70*/ void <Portal_Dimension>b__0();
    }

    class <>c__DisplayClass57_0
    {
        /*0x10*/ player_ship <>4__this;
        /*0x18*/ int mana_need;
        /*0x20*/ System.Action on_arrive_action;

        /*0x1c53b20*/ <>c__DisplayClass57_0();
        /*0x1c53b28*/ void <Portal>b__0();
    }

    class <>c__DisplayClass58_0
    {
        /*0x10*/ player_ship <>4__this;
        /*0x18*/ int mana_need;
        /*0x20*/ System.Action on_arrive_action;

        /*0x1c53b54*/ <>c__DisplayClass58_0();
        /*0x1c53b5c*/ void <Portal_Dimension>b__0();
    }

    class <>c__DisplayClass59_0
    {
        /*0x10*/ player_ship <>4__this;
        /*0x18*/ System.Action on_arrive_action;

        /*0x1c53c08*/ <>c__DisplayClass59_0();
        /*0x1c53c10*/ void <Portal_farm>b__0();
        /*0x1c53c8c*/ void <Portal_farm>b__1();
    }

    class <IE_Portal>d__64 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ player_ship <>4__this;
        /*0x28*/ int mana_need;
        /*0x30*/ System.Action onArriveAction;

        /*0x1c53cb0*/ <IE_Portal>d__64(int <>1__state);
        /*0x1c53cd8*/ void System.IDisposable.Dispose();
        /*0x1c53cdc*/ bool MoveNext();
        /*0x1c53e60*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1c53e68*/ void System.Collections.IEnumerator.Reset();
        /*0x1c53ea8*/ object System.Collections.IEnumerator.get_Current();
    }

    class <fadeOut>d__69 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UnityEngine.UI.Image <fader>5__2;
        /*0x28*/ UnityEngine.Color <color_target>5__3;
        /*0x38*/ float <time>5__4;

        /*0x1c53eb0*/ <fadeOut>d__69(int <>1__state);
        /*0x1c53ed8*/ void System.IDisposable.Dispose();
        /*0x1c53edc*/ bool MoveNext();
        /*0x1c54038*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1c54040*/ void System.Collections.IEnumerator.Reset();
        /*0x1c54080*/ object System.Collections.IEnumerator.get_Current();
    }

    class <fadeIn>d__70 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UnityEngine.UI.Image <fader>5__2;
        /*0x28*/ float <time>5__3;
        /*0x2c*/ UnityEngine.Color <color_target>5__4;

        /*0x1c54088*/ <fadeIn>d__70(int <>1__state);
        /*0x1c540b0*/ void System.IDisposable.Dispose();
        /*0x1c540b4*/ bool MoveNext();
        /*0x1c54214*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1c5421c*/ void System.Collections.IEnumerator.Reset();
        /*0x1c5425c*/ object System.Collections.IEnumerator.get_Current();
    }
}

class PortalManaCalculator
{
    static /*0x1c54264*/ int Get_Portal_needMana(data_place_element to);
    static /*0x1c542cc*/ int Get_Portal_needMana(data_place_element from, data_place_element to);
    static /*0x1c54758*/ int Get_Portal_needMana(UnityEngine.Vector2 to);
    static /*0x1c54830*/ int Get_Portal_needMana(UnityEngine.Vector2 from, UnityEngine.Vector2 to);
    static /*0x1c54b44*/ int Get_Portal_needMana_For_Dimension_Switch();
    /*0x1c54b4c*/ PortalManaCalculator();
}

class player_skill : UnityEngine.MonoBehaviour
{
    static double TIME_MAX = 86400;
    static float BOOST_COOLTIME = 30;
    /*0x18*/ System.Collections.Generic.Dictionary<data_skill_element, player_skill_element> dic;
    /*0x20*/ float time_mana;

    /*0x1c57404*/ player_skill();
    /*0x1c54b54*/ void Awake();
    /*0x1c54cbc*/ void Update();
    /*0x1c55754*/ void Load();
    /*0x1c55c58*/ void Save();
    /*0x1c55f9c*/ void Refresh_Initiate();
    /*0x1c54d24*/ void Update_Skill();
    /*0x1c5563c*/ void Update_Mana();
    /*0x1c566b4*/ float Get_mult_now(data_skill_element skill);
    /*0x1c569b8*/ float Get_mult_base(data_skill_element skill);
    /*0x1c5682c*/ float Get_mult_withBoost(data_skill_element skill);
    /*0x1c5613c*/ void Charge_skill(data_skill_element skill);
    /*0x1c56b94*/ float Get_time_add(data_skill_element skill);
    /*0x1c56aa8*/ int Get_mana_need(data_skill_element skill);
    /*0x1c56e10*/ bool Get_Boost_enabled(data_skill_element skill);
    /*0x1c56ee8*/ void Use_Boost(data_skill_element skill);
    /*0x1c570ec*/ bool get_canAuto();
    /*0x1c571c4*/ void Use_Potion();
    /*0x1c5740c*/ int <Update_Skill>b__6_2(System.Collections.Generic.KeyValuePair<data_skill_element, player_skill_element> item);
    /*0x1c57448*/ bool <Update_Skill>b__6_4(System.Collections.Generic.KeyValuePair<data_skill_element, player_skill_element> item);
    /*0x1c57574*/ int <Update_Skill>b__6_5(System.Collections.Generic.KeyValuePair<data_skill_element, player_skill_element> item);

    class <>c
    {
        static /*0x0*/ player_skill.<> <>9;
        static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<data_skill_element, player_skill_element>, bool> <>9__6_0;
        static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<data_skill_element, player_skill_element>, double> <>9__6_1;
        static /*0x18*/ System.Func<System.Collections.Generic.KeyValuePair<data_skill_element, player_skill_element>, data_skill_element> <>9__6_3;
        static /*0x20*/ System.Func<System.Collections.Generic.KeyValuePair<data_skill_element, player_skill_element>, data_skill_element> <>9__6_6;

        static /*0x1c575b0*/ <>c();
        /*0x1c57614*/ <>c();
        /*0x1c5761c*/ bool <Update_Skill>b__6_0(System.Collections.Generic.KeyValuePair<data_skill_element, player_skill_element> item);
        /*0x1c576c4*/ double <Update_Skill>b__6_1(System.Collections.Generic.KeyValuePair<data_skill_element, player_skill_element> item);
        /*0x1c5774c*/ data_skill_element <Update_Skill>b__6_3(System.Collections.Generic.KeyValuePair<data_skill_element, player_skill_element> item);
        /*0x1c57788*/ data_skill_element <Update_Skill>b__6_6(System.Collections.Generic.KeyValuePair<data_skill_element, player_skill_element> item);
    }
}

class player_skill_element
{
    /*0x10*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble time_now;
    /*0x30*/ double time_max_charged;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool boost_enabled;
    /*0x48*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble boost_cooltime;
    /*0x68*/ bool auto_enabled;

    /*0x1c55c50*/ player_skill_element();
    /*0x1c577c4*/ float get_rate();
    /*0x1c567b0*/ bool get_isOn();
}

class player_skin : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.Dictionary<data_skin.Type, System.Collections.Generic.List<data_skin_element>> <dic>k__BackingField;
    /*0x20*/ System.Collections.Generic.Dictionary<data_skin_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> <rank>k__BackingField;
    /*0x28*/ System.Collections.Generic.Dictionary<data_skin.Type, data_skin_element> <_selected>k__BackingField;
    /*0x30*/ data_skin_element preview;
    /*0x38*/ System.Collections.Generic.List<player_skin_stat> stats;

    /*0x1c5aaa0*/ player_skin();
    /*0x1c57844*/ void Awake();
    /*0x1c57958*/ System.Collections.Generic.List<data_skin_element> get_list();
    /*0x1c57a9c*/ System.Collections.Generic.Dictionary<data_skin.Type, System.Collections.Generic.List<data_skin_element>> get_dic();
    /*0x1c57aa4*/ void set_dic(System.Collections.Generic.Dictionary<data_skin.Type, System.Collections.Generic.List<data_skin_element>> value);
    /*0x1c57aac*/ System.Collections.Generic.Dictionary<data_skin_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> get_rank();
    /*0x1c57ab4*/ void set_rank(System.Collections.Generic.Dictionary<data_skin_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> value);
    /*0x1c57abc*/ System.Collections.Generic.Dictionary<data_skin.Type, data_skin_element> get__selected();
    /*0x1c57ac4*/ void set__selected(System.Collections.Generic.Dictionary<data_skin.Type, data_skin_element> value);
    /*0x1c57acc*/ System.Collections.Generic.Dictionary<data_skin.Type, data_skin_element> get_selected();
    /*0x1c57d38*/ void set_selected(System.Collections.Generic.Dictionary<data_skin.Type, data_skin_element> value);
    /*0x1c57d40*/ void Load();
    /*0x1c587bc*/ void Save();
    /*0x1c58f0c*/ int Get_RankSum(data_skin.Type type);
    /*0x1c58e3c*/ int Get_Rank(data_skin_element skin);
    /*0x1c56c50*/ player_skin_stat Get_Stat(data_skin.Type type);
    /*0x1c59084*/ string stats_toString(data_skin_element element);
    /*0x1c590b0*/ string stats_toString(data_skin_element element, int rank);
    /*0x1c59290*/ void Set_Skin(data_skin_element element);
    /*0x1c593f0*/ void Buy(data_skin_element element, System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos, bool isEvents);
    /*0x1c598cc*/ void Upgrade(data_skin_element element);
    /*0x1c59d38*/ void Craft(data_skin_element element, int rank);
    /*0x1c59f08*/ void Adds(System.Collections.Generic.List<data_skin_element> elements, System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos);
    /*0x1c5a178*/ void Add(data_skin_element element);
    /*0x1c59fcc*/ void Add(data_skin_element element, System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos);
    /*0x1c5a2e4*/ void Godmod_AllSkin();

    class <>c
    {
        static /*0x0*/ player_skin.<> <>9;
        static /*0x8*/ System.Func<System.Collections.Generic.List<data_skin_element>, System.Collections.Generic.IEnumerable<data_skin_element>> <>9__2_0;

        static /*0x1c5aaa8*/ <>c();
        /*0x1c5ab0c*/ <>c();
        /*0x1c5ab14*/ System.Collections.Generic.IEnumerable<data_skin_element> <get_list>b__2_0(System.Collections.Generic.List<data_skin_element> x);
    }

    class <>c__DisplayClass24_0
    {
        /*0x10*/ data_skin.Type type;

        /*0x1c5907c*/ <>c__DisplayClass24_0();
        /*0x1c5ab1c*/ bool <Get_Stat>b__0(player_skin_stat stat);
    }
}

class player_skin_stat
{
    /*0x10*/ data_skin.Type type;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat mult;
    /*0x30*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt rank;
    /*0x40*/ data_quest_element quest;

    /*0x1c5ac8c*/ player_skin_stat(data_skin.Type type, float mult);
    /*0x1c5ab40*/ bool canUse();
    /*0x1c56d44*/ float get_multSum();
    /*0x1c5ad34*/ string multSum_toString();
}

class player_status
{
    static float BUFF_MULT = 1.5;
    static float OVERLV_MAX_RATE = 0.019999999552965164;
    static int OVERLV_MIN = 5;
    static int OVERLV_MAX = 36;
    static float MANA_REGEN_BASE = 0.009999999776482582;
    static int RAMPAGE_MAXLV_BASE = 5;
    static float RAMPAGE_STAT_MULT = 0.05000000074505806;

    /*0x1c5c318*/ player_status();
    /*0x1c5aee0*/ double get_dps_mult();
    /*0x1c5af98*/ float get_crit_rate();
    /*0x1c5b018*/ float get_crit_mult();
    /*0x1c5b0a4*/ float get_buff_mult_now();
    /*0x1c5b224*/ float get_exp_mult();
    /*0x1c5b288*/ float get_exp_mult_skin();
    /*0x1c5b4cc*/ float get_exp_mult_farm();
    /*0x1c5b364*/ float get_exp_mult_monument();
    /*0x1c5b3e4*/ float get_exp_mult_relic();
    /*0x1c5b464*/ float get_exp_mult_questgroup();
    /*0x1c5b538*/ int overLv_max_now();
    /*0x1c5b5a4*/ int overLv_maxDiff_now();
    /*0x1c5b674*/ float get_exp_overLv_penalty();
    /*0x1c5b7cc*/ float get_gold_mult();
    /*0x1c5b830*/ float get_gold_mult_skin();
    /*0x1c5b2f8*/ float get_gold_mult_farm();
    /*0x1c5b8a0*/ float get_gold_mult_monument();
    /*0x1c5b920*/ float get_gold_mult_relic();
    /*0x1c5b9a0*/ float get_gold_mult_questgroup();
    /*0x1c5ba08*/ float get_trace_mult();
    /*0x1c5ba9c*/ float get_events_mult();
    /*0x1c5bb30*/ float get_sonar_distance();
    /*0x1c5bd34*/ bool get_sonar_enabled();
    /*0x1c5be14*/ float get_sonar_reach();
    /*0x1c56698*/ float get_mana_regen();
    /*0x1c5c018*/ float get_mana_regen_mult();
    /*0x1c5c098*/ int get_rampage_maxLv();
    /*0x1c5c16c*/ float get_rampage_mult_now();
    /*0x1c5c21c*/ float get_rampage_mult_perLv();
    /*0x1c5c2a8*/ float get_balloon_mult();
}

class player_time : UnityEngine.MonoBehaviour
{
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble <passed>k__BackingField;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble <saved>k__BackingField;
    /*0x58*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble <loaded>k__BackingField;
    /*0x78*/ float sec;

    /*0x1c5cd70*/ player_time();
    /*0x1c5c320*/ void Awake();
    /*0x1c5c434*/ void Update();
    /*0x1c5c734*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble get_passed();
    /*0x1c5c744*/ void set_passed(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble value);
    /*0x1c5c754*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble get_saved();
    /*0x1c5c764*/ void set_saved(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble value);
    /*0x1c5c774*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble get_loaded();
    /*0x1c5c784*/ void set_loaded(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble value);
    /*0x1c5c794*/ double get_dateTime_now();
    /*0x1c5c840*/ void Load();
    /*0x1c5caf4*/ void Save();
    /*0x1c5c494*/ void Update_time();
}

class player_turret : UnityEngine.MonoBehaviour
{
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt no;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt lv_base;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt lv_parallel;
    /*0x48*/ data_skin.Type skinType;

    /*0x1c5e1f0*/ player_turret();
    /*0x1c5cd78*/ void Awake();
    /*0x1c5ce8c*/ string get_turret_key();
    /*0x1c5cf24*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt get_lv();
    /*0x1c5cfd0*/ void set_lv(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
    /*0x1c5d088*/ double dps(int lv);
    /*0x1c5d278*/ float dps_mult(int lv);
    /*0x1c5d4a4*/ double get_damage();
    /*0x1c5d5f4*/ bool get_canUpgrade();
    /*0x1c5d15c*/ bool get_canUse();
    /*0x1c5d7a8*/ void Load();
    /*0x1c5da9c*/ void Save();
    /*0x1c5dc80*/ void reset_parallel_turret();
    /*0x1c5dce0*/ void Upgrade();
    /*0x1c5e108*/ void Godmod_LvMax();
}

class player_www : UnityEngine.MonoBehaviour
{
    static double DAILY_BUFF = 3600;
    static double DAILY_VIP_BUFF = 3600;
    static double HOTTIME_OFFSET = 4;
    static int STORE_TIME = 12;
    static int STORE_MAX = 4;
    static int STORE_DIAMOND_REFILL = 50;
    static int ADS_BUFF_NUM_MAX = 10;
    static int ADS_BUFF_COOLTIME = 1200;
    static int ADS_POTION_NUM_MAX = 40;
    static int ADS_POTION_COOLTIME = 300;
    /*0x18*/ System.DateTime <time_hottime>k__BackingField;
    /*0x20*/ System.DateTime <time_store>k__BackingField;
    /*0x28*/ System.DateTime <time_buff>k__BackingField;
    /*0x30*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt last_gift_received;
    /*0x40*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt daily_date;
    /*0x50*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt daily_date_num;
    /*0x60*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt daily_vip_date;
    /*0x70*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt ads_potion_num;
    /*0x80*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt ads_buff_num;
    /*0x90*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt ads_date;
    /*0xa0*/ System.DateTime <ads_buff_time>k__BackingField;
    /*0xa8*/ System.DateTime <ads_potion_time>k__BackingField;
    /*0xb0*/ System.Collections.Generic.List<data_skin_element> <skin_store>k__BackingField;
    /*0xb8*/ System.Collections.Generic.List<CurNumPair> daily_reward;
    /*0xc0*/ System.Collections.Generic.List<CurNumPair> daily_vip_reward;
    /*0xc8*/ System.DateTime[] time_hottime_reward;
    /*0xd0*/ System.Collections.Generic.List<data_skin_element> _store_skin_all;

    /*0x1c61c44*/ player_www();
    /*0x1c5e1f8*/ System.DateTime get_time_hottime();
    /*0x1c5e200*/ void set_time_hottime(System.DateTime value);
    /*0x1c5e208*/ System.DateTime get_time_store();
    /*0x1c5e210*/ void set_time_store(System.DateTime value);
    /*0x1c5e218*/ System.DateTime get_time_buff();
    /*0x1c5e220*/ void set_time_buff(System.DateTime value);
    /*0x1c5e228*/ System.DateTime get_ads_buff_time();
    /*0x1c5e230*/ void set_ads_buff_time(System.DateTime value);
    /*0x1c5e238*/ System.DateTime get_ads_potion_time();
    /*0x1c5e240*/ void set_ads_potion_time(System.DateTime value);
    /*0x1c5e248*/ System.Collections.Generic.List<data_skin_element> get_skin_store();
    /*0x1c5e250*/ void set_skin_store(System.Collections.Generic.List<data_skin_element> value);
    /*0x1c5e258*/ void Awake();
    /*0x1c5e3f8*/ void Load();
    /*0x1c5f498*/ void Save();
    /*0x1c5fe00*/ void Refresh_UI();
    /*0x1c5fe04*/ bool get_can_daily_reward();
    /*0x1c5feac*/ void Get_daily_reward(System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos);
    /*0x1c60378*/ bool get_can_daily_vip_reward();
    /*0x1c604b0*/ void Get_daily_vip_reward(System.Nullable<UnityEngine.Vector3> effect_pos, bool isWorldPos);
    /*0x1c60798*/ void reward_hottime();
    /*0x1c60db0*/ System.Collections.Generic.List<data_skin_element> get_store_skin_all();
    /*0x1c60f14*/ System.Collections.Generic.List<data_skin_element> Get_store_skin_target();
    /*0x1c6113c*/ System.DateTime get_store_time_next();
    /*0x1c61160*/ void store_refill();
    /*0x1c61534*/ void store_refill_auto();
    /*0x1c6161c*/ void Add_Buff(float time);
    /*0x1c60154*/ void Add_Buff(double time);
    /*0x1c5b110*/ bool Check_Buff();
    /*0x1c61624*/ bool Can_Get_Ads();
    /*0x1c61654*/ bool Can_Get_Ads(player_www.Ads_Type type);
    /*0x1c61900*/ void Get_Ads(player_www.Ads_Type type, double num);
    /*0x1c61ad8*/ void Set_Ads_Cooltime(player_www.Ads_Type type);
    /*0x1c61d68*/ bool <Get_store_skin_target>b__54_0(data_skin_element skin);

    enum Ads_Type
    {
        potion = 0,
        buff = 1,
    }

    class <>c
    {
        static /*0x0*/ player_www.<> <>9;
        static /*0x8*/ System.Func<data_skin_element, bool> <>9__53_0;
        static /*0x10*/ System.Func<data_skin_element, bool> <>9__54_1;

        static /*0x1c61e50*/ <>c();
        /*0x1c61eb4*/ <>c();
        /*0x1c61ebc*/ bool <get_store_skin_all>b__53_0(data_skin_element skin);
        /*0x1c61f8c*/ bool <Get_store_skin_target>b__54_1(data_skin_element skin);
    }

    class <>c__DisplayClass57_0
    {
        /*0x10*/ player_www <>4__this;
        /*0x18*/ System.Collections.Generic.List<data_skin_element> target;
        /*0x20*/ System.Action action;

        /*0x1c6152c*/ <>c__DisplayClass57_0();
        /*0x1c62018*/ void <store_refill>b__0();
        /*0x1c62118*/ void <store_refill>b__1();
    }
}

class player_refiner
{
    static /*0x1c62234*/ SimpleJSON_Ex.JSONNode Refine(string data_now);
    /*0x1c64b64*/ player_refiner();
}

class Play_Test : UnityEngine.MonoBehaviour
{
    /*0x18*/ float damage;
    /*0x1c*/ float time_shot;
    /*0x20*/ float time_wait;
    /*0x24*/ float time_found;
    /*0x28*/ float time_initiate;
    /*0x2c*/ float time_done;
    /*0x30*/ Play_Test.state state_now;
    /*0x38*/ UnityEngine.UI.Text text_state;
    /*0x40*/ UnityEngine.UI.Text text_log;
    /*0x48*/ System.Collections.IEnumerator coroutine;
    /*0x50*/ float charge_now;
    /*0x58*/ UnityEngine.UI.Image bar_charge;
    /*0x60*/ float life_max;
    /*0x64*/ float time_max;
    /*0x68*/ UnityEngine.UI.Image bar_life;
    /*0x70*/ UnityEngine.UI.Image bar_time;
    /*0x78*/ float life_left;
    /*0x7c*/ float time_left;

    /*0x1c65064*/ Play_Test();
    /*0x1c64b6c*/ void Set_State(Play_Test.state targetState);
    /*0x1c64c64*/ void Add_Log(string text);
    /*0x1c64cfc*/ System.Collections.IEnumerator IE_Charge();
    /*0x1c64d8c*/ System.Collections.IEnumerator IE_Shot();
    /*0x1c64e1c*/ System.Collections.IEnumerator IE_Initiate();
    /*0x1c64eac*/ System.Collections.IEnumerator IE_Done();
    /*0x1c64f3c*/ void PointerDown();
    /*0x1c64fe8*/ void PointerUp();

    enum state
    {
        idle = 0,
        charge = 1,
        shot = 2,
        wait = 3,
        found = 4,
        initiate = 5,
        fight_idle = 6,
        done = 7,
    }

    class <IE_Charge>d__15 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Play_Test <>4__this;

        /*0x1c64d64*/ <IE_Charge>d__15(int <>1__state);
        /*0x1c65078*/ void System.IDisposable.Dispose();
        /*0x1c6507c*/ bool MoveNext();
        /*0x1c65164*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1c6516c*/ void System.Collections.IEnumerator.Reset();
        /*0x1c651ac*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_Shot>d__16 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Play_Test <>4__this;

        /*0x1c64df4*/ <IE_Shot>d__16(int <>1__state);
        /*0x1c651b4*/ void System.IDisposable.Dispose();
        /*0x1c651b8*/ bool MoveNext();
        /*0x1c65330*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1c65338*/ void System.Collections.IEnumerator.Reset();
        /*0x1c65378*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_Initiate>d__23 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Play_Test <>4__this;

        /*0x1c64e84*/ <IE_Initiate>d__23(int <>1__state);
        /*0x1c65380*/ void System.IDisposable.Dispose();
        /*0x1c65384*/ bool MoveNext();
        /*0x1c6550c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1c65514*/ void System.Collections.IEnumerator.Reset();
        /*0x1c65554*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_Done>d__24 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Play_Test <>4__this;

        /*0x1c64f14*/ <IE_Done>d__24(int <>1__state);
        /*0x1c6555c*/ void System.IDisposable.Dispose();
        /*0x1c65560*/ bool MoveNext();
        /*0x1c656c4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1c656cc*/ void System.Collections.IEnumerator.Reset();
        /*0x1c6570c*/ object System.Collections.IEnumerator.get_Current();
    }
}

class fish_legend_essence_fight_attack_state : UnityEngine.StateMachineBehaviour
{
    /*0x1c657b0*/ fish_legend_essence_fight_attack_state();
    /*0x1c65714*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class fish_legend_essence_fight_state : UnityEngine.StateMachineBehaviour
{
    /*0x18*/ float nextAttackTimeOffsetMin;
    /*0x1c*/ float nextAttackTimeOffsetMax;
    /*0x20*/ float nextAttackTime;
    /*0x24*/ float nextAttackTimeCount;

    /*0x1c65864*/ fish_legend_essence_fight_state();
    /*0x1c657b8*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
    /*0x1c657dc*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class prefab_fish : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Transform pos_rod;
    /*0x20*/ UnityEngine.Transform pos_hit;

    /*0x1c65a64*/ prefab_fish();
    /*0x1c6586c*/ void Particle_Water_Cam();
    /*0x1c658d0*/ void Particle_Water_On();
    /*0x1c65930*/ void Particle_Water_Off();
    /*0x1c65990*/ void Particle_Death();
    /*0x1c65a08*/ void Play_Sfx_Clip(UnityEngine.AudioClip sfx);
}

class boss_039_emissive_manager : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicSlowEmissive leftLegEmissive;
    /*0x20*/ GarlicSlowEmissive centerLegEmissive;
    /*0x28*/ GarlicSlowEmissive rightLegEmissive;
    /*0x30*/ GarlicSlowEmissive headEmissive;
    /*0x38*/ float emissiveRangeSize;
    /*0x3c*/ float idleEmissiveMin;
    /*0x40*/ float attackEmissiveMin;
    /*0x44*/ boss_039_emissive_manager.EmissiveMode emissiveMode;

    /*0x1c65da8*/ boss_039_emissive_manager();
    /*0x1c65a6c*/ void Awake();
    /*0x1c65a74*/ void setupIdleEmissive();
    /*0x1c65c54*/ void setupAttackEmissive(Boss_039_Attack_Type attackType);
    /*0x1c65bc4*/ System.Collections.IEnumerator lerpEmissiveValue(GarlicSlowEmissive[] targetEmissives, float targetMinEmissive, float lerpTime);
    /*0x1c65da4*/ void prepareAttackEmissive(Boss_039_Attack_Type attackType);

    enum EmissiveMode
    {
        Idle = 0,
        Attack = 1,
    }

    class <lerpEmissiveValue>d__12 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ float lerpTime;
        /*0x28*/ GarlicSlowEmissive[] targetEmissives;
        /*0x30*/ float targetMinEmissive;
        /*0x38*/ boss_039_emissive_manager <>4__this;
        /*0x40*/ float <timeCount>5__2;

        /*0x1c65d7c*/ <lerpEmissiveValue>d__12(int <>1__state);
        /*0x1c65dc8*/ void System.IDisposable.Dispose();
        /*0x1c65dcc*/ bool MoveNext();
        /*0x1c65f10*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1c65f18*/ void System.Collections.IEnumerator.Reset();
        /*0x1c65f58*/ object System.Collections.IEnumerator.get_Current();
    }
}

class boss_039_state_prepareattack : UnityEngine.StateMachineBehaviour
{
    /*0x1c660b4*/ boss_039_state_prepareattack();
    /*0x1c65f60*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
    /*0x1c65f64*/ void playRandomAttackAnimation(UnityEngine.Animator animator);
    /*0x1c65ff0*/ Boss_039_Attack_Type getRandomAttackType();
}

class boss_039_state_wait : UnityEngine.StateMachineBehaviour
{
    /*0x18*/ float nextAttackTimeOffsetMin;
    /*0x1c*/ float nextAttackTimeOffsetMax;
    /*0x20*/ float nextAttackTime;
    /*0x24*/ float nextAttackTimeCount;

    /*0x1c66168*/ boss_039_state_wait();
    /*0x1c660bc*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
    /*0x1c660e0*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

enum Boss_039_Attack_Type
{
    Attack_Left = 0,
    Attack_Right = 1,
}

class prefab_fish_boss_039_manager : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject rightLegTouchbox;
    /*0x20*/ UnityEngine.GameObject leftLegTouchbox;
    /*0x28*/ UnityEngine.UI.Image UIRightAttackWarning;
    /*0x30*/ UnityEngine.UI.Image UILeftAttackWarning;
    /*0x38*/ UnityEngine.ParticleSystem onRightAttackParticle;
    /*0x40*/ UnityEngine.ParticleSystem onLeftAttackParticle;
    /*0x48*/ UnityEngine.GameObject amber_base;
    /*0x50*/ UnityEngine.GameObject amber_parallel;
    /*0x58*/ int attackCancelTouchCount;
    /*0x5c*/ float timeDecreaseAmountWhenAttacked;
    /*0x60*/ boss_039_emissive_manager emissiveManager;
    /*0x68*/ UnityEngine.Animator animator;
    /*0x70*/ int currentTouchCount;

    /*0x1c66bf8*/ prefab_fish_boss_039_manager();
    /*0x1c66170*/ void Awake();
    /*0x1c662a4*/ void initialize_done();
    /*0x1c662f8*/ void fight_done();
    /*0x1c6634c*/ void attack_success(Boss_039_Attack_Type attackType);
    /*0x1c665a8*/ void inactivateWarningUIs();
    /*0x1c665f8*/ void shakeCamera(Boss_039_Attack_Type attackType);
    /*0x1c669ec*/ void activateTouchCollider(Boss_039_Attack_Type attackType);
    /*0x1c66a88*/ void onPlayerTouchRightLeg();
    /*0x1c66b9c*/ void onPlayerTouchLeftLeg();
    /*0x1c661f0*/ void initAmber();
    /*0x1c66ae4*/ void incrementTouchCount();
    /*0x1c66570*/ void inactivateAllTouchBoxes();
}

class prefab_fish_legend_essence : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.ParticleSystem sparkParticle;
    /*0x20*/ UnityEngine.ParticleSystem fireflowerParticle;
    /*0x28*/ float projectileSummonDelay;
    /*0x30*/ UnityEngine.GameObject projectile_front;
    /*0x38*/ UnityEngine.BoxCollider fall_projectile_summon_range;
    /*0x40*/ UnityEngine.Vector2 projectFallSpeed;
    /*0x48*/ float fallProjectSummonOffsetTime;
    /*0x4c*/ int fallProjectileCount;
    /*0x50*/ float fish_summon_position_z;
    /*0x58*/ UnityEngine.Animator animator;
    /*0x60*/ UnityEngine.Coroutine projectileCoroutine;

    /*0x1c66eb4*/ prefab_fish_legend_essence();
    /*0x1c66c00*/ void Awake();
    /*0x1c65788*/ void SummonProjectiles();
    /*0x1c66c50*/ System.Collections.IEnumerator summonProjectilesCoroutine();
    /*0x1c66ce0*/ void startParty();
    /*0x1c66d30*/ System.Collections.IEnumerator summonFallingProjectilesCoroutine();
    /*0x1c66dc0*/ UnityEngine.Vector3 getRandomPointOfBox(UnityEngine.BoxCollider box);

    class <summonProjectilesCoroutine>d__13 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ prefab_fish_legend_essence <>4__this;

        /*0x1c66cb8*/ <summonProjectilesCoroutine>d__13(int <>1__state);
        /*0x1c66ed0*/ void System.IDisposable.Dispose();
        /*0x1c66ed4*/ bool MoveNext();
        /*0x1c67098*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1c670a0*/ void System.Collections.IEnumerator.Reset();
        /*0x1c670e0*/ object System.Collections.IEnumerator.get_Current();
    }

    class <summonFallingProjectilesCoroutine>d__15 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ prefab_fish_legend_essence <>4__this;
        /*0x28*/ int <i>5__2;

        /*0x1c66d98*/ <summonFallingProjectilesCoroutine>d__15(int <>1__state);
        /*0x1c670e8*/ void System.IDisposable.Dispose();
        /*0x1c670ec*/ bool MoveNext();
        /*0x1c6737c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1c67384*/ void System.Collections.IEnumerator.Reset();
        /*0x1c673c4*/ object System.Collections.IEnumerator.get_Current();
    }
}

class prefab_fish_legend_essence_background_prj : prefab_fish_legend_essence_prj
{
    /*0x1c674ac*/ prefab_fish_legend_essence_background_prj();
    /*0x1c673cc*/ void onUpdate();
}

class prefab_fish_legend_essence_prj : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject onExplodeParticle;
    /*0x20*/ bool fired;
    /*0x24*/ UnityEngine.Vector2 fireSpeed;
    /*0x30*/ UnityEngine.Renderer myRenderer;

    /*0x1c674b4*/ prefab_fish_legend_essence_prj();
    /*0x1c6736c*/ void Fire(UnityEngine.Vector2 fireSpeed);
    /*0x1c674bc*/ void Awake();
    /*0x1c67550*/ void Update();
    /*0x1c6755c*/ void onUpdate();
    /*0x1c6770c*/ void onExplode();
    /*0x1c678f0*/ void onTouched();
    /*0x1c67968*/ System.Collections.IEnumerator shirink();

    class <shirink>d__10 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ prefab_fish_legend_essence_prj <>4__this;

        /*0x1c679d0*/ <shirink>d__10(int <>1__state);
        /*0x1c679f8*/ void System.IDisposable.Dispose();
        /*0x1c679fc*/ bool MoveNext();
        /*0x1c67b5c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1c67b64*/ void System.Collections.IEnumerator.Reset();
        /*0x1c67ba4*/ object System.Collections.IEnumerator.get_Current();
    }
}

class prefab_fish_legend_mermaid : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Animator anim;
    /*0x20*/ UnityEngine.Transform trans_pos;
    /*0x28*/ UnityEngine.GameObject prefab_projectile;
    /*0x30*/ System.Collections.IEnumerator cor;

    /*0x1c67c70*/ prefab_fish_legend_mermaid();
    /*0x1c67bac*/ void WaitAndAttack();
    /*0x1c67be0*/ System.Collections.IEnumerator IE_WaitAndAttack();

    class <IE_WaitAndAttack>d__5 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ prefab_fish_legend_mermaid <>4__this;

        /*0x1c67c48*/ <IE_WaitAndAttack>d__5(int <>1__state);
        /*0x1c67c78*/ void System.IDisposable.Dispose();
        /*0x1c67c7c*/ bool MoveNext();
        /*0x1c67f30*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1c67f38*/ void System.Collections.IEnumerator.Reset();
        /*0x1c67f78*/ object System.Collections.IEnumerator.get_Current();
    }
}

class prefab_fish_legend_mermaid_face : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<UnityEngine.Texture2D> texture_faces;
    /*0x20*/ UnityEngine.SkinnedMeshRenderer rend;

    /*0x1c680a4*/ prefab_fish_legend_mermaid_face();
    /*0x1c67f80*/ void Change_Face(int no);
}

class prefab_fish_legend_mermaid_prj : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler
{
    /*0x18*/ UnityEngine.GameObject onExplodeParticle;
    /*0x20*/ bool reached;
    /*0x21*/ bool destroy;
    /*0x24*/ UnityEngine.Vector3 randomPos;

    /*0x1c68794*/ prefab_fish_legend_mermaid_prj();
    /*0x1c680ac*/ void Play(UnityEngine.Vector3 randomPos);
    /*0x1c680b8*/ void Update();
    /*0x1c68788*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
}

class prefab_har_004 : UnityEngine.MonoBehaviour
{
    /*0x1c687a0*/ prefab_har_004();
    /*0x1c6879c*/ void Open_win();
}

class prefab_hat : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject front;
    /*0x20*/ UnityEngine.GameObject back;

    /*0x1c687f0*/ prefab_hat();
    /*0x1c687a8*/ void Refresh_Side(bool isFront);
}

class prefab_map_hidden : SimplePool_element<data_hidden_element>
{
    /*0x28*/ UnityEngine.UI.Image img_icon;

    /*0x1c68d20*/ prefab_map_hidden();
    /*0x1c687f8*/ void OnEnable();
    /*0x1c688e8*/ void OnDisable();
    /*0x1c689d8*/ void Instantiate();
    /*0x1c68ae8*/ void Refresh_Sonar();
    /*0x1c68c1c*/ void LateUpdate();
    /*0x1c68bb4*/ System.Collections.IEnumerator IE_Sonar();

    class <IE_Sonar>d__6 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ prefab_map_hidden <>4__this;

        /*0x1c68cf8*/ <IE_Sonar>d__6(int <>1__state);
        /*0x1c68d68*/ void System.IDisposable.Dispose();
        /*0x1c68d6c*/ bool MoveNext();
        /*0x1c68ed4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1c68edc*/ void System.Collections.IEnumerator.Reset();
        /*0x1c68f1c*/ object System.Collections.IEnumerator.get_Current();
    }
}

class prefab_map_place : SimplePool_element<data_place_element>
{
    /*0x28*/ ui_button button;
    /*0x30*/ UnityEngine.UI.Image img_icon;
    /*0x38*/ UnityEngine.UI.Image img_quest;
    /*0x40*/ UnityEngine.UI.Image icon_charge;
    /*0x48*/ GarlicText.UI.HyperText text_time;
    /*0x50*/ GarlicText.UI.HyperText text_name;
    /*0x58*/ UnityEngine.UI.Image img_icon_disabled;
    /*0x60*/ GarlicText.UI.HyperText text_name_disabled;
    /*0x68*/ UnityEngine.GameObject panel_diabled;

    /*0x1c69e9c*/ prefab_map_place();
    /*0x1c68f24*/ void Awake();
    /*0x1c69048*/ void Instantiate();
    /*0x1c6915c*/ void Refresh_UI();
    /*0x1c694ec*/ void Refresh_Sec();
    /*0x1c69ce8*/ void OnClick();
}

class CycleOffsetStateMachine : UnityEngine.StateMachineBehaviour
{
    /*0x1ab6918*/ CycleOffsetStateMachine();
    /*0x1ab68b4*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class place_045_state_fight : UnityEngine.StateMachineBehaviour
{
    /*0x18*/ float min_shot_term;
    /*0x1c*/ float max_shot_term;
    /*0x20*/ float shot_term;
    /*0x24*/ float shot_term_count;

    /*0x1ab69d8*/ place_045_state_fight();
    /*0x1ab6920*/ void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
    /*0x1ab6944*/ void OnStateUpdate(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
    /*0x1ab69d4*/ void OnStateExit(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex);
}

class place_field_045_anim_manager : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Animator boss_animator;
    /*0x20*/ place_field_045_fish_spawner fish_spawner;
    /*0x28*/ place_field_045_anim_manager.manager_state state;
    /*0x30*/ System.Collections.Generic.List<UnityEngine.Transform> toy_attatch_points;
    /*0x38*/ System.Collections.Generic.List<int> toy_spawned_list;
    /*0x40*/ UnityEngine.Transform fish_spawn_position;
    /*0x48*/ UnityEngine.BoxCollider fish_float_box;
    /*0x50*/ UnityEngine.ParticleSystem boom_particle;

    /*0x1ab72e4*/ place_field_045_anim_manager();
    /*0x1ab69e0*/ void Start();
    /*0x1ab6a58*/ void Update();
    /*0x1ab6dd0*/ void OnDestroy();
    /*0x1ab6c88*/ void after_fight_done();
    /*0x1ab6f10*/ void throw_toy();
    /*0x1ab7118*/ void destroy_toy_and_summon_fish();
    /*0x1ab72c8*/ void play_boom_particle();

    enum manager_state
    {
        sleep = 0,
        idle = 1,
        fighting = 2,
        fight_failed = 3,
        fight_success = 4,
    }
}

class place_field_045_fish_object : UnityEngine.MonoBehaviour
{
    static float rotate_speed = 1200;
    /*0x18*/ UnityEngine.Mesh[] meshes;
    /*0x20*/ UnityEngine.GameObject move_target;
    /*0x28*/ UnityEngine.GameObject look_target;
    /*0x30*/ UnityEngine.GameObject mesh_target;
    /*0x38*/ UnityEngine.BoxCollider _boxCollider;
    /*0x40*/ float speed;
    /*0x44*/ float refresh_target_count_max;
    /*0x48*/ UnityEngine.MeshFilter meshFilter;
    /*0x50*/ place_field_045_fish_object.state cur_state;
    /*0x54*/ float refresh_target_count;
    /*0x58*/ float total_rotation_amount;
    /*0x5c*/ float current_rotation_amount;
    /*0x60*/ float _rotate_speed;
    /*0x64*/ float initial_rot;
    /*0x68*/ float target_rot;
    /*0x6c*/ float rot_time;
    /*0x70*/ float rot_time_count;
    /*0x78*/ UnityEngine.Transform spawn_position;
    /*0x80*/ UnityEngine.BoxCollider fish_float_box;
    /*0x88*/ int touch_counts_to_explode;
    /*0x8c*/ int touch_count;

    /*0x1ab8514*/ place_field_045_fish_object();
    /*0x1ab72ec*/ UnityEngine.BoxCollider get_boxCollider();
    /*0x1ab7380*/ void Awake();
    /*0x1ab73dc*/ void Update();
    /*0x1ab7418*/ void update_swim();
    /*0x1ab7794*/ void update_prepare_attack();
    /*0x1ab7fe4*/ float angle_between_points(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2);
    /*0x1ab7fa0*/ UnityEngine.Vector3 z_aligned_lookat(UnityEngine.Vector3 target);
    /*0x1ab7844*/ void update_look_player();
    /*0x1ab7a84*/ void update_attack_player();
    /*0x1ab8168*/ void initialize(int type, UnityEngine.Transform fish_spawn_pos, UnityEngine.BoxCollider fish_float_box);
    /*0x1ab7f5c*/ void refresh_target_pos();
    /*0x1ab8324*/ UnityEngine.Vector3 get_next_target_pos();
    /*0x1ab84c4*/ void onTouched();
    /*0x1ab8508*/ void force_attack_cancelled();
    /*0x1ab7e54*/ void update_attack_cancelled();

    enum state
    {
        swim = 0,
        prepare_attack = 1,
        look_player = 2,
        attack_player = 3,
        attack_cancelled = 4,
    }
}

class place_field_045_fish_spawner : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject fish_pool;
    /*0x20*/ UnityEngine.GameObject toy_pool;
    /*0x28*/ System.Collections.Generic.List<UnityEngine.GameObject> fish_list;
    /*0x30*/ System.Collections.Generic.List<UnityEngine.GameObject> toy_list;
    /*0x38*/ UnityEngine.ParticleSystem particle_boom;

    /*0x1ab8e5c*/ place_field_045_fish_spawner();
    /*0x1ab8538*/ void Start();
    /*0x1ab7050*/ UnityEngine.GameObject get_toy_object(int type, UnityEngine.GameObject attatch_point);
    /*0x1ab71f0*/ UnityEngine.GameObject get_fish_object(int type, UnityEngine.Transform fish_spawn_pos, UnityEngine.BoxCollider fish_spawn_box);
    /*0x1ab6e38*/ void fight_done();
    /*0x1ab8c44*/ UnityEngine.GameObject get_obj_from_pool(System.Collections.Generic.List<UnityEngine.GameObject> targetPool);
    /*0x1ab8020*/ void Play_Particle();
}

class place_field_045_toy_object : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Mesh[] meshes;
    /*0x20*/ UnityEngine.MeshFilter meshFilter;
    /*0x28*/ UnityEngine.GameObject attatch_point;

    /*0x1ab8f74*/ place_field_045_toy_object();
    /*0x1ab8e64*/ void Start();
    /*0x1ab8ef0*/ void Update();
    /*0x1ab8cf4*/ void initialize(int type, UnityEngine.GameObject attatch_point);
}

class prefab_place_conditionchecker : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<prefab_place_conditionchecker.PlaceActivateCondition> conditions_list;

    /*0x1ab965c*/ prefab_place_conditionchecker();
    /*0x1ab8f7c*/ void OnEnable();
    /*0x1ab95a4*/ void OnDisable();
    /*0x1ab903c*/ void Refresh_UI();
    /*0x1ab9664*/ int <Refresh_UI>b__4_1(prefab_place_conditionchecker.PlaceActivateCondition l);
    /*0x1ab96bc*/ int <Refresh_UI>b__4_4(prefab_place_conditionchecker.PlaceActivateCondition l);

    class PlaceActivateCondition
    {
        /*0x10*/ UnityEngine.GameObject obj;
        /*0x18*/ DimensionalConditionChecker condition_checker;

        /*0x1ab9774*/ PlaceActivateCondition();
        /*0x1ab9714*/ bool check_condition();
    }

    class <>c
    {
        static /*0x0*/ prefab_place_conditionchecker.<> <>9;
        static /*0x8*/ System.Func<prefab_place_conditionchecker.PlaceActivateCondition, bool> <>9__4_0;
        static /*0x10*/ System.Func<prefab_place_conditionchecker.PlaceActivateCondition, UnityEngine.GameObject> <>9__4_2;
        static /*0x18*/ System.Func<prefab_place_conditionchecker.PlaceActivateCondition, bool> <>9__4_3;
        static /*0x20*/ System.Func<prefab_place_conditionchecker.PlaceActivateCondition, UnityEngine.GameObject> <>9__4_5;

        static /*0x1ab977c*/ <>c();
        /*0x1ab97e0*/ <>c();
        /*0x1ab97e8*/ bool <Refresh_UI>b__4_0(prefab_place_conditionchecker.PlaceActivateCondition l);
        /*0x1ab97fc*/ UnityEngine.GameObject <Refresh_UI>b__4_2(prefab_place_conditionchecker.PlaceActivateCondition l);
        /*0x1ab9814*/ bool <Refresh_UI>b__4_3(prefab_place_conditionchecker.PlaceActivateCondition l);
        /*0x1ab9828*/ UnityEngine.GameObject <Refresh_UI>b__4_5(prefab_place_conditionchecker.PlaceActivateCondition l);
    }
}

class prefab_place_farm_000 : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.Dictionary<data_farm.Type, UnityEngine.Transform> _farm_parent;
    /*0x20*/ System.Collections.Generic.Dictionary<data_farm.Type, UnityEngine.GameObject> farm_prefab;
    /*0x28*/ ui_button button_gold;
    /*0x30*/ UnityEngine.UI.Image img_gold_fill;
    /*0x38*/ GarlicText.UI.HyperText text_gold_fill_left;
    /*0x40*/ UnityEngine.Transform pos_gold_effect;

    /*0x1abad64*/ prefab_place_farm_000();
    /*0x1ab9840*/ void OnEnable();
    /*0x1aba274*/ void OnDisable();
    /*0x1aba388*/ System.Collections.Generic.Dictionary<data_farm.Type, UnityEngine.Transform> get_farm_parent();
    /*0x1ab99ac*/ void Refresh_Skin();
    /*0x1aba114*/ void Refresh_Sec();
    /*0x1abac58*/ void Click_gold();
}

class prefab_place_harbor_003 : UnityEngine.MonoBehaviour
{
    /*0x1abae54*/ prefab_place_harbor_003();
    /*0x1abade0*/ void OnClick();
}

class prefab_place_legend : UnityEngine.MonoBehaviour
{
    /*0x18*/ float distance_max;
    /*0x20*/ UnityEngine.AudioSource audiosource;
    /*0x28*/ UnityEngine.ParticleSystem particle_rain;
    /*0x30*/ data_place_element place;
    /*0x38*/ UnityEngine.GameObject obj_legend_upgrade;
    /*0x40*/ GarlicText.UI.HyperText text_info;
    /*0x48*/ GarlicText.UI.HyperText text_price;
    /*0x50*/ UnityEngine.UI.Button button_upgrade;
    /*0x58*/ UnityEngine.Animator myAnim;
    /*0x60*/ UnityEngine.GameObject[] obj_lv;
    /*0x68*/ System.Collections.IEnumerator cor;

    /*0x1abbe64*/ prefab_place_legend();
    /*0x1abae5c*/ void OnEnable();
    /*0x1abb524*/ void OnDisable();
    /*0x1abb5dc*/ void Update();
    /*0x1abaf1c*/ void Refresh_UI();
    /*0x1abb74c*/ void OnClick();
    /*0x1abbc84*/ void Upgrade();
    /*0x1abbdd4*/ System.Collections.IEnumerator IE_Upgrade();
    /*0x1abbe6c*/ void <OnClick>b__14_0();

    class <IE_Upgrade>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ prefab_place_legend <>4__this;
        /*0x28*/ player_place_element <place_tmp>5__2;

        /*0x1abbe3c*/ <IE_Upgrade>d__17(int <>1__state);
        /*0x1abbe70*/ void System.IDisposable.Dispose();
        /*0x1abbe74*/ bool MoveNext();
        /*0x1abc028*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1abc030*/ void System.Collections.IEnumerator.Reset();
        /*0x1abc070*/ object System.Collections.IEnumerator.get_Current();
    }
}

class prefab_place_monument : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_lv;
    /*0x20*/ GarlicText.UI.HyperText text_info;
    /*0x28*/ GarlicText.UI.HyperText text_price;
    /*0x30*/ UnityEngine.UI.Button button_upgrade;
    /*0x38*/ data_place_element place;
    /*0x40*/ UnityEngine.ParticleSystem particle_upgrade;

    /*0x1abcbb8*/ prefab_place_monument();
    /*0x1abc078*/ void OnEnable();
    /*0x1abc3f0*/ void OnDisable();
    /*0x1abc138*/ void Refresh();
    /*0x1abc5f0*/ void OnClick();
    /*0x1abc950*/ void Upgrade();
    /*0x1abcbc0*/ void <OnClick>b__9_0();
}

class prefab_place_npc : UnityEngine.MonoBehaviour
{
    /*0x18*/ data_npc_element npc;
    /*0x20*/ int rank_now;
    /*0x28*/ System.Collections.Generic.List<string> _dialogues;
    /*0x30*/ UnityEngine.Transform parent_dialogue;
    /*0x38*/ GarlicText.UI.HyperText text_dialogue;
    /*0x40*/ System.Collections.IEnumerator cor;

    /*0x1abcdd0*/ prefab_place_npc();
    /*0x1abcbc4*/ void Awake();
    /*0x1abcc50*/ System.Collections.Generic.List<string> get_dialogues();
    /*0x1abcbe8*/ System.Collections.IEnumerator IE_dialogue();

    class <IE_dialogue>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ prefab_place_npc <>4__this;
        /*0x28*/ float <scale>5__2;

        /*0x1abcda8*/ <IE_dialogue>d__9(int <>1__state);
        /*0x1abcdd8*/ void System.IDisposable.Dispose();
        /*0x1abcddc*/ bool MoveNext();
        /*0x1abd210*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1abd218*/ void System.Collections.IEnumerator.Reset();
        /*0x1abd258*/ object System.Collections.IEnumerator.get_Current();
    }
}

class prefab_place_special_000 : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Transform circle;
    /*0x20*/ int[] scores;
    /*0x28*/ float move_round_mult;
    /*0x2c*/ float move_speed_div;
    /*0x30*/ float move_speed_min;
    /*0x38*/ player_place_element _myplace;
    /*0x40*/ bool isRunning;
    /*0x48*/ GarlicText.UI.HyperText text_time;
    /*0x50*/ int time_left;

    /*0x1abd7ec*/ prefab_place_special_000();
    /*0x1abd260*/ player_place_element get_myPlace();
    /*0x1abd304*/ void Run();
    /*0x1abd450*/ System.Collections.IEnumerator IE_Run(float target);
    /*0x1abd4f0*/ void OnEnable();
    /*0x1abd6c0*/ void OnDisable();
    /*0x1abd5b0*/ void Refresh_Sec();
    /*0x1abd778*/ void Help();

    enum State
    {
        idle = 0,
        running = 1,
    }

    class <IE_Run>d__11 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ prefab_place_special_000 <>4__this;
        /*0x28*/ float target;
        /*0x2c*/ UnityEngine.Vector3 <origin>5__2;
        /*0x38*/ float <now>5__3;
        /*0x3c*/ float <sound_rot>5__4;

        /*0x1abd4c8*/ <IE_Run>d__11(int <>1__state);
        /*0x1abd7f4*/ void System.IDisposable.Dispose();
        /*0x1abd7f8*/ bool MoveNext();
        /*0x1abddfc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1abde04*/ void System.Collections.IEnumerator.Reset();
        /*0x1abde44*/ object System.Collections.IEnumerator.get_Current();
    }
}

class prefab_place_special_001 : UnityEngine.MonoBehaviour
{
    /*0x18*/ player_place_element _myplace;
    /*0x20*/ prefab_place_special_001_cell[] cells;
    /*0x28*/ prefab_place_special_001_time timer_text;
    /*0x30*/ GarlicText.UI.HyperText text_score;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool playing;
    /*0x48*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat play_time_count;
    /*0x60*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat play_turn_max;
    /*0x78*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt play_score;
    /*0x88*/ prefab_place_special_001.mole_type[] mole_types;
    /*0x90*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt total_turns;
    /*0xa0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat total_play_time;

    /*0x1abed38*/ prefab_place_special_001();
    /*0x1abde4c*/ player_place_element get_myPlace();
    /*0x1abdef0*/ System.Collections.IEnumerator IE_Play();
    /*0x1abdf80*/ System.Collections.Generic.List<prefab_place_special_001.Keymap> Get_Keymap();
    /*0x1abe30c*/ void OnEnable();
    /*0x1abe534*/ void OnDisable();
    /*0x1abe3cc*/ void Refresh_Sec();
    /*0x1abe7c8*/ void button_start();
    /*0x1abe870*/ void button_help();
    /*0x1abe934*/ void button_cell(int no);

    class Keymap
    {
        /*0x10*/ int turn;
        /*0x14*/ int type;

        /*0x1abe2e0*/ Keymap(int turn, int type);
    }

    struct mole_type
    {
        /*0x10*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt num;
        /*0x20*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt score;
    }

    class <>c
    {
        static /*0x0*/ prefab_place_special_001.<> <>9;
        static /*0x8*/ System.Func<prefab_place_special_001_cell, bool> <>9__10_0;
        static /*0x10*/ System.Func<prefab_place_special_001.Keymap, int> <>9__14_0;

        static /*0x1abed40*/ <>c();
        /*0x1abeda4*/ <>c();
        /*0x1abedac*/ bool <IE_Play>b__10_0(prefab_place_special_001_cell s);
        /*0x1abedcc*/ int <Get_Keymap>b__14_0(prefab_place_special_001.Keymap s);
    }

    class <IE_Play>d__10 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ prefab_place_special_001 <>4__this;
        /*0x28*/ System.Collections.Generic.List<prefab_place_special_001.Keymap> <play_keys>5__2;
        /*0x30*/ float <secondsPerTurn>5__3;

        /*0x1abdf58*/ <IE_Play>d__10(int <>1__state);
        /*0x1abede4*/ void System.IDisposable.Dispose();
        /*0x1abede8*/ bool MoveNext();
        /*0x1abfe00*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1abfe08*/ void System.Collections.IEnumerator.Reset();
        /*0x1abfe48*/ object System.Collections.IEnumerator.get_Current();
    }
}

class prefab_place_special_001_cell : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Animator myAnim;
    /*0x20*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt type;
    /*0x30*/ UnityEngine.Coroutine playCoroutine;
    /*0x38*/ bool <isPlaying>k__BackingField;

    /*0x1abff40*/ prefab_place_special_001_cell();
    /*0x1abfcfc*/ void Play(int type);
    /*0x1abfe50*/ System.Collections.IEnumerator IE_Play();
    /*0x1abeb20*/ void Click();
    /*0x1abfd8c*/ void Stop();
    /*0x1abff04*/ bool get_isPlaying();
    /*0x1abff0c*/ void set_isPlaying(bool value);
    /*0x1abff18*/ void Anim_isPlaying_false();
    /*0x1abfee0*/ void stopGameplayCoroutine();

    class <IE_Play>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ prefab_place_special_001_cell <>4__this;
        /*0x28*/ float <timer>5__2;

        /*0x1abfeb8*/ <IE_Play>d__4(int <>1__state);
        /*0x1abff48*/ void System.IDisposable.Dispose();
        /*0x1abff4c*/ bool MoveNext();
        /*0x1ac00e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1ac00f0*/ void System.Collections.IEnumerator.Reset();
        /*0x1ac0130*/ object System.Collections.IEnumerator.get_Current();
    }
}

class prefab_place_special_001_time : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_time;
    /*0x20*/ string value_now;
    /*0x28*/ bool showTime;
    /*0x2c*/ UnityEngine.Vector3 rot_back;

    /*0x1ac02b8*/ prefab_place_special_001_time();
    /*0x1abe6f8*/ void Set_timer_text(bool playing, int time);
    /*0x1ac0138*/ void Update();
}

class prefab_place_special_002 : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Transform pos_effect;
    /*0x20*/ GarlicText.UI.HyperText text_time;
    /*0x28*/ GarlicText.UI.HyperText text_ready;
    /*0x30*/ int time_left;

    /*0x1ac07c0*/ prefab_place_special_002();
    /*0x1ac02d0*/ player_place_element get_myPlace();
    /*0x1ac0360*/ void OnEnable();
    /*0x1ac0644*/ void OnDisable();
    /*0x1ac0470*/ void Refresh();
    /*0x1ac074c*/ void Help();
}

class prefab_place_special_003 : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Transform pos_effect;

    /*0x1ac08cc*/ prefab_place_special_003();
    /*0x1ac07c8*/ player_place_element get_myPlace();
    /*0x1ac0858*/ void Help();
}

class prefab_place_special_alchemy : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Transform pos_effect;
    /*0x20*/ System.Collections.Generic.List<UnityEngine.UI.Button> button_play;
    /*0x28*/ GarlicText.UI.HyperText text_time;
    /*0x30*/ UnityEngine.Animator myAnim;
    /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt reward_mastery;
    /*0x48*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt reward_gem;
    /*0x58*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt potion_num_charge;
    /*0x68*/ data_currency_element cur_target;
    /*0x70*/ System.Collections.IEnumerator cor;
    /*0x78*/ int time_left;

    /*0x1ac1470*/ prefab_place_special_alchemy();
    /*0x1ac08d4*/ player_place_element get_myPlace();
    /*0x1ac0964*/ void Play_all(data_currency_element cur_target);
    /*0x1ac0b84*/ void Play(bool use_potion, int potion_count);
    /*0x1ac0c48*/ System.Collections.IEnumerator IE_Play(bool use_potion, int potion_count);
    /*0x1ac0cf4*/ System.Collections.Generic.List<CurNumPair> calculate_reward(int potion_count);
    /*0x1ac1120*/ void OnEnable();
    /*0x1ac12f4*/ void OnDisable();
    /*0x1ac1230*/ void Refresh();
    /*0x1ac13fc*/ void Help();
    /*0x1ac14d8*/ void <Play_all>b__9_0(int x);

    class <IE_Play>d__13 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ prefab_place_special_alchemy <>4__this;
        /*0x28*/ bool use_potion;
        /*0x2c*/ int potion_count;
        /*0x30*/ int <cnt_button>5__2;

        /*0x1ac0ccc*/ <IE_Play>d__13(int <>1__state);
        /*0x1ac14e4*/ void System.IDisposable.Dispose();
        /*0x1ac14e8*/ bool MoveNext();
        /*0x1ac1b2c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1ac1b34*/ void System.Collections.IEnumerator.Reset();
        /*0x1ac1b74*/ object System.Collections.IEnumerator.get_Current();
    }
}

class prefab_place_special_portal : UnityEngine.MonoBehaviour
{
    /*0x18*/ ui_button button_portal;
    /*0x20*/ ui_button button_npc;
    /*0x28*/ UnityEngine.Animator animator;
    /*0x30*/ GarlicText.UI.HyperText text_difficulty;
    /*0x38*/ GarlicText.UI.HyperText text_max;

    /*0x1ac221c*/ prefab_place_special_portal();
    /*0x1ac1b7c*/ void OnEnable();
    /*0x1ac1ce8*/ void OnDisable();
    /*0x1ac1c3c*/ void Refresh_UI();
    /*0x1ac1dcc*/ void deactivate_door();
    /*0x1ac1e64*/ void activate_door();
    /*0x1ac1f74*/ void block_button();
    /*0x1ac1da0*/ void unblock_button();
    /*0x1ac1f9c*/ void OnClick_Alex();
    /*0x1ac2010*/ void OnClick_portal();
}

class prefab_place_special_portal_anim : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.MeshRenderer[] meshRenderers;
    /*0x20*/ UnityEngine.AudioSource audioSource;
    /*0x28*/ float emission;
    /*0x2c*/ float volume;
    /*0x30*/ float distance_max;
    /*0x34*/ UnityEngine.Color color;

    /*0x1ac233c*/ prefab_place_special_portal_anim();
    /*0x1ac2224*/ void Update();
}

class prefab_ship : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Transform pos_character;
    /*0x20*/ UnityEngine.Transform pos_inven;
    /*0x28*/ UnityEngine.Transform pos_skill;
    /*0x30*/ UnityEngine.Transform[] pos_turret;
    /*0x38*/ UnityEngine.ParticleSystem[] particles_idle;
    /*0x40*/ UnityEngine.ParticleSystem[] particles_move;

    /*0x1ac2454*/ prefab_ship();
    /*0x1ac234c*/ void Set_particles(int state);

    enum State
    {
        idle = 0,
        move = 1,
    }
}

class prefab_turret : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Animator animator;
    /*0x20*/ UnityEngine.Transform look_targeter;
    /*0x28*/ UnityEngine.Vector3 look_target_pos;
    /*0x34*/ float wait_time;
    /*0x38*/ UnityEngine.Transform trans_hor;
    /*0x40*/ UnityEngine.Transform trans_ver;

    /*0x1ac29fc*/ prefab_turret();
    /*0x1ac245c*/ void Awake();
    /*0x1ac2488*/ void Anim_Play(anim_turret.State state);
    /*0x1ac2550*/ void Anim_activate(bool active);
    /*0x1ac2600*/ void LateUpdate();
    /*0x1ac2858*/ void Set_Lookat(UnityEngine.Vector3 target_pos);
    /*0x1ac282c*/ UnityEngine.Vector3 Get_random_pos();
}

class Refresher
{
    static /*0x0*/ UnityEngine.Events.UnityEvent Save;
    static /*0x8*/ UnityEngine.Events.UnityEvent Load;
    static /*0x10*/ UnityEngine.Events.UnityEvent Initiate;
    static /*0x18*/ UnityEngine.Events.UnityEvent UI;
    static /*0x20*/ UnityEngine.Events.UnityEvent Sec;
    static /*0x28*/ UnityEngine.Events.UnityEvent Skin;
    static /*0x30*/ UnityEngine.Events.UnityEvent Place;
    static /*0x38*/ UnityEngine.Events.UnityEvent AfterDimensionChanged;

    static /*0x1ac2a0c*/ Refresher();
    /*0x1ac2a04*/ Refresher();
}

class sound : UnityEngine.MonoBehaviour
{
    static float VOLUME_MIN = -20;
    static float VOLUME_ZERO = -80;
    static /*0x0*/ sound ins;
    /*0x18*/ System.Collections.Generic.List<UnityEngine.AudioClip> list;
    /*0x20*/ System.Collections.Generic.Dictionary<string, UnityEngine.AudioClip> dic;
    /*0x28*/ UnityEngine.AudioSource ambient;
    /*0x30*/ UnityEngine.AudioSource ambient_move;
    /*0x38*/ System.Collections.Generic.Dictionary<string, UnityEngine.AudioSource> channels;
    /*0x40*/ UnityEngine.AudioSource sfx;
    /*0x48*/ UnityEngine.Audio.AudioMixer mixer;
    /*0x50*/ System.Collections.Generic.Dictionary<sound.group_type, UnityEngine.Audio.AudioMixerGroup> dic_group;
    /*0x58*/ UnityEngine.Audio.AudioMixerGroup group_ambient;
    /*0x60*/ UnityEngine.Audio.AudioMixerGroup group_bgm;
    /*0x68*/ UnityEngine.Audio.AudioMixerGroup group_sfx;

    /*0x1ac3898*/ sound();
    /*0x1ac2b80*/ void Awake();
    /*0x1ac3038*/ void Update();
    /*0x1ac2c50*/ void Awake_ins();
    /*0x1ac3220*/ UnityEngine.AudioClip Get_Clip(string name);
    /*0x1ac2d10*/ void Awake_dic();
    /*0x1ac32dc*/ void Refresh_Init();
    /*0x1ac3304*/ System.Collections.IEnumerator IE_Play_Ambient();
    /*0x1ac303c*/ void Update_Ambient_move();
    /*0x1ac34f0*/ UnityEngine.AudioSource Get_Channel(string chan);
    /*0x1abfc18*/ void Play_Channel(string chan, string clip_name, bool loop, sound.group_type group);
    /*0x1ac36b8*/ void Play_Channel(string chan, UnityEngine.AudioClip clip, bool loop, sound.group_type group);
    /*0x1abe664*/ void Stop_Channel(string chan);
    /*0x1ac336c*/ void Stop_Channel_All();
    /*0x1ab80c0*/ void Play_Sfx(string code);
    /*0x1ac378c*/ void Play_Sfx(UnityEngine.AudioClip clip);
    /*0x1ac2fb0*/ void Awake_Group();
    /*0x1ac37a8*/ void Set_Group_Volume(sound.group_type group, float rate);

    enum group_type
    {
        ambient = 0,
        bgm = 1,
        sfx = 2,
    }

    class <IE_Play_Ambient>d__10 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ sound <>4__this;

        /*0x1ac34c8*/ <IE_Play_Ambient>d__10(int <>1__state);
        /*0x1ac3958*/ void System.IDisposable.Dispose();
        /*0x1ac395c*/ bool MoveNext();
        /*0x1ac3a60*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1ac3a68*/ void System.Collections.IEnumerator.Reset();
        /*0x1ac3aa8*/ object System.Collections.IEnumerator.get_Current();
    }
}

class sound_onEnable : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.AudioClip clip;

    /*0x1ac3b1c*/ sound_onEnable();
    /*0x1ac3ab0*/ void OnEnable();
}

class sound_player : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.AudioClip sfx;

    /*0x1ac3bfc*/ sound_player();
    /*0x1ac3b24*/ void Play_Sfx();
    /*0x1ac3b90*/ void Play_Sfx_Clip(UnityEngine.AudioClip sfx);
}

class Ambient_Controller : UnityEngine.MonoBehaviour
{
    static /*0x0*/ Ambient_Controller ins;
    /*0x18*/ UnityEngine.Camera MainCam;
    /*0x20*/ CubemapMng cubemapMng;
    /*0x28*/ UnityEngine.SpriteRenderer skyEnd;
    /*0x30*/ UnityEngine.Color color_skyEnd;
    /*0x40*/ UnityEngine.Color color_sky;
    /*0x50*/ UnityEngine.Color color_ambient;
    /*0x60*/ float diff_Sum_Max;
    /*0x64*/ UnityEngine.Color color_skyEnd_lastframe;
    /*0x74*/ UnityEngine.Color color_sky_lastframe;
    /*0x84*/ UnityEngine.Color color_zero;
    /*0x94*/ float diff_Sum;

    /*0x1ac40b0*/ Ambient_Controller();
    /*0x1ac3c04*/ void Awake();
    /*0x1ac3d34*/ void Update();
    /*0x1ac3d38*/ void Update_Ambient();
}

class Animator_material : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Color color;
    /*0x28*/ Animator_material.Animator_materail_pair[] materials;

    /*0x1ac4118*/ Animator_material();
    /*0x1ac40c0*/ void Update();

    class Animator_materail_pair
    {
        /*0x10*/ UnityEngine.MeshRenderer meshRenderer;
        /*0x18*/ string color_name;
        /*0x20*/ UnityEngine.Material _mat;

        /*0x1ac41a8*/ Animator_materail_pair();
        /*0x1ac4120*/ UnityEngine.Material get_material();
        /*0x1ac40c4*/ void Set_Color(UnityEngine.Color color);
    }
}

class Animator_paramSetter : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Animator _myAnim;
    /*0x20*/ System.Collections.Generic.Dictionary<string, bool> dic_bool;
    /*0x28*/ System.Collections.Generic.Dictionary<string, int> dic_int;
    /*0x30*/ System.Collections.Generic.Dictionary<string, float> dic_float;

    /*0x1ac47b0*/ Animator_paramSetter();
    /*0x1ac41b0*/ UnityEngine.Animator get_myAnim();
    /*0x1ac4244*/ void OnEnable();
    /*0x1ac4264*/ System.Collections.IEnumerator Enabler();
    /*0x1ac42f4*/ void Set_bool(string key, bool b);
    /*0x1ac43e0*/ System.Collections.IEnumerator Anim_Set_bool(string key, bool b);
    /*0x1ac4488*/ void Set_int(string key, int i);
    /*0x1ac4574*/ System.Collections.IEnumerator Anim_Set_int(string key, int i);
    /*0x1ac4618*/ void Set_float(string key, float f);
    /*0x1ac4704*/ System.Collections.IEnumerator Anim_Set_float(string key, float f);

    class <Enabler>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Animator_paramSetter <>4__this;

        /*0x1ac42cc*/ <Enabler>d__4(int <>1__state);
        /*0x1ac48b4*/ void System.IDisposable.Dispose();
        /*0x1ac48b8*/ bool MoveNext();
        /*0x1ac4d98*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1ac4da0*/ void System.Collections.IEnumerator.Reset();
        /*0x1ac4de0*/ object System.Collections.IEnumerator.get_Current();
    }

    class <Anim_Set_bool>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Animator_paramSetter <>4__this;
        /*0x28*/ string key;
        /*0x30*/ bool b;

        /*0x1ac4460*/ <Anim_Set_bool>d__7(int <>1__state);
        /*0x1ac4de8*/ void System.IDisposable.Dispose();
        /*0x1ac4dec*/ bool MoveNext();
        /*0x1ac4e9c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1ac4ea4*/ void System.Collections.IEnumerator.Reset();
        /*0x1ac4ee4*/ object System.Collections.IEnumerator.get_Current();
    }

    class <Anim_Set_int>d__10 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Animator_paramSetter <>4__this;
        /*0x28*/ string key;
        /*0x30*/ int i;

        /*0x1ac45f0*/ <Anim_Set_int>d__10(int <>1__state);
        /*0x1ac4eec*/ void System.IDisposable.Dispose();
        /*0x1ac4ef0*/ bool MoveNext();
        /*0x1ac4fa0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1ac4fa8*/ void System.Collections.IEnumerator.Reset();
        /*0x1ac4fe8*/ object System.Collections.IEnumerator.get_Current();
    }

    class <Anim_Set_float>d__13 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Animator_paramSetter <>4__this;
        /*0x28*/ string key;
        /*0x30*/ float f;

        /*0x1ac4788*/ <Anim_Set_float>d__13(int <>1__state);
        /*0x1ac4ff0*/ void System.IDisposable.Dispose();
        /*0x1ac4ff4*/ bool MoveNext();
        /*0x1ac50a4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1ac50ac*/ void System.Collections.IEnumerator.Reset();
        /*0x1ac50ec*/ object System.Collections.IEnumerator.get_Current();
    }
}

class Animator_particles : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<UnityEngine.ParticleSystem> particles;

    /*0x1ac51fc*/ Animator_particles();
    /*0x1ac50f4*/ void particle_play(int no);
}

class CubemapMng : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Camera mainCam;
    /*0x20*/ UnityEngine.GameObject[] obj_Fader;
    /*0x28*/ UnityEngine.Camera bakerCam;
    /*0x30*/ UnityEngine.Cubemap myCubemap;

    /*0x1ac530c*/ CubemapMng();
    /*0x1ac5278*/ void Awake();
    /*0x1ac3f6c*/ void BakeCubemap();
}

class CurNumPair
{
    /*0x10*/ data_currency_element currency;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble num;

    /*0x1ac5314*/ CurNumPair();
    /*0x1ac0fb8*/ CurNumPair(data_currency_element currency, double num);
    /*0x1abbbe4*/ string toStringFormat(bool withIcon);
}

class CurrencyCodeMapper
{
    static /*0x0*/ System.Collections.Generic.Dictionary<string, string> SymbolsByCode;

    static /*0x1ac541c*/ CurrencyCodeMapper();
    static /*0x1ac539c*/ string GetSymbol(string code);

    class <>c
    {
        static /*0x0*/ CurrencyCodeMapper.<> <>9;

        static /*0x1ac58f8*/ <>c();
        /*0x1ac595c*/ <>c();
        /*0x1ac5964*/ System.Globalization.RegionInfo <.cctor>b__2_0(System.Globalization.CultureInfo x);
    }
}

class EnumUtil
{
    static System.Collections.Generic.IEnumerable<T> GetValues<T>();
}

class anim_looseForce : UnityEngine.MonoBehaviour
{
    /*0x18*/ float loseSpeed;
    /*0x20*/ UnityEngine.Rigidbody _rigidbody;

    /*0x1ac5c1c*/ anim_looseForce();
    /*0x1ac59e4*/ UnityEngine.Rigidbody get_rigidbody();
    /*0x1ac5a78*/ void LateUpdate();
}

class DimensionalConditionChecker
{
    /*0x10*/ DimensionalConditionChecker.Check_Mode check_mode;
    /*0x18*/ System.Collections.Generic.List<DimensionalConditionChecker.Condition> conditions;

    /*0x1ac61c0*/ DimensionalConditionChecker();
    /*0x1ac5c24*/ void Add_Condition(DimensionalConditionChecker.Condition.Condition_Type type, int target_rank, int target_dimension, data_quest_element target_quest, data_place_element target_place);
    /*0x1ab9750*/ bool check_condition();
    /*0x1ac5d88*/ bool check_condition_internal();

    class Condition
    {
        /*0x10*/ DimensionalConditionChecker.Condition.Condition_Type type;
        /*0x14*/ bool deceived_by_fake_base;
        /*0x18*/ int target_rank;
        /*0x1c*/ int target_dimension;
        /*0x20*/ int target_difficulty;
        /*0x28*/ data_quest_element target_quest;
        /*0x30*/ data_place_element target_place;

        /*0x1ac5d80*/ Condition();
        /*0x1ac5f00*/ bool check_condition();
        /*0x1ac61c8*/ int get_current_dimension_rank();

        enum Condition_Type
        {
            Rank_Over = 0,
            Rank_Base_Over = 1,
            Reach_Rank = 2,
            Reach_Rank_Base = 3,
            Base_Dimension = 4,
            Parallel_Dimension = 5,
            Parallel_Difficulty = 6,
            Parallel_Difficulty_Is_Not = 9,
            Clear_Quest = 7,
            Arrive_Place = 8,
            Highest_Cleared_Dimension = 10,
        }
    }

    enum Check_Mode
    {
        Always_Valid = 0,
        Always_Invalid = 1,
        Check_Conditions = 2,
    }
}

class EmailValidityChecker
{
    static /*0x0*/ System.Text.RegularExpressions.Regex ValidEmailRegex;

    static /*0x1ac63a8*/ EmailValidityChecker();
    static /*0x1ac62c4*/ System.Text.RegularExpressions.Regex CreateValidEmailRegex();
    static /*0x1ac633c*/ bool EmailIsValid(string emailAddress);
}

class MyDebug
{
    static /*0x1ab6ce4*/ void Log(string s);
    static /*0x1ac63f4*/ void Log(object obj);
    static /*0x1ac1058*/ void print(string s);
    static /*0x1ac6414*/ void print(object obj);
    /*0x1ac6434*/ MyDebug();
}

struct ItemNeedOwnPair
{
    /*0x10*/ data_item_element item;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt need;
    /*0x28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt own;

    /*0x1ac643c*/ ItemNeedOwnPair(data_item_element item, int need, int own);
}

class ItemNumPair
{
    /*0x10*/ data_item_element element;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt num;

    /*0x1ac64cc*/ ItemNumPair();
    /*0x1ac653c*/ ItemNumPair(string name, int num);
    /*0x1ac65fc*/ ItemNumPair(data_item_element element, int num);
}

class ItemNumPair_List
{
    /*0x10*/ System.Collections.Generic.List<ItemNumPair> lists;

    /*0x1ac667c*/ ItemNumPair_List();
    /*0x1ac6720*/ ItemNumPair_List(SimpleJSON_Ex.JSONNode json);
    /*0x1ac67b4*/ void Set_Json(SimpleJSON_Ex.JSONNode json);
    /*0x1ac6a30*/ SimpleJSON_Ex.JSONNode Get_Json();
    /*0x1ac6c48*/ void Add(ItemNumPair item);
    /*0x1ac6ee4*/ int Get_num(data_item_element item);
}

class JiggleBone : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Transform thisParent;
    /*0x20*/ UnityEngine.Rigidbody thisRigidbody;
    /*0x28*/ UnityEngine.Vector3 rotation_origin;
    /*0x34*/ UnityEngine.Vector3 localPosition_origin;
    /*0x40*/ UnityEngine.Vector3 parentPosLastFrame;
    /*0x4c*/ bool freeze_rot_x;
    /*0x4d*/ bool freeze_rot_y;
    /*0x4e*/ bool freeze_rot_z;

    /*0x1ac73a8*/ JiggleBone();
    /*0x1ac70cc*/ void Awake();
    /*0x1ac71c0*/ void Update();
}

class Linerenderer_Link : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Transform pos_target;
    /*0x20*/ UnityEngine.LineRenderer _LR;
    /*0x28*/ float offset;
    /*0x2c*/ bool Uv_Anim;

    /*0x1ac75c4*/ Linerenderer_Link();
    /*0x1ac7408*/ UnityEngine.LineRenderer get_LR();
    /*0x1ac749c*/ void Update();
}

class Mathd
{
    static /*0x1ac75cc*/ double Lerp(double a, double b, float t);
    /*0x1ac766c*/ Mathd();
}

class MonthDatePair
{
    /*0x10*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt month;
    /*0x20*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt day;

    /*0x1ac7674*/ MonthDatePair(int month, int day);
    /*0x1ac7700*/ System.DateTime Get_DateTime(int year);
}

class myFunctions
{
    /*0x1ac77a8*/ myFunctions();
    /*0x1ac77a4*/ void a();
}

class PlatformEnabler : UnityEngine.MonoBehaviour
{
    /*0x18*/ bool Ios;
    /*0x19*/ bool Ios_Ipad;
    /*0x1a*/ bool Android;

    /*0x1ac77d8*/ PlatformEnabler();
    /*0x1ac77b0*/ void Awake();
}

class Projectile : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Transform <_parent>k__BackingField;
    /*0x20*/ UnityEngine.Animator _animator;
    /*0x28*/ float time_shot;
    /*0x2c*/ float time_exp;
    /*0x30*/ System.Collections.IEnumerator cor;

    /*0x1ac7b60*/ Projectile();
    /*0x1ac77e0*/ UnityEngine.Transform get__parent();
    /*0x1ac77e8*/ void set__parent(UnityEngine.Transform value);
    /*0x1ac77f0*/ UnityEngine.Transform get_parent();
    /*0x1ac7880*/ UnityEngine.Animator get_animator();
    /*0x1ac7914*/ void Shot(UnityEngine.Transform target);
    /*0x1ac7964*/ System.Collections.IEnumerator IE_Shot(UnityEngine.Transform target);
    /*0x1ac7a00*/ void Reload();

    enum anim_trigger
    {
        idle = 0,
        shot = 1,
        exp = 2,
    }

    class <IE_Shot>d__14 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ Projectile <>4__this;
        /*0x28*/ UnityEngine.Transform target;
        /*0x30*/ UnityEngine.Vector3 <pos_start>5__2;
        /*0x3c*/ UnityEngine.Vector3 <pos_target>5__3;
        /*0x48*/ float <time_moved>5__4;

        /*0x1ac79d8*/ <IE_Shot>d__14(int <>1__state);
        /*0x1ac7b68*/ void System.IDisposable.Dispose();
        /*0x1ac7b6c*/ bool MoveNext();
        /*0x1ac7e0c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1ac7e14*/ void System.Collections.IEnumerator.Reset();
        /*0x1ac7e54*/ object System.Collections.IEnumerator.get_Current();
    }
}

class RankLvPair
{
    /*0x10*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt lv;
    /*0x20*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt rank;

    /*0x1ac7e5c*/ RankLvPair();
    /*0x1ac7ed8*/ RankLvPair(int lv, int rank);
}

class SimplePool<T>
{
    /*0x0*/ System.Collections.Generic.Stack<SimplePool_element<T>> element_pool;
    /*0x0*/ System.Collections.Generic.List<SimplePool_element<T>> element_using;
    /*0x0*/ UnityEngine.GameObject prefab;
    /*0x0*/ UnityEngine.Transform parent;
    /*0x0*/ bool worldPositionStays;

    SimplePool(UnityEngine.GameObject prefab, UnityEngine.Transform parent, bool worldPositionStays);
    void Add_Pool(int num);
    void Add_Pool();
    void Add_Use(int num, T data);
    void Add_Use(T data);
    void Use_withList(System.Collections.Generic.List<T> datas);
    void Use_withList(System.Collections.Generic.List<T> datas, UnityEngine.Transform parent);
    void Change_parent(UnityEngine.Transform parent);
    void Destroy(int num);
    void Destroy();
    void Destroy(SimplePool_element<T> item);
    void Destroy_All();
    SimplePool_element<T> Get_Element(T data);
    int get_element_using_count();
    SimplePool_element<T> find_element(T data);
    void SendMessageToElements(string methodName, object value);

    class <>c__DisplayClass11_0<T>
    {
        /*0x0*/ System.Collections.Generic.IEnumerable<T> datas_toRemove;
        /*0x0*/ System.Collections.Generic.List<T> datas;

        <>c__DisplayClass11_0();
        bool <Use_withList>b__1(SimplePool_element<T> element);
        int <Use_withList>b__2(SimplePool_element<T> element);
    }

    class <>c<T>
    {
        static /*0x0*/ SimplePool.<>c<T> <>9;
        static /*0x0*/ System.Func<SimplePool_element<T>, T> <>9__11_0;
        static /*0x0*/ System.Func<SimplePool_element<T>, int> <>9__12_0;

        static <>c();
        <>c();
        T <Use_withList>b__11_0(SimplePool_element<T> element);
        int <Change_parent>b__12_0(SimplePool_element<T> element);
    }
}

class SimplePool_Dummy : SimplePool_element<int>
{
    /*0x1ac7fac*/ SimplePool_Dummy();
    /*0x1ac7f64*/ void Instantiate();
}

class SimplePool_element<T> : UnityEngine.MonoBehaviour
{
    /*0x0*/ SimplePool<T> pool_parent;
    /*0x0*/ T <Data>k__BackingField;

    SimplePool_element();
    void set_Data(T value);
    T get_Data();
    void Instantiate(T data);
    void Instantiate();
    void Destroy();
}

class SkinNumPair
{
    /*0x10*/ data_skin_element element;
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble num;

    /*0x1ac7ff4*/ SkinNumPair();
    /*0x1ac807c*/ SkinNumPair(data_skin_element element, double num);
}

class stringFormat
{
    static /*0x0*/ SimpleJSON_Ex.JSONNode _lang_json;
    static /*0x8*/ string[] units;

    static /*0x1ac95b4*/ stringFormat();
    static /*0x1ac811c*/ UnityEngine.TextAsset get_lang_text();
    static /*0x1ac8200*/ SimpleJSON_Ex.JSONNode get_lang_json();
    static /*0x1abd1a4*/ string get_language(string code);
    static /*0x1ac83f0*/ string get_language(string code, object[] options);
    static /*0x1ac8468*/ string get_language(string code, stringFormat.lang_type lang);
    static /*0x1ac82bc*/ string get_language(string code, stringFormat.lang_type lang, object[] options);
    static /*0x1ac84d0*/ bool has_language(string code);
    static /*0x1abc56c*/ string get_quad(string type);
    static /*0x1ac85b8*/ string compare_now_max(double now, double max, bool red);
    static /*0x1ac8708*/ string compare_need(data_currency_element currency, double now, double need, bool red);
    static /*0x1ac886c*/ string sec_toTime(int sec);
    static /*0x1ac88c4*/ string sec_toTime(float sec);
    static /*0x1ac8934*/ string sec_toTime(double sec);
    static /*0x1aba7b4*/ string sec_toTime(int sec, bool icon);
    static /*0x1ac89a4*/ string sec_toTime_short(double sec, bool show_icon, int needUnitNum, bool removeSecond);
    static /*0x1ac8ffc*/ System.TimeSpan Ceil_Seconds(System.TimeSpan time, double ceilSec);
    static /*0x1ac9098*/ string bigNum_toString(int num);
    static /*0x1ac9354*/ string bigNum_toString(float num);
    static /*0x1abc4a8*/ string bigNum_toString(double num);
    static /*0x1ac9104*/ string bigNum_toString(string num);
    static /*0x1ac941c*/ string need_rank(int rank, int fontsize);
    /*0x1ac95ac*/ stringFormat();

    enum lang_type
    {
        en = 0,
        kr = 1,
        jp = 2,
        ch = 3,
        tw = 4,
    }
}

class ui_bottom : UnityEngine.MonoBehaviour
{
    /*0x18*/ ui_button_selectable button_gem;
    /*0x20*/ ui_button_selectable button_mastery;
    /*0x28*/ ui_button_selectable button_amber;
    /*0x30*/ ui_button_selectable button_dimension;
    /*0x38*/ GarlicText.UI.HyperText text_inven_size;
    /*0x40*/ UnityEngine.GameObject icon_harbor;
    /*0x48*/ UnityEngine.GameObject icon_invenFull;

    /*0x1aca914*/ ui_bottom();
    /*0x1aca478*/ void OnEnable();
    /*0x1aca85c*/ void OnDisable();
    /*0x1aca57c*/ void Refresh();
}

class ui_bottom_button_gold : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Image img_noice;

    /*0x1acabf4*/ ui_bottom_button_gold();
    /*0x1aca91c*/ void OnEnable();
    /*0x1acab3c*/ void OnDisable();
    /*0x1acaa20*/ void Refresh();
}

class ui_bottom_button_skill : UnityEngine.MonoBehaviour
{
    /*0x18*/ ui_button_selectable button;
    /*0x20*/ GarlicText.UI.HyperText text_skill_mana;
    /*0x28*/ UnityEngine.UI.Image img_noice;

    /*0x1acb000*/ ui_bottom_button_skill();
    /*0x1acabfc*/ void OnEnable();
    /*0x1acaf48*/ void OnDisable();
    /*0x1acad00*/ void Refresh();
}

class ui_bottom_page_amber : ui_win_base
{
    /*0x20*/ UnityEngine.GameObject obj_essence;
    /*0x28*/ UnityEngine.UI.Image img_farm;
    /*0x30*/ UnityEngine.UI.Image img_farm_glow;

    /*0x1acb4b4*/ ui_bottom_page_amber();
    /*0x1acb008*/ void OnEnable();
    /*0x1acb198*/ void OnDisable();
    /*0x1acb10c*/ void Refresh_UI();
    /*0x1acb250*/ void Update();
    /*0x1acb340*/ void Click_Amber();
}

class ui_bottom_page_amber_cell : UnityEngine.MonoBehaviour
{
    /*0x18*/ data_place_element place;
    /*0x20*/ UnityEngine.GameObject panel_normal;
    /*0x28*/ UnityEngine.GameObject panel_disabled;
    /*0x30*/ GarlicText.UI.HyperText text_name;
    /*0x38*/ GarlicText.UI.HyperText text_info;
    /*0x40*/ GarlicText.UI.HyperText text_lv;
    /*0x48*/ GarlicText.UI.HyperText text_need;
    /*0x50*/ GarlicText.UI.HyperText text_needRank;
    /*0x58*/ ui_button button_refund;

    /*0x1acbeb0*/ ui_bottom_page_amber_cell();
    /*0x1acb4bc*/ void OnEnable();
    /*0x1acba38*/ void OnDisable();
    /*0x1acb5c0*/ void Refresh_UI();
    /*0x1acbaf0*/ void Click_ShortCut();
    /*0x1acbc60*/ void Click_Refund();
    /*0x1acbe4c*/ void Click_Portal();
    /*0x1acbeb8*/ void <Click_Refund>b__13_0();
}

class ui_bottom_page_dimension : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject cell_prefab;
    /*0x20*/ UnityEngine.Transform cell_parent;
    /*0x28*/ SimplePool<data_enhance_element> pool;

    /*0x1acc25c*/ ui_bottom_page_dimension();
    /*0x1acbf94*/ void Awake();
    /*0x1acc020*/ void OnEnable();
    /*0x1acc1a4*/ void OnDisable();
    /*0x1acc124*/ void Refresh_UI();
}

class ui_bottom_page_dimension_cell : SimplePool_element<data_enhance_element>
{
    /*0x28*/ UnityEngine.UI.Image img_icon;
    /*0x30*/ GarlicText.UI.HyperText text_title;
    /*0x38*/ GarlicText.UI.HyperText text_info;
    /*0x40*/ GarlicText.UI.HyperText text_lv;
    /*0x48*/ ui_button button_upgrade;
    /*0x50*/ GarlicText.UI.HyperText text_upgrade;

    /*0x1acc80c*/ ui_bottom_page_dimension_cell();
    /*0x1acc264*/ void Instantiate();
    /*0x1acc268*/ void Refresh_UI();
    /*0x1acc754*/ void OnClick_Upgrade();
}

class ui_bottom_page_gem : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject cell_prefab;
    /*0x20*/ UnityEngine.Transform cell_parent;
    /*0x28*/ SimplePool<data_relic_element> pool;
    /*0x30*/ data_place_element place_special_003;

    /*0x1accb1c*/ ui_bottom_page_gem();
    /*0x1acc854*/ void Awake();
    /*0x1acc8e0*/ void OnEnable();
    /*0x1acca64*/ void OnDisable();
    /*0x1acc9e4*/ void Refresh_UI();
}

class ui_bottom_page_gem_cell : SimplePool_element<data_relic_element>
{
    /*0x28*/ UnityEngine.GameObject panel_active;
    /*0x30*/ UnityEngine.GameObject panel_disabled;
    /*0x38*/ UnityEngine.UI.Image img_icon;
    /*0x40*/ UnityEngine.UI.Image img_bar;
    /*0x48*/ GarlicText.UI.HyperText text_title;
    /*0x50*/ GarlicText.UI.HyperText text_info;
    /*0x58*/ GarlicText.UI.HyperText text_lv;
    /*0x60*/ GarlicText.UI.HyperText text_num;
    /*0x68*/ GarlicText.UI.HyperText text_needRank;

    /*0x1acd144*/ ui_bottom_page_gem_cell();
    /*0x1accb24*/ void Instantiate();
    /*0x1accb28*/ void Refresh_UI();
}

class ui_bottom_page_gold : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_dps;
    /*0x20*/ GarlicText.UI.HyperText text_tps;

    /*0x1acd604*/ ui_bottom_page_gold();
    /*0x1acd18c*/ void OnEnable();
    /*0x1acd54c*/ void OnDisable();
    /*0x1acd290*/ void Refresh_UI();
}

class ui_bottom_page_gold_pet : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject panel_active;
    /*0x20*/ UnityEngine.GameObject panel_disabled;
    /*0x28*/ GarlicText.UI.HyperText text_pet_lv;
    /*0x30*/ GarlicText.UI.HyperText text_pet_info;
    /*0x38*/ UnityEngine.UI.Image img_exp;

    /*0x1acdb9c*/ ui_bottom_page_gold_pet();
    /*0x1acd60c*/ void OnEnable();
    /*0x1acdae4*/ void OnDisable();
    /*0x1acd710*/ void Refresh_UI();
}

class ui_bottom_page_gold_rod : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_lv;
    /*0x20*/ GarlicText.UI.HyperText text_price;
    /*0x28*/ GarlicText.UI.HyperText text_dps;
    /*0x30*/ GarlicText.UI.HyperText text_info;

    /*0x1ace30c*/ ui_bottom_page_gold_rod();
    /*0x1acdba4*/ void OnEnable();
    /*0x1ace1f8*/ void OnDisable();
    /*0x1acdca8*/ void Refresh_UI();
    /*0x1ace2b0*/ void Click_Upgrade();
}

class ui_bottom_page_gold_turret : UnityEngine.MonoBehaviour
{
    /*0x18*/ int no;
    /*0x20*/ UnityEngine.GameObject panel_active;
    /*0x28*/ UnityEngine.GameObject panel_disabled;
    /*0x30*/ UnityEngine.UI.Image img_icon;
    /*0x38*/ GarlicText.UI.HyperText text_lv;
    /*0x40*/ GarlicText.UI.HyperText text_title;
    /*0x48*/ GarlicText.UI.HyperText text_gold_need;
    /*0x50*/ GarlicText.UI.HyperText text_dps;
    /*0x58*/ GarlicText.UI.HyperText text_info;
    /*0x60*/ GarlicText.UI.HyperText text_needRank;

    /*0x1acee58*/ ui_bottom_page_gold_turret();
    /*0x1ace314*/ void OnEnable();
    /*0x1aced20*/ void OnDisable();
    /*0x1ace418*/ void Refresh();
    /*0x1acedd8*/ void Click_Upgrade();
}

class ui_bottom_page_inven : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject ui_bottom_sub;
    /*0x20*/ UnityEngine.Transform pos_sellAll;
    /*0x28*/ UnityEngine.UI.Toggle toggle_autolock;
    /*0x30*/ ui_bottom_page_inven_cell[] _cells;

    /*0x1a04794*/ ui_bottom_page_inven();
    /*0x1a03c80*/ ui_bottom_page_inven_cell[] get_cells();
    /*0x1a03cd8*/ void OnEnable();
    /*0x1a04048*/ void OnDisable();
    /*0x1a03ddc*/ void Refresh();
    /*0x1a0444c*/ void button_SellAll();
    /*0x1a044f8*/ void button_tutorial();
    /*0x1a046b4*/ void On_Toogle_autolock();
}

class ui_bottom_page_inven_cell : UnityEngine.EventSystems.UIBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerExitHandler
{
    /*0x18*/ float durationThreshold;
    /*0x1c*/ bool isPressing;
    /*0x1d*/ bool longPressTriggered;
    /*0x20*/ float timePressStarted;
    /*0x28*/ UnityEngine.UI.Image img_icon;
    /*0x30*/ UnityEngine.UI.Image img_locked;
    /*0x38*/ UnityEngine.UI.Image img_arrow;
    /*0x40*/ GarlicText.UI.HyperText text_num;
    /*0x48*/ player_inven_element item;

    /*0x1a04a00*/ ui_bottom_page_inven_cell();
    /*0x1a0479c*/ bool get_interactable();
    /*0x1a047ac*/ void Update();
    /*0x1a048f8*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x1a04924*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x1a049f8*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x1a04100*/ void Refresh(player_inven_element item);
    /*0x1a047fc*/ void OnLongPress();
}

class ui_bottom_page_mastery : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject cell_prefab;
    /*0x20*/ UnityEngine.Transform cell_parent;
    /*0x28*/ SimplePool<data_mastery_element> pool;
    /*0x30*/ UnityEngine.UI.Toggle toggle_showAll;

    /*0x1a05220*/ ui_bottom_page_mastery();
    /*0x1a04a10*/ bool get_showAll();
    /*0x1a04a2c*/ void Awake();
    /*0x1a04ab8*/ void OnEnable();
    /*0x1a05094*/ void OnDisable();
    /*0x1a04bbc*/ void Refresh_UI();
    /*0x1a0514c*/ void OnClick_Toggle();
    /*0x1a051b0*/ void OnClick_Tutorial();

    class <>c
    {
        static /*0x0*/ ui_bottom_page_mastery.<> <>9;
        static /*0x8*/ System.Func<data_mastery_element, int> <>9__9_0;
        static /*0x10*/ System.Predicate<data_mastery_element> <>9__9_1;

        static /*0x1a05228*/ <>c();
        /*0x1a0528c*/ <>c();
        /*0x1a05294*/ int <Refresh_UI>b__9_0(data_mastery_element m);
        /*0x1a052ac*/ bool <Refresh_UI>b__9_1(data_mastery_element m);
    }
}

class ui_bottom_page_mastery_cell : SimplePool_element<data_mastery_element>
{
    /*0x28*/ UnityEngine.UI.Image img_icon;
    /*0x30*/ UnityEngine.UI.Image img_lvLock;
    /*0x38*/ GarlicText.UI.HyperText text_title;
    /*0x40*/ GarlicText.UI.HyperText text_lv;
    /*0x48*/ GarlicText.UI.HyperText text_price;
    /*0x50*/ GarlicText.UI.HyperText text_needRank;
    /*0x58*/ ui_button button_upgrade;
    /*0x60*/ UnityEngine.GameObject panel_active;
    /*0x68*/ UnityEngine.GameObject panel_disabled;
    /*0x70*/ data_tutorial_element tutorial;

    /*0x1a0595c*/ ui_bottom_page_mastery_cell();
    /*0x1a05398*/ void Instantiate();
    /*0x1a0539c*/ void Refresh_UI();
    /*0x1a057ec*/ bool get_interactable();
    /*0x1a058ac*/ void OnClick();
}

class ui_bottom_page_skill : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_mana;
    /*0x20*/ GarlicText.UI.HyperText text_potion;
    /*0x28*/ UnityEngine.UI.Image bar_mana;

    /*0x1a06194*/ ui_bottom_page_skill();
    /*0x1a059a4*/ void OnEnable();
    /*0x1a05b54*/ void OnDisable();
    /*0x1a05aa8*/ void Refresh();
    /*0x1a05c0c*/ void Update();
    /*0x1a05e7c*/ void Click_PotionUse();

    class <>c
    {
        static /*0x0*/ ui_bottom_page_skill.<> <>9;
        static /*0x8*/ System.Action <>9__7_0;

        static /*0x1a0619c*/ <>c();
        /*0x1a06200*/ <>c();
        /*0x1a06208*/ void <Click_PotionUse>b__7_0();
    }
}

class ui_bottom_page_skill_buff : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_name;
    /*0x20*/ GarlicText.UI.HyperText text_info;
    /*0x28*/ GarlicText.UI.HyperText text_time_left;
    /*0x30*/ UnityEngine.GameObject panel_active;
    /*0x38*/ UnityEngine.GameObject panel_disabled;

    /*0x1a06a54*/ ui_bottom_page_skill_buff();
    /*0x1a06264*/ void OnEnable();
    /*0x1a06614*/ void OnDisable();
    /*0x1a06368*/ void Refresh_UI();
    /*0x1a066cc*/ void Click_mastery();
    /*0x1a069a0*/ void Click_diamond();
    /*0x1a06778*/ void Add_buff_currency(CurNumPair price, double time_buff);

    class <>c__DisplayClass10_0
    {
        /*0x10*/ CurNumPair price;
        /*0x18*/ double time_buff;

        /*0x1a06a4c*/ <>c__DisplayClass10_0();
        /*0x1a06a5c*/ void <Add_buff_currency>b__0();
    }
}

class ui_bottom_page_skill_element : UnityEngine.MonoBehaviour
{
    /*0x18*/ data_skill_element mySkill;
    /*0x20*/ UnityEngine.UI.Image img_icon;
    /*0x28*/ GarlicText.UI.HyperText text_name;
    /*0x30*/ GarlicText.UI.HyperText text_info;
    /*0x38*/ GarlicText.UI.HyperText text_mana;
    /*0x40*/ GarlicText.UI.HyperText text_time_left;
    /*0x48*/ UnityEngine.GameObject panel_active;
    /*0x50*/ UnityEngine.GameObject panel_disabled;
    /*0x58*/ ui_button button_boost;
    /*0x60*/ ui_button button_auto;
    /*0x68*/ UnityEngine.UI.Image img_boost_enabled;
    /*0x70*/ UnityEngine.UI.Image img_boost_cooltime;
    /*0x78*/ UnityEngine.UI.Image img_auto_enabled;
    /*0x80*/ GarlicText.UI.HyperText text_needRank;

    /*0x1a07a14*/ ui_bottom_page_skill_element();
    /*0x1a06ba0*/ void OnEnable();
    /*0x1a07230*/ void OnDisable();
    /*0x1a06ca4*/ void Refresh_UI();
    /*0x1a072e8*/ void LateUpdate();
    /*0x1a07528*/ void Click_mana();
    /*0x1a077e0*/ void Click_mana_fast();
    /*0x1a07844*/ void Click_auto();
    /*0x1a07974*/ void Click_boost();
    /*0x1a07a1c*/ void <Click_mana>b__18_0();
}

class ui_bottom_sub : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<UnityEngine.GameObject> panels;

    /*0x1a07c14*/ ui_bottom_sub();
    /*0x1a07a80*/ void LateUpdate();
}

class ui_bottom_sub_craft : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject panel_craft;
    /*0x20*/ UnityEngine.GameObject panel_farm;
    /*0x28*/ data_craft_element element;

    /*0x1a07fac*/ ui_bottom_sub_craft();
    /*0x1a07c1c*/ void OnEnable();
    /*0x1a07ef4*/ void OnDisable();
    /*0x1a07d20*/ void Refresh_UI();
}

class ui_bottom_sub_craft_craft : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Image img_icon;
    /*0x20*/ GarlicText.UI.HyperText text_name;
    /*0x28*/ GarlicText.UI.HyperText text_info;
    /*0x30*/ UnityEngine.GameObject panel_top;
    /*0x38*/ UnityEngine.UI.Image img_lv_locked;
    /*0x40*/ GarlicText.UI.HyperText text_lv;
    /*0x48*/ UnityEngine.UI.Image img_rate;
    /*0x50*/ GarlicText.UI.HyperText text_rate;
    /*0x58*/ UnityEngine.UI.Button button_done;
    /*0x60*/ UnityEngine.GameObject panel_farm;
    /*0x68*/ UnityEngine.UI.Button button_farm_select;
    /*0x70*/ UnityEngine.UI.Button button_farm_close;
    /*0x78*/ UnityEngine.GameObject pool_prefab;
    /*0x80*/ UnityEngine.Transform pool_parent;
    /*0x88*/ SimplePool<ItemNeedOwnPair> pool;
    /*0x90*/ GarlicText.UI.HyperText text_stat;
    /*0x98*/ data_craft_element element;
    /*0xa0*/ player_craft_element element_player;
    /*0xa8*/ data_tutorial_element tutorial;

    /*0x1a08ce4*/ ui_bottom_sub_craft_craft();
    /*0x1a07fb4*/ void Awake();
    /*0x1a08040*/ void OnEnable();
    /*0x1a08908*/ void OnDisable();
    /*0x1a08144*/ void Refresh_UI();
    /*0x1a089c0*/ void Click_Done();
    /*0x1a08a7c*/ void Click_Farm_Close();
    /*0x1a08b54*/ void Click_Farm_Select();
    /*0x1a08c70*/ void Click_Tutorial();
}

class ui_bottom_sub_craft_craft_element : SimplePool_element<ItemNeedOwnPair>
{
    /*0x48*/ UnityEngine.UI.Image img_icon;
    /*0x50*/ UnityEngine.UI.Image img_full;
    /*0x58*/ UnityEngine.UI.Image img_arrow;
    /*0x60*/ GarlicText.UI.HyperText text_needOwn;
    /*0x68*/ UnityEngine.CanvasGroup canvas;
    /*0x70*/ UnityEngine.UI.Button button;
    /*0x78*/ string num;
    /*0x80*/ bool hasItemAndNeed;

    /*0x1a09038*/ ui_bottom_sub_craft_craft_element();
    /*0x1a08cec*/ void Instantiate();
    /*0x1a08f88*/ void Click();
}

class ui_bottom_sub_craft_farm : UnityEngine.MonoBehaviour
{
    /*0x18*/ data_farm.Type type;
    /*0x20*/ System.Collections.Generic.List<UnityEngine.UI.Button> buttons;
    /*0x28*/ UnityEngine.Transform buttons_parent;
    /*0x30*/ UnityEngine.GameObject pool_prefab;
    /*0x38*/ UnityEngine.Transform pool_parent;
    /*0x40*/ SimplePool<data_farm_element> pool;
    /*0x48*/ GarlicText.UI.HyperText text_stat;
    /*0x50*/ data_tutorial_element tutorial;

    /*0x1a09804*/ ui_bottom_sub_craft_farm();
    /*0x1a09080*/ void Awake();
    /*0x1a0914c*/ void OnEnable();
    /*0x1a0960c*/ void OnDisable();
    /*0x1a09250*/ void Refresh_UI();
    /*0x1a096c4*/ void Click_Type(int no);
    /*0x1a09790*/ void Click_Tutorial();
    /*0x1a0980c*/ bool <Refresh_UI>b__11_0(data_farm_element element);

    class <>c
    {
        static /*0x0*/ ui_bottom_sub_craft_farm.<> <>9;
        static /*0x8*/ System.Func<data_farm_element, string> <>9__11_1;

        static /*0x1a09830*/ <>c();
        /*0x1a09894*/ <>c();
        /*0x1a0989c*/ string <Refresh_UI>b__11_1(data_farm_element element);
    }
}

class ui_bottom_sub_craft_farm_element : SimplePool_element<data_farm_element>
{
    /*0x28*/ UnityEngine.GameObject panel_lv;
    /*0x30*/ UnityEngine.GameObject panel_lv_locked;
    /*0x38*/ UnityEngine.UI.Image img_icon;
    /*0x40*/ UnityEngine.UI.Image img_rate;
    /*0x48*/ UnityEngine.UI.Image img_selected;
    /*0x50*/ UnityEngine.UI.Image img_arrow;
    /*0x58*/ GarlicText.UI.HyperText text_lv;
    /*0x60*/ player_craft_element craft;

    /*0x1a09ef0*/ ui_bottom_sub_craft_farm_element();
    /*0x1a098b4*/ void Instantiate();
    /*0x1a09e08*/ void Click();

    class <>c
    {
        static /*0x0*/ ui_bottom_sub_craft_farm_element.<> <>9;
        static /*0x8*/ System.Func<ItemNeedOwnPair, bool> <>9__8_0;
        static /*0x10*/ System.Func<ItemNeedOwnPair, data_item_element> <>9__8_1;

        static /*0x1a09f38*/ <>c();
        /*0x1a09f9c*/ <>c();
        /*0x1a09fa4*/ bool <Instantiate>b__8_0(ItemNeedOwnPair pair);
        /*0x1a0a024*/ data_item_element <Instantiate>b__8_1(ItemNeedOwnPair pair);
    }
}

class ui_bottom_sub_harbor : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject panel;
    /*0x20*/ UnityEngine.GameObject cell_prefab;
    /*0x28*/ UnityEngine.Transform cell_parent;
    /*0x30*/ System.Collections.Generic.List<ui_bottom_sub_harbor_cell> cells;
    /*0x38*/ GarlicText.UI.HyperText text_gem;
    /*0x40*/ UnityEngine.GameObject panel_scrollRect;
    /*0x48*/ UnityEngine.GameObject panel_soldout;

    /*0x1a0a924*/ ui_bottom_sub_harbor();
    /*0x1a0a02c*/ void OnEnable();
    /*0x1a0a7ec*/ void OnDisable();
    /*0x1a0a130*/ void Refresh_UI();

    class <>c
    {
        static /*0x0*/ ui_bottom_sub_harbor.<> <>9;
        static /*0x8*/ System.Func<data_skin_element, bool> <>9__9_0;
        static /*0x10*/ System.Func<data_skin_element, int> <>9__9_1;

        static /*0x1a0a9a0*/ <>c();
        /*0x1a0aa04*/ <>c();
        /*0x1a0aa0c*/ bool <Refresh_UI>b__9_0(data_skin_element item);
        /*0x1a0aac0*/ int <Refresh_UI>b__9_1(data_skin_element item);
    }
}

class ui_bottom_sub_harbor_cell : UnityEngine.MonoBehaviour
{
    /*0x18*/ data_skin_element element;
    /*0x20*/ UnityEngine.UI.Image img_icon;
    /*0x28*/ GarlicText.UI.HyperText text_price;

    /*0x1a0ac88*/ ui_bottom_sub_harbor_cell();
    /*0x1a0a8a4*/ void Refresh(data_skin_element skin_element);
    /*0x1a0ab60*/ void OnClick();
}

class ui_bottom_sub_relic : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject panel;
    /*0x20*/ data_place_element place_special_003;
    /*0x28*/ GarlicText.UI.HyperText text_price;
    /*0x30*/ UnityEngine.UI.Button button_random;

    /*0x1a0b288*/ ui_bottom_sub_relic();
    /*0x1a0ac90*/ void OnEnable();
    /*0x1a0ae78*/ void OnDisable();
    /*0x1a0ad94*/ void Refresh_UI();
    /*0x1a0af30*/ void OnClick_random_withWarn();
    /*0x1a0b1c8*/ void OnClick_random();
    /*0x1a0b290*/ void <OnClick_random_withWarn>b__7_0();
}

class ui_bottom_sub_relic_cell : UnityEngine.MonoBehaviour
{
    /*0x18*/ data_relic_element element;
    /*0x20*/ UnityEngine.UI.Button button;
    /*0x28*/ UnityEngine.UI.Image img_icon;
    /*0x30*/ UnityEngine.UI.Image img_item;
    /*0x38*/ UnityEngine.GameObject obj_hasItems;
    /*0x40*/ GarlicText.UI.HyperText text_price;

    /*0x1a0b714*/ ui_bottom_sub_relic_cell();
    /*0x1a0b294*/ void OnEnable();
    /*0x1a0b58c*/ void OnDisable();
    /*0x1a0b398*/ void Refresh_UI();
    /*0x1a0b644*/ void OnClick();
}

class ui_character : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Image bar_exp;
    /*0x20*/ GarlicText.UI.HyperText text_lv;
    /*0x28*/ GarlicText.UI.HyperText text_exp;
    /*0x30*/ GarlicText.UI.HyperText text_time;
    /*0x38*/ UnityEngine.GameObject icon_up;
    /*0x40*/ float exp_target;

    /*0x1a0bdb8*/ ui_character();
    /*0x1a0b71c*/ void OnEnable();
    /*0x1a0babc*/ void OnDisable();
    /*0x1a0b820*/ void Refresh();
    /*0x1a0bb74*/ void Update();
}

class ui_center : UnityEngine.MonoBehaviour
{
    /*0x18*/ ui_center_charge charge;
    /*0x20*/ ui_center_pin pin;
    /*0x28*/ ui_center_sonar sonar;

    /*0x1a0bdc0*/ ui_center();
}

class ui_center_charge : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Image img_charge;
    /*0x20*/ UnityEngine.UI.Image img_icon;
    /*0x28*/ GarlicText.UI.HyperText text_lvMax;
    /*0x30*/ GarlicText.UI.HyperText text_lvMin;
    /*0x38*/ UnityEngine.GameObject icon_isNew;
    /*0x40*/ UnityEngine.Color color_min;
    /*0x50*/ UnityEngine.Color color_mid;
    /*0x60*/ UnityEngine.Color color_mid_max;
    /*0x70*/ UnityEngine.Color color_max;
    /*0x80*/ int min;
    /*0x84*/ int mid;
    /*0x88*/ int max;
    /*0x8c*/ int rank;
    /*0x90*/ int all;
    /*0x94*/ int mid_min;
    /*0x98*/ int mid_max;
    /*0x9c*/ float min_mid_rate;
    /*0xa0*/ float mid_rate;
    /*0xa4*/ float mid_max_rate;
    /*0xa8*/ UnityEngine.Texture2D texture;
    /*0xb0*/ int texture_resolution;
    /*0xb8*/ UnityEngine.RectTransform trans_base;
    /*0xc0*/ UnityEngine.RectTransform trans_fishLv;
    /*0xc8*/ bool initialized;
    /*0xcc*/ game.state state_now;
    /*0xd0*/ float fishLv_target;

    /*0x1a0cc10*/ ui_center_charge();
    /*0x1a0bdc8*/ UnityEngine.Color Get_Color(float rate);
    /*0x1a0bf48*/ int get_mid_up();
    /*0x1a0c188*/ int get_mid_down();
    /*0x1a0c1e4*/ float Get_Rate(int lv);
    /*0x1a0c200*/ void Awake();
    /*0x1a0c3b4*/ void Update();
    /*0x1a0c550*/ void Refresh_Init();
    /*0x1a0c558*/ void Refresh_UI();
    /*0x1a0c85c*/ void Refresh_UI_Pingpong();
    /*0x1a0cb80*/ System.Collections.IEnumerator IE_fishLv_PingPong();
    /*0x1a0c464*/ void Update_fishLv();

    class <IE_fishLv_PingPong>d__36 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ui_center_charge <>4__this;
        /*0x28*/ float <tmp>5__2;

        /*0x1a0cbe8*/ <IE_fishLv_PingPong>d__36(int <>1__state);
        /*0x1a0cc18*/ void System.IDisposable.Dispose();
        /*0x1a0cc1c*/ bool MoveNext();
        /*0x1a0cd9c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1a0cda4*/ void System.Collections.IEnumerator.Reset();
        /*0x1a0cde4*/ object System.Collections.IEnumerator.get_Current();
    }
}

class ui_center_gameState : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Animator myAnim;
    /*0x20*/ ui_center_gameState.anim_state state_now;

    /*0x1a0d0b8*/ ui_center_gameState();
    /*0x1a0cdec*/ void Awake();
    /*0x1a0cea4*/ void Refresh_UI();
    /*0x1a0cf8c*/ void Set_State(ui_center_gameState.anim_state state_target);

    enum anim_state
    {
        sleep = 0,
        harbor = 1,
        idle = 2,
        wait = 3,
        found = 4,
        fight = 5,
        done = 6,
    }
}

class ui_center_pin : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Slider slider_pin;
    /*0x20*/ GarlicText.UI.HyperText text_lv;
    /*0x28*/ int _lv;
    /*0x30*/ UnityEngine.UI.InputField input_lv;
    /*0x38*/ float time_touched;
    /*0x3c*/ bool dragging;

    /*0x1a0d824*/ ui_center_pin();
    /*0x1a0d0c8*/ bool get_isInteractable();
    /*0x1a0d130*/ int get_lv();
    /*0x1a0d180*/ void set_lv(int value);
    /*0x1a0d188*/ void Awake();
    /*0x1a0d29c*/ void Refresh_Init();
    /*0x1a0d384*/ void Refresh_UI();
    /*0x1a0d5ec*/ void Update();
    /*0x1a0d620*/ void LateUpdate();
    /*0x1a0d69c*/ void Click_Test();
    /*0x1a0d794*/ void Input_finished();
    /*0x1a0d7c0*/ void Pointer_Down();
    /*0x1a0d7cc*/ void Pointer_Up();
    /*0x1a0d7d4*/ void Slider_Changed();
}

class ui_center_placeState : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Image img_placeState;

    /*0x1a0df18*/ ui_center_placeState();
    /*0x1a0d82c*/ void Awake();
    /*0x1a0d8e4*/ void Refresh_UI();
    /*0x1a0dc6c*/ void Refresh_Sec();
}

class ui_center_rampage : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject panel;
    /*0x20*/ UnityEngine.GameObject particle;
    /*0x28*/ UnityEngine.UI.Image img_rampage;
    /*0x30*/ GarlicText.UI.HyperText text_rampage;

    /*0x1a0e124*/ ui_center_rampage();
    /*0x1a0df20*/ void Update();
}

class ui_center_skill : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject icon_skill;
    /*0x20*/ UnityEngine.UI.Image bar_skill;
    /*0x28*/ UnityEngine.UI.Image img_boost;
    /*0x30*/ data_skill_element skill;

    /*0x1a0e290*/ ui_center_skill();
    /*0x1a0e12c*/ void Update();
}

class ui_center_skill_buff : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject panel;

    /*0x1a0e408*/ ui_center_skill_buff();
    /*0x1a0e298*/ void Awake();
    /*0x1a0e350*/ void Refresh_UI();
}

class ui_center_sonar : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Animator animator;
    /*0x20*/ UnityEngine.RectTransform rectTransform;
    /*0x28*/ UnityEngine.GameObject prefab_cell;
    /*0x30*/ UnityEngine.UI.Image img_reach;
    /*0x38*/ SimplePool<data_hidden_element> pool;

    /*0x1a0e734*/ ui_center_sonar();
    /*0x1a0e410*/ void Awake();
    /*0x1a0e5f8*/ void Play();
    /*0x1a0e6ac*/ void Refresh_UI();
}

class ui_center_sonar_cell : SimplePool_element<data_hidden_element>
{
    /*0x28*/ UnityEngine.RectTransform rectTransform;
    /*0x30*/ UnityEngine.UI.Image img_icon;

    /*0x1a0e8c8*/ ui_center_sonar_cell();
    /*0x1a0e73c*/ void Instantiate();
    /*0x1a0e75c*/ System.Collections.IEnumerator IE_Sonar();
    /*0x1a0e7ec*/ void LateUpdate();

    class <IE_Sonar>d__3 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ui_center_sonar_cell <>4__this;

        /*0x1a0e7c4*/ <IE_Sonar>d__3(int <>1__state);
        /*0x1a0e910*/ void System.IDisposable.Dispose();
        /*0x1a0e914*/ bool MoveNext();
        /*0x1a0ec10*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1a0ec18*/ void System.Collections.IEnumerator.Reset();
        /*0x1a0ec58*/ object System.Collections.IEnumerator.get_Current();
    }
}

class Check_www : UnityEngine.MonoBehaviour
{
    /*0x1a0ef40*/ Check_www();
    /*0x1a0ec60*/ void OnEnable();
    /*0x1a0ed98*/ void OnDisable();
    /*0x1a0ee50*/ void Refresh_UI_www();
}

class ui_fish : UnityEngine.MonoBehaviour
{
    /*0x18*/ ui_fish_default Panel_Default;
    /*0x20*/ ui_fish_legend Panel_Legend;
    /*0x28*/ ui_fish_infinite Panel_Infinite;
    /*0x30*/ game.state state_now;

    /*0x1a0f630*/ ui_fish();
    /*0x1a0ef48*/ void Awake();
    /*0x1a0f060*/ void Refresh_UI();
}

class ui_fishDmg : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject prefab;
    /*0x20*/ UnityEngine.RectTransform canvasRect;
    /*0x28*/ System.Collections.Generic.List<ui_fishDmg_cell> cell_pool;
    /*0x30*/ System.Collections.Generic.List<ui_fishDmg_cell> cell_using;
    /*0x38*/ int max;
    /*0x3c*/ float power_ver;
    /*0x40*/ float power_ver_max;
    /*0x44*/ float power_ver_min;
    /*0x48*/ float power_hor;
    /*0x4c*/ float time;

    /*0x1a0fdcc*/ ui_fishDmg();
    /*0x1a0f638*/ void Play(double dmg, bool isCrit);
    /*0x1a0fc34*/ void Set_using_to_pool(ui_fishDmg_cell cell);
}

class ui_fishDmg_cell : UnityEngine.MonoBehaviour
{
    /*0x18*/ ui_fishDmg _myParent;
    /*0x20*/ GarlicText.UI.HyperText text_dmg;
    /*0x28*/ UnityEngine.Animator myAnim;
    /*0x30*/ System.Collections.IEnumerator cor;

    /*0x1a0ff90*/ ui_fishDmg_cell();
    /*0x1a0fe6c*/ ui_fishDmg get_myParent();
    /*0x1a0fb10*/ void Play(double dmg, UnityEngine.Vector3 pos_start, bool isCrit);
    /*0x1a0ff00*/ System.Collections.IEnumerator IE_Play();

    class <IE_Play>d__7 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ui_fishDmg_cell <>4__this;
        /*0x28*/ float <power_ver>5__2;
        /*0x2c*/ float <power_hor>5__3;
        /*0x30*/ float <time>5__4;

        /*0x1a0ff68*/ <IE_Play>d__7(int <>1__state);
        /*0x1a0ff98*/ void System.IDisposable.Dispose();
        /*0x1a0ff9c*/ bool MoveNext();
        /*0x1a101b4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1a101bc*/ void System.Collections.IEnumerator.Reset();
        /*0x1a101fc*/ object System.Collections.IEnumerator.get_Current();
    }
}

class ui_fish_default : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_fish_name;
    /*0x20*/ GarlicText.UI.HyperText text_fish_life;
    /*0x28*/ GarlicText.UI.HyperText text_time;
    /*0x30*/ GarlicText.UI.HyperText text_tps;
    /*0x38*/ GarlicText.UI.HyperText text_dps;
    /*0x40*/ UnityEngine.UI.Image icon_charge;
    /*0x48*/ UnityEngine.UI.Image img_fish_type;
    /*0x50*/ UnityEngine.UI.Image bar_fish_life;
    /*0x58*/ UnityEngine.UI.Image bar_tps;
    /*0x60*/ UnityEngine.Sprite sprite_normal;
    /*0x68*/ UnityEngine.Sprite sprite_rare;
    /*0x70*/ UnityEngine.Sprite sprite_boss;
    /*0x78*/ UnityEngine.RectTransform icon_time;
    /*0x80*/ float life_width;

    /*0x1a107c8*/ ui_fish_default();
    /*0x1a10204*/ void Awake();
    /*0x1a0f314*/ void Refresh();
    /*0x1a10258*/ void Update();
}

class ui_fish_infinite : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_fish_name;
    /*0x20*/ GarlicText.UI.HyperText text_fish_life;
    /*0x28*/ GarlicText.UI.HyperText text_time;
    /*0x30*/ GarlicText.UI.HyperText text_tps;
    /*0x38*/ GarlicText.UI.HyperText text_dps;
    /*0x40*/ UnityEngine.UI.Image bar_fish_life;
    /*0x48*/ UnityEngine.UI.Image bar_tps;
    /*0x50*/ UnityEngine.RectTransform icon_time;
    /*0x58*/ float life_width;
    /*0x5c*/ UnityEngine.Color color_min;
    /*0x6c*/ UnityEngine.Color color_max;

    /*0x1a10d78*/ ui_fish_infinite();
    /*0x1a107d0*/ void Awake();
    /*0x1a0f2dc*/ void Refresh();
    /*0x1a10824*/ void Update();
}

class ui_fish_legend : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_fish_name;
    /*0x20*/ GarlicText.UI.HyperText text_fish_life;
    /*0x28*/ GarlicText.UI.HyperText text_time;
    /*0x30*/ GarlicText.UI.HyperText text_tps;
    /*0x38*/ GarlicText.UI.HyperText text_dps;
    /*0x40*/ GarlicText.UI.HyperText text_amber;
    /*0x48*/ UnityEngine.UI.Image bar_fish_life;
    /*0x50*/ UnityEngine.UI.Image bar_tps;
    /*0x58*/ UnityEngine.RectTransform icon_time;
    /*0x60*/ float life_width;
    /*0x64*/ UnityEngine.Color color_min;
    /*0x74*/ UnityEngine.Color color_max;

    /*0x1a1136c*/ ui_fish_legend();
    /*0x1a10d80*/ void Awake();
    /*0x1a0f2a4*/ void Refresh();
    /*0x1a10dd4*/ void Update();
}

class ui_popup : UnityEngine.MonoBehaviour
{
    /*0x18*/ ui_popup_fish fish;
    /*0x20*/ ui_popup_skin skin;
    /*0x28*/ ui_popup_lv lv;
    /*0x30*/ ui_popup_rank rank;
    /*0x38*/ ui_popup_tutorial tutorial;
    /*0x40*/ ui_popup_quest quest;
    /*0x48*/ ui_popup_journal journal;
    /*0x50*/ ui_popup_preview preview;
    /*0x58*/ ui_popup_legend legend;
    /*0x60*/ ui_popup_parallel parallel;
    /*0x68*/ ui_popup_infinite infinite;
    /*0x70*/ System.Collections.Generic.List<System.Action> list;
    /*0x78*/ bool <isPlaying>k__BackingField;
    /*0x79*/ bool next;
    /*0x80*/ System.Collections.IEnumerator coroutine;

    /*0x1a11ee4*/ ui_popup();
    /*0x1a11374*/ bool get_isPlaying();
    /*0x1a1137c*/ void set_isPlaying(bool value);
    /*0x1a11388*/ void Add(System.Action action_open);
    /*0x1a1147c*/ void Add_lv(int lv);
    /*0x1a11544*/ void Add_Rank(int target_rank);
    /*0x1a0abc4*/ void Add_Skin(data_skin_element skin, ui_popup_skin.State state);
    /*0x1a11614*/ void Add_Previes(data_skin_element skin);
    /*0x1a116d8*/ void Add_Fish(data_fish_element fish, ui_popup.State isNew, int lv);
    /*0x1a117b0*/ void Add_legend(double amber_num, UnityEngine.Vector3 effect_pos);
    /*0x1a11894*/ void Add_parallel(int difficulty);
    /*0x1a1195c*/ void Add_Quest(data_quest_element quest, ui_popup.State state);
    /*0x1a04568*/ void Add_tutorial(string code);
    /*0x1a11a54*/ void Add_Rankup_Tutorial(int rank_reached);
    /*0x1a11b8c*/ void Add_infinite(int lv_origin, int lv_target);
    /*0x1a11c58*/ System.Collections.IEnumerator IE_Play();
    /*0x1a11440*/ void Play();
    /*0x1a11ce8*/ void Next();
    /*0x1a11d74*/ void CloseAll();

    enum State
    {
        none = 0,
        isNew = 1,
        isUp = 2,
    }

    class <>c__DisplayClass18_0
    {
        /*0x10*/ ui_popup <>4__this;
        /*0x18*/ int lv;

        /*0x1a1153c*/ <>c__DisplayClass18_0();
        /*0x1a11f60*/ void <Add_lv>b__0();
    }

    class <>c__DisplayClass19_0
    {
        /*0x10*/ ui_popup <>4__this;
        /*0x18*/ int target_rank;

        /*0x1a11604*/ <>c__DisplayClass19_0();
        /*0x1a120f8*/ void <Add_Rank>b__0();
    }

    class <>c__DisplayClass20_0
    {
        /*0x10*/ ui_popup <>4__this;
        /*0x18*/ data_skin_element skin;
        /*0x20*/ ui_popup_skin.State state;

        /*0x1a1160c*/ <>c__DisplayClass20_0();
        /*0x1a12558*/ void <Add_Skin>b__0();
    }

    class <>c__DisplayClass21_0
    {
        /*0x10*/ ui_popup <>4__this;
        /*0x18*/ data_skin_element skin;

        /*0x1a116d0*/ <>c__DisplayClass21_0();
        /*0x1a12b80*/ void <Add_Previes>b__0();
    }

    class <>c__DisplayClass22_0
    {
        /*0x10*/ ui_popup <>4__this;
        /*0x18*/ data_fish_element fish;
        /*0x20*/ ui_popup.State isNew;
        /*0x24*/ int lv;

        /*0x1a117a8*/ <>c__DisplayClass22_0();
        /*0x1a12c90*/ void <Add_Fish>b__0();
    }

    class <>c__DisplayClass23_0
    {
        /*0x10*/ ui_popup <>4__this;
        /*0x18*/ double amber_num;
        /*0x20*/ UnityEngine.Vector3 effect_pos;

        /*0x1a1188c*/ <>c__DisplayClass23_0();
        /*0x1a12fb4*/ void <Add_legend>b__0();
    }

    class <>c__DisplayClass24_0
    {
        /*0x10*/ ui_popup <>4__this;
        /*0x18*/ int difficulty;

        /*0x1a11954*/ <>c__DisplayClass24_0();
        /*0x1a1317c*/ void <Add_parallel>b__0();
    }

    class <>c__DisplayClass25_0
    {
        /*0x10*/ ui_popup <>4__this;
        /*0x18*/ data_quest_element quest;
        /*0x20*/ ui_popup.State state;

        /*0x1a11a44*/ <>c__DisplayClass25_0();
        /*0x1a13318*/ void <Add_Quest>b__0();
        /*0x1a133ac*/ void <Add_Quest>b__1();
    }

    class <>c__DisplayClass26_0
    {
        /*0x10*/ ui_popup <>4__this;
        /*0x18*/ string code;

        /*0x1a11a4c*/ <>c__DisplayClass26_0();
        /*0x1a1343c*/ void <Add_tutorial>b__0();
    }

    class <>c__DisplayClass27_0
    {
        /*0x10*/ ui_popup <>4__this;
        /*0x18*/ int rank_reached;

        /*0x1a11b84*/ <>c__DisplayClass27_0();
        /*0x1a13a9c*/ void <Add_Rankup_Tutorial>b__0();
    }

    class <>c__DisplayClass28_0
    {
        /*0x10*/ ui_popup <>4__this;
        /*0x18*/ int lv_origin;
        /*0x1c*/ int lv_target;

        /*0x1a11c50*/ <>c__DisplayClass28_0();
        /*0x1a13ca4*/ void <Add_infinite>b__0();
    }

    class <IE_Play>d__31 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ui_popup <>4__this;

        /*0x1a11cc0*/ <IE_Play>d__31(int <>1__state);
        /*0x1a13ea8*/ void System.IDisposable.Dispose();
        /*0x1a13eac*/ bool MoveNext();
        /*0x1a14018*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1a14020*/ void System.Collections.IEnumerator.Reset();
        /*0x1a14060*/ object System.Collections.IEnumerator.get_Current();
    }
}

class ui_popup_fish : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_name;
    /*0x20*/ GarlicText.UI.HyperText text_lv;
    /*0x28*/ GarlicText.UI.HyperText text_info;
    /*0x30*/ UnityEngine.UI.Image img_sprite;
    /*0x38*/ UnityEngine.UI.Image img_type;
    /*0x40*/ UnityEngine.GameObject img_new;
    /*0x48*/ UnityEngine.GameObject img_up;

    /*0x1a14068*/ ui_popup_fish();
    /*0x1a12cbc*/ void Open(data_fish_element fish, ui_popup.State state, int lv);
}

class ui_popup_infinite : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_lv;
    /*0x20*/ SimplePool<data_fish_infinite_element.LvRewardPair> pool;
    /*0x28*/ UnityEngine.Transform pool_parent;
    /*0x30*/ UnityEngine.GameObject pool_prefab;
    /*0x38*/ int <lv_origin>k__BackingField;
    /*0x3c*/ int lv_target;
    /*0x40*/ int <lv_now>k__BackingField;
    /*0x48*/ System.Collections.IEnumerator cor;

    /*0x1a14278*/ ui_popup_infinite();
    /*0x1a14070*/ void Awake();
    /*0x1a141c8*/ int get_lv_origin();
    /*0x1a141d0*/ void set_lv_origin(int value);
    /*0x1a13ccc*/ void Open(int lv_origin, int lv_target);
    /*0x1a14240*/ int get_lv_now();
    /*0x1a14248*/ void set_lv_now(int value);
    /*0x1a141d8*/ System.Collections.IEnumerator IE_Play();

    class <IE_Play>d__16 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ui_popup_infinite <>4__this;
        /*0x28*/ float <lv_now_float>5__2;

        /*0x1a14250*/ <IE_Play>d__16(int <>1__state);
        /*0x1a14280*/ void System.IDisposable.Dispose();
        /*0x1a14284*/ bool MoveNext();
        /*0x1a144dc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x1a144e4*/ void System.Collections.IEnumerator.Reset();
        /*0x1a14524*/ object System.Collections.IEnumerator.get_Current();
    }
}

class ui_popup_infinite_reward_cell : SimplePool_element<data_fish_infinite_element.LvRewardPair>
{
    /*0x28*/ GarlicText.UI.HyperText text_lv;
    /*0x30*/ UnityEngine.UI.Image img_skin;
    /*0x38*/ UnityEngine.UI.Image img_done;
    /*0x40*/ UnityEngine.CanvasGroup canvasGroup;
    /*0x48*/ UnityEngine.AudioClip sfx_done;
    /*0x50*/ bool _isDone;

    /*0x1a149b0*/ ui_popup_infinite_reward_cell();
    /*0x1a1452c*/ bool get_isDone();
    /*0x1a14534*/ void set_isDone(bool value);
    /*0x1a145c0*/ void Instantiate();
    /*0x1a146f4*/ void Update();
}

class ui_popup_journal : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_title;
    /*0x20*/ GarlicText.UI.HyperText text_contents;
    /*0x28*/ UnityEngine.UI.Button prev;
    /*0x30*/ UnityEngine.UI.Button next;
    /*0x38*/ UnityEngine.UI.Image img_new;
    /*0x40*/ data_quest_element journal_quest;
    /*0x48*/ ui_popup.State state;
    /*0x4c*/ int total_page;
    /*0x50*/ int current_page;
    /*0x58*/ string title_string;
    /*0x60*/ string[] paged_content_strings;

    /*0x1a14fcc*/ ui_popup_journal();
    /*0x1a149f8*/ void OnEnable();
    /*0x1a14ab0*/ void OnDisable();
    /*0x1a13344*/ void Open(data_quest_element journal_quest, ui_popup.State state);
    /*0x1a14b68*/ void Refresh_UI();
    /*0x1a14c14*/ void init_texts();
    /*0x1a14d80*/ void refresh_page();
    /*0x1a14dbc*/ void setup_title();
    /*0x1a14de8*/ void setup_current_page();
    /*0x1a14e30*/ void setup_arrow_button_state();
    /*0x1a14f14*/ void Prev();
    /*0x1a14f3c*/ void Next();
    /*0x1a14f70*/ void Click_Godmod();
}

class ui_popup_legend : UnityEngine.MonoBehaviour
{
    static int POTION_NUM = 2;
    /*0x18*/ double num_amber;
    /*0x20*/ UnityEngine.Vector3 effect_pos;
    /*0x30*/ GarlicText.UI.HyperText text_popup_legend_amber;
    /*0x38*/ GarlicText.UI.HyperText text_popup_legend_time;
    /*0x40*/ GarlicText.UI.HyperText text_popup_legend_button;

    /*0x1a1527c*/ ui_popup_legend();
    /*0x1a12fe4*/ void Open(double num_amber, UnityEngine.Vector3 effect_pos);
    /*0x1a14fd4*/ void Update();
    /*0x1a151c8*/ void Click();
    /*0x1a15284*/ void <Click>b__8_0();
}

class ui_popup_lv : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_lv;
    /*0x20*/ GarlicText.UI.HyperText text_dmg;

    /*0x1a1542c*/ ui_popup_lv();
    /*0x1a11f88*/ void Open(int lv);
}

class ui_popup_parallel : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_difficulty;
    /*0x20*/ GarlicText.UI.HyperText text_info;

    /*0x1a15434*/ ui_popup_parallel();
    /*0x1a131a4*/ void Open(int difficulty);
}

class ui_popup_preview : UnityEngine.MonoBehaviour
{
    /*0x1a15558*/ ui_popup_preview();
    /*0x1a12ba8*/ void Open(data_skin_element skin);
    /*0x1a1543c*/ void OnDisable();
    /*0x1a15500*/ void Close();
}

class ui_popup_quest : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_title;
    /*0x20*/ GarlicText.UI.HyperText text_info;
    /*0x28*/ GarlicText.UI.HyperText text_reward;
    /*0x30*/ UnityEngine.UI.Image img_npc;
    /*0x38*/ UnityEngine.UI.Image icon_new;
    /*0x40*/ UnityEngine.UI.Button button_done;
    /*0x48*/ ui_popup_quest_option option_task;
    /*0x50*/ ui_popup_quest_option option_place_reward;
    /*0x58*/ data_quest_element quest;
    /*0x60*/ ui_popup.State state;

    /*0x1a161b8*/ ui_popup_quest();
    /*0x1a15560*/ void OnEnable();
    /*0x1a15618*/ void OnDisable();
    /*0x1a133d8*/ void Open(data_quest_element quest, ui_popup.State state);
    /*0x1a156d0*/ void Refresh_UI();
    /*0x1a160a8*/ void Click_Finish();
    /*0x1a1615c*/ void Click_Godmod();
}

class ui_popup_quest_option : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_option;
    /*0x20*/ UnityEngine.GameObject obj_done;
    /*0x28*/ UnityEngine.GameObject button_shortcut;
    /*0x30*/ data_place_element place;
    /*0x38*/ bool player_at_target_dimension;

    /*0x1a164d4*/ ui_popup_quest_option();
    /*0x1a15f9c*/ void Refresh(string info, bool isdone, data_place_element place, bool player_at_target_dimension);
    /*0x1a161c0*/ void Click_shortcut();
}

class ui_popup_rank : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_rank;
    /*0x20*/ GarlicText.UI.HyperText text_fish_stat;
    /*0x28*/ UnityEngine.GameObject panel_contents;
    /*0x30*/ SimplePool<UnityEngine.Sprite> pool;
    /*0x38*/ UnityEngine.Transform pool_parent;
    /*0x40*/ UnityEngine.GameObject pool_prefab;

    /*0x1a16568*/ ui_popup_rank();
    /*0x1a164dc*/ void Awake();
    /*0x1a12120*/ void Open(int target_rank);
}

class ui_popup_rank_cell : SimplePool_element<UnityEngine.Sprite>
{
    /*0x28*/ UnityEngine.UI.Image img_icon;

    /*0x1a165bc*/ ui_popup_rank_cell();
    /*0x1a16570*/ void Instantiate();
}

class ui_popup_skin : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_name;
    /*0x20*/ GarlicText.UI.HyperText text_info;
    /*0x28*/ GarlicText.UI.HyperText text_price;
    /*0x30*/ GarlicText.UI.HyperText text_stat;
    /*0x38*/ GarlicText.UI.HyperText text_from;
    /*0x40*/ UnityEngine.UI.Image img_sprite;
    /*0x48*/ UnityEngine.UI.Image img_type;
    /*0x50*/ data_skin_element skin;
    /*0x58*/ int rank;
    /*0x60*/ UnityEngine.GameObject button_buy;
    /*0x68*/ UnityEngine.GameObject button_select;
    /*0x70*/ UnityEngine.GameObject panel_from;
    /*0x78*/ UnityEngine.UI.Image[] icon_rank;
    /*0x80*/ ui_popup_skin.State state;

    /*0x1a168f0*/ ui_popup_skin();
    /*0x1a12584*/ void Open(data_skin_element skin, ui_popup_skin.State state);
    /*0x1a16604*/ void Click_Buy();
    /*0x1a167b8*/ void Click_Select();
    /*0x1a16890*/ void Click_Preview();
    /*0x1a168f8*/ void <Click_Buy>b__16_0();

    enum State
    {
        none = 0,
        buy = 1,
        events = 2,
    }
}

class ui_popup_tutorial : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Transform Content;
    /*0x20*/ UnityEngine.GameObject prefab;
    /*0x28*/ System.Collections.Generic.List<UnityEngine.GameObject> prefab_pages;
    /*0x30*/ string code;
    /*0x38*/ int page_now;
    /*0x3c*/ int page_cnt;
    /*0x40*/ UnityEngine.UI.Button button_before;
    /*0x48*/ UnityEngine.GameObject button_next;
    /*0x50*/ UnityEngine.GameObject button_close;
    /*0x58*/ GarlicText.UI.HyperText text_title;
    /*0x60*/ GarlicText.UI.HyperText text_info;
    /*0x68*/ UnityEngine.Animator anim_prefab;
    /*0x70*/ UnityEngine.Animator anim_text;

    /*0x1a16cb4*/ ui_popup_tutorial();
    /*0x1a13ac4*/ void Open_Rank_Reached(int reached_rank);
    /*0x1a13464*/ void Open(string code);
    /*0x1a16a40*/ void Open_Page(int no);
    /*0x1a16c44*/ void Next();
    /*0x1a16c50*/ void Before();
    /*0x1a16c5c*/ void Close();
}

class ui_quest : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject cell_prefab;
    /*0x20*/ UnityEngine.Transform cell_parent;
    /*0x28*/ System.Collections.Generic.List<ui_quest_cell> cell_pool;
    /*0x30*/ UnityEngine.GameObject icon_updown;
    /*0x38*/ UnityEngine.UI.ScrollRect scrollrect;

    /*0x1a17528*/ ui_quest();
    /*0x1a16cbc*/ void OnEnable();
    /*0x1a171f0*/ void OnDisable();
    /*0x1a16dc0*/ void Refresh_UI();
    /*0x1a17480*/ void Update();

    class <>c
    {
        static /*0x0*/ ui_quest.<> <>9;
        static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<data_quest_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>, data_quest.Type> <>9__5_0;
        static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<data_quest_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>, data_quest_element> <>9__5_1;

        static /*0x1a175a4*/ <>c();
        /*0x1a17608*/ <>c();
        /*0x1a17610*/ data_quest.Type <Refresh_UI>b__5_0(System.Collections.Generic.KeyValuePair<data_quest_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> quest);
        /*0x1a17658*/ data_quest_element <Refresh_UI>b__5_1(System.Collections.Generic.KeyValuePair<data_quest_element, CodeStage.AntiCheat.ObscuredTypes.ObscuredInt> quest);
    }
}

class ui_quest_cell : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject obj_progress;
    /*0x20*/ UnityEngine.GameObject obj_done;
    /*0x28*/ UnityEngine.UI.Image img_npc;
    /*0x30*/ UnityEngine.UI.Image img_progress;
    /*0x38*/ data_quest_element quest;

    /*0x1a17740*/ ui_quest_cell();
    /*0x1a172a8*/ void Refresh(data_quest_element quest);
    /*0x1a17694*/ void OnClick();
}

class ui_side : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.CanvasGroup side_group;
    /*0x20*/ float target;

    /*0x1a178c0*/ ui_side();
    /*0x1a17748*/ void Update();
    /*0x1a17860*/ bool get_isOn();
}

class ui_side_ads : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject panel_potion;
    /*0x20*/ UnityEngine.GameObject panel_buff;

    /*0x1a18194*/ ui_side_ads();
    /*0x1a178c8*/ void Awake();
    /*0x1a17980*/ void Refresh_UI();
    /*0x1a17aac*/ void OnClick();
    /*0x1a17e70*/ void OnClick_Potion();
    /*0x1a17b54*/ void OnClick_Buff();

    class <>c__DisplayClass5_0
    {
        /*0x10*/ System.Action action_reward;

        /*0x1a18184*/ <>c__DisplayClass5_0();
        /*0x1a1819c*/ void <OnClick_Potion>b__1();
    }

    class <>c
    {
        static /*0x0*/ ui_side_ads.<> <>9;
        static /*0x8*/ System.Action <>9__5_0;

        static /*0x1a18240*/ <>c();
        /*0x1a182a4*/ <>c();
        /*0x1a182ac*/ void <OnClick_Potion>b__5_0();
    }

    class <>c__DisplayClass6_0
    {
        /*0x10*/ double time_buff;
        /*0x18*/ System.Action action_reward;

        /*0x1a1818c*/ <>c__DisplayClass6_0();
        /*0x1a18310*/ void <OnClick_Buff>b__0();
        /*0x1a18378*/ void <OnClick_Buff>b__1();
    }
}

class ui_side_amber : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject Panel;

    /*0x1a18650*/ ui_side_amber();
    /*0x1a1841c*/ void Awake();
    /*0x1a184d4*/ void Refresh_UI();
}

class ui_side_autoBalloon : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject panel;
    /*0x20*/ UnityEngine.UI.Image img_fill;
    /*0x28*/ data_relic_element relic_balloon;
    /*0x30*/ UnityEngine.Animator anim;

    /*0x1a188e4*/ ui_side_autoBalloon();
    /*0x1a18658*/ void Awake();
    /*0x1a18710*/ void Update();
    /*0x1a187c0*/ void Refresh();
    /*0x1a18890*/ void On_Activated();
}

class ui_side_autoFight : UnityEngine.MonoBehaviour
{
    /*0x18*/ ui_button button_cancel;
    /*0x20*/ UnityEngine.GameObject obj_Enabled;
    /*0x28*/ UnityEngine.CanvasGroup canvasGroup;

    /*0x1a18b14*/ ui_side_autoFight();
    /*0x1a188ec*/ void Awake();
    /*0x1a189a4*/ void Refresh();
    /*0x1a18aac*/ void OnClick();
}

class ui_side_autoMove : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject myParticle;
    /*0x20*/ UnityEngine.GameObject obj_activated;
    /*0x28*/ UnityEngine.GameObject obj_disactivated;
    /*0x30*/ UnityEngine.GameObject win_autoMove;
    /*0x38*/ UnityEngine.UI.Image img_type;
    /*0x40*/ UnityEngine.Sprite sprite_off;
    /*0x48*/ UnityEngine.Sprite sprite_play;
    /*0x50*/ bool isPlaying;

    /*0x1a18ee0*/ ui_side_autoMove();
    /*0x1a18b1c*/ void Awake();
    /*0x1a18bd4*/ void Refresh_UI();
    /*0x1a18d5c*/ void OnClick();
}

class ui_side_cancel : UnityEngine.MonoBehaviour
{
    /*0x18*/ ui_button button_cancel;

    /*0x1a19068*/ ui_side_cancel();
    /*0x1a18ee8*/ void Awake();
    /*0x1a18fa0*/ void Start();
    /*0x1a18fa4*/ void Refresh_UI();
    /*0x1a19014*/ void OnClick();
}

class ui_side_event : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject win_events;
    /*0x20*/ data_events_element events;
    /*0x28*/ UnityEngine.GameObject obj_prefab;

    /*0x1a19414*/ ui_side_event();
    /*0x1a19070*/ void OnEnable();
    /*0x1a1935c*/ void OnDisable();
    /*0x1a19174*/ void Refresh_UI();
}

class ui_side_farm : UnityEngine.MonoBehaviour
{
    /*0x18*/ ui_button button;
    /*0x20*/ data_place_element place_farm;

    /*0x91aaec*/ ui_side_farm();
    /*0x91a6c8*/ void Awake();
    /*0x91a780*/ void Refresh_UI();
    /*0x91a820*/ bool is_farm();
    /*0x91a904*/ bool is_upgradable_place();
}

class ui_side_helper : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject panel;

    /*0x91ad04*/ ui_side_helper();
    /*0x91aaf4*/ void Awake();
    /*0x91abac*/ void Refresh_UI();
    /*0x91aca8*/ void Click();
}

class ui_side_left : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject panel_quest;
    /*0x20*/ UnityEngine.GameObject icon_isOn;
    /*0x28*/ UnityEngine.GameObject icon_isOff;
    /*0x30*/ bool <On>k__BackingField;

    /*0x91af90*/ ui_side_left();
    /*0x91ad0c*/ void Start();
    /*0x91add0*/ void Refresh_UI();
    /*0x91af08*/ bool get_On();
    /*0x91af10*/ void set_On(bool value);
    /*0x91af1c*/ void OnOff();
}

class ui_side_legend : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject icon_new;
    /*0x20*/ UnityEngine.GameObject icon_upgrade;
    /*0x28*/ UnityEngine.GameObject CanUpgrade;
    /*0x30*/ UnityEngine.UI.Image img_fill;
    /*0x38*/ GarlicText.UI.HyperText text_rate;

    /*0x91b818*/ ui_side_legend();
    /*0x91af98*/ void OnEnable();
    /*0x91b444*/ void OnDisable();
    /*0x91b09c*/ void Refresh_UI();
    /*0x91b4fc*/ void Click();

    class <>c
    {
        static /*0x0*/ ui_side_legend.<> <>9;
        static /*0x8*/ System.Action <>9__8_0;

        static /*0x91b820*/ <>c();
        /*0x91b884*/ <>c();
        /*0x91b88c*/ void <Click>b__8_0();
    }
}

class ui_side_mastery : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject Panel;

    /*0x91bb50*/ ui_side_mastery();
    /*0x91b904*/ void Awake();
    /*0x91b9bc*/ void Refresh_UI();
}

class ui_side_notice : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Button button_connect;
    /*0x20*/ UnityEngine.GameObject button_version;
    /*0x28*/ UnityEngine.GameObject button_event;
    /*0x30*/ UnityEngine.GameObject button_shop;
    /*0x38*/ UnityEngine.GameObject button_mail;
    /*0x40*/ UnityEngine.GameObject button_quest;
    /*0x48*/ UnityEngine.GameObject button_record;
    /*0x50*/ UnityEngine.GameObject button_legend;
    /*0x58*/ UnityEngine.GameObject button_parallel;
    /*0x60*/ UnityEngine.GameObject button_ads;
    /*0x68*/ UnityEngine.GameObject button_share;
    /*0x70*/ UnityEngine.UI.Image img_parallel_isDone;
    /*0x78*/ float cooltime;
    /*0x80*/ UnityEngine.UI.ScrollRect scrollrect;
    /*0x88*/ UnityEngine.GameObject icon_updown;

    /*0x91c64c*/ ui_side_notice();
    /*0x91bb58*/ void Awake();
    /*0x91bb5c*/ void OnEnable();
    /*0x91c16c*/ void OnDisable();
    /*0x91bc60*/ void Refresh_UI();
    /*0x91c224*/ void LateUpdate();
    /*0x91c300*/ void Need_Version();
    /*0x91c4bc*/ void Click_Connect();
    /*0x91c530*/ void Click_parallel();
    /*0x91c5a4*/ void Update();

    class <>c
    {
        static /*0x0*/ ui_side_notice.<> <>9;
        static /*0x8*/ System.Action <>9__18_0;

        static /*0x91c654*/ <>c();
        /*0x91c6b8*/ <>c();
        /*0x91c6c0*/ void <Need_Version>b__18_0();
    }
}

class ui_side_questgroup_temp : UnityEngine.MonoBehaviour
{
    /*0x91cd30*/ ui_side_questgroup_temp();
    /*0x91c71c*/ void DebugQuestGroupStatus(System.Collections.Generic.List<data_quest_group_element> quest_group_list);
    /*0x91cb1c*/ void OnEnable();
    /*0x91cc78*/ void OnDisable();
    /*0x91cc1c*/ void Refresh_UI();
}

class ui_side_record : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject icon_new;

    /*0x91ce68*/ ui_side_record();
    /*0x91cd38*/ void Awake();
    /*0x91cdf0*/ void Refresh_UI();
}

class ui_side_right : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject panel_event;
    /*0x20*/ UnityEngine.GameObject button_mgn;
    /*0x28*/ UnityEngine.GameObject icon_isOn;
    /*0x30*/ UnityEngine.GameObject icon_isOff;
    /*0x38*/ UnityEngine.GameObject icon_isOff_new;
    /*0x40*/ bool <On>k__BackingField;

    /*0x91d358*/ ui_side_right();
    /*0x91ce70*/ void Start();
    /*0x91cf34*/ void Refresh_UI();
    /*0x91d2d0*/ bool get_On();
    /*0x91d2d8*/ void set_On(bool value);
    /*0x91d2e4*/ void OnOff();
}

class ui_side_shop : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject icon_daily_new;

    /*0x91d8b0*/ ui_side_shop();
    /*0x91d360*/ void OnEnable();
    /*0x91d54c*/ void OnDisable();
    /*0x91d464*/ void Refresh_UI();
    /*0x91d604*/ void OnClick();
    /*0x91d6bc*/ void OnClick_China();
    /*0x91d608*/ void OnClick_NonChina();

    class <>c
    {
        static /*0x0*/ ui_side_shop.<> <>9;
        static /*0x8*/ System.Action <>9__5_0;

        static /*0x91d8b8*/ <>c();
        /*0x91d91c*/ <>c();
        /*0x91d924*/ void <OnClick_China>b__5_0();
    }
}

class ui_side_sonar : UnityEngine.MonoBehaviour
{
    /*0x18*/ ui_button button;
    /*0x20*/ UnityEngine.UI.Image img_active;
    /*0x28*/ UnityEngine.CanvasGroup canvasGroup;

    /*0x91dc1c*/ ui_side_sonar();
    /*0x91d998*/ void Awake();
    /*0x91da50*/ void Refresh();
    /*0x91db74*/ void OnClick();
}

class ui_side_special_003 : UnityEngine.MonoBehaviour
{
    /*0x18*/ ui_button button;
    /*0x20*/ data_place_element place_special_003;

    /*0x91dda8*/ ui_side_special_003();
    /*0x91dc24*/ void Awake();
    /*0x91dcdc*/ void Refresh_UI();
}

class ui_button_savedata : UnityEngine.MonoBehaviour
{
    /*0x91e0f4*/ ui_button_savedata();
    /*0x91ddb0*/ void OnClick();
}

class ui_sendbird : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Text text_message;
    /*0x20*/ int ver;

    /*0x91e530*/ ui_sendbird();
    /*0x91e0fc*/ void Awake();
    /*0x91e1b4*/ void Update();
    /*0x91e2cc*/ void Refresh_UI();
    /*0x91e3a0*/ void Open_Window();
}

class ui_top_character : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_rank;
    /*0x20*/ UnityEngine.UI.Image img_parallel;
    /*0x28*/ GarlicText.UI.HyperText text_parallel;
    /*0x30*/ UnityEngine.UI.Image img_new;

    /*0x91e8d0*/ ui_top_character();
    /*0x91e540*/ void OnEnable();
    /*0x91e818*/ void OnDisable();
    /*0x91e644*/ void Refresh_UI();
}

class ui_top_place : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject icon_notice;
    /*0x20*/ GarlicText.UI.HyperText text_place;
    /*0x28*/ GarlicText.UI.HyperText text_timeLeft;
    /*0x30*/ UnityEngine.UI.Image img_placeState;
    /*0x38*/ UnityEngine.UI.Image img_quest;

    /*0x91f518*/ ui_top_place();
    /*0x91e8d8*/ void Awake();
    /*0x91e9ec*/ void Refresh_UI();
    /*0x91f160*/ void Refresh_Sec();
}

class ui_top_screensaver : UnityEngine.MonoBehaviour
{
    /*0x91f584*/ ui_top_screensaver();
    /*0x91f520*/ void OnClick();
}

class ui : UnityEngine.MonoBehaviour
{
    static /*0x0*/ ui ins;
    /*0x18*/ UnityEngine.Animator myAnim;
    /*0x20*/ ui_global_tab tab_bottom;
    /*0x28*/ ui_center center;
    /*0x30*/ ui_win window;
    /*0x38*/ ui_popup popup;
    /*0x40*/ ui_alert alert;
    /*0x48*/ ui_effect effect;
    /*0x50*/ ui_fishDmg fishDmg;
    /*0x58*/ ui_loading loading;
    /*0x60*/ ui_warning warning;
    /*0x68*/ ui_gdpr gdpr;

    static /*0x91f6f4*/ void Effect(data_item_element item, UnityEngine.Vector3 pos_start, bool isWorldPos);
    static /*0x91f790*/ void Effect(data_skin_element skin, UnityEngine.Vector3 pos_start, bool isWorldPos);
    static /*0x91f82c*/ void Effect(data_relic_element relic, int num, UnityEngine.Vector3 pos_start, bool isWorldPos);
    static /*0x91f8d0*/ void Effect(data_currency_element currency, double num, UnityEngine.Vector3 pos_start, bool isWorldPos);
    static /*0x91f974*/ void FishDmg(double dmg, bool isCrit);
    /*0x91f9e8*/ ui();
    /*0x91f58c*/ void Awake();
    /*0x91f670*/ void Initialized();
}

class ui_button_hold_manager : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler
{
    /*0x18*/ float Tick_Time;
    /*0x1c*/ float Tick_Inertia_Factor;
    /*0x20*/ int Tick_Inertia_MaxStep;
    /*0x24*/ int Tick_Inertia_Count_Tick;
    /*0x28*/ UnityEngine.Events.UnityEvent onPointerClick;
    /*0x30*/ UnityEngine.Events.UnityEvent onPointerHold;
    /*0x38*/ bool down;
    /*0x3c*/ int invoke_count;
    /*0x40*/ float tick_time_count;

    /*0x91fbb0*/ ui_button_hold_manager();
    /*0x91f9f0*/ void Awake();
    /*0x91fa08*/ void OnEnable();
    /*0x91f9fc*/ void init();
    /*0x91fa14*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x91fa24*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x91fa60*/ void OnPointerCancel();
    /*0x91fa6c*/ void Update();
}

class ui_gdpr : UnityEngine.MonoBehaviour
{
    /*0x91fc70*/ ui_gdpr();
    /*0x91fbcc*/ void OnClick_Accept();
    /*0x91fc2c*/ void OnClick_Policy();
}

class ui_godmod : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject obj_parent;
    /*0x20*/ UnityEngine.GameObject obj_watermark;
    /*0x28*/ UnityEngine.GameObject obj_tester_watermark;
    /*0x30*/ UnityEngine.GameObject obj_china_watermark;
    /*0x38*/ ui_godmod.State print_state;
    /*0x3c*/ float delta;
    /*0x40*/ int frames;
    /*0x48*/ UnityEngine.UI.Text text_Fps;
    /*0x50*/ UnityEngine.UI.Text text_verifyinfo;
    /*0x58*/ UnityEngine.UI.Text text_Admob_Cool;
    /*0x60*/ UnityEngine.UI.Text text_rank;
    /*0x68*/ UnityEngine.UI.Text text_placeCharge;
    /*0x70*/ UnityEngine.UI.Text text_deviceID;
    /*0x78*/ UnityEngine.UI.Slider slider_time;
    /*0x80*/ UnityEngine.UI.Slider slider_speed;
    /*0x88*/ UnityEngine.UI.Slider slider_haste;
    /*0x90*/ UnityEngine.UI.InputField input_rank;
    /*0x98*/ UnityEngine.UI.Text unityads_block_text;

    /*0x920760*/ ui_godmod();
    /*0x91fc78*/ void Start();
    /*0x91fe3c*/ void Button_OnOff();
    /*0x91fecc*/ void Update();
    /*0x920040*/ void print_fps(float num);
    /*0x9201ac*/ void print_admob_cooltime();
    /*0x9201b0*/ void Refresh();
    /*0x920490*/ void Slider_Time();
    /*0x920504*/ void Slider_Speed();
    /*0x920578*/ void Slider_Haste();
    /*0x9205ec*/ void Input_rank();
    /*0x9206a8*/ void UnityAds_Block_OnClick();

    enum State
    {
        secound = 0,
        frame = 1,
    }
}

class ui_godmod_simulator : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.Dictionary<string, UnityEngine.UI.InputField> inputDic;

    /*0x921b9c*/ ui_godmod_simulator();
    /*0x920768*/ void Awake();
    /*0x920958*/ void OnEnable();
    /*0x92122c*/ void Click_Submit();

    class <>c
    {
        static /*0x0*/ ui_godmod_simulator.<> <>9;
        static /*0x8*/ System.Func<data_place_element, bool> <>9__2_0;
        static /*0x10*/ System.Func<data_place_element, bool> <>9__3_0;

        static /*0x921c18*/ <>c();
        /*0x921c7c*/ <>c();
        /*0x921c84*/ bool <OnEnable>b__2_0(data_place_element place);
        /*0x921ca4*/ bool <Click_Submit>b__3_0(data_place_element place);
    }
}

class ui_loading : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject Panel_Load;
    /*0x20*/ UnityEngine.GameObject Panel_Fader;
    /*0x28*/ int _num_loadRequest;

    /*0x921da4*/ ui_loading();
    /*0x921cc4*/ int get_num_loadRequest();
    /*0x921ccc*/ void set_num_loadRequest(int value);
    /*0x921d78*/ void LateUpdate();
}

class ui_map : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject Panel;
    /*0x20*/ UnityEngine.GameObject icon_left;
    /*0x28*/ UnityEngine.GameObject icon_right;
    /*0x30*/ UnityEngine.UI.Image img_portal_farm;
    /*0x38*/ UnityEngine.UI.Image img_portal_farm_glow;
    /*0x40*/ GarlicText.UI.HyperText text_portal_farm_time;
    /*0x48*/ UnityEngine.UI.Image img_portal;
    /*0x50*/ UnityEngine.UI.Image img_portal_glow;
    /*0x58*/ UnityEngine.UI.Button button_portal_farm;
    /*0x60*/ UnityEngine.UI.Button button_portal;

    /*0x922600*/ ui_map();
    /*0x921dac*/ void Awake();
    /*0x921ec0*/ void Refresh_UI();
    /*0x922140*/ void Refresh_Sec();
    /*0x922324*/ void Update();
    /*0x9223fc*/ void Click_Portal_Farm();
    /*0x922538*/ void Click_Portal();
}

class ui_safearea_topbottom : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.RectTransform panel;
    /*0x20*/ UnityEngine.Rect lastSafeArea;
    /*0x30*/ UnityEngine.Vector2 defaultOffsetMin;
    /*0x38*/ UnityEngine.Vector2 defaultOffsetMax;

    /*0x922940*/ ui_safearea_topbottom();
    /*0x922608*/ void Awake();
    /*0x922680*/ void Start();
    /*0x9226f4*/ void Update();
    /*0x922684*/ void Refresh();
    /*0x9226f8*/ UnityEngine.Rect GetSafeArea();
    /*0x922700*/ void ApplySafeArea(UnityEngine.Rect r);
}

class ui_safearea_topbottom_ignore : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.RectTransform panel;
    /*0x20*/ UnityEngine.Rect lastSafeArea;
    /*0x30*/ UnityEngine.Vector2 defaultOffsetMin;
    /*0x38*/ UnityEngine.Vector2 defaultOffsetMax;

    /*0x922cb4*/ ui_safearea_topbottom_ignore();
    /*0x92298c*/ void Awake();
    /*0x922a04*/ void Start();
    /*0x922a78*/ void Update();
    /*0x922a08*/ void Refresh();
    /*0x922a7c*/ UnityEngine.Rect GetSafeArea();
    /*0x922a84*/ void ApplySafeArea(UnityEngine.Rect r);
}

class ui_screensaver_text_mover : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.RectTransform rt;
    /*0x20*/ UnityEngine.Vector3 initial_position;

    /*0x922db4*/ ui_screensaver_text_mover();
    /*0x922d00*/ void Start();
    /*0x922d68*/ void Update();
}

class ui_scrollrect_position_snapper : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.ScrollRect scrollRect;
    /*0x20*/ UnityEngine.Animator popup_animator;

    /*0x922e78*/ ui_scrollrect_position_snapper();
    /*0x922dbc*/ void Update();
}

class LazyLoadAlphaAnimation : UnityEngine.MonoBehaviour
{
    /*0x18*/ float animate_time;
    /*0x1c*/ float animate_time_count;
    /*0x20*/ float target_y;
    /*0x24*/ float target_alpha;
    /*0x28*/ UnityEngine.CanvasGroup canvas;

    static /*0x922fd4*/ void Attatch_Script(UnityEngine.CanvasGroup canvas, float target_alpha);
    /*0x92304c*/ LazyLoadAlphaAnimation();
    /*0x922e80*/ void Start();
    /*0x922ea0*/ void OnDisable();
    /*0x922ef8*/ void Update();
    /*0x922fc8*/ void init(UnityEngine.CanvasGroup canvas, float target_alpha);
}

class ui_win : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.CanvasGroup canvasGroup;
    /*0x20*/ ui_win_alchemy alchemy;
    /*0x28*/ ui_win_mastery mastery;
    /*0x30*/ ui_win_sendbird sendbird_global;
    /*0x38*/ ui_win_sendbird_china sendbird_china;
    /*0x40*/ ui_win_base shop;
    /*0x48*/ ui_win_shopEmail paymentwall_email;
    /*0x50*/ System.Collections.Generic.List<ui_win_base> windows;

    /*0x9238b8*/ ui_win();
    /*0x923060*/ void Awake();
    /*0x923168*/ bool get_isOpening();
    /*0x9232f4*/ void Close();
    /*0x923608*/ void CloseAll();
    /*0x91de6c*/ void Open(string name);

    class <>c
    {
        static /*0x0*/ ui_win.<> <>9;
        static /*0x8*/ System.Predicate<ui_win_base> <>9__11_0;
        static /*0x10*/ System.Predicate<ui_win_base> <>9__12_0;
        static /*0x18*/ System.Predicate<ui_win_base> <>9__13_0;

        static /*0x923934*/ <>c();
        /*0x923998*/ <>c();
        /*0x9239a0*/ bool <Close>b__11_0(ui_win_base x);
        /*0x9239fc*/ bool <CloseAll>b__12_0(ui_win_base x);
        /*0x923a58*/ bool <Open>b__13_0(ui_win_base x);
    }
}

class ui_win_alchemy : ui_win_base
{
    /*0x20*/ System.Action<int> action;
    /*0x28*/ System.Func<int, System.Collections.Generic.List<CurNumPair>> reward_calculator;
    /*0x30*/ UnityEngine.UI.Slider slider_potion;
    /*0x38*/ UnityEngine.UI.Button button_play;
    /*0x40*/ GarlicText.UI.HyperText text_num;
    /*0x48*/ UnityEngine.UI.Image img_reward;
    /*0x50*/ GarlicText.UI.HyperText text_reward;
    /*0x58*/ int potion_max;
    /*0x60*/ data_tutorial_element tutorial;

    /*0x9242ac*/ ui_win_alchemy();
    /*0x923ab4*/ void Open(System.Action<int> action, System.Func<int, System.Collections.Generic.List<CurNumPair>> reward_calculator);
    /*0x923bf4*/ void OnSlider_potion();
    /*0x923d30*/ void set_reward_text(System.Collections.Generic.List<CurNumPair> reward);
    /*0x923f38*/ void OnClick_play();
    /*0x924234*/ void OnClick_Tutorial();

    class <>c__DisplayClass11_0
    {
        /*0x10*/ ui_win_alchemy <>4__this;
        /*0x18*/ int num;

        /*0x92422c*/ <>c__DisplayClass11_0();
        /*0x9242c4*/ void <OnClick_play>b__0();
    }
}

class ui_win_autoMove : ui_win_base
{
    static int POTION_TO_AUTOSELL_NEEDNUM = 2;
    /*0x20*/ UnityEngine.GameObject obj_autoSell;
    /*0x28*/ UnityEngine.GameObject obj_autoSell_Disabled;
    /*0x30*/ UnityEngine.UI.Toggle toggle_gem;
    /*0x38*/ UnityEngine.UI.Toggle toggle_mastery;
    /*0x40*/ UnityEngine.UI.Toggle toggle_amber;
    /*0x48*/ UnityEngine.UI.Toggle toggle_boss;
    /*0x50*/ UnityEngine.UI.Toggle toggle_rare;
    /*0x58*/ UnityEngine.UI.Toggle toggle_near;
    /*0x60*/ UnityEngine.UI.Toggle toggle_autoSell;
    /*0x68*/ UnityEngine.UI.Button button_autosell_add;
    /*0x70*/ GarlicText.UI.HyperText text_autosell_num;

    /*0x924e1c*/ ui_win_autoMove();
    /*0x9242f4*/ void OnEnable();
    /*0x9247ac*/ void OnDisable();
    /*0x9243f8*/ void Refresh_UI();
    /*0x924864*/ void OnClick_Start();
    /*0x9249e0*/ void OnClick_Add_Autosell();
    /*0x924bec*/ void OnClick_Add_Autosell_fast();
    /*0x924e24*/ void <OnClick_Add_Autosell>b__16_0();
}

class ui_win_base : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject win_parent;

    /*0x9242bc*/ ui_win_base();
    /*0x923570*/ void Close();
}

class ui_win_coupon : ui_win_base
{
    /*0x20*/ UnityEngine.UI.InputField inputfield_coupon;

    /*0x924ee0*/ ui_win_coupon();
    /*0x924e28*/ void Submit();
}

class ui_win_credit : ui_win_base
{
    /*0x20*/ ui_button_selectable button_twitter;
    /*0x28*/ ui_button_selectable button_facebook;

    /*0x9255a4*/ ui_win_credit();
    /*0x924ee8*/ void OnEnable();
    /*0x9250d4*/ void OnDisable();
    /*0x924fec*/ void Refresh_UI();
    /*0x92518c*/ void OnClick_Twitter();
    /*0x925398*/ void OnClick_Facebook();
}

class ui_win_daerisave : ui_win_base
{
    /*0x20*/ UnityEngine.UI.Button save_button;
    /*0x28*/ UnityEngine.UI.Button load_button;
    /*0x30*/ UnityEngine.GameObject[] obj_taptap;
    /*0x38*/ UnityEngine.GameObject[] obj_notTaptap;

    /*0x9258f8*/ ui_win_daerisave();
    /*0x9255ac*/ void OnEnable();
    /*0x925770*/ void OnDisable();
    /*0x92566c*/ void Refresh();
    /*0x925828*/ void cloud_load_clicked();
    /*0x92589c*/ void cloud_save_clicked();
}

class ui_win_daerisave_testerLoad : ui_win_base
{
    /*0x20*/ UnityEngine.UI.InputField inputfield_userid;

    /*0x925a08*/ ui_win_daerisave_testerLoad();
    /*0x925900*/ void OnEnable();
    /*0x925978*/ void Submit();
}

class ui_win_events : ui_win_base
{
    /*0x20*/ UnityEngine.Transform event_parent;
    /*0x28*/ data_events_element events;
    /*0x30*/ UnityEngine.GameObject event_prefab;

    /*0x925d68*/ ui_win_events();
    /*0x925a10*/ void OnEnable();
    /*0x925cb0*/ void OnDisable();
    /*0x925b14*/ void Refresh_UI();
}

class ui_win_events_002 : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Button button_skin;
    /*0x20*/ data_skin_element skin_exam;

    /*0x92626c*/ ui_win_events_002();
    /*0x925d70*/ void OnEnable();
    /*0x925f3c*/ void OnDisable();
    /*0x925e74*/ void Refresh_UI();
    /*0x925ff4*/ void Click_Skin();
}

class ui_win_events_skin : UnityEngine.MonoBehaviour
{
    static int POTION_EVENTS_PRICE = 500;
    /*0x18*/ data_events_element events;
    /*0x20*/ UnityEngine.UI.Image img_currency;
    /*0x28*/ GarlicText.UI.HyperText text_currency;
    /*0x30*/ UnityEngine.Transform cell_parent;
    /*0x38*/ UnityEngine.GameObject cell_prefab;
    /*0x40*/ SimplePool<data_skin_element> cells;
    /*0x48*/ UnityEngine.Transform cell_potion;
    /*0x50*/ GarlicText.UI.HyperText text_potion_price;
    /*0x58*/ GarlicText.UI.HyperText text_iap;
    /*0x60*/ data_iap_element iap_now;
    /*0x68*/ UnityEngine.GameObject obj_iap;
    /*0x70*/ GarlicText.UI.HyperText text_iap_price_unSale;
    /*0x78*/ GarlicText.UI.HyperText text_iap_price;
    /*0x80*/ GarlicText.UI.HyperText text_iap_info;
    /*0x88*/ GarlicText.UI.HyperText text_date;

    /*0x927184*/ ui_win_events_skin();
    /*0x926274*/ void OnEnable();
    /*0x926af8*/ void OnDisable();
    /*0x926bb0*/ player_currency_element get_currency_player();
    /*0x926c30*/ void Awake();
    /*0x926378*/ void Refresh_UI();
    /*0x926cfc*/ void Click_potion();
    /*0x926e84*/ void Click_tutorial();
    /*0x926ef8*/ void Click_IAP();
    /*0x926fa8*/ void Click_IAP_China();
    /*0x926efc*/ void Click_IAP_NonChina();
    /*0x92718c*/ void <Click_potion>b__22_0();
    /*0x9273b8*/ void <Click_IAP_China>b__25_0();
}

class ui_win_events_skin_cell : SimplePool_element<data_skin_element>
{
    /*0x28*/ ui_button button;
    /*0x30*/ UnityEngine.UI.Image img_icon;
    /*0x38*/ GarlicText.UI.HyperText text_price;
    /*0x40*/ System.Collections.Generic.List<UnityEngine.GameObject> list_rank;

    /*0x927928*/ ui_win_events_skin_cell();
    /*0x927464*/ void Instantiate();
    /*0x92773c*/ void OnEnable();
    /*0x9277fc*/ void OnDisable();
    /*0x927630*/ void Refresh_UI();
    /*0x9278b4*/ void OnClick();
}

class ui_win_junk : UnityEngine.MonoBehaviour
{
    /*0x927b08*/ ui_win_junk();
    /*0x927970*/ void OnEnable();
    /*0x927a50*/ void OnDisable();
    /*0x927a4c*/ void Refresh_UI();
}

class ui_win_junk_cell : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Image img_icon;
    /*0x20*/ GarlicText.UI.HyperText text_num;
    /*0x28*/ data_currency_element currency;
    /*0x30*/ player_currency_element _element;

    /*0x927e60*/ ui_win_junk_cell();
    /*0x927b10*/ void OnEnable();
    /*0x927d20*/ void OnDisable();
    /*0x927dd8*/ player_currency_element get_element();
    /*0x927c14*/ void Refresh_UI();
}

class ui_win_mastery : ui_win_base
{
    /*0x20*/ data_mastery_element mastery;
    /*0x28*/ SimplePool<ui_win_mastery.MasteryLvPair> _pool;
    /*0x30*/ UnityEngine.GameObject pool_prefab;
    /*0x38*/ UnityEngine.Transform pool_parent;
    /*0x40*/ UnityEngine.UI.Image img_icon;
    /*0x48*/ UnityEngine.UI.Image img_lvLock;
    /*0x50*/ GarlicText.UI.HyperText text_name;
    /*0x58*/ GarlicText.UI.HyperText text_lv;
    /*0x60*/ GarlicText.UI.HyperText text_price;
    /*0x68*/ GarlicText.UI.HyperText text_info;
    /*0x70*/ UnityEngine.Transform panel_ScrollList;
    /*0x78*/ ui_button button_upgrade;

    /*0x928834*/ ui_win_mastery();
    /*0x927e68*/ SimplePool<ui_win_mastery.MasteryLvPair> get_pool();
    /*0x927f00*/ void Open(data_mastery_element mastery);
    /*0x928460*/ void OnEnable();
    /*0x928520*/ void OnDisable();
    /*0x927f08*/ void Refresh_UI();
    /*0x9285e4*/ void OnClick_upgrade();
    /*0x92883c*/ void <OnClick_upgrade>b__19_0();

    struct MasteryLvPair
    {
        /*0x10*/ data_mastery_element mastery;
        /*0x18*/ int lv;

        /*0x9285d8*/ MasteryLvPair(data_mastery_element mastery, int lv);
    }
}

class ui_win_mastery_cell : SimplePool_element<ui_win_mastery.MasteryLvPair>
{
    /*0x30*/ GarlicText.UI.HyperText text_lv;
    /*0x38*/ GarlicText.UI.HyperText text_info;
    /*0x40*/ ui_button button_tutorial;
    /*0x48*/ UnityEngine.CanvasGroup canvasGroup;
    /*0x50*/ data_tutorial_element tutorial;

    /*0x928e64*/ ui_win_mastery_cell();
    /*0x9288a0*/ void Instantiate();
    /*0x928c2c*/ void OnEnable();
    /*0x928cec*/ void OnDisable();
    /*0x928a8c*/ void Refresh_UI();
    /*0x928da4*/ void OnClick_tutorial();
}

class ui_win_menu : ui_win_base
{
    /*0x928eac*/ ui_win_menu();
}

class ui_win_parallel : ui_win_base
{
    /*0x20*/ GarlicText.UI.HyperText text_difficulty_now;
    /*0x28*/ GarlicText.UI.HyperText text_difficulty_record;
    /*0x30*/ GarlicText.UI.HyperText text_amberMult;
    /*0x38*/ ui_button button_open;
    /*0x40*/ ui_button button_close;
    /*0x48*/ ui_button button_downgrade;

    /*0x9299d8*/ ui_win_parallel();
    /*0x928eb4*/ void OnEnable();
    /*0x929340*/ void OnDisable();
    /*0x928fb8*/ void Refresh_UI();
    /*0x9293f8*/ void OnClick_Open();
    /*0x9295c8*/ void OnClick_Close();
    /*0x9297a4*/ void OnClick_Downgrade();
}

class ui_win_rewards : ui_win_base
{
    /*0x20*/ UnityEngine.GameObject icon_questgroup_new;
    /*0x28*/ UnityEngine.GameObject icon_records_new;

    /*0x929c6c*/ ui_win_rewards();
    /*0x9299e0*/ void OnEnable();
    /*0x929bb4*/ void OnDisable();
    /*0x929ae4*/ void Refresh_UI();
}

class ui_win_rewards_fish : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Button[] buttons;
    /*0x20*/ UnityEngine.GameObject cell_prefab;
    /*0x28*/ UnityEngine.Transform cell_parent;
    /*0x30*/ System.Collections.Generic.List<ui_win_rewards_fish_cell> cells;
    /*0x38*/ data_fish.Type type;

    /*0x92a5a8*/ ui_win_rewards_fish();
    /*0x929c74*/ void OnEnable();
    /*0x92a120*/ void OnDisable();
    /*0x92a1d8*/ void Set_Type(data_fish.Type type);
    /*0x92a260*/ void Set_Type(int num);
    /*0x929d78*/ void Refresh_UI();
    /*0x92a624*/ bool <Refresh_UI>b__9_0(data_fish_element fishes);
}

class ui_win_rewards_fish_cell : UnityEngine.MonoBehaviour
{
    /*0x18*/ data_fish_element fish;
    /*0x20*/ GarlicText.UI.HyperText text_lv;
    /*0x28*/ UnityEngine.UI.Image img_icon;
    /*0x30*/ UnityEngine.GameObject img_locked;

    /*0x92a76c*/ ui_win_rewards_fish_cell();
    /*0x92a264*/ void Refresh(data_fish_element fish);
    /*0x92a65c*/ void OnClick();
}

class ui_win_rewards_mail : UnityEngine.MonoBehaviour
{
    /*0x18*/ SimplePool<player_mail_element> pool;
    /*0x20*/ UnityEngine.Transform pool_parent;
    /*0x28*/ UnityEngine.GameObject pool_prefab;
    /*0x30*/ UnityEngine.GameObject panel_empty;

    /*0x92aa84*/ ui_win_rewards_mail();
    /*0x92a774*/ void Awake();
    /*0x92a800*/ void OnEnable();
    /*0x92a9cc*/ void OnDisable();
    /*0x92a904*/ void Refresh_UI();
}

class ui_win_rewards_mail_cell : SimplePool_element<player_mail_element>
{
    /*0x28*/ UnityEngine.UI.Image img_icon;
    /*0x30*/ GarlicText.UI.HyperText text_num;
    /*0x38*/ GarlicText.UI.HyperText text_info;
    /*0x40*/ GarlicText.UI.HyperText text_date;

    /*0x92acc4*/ ui_win_rewards_mail_cell();
    /*0x92aa8c*/ void Instantiate();
    /*0x92abfc*/ void Click();
}

class ui_win_rewards_quest : UnityEngine.MonoBehaviour
{
    static /*0x0*/ ui_win_rewards_quest ins;
    /*0x18*/ SimplePool<data_quest_group_element> pool_group;
    /*0x20*/ UnityEngine.GameObject pool_group_prefab;
    /*0x28*/ UnityEngine.Transform pool_group_parent;
    /*0x30*/ GarlicText.UI.HyperText text_status;
    /*0x38*/ SimplePool<int> pool_group_lines;
    /*0x40*/ UnityEngine.GameObject pool_group_line_prefab;
    /*0x48*/ SimplePool<data_quest_element> pool_quest;
    /*0x50*/ UnityEngine.GameObject pool_quest_prefab;
    /*0x58*/ data_quest_group_element <group_selected>k__BackingField;

    /*0x92bfd4*/ ui_win_rewards_quest();
    /*0x92ad0c*/ void Awake();
    /*0x92af64*/ void OnEnable();
    /*0x92b248*/ void OnDisable();
    /*0x92aec8*/ void initialize();
    /*0x92b068*/ void Refresh_UI();
    /*0x92b75c*/ void Refresh_Target_UI(data_quest_element quest);
    /*0x92b308*/ System.Collections.Generic.List<data_quest_group_element> get_group_targets();
    /*0x92b650*/ void refresh_selected_group();
    /*0x92b954*/ System.Collections.Generic.List<data_quest_element> get_selected_group_quests(data_quest_group_element group_selected);
    /*0x92b490*/ void view_quest_groups_by_types(System.Collections.Generic.List<data_quest_group_element> total_quest_groups);
    /*0x92bcc8*/ void Add_Elements(System.Collections.Generic.List<System.Collections.Generic.List<data_quest_group_element>> non_empty_quest_group_lists);
    /*0x92bb60*/ System.Collections.Generic.List<data_quest_group_element> groups_of_type(data_quest_group_element.Type target_type, System.Collections.Generic.List<data_quest_group_element> total_quest_groups);
    /*0x92becc*/ data_quest_group_element get_group_selected();
    /*0x92bed4*/ void set_group_selected(data_quest_group_element value);
    /*0x92bedc*/ void Open_group(ui_win_rewards_quest_group group_target);
    /*0x92b8d0*/ ui_win_rewards_quest_group get_quest_parent(data_quest_group_element elem);
}

class ui_win_rewards_quest_group : SimplePool_element<data_quest_group_element>
{
    /*0x28*/ GarlicText.UI.HyperText text_title;
    /*0x30*/ GarlicText.UI.HyperText text_progress;
    /*0x38*/ ui_button button_reward;
    /*0x40*/ UnityEngine.UI.Image img_reward;
    /*0x48*/ GarlicText.UI.HyperText text_reward;
    /*0x50*/ UnityEngine.UI.Image img_isOpened;
    /*0x58*/ UnityEngine.UI.Image img_isClosed;
    /*0x60*/ UnityEngine.Transform quest_cells_parent;
    /*0x68*/ UnityEngine.CanvasGroup canvas_group;

    /*0x92c4c8*/ ui_win_rewards_quest_group();
    /*0x92bfdc*/ void Instantiate();
    /*0x92b890*/ void Refresh_Manual();
    /*0x92c01c*/ void Refresh_Quest_Group(data_quest_group_element quest_group);
    /*0x92c390*/ void OnClick_GroupReward();
    /*0x92c470*/ void OnClick_ShowQuest();
}

class ui_win_rewards_quest_group_cell : SimplePool_element<data_quest_element>
{
    /*0x28*/ GarlicText.UI.HyperText ui_quest_name;
    /*0x30*/ UnityEngine.UI.Button button;
    /*0x38*/ UnityEngine.UI.Image img_line;
    /*0x40*/ UnityEngine.UI.Image img_doing;
    /*0x48*/ UnityEngine.UI.Image img_done;

    /*0x92c81c*/ ui_win_rewards_quest_group_cell();
    /*0x92c510*/ void Instantiate();
    /*0x92c7a8*/ void OnClick_quest();
}

class ui_win_rewards_rank : UnityEngine.MonoBehaviour
{
    static /*0x0*/ ui_win_rewards_rank ins;
    /*0x18*/ SimplePool<int> pool;
    /*0x20*/ UnityEngine.Transform pool_parent;
    /*0x28*/ UnityEngine.GameObject pool_prefab;
    /*0x30*/ System.Collections.Generic.List<int> _ranks;
    /*0x38*/ UnityEngine.Coroutine add_element_coroutine;

    /*0x92ce8c*/ ui_win_rewards_rank();
    /*0x92c864*/ System.Collections.Generic.List<int> get_ranks();
    /*0x92c970*/ void Awake();
    /*0x92ca68*/ void OnEnable();
    /*0x92ccc0*/ void OnDisable();
    /*0x92cb6c*/ void Refresh_UI();
    /*0x92cd9c*/ void Refresh_Target_UI(int current_rank);
}

class ui_win_rewards_rank_cell : SimplePool_element<int>
{
    /*0x28*/ SimplePool<UnityEngine.Sprite> pool_icons;
    /*0x30*/ UnityEngine.GameObject icons_prefab;
    /*0x38*/ UnityEngine.Transform icons_parent;
    /*0x40*/ UnityEngine.UI.Outline[] _outlines;
    /*0x48*/ UnityEngine.CanvasGroup canvasGroup;
    /*0x50*/ GarlicText.UI.HyperText text_rank;

    /*0x92d4d8*/ ui_win_rewards_rank_cell();
    /*0x92ce94*/ UnityEngine.UI.Outline[] get_outlines();
    /*0x92cef0*/ float get_target_alpha();
    /*0x92cfb4*/ void OnDisable();
    /*0x92d00c*/ void Instantiate();
    /*0x92ce88*/ void Refresh_Manual();
    /*0x92d010*/ void Refresh();
}

class ui_win_rewards_rank_cell_icon : SimplePool_element<UnityEngine.Sprite>
{
    /*0x28*/ UnityEngine.UI.Image img_icon;

    /*0x92d56c*/ ui_win_rewards_rank_cell_icon();
    /*0x92d520*/ void Instantiate();
}

class ui_win_rewards_record : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject cell_prefab;
    /*0x20*/ UnityEngine.Transform cell_parent;
    /*0x28*/ System.Collections.Generic.List<ui_win_rewards_record_cell> cells;

    /*0x92deb4*/ ui_win_rewards_record();
    /*0x92d5b4*/ void OnEnable();
    /*0x92d9fc*/ void OnDisable();
    /*0x92d6b8*/ void Refresh_UI();
}

class ui_win_rewards_record_cell : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_todo;
    /*0x20*/ GarlicText.UI.HyperText text_reward;
    /*0x28*/ ui_button button_reward;
    /*0x30*/ UnityEngine.UI.Image bar_numRate;
    /*0x38*/ player_record_element record;

    /*0x92df70*/ ui_win_rewards_record_cell();
    /*0x92dab4*/ void Refresh(player_record_element record);
    /*0x92df30*/ void Add_Reward();
}

class ui_win_sendbird : ui_win_base
{
    /*0x20*/ System.Collections.Generic.List<ui_win_sendbird_cell> cells;
    /*0x28*/ UnityEngine.GameObject cell_prefab;
    /*0x30*/ UnityEngine.Transform cell_parent;
    /*0x38*/ UnityEngine.GameObject panel_connected;
    /*0x40*/ UnityEngine.GameObject panel_disconnected;
    /*0x48*/ UnityEngine.GameObject panel_disc_input;
    /*0x50*/ UnityEngine.GameObject panel_disc_loading;
    /*0x58*/ UnityEngine.UI.InputField input_room;
    /*0x60*/ UnityEngine.UI.InputField input_message;
    /*0x68*/ UnityEngine.UI.Text text_nickname;
    /*0x70*/ UnityEngine.UI.Text text_room;
    /*0x78*/ ui_button button_qna;
    /*0x80*/ ui_button button_default;
    /*0x88*/ ui_button button_anime;
    /*0x90*/ int ver;
    /*0x98*/ UnityEngine.UI.Toggle scrollbar_lock;
    /*0xa0*/ UnityEngine.UI.Scrollbar scrollbar;

    /*0x92ee44*/ ui_win_sendbird();
    /*0x92df78*/ void OnEnable();
    /*0x92df7c*/ void Update();
    /*0x92e340*/ void OnTextChanged();
    /*0x92e770*/ System.Collections.IEnumerator IE_GotoLast();
    /*0x92e800*/ void Submit_Login();
    /*0x92e984*/ void Submit_Login(string room);
    /*0x92eb1c*/ void Submit_Login_Event();
    /*0x92ec78*/ void OnConnectedSendbird(string room, string channel);
    /*0x92ecec*/ void Submit_Logout();
    /*0x92ed48*/ void Submit_Message();
    /*0x92ee00*/ void Submit_Email();
    /*0x92eec8*/ void <Submit_Login>b__21_0();
    /*0x92ef1c*/ void <Submit_Login_Event>b__23_0();

    class <IE_GotoLast>d__20 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ui_win_sendbird <>4__this;

        /*0x92e7d8*/ <IE_GotoLast>d__20(int <>1__state);
        /*0x92ef74*/ void System.IDisposable.Dispose();
        /*0x92ef78*/ bool MoveNext();
        /*0x92f00c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x92f014*/ void System.Collections.IEnumerator.Reset();
        /*0x92f054*/ object System.Collections.IEnumerator.get_Current();
    }

    class <>c
    {
        static /*0x0*/ ui_win_sendbird.<> <>9;
        static /*0x8*/ System.Action<string> <>9__21_1;
        static /*0x10*/ System.Action<string> <>9__22_1;
        static /*0x18*/ System.Action<string> <>9__23_1;

        static /*0x92f05c*/ <>c();
        /*0x92f0c0*/ <>c();
        /*0x92f0c8*/ void <Submit_Login>b__21_1(string errorMsg);
        /*0x92f11c*/ void <Submit_Login>b__22_1(string errorMsg);
        /*0x92f170*/ void <Submit_Login_Event>b__23_1(string errorMsg);
    }

    class <>c__DisplayClass22_0
    {
        /*0x10*/ ui_win_sendbird <>4__this;
        /*0x18*/ string room;

        /*0x92eb14*/ <>c__DisplayClass22_0();
        /*0x92f1c4*/ void <Submit_Login>b__0();
    }
}

class ui_win_sendbird_block : UnityEngine.MonoBehaviour
{
    /*0x18*/ System.Collections.Generic.List<ui_win_sendbird_block_cell> cells;
    /*0x20*/ UnityEngine.GameObject cell_prefab;
    /*0x28*/ UnityEngine.Transform cell_parent;

    /*0x92f714*/ ui_win_sendbird_block();
    /*0x92f218*/ void OnEnable();
    /*0x92f5d8*/ void OnDisable();
    /*0x92f2d8*/ void Refresh();
}

class ui_win_sendbird_block_cell : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Text text_message;
    /*0x20*/ UnityEngine.GameObject button_ban;
    /*0x28*/ string id;
    /*0x30*/ string nickname;
    /*0x38*/ string text;

    /*0x92f8f4*/ ui_win_sendbird_block_cell();
    /*0x92f690*/ void Refresh(string id, string nickname);
    /*0x92f790*/ void Click_UnBan();
    /*0x92f8fc*/ void <Click_UnBan>b__6_0();
}

class ui_win_sendbird_cell : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Text text_message;
    /*0x20*/ UnityEngine.GameObject button_ban;
    /*0x28*/ string id;
    /*0x30*/ string nickname;
    /*0x38*/ string text;

    /*0x92fb30*/ ui_win_sendbird_cell();
    /*0x92e694*/ void Refresh(string text, string id, string nickname);
    /*0x92f960*/ void Click_Ban();
    /*0x92fb38*/ void <Click_Ban>b__6_0();
}

class ui_win_sendbird_china : ui_win_base
{
    /*0x20*/ System.Collections.Generic.List<ui_win_sendbird_cell> cells;
    /*0x28*/ UnityEngine.GameObject cell_prefab;
    /*0x30*/ UnityEngine.Transform cell_parent;
    /*0x38*/ UnityEngine.GameObject panel_connected;
    /*0x40*/ UnityEngine.GameObject panel_disconnected;
    /*0x48*/ UnityEngine.GameObject panel_disc_input;
    /*0x50*/ UnityEngine.GameObject panel_disc_loading;
    /*0x58*/ UnityEngine.UI.InputField input_message;
    /*0x60*/ UnityEngine.UI.Text text_nickname;
    /*0x68*/ UnityEngine.UI.Text text_room;
    /*0x70*/ int ver;
    /*0x78*/ UnityEngine.UI.Toggle scrollbar_lock;
    /*0x80*/ UnityEngine.UI.Scrollbar scrollbar;

    /*0x930740*/ ui_win_sendbird_china();
    /*0x92fb9c*/ void OnEnable();
    /*0x92fba0*/ void Update();
    /*0x92fe9c*/ void OnTextChanged();
    /*0x9301f0*/ System.Collections.IEnumerator IE_GotoLast();
    /*0x930280*/ void Submit_Login(string room);
    /*0x930418*/ void Submit_Login_Event();
    /*0x930574*/ void Submit_Logout();
    /*0x9305d0*/ void OnConnectedSendbird(string room, string channel);
    /*0x930644*/ void Submit_Message();
    /*0x9306fc*/ void Submit_Email();
    /*0x9307c4*/ void <Submit_Login_Event>b__18_0();

    class <IE_GotoLast>d__16 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ui_win_sendbird_china <>4__this;

        /*0x930258*/ <IE_GotoLast>d__16(int <>1__state);
        /*0x93081c*/ void System.IDisposable.Dispose();
        /*0x930820*/ bool MoveNext();
        /*0x9308b4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x9308bc*/ void System.Collections.IEnumerator.Reset();
        /*0x9308fc*/ object System.Collections.IEnumerator.get_Current();
    }

    class <>c__DisplayClass17_0
    {
        /*0x10*/ ui_win_sendbird_china <>4__this;
        /*0x18*/ string room;

        /*0x930410*/ <>c__DisplayClass17_0();
        /*0x930904*/ void <Submit_Login>b__0();
    }

    class <>c
    {
        static /*0x0*/ ui_win_sendbird_china.<> <>9;
        static /*0x8*/ System.Action<string> <>9__17_1;
        static /*0x10*/ System.Action<string> <>9__18_1;

        static /*0x930958*/ <>c();
        /*0x9309bc*/ <>c();
        /*0x9309c4*/ void <Submit_Login>b__17_1(string errorMsg);
        /*0x930a18*/ void <Submit_Login_Event>b__18_1(string errorMsg);
    }
}

class ui_win_setting : ui_win_base
{
    /*0x20*/ UnityEngine.GameObject button_gpgs_connect;
    /*0x28*/ UnityEngine.GameObject button_gpgs_disconnect;
    /*0x30*/ UnityEngine.UI.Button button_fps_min;
    /*0x38*/ UnityEngine.UI.Button button_fps_mid;
    /*0x40*/ UnityEngine.UI.Button button_fps_max;
    /*0x48*/ UnityEngine.UI.Button button_res_min;
    /*0x50*/ UnityEngine.UI.Button button_res_mid;
    /*0x58*/ UnityEngine.UI.Button button_res_max;
    /*0x60*/ UnityEngine.UI.Button button_lang_en;
    /*0x68*/ UnityEngine.UI.Button button_lang_kr;
    /*0x70*/ UnityEngine.UI.Button button_lang_jp;
    /*0x78*/ UnityEngine.UI.Button button_lang_ch;
    /*0x80*/ UnityEngine.UI.Button button_lang_tw;
    /*0x88*/ UnityEngine.UI.Button button_quality_high;
    /*0x90*/ UnityEngine.UI.Button button_quality_low;
    /*0x98*/ UnityEngine.UI.Button button_popup_0;
    /*0xa0*/ UnityEngine.UI.Button button_popup_1;
    /*0xa8*/ UnityEngine.UI.Button button_popup_2;
    /*0xb0*/ UnityEngine.UI.Button button_tip_1;
    /*0xb8*/ UnityEngine.UI.Button button_tip_2;
    /*0xc0*/ UnityEngine.UI.Button button_tip_0;
    /*0xc8*/ UnityEngine.UI.Toggle toggle_itemeffect;
    /*0xd0*/ UnityEngine.UI.Toggle toggle_skilleffect;
    /*0xd8*/ UnityEngine.UI.Toggle toggle_vibrate;
    /*0xe0*/ UnityEngine.UI.Toggle toggle_push;
    /*0xe8*/ UnityEngine.UI.Toggle toggle_mute;
    /*0xf0*/ UnityEngine.UI.Toggle toggle_sound_sonar;
    /*0xf8*/ UnityEngine.UI.Toggle toggle_damage;
    /*0x100*/ UnityEngine.UI.Toggle toggle_fastupgrade;
    /*0x108*/ UnityEngine.UI.Toggle toggle_autosave;
    /*0x110*/ UnityEngine.UI.Slider slider_volume_ambient;
    /*0x118*/ UnityEngine.UI.Slider slider_volume_bgm;
    /*0x120*/ UnityEngine.UI.Slider slider_volume_sfx;
    /*0x128*/ GarlicText.UI.HyperText text_gpgs_id_data;
    /*0x130*/ GarlicText.UI.HyperText text_gpgs_id_now;
    /*0x138*/ GarlicText.UI.HyperText text_version;
    /*0x140*/ UnityEngine.GameObject panel_language;

    /*0x931c7c*/ ui_win_setting();
    /*0x930a6c*/ void OnEnable();
    /*0x931558*/ void OnDisable();
    /*0x930b70*/ void Refresh_UI();
    /*0x931610*/ void toggle_changed_itemeffect();
    /*0x9316c4*/ void toggle_changed_skilleffect();
    /*0x931778*/ void toggle_changed_vibrate();
    /*0x93184c*/ void toggle_changed_push();
    /*0x931850*/ void toggle_changed_mute();
    /*0x931904*/ void toggle_changed_fastupgrade();
    /*0x9319b8*/ void toggle_changed_damage();
    /*0x931a6c*/ void toggle_changed_sound_sonar();
    /*0x931b20*/ void toggle_changed_autosave();
    /*0x931bd4*/ void Refreshser();
}

class ui_win_setting_volume : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Slider _mySlider;
    /*0x20*/ sound.group_type group;

    /*0x9e7c2c*/ ui_win_setting_volume();
    /*0x9e7b10*/ UnityEngine.UI.Slider get_mySlider();
    /*0x9e7ba4*/ void Change_volume();
}

class ui_win_share : ui_win_base
{
    static string twitter_jp = "https://goo.gl/wci1jr";
    static string facebook_hanja = "https://www.facebook.com/sharer/sharer.php?u=https%3A%2F%2Fwww.facebook.com%2FDAERISOFT%2Fvideos%2F1424602580967123%2F&quote=";
    static string facebook_eng = "https://www.facebook.com/sharer/sharer.php?u=https%3A%2F%2Fwww.facebook.com%2FDAERISOFT%2Fvideos%2F1424604840966897%2F&quote=";
    /*0x20*/ GarlicText.UI.HyperText text_reward;
    /*0x28*/ ui_button button_twitter;
    /*0x30*/ ui_button button_facebook;

    /*0x9e8364*/ ui_win_share();
    /*0x9e7c34*/ void OnEnable();
    /*0x9e7ea4*/ void OnDisable();
    /*0x9e7d30*/ void Refresh();
    /*0x9e7f5c*/ void Onclick_Twitter();
    /*0x9e80b0*/ void Onclick_Facebook();
    /*0x9e81c4*/ void give_reward();
}

class ui_win_shopEmail : ui_win_base
{
    /*0x20*/ UnityEngine.UI.InputField inputfield_email;
    /*0x28*/ System.Action onSubmitAction;

    /*0x9e85bc*/ ui_win_shopEmail();
    /*0x9e836c*/ void Submit();
}

class ui_win_shop_cell : UnityEngine.MonoBehaviour
{
    /*0x18*/ data_iap_element product;
    /*0x20*/ ui_button _button;
    /*0x28*/ GarlicText.UI.HyperText text_name;
    /*0x30*/ GarlicText.UI.HyperText text_price;
    /*0x38*/ System.Collections.Generic.List<ui_win_shop_cell.Reward_UI> rewards;
    /*0x40*/ bool isPurchased;

    /*0x9e8cb8*/ ui_win_shop_cell();
    /*0x9e85c4*/ void OnEnable();
    /*0x9e8a8c*/ void OnDisable();
    /*0x9e8b44*/ ui_button get_button();
    /*0x9e86c4*/ void Refresh_UI();
    /*0x9e8c54*/ void OnClick();

    struct Reward_UI
    {
        /*0x10*/ UnityEngine.UI.Image img;
        /*0x18*/ GarlicText.UI.HyperText text;
    }
}

class ui_win_shop_china : UnityEngine.MonoBehaviour
{
    /*0x9e8d20*/ ui_win_shop_china();
    /*0x9e8cc0*/ void open_xsolla();
}

class ui_win_shop_removeAds : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject panel;

    /*0x9e8f94*/ ui_win_shop_removeAds();
    /*0x9e8d28*/ void OnEnable();
    /*0x9e8edc*/ void OnDisable();
    /*0x9e8e2c*/ void Refresh_UI();
}

class ui_win_shop_special : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_vip_left;
    /*0x20*/ GarlicText.UI.HyperText text_diamond;
    /*0x28*/ GarlicText.UI.HyperText text_store_refill;
    /*0x30*/ ui_button button_daily;
    /*0x38*/ ui_button button_daily_vip;
    /*0x40*/ UnityEngine.UI.Image img_daily_vip_done;
    /*0x48*/ UnityEngine.GameObject obj_store;
    /*0x50*/ System.Collections.Generic.List<ui_win_shop_special_skin> button_store_skins;

    /*0x9e9f50*/ ui_win_shop_special();
    /*0x9e8f9c*/ void OnEnable();
    /*0x9e9758*/ void OnDisable();
    /*0x9e90a0*/ void Refresh_UI();
    /*0x9e9a48*/ void Click_Iap_Vip();
    /*0x9e9a4c*/ void unity_iap_buy_vip();
    /*0x9e9de0*/ void Click_Daily_Reward();
    /*0x9e9e98*/ void Click_Daily_Reward_Vip();

    class <>c__DisplayClass12_0
    {
        /*0x10*/ data_iap_element iap;

        /*0x9e9dcc*/ <>c__DisplayClass12_0();
        /*0x9e9f58*/ void <unity_iap_buy_vip>b__0();
    }
}

class ui_win_shop_special_buff : UnityEngine.MonoBehaviour
{
    /*0x18*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble time_buff;
    /*0x38*/ CurNumPair price;
    /*0x40*/ GarlicText.UI.HyperText text_price;

    /*0x9ea3f0*/ ui_win_shop_special_buff();
    /*0x9e9fbc*/ void OnEnable();
    /*0x9ea104*/ void OnDisable();
    /*0x9ea0c0*/ void Refresh_UI();
    /*0x9ea1bc*/ void Click();
    /*0x9ea3f8*/ void <Click>b__6_0();
}

class ui_win_shop_special_skin : UnityEngine.MonoBehaviour
{
    /*0x18*/ data_skin_element element;
    /*0x20*/ UnityEngine.UI.Image img_skin;
    /*0x28*/ GarlicText.UI.HyperText text_currency;
    /*0x30*/ ui_button button;
    /*0x38*/ System.Collections.Generic.List<UnityEngine.UI.Image> list_img_ranks;

    /*0x9ea5f4*/ ui_win_shop_special_skin();
    /*0x9e9810*/ void Refresh(data_skin_element element);
    /*0x9ea58c*/ void Click();
}

class ui_win_shop_special_vip_skin : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject panel;
    /*0x20*/ GarlicText.UI.HyperText text_needDate;
    /*0x28*/ GarlicText.UI.HyperText text_daily_done;
    /*0x30*/ UnityEngine.UI.Button button;
    /*0x38*/ UnityEngine.UI.Image img_line;
    /*0x40*/ UnityEngine.UI.Image img_skin;
    /*0x48*/ System.Collections.Generic.List<ui_win_shop_special_vip_skin.vip_skin> skins;
    /*0x50*/ UnityEngine.GameObject obj_own;
    /*0x58*/ UnityEngine.GameObject obj_need;
    /*0x60*/ ui_win_shop_special_vip_skin.vip_skin skin_target;

    /*0x9eaefc*/ ui_win_shop_special_vip_skin();
    /*0x9ea5fc*/ void OnEnable();
    /*0x9eac30*/ void OnDisable();
    /*0x9ea700*/ void Refresh_UI();
    /*0x9eace8*/ void Click();

    class vip_skin
    {
        /*0x10*/ int need_days;
        /*0x18*/ data_skin_element skin;

        /*0x9eaf04*/ vip_skin();
    }

    class <>c
    {
        static /*0x0*/ ui_win_shop_special_vip_skin.<> <>9;
        static /*0x8*/ System.Func<ui_win_shop_special_vip_skin.vip_skin, bool> <>9__13_0;
        static /*0x10*/ System.Func<ui_win_shop_special_vip_skin.vip_skin, int> <>9__13_1;

        static /*0x9eaf0c*/ <>c();
        /*0x9eaf70*/ <>c();
        /*0x9eaf78*/ bool <Refresh_UI>b__13_0(ui_win_shop_special_vip_skin.vip_skin skin);
        /*0x9eb034*/ int <Refresh_UI>b__13_1(ui_win_shop_special_vip_skin.vip_skin skin);
    }
}

class ui_win_skin : ui_win_base
{
    /*0x20*/ GarlicText.UI.HyperText text_info;
    /*0x28*/ System.Collections.Generic.List<UnityEngine.UI.Button> buttons;
    /*0x30*/ SimplePool<data_skin_element> pool;
    /*0x38*/ UnityEngine.GameObject cell_prefab;
    /*0x40*/ UnityEngine.Transform cell_parent;
    /*0x48*/ UnityEngine.CanvasGroup cell_parent_canvas;
    /*0x50*/ data_skin.Type type;
    /*0x58*/ System.Collections.IEnumerator cor;

    /*0x9eb96c*/ ui_win_skin();
    /*0x9eb04c*/ void Awake();
    /*0x9eb0d8*/ void OnEnable();
    /*0x9eb7e4*/ void OnDisable();
    /*0x9eb89c*/ void Set_Type(int num);
    /*0x9eb1e8*/ void Set_Type(data_skin.Type type);
    /*0x9eb310*/ void Refresh_UI();
    /*0x9eb8a0*/ void Refresh_Parent();
    /*0x9eb8dc*/ System.Collections.IEnumerator IE_Refresh_Parent();
    /*0x9eb9e8*/ bool <Refresh_UI>b__12_0(data_skin_element el);
    /*0x9eba0c*/ bool <Refresh_UI>b__12_1(data_skin_element el);

    class <>c
    {
        static /*0x0*/ ui_win_skin.<> <>9;
        static /*0x8*/ System.Func<data_skin_element, string> <>9__12_2;

        static /*0x9ebabc*/ <>c();
        /*0x9ebb20*/ <>c();
        /*0x9ebb28*/ string <Refresh_UI>b__12_2(data_skin_element el);
    }

    class <IE_Refresh_Parent>d__15 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ui_win_skin <>4__this;

        /*0x9eb944*/ <IE_Refresh_Parent>d__15(int <>1__state);
        /*0x9ebb40*/ void System.IDisposable.Dispose();
        /*0x9ebb44*/ bool MoveNext();
        /*0x9ebc84*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x9ebc8c*/ void System.Collections.IEnumerator.Reset();
        /*0x9ebccc*/ object System.Collections.IEnumerator.get_Current();
    }
}

class ui_win_skinrank : ui_win_base
{
    /*0x20*/ UnityEngine.GameObject cell_prefab;
    /*0x28*/ UnityEngine.Transform cell_parent;
    /*0x30*/ System.Collections.Generic.List<ui_win_skinrank_cell> cells;
    /*0x38*/ GarlicText.UI.HyperText text_gem;
    /*0x40*/ UnityEngine.GameObject obj_scrollRect;
    /*0x48*/ UnityEngine.GameObject obj_noSkin;
    /*0x50*/ UnityEngine.UI.Toggle toggle_filter;

    /*0x9ecbb8*/ ui_win_skinrank();
    /*0x9ebcd4*/ void OnEnable();
    /*0x9ec88c*/ void OnDisable();
    /*0x9ebdd8*/ void Refresh_UI();
    /*0x9ecb40*/ void OnClick_Tutorial();
    /*0x9ecbb4*/ void Click_toggle_filter();

    class <>c__DisplayClass9_0
    {
        /*0x10*/ data_skin.Type type;

        /*0x9ec944*/ <>c__DisplayClass9_0();
        /*0x9ecc34*/ bool <Refresh_UI>b__2(data_skin_element skin);
    }

    class <>c
    {
        static /*0x0*/ ui_win_skinrank.<> <>9;
        static /*0x8*/ System.Func<data_skin_element, bool> <>9__9_0;
        static /*0x10*/ System.Func<data_skin_element, double> <>9__9_1;

        static /*0x9ecc58*/ <>c();
        /*0x9eccbc*/ <>c();
        /*0x9eccc4*/ bool <Refresh_UI>b__9_0(data_skin_element s);
        /*0x9ece78*/ double <Refresh_UI>b__9_1(data_skin_element s);
    }
}

class ui_win_skinrank_cell : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Image[] icon_rank;
    /*0x20*/ UnityEngine.UI.Image img_skin;
    /*0x28*/ GarlicText.UI.HyperText text_price;
    /*0x30*/ GarlicText.UI.HyperText text_stat;
    /*0x38*/ UnityEngine.Color color_on;
    /*0x48*/ UnityEngine.Color color_off;
    /*0x58*/ data_skin_element skin;
    /*0x60*/ CurNumPair price;

    /*0x9ed128*/ ui_win_skinrank_cell();
    /*0x9ec94c*/ void Refresh(data_skin_element skin);
    /*0x9ecf44*/ void Click_Upgrade();
    /*0x9ed0c0*/ void Click_Info();
    /*0x9ed130*/ void <Click_Upgrade>b__9_0();
}

class ui_win_skin_cell : SimplePool_element<data_skin_element>
{
    /*0x28*/ UnityEngine.UI.Image img_icon;
    /*0x30*/ UnityEngine.GameObject img_selected;
    /*0x38*/ UnityEngine.CanvasGroup canvasGroup;
    /*0x40*/ UnityEngine.UI.Image[] icon_rank;

    /*0x9ed5a8*/ ui_win_skin_cell();
    /*0x9ed194*/ void Instantiate();
    /*0x9ed198*/ void Refresh();
    /*0x9ed534*/ void OnClick();
}

class ui_win_tutorial : ui_win_base
{
    /*0x20*/ SimplePool<int> pool_group;
    /*0x28*/ UnityEngine.GameObject prefab_group;
    /*0x30*/ UnityEngine.Transform cell_parent;

    /*0x9ed9a0*/ ui_win_tutorial();
    /*0x9ed5f0*/ void Awake();
    /*0x9ed67c*/ void OnEnable();

    class <>c
    {
        static /*0x0*/ ui_win_tutorial.<> <>9;
        static /*0x8*/ System.Func<data_tutorial_element, bool> <>9__4_0;
        static /*0x10*/ System.Func<data_tutorial_element, int> <>9__4_1;
        static /*0x18*/ System.Func<data_tutorial_element, int> <>9__4_2;

        static /*0x9ed9a8*/ <>c();
        /*0x9eda0c*/ <>c();
        /*0x9eda14*/ bool <OnEnable>b__4_0(data_tutorial_element a);
        /*0x9eda2c*/ int <OnEnable>b__4_1(data_tutorial_element a);
        /*0x9eda44*/ int <OnEnable>b__4_2(data_tutorial_element a);
    }
}

class ui_win_tutorial_cell : SimplePool_element<data_tutorial_element>
{
    /*0x28*/ GarlicText.UI.HyperText text_title;

    /*0x9edbb8*/ ui_win_tutorial_cell();
    /*0x9eda5c*/ void Instantiate();
    /*0x9edb34*/ void OnClick();
}

class ui_win_tutorial_group : SimplePool_element<int>
{
    /*0x28*/ SimplePool<data_tutorial_element> pool;
    /*0x30*/ UnityEngine.GameObject prefab;
    /*0x38*/ UnityEngine.Transform parent;
    /*0x40*/ GarlicText.UI.HyperText text_title;

    /*0x9edf94*/ ui_win_tutorial_group();
    /*0x9edc00*/ void Awake();
    /*0x9edc8c*/ void Instantiate();
    /*0x9edfdc*/ bool <Instantiate>b__5_0(data_tutorial_element a);

    class <>c
    {
        static /*0x0*/ ui_win_tutorial_group.<> <>9;
        static /*0x8*/ System.Func<data_tutorial_element, int> <>9__5_1;

        static /*0x9ee048*/ <>c();
        /*0x9ee0ac*/ <>c();
        /*0x9ee0b4*/ int <Instantiate>b__5_1(data_tutorial_element a);
    }
}

class ui_alert : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.CanvasGroup myCanvas;
    /*0x20*/ GarlicText.UI.HyperText myText;
    /*0x28*/ bool _pause;
    /*0x2c*/ float time_wait_default;
    /*0x30*/ bool <isPlaying>k__BackingField;
    /*0x38*/ System.Collections.IEnumerator cor_alert;
    /*0x40*/ float routine_time;
    /*0x48*/ string[] routine_codes;
    /*0x50*/ System.Collections.IEnumerator cor_tip;

    /*0x9ee7e0*/ ui_alert();
    /*0x9ee0cc*/ void Awake();
    /*0x9ee20c*/ void Refresh_Init();
    /*0x9ee2cc*/ bool get_pause();
    /*0x9ee2d4*/ void set_pause(bool value);
    /*0x9ee344*/ void alert(string code, bool isError, object[] options);
    /*0x9e8528*/ void alert(string code, bool isError);
    /*0x9ee4b4*/ void alert(string code, float time, bool isError);
    /*0x9ee3d0*/ void start_alert(string text, float time, bool isError);
    /*0x9ee308*/ void alert_close();
    /*0x9ee644*/ bool get_isPlaying();
    /*0x9ee64c*/ void set_isPlaying(bool value);
    /*0x9ee558*/ System.Collections.IEnumerator IE_Alert(string text, float time);
    /*0x9ee5dc*/ System.Collections.IEnumerator IE_Alert_Close();
    /*0x9ee6a8*/ bool Set_Scale(float scale_end);
    /*0x9ee18c*/ void Reset_Scale();
    /*0x9ee264*/ System.Collections.IEnumerator IE_Tip();

    class <IE_Alert>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ui_alert <>4__this;
        /*0x28*/ string text;
        /*0x30*/ float time;

        /*0x9ee658*/ <IE_Alert>d__19(int <>1__state);
        /*0x9ee7f0*/ void System.IDisposable.Dispose();
        /*0x9ee7f4*/ bool MoveNext();
        /*0x9ee910*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x9ee918*/ void System.Collections.IEnumerator.Reset();
        /*0x9ee958*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_Alert_Close>d__20 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ui_alert <>4__this;

        /*0x9ee680*/ <IE_Alert_Close>d__20(int <>1__state);
        /*0x9ee960*/ void System.IDisposable.Dispose();
        /*0x9ee964*/ bool MoveNext();
        /*0x9ee9d0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x9ee9d8*/ void System.Collections.IEnumerator.Reset();
        /*0x9eea18*/ object System.Collections.IEnumerator.get_Current();
    }

    class <IE_Tip>d__26 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ui_alert <>4__this;
        /*0x28*/ int <alert_codes_cnt>5__2;

        /*0x9ee7b8*/ <IE_Tip>d__26(int <>1__state);
        /*0x9eea20*/ void System.IDisposable.Dispose();
        /*0x9eea24*/ bool MoveNext();
        /*0x9eed3c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x9eed44*/ void System.Collections.IEnumerator.Reset();
        /*0x9eed84*/ object System.Collections.IEnumerator.get_Current();
    }
}

class ui_button : UnityEngine.MonoBehaviour, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerExitHandler
{
    static float SIZE_MAX = 1.100000023841858;
    static float SIZE_SPEED = 20;
    static string NAME_NORMAL = "Normal";
    static string NAME_DISABLED = "Disabled";
    /*0x18*/ bool interactable;
    /*0x19*/ bool <isPressing>k__BackingField;
    /*0x20*/ UnityEngine.Transform obj_Normal;
    /*0x28*/ UnityEngine.Transform obj_Disabled;
    /*0x30*/ UnityEngine.Events.UnityEvent OnClick;

    /*0x9ef1f4*/ ui_button();
    /*0x9eed8c*/ bool get_isPressing();
    /*0x9eed94*/ void set_isPressing(bool value);
    /*0x9eeda0*/ void Awake();
    /*0x9eee3c*/ void OnEnable();
    /*0x9eee40*/ void LateUpdate();
    /*0x9ef15c*/ void A_OnPointerDown();
    /*0x9ef170*/ void A_OnPointerUp();
    /*0x9ef19c*/ void A_OnPointerExit();
    /*0x9ef1a4*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x9ef1b0*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
    /*0x9ef1e8*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
}

class ui_button_map : ui_button
{
    /*0x9ef26c*/ ui_button_map();
    /*0x9ef204*/ void OnEnable();
}

class ui_button_pressing : ui_button
{
    /*0x38*/ UnityEngine.Events.UnityEvent OnPressing;
    /*0x40*/ float Tick_Time;
    /*0x44*/ float Tick_Inertia_Factor;
    /*0x48*/ int Tick_Inertia_MaxStep;
    /*0x4c*/ int Tick_Inertia_Count_Tick;
    /*0x50*/ int invoke_count;
    /*0x54*/ float tick_time_count;

    /*0x9ef460*/ ui_button_pressing();
    /*0x9ef27c*/ void Awake();
    /*0x9ef294*/ void OnEnable();
    /*0x9ef2a0*/ void LateUpdate();
    /*0x9ef434*/ void A_OnPointerDown();
    /*0x9ef44c*/ void A_OnPointerUp();
}

class ui_button_selectable : ui_button
{
    static string NAME_SELECTED = "Selected";
    /*0x38*/ bool selected;
    /*0x40*/ UnityEngine.Transform obj_Selected;

    /*0x9ef5a8*/ ui_button_selectable();
    /*0x9ef484*/ void Awake();
    /*0x9ef4f0*/ void LateUpdate();
}

class ui_currency : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_currency;
    /*0x20*/ data_currency_element currency;
    /*0x28*/ bool update;
    /*0x29*/ bool withMax;
    /*0x2a*/ bool withColor;
    /*0x30*/ double num_now;
    /*0x38*/ System.Text.StringBuilder sb;

    /*0x9efd7c*/ ui_currency();
    /*0x9ef5b8*/ player_currency_element get_player_cur();
    /*0x9ef630*/ void Awake();
    /*0x9ef944*/ void OnEnable();
    /*0x9efb84*/ void OnDisable();
    /*0x9efaf0*/ void Refresh_UI();
    /*0x9efc50*/ void Update();
    /*0x9ef63c*/ void Draw(double num);
}

class ui_currency_exchange : UnityEngine.MonoBehaviour
{
    /*0x18*/ CurNumPair currency_from;
    /*0x20*/ CurNumPair currency_target;
    /*0x28*/ GarlicText.UI.HyperText text_currency_from;
    /*0x30*/ UnityEngine.UI.Image img_currency_target;
    /*0x38*/ GarlicText.UI.HyperText text_currency_target;

    /*0x9f0090*/ ui_currency_exchange();
    /*0x9efd84*/ void Start();
    /*0x9efed4*/ void Click_Button();
    /*0x9f0098*/ void <Click_Button>b__6_0();
}

class ui_effect : UnityEngine.MonoBehaviour
{
    /*0x18*/ int play_max;
    /*0x1c*/ int pool_max;
    /*0x20*/ UnityEngine.GameObject prefab;
    /*0x28*/ UnityEngine.RectTransform canvasRect;
    /*0x30*/ UnityEngine.Transform pos_currency;
    /*0x38*/ UnityEngine.Transform pos_gold;
    /*0x40*/ UnityEngine.Transform pos_gem;
    /*0x48*/ UnityEngine.Transform pos_mana;
    /*0x50*/ UnityEngine.Transform pos_item;
    /*0x58*/ UnityEngine.Transform pos_skin;
    /*0x60*/ UnityEngine.Transform pos_mastery;
    /*0x68*/ UnityEngine.Transform pos_amber;
    /*0x70*/ UnityEngine.Transform pos_trace;
    /*0x78*/ UnityEngine.Transform pos_event;
    /*0x80*/ UnityEngine.Transform pos_shop;
    /*0x88*/ UnityEngine.Transform pos_junk;
    /*0x90*/ UnityEngine.Transform pos_dimension;
    /*0x98*/ UnityEngine.Transform pos_automove;
    /*0xa0*/ System.Collections.Generic.List<ui_effect_cell> cell_pool;
    /*0xa8*/ System.Collections.Generic.List<ui_effect_cell> cell_using;
    /*0xb0*/ bool doing;

    /*0x9f1020*/ ui_effect();
    /*0x9f03a0*/ void Awake();
    /*0x9f051c*/ void Play(data_currency_element currency, double num, UnityEngine.Vector3 pos_start, bool isWorldPos);
    /*0x9f0b38*/ void Play(data_item_element item, UnityEngine.Vector3 pos_start, bool isWorldPos);
    /*0x9f0bc0*/ void Play(data_skin_element skin, UnityEngine.Vector3 pos_start, bool isWorldPos);
    /*0x9f0c68*/ void Play(data_relic_element relic, int num, UnityEngine.Vector3 pos_start, bool isWorldPos);
    /*0x9f0d38*/ void Play(UnityEngine.Sprite icon, UnityEngine.Vector3 pos_start, UnityEngine.Vector3 pos_end, bool isWorldPos);
    /*0x9f0a74*/ System.Collections.IEnumerator IE_Play(UnityEngine.Sprite icon, UnityEngine.Vector3 pos_start, UnityEngine.Vector3 pos_end, bool isWorldPos);
    /*0x9f0d84*/ UnityEngine.Vector3 Get_WorldToPos(UnityEngine.Vector3 pos_world);
    /*0x9f0e90*/ void Set_using_to_pool(ui_effect_cell cell);

    enum Type
    {
        currency = 0,
        item = 1,
    }

    class <IE_Play>d__28 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ ui_effect <>4__this;
        /*0x28*/ bool isWorldPos;
        /*0x2c*/ UnityEngine.Vector3 pos_start;
        /*0x38*/ UnityEngine.Sprite icon;
        /*0x40*/ UnityEngine.Vector3 pos_end;

        /*0x9f0d5c*/ <IE_Play>d__28(int <>1__state);
        /*0x9f10c0*/ void System.IDisposable.Dispose();
        /*0x9f10c4*/ bool MoveNext();
        /*0x9f1390*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x9f1398*/ void System.Collections.IEnumerator.Reset();
        /*0x9f13d8*/ object System.Collections.IEnumerator.get_Current();
    }
}

class ui_effect_cell : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Image myImg;
    /*0x20*/ UnityEngine.Animator myAnim;
    /*0x28*/ System.Collections.IEnumerator cor;

    /*0x9f154c*/ ui_effect_cell();
    /*0x9f1320*/ void Play(UnityEngine.Sprite icon, UnityEngine.Vector3 pos_start, UnityEngine.Vector3 pos_end);
    /*0x9f13e0*/ void Play(UnityEngine.Vector3 pos_start, UnityEngine.Vector3 pos_end);
    /*0x9f1464*/ System.Collections.IEnumerator IE_Play(UnityEngine.Vector3 pos_start, UnityEngine.Vector3 pos_end);
    /*0x9f1534*/ UnityEngine.Vector3 get_randomInCircle();

    class <IE_Play>d__5 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
    {
        /*0x10*/ int <>1__state;
        /*0x18*/ object <>2__current;
        /*0x20*/ UnityEngine.Vector3 pos_start;
        /*0x30*/ ui_effect_cell <>4__this;
        /*0x38*/ UnityEngine.Vector3 pos_end;
        /*0x44*/ UnityEngine.Vector3 <pos_target>5__2;

        /*0x9f150c*/ <IE_Play>d__5(int <>1__state);
        /*0x9f1554*/ void System.IDisposable.Dispose();
        /*0x9f1558*/ bool MoveNext();
        /*0x9f1aa0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
        /*0x9f1aa8*/ void System.Collections.IEnumerator.Reset();
        /*0x9f1ae8*/ object System.Collections.IEnumerator.get_Current();
    }
}

class ui_global_tab : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Transform parent_page;
    /*0x20*/ UnityEngine.Transform parent_button;
    /*0x28*/ bool allowSwitchOff;
    /*0x30*/ System.Collections.Generic.List<UnityEngine.GameObject> _tab_pages;
    /*0x38*/ System.Collections.Generic.List<ui_button_selectable> _tabs_buttons;

    /*0x9f2294*/ ui_global_tab();
    /*0x9f1af0*/ System.Collections.Generic.List<UnityEngine.GameObject> get_tab_pages();
    /*0x9f1e64*/ System.Collections.Generic.List<ui_button_selectable> get_tab_buttons();
    /*0x9f1ef4*/ int get_page_opened();
    /*0x9f1fa4*/ int get_element_num();
    /*0x9f2014*/ void Awake();
    /*0x9f20f4*/ void Open_Page(int no);
    /*0x9f2028*/ void Close_All();
}

class ui_ImgTextPair : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text;
    /*0x20*/ UnityEngine.UI.Image img;

    /*0x9f23a4*/ ui_ImgTextPair();
    /*0x9f2354*/ void Refresh(UnityEngine.Sprite img, string text);
}

class ui_isParallel : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Image _img_parallel;

    /*0x9f2700*/ ui_isParallel();
    /*0x9f23ac*/ UnityEngine.UI.Image get_img_parallel();
    /*0x9f2440*/ void OnEnable();
    /*0x9f2570*/ void OnDisable();
    /*0x9f2628*/ void Refresh_UI();
}

class ui_language_text : UnityEngine.MonoBehaviour
{
    /*0x18*/ string code;
    /*0x20*/ GarlicText.UI.HyperText _text;

    /*0x9f29e4*/ ui_language_text();
    /*0x9f2708*/ GarlicText.UI.HyperText get_text();
    /*0x9f279c*/ void OnEnable();
    /*0x9f292c*/ void OnDisable();
    /*0x9f28a0*/ void Refresh_UI();
}

class ui_tab : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.Transform parent_page;
    /*0x20*/ UnityEngine.Transform parent_button;
    /*0x28*/ bool allowSwitchOff;
    /*0x30*/ System.Collections.Generic.List<UnityEngine.GameObject> _tab_pages;
    /*0x38*/ System.Collections.Generic.List<UnityEngine.UI.Button> _tabs_buttons;
    /*0x40*/ int page_now;

    /*0x9f2fe8*/ ui_tab();
    /*0x9f29ec*/ System.Collections.Generic.List<UnityEngine.GameObject> get_tab_pages();
    /*0x9f2d60*/ System.Collections.Generic.List<UnityEngine.UI.Button> get_tab_buttons();
    /*0x9f2df4*/ int get_element_num();
    /*0x9f2e64*/ void Awake();
    /*0x9f2e78*/ void Open_Page(int no);
    /*0x9f2e70*/ void Close_All();
}

class ui_tutorial : UnityEngine.MonoBehaviour
{
    /*0x18*/ data_tutorial_element tutorial;

    /*0x9f3120*/ ui_tutorial();
    /*0x9f30a8*/ void OnClick();
}

class ui_version : UnityEngine.MonoBehaviour
{
    /*0x18*/ GarlicText.UI.HyperText text_version;

    /*0x9f31d4*/ ui_version();
    /*0x9f3128*/ void Start();
}

class ui_warning : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject Panel;
    /*0x20*/ UnityEngine.GameObject button_agree;
    /*0x28*/ UnityEngine.GameObject button_next;
    /*0x30*/ GarlicText.UI.HyperText text_info;
    /*0x38*/ GarlicText.UI.HyperText text_agree;
    /*0x40*/ GarlicText.UI.HyperText text_cancel;
    /*0x48*/ GarlicText.UI.HyperText text_next;
    /*0x50*/ bool CanClose;
    /*0x58*/ System.Collections.Generic.List<ui_warning_element> list_actions;

    /*0x9f36fc*/ ui_warning();
    /*0x9f31dc*/ bool get_isOpened();
    /*0x9f31f8*/ void Add(string info, string agree, System.Action event_agree, object[] options);
    /*0x9e9dd4*/ void Add(string info, string agree, string cancel, System.Action event_agree, object[] options);
    /*0x9f327c*/ void Add(string info, string agree, string cancel, System.Action event_agree, System.Action event_cancel, object[] options);
    /*0x9f344c*/ void Play();
    /*0x9f352c*/ void Agree();
    /*0x9f3608*/ void Close();

    class <>c__DisplayClass13_0
    {
        /*0x10*/ ui_warning <>4__this;
        /*0x18*/ string info;
        /*0x20*/ object[] options;
        /*0x28*/ string cancel;
        /*0x30*/ string agree;

        /*0x9f3408*/ <>c__DisplayClass13_0();
        /*0x9f3778*/ void <Add>b__0();
    }
}

class ui_warning_element
{
    /*0x10*/ System.Action event_warning;
    /*0x18*/ System.Action event_agree;
    /*0x20*/ System.Action event_cancel;

    /*0x9f3410*/ ui_warning_element(System.Action event_warning, System.Action event_agree, System.Action event_cancel);
    /*0x9f3510*/ void Play();
    /*0x9f35ec*/ void Agree();
    /*0x9f36e0*/ void Close();
}

class UI_Test : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.UI.Button but;

    /*0x9f3a38*/ UI_Test();
    /*0x9f3968*/ void OnClick();
    /*0x9f39d0*/ void OnPressing();
}

class madsample : UnityEngine.MonoBehaviour
{
    /*0x18*/ string string_prefix;
    /*0x20*/ string[] _permissionNames;
    /*0x28*/ NotiPopup panel_notipopup;
    /*0x30*/ UnityEngine.TextAsset textasset_lang;
    /*0x38*/ SimpleJSON_Ex.JSONNode json_lang;

    /*0x9f5254*/ madsample();
    /*0x9f3a40*/ string get_lang_now();
    /*0x9f3ac8*/ string Get_Lang(string code);
    /*0x9f3c04*/ void Start();
    /*0x9f4374*/ void requestPermission();
    /*0x9f445c*/ System.Collections.Generic.List<string> checkPermission(string[] permissionNames);
    /*0x9f4708*/ System.Collections.Generic.List<string> getNeedDescriptionPermission(System.Collections.Generic.List<string> requestPermissionNames);
    /*0x9f4d68*/ void requestPermission(System.Collections.Generic.List<string> requestPermissionNames);
    /*0x9f4650*/ void onRequestPermissionResult(bool success, string[] failPermission);
    /*0x9f4a14*/ void showPermissionDescription(System.Collections.Generic.List<string> needPermission);
    /*0x9f5068*/ void showGameNotiQuit();

    class <>c__DisplayClass14_0
    {
        /*0x10*/ madsample <>4__this;
        /*0x18*/ System.Collections.Generic.List<string> needPermission;

        /*0x9f51d0*/ <>c__DisplayClass14_0();
        /*0x9f5328*/ void <showPermissionDescription>b__0();
    }

    class <>c
    {
        static /*0x0*/ madsample.<> <>9;
        static /*0x8*/ System.Action <>9__15_0;

        static /*0x9f5348*/ <>c();
        /*0x9f53ac*/ <>c();
        /*0x9f53b4*/ void <showGameNotiQuit>b__15_0();
    }
}

class NotiPopup : UnityEngine.MonoBehaviour
{
    /*0x18*/ UnityEngine.GameObject panel;
    /*0x20*/ UnityEngine.UI.Text text_info;
    /*0x28*/ UnityEngine.UI.Text text_button;
    /*0x30*/ System.Action result;

    /*0x9f5424*/ NotiPopup();
    /*0x9f53bc*/ void Awake();
    /*0x9f51d8*/ void Open(string text_info, string text_button, System.Action reseult);
    /*0x9f53dc*/ void OnClick_Yes();
}

namespace SimpleJSON_Ex
{
    enum JSONBinaryTag
    {
        Array = 1,
        Class = 2,
        Value = 3,
        IntValue = 4,
        DoubleValue = 5,
        BoolValue = 6,
        FloatValue = 7,
    }

    class JSONNode
    {
        static /*0x9f5c68*/ SimpleJSON_Ex.JSONNode op_Implicit(string s);
        static /*0x9f5cf4*/ string op_Implicit(SimpleJSON_Ex.JSONNode d);
        static /*0x9f3b7c*/ bool op_Equality(SimpleJSON_Ex.JSONNode a, object b);
        static /*0x9f5d30*/ bool op_Inequality(SimpleJSON_Ex.JSONNode a, object b);
        static /*0x9f5d5c*/ string Escape(string aText);
        static /*0x9f3c4c*/ SimpleJSON_Ex.JSONNode Parse(string aJSON);
        static /*0x9f6564*/ SimpleJSON_Ex.JSONNode Deserialize(System.IO.BinaryReader aReader);
        static /*0x9f69d4*/ SimpleJSON_Ex.JSONNode LoadFromCompressedFile(string aFileName);
        static /*0x9f6a24*/ SimpleJSON_Ex.JSONNode LoadFromCompressedStream(System.IO.Stream aData);
        static /*0x9f6a74*/ SimpleJSON_Ex.JSONNode LoadFromCompressedBase64(string aBase64);
        static /*0x9f6ac4*/ SimpleJSON_Ex.JSONNode LoadFromStream(System.IO.Stream aData);
        static /*0x9f6c58*/ SimpleJSON_Ex.JSONNode LoadFromFile(string aFileName);
        static /*0x9f6dd4*/ SimpleJSON_Ex.JSONNode LoadFromBase64(string aBase64);
        /*0x9f6e88*/ JSONNode();
        /*0x9f542c*/ System.Collections.Generic.IEnumerable<string> get_Keys();
        /*0x9f54d0*/ void Add(string aKey, SimpleJSON_Ex.JSONNode aItem);
        /*0x9f54d4*/ SimpleJSON_Ex.JSONNode get_Item(int aIndex);
        /*0x9f54dc*/ void set_Item(int aIndex, SimpleJSON_Ex.JSONNode value);
        /*0x9f54e0*/ SimpleJSON_Ex.JSONNode get_Item(string aKey);
        /*0x9f54e8*/ void set_Item(string aKey, SimpleJSON_Ex.JSONNode value);
        /*0x9f54ec*/ string get_Value();
        /*0x9f552c*/ void set_Value(string value);
        /*0x9f5530*/ int get_Count();
        /*0x9f5538*/ void Add(SimpleJSON_Ex.JSONNode aItem);
        /*0x9f5598*/ SimpleJSON_Ex.JSONNode Remove(string aKey);
        /*0x9f55a0*/ SimpleJSON_Ex.JSONNode Remove(int aIndex);
        /*0x9f55a8*/ SimpleJSON_Ex.JSONNode Remove(SimpleJSON_Ex.JSONNode aNode);
        /*0x9f55b0*/ System.Collections.Generic.IEnumerable<SimpleJSON_Ex.JSONNode> get_Childs();
        /*0x9f5654*/ System.Collections.Generic.IEnumerable<SimpleJSON_Ex.JSONNode> get_DeepChilds();
        /*0x9f5700*/ string ToString();
        /*0x9f5740*/ string ToString(string aPrefix);
        /*0x9f5780*/ int get_AsInt();
        /*0x9f57b4*/ void set_AsInt(int value);
        /*0x9f57f0*/ float get_AsFloat();
        /*0x9f5894*/ void set_AsFloat(float value);
        /*0x9f591c*/ double get_AsDouble();
        /*0x9f59c0*/ void set_AsDouble(double value);
        /*0x9f5a48*/ bool get_AsBool();
        /*0x9f5b00*/ void set_AsBool(bool value);
        /*0x9f5b78*/ SimpleJSON_Ex.JSONArray get_AsArray();
        /*0x9f5bf0*/ SimpleJSON_Ex.JSONClass get_AsObject();
        /*0x9f5d48*/ bool Equals(object obj);
        /*0x9f5d54*/ int GetHashCode();
        /*0x9f6020*/ void Serialize(System.IO.BinaryWriter aWriter);
        /*0x9f6024*/ void SaveToStream(System.IO.Stream aData);
        /*0x9f60a4*/ void SaveToCompressedStream(System.IO.Stream aData);
        /*0x9f60f4*/ void SaveToCompressedFile(string aFileName);
        /*0x9f6144*/ string SaveToCompressedBase64();
        /*0x9f6194*/ void SaveToFile(string aFileName);
        /*0x9f6364*/ string SaveToBase64();

        class <get_Keys>d__1 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ string <>2__current;
            /*0x20*/ int <>l__initialThreadId;

            /*0x9f549c*/ <get_Keys>d__1(int <>1__state);
            /*0x9f6e90*/ void System.IDisposable.Dispose();
            /*0x9f6e94*/ bool MoveNext();
            /*0x9f6eac*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
            /*0x9f6eb4*/ void System.Collections.IEnumerator.Reset();
            /*0x9f6ef4*/ object System.Collections.IEnumerator.get_Current();
            /*0x9f6efc*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
            /*0x9f6f94*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <get_Childs>d__19 : System.Collections.Generic.IEnumerable<SimpleJSON_Ex.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON_Ex.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ SimpleJSON_Ex.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;

            /*0x9f5620*/ <get_Childs>d__19(int <>1__state);
            /*0x9f6f98*/ void System.IDisposable.Dispose();
            /*0x9f6f9c*/ bool MoveNext();
            /*0x9f6fb4*/ SimpleJSON_Ex.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON_Ex.JSONNode>.get_Current();
            /*0x9f6fbc*/ void System.Collections.IEnumerator.Reset();
            /*0x9f6ffc*/ object System.Collections.IEnumerator.get_Current();
            /*0x9f7004*/ System.Collections.Generic.IEnumerator<SimpleJSON_Ex.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON_Ex.JSONNode>.GetEnumerator();
            /*0x9f709c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <get_DeepChilds>d__21 : System.Collections.Generic.IEnumerable<SimpleJSON_Ex.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON_Ex.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ SimpleJSON_Ex.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ SimpleJSON_Ex.JSONNode <>4__this;
            /*0x30*/ System.Collections.Generic.IEnumerator<SimpleJSON_Ex.JSONNode> <>7__wrap1;
            /*0x38*/ System.Collections.Generic.IEnumerator<SimpleJSON_Ex.JSONNode> <>7__wrap2;

            /*0x9f56cc*/ <get_DeepChilds>d__21(int <>1__state);
            /*0x9f70a0*/ void System.IDisposable.Dispose();
            /*0x9f7158*/ bool MoveNext();
            /*0x9f763c*/ void <>m__Finally1();
            /*0x9f758c*/ void <>m__Finally2();
            /*0x9f76ec*/ SimpleJSON_Ex.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON_Ex.JSONNode>.get_Current();
            /*0x9f76f4*/ void System.Collections.IEnumerator.Reset();
            /*0x9f7734*/ object System.Collections.IEnumerator.get_Current();
            /*0x9f773c*/ System.Collections.Generic.IEnumerator<SimpleJSON_Ex.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON_Ex.JSONNode>.GetEnumerator();
            /*0x9f77e0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }
    }

    class JSONArray : SimpleJSON_Ex.JSONNode, System.Collections.IEnumerable
    {
        /*0x10*/ System.Collections.Generic.List<SimpleJSON_Ex.JSONNode> m_List;

        /*0x9f5fa4*/ JSONArray();
        /*0x9f77e4*/ SimpleJSON_Ex.JSONNode get_Item(int aIndex);
        /*0x9f78c0*/ void set_Item(int aIndex, SimpleJSON_Ex.JSONNode value);
        /*0x9f79c8*/ SimpleJSON_Ex.JSONNode get_Item(string aKey);
        /*0x9f7a2c*/ void set_Item(string aKey, SimpleJSON_Ex.JSONNode value);
        /*0x9f7ad4*/ int get_Count();
        /*0x9f7b1c*/ void Add(string aKey, SimpleJSON_Ex.JSONNode aItem);
        /*0x9f7bc4*/ SimpleJSON_Ex.JSONNode Remove(int aIndex);
        /*0x9f7c78*/ SimpleJSON_Ex.JSONNode Remove(SimpleJSON_Ex.JSONNode aNode);
        /*0x9f7cd8*/ System.Collections.Generic.IEnumerable<SimpleJSON_Ex.JSONNode> get_Childs();
        /*0x9f7d84*/ System.Collections.IEnumerator GetEnumerator();
        /*0x9f7e14*/ string ToString();
        /*0x9f802c*/ string ToString(string aPrefix);
        /*0x9f82ac*/ void Serialize(System.IO.BinaryWriter aWriter);

        class <get_Childs>d__13 : System.Collections.Generic.IEnumerable<SimpleJSON_Ex.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON_Ex.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ SimpleJSON_Ex.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ SimpleJSON_Ex.JSONArray <>4__this;
            /*0x30*/ System.Collections.Generic.List.Enumerator<SimpleJSON_Ex.JSONNode> <>7__wrap1;

            /*0x9f7d50*/ <get_Childs>d__13(int <>1__state);
            /*0x9f8388*/ void System.IDisposable.Dispose();
            /*0x9f83a4*/ bool MoveNext();
            /*0x9f8538*/ void <>m__Finally1();
            /*0x9f8588*/ SimpleJSON_Ex.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON_Ex.JSONNode>.get_Current();
            /*0x9f8590*/ void System.Collections.IEnumerator.Reset();
            /*0x9f85d0*/ object System.Collections.IEnumerator.get_Current();
            /*0x9f85d8*/ System.Collections.Generic.IEnumerator<SimpleJSON_Ex.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON_Ex.JSONNode>.GetEnumerator();
            /*0x9f867c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <GetEnumerator>d__14 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ SimpleJSON_Ex.JSONArray <>4__this;
            /*0x28*/ System.Collections.Generic.List.Enumerator<SimpleJSON_Ex.JSONNode> <>7__wrap1;

            /*0x9f7dec*/ <GetEnumerator>d__14(int <>1__state);
            /*0x9f8680*/ void System.IDisposable.Dispose();
            /*0x9f869c*/ bool MoveNext();
            /*0x9f8830*/ void <>m__Finally1();
            /*0x9f8880*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x9f8888*/ void System.Collections.IEnumerator.Reset();
            /*0x9f88c8*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class JSONClass : SimpleJSON_Ex.JSONNode, System.Collections.IEnumerable
    {
        /*0x10*/ System.Collections.Generic.Dictionary<string, SimpleJSON_Ex.JSONNode> m_Dict;

        /*0x9f5f28*/ JSONClass();
        /*0x9f88d0*/ System.Collections.Generic.IEnumerable<string> get_Keys();
        /*0x9f897c*/ SimpleJSON_Ex.JSONNode get_Item(string aKey);
        /*0x9f8a6c*/ void set_Item(string aKey, SimpleJSON_Ex.JSONNode value);
        /*0x9f8b38*/ SimpleJSON_Ex.JSONNode get_Item(int aIndex);
        /*0x9f8bd8*/ void set_Item(int aIndex, SimpleJSON_Ex.JSONNode value);
        /*0x9f8cb4*/ int get_Count();
        /*0x9f8d04*/ void Add(string aKey, SimpleJSON_Ex.JSONNode aItem);
        /*0x9f8e18*/ SimpleJSON_Ex.JSONNode Remove(string aKey);
        /*0x9f8edc*/ SimpleJSON_Ex.JSONNode Remove(int aIndex);
        /*0x9f8fb8*/ SimpleJSON_Ex.JSONNode Remove(SimpleJSON_Ex.JSONNode aNode);
        /*0x9f9180*/ System.Collections.Generic.IEnumerable<SimpleJSON_Ex.JSONNode> get_Childs();
        /*0x9f922c*/ System.Collections.IEnumerator GetEnumerator();
        /*0x9f92bc*/ string ToString();
        /*0x9f96a4*/ string ToString(string aPrefix);
        /*0x9f9b10*/ void Serialize(System.IO.BinaryWriter aWriter);

        class <get_Keys>d__1 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ string <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ SimpleJSON_Ex.JSONClass <>4__this;
            /*0x30*/ System.Collections.Generic.Dictionary.KeyCollection.Enumerator<string, SimpleJSON_Ex.JSONNode> <>7__wrap1;

            /*0x9f8948*/ <get_Keys>d__1(int <>1__state);
            /*0x9f9d30*/ void System.IDisposable.Dispose();
            /*0x9f9d4c*/ bool MoveNext();
            /*0x9f9f08*/ void <>m__Finally1();
            /*0x9f9f58*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
            /*0x9f9f60*/ void System.Collections.IEnumerator.Reset();
            /*0x9f9fa0*/ object System.Collections.IEnumerator.get_Current();
            /*0x9f9fa8*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
            /*0x9fa04c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <>c__DisplayClass14_0
        {
            /*0x10*/ SimpleJSON_Ex.JSONNode aNode;

            /*0x9f9178*/ <>c__DisplayClass14_0();
            /*0x9fa050*/ bool <Remove>b__0(System.Collections.Generic.KeyValuePair<string, SimpleJSON_Ex.JSONNode> k);
        }

        class <get_Childs>d__16 : System.Collections.Generic.IEnumerable<SimpleJSON_Ex.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON_Ex.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ SimpleJSON_Ex.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ SimpleJSON_Ex.JSONClass <>4__this;
            /*0x30*/ System.Collections.Generic.Dictionary.Enumerator<string, SimpleJSON_Ex.JSONNode> <>7__wrap1;

            /*0x9f91f8*/ <get_Childs>d__16(int <>1__state);
            /*0x9fa094*/ void System.IDisposable.Dispose();
            /*0x9fa0b0*/ bool MoveNext();
            /*0x9fa258*/ void <>m__Finally1();
            /*0x9fa2a8*/ SimpleJSON_Ex.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON_Ex.JSONNode>.get_Current();
            /*0x9fa2b0*/ void System.Collections.IEnumerator.Reset();
            /*0x9fa2f0*/ object System.Collections.IEnumerator.get_Current();
            /*0x9fa2f8*/ System.Collections.Generic.IEnumerator<SimpleJSON_Ex.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON_Ex.JSONNode>.GetEnumerator();
            /*0x9fa39c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <GetEnumerator>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ SimpleJSON_Ex.JSONClass <>4__this;
            /*0x28*/ System.Collections.Generic.Dictionary.Enumerator<string, SimpleJSON_Ex.JSONNode> <>7__wrap1;

            /*0x9f9294*/ <GetEnumerator>d__17(int <>1__state);
            /*0x9fa3a0*/ void System.IDisposable.Dispose();
            /*0x9fa3bc*/ bool MoveNext();
            /*0x9fa590*/ void <>m__Finally1();
            /*0x9fa5e0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x9fa5e8*/ void System.Collections.IEnumerator.Reset();
            /*0x9fa628*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class JSONData : SimpleJSON_Ex.JSONNode
    {
        /*0x10*/ string m_Data;

        /*0x9f5ccc*/ JSONData(string aData);
        /*0x9f699c*/ JSONData(float aData);
        /*0x9f692c*/ JSONData(double aData);
        /*0x9f6964*/ JSONData(bool aData);
        /*0x9f68f4*/ JSONData(int aData);
        /*0x9fa630*/ string get_Value();
        /*0x9fa638*/ void set_Value(string value);
        /*0x9fa640*/ string ToString();
        /*0x9fa698*/ string ToString(string aPrefix);
        /*0x9fa6f0*/ void Serialize(System.IO.BinaryWriter aWriter);
    }

    class JSONLazyCreator : SimpleJSON_Ex.JSONNode
    {
        /*0x10*/ SimpleJSON_Ex.JSONNode m_Node;
        /*0x18*/ string m_Key;

        static /*0x9facf4*/ bool op_Equality(SimpleJSON_Ex.JSONLazyCreator a, object b);
        static /*0x9fad0c*/ bool op_Inequality(SimpleJSON_Ex.JSONLazyCreator a, object b);
        /*0x9f7898*/ JSONLazyCreator(SimpleJSON_Ex.JSONNode aNode);
        /*0x9f8a40*/ JSONLazyCreator(SimpleJSON_Ex.JSONNode aNode, string aKey);
        /*0x9fa9b0*/ void Set(SimpleJSON_Ex.JSONNode aVal);
        /*0x9faa08*/ SimpleJSON_Ex.JSONNode get_Item(int aIndex);
        /*0x9faa6c*/ void set_Item(int aIndex, SimpleJSON_Ex.JSONNode value);
        /*0x9faaf0*/ SimpleJSON_Ex.JSONNode get_Item(string aKey);
        /*0x9fab60*/ void set_Item(string aKey, SimpleJSON_Ex.JSONNode value);
        /*0x9fabe8*/ void Add(SimpleJSON_Ex.JSONNode aItem);
        /*0x9fac6c*/ void Add(string aKey, SimpleJSON_Ex.JSONNode aItem);
        /*0x9fad24*/ bool Equals(object obj);
        /*0x9fad3c*/ int GetHashCode();
        /*0x9fad44*/ string ToString();
        /*0x9fad84*/ string ToString(string aPrefix);
        /*0x9fadc4*/ int get_AsInt();
        /*0x9fae48*/ void set_AsInt(int value);
        /*0x9faed0*/ float get_AsFloat();
        /*0x9faf54*/ void set_AsFloat(float value);
        /*0x9fafdc*/ double get_AsDouble();
        /*0x9fb060*/ void set_AsDouble(double value);
        /*0x9fb0e8*/ bool get_AsBool();
        /*0x9fb16c*/ void set_AsBool(bool value);
        /*0x9fb1f4*/ SimpleJSON_Ex.JSONArray get_AsArray();
        /*0x9fb25c*/ SimpleJSON_Ex.JSONClass get_AsObject();
    }

    class JSON
    {
        static /*0x9fb2c4*/ SimpleJSON_Ex.JSONNode Parse(string aJSON);
    }
}

namespace MadUtil
{
    class MadCrypt
    {
        static int HMAC_SIZE = 32;

        static /*0x9fb2c8*/ string AESEncrypt256(string Input, string key, int ivSize);
        static /*0x9fb9b0*/ string AESDecrypt256(string Input, string key, int ivSize);
        static /*0x9fb8bc*/ void setRandIV(byte[] arrIV);
        static /*0x9fb834*/ byte[] getSha256Hash(string pw);
        static /*0x9fb928*/ byte[] GenerateNewHMAC(string pw, byte[] challenge);
        static /*0x9fbf30*/ bool checkHmac(byte[] hmac, byte[] checkHmac);
        static /*0x9fbf9c*/ string Base64Encoding(string EncodingText, System.Text.Encoding oEncoding);
        static /*0x9fc030*/ string Base64Decoding(string DecodingText, System.Text.Encoding oEncoding);
        /*0x9fc0bc*/ MadCrypt();
    }
}

namespace Ex
{
    class Extentions
    {
        static /*0x9fc0c4*/ System.DateTime RoundUp(System.DateTime dt, System.TimeSpan d);
        static /*0x9fc138*/ System.DateTime RoundDown(System.DateTime dt, System.TimeSpan d);
        static /*0x9fc1b0*/ System.DateTime RoundToNearest(System.DateTime dt, System.TimeSpan d);
    }

    class RandomTools
    {
        static /*0x0*/ System.Random Rand;

        static /*0x9fc2d0*/ RandomTools();
        static System.Collections.Generic.List<T> Pick<T>(System.Collections.Generic.List<T> values, int num_values);
        static System.Collections.Generic.List<T> Shuffle<T>(System.Collections.Generic.List<T> sequence);
        static /*0x9fc234*/ char AtoZ();
    }
}

namespace Mad
{
    class DsHttpsObject : UnityEngine.MonoBehaviour, System.IDisposable
    {
        static int _ivSize = 32;
        static string DAERI_FUNCNAME_KEY = "dsFuncName";
        static /*0x0*/ Mad.DsHttpsObject.ResponseDelegate OnResponse;
        static /*0x8*/ Mad.DsHttpsObject _instance;
        static /*0x10*/ UnityEngine.GameObject container;
        static /*0x18*/ object _requestLock;
        static /*0x20*/ object _responseLock;
        /*0x18*/ string _reqUrl;
        /*0x20*/ string _serviceName;
        /*0x28*/ string _daeriKey;
        /*0x30*/ System.Text.StringBuilder reqStr;
        /*0x38*/ int _requestId;
        /*0x3c*/ float _requestTermTime;
        /*0x40*/ System.Collections.Generic.List<Mad.DsHttpsObject.RequestInfo> _requestInfo;
        /*0x48*/ System.Collections.Generic.List<Mad.DsHttpsObject.RequestInfo> _responseInfo;
        /*0x50*/ byte[] _tempBuffer;
        /*0x58*/ bool _isThreadStop;
        /*0x60*/ System.Threading.Thread _asyncThread;

        static /*0x9fe204*/ DsHttpsObject();
        static /*0x9fc370*/ Mad.DsHttpsObject get_Instance();
        /*0x9fe130*/ DsHttpsObject();
        /*0x9fc348*/ int get_requestId();
        /*0x9fc360*/ float get_requestTermTime();
        /*0x9fc368*/ void set_requestTermTime(float value);
        /*0x9fc690*/ void init();
        /*0x9fc9f8*/ void Dispose();
        /*0x9fca64*/ System.Net.HttpWebRequest getRequest();
        /*0x9fcb70*/ int post(string dsFuncName, string reqPlainData, Mad.DsHttpsObject.ResponseDelegate responseDelegate);
        /*0x9fc7c8*/ void initRequestInfo();
        /*0x9fcb74*/ int addRequest(string functionName, string reqPlainData, Mad.DsHttpsObject.ResponseDelegate resDelegate);
        /*0x9fd030*/ Mad.DsHttpsObject.RequestInfo getRequestInfo();
        /*0x9fd1e4*/ bool hasRequestData();
        /*0x9fce58*/ bool hasRequestWithId(int id);
        /*0x9fc83c*/ void initResponseInfo();
        /*0x9fd324*/ bool addResponse(Mad.DsHttpsObject.RequestInfo resInfo);
        /*0x9fd4a4*/ Mad.DsHttpsObject.RequestInfo getResponseInfo();
        /*0x9fd658*/ bool hasResponseData();
        /*0x9fd6a8*/ bool hasResponseInfoWithId(int id);
        /*0x9fc990*/ System.Collections.IEnumerator onMainThreadWork();
        /*0x9fc8b0*/ void initAsyncThread();
        /*0x9fc9fc*/ void stopAsyncThread();
        /*0x9fd7b4*/ void onAsyncWork();
        /*0x9fd834*/ void requestProc(Mad.DsHttpsObject.RequestInfo reqInfo);
        /*0x9fdf0c*/ byte[] getRequestPostData(Mad.DsHttpsObject.RequestInfo reqInfo);
        /*0x9fe0bc*/ string getResponseData(string resCryptedData);

        class ResponseDelegate : System.MulticastDelegate
        {
            /*0x9fe2b8*/ ResponseDelegate(object object, nint method);
            /*0x9fe37c*/ void Invoke(int id, string resData);
            /*0x9fe390*/ System.IAsyncResult BeginInvoke(int id, string resData, System.AsyncCallback callback, object object);
            /*0x9fe420*/ void EndInvoke(System.IAsyncResult result);
        }

        class RequestInfo : System.IDisposable
        {
            /*0x10*/ int id;
            /*0x18*/ string reqData;
            /*0x20*/ string resData;
            /*0x28*/ Mad.DsHttpsObject.ResponseDelegate resDelegate;
            /*0x30*/ System.Collections.Generic.Dictionary<string, string> reqAddInfo;

            /*0x9fcf34*/ RequestInfo(int id, string reqData, string resData, Mad.DsHttpsObject.ResponseDelegate resDelegate);
            /*0x9fd234*/ RequestInfo(Mad.DsHttpsObject.RequestInfo reqInfo);
            /*0x9fcf80*/ void addRequestAddInfo(string key, string info);
            /*0x9fe42c*/ void removeRequestAddInfo(string key);
            /*0x9fe0d0*/ string getRequestAddInfo(string key);
            /*0x9fe4bc*/ void Dispose();
        }

        class <>c
        {
            static /*0x0*/ Mad.DsHttpsObject.<> <>9;
            static /*0x8*/ System.Net.Security.RemoteCertificateValidationCallback <>9__19_0;

            static /*0x9fe514*/ <>c();
            /*0x9fe578*/ <>c();
            /*0x9fe580*/ bool <init>b__19_0(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
        }

        class <>c__DisplayClass30_0
        {
            /*0x10*/ int id;

            /*0x9fd31c*/ <>c__DisplayClass30_0();
            /*0x9fe588*/ bool <hasRequestWithId>b__0(Mad.DsHttpsObject.RequestInfo x);
        }

        class <>c__DisplayClass37_0
        {
            /*0x10*/ int id;

            /*0x9fd784*/ <>c__DisplayClass37_0();
            /*0x9fe5ac*/ bool <hasResponseInfoWithId>b__0(Mad.DsHttpsObject.RequestInfo x);
        }

        class <onMainThreadWork>d__38 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Mad.DsHttpsObject <>4__this;

            /*0x9fd78c*/ <onMainThreadWork>d__38(int <>1__state);
            /*0x9fe5d0*/ void System.IDisposable.Dispose();
            /*0x9fe5d4*/ bool MoveNext();
            /*0x9fe7c0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x9fe7c8*/ void System.Collections.IEnumerator.Reset();
            /*0x9fe808*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class MadHttpsObject : UnityEngine.MonoBehaviour, System.IDisposable
    {
        static /*0x0*/ Mad.MadHttpsObject.ResponseDelegate OnResponse;
        static /*0x8*/ Mad.MadHttpsObject _instance;
        static /*0x10*/ UnityEngine.GameObject container;
        static /*0x18*/ object _requestLock;
        static /*0x20*/ object _responseLock;
        /*0x18*/ int _requestId;
        /*0x1c*/ float _requestTermTime;
        /*0x20*/ System.Collections.Generic.List<Mad.MadHttpsObject.RequestInfo> _requestInfo;
        /*0x28*/ System.Collections.Generic.List<Mad.MadHttpsObject.RequestInfo> _responseInfo;
        /*0x30*/ byte[] _tempBuffer;
        /*0x38*/ bool _isThreadStop;
        /*0x40*/ System.Threading.Thread _asyncThread;

        static /*0xa0085c*/ MadHttpsObject();
        static /*0x9fe838*/ Mad.MadHttpsObject get_Instance();
        /*0xa0084c*/ MadHttpsObject();
        /*0x9fe810*/ int get_requestId();
        /*0x9fe828*/ float get_requestTermTime();
        /*0x9fe830*/ void set_requestTermTime(float value);
        /*0x9feb58*/ void init();
        /*0x9feec0*/ void Dispose();
        /*0x9fef2c*/ System.Net.HttpWebRequest getPostRequest(string url);
        /*0x9ff124*/ System.Net.HttpWebRequest getGetRequest(string url);
        /*0x9ff31c*/ int post(string url, string reqData, Mad.MadHttpsObject.ResponseDelegate responseDelegate);
        /*0x9ff5e0*/ int get(string url, Mad.MadHttpsObject.ResponseDelegate responseDelegate);
        /*0x9fec90*/ void initRequestInfo();
        /*0x9ff320*/ int addRequest(string url, string reqData, Mad.MadHttpsObject.ResponseDelegate resDelegate);
        /*0x9ff5e4*/ int addRequest(string url, Mad.MadHttpsObject.ResponseDelegate resDelegate);
        /*0x9ff974*/ Mad.MadHttpsObject.RequestInfo getRequestInfo();
        /*0x9ffb2c*/ bool hasRequestData();
        /*0x9ff898*/ bool hasRequestWithId(int id);
        /*0x9fed04*/ void initResponseInfo();
        /*0x9ffb7c*/ bool addResponse(Mad.MadHttpsObject.RequestInfo resInfo);
        /*0x9ffcfc*/ Mad.MadHttpsObject.RequestInfo getResponseInfo();
        /*0x9ffeb4*/ bool hasResponseData();
        /*0x9fff04*/ bool hasResponseInfoWithId(int id);
        /*0x9fee58*/ System.Collections.IEnumerator onMainThreadWork();
        /*0x9fed78*/ void initAsyncThread();
        /*0x9feec4*/ void stopAsyncThread();
        /*0x9fffe0*/ void onAsyncWork();
        /*0xa00060*/ void requestProc(Mad.MadHttpsObject.RequestInfo reqInfo);
        /*0xa00708*/ System.Net.HttpWebRequest buildWebRequest(Mad.MadHttpsObject.RequestInfo reqInfo);

        class ResponseDelegate : System.MulticastDelegate
        {
            /*0xead4e8*/ ResponseDelegate(object object, nint method);
            /*0xead5ac*/ void Invoke(int id, int responseStatusCode, string resData);
            /*0xead5c0*/ System.IAsyncResult BeginInvoke(int id, int responseStatusCode, string resData, System.AsyncCallback callback, object object);
            /*0xead664*/ void EndInvoke(System.IAsyncResult result);
        }

        class RequestInfo : System.IDisposable
        {
            /*0x10*/ string target_url;
            /*0x18*/ int id;
            /*0x1c*/ int responseStatusCode;
            /*0x20*/ string reqData;
            /*0x28*/ string resData;
            /*0x30*/ string error_msg;
            /*0x38*/ Mad.MadHttpsObject.ResponseDelegate resDelegate;
            /*0x40*/ Mad.MadHttpsObject.RequestInfo.HTTPMethod method;

            /*0xead670*/ RequestInfo(int id, string target_url, string reqData, string resData, Mad.MadHttpsObject.RequestInfo.HTTPMethod method, Mad.MadHttpsObject.ResponseDelegate resDelegate);
            /*0xead6d4*/ RequestInfo(Mad.MadHttpsObject.RequestInfo reqInfo);
            /*0xead750*/ void Dispose();

            enum HTTPMethod
            {
                POST = 0,
                GET = 1,
            }
        }

        class <>c
        {
            static /*0x0*/ Mad.MadHttpsObject.<> <>9;
            static /*0x8*/ System.Net.Security.RemoteCertificateValidationCallback <>9__13_0;
            static /*0x10*/ System.Net.Security.RemoteCertificateValidationCallback <>9__15_0;
            static /*0x18*/ System.Net.Security.RemoteCertificateValidationCallback <>9__16_0;

            static /*0xead758*/ <>c();
            /*0xead7bc*/ <>c();
            /*0xead7c4*/ bool <init>b__13_0(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
            /*0xead7cc*/ bool <getPostRequest>b__15_0(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
            /*0xead7d4*/ bool <getGetRequest>b__16_0(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors);
        }

        class <>c__DisplayClass27_0
        {
            /*0x10*/ int id;

            /*0xead7dc*/ <>c__DisplayClass27_0();
            /*0xead7e4*/ bool <hasRequestWithId>b__0(Mad.MadHttpsObject.RequestInfo x);
        }

        class <>c__DisplayClass34_0
        {
            /*0x10*/ int id;

            /*0xead808*/ <>c__DisplayClass34_0();
            /*0xead810*/ bool <hasResponseInfoWithId>b__0(Mad.MadHttpsObject.RequestInfo x);
        }

        class <onMainThreadWork>d__35 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ Mad.MadHttpsObject <>4__this;

            /*0xead834*/ <onMainThreadWork>d__35(int <>1__state);
            /*0xead85c*/ void System.IDisposable.Dispose();
            /*0xead860*/ bool MoveNext();
            /*0xeada50*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0xeada58*/ void System.Collections.IEnumerator.Reset();
            /*0xeada98*/ object System.Collections.IEnumerator.get_Current();
        }
    }
}

namespace ScottGarland
{
    class DigitsArray
    {
        static /*0x0*/ uint AllBits;
        static /*0x4*/ uint HiBitSet;
        /*0x10*/ uint[] m_data;
        /*0x18*/ int m_dataUsed;

        static /*0xeadd8c*/ DigitsArray();
        static /*0xeadd7c*/ int get_DataSizeOf();
        static /*0xeadd84*/ int get_DataSizeBits();
        static /*0xeae024*/ int ShiftRight(uint[] buffer, int shiftCount);
        static /*0xeae1fc*/ int ShiftLeft(uint[] buffer, int shiftCount);
        /*0xeadaa0*/ DigitsArray(int size);
        /*0xeadb34*/ DigitsArray(int size, int used);
        /*0xeadb68*/ DigitsArray(uint[] copyFrom);
        /*0xeadd00*/ DigitsArray(ScottGarland.DigitsArray copyFrom);
        /*0xeadbc4*/ void Allocate(int size);
        /*0xeadad0*/ void Allocate(int size, int used);
        /*0xeadbcc*/ void CopyFrom(uint[] source, int sourceOffset, int offset, int length);
        /*0xeadddc*/ void CopyTo(uint[] array, int offset, int length);
        /*0xeaddf8*/ uint get_Item(int index);
        /*0xeadf2c*/ void set_Item(int index, uint value);
        /*0xeadf5c*/ int get_DataUsed();
        /*0xeadf64*/ void set_DataUsed(int value);
        /*0xeadd60*/ int get_Count();
        /*0xeadf6c*/ bool get_IsZero();
        /*0xeadea0*/ bool get_IsNegative();
        /*0xeadbe8*/ void ResetDataUsed();
        /*0xeadfbc*/ int ShiftRight(int shiftCount);
        /*0xeae194*/ int ShiftLeft(int shiftCount);
        /*0xeae3a4*/ int ShiftLeftWithoutOverflow(int shiftCount);
    }

    class BigInteger
    {
        static /*0x0*/ string[] units;
        /*0x10*/ ScottGarland.DigitsArray m_digits;

        static /*0xeb29d0*/ BigInteger();
        static /*0xeaf62c*/ ScottGarland.BigInteger op_Implicit(long value);
        static /*0xeaf68c*/ ScottGarland.BigInteger op_Implicit(ulong value);
        static /*0xeaeee4*/ ScottGarland.BigInteger op_Implicit(int value);
        static /*0xeaf6ec*/ ScottGarland.BigInteger op_Implicit(uint value);
        static /*0xeaf230*/ ScottGarland.BigInteger op_Addition(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeaf74c*/ ScottGarland.BigInteger Add(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeaf968*/ ScottGarland.BigInteger op_Increment(ScottGarland.BigInteger leftSide);
        static /*0xeaf9c8*/ ScottGarland.BigInteger Increment(ScottGarland.BigInteger leftSide);
        static /*0xeaf7b0*/ ScottGarland.BigInteger op_Subtraction(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeafa28*/ ScottGarland.BigInteger Subtract(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeafa8c*/ ScottGarland.BigInteger op_Decrement(ScottGarland.BigInteger leftSide);
        static /*0xeafaec*/ ScottGarland.BigInteger Decrement(ScottGarland.BigInteger leftSide);
        static /*0xeaf3d8*/ ScottGarland.BigInteger op_UnaryNegation(ScottGarland.BigInteger leftSide);
        static /*0xeafba0*/ ScottGarland.BigInteger Abs(ScottGarland.BigInteger leftSide);
        static /*0xeaef44*/ ScottGarland.BigInteger op_Multiply(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeafc68*/ ScottGarland.BigInteger Multiply(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeafccc*/ ScottGarland.BigInteger op_Division(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeb01b8*/ ScottGarland.BigInteger Divide(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeb00c4*/ void Divide(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide, ref ScottGarland.BigInteger quotient, ref ScottGarland.BigInteger remainder);
        static /*0xeb0530*/ void MultiDivide(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide, ref ScottGarland.BigInteger quotient, ref ScottGarland.BigInteger remainder);
        static /*0xeb021c*/ void SingleDivide(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide, ref ScottGarland.BigInteger quotient, ref ScottGarland.BigInteger remainder);
        static /*0xeb0e1c*/ ScottGarland.BigInteger op_Modulus(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeb0fe4*/ ScottGarland.BigInteger Modulus(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeb1048*/ ScottGarland.BigInteger op_BitwiseAnd(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeb11a4*/ ScottGarland.BigInteger BitwiseAnd(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeb1208*/ ScottGarland.BigInteger op_BitwiseOr(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeb1364*/ ScottGarland.BigInteger BitwiseOr(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeb13c8*/ ScottGarland.BigInteger op_ExclusiveOr(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeb1524*/ ScottGarland.BigInteger Xor(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeb1588*/ ScottGarland.BigInteger op_OnesComplement(ScottGarland.BigInteger leftSide);
        static /*0xeb168c*/ ScottGarland.BigInteger OnesComplement(ScottGarland.BigInteger leftSide);
        static /*0xeb0b98*/ ScottGarland.BigInteger op_LeftShift(ScottGarland.BigInteger leftSide, int shiftCount);
        static /*0xeb16e0*/ ScottGarland.BigInteger LeftShift(ScottGarland.BigInteger leftSide, int shiftCount);
        static /*0xeb1744*/ ScottGarland.BigInteger op_RightShift(ScottGarland.BigInteger leftSide, int shiftCount);
        static /*0xeb1950*/ ScottGarland.BigInteger RightShift(ScottGarland.BigInteger leftSide, int shiftCount);
        static /*0xeb1a78*/ int Compare(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeafec8*/ bool op_Equality(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeb1b90*/ bool op_Inequality(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeb0ca4*/ bool op_GreaterThan(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeaff4c*/ bool op_LessThan(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeb1c00*/ bool op_GreaterThanOrEqual(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeb1c70*/ bool op_LessThanOrEqual(ScottGarland.BigInteger leftSide, ScottGarland.BigInteger rightSide);
        static /*0xeb24e0*/ int ToInt16(ScottGarland.BigInteger value);
        static /*0xeb25b8*/ uint ToUInt16(ScottGarland.BigInteger value);
        static /*0xeb2690*/ int ToInt32(ScottGarland.BigInteger value);
        static /*0xeb2760*/ uint ToUInt32(ScottGarland.BigInteger value);
        static /*0xeb2830*/ long ToInt64(ScottGarland.BigInteger value);
        static /*0xeb2900*/ ulong ToUInt64(ScottGarland.BigInteger value);
        /*0xeae61c*/ BigInteger();
        /*0xeae698*/ BigInteger(long number);
        /*0xeae7a4*/ BigInteger(ulong number);
        /*0xeae8b0*/ BigInteger(byte[] array);
        /*0xeaeb90*/ BigInteger(byte[] array, int length);
        /*0xeaebc8*/ BigInteger(byte[] array, int offset, int length);
        /*0xeaec0c*/ BigInteger(string digits);
        /*0xeaeeb0*/ BigInteger(string digits, int radix);
        /*0xeaf5c4*/ BigInteger(ScottGarland.DigitsArray digits);
        /*0xeae8ec*/ void ConstructFrom(byte[] array, int offset, int length);
        /*0xeaec3c*/ void Construct(string digits, int radix);
        /*0xeaf5fc*/ bool get_IsNegative();
        /*0xeaf614*/ bool get_IsZero();
        /*0xeafb4c*/ ScottGarland.BigInteger Negate();
        /*0xeb1a14*/ int CompareTo(ScottGarland.BigInteger value);
        /*0xeb1ce0*/ bool Equals(object obj);
        /*0xeb1de8*/ int GetHashCode();
        /*0xeb1e08*/ string ToString();
        /*0xeb1e10*/ string ToString(int radix);
        /*0xeb2144*/ string ToStringUnit();
        /*0xeb231c*/ string ToHexString();
    }
}

namespace GarlicSimpleJSON
{
    enum JSONBinaryTag
    {
        Array = 1,
        Class = 2,
        Value = 3,
        IntValue = 4,
        DoubleValue = 5,
        BoolValue = 6,
        FloatValue = 7,
    }

    class JSONNode
    {
        static /*0xeb411c*/ GarlicSimpleJSON.JSONNode op_Implicit(string s);
        static /*0xeb41a8*/ string op_Implicit(GarlicSimpleJSON.JSONNode d);
        static /*0xeb41e4*/ bool op_Equality(GarlicSimpleJSON.JSONNode a, object b);
        static /*0xeb426c*/ bool op_Inequality(GarlicSimpleJSON.JSONNode a, object b);
        static /*0xeb4298*/ string Escape(string aText);
        static /*0xeb4464*/ GarlicSimpleJSON.JSONNode Parse(string aJSON);
        static /*0xeb51c8*/ GarlicSimpleJSON.JSONNode Deserialize(System.IO.BinaryReader aReader);
        static /*0xeb5638*/ GarlicSimpleJSON.JSONNode LoadFromCompressedFile(string aFileName);
        static /*0xeb5688*/ GarlicSimpleJSON.JSONNode LoadFromCompressedStream(System.IO.Stream aData);
        static /*0xeb56d8*/ GarlicSimpleJSON.JSONNode LoadFromCompressedBase64(string aBase64);
        static /*0xeb5728*/ GarlicSimpleJSON.JSONNode LoadFromStream(System.IO.Stream aData);
        static /*0xeb58bc*/ GarlicSimpleJSON.JSONNode LoadFromFile(string aFileName);
        static /*0xeb5a38*/ GarlicSimpleJSON.JSONNode LoadFromBase64(string aBase64);
        /*0xeb5aec*/ JSONNode();
        /*0xeb3894*/ System.Collections.Generic.IEnumerable<string> get_Keys();
        /*0xeb3938*/ void Add(string aKey, GarlicSimpleJSON.JSONNode aItem);
        /*0xeb393c*/ GarlicSimpleJSON.JSONNode get_Item(int aIndex);
        /*0xeb3944*/ void set_Item(int aIndex, GarlicSimpleJSON.JSONNode value);
        /*0xeb3948*/ GarlicSimpleJSON.JSONNode get_Item(string aKey);
        /*0xeb3950*/ void set_Item(string aKey, GarlicSimpleJSON.JSONNode value);
        /*0xeb3954*/ string get_Value();
        /*0xeb3994*/ void set_Value(string value);
        /*0xeb3998*/ int get_Count();
        /*0xeb39a0*/ void Add(GarlicSimpleJSON.JSONNode aItem);
        /*0xeb3a00*/ GarlicSimpleJSON.JSONNode Remove(string aKey);
        /*0xeb3a08*/ GarlicSimpleJSON.JSONNode Remove(int aIndex);
        /*0xeb3a10*/ GarlicSimpleJSON.JSONNode Remove(GarlicSimpleJSON.JSONNode aNode);
        /*0xeb3a18*/ System.Collections.Generic.IEnumerable<GarlicSimpleJSON.JSONNode> get_Childs();
        /*0xeb3abc*/ System.Collections.Generic.IEnumerable<GarlicSimpleJSON.JSONNode> get_DeepChilds();
        /*0xeb3b68*/ string ToString();
        /*0xeb3ba8*/ string ToString(string aPrefix);
        /*0xeb3be8*/ int get_AsInt();
        /*0xeb3c1c*/ void set_AsInt(int value);
        /*0xeb3ca4*/ float get_AsFloat();
        /*0xeb3d48*/ void set_AsFloat(float value);
        /*0xeb3dd0*/ double get_AsDouble();
        /*0xeb3e74*/ void set_AsDouble(double value);
        /*0xeb3efc*/ bool get_AsBool();
        /*0xeb3fb4*/ void set_AsBool(bool value);
        /*0xeb402c*/ GarlicSimpleJSON.JSONArray get_AsArray();
        /*0xeb40a4*/ GarlicSimpleJSON.JSONClass get_AsObject();
        /*0xeb4284*/ bool Equals(object obj);
        /*0xeb4290*/ int GetHashCode();
        /*0xeb4c84*/ void Serialize(System.IO.BinaryWriter aWriter);
        /*0xeb4c88*/ void SaveToStream(System.IO.Stream aData);
        /*0xeb4d08*/ void SaveToCompressedStream(System.IO.Stream aData);
        /*0xeb4d58*/ void SaveToCompressedFile(string aFileName);
        /*0xeb4da8*/ string SaveToCompressedBase64();
        /*0xeb4df8*/ void SaveToFile(string aFileName);
        /*0xeb4fc8*/ string SaveToBase64();

        class <get_Keys>d__1 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ string <>2__current;
            /*0x20*/ int <>l__initialThreadId;

            /*0xeb3904*/ <get_Keys>d__1(int <>1__state);
            /*0xeb5af4*/ void System.IDisposable.Dispose();
            /*0xeb5af8*/ bool MoveNext();
            /*0xeb5b10*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
            /*0xeb5b18*/ void System.Collections.IEnumerator.Reset();
            /*0xeb5b58*/ object System.Collections.IEnumerator.get_Current();
            /*0xeb5b60*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
            /*0xeb5bf8*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <get_Childs>d__19 : System.Collections.Generic.IEnumerable<GarlicSimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<GarlicSimpleJSON.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ GarlicSimpleJSON.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;

            /*0xeb3a88*/ <get_Childs>d__19(int <>1__state);
            /*0xeb5bfc*/ void System.IDisposable.Dispose();
            /*0xeb5c00*/ bool MoveNext();
            /*0xeb5c18*/ GarlicSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<GarlicSimpleJSON.JSONNode>.get_Current();
            /*0xeb5c20*/ void System.Collections.IEnumerator.Reset();
            /*0xeb5c60*/ object System.Collections.IEnumerator.get_Current();
            /*0xeb5c68*/ System.Collections.Generic.IEnumerator<GarlicSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<GarlicSimpleJSON.JSONNode>.GetEnumerator();
            /*0xeb5d00*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <get_DeepChilds>d__21 : System.Collections.Generic.IEnumerable<GarlicSimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<GarlicSimpleJSON.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ GarlicSimpleJSON.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ GarlicSimpleJSON.JSONNode <>4__this;
            /*0x30*/ System.Collections.Generic.IEnumerator<GarlicSimpleJSON.JSONNode> <>7__wrap1;
            /*0x38*/ System.Collections.Generic.IEnumerator<GarlicSimpleJSON.JSONNode> <>7__wrap2;

            /*0xeb3b34*/ <get_DeepChilds>d__21(int <>1__state);
            /*0xeb5d04*/ void System.IDisposable.Dispose();
            /*0xeb5dbc*/ bool MoveNext();
            /*0xeb62a0*/ void <>m__Finally1();
            /*0xeb61f0*/ void <>m__Finally2();
            /*0xeb6350*/ GarlicSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<GarlicSimpleJSON.JSONNode>.get_Current();
            /*0xeb6358*/ void System.Collections.IEnumerator.Reset();
            /*0xeb6398*/ object System.Collections.IEnumerator.get_Current();
            /*0xeb63a0*/ System.Collections.Generic.IEnumerator<GarlicSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<GarlicSimpleJSON.JSONNode>.GetEnumerator();
            /*0xeb6444*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }
    }

    class JSONArray : GarlicSimpleJSON.JSONNode, System.Collections.IEnumerable
    {
        /*0x10*/ System.Collections.Generic.List<GarlicSimpleJSON.JSONNode> m_List;

        /*0xeb4c08*/ JSONArray();
        /*0xeb6448*/ GarlicSimpleJSON.JSONNode get_Item(int aIndex);
        /*0xeb6524*/ void set_Item(int aIndex, GarlicSimpleJSON.JSONNode value);
        /*0xeb662c*/ GarlicSimpleJSON.JSONNode get_Item(string aKey);
        /*0xeb6690*/ void set_Item(string aKey, GarlicSimpleJSON.JSONNode value);
        /*0xeb6738*/ int get_Count();
        /*0xeb6780*/ void Add(string aKey, GarlicSimpleJSON.JSONNode aItem);
        /*0xeb6828*/ GarlicSimpleJSON.JSONNode Remove(int aIndex);
        /*0xeb68dc*/ GarlicSimpleJSON.JSONNode Remove(GarlicSimpleJSON.JSONNode aNode);
        /*0xeb693c*/ System.Collections.Generic.IEnumerable<GarlicSimpleJSON.JSONNode> get_Childs();
        /*0xeb69e8*/ System.Collections.IEnumerator GetEnumerator();
        /*0xeb6a78*/ string ToString();
        /*0xeb6c90*/ string ToString(string aPrefix);
        /*0xeb6f10*/ void Serialize(System.IO.BinaryWriter aWriter);

        class <get_Childs>d__13 : System.Collections.Generic.IEnumerable<GarlicSimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<GarlicSimpleJSON.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ GarlicSimpleJSON.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ GarlicSimpleJSON.JSONArray <>4__this;
            /*0x30*/ System.Collections.Generic.List.Enumerator<GarlicSimpleJSON.JSONNode> <>7__wrap1;

            /*0xeb69b4*/ <get_Childs>d__13(int <>1__state);
            /*0xeb6fec*/ void System.IDisposable.Dispose();
            /*0xeb7008*/ bool MoveNext();
            /*0xeb719c*/ void <>m__Finally1();
            /*0xeb71ec*/ GarlicSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<GarlicSimpleJSON.JSONNode>.get_Current();
            /*0xeb71f4*/ void System.Collections.IEnumerator.Reset();
            /*0xeb7234*/ object System.Collections.IEnumerator.get_Current();
            /*0xeb723c*/ System.Collections.Generic.IEnumerator<GarlicSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<GarlicSimpleJSON.JSONNode>.GetEnumerator();
            /*0xeb72e0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <GetEnumerator>d__14 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ GarlicSimpleJSON.JSONArray <>4__this;
            /*0x28*/ System.Collections.Generic.List.Enumerator<GarlicSimpleJSON.JSONNode> <>7__wrap1;

            /*0xeb6a50*/ <GetEnumerator>d__14(int <>1__state);
            /*0xeb72e4*/ void System.IDisposable.Dispose();
            /*0xeb7300*/ bool MoveNext();
            /*0xeb7494*/ void <>m__Finally1();
            /*0xeb74e4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0xeb74ec*/ void System.Collections.IEnumerator.Reset();
            /*0xeb752c*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class JSONClass : GarlicSimpleJSON.JSONNode, System.Collections.IEnumerable
    {
        /*0x10*/ System.Collections.Generic.Dictionary<string, GarlicSimpleJSON.JSONNode> m_Dict;

        /*0xeb4b8c*/ JSONClass();
        /*0xeb7534*/ System.Collections.Generic.IEnumerable<string> get_Keys();
        /*0xeb75e0*/ GarlicSimpleJSON.JSONNode get_Item(string aKey);
        /*0xeb76d0*/ void set_Item(string aKey, GarlicSimpleJSON.JSONNode value);
        /*0xeb779c*/ GarlicSimpleJSON.JSONNode get_Item(int aIndex);
        /*0xeb783c*/ void set_Item(int aIndex, GarlicSimpleJSON.JSONNode value);
        /*0xeb7918*/ int get_Count();
        /*0xeb7968*/ void Add(string aKey, GarlicSimpleJSON.JSONNode aItem);
        /*0xeb7a7c*/ GarlicSimpleJSON.JSONNode Remove(string aKey);
        /*0xeb7b40*/ GarlicSimpleJSON.JSONNode Remove(int aIndex);
        /*0xeb7c1c*/ GarlicSimpleJSON.JSONNode Remove(GarlicSimpleJSON.JSONNode aNode);
        /*0xeb7de4*/ System.Collections.Generic.IEnumerable<GarlicSimpleJSON.JSONNode> get_Childs();
        /*0xeb7e90*/ System.Collections.IEnumerator GetEnumerator();
        /*0xeb7f20*/ string ToString();
        /*0xeb8308*/ string ToString(string aPrefix);
        /*0xeb8774*/ void Serialize(System.IO.BinaryWriter aWriter);

        class <get_Keys>d__1 : System.Collections.Generic.IEnumerable<string>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<string>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ string <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ GarlicSimpleJSON.JSONClass <>4__this;
            /*0x30*/ System.Collections.Generic.Dictionary.KeyCollection.Enumerator<string, GarlicSimpleJSON.JSONNode> <>7__wrap1;

            /*0xeb75ac*/ <get_Keys>d__1(int <>1__state);
            /*0xeb8994*/ void System.IDisposable.Dispose();
            /*0xeb89b0*/ bool MoveNext();
            /*0xeb8b6c*/ void <>m__Finally1();
            /*0xeb8bbc*/ string System.Collections.Generic.IEnumerator<System.String>.get_Current();
            /*0xeb8bc4*/ void System.Collections.IEnumerator.Reset();
            /*0xeb8c04*/ object System.Collections.IEnumerator.get_Current();
            /*0xeb8c0c*/ System.Collections.Generic.IEnumerator<string> System.Collections.Generic.IEnumerable<System.String>.GetEnumerator();
            /*0xeb8cb0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <>c__DisplayClass14_0
        {
            /*0x10*/ GarlicSimpleJSON.JSONNode aNode;

            /*0xeb7ddc*/ <>c__DisplayClass14_0();
            /*0xeb8cb4*/ bool <Remove>b__0(System.Collections.Generic.KeyValuePair<string, GarlicSimpleJSON.JSONNode> k);
        }

        class <get_Childs>d__16 : System.Collections.Generic.IEnumerable<GarlicSimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<GarlicSimpleJSON.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ GarlicSimpleJSON.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ GarlicSimpleJSON.JSONClass <>4__this;
            /*0x30*/ System.Collections.Generic.Dictionary.Enumerator<string, GarlicSimpleJSON.JSONNode> <>7__wrap1;

            /*0xeb7e5c*/ <get_Childs>d__16(int <>1__state);
            /*0xeb8cf8*/ void System.IDisposable.Dispose();
            /*0xeb8d14*/ bool MoveNext();
            /*0xeb8ebc*/ void <>m__Finally1();
            /*0xeb8f0c*/ GarlicSimpleJSON.JSONNode System.Collections.Generic.IEnumerator<GarlicSimpleJSON.JSONNode>.get_Current();
            /*0xeb8f14*/ void System.Collections.IEnumerator.Reset();
            /*0xeb8f54*/ object System.Collections.IEnumerator.get_Current();
            /*0xeb8f5c*/ System.Collections.Generic.IEnumerator<GarlicSimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<GarlicSimpleJSON.JSONNode>.GetEnumerator();
            /*0xeb9000*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <GetEnumerator>d__17 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ GarlicSimpleJSON.JSONClass <>4__this;
            /*0x28*/ System.Collections.Generic.Dictionary.Enumerator<string, GarlicSimpleJSON.JSONNode> <>7__wrap1;

            /*0xeb7ef8*/ <GetEnumerator>d__17(int <>1__state);
            /*0xeb9004*/ void System.IDisposable.Dispose();
            /*0xeb9020*/ bool MoveNext();
            /*0xeb91f4*/ void <>m__Finally1();
            /*0xeb9244*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0xeb924c*/ void System.Collections.IEnumerator.Reset();
            /*0xeb928c*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class JSONData : GarlicSimpleJSON.JSONNode
    {
        /*0x10*/ string m_Data;

        /*0xeb4180*/ JSONData(string aData);
        /*0xeb5600*/ JSONData(float aData);
        /*0xeb5590*/ JSONData(double aData);
        /*0xeb55c8*/ JSONData(bool aData);
        /*0xeb5558*/ JSONData(int aData);
        /*0xeb9294*/ string get_Value();
        /*0xeb929c*/ void set_Value(string value);
        /*0xeb92a4*/ string ToString();
        /*0xeb92fc*/ string ToString(string aPrefix);
        /*0xeb9354*/ void Serialize(System.IO.BinaryWriter aWriter);
    }

    class JSONLazyCreator : GarlicSimpleJSON.JSONNode
    {
        /*0x10*/ GarlicSimpleJSON.JSONNode m_Node;
        /*0x18*/ string m_Key;

        static /*0xeb9958*/ bool op_Equality(GarlicSimpleJSON.JSONLazyCreator a, object b);
        static /*0xeb9970*/ bool op_Inequality(GarlicSimpleJSON.JSONLazyCreator a, object b);
        /*0xeb64fc*/ JSONLazyCreator(GarlicSimpleJSON.JSONNode aNode);
        /*0xeb76a4*/ JSONLazyCreator(GarlicSimpleJSON.JSONNode aNode, string aKey);
        /*0xeb9614*/ void Set(GarlicSimpleJSON.JSONNode aVal);
        /*0xeb966c*/ GarlicSimpleJSON.JSONNode get_Item(int aIndex);
        /*0xeb96d0*/ void set_Item(int aIndex, GarlicSimpleJSON.JSONNode value);
        /*0xeb9754*/ GarlicSimpleJSON.JSONNode get_Item(string aKey);
        /*0xeb97c4*/ void set_Item(string aKey, GarlicSimpleJSON.JSONNode value);
        /*0xeb984c*/ void Add(GarlicSimpleJSON.JSONNode aItem);
        /*0xeb98d0*/ void Add(string aKey, GarlicSimpleJSON.JSONNode aItem);
        /*0xeb9988*/ bool Equals(object obj);
        /*0xeb99a0*/ int GetHashCode();
        /*0xeb99a8*/ string ToString();
        /*0xeb99e8*/ string ToString(string aPrefix);
        /*0xeb9a28*/ int get_AsInt();
        /*0xeb9aac*/ void set_AsInt(int value);
        /*0xeb9b34*/ float get_AsFloat();
        /*0xeb9bb8*/ void set_AsFloat(float value);
        /*0xeb9c40*/ double get_AsDouble();
        /*0xeb9cc4*/ void set_AsDouble(double value);
        /*0xeb9d4c*/ bool get_AsBool();
        /*0xeb9dd0*/ void set_AsBool(bool value);
        /*0xeb9e58*/ GarlicSimpleJSON.JSONArray get_AsArray();
        /*0xeb9ec0*/ GarlicSimpleJSON.JSONClass get_AsObject();
    }

    class JSON
    {
        static /*0xeb9f28*/ GarlicSimpleJSON.JSONNode Parse(string aJSON);
    }
}

namespace SimpleJSON_2020
{
    enum JSONNodeType
    {
        Array = 1,
        Object = 2,
        String = 3,
        Number = 4,
        NullValue = 5,
        Boolean = 6,
        None = 7,
        Custom = 255,
    }

    enum JSONTextMode
    {
        Compact = 0,
        Indent = 1,
    }

    class JSONNode
    {
        static /*0x0*/ bool forceASCII;
        static /*0x1*/ bool longAsString;
        static /*0x2*/ bool allowLineComments;
        static /*0x4*/ SimpleJSON_2020.JSONContainerType VectorContainerType;
        static /*0x8*/ SimpleJSON_2020.JSONContainerType QuaternionContainerType;
        static /*0xc*/ SimpleJSON_2020.JSONContainerType RectContainerType;
        [ThreadStatic] static System.Text.StringBuilder m_EscapeBuilder;

        static /*0xebf924*/ JSONNode();
        static /*0xeba8b0*/ SimpleJSON_2020.JSONNode op_Implicit(string s);
        static /*0xeba97c*/ string op_Implicit(SimpleJSON_2020.JSONNode d);
        static /*0xebab80*/ SimpleJSON_2020.JSONNode op_Implicit(double n);
        static /*0xebac54*/ double op_Implicit(SimpleJSON_2020.JSONNode d);
        static /*0xebacdc*/ SimpleJSON_2020.JSONNode op_Implicit(float n);
        static /*0xebad44*/ float op_Implicit(SimpleJSON_2020.JSONNode d);
        static /*0xebadcc*/ SimpleJSON_2020.JSONNode op_Implicit(int n);
        static /*0xebae2c*/ int op_Implicit(SimpleJSON_2020.JSONNode d);
        static /*0xebaeb4*/ SimpleJSON_2020.JSONNode op_Implicit(long n);
        static /*0xebaf98*/ long op_Implicit(SimpleJSON_2020.JSONNode d);
        static /*0xebb020*/ SimpleJSON_2020.JSONNode op_Implicit(bool b);
        static /*0xebb0ec*/ bool op_Implicit(SimpleJSON_2020.JSONNode d);
        static /*0xebb174*/ SimpleJSON_2020.JSONNode op_Implicit(System.Collections.Generic.KeyValuePair<string, SimpleJSON_2020.JSONNode> aKeyValue);
        static /*0xebaa00*/ bool op_Equality(SimpleJSON_2020.JSONNode a, object b);
        static /*0xebb1b0*/ bool op_Inequality(SimpleJSON_2020.JSONNode a, object b);
        static /*0xebb234*/ System.Text.StringBuilder get_EscapeBuilder();
        static /*0xebb300*/ string Escape(string aText);
        static /*0xebb5f0*/ SimpleJSON_2020.JSONNode ParseElement(string token, bool quoted);
        static /*0xebb850*/ SimpleJSON_2020.JSONNode Parse(string aJSON);
        static /*0xebc638*/ SimpleJSON_2020.JSONNode DeserializeBinary(System.IO.BinaryReader aReader);
        static /*0xebc99c*/ SimpleJSON_2020.JSONNode LoadFromCompressedFile(string aFileName);
        static /*0xebc9ec*/ SimpleJSON_2020.JSONNode LoadFromCompressedStream(System.IO.Stream aData);
        static /*0xebca3c*/ SimpleJSON_2020.JSONNode LoadFromCompressedBase64(string aBase64);
        static /*0xebca8c*/ SimpleJSON_2020.JSONNode LoadFromBinaryStream(System.IO.Stream aData);
        static /*0xebcc48*/ SimpleJSON_2020.JSONNode LoadFromBinaryFile(string aFileName);
        static /*0xebcdf4*/ SimpleJSON_2020.JSONNode LoadFromBinaryBase64(string aBase64);
        static /*0xebcecc*/ bool TryParse(string aJSON, ref SimpleJSON_2020.JSONNode result);
        static /*0xebd5fc*/ SimpleJSON_2020.JSONNode GetContainer(SimpleJSON_2020.JSONContainerType aType);
        static /*0xebd688*/ SimpleJSON_2020.JSONNode op_Implicit(UnityEngine.Vector2 aVec);
        static /*0xebd864*/ SimpleJSON_2020.JSONNode op_Implicit(UnityEngine.Vector3 aVec);
        static /*0xebdad8*/ SimpleJSON_2020.JSONNode op_Implicit(UnityEngine.Vector4 aVec);
        static /*0xebddbc*/ SimpleJSON_2020.JSONNode op_Implicit(UnityEngine.Quaternion aRot);
        static /*0xebe0a0*/ SimpleJSON_2020.JSONNode op_Implicit(UnityEngine.Rect aRect);
        static /*0xebe3e0*/ SimpleJSON_2020.JSONNode op_Implicit(UnityEngine.RectOffset aRect);
        static /*0xebe718*/ UnityEngine.Vector2 op_Implicit(SimpleJSON_2020.JSONNode aNode);
        static /*0xebe778*/ UnityEngine.Vector3 op_Implicit(SimpleJSON_2020.JSONNode aNode);
        static /*0xebe7dc*/ UnityEngine.Vector4 op_Implicit(SimpleJSON_2020.JSONNode aNode);
        static /*0xebe840*/ UnityEngine.Quaternion op_Implicit(SimpleJSON_2020.JSONNode aNode);
        static /*0xebe8a4*/ UnityEngine.Rect op_Implicit(SimpleJSON_2020.JSONNode aNode);
        static /*0xebe8d8*/ UnityEngine.RectOffset op_Implicit(SimpleJSON_2020.JSONNode aNode);
        /*0xebf91c*/ JSONNode();
        SimpleJSON_2020.JSONNodeType get_Tag();
        /*0xeb9f2c*/ SimpleJSON_2020.JSONNode get_Item(int aIndex);
        /*0xeb9f34*/ void set_Item(int aIndex, SimpleJSON_2020.JSONNode value);
        /*0xeb9f38*/ SimpleJSON_2020.JSONNode get_Item(string aKey);
        /*0xeb9f40*/ void set_Item(string aKey, SimpleJSON_2020.JSONNode value);
        /*0xeb9f44*/ string get_Value();
        /*0xeb9f84*/ void set_Value(string value);
        /*0xeb9f88*/ int get_Count();
        /*0xeb9f90*/ bool get_IsNumber();
        /*0xeb9f98*/ bool get_IsString();
        /*0xeb9fa0*/ bool get_IsBoolean();
        /*0xeb9fa8*/ bool get_IsNull();
        /*0xeb9fb0*/ bool get_IsArray();
        /*0xeb9fb8*/ bool get_IsObject();
        /*0xeb9fc0*/ bool get_Inline();
        /*0xeb9fc8*/ void set_Inline(bool value);
        /*0xeb9fcc*/ void Add(string aKey, SimpleJSON_2020.JSONNode aItem);
        /*0xeb9fd0*/ void Add(SimpleJSON_2020.JSONNode aItem);
        /*0xeba034*/ SimpleJSON_2020.JSONNode Remove(string aKey);
        /*0xeba03c*/ SimpleJSON_2020.JSONNode Remove(int aIndex);
        /*0xeba044*/ SimpleJSON_2020.JSONNode Remove(SimpleJSON_2020.JSONNode aNode);
        /*0xeba04c*/ SimpleJSON_2020.JSONNode Clone();
        /*0xeba054*/ System.Collections.Generic.IEnumerable<SimpleJSON_2020.JSONNode> get_Children();
        /*0xeba0f8*/ System.Collections.Generic.IEnumerable<SimpleJSON_2020.JSONNode> get_DeepChildren();
        /*0xeba1a4*/ bool HasKey(string aKey);
        /*0xeba1ac*/ SimpleJSON_2020.JSONNode GetValueOrDefault(string aKey, SimpleJSON_2020.JSONNode aDefault);
        /*0xeba1b4*/ string ToString();
        /*0xeba240*/ string ToString(int aIndent);
        void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON_2020.JSONTextMode aMode);
        SimpleJSON_2020.JSONNode.Enumerator GetEnumerator();
        /*0xeba2d8*/ System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, SimpleJSON_2020.JSONNode>> get_Linq();
        /*0xeba3fc*/ SimpleJSON_2020.JSONNode.KeyEnumerator get_Keys();
        /*0xeba438*/ SimpleJSON_2020.JSONNode.ValueEnumerator get_Values();
        /*0xeba474*/ double get_AsDouble();
        /*0xeba518*/ void set_AsDouble(double value);
        /*0xeba5a0*/ int get_AsInt();
        /*0xeba5d4*/ void set_AsInt(int value);
        /*0xeba5ec*/ float get_AsFloat();
        /*0xeba60c*/ void set_AsFloat(float value);
        /*0xeba620*/ bool get_AsBool();
        /*0xeba6d8*/ void set_AsBool(bool value);
        /*0xeba750*/ long get_AsLong();
        /*0xeba784*/ void set_AsLong(long value);
        /*0xeba7c0*/ SimpleJSON_2020.JSONArray get_AsArray();
        /*0xeba838*/ SimpleJSON_2020.JSONObject get_AsObject();
        /*0xebb220*/ bool Equals(object obj);
        /*0xebb22c*/ int GetHashCode();
        void SerializeBinary(System.IO.BinaryWriter aWriter);
        /*0xebc0f8*/ void SaveToBinaryStream(System.IO.Stream aData);
        /*0xebc178*/ void SaveToCompressedStream(System.IO.Stream aData);
        /*0xebc1c8*/ void SaveToCompressedFile(string aFileName);
        /*0xebc218*/ string SaveToCompressedBase64();
        /*0xebc268*/ void SaveToBinaryFile(string aFileName);
        /*0xebc438*/ string SaveToBinaryBase64();
        /*0xebe94c*/ UnityEngine.Vector2 ReadVector2(UnityEngine.Vector2 aDefault);
        /*0xebea8c*/ UnityEngine.Vector2 ReadVector2(string aXName, string aYName);
        /*0xebe728*/ UnityEngine.Vector2 ReadVector2();
        /*0xebd734*/ SimpleJSON_2020.JSONNode WriteVector2(UnityEngine.Vector2 aVec, string aXName, string aYName);
        /*0xebeb64*/ UnityEngine.Vector3 ReadVector3(UnityEngine.Vector3 aDefault);
        /*0xebed20*/ UnityEngine.Vector3 ReadVector3(string aXName, string aYName, string aZName);
        /*0xebe788*/ UnityEngine.Vector3 ReadVector3();
        /*0xebd938*/ SimpleJSON_2020.JSONNode WriteVector3(UnityEngine.Vector3 aVec, string aXName, string aYName, string aZName);
        /*0xebee38*/ UnityEngine.Vector4 ReadVector4(UnityEngine.Vector4 aDefault);
        /*0xebe7ec*/ UnityEngine.Vector4 ReadVector4();
        /*0xebdb6c*/ SimpleJSON_2020.JSONNode WriteVector4(UnityEngine.Vector4 aVec);
        /*0xebf068*/ UnityEngine.Quaternion ReadQuaternion(UnityEngine.Quaternion aDefault);
        /*0xebe850*/ UnityEngine.Quaternion ReadQuaternion();
        /*0xebde50*/ SimpleJSON_2020.JSONNode WriteQuaternion(UnityEngine.Quaternion aRot);
        /*0xebf298*/ UnityEngine.Rect ReadRect(UnityEngine.Rect aDefault);
        /*0xebe8c4*/ UnityEngine.Rect ReadRect();
        /*0xebe134*/ SimpleJSON_2020.JSONNode WriteRect(UnityEngine.Rect aRect);
        /*0xebf4f0*/ UnityEngine.RectOffset ReadRectOffset(UnityEngine.RectOffset aDefault);
        /*0xebe8e8*/ UnityEngine.RectOffset ReadRectOffset();
        /*0xebe44c*/ SimpleJSON_2020.JSONNode WriteRectOffset(UnityEngine.RectOffset aRect);
        /*0xebf78c*/ UnityEngine.Matrix4x4 ReadMatrix();
        /*0xebf870*/ SimpleJSON_2020.JSONNode WriteMatrix(UnityEngine.Matrix4x4 aMatrix);

        struct Enumerator
        {
            /*0x10*/ SimpleJSON_2020.JSONNode.Enumerator.Type type;
            /*0x18*/ System.Collections.Generic.Dictionary.Enumerator<string, SimpleJSON_2020.JSONNode> m_Object;
            /*0x40*/ System.Collections.Generic.List.Enumerator<SimpleJSON_2020.JSONNode> m_Array;

            /*0xebf98c*/ Enumerator(System.Collections.Generic.List.Enumerator<SimpleJSON_2020.JSONNode> aArrayEnum);
            /*0xebf9b8*/ Enumerator(System.Collections.Generic.Dictionary.Enumerator<string, SimpleJSON_2020.JSONNode> aDictEnum);
            /*0xebf97c*/ bool get_IsValid();
            /*0xebf9dc*/ System.Collections.Generic.KeyValuePair<string, SimpleJSON_2020.JSONNode> get_Current();
            /*0xebfaa8*/ bool MoveNext();

            enum Type
            {
                None = 0,
                Array = 1,
                Object = 2,
            }
        }

        struct ValueEnumerator
        {
            /*0x10*/ SimpleJSON_2020.JSONNode.Enumerator m_Enumerator;

            /*0xebfb3c*/ ValueEnumerator(System.Collections.Generic.List.Enumerator<SimpleJSON_2020.JSONNode> aArrayEnum);
            /*0xebfb7c*/ ValueEnumerator(System.Collections.Generic.Dictionary.Enumerator<string, SimpleJSON_2020.JSONNode> aDictEnum);
            /*0xebfbec*/ ValueEnumerator(SimpleJSON_2020.JSONNode.Enumerator aEnumerator);
            /*0xebfc00*/ SimpleJSON_2020.JSONNode get_Current();
            /*0xebfc44*/ bool MoveNext();
            /*0xebfc48*/ SimpleJSON_2020.JSONNode.ValueEnumerator GetEnumerator();
        }

        struct KeyEnumerator
        {
            /*0x10*/ SimpleJSON_2020.JSONNode.Enumerator m_Enumerator;

            /*0xebfc58*/ KeyEnumerator(System.Collections.Generic.List.Enumerator<SimpleJSON_2020.JSONNode> aArrayEnum);
            /*0xebfc98*/ KeyEnumerator(System.Collections.Generic.Dictionary.Enumerator<string, SimpleJSON_2020.JSONNode> aDictEnum);
            /*0xebfd08*/ KeyEnumerator(SimpleJSON_2020.JSONNode.Enumerator aEnumerator);
            /*0xebfd1c*/ string get_Current();
            /*0xebfd58*/ bool MoveNext();
            /*0xebfd5c*/ SimpleJSON_2020.JSONNode.KeyEnumerator GetEnumerator();
        }

        class LinqEnumerator : System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, SimpleJSON_2020.JSONNode>>, System.Collections.IEnumerator, System.IDisposable, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, SimpleJSON_2020.JSONNode>>, System.Collections.IEnumerable
        {
            /*0x10*/ SimpleJSON_2020.JSONNode m_Node;
            /*0x18*/ SimpleJSON_2020.JSONNode.Enumerator m_Enumerator;

            /*0xeba338*/ LinqEnumerator(SimpleJSON_2020.JSONNode aNode);
            /*0xebfd6c*/ System.Collections.Generic.KeyValuePair<string, SimpleJSON_2020.JSONNode> get_Current();
            /*0xebfd74*/ object System.Collections.IEnumerator.get_Current();
            /*0xebfdd8*/ bool MoveNext();
            /*0xebfde0*/ void Dispose();
            /*0xebfdf4*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, SimpleJSON_2020.JSONNode>> GetEnumerator();
            /*0xebfe58*/ void Reset();
            /*0xebff04*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <get_Children>d__42 : System.Collections.Generic.IEnumerable<SimpleJSON_2020.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON_2020.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ SimpleJSON_2020.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;

            /*0xeba0c4*/ <get_Children>d__42(int <>1__state);
            /*0xebff68*/ void System.IDisposable.Dispose();
            /*0xebff6c*/ bool MoveNext();
            /*0xebff84*/ SimpleJSON_2020.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON_2020.JSONNode>.get_Current();
            /*0xebff8c*/ void System.Collections.IEnumerator.Reset();
            /*0xebffcc*/ object System.Collections.IEnumerator.get_Current();
            /*0xebffd4*/ System.Collections.Generic.IEnumerator<SimpleJSON_2020.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON_2020.JSONNode>.GetEnumerator();
            /*0xec006c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <get_DeepChildren>d__44 : System.Collections.Generic.IEnumerable<SimpleJSON_2020.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON_2020.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ SimpleJSON_2020.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ SimpleJSON_2020.JSONNode <>4__this;
            /*0x30*/ System.Collections.Generic.IEnumerator<SimpleJSON_2020.JSONNode> <>7__wrap1;
            /*0x38*/ System.Collections.Generic.IEnumerator<SimpleJSON_2020.JSONNode> <>7__wrap2;

            /*0xeba170*/ <get_DeepChildren>d__44(int <>1__state);
            /*0xec0070*/ void System.IDisposable.Dispose();
            /*0xec0128*/ bool MoveNext();
            /*0xec060c*/ void <>m__Finally1();
            /*0xec055c*/ void <>m__Finally2();
            /*0xec06bc*/ SimpleJSON_2020.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON_2020.JSONNode>.get_Current();
            /*0xec06c4*/ void System.Collections.IEnumerator.Reset();
            /*0xec0704*/ object System.Collections.IEnumerator.get_Current();
            /*0xec070c*/ System.Collections.Generic.IEnumerator<SimpleJSON_2020.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON_2020.JSONNode>.GetEnumerator();
            /*0xec07b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }
    }

    class JSONArray : SimpleJSON_2020.JSONNode
    {
        /*0x10*/ System.Collections.Generic.List<SimpleJSON_2020.JSONNode> m_List;
        /*0x18*/ bool inline;

        /*0xebc058*/ JSONArray();
        /*0xec07b4*/ bool get_Inline();
        /*0xec07bc*/ void set_Inline(bool value);
        /*0xec07c8*/ SimpleJSON_2020.JSONNodeType get_Tag();
        /*0xec07d0*/ bool get_IsArray();
        /*0xec07d8*/ SimpleJSON_2020.JSONNode.Enumerator GetEnumerator();
        /*0xec0864*/ SimpleJSON_2020.JSONNode get_Item(int aIndex);
        /*0xec0980*/ void set_Item(int aIndex, SimpleJSON_2020.JSONNode value);
        /*0xec0ae8*/ SimpleJSON_2020.JSONNode get_Item(string aKey);
        /*0xec0b48*/ void set_Item(string aKey, SimpleJSON_2020.JSONNode value);
        /*0xec0c5c*/ int get_Count();
        /*0xec0ca4*/ void Add(string aKey, SimpleJSON_2020.JSONNode aItem);
        /*0xec0db8*/ SimpleJSON_2020.JSONNode Remove(int aIndex);
        /*0xec0e6c*/ SimpleJSON_2020.JSONNode Remove(SimpleJSON_2020.JSONNode aNode);
        /*0xec0ecc*/ SimpleJSON_2020.JSONNode Clone();
        /*0xec1124*/ System.Collections.Generic.IEnumerable<SimpleJSON_2020.JSONNode> get_Children();
        /*0xec11d0*/ void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON_2020.JSONTextMode aMode);
        /*0xec1338*/ void SerializeBinary(System.IO.BinaryWriter aWriter);

        class <get_Children>d__23 : System.Collections.Generic.IEnumerable<SimpleJSON_2020.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON_2020.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ SimpleJSON_2020.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ SimpleJSON_2020.JSONArray <>4__this;
            /*0x30*/ System.Collections.Generic.List.Enumerator<SimpleJSON_2020.JSONNode> <>7__wrap1;

            /*0xec119c*/ <get_Children>d__23(int <>1__state);
            /*0xec1414*/ void System.IDisposable.Dispose();
            /*0xec1430*/ bool MoveNext();
            /*0xec15c4*/ void <>m__Finally1();
            /*0xec1614*/ SimpleJSON_2020.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON_2020.JSONNode>.get_Current();
            /*0xec161c*/ void System.Collections.IEnumerator.Reset();
            /*0xec165c*/ object System.Collections.IEnumerator.get_Current();
            /*0xec1664*/ System.Collections.Generic.IEnumerator<SimpleJSON_2020.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON_2020.JSONNode>.GetEnumerator();
            /*0xec1708*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }
    }

    class JSONObject : SimpleJSON_2020.JSONNode
    {
        /*0x10*/ System.Collections.Generic.Dictionary<string, SimpleJSON_2020.JSONNode> m_Dict;
        /*0x18*/ bool inline;

        /*0xebbfb8*/ JSONObject();
        /*0xec170c*/ bool get_Inline();
        /*0xec1714*/ void set_Inline(bool value);
        /*0xec1720*/ SimpleJSON_2020.JSONNodeType get_Tag();
        /*0xec1728*/ bool get_IsObject();
        /*0xec1730*/ SimpleJSON_2020.JSONNode.Enumerator GetEnumerator();
        /*0xec17b8*/ SimpleJSON_2020.JSONNode get_Item(string aKey);
        /*0xec18ec*/ void set_Item(string aKey, SimpleJSON_2020.JSONNode value);
        /*0xec1a18*/ SimpleJSON_2020.JSONNode get_Item(int aIndex);
        /*0xec1ab8*/ void set_Item(int aIndex, SimpleJSON_2020.JSONNode value);
        /*0xec1bf4*/ int get_Count();
        /*0xec1c44*/ void Add(string aKey, SimpleJSON_2020.JSONNode aItem);
        /*0xec1dac*/ SimpleJSON_2020.JSONNode Remove(string aKey);
        /*0xec1e70*/ SimpleJSON_2020.JSONNode Remove(int aIndex);
        /*0xec1f4c*/ SimpleJSON_2020.JSONNode Remove(SimpleJSON_2020.JSONNode aNode);
        /*0xec2114*/ SimpleJSON_2020.JSONNode Clone();
        /*0xec22d8*/ bool HasKey(string aKey);
        /*0xec2330*/ SimpleJSON_2020.JSONNode GetValueOrDefault(string aKey, SimpleJSON_2020.JSONNode aDefault);
        /*0xec23ac*/ System.Collections.Generic.IEnumerable<SimpleJSON_2020.JSONNode> get_Children();
        /*0xec2458*/ void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON_2020.JSONTextMode aMode);
        /*0xec2798*/ void SerializeBinary(System.IO.BinaryWriter aWriter);

        class <>c__DisplayClass21_0
        {
            /*0x10*/ SimpleJSON_2020.JSONNode aNode;

            /*0xec210c*/ <>c__DisplayClass21_0();
            /*0xec29b8*/ bool <Remove>b__0(System.Collections.Generic.KeyValuePair<string, SimpleJSON_2020.JSONNode> k);
        }

        class <get_Children>d__26 : System.Collections.Generic.IEnumerable<SimpleJSON_2020.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON_2020.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ SimpleJSON_2020.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ SimpleJSON_2020.JSONObject <>4__this;
            /*0x30*/ System.Collections.Generic.Dictionary.Enumerator<string, SimpleJSON_2020.JSONNode> <>7__wrap1;

            /*0xec2424*/ <get_Children>d__26(int <>1__state);
            /*0xec2a2c*/ void System.IDisposable.Dispose();
            /*0xec2a48*/ bool MoveNext();
            /*0xec2bf0*/ void <>m__Finally1();
            /*0xec2c40*/ SimpleJSON_2020.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON_2020.JSONNode>.get_Current();
            /*0xec2c48*/ void System.Collections.IEnumerator.Reset();
            /*0xec2c88*/ object System.Collections.IEnumerator.get_Current();
            /*0xec2c90*/ System.Collections.Generic.IEnumerator<SimpleJSON_2020.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON_2020.JSONNode>.GetEnumerator();
            /*0xec2d34*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }
    }

    class JSONString : SimpleJSON_2020.JSONNode
    {
        /*0x10*/ string m_Data;

        /*0xeba910*/ JSONString(string aData);
        /*0xec2d38*/ SimpleJSON_2020.JSONNodeType get_Tag();
        /*0xec2d40*/ bool get_IsString();
        /*0xec2d48*/ SimpleJSON_2020.JSONNode.Enumerator GetEnumerator();
        /*0xec2d5c*/ string get_Value();
        /*0xec2d64*/ void set_Value(string value);
        /*0xec2d6c*/ SimpleJSON_2020.JSONNode Clone();
        /*0xec2dd0*/ void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON_2020.JSONTextMode aMode);
        /*0xec2e70*/ bool Equals(object obj);
        /*0xec2f80*/ int GetHashCode();
        /*0xec2fa0*/ void SerializeBinary(System.IO.BinaryWriter aWriter);
    }

    class JSONNumber : SimpleJSON_2020.JSONNode
    {
        /*0x10*/ double m_Data;

        static /*0xec3258*/ bool IsNumeric(object value);
        /*0xebabe8*/ JSONNumber(double aData);
        /*0xec3140*/ JSONNumber(string aData);
        /*0xec2fec*/ SimpleJSON_2020.JSONNodeType get_Tag();
        /*0xec2ff4*/ bool get_IsNumber();
        /*0xec2ffc*/ SimpleJSON_2020.JSONNode.Enumerator GetEnumerator();
        /*0xec3010*/ string get_Value();
        /*0xec3078*/ void set_Value(string value);
        /*0xec3104*/ double get_AsDouble();
        /*0xec310c*/ void set_AsDouble(double value);
        /*0xec3114*/ long get_AsLong();
        /*0xec3134*/ void set_AsLong(long value);
        /*0xec31b8*/ SimpleJSON_2020.JSONNode Clone();
        /*0xec3224*/ void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON_2020.JSONTextMode aMode);
        /*0xec33f8*/ bool Equals(object obj);
        /*0xec351c*/ int GetHashCode();
        /*0xec358c*/ void SerializeBinary(System.IO.BinaryWriter aWriter);
    }

    class JSONBool : SimpleJSON_2020.JSONNode
    {
        /*0x10*/ bool m_Data;

        /*0xebb080*/ JSONBool(bool aData);
        /*0xec3698*/ JSONBool(string aData);
        /*0xec35d8*/ SimpleJSON_2020.JSONNodeType get_Tag();
        /*0xec35e0*/ bool get_IsBoolean();
        /*0xec35e8*/ SimpleJSON_2020.JSONNode.Enumerator GetEnumerator();
        /*0xec35fc*/ string get_Value();
        /*0xec3608*/ void set_Value(string value);
        /*0xec3684*/ bool get_AsBool();
        /*0xec368c*/ void set_AsBool(bool value);
        /*0xec3710*/ SimpleJSON_2020.JSONNode Clone();
        /*0xec3778*/ void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON_2020.JSONTextMode aMode);
        /*0xec37f0*/ bool Equals(object obj);
        /*0xec3868*/ int GetHashCode();
        /*0xec3874*/ void SerializeBinary(System.IO.BinaryWriter aWriter);
    }

    class JSONNull : SimpleJSON_2020.JSONNode
    {
        static /*0x0*/ SimpleJSON_2020.JSONNull m_StaticInstance;
        static /*0x8*/ bool reuseSameInstance;

        static /*0xec3ae0*/ JSONNull();
        static /*0xebb7c0*/ SimpleJSON_2020.JSONNull CreateOrGet();
        /*0xec38bc*/ JSONNull();
        /*0xec3914*/ SimpleJSON_2020.JSONNodeType get_Tag();
        /*0xec391c*/ bool get_IsNull();
        /*0xec3924*/ SimpleJSON_2020.JSONNode.Enumerator GetEnumerator();
        /*0xec3938*/ string get_Value();
        /*0xec3978*/ void set_Value(string value);
        /*0xec397c*/ bool get_AsBool();
        /*0xec3984*/ void set_AsBool(bool value);
        /*0xec3988*/ SimpleJSON_2020.JSONNode Clone();
        /*0xec39d4*/ bool Equals(object obj);
        /*0xec3a60*/ int GetHashCode();
        /*0xec3a68*/ void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON_2020.JSONTextMode aMode);
        /*0xec3abc*/ void SerializeBinary(System.IO.BinaryWriter aWriter);
    }

    class JSONLazyCreator : SimpleJSON_2020.JSONNode
    {
        /*0x10*/ SimpleJSON_2020.JSONNode m_Node;
        /*0x18*/ string m_Key;

        static /*0xec3ebc*/ bool op_Equality(SimpleJSON_2020.JSONLazyCreator a, object b);
        static /*0xec3ed4*/ bool op_Inequality(SimpleJSON_2020.JSONLazyCreator a, object b);
        /*0xec0914*/ JSONLazyCreator(SimpleJSON_2020.JSONNode aNode);
        /*0xec187c*/ JSONLazyCreator(SimpleJSON_2020.JSONNode aNode, string aKey);
        /*0xec3b50*/ SimpleJSON_2020.JSONNodeType get_Tag();
        /*0xec3b58*/ SimpleJSON_2020.JSONNode.Enumerator GetEnumerator();
        T Set<T>(T aVal);
        /*0xec3b6c*/ SimpleJSON_2020.JSONNode get_Item(int aIndex);
        /*0xec3bcc*/ void set_Item(int aIndex, SimpleJSON_2020.JSONNode value);
        /*0xec3c68*/ SimpleJSON_2020.JSONNode get_Item(string aKey);
        /*0xec3cd8*/ void set_Item(string aKey, SimpleJSON_2020.JSONNode value);
        /*0xec3d7c*/ void Add(SimpleJSON_2020.JSONNode aItem);
        /*0xec3e18*/ void Add(string aKey, SimpleJSON_2020.JSONNode aItem);
        /*0xec3eec*/ bool Equals(object obj);
        /*0xec3f04*/ int GetHashCode();
        /*0xec3f0c*/ int get_AsInt();
        /*0xec3f90*/ void set_AsInt(int value);
        /*0xec4018*/ float get_AsFloat();
        /*0xec409c*/ void set_AsFloat(float value);
        /*0xec4124*/ double get_AsDouble();
        /*0xec41a8*/ void set_AsDouble(double value);
        /*0xec4230*/ long get_AsLong();
        /*0xec4340*/ void set_AsLong(long value);
        /*0xec4474*/ bool get_AsBool();
        /*0xec44f8*/ void set_AsBool(bool value);
        /*0xec4580*/ SimpleJSON_2020.JSONArray get_AsArray();
        /*0xec45f8*/ SimpleJSON_2020.JSONObject get_AsObject();
        /*0xec4670*/ void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON_2020.JSONTextMode aMode);
        /*0xec46c4*/ void SerializeBinary(System.IO.BinaryWriter aWriter);
    }

    class JSON
    {
        static /*0xec46c8*/ SimpleJSON_2020.JSONNode Parse(string aJSON);
    }

    enum JSONContainerType
    {
        Array = 0,
        Object = 1,
    }
}

namespace GooglePlayGames
{
    class GameInfo
    {
        static string UnescapedApplicationId = "APP_ID";
        static string UnescapedWebClientId = "WEB_CLIENTID";
        static string UnescapedNearbyServiceId = "NEARBY_SERVICE_ID";
        static string ApplicationId = "__APP_ID__";
        static string WebClientId = "__WEB_CLIENTID__";
        static string NearbyConnectionServiceId = "__NEARBY_SERVICE_ID__";

        static /*0xec471c*/ bool ApplicationIdInitialized();
        static /*0xec47fc*/ bool WebClientIdInitialized();
        static /*0xec4890*/ bool NearbyConnectionsInitialized();
        static /*0xec47b0*/ string ToEscapedToken(string token);
    }

    class ReportProgress : System.MulticastDelegate
    {
        /*0xec4924*/ ReportProgress(object object, nint method);
        /*0xec49fc*/ void Invoke(string id, double progress, System.Action<bool> callback);
        /*0xec4a10*/ System.IAsyncResult BeginInvoke(string id, double progress, System.Action<bool> callback, System.AsyncCallback __callback, object object);
        /*0xec4aa8*/ void EndInvoke(System.IAsyncResult result);
    }

    class PlayGamesAchievement : UnityEngine.SocialPlatforms.IAchievement, UnityEngine.SocialPlatforms.IAchievementDescription
    {
        /*0x10*/ GooglePlayGames.ReportProgress mProgressCallback;
        /*0x18*/ string mId;
        /*0x20*/ bool mIsIncremental;
        /*0x24*/ int mCurrentSteps;
        /*0x28*/ int mTotalSteps;
        /*0x30*/ double mPercentComplete;
        /*0x38*/ bool mCompleted;
        /*0x39*/ bool mHidden;
        /*0x40*/ System.DateTime mLastModifiedTime;
        /*0x48*/ string mTitle;
        /*0x50*/ string mRevealedImageUrl;
        /*0x58*/ string mUnlockedImageUrl;
        /*0x60*/ UnityEngine.Networking.UnityWebRequest mImageFetcher;
        /*0x68*/ UnityEngine.Texture2D mImage;
        /*0x70*/ string mDescription;
        /*0x78*/ ulong mPoints;

        /*0xec4ab4*/ PlayGamesAchievement();
        /*0xec4c24*/ PlayGamesAchievement(GooglePlayGames.ReportProgress progressCallback);
        /*0xec4ce4*/ PlayGamesAchievement(GooglePlayGames.BasicApi.Achievement ach);
        /*0xec4dbc*/ void ReportProgress(System.Action<bool> callback);
        /*0xec4dec*/ UnityEngine.Texture2D LoadImage();
        /*0xec4f04*/ string get_id();
        /*0xec4f0c*/ void set_id(string value);
        /*0xec4f14*/ bool get_isIncremental();
        /*0xec4f1c*/ int get_currentSteps();
        /*0xec4f24*/ int get_totalSteps();
        /*0xec4f2c*/ double get_percentCompleted();
        /*0xec4f34*/ void set_percentCompleted(double value);
        /*0xec4f3c*/ bool get_completed();
        /*0xec4f44*/ bool get_hidden();
        /*0xec4f4c*/ System.DateTime get_lastReportedDate();
        /*0xec4f54*/ string get_title();
        /*0xec4f5c*/ UnityEngine.Texture2D get_image();
        /*0xec4f60*/ string get_achievedDescription();
        /*0xec4f68*/ string get_unachievedDescription();
        /*0xec4f70*/ int get_points();
    }

    class PlayGamesLeaderboard : UnityEngine.SocialPlatforms.ILeaderboard
    {
        /*0x10*/ string mId;
        /*0x18*/ UnityEngine.SocialPlatforms.UserScope mUserScope;
        /*0x1c*/ UnityEngine.SocialPlatforms.Range mRange;
        /*0x24*/ UnityEngine.SocialPlatforms.TimeScope mTimeScope;
        /*0x28*/ string[] mFilteredUserIds;
        /*0x30*/ bool mLoading;
        /*0x38*/ UnityEngine.SocialPlatforms.IScore mLocalUserScore;
        /*0x40*/ uint mMaxRange;
        /*0x48*/ System.Collections.Generic.List<GooglePlayGames.PlayGamesScore> mScoreList;
        /*0x50*/ string mTitle;

        /*0xec4f78*/ PlayGamesLeaderboard(string id);
        /*0xec5008*/ void SetUserFilter(string[] userIDs);
        /*0xec5010*/ void LoadScores(System.Action<bool> callback);
        /*0xec5620*/ bool get_loading();
        /*0xec5628*/ void set_loading(bool value);
        /*0xec5634*/ string get_id();
        /*0xec563c*/ void set_id(string value);
        /*0xec5644*/ UnityEngine.SocialPlatforms.UserScope get_userScope();
        /*0xec564c*/ void set_userScope(UnityEngine.SocialPlatforms.UserScope value);
        /*0xec5654*/ UnityEngine.SocialPlatforms.Range get_range();
        /*0xec565c*/ void set_range(UnityEngine.SocialPlatforms.Range value);
        /*0xec5664*/ UnityEngine.SocialPlatforms.TimeScope get_timeScope();
        /*0xec566c*/ void set_timeScope(UnityEngine.SocialPlatforms.TimeScope value);
        /*0xec5674*/ UnityEngine.SocialPlatforms.IScore get_localUserScore();
        /*0xec567c*/ uint get_maxRange();
        /*0xec5684*/ UnityEngine.SocialPlatforms.IScore[] get_scores();
        /*0xec571c*/ string get_title();
        /*0xec5724*/ bool SetFromData(GooglePlayGames.BasicApi.LeaderboardScoreData data);
        /*0xec5918*/ void SetMaxRange(ulong val);
        /*0xec5aac*/ void SetTitle(string value);
        /*0xec5ab4*/ void SetLocalUserScore(GooglePlayGames.PlayGamesScore score);
        /*0xec5920*/ int AddScore(GooglePlayGames.PlayGamesScore score);
        /*0xec5abc*/ int get_ScoreCount();
        /*0xec5a44*/ bool HasAllScores();
    }

    class PlayGamesLocalUser : GooglePlayGames.PlayGamesUserProfile, UnityEngine.SocialPlatforms.ILocalUser, UnityEngine.SocialPlatforms.IUserProfile
    {
        /*0x38*/ GooglePlayGames.PlayGamesPlatform mPlatform;
        /*0x40*/ string emailAddress;
        /*0x48*/ GooglePlayGames.BasicApi.PlayerStats mStats;

        /*0xec5b04*/ PlayGamesLocalUser(GooglePlayGames.PlayGamesPlatform plaf);
        /*0xec5b8c*/ void Authenticate(System.Action<bool> callback);
        /*0xec5bb0*/ void Authenticate(System.Action<bool, string> callback);
        /*0xec5bd4*/ void Authenticate(System.Action<bool> callback, bool silent);
        /*0xec5cb4*/ void Authenticate(System.Action<bool, string> callback, bool silent);
        /*0xec5d9c*/ void LoadFriends(System.Action<bool> callback);
        /*0xec5ee0*/ UnityEngine.SocialPlatforms.IUserProfile[] get_friends();
        /*0xec6014*/ string GetIdToken();
        /*0xec6120*/ bool get_authenticated();
        /*0xec61e8*/ bool get_underage();
        /*0xec61f0*/ string get_userName();
        /*0xec65f4*/ string get_id();
        /*0xec66bc*/ bool get_isFriend();
        /*0xec66c4*/ UnityEngine.SocialPlatforms.UserState get_state();
        /*0xec66cc*/ string get_AvatarURL();
        /*0xec6794*/ string get_Email();
        /*0xec68e4*/ void GetStats(System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback);

        class <>c__DisplayClass28_0
        {
            /*0x10*/ GooglePlayGames.PlayGamesLocalUser <>4__this;
            /*0x18*/ System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback;

            /*0xec69dc*/ <>c__DisplayClass28_0();
            /*0xec6b98*/ void <GetStats>b__0(GooglePlayGames.BasicApi.CommonStatusCodes rc, GooglePlayGames.BasicApi.PlayerStats stats);
        }
    }

    class PlayGamesPlatform : UnityEngine.SocialPlatforms.ISocialPlatform
    {
        static /*0x0*/ GooglePlayGames.PlayGamesPlatform sInstance;
        static /*0x8*/ bool sNearbyInitializePending;
        static /*0x10*/ GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient sNearbyConnectionClient;
        /*0x10*/ GooglePlayGames.BasicApi.PlayGamesClientConfiguration mConfiguration;
        /*0x40*/ GooglePlayGames.PlayGamesLocalUser mLocalUser;
        /*0x48*/ GooglePlayGames.BasicApi.IPlayGamesClient mClient;
        /*0x50*/ string mDefaultLbUi;
        /*0x58*/ System.Collections.Generic.Dictionary<string, string> mIdMap;

        static /*0xec6dfc*/ bool get_DebugLogEnabled();
        static /*0xec6e84*/ void set_DebugLogEnabled(bool value);
        static /*0xec4b30*/ GooglePlayGames.PlayGamesPlatform get_Instance();
        static /*0xec7098*/ GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient get_Nearby();
        static /*0xec6f14*/ void InitializeInstance(GooglePlayGames.BasicApi.PlayGamesClientConfiguration configuration);
        static /*0xec712c*/ void InitializeNearby(System.Action<GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient> callback);
        static /*0xec762c*/ GooglePlayGames.PlayGamesPlatform Activate();
        static System.Action<T> ToOnGameThread<T>(System.Action<T> toConvert);
        /*0xec6bc8*/ PlayGamesPlatform(GooglePlayGames.BasicApi.IPlayGamesClient client);
        /*0xec6ce4*/ PlayGamesPlatform(GooglePlayGames.BasicApi.PlayGamesClientConfiguration configuration);
        /*0xec72f0*/ GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient get_RealTime();
        /*0xec7394*/ GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient get_TurnBased();
        /*0xec7438*/ GooglePlayGames.BasicApi.SavedGame.ISavedGameClient get_SavedGame();
        /*0xec74dc*/ GooglePlayGames.BasicApi.Events.IEventsClient get_Events();
        /*0xec7580*/ GooglePlayGames.BasicApi.Video.IVideoClient get_Video();
        /*0xec7624*/ UnityEngine.SocialPlatforms.ILocalUser get_localUser();
        /*0xec7710*/ void SetGravityForPopups(GooglePlayGames.BasicApi.Gravity gravity);
        /*0xec77bc*/ void AddIdMapping(string fromId, string toId);
        /*0xec5ba8*/ void Authenticate(System.Action<bool> callback);
        /*0xec5bcc*/ void Authenticate(System.Action<bool, string> callback);
        /*0xec5bf0*/ void Authenticate(System.Action<bool> callback, bool silent);
        /*0xec5cd0*/ void Authenticate(System.Action<bool, string> callback, bool silent);
        /*0xec7824*/ void Authenticate(GooglePlayGames.BasicApi.SignInInteractivity signInInteractivity, System.Action<GooglePlayGames.BasicApi.SignInStatus> callback);
        /*0xec7c04*/ void Authenticate(UnityEngine.SocialPlatforms.ILocalUser unused, System.Action<bool> callback);
        /*0xec7c10*/ void Authenticate(UnityEngine.SocialPlatforms.ILocalUser unused, System.Action<bool, string> callback);
        /*0xec6138*/ bool IsAuthenticated();
        /*0xec7c1c*/ void SignOut();
        /*0xec7cf4*/ void LoadUsers(string[] userIds, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback);
        /*0xec63d8*/ string GetUserId();
        /*0xec602c*/ string GetIdToken();
        /*0xec7e44*/ string GetServerAuthCode();
        /*0xec7f60*/ void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback);
        /*0xec6840*/ string GetUserEmail();
        /*0xec69e4*/ void GetPlayerStats(System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback);
        /*0xec62b8*/ string GetUserDisplayName();
        /*0xec64f0*/ string GetUserImageUrl();
        /*0xec81d4*/ void ReportProgress(string achievementID, double progress, System.Action<bool> callback);
        /*0xec8638*/ void RevealAchievement(string achievementID, System.Action<bool> callback);
        /*0xec87d0*/ void UnlockAchievement(string achievementID, System.Action<bool> callback);
        /*0xec8968*/ void IncrementAchievement(string achievementID, int steps, System.Action<bool> callback);
        /*0xec8b38*/ void SetStepsAtLeast(string achievementID, int steps, System.Action<bool> callback);
        /*0xec8d08*/ void LoadAchievementDescriptions(System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback);
        /*0xec8eb0*/ void LoadAchievements(System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback);
        /*0xec9048*/ UnityEngine.SocialPlatforms.IAchievement CreateAchievement();
        /*0xec90a0*/ void ReportScore(long score, string board, System.Action<bool> callback);
        /*0xec9270*/ void ReportScore(long score, string board, string metadata, System.Action<bool> callback);
        /*0xec958c*/ void LoadScores(string leaderboardId, System.Action<UnityEngine.SocialPlatforms.IScore[]> callback);
        /*0xec96e0*/ void LoadScores(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback);
        /*0xec987c*/ void LoadMoreScores(GooglePlayGames.BasicApi.ScorePageToken token, int rowCount, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback);
        /*0xec99f0*/ UnityEngine.SocialPlatforms.ILeaderboard CreateLeaderboard();
        /*0xec9a54*/ void ShowAchievementsUI();
        /*0xec9a5c*/ void ShowAchievementsUI(System.Action<GooglePlayGames.BasicApi.UIStatus> callback);
        /*0xec9bd4*/ void ShowLeaderboardUI();
        /*0xec9c6c*/ void ShowLeaderboardUI(string leaderboardId);
        /*0xec9c60*/ void ShowLeaderboardUI(string leaderboardId, System.Action<GooglePlayGames.BasicApi.UIStatus> callback);
        /*0xec9d34*/ void ShowLeaderboardUI(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardTimeSpan span, System.Action<GooglePlayGames.BasicApi.UIStatus> callback);
        /*0xec9f14*/ void SetDefaultLeaderboardForUI(string lbid);
        /*0xec5db8*/ void LoadFriends(UnityEngine.SocialPlatforms.ILocalUser user, System.Action<bool> callback);
        /*0xec5040*/ void LoadScores(UnityEngine.SocialPlatforms.ILeaderboard board, System.Action<bool> callback);
        /*0xec9fc4*/ void RequestPermission(string scope, System.Action<GooglePlayGames.BasicApi.SignInStatus> callback);
        /*0xeca06c*/ void RequestPermissions(string[] scopes, System.Action<GooglePlayGames.BasicApi.SignInStatus> callback);
        /*0xeca19c*/ bool HasPermission(string scope);
        /*0xeca23c*/ bool HasPermissions(string[] scopes);
        /*0xeca348*/ bool GetLoading(UnityEngine.SocialPlatforms.ILeaderboard board);
        /*0xeca3f0*/ void RegisterInvitationDelegate(GooglePlayGames.BasicApi.InvitationReceivedDelegate deleg);
        /*0xeca49c*/ void HandleLoadingScores(GooglePlayGames.PlayGamesLeaderboard board, GooglePlayGames.BasicApi.LeaderboardScoreData scoreData, System.Action<bool> callback);
        /*0xec5ef8*/ UnityEngine.SocialPlatforms.IUserProfile[] GetFriends();
        /*0xec851c*/ string MapId(string id);

        class <>c__DisplayClass30_0
        {
            /*0x10*/ System.Action<GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient> callback;

            /*0xe19db0*/ <>c__DisplayClass30_0();
            /*0xe19db8*/ void <InitializeNearby>b__0(GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient client);
        }

        class <>c__DisplayClass36_0
        {
            /*0x10*/ System.Action<bool> callback;

            /*0xe19eac*/ <>c__DisplayClass36_0();
            /*0xe19eb4*/ void <Authenticate>b__0(bool success, string msg);
        }

        class <>c__DisplayClass37_0
        {
            /*0x10*/ System.Action<bool, string> callback;

            /*0xe19edc*/ <>c__DisplayClass37_0();
            /*0xe19ee4*/ void <Authenticate>b__0(GooglePlayGames.BasicApi.SignInStatus status);
        }

        class <>c__DisplayClass38_0
        {
            /*0x10*/ System.Action<GooglePlayGames.BasicApi.SignInStatus> callback;
            /*0x18*/ GooglePlayGames.PlayGamesPlatform <>4__this;
            /*0x20*/ System.Action<GooglePlayGames.BasicApi.SignInStatus> <>9__5;

            /*0xe1a000*/ <>c__DisplayClass38_0();
            /*0xe1a008*/ void <Authenticate>b__1(GooglePlayGames.BasicApi.SignInStatus code);
            /*0xe1a070*/ void <Authenticate>b__2(GooglePlayGames.BasicApi.SignInStatus code);
            /*0xe1a0d8*/ void <Authenticate>b__3(GooglePlayGames.BasicApi.SignInStatus silentSignInResultCode);
            /*0xe1a320*/ void <Authenticate>b__5(GooglePlayGames.BasicApi.SignInStatus interactiveSignInResultCode);
            /*0xe1a3f0*/ void <Authenticate>b__4();
        }

        class <>c
        {
            static /*0x0*/ GooglePlayGames.PlayGamesPlatform.<> <>9;
            static /*0x8*/ System.Action<GooglePlayGames.BasicApi.SignInStatus> <>9__38_0;

            static /*0xe1a418*/ <>c();
            /*0xe1a47c*/ <>c();
            /*0xe1a484*/ void <Authenticate>b__38_0(GooglePlayGames.BasicApi.SignInStatus status);
        }

        class <>c__DisplayClass47_0
        {
            /*0x10*/ System.Action<string> callback;
            /*0x18*/ GooglePlayGames.PlayGamesPlatform <>4__this;

            /*0xe1a488*/ <>c__DisplayClass47_0();
            /*0xe1a490*/ void <GetAnotherServerAuthCode>b__0(GooglePlayGames.BasicApi.SignInStatus status);
        }

        class <>c__DisplayClass52_0
        {
            /*0x10*/ string achievementID;
            /*0x18*/ double progress;
            /*0x20*/ GooglePlayGames.PlayGamesPlatform <>4__this;
            /*0x28*/ System.Action<bool> callback;

            /*0xe1a630*/ <>c__DisplayClass52_0();
            /*0xe1a638*/ void <ReportProgress>b__0(GooglePlayGames.BasicApi.Achievement[] ach);
        }

        class <>c__DisplayClass57_0
        {
            /*0x10*/ System.Action<UnityEngine.SocialPlatforms.IAchievementDescription[]> callback;

            /*0xe1ab50*/ <>c__DisplayClass57_0();
            /*0xe1ab58*/ void <LoadAchievementDescriptions>b__0(GooglePlayGames.BasicApi.Achievement[] ach);
        }

        class <>c__DisplayClass58_0
        {
            /*0x10*/ System.Action<UnityEngine.SocialPlatforms.IAchievement[]> callback;

            /*0xe1ac80*/ <>c__DisplayClass58_0();
            /*0xe1ac88*/ void <LoadAchievements>b__0(GooglePlayGames.BasicApi.Achievement[] ach);
        }

        class <>c__DisplayClass62_0
        {
            /*0x10*/ System.Action<UnityEngine.SocialPlatforms.IScore[]> callback;

            /*0xe1adb0*/ <>c__DisplayClass62_0();
            /*0xe1adb8*/ void <LoadScores>b__0(GooglePlayGames.BasicApi.LeaderboardScoreData scoreData);
        }

        class <>c__DisplayClass74_0
        {
            /*0x10*/ GooglePlayGames.PlayGamesPlatform <>4__this;
            /*0x18*/ UnityEngine.SocialPlatforms.ILeaderboard board;
            /*0x20*/ System.Action<bool> callback;

            /*0xe1adf0*/ <>c__DisplayClass74_0();
            /*0xe1adf8*/ void <LoadScores>b__0(GooglePlayGames.BasicApi.LeaderboardScoreData scoreData);
        }

        class <>c__DisplayClass81_0
        {
            /*0x10*/ GooglePlayGames.PlayGamesPlatform <>4__this;
            /*0x18*/ GooglePlayGames.PlayGamesLeaderboard board;
            /*0x20*/ System.Action<bool> callback;

            /*0xe1ae90*/ <>c__DisplayClass81_0();
            /*0xe1ae98*/ void <HandleLoadingScores>b__0(GooglePlayGames.BasicApi.LeaderboardScoreData nextScoreData);
        }

        class <>c__DisplayClass84_0<T>
        {
            /*0x0*/ System.Action<T> toConvert;

            <>c__DisplayClass84_0();
            void <ToOnGameThread>b__1(T val);
        }

        class <>c__DisplayClass84_<T>
        {
            /*0x0*/ T val;
            /*0x0*/ GooglePlayGames.PlayGamesPlatform.<>c__DisplayClass84_0<T> CS$<>8__locals1;

            <>c__DisplayClass84_();
            void <ToOnGameThread>b__2();
        }

        class <>c__84<T>
        {
            static /*0x0*/ GooglePlayGames.PlayGamesPlatform.<>c__84<T> <>9;
            static /*0x0*/ System.Action<T> <>9__84_0;

            static <>c__84();
            <>c__84();
            void <ToOnGameThread>b__84_0(T <p0>);
        }
    }

    class PlayGamesScore : UnityEngine.SocialPlatforms.IScore
    {
        /*0x10*/ string mLbId;
        /*0x18*/ long mValue;
        /*0x20*/ ulong mRank;
        /*0x28*/ string mPlayerId;
        /*0x30*/ string mMetadata;
        /*0x38*/ System.DateTime mDate;

        /*0xe1aec0*/ PlayGamesScore(System.DateTime date, string leaderboardId, ulong rank, string playerId, ulong value, string metadata);
        /*0xe1af84*/ void ReportScore(System.Action<bool> callback);
        /*0xe1afc0*/ string get_leaderboardID();
        /*0xe1afc8*/ void set_leaderboardID(string value);
        /*0xe1afd0*/ long get_value();
        /*0xe1afd8*/ void set_value(long value);
        /*0xe1afe0*/ System.DateTime get_date();
        /*0xe1afe8*/ string get_formattedValue();
        /*0xe1aff4*/ string get_userID();
        /*0xe1affc*/ int get_rank();
        /*0xe1b004*/ string get_metaData();
    }

    class PlayGamesUserProfile : UnityEngine.SocialPlatforms.IUserProfile
    {
        /*0x10*/ string mDisplayName;
        /*0x18*/ string mPlayerId;
        /*0x20*/ string mAvatarUrl;
        /*0x28*/ bool mImageLoading;
        /*0x30*/ UnityEngine.Texture2D mImage;

        /*0xe1b00c*/ PlayGamesUserProfile(string displayName, string playerId, string avatarUrl);
        /*0xe1b110*/ void ResetIdentity(string displayName, string playerId, string avatarUrl);
        /*0xe1b15c*/ string get_userName();
        /*0xe1b164*/ string get_id();
        /*0xe1b16c*/ string get_gameId();
        /*0xe1b174*/ bool get_isFriend();
        /*0xe1b17c*/ UnityEngine.SocialPlatforms.UserState get_state();
        /*0xe1b184*/ UnityEngine.Texture2D get_image();
        /*0xe1b31c*/ string get_AvatarURL();
        /*0xe1b2b4*/ System.Collections.IEnumerator LoadImage();
        /*0xe1b34c*/ bool Equals(object obj);
        /*0xe1b46c*/ int GetHashCode();
        /*0xe1b51c*/ string ToString();
        /*0xe1b058*/ void setAvatarUrl(string avatarUrl);

        class <LoadImage>d__21 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ GooglePlayGames.PlayGamesUserProfile <>4__this;
            /*0x28*/ UnityEngine.Networking.UnityWebRequest <www>5__2;

            /*0xe1b324*/ <LoadImage>d__21(int <>1__state);
            /*0xe1b568*/ void System.IDisposable.Dispose();
            /*0xe1b56c*/ bool MoveNext();
            /*0xe1b730*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0xe1b738*/ void System.Collections.IEnumerator.Reset();
            /*0xe1b778*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class NearbyConnectionClientFactory
    {
        static /*0xe1b780*/ void Create(System.Action<GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient> callback);
    }

    class PlayGamesClientFactory
    {
        static /*0xe1bb10*/ GooglePlayGames.BasicApi.IPlayGamesClient GetPlatformPlayGamesClient(GooglePlayGames.BasicApi.PlayGamesClientConfiguration config);
        /*0xe1bdc4*/ PlayGamesClientFactory();
    }

    interface TokenClient
    {
        string GetEmail();
        string GetAuthCode();
        string GetIdToken();
        void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback);
        void Signout();
        void SetRequestAuthCode(bool flag, bool forceRefresh);
        void SetRequestEmail(bool flag);
        void SetRequestIdToken(bool flag);
        void SetWebClientId(string webClientId);
        void SetAccountName(string accountName);
        void AddOauthScopes(string[] scopes);
        void SetHidePopups(bool flag);
        void FetchTokens(bool silent, System.Action<int> callback);
        void RequestPermissions(string[] scopes, System.Action<GooglePlayGames.BasicApi.SignInStatus> callback);
        bool HasPermissions(string[] scopes);
    }

    class PluginVersion
    {
        static int VersionInt = 4105;
        static string VersionString = "0.10.09";
        static string VersionKey = "01009";

        /*0xe1bdcc*/ PluginVersion();
    }

    namespace Android
    {
        class AndroidClient : GooglePlayGames.BasicApi.IPlayGamesClient
        {
            static /*0x0*/ string TasksClassName;
            /*0x10*/ object GameServicesLock;
            /*0x18*/ object AuthStateLock;
            /*0x20*/ GooglePlayGames.BasicApi.PlayGamesClientConfiguration mConfiguration;
            /*0x50*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient mTurnBasedClient;
            /*0x58*/ GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient mRealTimeClient;
            /*0x60*/ GooglePlayGames.BasicApi.SavedGame.ISavedGameClient mSavedGameClient;
            /*0x68*/ GooglePlayGames.BasicApi.Events.IEventsClient mEventsClient;
            /*0x70*/ GooglePlayGames.BasicApi.Video.IVideoClient mVideoClient;
            /*0x78*/ GooglePlayGames.Android.AndroidTokenClient mTokenClient;
            /*0x80*/ System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation, bool> mInvitationDelegate;
            /*0x88*/ GooglePlayGames.BasicApi.Multiplayer.Player mUser;
            /*0x90*/ GooglePlayGames.Android.AndroidClient.AuthState mAuthState;
            /*0x98*/ UnityEngine.AndroidJavaClass mGamesClass;
            /*0xa0*/ UnityEngine.AndroidJavaObject mInvitationCallback;
            /*0xa8*/ int mLeaderboardMaxResults;

            static /*0xe24ba8*/ AndroidClient();
            static System.Action<T> AsOnGameThreadCallback<T>(System.Action<T> callback);
            static /*0xe1c514*/ void InvokeCallbackOnGameThread(System.Action callback);
            static void InvokeCallbackOnGameThread<T>(System.Action<T> callback, T data);
            static System.Action<T1, T2> AsOnGameThreadCallback<T1, T2>(System.Action<T1, T2> toInvokeOnGameThread);
            static void InvokeCallbackOnGameThread<T1, T2>(System.Action<T1, T2> callback, T1 t1, T2 t2);
            /*0xe1bc44*/ AndroidClient(GooglePlayGames.BasicApi.PlayGamesClientConfiguration configuration);
            /*0xe1bee8*/ void Authenticate(bool silent, System.Action<GooglePlayGames.BasicApi.SignInStatus> callback);
            /*0xe1c600*/ void InitializeGameServices();
            /*0xe1c170*/ void InitializeTokenClient();
            /*0xe1c700*/ string GetUserEmail();
            /*0xe1c868*/ string GetIdToken();
            /*0xe1c900*/ string GetServerAuthCode();
            /*0xe1c998*/ void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback);
            /*0xe1c798*/ bool IsAuthenticated();
            /*0xe1cb24*/ void LoadFriends(System.Action<bool> callback);
            /*0xe1cc08*/ UnityEngine.SocialPlatforms.IUserProfile[] GetFriends();
            /*0xe1cc4c*/ void SignOut();
            /*0xe1cc54*/ void SignOut(System.Action uiCallback);
            /*0xe1d410*/ string GetUserId();
            /*0xe1d450*/ string GetUserDisplayName();
            /*0xe1d490*/ string GetUserImageUrl();
            /*0xe1d4d0*/ void SetGravityForPopups(GooglePlayGames.BasicApi.Gravity gravity);
            /*0xe1d8e0*/ void GetPlayerStats(System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback);
            /*0xe1df20*/ void LoadUsers(string[] userIds, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback);
            /*0xe1e6a4*/ void LoadAchievements(System.Action<GooglePlayGames.BasicApi.Achievement[]> callback);
            /*0xe1ec24*/ void UnlockAchievement(string achId, System.Action<bool> callback);
            /*0xe1eeb8*/ void RevealAchievement(string achId, System.Action<bool> callback);
            /*0xe1f14c*/ void IncrementAchievement(string achId, int steps, System.Action<bool> callback);
            /*0xe1f454*/ void SetStepsAtLeast(string achId, int steps, System.Action<bool> callback);
            /*0xe1f75c*/ void ShowAchievementsUI(System.Action<GooglePlayGames.BasicApi.UIStatus> callback);
            /*0xe1fd50*/ int LeaderboardMaxResults();
            /*0xe1fd58*/ void ShowLeaderboardUI(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardTimeSpan span, System.Action<GooglePlayGames.BasicApi.UIStatus> callback);
            /*0xe1de60*/ void AddOnFailureListenerWithSignOut(UnityEngine.AndroidJavaObject task, System.Action<UnityEngine.AndroidJavaObject> callback);
            /*0xe1f7f4*/ System.Action<GooglePlayGames.BasicApi.UIStatus> GetUiSignOutCallbackOnGameThread(System.Action<GooglePlayGames.BasicApi.UIStatus> callback);
            /*0xe2094c*/ void LoadScores(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback);
            /*0xe21060*/ void LoadMoreScores(GooglePlayGames.BasicApi.ScorePageToken token, int rowCount, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback);
            /*0xe215c0*/ GooglePlayGames.BasicApi.LeaderboardScoreData CreateLeaderboardScoreData(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timespan, GooglePlayGames.BasicApi.ResponseStatus status, UnityEngine.AndroidJavaObject leaderboardScoresJava);
            /*0xe2278c*/ void SubmitScore(string leaderboardId, long score, System.Action<bool> callback);
            /*0xe22a80*/ void SubmitScore(string leaderboardId, long score, string metadata, System.Action<bool> callback);
            /*0xe22dbc*/ void RequestPermissions(string[] scopes, System.Action<GooglePlayGames.BasicApi.SignInStatus> callback);
            /*0xe234e0*/ void UpdateClients();
            /*0xe240c8*/ bool HasPermissions(string[] scopes);
            /*0xe244c0*/ GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient GetRtmpClient();
            /*0xe24598*/ GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient GetTbmpClient();
            /*0xe24660*/ GooglePlayGames.BasicApi.SavedGame.ISavedGameClient GetSavedGameClient();
            /*0xe24728*/ GooglePlayGames.BasicApi.Events.IEventsClient GetEventsClient();
            /*0xe247f0*/ GooglePlayGames.BasicApi.Video.IVideoClient GetVideoClient();
            /*0xe1bdd4*/ void RegisterInvitationDelegate(GooglePlayGames.BasicApi.InvitationReceivedDelegate invitationDelegate);
            /*0xe1eb10*/ UnityEngine.AndroidJavaObject getAchievementsClient();
            /*0xe1d7cc*/ UnityEngine.AndroidJavaObject getGamesClient();
            /*0xe1d1f4*/ UnityEngine.AndroidJavaObject getInvitationsClient();
            /*0xe1e588*/ UnityEngine.AndroidJavaObject getPlayersClient();
            /*0xe20f2c*/ UnityEngine.AndroidJavaObject getLeaderboardsClient();
            /*0xe1dd4c*/ UnityEngine.AndroidJavaObject getPlayerStatsClient();
            /*0xe24a94*/ UnityEngine.AndroidJavaObject getVideosClient();

            enum AuthState
            {
                Unauthenticated = 0,
                Authenticated = 1,
            }

            class InvitationCallbackProxy : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation, bool> mInvitationDelegate;

                /*0xe24c08*/ InvitationCallbackProxy(System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation, bool> invitationDelegate);
                /*0xe24c8c*/ void onInvitationReceived(UnityEngine.AndroidJavaObject invitation);
                /*0xe25144*/ void onInvitationRemoved(string invitationId);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidClient <>4__this;
                /*0x18*/ System.Action<GooglePlayGames.BasicApi.SignInStatus> callback;

                /*0xe1c168*/ <>c__DisplayClass18_0();
                /*0xe25148*/ void <Authenticate>b__0(int result);
            }

            class <>c__DisplayClass18_1
            {
                /*0x10*/ UnityEngine.AndroidJavaObject taskGetPlayer;
                /*0x18*/ UnityEngine.AndroidJavaObject taskIsCaptureSupported;
                /*0x20*/ UnityEngine.AndroidJavaObject taskGetActivationHint;
                /*0x28*/ GooglePlayGames.Android.AndroidClient.<> CS$<>8__locals1;

                /*0xe26408*/ <>c__DisplayClass18_1();
                /*0xe26784*/ void <Authenticate>b__1(UnityEngine.AndroidJavaObject completeTask);
            }

            class <>c
            {
                static /*0x0*/ GooglePlayGames.Android.AndroidClient.<> <>9;
                static /*0x8*/ System.Action<GooglePlayGames.BasicApi.Achievement[]> <>9__18_2;
                static /*0x10*/ System.Action <>9__34_0;

                static /*0xe28500*/ <>c();
                /*0xe28564*/ <>c();
                /*0xe2856c*/ void <Authenticate>b__18_2(GooglePlayGames.BasicApi.Achievement[] ignore);
                /*0xe28570*/ void <SignOut>b__34_0();
            }

            class <>c__DisplayClass19_0<T>
            {
                /*0x0*/ System.Action<T> callback;

                <>c__DisplayClass19_0();
                void <AsOnGameThreadCallback>b__1(T result);
            }

            class <>c__19<T>
            {
                static /*0x0*/ GooglePlayGames.Android.AndroidClient.<>c__19<T> <>9;
                static /*0x0*/ System.Action<T> <>9__19_0;

                static <>c__19();
                <>c__19();
                void <AsOnGameThreadCallback>b__19_0(T <p0>);
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ System.Action callback;

                /*0xe1c5f8*/ <>c__DisplayClass20_0();
                /*0xe285c4*/ void <InvokeCallbackOnGameThread>b__0();
            }

            class <>c__DisplayClass21_0<T>
            {
                /*0x0*/ System.Action<T> callback;
                /*0x0*/ T data;

                <>c__DisplayClass21_0();
                void <InvokeCallbackOnGameThread>b__0();
            }

            class <>c__DisplayClass22_0<T1, T2>
            {
                /*0x0*/ System.Action<T1, T2> toInvokeOnGameThread;

                <>c__DisplayClass22_0();
                void <AsOnGameThreadCallback>b__0(T1 result1, T2 result2);
            }

            class <>c__DisplayClass22_1<T1, T2>
            {
                /*0x0*/ T1 result1;
                /*0x0*/ T2 result2;
                /*0x0*/ GooglePlayGames.Android.AndroidClient.<>c__DisplayClass22_0<T1, T2> CS$<>8__locals1;

                <>c__DisplayClass22_1();
                void <AsOnGameThreadCallback>b__1();
            }

            class <>c__DisplayClass23_0<T1, T2>
            {
                /*0x0*/ System.Action<T1, T2> callback;
                /*0x0*/ T1 t1;
                /*0x0*/ T2 t2;

                <>c__DisplayClass23_0();
                void <InvokeCallbackOnGameThread>b__0();
            }

            class <>c__DisplayClass34_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidClient <>4__this;
                /*0x18*/ System.Action uiCallback;

                /*0xe1d1ec*/ <>c__DisplayClass34_0();
                /*0xe285e8*/ void <SignOut>b__1(UnityEngine.AndroidJavaObject completedTask);
            }

            class <>c__DisplayClass39_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback;
                /*0x18*/ GooglePlayGames.Android.AndroidClient <>4__this;

                /*0xe1dd44*/ <>c__DisplayClass39_0();
                /*0xe28684*/ void <GetPlayerStats>b__0(UnityEngine.AndroidJavaObject annotatedData);
                /*0xe28df4*/ void <GetPlayerStats>b__1(UnityEngine.AndroidJavaObject e);
            }

            class <>c__DisplayClass40_0
            {
                /*0x10*/ string[] userIds;
                /*0x18*/ System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback;
                /*0x20*/ UnityEngine.SocialPlatforms.IUserProfile[] users;
                /*0x28*/ int count;
                /*0x30*/ object countLock;
                /*0x38*/ int resultCount;
                /*0x40*/ System.Action<UnityEngine.AndroidJavaObject> <>9__0;

                /*0xe1e580*/ <>c__DisplayClass40_0();
                /*0xe28fb4*/ void <LoadUsers>b__0(UnityEngine.AndroidJavaObject annotatedData);
            }

            class <>c__DisplayClass40_1
            {
                /*0x10*/ int i;
                /*0x18*/ GooglePlayGames.Android.AndroidClient.<> CS$<>8__locals1;

                /*0xe1e69c*/ <>c__DisplayClass40_1();
                /*0xe29418*/ void <LoadUsers>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass41_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.Achievement[]> callback;

                /*0xe1eb08*/ <>c__DisplayClass41_0();
                /*0xe2969c*/ void <LoadAchievements>b__0(UnityEngine.AndroidJavaObject annotatedData);
                /*0xe2a21c*/ void <LoadAchievements>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass49_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidClient <>4__this;
                /*0x18*/ System.Action<UnityEngine.AndroidJavaObject> callback;

                /*0xe207b8*/ <>c__DisplayClass49_0();
                /*0xe2a3c0*/ void <AddOnFailureListenerWithSignOut>b__0(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass50_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidClient <>4__this;
                /*0x18*/ System.Action<GooglePlayGames.BasicApi.UIStatus> callback;

                /*0xe20944*/ <>c__DisplayClass50_0();
                /*0xe2a4c8*/ void <GetUiSignOutCallbackOnGameThread>b__0(GooglePlayGames.BasicApi.UIStatus status);
            }

            class <>c__DisplayClass50_1
            {
                /*0x10*/ GooglePlayGames.BasicApi.UIStatus status;
                /*0x18*/ GooglePlayGames.Android.AndroidClient.<> CS$<>8__locals1;

                /*0xe2a5d0*/ <>c__DisplayClass50_1();
                /*0xe2a5d8*/ void <GetUiSignOutCallbackOnGameThread>b__1();
            }

            class <>c__DisplayClass51_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback;
                /*0x18*/ GooglePlayGames.Android.AndroidClient <>4__this;
                /*0x20*/ string leaderboardId;
                /*0x28*/ GooglePlayGames.BasicApi.LeaderboardCollection collection;
                /*0x2c*/ GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan;

                /*0xe20f24*/ <>c__DisplayClass51_0();
                /*0xe2a610*/ void <LoadScores>b__0(UnityEngine.AndroidJavaObject annotatedData);
                /*0xe2a9a0*/ void <LoadScores>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass52_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback;
                /*0x18*/ GooglePlayGames.Android.AndroidClient <>4__this;
                /*0x20*/ GooglePlayGames.BasicApi.ScorePageToken token;

                /*0xe21598*/ <>c__DisplayClass52_0();
                /*0xe2ab4c*/ void <LoadMoreScores>b__0(UnityEngine.AndroidJavaObject annotatedData);
                /*0xe2aee0*/ void <LoadMoreScores>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass56_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidClient <>4__this;
                /*0x18*/ System.Action<GooglePlayGames.BasicApi.SignInStatus> callback;

                /*0xe22edc*/ <>c__DisplayClass56_0();
                /*0xe2b094*/ void <RequestPermissions>b__0(GooglePlayGames.BasicApi.SignInStatus code);
            }

            class <>c__DisplayClass64_0
            {
                /*0x10*/ GooglePlayGames.BasicApi.InvitationReceivedDelegate invitationDelegate;

                /*0xe248b8*/ <>c__DisplayClass64_0();
                /*0xe2b0d8*/ void <RegisterInvitationDelegate>b__0(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation, bool autoAccept);
            }
        }

        class AndroidEventsClient : GooglePlayGames.BasicApi.Events.IEventsClient
        {
            /*0x10*/ UnityEngine.AndroidJavaObject mEventsClient;

            static System.Action<T1, T2> ToOnGameThread<T1, T2>(System.Action<T1, T2> toConvert);
            static /*0xe2b97c*/ GooglePlayGames.BasicApi.Events.Event CreateEvent(UnityEngine.AndroidJavaObject eventJava);
            /*0xe23a74*/ AndroidEventsClient(UnityEngine.AndroidJavaObject account);
            /*0xe2b100*/ void FetchAllEvents(GooglePlayGames.BasicApi.DataSource source, System.Action<GooglePlayGames.BasicApi.ResponseStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.Events.IEvent>> callback);
            /*0xe2b470*/ void FetchEvent(GooglePlayGames.BasicApi.DataSource source, string eventId, System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Events.IEvent> callback);
            /*0xe2b854*/ void IncrementEvent(string eventId, uint stepsToIncrement);

            class <>c__DisplayClass2_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.ResponseStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.Events.IEvent>> callback;

                /*0xe2b468*/ <>c__DisplayClass2_0();
                /*0xe2bd18*/ void <FetchAllEvents>b__0(UnityEngine.AndroidJavaObject annotatedData);
                /*0xe2c3cc*/ void <FetchAllEvents>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Events.IEvent> callback;

                /*0xe2b84c*/ <>c__DisplayClass3_0();
                /*0xe2c45c*/ void <FetchEvent>b__0(UnityEngine.AndroidJavaObject annotatedData);
                /*0xe2caa0*/ void <FetchEvent>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass5_0<T1, T2>
            {
                /*0x0*/ System.Action<T1, T2> toConvert;

                <>c__DisplayClass5_0();
                void <ToOnGameThread>b__0(T1 val1, T2 val2);
            }

            class <>c__DisplayClass5_1<T1, T2>
            {
                /*0x0*/ T1 val1;
                /*0x0*/ T2 val2;
                /*0x0*/ GooglePlayGames.Android.AndroidEventsClient.<>c__DisplayClass5_0<T1, T2> CS$<>8__locals1;

                <>c__DisplayClass5_1();
                void <ToOnGameThread>b__1();
            }
        }

        class AndroidHelperFragment
        {
            static string HelperFragmentClass = "com.google.games.bridge.HelperFragment";

            static /*0xe248c0*/ UnityEngine.AndroidJavaObject GetActivity();
            static /*0xe26410*/ UnityEngine.AndroidJavaObject GetDefaultPopupView();
            static /*0xe1f8e8*/ void ShowAchievementsUI(System.Action<GooglePlayGames.BasicApi.UIStatus> cb);
            static /*0xe2cb38*/ void ShowCaptureOverlayUI();
            static /*0xe1fe28*/ void ShowAllLeaderboardsUI(System.Action<GooglePlayGames.BasicApi.UIStatus> cb);
            static /*0xe20290*/ void ShowLeaderboardUI(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, System.Action<GooglePlayGames.BasicApi.UIStatus> cb);
            static /*0xe2cd6c*/ void ShowSelectSnapshotUI(bool showCreateSaveUI, bool showDeleteSaveUI, int maxDisplayedSavedGames, string uiTitle, System.Action<GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> cb);
            static /*0xe2d344*/ void ShowRtmpSelectOpponentsUI(uint minOpponents, uint maxOpponents, System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.Android.AndroidHelperFragment.InvitationResultHolder> cb);
            static /*0xe2d894*/ void ShowTbmpSelectOpponentsUI(uint minOpponents, uint maxOpponents, System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.Android.AndroidHelperFragment.InvitationResultHolder> cb);
            static /*0xe2d350*/ void ShowSelectOpponentsUI(uint minOpponents, uint maxOpponents, bool isRealTime, System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.Android.AndroidHelperFragment.InvitationResultHolder> cb);
            static /*0xe2d8a8*/ void ShowWaitingRoomUI(UnityEngine.AndroidJavaObject room, int minParticipantsToStart, System.Action<GooglePlayGames.Android.AndroidHelperFragment.WaitingRoomUIStatus, UnityEngine.AndroidJavaObject> cb);
            static /*0xe2ddb4*/ void ShowInboxUI(System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> cb);
            static /*0xe2e210*/ void ShowInvitationInboxUI(System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.Invitation> cb);
            static /*0xe2e66c*/ System.Collections.Generic.List<string> CreatePlayerIdsToInvite(UnityEngine.AndroidJavaObject playerIdsObject);
            /*0xe2e8e4*/ AndroidHelperFragment();

            enum WaitingRoomUIStatus
            {
                Valid = 1,
                Cancelled = 2,
                LeftRoom = 3,
                InvalidRoom = 4,
                Busy = -1,
                InternalError = -2,
            }

            class InvitationResultHolder
            {
                /*0x10*/ int MinAutomatchingPlayers;
                /*0x14*/ int MaxAutomatchingPlayers;
                /*0x18*/ System.Collections.Generic.List<string> PlayerIdsToInvite;

                /*0xe2e8ec*/ InvitationResultHolder(int MinAutomatchingPlayers, int MaxAutomatchingPlayers, System.Collections.Generic.List<string> PlayerIdsToInvite);
            }

            class <>c__DisplayClass3_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.UIStatus> cb;

                /*0xe2cb30*/ <>c__DisplayClass3_0();
                /*0xe2e928*/ void <ShowAchievementsUI>b__0(int uiCode);
                /*0xe2e9ec*/ void <ShowAchievementsUI>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.UIStatus> cb;

                /*0xe2cd5c*/ <>c__DisplayClass5_0();
                /*0xe2ea78*/ void <ShowAllLeaderboardsUI>b__0(int uiCode);
                /*0xe2eb3c*/ void <ShowAllLeaderboardsUI>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.UIStatus> cb;

                /*0xe2cd64*/ <>c__DisplayClass6_0();
                /*0xe2ebc8*/ void <ShowLeaderboardUI>b__0(int uiCode);
                /*0xe2ec8c*/ void <ShowLeaderboardUI>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> cb;

                /*0xe2d33c*/ <>c__DisplayClass7_0();
                /*0xe2ed18*/ void <ShowSelectSnapshotUI>b__0(UnityEngine.AndroidJavaObject result);
                /*0xe2ef08*/ void <ShowSelectSnapshotUI>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.Android.AndroidHelperFragment.InvitationResultHolder> cb;

                /*0xe2d8a0*/ <>c__DisplayClass10_0();
                /*0xe2ef98*/ void <ShowSelectOpponentsUI>b__0(UnityEngine.AndroidJavaObject result);
                /*0xe2f288*/ void <ShowSelectOpponentsUI>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ System.Action<GooglePlayGames.Android.AndroidHelperFragment.WaitingRoomUIStatus, UnityEngine.AndroidJavaObject> cb;

                /*0xe2ddac*/ <>c__DisplayClass12_0();
                /*0xe2f318*/ void <ShowWaitingRoomUI>b__0(UnityEngine.AndroidJavaObject result);
                /*0xe2f3e8*/ void <ShowWaitingRoomUI>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> cb;

                /*0xe2e208*/ <>c__DisplayClass13_0();
                /*0xe2f478*/ void <ShowInboxUI>b__0(UnityEngine.AndroidJavaObject result);
                /*0xe2f6ac*/ void <ShowInboxUI>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.Invitation> cb;

                /*0xe2e664*/ <>c__DisplayClass14_0();
                /*0xe2f73c*/ void <ShowInvitationInboxUI>b__0(UnityEngine.AndroidJavaObject result);
                /*0xe2f970*/ void <ShowInvitationInboxUI>b__1(UnityEngine.AndroidJavaObject exception);
            }
        }

        class AndroidJavaConverter
        {
            static /*0xe22738*/ System.DateTime ToDateTime(long milliseconds);
            static /*0xe21040*/ int ToLeaderboardVariantTimeSpan(GooglePlayGames.BasicApi.LeaderboardTimeSpan span);
            static /*0xe21054*/ int ToLeaderboardVariantCollection(GooglePlayGames.BasicApi.LeaderboardCollection collection);
            static /*0xe215a0*/ int ToPageDirection(GooglePlayGames.BasicApi.ScorePageDirection direction);
            static /*0xe2fa00*/ GooglePlayGames.BasicApi.Multiplayer.Invitation.InvType FromInvitationType(int invitationTypeJava);
            static /*0xe2fa14*/ GooglePlayGames.BasicApi.Multiplayer.Participant.ParticipantStatus FromParticipantStatus(int participantStatusJava);
            static /*0xe2fa24*/ GooglePlayGames.BasicApi.Multiplayer.Participant ToParticipant(UnityEngine.AndroidJavaObject participant);
            static /*0xe27c40*/ GooglePlayGames.BasicApi.Multiplayer.Player ToPlayer(UnityEngine.AndroidJavaObject player);
            static /*0xe24cc0*/ GooglePlayGames.BasicApi.Multiplayer.Invitation ToInvitation(UnityEngine.AndroidJavaObject invitation);
            static /*0xe27e3c*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch ToTurnBasedMatch(UnityEngine.AndroidJavaObject turnBasedMatch);
            static /*0xe2ff10*/ System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> ToParticipantList(UnityEngine.AndroidJavaObject turnBasedMatch);
            static /*0xe3059c*/ System.Collections.Generic.List<string> ToStringList(UnityEngine.AndroidJavaObject stringList);
            static /*0xe30848*/ UnityEngine.AndroidJavaObject ToJavaStringList(System.Collections.Generic.List<string> list);
            static /*0xe3055c*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus ToMatchStatus(int matchStatus);
            static /*0xe3057c*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus ToMatchTurnStatus(int matchTurnStatus);
            /*0xe30a20*/ AndroidJavaConverter();
        }

        class AndroidNearbyConnectionClient : GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient
        {
            static /*0x0*/ long NearbyClientId;
            static /*0x8*/ int ApplicationInfoFlags;
            static /*0x10*/ string ServiceId;
            /*0x10*/ UnityEngine.AndroidJavaObject mClient;
            /*0x18*/ GooglePlayGames.BasicApi.Nearby.IMessageListener mAdvertisingMessageListener;

            static /*0xe34518*/ AndroidNearbyConnectionClient();
            static /*0xe33c94*/ string ReadServiceId();
            static System.Action<T> ToOnGameThread<T>(System.Action<T> toConvert);
            static System.Action<T1, T2> ToOnGameThread<T1, T2>(System.Action<T1, T2> toConvert);
            /*0xe1b880*/ AndroidNearbyConnectionClient();
            /*0xe30a28*/ int MaxUnreliableMessagePayloadLength();
            /*0xe30a30*/ int MaxReliableMessagePayloadLength();
            /*0xe30a38*/ void SendReliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload);
            /*0xe30f30*/ void SendUnreliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload);
            /*0xe30a3c*/ void InternalSend(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload);
            /*0xe30f34*/ void StartAdvertising(string name, System.Collections.Generic.List<string> appIdentifiers, System.Nullable<System.TimeSpan> advertisingDuration, System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult> resultCallback, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionRequest> connectionRequestCallback);
            /*0xe31804*/ UnityEngine.AndroidJavaObject CreateAdvertisingOptions();
            /*0xe31e00*/ void StopAdvertising();
            /*0xe31eb8*/ void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionResponse> responseCallback, GooglePlayGames.BasicApi.Nearby.IMessageListener listener);
            /*0xe323e4*/ void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, GooglePlayGames.BasicApi.Nearby.IMessageListener listener);
            /*0xe32840*/ void StartDiscovery(string serviceId, System.Nullable<System.TimeSpan> advertisingDuration, GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener);
            /*0xe33060*/ UnityEngine.AndroidJavaObject CreateDiscoveryOptions();
            /*0xe3365c*/ void StopDiscovery(string serviceId);
            /*0xe3370c*/ void RejectConnectionRequest(string requestingEndpointId);
            /*0xe338b0*/ void DisconnectFromEndpoint(string remoteEndpointId);
            /*0xe33978*/ void StopAllConnections();
            /*0xe33a30*/ string GetAppBundleId();
            /*0xe33c3c*/ string GetServiceId();

            class AdvertisingConnectionLifecycleCallbackProxy : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult> mResultCallback;
                /*0x28*/ System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionRequest> mConnectionRequestCallback;
                /*0x30*/ GooglePlayGames.Android.AndroidNearbyConnectionClient mClient;
                /*0x38*/ string mLocalEndpointName;

                /*0xe3176c*/ AdvertisingConnectionLifecycleCallbackProxy(System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult> resultCallback, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionRequest> connectionRequestCallback, GooglePlayGames.Android.AndroidNearbyConnectionClient client);
                /*0xe34578*/ void onConnectionInitiated(string endpointId, UnityEngine.AndroidJavaObject connectionInfo);
                /*0xe34710*/ void onConnectionResult(string endpointId, UnityEngine.AndroidJavaObject connectionResolution);
                /*0xe34a18*/ void onDisconnected(string endpointId);
            }

            class PayloadCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ GooglePlayGames.BasicApi.Nearby.IMessageListener mListener;

                /*0xe327bc*/ PayloadCallback(GooglePlayGames.BasicApi.Nearby.IMessageListener listener);
                /*0xe34ad8*/ void onPayloadReceived(string endpointId, UnityEngine.AndroidJavaObject payload);
            }

            class DiscoveringConnectionLifecycleCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionResponse> mResponseCallback;
                /*0x28*/ GooglePlayGames.BasicApi.Nearby.IMessageListener mListener;
                /*0x30*/ UnityEngine.AndroidJavaObject mClient;
                /*0x38*/ string mLocalEndpointName;

                /*0xe3234c*/ DiscoveringConnectionLifecycleCallback(System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionResponse> responseCallback, GooglePlayGames.BasicApi.Nearby.IMessageListener listener, UnityEngine.AndroidJavaObject client);
                /*0xe34cb8*/ void onConnectionInitiated(string endpointId, UnityEngine.AndroidJavaObject connectionInfo);
                /*0xe35020*/ void onConnectionResult(string endpointId, UnityEngine.AndroidJavaObject connectionResolution);
                /*0xe35414*/ void onDisconnected(string endpointId);
            }

            class EndpointDiscoveryCallback : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ GooglePlayGames.BasicApi.Nearby.IDiscoveryListener mListener;

                /*0xe32fdc*/ EndpointDiscoveryCallback(GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener);
                /*0xe354c0*/ void onEndpointFound(string endpointId, UnityEngine.AndroidJavaObject endpointInfo);
                /*0xe3572c*/ void onEndpointLost(string endpointId);
                /*0xe355c4*/ GooglePlayGames.BasicApi.Nearby.EndpointDetails CreateEndPointDetails(string endpointId, UnityEngine.AndroidJavaObject endpointInfo);
            }

            class OnGameThreadMessageListener : GooglePlayGames.BasicApi.Nearby.IMessageListener
            {
                /*0x10*/ GooglePlayGames.BasicApi.Nearby.IMessageListener mListener;

                /*0xe322e4*/ OnGameThreadMessageListener(GooglePlayGames.BasicApi.Nearby.IMessageListener listener);
                /*0xe357d8*/ void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage);
                /*0xe358dc*/ void OnRemoteEndpointDisconnected(string remoteEndpointId);

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ GooglePlayGames.Android.AndroidNearbyConnectionClient.OnGameThreadMessageListener <>4__this;
                    /*0x18*/ string remoteEndpointId;
                    /*0x20*/ byte[] data;
                    /*0x28*/ bool isReliableMessage;

                    /*0xe358d4*/ <>c__DisplayClass2_0();
                    /*0xe359c4*/ void <OnMessageReceived>b__0();
                }

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ GooglePlayGames.Android.AndroidNearbyConnectionClient.OnGameThreadMessageListener <>4__this;
                    /*0x18*/ string remoteEndpointId;

                    /*0xe359bc*/ <>c__DisplayClass3_0();
                    /*0xe35a8c*/ void <OnRemoteEndpointDisconnected>b__0();
                }
            }

            class OnGameThreadDiscoveryListener : GooglePlayGames.BasicApi.Nearby.IDiscoveryListener
            {
                /*0x10*/ GooglePlayGames.BasicApi.Nearby.IDiscoveryListener mListener;

                /*0xe32fb4*/ OnGameThreadDiscoveryListener(GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener);
                /*0xe35b40*/ void OnEndpointFound(GooglePlayGames.BasicApi.Nearby.EndpointDetails discoveredEndpoint);
                /*0xe35c38*/ void OnEndpointLost(string lostEndpointId);

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ GooglePlayGames.Android.AndroidNearbyConnectionClient.OnGameThreadDiscoveryListener <>4__this;
                    /*0x18*/ GooglePlayGames.BasicApi.Nearby.EndpointDetails discoveredEndpoint;

                    /*0xe35c30*/ <>c__DisplayClass2_0();
                    /*0xe35d20*/ void <OnEndpointFound>b__0();
                }

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ GooglePlayGames.Android.AndroidNearbyConnectionClient.OnGameThreadDiscoveryListener <>4__this;
                    /*0x18*/ string lostEndpointId;

                    /*0xe35d18*/ <>c__DisplayClass3_0();
                    /*0xe35e0c*/ void <OnEndpointLost>b__0();
                }
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ System.Nullable<System.TimeSpan> advertisingDuration;

                /*0xe31764*/ <>c__DisplayClass11_0();
                /*0xe35ec0*/ void <StartAdvertising>b__0(UnityEngine.AndroidJavaObject v);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ System.Nullable<System.TimeSpan> advertisingDuration;

                /*0xe32fac*/ <>c__DisplayClass18_0();
                /*0xe35ed0*/ void <StartDiscovery>b__0(UnityEngine.AndroidJavaObject v);
            }

            class <>c__DisplayClass31_0<T>
            {
                /*0x0*/ System.Action<T> toConvert;

                <>c__DisplayClass31_0();
                void <ToOnGameThread>b__0(T val);
            }

            class <>c__DisplayClass31_<T>
            {
                /*0x0*/ T val;
                /*0x0*/ GooglePlayGames.Android.AndroidNearbyConnectionClient.<>c__DisplayClass31_0<T> CS$<>8__locals1;

                <>c__DisplayClass31_();
                void <ToOnGameThread>b__1();
            }

            class <>c__DisplayClass32_0<T1, T2>
            {
                /*0x0*/ System.Action<T1, T2> toConvert;

                <>c__DisplayClass32_0();
                void <ToOnGameThread>b__0(T1 val1, T2 val2);
            }

            class <>c__DisplayClass32_1<T1, T2>
            {
                /*0x0*/ T1 val1;
                /*0x0*/ T2 val2;
                /*0x0*/ GooglePlayGames.Android.AndroidNearbyConnectionClient.<>c__DisplayClass32_0<T1, T2> CS$<>8__locals1;

                <>c__DisplayClass32_1();
                void <ToOnGameThread>b__1();
            }
        }

        class AndroidRealTimeMultiplayerClient : GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient
        {
            /*0x10*/ object mSessionLock;
            /*0x18*/ int mMinPlayersToStart;
            /*0x20*/ GooglePlayGames.Android.AndroidClient mAndroidClient;
            /*0x28*/ UnityEngine.AndroidJavaObject mRtmpClient;
            /*0x30*/ UnityEngine.AndroidJavaObject mInvitationsClient;
            /*0x38*/ UnityEngine.AndroidJavaObject mRoom;
            /*0x40*/ UnityEngine.AndroidJavaObject mRoomConfig;
            /*0x48*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener mListener;
            /*0x50*/ GooglePlayGames.BasicApi.Multiplayer.Invitation mInvitation;

            static System.Action<T> ToOnGameThread<T>(System.Action<T> toConvert);
            /*0xe23d14*/ AndroidRealTimeMultiplayerClient(GooglePlayGames.Android.AndroidClient androidClient, UnityEngine.AndroidJavaObject account);
            /*0xe35ee0*/ void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener);
            /*0xe35eec*/ void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitMask, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener);
            /*0xe37758*/ void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener);
            /*0xe37994*/ float GetPercentComplete();
            /*0xe37c48*/ void ShowWaitingRoomUI();
            /*0xe37cfc*/ void GetAllInvitations(System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> callback);
            /*0xe38018*/ void AcceptFromInbox(GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener);
            /*0xe3822c*/ void AcceptInvitation(string invitationId, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener);
            /*0xe387b0*/ void SendMessageToAll(bool reliable, byte[] data);
            /*0xe38f74*/ void SendMessageToAll(bool reliable, byte[] data, int offset, int length);
            /*0xe38b44*/ void SendMessage(bool reliable, string participantId, byte[] data);
            /*0xe39268*/ void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length);
            /*0xe37a38*/ System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> GetConnectedParticipants();
            /*0xe392ac*/ System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> GetParticipantList();
            /*0xe39860*/ GooglePlayGames.BasicApi.Multiplayer.Participant GetSelf();
            /*0xe38fb0*/ GooglePlayGames.BasicApi.Multiplayer.Participant GetParticipant(string participantId);
            /*0xe39a28*/ GooglePlayGames.BasicApi.Multiplayer.Invitation GetInvitation();
            /*0xe39a30*/ void LeaveRoom();
            /*0xe39d3c*/ bool IsRoomConnected();
            /*0xe37410*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.RoomStatus GetRoomStatus();
            /*0xe39d54*/ void DeclineInvitation(string invitationId);
            /*0xe384ac*/ void FindInvitation(string invitationId, System.Action<bool> fail, System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation> callback);
            /*0xe39c78*/ void CleanSession();
            /*0xe39ed4*/ void <ShowWaitingRoomUI>b__15_0(GooglePlayGames.Android.AndroidHelperFragment.WaitingRoomUIStatus response, UnityEngine.AndroidJavaObject room);

            enum RoomStatus
            {
                NotCreated = -1,
                Inviting = 0,
                AutoMatching = 1,
                Connecting = 2,
                Active = 3,
                Deleted = 4,
            }

            class RoomStatusUpdateCallbackProxy : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener mListener;
                /*0x28*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient mParent;

                /*0xe376d0*/ RoomStatusUpdateCallbackProxy(GooglePlayGames.Android.AndroidRealTimeMultiplayerClient parent, GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listener);
                /*0xe3a040*/ void onRoomConnecting(UnityEngine.AndroidJavaObject room);
                /*0xe3a05c*/ void onRoomAutoMatching(UnityEngine.AndroidJavaObject room);
                /*0xe3a078*/ void onPeerInvitedToRoom(UnityEngine.AndroidJavaObject room, UnityEngine.AndroidJavaObject participantIds);
                /*0xe3a2d4*/ void onPeerDeclined(UnityEngine.AndroidJavaObject room, UnityEngine.AndroidJavaObject participantIds);
                /*0xe3a2d8*/ void onPeerJoined(UnityEngine.AndroidJavaObject room, UnityEngine.AndroidJavaObject participantIds);
                /*0xe3a2dc*/ void onPeerLeft(UnityEngine.AndroidJavaObject room, UnityEngine.AndroidJavaObject participantIds);
                /*0xe3a07c*/ void handleParticipantStatusChanged(UnityEngine.AndroidJavaObject room, UnityEngine.AndroidJavaObject participantIds);
                /*0xe3a3c0*/ void onConnectedToRoom(UnityEngine.AndroidJavaObject room);
                /*0xe3aa3c*/ void onDisconnectedFromRoom(UnityEngine.AndroidJavaObject room);
                /*0xe3aa9c*/ void onPeersConnected(UnityEngine.AndroidJavaObject room, UnityEngine.AndroidJavaObject participantIds);
                /*0xe3ac2c*/ void onPeersDisconnected(UnityEngine.AndroidJavaObject room, UnityEngine.AndroidJavaObject participantIds);
                /*0xe3a414*/ void handleConnectedSetChanged(UnityEngine.AndroidJavaObject room);
                /*0xe3adbc*/ void onP2PConnected(string participantId);
                /*0xe3adc0*/ void onP2PDisconnected(string participantId);
            }

            class MessageReceivedListenerProxy : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener mListener;

                /*0xe3764c*/ MessageReceivedListenerProxy(GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listener);
                /*0xe3adc4*/ void onRealTimeMessageReceived(bool isReliable, string senderId, byte[] data);
            }

            class RoomUpdateCallbackProxy : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener mListener;
                /*0x28*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient mParent;

                /*0xe375c4*/ RoomUpdateCallbackProxy(GooglePlayGames.Android.AndroidRealTimeMultiplayerClient parent, GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listener);
                /*0xe3aedc*/ void onRoomCreated(int statusCode, UnityEngine.AndroidJavaObject room);
                /*0xe3af24*/ void onJoinedRoom(int statusCode, UnityEngine.AndroidJavaObject room);
                /*0xe3b498*/ void onLeftRoom(int statusCode, string roomId);
                /*0xe3b564*/ void onRoomConnected(int statusCode, UnityEngine.AndroidJavaObject room);
            }

            class OnGameThreadForwardingListener
            {
                /*0x10*/ GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener mListener;

                /*0xe373a8*/ OnGameThreadForwardingListener(GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener);
                /*0xe39f5c*/ void OnRoomSetupProgress(float percent);
                /*0xe374dc*/ void OnRoomConnected(bool success);
                /*0xe3b4c0*/ void OnLeftRoom();
                /*0xe3ab4c*/ void OnPeersConnected(string[] participantIds);
                /*0xe3acdc*/ void OnPeersDisconnected(string[] participantIds);
                /*0xe3ade0*/ void OnRealTimeMessageReceived(bool isReliable, string senderId, byte[] data);
                /*0xe3a2e0*/ void OnParticipantLeft(GooglePlayGames.BasicApi.Multiplayer.Participant participant);
                /*0xe3b5d0*/ void <OnLeftRoom>b__4_0();

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener <>4__this;
                    /*0x18*/ float percent;

                    /*0xe3b5a0*/ <>c__DisplayClass2_0();
                    /*0xe3b674*/ void <OnRoomSetupProgress>b__0();
                }

                class <>c__DisplayClass3_0
                {
                    /*0x10*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener <>4__this;
                    /*0x18*/ bool success;

                    /*0xe3b5a8*/ <>c__DisplayClass3_0();
                    /*0xe3b72c*/ void <OnRoomConnected>b__0();
                }

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener <>4__this;
                    /*0x18*/ string[] participantIds;

                    /*0xe3b5b0*/ <>c__DisplayClass5_0();
                    /*0xe3b7e4*/ void <OnPeersConnected>b__0();
                }

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener <>4__this;
                    /*0x18*/ string[] participantIds;

                    /*0xe3b5b8*/ <>c__DisplayClass6_0();
                    /*0xe3b898*/ void <OnPeersDisconnected>b__0();
                }

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener <>4__this;
                    /*0x18*/ bool isReliable;
                    /*0x20*/ string senderId;
                    /*0x28*/ byte[] data;

                    /*0xe3b5c0*/ <>c__DisplayClass7_0();
                    /*0xe3b94c*/ void <OnRealTimeMessageReceived>b__0();
                }

                class <>c__DisplayClass8_0
                {
                    /*0x10*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener <>4__this;
                    /*0x18*/ GooglePlayGames.BasicApi.Multiplayer.Participant participant;

                    /*0xe3b5c8*/ <>c__DisplayClass8_0();
                    /*0xe3ba18*/ void <OnParticipantLeft>b__0();
                }
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listenerOnGameThread;
                /*0x18*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient <>4__this;

                /*0xe373a0*/ <>c__DisplayClass12_0();
                /*0xe3bacc*/ void <CreateQuickGame>b__0(UnityEngine.AndroidJavaObject e);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient <>4__this;
                /*0x18*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listenerOnGameThread;
                /*0x20*/ uint variant;
                /*0x28*/ System.Action <>9__1;
                /*0x30*/ System.Action<UnityEngine.AndroidJavaObject> <>9__2;

                /*0xe3798c*/ <>c__DisplayClass13_0();
                /*0xe3baf8*/ void <CreateWithInvitationScreen>b__0(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.Android.AndroidHelperFragment.InvitationResultHolder result);
                /*0xe3d128*/ void <CreateWithInvitationScreen>b__1();
                /*0xe3d154*/ void <CreateWithInvitationScreen>b__2(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> callback;

                /*0xe38010*/ <>c__DisplayClass16_0();
                /*0xe3d180*/ void <GetAllInvitations>b__0(UnityEngine.AndroidJavaObject annotatedData);
                /*0xe3d6e4*/ void <GetAllInvitations>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient <>4__this;
                /*0x18*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listenerOnGameThread;
                /*0x20*/ GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener;
                /*0x28*/ System.Action <>9__1;

                /*0xe38224*/ <>c__DisplayClass17_0();
                /*0xe3d70c*/ void <AcceptFromInbox>b__0(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.BasicApi.Multiplayer.Invitation invitation);
                /*0xe3d854*/ void <AcceptFromInbox>b__1();
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.OnGameThreadForwardingListener listenerOnGameThread;
                /*0x18*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient <>4__this;
                /*0x20*/ string invitationId;
                /*0x28*/ System.Action<UnityEngine.AndroidJavaObject> <>9__2;

                /*0xe384a4*/ <>c__DisplayClass18_0();
                /*0xe3d870*/ void <AcceptInvitation>b__0(bool fail);
                /*0xe3d88c*/ void <AcceptInvitation>b__1(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation);
                /*0xe3e9e8*/ void <AcceptInvitation>b__2(UnityEngine.AndroidJavaObject e);
            }

            class <>c__DisplayClass31_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient <>4__this;
                /*0x18*/ string invitationId;

                /*0xe39ec4*/ <>c__DisplayClass31_0();
                /*0xe3ea14*/ void <DeclineInvitation>b__1(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation);
            }

            class <>c
            {
                static /*0x0*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.<> <>9;
                static /*0x8*/ System.Action<bool> <>9__31_0;

                static /*0xe3eb70*/ <>c();
                /*0xe3ebd4*/ <>c();
                /*0xe3ebdc*/ void <DeclineInvitation>b__31_0(bool fail);
            }

            class <>c__DisplayClass32_0
            {
                /*0x10*/ string invitationId;
                /*0x18*/ System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation> callback;
                /*0x20*/ System.Action<bool> fail;

                /*0xe39ecc*/ <>c__DisplayClass32_0();
                /*0xe3ebe0*/ void <FindInvitation>b__0(UnityEngine.AndroidJavaObject annotatedData);
                /*0xe3f18c*/ void <FindInvitation>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass38_0<T>
            {
                /*0x0*/ System.Action<T> toConvert;

                <>c__DisplayClass38_0();
                void <ToOnGameThread>b__0(T val);
            }

            class <>c__DisplayClass38_<T>
            {
                /*0x0*/ T val;
                /*0x0*/ GooglePlayGames.Android.AndroidRealTimeMultiplayerClient.<>c__DisplayClass38_0<T> CS$<>8__locals1;

                <>c__DisplayClass38_();
                void <ToOnGameThread>b__1();
            }
        }

        class AndroidSavedGameClient : GooglePlayGames.BasicApi.SavedGame.ISavedGameClient
        {
            static /*0x0*/ System.Text.RegularExpressions.Regex ValidFilenameRegex;
            /*0x10*/ UnityEngine.AndroidJavaObject mSnapshotsClient;
            /*0x18*/ GooglePlayGames.Android.AndroidClient mAndroidClient;

            static /*0xe41838*/ AndroidSavedGameClient();
            static /*0xe3f510*/ bool IsValidFilename(string filename);
            static /*0xe40810*/ UnityEngine.AndroidJavaObject AsMetadataChange(GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate update);
            static System.Action<T1, T2> ToOnGameThread<T1, T2>(System.Action<T1, T2> toConvert);
            /*0xe237c8*/ AndroidSavedGameClient(GooglePlayGames.Android.AndroidClient androidClient, UnityEngine.AndroidJavaObject account);
            /*0xe3f218*/ void OpenWithAutomaticConflictResolution(string filename, GooglePlayGames.BasicApi.DataSource source, GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback);
            /*0xe3f994*/ void OpenWithManualConflictResolution(string filename, GooglePlayGames.BasicApi.DataSource source, bool prefetchDataOnConflict, GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback);
            /*0xe3f590*/ void InternalOpen(string filename, GooglePlayGames.BasicApi.DataSource source, GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy, bool prefetchDataOnConflict, GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback);
            /*0xe3fc30*/ void ReadBinaryData(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Byte[]> completedCallback);
            /*0xe3ff58*/ void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, System.Action<GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback);
            /*0xe400c4*/ void CommitUpdate(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata, GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback);
            /*0xe41294*/ void FetchAllSavedGames(GooglePlayGames.BasicApi.DataSource source, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>> callback);
            /*0xe41654*/ void Delete(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata);
            /*0xe3fb70*/ void AddOnFailureListenerWithSignOut(UnityEngine.AndroidJavaObject task, System.Action<UnityEngine.AndroidJavaObject> callback);
            /*0xe3f464*/ GooglePlayGames.BasicApi.SavedGame.ConflictCallback ToOnGameThread(GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback);

            class AndroidConflictResolver : GooglePlayGames.BasicApi.SavedGame.IConflictResolver
            {
                /*0x10*/ UnityEngine.AndroidJavaObject mSnapshotsClient;
                /*0x18*/ UnityEngine.AndroidJavaObject mConflict;
                /*0x20*/ GooglePlayGames.Android.AndroidSnapshotMetadata mOriginal;
                /*0x28*/ GooglePlayGames.Android.AndroidSnapshotMetadata mUnmerged;
                /*0x30*/ System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> mCompleteCallback;
                /*0x38*/ System.Action mRetryFileOpen;
                /*0x40*/ GooglePlayGames.Android.AndroidSavedGameClient mAndroidSavedGameClient;

                /*0xe418c8*/ AndroidConflictResolver(GooglePlayGames.Android.AndroidSavedGameClient androidSavedGameClient, UnityEngine.AndroidJavaObject snapshotClient, UnityEngine.AndroidJavaObject conflict, GooglePlayGames.Android.AndroidSnapshotMetadata original, GooglePlayGames.Android.AndroidSnapshotMetadata unmerged, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completeCallback, System.Action retryOpen);
                /*0xe419f0*/ void ResolveConflict(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata, GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate metadataUpdate, byte[] updatedData);
                /*0xe423b4*/ void ChooseMetadata(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata);
                /*0xe42840*/ void <ResolveConflict>b__8_0(UnityEngine.AndroidJavaObject dataOrConflict);
                /*0xe42864*/ void <ResolveConflict>b__8_1(UnityEngine.AndroidJavaObject exception);
                /*0xe429d4*/ void <ChooseMetadata>b__9_0(UnityEngine.AndroidJavaObject dataOrConflict);
                /*0xe429f8*/ void <ChooseMetadata>b__9_1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy;
                /*0x18*/ System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback;

                /*0xe3f45c*/ <>c__DisplayClass4_0();
                /*0xe42b68*/ void <OpenWithAutomaticConflictResolution>b__0(GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original, byte[] originalData, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged, byte[] unmergedData);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidSavedGameClient <>4__this;
                /*0x18*/ System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback;
                /*0x20*/ string filename;
                /*0x28*/ GooglePlayGames.BasicApi.DataSource source;
                /*0x2c*/ GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy;
                /*0x30*/ bool prefetchDataOnConflict;
                /*0x38*/ GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback;
                /*0x40*/ System.Action <>9__2;

                /*0xe3fb68*/ <>c__DisplayClass6_0();
                /*0xe42ee4*/ void <InternalOpen>b__0(UnityEngine.AndroidJavaObject dataOrConflict);
                /*0xe436c4*/ void <InternalOpen>b__2();
                /*0xe436f0*/ void <InternalOpen>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback;
                /*0x18*/ GooglePlayGames.Android.AndroidSavedGameClient <>4__this;

                /*0xe40808*/ <>c__DisplayClass9_0();
                /*0xe43860*/ void <CommitUpdate>b__0(UnityEngine.AndroidJavaObject snapshotMetadata);
                /*0xe43930*/ void <CommitUpdate>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>> callback;
                /*0x18*/ GooglePlayGames.Android.AndroidSavedGameClient <>4__this;

                /*0xe4164c*/ <>c__DisplayClass10_0();
                /*0xe43aa0*/ void <FetchAllSavedGames>b__0(UnityEngine.AndroidJavaObject annotatedData);
                /*0xe4417c*/ void <FetchAllSavedGames>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidSavedGameClient <>4__this;
                /*0x18*/ System.Action<UnityEngine.AndroidJavaObject> callback;

                /*0xe41828*/ <>c__DisplayClass12_0();
                /*0xe44330*/ void <AddOnFailureListenerWithSignOut>b__0(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback;

                /*0xe41830*/ <>c__DisplayClass13_0();
                /*0xe44448*/ void <ToOnGameThread>b__0(GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original, byte[] originalData, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged, byte[] unmergedData);
            }

            class <>c__DisplayClass13_1
            {
                /*0x10*/ GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver;
                /*0x18*/ GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original;
                /*0x20*/ byte[] originalData;
                /*0x28*/ GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged;
                /*0x30*/ byte[] unmergedData;
                /*0x38*/ GooglePlayGames.Android.AndroidSavedGameClient.<> CS$<>8__locals1;

                /*0xe4459c*/ <>c__DisplayClass13_1();
                /*0xe445a4*/ void <ToOnGameThread>b__1();
            }

            class <>c__DisplayClass17_0<T1, T2>
            {
                /*0x0*/ System.Action<T1, T2> toConvert;

                <>c__DisplayClass17_0();
                void <ToOnGameThread>b__0(T1 val1, T2 val2);
            }

            class <>c__DisplayClass17_1<T1, T2>
            {
                /*0x0*/ T1 val1;
                /*0x0*/ T2 val2;
                /*0x0*/ GooglePlayGames.Android.AndroidSavedGameClient.<>c__DisplayClass17_0<T1, T2> CS$<>8__locals1;

                <>c__DisplayClass17_1();
                void <ToOnGameThread>b__1();
            }
        }

        class AndroidSnapshotMetadata : GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata
        {
            /*0x10*/ UnityEngine.AndroidJavaObject mJavaSnapshot;
            /*0x18*/ UnityEngine.AndroidJavaObject mJavaMetadata;
            /*0x20*/ UnityEngine.AndroidJavaObject mJavaContents;

            /*0xe4357c*/ AndroidSnapshotMetadata(UnityEngine.AndroidJavaObject javaSnapshot);
            /*0xe2eed8*/ AndroidSnapshotMetadata(UnityEngine.AndroidJavaObject javaMetadata, UnityEngine.AndroidJavaObject javaContents);
            /*0xe445dc*/ UnityEngine.AndroidJavaObject get_JavaSnapshot();
            /*0xe445e4*/ UnityEngine.AndroidJavaObject get_JavaMetadata();
            /*0xe445ec*/ UnityEngine.AndroidJavaObject get_JavaContents();
            /*0xe3fe88*/ bool get_IsOpen();
            /*0xe445f4*/ string get_Filename();
            /*0xe446b4*/ string get_Description();
            /*0xe44774*/ string get_CoverImageURL();
            /*0xe44834*/ System.TimeSpan get_TotalTimePlayed();
            /*0xe4492c*/ System.DateTime get_LastModifiedTimestamp();
        }

        class AndroidTaskUtils
        {
            static void AddOnSuccessListener<T>(UnityEngine.AndroidJavaObject task, System.Action<T> callback);
            static void AddOnSuccessListener<T>(UnityEngine.AndroidJavaObject task, bool disposeResult, System.Action<T> callback);
            static /*0xe207c0*/ void AddOnFailureListener(UnityEngine.AndroidJavaObject task, System.Action<UnityEngine.AndroidJavaObject> callback);
            static void AddOnCompleteListener<T>(UnityEngine.AndroidJavaObject task, System.Action<T> callback);
            /*0xe449f0*/ AndroidTaskUtils();

            class TaskOnCompleteProxy<T> : UnityEngine.AndroidJavaProxy
            {
                /*0x0*/ System.Action<T> mCallback;

                TaskOnCompleteProxy(System.Action<T> callback);
                void onComplete(T result);
            }

            class TaskOnSuccessProxy<T> : UnityEngine.AndroidJavaProxy
            {
                /*0x0*/ System.Action<T> mCallback;
                /*0x0*/ System.Action<UnityEngine.AndroidJavaObject> mCallback2;
                /*0x0*/ bool mDisposeResult;

                TaskOnSuccessProxy(System.Action<T> callback, bool disposeResult);
                void onSuccess(T result);
            }

            class TaskOnFailedProxy : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<UnityEngine.AndroidJavaObject> mCallback;

                /*0xe449f8*/ TaskOnFailedProxy(System.Action<UnityEngine.AndroidJavaObject> callback);
                /*0xe44a7c*/ void onFailure(UnityEngine.AndroidJavaObject exception);
            }
        }

        class AndroidTokenClient : GooglePlayGames.TokenClient
        {
            static string HelperFragmentClass = "com.google.games.bridge.HelperFragment";
            /*0x10*/ bool requestEmail;
            /*0x11*/ bool requestAuthCode;
            /*0x12*/ bool requestIdToken;
            /*0x18*/ System.Collections.Generic.List<string> oauthScopes;
            /*0x20*/ string webClientId;
            /*0x28*/ bool forceRefresh;
            /*0x29*/ bool hidePopups;
            /*0x30*/ string accountName;
            /*0x38*/ UnityEngine.AndroidJavaObject account;
            /*0x40*/ string email;
            /*0x48*/ string authCode;
            /*0x50*/ string idToken;

            /*0xe1c634*/ AndroidTokenClient();
            /*0xe1c63c*/ void SetRequestAuthCode(bool flag, bool forceRefresh);
            /*0xe44bf8*/ void SetRequestEmail(bool flag);
            /*0xe44c04*/ void SetRequestIdToken(bool flag);
            /*0xe44c10*/ void SetWebClientId(string webClientId);
            /*0xe44c18*/ void SetHidePopups(bool flag);
            /*0xe44c24*/ void SetAccountName(string accountName);
            /*0xe1c650*/ void AddOauthScopes(string[] scopes);
            /*0xe1d308*/ void Signout();
            /*0xe44c2c*/ string GetEmail();
            /*0xe44c34*/ string GetAuthCode();
            /*0xe44c3c*/ string GetIdToken();
            /*0xe1c424*/ void FetchTokens(bool silent, System.Action<int> callback);
            /*0xe22ee4*/ void RequestPermissions(string[] scopes, System.Action<GooglePlayGames.BasicApi.SignInStatus> callback);
            /*0xe240f4*/ bool HasPermissions(string[] scopes);
            /*0xe44c44*/ void DoFetchToken(bool silent, System.Action<int> callback);
            /*0xe455ec*/ UnityEngine.AndroidJavaObject GetAccount();
            /*0xe1ca34*/ void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback);
            /*0xe455f4*/ void DoGetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback);

            class ResultCallbackProxy : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<UnityEngine.AndroidJavaObject> mCallback;

                /*0xcba160*/ ResultCallbackProxy(System.Action<UnityEngine.AndroidJavaObject> callback);
                /*0xcba1e4*/ void onResult(UnityEngine.AndroidJavaObject tokenResult);
            }

            class <>c
            {
                static /*0x0*/ GooglePlayGames.Android.AndroidTokenClient.<> <>9;
                static /*0x8*/ System.Action <>9__20_0;

                static /*0xcba208*/ <>c();
                /*0xcba26c*/ <>c();
                /*0xcba274*/ void <Signout>b__20_0();
            }

            class <>c__DisplayClass24_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidTokenClient <>4__this;
                /*0x18*/ bool silent;
                /*0x20*/ System.Action<int> callback;

                /*0xcba3b4*/ <>c__DisplayClass24_0();
                /*0xcba3bc*/ void <FetchTokens>b__0();
            }

            class <>c__DisplayClass25_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.SignInStatus> callback;
                /*0x18*/ GooglePlayGames.Android.AndroidTokenClient <>4__this;
                /*0x20*/ string[] scopes;

                /*0xcba3e4*/ <>c__DisplayClass25_0();
                /*0xcba3ec*/ void <RequestPermissions>b__0(UnityEngine.AndroidJavaObject accountWithNewScopes);
                /*0xcba640*/ void <RequestPermissions>b__1(UnityEngine.AndroidJavaObject e);
            }

            class <>c__DisplayClass27_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidTokenClient <>4__this;
                /*0x18*/ System.Action<int> callback;

                /*0xcbaad0*/ <>c__DisplayClass27_0();
                /*0xcbaad8*/ void <DoFetchToken>b__0(UnityEngine.AndroidJavaObject tokenResult);
            }

            class <>c__DisplayClass29_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidTokenClient <>4__this;
                /*0x18*/ bool reAuthenticateIfNeeded;
                /*0x20*/ System.Action<string> callback;

                /*0xcbadac*/ <>c__DisplayClass29_0();
                /*0xcbadb4*/ void <GetAnotherServerAuthCode>b__0();
            }

            class <>c__DisplayClass30_0
            {
                /*0x10*/ System.Action<string> callback;

                /*0xcbaddc*/ <>c__DisplayClass30_0();
                /*0xcbade4*/ void <DoGetAnotherServerAuthCode>b__0(UnityEngine.AndroidJavaObject tokenResult);
            }
        }

        class AndroidTurnBasedMultiplayerClient : GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient
        {
            /*0x10*/ UnityEngine.AndroidJavaObject mClient;
            /*0x18*/ GooglePlayGames.Android.AndroidClient mAndroidClient;
            /*0x20*/ System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> mMatchDelegate;

            static System.Action<T> ToOnGameThread<T>(System.Action<T> toConvert);
            static System.Action<T1, T2> ToOnGameThread<T1, T2>(System.Action<T1, T2> toConvert);
            /*0xcbaec8*/ AndroidTurnBasedMultiplayerClient(GooglePlayGames.Android.AndroidClient androidClient, UnityEngine.AndroidJavaObject account);
            /*0xcbb178*/ void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
            /*0xcbb184*/ void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitmask, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
            /*0xcbbd88*/ void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
            /*0xcbbe6c*/ void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
            /*0xcbbf7c*/ UnityEngine.AndroidJavaObject StringListToAndroidJavaObject(System.Collections.Generic.List<string> list);
            /*0xcbc154*/ void GetAllInvitations(System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> callback);
            /*0xcbc4d0*/ void GetAllMatches(System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch[]> callback);
            /*0xcbc84c*/ void GetMatch(string matchId, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
            /*0xcbcb88*/ void GetMatchAndroidJavaObject(string matchId, System.Action<bool, UnityEngine.AndroidJavaObject> callback);
            /*0xcbce98*/ void AcceptFromInbox(System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
            /*0xcbcf80*/ void AcceptInvitation(string invitationId, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
            /*0xcbd3d4*/ void RegisterMatchDelegate(GooglePlayGames.BasicApi.Multiplayer.MatchDelegate del);
            /*0xcbd718*/ System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> get_MatchDelegate();
            /*0xcbd730*/ void TakeTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, string pendingParticipantId, System.Action<bool> callback);
            /*0xcbd928*/ int GetMaxMatchDataSize();
            /*0xcbd930*/ void Finish(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, GooglePlayGames.BasicApi.Multiplayer.MatchOutcome outcome, System.Action<bool> callback);
            /*0xcbda44*/ void AcknowledgeFinished(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> callback);
            /*0xcbdc08*/ void Leave(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> callback);
            /*0xcbdd08*/ void LeaveDuringTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, string pendingParticipantId, System.Action<bool> callback);
            /*0xcbde18*/ void Cancel(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> callback);
            /*0xcbdf18*/ void Dismiss(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match);
            /*0xcbdfe0*/ void Rematch(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
            /*0xcbe0e0*/ void DeclineInvitation(string invitationId);
            /*0xcbd080*/ void FindInvitationWithId(string invitationId, System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation> callback);
            /*0xcbdb3c*/ void FindEqualVersionMatch(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
            /*0xcbd84c*/ void FindEqualVersionMatchWithParticipant(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, string participantId, System.Action<bool> onFailure, System.Action<GooglePlayGames.BasicApi.Multiplayer.Participant, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> onFoundParticipantAndMatch);
            /*0xcbe1c0*/ GooglePlayGames.BasicApi.Multiplayer.Participant CreateAutomatchingSentinel();
            /*0xcbe320*/ System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> CreateTurnBasedMatchList(UnityEngine.AndroidJavaObject turnBasedMatchBuffer);

            class TurnBasedMatchUpdateCallbackProxy : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> mMatchDelegate;

                /*0xcbd694*/ TurnBasedMatchUpdateCallbackProxy(System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch, bool> matchDelegate);
                /*0xcbe59c*/ void onTurnBasedMatchReceived(UnityEngine.AndroidJavaObject turnBasedMatch);
                /*0xcbe5d4*/ void onTurnBasedMatchRemoved(string invitationId);
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;

                /*0xcbbd80*/ <>c__DisplayClass5_0();
                /*0xcbe5d8*/ void <CreateQuickMatch>b__0(UnityEngine.AndroidJavaObject turnBasedMatch);
                /*0xcbe610*/ void <CreateQuickMatch>b__1(UnityEngine.AndroidJavaObject e);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;

                /*0xcbbe64*/ <>c__DisplayClass6_0();
                /*0xcbe63c*/ void <CreateWithInvitationScreen>b__0(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
                /*0x18*/ System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
                /*0x20*/ uint variant;
                /*0x28*/ System.Action<UnityEngine.AndroidJavaObject> <>9__2;
                /*0x30*/ System.Action<UnityEngine.AndroidJavaObject> <>9__3;

                /*0xcbbf74*/ <>c__DisplayClass7_0();
                /*0xcbe668*/ void <CreateWithInvitationScreen>b__0(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.Android.AndroidHelperFragment.InvitationResultHolder result);
                /*0xcbf804*/ void <CreateWithInvitationScreen>b__2(UnityEngine.AndroidJavaObject turnBasedMatch);
                /*0xcbf83c*/ void <CreateWithInvitationScreen>b__3(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass7_1
            {
                /*0x10*/ GooglePlayGames.BasicApi.UIStatus status;
                /*0x18*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.<> CS$<>8__locals1;

                /*0xcbf7fc*/ <>c__DisplayClass7_1();
                /*0xcbf868*/ void <CreateWithInvitationScreen>b__1();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> callback;

                /*0xcbc4c8*/ <>c__DisplayClass9_0();
                /*0xcbf89c*/ void <GetAllInvitations>b__0(UnityEngine.AndroidJavaObject annotatedData);
                /*0xcbffa0*/ void <GetAllInvitations>b__1(UnityEngine.AndroidJavaObject e);
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
                /*0x18*/ System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch[]> callback;

                /*0xcbc844*/ <>c__DisplayClass10_0();
                /*0xcbffc8*/ void <GetAllMatches>b__0(UnityEngine.AndroidJavaObject annotatedData);
                /*0xcc07d0*/ void <GetAllMatches>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ string matchId;
                /*0x18*/ System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;

                /*0xcbcb80*/ <>c__DisplayClass11_0();
                /*0xcc07f8*/ void <GetMatch>b__0(UnityEngine.AndroidJavaObject annotatedData);
                /*0xcc0aa4*/ void <GetMatch>b__1(UnityEngine.AndroidJavaObject e);
            }

            class <>c__DisplayClass12_0
            {
                /*0x10*/ string matchId;
                /*0x18*/ System.Action<bool, UnityEngine.AndroidJavaObject> callback;

                /*0xcbce90*/ <>c__DisplayClass12_0();
                /*0xcc0ad0*/ void <GetMatchAndroidJavaObject>b__0(UnityEngine.AndroidJavaObject annotatedData);
                /*0xcc0d70*/ void <GetMatchAndroidJavaObject>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
                /*0x18*/ System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
                /*0x20*/ System.Action <>9__1;

                /*0xcbcf78*/ <>c__DisplayClass13_0();
                /*0xcc0d9c*/ void <AcceptFromInbox>b__0(GooglePlayGames.BasicApi.UIStatus status, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch turnBasedMatch);
                /*0xcc1034*/ void <AcceptFromInbox>b__1();
            }

            class <>c__DisplayClass14_0
            {
                /*0x10*/ string invitationId;
                /*0x18*/ System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
                /*0x20*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
                /*0x28*/ System.Action<UnityEngine.AndroidJavaObject> <>9__1;
                /*0x30*/ System.Action<UnityEngine.AndroidJavaObject> <>9__2;

                /*0xcbd078*/ <>c__DisplayClass14_0();
                /*0xcc1060*/ void <AcceptInvitation>b__0(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation);
                /*0xcc13dc*/ void <AcceptInvitation>b__1(UnityEngine.AndroidJavaObject turnBasedMatch);
                /*0xcc1414*/ void <AcceptInvitation>b__2(UnityEngine.AndroidJavaObject e);
            }

            class <>c__DisplayClass15_0
            {
                /*0x10*/ GooglePlayGames.BasicApi.Multiplayer.MatchDelegate del;

                /*0xcbd68c*/ <>c__DisplayClass15_0();
                /*0xcc1440*/ void <RegisterMatchDelegate>b__0(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch turnBasedMatch, bool autoAccept);
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
                /*0x18*/ byte[] data;
                /*0x20*/ string pendingParticipantId;
                /*0x28*/ System.Action<bool> callback;
                /*0x30*/ System.Action<UnityEngine.AndroidJavaObject> <>9__1;
                /*0x38*/ System.Action<UnityEngine.AndroidJavaObject> <>9__2;

                /*0xcbd844*/ <>c__DisplayClass18_0();
                /*0xcc1468*/ void <TakeTurn>b__0(GooglePlayGames.BasicApi.Multiplayer.Participant pendingParticipant, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch);
                /*0xcc17b8*/ void <TakeTurn>b__1(UnityEngine.AndroidJavaObject turnBasedMatch);
                /*0xcc17e0*/ void <TakeTurn>b__2(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass20_0
            {
                /*0x10*/ System.Action<bool> callback;
                /*0x18*/ GooglePlayGames.BasicApi.Multiplayer.MatchOutcome outcome;
                /*0x20*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
                /*0x28*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;
                /*0x30*/ byte[] data;
                /*0x38*/ System.Action<UnityEngine.AndroidJavaObject> <>9__1;
                /*0x40*/ System.Action<UnityEngine.AndroidJavaObject> <>9__2;

                /*0xcbda3c*/ <>c__DisplayClass20_0();
                /*0xcc1868*/ void <Finish>b__0(bool status, UnityEngine.AndroidJavaObject foundMatch);
                /*0xcc2cac*/ void <Finish>b__1(UnityEngine.AndroidJavaObject turnBasedMatch);
                /*0xcc2cd4*/ void <Finish>b__2(UnityEngine.AndroidJavaObject e);
            }

            class <>c__DisplayClass21_0
            {
                /*0x10*/ System.Action<bool> callback;
                /*0x18*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
                /*0x20*/ System.Action<UnityEngine.AndroidJavaObject> <>9__1;
                /*0x28*/ System.Action<UnityEngine.AndroidJavaObject> <>9__2;

                /*0xcbdb34*/ <>c__DisplayClass21_0();
                /*0xcc2cfc*/ void <AcknowledgeFinished>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch);
                /*0xcc3030*/ void <AcknowledgeFinished>b__1(UnityEngine.AndroidJavaObject v);
                /*0xcc3058*/ void <AcknowledgeFinished>b__2(UnityEngine.AndroidJavaObject e);
            }

            class <>c__DisplayClass22_0
            {
                /*0x10*/ System.Action<bool> callback;
                /*0x18*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
                /*0x20*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;
                /*0x28*/ System.Action<UnityEngine.AndroidJavaObject> <>9__1;
                /*0x30*/ System.Action<UnityEngine.AndroidJavaObject> <>9__2;

                /*0xcbdd00*/ <>c__DisplayClass22_0();
                /*0xcc3080*/ void <Leave>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch);
                /*0xcc339c*/ void <Leave>b__1(UnityEngine.AndroidJavaObject v);
                /*0xcc33c4*/ void <Leave>b__2(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass23_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
                /*0x18*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;
                /*0x20*/ string pendingParticipantId;
                /*0x28*/ System.Action<bool> callback;
                /*0x30*/ System.Action<UnityEngine.AndroidJavaObject> <>9__1;
                /*0x38*/ System.Action<UnityEngine.AndroidJavaObject> <>9__2;

                /*0xcbde10*/ <>c__DisplayClass23_0();
                /*0xcc33ec*/ void <LeaveDuringTurn>b__0(GooglePlayGames.BasicApi.Multiplayer.Participant pendingParticipant, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch);
                /*0xcc3710*/ void <LeaveDuringTurn>b__1(UnityEngine.AndroidJavaObject v);
                /*0xcc3738*/ void <LeaveDuringTurn>b__2(UnityEngine.AndroidJavaObject e);
            }

            class <>c__DisplayClass24_0
            {
                /*0x10*/ System.Action<bool> callback;
                /*0x18*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
                /*0x20*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;
                /*0x28*/ System.Action<string> <>9__1;
                /*0x30*/ System.Action<UnityEngine.AndroidJavaObject> <>9__2;

                /*0xcbdf10*/ <>c__DisplayClass24_0();
                /*0xcc3760*/ void <Cancel>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch);
                /*0xcc3a9c*/ void <Cancel>b__1(string v);
                /*0xcc3ac4*/ void <Cancel>b__2(UnityEngine.AndroidJavaObject e);
            }

            class <>c__DisplayClass25_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
                /*0x18*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;

                /*0xcbdfd8*/ <>c__DisplayClass25_0();
                /*0xcc3aec*/ void <Dismiss>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch);
            }

            class <>c__DisplayClass26_0
            {
                /*0x10*/ System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
                /*0x18*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
                /*0x20*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;
                /*0x28*/ System.Action<UnityEngine.AndroidJavaObject> <>9__1;
                /*0x30*/ System.Action<UnityEngine.AndroidJavaObject> <>9__2;

                /*0xcbe0d8*/ <>c__DisplayClass26_0();
                /*0xcc3c58*/ void <Rematch>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch);
                /*0xcc3f84*/ void <Rematch>b__1(UnityEngine.AndroidJavaObject turnBasedMatch);
                /*0xcc3fbc*/ void <Rematch>b__2(UnityEngine.AndroidJavaObject e);
            }

            class <>c__DisplayClass27_0
            {
                /*0x10*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
                /*0x18*/ string invitationId;

                /*0xcbe1a0*/ <>c__DisplayClass27_0();
                /*0xcc3fe8*/ void <DeclineInvitation>b__0(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation);
            }

            class <>c__DisplayClass28_0
            {
                /*0x10*/ string invitationId;
                /*0x18*/ System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation> callback;

                /*0xcbe1a8*/ <>c__DisplayClass28_0();
                /*0xcc414c*/ void <FindInvitationWithId>b__0(UnityEngine.AndroidJavaObject annotatedData);
                /*0xcc471c*/ void <FindInvitationWithId>b__1(UnityEngine.AndroidJavaObject e);
            }

            class <>c__DisplayClass29_0
            {
                /*0x10*/ System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback;
                /*0x18*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;

                /*0xcbe1b0*/ <>c__DisplayClass29_0();
                /*0xcc4744*/ void <FindEqualVersionMatch>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch);
            }

            class <>c__DisplayClass30_0
            {
                /*0x10*/ System.Action<bool> onFailure;
                /*0x18*/ string participantId;
                /*0x20*/ System.Action<GooglePlayGames.BasicApi.Multiplayer.Participant, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> onFoundParticipantAndMatch;
                /*0x28*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient <>4__this;
                /*0x30*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match;

                /*0xcbe1b8*/ <>c__DisplayClass30_0();
                /*0xcc48b8*/ void <FindEqualVersionMatchWithParticipant>b__0(bool success, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch foundMatch);
            }

            class <>c__DisplayClass33_0<T>
            {
                /*0x0*/ System.Action<T> toConvert;

                <>c__DisplayClass33_0();
                void <ToOnGameThread>b__0(T val);
            }

            class <>c__DisplayClass33_<T>
            {
                /*0x0*/ T val;
                /*0x0*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.<>c__DisplayClass33_0<T> CS$<>8__locals1;

                <>c__DisplayClass33_();
                void <ToOnGameThread>b__1();
            }

            class <>c__DisplayClass34_0<T1, T2>
            {
                /*0x0*/ System.Action<T1, T2> toConvert;

                <>c__DisplayClass34_0();
                void <ToOnGameThread>b__0(T1 val1, T2 val2);
            }

            class <>c__DisplayClass34_1<T1, T2>
            {
                /*0x0*/ T1 val1;
                /*0x0*/ T2 val2;
                /*0x0*/ GooglePlayGames.Android.AndroidTurnBasedMultiplayerClient.<>c__DisplayClass34_0<T1, T2> CS$<>8__locals1;

                <>c__DisplayClass34_1();
                void <ToOnGameThread>b__1();
            }
        }

        class AndroidVideoClient : GooglePlayGames.BasicApi.Video.IVideoClient
        {
            /*0x10*/ UnityEngine.AndroidJavaObject mVideosClient;
            /*0x18*/ bool mIsCaptureSupported;
            /*0x20*/ GooglePlayGames.Android.AndroidVideoClient.OnCaptureOverlayStateListenerProxy mOnCaptureOverlayStateListenerProxy;

            static System.Action<T1, T2> ToOnGameThread<T1, T2>(System.Action<T1, T2> toConvert);
            static /*0xcc5c04*/ GooglePlayGames.BasicApi.VideoQualityLevel FromVideoQualityLevel(int captureQualityJava);
            static /*0xcc5c10*/ GooglePlayGames.BasicApi.VideoCaptureMode FromVideoCaptureMode(int captureMode);
            static /*0xcc5864*/ int ToVideoCaptureMode(GooglePlayGames.BasicApi.VideoCaptureMode captureMode);
            static /*0xcc5c20*/ GooglePlayGames.BasicApi.Video.VideoCaptureState CreateVideoCaptureState(UnityEngine.AndroidJavaObject videoCaptureState);
            static /*0xcc5f8c*/ GooglePlayGames.BasicApi.Video.VideoCapabilities CreateVideoCapabilities(UnityEngine.AndroidJavaObject videoCapabilities);
            /*0xcc4be4*/ AndroidVideoClient(bool isCaptureSupported, UnityEngine.AndroidJavaObject account);
            /*0xcc4e90*/ void GetCaptureCapabilities(System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities> callback);
            /*0xcc51b0*/ void ShowCaptureOverlay();
            /*0xcc51b8*/ void GetCaptureState(System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCaptureState> callback);
            /*0xcc54d8*/ void IsCaptureAvailable(GooglePlayGames.BasicApi.VideoCaptureMode captureMode, System.Action<GooglePlayGames.BasicApi.ResponseStatus, bool> callback);
            /*0xcc5874*/ bool IsCaptureSupported();
            /*0xcc587c*/ void RegisterCaptureOverlayStateChangedListener(GooglePlayGames.BasicApi.Video.CaptureOverlayStateListener listener);
            /*0xcc5a20*/ void UnregisterCaptureOverlayStateChangedListener();

            class OnCaptureOverlayStateListenerProxy : UnityEngine.AndroidJavaProxy
            {
                /*0x20*/ GooglePlayGames.BasicApi.Video.CaptureOverlayStateListener mListener;

                static /*0xcc65e0*/ GooglePlayGames.BasicApi.VideoCaptureOverlayState FromVideoCaptureOverlayState(int overlayState);
                /*0xcc5b80*/ OnCaptureOverlayStateListenerProxy(GooglePlayGames.BasicApi.Video.CaptureOverlayStateListener listener);
                /*0xcc62f0*/ void onCaptureOverlayStateChanged(int overlayState);

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ GooglePlayGames.Android.AndroidVideoClient.OnCaptureOverlayStateListenerProxy <>4__this;
                    /*0x18*/ int overlayState;

                    /*0xcc63d0*/ <>c__DisplayClass2_0();
                    /*0xcc65f0*/ void <onCaptureOverlayStateChanged>b__0();
                }
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities> callback;

                /*0xcc51a8*/ <>c__DisplayClass4_0();
                /*0xcc66ac*/ void <GetCaptureCapabilities>b__0(UnityEngine.AndroidJavaObject videoCapabilities);
                /*0xcc66e0*/ void <GetCaptureCapabilities>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCaptureState> callback;

                /*0xcc54d0*/ <>c__DisplayClass6_0();
                /*0xcc670c*/ void <GetCaptureState>b__0(UnityEngine.AndroidJavaObject captureState);
                /*0xcc6740*/ void <GetCaptureState>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.ResponseStatus, bool> callback;

                /*0xcc585c*/ <>c__DisplayClass7_0();
                /*0xcc676c*/ void <IsCaptureAvailable>b__0(bool isCaptureAvailable);
                /*0xcc6798*/ void <IsCaptureAvailable>b__1(UnityEngine.AndroidJavaObject exception);
            }

            class <>c__DisplayClass12_0<T1, T2>
            {
                /*0x0*/ System.Action<T1, T2> toConvert;

                <>c__DisplayClass12_0();
                void <ToOnGameThread>b__0(T1 val1, T2 val2);
            }

            class <>c__DisplayClass12_1<T1, T2>
            {
                /*0x0*/ T1 val1;
                /*0x0*/ T2 val2;
                /*0x0*/ GooglePlayGames.Android.AndroidVideoClient.<>c__DisplayClass12_0<T1, T2> CS$<>8__locals1;

                <>c__DisplayClass12_1();
                void <ToOnGameThread>b__1();
            }
        }
    }

    namespace OurUtils
    {
        class Logger
        {
            static /*0x0*/ bool debugLogEnabled;
            static /*0x1*/ bool warningLogEnabled;

            static /*0xcc6dfc*/ Logger();
            static /*0xcc67c4*/ bool get_DebugLogEnabled();
            static /*0xcc681c*/ void set_DebugLogEnabled(bool value);
            static /*0xcc6878*/ bool get_WarningLogEnabled();
            static /*0xcc68d0*/ void set_WarningLogEnabled(bool value);
            static /*0xcc0f24*/ void d(string msg);
            static /*0xcc6934*/ void w(string msg);
            static /*0xcba9c0*/ void e(string msg);
            static /*0xcc6a54*/ string describe(byte[] b);
            static /*0xcc6af8*/ string ToLogMessage(string prefix, string logType, string msg);
            /*0xcc6df4*/ Logger();

            class <>c__DisplayClass8_0
            {
                /*0x10*/ string msg;

                /*0xcc692c*/ <>c__DisplayClass8_0();
                /*0xcc6e48*/ void <d>b__0();
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ string msg;

                /*0xcc6a44*/ <>c__DisplayClass9_0();
                /*0xcc6f1c*/ void <w>b__0();
            }

            class <>c__DisplayClass10_0
            {
                /*0x10*/ string msg;

                /*0xcc6a4c*/ <>c__DisplayClass10_0();
                /*0xcc6fe4*/ void <e>b__0();
            }

            class <>c
            {
                static /*0x0*/ GooglePlayGames.OurUtils.Logger.<> <>9;
                static /*0x8*/ System.Action <>9__12_0;

                static /*0xcc70ac*/ <>c();
                /*0xcc7110*/ <>c();
                /*0xcc7118*/ void <ToLogMessage>b__12_0();
            }
        }

        class Misc
        {
            static /*0xcc7180*/ bool BuffersAreIdentical(byte[] a, byte[] b);
            static /*0xcc7200*/ byte[] GetSubsetBytes(byte[] array, int offset, int length);
            static T CheckNotNull<T>(T value);
            static T CheckNotNull<T>(T value, string paramName);
        }

        class NearbyHelperObject : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ GooglePlayGames.OurUtils.NearbyHelperObject instance;
            static /*0x8*/ double mAdvertisingRemaining;
            static /*0x10*/ double mDiscoveryRemaining;
            static /*0x18*/ GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient mClient;

            static /*0xcc7358*/ void CreateObject(GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient client);
            static /*0xcc74b4*/ double ToSeconds(System.Nullable<System.TimeSpan> span);
            static /*0xcc756c*/ void StartAdvertisingTimer(System.Nullable<System.TimeSpan> span);
            static /*0xcc75d0*/ void StartDiscoveryTimer(System.Nullable<System.TimeSpan> span);
            /*0xcc74ac*/ NearbyHelperObject();
            /*0xcc7634*/ void Awake();
            /*0xcc76a0*/ void OnDisable();
            /*0xcc7738*/ void Update();
        }

        class PlatformUtils
        {
            static /*0xcc793c*/ bool get_Supported();
        }

        class PlayGamesHelperObject : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ GooglePlayGames.OurUtils.PlayGamesHelperObject instance;
            static /*0x8*/ bool sIsDummy;
            static /*0x10*/ System.Collections.Generic.List<System.Action> sQueue;
            static /*0x18*/ bool sQueueEmpty;
            static /*0x20*/ System.Collections.Generic.List<System.Action<bool>> sPauseCallbackList;
            static /*0x28*/ System.Collections.Generic.List<System.Action<bool>> sFocusCallbackList;
            /*0x18*/ System.Collections.Generic.List<System.Action> localQueue;

            static /*0xcc8b9c*/ PlayGamesHelperObject();
            static /*0xcc7bc0*/ void CreateObject();
            static /*0xcc7ef0*/ void RunCoroutine(System.Collections.IEnumerator action);
            static /*0xcc63d8*/ void RunOnGameThread(System.Action action);
            static /*0xcc8874*/ void AddFocusCallback(System.Action<bool> callback);
            static /*0xcc8988*/ bool RemoveFocusCallback(System.Action<bool> callback);
            static /*0xcc8a08*/ void AddPauseCallback(System.Action<bool> callback);
            static /*0xcc8b1c*/ bool RemovePauseCallback(System.Action<bool> callback);
            /*0xcc7d54*/ PlayGamesHelperObject();
            /*0xcc7dd0*/ void Awake();
            /*0xcc7e3c*/ void OnDisable();
            /*0xcc8038*/ void Update();
            /*0xcc82b4*/ void OnApplicationFocus(bool focused);
            /*0xcc8594*/ void OnApplicationPause(bool paused);

            class <>c__DisplayClass10_0
            {
                /*0x10*/ System.Collections.IEnumerator action;

                /*0xcc8030*/ <>c__DisplayClass10_0();
                /*0xcc8ccc*/ void <RunCoroutine>b__0();
            }
        }
    }

    namespace BasicApi
    {
        class Achievement
        {
            static /*0x0*/ System.DateTime UnixEpoch;
            /*0x10*/ string mId;
            /*0x18*/ bool mIsIncremental;
            /*0x19*/ bool mIsRevealed;
            /*0x1a*/ bool mIsUnlocked;
            /*0x1c*/ int mCurrentSteps;
            /*0x20*/ int mTotalSteps;
            /*0x28*/ string mDescription;
            /*0x30*/ string mName;
            /*0x38*/ long mLastModifiedTime;
            /*0x40*/ ulong mPoints;
            /*0x48*/ string mRevealedImageUrl;
            /*0x50*/ string mUnlockedImageUrl;

            static /*0xcc922c*/ Achievement();
            /*0xcc8fe0*/ Achievement();
            /*0xcc8d38*/ string ToString();
            /*0xcc903c*/ bool get_IsIncremental();
            /*0xcc9044*/ void set_IsIncremental(bool value);
            /*0xcc9050*/ int get_CurrentSteps();
            /*0xcc9058*/ void set_CurrentSteps(int value);
            /*0xcc9060*/ int get_TotalSteps();
            /*0xcc9068*/ void set_TotalSteps(int value);
            /*0xcc9070*/ bool get_IsUnlocked();
            /*0xcc9078*/ void set_IsUnlocked(bool value);
            /*0xcc9084*/ bool get_IsRevealed();
            /*0xcc908c*/ void set_IsRevealed(bool value);
            /*0xcc9098*/ string get_Id();
            /*0xcc90a0*/ void set_Id(string value);
            /*0xcc90a8*/ string get_Description();
            /*0xcc90b0*/ void set_Description(string value);
            /*0xcc90b8*/ string get_Name();
            /*0xcc90c0*/ void set_Name(string value);
            /*0xcc90c8*/ System.DateTime get_LastModifiedTime();
            /*0xcc912c*/ void set_LastModifiedTime(System.DateTime value);
            /*0xcc91fc*/ ulong get_Points();
            /*0xcc9204*/ void set_Points(ulong value);
            /*0xcc920c*/ string get_RevealedImageUrl();
            /*0xcc9214*/ void set_RevealedImageUrl(string value);
            /*0xcc921c*/ string get_UnlockedImageUrl();
            /*0xcc9224*/ void set_UnlockedImageUrl(string value);
        }

        enum CommonStatusCodes
        {
            SuccessCached = -1,
            Success = 0,
            ServiceMissing = 1,
            ServiceVersionUpdateRequired = 2,
            ServiceDisabled = 3,
            SignInRequired = 4,
            InvalidAccount = 5,
            ResolutionRequired = 6,
            NetworkError = 7,
            InternalError = 8,
            ServiceInvalid = 9,
            DeveloperError = 10,
            LicenseCheckFailed = 11,
            Error = 13,
            Interrupted = 14,
            Timeout = 15,
            Canceled = 16,
            ApiNotConnected = 17,
            AuthApiInvalidCredentials = 3000,
            AuthApiAccessForbidden = 3001,
            AuthApiClientError = 3002,
            AuthApiServerError = 3003,
            AuthTokenError = 3004,
            AuthUrlResolution = 3005,
        }

        enum DataSource
        {
            ReadCacheOrNetwork = 0,
            ReadNetworkOnly = 1,
        }

        enum ResponseStatus
        {
            Success = 1,
            SuccessWithStale = 2,
            LicenseCheckFailed = -1,
            InternalError = -2,
            NotAuthorized = -3,
            VersionUpdateRequired = -4,
            Timeout = -5,
        }

        enum UIStatus
        {
            Valid = 1,
            InternalError = -2,
            NotAuthorized = -3,
            VersionUpdateRequired = -4,
            Timeout = -5,
            UserClosedUI = -6,
            UiBusy = -12,
            LeftRoom = -18,
        }

        enum LeaderboardStart
        {
            TopScores = 1,
            PlayerCentered = 2,
        }

        enum LeaderboardTimeSpan
        {
            Daily = 1,
            Weekly = 2,
            AllTime = 3,
        }

        enum LeaderboardCollection
        {
            Public = 1,
            Social = 2,
        }

        enum VideoCaptureMode
        {
            Unknown = -1,
            File = 0,
            Stream = 1,
        }

        enum VideoQualityLevel
        {
            Unknown = -1,
            SD = 0,
            HD = 1,
            XHD = 2,
            FullHD = 3,
        }

        enum VideoCaptureOverlayState
        {
            Unknown = -1,
            Shown = 1,
            Started = 2,
            Stopped = 3,
            Dismissed = 4,
        }

        enum Gravity
        {
            TOP = 48,
            BOTTOM = 80,
            LEFT = 3,
            RIGHT = 5,
            CENTER_HORIZONTAL = 1,
        }

        class CommonTypesUtil
        {
            static /*0xcc92b0*/ bool StatusIsSuccess(GooglePlayGames.BasicApi.ResponseStatus status);
            /*0xcc92bc*/ CommonTypesUtil();
        }

        class DummyClient : GooglePlayGames.BasicApi.IPlayGamesClient
        {
            static /*0xcc92f4*/ void LogUsage();
            /*0xcc9a24*/ DummyClient();
            /*0xcc92c4*/ void Authenticate(bool silent, System.Action<GooglePlayGames.BasicApi.SignInStatus> callback);
            /*0xcc9358*/ bool IsAuthenticated();
            /*0xcc936c*/ void SignOut();
            /*0xcc9370*/ string GetIdToken();
            /*0xcc9384*/ string GetUserId();
            /*0xcc93c8*/ string GetServerAuthCode();
            /*0xcc93dc*/ void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback);
            /*0xcc9408*/ string GetUserEmail();
            /*0xcc9450*/ void GetPlayerStats(System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback);
            /*0xcc94e8*/ string GetUserDisplayName();
            /*0xcc952c*/ string GetUserImageUrl();
            /*0xcc9540*/ void LoadUsers(string[] userIds, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback);
            /*0xcc9570*/ void LoadAchievements(System.Action<GooglePlayGames.BasicApi.Achievement[]> callback);
            /*0xcc95a0*/ void UnlockAchievement(string achId, System.Action<bool> callback);
            /*0xcc95d0*/ void RevealAchievement(string achId, System.Action<bool> callback);
            /*0xcc9600*/ void IncrementAchievement(string achId, int steps, System.Action<bool> callback);
            /*0xcc9630*/ void SetStepsAtLeast(string achId, int steps, System.Action<bool> callback);
            /*0xcc9660*/ void ShowAchievementsUI(System.Action<GooglePlayGames.BasicApi.UIStatus> callback);
            /*0xcc9690*/ void ShowLeaderboardUI(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardTimeSpan span, System.Action<GooglePlayGames.BasicApi.UIStatus> callback);
            /*0xcc96c0*/ int LeaderboardMaxResults();
            /*0xcc96c8*/ void LoadScores(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback);
            /*0xcc97e8*/ void LoadMoreScores(GooglePlayGames.BasicApi.ScorePageToken token, int rowCount, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback);
            /*0xcc9878*/ void SubmitScore(string leaderboardId, long score, System.Action<bool> callback);
            /*0xcc98a8*/ void SubmitScore(string leaderboardId, long score, string metadata, System.Action<bool> callback);
            /*0xcc98d8*/ void RequestPermissions(string[] scopes, System.Action<GooglePlayGames.BasicApi.SignInStatus> callback);
            /*0xcc9908*/ bool HasPermissions(string[] scopes);
            /*0xcc991c*/ GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient GetRtmpClient();
            /*0xcc9930*/ GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient GetTbmpClient();
            /*0xcc9944*/ GooglePlayGames.BasicApi.SavedGame.ISavedGameClient GetSavedGameClient();
            /*0xcc9958*/ GooglePlayGames.BasicApi.Events.IEventsClient GetEventsClient();
            /*0xcc996c*/ GooglePlayGames.BasicApi.Video.IVideoClient GetVideoClient();
            /*0xcc9980*/ void RegisterInvitationDelegate(GooglePlayGames.BasicApi.InvitationReceivedDelegate invitationDelegate);
            /*0xcc9984*/ GooglePlayGames.BasicApi.Multiplayer.Invitation GetInvitationFromNotification();
            /*0xcc9998*/ bool HasInvitationFromNotification();
            /*0xcc99ac*/ void LoadFriends(System.Action<bool> callback);
            /*0xcc99d8*/ UnityEngine.SocialPlatforms.IUserProfile[] GetFriends();
            /*0xcc9a20*/ void SetGravityForPopups(GooglePlayGames.BasicApi.Gravity gravity);
        }

        interface IPlayGamesClient
        {
            void Authenticate(bool silent, System.Action<GooglePlayGames.BasicApi.SignInStatus> callback);
            bool IsAuthenticated();
            void SignOut();
            string GetUserId();
            void LoadFriends(System.Action<bool> callback);
            string GetUserDisplayName();
            string GetIdToken();
            string GetServerAuthCode();
            void GetAnotherServerAuthCode(bool reAuthenticateIfNeeded, System.Action<string> callback);
            string GetUserEmail();
            string GetUserImageUrl();
            void GetPlayerStats(System.Action<GooglePlayGames.BasicApi.CommonStatusCodes, GooglePlayGames.BasicApi.PlayerStats> callback);
            void LoadUsers(string[] userIds, System.Action<UnityEngine.SocialPlatforms.IUserProfile[]> callback);
            void LoadAchievements(System.Action<GooglePlayGames.BasicApi.Achievement[]> callback);
            void UnlockAchievement(string achievementId, System.Action<bool> successOrFailureCalllback);
            void RevealAchievement(string achievementId, System.Action<bool> successOrFailureCalllback);
            void IncrementAchievement(string achievementId, int steps, System.Action<bool> successOrFailureCalllback);
            void SetStepsAtLeast(string achId, int steps, System.Action<bool> callback);
            void ShowAchievementsUI(System.Action<GooglePlayGames.BasicApi.UIStatus> callback);
            void ShowLeaderboardUI(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardTimeSpan span, System.Action<GooglePlayGames.BasicApi.UIStatus> callback);
            void LoadScores(string leaderboardId, GooglePlayGames.BasicApi.LeaderboardStart start, int rowCount, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timeSpan, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback);
            void LoadMoreScores(GooglePlayGames.BasicApi.ScorePageToken token, int rowCount, System.Action<GooglePlayGames.BasicApi.LeaderboardScoreData> callback);
            int LeaderboardMaxResults();
            void SubmitScore(string leaderboardId, long score, System.Action<bool> successOrFailureCalllback);
            void SubmitScore(string leaderboardId, long score, string metadata, System.Action<bool> successOrFailureCalllback);
            void RequestPermissions(string[] scopes, System.Action<GooglePlayGames.BasicApi.SignInStatus> callback);
            bool HasPermissions(string[] scopes);
            GooglePlayGames.BasicApi.Multiplayer.IRealTimeMultiplayerClient GetRtmpClient();
            GooglePlayGames.BasicApi.Multiplayer.ITurnBasedMultiplayerClient GetTbmpClient();
            GooglePlayGames.BasicApi.SavedGame.ISavedGameClient GetSavedGameClient();
            GooglePlayGames.BasicApi.Events.IEventsClient GetEventsClient();
            GooglePlayGames.BasicApi.Video.IVideoClient GetVideoClient();
            void RegisterInvitationDelegate(GooglePlayGames.BasicApi.InvitationReceivedDelegate invitationDelegate);
            UnityEngine.SocialPlatforms.IUserProfile[] GetFriends();
            void SetGravityForPopups(GooglePlayGames.BasicApi.Gravity gravity);
        }

        class InvitationReceivedDelegate : System.MulticastDelegate
        {
            /*0xcc9a2c*/ InvitationReceivedDelegate(object object, nint method);
            /*0xcc9b5c*/ void Invoke(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation, bool shouldAutoAccept);
            /*0xcc9b74*/ System.IAsyncResult BeginInvoke(GooglePlayGames.BasicApi.Multiplayer.Invitation invitation, bool shouldAutoAccept, System.AsyncCallback callback, object object);
            /*0xcc9c0c*/ void EndInvoke(System.IAsyncResult result);
        }

        class LeaderboardScoreData
        {
            /*0x10*/ string mId;
            /*0x18*/ GooglePlayGames.BasicApi.ResponseStatus mStatus;
            /*0x20*/ ulong mApproxCount;
            /*0x28*/ string mTitle;
            /*0x30*/ UnityEngine.SocialPlatforms.IScore mPlayerScore;
            /*0x38*/ GooglePlayGames.BasicApi.ScorePageToken mPrevPage;
            /*0x40*/ GooglePlayGames.BasicApi.ScorePageToken mNextPage;
            /*0x48*/ System.Collections.Generic.List<GooglePlayGames.PlayGamesScore> mScores;

            /*0xcc9c18*/ LeaderboardScoreData(string leaderboardId);
            /*0xcc9750*/ LeaderboardScoreData(string leaderboardId, GooglePlayGames.BasicApi.ResponseStatus status);
            /*0xcc9ca8*/ bool get_Valid();
            /*0xcc9cbc*/ GooglePlayGames.BasicApi.ResponseStatus get_Status();
            /*0xcc9cc4*/ void set_Status(GooglePlayGames.BasicApi.ResponseStatus value);
            /*0xcc9ccc*/ ulong get_ApproximateCount();
            /*0xcc9cd4*/ void set_ApproximateCount(ulong value);
            /*0xcc9cdc*/ string get_Title();
            /*0xcc9ce4*/ void set_Title(string value);
            /*0xcc9cec*/ string get_Id();
            /*0xcc9cf4*/ void set_Id(string value);
            /*0xcc9cfc*/ UnityEngine.SocialPlatforms.IScore get_PlayerScore();
            /*0xcc9d04*/ void set_PlayerScore(UnityEngine.SocialPlatforms.IScore value);
            /*0xcc9d0c*/ UnityEngine.SocialPlatforms.IScore[] get_Scores();
            /*0xcc9d5c*/ int AddScore(GooglePlayGames.PlayGamesScore score);
            /*0xcc9e18*/ GooglePlayGames.BasicApi.ScorePageToken get_PrevPageToken();
            /*0xcc9e20*/ void set_PrevPageToken(GooglePlayGames.BasicApi.ScorePageToken value);
            /*0xcc9e28*/ GooglePlayGames.BasicApi.ScorePageToken get_NextPageToken();
            /*0xcc9e30*/ void set_NextPageToken(GooglePlayGames.BasicApi.ScorePageToken value);
            /*0xcc9e38*/ string ToString();
        }

        class PlayerStats
        {
            static /*0x0*/ float UNSET_VALUE;
            /*0x10*/ bool mValid;
            /*0x14*/ int mNumberOfPurchases;
            /*0x18*/ float mAvgSessionLength;
            /*0x1c*/ int mDaysSinceLastPlayed;
            /*0x20*/ int mNumberOfSessions;
            /*0x24*/ float mSessPercentile;
            /*0x28*/ float mSpendPercentile;
            /*0x2c*/ float mSpendProbability;
            /*0x30*/ float mChurnProbability;
            /*0x34*/ float mHighSpenderProbability;
            /*0x38*/ float mTotalSpendNext28Days;

            static /*0xcca4d0*/ PlayerStats();
            /*0xcc9fc8*/ PlayerStats(int numberOfPurchases, float avgSessionLength, int daysSinceLastPlayed, int numberOfSessions, float sessPercentile, float spendPercentile, float spendProbability, float churnProbability, float highSpenderProbability, float totalSpendNext28Days);
            /*0xcc94cc*/ PlayerStats();
            /*0xcca058*/ bool get_Valid();
            /*0xcca060*/ int get_NumberOfPurchases();
            /*0xcca068*/ float get_AvgSessionLength();
            /*0xcca070*/ int get_DaysSinceLastPlayed();
            /*0xcca078*/ int get_NumberOfSessions();
            /*0xcca080*/ float get_SessPercentile();
            /*0xcca088*/ float get_SpendPercentile();
            /*0xcca090*/ float get_SpendProbability();
            /*0xcca098*/ float get_ChurnProbability();
            /*0xcca0a0*/ float get_HighSpenderProbability();
            /*0xcca0a8*/ float get_TotalSpendNext28Days();
            /*0xcca0b0*/ bool HasNumberOfPurchases();
            /*0xcca130*/ bool HasAvgSessionLength();
            /*0xcca1a0*/ bool HasDaysSinceLastPlayed();
            /*0xcca220*/ bool HasNumberOfSessions();
            /*0xcca2a0*/ bool HasSessPercentile();
            /*0xcca310*/ bool HasSpendPercentile();
            /*0xcca380*/ bool HasChurnProbability();
            /*0xcca3f0*/ bool HasHighSpenderProbability();
            /*0xcca460*/ bool HasTotalSpendNext28Days();
        }

        struct PlayGamesClientConfiguration
        {
            static /*0x0*/ GooglePlayGames.BasicApi.PlayGamesClientConfiguration DefaultConfiguration;
            /*0x10*/ bool mEnableSavedGames;
            /*0x18*/ string[] mScopes;
            /*0x20*/ bool mRequestAuthCode;
            /*0x21*/ bool mForceRefresh;
            /*0x22*/ bool mHidePopups;
            /*0x23*/ bool mRequestEmail;
            /*0x24*/ bool mRequestIdToken;
            /*0x28*/ string mAccountName;
            /*0x30*/ GooglePlayGames.BasicApi.InvitationReceivedDelegate mInvitationDelegate;
            /*0x38*/ GooglePlayGames.BasicApi.Multiplayer.MatchDelegate mMatchDelegate;

            static /*0xccaa78*/ PlayGamesClientConfiguration();
            static /*0xcca640*/ bool op_Equality(GooglePlayGames.BasicApi.PlayGamesClientConfiguration c1, GooglePlayGames.BasicApi.PlayGamesClientConfiguration c2);
            static /*0xcca758*/ bool op_Inequality(GooglePlayGames.BasicApi.PlayGamesClientConfiguration c1, GooglePlayGames.BasicApi.PlayGamesClientConfiguration c2);
            /*0xcca51c*/ PlayGamesClientConfiguration(GooglePlayGames.BasicApi.PlayGamesClientConfiguration.Builder builder);
            /*0xcca600*/ bool get_EnableSavedGames();
            /*0xcca608*/ bool get_IsHidingPopups();
            /*0xcca610*/ bool get_IsRequestingAuthCode();
            /*0xcca618*/ bool get_IsForcingRefresh();
            /*0xcca620*/ bool get_IsRequestingEmail();
            /*0xcca628*/ bool get_IsRequestingIdToken();
            /*0xcca630*/ string get_AccountName();
            /*0xcca638*/ string[] get_Scopes();
            /*0xcca810*/ GooglePlayGames.BasicApi.InvitationReceivedDelegate get_InvitationDelegate();
            /*0xcca818*/ GooglePlayGames.BasicApi.Multiplayer.MatchDelegate get_MatchDelegate();
            /*0xcca820*/ int GetHashCode();
            /*0xcca9a4*/ bool Equals(object obj);

            class Builder
            {
                /*0x10*/ bool mEnableSaveGames;
                /*0x18*/ System.Collections.Generic.List<string> mScopes;
                /*0x20*/ bool mHidePopups;
                /*0x21*/ bool mRequestAuthCode;
                /*0x22*/ bool mForceRefresh;
                /*0x23*/ bool mRequestEmail;
                /*0x24*/ bool mRequestIdToken;
                /*0x28*/ string mAccountName;
                /*0x30*/ GooglePlayGames.BasicApi.InvitationReceivedDelegate mInvitationDelegate;
                /*0x38*/ GooglePlayGames.BasicApi.Multiplayer.MatchDelegate mMatchDelegate;

                /*0xccab20*/ Builder();
                /*0xccaca4*/ GooglePlayGames.BasicApi.PlayGamesClientConfiguration.Builder EnableSavedGames();
                /*0xccacb0*/ GooglePlayGames.BasicApi.PlayGamesClientConfiguration.Builder EnableHidePopups();
                /*0xccacbc*/ GooglePlayGames.BasicApi.PlayGamesClientConfiguration.Builder RequestServerAuthCode(bool forceRefresh);
                /*0xccacd0*/ GooglePlayGames.BasicApi.PlayGamesClientConfiguration.Builder RequestEmail();
                /*0xccacdc*/ GooglePlayGames.BasicApi.PlayGamesClientConfiguration.Builder RequestIdToken();
                /*0xccace8*/ GooglePlayGames.BasicApi.PlayGamesClientConfiguration.Builder SetAccountName(string accountName);
                /*0xccacf0*/ GooglePlayGames.BasicApi.PlayGamesClientConfiguration.Builder AddOauthScope(string scope);
                /*0xccade0*/ GooglePlayGames.BasicApi.PlayGamesClientConfiguration.Builder WithInvitationDelegate(GooglePlayGames.BasicApi.InvitationReceivedDelegate invitationDelegate);
                /*0xccae40*/ GooglePlayGames.BasicApi.PlayGamesClientConfiguration.Builder WithMatchDelegate(GooglePlayGames.BasicApi.Multiplayer.MatchDelegate matchDelegate);
                /*0xccac8c*/ GooglePlayGames.BasicApi.PlayGamesClientConfiguration Build();
                /*0xccaea0*/ bool HasEnableSaveGames();
                /*0xccaea8*/ bool IsRequestingAuthCode();
                /*0xccaeb0*/ bool IsHidingPopups();
                /*0xccaeb8*/ bool IsForcingRefresh();
                /*0xccaec0*/ bool IsRequestingEmail();
                /*0xccaec8*/ bool IsRequestingIdToken();
                /*0xccaed0*/ string GetAccountName();
                /*0xcca58c*/ string[] getScopes();
                /*0xccaed8*/ GooglePlayGames.BasicApi.Multiplayer.MatchDelegate GetMatchDelegate();
                /*0xccaee0*/ GooglePlayGames.BasicApi.InvitationReceivedDelegate GetInvitationDelegate();

                class <>c
                {
                    static /*0x0*/ GooglePlayGames.BasicApi.PlayGamesClientConfiguration.Builder.<> <>9;
                    static /*0x8*/ GooglePlayGames.BasicApi.InvitationReceivedDelegate <>9__30_0;
                    static /*0x10*/ GooglePlayGames.BasicApi.Multiplayer.MatchDelegate <>9__30_1;

                    static /*0xccb018*/ <>c();
                    /*0xccb07c*/ <>c();
                    /*0xccb084*/ void <.ctor>b__30_0(GooglePlayGames.BasicApi.Multiplayer.Invitation <p0>, bool <p1>);
                    /*0xccb088*/ void <.ctor>b__30_1(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch <p0>, bool <p1>);
                }
            }
        }

        enum ScorePageDirection
        {
            Forward = 1,
            Backward = 2,
        }

        class ScorePageToken
        {
            /*0x10*/ string mId;
            /*0x18*/ object mInternalObject;
            /*0x20*/ GooglePlayGames.BasicApi.LeaderboardCollection mCollection;
            /*0x24*/ GooglePlayGames.BasicApi.LeaderboardTimeSpan mTimespan;
            /*0x28*/ GooglePlayGames.BasicApi.ScorePageDirection mDirection;

            /*0xccb08c*/ ScorePageToken(object internalObject, string id, GooglePlayGames.BasicApi.LeaderboardCollection collection, GooglePlayGames.BasicApi.LeaderboardTimeSpan timespan, GooglePlayGames.BasicApi.ScorePageDirection direction);
            /*0xccb0dc*/ GooglePlayGames.BasicApi.LeaderboardCollection get_Collection();
            /*0xccb0e4*/ GooglePlayGames.BasicApi.LeaderboardTimeSpan get_TimeSpan();
            /*0xccb0ec*/ GooglePlayGames.BasicApi.ScorePageDirection get_Direction();
            /*0xccb0f4*/ string get_LeaderboardId();
            /*0xccb0fc*/ object get_InternalObject();
        }

        class SignInHelper
        {
            static string PromptSignInKey = "prompt_sign_in";
            static /*0x0*/ int True;
            static /*0x4*/ int False;

            static /*0xccb228*/ SignInHelper();
            static /*0xcba7fc*/ GooglePlayGames.BasicApi.SignInStatus ToSignInStatus(int code);
            static /*0xccb104*/ void SetPromptUiSignIn(bool value);
            static /*0xccb194*/ bool ShouldPromptUiSignIn();
            /*0xccb220*/ SignInHelper();
        }

        enum SignInInteractivity
        {
            NoPrompt = 0,
            CanPromptAlways = 1,
            CanPromptOnce = 2,
        }

        enum SignInStatus
        {
            Success = 0,
            UiSignInRequired = 1,
            DeveloperError = 2,
            NetworkError = 3,
            InternalError = 4,
            Canceled = 5,
            AlreadyInProgress = 6,
            Failed = 7,
            NotAuthenticated = 8,
        }

        namespace Video
        {
            interface CaptureOverlayStateListener
            {
                void OnCaptureOverlayStateChanged(GooglePlayGames.BasicApi.VideoCaptureOverlayState overlayState);
            }

            interface IVideoClient
            {
                void GetCaptureCapabilities(System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCapabilities> callback);
                void ShowCaptureOverlay();
                void GetCaptureState(System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Video.VideoCaptureState> callback);
                void IsCaptureAvailable(GooglePlayGames.BasicApi.VideoCaptureMode captureMode, System.Action<GooglePlayGames.BasicApi.ResponseStatus, bool> callback);
                bool IsCaptureSupported();
                void RegisterCaptureOverlayStateChangedListener(GooglePlayGames.BasicApi.Video.CaptureOverlayStateListener listener);
                void UnregisterCaptureOverlayStateChangedListener();
            }

            class VideoCapabilities
            {
                /*0x10*/ bool mIsCameraSupported;
                /*0x11*/ bool mIsMicSupported;
                /*0x12*/ bool mIsWriteStorageSupported;
                /*0x18*/ bool[] mCaptureModesSupported;
                /*0x20*/ bool[] mQualityLevelsSupported;

                /*0xcc629c*/ VideoCapabilities(bool isCameraSupported, bool isMicSupported, bool isWriteStorageSupported, bool[] captureModesSupported, bool[] qualityLevelsSupported);
                /*0xccb278*/ bool get_IsCameraSupported();
                /*0xccb280*/ bool get_IsMicSupported();
                /*0xccb288*/ bool get_IsWriteStorageSupported();
                /*0xccb290*/ bool SupportsCaptureMode(GooglePlayGames.BasicApi.VideoCaptureMode captureMode);
                /*0xccb33c*/ bool SupportsQualityLevel(GooglePlayGames.BasicApi.VideoQualityLevel qualityLevel);
                /*0xccb3e8*/ string ToString();

                class <>c
                {
                    static /*0x0*/ GooglePlayGames.BasicApi.Video.VideoCapabilities.<> <>9;
                    static /*0x8*/ System.Func<bool, string> <>9__14_0;
                    static /*0x10*/ System.Func<bool, string> <>9__14_1;

                    static /*0xccb77c*/ <>c();
                    /*0xccb7e0*/ <>c();
                    /*0xccb7e8*/ string <ToString>b__14_0(bool p);
                    /*0xccb808*/ string <ToString>b__14_1(bool p);
                }
            }

            class VideoCaptureState
            {
                /*0x10*/ bool mIsCapturing;
                /*0x14*/ GooglePlayGames.BasicApi.VideoCaptureMode mCaptureMode;
                /*0x18*/ GooglePlayGames.BasicApi.VideoQualityLevel mQualityLevel;
                /*0x1c*/ bool mIsOverlayVisible;
                /*0x1d*/ bool mIsPaused;

                /*0xcc5f38*/ VideoCaptureState(bool isCapturing, GooglePlayGames.BasicApi.VideoCaptureMode captureMode, GooglePlayGames.BasicApi.VideoQualityLevel qualityLevel, bool isOverlayVisible, bool isPaused);
                /*0xccb828*/ bool get_IsCapturing();
                /*0xccb830*/ GooglePlayGames.BasicApi.VideoCaptureMode get_CaptureMode();
                /*0xccb838*/ GooglePlayGames.BasicApi.VideoQualityLevel get_QualityLevel();
                /*0xccb840*/ bool get_IsOverlayVisible();
                /*0xccb848*/ bool get_IsPaused();
                /*0xccb850*/ string ToString();
            }
        }

        namespace SavedGame
        {
            enum ConflictResolutionStrategy
            {
                UseLongestPlaytime = 0,
                UseOriginal = 1,
                UseUnmerged = 2,
                UseManual = 3,
                UseLastKnownGood = 4,
                UseMostRecentlySaved = 5,
            }

            enum SavedGameRequestStatus
            {
                Success = 1,
                TimeoutError = -1,
                InternalError = -2,
                AuthenticationError = -3,
                BadInputError = -4,
            }

            enum SelectUIStatus
            {
                SavedGameSelected = 1,
                UserClosedUI = 2,
                InternalError = -1,
                TimeoutError = -2,
                AuthenticationError = -3,
                BadInputError = -4,
                UiBusy = -5,
            }

            class ConflictCallback : System.MulticastDelegate
            {
                /*0xccba7c*/ ConflictCallback(object object, nint method);
                /*0xccbbac*/ void Invoke(GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original, byte[] originalData, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged, byte[] unmergedData);
                /*0xccbbc0*/ System.IAsyncResult BeginInvoke(GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original, byte[] originalData, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged, byte[] unmergedData, System.AsyncCallback callback, object object);
                /*0xccbbf0*/ void EndInvoke(System.IAsyncResult result);
            }

            interface ISavedGameClient
            {
                void OpenWithAutomaticConflictResolution(string filename, GooglePlayGames.BasicApi.DataSource source, GooglePlayGames.BasicApi.SavedGame.ConflictResolutionStrategy resolutionStrategy, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback);
                void OpenWithManualConflictResolution(string filename, GooglePlayGames.BasicApi.DataSource source, bool prefetchDataOnConflict, GooglePlayGames.BasicApi.SavedGame.ConflictCallback conflictCallback, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> completedCallback);
                void ReadBinaryData(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Byte[]> completedCallback);
                void ShowSelectSavedGameUI(string uiTitle, uint maxDisplayedSavedGames, bool showCreateSaveUI, bool showDeleteSaveUI, System.Action<GooglePlayGames.BasicApi.SavedGame.SelectUIStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback);
                void CommitUpdate(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata, GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate updateForMetadata, byte[] updatedBinaryData, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata> callback);
                void FetchAllSavedGames(GooglePlayGames.BasicApi.DataSource source, System.Action<GooglePlayGames.BasicApi.SavedGame.SavedGameRequestStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata>> callback);
                void Delete(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata metadata);
            }

            interface IConflictResolver
            {
                void ChooseMetadata(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata);
                void ResolveConflict(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata chosenMetadata, GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate metadataUpdate, byte[] updatedData);
            }

            interface ISavedGameMetadata
            {
                bool get_IsOpen();
                string get_Filename();
                string get_Description();
                string get_CoverImageURL();
                System.TimeSpan get_TotalTimePlayed();
                System.DateTime get_LastModifiedTimestamp();
            }

            struct SavedGameMetadataUpdate
            {
                /*0x10*/ bool mDescriptionUpdated;
                /*0x18*/ string mNewDescription;
                /*0x20*/ bool mCoverImageUpdated;
                /*0x28*/ byte[] mNewPngCoverImage;
                /*0x30*/ System.Nullable<System.TimeSpan> mNewPlayedTime;

                /*0xccbbfc*/ SavedGameMetadataUpdate(GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate.Builder builder);
                /*0xccbc40*/ bool get_IsDescriptionUpdated();
                /*0xccbc48*/ string get_UpdatedDescription();
                /*0xccbc50*/ bool get_IsCoverImageUpdated();
                /*0xccbc58*/ byte[] get_UpdatedPngCoverImage();
                /*0xccbc60*/ bool get_IsPlayedTimeUpdated();
                /*0xccbc9c*/ System.Nullable<System.TimeSpan> get_UpdatedPlayedTime();

                struct Builder
                {
                    /*0x10*/ bool mDescriptionUpdated;
                    /*0x18*/ string mNewDescription;
                    /*0x20*/ bool mCoverImageUpdated;
                    /*0x28*/ byte[] mNewPngCoverImage;
                    /*0x30*/ System.Nullable<System.TimeSpan> mNewPlayedTime;

                    /*0xccbca8*/ GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate.Builder WithUpdatedDescription(string description);
                    /*0xccbd20*/ GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate.Builder WithUpdatedPngCoverImage(byte[] newPngCoverImage);
                    /*0xccbd40*/ GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate.Builder WithUpdatedPlayedTime(System.TimeSpan newPlayedTime);
                    /*0xccbe24*/ GooglePlayGames.BasicApi.SavedGame.SavedGameMetadataUpdate Build();
                }
            }
        }

        namespace Nearby
        {
            struct AdvertisingResult
            {
                /*0x10*/ GooglePlayGames.BasicApi.ResponseStatus mStatus;
                /*0x18*/ string mLocalEndpointName;

                /*0xccbe58*/ AdvertisingResult(GooglePlayGames.BasicApi.ResponseStatus status, string localEndpointName);
                /*0xccbebc*/ bool get_Succeeded();
                /*0xccbecc*/ GooglePlayGames.BasicApi.ResponseStatus get_Status();
                /*0xccbed4*/ string get_LocalEndpointName();
            }

            struct ConnectionRequest
            {
                /*0x10*/ GooglePlayGames.BasicApi.Nearby.EndpointDetails mRemoteEndpoint;
                /*0x28*/ byte[] mPayload;

                /*0xccbedc*/ ConnectionRequest(string remoteEndpointId, string remoteEndpointName, string serviceId, byte[] payload);
                /*0xccc04c*/ GooglePlayGames.BasicApi.Nearby.EndpointDetails get_RemoteEndpoint();
                /*0xccc060*/ byte[] get_Payload();
            }

            struct ConnectionResponse
            {
                static /*0x0*/ byte[] EmptyPayload;
                /*0x10*/ long mLocalClientId;
                /*0x18*/ string mRemoteEndpointId;
                /*0x20*/ GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Status mResponseStatus;
                /*0x28*/ byte[] mPayload;

                static /*0xccc3e0*/ ConnectionResponse();
                static /*0xccc12c*/ GooglePlayGames.BasicApi.Nearby.ConnectionResponse Rejected(long localClientId, string remoteEndpointId);
                static /*0xccc1b0*/ GooglePlayGames.BasicApi.Nearby.ConnectionResponse NetworkNotConnected(long localClientId, string remoteEndpointId);
                static /*0xccc234*/ GooglePlayGames.BasicApi.Nearby.ConnectionResponse InternalError(long localClientId, string remoteEndpointId);
                static /*0xccc2b8*/ GooglePlayGames.BasicApi.Nearby.ConnectionResponse EndpointNotConnected(long localClientId, string remoteEndpointId);
                static /*0xccc33c*/ GooglePlayGames.BasicApi.Nearby.ConnectionResponse Accepted(long localClientId, string remoteEndpointId, byte[] payload);
                static /*0xccc35c*/ GooglePlayGames.BasicApi.Nearby.ConnectionResponse AlreadyConnected(long localClientId, string remoteEndpointId);
                /*0xccc068*/ ConnectionResponse(long localClientId, string remoteEndpointId, GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Status code, byte[] payload);
                /*0xccc10c*/ long get_LocalClientId();
                /*0xccc114*/ string get_RemoteEndpointId();
                /*0xccc11c*/ GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Status get_ResponseStatus();
                /*0xccc124*/ byte[] get_Payload();

                enum Status
                {
                    Accepted = 0,
                    Rejected = 1,
                    ErrorInternal = 2,
                    ErrorNetworkNotConnected = 3,
                    ErrorEndpointNotConnected = 4,
                    ErrorAlreadyConnected = 5,
                }
            }

            class DummyNearbyConnectionClient : GooglePlayGames.BasicApi.Nearby.INearbyConnectionClient
            {
                /*0xcccaa0*/ DummyNearbyConnectionClient();
                /*0xccc448*/ int MaxUnreliableMessagePayloadLength();
                /*0xccc450*/ int MaxReliableMessagePayloadLength();
                /*0xccc458*/ void SendReliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload);
                /*0xccc4c0*/ void SendUnreliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload);
                /*0xccc528*/ void StartAdvertising(string name, System.Collections.Generic.List<string> appIdentifiers, System.Nullable<System.TimeSpan> advertisingDuration, System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult> resultCallback, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionRequest> connectionRequestCallback);
                /*0xccc5cc*/ void StopAdvertising();
                /*0xccc634*/ void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionResponse> responseCallback, GooglePlayGames.BasicApi.Nearby.IMessageListener listener);
                /*0xccc728*/ void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, GooglePlayGames.BasicApi.Nearby.IMessageListener listener);
                /*0xccc790*/ void StartDiscovery(string serviceId, System.Nullable<System.TimeSpan> advertisingTimeout, GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener);
                /*0xccc7f8*/ void StopDiscovery(string serviceId);
                /*0xccc860*/ void RejectConnectionRequest(string requestingEndpointId);
                /*0xccc8c8*/ void DisconnectFromEndpoint(string remoteEndpointId);
                /*0xccc930*/ void StopAllConnections();
                /*0xccc998*/ string LocalEndpointId();
                /*0xccc9e0*/ string LocalDeviceId();
                /*0xccca20*/ string GetAppBundleId();
                /*0xccca60*/ string GetServiceId();
            }

            struct EndpointDetails
            {
                /*0x10*/ string mEndpointId;
                /*0x18*/ string mName;
                /*0x20*/ string mServiceId;

                /*0xccbfc0*/ EndpointDetails(string endpointId, string name, string serviceId);
                /*0xcccaa8*/ string get_EndpointId();
                /*0xcccab0*/ string get_Name();
                /*0xcccab8*/ string get_ServiceId();
            }

            interface INearbyConnectionClient
            {
                int MaxUnreliableMessagePayloadLength();
                int MaxReliableMessagePayloadLength();
                void SendReliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload);
                void SendUnreliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload);
                void StartAdvertising(string name, System.Collections.Generic.List<string> appIdentifiers, System.Nullable<System.TimeSpan> advertisingDuration, System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult> resultCallback, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionRequest> connectionRequestCallback);
                void StopAdvertising();
                void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionResponse> responseCallback, GooglePlayGames.BasicApi.Nearby.IMessageListener listener);
                void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, GooglePlayGames.BasicApi.Nearby.IMessageListener listener);
                void StartDiscovery(string serviceId, System.Nullable<System.TimeSpan> advertisingTimeout, GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener);
                void StopDiscovery(string serviceId);
                void RejectConnectionRequest(string requestingEndpointId);
                void DisconnectFromEndpoint(string remoteEndpointId);
                void StopAllConnections();
                string GetAppBundleId();
                string GetServiceId();
            }

            interface IMessageListener
            {
                void OnMessageReceived(string remoteEndpointId, byte[] data, bool isReliableMessage);
                void OnRemoteEndpointDisconnected(string remoteEndpointId);
            }

            interface IDiscoveryListener
            {
                void OnEndpointFound(GooglePlayGames.BasicApi.Nearby.EndpointDetails discoveredEndpoint);
                void OnEndpointLost(string lostEndpointId);
            }

            enum InitializationStatus
            {
                Success = 0,
                VersionUpdateRequired = 1,
                InternalError = 2,
            }

            struct NearbyConnectionConfiguration
            {
                static int MaxUnreliableMessagePayloadLength = 1168;
                static int MaxReliableMessagePayloadLength = 4096;
                /*0x10*/ System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> mInitializationCallback;
                /*0x18*/ long mLocalClientId;

                /*0xcccac0*/ NearbyConnectionConfiguration(System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> callback, long localClientId);
                /*0xcccb20*/ long get_LocalClientId();
                /*0xcccb28*/ System.Action<GooglePlayGames.BasicApi.Nearby.InitializationStatus> get_InitializationCallback();
            }
        }

        namespace Multiplayer
        {
            class Invitation
            {
                /*0x10*/ GooglePlayGames.BasicApi.Multiplayer.Invitation.InvType mInvitationType;
                /*0x18*/ string mInvitationId;
                /*0x20*/ GooglePlayGames.BasicApi.Multiplayer.Participant mInviter;
                /*0x28*/ int mVariant;
                /*0x30*/ System.DateTime mCreationTime;

                /*0xcccb30*/ Invitation(GooglePlayGames.BasicApi.Multiplayer.Invitation.InvType invType, string invId, GooglePlayGames.BasicApi.Multiplayer.Participant inviter, int variant, System.DateTime creationTime);
                /*0xcccb84*/ GooglePlayGames.BasicApi.Multiplayer.Invitation.InvType get_InvitationType();
                /*0xcccb8c*/ string get_InvitationId();
                /*0xcccb94*/ GooglePlayGames.BasicApi.Multiplayer.Participant get_Inviter();
                /*0xcccb9c*/ int get_Variant();
                /*0xcccba4*/ System.DateTime get_CreationTime();
                /*0xcccbac*/ string ToString();

                enum InvType
                {
                    RealTime = 0,
                    TurnBased = 1,
                    Unknown = 2,
                }
            }

            interface IRealTimeMultiplayerClient
            {
                void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener);
                void CreateQuickGame(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitMask, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener);
                void CreateWithInvitationScreen(uint minOpponents, uint maxOppponents, uint variant, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener);
                void ShowWaitingRoomUI();
                void GetAllInvitations(System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> callback);
                void AcceptFromInbox(GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener);
                void AcceptInvitation(string invitationId, GooglePlayGames.BasicApi.Multiplayer.RealTimeMultiplayerListener listener);
                void SendMessageToAll(bool reliable, byte[] data);
                void SendMessageToAll(bool reliable, byte[] data, int offset, int length);
                void SendMessage(bool reliable, string participantId, byte[] data);
                void SendMessage(bool reliable, string participantId, byte[] data, int offset, int length);
                System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> GetConnectedParticipants();
                GooglePlayGames.BasicApi.Multiplayer.Participant GetSelf();
                GooglePlayGames.BasicApi.Multiplayer.Participant GetParticipant(string participantId);
                GooglePlayGames.BasicApi.Multiplayer.Invitation GetInvitation();
                void LeaveRoom();
                bool IsRoomConnected();
                void DeclineInvitation(string invitationId);
            }

            interface ITurnBasedMultiplayerClient
            {
                void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
                void CreateQuickMatch(uint minOpponents, uint maxOpponents, uint variant, ulong exclusiveBitmask, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
                void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
                void CreateWithInvitationScreen(uint minOpponents, uint maxOpponents, uint variant, System.Action<GooglePlayGames.BasicApi.UIStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
                void GetAllInvitations(System.Action<GooglePlayGames.BasicApi.Multiplayer.Invitation[]> callback);
                void GetAllMatches(System.Action<GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch[]> callback);
                void GetMatch(string matchId, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
                void AcceptFromInbox(System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
                void AcceptInvitation(string invitationId, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
                void RegisterMatchDelegate(GooglePlayGames.BasicApi.Multiplayer.MatchDelegate del);
                void TakeTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, string pendingParticipantId, System.Action<bool> callback);
                int GetMaxMatchDataSize();
                void Finish(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, byte[] data, GooglePlayGames.BasicApi.Multiplayer.MatchOutcome outcome, System.Action<bool> callback);
                void AcknowledgeFinished(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> callback);
                void Leave(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> callback);
                void LeaveDuringTurn(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, string pendingParticipantId, System.Action<bool> callback);
                void Cancel(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool> callback);
                void Dismiss(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match);
                void Rematch(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, System.Action<bool, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch> callback);
                void DeclineInvitation(string invitationId);
            }

            class MatchDelegate : System.MulticastDelegate
            {
                /*0xccaee8*/ MatchDelegate(object object, nint method);
                /*0xcccd98*/ void Invoke(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, bool shouldAutoLaunch);
                /*0xcccdb0*/ System.IAsyncResult BeginInvoke(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, bool shouldAutoLaunch, System.AsyncCallback callback, object object);
                /*0xccce48*/ void EndInvoke(System.IAsyncResult result);
            }

            class MatchOutcome
            {
                static uint PlacementUnset = 0;
                /*0x10*/ System.Collections.Generic.List<string> mParticipantIds;
                /*0x18*/ System.Collections.Generic.Dictionary<string, uint> mPlacements;
                /*0x20*/ System.Collections.Generic.Dictionary<string, GooglePlayGames.BasicApi.Multiplayer.MatchOutcome.ParticipantResult> mResults;

                /*0xccce54*/ MatchOutcome();
                /*0xcccf58*/ void SetParticipantResult(string participantId, GooglePlayGames.BasicApi.Multiplayer.MatchOutcome.ParticipantResult result, uint placement);
                /*0xccd08c*/ void SetParticipantResult(string participantId, GooglePlayGames.BasicApi.Multiplayer.MatchOutcome.ParticipantResult result);
                /*0xccd094*/ void SetParticipantResult(string participantId, uint placement);
                /*0xccd0a0*/ System.Collections.Generic.List<string> get_ParticipantIds();
                /*0xcc2b84*/ GooglePlayGames.BasicApi.Multiplayer.MatchOutcome.ParticipantResult GetResultFor(string participantId);
                /*0xcc2c18*/ uint GetPlacementFor(string participantId);
                /*0xccd0a8*/ string ToString();

                enum ParticipantResult
                {
                    Unset = -1,
                    None = 0,
                    Win = 1,
                    Loss = 2,
                    Tie = 3,
                }
            }

            class Participant : System.IComparable<GooglePlayGames.BasicApi.Multiplayer.Participant>
            {
                /*0x10*/ string mDisplayName;
                /*0x18*/ string mParticipantId;
                /*0x20*/ GooglePlayGames.BasicApi.Multiplayer.Participant.ParticipantStatus mStatus;
                /*0x28*/ GooglePlayGames.BasicApi.Multiplayer.Player mPlayer;
                /*0x30*/ bool mIsConnectedToRoom;

                /*0xcbe280*/ Participant(string displayName, string participantId, GooglePlayGames.BasicApi.Multiplayer.Participant.ParticipantStatus status, GooglePlayGames.BasicApi.Multiplayer.Player player, bool connectedToRoom);
                /*0xccd2f0*/ string get_DisplayName();
                /*0xccd2f8*/ string get_ParticipantId();
                /*0xccd300*/ GooglePlayGames.BasicApi.Multiplayer.Participant.ParticipantStatus get_Status();
                /*0xccd308*/ GooglePlayGames.BasicApi.Multiplayer.Player get_Player();
                /*0xccd310*/ bool get_IsConnectedToRoom();
                /*0xccd318*/ bool get_IsAutomatch();
                /*0xccd328*/ string ToString();
                /*0xccd530*/ int CompareTo(GooglePlayGames.BasicApi.Multiplayer.Participant other);
                /*0xccd554*/ bool Equals(object obj);
                /*0xccd680*/ int GetHashCode();

                enum ParticipantStatus
                {
                    NotInvitedYet = 0,
                    Invited = 1,
                    Joined = 2,
                    Declined = 3,
                    Left = 4,
                    Finished = 5,
                    Unresponsive = 6,
                    Unknown = 7,
                }
            }

            class Player : GooglePlayGames.PlayGamesUserProfile
            {
                /*0xcbe278*/ Player(string displayName, string playerId, string avatarUrl);
            }

            interface RealTimeMultiplayerListener
            {
                void OnRoomSetupProgress(float percent);
                void OnRoomConnected(bool success);
                void OnLeftRoom();
                void OnParticipantLeft(GooglePlayGames.BasicApi.Multiplayer.Participant participant);
                void OnPeersConnected(string[] participantIds);
                void OnPeersDisconnected(string[] participantIds);
                void OnRealTimeMessageReceived(bool isReliable, string senderId, byte[] data);
            }

            class TurnBasedMatch
            {
                /*0x10*/ string mMatchId;
                /*0x18*/ byte[] mData;
                /*0x20*/ bool mCanRematch;
                /*0x24*/ uint mAvailableAutomatchSlots;
                /*0x28*/ string mSelfParticipantId;
                /*0x30*/ System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> mParticipants;
                /*0x38*/ string mPendingParticipantId;
                /*0x40*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus mTurnStatus;
                /*0x44*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus mMatchStatus;
                /*0x48*/ uint mVariant;
                /*0x4c*/ uint mVersion;
                /*0x50*/ System.DateTime mCreationTime;
                /*0x58*/ System.DateTime mLastUpdateTime;

                /*0xccd698*/ TurnBasedMatch(string matchId, byte[] data, bool canRematch, string selfParticipantId, System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> participants, uint availableAutomatchSlots, string pendingParticipantId, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus turnStatus, GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus matchStatus, uint variant, uint version, System.DateTime creationTime, System.DateTime lastUpdateTime);
                /*0xccd768*/ System.DateTime get_CreationTime();
                /*0xccd770*/ System.DateTime get_LastUpdateTime();
                /*0xccd778*/ string get_MatchId();
                /*0xccd780*/ byte[] get_Data();
                /*0xccd788*/ bool get_CanRematch();
                /*0xccd790*/ string get_SelfParticipantId();
                /*0xccd798*/ GooglePlayGames.BasicApi.Multiplayer.Participant get_Self();
                /*0xcc4a00*/ GooglePlayGames.BasicApi.Multiplayer.Participant GetParticipant(string participantId);
                /*0xccd7a0*/ System.Collections.Generic.List<GooglePlayGames.BasicApi.Multiplayer.Participant> get_Participants();
                /*0xccd7a8*/ string get_PendingParticipantId();
                /*0xccd7b0*/ GooglePlayGames.BasicApi.Multiplayer.Participant get_PendingParticipant();
                /*0xccd7c4*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchTurnStatus get_TurnStatus();
                /*0xccd7cc*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.MatchStatus get_Status();
                /*0xccd7d4*/ uint get_Variant();
                /*0xccd7dc*/ uint get_Version();
                /*0xccd7e4*/ uint get_AvailableAutomatchSlots();
                /*0xccd7ec*/ string ToString();

                enum MatchStatus
                {
                    Active = 0,
                    AutoMatching = 1,
                    Cancelled = 2,
                    Complete = 3,
                    Expired = 4,
                    Unknown = 5,
                    Deleted = 6,
                }

                enum MatchTurnStatus
                {
                    Complete = 0,
                    Invited = 1,
                    MyTurn = 2,
                    TheirTurn = 3,
                    Unknown = 4,
                }

                class <>c
                {
                    static /*0x0*/ GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch.<> <>9;
                    static /*0x8*/ System.Func<GooglePlayGames.BasicApi.Multiplayer.Participant, string> <>9__47_0;

                    static /*0xccdca4*/ <>c();
                    /*0xccdd08*/ <>c();
                    /*0xccdd10*/ string <ToString>b__47_0(GooglePlayGames.BasicApi.Multiplayer.Participant p);
                }
            }
        }

        namespace Events
        {
            class Event : GooglePlayGames.BasicApi.Events.IEvent
            {
                /*0x10*/ string mId;
                /*0x18*/ string mName;
                /*0x20*/ string mDescription;
                /*0x28*/ string mImageUrl;
                /*0x30*/ ulong mCurrentCount;
                /*0x38*/ GooglePlayGames.BasicApi.Events.EventVisibility mVisibility;

                /*0xccdd30*/ Event(string id, string name, string description, string imageUrl, ulong currentCount, GooglePlayGames.BasicApi.Events.EventVisibility visibility);
                /*0xccdd88*/ string get_Id();
                /*0xccdd90*/ string get_Name();
                /*0xccdd98*/ string get_Description();
                /*0xccdda0*/ string get_ImageUrl();
                /*0xccdda8*/ ulong get_CurrentCount();
                /*0xccddb0*/ GooglePlayGames.BasicApi.Events.EventVisibility get_Visibility();
            }

            enum EventVisibility
            {
                Hidden = 1,
                Revealed = 2,
            }

            interface IEvent
            {
                string get_Id();
                string get_Name();
                string get_Description();
                string get_ImageUrl();
                ulong get_CurrentCount();
                GooglePlayGames.BasicApi.Events.EventVisibility get_Visibility();
            }

            interface IEventsClient
            {
                void FetchAllEvents(GooglePlayGames.BasicApi.DataSource source, System.Action<GooglePlayGames.BasicApi.ResponseStatus, System.Collections.Generic.List<GooglePlayGames.BasicApi.Events.IEvent>> callback);
                void FetchEvent(GooglePlayGames.BasicApi.DataSource source, string eventId, System.Action<GooglePlayGames.BasicApi.ResponseStatus, GooglePlayGames.BasicApi.Events.IEvent> callback);
                void IncrementEvent(string eventId, uint stepsToIncrement);
            }
        }
    }
}

namespace Meta
{
    namespace Numerics
    {
        class NonconvergenceException : System.Exception
        {
            /*0xccddb8*/ NonconvergenceException();
            /*0xccde10*/ NonconvergenceException(string message);
            /*0xccde78*/ NonconvergenceException(string message, System.Exception innerException);
            /*0xccdee8*/ NonconvergenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class DimensionMismatchException : System.Exception
        {
            /*0xccdf68*/ DimensionMismatchException();
            /*0xccdfc0*/ DimensionMismatchException(string message);
            /*0xcce028*/ DimensionMismatchException(string message, System.Exception innerException);
            /*0xcce098*/ DimensionMismatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context);
        }

        class Global
        {
            static int SeriesMax = 250;
            static double TwoPI = 6.283185307179586;
            static double HalfPI = 1.5707963267948966;
            static /*0x0*/ double SqrtMax;
            static /*0x8*/ double Accuracy;
            static /*0x10*/ double SqrtTwo;
            static /*0x18*/ double SqrtThree;
            static /*0x20*/ double SqrtPI;
            static /*0x28*/ double SqrtTwoPI;
            static /*0x30*/ double LogTwo;

            static /*0xcce118*/ Global();
            static void Swap<T>(ref T a, ref T b);
        }

        namespace Functions
        {
            class AdvancedMath
            {
                static double EI = 0.36787944117144233;

                static /*0xcce1ec*/ double LambertW(double x);
                static /*0xcce4ac*/ double Lambert_Halley(double x, double w0);
                static /*0xcce3dc*/ double Lambert_SeriesZero(double x);
                static /*0xcce31c*/ double Lambert_SeriesSmall(double x);
                static /*0xcce418*/ double Lambert_SeriesLarge(double x);
            }
        }
    }
}

namespace GarlicText
{
    namespace UI
    {
        class HyperText : TMPro.TextMeshProUGUI
        {
            /*0x798*/ UnityEngine.UI.FontData m_FontData;
            /*0x7a0*/ string m_Text;
            /*0x7a8*/ UnityEngine.Color m_ColorOriginal;
            /*0x7b8*/ bool m_ShouldOverrideStylesFontColor;
            /*0x7c0*/ GarlicText.UI.HyperTextOutline _outlineCache;

            /*0xccef68*/ HyperText();
            /*0xcce5a8*/ GarlicText.UI.HyperTextOutline get_outline();
            /*0xcce63c*/ bool get_IsCookie();
            /*0xcce69c*/ void Start();
            /*0xcce9cc*/ void OnEnable();
            /*0xccebec*/ void OnDisable();
            /*0xcceaf8*/ void OnFontShouldChange(stringFormat.lang_type changedLanguage);
            /*0xcce6b8*/ void RefreshOutline();
            /*0xcced04*/ TMPro.TMP_FontAsset DetectTargetFontAsset(stringFormat.lang_type changedLanguage);
            /*0xccedcc*/ UnityEngine.Material DetectTargetFontMaterial(stringFormat.lang_type changedLanguage);
        }

        class HyperTextOutline : UnityEngine.MonoBehaviour
        {
            /*0x18*/ UnityEngine.Color32 color;
            /*0x1c*/ float thickness;
            /*0x20*/ float dilate;

            /*0xccefc0*/ HyperTextOutline();
        }
    }
}

namespace CodeStage
{
    namespace AntiCheat
    {
        namespace Utils
        {
            class xxHash
            {
                static uint PRIME32_1 = 2654435761;
                static uint PRIME32_2 = 2246822519;
                static uint PRIME32_3 = 3266489917;
                static uint PRIME32_4 = 668265263;
                static uint PRIME32_5 = 374761393;

                static /*0xccefd4*/ uint CalculateHash(byte[] buf, int len, uint seed);
                /*0xccf384*/ xxHash();
            }
        }

        namespace ObscuredTypes
        {
            struct ObscuredBool : System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredBool>
            {
                static /*0x0*/ byte cryptoKey;
                /*0x10*/ byte currentCryptoKey;
                /*0x14*/ int hiddenValue;
                /*0x18*/ bool fakeValue;
                /*0x19*/ bool fakeValueChanged;
                /*0x1a*/ bool inited;

                static /*0xccfad8*/ ObscuredBool();
                static /*0xccf408*/ void SetNewCryptoKey(byte newKey);
                static /*0xccf464*/ int Encrypt(bool value);
                static /*0xccf4bc*/ int Encrypt(bool value, byte key);
                static /*0xccf53c*/ bool Decrypt(int value);
                static /*0xccf594*/ bool Decrypt(int value, byte key);
                static /*0xccf8b0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool op_Implicit(bool value);
                static /*0xccf948*/ bool op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool value);
                /*0xccf38c*/ ObscuredBool(int value);
                /*0xccf60c*/ void ApplyNewCryptoKey();
                /*0xccf7c8*/ void RandomizeCryptoKey();
                /*0xccf854*/ int GetEncrypted();
                /*0xccf86c*/ void SetEncrypted(int encrypted);
                /*0xccf6bc*/ bool InternalDecrypt();
                /*0xccf970*/ bool Equals(object obj);
                /*0xccf9ec*/ bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredBool obj);
                /*0xccfa90*/ int GetHashCode();
                /*0xccfab4*/ string ToString();
            }

            struct ObscuredByte : System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredByte>, System.IFormattable
            {
                static /*0x0*/ byte cryptoKey;
                /*0x10*/ byte currentCryptoKey;
                /*0x11*/ byte hiddenValue;
                /*0x12*/ byte fakeValue;
                /*0x13*/ bool inited;

                static /*0xcd02f4*/ ObscuredByte();
                static /*0xccfb9c*/ void SetNewCryptoKey(byte newKey);
                static /*0xccfbf8*/ byte EncryptDecrypt(byte value);
                static /*0xccfc50*/ byte EncryptDecrypt(byte value, byte key);
                static /*0xccff58*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredByte op_Implicit(byte value);
                static /*0xccffdc*/ byte op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte value);
                static /*0xccfff4*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredByte op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte input);
                static /*0xcd007c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredByte op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte input);
                /*0xccfb24*/ ObscuredByte(byte value);
                /*0xccfcbc*/ void ApplyNewCryptoKey();
                /*0xccfe80*/ void RandomizeCryptoKey();
                /*0xccff0c*/ byte GetEncrypted();
                /*0xccff24*/ void SetEncrypted(byte encrypted);
                /*0xccfd6c*/ byte InternalDecrypt();
                /*0xcd0104*/ bool Equals(object obj);
                /*0xcd017c*/ bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredByte obj);
                /*0xcd021c*/ string ToString();
                /*0xcd023c*/ string ToString(string format);
                /*0xcd026c*/ int GetHashCode();
                /*0xcd028c*/ string ToString(System.IFormatProvider provider);
                /*0xcd02bc*/ string ToString(string format, System.IFormatProvider provider);
            }

            struct ObscuredChar : System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredChar>
            {
                static /*0x0*/ char cryptoKey;
                /*0x10*/ char currentCryptoKey;
                /*0x12*/ char hiddenValue;
                /*0x14*/ char fakeValue;
                /*0x16*/ bool inited;

                static /*0xcd0aac*/ ObscuredChar();
                static /*0xcd03bc*/ void SetNewCryptoKey(char newKey);
                static /*0xcd0418*/ char EncryptDecrypt(char value);
                static /*0xcd0470*/ char EncryptDecrypt(char value, char key);
                static /*0xcd077c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredChar op_Implicit(char value);
                static /*0xcd0800*/ char op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar value);
                static /*0xcd0818*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredChar op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar input);
                static /*0xcd08a0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredChar op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar input);
                /*0xcd0340*/ ObscuredChar(char value);
                /*0xcd04dc*/ void ApplyNewCryptoKey();
                /*0xcd06a4*/ void RandomizeCryptoKey();
                /*0xcd0730*/ char GetEncrypted();
                /*0xcd0748*/ void SetEncrypted(char encrypted);
                /*0xcd058c*/ char InternalDecrypt();
                /*0xcd0928*/ bool Equals(object obj);
                /*0xcd09a0*/ bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredChar obj);
                /*0xcd0a3c*/ string ToString();
                /*0xcd0a5c*/ string ToString(System.IFormatProvider provider);
                /*0xcd0a8c*/ int GetHashCode();
            }

            struct ObscuredDecimal : System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal>, System.IFormattable
            {
                static /*0x0*/ long cryptoKey;
                /*0x10*/ long currentCryptoKey;
                /*0x18*/ byte[] hiddenValue;
                /*0x20*/ decimal fakeValue;
                /*0x30*/ bool inited;

                static /*0xcd1c00*/ ObscuredDecimal();
                static /*0xcd0b70*/ void SetNewCryptoKey(long newKey);
                static /*0xcd0bcc*/ decimal Encrypt(decimal value);
                static /*0xcd0c3c*/ decimal Encrypt(decimal value, long key);
                static /*0xcd0c48*/ byte[] InternalEncrypt(decimal value);
                static /*0xcd0cb0*/ byte[] InternalEncrypt(decimal value, long key);
                static /*0xcd0e4c*/ decimal Decrypt(decimal value);
                static /*0xcd0ebc*/ decimal Decrypt(decimal value, long key);
                static /*0xcd14dc*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Implicit(decimal value);
                static /*0xcd15b0*/ decimal op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal value);
                static /*0xcd15b4*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Explicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat f);
                static /*0xcd16ec*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal input);
                static /*0xcd17e0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal input);
                /*0xcd0af8*/ ObscuredDecimal(byte[] value);
                /*0xcd0ec8*/ void ApplyNewCryptoKey();
                /*0xcd11e0*/ void RandomizeCryptoKey();
                /*0xcd1274*/ decimal GetEncrypted();
                /*0xcd1358*/ void SetEncrypted(decimal encrypted);
                /*0xcd0f84*/ decimal InternalDecrypt();
                /*0xcd18d4*/ string ToString();
                /*0xcd197c*/ string ToString(string format);
                /*0xcd19d4*/ string ToString(System.IFormatProvider provider);
                /*0xcd1a2c*/ string ToString(string format, System.IFormatProvider provider);
                /*0xcd1a8c*/ bool Equals(object obj);
                /*0xcd1b44*/ bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal obj);
                /*0xcd1bb8*/ int GetHashCode();

                struct DecimalLongBytesUnion
                {
                    /*0x10*/ decimal d;
                    /*0x10*/ long l1;
                    /*0x18*/ long l2;
                    /*0x10*/ byte b1;
                    /*0x11*/ byte b2;
                    /*0x12*/ byte b3;
                    /*0x13*/ byte b4;
                    /*0x14*/ byte b5;
                    /*0x15*/ byte b6;
                    /*0x16*/ byte b7;
                    /*0x17*/ byte b8;
                    /*0x18*/ byte b9;
                    /*0x19*/ byte b10;
                    /*0x1a*/ byte b11;
                    /*0x1b*/ byte b12;
                    /*0x1c*/ byte b13;
                    /*0x1d*/ byte b14;
                    /*0x1e*/ byte b15;
                    /*0x1f*/ byte b16;
                }
            }

            struct ObscuredDouble : System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble>, System.IFormattable
            {
                static /*0x0*/ long cryptoKey;
                /*0x10*/ long currentCryptoKey;
                /*0x18*/ byte[] hiddenValue;
                /*0x20*/ double fakeValue;
                /*0x28*/ bool inited;

                static /*0xcd2850*/ ObscuredDouble();
                static /*0xcd1cc8*/ void SetNewCryptoKey(long newKey);
                static /*0xcd1d24*/ long Encrypt(double value);
                static /*0xcd1d90*/ long Encrypt(double value, long key);
                static /*0xcd1d9c*/ byte[] InternalEncrypt(double value);
                static /*0xcd1dfc*/ byte[] InternalEncrypt(double value, long key);
                static /*0xcd1f18*/ double Decrypt(long value);
                static /*0xcd1f7c*/ double Decrypt(long value, long key);
                static /*0xcd2428*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Implicit(double value);
                static /*0xcd24c0*/ double op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble value);
                static /*0xcd24c4*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble input);
                static /*0xcd2564*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble input);
                /*0xcd1c50*/ ObscuredDouble(byte[] value);
                /*0xcd1f88*/ void ApplyNewCryptoKey();
                /*0xcd21f8*/ void RandomizeCryptoKey();
                /*0xcd2284*/ long GetEncrypted();
                /*0xcd2324*/ void SetEncrypted(long encrypted);
                /*0xcd203c*/ double InternalDecrypt();
                /*0xcd2604*/ string ToString();
                /*0xcd2680*/ string ToString(string format);
                /*0xcd26b0*/ string ToString(System.IFormatProvider provider);
                /*0xcd26e0*/ string ToString(string format, System.IFormatProvider provider);
                /*0xcd2718*/ bool Equals(object obj);
                /*0xcd27a0*/ bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble obj);
                /*0xcd27dc*/ int GetHashCode();

                struct DoubleLongBytesUnion
                {
                    /*0x10*/ double d;
                    /*0x10*/ long l;
                    /*0x10*/ byte b1;
                    /*0x11*/ byte b2;
                    /*0x12*/ byte b3;
                    /*0x13*/ byte b4;
                    /*0x14*/ byte b5;
                    /*0x15*/ byte b6;
                    /*0x16*/ byte b7;
                    /*0x17*/ byte b8;
                }
            }

            struct ObscuredFloat : System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat>, System.IFormattable
            {
                static /*0x0*/ int cryptoKey;
                /*0x10*/ int currentCryptoKey;
                /*0x18*/ byte[] hiddenValue;
                /*0x20*/ float fakeValue;
                /*0x24*/ bool inited;

                static /*0xcd3374*/ ObscuredFloat();
                static /*0xcd291c*/ void SetNewCryptoKey(int newKey);
                static /*0xcd2978*/ int Encrypt(float value);
                static /*0xcd29e4*/ int Encrypt(float value, int key);
                static /*0xcd29f0*/ byte[] InternalEncrypt(float value);
                static /*0xcd2a50*/ byte[] InternalEncrypt(float value, int key);
                static /*0xcd2b2c*/ float Decrypt(int value);
                static /*0xcd2b90*/ float Decrypt(int value, int key);
                static /*0xcd2f7c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Implicit(float value);
                static /*0xcd16e8*/ float op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat value);
                static /*0xcd301c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat input);
                static /*0xcd30c4*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat input);
                /*0xcd28a0*/ ObscuredFloat(byte[] value);
                /*0xcd2b9c*/ void ApplyNewCryptoKey();
                /*0xcd2dcc*/ void RandomizeCryptoKey();
                /*0xcd2e58*/ int GetEncrypted();
                /*0xcd2eb8*/ void SetEncrypted(int encrypted);
                /*0xcd2c50*/ float InternalDecrypt();
                /*0xcd316c*/ bool Equals(object obj);
                /*0xcd31fc*/ bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat obj);
                /*0xcd3240*/ int GetHashCode();
                /*0xcd3260*/ string ToString();
                /*0xcd32dc*/ string ToString(string format);
                /*0xcd330c*/ string ToString(System.IFormatProvider provider);
                /*0xcd333c*/ string ToString(string format, System.IFormatProvider provider);

                struct FloatIntBytesUnion
                {
                    /*0x10*/ float f;
                    /*0x10*/ int i;
                    /*0x10*/ byte b1;
                    /*0x11*/ byte b2;
                    /*0x12*/ byte b3;
                    /*0x13*/ byte b4;
                }
            }

            struct ObscuredInt : System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>, System.IFormattable
            {
                static /*0x0*/ int cryptoKey;
                /*0x10*/ int currentCryptoKey;
                /*0x14*/ int hiddenValue;
                /*0x18*/ int fakeValue;
                /*0x1c*/ bool inited;

                static /*0xcd3dd4*/ ObscuredInt();
                static /*0xcd343c*/ void SetNewCryptoKey(int newKey);
                static /*0xcd3498*/ int Encrypt(int value);
                static /*0xcd34f0*/ int Encrypt(int value, int key);
                static /*0xcd3558*/ int Decrypt(int value);
                static /*0xcd35b0*/ int Decrypt(int value, int key);
                static /*0xcd38b0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Implicit(int value);
                static /*0xcd3934*/ int op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
                static /*0xcd3954*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
                static /*0xcd39dc*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
                static /*0xcd3a5c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Explicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt value);
                static /*0xcd3acc*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt input);
                static /*0xcd3b5c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt input);
                /*0xcd33c4*/ ObscuredInt(int value);
                /*0xcd3618*/ void ApplyNewCryptoKey();
                /*0xcd37dc*/ void RandomizeCryptoKey();
                /*0xcd3864*/ int GetEncrypted();
                /*0xcd387c*/ void SetEncrypted(int encrypted);
                /*0xcd36c8*/ int InternalDecrypt();
                /*0xcd3bec*/ bool Equals(object obj);
                /*0xcd3c64*/ bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredInt obj);
                /*0xcd3cfc*/ int GetHashCode();
                /*0xcd3d1c*/ string ToString();
                /*0xcd3d3c*/ string ToString(string format);
                /*0xcd3d6c*/ string ToString(System.IFormatProvider provider);
                /*0xcd3d9c*/ string ToString(string format, System.IFormatProvider provider);
            }

            struct ObscuredLong : System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredLong>, System.IFormattable
            {
                static /*0x0*/ long cryptoKey;
                /*0x10*/ long currentCryptoKey;
                /*0x18*/ long hiddenValue;
                /*0x20*/ long fakeValue;
                /*0x28*/ bool inited;

                static /*0xcd46d4*/ ObscuredLong();
                static /*0xcd3e9c*/ void SetNewCryptoKey(long newKey);
                static /*0xcd3ef8*/ long Encrypt(long value);
                static /*0xcd3fb8*/ long Decrypt(long value);
                static /*0xcd3f50*/ long Encrypt(long value, long key);
                static /*0xcd4010*/ long Decrypt(long value, long key);
                static /*0xcd4314*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredLong op_Implicit(long value);
                static /*0xcd43ac*/ long op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredLong value);
                static /*0xcd43b0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredLong op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredLong input);
                static /*0xcd4448*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredLong op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredLong input);
                /*0xcd3e24*/ ObscuredLong(long value);
                /*0xcd4078*/ void ApplyNewCryptoKey();
                /*0xcd423c*/ void RandomizeCryptoKey();
                /*0xcd42c8*/ long GetEncrypted();
                /*0xcd42e0*/ void SetEncrypted(long encrypted);
                /*0xcd4128*/ long InternalDecrypt();
                /*0xcd44e0*/ bool Equals(object obj);
                /*0xcd4568*/ bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredLong obj);
                /*0xcd45fc*/ int GetHashCode();
                /*0xcd461c*/ string ToString();
                /*0xcd463c*/ string ToString(string format);
                /*0xcd466c*/ string ToString(System.IFormatProvider provider);
                /*0xcd469c*/ string ToString(string format, System.IFormatProvider provider);
            }

            class ObscuredPrefs
            {
                static byte VERSION = 2;
                static string RAW_NOT_FOUND = "{not_found}";
                static string DATA_SEPARATOR = "|";
                static char DEPRECATED_RAW_SEPARATOR = 58;
                static /*0x0*/ bool foreignSavesReported;
                static /*0x8*/ string cryptoKey;
                static /*0x10*/ string deviceId;
                static /*0x18*/ uint deviceIdHash;
                static /*0x20*/ System.Action onAlterationDetected;
                static /*0x28*/ bool preservePlayerPrefs;
                static /*0x30*/ System.Action onPossibleForeignSavesDetected;
                static /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DeviceLockLevel lockToDevice;
                static /*0x39*/ bool readForeignSaves;
                static /*0x3a*/ bool emergencyMode;
                static /*0x40*/ string deprecatedDeviceId;

                static /*0xcd9824*/ ObscuredPrefs();
                static /*0xcd4724*/ void set_CryptoKey(string value);
                static /*0xcd4780*/ string get_CryptoKey();
                static /*0xcd47d8*/ string get_DeviceId();
                static /*0xcd4900*/ void set_DeviceId(string value);
                static /*0xcd495c*/ string get_DeviceID();
                static /*0xcd49a8*/ void set_DeviceID(string value);
                static /*0xcd4a34*/ uint get_DeviceIdHash();
                static /*0xcd4b78*/ void ForceLockToDeviceInit();
                static /*0xcd4c58*/ void SetNewCryptoKey(string newKey);
                static /*0xcd4ce4*/ void SetInt(string key, int value);
                static /*0xcd4ef4*/ int GetInt(string key);
                static /*0xcd4f4c*/ int GetInt(string key, int defaultValue);
                static /*0xcd4e54*/ string EncryptIntValue(string key, int value);
                static /*0xcd51a0*/ int DecryptIntValue(string key, string encryptedInput, int defaultValue);
                static /*0xcd5d34*/ void SetUInt(string key, uint value);
                static /*0xcd5e54*/ uint GetUInt(string key);
                static /*0xcd5eac*/ uint GetUInt(string key, uint defaultValue);
                static /*0xcd5db4*/ string EncryptUIntValue(string key, uint value);
                static /*0xcd5f74*/ uint DecryptUIntValue(string key, string encryptedInput, uint defaultValue);
                static /*0xcd60c0*/ void SetString(string key, string value);
                static /*0xcd61cc*/ string GetString(string key);
                static /*0xcd6238*/ string GetString(string key, string defaultValue);
                static /*0xcd6140*/ string EncryptStringValue(string key, string value);
                static /*0xcd6394*/ string DecryptStringValue(string key, string encryptedInput, string defaultValue);
                static /*0xcd64bc*/ void SetFloat(string key, float value);
                static /*0xcd65dc*/ float GetFloat(string key);
                static /*0xcd6634*/ float GetFloat(string key, float defaultValue);
                static /*0xcd653c*/ string EncryptFloatValue(string key, float value);
                static /*0xcd6794*/ float DecryptFloatValue(string key, string encryptedInput, float defaultValue);
                static /*0xcd691c*/ void SetDouble(string key, double value);
                static /*0xcd6a3c*/ double GetDouble(string key);
                static /*0xcd6a94*/ double GetDouble(string key, double defaultValue);
                static /*0xcd699c*/ string EncryptDoubleValue(string key, double value);
                static /*0xcd6b5c*/ double DecryptDoubleValue(string key, string encryptedInput, double defaultValue);
                static /*0xcd6ce4*/ void SetLong(string key, long value);
                static /*0xcd6e04*/ long GetLong(string key);
                static /*0xcd6e5c*/ long GetLong(string key, long defaultValue);
                static /*0xcd6d64*/ string EncryptLongValue(string key, long value);
                static /*0xcd6f24*/ long DecryptLongValue(string key, string encryptedInput, long defaultValue);
                static /*0xcd7070*/ void SetBool(string key, bool value);
                static /*0xcd7190*/ bool GetBool(string key);
                static /*0xcd71e8*/ bool GetBool(string key, bool defaultValue);
                static /*0xcd70f0*/ string EncryptBoolValue(string key, bool value);
                static /*0xcd72b0*/ bool DecryptBoolValue(string key, string encryptedInput, bool defaultValue);
                static /*0xcd7408*/ void SetByteArray(string key, byte[] value);
                static /*0xcd74f0*/ byte[] GetByteArray(string key);
                static /*0xcd754c*/ byte[] GetByteArray(string key, byte defaultValue, int defaultLength);
                static /*0xcd7488*/ string EncryptByteArrayValue(string key, byte[] value);
                static /*0xcd76c0*/ byte[] DecryptByteArrayValue(string key, string encryptedInput, byte defaultValue, int defaultLength);
                static /*0xcd762c*/ byte[] ConstructByteArray(byte value, int length);
                static /*0xcd7810*/ void SetVector2(string key, UnityEngine.Vector2 value);
                static /*0xcd79a0*/ UnityEngine.Vector2 GetVector2(string key);
                static /*0xcd7a38*/ UnityEngine.Vector2 GetVector2(string key, UnityEngine.Vector2 defaultValue);
                static /*0xcd7898*/ string EncryptVector2Value(string key, UnityEngine.Vector2 value);
                static /*0xcd7b08*/ UnityEngine.Vector2 DecryptVector2Value(string key, string encryptedInput, UnityEngine.Vector2 defaultValue);
                static /*0xcd7ce0*/ void SetVector3(string key, UnityEngine.Vector3 value);
                static /*0xcd7eb0*/ UnityEngine.Vector3 GetVector3(string key);
                static /*0xcd7f58*/ UnityEngine.Vector3 GetVector3(string key, UnityEngine.Vector3 defaultValue);
                static /*0xcd7d78*/ string EncryptVector3Value(string key, UnityEngine.Vector3 value);
                static /*0xcd8040*/ UnityEngine.Vector3 DecryptVector3Value(string key, string encryptedInput, UnityEngine.Vector3 defaultValue);
                static /*0xcd826c*/ void SetQuaternion(string key, UnityEngine.Quaternion value);
                static /*0xcd846c*/ UnityEngine.Quaternion GetQuaternion(string key);
                static /*0xcd8518*/ UnityEngine.Quaternion GetQuaternion(string key, UnityEngine.Quaternion defaultValue);
                static /*0xcd830c*/ string EncryptQuaternionValue(string key, UnityEngine.Quaternion value);
                static /*0xcd8610*/ UnityEngine.Quaternion DecryptQuaternionValue(string key, string encryptedInput, UnityEngine.Quaternion defaultValue);
                static /*0xcd8878*/ void SetColor(string key, UnityEngine.Color32 value);
                static /*0xcd89a4*/ UnityEngine.Color32 GetColor(string key);
                static /*0xcd8a04*/ UnityEngine.Color32 GetColor(string key, UnityEngine.Color32 defaultValue);
                static /*0xcd8904*/ string EncryptColorValue(string key, uint value);
                static /*0xcd8ae0*/ void SetRect(string key, UnityEngine.Rect value);
                static /*0xcd8d00*/ UnityEngine.Rect GetRect(string key);
                static /*0xcd8d88*/ UnityEngine.Rect GetRect(string key, UnityEngine.Rect defaultValue);
                static /*0xcd8b80*/ string EncryptRectValue(string key, UnityEngine.Rect value);
                static /*0xcd8e80*/ UnityEngine.Rect DecryptRectValue(string key, string encryptedInput, UnityEngine.Rect defaultValue);
                static /*0xcd9138*/ void SetRawValue(string key, string encryptedValue);
                static /*0xcd91a4*/ string GetRawValue(string key);
                static /*0xcd9200*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DataType GetRawValueType(string value);
                static /*0xcd4d64*/ string EncryptKey(string key);
                static /*0xcd92fc*/ bool HasKey(string key);
                static /*0xcd9378*/ void DeleteKey(string key);
                static /*0xcd93fc*/ void DeleteAll();
                static /*0xcd9404*/ void Save();
                static /*0xcd50a8*/ string GetEncryptedPrefsString(string key, string encryptedKey);
                static /*0xcd52ec*/ string EncryptData(string key, byte[] cleanBytes, CodeStage.AntiCheat.ObscuredTypes.ObscuredPrefs.DataType type);
                static /*0xcd5944*/ byte[] DecryptData(string key, string encryptedInput);
                static /*0xcd4ad4*/ uint CalculateChecksum(string input);
                static /*0xcd94f4*/ void SavesTampered();
                static /*0xcd958c*/ void PossibleForeignSavesDetected();
                static /*0xcd487c*/ string GetDeviceId();
                static /*0xcd940c*/ byte[] EncryptDecryptBytes(byte[] bytes, int dataLength, string key);
                static /*0xcd559c*/ string DeprecatedDecryptValue(string value);
                static /*0xcd96ec*/ string DeprecatedCalculateChecksum(string input);
                static /*0xcd9644*/ string get_DeprecatedDeviceId();

                enum DataType
                {
                    Unknown = 0,
                    Int = 5,
                    UInt = 10,
                    String = 15,
                    Float = 20,
                    Double = 25,
                    Long = 30,
                    Bool = 35,
                    ByteArray = 40,
                    Vector2 = 45,
                    Vector3 = 50,
                    Quaternion = 55,
                    Color = 60,
                    Rect = 65,
                }

                enum DeviceLockLevel
                {
                    None = 0,
                    Soft = 1,
                    Strict = 2,
                }
            }

            struct ObscuredQuaternion
            {
                static /*0x0*/ int cryptoKey;
                static /*0x4*/ UnityEngine.Quaternion initialFakeValue;
                /*0x10*/ int currentCryptoKey;
                /*0x14*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion hiddenValue;
                /*0x24*/ UnityEngine.Quaternion fakeValue;
                /*0x34*/ bool inited;

                static /*0xd92fec*/ ObscuredQuaternion();
                static /*0xd92540*/ void SetNewCryptoKey(int newKey);
                static /*0xd9259c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion Encrypt(UnityEngine.Quaternion value);
                static /*0xd9261c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion Encrypt(UnityEngine.Quaternion value, int key);
                static /*0xd92728*/ UnityEngine.Quaternion Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion value);
                static /*0xd92790*/ UnityEngine.Quaternion Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion value, int key);
                static /*0xd92e30*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion op_Implicit(UnityEngine.Quaternion value);
                static /*0xd92f00*/ UnityEngine.Quaternion op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion value);
                /*0xd924b0*/ ObscuredQuaternion(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion value);
                /*0xd92898*/ void ApplyNewCryptoKey();
                /*0xd92b9c*/ void RandomizeCryptoKey();
                /*0xd92c4c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion GetEncrypted();
                /*0xd92c68*/ void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredQuaternion.RawEncryptedQuaternion encrypted);
                /*0xd92970*/ UnityEngine.Quaternion InternalDecrypt();
                /*0xd92cf8*/ bool CompareQuaternionsWithTolerance(UnityEngine.Quaternion q1, UnityEngine.Quaternion q2);
                /*0xd92f04*/ int GetHashCode();
                /*0xd92f8c*/ string ToString();
                /*0xd92fb8*/ string ToString(string format);

                struct RawEncryptedQuaternion
                {
                    /*0x10*/ int x;
                    /*0x14*/ int y;
                    /*0x18*/ int z;
                    /*0x1c*/ int w;
                }
            }

            struct ObscuredSByte : System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte>, System.IFormattable
            {
                static /*0x0*/ sbyte cryptoKey;
                /*0x10*/ sbyte currentCryptoKey;
                /*0x11*/ sbyte hiddenValue;
                /*0x12*/ sbyte fakeValue;
                /*0x13*/ bool inited;

                static /*0xd93838*/ ObscuredSByte();
                static /*0xd930f4*/ void SetNewCryptoKey(sbyte newKey);
                static /*0xd93150*/ sbyte EncryptDecrypt(sbyte value);
                static /*0xd931a8*/ sbyte EncryptDecrypt(sbyte value, sbyte key);
                static /*0xd934a8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte op_Implicit(sbyte value);
                static /*0xd93528*/ sbyte op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte value);
                static /*0xd93540*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte input);
                static /*0xd935c4*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte input);
                /*0xd9307c*/ ObscuredSByte(sbyte value);
                /*0xd93214*/ void ApplyNewCryptoKey();
                /*0xd933d4*/ void RandomizeCryptoKey();
                /*0xd93460*/ sbyte GetEncrypted();
                /*0xd93478*/ void SetEncrypted(sbyte encrypted);
                /*0xd932c4*/ sbyte InternalDecrypt();
                /*0xd93648*/ bool Equals(object obj);
                /*0xd936c0*/ bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte obj);
                /*0xd93760*/ string ToString();
                /*0xd93780*/ string ToString(string format);
                /*0xd937b0*/ int GetHashCode();
                /*0xd937d0*/ string ToString(System.IFormatProvider provider);
                /*0xd93800*/ string ToString(string format, System.IFormatProvider provider);
            }

            struct ObscuredShort : System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredShort>, System.IFormattable
            {
                static /*0x0*/ short cryptoKey;
                /*0x10*/ short currentCryptoKey;
                /*0x12*/ short hiddenValue;
                /*0x14*/ short fakeValue;
                /*0x16*/ bool inited;

                static /*0xd94034*/ ObscuredShort();
                static /*0xd93900*/ void SetNewCryptoKey(short newKey);
                static /*0xd9395c*/ short EncryptDecrypt(short value);
                static /*0xd939b4*/ short EncryptDecrypt(short value, short key);
                static /*0xd93cb8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredShort op_Implicit(short value);
                static /*0xd93d38*/ short op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort value);
                static /*0xd93d50*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredShort op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort input);
                static /*0xd93dcc*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredShort op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort input);
                /*0xd93884*/ ObscuredShort(short value);
                /*0xd93a20*/ void ApplyNewCryptoKey();
                /*0xd93be4*/ void RandomizeCryptoKey();
                /*0xd93c70*/ short GetEncrypted();
                /*0xd93c88*/ void SetEncrypted(short encrypted);
                /*0xd93ad0*/ short InternalDecrypt();
                /*0xd93e48*/ bool Equals(object obj);
                /*0xd93ec0*/ bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredShort obj);
                /*0xd93f5c*/ string ToString();
                /*0xd93f7c*/ string ToString(string format);
                /*0xd93fac*/ int GetHashCode();
                /*0xd93fcc*/ string ToString(System.IFormatProvider provider);
                /*0xd93ffc*/ string ToString(string format, System.IFormatProvider provider);
            }

            class ObscuredString
            {
                static /*0x0*/ string cryptoKey;
                /*0x10*/ string currentCryptoKey;
                /*0x18*/ byte[] hiddenValue;
                /*0x20*/ string fakeValue;
                /*0x28*/ bool inited;

                static /*0xd94dd0*/ ObscuredString();
                static /*0xd9410c*/ void SetNewCryptoKey(string newKey);
                static /*0xd94168*/ string EncryptDecrypt(string value);
                static /*0xd941d4*/ string EncryptDecrypt(string value, string key);
                static /*0xd94554*/ byte[] InternalEncrypt(string value);
                static /*0xd94650*/ byte[] InternalEncrypt(string value, string key);
                static /*0xd948b0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredString op_Implicit(string value);
                static /*0xd94948*/ string op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value);
                static /*0xd949d0*/ bool op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredString a, CodeStage.AntiCheat.ObscuredTypes.ObscuredString b);
                static /*0xd94b1c*/ bool op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredString a, CodeStage.AntiCheat.ObscuredTypes.ObscuredString b);
                static /*0xd94828*/ byte[] GetBytes(string str);
                static /*0xd94718*/ string GetString(byte[] bytes);
                static /*0xd94a9c*/ bool ArraysEquals(byte[] a1, byte[] a2);
                /*0xd94080*/ ObscuredString();
                /*0xd94088*/ ObscuredString(byte[] value);
                /*0xd94340*/ void ApplyNewCryptoKey();
                /*0xd945b4*/ void RandomizeCryptoKey();
                /*0xd946b8*/ string GetEncrypted();
                /*0xd947a4*/ void SetEncrypted(string encrypted);
                /*0xd943ec*/ string InternalDecrypt();
                /*0xd94a98*/ string ToString();
                /*0xd94b8c*/ bool Equals(object obj);
                /*0xd94bfc*/ bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value);
                /*0xd94cf4*/ bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredString value, System.StringComparison comparisonType);
                /*0xd94db0*/ int GetHashCode();
            }

            struct ObscuredUInt : System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt>, System.IFormattable
            {
                static /*0x0*/ uint cryptoKey;
                /*0x10*/ uint currentCryptoKey;
                /*0x14*/ uint hiddenValue;
                /*0x18*/ uint fakeValue;
                /*0x1c*/ bool inited;

                static /*0xd95728*/ ObscuredUInt();
                static /*0xd94ea8*/ void SetNewCryptoKey(uint newKey);
                static /*0xd94f04*/ uint Encrypt(uint value);
                static /*0xd94fc4*/ uint Decrypt(uint value);
                static /*0xd94f5c*/ uint Encrypt(uint value, uint key);
                static /*0xd9501c*/ uint Decrypt(uint value, uint key);
                static /*0xd95318*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Implicit(uint value);
                static /*0xd95398*/ uint op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt value);
                static /*0xd953b8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt op_Explicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt value);
                static /*0xd95428*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt input);
                static /*0xd954b4*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt input);
                /*0xd94e30*/ ObscuredUInt(uint value);
                /*0xd95084*/ void ApplyNewCryptoKey();
                /*0xd95244*/ void RandomizeCryptoKey();
                /*0xd952d0*/ uint GetEncrypted();
                /*0xd952e8*/ void SetEncrypted(uint encrypted);
                /*0xd95134*/ uint InternalDecrypt();
                /*0xd95540*/ bool Equals(object obj);
                /*0xd955b8*/ bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt obj);
                /*0xd95650*/ string ToString();
                /*0xd95670*/ string ToString(string format);
                /*0xd956a0*/ int GetHashCode();
                /*0xd956c0*/ string ToString(System.IFormatProvider provider);
                /*0xd956f0*/ string ToString(string format, System.IFormatProvider provider);
            }

            struct ObscuredULong : System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredULong>, System.IFormattable
            {
                static /*0x0*/ ulong cryptoKey;
                /*0x10*/ ulong currentCryptoKey;
                /*0x18*/ ulong hiddenValue;
                /*0x20*/ ulong fakeValue;
                /*0x28*/ bool inited;

                static /*0xd96014*/ ObscuredULong();
                static /*0xd957f0*/ void SetNewCryptoKey(ulong newKey);
                static /*0xd9584c*/ ulong Encrypt(ulong value);
                static /*0xd9590c*/ ulong Decrypt(ulong value);
                static /*0xd958a4*/ ulong Encrypt(ulong value, ulong key);
                static /*0xd95964*/ ulong Decrypt(ulong value, ulong key);
                static /*0xd95c60*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredULong op_Implicit(ulong value);
                static /*0xd95cf4*/ ulong op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredULong value);
                static /*0xd95cf8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredULong op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredULong input);
                static /*0xd95d8c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredULong op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredULong input);
                /*0xd95778*/ ObscuredULong(ulong value);
                /*0xd959cc*/ void ApplyNewCryptoKey();
                /*0xd95b8c*/ void RandomizeCryptoKey();
                /*0xd95c18*/ ulong GetEncrypted();
                /*0xd95c30*/ void SetEncrypted(ulong encrypted);
                /*0xd95a7c*/ ulong InternalDecrypt();
                /*0xd95e20*/ bool Equals(object obj);
                /*0xd95ea8*/ bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredULong obj);
                /*0xd95f3c*/ int GetHashCode();
                /*0xd95f5c*/ string ToString();
                /*0xd95f7c*/ string ToString(string format);
                /*0xd95fac*/ string ToString(System.IFormatProvider provider);
                /*0xd95fdc*/ string ToString(string format, System.IFormatProvider provider);
            }

            struct ObscuredUShort : System.IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort>, System.IFormattable
            {
                static /*0x0*/ ushort cryptoKey;
                /*0x10*/ ushort currentCryptoKey;
                /*0x12*/ ushort hiddenValue;
                /*0x14*/ ushort fakeValue;
                /*0x16*/ bool inited;

                static /*0xd96824*/ ObscuredUShort();
                static /*0xd960e0*/ void SetNewCryptoKey(ushort newKey);
                static /*0xd9613c*/ ushort EncryptDecrypt(ushort value);
                static /*0xd96194*/ ushort EncryptDecrypt(ushort value, ushort key);
                static /*0xd96498*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort op_Implicit(ushort value);
                static /*0xd96518*/ ushort op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort value);
                static /*0xd96530*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort op_Increment(CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort input);
                static /*0xd965b4*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort op_Decrement(CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort input);
                /*0xd96064*/ ObscuredUShort(ushort value);
                /*0xd96200*/ void ApplyNewCryptoKey();
                /*0xd963c4*/ void RandomizeCryptoKey();
                /*0xd96450*/ ushort GetEncrypted();
                /*0xd96468*/ void SetEncrypted(ushort encrypted);
                /*0xd962b0*/ ushort InternalDecrypt();
                /*0xd96638*/ bool Equals(object obj);
                /*0xd966b0*/ bool Equals(CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort obj);
                /*0xd9674c*/ string ToString();
                /*0xd9676c*/ string ToString(string format);
                /*0xd9679c*/ int GetHashCode();
                /*0xd967bc*/ string ToString(System.IFormatProvider provider);
                /*0xd967ec*/ string ToString(string format, System.IFormatProvider provider);
            }

            struct ObscuredVector2
            {
                static /*0x0*/ int cryptoKey;
                static /*0x4*/ UnityEngine.Vector2 initialFakeValue;
                /*0x10*/ int currentCryptoKey;
                /*0x14*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 hiddenValue;
                /*0x1c*/ UnityEngine.Vector2 fakeValue;
                /*0x24*/ bool inited;

                static /*0xd9775c*/ ObscuredVector2();
                static /*0xd96d80*/ void SetNewCryptoKey(int newKey);
                static /*0xd96ddc*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 Encrypt(UnityEngine.Vector2 value);
                static /*0xd96e44*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 Encrypt(UnityEngine.Vector2 value, int key);
                static /*0xd96f08*/ UnityEngine.Vector2 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 value);
                static /*0xd96f60*/ UnityEngine.Vector2 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 value, int key);
                static /*0xd9743c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 op_Implicit(UnityEngine.Vector2 value);
                static /*0xd974e0*/ UnityEngine.Vector2 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 value);
                static /*0xd974e4*/ UnityEngine.Vector3 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 value);
                static /*0xd974f8*/ UnityEngine.Vector2 op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 b);
                static /*0xd97558*/ UnityEngine.Vector2 op_Addition(UnityEngine.Vector2 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 b);
                static /*0xd9759c*/ UnityEngine.Vector2 op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 a, UnityEngine.Vector2 b);
                static /*0xd975e0*/ UnityEngine.Vector2 op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 b);
                static /*0xd97640*/ UnityEngine.Vector2 op_Subtraction(UnityEngine.Vector2 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 b);
                static /*0xd97684*/ UnityEngine.Vector2 op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 a, UnityEngine.Vector2 b);
                /*0xd96870*/ ObscuredVector2(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 value);
                /*0xd968f8*/ float get_x();
                /*0xd96aa0*/ void set_x(float value);
                /*0xd96b68*/ float get_y();
                /*0xd96c88*/ void set_y(float value);
                /*0xd96cb8*/ float get_Item(int index);
                /*0xd96d1c*/ void set_Item(int index, float value);
                /*0xd97028*/ void ApplyNewCryptoKey();
                /*0xd97284*/ void RandomizeCryptoKey();
                /*0xd97318*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 GetEncrypted();
                /*0xd97330*/ void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2.RawEncryptedVector2 encrypted);
                /*0xd970e4*/ UnityEngine.Vector2 InternalDecrypt();
                /*0xd97360*/ bool CompareVectorsWithTolerance(UnityEngine.Vector2 vector1, UnityEngine.Vector2 vector2);
                /*0xd96a10*/ float InternalDecryptField(int encrypted);
                /*0xd96ad0*/ int InternalEncryptField(float encrypted);
                /*0xd976c8*/ int GetHashCode();
                /*0xd9770c*/ string ToString();
                /*0xd9772c*/ string ToString(string format);

                struct RawEncryptedVector2
                {
                    /*0x10*/ int x;
                    /*0x14*/ int y;
                }
            }

            struct ObscuredVector3
            {
                static /*0x0*/ int cryptoKey;
                static /*0x4*/ UnityEngine.Vector3 initialFakeValue;
                /*0x10*/ int currentCryptoKey;
                /*0x14*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 hiddenValue;
                /*0x20*/ UnityEngine.Vector3 fakeValue;
                /*0x2c*/ bool inited;

                static /*0xd991d8*/ ObscuredVector3();
                static /*0xd97ea0*/ void SetNewCryptoKey(int newKey);
                static /*0xd97efc*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 Encrypt(UnityEngine.Vector3 value);
                static /*0xd97f7c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 Encrypt(UnityEngine.Vector3 value, int key);
                static /*0xd98064*/ UnityEngine.Vector3 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 value);
                static /*0xd980cc*/ UnityEngine.Vector3 Decrypt(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 value, int key);
                static /*0xd98684*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Implicit(UnityEngine.Vector3 value);
                static /*0xd98748*/ UnityEngine.Vector3 op_Implicit(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 value);
                static /*0xd9874c*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b);
                static /*0xd98808*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Addition(UnityEngine.Vector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b);
                static /*0xd988b8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Addition(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, UnityEngine.Vector3 b);
                static /*0xd98968*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b);
                static /*0xd98a24*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Subtraction(UnityEngine.Vector3 a, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 b);
                static /*0xd98ad4*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Subtraction(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, UnityEngine.Vector3 b);
                static /*0xd98b84*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_UnaryNegation(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a);
                static /*0xd98c28*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Multiply(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, float d);
                static /*0xd98cd0*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Multiply(float d, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a);
                static /*0xd98d78*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 op_Division(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 a, float d);
                static /*0xd98e20*/ bool op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs);
                static /*0xd98e88*/ bool op_Equality(UnityEngine.Vector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs);
                static /*0xd98ee4*/ bool op_Equality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, UnityEngine.Vector3 rhs);
                static /*0xd98f40*/ bool op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs);
                static /*0xd98fa8*/ bool op_Inequality(UnityEngine.Vector3 lhs, CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 rhs);
                static /*0xd99004*/ bool op_Inequality(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 lhs, UnityEngine.Vector3 rhs);
                /*0xd977ec*/ ObscuredVector3(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 encrypted);
                /*0xd97884*/ float get_x();
                /*0xd97a3c*/ void set_x(float value);
                /*0xd97b04*/ float get_y();
                /*0xd97c34*/ void set_y(float value);
                /*0xd97c64*/ float get_z();
                /*0xd97d90*/ void set_z(float value);
                /*0xd97dc0*/ float get_Item(int index);
                /*0xd97e30*/ void set_Item(int index, float value);
                /*0xd981b0*/ void ApplyNewCryptoKey();
                /*0xd98480*/ void RandomizeCryptoKey();
                /*0xd98528*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 GetEncrypted();
                /*0xd98544*/ void SetEncrypted(CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3.RawEncryptedVector3 encrypted);
                /*0xd98280*/ UnityEngine.Vector3 InternalDecrypt();
                /*0xd9857c*/ bool CompareVectorsWithTolerance(UnityEngine.Vector3 vector1, UnityEngine.Vector3 vector2);
                /*0xd979ac*/ float InternalDecryptField(int encrypted);
                /*0xd97a6c*/ int InternalEncryptField(float encrypted);
                /*0xd99060*/ bool Equals(object other);
                /*0xd99110*/ int GetHashCode();
                /*0xd99178*/ string ToString();
                /*0xd991a4*/ string ToString(string format);

                struct RawEncryptedVector3
                {
                    /*0x10*/ int x;
                    /*0x14*/ int y;
                    /*0x18*/ int z;
                }
            }
        }

        namespace Detectors
        {
            class ActDetectorBase : UnityEngine.MonoBehaviour
            {
                static string CONTAINER_NAME = "Anti-Cheat Toolkit Detectors";
                static string MENU_PATH = "Code Stage/Anti-Cheat Toolkit/";
                static string GAME_OBJECT_MENU_PATH = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";
                static /*0x0*/ UnityEngine.GameObject detectorsContainer;
                /*0x18*/ bool autoStart;
                /*0x19*/ bool keepAlive;
                /*0x1a*/ bool autoDispose;
                /*0x20*/ UnityEngine.Events.UnityEvent detectionEvent;
                /*0x28*/ UnityEngine.Events.UnityAction detectionAction;
                /*0x30*/ bool detectionEventHasListener;
                /*0x31*/ bool isRunning;
                /*0x32*/ bool started;

                /*0xd99750*/ ActDetectorBase();
                /*0xd99270*/ void Start();
                /*0xd99380*/ void OnEnable();
                /*0xd993a8*/ void OnDisable();
                /*0xd993c0*/ void OnApplicationQuit();
                /*0xd993cc*/ void OnDestroy();
                /*0xd99504*/ bool Init(CodeStage.AntiCheat.Detectors.ActDetectorBase instance, string detectorName);
                /*0xd99698*/ void DisposeInternal();
                /*0xd996f0*/ void OnCheatingDetected();
                void StartDetectionAutomatically();
                void StopDetectionInternal();
                void PauseDetector();
                void ResumeDetector();
            }

            class InjectionDetector : CodeStage.AntiCheat.Detectors.ActDetectorBase
            {
                static string COMPONENT_NAME = "Injection Detector";
                static string FINAL_LOG_PREFIX = "[ACTk] Injection Detector: ";
                static /*0x0*/ int instancesInScene;
                static /*0x8*/ CodeStage.AntiCheat.Detectors.InjectionDetector <Instance>k__BackingField;
                /*0x33*/ bool signaturesAreNotGenuine;
                /*0x38*/ CodeStage.AntiCheat.Detectors.InjectionDetector.AllowedAssembly[] allowedAssemblies;
                /*0x40*/ string[] hexTable;

                static /*0xd99768*/ void StartDetection();
                static /*0xd99a80*/ void StartDetection(UnityEngine.Events.UnityAction callback);
                static /*0xd99c58*/ void StopDetection();
                static /*0xd99d30*/ void Dispose();
                static /*0xd99e08*/ CodeStage.AntiCheat.Detectors.InjectionDetector get_Instance();
                static /*0xd99e50*/ void set_Instance(CodeStage.AntiCheat.Detectors.InjectionDetector value);
                static /*0xd99aa0*/ CodeStage.AntiCheat.Detectors.InjectionDetector get_GetOrCreateInstance();
                /*0xd99e9c*/ InjectionDetector();
                /*0xd99eb4*/ void Awake();
                /*0xd9a008*/ void OnDestroy();
                /*0xd9a064*/ void OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
                /*0xd9a068*/ void OnLevelLoadedCallback();
                /*0xd9987c*/ void StartDetectionInternal(UnityEngine.Events.UnityAction callback);
                /*0xd9a70c*/ void StartDetectionAutomatically();
                /*0xd9a714*/ void PauseDetector();
                /*0xd9a7b0*/ void ResumeDetector();
                /*0xd9a86c*/ void StopDetectionInternal();
                /*0xd9a918*/ void DisposeInternal();
                /*0xd9a9e4*/ void OnNewAssemblyLoaded(object sender, System.AssemblyLoadEventArgs args);
                /*0xd9a67c*/ bool FindInjectionInCurrentAssemblies();
                /*0xd9aa1c*/ bool AssemblyAllowed(System.Reflection.Assembly ass);
                /*0xd9a150*/ void LoadAndParseAllowedAssemblies();
                /*0xd9ab18*/ int GetAssemblyHash(System.Reflection.Assembly ass);
                /*0xd9ac1c*/ string PublicKeyTokenToString(byte[] bytes);

                class AllowedAssembly
                {
                    /*0x10*/ string name;
                    /*0x18*/ int[] hashes;

                    /*0xd9abf0*/ AllowedAssembly(string name, int[] hashes);
                }
            }

            class ObscuredCheatingDetector : CodeStage.AntiCheat.Detectors.ActDetectorBase
            {
                static string COMPONENT_NAME = "Obscured Cheating Detector";
                static string FINAL_LOG_PREFIX = "[ACTk] Obscured Cheating Detector: ";
                static /*0x0*/ int instancesInScene;
                static /*0x8*/ CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector <Instance>k__BackingField;
                /*0x34*/ float floatEpsilon;
                /*0x38*/ float vector2Epsilon;
                /*0x3c*/ float vector3Epsilon;
                /*0x40*/ float quaternionEpsilon;

                static /*0xd9acc0*/ void StartDetection();
                static /*0xd9af30*/ void StartDetection(UnityEngine.Events.UnityAction callback);
                static /*0xd9b108*/ void StopDetection();
                static /*0xd9b1e0*/ void Dispose();
                static /*0xd9b2b8*/ CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector get_Instance();
                static /*0xd9b300*/ void set_Instance(CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector value);
                static /*0xd9af50*/ CodeStage.AntiCheat.Detectors.ObscuredCheatingDetector get_GetOrCreateInstance();
                static /*0xd92ca0*/ bool get_IsRunning();
                /*0xd9b34c*/ ObscuredCheatingDetector();
                /*0xd9b370*/ void Awake();
                /*0xd9b4c4*/ void OnDestroy();
                /*0xd9b520*/ void OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
                /*0xd9b524*/ void OnLevelLoadedCallback();
                /*0xd9add4*/ void StartDetectionInternal(UnityEngine.Events.UnityAction callback);
                /*0xd9b60c*/ void StartDetectionAutomatically();
                /*0xd9b614*/ void PauseDetector();
                /*0xd9b61c*/ void ResumeDetector();
                /*0xd9b638*/ void StopDetectionInternal();
                /*0xd9b64c*/ void DisposeInternal();
            }

            class SpeedHackDetector : CodeStage.AntiCheat.Detectors.ActDetectorBase
            {
                static string COMPONENT_NAME = "Speed Hack Detector";
                static string FINAL_LOG_PREFIX = "[ACTk] Speed Hack Detector: ";
                static long TICKS_PER_SECOND = 10000000;
                static int THRESHOLD = 5000000;
                static /*0x0*/ int instancesInScene;
                static /*0x8*/ CodeStage.AntiCheat.Detectors.SpeedHackDetector <Instance>k__BackingField;
                /*0x34*/ float interval;
                /*0x38*/ byte maxFalsePositives;
                /*0x3c*/ int coolDown;
                /*0x40*/ byte currentFalsePositives;
                /*0x44*/ int currentCooldownShots;
                /*0x48*/ long ticksOnStart;
                /*0x50*/ long vulnerableTicksOnStart;
                /*0x58*/ long prevTicks;
                /*0x60*/ long prevIntervalTicks;

                static /*0xd9b718*/ void StartDetection();
                static /*0xd9b9dc*/ void StartDetection(UnityEngine.Events.UnityAction callback);
                static /*0xd9bbb8*/ void StartDetection(UnityEngine.Events.UnityAction callback, float interval);
                static /*0xd9bbec*/ void StartDetection(UnityEngine.Events.UnityAction callback, float interval, byte maxFalsePositives);
                static /*0xd9bc30*/ void StartDetection(UnityEngine.Events.UnityAction callback, float interval, byte maxFalsePositives, int coolDown);
                static /*0xd9bc78*/ void StopDetection();
                static /*0xd9bd50*/ void Dispose();
                static /*0xd9be28*/ CodeStage.AntiCheat.Detectors.SpeedHackDetector get_Instance();
                static /*0xd9be70*/ void set_Instance(CodeStage.AntiCheat.Detectors.SpeedHackDetector value);
                static /*0xd9ba00*/ CodeStage.AntiCheat.Detectors.SpeedHackDetector get_GetOrCreateInstance();
                /*0xd9bebc*/ SpeedHackDetector();
                /*0xd9beec*/ void Awake();
                /*0xd9c040*/ void OnDestroy();
                /*0xd9c09c*/ void OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
                /*0xd9c0a0*/ void OnLevelLoadedCallback();
                /*0xd9c188*/ void OnApplicationPause(bool pause);
                /*0xd9c228*/ void Update();
                /*0xd9b838*/ void StartDetectionInternal(UnityEngine.Events.UnityAction callback, float checkInterval, byte falsePositives, int shotsTillCooldown);
                /*0xd9c3a0*/ void StartDetectionAutomatically();
                /*0xd9c3b4*/ void PauseDetector();
                /*0xd9c3bc*/ void ResumeDetector();
                /*0xd9c3d8*/ void StopDetectionInternal();
                /*0xd9c3ec*/ void DisposeInternal();
                /*0xd9c194*/ void ResetStartTicks();
            }

            class WallHackDetector : CodeStage.AntiCheat.Detectors.ActDetectorBase
            {
                static string COMPONENT_NAME = "WallHack Detector";
                static string FINAL_LOG_PREFIX = "[ACTk] WallHack Detector: ";
                static string SERVICE_CONTAINER_NAME = "[WH Detector Service]";
                static string WIREFRAME_SHADER_NAME = "Hidden/ACTk/WallHackTexture";
                static int SHADER_TEXTURE_SIZE = 4;
                static int RENDER_TEXTURE_SIZE = 4;
                static /*0x0*/ int instancesInScene;
                static /*0x8*/ CodeStage.AntiCheat.Detectors.WallHackDetector <Instance>k__BackingField;
                /*0x34*/ UnityEngine.Vector3 rigidPlayerVelocity;
                /*0x40*/ UnityEngine.WaitForEndOfFrame waitForEndOfFrame;
                /*0x48*/ bool checkRigidbody;
                /*0x49*/ bool checkController;
                /*0x4a*/ bool checkWireframe;
                /*0x4b*/ bool checkRaycast;
                /*0x4c*/ int wireframeDelay;
                /*0x50*/ int raycastDelay;
                /*0x54*/ UnityEngine.Vector3 spawnPosition;
                /*0x60*/ byte maxFalsePositives;
                /*0x68*/ UnityEngine.GameObject serviceContainer;
                /*0x70*/ UnityEngine.GameObject solidWall;
                /*0x78*/ UnityEngine.GameObject thinWall;
                /*0x80*/ UnityEngine.Camera wfCamera;
                /*0x88*/ UnityEngine.MeshRenderer foregroundRenderer;
                /*0x90*/ UnityEngine.MeshRenderer backgroundRenderer;
                /*0x98*/ UnityEngine.Color wfColor1;
                /*0xa8*/ UnityEngine.Color wfColor2;
                /*0xb8*/ UnityEngine.Shader wfShader;
                /*0xc0*/ UnityEngine.Material wfMaterial;
                /*0xc8*/ UnityEngine.Texture2D shaderTexture;
                /*0xd0*/ UnityEngine.Texture2D targetTexture;
                /*0xd8*/ UnityEngine.RenderTexture renderTexture;
                /*0xe0*/ int whLayer;
                /*0xe4*/ int raycastMask;
                /*0xe8*/ UnityEngine.Rigidbody rigidPlayer;
                /*0xf0*/ UnityEngine.CharacterController charControllerPlayer;
                /*0xf8*/ float charControllerVelocity;
                /*0xfc*/ byte rigidbodyDetections;
                /*0xfd*/ byte controllerDetections;
                /*0xfe*/ byte wireframeDetections;
                /*0xff*/ byte raycastDetections;
                /*0x100*/ bool wireframeDetected;

                static /*0xd9e2d4*/ void StartDetection();
                static /*0xd9e5b8*/ void StartDetection(UnityEngine.Events.UnityAction callback);
                static /*0xd9e798*/ void StartDetection(UnityEngine.Events.UnityAction callback, UnityEngine.Vector3 spawnPosition);
                static /*0xd9e7e4*/ void StartDetection(UnityEngine.Events.UnityAction callback, UnityEngine.Vector3 spawnPosition, byte maxFalsePositives);
                static /*0xd9e83c*/ void StopDetection();
                static /*0xd9e914*/ void Dispose();
                static /*0xd9e9ec*/ CodeStage.AntiCheat.Detectors.WallHackDetector get_Instance();
                static /*0xd9ea34*/ void set_Instance(CodeStage.AntiCheat.Detectors.WallHackDetector value);
                static /*0xd9e5e0*/ CodeStage.AntiCheat.Detectors.WallHackDetector get_GetOrCreateInstance();
                static /*0xd9f31c*/ UnityEngine.Color32 GenerateColor();
                static /*0xd9f374*/ bool ColorsSimilar(UnityEngine.Color32 c1, UnityEngine.Color32 c2, int tolerance);
                /*0xd9ea80*/ WallHackDetector();
                /*0xd9c4b8*/ bool get_CheckRigidbody();
                /*0xd9c4c0*/ void set_CheckRigidbody(bool value);
                /*0xd9dd9c*/ bool get_CheckController();
                /*0xd9dda4*/ void set_CheckController(bool value);
                /*0xd9dff0*/ bool get_CheckWireframe();
                /*0xd9dff8*/ void set_CheckWireframe(bool value);
                /*0xd9e16c*/ bool get_CheckRaycast();
                /*0xd9e174*/ void set_CheckRaycast(bool value);
                /*0xd9eb38*/ void Awake();
                /*0xd9ec8c*/ void OnDestroy();
                /*0xd9edd4*/ void OnLevelWasLoadedNew(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
                /*0xd9edd8*/ void OnLevelLoadedCallback();
                /*0xd9eec0*/ void FixedUpdate();
                /*0xd9efec*/ void Update();
                /*0xd9e3f4*/ void StartDetectionInternal(UnityEngine.Events.UnityAction callback, UnityEngine.Vector3 servicePosition, byte falsePositivesInRow);
                /*0xd9f168*/ void StartDetectionAutomatically();
                /*0xd9f17c*/ void PauseDetector();
                /*0xd9f1b8*/ void ResumeDetector();
                /*0xd9f224*/ void StopDetectionInternal();
                /*0xd9f250*/ void DisposeInternal();
                /*0xd9c560*/ void UpdateServiceContainer();
                /*0xd9f100*/ System.Collections.IEnumerator InitDetector();
                /*0xd9db00*/ void StartRigidModule();
                /*0xd9de44*/ void StartControllerModule();
                /*0xd9e098*/ void StartWireframeModule();
                /*0xd9f828*/ void ShootWireframeModule();
                /*0xd9f894*/ System.Collections.IEnumerator CaptureFrame();
                /*0xd9e214*/ void StartRaycastModule();
                /*0xd9f924*/ void ShootRaycastModule();
                /*0xd9dcc8*/ void StopRigidModule();
                /*0xd9df68*/ void StopControllerModule();
                /*0xd9e120*/ void StopWireframeModule();
                /*0xd9e288*/ void StopRaycastModule();
                /*0xd9f514*/ void InitRigidModule();
                /*0xd9f6f4*/ void InitControllerModule();
                /*0xd9f474*/ void UninitRigidModule();
                /*0xd9f654*/ void UninitControllerModule();
                /*0xd9ef94*/ bool Detect();

                class <InitDetector>d__78 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ CodeStage.AntiCheat.Detectors.WallHackDetector <>4__this;

                    /*0xd9f44c*/ <InitDetector>d__78(int <>1__state);
                    /*0xd9fa74*/ void System.IDisposable.Dispose();
                    /*0xd9fa78*/ bool MoveNext();
                    /*0xd9fb18*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0xd9fb20*/ void System.Collections.IEnumerator.Reset();
                    /*0xd9fb60*/ object System.Collections.IEnumerator.get_Current();
                }

                class <CaptureFrame>d__83 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ CodeStage.AntiCheat.Detectors.WallHackDetector <>4__this;
                    /*0x28*/ UnityEngine.RenderTexture <previousActive>5__2;

                    /*0xd9f8fc*/ <CaptureFrame>d__83(int <>1__state);
                    /*0xd9fb68*/ void System.IDisposable.Dispose();
                    /*0xd9fb6c*/ bool MoveNext();
                    /*0xda0080*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0xda0088*/ void System.Collections.IEnumerator.Reset();
                    /*0xda00c8*/ object System.Collections.IEnumerator.get_Current();
                }
            }
        }

        namespace Common
        {
            class Constants
            {
                static string LOG_PREFIX = "[ACTk] ";

                /*0xda00d0*/ Constants();
            }
        }

        namespace Examples
        {
            class ActRotatorExample : UnityEngine.MonoBehaviour
            {
                /*0x18*/ float speed;

                /*0xda0124*/ ActRotatorExample();
                /*0xda00d8*/ void Update();
            }

            class ActTesterGui : UnityEngine.MonoBehaviour
            {
                static string RED_COLOR = "#FF4040";
                static string GREEN_COLOR = "#02C85F";
                static string PREFS_STRING = "name";
                static string PREFS_INT = "money";
                static string PREFS_FLOAT = "lifeBar";
                static string PREFS_BOOL = "gameComplete";
                static string PREFS_UINT = "demoUint";
                static string PREFS_LONG = "demoLong";
                static string PREFS_DOUBLE = "demoDouble";
                static string PREFS_VECTOR2 = "demoVector2";
                static string PREFS_VECTOR3 = "demoVector3";
                static string PREFS_QUATERNION = "demoQuaternion";
                static string PREFS_RECT = "demoRect";
                static string PREFS_COLOR = "demoColor";
                static string PREFS_BYTE_ARRAY = "demoByteArray";
                static string API_URL_LOCK_TO_DEVICE = "http://j.mp/1gxg1tf";
                static string API_URL_PRESERVE_PREFS = "http://j.mp/1iBK5pz";
                static string API_URL_EMERGENCY_MODE = "http://j.mp/1FRAL5L";
                static string API_URL_READ_FOREIGN = "http://j.mp/1LCdpDa";
                static string API_URL_UNOBSCURED_MODE = "http://j.mp/1KVrpxi";
                static string API_URL_PLAYER_PREFS = "http://docs.unity3d.com/ScriptReference/PlayerPrefs.html";
                /*0x18*/ string regularString;
                /*0x20*/ int regularInt;
                /*0x24*/ float regularFloat;
                /*0x28*/ UnityEngine.Vector3 regularVector3;
                /*0x38*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredString obscuredString;
                /*0x40*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredInt obscuredInt;
                /*0x50*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat obscuredFloat;
                /*0x68*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector3 obscuredVector3;
                /*0x88*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredBool obscuredBool;
                /*0x98*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredLong obscuredLong;
                /*0xb8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble obscuredDouble;
                /*0xd8*/ CodeStage.AntiCheat.ObscuredTypes.ObscuredVector2 obscuredVector2;
                /*0xf0*/ string prefsEncryptionKey;
                /*0xf8*/ string[] tabs;
                /*0x100*/ int currentTab;
                /*0x108*/ string allSimpleObscuredTypes;
                /*0x110*/ string regularPrefs;
                /*0x118*/ string obscuredPrefs;
                /*0x120*/ int savesLock;
                /*0x124*/ bool savesAlterationDetected;
                /*0x125*/ bool foreignSavesDetected;
                /*0x126*/ bool injectionDetected;
                /*0x127*/ bool speedHackDetected;
                /*0x128*/ bool obscuredTypeCheatDetected;
                /*0x129*/ bool wallHackCheatDetected;
                /*0x130*/ System.Text.StringBuilder logBuilder;

                /*0xda8718*/ ActTesterGui();
                /*0xda0134*/ void OnSpeedHackDetected();
                /*0xda01a8*/ void OnInjectionDetected();
                /*0xda021c*/ void OnObscuredTypeCheatingDetected();
                /*0xda0290*/ void OnWallHackDetected();
                /*0xda0304*/ void OnValidate();
                /*0xda03a0*/ void Awake();
                /*0xda04d0*/ void Start();
                /*0xda133c*/ void RandomizeObscuredVars();
                /*0xda054c*/ void ObscuredStringExample();
                /*0xda070c*/ void ObscuredIntExample();
                /*0xda0bac*/ void ObscuredFloatExample();
                /*0xda0f80*/ void ObscuredVector3Example();
                /*0xda13c8*/ void SavesAlterationDetected();
                /*0xda13d4*/ void ForeignSavesDetected();
                /*0xda13e0*/ void OnGUI();
                /*0xda6e4c*/ string GetAllSimpleObscuredTypes();
                /*0xda7154*/ string GetAllObscuredPrefsDataTypes();
                /*0xda71b4*/ void LoadRegularPrefs();
                /*0xda7348*/ void SaveRegularPrefs();
                /*0xda7400*/ void DeleteRegularPrefs();
                /*0xda7494*/ void LoadObscuredPrefs();
                /*0xda7f00*/ void SaveObscuredPrefs();
                /*0xda83a8*/ void DeleteObscuredPrefs();
                /*0xda85b8*/ void PlaceUrlButton(string url);
                /*0xda86b0*/ void PlaceUrlButton(string url, int width);
                /*0xda85c0*/ void PlaceUrlButton(string url, string buttonName, int width);
                /*0xda8708*/ void OnApplicationQuit();

                class <>c__DisplayClass62_0
                {
                    /*0x10*/ string types;

                    /*0xda86a8*/ <>c__DisplayClass62_0();
                    /*0xda8af8*/ void <GetAllSimpleObscuredTypes>b__1(System.Type t);
                }

                class <>c
                {
                    static /*0x0*/ CodeStage.AntiCheat.Examples.ActTesterGui.<> <>9;
                    static /*0x8*/ System.Func<System.Type, bool> <>9__62_0;

                    static /*0xda8b9c*/ <>c();
                    /*0xda8c00*/ <>c();
                    /*0xda8c08*/ bool <GetAllSimpleObscuredTypes>b__62_0(System.Type t);
                }
            }

            class HorizontalLayout : System.IDisposable
            {
                /*0xda6e2c*/ HorizontalLayout(UnityEngine.GUILayoutOption[] options);
                /*0xda8cc0*/ void Dispose();
            }

            class VerticalLayout : System.IDisposable
            {
                /*0xda7194*/ VerticalLayout(UnityEngine.GUILayoutOption[] options);
                /*0xda70b4*/ VerticalLayout(UnityEngine.GUIStyle style);
                /*0xda8cc8*/ void Dispose();
            }

            class ObscuredPerformanceTests : UnityEngine.MonoBehaviour
            {
                /*0x18*/ bool boolTest;
                /*0x1c*/ int boolIterations;
                /*0x20*/ bool byteTest;
                /*0x24*/ int byteIterations;
                /*0x28*/ bool shortTest;
                /*0x2c*/ int shortIterations;
                /*0x30*/ bool ushortTest;
                /*0x34*/ int ushortIterations;
                /*0x38*/ bool intTest;
                /*0x3c*/ int intIterations;
                /*0x40*/ bool uintTest;
                /*0x44*/ int uintIterations;
                /*0x48*/ bool longTest;
                /*0x4c*/ int longIterations;
                /*0x50*/ bool floatTest;
                /*0x54*/ int floatIterations;
                /*0x58*/ bool doubleTest;
                /*0x5c*/ int doubleIterations;
                /*0x60*/ bool stringTest;
                /*0x64*/ int stringIterations;
                /*0x68*/ bool vector3Test;
                /*0x6c*/ int vector3Iterations;
                /*0x70*/ bool prefsTest;
                /*0x74*/ int prefsIterations;
                /*0x78*/ System.Text.StringBuilder logBuilder;

                /*0xdab400*/ ObscuredPerformanceTests();
                /*0xda8cd0*/ void Start();
                /*0xda8d20*/ void StartTests();
                /*0xda8e7c*/ void TestBool();
                /*0xda9174*/ void TestByte();
                /*0xda945c*/ void TestShort();
                /*0xda9728*/ void TestUShort();
                /*0xdaa608*/ void TestDouble();
                /*0xdaa2c0*/ void TestFloat();
                /*0xda99f4*/ void TestInt();
                /*0xda9fb0*/ void TestLong();
                /*0xdaa91c*/ void TestString();
                /*0xda9cd4*/ void TestUInt();
                /*0xdaac7c*/ void TestVector3();
                /*0xdaafc8*/ void TestPrefs();
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> BAED642339816AFFB3FE8719792D0E4CE82F12DB72B7373D244EAA65445800FE;
    static /*0x10*/ int C9513413361171C289BA71B26C2E428164D74AC7979C32D27C62C530C7DD1E4C;

    static /*0x91a64c*/ uint ComputeStringHash(string s);

    struct __StaticArrayInitTypeSize=16
    {
    }
}
