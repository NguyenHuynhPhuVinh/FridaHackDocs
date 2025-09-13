class <Module>
{
}

class PerftestManager : UnityEngine.MonoBehaviour
{
    static /*0x0*/ UnityEngine.AndroidJavaObject appguardClass;

    static /*0x2abb8ac*/ void SetId(string userId);
    static /*0x2abbad8*/ void SetCallback(string classPath, string functionName, bool useMsgBox);
    static /*0x2abbe1c*/ void ED(byte[] data);
    static /*0x2abbfec*/ void B(int blockPolicy);
    /*0x2abc238*/ PerftestManager();
}

namespace SimpleJSON
{
    enum JSONBinaryTag
    {
        Array = 1,
        Class = 2,
        Value = 3,
        IntValue = 4,
        DoubleValue = 5,
        BoolValue = 6,
        FloatValue = 7,
    }

    class JSONNode
    {
        static /*0x2abaa44*/ SimpleJSON.JSONNode op_Implicit(string s);
        static /*0x2abaaa4*/ string op_Implicit(SimpleJSON.JSONNode d);
        static /*0x2abaaf0*/ bool op_Equality(SimpleJSON.JSONNode a, object b);
        static /*0x2abab84*/ bool op_Inequality(SimpleJSON.JSONNode a, object b);
        static /*0x2ab8b20*/ string Escape(string aText);
        static /*0x2ab6b04*/ SimpleJSON.JSONNode Parse(string aJSON);
        static /*0x2abb08c*/ SimpleJSON.JSONNode Deserialize(System.IO.BinaryReader aReader);
        static /*0x2abb454*/ SimpleJSON.JSONNode LoadFromCompressedFile(string aFileName);
        static /*0x2abb4a8*/ SimpleJSON.JSONNode LoadFromCompressedStream(System.IO.Stream aData);
        static /*0x2abb4fc*/ SimpleJSON.JSONNode LoadFromCompressedBase64(string aBase64);
        static /*0x2abb550*/ SimpleJSON.JSONNode LoadFromStream(System.IO.Stream aData);
        static /*0x2abb6b0*/ SimpleJSON.JSONNode LoadFromFile(string aFileName);
        static /*0x2abb7f0*/ SimpleJSON.JSONNode LoadFromBase64(string aBase64);
        /*0x2ab7d54*/ JSONNode();
        /*0x2aba2d8*/ void Add(string aKey, SimpleJSON.JSONNode aItem);
        /*0x2aba2dc*/ SimpleJSON.JSONNode get_Item(int aIndex);
        /*0x2aba2e4*/ void set_Item(int aIndex, SimpleJSON.JSONNode value);
        /*0x2aba2e8*/ SimpleJSON.JSONNode get_Item(string aKey);
        /*0x2aba2f0*/ void set_Item(string aKey, SimpleJSON.JSONNode value);
        /*0x2aba2f4*/ string get_Value();
        /*0x2aba338*/ void set_Value(string value);
        /*0x2aba33c*/ int get_Count();
        /*0x2aba344*/ void Add(SimpleJSON.JSONNode aItem);
        /*0x2aba3a8*/ SimpleJSON.JSONNode Remove(string aKey);
        /*0x2aba3b0*/ SimpleJSON.JSONNode Remove(int aIndex);
        /*0x2aba3b8*/ SimpleJSON.JSONNode Remove(SimpleJSON.JSONNode aNode);
        /*0x2aba3c0*/ System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> get_Childs();
        /*0x2aba464*/ System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> get_DeepChilds();
        /*0x2aba518*/ string ToString();
        /*0x2aba55c*/ string ToString(string aPrefix);
        /*0x2aba5a0*/ uint get_AsUInt();
        /*0x2aba5e0*/ void set_AsUInt(uint value);
        /*0x2aba620*/ int get_AsInt();
        /*0x2aba660*/ void set_AsInt(int value);
        /*0x2aba6a0*/ float get_AsFloat();
        /*0x2aba6e4*/ void set_AsFloat(float value);
        /*0x2aba724*/ double get_AsDouble();
        /*0x2aba7c4*/ void set_AsDouble(double value);
        /*0x2aba804*/ bool get_AsBool();
        /*0x2aba8c8*/ void set_AsBool(bool value);
        /*0x2aba94c*/ SimpleJSON.JSONArray get_AsArray();
        /*0x2aba9c8*/ SimpleJSON.JSONClass get_AsObject();
        /*0x2ababa0*/ bool Equals(object obj);
        /*0x2ab9d70*/ int GetHashCode();
        /*0x2ababac*/ void Serialize(System.IO.BinaryWriter aWriter);
        /*0x2ababb0*/ void SaveToStream(System.IO.Stream aData);
        /*0x2abac2c*/ void SaveToCompressedStream(System.IO.Stream aData);
        /*0x2abac80*/ void SaveToCompressedFile(string aFileName);
        /*0x2abacd4*/ string SaveToCompressedBase64();
        /*0x2abad28*/ void SaveToFile(string aFileName);
        /*0x2abaeb8*/ string SaveToBase64();

