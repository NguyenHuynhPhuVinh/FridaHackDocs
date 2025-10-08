class <Module>
{
}

namespace EA
{
    namespace Unity
    {
        namespace CachedCoroutineYields
        {
            class CachedCoroutineYields
            {
                static /*0x0*/ UnityEngine.WaitForEndOfFrame <EndOfFrame>k__BackingField;
                static /*0x8*/ UnityEngine.WaitForFixedUpdate <FixedUpdateWait>k__BackingField;
                static /*0x10*/ System.Collections.Generic.Dictionary<float, UnityEngine.WaitForSeconds> timeInterval;
                static /*0x18*/ System.Collections.Generic.Dictionary<float, UnityEngine.WaitForSecondsRealtime> realtimeInterval;

                static /*0x2ba8f6c*/ CachedCoroutineYields();
                static /*0x2ba90e4*/ UnityEngine.WaitForSeconds GetWaitForSeconds(float seconds);
            }
        }
    }
}
