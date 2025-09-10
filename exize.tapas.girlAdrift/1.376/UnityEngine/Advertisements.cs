class <Module>
{
}

namespace UnityEngine
{
    namespace Advertisements
    {
        class Advertisement
        {
            static /*0x0*/ UnityEngine.Advertisements.Platform.IPlatform s_Platform;

            static /*0x19403ec*/ Advertisement();
            static /*0x1940790*/ bool get_isInitialized();
            static /*0x194085c*/ bool get_isSupported();
            static /*0x19408e8*/ bool get_debugMode();
            static /*0x19409b4*/ void set_debugMode(bool value);
            static /*0x1940a88*/ string get_version();
            static /*0x1940b54*/ bool get_isShowing();
            static /*0x1940c20*/ void Initialize(string gameId);
            static /*0x1940c78*/ void Initialize(string gameId, bool testMode);
            static /*0x1940ce0*/ void Initialize(string gameId, bool testMode, UnityEngine.Advertisements.IUnityAdsInitializationListener initializationListener);
            static /*0x1940f44*/ void Load(string placementId);
            static /*0x1940f9c*/ void Load(string placementId, UnityEngine.Advertisements.IUnityAdsLoadListener loadListener);
            static /*0x1941190*/ void Show(UnityEngine.Advertisements.ShowOptions showOptions);
            static /*0x19413bc*/ void Show(string placementId);
            static /*0x1941418*/ void Show(string placementId, UnityEngine.Advertisements.ShowOptions showOptions);
            static /*0x1941480*/ void Show(string placementId, UnityEngine.Advertisements.IUnityAdsShowListener showListener);
            static /*0x19411ec*/ void Show(string placementId, UnityEngine.Advertisements.ShowOptions showOptions, UnityEngine.Advertisements.IUnityAdsShowListener showListener);
            static /*0x1941514*/ void SetMetaData(UnityEngine.Advertisements.MetaData metaData);
            static /*0x1940448*/ UnityEngine.Advertisements.Platform.IPlatform CreatePlatform();
            static /*0x19408a8*/ bool IsSupported();

            class Banner
            {
                static /*0x194181c*/ void Load();
                static /*0x1941980*/ void Load(UnityEngine.Advertisements.BannerLoadOptions options);
                static /*0x194198c*/ void Load(string placementId);
                static /*0x1941828*/ void Load(string placementId, UnityEngine.Advertisements.BannerLoadOptions options);
                static /*0x1941994*/ void Show(string placementId);
                static /*0x194199c*/ void Show(string placementId, UnityEngine.Advertisements.BannerOptions options);
                static /*0x1941b5c*/ void Hide(bool destroy);
                static /*0x1941ca4*/ void SetPosition(UnityEngine.Advertisements.BannerPosition position);
                static /*0x1941dec*/ bool get_isLoaded();
            }
        }

        class Banner : UnityEngine.Advertisements.IBanner
        {
            /*0x10*/ UnityEngine.Advertisements.Utilities.IUnityLifecycleManager <UnityLifecycleManager>k__BackingField;
            /*0x18*/ bool <ShowAfterLoad>k__BackingField;
            /*0x20*/ UnityEngine.Advertisements.INativeBanner m_NativeBanner;

            /*0x194167c*/ Banner(UnityEngine.Advertisements.INativeBanner nativeBanner, UnityEngine.Advertisements.Utilities.IUnityLifecycleManager unityLifecycleManager);
            /*0x1941f2c*/ UnityEngine.Advertisements.Utilities.IUnityLifecycleManager get_UnityLifecycleManager();
            /*0x1941f34*/ bool get_IsLoaded();
            /*0x1941fd4*/ bool get_ShowAfterLoad();
            /*0x1941fdc*/ void set_ShowAfterLoad(bool value);
            /*0x1941fe8*/ void Load(string placementId, UnityEngine.Advertisements.BannerLoadOptions loadOptions);
            /*0x19420a4*/ void Show(string placementId, UnityEngine.Advertisements.BannerOptions showOptions);
            /*0x1942160*/ void Hide(bool destroy);
            /*0x194220c*/ void SetPosition(UnityEngine.Advertisements.BannerPosition position);
            /*0x19422b8*/ void UnityAdsBannerDidShow(string placementId, UnityEngine.Advertisements.BannerOptions bannerOptions);
            /*0x1942408*/ void UnityAdsBannerDidHide(string placementId, UnityEngine.Advertisements.BannerOptions bannerOptions);
            /*0x1942558*/ void UnityAdsBannerClick(string placementId, UnityEngine.Advertisements.BannerOptions bannerOptions);
            /*0x19426a8*/ void UnityAdsBannerDidLoad(string placementId, UnityEngine.Advertisements.BannerLoadOptions bannerOptions);
            /*0x19427f8*/ void UnityAdsBannerDidError(string message, UnityEngine.Advertisements.BannerLoadOptions bannerOptions);

            class <>c__DisplayClass15_0
            {
                /*0x10*/ UnityEngine.Advertisements.BannerOptions bannerOptions;

