class <Module>
{
}

namespace Facebook
{
    namespace MiniJSON
    {
        class Json
        {
            static /*0x0*/ System.Globalization.NumberFormatInfo numberFormat;

            static /*0x15025fc*/ Json();
            static /*0x14f1040*/ object Deserialize(string json);
            static /*0x14e33e8*/ string Serialize(object obj);

            class Parser : System.IDisposable
            {
                /*0x10*/ System.IO.StringReader json;

                static /*0x2a12c64*/ object Parse(string jsonString);
                /*0x2a12794*/ Parser(string jsonString);
                /*0x2a1280c*/ char get_PeekChar();
                /*0x2a12890*/ char get_NextChar();
                /*0x2a12914*/ string get_NextWord();
                /*0x2a12a00*/ Facebook.MiniJSON.Json.Parser.TOKEN get_NextToken();
                /*0x2a12dfc*/ void Dispose();
                /*0x2a12e30*/ System.Collections.Generic.Dictionary<string, object> ParseObject();
                /*0x2a131c8*/ System.Collections.Generic.List<object> ParseArray();
                /*0x2a12dd4*/ object ParseValue();
                /*0x2a132b0*/ object ParseByToken(Facebook.MiniJSON.Json.Parser.TOKEN token);
                /*0x2a12f58*/ string ParseString();
                /*0x2a13388*/ object ParseNumber();
                /*0x2a12bc4*/ void EatWhitespace();

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

                static /*0x2a1352c*/ string Serialize(object obj);
                /*0x2a134c4*/ Serializer();
                /*0x2a135a4*/ void SerializeValue(object value);
                /*0x2a13d34*/ void SerializeObject(System.Collections.IDictionary obj);
                /*0x2a13a2c*/ void SerializeArray(System.Collections.IList array);
                /*0x2a13760*/ void SerializeString(string str);
                /*0x2a14174*/ void SerializeOther(object value);
            }
        }
    }

    namespace Unity
    {
        class AccessToken
        {
            static /*0x0*/ Facebook.Unity.AccessToken <CurrentAccessToken>k__BackingField;
            /*0x10*/ string <TokenString>k__BackingField;
            /*0x18*/ System.DateTime <ExpirationTime>k__BackingField;
            /*0x20*/ System.Collections.Generic.IEnumerable<string> <Permissions>k__BackingField;
            /*0x28*/ string <UserId>k__BackingField;
            /*0x30*/ System.Nullable<System.DateTime> <LastRefresh>k__BackingField;
            /*0x40*/ string <GraphDomain>k__BackingField;

            static /*0x14e2e4c*/ Facebook.Unity.AccessToken get_CurrentAccessToken();
            static /*0x14e2e98*/ void set_CurrentAccessToken(Facebook.Unity.AccessToken value);
            /*0x14e2c9c*/ AccessToken(string tokenString, string userId, System.DateTime expirationTime, System.Collections.Generic.IEnumerable<string> permissions, System.Nullable<System.DateTime> lastRefresh, string graphDomain);
            /*0x14e2ee8*/ string get_TokenString();
            /*0x14e2ef0*/ void set_TokenString(string value);
            /*0x14e2ef8*/ System.DateTime get_ExpirationTime();
            /*0x14e2f00*/ void set_ExpirationTime(System.DateTime value);
            /*0x14e2f08*/ System.Collections.Generic.IEnumerable<string> get_Permissions();
            /*0x14e2f10*/ void set_Permissions(System.Collections.Generic.IEnumerable<string> value);
            /*0x14e2f18*/ string get_UserId();
            /*0x14e2f20*/ void set_UserId(string value);
            /*0x14e2f28*/ System.Nullable<System.DateTime> get_LastRefresh();
            /*0x14e2f34*/ void set_LastRefresh(System.Nullable<System.DateTime> value);
            /*0x14e2f3c*/ string get_GraphDomain();
            /*0x14e2f44*/ void set_GraphDomain(string value);
            /*0x14e2f4c*/ string ToString();
            /*0x14e314c*/ string ToJson();
        }

        class CallbackManager
        {
            /*0x10*/ System.Collections.Generic.IDictionary<string, object> facebookDelegates;
            /*0x18*/ int nextAsyncId;

            static /*0x14ea138*/ void CallCallback(object callback, Facebook.Unity.IResult result);
            static bool TryCallCallback<T>(object callback, Facebook.Unity.IResult result);
            /*0x14e392c*/ CallbackManager();
            string AddFacebookDelegate<T>(Facebook.Unity.FacebookDelegate<T> callback);
            /*0x14e9e98*/ void OnFacebookResponse(Facebook.Unity.IInternalResult result);
        }

        class ComponentFactory
        {
            static /*0x0*/ UnityEngine.GameObject facebookGameObject;

            static /*0x14f1280*/ UnityEngine.GameObject get_FacebookGameObject();
            static T GetComponent<T>(Facebook.Unity.ComponentFactory.IfNotExist ifNotExist);
            static T AddComponent<T>();

            enum IfNotExist
            {
                AddNew = 0,
                ReturnNull = 1,
            }
        }

        class Constants
        {
            static /*0x0*/ System.Nullable<Facebook.Unity.FacebookUnityPlatform> currentPlatform;

            static /*0x14f1364*/ System.Uri get_GraphUrl();
            static /*0x14f1650*/ string get_GraphApiUserAgent();
            static /*0x14f197c*/ bool get_IsEditor();
            static /*0x14f1984*/ bool get_IsWeb();
            static /*0x14e3f6c*/ string get_UnitySDKUserAgentSuffixLegacy();
            static /*0x14f1908*/ string get_UnitySDKUserAgent();
            static /*0x14f19a0*/ bool get_DebugMode();
            static /*0x14ead84*/ Facebook.Unity.FacebookUnityPlatform get_CurrentPlatform();
            static /*0x14f19fc*/ Facebook.Unity.FacebookUnityPlatform GetCurrentPlatform();
        }

        class CustomUpdateContent
        {
            /*0x10*/ string _contextTokenId;
            /*0x18*/ Facebook.Unity.CustomUpdateLocalizedText _text;
            /*0x20*/ Facebook.Unity.CustomUpdateLocalizedText _cta;
            /*0x28*/ string _image;
            /*0x30*/ Facebook.Unity.CustomUpdateMedia _media;
            /*0x38*/ string _data;

            /*0x14f1d78*/ System.Collections.Generic.IDictionary<string, string> toGraphAPIData();
        }

        class CustomUpdateLocalizedText
        {
            /*0x10*/ string _default;
            /*0x18*/ System.Collections.Generic.IDictionary<string, string> _localizations;

            /*0x14f1f28*/ string toJson();
        }

        class CustomUpdateMedia
        {
            /*0x10*/ Facebook.Unity.CustomUpdateMediaInfo _gif;
            /*0x18*/ Facebook.Unity.CustomUpdateMediaInfo _video;

            /*0x14f2040*/ string toJson();
        }

        class CustomUpdateMediaInfo
        {
            /*0x10*/ string _url;

            /*0x14f2248*/ string get_Url();
        }

        class FB : UnityEngine.ScriptableObject
        {
            static string DefaultJSSDKLocale = "en_US";
            static /*0x0*/ Facebook.Unity.IFacebook facebook;
            static /*0x8*/ bool isInitCalled;
            static /*0x10*/ string facebookDomain;
            static /*0x18*/ string gamingDomain;
            static /*0x20*/ string graphApiVersion;
            static /*0x28*/ string <AppId>k__BackingField;
            static /*0x30*/ string <ClientToken>k__BackingField;
            static /*0x38*/ Facebook.Unity.FB.OnDLLLoaded <OnDLLLoadedDelegate>k__BackingField;

            static /*0x14fb8d8*/ FB();
            static /*0x14f7e8c*/ string get_AppId();
            static /*0x14f7ef0*/ void set_AppId(string value);
            static /*0x14f7f58*/ string get_ClientToken();
            static /*0x14f7fbc*/ void set_ClientToken(string value);
            static /*0x14f8024*/ string get_GraphApiVersion();
            static /*0x14f8088*/ void set_GraphApiVersion(string value);
            static /*0x14f80f0*/ bool get_IsLoggedIn();
            static /*0x14f81fc*/ bool get_IsInitialized();
            static /*0x14f8310*/ bool get_LimitAppEventUsage();
            static /*0x14f8424*/ void set_LimitAppEventUsage(bool value);
            static /*0x14f1834*/ Facebook.Unity.IFacebook get_FacebookImpl();
            static /*0x14f8548*/ void set_FacebookImpl(Facebook.Unity.IFacebook value);
            static /*0x14f1540*/ string get_FacebookDomain();
            static /*0x14f85b0*/ void set_FacebookDomain(string value);
            static /*0x14f8618*/ Facebook.Unity.FB.OnDLLLoaded get_OnDLLLoadedDelegate();
            static /*0x14f867c*/ void set_OnDLLLoadedDelegate(Facebook.Unity.FB.OnDLLLoaded value);
            static /*0x14f86e4*/ void Init(Facebook.Unity.InitDelegate onInitComplete, Facebook.Unity.HideUnityDelegate onHideUnity, string authResponse);
            static /*0x14f8838*/ void Init(string appId, string clientToken, bool cookie, bool logging, bool status, bool xfbml, bool frictionlessRequests, string authResponse, string javascriptSDKLocale, Facebook.Unity.HideUnityDelegate onHideUnity, Facebook.Unity.InitDelegate onInitComplete);
            static /*0x14f8fcc*/ void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
            static /*0x14f90c0*/ void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
            static /*0x14f91b4*/ void LogOut();
            static /*0x14f9290*/ void AppRequest(string message, Facebook.Unity.OGActionType actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
            static /*0x14f93fc*/ void AppRequest(string message, Facebook.Unity.OGActionType actionType, string objectId, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
            static /*0x14f9578*/ void AppRequest(string message, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
            static /*0x14f96c4*/ void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
            static /*0x14f97d8*/ void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
            static /*0x14ed1e4*/ void API(string query, Facebook.Unity.HttpMethod method, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback, System.Collections.Generic.IDictionary<string, string> formData);
            static /*0x14f9920*/ void API(string query, Facebook.Unity.HttpMethod method, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback, UnityEngine.WWWForm formData);
            static /*0x14f9a98*/ void ActivateApp();
            static /*0x14f9bc4*/ void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
            static /*0x14f9cb8*/ void ClearAppLink();
            static /*0x14effac*/ void LogAppEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
            static /*0x14f9cbc*/ void LogPurchase(decimal logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
            static /*0x14f9d60*/ void LogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
            static /*0x14f9e94*/ void LogVersion();
            static /*0x14fa184*/ void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback);
            static /*0x14fa268*/ void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback);
            static /*0x14fa34c*/ void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload);
            static /*0x14fa448*/ void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback);
            static /*0x14fa53c*/ Facebook.Unity.Profile CurrentProfile();
            static /*0x14fa618*/ void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback);
            static /*0x14fa6fc*/ void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
            static /*0x14fa7f0*/ void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
            static /*0x14fa8e4*/ void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
            static /*0x14fa9d8*/ void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
            static /*0x14faacc*/ void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
            static /*0x14fabb0*/ void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
            static /*0x14fac94*/ void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
            static /*0x14fad88*/ void ScheduleAppToUserNotification(string title, string body, System.Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback);
            static /*0x14faeac*/ void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback);
            static /*0x14fafa0*/ void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
            static /*0x14fb094*/ void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
            static /*0x14fb178*/ void ShareTournament(int score, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
            static /*0x14fb274*/ void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
            static /*0x14fb3b0*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            static /*0x14fb4bc*/ void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            static /*0x14fb5c8*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            static /*0x14fb6d8*/ void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            static /*0x14fb7ec*/ void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback);
            /*0x14fb8d0*/ FB();

            class OnDLLLoaded : System.MulticastDelegate
            {
                /*0x2a12398*/ OnDLLLoaded(object object, nint method);
                /*0x2a12018*/ void Invoke();
                /*0x2a123f8*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0x2a12424*/ void EndInvoke(System.IAsyncResult result);
            }

            class Mobile
            {
                static /*0x2a12224*/ Facebook.Unity.Mobile.IMobileFacebook get_MobileFacebookImpl();
                static /*0x2a122ec*/ bool IsImplicitPurchaseLoggingEnabled();
            }

            class CompiledFacebookLoader : UnityEngine.MonoBehaviour
            {
                /*0x2a102c4*/ CompiledFacebookLoader();
                Facebook.Unity.FacebookGameObject get_FBGameObject();
                /*0x2a11f00*/ void Start();
            }

            class <>c__DisplayClass36_0
            {
                /*0x10*/ string appId;
                /*0x18*/ Facebook.Unity.HideUnityDelegate onHideUnity;
                /*0x20*/ Facebook.Unity.InitDelegate onInitComplete;
                /*0x28*/ bool cookie;
                /*0x29*/ bool logging;
                /*0x2a*/ bool status;
                /*0x2b*/ bool xfbml;
                /*0x30*/ string authResponse;
                /*0x38*/ bool frictionlessRequests;
                /*0x40*/ string javascriptSDKLocale;
                /*0x48*/ string clientToken;

