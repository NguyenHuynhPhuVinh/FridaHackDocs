class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x30cd6ac*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x30cd7a0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace LeTai
{
    namespace Asset
    {
        namespace TranslucentImage
        {
            namespace UniversalRP
            {
                enum RendererType
                {
                    Universal = 0,
                    Renderer2D = 1,
                }

                class TranslucentImageBlurRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static string PROFILER_TAG = "Translucent Image Source";
                    /*0xb8*/ LeTai.Asset.TranslucentImage.UniversalRP.URPRendererInternal urpRendererInternal;
                    /*0xc0*/ LeTai.Asset.TranslucentImage.UniversalRP.TranslucentImageBlurRenderPass.PassData currentPassData;
                    /*0xf0*/ LeTai.Asset.TranslucentImage.UniversalRP.TranslucentImageBlurRenderPass.SRPassData currentSRPassData;
                    /*0xf8*/ string[] scratchNames;
                    /*0x100*/ System.Collections.Generic.Dictionary<UnityEngine.RenderTexture, UnityEngine.Rendering.RTHandle> blurredScreenHdlDict;

                    static /*0x30cdf20*/ void ExecutePreview(UnityEngine.Rendering.CommandBuffer cmd, ref LeTai.Asset.TranslucentImage.UniversalRP.TranslucentImageBlurRenderPass.PreviewExecutionData data);
                    /*0x30cd7a8*/ TranslucentImageBlurRenderPass(LeTai.Asset.TranslucentImage.UniversalRP.URPRendererInternal urpRendererInternal);
                    /*0x30cd978*/ void SetupSRP(LeTai.Asset.TranslucentImage.UniversalRP.TranslucentImageBlurRenderPass.SRPassData srPassData);
                    /*0x30cd980*/ void Dispose();
                    /*0x30cdb64*/ void Setup(LeTai.Asset.TranslucentImage.UniversalRP.TranslucentImageBlurRenderPass.PassData passData);
                    /*0x30cdb9c*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x30ce028*/ void RecordRenderGraph(UnityEngine.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ContextContainer frameData);
                    /*0x30cd878*/ void RenderGraphInit();
                    /*0x30cd984*/ void RenderGraphDispose();

                    struct PassData
                    {
                        /*0x10*/ LeTai.Asset.TranslucentImage.TranslucentImageSource blurSource;
                        /*0x18*/ LeTai.Asset.TranslucentImage.IBlurAlgorithm blurAlgorithm;
                        /*0x20*/ UnityEngine.Rect camPixelRect;
                        /*0x30*/ bool shouldUpdateBlur;
                        /*0x31*/ bool isPreviewing;
                        /*0x38*/ UnityEngine.Material previewMaterial;
                    }

                    struct SRPassData
                    {
                        /*0x10*/ bool canvasDisappearWorkaround;
                    }

                    struct PreviewExecutionData
                    {
                        /*0x10*/ LeTai.Asset.TranslucentImage.TranslucentImageSource blurSource;
                        /*0x18*/ UnityEngine.Rendering.RenderTargetIdentifier previewTarget;
                        /*0x40*/ UnityEngine.Material previewMaterial;

                        /*0x30cded8*/ PreviewExecutionData(LeTai.Asset.TranslucentImage.TranslucentImageSource blurSource, UnityEngine.Rendering.RenderTargetIdentifier previewTarget, UnityEngine.Material previewMaterial);
                    }

                    class BlurRGPassData
                    {
                        /*0x10*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle sourceTex;
                        /*0x20*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle[] scratches;
                        /*0x28*/ LeTai.Asset.TranslucentImage.TranslucentImageSource blurSource;
                        /*0x30*/ LeTai.Asset.TranslucentImage.IBlurAlgorithm blurAlgorithm;

                        /*0x30cec78*/ BlurRGPassData();
                    }

                    class PreviewRGPassData
                    {
                        /*0x10*/ LeTai.Asset.TranslucentImage.TranslucentImageSource blurSource;
                        /*0x18*/ UnityEngine.Rendering.RenderGraphModule.TextureHandle previewTarget;
                        /*0x28*/ UnityEngine.Material previewMaterial;

                        /*0x30cec80*/ PreviewRGPassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ LeTai.Asset.TranslucentImage.UniversalRP.TranslucentImageBlurRenderPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<LeTai.Asset.TranslucentImage.UniversalRP.TranslucentImageBlurRenderPass.BlurRGPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__17_0;
                        static /*0x10*/ UnityEngine.Rendering.RenderGraphModule.BaseRenderFunc<LeTai.Asset.TranslucentImage.UniversalRP.TranslucentImageBlurRenderPass.PreviewRGPassData, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext> <>9__17_1;

                        static /*0x30cec88*/ <>c();
                        /*0x30cecf0*/ <>c();
                        /*0x30cecf8*/ void <RecordRenderGraph>b__17_0(LeTai.Asset.TranslucentImage.UniversalRP.TranslucentImageBlurRenderPass.BlurRGPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                        /*0x30cef9c*/ void <RecordRenderGraph>b__17_1(LeTai.Asset.TranslucentImage.UniversalRP.TranslucentImageBlurRenderPass.PreviewRGPassData data, UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext context);
                    }
                }

                class URPRendererInternal
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.ScriptableRenderer renderer;
                    /*0x18*/ System.Func<UnityEngine.Rendering.RTHandle> getBackBufferDelegate;
                    /*0x20*/ System.Func<UnityEngine.Rendering.RTHandle> getAfterPostColorDelegate;

                    /*0x30cf3c0*/ URPRendererInternal();
                    /*0x30cf0bc*/ void CacheRenderer(UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                    /*0x30cde84*/ UnityEngine.Rendering.RenderTargetIdentifier GetBackBuffer();
                    /*0x30cf36c*/ UnityEngine.Rendering.RenderTargetIdentifier GetAfterPostColor();
                    /*0x30cf100*/ void <CacheRenderer>g__CacheBackBufferGetter|3_0(object rd);

                    class <>c
                    {
                        static /*0x0*/ LeTai.Asset.TranslucentImage.UniversalRP.URPRendererInternal.<> <>9;
                        static /*0x8*/ System.Func<System.Reflection.MethodInfo, bool> <>9__3_1;

                        static /*0x30cf3c8*/ <>c();
                        /*0x30cf430*/ <>c();
                        /*0x30cf438*/ bool <CacheRenderer>b__3_1(System.Reflection.MethodInfo m);
                    }
                }

                class TranslucentImageBlurSource : UnityEngine.Rendering.Universal.ScriptableRendererFeature
                {
                    /*0x1c*/ LeTai.Asset.TranslucentImage.UniversalRP.TranslucentImageBlurSource.RenderOrder renderOrder;
                    /*0x20*/ bool canvasDisappearWorkaround;
                    /*0x24*/ LeTai.Asset.TranslucentImage.UniversalRP.RendererType rendererType;
                    /*0x28*/ System.Collections.Generic.Dictionary<UnityEngine.Camera, LeTai.Asset.TranslucentImage.TranslucentImageSource> blurSourceCache;
                    /*0x30*/ System.Collections.Generic.Dictionary<UnityEngine.Camera, UnityEngine.Camera> baseCameraCache;
                    /*0x38*/ LeTai.Asset.TranslucentImage.UniversalRP.URPRendererInternal urpRendererInternal;
                    /*0x40*/ LeTai.Asset.TranslucentImage.UniversalRP.TranslucentImageBlurRenderPass pass;
                    /*0x48*/ LeTai.Asset.TranslucentImage.IBlurAlgorithm blurAlgorithm;
                    /*0x50*/ UnityEngine.Material previewMaterial;

                    /*0x30cfc4c*/ TranslucentImageBlurSource();
                    /*0x30cf4cc*/ UnityEngine.Material get_PreviewMaterial();
                    /*0x30cf588*/ void RegisterSource(LeTai.Asset.TranslucentImage.TranslucentImageSource source);
                    /*0x30cf61c*/ void Create();
                    /*0x30cf740*/ void Dispose(bool disposing);
                    /*0x30cf7a8*/ void SetupSRP(UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                    /*0x30cf834*/ void SetupRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x30cf9d4*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x30cf8e4*/ LeTai.Asset.TranslucentImage.TranslucentImageSource GetBlurSource(UnityEngine.Camera camera);
                    /*0x30cfc20*/ UnityEngine.Rect GetPixelRect(UnityEngine.Rendering.Universal.CameraData cameraData);

                    enum RenderOrder
                    {
                        AfterPostProcessing = 0,
                        BeforePostProcessing = 1,
                    }
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 6BDC202F703391B58DD08A7F304E87EB093792B4363CB10A5DACE55372D6C9BB;
    static /*0x2e7*/ <PrivateImplementationDetails> 6EDCF43F7C603C8550A990E30DF661FDB9BAB67F34DF44A37EAEF86716327FCA;

    struct __StaticArrayInitTypeSize=274
    {
    }

    struct __StaticArrayInitTypeSize=743
    {
    }
}