                /*0x1942400*/ <>c__DisplayClass15_0();
                /*0x194294c*/ void <UnityAdsBannerDidShow>b__0();
            }

            class <>c__DisplayClass16_0
            {
                /*0x10*/ UnityEngine.Advertisements.BannerOptions bannerOptions;

                /*0x1942550*/ <>c__DisplayClass16_0();
                /*0x1942978*/ void <UnityAdsBannerDidHide>b__0();
            }

            class <>c__DisplayClass17_0
            {
                /*0x10*/ UnityEngine.Advertisements.BannerOptions bannerOptions;

                /*0x19426a0*/ <>c__DisplayClass17_0();
                /*0x19429a4*/ void <UnityAdsBannerClick>b__0();
            }

            class <>c__DisplayClass18_0
            {
                /*0x10*/ UnityEngine.Advertisements.BannerLoadOptions bannerOptions;

                /*0x19427f0*/ <>c__DisplayClass18_0();
                /*0x19429d0*/ void <UnityAdsBannerDidLoad>b__0();
            }

            class <>c__DisplayClass19_0
            {
                /*0x10*/ UnityEngine.Advertisements.BannerLoadOptions bannerOptions;
                /*0x18*/ string message;

                /*0x1942944*/ <>c__DisplayClass19_0();
                /*0x19429fc*/ void <UnityAdsBannerDidError>b__0();
            }
        }

        class BannerLoadOptions
        {
            /*0x10*/ UnityEngine.Advertisements.BannerLoadOptions.LoadCallback <loadCallback>k__BackingField;
            /*0x18*/ UnityEngine.Advertisements.BannerLoadOptions.ErrorCallback <errorCallback>k__BackingField;

            /*0x1942a8c*/ BannerLoadOptions();
            /*0x1942a6c*/ UnityEngine.Advertisements.BannerLoadOptions.LoadCallback get_loadCallback();
            /*0x1942a74*/ void set_loadCallback(UnityEngine.Advertisements.BannerLoadOptions.LoadCallback value);
            /*0x1942a7c*/ UnityEngine.Advertisements.BannerLoadOptions.ErrorCallback get_errorCallback();
            /*0x1942a84*/ void set_errorCallback(UnityEngine.Advertisements.BannerLoadOptions.ErrorCallback value);

            class LoadCallback : System.MulticastDelegate
            {
                /*0x1942a94*/ LoadCallback(object object, nint method);
                /*0x1942b50*/ void Invoke();
                /*0x1942b64*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x1942b84*/ void EndInvoke(System.IAsyncResult result);
            }

            class ErrorCallback : System.MulticastDelegate
            {
                /*0x1942b90*/ ErrorCallback(object object, nint method);
                /*0x1942c64*/ void Invoke(string message);
                /*0x1942c78*/ System.IAsyncResult BeginInvoke(string message, System.AsyncCallback callback, object object);
                /*0x1942c98*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class BannerOptions
        {
            /*0x10*/ UnityEngine.Advertisements.BannerOptions.BannerCallback <showCallback>k__BackingField;
            /*0x18*/ UnityEngine.Advertisements.BannerOptions.BannerCallback <hideCallback>k__BackingField;
            /*0x20*/ UnityEngine.Advertisements.BannerOptions.BannerCallback <clickCallback>k__BackingField;

            /*0x1942cd4*/ BannerOptions();
            /*0x1942ca4*/ UnityEngine.Advertisements.BannerOptions.BannerCallback get_showCallback();
            /*0x1942cac*/ void set_showCallback(UnityEngine.Advertisements.BannerOptions.BannerCallback value);
            /*0x1942cb4*/ UnityEngine.Advertisements.BannerOptions.BannerCallback get_hideCallback();
            /*0x1942cbc*/ void set_hideCallback(UnityEngine.Advertisements.BannerOptions.BannerCallback value);
            /*0x1942cc4*/ UnityEngine.Advertisements.BannerOptions.BannerCallback get_clickCallback();
            /*0x1942ccc*/ void set_clickCallback(UnityEngine.Advertisements.BannerOptions.BannerCallback value);

            class BannerCallback : System.MulticastDelegate
            {
                /*0x1942cdc*/ BannerCallback(object object, nint method);
                /*0x1942d98*/ void Invoke();
                /*0x1942dac*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x1942dcc*/ void EndInvoke(System.IAsyncResult result);
            }
        }

        class Configuration
        {
            /*0x10*/ bool <enabled>k__BackingField;
            /*0x18*/ string <defaultPlacement>k__BackingField;
            /*0x20*/ System.Collections.Generic.Dictionary<string, bool> <placements>k__BackingField;

            /*0x1942df0*/ Configuration(string configurationResponse);
            /*0x1942dd8*/ bool get_enabled();
            /*0x1942de0*/ string get_defaultPlacement();
            /*0x1942de8*/ System.Collections.Generic.Dictionary<string, bool> get_placements();
        }

        class UnityAdsInitializationListenerMainDispatch : UnityEngine.Advertisements.IUnityAdsInitializationListener
        {
            /*0x10*/ UnityEngine.Advertisements.IUnityAdsInitializationListener m_InitializationListener;
            /*0x18*/ UnityEngine.Advertisements.Utilities.IUnityLifecycleManager m_LifecycleManager;

