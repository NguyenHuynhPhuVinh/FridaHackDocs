class <Module>
{
}

namespace Csdk
{
    namespace GluCustomerSupport
    {
        class GluCustomerSupportFactory
        {
            /*0x3041d48*/ GluCustomerSupportFactory();
            /*0x304178c*/ Csdk.GluCustomerSupport.ICustomerSupport CreateCustomerSupport(UnityEngine.GameObject gameObject, string jsonConfig, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
            /*0x30418e8*/ Csdk.GluCustomerSupport.ICustomerSupport CreateAndroidCustomerSupport(UnityEngine.GameObject gameObject, string jsonConfig, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
        }

        interface ICustomerSupport : System.IDisposable
        {
            /*0x1f30ebc*/ void add_QueryNotificationCountEventReceived(System.Action<Csdk.GluCustomerSupport.QueryNotificationCountEvent> value);
            /*0x1f30ebc*/ void remove_QueryNotificationCountEventReceived(System.Action<Csdk.GluCustomerSupport.QueryNotificationCountEvent> value);
            /*0x1f30ebc*/ void add_SessionStartedEventReceived(System.Action<Csdk.GluCustomerSupport.SessionStartedEvent> value);
            /*0x1f30ebc*/ void remove_SessionStartedEventReceived(System.Action<Csdk.GluCustomerSupport.SessionStartedEvent> value);
            /*0x1f30ebc*/ void add_SessionEndedEventReceived(System.Action<Csdk.GluCustomerSupport.SessionEndedEvent> value);
            /*0x1f30ebc*/ void remove_SessionEndedEventReceived(System.Action<Csdk.GluCustomerSupport.SessionEndedEvent> value);
            /*0x1f30ebc*/ void Login(Csdk.GluCustomerSupport.UserInfo info);
            /*0x1f309e4*/ void Logout();
            /*0x1f309e4*/ void QueryNotificationCount();
            /*0x1f30ebc*/ void ShowFAQs(System.Collections.Generic.Dictionary<string, object> options);
            /*0x1f30ebc*/ void ShowConversation(System.Collections.Generic.Dictionary<string, object> options);
            /*0x1f309e4*/ void Close();
            /*0x1f310fc*/ void SetMetadata(System.Collections.Generic.Dictionary<string, object> metadata, System.Collections.Generic.List<object> tags, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> fields);
        }

        class UserInfo : Csdk.GluCustomerSupport.Implementation.ISerializableJsonObject
        {
            /*0x10*/ string UserID;
            /*0x18*/ string UserName;
            /*0x20*/ string UserEmail;
            /*0x28*/ string JwtToken;

            /*0x3041d50*/ UserInfo(string userID, string userName, string userEmail, string jwtToken);
            /*0x3041dc4*/ string ToString();
            /*0x3041eb8*/ void WriteObject(Csdk.GluCustomerSupport.Implementation.JsonStringer json);
        }

        class QueryNotificationCountEvent : Csdk.GluCustomerSupport.Implementation.ISerializableJsonObject
        {
            /*0x10*/ long Count;
            /*0x18*/ System.Exception Error;

            /*0x3042040*/ QueryNotificationCountEvent(long count, System.Exception error);
            /*0x3042078*/ string ToString();
            /*0x30420fc*/ void WriteObject(Csdk.GluCustomerSupport.Implementation.JsonStringer json);
        }

        class SessionStartedEvent : Csdk.GluCustomerSupport.Implementation.ISerializableJsonObject
        {
            /*0x10*/ System.Exception Error;

            /*0x30421a4*/ SessionStartedEvent(System.Exception error);
            /*0x30421d4*/ string ToString();
            /*0x3042258*/ void WriteObject(Csdk.GluCustomerSupport.Implementation.JsonStringer json);
        }

        class SessionEndedEvent : Csdk.GluCustomerSupport.Implementation.ISerializableJsonObject
        {
            /*0x10*/ System.Exception Error;

            /*0x30422b8*/ SessionEndedEvent(System.Exception error);
            /*0x30422e8*/ string ToString();
            /*0x304236c*/ void WriteObject(Csdk.GluCustomerSupport.Implementation.JsonStringer json);
        }

        namespace Implementation
        {
            class AndroidCustomerSupport : UnityEngine.MonoBehaviour, Csdk.GluCustomerSupport.ICustomerSupport, System.IDisposable
            {
                /*0x20*/ System.Action<Csdk.GluCustomerSupport.QueryNotificationCountEvent> QueryNotificationCountEventReceived;
                /*0x28*/ System.Action<Csdk.GluCustomerSupport.SessionStartedEvent> SessionStartedEventReceived;
                /*0x30*/ System.Action<Csdk.GluCustomerSupport.SessionEndedEvent> SessionEndedEventReceived;
                /*0x38*/ UnityEngine.AndroidJavaObject javaCustomerSupport;
                /*0x40*/ UnityEngine.AndroidJavaClass javaUtil;

                /*0x3044108*/ AndroidCustomerSupport();
                /*0x30423cc*/ void add_QueryNotificationCountEventReceived(System.Action<Csdk.GluCustomerSupport.QueryNotificationCountEvent> value);
                /*0x304247c*/ void remove_QueryNotificationCountEventReceived(System.Action<Csdk.GluCustomerSupport.QueryNotificationCountEvent> value);
                /*0x304252c*/ void add_SessionStartedEventReceived(System.Action<Csdk.GluCustomerSupport.SessionStartedEvent> value);
                /*0x30425dc*/ void remove_SessionStartedEventReceived(System.Action<Csdk.GluCustomerSupport.SessionStartedEvent> value);
                /*0x304268c*/ void add_SessionEndedEventReceived(System.Action<Csdk.GluCustomerSupport.SessionEndedEvent> value);
                /*0x304273c*/ void remove_SessionEndedEventReceived(System.Action<Csdk.GluCustomerSupport.SessionEndedEvent> value);
                /*0x3041964*/ void Initialize(string jsonConfig, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
                /*0x30427f8*/ void Dispose();
                /*0x3042850*/ void OnDestroy();
                /*0x304299c*/ void Login(Csdk.GluCustomerSupport.UserInfo info);
                /*0x3042ab4*/ void Logout();
                /*0x3042b7c*/ void QueryNotificationCount();
                /*0x3042c44*/ void ShowDefault(System.Collections.Generic.Dictionary<string, object> options);
                /*0x3042d5c*/ void ShowFAQs(System.Collections.Generic.Dictionary<string, object> options);
                /*0x3042e74*/ void ShowSingleFAQ(string faqID, System.Collections.Generic.Dictionary<string, object> options);
                /*0x3042fec*/ void ShowFAQSection(string sectionID, System.Collections.Generic.Dictionary<string, object> options);
                /*0x3043164*/ void ShowConversation(System.Collections.Generic.Dictionary<string, object> options);
                /*0x304327c*/ void Close();
                /*0x3043344*/ void SetMetadata(System.Collections.Generic.Dictionary<string, object> metadata, System.Collections.Generic.List<object> tags, System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, string>> fields);
                /*0x3043a24*/ void SetLanguageCode(string languageCode);
                /*0x3043b2c*/ void LogUserAction(string action);
                /*0x3043c54*/ void ClearUserActions();
                /*0x3043d1c*/ void AndroidCustomerSupportOnQueryNotificationCount(string message);
                /*0x3043e90*/ void AndroidCustomerSupportOnHelpshiftSessionStarted(string message);
                /*0x3043fcc*/ void AndroidCustomerSupportOnHelpshiftSessionEnded(string message);
            }

            class MarshallingUtil
            {
                static /*0x3044110*/ System.Exception ErrorFromJsonObject(Csdk.GluCustomerSupport.Implementation.Json.JsonResult err);
                static /*0x30427ec*/ string JsonArg(object val);
                static /*0x3043d54*/ Csdk.GluCustomerSupport.QueryNotificationCountEvent QueryNotificationCountEventFromString(string message);
                static /*0x3043ec8*/ Csdk.GluCustomerSupport.SessionStartedEvent SessionStartedEventFromString(string message);
                static /*0x3044004*/ Csdk.GluCustomerSupport.SessionEndedEvent SessionEndedEventFromString(string message);
            }

            interface ISerializableJsonObject
            {
                /*0x1f30ebc*/ void WriteObject(Csdk.GluCustomerSupport.Implementation.JsonStringer json);
            }

            interface ISerializableJson
            {
                /*0x1f30ff0*/ void Write(Csdk.GluCustomerSupport.Implementation.JsonStringer json, string key);
            }

            class JsonStringer
            {
                static /*0x0*/ System.Collections.Generic.IDictionary<char, string> EscapedCharacters;
                /*0x10*/ System.Text.StringBuilder sb;
                /*0x18*/ bool hasElements;

                static /*0x3045208*/ JsonStringer();
                static /*0x3045014*/ System.Collections.Generic.IDictionary<char, string> CreateEscapedCharacters();
                /*0x3044630*/ JsonStringer();
                /*0x304469c*/ Csdk.GluCustomerSupport.Implementation.JsonStringer EndArray();
                /*0x3044700*/ Csdk.GluCustomerSupport.Implementation.JsonStringer EndObject();
                /*0x3044734*/ Csdk.GluCustomerSupport.Implementation.JsonStringer KeyNull(string key);
                /*0x3044854*/ Csdk.GluCustomerSupport.Implementation.JsonStringer KeyArray(string key);
                /*0x30448b0*/ Csdk.GluCustomerSupport.Implementation.JsonStringer KeyObject(string key);
                /*0x30448d0*/ Csdk.GluCustomerSupport.Implementation.JsonStringer KeyValue(string key, bool val);
                /*0x3044968*/ Csdk.GluCustomerSupport.Implementation.JsonStringer KeyValue(string key, long val);
                /*0x3044a10*/ Csdk.GluCustomerSupport.Implementation.JsonStringer KeyValue(string key, ulong val);
                /*0x3044ab8*/ Csdk.GluCustomerSupport.Implementation.JsonStringer KeyValue(string key, double val);
                /*0x3044bbc*/ Csdk.GluCustomerSupport.Implementation.JsonStringer KeyValue(string key, decimal val);
                /*0x3044cc8*/ Csdk.GluCustomerSupport.Implementation.JsonStringer KeyValue(string key, string val);
                /*0x3044ff8*/ string ToString();
                /*0x3044874*/ void DoBeginScope(char scope, string key);
                /*0x30446d0*/ void DoEndScope(char scopeBegin, char scopeEnd);
                /*0x3044d10*/ void DoAppendString(string val);
                /*0x30447a4*/ void PreCommon(string key, bool newHasElements);
            }

            class JsonUtil
            {
                static /*0x3041e48*/ string ToJson(object val);
                static /*0x3045260*/ Csdk.GluCustomerSupport.Implementation.JsonStringer Value(Csdk.GluCustomerSupport.Implementation.JsonStringer json, object val);
                static /*0x304526c*/ Csdk.GluCustomerSupport.Implementation.JsonStringer KeyValue(Csdk.GluCustomerSupport.Implementation.JsonStringer json, string key, object val);
                static /*0x3042034*/ Csdk.GluCustomerSupport.Implementation.JsonStringer OptionalKeyValue(Csdk.GluCustomerSupport.Implementation.JsonStringer json, string key, object val);
                static /*0x3045bbc*/ Csdk.GluCustomerSupport.Implementation.JsonStringer DoKeyValue(Csdk.GluCustomerSupport.Implementation.JsonStringer json, string key, System.Exception e);
                static /*0x3045cd0*/ Csdk.GluCustomerSupport.Implementation.JsonStringer DoKeyValue(Csdk.GluCustomerSupport.Implementation.JsonStringer json, string key, System.Collections.IList val);
                static /*0x1f3299c*/ Csdk.GluCustomerSupport.Implementation.JsonStringer DoKeyValue<T>(Csdk.GluCustomerSupport.Implementation.JsonStringer json, string key, System.Collections.Generic.IDictionary<string, T> val);
                static /*0x3045fa0*/ Csdk.GluCustomerSupport.Implementation.JsonStringer DoKeyValue(Csdk.GluCustomerSupport.Implementation.JsonStringer json, string key, System.Collections.IDictionary val);
            }

            namespace Json
            {
                class AJson
                {
                    static /*0x3044478*/ Csdk.GluCustomerSupport.Implementation.Json.JsonResult ParseString(string str);
                }

                class JsonLexer
                {
                    static /*0x0*/ System.Collections.Generic.IDictionary<char, Csdk.GluCustomerSupport.Implementation.Json.TokenType> OtherTokens;
                    static /*0x8*/ System.Collections.Generic.IDictionary<char, char> EscapedCharacters;
                    static /*0x10*/ object TrueValue;
                    static /*0x18*/ object FalseValue;
                    /*0x10*/ System.Text.StringBuilder mStringBuilder;
                    /*0x18*/ string mCurrentString;
                    /*0x20*/ int mCurrentStringOffset;

                    static /*0x30474a0*/ JsonLexer();
                    static /*0x3046564*/ System.Collections.Generic.IEnumerable<Csdk.GluCustomerSupport.Implementation.Json.JsonToken> ProcessString(string str);
                    static /*0x30469d8*/ System.Collections.Generic.IDictionary<char, Csdk.GluCustomerSupport.Implementation.Json.TokenType> CreateOtherTokens();
                    static /*0x3046b3c*/ System.Collections.Generic.IDictionary<char, char> CreateEscapedCharacters();
                    /*0x304689c*/ JsonLexer();
                    /*0x3046908*/ System.Collections.Generic.IEnumerable<Csdk.GluCustomerSupport.Implementation.Json.JsonToken> Process(string text);
                    /*0x3046c58*/ void MunchWhitespaces();
                    /*0x3046d0c*/ bool TryMunchString(ref string value);
                    /*0x3046d64*/ bool DoTryMunchString(ref string value);
                    /*0x30470b8*/ bool TryMunchNumber(ref decimal value);
                    /*0x3047268*/ bool TryMunchBool(ref bool value);
                    /*0x3047360*/ bool TryMunchOther(ref Csdk.GluCustomerSupport.Implementation.Json.TokenType tokenType);
                    /*0x3047304*/ bool TryMunchKeyword(string str);
                    /*0x3047024*/ System.Text.StringBuilder GetEmptyStringBuilder();
                    /*0x3046cec*/ char PeekCurrentCharacter();
                    /*0x304706c*/ bool ReadNextCharacter(ref char c);

                    class <Process>d__10 : System.Collections.Generic.IEnumerable<Csdk.GluCustomerSupport.Implementation.Json.JsonToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Csdk.GluCustomerSupport.Implementation.Json.JsonToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Csdk.GluCustomerSupport.Implementation.Json.JsonToken <>2__current;
                        /*0x28*/ int <>l__initialThreadId;
                        /*0x30*/ string text;
                        /*0x38*/ string <>3__text;
                        /*0x40*/ Csdk.GluCustomerSupport.Implementation.Json.JsonLexer <>4__this;
                        /*0x48*/ string <stringValue>5__2;
                        /*0x50*/ decimal <numberValue>5__3;
                        /*0x60*/ bool <boolValue>5__4;
                        /*0x64*/ Csdk.GluCustomerSupport.Implementation.Json.TokenType <otherValue>5__5;

                        /*0x30469a4*/ <Process>d__10(int <>1__state);
                        /*0x3047574*/ void System.IDisposable.Dispose();
                        /*0x3047578*/ bool MoveNext();
                        /*0x3047904*/ Csdk.GluCustomerSupport.Implementation.Json.JsonToken System.Collections.Generic.IEnumerator<Csdk.GluCustomerSupport.Implementation.Json.JsonToken>.get_Current();
                        /*0x3047910*/ void System.Collections.IEnumerator.Reset();
                        /*0x3047948*/ object System.Collections.IEnumerator.get_Current();
                        /*0x30479a4*/ System.Collections.Generic.IEnumerator<Csdk.GluCustomerSupport.Implementation.Json.JsonToken> System.Collections.Generic.IEnumerable<Csdk.GluCustomerSupport.Implementation.Json.JsonToken>.GetEnumerator();
                        /*0x3047a58*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

                    static /*0x30481a8*/ JsonNode();
                    static /*0x3047cc0*/ Csdk.GluCustomerSupport.Implementation.Json.JsonNode Create(object value, string key);
                    static /*0x3047d5c*/ Csdk.GluCustomerSupport.Implementation.Json.JsonNode Object(int size, string key);
                    static /*0x3047dec*/ Csdk.GluCustomerSupport.Implementation.Json.JsonNode Array(int size, string key);
                    /*0x3047a5c*/ JsonNode(object value, string key, int size);
                    /*0x3047a98*/ bool get_IsObject();
                    /*0x3047b00*/ bool get_IsNull();
                    /*0x3047b68*/ bool get_IsBoolean();
                    /*0x3047bcc*/ bool get_IsString();
                    /*0x3047c30*/ bool get_IsNumber();
                    /*0x3047e7c*/ decimal AsDecimal();
                    /*0x3048084*/ string AsString();
                }

                class JsonParser
                {
                    /*0x10*/ System.Collections.Generic.IList<Csdk.GluCustomerSupport.Implementation.Json.JsonNode> mNodes;
                    /*0x18*/ System.Collections.Generic.IEnumerator<Csdk.GluCustomerSupport.Implementation.Json.JsonToken> mEnum;
                    /*0x20*/ Csdk.GluCustomerSupport.Implementation.Json.JsonToken mCurrentToken;

                    /*0x30465c4*/ JsonParser();
                    /*0x3048274*/ Csdk.GluCustomerSupport.Implementation.Json.JsonToken get_CurrentToken();
                    /*0x30465cc*/ Csdk.GluCustomerSupport.Implementation.Json.JsonResult Parse(System.Collections.Generic.IEnumerable<Csdk.GluCustomerSupport.Implementation.Json.JsonToken> tokens);
                    /*0x30483f8*/ void ParseObject(string key);
                    /*0x3048708*/ void ParseArray(string key);
                    /*0x3048b5c*/ string ParseString();
                    /*0x3048b9c*/ void ParseValue(string key);
                    /*0x3048a1c*/ void Munch(Csdk.GluCustomerSupport.Implementation.Json.TokenType token);
                    /*0x3048280*/ void MoveNext();
                    /*0x3048d88*/ System.Exception ThrowInvalidJsonException(string message);
                    /*0x3048a00*/ System.Exception ThrowInvalidJsonException(string format, object[] args);
                }

                struct JsonResult : System.Collections.Generic.IEnumerable<Csdk.GluCustomerSupport.Implementation.Json.JsonResult>, System.Collections.IEnumerable
                {
                    static /*0x0*/ Csdk.GluCustomerSupport.Implementation.Json.JsonResult Empty;
                    static /*0x10*/ System.Collections.Generic.IList<Csdk.GluCustomerSupport.Implementation.Json.JsonResult> EmptyList;
                    /*0x10*/ System.Collections.Generic.IList<Csdk.GluCustomerSupport.Implementation.Json.JsonNode> mNodes;
                    /*0x18*/ int mIndex;
                    /*0x1c*/ int mEnd;

                    static /*0x304951c*/ JsonResult();
                    static /*0x30445d0*/ long op_Implicit(Csdk.GluCustomerSupport.Implementation.Json.JsonResult result);
                    static /*0x3044418*/ string op_Implicit(Csdk.GluCustomerSupport.Implementation.Json.JsonResult result);
                    /*0x3048af4*/ JsonResult(System.Collections.Generic.IList<Csdk.GluCustomerSupport.Implementation.Json.JsonNode> nodes);
                    /*0x3048dcc*/ JsonResult(System.Collections.Generic.IList<Csdk.GluCustomerSupport.Implementation.Json.JsonNode> nodes, int index);
                    /*0x3048eb0*/ bool get_HasValue();
                    /*0x3044510*/ bool get_IsObject();
                    /*0x304421c*/ Csdk.GluCustomerSupport.Implementation.Json.JsonResult get_Item(string key);
                    /*0x3049078*/ long AsInt64();
                    /*0x30491c4*/ decimal AsDecimal();
                    /*0x3049108*/ string AsString();
                    /*0x30492d0*/ System.Collections.Generic.IEnumerable<Csdk.GluCustomerSupport.Implementation.Json.JsonResult> AsEnumerable();
                    /*0x3049384*/ System.Collections.Generic.IEnumerator<Csdk.GluCustomerSupport.Implementation.Json.JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluCustomerSupport.Implementation.Json.JsonResult>.GetEnumerator();
                    /*0x3049450*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x3048ec0*/ Csdk.GluCustomerSupport.Implementation.Json.JsonNode GetNode();
                    /*0x3048fb8*/ int GetNextNodeIndex(int index);
                    /*0x3048f8c*/ Csdk.GluCustomerSupport.Implementation.Json.JsonResult FromIndex(int index);

                    class <AsEnumerable>d__42 : System.Collections.Generic.IEnumerable<Csdk.GluCustomerSupport.Implementation.Json.JsonResult>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Csdk.GluCustomerSupport.Implementation.Json.JsonResult>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Csdk.GluCustomerSupport.Implementation.Json.JsonResult <>2__current;
                        /*0x28*/ int <>l__initialThreadId;
                        /*0x30*/ Csdk.GluCustomerSupport.Implementation.Json.JsonResult <>4__this;
                        /*0x40*/ Csdk.GluCustomerSupport.Implementation.Json.JsonResult <>3__<>4__this;
                        /*0x50*/ int <nodeIndex>5__2;

                        /*0x3049350*/ <AsEnumerable>d__42(int <>1__state);
                        /*0x3049598*/ void System.IDisposable.Dispose();
                        /*0x304959c*/ bool MoveNext();
                        /*0x3049794*/ Csdk.GluCustomerSupport.Implementation.Json.JsonResult System.Collections.Generic.IEnumerator<Csdk.GluCustomerSupport.Implementation.Json.JsonResult>.get_Current();
                        /*0x30497a0*/ void System.Collections.IEnumerator.Reset();
                        /*0x30497d8*/ object System.Collections.IEnumerator.get_Current();
                        /*0x3049834*/ System.Collections.Generic.IEnumerator<Csdk.GluCustomerSupport.Implementation.Json.JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluCustomerSupport.Implementation.Json.JsonResult>.GetEnumerator();
                        /*0x30498dc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                struct JsonToken
                {
                    /*0x10*/ Csdk.GluCustomerSupport.Implementation.Json.TokenType Type;
                    /*0x18*/ object Value;

                    /*0x30478f4*/ JsonToken(Csdk.GluCustomerSupport.Implementation.Json.TokenType type, object value);
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
