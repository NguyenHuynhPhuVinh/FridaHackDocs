class <Module>
{
}

namespace Csdk
{
    namespace GluAds
    {
        class GluAdsFactory
        {
            /*0x301e564*/ GluAdsFactory();
            /*0x301dfa4*/ Csdk.GluAds.IAdvertising CreateAdvertising(UnityEngine.GameObject gameObject, string jsonConfig, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
            /*0x301e100*/ Csdk.GluAds.IAdvertising CreateAndroidAdvertising(UnityEngine.GameObject gameObject, string jsonConfig, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
        }

        interface IAdvertising : System.IDisposable
        {
            /*0x1f30ebc*/ void add_PlacementEventReceived(System.Action<Csdk.GluAds.PlacementEvent> value);
            /*0x1f30ebc*/ void remove_PlacementEventReceived(System.Action<Csdk.GluAds.PlacementEvent> value);
            /*0x1f30ebc*/ void add_RewardReceived(System.Action<Csdk.GluAds.Reward> value);
            /*0x1f30ebc*/ void remove_RewardReceived(System.Action<Csdk.GluAds.Reward> value);
            bool IsLoaded(string advertisementType, string placement, System.Collections.Generic.IDictionary<string, object> extra);
            /*0x1f310fc*/ void Load(string advertisementType, string placement, System.Collections.Generic.IDictionary<string, object> extra);
            /*0x1f310fc*/ void Show(string advertisementType, string placement, System.Collections.Generic.IDictionary<string, object> extra);
            /*0x1f310fc*/ void Discard(string advertisementType, string identifier, System.Collections.Generic.IDictionary<string, object> extra);
            /*0x1f30ebc*/ void SetCustomProperties(System.Collections.Generic.IDictionary<string, object> properties);
        }

        class CustomAction : Csdk.GluAds.Implementation.ISerializableJsonObject
        {
            /*0x10*/ string Action;
            /*0x18*/ System.Collections.Generic.IDictionary<string, object> Extra;

            /*0x301e56c*/ CustomAction(string action, System.Collections.Generic.IDictionary<string, object> extra);
            /*0x301e5fc*/ string ToString();
            /*0x301e6f0*/ void WriteObject(Csdk.GluAds.Implementation.JsonStringer json);
        }

        class PlacementEvent : Csdk.GluAds.Implementation.ISerializableJsonObject
        {
            /*0x10*/ string AdvertisementType;
            /*0x18*/ string Placement;
            /*0x20*/ string Status;
            /*0x28*/ System.Exception Error;
            /*0x30*/ System.Collections.Generic.IDictionary<string, object> Extra;
            /*0x38*/ string PlacementEventId;

            /*0x301e788*/ PlacementEvent(string advertisementType, string placement, string status, System.Exception error, System.Collections.Generic.IDictionary<string, object> extra, string placementEventId);
            /*0x301e8c0*/ string ToString();
            /*0x301e944*/ void WriteObject(Csdk.GluAds.Implementation.JsonStringer json);
        }

        class Reward : Csdk.GluAds.Implementation.ISerializableJsonObject
        {
            /*0x10*/ string Identifier;
            /*0x18*/ string Placement;
            /*0x20*/ string AdvertisementType;
            /*0x28*/ string Item;
            /*0x30*/ int Amount;
            /*0x38*/ string PlacementEventId;

            /*0x301ea80*/ Reward(string identifier, string placement, string advertisementType, string item, int amount, string placementEventId);
            /*0x301ec08*/ string ToString();
            /*0x301ec8c*/ void WriteObject(Csdk.GluAds.Implementation.JsonStringer json);
        }

        namespace Implementation
        {
            class AndroidAdvertising : UnityEngine.MonoBehaviour, Csdk.GluAds.IAdvertising, System.IDisposable
            {
                /*0x20*/ UnityEngine.AndroidJavaObject javaAdvertising;
                /*0x28*/ UnityEngine.AndroidJavaClass javaUtil;
                /*0x30*/ System.Action<Csdk.GluAds.CustomAction> CustomActionReceived;
                /*0x38*/ System.Action<Csdk.GluAds.PlacementEvent> PlacementEventReceived;
                /*0x40*/ System.Action<Csdk.GluAds.Reward> RewardReceived;

                static /*0x30208a4*/ nint GluAdsPlacementIdTrackIDFor(string type, string placement, string status);
                static /*0x3020a94*/ nint GluAdsPlacementIdGetLastShownIDFor(string type, string placement);
                static /*0x301f294*/ void GluAdsPlacementIdReset();
                /*0x3020c94*/ AndroidAdvertising();
                /*0x301ee68*/ void add_CustomActionReceived(System.Action<Csdk.GluAds.CustomAction> value);
                /*0x301ef18*/ void remove_CustomActionReceived(System.Action<Csdk.GluAds.CustomAction> value);
                /*0x301efc8*/ void add_PlacementEventReceived(System.Action<Csdk.GluAds.PlacementEvent> value);
                /*0x301f078*/ void remove_PlacementEventReceived(System.Action<Csdk.GluAds.PlacementEvent> value);
                /*0x301f128*/ void add_RewardReceived(System.Action<Csdk.GluAds.Reward> value);
                /*0x301f1d8*/ void remove_RewardReceived(System.Action<Csdk.GluAds.Reward> value);
                /*0x301e17c*/ void Initialize(string jsonConfig, System.Collections.Generic.IDictionary<string, object> runtimeConfig);
                /*0x301f2f8*/ void Dispose();
                /*0x301f350*/ bool IsLoaded(string advertisementType, string placement, System.Collections.Generic.IDictionary<string, object> extra);
                /*0x301f544*/ void Load(string advertisementType, string placement, System.Collections.Generic.IDictionary<string, object> extra);
                /*0x301f718*/ void Show(string advertisementType, string placement, System.Collections.Generic.IDictionary<string, object> extra);
                /*0x301f8ec*/ void OnAdvertisementImpression(string advertisementType, string identifier, System.Collections.Generic.IDictionary<string, object> extra);
                /*0x301fac0*/ void OnAdvertisementClick(string advertisementType, string identifier, System.Collections.Generic.IDictionary<string, object> extra);
                /*0x301fc94*/ void SetUserIdentifier(string userIdentifier, System.Collections.Generic.IDictionary<string, object> extra);
                /*0x301fe1c*/ void Discard(string advertisementType, string identifier, System.Collections.Generic.IDictionary<string, object> extra);
                /*0x301fff0*/ void SetCustomProperties(System.Collections.Generic.IDictionary<string, object> properties);
                /*0x3020130*/ Csdk.GluAds.Reward GetReward(string advertisementType, string placement);
                /*0x3020490*/ void AndroidAdvertisingOnCustomActionReceived(string message);
                /*0x3020598*/ void AndroidAdvertisingOnPlacementEvent(string message);
                /*0x302097c*/ void AndroidAdvertisingOnRewardReceived(string message);
                /*0x3020b48*/ void OnDestroy();
            }

            class MarshallingUtil
            {
                static /*0x301f288*/ string JsonArg(object val);
                static /*0x30204c8*/ Csdk.GluAds.CustomAction CustomActionFromString(string message);
                static /*0x30206a4*/ Csdk.GluAds.PlacementEvent PlacementEventFromString(string message);
                static /*0x30202ec*/ Csdk.GluAds.Reward RewardFromString(string message);
            }

            interface ISerializableJsonObject
            {
                /*0x1f30ebc*/ void WriteObject(Csdk.GluAds.Implementation.JsonStringer json);
            }

            interface ISerializableJson
            {
                /*0x1f30ff0*/ void Write(Csdk.GluAds.Implementation.JsonStringer json, string key);
            }

            class JsonStringer
            {
                static /*0x0*/ System.Collections.Generic.IDictionary<char, string> EscapedCharacters;
                /*0x10*/ System.Text.StringBuilder sb;
                /*0x18*/ bool hasElements;

                static /*0x3021be0*/ JsonStringer();
                static /*0x30219ec*/ System.Collections.Generic.IDictionary<char, string> CreateEscapedCharacters();
                /*0x30210b0*/ JsonStringer();
                /*0x302111c*/ Csdk.GluAds.Implementation.JsonStringer EndArray();
                /*0x3021180*/ Csdk.GluAds.Implementation.JsonStringer EndObject();
                /*0x30211b4*/ Csdk.GluAds.Implementation.JsonStringer KeyNull(string key);
                /*0x30212d4*/ Csdk.GluAds.Implementation.JsonStringer KeyArray(string key);
                /*0x3021330*/ Csdk.GluAds.Implementation.JsonStringer KeyObject(string key);
                /*0x3021350*/ Csdk.GluAds.Implementation.JsonStringer KeyValue(string key, bool val);
                /*0x301edc0*/ Csdk.GluAds.Implementation.JsonStringer KeyValue(string key, long val);
                /*0x30213e8*/ Csdk.GluAds.Implementation.JsonStringer KeyValue(string key, ulong val);
                /*0x3021490*/ Csdk.GluAds.Implementation.JsonStringer KeyValue(string key, double val);
                /*0x3021594*/ Csdk.GluAds.Implementation.JsonStringer KeyValue(string key, decimal val);
                /*0x30216a0*/ Csdk.GluAds.Implementation.JsonStringer KeyValue(string key, string val);
                /*0x30219d0*/ string ToString();
                /*0x30212f4*/ void DoBeginScope(char scope, string key);
                /*0x3021150*/ void DoEndScope(char scopeBegin, char scopeEnd);
                /*0x30216e8*/ void DoAppendString(string val);
                /*0x3021224*/ void PreCommon(string key, bool newHasElements);
            }

            class JsonUtil
            {
                static /*0x301e680*/ string ToJson(object val);
                static /*0x3021c38*/ Csdk.GluAds.Implementation.JsonStringer Value(Csdk.GluAds.Implementation.JsonStringer json, object val);
                static /*0x3021c44*/ Csdk.GluAds.Implementation.JsonStringer KeyValue(Csdk.GluAds.Implementation.JsonStringer json, string key, object val);
                static /*0x301e77c*/ Csdk.GluAds.Implementation.JsonStringer OptionalKeyValue(Csdk.GluAds.Implementation.JsonStringer json, string key, object val);
                static /*0x3022594*/ Csdk.GluAds.Implementation.JsonStringer DoKeyValue(Csdk.GluAds.Implementation.JsonStringer json, string key, System.Exception e);
                static /*0x30226a8*/ Csdk.GluAds.Implementation.JsonStringer DoKeyValue(Csdk.GluAds.Implementation.JsonStringer json, string key, System.Collections.IList val);
                static /*0x1f3299c*/ Csdk.GluAds.Implementation.JsonStringer DoKeyValue<T>(Csdk.GluAds.Implementation.JsonStringer json, string key, System.Collections.Generic.IDictionary<string, T> val);
                static /*0x3022978*/ Csdk.GluAds.Implementation.JsonStringer DoKeyValue(Csdk.GluAds.Implementation.JsonStringer json, string key, System.Collections.IDictionary val);
            }

            namespace Json
            {
                class AJson
                {
                    static /*0x3020c9c*/ Csdk.GluAds.Implementation.Json.JsonResult ParseString(string str);
                }

                class JsonLexer
                {
                    static /*0x0*/ System.Collections.Generic.IDictionary<char, Csdk.GluAds.Implementation.Json.TokenType> OtherTokens;
                    static /*0x8*/ System.Collections.Generic.IDictionary<char, char> EscapedCharacters;
                    static /*0x10*/ object TrueValue;
                    static /*0x18*/ object FalseValue;
                    /*0x10*/ System.Text.StringBuilder mStringBuilder;
                    /*0x18*/ string mCurrentString;
                    /*0x20*/ int mCurrentStringOffset;

                    static /*0x3023e78*/ JsonLexer();
                    static /*0x3022f3c*/ System.Collections.Generic.IEnumerable<Csdk.GluAds.Implementation.Json.JsonToken> ProcessString(string str);
                    static /*0x30233b0*/ System.Collections.Generic.IDictionary<char, Csdk.GluAds.Implementation.Json.TokenType> CreateOtherTokens();
                    static /*0x3023514*/ System.Collections.Generic.IDictionary<char, char> CreateEscapedCharacters();
                    /*0x3023274*/ JsonLexer();
                    /*0x30232e0*/ System.Collections.Generic.IEnumerable<Csdk.GluAds.Implementation.Json.JsonToken> Process(string text);
                    /*0x3023630*/ void MunchWhitespaces();
                    /*0x30236e4*/ bool TryMunchString(ref string value);
                    /*0x302373c*/ bool DoTryMunchString(ref string value);
                    /*0x3023a90*/ bool TryMunchNumber(ref decimal value);
                    /*0x3023c40*/ bool TryMunchBool(ref bool value);
                    /*0x3023d38*/ bool TryMunchOther(ref Csdk.GluAds.Implementation.Json.TokenType tokenType);
                    /*0x3023cdc*/ bool TryMunchKeyword(string str);
                    /*0x30239fc*/ System.Text.StringBuilder GetEmptyStringBuilder();
                    /*0x30236c4*/ char PeekCurrentCharacter();
                    /*0x3023a44*/ bool ReadNextCharacter(ref char c);

                    class <Process>d__10 : System.Collections.Generic.IEnumerable<Csdk.GluAds.Implementation.Json.JsonToken>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Csdk.GluAds.Implementation.Json.JsonToken>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Csdk.GluAds.Implementation.Json.JsonToken <>2__current;
                        /*0x28*/ int <>l__initialThreadId;
                        /*0x30*/ string text;
                        /*0x38*/ string <>3__text;
                        /*0x40*/ Csdk.GluAds.Implementation.Json.JsonLexer <>4__this;
                        /*0x48*/ string <stringValue>5__2;
                        /*0x50*/ decimal <numberValue>5__3;
                        /*0x60*/ bool <boolValue>5__4;
                        /*0x64*/ Csdk.GluAds.Implementation.Json.TokenType <otherValue>5__5;

                        /*0x302337c*/ <Process>d__10(int <>1__state);
                        /*0x3023f4c*/ void System.IDisposable.Dispose();
                        /*0x3023f50*/ bool MoveNext();
                        /*0x30242dc*/ Csdk.GluAds.Implementation.Json.JsonToken System.Collections.Generic.IEnumerator<Csdk.GluAds.Implementation.Json.JsonToken>.get_Current();
                        /*0x30242e8*/ void System.Collections.IEnumerator.Reset();
                        /*0x3024320*/ object System.Collections.IEnumerator.get_Current();
                        /*0x302437c*/ System.Collections.Generic.IEnumerator<Csdk.GluAds.Implementation.Json.JsonToken> System.Collections.Generic.IEnumerable<Csdk.GluAds.Implementation.Json.JsonToken>.GetEnumerator();
                        /*0x3024430*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
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

                    static /*0x3024b80*/ JsonNode();
                    static /*0x3024698*/ Csdk.GluAds.Implementation.Json.JsonNode Create(object value, string key);
                    static /*0x3024734*/ Csdk.GluAds.Implementation.Json.JsonNode Object(int size, string key);
                    static /*0x30247c4*/ Csdk.GluAds.Implementation.Json.JsonNode Array(int size, string key);
                    /*0x3024434*/ JsonNode(object value, string key, int size);
                    /*0x3024470*/ bool get_IsObject();
                    /*0x30244d8*/ bool get_IsNull();
                    /*0x3024540*/ bool get_IsBoolean();
                    /*0x30245a4*/ bool get_IsString();
                    /*0x3024608*/ bool get_IsNumber();
                    /*0x3024854*/ decimal AsDecimal();
                    /*0x3024a5c*/ string AsString();
                }

                class JsonParser
                {
                    /*0x10*/ System.Collections.Generic.IList<Csdk.GluAds.Implementation.Json.JsonNode> mNodes;
                    /*0x18*/ System.Collections.Generic.IEnumerator<Csdk.GluAds.Implementation.Json.JsonToken> mEnum;
                    /*0x20*/ Csdk.GluAds.Implementation.Json.JsonToken mCurrentToken;

                    /*0x3022f9c*/ JsonParser();
                    /*0x3024c4c*/ Csdk.GluAds.Implementation.Json.JsonToken get_CurrentToken();
                    /*0x3022fa4*/ Csdk.GluAds.Implementation.Json.JsonResult Parse(System.Collections.Generic.IEnumerable<Csdk.GluAds.Implementation.Json.JsonToken> tokens);
                    /*0x3024dd0*/ void ParseObject(string key);
                    /*0x30250e0*/ void ParseArray(string key);
                    /*0x3025534*/ string ParseString();
                    /*0x3025574*/ void ParseValue(string key);
                    /*0x30253f4*/ void Munch(Csdk.GluAds.Implementation.Json.TokenType token);
                    /*0x3024c58*/ void MoveNext();
                    /*0x3025760*/ System.Exception ThrowInvalidJsonException(string message);
                    /*0x30253d8*/ System.Exception ThrowInvalidJsonException(string format, object[] args);
                }

                struct JsonResult : System.Collections.Generic.IEnumerable<Csdk.GluAds.Implementation.Json.JsonResult>, System.Collections.IEnumerable
                {
                    static /*0x0*/ Csdk.GluAds.Implementation.Json.JsonResult Empty;
                    static /*0x10*/ System.Collections.Generic.IList<Csdk.GluAds.Implementation.Json.JsonResult> EmptyList;
                    /*0x10*/ System.Collections.Generic.IList<Csdk.GluAds.Implementation.Json.JsonNode> mNodes;
                    /*0x18*/ int mIndex;
                    /*0x1c*/ int mEnd;

                    static /*0x3025ef4*/ JsonResult();
                    static /*0x3021050*/ int op_Implicit(Csdk.GluAds.Implementation.Json.JsonResult result);
                    static /*0x3020f30*/ string op_Implicit(Csdk.GluAds.Implementation.Json.JsonResult result);
                    /*0x30254cc*/ JsonResult(System.Collections.Generic.IList<Csdk.GluAds.Implementation.Json.JsonNode> nodes);
                    /*0x30257a4*/ JsonResult(System.Collections.Generic.IList<Csdk.GluAds.Implementation.Json.JsonNode> nodes, int index);
                    /*0x3025888*/ bool get_HasValue();
                    /*0x3020f90*/ bool get_IsObject();
                    /*0x3020d34*/ Csdk.GluAds.Implementation.Json.JsonResult get_Item(string key);
                    /*0x3025a50*/ int AsInt32();
                    /*0x3025b9c*/ decimal AsDecimal();
                    /*0x3025ae0*/ string AsString();
                    /*0x3025ca8*/ System.Collections.Generic.IEnumerable<Csdk.GluAds.Implementation.Json.JsonResult> AsEnumerable();
                    /*0x3025d5c*/ System.Collections.Generic.IEnumerator<Csdk.GluAds.Implementation.Json.JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluAds.Implementation.Json.JsonResult>.GetEnumerator();
                    /*0x3025e28*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    /*0x3025898*/ Csdk.GluAds.Implementation.Json.JsonNode GetNode();
                    /*0x3025990*/ int GetNextNodeIndex(int index);
                    /*0x3025964*/ Csdk.GluAds.Implementation.Json.JsonResult FromIndex(int index);

                    class <AsEnumerable>d__42 : System.Collections.Generic.IEnumerable<Csdk.GluAds.Implementation.Json.JsonResult>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Csdk.GluAds.Implementation.Json.JsonResult>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ Csdk.GluAds.Implementation.Json.JsonResult <>2__current;
                        /*0x28*/ int <>l__initialThreadId;
                        /*0x30*/ Csdk.GluAds.Implementation.Json.JsonResult <>4__this;
                        /*0x40*/ Csdk.GluAds.Implementation.Json.JsonResult <>3__<>4__this;
                        /*0x50*/ int <nodeIndex>5__2;

                        /*0x3025d28*/ <AsEnumerable>d__42(int <>1__state);
                        /*0x3025f70*/ void System.IDisposable.Dispose();
                        /*0x3025f74*/ bool MoveNext();
                        /*0x302616c*/ Csdk.GluAds.Implementation.Json.JsonResult System.Collections.Generic.IEnumerator<Csdk.GluAds.Implementation.Json.JsonResult>.get_Current();
                        /*0x3026178*/ void System.Collections.IEnumerator.Reset();
                        /*0x30261b0*/ object System.Collections.IEnumerator.get_Current();
                        /*0x302620c*/ System.Collections.Generic.IEnumerator<Csdk.GluAds.Implementation.Json.JsonResult> System.Collections.Generic.IEnumerable<Csdk.GluAds.Implementation.Json.JsonResult>.GetEnumerator();
                        /*0x30262b4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                struct JsonToken
                {
                    /*0x10*/ Csdk.GluAds.Implementation.Json.TokenType Type;
                    /*0x18*/ object Value;

                    /*0x30242cc*/ JsonToken(Csdk.GluAds.Implementation.Json.TokenType type, object value);
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
