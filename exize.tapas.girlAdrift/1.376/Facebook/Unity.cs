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

            static /*0xa8b024*/ Json();
            static /*0xa8ae04*/ object Deserialize(string json);
            static /*0xa8afac*/ string Serialize(object obj);

            class Parser : System.IDisposable
            {
                static string WhiteSpace = " 	
";
                static string WordBreak = " 	
{}[],:"";
                /*0x10*/ System.IO.StringReader json;

                static /*0xa8ae10*/ object Parse(string jsonString);
                /*0xa8b0c8*/ Parser(string jsonString);
                /*0xa8b144*/ char get_PeekChar();
                /*0xa8b1bc*/ char get_NextChar();
                /*0xa8b234*/ string get_NextWord();
                /*0xa8b30c*/ Facebook.MiniJSON.Json.Parser.TOKEN get_NextToken();
                /*0xa8b588*/ void Dispose();
                /*0xa8b5b0*/ System.Collections.Generic.Dictionary<string, object> ParseObject();
                /*0xa8b910*/ System.Collections.Generic.List<object> ParseArray();
                /*0xa8b56c*/ object ParseValue();
                /*0xa8ba34*/ object ParseByToken(Facebook.MiniJSON.Json.Parser.TOKEN token);
                /*0xa8b6d4*/ string ParseString();
                /*0xa8bb1c*/ object ParseNumber();
                /*0xa8b4d0*/ void EatWhitespace();

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

                static /*0xa8afb0*/ string Serialize(object obj);
                /*0xa8bc04*/ Serializer();
                /*0xa8bc70*/ void SerializeValue(object value);
                /*0xa8c428*/ void SerializeObject(System.Collections.IDictionary obj);
                /*0xa8c0c8*/ void SerializeArray(System.Collections.IList array);
                /*0xa8be10*/ void SerializeString(string str);
                /*0xa8c8b4*/ void SerializeOther(object value);
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

            static /*0xa8cc3c*/ Facebook.Unity.AccessToken get_CurrentAccessToken();
            static /*0xa8cc84*/ void set_CurrentAccessToken(Facebook.Unity.AccessToken value);
            /*0xa8ca90*/ AccessToken(string tokenString, string userId, System.DateTime expirationTime, System.Collections.Generic.IEnumerable<string> permissions, System.Nullable<System.DateTime> lastRefresh, string graphDomain);
            /*0xa8ccd0*/ string get_TokenString();
            /*0xa8ccd8*/ void set_TokenString(string value);
            /*0xa8cce0*/ System.DateTime get_ExpirationTime();
            /*0xa8cce8*/ void set_ExpirationTime(System.DateTime value);
            /*0xa8ccf0*/ System.Collections.Generic.IEnumerable<string> get_Permissions();
            /*0xa8ccf8*/ void set_Permissions(System.Collections.Generic.IEnumerable<string> value);
            /*0xa8cd00*/ string get_UserId();
            /*0xa8cd08*/ void set_UserId(string value);
            /*0xa8cd10*/ System.Nullable<System.DateTime> get_LastRefresh();
            /*0xa8cd1c*/ void set_LastRefresh(System.Nullable<System.DateTime> value);
            /*0xa8cd24*/ string get_GraphDomain();
            /*0xa8cd2c*/ void set_GraphDomain(string value);
            /*0xa8cd34*/ string ToString();
            /*0xa8d4c4*/ string ToJson();
        }

        class AppEventName
        {
            static string AchievedLevel = "fb_mobile_level_achieved";
            static string ActivatedApp = "fb_mobile_activate_app";
            static string AddedPaymentInfo = "fb_mobile_add_payment_info";
            static string AddedToCart = "fb_mobile_add_to_cart";
            static string AddedToWishlist = "fb_mobile_add_to_wishlist";
            static string CompletedRegistration = "fb_mobile_complete_registration";
            static string CompletedTutorial = "fb_mobile_tutorial_completion";
            static string InitiatedCheckout = "fb_mobile_initiated_checkout";
            static string Purchased = "fb_mobile_purchase";
            static string Rated = "fb_mobile_rate";
            static string Searched = "fb_mobile_search";
            static string SpentCredits = "fb_mobile_spent_credits";
            static string UnlockedAchievement = "fb_mobile_achievement_unlocked";
            static string ViewedContent = "fb_mobile_content_view";
        }

        class AppEventParameterName
        {
            static string ContentID = "fb_content_id";
            static string ContentType = "fb_content_type";
            static string Currency = "fb_currency";
            static string Description = "fb_description";
            static string Level = "fb_level";
            static string MaxRatingValue = "fb_max_rating_value";
            static string NumItems = "fb_num_items";
            static string PaymentInfoAvailable = "fb_payment_info_available";
            static string RegistrationMethod = "fb_registration_method";
            static string SearchString = "fb_search_string";
            static string Success = "fb_success";
        }

        class CallbackManager
        {
            /*0x10*/ System.Collections.Generic.IDictionary<string, object> facebookDelegates;
            /*0x18*/ int nextAsyncId;

            static /*0xa8d9a4*/ void CallCallback(object callback, Facebook.Unity.IResult result);
            static bool TryCallCallback<T>(object callback, Facebook.Unity.IResult result);
            /*0xa8dc24*/ CallbackManager();
            string AddFacebookDelegate<T>(Facebook.Unity.FacebookDelegate<T> callback);
            /*0xa8d738*/ void OnFacebookResponse(Facebook.Unity.IInternalResult result);
        }

        class ComponentFactory
        {
            static string GameObjectName = "UnityFacebookSDKPlugin";
            static /*0x0*/ UnityEngine.GameObject facebookGameObject;

            static /*0xa8dca0*/ UnityEngine.GameObject get_FacebookGameObject();
            static T GetComponent<T>(Facebook.Unity.ComponentFactory.IfNotExist ifNotExist);
            static T AddComponent<T>();
            /*0xa8dd80*/ ComponentFactory();

            enum IfNotExist
            {
                AddNew = 0,
                ReturnNull = 1,
            }
        }

        class Constants
        {
            static string CallbackIdKey = "callback_id";
            static string AccessTokenKey = "access_token";
            static string UrlKey = "url";
            static string RefKey = "ref";
            static string ExtrasKey = "extras";
            static string TargetUrlKey = "target_url";
            static string CancelledKey = "cancelled";
            static string ErrorKey = "error";
            static string HasLicenseKey = "has_license";
            static string OnPayCompleteMethodName = "OnPayComplete";
            static string OnShareCompleteMethodName = "OnShareLinkComplete";
            static string OnAppRequestsCompleteMethodName = "OnAppRequestsComplete";
            static string OnGroupCreateCompleteMethodName = "OnGroupCreateComplete";
            static string OnGroupJoinCompleteMethodName = "OnJoinGroupComplete";
            static string GraphApiVersion = "v6.0";
            static string GraphUrlFormat = "https://graph.{0}/{1}/";
            static string UserLikesPermission = "user_likes";
            static string EmailPermission = "email";
            static string PublishActionsPermission = "publish_actions";
            static string PublishPagesPermission = "publish_pages";
            static string EventBindingKeysClassName = "class_name";
            static string EventBindingKeysIndex = "index";
            static string EventBindingKeysPath = "path";
            static string EventBindingKeysEventName = "event_name";
            static string EventBindingKeysEventType = "event_type";
            static string EventBindingKeysAppVersion = "app_version";
            static string EventBindingKeysText = "text";
            static string EventBindingKeysHint = "hint";
            static string EventBindingKeysDescription = "description";
            static string EventBindingKeysTag = "tag";
            static string EventBindingKeysSection = "section";
            static string EventBindingKeysRow = "row";
            static string EventBindingKeysMatchBitmask = "match_bitmask";
            static int MaxPathDepth = 35;
            static /*0x0*/ System.Nullable<Facebook.Unity.FacebookUnityPlatform> currentPlatform;

            static /*0xa8dd88*/ System.Uri get_GraphUrl();
            static /*0xa8e034*/ string get_GraphApiUserAgent();
            static /*0xa8e31c*/ bool get_IsMobile();
            static /*0xa8e400*/ bool get_IsEditor();
            static /*0xa8e408*/ bool get_IsWeb();
            static /*0xa8e420*/ bool get_IsGameroom();
            static /*0xa8e438*/ string get_UnitySDKUserAgentSuffixLegacy();
            static /*0xa8e2b0*/ string get_UnitySDKUserAgent();
            static /*0xa8e6a4*/ bool get_DebugMode();
            static /*0xa8e340*/ Facebook.Unity.FacebookUnityPlatform get_CurrentPlatform();
            static /*0xa8e740*/ void set_CurrentPlatform(Facebook.Unity.FacebookUnityPlatform value);
            static /*0xa8e6f4*/ Facebook.Unity.FacebookUnityPlatform GetCurrentPlatform();
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

            static /*0xa90ad8*/ FB();
            static /*0xa8e7c0*/ string get_AppId();
            static /*0xa8e818*/ void set_AppId(string value);
            static /*0xa8e874*/ string get_ClientToken();
            static /*0xa8e8cc*/ void set_ClientToken(string value);
            static /*0xa8e928*/ string get_GraphApiVersion();
            static /*0xa8e980*/ void set_GraphApiVersion(string value);
            static /*0xa8e9dc*/ bool get_IsLoggedIn();
            static /*0xa8eacc*/ bool get_IsInitialized();
            static /*0xa8ebc4*/ bool get_LimitAppEventUsage();
            static /*0xa8ecbc*/ void set_LimitAppEventUsage(bool value);
            static /*0xa8e1ec*/ Facebook.Unity.IFacebook get_FacebookImpl();
            static /*0xa8edb8*/ void set_FacebookImpl(Facebook.Unity.IFacebook value);
            static /*0xa8df44*/ string get_FacebookDomain();
            static /*0xa8ee14*/ void set_FacebookDomain(string value);
            static /*0xa8ee70*/ Facebook.Unity.FB.OnDLLLoaded get_OnDLLLoadedDelegate();
            static /*0xa8eec8*/ void set_OnDLLLoadedDelegate(Facebook.Unity.FB.OnDLLLoaded value);
            static /*0xa8ef24*/ void Init(Facebook.Unity.InitDelegate onInitComplete, Facebook.Unity.HideUnityDelegate onHideUnity, string authResponse);
            static /*0xa8f064*/ void Init(string appId, string clientToken, bool cookie, bool logging, bool status, bool xfbml, bool frictionlessRequests, string authResponse, string javascriptSDKLocale, Facebook.Unity.HideUnityDelegate onHideUnity, Facebook.Unity.InitDelegate onInitComplete);
            static /*0xa8f808*/ void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
            static /*0xa8f8e8*/ void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
            static /*0xa8f9c8*/ void LogOut();
            static /*0xa8fa90*/ void AppRequest(string message, Facebook.Unity.OGActionType actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
            static /*0xa8fbe8*/ void AppRequest(string message, Facebook.Unity.OGActionType actionType, string objectId, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
            static /*0xa8fd50*/ void AppRequest(string message, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
            static /*0xa8fe88*/ void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
            static /*0xa8ff88*/ void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
            static /*0xa900bc*/ void API(string query, Facebook.Unity.HttpMethod method, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback, System.Collections.Generic.IDictionary<string, string> formData);
            static /*0xa9021c*/ void API(string query, Facebook.Unity.HttpMethod method, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback, UnityEngine.WWWForm formData);
            static /*0xa9037c*/ void ActivateApp();
            static /*0xa90484*/ void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
            static /*0xa90564*/ void ClearAppLink();
            static /*0xa90568*/ void LogAppEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
            static /*0xa90650*/ void LogPurchase(decimal logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
            static /*0xa90708*/ void LogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
            static /*0xa90828*/ void LogVersion();
            /*0xa90ad0*/ FB();

            class OnDLLLoaded : System.MulticastDelegate
            {
                /*0xa8f648*/ OnDLLLoaded(object object, nint method);
                /*0xa90b7c*/ void Invoke();
                /*0xa90b90*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
                /*0xa90bb0*/ void EndInvoke(System.IAsyncResult result);
            }

            class Canvas
            {
                static /*0xa90bbc*/ Facebook.Unity.IPayFacebook get_FacebookPayImpl();
                static /*0xa90c78*/ void Pay(string product, string action, int quantity, System.Nullable<int> quantityMin, System.Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                static /*0xa90d8c*/ void PayWithProductId(string productId, string action, int quantity, System.Nullable<int> quantityMin, System.Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                static /*0xa90ea4*/ void PayWithProductId(string productId, string action, string developerPayload, string testCurrency, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                /*0xa90f80*/ Canvas();
            }

            class Mobile
            {
                static /*0xa90f88*/ Facebook.Unity.ShareDialogMode get_ShareDialogMode();
                static /*0xa910dc*/ void set_ShareDialogMode(Facebook.Unity.ShareDialogMode value);
                static /*0xa91188*/ string get_UserID();
                static /*0xa91224*/ void set_UserID(string value);
                static /*0xa912d0*/ void UpdateUserProperties(System.Collections.Generic.Dictionary<string, string> parameters);
                static /*0xa91020*/ Facebook.Unity.Mobile.IMobileFacebook get_MobileFacebookImpl();
                static /*0xa9137c*/ void FetchDeferredAppLinkData(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                static /*0xa91438*/ void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback);
                static /*0xa914e4*/ bool IsImplicitPurchaseLoggingEnabled();
                static /*0xa91580*/ void SetAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled);
                static /*0xa9162c*/ void SetAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled);
                static /*0xa916d8*/ void SetPushNotificationsDeviceTokenString(string token);
                /*0xa91784*/ Mobile();
            }

            class Android
            {
                static /*0xa9178c*/ string get_KeyHash();
                /*0xa9182c*/ Android();
            }

            class Gameroom
            {
                static /*0xa91834*/ Facebook.Unity.Gameroom.IGameroomFacebook get_GameroomFacebookImpl();
                static /*0xa918f0*/ void PayPremium(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                static /*0xa91998*/ void HasLicense(Facebook.Unity.FacebookDelegate<Facebook.Unity.IHasLicenseResult> callback);
                /*0xa91a44*/ Gameroom();
            }

            class CompiledFacebookLoader : UnityEngine.MonoBehaviour
            {
                /*0xa91b48*/ CompiledFacebookLoader();
                Facebook.Unity.FacebookGameObject get_FBGameObject();
                /*0xa91a4c*/ void Start();
            }

            class <>c__DisplayClass36_0
            {
                /*0x10*/ Facebook.Unity.InitDelegate onInitComplete;
                /*0x18*/ string appId;
                /*0x20*/ bool cookie;
                /*0x21*/ bool logging;
                /*0x22*/ bool status;
                /*0x23*/ bool xfbml;
                /*0x28*/ string authResponse;
                /*0x30*/ bool frictionlessRequests;
                /*0x38*/ string javascriptSDKLocale;
                /*0x40*/ Facebook.Unity.HideUnityDelegate onHideUnity;

                /*0xa8f640*/ <>c__DisplayClass36_0();
                /*0xa91b50*/ void <Init>b__0();
                /*0xa91c2c*/ void <Init>b__1();
                /*0xa92150*/ void <Init>b__2();
                /*0xa92398*/ void <Init>b__3();
                /*0xa92644*/ void <Init>b__4();
            }
        }

        class FBGamingServices : UnityEngine.ScriptableObject
        {
            static /*0xa927c8*/ void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
            static /*0xa92930*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            static /*0xa929fc*/ void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            static /*0xa92874*/ Facebook.Unity.Mobile.IMobileFacebook get_MobileFacebookImpl();
            /*0xa92ac0*/ FBGamingServices();
        }

        class FacebookBase : Facebook.Unity.IFacebookImplementation, Facebook.Unity.IFacebook, Facebook.Unity.IFacebookResultHandler
        {
            /*0x10*/ Facebook.Unity.InitDelegate onInitCompleteDelegate;
            /*0x18*/ bool <Initialized>k__BackingField;
            /*0x20*/ Facebook.Unity.CallbackManager <CallbackManager>k__BackingField;

            /*0xa92ac8*/ FacebookBase(Facebook.Unity.CallbackManager callbackManager);
            bool get_LimitEventUsage();
            void set_LimitEventUsage(bool value);
            string get_SDKName();
            string get_SDKVersion();
            /*0xa92af0*/ string get_SDKUserAgent();
            /*0xa92b38*/ bool get_LoggedIn();
            /*0xa92bd8*/ bool get_Initialized();
            /*0xa92be0*/ void set_Initialized(bool value);
            /*0xa92bec*/ Facebook.Unity.CallbackManager get_CallbackManager();
            /*0xa92bf4*/ void set_CallbackManager(Facebook.Unity.CallbackManager value);
            /*0xa92bfc*/ void Init(Facebook.Unity.InitDelegate onInitComplete);
            void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
            void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
            /*0xa92c04*/ void LogOut();
            /*0xa92c44*/ void AppRequest(string message, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
            void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
            void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
            void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
            /*0xa92c94*/ void API(string query, Facebook.Unity.HttpMethod method, System.Collections.Generic.IDictionary<string, string> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            /*0xa934c4*/ void API(string query, Facebook.Unity.HttpMethod method, UnityEngine.WWWForm formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            void ActivateApp(string appId);
            void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
            void AppEventsLogEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
            void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
            /*0xa93654*/ void OnInitComplete(Facebook.Unity.ResultContainer resultContainer);
            void OnLoginComplete(Facebook.Unity.ResultContainer resultContainer);
            /*0xa937bc*/ void OnLogoutComplete(Facebook.Unity.ResultContainer resultContainer);
            void OnGetAppLinkComplete(Facebook.Unity.ResultContainer resultContainer);
            void OnAppRequestsComplete(Facebook.Unity.ResultContainer resultContainer);
            void OnShareLinkComplete(Facebook.Unity.ResultContainer resultContainer);
            /*0xa937fc*/ void ValidateAppRequestArgs(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
            /*0xa93a6c*/ void OnAuthResponse(Facebook.Unity.LoginResult result);
            /*0xa92f7c*/ System.Collections.Generic.IDictionary<string, string> CopyByValue(System.Collections.Generic.IDictionary<string, string> data);
            /*0xa93400*/ System.Uri GetGraphUrl(string query);
            /*0xa93ae0*/ void <OnInitComplete>b__35_0(Facebook.Unity.ILoginResult result);

            class <>c
            {
                static /*0x0*/ Facebook.Unity.FacebookBase.<> <>9;
                static /*0x8*/ System.Func<string, bool> <>9__41_0;

                static /*0xa93afc*/ <>c();
                /*0xa93b60*/ <>c();
                /*0xa93b68*/ bool <ValidateAppRequestArgs>b__41_0(string toWhom);
            }
        }

        class InitDelegate : System.MulticastDelegate
        {
            /*0xa93b74*/ InitDelegate(object object, nint method);
            /*0xa93c30*/ void Invoke();
            /*0xa93c44*/ System.IAsyncResult BeginInvoke(System.AsyncCallback callback, object object);
            /*0xa93c64*/ void EndInvoke(System.IAsyncResult result);
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
            /*0xa93c70*/ HideUnityDelegate(object object, nint method);
            /*0xa93d34*/ void Invoke(bool isUnityShown);
            /*0xa93d4c*/ System.IAsyncResult BeginInvoke(bool isUnityShown, System.AsyncCallback callback, object object);
            /*0xa93dd4*/ void EndInvoke(System.IAsyncResult result);
        }

        class FacebookGameObject : UnityEngine.MonoBehaviour, Facebook.Unity.IFacebookCallbackHandler
        {
            /*0x18*/ Facebook.Unity.IFacebookImplementation <Facebook>k__BackingField;

            /*0xa944f8*/ FacebookGameObject();
            /*0xa93de0*/ Facebook.Unity.IFacebookImplementation get_Facebook();
            /*0xa93de8*/ void set_Facebook(Facebook.Unity.IFacebookImplementation value);
            /*0xa93df0*/ void Awake();
            /*0xa93e8c*/ void OnInitComplete(string message);
            /*0xa94094*/ void OnLoginComplete(string message);
            /*0xa94174*/ void OnLogoutComplete(string message);
            /*0xa94254*/ void OnGetAppLinkComplete(string message);
            /*0xa94334*/ void OnAppRequestsComplete(string message);
            /*0xa94414*/ void OnShareLinkComplete(string message);
            /*0xa944f4*/ void OnAwake();
        }

        class FacebookSdkVersion
        {
            static /*0xa8e54c*/ string get_Build();
            /*0xa94500*/ FacebookSdkVersion();
        }

        enum FacebookUnityPlatform
        {
            Unknown = 0,
            Android = 1,
            IOS = 2,
            WebGL = 3,
            Gameroom = 4,
        }

        interface IFacebook
        {
            bool get_LoggedIn();
            bool get_LimitEventUsage();
            void set_LimitEventUsage(bool value);
            string get_SDKName();
            string get_SDKVersion();
            string get_SDKUserAgent();
            bool get_Initialized();
            void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
            void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
            void LogOut();
            void AppRequest(string message, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
            void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
            void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
            void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
            void API(string query, Facebook.Unity.HttpMethod method, System.Collections.Generic.IDictionary<string, string> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            void API(string query, Facebook.Unity.HttpMethod method, UnityEngine.WWWForm formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            void ActivateApp(string appId);
            void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
            void AppEventsLogEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
            void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
        }

        interface IFacebookCallbackHandler
        {
            void OnInitComplete(string message);
            void OnLoginComplete(string message);
            void OnLogoutComplete(string message);
            void OnGetAppLinkComplete(string message);
            void OnAppRequestsComplete(string message);
            void OnShareLinkComplete(string message);
        }

        interface IFacebookImplementation : Facebook.Unity.IFacebook, Facebook.Unity.IFacebookResultHandler
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

        interface IPayFacebook
        {
            void Pay(string product, string action, int quantity, System.Nullable<int> quantityMin, System.Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
            void PayWithProductId(string productId, string action, int quantity, System.Nullable<int> quantityMin, System.Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
            void PayWithProductId(string productId, string action, string developerPayload, string testCurrency, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
        }

        class MethodArguments
        {
            /*0x10*/ System.Collections.Generic.IDictionary<string, object> arguments;

            static /*0xa948bc*/ System.Collections.Generic.Dictionary<string, string> ToStringDict(System.Collections.Generic.IDictionary<string, object> dict);
            /*0xa94508*/ MethodArguments();
            /*0xa94610*/ MethodArguments(Facebook.Unity.MethodArguments methodArgs);
            /*0xa94580*/ MethodArguments(System.Collections.Generic.IDictionary<string, object> arguments);
            void AddPrimative<T>(string argumentName, T value);
            void AddNullablePrimitive<T>(string argumentName, System.Nullable<T> nullable);
            /*0xa94628*/ void AddString(string argumentName, string value);
            /*0xa94704*/ void AddCommaSeparatedList(string argumentName, System.Collections.Generic.IEnumerable<string> value);
            /*0xa947e0*/ void AddDictionary(string argumentName, System.Collections.Generic.IDictionary<string, object> dict);
            void AddList<T>(string argumentName, System.Collections.Generic.IEnumerable<T> list);
            /*0xa94c38*/ void AddUri(string argumentName, System.Uri uri);
            /*0xa94d6c*/ string ToJsonString();
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
            Facebook.Unity.FacebookBase get_FacebookImpl();
            void set_FacebookImpl(Facebook.Unity.FacebookBase value);
            Facebook.Unity.MethodArguments get_Parameters();
            void set_Parameters(Facebook.Unity.MethodArguments value);
            void Call(Facebook.Unity.MethodArguments args);
        }

        enum ShareDialogMode
        {
            AUTOMATIC = 0,
            NATIVE = 1,
            WEB = 2,
            FEED = 3,
        }

        enum OGActionType
        {
            SEND = 0,
            ASKFOR = 1,
            TURN = 2,
        }

        class AccessTokenRefreshResult : Facebook.Unity.ResultBase, Facebook.Unity.IAccessTokenRefreshResult, Facebook.Unity.IResult
        {
            /*0x48*/ Facebook.Unity.AccessToken <AccessToken>k__BackingField;

            /*0xa94dc4*/ AccessTokenRefreshResult(Facebook.Unity.ResultContainer resultContainer);
            /*0xa950c4*/ Facebook.Unity.AccessToken get_AccessToken();
            /*0xa950cc*/ void set_AccessToken(Facebook.Unity.AccessToken value);
            /*0xa950d4*/ string ToString();
        }

        class AppLinkResult : Facebook.Unity.ResultBase, Facebook.Unity.IAppLinkResult, Facebook.Unity.IResult
        {
            /*0x48*/ string <Url>k__BackingField;
            /*0x50*/ string <TargetUrl>k__BackingField;
            /*0x58*/ string <Ref>k__BackingField;
            /*0x60*/ System.Collections.Generic.IDictionary<string, object> <Extras>k__BackingField;

            /*0xa9537c*/ AppLinkResult(Facebook.Unity.ResultContainer resultContainer);
            /*0xa9550c*/ string get_Url();
            /*0xa95514*/ void set_Url(string value);
            /*0xa9551c*/ string get_TargetUrl();
            /*0xa95524*/ void set_TargetUrl(string value);
            /*0xa9552c*/ string get_Ref();
            /*0xa95534*/ void set_Ref(string value);
            /*0xa9553c*/ System.Collections.Generic.IDictionary<string, object> get_Extras();
            /*0xa95544*/ void set_Extras(System.Collections.Generic.IDictionary<string, object> value);
            /*0xa9554c*/ string ToString();
        }

        class AppRequestResult : Facebook.Unity.ResultBase, Facebook.Unity.IAppRequestResult, Facebook.Unity.IResult
        {
            static string RequestIDKey = "request";
            static string ToKey = "to";
            /*0x48*/ string <RequestID>k__BackingField;
            /*0x50*/ System.Collections.Generic.IEnumerable<string> <To>k__BackingField;

            /*0xa95720*/ AppRequestResult(Facebook.Unity.ResultContainer resultContainer);
            /*0xa95c40*/ string get_RequestID();
            /*0xa95c48*/ void set_RequestID(string value);
            /*0xa95c50*/ System.Collections.Generic.IEnumerable<string> get_To();
            /*0xa95c58*/ void set_To(System.Collections.Generic.IEnumerable<string> value);
            /*0xa95c60*/ string ToString();
        }

        class GamingServicesFriendFinderResult : Facebook.Unity.ResultBase, Facebook.Unity.IGamingServicesFriendFinderResult, Facebook.Unity.IResult
        {
            /*0xa95d98*/ GamingServicesFriendFinderResult(Facebook.Unity.ResultContainer resultContainer);
        }

        class GraphResult : Facebook.Unity.ResultBase, Facebook.Unity.IGraphResult, Facebook.Unity.IResult
        {
            /*0x48*/ System.Collections.Generic.IList<object> <ResultList>k__BackingField;
            /*0x50*/ UnityEngine.Texture2D <Texture>k__BackingField;

            /*0xa95d9c*/ GraphResult(UnityEngine.WWW result);
            /*0xa95fd0*/ System.Collections.Generic.IList<object> get_ResultList();
            /*0xa95fd8*/ void set_ResultList(System.Collections.Generic.IList<object> value);
            /*0xa95fe0*/ UnityEngine.Texture2D get_Texture();
            /*0xa95fe8*/ void set_Texture(UnityEngine.Texture2D value);
            /*0xa95ed8*/ void Init(string rawResult);
        }

        class GroupCreateResult : Facebook.Unity.ResultBase, Facebook.Unity.IGroupCreateResult, Facebook.Unity.IResult
        {
            static string IDKey = "id";
            /*0x48*/ string <GroupId>k__BackingField;

            /*0xa95ff0*/ GroupCreateResult(Facebook.Unity.ResultContainer resultContainer);
            /*0xa960a0*/ string get_GroupId();
            /*0xa960a8*/ void set_GroupId(string value);
            /*0xa960b0*/ string ToString();
        }

        class GroupJoinResult : Facebook.Unity.ResultBase, Facebook.Unity.IGroupJoinResult, Facebook.Unity.IResult
        {
            /*0xa961a8*/ GroupJoinResult(Facebook.Unity.ResultContainer resultContainer);
        }

        interface IAccessTokenRefreshResult : Facebook.Unity.IResult
        {
            Facebook.Unity.AccessToken get_AccessToken();
        }

        interface IAppLinkResult : Facebook.Unity.IResult
        {
            string get_Url();
            string get_TargetUrl();
            string get_Ref();
            System.Collections.Generic.IDictionary<string, object> get_Extras();
        }

        interface IAppRequestResult : Facebook.Unity.IResult
        {
            string get_RequestID();
            System.Collections.Generic.IEnumerable<string> get_To();
        }

        interface IGamingServicesFriendFinderResult : Facebook.Unity.IResult
        {
        }

        interface IGraphResult : Facebook.Unity.IResult
        {
            System.Collections.Generic.IList<object> get_ResultList();
            UnityEngine.Texture2D get_Texture();
        }

        interface IGroupCreateResult : Facebook.Unity.IResult
        {
            string get_GroupId();
        }

        interface IGroupJoinResult : Facebook.Unity.IResult
        {
        }

        interface IInternalResult : Facebook.Unity.IResult
        {
            string get_CallbackId();
        }

        interface ILoginResult : Facebook.Unity.IResult
        {
            Facebook.Unity.AccessToken get_AccessToken();
        }

        interface IPayResult : Facebook.Unity.IResult
        {
            long get_ErrorCode();
        }

        interface IResult
        {
            string get_Error();
            System.Collections.Generic.IDictionary<string, object> get_ResultDictionary();
            string get_RawResult();
            bool get_Cancelled();
        }

        interface IShareResult : Facebook.Unity.IResult
        {
            string get_PostId();
        }

        class LoginResult : Facebook.Unity.ResultBase, Facebook.Unity.ILoginResult, Facebook.Unity.IResult
        {
            static string LastRefreshKey = "last_refresh";
            static /*0x0*/ string UserIdKey;
            static /*0x8*/ string ExpirationTimestampKey;
            static /*0x10*/ string PermissionsKey;
            static /*0x18*/ string AccessTokenKey;
            static /*0x20*/ string GraphDomain;
            /*0x48*/ Facebook.Unity.AccessToken <AccessToken>k__BackingField;

            static /*0xa963ec*/ LoginResult();
            /*0xa961ac*/ LoginResult(Facebook.Unity.ResultContainer resultContainer);
            /*0xa962dc*/ Facebook.Unity.AccessToken get_AccessToken();
            /*0xa962e4*/ void set_AccessToken(Facebook.Unity.AccessToken value);
            /*0xa962ec*/ string ToString();
        }

        class PayResult : Facebook.Unity.ResultBase, Facebook.Unity.IPayResult, Facebook.Unity.IResult
        {
            static long CancelPaymentFlowCode = 1383010;

            /*0xa96574*/ PayResult(Facebook.Unity.ResultContainer resultContainer);
            /*0xa96620*/ long get_ErrorCode();
            /*0xa9665c*/ string ToString();
        }

        class ResultBase : Facebook.Unity.IInternalResult, Facebook.Unity.IResult
        {
            static long CancelDialogCode = 4201;
            static string ErrorCodeKey = "error_code";
            static string ErrorMessageKey = "error_message";
            /*0x10*/ string <Error>k__BackingField;
            /*0x18*/ System.Collections.Generic.IDictionary<string, object> <ResultDictionary>k__BackingField;
            /*0x20*/ string <RawResult>k__BackingField;
            /*0x28*/ bool <Cancelled>k__BackingField;
            /*0x30*/ string <CallbackId>k__BackingField;
            /*0x38*/ System.Nullable<long> <CanvasErrorCode>k__BackingField;

            static /*0xa96798*/ string GetErrorValue(System.Collections.Generic.IDictionary<string, object> result);
            static /*0xa9681c*/ bool GetCancelledValue(System.Collections.Generic.IDictionary<string, object> result);
            static /*0xa96a88*/ string GetCallbackId(System.Collections.Generic.IDictionary<string, object> result);
            /*0xa94ef4*/ ResultBase(Facebook.Unity.ResultContainer result);
            /*0xa95e90*/ ResultBase(Facebook.Unity.ResultContainer result, string error, bool cancelled);
            /*0xa96cf8*/ string get_Error();
            /*0xa96d00*/ void set_Error(string value);
            /*0xa96d08*/ System.Collections.Generic.IDictionary<string, object> get_ResultDictionary();
            /*0xa96d10*/ void set_ResultDictionary(System.Collections.Generic.IDictionary<string, object> value);
            /*0xa96d18*/ string get_RawResult();
            /*0xa96d20*/ void set_RawResult(string value);
            /*0xa96d28*/ bool get_Cancelled();
            /*0xa96d30*/ void set_Cancelled(bool value);
            /*0xa96d3c*/ string get_CallbackId();
            /*0xa96d44*/ void set_CallbackId(string value);
            /*0xa96d4c*/ System.Nullable<long> get_CanvasErrorCode();
            /*0xa96d58*/ void set_CanvasErrorCode(System.Nullable<long> value);
            /*0xa951d4*/ string ToString();
            /*0xa96b0c*/ void Init(Facebook.Unity.ResultContainer result, string error, bool cancelled, string callbackId);
        }

        class ResultContainer
        {
            static string CanvasResponseKey = "response";
            /*0x10*/ string <RawResult>k__BackingField;
            /*0x18*/ System.Collections.Generic.IDictionary<string, object> <ResultDictionary>k__BackingField;

            /*0xa96d60*/ ResultContainer(System.Collections.Generic.IDictionary<string, object> dictionary);
            /*0xa93f68*/ ResultContainer(string result);
            /*0xa96f44*/ string get_RawResult();
            /*0xa96f4c*/ void set_RawResult(string value);
            /*0xa96f54*/ System.Collections.Generic.IDictionary<string, object> get_ResultDictionary();
            /*0xa96f5c*/ void set_ResultDictionary(System.Collections.Generic.IDictionary<string, object> value);
            /*0xa96da8*/ System.Collections.Generic.IDictionary<string, object> GetWebFormattedResponseDictionary(System.Collections.Generic.IDictionary<string, object> resultDictionary);
        }

        class ShareResult : Facebook.Unity.ResultBase, Facebook.Unity.IShareResult, Facebook.Unity.IResult
        {
            /*0x48*/ string <PostId>k__BackingField;

            static /*0xa97044*/ string get_PostIDKey();
            /*0xa96f64*/ ShareResult(Facebook.Unity.ResultContainer resultContainer);
            /*0xa970a4*/ string get_PostId();
            /*0xa970ac*/ void set_PostId(string value);
            /*0xa970b4*/ string ToString();
        }

        class AsyncRequestString : UnityEngine.MonoBehaviour
        {
            /*0x18*/ System.Uri url;
            /*0x20*/ Facebook.Unity.HttpMethod method;
            /*0x28*/ System.Collections.Generic.IDictionary<string, string> formData;
            /*0x30*/ UnityEngine.WWWForm query;
            /*0x38*/ Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback;

            static /*0xa971ac*/ void Post(System.Uri url, System.Collections.Generic.Dictionary<string, string> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            static /*0xa97238*/ void Get(System.Uri url, System.Collections.Generic.Dictionary<string, string> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            static /*0xa97248*/ void Request(System.Uri url, Facebook.Unity.HttpMethod method, UnityEngine.WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            static /*0xa971bc*/ void Request(System.Uri url, Facebook.Unity.HttpMethod method, System.Collections.Generic.IDictionary<string, string> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            /*0xa97378*/ AsyncRequestString();
            /*0xa972e8*/ System.Collections.IEnumerator Start();
            /*0xa972c0*/ Facebook.Unity.AsyncRequestString SetUrl(System.Uri url);
            /*0xa972c8*/ Facebook.Unity.AsyncRequestString SetMethod(Facebook.Unity.HttpMethod method);
            /*0xa972e0*/ Facebook.Unity.AsyncRequestString SetFormData(System.Collections.Generic.IDictionary<string, string> formData);
            /*0xa972d0*/ Facebook.Unity.AsyncRequestString SetQuery(UnityEngine.WWWForm query);
            /*0xa972d8*/ Facebook.Unity.AsyncRequestString SetCallback(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);

            class <Start>d__9 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ Facebook.Unity.AsyncRequestString <>4__this;
                /*0x28*/ UnityEngine.WWW <www>5__2;

                /*0xa97350*/ <Start>d__9(int <>1__state);
                /*0xa97380*/ void System.IDisposable.Dispose();
                /*0xa97384*/ bool MoveNext();
                /*0xa97cfc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xa97d04*/ void System.Collections.IEnumerator.Reset();
                /*0xa97d44*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class FacebookLogger
        {
            static /*0x0*/ Facebook.Unity.IFacebookLogger <Instance>k__BackingField;

            static /*0xa97d4c*/ FacebookLogger();
            static /*0xa97df0*/ Facebook.Unity.IFacebookLogger get_Instance();
            static /*0xa97e48*/ void set_Instance(Facebook.Unity.IFacebookLogger value);
            static /*0xa97ea4*/ void Log(string msg);
            static /*0xa97fa4*/ void Log(string format, string[] args);
            static /*0xa909cc*/ void Info(string msg);
            static /*0xa9801c*/ void Info(string format, string[] args);
            static /*0xa8f704*/ void Warn(string msg);
            static /*0xa98094*/ void Warn(string format, string[] args);
            static /*0xa9810c*/ void Error(string msg);
            static /*0xa98210*/ void Error(string format, string[] args);

            class DebugLogger : Facebook.Unity.IFacebookLogger
            {
                /*0xa97de8*/ DebugLogger();
                /*0xa98288*/ void Log(string msg);
                /*0xa98308*/ void Info(string msg);
                /*0xa98360*/ void Warn(string msg);
                /*0xa983b8*/ void Error(string msg);
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
            void Error(string msg);
        }

        class Utilities
        {
            static string WarningMissingParameter = "Did not find expected value '{0}' in dictionary";
            static /*0x0*/ System.Collections.Generic.Dictionary<string, string> commandLineArguments;

            static /*0xa98410*/ System.Collections.Generic.Dictionary<string, string> get_CommandLineArguments();
            static bool TryGetValue<T>(System.Collections.Generic.IDictionary<string, object> dictionary, string key, ref T value);
            static /*0xa8cf34*/ long TotalSeconds(System.DateTime dateTime);
            static T GetValueOrDefault<T>(System.Collections.Generic.IDictionary<string, object> dictionary, string key, bool logWarning);
            static /*0xa8cff0*/ string ToCommaSeparateList(System.Collections.Generic.IEnumerable<string> list);
            static /*0xa985cc*/ string AbsoluteUrlOrEmptyString(System.Uri uri);
            static /*0xa8e58c*/ string GetUserAgent(string productName, string productVersion);
            static /*0xa956cc*/ string ToJson(System.Collections.Generic.IDictionary<string, object> dictionary);
            static void AddAllKVPFrom<T1, T2>(System.Collections.Generic.IDictionary<T1, T2> dest, System.Collections.Generic.IDictionary<T1, T2> source);
            static /*0xa94f64*/ Facebook.Unity.AccessToken ParseAccessTokenFromResult(System.Collections.Generic.IDictionary<string, object> resultDictionary);
            static /*0xa8d090*/ string ToStringNullOk(object obj);
            static /*0xa8d0f0*/ string FormatToString(string baseString, string className, System.Collections.Generic.IDictionary<string, string> propertiesAndValues);
            static /*0xa9866c*/ System.DateTime ParseExpirationDateFromResult(System.Collections.Generic.IDictionary<string, object> resultDictionary);
            static /*0xa98ae8*/ System.Nullable<System.DateTime> ParseLastRefreshFromResult(System.Collections.Generic.IDictionary<string, object> resultDictionary);
            static /*0xa987f8*/ System.Collections.Generic.ICollection<string> ParsePermissionFromResult(System.Collections.Generic.IDictionary<string, object> resultDictionary);
            static /*0xa98bbc*/ System.DateTime FromTimestamp(int timestamp);

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
                static /*0x8*/ System.Func<object, string> <>9__18_0;

                static /*0xa98c18*/ <>c();
                /*0xa98c7c*/ <>c();
                /*0xa98c84*/ string <ParsePermissionFromResult>b__18_0(object permission);
            }
        }

        class FBUnityUtility
        {
            static /*0x0*/ string currentDeviceIdentifier;
            static /*0x8*/ Facebook.Unity.IAsyncRequestStringWrapper asyncRequestStringWrapper;

            static /*0xa98ca4*/ string get_UnityDeviceIdentifier();
            static /*0xa98d18*/ void set_UnityDeviceIdentifier(string value);
            static /*0xa93374*/ Facebook.Unity.IAsyncRequestStringWrapper get_AsyncRequestStringWrapper();
            static /*0xa98d6c*/ void set_AsyncRequestStringWrapper(Facebook.Unity.IAsyncRequestStringWrapper value);
        }

        class AsyncRequestStringWrapper : Facebook.Unity.IAsyncRequestStringWrapper
        {
            /*0xa98d64*/ AsyncRequestStringWrapper();
            /*0xa98db8*/ void Request(System.Uri url, Facebook.Unity.HttpMethod method, UnityEngine.WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            /*0xa98dcc*/ void Request(System.Uri url, Facebook.Unity.HttpMethod method, System.Collections.Generic.IDictionary<string, string> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
        }

        interface IAsyncRequestStringWrapper
        {
            void Request(System.Uri url, Facebook.Unity.HttpMethod method, UnityEngine.WWWForm query, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
            void Request(System.Uri url, Facebook.Unity.HttpMethod method, System.Collections.Generic.IDictionary<string, string> formData, Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult> callback);
        }

        class FacebookScheduler : UnityEngine.MonoBehaviour, Facebook.Unity.IFacebookScheduler
        {
            /*0xa98e9c*/ FacebookScheduler();
            /*0xa98de0*/ void Schedule(System.Action action, long delay);
            /*0xa98e00*/ System.Collections.IEnumerator DelayEvent(System.Action action, long delay);

            class <DelayEvent>d__1 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ long delay;
                /*0x28*/ System.Action action;

                /*0xa98e74*/ <DelayEvent>d__1(int <>1__state);
                /*0xa98ea4*/ void System.IDisposable.Dispose();
                /*0xa98ea8*/ bool MoveNext();
                /*0xa98f58*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xa98f60*/ void System.Collections.IEnumerator.Reset();
                /*0xa98fa0*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        interface IFacebookScheduler
        {
            void Schedule(System.Action action, long delay);
        }

        interface IFacebookSchedulerFactory
        {
            Facebook.Unity.IFacebookScheduler GetInstance();
        }

        class FacebookSchedulerFactory : Facebook.Unity.IFacebookSchedulerFactory
        {
            /*0xa98fec*/ FacebookSchedulerFactory();
            /*0xa98fa8*/ Facebook.Unity.IFacebookScheduler GetInstance();
        }

        interface IHasLicenseResult : Facebook.Unity.IResult
        {
            bool get_HasLicense();
        }

        class HasLicenseResult : Facebook.Unity.ResultBase, Facebook.Unity.IHasLicenseResult, Facebook.Unity.IResult
        {
            /*0x48*/ bool <HasLicense>k__BackingField;

            /*0xa98ff4*/ HasLicenseResult(Facebook.Unity.ResultContainer resultContainer);
            /*0xa990a4*/ bool get_HasLicense();
            /*0xa990ac*/ void set_HasLicense(bool value);
        }

        class CodelessIAPAutoLog
        {
            static /*0xa990b8*/ void handlePurchaseCompleted(object data);
            static /*0xa99510*/ void addListenerToIAPButtons(object listenerObject);
            static /*0xa9963c*/ void addListenerToGameObject(UnityEngine.Object gameObject, object listenerObject);
            static /*0xa999d0*/ System.Type FindTypeInAssemblies(string typeName, string nameSpace);
            static /*0xa995c0*/ UnityEngine.Object[] FindObjectsOfTypeByName(string typeName, string nameSpace);
            static /*0xa99b10*/ object GetField(object inObj, string fieldName);
            static /*0xa994b0*/ object GetProperty(object inObj, string propertyName);
            /*0xa99b6c*/ CodelessIAPAutoLog();
        }

        class CodelessCrawler : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ bool isGeneratingSnapshot;
            static /*0x8*/ UnityEngine.Camera mainCamera;

            static /*0xa9b060*/ CodelessCrawler();
            static /*0xa99df4*/ void SendAndroid(string json);
            static /*0xa9a014*/ void SendIos(string json);
            static /*0xa9a018*/ string GenBase64Screenshot();
            static /*0xa9a180*/ string GenViewJson();
            static /*0xa9a574*/ void GenChild(UnityEngine.GameObject curObj, System.Text.StringBuilder builder);
            static /*0xa99d04*/ void updateMainCamera();
            static /*0xa9ae14*/ UnityEngine.Vector2 getScreenCoordinate(UnityEngine.Vector3 position, UnityEngine.RenderMode renderMode);
            static /*0xa9af14*/ string getClasstypeBitmaskButton();
            static /*0xa9af98*/ string getVisibility(UnityEngine.GameObject gameObj);
            /*0xa9b058*/ CodelessCrawler();
            /*0xa99b74*/ void Awake();
            /*0xa99c18*/ void CaptureViewHierarchy(string message);
            /*0xa99d6c*/ System.Collections.IEnumerator GenSnapshot();
            /*0xa9b00c*/ void onActiveSceneChanged(UnityEngine.SceneManagement.Scene arg0, UnityEngine.SceneManagement.Scene arg1);

            class <GenSnapshot>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;

                /*0xa99dcc*/ <GenSnapshot>d__4(int <>1__state);
                /*0xa9b064*/ void System.IDisposable.Dispose();
                /*0xa9b068*/ bool MoveNext();
                /*0xa9b2c4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0xa9b2cc*/ void System.Collections.IEnumerator.Reset();
                /*0xa9b30c*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class CodelessUIInteractEvent : UnityEngine.MonoBehaviour
        {
            /*0x18*/ Facebook.Unity.FBSDKEventBindingManager <eventBindingManager>k__BackingField;

            static /*0xa9b464*/ void SetLoggerInitAndroid();
            static /*0xa9b58c*/ void SetLoggerInitIos();
            /*0xa9bde4*/ CodelessUIInteractEvent();
            /*0xa9b314*/ Facebook.Unity.FBSDKEventBindingManager get_eventBindingManager();
            /*0xa9b31c*/ void set_eventBindingManager(Facebook.Unity.FBSDKEventBindingManager value);
            /*0xa9b324*/ void Awake();
            /*0xa9b590*/ void Update();
            /*0xa9ba54*/ void OnReceiveMapping(string message);
        }

        class FBSDKViewHiearchy
        {
            static /*0xa9ba38*/ bool CheckGameObjectMatchPath(UnityEngine.GameObject go, System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> path);
            static /*0xa9bdf4*/ bool CheckPathMatchPath(System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> goPath, System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> path);
            static /*0xa9bdec*/ System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> GetPath(UnityEngine.GameObject go);
            static /*0xa9bf18*/ System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> GetPath(UnityEngine.GameObject go, int limit);
            static /*0xa9c218*/ UnityEngine.GameObject GetParent(UnityEngine.GameObject go);
            static /*0xa9c664*/ System.Collections.Generic.Dictionary<string, object> GetAttribute(UnityEngine.GameObject obj, UnityEngine.GameObject parent);
            /*0xa9c824*/ FBSDKViewHiearchy();
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

            /*0xa9c2c0*/ FBSDKCodelessPathComponent(System.Collections.Generic.Dictionary<string, object> dict);
            /*0xa9c82c*/ string get_className();
            /*0xa9c834*/ void set_className(string value);
            /*0xa9c83c*/ string get_text();
            /*0xa9c844*/ void set_text(string value);
            /*0xa9c84c*/ string get_hint();
            /*0xa9c854*/ void set_hint(string value);
            /*0xa9c85c*/ string get_desc();
            /*0xa9c864*/ void set_desc(string value);
            /*0xa9c86c*/ string get_tag();
            /*0xa9c874*/ void set_tag(string value);
            /*0xa9c87c*/ long get_index();
            /*0xa9c884*/ void set_index(long value);
            /*0xa9c88c*/ long get_section();
            /*0xa9c894*/ void set_section(long value);
            /*0xa9c89c*/ long get_row();
            /*0xa9c8a4*/ void set_row(long value);
            /*0xa9c8ac*/ long get_matchBitmask();
            /*0xa9c8b4*/ void set_matchBitmask(long value);
        }

        class FBSDKEventBinding
        {
            /*0x10*/ string <eventName>k__BackingField;
            /*0x18*/ string <eventType>k__BackingField;
            /*0x20*/ string <appVersion>k__BackingField;
            /*0x28*/ string <pathType>k__BackingField;
            /*0x30*/ System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> <path>k__BackingField;
            /*0x38*/ System.Collections.Generic.List<string> <parameters>k__BackingField;

            /*0xa9c8bc*/ FBSDKEventBinding(System.Collections.Generic.Dictionary<string, object> dict);
            /*0xa9cce4*/ string get_eventName();
            /*0xa9ccec*/ void set_eventName(string value);
            /*0xa9ccf4*/ string get_eventType();
            /*0xa9ccfc*/ void set_eventType(string value);
            /*0xa9cd04*/ string get_appVersion();
            /*0xa9cd0c*/ void set_appVersion(string value);
            /*0xa9cd14*/ string get_pathType();
            /*0xa9cd1c*/ void set_pathType(string value);
            /*0xa9cd24*/ System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> get_path();
            /*0xa9cd2c*/ void set_path(System.Collections.Generic.List<Facebook.Unity.FBSDKCodelessPathComponent> value);
            /*0xa9cd34*/ System.Collections.Generic.List<string> get_parameters();
            /*0xa9cd3c*/ void set_parameters(System.Collections.Generic.List<string> value);
        }

        class FBSDKEventBindingManager
        {
            /*0x10*/ System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> <eventBindings>k__BackingField;

            /*0xa9bb3c*/ FBSDKEventBindingManager(System.Collections.Generic.List<object> listDict);
            /*0xa9cd44*/ System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> get_eventBindings();
            /*0xa9cd4c*/ void set_eventBindings(System.Collections.Generic.List<Facebook.Unity.FBSDKEventBinding> value);
        }

        interface IMediaUploadResult : Facebook.Unity.IResult
        {
            string get_MediaId();
        }

        class MediaUploadResult : Facebook.Unity.ResultBase, Facebook.Unity.IMediaUploadResult, Facebook.Unity.IResult
        {
            /*0x48*/ string <MediaId>k__BackingField;

            /*0xa9cd54*/ MediaUploadResult(Facebook.Unity.ResultContainer resultContainer);
            /*0xa9ce3c*/ string get_MediaId();
            /*0xa9ce44*/ void set_MediaId(string value);
            /*0xa9ce4c*/ string ToString();
        }

        namespace Gameroom
        {
            class GameroomFacebook : Facebook.Unity.FacebookBase, Facebook.Unity.Gameroom.IGameroomFacebookImplementation, Facebook.Unity.Gameroom.IGameroomFacebook, Facebook.Unity.IPayFacebook, Facebook.Unity.IFacebook, Facebook.Unity.Gameroom.IGameroomFacebookResultHandler, Facebook.Unity.IFacebookResultHandler
            {
                /*0x28*/ string appId;
                /*0x30*/ Facebook.Unity.Gameroom.IGameroomWrapper gameroomWrapper;
                /*0x38*/ bool <LimitEventUsage>k__BackingField;

                static /*0xa9cfbc*/ Facebook.Unity.Gameroom.IGameroomWrapper GetGameroomWrapper();
                /*0xa9cf44*/ GameroomFacebook();
                /*0xa9d074*/ GameroomFacebook(Facebook.Unity.Gameroom.IGameroomWrapper gameroomWrapper, Facebook.Unity.CallbackManager callbackManager);
                /*0xa9d0a4*/ bool get_LimitEventUsage();
                /*0xa9d0ac*/ void set_LimitEventUsage(bool value);
                /*0xa9d0b8*/ string get_SDKName();
                /*0xa9d0f8*/ string get_SDKVersion();
                /*0xa926d4*/ void Init(string appId, Facebook.Unity.HideUnityDelegate hideUnityDelegate, Facebook.Unity.InitDelegate onInitComplete);
                /*0xa9d264*/ void ActivateApp(string appId);
                /*0xa9d304*/ void AppEventsLogEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
                /*0xa9d640*/ void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
                /*0xa9d768*/ void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
                /*0xa9dc58*/ void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                /*0xa9de60*/ void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                /*0xa9dea4*/ void Pay(string product, string action, int quantity, System.Nullable<int> quantityMin, System.Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                /*0xa9e128*/ void PayWithProductId(string productId, string action, int quantity, System.Nullable<int> quantityMin, System.Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                /*0xa9e16c*/ void PayWithProductId(string productId, string action, string developerPayload, string testCurrency, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                /*0xa9e1b0*/ void PayPremium(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                /*0xa9e2e0*/ void HasLicense(Facebook.Unity.FacebookDelegate<Facebook.Unity.IHasLicenseResult> callback);
                /*0xa9e410*/ void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                /*0xa9e450*/ void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                /*0xa9e594*/ void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                /*0xa9e598*/ void OnAppRequestsComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xa9e610*/ void OnGetAppLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xa9e650*/ void OnLoginComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xa9e6cc*/ void OnShareLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xa9e744*/ void OnPayComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xa9e7bc*/ void OnHasLicenseComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xa9e834*/ bool HaveReceivedPipeResponse();
                /*0xa9e8e0*/ string GetPipeResponse(string callbackId);
                /*0xa9dee4*/ void PayImpl(string product, string productId, string action, int quantity, System.Nullable<int> quantityMin, System.Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, string developerPayload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                /*0xa9e454*/ void LoginWithPermissions(System.Collections.Generic.IEnumerable<string> scope, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);

                class OnComplete : System.MulticastDelegate
                {
                    /*0xa9d138*/ OnComplete(object object, nint method);
                    /*0xa9ea94*/ void Invoke(Facebook.Unity.ResultContainer resultContainer);
                    /*0xa9eaa8*/ System.IAsyncResult BeginInvoke(Facebook.Unity.ResultContainer resultContainer, System.AsyncCallback callback, object object);
                    /*0xa9eac8*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class GameroomFacebookGameObject : Facebook.Unity.FacebookGameObject, Facebook.Unity.IFacebookCallbackHandler
            {
                /*0xa9ec08*/ GameroomFacebookGameObject();
                /*0xa9ead4*/ Facebook.Unity.Gameroom.IGameroomFacebookImplementation get_GameroomFacebookImpl();
                /*0xa9eb40*/ void WaitForResponse(Facebook.Unity.Gameroom.GameroomFacebook.OnComplete onCompleteDelegate, string callbackId);
                /*0xa9ebdc*/ void OnAwake();
                /*0xa9eb60*/ System.Collections.IEnumerator WaitForPipeResponse(Facebook.Unity.Gameroom.GameroomFacebook.OnComplete onCompleteDelegate, string callbackId);

                class <WaitForPipeResponse>d__4 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ object <>2__current;
                    /*0x20*/ Facebook.Unity.Gameroom.GameroomFacebookGameObject <>4__this;
                    /*0x28*/ Facebook.Unity.Gameroom.GameroomFacebook.OnComplete onCompleteDelegate;
                    /*0x30*/ string callbackId;

                    /*0xa9ebe0*/ <WaitForPipeResponse>d__4(int <>1__state);
                    /*0xa9ec10*/ void System.IDisposable.Dispose();
                    /*0xa9ec14*/ bool MoveNext();
                    /*0xa9edc0*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                    /*0xa9edc8*/ void System.Collections.IEnumerator.Reset();
                    /*0xa9ee08*/ object System.Collections.IEnumerator.get_Current();
                }
            }

            class GameroomFacebookLoader : Facebook.Unity.FB.CompiledFacebookLoader
            {
                /*0xa9ee9c*/ GameroomFacebookLoader();
                /*0xa9ee10*/ Facebook.Unity.FacebookGameObject get_FBGameObject();
            }

            interface IGameroomFacebook : Facebook.Unity.IPayFacebook, Facebook.Unity.IFacebook
            {
                void PayPremium(Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                void HasLicense(Facebook.Unity.FacebookDelegate<Facebook.Unity.IHasLicenseResult> callback);
            }

            interface IGameroomFacebookImplementation : Facebook.Unity.Gameroom.IGameroomFacebook, Facebook.Unity.IPayFacebook, Facebook.Unity.IFacebook, Facebook.Unity.Gameroom.IGameroomFacebookResultHandler, Facebook.Unity.IFacebookResultHandler
            {
                bool HaveReceivedPipeResponse();
                string GetPipeResponse(string callbackId);
            }

            interface IGameroomFacebookResultHandler : Facebook.Unity.IFacebookResultHandler
            {
            }

            interface IGameroomWrapper
            {
                System.Collections.Generic.IDictionary<string, object> get_PipeResponse();
                void set_PipeResponse(System.Collections.Generic.IDictionary<string, object> value);
                void Init(Facebook.Unity.Gameroom.GameroomFacebook.OnComplete completeDelegate);
                void DoLoginRequest(string appID, string permissions, string callbackID, Facebook.Unity.Gameroom.GameroomFacebook.OnComplete completeDelegate);
                void DoPayRequest(string appId, string method, string action, string product, string productId, string quantity, string quantityMin, string quantityMax, string requestId, string pricepointId, string testCurrency, string developerPayload, string callbackID, Facebook.Unity.Gameroom.GameroomFacebook.OnComplete completeDelegate);
                void DoFeedShareRequest(string appId, string toId, string link, string linkName, string linkCaption, string linkDescription, string pictureLink, string mediaSource, string callbackID, Facebook.Unity.Gameroom.GameroomFacebook.OnComplete completeDelegate);
                void DoAppRequestRequest(string appId, string message, string actionType, string objectId, string to, string filters, string excludeIDs, string maxRecipients, string data, string title, string callbackID, Facebook.Unity.Gameroom.GameroomFacebook.OnComplete completeDelegate);
                void DoPayPremiumRequest(string appId, string callbackID, Facebook.Unity.Gameroom.GameroomFacebook.OnComplete completeDelegate);
                void DoHasLicenseRequest(string appId, string callbackID, Facebook.Unity.Gameroom.GameroomFacebook.OnComplete completeDelegate);
            }
        }

        namespace Editor
        {
            class EditorFacebook : Facebook.Unity.FacebookBase, Facebook.Unity.Mobile.IMobileFacebookImplementation, Facebook.Unity.Mobile.IMobileFacebook, Facebook.Unity.IFacebook, Facebook.Unity.Mobile.IMobileFacebookResultHandler, Facebook.Unity.IFacebookResultHandler, Facebook.Unity.Canvas.ICanvasFacebookImplementation, Facebook.Unity.Canvas.ICanvasFacebook, Facebook.Unity.IPayFacebook, Facebook.Unity.Canvas.ICanvasFacebookResultHandler
            {
                static string WarningMessage = "You are using the facebook SDK in the Unity Editor. Behavior may not be the same as when used on iOS, Android, or Web.";
                static string AccessTokenKey = "com.facebook.unity.editor.accesstoken";
                /*0x28*/ Facebook.Unity.Editor.IEditorWrapper editorWrapper;
                /*0x30*/ bool <LimitEventUsage>k__BackingField;
                /*0x34*/ Facebook.Unity.ShareDialogMode <ShareDialogMode>k__BackingField;
                /*0x38*/ string <UserID>k__BackingField;

                static /*0xa9ef7c*/ Facebook.Unity.IFacebookCallbackHandler get_EditorGameObject();
                /*0xa9eea4*/ EditorFacebook(Facebook.Unity.Editor.IEditorWrapper wrapper, Facebook.Unity.CallbackManager callbackManager);
                /*0xa9eed0*/ EditorFacebook();
                /*0xa9efe8*/ bool get_LimitEventUsage();
                /*0xa9eff0*/ void set_LimitEventUsage(bool value);
                /*0xa9effc*/ Facebook.Unity.ShareDialogMode get_ShareDialogMode();
                /*0xa9f004*/ void set_ShareDialogMode(Facebook.Unity.ShareDialogMode value);
                /*0xa9f00c*/ string get_SDKName();
                /*0xa9f04c*/ string get_SDKVersion();
                /*0xa9f08c*/ string get_UserID();
                /*0xa9f094*/ void set_UserID(string value);
                /*0xa9f09c*/ void UpdateUserProperties(System.Collections.Generic.Dictionary<string, string> parameters);
                /*0xa9f0a0*/ void Init(Facebook.Unity.InitDelegate onInitComplete);
                /*0xa9f190*/ void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                /*0xa9f1a0*/ void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                /*0xa9f2d0*/ void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
                /*0xa9f3ec*/ void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                /*0xa9f524*/ void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                /*0xa9f65c*/ void ActivateApp(string appId);
                /*0xa9f6c0*/ void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                /*0xa9f824*/ void AppEventsLogEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
                /*0xa9f888*/ void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
                /*0xa9f8ec*/ bool IsImplicitPurchaseLoggingEnabled();
                /*0xa9f8f4*/ void SetAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled);
                /*0xa9f8f8*/ void SetAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled);
                /*0xa9f8fc*/ void SetPushNotificationsDeviceTokenString(string token);
                /*0xa9f900*/ void FetchDeferredAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                /*0xa9fbe4*/ void Pay(string product, string action, int quantity, System.Nullable<int> quantityMin, System.Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                /*0xa9fd00*/ void PayWithProductId(string productId, string action, int quantity, System.Nullable<int> quantityMin, System.Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                /*0xa9fe1c*/ void PayWithProductId(string productId, string action, string developerPayload, string testCurrency, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                /*0xa9ff38*/ void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback);
                /*0xaa0204*/ void OnAppRequestsComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa0278*/ void OnGetAppLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa02ec*/ void OnLoginComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa0368*/ void OnShareLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xa9fb70*/ void OnFetchDeferredAppLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa03dc*/ void OnPayComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa0190*/ void OnRefreshCurrentAccessTokenComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa0450*/ void OnFriendFinderComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa04c4*/ void OnUploadImageToMediaLibraryComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa0538*/ void OnUploadVideoToMediaLibraryComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa05ac*/ void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
                /*0xaa06e4*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                /*0xaa083c*/ void UploadVideoToMediaLibrary(string caption, System.Uri imageUri, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                /*0xaa0994*/ void OnFacebookAuthResponseChange(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa09d4*/ void OnUrlResponse(string message);
                /*0xaa0a14*/ void OnHideUnity(bool hidden);
            }

            class EditorFacebookGameObject : Facebook.Unity.FacebookGameObject
            {
                /*0xaa0bac*/ EditorFacebookGameObject();
                /*0xaa0a54*/ void OnAwake();
                /*0xaa0a58*/ void OnEnable();
                /*0xaa0afc*/ void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
                /*0xaa0b00*/ void OnDisable();
                /*0xaa0ba4*/ void onPurchaseCompleteHandler(object data);
            }

            class EditorFacebookLoader : Facebook.Unity.FB.CompiledFacebookLoader
            {
                /*0xaa0c3c*/ EditorFacebookLoader();
                /*0xaa0bb4*/ Facebook.Unity.FacebookGameObject get_FBGameObject();
            }

            class EditorFacebookMockDialog : UnityEngine.MonoBehaviour
            {
                /*0x18*/ UnityEngine.Rect modalRect;
                /*0x28*/ UnityEngine.GUIStyle modalStyle;
                /*0x30*/ Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> <Callback>k__BackingField;
                /*0x38*/ string <CallbackID>k__BackingField;

                /*0xaa158c*/ EditorFacebookMockDialog();
                /*0xaa0c44*/ Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> get_Callback();
                /*0xaa0c4c*/ void set_Callback(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> value);
                /*0xaa0c54*/ string get_CallbackID();
                /*0xaa0c5c*/ void set_CallbackID(string value);
                string get_DialogTitle();
                /*0xaa0c64*/ void Start();
                /*0xaa0d94*/ void OnGUI();
                void DoGui();
                void SendSuccessResult();
                /*0xaa0ea8*/ void SendCancelResult();
                /*0xaa101c*/ void SendErrorResult(string errorMessage);
                /*0xaa1168*/ void OnGUIDialog(int windowId);
            }

            class EditorWrapper : Facebook.Unity.Editor.IEditorWrapper
            {
                /*0x10*/ Facebook.Unity.IFacebookCallbackHandler callbackHandler;

                /*0xa9efc0*/ EditorWrapper(Facebook.Unity.IFacebookCallbackHandler callbackHandler);
                /*0xaa1594*/ void Init();
                /*0xaa1658*/ void ShowLoginMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId, string permsisions);
                /*0xaa16bc*/ void ShowAppRequestMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId);
                /*0xaa1780*/ void ShowGameGroupCreateMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId);
                /*0xaa17d8*/ void ShowGameGroupJoinMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId);
                /*0xaa1830*/ void ShowPayMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId);
                /*0xaa1888*/ void ShowMockShareDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId);
                /*0xaa18f4*/ void ShowMockFriendFinderDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId);
                /*0xaa1714*/ void ShowEmptyMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId, string title);
            }

            interface IEditorWrapper
            {
                void Init();
                void ShowLoginMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId, string permissions);
                void ShowAppRequestMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId);
                void ShowGameGroupCreateMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId);
                void ShowGameGroupJoinMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId);
                void ShowPayMockDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string callbackId);
                void ShowMockShareDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId);
                void ShowMockFriendFinderDialog(Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback, string subTitle, string callbackId);
            }

            namespace Dialogs
            {
                class EmptyMockDialog : Facebook.Unity.Editor.EditorFacebookMockDialog
                {
                    /*0x40*/ string <EmptyDialogTitle>k__BackingField;

                    /*0xaa1a84*/ EmptyMockDialog();
                    /*0xaa1904*/ string get_EmptyDialogTitle();
                    /*0xaa190c*/ void set_EmptyDialogTitle(string value);
                    /*0xaa1914*/ string get_DialogTitle();
                    /*0xaa191c*/ void DoGui();
                    /*0xaa1920*/ void SendSuccessResult();
                }

                class MockLoginDialog : Facebook.Unity.Editor.EditorFacebookMockDialog
                {
                    /*0x40*/ string accessToken;

                    /*0xaa2078*/ MockLoginDialog();
                    /*0xaa1a8c*/ string get_DialogTitle();
                    /*0xaa1acc*/ void DoGui();
                    /*0xaa1cfc*/ void SendSuccessResult();

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ Facebook.Unity.Editor.Dialogs.MockLoginDialog <>4__this;
                        /*0x18*/ string graphDomain;

                        /*0xaa2070*/ <>c__DisplayClass4_0();
                        /*0xaa20d0*/ void <SendSuccessResult>b__0(Facebook.Unity.IGraphResult graphResult);
                    }

                    class <>c__DisplayClass4_1
                    {
                        /*0x10*/ string facebookID;
                        /*0x18*/ Facebook.Unity.Editor.Dialogs.MockLoginDialog.<> CS$<>8__locals1;

                        /*0xaa2410*/ <>c__DisplayClass4_1();
                        /*0xaa2418*/ void <SendSuccessResult>b__1(Facebook.Unity.IGraphResult permResult);
                    }
                }

                class MockShareDialog : Facebook.Unity.Editor.EditorFacebookMockDialog
                {
                    /*0x40*/ string <SubTitle>k__BackingField;

                    /*0xaa3220*/ MockShareDialog();
                    /*0xaa2dc8*/ string get_SubTitle();
                    /*0xaa2dd0*/ void set_SubTitle(string value);
                    /*0xaa2dd8*/ string get_DialogTitle();
                    /*0xaa2e44*/ void DoGui();
                    /*0xaa2e48*/ void SendSuccessResult();
                    /*0xaa30d4*/ void SendCancelResult();
                    /*0xaa2fec*/ string GenerateFakePostID();
                }
            }
        }

        namespace Mobile
        {
            interface IMobileFacebook : Facebook.Unity.IFacebook
            {
                Facebook.Unity.ShareDialogMode get_ShareDialogMode();
                void set_ShareDialogMode(Facebook.Unity.ShareDialogMode value);
                string get_UserID();
                void set_UserID(string value);
                void UpdateUserProperties(System.Collections.Generic.Dictionary<string, string> parameters);
                void FetchDeferredAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback);
                bool IsImplicitPurchaseLoggingEnabled();
                void SetPushNotificationsDeviceTokenString(string token);
                void SetAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled);
                void SetAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled);
                void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
                void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
            }

            interface IMobileFacebookCallbackHandler : Facebook.Unity.IFacebookCallbackHandler
            {
                void OnFetchDeferredAppLinkComplete(string message);
                void OnRefreshCurrentAccessTokenComplete(string message);
                void OnFriendFinderComplete(string message);
                void OnUploadImageToMediaLibraryComplete(string message);
                void OnUploadVideoToMediaLibraryComplete(string message);
            }

            interface IMobileFacebookImplementation : Facebook.Unity.Mobile.IMobileFacebook, Facebook.Unity.IFacebook, Facebook.Unity.Mobile.IMobileFacebookResultHandler, Facebook.Unity.IFacebookResultHandler
            {
            }

            interface IMobileFacebookResultHandler : Facebook.Unity.IFacebookResultHandler
            {
                void OnFetchDeferredAppLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnRefreshCurrentAccessTokenComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnFriendFinderComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnUploadImageToMediaLibraryComplete(Facebook.Unity.ResultContainer resultContainer);
                void OnUploadVideoToMediaLibraryComplete(Facebook.Unity.ResultContainer resultContainer);
            }

            class MobileFacebook : Facebook.Unity.FacebookBase, Facebook.Unity.Mobile.IMobileFacebookImplementation, Facebook.Unity.Mobile.IMobileFacebook, Facebook.Unity.IFacebook, Facebook.Unity.Mobile.IMobileFacebookResultHandler, Facebook.Unity.IFacebookResultHandler
            {
                static string CallbackIdKey = "callback_id";
                /*0x28*/ Facebook.Unity.ShareDialogMode shareDialogMode;

                static /*0xaa3784*/ System.Collections.Generic.IDictionary<string, object> DeserializeMessage(string message);
                static /*0xaa3830*/ string SerializeDictionary(System.Collections.Generic.IDictionary<string, object> dict);
                static /*0xaa3884*/ bool TryGetCallbackId(System.Collections.Generic.IDictionary<string, object> result, ref string callbackId);
                static /*0xaa399c*/ bool TryGetError(System.Collections.Generic.IDictionary<string, object> result, ref string errorMessage);
                /*0xaa3228*/ MobileFacebook(Facebook.Unity.CallbackManager callbackManager);
                /*0xaa3250*/ Facebook.Unity.ShareDialogMode get_ShareDialogMode();
                /*0xaa3258*/ void set_ShareDialogMode(Facebook.Unity.ShareDialogMode value);
                string get_UserID();
                void set_UserID(string value);
                void UpdateUserProperties(System.Collections.Generic.Dictionary<string, string> parameters);
                void FetchDeferredAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback);
                bool IsImplicitPurchaseLoggingEnabled();
                void SetAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled);
                void SetAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled);
                void SetPushNotificationsDeviceTokenString(string token);
                /*0xaa326c*/ void OnLoginComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa32e8*/ void OnGetAppLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa335c*/ void OnAppRequestsComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa33d0*/ void OnFetchDeferredAppLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa3444*/ void OnShareLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa34b8*/ void OnRefreshCurrentAccessTokenComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa3568*/ void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
                /*0xaa35a8*/ void OnFriendFinderComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa361c*/ void OnUploadImageToMediaLibraryComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa3690*/ void OnUploadVideoToMediaLibraryComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaa3704*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                /*0xaa3744*/ void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                void SetShareDialogMode(Facebook.Unity.ShareDialogMode mode);
            }

            class MobileFacebookGameObject : Facebook.Unity.FacebookGameObject, Facebook.Unity.Mobile.IMobileFacebookCallbackHandler, Facebook.Unity.IFacebookCallbackHandler
            {
                /*0xaa3fb8*/ MobileFacebookGameObject();
                /*0xaa3ab4*/ Facebook.Unity.Mobile.IMobileFacebookImplementation get_MobileFacebook();
                /*0xaa3b20*/ void OnFetchDeferredAppLinkComplete(string message);
                /*0xaa3c08*/ void OnRefreshCurrentAccessTokenComplete(string message);
                /*0xaa3cf4*/ void OnFriendFinderComplete(string message);
                /*0xaa3de0*/ void OnUploadImageToMediaLibraryComplete(string message);
                /*0xaa3ecc*/ void OnUploadVideoToMediaLibraryComplete(string message);
            }

            namespace IOS
            {
                interface IIOSWrapper
                {
                    void Init(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix);
                    void LogInWithReadPermissions(int requestId, string scope);
                    void LogInWithPublishPermissions(int requestId, string scope);
                    void LogOut();
                    void SetPushNotificationsDeviceTokenString(string token);
                    void SetShareDialogMode(int mode);
                    void ShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL);
                    void FeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource);
                    void AppRequest(int requestId, string message, string actionType, string objectId, string[] to, int toLength, string filters, string[] excludeIds, int excludeIdsLength, bool hasMaxRecipients, int maxRecipients, string data, string title);
                    void FBAppEventsActivateApp();
                    void LogAppEvent(string logEvent, double valueToSum, int numParams, string[] paramKeys, string[] paramVals);
                    void LogPurchaseAppEvent(double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals);
                    void FBAppEventsSetLimitEventUsage(bool limitEventUsage);
                    void FBAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled);
                    void FBAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabledID);
                    void GetAppLink(int requestId);
                    void RefreshCurrentAccessToken(int requestId);
                    string FBSdkVersion();
                    void FBSetUserID(string userID);
                    string FBGetUserID();
                    void OpenFriendFinderDialog(int requestId);
                    void UpdateUserProperties(int numParams, string[] paramKeys, string[] paramVals);
                    void UploadImageToMediaLibrary(int requestId, string caption, string mediaUri, bool shouldLaunchMediaDialog);
                    void UploadVideoToMediaLibrary(int requestId, string caption, string videoUri);
                    void FetchDeferredAppLink(int requestId);
                }

                class IOSFacebook : Facebook.Unity.Mobile.MobileFacebook
                {
                    static string CancelledResponse = "{"cancelled":true}";
                    /*0x2c*/ bool limitEventUsage;
                    /*0x30*/ Facebook.Unity.Mobile.IOS.IIOSWrapper iosWrapper;
                    /*0x38*/ string userID;

                    static /*0xaa4038*/ Facebook.Unity.Mobile.IOS.IIOSWrapper GetIOSWrapper();
                    static /*0xaa53dc*/ Facebook.Unity.Mobile.IOS.IOSFacebook.NativeDict MarshallDict(System.Collections.Generic.Dictionary<string, object> dict);
                    static /*0xaa4654*/ Facebook.Unity.Mobile.IOS.IOSFacebook.NativeDict MarshallDict(System.Collections.Generic.Dictionary<string, string> dict);
                    /*0xaa3fc0*/ IOSFacebook();
                    /*0xaa40f0*/ IOSFacebook(Facebook.Unity.Mobile.IOS.IIOSWrapper iosWrapper, Facebook.Unity.CallbackManager callbackManager);
                    /*0xaa4120*/ bool get_LimitEventUsage();
                    /*0xaa4128*/ void set_LimitEventUsage(bool value);
                    /*0xaa41e4*/ void SetAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled);
                    /*0xaa4290*/ void SetAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled);
                    /*0xaa433c*/ void SetPushNotificationsDeviceTokenString(string token);
                    /*0xaa43e8*/ string get_SDKName();
                    /*0xaa4428*/ string get_SDKVersion();
                    /*0xaa44cc*/ string get_UserID();
                    /*0xaa44d4*/ void set_UserID(string value);
                    /*0xaa4584*/ void UpdateUserProperties(System.Collections.Generic.Dictionary<string, string> parameters);
                    /*0xa92250*/ void Init(string appId, bool frictionlessRequests, string iosURLSuffix, Facebook.Unity.HideUnityDelegate hideUnityDelegate, Facebook.Unity.InitDelegate onInitComplete);
                    /*0xaa4924*/ void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                    /*0xaa4a14*/ void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                    /*0xaa4b04*/ void LogOut();
                    /*0xaa4bdc*/ void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
                    /*0xaa4ef8*/ void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                    /*0xaa501c*/ void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                    /*0xaa5208*/ void AppEventsLogEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
                    /*0xaa56cc*/ void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
                    /*0xaa57b8*/ bool IsImplicitPurchaseLoggingEnabled();
                    /*0xaa57c0*/ void ActivateApp(string appId);
                    /*0xaa5864*/ void FetchDeferredAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                    /*0xaa5940*/ void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                    /*0xaa5a50*/ void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
                    /*0xaa5b60*/ void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback);
                    /*0xaa5c70*/ void SetShareDialogMode(Facebook.Unity.ShareDialogMode mode);
                    /*0xaa5d1c*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                    /*0xaa5e78*/ void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                    int AddCallback<T>(Facebook.Unity.FacebookDelegate<T> callback);

                    enum FBInsightsFlushBehavior
                    {
                        FBInsightsFlushBehaviorAuto = 0,
                        FBInsightsFlushBehaviorExplicitOnly = 1,
                    }

                    class NativeDict
                    {
                        /*0x10*/ int <NumEntries>k__BackingField;
                        /*0x18*/ string[] <Keys>k__BackingField;
                        /*0x20*/ string[] <Values>k__BackingField;

                        /*0xaa5fc4*/ NativeDict();
                        /*0xaa5fe4*/ int get_NumEntries();
                        /*0xaa5fec*/ void set_NumEntries(int value);
                        /*0xaa5ff4*/ string[] get_Keys();
                        /*0xaa5ffc*/ void set_Keys(string[] value);
                        /*0xaa6004*/ string[] get_Values();
                        /*0xaa600c*/ void set_Values(string[] value);
                    }
                }

                class IOSFacebookGameObject : Facebook.Unity.Mobile.MobileFacebookGameObject
                {
                    /*0xaa6014*/ IOSFacebookGameObject();
                }

                class IOSFacebookLoader : Facebook.Unity.FB.CompiledFacebookLoader
                {
                    /*0xaa60a8*/ IOSFacebookLoader();
                    /*0xaa601c*/ Facebook.Unity.FacebookGameObject get_FBGameObject();
                }
            }

            namespace Android
            {
                class AndroidFacebook : Facebook.Unity.Mobile.MobileFacebook
                {
                    static string LoginPermissionsKey = "scope";
                    /*0x2c*/ bool limitEventUsage;
                    /*0x30*/ Facebook.Unity.Mobile.Android.IAndroidWrapper androidWrapper;
                    /*0x38*/ string userID;
                    /*0x40*/ string <KeyHash>k__BackingField;

                    static /*0xaa6120*/ Facebook.Unity.Mobile.Android.IAndroidWrapper GetAndroidWrapper();
                    /*0xaa60b0*/ AndroidFacebook();
                    /*0xaa61d8*/ AndroidFacebook(Facebook.Unity.Mobile.Android.IAndroidWrapper androidWrapper, Facebook.Unity.CallbackManager callbackManager);
                    /*0xaa624c*/ string get_KeyHash();
                    /*0xaa6254*/ void set_KeyHash(string value);
                    /*0xaa625c*/ bool get_LimitEventUsage();
                    /*0xaa6264*/ void set_LimitEventUsage(bool value);
                    /*0xaa63ec*/ string get_UserID();
                    /*0xaa63f4*/ void set_UserID(string value);
                    /*0xaa6450*/ void UpdateUserProperties(System.Collections.Generic.Dictionary<string, string> parameters);
                    /*0xaa6604*/ void SetAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled);
                    /*0xaa6670*/ void SetAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled);
                    /*0xaa66dc*/ void SetPushNotificationsDeviceTokenString(string token);
                    /*0xaa6734*/ string get_SDKName();
                    /*0xaa6774*/ string get_SDKVersion();
                    /*0xa92428*/ void Init(string appId, Facebook.Unity.HideUnityDelegate hideUnityDelegate, Facebook.Unity.InitDelegate onInitComplete);
                    /*0xaa6854*/ void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                    /*0xaa6964*/ void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                    /*0xaa6a74*/ void LogOut();
                    /*0xaa6b44*/ void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
                    /*0xaa6e3c*/ void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                    /*0xaa6fe0*/ void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                    /*0xaa71f8*/ void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                    /*0xaa72b0*/ void ClearAppLink();
                    /*0xaa72fc*/ void AppEventsLogEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
                    /*0xaa74d0*/ void AppEventsLogPurchase(float logPurchase, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
                    /*0xaa766c*/ bool IsImplicitPurchaseLoggingEnabled();
                    /*0xaa7750*/ void ActivateApp(string appId);
                    /*0xaa779c*/ void FetchDeferredAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                    /*0xaa787c*/ void RefreshCurrentAccessToken(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAccessTokenRefreshResult> callback);
                    /*0xaa7934*/ void OpenFriendFinderDialog(Facebook.Unity.FacebookDelegate<Facebook.Unity.IGamingServicesFriendFinderResult> callback);
                    /*0xaa79ec*/ void UploadImageToMediaLibrary(string caption, System.Uri imageUri, bool shouldLaunchMediaDialog, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                    /*0xaa7b70*/ void UploadVideoToMediaLibrary(string caption, System.Uri videoUri, Facebook.Unity.FacebookDelegate<Facebook.Unity.IMediaUploadResult> callback);
                    /*0xaa7cb0*/ void SetShareDialogMode(Facebook.Unity.ShareDialogMode mode);
                    /*0xaa62d4*/ void CallFB(string method, string args);

                    class JavaMethodCall<T> : Facebook.Unity.MethodCall<T>
                    {
                        /*0x0*/ Facebook.Unity.Mobile.Android.AndroidFacebook androidImpl;

                        JavaMethodCall(Facebook.Unity.Mobile.Android.AndroidFacebook androidImpl, string methodName);
                        void Call(Facebook.Unity.MethodArguments args);
                    }
                }

                class AndroidFacebookGameObject : Facebook.Unity.Mobile.MobileFacebookGameObject
                {
                    /*0xaa7e9c*/ AndroidFacebookGameObject();
                    /*0xaa7d44*/ void OnAwake();
                    /*0xaa7d48*/ void OnEnable();
                    /*0xaa7dec*/ void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
                    /*0xaa7df0*/ void OnDisable();
                    /*0xaa7e94*/ void onPurchaseCompleteHandler(object data);
                }

                class AndroidFacebookLoader : Facebook.Unity.FB.CompiledFacebookLoader
                {
                    /*0xaa7f30*/ AndroidFacebookLoader();
                    /*0xaa7ea4*/ Facebook.Unity.FacebookGameObject get_FBGameObject();
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
            class CanvasFacebook : Facebook.Unity.FacebookBase, Facebook.Unity.Canvas.ICanvasFacebookImplementation, Facebook.Unity.Canvas.ICanvasFacebook, Facebook.Unity.IPayFacebook, Facebook.Unity.IFacebook, Facebook.Unity.Canvas.ICanvasFacebookResultHandler, Facebook.Unity.IFacebookResultHandler
            {
                static string MethodAppRequests = "apprequests";
                static string MethodFeed = "feed";
                static string MethodPay = "pay";
                static string CancelledResponse = "{"cancelled":true}";
                static string FacebookConnectURL = "https://connect.facebook.net";
                static string AuthResponseKey = "authResponse";
                /*0x28*/ string appId;
                /*0x30*/ string appLinkUrl;
                /*0x38*/ Facebook.Unity.Canvas.ICanvasJSWrapper canvasJSWrapper;
                /*0x40*/ Facebook.Unity.HideUnityDelegate onHideUnityDelegate;
                /*0x48*/ bool <LimitEventUsage>k__BackingField;

                static /*0xaa7fb0*/ Facebook.Unity.Canvas.ICanvasJSWrapper GetCanvasJSWrapper();
                static /*0xaa96dc*/ void FormatAuthResponse(Facebook.Unity.ResultContainer result, Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback);
                /*0xaa7f38*/ CanvasFacebook();
                /*0xaa8068*/ CanvasFacebook(Facebook.Unity.Canvas.ICanvasJSWrapper canvasJSWrapper, Facebook.Unity.CallbackManager callbackManager);
                /*0xaa8098*/ bool get_LimitEventUsage();
                /*0xaa80a0*/ void set_LimitEventUsage(bool value);
                /*0xaa80ac*/ string get_SDKName();
                /*0xaa80ec*/ string get_SDKVersion();
                /*0xaa818c*/ string get_SDKUserAgent();
                /*0xa91d90*/ void Init(string appId, bool cookie, bool logging, bool status, bool xfbml, string channelUrl, string authResponse, bool frictionlessRequests, string javascriptSDKLocale, bool loadDebugJSSDK, Facebook.Unity.HideUnityDelegate hideUnityDelegate, Facebook.Unity.InitDelegate onInitComplete);
                /*0xaa844c*/ void LogInWithPublishPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                /*0xaa8598*/ void LogInWithReadPermissions(System.Collections.Generic.IEnumerable<string> permissions, Facebook.Unity.FacebookDelegate<Facebook.Unity.ILoginResult> callback);
                /*0xaa86e4*/ void LogOut();
                /*0xaa87bc*/ void AppRequest(string message, System.Nullable<Facebook.Unity.OGActionType> actionType, string objectId, System.Collections.Generic.IEnumerable<string> to, System.Collections.Generic.IEnumerable<object> filters, System.Collections.Generic.IEnumerable<string> excludeIds, System.Nullable<int> maxRecipients, string data, string title, Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult> callback);
                /*0xaa8ad4*/ void ActivateApp(string appId);
                /*0xaa8b78*/ void ShareLink(System.Uri contentURL, string contentTitle, string contentDescription, System.Uri photoURL, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                /*0xaa8d34*/ void FeedShare(string toId, System.Uri link, string linkName, string linkCaption, string linkDescription, System.Uri picture, string mediaSource, Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult> callback);
                /*0xaa8f60*/ void Pay(string product, string action, int quantity, System.Nullable<int> quantityMin, System.Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                /*0xaa927c*/ void PayWithProductId(string productId, string action, int quantity, System.Nullable<int> quantityMin, System.Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                /*0xaa92c0*/ void PayWithProductId(string productId, string action, string developerPayload, string testCurrency, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                /*0xaa9304*/ void GetAppLink(Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppLinkResult> callback);
                /*0xaa9458*/ void AppEventsLogEvent(string logEvent, System.Nullable<float> valueToSum, System.Collections.Generic.Dictionary<string, object> parameters);
                /*0xaa9554*/ void AppEventsLogPurchase(float purchaseAmount, string currency, System.Collections.Generic.Dictionary<string, object> parameters);
                /*0xaa9650*/ void OnLoginComplete(Facebook.Unity.ResultContainer result);
                /*0xaa9ef8*/ void OnGetAppLinkComplete(Facebook.Unity.ResultContainer message);
                /*0xaa9f38*/ void OnFacebookAuthResponseChange(string responseJsonData);
                /*0xaa9f98*/ void OnFacebookAuthResponseChange(Facebook.Unity.ResultContainer resultContainer);
                /*0xaaa078*/ void OnPayComplete(string responseJsonData);
                /*0xaaa0e8*/ void OnPayComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaaa15c*/ void OnAppRequestsComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaaa1d0*/ void OnShareLinkComplete(Facebook.Unity.ResultContainer resultContainer);
                /*0xaaa244*/ void OnUrlResponse(string url);
                /*0xaaa24c*/ void OnHideUnity(bool isGameShown);
                /*0xaa8fa0*/ void PayImpl(string product, string productId, string action, int quantity, System.Nullable<int> quantityMin, System.Nullable<int> quantityMax, string requestId, string pricepointId, string testCurrency, string developerPayload, Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult> callback);
                /*0xaaa274*/ void <OnLoginComplete>b__37_0(Facebook.Unity.ResultContainer formattedResponse);

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

                    static /*0xaaa2f0*/ <>c();
                    /*0xaaa354*/ <>c();
                    /*0xaaa35c*/ void <OnFacebookAuthResponseChange>b__40_0(Facebook.Unity.ResultContainer formattedResponse);
                }

                class <>c__DisplayClass47_0
                {
                    /*0x10*/ Facebook.Unity.ResultContainer result;
                    /*0x18*/ Facebook.Unity.Utilities.Callback<Facebook.Unity.ResultContainer> callback;

                    /*0xaaa26c*/ <>c__DisplayClass47_0();
                    /*0xaaa3f0*/ void <FormatAuthResponse>b__0(Facebook.Unity.IGraphResult r);
                }
            }

            class CanvasFacebookGameObject : Facebook.Unity.FacebookGameObject, Facebook.Unity.Canvas.ICanvasFacebookCallbackHandler, Facebook.Unity.IFacebookCallbackHandler
            {
                /*0xaab024*/ CanvasFacebookGameObject();
                /*0xaaabb0*/ Facebook.Unity.Canvas.ICanvasFacebookImplementation get_CanvasFacebookImpl();
                /*0xaaac1c*/ void OnPayComplete(string result);
                /*0xaaad04*/ void OnFacebookAuthResponseChange(string message);
                /*0xaaadf0*/ void OnUrlResponse(string message);
                /*0xaaaea4*/ void OnHideUnity(bool hide);
                /*0xaaaf58*/ void OnAwake();
            }

            class CanvasFacebookLoader : Facebook.Unity.FB.CompiledFacebookLoader
            {
                /*0xaab0b8*/ CanvasFacebookLoader();
                /*0xaab02c*/ Facebook.Unity.FacebookGameObject get_FBGameObject();
            }

            interface ICanvasFacebook : Facebook.Unity.IPayFacebook, Facebook.Unity.IFacebook
            {
            }

            interface ICanvasFacebookCallbackHandler : Facebook.Unity.IFacebookCallbackHandler
            {
                void OnPayComplete(string message);
                void OnFacebookAuthResponseChange(string message);
                void OnUrlResponse(string message);
                void OnHideUnity(bool hide);
            }

            interface ICanvasFacebookImplementation : Facebook.Unity.Canvas.ICanvasFacebook, Facebook.Unity.IPayFacebook, Facebook.Unity.IFacebook, Facebook.Unity.Canvas.ICanvasFacebookResultHandler, Facebook.Unity.IFacebookResultHandler
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

                /*0xaab698*/ JsBridge();
                /*0xaab0c0*/ void Start();
                /*0xaab110*/ void OnLoginComplete(string responseJsonData);
                /*0xaab1bc*/ void OnFacebookAuthResponseChange(string responseJsonData);
                /*0xaab268*/ void OnPayComplete(string responseJsonData);
                /*0xaab310*/ void OnAppRequestsComplete(string responseJsonData);
                /*0xaab3bc*/ void OnShareLinkComplete(string responseJsonData);
                /*0xaab468*/ void OnFacebookFocus(string state);
                /*0xaab544*/ void OnInitComplete(string responseJsonData);
                /*0xaab5ec*/ void OnUrlResponse(string url);
            }
        }
    }
}
