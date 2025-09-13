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

            static /*0x2b34edc*/ nint Internal_Create();
            static /*0x2b34f10*/ UnityEngine.VFX.VFXEventAttribute Internal_InstanciateVFXEventAttribute(UnityEngine.VFX.VisualEffectAsset vfxAsset);
            static /*0x2b350c8*/ void Internal_Destroy(nint ptr);
            /*0x2b34e94*/ VFXEventAttribute(nint ptr, bool owner, UnityEngine.VFX.VisualEffectAsset vfxAsset);
            /*0x2b34fe4*/ void Internal_InitFromAsset(UnityEngine.VFX.VisualEffectAsset vfxAsset);
            /*0x2b35034*/ void Release();
            /*0x2b35108*/ void Finalize();
            /*0x2b35170*/ void Dispose();
        }

        class VFXExpressionValues
        {
            /*0x10*/ nint m_Ptr;

            static /*0x2b351e4*/ UnityEngine.VFX.VFXExpressionValues CreateExpressionValuesWrapper(nint ptr);
            /*0x2b351dc*/ VFXExpressionValues();
        }

        class VFXManager
        {
        }

        class VFXSpawnerCallbacks : UnityEngine.ScriptableObject
        {
            /*0x2b35258*/ VFXSpawnerCallbacks();
            void OnPlay(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            void OnUpdate(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
            void OnStop(UnityEngine.VFX.VFXSpawnerState state, UnityEngine.VFX.VFXExpressionValues vfxValues, UnityEngine.VFX.VisualEffect vfxComponent);
        }

        class VFXSpawnerState : System.IDisposable
        {
            /*0x10*/ nint m_Ptr;
            /*0x18*/ bool m_Owner;

            static /*0x2b352a0*/ UnityEngine.VFX.VFXSpawnerState CreateSpawnerStateWrapper();
            static /*0x2b35400*/ void Internal_Destroy(nint ptr);
            /*0x2b35260*/ VFXSpawnerState(nint ptr, bool owner);
            /*0x2b3530c*/ void SetWrapValue(nint ptr);
            /*0x2b35370*/ void Release();
            /*0x2b35440*/ void Finalize();
            /*0x2b354a8*/ void Dispose();
        }

        class VisualEffectObject : UnityEngine.Object
        {
            /*0x2b356ec*/ VisualEffectObject();
        }

        class VisualEffectAsset : UnityEngine.VFX.VisualEffectObject
        {
            static /*0x0*/ int PlayEventID;
            static /*0x4*/ int StopEventID;

            static /*0x2b35750*/ VisualEffectAsset();
            /*0x2b356e8*/ VisualEffectAsset();
        }

        struct VFXOutputEventArgs
        {
            /*0x10*/ int <nameId>k__BackingField;
            /*0x18*/ UnityEngine.VFX.VFXEventAttribute <eventAttribute>k__BackingField;

            /*0xb7ab0c*/ VFXOutputEventArgs(int nameId, UnityEngine.VFX.VFXEventAttribute eventAttribute);
        }

        class VisualEffect : UnityEngine.Behaviour
        {
            /*0x18*/ UnityEngine.VFX.VFXEventAttribute m_cachedEventAttribute;
            /*0x20*/ System.Action<UnityEngine.VFX.VFXOutputEventArgs> outputEventReceived;

            static /*0x2b35634*/ UnityEngine.VFX.VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(UnityEngine.VFX.VisualEffect source);
            static /*0x2b3567c*/ void InvokeOutputEventReceived_Internal(UnityEngine.VFX.VisualEffect source, int eventNameId);
            /*0x2b35514*/ UnityEngine.VFX.VisualEffectAsset get_visualEffectAsset();
            /*0x2b35554*/ UnityEngine.VFX.VFXEventAttribute CreateVFXEventAttribute();
        }
    }
}
