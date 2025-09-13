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
            /*0x2b1a514*/ UnityPurchasingCallback(object object, nint method);
            /*0x2b1a574*/ void Invoke(string subject, string payload, string receipt, string transactionId);
            /*0x2b1a94c*/ System.IAsyncResult BeginInvoke(string subject, string payload, string receipt, string transactionId, System.AsyncCallback callback, object object);
            /*0x2b1a980*/ void EndInvoke(System.IAsyncResult result);
        }

        class MiniJson
        {
            static /*0x2b1a338*/ string JsonEncode(object json);
            static /*0x2b1a33c*/ object JsonDecode(string json);
        }

        namespace MiniJSON
        {
            class Json
            {
                static /*0x2b1a140*/ object Deserialize(string json);
                static /*0x2b1a2bc*/ string Serialize(object obj);

                class Parser : System.IDisposable
                {
                    /*0x10*/ System.IO.StringReader json;

                    static /*0x2b1a98c*/ bool IsWordBreak(char c);
                    static /*0x2b1a14c*/ object Parse(string jsonString);
                    /*0x2b1aa34*/ Parser(string jsonString);
                    /*0x2b1aad4*/ void Dispose();
                    /*0x2b1ab08*/ System.Collections.Generic.Dictionary<string, object> ParseObject();
                    /*0x2b1b088*/ System.Collections.Generic.List<object> ParseArray();
                    /*0x2b1aaac*/ object ParseValue();
                    /*0x2b1b170*/ object ParseByToken(UnityEngine.Purchasing.MiniJSON.Json.Parser.TOKEN token);
                    /*0x2b1adf4*/ string ParseString();
                    /*0x2b1b248*/ object ParseNumber();
                    /*0x2b1b518*/ void EatWhitespace();
                    /*0x2b1b5c8*/ char get_PeekChar();
                    /*0x2b1b3dc*/ char get_NextChar();
                    /*0x2b1b460*/ string get_NextWord();
                    /*0x2b1ac30*/ UnityEngine.Purchasing.MiniJSON.Json.Parser.TOKEN get_NextToken();

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

                    static /*0x2b1a2c0*/ string Serialize(object obj);
                    /*0x2b1b64c*/ Serializer();
                    /*0x2b1b6b4*/ void SerializeValue(object value);
                    /*0x2b1be70*/ void SerializeObject(System.Collections.IDictionary obj);
                    /*0x2b1bb68*/ void SerializeArray(System.Collections.IList anArray);
                    /*0x2b1b8a0*/ void SerializeString(string str);
                    /*0x2b1c2b0*/ void SerializeOther(object value);
                }
            }

            class MiniJsonExtensions
            {
                static /*0x2b1a348*/ string GetString(System.Collections.Generic.Dictionary<string, object> dic, string key, string defaultValue);
                static /*0x2b1a3fc*/ string toJson(System.Collections.Generic.Dictionary<string, object> obj);
                static /*0x2b1a400*/ string toJson(System.Collections.Generic.Dictionary<string, string> obj);
                static /*0x2b1a404*/ System.Collections.Generic.List<object> ArrayListFromJson(string json);
                static /*0x2b1a48c*/ System.Collections.Generic.Dictionary<string, object> HashtableFromJson(string json);
            }
        }
    }
}
