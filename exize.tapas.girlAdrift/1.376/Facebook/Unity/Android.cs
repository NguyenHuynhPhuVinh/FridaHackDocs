class <Module>
{
}

namespace Facebook
{
    namespace Unity
    {
        namespace Android
        {
            class AndroidWrapper : Facebook.Unity.Mobile.Android.IAndroidWrapper
            {
                static string FacebookJavaClassName = "com.facebook.unity.FB";
                /*0x10*/ UnityEngine.AndroidJavaClass facebookJavaClass;

                /*0x121f904*/ AndroidWrapper();
                T CallStatic<T>(string methodName);
                /*0x121f8e8*/ void CallStatic(string methodName, object[] args);
            }
        }
    }
}
