class <Module>
{
}

namespace UnityEngine
{
    class JsonUtility
    {
        static /*0x2b39580*/ string ToJsonInternal(object obj, bool prettyPrint);
        static /*0x2b395d0*/ object FromJsonInternal(string json, object objectToOverwrite, System.Type type);
        static /*0x2b39628*/ string ToJson(object obj);
        static /*0x2b39630*/ string ToJson(object obj, bool prettyPrint);
        static T FromJson<T>(string json);
        static /*0x2b397b0*/ object FromJson(string json, System.Type type);
    }
}
