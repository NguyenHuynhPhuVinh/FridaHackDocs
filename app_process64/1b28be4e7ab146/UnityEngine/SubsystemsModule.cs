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
        /*0x38148bc*/ string get_id();
    }

    class IntegratedSubsystem : UnityEngine.ISubsystem
    {
        /*0x10*/ nint m_Ptr;
        /*0x18*/ UnityEngine.ISubsystemDescriptor m_SubsystemDescriptor;

        static /*0x7f6f694*/ void SetHandle_Injected(nint _unity_self, UnityEngine.IntegratedSubsystem subsystem);
        static /*0x7f6f74c*/ bool IsRunning_Injected(nint _unity_self);
        /*0x7f6f788*/ IntegratedSubsystem();
        /*0x7f6f63c*/ void SetHandle(UnityEngine.IntegratedSubsystem subsystem);
        /*0x7f6f6d8*/ bool get_running();
        /*0x7f6f6ec*/ bool get_valid();
        /*0x7f6f6fc*/ bool IsRunning();

        class BindingsMarshaller
        {
            static /*0x7f6f790*/ nint ConvertToNative(UnityEngine.IntegratedSubsystem integratedSubsystem);
        }
    }

    class IntegratedSubsystem<TSubsystemDescriptor> : UnityEngine.IntegratedSubsystem
    {
        /*0x38159dc*/ IntegratedSubsystem();
    }

    class IntegratedSubsystemDescriptor : UnityEngine.ISubsystemDescriptor
    {
        /*0x10*/ nint m_Ptr;

        /*0x7f6f86c*/ IntegratedSubsystemDescriptor();
        /*0x7f6f7a8*/ string get_id();
    }

    class IntegratedSubsystemDescriptor<TSubsystem> : UnityEngine.IntegratedSubsystemDescriptor
    {
        /*0x38159dc*/ IntegratedSubsystemDescriptor();
    }

    class SubsystemDescriptorBindings
    {
        static /*0x7f6f7b0*/ string GetId(nint descriptorPtr);
        static /*0x7f6f874*/ void GetId_Injected(nint descriptorPtr, ref UnityEngine.Bindings.ManagedSpanWrapper ret);
    }

    class Subsystem : UnityEngine.ISubsystem
    {
        /*0x7f6f8b8*/ Subsystem();
    }

    class SubsystemDescriptor : UnityEngine.ISubsystemDescriptor
    {
        /*0x10*/ string <id>k__BackingField;

        /*0x7f6f8c8*/ SubsystemDescriptor();
        /*0x7f6f8c0*/ string get_id();
    }

    class Internal_SubsystemDescriptors
    {
        static /*0x7f6f8d0*/ void Internal_AddDescriptor(UnityEngine.SubsystemDescriptor descriptor);
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

        static /*0x7f6febc*/ SubsystemManager();
        static /*0x7f6f99c*/ void ReloadSubsystemsStarted();
        static /*0x7f6fa7c*/ void ReloadSubsystemsCompleted();
        static /*0x7f6fb5c*/ void InitializeIntegratedSubsystem(nint ptr, UnityEngine.IntegratedSubsystem subsystem);
        static /*0x7f6fc48*/ void ClearSubsystems();
        static /*0x7f6fe94*/ void StaticConstructScriptingClassMap();
        static /*0x3840c74*/ void GetSubsystems<T>(System.Collections.Generic.List<T> subsystems);
        static /*0x3843dfc*/ void AddSubsystemSubset<TBaseTypeInList, TQueryType>(System.Collections.Generic.List<TBaseTypeInList> copyFrom, System.Collections.Generic.List<TQueryType> copyTo);
        static /*0x7f7001c*/ UnityEngine.IntegratedSubsystem GetIntegratedSubsystemByPtr(nint ptr);
    }

    namespace SubsystemsImplementation
    {
        class SubsystemDescriptorStore
        {
            static /*0x0*/ System.Collections.Generic.List<UnityEngine.IntegratedSubsystemDescriptor> s_IntegratedDescriptors;
            static /*0x8*/ System.Collections.Generic.List<UnityEngine.SubsystemsImplementation.SubsystemDescriptorWithProvider> s_StandaloneDescriptors;
            static /*0x10*/ System.Collections.Generic.List<UnityEngine.SubsystemDescriptor> s_DeprecatedDescriptors;

            static /*0x7f70600*/ SubsystemDescriptorStore();
            static /*0x7f7019c*/ void InitializeManagedDescriptor(nint ptr, UnityEngine.IntegratedSubsystemDescriptor desc);
            static /*0x7f7027c*/ void ClearManagedDescriptors();
            static /*0x7f70438*/ void ReportSingleSubsystemAnalytics(string id);
            static /*0x3910ae8*/ void RegisterDescriptor<TDescriptor, TBaseTypeInList>(TDescriptor descriptor, System.Collections.Generic.List<TBaseTypeInList> storeInList);
            static /*0x7f6f924*/ void RegisterDeprecatedDescriptor(UnityEngine.SubsystemDescriptor descriptor);
            static /*0x7f705c4*/ void ReportSingleSubsystemAnalytics_Injected(ref UnityEngine.Bindings.ManagedSpanWrapper id);
        }

        class SubsystemDescriptorWithProvider : UnityEngine.ISubsystemDescriptor
        {
            /*0x10*/ string <id>k__BackingField;

            /*0x7f70750*/ SubsystemDescriptorWithProvider();
            /*0x7f70748*/ string get_id();
        }

        class SubsystemWithProvider : UnityEngine.ISubsystem
        {
            /*0x7f70758*/ SubsystemWithProvider();
        }
    }
}