            /*0x1940f18*/ UnityAdsInitializationListenerMainDispatch(UnityEngine.Advertisements.IUnityAdsInitializationListener initializationListener, UnityEngine.Advertisements.Utilities.IUnityLifecycleManager lifecycleManager);
            /*0x1943284*/ void OnInitializationComplete();
            /*0x1943374*/ void OnInitializationFailed(UnityEngine.Advertisements.UnityAdsInitializationError error, string message);
            /*0x19434b4*/ void <OnInitializationComplete>b__3_0();

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Advertisements.UnityAdsInitializationListenerMainDispatch <>4__this;
                /*0x18*/ UnityEngine.Advertisements.UnityAdsInitializationError error;
                /*0x20*/ string message;

                /*0x19434ac*/ <>c__DisplayClass4_0();
                /*0x194355c*/ void <OnInitializationFailed>b__0();
            }
        }

        class UnityAdsLoadListenerMainDispatch : UnityEngine.Advertisements.IUnityAdsLoadListener
        {
            /*0x10*/ UnityEngine.Advertisements.IUnityAdsLoadListener m_LoadListener;
            /*0x18*/ UnityEngine.Advertisements.Utilities.IUnityLifecycleManager m_LifecycleManager;

            /*0x1941164*/ UnityAdsLoadListenerMainDispatch(UnityEngine.Advertisements.IUnityAdsLoadListener loadListener, UnityEngine.Advertisements.Utilities.IUnityLifecycleManager lifecycleManager);
            /*0x1943624*/ void OnUnityAdsAdLoaded(string placementId);
            /*0x1943758*/ void OnUnityAdsFailedToLoad(string placementId, UnityEngine.Advertisements.UnityAdsLoadError error, string message);

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Advertisements.UnityAdsLoadListenerMainDispatch <>4__this;
                /*0x18*/ string placementId;

                /*0x1943750*/ <>c__DisplayClass3_0();
                /*0x19438a4*/ void <OnUnityAdsAdLoaded>b__0();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Advertisements.UnityAdsLoadListenerMainDispatch <>4__this;
                /*0x18*/ string placementId;
                /*0x20*/ UnityEngine.Advertisements.UnityAdsLoadError error;
                /*0x28*/ string message;

                /*0x194389c*/ <>c__DisplayClass4_0();
                /*0x1943960*/ void <OnUnityAdsFailedToLoad>b__0();
            }
        }

        class UnityAdsShowListenerMainDispatch : UnityEngine.Advertisements.IUnityAdsShowListener
        {
            /*0x10*/ UnityEngine.Advertisements.IUnityAdsShowListener m_ShowListener;
            /*0x18*/ UnityEngine.Advertisements.Utilities.IUnityLifecycleManager m_LifecycleManager;

            /*0x19414e8*/ UnityAdsShowListenerMainDispatch(UnityEngine.Advertisements.IUnityAdsShowListener showListener, UnityEngine.Advertisements.Utilities.IUnityLifecycleManager lifecycleManager);
            /*0x1943a3c*/ void OnUnityAdsShowFailure(string placementId, UnityEngine.Advertisements.UnityAdsShowError error, string message);
            /*0x1943b88*/ void OnUnityAdsShowStart(string placementId);
            /*0x1943cbc*/ void OnUnityAdsShowClick(string placementId);
            /*0x1943df0*/ void OnUnityAdsShowComplete(string placementId, UnityEngine.Advertisements.UnityAdsShowCompletionState showCompletionState);

            class <>c__DisplayClass3_0
            {
                /*0x10*/ UnityEngine.Advertisements.UnityAdsShowListenerMainDispatch <>4__this;
                /*0x18*/ string placementId;
                /*0x20*/ UnityEngine.Advertisements.UnityAdsShowError error;
                /*0x28*/ string message;

                /*0x1943b80*/ <>c__DisplayClass3_0();
                /*0x1943f2c*/ void <OnUnityAdsShowFailure>b__0();
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ UnityEngine.Advertisements.UnityAdsShowListenerMainDispatch <>4__this;
                /*0x18*/ string placementId;

                /*0x1943cb4*/ <>c__DisplayClass4_0();
                /*0x1944004*/ void <OnUnityAdsShowStart>b__0();
            }

            class <>c__DisplayClass5_0
            {
                /*0x10*/ UnityEngine.Advertisements.UnityAdsShowListenerMainDispatch <>4__this;
                /*0x18*/ string placementId;

                /*0x1943de8*/ <>c__DisplayClass5_0();
                /*0x19440c4*/ void <OnUnityAdsShowClick>b__0();
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ UnityEngine.Advertisements.UnityAdsShowListenerMainDispatch <>4__this;
                /*0x18*/ string placementId;
                /*0x20*/ UnityEngine.Advertisements.UnityAdsShowCompletionState showCompletionState;

                /*0x1943f24*/ <>c__DisplayClass6_0();
                /*0x1944184*/ void <OnUnityAdsShowComplete>b__0();
            }
        }

