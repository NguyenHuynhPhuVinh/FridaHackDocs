class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x6f9913c*/ EmbeddedAttribute();
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

                /*0x6f99144*/ NullableAttribute(byte );
                /*0x6f991cc*/ NullableAttribute(byte[] );
            }

            class NullableContextAttribute : System.Attribute
            {
                /*0x10*/ byte Flag;

                /*0x6f991fc*/ NullableContextAttribute(byte );
            }
        }
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x6f99224*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x6f99318*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
                /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<Assets.Plugins.WebGl.JSInterop.GetTokenResult> GetTokenAsync();
                /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<Assets.Plugins.WebGl.JSInterop.GetConfigurationResult> GetConfigurationAsync();
                /*0x3816710*/ void TryCopyToClipboard(string text);
                Cysharp.Threading.Tasks.UniTask<string> GetVideoUri(string filePath);
                /*0x38139c0*/ Cysharp.Threading.Tasks.UniTask<bool> IsAstcFormatIsSupported();
                /*0x3813a3c*/ Cysharp.Threading.Tasks.UniTask<Assets.Plugins.WebGl.JSInterop.IsInsideIframeResult> IsInsideIframeAsync();
                Cysharp.Threading.Tasks.UniTask<bool> StartAudioSampling(string name, float duration, int bufferSize);
                /*0x3816710*/ void CloseAudioSampling(string name);
                void GetAudioSamples(UnityEngine.AudioSource audioSource, float[] freqData, int size);
                /*0x38159dc*/ void Reload();
            }

            class JSInterop : Assets.Plugins.WebGl.IJSInterop
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<int, System.Delegate> <Callbacks>k__BackingField;
                static /*0x8*/ System.Collections.Generic.Dictionary<int, System.Type> <CallbackParameterTypes>k__BackingField;
                static /*0x10*/ int counter;

                static /*0x6f996e4*/ JSInterop();
                static /*0x6f99540*/ void GetToken(int callbackIndex, System.Action<int, nint> callback);
                static /*0x6f99544*/ void GetConfiguration(int callbackIndex, System.Action<int, nint> callback);
                static /*0x6f99548*/ void CopyToClipboard(string textToCopy);
                static /*0x6f9954c*/ void GetVideoUri(string dataJson, int callbackIndex, System.Action<int, nint> callback);
                static /*0x6f99550*/ void IsAstcFormatIsSupported(int callbackIndex, System.Action<int, nint> callback);
                static /*0x6f99554*/ void IsInsideIframe(int callbackIndex, System.Action<int, nint> callback);
                static /*0x6f99558*/ bool StartSampling(string name, float duration, int bufferSize);
                static /*0x6f99560*/ void CloseSampling(string name);
                static /*0x6f99564*/ void GetSamples(string name, float[] freqData, int size);
                static /*0x6f99568*/ void ReloadLocation();
                static /*0x6f9956c*/ System.Collections.Generic.Dictionary<int, System.Delegate> get_Callbacks();
                static /*0x6f995c4*/ void set_Callbacks(System.Collections.Generic.Dictionary<int, System.Delegate> value);
                static /*0x6f9962c*/ System.Collections.Generic.Dictionary<int, System.Type> get_CallbackParameterTypes();
                static /*0x6f99684*/ void set_CallbackParameterTypes(System.Collections.Generic.Dictionary<int, System.Type> value);
                static /*0x6f99838*/ int RegisterCallback(System.Delegate callback);
                static /*0x6f99a20*/ void UnregisterCallback(int callbackIndex);
                static /*0x6f99320*/ void Callback(int callbackIndex, nint dataPtr);
                /*0x6f9a7c0*/ JSInterop();
                /*0x6f99b30*/ Cysharp.Threading.Tasks.UniTask<Assets.Plugins.WebGl.JSInterop.GetTokenResult> GetTokenAsync();
                /*0x6f99cec*/ Cysharp.Threading.Tasks.UniTask<Assets.Plugins.WebGl.JSInterop.GetConfigurationResult> GetConfigurationAsync();
                /*0x6f99ea8*/ void TryCopyToClipboard(string text);
                /*0x6f99efc*/ Cysharp.Threading.Tasks.UniTask<string> GetVideoUri(string filePath);
                /*0x6f9a248*/ Cysharp.Threading.Tasks.UniTask<bool> IsAstcFormatIsSupported();
                /*0x6f9a4b0*/ Cysharp.Threading.Tasks.UniTask<Assets.Plugins.WebGl.JSInterop.IsInsideIframeResult> IsInsideIframeAsync();
                /*0x6f9a66c*/ Cysharp.Threading.Tasks.UniTask<bool> StartAudioSampling(string name, float duration, int bufferSize);
                /*0x6f9a6f8*/ void CloseAudioSampling(string name);
                /*0x6f9a74c*/ void GetAudioSamples(UnityEngine.AudioSource audioSource, float[] freqData, int size);
                /*0x6f9a76c*/ void Reload();

                class GetTokenResult
                {
                    /*0x10*/ bool success;
                    /*0x18*/ string data;
                    /*0x20*/ string nickname;
                    /*0x28*/ string birthday;
                    /*0x30*/ string message;

                    /*0x6f9a7c8*/ GetTokenResult();
                }

                class GetConfigurationResult
                {
                    /*0x10*/ string backendUrl;
                    /*0x18*/ bool isAdult;

                    /*0x6f9a84c*/ GetConfigurationResult();
                }

                class GetVideoUriRequest
                {
                    /*0x10*/ string objectStoreName;
                    /*0x18*/ string assetName;
                    /*0x20*/ string dbName;

                    /*0x6f9a1dc*/ GetVideoUriRequest();
                }

                class GetVideoUriResult
                {
                    /*0x10*/ string videoUri;

                    /*0x6f9a880*/ GetVideoUriResult();
                }

                class GetUseAstcResult
                {
                    /*0x10*/ bool useAstc;

                    /*0x6f9a8b4*/ GetUseAstcResult();
                }

                class IsInsideIframeResult
                {
                    /*0x10*/ bool insideIframe;

                    /*0x6f9a8bc*/ IsInsideIframeResult();
                }

                class <>c__DisplayClass23_0
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<Assets.Plugins.WebGl.JSInterop.GetTokenResult> tcs;

                    /*0x6f99ce4*/ <>c__DisplayClass23_0();
                    /*0x6f9a8c4*/ void <GetTokenAsync>b__0(Assets.Plugins.WebGl.JSInterop.GetTokenResult result);
                }

                class <>c__DisplayClass24_0
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<Assets.Plugins.WebGl.JSInterop.GetConfigurationResult> tcs;

                    /*0x6f99ea0*/ <>c__DisplayClass24_0();
                    /*0x6f9a91c*/ void <GetConfigurationAsync>b__0(Assets.Plugins.WebGl.JSInterop.GetConfigurationResult result);
                }

                class <>c__DisplayClass26_0
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<string> tcs;

                    /*0x6f9a1d4*/ <>c__DisplayClass26_0();
                    /*0x6f9a974*/ void <GetVideoUri>b__0(Assets.Plugins.WebGl.JSInterop.GetVideoUriResult result);
                }

                class <>c__DisplayClass27_0
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<bool> tcs;

                    /*0x6f9a4a8*/ <>c__DisplayClass27_0();
                    /*0x6f9a9d0*/ void <IsAstcFormatIsSupported>b__0(Assets.Plugins.WebGl.JSInterop.GetUseAstcResult result);
                }

                class <>c__DisplayClass28_0
                {
                    /*0x10*/ Cysharp.Threading.Tasks.UniTaskCompletionSource<Assets.Plugins.WebGl.JSInterop.IsInsideIframeResult> tcs;

                    /*0x6f9a664*/ <>c__DisplayClass28_0();
                    /*0x6f9aa2c*/ void <IsInsideIframeAsync>b__0(Assets.Plugins.WebGl.JSInterop.IsInsideIframeResult result);
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
