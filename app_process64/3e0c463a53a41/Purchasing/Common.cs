class <Module>
{
}

namespace UnityEngine
{
    namespace Purchasing
    {
        interface INativeStore
        {
            /*0x380d83c*/ void RetrieveProducts(string json);
            /*0x380d93c*/ void Purchase(string productJSON, string developerPayload);
            /*0x380d93c*/ void FinishTransaction(string productJSON, string transactionID);
        }

        class UnityPurchasingCallback : System.MulticastDelegate
        {
            /*0x73616a4*/ UnityPurchasingCallback(object object, nint method);
            /*0x7361758*/ void Invoke(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored);
        }

        class MiniJson
        {
            static /*0x7361770*/ string JsonEncode(object json);
            static /*0x7361778*/ object JsonDecode(string json);
        }

        namespace MiniJSON
        {
            class Json
            {
                static /*0x7361784*/ object Deserialize(string json);
                static /*0x7361774*/ string Serialize(object obj);

                class Parser : System.IDisposable
                {
                    /*0x10*/ System.IO.StringReader json;

                    static /*0x73619ac*/ bool IsWordBreak(char c);
                    static /*0x7361790*/ object Parse(string jsonString);
                    /*0x7361a3c*/ Parser(string jsonString);
                    /*0x7361ad4*/ void Dispose();
                    /*0x7361b04*/ System.Collections.Generic.Dictionary<string, object> ParseObject();
                    /*0x736206c*/ System.Collections.Generic.List<object> ParseArray();
                    /*0x7361ab8*/ object ParseValue();
                    /*0x7362198*/ object ParseByToken(UnityEngine.Purchasing.MiniJSON.Json.Parser.TOKEN token);
                    /*0x7361dec*/ string ParseString();
                    /*0x7362234*/ object ParseNumber();
                    /*0x736249c*/ void EatWhitespace();
                    /*0x7362520*/ char get_PeekChar();
                    /*0x7362370*/ char get_NextChar();
                    /*0x73623e8*/ string get_NextWord();
                    /*0x7361c28*/ UnityEngine.Purchasing.MiniJSON.Json.Parser.TOKEN get_NextToken();

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

                    static /*0x7361938*/ string Serialize(object obj);
                    /*0x7362598*/ Serializer();
                    /*0x7362604*/ void SerializeValue(object value);
                    /*0x7362dbc*/ void SerializeObject(System.Collections.IDictionary obj);
                    /*0x7362a5c*/ void SerializeArray(System.Collections.IList anArray);
                    /*0x73627a0*/ void SerializeString(string str);
                    /*0x7363248*/ void SerializeOther(object value);
                }
            }

            class MiniJsonExtensions
            {
                static /*0x7363460*/ string GetString(System.Collections.Generic.Dictionary<string, object> dic, string key, string defaultValue);
                static /*0x7363510*/ string toJson(System.Collections.Generic.Dictionary<string, object> obj);
                static /*0x7363514*/ string toJson(System.Collections.Generic.Dictionary<string, string> obj);
                static /*0x7363518*/ System.Collections.Generic.List<object> ArrayListFromJson(string json);
                static /*0x736359c*/ System.Collections.Generic.Dictionary<string, object> HashtableFromJson(string json);
            }
        }
    }
}