        enum BannerPosition
        {
            TOP_LEFT = 0,
            TOP_CENTER = 1,
            TOP_RIGHT = 2,
            BOTTOM_LEFT = 3,
            BOTTOM_CENTER = 4,
            BOTTOM_RIGHT = 5,
            CENTER = 6,
        }

        enum ShowResult
        {
            Failed = 0,
            Skipped = 1,
            Finished = 2,
        }

        enum UnityAdsCompletionState
        {
            SKIPPED = 0,
            COMPLETED = 1,
            UNKNOWN = 2,
        }

        enum UnityAdsInitializationError
        {
            UNKNOWN = 0,
            INTERNAL_ERROR = 1,
            INVALID_ARGUMENT = 2,
            AD_BLOCKER_DETECTED = 3,
        }

        enum UnityAdsLoadError
        {
            INITIALIZE_FAILED = 0,
            INTERNAL_ERROR = 1,
            INVALID_ARGUMENT = 2,
            NO_FILL = 3,
            TIMEOUT = 4,
            UNKNOWN = 5,
        }

        enum UnityAdsShowCompletionState
        {
            SKIPPED = 0,
            COMPLETED = 1,
            UNKNOWN = 2,
        }

        enum UnityAdsShowError
        {
            NOT_INITIALIZED = 0,
            NOT_READY = 1,
            VIDEO_PLAYER_ERROR = 2,
            INVALID_ARGUMENT = 3,
            NO_CONNECTION = 4,
            ALREADY_SHOWING = 5,
            INTERNAL_ERROR = 6,
            UNKNOWN = 7,
        }

        interface IBanner
        {
            UnityEngine.Advertisements.Utilities.IUnityLifecycleManager get_UnityLifecycleManager();
            bool get_IsLoaded();
            bool get_ShowAfterLoad();
            void set_ShowAfterLoad(bool value);
            void Load(string placementId, UnityEngine.Advertisements.BannerLoadOptions loadOptions);
            void Show(string placementId, UnityEngine.Advertisements.BannerOptions showOptions);
            void Hide(bool destroy);
            void SetPosition(UnityEngine.Advertisements.BannerPosition position);
            void UnityAdsBannerDidShow(string placementId, UnityEngine.Advertisements.BannerOptions bannerOptions);
            void UnityAdsBannerDidHide(string placementId, UnityEngine.Advertisements.BannerOptions bannerOptions);
            void UnityAdsBannerClick(string placementId, UnityEngine.Advertisements.BannerOptions bannerOptions);
            void UnityAdsBannerDidLoad(string placementId, UnityEngine.Advertisements.BannerLoadOptions bannerOptions);
            void UnityAdsBannerDidError(string message, UnityEngine.Advertisements.BannerLoadOptions bannerOptions);
        }

        interface INativeBanner
        {
            bool get_IsLoaded();
            void SetupBanner(UnityEngine.Advertisements.IBanner banner);
            void Load(string placementId, UnityEngine.Advertisements.BannerLoadOptions loadOptions);
            void Show(string placementId, UnityEngine.Advertisements.BannerOptions showOptions);
            void Hide(bool destroy);
            void SetPosition(UnityEngine.Advertisements.BannerPosition position);
        }

        interface IUnityAdsInitializationListener
        {
            void OnInitializationComplete();
            void OnInitializationFailed(UnityEngine.Advertisements.UnityAdsInitializationError error, string message);
        }

        interface IUnityAdsLoadListener
        {
            void OnUnityAdsAdLoaded(string placementId);
            void OnUnityAdsFailedToLoad(string placementId, UnityEngine.Advertisements.UnityAdsLoadError error, string message);
        }

        interface IUnityAdsShowListener
        {
            void OnUnityAdsShowFailure(string placementId, UnityEngine.Advertisements.UnityAdsShowError error, string message);
            void OnUnityAdsShowStart(string placementId);
            void OnUnityAdsShowClick(string placementId);
            void OnUnityAdsShowComplete(string placementId, UnityEngine.Advertisements.UnityAdsShowCompletionState showCompletionState);
        }

        class MetaData
        {
            /*0x10*/ System.Collections.Generic.IDictionary<string, object> m_MetaData;
            /*0x18*/ string <category>k__BackingField;

            /*0x194425c*/ MetaData(string category);
            /*0x194424c*/ string get_category();
            /*0x1944254*/ void set_category(string value);
            /*0x19442ec*/ void Set(string key, object value);
            /*0x19443a8*/ object Get(string key);
            /*0x1944450*/ System.Collections.Generic.IDictionary<string, object> Values();
            /*0x1944458*/ string ToJSON();
        }

        class AndroidInitializationListener : UnityEngine.AndroidJavaProxy
        {
            static string CLASS_REFERENCE = "com.unity3d.ads.IUnityAdsInitializationListener";
            /*0x20*/ UnityEngine.Advertisements.IUnityAdsInitializationListener m_ManagedListener;