        class <get_Childs>d__17 : System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ SimpleJSON.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;

            /*0x2aba42c*/ <get_Childs>d__17(int <>1__state);
            /*0x2abcd00*/ void System.IDisposable.Dispose();
            /*0x2abcd04*/ bool MoveNext();
            /*0x2abcd1c*/ SimpleJSON.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.get_Current();
            /*0x2abcd24*/ void System.Collections.IEnumerator.Reset();
            /*0x2abcd64*/ object System.Collections.IEnumerator.get_Current();
            /*0x2abcd6c*/ System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator();
            /*0x2abce00*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <get_DeepChilds>d__19 : System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ SimpleJSON.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ SimpleJSON.JSONNode <>4__this;
            /*0x30*/ System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> <>7__wrap1;
            /*0x38*/ System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> <>7__wrap2;

            /*0x2aba4e0*/ <get_DeepChilds>d__19(int <>1__state);
            /*0x2abce04*/ void System.IDisposable.Dispose();
            /*0x2abd00c*/ bool MoveNext();
            /*0x2abcf50*/ void <>m__Finally1();
            /*0x2abce94*/ void <>m__Finally2();
            /*0x2abd440*/ SimpleJSON.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.get_Current();
            /*0x2abd448*/ void System.Collections.IEnumerator.Reset();
            /*0x2abd488*/ object System.Collections.IEnumerator.get_Current();
            /*0x2abd490*/ System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator();
            /*0x2abd538*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }
    }

    class JSONArray : SimpleJSON.JSONNode, System.Collections.IEnumerable
    {
        /*0x10*/ System.Collections.Generic.List<SimpleJSON.JSONNode> m_List;

        /*0x2ab7cdc*/ JSONArray();
        /*0x2ab7234*/ SimpleJSON.JSONNode get_Item(int aIndex);
        /*0x2ab731c*/ void set_Item(int aIndex, SimpleJSON.JSONNode value);
        /*0x2ab73d4*/ SimpleJSON.JSONNode get_Item(string aKey);
        /*0x2ab7434*/ void set_Item(string aKey, SimpleJSON.JSONNode value);
        /*0x2ab7498*/ int get_Count();
        /*0x2ab74e4*/ void Add(string aKey, SimpleJSON.JSONNode aItem);
        /*0x2ab7548*/ SimpleJSON.JSONNode Remove(int aIndex);
        /*0x2ab7608*/ SimpleJSON.JSONNode Remove(SimpleJSON.JSONNode aNode);
        /*0x2ab7674*/ System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> get_Childs();
        /*0x2ab7728*/ System.Collections.IEnumerator GetEnumerator();
        /*0x2ab77c0*/ string ToString();
        /*0x2ab799c*/ string ToString(string aPrefix);
        /*0x2ab7bf4*/ void Serialize(System.IO.BinaryWriter aWriter);

        class <get_Childs>d__13 : System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ SimpleJSON.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ SimpleJSON.JSONArray <>4__this;
            /*0x30*/ System.Collections.Generic.List.Enumerator<SimpleJSON.JSONNode> <>7__wrap1;

