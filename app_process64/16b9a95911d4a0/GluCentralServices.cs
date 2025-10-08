class <Module>
{
}

namespace Csdk
{
    namespace GluCentralServices
    {
        class TagCallback : System.MulticastDelegate
        {
            /*0x30358a4*/ TagCallback(object object, nint method);
            /*0x3035958*/ void Invoke(string newTag, string tagMetadata);
        }

        class PayloadCallback : System.MulticastDelegate
        {
            /*0x303596c*/ PayloadCallback(object object, nint method);
            /*0x3035a74*/ void Invoke(Csdk.GluCentralServices.PayloadResult payloadResult);
        }

        class EVSCallback : System.MulticastDelegate
        {
            /*0x3035a88*/ EVSCallback(object object, nint method);
            /*0x3035b3c*/ void Invoke(string state, string errorMessage);
        }

        class CustomActionHandler : System.MulticastDelegate
        {
            /*0x3035b50*/ CustomActionHandler(object object, nint method);
            /*0x3035bf0*/ void Invoke(Csdk.GluCentralServices.CustomAction act);
        }

        enum AccountAction
        {
            QUERY = 0,
            DELETE = 1,
            CANCEL_DELETE = 2,
        }

        struct AccountStatus
        {
            /*0x10*/ string Status;
            /*0x18*/ Csdk.GluCentralServices.AccountStatus.ErrorCode Code;
            /*0x20*/ string Error;
            /*0x28*/ System.Collections.Generic.IDictionary<string, string> Extra;

            enum ErrorCode
            {
                Success = 0,
                ErrorNotConnectedToInternet = 1000,
                ErrorInternal = 1001,
                ErrorBadRequest = 4000,
                ErrorRequestTimedOut = 4003,
                ErrorAlreadyInPending = 4009,
                ErrorCancelDeletion = 4012,
                ErrorInvalidJsonResponse = 5000,
            }
        }

        class AccountCallback : System.MulticastDelegate
        {
            /*0x3035c04*/ AccountCallback(object object, nint method);
            /*0x3035ca4*/ void Invoke(Csdk.GluCentralServices.AccountStatus status);
        }

        enum PrivacyType
        {
            NONE = 0,
            CCPA = 1,
            GDPR = 2,
            AGEGATE = 3,
        }

        enum PrivacyApplyType
        {
            NONE_APPLIES = 0,
            CCPA_APPLIES = 1,
            GDPR_APPLIES = 2,
            AGE_GATE_APPLIES = 3,
        }

        enum PrivacyApplyStatus
        {
            UNDETERMINED = 0,
            DOES_NOT_APPLY = 1,
            APPLY = 2,
        }

        enum UserResponseType
        {
            NONE = 0,
            CCPA_BY_PLAYER = 1,
            GDPR_BY_DEVICE = 2,
            AGE_GATE_BY_DEVICE = 3,
        }

        enum UserResponseStatus
        {
            UNDETERMINED = 0,
            PREDETERMINED = 1,
            DENIED = 2,
            ACCEPTED = 3,
        }

        enum UserAgeStatus
        {
            UNDETERMINED = 0,
            UNDERAGE = 1,
            AGEAPPROPRIATE = 2,
        }

        class PrivacyResponseStatus
        {
            /*0x10*/ Csdk.GluCentralServices.PrivacyApplyType applyType;
            /*0x14*/ Csdk.GluCentralServices.PrivacyApplyStatus applyStatus;
            /*0x18*/ Csdk.GluCentralServices.UserResponseType responseType;
            /*0x1c*/ Csdk.GluCentralServices.UserResponseStatus responseStatus;
            /*0x20*/ Csdk.GluCentralServices.UserAgeStatus ageStatus;

            /*0x3035cd8*/ PrivacyResponseStatus(Csdk.GluCentralServices.PrivacyApplyType applyType, Csdk.GluCentralServices.PrivacyApplyStatus applyStatus, Csdk.GluCentralServices.UserResponseType responseType, Csdk.GluCentralServices.UserResponseStatus responseStatus, Csdk.GluCentralServices.UserAgeStatus ageStatus);
        }

