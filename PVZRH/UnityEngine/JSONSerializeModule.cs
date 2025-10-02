class <Module>
{
}

namespace UnityEngine
{
    class JsonUtility
    {
        static /*0x1645610*/ string ToJsonInternal(object obj, bool prettyPrint);
        static /*0x1645200*/ object FromJsonInternal(string json, object objectToOverwrite, System.Type type);
        static /*0x1645660*/ string ToJson(object obj);
        static /*0x16457d0*/ string ToJson(object obj, bool prettyPrint);
        static /*0x2a5510*/ T FromJson<T>(string json);
        static /*0x1645410*/ object FromJson(string json, System.Type type);
        static /*0x1645260*/ void FromJsonOverwrite(string json, object objectToOverwrite);
    }
}
