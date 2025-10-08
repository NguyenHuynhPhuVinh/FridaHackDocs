class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x30c65e0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x30c66d4*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
            struct ActiveRegion
            {
                static /*0x0*/ LeTai.Asset.TranslucentImage.ActiveRegion INACTIVE;
                /*0x10*/ UnityEngine.Rect rect;
                /*0x20*/ UnityEngine.Matrix4x4 localToWorld;
                /*0x60*/ LeTai.Asset.TranslucentImage.VPMatrixCache.Index vpMatrixCacheIndex;

                static /*0x30c6768*/ ActiveRegion();
                /*0x30c6748*/ ActiveRegion(UnityEngine.Rect rect, UnityEngine.Matrix4x4 localToWorld, LeTai.Asset.TranslucentImage.VPMatrixCache.Index vpMatrixCacheIndex);
                /*0x30c66dc*/ bool get_IsWorldSpace();
            }

            interface IActiveRegionProvider
            {
                /*0x1f2fe14*/ bool HaveActiveRegion();
                /*0x1f30ff0*/ void GetActiveRegion(LeTai.Asset.TranslucentImage.VPMatrixCache vpMatrixCache, ref LeTai.Asset.TranslucentImage.ActiveRegion activeRegion);
            }

            struct ActiveRegionMergeJob : Unity.Jobs.IJob
            {
                /*0x10*/ Unity.Collections.NativeList<LeTai.Asset.TranslucentImage.ActiveRegion> activeRegions;
                /*0x18*/ Unity.Collections.NativeList<UnityEngine.Matrix4x4> vpMatrices;
                /*0x20*/ UnityEngine.Vector2 screenSize;
                /*0x28*/ UnityEngine.Rect viewport;
                /*0x38*/ Unity.Collections.NativeArray<UnityEngine.Rect> merged;

                /*0x30c683c*/ void Execute();
            }

            class BlurConfig : UnityEngine.ScriptableObject
            {
                /*0x30c6afc*/ BlurConfig();
                /*0x1f30804*/ float get_Strength();
                void set_Strength(float value);
            }

            enum BlurAlgorithmType
            {
                ScalableBlur = 0,
            }

            enum BackgroundFillMode
            {
                None = 0,
                Color = 1,
            }

            class BackgroundFill
            {
                /*0x10*/ LeTai.Asset.TranslucentImage.BackgroundFillMode mode;
                /*0x14*/ UnityEngine.Color color;

                /*0x30c6b04*/ BackgroundFill();
            }

            interface IBlurAlgorithm
            {
                void Init(LeTai.Asset.TranslucentImage.BlurConfig config, bool isBirp);
                void Blur(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier src, UnityEngine.Rect srcCropRegion, UnityEngine.Rect activeRegion, LeTai.Asset.TranslucentImage.BackgroundFill backgroundFill, UnityEngine.RenderTexture target);
                /*0x1f2ffc8*/ int GetScratchesCount();
                /*0x1f30c88*/ void GetScratchDescriptor(int index, ref UnityEngine.RenderTextureDescriptor descriptor);
                void SetScratch(int index, UnityEngine.Rendering.RenderTargetIdentifier value);
            }

            class ScalableBlur : LeTai.Asset.TranslucentImage.IBlurAlgorithm
            {
                /*0x10*/ UnityEngine.Rendering.RenderTargetIdentifier[] scratches;
                /*0x18*/ bool isBirp;
                /*0x20*/ UnityEngine.Material material;
                /*0x28*/ LeTai.Asset.TranslucentImage.ScalableBlurConfig config;
                /*0x30*/ UnityEngine.MaterialPropertyBlock propertyBlock;

                static /*0x30c7860*/ int SimplePingPong(int t, int max);
                static /*0x30c757c*/ void <Blur>g__CropViewport|9_0(int targetWidth, int targetHeight, float padding, ref UnityEngine.Rect viewport, ref UnityEngine.Rect activeRegionSnapped, ref LeTai.Asset.TranslucentImage.ScalableBlur.<> );
                /*0x30c7958*/ ScalableBlur();
                /*0x30c6b14*/ UnityEngine.Material get_Material();
                /*0x30c6c10*/ void set_Material(UnityEngine.Material value);
                /*0x30c6c18*/ void Init(LeTai.Asset.TranslucentImage.BlurConfig config, bool isBirp);
                /*0x30c6d1c*/ void Blur(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier src, UnityEngine.Rect srcCropRegion, UnityEngine.Rect activeRegion, LeTai.Asset.TranslucentImage.BackgroundFill backgroundFill, UnityEngine.RenderTexture target);
                /*0x30c7874*/ int GetScratchesCount();
                /*0x30c78a4*/ void GetScratchDescriptor(int index, ref UnityEngine.RenderTextureDescriptor descriptor);
                /*0x30c7914*/ void SetScratch(int index, UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0x30c7394*/ void ConfigMaterial(float radius, LeTai.Asset.TranslucentImage.BackgroundFill backgroundFill);
                /*0x30c7360*/ float ScaleWithResolution(float baseRadius, float width, float height);

                struct <>c__DisplayClass9_0
                {
                    /*0x10*/ UnityEngine.Rect activeRegionRelative;
                }
            }

            class ScalableBlurConfig : LeTai.Asset.TranslucentImage.BlurConfig
            {
                /*0x18*/ float radius;
                /*0x1c*/ int iteration;
                /*0x20*/ float strength;

                /*0x30c7a70*/ ScalableBlurConfig();
                /*0x30c79bc*/ float get_Radius();
                /*0x30c79c4*/ void set_Radius(float value);
                /*0x30c79d8*/ int get_Iteration();
                /*0x30c79e0*/ void set_Iteration(int value);
                /*0x30c79ec*/ float get_Strength();
                /*0x30c7a1c*/ void set_Strength(float value);
            }

            class TranslucentImage : UnityEngine.UI.Image, UnityEngine.UI.IMeshModifier, LeTai.Asset.TranslucentImage.IActiveRegionProvider
            {
                /*0x110*/ LeTai.Asset.TranslucentImage.TranslucentImageSource _source;
                /*0x118*/ bool shouldRun;
                /*0x119*/ bool isBirp;
                /*0x120*/ LeTai.Asset.TranslucentImage.TranslucentImageSource _sourcePrev;
                /*0x128*/ bool sourceAcquiredOnStart;
                /*0x12c*/ float m_spriteBlending;

                static /*0x30c8978*/ void CopyMaterialPropertiesTo(UnityEngine.Material src, UnityEngine.Material dst);
                /*0x30c9454*/ TranslucentImage();
                /*0x30c7a84*/ LeTai.Asset.TranslucentImage.TranslucentImageSource get_source();
                /*0x30c7a8c*/ void set_source(LeTai.Asset.TranslucentImage.TranslucentImageSource value);
                /*0x30c7d88*/ float get_vibrancy();
                /*0x30c7e10*/ void set_vibrancy(float value);
                /*0x30c7ea8*/ float get_brightness();
                /*0x30c7f30*/ void set_brightness(float value);
                /*0x30c7fc8*/ float get_flatten();
                /*0x30c8050*/ void set_flatten(float value);
                /*0x30c80e8*/ UnityEngine.Material get_material();
                /*0x30c80f0*/ void set_material(UnityEngine.Material value);
                /*0x30c812c*/ void Start();
                /*0x30c854c*/ void OnEnable();
                /*0x30c8590*/ void OnDisable();
                /*0x30c85c4*/ bool HaveActiveRegion();
                /*0x30c8694*/ void GetActiveRegion(LeTai.Asset.TranslucentImage.VPMatrixCache vpMatrixCache, ref LeTai.Asset.TranslucentImage.ActiveRegion activeRegion);
                /*0x30c7c60*/ void ConnectSource(LeTai.Asset.TranslucentImage.TranslucentImageSource source);
                /*0x30c7b48*/ void DisconnectSource(LeTai.Asset.TranslucentImage.TranslucentImageSource source);
                /*0x30c8bf0*/ void SetBlurTex();
                /*0x30c8cc8*/ void SetBlurRegion();
                /*0x30c8114*/ void OnDirtyMaterial();
                /*0x30c90b0*/ bool IsInPrefabMode();
                /*0x30c8468*/ void AutoAcquireSource();
                /*0x30c90b8*/ void ApplySerializedData();
                /*0x30c90dc*/ float get_spriteBlending();
                /*0x30c90e4*/ void set_spriteBlending(float value);
                /*0x30c90f8*/ void ModifyMesh(UnityEngine.UI.VertexHelper vh);
                /*0x30c92b4*/ void OnDidApplyAnimationProperties();
                /*0x30c92dc*/ void ModifyMesh(UnityEngine.Mesh mesh);
            }

            class TranslucentImageSource : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ UnityEngine.Rect FULLSCREEN_REGION;
                static /*0x10*/ Unity.Profiling.ProfilerMarker profilerMarkerCull;
                /*0x20*/ LeTai.Asset.TranslucentImage.BlurConfig blurConfig;
                /*0x28*/ int downsample;
                /*0x2c*/ UnityEngine.Rect blurRegion;
                /*0x3c*/ float maxUpdateRate;
                /*0x40*/ float cullPadding;
                /*0x44*/ bool preview;
                /*0x48*/ LeTai.Asset.TranslucentImage.BackgroundFill backgroundFill;
                /*0x50*/ bool skipCulling;
                /*0x54*/ int lastDownsample;
                /*0x58*/ UnityEngine.Rect lastBlurRegion;
                /*0x68*/ UnityEngine.Rect lastCamPixelRect;
                /*0x78*/ UnityEngine.Vector2Int lastCamPixelSize;
                /*0x80*/ float lastUpdate;
                /*0x84*/ bool hasUpdated;
                /*0x88*/ LeTai.Asset.TranslucentImage.IBlurAlgorithm blurAlgorithm;
                /*0x90*/ UnityEngine.Camera camera;
                /*0x98*/ UnityEngine.Material previewMaterial;
                /*0xa0*/ UnityEngine.RenderTexture blurredScreen;
                /*0xa8*/ UnityEngine.Rendering.CommandBuffer cmd;
                /*0xb0*/ bool isForOverlayCanvas;
                /*0xb1*/ bool needRegisterCanvasPreRenderCallback;
                /*0xb8*/ System.Collections.Generic.List<LeTai.Asset.TranslucentImage.IActiveRegionProvider> activeRegionProviders;
                /*0xc0*/ LeTai.Asset.TranslucentImage.VPMatrixCache vpMatrixCache;
                /*0xc8*/ Unity.Collections.NativeList<LeTai.Asset.TranslucentImage.ActiveRegion> activeRegions;
                /*0xd0*/ Unity.Collections.NativeArray<UnityEngine.Rect> activeRegionJobResult;
                /*0xe0*/ Unity.Jobs.JobHandle findBoundsJobHandle;
                /*0xf0*/ UnityEngine.Rect <ActiveRegion>k__BackingField;
                /*0x100*/ UnityEngine.Rect <CamRectOverride>k__BackingField;
                /*0x110*/ System.Action blurredScreenChanged;
                /*0x118*/ System.Action blurRegionChanged;
                /*0x120*/ UnityEngine.Rendering.TextureDimension lastEyeTexDim;

                static /*0x30cb240*/ TranslucentImageSource();
                static /*0x30cb0f4*/ float GetTrueCurrentTime();
                /*0x30cb0fc*/ TranslucentImageSource();
                /*0x30c94b8*/ LeTai.Asset.TranslucentImage.BlurConfig get_BlurConfig();
                /*0x30c94c0*/ void set_BlurConfig(LeTai.Asset.TranslucentImage.BlurConfig value);
                /*0x30c957c*/ int get_Downsample();
                /*0x30c9584*/ void set_Downsample(int value);
                /*0x30c9590*/ UnityEngine.Rect get_BlurRegion();
                /*0x30c959c*/ void set_BlurRegion(UnityEngine.Rect value);
                /*0x30c9740*/ UnityEngine.Rect get_ActiveRegion();
                /*0x30c974c*/ void set_ActiveRegion(UnityEngine.Rect value);
                /*0x30c9758*/ float get_MaxUpdateRate();
                /*0x30c9760*/ void set_MaxUpdateRate(float value);
                /*0x30c9774*/ float get_CullPadding();
                /*0x30c977c*/ void set_CullPadding(float value);
                /*0x30c9790*/ LeTai.Asset.TranslucentImage.BackgroundFill get_BackgroundFill();
                /*0x30c9798*/ void set_BackgroundFill(LeTai.Asset.TranslucentImage.BackgroundFill value);
                /*0x30c97a0*/ bool get_Preview();
                /*0x30c97a8*/ void set_Preview(bool value);
                /*0x30c97b0*/ bool get_SkipCulling();
                /*0x30c97b8*/ void set_SkipCulling(bool value);
                /*0x30c97c0*/ UnityEngine.RenderTexture get_BlurredScreen();
                /*0x30c97c8*/ void set_BlurredScreen(UnityEngine.RenderTexture value);
                /*0x30c97d0*/ UnityEngine.Rect get_CamRectOverride();
                /*0x30c97e4*/ void set_CamRectOverride(UnityEngine.Rect value);
                /*0x30c9070*/ UnityEngine.Rect get_BlurRegionNormalizedScreenSpace();
                /*0x30c9840*/ void set_BlurRegionNormalizedScreenSpace(UnityEngine.Rect value);
                /*0x30c9670*/ UnityEngine.Camera get_Cam();
                /*0x30c98d8*/ float get_MinUpdateCycle();
                /*0x30c98f8*/ bool get_ShouldCull();
                /*0x30c8ab8*/ void add_blurredScreenChanged(System.Action value);
                /*0x30c8f38*/ void remove_blurredScreenChanged(System.Action value);
                /*0x30c8b54*/ void add_blurRegionChanged(System.Action value);
                /*0x30c8fd4*/ void remove_blurRegionChanged(System.Action value);
                /*0x30c9724*/ void OnBlurRegionChanged();
                /*0x30c8a60*/ void RegisterActiveRegionProvider(LeTai.Asset.TranslucentImage.IActiveRegionProvider provider);
                /*0x30c8ee0*/ void UnRegisterActiveRegionProvider(LeTai.Asset.TranslucentImage.IActiveRegionProvider provider);
                /*0x30c9908*/ void OnEnable();
                /*0x30c9ad0*/ void OnDisable();
                /*0x30c9cfc*/ void Start();
                /*0x30c9dc8*/ void Update();
                /*0x30c9e50*/ void OnDestroy();
                /*0x30c9ed0*/ void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination);
                /*0x30c9d00*/ void Init();
                /*0x30c94dc*/ void InitializeBlurAlgorithm();
                /*0x30ca890*/ void OnWillRenderCanvases();
                /*0x30ca894*/ void StartCull();
                /*0x30c9bb4*/ bool CompleteCull();
                /*0x30cad70*/ void CreateNewBlurredScreen(UnityEngine.Vector2Int camPixelSize);
                /*0x30ca2ec*/ void ReallocateBlurTexIfNeeded(UnityEngine.Rect camPixelRect);
                /*0x30ca238*/ bool ShouldUpdateBlur();
                /*0x30cac4c*/ UnityEngine.Rect GetActiveCameraRect();
                /*0x30c97f8*/ UnityEngine.Rect ViewportToScreen01Space(UnityEngine.Rect rect);
                /*0x30c9890*/ UnityEngine.Rect Screen01ToViewportSpace(UnityEngine.Rect rect);
            }

            class Blitter
            {
                static /*0x0*/ UnityEngine.Mesh fullscreenTriangle;

                static /*0x30cb2c8*/ UnityEngine.Mesh get_FullscreenTriangle();
                static /*0x30c7614*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Material material, int passIndex, UnityEngine.MaterialPropertyBlock propertyBlock, UnityEngine.Rect viewport);
            }

            class BlurExecutor
            {
                static /*0x0*/ int[] TEMP_RT;

                static /*0x30cb538*/ BlurExecutor();
                static /*0x30ca514*/ void ExecuteBlurWithTempTextures(UnityEngine.Rendering.CommandBuffer cmd, ref LeTai.Asset.TranslucentImage.BlurExecutor.BlurExecutionData data);
                static /*0x30cb658*/ void ExecuteBlur(UnityEngine.Rendering.CommandBuffer cmd, ref LeTai.Asset.TranslucentImage.BlurExecutor.BlurExecutionData data);

                struct BlurExecutionData
                {
                    /*0x10*/ UnityEngine.Rendering.RenderTargetIdentifier sourceTex;
                    /*0x38*/ LeTai.Asset.TranslucentImage.TranslucentImageSource blurSource;
                    /*0x40*/ LeTai.Asset.TranslucentImage.IBlurAlgorithm blurAlgorithm;

                    /*0x30ca4d0*/ BlurExecutionData(UnityEngine.Rendering.RenderTargetIdentifier sourceTex, LeTai.Asset.TranslucentImage.TranslucentImageSource blurSource, LeTai.Asset.TranslucentImage.IBlurAlgorithm blurAlgorithm);
                }
            }

            class RectUtils
            {
                static /*0x30cb0a4*/ bool ApproximateEqual01(UnityEngine.Rect a, UnityEngine.Rect b);
                static /*0x30cb7a8*/ bool QuickApproximate01(float a, float b);
                static /*0x30c7520*/ UnityEngine.Rect Intersect(UnityEngine.Rect a, UnityEngine.Rect b);
                static /*0x30c75ec*/ UnityEngine.Rect Crop(UnityEngine.Rect src, UnityEngine.Rect cropRegion);
                static /*0x30c7608*/ UnityEngine.Vector4 ToMinMaxVector(UnityEngine.Rect rect);
                static /*0x30cb7c0*/ UnityEngine.Vector4 ToVector4(UnityEngine.Rect rect);
                static /*0x30cad54*/ UnityEngine.Rect Expand(UnityEngine.Rect rect, UnityEngine.Vector2 padding);
            }

            class ShaderID
            {
                static /*0x0*/ int VIBRANCY;
                static /*0x4*/ int BRIGHTNESS;
                static /*0x8*/ int FLATTEN;
                static /*0xc*/ int BLUR_TEX;
                static /*0x10*/ int MAIN_TEX;
                static /*0x14*/ int RADIUS;
                static /*0x18*/ int BACKGROUND_COLOR;
                static /*0x1c*/ int CROP_REGION;

                static /*0x30cb7c4*/ ShaderID();
            }

            class Shims
            {
                static /*0x1ffc854*/ T FindObjectOfType<T>(bool includeInactive, bool sorted);
                static T[] FindObjectsOfType<T>(bool includeInactive);
            }

            class VPMatrixCache : System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Camera> cameras;
                /*0x18*/ Unity.Collections.NativeList<UnityEngine.Matrix4x4> <VpMatrices>k__BackingField;

                /*0x30c99f8*/ VPMatrixCache();
                /*0x30cb99c*/ Unity.Collections.NativeList<UnityEngine.Matrix4x4> get_VpMatrices();
                /*0x30c8880*/ LeTai.Asset.TranslucentImage.VPMatrixCache.Index IndexOf(UnityEngine.Camera camera);
                /*0x30c88d8*/ LeTai.Asset.TranslucentImage.VPMatrixCache.Index Add(UnityEngine.Camera camera);
                /*0x30cb9a4*/ LeTai.Asset.TranslucentImage.VPMatrixCache.Index Add(UnityEngine.Camera camera, UnityEngine.Matrix4x4 vpMatrix);
                /*0x30cab80*/ void Clear();
                /*0x30c9ca0*/ void Dispose();

                struct Index
                {
                    static /*0x0*/ LeTai.Asset.TranslucentImage.VPMatrixCache.Index INVALID;
                    /*0x10*/ int index;

                    static /*0x30cba60*/ Index();
                    /*0x30cba58*/ Index(int index);
                    /*0x30c6738*/ bool IsValid();
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 0D625EC6A8D3B41A2990283E49191489C130BAEF4F718D2D21D57131DB56D177;
    static /*0x3bb*/ <PrivateImplementationDetails> D45B503D807133CFD9446F13E67D3E70416FED01216B1F29F13BE96CD4AAB130;

    struct __StaticArrayInitTypeSize=924
    {
    }

    struct __StaticArrayInitTypeSize=955
    {
    }
}

class __JobReflectionRegistrationOutput__11076780435287693420
{
    static /*0x30cbaac*/ void CreateJobReflectionData();
    static /*0x30cbb8c*/ void EarlyInit();
}