            /*0x1944464*/ AndroidInitializationListener(UnityEngine.Advertisements.IUnityAdsInitializationListener initializationListener);
            /*0x19444e8*/ void onInitializationComplete();
            /*0x1944590*/ void onInitializationFailed(UnityEngine.AndroidJavaObject error, string message);
        }

        class AndroidLoadListener : UnityEngine.AndroidJavaProxy
        {
            static string CLASS_REFERENCE = "com.unity3d.ads.IUnityAdsLoadListener";
            /*0x20*/ UnityEngine.Advertisements.IUnityAdsLoadListener m_ManagedListener;

            /*0x1944680*/ AndroidLoadListener(UnityEngine.Advertisements.IUnityAdsLoadListener loadListener);
            /*0x1944704*/ void onUnityAdsAdLoaded(string placementId);
            /*0x19447b4*/ void onUnityAdsFailedToLoad(string placementId, UnityEngine.AndroidJavaObject error, string message);
        }

        class AndroidShowListener : UnityEngine.AndroidJavaProxy
        {
            static string OBJECT_ID = "com.unity3d.ads.IUnityAdsShowListener";
            /*0x20*/ UnityEngine.Advertisements.Platform.IPlatform m_Platform;
            /*0x28*/ UnityEngine.Advertisements.IUnityAdsShowListener m_ManagedListener;

            /*0x19448ac*/ AndroidShowListener(UnityEngine.Advertisements.Platform.IPlatform platform, UnityEngine.Advertisements.IUnityAdsShowListener showListener);
            /*0x1944934*/ void onUnityAdsShowFailure(string placementId, UnityEngine.AndroidJavaObject error, string message);
            /*0x1944abc*/ void onUnityAdsShowStart(string placementId);
            /*0x1944bf0*/ void onUnityAdsShowClick(string placementId);
            /*0x1944d24*/ void onUnityAdsShowComplete(string placementId, UnityEngine.AndroidJavaObject state);
        }

        interface INativePlatform
        {
            void SetupPlatform(UnityEngine.Advertisements.Platform.IPlatform platform);
            void Initialize(string gameId, bool testMode, UnityEngine.Advertisements.IUnityAdsInitializationListener initializationListener);
            void Load(string placementId, UnityEngine.Advertisements.IUnityAdsLoadListener loadListener);
            void Show(string placementId, UnityEngine.Advertisements.IUnityAdsShowListener showListener);
            void SetMetaData(UnityEngine.Advertisements.MetaData metaData);
            bool GetDebugMode();
            void SetDebugMode(bool debugMode);
            string GetVersion();
            bool IsInitialized();
        }

        class ShowOptions
        {
            /*0x10*/ string <gamerSid>k__BackingField;

            /*0x1944ea8*/ ShowOptions();
            /*0x1944e98*/ string get_gamerSid();
            /*0x1944ea0*/ void set_gamerSid(string value);
        }

        namespace Utilities
        {
            class ApplicationQuit : UnityEngine.MonoBehaviour
            {
                /*0x18*/ UnityEngine.Events.UnityAction OnApplicationQuitEventHandler;

                /*0x1945004*/ ApplicationQuit();
                /*0x1944eb0*/ void add_OnApplicationQuitEventHandler(UnityEngine.Events.UnityAction value);
                /*0x1944f4c*/ void remove_OnApplicationQuitEventHandler(UnityEngine.Events.UnityAction value);
                /*0x1944fe8*/ void OnApplicationQuit();
            }

            class AssemblyInfoUtilities
            {
                static /*0x194500c*/ string GetCurrentAssemblyInfoVersion();
            }

            class Color
            {
                static int Transparent = 0;
            }

            class CoroutineExecutor : UnityEngine.MonoBehaviour
            {
                /*0x18*/ int referenceCount;
                /*0x20*/ System.Collections.Generic.Queue<System.Action> queue;

                /*0x19451ac*/ CoroutineExecutor();
                /*0x194507c*/ void Update();
            }

            class EnumUtilities
            {
                static T GetEnumFromAndroidJavaObject<T>(UnityEngine.AndroidJavaObject androidJavaObject, T defaultValue);
            }

            interface IUnityLifecycleManager : System.IDisposable
            {
                UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator enumerator);
                void Post(System.Action action);
                void SetOnApplicationQuitCallback(UnityEngine.Events.UnityAction action);
            }

            class Json
            {
                static /*0x1943278*/ object Deserialize(string json);
                static /*0x1944460*/ string Serialize(object obj);

                class Parser : System.IDisposable
                {
                    static string WORD_BREAK = "{}[],:"";
                    /*0x10*/ System.IO.StringReader json;

                    static /*0x1945438*/ bool IsWordBreak(char c);
                    static /*0x1945228*/ object Parse(string jsonString);
                    /*0x19454d4*/ Parser(string jsonString);
                    /*0x194556c*/ void Dispose();
                    /*0x1945594*/ System.Collections.Generic.Dictionary<string, object> ParseObject();
                    /*0x1945adc*/ System.Collections.Generic.List<object> ParseArray();
                    /*0x1945550*/ object ParseValue();
                    /*0x1945c00*/ object ParseByToken(UnityEngine.Advertisements.Utilities.Json.Parser.TOKEN token);
                    /*0x194587c*/ string ParseString();
                    /*0x1945ce8*/ object ParseNumber();
                    /*0x1945f1c*/ void EatWhitespace();
                    /*0x1945fc0*/ char get_PeekChar();
                    /*0x1945df8*/ char get_NextChar();
                    /*0x1945e70*/ string get_NextWord();
                    /*0x19456b8*/ UnityEngine.Advertisements.Utilities.Json.Parser.TOKEN get_NextToken();

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

