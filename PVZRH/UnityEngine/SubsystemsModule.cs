class <Module>
{
}

namespace UnityEngine
{
    class IntegratedSubsystem : UnityEngine.ISubsystem
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.ISubsystemDescriptor m_SubsystemDescriptor;

        /*0x32f970*/ IntegratedSubsystem();
        /*0x16560a0*/ void SetHandle(UnityEngine.IntegratedSubsystem subsystem);
        /*0x16560f0*/ bool get_running();
        /*0x1656150*/ bool get_valid();
        /*0x1656060*/ bool IsRunning();
    }

    class IntegratedSubsystem<TSubsystemDescriptor> : UnityEngine.IntegratedSubsystem
    {
        /*0x180fc0*/ IntegratedSubsystem();
    }

    class IntegratedSubsystemDescriptor : UnityEngine.ISubsystemDescriptor
    {
        /*0x10*/ nint m_Ptr;

        /*0x32f970*/ IntegratedSubsystemDescriptor();
        /*0x1656020*/ string get_id();
    }

    class IntegratedSubsystemDescriptor<TSubsystem> : UnityEngine.IntegratedSubsystemDescriptor
    {
        /*0x180fc0*/ IntegratedSubsystemDescriptor();
    }

    class SubsystemDescriptorBindings
    {
        static /*0x1656200*/ string GetId(nint descriptorPtr);
    }

    interface ISubsystem
    {
    }

    interface ISubsystemDescriptor
    {
        /*0x1803b0*/ string get_id();
    }

    class Subsystem : UnityEngine.ISubsystem
    {
        /*0x32f970*/ Subsystem();
    }

    class SubsystemDescriptor : UnityEngine.ISubsystemDescriptor
    {
        /*0x10*/ string <id>k__BackingField;

        /*0x32f970*/ SubsystemDescriptor();
        /*0x73d3e0*/ string get_id();
    }

    class Internal_SubsystemDescriptors
    {
        static /*0x1656160*/ void Internal_AddDescriptor(UnityEngine.SubsystemDescriptor descriptor);
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

        static /*0x1656d70*/ SubsystemManager();
        static /*0x1656c50*/ void ReloadSubsystemsStarted();
        static /*0x1656b60*/ void ReloadSubsystemsCompleted();
        static /*0x1656a50*/ void InitializeIntegratedSubsystem(nint ptr, UnityEngine.IntegratedSubsystem subsystem);
        static /*0x16566c0*/ void ClearSubsystems();
        static /*0x1656d40*/ void StaticConstructScriptingClassMap();
        static /*0x177be0*/ void GetSubsystems<T>(System.Collections.Generic.List<T> subsystems);
        static /*0x177670*/ void AddSubsystemSubset<TBaseTypeInList, TQueryType>(System.Collections.Generic.List<TBaseTypeInList> copyFrom, System.Collections.Generic.List<TQueryType> copyTo);
        static /*0x16568e0*/ UnityEngine.IntegratedSubsystem GetIntegratedSubsystemByPtr(nint ptr);
        static /*0x177be0*/ void GetInstances<T>(System.Collections.Generic.List<T> subsystems);
    }

    namespace SubsystemsImplementation
    {
        class SubsystemDescriptorStore
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.IntegratedSubsystemDescriptor> s_IntegratedDescriptors;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider> s_StandaloneDescriptors;
            static /*0x10*/ System.Collections.Generic.List<UnityEngine.SubsystemDescriptor> s_DeprecatedDescriptors;

            static /*0x1656570*/ SubsystemDescriptorStore();
            static /*0x16563d0*/ void InitializeManagedDescriptor(nint ptr, UnityEngine.IntegratedSubsystemDescriptor desc);
            static /*0x1656240*/ void ClearManagedDescriptors();
            static /*0x1656530*/ void ReportSingleSubsystemAnalytics(string id);
            static /*0x2a5510*/ void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, System.Collections.Generic.List<TBaseTypeInList> storeInList);
            static /*0x16564c0*/ void RegisterDeprecatedDescriptor(UnityEngine.SubsystemDescriptor descriptor);
        }

        class SubsystemDescriptorWithProvider : UnityEngine.ISubsystemDescriptor
        {
            /*0x10*/ string <id>k__BackingField;

            /*0x32f970*/ SubsystemDescriptorWithProvider();
            /*0x73d3e0*/ string get_id();
        }

        class SubsystemWithProvider : UnityEngine.ISubsystem
        {
            /*0x32f970*/ SubsystemWithProvider();
        }
    }
}
