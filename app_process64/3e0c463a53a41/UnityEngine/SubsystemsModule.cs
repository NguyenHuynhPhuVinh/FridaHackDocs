class <Module>
{
}

namespace UnityEngine
{
    interface ISubsystem
    {
    }

    interface ISubsystemDescriptor
    {
        /*0x380b9e8*/ string get_id();
    }

    class IntegratedSubsystem : UnityEngine.ISubsystem
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.ISubsystemDescriptor m_SubsystemDescriptor;

        static /*0x7f58264*/ void SetHandle_Injected(nint _unity_self, UnityEngine.IntegratedSubsystem subsystem);
        static /*0x7f5831c*/ bool IsRunning_Injected(nint _unity_self);
        /*0x7f58358*/ IntegratedSubsystem();
        /*0x7f5820c*/ void SetHandle(UnityEngine.IntegratedSubsystem subsystem);
        /*0x7f582a8*/ bool get_running();
        /*0x7f582bc*/ bool get_valid();
        /*0x7f582cc*/ bool IsRunning();

        class BindingsMarshaller
        {
            static /*0x7f58360*/ nint ConvertToNative(UnityEngine.IntegratedSubsystem integratedSubsystem);
        }
    }

    class IntegratedSubsystem<TSubsystemDescriptor> : UnityEngine.IntegratedSubsystem
    {
        /*0x380cb08*/ IntegratedSubsystem();
    }

    class IntegratedSubsystemDescriptor : UnityEngine.ISubsystemDescriptor
    {
        /*0x10*/ nint m_Ptr;

        /*0x7f5843c*/ IntegratedSubsystemDescriptor();
        /*0x7f58378*/ string get_id();
    }

    class IntegratedSubsystemDescriptor<TSubsystem> : UnityEngine.IntegratedSubsystemDescriptor
    {
        /*0x380cb08*/ IntegratedSubsystemDescriptor();
    }

    class SubsystemDescriptorBindings
    {
        static /*0x7f58380*/ string GetId(nint descriptorPtr);
        static /*0x7f58444*/ void GetId_Injected(nint descriptorPtr, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
    }

    class Subsystem : UnityEngine.ISubsystem
    {
        /*0x7f58488*/ Subsystem();
    }

    class SubsystemDescriptor : UnityEngine.ISubsystemDescriptor
    {
        /*0x10*/ string <id>k__BackingField;

        /*0x7f58498*/ SubsystemDescriptor();
        /*0x7f58490*/ string get_id();
    }

    class Internal_SubsystemDescriptors
    {
        static /*0x7f584a0*/ void Internal_AddDescriptor(UnityEngine.SubsystemDescriptor descriptor);
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

        static /*0x7f58a8c*/ SubsystemManager();
        static /*0x7f5856c*/ void ReloadSubsystemsStarted();
        static /*0x7f5864c*/ void ReloadSubsystemsCompleted();
        static /*0x7f5872c*/ void InitializeIntegratedSubsystem(nint ptr, UnityEngine.IntegratedSubsystem subsystem);
        static /*0x7f58818*/ void ClearSubsystems();
        static /*0x7f58a64*/ void StaticConstructScriptingClassMap();
        static /*0x3837da0*/ void GetSubsystems<T>(System.Collections.Generic.List<T> subsystems);
        static /*0x383af28*/ void AddSubsystemSubset<TBaseTypeInList, TQueryType>(System.Collections.Generic.List<TBaseTypeInList> copyFrom, System.Collections.Generic.List<TQueryType> copyTo);
        static /*0x7f58bec*/ UnityEngine.IntegratedSubsystem GetIntegratedSubsystemByPtr(nint ptr);
    }

    namespace SubsystemsImplementation
    {
        class SubsystemDescriptorStore
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.IntegratedSubsystemDescriptor> s_IntegratedDescriptors;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider> s_StandaloneDescriptors;
            static /*0x10*/ System.Collections.Generic.List<UnityEngine.SubsystemDescriptor> s_DeprecatedDescriptors;

            static /*0x7f591d0*/ SubsystemDescriptorStore();
            static /*0x7f58d6c*/ void InitializeManagedDescriptor(nint ptr, UnityEngine.IntegratedSubsystemDescriptor desc);
            static /*0x7f58e4c*/ void ClearManagedDescriptors();
            static /*0x7f59008*/ void ReportSingleSubsystemAnalytics(string id);
            static /*0x3907c14*/ void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, System.Collections.Generic.List<TBaseTypeInList> storeInList);
            static /*0x7f584f4*/ void RegisterDeprecatedDescriptor(UnityEngine.SubsystemDescriptor descriptor);
            static /*0x7f59194*/ void ReportSingleSubsystemAnalytics_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper id);
        }

        class SubsystemDescriptorWithProvider : UnityEngine.ISubsystemDescriptor
        {
            /*0x10*/ string <id>k__BackingField;

            /*0x7f59320*/ SubsystemDescriptorWithProvider();
            /*0x7f59318*/ string get_id();
        }

        class SubsystemWithProvider : UnityEngine.ISubsystem
        {
            /*0x7f59328*/ SubsystemWithProvider();
        }
    }
}
