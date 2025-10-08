class <Module>
{
}

namespace SimpleJSON
{
    enum JSONTextMode
    {
        Compact = 0,
        Indent = 1,
    }

    class JSONNode
    {
        static /*0x0*/ System.Text.StringBuilder m_EscapeBuilder;

        static /*0x3652438*/ JSONNode();
        static /*0x365116c*/ SimpleJSON.JSONNode op_Implicit(string s);
        static /*0x3651238*/ string op_Implicit(SimpleJSON.JSONNode d);
        static /*0x3651420*/ SimpleJSON.JSONNode op_Implicit(double n);
        static /*0x36514ec*/ SimpleJSON.JSONNode op_Implicit(int n);
        static /*0x3651544*/ int op_Implicit(SimpleJSON.JSONNode d);
        static /*0x36515c8*/ SimpleJSON.JSONNode op_Implicit(bool b);
        static /*0x36512bc*/ bool op_Equality(SimpleJSON.JSONNode a, object b);
        static /*0x3651690*/ bool op_Inequality(SimpleJSON.JSONNode a, object b);
        static /*0x3651714*/ string Escape(string aText);
        static /*0x3651aa4*/ void ParseElement(SimpleJSON.JSONNode ctx, string token, string tokenName, bool quoted);
        static /*0x3651c98*/ SimpleJSON.JSONNode Parse(string aJSON);
        /*0x3652430*/ JSONNode();
        /*0x3650fd0*/ SimpleJSON.JSONNode get_Item(string aKey);
        /*0x3650fd8*/ void set_Item(string aKey, SimpleJSON.JSONNode value);
        /*0x3650fdc*/ string get_Value();
        /*0x365101c*/ void Add(string aKey, SimpleJSON.JSONNode aItem);
        /*0x3651020*/ void Add(SimpleJSON.JSONNode aItem);
        /*0x3651080*/ string ToString();
        void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode);
        /*0x3651108*/ double get_AsDouble();
        /*0x365113c*/ int get_AsInt();
        /*0x3651700*/ bool Equals(object obj);
        /*0x365170c*/ int GetHashCode();
    }

    class JSONArray : SimpleJSON.JSONNode, System.Collections.IEnumerable
    {
        /*0x10*/ System.Collections.Generic.List<SimpleJSON.JSONNode> m_List;
        /*0x18*/ bool inline;

        /*0x3652384*/ JSONArray();
        /*0x36524b4*/ SimpleJSON.JSONNode get_Item(string aKey);
        /*0x3652590*/ void set_Item(string aKey, SimpleJSON.JSONNode value);
        /*0x36526a0*/ void Add(string aKey, SimpleJSON.JSONNode aItem);
        /*0x3652758*/ System.Collections.IEnumerator GetEnumerator();
        /*0x36527ec*/ void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode);

        class <GetEnumerator>d__19 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ SimpleJSON.JSONArray <>4__this;
            /*0x28*/ System.Collections.Generic.List.Enumerator<SimpleJSON.JSONNode> <>7__wrap1;

            /*0x36527c4*/ <GetEnumerator>d__19(int <>1__state);
            /*0x3652958*/ void System.IDisposable.Dispose();
            /*0x3652974*/ bool MoveNext();
            /*0x3652b94*/ void <>m__Finally1();
            /*0x3652be4*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x3652bec*/ void System.Collections.IEnumerator.Reset();
            /*0x3652c24*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class JSONObject : SimpleJSON.JSONNode, System.Collections.IEnumerable
    {
        /*0x10*/ System.Collections.Generic.Dictionary<string, SimpleJSON.JSONNode> m_Dict;
        /*0x18*/ bool inline;

        /*0x36522d8*/ JSONObject();
        /*0x3652c2c*/ SimpleJSON.JSONNode get_Item(string aKey);
        /*0x3652d80*/ void set_Item(string aKey, SimpleJSON.JSONNode value);
        /*0x3652ea4*/ void Add(string aKey, SimpleJSON.JSONNode aItem);
        /*0x3653038*/ System.Collections.IEnumerator GetEnumerator();
        /*0x36530cc*/ void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode);

        class <GetEnumerator>d__20 : System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x10*/ int <>1__state;
            /*0x18*/ object <>2__current;
            /*0x20*/ SimpleJSON.JSONObject <>4__this;
            /*0x28*/ System.Collections.Generic.Dictionary.Enumerator<string, SimpleJSON.JSONNode> <>7__wrap1;

            /*0x36530a4*/ <GetEnumerator>d__20(int <>1__state);
            /*0x3653558*/ void System.IDisposable.Dispose();
            /*0x3653574*/ bool MoveNext();
            /*0x36537cc*/ void <>m__Finally1();
            /*0x365381c*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
            /*0x3653824*/ void System.Collections.IEnumerator.Reset();
            /*0x365385c*/ object System.Collections.IEnumerator.get_Current();
        }
    }

    class JSONString : SimpleJSON.JSONNode
    {
        /*0x10*/ string m_Data;

        /*0x36511c4*/ JSONString(string aData);
        /*0x3653864*/ string get_Value();
        /*0x365386c*/ void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode);
        /*0x365390c*/ bool Equals(object obj);
        /*0x3653a10*/ int GetHashCode();
    }

    class JSONNumber : SimpleJSON.JSONNode
    {
        /*0x10*/ double m_Data;

        static /*0x3653a5c*/ bool IsNumeric(object value);
        /*0x3651480*/ JSONNumber(double aData);
        /*0x3653a2c*/ string get_Value();
        /*0x3653a38*/ double get_AsDouble();
        /*0x3653a40*/ void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode);
        /*0x3653b48*/ bool Equals(object obj);
        /*0x3653c6c*/ int GetHashCode();
    }

    class JSONBool : SimpleJSON.JSONNode
    {
        /*0x10*/ bool m_Data;

        /*0x3651620*/ JSONBool(bool aData);
        /*0x3653c8c*/ string get_Value();
        /*0x3653cc0*/ void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode);
        /*0x3653d38*/ bool Equals(object obj);
        /*0x3653d80*/ int GetHashCode();
    }

    class JSONNull : SimpleJSON.JSONNode
    {
        /*0x3652648*/ JSONNull();
        /*0x3653db4*/ string get_Value();
        /*0x3653df4*/ bool Equals(object obj);
        /*0x3653e80*/ int GetHashCode();
        /*0x3653e88*/ void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode);
    }

    class JSONLazyCreator : SimpleJSON.JSONNode
    {
        /*0x10*/ SimpleJSON.JSONNode m_Node;
        /*0x18*/ string m_Key;

        /*0x365250c*/ JSONLazyCreator(SimpleJSON.JSONNode aNode);
        /*0x3652cf8*/ JSONLazyCreator(SimpleJSON.JSONNode aNode, string aKey);
        /*0x3653edc*/ void Set(SimpleJSON.JSONNode aVal);
        /*0x3653f38*/ SimpleJSON.JSONNode get_Item(string aKey);
        /*0x3653fa0*/ void set_Item(string aKey, SimpleJSON.JSONNode value);
        /*0x3654028*/ void Add(SimpleJSON.JSONNode aItem);
        /*0x36540a8*/ void Add(string aKey, SimpleJSON.JSONNode aItem);
        /*0x3654130*/ bool Equals(object obj);
        /*0x3654140*/ int GetHashCode();
        /*0x3654148*/ int get_AsInt();
        /*0x36541ac*/ double get_AsDouble();
        /*0x3654210*/ void WriteToStringBuilder(System.Text.StringBuilder aSB, int aIndent, int aIndentInc, SimpleJSON.JSONTextMode aMode);
    }

    class JSON
    {
        static /*0x3654264*/ SimpleJSON.JSONNode Parse(string aJSON);
    }
}
