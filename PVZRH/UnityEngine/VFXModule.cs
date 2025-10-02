class <Module>
{
}

namespace UnityEngine
{
    namespace VFX
    {
        class VFXEventAttribute : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ bool m_Owner;
            /*0x20*/ UnityEngine.VFX.VisualEffectAsset m_VfxAsset;

            static /*0x1869a00*/ UnityEngine.VFX.VFXEventAttribute CreateEventAttributeWrapper();
            static /*0x1869bd0*/ nint Internal_Create();
            static /*0x1869c90*/ UnityEngine.VFX.VFXEventAttribute Internal_InstanciateVFXEventAttribute(UnityEngine.VFX.VisualEffectAsset vfxAsset);
            static /*0x1869c00*/ void Internal_Destroy(nint ptr);
            /*0x1869e30*/ VFXEventAttribute(nint ptr, bool owner, UnityEngine.VFX.VisualEffectAsset vfxAsset);
            /*0x1869dc0*/ void SetWrapValue(nint ptrToEventAttribute);
            /*0x1869c40*/ void Internal_InitFromAsset(UnityEngine.VFX.VisualEffectAsset vfxAsset);
            /*0x1869d50*/ void Release();
            /*0x1869b10*/ void Finalize();
            /*0x1869a60*/ void Dispose();
        }

        class VFXExpressionValues
        {
            /*0x10*/ nint m_Ptr;

            static /*0x1869e90*/ UnityEngine.VFX.VFXExpressionValues CreateExpressionValuesWrapper(nint ptr);
            /*0x32f970*/ VFXExpressionValues();
        }

        struct VFXCameraXRSettings
        {
            /*0x10*/ uint viewTotal;
            /*0x14*/ uint viewCount;
            /*0x18*/ uint viewOffset;
        }

        struct VFXBatchedEffectInfo
        {
            /*0x10*/ UnityEngine.VFX.VisualEffectAsset vfxAsset;
            /*0x18*/ uint activeBatchCount;
            /*0x1c*/ uint inactiveBatchCount;
            /*0x20*/ uint activeInstanceCount;
            /*0x24*/ uint unbatchedInstanceCount;
            /*0x28*/ uint totalInstanceCapacity;
            /*0x2c*/ uint maxInstancePerBatchCapacity;
            /*0x30*/ ulong totalGPUSizeInBytes;
            /*0x38*/ ulong totalCPUSizeInBytes;
        }

        struct VFXBatchInfo
        {
            /*0x10*/ uint capacity;
            /*0x14*/ uint activeInstanceCount;
        }

        class VFXManager
        {
            static /*0x0*/ UnityEngine.VFX.VFXCameraXRSettings kDefaultCameraXRSettings;

            static /*0x186a0e0*/ VFXManager();
            static /*0x186a000*/ void ProcessCameraCommand(UnityEngine.Camera cam, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.VFX.VFXCameraXRSettings camXRSettings, UnityEngine.Rendering.CullingResults results);
            static /*0x1869f60*/ void Internal_ProcessCameraCommand(UnityEngine.Camera cam, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.VFX.VFXCameraXRSettings camXRSettings, nint cullResults);
            static /*0x1869ef0*/ void Internal_ProcessCameraCommand_Injected(UnityEngine.Camera cam, UnityEngine.Rendering.CommandBuffer cmd, ref UnityEngine.VFX.VFXCameraXRSettings camXRSettings, nint cullResults);
        }

        class VFXSpawnerCallbacks : UnityEngine.ScriptableObject
        {
            /*0x533ec0*/ VFXSpawnerCallbacks();
            /*0x183830*/ void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x183830*/ void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x183830*/ void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
        }

        class VFXSpawnerState : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ bool m_Owner;
            /*0x20*/ UnityEngine.VFX.VFXEventAttribute m_WrapEventAttribute;

            static /*0x186a140*/ UnityEngine.VFX.VFXSpawnerState CreateSpawnerStateWrapper();
            static /*0x186a3c0*/ void Internal_Destroy(nint ptr);
            /*0x186a6b0*/ VFXSpawnerState(nint ptr, bool owner);
            /*0x186a400*/ void PrepareWrapper();
            /*0x186a590*/ void SetWrapValue(nint ptrToSpawnerState, nint ptrToEventAttribute);
            /*0x186a520*/ void Release();
            /*0x186a300*/ void Finalize();
            /*0x186a250*/ void Dispose();
        }

        class VisualEffectObject : UnityEngine.Object
        {
            /*0x186a770*/ VisualEffectObject();
        }

        class VisualEffectAsset : UnityEngine.VFX.VisualEffectObject
        {
            static /*0x0*/ int PlayEventID;
            static /*0x4*/ int StopEventID;

            static /*0x186a6f0*/ VisualEffectAsset();
            /*0x186a770*/ VisualEffectAsset();
        }

        struct VFXOutputEventArgs
        {
            /*0x10*/ int <nameId>k__BackingField;
            /*0x18*/ UnityEngine.VFX.VFXEventAttribute <eventAttribute>k__BackingField;

            /*0xa59e80*/ VFXOutputEventArgs(int nameId, UnityEngine.VFX.VFXEventAttribute eventAttribute);
        }

        class VisualEffect : UnityEngine.Behaviour
        {
            /*0x18*/ UnityEngine.VFX.VFXEventAttribute m_cachedEventAttribute;
            /*0x20*/ System.Action<UnityEngine.VFX.VFXOutputEventArgs> outputEventReceived;

            static /*0x186a920*/ UnityEngine.VFX.VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(UnityEngine.VFX.VisualEffect source);
            static /*0x186aad0*/ void InvokeOutputEventReceived_Internal(UnityEngine.VFX.VisualEffect source, int eventNameId);
            /*0x186ab30*/ UnityEngine.VFX.VisualEffectAsset get_visualEffectAsset();
            /*0x186a7c0*/ UnityEngine.VFX.VFXEventAttribute CreateVFXEventAttribute();
        }

        class VFXRenderer : UnityEngine.Renderer
        {
            /*0x31c640*/ VFXRenderer();
        }
    }
}
