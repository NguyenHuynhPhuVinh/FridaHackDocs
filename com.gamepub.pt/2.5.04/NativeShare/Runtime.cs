class <Module>
{
}

class NativeShare
{
    static /*0x0*/ UnityEngine.AndroidJavaClass m_ajc;
    static /*0x8*/ UnityEngine.AndroidJavaObject m_context;
    /*0x10*/ string subject;
    /*0x18*/ string text;
    /*0x20*/ string title;
    /*0x28*/ System.Collections.Generic.List<string> targetPackages;
    /*0x30*/ System.Collections.Generic.List<string> targetClasses;
    /*0x38*/ System.Collections.Generic.List<string> files;
    /*0x40*/ System.Collections.Generic.List<string> mimes;
    /*0x48*/ NativeShare.ShareResultCallback callback;

    static /*0x2b1f9ec*/ NativeShare();
    static /*0x2b1dfe8*/ UnityEngine.AndroidJavaClass get_AJC();
    static /*0x2b1e0d8*/ UnityEngine.AndroidJavaObject get_Context();
    static /*0x2b1eebc*/ bool TargetExists(string androidPackageName, string androidClassName);
    static /*0x2b1f080*/ bool FindTarget(ref string androidPackageName, ref string androidClassName, string packageNameRegex, string classNameRegex);
    static /*0x2b1ea10*/ byte[] GetTextureBytes(UnityEngine.Texture2D texture, bool isJpeg);
    static /*0x2b1f2c0*/ byte[] GetTextureBytesFromCopy(UnityEngine.Texture2D texture, bool isJpeg);
    /*0x2b1f8d8*/ NativeShare();
    /*0x2b1e300*/ NativeShare SetSubject(string subject);
    /*0x2b1e378*/ NativeShare SetText(string text);
    /*0x2b1e3f0*/ NativeShare SetTitle(string title);
    /*0x2b1e468*/ NativeShare SetCallback(NativeShare.ShareResultCallback callback);
    /*0x2b1e470*/ NativeShare SetTarget(string androidPackageName, string androidClassName);
    /*0x2b1e4f4*/ NativeShare AddTarget(string androidPackageName, string androidClassName);
    /*0x2b1e650*/ NativeShare AddFile(string filePath, string mime);
    /*0x2b1e780*/ NativeShare AddFile(UnityEngine.Texture2D texture, string createdFileName);
    /*0x2b1eb38*/ void Share();

    enum ShareResult
    {
        Unknown = 0,
        Shared = 1,
        NotShared = 2,
    }

    class ShareResultCallback : System.MulticastDelegate
    {
        /*0x2b1f9f0*/ ShareResultCallback(object object, nint method);
        /*0x2b1da60*/ void Invoke(NativeShare.ShareResult result, string shareTarget);
        /*0x2b1fa50*/ System.IAsyncResult BeginInvoke(NativeShare.ShareResult result, string shareTarget, System.AsyncCallback callback, object object);
        /*0x2b1fae4*/ void EndInvoke(System.IAsyncResult result);
    }
}

namespace NativeShareNamespace
{
    class NSCallbackHelper : UnityEngine.MonoBehaviour
    {
        /*0x18*/ NativeShare.ShareResultCallback callback;
        /*0x20*/ NativeShare.ShareResult result;
        /*0x28*/ string shareTarget;
        /*0x30*/ bool resultReceived;

        /*0x2b1dd64*/ NSCallbackHelper();
        /*0x2b1d8e0*/ void Awake();
        /*0x2b1d958*/ void Update();
        /*0x2b1dcd8*/ void OnApplicationFocus(bool focus);
        /*0x2b1dce8*/ void OnShareCompleted(int resultRaw, string shareTarget);
    }

    class NSShareResultCallbackAndroid : UnityEngine.AndroidJavaProxy
    {
        /*0x20*/ NativeShareNamespace.NSCallbackHelper callbackHelper;

        /*0x2b1dd6c*/ NSShareResultCallbackAndroid(NativeShare.ShareResultCallback callback);
        /*0x2b1de6c*/ void OnShareCompleted(int result, string shareTarget);
        /*0x2b1df58*/ bool HasManagedCallback();
    }
}
