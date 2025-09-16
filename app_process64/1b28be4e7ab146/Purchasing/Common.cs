class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        interface INativeStore
        {
            /*0x3816710*/ void RetrieveProducts(string json);
            /*0x3816810*/ void Purchase(string productJSON, string developerPayload);
            /*0x3816810*/ void FinishTransaction(string productJSON, string transactionID);
        }

        class UnityPurchasingCallback : System.MulticastDelegate
        {
            /*0x7378ad4*/ UnityPurchasingCallback(object object, nint method);
            /*0x7378b88*/ void Invoke(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored);
        }

        class MiniJson
        {
            static /*0x7378ba0*/ string JsonEncode(object json);
            static /*0x7378ba8*/ object JsonDecode(string json);
        }

        namespace MiniJSON
        {
            class Json
            {
                static /*0x7378bb4*/ object Deserialize(string json);
                static /*0x7378ba4*/ string Serialize(object obj);

                class Parser : System.IDisposable
                {
                    /*0x10*/ System.IO.StringReader json;

                    static /*0x7378ddc*/ bool IsWordBreak(char c);
                    static /*0x7378bc0*/ object Parse(string jsonString);
                    /*0x7378e6c*/ Parser(string jsonString);
                    /*0x7378f04*/ void Dispose();
                    /*0x7378f34*/ System.Collections.Generic.Dictionary<string, object> ParseObject();
                    /*0x737949c*/ System.Collections.Generic.List<object> ParseArray();
                    /*0x7378ee8*/ object ParseValue();
                    /*0x73795c8*/ object ParseByToken(UnityEngine.Purchasing.MiniJSON.Json.Parser.TOKEN token);
                    /*0x737921c*/ string ParseString();
                    /*0x7379664*/ object ParseNumber();
                    /*0x73798cc*/ void EatWhitespace();
                    /*0x7379950*/ char get_PeekChar();
                    /*0x73797a0*/ char get_NextChar();
                    /*0x7379818*/ string get_NextWord();
                    /*0x7379058*/ UnityEngine.Purchasing.MiniJSON.Json.Parser.TOKEN get_NextToken();

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

                    static /*0x7378d68*/ string Serialize(object obj);
                    /*0x73799c8*/ Serializer();
                    /*0x7379a34*/ void SerializeValue(object value);
                    /*0x737a1ec*/ void SerializeObject(System.Collections.IDictionary obj);
                    /*0x7379e8c*/ void SerializeArray(System.Collections.IList anArray);
                    /*0x7379bd0*/ void SerializeString(string str);
                    /*0x737a678*/ void SerializeOther(object value);
                }
            }

            class MiniJsonExtensions
            {
                static /*0x737a890*/ string GetString(System.Collections.Generic.Dictionary<string, object> dic, string key, string defaultValue);
                static /*0x737a940*/ string toJson(System.Collections.Generic.Dictionary<string, object> obj);
                static /*0x737a944*/ string toJson(System.Collections.Generic.Dictionary<string, string> obj);
                static /*0x737a948*/ System.Collections.Generic.List<object> ArrayListFromJson(string json);
                static /*0x737a9cc*/ System.Collections.Generic.Dictionary<string, object> HashtableFromJson(string json);
            }
        }
    }
}
