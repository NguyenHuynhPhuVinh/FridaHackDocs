class <Module>
{
}

namespace UnityEngine
{
    interface ISubsystemDescriptor
    {
        string get_id();
    }

    class IntegratedSubsystem
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.ISubsystemDescriptor m_SubsystemDescriptor;

        /*0x2b2d4d8*/ IntegratedSubsystem();
        /*0x2b2d488*/ void SetHandle(UnityEngine.IntegratedSubsystem subsystem);
    }

    class IntegratedSubsystem<TSubsystemDescriptor> : UnityEngine.IntegratedSubsystem
    {
        IntegratedSubsystem();
    }

    class IntegratedSubsystemDescriptor : UnityEngine.ISubsystemDescriptor
    {
        /*0x10*/ nint m_Ptr;

        /*0x2b2d560*/ IntegratedSubsystemDescriptor();
        /*0x2b2d4e0*/ string get_id();
    }

    class IntegratedSubsystemDescriptor<TSubsystem> : UnityEngine.IntegratedSubsystemDescriptor
    {
        IntegratedSubsystemDescriptor();
    }

    class SubsystemDescriptorBindings
    {
        static /*0x2b2d520*/ string GetId(nint descriptorPtr);
    }

    class Subsystem
    {
        /*0x2b2d64c*/ Subsystem();
    }

    class SubsystemDescriptor : UnityEngine.ISubsystemDescriptor
    {
        /*0x10*/ string <id>k__BackingField;

        /*0x2b2d65c*/ SubsystemDescriptor();
        /*0x2b2d654*/ string get_id();
    }

    class Internal_SubsystemDescriptors
    {
        static /*0x2b2d568*/ void Internal_AddDescriptor(UnityEngine.SubsystemDescriptor descriptor);
    }

    class SubsystemManager
    {
        static /*0x0*/ System.Action beforeReloadSubsystems;
        static /*0x8*/ System.Action afterReloadSubsystems;
        static /*0x10*/ System.Collections.Generic.List<UnityEngine.IntegratedSubsystem> s_IntegratedSubsystems;
        static /*0x18*/ System.Collections.Generic.List<UnityEngine.SubsystemsImplementation.SubsystemWithProvider> s_StandaloneSubsystems;
        static /*0x20*/ System.Collections.Generic.List<UnityEngine.Subsystem> s_DeprecatedSubsystems;
        static /*0x28*/ System.Action reloadSubsytemsStarted;
        static /*0x30*/ System.Action reloadSubsytemsCompleted;

        static /*0x2b2dedc*/ SubsystemManager();
        static /*0x2b2d9fc*/ void ReloadSubsystemsStarted();
        static /*0x2b2daf8*/ void ReloadSubsystemsCompleted();
        static /*0x2b2dbf4*/ void InitializeIntegratedSubsystem(nint ptr, UnityEngine.IntegratedSubsystem subsystem);
        static /*0x2b2dcc0*/ void ClearSubsystems();
        static /*0x2b2dea8*/ void StaticConstructScriptingClassMap();
        static /*0x2b2e010*/ UnityEngine.IntegratedSubsystem GetIntegratedSubsystemByPtr(nint ptr);
    }

    namespace SubsystemsImplementation
    {
        class SubsystemDescriptorStore
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.IntegratedSubsystemDescriptor> s_IntegratedDescriptors;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider> s_StandaloneDescriptors;
            static /*0x10*/ System.Collections.Generic.List<UnityEngine.SubsystemDescriptor> s_DeprecatedDescriptors;

            static /*0x2b2d8d4*/ SubsystemDescriptorStore();
            static /*0x2b2d664*/ void InitializeManagedDescriptor(nint ptr, UnityEngine.IntegratedSubsystemDescriptor desc);
            static /*0x2b2d704*/ void ClearManagedDescriptors();
            static /*0x2b2d894*/ void ReportSingleSubsystemAnalytics(string id);
            static void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, System.Collections.Generic.List<TBaseTypeInList> storeInList);
            static /*0x2b2d5c8*/ void RegisterDeprecatedDescriptor(UnityEngine.SubsystemDescriptor descriptor);
        }

        class SubsystemDescriptorWithProvider : UnityEngine.ISubsystemDescriptor
        {
            /*0x10*/ string <id>k__BackingField;

            /*0x2b2d9f4*/ SubsystemDescriptorWithProvider();
            /*0x2b2d9ec*/ string get_id();
        }

        class SubsystemWithProvider
        {
            /*0x2b2e18c*/ SubsystemWithProvider();
        }
    }
}