        interface IGluCentralServices : System.IDisposable
        {
            /*0x1f30214*/ Csdk.GluCentralServices.IProfileService get_ProfileService();
            /*0x1f30214*/ Csdk.GluCentralServices.IConsent get_Consent();
            /*0x1f30ebc*/ void SetUserID(string userID);
            /*0x1f30214*/ string GetIdentityPin();
        }

        interface IEVS
        {
        }

        interface IAccount
        {
        }

        interface IProfileService
        {
            /*0x1f310fc*/ void SetValue(string name, object val, string op);
        }

        interface ITags
        {
        }

        interface IConsent
        {
            /*0x1f30ebc*/ void add_ConsentUpdateReceived(System.Action<Csdk.GluCentralServices.ConsentUpdateResult> value);
            /*0x1f30ebc*/ void remove_ConsentUpdateReceived(System.Action<Csdk.GluCentralServices.ConsentUpdateResult> value);
            /*0x1f30ebc*/ void ConsentFormOverrides(System.Collections.Generic.IDictionary<string, string> overrideText);
            /*0x1f30ebc*/ void Show(string placement);
            /*0x1f2fe14*/ bool IsSettingsUIInteractable();
            /*0x1f2fe14*/ bool IsInternalTargetedAdsUIInteractable();
        }

        class UpdateValueInput
        {
            /*0x10*/ string mName;
            /*0x18*/ string mColType;
            /*0x20*/ string mMapKey;
            /*0x28*/ string mValType;
            /*0x30*/ string mVal;
            /*0x38*/ string mOp;

            /*0x3035d28*/ UpdateValueInput(string name);
            /*0x3035da4*/ Csdk.GluCentralServices.UpdateValueInput ValNumberFromInt64(long val);
            /*0x3035e8c*/ Csdk.GluCentralServices.UpdateValueInput ValNumberFromDouble(double val);
            /*0x3035f54*/ Csdk.GluCentralServices.UpdateValueInput ValNumberFromDecimal(decimal val);
            /*0x3036058*/ Csdk.GluCentralServices.UpdateValueInput ValBool(bool val);
            /*0x30360fc*/ Csdk.GluCentralServices.UpdateValueInput ValString(string val);
            /*0x30361b0*/ Csdk.GluCentralServices.UpdateValueInput ValVersion(System.Version val);
            /*0x3036248*/ Csdk.GluCentralServices.UpdateValueInput ValVersionFromString(string val);
            /*0x30362fc*/ Csdk.GluCentralServices.UpdateValueInput ValTimestamp(System.DateTime val);
            /*0x303639c*/ Csdk.GluCentralServices.UpdateValueInput ValTimestampFromUnixMS(long val);
            /*0x30364e8*/ Csdk.GluCentralServices.UpdateValueInput DoOp(string op);
            /*0x3035e54*/ Csdk.GluCentralServices.UpdateValueInput DoVal(string valType, string val);
        }

