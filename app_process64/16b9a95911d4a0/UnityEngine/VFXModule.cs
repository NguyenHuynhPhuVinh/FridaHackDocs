class <Module>
{
}

namespace UnityEngine
{
    namespace VFX
    {
        enum VFXCameraBufferTypes
        {
            None = 0,
            Depth = 1,
            Color = 2,
            Normal = 4,
        }

        class VFXEventAttribute : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ bool m_Owner;
            /*0x20*/ UnityEngine.VFX.VisualEffectAsset m_VfxAsset;

            static /*0x40ff8b8*/ UnityEngine.VFX.VFXEventAttribute CreateEventAttributeWrapper();
            static /*0x40ff980*/ nint Internal_Create();
            static /*0x40ff9a8*/ UnityEngine.VFX.VFXEventAttribute Internal_InstanciateVFXEventAttribute(UnityEngine.VFX.VisualEffectAsset vfxAsset);
            static /*0x40ffb9c*/ void Internal_Destroy(nint ptr);
            static /*0x40ffaf8*/ void Internal_InitFromAsset_Injected(nint _unity_self, nint vfxAsset);
            /*0x40ff870*/ VFXEventAttribute(nint ptr, bool owner, UnityEngine.VFX.VisualEffectAsset vfxAsset);
            /*0x40ff924*/ void SetWrapValue(nint ptrToEventAttribute);
            /*0x40ffa50*/ void Internal_InitFromAsset(UnityEngine.VFX.VisualEffectAsset vfxAsset);
            /*0x40ffb3c*/ void Release();
            /*0x40ffbd8*/ void Finalize();
            /*0x40ffc5c*/ void Dispose();

            class BindingsMarshaller
            {
                static /*0x40ffcbc*/ nint ConvertToNative(UnityEngine.VFX.VFXEventAttribute eventAttibute);
            }
        }

        class VFXExpressionValues
        {
            /*0x10*/ nint m_Ptr;

            static /*0x40ffcd8*/ UnityEngine.VFX.VFXExpressionValues CreateExpressionValuesWrapper(nint ptr);
            /*0x40ffcd0*/ VFXExpressionValues();
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

            static /*0x4100208*/ VFXManager();
            static /*0x40ffd3c*/ void ProcessCameraCommand(UnityEngine.Camera cam, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.VFX.VFXCameraXRSettings camXRSettings, UnityEngine.Rendering.CullingResults results);
            static /*0x40ffdc4*/ void Internal_ProcessCameraCommand(UnityEngine.Camera cam, UnityEngine.Rendering.CommandBuffer cmd, UnityEngine.VFX.VFXCameraXRSettings camXRSettings, nint cullResults, nint customPassCullResults);
            static /*0x40fff3c*/ UnityEngine.VFX.VFXCameraBufferTypes IsCameraBufferNeeded(UnityEngine.Camera cam);
            static /*0x4100044*/ void SetCameraBuffer(UnityEngine.Camera cam, UnityEngine.VFX.VFXCameraBufferTypes type, UnityEngine.Texture buffer, int x, int y, int width, int height);
            static /*0x40ffed0*/ void Internal_ProcessCameraCommand_Injected(nint cam, nint cmd, ref UnityEngine.VFX.VFXCameraXRSettings camXRSettings, nint cullResults, nint customPassCullResults);
            static /*0x4100008*/ UnityEngine.VFX.VFXCameraBufferTypes IsCameraBufferNeeded_Injected(nint cam);
            static /*0x4100184*/ void SetCameraBuffer_Injected(nint cam, UnityEngine.VFX.VFXCameraBufferTypes type, nint buffer, int x, int y, int width, int height);
        }

        class VFXSpawnerCallbacks : UnityEngine.ScriptableObject
        {
            /*0x4100258*/ VFXSpawnerCallbacks();
            /*0x1f310fc*/ void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x1f310fc*/ void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            /*0x1f310fc*/ void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
        }

        class VFXSpawnerState : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ bool m_Owner;
            /*0x20*/ UnityEngine.VFX.VFXEventAttribute m_WrapEventAttribute;

            static /*0x4100290*/ UnityEngine.VFX.VFXSpawnerState CreateSpawnerStateWrapper();
            static /*0x4100480*/ void Internal_Destroy(nint ptr);
            /*0x4100260*/ VFXSpawnerState(nint ptr, bool owner);
            /*0x41002f4*/ void PrepareWrapper();
            /*0x410038c*/ void SetWrapValue(nint ptrToSpawnerState, nint ptrToEventAttribute);
            /*0x4100420*/ void Release();
            /*0x41004bc*/ void Finalize();
            /*0x4100540*/ void Dispose();
        }

        class VisualEffectObject : UnityEngine.Object
        {
        }

        class VisualEffectAsset : UnityEngine.VFX.VisualEffectObject
        {
            static /*0x0*/ int PlayEventID;
            static /*0x4*/ int StopEventID;

            static /*0x41005a0*/ VisualEffectAsset();
        }

        struct VFXOutputEventArgs
        {
            /*0x10*/ int <nameId>k__BackingField;
            /*0x18*/ UnityEngine.VFX.VFXEventAttribute <eventAttribute>k__BackingField;

            /*0x4100640*/ VFXOutputEventArgs(int nameId, UnityEngine.VFX.VFXEventAttribute eventAttribute);
        }

        class VisualEffect : UnityEngine.Behaviour
        {
            /*0x18*/ UnityEngine.VFX.VFXEventAttribute m_cachedEventAttribute;
            /*0x20*/ System.Action<UnityEngine.VFX.VFXOutputEventArgs> outputEventReceived;

            static /*0x41007ac*/ UnityEngine.VFX.VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(UnityEngine.VFX.VisualEffect source);
            static /*0x4100804*/ void InvokeOutputEventReceived_Internal(UnityEngine.VFX.VisualEffect source, int eventNameId);
            static /*0x41006e4*/ nint get_visualEffectAsset_Injected(nint _unity_self);
            /*0x4100650*/ UnityEngine.VFX.VisualEffectAsset get_visualEffectAsset();
            /*0x4100720*/ UnityEngine.VFX.VFXEventAttribute CreateVFXEventAttribute();
        }

        class VFXRenderer : UnityEngine.Renderer
        {
            /*0x4100868*/ VFXRenderer();
        }
    }
}