            /*0x2ab76f0*/ <get_Childs>d__13(int <>1__state);
            /*0x2abc474*/ void System.IDisposable.Dispose();
            /*0x2abc4e4*/ bool MoveNext();
            /*0x2abc490*/ void <>m__Finally1();
            /*0x2abc658*/ SimpleJSON.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.get_Current();
            /*0x2abc660*/ void System.Collections.IEnumerator.Reset();
            /*0x2abc6a0*/ object System.Collections.IEnumerator.get_Current();
            /*0x2abc6a8*/ System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator();
            /*0x2abc750*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <GetEnumerator>d__14 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ SimpleJSON.JSONArray <>4__this;
            /*0x28*/ System.Collections.Generic.List.Enumerator<SimpleJSON.JSONNode> <>7__wrap1;

            /*0x2ab7794*/ <GetEnumerator>d__14(int <>1__state);
            /*0x2abc240*/ void System.IDisposable.Dispose();
            /*0x2abc2b0*/ bool MoveNext();
            /*0x2abc25c*/ void <>m__Finally1();
            /*0x2abc424*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x2abc42c*/ void System.Collections.IEnumerator.Reset();
            /*0x2abc46c*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class JSONClass : SimpleJSON.JSONNode, System.Collections.IEnumerable
    {
        /*0x10*/ System.Collections.Generic.Dictionary<string, SimpleJSON.JSONNode> m_Dict;

        /*0x2ab94a4*/ JSONClass();
        /*0x2ab7d5c*/ SimpleJSON.JSONNode get_Item(string aKey);
        /*0x2ab7e64*/ void set_Item(string aKey, SimpleJSON.JSONNode value);
        /*0x2ab7f34*/ SimpleJSON.JSONNode get_Item(int aIndex);
        /*0x2ab7fe0*/ void set_Item(int aIndex, SimpleJSON.JSONNode value);
        /*0x2ab80c0*/ int get_Count();
        /*0x2ab8114*/ void Add(string aKey, SimpleJSON.JSONNode aItem);
        /*0x2ab8260*/ SimpleJSON.JSONNode Remove(string aKey);
        /*0x2ab8330*/ SimpleJSON.JSONNode Remove(int aIndex);
        /*0x2ab8418*/ SimpleJSON.JSONNode Remove(SimpleJSON.JSONNode aNode);
        /*0x2ab85ec*/ System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode> get_Childs();
        /*0x2ab86a0*/ System.Collections.IEnumerator GetEnumerator();
        /*0x2ab8738*/ string ToString();
        /*0x2ab8cec*/ string ToString(string aPrefix);
        /*0x2ab9144*/ void Serialize(System.IO.BinaryWriter aWriter);
        /*0x2ab9340*/ System.Collections.ArrayList GetKeys();

        class <>c__DisplayClass12_0
        {
            /*0x10*/ SimpleJSON.JSONNode aNode;

            /*0x2ab85e4*/ <>c__DisplayClass12_0();
            /*0x2abc754*/ bool <Remove>b__0(System.Collections.Generic.KeyValuePair<string, SimpleJSON.JSONNode> k);
        }

        class <get_Childs>d__14 : System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ SimpleJSON.JSONNode <>2__current;
            /*0x20*/ int <>l__initialThreadId;
            /*0x28*/ SimpleJSON.JSONClass <>4__this;
            /*0x30*/ System.Collections.Generic.Dictionary.Enumerator<string, SimpleJSON.JSONNode> <>7__wrap1;

            /*0x2ab8668*/ <get_Childs>d__14(int <>1__state);
            /*0x2abca0c*/ void System.IDisposable.Dispose();
            /*0x2abca7c*/ bool MoveNext();
            /*0x2abca28*/ void <>m__Finally1();
            /*0x2abcc04*/ SimpleJSON.JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.get_Current();
            /*0x2abcc0c*/ void System.Collections.IEnumerator.Reset();
            /*0x2abcc4c*/ object System.Collections.IEnumerator.get_Current();
            /*0x2abcc54*/ System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator();
            /*0x2abccfc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class <GetEnumerator>d__15 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ SimpleJSON.JSONClass <>4__this;
            /*0x28*/ System.Collections.Generic.Dictionary.Enumerator<string, SimpleJSON.JSONNode> <>7__wrap1;

            /*0x2ab870c*/ <GetEnumerator>d__15(int <>1__state);
            /*0x2abc7a4*/ void System.IDisposable.Dispose();
            /*0x2abc814*/ bool MoveNext();
            /*0x2abc7c0*/ void <>m__Finally1();
            /*0x2abc9bc*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x2abc9c4*/ void System.Collections.IEnumerator.Reset();
            /*0x2abca04*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class JSONData : SimpleJSON.JSONNode
    {
        /*0x10*/ string m_Data;