        class GluCentralServicesFactory
        {
            /*0x3036740*/ GluCentralServicesFactory();
            /*0x3036504*/ Csdk.GluCentralServices.IGluCentralServices Create(UnityEngine.GameObject gameObject, string jsonConfig, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
            /*0x3036660*/ Csdk.GluCentralServices.IGluCentralServices CreateNative(UnityEngine.GameObject gameObject, string jsonConfig, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
        }

        class ShowConsentResult
        {
            /*0x10*/ string Status;
            /*0x18*/ System.Exception Error;
            /*0x20*/ string Placement;

            /*0x3036748*/ ShowConsentResult(string status, System.Exception error, string placement);
        }

        class ConsentStatus
        {
            /*0x10*/ bool NoticeAccepted;
            /*0x18*/ string DateOfBirth;
            /*0x20*/ bool UnderAge;
            /*0x21*/ bool PreExistingUnderAge;
            /*0x22*/ bool Teen;
            /*0x23*/ bool BehavioralAdsAccepted;
            /*0x24*/ bool PersonalizationAccepted;
            /*0x25*/ bool AppTrackingTransparencyApplies;
            /*0x26*/ bool AppTrackingTransparencyAccepted;

            /*0x30367a8*/ ConsentStatus(bool noticeAccepted, string dateOfBirth, bool behavioralAdsAccepted, bool personalizationAccepted, bool underAge, bool preExistingUnderAge, bool teen, bool appTrackingTransparencyApplies, bool appTrakcingTransparencyAccepted);
        }

        class ConsentUpdateResult
        {
            /*0x10*/ string Placement;
            /*0x18*/ string Error;
            /*0x20*/ bool DoesGDPRApply;
            /*0x21*/ bool DoesCCPAApply;
            /*0x22*/ bool DoesAgeGateApply;
            /*0x23*/ bool IsEligibleForAltPayments;
            /*0x28*/ Csdk.GluCentralServices.ConsentStatus ConsentStatus;

            /*0x303683c*/ ConsentUpdateResult(string placement, string error, bool doesGDPRApply, bool doesAgeGateApply, bool doesCCPAApply, bool isEligibleForAltPayments, Csdk.GluCentralServices.ConsentStatus consentStatus);
        }

        class PayloadResult
        {
            /*0x10*/ string TagName;
            /*0x18*/ string PayloadName;
            /*0x20*/ string PayloadMetadata;
            /*0x28*/ string PayloadPath;

            /*0x30368bc*/ PayloadResult(string tagName, string payloadName, string payloadMetadata, string payloadPath);
        }

        struct CustomAction
        {
            /*0x10*/ string Action;
            /*0x18*/ System.Collections.Generic.IDictionary<string, string> Data;
        }

        namespace Implementation
        {
            class NativeGluCentralServices : UnityEngine.MonoBehaviour, Csdk.GluCentralServices.IGluCentralServices, System.IDisposable, Csdk.GluCentralServices.IEVS, Csdk.GluCentralServices.IProfileService, Csdk.GluCentralServices.ITags, Csdk.GluCentralServices.IConsent, Csdk.GluCentralServices.IAccount
            {
                static string DLLImportName = "glucentralservices";
                /*0x20*/ nint nativeService;
                /*0x28*/ System.Collections.Generic.IDictionary<string, Csdk.GluCentralServices.TagCallback> mTagDelegates;
                /*0x30*/ System.Collections.Generic.IDictionary<string, Csdk.GluCentralServices.PayloadCallback> mPayloadDelegates;
                /*0x38*/ System.Collections.Generic.IDictionary<string, Csdk.GluCentralServices.CustomActionHandler> mCustomActionHandlers;
                /*0x40*/ System.Collections.Generic.IDictionary<string, Csdk.GluCentralServices.EVSCallback> mEVSDelegates;
                /*0x48*/ System.Collections.Generic.IDictionary<string, Csdk.GluCentralServices.AccountCallback> mAccountDelegates;
                /*0x50*/ long mIDCounter;
                /*0x58*/ System.Action<Csdk.GluCentralServices.ShowConsentResult> ShowConsentReceived;
                /*0x60*/ System.Action<Csdk.GluCentralServices.ConsentUpdateResult> ConsentUpdateReceived;
                /*0x68*/ System.Action<string> TriggerEventShown;
                /*0x70*/ System.Action<string> TriggerEventDismissed;

                static /*0x3037104*/ string JSONArg(object val);
                static /*0x3037110*/ nint GluCentralServices_createCentralServices(string jsonConfig, string runtimeConfig, string gameObject);
                static /*0x3039bf8*/ void GluCentralServices_destroy(nint service);
                static /*0x3037248*/ void GluCentralServices_setUserID(nint service, string userID);
                static /*0x30372e8*/ int GluCentralServices_getDeviceTier(nint service);
                static /*0x30373cc*/ nint GluCentralServices_getIdentityPin(nint service);
                static /*0x3037614*/ nint GluCentralServices_getPrivacyResponseStatus(nint service, int type);
                static /*0x3037994*/ void GluCentralServices_triggerEvent(nint service, string evt);
                static /*0x3037d5c*/ void GluCentralServices_registerCustomActionHandler(nint service, string action, string gameObject);
                static /*0x30384a0*/ void GluCentralServices_ProfileService_updateValue(nint services, string name, string colType, string mapKey, string valType, string val, string op);
                static /*0x30388dc*/ void GluCentralServices_Tags_getTag(nint services, string id, string tagName, string currentTag, string gameObject);
                static /*0x30389fc*/ void GluCentralServices_Consent_consentFormOverrides(nint services, string overrideText);
                static /*0x3038ad4*/ void GluCentralServices_Consent_show(nint services, string placement, string gameObject);
                static /*0x3038b98*/ bool GluCentralServices_Consent_isSettingsUIInteractable(nint services);
                static /*0x3038c24*/ bool GluCentralServices_Consent_isInternalTargetedAdsUIInteractable(nint services);
                static /*0x3038cb0*/ bool GluCentralServices_Consent_isCmpConsentEnabled(nint services);
                static /*0x3038fd0*/ void GluCentralServices_EVS_requestPin(nint services, string id, string email, string gameObject);
                static /*0x3039320*/ void GluCentralServices_EVS_verifyPin(nint services, string id, string pin, string email, string gameObject);
                static /*0x3039634*/ void GluCentralServices_EVS_checkState(nint services, string id, string gameObject);
                static /*0x3039930*/ void GluCentralServices_Account_requestAccountOperation(nint services, string id, int action, string extraIds, string gameObject);
                /*0x303c3a4*/ NativeGluCentralServices();
                /*0x3036930*/ void add_ShowConsentReceived(System.Action<Csdk.GluCentralServices.ShowConsentResult> value);
                /*0x30369e0*/ void remove_ShowConsentReceived(System.Action<Csdk.GluCentralServices.ShowConsentResult> value);
                /*0x3036a90*/ void add_ConsentUpdateReceived(System.Action<Csdk.GluCentralServices.ConsentUpdateResult> value);
                /*0x3036b40*/ void remove_ConsentUpdateReceived(System.Action<Csdk.GluCentralServices.ConsentUpdateResult> value);
                /*0x3036bf0*/ void add_TriggerEventShown(System.Action<string> value);
                /*0x3036ca0*/ void remove_TriggerEventShown(System.Action<string> value);
                /*0x3036d50*/ void add_TriggerEventDismissed(System.Action<string> value);
                /*0x3036e00*/ void remove_TriggerEventDismissed(System.Action<string> value);
                /*0x3036eb0*/ Csdk.GluCentralServices.IProfileService get_ProfileService();
                /*0x3036eb4*/ Csdk.GluCentralServices.ITags get_Tags();
                /*0x3036eb8*/ Csdk.GluCentralServices.IConsent get_Consent();
                /*0x3036ebc*/ Csdk.GluCentralServices.IEVS get_EVS();
                /*0x3036ec0*/ Csdk.GluCentralServices.IAccount get_Account();
                /*0x30366dc*/ void Initialize(string jsonConfig, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
                /*0x30371e8*/ void Dispose();
                /*0x3037240*/ void SetUserID(string userID);
                /*0x30372e0*/ int GetDeviceTier();
                /*0x3037364*/ string GetIdentityPin();
                /*0x3037448*/ Csdk.GluCentralServices.PrivacyResponseStatus GetPrivacyResponseStatus(Csdk.GluCentralServices.PrivacyType type);
                /*0x303798c*/ void TriggerEvent(string evt);
                /*0x3037a2c*/ void RegisterCustomActionHandler(string action, Csdk.GluCentralServices.CustomActionHandler h);
                /*0x3037e18*/ void SetValue(string name, object val, string op);
                /*0x3038438*/ void UpdateValue(Csdk.GluCentralServices.UpdateValueInput val);
                /*0x30385dc*/ void GetTag(string tagName, string currentTag, Csdk.GluCentralServices.TagCallback tagCallback, Csdk.GluCentralServices.PayloadCallback payloadCallback);
                /*0x30389d8*/ void ConsentFormOverrides(System.Collections.Generic.IDictionary<string, string> overrideText);
                /*0x3038a94*/ void Show(string placement);
                /*0x3038b90*/ bool IsSettingsUIInteractable();
                /*0x3038c1c*/ bool IsInternalTargetedAdsUIInteractable();
                /*0x3038ca8*/ bool IsCmpConsentEnabled();
                /*0x3038da4*/ void RequestPin(string email, Csdk.GluCentralServices.EVSCallback callback);
                /*0x30390a8*/ void VerifyPin(string pin, string email, Csdk.GluCentralServices.EVSCallback callback);
                /*0x303941c*/ void CheckState(Csdk.GluCentralServices.EVSCallback callback);
                /*0x30396f0*/ void RequestAccountOperation(Csdk.GluCentralServices.AccountAction action, Csdk.GluCentralServices.AccountCallback callback, System.Collections.Generic.IDictionary<string, string> extraIds);
                /*0x3039a18*/ void Awake();
                /*0x3039bdc*/ void OnDestroy();
                /*0x3039c74*/ void Update();
                /*0x3039c78*/ void OnTagReceived(string json);
                /*0x3039f3c*/ void OnPayloadReceived(string json);
                /*0x303a230*/ void OnEVSCallback(string json);
                /*0x303a494*/ void OnAccountCallback(string json);
                /*0x303b33c*/ void OnShowConsent(string json);
                /*0x303b508*/ void OnConsentUpdate(string json);
                /*0x303b9e8*/ void OnShowTriggerEvent(string json);
                /*0x303baa0*/ void OnDismissTriggerEvent(string json);
                /*0x303bb58*/ void OnCustomAction(string json);
                /*0x3036ec4*/ string ReplaceMarketplace(string jsonConfig);
            }

            interface ISerializableJsonObject
            {
                /*0x1f30ebc*/ void WriteObject(Csdk.GluCentralServices.Implementation.JsonStringer json);
            }

            interface ISerializableJson
            {
                /*0x1f30ff0*/ void Write(Csdk.GluCentralServices.Implementation.JsonStringer json, string key);
            }

            class JsonStringer
            {
                static /*0x0*/ System.Collections.Generic.IDictionary<char, string> EscapedCharacters;
                /*0x10*/ System.Text.StringBuilder sb;
                /*0x18*/ bool hasElements;

                static /*0x303cf84*/ JsonStringer();
                static /*0x303cd90*/ System.Collections.Generic.IDictionary<char, string> CreateEscapedCharacters();
                /*0x303c3ac*/ JsonStringer();
                /*0x303c418*/ Csdk.GluCentralServices.Implementation.JsonStringer EndArray();
                /*0x303c47c*/ Csdk.GluCentralServices.Implementation.JsonStringer EndObject();
                /*0x303c4b0*/ Csdk.GluCentralServices.Implementation.JsonStringer KeyNull(string key);
                /*0x303c5d0*/ Csdk.GluCentralServices.Implementation.JsonStringer KeyArray(string key);
                /*0x303c62c*/ Csdk.GluCentralServices.Implementation.JsonStringer KeyObject(string key);
                /*0x303c64c*/ Csdk.GluCentralServices.Implementation.JsonStringer KeyValue(string key, bool val);
                /*0x303c6e4*/ Csdk.GluCentralServices.Implementation.JsonStringer KeyValue(string key, long val);
                /*0x303c78c*/ Csdk.GluCentralServices.Implementation.JsonStringer KeyValue(string key, ulong val);
                /*0x303c834*/ Csdk.GluCentralServices.Implementation.JsonStringer KeyValue(string key, double val);
                /*0x303c938*/ Csdk.GluCentralServices.Implementation.JsonStringer KeyValue(string key, decimal val);
                /*0x303ca44*/ Csdk.GluCentralServices.Implementation.JsonStringer KeyValue(string key, string val);
                /*0x303cd74*/ string ToString();
                /*0x303c5f0*/ void DoBeginScope(char scope, string key);
                /*0x303c44c*/ void DoEndScope(char scopeBegin, char scopeEnd);
                /*0x303ca8c*/ void DoAppendString(string val);
                /*0x303c520*/ void PreCommon(string key, bool newHasElements);
            }

            class JsonUtil
            {
                static /*0x3038d34*/ string ToJson(object val);
                static /*0x303cfdc*/ Csdk.GluCentralServices.Implementation.JsonStringer Value(Csdk.GluCentralServices.Implementation.JsonStringer json, object val);
                static /*0x303cfe8*/ Csdk.GluCentralServices.Implementation.JsonStringer KeyValue(Csdk.GluCentralServices.Implementation.JsonStringer json, string key, object val);
                static /*0x303e2e0*/ Csdk.GluCentralServices.Implementation.JsonStringer OptionalKeyValue(Csdk.GluCentralServices.Implementation.JsonStringer json, string key, object val);
                static /*0x303d938*/ Csdk.GluCentralServices.Implementation.JsonStringer DoKeyValue(Csdk.GluCentralServices.Implementation.JsonStringer json, string key, System.Exception e);
                static /*0x303da4c*/ Csdk.GluCentralServices.Implementation.JsonStringer DoKeyValue(Csdk.GluCentralServices.Implementation.JsonStringer json, string key, System.Collections.IList val);
                static /*0x1f3299c*/ Csdk.GluCentralServices.Implementation.JsonStringer DoKeyValue<T>(Csdk.GluCentralServices.Implementation.JsonStringer json, string key, System.Collections.Generic.IDictionary<string, T> val);
                static /*0x303dd1c*/ Csdk.GluCentralServices.Implementation.JsonStringer DoKeyValue(Csdk.GluCentralServices.Implementation.JsonStringer json, string key, System.Collections.IDictionary val);
            }

            namespace Json
            {
                class AJson
                {
                    static /*0x3037698*/ Csdk.GluCentralServices.Implementation.Json.JsonResult ParseString(string str);
                }

                class JsonLexer
                {
                    static /*0x0*/ System.Collections.Generic.IDictionary<char, Csdk.GluCentralServices.Implementation.Json.TokenType> OtherTokens;
                    static /*0x8*/ System.Collections.Generic.IDictionary<char, char> EscapedCharacters;
                    static /*0x10*/ object TrueValue;
                    static /*0x18*/ object FalseValue;
                    /*0x10*/ System.Text.StringBuilder mStringBuilder;
                    /*0x18*/ string mCurrentString;
                    /*0x20*/ int mCurrentStringOffset;

                    static /*0x303f228*/ JsonLexer();
                    static /*0x303e2ec*/ System.Collections.Generic.IEnumerable<Csdk.GluCentralServices.Implementation.Json.JsonToken> ProcessString(string str);
                    static /*0x303e760*/ System.Collections.Generic.IDictionary<char, Csdk.GluCentralServices.Implementation.Json.TokenType> CreateOtherTokens();
                    static /*0x303e8c4*/ System.Collections.Generic.IDictionary<char, char> CreateEscapedCharacters();
                    /*0x303e624*/ JsonLexer();
                    /*0x303e690*/ System.Collections.Generic.IEnumerable<Csdk.GluCentralServices.Implementation.Json.JsonToken> Process(string text);
                    /*0x303e9e0*/ void MunchWhitespaces();
                    /*0x303ea94*/ bool TryMunchString(ref string value);
                    /*0x303eaec*/ bool DoTryMunchString(ref string value);
                    /*0x303ee40*/ bool TryMunchNumber(ref decimal value);
                    /*0x303eff0*/ bool TryMunchBool(ref bool value);
                    /*0x303f0e8*/ bool TryMunchOther(ref Csdk.GluCentralServices.Implementation.Json.TokenType tokenType);
                    /*0x303f08c*/ bool TryMunchKeyword(string str);
                    /*0x303edac*/ System.Text.StringBuilder GetEmptyStringBuilder();
                    /*0x303ea74*/ char PeekCurrentCharacter();
                    /*0x303edf4*/ bool ReadNextCharacter(ref char c);

                    class <Process>d__10 : System.Collections.Generic.IEnumerable<Csdk.GluCentralServices.Implementation.Json.JsonToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Csdk.GluCentralServices.Implementation.Json.JsonToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Csdk.GluCentralServices.Implementation.Json.JsonToken <>2__current;
                        /*0x28*/ int <>l__initialThreadId;
                        /*0x30*/ string text;
                        /*0x38*/ string <>3__text;
                        /*0x40*/ Csdk.GluCentralServices.Implementation.Json.JsonLexer <>4__this;
                        /*0x48*/ string <stringValue>5__2;
                        /*0x50*/ decimal <numberValue>5__3;
                        /*0x60*/ bool <boolValue>5__4;
                        /*0x64*/ Csdk.GluCentralServices.Implementation.Json.TokenType <otherValue>5__5;

                        /*0x303e72c*/ <Process>d__10(int <>1__state);
                        /*0x303f2fc*/ void System.IDisposable.Dispose();
                        /*0x303f300*/ bool MoveNext();
                        /*0x303f68c*/ Csdk.GluCentralServices.Implementation.Json.JsonToken System.Collections.Generic.IEnumerator<Csdk.GluCentralServices.Implementation.Json.JsonToken>.get_Current();
                        /*0x303f698*/ void System.Collections.IEnumerator.Reset();
                        /*0x303f6d0*/ object System.Collections.IEnumerator.get_Current();
                        /*0x303f72c*/ System.Collections.Generic.IEnumerator<Csdk.GluCentralServices.Implementation.Json.JsonToken> System.Collections.Generic.IEnumerable<Csdk.GluCentralServices.Implementation.Json.JsonToken>.GetEnumerator();
                        /*0x303f7e0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                struct JsonNode
                {
                    static /*0x0*/ object ObjectValue;
                    static /*0x8*/ object ArrayValue;
                    static /*0x10*/ object NullValue;
                    /*0x10*/ string Key;
                    /*0x18*/ int Size;
                    /*0x20*/ object Value;

                    static /*0x30401a0*/ JsonNode();
                    static /*0x303fab0*/ Csdk.GluCentralServices.Implementation.Json.JsonNode Create(object value, string key);
                    static /*0x303fb4c*/ Csdk.GluCentralServices.Implementation.Json.JsonNode Object(int size, string key);
                    static /*0x303fbdc*/ Csdk.GluCentralServices.Implementation.Json.JsonNode Array(int size, string key);
                    /*0x303f7e4*/ JsonNode(object value, string key, int size);
                    /*0x303f820*/ bool get_IsObject();
                    /*0x303f888*/ bool get_IsArray();
                    /*0x303f8f0*/ bool get_IsNull();
                    /*0x303f958*/ bool get_IsBoolean();
                    /*0x303f9bc*/ bool get_IsString();
                    /*0x303fa20*/ bool get_IsNumber();
                    /*0x303fc6c*/ decimal AsDecimal();
                    /*0x303fe74*/ string AsString();
                    /*0x303ff98*/ bool AsBoolean();
                }

                class JsonParser
                {
                    /*0x10*/ System.Collections.Generic.IList<Csdk.GluCentralServices.Implementation.Json.JsonNode> mNodes;
                    /*0x18*/ System.Collections.Generic.IEnumerator<Csdk.GluCentralServices.Implementation.Json.JsonToken> mEnum;
                    /*0x20*/ Csdk.GluCentralServices.Implementation.Json.JsonToken mCurrentToken;

                    /*0x303e34c*/ JsonParser();
                    /*0x304026c*/ Csdk.GluCentralServices.Implementation.Json.JsonToken get_CurrentToken();
                    /*0x303e354*/ Csdk.GluCentralServices.Implementation.Json.JsonResult Parse(System.Collections.Generic.IEnumerable<Csdk.GluCentralServices.Implementation.Json.JsonToken> tokens);
                    /*0x30403f0*/ void ParseObject(string key);
                    /*0x3040700*/ void ParseArray(string key);
                    /*0x3040b54*/ string ParseString();
                    /*0x3040b94*/ void ParseValue(string key);
                    /*0x3040a14*/ void Munch(Csdk.GluCentralServices.Implementation.Json.TokenType token);
                    /*0x3040278*/ void MoveNext();
                    /*0x3040d80*/ System.Exception ThrowInvalidJsonException(string message);
                    /*0x30409f8*/ System.Exception ThrowInvalidJsonException(string format, object[] args);
                }

                struct JsonResult : System.Collections.Generic.IEnumerable<Csdk.GluCentralServices.Implementation.Json.JsonResult>, System.Collections.IEnumerable
                {
                    static /*0x0*/ Csdk.GluCentralServices.Implementation.Json.JsonResult Empty;
                    static /*0x10*/ System.Collections.Generic.IList<Csdk.GluCentralServices.Implementation.Json.JsonResult> EmptyList;
                    /*0x10*/ System.Collections.Generic.IList<Csdk.GluCentralServices.Implementation.Json.JsonNode> mNodes;
                    /*0x18*/ int mIndex;
                    /*0x1c*/ int mEnd;

                    static /*0x30413c8*/ JsonResult();
                    static /*0x303792c*/ int op_Implicit(Csdk.GluCentralServices.Implementation.Json.JsonResult result);
                    static /*0x3039edc*/ string op_Implicit(Csdk.GluCentralServices.Implementation.Json.JsonResult result);
                    /*0x3040aec*/ JsonResult(System.Collections.Generic.IList<Csdk.GluCentralServices.Implementation.Json.JsonNode> nodes);
                    /*0x3040dc4*/ JsonResult(System.Collections.Generic.IList<Csdk.GluCentralServices.Implementation.Json.JsonNode> nodes, int index);
                    /*0x3040ea8*/ bool get_HasValue();
                    /*0x303adb8*/ bool get_IsObject();
                    /*0x303b1c0*/ bool get_IsString();
                    /*0x3037730*/ Csdk.GluCentralServices.Implementation.Json.JsonResult get_Item(string key);
                    /*0x303ae78*/ int Count();
                    /*0x303ad28*/ int AsInt32();
                    /*0x3041070*/ decimal AsDecimal();
                    /*0x303b280*/ string AsString();
                    /*0x303b928*/ bool AsBoolean();
                    /*0x304117c*/ System.Collections.Generic.IEnumerable<Csdk.GluCentralServices.Implementation.Json.JsonResult> AsEnumerable();
                    /*0x303afa4*/ System.Collections.Generic.IDictionary<string, Csdk.GluCentralServices.Implementation.Json.JsonResult> AsDictionary();
                    /*0x3041230*/ System.Collections.Generic.IEnumerator<Csdk.GluCentralServices.Implementation.Json.JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluCentralServices.Implementation.Json.JsonResult>.GetEnumerator();
                    /*0x30412fc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x3040eb8*/ Csdk.GluCentralServices.Implementation.Json.JsonNode GetNode();
                    /*0x3040fb0*/ int GetNextNodeIndex(int index);
                    /*0x3040f84*/ Csdk.GluCentralServices.Implementation.Json.JsonResult FromIndex(int index);

                    class <AsEnumerable>d__42 : System.Collections.Generic.IEnumerable<Csdk.GluCentralServices.Implementation.Json.JsonResult>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Csdk.GluCentralServices.Implementation.Json.JsonResult>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Csdk.GluCentralServices.Implementation.Json.JsonResult <>2__current;
                        /*0x28*/ int <>l__initialThreadId;
                        /*0x30*/ Csdk.GluCentralServices.Implementation.Json.JsonResult <>4__this;
                        /*0x40*/ Csdk.GluCentralServices.Implementation.Json.JsonResult <>3__<>4__this;
                        /*0x50*/ int <nodeIndex>5__2;

                        /*0x30411fc*/ <AsEnumerable>d__42(int <>1__state);
                        /*0x3041444*/ void System.IDisposable.Dispose();
                        /*0x3041448*/ bool MoveNext();
                        /*0x3041640*/ Csdk.GluCentralServices.Implementation.Json.JsonResult System.Collections.Generic.IEnumerator<Csdk.GluCentralServices.Implementation.Json.JsonResult>.get_Current();
                        /*0x304164c*/ void System.Collections.IEnumerator.Reset();
                        /*0x3041684*/ object System.Collections.IEnumerator.get_Current();
                        /*0x30416e0*/ System.Collections.Generic.IEnumerator<Csdk.GluCentralServices.Implementation.Json.JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluCentralServices.Implementation.Json.JsonResult>.GetEnumerator();
                        /*0x3041788*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                struct JsonToken
                {
                    /*0x10*/ Csdk.GluCentralServices.Implementation.Json.TokenType Type;
                    /*0x18*/ object Value;

                    /*0x303f67c*/ JsonToken(Csdk.GluCentralServices.Implementation.Json.TokenType type, object value);
                }

                enum TokenType
                {
                    String = 0,
                    Number = 1,
                    Bool = 2,
                    Null = 3,
                    Comma = 4,
                    OpeningCurlyBracket = 5,
                    ClosingCurlyBracket = 6,
                    OpeningSquareBracket = 7,
                    ClosingSquareBracket = 8,
                    Colon = 9,
                    Unknown = 10,
                    Eof = 11,
                }
            }
        }
    }
}
