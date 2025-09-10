class <Module>
{
}

namespace UnityEngine
{
    class JsonUtility
    {
        static /*0x1575458*/ string ToJsonInternal(object obj, bool prettyPrint);
        static /*0x157549c*/ object FromJsonInternal(string json, object objectToOverwrite, System.Type type);
        static /*0x15754f0*/ string ToJson(object obj);
        static /*0x15754f8*/ string ToJson(object obj, bool prettyPrint);
        static T FromJson<T>(string json);
        static /*0x157566c*/ object FromJson(string json, System.Type type);
    }
}
