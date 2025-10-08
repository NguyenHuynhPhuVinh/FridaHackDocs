class <Module>
{
}

namespace EA
{
    namespace Unity
    {
        namespace InAppReview
        {
            class GooglePlayInAppReview : EA.Unity.InAppReview.IInAppReview
            {
                /*0x2be6050*/ GooglePlayInAppReview();
                /*0x2be5d2c*/ void RequestForReview(System.Action<bool> onRequestComplete);

                class NativeCodeListener : UnityEngine.MonoBehaviour
                {
                    static /*0x0*/ EA.Unity.InAppReview.GooglePlayInAppReview.NativeCodeListener instance;
                    /*0x20*/ System.Action<bool> onRequestComplete;

                    static /*0x2be5f2c*/ EA.Unity.InAppReview.GooglePlayInAppReview.NativeCodeListener get_Instance();
                    static /*0x2be6058*/ EA.Unity.InAppReview.GooglePlayInAppReview.NativeCodeListener CreateInstance();
                    /*0x2be630c*/ NativeCodeListener();
                    /*0x2be5fa0*/ void add_onRequestComplete(System.Action<bool> value);
                    /*0x2be61e0*/ void remove_onRequestComplete(System.Action<bool> value);
                    /*0x2be6290*/ void OnGooglePlayInAppReviewRequestCompleted(string successString);
                }
            }
        }
    }
}
