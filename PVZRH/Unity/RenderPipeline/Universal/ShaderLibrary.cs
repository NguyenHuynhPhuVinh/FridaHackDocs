class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x129c2f0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
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
    namespace Rendering
    {
        namespace Universal
        {
            enum DebugMaterialMode
            {
                None = 0,
                Albedo = 1,
                Specular = 2,
                Alpha = 3,
                Smoothness = 4,
                AmbientOcclusion = 5,
                Emission = 6,
                NormalWorldSpace = 7,
                NormalTangentSpace = 8,
                LightingComplexity = 9,
                Metallic = 10,
                SpriteMask = 11,
            }

            enum DebugVertexAttributeMode
            {
                None = 0,
                Texcoord0 = 1,
                Texcoord1 = 2,
                Texcoord2 = 3,
                Texcoord3 = 4,
                Color = 5,
                Tangent = 6,
                Normal = 7,
            }

            enum DebugMaterialValidationMode
            {
                None = 0,
                Albedo = 1,
                Metallic = 2,
            }

            enum DebugFullScreenMode
            {
                None = 0,
                Depth = 1,
                AdditionalLightsShadowMap = 2,
                MainLightShadowMap = 3,
                ReflectionProbeAtlas = 4,
            }

            enum DebugSceneOverrideMode
            {
                None = 0,
                Overdraw = 1,
                Wireframe = 2,
                SolidWireframe = 3,
                ShadedWireframe = 4,
            }

            enum DebugOverdrawMode
            {
                None = 0,
                Opaque = 1,
                Transparent = 2,
                All = 3,
            }

            enum DebugMipInfoMode
            {
                None = 0,
                Level = 1,
                Count = 2,
                Ratio = 3,
            }

            enum DebugPostProcessingMode
            {
                Disabled = 0,
                Auto = 1,
                Enabled = 2,
            }

            enum DebugValidationMode
            {
                None = 0,
                HighlightNanInfNegative = 1,
                HighlightOutsideOfRange = 2,
            }

            enum PixelValidationChannels
            {
                RGB = 0,
                R = 1,
                G = 2,
                B = 3,
                A = 4,
            }

            enum DebugLightingMode
            {
                None = 0,
                ShadowCascades = 1,
                LightingWithoutNormalMaps = 2,
                LightingWithNormalMaps = 3,
                Reflections = 4,
                ReflectionsWithSmoothness = 5,
            }

            enum HDRDebugMode
            {
                None = 0,
                GamutView = 1,
                GamutClip = 2,
                ValuesAbovePaperWhite = 3,
            }

            enum DebugLightingFeatureFlags
            {
                None = 0,
                GlobalIllumination = 1,
                MainLight = 2,
                AdditionalLights = 4,
                VertexLighting = 8,
                Emission = 16,
                AmbientOcclusion = 32,
            }

            class ShaderInput
            {
                struct ShadowData
                {
                    /*0x10*/ UnityEngine.Matrix4x4 worldToShadowMatrix;
                    /*0x50*/ UnityEngine.Vector4 shadowParams;
                }

                struct LightData
                {
                    /*0x10*/ UnityEngine.Vector4 position;
                    /*0x20*/ UnityEngine.Vector4 color;
                    /*0x30*/ UnityEngine.Vector4 attenuation;
                    /*0x40*/ UnityEngine.Vector4 spotDirection;
                    /*0x50*/ UnityEngine.Vector4 occlusionProbeChannels;
                    /*0x60*/ uint layerMask;
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 58BB7E3F387A2A49C905373DADB0FA29CC579679DD37F0A57279C7BECDA58273;
    static /*0xcd*/ <PrivateImplementationDetails> 685D33E36DBAAACD58F4B35441F9B70BB1F802DA5A24F6C4FBBFD56AB33E8AEC;

    struct __StaticArrayInitTypeSize=205
    {
    }

    struct __StaticArrayInitTypeSize=213
    {
    }
}
