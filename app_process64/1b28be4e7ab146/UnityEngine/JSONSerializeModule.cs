class <Module>
{
}

namespace UnityEngine
{
    class JsonUtility
    {
        static /*0x7f0314c*/ string ToJsonInternal(object obj, bool prettyPrint);
        static /*0x7f032a0*/ object FromJsonInternal(string json, object objectToOverwrite, System.Type type);
        static /*0x7f0347c*/ string ToJson(object obj);
        static /*0x7f03484*/ string ToJson(object obj, bool prettyPrint);
        static /*0x3910ae8*/ T FromJson<T>(string json);
        static /*0x7f035d4*/ object FromJson(string json, System.Type type);
        static /*0x7f0324c*/ void ToJsonInternal_Injected(object obj, bool prettyPrint, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
        static /*0x7f03428*/ object FromJsonInternal_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper json, object objectToOverwrite, System.Type type);
    }
}
