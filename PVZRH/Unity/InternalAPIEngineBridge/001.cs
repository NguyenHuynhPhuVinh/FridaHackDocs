class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x1188d10*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
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
    namespace U2D
    {
        namespace Common
        {
            interface IPreviewable : UnityEngine.Animations.IAnimationPreviewable
            {
            }

            class InternalEngineBridge
            {
                static /*0x1188ce0*/ void SetLocalAABB(UnityEngine.SpriteRenderer spriteRenderer, UnityEngine.Bounds aabb);
                static /*0x1188cc0*/ void SetDeformableBuffer(UnityEngine.SpriteRenderer spriteRenderer, Unity.Collections.NativeArray<byte> src);
                static /*0x1188c70*/ bool IsUsingDeformableBuffer(UnityEngine.SpriteRenderer spriteRenderer, nint buffer);
                static /*0x1188bd0*/ UnityEngine.Vector2 GUIUnclip(UnityEngine.Vector2 v);
                static /*0x1188be0*/ UnityEngine.Rect GetGUIClipTopMostRect();
                static /*0x1188c10*/ UnityEngine.Rect GetGUIClipTopRect();
                static /*0x1188c40*/ UnityEngine.Rect GetGUIClipVisibleRect();
                static /*0x1188c80*/ void SetBatchDeformableBufferAndLocalAABBArray(UnityEngine.SpriteRenderer[] spriteRenderers, Unity.Collections.NativeArray<nint> buffers, Unity.Collections.NativeArray<int> bufferSizes, Unity.Collections.NativeArray<UnityEngine.Bounds> bounds);
                static /*0x1188bb0*/ int ConvertFloatToInt(float f);
                static /*0x1188bc0*/ float ConvertIntToFloat(int i);
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 3A12FECE0BDACC38D4B8DBC3BE2F98E8C3EC9A1FC2B5B47C23BEADF88EBFB116;
    static /*0x58*/ <PrivateImplementationDetails> 78AD561E8820D8585731AB3E5FFF4C91B89CC762DE80BA920AE26A606BA9065E;

    struct __StaticArrayInitTypeSize=88
    {
    }

    struct __StaticArrayInitTypeSize=205
    {
    }
}