                    static /*0x19453c4*/ string Serialize(object obj);
                    /*0x1946038*/ Serializer();
                    /*0x19460a4*/ void SerializeValue(object value);
                    /*0x1946890*/ void SerializeObject(System.Collections.IDictionary obj);
                    /*0x1946530*/ void SerializeArray(System.Collections.IList anArray);
                    /*0x1946274*/ void SerializeString(string str);
                    /*0x1946d1c*/ void SerializeOther(object value);
                }
            }

            class UnityLifecycleManager : UnityEngine.Advertisements.Utilities.IUnityLifecycleManager, System.IDisposable
            {
                static string gameObjectName = "UnityEngine_UnityAds_CoroutineExecutor";
                /*0x10*/ UnityEngine.GameObject m_GameObject;
                /*0x18*/ UnityEngine.Advertisements.Utilities.CoroutineExecutor m_CoroutineExecutor;
                /*0x20*/ UnityEngine.Advertisements.Utilities.ApplicationQuit m_ApplicationQuit;
                /*0x28*/ bool m_Disposed;

                /*0x19415e8*/ UnityLifecycleManager();
                /*0x1946fec*/ void Initialize();
                /*0x19471e4*/ UnityEngine.Coroutine StartCoroutine(System.Collections.IEnumerator enumerator);
                /*0x194727c*/ void Post(System.Action action);
                /*0x19473cc*/ void Dispose();
                /*0x1947460*/ void SetOnApplicationQuitCallback(UnityEngine.Events.UnityAction callback);
            }
        }

        namespace Platform
        {
            interface IPlatform
            {
                UnityEngine.Advertisements.IBanner get_Banner();
                UnityEngine.Advertisements.Utilities.IUnityLifecycleManager get_UnityLifecycleManager();
                UnityEngine.Advertisements.INativePlatform get_NativePlatform();
                bool get_IsInitialized();
                bool get_IsShowing();
                string get_Version();
                bool get_DebugMode();
                void set_DebugMode(bool value);
                void Initialize(string gameId, bool testMode, UnityEngine.Advertisements.IUnityAdsInitializationListener initializationListener);
                void Load(string placementId, UnityEngine.Advertisements.IUnityAdsLoadListener loadListener);
                void Show(string placementId, UnityEngine.Advertisements.ShowOptions showOptions, UnityEngine.Advertisements.IUnityAdsShowListener showListener);
                void SetMetaData(UnityEngine.Advertisements.MetaData metaData);
                void OnUnityAdsShowFailure(string placementId, UnityEngine.Advertisements.UnityAdsShowError error, string message);
                void OnUnityAdsShowStart(string placementId);
                void OnUnityAdsShowClick(string placementId);
                void OnUnityAdsShowComplete(string placementId, UnityEngine.Advertisements.UnityAdsShowCompletionState completionState);
            }

            class Platform : UnityEngine.Advertisements.Platform.IPlatform
            {
                /*0x10*/ UnityEngine.Advertisements.IBanner <Banner>k__BackingField;
                /*0x18*/ UnityEngine.Advertisements.Utilities.IUnityLifecycleManager <UnityLifecycleManager>k__BackingField;
                /*0x20*/ UnityEngine.Advertisements.INativePlatform <NativePlatform>k__BackingField;
                /*0x28*/ bool <IsShowing>k__BackingField;

                /*0x1941744*/ Platform(UnityEngine.Advertisements.INativePlatform nativePlatform, UnityEngine.Advertisements.IBanner banner, UnityEngine.Advertisements.Utilities.IUnityLifecycleManager unityLifecycleManager);
                /*0x19474f4*/ UnityEngine.Advertisements.IBanner get_Banner();
                /*0x19474fc*/ UnityEngine.Advertisements.Utilities.IUnityLifecycleManager get_UnityLifecycleManager();
                /*0x1947504*/ UnityEngine.Advertisements.INativePlatform get_NativePlatform();
                /*0x194750c*/ bool get_IsInitialized();
                /*0x19475bc*/ bool get_IsShowing();
                /*0x19475c4*/ void set_IsShowing(bool value);
                /*0x19475d0*/ string get_Version();
                /*0x194769c*/ bool get_DebugMode();
                /*0x194774c*/ void set_DebugMode(bool value);
                /*0x1947800*/ void Initialize(string gameId, bool testMode, UnityEngine.Advertisements.IUnityAdsInitializationListener initializationListener);
                /*0x1947ac8*/ void Load(string placementId);
                /*0x1947ad0*/ void Load(string placementId, UnityEngine.Advertisements.IUnityAdsLoadListener loadListener);
                /*0x1947bec*/ void Show(string placementId, UnityEngine.Advertisements.ShowOptions showOptions, UnityEngine.Advertisements.IUnityAdsShowListener showListener);
                /*0x1947a1c*/ void SetMetaData(UnityEngine.Advertisements.MetaData metaData);
                /*0x1947d68*/ void OnUnityAdsShowFailure(string placementId, UnityEngine.Advertisements.UnityAdsShowError error, string message);
                /*0x1947d70*/ void OnUnityAdsShowStart(string placementId);
                /*0x1947d7c*/ void OnUnityAdsShowClick(string placementId);
                /*0x1947d80*/ void OnUnityAdsShowComplete(string placementId, UnityEngine.Advertisements.UnityAdsShowCompletionState completionState);
            }

            namespace Unsupported
            {
                class UnsupportedBanner : UnityEngine.Advertisements.INativeBanner
                {
                    /*0x1941814*/ UnsupportedBanner();
                    /*0x1947d88*/ bool get_IsLoaded();
                    /*0x1947d90*/ void SetupBanner(UnityEngine.Advertisements.IBanner banner);
                    /*0x1947d94*/ void Load(string placementId, UnityEngine.Advertisements.BannerLoadOptions loadOptions);
                    /*0x1947d98*/ void Show(string placementId, UnityEngine.Advertisements.BannerOptions showOptions);
                    /*0x1947d9c*/ void Hide(bool destroy);
                    /*0x1947da0*/ void SetPosition(UnityEngine.Advertisements.BannerPosition position);
                }

                class UnsupportedPlatform : UnityEngine.Advertisements.INativePlatform
                {
                    /*0x194180c*/ UnsupportedPlatform();
                    /*0x1947da4*/ void SetupPlatform(UnityEngine.Advertisements.Platform.IPlatform platform);
                    /*0x1947da8*/ void Initialize(string gameId, bool testMode, UnityEngine.Advertisements.IUnityAdsInitializationListener initializationListener);
                    /*0x1947dac*/ void Load(string placementId, UnityEngine.Advertisements.IUnityAdsLoadListener loadListener);
                    /*0x1947db0*/ void Show(string placementId, UnityEngine.Advertisements.IUnityAdsShowListener showListener);
                    /*0x1947db4*/ void SetMetaData(UnityEngine.Advertisements.MetaData metaData);
                    /*0x1947db8*/ bool GetDebugMode();
                    /*0x1947dc0*/ void SetDebugMode(bool debugMode);
                    /*0x1947dc4*/ string GetVersion();
                    /*0x1947e04*/ bool IsInitialized();
                }
            }

            namespace Editor
            {
                class BannerPlaceholder : UnityEngine.MonoBehaviour
                {
                    /*0x18*/ UnityEngine.Texture2D aTexture;
                    /*0x20*/ UnityEngine.Advertisements.BannerPosition BannerPosition;
                    /*0x28*/ UnityEngine.Advertisements.BannerOptions BannerOptions;
                    /*0x30*/ bool IsShowing;

                    static /*0x1947e40*/ UnityEngine.Texture2D BackgroundTexture(int width, int height, UnityEngine.Color color);
                    static /*0x194813c*/ UnityEngine.Rect GetBannerRect(UnityEngine.Advertisements.BannerPosition position);
                    /*0x19482dc*/ BannerPlaceholder();
                    /*0x1947e0c*/ void Awake();
                    /*0x1947f58*/ void OnGUI();
                    /*0x19482c0*/ void ShowBanner(UnityEngine.Advertisements.BannerPosition bannerPosition, UnityEngine.Advertisements.BannerOptions bannerOptions);
                    /*0x19482d4*/ void HideBanner();
                }
            }

            namespace Android
            {
                class AndroidBanner : UnityEngine.AndroidJavaProxy, UnityEngine.Advertisements.INativeBanner
                {
                    /*0x20*/ UnityEngine.Advertisements.IBanner m_Banner;
                    /*0x28*/ UnityEngine.AndroidJavaClass m_BannersClass;
                    /*0x30*/ UnityEngine.AndroidJavaObject m_CurrentActivity;
                    /*0x38*/ UnityEngine.Advertisements.Platform.Android.BannerBundle m_BannerBundle;
                    /*0x40*/ UnityEngine.Advertisements.BannerLoadOptions m_BannerLoadOptions;
                    /*0x48*/ UnityEngine.Advertisements.BannerOptions m_BannerShowOptions;
                    /*0x50*/ bool m_ListenerIsSet;

                    /*0x1941604*/ AndroidBanner();
                    /*0x19482e4*/ bool get_IsLoaded();
                    /*0x19482f4*/ void SetupBanner(UnityEngine.Advertisements.IBanner banner);
                    /*0x1948428*/ void Load(string placementId, UnityEngine.Advertisements.BannerLoadOptions loadOptions);
                    /*0x1948aac*/ void Show(string placementId, UnityEngine.Advertisements.BannerOptions showOptions);
                    /*0x19487a8*/ void Hide(bool destroy);
                    /*0x1948e14*/ void SetPosition(UnityEngine.Advertisements.BannerPosition position);
                    /*0x19490ac*/ void onUnityBannerShow(string placementId);
                    /*0x19490b0*/ void onUnityBannerHide(string placementId);
                    /*0x19490b4*/ void onUnityBannerLoaded(string placementId, UnityEngine.AndroidJavaObject view);
                    /*0x1949640*/ void onUnityBannerUnloaded(string placementId);
                    /*0x1949644*/ void onUnityBannerClick(string placementId);
                    /*0x19497ac*/ void onUnityBannerError(string message);
                    /*0x1949958*/ void <Hide>b__13_0();
                    /*0x1949ac4*/ void <Hide>b__13_1();
                    /*0x1949af8*/ void <onUnityBannerLoaded>b__17_1();
                    /*0x1949b2c*/ void <onUnityBannerLoaded>b__17_0();
                    /*0x1949b60*/ void <onUnityBannerClick>b__19_0();

                    class <>c__DisplayClass11_0
                    {
                        /*0x10*/ UnityEngine.Advertisements.BannerLoadOptions loadOptions;

                        /*0x19487a0*/ <>c__DisplayClass11_0();
                        /*0x1949b94*/ void <Load>b__0();
                    }

                    class <>c__DisplayClass12_0
                    {
                        /*0x10*/ UnityEngine.Advertisements.Platform.Android.AndroidBanner <>4__this;
                        /*0x18*/ UnityEngine.Advertisements.BannerOptions showOptions;

                        /*0x1948e0c*/ <>c__DisplayClass12_0();
                        /*0x1949bc8*/ void <Show>b__0();
                        /*0x1949e04*/ void <Show>b__1();
                    }

                    class <>c__DisplayClass20_0
                    {
                        /*0x10*/ UnityEngine.Advertisements.Platform.Android.AndroidBanner <>4__this;
                        /*0x18*/ string message;

                        /*0x1949950*/ <>c__DisplayClass20_0();
                        /*0x1949e38*/ void <onUnityBannerError>b__0();
                    }
                }

                class AndroidPlatform : UnityEngine.Advertisements.INativePlatform
                {
                    static string ADS_BASE_CLASS = "com.unity3d.ads.UnityAds";
                    static string ADS_METADATA_CLASS = "com.unity3d.ads.metadata.MetaData";
                    static string UNITY_PLAYER_CLASS = "com.unity3d.player.UnityPlayer";
                    /*0x10*/ UnityEngine.Advertisements.Platform.IPlatform m_Platform;
                    /*0x18*/ UnityEngine.AndroidJavaObject m_CurrentActivity;
                    /*0x20*/ UnityEngine.AndroidJavaClass m_UnityAds;
                    /*0x28*/ UnityEngine.AndroidJavaClass m_Placement;

                    static /*0x1948384*/ UnityEngine.AndroidJavaObject GetCurrentAndroidActivity();
                    /*0x1941674*/ AndroidPlatform();
                    /*0x1949e78*/ void SetupPlatform(UnityEngine.Advertisements.Platform.IPlatform platform);
                    /*0x1949f08*/ void Initialize(string gameId, bool testMode, UnityEngine.Advertisements.IUnityAdsInitializationListener initializationListener);
                    /*0x194a0b0*/ void Load(string placementId, UnityEngine.Advertisements.IUnityAdsLoadListener loadListener);
                    /*0x194a1d8*/ void Show(string placementId, UnityEngine.Advertisements.IUnityAdsShowListener showListener);
                    /*0x194a340*/ void SetMetaData(UnityEngine.Advertisements.MetaData metaData);
                    /*0x194a898*/ bool GetDebugMode();
                    /*0x194a964*/ void SetDebugMode(bool debugMode);
                    /*0x194aa58*/ string GetVersion();
                    /*0x194ab48*/ bool IsInitialized();
                }

                class BannerBundle
                {
                    /*0x10*/ UnityEngine.AndroidJavaObject <bannerView>k__BackingField;
                    /*0x18*/ string <bannerPlacementId>k__BackingField;

                    /*0x1949614*/ BannerBundle(string bannerPlacementId, UnityEngine.AndroidJavaObject bannerView);
                    /*0x194ac14*/ UnityEngine.AndroidJavaObject get_bannerView();
                    /*0x194ac1c*/ string get_bannerPlacementId();
                }
            }
        }

        namespace Events
        {
            class FinishEventArgs : System.EventArgs
            {
                /*0x10*/ string <placementId>k__BackingField;
                /*0x18*/ UnityEngine.Advertisements.ShowResult <showResult>k__BackingField;

                /*0x194ac34*/ FinishEventArgs(string placementId, UnityEngine.Advertisements.ShowResult showResult);
                /*0x194ac24*/ string get_placementId();
                /*0x194ac2c*/ UnityEngine.Advertisements.ShowResult get_showResult();
            }

            class StartEventArgs : System.EventArgs
            {
                /*0x10*/ string <placementId>k__BackingField;

                /*0x194acb0*/ StartEventArgs(string placementId);
                /*0x194aca8*/ string get_placementId();
            }
        }
    }
}
