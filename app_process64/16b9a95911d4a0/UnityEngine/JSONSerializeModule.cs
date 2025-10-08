class <Module>
{
}

namespace UnityEngine
{
    class JsonUtility
    {
        static /*0x3e6ad80*/ string ToJsonInternal(object obj, bool prettyPrint);
        static /*0x3e6af04*/ object FromJsonInternal(string json, object objectToOverwrite, System.Type type);
        static /*0x3e6b0e0*/ string ToJson(object obj);
        static /*0x3e6b0e8*/ string ToJson(object obj, bool prettyPrint);
        static /*0x1ffc854*/ T FromJson<T>(string json);
        static /*0x3e6b238*/ object FromJson(string json, System.Type type);
        static /*0x3e6b3f8*/ void FromJsonOverwrite(string json, object objectToOverwrite);
        static /*0x3e6aeb0*/ void ToJsonInternal_Injected(object obj, bool prettyPrint, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x3e6b08c*/ object FromJsonInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper json, object objectToOverwrite, System.Type type);
    }
}