                /*0x2a11930*/ <>c__DisplayClass36_0();
                /*0x2a11938*/ void <Init>b__0();
                /*0x2a11a34*/ void <Init>b__1();
                /*0x2a11b1c*/ void <Init>b__2();
                /*0x2a11c9c*/ void <Init>b__3();
                /*0x2a11db4*/ void <Init>b__4();
                /*0x2a11e5c*/ void <Init>b__5();
            }
        }

        class FBGamingServices : UnityEngine.ScriptableObject
        {
            static /*0x14fb984*/ void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
            static /*0x14fbb00*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            static /*0x14fbbe0*/ void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            static /*0x14fbcc0*/ void PerformCustomUpdate(Facebook.Unity.CustomUpdateContent content, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            static /*0x14fbd64*/ void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback);
            static /*0x14fbe1c*/ void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback);
            static /*0x14fbed4*/ void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback);
            static /*0x14fbf8c*/ void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload);
            static /*0x14fc05c*/ void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback);
            static /*0x14fc124*/ void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback);
            static /*0x14fc1dc*/ void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback);
            static /*0x14fc294*/ void ScheduleAppToUserNotification(string title, string body, System.Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback);
            static /*0x14fc38c*/ void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
            static /*0x14fc454*/ void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
            static /*0x14fc51c*/ void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
            static /*0x14fc5e4*/ void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
            static /*0x14fc6ac*/ void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback);
            static /*0x14fc764*/ void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback);
            static /*0x14fc82c*/ void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
            static /*0x14fc8e4*/ void ShareTournament(int score, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
            static /*0x14fc9b4*/ void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
            static /*0x14fcac4*/ void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
            static /*0x14fcb8c*/ void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback);
            static /*0x14fcc44*/ void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback);
            static /*0x14fcd0c*/ void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback);
            static /*0x14fcdd4*/ void ChooseGamingContext(System.Collections.Generic.List<string> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback);
            static /*0x14fceb4*/ void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback);
            static /*0x14fba3c*/ Facebook.Unity.Mobile.IMobileFacebook get_MobileFacebookImpl();
            /*0x14fcf6c*/ FBGamingServices();
        }

        class FacebookBase : Facebook.Unity.IFacebookImplementation, Facebook.Unity.IFacebook, Facebook.Unity.IFacebookWindows, Facebook.Unity.IFacebookResultHandler
        {
            /*0x10*/ Facebook.Unity.InitDelegate onInitCompleteDelegate;
            /*0x18*/ bool <Initialized>k__BackingField;
            /*0x20*/ Facebook.Unity.CallbackManager <CallbackManager>k__BackingField;

            /*0x14ea940*/ FacebookBase(Facebook.Unity.CallbackManager callbackManager);
            bool get_LimitEventUsage();
            void set_LimitEventUsage(bool value);
            string get_SDKName();
            string get_SDKVersion();
            /*0x14eaf6c*/ string get_SDKUserAgent();
            /*0x14fdfe0*/ bool get_LoggedIn();
            /*0x14fe098*/ bool get_Initialized();
            /*0x14fe0a0*/ void set_Initialized(bool value);
            /*0x14fe0ac*/ Facebook.Unity.CallbackManager get_CallbackManager();
            /*0x14fe0b4*/ void set_CallbackManager(Facebook.Unity.CallbackManager value);
            /*0x14fe0bc*/ void Init(Facebook.Unity.InitDelegate onInitComplete);
            void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
            void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
            /*0x14e45c8*/ void LogOut();
            void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
            void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
            void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
            /*0x14fe0c4*/ void API(string query, Facebook.Unity.HttpMethod method, System.Collections.Generic.IDictionary<string, string> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            /*0x14fe894*/ void API(string query, Facebook.Unity.HttpMethod method, UnityEngine.WWWForm formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            void ActivateApp(string appId);
            void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
            void AppEventsLogEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
            void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
            /*0x14fea34*/ void OnInitComplete(Facebook.Unity.ResultContainer resultContainer);
            void OnLoginComplete(Facebook.Unity.ResultContainer resultContainer);
            /*0x14febc0*/ void OnLogoutComplete(Facebook.Unity.ResultContainer resultContainer);
            void OnGetAppLinkComplete(Facebook.Unity.ResultContainer resultContainer);
            void OnAppRequestsComplete(Facebook.Unity.ResultContainer resultContainer);
            void OnShareLinkComplete(Facebook.Unity.ResultContainer resultContainer);
            /*0x14e5bb8*/ void ValidateAppRequestArgs(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
            /*0x14fec0c*/ void OnAuthResponse(Facebook.Unity.LoginResult result);
            /*0x14fe3d8*/ System.Collections.Generic.IDictionary<string, string> CopyByValue(System.Collections.Generic.IDictionary<string, string> data);
            /*0x14fe7c8*/ System.Uri GetGraphUrl(string query);
            void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback);
            void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback);
            void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload);
            void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback);
            Facebook.Unity.Profile CurrentProfile();
            void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback);
            void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
            void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
            void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
            void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
            void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
            void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
            void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
            void ScheduleAppToUserNotification(string title, string body, System.Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback);
            void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback);
            void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
            void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
            void ShareTournament(int score, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
            void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
            void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            /*0x14fec84*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            /*0x14fec88*/ void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback);
            /*0x14fec8c*/ void <OnInitComplete>b__35_0(Facebook.Unity.ILoginResult result);

            class <>c
            {
                static /*0x0*/ Facebook.Unity.FacebookBase.<> <>9;
                static /*0x8*/ System.Func<string, bool> <>9__41_0;

                static /*0x2a12430*/ <>c();
                /*0x2a12490*/ <>c();
                /*0x2a12498*/ bool <ValidateAppRequestArgs>b__41_0(string toWhom);
            }
        }

        class InitDelegate : System.MulticastDelegate
        {
            /*0x1501ee8*/ InitDelegate(object object, nint method);
            /*0x14fec9c*/ void Invoke();
            /*0x1501f48*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0x1501f74*/ void EndInvoke(System.IAsyncResult result);
        }

        class FacebookDelegate<T> : System.MulticastDelegate
        {
            FacebookDelegate(object object, nint method);
            void Invoke(T result);
            System.IAsyncResult BeginInvoke(T result, System.AsyncCallback callback, object object);
            void EndInvoke(System.IAsyncResult result);
        }

        class HideUnityDelegate : System.MulticastDelegate
        {
            /*0x14ffb6c*/ HideUnityDelegate(object object, nint method);
            /*0x14ecfb8*/ void Invoke(bool isUnityShown);
            /*0x14ffbcc*/ System.IAsyncResult BeginInvoke(bool isUnityShown, System.AsyncCallback callback, object object);
            /*0x14ffc58*/ void EndInvoke(System.IAsyncResult result);
        }

        class FacebookGameObject : UnityEngine.MonoBehaviour, Facebook.Unity.IFacebookCallbackHandler
        {
            /*0x18*/ Facebook.Unity.IFacebookImplementation <Facebook>k__BackingField;

            /*0x14ee268*/ FacebookGameObject();
            /*0x14feea8*/ Facebook.Unity.IFacebookImplementation get_Facebook();
            /*0x14feeb0*/ void set_Facebook(Facebook.Unity.IFacebookImplementation value);
            /*0x14feeb8*/ void Awake();
            /*0x14fef60*/ void OnInitComplete(string message);
            /*0x14ff044*/ void OnLoginComplete(string message);
            /*0x14ff12c*/ void OnLogoutComplete(string message);
            /*0x14ff214*/ void OnGetAppLinkComplete(string message);
            /*0x14ff2fc*/ void OnAppRequestsComplete(string message);
            /*0x14ff3e4*/ void OnShareLinkComplete(string message);
            /*0x14ff4cc*/ void OnAwake();
        }

        class FacebookSdkVersion
        {
            static /*0x14eafbc*/ string get_Build();
        }

        enum FacebookUnityPlatform
        {
            Unknown = 0,
            Android = 1,
            IOS = 2,
            WebGL = 3,
            Windows = 4,
        }

        interface IFacebook : Facebook.Unity.IFacebookWindows
        {
            bool get_LoggedIn();
            bool get_LimitEventUsage();
            void set_LimitEventUsage(bool value);
            string get_SDKUserAgent();
            bool get_Initialized();
            void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
            void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
            void LogOut();
            void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
            void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
            void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
            void API(string query, Facebook.Unity.HttpMethod method, System.Collections.Generic.IDictionary<string, string> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            void API(string query, Facebook.Unity.HttpMethod method, UnityEngine.WWWForm formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            void ActivateApp(string appId);
            void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
            void AppEventsLogEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
            void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
            void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback);
            void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback);
            void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload);
            void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback);
            Facebook.Unity.Profile CurrentProfile();
            void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback);
            void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
            void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
            void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
            void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
            void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
            void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
            void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
            void ScheduleAppToUserNotification(string title, string body, System.Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback);
            void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback);
            void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
            void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
            void ShareTournament(int score, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
            void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
            void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback);
        }

        interface IFacebookWindows
        {
            void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
        }

        interface IFacebookCallbackHandler
        {
            void OnInitComplete(string message);
            void OnLoginComplete(string message);
            void OnAppRequestsComplete(string message);
            void OnShareLinkComplete(string message);
        }

        interface IFacebookImplementation : Facebook.Unity.IFacebook, Facebook.Unity.IFacebookWindows, Facebook.Unity.IFacebookResultHandler
        {
        }

        interface IFacebookResultHandler
        {
            void OnInitComplete(Facebook.Unity.ResultContainer resultContainer);
            void OnLoginComplete(Facebook.Unity.ResultContainer resultContainer);
            void OnLogoutComplete(Facebook.Unity.ResultContainer resultContainer);
            void OnGetAppLinkComplete(Facebook.Unity.ResultContainer resultContainer);
            void OnAppRequestsComplete(Facebook.Unity.ResultContainer resultContainer);
            void OnShareLinkComplete(Facebook.Unity.ResultContainer resultContainer);
        }

        class MethodArguments
        {
            /*0x10*/ System.Collections.Generic.IDictionary<string, object> arguments;

            static /*0x1502cf4*/ System.Collections.Generic.Dictionary<string, string> ToStringDict(System.Collections.Generic.IDictionary<string, object> dict);
            /*0x14e4094*/ MethodArguments();
            /*0x1502cdc*/ MethodArguments(Facebook.Unity.MethodArguments methodArgs);
            /*0x1502c50*/ MethodArguments(System.Collections.Generic.IDictionary<string, object> arguments);
            void AddPrimative<T>(string argumentName, T value);
            void AddNullablePrimitive<T>(string argumentName, System.Nullable<T> nullable);
            /*0x14e4108*/ void AddString(string argumentName, string value);
            /*0x14e42fc*/ void AddCommaSeparatedList(string argumentName, System.Collections.Generic.IEnumerable<string> value);
            /*0x14e65b4*/ void AddDictionary(string argumentName, System.Collections.Generic.IDictionary<string, object> dict);
            void AddList<T>(string argumentName, System.Collections.Generic.IEnumerable<T> list);
            /*0x14e5fd0*/ void AddUri(string argumentName, System.Uri uri);
            /*0x14eb3d0*/ string ToJsonString();
        }

        class MethodCall<T>
        {
            /*0x0*/ string <MethodName>k__BackingField;
            /*0x0*/ Facebook.Unity.FacebookDelegate<T> <Callback>k__BackingField;
            /*0x0*/ Facebook.Unity.FacebookBase <FacebookImpl>k__BackingField;
            /*0x0*/ Facebook.Unity.MethodArguments <Parameters>k__BackingField;

            MethodCall(Facebook.Unity.FacebookBase facebookImpl, string methodName);
            string get_MethodName();
            void set_MethodName(string value);
            Facebook.Unity.FacebookDelegate<T> get_Callback();
            void set_Callback(Facebook.Unity.FacebookDelegate<T> value);
            void set_FacebookImpl(Facebook.Unity.FacebookBase value);
            void set_Parameters(Facebook.Unity.MethodArguments value);
            void Call(Facebook.Unity.MethodArguments args);
        }

        enum OGActionType
        {
            SEND = 0,
            ASKFOR = 1,
            TURN = 2,
        }

        class CurrencyAmount
        {
            /*0x10*/ string <Amount>k__BackingField;
            /*0x18*/ string <Currency>k__BackingField;

            /*0x14f1c0c*/ CurrencyAmount(string amount, string currency);
            /*0x14f1c44*/ string get_Amount();
            /*0x14f1c4c*/ void set_Amount(string value);
            /*0x14f1c54*/ string get_Currency();
            /*0x14f1c5c*/ void set_Currency(string value);
            /*0x14f1c64*/ string ToString();
        }

        class Product
        {
            /*0x10*/ string <Title>k__BackingField;
            /*0x18*/ string <ProductID>k__BackingField;
            /*0x20*/ string <Description>k__BackingField;
            /*0x28*/ string <ImageURI>k__BackingField;
            /*0x30*/ string <Price>k__BackingField;
            /*0x38*/ System.Nullable<double> <PriceAmount>k__BackingField;
            /*0x48*/ string <PriceCurrencyCode>k__BackingField;

            /*0x1507594*/ Product(string title, string productID, string description, string imageURI, string price, System.Nullable<double> priceAmount, string priceCurrencyCode);
            /*0x1507704*/ string get_Title();
            /*0x150770c*/ void set_Title(string value);
            /*0x1507714*/ string get_ProductID();
            /*0x150771c*/ void set_ProductID(string value);
            /*0x1507724*/ string get_Description();
            /*0x150772c*/ void set_Description(string value);
            /*0x1507734*/ string get_ImageURI();
            /*0x150773c*/ void set_ImageURI(string value);
            /*0x1507744*/ string get_Price();
            /*0x150774c*/ void set_Price(string value);
            /*0x1507754*/ System.Nullable<double> get_PriceAmount();
            /*0x1507760*/ void set_PriceAmount(System.Nullable<double> value);
            /*0x1507768*/ string get_PriceCurrencyCode();
            /*0x1507770*/ void set_PriceCurrencyCode(string value);
            /*0x1507778*/ string ToString();
        }

        class Purchase
        {
            /*0x10*/ string <DeveloperPayload>k__BackingField;
            /*0x18*/ bool <IsConsumed>k__BackingField;
            /*0x20*/ string <PaymentActionType>k__BackingField;
            /*0x28*/ string <PaymentID>k__BackingField;
            /*0x30*/ string <ProductID>k__BackingField;
            /*0x38*/ string <PurchasePlatform>k__BackingField;
            /*0x40*/ Facebook.Unity.CurrencyAmount <PurchasePrice>k__BackingField;
            /*0x48*/ System.DateTime <PurchaseTime>k__BackingField;
            /*0x50*/ string <PurchaseToken>k__BackingField;
            /*0x58*/ string <SignedRequest>k__BackingField;

            /*0x1507e54*/ Purchase(string developerPayload, bool isConsumed, string paymentActionType, string paymentID, string productID, string purchasePlatform, System.Collections.Generic.IDictionary<string, object> purchasePrice, long purchaseTime, string purchaseToken, string signedRequest);
            /*0x1508248*/ string get_DeveloperPayload();
            /*0x1508250*/ void set_DeveloperPayload(string value);
            /*0x1508258*/ bool get_IsConsumed();
            /*0x1508260*/ string get_PaymentActionType();
            /*0x1508268*/ void set_PaymentActionType(string value);
            /*0x1508270*/ string get_PaymentID();
            /*0x1508278*/ void set_PaymentID(string value);
            /*0x1508280*/ string get_ProductID();
            /*0x1508288*/ void set_ProductID(string value);
            /*0x1508290*/ string get_PurchasePlatform();
            /*0x1508298*/ void set_PurchasePlatform(string value);
            /*0x15082a0*/ Facebook.Unity.CurrencyAmount get_PurchasePrice();
            /*0x15082a8*/ void set_PurchasePrice(Facebook.Unity.CurrencyAmount value);
            /*0x15082b0*/ System.DateTime get_PurchaseTime();
            /*0x15082b8*/ void set_PurchaseTime(System.DateTime value);
            /*0x15082c0*/ string get_PurchaseToken();
            /*0x15082c8*/ void set_PurchaseToken(string value);
            /*0x15082d0*/ string get_SignedRequest();
            /*0x15082d8*/ void set_SignedRequest(string value);
            /*0x15082e0*/ string ToString();
        }

        class AccessTokenRefreshResult : Facebook.Unity.ResultBase, Facebook.Unity.IAccessTokenRefreshResult, Facebook.Unity.IResult
        {
            /*0x50*/ Facebook.Unity.AccessToken <AccessToken>k__BackingField;

            /*0x14e33f0*/ AccessTokenRefreshResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x14e3540*/ Facebook.Unity.AccessToken get_AccessToken();
            /*0x14e3548*/ void set_AccessToken(Facebook.Unity.AccessToken value);
            /*0x14e3550*/ string ToString();
        }

        class AppLinkResult : Facebook.Unity.ResultBase, Facebook.Unity.IAppLinkResult, Facebook.Unity.IResult
        {
            /*0x50*/ string <Url>k__BackingField;
            /*0x58*/ string <TargetUrl>k__BackingField;
            /*0x60*/ string <Ref>k__BackingField;
            /*0x68*/ System.Collections.Generic.IDictionary<string, object> <Extras>k__BackingField;

            /*0x14e921c*/ AppLinkResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x14e93b4*/ string get_Url();
            /*0x14e93bc*/ void set_Url(string value);
            /*0x14e93c4*/ string get_TargetUrl();
            /*0x14e93cc*/ void set_TargetUrl(string value);
            /*0x14e93d4*/ string get_Ref();
            /*0x14e93dc*/ void set_Ref(string value);
            /*0x14e93e4*/ System.Collections.Generic.IDictionary<string, object> get_Extras();
            /*0x14e93ec*/ void set_Extras(System.Collections.Generic.IDictionary<string, object> value);
            /*0x14e93f4*/ string ToString();
        }

        class AppRequestResult : Facebook.Unity.ResultBase, Facebook.Unity.IAppRequestResult, Facebook.Unity.IResult
        {
            /*0x50*/ string <RequestID>k__BackingField;
            /*0x58*/ System.Collections.Generic.IEnumerable<string> <To>k__BackingField;

            /*0x14e9578*/ AppRequestResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x14e9a18*/ string get_RequestID();
            /*0x14e9a20*/ void set_RequestID(string value);
            /*0x14e9a28*/ System.Collections.Generic.IEnumerable<string> get_To();
            /*0x14e9a30*/ void set_To(System.Collections.Generic.IEnumerable<string> value);
            /*0x14e9a38*/ string ToString();
        }

        class CatalogResult : Facebook.Unity.ResultBase, Facebook.Unity.ICatalogResult, Facebook.Unity.IResult
        {
            /*0x50*/ System.Collections.Generic.IList<Facebook.Unity.Product> <Products>k__BackingField;

            /*0x14ee304*/ CatalogResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x14ee5c0*/ System.Collections.Generic.IList<Facebook.Unity.Product> get_Products();
            /*0x14ee5c8*/ void set_Products(System.Collections.Generic.IList<Facebook.Unity.Product> value);
            /*0x14ee5d0*/ string ToString();
        }

        interface IFriendFinderInvitationResult : Facebook.Unity.IResult
        {
        }

        interface ILocaleResult : Facebook.Unity.IResult
        {
        }

        interface IProfileResult : Facebook.Unity.IResult
        {
        }

        class ConsumePurchaseResult : Facebook.Unity.ResultBase, Facebook.Unity.IConsumePurchaseResult, Facebook.Unity.IResult
        {
            /*0x14f1a4c*/ ConsumePurchaseResult(Facebook.Unity.ResultContainer resultContainer);
        }

        class GamingServicesFriendFinderResult : Facebook.Unity.ResultBase, Facebook.Unity.IGamingServicesFriendFinderResult, Facebook.Unity.IResult
        {
            /*0x14f313c*/ GamingServicesFriendFinderResult(Facebook.Unity.ResultContainer resultContainer);
        }

        class GraphResult : Facebook.Unity.ResultBase, Facebook.Unity.IGraphResult, Facebook.Unity.IResult
        {
            /*0x50*/ System.Collections.Generic.IList<object> <ResultList>k__BackingField;
            /*0x58*/ UnityEngine.Texture2D <Texture>k__BackingField;

            /*0x14ff87c*/ GraphResult(UnityEngine.Networking.UnityWebRequestAsyncOperation result);
            /*0x14ffb54*/ void set_ResultList(System.Collections.Generic.IList<object> value);
            /*0x14ffb5c*/ UnityEngine.Texture2D get_Texture();
            /*0x14ffb64*/ void set_Texture(UnityEngine.Texture2D value);
            /*0x14ffa38*/ void Init(string rawResult);
        }

        interface IAccessTokenRefreshResult : Facebook.Unity.IResult
        {
        }

        interface IAppLinkResult : Facebook.Unity.IResult
        {
        }

        class IAPReadyResult : Facebook.Unity.ResultBase, Facebook.Unity.IIAPReadyResult, Facebook.Unity.IResult
        {
            /*0x14f3388*/ IAPReadyResult(Facebook.Unity.ResultContainer resultContainer);
        }

        interface IAppRequestResult : Facebook.Unity.IResult
        {
        }

        interface ICatalogResult : Facebook.Unity.IResult
        {
        }

        interface IConsumePurchaseResult : Facebook.Unity.IResult
        {
        }

        interface IGamingServicesFriendFinderResult : Facebook.Unity.IResult
        {
        }

        interface IGraphResult : Facebook.Unity.IResult
        {
        }

        interface IGroupCreateResult : Facebook.Unity.IResult
        {
        }

        interface IGroupJoinResult : Facebook.Unity.IResult
        {
        }

        class InitCloudGameResult : Facebook.Unity.ResultBase, Facebook.Unity.IInitCloudGameResult, Facebook.Unity.IResult
        {
            /*0x14f3c4c*/ InitCloudGameResult(Facebook.Unity.ResultContainer resultContainer);
        }

        class GameLoadCompleteResult : Facebook.Unity.ResultBase, Facebook.Unity.IGameLoadCompleteResult, Facebook.Unity.IResult
        {
            /*0x14f3cc4*/ GameLoadCompleteResult(Facebook.Unity.ResultContainer resultContainer);
        }

        class InterstitialAdResult : Facebook.Unity.ResultBase, Facebook.Unity.IInterstitialAdResult, Facebook.Unity.IResult
        {
            /*0x14f3db4*/ InterstitialAdResult(Facebook.Unity.ResultContainer resultContainer);
        }

        interface IIAPReadyResult : Facebook.Unity.IResult
        {
        }

        interface IInitCloudGameResult : Facebook.Unity.IResult
        {
        }

        interface IGameLoadCompleteResult : Facebook.Unity.IResult
        {
        }

        interface IInternalResult : Facebook.Unity.IResult
        {
            string get_CallbackId();
        }

        interface IInterstitialAdResult : Facebook.Unity.IResult
        {
        }

        interface ILoginResult : Facebook.Unity.IResult
        {
            Facebook.Unity.AccessToken get_AccessToken();
        }

        interface ILoginStatusResult : Facebook.Unity.ILoginResult, Facebook.Unity.IResult
        {
        }

        interface IOpenAppStoreResult : Facebook.Unity.IResult
        {
        }

        interface IPayloadResult : Facebook.Unity.IResult
        {
        }

        interface IPayResult : Facebook.Unity.IResult
        {
        }

        interface IPurchaseResult : Facebook.Unity.IResult
        {
        }

        interface IPurchasesResult : Facebook.Unity.IResult
        {
        }

        interface IResult
        {
            string get_Error();
            System.Collections.Generic.IDictionary<string, object> get_ResultDictionary();
            bool get_Cancelled();
        }

        interface IRewardedVideoResult : Facebook.Unity.IResult
        {
        }

        interface IScheduleAppToUserNotificationResult : Facebook.Unity.IResult
        {
        }

        interface IShareResult : Facebook.Unity.IResult
        {
        }

        interface ISoftKeyboardOpenResult : Facebook.Unity.IResult
        {
        }

        interface IVirtualGamepadLayoutResult : Facebook.Unity.IResult
        {
        }

        class LoginResult : Facebook.Unity.ResultBase, Facebook.Unity.ILoginResult, Facebook.Unity.IResult
        {
            static /*0x0*/ string UserIdKey;
            static /*0x8*/ string ExpirationTimestampKey;
            static /*0x10*/ string PermissionsKey;
            static /*0x18*/ string AccessTokenKey;
            static /*0x20*/ string GraphDomain;
            static /*0x28*/ string AuthTokenString;
            static /*0x30*/ string AuthNonce;
            /*0x50*/ Facebook.Unity.AccessToken <AccessToken>k__BackingField;
            /*0x58*/ Facebook.Unity.AuthenticationToken <AuthenticationToken>k__BackingField;

            static /*0x1502804*/ LoginResult();
            /*0x14ed954*/ LoginResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x15026a4*/ Facebook.Unity.AccessToken get_AccessToken();
            /*0x15026ac*/ void set_AccessToken(Facebook.Unity.AccessToken value);
            /*0x15026b4*/ Facebook.Unity.AuthenticationToken get_AuthenticationToken();
            /*0x15026bc*/ void set_AuthenticationToken(Facebook.Unity.AuthenticationToken value);
            /*0x15026c4*/ string ToString();
        }

        class LoginStatusResult : Facebook.Unity.LoginResult, Facebook.Unity.ILoginStatusResult, Facebook.Unity.ILoginResult, Facebook.Unity.IResult
        {
            static /*0x0*/ string FailedKey;
            /*0x60*/ bool <Failed>k__BackingField;

            static /*0x1502ae4*/ LoginStatusResult();
            /*0x14e56f4*/ LoginStatusResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x15029b4*/ bool get_Failed();
            /*0x15029bc*/ void set_Failed(bool value);
            /*0x15029c8*/ string ToString();
        }

        class OpenAppStoreResult : Facebook.Unity.ResultBase, Facebook.Unity.IOpenAppStoreResult, Facebook.Unity.IResult
        {
            /*0x14f4b50*/ OpenAppStoreResult(Facebook.Unity.ResultContainer resultContainer);
        }

        class PayloadResult : Facebook.Unity.ResultBase, Facebook.Unity.IPayloadResult, Facebook.Unity.IResult
        {
            /*0x50*/ System.Collections.Generic.IDictionary<string, string> <Payload>k__BackingField;

            /*0x14f40dc*/ PayloadResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x150753c*/ System.Collections.Generic.IDictionary<string, string> get_Payload();
            /*0x1507544*/ void set_Payload(System.Collections.Generic.IDictionary<string, string> value);
            /*0x150754c*/ string ToString();
        }

        class PayResult : Facebook.Unity.ResultBase, Facebook.Unity.IPayResult, Facebook.Unity.IResult
        {
            /*0x14ecdf8*/ PayResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x15073c0*/ long get_ErrorCode();
            /*0x1507400*/ string ToString();
        }

        class PurchaseResult : Facebook.Unity.ResultBase, Facebook.Unity.IPurchaseResult, Facebook.Unity.IResult
        {
            /*0x50*/ Facebook.Unity.Purchase <Purchase>k__BackingField;

            /*0x14f37a4*/ PurchaseResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x15085b0*/ Facebook.Unity.Purchase get_Purchase();
            /*0x15085b8*/ void set_Purchase(Facebook.Unity.Purchase value);
            /*0x15085c0*/ string ToString();
        }

        class PurchasesResult : Facebook.Unity.ResultBase, Facebook.Unity.IPurchasesResult, Facebook.Unity.IResult
        {
            /*0x50*/ System.Collections.Generic.IList<Facebook.Unity.Purchase> <Purchases>k__BackingField;

            /*0x14f3474*/ PurchasesResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x15086c0*/ System.Collections.Generic.IList<Facebook.Unity.Purchase> get_Purchases();
            /*0x15086c8*/ void set_Purchases(System.Collections.Generic.IList<Facebook.Unity.Purchase> value);
            /*0x15086d0*/ string ToString();
        }

        class ResultBase : Facebook.Unity.IInternalResult, Facebook.Unity.IResult
        {
            /*0x10*/ string <Error>k__BackingField;
            /*0x18*/ System.Collections.Generic.IDictionary<string, string> <ErrorDictionary>k__BackingField;
            /*0x20*/ System.Collections.Generic.IDictionary<string, object> <ResultDictionary>k__BackingField;
            /*0x28*/ string <RawResult>k__BackingField;
            /*0x30*/ bool <Cancelled>k__BackingField;
            /*0x38*/ string <CallbackId>k__BackingField;
            /*0x40*/ System.Nullable<long> <CanvasErrorCode>k__BackingField;

            static /*0x1508aa0*/ string GetErrorValue(System.Collections.Generic.IDictionary<string, object> result);
            static /*0x1508b30*/ bool GetCancelledValue(System.Collections.Generic.IDictionary<string, object> result);
            static /*0x1508dd0*/ string GetCallbackId(System.Collections.Generic.IDictionary<string, object> result);
            /*0x14e2c1c*/ ResultBase(Facebook.Unity.ResultContainer result);
            /*0x14ff9ec*/ ResultBase(Facebook.Unity.ResultContainer result, string error, bool cancelled);
            /*0x1509070*/ string get_Error();
            /*0x1509078*/ void set_Error(string value);
            /*0x1509080*/ System.Collections.Generic.IDictionary<string, string> get_ErrorDictionary();
            /*0x1509088*/ void set_ErrorDictionary(System.Collections.Generic.IDictionary<string, string> value);
            /*0x1509090*/ System.Collections.Generic.IDictionary<string, object> get_ResultDictionary();
            /*0x1509098*/ void set_ResultDictionary(System.Collections.Generic.IDictionary<string, object> value);
            /*0x15090a0*/ string get_RawResult();
            /*0x15090a8*/ void set_RawResult(string value);
            /*0x15090b0*/ bool get_Cancelled();
            /*0x15090b8*/ void set_Cancelled(bool value);
            /*0x15090c4*/ string get_CallbackId();
            /*0x15090cc*/ void set_CallbackId(string value);
            /*0x15090d4*/ System.Nullable<long> get_CanvasErrorCode();
            /*0x15090e0*/ void set_CanvasErrorCode(System.Nullable<long> value);
            /*0x14e3654*/ string ToString();
            /*0x1508e60*/ void Init(Facebook.Unity.ResultContainer result, string error, bool cancelled, string callbackId);
        }

        class ResultContainer
        {
            static string CanvasResponseKey = "response";
            /*0x10*/ string <RawResult>k__BackingField;
            /*0x18*/ System.Collections.Generic.IDictionary<string, object> <ResultDictionary>k__BackingField;

            /*0x14ec0ec*/ ResultContainer(System.Collections.Generic.IDictionary<string, object> dictionary);
            /*0x14e9038*/ ResultContainer(string result);
            /*0x1509294*/ string get_RawResult();
            /*0x150929c*/ void set_RawResult(string value);
            /*0x15092a4*/ System.Collections.Generic.IDictionary<string, object> get_ResultDictionary();
            /*0x15092ac*/ void set_ResultDictionary(System.Collections.Generic.IDictionary<string, object> value);
            /*0x15090e8*/ System.Collections.Generic.IDictionary<string, object> GetWebFormattedResponseDictionary(System.Collections.Generic.IDictionary<string, object> resultDictionary);
        }

        class RewardedVideoResult : Facebook.Unity.ResultBase, Facebook.Unity.IRewardedVideoResult, Facebook.Unity.IResult
        {
            /*0x2a09910*/ RewardedVideoResult(Facebook.Unity.ResultContainer resultContainer);
        }

        class ScheduleAppToUserNotificationResult : Facebook.Unity.ResultBase, Facebook.Unity.IScheduleAppToUserNotificationResult, Facebook.Unity.IResult
        {
            /*0x2a09a64*/ ScheduleAppToUserNotificationResult(Facebook.Unity.ResultContainer resultContainer);
        }

        class ShareResult : Facebook.Unity.ResultBase, Facebook.Unity.IShareResult, Facebook.Unity.IResult
        {
            /*0x50*/ string <PostId>k__BackingField;

            static /*0x2a09b5c*/ string get_PostIDKey();
            /*0x2a09a74*/ ShareResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x2a09bc4*/ string get_PostId();
            /*0x2a09bcc*/ void set_PostId(string value);
            /*0x2a09bd4*/ string ToString();
        }

        class AsyncRequestString : UnityEngine.MonoBehaviour
        {
            /*0x18*/ System.Uri url;
            /*0x20*/ Facebook.Unity.HttpMethod method;
            /*0x28*/ System.Collections.Generic.IDictionary<string, string> formData;
            /*0x30*/ UnityEngine.WWWForm query;
            /*0x38*/ Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback;

            static /*0x14e9b7c*/ void Post(System.Uri url, System.Collections.Generic.Dictionary<string, string> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            static /*0x14e9c0c*/ void Get(System.Uri url, System.Collections.Generic.Dictionary<string, string> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            static /*0x14e9c1c*/ void Request(System.Uri url, Facebook.Unity.HttpMethod method, UnityEngine.WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            static /*0x14e9b8c*/ void Request(System.Uri url, Facebook.Unity.HttpMethod method, System.Collections.Generic.IDictionary<string, string> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            /*0x14e9d2c*/ AsyncRequestString();
            /*0x14e9cc0*/ System.Collections.IEnumerator Start();
            /*0x14e9c98*/ Facebook.Unity.AsyncRequestString SetUrl(System.Uri url);
            /*0x14e9ca0*/ Facebook.Unity.AsyncRequestString SetMethod(Facebook.Unity.HttpMethod method);
            /*0x14e9cb8*/ Facebook.Unity.AsyncRequestString SetFormData(System.Collections.Generic.IDictionary<string, string> formData);
            /*0x14e9ca8*/ Facebook.Unity.AsyncRequestString SetQuery(UnityEngine.WWWForm query);
            /*0x14e9cb0*/ Facebook.Unity.AsyncRequestString SetCallback(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);

            class <Start>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ Facebook.Unity.AsyncRequestString <>4__this;
                /*0x28*/ UnityEngine.Networking.UnityWebRequestAsyncOperation <webRequestOperation>5__2;

                /*0x2a10434*/ <Start>d__9(int <>1__state);
                /*0x2a10460*/ void System.IDisposable.Dispose();
                /*0x2a10464*/ bool MoveNext();
                /*0x2a10d1c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x2a10d24*/ void System.Collections.IEnumerator.Reset();
                /*0x2a10d64*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class FacebookLogger
        {
            static /*0x0*/ Facebook.Unity.IFacebookLogger <Instance>k__BackingField;

            static /*0x14ff4d0*/ FacebookLogger();
            static /*0x14ff570*/ Facebook.Unity.IFacebookLogger get_Instance();
            static /*0x14ff5d4*/ void set_Instance(Facebook.Unity.IFacebookLogger value);
            static /*0x14f00a8*/ void Log(string msg);
            static /*0x14fa05c*/ void Info(string msg);
            static /*0x14eae44*/ void Warn(string msg);
            static /*0x14ff63c*/ void Warn(string format, string[] args);

            class DebugLogger : Facebook.Unity.IFacebookLogger
            {
                /*0x2a124a4*/ DebugLogger();
                /*0x2a124ac*/ void Log(string msg);
                /*0x2a12540*/ void Info(string msg);
                /*0x2a125a4*/ void Warn(string msg);
            }
        }

        enum HttpMethod
        {
            GET = 0,
            POST = 1,
            DELETE = 2,
        }

        interface IFacebookLogger
        {
            void Log(string msg);
            void Info(string msg);
            void Warn(string msg);
        }

        class Utilities
        {
            static bool TryGetValue<T>(System.Collections.Generic.IDictionary<string, object> dictionary, string key, ref T value);
            static /*0x2a0acb4*/ long TotalSeconds(System.DateTime dateTime);
            static T GetValueOrDefault<T>(System.Collections.Generic.IDictionary<string, object> dictionary, string key, bool logWarning);
            static /*0x2a0ad7c*/ string ToCommaSeparateList(System.Collections.Generic.IEnumerable<string> list);
            static /*0x2a0ae20*/ string AbsoluteUrlOrEmptyString(System.Uri uri);
            static /*0x2a0aecc*/ string GetUserAgent(string productName, string productVersion);
            static /*0x2a0aff8*/ string ToJson(System.Collections.Generic.IDictionary<string, object> dictionary);
            static /*0x2a0b05c*/ Facebook.Unity.AccessToken ParseAccessTokenFromResult(System.Collections.Generic.IDictionary<string, object> resultDictionary);
            static /*0x2a0b768*/ Facebook.Unity.AuthenticationToken ParseAuthenticationTokenFromResult(System.Collections.Generic.IDictionary<string, object> resultDictionary);
            static /*0x2a0b858*/ string ToStringNullOk(object obj);
            static /*0x2a09ccc*/ string FormatToString(string baseString, string className, System.Collections.Generic.IDictionary<string, string> propertiesAndValues);
            static /*0x2a0b1c4*/ System.DateTime ParseExpirationDateFromResult(System.Collections.Generic.IDictionary<string, object> resultDictionary);
            static /*0x2a0b698*/ System.Nullable<System.DateTime> ParseLastRefreshFromResult(System.Collections.Generic.IDictionary<string, object> resultDictionary);
            static /*0x2a0b35c*/ System.Collections.Generic.ICollection<string> ParsePermissionFromResult(System.Collections.Generic.IDictionary<string, object> resultDictionary);
            static /*0x2a0b920*/ System.Collections.Generic.IList<Facebook.Unity.Product> ParseCatalogFromResult(System.Collections.Generic.IDictionary<string, object> resultDictionary);
            static /*0x2a0be50*/ Facebook.Unity.Product ParseProductFromCatalogResult(System.Collections.Generic.IDictionary<string, object> product, bool isWindows);
            static /*0x2a0c520*/ System.Collections.Generic.IList<Facebook.Unity.Purchase> ParsePurchasesFromResult(System.Collections.Generic.IDictionary<string, object> resultDictionary);
            static /*0x2a0d3fc*/ Facebook.Unity.Purchase ParsePurchaseFromResult(System.Collections.Generic.IDictionary<string, object> resultDictionary);
            static /*0x2a0c914*/ Facebook.Unity.Purchase ParsePurchaseFromDictionary(System.Collections.Generic.IDictionary<string, object> purchase, bool isWindows);
            static /*0x2a0d57c*/ System.Collections.Generic.IDictionary<string, string> ParseStringDictionaryFromString(string input);
            static /*0x2a0d864*/ System.Collections.Generic.IDictionary<string, string> ParseInnerStringDictionary(System.Collections.Generic.IDictionary<string, object> resultDictionary, string key);
            static /*0x2a0b8bc*/ System.DateTime FromTimestamp(int timestamp);

            class Callback<T> : System.MulticastDelegate
            {
                Callback(object object, nint method);
                void Invoke(T obj);
                System.IAsyncResult BeginInvoke(T obj, System.AsyncCallback callback, object object);
                void EndInvoke(System.IAsyncResult result);
            }

            class <>c
            {
                static /*0x0*/ Facebook.Unity.Utilities.<> <>9;
                static /*0x8*/ System.Func<object, string> <>9__19_0;

                static /*0x2a15044*/ <>c();
                /*0x2a150a4*/ <>c();
                /*0x2a150ac*/ string <ParsePermissionFromResult>b__19_0(object permission);
            }
        }

        class FBUnityUtility
        {
            static /*0x0*/ Facebook.Unity.IAsyncRequestStringWrapper asyncRequestStringWrapper;

            static /*0x14fdf50*/ Facebook.Unity.IAsyncRequestStringWrapper get_AsyncRequestStringWrapper();
        }

        class AsyncRequestStringWrapper : Facebook.Unity.IAsyncRequestStringWrapper
        {
            /*0x14e9d5c*/ AsyncRequestStringWrapper();
            /*0x14e9d34*/ void Request(System.Uri url, Facebook.Unity.HttpMethod method, UnityEngine.WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            /*0x14e9d48*/ void Request(System.Uri url, Facebook.Unity.HttpMethod method, System.Collections.Generic.IDictionary<string, string> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
        }

        interface IAsyncRequestStringWrapper
        {
            void Request(System.Uri url, Facebook.Unity.HttpMethod method, UnityEngine.WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            void Request(System.Uri url, Facebook.Unity.HttpMethod method, System.Collections.Generic.IDictionary<string, string> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
        }

        class FacebookScheduler : UnityEngine.MonoBehaviour
        {
            /*0x14ff764*/ FacebookScheduler();
            /*0x14ff6c0*/ void Schedule(System.Action action, long delay);
            /*0x14ff6ec*/ System.Collections.IEnumerator DelayEvent(System.Action action, long delay);

            class <DelayEvent>d__1 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ long delay;
                /*0x28*/ System.Action action;

                /*0x2a12608*/ <DelayEvent>d__1(int <>1__state);
                /*0x2a12634*/ void System.IDisposable.Dispose();
                /*0x2a12638*/ bool MoveNext();
                /*0x2a126e8*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x2a126f0*/ void System.Collections.IEnumerator.Reset();
                /*0x2a12730*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        interface IHasLicenseResult : Facebook.Unity.IResult
        {
        }

        class CodelessIAPAutoLog
        {
            static /*0x14e8b64*/ void handlePurchaseCompleted(object data);
            static /*0x14e8924*/ void addListenerToIAPButtons(object listenerObject);
            static /*0x14f0260*/ void addListenerToGameObject(UnityEngine.Object gameObject, object listenerObject);
            static /*0x14f0614*/ System.Type FindTypeInAssemblies(string typeName, string nameSpace);
            static /*0x14f01cc*/ UnityEngine.Object[] FindObjectsOfTypeByName(string typeName, string nameSpace);
            static /*0x14f0768*/ object GetField(object inObj, string fieldName);
            static /*0x14eff48*/ object GetProperty(object inObj, string propertyName);
        }

        class CodelessCrawler : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ bool isGeneratingSnapshot;
            static /*0x8*/ UnityEngine.Camera mainCamera;

            static /*0x14eed94*/ void SendAndroid(string json);
            static /*0x14eef84*/ void SendIos(string json);
            static /*0x14eef88*/ string GenBase64Screenshot();
            static /*0x14ef104*/ string GenViewJson();
            static /*0x14ef4e4*/ void GenChild(UnityEngine.GameObject curObj, System.Text.StringBuilder builder);
            static /*0x14eece4*/ void updateMainCamera();
            static /*0x14efd5c*/ UnityEngine.Vector2 getScreenCoordinate(UnityEngine.Vector3 position, UnityEngine.RenderMode renderMode);
            static /*0x14efe44*/ string getClasstypeBitmaskButton();
            static /*0x14efec4*/ string getVisibility(UnityEngine.GameObject gameObj);
            /*0x14eff40*/ CodelessCrawler();
            /*0x14eeb5c*/ void Awake();
            /*0x14eec18*/ void CaptureViewHierarchy(string message);
            /*0x14eed38*/ System.Collections.IEnumerator GenSnapshot();
            /*0x14eff3c*/ void onActiveSceneChanged(UnityEngine.SceneManagement.Scene arg0, UnityEngine.SceneManagement.Scene arg1);

            class <GenSnapshot>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;

                /*0x2a11690*/ <GenSnapshot>d__4(int <>1__state);
                /*0x2a116bc*/ void System.IDisposable.Dispose();
                /*0x2a116c0*/ bool MoveNext();
                /*0x2a118e0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x2a118e8*/ void System.Collections.IEnumerator.Reset();
                /*0x2a11928*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class CodelessUIInteractEvent : UnityEngine.MonoBehaviour
        {
            /*0x18*/ Facebook.Unity.FBSDKEventBindingManager <eventBindingManager>k__BackingField;
            /*0x20*/ bool <isOldEventSystem>k__BackingField;

            static /*0x14f0918*/ void SetLoggerInitAndroid();
            static /*0x14f0a4c*/ void SetLoggerInitIos();
            /*0x14f1278*/ CodelessUIInteractEvent();
            /*0x14f07c8*/ Facebook.Unity.FBSDKEventBindingManager get_eventBindingManager();
            /*0x14f07d0*/ void set_eventBindingManager(Facebook.Unity.FBSDKEventBindingManager value);
            /*0x14f07d8*/ bool get_isOldEventSystem();
            /*0x14f07e0*/ void set_isOldEventSystem(bool value);
            /*0x14f07ec*/ void Awake();
            /*0x14f0a50*/ void Update();
            /*0x14f0f48*/ void OnReceiveMapping(string message);
        }

        class FBSDKViewHiearchy
        {
            static /*0x14f0f20*/ bool CheckGameObjectMatchPath(UnityEngine.GameObject go, System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> path);
            static /*0x14fd8f4*/ bool CheckPathMatchPath(System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> goPath, System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> path);
            static /*0x14fd8ec*/ System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> GetPath(UnityEngine.GameObject go);
            static /*0x14fda30*/ System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> GetPath(UnityEngine.GameObject go, int limit);
            static /*0x14fdcb4*/ UnityEngine.GameObject GetParent(UnityEngine.GameObject go);
            static /*0x14fdd68*/ System.Collections.Generic.Dictionary<string, object> GetAttribute(UnityEngine.GameObject obj, UnityEngine.GameObject parent);
        }

        class FBSDKCodelessPathComponent
        {
            /*0x10*/ string <className>k__BackingField;
            /*0x18*/ string <text>k__BackingField;
            /*0x20*/ string <hint>k__BackingField;
            /*0x28*/ string <desc>k__BackingField;
            /*0x30*/ string <tag>k__BackingField;
            /*0x38*/ long <index>k__BackingField;
            /*0x40*/ long <section>k__BackingField;
            /*0x48*/ long <row>k__BackingField;
            /*0x50*/ long <matchBitmask>k__BackingField;

            /*0x14fd0e0*/ FBSDKCodelessPathComponent(System.Collections.Generic.Dictionary<string, object> dict);
            /*0x14fd4a0*/ string get_className();
            /*0x14fd4a8*/ void set_className(string value);
            /*0x14fd4b0*/ void set_text(string value);
            /*0x14fd4b8*/ void set_hint(string value);
            /*0x14fd4c0*/ void set_desc(string value);
            /*0x14fd4c8*/ void set_tag(string value);
            /*0x14fd4d0*/ void set_index(long value);
            /*0x14fd4d8*/ void set_section(long value);
            /*0x14fd4e0*/ void set_row(long value);
            /*0x14fd4e8*/ void set_matchBitmask(long value);
        }

        class FBSDKEventBinding
        {
            /*0x10*/ string <eventName>k__BackingField;
            /*0x18*/ string <eventType>k__BackingField;
            /*0x20*/ string <appVersion>k__BackingField;
            /*0x28*/ string <pathType>k__BackingField;
            /*0x30*/ System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> <path>k__BackingField;
            /*0x38*/ System.Collections.Generic.List<string> <parameters>k__BackingField;

            /*0x14fd4f0*/ FBSDKEventBinding(System.Collections.Generic.Dictionary<string, object> dict);
            /*0x14fd89c*/ string get_eventName();
            /*0x14fd8a4*/ void set_eventName(string value);
            /*0x14fd8ac*/ string get_eventType();
            /*0x14fd8b4*/ void set_eventType(string value);
            /*0x14fd8bc*/ string get_appVersion();
            /*0x14fd8c4*/ void set_appVersion(string value);
            /*0x14fd8cc*/ System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> get_path();
            /*0x14fd8d4*/ void set_path(System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> value);
        }

        class FBSDKEventBindingManager
        {
            /*0x10*/ System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> <eventBindings>k__BackingField;

            /*0x14f1050*/ FBSDKEventBindingManager(System.Collections.Generic.List<object> listDict);
            /*0x14fd8dc*/ System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> get_eventBindings();
            /*0x14fd8e4*/ void set_eventBindings(System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> value);
        }

        interface IMediaUploadResult : Facebook.Unity.IResult
        {
        }

        class MediaUploadResult : Facebook.Unity.ResultBase, Facebook.Unity.IMediaUploadResult, Facebook.Unity.IResult
        {
            /*0x50*/ string <MediaId>k__BackingField;

            /*0x14f31b4*/ MediaUploadResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x1502b48*/ string get_MediaId();
            /*0x1502b50*/ void set_MediaId(string value);
            /*0x1502b58*/ string ToString();
        }

        interface ISessionScoreResult : Facebook.Unity.IResult
        {
        }

        class SessionScoreResult : Facebook.Unity.ResultBase, Facebook.Unity.ISessionScoreResult, Facebook.Unity.IResult
        {
            /*0x2a09a6c*/ SessionScoreResult(Facebook.Unity.ResultContainer resultContainer);
        }

        class AuthenticationToken
        {
            /*0x10*/ string <TokenString>k__BackingField;
            /*0x18*/ string <Nonce>k__BackingField;

            /*0x14e494c*/ AuthenticationToken(string tokenString, string nonce);
            /*0x14e9d64*/ string get_TokenString();
            /*0x14e9d6c*/ void set_TokenString(string value);
            /*0x14e9d74*/ string get_Nonce();
            /*0x14e9d7c*/ void set_Nonce(string value);
            /*0x14e9d84*/ string ToString();
        }

        class Profile
        {
            /*0x10*/ string <UserID>k__BackingField;
            /*0x18*/ string <FirstName>k__BackingField;
            /*0x20*/ string <MiddleName>k__BackingField;
            /*0x28*/ string <LastName>k__BackingField;
            /*0x30*/ string <Name>k__BackingField;
            /*0x38*/ string <Email>k__BackingField;
            /*0x40*/ string <ImageURL>k__BackingField;
            /*0x48*/ string <LinkURL>k__BackingField;
            /*0x50*/ string[] <FriendIDs>k__BackingField;
            /*0x58*/ System.Nullable<System.DateTime> <Birthday>k__BackingField;
            /*0x68*/ Facebook.Unity.UserAgeRange <AgeRange>k__BackingField;
            /*0x70*/ Facebook.Unity.FBLocation <Hometown>k__BackingField;
            /*0x78*/ Facebook.Unity.FBLocation <Location>k__BackingField;
            /*0x80*/ string <Gender>k__BackingField;

            /*0x14e54f0*/ Profile(string userID, string firstName, string middleName, string lastName, string name, string email, string imageURL, string linkURL, string[] friendIDs, string birthday, Facebook.Unity.UserAgeRange ageRange, Facebook.Unity.FBLocation hometown, Facebook.Unity.FBLocation location, string gender);
            /*0x15079a8*/ string get_UserID();
            /*0x15079b0*/ void set_UserID(string value);
            /*0x15079b8*/ string get_FirstName();
            /*0x15079c0*/ void set_FirstName(string value);
            /*0x15079c8*/ string get_MiddleName();
            /*0x15079d0*/ void set_MiddleName(string value);
            /*0x15079d8*/ string get_LastName();
            /*0x15079e0*/ void set_LastName(string value);
            /*0x15079e8*/ string get_Name();
            /*0x15079f0*/ void set_Name(string value);
            /*0x15079f8*/ string get_Email();
            /*0x1507a00*/ void set_Email(string value);
            /*0x1507a08*/ string get_ImageURL();
            /*0x1507a10*/ void set_ImageURL(string value);
            /*0x1507a18*/ string get_LinkURL();
            /*0x1507a20*/ void set_LinkURL(string value);
            /*0x1507a28*/ string[] get_FriendIDs();
            /*0x1507a30*/ void set_FriendIDs(string[] value);
            /*0x1507a38*/ System.Nullable<System.DateTime> get_Birthday();
            /*0x1507a44*/ void set_Birthday(System.Nullable<System.DateTime> value);
            /*0x1507a4c*/ Facebook.Unity.UserAgeRange get_AgeRange();
            /*0x1507a54*/ void set_AgeRange(Facebook.Unity.UserAgeRange value);
            /*0x1507a5c*/ Facebook.Unity.FBLocation get_Hometown();
            /*0x1507a64*/ void set_Hometown(Facebook.Unity.FBLocation value);
            /*0x1507a6c*/ Facebook.Unity.FBLocation get_Location();
            /*0x1507a74*/ void set_Location(Facebook.Unity.FBLocation value);
            /*0x1507a7c*/ string get_Gender();
            /*0x1507a84*/ void set_Gender(string value);
            /*0x1507a8c*/ string ToString();
        }

        class UserAgeRange
        {
            /*0x10*/ long <Min>k__BackingField;
            /*0x18*/ long <Max>k__BackingField;

            static /*0x2a0a97c*/ Facebook.Unity.UserAgeRange AgeRangeFromDictionary(System.Collections.Generic.IDictionary<string, string> dictionary);
            /*0x2a0a924*/ UserAgeRange(long min, long max);
            /*0x2a0a95c*/ long get_Min();
            /*0x2a0a964*/ void set_Min(long value);
            /*0x2a0a96c*/ long get_Max();
            /*0x2a0a974*/ void set_Max(long value);
            /*0x2a0ab6c*/ string ToString();
        }

        class FBLocation
        {
            /*0x10*/ string <ID>k__BackingField;
            /*0x18*/ string <Name>k__BackingField;

            static /*0x14e531c*/ Facebook.Unity.FBLocation FromDictionary(string prefix, System.Collections.Generic.IDictionary<string, string> dictionary);
            /*0x14fcf74*/ FBLocation(string id, string name);
            /*0x14fcfac*/ string get_ID();
            /*0x14fcfb4*/ void set_ID(string value);
            /*0x14fcfbc*/ string get_Name();
            /*0x14fcfc4*/ void set_Name(string value);
            /*0x14fcfcc*/ string ToString();
        }

        interface ITournamentResult : Facebook.Unity.IResult
        {
        }

        class TournamentResult : Facebook.Unity.ResultBase, Facebook.Unity.ITournamentResult, Facebook.Unity.IResult, Facebook.Unity.IDialogResult
        {
            /*0x50*/ string <TournamentId>k__BackingField;
            /*0x58*/ string <ContextId>k__BackingField;
            /*0x60*/ int <EndTime>k__BackingField;
            /*0x68*/ string <TournamentTitle>k__BackingField;
            /*0x70*/ System.Collections.Generic.IDictionary<string, string> <Payload>k__BackingField;

            /*0x2a0a224*/ TournamentResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x2a0a418*/ string get_TournamentId();
            /*0x2a0a420*/ void set_TournamentId(string value);
            /*0x2a0a428*/ string get_ContextId();
            /*0x2a0a430*/ void set_ContextId(string value);
            /*0x2a0a438*/ int get_EndTime();
            /*0x2a0a440*/ void set_EndTime(int value);
            /*0x2a0a448*/ string get_TournamentTitle();
            /*0x2a0a450*/ void set_TournamentTitle(string value);
            /*0x2a0a458*/ System.Collections.Generic.IDictionary<string, string> get_Payload();
            /*0x2a0a460*/ void set_Payload(System.Collections.Generic.IDictionary<string, string> value);
            /*0x2a0a468*/ string ToString();
        }

        interface IGetTournamentsResult : Facebook.Unity.IResult
        {
        }

        class GetTournamentsResult : Facebook.Unity.ResultBase, Facebook.Unity.IGetTournamentsResult, Facebook.Unity.IResult
        {
            /*0x50*/ Facebook.Unity.TournamentResult[] <Tournaments>k__BackingField;

            /*0x14f44d8*/ GetTournamentsResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x14ff874*/ void set_Tournaments(Facebook.Unity.TournamentResult[] value);
        }

        interface IDialogResult : Facebook.Unity.IResult
        {
        }

        class AbortDialogResult : Facebook.Unity.ResultBase, Facebook.Unity.IDialogResult, Facebook.Unity.IResult
        {
            /*0x50*/ bool <Success>k__BackingField;

            /*0x14e2bf8*/ AbortDialogResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x14e2c90*/ void set_Success(bool value);
        }

        interface ITournamentScoreResult : Facebook.Unity.IResult
        {
        }

        class TournamentScoreResult : Facebook.Unity.ResultBase, Facebook.Unity.ITournamentScoreResult, Facebook.Unity.IResult
        {
            /*0x2a0a91c*/ TournamentScoreResult(Facebook.Unity.ResultContainer resultContainer);
        }

        interface ICreateGamingContextResult : Facebook.Unity.IResult
        {
        }

        interface ISwitchGamingContextResult : Facebook.Unity.IResult
        {
        }

        interface IChooseGamingContextResult : Facebook.Unity.IResult
        {
        }

        class ChooseGamingContextResult : Facebook.Unity.ResultBase, Facebook.Unity.IChooseGamingContextResult, Facebook.Unity.IResult
        {
            /*0x50*/ string <ContextId>k__BackingField;

            /*0x14ee9a0*/ ChooseGamingContextResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x14eea54*/ string get_ContextId();
            /*0x14eea5c*/ void set_ContextId(string value);
            /*0x14eea64*/ string ToString();
        }

        class CreateGamingContextResult : Facebook.Unity.ResultBase, Facebook.Unity.ICreateGamingContextResult, Facebook.Unity.IResult
        {
            /*0x50*/ string <ContextId>k__BackingField;

            /*0x14f1a50*/ CreateGamingContextResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x14f1b04*/ string get_ContextId();
            /*0x14f1b0c*/ void set_ContextId(string value);
            /*0x14f1b14*/ string ToString();
        }

        class SwitchGamingContextResult : Facebook.Unity.ResultBase, Facebook.Unity.ISwitchGamingContextResult, Facebook.Unity.IResult
        {
            /*0x50*/ string <ContextId>k__BackingField;

            /*0x2a0a064*/ SwitchGamingContextResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x2a0a11c*/ string get_ContextId();
            /*0x2a0a124*/ void set_ContextId(string value);
            /*0x2a0a12c*/ string ToString();
        }

        interface IGetCurrentGamingContextResult : Facebook.Unity.IResult
        {
        }

        class GetCurrentGamingContextResult : Facebook.Unity.ResultBase, Facebook.Unity.IGetCurrentGamingContextResult, Facebook.Unity.IResult
        {
            /*0x50*/ string <ContextId>k__BackingField;

            /*0x14f4d28*/ GetCurrentGamingContextResult(Facebook.Unity.ResultContainer resultContainer);
            /*0x14ff76c*/ string get_ContextId();
            /*0x14ff774*/ void set_ContextId(string value);
            /*0x14ff77c*/ string ToString();
        }

        namespace Windows
        {
            class WindowsFacebook : Facebook.Unity.FacebookBase, Facebook.Unity.Windows.IWindowsFacebookImplementation, Facebook.Unity.IFacebook, Facebook.Unity.IFacebookWindows, Facebook.Unity.IFacebookResultHandler
            {
                /*0x28*/ string appId;
                /*0x30*/ Facebook.Unity.Windows.IWindowsWrapper windowsWrapper;
                /*0x38*/ bool <LimitEventUsage>k__BackingField;

                static /*0x2a0d9f0*/ Facebook.Unity.Windows.IWindowsWrapper GetWindowsWrapper();
                /*0x2a0d970*/ WindowsFacebook();
                /*0x2a0daac*/ WindowsFacebook(Facebook.Unity.Windows.IWindowsWrapper windowsWrapper, Facebook.Unity.CallbackManager callbackManager);
                /*0x2a0dadc*/ bool get_LimitEventUsage();
                /*0x2a0dae4*/ void set_LimitEventUsage(bool value);
                /*0x2a0daf0*/ string get_SDKName();
                /*0x2a0db34*/ string get_SDKVersion();
                /*0x2a0db78*/ void Init(string appId, string clientToken, Facebook.Unity.HideUnityDelegate hideUnityDelegate, Facebook.Unity.InitDelegate onInitComplete);
                /*0x2a0dc64*/ void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                /*0x2a0dd60*/ void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                /*0x2a0de5c*/ void LogOut();
                /*0x2a0df0c*/ bool get_LoggedIn();
                /*0x2a0dfbc*/ void ActivateApp(string appId);
                /*0x2a0e058*/ void AppEventsLogEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
                /*0x2a0e39c*/ void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
                /*0x2a0e4c8*/ void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback);
                /*0x2a0e5bc*/ void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback);
                /*0x2a0e6b0*/ void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload);
                /*0x2a0e7bc*/ void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback);
                /*0x2a0e8b8*/ void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback);
                /*0x2a0e9ac*/ void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
                /*0x2a0eaa8*/ void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
                /*0x2a0eba4*/ void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
                /*0x2a0eca0*/ void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
                /*0x2a0ed9c*/ void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
                /*0x2a0ee90*/ void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
                /*0x2a0ef84*/ void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
                /*0x2a0f080*/ void ScheduleAppToUserNotification(string title, string body, System.Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback);
                /*0x2a0f1bc*/ void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback);
                /*0x2a0f2b8*/ void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
                /*0x2a0f3b4*/ void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
                /*0x2a0f4a8*/ void ShareTournament(int score, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
                /*0x2a0f5b4*/ void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
                /*0x2a0f6fc*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                /*0x2a0f820*/ void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, bool shouldLaunchMediaDialog, string travelId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                /*0x2a0f944*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                /*0x2a0fa7c*/ void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                /*0x2a0fbb4*/ void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback);
                /*0x2a0fca8*/ void Tick();
                /*0x2a0fd58*/ void Deinit();
                /*0x2a0fe08*/ void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
                /*0x2a0fe48*/ void OnAppRequestsComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x2a0fe88*/ void OnLoginComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x2a0fec8*/ void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                /*0x2a0ff08*/ void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                /*0x2a0ff48*/ void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                /*0x2a0ff88*/ void OnShareLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x2a0ffc8*/ void OnGetAppLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x2a10008*/ Facebook.Unity.Profile CurrentProfile();
            }

            interface IWindowsFacebookImplementation : Facebook.Unity.IFacebook, Facebook.Unity.IFacebookWindows, Facebook.Unity.IFacebookResultHandler
            {
                void Tick();
                void Deinit();
            }

            interface IWindowsWrapper
            {
                bool Init(string appId, string clientToken);
                void LogInWithScopes(System.Collections.Generic.IEnumerable<string> scope, string callbackId, Facebook.Unity.CallbackManager callbackManager);
                bool IsLoggedIn();
                void LogOut();
                void Tick();
                void Deinit();
                void GetCatalog(string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void GetPurchases(string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void Purchase(string productID, string developerPayload, string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void ConsumePurchase(string productToken, string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void CurrentProfile(string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void LoadInterstitialAd(string placementID, string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void ShowInterstitialAd(string placementID, string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void LoadRewardedVideo(string placementID, string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void ShowRewardedVideo(string placementID, string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void OpenFriendFinderDialog(string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void GetFriendFinderInvitations(string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void DeleteFriendFinderInvitation(string invitationId, string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void ScheduleAppToUserNotification(string title, string body, System.Uri media, int timeInterval, string payload, string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void PostSessionScore(int score, string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void PostTournamentScore(int score, string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void GetTournament(string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void ShareTournament(int score, System.Collections.Generic.Dictionary<string, string> data, string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<string, string> data, string callbackId, Facebook.Unity.CallbackManager callbackManager);
                void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, string callbackId, string travelId, Facebook.Unity.CallbackManager callbackManager);
                void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, bool shouldLaunchMediaDialog, string callbackId, string travelId, Facebook.Unity.CallbackManager callbackManager);
                void GetUserLocale(string callbackId, Facebook.Unity.CallbackManager callbackManager);
            }

            class WindowsFacebookLoader : Facebook.Unity.FB.CompiledFacebookLoader
            {
                /*0x2a102bc*/ WindowsFacebookLoader();
                /*0x2a10230*/ Facebook.Unity.FacebookGameObject get_FBGameObject();
            }

            class WindowsFacebookGameObject : Facebook.Unity.FacebookGameObject, Facebook.Unity.IFacebookCallbackHandler
            {
                /*0x2a10228*/ WindowsFacebookGameObject();
                /*0x2a10048*/ Facebook.Unity.Windows.IWindowsFacebookImplementation get_WindowsFacebookImpl();
                /*0x2a100b8*/ void OnAwake();
                /*0x2a100bc*/ void Update();
                /*0x2a10170*/ void OnDestroy();
            }
        }

        namespace Editor
        {
            class EditorFacebook : Facebook.Unity.FacebookBase, Facebook.Unity.Mobile.IMobileFacebookImplementation, Facebook.Unity.Mobile.IMobileFacebook, Facebook.Unity.IFacebook, Facebook.Unity.IFacebookWindows, Facebook.Unity.Mobile.IMobileFacebookResultHandler, Facebook.Unity.IFacebookResultHandler, Facebook.Unity.Canvas.ICanvasFacebookImplementation, Facebook.Unity.Canvas.ICanvasFacebookResultHandler
            {
                /*0x28*/ Facebook.Unity.Editor.IEditorWrapper editorWrapper;
                /*0x30*/ bool <LimitEventUsage>k__BackingField;

                static /*0x14f232c*/ Facebook.Unity.IFacebookCallbackHandler get_EditorGameObject();
                /*0x14f2250*/ EditorFacebook(Facebook.Unity.Editor.IEditorWrapper wrapper, Facebook.Unity.CallbackManager callbackManager);
                /*0x14f2288*/ EditorFacebook();
                /*0x14f23a0*/ bool get_LimitEventUsage();
                /*0x14f23a8*/ void set_LimitEventUsage(bool value);
                /*0x14f23b4*/ string get_SDKName();
                /*0x14f23f8*/ string get_SDKVersion();
                /*0x14f243c*/ void Init(Facebook.Unity.InitDelegate onInitComplete);
                /*0x14f2540*/ void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                /*0x14f2550*/ void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                /*0x14f26ac*/ void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
                /*0x14f27e8*/ void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                /*0x14f2940*/ void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                /*0x14f2a98*/ void ActivateApp(string appId);
                /*0x14f2b08*/ void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                /*0x14f2c64*/ void AppEventsLogEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
                /*0x14f2cd4*/ void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
                /*0x14f2d44*/ bool IsImplicitPurchaseLoggingEnabled();
                /*0x14f2d4c*/ Facebook.Unity.Profile CurrentProfile();
                /*0x14f2d54*/ void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback);
                /*0x14f2d94*/ void OnAppRequestsComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f2e08*/ void OnGetAppLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f2e7c*/ void OnLoginComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f2ef4*/ void OnShareLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f2f6c*/ void OnFetchDeferredAppLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f2fe0*/ void OnPayComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f3054*/ void OnRefreshCurrentAccessTokenComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f30c8*/ void OnFriendFinderComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f3140*/ void OnUploadImageToMediaLibraryComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f32a0*/ void OnUploadVideoToMediaLibraryComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f3314*/ void OnOnIAPReadyComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f338c*/ void OnGetCatalogComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f3400*/ void OnGetPurchasesComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f3730*/ void OnPurchaseComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f3b64*/ void OnConsumePurchaseComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f3bd8*/ void OnInitCloudGameComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f3c50*/ void OnGameLoadCompleteComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f3cc8*/ void OnScheduleAppToUserNotificationComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f3d40*/ void OnLoadInterstitialAdComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f3f04*/ void OnShowInterstitialAdComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f3f78*/ void OnLoadRewardedVideoComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f3ff0*/ void OnShowRewardedVideoComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f4068*/ void OnGetPayloadComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f420c*/ void OnPostSessionScoreComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f4284*/ void OnPostTournamentScoreComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f42fc*/ void OnGetTournamentComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f4374*/ void OnShareTournamentComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f43ec*/ void OnCreateTournamentComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f4464*/ void OnGetTournamentsComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f48fc*/ void OnUpdateTournamentComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f4974*/ void OnTournamentDialogSuccess(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f49ec*/ void OnTournamentDialogCancel(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f4a64*/ void OnTournamentDialogError(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f4adc*/ void OnOpenAppStoreComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f4b54*/ void OnCreateGamingContextComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f4bc8*/ void OnSwitchGamingContextComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f4c40*/ void OnChooseGamingContextComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f4cb4*/ void OnGetCurrentGamingContextComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f4ddc*/ void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
                /*0x14f4f34*/ void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
                /*0x14f4f74*/ void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
                /*0x14f4fb4*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                /*0x14f5104*/ void UploadVideoToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                /*0x14f5254*/ void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback);
                /*0x14f5294*/ void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback);
                /*0x14f53b0*/ void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback);
                /*0x14f54cc*/ void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback);
                /*0x14f55e8*/ void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload);
                /*0x14f5704*/ void ConsumePurchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback);
                /*0x14f5820*/ void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback);
                /*0x14f593c*/ void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback);
                /*0x14f5a58*/ void ScheduleAppToUserNotification(string title, string body, System.Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback);
                /*0x14f5b74*/ void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
                /*0x14f5c90*/ void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
                /*0x14f5dac*/ void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
                /*0x14f5ec8*/ void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
                /*0x14f5fe4*/ void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback);
                /*0x14f6100*/ void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback);
                /*0x14f621c*/ void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
                /*0x14f6338*/ void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
                /*0x14f6524*/ void ShareTournament(int score, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
                /*0x14f6640*/ void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
                /*0x14f682c*/ void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback);
                /*0x14f6948*/ void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback);
                /*0x14f6a64*/ void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback);
                /*0x14f6b80*/ void ChooseGamingContext(System.Collections.Generic.List<string> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback);
                /*0x14f6c9c*/ void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback);
                /*0x14f6db8*/ void OnFacebookAuthResponseChange(Facebook.Unity.ResultContainer resultContainer);
                /*0x14f6df8*/ void OnUrlResponse(string message);
                /*0x14f6e38*/ void OnHideUnity(bool hidden);
            }

            class EditorFacebookGameObject : Facebook.Unity.FacebookGameObject
            {
                /*0x14f7000*/ EditorFacebookGameObject();
                /*0x14f6e78*/ void OnAwake();
                /*0x14f6e7c*/ void OnEnable();
                /*0x14f6f38*/ void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
                /*0x14f6f3c*/ void OnDisable();
                /*0x14f6ff8*/ void onPurchaseCompleteHandler(object data);
            }

            class EditorFacebookLoader : Facebook.Unity.FB.CompiledFacebookLoader
            {
                /*0x14f7090*/ EditorFacebookLoader();
                /*0x14f7008*/ Facebook.Unity.FacebookGameObject get_FBGameObject();
            }

            class EditorFacebookMockDialog : UnityEngine.MonoBehaviour
            {
                /*0x18*/ UnityEngine.Rect modalRect;
                /*0x28*/ UnityEngine.GUIStyle modalStyle;
                /*0x30*/ Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> <Callback>k__BackingField;
                /*0x38*/ string <CallbackID>k__BackingField;

                /*0x14f7a70*/ EditorFacebookMockDialog();
                /*0x14f7098*/ Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> get_Callback();
                /*0x14f70a0*/ void set_Callback(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> value);
                /*0x14f70a8*/ string get_CallbackID();
                /*0x14f70b0*/ void set_CallbackID(string value);
                string get_DialogTitle();
                /*0x14f70b8*/ void Start();
                /*0x14f720c*/ void OnGUI();
                void DoGui();
                void SendSuccessResult();
                /*0x14f7324*/ void SendCancelResult();
                /*0x14f74a4*/ void SendErrorResult(string errorMessage);
                /*0x14f75fc*/ void OnGUIDialog(int windowId);
            }

            class EditorWrapper : Facebook.Unity.Editor.IEditorWrapper
            {
                /*0x10*/ Facebook.Unity.IFacebookCallbackHandler callbackHandler;

                /*0x14f2374*/ EditorWrapper(Facebook.Unity.IFacebookCallbackHandler callbackHandler);
                /*0x14f7a78*/ void Init();
                /*0x14f7b48*/ void ShowLoginMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId, string permsisions);
                /*0x14f7bb0*/ void ShowAppRequestMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId);
                /*0x14f7c7c*/ void ShowMockShareDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId);
                /*0x14f7cec*/ void ShowMockFriendFinderDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId);
                /*0x14f7c0c*/ void ShowEmptyMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId, string title);
            }

            interface IEditorWrapper
            {
                void Init();
                void ShowLoginMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId, string permissions);
                void ShowAppRequestMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId);
                void ShowMockShareDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId);
                void ShowMockFriendFinderDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId);
            }

            namespace Dialogs
            {
                class EmptyMockDialog : Facebook.Unity.Editor.EditorFacebookMockDialog
                {
                    /*0x40*/ string <EmptyDialogTitle>k__BackingField;

                    /*0x14f7e84*/ EmptyMockDialog();
                    /*0x14f7cfc*/ string get_EmptyDialogTitle();
                    /*0x14f7d04*/ void set_EmptyDialogTitle(string value);
                    /*0x14f7d0c*/ string get_DialogTitle();
                    /*0x14f7d14*/ void DoGui();
                    /*0x14f7d18*/ void SendSuccessResult();
                }

                class MockLoginDialog : Facebook.Unity.Editor.EditorFacebookMockDialog
                {
                    /*0x40*/ string accessToken;

                    /*0x1506ed8*/ MockLoginDialog();
                    /*0x15068f4*/ string get_DialogTitle();
                    /*0x1506938*/ void DoGui();
                    /*0x1506b8c*/ void SendSuccessResult();

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ Facebook.Unity.Editor.Dialogs.MockLoginDialog <>4__this;
                        /*0x18*/ string graphDomain;

                        /*0x2a14360*/ <>c__DisplayClass4_0();
                        /*0x2a14368*/ void <SendSuccessResult>b__0(Facebook.Unity.IGraphResult graphResult);
                    }

                    class <>c__DisplayClass4_1
                    {
                        /*0x10*/ string facebookID;
                        /*0x18*/ Facebook.Unity.Editor.Dialogs.MockLoginDialog.<> CS$<>8__locals1;

                        /*0x2a146e8*/ <>c__DisplayClass4_1();
                        /*0x2a146f0*/ void <SendSuccessResult>b__1(Facebook.Unity.IGraphResult permResult);
                    }
                }

                class MockShareDialog : Facebook.Unity.Editor.EditorFacebookMockDialog
                {
                    /*0x40*/ string <SubTitle>k__BackingField;

                    /*0x15073b8*/ MockShareDialog();
                    /*0x1506f34*/ string get_SubTitle();
                    /*0x1506f3c*/ void set_SubTitle(string value);
                    /*0x1506f44*/ string get_DialogTitle();
                    /*0x1506fac*/ void DoGui();
                    /*0x1506fb0*/ void SendSuccessResult();
                    /*0x1507264*/ void SendCancelResult();
                    /*0x1507178*/ string GenerateFakePostID();
                }
            }
        }

        namespace Mobile
        {
            interface IMobileFacebook : Facebook.Unity.IFacebook, Facebook.Unity.IFacebookWindows
            {
                bool IsImplicitPurchaseLoggingEnabled();
                void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback);
                void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback);
                void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback);
                void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback);
                void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback);
                void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback);
                void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback);
                void ChooseGamingContext(System.Collections.Generic.List<string> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback);
                void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback);
            }

            interface IMobileFacebookImplementation : Facebook.Unity.Mobile.IMobileFacebook, Facebook.Unity.IFacebook, Facebook.Unity.IFacebookWindows, Facebook.Unity.Mobile.IMobileFacebookResultHandler, Facebook.Unity.IFacebookResultHandler
            {
            }

            interface IMobileFacebookResultHandler : Facebook.Unity.IFacebookResultHandler
            {
                void OnFetchDeferredAppLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnRefreshCurrentAccessTokenComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnFriendFinderComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnUploadImageToMediaLibraryComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnUploadVideoToMediaLibraryComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnOnIAPReadyComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnGetCatalogComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnGetPurchasesComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnPurchaseComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnConsumePurchaseComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnInitCloudGameComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnGameLoadCompleteComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnScheduleAppToUserNotificationComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnLoadInterstitialAdComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnShowInterstitialAdComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnLoadRewardedVideoComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnShowRewardedVideoComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnGetPayloadComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnPostSessionScoreComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnGetTournamentComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnShareTournamentComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnCreateTournamentComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnPostTournamentScoreComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnGetTournamentsComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnUpdateTournamentComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnTournamentDialogSuccess(Facebook.Unity.ResultContainer resultContainer);
                void OnTournamentDialogCancel(Facebook.Unity.ResultContainer resultContainer);
                void OnTournamentDialogError(Facebook.Unity.ResultContainer resultContainer);
                void OnOpenAppStoreComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnCreateGamingContextComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnSwitchGamingContextComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnChooseGamingContextComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnGetCurrentGamingContextComplete(Facebook.Unity.ResultContainer resultContainer);
            }

            class MobileFacebook : Facebook.Unity.FacebookBase, Facebook.Unity.Mobile.IMobileFacebookImplementation, Facebook.Unity.Mobile.IMobileFacebook, Facebook.Unity.IFacebook, Facebook.Unity.IFacebookWindows, Facebook.Unity.Mobile.IMobileFacebookResultHandler, Facebook.Unity.IFacebookResultHandler
            {
                /*0x14e3a1c*/ MobileFacebook(Facebook.Unity.CallbackManager callbackManager);
                Facebook.Unity.AuthenticationToken CurrentAuthenticationToken();
                /*0x1503054*/ Facebook.Unity.Profile CurrentProfile();
                /*0x1503094*/ void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback);
                bool IsImplicitPurchaseLoggingEnabled();
                /*0x15030d4*/ void OnLoginComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x150314c*/ void OnGetAppLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x15031c0*/ void OnAppRequestsComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503234*/ void OnFetchDeferredAppLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x15032a8*/ void OnShareLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503320*/ void OnRefreshCurrentAccessTokenComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x15033d4*/ void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
                /*0x1503414*/ void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
                /*0x1503454*/ void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
                /*0x1503494*/ void OnFriendFinderComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503508*/ void OnUploadImageToMediaLibraryComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x150357c*/ void OnUploadVideoToMediaLibraryComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x15035f0*/ void OnOnIAPReadyComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503664*/ void OnGetCatalogComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x15036d8*/ void OnGetPurchasesComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x150374c*/ void OnPurchaseComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x15037c0*/ void OnConsumePurchaseComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503834*/ void OnInitCloudGameComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x15038a8*/ void OnGameLoadCompleteComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x150391c*/ void OnScheduleAppToUserNotificationComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503994*/ void OnLoadInterstitialAdComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503a08*/ void OnShowInterstitialAdComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503a7c*/ void OnLoadRewardedVideoComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503af4*/ void OnShowRewardedVideoComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503b6c*/ void OnGetPayloadComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503be0*/ void OnPostSessionScoreComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503c58*/ void OnPostTournamentScoreComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503cd0*/ void OnGetTournamentComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503d48*/ void OnShareTournamentComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503dc0*/ void OnCreateTournamentComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503e38*/ void OnGetTournamentsComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503eac*/ void OnUpdateTournamentComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503f24*/ void OnTournamentDialogSuccess(Facebook.Unity.ResultContainer resultContainer);
                /*0x1503f9c*/ void OnTournamentDialogError(Facebook.Unity.ResultContainer resultContainer);
                /*0x1504014*/ void OnTournamentDialogCancel(Facebook.Unity.ResultContainer resultContainer);
                /*0x150408c*/ void OnOpenAppStoreComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1504100*/ void OnCreateGamingContextComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1504174*/ void OnSwitchGamingContextComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x15041ec*/ void OnChooseGamingContextComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x1504260*/ void OnGetCurrentGamingContextComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x15042d4*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                /*0x1504314*/ void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                /*0x1504354*/ void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback);
                /*0x1504394*/ void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback);
                /*0x15043d4*/ void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback);
                /*0x1504414*/ void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload);
                /*0x1504454*/ void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback);
                /*0x1504494*/ void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback);
                /*0x15044d4*/ void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback);
                /*0x1504514*/ void ScheduleAppToUserNotification(string title, string body, System.Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback);
                /*0x1504554*/ void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
                /*0x1504594*/ void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
                /*0x15045d4*/ void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
                /*0x1504614*/ void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
                /*0x1504654*/ void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback);
                /*0x1504694*/ void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback);
                /*0x15046d4*/ void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
                /*0x1504714*/ void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
                /*0x1504754*/ void ShareTournament(int score, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
                /*0x1504794*/ void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
                /*0x15047d4*/ void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback);
                /*0x1504814*/ void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback);
                /*0x1504854*/ void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback);
                /*0x1504894*/ void ChooseGamingContext(System.Collections.Generic.List<string> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback);
                /*0x15048d4*/ void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback);
            }

            class MobileFacebookGameObject : Facebook.Unity.FacebookGameObject, Facebook.Unity.IFacebookCallbackHandler
            {
                /*0x14e9180*/ MobileFacebookGameObject();
                /*0x1504914*/ Facebook.Unity.Mobile.IMobileFacebookImplementation get_MobileFacebook();
                /*0x1504984*/ void OnFetchDeferredAppLinkComplete(string message);
                /*0x1504a74*/ void OnRefreshCurrentAccessTokenComplete(string message);
                /*0x1504b68*/ void OnFriendFinderComplete(string message);
                /*0x1504c5c*/ void OnUploadImageToMediaLibraryComplete(string message);
                /*0x1504d50*/ void OnUploadVideoToMediaLibraryComplete(string message);
                /*0x1504e44*/ void OnOnIAPReadyComplete(string message);
                /*0x1504f38*/ void OnGetCatalogComplete(string message);
                /*0x150502c*/ void OnGetPurchasesComplete(string message);
                /*0x1505120*/ void OnPurchaseComplete(string message);
                /*0x1505214*/ void OnConsumePurchaseComplete(string message);
                /*0x1505308*/ void OnInitCloudGameComplete(string message);
                /*0x15053fc*/ void OnGameLoadCompleteComplete(string message);
                /*0x15054f0*/ void OnScheduleAppToUserNotificationComplete(string message);
                /*0x15055e4*/ void OnLoadInterstitialAdComplete(string message);
                /*0x15056d8*/ void OnShowInterstitialAdComplete(string message);
                /*0x15057cc*/ void OnLoadRewardedVideoComplete(string message);
                /*0x15058c0*/ void OnShowRewardedVideoComplete(string message);
                /*0x15059b4*/ void OnGetPayloadComplete(string message);
                /*0x1505aa8*/ void OnPostSessionScoreComplete(string message);
                /*0x1505b9c*/ void OnPostTournamentScoreComplete(string message);
                /*0x1505c90*/ void OnGetTournamentComplete(string message);
                /*0x1505d84*/ void OnShareTournamentComplete(string message);
                /*0x1505e78*/ void OnCreateTournamentComplete(string message);
                /*0x1505f6c*/ void OnGetTournamentsComplete(string message);
                /*0x1506060*/ void OnUpdateTournamentComplete(string message);
                /*0x1506154*/ void OnTournamentDialogSuccess(string message);
                /*0x1506248*/ void OnTournamentDialogCancel(string message);
                /*0x150633c*/ void OnTournamentDialogError(string message);
                /*0x1506430*/ void OnOpenAppStoreComplete(string message);
                /*0x1506524*/ void OnCreateGamingContextComplete(string message);
                /*0x1506618*/ void OnSwitchGamingContextComplete(string message);
                /*0x150670c*/ void OnChooseGamingContextComplete(string message);
                /*0x1506800*/ void OnGetCurrentGamingContextComplete(string message);
            }

            namespace IOS
            {
                interface IIOSWrapper
                {
                    void Init(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix);
                    void LogInWithReadPermissions(int requestId, string scope);
                    void LogInWithPublishPermissions(int requestId, string scope);
                    void LogOut();
                    void ShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL);
                    void FeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource);
                    void AppRequest(int requestId, string message, string actionType, string objectId, string[] to, int toLength, string filters, string[] excludeIds, int excludeIdsLength, bool hasMaxRecipients, int maxRecipients, string data, string title);
                    void FBAppEventsActivateApp();
                    void LogAppEvent(string logEvent, double valueToSum, int numParams, string[] paramKeys, string[] paramVals);
                    void LogPurchaseAppEvent(double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals);
                    void FBAppEventsSetLimitEventUsage(bool limitEventUsage);
                    void GetAppLink(int requestId);
                    string FBSdkVersion();
                    string FBGetUserID();
                    void OpenFriendFinderDialog(int requestId);
                    void CreateGamingContext(int requestId, string playerID);
                    void SwitchGamingContext(int requestId, string gamingContextID);
                    void GetCurrentGamingContext(int requestId);
                    void ChooseGamingContext(int requestId, string filter, int minSize, int maxSize);
                    void UploadImageToMediaLibrary(int requestId, string caption, string mediaUri, bool shouldLaunchMediaDialog);
                    void UploadVideoToMediaLibrary(int requestId, string caption, string videoUri);
                    Facebook.Unity.AuthenticationToken CurrentAuthenticationToken();
                    Facebook.Unity.Profile CurrentProfile();
                }

                class IOSFacebook : Facebook.Unity.Mobile.MobileFacebook
                {
                    /*0x28*/ bool limitEventUsage;
                    /*0x30*/ Facebook.Unity.Mobile.IOS.IIOSWrapper iosWrapper;
                    /*0x38*/ string userID;

                    static /*0x14ffce0*/ Facebook.Unity.Mobile.IOS.IIOSWrapper GetIOSWrapper();
                    static /*0x1500ea8*/ Facebook.Unity.Mobile.IOS.IOSFacebook.NativeDict MarshallDict(System.Collections.Generic.Dictionary<string, object> dict);
                    /*0x14ffc64*/ IOSFacebook();
                    /*0x14ffd9c*/ IOSFacebook(Facebook.Unity.Mobile.IOS.IIOSWrapper iosWrapper, Facebook.Unity.CallbackManager callbackManager);
                    /*0x14ffdd8*/ bool get_LimitEventUsage();
                    /*0x14ffde0*/ void set_LimitEventUsage(bool value);
                    /*0x14ffea8*/ string get_SDKName();
                    /*0x14ffeec*/ string get_SDKVersion();
                    /*0x14fff9c*/ void Init(string appId, bool frictionlessRequests, string iosURLSuffix, Facebook.Unity.HideUnityDelegate hideUnityDelegate, Facebook.Unity.InitDelegate onInitComplete);
                    /*0x1500100*/ void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                    /*0x1500200*/ void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                    /*0x1500300*/ void LogOut();
                    /*0x15003e4*/ bool get_LoggedIn();
                    /*0x15004c0*/ Facebook.Unity.AuthenticationToken CurrentAuthenticationToken();
                    /*0x1500570*/ Facebook.Unity.Profile CurrentProfile();
                    /*0x1500620*/ void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
                    /*0x1500970*/ void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                    /*0x1500aa8*/ void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                    /*0x1500cb8*/ void AppEventsLogEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
                    /*0x150117c*/ void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
                    /*0x150127c*/ bool IsImplicitPurchaseLoggingEnabled();
                    /*0x1501284*/ void ActivateApp(string appId);
                    /*0x1501334*/ void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                    /*0x1501460*/ void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
                    /*0x150158c*/ void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
                    /*0x15015cc*/ void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
                    /*0x150160c*/ void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback);
                    /*0x1501740*/ void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback);
                    /*0x1501874*/ void ChooseGamingContext(System.Collections.Generic.List<string> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback);
                    /*0x1501a08*/ void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback);
                    /*0x1501b34*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                    /*0x1501ca4*/ void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                    /*0x1501e0c*/ void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback);
                    int AddCallback<T>(Facebook.Unity.FacebookDelegate<T> callback);

                    class NativeDict
                    {
                        /*0x10*/ int <NumEntries>k__BackingField;
                        /*0x18*/ string[] <Keys>k__BackingField;
                        /*0x20*/ string[] <Values>k__BackingField;

                        /*0x2a12738*/ NativeDict();
                        /*0x2a12764*/ int get_NumEntries();
                        /*0x2a1276c*/ void set_NumEntries(int value);
                        /*0x2a12774*/ string[] get_Keys();
                        /*0x2a1277c*/ void set_Keys(string[] value);
                        /*0x2a12784*/ string[] get_Values();
                        /*0x2a1278c*/ void set_Values(string[] value);
                    }
                }

                class IOSFacebookGameObject : Facebook.Unity.Mobile.MobileFacebookGameObject
                {
                    /*0x1501e4c*/ IOSFacebookGameObject();
                }

                class IOSFacebookLoader : Facebook.Unity.FB.CompiledFacebookLoader
                {
                    /*0x1501ee0*/ IOSFacebookLoader();
                    /*0x1501e54*/ Facebook.Unity.FacebookGameObject get_FBGameObject();
                }
            }

            namespace Android
            {
                class AndroidFacebook : Facebook.Unity.Mobile.MobileFacebook
                {
                    /*0x28*/ bool limitEventUsage;
                    /*0x30*/ Facebook.Unity.Mobile.Android.IAndroidWrapper androidWrapper;
                    /*0x38*/ string userID;
                    /*0x40*/ string <KeyHash>k__BackingField;

                    static /*0x14e3870*/ Facebook.Unity.Mobile.Android.IAndroidWrapper GetAndroidWrapper();
                    /*0x14e37fc*/ AndroidFacebook();
                    /*0x14e39a4*/ AndroidFacebook(Facebook.Unity.Mobile.Android.IAndroidWrapper androidWrapper, Facebook.Unity.CallbackManager callbackManager);
                    /*0x14e3a48*/ void set_KeyHash(string value);
                    /*0x14e3a50*/ bool get_LimitEventUsage();
                    /*0x14e3a58*/ void set_LimitEventUsage(bool value);
                    /*0x14e3bf8*/ string get_SDKName();
                    /*0x14e3c3c*/ string get_SDKVersion();
                    /*0x14e3d24*/ void Init(string appId, string clientToken, Facebook.Unity.HideUnityDelegate hideUnityDelegate, Facebook.Unity.InitDelegate onInitComplete);
                    /*0x14e41f0*/ void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                    /*0x14e43e8*/ void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                    /*0x14e44f4*/ void LogOut();
                    /*0x14e4614*/ Facebook.Unity.AuthenticationToken CurrentAuthenticationToken();
                    /*0x14e4a0c*/ Facebook.Unity.Profile CurrentProfile();
                    /*0x14e567c*/ void OnLoginStatusRetrieved(Facebook.Unity.ResultContainer resultContainer);
                    /*0x14e58bc*/ void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
                    /*0x14e5e3c*/ void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                    /*0x14e6118*/ void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                    /*0x14e632c*/ void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                    /*0x14e63e8*/ void AppEventsLogEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
                    /*0x14e669c*/ void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
                    /*0x14e6834*/ bool IsImplicitPurchaseLoggingEnabled();
                    /*0x14e691c*/ void ActivateApp(string appId);
                    /*0x14e696c*/ void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
                    /*0x14e6a28*/ void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
                    /*0x14e6a68*/ void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
                    /*0x14e6aa8*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                    /*0x14e6c20*/ void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                    /*0x14e6d5c*/ void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback);
                    /*0x14e6d9c*/ void OnIAPReady(Facebook.Unity.FacebookDelegate<Facebook.Unity.IIAPReadyResult> callback);
                    /*0x14e6e58*/ void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback);
                    /*0x14e6f14*/ void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback);
                    /*0x14e6fd0*/ void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload);
                    /*0x14e710c*/ void ConsumePurchase(string purchaseToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback);
                    /*0x14e7218*/ void InitCloudGame(Facebook.Unity.FacebookDelegate<Facebook.Unity.IInitCloudGameResult> callback);
                    /*0x14e72d4*/ void GameLoadComplete(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGameLoadCompleteResult> callback);
                    /*0x14e7390*/ void ScheduleAppToUserNotification(string title, string body, System.Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback);
                    /*0x14e7564*/ void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
                    /*0x14e7670*/ void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
                    /*0x14e777c*/ void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
                    /*0x14e7888*/ void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
                    /*0x14e7994*/ void GetPayload(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayloadResult> callback);
                    /*0x14e7a50*/ void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback);
                    /*0x14e7b74*/ void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
                    /*0x14e7c98*/ void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
                    /*0x14e7d54*/ void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
                    /*0x14e80e4*/ void ShareTournament(int score, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
                    /*0x14e83d4*/ void OpenAppStore(Facebook.Unity.FacebookDelegate<Facebook.Unity.IOpenAppStoreResult> callback);
                    /*0x14e8490*/ void CreateGamingContext(string playerID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ICreateGamingContextResult> callback);
                    /*0x14e859c*/ void SwitchGamingContext(string gamingContextID, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISwitchGamingContextResult> callback);
                    /*0x14e86a8*/ void ChooseGamingContext(System.Collections.Generic.List<string> filters, int minSize, int maxSize, Facebook.Unity.FacebookDelegate<Facebook.Unity.IChooseGamingContextResult> callback);
                    /*0x14e8840*/ void GetCurrentGamingContext(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGetCurrentGamingContextResult> callback);
                    /*0x14e3acc*/ void CallFB(string method, string args);

                    class JavaMethodCall<T> : Facebook.Unity.MethodCall<T>
                    {
                        /*0x0*/ Facebook.Unity.Mobile.Android.AndroidFacebook androidImpl;

                        JavaMethodCall(Facebook.Unity.Mobile.Android.AndroidFacebook androidImpl, string methodName);
                        void Call(Facebook.Unity.MethodArguments args);
                    }

                    class <>c
                    {
                        static /*0x0*/ Facebook.Unity.Mobile.Android.AndroidFacebook.<> <>9;
                        static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<string, string>, string> <>9__68_0;
                        static /*0x10*/ System.Func<System.Collections.Generic.KeyValuePair<string, string>, object> <>9__68_1;
                        static /*0x18*/ System.Func<System.Collections.Generic.KeyValuePair<string, string>, string> <>9__69_0;
                        static /*0x20*/ System.Func<System.Collections.Generic.KeyValuePair<string, string>, object> <>9__69_1;

                        static /*0x2a102cc*/ <>c();
                        /*0x2a1032c*/ <>c();
                        /*0x2a10334*/ string <CreateTournament>b__68_0(System.Collections.Generic.KeyValuePair<string, string> pair);
                        /*0x2a10374*/ object <CreateTournament>b__68_1(System.Collections.Generic.KeyValuePair<string, string> pair);
                        /*0x2a103b4*/ string <ShareTournament>b__69_0(System.Collections.Generic.KeyValuePair<string, string> pair);
                        /*0x2a103f4*/ object <ShareTournament>b__69_1(System.Collections.Generic.KeyValuePair<string, string> pair);
                    }
                }

                class AndroidFacebookGameObject : Facebook.Unity.Mobile.MobileFacebookGameObject
                {
                    /*0x14e9178*/ AndroidFacebookGameObject();
                    /*0x14e8920*/ void OnAwake();
                    /*0x14e89e0*/ void OnEnable();
                    /*0x14e8a9c*/ void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
                    /*0x14e8aa0*/ void OnDisable();
                    /*0x14e8b5c*/ void onPurchaseCompleteHandler(object data);
                    /*0x14e8f98*/ void OnLoginStatusRetrieved(string message);
                }

                class AndroidFacebookLoader : Facebook.Unity.FB.CompiledFacebookLoader
                {
                    /*0x14e9214*/ AndroidFacebookLoader();
                    /*0x14e9188*/ Facebook.Unity.FacebookGameObject get_FBGameObject();
                }

                interface IAndroidWrapper
                {
                    T CallStatic<T>(string methodName);
                    void CallStatic(string methodName, object[] args);
                }
            }
        }

        namespace Canvas
        {
            class CanvasFacebook : Facebook.Unity.FacebookBase, Facebook.Unity.Canvas.ICanvasFacebookImplementation, Facebook.Unity.IFacebook, Facebook.Unity.IFacebookWindows, Facebook.Unity.Canvas.ICanvasFacebookResultHandler, Facebook.Unity.IFacebookResultHandler
            {
                /*0x28*/ string appId;
                /*0x30*/ string appLinkUrl;
                /*0x38*/ Facebook.Unity.Canvas.ICanvasJSWrapper canvasJSWrapper;
                /*0x40*/ Facebook.Unity.HideUnityDelegate onHideUnityDelegate;
                /*0x48*/ bool <LimitEventUsage>k__BackingField;

                static /*0x14ea848*/ Facebook.Unity.Canvas.ICanvasJSWrapper GetCanvasJSWrapper();
                static /*0x14ec400*/ void FormatAuthResponse(Facebook.Unity.ResultContainer result, Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback);
                /*0x14ea7cc*/ CanvasFacebook();
                /*0x14ea904*/ CanvasFacebook(Facebook.Unity.Canvas.ICanvasJSWrapper canvasJSWrapper, Facebook.Unity.CallbackManager callbackManager);
                /*0x14ea96c*/ bool get_LimitEventUsage();
                /*0x14ea974*/ void set_LimitEventUsage(bool value);
                /*0x14ea980*/ string get_SDKName();
                /*0x14ea9c4*/ string get_SDKVersion();
                /*0x14eaa70*/ string get_SDKUserAgent();
                /*0x14eb000*/ void Init(string appId, bool cookie, bool logging, bool status, bool xfbml, string channelUrl, string authResponse, bool frictionlessRequests, string javascriptSDKLocale, bool loadDebugJSSDK, Facebook.Unity.HideUnityDelegate hideUnityDelegate, Facebook.Unity.InitDelegate onInitComplete);
                /*0x14eb438*/ void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                /*0x14eb5a0*/ void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                /*0x14eb708*/ void LogOut();
                /*0x14eb7ec*/ void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
                /*0x14ebb0c*/ void ActivateApp(string appId);
                /*0x14ebbbc*/ void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                /*0x14ebd68*/ void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                /*0x14ebf94*/ void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                /*0x14ec13c*/ void AppEventsLogEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
                /*0x14ec250*/ void AppEventsLogPurchase(float purchaseAmount, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
                /*0x14ec364*/ void OnLoginComplete(Facebook.Unity.ResultContainer result);
                /*0x14ecc44*/ void OnGetAppLinkComplete(Facebook.Unity.ResultContainer message);
                /*0x14ecc84*/ void OnFacebookAuthResponseChange(Facebook.Unity.ResultContainer resultContainer);
                /*0x14ecd84*/ void OnPayComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14eceb0*/ void OnAppRequestsComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14ecf24*/ void OnShareLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0x14ecf9c*/ void OnUrlResponse(string url);
                /*0x14ecfa4*/ void OnHideUnity(bool isGameShown);
                /*0x14ed35c*/ void GetCatalog(Facebook.Unity.FacebookDelegate<Facebook.Unity.ICatalogResult> callback);
                /*0x14ed39c*/ void GetPurchases(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchasesResult> callback);
                /*0x14ed3dc*/ void Purchase(string productID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPurchaseResult> callback, string developerPayload);
                /*0x14ed41c*/ void ConsumePurchase(string productToken, Facebook.Unity.FacebookDelegate<Facebook.Unity.IConsumePurchaseResult> callback);
                /*0x14ed45c*/ Facebook.Unity.Profile CurrentProfile();
                /*0x14ed49c*/ void CurrentProfile(Facebook.Unity.FacebookDelegate<Facebook.Unity.IProfileResult> callback);
                /*0x14ed4dc*/ void LoadInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
                /*0x14ed51c*/ void ShowInterstitialAd(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IInterstitialAdResult> callback);
                /*0x14ed55c*/ void LoadRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
                /*0x14ed59c*/ void ShowRewardedVideo(string placementID, Facebook.Unity.FacebookDelegate<Facebook.Unity.IRewardedVideoResult> callback);
                /*0x14ed5dc*/ void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
                /*0x14ed61c*/ void GetFriendFinderInvitations(Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
                /*0x14ed65c*/ void DeleteFriendFinderInvitation(string invitationId, Facebook.Unity.FacebookDelegate<Facebook.Unity.IFriendFinderInvitationResult> callback);
                /*0x14ed69c*/ void ScheduleAppToUserNotification(string title, string body, System.Uri media, int timeInterval, string payload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IScheduleAppToUserNotificationResult> callback);
                /*0x14ed6dc*/ void PostSessionScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ISessionScoreResult> callback);
                /*0x14ed71c*/ void PostTournamentScore(int score, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
                /*0x14ed75c*/ void GetTournament(Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
                /*0x14ed79c*/ void ShareTournament(int score, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentScoreResult> callback);
                /*0x14ed7dc*/ void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, System.Collections.Generic.Dictionary<string, string> data, Facebook.Unity.FacebookDelegate<Facebook.Unity.ITournamentResult> callback);
                /*0x14ed81c*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                /*0x14ed85c*/ void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                /*0x14ed89c*/ void GetUserLocale(Facebook.Unity.FacebookDelegate<Facebook.Unity.ILocaleResult> callback);
                /*0x14ed8dc*/ void <OnLoginComplete>b__37_0(Facebook.Unity.ResultContainer formattedResponse);

                class CanvasUIMethodCall<T> : Facebook.Unity.MethodCall<T>
                {
                    /*0x0*/ Facebook.Unity.Canvas.CanvasFacebook canvasImpl;
                    /*0x0*/ string callbackMethod;

                    CanvasUIMethodCall(Facebook.Unity.Canvas.CanvasFacebook canvasImpl, string methodName, string callbackMethod);
                    void Call(Facebook.Unity.MethodArguments args);
                    void UI(string method, Facebook.Unity.MethodArguments args, Facebook.Unity.FacebookDelegate<T> callback);
                }

                class <>c
                {
                    static /*0x0*/ Facebook.Unity.Canvas.CanvasFacebook.<> <>9;
                    static /*0x8*/ Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> <>9__40_0;

                    static /*0x2a10d6c*/ <>c();
                    /*0x2a10dcc*/ <>c();
                    /*0x2a10dd4*/ void <OnFacebookAuthResponseChange>b__40_0(Facebook.Unity.ResultContainer formattedResponse);
                }

                class <>c__DisplayClass47_0
                {
                    /*0x10*/ Facebook.Unity.ResultContainer result;
                    /*0x18*/ Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback;

                    /*0x2a10e78*/ <>c__DisplayClass47_0();
                    /*0x2a10e80*/ void <FormatAuthResponse>b__0(Facebook.Unity.IGraphResult r);
                }
            }

            class CanvasFacebookGameObject : Facebook.Unity.FacebookGameObject, Facebook.Unity.Canvas.ICanvasFacebookCallbackHandler, Facebook.Unity.IFacebookCallbackHandler
            {
                /*0x14ee260*/ CanvasFacebookGameObject();
                /*0x14eddac*/ Facebook.Unity.Canvas.ICanvasFacebookImplementation get_CanvasFacebookImpl();
                /*0x14ede1c*/ void OnPayComplete(string result);
                /*0x14edf0c*/ void OnFacebookAuthResponseChange(string message);
                /*0x14ee000*/ void OnUrlResponse(string message);
                /*0x14ee0c8*/ void OnHideUnity(bool hide);
                /*0x14ee190*/ void OnAwake();
            }

            class CanvasFacebookLoader : Facebook.Unity.FB.CompiledFacebookLoader
            {
                /*0x14ee2fc*/ CanvasFacebookLoader();
                /*0x14ee270*/ Facebook.Unity.FacebookGameObject get_FBGameObject();
            }

            interface ICanvasFacebookCallbackHandler : Facebook.Unity.IFacebookCallbackHandler
            {
                void OnPayComplete(string message);
                void OnFacebookAuthResponseChange(string message);
                void OnUrlResponse(string message);
                void OnHideUnity(bool hide);
            }

            interface ICanvasFacebookImplementation : Facebook.Unity.IFacebook, Facebook.Unity.IFacebookWindows, Facebook.Unity.Canvas.ICanvasFacebookResultHandler, Facebook.Unity.IFacebookResultHandler
            {
            }

            interface ICanvasFacebookResultHandler : Facebook.Unity.IFacebookResultHandler
            {
                void OnPayComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnFacebookAuthResponseChange(Facebook.Unity.ResultContainer resultContainer);
                void OnUrlResponse(string message);
                void OnHideUnity(bool hide);
            }

            interface ICanvasJSWrapper
            {
                string GetSDKVersion();
                void DisableFullScreen();
                void Init(string connectFacebookUrl, string locale, int debug, string initParams, int status);
                void Login(System.Collections.Generic.IEnumerable<string> scope, string callback_id);
                void Logout();
                void ActivateApp();
                void LogAppEvent(string eventName, System.Nullable<float> valueToSum, string parameters);
                void LogPurchase(float purchaseAmount, string currency, string parameters);
                void Ui(string x, string uid, string callbackMethodName);
                void InitScreenPosition();
            }

            class JsBridge : UnityEngine.MonoBehaviour
            {
                /*0x18*/ Facebook.Unity.Canvas.ICanvasFacebookCallbackHandler facebook;

                /*0x15025f4*/ JsBridge();
                /*0x1501f80*/ void Start();
                /*0x1501fd4*/ void OnLoginComplete(string responseJsonData);
                /*0x1502094*/ void OnFacebookAuthResponseChange(string responseJsonData);
                /*0x1502154*/ void OnPayComplete(string responseJsonData);
                /*0x1502210*/ void OnAppRequestsComplete(string responseJsonData);
                /*0x15022d0*/ void OnShareLinkComplete(string responseJsonData);
                /*0x1502390*/ void OnFacebookFocus(string state);
                /*0x1502478*/ void OnInitComplete(string responseJsonData);
                /*0x1502534*/ void OnUrlResponse(string url);
            }
        }
    }
}
