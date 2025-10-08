class <Module>
{
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
                static /*0x3ac18ac*/ void SetLocalAABB(UnityEngine.SpriteRenderer spriteRenderer, UnityEngine.Bounds aabb);
                static /*0x3ac18dc*/ void SetDeformableBuffer(UnityEngine.SpriteRenderer spriteRenderer, Unity.Collections.NativeArray<byte> src);
                static /*0x3ac18e4*/ bool IsUsingDeformableBuffer(UnityEngine.SpriteRenderer spriteRenderer, nint buffer);
                static /*0x3ac18ec*/ bool IsGPUSkinningEnabled();
                static /*0x3ac18f4*/ void SetBatchDeformableBufferAndLocalAABBArray(UnityEngine.SpriteRenderer[] spriteRenderers, Unity.Collections.NativeArray<nint> buffers, Unity.Collections.NativeArray<int> bufferSizes, Unity.Collections.NativeArray<UnityEngine.Bounds> bounds);
                static /*0x3ac18fc*/ void SetBatchBoneTransformsAABBArray(UnityEngine.SpriteRenderer[] spriteRenderers, Unity.Collections.NativeArray<nint> buffers, Unity.Collections.NativeArray<int> bufferSizes, Unity.Collections.NativeArray<UnityEngine.Bounds> bounds);
                static /*0x3ac1904*/ int ConvertFloatToInt(float f);
                static /*0x3ac190c*/ float ConvertIntToFloat(int i);
            }
        }
    }
}
