class <Module>
{
}

namespace Csdk
{
    namespace GluAppTracking
    {
        class GluAppTrackingFactory
        {
            static /*0x302d618*/ Csdk.GluAppTracking.IGluAppTracking CreateAppTrackingAndroid(UnityEngine.GameObject gameObject, string jsonConfig, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
            /*0x302d9b4*/ GluAppTrackingFactory();
            /*0x302d4a4*/ Csdk.GluAppTracking.IGluAppTracking CreateAppTracking(UnityEngine.GameObject gameObject, string jsonConfig, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
        }

        class DeepLinkEvent : Csdk.GluAppTracking.Implementation.ISerializableJsonObject
        {
            /*0x10*/ string DeepLink;
            /*0x18*/ string PassThrough;
            /*0x20*/ bool IsDeferred;
            /*0x28*/ System.Collections.Generic.IDictionary<string, string> UrlParameters;

            /*0x302d9bc*/ DeepLinkEvent(string deepLink, string passThrough, bool isDeferred, System.Collections.Generic.IDictionary<string, string> urlParameters);
            /*0x302da24*/ string ToString();
            /*0x302db18*/ void WriteObject(Csdk.GluAppTracking.Implementation.JsonStringer json);
        }

        interface IGluAppTracking : System.IDisposable
        {
            /*0x1f30ebc*/ void LogEvent(string eventName);
            /*0x1f30ff0*/ void LogEvent(string eventName, System.Collections.Generic.IDictionary<string, object> extra);
            void TrackRevenue(string currency, decimal price, System.Collections.Generic.IDictionary<string, object> extra);
            /*0x1f30ebc*/ void SetCustomProperties(System.Collections.Generic.IDictionary<string, object> properties);
        }

        namespace Utils
        {
            class JniUtil
            {
                static /*0x302dc24*/ void CallInLocalFrame(System.Action action);
                static /*0x1ffc854*/ T CallInLocalFrame<T>(System.Func<T> func);

                class <>c__DisplayClass0_0
                {
                    /*0x10*/ System.Action action;

                    /*0x302dd08*/ <>c__DisplayClass0_0();
                    /*0x302dd10*/ object <CallInLocalFrame>b__0();
                }
            }
        }

        namespace Implementation
        {
            class AndroidAppTracking : UnityEngine.MonoBehaviour, Csdk.GluAppTracking.IGluAppTracking, System.IDisposable
            {
                /*0x20*/ System.Action<Csdk.GluAppTracking.DeepLinkEvent> DeepLinkEventReceived;
                /*0x28*/ UnityEngine.AndroidJavaObject mJavaObject;
                /*0x30*/ UnityEngine.AndroidJavaClass javaUtil;

                /*0x302f044*/ AndroidAppTracking();
                /*0x302dd3c*/ void add_DeepLinkEventReceived(System.Action<Csdk.GluAppTracking.DeepLinkEvent> value);
                /*0x302ddec*/ void remove_DeepLinkEventReceived(System.Action<Csdk.GluAppTracking.DeepLinkEvent> value);
                /*0x302d69c*/ void Init(string jsonConfig, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
                /*0x302dea4*/ void LogEvent(string eventName);
                /*0x302df7c*/ void LogEvent(string eventName, System.Collections.Generic.IDictionary<string, object> extra);
                /*0x302e070*/ void TrackRevenue(string currency, decimal price);
                /*0x302e108*/ void TrackRevenue(string currency, decimal price, System.Collections.Generic.IDictionary<string, object> extra);
                /*0x302e210*/ void TrackRevenueInUsd(decimal price);
                /*0x302e2e8*/ void TrackRevenue(string productId, string receipt, System.Collections.Generic.IDictionary<string, object> extra);
                /*0x302e3f0*/ void SetGlobalProperty(string key, string value);
                /*0x302e3f8*/ void SetGlobalProperty(string key, string value, bool overrideExisting);
                /*0x302e4f8*/ void SetCustomProperties(System.Collections.Generic.IDictionary<string, object> properties);
                /*0x302e5d0*/ void SetUserID(string userID);
                /*0x302e6a8*/ void Dispose();
                /*0x302e710*/ void SetPushToken(string pushNotificationsToken);
                /*0x302e7e8*/ void RegisterAppForAdNetworkAttribution();
                /*0x302e7ec*/ void OnDestroy();
                /*0x302e8f8*/ void AndroidAppTrackingOnDeepLinkEvent(string message);

                class <>c__DisplayClass10_0
                {
                    /*0x10*/ Csdk.GluAppTracking.Implementation.AndroidAppTracking <>4__this;
                    /*0x18*/ decimal price;

                    /*0x302e2e0*/ <>c__DisplayClass10_0();
                    /*0x302f04c*/ void <TrackRevenueInUsd>b__0();
                }

                class <>c__DisplayClass11_0
                {
                    /*0x10*/ Csdk.GluAppTracking.Implementation.AndroidAppTracking <>4__this;
                    /*0x18*/ string productId;
                    /*0x20*/ string receipt;
                    /*0x28*/ System.Collections.Generic.IDictionary<string, object> extra;

                    /*0x302e3e8*/ <>c__DisplayClass11_0();
                    /*0x302f180*/ void <TrackRevenue>b__0();
                }

                class <>c__DisplayClass13_0
                {
                    /*0x10*/ Csdk.GluAppTracking.Implementation.AndroidAppTracking <>4__this;
                    /*0x18*/ string key;
                    /*0x20*/ string value;
                    /*0x28*/ bool overrideExisting;

                    /*0x302e4f0*/ <>c__DisplayClass13_0();
                    /*0x302f324*/ void <SetGlobalProperty>b__0();
                }

                class <>c__DisplayClass14_0
                {
                    /*0x10*/ Csdk.GluAppTracking.Implementation.AndroidAppTracking <>4__this;
                    /*0x18*/ System.Collections.Generic.IDictionary<string, object> properties;

                    /*0x302e5c8*/ <>c__DisplayClass14_0();
                    /*0x302f4cc*/ void <SetCustomProperties>b__0();
                }

                class <>c__DisplayClass15_0
                {
                    /*0x10*/ Csdk.GluAppTracking.Implementation.AndroidAppTracking <>4__this;
                    /*0x18*/ string userID;

                    /*0x302e6a0*/ <>c__DisplayClass15_0();
                    /*0x302f5f4*/ void <SetUserID>b__0();
                }

                class <>c__DisplayClass17_0
                {
                    /*0x10*/ Csdk.GluAppTracking.Implementation.AndroidAppTracking <>4__this;
                    /*0x18*/ string pushNotificationsToken;

                    /*0x302e7e0*/ <>c__DisplayClass17_0();
                    /*0x302f6f0*/ void <SetPushToken>b__0();
                }

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ Csdk.GluAppTracking.Implementation.AndroidAppTracking <>4__this;
                    /*0x18*/ string jsonConfig;
                    /*0x20*/ System.Collections.Generic.IDictionary<string, object> runtimeConfig;
                    /*0x28*/ UnityEngine.AndroidJavaObject factory;

                    /*0x302de9c*/ <>c__DisplayClass5_0();
                    /*0x302f7ec*/ UnityEngine.AndroidJavaObject <Init>b__0();
                }

                class <>c__DisplayClass6_0
                {
                    /*0x10*/ Csdk.GluAppTracking.Implementation.AndroidAppTracking <>4__this;
                    /*0x18*/ string eventName;

                    /*0x302df74*/ <>c__DisplayClass6_0();
                    /*0x302f9b4*/ void <LogEvent>b__0();
                }

                class <>c__DisplayClass7_0
                {
                    /*0x10*/ Csdk.GluAppTracking.Implementation.AndroidAppTracking <>4__this;
                    /*0x18*/ string eventName;
                    /*0x20*/ System.Collections.Generic.IDictionary<string, object> extra;

                    /*0x302e068*/ <>c__DisplayClass7_0();
                    /*0x302fab0*/ void <LogEvent>b__0();
                }

                class <>c__DisplayClass9_0
                {
                    /*0x10*/ Csdk.GluAppTracking.Implementation.AndroidAppTracking <>4__this;
                    /*0x18*/ string currency;
                    /*0x20*/ decimal price;
                    /*0x30*/ System.Collections.Generic.IDictionary<string, object> extra;

                    /*0x302e208*/ <>c__DisplayClass9_0();
                    /*0x302fc38*/ void <TrackRevenue>b__0();
                }
            }

            class DummyAppTracking : Csdk.GluAppTracking.IGluAppTracking, System.IDisposable
            {
                /*0x10*/ System.Action<Csdk.GluAppTracking.DeepLinkEvent> DeepLinkEventReceived;

                /*0x302d694*/ DummyAppTracking();
                /*0x302fe2c*/ void LogEvent(string eventName);
                /*0x302fe30*/ void LogEvent(string eventName, System.Collections.Generic.IDictionary<string, object> extra);
                /*0x302fe34*/ void TrackRevenue(string currency, decimal price, System.Collections.Generic.IDictionary<string, object> extra);
                /*0x302fe38*/ void Dispose();
                /*0x302fe44*/ void SetCustomProperties(System.Collections.Generic.IDictionary<string, object> properties);
            }

            class MarshallingUtil
            {
                static /*0x302f318*/ string JsonArg(object val);
                static /*0x302e930*/ Csdk.GluAppTracking.DeepLinkEvent DeepLinkEventFromString(string message);
            }

            interface ISerializableJsonObject
            {
                /*0x1f30ebc*/ void WriteObject(Csdk.GluAppTracking.Implementation.JsonStringer json);
            }

            interface ISerializableJson
            {
                /*0x1f30ff0*/ void Write(Csdk.GluAppTracking.Implementation.JsonStringer json, string key);
            }

            class JsonStringer
            {
                static /*0x0*/ System.Collections.Generic.IDictionary<char, string> EscapedCharacters;
                /*0x10*/ System.Text.StringBuilder sb;
                /*0x18*/ bool hasElements;

                static /*0x30312fc*/ JsonStringer();
                static /*0x3031108*/ System.Collections.Generic.IDictionary<char, string> CreateEscapedCharacters();
                /*0x3030724*/ JsonStringer();
                /*0x3030790*/ Csdk.GluAppTracking.Implementation.JsonStringer EndArray();
                /*0x30307f4*/ Csdk.GluAppTracking.Implementation.JsonStringer EndObject();
                /*0x3030828*/ Csdk.GluAppTracking.Implementation.JsonStringer KeyNull(string key);
                /*0x3030948*/ Csdk.GluAppTracking.Implementation.JsonStringer KeyArray(string key);
                /*0x30309a4*/ Csdk.GluAppTracking.Implementation.JsonStringer KeyObject(string key);
                /*0x30309c4*/ Csdk.GluAppTracking.Implementation.JsonStringer KeyValue(string key, bool val);
                /*0x3030a5c*/ Csdk.GluAppTracking.Implementation.JsonStringer KeyValue(string key, long val);
                /*0x3030b04*/ Csdk.GluAppTracking.Implementation.JsonStringer KeyValue(string key, ulong val);
                /*0x3030bac*/ Csdk.GluAppTracking.Implementation.JsonStringer KeyValue(string key, double val);
                /*0x3030cb0*/ Csdk.GluAppTracking.Implementation.JsonStringer KeyValue(string key, decimal val);
                /*0x3030dbc*/ Csdk.GluAppTracking.Implementation.JsonStringer KeyValue(string key, string val);
                /*0x30310ec*/ string ToString();
                /*0x3030968*/ void DoBeginScope(char scope, string key);
                /*0x30307c4*/ void DoEndScope(char scopeBegin, char scopeEnd);
                /*0x3030e04*/ void DoAppendString(string val);
                /*0x3030898*/ void PreCommon(string key, bool newHasElements);
            }

            class JsonUtil
            {
                static /*0x302daa8*/ string ToJson(object val);
                static /*0x3031354*/ Csdk.GluAppTracking.Implementation.JsonStringer Value(Csdk.GluAppTracking.Implementation.JsonStringer json, object val);
                static /*0x3031360*/ Csdk.GluAppTracking.Implementation.JsonStringer KeyValue(Csdk.GluAppTracking.Implementation.JsonStringer json, string key, object val);
                static /*0x302dc18*/ Csdk.GluAppTracking.Implementation.JsonStringer OptionalKeyValue(Csdk.GluAppTracking.Implementation.JsonStringer json, string key, object val);
                static /*0x3031cb0*/ Csdk.GluAppTracking.Implementation.JsonStringer DoKeyValue(Csdk.GluAppTracking.Implementation.JsonStringer json, string key, System.Exception e);
                static /*0x3031dc4*/ Csdk.GluAppTracking.Implementation.JsonStringer DoKeyValue(Csdk.GluAppTracking.Implementation.JsonStringer json, string key, System.Collections.IList val);
                static /*0x1f3299c*/ Csdk.GluAppTracking.Implementation.JsonStringer DoKeyValue<T>(Csdk.GluAppTracking.Implementation.JsonStringer json, string key, System.Collections.Generic.IDictionary<string, T> val);
                static /*0x3032094*/ Csdk.GluAppTracking.Implementation.JsonStringer DoKeyValue(Csdk.GluAppTracking.Implementation.JsonStringer json, string key, System.Collections.IDictionary val);
            }

            namespace Json
            {
                class AJson
                {
                    static /*0x302fe48*/ Csdk.GluAppTracking.Implementation.Json.JsonResult ParseString(string str);
                }

                class JsonLexer
                {
                    static /*0x0*/ System.Collections.Generic.IDictionary<char, Csdk.GluAppTracking.Implementation.Json.TokenType> OtherTokens;
                    static /*0x8*/ System.Collections.Generic.IDictionary<char, char> EscapedCharacters;
                    static /*0x10*/ object TrueValue;
                    static /*0x18*/ object FalseValue;
                    /*0x10*/ System.Text.StringBuilder mStringBuilder;
                    /*0x18*/ string mCurrentString;
                    /*0x20*/ int mCurrentStringOffset;

                    static /*0x3033594*/ JsonLexer();
                    static /*0x3032658*/ System.Collections.Generic.IEnumerable<Csdk.GluAppTracking.Implementation.Json.JsonToken> ProcessString(string str);
                    static /*0x3032acc*/ System.Collections.Generic.IDictionary<char, Csdk.GluAppTracking.Implementation.Json.TokenType> CreateOtherTokens();
                    static /*0x3032c30*/ System.Collections.Generic.IDictionary<char, char> CreateEscapedCharacters();
                    /*0x3032990*/ JsonLexer();
                    /*0x30329fc*/ System.Collections.Generic.IEnumerable<Csdk.GluAppTracking.Implementation.Json.JsonToken> Process(string text);
                    /*0x3032d4c*/ void MunchWhitespaces();
                    /*0x3032e00*/ bool TryMunchString(ref string value);
                    /*0x3032e58*/ bool DoTryMunchString(ref string value);
                    /*0x30331ac*/ bool TryMunchNumber(ref decimal value);
                    /*0x303335c*/ bool TryMunchBool(ref bool value);
                    /*0x3033454*/ bool TryMunchOther(ref Csdk.GluAppTracking.Implementation.Json.TokenType tokenType);
                    /*0x30333f8*/ bool TryMunchKeyword(string str);
                    /*0x3033118*/ System.Text.StringBuilder GetEmptyStringBuilder();
                    /*0x3032de0*/ char PeekCurrentCharacter();
                    /*0x3033160*/ bool ReadNextCharacter(ref char c);

                    class <Process>d__10 : System.Collections.Generic.IEnumerable<Csdk.GluAppTracking.Implementation.Json.JsonToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Csdk.GluAppTracking.Implementation.Json.JsonToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Csdk.GluAppTracking.Implementation.Json.JsonToken <>2__current;
                        /*0x28*/ int <>l__initialThreadId;
                        /*0x30*/ string text;
                        /*0x38*/ string <>3__text;
                        /*0x40*/ Csdk.GluAppTracking.Implementation.Json.JsonLexer <>4__this;
                        /*0x48*/ string <stringValue>5__2;
                        /*0x50*/ decimal <numberValue>5__3;
                        /*0x60*/ bool <boolValue>5__4;
                        /*0x64*/ Csdk.GluAppTracking.Implementation.Json.TokenType <otherValue>5__5;

                        /*0x3032a98*/ <Process>d__10(int <>1__state);
                        /*0x3033668*/ void System.IDisposable.Dispose();
                        /*0x303366c*/ bool MoveNext();
                        /*0x30339f8*/ Csdk.GluAppTracking.Implementation.Json.JsonToken System.Collections.Generic.IEnumerator<Csdk.GluAppTracking.Implementation.Json.JsonToken>.get_Current();
                        /*0x3033a04*/ void System.Collections.IEnumerator.Reset();
                        /*0x3033a3c*/ object System.Collections.IEnumerator.get_Current();
                        /*0x3033a98*/ System.Collections.Generic.IEnumerator<Csdk.GluAppTracking.Implementation.Json.JsonToken> System.Collections.Generic.IEnumerable<Csdk.GluAppTracking.Implementation.Json.JsonToken>.GetEnumerator();
                        /*0x3033b4c*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

                    static /*0x3034304*/ JsonNode();
                    static /*0x3033e1c*/ Csdk.GluAppTracking.Implementation.Json.JsonNode Create(object value, string key);
                    static /*0x3033eb8*/ Csdk.GluAppTracking.Implementation.Json.JsonNode Object(int size, string key);
                    static /*0x3033f48*/ Csdk.GluAppTracking.Implementation.Json.JsonNode Array(int size, string key);
                    /*0x3033b50*/ JsonNode(object value, string key, int size);
                    /*0x3033b8c*/ bool get_IsObject();
                    /*0x3033bf4*/ bool get_IsArray();
                    /*0x3033c5c*/ bool get_IsNull();
                    /*0x3033cc4*/ bool get_IsBoolean();
                    /*0x3033d28*/ bool get_IsString();
                    /*0x3033d8c*/ bool get_IsNumber();
                    /*0x3033fd8*/ string AsString();
                    /*0x30340fc*/ bool AsBoolean();
                }

                class JsonParser
                {
                    /*0x10*/ System.Collections.Generic.IList<Csdk.GluAppTracking.Implementation.Json.JsonNode> mNodes;
                    /*0x18*/ System.Collections.Generic.IEnumerator<Csdk.GluAppTracking.Implementation.Json.JsonToken> mEnum;
                    /*0x20*/ Csdk.GluAppTracking.Implementation.Json.JsonToken mCurrentToken;

                    /*0x30326b8*/ JsonParser();
                    /*0x30343d0*/ Csdk.GluAppTracking.Implementation.Json.JsonToken get_CurrentToken();
                    /*0x30326c0*/ Csdk.GluAppTracking.Implementation.Json.JsonResult Parse(System.Collections.Generic.IEnumerable<Csdk.GluAppTracking.Implementation.Json.JsonToken> tokens);
                    /*0x3034554*/ void ParseObject(string key);
                    /*0x3034864*/ void ParseArray(string key);
                    /*0x3034cb8*/ string ParseString();
                    /*0x3034cf8*/ void ParseValue(string key);
                    /*0x3034b78*/ void Munch(Csdk.GluAppTracking.Implementation.Json.TokenType token);
                    /*0x30343dc*/ void MoveNext();
                    /*0x3034ee4*/ System.Exception ThrowInvalidJsonException(string message);
                    /*0x3034b5c*/ System.Exception ThrowInvalidJsonException(string format, object[] args);
                }

                struct JsonResult : System.Collections.Generic.IEnumerable<Csdk.GluAppTracking.Implementation.Json.JsonResult>, System.Collections.IEnumerable
                {
                    static /*0x0*/ Csdk.GluAppTracking.Implementation.Json.JsonResult Empty;
                    static /*0x10*/ System.Collections.Generic.IList<Csdk.GluAppTracking.Implementation.Json.JsonResult> EmptyList;
                    /*0x10*/ System.Collections.Generic.IList<Csdk.GluAppTracking.Implementation.Json.JsonNode> mNodes;
                    /*0x18*/ int mIndex;
                    /*0x1c*/ int mEnd;

                    static /*0x30354e0*/ JsonResult();
                    static /*0x303013c*/ bool op_Implicit(Csdk.GluAppTracking.Implementation.Json.JsonResult result);
                    static /*0x30300dc*/ string op_Implicit(Csdk.GluAppTracking.Implementation.Json.JsonResult result);
                    /*0x3034c50*/ JsonResult(System.Collections.Generic.IList<Csdk.GluAppTracking.Implementation.Json.JsonNode> nodes);
                    /*0x3034f28*/ JsonResult(System.Collections.Generic.IList<Csdk.GluAppTracking.Implementation.Json.JsonNode> nodes, int index);
                    /*0x303500c*/ bool get_HasValue();
                    /*0x30301a0*/ bool get_IsObject();
                    /*0x30305a8*/ bool get_IsString();
                    /*0x302fee0*/ Csdk.GluAppTracking.Implementation.Json.JsonResult get_Item(string key);
                    /*0x3030260*/ int Count();
                    /*0x3030668*/ string AsString();
                    /*0x30351d4*/ bool AsBoolean();
                    /*0x3035294*/ System.Collections.Generic.IEnumerable<Csdk.GluAppTracking.Implementation.Json.JsonResult> AsEnumerable();
                    /*0x303038c*/ System.Collections.Generic.IDictionary<string, Csdk.GluAppTracking.Implementation.Json.JsonResult> AsDictionary();
                    /*0x3035348*/ System.Collections.Generic.IEnumerator<Csdk.GluAppTracking.Implementation.Json.JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluAppTracking.Implementation.Json.JsonResult>.GetEnumerator();
                    /*0x3035414*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x303501c*/ Csdk.GluAppTracking.Implementation.Json.JsonNode GetNode();
                    /*0x3035114*/ int GetNextNodeIndex(int index);
                    /*0x30350e8*/ Csdk.GluAppTracking.Implementation.Json.JsonResult FromIndex(int index);

                    class <AsEnumerable>d__42 : System.Collections.Generic.IEnumerable<Csdk.GluAppTracking.Implementation.Json.JsonResult>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Csdk.GluAppTracking.Implementation.Json.JsonResult>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Csdk.GluAppTracking.Implementation.Json.JsonResult <>2__current;
                        /*0x28*/ int <>l__initialThreadId;
                        /*0x30*/ Csdk.GluAppTracking.Implementation.Json.JsonResult <>4__this;
                        /*0x40*/ Csdk.GluAppTracking.Implementation.Json.JsonResult <>3__<>4__this;
                        /*0x50*/ int <nodeIndex>5__2;

                        /*0x3035314*/ <AsEnumerable>d__42(int <>1__state);
                        /*0x303555c*/ void System.IDisposable.Dispose();
                        /*0x3035560*/ bool MoveNext();
                        /*0x3035758*/ Csdk.GluAppTracking.Implementation.Json.JsonResult System.Collections.Generic.IEnumerator<Csdk.GluAppTracking.Implementation.Json.JsonResult>.get_Current();
                        /*0x3035764*/ void System.Collections.IEnumerator.Reset();
                        /*0x303579c*/ object System.Collections.IEnumerator.get_Current();
                        /*0x30357f8*/ System.Collections.Generic.IEnumerator<Csdk.GluAppTracking.Implementation.Json.JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluAppTracking.Implementation.Json.JsonResult>.GetEnumerator();
                        /*0x30358a0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                struct JsonToken
                {
                    /*0x10*/ Csdk.GluAppTracking.Implementation.Json.TokenType Type;
                    /*0x18*/ object Value;

                    /*0x30339e8*/ JsonToken(Csdk.GluAppTracking.Implementation.Json.TokenType type, object value);
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