        /*0x2ab952c*/ JSONData(string aData);
        /*0x2ab9558*/ JSONData(float aData);
        /*0x2ab959c*/ JSONData(double aData);
        /*0x2ab95e0*/ JSONData(bool aData);
        /*0x2ab961c*/ JSONData(int aData);
        /*0x2ab951c*/ string get_Value();
        /*0x2ab9524*/ void set_Value(string value);
        /*0x2ab9658*/ string ToString();
        /*0x2ab96b4*/ string ToString(string aPrefix);
        /*0x2ab9710*/ void Serialize(System.IO.BinaryWriter aWriter);
    }

    class JSONLazyCreator : SimpleJSON.JSONNode
    {
        /*0x10*/ SimpleJSON.JSONNode m_Node;
        /*0x18*/ string m_Key;

        static /*0x2ab9d20*/ bool op_Equality(SimpleJSON.JSONLazyCreator a, object b);
        static /*0x2ab9d38*/ bool op_Inequality(SimpleJSON.JSONLazyCreator a, object b);
        /*0x2ab72f0*/ JSONLazyCreator(SimpleJSON.JSONNode aNode);
        /*0x2ab7e2c*/ JSONLazyCreator(SimpleJSON.JSONNode aNode, string aKey);
        /*0x2ab99d4*/ void Set(SimpleJSON.JSONNode aVal);
        /*0x2ab9a34*/ SimpleJSON.JSONNode get_Item(int aIndex);
        /*0x2ab9a94*/ void set_Item(int aIndex, SimpleJSON.JSONNode value);
        /*0x2ab9b18*/ SimpleJSON.JSONNode get_Item(string aKey);
        /*0x2ab9b84*/ void set_Item(string aKey, SimpleJSON.JSONNode value);
        /*0x2ab9c10*/ void Add(SimpleJSON.JSONNode aItem);
        /*0x2ab9c94*/ void Add(string aKey, SimpleJSON.JSONNode aItem);
        /*0x2ab9d50*/ bool Equals(object obj);
        /*0x2ab9d68*/ int GetHashCode();
        /*0x2ab9d78*/ string ToString();
        /*0x2ab9dbc*/ string ToString(string aPrefix);
        /*0x2ab9e00*/ int get_AsInt();
        /*0x2ab9e80*/ void set_AsInt(int value);
        /*0x2ab9f04*/ float get_AsFloat();
        /*0x2ab9f84*/ void set_AsFloat(float value);
        /*0x2aba008*/ double get_AsDouble();
        /*0x2aba088*/ void set_AsDouble(double value);
        /*0x2aba10c*/ bool get_AsBool();
        /*0x2aba18c*/ void set_AsBool(bool value);
        /*0x2aba210*/ SimpleJSON.JSONArray get_AsArray();
        /*0x2aba274*/ SimpleJSON.JSONClass get_AsObject();
    }

    class JSON
    {
        static /*0x2ab6b00*/ SimpleJSON.JSONNode Parse(string aJSON);
    }
}

namespace SimpleDiskUtils
{
    class DiskUtils
    {
        static /*0x2ab5ffc*/ int CheckAvailableSpace(bool isExternalStorage);
        static /*0x2ab6144*/ int CheckTotalSpace(bool isExternalStorage);
        static /*0x2ab628c*/ int CheckBusySpace(bool isExternalStorage);
        static /*0x2ab63d4*/ void DeleteFile(string filePath);
        static /*0x2ab6410*/ void SaveFile(object obj, string filePath);
        static /*0x2ab655c*/ void SaveFile(object obj, string dirPath, string fileName);
        static T LoadFile<T>(string filePath);
        static /*0x2ab68fc*/ void SaveTextFile(string str, string filePath);
        static /*0x2ab69c4*/ void SaveTextFile(string str, string dirPath, string fileName);
        static string LoadTextFile<T>(string filePath);
        static /*0x2ab66d4*/ byte[] ObjectToByteArray(object obj);
        static T ByteArrayToObject<T>(byte[] bytes);
        /*0x2ab6af8*/ DiskUtils();
    }
}
