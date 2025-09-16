class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x6f81d0c*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class NullableAttribute : System.Attribute
            {
                /*0x10*/ byte[] NullableFlags;

                /*0x6f81d14*/ NullableAttribute(byte );
                /*0x6f81d9c*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x6f81dcc*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x6f81df4*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x6f81ee8*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace Assets
{
    namespace Plugins
    {
        namespace WebGl
        {
            interface IJSInterop
            {
                /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<Assets.Plugins.WebGl.JSInterop.GetTokenResult> GetTokenAsync();
                /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<Assets.Plugins.WebGl.JSInterop.GetConfigurationResult> GetConfigurationAsync();
                /*0x380d83c*/ void TryCopyToClipboard(string text);
                Cysharp.Threading.Tasks.UniTask<string> GetVideoUri(string filePath);
                /*0x380aaec*/ Cysharp.Threading.Tasks.UniTask<bool> IsAstcFormatIsSupported();
                /*0x380ab68*/ Cysharp.Threading.Tasks.UniTask<Assets.Plugins.WebGl.JSInterop.IsInsideIframeResult> IsInsideIframeAsync();
                Cysharp.Threading.Tasks.UniTask<bool> StartAudioSampling(string name, float duration, int bufferSize);
                /*0x380d83c*/ void CloseAudioSampling(string name);
                void GetAudioSamples(UnityEngine.AudioSource audioSource, float[] freqData, int size);
                /*0x380cb08*/ void Reload();
            }

            class JSInterop : Assets.Plugins.WebGl.IJSInterop
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<int, System.Delegate> <Callbacks>k__BackingField;
                static /*0x8*/ System.Collections.Generic.Dictionary<int, System.Type> <CallbackParameterTypes>k__BackingField;
                static /*0x10*/ int counter;

                static /*0x6f822b4*/ JSInterop();
                static /*0x6f82110*/ void GetToken(int callbackIndex, System.Action<int, nint> callback);
                static /*0x6f82114*/ void GetConfiguration(int callbackIndex, System.Action<int, nint> callback);
                static /*0x6f82118*/ void CopyToClipboard(string textToCopy);
                static /*0x6f8211c*/ void GetVideoUri(string dataJson, int callbackIndex, System.Action<int, nint> callback);
                static /*0x6f82120*/ void IsAstcFormatIsSupported(int callbackIndex, System.Action<int, nint> callback);
                static /*0x6f82124*/ void IsInsideIframe(int callbackIndex, System.Action<int, nint> callback);
                static /*0x6f82128*/ bool StartSampling(string name, float duration, int bufferSize);
                static /*0x6f82130*/ void CloseSampling(string name);
                static /*0x6f82134*/ void GetSamples(string name, float[] freqData, int size);
                static /*0x6f82138*/ void ReloadLocation();
                static /*0x6f8213c*/ System.Collections.Generic.Dictionary<int, System.Delegate> get_Callbacks();
                static /*0x6f82194*/ void set_Callbacks(System.Collections.Generic.Dictionary<int, System.Delegate> value);
                static /*0x6f821fc*/ System.Collections.Generic.Dictionary<int, System.Type> get_CallbackParameterTypes();
                static /*0x6f82254*/ void set_CallbackParameterTypes(System.Collections.Generic.Dictionary<int, System.Type> value);
                static /*0x6f82408*/ int RegisterCallback(System.Delegate callback);
                static /*0x6f825f0*/ void UnregisterCallback(int callbackIndex);
                static /*0x6f81ef0*/ void Callback(int callbackIndex, nint dataPtr);
                /*0x6f83390*/ JSInterop();
                /*0x6f82700*/ Cysharp.Threading.Tasks.UniTask<Assets.Plugins.WebGl.JSInterop.GetTokenResult> GetTokenAsync();
                /*0x6f828bc*/ Cysharp.Threading.Tasks.UniTask<Assets.Plugins.WebGl.JSInterop.GetConfigurationResult> GetConfigurationAsync();
                /*0x6f82a78*/ void TryCopyToClipboard(string text);
                /*0x6f82acc*/ Cysharp.Threading.Tasks.UniTask<string> GetVideoUri(string filePath);
                /*0x6f82e18*/ Cysharp.Threading.Tasks.UniTask<bool> IsAstcFormatIsSupported();
                /*0x6f83080*/ Cysharp.Threading.Tasks.UniTask<Assets.Plugins.WebGl.JSInterop.IsInsideIframeResult> IsInsideIframeAsync();
                /*0x6f8323c*/ Cysharp.Threading.Tasks.UniTask<bool> StartAudioSampling(string name, float duration, int bufferSize);
                /*0x6f832c8*/ void CloseAudioSampling(string name);
                /*0x6f8331c*/ void GetAudioSamples(UnityEngine.AudioSource audioSource, float[] freqData, int size);
                /*0x6f8333c*/ void Reload();

                class GetTokenResult
                {
                    /*0x10*/ bool success;
                    /*0x18*/ string data;
                    /*0x20*/ string nickname;
                    /*0x28*/ string birthday;
                    /*0x30*/ string message;

                    /*0x6f83398*/ GetTokenResult();
                }

                class GetConfigurationResult
                {
                    /*0x10*/ string backendUrl;
                    /*0x18*/ bool isAdult;

                    /*0x6f8341c*/ GetConfigurationResult();
                }

                class GetVideoUriRequest
                {
                    /*0x10*/ string objectStoreName;
                    /*0x18*/ string assetName;
                    /*0x20*/ string dbName;

                    /*0x6f82dac*/ GetVideoUriRequest();
                }

                class GetVideoUriResult
                {
                    /*0x10*/ string videoUri;

                    /*0x6f83450*/ GetVideoUriResult();
                }

                class GetUseAstcResult
                {
                    /*0x10*/ bool useAstc;

                    /*0x6f83484*/ GetUseAstcResult();
                }

                class IsInsideIframeResult
                {
                    /*0x10*/ bool insideIframe;

                    /*0x6f8348c*/ IsInsideIframeResult();
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<Assets.Plugins.WebGl.JSInterop.GetTokenResult> tcs;

                    /*0x6f828b4*/ <>c__DisplayClass23_0();
                    /*0x6f83494*/ void <GetTokenAsync>b__0(Assets.Plugins.WebGl.JSInterop.GetTokenResult result);
                }

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<Assets.Plugins.WebGl.JSInterop.GetConfigurationResult> tcs;

                    /*0x6f82a70*/ <>c__DisplayClass24_0();
                    /*0x6f834ec*/ void <GetConfigurationAsync>b__0(Assets.Plugins.WebGl.JSInterop.GetConfigurationResult result);
                }

                class <>c__DisplayClass26_0
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<string> tcs;

                    /*0x6f82da4*/ <>c__DisplayClass26_0();
                    /*0x6f83544*/ void <GetVideoUri>b__0(Assets.Plugins.WebGl.JSInterop.GetVideoUriResult result);
                }

                class <>c__DisplayClass27_0
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> tcs;

                    /*0x6f83078*/ <>c__DisplayClass27_0();
                    /*0x6f835a0*/ void <IsAstcFormatIsSupported>b__0(Assets.Plugins.WebGl.JSInterop.GetUseAstcResult result);
                }

                class <>c__DisplayClass28_0
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<Assets.Plugins.WebGl.JSInterop.IsInsideIframeResult> tcs;

                    /*0x6f83234*/ <>c__DisplayClass28_0();
                    /*0x6f835fc*/ void <IsInsideIframeAsync>b__0(Assets.Plugins.WebGl.JSInterop.IsInsideIframeResult result);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 617BA8D27BE5169CF42FEA0C9643F90C714C1D9AF9197935AD48748260AF9639;
    static /*0x18a*/ <PrivateImplementationDetails> 8E19F7BC73B12D994D37C2AD48A3EA98A4493A0F8CB8CDC3ADB689731B8C1840;

    struct __StaticArrayInitTypeSize=42
    {
    }

    struct __StaticArrayInitTypeSize=394
    {
    }
}
