class <Module>
{
}

namespace UnityEngine
{
    class JsonUtility
    {
        static /*0x7eebd1c*/ string ToJsonInternal(object obj, bool prettyPrint);
        static /*0x7eebe70*/ object FromJsonInternal(string json, object objectToOverwrite, System.Type type);
        static /*0x7eec04c*/ string ToJson(object obj);
        static /*0x7eec054*/ string ToJson(object obj, bool prettyPrint);
        static /*0x3907c14*/ T FromJson<T>(string json);
        static /*0x7eec1a4*/ object FromJson(string json, System.Type type);
        static /*0x7eebe1c*/ void ToJsonInternal_Injected(object obj, bool prettyPrint, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7eebff8*/ object FromJsonInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper json, object objectToOverwrite, System.Type type);
    }
}
