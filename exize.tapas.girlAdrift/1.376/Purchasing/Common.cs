class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        interface INativeStore
        {
            void RetrieveProducts(string json);
            void Purchase(string productJSON, string developerPayload);
            void FinishTransaction(string productJSON, string transactionID);
        }

        class UnityPurchasingCallback : System.MulticastDelegate
        {
            /*0x18ae960*/ UnityPurchasingCallback(object object, nint method);
            /*0x18aea38*/ void Invoke(string subject, string payload, string receipt, string transactionId);
            /*0x18aea4c*/ System.IAsyncResult BeginInvoke(string subject, string payload, string receipt, string transactionId, System.AsyncCallback callback, object object);
            /*0x18aea78*/ void EndInvoke(System.IAsyncResult result);
        }

        class MiniJson
        {
            static /*0x18aea84*/ string JsonEncode(object json);
            static /*0x18aea8c*/ object JsonDecode(string json);
            /*0x18aeaa4*/ MiniJson();
        }

        class VersionCheck
        {
            static /*0x18aeaac*/ bool GreaterThanOrEqual(string versionA, string versionB);
            static /*0x18aeb2c*/ bool GreaterThan(string versionA, string versionB);
            static /*0x18aeac4*/ bool LessThan(string versionA, string versionB);
            static /*0x18aeb44*/ bool LessThanOrEqual(string versionA, string versionB);
            static /*0x18aebd4*/ bool Equal(string versionA, string versionB);
            static /*0x18aec14*/ int MajorVersion(string version);
            static /*0x18aed24*/ int MinorVersion(string version);
            static /*0x18aed2c*/ int PatchVersion(string version);
            static /*0x18aeb84*/ UnityEngine.Purchasing.VersionCheck.Version Parse(string version);
            static /*0x18aec1c*/ int PartialVersion(string version, int index);

            struct Version
            {
                /*0x10*/ int major;
                /*0x14*/ int minor;
                /*0x18*/ int patch;
            }
        }

        namespace MiniJSON
        {
            class Json
            {
                static /*0x18aea98*/ object Deserialize(string json);
                static /*0x18aea88*/ string Serialize(object obj);

                class Parser : System.IDisposable
                {
                    static string WORD_BREAK = "{}[],:"";
                    /*0x10*/ System.IO.StringReader json;

                    static /*0x18aef44*/ bool IsWordBreak(char c);
                    static /*0x18aed34*/ object Parse(string jsonString);
                    /*0x18aefe0*/ Parser(string jsonString);
                    /*0x18af078*/ void Dispose();
                    /*0x18af0a0*/ System.Collections.Generic.Dictionary<string, object> ParseObject();
                    /*0x18af5e8*/ System.Collections.Generic.List<object> ParseArray();
                    /*0x18af05c*/ object ParseValue();
                    /*0x18af70c*/ object ParseByToken(UnityEngine.Purchasing.MiniJSON.Json.Parser.TOKEN token);
                    /*0x18af388*/ string ParseString();
                    /*0x18af7f4*/ object ParseNumber();
                    /*0x18afa6c*/ void EatWhitespace();
                    /*0x18afb10*/ char get_PeekChar();
                    /*0x18af948*/ char get_NextChar();
                    /*0x18af9c0*/ string get_NextWord();
                    /*0x18af1c4*/ UnityEngine.Purchasing.MiniJSON.Json.Parser.TOKEN get_NextToken();

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

                    static /*0x18aeed0*/ string Serialize(object obj);
                    /*0x18afb88*/ Serializer();
                    /*0x18afbf4*/ void SerializeValue(object value);
                    /*0x18b03e0*/ void SerializeObject(System.Collections.IDictionary obj);
                    /*0x18b0080*/ void SerializeArray(System.Collections.IList anArray);
                    /*0x18afdc4*/ void SerializeString(string str);
                    /*0x18b086c*/ void SerializeOther(object value);
                }
            }

            class MiniJsonExtensions
            {
                static /*0x18b0b3c*/ System.Collections.Generic.Dictionary<string, object> GetHash(System.Collections.Generic.Dictionary<string, object> dic, string key);
                static T GetEnum<T>(System.Collections.Generic.Dictionary<string, object> dic, string key);
                static /*0x18b0be0*/ string GetString(System.Collections.Generic.Dictionary<string, object> dic, string key, string defaultValue);
                static /*0x18b0c90*/ long GetLong(System.Collections.Generic.Dictionary<string, object> dic, string key);
                static /*0x18b0d38*/ System.Collections.Generic.List<string> GetStringList(System.Collections.Generic.Dictionary<string, object> dic, string key);
                static /*0x18b0fe4*/ bool GetBool(System.Collections.Generic.Dictionary<string, object> dic, string key);
                static T Get<T>(System.Collections.Generic.Dictionary<string, object> dic, string key);
                static /*0x18b10bc*/ string toJson(System.Collections.Generic.Dictionary<string, object> obj);
                static /*0x18b10c0*/ string toJson(System.Collections.Generic.Dictionary<string, string> obj);
                static /*0x18b10c4*/ string toJson(string[] array);
                static /*0x18b11e4*/ System.Collections.Generic.List<object> ArrayListFromJson(string json);
                static /*0x18b1268*/ System.Collections.Generic.Dictionary<string, object> HashtableFromJson(string json);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ long F642F9B52A17FCAEDFF8B008B645A49C9B6C1C229ACA7ABC830E359B614ABCD2;
}
