class <Module>
{
}

namespace Microsoft
{
    namespace CodeAnalysis
    {
        class EmbeddedAttribute : System.Attribute
        {
            /*0x534220*/ EmbeddedAttribute();
        }
    }
}

namespace System
{
    namespace Runtime
    {
        namespace CompilerServices
        {
            class IsUnmanagedAttribute : System.Attribute
            {
                /*0x534220*/ IsUnmanagedAttribute();
            }
        }
    }
}

class FullScreenPassRendererFeature : UnityEngine.Rendering.Universal.ScriptableRendererFeature, UnityEngine.ISerializationCallbackReceiver
{
    /*0x20*/ FullScreenPassRendererFeature.InjectionPoint injectionPoint;
    /*0x24*/ bool fetchColorBuffer;
    /*0x28*/ UnityEngine.Rendering.Universal.ScriptableRenderPassInput requirements;
    /*0x30*/ UnityEngine.Material passMaterial;
    /*0x38*/ bool showAdditionalProperties;
    /*0x3c*/ int passIndex;
    /*0x40*/ bool bindDepthStencilAttachment;
    /*0x48*/ FullScreenPassRendererFeature.FullScreenRenderPass m_FullScreenPass;
    /*0x50*/ FullScreenPassRendererFeature.Version m_Version;

    /*0x13491d0*/ FullScreenPassRendererFeature();
    /*0x1349070*/ void Create();
    /*0x1349190*/ bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event atEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
    /*0x1348d80*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
    /*0x1349160*/ void Dispose(bool disposing);
    /*0x32d010*/ void UpgradeIfNeeded();
    /*0x13491c0*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
    /*0x13491b0*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();

    enum InjectionPoint
    {
        BeforeRenderingTransparents = 450,
        BeforeRenderingPostProcessing = 550,
        AfterRenderingPostProcessing = 600,
    }

    class FullScreenRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
    {
        static /*0x0*/ UnityEngine.MaterialPropertyBlock s_SharedPropertyBlock;
        /*0xe0*/ UnityEngine.Material m_Material;
        /*0xe8*/ int m_PassIndex;
        /*0xec*/ bool m_CopyActiveColor;
        /*0xed*/ bool m_BindDepthStencilAttachment;
        /*0xf0*/ UnityEngine.Rendering.RTHandle m_CopiedColor;

        static /*0x1349bd0*/ FullScreenRenderPass();
        static /*0x1349210*/ void ExecuteCopyColorPass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle sourceTexture);
        static /*0x1349290*/ void ExecuteMainPass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Material material, int passIndex);
        /*0x1349c50*/ FullScreenRenderPass(string passName);
        /*0x1349b70*/ void SetupMembers(UnityEngine.Material material, int passIndex, bool copyActiveColor, bool bindDepthStencilAttachment);
        /*0x13499c0*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
        /*0x1349ac0*/ void ReAllocate(UnityEngine.RenderTextureDescriptor desc);
        /*0x13491f0*/ void Dispose();
        /*0x13494f0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
    }

    enum Version
    {
        Uninitialised = -1,
        Initial = 0,
        AddFetchColorBufferCheckbox = 1,
        Count = 2,
        Latest = 1,
    }
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x134d530*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x32f970*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace UnityEngine
{
    namespace Experimental
    {
        namespace Rendering
        {
            namespace Universal
            {
                class PixelPerfectCamera : UnityEngine.MonoBehaviour, UnityEngine.Rendering.Universal.IPixelPerfectCamera, UnityEngine.ISerializationCallbackReceiver
                {
                    /*0x20*/ int m_AssetsPPU;
                    /*0x24*/ int m_RefResolutionX;
                    /*0x28*/ int m_RefResolutionY;
                    /*0x2c*/ UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera.CropFrame m_CropFrame;
                    /*0x30*/ UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera.GridSnapping m_GridSnapping;
                    /*0x34*/ UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera.PixelPerfectFilterMode m_FilterMode;
                    /*0x38*/ UnityEngine.Camera m_Camera;
                    /*0x40*/ UnityEngine.Rendering.Universal.PixelPerfectCameraInternal m_Internal;
                    /*0x48*/ bool m_CinemachineCompatibilityMode;

                    /*0x134ae40*/ PixelPerfectCamera();
                    /*0xbe6c70*/ UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera.CropFrame get_cropFrame();
                    /*0xbe6cd0*/ void set_cropFrame(UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera.CropFrame value);
                    /*0xa79cc0*/ UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera.GridSnapping get_gridSnapping();
                    /*0xa79cd0*/ void set_gridSnapping(UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera.GridSnapping value);
                    /*0x134afb0*/ float get_orthographicSize();
                    /*0x3e3af0*/ int get_assetsPPU();
                    /*0x134b060*/ void set_assetsPPU(int value);
                    /*0x3e3ad0*/ int get_refResolutionX();
                    /*0x134b130*/ void set_refResolutionX(int value);
                    /*0x3e3ae0*/ int get_refResolutionY();
                    /*0x134b160*/ void set_refResolutionY(int value);
                    /*0x134b050*/ bool get_upscaleRT();
                    /*0x134b1a0*/ void set_upscaleRT(bool value);
                    /*0x134b010*/ bool get_pixelSnapping();
                    /*0x134b110*/ void set_pixelSnapping(bool value);
                    /*0x134af30*/ bool get_cropFrameX();
                    /*0x134b090*/ void set_cropFrameX(bool value);
                    /*0x134af50*/ bool get_cropFrameY();
                    /*0x134b0d0*/ void set_cropFrameY(bool value);
                    /*0x134b040*/ bool get_stretchFill();
                    /*0x134b190*/ void set_stretchFill(bool value);
                    /*0x134afd0*/ int get_pixelRatio();
                    /*0x134b020*/ bool get_requiresUpscalePass();
                    /*0x134abe0*/ UnityEngine.Vector3 RoundToPixel(UnityEngine.Vector3 position);
                    /*0x134a4a0*/ float CorrectCinemachineOrthoSize(float targetOrthoSize);
                    /*0x134af70*/ UnityEngine.FilterMode get_finalBlitFilterMode();
                    /*0x134af80*/ UnityEngine.Vector2Int get_offscreenRTSize();
                    /*0x134ae60*/ UnityEngine.Vector2Int get_cameraRTSize();
                    /*0x134a7d0*/ void PixelSnap();
                    /*0x134a400*/ void Awake();
                    /*0x134acc0*/ void UpdateCameraProperties();
                    /*0x134a4c0*/ void OnBeginCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                    /*0x134a760*/ void OnEndCameraRendering(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                    /*0x134a690*/ void OnEnable();
                    /*0x134a580*/ void OnDisable();
                    /*0x32d010*/ void OnBeforeSerialize();
                    /*0x32d010*/ void OnAfterDeserialize();

                    enum CropFrame
                    {
                        None = 0,
                        Pillarbox = 1,
                        Letterbox = 2,
                        Windowbox = 3,
                        StretchFill = 4,
                    }

                    enum GridSnapping
                    {
                        None = 0,
                        PixelSnapping = 1,
                        UpscaleRenderTexture = 2,
                    }

                    enum PixelPerfectFilterMode
                    {
                        RetroAA = 0,
                        Point = 1,
                    }

                    enum ComponentVersions
                    {
                        Version_Unserialized = 0,
                        Version_1 = 1,
                    }
                }

                class RenderObjectsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xe0*/ UnityEngine.Experimental.Rendering.Universal.RenderQueueType renderQueueType;
                    /*0xe4*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                    /*0x100*/ UnityEngine.Experimental.Rendering.Universal.RenderObjects.CustomCameraSettings m_CameraSettings;
                    /*0x108*/ string m_ProfilerTag;
                    /*0x110*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                    /*0x118*/ UnityEngine.Material <overrideMaterial>k__BackingField;
                    /*0x120*/ int <overrideMaterialPassIndex>k__BackingField;
                    /*0x128*/ UnityEngine.Shader <overrideShader>k__BackingField;
                    /*0x130*/ int <overrideShaderPassIndex>k__BackingField;
                    /*0x138*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                    /*0x140*/ UnityEngine.Rendering.RenderStateBlock m_RenderStateBlock;

                    /*0x134c670*/ RenderObjectsPass(string profilerTag, UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent, string[] shaderTags, UnityEngine.Experimental.Rendering.Universal.RenderQueueType renderQueueType, int layerMask, UnityEngine.Experimental.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings);
                    /*0x134c570*/ RenderObjectsPass(UnityEngine.Rendering.Universal.URPProfileId profileId, UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent, string[] shaderTags, UnityEngine.Experimental.Rendering.Universal.RenderQueueType renderQueueType, int layerMask, UnityEngine.Experimental.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings);
                    /*0x134cc10*/ UnityEngine.Material get_overrideMaterial();
                    /*0x134cc40*/ void set_overrideMaterial(UnityEngine.Material value);
                    /*0x134cc00*/ int get_overrideMaterialPassIndex();
                    /*0x134cc30*/ void set_overrideMaterialPassIndex(int value);
                    /*0x10d2010*/ UnityEngine.Shader get_overrideShader();
                    /*0x10f5010*/ void set_overrideShader(UnityEngine.Shader value);
                    /*0x134cc20*/ int get_overrideShaderPassIndex();
                    /*0x134cc60*/ void set_overrideShaderPassIndex(int value);
                    /*0x134c3d0*/ void SetDetphState(bool writeEnabled, UnityEngine.Rendering.CompareFunction function);
                    /*0x134c460*/ void SetStencilState(int reference, UnityEngine.Rendering.CompareFunction compareFunction, UnityEngine.Rendering.StencilOp passOp, UnityEngine.Rendering.StencilOp failOp, UnityEngine.Rendering.StencilOp zFailOp);
                    /*0x134b740*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x134bfb0*/ void RecordRenderGraph(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.Universal.RenderingData renderingData);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Experimental.Rendering.Universal.RenderObjectsPass pass;
                        /*0x18*/ UnityEngine.Rendering.Universal.RenderingData renderingData;

                        /*0x32f970*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Experimental.Rendering.Universal.RenderObjectsPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.Universal.DebugHandler.DrawFunction <>9__27_0;
                        static /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Experimental.Rendering.Universal.RenderObjectsPass.PassData> <>9__29_0;

                        static /*0x134d4c0*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x134d3e0*/ void <Execute>b__27_0(UnityEngine.Rendering.ScriptableRenderContext ctx, ref UnityEngine.Rendering.Universal.RenderingData data, ref UnityEngine.Rendering.DrawingSettings ds, ref UnityEngine.Rendering.FilteringSettings fs, ref UnityEngine.Rendering.RenderStateBlock rsb);
                        /*0x134d480*/ void <RecordRenderGraph>b__29_0(UnityEngine.Experimental.Rendering.Universal.RenderObjectsPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext);
                    }
                }

                enum RenderQueueType
                {
                    Opaque = 0,
                    Transparent = 1,
                }

                class RenderObjects : UnityEngine.Rendering.Universal.ScriptableRendererFeature
                {
                    /*0x20*/ UnityEngine.Experimental.Rendering.Universal.RenderObjects.RenderObjectsSettings settings;
                    /*0x28*/ UnityEngine.Experimental.Rendering.Universal.RenderObjectsPass renderObjectsPass;

                    /*0x134d260*/ RenderObjects();
                    /*0x134ce30*/ void Create();
                    /*0x134cda0*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x3ce290*/ bool SupportsNativeRenderPass();

                    class RenderObjectsSettings
                    {
                        /*0x10*/ string passTag;
                        /*0x18*/ UnityEngine.Rendering.Universal.RenderPassEvent Event;
                        /*0x20*/ UnityEngine.Experimental.Rendering.Universal.RenderObjects.FilterSettings filterSettings;
                        /*0x28*/ UnityEngine.Material overrideMaterial;
                        /*0x30*/ int overrideMaterialPassIndex;
                        /*0x38*/ UnityEngine.Shader overrideShader;
                        /*0x40*/ int overrideShaderPassIndex;
                        /*0x44*/ UnityEngine.Experimental.Rendering.Universal.RenderObjects.RenderObjectsSettings.OverrideMaterialMode overrideMode;
                        /*0x48*/ bool overrideDepthState;
                        /*0x4c*/ UnityEngine.Rendering.CompareFunction depthCompareFunction;
                        /*0x50*/ bool enableWrite;
                        /*0x58*/ UnityEngine.Rendering.Universal.StencilStateData stencilSettings;
                        /*0x60*/ UnityEngine.Experimental.Rendering.Universal.RenderObjects.CustomCameraSettings cameraSettings;

                        /*0x134cc70*/ RenderObjectsSettings();

                        enum OverrideMaterialMode
                        {
                            None = 0,
                            Material = 1,
                            Shader = 2,
                        }
                    }

                    class FilterSettings
                    {
                        /*0x10*/ UnityEngine.Experimental.Rendering.Universal.RenderQueueType RenderQueueType;
                        /*0x14*/ UnityEngine.LayerMask LayerMask;
                        /*0x18*/ string[] PassNames;

                        /*0x1348d50*/ FilterSettings();
                    }

                    class CustomCameraSettings
                    {
                        /*0x10*/ bool overrideCamera;
                        /*0x11*/ bool restoreCamera;
                        /*0x14*/ UnityEngine.Vector4 offset;
                        /*0x24*/ float cameraFieldOfView;

                        /*0x1348d10*/ CustomCameraSettings();
                    }
                }
            }
        }
    }

    namespace Rendering
    {
        namespace Universal
        {
            class CinemachineUniversalPixelPerfect : UnityEngine.MonoBehaviour
            {
                /*0x31c640*/ CinemachineUniversalPixelPerfect();
                /*0x1335ba0*/ void OnEnable();
            }

            struct DoublePoint
            {
                /*0x10*/ double X;
                /*0x18*/ double Y;

                /*0x11534d0*/ DoublePoint(double x, double y);
                /*0x1209890*/ DoublePoint(UnityEngine.Rendering.Universal.DoublePoint dp);
                /*0x1348d30*/ DoublePoint(UnityEngine.Rendering.Universal.IntPoint ip);
            }

            class PolyTree : UnityEngine.Rendering.Universal.PolyNode
            {
                /*0x40*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.PolyNode> m_AllPolys;

                /*0x134b620*/ PolyTree();
                /*0x134b4c0*/ void Clear();
                /*0x134b5b0*/ UnityEngine.Rendering.Universal.PolyNode GetFirst();
                /*0x134b6a0*/ int get_Total();
            }

            class PolyNode
            {
                /*0x10*/ UnityEngine.Rendering.Universal.PolyNode m_Parent;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> m_polygon;
                /*0x20*/ int m_Index;
                /*0x24*/ UnityEngine.Rendering.Universal.JoinType m_jointype;
                /*0x28*/ UnityEngine.Rendering.Universal.EndType m_endtype;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.PolyNode> m_Childs;
                /*0x38*/ bool <IsOpen>k__BackingField;

                /*0x134b3c0*/ PolyNode();
                /*0x134b3a0*/ bool IsHoleNode();
                /*0x134b480*/ int get_ChildCount();
                /*0x32f410*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> get_Contour();
                /*0x134b1c0*/ void AddChild(UnityEngine.Rendering.Universal.PolyNode Child);
                /*0x134b330*/ UnityEngine.Rendering.Universal.PolyNode GetNext();
                /*0x134b2a0*/ UnityEngine.Rendering.Universal.PolyNode GetNextSiblingUp();
                /*0x997630*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.PolyNode> get_Childs();
                /*0x73d3e0*/ UnityEngine.Rendering.Universal.PolyNode get_Parent();
                /*0x134b3a0*/ bool get_IsHole();
                /*0xd180c0*/ bool get_IsOpen();
                /*0xd18610*/ void set_IsOpen(bool value);
            }

            struct Int128
            {
                /*0x10*/ long hi;
                /*0x18*/ ulong lo;

                static /*0x1349ed0*/ bool op_Equality(UnityEngine.Rendering.Universal.Int128 val1, UnityEngine.Rendering.Universal.Int128 val2);
                static /*0x134a060*/ bool op_Inequality(UnityEngine.Rendering.Universal.Int128 val1, UnityEngine.Rendering.Universal.Int128 val2);
                static /*0x134a040*/ bool op_GreaterThan(UnityEngine.Rendering.Universal.Int128 val1, UnityEngine.Rendering.Universal.Int128 val2);
                static /*0x134a120*/ bool op_LessThan(UnityEngine.Rendering.Universal.Int128 val1, UnityEngine.Rendering.Universal.Int128 val2);
                static /*0x1349ea0*/ UnityEngine.Rendering.Universal.Int128 op_Addition(UnityEngine.Rendering.Universal.Int128 lhs, UnityEngine.Rendering.Universal.Int128 rhs);
                static /*0x134a140*/ UnityEngine.Rendering.Universal.Int128 op_Subtraction(UnityEngine.Rendering.Universal.Int128 lhs, UnityEngine.Rendering.Universal.Int128 rhs);
                static /*0x134a1b0*/ UnityEngine.Rendering.Universal.Int128 op_UnaryNegation(UnityEngine.Rendering.Universal.Int128 val);
                static /*0x1349f90*/ double op_Explicit(UnityEngine.Rendering.Universal.Int128 val);
                static /*0x1349db0*/ UnityEngine.Rendering.Universal.Int128 Int128Mul(long lhs, long rhs);
                /*0x1349e80*/ Int128(long _lo);
                /*0x1349e90*/ Int128(long _hi, ulong _lo);
                /*0x1209890*/ Int128(UnityEngine.Rendering.Universal.Int128 val);
                /*0x1349e70*/ bool IsNegative();
                /*0x1349cf0*/ bool Equals(object obj);
                /*0x1349d80*/ int GetHashCode();
            }

            struct IntPoint
            {
                /*0x10*/ long N;
                /*0x18*/ long X;
                /*0x20*/ long Y;
                /*0x28*/ long D;
                /*0x30*/ double NX;
                /*0x38*/ double NY;

                static /*0x134a360*/ bool op_Equality(UnityEngine.Rendering.Universal.IntPoint a, UnityEngine.Rendering.Universal.IntPoint b);
                static /*0x134a390*/ bool op_Inequality(UnityEngine.Rendering.Universal.IntPoint a, UnityEngine.Rendering.Universal.IntPoint b);
                /*0x134a310*/ IntPoint(long X, long Y);
                /*0x134a2e0*/ IntPoint(double x, double y);
                /*0x134a330*/ IntPoint(UnityEngine.Rendering.Universal.IntPoint pt);
                /*0x134a1f0*/ bool Equals(object obj);
                /*0x134a280*/ int GetHashCode();
            }

            struct IntRect
            {
                /*0x10*/ long left;
                /*0x18*/ long top;
                /*0x20*/ long right;
                /*0x28*/ long bottom;

                /*0x11536f0*/ IntRect(long l, long t, long r, long b);
                /*0x121e1f0*/ IntRect(UnityEngine.Rendering.Universal.IntRect ir);
            }

            enum ClipType
            {
                ctIntersection = 0,
                ctUnion = 1,
                ctDifference = 2,
                ctXor = 3,
            }

            enum PolyType
            {
                ptSubject = 0,
                ptClip = 1,
            }

            enum PolyFillType
            {
                pftEvenOdd = 0,
                pftNonZero = 1,
                pftPositive = 2,
                pftNegative = 3,
            }

            enum JoinType
            {
                jtRound = 0,
            }

            enum EndType
            {
                etClosedPolygon = 0,
                etClosedLine = 1,
            }

            enum EdgeSide
            {
                esLeft = 0,
                esRight = 1,
            }

            enum Direction
            {
                dRightToLeft = 0,
                dLeftToRight = 1,
            }

            class TEdge
            {
                /*0x10*/ UnityEngine.Rendering.Universal.IntPoint Bot;
                /*0x40*/ UnityEngine.Rendering.Universal.IntPoint Curr;
                /*0x70*/ UnityEngine.Rendering.Universal.IntPoint Top;
                /*0xa0*/ UnityEngine.Rendering.Universal.IntPoint Delta;
                /*0xd0*/ double Dx;
                /*0xd8*/ UnityEngine.Rendering.Universal.PolyType PolyTyp;
                /*0xdc*/ UnityEngine.Rendering.Universal.EdgeSide Side;
                /*0xe0*/ int WindDelta;
                /*0xe4*/ int WindCnt;
                /*0xe8*/ int WindCnt2;
                /*0xec*/ int OutIdx;
                /*0xf0*/ UnityEngine.Rendering.Universal.TEdge Next;
                /*0xf8*/ UnityEngine.Rendering.Universal.TEdge Prev;
                /*0x100*/ UnityEngine.Rendering.Universal.TEdge NextInLML;
                /*0x108*/ UnityEngine.Rendering.Universal.TEdge NextInAEL;
                /*0x110*/ UnityEngine.Rendering.Universal.TEdge PrevInAEL;
                /*0x118*/ UnityEngine.Rendering.Universal.TEdge NextInSEL;
                /*0x120*/ UnityEngine.Rendering.Universal.TEdge PrevInSEL;

                /*0x32f970*/ TEdge();
            }

            class IntersectNode
            {
                /*0x10*/ UnityEngine.Rendering.Universal.TEdge Edge1;
                /*0x18*/ UnityEngine.Rendering.Universal.TEdge Edge2;
                /*0x20*/ UnityEngine.Rendering.Universal.IntPoint Pt;

                /*0x32f970*/ IntersectNode();
            }

            class MyIntersectNodeSort : System.Collections.Generic.IComparer<UnityEngine.Rendering.Universal.IntersectNode>
            {
                /*0x32f970*/ MyIntersectNodeSort();
                /*0x134a3c0*/ int Compare(UnityEngine.Rendering.Universal.IntersectNode node1, UnityEngine.Rendering.Universal.IntersectNode node2);
            }

            class LocalMinima
            {
                /*0x10*/ long Y;
                /*0x18*/ UnityEngine.Rendering.Universal.TEdge LeftBound;
                /*0x20*/ UnityEngine.Rendering.Universal.TEdge RightBound;
                /*0x28*/ UnityEngine.Rendering.Universal.LocalMinima Next;

                /*0x32f970*/ LocalMinima();
            }

            class Scanbeam
            {
                /*0x10*/ long Y;
                /*0x18*/ UnityEngine.Rendering.Universal.Scanbeam Next;

                /*0x32f970*/ Scanbeam();
            }

            class Maxima
            {
                /*0x10*/ long X;
                /*0x18*/ UnityEngine.Rendering.Universal.Maxima Next;
                /*0x20*/ UnityEngine.Rendering.Universal.Maxima Prev;

                /*0x32f970*/ Maxima();
            }

            class OutRec
            {
                /*0x10*/ int Idx;
                /*0x14*/ bool IsHole;
                /*0x15*/ bool IsOpen;
                /*0x18*/ UnityEngine.Rendering.Universal.OutRec FirstLeft;
                /*0x20*/ UnityEngine.Rendering.Universal.OutPt Pts;
                /*0x28*/ UnityEngine.Rendering.Universal.OutPt BottomPt;
                /*0x30*/ UnityEngine.Rendering.Universal.PolyNode PolyNode;

                /*0x32f970*/ OutRec();
            }

            class OutPt
            {
                /*0x10*/ int Idx;
                /*0x18*/ UnityEngine.Rendering.Universal.IntPoint Pt;
                /*0x48*/ UnityEngine.Rendering.Universal.OutPt Next;
                /*0x50*/ UnityEngine.Rendering.Universal.OutPt Prev;

                /*0x32f970*/ OutPt();
            }

            class Join
            {
                /*0x10*/ UnityEngine.Rendering.Universal.OutPt OutPt1;
                /*0x18*/ UnityEngine.Rendering.Universal.OutPt OutPt2;
                /*0x20*/ UnityEngine.Rendering.Universal.IntPoint OffPt;

                /*0x32f970*/ Join();
            }

            class ClipperBase
            {
                static double horizontal = -3.4e+38;
                static int Skip = -2;
                static int Unassigned = -1;
                static double tolerance = 1e-20;
                static long loRange = 1073741823;
                static long hiRange = 4611686018427387903;
                /*0x10*/ UnityEngine.Rendering.Universal.LocalMinima m_MinimaList;
                /*0x18*/ UnityEngine.Rendering.Universal.LocalMinima m_CurrentLM;
                /*0x20*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.TEdge>> m_edges;
                /*0x28*/ UnityEngine.Rendering.Universal.Scanbeam m_Scanbeam;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.OutRec> m_PolyOuts;
                /*0x38*/ UnityEngine.Rendering.Universal.TEdge m_ActiveEdges;
                /*0x40*/ bool m_UseFullRange;
                /*0x41*/ bool m_HasOpenPaths;
                /*0x42*/ bool <PreserveCollinear>k__BackingField;

                static /*0x133a5e0*/ bool near_zero(double val);
                static /*0x13388d0*/ bool IsHorizontal(UnityEngine.Rendering.Universal.TEdge e);
                static /*0x1339ae0*/ bool SlopesEqual(UnityEngine.Rendering.Universal.TEdge e1, UnityEngine.Rendering.Universal.TEdge e2, bool UseFullRange);
                static /*0x1339df0*/ bool SlopesEqual(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2, UnityEngine.Rendering.Universal.IntPoint pt3, bool UseFullRange);
                static /*0x1339c60*/ bool SlopesEqual(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2, UnityEngine.Rendering.Universal.IntPoint pt3, UnityEngine.Rendering.Universal.IntPoint pt4, bool UseFullRange);
                static /*0x1338180*/ UnityEngine.Rendering.Universal.IntRect GetBounds(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> paths);
                /*0x133a530*/ ClipperBase();
                /*0x133a5d0*/ bool get_PreserveCollinear();
                /*0x133a600*/ void set_PreserveCollinear(bool value);
                /*0x133a2b0*/ void Swap(ref long val1, ref long val2);
                /*0x13388f0*/ bool PointIsVertex(UnityEngine.Rendering.Universal.IntPoint pt, UnityEngine.Rendering.Universal.OutPt pp);
                /*0x1338940*/ bool PointOnLineSegment(UnityEngine.Rendering.Universal.IntPoint pt, UnityEngine.Rendering.Universal.IntPoint linePt1, UnityEngine.Rendering.Universal.IntPoint linePt2, bool UseFullRange);
                /*0x1338bc0*/ bool PointOnPolygon(UnityEngine.Rendering.Universal.IntPoint pt, UnityEngine.Rendering.Universal.OutPt pp, bool UseFullRange);
                /*0x1337b60*/ void Clear();
                /*0x1337f40*/ void DisposeLocalMinimaList();
                /*0x1339610*/ void RangeTest(UnityEngine.Rendering.Universal.IntPoint Pt, ref bool useFullRange);
                /*0x1338620*/ void InitEdge(UnityEngine.Rendering.Universal.TEdge e, UnityEngine.Rendering.Universal.TEdge eNext, UnityEngine.Rendering.Universal.TEdge ePrev, UnityEngine.Rendering.Universal.IntPoint pt);
                /*0x1338500*/ void InitEdge2(UnityEngine.Rendering.Universal.TEdge e, UnityEngine.Rendering.Universal.PolyType polyType);
                /*0x1338050*/ UnityEngine.Rendering.Universal.TEdge FindNextLocMin(UnityEngine.Rendering.Universal.TEdge E);
                /*0x1338f30*/ UnityEngine.Rendering.Universal.TEdge ProcessBound(UnityEngine.Rendering.Universal.TEdge E, bool LeftBoundIsForward);
                /*0x1335c00*/ bool AddPath(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> pg, UnityEngine.Rendering.Universal.PolyType polyType, bool Closed);
                /*0x1337a90*/ bool AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> ppg, UnityEngine.Rendering.Universal.PolyType polyType, bool closed);
                /*0x1339570*/ bool Pt2IsBetweenPt1AndPt3(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2, UnityEngine.Rendering.Universal.IntPoint pt3);
                /*0x1339750*/ UnityEngine.Rendering.Universal.TEdge RemoveEdge(UnityEngine.Rendering.Universal.TEdge e);
                /*0x1339a70*/ void SetDx(UnityEngine.Rendering.Universal.TEdge e);
                /*0x13386a0*/ void InsertLocalMinima(UnityEngine.Rendering.Universal.LocalMinima newLm);
                /*0x1338e80*/ bool PopLocalMinima(long Y, ref UnityEngine.Rendering.Universal.LocalMinima current);
                /*0x1339a40*/ void ReverseHorizontal(UnityEngine.Rendering.Universal.TEdge e);
                /*0x13397f0*/ void Reset();
                /*0x1338760*/ void InsertScanbeam(long Y);
                /*0x1338ee0*/ bool PopScanbeam(ref long Y);
                /*0xfd8400*/ bool LocalMinimaPending();
                /*0x1337d30*/ UnityEngine.Rendering.Universal.OutRec CreateOutRec();
                /*0x1337fc0*/ void DisposeOutRec(int index);
                /*0x133a2c0*/ void UpdateEdgeIntoAEL(ref UnityEngine.Rendering.Universal.TEdge e);
                /*0x1339fa0*/ void SwapPositionsInAEL(UnityEngine.Rendering.Universal.TEdge edge1, UnityEngine.Rendering.Universal.TEdge edge2);
                /*0x1337e80*/ void DeleteFromAEL(UnityEngine.Rendering.Universal.TEdge e);
            }

            class Clipper : UnityEngine.Rendering.Universal.ClipperBase
            {
                static int ioReverseSolution = 1;
                static int ioStrictlySimple = 2;
                static int ioPreserveCollinear = 4;
                /*0x48*/ UnityEngine.Rendering.Universal.ClipType m_ClipType;
                /*0x50*/ UnityEngine.Rendering.Universal.Maxima m_Maxima;
                /*0x58*/ UnityEngine.Rendering.Universal.TEdge m_SortedEdges;
                /*0x60*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntersectNode> m_IntersectList;
                /*0x68*/ System.Collections.Generic.IComparer<UnityEngine.Rendering.Universal.IntersectNode> m_IntersectNodeComparer;
                /*0x70*/ bool m_ExecuteLocked;
                /*0x74*/ UnityEngine.Rendering.Universal.PolyFillType m_ClipFillType;
                /*0x78*/ UnityEngine.Rendering.Universal.PolyFillType m_SubjFillType;
                /*0x80*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.Join> m_Joins;
                /*0x88*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.Join> m_GhostJoins;
                /*0x90*/ bool m_UsingPolyTree;
                /*0x94*/ int <LastIndex>k__BackingField;
                /*0x98*/ bool <ReverseSolution>k__BackingField;
                /*0x99*/ bool <StrictlySimple>k__BackingField;

                static /*0x1348730*/ void SwapSides(UnityEngine.Rendering.Universal.TEdge edge1, UnityEngine.Rendering.Universal.TEdge edge2);
                static /*0x13483e0*/ void SwapPolyIndexes(UnityEngine.Rendering.Universal.TEdge edge1, UnityEngine.Rendering.Universal.TEdge edge2);
                static /*0x1341f60*/ int IntersectNodeSort(UnityEngine.Rendering.Universal.IntersectNode node1, UnityEngine.Rendering.Universal.IntersectNode node2);
                static /*0x1347ab0*/ long Round(double value);
                static /*0x1348770*/ long TopX(UnityEngine.Rendering.Universal.TEdge edge, long currentY);
                static /*0x1347920*/ void ReversePaths(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> polys);
                static /*0x13452f0*/ bool Orientation(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> poly);
                static /*0x1345650*/ int PointInPolygon(UnityEngine.Rendering.Universal.IntPoint pt, System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path);
                static /*0x13454f0*/ int PointInPolygon(UnityEngine.Rendering.Universal.IntPoint pt, UnityEngine.Rendering.Universal.OutPt op);
                static /*0x13459b0*/ bool Poly2ContainsPoly1(UnityEngine.Rendering.Universal.OutPt outPt1, UnityEngine.Rendering.Universal.OutPt outPt2);
                static /*0x13454a0*/ UnityEngine.Rendering.Universal.OutRec ParseFirstLeft(UnityEngine.Rendering.Universal.OutRec FirstLeft);
                static /*0x133bd70*/ double Area(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> poly);
                static /*0x1347ea0*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> SimplifyPolygon(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> poly, UnityEngine.Rendering.Universal.PolyFillType fillType);
                static /*0x1347f90*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> SimplifyPolygons(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> polys, UnityEngine.Rendering.Universal.PolyFillType fillType);
                static /*0x133d490*/ double DistanceSqrd(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2);
                static /*0x133d3e0*/ double DistanceFromLineSqrd(UnityEngine.Rendering.Universal.IntPoint pt, UnityEngine.Rendering.Universal.IntPoint ln1, UnityEngine.Rendering.Universal.IntPoint ln2);
                static /*0x1348080*/ bool SlopesNearCollinear(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2, UnityEngine.Rendering.Universal.IntPoint pt3, double distSqrd);
                static /*0x1345940*/ bool PointsAreClose(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2, double distSqrd);
                static /*0x133ee00*/ UnityEngine.Rendering.Universal.OutPt ExcludeOp(UnityEngine.Rendering.Universal.OutPt op);
                static /*0x133c880*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> CleanPolygon(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path, double distance);
                static /*0x133cf90*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> CleanPolygons(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> polys, double distance);
                static /*0x13448c0*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> Minkowski(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> pattern, System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path, bool IsSum, bool IsClosed);
                static /*0x13447f0*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> MinkowskiSum(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> pattern, System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path, bool pathIsClosed);
                static /*0x13487e0*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> TranslatePath(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path, UnityEngine.Rendering.Universal.IntPoint delta);
                static /*0x1344570*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> MinkowskiSum(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> pattern, System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> paths, bool pathIsClosed);
                static /*0x13444b0*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> MinkowskiDiff(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> poly1, System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> poly2);
                static /*0x1345b40*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> PolyTreeToPaths(UnityEngine.Rendering.Universal.PolyTree polytree);
                static /*0x133b180*/ void AddPolyNodeToPaths(UnityEngine.Rendering.Universal.PolyNode polynode, UnityEngine.Rendering.Universal.Clipper.NodeType nt, System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> paths);
                static /*0x1345180*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> OpenPathsFromPolyTree(UnityEngine.Rendering.Universal.PolyTree polytree);
                static /*0x133d0e0*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> ClosedPathsFromPolyTree(UnityEngine.Rendering.Universal.PolyTree polytree);
                /*0x1348a40*/ Clipper(int InitOptions);
                /*0x1341690*/ void InsertMaxima(long X);
                /*0x1348cb0*/ int get_LastIndex();
                /*0x1348ce0*/ void set_LastIndex(int value);
                /*0x1348cc0*/ bool get_ReverseSolution();
                /*0x1348cf0*/ void set_ReverseSolution(bool value);
                /*0x1348cd0*/ bool get_StrictlySimple();
                /*0x1348d00*/ void set_StrictlySimple(bool value);
                /*0x133f570*/ bool Execute(UnityEngine.Rendering.Universal.ClipType clipType, System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> solution, UnityEngine.Rendering.Universal.PolyFillType FillType);
                /*0x133f590*/ bool Execute(UnityEngine.Rendering.Universal.ClipType clipType, UnityEngine.Rendering.Universal.PolyTree polytree, UnityEngine.Rendering.Universal.PolyFillType FillType);
                /*0x133f3d0*/ bool Execute(UnityEngine.Rendering.Universal.ClipType clipType, System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> solution, UnityEngine.Rendering.Universal.PolyFillType subjFillType, UnityEngine.Rendering.Universal.PolyFillType clipFillType);
                /*0x133f2f0*/ bool Execute(UnityEngine.Rendering.Universal.ClipType clipType, UnityEngine.Rendering.Universal.PolyTree polytree, UnityEngine.Rendering.Universal.PolyFillType subjFillType, UnityEngine.Rendering.Universal.PolyFillType clipFillType);
                /*0x133f9a0*/ void FixHoleLinkage(UnityEngine.Rendering.Universal.OutRec outRec);
                /*0x133ee60*/ bool ExecuteInternal();
                /*0x133d2c0*/ void DisposeAllPolyPts();
                /*0x133a810*/ void AddJoin(UnityEngine.Rendering.Universal.OutPt Op1, UnityEngine.Rendering.Universal.OutPt Op2, UnityEngine.Rendering.Universal.IntPoint OffPt);
                /*0x133a6f0*/ void AddGhostJoin(UnityEngine.Rendering.Universal.OutPt Op, UnityEngine.Rendering.Universal.IntPoint OffPt);
                /*0x1340f90*/ void InsertLocalMinimaIntoAEL(long botY);
                /*0x1340de0*/ void InsertEdgeIntoAEL(UnityEngine.Rendering.Universal.TEdge edge, UnityEngine.Rendering.Universal.TEdge startEdge);
                /*0x133eca0*/ bool E2InsertsBeforeE1(UnityEngine.Rendering.Universal.TEdge e1, UnityEngine.Rendering.Universal.TEdge e2);
                /*0x1342790*/ bool IsEvenOddFillType(UnityEngine.Rendering.Universal.TEdge edge);
                /*0x1342760*/ bool IsEvenOddAltFillType(UnityEngine.Rendering.Universal.TEdge edge);
                /*0x1342580*/ bool IsContributing(UnityEngine.Rendering.Universal.TEdge edge);
                /*0x1347c00*/ void SetWindingCount(UnityEngine.Rendering.Universal.TEdge edge);
                /*0x133a610*/ void AddEdgeToSEL(UnityEngine.Rendering.Universal.TEdge edge);
                /*0x1345bf0*/ bool PopEdgeFromSEL(ref UnityEngine.Rendering.Universal.TEdge e);
                /*0x133d190*/ void CopyAELToSEL();
                /*0x1348420*/ void SwapPositionsInSEL(UnityEngine.Rendering.Universal.TEdge edge1, UnityEngine.Rendering.Universal.TEdge edge2);
                /*0x133a950*/ void AddLocalMaxPoly(UnityEngine.Rendering.Universal.TEdge e1, UnityEngine.Rendering.Universal.TEdge e2, UnityEngine.Rendering.Universal.IntPoint pt);
                /*0x133aa40*/ UnityEngine.Rendering.Universal.OutPt AddLocalMinPoly(UnityEngine.Rendering.Universal.TEdge e1, UnityEngine.Rendering.Universal.TEdge e2, UnityEngine.Rendering.Universal.IntPoint pt);
                /*0x133ae50*/ UnityEngine.Rendering.Universal.OutPt AddOutPt(UnityEngine.Rendering.Universal.TEdge e, UnityEngine.Rendering.Universal.IntPoint pt);
                /*0x13408f0*/ UnityEngine.Rendering.Universal.OutPt GetLastOutPt(UnityEngine.Rendering.Universal.TEdge e);
                /*0x1348360*/ void SwapPoints(ref UnityEngine.Rendering.Universal.IntPoint pt1, ref UnityEngine.Rendering.Universal.IntPoint pt2);
                /*0x1340da0*/ bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b);
                /*0x1347ae0*/ void SetHoleState(UnityEngine.Rendering.Universal.TEdge e, UnityEngine.Rendering.Universal.OutRec outRec);
                /*0x1340840*/ double GetDx(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2);
                /*0x133f5b0*/ bool FirstIsBottomPt(UnityEngine.Rendering.Universal.OutPt btmPt1, UnityEngine.Rendering.Universal.OutPt btmPt2);
                /*0x1340750*/ UnityEngine.Rendering.Universal.OutPt GetBottomPt(UnityEngine.Rendering.Universal.OutPt pp);
                /*0x1340970*/ UnityEngine.Rendering.Universal.OutRec GetLowermostRec(UnityEngine.Rendering.Universal.OutRec outRec1, UnityEngine.Rendering.Universal.OutRec outRec2);
                /*0x1345470*/ bool OutRec1RightOfOutRec2(UnityEngine.Rendering.Universal.OutRec outRec1, UnityEngine.Rendering.Universal.OutRec outRec2);
                /*0x1340bf0*/ UnityEngine.Rendering.Universal.OutRec GetOutRec(int idx);
                /*0x133b320*/ void AppendPolygon(UnityEngine.Rendering.Universal.TEdge e1, UnityEngine.Rendering.Universal.TEdge e2);
                /*0x1347a40*/ void ReversePolyPtLinks(UnityEngine.Rendering.Universal.OutPt pp);
                /*0x1341800*/ void IntersectEdges(UnityEngine.Rendering.Universal.TEdge e1, UnityEngine.Rendering.Universal.TEdge e2, UnityEngine.Rendering.Universal.IntPoint pt);
                /*0x133d200*/ void DeleteFromSEL(UnityEngine.Rendering.Universal.TEdge e);
                /*0x13474e0*/ void ProcessHorizontals();
                /*0x1340890*/ void GetHorzDirection(UnityEngine.Rendering.Universal.TEdge HorzEdge, ref UnityEngine.Rendering.Universal.Direction Dir, ref long Left, ref long Right);
                /*0x1346540*/ void ProcessHorizontal(UnityEngine.Rendering.Universal.TEdge horzEdge);
                /*0x1340bc0*/ UnityEngine.Rendering.Universal.TEdge GetNextInAEL(UnityEngine.Rendering.Universal.TEdge e, UnityEngine.Rendering.Universal.Direction Direction);
                /*0x1342830*/ bool IsMinima(UnityEngine.Rendering.Universal.TEdge e);
                /*0x1342800*/ bool IsMaxima(UnityEngine.Rendering.Universal.TEdge e, double Y);
                /*0x13427c0*/ bool IsIntermediate(UnityEngine.Rendering.Universal.TEdge e, double Y);
                /*0x1340b30*/ UnityEngine.Rendering.Universal.TEdge GetMaximaPair(UnityEngine.Rendering.Universal.TEdge e);
                /*0x1340a60*/ UnityEngine.Rendering.Universal.TEdge GetMaximaPairEx(UnityEngine.Rendering.Universal.TEdge e);
                /*0x13476e0*/ bool ProcessIntersections(long topY);
                /*0x133bef0*/ void BuildIntersectList(long topY);
                /*0x133edc0*/ bool EdgesAdjacent(UnityEngine.Rendering.Universal.IntersectNode inode);
                /*0x133fef0*/ bool FixupIntersectionOrder();
                /*0x13475b0*/ void ProcessIntersectList();
                /*0x1341f80*/ void IntersectPoint(UnityEngine.Rendering.Universal.TEdge edge1, UnityEngine.Rendering.Universal.TEdge edge2, ref UnityEngine.Rendering.Universal.IntPoint ip);
                /*0x1345ca0*/ void ProcessEdgesAtTopOfScanbeam(long topY);
                /*0x133d4f0*/ void DoMaxima(UnityEngine.Rendering.Universal.TEdge e);
                /*0x13454c0*/ int PointCount(UnityEngine.Rendering.Universal.OutPt pts);
                /*0x133c650*/ void BuildResult(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> polyg);
                /*0x133c210*/ void BuildResult2(UnityEngine.Rendering.Universal.PolyTree polytree);
                /*0x1340650*/ void FixupOutPolyline(UnityEngine.Rendering.Universal.OutRec outrec);
                /*0x13401a0*/ void FixupOutPolygon(UnityEngine.Rendering.Universal.OutRec outRec);
                /*0x133eb50*/ UnityEngine.Rendering.Universal.OutPt DupOutPt(UnityEngine.Rendering.Universal.OutPt outPt, bool InsertAfter);
                /*0x1340ca0*/ bool GetOverlap(long a1, long a2, long b1, long b2, ref long Left, ref long Right);
                /*0x1343220*/ bool JoinHorz(UnityEngine.Rendering.Universal.OutPt op1, UnityEngine.Rendering.Universal.OutPt op1b, UnityEngine.Rendering.Universal.OutPt op2, UnityEngine.Rendering.Universal.OutPt op2b, UnityEngine.Rendering.Universal.IntPoint Pt, bool DiscardLeft);
                /*0x1343680*/ bool JoinPoints(UnityEngine.Rendering.Universal.Join j, UnityEngine.Rendering.Universal.OutRec outRec1, UnityEngine.Rendering.Universal.OutRec outRec2);
                /*0x133fa10*/ void FixupFirstLefts1(UnityEngine.Rendering.Universal.OutRec OldOutRec, UnityEngine.Rendering.Universal.OutRec NewOutRec);
                /*0x133fba0*/ void FixupFirstLefts2(UnityEngine.Rendering.Universal.OutRec innerOutRec, UnityEngine.Rendering.Universal.OutRec outerOutRec);
                /*0x133fda0*/ void FixupFirstLefts3(UnityEngine.Rendering.Universal.OutRec OldOutRec, UnityEngine.Rendering.Universal.OutRec NewOutRec);
                /*0x1342880*/ void JoinCommonEdges();
                /*0x1348a10*/ void UpdateOutPtIdxs(UnityEngine.Rendering.Universal.OutRec outrec);
                /*0x133e850*/ void DoSimplePolygons();
                /*0x133bd00*/ double Area(UnityEngine.Rendering.Universal.OutRec outRec);
                /*0x133bc90*/ double Area(UnityEngine.Rendering.Universal.OutPt op);

                enum NodeType
                {
                    ntAny = 0,
                    ntOpen = 1,
                    ntClosed = 2,
                }
            }

            class ClipperOffset
            {
                static double two_pi = 6.283185307179586;
                static double def_arc_tolerance = 0.25;
                /*0x10*/ System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> m_destPolys;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> m_srcPoly;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> m_destPoly;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DoublePoint> m_normals;
                /*0x30*/ double m_delta;
                /*0x38*/ double m_sinA;
                /*0x40*/ double m_sin;
                /*0x48*/ double m_cos;
                /*0x50*/ double m_StepsPerRad;
                /*0x58*/ UnityEngine.Rendering.Universal.IntPoint m_lowest;
                /*0x88*/ UnityEngine.Rendering.Universal.PolyNode m_polyNodes;
                /*0x90*/ double <ArcTolerance>k__BackingField;

                static /*0x1347ab0*/ long Round(double value);
                static /*0x1350ac0*/ UnityEngine.Rendering.Universal.DoublePoint GetUnitNormal(UnityEngine.Rendering.Universal.IntPoint pt1, UnityEngine.Rendering.Universal.IntPoint pt2);
                /*0x1351520*/ ClipperOffset(double arcTolerance);
                /*0x7379c0*/ double get_ArcTolerance();
                /*0x737ba0*/ void set_ArcTolerance(double value);
                /*0x134ddc0*/ void Clear();
                /*0x134d6f0*/ void AddPath(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path, UnityEngine.Rendering.Universal.JoinType joinType, UnityEngine.Rendering.Universal.EndType endType);
                /*0x134dc80*/ void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> paths, UnityEngine.Rendering.Universal.JoinType joinType, UnityEngine.Rendering.Universal.EndType endType);
                /*0x13508e0*/ void FixOrientations();
                /*0x134e170*/ void DoOffset(double delta);
                /*0x13503d0*/ void Execute(ref System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint>> solution, double delta, int inputSize);
                /*0x134fd50*/ void Execute(ref UnityEngine.Rendering.Universal.PolyTree solution, double delta);
                /*0x1350bd0*/ void OffsetPoint(int j, ref int k, UnityEngine.Rendering.Universal.JoinType jointype);
                /*0x134f690*/ void DoSquare(int j, int k);
                /*0x134de30*/ void DoMiter(int j, int k, double r);
                /*0x134f0c0*/ void DoRound(int j, int k);
            }

            class ClipperException : System.Exception
            {
                /*0x134d690*/ ClipperException(string description);
            }

            class Light2D : UnityEngine.U2D.Light2DBase, UnityEngine.ISerializationCallbackReceiver
            {
                static UnityEngine.Rendering.Universal.Light2D.ComponentVersions k_CurrentComponentVersion = 1;
                /*0x20*/ UnityEngine.Rendering.Universal.Light2D.ComponentVersions m_ComponentVersion;
                /*0x24*/ UnityEngine.Rendering.Universal.Light2D.LightType m_LightType;
                /*0x28*/ int m_BlendStyleIndex;
                /*0x2c*/ float m_FalloffIntensity;
                /*0x30*/ UnityEngine.Color m_Color;
                /*0x40*/ float m_Intensity;
                /*0x44*/ float m_LightVolumeIntensity;
                /*0x48*/ bool m_LightVolumeIntensityEnabled;
                /*0x50*/ int[] m_ApplyToSortingLayers;
                /*0x58*/ UnityEngine.Sprite m_LightCookieSprite;
                /*0x60*/ UnityEngine.Sprite m_DeprecatedPointLightCookieSprite;
                /*0x68*/ int m_LightOrder;
                /*0x6c*/ bool m_AlphaBlendOnOverlap;
                /*0x70*/ UnityEngine.Rendering.Universal.Light2D.OverlapOperation m_OverlapOperation;
                /*0x74*/ float m_NormalMapDistance;
                /*0x78*/ UnityEngine.Rendering.Universal.Light2D.NormalMapQuality m_NormalMapQuality;
                /*0x7c*/ bool m_UseNormalMap;
                /*0x7d*/ bool m_ShadowIntensityEnabled;
                /*0x80*/ float m_ShadowIntensity;
                /*0x84*/ bool m_ShadowVolumeIntensityEnabled;
                /*0x88*/ float m_ShadowVolumeIntensity;
                /*0x90*/ UnityEngine.Mesh m_Mesh;
                /*0x98*/ UnityEngine.Rendering.Universal.LightUtility.LightMeshVertex[] m_Vertices;
                /*0xa0*/ ushort[] m_Triangles;
                /*0xa8*/ int m_PreviousLightCookieSprite;
                /*0xac*/ UnityEngine.Vector3 m_CachedPosition;
                /*0xb8*/ UnityEngine.Bounds m_LocalBounds;
                /*0xd0*/ UnityEngine.BoundingSphere <boundingSphere>k__BackingField;
                /*0xe0*/ bool forceUpdate;
                /*0xe4*/ float m_PointLightInnerAngle;
                /*0xe8*/ float m_PointLightOuterAngle;
                /*0xec*/ float m_PointLightInnerRadius;
                /*0xf0*/ float m_PointLightOuterRadius;
                /*0xf4*/ int m_ShapeLightParametricSides;
                /*0xf8*/ float m_ShapeLightParametricAngleOffset;
                /*0xfc*/ float m_ShapeLightParametricRadius;
                /*0x100*/ float m_ShapeLightFalloffSize;
                /*0x104*/ UnityEngine.Vector2 m_ShapeLightFalloffOffset;
                /*0x110*/ UnityEngine.Vector3[] m_ShapePath;
                /*0x118*/ float m_PreviousShapeLightFalloffSize;
                /*0x11c*/ int m_PreviousShapeLightParametricSides;
                /*0x120*/ float m_PreviousShapeLightParametricAngleOffset;
                /*0x124*/ float m_PreviousShapeLightParametricRadius;
                /*0x128*/ int m_PreviousShapePathHash;
                /*0x12c*/ UnityEngine.Rendering.Universal.Light2D.LightType m_PreviousLightType;

                /*0x1355020*/ Light2D();
                /*0x9c7a50*/ UnityEngine.Rendering.Universal.LightUtility.LightMeshVertex[] get_vertices();
                /*0x9c7a70*/ void set_vertices(UnityEngine.Rendering.Universal.LightUtility.LightMeshVertex[] value);
                /*0xec32e0*/ ushort[] get_indices();
                /*0x13553e0*/ void set_indices(ushort[] value);
                /*0x4e40e0*/ int[] get_affectedSortingLayers();
                /*0x1355210*/ int get_lightCookieSpriteInstanceID();
                /*0x13551b0*/ UnityEngine.BoundingSphere get_boundingSphere();
                /*0x13553a0*/ void set_boundingSphere(UnityEngine.BoundingSphere value);
                /*0x1355240*/ UnityEngine.Mesh get_lightMesh();
                /*0x13551c0*/ bool get_hasCachedMesh();
                /*0x3e3ad0*/ UnityEngine.Rendering.Universal.Light2D.LightType get_lightType();
                /*0x1355410*/ void set_lightType(UnityEngine.Rendering.Universal.Light2D.LightType value);
                /*0x3e3ae0*/ int get_blendStyleIndex();
                /*0xc6dab0*/ void set_blendStyleIndex(int value);
                /*0x12fb1f0*/ float get_shadowIntensity();
                /*0x13554a0*/ void set_shadowIntensity(float value);
                /*0x1355340*/ bool get_shadowsEnabled();
                /*0x1355500*/ void set_shadowsEnabled(bool value);
                /*0x737b10*/ float get_shadowVolumeIntensity();
                /*0x13554d0*/ void set_shadowVolumeIntensity(float value);
                /*0x1355390*/ bool get_volumetricShadowsEnabled();
                /*0x1355550*/ void set_volumetricShadowsEnabled(bool value);
                /*0x10daa90*/ UnityEngine.Color get_color();
                /*0x12f4ba0*/ void set_color(UnityEngine.Color value);
                /*0xcf6cb0*/ float get_intensity();
                /*0xcf6d00*/ void set_intensity(float value);
                /*0x129f7a0*/ float get_volumeOpacity();
                /*0x129f7a0*/ float get_volumeIntensity();
                /*0x1355540*/ void set_volumeIntensity(float value);
                /*0xe85db0*/ bool get_volumeIntensityEnabled();
                /*0x10d9810*/ void set_volumeIntensityEnabled(bool value);
                /*0x1355230*/ UnityEngine.Sprite get_lightCookieSprite();
                /*0xb61a20*/ void set_lightCookieSprite(UnityEngine.Sprite value);
                /*0x4ccc40*/ float get_falloffIntensity();
                /*0x13553b0*/ void set_falloffIntensity(float value);
                /*0x13551a0*/ bool get_alphaBlendOnOverlap();
                /*0x1355300*/ UnityEngine.Rendering.Universal.Light2D.OverlapOperation get_overlapOperation();
                /*0x1355480*/ void set_overlapOperation(UnityEngine.Rendering.Universal.Light2D.OverlapOperation value);
                /*0x1101d30*/ int get_lightOrder();
                /*0x1355400*/ void set_lightOrder(int value);
                /*0x13552f0*/ float get_normalMapDistance();
                /*0x1101d10*/ UnityEngine.Rendering.Universal.Light2D.NormalMapQuality get_normalMapQuality();
                /*0x1355320*/ bool get_renderVolumetricShadows();
                /*0x13544c0*/ void MarkForUpdate();
                /*0x13542b0*/ void CacheValues();
                /*0x1354300*/ int GetTopMostLitLayer();
                /*0x1354ef0*/ UnityEngine.Bounds UpdateSpriteMesh();
                /*0x1354b50*/ void UpdateMesh(bool forceUpdate);
                /*0x13547b0*/ void UpdateBoundingSphere();
                /*0x1354430*/ bool IsLitLayer(int layer);
                /*0x13541c0*/ void Awake();
                /*0x1354630*/ void OnEnable();
                /*0x1354550*/ void OnDisable();
                /*0x1354480*/ void LateUpdate();
                /*0x1354540*/ void OnBeforeSerialize();
                /*0x13544d0*/ void OnAfterDeserialize();
                /*0x1355310*/ float get_pointLightInnerAngle();
                /*0x1355490*/ void set_pointLightInnerAngle(float value);
                /*0xbf2cd0*/ float get_pointLightOuterAngle();
                /*0xbf3120*/ void set_pointLightOuterAngle(float value);
                /*0xbf2d30*/ float get_pointLightInnerRadius();
                /*0xbf3150*/ void set_pointLightInnerRadius(float value);
                /*0xbf2ed0*/ float get_pointLightOuterRadius();
                /*0xbf3170*/ void set_pointLightOuterRadius(float value);
                /*0x13552f0*/ float get_pointLightDistance();
                /*0x1101d10*/ UnityEngine.Rendering.Universal.Light2D.NormalMapQuality get_pointLightQuality();
                /*0x1355200*/ bool get_isPointLight();
                /*0xbf2c80*/ int get_shapeLightParametricSides();
                /*0x1355360*/ float get_shapeLightParametricAngleOffset();
                /*0x1355370*/ float get_shapeLightParametricRadius();
                /*0x1355530*/ void set_shapeLightParametricRadius(float value);
                /*0x1355350*/ float get_shapeLightFalloffSize();
                /*0x1355510*/ void set_shapeLightFalloffSize(float value);
                /*0x1355380*/ UnityEngine.Vector3[] get_shapePath();
                /*0x1354790*/ void set_shapePath(UnityEngine.Vector3[] value);
                /*0x1354790*/ void SetShapePath(UnityEngine.Vector3[] path);

                enum DeprecatedLightType
                {
                    Parametric = 0,
                }

                enum LightType
                {
                    Parametric = 0,
                    Freeform = 1,
                    Sprite = 2,
                    Point = 3,
                    Global = 4,
                }

                enum NormalMapQuality
                {
                    Disabled = 2,
                    Fast = 0,
                    Accurate = 1,
                }

                enum OverlapOperation
                {
                    Additive = 0,
                    AlphaBlend = 1,
                }

                enum ComponentVersions
                {
                    Version_Unserialized = 0,
                    Version_1 = 1,
                }
            }

            struct Light2DBlendStyle
            {
                /*0x10*/ string name;
                /*0x18*/ UnityEngine.Rendering.Universal.Light2DBlendStyle.TextureChannel maskTextureChannel;
                /*0x1c*/ UnityEngine.Rendering.Universal.Light2DBlendStyle.BlendMode blendMode;
                /*0x20*/ bool <isDirty>k__BackingField;
                /*0x21*/ bool <hasRenderTarget>k__BackingField;
                /*0x24*/ int renderTargetHandleId;
                /*0x28*/ UnityEngine.Rendering.RTHandle renderTargetHandle;

                /*0x1352650*/ UnityEngine.Vector2 get_blendFactors();
                /*0x13526a0*/ UnityEngine.Rendering.Universal.Light2DBlendStyle.MaskChannelFilter get_maskTextureChannelFilter();
                /*0x793eb0*/ bool get_isDirty();
                /*0x793ec0*/ void set_isDirty(bool value);
                /*0xf26f80*/ bool get_hasRenderTarget();
                /*0xf26f90*/ void set_hasRenderTarget(bool value);

                enum TextureChannel
                {
                    None = 0,
                    R = 1,
                    G = 2,
                    B = 3,
                    A = 4,
                    OneMinusR = 5,
                    OneMinusG = 6,
                    OneMinusB = 7,
                    OneMinusA = 8,
                }

                struct MaskChannelFilter
                {
                    /*0x10*/ UnityEngine.Vector4 <mask>k__BackingField;
                    /*0x20*/ UnityEngine.Vector4 <inverted>k__BackingField;

                    /*0x99b640*/ MaskChannelFilter(UnityEngine.Vector4 m, UnityEngine.Vector4 i);
                    /*0x6bba70*/ UnityEngine.Vector4 get_mask();
                    /*0xdb4640*/ void set_mask(UnityEngine.Vector4 value);
                    /*0x8b2880*/ UnityEngine.Vector4 get_inverted();
                    /*0x9f0700*/ void set_inverted(UnityEngine.Vector4 value);
                }

                enum BlendMode
                {
                    Additive = 0,
                    Multiply = 1,
                    Subtractive = 2,
                }

                struct BlendFactors
                {
                    /*0x10*/ float multiplicative;
                    /*0x14*/ float additive;
                }
            }

            struct LightStats
            {
                /*0x10*/ int totalLights;
                /*0x14*/ int totalNormalMapUsage;
                /*0x18*/ int totalVolumetricUsage;
                /*0x1c*/ uint blendStylesUsed;
                /*0x20*/ uint blendStylesWithLights;

                /*0x13556a0*/ bool get_useNormalMap();
            }

            interface ILight2DCullResult
            {
                /*0x1803b0*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.Light2D> get_visibleLights();
                /*0x1803b0*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowCasterGroup2D> get_visibleShadows();
                UnityEngine.Rendering.Universal.LightStats GetLightStatsByLayer(int layer);
                /*0x17cb40*/ bool IsSceneLit();
            }

            class Light2DCullResult : UnityEngine.Rendering.Universal.ILight2DCullResult
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.Light2D> m_VisibleLights;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowCasterGroup2D> m_VisibleShadows;

                /*0x13533c0*/ Light2DCullResult();
                /*0x73d3e0*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.Light2D> get_visibleLights();
                /*0x32f410*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowCasterGroup2D> get_visibleShadows();
                /*0x1352a10*/ bool IsSceneLit();
                /*0x1352830*/ UnityEngine.Rendering.Universal.LightStats GetLightStatsByLayer(int layer);
                /*0x1352ab0*/ void SetupCulling(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, UnityEngine.Camera camera);

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.Light2DCullResult.<> <>9;
                    static /*0x8*/ System.Comparison<UnityEngine.Rendering.Universal.Light2D> <>9__8_0;

                    static /*0x1364a10*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x13649f0*/ int <SetupCulling>b__8_0(UnityEngine.Rendering.Universal.Light2D l1, UnityEngine.Rendering.Universal.Light2D l2);
                }
            }

            class Light2DManager
            {
                static /*0x0*/ UnityEngine.SortingLayer[] s_SortingLayers;
                static /*0x8*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.Light2D> <lights>k__BackingField;

                static /*0x13540e0*/ Light2DManager();
                static /*0x1354170*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.Light2D> get_lights();
                static /*0x32d010*/ void Initialize();
                static /*0x32d010*/ void Dispose();
                static /*0x1353fd0*/ void RegisterLight(UnityEngine.Rendering.Universal.Light2D light);
                static /*0x1353aa0*/ void DeregisterLight(UnityEngine.Rendering.Universal.Light2D light);
                static /*0x1353b50*/ void ErrorIfDuplicateGlobalLight(UnityEngine.Rendering.Universal.Light2D light);
                static /*0x1353da0*/ bool GetGlobalColor(int sortingLayerIndex, int blendStyleIndex, ref UnityEngine.Color color);
                static /*0x13538e0*/ bool ContainsDuplicateGlobalLight(int sortingLayerIndex, int blendStyleIndex);
                static /*0x1353cc0*/ UnityEngine.SortingLayer[] GetCachedSortingLayer();
            }

            class LightUtility
            {
                static /*0x13556b0*/ bool CheckForChange(UnityEngine.Rendering.Universal.Light2D.LightType a, ref UnityEngine.Rendering.Universal.Light2D.LightType b);
                static /*0x13556b0*/ bool CheckForChange(int a, ref int b);
                static /*0x13556d0*/ bool CheckForChange(float a, ref float b);
                static /*0x13556c0*/ bool CheckForChange(bool a, ref bool b);
                static /*0x1358410*/ bool TestPivot(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path, int activePoint, long lastPoint);
                static /*0x13556f0*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> DegeneratePivots(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> path, System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> inPath, ref int interiorStart);
                static /*0x13581f0*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> SortPivots(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> outPath, System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> inPath);
                static /*0x1355a90*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> FixPivots(System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> outPath, System.Collections.Generic.List<UnityEngine.Rendering.Universal.IntPoint> inPath, ref int interiorStart);
                static /*0x1357ce0*/ System.Collections.Generic.List<UnityEngine.Vector2> GetOutlinePath(UnityEngine.Vector3[] shapePath, float offsetDistance);
                static /*0x13584c0*/ void TransferToMesh(Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.LightUtility.LightMeshVertex> vertices, int vertexCount, Unity.Collections.NativeArray<ushort> indices, int indexCount, UnityEngine.Rendering.Universal.Light2D light);
                static /*0x1356710*/ UnityEngine.Bounds GenerateShapeMesh(UnityEngine.Rendering.Universal.Light2D light, UnityEngine.Vector3[] shapePath, float falloffDistance);
                static /*0x1355da0*/ UnityEngine.Bounds GenerateParametricMesh(UnityEngine.Rendering.Universal.Light2D light, float radius, float falloffDistance, float angle, int sides);
                static /*0x1357780*/ UnityEngine.Bounds GenerateSpriteMesh(UnityEngine.Rendering.Universal.Light2D light, UnityEngine.Sprite sprite);
                static /*0x1358120*/ int GetShapePathHash(UnityEngine.Vector3[] path);

                enum PivotType
                {
                    PivotBase = 0,
                    PivotCurve = 1,
                    PivotIntersect = 2,
                    PivotSkip = 3,
                    PivotClip = 4,
                }

                struct LightMeshVertex
                {
                    static /*0x0*/ UnityEngine.Rendering.VertexAttributeDescriptor[] VertexLayout;
                    /*0x10*/ UnityEngine.Vector3 position;
                    /*0x1c*/ UnityEngine.Color color;
                    /*0x2c*/ UnityEngine.Vector2 uv;

                    static /*0x1355560*/ LightMeshVertex();
                }
            }

            interface IRenderPass2D
            {
                /*0x1803b0*/ UnityEngine.Rendering.Universal.Renderer2DData get_rendererData();
            }

            class PixelPerfectBackgroundPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingScope;

                static /*0x1358880*/ PixelPerfectBackgroundPass();
                /*0x1358910*/ PixelPerfectBackgroundPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x13586f0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            class Render2DLightingPass : UnityEngine.Rendering.Universal.ScriptableRenderPass, UnityEngine.Rendering.Universal.IRenderPass2D
            {
                static /*0x0*/ int k_HDREmulationScaleID;
                static /*0x4*/ int k_InverseHDREmulationScaleID;
                static /*0x8*/ int k_UseSceneLightingID;
                static /*0xc*/ int k_RendererColorID;
                static /*0x10*/ int[] k_ShapeLightTextureIDs;
                static /*0x18*/ UnityEngine.Rendering.ShaderTagId k_CombinedRenderingPassName;
                static /*0x1c*/ UnityEngine.Rendering.ShaderTagId k_NormalsRenderingPassName;
                static /*0x20*/ UnityEngine.Rendering.ShaderTagId k_LegacyPassName;
                static /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> k_ShaderTags;
                static /*0x30*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingDrawLights;
                static /*0x38*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingDrawLightTextures;
                static /*0x40*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingDrawRenderers;
                static /*0x48*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingDrawLayerBatch;
                static /*0x50*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerUnlit;
                /*0xe0*/ UnityEngine.Material m_BlitMaterial;
                /*0xe8*/ UnityEngine.Material m_SamplingMaterial;
                /*0xf0*/ UnityEngine.Rendering.Universal.Renderer2DData m_Renderer2DData;
                /*0xf8*/ bool m_NeedsDepth;
                /*0xfa*/ short m_CameraSortingLayerBoundsIndex;

                static /*0x135cba0*/ Render2DLightingPass();
                static /*0x135c7a0*/ short GetCameraSortingLayerBoundsIndex(UnityEngine.Rendering.Universal.Renderer2DData rendererData);
                /*0x135d130*/ Render2DLightingPass(UnityEngine.Rendering.Universal.Renderer2DData rendererData, UnityEngine.Material blitMaterial, UnityEngine.Material samplingMaterial);
                /*0x135cb90*/ void Setup(bool useDepth);
                /*0x135c880*/ void GetTransparencySortingMode(UnityEngine.Camera camera, ref UnityEngine.Rendering.SortingSettings sortingSettings);
                /*0x1359390*/ void CopyCameraSortingLayerRenderTexture(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.RenderBufferStoreAction mainTargetStoreAction);
                /*0x1359880*/ void DetermineWhenToResolve(int startIndex, int batchesDrawn, int batchCount, UnityEngine.Rendering.Universal.LayerBatch[] layerBatches, ref int resolveDuringBatch, ref bool resolveIsAfterCopy);
                /*0x135c940*/ void Render(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.FilteringSettings filterSettings, UnityEngine.Rendering.DrawingSettings drawSettings);
                /*0x1359b50*/ int DrawLayerBatches(UnityEngine.Rendering.Universal.LayerBatch[] layerBatches, int batchCount, int startIndex, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.DrawingSettings normalsDrawSettings, ref UnityEngine.Rendering.DrawingSettings drawSettings, ref UnityEngine.RenderTextureDescriptor desc);
                /*0x135b0a0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x10d0110*/ UnityEngine.Rendering.Universal.Renderer2DData UnityEngine.Rendering.Universal.IRenderPass2D.get_rendererData();

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.Render2DLightingPass.<> <>9;
                    static /*0x8*/ UnityEngine.Rendering.Universal.DebugHandler.DrawFunction <>9__25_0;

                    static /*0x1364a80*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x1364950*/ void <Render>b__25_0(UnityEngine.Rendering.ScriptableRenderContext ctx, ref UnityEngine.Rendering.Universal.RenderingData data, ref UnityEngine.Rendering.DrawingSettings ds, ref UnityEngine.Rendering.FilteringSettings fs, ref UnityEngine.Rendering.RenderStateBlock rsb);
                }
            }

            class UpscalePass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingScope;
                static /*0x8*/ UnityEngine.Material m_BlitMaterial;
                /*0xe0*/ UnityEngine.Rendering.RTHandle m_Source;
                /*0xe8*/ UnityEngine.Rendering.RTHandle m_UpscaleHandle;

                static /*0x1364e40*/ UpscalePass();
                /*0x1364ed0*/ UpscalePass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material blitMaterial);
                /*0x1364cd0*/ void Setup(UnityEngine.Rendering.RTHandle colorTargetHandle, int width, int height, UnityEngine.FilterMode mode, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.RTHandle upscaleHandle);
                /*0x1364af0*/ void Dispose();
                /*0x1364b10*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            struct LayerBatch
            {
                /*0x10*/ int startLayerID;
                /*0x14*/ int endLayerValue;
                /*0x18*/ UnityEngine.Rendering.SortingLayerRange layerRange;
                /*0x1c*/ UnityEngine.Rendering.Universal.LightStats lightStats;
                /*0x30*/ bool useNormals;
                /*0x34*/ UnityEngine.Rendering.Universal.LayerBatch.<renderTargetIds> renderTargetIds;
                /*0x44*/ UnityEngine.Rendering.Universal.LayerBatch.<renderTargetUsed> renderTargetUsed;

                /*0x13516a0*/ void InitRTIds(int index);
                /*0x13515f0*/ UnityEngine.Rendering.RenderTargetIdentifier GetRTId(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor desc, int index);
                /*0x1351770*/ void ReleaseRT(UnityEngine.Rendering.CommandBuffer cmd);

                struct <renderTargetIds>e__FixedBuffer
                {
                    /*0x10*/ int FixedElementField;
                }

                struct <renderTargetUsed>e__FixedBuffer
                {
                    /*0x10*/ bool FixedElementField;
                }
            }

            class LayerUtility
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.LayerBatch[] s_LayerBatches;
                static /*0x8*/ uint <maxTextureCount>k__BackingField;

                static /*0x13525d0*/ uint get_maxTextureCount();
                static /*0x1352610*/ void set_maxTextureCount(uint value);
                static /*0x1352580*/ void InitializeBudget(uint maxTextureCount);
                static /*0x1351d40*/ bool CanBatchLightsInLayer(int layerIndex1, int layerIndex2, UnityEngine.SortingLayer[] sortingLayers, UnityEngine.Rendering.Universal.ILight2DCullResult lightCullResult);
                static /*0x1351c90*/ bool CanBatchCameraSortingLayer(int startLayerIndex, UnityEngine.SortingLayer[] sortingLayers, UnityEngine.Rendering.Universal.Renderer2DData rendererData);
                static /*0x13522a0*/ int FindUpperBoundInBatch(int startLayerIndex, UnityEngine.SortingLayer[] sortingLayers, UnityEngine.Rendering.Universal.Renderer2DData rendererData);
                static /*0x1352480*/ void InitializeBatchInfos(UnityEngine.SortingLayer[] cachedSortingLayers);
                static /*0x13517f0*/ UnityEngine.Rendering.Universal.LayerBatch[] CalculateBatches(UnityEngine.Rendering.Universal.Renderer2DData rendererData, ref int batchCount);
                static /*0x13523b0*/ void GetFilterSettings(UnityEngine.Rendering.Universal.Renderer2DData rendererData, ref UnityEngine.Rendering.Universal.LayerBatch layerBatch, ref UnityEngine.Rendering.FilteringSettings filterSettings);
            }

            class Light2DLookupTexture
            {
                static /*0x0*/ UnityEngine.Texture2D s_PointLightLookupTexture;

                static /*0x1353830*/ UnityEngine.Texture GetLightLookupTexture();
                static /*0x1353480*/ UnityEngine.Texture2D CreatePointLightLookupTexture();
            }

            class RendererLighting
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                static /*0x8*/ UnityEngine.Rendering.ShaderTagId k_NormalsRenderingPassName;
                static /*0xc*/ UnityEngine.Color k_NormalClearColor;
                static /*0x20*/ string k_SpriteLightKeyword;
                static /*0x28*/ string k_UsePointLightCookiesKeyword;
                static /*0x30*/ string k_LightQualityFastKeyword;
                static /*0x38*/ string k_UseNormalMap;
                static /*0x40*/ string k_UseAdditiveBlendingKeyword;
                static /*0x48*/ string[] k_UseBlendStyleKeywords;
                static /*0x50*/ int[] k_BlendFactorsPropIDs;
                static /*0x58*/ int[] k_MaskFilterPropIDs;
                static /*0x60*/ int[] k_InvertedFilterPropIDs;
                static /*0x68*/ UnityEngine.Experimental.Rendering.GraphicsFormat s_RenderTextureFormatToUse;
                static /*0x6c*/ bool s_HasSetupRenderTextureFormatToUse;
                static /*0x70*/ int k_SrcBlendID;
                static /*0x74*/ int k_DstBlendID;
                static /*0x78*/ int k_FalloffIntensityID;
                static /*0x7c*/ int k_FalloffDistanceID;
                static /*0x80*/ int k_LightColorID;
                static /*0x84*/ int k_VolumeOpacityID;
                static /*0x88*/ int k_CookieTexID;
                static /*0x8c*/ int k_FalloffLookupID;
                static /*0x90*/ int k_LightPositionID;
                static /*0x94*/ int k_LightInvMatrixID;
                static /*0x98*/ int k_InnerRadiusMultID;
                static /*0x9c*/ int k_OuterAngleID;
                static /*0xa0*/ int k_InnerAngleMultID;
                static /*0xa4*/ int k_LightLookupID;
                static /*0xa8*/ int k_IsFullSpotlightID;
                static /*0xac*/ int k_LightZDistanceID;
                static /*0xb0*/ int k_PointLightCookieTexID;

                static /*0x1364040*/ RendererLighting();
                static /*0x1361130*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetRenderTextureFormat();
                static /*0x1360680*/ void CreateNormalMapRenderTexture(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmd, float renderScale);
                static /*0x1360bf0*/ UnityEngine.RenderTextureDescriptor GetBlendStyleRenderTextureDesc(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x13600e0*/ void CreateCameraSortingLayerRenderTexture(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.Downsampling downsamplingMethod);
                static /*0x1360b30*/ void EnableBlendStyle(UnityEngine.Rendering.CommandBuffer cmd, int blendStyleIndex, bool enabled);
                static /*0x1360900*/ void DisableAllKeywords(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.CommandBuffer cmd);
                static /*0x1361420*/ void ReleaseRenderTextures(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.CommandBuffer cmd);
                static /*0x13609c0*/ void DrawPointLight(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.Light2D light, UnityEngine.Mesh lightMesh, UnityEngine.Material material);
                static /*0x135fda0*/ bool CanCastShadows(UnityEngine.Rendering.Universal.Light2D light, int layerToRender);
                static /*0x135fe20*/ bool CanCastVolumetricShadows(UnityEngine.Rendering.Universal.Light2D light, int endLayerValue);
                static /*0x1363fa0*/ bool ShouldRenderLight(UnityEngine.Rendering.Universal.Light2D light, int blendStyleIndex, int layerToRender);
                static /*0x1361530*/ void RenderLightSet(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, int blendStyleIndex, UnityEngine.Rendering.CommandBuffer cmd, int layerToRender, UnityEngine.Rendering.RenderTargetIdentifier renderTexture, System.Collections.Generic.List<UnityEngine.Rendering.Universal.Light2D> lights);
                static /*0x1361e10*/ void RenderLightVolumes(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmd, int layerToRender, int endLayerValue, UnityEngine.Rendering.RenderTargetIdentifier renderTexture, UnityEngine.Rendering.RenderTargetIdentifier depthTexture, UnityEngine.Rendering.RenderBufferStoreAction intermediateStoreAction, UnityEngine.Rendering.RenderBufferStoreAction finalStoreAction, bool requiresRTInit, System.Collections.Generic.List<UnityEngine.Rendering.Universal.Light2D> lights);
                static /*0x1363c10*/ void SetShapeLightShaderGlobals(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.CommandBuffer cmd);
                static /*0x1361100*/ float GetNormalizedInnerRadius(UnityEngine.Rendering.Universal.Light2D light);
                static /*0x13610f0*/ float GetNormalizedAngle(float angle);
                static /*0x1361270*/ void GetScaledLightInvMatrix(UnityEngine.Rendering.Universal.Light2D light, ref UnityEngine.Matrix4x4 retMatrix);
                static /*0x13633a0*/ void SetGeneralLightShaderGlobals(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.Light2D light);
                static /*0x1363530*/ void SetPointLightShaderGlobals(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.Light2D light);
                static /*0x135fe80*/ void ClearDirtyLighting(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.CommandBuffer cmd, uint blendStylesUsed);
                static /*0x1362bd0*/ void RenderNormals(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.DrawingSettings drawSettings, UnityEngine.Rendering.FilteringSettings filterSettings, UnityEngine.Rendering.RenderTargetIdentifier depthTarget, bool bFirstClear);
                static /*0x13626a0*/ void RenderLights(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmd, int layerToRender, ref UnityEngine.Rendering.Universal.LayerBatch layerBatch, ref UnityEngine.RenderTextureDescriptor rtDesc);
                static /*0x13632f0*/ void SetBlendModes(UnityEngine.Material material, UnityEngine.Rendering.BlendMode src, UnityEngine.Rendering.BlendMode dst);
                static /*0x1360d40*/ uint GetLightMaterialIndex(UnityEngine.Rendering.Universal.Light2D light, bool isVolume);
                static /*0x1360290*/ UnityEngine.Material CreateLightMaterial(UnityEngine.Rendering.Universal.Renderer2DData rendererData, UnityEngine.Rendering.Universal.Light2D light, bool isVolume);
                static /*0x1360eb0*/ UnityEngine.Material GetLightMaterial(UnityEngine.Rendering.Universal.Renderer2DData rendererData, UnityEngine.Rendering.Universal.Light2D light, bool isVolume);
            }

            interface IPixelPerfectCamera
            {
                /*0x180980*/ int get_assetsPPU();
                /*0x17aa40*/ void set_assetsPPU(int value);
                /*0x180980*/ int get_refResolutionX();
                /*0x17aa40*/ void set_refResolutionX(int value);
                /*0x180980*/ int get_refResolutionY();
                /*0x17aa40*/ void set_refResolutionY(int value);
                /*0x17cb40*/ bool get_upscaleRT();
                /*0x181190*/ void set_upscaleRT(bool value);
                /*0x17cb40*/ bool get_pixelSnapping();
                /*0x181190*/ void set_pixelSnapping(bool value);
                /*0x17cb40*/ bool get_cropFrameX();
                /*0x181190*/ void set_cropFrameX(bool value);
                /*0x17cb40*/ bool get_cropFrameY();
                /*0x181190*/ void set_cropFrameY(bool value);
                /*0x17cb40*/ bool get_stretchFill();
                /*0x181190*/ void set_stretchFill(bool value);
            }

            class PixelPerfectCameraInternal : UnityEngine.ISerializationCallbackReceiver
            {
                /*0x10*/ UnityEngine.Rendering.Universal.IPixelPerfectCamera m_Component;
                /*0x18*/ UnityEngine.Experimental.Rendering.Universal.PixelPerfectCamera m_SerializableComponent;
                /*0x20*/ float originalOrthoSize;
                /*0x24*/ bool hasPostProcessLayer;
                /*0x25*/ bool cropFrameXAndY;
                /*0x26*/ bool cropFrameXOrY;
                /*0x27*/ bool useStretchFill;
                /*0x28*/ int zoom;
                /*0x2c*/ bool useOffscreenRT;
                /*0x30*/ int offscreenRTWidth;
                /*0x34*/ int offscreenRTHeight;
                /*0x38*/ UnityEngine.Rect pixelRect;
                /*0x48*/ float orthoSize;
                /*0x4c*/ float unitsPerPixel;
                /*0x50*/ int cinemachineVCamZoom;
                /*0x54*/ bool requiresUpscaling;

                /*0x1359330*/ PixelPerfectCameraInternal(UnityEngine.Rendering.Universal.IPixelPerfectCamera component);
                /*0x1359260*/ void OnBeforeSerialize();
                /*0x13591f0*/ void OnAfterDeserialize();
                /*0x1358970*/ void CalculateCameraProperties(int screenWidth, int screenHeight);
                /*0x1358e20*/ UnityEngine.Rect CalculateFinalBlitPixelRect(int screenWidth, int screenHeight);
                /*0x1359070*/ float CorrectCinemachineOrthoSize(float targetOrthoSize);
            }

            class Renderer2D : UnityEngine.Rendering.Universal.ScriptableRenderer
            {
                static int k_DepthBufferBits = 32;
                static int k_FinalBlitPassQueueOffset = 1;
                static int k_AfterFinalBlitPassQueueOffset = 2;
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0x1a8*/ UnityEngine.Rendering.Universal.Render2DLightingPass m_Render2DLightingPass;
                /*0x1b0*/ UnityEngine.Rendering.Universal.PixelPerfectBackgroundPass m_PixelPerfectBackgroundPass;
                /*0x1b8*/ UnityEngine.Rendering.Universal.UpscalePass m_UpscalePass;
                /*0x1c0*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass m_FinalBlitPass;
                /*0x1c8*/ UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass m_DrawOffscreenUIPass;
                /*0x1d0*/ UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass m_DrawOverlayUIPass;
                /*0x1d8*/ UnityEngine.Rendering.Universal.Light2DCullResult m_LightCullResult;
                /*0x1e0*/ UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem m_ColorBufferSystem;
                /*0x1e8*/ bool m_UseDepthStencilBuffer;
                /*0x1e9*/ bool m_CreateColorTexture;
                /*0x1ea*/ bool m_CreateDepthTexture;
                /*0x1f0*/ UnityEngine.Rendering.RTHandle m_ColorTextureHandle;
                /*0x1f8*/ UnityEngine.Rendering.RTHandle m_DepthTextureHandle;
                /*0x200*/ UnityEngine.Material m_BlitMaterial;
                /*0x208*/ UnityEngine.Material m_BlitHDRMaterial;
                /*0x210*/ UnityEngine.Material m_SamplingMaterial;
                /*0x218*/ UnityEngine.Rendering.Universal.Renderer2DData m_Renderer2DData;
                /*0x220*/ UnityEngine.Rendering.Universal.PostProcessPasses m_PostProcessPasses;

                static /*0x135f360*/ Renderer2D();
                /*0x135f3f0*/ Renderer2D(UnityEngine.Rendering.Universal.Renderer2DData data);
                /*0x135fd60*/ bool get_createColorTexture();
                /*0x135fd70*/ bool get_createDepthTexture();
                /*0x135fd50*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass get_colorGradingLutPass();
                /*0x135fd90*/ UnityEngine.Rendering.Universal.PostProcessPass get_postProcessPass();
                /*0x135fd80*/ UnityEngine.Rendering.Universal.PostProcessPass get_finalPostProcessPass();
                /*0x135fd30*/ UnityEngine.Rendering.RTHandle get_afterPostProcessColorHandle();
                /*0x135fd40*/ UnityEngine.Rendering.RTHandle get_colorGradingLutHandle();
                /*0x408450*/ int SupportedCameraStackingTypes();
                /*0x135d8c0*/ void Dispose(bool disposing);
                /*0x135dd30*/ void ReleaseRenderTargets();
                /*0x135dd20*/ UnityEngine.Rendering.Universal.Renderer2DData GetRenderer2DData();
                /*0x135daf0*/ UnityEngine.Rendering.Universal.Renderer2D.RenderPassInputSummary GetRenderPassInputs(ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x135d2c0*/ void CreateRenderTextures(ref UnityEngine.Rendering.Universal.Renderer2D.RenderPassInputSummary renderPassInputs, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData, bool forceCreateColorTexture, UnityEngine.FilterMode colorTextureFilterMode, ref UnityEngine.Rendering.RTHandle colorTargetHandle, ref UnityEngine.Rendering.RTHandle depthTargetHandle);
                /*0x135de30*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x135dd70*/ void SetupCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x135f140*/ void SwapColorBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x135dac0*/ UnityEngine.Rendering.RTHandle GetCameraColorFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x135da90*/ UnityEngine.Rendering.RTHandle GetCameraColorBackBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x135da60*/ void EnableSwapBufferMSAA(bool enable);

                struct RenderPassInputSummary
                {
                    /*0x10*/ bool requiresDepthTexture;
                    /*0x11*/ bool requiresColorTexture;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.Renderer2D.<> <>9;
                    static /*0x8*/ System.Predicate<UnityEngine.Rendering.Universal.ScriptableRenderPass> <>9__44_1;
                    static /*0x10*/ System.Predicate<UnityEngine.Rendering.Universal.ScriptableRenderPass> <>9__44_0;

                    static /*0x137b520*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x1379400*/ bool <Setup>b__44_1(UnityEngine.Rendering.Universal.ScriptableRenderPass x);
                    /*0x13793e0*/ bool <Setup>b__44_0(UnityEngine.Rendering.Universal.ScriptableRenderPass x);
                }
            }

            class Renderer2DData : UnityEngine.Rendering.Universal.ScriptableRendererData
            {
                /*0x40*/ UnityEngine.LayerMask m_LayerMask;
                /*0x44*/ UnityEngine.TransparencySortMode m_TransparencySortMode;
                /*0x48*/ UnityEngine.Vector3 m_TransparencySortAxis;
                /*0x54*/ float m_HDREmulationScale;
                /*0x58*/ float m_LightRenderTextureScale;
                /*0x60*/ UnityEngine.Rendering.Universal.Light2DBlendStyle[] m_LightBlendStyles;
                /*0x68*/ bool m_UseDepthStencilBuffer;
                /*0x69*/ bool m_UseCameraSortingLayersTexture;
                /*0x6c*/ int m_CameraSortingLayersTextureBound;
                /*0x70*/ UnityEngine.Rendering.Universal.Downsampling m_CameraSortingLayerDownsamplingMethod;
                /*0x74*/ uint m_MaxLightRenderTextureCount;
                /*0x78*/ uint m_MaxShadowRenderTextureCount;
                /*0x80*/ UnityEngine.Shader m_ShapeLightShader;
                /*0x88*/ UnityEngine.Shader m_ShapeLightVolumeShader;
                /*0x90*/ UnityEngine.Shader m_PointLightShader;
                /*0x98*/ UnityEngine.Shader m_PointLightVolumeShader;
                /*0xa0*/ UnityEngine.Shader m_CoreBlitShader;
                /*0xa8*/ UnityEngine.Shader m_BlitHDROverlay;
                /*0xb0*/ UnityEngine.Shader m_CoreBlitColorAndDepthPS;
                /*0xb8*/ UnityEngine.Shader m_SamplingShader;
                /*0xc0*/ UnityEngine.Shader m_ProjectedShadowShader;
                /*0xc8*/ UnityEngine.Shader m_SpriteShadowShader;
                /*0xd0*/ UnityEngine.Shader m_SpriteUnshadowShader;
                /*0xd8*/ UnityEngine.Shader m_GeometryUnshadowShader;
                /*0xe0*/ UnityEngine.Shader m_FallbackErrorShader;
                /*0xe8*/ UnityEngine.Rendering.Universal.PostProcessData m_PostProcessData;
                /*0xf0*/ UnityEngine.Texture2D m_FallOffLookup;
                /*0xf8*/ System.Collections.Generic.Dictionary<uint, UnityEngine.Material> <lightMaterials>k__BackingField;
                /*0x100*/ UnityEngine.Material[] <spriteSelfShadowMaterial>k__BackingField;
                /*0x108*/ UnityEngine.Material[] <spriteUnshadowMaterial>k__BackingField;
                /*0x110*/ UnityEngine.Material[] <geometryUnshadowMaterial>k__BackingField;
                /*0x118*/ UnityEngine.Material[] <projectedShadowMaterial>k__BackingField;
                /*0x120*/ UnityEngine.Material[] <stencilOnlyShadowMaterial>k__BackingField;
                /*0x128*/ bool <isNormalsRenderTargetValid>k__BackingField;
                /*0x12c*/ float <normalsRenderTargetScale>k__BackingField;
                /*0x130*/ UnityEngine.Rendering.RTHandle normalsRenderTarget;
                /*0x138*/ int normalsRenderTargetId;
                /*0x140*/ UnityEngine.Rendering.RTHandle shadowsRenderTarget;
                /*0x148*/ int shadowsRenderTargetId;
                /*0x150*/ UnityEngine.Rendering.RTHandle cameraSortingLayerRenderTarget;
                /*0x158*/ int cameraSortingLayerRenderTargetId;
                /*0x160*/ UnityEngine.Rendering.Universal.ILight2DCullResult <lightCullResult>k__BackingField;

                /*0x136fb00*/ Renderer2DData();
                /*0x136fc20*/ float get_hdrEmulationScale();
                /*0x136fc70*/ float get_lightRenderTextureScale();
                /*0xe643b0*/ UnityEngine.Rendering.Universal.Light2DBlendStyle[] get_lightBlendStyles();
                /*0xe7e580*/ bool get_useDepthStencilBuffer();
                /*0x10d0110*/ UnityEngine.Texture2D get_fallOffLookup();
                /*0xeeac90*/ UnityEngine.Shader get_shapeLightShader();
                /*0x7379f0*/ UnityEngine.Shader get_shapeLightVolumeShader();
                /*0x7378b0*/ UnityEngine.Shader get_pointLightShader();
                /*0x9c7a50*/ UnityEngine.Shader get_pointLightVolumeShader();
                /*0xec32e0*/ UnityEngine.Shader get_blitShader();
                /*0xbf2ca0*/ UnityEngine.Shader get_blitHDROverlay();
                /*0xec32e0*/ UnityEngine.Shader get_coreBlitPS();
                /*0x136fc00*/ UnityEngine.Shader get_coreBlitColorAndDepthPS();
                /*0xb69980*/ UnityEngine.Shader get_samplingShader();
                /*0x10d00b0*/ UnityEngine.Rendering.Universal.PostProcessData get_postProcessData();
                /*0x136fd30*/ void set_postProcessData(UnityEngine.Rendering.Universal.PostProcessData value);
                /*0x136fca0*/ UnityEngine.Shader get_spriteShadowShader();
                /*0x136fcc0*/ UnityEngine.Shader get_spriteUnshadowShader();
                /*0x136fc10*/ UnityEngine.Shader get_geometryUnshadowShader();
                /*0xefdcf0*/ UnityEngine.Shader get_projectedShadowShader();
                /*0x10eed50*/ UnityEngine.TransparencySortMode get_transparencySortMode();
                /*0x136fcd0*/ UnityEngine.Vector3 get_transparencySortAxis();
                /*0x136fc60*/ uint get_lightRenderTextureMemoryBudget();
                /*0x1101d10*/ uint get_shadowRenderTextureMemoryBudget();
                /*0x10b58f0*/ bool get_useCameraSortingLayerTexture();
                /*0x136fbf0*/ int get_cameraSortingLayerTextureBound();
                /*0x1355300*/ UnityEngine.Rendering.Universal.Downsampling get_cameraSortingLayerDownsamplingMethod();
                /*0xbe6be0*/ UnityEngine.LayerMask get_layerMask();
                /*0x136f4d0*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x136f530*/ void Dispose();
                /*0x136f720*/ void OnEnable();
                /*0x136fc50*/ System.Collections.Generic.Dictionary<uint, UnityEngine.Material> get_lightMaterials();
                /*0x136fc90*/ UnityEngine.Material[] get_spriteSelfShadowMaterial();
                /*0x136fd50*/ void set_spriteSelfShadowMaterial(UnityEngine.Material[] value);
                /*0x136fcb0*/ UnityEngine.Material[] get_spriteUnshadowMaterial();
                /*0x136fd70*/ void set_spriteUnshadowMaterial(UnityEngine.Material[] value);
                /*0x1355380*/ UnityEngine.Material[] get_geometryUnshadowMaterial();
                /*0x1354790*/ void set_geometryUnshadowMaterial(UnityEngine.Material[] value);
                /*0x134cc10*/ UnityEngine.Material[] get_projectedShadowMaterial();
                /*0x134cc40*/ void set_projectedShadowMaterial(UnityEngine.Material[] value);
                /*0x10f4ac0*/ UnityEngine.Material[] get_stencilOnlyShadowMaterial();
                /*0x136fd90*/ void set_stencilOnlyShadowMaterial(UnityEngine.Material[] value);
                /*0x136fc30*/ bool get_isNormalsRenderTargetValid();
                /*0x136fcf0*/ void set_isNormalsRenderTargetValid(bool value);
                /*0x136fc80*/ float get_normalsRenderTargetScale();
                /*0x136fd20*/ void set_normalsRenderTargetScale(float value);
                /*0x136fc40*/ UnityEngine.Rendering.Universal.ILight2DCullResult get_lightCullResult();
                /*0x136fd00*/ void set_lightCullResult(UnityEngine.Rendering.Universal.ILight2DCullResult value);

                enum Renderer2DDefaultMaterialType
                {
                    Lit = 0,
                    Unlit = 1,
                    Custom = 2,
                }
            }

            class CompositeShadowCaster2D : UnityEngine.Rendering.Universal.ShadowCasterGroup2D
            {
                /*0x31c640*/ CompositeShadowCaster2D();
                /*0x1368220*/ void OnEnable();
                /*0x1368210*/ void OnDisable();
            }

            class ShadowCaster2D : UnityEngine.Rendering.Universal.ShadowCasterGroup2D, UnityEngine.ISerializationCallbackReceiver
            {
                static UnityEngine.Rendering.Universal.ShadowCaster2D.ComponentVersions k_CurrentComponentVersion = 1;
                /*0x30*/ UnityEngine.Rendering.Universal.ShadowCaster2D.ComponentVersions m_ComponentVersion;
                /*0x34*/ bool m_HasRenderer;
                /*0x35*/ bool m_UseRendererSilhouette;
                /*0x36*/ bool m_CastsShadows;
                /*0x37*/ bool m_SelfShadows;
                /*0x38*/ int[] m_ApplyToSortingLayers;
                /*0x40*/ UnityEngine.Vector3[] m_ShapePath;
                /*0x48*/ int m_ShapePathHash;
                /*0x50*/ UnityEngine.Mesh m_Mesh;
                /*0x58*/ int m_InstanceId;
                /*0x60*/ UnityEngine.Rendering.Universal.ShadowCasterGroup2D m_ShadowCasterGroup;
                /*0x68*/ UnityEngine.Rendering.Universal.ShadowCasterGroup2D m_PreviousShadowCasterGroup;
                /*0x70*/ UnityEngine.Bounds m_LocalBounds;
                /*0x88*/ UnityEngine.BoundingSphere m_BoundingSphere;
                /*0x98*/ int m_PreviousShadowGroup;
                /*0x9c*/ bool m_PreviousCastsShadows;
                /*0xa0*/ int m_PreviousPathHash;
                /*0xa4*/ UnityEngine.Vector3 m_CachedPosition;
                /*0xb0*/ UnityEngine.Vector3 m_CachedLossyScale;
                /*0xbc*/ UnityEngine.Quaternion m_CachedRotation;
                /*0xcc*/ UnityEngine.Matrix4x4 m_CachedShadowMatrix;
                /*0x10c*/ UnityEngine.Matrix4x4 m_CachedInverseShadowMatrix;
                /*0x14c*/ UnityEngine.Matrix4x4 m_CachedLocalToWorldMatrix;

                static /*0x13724a0*/ int[] SetDefaultSortingLayers();
                /*0x13729e0*/ ShadowCaster2D();
                /*0x4e40e0*/ UnityEngine.Mesh get_mesh();
                /*0xb61870*/ UnityEngine.Vector3[] get_shapePath();
                /*0x12f47d0*/ int get_shapePathHash();
                /*0x136a110*/ void set_shapePathHash(int value);
                /*0x1372030*/ void CacheValues();
                /*0x136a370*/ void set_useRendererSilhouette(bool value);
                /*0x1372a20*/ bool get_useRendererSilhouette();
                /*0x1372a40*/ void set_selfShadows(bool value);
                /*0x1372a10*/ bool get_selfShadows();
                /*0x1372a30*/ void set_castsShadows(bool value);
                /*0x1372a00*/ bool get_castsShadows();
                /*0x1372250*/ bool IsLit(UnityEngine.Rendering.Universal.Light2D light);
                /*0x13722d0*/ bool IsShadowedLayer(int layer);
                /*0x1371a00*/ void Awake();
                /*0x13723b0*/ void OnEnable();
                /*0x13723a0*/ void OnDisable();
                /*0x1372800*/ void Update();
                /*0x1372390*/ void OnBeforeSerialize();
                /*0x1372340*/ void OnAfterDeserialize();
                /*0x1372580*/ void UpdateBoundingSphere();

                enum ComponentVersions
                {
                    Version_Unserialized = 0,
                    Version_1 = 1,
                }
            }

            class ShadowCasterGroup2D : UnityEngine.MonoBehaviour
            {
                /*0x20*/ int m_ShadowGroup;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowCaster2D> m_ShadowCasters;

                /*0x31c640*/ ShadowCasterGroup2D();
                /*0x13733c0*/ void CacheValues();
                /*0x79a150*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowCaster2D> GetShadowCasters();
                /*0x3e3af0*/ int GetShadowGroup();
                /*0x1373460*/ void RegisterShadowCaster2D(UnityEngine.Rendering.Universal.ShadowCaster2D shadowCaster2D);
                /*0x1373560*/ void UnregisterShadowCaster2D(UnityEngine.Rendering.Universal.ShadowCaster2D shadowCaster2D);
            }

            class ShadowCasterGroup2DManager
            {
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowCasterGroup2D> s_ShadowCasterGroups;

                static /*0x1373380*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowCasterGroup2D> get_shadowCasterGroups();
                static /*0x1372f60*/ void CacheValues();
                static /*0x1372be0*/ void AddShadowCasterGroupToList(UnityEngine.Rendering.Universal.ShadowCasterGroup2D shadowCaster, System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowCasterGroup2D> list);
                static /*0x1373320*/ void RemoveShadowCasterGroupFromList(UnityEngine.Rendering.Universal.ShadowCasterGroup2D shadowCaster, System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowCasterGroup2D> list);
                static /*0x13730e0*/ UnityEngine.Rendering.Universal.CompositeShadowCaster2D FindTopMostCompositeShadowCaster(UnityEngine.Rendering.Universal.ShadowCaster2D shadowCaster);
                static /*0x1372ca0*/ bool AddToShadowCasterGroup(UnityEngine.Rendering.Universal.ShadowCaster2D shadowCaster, ref UnityEngine.Rendering.Universal.ShadowCasterGroup2D shadowCasterGroup);
                static /*0x13731a0*/ void RemoveFromShadowCasterGroup(UnityEngine.Rendering.Universal.ShadowCaster2D shadowCaster, UnityEngine.Rendering.Universal.ShadowCasterGroup2D shadowCasterGroup);
                static /*0x1372a50*/ void AddGroup(UnityEngine.Rendering.Universal.ShadowCasterGroup2D group);
                static /*0x1373270*/ void RemoveGroup(UnityEngine.Rendering.Universal.ShadowCasterGroup2D group);
                /*0x32f970*/ ShadowCasterGroup2DManager();
            }

            class ShadowRendering
            {
                static /*0x0*/ int k_LightPosID;
                static /*0x4*/ int k_SelfShadowingID;
                static /*0x8*/ int k_ShadowStencilGroupID;
                static /*0xc*/ int k_ShadowIntensityID;
                static /*0x10*/ int k_ShadowVolumeIntensityID;
                static /*0x14*/ int k_ShadowRadiusID;
                static /*0x18*/ int k_ShadowColorMaskID;
                static /*0x1c*/ int k_ShadowModelMatrixID;
                static /*0x20*/ int k_ShadowModelInvMatrixID;
                static /*0x24*/ int k_ShadowModelScaleID;
                static /*0x28*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerShadows;
                static /*0x30*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerShadowsA;
                static /*0x38*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerShadowsR;
                static /*0x40*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerShadowsG;
                static /*0x48*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerShadowsB;
                static /*0x50*/ UnityEngine.Rendering.RTHandle[] m_RenderTargets;
                static /*0x58*/ int[] m_RenderTargetIds;
                static /*0x60*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_LightInputTextures;
                static /*0x68*/ UnityEngine.Color[] k_ColorLookup;
                static /*0x70*/ UnityEngine.Rendering.ProfilingSampler[] m_ProfilingSamplerShadowColorsLookup;
                static /*0x78*/ uint <maxTextureCount>k__BackingField;

                static /*0x1375e80*/ ShadowRendering();
                static /*0x1376520*/ uint get_maxTextureCount();
                static /*0x1376570*/ void set_maxTextureCount(uint value);
                static /*0x1374200*/ void InitializeBudget(uint maxTextureCount);
                static /*0x13735c0*/ UnityEngine.Material[] CreateMaterials(UnityEngine.Shader shader, int pass);
                static /*0x1373d40*/ UnityEngine.Material GetProjectedShadowMaterial(UnityEngine.Rendering.Universal.Renderer2DData rendererData, int colorIndex);
                static /*0x13740d0*/ UnityEngine.Material GetStencilOnlyShadowMaterial(UnityEngine.Rendering.Universal.Renderer2DData rendererData, int colorIndex);
                static /*0x1373e70*/ UnityEngine.Material GetSpriteSelfShadowMaterial(UnityEngine.Rendering.Universal.Renderer2DData rendererData, int colorIndex);
                static /*0x1373fa0*/ UnityEngine.Material GetSpriteUnshadowMaterial(UnityEngine.Rendering.Universal.Renderer2DData rendererData, int colorIndex);
                static /*0x1373c10*/ UnityEngine.Material GetGeometryUnshadowMaterial(UnityEngine.Rendering.Universal.Renderer2DData rendererData, int colorIndex);
                static /*0x1373750*/ void CreateShadowRenderTexture(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmdBuffer, int shadowIndex);
                static /*0x13746a0*/ bool PrerenderShadows(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmdBuffer, int layerToRender, UnityEngine.Rendering.Universal.Light2D light, int shadowIndex, float shadowIntensity);
                static /*0x1375b60*/ void SetGlobalShadowTexture(UnityEngine.Rendering.CommandBuffer cmdBuffer, UnityEngine.Rendering.Universal.Light2D light, int shadowIndex);
                static /*0x1373b70*/ void DisableGlobalShadowTexture(UnityEngine.Rendering.CommandBuffer cmdBuffer);
                static /*0x13739d0*/ void CreateShadowRenderTexture(UnityEngine.Rendering.Universal.IRenderPass2D pass, int handleId, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmdBuffer);
                static /*0x1374980*/ void ReleaseShadowRenderTexture(UnityEngine.Rendering.CommandBuffer cmdBuffer, int shadowIndex);
                static /*0x1375d10*/ void SetShadowProjectionGlobals(UnityEngine.Rendering.CommandBuffer cmdBuffer, UnityEngine.Rendering.Universal.ShadowCaster2D shadowCaster);
                static /*0x1374a30*/ bool RenderShadows(UnityEngine.Rendering.Universal.IRenderPass2D pass, UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.CommandBuffer cmdBuffer, int layerToRender, UnityEngine.Rendering.Universal.Light2D light, float shadowIntensity, UnityEngine.Rendering.RenderTargetIdentifier renderTexture, int colorBit);
            }

            class ShadowUtility
            {
                static /*0x1376900*/ UnityEngine.Rendering.Universal.ShadowUtility.Edge CreateEdge(int triangleIndexA, int triangleIndexB, System.Collections.Generic.List<UnityEngine.Vector3> vertices, System.Collections.Generic.List<int> triangles);
                static /*0x1377d60*/ void PopulateEdgeArray(System.Collections.Generic.List<UnityEngine.Vector3> vertices, System.Collections.Generic.List<int> triangles, System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowUtility.Edge> edges);
                static /*0x1377be0*/ bool IsOutsideEdge(int edgeIndex, System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowUtility.Edge> edgesToProcess);
                static /*0x1377fe0*/ void SortEdges(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowUtility.Edge> edgesToProcess);
                static /*0x1376bf0*/ void CreateShadowTriangles(System.Collections.Generic.List<UnityEngine.Vector3> vertices, System.Collections.Generic.List<UnityEngine.Color> colors, System.Collections.Generic.List<int> triangles, System.Collections.Generic.List<UnityEngine.Vector4> tangents, System.Collections.Generic.List<UnityEngine.Rendering.Universal.ShadowUtility.Edge> edges);
                static /*0x1377bb0*/ object InterpCustomVertexData(UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 position, object[] data, float[] weights);
                static /*0x1377ac0*/ void InitializeTangents(int tangentsToAdd, System.Collections.Generic.List<UnityEngine.Vector4> tangents);
                static /*0x13765d0*/ UnityEngine.Bounds CalculateLocalBounds(UnityEngine.Vector3[] inVertices);
                static /*0x1376fd0*/ UnityEngine.Bounds GenerateShadowMesh(UnityEngine.Mesh mesh, UnityEngine.Vector3[] shapePath);
                /*0x32f970*/ ShadowUtility();

                struct Edge : System.IComparable<UnityEngine.Rendering.Universal.ShadowUtility.Edge>
                {
                    /*0x10*/ int vertexIndex0;
                    /*0x14*/ int vertexIndex1;
                    /*0x18*/ UnityEngine.Vector4 tangent;
                    /*0x28*/ bool compareReversed;

                    /*0x136f090*/ void AssignVertexIndices(int vi0, int vi1);
                    /*0x136f120*/ int Compare(UnityEngine.Rendering.Universal.ShadowUtility.Edge a, UnityEngine.Rendering.Universal.ShadowUtility.Edge b);
                    /*0x136f0a0*/ int CompareTo(UnityEngine.Rendering.Universal.ShadowUtility.Edge edgeToCompare);
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.ShadowUtility.<> <>9;
                    static /*0x8*/ System.Func<int, int> <>9__9_0;
                    static /*0x10*/ System.Func<UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex, UnityEngine.Vector3> <>9__9_1;
                    static /*0x18*/ System.Func<UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex, UnityEngine.Color> <>9__9_2;

                    static /*0x137b670*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x415460*/ int <GenerateShadowMesh>b__9_0(int i);
                    /*0x1379240*/ UnityEngine.Vector3 <GenerateShadowMesh>b__9_1(UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex v);
                    /*0x1379260*/ UnityEngine.Color <GenerateShadowMesh>b__9_2(UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex v);
                }
            }

            class ComponentUtility
            {
                static /*0x1368110*/ bool IsUniversalCamera(UnityEngine.Camera camera);
                static /*0x1368190*/ bool IsUniversalLight(UnityEngine.Light light);
            }

            class PostProcessData : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.PostProcessData.ShaderResources shaders;
                /*0x20*/ UnityEngine.Rendering.Universal.PostProcessData.TextureResources textures;

                /*0x533ec0*/ PostProcessData();

                class ShaderResources
                {
                    /*0x10*/ UnityEngine.Shader stopNanPS;
                    /*0x18*/ UnityEngine.Shader subpixelMorphologicalAntialiasingPS;
                    /*0x20*/ UnityEngine.Shader gaussianDepthOfFieldPS;
                    /*0x28*/ UnityEngine.Shader bokehDepthOfFieldPS;
                    /*0x30*/ UnityEngine.Shader cameraMotionBlurPS;
                    /*0x38*/ UnityEngine.Shader paniniProjectionPS;
                    /*0x40*/ UnityEngine.Shader lutBuilderLdrPS;
                    /*0x48*/ UnityEngine.Shader lutBuilderHdrPS;
                    /*0x50*/ UnityEngine.Shader bloomPS;
                    /*0x58*/ UnityEngine.Shader temporalAntialiasingPS;
                    /*0x60*/ UnityEngine.Shader LensFlareDataDrivenPS;
                    /*0x68*/ UnityEngine.Shader scalingSetupPS;
                    /*0x70*/ UnityEngine.Shader easuPS;
                    /*0x78*/ UnityEngine.Shader uberPostPS;
                    /*0x80*/ UnityEngine.Shader finalPostPassPS;

                    /*0x32f970*/ ShaderResources();
                }

                class TextureResources
                {
                    /*0x10*/ UnityEngine.Texture2D[] blueNoise16LTex;
                    /*0x18*/ UnityEngine.Texture2D[] filmGrainTex;
                    /*0x20*/ UnityEngine.Texture2D smaaAreaTex;
                    /*0x28*/ UnityEngine.Texture2D smaaSearchTex;

                    /*0x32f970*/ TextureResources();
                }
            }

            class StencilStateData
            {
                /*0x10*/ bool overrideStencilState;
                /*0x14*/ int stencilReference;
                /*0x18*/ UnityEngine.Rendering.CompareFunction stencilCompareFunction;
                /*0x1c*/ UnityEngine.Rendering.StencilOp passOperation;
                /*0x20*/ UnityEngine.Rendering.StencilOp failOperation;
                /*0x24*/ UnityEngine.Rendering.StencilOp zFailOperation;

                /*0x13781a0*/ StencilStateData();
            }

            enum ShadowQuality
            {
                Disabled = 0,
                HardShadows = 1,
                SoftShadows = 2,
            }

            enum SoftShadowQuality
            {
                UsePipelineSettings = 0,
                Low = 1,
                Medium = 2,
                High = 3,
            }

            enum ShadowResolution
            {
                _256 = 256,
                _512 = 512,
                _1024 = 1024,
                _2048 = 2048,
                _4096 = 4096,
            }

            enum LightCookieResolution
            {
                _256 = 256,
                _512 = 512,
                _1024 = 1024,
                _2048 = 2048,
                _4096 = 4096,
            }

            enum LightCookieFormat
            {
                GrayscaleLow = 0,
                GrayscaleHigh = 1,
                ColorLow = 2,
                ColorHigh = 3,
                ColorHDR = 4,
            }

            enum HDRColorBufferPrecision
            {
                _32Bits = 0,
                _64Bits = 1,
            }

            enum MsaaQuality
            {
                Disabled = 1,
                _2x = 2,
                _4x = 4,
                _8x = 8,
            }

            enum Downsampling
            {
                None = 0,
                _2xBilinear = 1,
                _4xBox = 2,
                _4xBilinear = 3,
            }

            enum DefaultMaterialType
            {
                Standard = 0,
                Particle = 1,
                Terrain = 2,
                Sprite = 3,
                UnityBuiltinDefault = 4,
                SpriteMask = 5,
                Decal = 6,
            }

            enum LightRenderingMode
            {
                Disabled = 0,
                PerVertex = 2,
                PerPixel = 1,
            }

            enum PipelineDebugLevel
            {
                Disabled = 0,
                Profiling = 1,
            }

            enum RendererType
            {
                Custom = 0,
                UniversalRenderer = 1,
                _2DRenderer = 2,
                ForwardRenderer = 1,
            }

            enum ColorGradingMode
            {
                LowDynamicRange = 0,
                HighDynamicRange = 1,
            }

            enum StoreActionsOptimization
            {
                Auto = 0,
                Discard = 1,
                Store = 2,
            }

            enum VolumeFrameworkUpdateMode
            {
                EveryFrame = 0,
                ViaScripting = 1,
                UsePipelineSettings = 2,
            }

            enum UpscalingFilterSelection
            {
                Auto = 0,
                Linear = 1,
                Point = 2,
                FSR = 3,
            }

            enum LODCrossFadeDitheringType
            {
                BayerMatrix = 0,
                BlueNoise = 1,
            }

            enum ShEvalMode
            {
                Auto = 0,
                PerVertex = 1,
                Mixed = 2,
                PerPixel = 3,
            }

            class UniversalRenderPipelineAsset : UnityEngine.Rendering.RenderPipelineAsset, UnityEngine.ISerializationCallbackReceiver
            {
                static int k_MinLutSize = 16;
                static int k_MaxLutSize = 65;
                static int k_ShadowCascadeMinCount = 1;
                static int k_ShadowCascadeMaxCount = 4;
                static /*0x0*/ int AdditionalLightsDefaultShadowResolutionTierLow;
                static /*0x4*/ int AdditionalLightsDefaultShadowResolutionTierMedium;
                static /*0x8*/ int AdditionalLightsDefaultShadowResolutionTierHigh;
                static /*0x10*/ UnityEngine.Experimental.Rendering.GraphicsFormat[][] s_LightCookieFormatList;
                /*0x18*/ UnityEngine.Shader m_DefaultShader;
                /*0x20*/ UnityEngine.Rendering.Universal.ScriptableRenderer[] m_Renderers;
                /*0x28*/ int k_AssetVersion;
                /*0x2c*/ int k_AssetPreviousVersion;
                /*0x30*/ UnityEngine.Rendering.Universal.RendererType m_RendererType;
                /*0x38*/ UnityEngine.Rendering.Universal.ScriptableRendererData m_RendererData;
                /*0x40*/ UnityEngine.Rendering.Universal.ScriptableRendererData[] m_RendererDataList;
                /*0x48*/ int m_DefaultRendererIndex;
                /*0x4c*/ bool m_RequireDepthTexture;
                /*0x4d*/ bool m_RequireOpaqueTexture;
                /*0x50*/ UnityEngine.Rendering.Universal.Downsampling m_OpaqueDownsampling;
                /*0x54*/ bool m_SupportsTerrainHoles;
                /*0x55*/ bool m_SupportsHDR;
                /*0x58*/ UnityEngine.Rendering.Universal.HDRColorBufferPrecision m_HDRColorBufferPrecision;
                /*0x5c*/ UnityEngine.Rendering.Universal.MsaaQuality m_MSAA;
                /*0x60*/ float m_RenderScale;
                /*0x64*/ UnityEngine.Rendering.Universal.UpscalingFilterSelection m_UpscalingFilter;
                /*0x68*/ bool m_FsrOverrideSharpness;
                /*0x6c*/ float m_FsrSharpness;
                /*0x70*/ bool m_EnableLODCrossFade;
                /*0x74*/ UnityEngine.Rendering.Universal.LODCrossFadeDitheringType m_LODCrossFadeDitheringType;
                /*0x78*/ UnityEngine.Rendering.Universal.ShEvalMode m_ShEvalMode;
                /*0x7c*/ UnityEngine.Rendering.Universal.LightRenderingMode m_MainLightRenderingMode;
                /*0x80*/ bool m_MainLightShadowsSupported;
                /*0x84*/ UnityEngine.Rendering.Universal.ShadowResolution m_MainLightShadowmapResolution;
                /*0x88*/ UnityEngine.Rendering.Universal.LightRenderingMode m_AdditionalLightsRenderingMode;
                /*0x8c*/ int m_AdditionalLightsPerObjectLimit;
                /*0x90*/ bool m_AdditionalLightShadowsSupported;
                /*0x94*/ UnityEngine.Rendering.Universal.ShadowResolution m_AdditionalLightsShadowmapResolution;
                /*0x98*/ int m_AdditionalLightsShadowResolutionTierLow;
                /*0x9c*/ int m_AdditionalLightsShadowResolutionTierMedium;
                /*0xa0*/ int m_AdditionalLightsShadowResolutionTierHigh;
                /*0xa4*/ bool m_ReflectionProbeBlending;
                /*0xa5*/ bool m_ReflectionProbeBoxProjection;
                /*0xa8*/ float m_ShadowDistance;
                /*0xac*/ int m_ShadowCascadeCount;
                /*0xb0*/ float m_Cascade2Split;
                /*0xb4*/ UnityEngine.Vector2 m_Cascade3Split;
                /*0xbc*/ UnityEngine.Vector3 m_Cascade4Split;
                /*0xc8*/ float m_CascadeBorder;
                /*0xcc*/ float m_ShadowDepthBias;
                /*0xd0*/ float m_ShadowNormalBias;
                /*0xd4*/ bool m_SoftShadowsSupported;
                /*0xd5*/ bool m_ConservativeEnclosingSphere;
                /*0xd8*/ int m_NumIterationsEnclosingSphere;
                /*0xdc*/ UnityEngine.Rendering.Universal.SoftShadowQuality m_SoftShadowQuality;
                /*0xe0*/ UnityEngine.Rendering.Universal.LightCookieResolution m_AdditionalLightsCookieResolution;
                /*0xe4*/ UnityEngine.Rendering.Universal.LightCookieFormat m_AdditionalLightsCookieFormat;
                /*0xe8*/ bool m_UseSRPBatcher;
                /*0xe9*/ bool m_SupportsDynamicBatching;
                /*0xea*/ bool m_MixedLightingSupported;
                /*0xeb*/ bool m_SupportsLightCookies;
                /*0xec*/ bool m_SupportsLightLayers;
                /*0xf0*/ UnityEngine.Rendering.Universal.PipelineDebugLevel m_DebugLevel;
                /*0xf4*/ UnityEngine.Rendering.Universal.StoreActionsOptimization m_StoreActionsOptimization;
                /*0xf8*/ bool m_EnableRenderGraph;
                /*0xf9*/ bool m_UseAdaptivePerformance;
                /*0xfc*/ UnityEngine.Rendering.Universal.ColorGradingMode m_ColorGradingMode;
                /*0x100*/ int m_ColorGradingLutSize;
                /*0x104*/ bool m_UseFastSRGBLinearConversion;
                /*0x105*/ bool m_SupportDataDrivenLensFlare;
                /*0x108*/ UnityEngine.Rendering.Universal.ShadowQuality m_ShadowType;
                /*0x10c*/ bool m_LocalShadowsSupported;
                /*0x110*/ UnityEngine.Rendering.Universal.ShadowResolution m_LocalShadowsAtlasResolution;
                /*0x114*/ int m_MaxPixelLights;
                /*0x118*/ UnityEngine.Rendering.Universal.ShadowResolution m_ShadowAtlasResolution;
                /*0x11c*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateMode;
                /*0x120*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset.TextureResources m_Textures;
                /*0x128*/ int m_ShaderVariantLogLevel;
                /*0x12c*/ UnityEngine.Rendering.Universal.ShadowCascadesOption m_ShadowCascades;

                static /*0x137c740*/ UniversalRenderPipelineAsset();
                /*0x137c980*/ UniversalRenderPipelineAsset();
                /*0x137d0d0*/ System.ReadOnlySpan<UnityEngine.Rendering.Universal.ScriptableRenderer> get_renderers();
                /*0x137c110*/ UnityEngine.Rendering.Universal.ScriptableRendererData LoadBuiltinRendererData(UnityEngine.Rendering.Universal.RendererType type);
                /*0x137b750*/ UnityEngine.Rendering.RenderPipeline CreatePipeline();
                /*0x137bcc0*/ void DestroyRenderers();
                /*0x137bc80*/ void DestroyRenderer(ref UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                /*0x137c410*/ void OnDisable();
                /*0x137ba20*/ void CreateRenderers();
                /*0x388e90*/ UnityEngine.Material GetMaterial(UnityEngine.Rendering.Universal.DefaultMaterialType materialType);
                /*0x137d240*/ UnityEngine.Rendering.Universal.ScriptableRenderer get_scriptableRenderer();
                /*0x137be40*/ UnityEngine.Rendering.Universal.ScriptableRenderer GetRenderer(int index);
                /*0x137d190*/ UnityEngine.Rendering.Universal.ScriptableRendererData get_scriptableRendererData();
                /*0x137cbd0*/ UnityEngine.Experimental.Rendering.GraphicsFormat get_additionalLightsCookieFormat();
                /*0x137cdf0*/ UnityEngine.Vector2Int get_additionalLightsCookieResolution();
                /*0x137d050*/ int[] get_rendererIndexList();
                /*0x137d5b0*/ bool get_supportsCameraDepthTexture();
                /*0x137de80*/ void set_supportsCameraDepthTexture(bool value);
                /*0x137d5c0*/ bool get_supportsCameraOpaqueTexture();
                /*0x137de90*/ void set_supportsCameraOpaqueTexture(bool value);
                /*0xc70ac0*/ UnityEngine.Rendering.Universal.Downsampling get_opaqueDownsampling();
                /*0x137d630*/ bool get_supportsTerrainHoles();
                /*0xbf2c80*/ UnityEngine.Rendering.Universal.StoreActionsOptimization get_storeActionsOptimization();
                /*0xbf30b0*/ void set_storeActionsOptimization(UnityEngine.Rendering.Universal.StoreActionsOptimization value);
                /*0x137d5e0*/ bool get_supportsHDR();
                /*0x137deb0*/ void set_supportsHDR(bool value);
                /*0x104a520*/ UnityEngine.Rendering.Universal.HDRColorBufferPrecision get_hdrColorBufferPrecision();
                /*0x137d9e0*/ void set_hdrColorBufferPrecision(UnityEngine.Rendering.Universal.HDRColorBufferPrecision value);
                /*0x12d9c40*/ int get_msaaSampleCount();
                /*0x137dab0*/ void set_msaaSampleCount(int value);
                /*0x137d040*/ float get_renderScale();
                /*0x137dae0*/ void set_renderScale(float value);
                /*0x137cf30*/ bool get_enableLODCrossFade();
                /*0x136fc60*/ UnityEngine.Rendering.Universal.LODCrossFadeDitheringType get_lodCrossFadeDitheringType();
                /*0x12fd4b0*/ UnityEngine.Rendering.Universal.UpscalingFilterSelection get_upscalingFilter();
                /*0x137dee0*/ void set_upscalingFilter(UnityEngine.Rendering.Universal.UpscalingFilterSelection value);
                /*0xe7e580*/ bool get_fsrOverrideSharpness();
                /*0xe7e640*/ void set_fsrOverrideSharpness(bool value);
                /*0x137cf50*/ float get_fsrSharpness();
                /*0x137d9d0*/ void set_fsrSharpness(float value);
                /*0x1101d10*/ UnityEngine.Rendering.Universal.ShEvalMode get_shEvalMode();
                /*0x12bba70*/ void set_shEvalMode(UnityEngine.Rendering.Universal.ShEvalMode value);
                /*0x137cfa0*/ UnityEngine.Rendering.Universal.LightRenderingMode get_mainLightRenderingMode();
                /*0x137d9f0*/ void set_mainLightRenderingMode(UnityEngine.Rendering.Universal.LightRenderingMode value);
                /*0x12c45f0*/ bool get_supportsMainLightShadows();
                /*0x137dec0*/ void set_supportsMainLightShadows(bool value);
                /*0x115f670*/ int get_mainLightShadowmapResolution();
                /*0x137da00*/ void set_mainLightShadowmapResolution(int value);
                /*0x737a20*/ UnityEngine.Rendering.Universal.LightRenderingMode get_additionalLightsRenderingMode();
                /*0x737e20*/ void set_additionalLightsRenderingMode(UnityEngine.Rendering.Universal.LightRenderingMode value);
                /*0x7378d0*/ int get_maxAdditionalLightsCount();
                /*0x137da10*/ void set_maxAdditionalLightsCount(int value);
                /*0xe71200*/ bool get_supportsAdditionalLightShadows();
                /*0xe71250*/ void set_supportsAdditionalLightShadows(bool value);
                /*0x1348cb0*/ int get_additionalLightsShadowmapResolution();
                /*0x1348ce0*/ void set_additionalLightsShadowmapResolution(int value);
                /*0x12ca850*/ int get_additionalLightsShadowResolutionTierLow();
                /*0x12ca870*/ void set_additionalLightsShadowResolutionTierLow(int value);
                /*0x10f4ab0*/ int get_additionalLightsShadowResolutionTierMedium();
                /*0x137d940*/ void set_additionalLightsShadowResolutionTierMedium(int value);
                /*0xbf2c90*/ int get_additionalLightsShadowResolutionTierHigh();
                /*0xbf30c0*/ void set_additionalLightsShadowResolutionTierHigh(int value);
                /*0x137bd70*/ int GetAdditionalLightsShadowResolution(int additionalLightsShadowResolutionTier);
                /*0x137d020*/ bool get_reflectionProbeBlending();
                /*0x137dac0*/ void set_reflectionProbeBlending(bool value);
                /*0x137d030*/ bool get_reflectionProbeBoxProjection();
                /*0x137dad0*/ void set_reflectionProbeBoxProjection(bool value);
                /*0x137d580*/ float get_shadowDistance();
                /*0x137dde0*/ void set_shadowDistance(float value);
                /*0xb69b00*/ int get_shadowCascadeCount();
                /*0x137dbc0*/ void set_shadowCascadeCount(int value);
                /*0x137ce10*/ float get_cascade2Split();
                /*0x137d950*/ void set_cascade2Split(float value);
                /*0x137ce20*/ UnityEngine.Vector2 get_cascade3Split();
                /*0x137d960*/ void set_cascade3Split(UnityEngine.Vector2 value);
                /*0xbf2cb0*/ UnityEngine.Vector3 get_cascade4Split();
                /*0xbf30f0*/ void set_cascade4Split(UnityEngine.Vector3 value);
                /*0x137ce40*/ float get_cascadeBorder();
                /*0x137d970*/ void set_cascadeBorder(float value);
                /*0x12f47f0*/ float get_shadowDepthBias();
                /*0x137dd70*/ void set_shadowDepthBias(float value);
                /*0x12f47e0*/ float get_shadowNormalBias();
                /*0x137de00*/ void set_shadowNormalBias(float value);
                /*0x137d620*/ bool get_supportsSoftShadows();
                /*0x137ded0*/ void set_supportsSoftShadows(bool value);
                /*0x137d590*/ UnityEngine.Rendering.Universal.SoftShadowQuality get_softShadowQuality();
                /*0x137de70*/ void set_softShadowQuality(UnityEngine.Rendering.Universal.SoftShadowQuality value);
                /*0x137d5d0*/ bool get_supportsDynamicBatching();
                /*0x137dea0*/ void set_supportsDynamicBatching(bool value);
                /*0x137d610*/ bool get_supportsMixedLighting();
                /*0x137d5f0*/ bool get_supportsLightCookies();
                /*0x137d600*/ bool get_supportsLightLayers();
                /*0x137d600*/ bool get_useRenderingLayers();
                /*0x137d930*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode();
                /*0x388e90*/ UnityEngine.Rendering.Universal.PipelineDebugLevel get_debugLevel();
                /*0x137d920*/ bool get_useSRPBatcher();
                /*0x137df00*/ void set_useSRPBatcher(bool value);
                /*0x137cf40*/ bool get_enableRenderGraph();
                /*0x135cb90*/ void set_enableRenderGraph(bool value);
                /*0x137ce60*/ UnityEngine.Rendering.Universal.ColorGradingMode get_colorGradingMode();
                /*0x137d9b0*/ void set_colorGradingMode(UnityEngine.Rendering.Universal.ColorGradingMode value);
                /*0x137ce50*/ int get_colorGradingLutSize();
                /*0x137d980*/ void set_colorGradingLutSize(int value);
                /*0x137d910*/ bool get_useFastSRGBLinearConversion();
                /*0x137d5a0*/ bool get_supportDataDrivenLensFlare();
                /*0x137d900*/ bool get_useAdaptivePerformance();
                /*0x137def0*/ void set_useAdaptivePerformance(bool value);
                /*0x137ce70*/ bool get_conservativeEnclosingSphere();
                /*0x137d9c0*/ void set_conservativeEnclosingSphere(bool value);
                /*0x137cfb0*/ int get_numIterationsEnclosingSphere();
                /*0x3417f0*/ void set_numIterationsEnclosingSphere(int value);
                /*0x388e90*/ UnityEngine.Material get_defaultMaterial();
                /*0x388e90*/ UnityEngine.Material get_defaultParticleMaterial();
                /*0x388e90*/ UnityEngine.Material get_defaultLineMaterial();
                /*0x388e90*/ UnityEngine.Material get_defaultTerrainMaterial();
                /*0x388e90*/ UnityEngine.Material get_defaultUIMaterial();
                /*0x388e90*/ UnityEngine.Material get_defaultUIOverdrawMaterial();
                /*0x388e90*/ UnityEngine.Material get_defaultUIETC1SupportedMaterial();
                /*0x388e90*/ UnityEngine.Material get_default2DMaterial();
                /*0x388e90*/ UnityEngine.Material get_default2DMaskMaterial();
                /*0x388e90*/ UnityEngine.Material get_decalMaterial();
                /*0x137ce80*/ UnityEngine.Shader get_defaultShader();
                /*0x137d7c0*/ UnityEngine.Shader get_terrainDetailLitShader();
                /*0x137d700*/ UnityEngine.Shader get_terrainDetailGrassShader();
                /*0x137d640*/ UnityEngine.Shader get_terrainDetailGrassBillboardShader();
                /*0x137d130*/ string[] get_renderingLayerMaskNames();
                /*0x137cfc0*/ string[] get_prefixedRenderingLayerMaskNames();
                /*0x137cf60*/ string[] get_lightLayerMaskNames();
                /*0x137d880*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset.TextureResources get_textures();
                /*0x32d010*/ void OnBeforeSerialize();
                /*0x137c160*/ void OnAfterDeserialize();
                /*0x137c6e0*/ float ValidateShadowBias(float value);
                /*0x137c430*/ int ValidatePerObjectLights(int value);
                /*0x137c4c0*/ float ValidateRenderScale(float value);
                /*0x137c530*/ bool ValidateRendererDataList(bool partial);
                /*0x137c640*/ bool ValidateRendererData(int index);
                /*0x137d490*/ UnityEngine.Rendering.Universal.ShaderVariantLogLevel get_shaderVariantLogLevel();
                /*0x137db60*/ void set_shaderVariantLogLevel(UnityEngine.Rendering.Universal.ShaderVariantLogLevel value);
                /*0x137d4f0*/ UnityEngine.Rendering.Universal.ShadowCascadesOption get_shadowCascadeOption();
                /*0x137dcd0*/ void set_shadowCascadeOption(UnityEngine.Rendering.Universal.ShadowCascadesOption value);

                class TextureResources
                {
                    /*0x10*/ UnityEngine.Texture2D blueNoise64LTex;
                    /*0x18*/ UnityEngine.Texture2D bayerMatrixTex;

                    /*0x32f970*/ TextureResources();
                    /*0x1378f10*/ bool NeedsReload();
                }
            }

            class UniversalRenderPipelineEditorResources : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineEditorResources.ShaderResources shaders;
                /*0x20*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineEditorResources.MaterialResources materials;

                /*0x533ec0*/ UniversalRenderPipelineEditorResources();

                class ShaderResources
                {
                    /*0x10*/ UnityEngine.Shader autodeskInteractivePS;
                    /*0x18*/ UnityEngine.Shader autodeskInteractiveTransparentPS;
                    /*0x20*/ UnityEngine.Shader autodeskInteractiveMaskedPS;
                    /*0x28*/ UnityEngine.Shader defaultSpeedTree7PS;
                    /*0x30*/ UnityEngine.Shader defaultSpeedTree8PS;

                    /*0x32f970*/ ShaderResources();
                }

                class MaterialResources
                {
                    /*0x10*/ UnityEngine.Material lit;
                    /*0x18*/ UnityEngine.Material particleLit;
                    /*0x20*/ UnityEngine.Material terrainLit;
                    /*0x28*/ UnityEngine.Material decal;

                    /*0x32f970*/ MaterialResources();
                }
            }

            class XRSystemData : UnityEngine.ScriptableObject
            {
                /*0x18*/ UnityEngine.Rendering.Universal.XRSystemData.ShaderResources shaders;

                /*0x533ec0*/ XRSystemData();

                class ShaderResources
                {
                    /*0x10*/ UnityEngine.Shader xrOcclusionMeshPS;
                    /*0x18*/ UnityEngine.Shader xrMirrorViewPS;

                    /*0x32f970*/ ShaderResources();
                }
            }

            class DebugDisplaySettingsCommon : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
            {
                /*0x32f970*/ DebugDisplaySettingsCommon();
                /*0x348b00*/ bool get_AreAnySettingsActive();
                /*0x3ce290*/ bool get_IsPostProcessingAllowed();
                /*0x3ce290*/ bool get_IsLightingActive();
                /*0x348b00*/ bool TryGetScreenClearColor(ref UnityEngine.Color _);
                /*0x13694c0*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();

                class WidgetFactory
                {
                    static /*0x1381630*/ UnityEngine.Rendering.DebugUI.Widget CreateMissingDebugShadersWarning();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon.WidgetFactory.<> <>9;
                        static /*0x8*/ System.Func<bool> <>9__0_0;

                        static /*0x137b6e0*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x13790d0*/ bool <CreateMissingDebugShadersWarning>b__0_0();
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel
                {
                    static string k_GoToSectionString = "Go to Section...";

                    /*0x136fdb0*/ SettingsPanel();
                    /*0x6bbaf0*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ UnityEngine.Rendering.DebugUI.Foldout foldout;

                        /*0x32f970*/ <>c__DisplayClass3_0();
                        /*0x137a7f0*/ void <.ctor>b__0();
                    }
                }
            }

            class DebugDisplaySettingsLighting : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugLightingMode <lightingDebugMode>k__BackingField;
                /*0x14*/ UnityEngine.Rendering.Universal.DebugLightingFeatureFlags <lightingFeatureFlags>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.Universal.HDRDebugMode <hdrDebugMode>k__BackingField;

                /*0x32f970*/ DebugDisplaySettingsLighting();
                /*0x417e30*/ UnityEngine.Rendering.Universal.DebugLightingMode get_lightingDebugMode();
                /*0xdcd9c0*/ void set_lightingDebugMode(UnityEngine.Rendering.Universal.DebugLightingMode value);
                /*0x70a440*/ UnityEngine.Rendering.Universal.DebugLightingFeatureFlags get_lightingFeatureFlags();
                /*0xc70b20*/ void set_lightingFeatureFlags(UnityEngine.Rendering.Universal.DebugLightingFeatureFlags value);
                /*0x8a5c20*/ UnityEngine.Rendering.Universal.HDRDebugMode get_hdrDebugMode();
                /*0x8a5c50*/ void set_hdrDebugMode(UnityEngine.Rendering.Universal.HDRDebugMode value);
                /*0x1369690*/ bool get_AreAnySettingsActive();
                /*0x13696b0*/ bool get_IsPostProcessingAllowed();
                /*0x3ce290*/ bool get_IsLightingActive();
                /*0x348b00*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x1369510*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();

                class Strings
                {
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LightingDebugMode;
                    static /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip LightingFeatures;
                    static /*0x20*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip HDRDebugMode;

                    static /*0x1378850*/ Strings();
                }

                class WidgetFactory
                {
                    static /*0x137fcf0*/ UnityEngine.Rendering.DebugUI.Widget CreateLightingDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel);
                    static /*0x137ff70*/ UnityEngine.Rendering.DebugUI.Widget CreateLightingFeatures(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel);
                    static /*0x137f8c0*/ UnityEngine.Rendering.DebugUI.Widget CreateHDRDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass0_0();
                        /*0x1379480*/ int <CreateLightingDebugMode>b__0();
                        /*0x13794d0*/ void <CreateLightingDebugMode>b__1(int value);
                        /*0x1379530*/ int <CreateLightingDebugMode>b__2();
                        /*0x1379580*/ void <CreateLightingDebugMode>b__3(int value);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass1_0();
                        /*0x1379dd0*/ System.Enum <CreateLightingFeatures>b__0();
                        /*0x1379e40*/ void <CreateLightingFeatures>b__1(System.Enum value);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass2_0();
                        /*0x137a2e0*/ int <CreateHDRDebugMode>b__0();
                        /*0x137a330*/ void <CreateHDRDebugMode>b__1(int value);
                        /*0x137a390*/ int <CreateHDRDebugMode>b__2();
                        /*0x137a3e0*/ void <CreateHDRDebugMode>b__3(int value);
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting>
                {
                    /*0x13700d0*/ SettingsPanel(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting data);
                }
            }

            class DebugDisplaySettingsMaterial : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPresetData[] m_AlbedoDebugValidationPresetData;
                /*0x18*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset m_AlbedoValidationPreset;
                /*0x1c*/ float <albedoMinLuminance>k__BackingField;
                /*0x20*/ float <albedoMaxLuminance>k__BackingField;
                /*0x24*/ float m_AlbedoHueTolerance;
                /*0x28*/ float m_AlbedoSaturationTolerance;
                /*0x2c*/ UnityEngine.Color <albedoCompareColor>k__BackingField;
                /*0x3c*/ float <metallicMinValue>k__BackingField;
                /*0x40*/ float <metallicMaxValue>k__BackingField;
                /*0x44*/ UnityEngine.Rendering.Universal.DebugMaterialValidationMode <materialValidationMode>k__BackingField;
                /*0x48*/ UnityEngine.Rendering.Universal.DebugMaterialMode <materialDebugMode>k__BackingField;
                /*0x4c*/ UnityEngine.Rendering.Universal.DebugVertexAttributeMode <vertexAttributeDebugMode>k__BackingField;

                /*0x1369730*/ DebugDisplaySettingsMaterial();
                /*0x8a5c20*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset get_albedoValidationPreset();
                /*0x136a0a0*/ void set_albedoValidationPreset(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.AlbedoDebugValidationPreset value);
                /*0x1316910*/ float get_albedoMinLuminance();
                /*0x1316920*/ void set_albedoMinLuminance(float value);
                /*0x129f790*/ float get_albedoMaxLuminance();
                /*0x136a080*/ void set_albedoMaxLuminance(float value);
                /*0x136a020*/ float get_albedoHueTolerance();
                /*0x136a070*/ void set_albedoHueTolerance(float value);
                /*0x136a040*/ float get_albedoSaturationTolerance();
                /*0x136a090*/ void set_albedoSaturationTolerance(float value);
                /*0x136a010*/ UnityEngine.Color get_albedoCompareColor();
                /*0x136a060*/ void set_albedoCompareColor(UnityEngine.Color value);
                /*0x129f7b0*/ float get_metallicMinValue();
                /*0x136a120*/ void set_metallicMinValue(float value);
                /*0xcf6cb0*/ float get_metallicMaxValue();
                /*0xcf6d00*/ void set_metallicMaxValue(float value);
                /*0x10eed50*/ UnityEngine.Rendering.Universal.DebugMaterialValidationMode get_materialValidationMode();
                /*0x10eed60*/ void set_materialValidationMode(UnityEngine.Rendering.Universal.DebugMaterialValidationMode value);
                /*0x12f47d0*/ UnityEngine.Rendering.Universal.DebugMaterialMode get_materialDebugMode();
                /*0x136a110*/ void set_materialDebugMode(UnityEngine.Rendering.Universal.DebugMaterialMode value);
                /*0xc70af0*/ UnityEngine.Rendering.Universal.DebugVertexAttributeMode get_vertexAttributeDebugMode();
                /*0xc70b40*/ void set_vertexAttributeDebugMode(UnityEngine.Rendering.Universal.DebugVertexAttributeMode value);
                /*0x1369fd0*/ bool get_AreAnySettingsActive();
                /*0x1369ff0*/ bool get_IsPostProcessingAllowed();
                /*0x1369ff0*/ bool get_IsLightingActive();
                /*0x348b00*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x13696d0*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();

                enum AlbedoDebugValidationPreset
                {
                    DefaultLuminance = 0,
                    BlackAcrylicPaint = 1,
                    DarkSoil = 2,
                    WornAsphalt = 3,
                    DryClaySoil = 4,
                    GreenGrass = 5,
                    OldConcrete = 6,
                    RedClayTile = 7,
                    DrySand = 8,
                    NewConcrete = 9,
                    WhiteAcrylicPaint = 10,
                    FreshSnow = 11,
                    BlueSky = 12,
                    Foliage = 13,
                    Custom = 14,
                }

                struct AlbedoDebugValidationPresetData
                {
                    /*0x10*/ string name;
                    /*0x18*/ UnityEngine.Color color;
                    /*0x28*/ float minLuminance;
                    /*0x2c*/ float maxLuminance;
                }

                class Strings
                {
                    static string AlbedoSettingsContainerName = "Albedo Settings";
                    static string MetallicSettingsContainerName = "Metallic Settings";
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MaterialOverride;
                    static /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip VertexAttribute;
                    static /*0x20*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MaterialValidationMode;
                    static /*0x30*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ValidationPreset;
                    static /*0x40*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoCustomColor;
                    static /*0x50*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoMinLuminance;
                    static /*0x60*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoMaxLuminance;
                    static /*0x70*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoHueTolerance;
                    static /*0x80*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AlbedoSaturationTolerance;
                    static /*0x90*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MetallicMinValue;
                    static /*0xa0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MetallicMaxValue;

                    static /*0x13789f0*/ Strings();
                }

                class WidgetFactory
                {
                    static /*0x1380920*/ UnityEngine.Rendering.DebugUI.Widget CreateMaterialOverride(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x1382910*/ UnityEngine.Rendering.DebugUI.Widget CreateVertexAttribute(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x1380ba0*/ UnityEngine.Rendering.DebugUI.Widget CreateMaterialValidationMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x137f370*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoPreset(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x137ec20*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoCustomColor(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x137f1c0*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoMinLuminance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x137f010*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoMaxLuminance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x137ee10*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoHueTolerance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x137f6c0*/ UnityEngine.Rendering.DebugUI.Widget CreateAlbedoSaturationTolerance(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x1381480*/ UnityEngine.Rendering.DebugUI.Widget CreateMetallicMinValue(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);
                    static /*0x13812d0*/ UnityEngine.Rendering.DebugUI.Widget CreateMetallicMaxValue(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel);

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.WidgetFactory.<> <>9;
                        static /*0x8*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__2_4;
                        static /*0x10*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__3_4;

                        static /*0x137b600*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x1379060*/ void <CreateMaterialValidationMode>b__2_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                        /*0x1379000*/ void <CreateAlbedoPreset>b__3_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                    }

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass0_0();
                        /*0x1379740*/ int <CreateMaterialOverride>b__0();
                        /*0x1379790*/ void <CreateMaterialOverride>b__1(int value);
                        /*0x13797f0*/ int <CreateMaterialOverride>b__2();
                        /*0x1379840*/ void <CreateMaterialOverride>b__3(int value);
                    }

                    class <>c__DisplayClass10_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass10_0();
                        /*0x1379900*/ float <CreateMetallicMaxValue>b__0();
                        /*0x1379950*/ void <CreateMetallicMaxValue>b__1(float value);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass1_0();
                        /*0x1379f80*/ int <CreateVertexAttribute>b__0();
                        /*0x1379fd0*/ void <CreateVertexAttribute>b__1(int value);
                        /*0x137a030*/ int <CreateVertexAttribute>b__2();
                        /*0x137a080*/ void <CreateVertexAttribute>b__3(int value);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass2_0();
                        /*0x137a440*/ int <CreateMaterialValidationMode>b__0();
                        /*0x137a490*/ void <CreateMaterialValidationMode>b__1(int value);
                        /*0x137a4f0*/ int <CreateMaterialValidationMode>b__2();
                        /*0x137a540*/ void <CreateMaterialValidationMode>b__3(int value);
                    }

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass3_0();
                        /*0x137a5a0*/ int <CreateAlbedoPreset>b__0();
                        /*0x137a5f0*/ void <CreateAlbedoPreset>b__1(int value);
                        /*0x137a690*/ int <CreateAlbedoPreset>b__2();
                        /*0x137a6e0*/ void <CreateAlbedoPreset>b__3(int value);
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass4_0();
                        /*0x137a8c0*/ UnityEngine.Color <CreateAlbedoCustomColor>b__0();
                        /*0x137a920*/ void <CreateAlbedoCustomColor>b__1(UnityEngine.Color value);
                        /*0x137a980*/ bool <CreateAlbedoCustomColor>b__2();
                    }

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass5_0();
                        /*0x137abd0*/ float <CreateAlbedoMinLuminance>b__0();
                        /*0x137ac20*/ void <CreateAlbedoMinLuminance>b__1(float value);
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass6_0();
                        /*0x137ad80*/ float <CreateAlbedoMaxLuminance>b__0();
                        /*0x137add0*/ void <CreateAlbedoMaxLuminance>b__1(float value);
                    }

                    class <>c__DisplayClass7_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass7_0();
                        /*0x137af90*/ float <CreateAlbedoHueTolerance>b__0();
                        /*0x137aff0*/ void <CreateAlbedoHueTolerance>b__1(float value);
                        /*0x137b050*/ bool <CreateAlbedoHueTolerance>b__2();
                    }

                    class <>c__DisplayClass8_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass8_0();
                        /*0x137b150*/ float <CreateAlbedoSaturationTolerance>b__0();
                        /*0x137b1b0*/ void <CreateAlbedoSaturationTolerance>b__1(float value);
                        /*0x137b210*/ bool <CreateAlbedoSaturationTolerance>b__2();
                    }

                    class <>c__DisplayClass9_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass9_0();
                        /*0x137b310*/ float <CreateMetallicMinValue>b__0();
                        /*0x137b360*/ void <CreateMetallicMinValue>b__1(float value);
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial>
                {
                    /*0x1370230*/ SettingsPanel(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial data;

                        /*0x32f970*/ <>c__DisplayClass0_0();
                        /*0x13798c0*/ bool <.ctor>b__0();
                        /*0x13798e0*/ bool <.ctor>b__1();
                    }
                }
            }

            enum DebugWireframeMode
            {
                None = 0,
                Wireframe = 1,
                SolidWireframe = 2,
                ShadedWireframe = 3,
            }

            class DebugDisplaySettingsRendering : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugWireframeMode m_WireframeMode;
                /*0x14*/ bool m_Overdraw;
                /*0x18*/ UnityEngine.Rendering.Universal.DebugOverdrawMode m_OverdrawMode;
                /*0x1c*/ int <maxOverdrawCount>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.Universal.DebugFullScreenMode <fullScreenDebugMode>k__BackingField;
                /*0x24*/ int <fullScreenDebugModeOutputSizeScreenPercent>k__BackingField;
                /*0x28*/ UnityEngine.Rendering.Universal.DebugSceneOverrideMode <sceneOverrideMode>k__BackingField;
                /*0x2c*/ UnityEngine.Rendering.Universal.DebugMipInfoMode <mipInfoMode>k__BackingField;
                /*0x30*/ UnityEngine.Rendering.Universal.DebugPostProcessingMode <postProcessingDebugMode>k__BackingField;
                /*0x34*/ bool <enableMsaa>k__BackingField;
                /*0x35*/ bool <enableHDR>k__BackingField;
                /*0x38*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.TaaDebugMode <taaDebugMode>k__BackingField;
                /*0x3c*/ UnityEngine.Rendering.Universal.DebugValidationMode <validationMode>k__BackingField;
                /*0x40*/ UnityEngine.Rendering.Universal.PixelValidationChannels <validationChannels>k__BackingField;
                /*0x44*/ float <validationRangeMin>k__BackingField;
                /*0x48*/ float <validationRangeMax>k__BackingField;

                /*0x136a2a0*/ DebugDisplaySettingsRendering();
                /*0x417e30*/ UnityEngine.Rendering.Universal.DebugWireframeMode get_wireframeMode();
                /*0x136a450*/ void set_wireframeMode(UnityEngine.Rendering.Universal.DebugWireframeMode value);
                /*0x8b9820*/ bool get_overdraw();
                /*0x136a3d0*/ void set_overdraw(bool value);
                /*0x8a5c20*/ UnityEngine.Rendering.Universal.DebugOverdrawMode get_overdrawMode();
                /*0x136a380*/ void set_overdrawMode(UnityEngine.Rendering.Universal.DebugOverdrawMode value);
                /*0xc70b00*/ int get_maxOverdrawCount();
                /*0xc70b50*/ void set_maxOverdrawCount(int value);
                /*0x136a240*/ void UpdateDebugSceneOverrideMode();
                /*0x3e3af0*/ UnityEngine.Rendering.Universal.DebugFullScreenMode get_fullScreenDebugMode();
                /*0x11172b0*/ void set_fullScreenDebugMode(UnityEngine.Rendering.Universal.DebugFullScreenMode value);
                /*0x3e3ad0*/ int get_fullScreenDebugModeOutputSizeScreenPercent();
                /*0xc70b30*/ void set_fullScreenDebugModeOutputSizeScreenPercent(int value);
                /*0x3e3ae0*/ UnityEngine.Rendering.Universal.DebugSceneOverrideMode get_sceneOverrideMode();
                /*0xc6dab0*/ void set_sceneOverrideMode(UnityEngine.Rendering.Universal.DebugSceneOverrideMode value);
                /*0xbe6c70*/ UnityEngine.Rendering.Universal.DebugMipInfoMode get_mipInfoMode();
                /*0xbe6cd0*/ void set_mipInfoMode(UnityEngine.Rendering.Universal.DebugMipInfoMode value);
                /*0xa79cc0*/ UnityEngine.Rendering.Universal.DebugPostProcessingMode get_postProcessingDebugMode();
                /*0xa79cd0*/ void set_postProcessingDebugMode(UnityEngine.Rendering.Universal.DebugPostProcessingMode value);
                /*0x1102a60*/ bool get_enableMsaa();
                /*0x1102a80*/ void set_enableMsaa(bool value);
                /*0x136a350*/ bool get_enableHDR();
                /*0x136a370*/ void set_enableHDR(bool value);
                /*0xeab1d0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.TaaDebugMode get_taaDebugMode();
                /*0x12d8f70*/ void set_taaDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.TaaDebugMode value);
                /*0xee1680*/ UnityEngine.Rendering.Universal.DebugValidationMode get_validationMode();
                /*0x136a430*/ void set_validationMode(UnityEngine.Rendering.Universal.DebugValidationMode value);
                /*0xbe6be0*/ UnityEngine.Rendering.Universal.PixelValidationChannels get_validationChannels();
                /*0xbe6cc0*/ void set_validationChannels(UnityEngine.Rendering.Universal.PixelValidationChannels value);
                /*0x129f7a0*/ float get_validationRangeMin();
                /*0x1355540*/ void set_validationRangeMin(float value);
                /*0x136a360*/ float get_validationRangeMax();
                /*0x136a440*/ void set_validationRangeMax(float value);
                /*0x136a2d0*/ bool get_AreAnySettingsActive();
                /*0x136a330*/ bool get_IsPostProcessingAllowed();
                /*0x136a310*/ bool get_IsLightingActive();
                /*0x136a130*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x136a1e0*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable UnityEngine.Rendering.IDebugDisplaySettingsData.CreatePanel();

                enum TaaDebugMode
                {
                    None = 0,
                    ShowRawFrame = 1,
                    ShowRawFrameNoJitter = 2,
                    ShowClampedHistory = 3,
                }

                class Strings
                {
                    static string RangeValidationSettingsContainerName = "Pixel Range Settings";
                    static /*0x0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MapOverlays;
                    static /*0x10*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MapSize;
                    static /*0x20*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip AdditionalWireframeModes;
                    static /*0x30*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip WireframeNotSupportedWarning;
                    static /*0x40*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip OverdrawMode;
                    static /*0x50*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MaxOverdrawCount;
                    static /*0x60*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip PostProcessing;
                    static /*0x70*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip MSAA;
                    static /*0x80*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip HDR;
                    static /*0x90*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip TaaDebugMode;
                    static /*0xa0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip PixelValidationMode;
                    static /*0xb0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip Channels;
                    static /*0xc0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ValueRangeMin;
                    static /*0xd0*/ UnityEngine.Rendering.DebugUI.Widget.NameAndTooltip ValueRangeMax;

                    static /*0x13781b0*/ Strings();
                }

                class WidgetFactory
                {
                    static /*0x13806a0*/ UnityEngine.Rendering.DebugUI.Widget CreateMapOverlays(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x1380310*/ UnityEngine.Rendering.DebugUI.Widget CreateMapOverlaySize(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x137e8d0*/ UnityEngine.Rendering.DebugUI.Widget CreateAdditionalWireframeShaderViews(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x1382b90*/ UnityEngine.Rendering.DebugUI.Widget CreateWireframeNotSupportedWarning(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x1381790*/ UnityEngine.Rendering.DebugUI.Widget CreateOverdrawMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x1380ef0*/ UnityEngine.Rendering.DebugUI.Widget CreateMaxOverdrawCount(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x1382340*/ UnityEngine.Rendering.DebugUI.Widget CreatePostProcessing(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x1380170*/ UnityEngine.Rendering.DebugUI.Widget CreateMSAA(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x137fb40*/ UnityEngine.Rendering.DebugUI.Widget CreateHDR(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x13825c0*/ UnityEngine.Rendering.DebugUI.Widget CreateTaaDebugMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x1381c90*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValidationMode(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x1381a10*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValidationChannels(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x1382190*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValueRangeMin(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);
                    static /*0x1381fe0*/ UnityEngine.Rendering.DebugUI.Widget CreatePixelValueRangeMax(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel);

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.WidgetFactory.<> <>9;
                        static /*0x8*/ System.Func<int> <>9__1_2;
                        static /*0x10*/ System.Func<int> <>9__1_3;
                        static /*0x18*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__2_4;
                        static /*0x20*/ System.Func<int> <>9__5_3;
                        static /*0x28*/ System.Func<int> <>9__5_4;
                        static /*0x30*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__9_4;
                        static /*0x38*/ System.Action<UnityEngine.Rendering.DebugUI.Field<int>, int> <>9__10_4;

                        static /*0x137b590*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x388e90*/ int <CreateMapOverlaySize>b__1_2();
                        /*0x3bcaf0*/ int <CreateMapOverlaySize>b__1_3();
                        /*0x1378fa0*/ void <CreateAdditionalWireframeShaderViews>b__2_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                        /*0x6bba80*/ int <CreateMaxOverdrawCount>b__5_3();
                        /*0x13790c0*/ int <CreateMaxOverdrawCount>b__5_4();
                        /*0x13791e0*/ void <CreateTaaDebugMode>b__9_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                        /*0x1379180*/ void <CreatePixelValidationMode>b__10_4(UnityEngine.Rendering.DebugUI.Field<int> _, int _);
                    }

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass0_0();
                        /*0x13795e0*/ int <CreateMapOverlays>b__0();
                        /*0x1379630*/ void <CreateMapOverlays>b__1(int value);
                        /*0x1379690*/ int <CreateMapOverlays>b__2();
                        /*0x13796e0*/ void <CreateMapOverlays>b__3(int value);
                    }

                    class <>c__DisplayClass10_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass10_0();
                        /*0x13799b0*/ int <CreatePixelValidationMode>b__0();
                        /*0x1379a00*/ void <CreatePixelValidationMode>b__1(int value);
                        /*0x1379a60*/ int <CreatePixelValidationMode>b__2();
                        /*0x1379ab0*/ void <CreatePixelValidationMode>b__3(int value);
                    }

                    class <>c__DisplayClass11_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass11_0();
                        /*0x1379b10*/ int <CreatePixelValidationChannels>b__0();
                        /*0x1379b60*/ void <CreatePixelValidationChannels>b__1(int value);
                        /*0x1379bc0*/ int <CreatePixelValidationChannels>b__2();
                        /*0x1379c10*/ void <CreatePixelValidationChannels>b__3(int value);
                    }

                    class <>c__DisplayClass12_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass12_0();
                        /*0x1379c70*/ float <CreatePixelValueRangeMin>b__0();
                        /*0x1379cc0*/ void <CreatePixelValueRangeMin>b__1(float value);
                    }

                    class <>c__DisplayClass13_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass13_0();
                        /*0x1379d20*/ float <CreatePixelValueRangeMax>b__0();
                        /*0x1379d70*/ void <CreatePixelValueRangeMax>b__1(float value);
                    }

                    class <>c__DisplayClass1_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass1_0();
                        /*0x1379ed0*/ int <CreateMapOverlaySize>b__0();
                        /*0x1379f20*/ void <CreateMapOverlaySize>b__1(int value);
                    }

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass2_0();
                        /*0x137a0e0*/ int <CreateAdditionalWireframeShaderViews>b__0();
                        /*0x137a130*/ void <CreateAdditionalWireframeShaderViews>b__1(int value);
                        /*0x137a1e0*/ int <CreateAdditionalWireframeShaderViews>b__2();
                        /*0x137a230*/ void <CreateAdditionalWireframeShaderViews>b__3(int value);
                    }

                    class <>c__DisplayClass3_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass3_0();
                        /*0x137a780*/ bool <CreateWireframeNotSupportedWarning>b__0();
                    }

                    class <>c__DisplayClass4_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass4_0();
                        /*0x137a9d0*/ int <CreateOverdrawMode>b__0();
                        /*0x137aa20*/ void <CreateOverdrawMode>b__1(int value);
                        /*0x137aad0*/ int <CreateOverdrawMode>b__2();
                        /*0x137ab20*/ void <CreateOverdrawMode>b__3(int value);
                    }

                    class <>c__DisplayClass5_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass5_0();
                        /*0x137ac80*/ bool <CreateMaxOverdrawCount>b__0();
                        /*0x137acd0*/ int <CreateMaxOverdrawCount>b__1();
                        /*0x137ad20*/ void <CreateMaxOverdrawCount>b__2(int value);
                    }

                    class <>c__DisplayClass6_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass6_0();
                        /*0x137ae30*/ int <CreatePostProcessing>b__0();
                        /*0x137ae80*/ void <CreatePostProcessing>b__1(int value);
                        /*0x137aee0*/ int <CreatePostProcessing>b__2();
                        /*0x137af30*/ void <CreatePostProcessing>b__3(int value);
                    }

                    class <>c__DisplayClass7_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass7_0();
                        /*0x137b0a0*/ bool <CreateMSAA>b__0();
                        /*0x137b0f0*/ void <CreateMSAA>b__1(bool value);
                    }

                    class <>c__DisplayClass8_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass8_0();
                        /*0x137b260*/ bool <CreateHDR>b__0();
                        /*0x137b2b0*/ void <CreateHDR>b__1(bool value);
                    }

                    class <>c__DisplayClass9_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering.SettingsPanel panel;

                        /*0x32f970*/ <>c__DisplayClass9_0();
                        /*0x137b3c0*/ int <CreateTaaDebugMode>b__0();
                        /*0x137b410*/ void <CreateTaaDebugMode>b__1(int value);
                        /*0x137b470*/ int <CreateTaaDebugMode>b__2();
                        /*0x137b4c0*/ void <CreateTaaDebugMode>b__3(int value);
                    }
                }

                class SettingsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel<UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering>
                {
                    /*0x1370e90*/ SettingsPanel(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data);

                    class <>c__DisplayClass0_0
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering data;

                        /*0x32f970*/ <>c__DisplayClass0_0();
                        /*0x13798a0*/ bool <.ctor>b__0();
                    }
                }
            }

            class DebugDisplayStats : UnityEngine.Rendering.IDebugDisplaySettingsData, UnityEngine.Rendering.IDebugDisplaySettingsQuery
            {
                /*0x10*/ UnityEngine.Rendering.DebugFrameTiming m_DebugFrameTiming;

                /*0x136a530*/ DebugDisplayStats();
                /*0x136a510*/ void UpdateFrameTiming();
                /*0x348b00*/ bool get_AreAnySettingsActive();
                /*0x3ce290*/ bool get_IsPostProcessingAllowed();
                /*0x3ce290*/ bool get_IsLightingActive();
                /*0x348b00*/ bool TryGetScreenClearColor(ref UnityEngine.Color _);
                /*0x136a4b0*/ UnityEngine.Rendering.IDebugDisplaySettingsPanelDisposable CreatePanel();

                class StatsPanel : UnityEngine.Rendering.DebugDisplaySettingsPanel
                {
                    /*0x1378030*/ StatsPanel(UnityEngine.Rendering.DebugFrameTiming frameTiming);
                    /*0x6bbad0*/ UnityEngine.Rendering.DebugUI.Flags get_Flags();
                }
            }

            class DebugHandler : UnityEngine.Rendering.IDebugDisplaySettingsQuery
            {
                static /*0x0*/ int k_DebugColorInvalidModePropertyId;
                static /*0x4*/ int k_DebugColorPropertyId;
                static /*0x8*/ int k_DebugTexturePropertyId;
                static /*0xc*/ int k_DebugTextureNoStereoPropertyId;
                static /*0x10*/ int k_DebugTextureDisplayRect;
                static /*0x14*/ int k_DebugRenderTargetSupportsStereo;
                static /*0x18*/ int k_DebugMaterialModeId;
                static /*0x1c*/ int k_DebugVertexAttributeModeId;
                static /*0x20*/ int k_DebugMaterialValidationModeId;
                static /*0x24*/ int k_DebugMipInfoModeId;
                static /*0x28*/ int k_DebugSceneOverrideModeId;
                static /*0x2c*/ int k_DebugFullScreenModeId;
                static /*0x30*/ int k_DebugValidationModeId;
                static /*0x34*/ int k_DebugValidateBelowMinThresholdColorPropertyId;
                static /*0x38*/ int k_DebugValidateAboveMaxThresholdColorPropertyId;
                static /*0x3c*/ int k_DebugMaxPixelCost;
                static /*0x40*/ int k_DebugLightingModeId;
                static /*0x44*/ int k_DebugLightingFeatureFlagsId;
                static /*0x48*/ int k_DebugValidateAlbedoMinLuminanceId;
                static /*0x4c*/ int k_DebugValidateAlbedoMaxLuminanceId;
                static /*0x50*/ int k_DebugValidateAlbedoSaturationToleranceId;
                static /*0x54*/ int k_DebugValidateAlbedoHueToleranceId;
                static /*0x58*/ int k_DebugValidateAlbedoCompareColorId;
                static /*0x5c*/ int k_DebugValidateMetallicMinValueId;
                static /*0x60*/ int k_DebugValidateMetallicMaxValueId;
                static /*0x64*/ int k_ValidationChannelsId;
                static /*0x68*/ int k_RangeMinimumId;
                static /*0x6c*/ int k_RangeMaximumId;
                /*0x10*/ UnityEngine.Material m_ReplacementMaterial;
                /*0x18*/ UnityEngine.Material m_HDRDebugViewMaterial;
                /*0x20*/ UnityEngine.Rendering.Universal.HDRDebugViewPass m_HDRDebugViewPass;
                /*0x28*/ UnityEngine.Rendering.RTHandle m_DebugScreenColorHandle;
                /*0x30*/ UnityEngine.Rendering.RTHandle m_DebugScreenDepthHandle;
                /*0x38*/ bool m_HasDebugRenderTarget;
                /*0x39*/ bool m_DebugRenderTargetSupportsStereo;
                /*0x3c*/ UnityEngine.Vector4 m_DebugRenderTargetPixelRect;
                /*0x50*/ UnityEngine.Rendering.RenderTargetIdentifier m_DebugRenderTargetIdentifier;
                /*0x78*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings m_DebugDisplaySettings;

                static /*0x136bc40*/ DebugHandler();
                static /*0x136a5a0*/ void ConfigureColorDescriptorForDebugScreen(ref UnityEngine.RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight);
                static /*0x136a5f0*/ void ConfigureDepthDescriptorForDebugScreen(ref UnityEngine.RenderTextureDescriptor descriptor, int depthBufferBits, int cameraWidth, int cameraHeight);
                /*0x136c120*/ DebugHandler(UnityEngine.Rendering.Universal.ScriptableRendererData scriptableRendererData);
                /*0x136c480*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting get_LightingSettings();
                /*0x136c4a0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial get_MaterialSettings();
                /*0x136c4c0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering get_RenderingSettings();
                /*0x136c2e0*/ bool get_AreAnySettingsActive();
                /*0x136c3d0*/ bool get_IsPostProcessingAllowed();
                /*0x136c3a0*/ bool get_IsLightingActive();
                /*0x136c330*/ bool get_IsActiveModeUnsupportedForDeferred();
                /*0x136b980*/ bool TryGetScreenClearColor(ref UnityEngine.Color color);
                /*0x73d3e0*/ UnityEngine.Material get_ReplacementMaterial();
                /*0xecb7b0*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings get_DebugDisplaySettings();
                /*0x136c310*/ ref UnityEngine.Rendering.RTHandle get_DebugScreenColorHandle();
                /*0x136c320*/ ref UnityEngine.Rendering.RTHandle get_DebugScreenDepthHandle();
                /*0x61a260*/ UnityEngine.Rendering.Universal.HDRDebugViewPass get_hdrDebugViewPass();
                /*0x136aeb0*/ bool HDRDebugViewIsActive(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x136aeb0*/ bool WriteToDebugScreenTexture(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x136c440*/ bool get_IsScreenClearNeeded();
                /*0x136c400*/ bool get_IsRenderPassSupported();
                /*0x136a700*/ void Dispose();
                /*0x136aef0*/ bool IsActiveForCamera(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x136b8f0*/ bool TryGetFullscreenDebugMode(ref UnityEngine.Rendering.Universal.DebugFullScreenMode debugFullScreenMode);
                /*0x136b930*/ bool TryGetFullscreenDebugMode(ref UnityEngine.Rendering.Universal.DebugFullScreenMode debugFullScreenMode, ref int textureHeightPercent);
                /*0x136af80*/ void SetupShaderProperties(UnityEngine.Rendering.CommandBuffer cmd, int passIndex);
                /*0x136af40*/ void SetDebugRenderTarget(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier, UnityEngine.Rect displayRect, bool supportsStereo);
                /*0xf35220*/ void ResetDebugRenderTarget();
                /*0x136b9b0*/ void UpdateShaderGlobalPropertiesForFinalValidationPass(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData, bool isFinalPass);
                /*0x136b480*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x136a650*/ System.Collections.Generic.IEnumerable<UnityEngine.Rendering.Universal.DebugRenderSetup> CreateDebugRenderSetupEnumerable(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.FilteringSettings filteringSettings);
                /*0x136a7a0*/ void DrawWithDebugRenderState(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock, UnityEngine.Rendering.Universal.DebugHandler.DrawFunction func);

                class DebugRenderPassEnumerable : System.Collections.Generic.IEnumerable<UnityEngine.Rendering.Universal.DebugRenderSetup>, System.Collections.IEnumerable
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.DebugHandler m_DebugHandler;
                    /*0x18*/ UnityEngine.Rendering.ScriptableRenderContext m_Context;
                    /*0x20*/ UnityEngine.Rendering.CommandBuffer m_CommandBuffer;
                    /*0x28*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;

                    /*0x136c5e0*/ DebugRenderPassEnumerable(UnityEngine.Rendering.Universal.DebugHandler debugHandler, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.FilteringSettings filteringSettings);
                    /*0x136c4e0*/ System.Collections.Generic.IEnumerator<UnityEngine.Rendering.Universal.DebugRenderSetup> GetEnumerator();
                    /*0x136c4e0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

                    class Enumerator : System.Collections.Generic.IEnumerator<UnityEngine.Rendering.Universal.DebugRenderSetup>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.DebugHandler m_DebugHandler;
                        /*0x18*/ UnityEngine.Rendering.ScriptableRenderContext m_Context;
                        /*0x20*/ UnityEngine.Rendering.CommandBuffer m_CommandBuffer;
                        /*0x28*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                        /*0x40*/ int m_NumIterations;
                        /*0x44*/ int m_Index;
                        /*0x48*/ UnityEngine.Rendering.Universal.DebugRenderSetup <Current>k__BackingField;

                        /*0x136f400*/ Enumerator(UnityEngine.Rendering.Universal.DebugHandler debugHandler, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer commandBuffer, UnityEngine.Rendering.FilteringSettings filteringSettings);
                        /*0x4e40d0*/ UnityEngine.Rendering.Universal.DebugRenderSetup get_Current();
                        /*0x4e4360*/ void set_Current(UnityEngine.Rendering.Universal.DebugRenderSetup value);
                        /*0x4e40d0*/ object System.Collections.IEnumerator.get_Current();
                        /*0x136f1c0*/ bool MoveNext();
                        /*0x136f3b0*/ void Reset();
                        /*0x136f1a0*/ void Dispose();
                    }
                }

                class DrawFunction : System.MulticastDelegate
                {
                    /*0x136efe0*/ DrawFunction(object object, nint method);
                    /*0x723cc0*/ void Invoke(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                    /*0x136ee90*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock, System.AsyncCallback callback, object object);
                    /*0x136efa0*/ void EndInvoke(ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.DrawingSettings drawingSettings, ref UnityEngine.Rendering.FilteringSettings filteringSettings, ref UnityEngine.Rendering.RenderStateBlock renderStateBlock, System.IAsyncResult result);
                }
            }

            class DebugRenderSetup : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DebugHandler m_DebugHandler;
                /*0x18*/ UnityEngine.Rendering.ScriptableRenderContext m_Context;
                /*0x20*/ UnityEngine.Rendering.CommandBuffer m_CommandBuffer;
                /*0x28*/ int m_Index;
                /*0x2c*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;

                /*0x136ce30*/ DebugRenderSetup(UnityEngine.Rendering.Universal.DebugHandler debugHandler, UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer commandBuffer, int index, UnityEngine.Rendering.FilteringSettings filteringSettings);
                /*0x136cfc0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial get_MaterialSettings();
                /*0x136cff0*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering get_RenderingSettings();
                /*0x136cf90*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting get_LightingSettings();
                /*0x136c660*/ void Begin();
                /*0x136c9b0*/ void End();
                /*0x136c750*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.DrawingSettings drawingSettings);
                /*0x136ca50*/ UnityEngine.Rendering.RenderStateBlock GetRenderStateBlock(UnityEngine.Rendering.RenderStateBlock renderStateBlock);
                /*0x136c9b0*/ void Dispose();
            }

            class UniversalRenderPipelineDebugDisplaySettings : UnityEngine.Rendering.DebugDisplaySettings<UnityEngine.Rendering.Universal.UniversalRenderPipelineDebugDisplaySettings>
            {
                /*0x18*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon <commonSettings>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial <materialSettings>k__BackingField;
                /*0x28*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering <renderingSettings>k__BackingField;
                /*0x30*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting <lightingSettings>k__BackingField;
                /*0x38*/ UnityEngine.Rendering.DebugDisplaySettingsVolume <volumeSettings>k__BackingField;
                /*0x40*/ UnityEngine.Rendering.Universal.DebugDisplayStats <displayStats>k__BackingField;

                /*0x137e260*/ UniversalRenderPipelineDebugDisplaySettings();
                /*0x32f410*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon get_commonSettings();
                /*0x7963c0*/ void set_commonSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsCommon value);
                /*0x61a260*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial get_materialSettings();
                /*0x7965a0*/ void set_materialSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsMaterial value);
                /*0x79a150*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering get_renderingSettings();
                /*0x98b030*/ void set_renderingSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsRendering value);
                /*0x997630*/ UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting get_lightingSettings();
                /*0x997640*/ void set_lightingSettings(UnityEngine.Rendering.Universal.DebugDisplaySettingsLighting value);
                /*0x995140*/ UnityEngine.Rendering.DebugDisplaySettingsVolume get_volumeSettings();
                /*0xe5a080*/ void set_volumeSettings(UnityEngine.Rendering.DebugDisplaySettingsVolume value);
                /*0xb61870*/ UnityEngine.Rendering.Universal.DebugDisplayStats get_displayStats();
                /*0xcf6cd0*/ void set_displayStats(UnityEngine.Rendering.Universal.DebugDisplayStats value);
                /*0x137e2e0*/ bool get_IsPostProcessingAllowed();
                /*0x137df10*/ void Reset();
                /*0x137e230*/ void UpdateFrameTiming();
            }

            class UniversalRenderPipelineVolumeDebugSettings : UnityEngine.Rendering.VolumeDebugSettings<UnityEngine.Rendering.Universal.UniversalAdditionalCameraData>
            {
                /*0x137e570*/ UniversalRenderPipelineVolumeDebugSettings();
                /*0x137e870*/ System.Type get_targetRenderPipeline();
                /*0x137e760*/ UnityEngine.Rendering.VolumeStack get_selectedCameraVolumeStack();
                /*0x137e5d0*/ UnityEngine.LayerMask get_selectedCameraLayerMask();
                /*0x137e680*/ UnityEngine.Vector3 get_selectedCameraPosition();
            }

            class DecalDrawDBufferSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x136d040*/ DecalDrawDBufferSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x136d020*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DBufferRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static /*0x0*/ string[] s_DBufferNames;
                static /*0x8*/ string s_DBufferDepthName;
                /*0xe0*/ UnityEngine.Rendering.Universal.DecalDrawDBufferSystem m_DrawSystem;
                /*0xe8*/ UnityEngine.Rendering.Universal.DBufferSettings m_Settings;
                /*0xf0*/ UnityEngine.Material m_DBufferClear;
                /*0xf8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0x110*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0x118*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0x120*/ UnityEngine.Rendering.ProfilingSampler m_DBufferClearSampler;
                /*0x128*/ bool m_DecalLayers;
                /*0x130*/ UnityEngine.Rendering.RTHandle m_DBufferDepth;
                /*0x138*/ UnityEngine.Rendering.RTHandle[] <dBufferColorHandles>k__BackingField;
                /*0x140*/ UnityEngine.Rendering.RTHandle <depthHandle>k__BackingField;

                static /*0x1368f90*/ DBufferRenderPass();
                /*0x1369100*/ DBufferRenderPass(UnityEngine.Material dBufferClear, UnityEngine.Rendering.Universal.DBufferSettings settings, UnityEngine.Rendering.Universal.DecalDrawDBufferSystem drawSystem, bool decalLayers);
                /*0x1369450*/ UnityEngine.Rendering.RTHandle[] get_dBufferColorHandles();
                /*0x1369480*/ void set_dBufferColorHandles(UnityEngine.Rendering.RTHandle[] value);
                /*0x1369470*/ UnityEngine.Rendering.RTHandle get_depthHandle();
                /*0x13694a0*/ void set_depthHandle(UnityEngine.Rendering.RTHandle value);
                /*0x1369460*/ UnityEngine.Rendering.RTHandle get_dBufferDepth();
                /*0x1368230*/ void Dispose();
                /*0x1368e50*/ void Setup(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x1368a40*/ void Setup(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.RTHandle depthTextureHandle);
                /*0x1368a20*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13682b0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x1368900*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
            }

            class DecalDrawFowardEmissiveSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x136d1e0*/ DecalDrawFowardEmissiveSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x136d1c0*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DecalForwardEmissivePass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xe0*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xf8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0x100*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0x108*/ UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem m_DrawSystem;

                /*0x136d460*/ DecalForwardEmissivePass(UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem drawSystem);
                /*0x136d250*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            class DecalDrawErrorSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x40*/ UnityEngine.Rendering.Universal.DecalTechnique m_Technique;

                /*0x136d140*/ DecalDrawErrorSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager, UnityEngine.Rendering.Universal.DecalTechnique technique);
                /*0x136d0d0*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
                /*0x136d0b0*/ UnityEngine.Material GetMaterial(UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk);
            }

            class DecalPreviewPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xe0*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xf8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0x100*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;

                /*0x136d8e0*/ DecalPreviewPass();
                /*0x136d6f0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            enum DecalScaleMode
            {
                ScaleInvariant = 0,
                InheritFromHierarchy = 1,
            }

            class DecalProjector : UnityEngine.MonoBehaviour
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction onDecalAdd;
                static /*0x8*/ UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction onDecalRemove;
                static /*0x10*/ UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction onDecalPropertyChange;
                static /*0x18*/ System.Action onAllDecalPropertyChange;
                static /*0x20*/ UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction onDecalMaterialChange;
                static /*0x28*/ UnityEngine.Material <defaultMaterial>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.Universal.DecalEntity <decalEntity>k__BackingField;
                /*0x28*/ UnityEngine.Material m_Material;
                /*0x30*/ float m_DrawDistance;
                /*0x34*/ float m_FadeScale;
                /*0x38*/ float m_StartAngleFade;
                /*0x3c*/ float m_EndAngleFade;
                /*0x40*/ UnityEngine.Vector2 m_UVScale;
                /*0x48*/ UnityEngine.Vector2 m_UVBias;
                /*0x50*/ uint m_DecalLayerMask;
                /*0x54*/ UnityEngine.Rendering.Universal.DecalScaleMode m_ScaleMode;
                /*0x58*/ UnityEngine.Vector3 m_Offset;
                /*0x64*/ UnityEngine.Vector3 m_Size;
                /*0x70*/ float m_FadeFactor;
                /*0x78*/ UnityEngine.Material m_OldMaterial;
                /*0x80*/ float m_OldDrawDistance;
                /*0x84*/ float m_OldFadeScale;
                /*0x88*/ float m_OldStartAngleFade;
                /*0x8c*/ float m_OldEndAngleFade;
                /*0x90*/ UnityEngine.Vector2 m_OldUVScale;
                /*0x98*/ UnityEngine.Vector2 m_OldUVBias;
                /*0xa0*/ UnityEngine.Rendering.Universal.DecalScaleMode m_OldScaleMode;
                /*0xa4*/ UnityEngine.Vector3 m_OldOffset;
                /*0xb0*/ UnityEngine.Vector3 m_OldSize;
                /*0xbc*/ float m_OldFadeFactor;

                static /*0x136e390*/ void add_onDecalAdd(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x136e970*/ void remove_onDecalAdd(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x136e5d0*/ void add_onDecalRemove(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x136ebb0*/ void remove_onDecalRemove(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x136e510*/ void add_onDecalPropertyChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x136eaf0*/ void remove_onDecalPropertyChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x136e2d0*/ void add_onAllDecalPropertyChange(System.Action value);
                static /*0x136e8b0*/ void remove_onAllDecalPropertyChange(System.Action value);
                static /*0x136e450*/ void add_onDecalMaterialChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x136ea30*/ void remove_onDecalMaterialChange(UnityEngine.Rendering.Universal.DecalProjector.DecalProjectorAction value);
                static /*0x136e6d0*/ UnityEngine.Material get_defaultMaterial();
                static /*0x136ec70*/ void set_defaultMaterial(UnityEngine.Material value);
                static /*0x136e7b0*/ bool get_isSupported();
                static /*0x136e190*/ void UpdateAllDecalProperties();
                /*0x136e1e0*/ DecalProjector();
                /*0x61a260*/ UnityEngine.Rendering.Universal.DecalEntity get_decalEntity();
                /*0x10cb140*/ void set_decalEntity(UnityEngine.Rendering.Universal.DecalEntity value);
                /*0x79a150*/ UnityEngine.Material get_material();
                /*0x136eda0*/ void set_material(UnityEngine.Material value);
                /*0x1101d20*/ float get_drawDistance();
                /*0x136ecd0*/ void set_drawDistance(float value);
                /*0x995150*/ float get_fadeScale();
                /*0x136ed60*/ void set_fadeScale(float value);
                /*0x136e840*/ float get_startAngleFade();
                /*0x136ee30*/ void set_startAngleFade(float value);
                /*0x129f7b0*/ float get_endAngleFade();
                /*0x136ecf0*/ void set_endAngleFade(float value);
                /*0x136e890*/ UnityEngine.Vector2 get_uvScale();
                /*0x136ee80*/ void set_uvScale(UnityEngine.Vector2 value);
                /*0x136e850*/ UnityEngine.Vector2 get_uvBias();
                /*0x136ee70*/ void set_uvBias(UnityEngine.Vector2 value);
                /*0xc70ac0*/ uint get_renderingLayerMask();
                /*0x136edf0*/ void set_renderingLayerMask(uint value);
                /*0x136e810*/ UnityEngine.Rendering.Universal.DecalScaleMode get_scaleMode();
                /*0x136ee00*/ void set_scaleMode(UnityEngine.Rendering.Universal.DecalScaleMode value);
                /*0x136e7f0*/ UnityEngine.Vector3 get_pivot();
                /*0x136edd0*/ void set_pivot(UnityEngine.Vector3 value);
                /*0x136e820*/ UnityEngine.Vector3 get_size();
                /*0x136ee10*/ void set_size(UnityEngine.Vector3 value);
                /*0x136e7a0*/ float get_fadeFactor();
                /*0x136ed20*/ void set_fadeFactor(float value);
                /*0x136e710*/ UnityEngine.Vector3 get_effectiveScale();
                /*0x136e6b0*/ UnityEngine.Vector3 get_decalSize();
                /*0x136e690*/ UnityEngine.Vector3 get_decalOffset();
                /*0x136e870*/ UnityEngine.Vector4 get_uvScaleBias();
                /*0x136db50*/ void InitMaterial();
                /*0x136df70*/ void OnEnable();
                /*0x136df10*/ void OnDisable();
                /*0x136e020*/ void OnValidate();
                /*0x136dcc0*/ void OnDidApplyAnimationProperties();
                /*0x136dba0*/ bool IsValid();

                class DecalProjectorAction : System.MulticastDelegate
                {
                    /*0xcf9550*/ DecalProjectorAction(object object, nint method);
                    /*0x720980*/ void Invoke(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                    /*0xe29290*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.Universal.DecalProjector decalProjector, System.AsyncCallback callback, object object);
                    /*0x723cb0*/ void EndInvoke(System.IAsyncResult result);
                }
            }

            class DecalShaderPassNames
            {
                static string DecalPreview = "DecalPreview";
                static string DBufferProjector = "DBufferProjector";
                static string DecalProjectorForwardEmissive = "DecalProjectorForwardEmissive";
                static string DecalScreenSpaceProjector = "DecalScreenSpaceProjector";
                static string DecalGBufferProjector = "DecalGBufferProjector";
                static string DBufferMesh = "DBufferMesh";
                static string DecalMeshForwardEmissive = "DecalMeshForwardEmissive";
                static string DecalScreenSpaceMesh = "DecalScreenSpaceMesh";
                static string DecalGBufferMesh = "DecalGBufferMesh";
            }

            class DecalChunk : System.IDisposable
            {
                /*0x10*/ int <count>k__BackingField;
                /*0x14*/ int <capacity>k__BackingField;
                /*0x18*/ Unity.Jobs.JobHandle <currentJobHandle>k__BackingField;

                /*0x32f970*/ DecalChunk();
                /*0x417e30*/ int get_count();
                /*0xdcd9c0*/ void set_count(int value);
                /*0x70a440*/ int get_capacity();
                /*0xc70b20*/ void set_capacity(int value);
                /*0x716050*/ Unity.Jobs.JobHandle get_currentJobHandle();
                /*0xdd5220*/ void set_currentJobHandle(Unity.Jobs.JobHandle value);
                /*0xc43cf0*/ void Push();
                /*0x17aa40*/ void RemoveAtSwapBack(int index);
                /*0x17aa40*/ void SetCapacity(int capacity);
                /*0x32d010*/ void Dispose();
                /*0x1383400*/ void ResizeNativeArray(ref UnityEngine.Jobs.TransformAccessArray array, UnityEngine.Rendering.Universal.DecalProjector[] decalProjectors, int capacity);
                void RemoveAtSwapBack<T>(ref Unity.Collections.NativeArray<T> array, int index, int count);
                void RemoveAtSwapBack<T>(ref T[] array, int index, int count);
            }

            struct DecalSubDrawCall
            {
                /*0x10*/ int start;
                /*0x14*/ int end;

                /*0x138ac10*/ int get_count();
            }

            class DecalDrawCallChunk : UnityEngine.Rendering.Universal.DecalChunk
            {
                /*0x28*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorlds;
                /*0x38*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToDecals;
                /*0x48*/ Unity.Collections.NativeArray<float> renderingLayerMasks;
                /*0x58*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalSubDrawCall> subCalls;
                /*0x68*/ Unity.Collections.NativeArray<int> subCallCounts;

                /*0x32f970*/ DecalDrawCallChunk();
                /*0x1383fc0*/ void set_subCallCount(int value);
                /*0x1383fb0*/ int get_subCallCount();
                /*0x1383e40*/ void RemoveAtSwapBack(int entityIndex);
                /*0x1383f10*/ void SetCapacity(int newCapacity);
                /*0x1383d90*/ void Dispose();
            }

            class DecalCreateDrawCallSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x20*/ float m_MaxDrawDistance;

                /*0x1383b20*/ DecalCreateDrawCallSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager, float maxDrawDistance);
                /*0x129f790*/ float get_maxDrawDistance();
                /*0x136a080*/ void set_maxDrawDistance(float value);
                /*0x13834d0*/ void Execute();
                /*0x13838f0*/ void Execute(UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk, UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk drawCallChunk, int count);

                struct DrawCallJob : Unity.Jobs.IJob
                {
                    /*0x10*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorlds;
                    /*0x20*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToWorlds;
                    /*0x30*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> sizeOffsets;
                    /*0x40*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> drawDistances;
                    /*0x50*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> angleFades;
                    /*0x60*/ Unity.Collections.NativeArray<Unity.Mathematics.float4> uvScaleBiases;
                    /*0x70*/ Unity.Collections.NativeArray<int> layerMasks;
                    /*0x80*/ Unity.Collections.NativeArray<ulong> sceneLayerMasks;
                    /*0x90*/ Unity.Collections.NativeArray<float> fadeFactors;
                    /*0xa0*/ Unity.Collections.NativeArray<UnityEngine.BoundingSphere> boundingSpheres;
                    /*0xb0*/ Unity.Collections.NativeArray<uint> renderingLayerMasks;
                    /*0xc0*/ UnityEngine.Vector3 cameraPosition;
                    /*0xd0*/ ulong sceneCullingMask;
                    /*0xd8*/ int cullingMask;
                    /*0xe0*/ Unity.Collections.NativeArray<int> visibleDecalIndices;
                    /*0xf0*/ int visibleDecalCount;
                    /*0xf4*/ float maxDrawDistance;
                    /*0xf8*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorldsDraw;
                    /*0x108*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToDecalsDraw;
                    /*0x118*/ Unity.Collections.NativeArray<float> renderingLayerMasksDraw;
                    /*0x128*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalSubDrawCall> subCalls;
                    /*0x138*/ Unity.Collections.NativeArray<int> subCallCount;

                    /*0x138ba60*/ void Execute();
                }
            }

            class DecalDrawSystem
            {
                static /*0x0*/ uint MaxBatchSize;
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Matrix4x4[] m_WorldToDecals;
                /*0x20*/ UnityEngine.Matrix4x4[] m_NormalToDecals;
                /*0x28*/ float[] m_DecalLayerMasks;
                /*0x30*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x38*/ UnityEngine.Material <overrideMaterial>k__BackingField;

                static /*0x1385700*/ DecalDrawSystem();
                /*0x1385740*/ DecalDrawSystem(string sampler, UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x995140*/ UnityEngine.Material get_overrideMaterial();
                /*0xe5a080*/ void set_overrideMaterial(UnityEngine.Material value);
                /*0x1384d70*/ void Execute(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x13856e0*/ UnityEngine.Material GetMaterial(UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk);
                /*0x17b580*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
                /*0x1385540*/ void Execute(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int count);
                /*0x1384ab0*/ void Draw(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int passIndex);
                /*0x1384450*/ void DrawInstanced(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int passIndex);
                /*0x1385220*/ void Execute(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x13850a0*/ void Execute(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk, int count);
                /*0x1384760*/ void Draw(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk);
                /*0x13840f0*/ void DrawInstanced(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.DecalEntityChunk decalEntityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk, UnityEngine.Rendering.Universal.DecalDrawCallChunk decalDrawCallChunk);
            }

            class DecalEntityIndexer
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalEntityIndexer.DecalEntityItem> m_Entities;
                /*0x18*/ System.Collections.Generic.Queue<int> m_FreeIndices;

                /*0x1386120*/ DecalEntityIndexer();
                /*0x1385e80*/ bool IsValid(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x1385b50*/ UnityEngine.Rendering.Universal.DecalEntity CreateDecalEntity(int arrayIndex, int chunkIndex);
                /*0x1385d40*/ void DestroyDecalEntity(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x1385e00*/ UnityEngine.Rendering.Universal.DecalEntityIndexer.DecalEntityItem GetItem(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x1386060*/ void UpdateIndex(UnityEngine.Rendering.Universal.DecalEntity decalEntity, int newArrayIndex);
                /*0x1385f10*/ void RemapChunkIndices(System.Collections.Generic.List<int> remaper);
                /*0x1385ae0*/ void Clear();

                struct DecalEntityItem
                {
                    /*0x10*/ int chunkIndex;
                    /*0x14*/ int arrayIndex;
                    /*0x18*/ int version;
                }
            }

            struct DecalEntity
            {
                /*0x10*/ int index;
                /*0x14*/ int version;
            }

            class DecalEntityChunk : UnityEngine.Rendering.Universal.DecalChunk
            {
                /*0x28*/ UnityEngine.Material material;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalEntity> decalEntities;
                /*0x40*/ UnityEngine.Rendering.Universal.DecalProjector[] decalProjectors;
                /*0x48*/ UnityEngine.Jobs.TransformAccessArray transformAccessArray;

                /*0x32f970*/ DecalEntityChunk();
                /*0xc43cf0*/ void Push();
                /*0x1385900*/ void RemoveAtSwapBack(int entityIndex);
                /*0x13859a0*/ void SetCapacity(int newCapacity);
                /*0x1385890*/ void Dispose();
            }

            class DecalEntityManager : System.IDisposable
            {
                /*0x10*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalEntityChunk> entityChunks;
                /*0x18*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalCachedChunk> cachedChunks;
                /*0x20*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalCulledChunk> culledChunks;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalDrawCallChunk> drawCallChunks;
                /*0x30*/ int chunkCount;
                /*0x38*/ UnityEngine.Rendering.ProfilingSampler m_AddDecalSampler;
                /*0x40*/ UnityEngine.Rendering.ProfilingSampler m_ResizeChunks;
                /*0x48*/ UnityEngine.Rendering.ProfilingSampler m_SortChunks;
                /*0x50*/ UnityEngine.Rendering.Universal.DecalEntityIndexer m_DecalEntityIndexer;
                /*0x58*/ System.Collections.Generic.Dictionary<UnityEngine.Material, int> m_MaterialToChunkIndex;
                /*0x60*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks> m_CombinedChunks;
                /*0x68*/ System.Collections.Generic.List<int> m_CombinedChunkRemmap;
                /*0x70*/ UnityEngine.Material m_ErrorMaterial;
                /*0x78*/ UnityEngine.Mesh m_DecalProjectorMesh;

                /*0x1388c70*/ DecalEntityManager();
                /*0x1389120*/ UnityEngine.Material get_errorMaterial();
                /*0x1389030*/ UnityEngine.Mesh get_decalProjectorMesh();
                /*0x1387a60*/ bool IsValid(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x13867e0*/ UnityEngine.Rendering.Universal.DecalEntity CreateDecalEntity(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x13861e0*/ int CreateChunkIndex(UnityEngine.Material material);
                /*0x1387a80*/ void UpdateAllDecalEntitiesData();
                /*0x1387c50*/ void UpdateDecalEntityData(UnityEngine.Rendering.Universal.DecalEntity decalEntity, UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x1386d70*/ void DestroyDecalEntity(UnityEngine.Rendering.Universal.DecalEntity decalEntity);
                /*0x13881c0*/ void Update();
                /*0x13870e0*/ void Dispose();

                struct CombinedChunks
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityChunk entityChunk;
                    /*0x18*/ UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk;
                    /*0x20*/ UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk;
                    /*0x28*/ UnityEngine.Rendering.Universal.DecalDrawCallChunk drawCallChunk;
                    /*0x30*/ int previousChunkIndex;
                    /*0x34*/ bool valid;
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DecalEntityManager.<> <>9;
                    static /*0x8*/ System.Comparison<UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks> <>9__26_0;

                    static /*0x139f160*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x139f030*/ int <Update>b__26_0(UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks a, UnityEngine.Rendering.Universal.DecalEntityManager.CombinedChunks b);
                }
            }

            class DecalSkipCulledSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x20*/ UnityEngine.Camera m_Camera;

                static /*0x388e90*/ ulong GetSceneCullingMaskFromCamera(UnityEngine.Camera camera);
                /*0x138ab80*/ DecalSkipCulledSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x138a8a0*/ void Execute(UnityEngine.Camera camera);
                /*0x138aab0*/ void Execute(UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, int count);
            }

            class DecalCachedChunk : UnityEngine.Rendering.Universal.DecalChunk
            {
                /*0x28*/ UnityEngine.MaterialPropertyBlock propertyBlock;
                /*0x30*/ int passIndexDBuffer;
                /*0x34*/ int passIndexEmissive;
                /*0x38*/ int passIndexScreenSpace;
                /*0x3c*/ int passIndexGBuffer;
                /*0x40*/ int drawOrder;
                /*0x44*/ bool isCreated;
                /*0x48*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorlds;
                /*0x58*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToWorlds;
                /*0x68*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> sizeOffsets;
                /*0x78*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> drawDistances;
                /*0x88*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> angleFades;
                /*0x98*/ Unity.Collections.NativeArray<Unity.Mathematics.float4> uvScaleBias;
                /*0xa8*/ Unity.Collections.NativeArray<int> layerMasks;
                /*0xb8*/ Unity.Collections.NativeArray<ulong> sceneLayerMasks;
                /*0xc8*/ Unity.Collections.NativeArray<float> fadeFactors;
                /*0xd8*/ Unity.Collections.NativeArray<UnityEngine.BoundingSphere> boundingSpheres;
                /*0xe8*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalScaleMode> scaleModes;
                /*0xf8*/ Unity.Collections.NativeArray<uint> renderingLayerMasks;
                /*0x108*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;
                /*0x118*/ Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotation;
                /*0x128*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> scales;
                /*0x138*/ Unity.Collections.NativeArray<bool> dirty;
                /*0x148*/ UnityEngine.BoundingSphere[] boundingSphereArray;

                /*0x32f970*/ DecalCachedChunk();
                /*0x1382ec0*/ void RemoveAtSwapBack(int entityIndex);
                /*0x13831d0*/ void SetCapacity(int newCapacity);
                /*0x1382cd0*/ void Dispose();
            }

            class DecalUpdateCachedSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;
                /*0x20*/ UnityEngine.Rendering.ProfilingSampler m_SamplerJob;

                /*0x138b090*/ DecalUpdateCachedSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x138af10*/ void Execute();
                /*0x138ac20*/ void Execute(UnityEngine.Rendering.Universal.DecalEntityChunk entityChunk, UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk, int count);

                struct UpdateTransformsJob : UnityEngine.Jobs.IJobParallelForTransform
                {
                    static /*0x0*/ Unity.Mathematics.quaternion k_MinusYtoZRotation;
                    /*0x10*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> positions;
                    /*0x20*/ Unity.Collections.NativeArray<Unity.Mathematics.quaternion> rotations;
                    /*0x30*/ Unity.Collections.NativeArray<Unity.Mathematics.float3> scales;
                    /*0x40*/ Unity.Collections.NativeArray<bool> dirty;
                    /*0x50*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.DecalScaleMode> scaleModes;
                    /*0x60*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> sizeOffsets;
                    /*0x70*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> decalToWorlds;
                    /*0x80*/ Unity.Collections.NativeArray<Unity.Mathematics.float4x4> normalToWorlds;
                    /*0x90*/ Unity.Collections.NativeArray<UnityEngine.BoundingSphere> boundingSpheres;
                    /*0xa0*/ float minDistance;

                    static /*0x139fd80*/ UpdateTransformsJob();
                    /*0x139f1d0*/ float DistanceBetweenQuaternions(Unity.Mathematics.quaternion a, Unity.Mathematics.quaternion b);
                    /*0x139f230*/ void Execute(int index, UnityEngine.Jobs.TransformAccess transform);
                    /*0x139faf0*/ UnityEngine.BoundingSphere GetDecalProjectBoundingSphere(UnityEngine.Matrix4x4 decalToWorld);
                }
            }

            class DecalUpdateCulledSystem
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;

                /*0x138b3d0*/ DecalUpdateCulledSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x138b160*/ void Execute();
                /*0x138b330*/ void Execute(UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, int count);
            }

            class DecalCulledChunk : UnityEngine.Rendering.Universal.DecalChunk
            {
                /*0x28*/ UnityEngine.Vector3 cameraPosition;
                /*0x38*/ ulong sceneCullingMask;
                /*0x40*/ int cullingMask;
                /*0x48*/ UnityEngine.CullingGroup cullingGroups;
                /*0x50*/ int[] visibleDecalIndexArray;
                /*0x58*/ Unity.Collections.NativeArray<int> visibleDecalIndices;
                /*0x68*/ int visibleDecalCount;

                /*0x32f970*/ DecalCulledChunk();
                /*0x1383c50*/ void RemoveAtSwapBack(int entityIndex);
                /*0x1383ce0*/ void SetCapacity(int newCapacity);
                /*0x1383bc0*/ void Dispose();
            }

            class DecalUpdateCullingGroupSystem
            {
                /*0x10*/ float[] m_BoundingDistance;
                /*0x18*/ UnityEngine.Camera m_Camera;
                /*0x20*/ UnityEngine.Rendering.Universal.DecalEntityManager m_EntityManager;
                /*0x28*/ UnityEngine.Rendering.ProfilingSampler m_Sampler;

                static /*0x388e90*/ ulong GetSceneCullingMaskFromCamera(UnityEngine.Camera camera);
                /*0x138b910*/ DecalUpdateCullingGroupSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager, float drawDistance);
                /*0x138ba00*/ float get_boundingDistance();
                /*0x138ba30*/ void set_boundingDistance(float value);
                /*0x138b460*/ void Execute(UnityEngine.Camera camera);
                /*0x138b780*/ void Execute(UnityEngine.Rendering.Universal.DecalCachedChunk cachedChunk, UnityEngine.Rendering.Universal.DecalCulledChunk culledChunk, int count);
            }

            class DecalDrawGBufferSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x1383ff0*/ DecalDrawGBufferSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x1383fd0*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DecalGBufferRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xe0*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xf8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0x100*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0x108*/ UnityEngine.Rendering.Universal.DecalDrawGBufferSystem m_DrawSystem;
                /*0x110*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings m_Settings;
                /*0x118*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;
                /*0x120*/ UnityEngine.Rendering.RTHandle[] m_GbufferAttachments;
                /*0x128*/ bool m_DecalLayers;

                /*0x1389d10*/ DecalGBufferRenderPass(UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings, UnityEngine.Rendering.Universal.DecalDrawGBufferSystem drawSystem, bool decalLayers);
                /*0x134cc40*/ void Setup(UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights);
                /*0x13891e0*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                /*0x1389880*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x1389bf0*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
            }

            class DecalDrawScreenSpaceSystem : UnityEngine.Rendering.Universal.DecalDrawSystem
            {
                /*0x1384080*/ DecalDrawScreenSpaceSystem(UnityEngine.Rendering.Universal.DecalEntityManager entityManager);
                /*0x1384060*/ int GetPassIndex(UnityEngine.Rendering.Universal.DecalCachedChunk decalCachedChunk);
            }

            class DecalScreenSpaceRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xe0*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0xf8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0x100*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                /*0x108*/ UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem m_DrawSystem;
                /*0x110*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings m_Settings;
                /*0x118*/ bool m_DecalLayers;

                /*0x138a580*/ DecalScreenSpaceRenderPass(UnityEngine.Rendering.Universal.DecalScreenSpaceSettings settings, UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem drawSystem, bool decalLayers);
                /*0x138a070*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x138a460*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
            }

            class ScriptableRenderPass
            {
                static /*0x0*/ UnityEngine.Rendering.RTHandle k_CameraTarget;
                /*0x10*/ UnityEngine.Rendering.Universal.RenderPassEvent <renderPassEvent>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.RenderBufferStoreAction[] m_ColorStoreActions;
                /*0x20*/ UnityEngine.Rendering.RenderBufferStoreAction m_DepthStoreAction;
                /*0x28*/ bool[] m_OverriddenColorStoreActions;
                /*0x30*/ bool m_OverriddenDepthStoreAction;
                /*0x38*/ UnityEngine.Rendering.ProfilingSampler <profilingSampler>k__BackingField;
                /*0x40*/ bool <overrideCameraTarget>k__BackingField;
                /*0x41*/ bool <isBlitRenderPass>k__BackingField;
                /*0x42*/ bool <useNativeRenderPass>k__BackingField;
                /*0x44*/ int <renderPassQueueIndex>k__BackingField;
                /*0x48*/ Unity.Collections.NativeArray<int> m_ColorAttachmentIndices;
                /*0x58*/ Unity.Collections.NativeArray<int> m_InputAttachmentIndices;
                /*0x68*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] <renderTargetFormat>k__BackingField;
                /*0x70*/ bool m_UsesRTHandles;
                /*0x78*/ UnityEngine.Rendering.RTHandle[] m_ColorAttachments;
                /*0x80*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_ColorAttachmentIds;
                /*0x88*/ UnityEngine.Rendering.RTHandle[] m_InputAttachments;
                /*0x90*/ bool[] m_InputAttachmentIsTransient;
                /*0x98*/ UnityEngine.Rendering.RTHandle m_DepthAttachment;
                /*0xa0*/ UnityEngine.Rendering.RenderTargetIdentifier m_DepthAttachmentId;
                /*0xc8*/ UnityEngine.Rendering.Universal.ScriptableRenderPassInput m_Input;
                /*0xcc*/ UnityEngine.Rendering.ClearFlag m_ClearFlag;
                /*0xd0*/ UnityEngine.Color m_ClearColor;

                static /*0x138dcd0*/ ScriptableRenderPass();
                static /*0x138d860*/ UnityEngine.Rendering.Universal.DebugHandler GetActiveDebugHandler(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x138e490*/ bool op_LessThan(UnityEngine.Rendering.Universal.ScriptableRenderPass lhs, UnityEngine.Rendering.Universal.ScriptableRenderPass rhs);
                static /*0x138e460*/ bool op_GreaterThan(UnityEngine.Rendering.Universal.ScriptableRenderPass lhs, UnityEngine.Rendering.Universal.ScriptableRenderPass rhs);
                static /*0x138d8b0*/ int GetRenderPassEventRange(UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent);
                /*0x138dda0*/ ScriptableRenderPass();
                /*0x138d840*/ void FrameCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x417e30*/ UnityEngine.Rendering.Universal.RenderPassEvent get_renderPassEvent();
                /*0xdcd9c0*/ void set_renderPassEvent(UnityEngine.Rendering.Universal.RenderPassEvent value);
                /*0xeeac90*/ UnityEngine.Rendering.RenderTargetIdentifier[] get_colorAttachments();
                /*0x138e360*/ UnityEngine.Rendering.RenderTargetIdentifier get_colorAttachment();
                /*0x138e3b0*/ UnityEngine.Rendering.RenderTargetIdentifier get_depthAttachment();
                /*0xecb7b0*/ UnityEngine.Rendering.RTHandle[] get_colorAttachmentHandles();
                /*0x138e330*/ UnityEngine.Rendering.RTHandle get_colorAttachmentHandle();
                /*0x9c7a50*/ UnityEngine.Rendering.RTHandle get_depthAttachmentHandle();
                /*0x32f410*/ UnityEngine.Rendering.RenderBufferStoreAction[] get_colorStoreActions();
                /*0x3e3af0*/ UnityEngine.Rendering.RenderBufferStoreAction get_depthStoreAction();
                /*0x79a150*/ bool[] get_overriddenColorStoreActions();
                /*0x995050*/ bool get_overriddenDepthStoreAction();
                /*0xeeac80*/ UnityEngine.Rendering.Universal.ScriptableRenderPassInput get_input();
                /*0x138e320*/ UnityEngine.Rendering.ClearFlag get_clearFlag();
                /*0x13551b0*/ UnityEngine.Color get_clearColor();
                /*0x995140*/ UnityEngine.Rendering.ProfilingSampler get_profilingSampler();
                /*0xe5a080*/ void set_profilingSampler(UnityEngine.Rendering.ProfilingSampler value);
                /*0xb61dd0*/ bool get_overrideCameraTarget();
                /*0xb61de0*/ void set_overrideCameraTarget(bool value);
                /*0xf17ee0*/ bool get_isBlitRenderPass();
                /*0x138e4c0*/ void set_isBlitRenderPass(bool value);
                /*0x133a5d0*/ bool get_useNativeRenderPass();
                /*0x133a600*/ void set_useNativeRenderPass(bool value);
                /*0x10eed50*/ int get_renderPassQueueIndex();
                /*0x10eed60*/ void set_renderPassQueueIndex(int value);
                /*0x8af030*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] get_renderTargetFormat();
                /*0xe69480*/ void set_renderTargetFormat(UnityEngine.Experimental.Rendering.GraphicsFormat[] value);
                /*0x138c8e0*/ void ConfigureInput(UnityEngine.Rendering.Universal.ScriptableRenderPassInput passInput);
                /*0x138c6c0*/ void ConfigureColorStoreAction(UnityEngine.Rendering.RenderBufferStoreAction storeAction, uint attachmentIndex);
                /*0x138c710*/ void ConfigureColorStoreActions(UnityEngine.Rendering.RenderBufferStoreAction[] storeActions);
                /*0x138c7e0*/ void ConfigureDepthStoreAction(UnityEngine.Rendering.RenderBufferStoreAction storeAction);
                /*0x138c7f0*/ void ConfigureInputAttachments(UnityEngine.Rendering.RTHandle input, bool isTransient);
                /*0x737e30*/ void ConfigureInputAttachments(UnityEngine.Rendering.RTHandle[] inputs);
                /*0x138c890*/ void ConfigureInputAttachments(UnityEngine.Rendering.RTHandle[] inputs, bool[] isTransient);
                /*0x138dca0*/ void SetInputAttachmentTransient(int idx, bool isTransient);
                /*0x138da10*/ bool IsInputAttachmentTransient(int idx);
                /*0x138daf0*/ void ResetTarget();
                /*0x138ca40*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment);
                /*0x138d4a0*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle depthAttachment);
                /*0x138c8f0*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachments, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment);
                /*0x138d0b0*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle[] colorAttachments, UnityEngine.Rendering.RTHandle depthAttachment);
                /*0x138d430*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle[] colorAttachments, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Experimental.Rendering.GraphicsFormat[] formats);
                /*0x138cdf0*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier colorAttachment);
                /*0x138cb70*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle colorAttachment);
                /*0x138cee0*/ void ConfigureTarget(UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachments);
                /*0x138d3c0*/ void ConfigureTarget(UnityEngine.Rendering.RTHandle[] colorAttachments);
                /*0x138c6a0*/ void ConfigureClear(UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                /*0x32d010*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x32d010*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                /*0x32d010*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x32d010*/ void OnFinishCameraStackRendering(UnityEngine.Rendering.CommandBuffer cmd);
                void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x138da50*/ void RecordRenderGraph(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x138c3d0*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.RenderTargetIdentifier destination, UnityEngine.Material material, int passIndex);
                /*0x138c2b0*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Material material, int passIndex);
                /*0x138c5e0*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData data, UnityEngine.Material material, int passIndex);
                /*0x138c580*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData data, UnityEngine.Rendering.RTHandle source, UnityEngine.Material material, int passIndex);
                /*0x138d740*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.ShaderTagId shaderTagId, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                /*0x138d640*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIdList, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
            }

            class ForwardRenderer : UnityEngine.Rendering.Universal.ScriptableRenderer
            {
                static /*0x0*/ string k_ErrorMessage;

                static /*0x138c1a0*/ ForwardRenderer();
                /*0x138c210*/ ForwardRenderer(UnityEngine.Rendering.Universal.ForwardRendererData data);
                /*0x138c0a0*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x138c020*/ void SetupLights(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x138bfa0*/ void SetupCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x138bee0*/ void FinishRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x138c120*/ void SwapColorBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x138bf60*/ UnityEngine.Rendering.RTHandle GetCameraColorFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
            }

            enum ShadowCascadesOption
            {
                NoCascades = 0,
                TwoCascades = 1,
                FourCascades = 2,
            }

            enum ShaderVariantLogLevel
            {
                Disabled = 0,
                OnlyUniversalRPShaders = 1,
                AllShaders = 2,
            }

            class ScriptableRenderer : System.IDisposable
            {
                static int kRenderPassMapSize = 10;
                static int kRenderPassMaxCount = 20;
                static int k_RenderPassBlockCount = 4;
                static /*0x0*/ UnityEngine.Rendering.Universal.ScriptableRenderer current;
                static /*0x8*/ bool m_UseOptimizedStoreActions;
                static /*0x10*/ UnityEngine.Rendering.RTHandle k_CameraTarget;
                static /*0x18*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_ActiveColorAttachments;
                static /*0x20*/ UnityEngine.Rendering.RenderTargetIdentifier m_ActiveDepthAttachment;
                static /*0x48*/ UnityEngine.Rendering.RenderBufferStoreAction[] m_ActiveColorStoreActions;
                static /*0x50*/ UnityEngine.Rendering.RenderBufferStoreAction m_ActiveDepthStoreAction;
                static /*0x58*/ UnityEngine.Rendering.RenderTargetIdentifier[][] m_TrimmedColorAttachmentCopies;
                static /*0x60*/ UnityEngine.Plane[] s_Planes;
                static /*0x68*/ UnityEngine.Vector4[] s_VectorPlanes;
                /*0x10*/ int m_LastBeginSubpassPassIndex;
                /*0x18*/ System.Collections.Generic.Dictionary<UnityEngine.Hash128, System.Int32[]> m_MergeableRenderPassesMap;
                /*0x20*/ int[][] m_MergeableRenderPassesMapArrays;
                /*0x28*/ UnityEngine.Hash128[] m_PassIndexToPassHash;
                /*0x30*/ System.Collections.Generic.Dictionary<UnityEngine.Hash128, int> m_RenderPassesAttachmentCount;
                /*0x38*/ UnityEngine.Rendering.AttachmentDescriptor[] m_ActiveColorAttachmentDescriptors;
                /*0x40*/ UnityEngine.Rendering.AttachmentDescriptor m_ActiveDepthAttachmentDescriptor;
                /*0xb8*/ bool[] m_IsActiveColorAttachmentTransient;
                /*0xc0*/ UnityEngine.Rendering.RenderBufferStoreAction[] m_FinalColorStoreAction;
                /*0xc8*/ UnityEngine.Rendering.RenderBufferStoreAction m_FinalDepthStoreAction;
                /*0xd0*/ UnityEngine.Rendering.ProfilingSampler <profilingExecute>k__BackingField;
                /*0xd8*/ bool hasReleasedRTs;
                /*0xe0*/ UnityEngine.Rendering.Universal.DebugHandler <DebugHandler>k__BackingField;
                /*0xe8*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderingFeatures <supportedRenderingFeatures>k__BackingField;
                /*0xf0*/ UnityEngine.Rendering.GraphicsDeviceType[] <unsupportedGraphicsDeviceTypes>k__BackingField;
                /*0xf8*/ UnityEngine.Rendering.Universal.StoreActionsOptimization m_StoreActionsOptimizationSetting;
                /*0x100*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> m_ActiveRenderPassQueue;
                /*0x108*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> m_RendererFeatures;
                /*0x110*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RTHandleRenderTargetIdentifierCompat m_CameraColorTarget;
                /*0x140*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RTHandleRenderTargetIdentifierCompat m_CameraDepthTarget;
                /*0x170*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RTHandleRenderTargetIdentifierCompat m_CameraResolveTarget;
                /*0x1a0*/ bool m_FirstTimeCameraColorTargetIsBound;
                /*0x1a1*/ bool m_FirstTimeCameraDepthTargetIsBound;
                /*0x1a2*/ bool m_IsPipelineExecuting;
                /*0x1a3*/ bool disableNativeRenderPassInFeatures;
                /*0x1a4*/ bool useRenderPassEnabled;
                /*0x1a5*/ bool <useDepthPriming>k__BackingField;
                /*0x1a6*/ bool <stripShadowsOffVariants>k__BackingField;
                /*0x1a7*/ bool <stripAdditionalLightOffVariants>k__BackingField;

                static /*0x139d3c0*/ ScriptableRenderer();
                static /*0x13939d0*/ uint GetSubPassAttachmentIndicesCount(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                static /*0x138e780*/ bool AreAttachmentIndicesCompatible(UnityEngine.Rendering.Universal.ScriptableRenderPass lastSubPass, UnityEngine.Rendering.Universal.ScriptableRenderPass currentSubPass);
                static /*0x1393b20*/ uint GetValidColorAttachmentCount(UnityEngine.Rendering.AttachmentDescriptor[] colorAttachments);
                static /*0x1393d50*/ int GetValidInputAttachmentCount(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                static /*0x1393100*/ int FindAttachmentDescriptorIndexInList(int attachmentIdx, UnityEngine.Rendering.AttachmentDescriptor attachmentDescriptor, UnityEngine.Rendering.AttachmentDescriptor[] attachmentDescriptors);
                static /*0x13932c0*/ int FindAttachmentDescriptorIndexInList(UnityEngine.Rendering.RenderTargetIdentifier target, UnityEngine.Rendering.AttachmentDescriptor[] attachmentDescriptors);
                static /*0x1393dc0*/ int GetValidPassIndexCount(int[] array);
                static /*0x13936c0*/ UnityEngine.Rendering.RTHandle GetFirstAllocatedRTHandle(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                static /*0x1394be0*/ bool PassHasInputAttachments(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                static /*0x138ff20*/ UnityEngine.Hash128 CreateRenderPassHash(int width, int height, int depthID, int sample, uint hashIndex);
                static /*0x138fe80*/ UnityEngine.Hash128 CreateRenderPassHash(UnityEngine.Rendering.Universal.ScriptableRenderer.RenderPassDescriptor desc, uint hashIndex);
                static /*0x13937b0*/ void GetRenderTextureDescriptor(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, ref UnityEngine.RenderTextureDescriptor targetRT);
                static /*0x13959c0*/ void SetCameraMatrices(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData, bool setInverseMatrices);
                static /*0x1395400*/ void SetCameraMatrices(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData, bool setInverseMatrices, bool isTargetFlipped);
                static /*0x138ee80*/ void CalculateBillboardProperties(ref UnityEngine.Matrix4x4 worldToCameraMatrix, ref UnityEngine.Vector3 billboardTangent, ref UnityEngine.Vector3 billboardNormal, ref float cameraXZAngle);
                static /*0x139b8d0*/ void SetShaderTimeValues(UnityEngine.Rendering.CommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime);
                static /*0x138f7d0*/ void ConfigureActiveTarget(UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment);
                static /*0x1393500*/ UnityEngine.Rendering.ClearFlag GetCameraClearFlag(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x138f190*/ void ClearRenderingState(UnityEngine.Rendering.CommandBuffer cmd);
                static /*0x1399ef0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                static /*0x139b2d0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                static /*0x139a250*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
                static /*0x139ad50*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction);
                static /*0x139ac80*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.ClearFlag clearFlags, UnityEngine.Color clearColor);
                static /*0x139b0e0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.ClearFlag clearFlags, UnityEngine.Color clearColor);
                static /*0x139a600*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier colorAttachment, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlags, UnityEngine.Color clearColor);
                static /*0x139aa60*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.RenderBufferLoadAction depthLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStoreAction, UnityEngine.Rendering.ClearFlag clearFlags, UnityEngine.Color clearColor);
                static /*0x139b1a0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachments, UnityEngine.Rendering.RenderTargetIdentifier depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                static /*0x139b7a0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier[] colorAttachments, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                static /*0x139a7d0*/ void SetRenderTarget(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle[] colorAttachments, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor);
                static /*0x139ce80*/ void SortStable(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> list);
                /*0x139e1a0*/ ScriptableRenderer(UnityEngine.Rendering.Universal.ScriptableRendererData data);
                /*0x139ef50*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraDepth();
                /*0x13952d0*/ void ResetNativeRenderPassFrameData();
                /*0x139bf20*/ void SetupNativeRenderPassFrameData(ref UnityEngine.Rendering.Universal.CameraData cameraData, bool isRenderPassEnabled);
                /*0x139d010*/ void UpdateFinalStoreActions(int[] currentMergeablePasses, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x1396900*/ void SetNativeRenderPassMRTAttachmentList(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, ref UnityEngine.Rendering.Universal.CameraData cameraData, bool needCustomCameraColorClear, UnityEngine.Rendering.ClearFlag cameraClearFlag);
                /*0x1394aa0*/ bool IsDepthOnlyRenderTexture(UnityEngine.RenderTexture t);
                /*0x1395a50*/ void SetNativeRenderPassAttachmentList(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.RTHandle passColorAttachment, UnityEngine.Rendering.RTHandle passDepthAttachment, UnityEngine.Rendering.ClearFlag finalClearFlag, UnityEngine.Color finalClearColor);
                /*0x1390d20*/ void ExecuteNativeRenderPass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, ref UnityEngine.Rendering.Universal.CameraData cameraData, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x139bc70*/ void SetupInputAttachmentIndices(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                /*0x139cd30*/ void SetupTransientInputAttachments(int attachmentCount);
                /*0x1394170*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderPassDescriptor InitializeRenderPassDescriptor(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                /*0x388e90*/ int SupportedCameraStackingTypes();
                /*0x139cfd0*/ bool SupportsCameraStackingType(UnityEngine.Rendering.Universal.CameraRenderType cameraRenderType);
                /*0x136fcc0*/ UnityEngine.Rendering.ProfilingSampler get_profilingExecute();
                /*0x139efc0*/ void set_profilingExecute(UnityEngine.Rendering.ProfilingSampler value);
                /*0x139ece0*/ UnityEngine.Rendering.Universal.DebugHandler get_DebugHandler();
                /*0x13985c0*/ void SetPerCameraShaderVariables(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x1397e20*/ void SetPerCameraShaderVariables(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData, bool isTargetFlipped);
                /*0x13974f0*/ void SetPerCameraBillboardProperties(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x1397ac0*/ void SetPerCameraClippingPlaneProperties(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x1397730*/ void SetPerCameraClippingPlaneProperties(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData, bool isTargetFlipped);
                /*0x139ed70*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraColorTarget();
                /*0x139ecf0*/ UnityEngine.Rendering.RTHandle get_cameraColorTargetHandle();
                /*0x388e90*/ UnityEngine.Rendering.RTHandle GetCameraColorFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x388e90*/ UnityEngine.Rendering.RTHandle GetCameraColorBackBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x139eea0*/ UnityEngine.Rendering.RenderTargetIdentifier get_cameraDepthTarget();
                /*0x139ee20*/ UnityEngine.Rendering.RTHandle get_cameraDepthTargetHandle();
                /*0x136fcb0*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> get_rendererFeatures();
                /*0x136fc90*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> get_activeRenderPassQueue();
                /*0x10d00b0*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderingFeatures get_supportedRenderingFeatures();
                /*0x136fd30*/ void set_supportedRenderingFeatures(UnityEngine.Rendering.Universal.ScriptableRenderer.RenderingFeatures value);
                /*0x10d0110*/ UnityEngine.Rendering.GraphicsDeviceType[] get_unsupportedGraphicsDeviceTypes();
                /*0x139f000*/ void set_unsupportedGraphicsDeviceTypes(UnityEngine.Rendering.GraphicsDeviceType[] value);
                /*0x139efb0*/ bool get_useDepthPriming();
                /*0x139f020*/ void set_useDepthPriming(bool value);
                /*0x139efa0*/ bool get_stripShadowsOffVariants();
                /*0x139eff0*/ void set_stripShadowsOffVariants(bool value);
                /*0x139ef90*/ bool get_stripAdditionalLightOffVariants();
                /*0x139efe0*/ void set_stripAdditionalLightOffVariants(bool value);
                /*0x138ff60*/ void Dispose();
                /*0x13900b0*/ void Dispose(bool disposing);
                /*0x32d010*/ void ReleaseRenderTargets();
                /*0x138fb30*/ void ConfigureCameraTarget(UnityEngine.Rendering.RenderTargetIdentifier colorTarget, UnityEngine.Rendering.RenderTargetIdentifier depthTarget);
                /*0x138fa50*/ void ConfigureCameraTarget(UnityEngine.Rendering.RTHandle colorTarget, UnityEngine.Rendering.RTHandle depthTarget);
                /*0x138fd40*/ void ConfigureCameraTarget(UnityEngine.Rendering.RenderTargetIdentifier colorTarget, UnityEngine.Rendering.RenderTargetIdentifier depthTarget, UnityEngine.Rendering.RenderTargetIdentifier resolveTarget);
                /*0x138fc00*/ void ConfigureCameraTarget(UnityEngine.Rendering.RTHandle colorTarget, UnityEngine.Rendering.RTHandle depthTarget, UnityEngine.Rendering.RTHandle resolveTarget);
                /*0x138f9e0*/ void ConfigureCameraColorTarget(UnityEngine.Rendering.RenderTargetIdentifier colorTarget);
                /*0x138f970*/ void ConfigureCameraColorTarget(UnityEngine.Rendering.RTHandle colorTarget);
                void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x32d010*/ void SetupLights(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x32d010*/ void SetupCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x32d010*/ void FinishRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x32d010*/ void OnRecordRenderGraph(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x1393e00*/ void InitRenderGraphFrame(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x1394c20*/ void ProcessVFXCameraCommand(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x139c720*/ void SetupRenderGraphCameraProperties(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.Universal.RenderingData renderingData, bool isTargetBackbuffer);
                /*0x13900d0*/ void DrawRenderGraphGizmos(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle color, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle depth, UnityEngine.Rendering.GizmoSubset gizmoSubset, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x138e880*/ void BeginRenderGraphXRRendering(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x1390500*/ void EndRenderGraphXRRendering(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x1395150*/ void RecordRenderGraph(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x1393420*/ void FinishRenderGraphRendering(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x32d010*/ void OnFinishRenderGraphRendering(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x1394e80*/ void RecordCustomRenderGraphPasses(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.Universal.RenderPassEvent injectionPoint);
                /*0x1397b10*/ void SetPerCameraProperties(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd);
                /*0x1391f30*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x1390ae0*/ void EnqueuePass(UnityEngine.Rendering.Universal.ScriptableRenderPass pass);
                /*0x1394b00*/ void OnPreCullRenderPasses(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x138e4d0*/ void AddRenderPasses(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x139cbc0*/ void SetupRenderPasses(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x138f4d0*/ void Clear(UnityEngine.Rendering.Universal.CameraRenderType cameraType);
                /*0x1390ba0*/ void ExecuteBlock(int blockIndex, ref UnityEngine.Rendering.Universal.ScriptableRenderer.RenderBlocks renderBlocks, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData, bool submit);
                /*0x1394ad0*/ bool IsRenderPassEnabled(UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass);
                /*0x1391ba0*/ void ExecuteRenderPass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x1398610*/ void SetRenderPassAttachments(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.ScriptableRenderPass renderPass, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x138ecc0*/ void BeginXRRendering(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x1390940*/ void EndXRRendering(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x32d010*/ void SwapColorBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x32d010*/ void EnableSwapBufferMSAA(bool enable);
                /*0x32d010*/ void DrawGizmos(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, UnityEngine.Rendering.GizmoSubset gizmoSubset, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13904a0*/ void DrawWireOverlay(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                /*0x1394910*/ void InternalStartRendering(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x1394540*/ void InternalFinishRendering(bool resolveFinalTarget, UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x1394300*/ void InternalFinishRendering(UnityEngine.Rendering.ScriptableRenderContext context, bool resolveFinalTarget, UnityEngine.Rendering.Universal.RenderingData renderingData);

                class Profiling
                {
                    static string k_Name = "ScriptableRenderer";
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler setMRTAttachmentsList;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler setAttachmentList;
                    static /*0x10*/ UnityEngine.Rendering.ProfilingSampler execute;
                    static /*0x18*/ UnityEngine.Rendering.ProfilingSampler setupFrameData;
                    static /*0x20*/ UnityEngine.Rendering.ProfilingSampler setPerCameraShaderVariables;
                    static /*0x28*/ UnityEngine.Rendering.ProfilingSampler sortRenderPasses;
                    static /*0x30*/ UnityEngine.Rendering.ProfilingSampler setupLights;
                    static /*0x38*/ UnityEngine.Rendering.ProfilingSampler setupCamera;
                    static /*0x40*/ UnityEngine.Rendering.ProfilingSampler vfxProcessCamera;
                    static /*0x48*/ UnityEngine.Rendering.ProfilingSampler addRenderPasses;
                    static /*0x50*/ UnityEngine.Rendering.ProfilingSampler setupRenderPasses;
                    static /*0x58*/ UnityEngine.Rendering.ProfilingSampler clearRenderingState;
                    static /*0x60*/ UnityEngine.Rendering.ProfilingSampler internalStartRendering;
                    static /*0x68*/ UnityEngine.Rendering.ProfilingSampler internalFinishRendering;
                    static /*0x70*/ UnityEngine.Rendering.ProfilingSampler drawGizmos;
                    static /*0x78*/ UnityEngine.Rendering.ProfilingSampler beginXRRendering;
                    static /*0x80*/ UnityEngine.Rendering.ProfilingSampler endXRRendering;

                    static /*0x13b5910*/ Profiling();

                    class RenderBlock
                    {
                        static string k_Name = "RenderPassBlock";
                        static /*0x0*/ UnityEngine.Rendering.ProfilingSampler beforeRendering;
                        static /*0x8*/ UnityEngine.Rendering.ProfilingSampler mainRenderingOpaque;
                        static /*0x10*/ UnityEngine.Rendering.ProfilingSampler mainRenderingTransparent;
                        static /*0x18*/ UnityEngine.Rendering.ProfilingSampler afterRendering;

                        static /*0x13b5fc0*/ RenderBlock();
                    }

                    class RenderPass
                    {
                        static string k_Name = "ScriptableRenderPass";
                        static /*0x0*/ UnityEngine.Rendering.ProfilingSampler configure;
                        static /*0x8*/ UnityEngine.Rendering.ProfilingSampler setRenderPassAttachments;

                        static /*0x13b6630*/ RenderPass();
                    }
                }

                struct RenderPassDescriptor
                {
                    /*0x10*/ int w;
                    /*0x14*/ int h;
                    /*0x18*/ int samples;
                    /*0x1c*/ int depthID;

                    /*0x1153590*/ RenderPassDescriptor(int width, int height, int sampleCount, int rtID);
                }

                class RenderingFeatures
                {
                    /*0x10*/ bool <cameraStacking>k__BackingField;
                    /*0x11*/ bool <msaa>k__BackingField;

                    /*0x13b6710*/ RenderingFeatures();
                    /*0x793eb0*/ bool get_cameraStacking();
                    /*0x793ec0*/ void set_cameraStacking(bool value);
                    /*0xf26f80*/ bool get_msaa();
                    /*0xf26f90*/ void set_msaa(bool value);
                }

                class RenderPassBlock
                {
                    static /*0x0*/ int BeforeRendering;
                    static /*0x4*/ int MainRenderingOpaque;
                    static /*0x8*/ int MainRenderingTransparent;
                    static /*0xc*/ int AfterRendering;

                    static /*0x13b65b0*/ RenderPassBlock();
                }

                struct RTHandleRenderTargetIdentifierCompat
                {
                    /*0x10*/ UnityEngine.Rendering.RTHandle handle;
                    /*0x18*/ UnityEngine.Rendering.RenderTargetIdentifier fallback;

                    /*0xfbe040*/ bool get_useRTHandle();
                    /*0x13b5f30*/ UnityEngine.Rendering.RenderTargetIdentifier get_nameID();
                }

                class VFXProcessCameraPassData
                {
                    /*0x10*/ UnityEngine.Rendering.CullingResults cullResults;
                    /*0x20*/ UnityEngine.Camera camera;

                    /*0x32f970*/ VFXProcessCameraPassData();
                }

                class DrawGizmosPassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.RenderingData renderingData;
                    /*0x2c8*/ UnityEngine.Rendering.Universal.ScriptableRenderer renderer;
                    /*0x2d0*/ UnityEngine.Rendering.GizmoSubset gizmoSubset;

                    /*0x32f970*/ DrawGizmosPassData();
                }

                class BeginXRPassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.RenderingData renderingData;
                    /*0x2c8*/ UnityEngine.Rendering.Universal.CameraData cameraData;

                    /*0x32f970*/ BeginXRPassData();
                }

                class EndXRPassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.RenderingData renderingData;
                    /*0x2c8*/ UnityEngine.Rendering.Universal.CameraData cameraData;

                    /*0x32f970*/ EndXRPassData();
                }

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.RenderingData renderingData;
                    /*0x2c8*/ UnityEngine.Rendering.Universal.ScriptableRenderer renderer;
                    /*0x2d0*/ UnityEngine.Rendering.Universal.CameraData cameraData;
                    /*0x4e0*/ bool isTargetBackbuffer;

                    /*0x32f970*/ PassData();
                }

                struct RenderBlocks : System.IDisposable
                {
                    /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.RenderPassEvent> m_BlockEventLimits;
                    /*0x20*/ Unity.Collections.NativeArray<int> m_BlockRanges;
                    /*0x30*/ Unity.Collections.NativeArray<int> m_BlockRangeLengths;

                    /*0x13b6300*/ RenderBlocks(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> activeRenderPassQueue);
                    /*0x13b6160*/ void Dispose();
                    /*0x13b61b0*/ void FillBlockRanges(System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRenderPass> activeRenderPassQueue);
                    /*0x13b62b0*/ int GetLength(int index);
                    /*0x13b62c0*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderBlocks.BlockRange GetRange(int index);

                    struct BlockRange : System.IDisposable
                    {
                        /*0x10*/ int m_Current;
                        /*0x14*/ int m_End;

                        /*0x139fe40*/ BlockRange(int begin, int end);
                        /*0x6937d0*/ UnityEngine.Rendering.Universal.ScriptableRenderer.RenderBlocks.BlockRange GetEnumerator();
                        /*0x139fe30*/ bool MoveNext();
                        /*0x6bba50*/ int get_Current();
                        /*0x32d010*/ void Dispose();
                    }
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.ScriptableRenderer.<> <>9;
                    static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.PassData> <>9__132_0;
                    static /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.VFXProcessCameraPassData> <>9__134_0;
                    static /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.PassData> <>9__135_0;
                    static /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.DrawGizmosPassData> <>9__137_0;
                    static /*0x28*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.BeginXRPassData> <>9__139_0;
                    static /*0x30*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.ScriptableRenderer.EndXRPassData> <>9__141_0;

                    static /*0x13b8320*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x13b7990*/ void <InitRenderGraphFrame>b__132_0(UnityEngine.Rendering.Universal.ScriptableRenderer.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext);
                    /*0x13b7a90*/ void <ProcessVFXCameraCommand>b__134_0(UnityEngine.Rendering.Universal.ScriptableRenderer.VFXProcessCameraPassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    /*0x13b7f60*/ void <SetupRenderGraphCameraProperties>b__135_0(UnityEngine.Rendering.Universal.ScriptableRenderer.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    /*0x13b7840*/ void <DrawRenderGraphGizmos>b__137_0(UnityEngine.Rendering.Universal.ScriptableRenderer.DrawGizmosPassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext rgContext);
                    /*0x13b76c0*/ void <BeginRenderGraphXRRendering>b__139_0(UnityEngine.Rendering.Universal.ScriptableRenderer.BeginXRPassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    /*0x13b7860*/ void <EndRenderGraphXRRendering>b__141_0(UnityEngine.Rendering.Universal.ScriptableRenderer.EndXRPassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                }
            }

            class Bloom : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedIntParameter skipIterations;
                /*0x40*/ UnityEngine.Rendering.MinFloatParameter threshold;
                /*0x48*/ UnityEngine.Rendering.MinFloatParameter intensity;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter scatter;
                /*0x58*/ UnityEngine.Rendering.MinFloatParameter clamp;
                /*0x60*/ UnityEngine.Rendering.ColorParameter tint;
                /*0x68*/ UnityEngine.Rendering.BoolParameter highQualityFiltering;
                /*0x70*/ UnityEngine.Rendering.Universal.DownscaleParameter downscale;
                /*0x78*/ UnityEngine.Rendering.ClampedIntParameter maxIterations;
                /*0x80*/ UnityEngine.Rendering.TextureParameter dirtTexture;
                /*0x88*/ UnityEngine.Rendering.MinFloatParameter dirtIntensity;

                /*0x139fea0*/ Bloom();
                /*0x139fe60*/ bool IsActive();
                /*0x348b00*/ bool IsTileCompatible();
            }

            class URPHelpURLAttribute : UnityEngine.Rendering.CoreRPHelpURLAttribute
            {
                /*0x13b84e0*/ URPHelpURLAttribute(string pageName, string pageHash);
            }

            class Documentation : UnityEngine.Rendering.DocumentationInfo
            {
                static string packageName = "com.unity.render-pipelines.universal";

                /*0x534220*/ Documentation();
            }

            class ForwardRendererData : UnityEngine.Rendering.Universal.ScriptableRendererData
            {
                static string k_ErrorMessage = "ForwardRendererData has been deprecated. Use UniversalRendererData instead";
                /*0x40*/ UnityEngine.Rendering.Universal.ForwardRendererData.ShaderResources shaders;
                /*0x48*/ UnityEngine.Rendering.Universal.PostProcessData postProcessData;
                /*0x50*/ UnityEngine.Rendering.Universal.XRSystemData xrSystemData;
                /*0x58*/ UnityEngine.LayerMask m_OpaqueLayerMask;
                /*0x5c*/ UnityEngine.LayerMask m_TransparentLayerMask;
                /*0x60*/ UnityEngine.Rendering.Universal.StencilStateData m_DefaultStencilState;
                /*0x68*/ bool m_ShadowTransparentReceive;
                /*0x6c*/ UnityEngine.Rendering.Universal.RenderingMode m_RenderingMode;
                /*0x70*/ UnityEngine.Rendering.Universal.DepthPrimingMode m_DepthPrimingMode;
                /*0x74*/ bool m_AccurateGbufferNormals;
                /*0x75*/ bool m_ClusteredRendering;
                /*0x78*/ UnityEngine.Rendering.Universal.TileSize m_TileSize;

                /*0x13a4b40*/ ForwardRendererData();
                /*0x13a4ab0*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x13a4bf0*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x13a4dd0*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0x13a4ce0*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x13a4ec0*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x13a4ba0*/ UnityEngine.Rendering.Universal.StencilStateData get_defaultStencilState();
                /*0x13a4d80*/ void set_defaultStencilState(UnityEngine.Rendering.Universal.StencilStateData value);
                /*0x13a4c90*/ bool get_shadowTransparentReceive();
                /*0x13a4e70*/ void set_shadowTransparentReceive(bool value);
                /*0x13a4c40*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingMode();
                /*0x13a4e20*/ void set_renderingMode(UnityEngine.Rendering.Universal.RenderingMode value);
                /*0x13a4b50*/ bool get_accurateGbufferNormals();
                /*0x13a4d30*/ void set_accurateGbufferNormals(bool value);

                class ShaderResources
                {
                    /*0x10*/ UnityEngine.Shader blitPS;
                    /*0x18*/ UnityEngine.Shader copyDepthPS;
                    /*0x20*/ UnityEngine.Shader screenSpaceShadowPS;
                    /*0x28*/ UnityEngine.Shader samplingPS;
                    /*0x30*/ UnityEngine.Shader stencilDeferredPS;
                    /*0x38*/ UnityEngine.Shader fallbackErrorPS;
                    /*0x40*/ UnityEngine.Shader fallbackLoadingPS;
                    /*0x48*/ UnityEngine.Shader materialErrorPS;
                    /*0x50*/ UnityEngine.Shader coreBlitPS;
                    /*0x58*/ UnityEngine.Shader coreBlitColorAndDepthPS;
                    /*0x60*/ UnityEngine.Shader cameraMotionVector;
                    /*0x68*/ UnityEngine.Shader objectMotionVector;

                    /*0x32f970*/ ShaderResources();
                }
            }

            enum IntermediateTextureMode
            {
                Auto = 0,
                Always = 1,
            }

            class LightCookieManager : System.IDisposable
            {
                static int k_MaxCookieSizeDivisor = 16;
                static /*0x0*/ UnityEngine.Matrix4x4 s_DirLightProj;
                /*0x10*/ UnityEngine.Rendering.Texture2DAtlas m_AdditionalLightsCookieAtlas;
                /*0x18*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieShaderData m_AdditionalLightsCookieShaderData;
                /*0x20*/ UnityEngine.Rendering.Universal.LightCookieManager.Settings m_Settings;
                /*0x40*/ UnityEngine.Rendering.Universal.LightCookieManager.WorkMemory m_WorkMem;
                /*0x48*/ int[] m_VisibleLightIndexToShaderDataIndex;
                /*0x50*/ int m_CookieSizeDivisor;
                /*0x54*/ uint m_PrevCookieRequestPixelCount;
                /*0x58*/ int m_PrevWarnFrame;
                /*0x5c*/ bool <IsKeywordLightCookieEnabled>k__BackingField;

                static /*0x13a9830*/ LightCookieManager();
                /*0x13a98c0*/ LightCookieManager(ref UnityEngine.Rendering.Universal.LightCookieManager.Settings settings);
                /*0xf39700*/ bool get_IsKeywordLightCookieEnabled();
                /*0x13a9950*/ void set_IsKeywordLightCookieEnabled(bool value);
                /*0x13a7d80*/ void InitAdditionalLights(int size);
                /*0x12e8540*/ bool isInitialized();
                /*0x13a6e00*/ void Dispose();
                /*0x13a7a80*/ int GetLightCookieShaderDataIndex(int visibleLightIndex);
                /*0x13a88e0*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext ctx, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightData lightData);
                /*0x13a8210*/ bool SetupMainLight(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight visibleMainLight);
                /*0x13a7ad0*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieShaderFormat GetLightCookieShaderFormat(UnityEngine.Experimental.Rendering.GraphicsFormat cookieFormat);
                /*0x13a7b50*/ void GetLightUVScaleOffset(ref UnityEngine.Rendering.Universal.UniversalAdditionalLightData additionalLightData, ref UnityEngine.Matrix4x4 uvTransform);
                /*0x13a7f60*/ bool SetupAdditionalLights(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightData lightData);
                /*0x13a75d0*/ int FilterAndValidateAdditionalLights(ref UnityEngine.Rendering.Universal.LightData lightData, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping[] validLightMappings);
                /*0x13a8d30*/ int UpdateAdditionalLightsAtlas(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings, UnityEngine.Vector4[] textureAtlasUVRects);
                /*0x13a7290*/ int FetchUVRects(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings, UnityEngine.Vector4[] textureAtlasUVRects, int cookieSizeDivisor);
                /*0x13a6c00*/ uint ComputeCookieRequestPixelCount(ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings);
                /*0x13a6bc0*/ int ApproximateCookieSizeDivisor(float requestAtlasRatio);
                /*0x13a6e70*/ UnityEngine.Vector4 Fetch2D(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture cookie, int cookieSizeDivisor);
                /*0x13a7020*/ UnityEngine.Vector4 FetchCube(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Texture cookie, int cookieSizeDivisor);
                /*0x13a6cf0*/ int ComputeOctahedralCookieSize(UnityEngine.Texture cookie);
                /*0x13a6900*/ void AdjustUVRect(ref UnityEngine.Vector4 uvScaleOffset, UnityEngine.Texture cookie, ref UnityEngine.Vector2 cookieSize);
                /*0x13a8bf0*/ void ShrinkUVRect(ref UnityEngine.Vector4 uvScaleOffset, float amountPixels, ref UnityEngine.Vector2 cookieSize);
                /*0x13a8fa0*/ void UploadAdditionalLights(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightData lightData, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping> validLightMappings, ref UnityEngine.Rendering.Universal.LightCookieManager.WorkSlice<UnityEngine.Vector4> validUvRects);

                class ShaderProperty
                {
                    static /*0x0*/ int mainLightTexture;
                    static /*0x4*/ int mainLightWorldToLight;
                    static /*0x8*/ int mainLightCookieTextureFormat;
                    static /*0xc*/ int additionalLightsCookieAtlasTexture;
                    static /*0x10*/ int additionalLightsCookieAtlasTextureFormat;
                    static /*0x14*/ int additionalLightsCookieEnableBits;
                    static /*0x18*/ int additionalLightsCookieAtlasUVRectBuffer;
                    static /*0x1c*/ int additionalLightsCookieAtlasUVRects;
                    static /*0x20*/ int additionalLightsWorldToLightBuffer;
                    static /*0x24*/ int additionalLightsLightTypeBuffer;
                    static /*0x28*/ int additionalLightsWorldToLights;
                    static /*0x2c*/ int additionalLightsLightTypes;

                    static /*0x13b6ca0*/ ShaderProperty();
                }

                enum LightCookieShaderFormat
                {
                    None = -1,
                    RGB = 0,
                    Alpha = 1,
                    Red = 2,
                }

                struct Settings
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.LightCookieManager.Settings.AtlasSettings atlas;
                    /*0x20*/ int maxAdditionalLights;
                    /*0x24*/ float cubeOctahedralSizeScale;
                    /*0x28*/ bool useStructuredBuffer;

                    static /*0x13b6720*/ UnityEngine.Rendering.Universal.LightCookieManager.Settings Create();

                    struct AtlasSettings
                    {
                        /*0x10*/ UnityEngine.Vector2Int resolution;
                        /*0x18*/ UnityEngine.Experimental.Rendering.GraphicsFormat format;
                        /*0x1c*/ bool useMips;

                        /*0x139fdf0*/ bool get_isPow2();
                        /*0x139fe20*/ bool get_isSquare();
                    }
                }

                struct Sorting
                {
                    static /*0x177670*/ void QuickSort<T>(T[] data, System.Func<T, T, int> compare);
                    static /*0x2a5510*/ void QuickSort<T>(T[] data, int start, int end, System.Func<T, T, int> compare);
                    static /*0x2a5510*/ T Median3Pivot<T>(T[] data, int start, int pivot, int end, System.Func<T, T, int> compare);
                    static /*0x2a5510*/ int Partition<T>(T[] data, int start, int end, System.Func<T, T, int> compare);
                    static /*0x2a5510*/ void InsertionSort<T>(T[] data, int start, int end, System.Func<T, T, int> compare);
                    static void <Median3Pivot>g__Swap|2_0<T>(int a, int b, ref UnityEngine.Rendering.Universal.LightCookieManager.Sorting.<>c__DisplayClass2_0<T> );

                    struct <>c__DisplayClass2_0<T>
                    {
                        /*0x0*/ T[] data;
                    }
                }

                struct LightCookieMapping
                {
                    static /*0x0*/ System.Func<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, int> s_CompareByCookieSize;
                    static /*0x8*/ System.Func<UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping, int> s_CompareByBufferIndex;
                    /*0x10*/ ushort visibleLightIndex;
                    /*0x12*/ ushort lightBufferIndex;
                    /*0x18*/ UnityEngine.Light light;

                    static /*0x13a9960*/ LightCookieMapping();

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping.<> <>9;

                        static /*0x13b8400*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x13b8130*/ int <.cctor>b__6_0(UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping a, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping b);
                        /*0x13b8230*/ int <.cctor>b__6_1(UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping a, UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping b);
                    }
                }

                struct WorkSlice<T>
                {
                    /*0x0*/ T[] m_Data;
                    /*0x0*/ int m_Start;
                    /*0x0*/ int m_Length;

                    /*0x182a70*/ WorkSlice(T[] src, int srcLen);
                    WorkSlice(T[] src, int srcStart, int srcLen);
                    /*0x2a5510*/ T get_Item(int index);
                    /*0x2a5510*/ void set_Item(int index, T value);
                    /*0x180980*/ int get_length();
                    /*0x180980*/ int get_capacity();
                    /*0x17aec0*/ void Sort(System.Func<T, T, int> compare);
                }

                class WorkMemory
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.LightCookieManager.LightCookieMapping[] lightMappings;
                    /*0x18*/ UnityEngine.Vector4[] uvRects;

                    /*0x32f970*/ WorkMemory();
                    /*0x13b8860*/ void Resize(int size);
                }

                struct ShaderBitArray
                {
                    static int k_BitsPerElement = 32;
                    static int k_ElementShift = 5;
                    static int k_ElementMask = 31;
                    /*0x10*/ float[] m_Data;

                    /*0x13b6b60*/ int get_elemLength();
                    /*0x13b6b40*/ int get_bitCapacity();
                    /*0x6937d0*/ float[] get_data();
                    /*0x13b6870*/ void Resize(int bitCount);
                    /*0x13b6810*/ void Clear();
                    /*0x13b6860*/ void GetElementIndexAndBitOffset(int index, ref int elemIndex, ref int bitOffset);
                    /*0x13b6af0*/ bool get_Item(int index);
                    /*0x13b6b70*/ void set_Item(int index, bool value);
                    /*0x13b69a0*/ string ToString();
                }

                class LightCookieShaderData : System.IDisposable
                {
                    /*0x10*/ int m_Size;
                    /*0x14*/ bool m_UseStructuredBuffer;
                    /*0x18*/ UnityEngine.Matrix4x4[] m_WorldToLightCpuData;
                    /*0x20*/ UnityEngine.Vector4[] m_AtlasUVRectCpuData;
                    /*0x28*/ float[] m_LightTypeCpuData;
                    /*0x30*/ UnityEngine.Rendering.Universal.LightCookieManager.ShaderBitArray m_CookieEnableBitsCpuData;
                    /*0x38*/ UnityEngine.ComputeBuffer m_WorldToLightBuffer;
                    /*0x40*/ UnityEngine.ComputeBuffer m_AtlasUVRectBuffer;
                    /*0x48*/ UnityEngine.ComputeBuffer m_LightTypeBuffer;
                    /*0x50*/ bool <isUploaded>k__BackingField;

                    /*0x13a9fd0*/ LightCookieShaderData(int size, bool useStructuredBuffer);
                    /*0x32f410*/ UnityEngine.Matrix4x4[] get_worldToLights();
                    /*0x997630*/ UnityEngine.Rendering.Universal.LightCookieManager.ShaderBitArray get_cookieEnableBits();
                    /*0x61a260*/ UnityEngine.Vector4[] get_atlasUVRects();
                    /*0x79a150*/ float[] get_lightTypes();
                    /*0x9ef740*/ bool get_isUploaded();
                    /*0x9ef990*/ void set_isUploaded(bool value);
                    /*0x13a9b70*/ void Dispose();
                    /*0x13a9bc0*/ void Resize(int size);
                    /*0x13a9df0*/ void Upload(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x13a9aa0*/ void Clear(UnityEngine.Rendering.CommandBuffer cmd);
                }
            }

            struct BuddyAllocation
            {
                /*0x10*/ int level;
                /*0x14*/ int index;

                /*0xa59f20*/ BuddyAllocation(int level, int index);
                /*0x13a01f0*/ Unity.Mathematics.uint2 get_index2D();
            }

            struct BuddyAllocator : System.IDisposable
            {
                /*0x10*/ void* m_Data;
                /*0x18*/ System.ValueTuple<int, int> m_ActiveFreeMaskCounts;
                /*0x20*/ System.ValueTuple<int, int> m_FreeMasksStorage;
                /*0x28*/ System.ValueTuple<int, int> m_FreeMaskIndicesStorage;
                /*0x30*/ Unity.Collections.Allocator m_Allocator;

                static /*0x13a08b0*/ int LevelOffset(int level, int branchingOrder);
                static /*0x13a0840*/ int LevelLength(int level, int branchingOrder);
                static /*0x13a0850*/ int LevelOffset64(int level, int branchingOrder);
                static /*0x13a0810*/ int LevelLength64(int level, int branchingOrder);
                static /*0x2a5510*/ System.ValueTuple<int, int> AllocateRange<T>(int length, ref int dataSize);
                static /*0x13a0200*/ int AlignForward(int offset, int alignment);
                static /*0x13a08f0*/ void* PtrAdd(void* ptr, int bytes);
                static /*0x132bb10*/ int Pow2(int n);
                static /*0x13a08e0*/ int Pow2N(int x, int n);
                /*0x13a0bc0*/ BuddyAllocator(int levelCount, int branchingOrder, Unity.Collections.Allocator allocator);
                /*0x13a0f20*/ ref UnityEngine.Rendering.Universal.BuddyAllocator.Header get_header();
                /*0x13a0dd0*/ Unity.Collections.NativeArray<int> get_freeMaskCounts();
                /*0x13a0eb0*/ Unity.Collections.NativeArray<ulong> get_freeMasksStorage();
                /*0x13a03e0*/ Unity.Collections.NativeArray<ulong> FreeMasks(int level);
                /*0x13a0e40*/ Unity.Collections.NativeArray<int> get_freeMaskIndicesStorage();
                /*0x13a0250*/ Unity.Collections.NativeArray<int> FreeMaskIndices(int level);
                /*0x13a0f60*/ int get_levelCount();
                /*0x13a0920*/ bool TryAllocate(int requestedLevel, ref UnityEngine.Rendering.Universal.BuddyAllocation allocation);
                /*0x13a0570*/ void Free(UnityEngine.Rendering.Universal.BuddyAllocation allocation);
                /*0x13a0220*/ void Dispose();
                /*0x2a5510*/ Unity.Collections.NativeArray<T> GetNativeArray<T>(int offset, int length);

                struct Header
                {
                    /*0x10*/ int branchingOrder;
                    /*0x14*/ int levelCount;
                    /*0x18*/ int allocationCount;
                    /*0x1c*/ int freeAllocationIdsCount;
                }
            }

            struct Fixed2<T>
            {
                /*0x0*/ T item1;
                /*0x0*/ T item2;

                static /*0x1784c0*/ void CheckRange(int index);
                /*0x2a5510*/ Fixed2(T item1);
                /*0x2a5510*/ Fixed2(T item1, T item2);
                /*0x2a5510*/ T get_Item(int index);
                /*0x2a5510*/ void set_Item(int index, T value);
            }

            struct PinnedArray<T> : System.IDisposable
            {
                /*0x0*/ T[] managedArray;
                /*0x0*/ System.Runtime.InteropServices.GCHandle handle;
                /*0x0*/ Unity.Collections.NativeArray<T> nativeArray;

                /*0x17aa40*/ PinnedArray(int length);
                /*0x180980*/ int get_length();
                /*0x180fc0*/ void Dispose();
            }

            class MotionVectorsPersistentData
            {
                static int k_EyeCount = 2;
                /*0x10*/ UnityEngine.Matrix4x4[] m_ViewProjection;
                /*0x18*/ UnityEngine.Matrix4x4[] m_PreviousViewProjection;
                /*0x20*/ int[] m_LastFrameIndex;
                /*0x28*/ float[] m_PrevAspectRatio;

                /*0x13ac1c0*/ MotionVectorsPersistentData();
                /*0x13ac400*/ int get_lastFrameIndex();
                /*0x13ac480*/ UnityEngine.Matrix4x4 get_viewProjection();
                /*0x13ac430*/ UnityEngine.Matrix4x4 get_previousViewProjection();
                /*0x73d3e0*/ UnityEngine.Matrix4x4[] get_viewProjectionStereo();
                /*0x32f410*/ UnityEngine.Matrix4x4[] get_previousViewProjectionStereo();
                /*0x13aba40*/ void Reset();
                /*0x13ab9f0*/ int GetXRMultiPassId(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x13abbc0*/ void Update(ref UnityEngine.Rendering.Universal.CameraData cameraData);
            }

            enum BloomDownscaleMode
            {
                Half = 0,
                Quarter = 1,
            }

            class DownscaleParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.BloomDownscaleMode>
            {
                /*0x13a2ba0*/ DownscaleParameter(UnityEngine.Rendering.Universal.BloomDownscaleMode value, bool overrideState);
            }

            class ChannelMixer : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter redOutRedIn;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter redOutGreenIn;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter redOutBlueIn;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter greenOutRedIn;
                /*0x58*/ UnityEngine.Rendering.ClampedFloatParameter greenOutGreenIn;
                /*0x60*/ UnityEngine.Rendering.ClampedFloatParameter greenOutBlueIn;
                /*0x68*/ UnityEngine.Rendering.ClampedFloatParameter blueOutRedIn;
                /*0x70*/ UnityEngine.Rendering.ClampedFloatParameter blueOutGreenIn;
                /*0x78*/ UnityEngine.Rendering.ClampedFloatParameter blueOutBlueIn;

                /*0x13a1600*/ ChannelMixer();
                /*0x13a1440*/ bool IsActive();
                /*0x3ce290*/ bool IsTileCompatible();
            }

            class ChromaticAberration : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter intensity;

                /*0x13a18e0*/ ChromaticAberration();
                /*0x13a18a0*/ bool IsActive();
                /*0x348b00*/ bool IsTileCompatible();
            }

            class ColorAdjustments : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.FloatParameter postExposure;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter contrast;
                /*0x48*/ UnityEngine.Rendering.ColorParameter colorFilter;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter hueShift;
                /*0x58*/ UnityEngine.Rendering.ClampedFloatParameter saturation;

                /*0x13a1a60*/ ColorAdjustments();
                /*0x13a1960*/ bool IsActive();
                /*0x3ce290*/ bool IsTileCompatible();
            }

            class ColorCurves : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.TextureCurveParameter master;
                /*0x40*/ UnityEngine.Rendering.TextureCurveParameter red;
                /*0x48*/ UnityEngine.Rendering.TextureCurveParameter green;
                /*0x50*/ UnityEngine.Rendering.TextureCurveParameter blue;
                /*0x58*/ UnityEngine.Rendering.TextureCurveParameter hueVsHue;
                /*0x60*/ UnityEngine.Rendering.TextureCurveParameter hueVsSat;
                /*0x68*/ UnityEngine.Rendering.TextureCurveParameter satVsSat;
                /*0x70*/ UnityEngine.Rendering.TextureCurveParameter lumVsSat;

                /*0x13a1c20*/ ColorCurves();
                /*0x3ce290*/ bool IsActive();
                /*0x3ce290*/ bool IsTileCompatible();
            }

            class ColorLookup : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.TextureParameter texture;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter contribution;

                /*0x13a26a0*/ ColorLookup();
                /*0x13a23a0*/ bool IsActive();
                /*0x3ce290*/ bool IsTileCompatible();
                /*0x13a23f0*/ bool ValidateLUT();
            }

            enum DepthOfFieldMode
            {
                Off = 0,
                Gaussian = 1,
                Bokeh = 2,
            }

            class DepthOfField : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.Universal.DepthOfFieldModeParameter mode;
                /*0x40*/ UnityEngine.Rendering.MinFloatParameter gaussianStart;
                /*0x48*/ UnityEngine.Rendering.MinFloatParameter gaussianEnd;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter gaussianMaxRadius;
                /*0x58*/ UnityEngine.Rendering.BoolParameter highQualitySampling;
                /*0x60*/ UnityEngine.Rendering.MinFloatParameter focusDistance;
                /*0x68*/ UnityEngine.Rendering.ClampedFloatParameter aperture;
                /*0x70*/ UnityEngine.Rendering.ClampedFloatParameter focalLength;
                /*0x78*/ UnityEngine.Rendering.ClampedIntParameter bladeCount;
                /*0x80*/ UnityEngine.Rendering.ClampedFloatParameter bladeCurvature;
                /*0x88*/ UnityEngine.Rendering.ClampedFloatParameter bladeRotation;

                /*0x13a2840*/ DepthOfField();
                /*0x13a27c0*/ bool IsActive();
                /*0x348b00*/ bool IsTileCompatible();
            }

            class DepthOfFieldModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.DepthOfFieldMode>
            {
                /*0x13a2760*/ DepthOfFieldModeParameter(UnityEngine.Rendering.Universal.DepthOfFieldMode value, bool overrideState);
            }

            enum FilmGrainLookup
            {
                Thin1 = 0,
                Thin2 = 1,
                Medium1 = 2,
                Medium2 = 3,
                Medium3 = 4,
                Medium4 = 5,
                Medium5 = 6,
                Medium6 = 7,
                Large01 = 8,
                Large02 = 9,
                Custom = 10,
            }

            class FilmGrain : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.Universal.FilmGrainLookupParameter type;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter response;
                /*0x50*/ UnityEngine.Rendering.NoInterpTextureParameter texture;

                /*0x13a4950*/ FilmGrain();
                /*0x13a4880*/ bool IsActive();
                /*0x3ce290*/ bool IsTileCompatible();
            }

            class FilmGrainLookupParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.FilmGrainLookup>
            {
                /*0x13a4820*/ FilmGrainLookupParameter(UnityEngine.Rendering.Universal.FilmGrainLookup value, bool overrideState);
            }

            class LensDistortion : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter xMultiplier;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter yMultiplier;
                /*0x50*/ UnityEngine.Rendering.Vector2Parameter center;
                /*0x58*/ UnityEngine.Rendering.ClampedFloatParameter scale;

                /*0x13a65a0*/ LensDistortion();
                /*0x13a64f0*/ bool IsActive();
                /*0x348b00*/ bool IsTileCompatible();
            }

            class LiftGammaGain : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.Vector4Parameter lift;
                /*0x40*/ UnityEngine.Rendering.Vector4Parameter gamma;
                /*0x48*/ UnityEngine.Rendering.Vector4Parameter gain;

                /*0x13a6800*/ LiftGammaGain();
                /*0x13a6750*/ bool IsActive();
                /*0x3ce290*/ bool IsTileCompatible();
            }

            enum MotionBlurMode
            {
                CameraOnly = 0,
                CameraAndObjects = 1,
            }

            enum MotionBlurQuality
            {
                Low = 0,
                Medium = 1,
                High = 2,
            }

            class MotionBlur : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.Universal.MotionBlurModeParameter mode;
                /*0x40*/ UnityEngine.Rendering.Universal.MotionBlurQualityParameter quality;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter clamp;

                /*0x13aa140*/ MotionBlur();
                /*0x13aa0d0*/ bool IsActive();
                /*0x348b00*/ bool IsTileCompatible();
            }

            class MotionBlurModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.MotionBlurMode>
            {
                /*0x13aa010*/ MotionBlurModeParameter(UnityEngine.Rendering.Universal.MotionBlurMode value, bool overrideState);
            }

            class MotionBlurQualityParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.MotionBlurQuality>
            {
                /*0x13aa070*/ MotionBlurQualityParameter(UnityEngine.Rendering.Universal.MotionBlurQuality value, bool overrideState);
            }

            class PaniniProjection : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter distance;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter cropToFit;

                /*0x13ac530*/ PaniniProjection();
                /*0x13a18a0*/ bool IsActive();
                /*0x348b00*/ bool IsTileCompatible();
            }

            class ShadowsMidtonesHighlights : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.Vector4Parameter shadows;
                /*0x40*/ UnityEngine.Rendering.Vector4Parameter midtones;
                /*0x48*/ UnityEngine.Rendering.Vector4Parameter highlights;
                /*0x50*/ UnityEngine.Rendering.MinFloatParameter shadowsStart;
                /*0x58*/ UnityEngine.Rendering.MinFloatParameter shadowsEnd;
                /*0x60*/ UnityEngine.Rendering.MinFloatParameter highlightsStart;
                /*0x68*/ UnityEngine.Rendering.MinFloatParameter highlightsEnd;

                /*0x13b6f80*/ ShadowsMidtonesHighlights();
                /*0x13b6ed0*/ bool IsActive();
                /*0x3ce290*/ bool IsTileCompatible();
            }

            class SplitToning : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ColorParameter shadows;
                /*0x40*/ UnityEngine.Rendering.ColorParameter highlights;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter balance;

                /*0x13b7210*/ SplitToning();
                /*0x13b7180*/ bool IsActive();
                /*0x3ce290*/ bool IsTileCompatible();
            }

            enum TonemappingMode
            {
                None = 0,
                Neutral = 1,
                ACES = 2,
            }

            enum NeutralRangeReductionMode
            {
                Reinhard = 1,
                BT2390 = 2,
            }

            enum HDRACESPreset
            {
                ACES1000Nits = 3,
                ACES2000Nits = 4,
                ACES4000Nits = 5,
            }

            class Tonemapping : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.Universal.TonemappingModeParameter mode;
                /*0x40*/ UnityEngine.Rendering.Universal.NeutralRangeReductionModeParameter neutralHDRRangeReductionMode;
                /*0x48*/ UnityEngine.Rendering.Universal.HDRACESPresetParameter acesPreset;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter hueShiftAmount;
                /*0x58*/ UnityEngine.Rendering.BoolParameter detectPaperWhite;
                /*0x60*/ UnityEngine.Rendering.ClampedFloatParameter paperWhite;
                /*0x68*/ UnityEngine.Rendering.BoolParameter detectBrightnessLimits;
                /*0x70*/ UnityEngine.Rendering.ClampedFloatParameter minNits;
                /*0x78*/ UnityEngine.Rendering.ClampedFloatParameter maxNits;

                /*0x13b73e0*/ Tonemapping();
                /*0x13b73b0*/ bool IsActive();
                /*0x3ce290*/ bool IsTileCompatible();
            }

            class TonemappingModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.TonemappingMode>
            {
                /*0x13b7350*/ TonemappingModeParameter(UnityEngine.Rendering.Universal.TonemappingMode value, bool overrideState);
            }

            class NeutralRangeReductionModeParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.NeutralRangeReductionMode>
            {
                /*0x13ac4d0*/ NeutralRangeReductionModeParameter(UnityEngine.Rendering.Universal.NeutralRangeReductionMode value, bool overrideState);
            }

            class HDRACESPresetParameter : UnityEngine.Rendering.VolumeParameter<UnityEngine.Rendering.Universal.HDRACESPreset>
            {
                /*0x13a4f10*/ HDRACESPresetParameter(UnityEngine.Rendering.Universal.HDRACESPreset value, bool overrideState);
            }

            class Vignette : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ColorParameter color;
                /*0x40*/ UnityEngine.Rendering.Vector2Parameter center;
                /*0x48*/ UnityEngine.Rendering.ClampedFloatParameter intensity;
                /*0x50*/ UnityEngine.Rendering.ClampedFloatParameter smoothness;
                /*0x58*/ UnityEngine.Rendering.BoolParameter rounded;

                /*0x13b8550*/ Vignette();
                /*0x139fe60*/ bool IsActive();
                /*0x3ce290*/ bool IsTileCompatible();
            }

            class WhiteBalance : UnityEngine.Rendering.VolumeComponent, UnityEngine.Rendering.Universal.IPostProcessComponent
            {
                /*0x38*/ UnityEngine.Rendering.ClampedFloatParameter temperature;
                /*0x40*/ UnityEngine.Rendering.ClampedFloatParameter tint;

                /*0x13b8790*/ WhiteBalance();
                /*0x13b8710*/ bool IsActive();
                /*0x3ce290*/ bool IsTileCompatible();
            }

            class CapturePass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static string m_ProfilerTag = "Capture Pass";
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0xe0*/ UnityEngine.Rendering.RTHandle m_CameraColorHandle;

                static /*0x13a1300*/ CapturePass();
                /*0x13a1390*/ CapturePass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x13a0fa0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            class DrawScreenSpaceUIPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xe0*/ UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData m_PassData;
                /*0xe8*/ UnityEngine.Rendering.RTHandle m_ColorTarget;
                /*0xf0*/ UnityEngine.Rendering.RTHandle m_DepthTarget;
                /*0xf8*/ bool m_RenderOffscreen;

                static /*0x13a2c00*/ void ConfigureColorDescriptor(ref UnityEngine.RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight);
                static /*0x13a2c50*/ void ConfigureDepthDescriptor(ref UnityEngine.RenderTextureDescriptor descriptor, int depthBufferBits, int cameraWidth, int cameraHeight);
                static /*0x13a2ce0*/ void ExecutePass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData passData);
                /*0x13a3b70*/ DrawScreenSpaceUIPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, bool renderOffscreen);
                /*0x13a2ca0*/ void Dispose();
                /*0x13a3930*/ void Setup(ref UnityEngine.Rendering.Universal.CameraData cameraData, int depthBufferBits);
                /*0x13a2d70*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13a31c0*/ void RenderOffscreen(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, int depthBufferBits, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle output, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13a36c0*/ void RenderOverlay(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle colorBuffer, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle depthBuffer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.CommandBuffer cmd;
                    /*0x18*/ UnityEngine.Camera camera;
                    /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle offscreenTexture;

                    /*0x32f970*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.<> <>9;
                    static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData> <>9__12_0;
                    static /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData> <>9__13_0;

                    static /*0x13b8390*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x13b7b60*/ void <RenderOffscreen>b__12_0(UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    /*0x13b7cf0*/ void <RenderOverlay>b__13_0(UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                }
            }

            class DrawSkyboxPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xe0*/ bool m_IsActiveTargetBackBuffer;

                /*0x13a4770*/ DrawSkyboxPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x13a4170*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13a3c70*/ UnityEngine.Rendering.RendererList CreateSkyboxRendererList(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x13a43c0*/ void Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle colorTarget, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle depthTarget, ref UnityEngine.Rendering.Universal.RenderingData renderingData);

                class PassData
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle color;
                    /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle depth;
                    /*0x20*/ UnityEngine.Rendering.Universal.RenderingData renderingData;
                    /*0x2d8*/ UnityEngine.Rendering.Universal.DrawSkyboxPass pass;

                    /*0x32f970*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.DrawSkyboxPass.<> <>9;
                    static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.DrawSkyboxPass.PassData> <>9__5_0;

                    static /*0x13b82b0*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x13b7f10*/ void <Render>b__5_0(UnityEngine.Rendering.Universal.DrawSkyboxPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                }
            }

            class HDRDebugViewPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xe0*/ UnityEngine.Rendering.Universal.HDRDebugViewPass.PassData m_PassData;
                /*0xe8*/ UnityEngine.Rendering.RTHandle m_CIExyTarget;
                /*0xf0*/ UnityEngine.Rendering.RTHandle m_PassthroughRT;
                /*0xf8*/ UnityEngine.Rendering.RTHandle m_CameraTargetHandle;

                static /*0x13a5000*/ void ConfigureDescriptor(ref UnityEngine.RenderTextureDescriptor descriptor);
                static /*0x13a4f70*/ void ConfigureDescriptorForCIEPrepass(ref UnityEngine.RenderTextureDescriptor descriptor);
                static /*0x13a5d20*/ UnityEngine.Vector4 GetLuminanceParameters(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x13a5090*/ void ExecuteCIExyPrepass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.HDRDebugViewPass.PassData data, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Rendering.RTHandle xyTarget, UnityEngine.Rendering.RTHandle destTexture);
                static /*0x13a5480*/ void ExecuteHDRDebugViewFinalPass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.HDRDebugViewPass.PassData data, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RTHandle xyTarget);
                /*0x13a6090*/ HDRDebugViewPass(UnityEngine.Material mat);
                /*0x13a5040*/ void Dispose();
                /*0x13a5e80*/ void Setup(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.HDRDebugMode hdrdebugMode);
                /*0x13a5820*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13a5770*/ void ExecutePass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.HDRDebugViewPass.PassData data, UnityEngine.Rendering.RTHandle sourceTexture, UnityEngine.Rendering.RTHandle xyTarget);

                enum HDRDebugPassId
                {
                    CIExyPrepass = 0,
                    DebugViewPass = 1,
                }

                class PassData
                {
                    /*0x10*/ UnityEngine.Material material;
                    /*0x18*/ UnityEngine.Rendering.Universal.HDRDebugMode hdrDebugMode;
                    /*0x1c*/ UnityEngine.Vector4 luminanceParameters;
                    /*0x30*/ UnityEngine.Rendering.Universal.CameraData cameraData;

                    /*0x32f970*/ PassData();
                }

                class ShaderConstants
                {
                    static /*0x0*/ int _DebugHDRModeId;
                    static /*0x4*/ int _HDRDebugParamsId;
                    static /*0x8*/ int _xyTextureId;
                    static /*0xc*/ int _SizeOfHDRXYMapping;
                    static /*0x10*/ int _CIExyUAVIndex;

                    static /*0x13b6bd0*/ ShaderConstants();
                    /*0x32f970*/ ShaderConstants();
                }
            }

            class InvokeOnRenderObjectCallbackPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0x13a6440*/ InvokeOnRenderObjectCallbackPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x13a61a0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13a61f0*/ void Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle colorTarget, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle depthTarget, ref UnityEngine.Rendering.Universal.RenderingData renderingData);

                class PassData
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle colorTarget;
                    /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle depthTarget;

                    /*0x32f970*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass.<> <>9;
                    static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass.PassData> <>9__3_0;

                    static /*0x13b8470*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x13b7eb0*/ void <Render>b__3_0(UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                }
            }

            class MotionVectorRenderPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static string kPreviousViewProjectionNoJitter = "_PrevViewProjMatrix";
                static string kViewProjectionNoJitter = "_NonJitteredViewProjMatrix";
                static string kPreviousViewProjectionNoJitterStereo = "_PrevViewProjMatrixStereo";
                static string kViewProjectionNoJitterStereo = "_NonJitteredViewProjMatrixStereo";
                static UnityEngine.Experimental.Rendering.GraphicsFormat k_TargetFormat = 46;
                static /*0x0*/ string[] s_ShaderTags;
                /*0xe0*/ UnityEngine.Rendering.RTHandle m_Color;
                /*0xe8*/ UnityEngine.Rendering.RTHandle m_Depth;
                /*0xf0*/ UnityEngine.Material m_CameraMaterial;
                /*0xf8*/ UnityEngine.Material m_ObjectMaterial;
                /*0x100*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                /*0x118*/ UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData m_PassData;

                static /*0x13ab760*/ MotionVectorRenderPass();
                static /*0x13aa840*/ void ExecutePass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData passData, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x13aaf80*/ UnityEngine.Rendering.DrawingSettings GetDrawingSettings(ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Material objectMaterial);
                static /*0x13aa3c0*/ void DrawCameraMotionVectors(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Camera camera, UnityEngine.Material cameraMaterial);
                static /*0x13aa5a0*/ void DrawObjectMotionVectors(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Camera camera, UnityEngine.Material objectMaterial, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.FilteringSettings filteringSettings);
                /*0x13ab810*/ MotionVectorRenderPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material cameraMaterial, UnityEngine.Material objectMaterial, UnityEngine.LayerMask opaqueLayerMask);
                /*0x13ab710*/ void Setup(UnityEngine.Rendering.RTHandle color, UnityEngine.Rendering.RTHandle depth);
                /*0x13aa2c0*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                /*0x13aae90*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13ab2c0*/ void Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle motionVectorColor, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle motionVectorDepth, ref UnityEngine.Rendering.Universal.RenderingData renderingData);

                class PassData
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle motionVectorColor;
                    /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle motionVectorDepth;
                    /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraDepth;
                    /*0x28*/ UnityEngine.Rendering.Universal.RenderingData renderingData;
                    /*0x2e0*/ UnityEngine.Material cameraMaterial;
                    /*0x2e8*/ UnityEngine.Material objectMaterial;
                    /*0x2f0*/ UnityEngine.Rendering.FilteringSettings filteringSettings;

                    /*0x32f970*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.MotionVectorRenderPass.<> <>9;
                    static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData> <>9__21_0;

                    static /*0x13b8240*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x13b7da0*/ void <Render>b__21_0(UnityEngine.Rendering.Universal.MotionVectorRenderPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                }
            }

            interface IPostProcessComponent
            {
                /*0x17cb40*/ bool IsActive();
                /*0x17cb40*/ bool IsTileCompatible();
            }

            class PostProcessPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static string k_RenderPostProcessingTag = "Render PostProcessing Effects";
                static string k_RenderFinalPostProcessingTag = "Render Final PostProcessing Pass";
                static int k_MaxPyramidSize = 16;
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingRenderPostProcessing;
                static /*0x8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingRenderFinalPostProcessing;
                static /*0x10*/ int k_ShaderPropertyId_ViewProjM;
                static /*0x14*/ int k_ShaderPropertyId_PrevViewProjM;
                static /*0x18*/ int k_ShaderPropertyId_ViewProjMStereo;
                static /*0x1c*/ int k_ShaderPropertyId_PrevViewProjMStereo;
                /*0xe0*/ UnityEngine.RenderTextureDescriptor m_Descriptor;
                /*0x118*/ UnityEngine.Rendering.RTHandle m_Source;
                /*0x120*/ UnityEngine.Rendering.RTHandle m_Destination;
                /*0x128*/ UnityEngine.Rendering.RTHandle m_Depth;
                /*0x130*/ UnityEngine.Rendering.RTHandle m_InternalLut;
                /*0x138*/ UnityEngine.Rendering.RTHandle m_MotionVectors;
                /*0x140*/ UnityEngine.Rendering.RTHandle m_FullCoCTexture;
                /*0x148*/ UnityEngine.Rendering.RTHandle m_HalfCoCTexture;
                /*0x150*/ UnityEngine.Rendering.RTHandle m_PingTexture;
                /*0x158*/ UnityEngine.Rendering.RTHandle m_PongTexture;
                /*0x160*/ UnityEngine.Rendering.RTHandle[] m_BloomMipDown;
                /*0x168*/ UnityEngine.Rendering.RTHandle[] m_BloomMipUp;
                /*0x170*/ UnityEngine.Rendering.RTHandle m_BlendTexture;
                /*0x178*/ UnityEngine.Rendering.RTHandle m_EdgeColorTexture;
                /*0x180*/ UnityEngine.Rendering.RTHandle m_EdgeStencilTexture;
                /*0x188*/ UnityEngine.Rendering.RTHandle m_TempTarget;
                /*0x190*/ UnityEngine.Rendering.RTHandle m_TempTarget2;
                /*0x198*/ UnityEngine.Rendering.Universal.PostProcessPass.MaterialLibrary m_Materials;
                /*0x1a0*/ UnityEngine.Rendering.Universal.PostProcessData m_Data;
                /*0x1a8*/ UnityEngine.Rendering.Universal.DepthOfField m_DepthOfField;
                /*0x1b0*/ UnityEngine.Rendering.Universal.MotionBlur m_MotionBlur;
                /*0x1b8*/ UnityEngine.Rendering.Universal.PaniniProjection m_PaniniProjection;
                /*0x1c0*/ UnityEngine.Rendering.Universal.Bloom m_Bloom;
                /*0x1c8*/ UnityEngine.Rendering.Universal.LensDistortion m_LensDistortion;
                /*0x1d0*/ UnityEngine.Rendering.Universal.ChromaticAberration m_ChromaticAberration;
                /*0x1d8*/ UnityEngine.Rendering.Universal.Vignette m_Vignette;
                /*0x1e0*/ UnityEngine.Rendering.Universal.ColorLookup m_ColorLookup;
                /*0x1e8*/ UnityEngine.Rendering.Universal.ColorAdjustments m_ColorAdjustments;
                /*0x1f0*/ UnityEngine.Rendering.Universal.Tonemapping m_Tonemapping;
                /*0x1f8*/ UnityEngine.Rendering.Universal.FilmGrain m_FilmGrain;
                /*0x200*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_DefaultHDRFormat;
                /*0x204*/ bool m_UseRGBM;
                /*0x208*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_SMAAEdgeFormat;
                /*0x20c*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_GaussianCoCFormat;
                /*0x210*/ int m_DitheringTextureIndex;
                /*0x218*/ UnityEngine.Rendering.RenderTargetIdentifier[] m_MRT2;
                /*0x220*/ UnityEngine.Vector4[] m_BokehKernel;
                /*0x228*/ int m_BokehHash;
                /*0x22c*/ float m_BokehMaxRadius;
                /*0x230*/ float m_BokehRCPAspect;
                /*0x234*/ bool m_IsFinalPass;
                /*0x235*/ bool m_HasFinalPass;
                /*0x236*/ bool m_EnableColorEncodingIfNeeded;
                /*0x237*/ bool m_UseFastSRGBLinearConversion;
                /*0x238*/ bool m_SupportDataDrivenLensFlare;
                /*0x239*/ bool m_ResolveToScreen;
                /*0x23a*/ bool m_UseSwapBuffer;
                /*0x240*/ UnityEngine.Rendering.RTHandle m_ScalingSetupTarget;
                /*0x248*/ UnityEngine.Rendering.RTHandle m_UpscaledTarget;
                /*0x250*/ UnityEngine.Material m_BlitMaterial;

                static /*0x13b5070*/ PostProcessPass();
                static /*0x13aee40*/ UnityEngine.RenderTextureDescriptor GetCompatibleDescriptor(UnityEngine.RenderTextureDescriptor desc, int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.DepthBits depthBufferBits);
                static /*0x13af200*/ float GetMaxBokehRadiusInPixels(float viewportHeight);
                static /*0x13aefe0*/ float GetLensFlareLightAttenuation(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                static /*0x13b4e10*/ void UpdateMotionBlurMatrices(ref UnityEngine.Material material, UnityEngine.Camera camera, UnityEngine.Experimental.Rendering.XRPass xr);
                /*0x13b5200*/ PostProcessPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.PostProcessData data, ref UnityEngine.Rendering.Universal.PostProcessParams postProcessParams);
                /*0x13ac760*/ void Cleanup();
                /*0x13ac790*/ void Dispose();
                /*0x13b4920*/ void Setup(ref UnityEngine.RenderTextureDescriptor baseDescriptor, ref UnityEngine.Rendering.RTHandle source, bool resolveToScreen, ref UnityEngine.Rendering.RTHandle depth, ref UnityEngine.Rendering.RTHandle internalLut, ref UnityEngine.Rendering.RTHandle motionVectors, bool hasFinalPass, bool enableColorEncoding);
                /*0x13b3e00*/ void SetupFinalPass(ref UnityEngine.Rendering.RTHandle source, bool useSwapBuffer, bool enableColorEncoding);
                /*0x13afb10*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x348b00*/ bool CanRunOnTile();
                /*0x13ae990*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13aeda0*/ UnityEngine.RenderTextureDescriptor GetCompatibleDescriptor();
                /*0x13aeec0*/ UnityEngine.RenderTextureDescriptor GetCompatibleDescriptor(int width, int height, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Rendering.DepthBits depthBufferBits);
                /*0x13b2840*/ bool RequireSRGBConversionBlitToBackBuffer(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x13b2810*/ bool RequireHDROutput(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x13b0960*/ void Render(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13ae180*/ void DoSubpixelMorphologicalAntialiasing(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination);
                /*0x13ad140*/ void DoDepthOfField(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect pixelRect);
                /*0x13ad270*/ void DoGaussianDepthOfField(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect pixelRect);
                /*0x13afb20*/ void PrepareBokehKernel(float maxRadius, float rcpAspect);
                /*0x13ac930*/ void DoBokehDepthOfField(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rect pixelRect);
                /*0x13af220*/ void LensFlareDataDrivenComputeOcclusion(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit);
                /*0x13af620*/ void LensFlareDataDriven(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit);
                /*0x13adbf0*/ void DoMotionBlur(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x13ade30*/ void DoPaniniProjection(UnityEngine.Camera camera, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination);
                /*0x13ac6f0*/ UnityEngine.Vector2 CalcViewExtents(UnityEngine.Camera camera);
                /*0x13ac600*/ UnityEngine.Vector2 CalcCropExtents(UnityEngine.Camera camera, float d);
                /*0x13b2870*/ void SetupBloom(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Material uberMaterial);
                /*0x13b4140*/ void SetupLensDistortion(UnityEngine.Material material, bool isSceneView);
                /*0x13b3770*/ void SetupChromaticAberration(UnityEngine.Material material);
                /*0x13b45b0*/ void SetupVignette(UnityEngine.Material material, UnityEngine.Experimental.Rendering.XRPass xrPass);
                /*0x13b3880*/ void SetupColorGrading(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Material material);
                /*0x13b3ec0*/ void SetupGrain(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Material material);
                /*0x13b3d50*/ void SetupDithering(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Material material);
                /*0x13b4030*/ void SetupHDROutput(UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, UnityEngine.ColorGamut hdrDisplayColorGamut, UnityEngine.Material material, UnityEngine.Rendering.HDROutputUtils.Operation hdrOperations);
                /*0x13aff20*/ void RenderFinalPass(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x132f7f0*/ UnityEngine.Rendering.RTHandle <Render>g__GetSource|68_0(ref UnityEngine.Rendering.Universal.PostProcessPass.<> );
                /*0x13b4a90*/ UnityEngine.Rendering.RTHandle <Render>g__GetDestination|68_1(ref UnityEngine.Rendering.Universal.PostProcessPass.<> );
                /*0x13b4cd0*/ void <Render>g__Swap|68_2(ref UnityEngine.Rendering.Universal.ScriptableRenderer r, ref UnityEngine.Rendering.Universal.PostProcessPass.<> );

                class MaterialLibrary
                {
                    /*0x10*/ UnityEngine.Material stopNaN;
                    /*0x18*/ UnityEngine.Material subpixelMorphologicalAntialiasing;
                    /*0x20*/ UnityEngine.Material gaussianDepthOfField;
                    /*0x28*/ UnityEngine.Material bokehDepthOfField;
                    /*0x30*/ UnityEngine.Material cameraMotionBlur;
                    /*0x38*/ UnityEngine.Material paniniProjection;
                    /*0x40*/ UnityEngine.Material bloom;
                    /*0x48*/ UnityEngine.Material temporalAntialiasing;
                    /*0x50*/ UnityEngine.Material scalingSetup;
                    /*0x58*/ UnityEngine.Material easu;
                    /*0x60*/ UnityEngine.Material uber;
                    /*0x68*/ UnityEngine.Material finalPass;
                    /*0x70*/ UnityEngine.Material lensFlareDataDriven;

                    /*0x13bacd0*/ MaterialLibrary(UnityEngine.Rendering.Universal.PostProcessData data);
                    /*0x13bab70*/ UnityEngine.Material Load(UnityEngine.Shader shader);
                    /*0x13baa90*/ void Cleanup();
                }

                class ShaderConstants
                {
                    static /*0x0*/ int _TempTarget;
                    static /*0x4*/ int _TempTarget2;
                    static /*0x8*/ int _StencilRef;
                    static /*0xc*/ int _StencilMask;
                    static /*0x10*/ int _FullCoCTexture;
                    static /*0x14*/ int _HalfCoCTexture;
                    static /*0x18*/ int _DofTexture;
                    static /*0x1c*/ int _CoCParams;
                    static /*0x20*/ int _BokehKernel;
                    static /*0x24*/ int _BokehConstants;
                    static /*0x28*/ int _PongTexture;
                    static /*0x2c*/ int _PingTexture;
                    static /*0x30*/ int _Metrics;
                    static /*0x34*/ int _AreaTexture;
                    static /*0x38*/ int _SearchTexture;
                    static /*0x3c*/ int _EdgeTexture;
                    static /*0x40*/ int _BlendTexture;
                    static /*0x44*/ int _ColorTexture;
                    static /*0x48*/ int _Params;
                    static /*0x4c*/ int _SourceTexLowMip;
                    static /*0x50*/ int _Bloom_Params;
                    static /*0x54*/ int _Bloom_RGBM;
                    static /*0x58*/ int _Bloom_Texture;
                    static /*0x5c*/ int _LensDirt_Texture;
                    static /*0x60*/ int _LensDirt_Params;
                    static /*0x64*/ int _LensDirt_Intensity;
                    static /*0x68*/ int _Distortion_Params1;
                    static /*0x6c*/ int _Distortion_Params2;
                    static /*0x70*/ int _Chroma_Params;
                    static /*0x74*/ int _Vignette_Params1;
                    static /*0x78*/ int _Vignette_Params2;
                    static /*0x7c*/ int _Vignette_ParamsXR;
                    static /*0x80*/ int _Lut_Params;
                    static /*0x84*/ int _UserLut_Params;
                    static /*0x88*/ int _InternalLut;
                    static /*0x8c*/ int _UserLut;
                    static /*0x90*/ int _DownSampleScaleFactor;
                    static /*0x94*/ int _FlareOcclusionRemapTex;
                    static /*0x98*/ int _FlareOcclusionTex;
                    static /*0x9c*/ int _FlareOcclusionIndex;
                    static /*0xa0*/ int _FlareTex;
                    static /*0xa4*/ int _FlareColorValue;
                    static /*0xa8*/ int _FlareData0;
                    static /*0xac*/ int _FlareData1;
                    static /*0xb0*/ int _FlareData2;
                    static /*0xb4*/ int _FlareData3;
                    static /*0xb8*/ int _FlareData4;
                    static /*0xbc*/ int _FlareData5;
                    static /*0xc0*/ int _FullscreenProjMat;
                    static /*0xc8*/ int[] _BloomMipUp;
                    static /*0xd0*/ int[] _BloomMipDown;

                    static /*0x13cabe0*/ ShaderConstants();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.PostProcessPass.<> <>9;
                    static /*0x8*/ System.Func<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, float> <>9__77_0;

                    static /*0x13d1c30*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x13d1620*/ float <LensFlareDataDriven>b__77_0(UnityEngine.Light light, UnityEngine.Camera cam, UnityEngine.Vector3 wo);
                }

                struct <>c__DisplayClass68_0
                {
                    /*0x10*/ UnityEngine.Rendering.RTHandle source;
                    /*0x18*/ UnityEngine.Rendering.RTHandle destination;
                    /*0x20*/ UnityEngine.Rendering.Universal.PostProcessPass <>4__this;
                    /*0x28*/ int amountOfPassesRemaining;
                    /*0x30*/ UnityEngine.Rendering.CommandBuffer cmd;
                }
            }

            enum ScriptableRenderPassInput
            {
                None = 0,
                Depth = 1,
                Normal = 2,
                Color = 4,
                Motion = 8,
            }

            enum RenderPassEvent
            {
                BeforeRendering = 0,
                BeforeRenderingShadows = 50,
                AfterRenderingShadows = 100,
                BeforeRenderingPrePasses = 150,
                AfterRenderingPrePasses = 200,
                BeforeRenderingGbuffer = 210,
                AfterRenderingGbuffer = 220,
                BeforeRenderingDeferredLights = 230,
                AfterRenderingDeferredLights = 240,
                BeforeRenderingOpaques = 250,
                AfterRenderingOpaques = 300,
                BeforeRenderingSkybox = 350,
                AfterRenderingSkybox = 400,
                BeforeRenderingTransparents = 450,
                AfterRenderingTransparents = 500,
                BeforeRenderingPostProcessing = 550,
                AfterRenderingPostProcessing = 600,
                AfterRendering = 1000,
            }

            class RenderPassEventsEnumValues
            {
                static /*0x0*/ int[] values;

                static /*0x13bfbe0*/ RenderPassEventsEnumValues();
            }

            class TransparentSettingsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                static string m_ProfilerTag = "Transparent Settings Pass";
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                /*0xe0*/ bool m_shouldReceiveShadows;

                static /*0x13d14d0*/ TransparentSettingsPass();
                static /*0x13d1330*/ void ExecutePass(UnityEngine.Rendering.CommandBuffer cmd, bool shouldReceiveShadows);
                /*0x13d1560*/ TransparentSettingsPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, bool shadowReceiveSupported);
                /*0x13d14c0*/ bool Setup();
                /*0x13d1450*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
            }

            class XROcclusionMeshPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
            {
                /*0xe0*/ UnityEngine.Rendering.Universal.XROcclusionMeshPass.PassData m_PassData;
                /*0xe8*/ bool m_IsActiveTargetBackBuffer;

                static /*0x13d1ca0*/ void ExecutePass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.XROcclusionMeshPass.PassData data);
                /*0x13d2280*/ XROcclusionMeshPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                /*0x13d1d50*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13d1ed0*/ void Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraColorAttachment, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraDepthAttachment, ref UnityEngine.Rendering.Universal.RenderingData renderingData);

                class PassData
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.RenderingData renderingData;
                    /*0x2c8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraColorAttachment;
                    /*0x2d0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraDepthAttachment;
                    /*0x2d8*/ bool isActiveTargetBackBuffer;

                    /*0x32f970*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.XROcclusionMeshPass.<> <>9;
                    static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.XROcclusionMeshPass.PassData> <>9__6_0;

                    static /*0x13d1bc0*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x13d1b00*/ void <Render>b__6_0(UnityEngine.Rendering.Universal.XROcclusionMeshPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                }
            }

            struct PostProcessParams
            {
                /*0x10*/ UnityEngine.Material blitMaterial;
                /*0x18*/ UnityEngine.Experimental.Rendering.GraphicsFormat requestHDRFormat;

                static /*0x13baf40*/ UnityEngine.Rendering.Universal.PostProcessParams Create();
            }

            struct PostProcessPasses : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass m_ColorGradingLutPass;
                /*0x18*/ UnityEngine.Rendering.Universal.PostProcessPass m_PostProcessPass;
                /*0x20*/ UnityEngine.Rendering.Universal.PostProcessPass m_FinalPostProcessPass;
                /*0x28*/ UnityEngine.Rendering.RTHandle m_AfterPostProcessColor;
                /*0x30*/ UnityEngine.Rendering.RTHandle m_ColorGradingLut;
                /*0x38*/ UnityEngine.Rendering.Universal.PostProcessData m_RendererPostProcessData;
                /*0x40*/ UnityEngine.Rendering.Universal.PostProcessData m_CurrentPostProcessData;
                /*0x48*/ UnityEngine.Material m_BlitMaterial;

                /*0x13bb280*/ PostProcessPasses(UnityEngine.Rendering.Universal.PostProcessData rendererPostProcessData, ref UnityEngine.Rendering.Universal.PostProcessParams postProcessParams);
                /*0x6937d0*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass get_colorGradingLutPass();
                /*0xa5a7f0*/ UnityEngine.Rendering.Universal.PostProcessPass get_postProcessPass();
                /*0x73d3e0*/ UnityEngine.Rendering.Universal.PostProcessPass get_finalPostProcessPass();
                /*0x32f410*/ UnityEngine.Rendering.RTHandle get_afterPostProcessColor();
                /*0x61a260*/ UnityEngine.Rendering.RTHandle get_colorGradingLut();
                /*0x13bb340*/ bool get_isCreated();
                /*0x13bafe0*/ void Recreate(UnityEngine.Rendering.Universal.PostProcessData data, ref UnityEngine.Rendering.Universal.PostProcessParams ppParams);
                /*0x13baf70*/ void Dispose();
                /*0x13bb220*/ void ReleaseRenderTargets();
            }

            class PostProcessUtils
            {
                static /*0x13bb5a0*/ int ConfigureDithering(UnityEngine.Rendering.Universal.PostProcessData data, int index, UnityEngine.Camera camera, UnityEngine.Material material);
                static /*0x13bb390*/ int ConfigureDithering(UnityEngine.Rendering.Universal.PostProcessData data, int index, int cameraPixelWidth, int cameraPixelHeight, UnityEngine.Material material);
                static /*0x13bb9d0*/ void ConfigureFilmGrain(UnityEngine.Rendering.Universal.PostProcessData data, UnityEngine.Rendering.Universal.FilmGrain settings, UnityEngine.Camera camera, UnityEngine.Material material);
                static /*0x13bb620*/ void ConfigureFilmGrain(UnityEngine.Rendering.Universal.PostProcessData data, UnityEngine.Rendering.Universal.FilmGrain settings, int cameraPixelWidth, int cameraPixelHeight, UnityEngine.Material material);
                static /*0x13bba60*/ void SetSourceSize(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor desc);

                class ShaderConstants
                {
                    static /*0x0*/ int _Grain_Texture;
                    static /*0x4*/ int _Grain_Params;
                    static /*0x8*/ int _Grain_TilingParams;
                    static /*0xc*/ int _BlueNoise_Texture;
                    static /*0x10*/ int _Dithering_Params;
                    static /*0x14*/ int _SourceSize;

                    static /*0x13caab0*/ ShaderConstants();
                }
            }

            struct ReflectionProbeManager : System.IDisposable
            {
                static int k_MaxMipCount = 7;
                static string k_ReflectionProbeAtlasName = "URP Reflection Probe Atlas";
                /*0x10*/ Unity.Mathematics.int2 m_Resolution;
                /*0x18*/ UnityEngine.RenderTexture m_AtlasTexture0;
                /*0x20*/ UnityEngine.RenderTexture m_AtlasTexture1;
                /*0x28*/ UnityEngine.Rendering.Universal.BuddyAllocator m_AtlasAllocator;
                /*0x50*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.Universal.ReflectionProbeManager.CachedProbe> m_Cache;
                /*0x58*/ System.Collections.Generic.Dictionary<int, int> m_WarningCache;
                /*0x60*/ System.Collections.Generic.List<int> m_NeedsUpdate;
                /*0x68*/ System.Collections.Generic.List<int> m_NeedsRemove;
                /*0x70*/ UnityEngine.Vector4[] m_BoxMax;
                /*0x78*/ UnityEngine.Vector4[] m_BoxMin;
                /*0x80*/ UnityEngine.Vector4[] m_ProbePosition;
                /*0x88*/ UnityEngine.Vector4[] m_MipScaleOffset;

                static /*0x13bd0a0*/ UnityEngine.Rendering.Universal.ReflectionProbeManager Create();
                /*0xa5a7f0*/ UnityEngine.RenderTexture get_atlasRT();
                /*0x13bd380*/ void Init();
                /*0x13bd850*/ void UpdateGpuData(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13bd1b0*/ Unity.Mathematics.float4 GetScaleOffset(int level, int dataIndex, bool includePadding, bool yflip);
                /*0x13bd0e0*/ void Dispose();

                struct CachedProbe
                {
                    /*0x10*/ uint updateCount;
                    /*0x18*/ UnityEngine.Hash128 imageContentsHash;
                    /*0x28*/ int size;
                    /*0x2c*/ int mipCount;
                    /*0x30*/ UnityEngine.Rendering.Universal.ReflectionProbeManager.CachedProbe.<dataIndices> dataIndices;
                    /*0x4c*/ UnityEngine.Rendering.Universal.ReflectionProbeManager.CachedProbe.<levels> levels;
                    /*0x68*/ UnityEngine.Texture texture;
                    /*0x70*/ int lastUsed;
                    /*0x74*/ UnityEngine.Vector4 hdrData;

                    struct <dataIndices>e__FixedBuffer
                    {
                        /*0x10*/ int FixedElementField;
                    }

                    struct <levels>e__FixedBuffer
                    {
                        /*0x10*/ int FixedElementField;
                    }
                }

                class ShaderProperties
                {
                    static /*0x0*/ int BoxMin;
                    static /*0x4*/ int BoxMax;
                    static /*0x8*/ int ProbePosition;
                    static /*0xc*/ int MipScaleOffset;
                    static /*0x10*/ int Count;
                    static /*0x14*/ int Atlas;

                    static /*0x13cb7b0*/ ShaderProperties();
                }
            }

            enum DecalSurfaceData
            {
                Albedo = 0,
                AlbedoNormal = 1,
                AlbedoNormalMAOS = 2,
            }

            enum DecalTechnique
            {
                Invalid = 0,
                DBuffer = 1,
                ScreenSpace = 2,
                GBuffer = 3,
            }

            enum DecalTechniqueOption
            {
                Automatic = 0,
                DBuffer = 1,
                ScreenSpace = 2,
            }

            class DBufferSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalSurfaceData surfaceData;

                /*0x13b89e0*/ DBufferSettings();
            }

            enum DecalNormalBlend
            {
                Low = 0,
                Medium = 1,
                High = 2,
            }

            class DecalScreenSpaceSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalNormalBlend normalBlend;

                /*0x32f970*/ DecalScreenSpaceSettings();
            }

            class DecalSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalTechniqueOption technique;
                /*0x14*/ float maxDrawDistance;
                /*0x18*/ bool decalLayers;
                /*0x20*/ UnityEngine.Rendering.Universal.DBufferSettings dBufferSettings;
                /*0x28*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings screenSpaceSettings;

                /*0x13ba200*/ DecalSettings();
            }

            class SharedDecalEntityManager : System.IDisposable
            {
                /*0x10*/ UnityEngine.Rendering.Universal.DecalEntityManager m_DecalEntityManager;
                /*0x18*/ int m_ReferenceCounter;

                /*0x32f970*/ SharedDecalEntityManager();
                /*0x13cef40*/ UnityEngine.Rendering.Universal.DecalEntityManager Get();
                /*0x13cf350*/ void Release(UnityEngine.Rendering.Universal.DecalEntityManager decalEntityManager);
                /*0x13cedb0*/ void Dispose();
                /*0x13cf1f0*/ void OnDecalAdd(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x13cf320*/ void OnDecalRemove(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x13cf2c0*/ void OnDecalPropertyChange(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
                /*0x13cf1d0*/ void OnAllDecalPropertyChange();
                /*0x13cf250*/ void OnDecalMaterialChange(UnityEngine.Rendering.Universal.DecalProjector decalProjector);
            }

            class DecalRendererFeature : UnityEngine.Rendering.Universal.ScriptableRendererFeature
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.SharedDecalEntityManager <sharedDecalEntityManager>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.Universal.DecalSettings m_Settings;
                /*0x28*/ UnityEngine.Shader m_CopyDepthPS;
                /*0x30*/ UnityEngine.Shader m_DBufferClear;
                /*0x38*/ UnityEngine.Rendering.Universal.DecalTechnique m_Technique;
                /*0x40*/ UnityEngine.Rendering.Universal.DBufferSettings m_DBufferSettings;
                /*0x48*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings m_ScreenSpaceSettings;
                /*0x50*/ bool m_RecreateSystems;
                /*0x58*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_CopyDepthPass;
                /*0x60*/ UnityEngine.Rendering.Universal.DecalPreviewPass m_DecalPreviewPass;
                /*0x68*/ UnityEngine.Material m_CopyDepthMaterial;
                /*0x70*/ UnityEngine.Rendering.Universal.DecalEntityManager m_DecalEntityManager;
                /*0x78*/ UnityEngine.Rendering.Universal.DecalUpdateCachedSystem m_DecalUpdateCachedSystem;
                /*0x80*/ UnityEngine.Rendering.Universal.DecalUpdateCullingGroupSystem m_DecalUpdateCullingGroupSystem;
                /*0x88*/ UnityEngine.Rendering.Universal.DecalUpdateCulledSystem m_DecalUpdateCulledSystem;
                /*0x90*/ UnityEngine.Rendering.Universal.DecalCreateDrawCallSystem m_DecalCreateDrawCallSystem;
                /*0x98*/ UnityEngine.Rendering.Universal.DecalDrawErrorSystem m_DrawErrorSystem;
                /*0xa0*/ UnityEngine.Rendering.Universal.DBufferRenderPass m_DBufferRenderPass;
                /*0xa8*/ UnityEngine.Rendering.Universal.DecalForwardEmissivePass m_ForwardEmissivePass;
                /*0xb0*/ UnityEngine.Rendering.Universal.DecalDrawDBufferSystem m_DecalDrawDBufferSystem;
                /*0xb8*/ UnityEngine.Rendering.Universal.DecalDrawFowardEmissiveSystem m_DecalDrawForwardEmissiveSystem;
                /*0xc0*/ UnityEngine.Material m_DBufferClearMaterial;
                /*0xc8*/ UnityEngine.Rendering.Universal.DecalScreenSpaceRenderPass m_ScreenSpaceDecalRenderPass;
                /*0xd0*/ UnityEngine.Rendering.Universal.DecalDrawScreenSpaceSystem m_DecalDrawScreenSpaceSystem;
                /*0xd8*/ UnityEngine.Rendering.Universal.DecalSkipCulledSystem m_DecalSkipCulledSystem;
                /*0xe0*/ UnityEngine.Rendering.Universal.DecalGBufferRenderPass m_GBufferRenderPass;
                /*0xe8*/ UnityEngine.Rendering.Universal.DecalDrawGBufferSystem m_DrawGBufferSystem;
                /*0xf0*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;

                static /*0x13ba030*/ DecalRendererFeature();
                static /*0x13ba1b0*/ UnityEngine.Rendering.Universal.SharedDecalEntityManager get_sharedDecalEntityManager();
                static /*0x13ba140*/ bool get_isGLDevice();
                /*0x13ba0b0*/ DecalRendererFeature();
                /*0x13ba1a0*/ ref UnityEngine.Rendering.Universal.DecalSettings get_settings();
                /*0x13ba130*/ bool get_intermediateRendering();
                /*0x13ba180*/ bool get_requiresDecalLayers();
                /*0x13b8b70*/ void Create();
                /*0x13b9d30*/ bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event atEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                /*0x13b8e80*/ UnityEngine.Rendering.Universal.DBufferSettings GetDBufferSettings();
                /*0x13b8f00*/ UnityEngine.Rendering.Universal.DecalScreenSpaceSettings GetScreenSpaceSettings();
                /*0x13b9290*/ UnityEngine.Rendering.Universal.DecalTechnique GetTechnique(UnityEngine.Rendering.Universal.ScriptableRendererData renderer);
                /*0x13b91b0*/ UnityEngine.Rendering.Universal.DecalTechnique GetTechnique(UnityEngine.Rendering.Universal.ScriptableRenderer renderer);
                /*0x13b8f80*/ UnityEngine.Rendering.Universal.DecalTechnique GetTechnique(bool isDeferred, bool needsGBufferAccurateNormals, bool checkForInvalidTechniques);
                /*0x13b93d0*/ bool IsAutomaticDBuffer();
                /*0x13b9550*/ bool RecreateSystemsIfNeeded(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x13b9430*/ void OnCameraPreCull(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x13b89f0*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13ba010*/ bool SupportsNativeRenderPass();
                /*0x13b9df0*/ void SetupRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13b8be0*/ void Dispose(bool disposing);
                /*0x32d010*/ void ChangeAdaptivePerformanceDrawDistances();
            }

            class DisallowMultipleRendererFeature : System.Attribute
            {
                /*0x10*/ string <customTitle>k__BackingField;

                /*0xa32e30*/ DisallowMultipleRendererFeature(string customTitle);
                /*0x9f12f0*/ void set_customTitle(string value);
                /*0x73d3e0*/ string get_customTitle();
            }

            class ScreenSpaceAmbientOcclusionSettings
            {
                /*0x10*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings.AOMethodOptions AOMethod;
                /*0x14*/ bool Downsample;
                /*0x15*/ bool AfterOpaque;
                /*0x18*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings.DepthSource Source;
                /*0x1c*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings.NormalQuality NormalSamples;
                /*0x20*/ float Intensity;
                /*0x24*/ float DirectLightingStrength;
                /*0x28*/ float Radius;
                /*0x2c*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings.AOSampleOption Samples;
                /*0x30*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings.BlurQualityOptions BlurQuality;
                /*0x34*/ float Falloff;
                /*0x38*/ int SampleCount;

                /*0x13c8ce0*/ ScreenSpaceAmbientOcclusionSettings();

                enum DepthSource
                {
                    Depth = 0,
                    DepthNormals = 1,
                }

                enum NormalQuality
                {
                    Low = 0,
                    Medium = 1,
                    High = 2,
                }

                enum AOSampleOption
                {
                    High = 0,
                    Medium = 1,
                    Low = 2,
                }

                enum AOMethodOptions
                {
                    BlueNoise = 0,
                    InterleavedGradient = 1,
                }

                enum BlurQualityOptions
                {
                    High = 0,
                    Medium = 1,
                    Low = 2,
                }
            }

            class ScreenSpaceAmbientOcclusion : UnityEngine.Rendering.Universal.ScriptableRendererFeature
            {
                static string k_AOInterleavedGradientKeyword = "_INTERLEAVED_GRADIENT";
                static string k_AOBlueNoiseKeyword = "_BLUE_NOISE";
                static string k_OrthographicCameraKeyword = "_ORTHOGRAPHIC";
                static string k_SourceDepthLowKeyword = "_SOURCE_DEPTH_LOW";
                static string k_SourceDepthMediumKeyword = "_SOURCE_DEPTH_MEDIUM";
                static string k_SourceDepthHighKeyword = "_SOURCE_DEPTH_HIGH";
                static string k_SourceDepthNormalsKeyword = "_SOURCE_DEPTH_NORMALS";
                static string k_SampleCountLowKeyword = "_SAMPLE_COUNT_LOW";
                static string k_SampleCountMediumKeyword = "_SAMPLE_COUNT_MEDIUM";
                static string k_SampleCountHighKeyword = "_SAMPLE_COUNT_HIGH";
                /*0x20*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings m_Settings;
                /*0x28*/ UnityEngine.Texture2D[] m_BlueNoise256Textures;
                /*0x30*/ UnityEngine.Shader m_Shader;
                /*0x38*/ UnityEngine.Material m_Material;
                /*0x40*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass m_SSAOPass;

                /*0x13c92c0*/ ScreenSpaceAmbientOcclusion();
                /*0x13ba1a0*/ ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings get_settings();
                /*0x13c9000*/ void Create();
                /*0x13c8d20*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13c90b0*/ void Dispose(bool disposing);
                /*0x13c91d0*/ bool GetMaterials();

                class ScreenSpaceAmbientOcclusionPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static int k_FinalTexID = 3;
                    static string k_SSAOTextureName = "_ScreenSpaceOcclusionTexture";
                    static string k_AmbientOcclusionParamName = "_AmbientOcclusionParam";
                    static /*0x0*/ int s_AmbientOcclusionParamID;
                    static /*0x4*/ int s_SSAOParamsID;
                    static /*0x8*/ int s_SSAOBlueNoiseParamsID;
                    static /*0xc*/ int s_LastKawasePass;
                    static /*0x10*/ int s_BlueNoiseTextureID;
                    static /*0x14*/ int s_CameraViewXExtentID;
                    static /*0x18*/ int s_CameraViewYExtentID;
                    static /*0x1c*/ int s_CameraViewZExtentID;
                    static /*0x20*/ int s_ProjectionParams2ID;
                    static /*0x24*/ int s_KawaseBlurIterationID;
                    static /*0x28*/ int s_CameraViewProjectionsID;
                    static /*0x2c*/ int s_CameraViewTopLeftCornerID;
                    static /*0x30*/ int[] m_BilateralTexturesIndices;
                    static /*0x38*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] m_BilateralPasses;
                    static /*0x40*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] m_BilateralAfterOpaquePasses;
                    static /*0x48*/ int[] m_GaussianTexturesIndices;
                    static /*0x50*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] m_GaussianPasses;
                    static /*0x58*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] m_GaussianAfterOpaquePasses;
                    static /*0x60*/ int[] m_KawaseTexturesIndices;
                    static /*0x68*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] m_KawasePasses;
                    static /*0x70*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] m_KawaseAfterOpaquePasses;
                    /*0xe0*/ string profilerTag;
                    /*0xe8*/ bool m_SupportsR8RenderTextureFormat;
                    /*0xec*/ int m_BlueNoiseTextureIndex;
                    /*0xf0*/ float m_BlurRandomOffsetX;
                    /*0xf4*/ float m_BlurRandomOffsetY;
                    /*0xf8*/ UnityEngine.Material m_Material;
                    /*0x100*/ UnityEngine.Texture2D[] m_BlueNoiseTextures;
                    /*0x108*/ UnityEngine.Vector4[] m_CameraTopLeftCorner;
                    /*0x110*/ UnityEngine.Vector4[] m_CameraXExtent;
                    /*0x118*/ UnityEngine.Vector4[] m_CameraYExtent;
                    /*0x120*/ UnityEngine.Vector4[] m_CameraZExtent;
                    /*0x128*/ UnityEngine.Rendering.RTHandle[] m_SSAOTextures;
                    /*0x130*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.BlurTypes m_BlurType;
                    /*0x138*/ UnityEngine.Matrix4x4[] m_CameraViewProjections;
                    /*0x140*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                    /*0x148*/ UnityEngine.Rendering.Universal.ScriptableRenderer m_Renderer;
                    /*0x150*/ UnityEngine.RenderTextureDescriptor m_AOPassDescriptor;
                    /*0x188*/ UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings m_CurrentSettings;

                    static /*0x13c8490*/ ScreenSpaceAmbientOcclusionPass();
                    static /*0x13c7e60*/ void RenderAndSetBaseMap(ref UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Material mat, ref UnityEngine.Rendering.RTHandle baseMap, ref UnityEngine.Rendering.RTHandle target, UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses pass);
                    static /*0x13c6830*/ void GetPassOrder(UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.BlurTypes blurType, bool isAfterOpaque, ref int[] textureIndices, ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses[] shaderPasses);
                    static /*0x13c6a90*/ bool IsAfterOpaquePass(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusion.ScreenSpaceAmbientOcclusionPass.ShaderPasses pass);
                    /*0x13c8a30*/ ScreenSpaceAmbientOcclusionPass();
                    /*0x13c8c50*/ bool get_isRendererDeferred();
                    /*0x13c81c0*/ bool Setup(ref UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings featureSettings, ref UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Material material, ref UnityEngine.Texture2D[] blueNoiseTextures);
                    /*0x13c6b90*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x13c60b0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x13c6ab0*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x13c6000*/ void Dispose();

                    enum BlurTypes
                    {
                        Bilateral = 0,
                        Gaussian = 1,
                        Kawase = 2,
                    }

                    enum ShaderPasses
                    {
                        AmbientOcclusion = 0,
                        BilateralBlurHorizontal = 1,
                        BilateralBlurVertical = 2,
                        BilateralBlurFinal = 3,
                        BilateralAfterOpaque = 4,
                        GaussianBlurHorizontal = 5,
                        GaussianBlurVertical = 6,
                        GaussianAfterOpaque = 7,
                        KawaseBlur = 8,
                        KawaseAfterOpaque = 9,
                    }
                }
            }

            class ScreenSpaceShadowsSettings
            {
                /*0x32f970*/ ScreenSpaceShadowsSettings();
            }

            class ScreenSpaceShadows : UnityEngine.Rendering.Universal.ScriptableRendererFeature
            {
                static string k_ShaderName = "Hidden/Universal Render Pipeline/ScreenSpaceShadows";
                /*0x20*/ UnityEngine.Shader m_Shader;
                /*0x28*/ UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings m_Settings;
                /*0x30*/ UnityEngine.Material m_Material;
                /*0x38*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPass m_SSShadowsPass;
                /*0x40*/ UnityEngine.Rendering.Universal.ScreenSpaceShadows.ScreenSpaceShadowsPostPass m_SSShadowsPostPass;

                /*0x13ca600*/ ScreenSpaceShadows();
                /*0x13ca2a0*/ void Create();
                /*0x13c9f90*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13ca420*/ void Dispose(bool disposing);
                /*0x13ca4a0*/ bool LoadMaterial();

                class ScreenSpaceShadowsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ string m_ProfilerTag;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                    /*0xe0*/ UnityEngine.Material m_Material;
                    /*0xe8*/ UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings m_CurrentSettings;
                    /*0xf0*/ UnityEngine.Rendering.RTHandle m_RenderTarget;

                    static /*0x13c9a60*/ ScreenSpaceShadowsPass();
                    /*0x13c9b40*/ ScreenSpaceShadowsPass();
                    /*0x13491f0*/ void Dispose();
                    /*0x13c99b0*/ bool Setup(UnityEngine.Rendering.Universal.ScreenSpaceShadowsSettings featureSettings, UnityEngine.Material material);
                    /*0x13c9640*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x13c9370*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                }

                class ScreenSpaceShadowsPostPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ string m_ProfilerTag;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                    static /*0x10*/ UnityEngine.Rendering.RTHandle k_CurrentActive;

                    static /*0x13c9db0*/ ScreenSpaceShadowsPostPass();
                    /*0x13c9f40*/ ScreenSpaceShadowsPostPass();
                    /*0x13c9bd0*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x13c9c30*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                }
            }

            class RenderingLayerUtils
            {
                static /*0x13c0920*/ void CombineRendererEvents(bool isDeferred, int msaaSampleCount, UnityEngine.Rendering.Universal.RenderingLayerUtils.Event rendererEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event combinedEvent);
                static /*0x13c0aa0*/ bool RequireRenderingLayers(UnityEngine.Rendering.Universal.UniversalRendererData universalRendererData, int msaaSampleCount, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event combinedEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize combinedMaskSize);
                static /*0x13c0d80*/ bool RequireRenderingLayers(UnityEngine.Rendering.Universal.UniversalRenderer universalRenderer, System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> rendererFeatures, int msaaSampleCount, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event combinedEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize combinedMaskSize);
                static /*0x13c1070*/ void SetupProperties(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                static /*0x13c09e0*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetFormat(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                static /*0x13c11a0*/ uint ToValidRenderingLayers(uint renderingLayers);
                static /*0x13c0a60*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize GetMaskSize(int bits);
                static /*0x13c0950*/ int GetBits(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                static /*0x3306a0*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.Event Combine(UnityEngine.Rendering.Universal.RenderingLayerUtils.Event a, UnityEngine.Rendering.Universal.RenderingLayerUtils.Event b);
                static /*0x13c0940*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize Combine(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize a, UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize b);

                enum Event
                {
                    DepthNormalPrePass = 0,
                    Opaque = 1,
                }

                enum MaskSize
                {
                    Bits8 = 0,
                    Bits16 = 1,
                    Bits24 = 2,
                    Bits32 = 3,
                }
            }

            class RenderingUtils
            {
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_LegacyShaderPassNames;
                static /*0x8*/ UnityEngine.Rendering.AttachmentDescriptor s_EmptyAttachment;
                static /*0x80*/ UnityEngine.Mesh s_FullscreenMesh;
                static /*0x88*/ UnityEngine.Material s_ErrorMaterial;
                static /*0x90*/ System.Collections.Generic.Dictionary<UnityEngine.RenderTextureFormat, bool> m_RenderTextureFormatSupport;
                static /*0x98*/ System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.GraphicsFormat, System.Collections.Generic.Dictionary<UnityEngine.Experimental.Rendering.FormatUsage, bool>> m_GraphicsFormatSupport;

                static /*0x13c5360*/ RenderingUtils();
                static /*0x13c5880*/ UnityEngine.Rendering.AttachmentDescriptor get_emptyAttachment();
                static /*0x13c5a70*/ UnityEngine.Mesh get_fullscreenMesh();
                static /*0x348b00*/ bool get_useStructuredBuffer();
                static /*0x13c5250*/ bool SupportsLightLayers(UnityEngine.Rendering.GraphicsDeviceType type);
                static /*0x13c5920*/ UnityEngine.Material get_errorMaterial();
                static /*0x13c4c70*/ void SetViewAndProjectionMatrices(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix, bool setInverseMatrices);
                static /*0x13c49b0*/ void SetScaleBiasRt(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x13c1340*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rect viewport, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, UnityEngine.Material material, int passIndex);
                static /*0x13c1540*/ void Blit(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.RTHandle source, UnityEngine.Rect viewport, UnityEngine.Rendering.RTHandle destinationColor, UnityEngine.Rendering.RenderBufferLoadAction colorLoadAction, UnityEngine.Rendering.RenderBufferStoreAction colorStoreAction, UnityEngine.Rendering.RTHandle destinationDepthStencil, UnityEngine.Rendering.RenderBufferLoadAction depthStencilLoadAction, UnityEngine.Rendering.RenderBufferStoreAction depthStencilStoreAction, UnityEngine.Rendering.ClearFlag clearFlag, UnityEngine.Color clearColor, UnityEngine.Material material, int passIndex);
                static /*0x13c1fe0*/ void FinalBlit(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.RenderBufferLoadAction loadAction, UnityEngine.Rendering.RenderBufferStoreAction storeAction, UnityEngine.Material material, int passIndex);
                static /*0x13c43a0*/ void RenderObjectsWithError(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Camera camera, UnityEngine.Rendering.FilteringSettings filterSettings, UnityEngine.Rendering.SortingCriteria sortFlags);
                static /*0x13c1780*/ void ClearSystemInfoCache();
                static /*0x13c5260*/ bool SupportsRenderTextureFormat(UnityEngine.RenderTextureFormat format);
                static /*0x13c5060*/ bool SupportsGraphicsFormat(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage);
                static /*0x13c27a0*/ int GetLastValidColorBufferIndex(UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers);
                static /*0x13c29d0*/ uint GetValidColorBufferCount(UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers);
                static /*0x13c28c0*/ uint GetValidColorBufferCount(UnityEngine.Rendering.RTHandle[] colorBuffers);
                static /*0x13c2ba0*/ bool IsMRT(UnityEngine.Rendering.RenderTargetIdentifier[] colorBuffers);
                static /*0x13c2ce0*/ bool IsMRT(UnityEngine.Rendering.RTHandle[] colorBuffers);
                static /*0x13c1830*/ bool Contains(UnityEngine.Rendering.RenderTargetIdentifier[] source, UnityEngine.Rendering.RenderTargetIdentifier value);
                static /*0x13c2ad0*/ int IndexOf(UnityEngine.Rendering.RenderTargetIdentifier[] source, UnityEngine.Rendering.RenderTargetIdentifier value);
                static /*0x13c1900*/ uint CountDistinct(UnityEngine.Rendering.RenderTargetIdentifier[] source, UnityEngine.Rendering.RenderTargetIdentifier value);
                static /*0x13c2e30*/ int LastValid(UnityEngine.Rendering.RenderTargetIdentifier[] source);
                static /*0xe8dab0*/ bool Contains(UnityEngine.Rendering.ClearFlag a, UnityEngine.Rendering.ClearFlag b);
                static /*0x13c47a0*/ bool SequenceEqual(UnityEngine.Rendering.RenderTargetIdentifier[] left, UnityEngine.Rendering.RenderTargetIdentifier[] right);
                static /*0x13c2f50*/ bool MultisampleDepthResolveSupported();
                static /*0x13c2fd0*/ bool RTHandleNeedsReAlloc(UnityEngine.Rendering.RTHandle handle, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc descriptor, bool scaled);
                static /*0x13c25f0*/ UnityEngine.Rendering.RenderTargetIdentifier GetCameraTargetIdentifier(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x13c39c0*/ bool ReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
                static /*0x13c3e70*/ bool ReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, UnityEngine.Vector2 scaleFactor, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
                static /*0x13c3470*/ bool ReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, UnityEngine.Rendering.ScaleFunc scaleFunc, ref UnityEngine.RenderTextureDescriptor descriptor, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, bool isShadowMap, int anisoLevel, float mipMapBias, string name);
                static /*0x13c48a0*/ bool SetMaxRTHandlePoolCapacity(int capacity);
                static /*0x13c1270*/ void AddStaleResourceToPoolOrRelease(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc desc, UnityEngine.Rendering.RTHandle handle);
                static /*0x13c1dd0*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(UnityEngine.Rendering.ShaderTagId shaderTagId, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
                static /*0x13c1a70*/ UnityEngine.Rendering.DrawingSettings CreateDrawingSettings(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIdList, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.SortingCriteria sortingCriteria);
            }

            struct RenderTargetHandle
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.RenderTargetHandle CameraTarget;
                /*0x10*/ int <id>k__BackingField;
                /*0x18*/ UnityEngine.Rendering.RenderTargetIdentifier <rtid>k__BackingField;

                static /*0x13c04b0*/ RenderTargetHandle();
                static /*0x13c00d0*/ UnityEngine.Rendering.Universal.RenderTargetHandle GetCameraTarget(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x13c0800*/ bool op_Equality(UnityEngine.Rendering.Universal.RenderTargetHandle c1, UnityEngine.Rendering.Universal.RenderTargetHandle c2);
                static /*0x13c0880*/ bool op_Inequality(UnityEngine.Rendering.Universal.RenderTargetHandle c1, UnityEngine.Rendering.Universal.RenderTargetHandle c2);
                /*0x13c0510*/ RenderTargetHandle(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier);
                /*0x13c0580*/ RenderTargetHandle(UnityEngine.Rendering.RTHandle rtHandle);
                /*0x6bbd40*/ void set_id(int value);
                /*0x6bba50*/ int get_id();
                /*0x13c0900*/ void set_rtid(UnityEngine.Rendering.RenderTargetIdentifier value);
                /*0xba96b0*/ UnityEngine.Rendering.RenderTargetIdentifier get_rtid();
                /*0x13c0450*/ void Init(string shaderProperty);
                /*0x13c03e0*/ void Init(UnityEngine.Rendering.RenderTargetIdentifier renderTargetIdentifier);
                /*0x13c02b0*/ UnityEngine.Rendering.RenderTargetIdentifier Identifier();
                /*0x13c0260*/ bool HasInternalRenderTargetId();
                /*0x13bfec0*/ bool Equals(UnityEngine.Rendering.Universal.RenderTargetHandle other);
                /*0x13c0010*/ bool Equals(object obj);
                /*0x13c0210*/ int GetHashCode();
            }

            class RTHandleResourcePool
            {
                static /*0x0*/ int s_CurrentStaleResourceCount;
                static /*0x4*/ int s_StaleResourceLifetime;
                static /*0x8*/ int s_StaleResourceMaxCapacity;
                /*0x10*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.SortedList<int, System.ValueTuple<UnityEngine.Rendering.RTHandle, int>>> m_ResourcePool;
                /*0x18*/ System.Collections.Generic.List<int> m_RemoveList;

                static /*0x13bce80*/ RTHandleResourcePool();
                static /*0x13bcc60*/ bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex);
                static /*0x13bc060*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc CreateTextureDesc(UnityEngine.RenderTextureDescriptor desc, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureSizeMode textureSizeMode, int anisoLevel, float mipMapBias, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode, string name);
                /*0x13bcef0*/ RTHandleResourcePool();
                /*0x13bcfc0*/ int get_staleResourceCapacity();
                /*0x13bd010*/ void set_staleResourceCapacity(int value);
                /*0x13bbb50*/ bool AddResourceToPool(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc texDesc, UnityEngine.Rendering.RTHandle resource, int currentFrameIndex);
                /*0x13bccd0*/ bool TryGetResource(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc texDesc, ref UnityEngine.Rendering.RTHandle resource, bool usepool);
                /*0x13bbd80*/ void Cleanup();
                /*0x13bc840*/ void PurgeUnusedResources(int currentFrameIndex);
                /*0x13bc240*/ void LogDebugInfo();
                /*0x13bc1a0*/ int GetHashCodeWithNameHash(ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureDesc texDesc);
            }

            enum SampleCount
            {
                One = 1,
                Two = 2,
                Four = 4,
            }

            class ScriptableRendererData : UnityEngine.ScriptableObject
            {
                /*0x18*/ bool <isInvalidated>k__BackingField;
                /*0x20*/ UnityEngine.Rendering.Universal.ScriptableRendererData.DebugShaderResources debugShaders;
                /*0x28*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> m_RendererFeatures;
                /*0x30*/ System.Collections.Generic.List<long> m_RendererFeatureMap;
                /*0x38*/ bool m_UseNativeRenderPass;

                /*0x13ca6a0*/ ScriptableRendererData();
                /*0xdd36a0*/ bool get_isInvalidated();
                /*0xdd5230*/ void set_isInvalidated(bool value);
                /*0x1803b0*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x79a150*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.ScriptableRendererFeature> get_rendererFeatures();
                /*0x13ca690*/ void SetDirty();
                /*0x13ca670*/ UnityEngine.Rendering.Universal.ScriptableRenderer InternalCreateRenderer();
                /*0x13ca690*/ void OnValidate();
                /*0x13ca690*/ void OnEnable();
                /*0xd180c0*/ bool get_useNativeRenderPass();
                /*0x13ca770*/ void set_useNativeRenderPass(bool value);
                /*0x17e620*/ bool TryGetRendererFeature<T>(ref T rendererFeature);

                class DebugShaderResources
                {
                    /*0x10*/ UnityEngine.Shader debugReplacementPS;
                    /*0x18*/ UnityEngine.Shader hdrDebugViewPS;

                    /*0x32f970*/ DebugShaderResources();
                }
            }

            class ScriptableRendererFeature : UnityEngine.ScriptableObject, System.IDisposable
            {
                /*0x18*/ bool m_Active;

                /*0x13ca820*/ ScriptableRendererFeature();
                /*0xdd36a0*/ bool get_isActive();
                /*0x180fc0*/ void Create();
                /*0x32d010*/ void OnCameraPreCull(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x183150*/ void AddRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x32d010*/ void SetupRenderPasses(UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13ca7f0*/ void OnEnable();
                /*0x13ca7f0*/ void OnValidate();
                /*0x348b00*/ bool SupportsNativeRenderPass();
                /*0x13ca810*/ bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.Event atEvent, ref UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize maskSize);
                /*0xdd5230*/ void SetActive(bool active);
                /*0x13ca780*/ void Dispose();
                /*0x32d010*/ void Dispose(bool disposing);
            }

            class ShaderData : System.IDisposable
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.ShaderData m_Instance;
                /*0x10*/ UnityEngine.ComputeBuffer m_LightDataBuffer;
                /*0x18*/ UnityEngine.ComputeBuffer m_LightIndicesBuffer;
                /*0x20*/ UnityEngine.ComputeBuffer m_AdditionalLightShadowParamsStructuredBuffer;
                /*0x28*/ UnityEngine.ComputeBuffer m_AdditionalLightShadowSliceMatricesStructuredBuffer;

                static /*0x13cb6b0*/ UnityEngine.Rendering.Universal.ShaderData get_instance();
                /*0x32f970*/ ShaderData();
                /*0x13cb4c0*/ void Dispose();
                /*0x13cb610*/ UnityEngine.ComputeBuffer GetLightDataBuffer(int size);
                /*0x13cb660*/ UnityEngine.ComputeBuffer GetLightIndicesBuffer(int size);
                /*0x13cb570*/ UnityEngine.ComputeBuffer GetAdditionalLightShadowParamsStructuredBuffer(int size);
                /*0x13cb5c0*/ UnityEngine.ComputeBuffer GetAdditionalLightShadowSliceMatricesStructuredBuffer(int size);
                UnityEngine.ComputeBuffer GetOrUpdateBuffer<T>(ref UnityEngine.ComputeBuffer buffer, int size);
                /*0x13cb480*/ void DisposeBuffer(ref UnityEngine.ComputeBuffer buffer);
            }

            enum ShaderPathID
            {
                Lit = 0,
                SimpleLit = 1,
                Unlit = 2,
                TerrainLit = 3,
                ParticlesLit = 4,
                ParticlesSimpleLit = 5,
                ParticlesUnlit = 6,
                BakedLit = 7,
                SpeedTree7 = 8,
                SpeedTree7Billboard = 9,
                SpeedTree8 = 10,
            }

            class ShaderUtils
            {
                static /*0x0*/ string[] s_ShaderPaths;

                static /*0x13cbcc0*/ ShaderUtils();
                static /*0x13cb9f0*/ string GetShaderPath(UnityEngine.Rendering.Universal.ShaderPathID id);
                static /*0x13cb8e0*/ UnityEngine.Rendering.Universal.ShaderPathID GetEnumFromPath(string path);
                static /*0x13cbc30*/ bool IsLWShader(UnityEngine.Shader shader);

                class <>c__DisplayClass2_0
                {
                    /*0x10*/ string path;

                    /*0x32f970*/ <>c__DisplayClass2_0();
                    /*0x13d1b30*/ bool <GetEnumFromPath>b__0(string m);
                }
            }

            struct ShadowSliceData
            {
                /*0x10*/ UnityEngine.Matrix4x4 viewMatrix;
                /*0x50*/ UnityEngine.Matrix4x4 projectionMatrix;
                /*0x90*/ UnityEngine.Matrix4x4 shadowTransform;
                /*0xd0*/ int offsetX;
                /*0xd4*/ int offsetY;
                /*0xd8*/ int resolution;
                /*0xdc*/ UnityEngine.Rendering.ShadowSplitData splitData;

                /*0x13cbf10*/ void Clear();
            }

            class ShadowUtils
            {
                static int kMinimumPunctualLightHardShadowResolution = 8;
                static int kMinimumPunctualLightSoftShadowResolution = 16;
                static /*0x0*/ bool m_ForceShadowPointSampling;
                static /*0x4*/ int _ShadowBias;
                static /*0x8*/ int _LightDirection;
                static /*0xc*/ int _LightPosition;

                static /*0x13ceca0*/ ShadowUtils();
                static /*0x13cc320*/ bool ExtractDirectionalLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, ref UnityEngine.Vector4 cascadeSplitDistance, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix);
                static /*0x13cc450*/ bool ExtractDirectionalLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, int cascadeIndex, int shadowmapWidth, int shadowmapHeight, int shadowResolution, float shadowNearPlane, ref UnityEngine.Vector4 cascadeSplitDistance, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData);
                static /*0x13cca00*/ bool ExtractSpotLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x13cc810*/ bool ExtractPointLightMatrix(ref UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.ShadowData shadowData, int shadowLightIndex, UnityEngine.CubemapFace cubemapFace, float fovBias, ref UnityEngine.Matrix4x4 shadowMatrix, ref UnityEngine.Matrix4x4 viewMatrix, ref UnityEngine.Matrix4x4 projMatrix, ref UnityEngine.Rendering.ShadowSplitData splitData);
                static /*0x13cd990*/ void RenderShadowSlice(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Rendering.ShadowDrawingSettings settings, UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view);
                static /*0x13cd750*/ void RenderShadowSlice(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, ref UnityEngine.Rendering.ShadowDrawingSettings settings);
                static /*0x13ccbd0*/ int GetMaxTileResolutionInAtlas(int atlasWidth, int atlasHeight, int tileCount);
                static /*0x13cc150*/ void ApplySliceTransform(ref UnityEngine.Rendering.Universal.ShadowSliceData shadowSliceData, int atlasWidth, int atlasHeight);
                static /*0x13ccca0*/ UnityEngine.Vector4 GetShadowBias(ref UnityEngine.Rendering.VisibleLight shadowLight, int shadowLightIndex, ref UnityEngine.Rendering.Universal.ShadowData shadowData, UnityEngine.Matrix4x4 lightProjectionMatrix, float shadowResolution);
                static /*0x13ccc30*/ void GetScaleAndBiasForLinearDistanceFade(float fadeDistance, float border, ref float scale, ref float bias);
                static /*0x13ce1a0*/ void SetupShadowCasterConstantBuffer(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight shadowLight, UnityEngine.Vector4 shadowBias);
                static /*0x13cddf0*/ void SetShadowBias(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4 shadowBias);
                static /*0x13cdc00*/ void SetLightDirection(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector3 lightDirection);
                static /*0x13cdcb0*/ void SetLightPosition(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector3 lightPosition);
                static /*0x13cdb50*/ void SetCameraPosition(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector3 worldSpaceCameraPos);
                static /*0x13cdfa0*/ void SetWorldToCameraAndCameraToWorldMatrices(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Matrix4x4 viewMatrix);
                static /*0x13cd310*/ UnityEngine.RenderTextureDescriptor GetTemporaryShadowTextureDescriptor(int width, int height, int bits);
                static /*0x13cd4e0*/ UnityEngine.RenderTexture GetTemporaryShadowTexture(int width, int height, int bits);
                static /*0x13ce460*/ bool ShadowRTNeedsReAlloc(UnityEngine.Rendering.RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name);
                static /*0x13cc020*/ UnityEngine.Rendering.RTHandle AllocShadowRT(int width, int height, int bits, int anisoLevel, float mipMapBias, string name);
                static /*0x13ce720*/ bool ShadowRTReAllocateIfNeeded(ref UnityEngine.Rendering.RTHandle handle, int width, int height, int bits, int anisoLevel, float mipMapBias, string name);
                static /*0x13cd090*/ UnityEngine.Matrix4x4 GetShadowTransform(UnityEngine.Matrix4x4 proj, UnityEngine.Matrix4x4 view);
                static /*0x13ceb30*/ float SoftShadowQualityToShaderProperty(UnityEngine.Light light, bool softShadowsEnabled);
                static /*0x3ce290*/ bool SupportsPerLightSoftShadowQuality();
                static /*0x13cdd60*/ void SetPerLightSoftShadowKeyword(UnityEngine.Rendering.CommandBuffer cmd, bool hasSoftShadows);
                static /*0x13cde80*/ void SetSoftShadowQualityShaderKeywords(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.ShadowData shadowData);
                static /*0x13cd5e0*/ bool IsValidShadowCastingLight(ref UnityEngine.Rendering.Universal.LightData lightData, int i);
                static /*0x13ccc10*/ int GetPunctualLightShadowSlicesCount(ref UnityEngine.LightType lightType);
                static /*0x13cd740*/ int MinimalPunctualLightShadowResolution(bool softShadow);
            }

            class SpaceFillingCurves
            {
                static /*0x13cf660*/ uint Part1By1(uint x);
                static /*0x13cf500*/ uint Compact1By1(uint x);
                static /*0x13cf5d0*/ uint EncodeMorton2D(Unity.Mathematics.uint2 coord);
                static /*0x13cf540*/ Unity.Mathematics.uint2 DecodeMorton2D(uint code);
            }

            enum TemporalAAQuality
            {
                VeryLow = 0,
                Low = 1,
                Medium = 2,
                High = 3,
                VeryHigh = 4,
            }

            class TaaPersistentData
            {
                static /*0x0*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] formatList;
                /*0x10*/ UnityEngine.RenderTextureDescriptor m_RtDesc;
                /*0x48*/ UnityEngine.Rendering.RTHandle m_AccumulationTexture;
                /*0x50*/ UnityEngine.Rendering.RTHandle m_AccumulationTexture2;
                /*0x58*/ int m_LastAccumUpdateFrameIndex;
                /*0x5c*/ int m_LastAccumUpdateFrameIndex2;

                static /*0x13cfe30*/ TaaPersistentData();
                static /*0x13cfb70*/ UnityEngine.Experimental.Rendering.GraphicsFormat <Init>g__CheckFormat|12_0(UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.Experimental.Rendering.FormatUsage usage);
                static /*0x13cfd00*/ UnityEngine.Experimental.Rendering.GraphicsFormat <Init>g__FindFormat|12_1(UnityEngine.Experimental.Rendering.FormatUsage usage);
                /*0x32f970*/ TaaPersistentData();
                /*0x13cfed0*/ UnityEngine.RenderTextureDescriptor get_rtd();
                /*0x13cfec0*/ UnityEngine.Rendering.RTHandle accumulationTexture(int index);
                /*0x13cf830*/ int GetLastAccumFrameIndex(int index);
                /*0x13cfb60*/ void SetLastAccumFrameIndex(int index, int value);
                /*0x13cf840*/ void Init(int sizeX, int sizeY, int volumeDepth, UnityEngine.Experimental.Rendering.GraphicsFormat format, UnityEngine.VRTextureUsage vrUsage, UnityEngine.Rendering.TextureDimension texDim);
                /*0x13cf6a0*/ bool AllocateTargets(bool xrMultipassEnabled);
                /*0x13cf7d0*/ void DeallocateTargets();
            }

            class TemporalAA
            {
                static /*0x0*/ UnityEngine.Vector2[] taaFilterOffsets;
                static /*0x8*/ float[] taaFilterWeights;

                static /*0x13d1190*/ TemporalAA();
                static /*0x13d0140*/ UnityEngine.Matrix4x4 CalculateJitterMatrix(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x13d0360*/ UnityEngine.Vector2 CalculateJitter(int frameIndex);
                static /*0x13cff00*/ float[] CalculateFilterWeights(float jitterScale);
                static /*0x13d0fc0*/ string ValidateAndWarn(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x13d03c0*/ void ExecutePass(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Material taaMaterial, ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.RenderTexture motionVectors);
                static /*0x13d0830*/ void Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Material taaMaterial, ref UnityEngine.Rendering.Universal.CameraData cameraData, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle srcColor, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle srcDepth, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle srcMotionVectors, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle dstColor);

                class ShaderConstants
                {
                    static /*0x0*/ int _TaaAccumulationTex;
                    static /*0x4*/ int _TaaMotionVectorTex;
                    static /*0x8*/ int _TaaFilterWeights;
                    static /*0xc*/ int _TaaFrameInfluence;
                    static /*0x10*/ int _TaaVarianceClampScale;
                    static /*0x14*/ int _CameraDepthTexture;

                    static /*0x13ca980*/ ShaderConstants();
                }

                class ShaderKeywords
                {
                    static /*0x0*/ string TAA_LOW_PRECISION_SOURCE;

                    static /*0x13cb740*/ ShaderKeywords();
                }

                struct Settings
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.TemporalAAQuality m_Quality;
                    /*0x14*/ float m_FrameInfluence;
                    /*0x18*/ float m_JitterScale;
                    /*0x1c*/ float m_MipBias;
                    /*0x20*/ float m_VarianceClampScale;
                    /*0x24*/ float m_ContrastAdaptiveSharpening;
                    /*0x28*/ int resetHistoryFrames;
                    /*0x2c*/ int jitterFrameCountOffset;

                    static /*0x13ca830*/ UnityEngine.Rendering.Universal.TemporalAA.Settings Create();
                    /*0x6bba50*/ UnityEngine.Rendering.Universal.TemporalAAQuality get_quality();
                    /*0x13ca930*/ void set_quality(UnityEngine.Rendering.Universal.TemporalAAQuality value);
                    /*0x13ca860*/ float get_baseBlendFactor();
                    /*0x13ca870*/ void set_baseBlendFactor(float value);
                    /*0xa5a910*/ float get_jitterScale();
                    /*0x13ca8d0*/ void set_jitterScale(float value);
                    /*0x1202400*/ float get_mipBias();
                    /*0x13ca900*/ void set_mipBias(float value);
                    /*0x8c2b50*/ float get_varianceClampScale();
                    /*0x13ca950*/ void set_varianceClampScale(float value);
                    /*0x8c1b90*/ float get_contrastAdaptiveSharpening();
                    /*0x13ca8a0*/ void set_contrastAdaptiveSharpening(float value);
                }

                class TaaPassData
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle dstTex;
                    /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle srcColorTex;
                    /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle srcDepthTex;
                    /*0x28*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle srcMotionVectorTex;
                    /*0x30*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle srcTaaAccumTex;
                    /*0x38*/ UnityEngine.Material material;
                    /*0x40*/ int passIndex;
                    /*0x44*/ float taaFrameInfluence;
                    /*0x48*/ float taaVarianceClampScale;
                    /*0x50*/ float[] taaFilterWeights;
                    /*0x58*/ bool taaLowPrecisionSource;

                    /*0x32f970*/ TaaPassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.TemporalAA.<> <>9;
                    static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.TemporalAA.TaaPassData> <>9__11_0;
                    static /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.TemporalAA.TaaPassData> <>9__11_1;

                    static /*0x13d1b50*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x13d16a0*/ void <Render>b__11_0(UnityEngine.Rendering.Universal.TemporalAA.TaaPassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    /*0x13d19d0*/ void <Render>b__11_1(UnityEngine.Rendering.Universal.TemporalAA.TaaPassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                }
            }

            struct InclusiveRange
            {
                /*0x10*/ short start;
                /*0x12*/ short end;

                static /*0x13ba330*/ UnityEngine.Rendering.Universal.InclusiveRange Merge(UnityEngine.Rendering.Universal.InclusiveRange a, UnityEngine.Rendering.Universal.InclusiveRange b);
                static /*0x13ba440*/ UnityEngine.Rendering.Universal.InclusiveRange get_empty();
                /*0x1255a80*/ InclusiveRange(short startEnd);
                /*0xee74d0*/ InclusiveRange(short start, short end);
                /*0x13ba2b0*/ void Expand(short index);
                /*0x13ba210*/ void Clamp(short min, short max);
                /*0x13ba450*/ bool get_isEmpty();
                /*0x13ba2a0*/ bool Contains(short index);
                /*0x13ba3b0*/ string ToString();
            }

            struct LightMinMaxZJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ UnityEngine.Rendering.Universal.Fixed2<Unity.Mathematics.float4x4> worldToViews;
                /*0x90*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights;
                /*0xa0*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> minMaxZs;

                /*0x13ba460*/ void Execute(int index);
            }

            struct ReflectionProbeMinMaxZJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ UnityEngine.Rendering.Universal.Fixed2<Unity.Mathematics.float4x4> worldToViews;
                /*0x90*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleReflectionProbe> reflectionProbes;
                /*0xa0*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> minMaxZs;

                /*0x13bf8c0*/ void Execute(int index);
            }

            struct TileRangeExpansionJob : Unity.Jobs.IJobFor
            {
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.InclusiveRange> tileRanges;
                /*0x20*/ Unity.Collections.NativeArray<uint> tileMasks;
                /*0x30*/ int rangesPerItem;
                /*0x34*/ int itemsPerTile;
                /*0x38*/ int wordsPerTile;
                /*0x3c*/ Unity.Mathematics.int2 tileResolution;

                /*0x13d2d40*/ void Execute(int jobIndex);
            }

            enum TileSize
            {
                _8 = 8,
                _16 = 16,
                _32 = 32,
                _64 = 64,
            }

            class TileSizeExtensions
            {
                static /*0x13d2f90*/ bool IsValid(UnityEngine.Rendering.Universal.TileSize tileSize);
            }

            struct TilingJob : Unity.Jobs.IJobFor
            {
                static /*0x0*/ Unity.Mathematics.float3[] k_CubePoints;
                static /*0x8*/ Unity.Mathematics.int4[] k_CubeLineIndices;
                /*0x10*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights;
                /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleReflectionProbe> reflectionProbes;
                /*0x30*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.InclusiveRange> tileRanges;
                /*0x40*/ int itemsPerTile;
                /*0x44*/ int rangesPerItem;
                /*0x48*/ UnityEngine.Rendering.Universal.Fixed2<Unity.Mathematics.float4x4> worldToViews;
                /*0xc8*/ Unity.Mathematics.float2 tileScale;
                /*0xd0*/ Unity.Mathematics.float2 tileScaleInv;
                /*0xd8*/ UnityEngine.Rendering.Universal.Fixed2<float> viewPlaneBottoms;
                /*0xe0*/ UnityEngine.Rendering.Universal.Fixed2<float> viewPlaneTops;
                /*0xe8*/ UnityEngine.Rendering.Universal.Fixed2<Unity.Mathematics.float4> viewToViewportScaleBiases;
                /*0x108*/ Unity.Mathematics.int2 tileCount;
                /*0x110*/ float near;
                /*0x114*/ bool isOrthographic;
                /*0x116*/ UnityEngine.Rendering.Universal.InclusiveRange m_TileYRange;
                /*0x11c*/ int m_Offset;
                /*0x120*/ int m_ViewIndex;
                /*0x124*/ Unity.Mathematics.float2 m_CenterOffset;

                static /*0x13d9d10*/ TilingJob();
                static /*0x11b6cf0*/ float square(float x);
                static /*0x13d4bb0*/ void GetSphereHorizon(Unity.Mathematics.float2 center, float radius, float near, float clipRadius, ref Unity.Mathematics.float2 p0, ref Unity.Mathematics.float2 p1);
                static /*0x13d4ea0*/ void GetSphereYPlaneHorizon(Unity.Mathematics.float3 center, float sphereRadius, float near, float clipRadius, float y, ref Unity.Mathematics.float3 left, ref Unity.Mathematics.float3 right);
                static /*0x13d40a0*/ bool GetCircleClipPoints(Unity.Mathematics.float3 circleCenter, Unity.Mathematics.float3 circleNormal, float circleRadius, float near, ref Unity.Mathematics.float3 p0, ref Unity.Mathematics.float3 p1);
                static /*0x13d56b0*/ System.ValueTuple<float, float> IntersectEllipseLine(float a, float b, Unity.Mathematics.float3 line);
                static /*0x13d4900*/ void GetProjectedCircleHorizon(Unity.Mathematics.float2 center, float radius, Unity.Mathematics.float2 U, Unity.Mathematics.float2 V, ref Unity.Mathematics.float2 uv1, ref Unity.Mathematics.float2 uv2);
                static /*0x13d52c0*/ bool IntersectCircleYPlane(float y, Unity.Mathematics.float3 circleCenter, Unity.Mathematics.float3 circleNormal, Unity.Mathematics.float3 circleU, Unity.Mathematics.float3 circleV, float circleRadius, ref Unity.Mathematics.float3 p1, ref Unity.Mathematics.float3 p2);
                static /*0x13d4320*/ void GetConeSideTangentPoints(Unity.Mathematics.float3 vertex, Unity.Mathematics.float3 axis, float cosHalfAngle, float circleRadius, float coneHeight, float range, Unity.Mathematics.float3 circleU, Unity.Mathematics.float3 circleV, ref Unity.Mathematics.float3 l1, ref Unity.Mathematics.float3 l2);
                static /*0x13d2fb0*/ Unity.Mathematics.float3 EvaluateNearConic(float near, Unity.Mathematics.float3 o, Unity.Mathematics.float3 d, float r, Unity.Mathematics.float3 u, Unity.Mathematics.float3 v, float theta);
                static /*0x13d3660*/ Unity.Mathematics.float2 FindNearConicTangentTheta(Unity.Mathematics.float2 o, Unity.Mathematics.float2 d, float r, Unity.Mathematics.float2 u, Unity.Mathematics.float2 v);
                static /*0x13d3950*/ Unity.Mathematics.float2 FindNearConicYTheta(float near, Unity.Mathematics.float3 o, Unity.Mathematics.float3 d, float r, Unity.Mathematics.float3 u, Unity.Mathematics.float3 v, float y);
                static /*0x13d9960*/ bool <TileLight>g__SpherePointIsValid|19_0(Unity.Mathematics.float3 p, ref UnityEngine.Rendering.Universal.TilingJob.<> );
                static /*0x13d9a60*/ bool <TileLight>g__ConicPointIsValid|19_1(Unity.Mathematics.float3 p, ref UnityEngine.Rendering.Universal.TilingJob.<> );
                static /*0x13d9960*/ bool <TileLightOrthographic>g__SpherePointIsValid|20_0(Unity.Mathematics.float3 p, ref UnityEngine.Rendering.Universal.TilingJob.<> );
                /*0x13d3220*/ void Execute(int jobIndex);
                /*0x13d6850*/ void TileLight(int lightIndex);
                /*0x13d5840*/ void TileLightOrthographic(int lightIndex);
                /*0x13d8e50*/ void TileReflectionProbe(int index);
                /*0x13d9c50*/ Unity.Mathematics.float2 ViewToTileSpace(Unity.Mathematics.float3 positionVS);
                /*0x13d9ba0*/ Unity.Mathematics.float2 ViewToTileSpaceOrthographic(Unity.Mathematics.float3 positionVS);
                /*0x13d3550*/ void ExpandY(Unity.Mathematics.float3 positionVS);
                /*0x13d3360*/ void ExpandOrthographic(Unity.Mathematics.float3 positionVS);
                /*0x13d3470*/ void ExpandRangeOrthographic(ref UnityEngine.Rendering.Universal.InclusiveRange range, float xVS);

                struct <>c__DisplayClass19_0
                {
                    /*0x10*/ UnityEngine.Rendering.VisibleLight light;
                    /*0x84*/ Unity.Mathematics.float3 lightPositionVS;
                    /*0x90*/ Unity.Mathematics.float3 lightDirectionVS;
                    /*0x9c*/ float cosHalfAngle;
                    /*0xa0*/ float coneHeight;
                }

                struct <>c__DisplayClass20_0
                {
                    /*0x10*/ UnityEngine.Rendering.VisibleLight light;
                    /*0x84*/ Unity.Mathematics.float3 lightPosVS;
                    /*0x90*/ Unity.Mathematics.float3 lightDirVS;
                    /*0x9c*/ float cosHalfAngle;
                }
            }

            struct ZBinningJob : Unity.Jobs.IJobFor
            {
                static int batchSize = 128;
                static int headerLength = 2;
                /*0x10*/ Unity.Collections.NativeArray<uint> bins;
                /*0x20*/ Unity.Collections.NativeArray<Unity.Mathematics.float2> minMaxZs;
                /*0x30*/ float zBinScale;
                /*0x34*/ float zBinOffset;
                /*0x38*/ int binCount;
                /*0x3c*/ int wordsPerTile;
                /*0x40*/ int lightCount;
                /*0x44*/ int reflectionProbeCount;
                /*0x48*/ int batchCount;
                /*0x4c*/ int viewCount;
                /*0x50*/ bool isOrthographic;

                static /*0x13e3f50*/ uint EncodeHeader(uint min, uint max);
                static /*0x13e3ef0*/ System.ValueTuple<uint, uint> DecodeHeader(uint zBin);
                /*0x13e3f60*/ void Execute(int jobIndex);
                /*0x13e4090*/ void FillZBins(int binStart, int binEnd, int itemStart, int itemEnd, int headerIndex, int itemOffset, int binOffset);
            }

            enum CameraOverrideOption
            {
                Off = 0,
                On = 1,
                UsePipelineSettings = 2,
            }

            enum RendererOverrideOption
            {
                Custom = 0,
                UsePipelineSettings = 1,
            }

            enum AntialiasingMode
            {
                None = 0,
                FastApproximateAntialiasing = 1,
                SubpixelMorphologicalAntiAliasing = 2,
                TemporalAntiAliasing = 3,
            }

            enum CameraRenderType
            {
                Base = 0,
                Overlay = 1,
            }

            enum AntialiasingQuality
            {
                Low = 0,
                Medium = 1,
                High = 2,
            }

            class CameraExtensions
            {
                static /*0x13d2530*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData GetUniversalAdditionalCameraData(UnityEngine.Camera camera);
                static /*0x13d25c0*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode GetVolumeFrameworkUpdateMode(UnityEngine.Camera camera);
                static /*0x13d2860*/ void SetVolumeFrameworkUpdateMode(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode mode);
                static /*0x13d2950*/ void UpdateVolumeStack(UnityEngine.Camera camera);
                static /*0x13d2a00*/ void UpdateVolumeStack(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData cameraData);
                static /*0x13d2430*/ void DestroyVolumeStack(UnityEngine.Camera camera);
                static /*0x13d23b0*/ void DestroyVolumeStack(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData cameraData);
                static /*0x13d2660*/ void GetVolumeLayerMaskAndTrigger(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData cameraData, ref UnityEngine.LayerMask layerMask, ref UnityEngine.Transform trigger);
            }

            class CameraTypeUtility
            {
                static /*0x0*/ string[] s_CameraTypeNames;

                static /*0x13d2bd0*/ CameraTypeUtility();
                static /*0x13d2b30*/ string GetName(UnityEngine.Rendering.Universal.CameraRenderType type);
            }

            class UniversalAdditionalCameraData : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver, UnityEngine.Rendering.IAdditionalData
            {
                static string k_GizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/";
                static string k_BaseCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png";
                static string k_OverlayCameraGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_Base.png";
                static string k_PostProcessingGizmoPath = "Packages/com.unity.render-pipelines.universal/Editor/Gizmos/Camera_PostProcessing.png";
                static /*0x0*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData s_DefaultAdditionalCameraData;
                static /*0x8*/ System.Collections.Generic.List<UnityEngine.Rendering.VolumeStack> s_CachedVolumeStacks;
                /*0x20*/ bool m_RenderShadows;
                /*0x24*/ UnityEngine.Rendering.Universal.CameraOverrideOption m_RequiresDepthTextureOption;
                /*0x28*/ UnityEngine.Rendering.Universal.CameraOverrideOption m_RequiresOpaqueTextureOption;
                /*0x2c*/ UnityEngine.Rendering.Universal.CameraRenderType m_CameraType;
                /*0x30*/ System.Collections.Generic.List<UnityEngine.Camera> m_Cameras;
                /*0x38*/ int m_RendererIndex;
                /*0x3c*/ UnityEngine.LayerMask m_VolumeLayerMask;
                /*0x40*/ UnityEngine.Transform m_VolumeTrigger;
                /*0x48*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode m_VolumeFrameworkUpdateModeOption;
                /*0x4c*/ bool m_RenderPostProcessing;
                /*0x50*/ UnityEngine.Rendering.Universal.AntialiasingMode m_Antialiasing;
                /*0x54*/ UnityEngine.Rendering.Universal.AntialiasingQuality m_AntialiasingQuality;
                /*0x58*/ bool m_StopNaN;
                /*0x59*/ bool m_Dithering;
                /*0x5a*/ bool m_ClearDepth;
                /*0x5b*/ bool m_AllowXRRendering;
                /*0x5c*/ bool m_AllowHDROutput;
                /*0x5d*/ bool m_UseScreenCoordOverride;
                /*0x60*/ UnityEngine.Vector4 m_ScreenSizeOverride;
                /*0x70*/ UnityEngine.Vector4 m_ScreenCoordScaleBias;
                /*0x80*/ UnityEngine.Camera m_Camera;
                /*0x88*/ bool m_RequiresDepthTexture;
                /*0x89*/ bool m_RequiresColorTexture;
                /*0x8c*/ float m_Version;
                /*0x90*/ UnityEngine.Rendering.Universal.MotionVectorsPersistentData m_MotionVectorsPersistentData;
                /*0x98*/ UnityEngine.Rendering.Universal.TaaPersistentData m_TaaPersistentData;
                /*0xa0*/ UnityEngine.Rendering.Universal.TemporalAA.Settings m_TaaSettings;
                /*0xc0*/ UnityEngine.Rendering.VolumeStack m_VolumeStack;

                static /*0x13daef0*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData get_defaultAdditionalCameraData();
                /*0x13dab60*/ UniversalAdditionalCameraData();
                /*0x7378c0*/ float get_version();
                /*0x13dae40*/ UnityEngine.Camera get_camera();
                /*0x796120*/ bool get_renderShadows();
                /*0x7963b0*/ void set_renderShadows(bool value);
                /*0x3e3ad0*/ UnityEngine.Rendering.Universal.CameraOverrideOption get_requiresDepthOption();
                /*0xc70b30*/ void set_requiresDepthOption(UnityEngine.Rendering.Universal.CameraOverrideOption value);
                /*0x3e3ae0*/ UnityEngine.Rendering.Universal.CameraOverrideOption get_requiresColorOption();
                /*0xc6dab0*/ void set_requiresColorOption(UnityEngine.Rendering.Universal.CameraOverrideOption value);
                /*0xbe6c70*/ UnityEngine.Rendering.Universal.CameraRenderType get_renderType();
                /*0xbe6cd0*/ void set_renderType(UnityEngine.Rendering.Universal.CameraRenderType value);
                /*0x13dacd0*/ System.Collections.Generic.List<UnityEngine.Camera> get_cameraStack();
                /*0x13da890*/ void UpdateCameraStack();
                /*0x13daee0*/ bool get_clearDepth();
                /*0x13db170*/ bool get_requiresDepthTexture();
                /*0x13db5b0*/ void set_requiresDepthTexture(bool value);
                /*0x13db100*/ bool get_requiresColorTexture();
                /*0x13db590*/ void set_requiresColorTexture(bool value);
                /*0x13db260*/ UnityEngine.Rendering.Universal.ScriptableRenderer get_scriptableRenderer();
                /*0x12d8f70*/ void SetRenderer(int index);
                /*0xee1680*/ UnityEngine.LayerMask get_volumeLayerMask();
                /*0x136a430*/ void set_volumeLayerMask(UnityEngine.LayerMask value);
                /*0xb61870*/ UnityEngine.Transform get_volumeTrigger();
                /*0xcf6cd0*/ void set_volumeTrigger(UnityEngine.Transform value);
                /*0x12f47d0*/ UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode get_volumeFrameworkUpdateMode();
                /*0x136a110*/ void set_volumeFrameworkUpdateMode(UnityEngine.Rendering.Universal.VolumeFrameworkUpdateMode value);
                /*0x13db1e0*/ bool get_requiresVolumeFrameworkUpdate();
                /*0xefdcf0*/ UnityEngine.Rendering.VolumeStack get_volumeStack();
                /*0x13db630*/ void set_volumeStack(UnityEngine.Rendering.VolumeStack value);
                /*0x13d9fd0*/ void GetOrCreateVolumeStack();
                /*0x137d5b0*/ bool get_renderPostProcessing();
                /*0x137de80*/ void set_renderPostProcessing(bool value);
                /*0xc70ac0*/ UnityEngine.Rendering.Universal.AntialiasingMode get_antialiasing();
                /*0x136edf0*/ void set_antialiasing(UnityEngine.Rendering.Universal.AntialiasingMode value);
                /*0x136e810*/ UnityEngine.Rendering.Universal.AntialiasingQuality get_antialiasingQuality();
                /*0x13db570*/ void set_antialiasingQuality(UnityEngine.Rendering.Universal.AntialiasingQuality value);
                /*0x13db540*/ ref UnityEngine.Rendering.Universal.TemporalAA.Settings get_taaSettings();
                /*0x9c7a50*/ UnityEngine.Rendering.Universal.TaaPersistentData get_taaPersistentData();
                /*0x7378b0*/ UnityEngine.Rendering.Universal.MotionVectorsPersistentData get_motionVectorsPersistentData();
                /*0x13db250*/ bool get_resetHistory();
                /*0x13db5d0*/ void set_resetHistory(bool value);
                /*0xe9dc40*/ bool get_stopNaN();
                /*0x13db610*/ void set_stopNaN(bool value);
                /*0xe9dc30*/ bool get_dithering();
                /*0x13db580*/ void set_dithering(bool value);
                /*0x13dacc0*/ bool get_allowXRRendering();
                /*0x13db560*/ void set_allowXRRendering(bool value);
                /*0x13db550*/ bool get_useScreenCoordOverride();
                /*0x13db620*/ void set_useScreenCoordOverride(bool value);
                /*0x12ebbd0*/ UnityEngine.Vector4 get_screenSizeOverride();
                /*0x12ebc20*/ void set_screenSizeOverride(UnityEngine.Vector4 value);
                /*0x12ebbe0*/ UnityEngine.Vector4 get_screenCoordScaleBias();
                /*0x12ebc30*/ void set_screenCoordScaleBias(UnityEngine.Vector4 value);
                /*0xf39700*/ bool get_allowHDROutput();
                /*0x13a9950*/ void set_allowHDROutput(bool value);
                /*0x32d010*/ void OnBeforeSerialize();
                /*0x13da500*/ void OnAfterDeserialize();
                /*0x13da740*/ void OnDrawGizmos();
                /*0x13da530*/ void OnDestroy();
                /*0x13da3a0*/ UnityEngine.Rendering.Universal.ScriptableRenderer GetRawRenderer();

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.UniversalAdditionalCameraData.<> <>9;
                    static /*0x8*/ System.Predicate<UnityEngine.Camera> <>9__52_0;

                    static /*0x13d9f60*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x13d9f10*/ bool <UpdateCameraStack>b__52_0(UnityEngine.Camera cam);
                }
            }

            enum LightLayerEnum
            {
                Nothing = 0,
                LightLayerDefault = 1,
                LightLayer1 = 2,
                LightLayer2 = 4,
                LightLayer3 = 8,
                LightLayer4 = 16,
                LightLayer5 = 32,
                LightLayer6 = 64,
                LightLayer7 = 128,
                Everything = 255,
            }

            class LightExtensions
            {
                static /*0x13d2cb0*/ UnityEngine.Rendering.Universal.UniversalAdditionalLightData GetUniversalAdditionalLightData(UnityEngine.Light light);
            }

            class UniversalAdditionalLightData : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver, UnityEngine.Rendering.IAdditionalData
            {
                static /*0x0*/ int AdditionalLightsShadowResolutionTierCustom;
                static /*0x4*/ int AdditionalLightsShadowResolutionTierLow;
                static /*0x8*/ int AdditionalLightsShadowResolutionTierMedium;
                static /*0xc*/ int AdditionalLightsShadowResolutionTierHigh;
                static /*0x10*/ int AdditionalLightsShadowDefaultResolutionTier;
                static /*0x14*/ int AdditionalLightsShadowDefaultCustomResolution;
                static /*0x18*/ int AdditionalLightsShadowMinimumResolution;
                /*0x20*/ int m_Version;
                /*0x24*/ bool m_UsePipelineSettings;
                /*0x28*/ UnityEngine.Light m_Light;
                /*0x30*/ int m_AdditionalLightsShadowResolutionTier;
                /*0x34*/ UnityEngine.Rendering.Universal.LightLayerEnum m_LightLayerMask;
                /*0x38*/ uint m_RenderingLayers;
                /*0x3c*/ bool m_CustomShadowLayers;
                /*0x40*/ UnityEngine.Rendering.Universal.LightLayerEnum m_ShadowLayerMask;
                /*0x44*/ uint m_ShadowRenderingLayers;
                /*0x48*/ UnityEngine.Vector2 m_LightCookieSize;
                /*0x50*/ UnityEngine.Vector2 m_LightCookieOffset;
                /*0x58*/ UnityEngine.Rendering.Universal.SoftShadowQuality m_SoftShadowQuality;

                static /*0x13db900*/ UniversalAdditionalLightData();
                /*0x13db9c0*/ UniversalAdditionalLightData();
                /*0x3e3af0*/ int get_version();
                /*0xed9100*/ bool get_usePipelineSettings();
                /*0x117be00*/ void set_usePipelineSettings(bool value);
                /*0x13dbaf0*/ UnityEngine.Light get_light();
                /*0xa79cc0*/ int get_additionalLightsShadowResolutionTier();
                /*0x995160*/ UnityEngine.Rendering.Universal.LightLayerEnum get_lightLayerMask();
                /*0x9952f0*/ void set_lightLayerMask(UnityEngine.Rendering.Universal.LightLayerEnum value);
                /*0xeab1d0*/ uint get_renderingLayers();
                /*0x13dbb80*/ void set_renderingLayers(uint value);
                /*0xc77220*/ bool get_customShadowLayers();
                /*0x13dbb70*/ void set_customShadowLayers(bool value);
                /*0xbe6be0*/ UnityEngine.Rendering.Universal.LightLayerEnum get_shadowLayerMask();
                /*0xbe6cc0*/ void set_shadowLayerMask(UnityEngine.Rendering.Universal.LightLayerEnum value);
                /*0x10eed50*/ uint get_shadowRenderingLayers();
                /*0x13dbb90*/ void set_shadowRenderingLayers(uint value);
                /*0x136e850*/ UnityEngine.Vector2 get_lightCookieSize();
                /*0x12a10c0*/ void set_lightCookieSize(UnityEngine.Vector2 value);
                /*0x13dbad0*/ UnityEngine.Vector2 get_lightCookieOffset();
                /*0x12a1080*/ void set_lightCookieOffset(UnityEngine.Vector2 value);
                /*0x104a520*/ UnityEngine.Rendering.Universal.SoftShadowQuality get_softShadowQuality();
                /*0x137d9e0*/ void set_softShadowQuality(UnityEngine.Rendering.Universal.SoftShadowQuality value);
                /*0x32d010*/ void OnBeforeSerialize();
                /*0x13db7a0*/ void OnAfterDeserialize();
                /*0x13db860*/ void SyncLightAndShadowLayers();
            }

            enum RenderingMode
            {
                Forward = 0,
                ForwardPlus = 2,
                Deferred = 1,
            }

            enum DepthPrimingMode
            {
                Disabled = 0,
                Auto = 1,
                Forced = 2,
            }

            class UniversalRenderer : UnityEngine.Rendering.Universal.ScriptableRenderer
            {
                static UnityEngine.Experimental.Rendering.GraphicsFormat k_DepthStencilFormat = 94;
                static int k_DepthBufferBits = 32;
                static int k_FinalBlitPassQueueOffset = 1;
                static int k_AfterFinalBlitPassQueueOffset = 2;
                static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> k_DepthNormalsOnly;
                static /*0x8*/ UnityEngine.Rendering.RTHandle m_RenderGraphCameraColorHandle;
                static /*0x10*/ UnityEngine.Rendering.RTHandle m_RenderGraphCameraDepthHandle;
                static /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle m_ActiveRenderGraphColor;
                static /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle m_ActiveRenderGraphDepth;
                static /*0x28*/ bool m_UseIntermediateTexture;
                /*0x1a8*/ bool m_Clustering;
                /*0x1b0*/ UnityEngine.Rendering.Universal.Internal.DepthOnlyPass m_DepthPrepass;
                /*0x1b8*/ UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass m_DepthNormalPrepass;
                /*0x1c0*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_PrimedDepthCopyPass;
                /*0x1c8*/ UnityEngine.Rendering.Universal.MotionVectorRenderPass m_MotionVectorPass;
                /*0x1d0*/ UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass m_MainLightShadowCasterPass;
                /*0x1d8*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;
                /*0x1e0*/ UnityEngine.Rendering.Universal.Internal.GBufferPass m_GBufferPass;
                /*0x1e8*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_GBufferCopyDepthPass;
                /*0x1f0*/ UnityEngine.Rendering.Universal.Internal.DeferredPass m_DeferredPass;
                /*0x1f8*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass m_RenderOpaqueForwardOnlyPass;
                /*0x200*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass m_RenderOpaqueForwardPass;
                /*0x208*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsWithRenderingLayersPass m_RenderOpaqueForwardWithRenderingLayersPass;
                /*0x210*/ UnityEngine.Rendering.Universal.DrawSkyboxPass m_DrawSkyboxPass;
                /*0x218*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_CopyDepthPass;
                /*0x220*/ UnityEngine.Rendering.Universal.Internal.CopyColorPass m_CopyColorPass;
                /*0x228*/ UnityEngine.Rendering.Universal.TransparentSettingsPass m_TransparentSettingsPass;
                /*0x230*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass m_RenderTransparentForwardPass;
                /*0x238*/ UnityEngine.Rendering.Universal.InvokeOnRenderObjectCallbackPass m_OnRenderObjectCallbackPass;
                /*0x240*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass m_FinalBlitPass;
                /*0x248*/ UnityEngine.Rendering.Universal.CapturePass m_CapturePass;
                /*0x250*/ UnityEngine.Rendering.Universal.XROcclusionMeshPass m_XROcclusionMeshPass;
                /*0x258*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass m_XRCopyDepthPass;
                /*0x260*/ UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass m_DrawOffscreenUIPass;
                /*0x268*/ UnityEngine.Rendering.Universal.DrawScreenSpaceUIPass m_DrawOverlayUIPass;
                /*0x270*/ UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem m_ColorBufferSystem;
                /*0x278*/ UnityEngine.Rendering.RTHandle m_ActiveCameraColorAttachment;
                /*0x280*/ UnityEngine.Rendering.RTHandle m_ColorFrontBuffer;
                /*0x288*/ UnityEngine.Rendering.RTHandle m_ActiveCameraDepthAttachment;
                /*0x290*/ UnityEngine.Rendering.RTHandle m_CameraDepthAttachment;
                /*0x298*/ UnityEngine.Rendering.RTHandle m_XRTargetHandleAlias;
                /*0x2a0*/ UnityEngine.Rendering.RTHandle m_CameraDepthAttachment_D3d_11;
                /*0x2a8*/ UnityEngine.Rendering.RTHandle m_DepthTexture;
                /*0x2b0*/ UnityEngine.Rendering.RTHandle m_NormalsTexture;
                /*0x2b8*/ UnityEngine.Rendering.RTHandle m_DecalLayersTexture;
                /*0x2c0*/ UnityEngine.Rendering.RTHandle m_OpaqueColor;
                /*0x2c8*/ UnityEngine.Rendering.RTHandle m_MotionVectorColor;
                /*0x2d0*/ UnityEngine.Rendering.RTHandle m_MotionVectorDepth;
                /*0x2d8*/ UnityEngine.Rendering.Universal.Internal.ForwardLights m_ForwardLights;
                /*0x2e0*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;
                /*0x2e8*/ UnityEngine.Rendering.Universal.RenderingMode m_RenderingMode;
                /*0x2ec*/ UnityEngine.Rendering.Universal.DepthPrimingMode m_DepthPrimingMode;
                /*0x2f0*/ UnityEngine.Rendering.Universal.CopyDepthMode m_CopyDepthMode;
                /*0x2f4*/ bool m_DepthPrimingRecommended;
                /*0x2f5*/ UnityEngine.Rendering.StencilState m_DefaultStencilState;
                /*0x308*/ UnityEngine.Rendering.Universal.LightCookieManager m_LightCookieManager;
                /*0x310*/ UnityEngine.Rendering.Universal.IntermediateTextureMode m_IntermediateTextureMode;
                /*0x314*/ bool m_VulkanEnablePreTransform;
                /*0x318*/ UnityEngine.Material m_BlitMaterial;
                /*0x320*/ UnityEngine.Material m_BlitHDRMaterial;
                /*0x328*/ UnityEngine.Material m_CopyDepthMaterial;
                /*0x330*/ UnityEngine.Material m_SamplingMaterial;
                /*0x338*/ UnityEngine.Material m_StencilDeferredMaterial;
                /*0x340*/ UnityEngine.Material m_CameraMotionVecMaterial;
                /*0x348*/ UnityEngine.Material m_ObjectMotionVecMaterial;
                /*0x350*/ UnityEngine.Rendering.Universal.PostProcessPasses m_PostProcessPasses;
                /*0x390*/ bool m_TargetIsBackbuffer;
                /*0x398*/ UnityEngine.Rendering.Universal.UniversalRenderer.RenderGraphFrameResources frameResources;

                static /*0x13e28e0*/ UniversalRenderer();
                static /*0x13dd7b0*/ bool IsOffscreenDepthTexture(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x13dce50*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle CreateRenderGraphTexture(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.RenderTextureDescriptor desc, string name, bool clear, UnityEngine.FilterMode filterMode, UnityEngine.TextureWrapMode wrapMode);
                /*0x13e2a10*/ UniversalRenderer(UnityEngine.Rendering.Universal.UniversalRendererData data);
                /*0x13e2690*/ int SupportedCameraStackingTypes();
                /*0x13e3ed0*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingModeRequested();
                /*0x13e3e40*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingModeActual();
                /*0x13e3dc0*/ bool get_accurateGbufferNormals();
                /*0x13e3e10*/ UnityEngine.Rendering.Universal.DepthPrimingMode get_depthPrimingMode();
                /*0x13e3ee0*/ void set_depthPrimingMode(UnityEngine.Rendering.Universal.DepthPrimingMode value);
                /*0x13e3de0*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass get_colorGradingLutPass();
                /*0x13e3e30*/ UnityEngine.Rendering.Universal.PostProcessPass get_postProcessPass();
                /*0x13e3e20*/ UnityEngine.Rendering.Universal.PostProcessPass get_finalPostProcessPass();
                /*0x13e3df0*/ UnityEngine.Rendering.RTHandle get_colorGradingLut();
                /*0x13e3e00*/ UnityEngine.Rendering.Universal.Internal.DeferredLights get_deferredLights();
                /*0x13dcf70*/ void Dispose(bool disposing);
                /*0x13de570*/ void ReleaseRenderTargets();
                /*0x13dee40*/ void SetupFinalPassDebug(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x13dd670*/ bool IsDepthPrimingEnabled(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x348b00*/ bool IsWebGL();
                /*0x13dd780*/ bool IsGLESDevice();
                /*0x13ba140*/ bool IsGLDevice();
                /*0x13df2a0*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13df230*/ void SetupLights(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13deb40*/ void SetupCullingParameters(ref UnityEngine.Rendering.ScriptableCullingParameters cullingParameters, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x13dd3b0*/ void FinishRendering(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x13dd1b0*/ void EnqueueDeferred(ref UnityEngine.Rendering.Universal.RenderingData renderingData, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, bool applyMainShadow, bool applyAdditionalShadow);
                /*0x13dd470*/ UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary GetRenderPassInputs(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13dbd20*/ void CreateCameraRenderTarget(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.RenderTextureDescriptor descriptor, bool primedDepth, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x13de500*/ bool PlatformRequiresExplicitMsaaResolve();
                /*0x13de8d0*/ bool RequiresIntermediateColorTexture(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x13dbba0*/ bool CanCopyDepth(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                /*0x13e26c0*/ void SwapColorBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x13dd440*/ UnityEngine.Rendering.RTHandle GetCameraColorFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x13dd410*/ UnityEngine.Rendering.RTHandle GetCameraColorBackBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                /*0x13dd180*/ void EnableSwapBufferMSAA(bool enable);
                /*0x13dbc80*/ void CleanupRenderGraphResources();
                /*0x13de6a0*/ bool RequiresColorAndDepthTextures(ref bool createColorTexture, ref bool createDepthTexture, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.Universal.UniversalRenderer.RenderPassInputSummary renderPassInputs);
                /*0x13dc400*/ void CreateRenderGraphCameraRenderTargets(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13de240*/ void OnRecordRenderGraph(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13ddb00*/ void OnFinishRenderGraphRendering(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13dd9f0*/ void OnBeforeRendering(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13ddba0*/ void OnMainRendering(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13dd840*/ void OnAfterRendering(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);

                class Profiling
                {
                    static string k_Name = "UniversalRenderer";
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler createCameraRenderTarget;

                    static /*0x13e9120*/ Profiling();
                }

                struct RenderPassInputSummary
                {
                    /*0x10*/ bool requiresDepthTexture;
                    /*0x11*/ bool requiresDepthPrepass;
                    /*0x12*/ bool requiresNormalsTexture;
                    /*0x13*/ bool requiresColorTexture;
                    /*0x14*/ bool requiresColorTextureCreated;
                    /*0x15*/ bool requiresMotionVectors;
                    /*0x18*/ UnityEngine.Rendering.Universal.RenderPassEvent requiresDepthNormalAtEvent;
                    /*0x1c*/ UnityEngine.Rendering.Universal.RenderPassEvent requiresDepthTextureEarliestEvent;
                }

                class RenderGraphFrameResources
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle backBufferColor;
                    /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraColor;
                    /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraDepth;
                    /*0x28*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle mainShadowsTexture;
                    /*0x30*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle additionalShadowsTexture;
                    /*0x38*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] gbuffer;
                    /*0x40*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraOpaqueTexture;
                    /*0x48*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture;
                    /*0x50*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraNormalsTexture;
                    /*0x58*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle motionVectorColor;
                    /*0x60*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle motionVectorDepth;
                    /*0x68*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle internalColorLut;
                    /*0x70*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle overlayUITexture;

                    /*0x32f970*/ RenderGraphFrameResources();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.UniversalRenderer.<> <>9;
                    static /*0x8*/ System.Predicate<UnityEngine.Rendering.Universal.ScriptableRenderPass> <>9__91_0;
                    static /*0x10*/ System.Predicate<UnityEngine.Rendering.Universal.ScriptableRenderPass> <>9__91_1;

                    static /*0x13f0ec0*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x13793e0*/ bool <Setup>b__91_0(UnityEngine.Rendering.Universal.ScriptableRenderPass x);
                    /*0x13f0aa0*/ bool <Setup>b__91_1(UnityEngine.Rendering.Universal.ScriptableRenderPass x);
                }
            }

            enum CopyDepthMode
            {
                AfterOpaques = 0,
                AfterTransparents = 1,
                ForcePrepass = 2,
            }

            class UniversalRendererData : UnityEngine.Rendering.Universal.ScriptableRendererData, UnityEngine.ISerializationCallbackReceiver
            {
                static int k_LatestAssetVersion = 2;
                /*0x40*/ UnityEngine.Rendering.Universal.PostProcessData postProcessData;
                /*0x48*/ UnityEngine.Rendering.Universal.XRSystemData xrSystemData;
                /*0x50*/ UnityEngine.Rendering.Universal.UniversalRendererData.ShaderResources shaders;
                /*0x58*/ int m_AssetVersion;
                /*0x5c*/ UnityEngine.LayerMask m_OpaqueLayerMask;
                /*0x60*/ UnityEngine.LayerMask m_TransparentLayerMask;
                /*0x68*/ UnityEngine.Rendering.Universal.StencilStateData m_DefaultStencilState;
                /*0x70*/ bool m_ShadowTransparentReceive;
                /*0x74*/ UnityEngine.Rendering.Universal.RenderingMode m_RenderingMode;
                /*0x78*/ UnityEngine.Rendering.Universal.DepthPrimingMode m_DepthPrimingMode;
                /*0x7c*/ UnityEngine.Rendering.Universal.CopyDepthMode m_CopyDepthMode;
                /*0x80*/ bool m_AccurateGbufferNormals;
                /*0x84*/ UnityEngine.Rendering.Universal.IntermediateTextureMode m_IntermediateTextureMode;

                /*0x13fb4d0*/ UniversalRendererData();
                /*0x13fb410*/ UnityEngine.Rendering.Universal.ScriptableRenderer Create();
                /*0x12d9c40*/ UnityEngine.LayerMask get_opaqueLayerMask();
                /*0x13fb680*/ void set_opaqueLayerMask(UnityEngine.LayerMask value);
                /*0xf91dd0*/ UnityEngine.LayerMask get_transparentLayerMask();
                /*0x13fb710*/ void set_transparentLayerMask(UnityEngine.LayerMask value);
                /*0x8af030*/ UnityEngine.Rendering.Universal.StencilStateData get_defaultStencilState();
                /*0x13fb5e0*/ void set_defaultStencilState(UnityEngine.Rendering.Universal.StencilStateData value);
                /*0x137cf30*/ bool get_shadowTransparentReceive();
                /*0x13fb6e0*/ void set_shadowTransparentReceive(bool value);
                /*0x136fc60*/ UnityEngine.Rendering.Universal.RenderingMode get_renderingMode();
                /*0x13fb6b0*/ void set_renderingMode(UnityEngine.Rendering.Universal.RenderingMode value);
                /*0x1101d10*/ UnityEngine.Rendering.Universal.DepthPrimingMode get_depthPrimingMode();
                /*0x13fb620*/ void set_depthPrimingMode(UnityEngine.Rendering.Universal.DepthPrimingMode value);
                /*0x137cfa0*/ UnityEngine.Rendering.Universal.CopyDepthMode get_copyDepthMode();
                /*0x13fb5b0*/ void set_copyDepthMode(UnityEngine.Rendering.Universal.CopyDepthMode value);
                /*0x12c45f0*/ bool get_accurateGbufferNormals();
                /*0x13fb580*/ void set_accurateGbufferNormals(bool value);
                /*0x115f670*/ UnityEngine.Rendering.Universal.IntermediateTextureMode get_intermediateTextureMode();
                /*0x13fb650*/ void set_intermediateTextureMode(UnityEngine.Rendering.Universal.IntermediateTextureMode value);
                /*0x13fb490*/ void OnEnable();
                /*0x32d010*/ void ReloadAllNullProperties();
                /*0x13fb4c0*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
                /*0x13fb4a0*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();

                class ShaderResources
                {
                    /*0x10*/ UnityEngine.Shader blitPS;
                    /*0x18*/ UnityEngine.Shader copyDepthPS;
                    /*0x20*/ UnityEngine.Shader screenSpaceShadowPS;
                    /*0x28*/ UnityEngine.Shader samplingPS;
                    /*0x30*/ UnityEngine.Shader stencilDeferredPS;
                    /*0x38*/ UnityEngine.Shader fallbackErrorPS;
                    /*0x40*/ UnityEngine.Shader fallbackLoadingPS;
                    /*0x48*/ UnityEngine.Shader materialErrorPS;
                    /*0x50*/ UnityEngine.Shader coreBlitPS;
                    /*0x58*/ UnityEngine.Shader coreBlitColorAndDepthPS;
                    /*0x60*/ UnityEngine.Shader blitHDROverlay;
                    /*0x68*/ UnityEngine.Shader cameraMotionVector;
                    /*0x70*/ UnityEngine.Shader objectMotionVector;
                    /*0x78*/ UnityEngine.Shader dataDrivenLensFlare;
                    /*0x80*/ UnityEngine.Shader terrainDetailLitPS;
                    /*0x88*/ UnityEngine.Shader terrainDetailGrassPS;
                    /*0x90*/ UnityEngine.Shader terrainDetailGrassBillboardPS;

                    /*0x32f970*/ ShaderResources();
                }
            }

            class ClearTargetsPass
            {
                static /*0x0*/ UnityEngine.Rendering.ProfilingSampler s_ClearProfilingSampler;

                static /*0x13e6530*/ ClearTargetsPass();
                static /*0x13e6240*/ void Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph, UnityEngine.Rendering.Universal.UniversalRenderer renderer, UnityEngine.Rendering.RTClearFlags clearFlags, UnityEngine.Color clearColor);
                /*0x32f970*/ ClearTargetsPass();

                class PassData
                {
                    /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle color;
                    /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle depth;
                    /*0x20*/ UnityEngine.Rendering.RTClearFlags clearFlags;
                    /*0x24*/ UnityEngine.Color clearColor;

                    /*0x32f970*/ PassData();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.ClearTargetsPass.<> <>9;
                    static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.ClearTargetsPass.PassData> <>9__2_0;

                    static /*0x13f0fa0*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x13f0a50*/ void <Render>b__2_0(UnityEngine.Rendering.Universal.ClearTargetsPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                }
            }

            class UniversalRenderPipeline : UnityEngine.Rendering.RenderPipeline
            {
                static string k_ShaderTagName = "UniversalPipeline";
                static int k_DefaultRenderingLayerMask = 1;
                static /*0x0*/ bool cameraStackRequiresDepthForPostprocessing;
                static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph s_RenderGraph;
                static /*0x10*/ UnityEngine.Rendering.Universal.RTHandleResourcePool s_RTHandlePool;
                static /*0x18*/ bool useRenderGraph;
                static /*0x1c*/ UnityEngine.Vector4 k_DefaultLightPosition;
                static /*0x2c*/ UnityEngine.Vector4 k_DefaultLightColor;
                static /*0x3c*/ UnityEngine.Vector4 k_DefaultLightAttenuation;
                static /*0x4c*/ UnityEngine.Vector4 k_DefaultLightSpotDirection;
                static /*0x5c*/ UnityEngine.Vector4 k_DefaultLightsProbeChannel;
                static /*0x70*/ System.Collections.Generic.List<UnityEngine.Vector4> m_ShadowBiasData;
                static /*0x78*/ System.Collections.Generic.List<int> m_ShadowResolutionData;
                static /*0x80*/ UnityEngine.Experimental.GlobalIllumination.Lightmapping.RequestLightsDelegate lightsDelegate;
                /*0x18*/ UnityEngine.Rendering.DebugDisplaySettingsUI m_DebugDisplaySettingsUI;
                /*0x20*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineGlobalSettings m_GlobalSettings;
                /*0x28*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset pipelineAsset;
                /*0x30*/ bool enableHDROnce;
                /*0x38*/ System.Comparison<UnityEngine.Camera> cameraComparison;

                static /*0x13fa820*/ UniversalRenderPipeline();
                static /*0x1301640*/ float get_maxShadowBias();
                static /*0x1301780*/ float get_minRenderScale();
                static /*0x13fb260*/ float get_maxRenderScale();
                static /*0x13fb220*/ int get_maxNumIterationsEnclosingSphere();
                static /*0x13fb230*/ int get_maxPerObjectLights();
                static /*0x13fb2d0*/ int get_maxVisibleAdditionalLights();
                static /*0x13fb1d0*/ int get_lightsPerTile();
                static /*0x6d5f10*/ int get_maxZBinWords();
                static /*0x13fb270*/ int get_maxTileWords();
                static /*0x13fb390*/ int get_maxVisibleReflectionProbes();
                static /*0x13f85a0*/ void RenderSingleCamera(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                static /*0x13f76f0*/ void RenderSingleCameraInternal(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera);
                static /*0x13f78f0*/ void RenderSingleCameraInternal(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, ref UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData);
                static /*0x13f9c50*/ bool TryGetCullingParameters(UnityEngine.Rendering.Universal.CameraData cameraData, ref UnityEngine.Rendering.ScriptableCullingParameters cullingParams);
                static /*0x13f7a50*/ void RenderSingleCamera(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x13f6120*/ void RenderCameraStack(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera baseCamera);
                static /*0x13f9f50*/ void UpdateCameraData(ref UnityEngine.Rendering.Universal.CameraData baseCameraData, ref UnityEngine.Experimental.Rendering.XRPass xr);
                static /*0x13fa570*/ void UpdateVolumeFramework(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData);
                static /*0x13f1bc0*/ bool CheckPostProcessForDepth(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x13f1af0*/ bool CheckPostProcessForDepth();
                static /*0x13f9230*/ void SetSupportedRenderingFeatures(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset pipelineAsset);
                static /*0x13f3760*/ void InitializeCameraData(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x13f5430*/ void InitializeStackedCameraData(UnityEngine.Camera baseCamera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData baseAdditionalCameraData, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x13f2db0*/ void InitializeAdditionalCameraData(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData, bool resolveFinalTarget, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x13f43b0*/ void InitializeRenderingData(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, ref UnityEngine.Rendering.Universal.CameraData cameraData, ref UnityEngine.Rendering.CullingResults cullResults, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x13f4ae0*/ void InitializeShadowData(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool mainLightCastShadows, bool additionalLightsCastShadows, bool isForwardPlus, ref UnityEngine.Rendering.Universal.ShadowData shadowData);
                static /*0x13f4350*/ void InitializePostProcessingData(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, bool isHDROutputActive, ref UnityEngine.Rendering.Universal.PostProcessingData postProcessingData);
                static /*0x13f4110*/ void InitializeLightData(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, int mainLightIndex, ref UnityEngine.Rendering.Universal.LightData lightData);
                static /*0x13f1810*/ void ApplyTaaRenderingDebugOverrides(ref UnityEngine.Rendering.Universal.TemporalAA.Settings taaSettings);
                static /*0x13fa3c0*/ void UpdateTemporalAAData(ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.Universal.UniversalAdditionalCameraData additionalCameraData);
                static /*0x13fa4b0*/ void UpdateTemporalAATargets(ref UnityEngine.Rendering.Universal.CameraData cameraData);
                static /*0x13fa200*/ void UpdateCameraStereoMatrices(UnityEngine.Camera camera, UnityEngine.Experimental.Rendering.XRPass xr);
                static /*0x13f2910*/ UnityEngine.Rendering.PerObjectData GetPerObjectLightFlags(int additionalLightsCount, bool isForwardPlus);
                static /*0x13f26c0*/ int GetMainLightIndex(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset settings, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights);
                static /*0x13f9840*/ void SetupPerFrameShaderConstants();
                static /*0x13f9290*/ void SetupPerCameraShaderConstants(UnityEngine.Rendering.CommandBuffer cmd);
                static /*0x13f18c0*/ void CheckAndApplyDebugSettings(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x13f8f50*/ UnityEngine.Rendering.Universal.ImageUpscalingFilter ResolveUpscalingFilterSelection(UnityEngine.Vector2 imageSize, float renderScale, UnityEngine.Rendering.Universal.UpscalingFilterSelection selection);
                static /*0x13f2c90*/ bool HDROutputForMainDisplayIsActive();
                static /*0x13f2bf0*/ bool HDROutputForAnyDisplayIsActive();
                static /*0x13f2430*/ void GetHDROutputLuminanceParameters(UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, UnityEngine.ColorGamut hdrDisplayColorGamut, UnityEngine.Rendering.Universal.Tonemapping tonemapping, ref UnityEngine.Vector4 hdrOutputParameters);
                static /*0x13f2330*/ void GetHDROutputGradingParameters(UnityEngine.Rendering.Universal.Tonemapping tonemapping, ref UnityEngine.Vector4 hdrOutputParameters);
                static /*0x13f5c20*/ bool IsGameCamera(UnityEngine.Camera camera);
                static /*0x13f5cf0*/ bool IsStereoEnabled(UnityEngine.Camera camera);
                static /*0x13fb150*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset get_asset();
                static /*0x13f5de0*/ UnityEngine.Experimental.Rendering.GraphicsFormat MakeRenderTextureGraphicsFormat(bool isHdrEnabled, UnityEngine.Rendering.Universal.HDRColorBufferPrecision requestHDRColorBufferPrecision, bool needsAlpha);
                static /*0x13f5ee0*/ UnityEngine.Experimental.Rendering.GraphicsFormat MakeUnormRenderTextureGraphicsFormat();
                static /*0x13f1c40*/ UnityEngine.RenderTextureDescriptor CreateRenderTextureDescriptor(UnityEngine.Camera camera, ref UnityEngine.Rendering.Universal.CameraData cameraData, bool isHdrEnabled, UnityEngine.Rendering.Universal.HDRColorBufferPrecision requestHDRColorBufferPrecision, int msaaSamples, bool needsAlpha, bool requiresOpaqueTexture);
                static /*0x13f2570*/ void GetLightAttenuationAndSpotDirection(UnityEngine.LightType lightType, float lightRange, UnityEngine.Matrix4x4 lightLocalToWorldMatrix, float spotAngle, System.Nullable<float> innerSpotAngle, ref UnityEngine.Vector4 lightAttenuation, ref UnityEngine.Vector4 lightSpotDir);
                static /*0x13f2a20*/ void GetPunctualLightDistanceAttenuation(float lightRange, ref UnityEngine.Vector4 lightAttenuation);
                static /*0x13f2a70*/ void GetSpotAngleAttenuation(float spotAngle, System.Nullable<float> innerSpotAngle, ref UnityEngine.Vector4 lightAttenuation);
                static /*0x13f2b80*/ void GetSpotDirection(ref UnityEngine.Matrix4x4 lightLocalToWorldMatrix, ref UnityEngine.Vector4 lightSpotDir);
                static /*0x13f3ba0*/ void InitializeLightConstants_Common(Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights, int lightIndex, ref UnityEngine.Vector4 lightPos, ref UnityEngine.Vector4 lightColor, ref UnityEngine.Vector4 lightAttenuation, ref UnityEngine.Vector4 lightSpotDir, ref UnityEngine.Vector4 lightOcclusionProbeChannel);
                static /*0x13f60e0*/ void RecordRenderGraph(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                static /*0x13f5f40*/ void RecordAndExecuteRenderGraph(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                /*0x13faa40*/ UniversalRenderPipeline(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset asset);
                /*0x61a260*/ UnityEngine.Rendering.RenderPipelineGlobalSettings get_defaultSettings();
                /*0x13f9c30*/ string ToString();
                /*0x13f2010*/ void Dispose(bool disposing);
                /*0x13f1f50*/ void DisposeAdditionalCameraData();
                /*0x13f8600*/ void Render(UnityEngine.Rendering.ScriptableRenderContext renderContext, UnityEngine.Camera[] cameras);
                /*0x13f86a0*/ void Render(UnityEngine.Rendering.ScriptableRenderContext renderContext, System.Collections.Generic.List<UnityEngine.Camera> cameras);
                /*0x2a5510*/ bool IsRenderRequestSupported<RequestData>(UnityEngine.Camera camera, RequestData data);
                /*0x2a5510*/ void ProcessRenderRequests<RequestData>(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Camera camera, RequestData renderRequest);
                /*0x13f90e0*/ void SetHDRState(System.Collections.Generic.List<UnityEngine.Camera> cameras);
                /*0x13f9bc0*/ void SortCameras(System.Collections.Generic.List<UnityEngine.Camera> cameras);

                class Profiling
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<int, UnityEngine.Rendering.ProfilingSampler> s_HashSamplerCache;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler unknownSampler;

                    static /*0x13e91b0*/ Profiling();
                    static /*0x13e8fa0*/ UnityEngine.Rendering.ProfilingSampler TryGetOrAddCameraSampler(UnityEngine.Camera camera);

                    class Pipeline
                    {
                        static string k_Name = "UniversalRenderPipeline";
                        static /*0x0*/ UnityEngine.Rendering.ProfilingSampler beginContextRendering;
                        static /*0x8*/ UnityEngine.Rendering.ProfilingSampler endContextRendering;
                        static /*0x10*/ UnityEngine.Rendering.ProfilingSampler beginCameraRendering;
                        static /*0x18*/ UnityEngine.Rendering.ProfilingSampler endCameraRendering;
                        static /*0x20*/ UnityEngine.Rendering.ProfilingSampler initializeCameraData;
                        static /*0x28*/ UnityEngine.Rendering.ProfilingSampler initializeStackedCameraData;
                        static /*0x30*/ UnityEngine.Rendering.ProfilingSampler initializeAdditionalCameraData;
                        static /*0x38*/ UnityEngine.Rendering.ProfilingSampler initializeRenderingData;
                        static /*0x40*/ UnityEngine.Rendering.ProfilingSampler initializeShadowData;
                        static /*0x48*/ UnityEngine.Rendering.ProfilingSampler initializeLightData;
                        static /*0x50*/ UnityEngine.Rendering.ProfilingSampler getPerObjectLightFlags;
                        static /*0x58*/ UnityEngine.Rendering.ProfilingSampler getMainLightIndex;
                        static /*0x60*/ UnityEngine.Rendering.ProfilingSampler setupPerFrameShaderConstants;
                        static /*0x68*/ UnityEngine.Rendering.ProfilingSampler setupPerCameraShaderConstants;

                        static /*0x13e8540*/ Pipeline();

                        class Renderer
                        {
                            static string k_Name = "ScriptableRenderer";
                            static /*0x0*/ UnityEngine.Rendering.ProfilingSampler setupCullingParameters;
                            static /*0x8*/ UnityEngine.Rendering.ProfilingSampler setup;

                            static /*0x13e92a0*/ Renderer();
                        }

                        class Context
                        {
                            static string k_Name = "ScriptableRenderContext";
                            static /*0x0*/ UnityEngine.Rendering.ProfilingSampler submit;

                            static /*0x13e65c0*/ Context();
                        }
                    }
                }

                class SingleCameraRequest
                {
                    /*0x10*/ UnityEngine.RenderTexture destination;
                    /*0x18*/ int mipLevel;
                    /*0x1c*/ UnityEngine.CubemapFace face;
                    /*0x20*/ int slice;

                    /*0x13e9cd0*/ SingleCameraRequest();
                }

                class <>c
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.UniversalRenderPipeline.<> <>9;
                    static /*0x8*/ System.Comparison<UnityEngine.Camera> <>9__33_0;

                    static /*0x13f0f30*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x13f0e70*/ int <.ctor>b__33_0(UnityEngine.Camera camera1, UnityEngine.Camera camera2);
                    /*0x13f0ad0*/ void <.cctor>b__99_0(UnityEngine.Light[] requests, Unity.Collections.NativeArray<UnityEngine.Experimental.GlobalIllumination.LightDataGI> lightsOutput);
                }
            }

            class NativeArrayExtensions
            {
                static /*0x2a5510*/ ref T UnsafeElementAt<T>(Unity.Collections.NativeArray<T> array, int index);
                static /*0x2a5510*/ ref T UnsafeElementAtMutable<T>(Unity.Collections.NativeArray<T> array, int index);
            }

            enum MixedLightingSetup
            {
                None = 0,
                ShadowMask = 1,
                Subtractive = 2,
            }

            enum ImageScalingMode
            {
                None = 0,
                Upscaling = 1,
                Downscaling = 2,
            }

            enum ImageUpscalingFilter
            {
                Linear = 0,
                Point = 1,
                FSR = 2,
            }

            struct RenderingData
            {
                /*0x10*/ UnityEngine.Rendering.CommandBuffer commandBuffer;
                /*0x18*/ UnityEngine.Rendering.CullingResults cullResults;
                /*0x28*/ UnityEngine.Rendering.Universal.CameraData cameraData;
                /*0x238*/ UnityEngine.Rendering.Universal.LightData lightData;
                /*0x260*/ UnityEngine.Rendering.Universal.ShadowData shadowData;
                /*0x2b0*/ UnityEngine.Rendering.Universal.PostProcessingData postProcessingData;
                /*0x2bc*/ bool supportsDynamicBatching;
                /*0x2c0*/ UnityEngine.Rendering.PerObjectData perObjectData;
                /*0x2c4*/ bool postProcessingEnabled;
            }

            struct LightData
            {
                /*0x10*/ int mainLightIndex;
                /*0x14*/ int additionalLightsCount;
                /*0x18*/ int maxPerObjectAdditionalLightsCount;
                /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights;
                /*0x30*/ bool shadeAdditionalLightsPerVertex;
                /*0x31*/ bool supportsMixedLighting;
                /*0x32*/ bool reflectionProbeBoxProjection;
                /*0x33*/ bool reflectionProbeBlending;
                /*0x34*/ bool supportsLightLayers;
                /*0x35*/ bool supportsAdditionalLights;
            }

            struct CameraData
            {
                /*0x10*/ UnityEngine.Matrix4x4 m_ViewMatrix;
                /*0x50*/ UnityEngine.Matrix4x4 m_ProjectionMatrix;
                /*0x90*/ UnityEngine.Matrix4x4 m_JitterMatrix;
                /*0xd0*/ UnityEngine.Camera camera;
                /*0xd8*/ UnityEngine.Rendering.Universal.CameraRenderType renderType;
                /*0xe0*/ UnityEngine.RenderTexture targetTexture;
                /*0xe8*/ UnityEngine.RenderTextureDescriptor cameraTargetDescriptor;
                /*0x11c*/ UnityEngine.Rect pixelRect;
                /*0x12c*/ bool useScreenCoordOverride;
                /*0x130*/ UnityEngine.Vector4 screenSizeOverride;
                /*0x140*/ UnityEngine.Vector4 screenCoordScaleBias;
                /*0x150*/ int pixelWidth;
                /*0x154*/ int pixelHeight;
                /*0x158*/ float aspectRatio;
                /*0x15c*/ float renderScale;
                /*0x160*/ UnityEngine.Rendering.Universal.ImageScalingMode imageScalingMode;
                /*0x164*/ UnityEngine.Rendering.Universal.ImageUpscalingFilter upscalingFilter;
                /*0x168*/ bool fsrOverrideSharpness;
                /*0x16c*/ float fsrSharpness;
                /*0x170*/ UnityEngine.Rendering.Universal.HDRColorBufferPrecision hdrColorBufferPrecision;
                /*0x174*/ bool clearDepth;
                /*0x178*/ UnityEngine.CameraType cameraType;
                /*0x17c*/ bool isDefaultViewport;
                /*0x17d*/ bool isHdrEnabled;
                /*0x17e*/ bool allowHDROutput;
                /*0x17f*/ bool requiresDepthTexture;
                /*0x180*/ bool requiresOpaqueTexture;
                /*0x181*/ bool postProcessingRequiresDepthTexture;
                /*0x182*/ bool xrRendering;
                /*0x183*/ bool stackLastCameraOutputToHDR;
                /*0x184*/ UnityEngine.Rendering.SortingCriteria defaultOpaqueSortFlags;
                /*0x188*/ UnityEngine.Experimental.Rendering.XRPass <xr>k__BackingField;
                /*0x190*/ bool isStereoEnabled;
                /*0x194*/ float maxShadowDistance;
                /*0x198*/ bool postProcessEnabled;
                /*0x199*/ bool stackAnyPostProcessingEnabled;
                /*0x1a0*/ System.Collections.Generic.IEnumerator<System.Action<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.CommandBuffer>> captureActions;
                /*0x1a8*/ UnityEngine.LayerMask volumeLayerMask;
                /*0x1b0*/ UnityEngine.Transform volumeTrigger;
                /*0x1b8*/ bool isStopNaNEnabled;
                /*0x1b9*/ bool isDitheringEnabled;
                /*0x1bc*/ UnityEngine.Rendering.Universal.AntialiasingMode antialiasing;
                /*0x1c0*/ UnityEngine.Rendering.Universal.AntialiasingQuality antialiasingQuality;
                /*0x1c8*/ UnityEngine.Rendering.Universal.ScriptableRenderer renderer;
                /*0x1d0*/ bool resolveFinalTarget;
                /*0x1d4*/ UnityEngine.Vector3 worldSpaceCameraPos;
                /*0x1e0*/ UnityEngine.Color backgroundColor;
                /*0x1f0*/ UnityEngine.Rendering.Universal.TaaPersistentData taaPersistentData;
                /*0x1f8*/ UnityEngine.Rendering.Universal.TemporalAA.Settings taaSettings;
                /*0x218*/ UnityEngine.Camera baseCamera;

                /*0x13e5a20*/ void SetViewAndProjectionMatrix(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix);
                /*0x13e5ad0*/ void SetViewProjectionAndJitterMatrix(UnityEngine.Matrix4x4 viewMatrix, UnityEngine.Matrix4x4 projectionMatrix, UnityEngine.Matrix4x4 jitterMatrix);
                /*0x13e5120*/ void PushBuiltinShaderConstantsXR(UnityEngine.Rendering.CommandBuffer cmd, bool renderIntoTexture);
                /*0x13e49b0*/ UnityEngine.Matrix4x4 GetViewMatrix(int viewIndex);
                /*0x13e47f0*/ UnityEngine.Matrix4x4 GetProjectionMatrix(int viewIndex);
                /*0x13e4750*/ UnityEngine.Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex);
                /*0x13e4410*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(int viewIndex);
                /*0x13e42e0*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex);
                /*0x13e4600*/ UnityEngine.Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex);
                /*0x13e6140*/ int get_scaledWidth();
                /*0x13e60f0*/ int get_scaledHeight();
                /*0x13e5e70*/ bool get_requireSrgbConversion();
                /*0x13e5df0*/ bool get_isSceneViewCamera();
                /*0x13e5dc0*/ bool get_isPreviewCamera();
                /*0x13e5dd0*/ bool get_isRenderPassSupportedCamera();
                /*0x13e6040*/ bool get_resolveToScreen();
                /*0x13e5d10*/ bool get_isHDROutputActive();
                /*0x13e5be0*/ UnityEngine.Rendering.HDROutputUtils.HDRDisplayInformation get_hdrDisplayInformation();
                /*0x13e5b50*/ UnityEngine.ColorGamut get_hdrDisplayColorGamut();
                /*0x13e5e00*/ bool get_rendersOverlayUI();
                /*0x13e4d50*/ bool IsHandleYFlipped(UnityEngine.Rendering.RTHandle handle);
                /*0x13e4a50*/ bool IsCameraProjectionMatrixFlipped();
                /*0x13e4f90*/ bool IsRenderTargetProjectionMatrixFlipped(UnityEngine.Rendering.RTHandle color, UnityEngine.Rendering.RTHandle depth);
                /*0x13e5050*/ bool IsTemporalAAEnabled();
                /*0x13e6210*/ UnityEngine.Experimental.Rendering.XRPass get_xr();
                /*0x13e6220*/ void set_xr(UnityEngine.Experimental.Rendering.XRPass value);
                /*0x13e6190*/ UnityEngine.Rendering.Universal.XRPassUniversal get_xrUniversal();
                /*0x13e6030*/ bool get_resetHistory();
            }

            struct ShadowData
            {
                /*0x10*/ bool supportsMainLightShadows;
                /*0x11*/ bool mainLightShadowsEnabled;
                /*0x12*/ bool requiresScreenSpaceShadowResolve;
                /*0x14*/ int mainLightShadowmapWidth;
                /*0x18*/ int mainLightShadowmapHeight;
                /*0x1c*/ int mainLightShadowCascadesCount;
                /*0x20*/ UnityEngine.Vector3 mainLightShadowCascadesSplit;
                /*0x2c*/ float mainLightShadowCascadeBorder;
                /*0x30*/ bool supportsAdditionalLightShadows;
                /*0x31*/ bool additionalLightShadowsEnabled;
                /*0x34*/ int additionalLightsShadowmapWidth;
                /*0x38*/ int additionalLightsShadowmapHeight;
                /*0x3c*/ bool supportsSoftShadows;
                /*0x40*/ int shadowmapDepthBufferBits;
                /*0x48*/ System.Collections.Generic.List<UnityEngine.Vector4> bias;
                /*0x50*/ System.Collections.Generic.List<int> resolution;
                /*0x58*/ bool isKeywordAdditionalLightShadowsEnabled;
                /*0x59*/ bool isKeywordSoftShadowsEnabled;
            }

            struct PreTile
            {
                /*0x10*/ Unity.Mathematics.float4 planeLeft;
                /*0x20*/ Unity.Mathematics.float4 planeRight;
                /*0x30*/ Unity.Mathematics.float4 planeBottom;
                /*0x40*/ Unity.Mathematics.float4 planeTop;
            }

            struct TileData
            {
                /*0x10*/ uint tileID;
                /*0x14*/ uint listBitMask;
                /*0x18*/ uint relLightOffset;
                /*0x1c*/ uint unused;
            }

            struct PunctualLightData
            {
                /*0x10*/ UnityEngine.Vector3 wsPos;
                /*0x1c*/ float radius;
                /*0x20*/ UnityEngine.Vector4 color;
                /*0x30*/ UnityEngine.Vector4 attenuation;
                /*0x40*/ UnityEngine.Vector3 spotDirection;
                /*0x4c*/ int flags;
                /*0x50*/ UnityEngine.Vector4 occlusionProbeInfo;
                /*0x60*/ uint layerMask;
            }

            class ShaderPropertyId
            {
                static /*0x0*/ int glossyEnvironmentColor;
                static /*0x4*/ int subtractiveShadowColor;
                static /*0x8*/ int glossyEnvironmentCubeMap;
                static /*0xc*/ int glossyEnvironmentCubeMapHDR;
                static /*0x10*/ int ambientSkyColor;
                static /*0x14*/ int ambientEquatorColor;
                static /*0x18*/ int ambientGroundColor;
                static /*0x1c*/ int time;
                static /*0x20*/ int sinTime;
                static /*0x24*/ int cosTime;
                static /*0x28*/ int deltaTime;
                static /*0x2c*/ int timeParameters;
                static /*0x30*/ int scaledScreenParams;
                static /*0x34*/ int worldSpaceCameraPos;
                static /*0x38*/ int screenParams;
                static /*0x3c*/ int alphaToMaskAvailable;
                static /*0x40*/ int projectionParams;
                static /*0x44*/ int zBufferParams;
                static /*0x48*/ int orthoParams;
                static /*0x4c*/ int globalMipBias;
                static /*0x50*/ int screenSize;
                static /*0x54*/ int screenCoordScaleBias;
                static /*0x58*/ int screenSizeOverride;
                static /*0x5c*/ int viewMatrix;
                static /*0x60*/ int projectionMatrix;
                static /*0x64*/ int viewAndProjectionMatrix;
                static /*0x68*/ int inverseViewMatrix;
                static /*0x6c*/ int inverseProjectionMatrix;
                static /*0x70*/ int inverseViewAndProjectionMatrix;
                static /*0x74*/ int cameraProjectionMatrix;
                static /*0x78*/ int inverseCameraProjectionMatrix;
                static /*0x7c*/ int worldToCameraMatrix;
                static /*0x80*/ int cameraToWorldMatrix;
                static /*0x84*/ int shadowBias;
                static /*0x88*/ int lightDirection;
                static /*0x8c*/ int lightPosition;
                static /*0x90*/ int cameraWorldClipPlanes;
                static /*0x94*/ int billboardNormal;
                static /*0x98*/ int billboardTangent;
                static /*0x9c*/ int billboardCameraParams;
                static /*0xa0*/ int blitTexture;
                static /*0xa4*/ int blitScaleBias;
                static /*0xa8*/ int sourceTex;
                static /*0xac*/ int scaleBias;
                static /*0xb0*/ int scaleBiasRt;
                static /*0xb4*/ int rendererColor;
                static /*0xb8*/ int ditheringTexture;
                static /*0xbc*/ int ditheringTextureInvSize;
                static /*0xc0*/ int renderingLayerMaxInt;
                static /*0xc4*/ int renderingLayerRcpMaxInt;
                static /*0xc8*/ int overlayUITexture;
                static /*0xcc*/ int hdrOutputLuminanceParams;
                static /*0xd0*/ int hdrOutputGradingParams;

                static /*0x13e9380*/ ShaderPropertyId();
            }

            struct PostProcessingData
            {
                /*0x10*/ UnityEngine.Rendering.Universal.ColorGradingMode gradingMode;
                /*0x14*/ int lutSize;
                /*0x18*/ bool useFastSRGBLinearConversion;
                /*0x19*/ bool supportDataDrivenLensFlare;
            }

            class ShaderKeywordStrings
            {
                static string MainLightShadows = "_MAIN_LIGHT_SHADOWS";
                static string MainLightShadowCascades = "_MAIN_LIGHT_SHADOWS_CASCADE";
                static string MainLightShadowScreen = "_MAIN_LIGHT_SHADOWS_SCREEN";
                static string CastingPunctualLightShadow = "_CASTING_PUNCTUAL_LIGHT_SHADOW";
                static string AdditionalLightsVertex = "_ADDITIONAL_LIGHTS_VERTEX";
                static string AdditionalLightsPixel = "_ADDITIONAL_LIGHTS";
                static string ForwardPlus = "_FORWARD_PLUS";
                static string AdditionalLightShadows = "_ADDITIONAL_LIGHT_SHADOWS";
                static string ReflectionProbeBoxProjection = "_REFLECTION_PROBE_BOX_PROJECTION";
                static string ReflectionProbeBlending = "_REFLECTION_PROBE_BLENDING";
                static string SoftShadows = "_SHADOWS_SOFT";
                static string SoftShadowsLow = "_SHADOWS_SOFT_LOW";
                static string SoftShadowsMedium = "_SHADOWS_SOFT_MEDIUM";
                static string SoftShadowsHigh = "_SHADOWS_SOFT_HIGH";
                static string MixedLightingSubtractive = "_MIXED_LIGHTING_SUBTRACTIVE";
                static string LightmapShadowMixing = "LIGHTMAP_SHADOW_MIXING";
                static string ShadowsShadowMask = "SHADOWS_SHADOWMASK";
                static string LightLayers = "_LIGHT_LAYERS";
                static string RenderPassEnabled = "_RENDER_PASS_ENABLED";
                static string BillboardFaceCameraPos = "BILLBOARD_FACE_CAMERA_POS";
                static string LightCookies = "_LIGHT_COOKIES";
                static string DepthNoMsaa = "_DEPTH_NO_MSAA";
                static string DepthMsaa2 = "_DEPTH_MSAA_2";
                static string DepthMsaa4 = "_DEPTH_MSAA_4";
                static string DepthMsaa8 = "_DEPTH_MSAA_8";
                static string LinearToSRGBConversion = "_LINEAR_TO_SRGB_CONVERSION";
                static string UseFastSRGBLinearConversion = "_USE_FAST_SRGB_LINEAR_CONVERSION";
                static string DBufferMRT1 = "_DBUFFER_MRT1";
                static string DBufferMRT2 = "_DBUFFER_MRT2";
                static string DBufferMRT3 = "_DBUFFER_MRT3";
                static string DecalNormalBlendLow = "_DECAL_NORMAL_BLEND_LOW";
                static string DecalNormalBlendMedium = "_DECAL_NORMAL_BLEND_MEDIUM";
                static string DecalNormalBlendHigh = "_DECAL_NORMAL_BLEND_HIGH";
                static string DecalLayers = "_DECAL_LAYERS";
                static string WriteRenderingLayers = "_WRITE_RENDERING_LAYERS";
                static string SmaaLow = "_SMAA_PRESET_LOW";
                static string SmaaMedium = "_SMAA_PRESET_MEDIUM";
                static string SmaaHigh = "_SMAA_PRESET_HIGH";
                static string PaniniGeneric = "_GENERIC";
                static string PaniniUnitDistance = "_UNIT_DISTANCE";
                static string BloomLQ = "_BLOOM_LQ";
                static string BloomHQ = "_BLOOM_HQ";
                static string BloomLQDirt = "_BLOOM_LQ_DIRT";
                static string BloomHQDirt = "_BLOOM_HQ_DIRT";
                static string UseRGBM = "_USE_RGBM";
                static string Distortion = "_DISTORTION";
                static string ChromaticAberration = "_CHROMATIC_ABERRATION";
                static string HDRGrading = "_HDR_GRADING";
                static string TonemapACES = "_TONEMAP_ACES";
                static string TonemapNeutral = "_TONEMAP_NEUTRAL";
                static string FilmGrain = "_FILM_GRAIN";
                static string Fxaa = "_FXAA";
                static string Dithering = "_DITHERING";
                static string ScreenSpaceOcclusion = "_SCREEN_SPACE_OCCLUSION";
                static string PointSampling = "_POINT_SAMPLING";
                static string Rcas = "_RCAS";
                static string EasuRcasAndHDRInput = "_EASU_RCAS_AND_HDR_INPUT";
                static string Gamma20 = "_GAMMA_20";
                static string FxaaAndGamma20 = "_FXAA_AND_GAMMA_20";
                static string HighQualitySampling = "_HIGH_QUALITY_SAMPLING";
                static string _SPOT = "_SPOT";
                static string _DIRECTIONAL = "_DIRECTIONAL";
                static string _POINT = "_POINT";
                static string _DEFERRED_STENCIL = "_DEFERRED_STENCIL";
                static string _DEFERRED_FIRST_LIGHT = "_DEFERRED_FIRST_LIGHT";
                static string _DEFERRED_MAIN_LIGHT = "_DEFERRED_MAIN_LIGHT";
                static string _GBUFFER_NORMALS_OCT = "_GBUFFER_NORMALS_OCT";
                static string _DEFERRED_MIXED_LIGHTING = "_DEFERRED_MIXED_LIGHTING";
                static string LIGHTMAP_ON = "LIGHTMAP_ON";
                static string DYNAMICLIGHTMAP_ON = "DYNAMICLIGHTMAP_ON";
                static string _ALPHATEST_ON = "_ALPHATEST_ON";
                static string DIRLIGHTMAP_COMBINED = "DIRLIGHTMAP_COMBINED";
                static string _DETAIL_MULX2 = "_DETAIL_MULX2";
                static string _DETAIL_SCALED = "_DETAIL_SCALED";
                static string _CLEARCOAT = "_CLEARCOAT";
                static string _CLEARCOATMAP = "_CLEARCOATMAP";
                static string DEBUG_DISPLAY = "DEBUG_DISPLAY";
                static string LOD_FADE_CROSSFADE = "LOD_FADE_CROSSFADE";
                static string USE_UNITY_CROSSFADE = "USE_UNITY_CROSSFADE";
                static string _EMISSION = "_EMISSION";
                static string _RECEIVE_SHADOWS_OFF = "_RECEIVE_SHADOWS_OFF";
                static string _SURFACE_TYPE_TRANSPARENT = "_SURFACE_TYPE_TRANSPARENT";
                static string _ALPHAPREMULTIPLY_ON = "_ALPHAPREMULTIPLY_ON";
                static string _ALPHAMODULATE_ON = "_ALPHAMODULATE_ON";
                static string _NORMALMAP = "_NORMALMAP";
                static string EDITOR_VISUALIZATION = "EDITOR_VISUALIZATION";
                static string DisableTexture2DXArray = "DISABLE_TEXTURE2D_X_ARRAY";
                static string BlitSingleSlice = "BLIT_SINGLE_SLICE";
                static string XROcclusionMeshCombined = "XR_OCCLUSION_MESH_COMBINED";
                static string SCREEN_COORD_OVERRIDE = "SCREEN_COORD_OVERRIDE";
                static string DOWNSAMPLING_SIZE_2 = "DOWNSAMPLING_SIZE_2";
                static string DOWNSAMPLING_SIZE_4 = "DOWNSAMPLING_SIZE_4";
                static string DOWNSAMPLING_SIZE_8 = "DOWNSAMPLING_SIZE_8";
                static string DOWNSAMPLING_SIZE_16 = "DOWNSAMPLING_SIZE_16";
                static string FoveatedRenderingNonUniformRaster = "_FOVEATED_RENDERING_NON_UNIFORM_RASTER";
                static string EVALUATE_SH_MIXED = "EVALUATE_SH_MIXED";
                static string EVALUATE_SH_VERTEX = "EVALUATE_SH_VERTEX";
                static string UseDrawProcedural = "_USE_DRAW_PROCEDURAL";
            }

            enum URPProfileId
            {
                UniversalRenderTotal = 0,
                UpdateVolumeFramework = 1,
                RenderCameraStack = 2,
                AdditionalLightsShadow = 3,
                ColorGradingLUT = 4,
                CopyColor = 5,
                CopyDepth = 6,
                DepthNormalPrepass = 7,
                DepthPrepass = 8,
                UpdateReflectionProbeAtlas = 9,
                DrawOpaqueObjects = 10,
                DrawTransparentObjects = 11,
                DrawScreenSpaceUI = 12,
                LightCookies = 13,
                MainLightShadow = 14,
                ResolveShadows = 15,
                SSAO = 16,
                StopNaNs = 17,
                SMAA = 18,
                GaussianDepthOfField = 19,
                BokehDepthOfField = 20,
                TemporalAA = 21,
                MotionBlur = 22,
                PaniniProjection = 23,
                UberPostProcess = 24,
                Bloom = 25,
                LensFlareDataDrivenComputeOcclusion = 26,
                LensFlareDataDriven = 27,
                MotionVectors = 28,
                DrawFullscreen = 29,
                FinalBlit = 30,
            }

            class PlatformAutoDetect
            {
                static /*0x0*/ bool <isXRMobile>k__BackingField;
                static /*0x1*/ bool <isShaderAPIMobileDefined>k__BackingField;
                static /*0x2*/ bool <isSwitch>k__BackingField;
                static /*0x3*/ bool isRunningOnPowerVRGPU;

                static /*0x13e8cf0*/ PlatformAutoDetect();
                static /*0x13e8a50*/ void Initialize();
                static /*0x13e8e30*/ bool get_isXRMobile();
                static /*0x13e8f40*/ void set_isXRMobile(bool value);
                static /*0x13e8d90*/ bool get_isShaderAPIMobileDefined();
                static /*0x13e8e80*/ void set_isShaderAPIMobileDefined(bool value);
                static /*0x13e8de0*/ bool get_isSwitch();
                static /*0x13e8ee0*/ void set_isSwitch(bool value);
                static /*0x13e8ba0*/ UnityEngine.Rendering.Universal.ShEvalMode ShAutoDetect(UnityEngine.Rendering.Universal.ShEvalMode mode);
            }

            class UniversalRenderPipelineGlobalSettings : UnityEngine.Rendering.RenderPipelineGlobalSettings, UnityEngine.ISerializationCallbackReceiver, UnityEngine.Rendering.IShaderVariantSettings
            {
                static /*0x0*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineGlobalSettings cachedInstance;
                static /*0x8*/ string defaultAssetName;
                /*0x18*/ int k_AssetVersion;
                /*0x20*/ string[] m_RenderingLayerNames;
                /*0x28*/ string[] m_PrefixedRenderingLayerNames;
                /*0x30*/ uint m_ValidRenderingLayers;
                /*0x38*/ string lightLayerName0;
                /*0x40*/ string lightLayerName1;
                /*0x48*/ string lightLayerName2;
                /*0x50*/ string lightLayerName3;
                /*0x58*/ string lightLayerName4;
                /*0x60*/ string lightLayerName5;
                /*0x68*/ string lightLayerName6;
                /*0x70*/ string lightLayerName7;
                /*0x78*/ bool m_StripDebugVariants;
                /*0x79*/ bool m_StripUnusedPostProcessingVariants;
                /*0x7a*/ bool m_StripUnusedVariants;
                /*0x7b*/ bool m_StripUnusedLODCrossFadeVariants;
                /*0x7c*/ bool m_StripScreenCoordOverrideVariants;
                /*0x7d*/ bool supportRuntimeDebugDisplay;
                /*0x80*/ UnityEngine.Rendering.ShaderVariantLogLevel m_ShaderVariantLogLevel;
                /*0x84*/ bool m_ExportShaderVariants;

                static /*0x13f1350*/ UniversalRenderPipelineGlobalSettings();
                static /*0x13f14b0*/ UnityEngine.Rendering.Universal.UniversalRenderPipelineGlobalSettings get_instance();
                static /*0x13f10b0*/ void UpdateGraphicsSettings(UnityEngine.Rendering.Universal.UniversalRenderPipelineGlobalSettings newSettings);
                /*0x13f13f0*/ UniversalRenderPipelineGlobalSettings();
                /*0x32d010*/ void OnBeforeSerialize();
                /*0x32d010*/ void OnAfterDeserialize();
                /*0x13f10a0*/ void Reset();
                /*0x13f16f0*/ string[] get_renderingLayerNames();
                /*0x13f16c0*/ string[] get_prefixedRenderingLayerNames();
                /*0x13f16f0*/ string[] get_renderingLayerMaskNames();
                /*0x13f16c0*/ string[] get_prefixedRenderingLayerMaskNames();
                /*0x13f1770*/ uint get_validRenderingLayers();
                /*0x13f11e0*/ void UpdateRenderingLayerNames();
                /*0x13f1680*/ string[] get_prefixedLightLayerNames();
                /*0x13f1640*/ string[] get_lightLayerNames();
                /*0x13f1010*/ void ResetRenderingLayerNames();
                /*0x13f1720*/ bool get_stripDebugVariants();
                /*0x13f17c0*/ void set_stripDebugVariants(bool value);
                /*0x13f1750*/ bool get_stripUnusedPostProcessingVariants();
                /*0x13f17f0*/ void set_stripUnusedPostProcessingVariants(bool value);
                /*0x13f1760*/ bool get_stripUnusedVariants();
                /*0x13f1800*/ void set_stripUnusedVariants(bool value);
                /*0x13f1740*/ bool get_stripUnusedLODCrossFadeVariants();
                /*0x13f17e0*/ void set_stripUnusedLODCrossFadeVariants(bool value);
                /*0x13f1730*/ bool get_stripScreenCoordOverrideVariants();
                /*0x13f17d0*/ void set_stripScreenCoordOverrideVariants(bool value);
                /*0x12d9c50*/ UnityEngine.Rendering.ShaderVariantLogLevel get_shaderVariantLogLevel();
                /*0x13f17b0*/ void set_shaderVariantLogLevel(UnityEngine.Rendering.ShaderVariantLogLevel value);
                /*0x1355390*/ bool get_exportShaderVariants();
                /*0x13f17a0*/ void set_exportShaderVariants(bool value);
            }

            class XRPassUniversal : UnityEngine.Experimental.Rendering.XRPass
            {
                /*0x6d0*/ bool <isLateLatchEnabled>k__BackingField;
                /*0x6d1*/ bool <canMarkLateLatch>k__BackingField;
                /*0x6d2*/ bool <hasMarkedLateLatch>k__BackingField;

                static /*0x13fbb90*/ UnityEngine.Experimental.Rendering.XRPass Create(UnityEngine.Experimental.Rendering.XRPassCreateInfo createInfo);
                /*0x13fbca0*/ XRPassUniversal();
                /*0x13fbc40*/ void Release();
                /*0x13fbcd0*/ bool get_isLateLatchEnabled();
                /*0x13fbd00*/ void set_isLateLatchEnabled(bool value);
                /*0x13fbcb0*/ bool get_canMarkLateLatch();
                /*0x13fbce0*/ void set_canMarkLateLatch(bool value);
                /*0x13fbcc0*/ bool get_hasMarkedLateLatch();
                /*0x13fbcf0*/ void set_hasMarkedLateLatch(bool value);
            }

            class XRSystemUniversal
            {
                static /*0x0*/ UnityEngine.Matrix4x4[] s_projMatrix;

                static /*0x13fc180*/ XRSystemUniversal();
                static /*0x13fbd10*/ void BeginLateLatching(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.XRPassUniversal xrPass);
                static /*0x13fbde0*/ void EndLateLatching(UnityEngine.Camera camera, UnityEngine.Rendering.Universal.XRPassUniversal xrPass);
                static /*0x13fc100*/ void UnmarkShaderProperties(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.XRPassUniversal xrPass);
                static /*0x13fbea0*/ void MarkShaderProperties(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.XRPassUniversal xrPass, bool renderIntoTexture);
            }

            namespace LibTessDotNet
            {
                class Dict<TValue>
                {
                    /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.LessOrEqual<TValue> _leq;
                    /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> _head;

                    /*0x17aec0*/ Dict(UnityEngine.Rendering.Universal.LibTessDotNet.Dict.LessOrEqual<TValue> leq);
                    /*0x2a5510*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> Insert(TValue key);
                    /*0x2a5510*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> InsertBefore(UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> node, TValue key);
                    /*0x2a5510*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> Find(TValue key);
                    /*0x1803b0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> Min();
                    /*0x17aec0*/ void Remove(UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> node);

                    class Node<TValue>
                    {
                        /*0x0*/ TValue _key;
                        /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> _prev;
                        /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> _next;

                        /*0x180fc0*/ Node();
                        /*0x2a5510*/ TValue get_Key();
                        /*0x1803b0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> get_Prev();
                        /*0x1803b0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<TValue> get_Next();
                    }

                    class LessOrEqual<TValue> : System.MulticastDelegate
                    {
                        LessOrEqual(object object, nint method);
                        /*0x2a5510*/ bool Invoke(TValue lhs, TValue rhs);
                        /*0x2a5510*/ System.IAsyncResult BeginInvoke(TValue lhs, TValue rhs, System.AsyncCallback callback, object object);
                        /*0x17e620*/ bool EndInvoke(System.IAsyncResult result);
                    }
                }

                class Geom
                {
                    static /*0x13e6780*/ bool IsWindingInside(UnityEngine.Rendering.Universal.LibTessDotNet.WindingRule rule, int n);
                    static /*0x10ecb70*/ bool VertCCW(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex u, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex v, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex w);
                    static /*0x10ecbd0*/ bool VertEq(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex lhs, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex rhs);
                    static /*0x10eccb0*/ bool VertLeq(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex lhs, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex rhs);
                    static /*0x10ebe20*/ float EdgeEval(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex u, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex v, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex w);
                    static /*0x10ec880*/ float EdgeSign(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex u, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex v, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex w);
                    static /*0x10ecab0*/ bool TransLeq(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex lhs, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex rhs);
                    static /*0x10eca00*/ float TransEval(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex u, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex v, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex w);
                    static /*0x10ecb00*/ float TransSign(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex u, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex v, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex w);
                    static /*0x10ebed0*/ bool EdgeGoesLeft(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge e);
                    static /*0x10ebf40*/ bool EdgeGoesRight(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge e);
                    static /*0x13e6830*/ float VertL1dist(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex u, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex v);
                    static /*0x10ebde0*/ void AddWinding(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eDst, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eSrc);
                    static /*0x10ec8f0*/ float Interpolate(float a, float x, float b, float y);
                    static /*0x62e230*/ void Swap(ref UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex a, ref UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex b);
                    static /*0x10ebfb0*/ void EdgeIntersect(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex o1, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex d1, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex o2, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex d2, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex v);
                }

                class Mesh : UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Pooled<UnityEngine.Rendering.Universal.LibTessDotNet.Mesh>
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex _vHead;
                    /*0x18*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face _fHead;
                    /*0x20*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _eHead;
                    /*0x28*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _eHeadSym;

                    /*0x13e81f0*/ Mesh();
                    /*0x10edf90*/ void Reset();
                    /*0x13e78a0*/ void OnFree();
                    /*0x13e7590*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge MakeEdge();
                    /*0x13e79a0*/ void Splice(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eOrg, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eDst);
                    /*0x13e7310*/ void Delete(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eDel);
                    /*0x13e6fb0*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge AddEdgeVertex(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eOrg);
                    /*0x13e7b10*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge SplitEdge(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eOrg);
                    /*0x13e70f0*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge Connect(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eOrg, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eDst);
                    /*0x13e7e00*/ void ZapFace(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face fZap);
                    /*0x13e7600*/ void MergeConvexFaces(int maxVertsPerFace);
                    /*0x10ed630*/ void Check();
                }

                struct Vec3
                {
                    static /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 Zero;
                    /*0x10*/ float X;
                    /*0x14*/ float Y;
                    /*0x18*/ float Z;

                    static /*0x32d010*/ Vec3();
                    static /*0x110a120*/ void Sub(ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 lhs, ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 rhs, ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 result);
                    static /*0x110a030*/ void Neg(ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 v);
                    static /*0x1109f20*/ void Dot(ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 u, ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 v, ref float dot);
                    static /*0x13fb820*/ void Normalize(ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 v);
                    static /*0x13fb740*/ int LongAxis(ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 v);
                    /*0x13fb9a0*/ float get_Item(int index);
                    /*0x13fba20*/ void set_Item(int index, float value);
                    /*0x13fb8e0*/ string ToString();
                }

                class MeshUtils
                {
                    static int Undef = -1;

                    static /*0x13e6b30*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge MakeEdge(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eNext);
                    static /*0x10ed450*/ void Splice(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge a, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge b);
                    static /*0x13e6ec0*/ void MakeVertex(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eOrig, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex vNext);
                    static /*0x13e6db0*/ void MakeFace(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eOrig, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face fNext);
                    static /*0x13e68d0*/ void KillEdge(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eDel);
                    static /*0x13e6a70*/ void KillVertex(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex vDel, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex newOrg);
                    static /*0x13e69b0*/ void KillFace(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face fDel, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face newLFace);
                    static /*0x10ecd00*/ float FaceArea(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face f);

                    class Pooled<T>
                    {
                        static /*0x0*/ System.Collections.Generic.Stack<T> _stack;

                        static /*0x2a5510*/ T Create();
                        /*0x180fc0*/ Pooled();
                        /*0x180fc0*/ void Reset();
                        /*0x180fc0*/ void OnFree();
                        /*0x180fc0*/ void Free();
                    }

                    class Vertex : UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Pooled<UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex>
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex _prev;
                        /*0x18*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex _next;
                        /*0x20*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _anEdge;
                        /*0x28*/ UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 _coords;
                        /*0x34*/ float _s;
                        /*0x38*/ float _t;
                        /*0x3c*/ UnityEngine.Rendering.Universal.LibTessDotNet.PQHandle _pqHandle;
                        /*0x40*/ int _n;
                        /*0x48*/ object _data;

                        /*0x13fbb50*/ Vertex();
                        /*0x13fbaa0*/ void Reset();
                    }

                    class Face : UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Pooled<UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face>
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face _prev;
                        /*0x18*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face _next;
                        /*0x20*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _anEdge;
                        /*0x28*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face _trail;
                        /*0x30*/ int _n;
                        /*0x34*/ bool _marked;
                        /*0x35*/ bool _inside;

                        /*0x13e6740*/ Face();
                        /*0x10ebdb0*/ int get_VertsCount();
                        /*0x10ebd10*/ void Reset();
                    }

                    struct EdgePair
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _e;
                        /*0x18*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _eSym;

                        static /*0x13e6650*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.EdgePair Create();
                        /*0x10eb900*/ void Reset();
                    }

                    class Edge : UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Pooled<UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge>
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.EdgePair _pair;
                        /*0x20*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _next;
                        /*0x28*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _Sym;
                        /*0x30*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _Onext;
                        /*0x38*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _Lnext;
                        /*0x40*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex _Org;
                        /*0x48*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face _Lface;
                        /*0x50*/ UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion _activeRegion;
                        /*0x58*/ int _winding;

                        static /*0x10eb940*/ void EnsureFirst(ref UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge e);
                        /*0x13e6700*/ Edge();
                        /*0x10ebb20*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face get__Rface();
                        /*0x10ebc80*/ void set__Rface(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face value);
                        /*0x10ebac0*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex get__Dst();
                        /*0x10ebbf0*/ void set__Dst(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex value);
                        /*0x10ebb00*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge get__Oprev();
                        /*0x10ebc50*/ void set__Oprev(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge value);
                        /*0x10ebae0*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge get__Lprev();
                        /*0x10ebc20*/ void set__Lprev(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge value);
                        /*0x10ebaa0*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge get__Dprev();
                        /*0x10ebbc0*/ void set__Dprev(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge value);
                        /*0x10ebb70*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge get__Rprev();
                        /*0x10ebce0*/ void set__Rprev(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge value);
                        /*0x10eba70*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge get__Dnext();
                        /*0x10ebb90*/ void set__Dnext(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge value);
                        /*0x10ebb40*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge get__Rnext();
                        /*0x10ebcb0*/ void set__Rnext(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge value);
                        /*0x10eb980*/ void Reset();
                    }
                }

                struct PQHandle
                {
                    static /*0x0*/ int Invalid;
                    /*0x10*/ int _handle;

                    static /*0x13e8500*/ PQHandle();
                }

                class PriorityHeap<TValue>
                {
                    /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.PriorityHeap.LessOrEqual<TValue> _leq;
                    /*0x0*/ int[] _nodes;
                    /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.PriorityHeap.HandleElem<TValue> _handles;
                    /*0x0*/ int _size;
                    /*0x0*/ int _max;
                    /*0x0*/ int _freeList;
                    /*0x0*/ bool _initialized;

                    PriorityHeap(int initialSize, UnityEngine.Rendering.Universal.LibTessDotNet.PriorityHeap.LessOrEqual<TValue> leq);
                    /*0x17cb40*/ bool get_Empty();
                    /*0x17aa40*/ void FloatDown(int curr);
                    /*0x17aa40*/ void FloatUp(int curr);
                    /*0x180fc0*/ void Init();
                    /*0x2a5510*/ UnityEngine.Rendering.Universal.LibTessDotNet.PQHandle Insert(TValue value);
                    /*0x2a5510*/ TValue ExtractMin();
                    /*0x2a5510*/ TValue Minimum();
                    /*0x2a5510*/ void Remove(UnityEngine.Rendering.Universal.LibTessDotNet.PQHandle handle);

                    class LessOrEqual<TValue> : System.MulticastDelegate
                    {
                        LessOrEqual(object object, nint method);
                        /*0x2a5510*/ bool Invoke(TValue lhs, TValue rhs);
                        /*0x2a5510*/ System.IAsyncResult BeginInvoke(TValue lhs, TValue rhs, System.AsyncCallback callback, object object);
                        /*0x17e620*/ bool EndInvoke(System.IAsyncResult result);
                    }

                    class HandleElem<TValue>
                    {
                        /*0x0*/ TValue _key;
                        /*0x0*/ int _node;

                        /*0x180fc0*/ HandleElem();
                    }
                }

                class PriorityQueue<TValue>
                {
                    /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.PriorityHeap.LessOrEqual<TValue> _leq;
                    /*0x0*/ UnityEngine.Rendering.Universal.LibTessDotNet.PriorityHeap<TValue> _heap;
                    /*0x0*/ TValue[] _keys;
                    /*0x0*/ int[] _order;
                    /*0x0*/ int _size;
                    /*0x0*/ int _max;
                    /*0x0*/ bool _initialized;

                    static /*0x177670*/ void Swap(ref int a, ref int b);
                    PriorityQueue(int initialSize, UnityEngine.Rendering.Universal.LibTessDotNet.PriorityHeap.LessOrEqual<TValue> leq);
                    /*0x17cb40*/ bool get_Empty();
                    /*0x180fc0*/ void Init();
                    /*0x2a5510*/ UnityEngine.Rendering.Universal.LibTessDotNet.PQHandle Insert(TValue value);
                    /*0x2a5510*/ TValue ExtractMin();
                    /*0x2a5510*/ TValue Minimum();
                    /*0x2a5510*/ void Remove(UnityEngine.Rendering.Universal.LibTessDotNet.PQHandle handle);

                    class StackItem<TValue>
                    {
                        /*0x0*/ int p;
                        /*0x0*/ int r;

                        /*0x180fc0*/ StackItem();
                    }
                }

                class Tess
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.Mesh _mesh;
                    /*0x18*/ UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 _normal;
                    /*0x24*/ UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 _sUnit;
                    /*0x30*/ UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 _tUnit;
                    /*0x3c*/ float _bminX;
                    /*0x40*/ float _bminY;
                    /*0x44*/ float _bmaxX;
                    /*0x48*/ float _bmaxY;
                    /*0x4c*/ UnityEngine.Rendering.Universal.LibTessDotNet.WindingRule _windingRule;
                    /*0x50*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict<UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion> _dict;
                    /*0x58*/ UnityEngine.Rendering.Universal.LibTessDotNet.PriorityQueue<UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex> _pq;
                    /*0x60*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex _event;
                    /*0x68*/ UnityEngine.Rendering.Universal.LibTessDotNet.CombineCallback _combineCallback;
                    /*0x70*/ UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex[] _vertices;
                    /*0x78*/ int _vertexCount;
                    /*0x80*/ int[] _elements;
                    /*0x88*/ int _elementCount;
                    /*0x8c*/ float SUnitX;
                    /*0x90*/ float SUnitY;
                    /*0x94*/ float SentinelCoord;
                    /*0x98*/ bool NoEmptyPolygons;
                    /*0x99*/ bool UsePooling;

                    /*0x13f0980*/ Tess();
                    /*0x11088f0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion RegionBelow(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x11088c0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion RegionAbove(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x1106c80*/ bool EdgeLeq(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg1, UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg2);
                    /*0x13edcd0*/ void DeleteRegion(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x13ee0f0*/ void FixUpperEdge(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge newEdge);
                    /*0x13f0280*/ UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion TopLeftRegion(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x1109690*/ UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion TopRightRegion(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x13e9f50*/ UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion AddRegionBelow(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regAbove, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eNewUp);
                    /*0x13ed2e0*/ void ComputeWinding(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x13ee050*/ void FinishRegion(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion reg);
                    /*0x13edeb0*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge FinishLeftRegions(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regFirst, UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regLast);
                    /*0x13ea040*/ void AddRightEdges(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regUp, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eFirst, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eLast, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eTopLeft, bool cleanUp);
                    /*0x13efa10*/ void SpliceMergeVertices(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge e1, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge e2);
                    /*0x13f03c0*/ void VertexWeights(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex isect, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex org, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex dst, ref float w0, ref float w1);
                    /*0x13ee160*/ void GetIntersectData(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex isect, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex orgUp, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex dstUp, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex orgLo, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex dstLo);
                    /*0x13eb1c0*/ bool CheckForRightSplice(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regUp);
                    /*0x13eaf10*/ bool CheckForLeftSplice(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regUp);
                    /*0x13ea510*/ bool CheckForIntersect(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regUp);
                    /*0x13f0590*/ void WalkDirtyRegions(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regUp);
                    /*0x13ed9b0*/ void ConnectRightVertex(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regUp, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge eBottomLeft);
                    /*0x13ed340*/ void ConnectLeftDegenerate(UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion regUp, UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex vEvent);
                    /*0x13ed4f0*/ void ConnectLeftVertex(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex vEvent);
                    /*0x13efa30*/ void SweepEvent(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Vertex vEvent);
                    /*0x13ea370*/ void AddSentinel(float smin, float smax, float t);
                    /*0x13ee500*/ void InitEdgeDict();
                    /*0x13eddc0*/ void DoneEdgeDict();
                    /*0x13ef6e0*/ void RemoveDegenerateEdges();
                    /*0x13ee600*/ void InitPriorityQ();
                    /*0x1106c60*/ void DonePriorityQ();
                    /*0x13ef860*/ void RemoveDegenerateFaces();
                    /*0x13eb600*/ void ComputeInterior();
                    /*0xa3cae0*/ UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 get_Normal();
                    /*0xdd5210*/ void set_Normal(UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 value);
                    /*0xd184b0*/ UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex[] get_Vertices();
                    /*0x1101d10*/ int get_VertexCount();
                    /*0xeeac90*/ int[] get_Elements();
                    /*0x737a20*/ int get_ElementCount();
                    /*0x13ec9d0*/ void ComputeNormal(ref UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 norm);
                    /*0x13eb4b0*/ void CheckOrientation();
                    /*0x13eefd0*/ void ProjectPolygon();
                    /*0x13efbc0*/ void TessellateMonoRegion(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Face face);
                    /*0x13efb50*/ void TessellateInterior();
                    /*0x13edd50*/ void DiscardExterior();
                    /*0x13ef920*/ void SetWindingNumber(int value, bool keepOnlyBoundary);
                    /*0x11076a0*/ int GetNeighbourFace(UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge edge);
                    /*0x13eeac0*/ void OutputPolymesh(UnityEngine.Rendering.Universal.LibTessDotNet.ElementType elementType, int polySize);
                    /*0x13ee800*/ void OutputContours();
                    /*0x1108c50*/ float SignedArea(UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex[] vertices);
                    /*0x13e9f40*/ void AddContour(UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex[] vertices);
                    /*0x13e9ce0*/ void AddContour(UnityEngine.Rendering.Universal.LibTessDotNet.ContourVertex[] vertices, UnityEngine.Rendering.Universal.LibTessDotNet.ContourOrientation forceOrientation);
                    /*0x13f0000*/ void Tessellate(UnityEngine.Rendering.Universal.LibTessDotNet.WindingRule windingRule, UnityEngine.Rendering.Universal.LibTessDotNet.ElementType elementType, int polySize);
                    /*0x13f0020*/ void Tessellate(UnityEngine.Rendering.Universal.LibTessDotNet.WindingRule windingRule, UnityEngine.Rendering.Universal.LibTessDotNet.ElementType elementType, int polySize, UnityEngine.Rendering.Universal.LibTessDotNet.CombineCallback combineCallback);

                    class ActiveRegion
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.MeshUtils.Edge _eUp;
                        /*0x18*/ UnityEngine.Rendering.Universal.LibTessDotNet.Dict.Node<UnityEngine.Rendering.Universal.LibTessDotNet.Tess.ActiveRegion> _nodeUp;
                        /*0x20*/ int _windingNumber;
                        /*0x24*/ bool _inside;
                        /*0x25*/ bool _sentinel;
                        /*0x26*/ bool _dirty;
                        /*0x27*/ bool _fixUpperEdge;

                        /*0x32f970*/ ActiveRegion();
                    }
                }

                enum WindingRule
                {
                    EvenOdd = 0,
                    NonZero = 1,
                    Positive = 2,
                    Negative = 3,
                    AbsGeqTwo = 4,
                }

                enum ElementType
                {
                    Polygons = 0,
                    ConnectedPolygons = 1,
                    BoundaryContours = 2,
                }

                enum ContourOrientation
                {
                    Original = 0,
                    Clockwise = 1,
                    CounterClockwise = 2,
                }

                struct ContourVertex
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 Position;
                    /*0x20*/ object Data;

                    /*0x1403490*/ string ToString();
                }

                class CombineCallback : System.MulticastDelegate
                {
                    /*0x10eb380*/ CombineCallback(object object, nint method);
                    /*0x10eb340*/ object Invoke(UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 position, object[] data, float[] weights);
                    /*0x1403400*/ System.IAsyncResult BeginInvoke(UnityEngine.Rendering.Universal.LibTessDotNet.Vec3 position, object[] data, float[] weights, System.AsyncCallback callback, object object);
                    /*0x723cb0*/ object EndInvoke(System.IAsyncResult result);
                }
            }

            namespace Internal
            {
                class DeferredConfig
                {
                    static /*0x0*/ bool <IsOpenGL>k__BackingField;
                    static /*0x1*/ bool <IsDX10>k__BackingField;

                    static /*0x1404b20*/ bool get_IsOpenGL();
                    static /*0x1404ba0*/ void set_IsOpenGL(bool value);
                    static /*0x1404ae0*/ bool get_IsDX10();
                    static /*0x1404b60*/ void set_IsDX10(bool value);
                }

                enum LightFlag
                {
                    SubtractiveMixedLighting = 4,
                }

                class DeferredLights
                {
                    static /*0x0*/ string[] k_GBufferNames;
                    static /*0x8*/ string[] k_StencilDeferredPassNames;
                    static /*0x10*/ ushort k_InvalidLightOffset;
                    static /*0x18*/ string k_SetupLights;
                    static /*0x20*/ string k_DeferredPass;
                    static /*0x28*/ string k_DeferredStencilPass;
                    static /*0x30*/ string k_DeferredFogPass;
                    static /*0x38*/ string k_ClearStencilPartial;
                    static /*0x40*/ string k_SetupLightConstants;
                    static /*0x48*/ float kStencilShapeGuard;
                    static /*0x50*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSetupLights;
                    static /*0x58*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingDeferredPass;
                    static /*0x60*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSetupLightConstants;
                    /*0x10*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize <RenderingLayerMaskSize>k__BackingField;
                    /*0x14*/ bool <UseDecalLayers>k__BackingField;
                    /*0x15*/ bool <UseRenderPass>k__BackingField;
                    /*0x16*/ bool <HasDepthPrepass>k__BackingField;
                    /*0x17*/ bool <HasNormalPrepass>k__BackingField;
                    /*0x18*/ bool <HasRenderingLayerPrepass>k__BackingField;
                    /*0x19*/ bool <IsOverlay>k__BackingField;
                    /*0x1a*/ bool <AccurateGbufferNormals>k__BackingField;
                    /*0x1c*/ UnityEngine.Rendering.Universal.MixedLightingSetup <MixedLightingSetup>k__BackingField;
                    /*0x20*/ bool <UseJobSystem>k__BackingField;
                    /*0x24*/ int <RenderWidth>k__BackingField;
                    /*0x28*/ int <RenderHeight>k__BackingField;
                    /*0x30*/ UnityEngine.Rendering.RTHandle[] <GbufferAttachments>k__BackingField;
                    /*0x38*/ UnityEngine.Rendering.RTHandle[] GbufferRTHandles;
                    /*0x40*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] <GbufferTextureHandles>k__BackingField;
                    /*0x48*/ UnityEngine.Rendering.RTHandle[] <DeferredInputAttachments>k__BackingField;
                    /*0x50*/ bool[] <DeferredInputIsTransient>k__BackingField;
                    /*0x58*/ UnityEngine.Rendering.RTHandle <DepthAttachment>k__BackingField;
                    /*0x60*/ UnityEngine.Rendering.RTHandle <DepthCopyTexture>k__BackingField;
                    /*0x68*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] <GbufferFormats>k__BackingField;
                    /*0x70*/ UnityEngine.Rendering.RTHandle <DepthAttachmentHandle>k__BackingField;
                    /*0x78*/ Unity.Collections.NativeArray<ushort> m_stencilVisLights;
                    /*0x88*/ Unity.Collections.NativeArray<ushort> m_stencilVisLightOffsets;
                    /*0x98*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass m_AdditionalLightsShadowCasterPass;
                    /*0xa0*/ UnityEngine.Mesh m_SphereMesh;
                    /*0xa8*/ UnityEngine.Mesh m_HemisphereMesh;
                    /*0xb0*/ UnityEngine.Mesh m_FullscreenMesh;
                    /*0xb8*/ UnityEngine.Material m_StencilDeferredMaterial;
                    /*0xc0*/ int[] m_StencilDeferredPasses;
                    /*0xc8*/ UnityEngine.Matrix4x4[] m_ScreenToWorld;
                    /*0xd0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerDeferredStencilPass;
                    /*0xd8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerDeferredFogPass;
                    /*0xe0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerClearStencilPartialPass;
                    /*0xe8*/ UnityEngine.Rendering.Universal.LightCookieManager m_LightCookieManager;

                    static /*0x140add0*/ DeferredLights();
                    static /*0x1407650*/ UnityEngine.Rendering.StencilState OverwriteStencil(UnityEngine.Rendering.StencilState s, int stencilWriteMask);
                    static /*0x1407360*/ UnityEngine.Rendering.RenderStateBlock OverwriteStencil(UnityEngine.Rendering.RenderStateBlock block, int stencilWriteMask, int stencilRef);
                    static /*0x1405a50*/ UnityEngine.Mesh CreateSphereMesh();
                    static /*0x1405350*/ UnityEngine.Mesh CreateHemisphereMesh();
                    static /*0x1404dc0*/ UnityEngine.Mesh CreateFullscreenMesh();
                    /*0x140b400*/ DeferredLights(UnityEngine.Rendering.Universal.Internal.DeferredLights.InitParams initParams, bool useNativeRenderPass);
                    /*0x388e90*/ int get_GBufferAlbedoIndex();
                    /*0x6bba80*/ int get_GBufferSpecularMetallicIndex();
                    /*0x6bba90*/ int get_GBufferNormalSmoothnessIndex();
                    /*0x408450*/ int get_GBufferLightingIndex();
                    /*0x140b8b0*/ int get_GbufferDepthIndex();
                    /*0x140b6f0*/ int get_GBufferRenderingLayers();
                    /*0x140b770*/ int get_GBufferShadowMask();
                    /*0x140b810*/ int get_GBufferSliceCount();
                    /*0x1406750*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGBufferFormat(int index);
                    /*0x140b9b0*/ bool get_UseShadowMask();
                    /*0x140b940*/ bool get_UseRenderingLayers();
                    /*0x417e30*/ UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize get_RenderingLayerMaskSize();
                    /*0xdcd9c0*/ void set_RenderingLayerMaskSize(UnityEngine.Rendering.Universal.RenderingLayerUtils.MaskSize value);
                    /*0x8b9820*/ bool get_UseDecalLayers();
                    /*0xe29380*/ void set_UseDecalLayers(bool value);
                    /*0x140b8e0*/ bool get_UseLightLayers();
                    /*0xe29370*/ bool get_UseRenderPass();
                    /*0xe29390*/ void set_UseRenderPass(bool value);
                    /*0x1119e40*/ bool get_HasDepthPrepass();
                    /*0x140b9d0*/ void set_HasDepthPrepass(bool value);
                    /*0x140b8d0*/ bool get_HasNormalPrepass();
                    /*0x140b9e0*/ void set_HasNormalPrepass(bool value);
                    /*0xdd36a0*/ bool get_HasRenderingLayerPrepass();
                    /*0xdd5230*/ void set_HasRenderingLayerPrepass(bool value);
                    /*0x10a65f0*/ bool get_IsOverlay();
                    /*0x10a6600*/ void set_IsOverlay(bool value);
                    /*0x140b6e0*/ bool get_AccurateGbufferNormals();
                    /*0x140b9c0*/ void set_AccurateGbufferNormals(bool value);
                    /*0xc70b00*/ UnityEngine.Rendering.Universal.MixedLightingSetup get_MixedLightingSetup();
                    /*0xc70b50*/ void set_MixedLightingSetup(UnityEngine.Rendering.Universal.MixedLightingSetup value);
                    /*0x796120*/ bool get_UseJobSystem();
                    /*0x7963b0*/ void set_UseJobSystem(bool value);
                    /*0x3e3ad0*/ int get_RenderWidth();
                    /*0xc70b30*/ void set_RenderWidth(int value);
                    /*0x3e3ae0*/ int get_RenderHeight();
                    /*0xc6dab0*/ void set_RenderHeight(int value);
                    /*0x997630*/ UnityEngine.Rendering.RTHandle[] get_GbufferAttachments();
                    /*0x997640*/ void set_GbufferAttachments(UnityEngine.Rendering.RTHandle[] value);
                    /*0xb61870*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] get_GbufferTextureHandles();
                    /*0xcf6cd0*/ void set_GbufferTextureHandles(UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] value);
                    /*0x4e40d0*/ UnityEngine.Rendering.RTHandle[] get_DeferredInputAttachments();
                    /*0x4e4360*/ void set_DeferredInputAttachments(UnityEngine.Rendering.RTHandle[] value);
                    /*0x4e40e0*/ bool[] get_DeferredInputIsTransient();
                    /*0x4e4370*/ void set_DeferredInputIsTransient(bool[] value);
                    /*0xb61940*/ UnityEngine.Rendering.RTHandle get_DepthAttachment();
                    /*0xb61a20*/ void set_DepthAttachment(UnityEngine.Rendering.RTHandle value);
                    /*0xe643b0*/ UnityEngine.Rendering.RTHandle get_DepthCopyTexture();
                    /*0xe643c0*/ void set_DepthCopyTexture(UnityEngine.Rendering.RTHandle value);
                    /*0x8af030*/ UnityEngine.Experimental.Rendering.GraphicsFormat[] get_GbufferFormats();
                    /*0xe69480*/ void set_GbufferFormats(UnityEngine.Experimental.Rendering.GraphicsFormat[] value);
                    /*0xd184b0*/ UnityEngine.Rendering.RTHandle get_DepthAttachmentHandle();
                    /*0xe49c60*/ void set_DepthAttachmentHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x1409f70*/ void SetupLights(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1409d30*/ void ResolveMixedLightingMode(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1406230*/ void DisableFramebufferFetchInput();
                    /*0x1407dd0*/ void ReleaseGbufferResources();
                    /*0x1407bc0*/ void ReAllocateGBufferIfNeeded(UnityEngine.RenderTextureDescriptor gbufferSlice, int gbufferIndex);
                    /*0x1404f30*/ void CreateGbufferResources();
                    /*0x140ab00*/ void UpdateDeferredInputAttachments();
                    /*0x1407210*/ bool IsRuntimeSupportedThisFrame();
                    /*0x140a850*/ void Setup(ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass, bool hasDepthPrepass, bool hasNormalPrepass, bool hasRenderingLayerPrepass, UnityEngine.Rendering.RTHandle depthCopyTexture, UnityEngine.Rendering.RTHandle depthAttachment, UnityEngine.Rendering.RTHandle colorAttachment);
                    /*0x9c7a70*/ void Setup(UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass additionalLightsShadowCasterPass);
                    /*0x14072a0*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x1404be0*/ void ClearStencilPartial(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x1406240*/ void ExecuteDeferredPass(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x140a840*/ void SetupShaderLightConstants(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x140a4e0*/ void SetupMainLightConstants(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightData lightData);
                    /*0x14068e0*/ UnityEngine.Matrix4x4[] GetScreenToWorldMatrix(UnityEngine.Rendering.Universal.CameraData cameraData);
                    /*0x140a720*/ void SetupMatrixConstants(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1407850*/ void PrecomputeLights(ref Unity.Collections.NativeArray<ushort> stencilVisLights, ref Unity.Collections.NativeArray<ushort> stencilVisLightOffsets, ref Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, bool hasAdditionalLights, UnityEngine.Matrix4x4 view, bool isOrthographic, float zNear);
                    /*0x1406cc0*/ bool HasStencilLightsOfType(UnityEngine.LightType type);
                    /*0x14088a0*/ void RenderStencilLights(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1409ec0*/ void SetAdditionalLightsShadowsKeyword(ref UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, bool hasDeferredShadows);
                    /*0x1408200*/ void RenderStencilDirectionalLights(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights, int mainLightIndex);
                    /*0x1408b80*/ void RenderStencilPointLights(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights);
                    /*0x14093c0*/ void RenderStencilSpotLights(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData, Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> visibleLights);
                    /*0x14080a0*/ void RenderSSAOBeforeShading(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1407e90*/ void RenderFog(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1406d30*/ void InitStencilDeferredMaterial();

                    class ShaderConstants
                    {
                        static /*0x0*/ int _LitStencilRef;
                        static /*0x4*/ int _LitStencilReadMask;
                        static /*0x8*/ int _LitStencilWriteMask;
                        static /*0xc*/ int _SimpleLitStencilRef;
                        static /*0x10*/ int _SimpleLitStencilReadMask;
                        static /*0x14*/ int _SimpleLitStencilWriteMask;
                        static /*0x18*/ int _StencilRef;
                        static /*0x1c*/ int _StencilReadMask;
                        static /*0x20*/ int _StencilWriteMask;
                        static /*0x24*/ int _LitPunctualStencilRef;
                        static /*0x28*/ int _LitPunctualStencilReadMask;
                        static /*0x2c*/ int _LitPunctualStencilWriteMask;
                        static /*0x30*/ int _SimpleLitPunctualStencilRef;
                        static /*0x34*/ int _SimpleLitPunctualStencilReadMask;
                        static /*0x38*/ int _SimpleLitPunctualStencilWriteMask;
                        static /*0x3c*/ int _LitDirStencilRef;
                        static /*0x40*/ int _LitDirStencilReadMask;
                        static /*0x44*/ int _LitDirStencilWriteMask;
                        static /*0x48*/ int _SimpleLitDirStencilRef;
                        static /*0x4c*/ int _SimpleLitDirStencilReadMask;
                        static /*0x50*/ int _SimpleLitDirStencilWriteMask;
                        static /*0x54*/ int _ClearStencilRef;
                        static /*0x58*/ int _ClearStencilReadMask;
                        static /*0x5c*/ int _ClearStencilWriteMask;
                        static /*0x60*/ int _ScreenToWorld;
                        static /*0x64*/ int _MainLightPosition;
                        static /*0x68*/ int _MainLightColor;
                        static /*0x6c*/ int _MainLightLayerMask;
                        static /*0x70*/ int _SpotLightScale;
                        static /*0x74*/ int _SpotLightBias;
                        static /*0x78*/ int _SpotLightGuard;
                        static /*0x7c*/ int _LightPosWS;
                        static /*0x80*/ int _LightColor;
                        static /*0x84*/ int _LightAttenuation;
                        static /*0x88*/ int _LightOcclusionProbInfo;
                        static /*0x8c*/ int _LightDirection;
                        static /*0x90*/ int _LightFlags;
                        static /*0x94*/ int _ShadowLightIndex;
                        static /*0x98*/ int _LightLayerMask;
                        static /*0x9c*/ int _CookieLightIndex;

                        static /*0x1410170*/ ShaderConstants();
                    }

                    enum StencilDeferredPasses
                    {
                        StencilVolume = 0,
                        PunctualLit = 1,
                        PunctualSimpleLit = 2,
                        DirectionalLit = 3,
                        DirectionalSimpleLit = 4,
                        ClearStencilPartial = 5,
                        Fog = 6,
                        SSAOOnly = 7,
                    }

                    struct InitParams
                    {
                        /*0x10*/ UnityEngine.Material stencilDeferredMaterial;
                        /*0x18*/ UnityEngine.Rendering.Universal.LightCookieManager lightCookieManager;
                    }
                }

                class AdditionalLightsShadowCasterPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static int k_ShadowmapBufferBits = 16;
                    static int k_EmptyShadowMapDimensions = 1;
                    static string k_AdditionalLightShadowMapTextureName = "_AdditionalLightsShadowmapTexture";
                    static string k_EmptyAdditionalLightShadowMapTextureName = "_EmptyAdditionalLightShadowmapTexture";
                    static float LightTypeIdentifierInShadowParams_Spot = 0;
                    static float LightTypeIdentifierInShadowParams_Point = 1;
                    static int kMinimumPunctualLightHardShadowResolution = 8;
                    static int kMinimumPunctualLightSoftShadowResolution = 16;
                    static /*0x0*/ int m_AdditionalShadowsBufferId;
                    static /*0x4*/ int m_AdditionalShadowsIndicesId;
                    static /*0x8*/ UnityEngine.Vector4 c_DefaultShadowParams;
                    static /*0x18*/ int m_AdditionalLightsWorldToShadow_SSBO;
                    static /*0x1c*/ int m_AdditionalShadowParams_SSBO;
                    static /*0x20*/ UnityEngine.Vector4[] s_EmptyAdditionalLightIndexToShadowParams;
                    /*0xe0*/ bool m_UseStructuredBuffer;
                    /*0xe4*/ int m_AdditionalLightsShadowmapID;
                    /*0xe8*/ UnityEngine.Rendering.RTHandle m_AdditionalLightsShadowmapHandle;
                    /*0xf0*/ bool m_CreateEmptyShadowmap;
                    /*0xf8*/ UnityEngine.Rendering.RTHandle m_EmptyAdditionalLightShadowmapTexture;
                    /*0x100*/ float m_MaxShadowDistanceSq;
                    /*0x104*/ float m_CascadeBorder;
                    /*0x108*/ UnityEngine.Rendering.Universal.ShadowSliceData[] m_AdditionalLightsShadowSlices;
                    /*0x110*/ int[] m_VisibleLightIndexToAdditionalLightIndex;
                    /*0x118*/ int[] m_AdditionalLightIndexToVisibleLightIndex;
                    /*0x120*/ System.Collections.Generic.List<int> m_ShadowSliceToAdditionalLightIndex;
                    /*0x128*/ System.Collections.Generic.List<int> m_GlobalShadowSliceIndexToPerLightShadowSliceIndex;
                    /*0x130*/ UnityEngine.Vector4[] m_AdditionalLightIndexToShadowParams;
                    /*0x138*/ UnityEngine.Matrix4x4[] m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix;
                    /*0x140*/ System.Collections.Generic.List<UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.ShadowResolutionRequest> m_ShadowResolutionRequests;
                    /*0x148*/ float[] m_VisibleLightIndexToCameraSquareDistance;
                    /*0x150*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.ShadowResolutionRequest[] m_SortedShadowResolutionRequests;
                    /*0x158*/ int[] m_VisibleLightIndexToSortedShadowResolutionRequestsFirstSliceIndex;
                    /*0x160*/ System.Collections.Generic.List<UnityEngine.RectInt> m_UnusedAtlasSquareAreas;
                    /*0x168*/ int renderTargetWidth;
                    /*0x16c*/ int renderTargetHeight;
                    /*0x170*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSetupSampler;
                    /*0x178*/ System.Collections.Generic.Dictionary<int, ulong> m_ShadowRequestsHashes;

                    static /*0x1400bc0*/ AdditionalLightsShadowCasterPass();
                    static /*0x13fc5d0*/ float CalcGuardAngle(float frustumAngleInDegrees, float guardBandSizeInTexels, float sliceResolutionInTexels);
                    static /*0x13fcbb0*/ float GetPointLightShadowFrustumFovBiasInDegrees(int shadowSliceResolution, bool shadowFiltering);
                    static /*0x13fe680*/ void SetEmptyAdditionalLightShadowParams(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Vector4[] lightIndexToShadowParams);
                    /*0x1400c30*/ AdditionalLightsShadowCasterPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                    /*0x1364af0*/ void Dispose();
                    /*0x13fcca0*/ int GetPunctualLightShadowSlicesCount(ref UnityEngine.LightType lightType);
                    /*0x13fd3b0*/ int MinimalPunctualLightShadowResolution(bool softShadow);
                    /*0x13fced0*/ void InsertionSort(UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.ShadowResolutionRequest[] array, int startIndex, int lastIndex);
                    /*0x13fca20*/ int EstimateScaleFactorNeededToFitAllShadowsInAtlas(ref UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.ShadowResolutionRequest[] shadowResolutionRequests, int endIndex, int atlasWidth);
                    /*0x13fc1f0*/ void AtlasLayout(int atlasSize, int totalShadowSlicesCount, int estimatedScaleFactor);
                    /*0x13fe630*/ ulong ResolutionLog2ForHash(int resolution);
                    /*0x13fc6c0*/ ulong ComputeShadowRequestHash(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x13fef20*/ bool Setup(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x13fedb0*/ bool SetupForEmptyRendering(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x13fc9c0*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x13fcab0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x13fccc0*/ int GetShadowLightIndexFromLightIndex(int visibleLightIndex);
                    /*0x13fc660*/ void Clear();
                    /*0x13fe7b0*/ void SetEmptyAdditionalShadowmapAtlas(ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x13fd3c0*/ void RenderAdditionalShadowmapAtlas(ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x13fe9a0*/ void SetupAdditionalLightsShadowReceiverConstants(UnityEngine.Rendering.CommandBuffer cmd, bool softShadows);
                    /*0x13fd2c0*/ bool IsValidShadowCastingLight(ref UnityEngine.Rendering.Universal.LightData lightData, int i);
                    /*0x13fdcf0*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x13fcd00*/ void InitPassData(ref UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData passData, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph);

                    class AdditionalShadowsConstantBuffer
                    {
                        static /*0x0*/ int _AdditionalLightsWorldToShadow;
                        static /*0x4*/ int _AdditionalShadowParams;
                        static /*0x8*/ int _AdditionalShadowOffset0;
                        static /*0xc*/ int _AdditionalShadowOffset1;
                        static /*0x10*/ int _AdditionalShadowFadeParams;
                        static /*0x14*/ int _AdditionalShadowmapSize;
                    }

                    struct ShadowResolutionRequest
                    {
                        /*0x10*/ int visibleLightIndex;
                        /*0x14*/ int perLightShadowSliceIndex;
                        /*0x18*/ int requestedResolution;
                        /*0x1c*/ bool softShadow;
                        /*0x1d*/ bool pointLightShadow;
                        /*0x20*/ int offsetX;
                        /*0x24*/ int offsetY;
                        /*0x28*/ int allocatedResolution;

                        /*0x1410ca0*/ ShadowResolutionRequest(int _visibleLightIndex, int _perLightShadowSliceIndex, int _requestedResolution, bool _softShadow, bool _pointLightShadow);
                    }

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass pass;
                        /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph;
                        /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle shadowmapTexture;
                        /*0x28*/ UnityEngine.Rendering.Universal.RenderingData renderingData;
                        /*0x2e0*/ int shadowmapID;
                        /*0x2e4*/ bool emptyShadowmap;

                        /*0x32f970*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.<> <>9;
                        static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData> <>9__62_0;
                        static /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData> <>9__62_1;

                        static /*0x1410ee0*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x1410d70*/ void <Render>b__62_0(UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                        /*0x1410dc0*/ void <Render>b__62_1(UnityEngine.Rendering.Universal.Internal.AdditionalLightsShadowCasterPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    }
                }

                class ForwardLights
                {
                    static string k_SetupLightConstants = "Setup Light Constants";
                    static /*0x0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                    static /*0x8*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerFPSetup;
                    static /*0x10*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerFPComplete;
                    static /*0x18*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSamplerFPUpload;
                    /*0x10*/ int m_AdditionalLightsBufferId;
                    /*0x14*/ int m_AdditionalLightsIndicesId;
                    /*0x18*/ UnityEngine.Rendering.Universal.MixedLightingSetup m_MixedLightingSetup;
                    /*0x20*/ UnityEngine.Vector4[] m_AdditionalLightPositions;
                    /*0x28*/ UnityEngine.Vector4[] m_AdditionalLightColors;
                    /*0x30*/ UnityEngine.Vector4[] m_AdditionalLightAttenuations;
                    /*0x38*/ UnityEngine.Vector4[] m_AdditionalLightSpotDirections;
                    /*0x40*/ UnityEngine.Vector4[] m_AdditionalLightOcclusionProbeChannels;
                    /*0x48*/ float[] m_AdditionalLightsLayerMasks;
                    /*0x50*/ bool m_UseStructuredBuffer;
                    /*0x51*/ bool m_UseForwardPlus;
                    /*0x54*/ int m_DirectionalLightCount;
                    /*0x58*/ int m_ActualTileWidth;
                    /*0x5c*/ Unity.Mathematics.int2 m_TileResolution;
                    /*0x68*/ Unity.Jobs.JobHandle m_CullingHandle;
                    /*0x78*/ Unity.Collections.NativeArray<uint> m_ZBins;
                    /*0x88*/ UnityEngine.GraphicsBuffer m_ZBinsBuffer;
                    /*0x90*/ Unity.Collections.NativeArray<uint> m_TileMasks;
                    /*0xa0*/ UnityEngine.GraphicsBuffer m_TileMasksBuffer;
                    /*0xa8*/ UnityEngine.Rendering.Universal.LightCookieManager m_LightCookieManager;
                    /*0xb0*/ UnityEngine.Rendering.Universal.ReflectionProbeManager m_ReflectionProbeManager;
                    /*0x130*/ int m_WordsPerTile;
                    /*0x134*/ float m_ZBinScale;
                    /*0x138*/ float m_ZBinOffset;
                    /*0x13c*/ int m_LightCount;
                    /*0x140*/ int m_BinCount;

                    static /*0x140f310*/ ForwardLights();
                    static /*0x140b9f0*/ int AlignByteCount(int count, int align);
                    static /*0x140f210*/ bool <PreSetup>g__IsProbeGreater|40_0(UnityEngine.Rendering.VisibleReflectionProbe probe, UnityEngine.Rendering.VisibleReflectionProbe otherProbe);
                    /*0x140f4b0*/ ForwardLights();
                    /*0x140f600*/ ForwardLights(UnityEngine.Rendering.Universal.Internal.ForwardLights.InitParams initParams);
                    /*0x140bb10*/ void CreateForwardPlusBuffers();
                    /*0x140fa60*/ UnityEngine.Rendering.Universal.ReflectionProbeManager get_reflectionProbeManager();
                    /*0x140bd10*/ void GetViewParams(UnityEngine.Camera camera, Unity.Mathematics.float4x4 viewToClip, ref float viewPlaneBot, ref float viewPlaneTop, ref Unity.Mathematics.float4 viewToViewportScaleBias);
                    /*0x140c100*/ void PreSetup(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x140e850*/ void Setup(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x140ba10*/ void Cleanup();
                    /*0x140bef0*/ void InitializeLightConstants(Unity.Collections.NativeArray<UnityEngine.Rendering.VisibleLight> lights, int lightIndex, ref UnityEngine.Vector4 lightPos, ref UnityEngine.Vector4 lightColor, ref UnityEngine.Vector4 lightAttenuation, ref UnityEngine.Vector4 lightSpotDir, ref UnityEngine.Vector4 lightOcclusionProbeChannel, ref uint lightLayerMask, ref bool isSubtractive);
                    /*0x140e800*/ void SetupShaderLightConstants(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x140e350*/ void SetupMainLightConstants(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.LightData lightData);
                    /*0x140dd10*/ void SetupAdditionalLightConstants(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x140e640*/ int SetupPerObjectLightIndices(UnityEngine.Rendering.CullingResults cullResults, ref UnityEngine.Rendering.Universal.LightData lightData);

                    class LightConstantBuffer
                    {
                        static /*0x0*/ int _MainLightPosition;
                        static /*0x4*/ int _MainLightColor;
                        static /*0x8*/ int _MainLightOcclusionProbesChannel;
                        static /*0xc*/ int _MainLightLayerMask;
                        static /*0x10*/ int _AdditionalLightsCount;
                        static /*0x14*/ int _AdditionalLightsPosition;
                        static /*0x18*/ int _AdditionalLightsColor;
                        static /*0x1c*/ int _AdditionalLightsAttenuation;
                        static /*0x20*/ int _AdditionalLightsSpotDir;
                        static /*0x24*/ int _AdditionalLightOcclusionProbeChannel;
                        static /*0x28*/ int _AdditionalLightsLayerMasks;
                    }

                    struct InitParams
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.LightCookieManager lightCookieManager;
                        /*0x18*/ bool forwardPlus;

                        static /*0x140fac0*/ UnityEngine.Rendering.Universal.Internal.ForwardLights.InitParams Create();
                    }
                }

                class NormalReconstruction
                {
                    static /*0x0*/ int s_NormalReconstructionMatrixID;
                    static /*0x8*/ UnityEngine.Matrix4x4[] s_NormalReconstructionMatrix;

                    static /*0x14100d0*/ NormalReconstruction();
                    static /*0x140fbf0*/ void SetupProperties(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData);
                }

                class ColorGradingLutPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xe0*/ UnityEngine.Material m_LutBuilderLdr;
                    /*0xe8*/ UnityEngine.Material m_LutBuilderHdr;
                    /*0xf0*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_HdrLutFormat;
                    /*0xf4*/ UnityEngine.Experimental.Rendering.GraphicsFormat m_LdrLutFormat;
                    /*0xf8*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.PassData m_PassData;
                    /*0x100*/ UnityEngine.Rendering.RTHandle m_InternalLut;
                    /*0x108*/ bool m_AllowColorGradingACESHDR;

                    static /*0x1401470*/ void ExecutePass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.PassData passData, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Rendering.RTHandle internalLutTarget);
                    static /*0x1403100*/ UnityEngine.Material <.ctor>g__Load|7_0(UnityEngine.Shader shader);
                    /*0x14031c0*/ ColorGradingLutPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.PostProcessData data);
                    /*0x14030e0*/ void Setup(ref UnityEngine.Rendering.RTHandle internalLut);
                    /*0x14013d0*/ void ConfigureDescriptor(ref UnityEngine.Rendering.Universal.PostProcessingData postProcessingData, ref UnityEngine.RenderTextureDescriptor descriptor, ref UnityEngine.FilterMode filterMode);
                    /*0x1402a50*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1402bf0*/ void Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle internalColorLut, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1401360*/ void Cleanup();

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.RenderingData renderingData;
                        /*0x2c8*/ UnityEngine.Material lutBuilderLdr;
                        /*0x2d0*/ UnityEngine.Material lutBuilderHdr;
                        /*0x2d8*/ bool allowColorGradingACESHDR;
                        /*0x2dc*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle internalLut;

                        /*0x32f970*/ PassData();
                    }

                    class ShaderConstants
                    {
                        static /*0x0*/ int _Lut_Params;
                        static /*0x4*/ int _ColorBalance;
                        static /*0x8*/ int _ColorFilter;
                        static /*0xc*/ int _ChannelMixerRed;
                        static /*0x10*/ int _ChannelMixerGreen;
                        static /*0x14*/ int _ChannelMixerBlue;
                        static /*0x18*/ int _HueSatCon;
                        static /*0x1c*/ int _Lift;
                        static /*0x20*/ int _Gamma;
                        static /*0x24*/ int _Gain;
                        static /*0x28*/ int _Shadows;
                        static /*0x2c*/ int _Midtones;
                        static /*0x30*/ int _Highlights;
                        static /*0x34*/ int _ShaHiLimits;
                        static /*0x38*/ int _SplitShadows;
                        static /*0x3c*/ int _SplitHighlights;
                        static /*0x40*/ int _CurveMaster;
                        static /*0x44*/ int _CurveRed;
                        static /*0x48*/ int _CurveGreen;
                        static /*0x4c*/ int _CurveBlue;
                        static /*0x50*/ int _CurveHueVsHue;
                        static /*0x54*/ int _CurveHueVsSat;
                        static /*0x58*/ int _CurveLumVsSat;
                        static /*0x5c*/ int _CurveSatVsSat;

                        static /*0x1410870*/ ShaderConstants();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.<> <>9;
                        static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.PassData> <>9__13_0;

                        static /*0x1410f50*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x1410cd0*/ void <Render>b__13_0(UnityEngine.Rendering.Universal.Internal.ColorGradingLutPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    }
                }

                class CopyColorPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xe0*/ int m_SampleOffsetShaderHandle;
                    /*0xe8*/ UnityEngine.Material m_SamplingMaterial;
                    /*0xf0*/ UnityEngine.Rendering.Universal.Downsampling m_DownsamplingMethod;
                    /*0xf8*/ UnityEngine.Material m_CopyColorMaterial;
                    /*0x100*/ UnityEngine.Rendering.RTHandle <source>k__BackingField;
                    /*0x108*/ UnityEngine.Rendering.RTHandle <destination>k__BackingField;
                    /*0x110*/ int <destinationID>k__BackingField;
                    /*0x118*/ UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData m_PassData;

                    static /*0x1403500*/ void ConfigureDescriptor(UnityEngine.Rendering.Universal.Downsampling downsamplingMethod, ref UnityEngine.RenderTextureDescriptor descriptor, ref UnityEngine.FilterMode filterMode);
                    static /*0x1403590*/ void ExecutePass(UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData passData, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, ref UnityEngine.Rendering.CommandBuffer cmd, bool useDrawProceduralBlit, bool disableFoveatedRenderingForPass);
                    /*0x1404960*/ CopyColorPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material samplingMaterial, UnityEngine.Material copyColorMaterial);
                    /*0x136fc90*/ UnityEngine.Rendering.RTHandle get_source();
                    /*0x136fd50*/ void set_source(UnityEngine.Rendering.RTHandle value);
                    /*0x136fcb0*/ UnityEngine.Rendering.RTHandle get_destination();
                    /*0x136fd70*/ void set_destination(UnityEngine.Rendering.RTHandle value);
                    /*0x1404ac0*/ int get_destinationID();
                    /*0x1404ad0*/ void set_destinationID(int value);
                    /*0x1404830*/ void Setup(UnityEngine.Rendering.RenderTargetIdentifier source, UnityEngine.Rendering.Universal.RenderTargetHandle destination, UnityEngine.Rendering.Universal.Downsampling downsampling);
                    /*0x14047d0*/ void Setup(UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination, UnityEngine.Rendering.Universal.Downsampling downsampling);
                    /*0x1403da0*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x14039e0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1403f90*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle source, UnityEngine.Rendering.Universal.Downsampling downsampling, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1403c80*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle source;
                        /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle destination;
                        /*0x20*/ bool useProceduralBlit;
                        /*0x21*/ bool disableFoveatedRenderingForPass;
                        /*0x28*/ UnityEngine.Rendering.CommandBuffer cmd;
                        /*0x30*/ UnityEngine.Material samplingMaterial;
                        /*0x38*/ UnityEngine.Material copyColorMaterial;
                        /*0x40*/ UnityEngine.Rendering.Universal.Downsampling downsamplingMethod;
                        /*0x44*/ UnityEngine.Rendering.ClearFlag clearFlag;
                        /*0x48*/ UnityEngine.Color clearColor;
                        /*0x58*/ int sampleOffsetShaderHandle;

                        /*0x32f970*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.CopyColorPass.<> <>9;
                        static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData> <>9__25_0;
                        static /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData> <>9__25_1;

                        static /*0x1426510*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x1425de0*/ void <Render>b__25_0(UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                        /*0x1425e80*/ void <Render>b__25_1(UnityEngine.Rendering.Universal.Internal.CopyColorPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    }
                }

                class CopyDepthPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xe0*/ UnityEngine.Rendering.RTHandle <source>k__BackingField;
                    /*0xe8*/ UnityEngine.Rendering.RTHandle <destination>k__BackingField;
                    /*0xf0*/ int <MssaSamples>k__BackingField;
                    /*0xf4*/ bool <CopyToDepth>k__BackingField;
                    /*0xf8*/ UnityEngine.Material m_CopyDepthMaterial;
                    /*0x100*/ bool m_CopyResolvedDepth;
                    /*0x101*/ bool m_ShouldClear;
                    /*0x108*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData m_PassData;

                    static /*0x1410fc0*/ void ExecutePass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData passData, ref UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.CameraData cameraData, UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination);
                    /*0x1412560*/ CopyDepthPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material copyDepthMaterial, bool shouldClear, bool copyToDepth, bool copyResolvedDepth);
                    /*0x139ece0*/ UnityEngine.Rendering.RTHandle get_source();
                    /*0x14126d0*/ void set_source(UnityEngine.Rendering.RTHandle value);
                    /*0x10d00b0*/ UnityEngine.Rendering.RTHandle get_destination();
                    /*0x136fd30*/ void set_destination(UnityEngine.Rendering.RTHandle value);
                    /*0x10e8be0*/ int get_MssaSamples();
                    /*0x14126c0*/ void set_MssaSamples(int value);
                    /*0x14126a0*/ bool get_CopyToDepth();
                    /*0x14126b0*/ void set_CopyToDepth(bool value);
                    /*0x1412510*/ void Setup(UnityEngine.Rendering.RTHandle source, UnityEngine.Rendering.RTHandle destination);
                    /*0x1411ac0*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1411860*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1411a00*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x1411c00*/ void Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle destination, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle source, ref UnityEngine.Rendering.Universal.RenderingData renderingData);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle source;
                        /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle destination;
                        /*0x20*/ UnityEngine.Rendering.CommandBuffer cmd;
                        /*0x28*/ UnityEngine.Rendering.Universal.CameraData cameraData;
                        /*0x238*/ UnityEngine.Material copyDepthMaterial;
                        /*0x240*/ int msaaSamples;
                        /*0x244*/ bool copyResolvedDepth;
                        /*0x245*/ bool copyToDepth;

                        /*0x32f970*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.CopyDepthPass.<> <>9;
                        static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData> <>9__27_0;
                        static /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData> <>9__27_1;
                        static /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData> <>9__27_2;

                        static /*0x14264a0*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x1425f40*/ void <Render>b__27_0(UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                        /*0x1426020*/ void <Render>b__27_1(UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                        /*0x14260d0*/ void <Render>b__27_2(UnityEngine.Rendering.Universal.Internal.CopyDepthPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    }
                }

                class DeferredPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xe0*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;

                    /*0x1412c10*/ DeferredPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights);
                    /*0x14126f0*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescripor);
                    /*0x1412790*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x14127f0*/ void Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle color, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle depth, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] gbuffer, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x14127c0*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle color;
                        /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle depth;
                        /*0x20*/ UnityEngine.Rendering.Universal.RenderingData renderingData;
                        /*0x2d8*/ UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights;

                        /*0x32f970*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DeferredPass.<> <>9;
                        static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.DeferredPass.PassData> <>9__5_0;

                        static /*0x14266d0*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x1426380*/ void <Render>b__5_0(UnityEngine.Rendering.Universal.Internal.DeferredPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    }
                }

                class DepthNormalOnlyPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> k_DepthNormals;
                    static /*0x8*/ UnityEngine.Rendering.RTHandle[] k_ColorAttachment1;
                    static /*0x10*/ UnityEngine.Rendering.RTHandle[] k_ColorAttachment2;
                    /*0xe0*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> <shaderTagIds>k__BackingField;
                    /*0xe8*/ UnityEngine.Rendering.RTHandle <depthHandle>k__BackingField;
                    /*0xf0*/ UnityEngine.Rendering.RTHandle <normalHandle>k__BackingField;
                    /*0xf8*/ UnityEngine.Rendering.RTHandle <renderingLayersHandle>k__BackingField;
                    /*0x100*/ bool <enableRenderingLayers>k__BackingField;
                    /*0x104*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                    /*0x120*/ UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.PassData m_PassData;

                    static /*0x1413d50*/ DepthNormalOnlyPass();
                    static /*0x1413160*/ UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat();
                    static /*0x1412ce0*/ void ExecutePass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.PassData passData, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1413f80*/ DepthNormalOnlyPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask);
                    /*0x139ece0*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> get_shaderTagIds();
                    /*0x14126d0*/ void set_shaderTagIds(System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> value);
                    /*0x10d00b0*/ UnityEngine.Rendering.RTHandle get_depthHandle();
                    /*0x136fd30*/ void set_depthHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x10d0110*/ UnityEngine.Rendering.RTHandle get_normalHandle();
                    /*0x139f000*/ void set_normalHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x136fc50*/ UnityEngine.Rendering.RTHandle get_renderingLayersHandle();
                    /*0x1414190*/ void set_renderingLayersHandle(UnityEngine.Rendering.RTHandle value);
                    /*0x1414170*/ bool get_enableRenderingLayers();
                    /*0x1414180*/ void set_enableRenderingLayers(bool value);
                    /*0x1413c80*/ void Setup(UnityEngine.Rendering.RTHandle depthHandle, UnityEngine.Rendering.RTHandle normalHandle);
                    /*0x1413cd0*/ void Setup(UnityEngine.Rendering.RTHandle depthHandle, UnityEngine.Rendering.RTHandle normalHandle, UnityEngine.Rendering.RTHandle decalLayerHandle);
                    /*0x1413310*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1413070*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1413200*/ void OnCameraCleanup(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x1413570*/ void Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraNormalsTexture, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture, ref UnityEngine.Rendering.Universal.RenderingData renderingData);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture;
                        /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraNormalsTexture;
                        /*0x20*/ UnityEngine.Rendering.Universal.RenderingData renderingData;
                        /*0x2d8*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> shaderTagIds;
                        /*0x2e0*/ UnityEngine.Rendering.FilteringSettings filteringSettings;
                        /*0x2f8*/ bool enableRenderingLayers;

                        /*0x32f970*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.<> <>9;
                        static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.PassData> <>9__34_0;

                        static /*0x1426430*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x1426300*/ void <Render>b__34_0(UnityEngine.Rendering.Universal.Internal.DepthNormalOnlyPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    }
                }

                class DepthOnlyPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ UnityEngine.Rendering.ShaderTagId k_ShaderTagId;
                    /*0xe0*/ UnityEngine.Rendering.RTHandle <destination>k__BackingField;
                    /*0xe8*/ UnityEngine.Experimental.Rendering.GraphicsFormat depthStencilFormat;
                    /*0xec*/ UnityEngine.Rendering.ShaderTagId <shaderTagId>k__BackingField;
                    /*0xf0*/ UnityEngine.Rendering.Universal.Internal.DepthOnlyPass.PassData m_PassData;
                    /*0xf8*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;

                    static /*0x1414b00*/ DepthOnlyPass();
                    static /*0x14141b0*/ void ExecutePass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.Internal.DepthOnlyPass.PassData passData, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1414b70*/ DepthOnlyPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask);
                    /*0x139ece0*/ UnityEngine.Rendering.RTHandle get_destination();
                    /*0x14126d0*/ void set_destination(UnityEngine.Rendering.RTHandle value);
                    /*0x1414d60*/ UnityEngine.Rendering.ShaderTagId get_shaderTagId();
                    /*0x1414d70*/ void set_shaderTagId(UnityEngine.Rendering.ShaderTagId value);
                    /*0x1414ac0*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor, UnityEngine.Rendering.RTHandle depthAttachmentHandle);
                    /*0x14144f0*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1414430*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x14145b0*/ void Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture, ref UnityEngine.Rendering.Universal.RenderingData renderingData);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraDepthTexture;
                        /*0x18*/ UnityEngine.Rendering.Universal.RenderingData renderingData;
                        /*0x2d0*/ UnityEngine.Rendering.ShaderTagId shaderTagId;
                        /*0x2d4*/ UnityEngine.Rendering.FilteringSettings filteringSettings;

                        /*0x32f970*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DepthOnlyPass.<> <>9;
                        static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.DepthOnlyPass.PassData> <>9__18_0;

                        static /*0x1426660*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x14258b0*/ void <Render>b__18_0(UnityEngine.Rendering.Universal.Internal.DepthOnlyPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    }
                }

                class DrawObjectsWithRenderingLayersPass : UnityEngine.Rendering.Universal.Internal.DrawObjectsPass
                {
                    /*0x198*/ UnityEngine.Rendering.RTHandle[] m_ColorTargetIndentifiers;
                    /*0x1a0*/ UnityEngine.Rendering.RTHandle m_DepthTargetIndentifiers;

                    /*0x1416950*/ DrawObjectsWithRenderingLayersPass(UnityEngine.Rendering.Universal.URPProfileId profilerTag, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x1416710*/ void Setup(UnityEngine.Rendering.RTHandle colorAttachment, UnityEngine.Rendering.RTHandle renderingLayersTexture, UnityEngine.Rendering.RTHandle depthAttachment);
                    /*0x1416690*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x14166b0*/ void OnExecute(UnityEngine.Rendering.CommandBuffer cmd);
                }

                class DrawObjectsPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ int s_DrawObjectPassDataPropID;
                    /*0xe0*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                    /*0xf8*/ UnityEngine.Rendering.RenderStateBlock m_RenderStateBlock;
                    /*0x168*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                    /*0x170*/ string m_ProfilerTag;
                    /*0x178*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                    /*0x180*/ bool m_IsOpaque;
                    /*0x181*/ bool m_IsActiveTargetBackBuffer;
                    /*0x182*/ bool m_ShouldTransparentsReceiveShadows;
                    /*0x188*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData m_PassData;
                    /*0x190*/ bool m_UseDepthPriming;

                    static /*0x1415e60*/ DrawObjectsPass();
                    static /*0x1414d80*/ void CameraSetup(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData data, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    static /*0x1414e60*/ void ExecutePass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData data, ref UnityEngine.Rendering.Universal.RenderingData renderingData, bool yFlip);
                    /*0x1416050*/ DrawObjectsPass(string profilerTag, UnityEngine.Rendering.ShaderTagId[] shaderTagIds, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x1415eb0*/ DrawObjectsPass(string profilerTag, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x1416450*/ DrawObjectsPass(UnityEngine.Rendering.Universal.URPProfileId profileId, bool opaque, UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference);
                    /*0x1415520*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x14158a0*/ void Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle colorTarget, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle depthTarget, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle mainShadowsTexture, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle additionalShadowsTexture, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x32d010*/ void OnExecute(UnityEngine.Rendering.CommandBuffer cmd);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle m_Albedo;
                        /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle m_Depth;
                        /*0x20*/ UnityEngine.Rendering.Universal.RenderingData m_RenderingData;
                        /*0x2d8*/ bool m_IsOpaque;
                        /*0x2dc*/ UnityEngine.Rendering.RenderStateBlock m_RenderStateBlock;
                        /*0x348*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                        /*0x360*/ System.Collections.Generic.List<UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;
                        /*0x368*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                        /*0x370*/ bool m_ShouldTransparentsReceiveShadows;
                        /*0x371*/ bool m_IsActiveTargetBackBuffer;
                        /*0x378*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass pass;

                        /*0x32f970*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.<> <>9;
                        static /*0x8*/ UnityEngine.Rendering.Universal.DebugHandler.DrawFunction <>9__16_0;
                        static /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData> <>9__18_0;

                        static /*0x1426580*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x1425410*/ void <ExecutePass>b__16_0(UnityEngine.Rendering.ScriptableRenderContext ctx, ref UnityEngine.Rendering.Universal.RenderingData data, ref UnityEngine.Rendering.DrawingSettings ds, ref UnityEngine.Rendering.FilteringSettings fs, ref UnityEngine.Rendering.RenderStateBlock rsb);
                        /*0x1425930*/ void <Render>b__18_0(UnityEngine.Rendering.Universal.Internal.DrawObjectsPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    }
                }

                class FinalBlitPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    /*0xe0*/ UnityEngine.Rendering.RTHandle m_Source;
                    /*0xe8*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData m_PassData;
                    /*0xf0*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass.BlitMaterialData[] m_BlitMaterialData;

                    static /*0x1417d20*/ void SetupHDROutput(UnityEngine.ColorGamut hdrDisplayColorGamut, UnityEngine.Material material, UnityEngine.Rendering.HDROutputUtils.Operation hdrOperation, UnityEngine.Vector4 hdrOutputParameters);
                    static /*0x1416c00*/ void ExecutePass(ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.Universal.Internal.FinalBlitPass.BlitMaterialData blitMaterialData, UnityEngine.Rendering.RTHandle cameraTarget, UnityEngine.Rendering.RTHandle source);
                    /*0x1417ff0*/ FinalBlitPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Material blitMaterial, UnityEngine.Material blitHDRMaterial);
                    /*0x32d010*/ void Dispose();
                    /*0x1417dd0*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor, UnityEngine.Rendering.Universal.RenderTargetHandle colorHandle);
                    /*0x1417fd0*/ void Setup(UnityEngine.RenderTextureDescriptor baseDescriptor, UnityEngine.Rendering.RTHandle colorHandle);
                    /*0x1417820*/ void OnCameraSetup(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1416db0*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1417660*/ void InitPassData(ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData passData, UnityEngine.Rendering.Universal.Internal.FinalBlitPass.BlitType blitType);
                    /*0x14178d0*/ void Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, ref UnityEngine.Rendering.Universal.RenderingData renderingData, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle src, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle dest, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle overlayUITexture);

                    class BlitPassNames
                    {
                        static string NearestSampler = "NearestDebugDraw";
                        static string BilinearSampler = "BilinearDebugDraw";
                    }

                    enum BlitType
                    {
                        Core = 0,
                        HDR = 1,
                        Count = 2,
                    }

                    struct BlitMaterialData
                    {
                        /*0x10*/ UnityEngine.Material material;
                        /*0x18*/ int nearestSamplerPass;
                        /*0x1c*/ int bilinearSamplerPass;
                    }

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle source;
                        /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle destination;
                        /*0x20*/ int sourceID;
                        /*0x24*/ UnityEngine.Vector4 hdrOutputLuminanceParams;
                        /*0x34*/ bool requireSrgbConversion;
                        /*0x38*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass.BlitMaterialData blitMaterialData;
                        /*0x48*/ UnityEngine.Rendering.Universal.RenderingData renderingData;

                        /*0x32f970*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.FinalBlitPass.<> <>9;
                        static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData> <>9__16_0;

                        static /*0x1426740*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x14254b0*/ void <Render>b__16_0(UnityEngine.Rendering.Universal.Internal.FinalBlitPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    }
                }

                class GBufferPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static /*0x0*/ int s_CameraNormalsTextureID;
                    static /*0x4*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagLit;
                    static /*0x8*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagSimpleLit;
                    static /*0xc*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagUnlit;
                    static /*0x10*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagComplexLit;
                    static /*0x14*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagUniversalGBuffer;
                    static /*0x18*/ UnityEngine.Rendering.ShaderTagId s_ShaderTagUniversalMaterialType;
                    static /*0x20*/ UnityEngine.Rendering.ShaderTagId[] s_ShaderTagValues;
                    static /*0x28*/ UnityEngine.Rendering.RenderStateBlock[] s_RenderStateBlocks;
                    /*0xe0*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSampler;
                    /*0xe8*/ UnityEngine.Rendering.Universal.Internal.DeferredLights m_DeferredLights;
                    /*0xf0*/ UnityEngine.Rendering.FilteringSettings m_FilteringSettings;
                    /*0x108*/ UnityEngine.Rendering.RenderStateBlock m_RenderStateBlock;
                    /*0x178*/ UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData m_PassData;

                    static /*0x1419b80*/ GBufferPass();
                    static /*0x1418620*/ void ExecutePass(UnityEngine.Rendering.ScriptableRenderContext context, UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData data, ref UnityEngine.Rendering.Universal.RenderingData renderingData, bool useRenderGraph);
                    /*0x1419d30*/ GBufferPass(UnityEngine.Rendering.Universal.RenderPassEvent evt, UnityEngine.Rendering.RenderQueueRange renderQueueRange, UnityEngine.LayerMask layerMask, UnityEngine.Rendering.StencilState stencilState, int stencilReference, UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights);
                    /*0x14185f0*/ void Dispose();
                    /*0x1418240*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x1418a90*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x1418e30*/ void Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph renderGraph, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraColor, UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle cameraDepth, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Rendering.Universal.UniversalRenderer.RenderGraphFrameResources frameResources);

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle[] gbuffer;
                        /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle depth;
                        /*0x20*/ UnityEngine.Rendering.Universal.RenderingData renderingData;
                        /*0x2d8*/ UnityEngine.Rendering.Universal.Internal.DeferredLights deferredLights;
                        /*0x2e0*/ UnityEngine.Rendering.FilteringSettings filteringSettings;
                        /*0x2f8*/ UnityEngine.Rendering.DrawingSettings drawingSettings;

                        /*0x32f970*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.GBufferPass.<> <>9;
                        static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData> <>9__20_0;
                        static /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData> <>9__20_1;

                        static /*0x14265f0*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x1425bc0*/ void <Render>b__20_0(UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                        /*0x1425c40*/ void <Render>b__20_1(UnityEngine.Rendering.Universal.Internal.GBufferPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    }
                }

                class MainLightShadowCasterPass : UnityEngine.Rendering.Universal.ScriptableRenderPass
                {
                    static int k_MaxCascades = 4;
                    static int k_ShadowmapBufferBits = 16;
                    static int k_EmptyShadowMapDimensions = 1;
                    static string k_MainLightShadowMapTextureName = "_MainLightShadowmapTexture";
                    static string k_EmptyMainLightShadowMapTextureName = "_EmptyMainLightShadowmapTexture";
                    static /*0x0*/ UnityEngine.Vector4 s_EmptyShadowParams;
                    static /*0x10*/ UnityEngine.Vector4 s_EmptyShadowmapSize;
                    /*0xe0*/ float m_CascadeBorder;
                    /*0xe4*/ float m_MaxShadowDistanceSq;
                    /*0xe8*/ int m_ShadowCasterCascadesCount;
                    /*0xec*/ int m_MainLightShadowmapID;
                    /*0xf0*/ UnityEngine.Rendering.RTHandle m_MainLightShadowmapTexture;
                    /*0xf8*/ UnityEngine.Rendering.RTHandle m_EmptyMainLightShadowmapTexture;
                    /*0x100*/ UnityEngine.Matrix4x4[] m_MainLightShadowMatrices;
                    /*0x108*/ UnityEngine.Rendering.Universal.ShadowSliceData[] m_CascadeSlices;
                    /*0x110*/ UnityEngine.Vector4[] m_CascadeSplitDistances;
                    /*0x118*/ bool m_CreateEmptyShadowmap;
                    /*0x11c*/ int renderTargetWidth;
                    /*0x120*/ int renderTargetHeight;
                    /*0x128*/ UnityEngine.Rendering.ProfilingSampler m_ProfilingSetupSampler;

                    static /*0x141ce50*/ MainLightShadowCasterPass();
                    static /*0x141bfd0*/ void SetEmptyMainLightShadowParams(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x141cec0*/ MainLightShadowCasterPass(UnityEngine.Rendering.Universal.RenderPassEvent evt);
                    /*0x141aad0*/ void Dispose();
                    /*0x141c7e0*/ bool Setup(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x141c0b0*/ bool SetupForEmptyRendering(ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x141aa70*/ void Configure(UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.RenderTextureDescriptor cameraTextureDescriptor);
                    /*0x141ab10*/ void Execute(UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x141a8d0*/ void Clear();
                    /*0x141be40*/ void SetEmptyMainLightCascadeShadowmap(ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x141ad70*/ void RenderMainLightCascadeShadowmap(ref UnityEngine.Rendering.ScriptableRenderContext context, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x141c190*/ void SetupMainLightShadowReceiverConstants(UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.Rendering.VisibleLight shadowLight, ref UnityEngine.Rendering.Universal.ShadowData shadowData);
                    /*0x141b500*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle Render(UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph, ref UnityEngine.Rendering.Universal.RenderingData renderingData);
                    /*0x141aba0*/ void InitPassData(ref UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData passData, ref UnityEngine.Rendering.Universal.RenderingData renderingData, ref UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph);

                    class MainLightShadowConstantBuffer
                    {
                        static /*0x0*/ int _WorldToShadow;
                        static /*0x4*/ int _ShadowParams;
                        static /*0x8*/ int _CascadeShadowSplitSpheres0;
                        static /*0xc*/ int _CascadeShadowSplitSpheres1;
                        static /*0x10*/ int _CascadeShadowSplitSpheres2;
                        static /*0x14*/ int _CascadeShadowSplitSpheres3;
                        static /*0x18*/ int _CascadeShadowSplitSphereRadii;
                        static /*0x1c*/ int _ShadowOffset0;
                        static /*0x20*/ int _ShadowOffset1;
                        static /*0x24*/ int _ShadowmapSize;
                    }

                    class PassData
                    {
                        /*0x10*/ UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass pass;
                        /*0x18*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraph graph;
                        /*0x20*/ UnityEngine.Experimental.Rendering.RenderGraphModule.TextureHandle shadowmapTexture;
                        /*0x28*/ UnityEngine.Rendering.Universal.RenderingData renderingData;
                        /*0x2e0*/ int shadowmapID;
                        /*0x2e4*/ bool emptyShadowmap;

                        /*0x32f970*/ PassData();
                    }

                    class <>c
                    {
                        static /*0x0*/ UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.<> <>9;
                        static /*0x8*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData> <>9__33_0;
                        static /*0x10*/ UnityEngine.Experimental.Rendering.RenderGraphModule.RenderFunc<UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData> <>9__33_1;

                        static /*0x14263c0*/ <>c();
                        /*0x32f970*/ <>c();
                        /*0x1426190*/ void <Render>b__33_0(UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                        /*0x14261e0*/ void <Render>b__33_1(UnityEngine.Rendering.Universal.Internal.MainLightShadowCasterPass.PassData data, UnityEngine.Experimental.Rendering.RenderGraphModule.RenderGraphContext context);
                    }
                }

                class RenderTargetBufferSystem
                {
                    static /*0x0*/ bool m_AisBackBuffer;
                    static /*0x4*/ UnityEngine.RenderTextureDescriptor m_Desc;
                    /*0x10*/ UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer m_A;
                    /*0x30*/ UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer m_B;
                    /*0x50*/ UnityEngine.FilterMode m_FilterMode;
                    /*0x54*/ bool m_AllowMSAA;

                    static /*0x1420820*/ RenderTargetBufferSystem();
                    /*0x1420860*/ RenderTargetBufferSystem(string name);
                    /*0x1420900*/ ref UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer get_backBuffer();
                    /*0x1420970*/ ref UnityEngine.Rendering.Universal.Internal.RenderTargetBufferSystem.SwapBuffer get_frontBuffer();
                    /*0x141fe50*/ void Dispose();
                    /*0x1420280*/ UnityEngine.Rendering.RTHandle PeekBackBuffer();
                    /*0x141ff30*/ UnityEngine.Rendering.RTHandle GetBackBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x1420080*/ UnityEngine.Rendering.RTHandle GetFrontBuffer(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x14207c0*/ void Swap();
                    /*0x14203b0*/ void ReAllocate(UnityEngine.Rendering.CommandBuffer cmd);
                    /*0x141fde0*/ void Clear();
                    /*0x1420660*/ void SetCameraSettings(UnityEngine.RenderTextureDescriptor desc, UnityEngine.FilterMode filterMode);
                    /*0x1420060*/ UnityEngine.Rendering.RTHandle GetBufferA();
                    /*0x141feb0*/ void EnableMSAA(bool enable);

                    struct SwapBuffer
                    {
                        /*0x10*/ UnityEngine.Rendering.RTHandle rtMSAA;
                        /*0x18*/ UnityEngine.Rendering.RTHandle rtResolve;
                        /*0x20*/ string name;
                        /*0x28*/ int msaa;
                    }
                }

                enum StencilUsage
                {
                    UserMask = 15,
                    StencilLight = 16,
                    MaterialMask = 96,
                    MaterialUnlit = 0,
                    MaterialLit = 32,
                    MaterialSimpleLit = 64,
                }
            }

            namespace UTess
            {
                struct ArraySlice<T> : System.IEquatable<UnityEngine.Rendering.Universal.UTess.ArraySlice<T>>
                {
                    /*0x0*/ byte* m_Buffer;
                    /*0x0*/ int m_Stride;
                    /*0x0*/ int m_Length;

                    static /*0x2a5510*/ bool op_Equality(UnityEngine.Rendering.Universal.UTess.ArraySlice<T> left, UnityEngine.Rendering.Universal.UTess.ArraySlice<T> right);
                    static /*0x2a5510*/ bool op_Inequality(UnityEngine.Rendering.Universal.UTess.ArraySlice<T> left, UnityEngine.Rendering.Universal.UTess.ArraySlice<T> right);
                    static /*0x2a5510*/ UnityEngine.Rendering.Universal.UTess.ArraySlice<T> ConvertExistingDataToArraySlice(void* dataPointer, int stride, int length);
                    /*0x2a5510*/ ArraySlice(Unity.Collections.NativeArray<T> array, int start, int length);
                    /*0x2a5510*/ bool Equals(UnityEngine.Rendering.Universal.UTess.ArraySlice<T> other);
                    /*0x17e620*/ bool Equals(object obj);
                    /*0x180980*/ int GetHashCode();
                    /*0x2a5510*/ T get_Item(int index);
                    /*0x2a5510*/ void set_Item(int index, T value);
                    /*0x2a5510*/ void* GetUnsafeReadOnlyPtr();
                    /*0x17aec0*/ void CopyTo(T[] array);
                    /*0x1803b0*/ T[] ToArray();
                    /*0x180980*/ int get_Stride();
                    /*0x180980*/ int get_Length();
                }

                class ArraySliceDebugView<T>
                {
                    /*0x0*/ UnityEngine.Rendering.Universal.UTess.ArraySlice<T> m_Slice;

                    /*0x2a5510*/ ArraySliceDebugView(UnityEngine.Rendering.Universal.UTess.ArraySlice<T> slice);
                    /*0x1803b0*/ T[] get_Items();
                }

                struct PlanarGraph
                {
                    static /*0x0*/ double kEpsilon;
                    static /*0x8*/ int kMaxIntersectionTolerance;

                    static /*0x141f120*/ PlanarGraph();
                    static /*0x141e4e0*/ void RemoveDuplicateEdges(ref Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, ref int edgeCount, Unity.Collections.NativeArray<int> duplicates, int duplicateCount);
                    static /*0x141d970*/ bool CheckCollinear(Unity.Mathematics.double2 a0, Unity.Mathematics.double2 a1, Unity.Mathematics.double2 b0, Unity.Mathematics.double2 b1);
                    static /*0x141ddd0*/ bool LineLineIntersection(Unity.Mathematics.double2 a0, Unity.Mathematics.double2 a1, Unity.Mathematics.double2 b0, Unity.Mathematics.double2 b1);
                    static /*0x141e300*/ bool LineLineIntersection(Unity.Mathematics.double2 p1, Unity.Mathematics.double2 p2, Unity.Mathematics.double2 p3, Unity.Mathematics.double2 p4, ref Unity.Mathematics.double2 result);
                    static /*0x141d270*/ bool CalculateEdgeIntersections(Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, int edgeCount, Unity.Collections.NativeArray<Unity.Mathematics.double2> points, int pointCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> results, ref Unity.Collections.NativeArray<Unity.Mathematics.double2> intersects, ref int resultCount);
                    static /*0x141d6d0*/ bool CalculateTJunctions(Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, int edgeCount, Unity.Collections.NativeArray<Unity.Mathematics.double2> points, int pointCount, Unity.Collections.NativeArray<Unity.Mathematics.int2> results, ref int resultCount);
                    static /*0x141daf0*/ bool CutEdges(ref Unity.Collections.NativeArray<Unity.Mathematics.double2> points, ref int pointCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, ref int edgeCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> tJunctions, ref int tJunctionCount, Unity.Collections.NativeArray<Unity.Mathematics.int2> intersections, Unity.Collections.NativeArray<Unity.Mathematics.double2> intersects, int intersectionCount);
                    static /*0x141e6c0*/ void RemoveDuplicatePoints(ref Unity.Collections.NativeArray<Unity.Mathematics.double2> points, ref int pointCount, ref Unity.Collections.NativeArray<int> duplicates, ref int duplicateCount, Unity.Collections.Allocator allocator);
                    static /*0x141e9d0*/ bool Validate(Unity.Collections.Allocator allocator, Unity.Collections.NativeArray<Unity.Mathematics.float2> inputPoints, int pointCount, Unity.Collections.NativeArray<Unity.Mathematics.int2> inputEdges, int edgeCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> outputPoints, ref int outputPointCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> outputEdges, ref int outputEdgeCount);
                }

                struct Refinery
                {
                    static /*0x0*/ float kMinAreaFactor;
                    static /*0x4*/ float kMaxAreaFactor;
                    static /*0x8*/ int kMaxSteinerCount;

                    static /*0x141fd70*/ Refinery();
                    static /*0x10e3130*/ bool RequiresRefining(UnityEngine.Rendering.Universal.UTess.UTriangle tri, float maxArea);
                    static /*0x141f760*/ void FetchEncroachedSegments(Unity.Collections.NativeArray<Unity.Mathematics.float2> pgPoints, int pgPointCount, Unity.Collections.NativeArray<Unity.Mathematics.int2> pgEdges, int pgEdgeCount, ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.UTess.UEncroachingSegment> encroach, ref int encroachCount, UnityEngine.Rendering.Universal.UTess.UCircle c);
                    static /*0x10e3110*/ void InsertVertex(ref Unity.Collections.NativeArray<Unity.Mathematics.float2> pgPoints, ref int pgPointCount, Unity.Mathematics.float2 newVertex, ref int nid);
                    static /*0x141f9a0*/ int FindSegment(Unity.Collections.NativeArray<Unity.Mathematics.float2> pgPoints, int pgPointCount, Unity.Collections.NativeArray<Unity.Mathematics.int2> pgEdges, int pgEdgeCount, UnityEngine.Rendering.Universal.UTess.UEncroachingSegment es);
                    static /*0x141fa80*/ void SplitSegments(ref Unity.Collections.NativeArray<Unity.Mathematics.float2> pgPoints, ref int pgPointCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> pgEdges, ref int pgEdgeCount, UnityEngine.Rendering.Universal.UTess.UEncroachingSegment es);
                    static /*0x141f180*/ bool Condition(Unity.Collections.Allocator allocator, float factorArea, float targetArea, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> pgPoints, ref int pgPointCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> pgEdges, ref int pgEdgeCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> vertices, ref int vertexCount, ref Unity.Collections.NativeArray<int> indices, ref int indexCount, ref float maxArea);
                }

                struct Smoothen
                {
                    static /*0x0*/ float kMaxAreaTolerance;
                    static /*0x4*/ float kMaxEdgeTolerance;

                    static /*0x1421850*/ Smoothen();
                    static /*0x14216a0*/ void RefineEdges(ref Unity.Collections.NativeArray<Unity.Mathematics.int4> refinedEdges, ref Unity.Collections.NativeArray<Unity.Mathematics.int4> delaEdges, ref int delaEdgeCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int4> voronoiEdges);
                    static /*0x10e42b0*/ void GetAffectingEdges(int pointIndex, Unity.Collections.NativeArray<Unity.Mathematics.int4> edges, int edgeCount, ref Unity.Collections.NativeArray<int> resultSet, ref Unity.Collections.NativeArray<int> checkSet, ref int resultCount);
                    static /*0x10e33a0*/ void CentroidByPoints(int triIndex, Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.UTess.UTriangle> triangles, ref Unity.Collections.NativeArray<int> centroidTris, ref int centroidCount, ref Unity.Mathematics.float2 aggregate, ref Unity.Mathematics.float2 point);
                    static /*0x14209e0*/ void CentroidByPolygon(Unity.Mathematics.int4 e, Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.UTess.UTriangle> triangles, ref Unity.Mathematics.float2 centroid, ref float area, ref float distance);
                    static /*0x10e40b0*/ bool ConnectTriangles(ref Unity.Collections.NativeArray<Unity.Mathematics.int4> connectedTri, ref Unity.Collections.NativeArray<int> affectEdges, ref Unity.Collections.NativeArray<int> checkSet, Unity.Collections.NativeArray<Unity.Mathematics.int4> voronoiEdges, int triangleCount);
                    static /*0x1420b10*/ bool Condition(Unity.Collections.Allocator allocator, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> pgPoints, int pgPointCount, Unity.Collections.NativeArray<Unity.Mathematics.int2> pgEdges, int pgEdgeCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> vertices, ref int vertexCount, ref Unity.Collections.NativeArray<int> indices, ref int indexCount);
                }

                struct Tessellator
                {
                    /*0x10*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> m_Edges;
                    /*0x20*/ Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.UTess.UStar> m_Stars;
                    /*0x30*/ Unity.Collections.NativeArray<Unity.Mathematics.int3> m_Cells;
                    /*0x40*/ int m_CellCount;
                    /*0x48*/ Unity.Collections.NativeArray<int> m_ILArray;
                    /*0x58*/ Unity.Collections.NativeArray<int> m_IUArray;
                    /*0x68*/ Unity.Collections.NativeArray<int> m_SPArray;
                    /*0x78*/ int m_NumEdges;
                    /*0x7c*/ int m_NumHulls;
                    /*0x80*/ int m_NumPoints;
                    /*0x84*/ int m_StarCount;
                    /*0x88*/ Unity.Collections.NativeArray<int> m_Flags;
                    /*0x98*/ Unity.Collections.NativeArray<int> m_Neighbors;
                    /*0xa8*/ Unity.Collections.NativeArray<int> m_Constraints;
                    /*0xb8*/ Unity.Collections.Allocator m_Allocator;

                    static /*0x1422f10*/ float FindSplit(UnityEngine.Rendering.Universal.UTess.UHull hull, UnityEngine.Rendering.Universal.UTess.UEvent edge);
                    static /*0x10e6910*/ void InsertHull(Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.UTess.UHull> Hulls, int Pos, ref int Count, UnityEngine.Rendering.Universal.UTess.UHull Value);
                    static /*0x10e6000*/ void EraseHull(Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.UTess.UHull> Hulls, int Pos, ref int Count);
                    static /*0x1423570*/ void InsertUniqueEdge(Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, Unity.Mathematics.int2 e, ref int edgeCount);
                    static /*0x14246b0*/ bool Tessellate(Unity.Collections.Allocator allocator, Unity.Collections.NativeArray<Unity.Mathematics.float2> pgPoints, int pgPointCount, Unity.Collections.NativeArray<Unity.Mathematics.int2> pgEdges, int pgEdgeCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> outputVertices, ref int vertexCount, ref Unity.Collections.NativeArray<int> outputIndices, ref int indexCount);
                    /*0xb69b10*/ void SetAllocator(Unity.Collections.Allocator allocator);
                    /*0x14218a0*/ bool AddPoint(Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.UTess.UHull> hulls, int hullCount, Unity.Collections.NativeArray<Unity.Mathematics.float2> points, Unity.Mathematics.float2 p, int idx);
                    /*0x14242a0*/ bool SplitHulls(Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.UTess.UHull> hulls, ref int hullCount, Unity.Collections.NativeArray<Unity.Mathematics.float2> points, UnityEngine.Rendering.Universal.UTess.UEvent evt);
                    /*0x1423600*/ bool MergeHulls(Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.UTess.UHull> hulls, ref int hullCount, Unity.Collections.NativeArray<Unity.Mathematics.float2> points, UnityEngine.Rendering.Universal.UTess.UEvent evt);
                    /*0x1423960*/ void PrepareDelaunay(Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, int edgeCount);
                    /*0x1423890*/ int OppositeOf(int a, int b);
                    /*0x1422d70*/ int FindConstraint(int a, int b);
                    /*0x1421d60*/ void AddTriangle(int i, int j, int k);
                    /*0x14240c0*/ void RemovePair(int r, int j, int k);
                    /*0x1424220*/ void RemoveTriangle(int i, int j, int k);
                    /*0x1422c60*/ void EdgeFlip(int i, int j);
                    /*0x14231c0*/ bool Flip(Unity.Collections.NativeArray<Unity.Mathematics.float2> points, ref Unity.Collections.NativeArray<int> stack, ref int stackCount, int a, int b, int x);
                    /*0x14233d0*/ Unity.Collections.NativeArray<Unity.Mathematics.int3> GetCells(ref int count);
                    /*0x1421f30*/ bool ApplyDelaunay(Unity.Collections.NativeArray<Unity.Mathematics.float2> points, Unity.Collections.NativeArray<Unity.Mathematics.int2> edges);
                    /*0x1422e20*/ int FindNeighbor(Unity.Collections.NativeArray<Unity.Mathematics.int3> cells, int count, int a, int b, int c);
                    /*0x1422700*/ Unity.Collections.NativeArray<Unity.Mathematics.int3> Constrain(ref int count);
                    /*0x1423e90*/ Unity.Collections.NativeArray<Unity.Mathematics.int3> RemoveExterior(ref int cellCount);
                    /*0x1423fb0*/ Unity.Collections.NativeArray<Unity.Mathematics.int3> RemoveInterior(int cellCount);
                    /*0x14249d0*/ bool Triangulate(Unity.Collections.NativeArray<Unity.Mathematics.float2> points, int pointCount, Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, int edgeCount);
                    /*0x14225a0*/ void Cleanup();

                    struct TestHullPointL : UnityEngine.Rendering.Universal.UTess.ICondition2<UnityEngine.Rendering.Universal.UTess.UHull, Unity.Mathematics.float2>
                    {
                        /*0x1425250*/ bool Test(UnityEngine.Rendering.Universal.UTess.UHull h, Unity.Mathematics.float2 p, ref float t);
                    }

                    struct TestHullPointU : UnityEngine.Rendering.Universal.UTess.ICondition2<UnityEngine.Rendering.Universal.UTess.UHull, Unity.Mathematics.float2>
                    {
                        /*0x1425330*/ bool Test(UnityEngine.Rendering.Universal.UTess.UHull h, Unity.Mathematics.float2 p, ref float t);
                    }

                    struct TestHullEventLe : UnityEngine.Rendering.Universal.UTess.ICondition2<UnityEngine.Rendering.Universal.UTess.UHull, UnityEngine.Rendering.Universal.UTess.UEvent>
                    {
                        /*0x14251e0*/ bool Test(UnityEngine.Rendering.Universal.UTess.UHull h, UnityEngine.Rendering.Universal.UTess.UEvent p, ref float t);
                    }

                    struct TestHullEventE : UnityEngine.Rendering.Universal.UTess.ICondition2<UnityEngine.Rendering.Universal.UTess.UHull, UnityEngine.Rendering.Universal.UTess.UEvent>
                    {
                        /*0x1425160*/ bool Test(UnityEngine.Rendering.Universal.UTess.UHull h, UnityEngine.Rendering.Universal.UTess.UEvent p, ref float t);
                    }

                    struct TestEdgePointE : UnityEngine.Rendering.Universal.UTess.ICondition2<Unity.Mathematics.int2, Unity.Mathematics.int2>
                    {
                        /*0x1425120*/ bool Test(Unity.Mathematics.int2 h, Unity.Mathematics.int2 p, ref float t);
                    }

                    struct TestCellE : UnityEngine.Rendering.Universal.UTess.ICondition2<Unity.Mathematics.int3, Unity.Mathematics.int3>
                    {
                        /*0x14250b0*/ bool Test(Unity.Mathematics.int3 h, Unity.Mathematics.int3 p, ref float t);
                    }
                }

                enum UEventType
                {
                    EVENT_POINT = 0,
                    EVENT_END = 1,
                    EVENT_START = 2,
                }

                struct UEvent
                {
                    /*0x10*/ Unity.Mathematics.float2 a;
                    /*0x18*/ Unity.Mathematics.float2 b;
                    /*0x20*/ int idx;
                    /*0x24*/ int type;
                }

                struct UHull
                {
                    /*0x10*/ Unity.Mathematics.float2 a;
                    /*0x18*/ Unity.Mathematics.float2 b;
                    /*0x20*/ int idx;
                    /*0x28*/ UnityEngine.Rendering.Universal.UTess.ArraySlice<int> ilarray;
                    /*0x38*/ int ilcount;
                    /*0x40*/ UnityEngine.Rendering.Universal.UTess.ArraySlice<int> iuarray;
                    /*0x50*/ int iucount;
                }

                struct UStar
                {
                    /*0x10*/ UnityEngine.Rendering.Universal.UTess.ArraySlice<int> points;
                    /*0x20*/ int pointCount;
                }

                struct UBounds
                {
                    /*0x10*/ Unity.Mathematics.double2 min;
                    /*0x20*/ Unity.Mathematics.double2 max;
                }

                struct UCircle
                {
                    /*0x10*/ Unity.Mathematics.float2 center;
                    /*0x18*/ float radius;
                }

                struct UTriangle
                {
                    /*0x10*/ Unity.Mathematics.float2 va;
                    /*0x18*/ Unity.Mathematics.float2 vb;
                    /*0x20*/ Unity.Mathematics.float2 vc;
                    /*0x28*/ UnityEngine.Rendering.Universal.UTess.UCircle c;
                    /*0x34*/ float area;
                    /*0x38*/ Unity.Mathematics.int3 indices;
                }

                struct UEncroachingSegment
                {
                    /*0x10*/ Unity.Mathematics.float2 a;
                    /*0x18*/ Unity.Mathematics.float2 b;
                    /*0x20*/ int index;
                }

                interface ICondition<T, U>
                {
                    /*0x2a5510*/ bool Test(T x, U y, ref float t);
                }

                struct XCompare : System.Collections.Generic.IComparer<double>
                {
                    /*0x10e89f0*/ int Compare(double a, double b);
                }

                struct IntersectionCompare : System.Collections.Generic.IComparer<Unity.Mathematics.int2>
                {
                    /*0x10*/ Unity.Collections.NativeArray<Unity.Mathematics.double2> points;
                    /*0x20*/ Unity.Collections.NativeArray<Unity.Mathematics.int2> edges;
                    /*0x30*/ UnityEngine.Rendering.Universal.UTess.IntersectionCompare.<xvasort> xvasort;
                    /*0x50*/ UnityEngine.Rendering.Universal.UTess.IntersectionCompare.<xvbsort> xvbsort;

                    /*0x141a700*/ int Compare(Unity.Mathematics.int2 a, Unity.Mathematics.int2 b);

                    struct <xvasort>e__FixedBuffer
                    {
                        /*0x10*/ double FixedElementField;
                    }

                    struct <xvbsort>e__FixedBuffer
                    {
                        /*0x10*/ double FixedElementField;
                    }
                }

                struct TessEventCompare : System.Collections.Generic.IComparer<UnityEngine.Rendering.Universal.UTess.UEvent>
                {
                    /*0x1367dd0*/ int Compare(UnityEngine.Rendering.Universal.UTess.UEvent a, UnityEngine.Rendering.Universal.UTess.UEvent b);
                }

                struct TessEdgeCompare : System.Collections.Generic.IComparer<Unity.Mathematics.int2>
                {
                    /*0x10e4540*/ int Compare(Unity.Mathematics.int2 a, Unity.Mathematics.int2 b);
                }

                struct TessCellCompare : System.Collections.Generic.IComparer<Unity.Mathematics.int3>
                {
                    /*0x10e4520*/ int Compare(Unity.Mathematics.int3 a, Unity.Mathematics.int3 b);
                }

                struct TessJunctionCompare : System.Collections.Generic.IComparer<Unity.Mathematics.int2>
                {
                    /*0x10e4540*/ int Compare(Unity.Mathematics.int2 a, Unity.Mathematics.int2 b);
                }

                struct DelaEdgeCompare : System.Collections.Generic.IComparer<Unity.Mathematics.int4>
                {
                    /*0x10dc910*/ int Compare(Unity.Mathematics.int4 a, Unity.Mathematics.int4 b);
                }

                struct TessLink
                {
                    /*0x10*/ Unity.Collections.NativeArray<int> roots;
                    /*0x20*/ Unity.Collections.NativeArray<int> ranks;

                    static /*0x1367fe0*/ UnityEngine.Rendering.Universal.UTess.TessLink CreateLink(int count, Unity.Collections.Allocator allocator);
                    static /*0x13680c0*/ void DestroyLink(UnityEngine.Rendering.Universal.UTess.TessLink link);
                    /*0x10e48c0*/ int Find(int x);
                    /*0x10e4920*/ void Link(int x, int y);
                }

                struct ModuleHandle
                {
                    static /*0x0*/ int kMaxArea;
                    static /*0x4*/ int kMaxEdgeCount;
                    static /*0x8*/ int kMaxIndexCount;
                    static /*0xc*/ int kMaxVertexCount;
                    static /*0x10*/ int kMaxTriangleCount;
                    static /*0x14*/ int kMaxRefineIterations;
                    static /*0x18*/ int kMaxSmoothenIterations;
                    static /*0x1c*/ float kIncrementAreaFactor;

                    static /*0x1367cf0*/ ModuleHandle();
                    static /*0x2a5510*/ void Copy<T>(Unity.Collections.NativeArray<T> src, int srcIndex, Unity.Collections.NativeArray<T> dst, int dstIndex, int length);
                    static /*0x2a5510*/ void Copy<T>(Unity.Collections.NativeArray<T> src, Unity.Collections.NativeArray<T> dst, int length);
                    static /*0x2a5510*/ void InsertionSort<T, U>(void* array, int lo, int hi, U comp);
                    static /*0x2a5510*/ int GetLower<T, U, X>(Unity.Collections.NativeArray<T> values, int count, U check, X condition);
                    static /*0x2a5510*/ int GetUpper<T, U, X>(Unity.Collections.NativeArray<T> values, int count, U check, X condition);
                    static /*0x2a5510*/ int GetEqual<T, U, X>(Unity.Collections.NativeArray<T> values, int count, U check, X condition);
                    static /*0x10deb20*/ float OrientFast(Unity.Mathematics.float2 a, Unity.Mathematics.float2 b, Unity.Mathematics.float2 c);
                    static /*0x10deac0*/ double OrientFastDouble(Unity.Mathematics.double2 a, Unity.Mathematics.double2 b, Unity.Mathematics.double2 c);
                    static /*0x10ddb40*/ UnityEngine.Rendering.Universal.UTess.UCircle CircumCircle(UnityEngine.Rendering.Universal.UTess.UTriangle tri);
                    static /*0x10de770*/ bool IsInsideCircle(UnityEngine.Rendering.Universal.UTess.UCircle c, Unity.Mathematics.float2 v);
                    static /*0x10e0280*/ float TriangleArea(Unity.Mathematics.float2 va, Unity.Mathematics.float2 vb, Unity.Mathematics.float2 vc);
                    static /*0x10dec40*/ float Sign(Unity.Mathematics.float2 p1, Unity.Mathematics.float2 p2, Unity.Mathematics.float2 p3);
                    static /*0x1366540*/ bool IsInsideTriangle(Unity.Mathematics.float2 pt, Unity.Mathematics.float2 v1, Unity.Mathematics.float2 v2, Unity.Mathematics.float2 v3);
                    static /*0x1366390*/ bool IsInsideTriangleApproximate(Unity.Mathematics.float2 pt, Unity.Mathematics.float2 v1, Unity.Mathematics.float2 v2, Unity.Mathematics.float2 v3);
                    static /*0x10de540*/ bool IsInsideCircle(Unity.Mathematics.float2 a, Unity.Mathematics.float2 b, Unity.Mathematics.float2 c, Unity.Mathematics.float2 p);
                    static /*0x1365830*/ void BuildTriangles(Unity.Collections.NativeArray<Unity.Mathematics.float2> vertices, int vertexCount, Unity.Collections.NativeArray<int> indices, int indexCount, ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.UTess.UTriangle> triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea);
                    static /*0x1365390*/ void BuildTriangles(Unity.Collections.NativeArray<Unity.Mathematics.float2> vertices, int vertexCount, Unity.Collections.NativeArray<int> indices, int indexCount, ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.UTess.UTriangle> triangles, ref int triangleCount, ref float maxArea, ref float avgArea, ref float minArea, ref float maxEdge, ref float avgEdge, ref float minEdge);
                    static /*0x1364f90*/ void BuildTrianglesAndEdges(Unity.Collections.NativeArray<Unity.Mathematics.float2> vertices, int vertexCount, Unity.Collections.NativeArray<int> indices, int indexCount, ref Unity.Collections.NativeArray<UnityEngine.Rendering.Universal.UTess.UTriangle> triangles, ref int triangleCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int4> delaEdges, ref int delaEdgeCount, ref float maxArea, ref float avgArea, ref float minArea);
                    static /*0x1365ef0*/ void CopyGraph(Unity.Collections.NativeArray<Unity.Mathematics.float2> srcPoints, int srcPointCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> dstPoints, ref int dstPointCount, Unity.Collections.NativeArray<Unity.Mathematics.int2> srcEdges, int srcEdgeCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> dstEdges, ref int dstEdgeCount);
                    static /*0x1365df0*/ void CopyGeometry(Unity.Collections.NativeArray<int> srcIndices, int srcIndexCount, ref Unity.Collections.NativeArray<int> dstIndices, ref int dstIndexCount, Unity.Collections.NativeArray<Unity.Mathematics.float2> srcVertices, int srcVertexCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> dstVertices, ref int dstVertexCount);
                    static /*0x1367a70*/ void TransferOutput(Unity.Collections.NativeArray<Unity.Mathematics.int2> srcEdges, int srcEdgeCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> dstEdges, ref int dstEdgeCount, Unity.Collections.NativeArray<int> srcIndices, int srcIndexCount, ref Unity.Collections.NativeArray<int> dstIndices, ref int dstIndexCount, Unity.Collections.NativeArray<Unity.Mathematics.float2> srcVertices, int srcVertexCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> dstVertices, ref int dstVertexCount);
                    static /*0x1366000*/ void GraphConditioner(Unity.Collections.NativeArray<Unity.Mathematics.float2> points, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> pgPoints, ref int pgPointCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> pgEdges, ref int pgEdgeCount, bool resetTopology);
                    static /*0x10deba0*/ void Reorder(int startVertexCount, int index, ref Unity.Collections.NativeArray<int> indices, ref int indexCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> vertices, ref int vertexCount);
                    static /*0x1367be0*/ void VertexCleanupConditioner(int startVertexCount, ref Unity.Collections.NativeArray<int> indices, ref int indexCount, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> vertices, ref int vertexCount);
                    static /*0x1365b70*/ Unity.Mathematics.float4 ConvexQuad(Unity.Collections.Allocator allocator, Unity.Collections.NativeArray<Unity.Mathematics.float2> points, Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> outVertices, ref int outVertexCount, ref Unity.Collections.NativeArray<int> outIndices, ref int outIndexCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> outEdges, ref int outEdgeCount);
                    static /*0x13675d0*/ Unity.Mathematics.float4 Tessellate(Unity.Collections.Allocator allocator, Unity.Collections.NativeArray<Unity.Mathematics.float2> points, Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> outVertices, ref int outVertexCount, ref Unity.Collections.NativeArray<int> outIndices, ref int outIndexCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> outEdges, ref int outEdgeCount);
                    static /*0x1366690*/ Unity.Mathematics.float4 Subdivide(Unity.Collections.Allocator allocator, Unity.Collections.NativeArray<Unity.Mathematics.float2> points, Unity.Collections.NativeArray<Unity.Mathematics.int2> edges, ref Unity.Collections.NativeArray<Unity.Mathematics.float2> outVertices, ref int outVertexCount, ref Unity.Collections.NativeArray<int> outIndices, ref int outIndexCount, ref Unity.Collections.NativeArray<Unity.Mathematics.int2> outEdges, ref int outEdgeCount, float areaFactor, float targetArea, int refineIterations, int smoothenIterations);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 08243D32F28C35701F6EA57F52AE707302C8528E8D358F13C6E6915543D265C6;
    static /*0x10*/ <PrivateImplementationDetails> 18689A54C1FF754BE58500B2ED77A6C75B025BE96F6D01FEF89C42DA1C953F34;
    static /*0x28*/ <PrivateImplementationDetails> 4636993D3E1DA4E9D6B8F87B79E8F7C6D018580D52661950EABC3845C5897A4D;
    static /*0x34*/ <PrivateImplementationDetails> 4E537B3EAF08706696FC723EB6ED487C95CDE757E2250A8914DE279A25F66C0D;
    static /*0x4852*/ <PrivateImplementationDetails> 6322123493378558D4F9DD025993C168685B194246485704DD5B391FDCD77A64;
    static /*0x4c12*/ <PrivateImplementationDetails> 6D38AC27B07D199F160756B50922F8CB747BCDA1786618BFE0589FD1A36D2064;
    static /*0xa8de*/ <PrivateImplementationDetails> 888955380992D62883B27CC51FDC7E5C290C441026048F403C5618F305AD2BF1;
    static /*0xa8ee*/ <PrivateImplementationDetails> 8E2129A5F232A49B45FCB149981C3507166B7EE6265A5B90A1C9B0B87B2C0A80;
    static /*0xa8fa*/ <PrivateImplementationDetails> 9D3A6E7E88415D8C1A0F3887B6384A9A8E4F44A036C5A24796C319751ACACCAD;
    static /*0xa906*/ <PrivateImplementationDetails> B6599D21CE74F24FA42D57991D6B0D0C5770322C90AF734EEB36A37F74090137;
    static /*0xa912*/ <PrivateImplementationDetails> BAED642339816AFFB3FE8719792D0E4CE82F12DB72B7373D244EAA65445800FE;
    static /*0xa922*/ <PrivateImplementationDetails> C94719FC63BFC7010A8361E8B4D4746BAB3C8AD593769F86532655EE58EBB101;
    static /*0xa932*/ <PrivateImplementationDetails> E2EF5640DF412939A64301FFA3F66A62A34FA6E45A26E62F6994E5390B380D01;

    struct __StaticArrayInitTypeSize=12
    {
    }

    struct __StaticArrayInitTypeSize=16
    {
    }

    struct __StaticArrayInitTypeSize=24
    {
    }

    struct __StaticArrayInitTypeSize=960
    {
    }

    struct __StaticArrayInitTypeSize=18462
    {
    }

    struct __StaticArrayInitTypeSize=23756
    {
    }
}
