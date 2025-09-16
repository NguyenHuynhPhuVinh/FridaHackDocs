class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x81e746c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x81e7560*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace VContainer
{
    class PreserveAttribute : System.Attribute
    {
        /*0x81e7568*/ PreserveAttribute();
    }

    class InjectAttribute : VContainer.PreserveAttribute
    {
        /*0x81e7570*/ InjectAttribute();
    }

    class InjectIgnoreAttribute : System.Attribute
    {
        /*0x81e7578*/ InjectIgnoreAttribute();
    }

    interface IObjectResolver : System.IDisposable
    {
        /*0x380b9e8*/ object get_ApplicationOrigin();
        /*0x380b9e8*/ VContainer.Diagnostics.DiagnosticsCollector get_Diagnostics();
        /*0x380d83c*/ void set_Diagnostics(VContainer.Diagnostics.DiagnosticsCollector value);
        /*0x380bb68*/ object Resolve(System.Type type);
        /*0x380bb68*/ object Resolve(VContainer.Registration registration);
        /*0x380bb68*/ VContainer.IScopedObjectResolver CreateScope(System.Action<VContainer.IContainerBuilder> installation);
        /*0x380d83c*/ void Inject(object instance);
    }

    interface IScopedObjectResolver : VContainer.IObjectResolver, System.IDisposable
    {
        /*0x380b9e8*/ VContainer.IObjectResolver get_Root();
        /*0x380b9e8*/ VContainer.IScopedObjectResolver get_Parent();
        /*0x380b32c*/ bool TryGetRegistration(System.Type type, ref VContainer.Registration registration);
    }

    enum Lifetime
    {
        Transient = 0,
        Singleton = 1,
        Scoped = 2,
    }

    class ScopedContainer : VContainer.IScopedObjectResolver, VContainer.IObjectResolver, System.IDisposable
    {
        /*0x10*/ VContainer.IObjectResolver <Root>k__BackingField;
        /*0x18*/ VContainer.IScopedObjectResolver <Parent>k__BackingField;
        /*0x20*/ object <ApplicationOrigin>k__BackingField;
        /*0x28*/ VContainer.Diagnostics.DiagnosticsCollector <Diagnostics>k__BackingField;
        /*0x30*/ VContainer.Internal.Registry registry;
        /*0x38*/ System.Collections.Concurrent.ConcurrentDictionary<VContainer.Registration, System.Lazy<object>> sharedInstances;
        /*0x40*/ VContainer.Internal.CompositeDisposable disposables;
        /*0x48*/ System.Func<VContainer.Registration, System.Lazy<object>> createInstance;

        /*0x81e75a8*/ ScopedContainer(VContainer.Internal.Registry registry, VContainer.IObjectResolver root, VContainer.IScopedObjectResolver parent, object applicationOrigin);
        /*0x81e7580*/ VContainer.IObjectResolver get_Root();
        /*0x81e7588*/ VContainer.IScopedObjectResolver get_Parent();
        /*0x81e7590*/ object get_ApplicationOrigin();
        /*0x81e7598*/ VContainer.Diagnostics.DiagnosticsCollector get_Diagnostics();
        /*0x81e75a0*/ void set_Diagnostics(VContainer.Diagnostics.DiagnosticsCollector value);
        /*0x81e77a8*/ object Resolve(System.Type type);
        /*0x81e785c*/ object Resolve(VContainer.Registration registration);
        /*0x81e7cb4*/ VContainer.IScopedObjectResolver CreateScope(System.Action<VContainer.IContainerBuilder> installation);
        /*0x81e7d94*/ void Inject(object instance);
        /*0x81e7fc0*/ bool TryGetRegistration(System.Type type, ref VContainer.Registration registration);
        /*0x81e8118*/ void Dispose();
        /*0x81e845c*/ object ResolveCore(VContainer.Registration registration);
        /*0x81e8708*/ object CreateTrackedInstance(VContainer.Registration registration);
        /*0x81e882c*/ VContainer.Registration FindRegistration(System.Type type);
        /*0x81e8a20*/ System.Lazy<object> <.ctor>b__17_0(VContainer.Registration registration);

        class <>c__DisplayClass17_0
        {
            /*0x10*/ VContainer.Registration registration;
            /*0x18*/ VContainer.ScopedContainer <>4__this;

            /*0x81e8b38*/ <>c__DisplayClass17_0();
            /*0x81e8b40*/ object <.ctor>b__1();
        }
    }

    class Container : VContainer.IObjectResolver, System.IDisposable
    {
        /*0x10*/ object <ApplicationOrigin>k__BackingField;
        /*0x18*/ VContainer.Diagnostics.DiagnosticsCollector <Diagnostics>k__BackingField;
        /*0x20*/ VContainer.Internal.Registry registry;
        /*0x28*/ VContainer.IScopedObjectResolver rootScope;
        /*0x30*/ System.Collections.Concurrent.ConcurrentDictionary<VContainer.Registration, System.Lazy<object>> sharedInstances;
        /*0x38*/ VContainer.Internal.CompositeDisposable disposables;
        /*0x40*/ System.Func<VContainer.Registration, System.Lazy<object>> createInstance;

        /*0x81e8c04*/ Container(VContainer.Internal.Registry registry, object applicationOrigin);
        /*0x81e8bec*/ object get_ApplicationOrigin();
        /*0x81e8bf4*/ VContainer.Diagnostics.DiagnosticsCollector get_Diagnostics();
        /*0x81e8bfc*/ void set_Diagnostics(VContainer.Diagnostics.DiagnosticsCollector value);
        /*0x81e8d98*/ object Resolve(System.Type type);
        /*0x81e8eb4*/ object Resolve(VContainer.Registration registration);
        /*0x81e8f60*/ VContainer.IScopedObjectResolver CreateScope(System.Action<VContainer.IContainerBuilder> installation);
        /*0x81e900c*/ void Inject(object instance);
        /*0x81e9100*/ void Dispose();
        /*0x81e91dc*/ object ResolveCore(VContainer.Registration registration);
        /*0x81e941c*/ System.Lazy<object> <.ctor>b__12_0(VContainer.Registration registration);

        class <>c__DisplayClass12_0
        {
            /*0x10*/ VContainer.Registration registration;
            /*0x18*/ VContainer.Container <>4__this;

            /*0x81e9534*/ <>c__DisplayClass12_0();
            /*0x81e953c*/ object <.ctor>b__1();
        }
    }

    interface IContainerBuilder
    {
        /*0x380b9e8*/ object get_ApplicationOrigin();
        /*0x380d83c*/ void set_ApplicationOrigin(object value);
        /*0x380b9e8*/ VContainer.Diagnostics.DiagnosticsCollector get_Diagnostics();
        /*0x380d83c*/ void set_Diagnostics(VContainer.Diagnostics.DiagnosticsCollector value);
        /*0x380b6a0*/ int get_Count();
        /*0x380ba90*/ VContainer.RegistrationBuilder get_Item(int index);
        /*0x380d170*/ void set_Item(int index, VContainer.RegistrationBuilder value);
        /*0x3907c14*/ T Register<T>(T registrationBuilder);
        /*0x380d83c*/ void RegisterBuildCallback(System.Action<VContainer.IObjectResolver> container);
        bool Exists(System.Type type, bool includeInterfaceTypes);
    }

    class ScopedContainerBuilder : VContainer.ContainerBuilder
    {
        /*0x30*/ VContainer.IObjectResolver root;
        /*0x38*/ VContainer.IScopedObjectResolver parent;

        /*0x81e7d54*/ ScopedContainerBuilder(VContainer.IObjectResolver root, VContainer.IScopedObjectResolver parent);
        /*0x81e9670*/ VContainer.IScopedObjectResolver BuildScope();
        /*0x81e9744*/ VContainer.IObjectResolver Build();
    }

    class ContainerBuilder : VContainer.IContainerBuilder
    {
        /*0x10*/ object <ApplicationOrigin>k__BackingField;
        /*0x18*/ System.Collections.Generic.List<VContainer.RegistrationBuilder> registrationBuilders;
        /*0x20*/ System.Action<VContainer.IObjectResolver> buildCallback;
        /*0x28*/ VContainer.Diagnostics.DiagnosticsCollector diagnostics;

        /*0x81e95e8*/ ContainerBuilder();
        /*0x81e974c*/ object get_ApplicationOrigin();
        /*0x81e9754*/ void set_ApplicationOrigin(object value);
        /*0x81e975c*/ int get_Count();
        /*0x81e97a4*/ VContainer.RegistrationBuilder get_Item(int index);
        /*0x81e97fc*/ void set_Item(int index, VContainer.RegistrationBuilder value);
        /*0x81e9864*/ VContainer.Diagnostics.DiagnosticsCollector get_Diagnostics();
        /*0x81e986c*/ void set_Diagnostics(VContainer.Diagnostics.DiagnosticsCollector value);
        /*0x3907c14*/ T Register<T>(T registrationBuilder);
        /*0x81e9898*/ void RegisterBuildCallback(System.Action<VContainer.IObjectResolver> callback);
        /*0x81e9940*/ bool Exists(System.Type type, bool includeInterfaceTypes);
        /*0x81e9b5c*/ VContainer.IObjectResolver Build();
        /*0x81e9c1c*/ VContainer.Internal.Registry BuildRegistry();
        /*0x81ea864*/ void EmitCallbacks(VContainer.IObjectResolver container);
    }

    class ContainerBuilderExtensions
    {
        static /*0x81ea908*/ VContainer.RegistrationBuilder Register(VContainer.IContainerBuilder builder, System.Type type, VContainer.Lifetime lifetime);
        static /*0x81eab68*/ VContainer.RegistrationBuilder Register(VContainer.IContainerBuilder builder, System.Type interfacetType, System.Type implementationType, VContainer.Lifetime lifetime);
        static /*0x38301ec*/ VContainer.RegistrationBuilder Register<T>(VContainer.IContainerBuilder builder, VContainer.Lifetime lifetime);
        static /*0x38301ec*/ VContainer.RegistrationBuilder Register<TInterface, TImplement>(VContainer.IContainerBuilder builder, VContainer.Lifetime lifetime);
        static /*0x38301ec*/ VContainer.RegistrationBuilder Register<TInterface1, TInterface2, TImplement>(VContainer.IContainerBuilder builder, VContainer.Lifetime lifetime);
        static /*0x38301ec*/ VContainer.RegistrationBuilder Register<TInterface1, TInterface2, TInterface3, TImplement>(VContainer.IContainerBuilder builder, VContainer.Lifetime lifetime);
        static /*0x383094c*/ VContainer.RegistrationBuilder Register<TInterface>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, TInterface> implementationConfiguration, VContainer.Lifetime lifetime);
        static /*0x3907c14*/ VContainer.RegistrationBuilder RegisterInstance<TInterface>(VContainer.IContainerBuilder builder, TInterface instance);
        static /*0x3907c14*/ VContainer.RegistrationBuilder RegisterInstance<TInterface1, TInterface2>(VContainer.IContainerBuilder builder, TInterface1 instance);
        static /*0x3907c14*/ VContainer.RegistrationBuilder RegisterInstance<TInterface1, TInterface2, TInterface3>(VContainer.IContainerBuilder builder, TInterface1 instance);
        static /*0x3830700*/ VContainer.RegistrationBuilder RegisterFactory<T>(VContainer.IContainerBuilder builder, System.Func<T> factory);
        static /*0x3830700*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, T>(VContainer.IContainerBuilder builder, System.Func<TParam1, T> factory);
        static /*0x3830700*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, TParam2, T>(VContainer.IContainerBuilder builder, System.Func<TParam1, TParam2, T> factory);
        static /*0x3830700*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, TParam2, TParam3, T>(VContainer.IContainerBuilder builder, System.Func<TParam1, TParam2, TParam3, T> factory);
        static /*0x3830700*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, TParam2, TParam3, TParam4, T>(VContainer.IContainerBuilder builder, System.Func<TParam1, TParam2, TParam3, TParam4, T> factory);
        static /*0x383094c*/ VContainer.RegistrationBuilder RegisterFactory<T>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, System.Func<T>> factoryFactory, VContainer.Lifetime lifetime);
        static /*0x383094c*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, T>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, System.Func<TParam1, T>> factoryFactory, VContainer.Lifetime lifetime);
        static /*0x383094c*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, TParam2, T>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, System.Func<TParam1, TParam2, T>> factoryFactory, VContainer.Lifetime lifetime);
        static /*0x383094c*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, TParam2, TParam3, T>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, System.Func<TParam1, TParam2, TParam3, T>> factoryFactory, VContainer.Lifetime lifetime);
        static /*0x383094c*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, TParam2, TParam3, TParam4, T>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, System.Func<TParam1, TParam2, TParam3, TParam4, T>> factoryFactory, VContainer.Lifetime lifetime);
        static /*0x81eabd0*/ void RegisterDisposeCallback(VContainer.IContainerBuilder builder, System.Action<VContainer.IObjectResolver> callback);
        static /*0x81eaddc*/ void RegisterContainer(VContainer.IContainerBuilder builder);

        class <>c
        {
            static /*0x0*/ VContainer.ContainerBuilderExtensions.<> <>9;
            static /*0x8*/ System.Action<VContainer.IObjectResolver> <>9__20_1;

            static /*0x81eade0*/ <>c();
            /*0x81eae48*/ <>c();
            /*0x81eae50*/ void <RegisterDisposeCallback>b__20_1(VContainer.IObjectResolver container);
        }

        class <>c__DisplayClass20_0
        {
            /*0x10*/ System.Action<VContainer.IObjectResolver> callback;

            /*0x81eadd4*/ <>c__DisplayClass20_0();
            /*0x81eae98*/ VContainer.Internal.BuilderCallbackDisposable <RegisterDisposeCallback>b__0(VContainer.IObjectResolver container);
        }

        class <>c__DisplayClass6_0<TInterface>
        {
            /*0x0*/ System.Func<VContainer.IObjectResolver, TInterface> implementationConfiguration;

            /*0x380cb08*/ <>c__DisplayClass6_0();
            /*0x380bb68*/ object <Register>b__0(VContainer.IObjectResolver container);
        }
    }

    interface IInjector
    {
        /*0x380da4c*/ void Inject(object instance, VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
        /*0x380bcbc*/ object CreateInstance(VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
    }

    interface IInjectParameter
    {
        /*0x380b32c*/ bool Match(System.Type parameterType, string parameterName);
        /*0x380b9e8*/ object get_Value();
    }

    interface IInstanceProvider
    {
        /*0x380bb68*/ object SpawnInstance(VContainer.IObjectResolver resolver);
    }

    class IObjectResolverExtensions
    {
        static /*0x3907c14*/ T Resolve<T>(VContainer.IObjectResolver resolver);
        static /*0x81eaf14*/ object ResolveNonGeneric(VContainer.IObjectResolver resolve, System.Type type);
        static /*0x81eafbc*/ object ResolveOrParameter(VContainer.IObjectResolver resolver, System.Type parameterType, string parameterName, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
    }

    class Registration
    {
        /*0x10*/ System.Type ImplementationType;
        /*0x18*/ System.Collections.Generic.IReadOnlyList<System.Type> InterfaceTypes;
        /*0x20*/ VContainer.Lifetime Lifetime;
        /*0x28*/ VContainer.IInstanceProvider Provider;

        /*0x81ea0e4*/ Registration(System.Type implementationType, VContainer.Lifetime lifetime, System.Collections.Generic.IReadOnlyList<System.Type> interfaceTypes, VContainer.IInstanceProvider provider);
        /*0x81eb264*/ string ToString();
        /*0x81eb46c*/ object SpawnInstance(VContainer.IObjectResolver resolver);
    }

    class RegistrationBuilder
    {
        /*0x10*/ System.Type ImplementationType;
        /*0x18*/ VContainer.Lifetime Lifetime;
        /*0x20*/ System.Collections.Generic.List<System.Type> InterfaceTypes;
        /*0x28*/ System.Collections.Generic.List<VContainer.IInjectParameter> Parameters;

        /*0x81eaa70*/ RegistrationBuilder(System.Type implementationType, VContainer.Lifetime lifetime);
        /*0x81eb514*/ VContainer.Registration Build();
        /*0x380b9e8*/ VContainer.RegistrationBuilder As<TInterface>();
        /*0x380b9e8*/ VContainer.RegistrationBuilder As<TInterface1, TInterface2>();
        /*0x380b9e8*/ VContainer.RegistrationBuilder As<TInterface1, TInterface2, TInterface3>();
        /*0x380b9e8*/ VContainer.RegistrationBuilder As<TInterface1, TInterface2, TInterface3, TInterface4>();
        /*0x81eb638*/ VContainer.RegistrationBuilder AsSelf();
        /*0x81eb65c*/ VContainer.RegistrationBuilder AsImplementedInterfaces();
        /*0x81eabb0*/ VContainer.RegistrationBuilder As(System.Type interfaceType);
        /*0x81eb72c*/ VContainer.RegistrationBuilder As(System.Type interfaceType1, System.Type interfaceType2);
        /*0x81eb76c*/ VContainer.RegistrationBuilder As(System.Type interfaceType1, System.Type interfaceType2, System.Type interfaceType3);
        /*0x81eb7c4*/ VContainer.RegistrationBuilder As(System.Type[] interfaceTypes);
        /*0x81eb83c*/ VContainer.RegistrationBuilder WithParameter(string name, object value);
        /*0x81eb9c8*/ VContainer.RegistrationBuilder WithParameter(System.Type type, object value);
        /*0x3907c14*/ VContainer.RegistrationBuilder WithParameter<TParam>(TParam value);
        /*0x81ebb54*/ void AddInterfaceType(System.Type interfaceType);
    }

    class VContainerException : System.Exception
    {
        /*0x90*/ System.Type InvalidType;

        /*0x81e89a4*/ VContainerException(System.Type invalidType, string message);
    }

    namespace Internal
    {
        struct BuilderCallbackDisposable : System.IDisposable
        {
            /*0x10*/ System.Action<VContainer.IObjectResolver> callback;
            /*0x18*/ VContainer.IObjectResolver container;

            /*0x81eaee4*/ BuilderCallbackDisposable(System.Action<VContainer.IObjectResolver> callback, VContainer.IObjectResolver container);
            /*0x81ebd08*/ void Dispose();
        }

        class CappedArrayPool<T>
        {
            static int InitialBucketSize = 4;
            static /*0x0*/ VContainer.Internal.CappedArrayPool<T> Shared8Limit;
            /*0x0*/ T[][][] buckets;
            /*0x0*/ object syncRoot;
            /*0x0*/ int[] tails;

            static /*0x38358cc*/ CappedArrayPool();
            /*0x380cffc*/ CappedArrayPool(int maxLength);
            /*0x380ba90*/ T[] Rent(int length);
            /*0x380d83c*/ void Return(T[] array);
        }

        class CompositeDisposable : System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.Stack<System.IDisposable> disposables;

            /*0x81e7720*/ CompositeDisposable();
            /*0x81e8294*/ void Dispose();
            /*0x81ebd30*/ void Add(System.IDisposable disposable);
        }

        class ContainerLocal<T>
        {
            /*0x0*/ T Value;

            /*0x3907c14*/ ContainerLocal(T value);
        }

        class FixedTypeKeyHashtable<TValue>
        {
            /*0x0*/ VContainer.Internal.FixedTypeKeyHashtable.HashEntry<TValue> table;
            /*0x0*/ int indexFor;

            FixedTypeKeyHashtable(System.Collections.Generic.KeyValuePair<System.Type, TValue> values, float loadFactor);
            /*0x3907c14*/ TValue Get(System.Type type);
            /*0x380b32c*/ bool TryGet(System.Type type, ref TValue value);

            struct HashEntry<TValue>
            {
                /*0x0*/ System.Type Type;
                /*0x0*/ TValue Value;

                /*0x3907c14*/ HashEntry(System.Type key, TValue value);
            }
        }

        class FuncRegistrationBuilder : VContainer.RegistrationBuilder
        {
            /*0x30*/ System.Func<VContainer.IObjectResolver, object> implementationProvider;

            /*0x81ebe30*/ FuncRegistrationBuilder(System.Func<VContainer.IObjectResolver, object> implementationProvider, System.Type implementationType, VContainer.Lifetime lifetime);
            /*0x81ebe84*/ VContainer.Registration Build();
        }

        class InjectorCache
        {
            static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, VContainer.IInjector> Injectors;

            static /*0x81ebf68*/ InjectorCache();
            static /*0x81e7e88*/ VContainer.IInjector GetOrBuild(System.Type type);

            class <>c
            {
                static /*0x0*/ VContainer.Internal.InjectorCache.<> <>9;
                static /*0x8*/ System.Func<System.Type, VContainer.IInjector> <>9__1_0;

                static /*0x81ec000*/ <>c();
                /*0x81ec068*/ <>c();
                /*0x81ec070*/ VContainer.IInjector <GetOrBuild>b__1_0(System.Type key);
            }
        }

        class TypedParameter : VContainer.IInjectParameter
        {
            /*0x10*/ System.Type Type;
            /*0x18*/ object <Value>k__BackingField;

            /*0x81ebb10*/ TypedParameter(System.Type type, object value);
            /*0x81ec270*/ object get_Value();
            /*0x81ec278*/ bool Match(System.Type parameterType, string _);
        }

        class NamedParameter : VContainer.IInjectParameter
        {
            /*0x10*/ string Name;
            /*0x18*/ object <Value>k__BackingField;

            /*0x81eb984*/ NamedParameter(string name, object value);
            /*0x81ec2bc*/ object get_Value();
            /*0x81ec2c4*/ bool Match(System.Type _, string parameterName);
        }

        class CollectionInstanceProvider : VContainer.IInstanceProvider, System.Collections.Generic.IEnumerable<VContainer.Registration>, System.Collections.IEnumerable
        {
            /*0x10*/ System.Type <ImplementationType>k__BackingField;
            /*0x18*/ System.Type <ElementType>k__BackingField;
            /*0x20*/ System.Collections.Generic.List<System.Type> interfaceTypes;
            /*0x28*/ System.Collections.Generic.List<VContainer.Registration> registrations;

            static /*0x81ec2d4*/ bool Match(System.Type openGenericType);
            /*0x81ec514*/ CollectionInstanceProvider(System.Type elementType);
            /*0x81ec3a0*/ System.Collections.Generic.List.Enumerator<VContainer.Registration> GetEnumerator();
            /*0x81ec414*/ System.Collections.Generic.IEnumerator<VContainer.Registration> System.Collections.Generic.IEnumerable<VContainer.Registration>.GetEnumerator();
            /*0x81ec484*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x81ec4f4*/ System.Type get_ImplementationType();
            /*0x81ec4fc*/ System.Collections.Generic.IReadOnlyList<System.Type> get_InterfaceTypes();
            /*0x81ec504*/ VContainer.Lifetime get_Lifetime();
            /*0x81ec50c*/ System.Type get_ElementType();
            /*0x81ec72c*/ string ToString();
            /*0x81ec814*/ void Add(VContainer.Registration registration);
            /*0x81eca98*/ object SpawnInstance(VContainer.IObjectResolver resolver);
            /*0x81ed014*/ object SpawnInstance(VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.Registration> registrations);
            /*0x81ecb18*/ System.Collections.Generic.List<VContainer.Registration> CollectFromParentScopes(VContainer.IScopedObjectResolver scope, bool localScopeOnly);
        }

        class ContainerInstanceProvider : VContainer.IInstanceProvider
        {
            static /*0x0*/ VContainer.Internal.ContainerInstanceProvider Default;

            static /*0x81ed270*/ ContainerInstanceProvider();
            /*0x81ed268*/ ContainerInstanceProvider();
            /*0x81ed260*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class ContainerLocalInstanceProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ System.Type wrappedType;
            /*0x18*/ VContainer.Registration valueRegistration;

            /*0x81ed2d8*/ ContainerLocalInstanceProvider(System.Type wrappedType, VContainer.Registration valueRegistration);
            /*0x81ed31c*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class ExistingInstanceProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ object implementationInstance;

            /*0x81ed5d8*/ ExistingInstanceProvider(object implementationInstance);
            /*0x81ed608*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class FuncInstanceProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ System.Func<VContainer.IObjectResolver, object> implementationProvider;

            /*0x81ebf38*/ FuncInstanceProvider(System.Func<VContainer.IObjectResolver, object> implementationProvider);
            /*0x81ed610*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class InstanceProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ VContainer.IInjector injector;
            /*0x18*/ System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters;

            /*0x81eb5f4*/ InstanceProvider(VContainer.IInjector injector, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters);
            /*0x81ed634*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class OpenGenericInstanceProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ VContainer.Lifetime lifetime;
            /*0x18*/ System.Type implementationType;
            /*0x20*/ System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters;
            /*0x28*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type[], VContainer.Registration> constructedRegistrations;
            /*0x30*/ System.Func<System.Type[], VContainer.Registration> createRegistrationFunc;

            /*0x81ed6e8*/ OpenGenericInstanceProvider(System.Type implementationType, VContainer.Lifetime lifetime, System.Collections.Generic.List<VContainer.IInjectParameter> injectParameters);
            /*0x81ed840*/ VContainer.Registration GetClosedRegistration(System.Type closedInterfaceType, System.Type[] typeParameters);
            /*0x81ed89c*/ VContainer.Registration CreateRegistration(System.Type[] typeParameters);
            /*0x81eda58*/ object SpawnInstance(VContainer.IObjectResolver resolver);

            class TypeParametersEqualityComparer : System.Collections.Generic.IEqualityComparer<System.Type[]>
            {
                /*0x81ed838*/ TypeParametersEqualityComparer();
                /*0x81eda90*/ bool Equals(System.Type[] x, System.Type[] y);
                /*0x81edb74*/ int GetHashCode(System.Type[] typeParameters);
            }
        }

        class InstanceRegistrationBuilder : VContainer.RegistrationBuilder
        {
            /*0x30*/ object implementationInstance;

            /*0x81edbf0*/ InstanceRegistrationBuilder(object implementationInstance);
            /*0x81edc54*/ VContainer.Registration Build();
        }

        class OpenGenericRegistrationBuilder : VContainer.RegistrationBuilder
        {
            /*0x81eaaac*/ OpenGenericRegistrationBuilder(System.Type implementationType, VContainer.Lifetime lifetime);
            /*0x81edd08*/ VContainer.Registration Build();
            /*0x81eddc4*/ VContainer.RegistrationBuilder AsImplementedInterfaces();
            /*0x81edf58*/ void AddInterfaceType(System.Type interfaceType);
        }

        class ReflectionInjector : VContainer.IInjector
        {
            /*0x10*/ VContainer.Internal.InjectTypeInfo injectTypeInfo;

            static /*0x81ee1e8*/ VContainer.Internal.ReflectionInjector Build(System.Type type);
            /*0x81ee308*/ ReflectionInjector(VContainer.Internal.InjectTypeInfo injectTypeInfo);
            /*0x81ee338*/ void Inject(object instance, VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
            /*0x81ef128*/ object CreateInstance(VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
            /*0x81ee38c*/ void InjectFields(object obj, VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
            /*0x81ee6e8*/ void InjectProperties(object obj, VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
            /*0x81eea44*/ void InjectMethods(object obj, VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
        }

        class RuntimeTypeCache
        {
            static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Type> OpenGenericTypes;
            static /*0x8*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Type[]> GenericTypeParameters;
            static /*0x10*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Type> ArrayTypes;
            static /*0x18*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Type> EnumerableTypes;
            static /*0x20*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Type> ReadOnlyListTypes;

            static /*0x81efb58*/ RuntimeTypeCache();
            static /*0x81ef540*/ System.Type OpenGenericTypeOf(System.Type closedGenericType);
            static /*0x81ef678*/ System.Type[] GenericTypeParametersOf(System.Type closedGenericType);
            static /*0x81ef7b0*/ System.Type ArrayTypeOf(System.Type elementType);
            static /*0x81ef8e8*/ System.Type EnumerableTypeOf(System.Type elementType);
            static /*0x81efa20*/ System.Type ReadOnlyListTypeOf(System.Type elementType);

            class <>c
            {
                static /*0x0*/ VContainer.Internal.RuntimeTypeCache.<> <>9;
                static /*0x8*/ System.Func<System.Type, System.Type> <>9__5_0;
                static /*0x10*/ System.Func<System.Type, System.Type[]> <>9__6_0;
                static /*0x18*/ System.Func<System.Type, System.Type> <>9__7_0;
                static /*0x20*/ System.Func<System.Type, System.Type> <>9__8_0;
                static /*0x28*/ System.Func<System.Type, System.Type> <>9__9_0;

                static /*0x81efcc0*/ <>c();
                /*0x81efd28*/ <>c();
                /*0x81efd30*/ System.Type <OpenGenericTypeOf>b__5_0(System.Type key);
                /*0x81efd58*/ System.Type[] <GenericTypeParametersOf>b__6_0(System.Type key);
                /*0x81efd80*/ System.Type <ArrayTypeOf>b__7_0(System.Type key);
                /*0x81efda8*/ System.Type <EnumerableTypeOf>b__8_0(System.Type key);
                /*0x81efe9c*/ System.Type <ReadOnlyListTypeOf>b__9_0(System.Type key);
            }
        }

        class InjectConstructorInfo
        {
            /*0x10*/ System.Reflection.ConstructorInfo ConstructorInfo;
            /*0x18*/ System.Reflection.ParameterInfo[] ParameterInfos;

            /*0x81eff90*/ InjectConstructorInfo(System.Reflection.ConstructorInfo constructorInfo);
            /*0x81effec*/ InjectConstructorInfo(System.Reflection.ConstructorInfo constructorInfo, System.Reflection.ParameterInfo[] parameterInfos);
        }

        class InjectMethodInfo
        {
            /*0x10*/ System.Reflection.MethodInfo MethodInfo;
            /*0x18*/ System.Reflection.ParameterInfo[] ParameterInfos;

            /*0x81f0030*/ InjectMethodInfo(System.Reflection.MethodInfo methodInfo);
        }

        class InjectTypeInfo
        {
            /*0x10*/ System.Type Type;
            /*0x18*/ VContainer.Internal.InjectConstructorInfo InjectConstructor;
            /*0x20*/ System.Collections.Generic.IReadOnlyList<VContainer.Internal.InjectMethodInfo> InjectMethods;
            /*0x28*/ System.Collections.Generic.IReadOnlyList<System.Reflection.FieldInfo> InjectFields;
            /*0x30*/ System.Collections.Generic.IReadOnlyList<System.Reflection.PropertyInfo> InjectProperties;

            /*0x81f008c*/ InjectTypeInfo(System.Type type, VContainer.Internal.InjectConstructorInfo injectConstructor, System.Collections.Generic.IReadOnlyList<VContainer.Internal.InjectMethodInfo> injectMethods, System.Collections.Generic.IReadOnlyList<System.Reflection.FieldInfo> injectFields, System.Collections.Generic.IReadOnlyList<System.Reflection.PropertyInfo> injectProperties);
        }

        struct DependencyInfo
        {
            /*0x10*/ VContainer.Registration Dependency;
            /*0x18*/ VContainer.Registration owner;
            /*0x20*/ object method;
            /*0x28*/ System.Reflection.ParameterInfo param;

            /*0x81f0154*/ DependencyInfo(VContainer.Registration dependency);
            /*0x81f0198*/ DependencyInfo(VContainer.Registration dependency, VContainer.Registration owner, System.Reflection.ConstructorInfo ctor, System.Reflection.ParameterInfo param);
            /*0x81f01f8*/ DependencyInfo(VContainer.Registration dependency, VContainer.Registration owner, System.Reflection.MethodInfo method, System.Reflection.ParameterInfo param);
            /*0x81f0258*/ DependencyInfo(VContainer.Registration dependency, VContainer.Registration owner, System.Reflection.FieldInfo field);
            /*0x81f02ac*/ DependencyInfo(VContainer.Registration dependency, VContainer.Registration owner, System.Reflection.PropertyInfo prop);
            /*0x81f011c*/ System.Type get_ImplementationType();
            /*0x81f0138*/ VContainer.IInstanceProvider get_Provider();
            /*0x81f0300*/ string ToString();
        }

        class TypeAnalyzer
        {
            static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, VContainer.Internal.InjectTypeInfo> Cache;
            static /*0x8*/ System.Func<System.Type, VContainer.Internal.InjectTypeInfo> AnalyzeFunc;
            [ThreadStatic] static System.Collections.Generic.Stack<VContainer.Internal.DependencyInfo> circularDependencyChecker;

            static /*0x81f22d0*/ TypeAnalyzer();
            static /*0x81ee284*/ VContainer.Internal.InjectTypeInfo AnalyzeWithCache(System.Type type);
            static /*0x81f066c*/ VContainer.Internal.InjectTypeInfo Analyze(System.Type type);
            static /*0x81ea618*/ void CheckCircularDependency(System.Collections.Generic.IReadOnlyList<VContainer.Registration> registrations, VContainer.Internal.Registry registry);
            static /*0x81f1344*/ void CheckCircularDependencyRecursive(VContainer.Internal.DependencyInfo current, VContainer.Internal.Registry registry, System.Collections.Generic.Stack<VContainer.Internal.DependencyInfo> stack);

            class <>c
            {
                static /*0x0*/ VContainer.Internal.TypeAnalyzer.<> <>9;
                static /*0x8*/ System.Func<VContainer.Internal.DependencyInfo, int, string> <>9__6_0;

                static /*0x81f23c8*/ <>c();
                /*0x81f2430*/ <>c();
                /*0x81f2438*/ string <CheckCircularDependencyRecursive>b__6_0(VContainer.Internal.DependencyInfo item, int itemIndex);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ System.Reflection.FieldInfo fieldInfo;

                /*0x81f133c*/ <>c__DisplayClass4_0();
                /*0x81f2518*/ bool <Analyze>b__0(System.Reflection.FieldInfo x);
            }
        }

        class TypeKeyHashTable2<TValue>
        {
            /*0x0*/ VContainer.Internal.TypeKeyHashTable2.Bucket<TValue> buckets;
            /*0x0*/ System.Collections.Generic.KeyValuePair<System.Type, TValue> entries;
            /*0x0*/ int indexFor;
            /*0x0*/ int insertedEntryLength;

            TypeKeyHashTable2(System.Collections.Generic.KeyValuePair<System.Type, TValue> values, float loadFactor);
            /*0x380b32c*/ bool TryGet(System.Type key, ref TValue value);
            /*0x3907c14*/ void Insert(System.Collections.Generic.KeyValuePair<System.Type, TValue> entry, int entryIndex);
            /*0x3907c14*/ void SetBucketAt(int i, VContainer.Internal.TypeKeyHashTable2.Bucket<TValue> bucket);
            /*0x380b6cc*/ int NextBucketIndex(int i);

            struct Bucket<TValue>
            {
                static uint DistOne = 256;
                static uint FingerPrintMask = 255;
                /*0x0*/ uint DistAndFingerPrint;
                /*0x0*/ int EntryIndex;

                static /*0x3834040*/ uint DistAndFingerPrintFromHash(int hash);
            }
        }

        class Registry
        {
            [ThreadStatic] static System.Collections.Generic.IDictionary<System.Type, VContainer.Registration> buildBuffer;
            /*0x10*/ VContainer.Internal.FixedTypeKeyHashtable<VContainer.Registration> hashTable;

            static /*0x81f3228*/ Registry();
            static /*0x81ea14c*/ VContainer.Internal.Registry Build(VContainer.Registration[] registrations);
            static /*0x81f256c*/ void AddToBuildBuffer(System.Collections.Generic.IDictionary<System.Type, VContainer.Registration> buf, System.Type service, VContainer.Registration registration);
            static /*0x81f29d0*/ void AddCollectionToBuildBuffer(System.Collections.Generic.IDictionary<System.Type, VContainer.Registration> buf, VContainer.Registration collectionRegistration);
            /*0x81f29a0*/ Registry(VContainer.Internal.FixedTypeKeyHashtable<VContainer.Registration> hashTable);
            /*0x81e7fd8*/ bool TryGet(System.Type interfaceType, ref VContainer.Registration registration);
            /*0x81f2c64*/ bool TryGetClosedGenericRegistration(System.Type interfaceType, System.Type openGenericType, System.Type[] typeParameters, ref VContainer.Registration registration);
            /*0x81e8624*/ bool Exists(System.Type type);
            /*0x81f3064*/ bool TryFallbackToContainerLocal(System.Type closedGenericType, System.Type openGenericType, System.Collections.Generic.IReadOnlyList<System.Type> typeParameters, ref VContainer.Registration newRegistration);
            /*0x81f2d68*/ bool TryFallbackToSingleElementCollection(System.Type closedGenericType, System.Type openGenericType, System.Collections.Generic.IReadOnlyList<System.Type> typeParameters, ref VContainer.Registration newRegistration);
        }
    }

    namespace Diagnostics
    {
        class DiagnosticsCollector
        {
            /*0x10*/ string <ScopeName>k__BackingField;
            /*0x18*/ System.Collections.Generic.List<VContainer.Diagnostics.DiagnosticsInfo> diagnosticsInfos;
            /*0x20*/ System.Threading.ThreadLocal<System.Collections.Generic.Stack<VContainer.Diagnostics.DiagnosticsInfo>> resolveCallStack;

            /*0x81f32cc*/ DiagnosticsCollector(string scopeName);
            /*0x81f32c4*/ string get_ScopeName();
            /*0x81f3464*/ System.Collections.Generic.IReadOnlyList<VContainer.Diagnostics.DiagnosticsInfo> GetDiagnosticsInfos();
            /*0x81e8180*/ void Clear();
            /*0x81f346c*/ void TraceRegister(VContainer.Diagnostics.RegisterInfo registerInfo);
            /*0x81e9e94*/ void TraceBuild(VContainer.RegistrationBuilder registrationBuilder, VContainer.Registration registration);
            /*0x81e7908*/ object TraceResolve(VContainer.Registration registration, System.Func<VContainer.Registration, object> resolving);
            /*0x81ea8b4*/ void NotifyContainerBuilt(VContainer.IObjectResolver container);

            class <>c
            {
                static /*0x0*/ VContainer.Diagnostics.DiagnosticsCollector.<> <>9;
                static /*0x8*/ System.Func<System.Collections.Generic.Stack<VContainer.Diagnostics.DiagnosticsInfo>> <>9__5_0;

                static /*0x81f38dc*/ <>c();
                /*0x81f3944*/ <>c();
                /*0x81f394c*/ System.Collections.Generic.Stack<VContainer.Diagnostics.DiagnosticsInfo> <.ctor>b__5_0();
            }
        }

        class DiagnositcsContext
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<string, VContainer.Diagnostics.DiagnosticsCollector> collectors;
            static /*0x8*/ System.Action<VContainer.IObjectResolver> OnContainerBuilt;

            static /*0x81f432c*/ DiagnositcsContext();
            static /*0x81f39b4*/ void add_OnContainerBuilt(System.Action<VContainer.IObjectResolver> value);
            static /*0x81f3aa8*/ void remove_OnContainerBuilt(System.Action<VContainer.IObjectResolver> value);
            static /*0x81f3b9c*/ VContainer.Diagnostics.DiagnosticsCollector GetCollector(string name);
            static /*0x81f3d7c*/ System.Linq.ILookup<string, VContainer.Diagnostics.DiagnosticsInfo> GetGroupedDiagnosticsInfos();
            static /*0x81f411c*/ System.Collections.Generic.IEnumerable<VContainer.Diagnostics.DiagnosticsInfo> GetDiagnosticsInfos();
            static /*0x81f3860*/ void NotifyContainerBuilt(VContainer.IObjectResolver container);
            static /*0x81f3750*/ VContainer.Diagnostics.DiagnosticsInfo FindByRegistration(VContainer.Registration registration);

            class <>c
            {
                static /*0x0*/ VContainer.Diagnostics.DiagnositcsContext.<> <>9;
                static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<string, VContainer.Diagnostics.DiagnosticsCollector>, System.Collections.Generic.IEnumerable<VContainer.Diagnostics.DiagnosticsInfo>> <>9__5_0;
                static /*0x10*/ System.Func<VContainer.Diagnostics.DiagnosticsInfo, bool> <>9__5_1;
                static /*0x18*/ System.Func<VContainer.Diagnostics.DiagnosticsInfo, string> <>9__5_2;
                static /*0x20*/ System.Func<System.Collections.Generic.KeyValuePair<string, VContainer.Diagnostics.DiagnosticsCollector>, System.Collections.Generic.IEnumerable<VContainer.Diagnostics.DiagnosticsInfo>> <>9__6_0;

                static /*0x81f43c4*/ <>c();
                /*0x81f442c*/ <>c();
                /*0x81f4434*/ System.Collections.Generic.IEnumerable<VContainer.Diagnostics.DiagnosticsInfo> <GetGroupedDiagnosticsInfos>b__5_0(System.Collections.Generic.KeyValuePair<string, VContainer.Diagnostics.DiagnosticsCollector> x);
                /*0x81f4478*/ bool <GetGroupedDiagnosticsInfos>b__5_1(VContainer.Diagnostics.DiagnosticsInfo x);
                /*0x81f44a0*/ string <GetGroupedDiagnosticsInfos>b__5_2(VContainer.Diagnostics.DiagnosticsInfo x);
                /*0x81f44b8*/ System.Collections.Generic.IEnumerable<VContainer.Diagnostics.DiagnosticsInfo> <GetDiagnosticsInfos>b__6_0(System.Collections.Generic.KeyValuePair<string, VContainer.Diagnostics.DiagnosticsCollector> x);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ VContainer.Registration registration;

                /*0x81f4324*/ <>c__DisplayClass8_0();
                /*0x81f44fc*/ bool <FindByRegistration>b__0(VContainer.Diagnostics.DiagnosticsInfo x);
            }
        }

        class DiagnosticsInfo
        {
            /*0x10*/ string <ScopeName>k__BackingField;
            /*0x18*/ VContainer.Diagnostics.RegisterInfo <RegisterInfo>k__BackingField;
            /*0x20*/ VContainer.Diagnostics.ResolveInfo <ResolveInfo>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<VContainer.Diagnostics.DiagnosticsInfo> <Dependencies>k__BackingField;

            /*0x81f35f4*/ DiagnosticsInfo(string scopeName, VContainer.Diagnostics.RegisterInfo registerInfo);
            /*0x81f4528*/ string get_ScopeName();
            /*0x81f4530*/ VContainer.Diagnostics.RegisterInfo get_RegisterInfo();
            /*0x81f4538*/ VContainer.Diagnostics.ResolveInfo get_ResolveInfo();
            /*0x81f4540*/ void set_ResolveInfo(VContainer.Diagnostics.ResolveInfo value);
            /*0x81f4548*/ System.Collections.Generic.List<VContainer.Diagnostics.DiagnosticsInfo> get_Dependencies();
        }

        class RegisterInfo
        {
            static /*0x0*/ bool displayFileNames;
            static /*0x4*/ int idSeed;
            /*0x10*/ int <Id>k__BackingField;
            /*0x18*/ VContainer.RegistrationBuilder <RegistrationBuilder>k__BackingField;
            /*0x20*/ System.Diagnostics.StackTrace <StackTrace>k__BackingField;
            /*0x28*/ System.Diagnostics.StackFrame headLineStackFrame;
            /*0x30*/ string formattedStackTrace;

            static /*0x81f4edc*/ RegisterInfo();
            /*0x81f4568*/ RegisterInfo(VContainer.RegistrationBuilder registrationBuilder);
            /*0x81f4550*/ int get_Id();
            /*0x81f4558*/ VContainer.RegistrationBuilder get_RegistrationBuilder();
            /*0x81f4560*/ System.Diagnostics.StackTrace get_StackTrace();
            /*0x81f4804*/ string GetFilename();
            /*0x81f4970*/ int GetFileLineNumber();
            /*0x81f4ad0*/ string GetScriptAssetPath();
            /*0x81f4b64*/ string GetHeadline();
            /*0x81f464c*/ System.Diagnostics.StackFrame GetHeadlineFrame(System.Diagnostics.StackTrace stackTrace);
        }

        class ResolveInfo
        {
            /*0x10*/ VContainer.Registration <Registration>k__BackingField;
            /*0x18*/ System.Collections.Generic.List<object> <Instances>k__BackingField;
            /*0x20*/ int <MaxDepth>k__BackingField;
            /*0x24*/ int <RefCount>k__BackingField;

            /*0x81f36ac*/ ResolveInfo(VContainer.Registration registration);
            /*0x81f4f28*/ VContainer.Registration get_Registration();
            /*0x81f4f30*/ System.Collections.Generic.List<object> get_Instances();
            /*0x81f4f38*/ int get_MaxDepth();
            /*0x81f4f40*/ void set_MaxDepth(int value);
            /*0x81f4f48*/ int get_RefCount();
            /*0x81f4f50*/ void set_RefCount(int value);
        }
    }

    namespace Unity
    {
        interface IAsyncStartable
        {
            /*0x380c9d4*/ Cysharp.Threading.Tasks.UniTask StartAsync(System.Threading.CancellationToken cancellation);
        }

        interface IFixedTickable
        {
            /*0x380cb08*/ void FixedTick();
        }

        interface IInitializable
        {
            /*0x380cb08*/ void Initialize();
        }

        interface ILateTickable
        {
            /*0x380cb08*/ void LateTick();
        }

        interface IPostFixedTickable
        {
            /*0x380cb08*/ void PostFixedTick();
        }

        interface IPostInitializable
        {
            /*0x380cb08*/ void PostInitialize();
        }

        interface IPostLateTickable
        {
            /*0x380cb08*/ void PostLateTick();
        }

        interface IPostStartable
        {
            /*0x380cb08*/ void PostStart();
        }

        interface IPostTickable
        {
            /*0x380cb08*/ void PostTick();
        }

        interface IStartable
        {
            /*0x380cb08*/ void Start();
        }

        interface ITickable
        {
            /*0x380cb08*/ void Tick();
        }

        class ActionInstaller : VContainer.Unity.IInstaller
        {
            /*0x10*/ System.Action<VContainer.IContainerBuilder> configuration;

            static /*0x81f4f58*/ VContainer.Unity.ActionInstaller op_Implicit(System.Action<VContainer.IContainerBuilder> installation);
            /*0x81f4fc0*/ ActionInstaller(System.Action<VContainer.IContainerBuilder> configuration);
            /*0x81f4ff0*/ void Install(VContainer.IContainerBuilder builder);
        }

        struct ComponentDestination
        {
            /*0x10*/ UnityEngine.Transform Parent;
            /*0x18*/ System.Func<VContainer.IObjectResolver, UnityEngine.Transform> ParentFinder;
            /*0x20*/ bool DontDestroyOnLoad;

            /*0x81f5014*/ UnityEngine.Transform GetParent(VContainer.IObjectResolver resolver);
            /*0x81f50bc*/ void ApplyDontDestroyOnLoadIfNeeded(UnityEngine.Component component);
        }

        class ComponentRegistrationBuilder : VContainer.RegistrationBuilder
        {
            /*0x30*/ object instance;
            /*0x38*/ System.Func<VContainer.IObjectResolver, UnityEngine.Component> prefabFinder;
            /*0x40*/ string gameObjectName;
            /*0x48*/ VContainer.Unity.ComponentDestination destination;
            /*0x60*/ UnityEngine.SceneManagement.Scene scene;

            /*0x81f512c*/ ComponentRegistrationBuilder(object instance);
            /*0x81f5190*/ ComponentRegistrationBuilder(ref UnityEngine.SceneManagement.Scene scene, System.Type implementationType);
            /*0x81f51d8*/ ComponentRegistrationBuilder(System.Func<VContainer.IObjectResolver, UnityEngine.Component> prefabFinder, System.Type implementationType, VContainer.Lifetime lifetime);
            /*0x81f522c*/ ComponentRegistrationBuilder(string gameObjectName, System.Type implementationType, VContainer.Lifetime lifetime);
            /*0x81f5280*/ VContainer.Registration Build();
            /*0x81f5694*/ VContainer.Unity.ComponentRegistrationBuilder UnderTransform(UnityEngine.Transform parent);
            /*0x81f56b0*/ VContainer.Unity.ComponentRegistrationBuilder UnderTransform(System.Func<UnityEngine.Transform> parentFinder);
            /*0x81f5788*/ VContainer.Unity.ComponentRegistrationBuilder UnderTransform(System.Func<VContainer.IObjectResolver, UnityEngine.Transform> parentFinder);
            /*0x81f57a4*/ VContainer.Unity.ComponentRegistrationBuilder DontDestroyOnLoad();

            class <>c__DisplayClass11_0
            {
                /*0x10*/ System.Func<UnityEngine.Transform> parentFinder;

                /*0x81f5780*/ <>c__DisplayClass11_0();
                /*0x81f57b0*/ UnityEngine.Transform <UnderTransform>b__0(VContainer.IObjectResolver _);
            }
        }

        struct EntryPointsBuilder
        {
            /*0x10*/ VContainer.IContainerBuilder containerBuilder;
            /*0x18*/ VContainer.Lifetime lifetime;

            static /*0x81f57d4*/ void EnsureDispatcherRegistered(VContainer.IContainerBuilder containerBuilder);
            /*0x81f5a3c*/ EntryPointsBuilder(VContainer.IContainerBuilder containerBuilder, VContainer.Lifetime lifetime);
            /*0x380b9e8*/ VContainer.RegistrationBuilder Add<T>();
            /*0x81f5a64*/ void OnException(System.Action<System.Exception> exceptionHandler);

            class <>c
            {
                static /*0x0*/ VContainer.Unity.EntryPointsBuilder.<> <>9;
                static /*0x8*/ System.Action<VContainer.IObjectResolver> <>9__0_0;

                static /*0x81f5afc*/ <>c();
                /*0x81f5b64*/ <>c();
                /*0x81f5b6c*/ void <EnsureDispatcherRegistered>b__0_0(VContainer.IObjectResolver container);
            }
        }

        struct ComponentsBuilder
        {
            /*0x10*/ VContainer.IContainerBuilder containerBuilder;
            /*0x18*/ UnityEngine.Transform parentTransform;

            /*0x81f6b60*/ ComponentsBuilder(VContainer.IContainerBuilder containerBuilder, UnityEngine.Transform parentTransform);
            /*0x3907c14*/ VContainer.RegistrationBuilder AddInstance<TInterface>(TInterface component);
            /*0x380b9e8*/ VContainer.Unity.ComponentRegistrationBuilder AddInHierarchy<T>();
            VContainer.Unity.ComponentRegistrationBuilder AddOnNewGameObject<T>(VContainer.Lifetime lifetime, string newGameObjectName);
            /*0x3907c14*/ VContainer.Unity.ComponentRegistrationBuilder AddInNewPrefab<T>(T prefab, VContainer.Lifetime lifetime);
        }

        class ContainerBuilderUnityExtensions
        {
            static /*0x81f6b90*/ void UseEntryPoints(VContainer.IContainerBuilder builder, System.Action<VContainer.Unity.EntryPointsBuilder> configuration);
            static /*0x81f6b9c*/ void UseEntryPoints(VContainer.IContainerBuilder builder, VContainer.Lifetime lifetime, System.Action<VContainer.Unity.EntryPointsBuilder> configuration);
            static /*0x81f6bf8*/ void UseComponents(VContainer.IContainerBuilder builder, System.Action<VContainer.Unity.ComponentsBuilder> configuration);
            static /*0x81f6c5c*/ void UseComponents(VContainer.IContainerBuilder builder, UnityEngine.Transform root, System.Action<VContainer.Unity.ComponentsBuilder> configuration);
            static /*0x38301ec*/ VContainer.RegistrationBuilder RegisterEntryPoint<T>(VContainer.IContainerBuilder builder, VContainer.Lifetime lifetime);
            static /*0x81f5a6c*/ void RegisterEntryPointExceptionHandler(VContainer.IContainerBuilder builder, System.Action<System.Exception> exceptionHandler);
            static /*0x3907c14*/ VContainer.RegistrationBuilder RegisterComponent<TInterface>(VContainer.IContainerBuilder builder, TInterface component);
            static /*0x81f6cf4*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentInHierarchy(VContainer.IContainerBuilder builder, System.Type type);
            static /*0x382eaf0*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentInHierarchy<T>(VContainer.IContainerBuilder builder);
            static /*0x81f6fcc*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentOnNewGameObject(VContainer.IContainerBuilder builder, System.Type type, VContainer.Lifetime lifetime, string newGameObjectName);
            static /*0x383030c*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentOnNewGameObject<T>(VContainer.IContainerBuilder builder, VContainer.Lifetime lifetime, string newGameObjectName);
            static /*0x81f70d0*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentInNewPrefab(VContainer.IContainerBuilder builder, System.Type interfaceType, UnityEngine.Component prefab, VContainer.Lifetime lifetime);
            static /*0x3907c14*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentInNewPrefab<T>(VContainer.IContainerBuilder builder, T prefab, VContainer.Lifetime lifetime);
            static /*0x383094c*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentInNewPrefab<T>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, T> prefab, VContainer.Lifetime lifetime);
            static /*0x383094c*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentInNewPrefab<TInterface, TImplement>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, TImplement> prefab, VContainer.Lifetime lifetime);

            class <>c__6<TInterface>
            {
                static /*0x0*/ VContainer.Unity.ContainerBuilderUnityExtensions.<>c__6<TInterface> <>9;
                static /*0x0*/ System.Action<VContainer.IObjectResolver> <>9__6_0;

                static /*0x38358cc*/ <>c__6();
                /*0x380cb08*/ <>c__6();
                /*0x380d83c*/ void <RegisterComponent>b__6_0(VContainer.IObjectResolver container);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.Component prefab;

                /*0x81f7298*/ <>c__DisplayClass11_0();
                /*0x81f72a0*/ UnityEngine.Component <RegisterComponentInNewPrefab>b__0(VContainer.IObjectResolver _);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ VContainer.Unity.ComponentRegistrationBuilder registrationBuilder;

                /*0x81f6fc4*/ <>c__DisplayClass7_0();
                /*0x81f72a8*/ void <RegisterComponentInHierarchy>b__0(VContainer.IObjectResolver container);
            }
        }

        class AsyncLoopItem : VContainer.Unity.IPlayerLoopItem
        {
            /*0x10*/ System.Action action;

            /*0x81f738c*/ AsyncLoopItem(System.Action action);
            /*0x81f73bc*/ bool MoveNext();
        }

        class EntryPointDispatcher : System.IDisposable
        {
            /*0x10*/ VContainer.IObjectResolver container;
            /*0x18*/ VContainer.Internal.CompositeDisposable disposable;

            /*0x81f73e8*/ EntryPointDispatcher(VContainer.IObjectResolver container);
            /*0x81f5bc0*/ void Dispatch();
            /*0x81f8208*/ void Dispose();
        }

        class EntryPointExceptionHandler
        {
            /*0x10*/ System.Action<System.Exception> handler;

            /*0x81f6cc4*/ EntryPointExceptionHandler(System.Action<System.Exception> handler);
            /*0x81f7e94*/ void Publish(System.Exception ex);
        }

        interface IInstaller
        {
            /*0x380d83c*/ void Install(VContainer.IContainerBuilder builder);
        }

        class ExistingComponentProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ object instance;
            /*0x18*/ VContainer.IInjector injector;
            /*0x20*/ System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters;
            /*0x28*/ bool dontDestroyOnLoad;

            /*0x81f5494*/ ExistingComponentProvider(object instance, VContainer.IInjector injector, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters, bool dontDestroyOnLoad);
            /*0x81f8220*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class FindComponentProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ System.Type componentType;
            /*0x18*/ System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters;
            /*0x20*/ VContainer.Unity.ComponentDestination destination;
            /*0x38*/ UnityEngine.SceneManagement.Scene scene;

            /*0x81f5500*/ FindComponentProvider(System.Type componentType, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters, ref UnityEngine.SceneManagement.Scene scene, ref VContainer.Unity.ComponentDestination destination);
            /*0x81f8408*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class NewGameObjectProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ System.Type componentType;
            /*0x18*/ VContainer.IInjector injector;
            /*0x20*/ System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters;
            /*0x28*/ string newGameObjectName;
            /*0x30*/ VContainer.Unity.ComponentDestination destination;

            /*0x81f55f8*/ NewGameObjectProvider(System.Type componentType, VContainer.IInjector injector, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters, ref VContainer.Unity.ComponentDestination destination, string newGameObjectName);
            /*0x81f88bc*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class PrefabComponentProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ VContainer.IInjector injector;
            /*0x18*/ System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters;
            /*0x20*/ System.Func<VContainer.IObjectResolver, UnityEngine.Component> prefabFinder;
            /*0x28*/ VContainer.Unity.ComponentDestination destination;

            /*0x81f5578*/ PrefabComponentProvider(System.Func<VContainer.IObjectResolver, UnityEngine.Component> prefabFinder, VContainer.IInjector injector, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters, ref VContainer.Unity.ComponentDestination destination);
            /*0x81f8a9c*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class VContainerParentTypeReferenceNotFound : System.Exception
        {
            /*0x90*/ System.Type ParentType;

            /*0x81f8dbc*/ VContainerParentTypeReferenceNotFound(System.Type parentType, string message);
        }

        class LifetimeScope : UnityEngine.MonoBehaviour, System.IDisposable
        {
            static /*0x0*/ System.Collections.Generic.List<VContainer.Unity.LifetimeScope> WaitingList;
            static /*0x8*/ System.Collections.Generic.Stack<VContainer.Unity.LifetimeScope> GlobalOverrideParents;
            static /*0x10*/ System.Collections.Generic.Stack<VContainer.Unity.IInstaller> GlobalExtraInstallers;
            static /*0x18*/ object SyncRoot;
            /*0x20*/ VContainer.Unity.ParentReference parentReference;
            /*0x38*/ bool autoRun;
            /*0x40*/ System.Collections.Generic.List<UnityEngine.GameObject> autoInjectGameObjects;
            /*0x48*/ VContainer.IObjectResolver <Container>k__BackingField;
            /*0x50*/ VContainer.Unity.LifetimeScope <Parent>k__BackingField;
            /*0x58*/ bool <IsRoot>k__BackingField;
            /*0x60*/ System.Collections.Generic.List<VContainer.Unity.IInstaller> localExtraInstallers;

            static /*0x81fb3a8*/ LifetimeScope();
            static /*0x81f8e38*/ void SubscribeSceneEvents();
            static /*0x81f8f00*/ void EnqueueAwake(VContainer.Unity.LifetimeScope lifetimeScope);
            static /*0x81f8fd4*/ void CancelAwake(VContainer.Unity.LifetimeScope lifetimeScope);
            static /*0x81f9054*/ void AwakeWaitingChildren(VContainer.Unity.LifetimeScope awakenParent);
            static /*0x81f93d0*/ void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            static /*0x81f9718*/ VContainer.Unity.LifetimeScope Create(VContainer.Unity.IInstaller installer);
            static /*0x81f985c*/ VContainer.Unity.LifetimeScope Create(System.Action<VContainer.IContainerBuilder> configuration);
            static /*0x81f98f0*/ VContainer.Unity.LifetimeScope.ParentOverrideScope EnqueueParent(VContainer.Unity.LifetimeScope parent);
            static /*0x81f9a48*/ VContainer.Unity.LifetimeScope.ExtraInstallationScope Enqueue(System.Action<VContainer.IContainerBuilder> installing);
            static /*0x81f9bf8*/ VContainer.Unity.LifetimeScope.ExtraInstallationScope Enqueue(VContainer.Unity.IInstaller installer);
            static /*0x81f9c10*/ VContainer.Unity.LifetimeScope.ParentOverrideScope PushParent(VContainer.Unity.LifetimeScope parent);
            static /*0x81f9c28*/ VContainer.Unity.LifetimeScope.ExtraInstallationScope Push(System.Action<VContainer.IContainerBuilder> installing);
            static /*0x81f9c84*/ VContainer.Unity.LifetimeScope.ExtraInstallationScope Push(VContainer.Unity.IInstaller installer);
            static /*0x3907c14*/ VContainer.Unity.LifetimeScope Find<T>(UnityEngine.SceneManagement.Scene scene);
            static /*0x382dee4*/ VContainer.Unity.LifetimeScope Find<T>();
            static /*0x81f9ce0*/ VContainer.Unity.LifetimeScope Find(System.Type type, UnityEngine.SceneManagement.Scene scene);
            static /*0x81f9f2c*/ VContainer.Unity.LifetimeScope Find(System.Type type);
            /*0x81fb318*/ LifetimeScope();
            /*0x81f9fd0*/ VContainer.IObjectResolver get_Container();
            /*0x81f9fd8*/ void set_Container(VContainer.IObjectResolver value);
            /*0x81f9fe0*/ VContainer.Unity.LifetimeScope get_Parent();
            /*0x81f9fe8*/ void set_Parent(VContainer.Unity.LifetimeScope value);
            /*0x81f9ff0*/ bool get_IsRoot();
            /*0x81f9ff8*/ void set_IsRoot(bool value);
            /*0x81fa004*/ void Awake();
            /*0x81fa900*/ void OnDestroy();
            /*0x81fa9e8*/ void Configure(VContainer.IContainerBuilder builder);
            /*0x81fa9ec*/ void Dispose();
            /*0x81fa904*/ void DisposeCore();
            /*0x81fa50c*/ void Build();
            /*0x81fb058*/ void SetContainer(VContainer.IObjectResolver container);
            /*0x3907c14*/ TScope CreateChild<TScope>(VContainer.Unity.IInstaller installer);
            /*0x81fb1fc*/ VContainer.Unity.LifetimeScope CreateChild(VContainer.Unity.IInstaller installer);
            /*0x3907c14*/ TScope CreateChild<TScope>(System.Action<VContainer.IContainerBuilder> installation);
            /*0x81fb254*/ VContainer.Unity.LifetimeScope CreateChild(System.Action<VContainer.IContainerBuilder> installation);
            /*0x3907c14*/ TScope CreateChildFromPrefab<TScope>(TScope prefab, VContainer.Unity.IInstaller installer);
            /*0x3907c14*/ TScope CreateChildFromPrefab<TScope>(TScope prefab, System.Action<VContainer.IContainerBuilder> installation);
            /*0x81fab68*/ void InstallTo(VContainer.IContainerBuilder builder);
            /*0x81fa134*/ VContainer.Unity.LifetimeScope GetRuntimeParent();
            /*0x81fb074*/ void AutoInjectAll();
            /*0x81fb52c*/ void <Build>b__44_0(VContainer.IContainerBuilder builder);

            struct ParentOverrideScope : System.IDisposable
            {
                /*0x81f9908*/ ParentOverrideScope(VContainer.Unity.LifetimeScope nextParent);
                /*0x81fb740*/ void Dispose();
            }

            struct ExtraInstallationScope : System.IDisposable
            {
                /*0x81f9ab8*/ ExtraInstallationScope(VContainer.Unity.IInstaller installer);
                /*0x81fb87c*/ void System.IDisposable.Dispose();
            }
        }

        class ObjectResolverUnityExtensions
        {
            static /*0x81fb2e4*/ void InjectGameObject(VContainer.IObjectResolver resolver, UnityEngine.GameObject gameObject);
            static /*0x3907c14*/ T Instantiate<T>(VContainer.IObjectResolver resolver, T prefab);
            static /*0x3907c14*/ T Instantiate<T>(VContainer.IObjectResolver resolver, T prefab, UnityEngine.Transform parent, bool worldPositionStays);
            static /*0x3907c14*/ T Instantiate<T>(VContainer.IObjectResolver resolver, T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
            static /*0x3907c14*/ T Instantiate<T>(VContainer.IObjectResolver resolver, T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
            static /*0x3907c14*/ T Instantiate<T>(VContainer.Unity.LifetimeScope scope, T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
            static /*0x81fbdcc*/ UnityEngine.GameObject Instantiate(VContainer.Unity.LifetimeScope scope, UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
            static /*0x81fc144*/ UnityEngine.GameObject Instantiate(VContainer.IObjectResolver resolver, UnityEngine.GameObject prefab);
            static /*0x81fc370*/ UnityEngine.GameObject Instantiate(VContainer.IObjectResolver resolver, UnityEngine.GameObject prefab, UnityEngine.Transform parent, bool worldPositionStays);
            static /*0x81fc1e8*/ UnityEngine.GameObject Instantiate(VContainer.IObjectResolver resolver, UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
            static /*0x81fc488*/ UnityEngine.GameObject Instantiate(VContainer.IObjectResolver resolver, UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
            static /*0x81fc038*/ void SetName(UnityEngine.Object instance, UnityEngine.Object prefab);
            static /*0x81fb9b8*/ void <InjectGameObject>g__InjectGameObjectRecursive|0_0(UnityEngine.GameObject current, ref VContainer.Unity.ObjectResolverUnityExtensions.<> );

            struct <>c__DisplayClass0_0
            {
                /*0x10*/ VContainer.IObjectResolver resolver;
            }
        }

        struct ParentReference : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ string TypeName;
            /*0x18*/ VContainer.Unity.LifetimeScope Object;
            /*0x20*/ System.Type <Type>k__BackingField;

            static /*0x3907c14*/ VContainer.Unity.ParentReference Create<T>();
            /*0x81fc67c*/ ParentReference(System.Type type);
            /*0x81fc66c*/ System.Type get_Type();
            /*0x81fc674*/ void set_Type(System.Type value);
            /*0x81fc6d8*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x81fc714*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
        }

        struct VContainerInitialization
        {
        }

        struct VContainerPostInitialization
        {
        }

        struct VContainerStartup
        {
        }

        struct VContainerPostStartup
        {
        }

        struct VContainerFixedUpdate
        {
        }

        struct VContainerPostFixedUpdate
        {
        }

        struct VContainerUpdate
        {
        }

        struct VContainerPostUpdate
        {
        }

        struct VContainerLateUpdate
        {
        }

        struct VContainerPostLateUpdate
        {
        }

        enum PlayerLoopTiming
        {
            Initialization = 0,
            PostInitialization = 1,
            Startup = 2,
            PostStartup = 3,
            FixedUpdate = 4,
            PostFixedUpdate = 5,
            Update = 6,
            PostUpdate = 7,
            LateUpdate = 8,
            PostLateUpdate = 9,
        }

        class PlayerLoopHelper
        {
            static /*0x0*/ VContainer.Unity.PlayerLoopRunner[] Runners;
            static /*0x8*/ long initialized;

            static /*0x81fcf4c*/ PlayerLoopHelper();
            static /*0x81f746c*/ void EnsureInitialized();
            static /*0x81f7efc*/ void Dispatch(VContainer.Unity.PlayerLoopTiming timing, VContainer.Unity.IPlayerLoopItem item);
            static /*0x81fc904*/ ref UnityEngine.LowLevel.PlayerLoopSystem FindSubSystem(System.Type targetType, UnityEngine.LowLevel.PlayerLoopSystem[] systems);
            static /*0x81fca28*/ void InsertSubsystem(ref UnityEngine.LowLevel.PlayerLoopSystem parentSystem, System.Type beforeType, UnityEngine.LowLevel.PlayerLoopSystem newSystem, UnityEngine.LowLevel.PlayerLoopSystem newPostSystem);
        }

        class StartableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IEnumerable<VContainer.Unity.IStartable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x81f7eb8*/ StartableLoopItem(System.Collections.Generic.IEnumerable<VContainer.Unity.IStartable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x81fcfc0*/ bool MoveNext();
            /*0x81fd3e0*/ void Dispose();
        }

        class PostStartableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IEnumerable<VContainer.Unity.IPostStartable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x81f7f90*/ PostStartableLoopItem(System.Collections.Generic.IEnumerable<VContainer.Unity.IPostStartable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x81fd3ec*/ bool MoveNext();
            /*0x81fd80c*/ void Dispose();
        }

        class FixedTickableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IReadOnlyList<VContainer.Unity.IFixedTickable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x81f7fd4*/ FixedTickableLoopItem(System.Collections.Generic.IReadOnlyList<VContainer.Unity.IFixedTickable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x81fd818*/ bool MoveNext();
            /*0x81fda9c*/ void Dispose();
        }

        class PostFixedTickableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IReadOnlyList<VContainer.Unity.IPostFixedTickable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x81f8018*/ PostFixedTickableLoopItem(System.Collections.Generic.IReadOnlyList<VContainer.Unity.IPostFixedTickable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x81fdaa8*/ bool MoveNext();
            /*0x81fdd2c*/ void Dispose();
        }

        class TickableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IReadOnlyList<VContainer.Unity.ITickable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x81f805c*/ TickableLoopItem(System.Collections.Generic.IReadOnlyList<VContainer.Unity.ITickable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x81fdd38*/ bool MoveNext();
            /*0x81fdfbc*/ void Dispose();
        }

        class PostTickableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IReadOnlyList<VContainer.Unity.IPostTickable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x81f80a0*/ PostTickableLoopItem(System.Collections.Generic.IReadOnlyList<VContainer.Unity.IPostTickable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x81fdfc8*/ bool MoveNext();
            /*0x81fe24c*/ void Dispose();
        }

        class LateTickableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IReadOnlyList<VContainer.Unity.ILateTickable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x81f80e4*/ LateTickableLoopItem(System.Collections.Generic.IReadOnlyList<VContainer.Unity.ILateTickable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x81fe258*/ bool MoveNext();
            /*0x81fe4dc*/ void Dispose();
        }

        class PostLateTickableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IReadOnlyList<VContainer.Unity.IPostLateTickable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x81f8128*/ PostLateTickableLoopItem(System.Collections.Generic.IReadOnlyList<VContainer.Unity.IPostLateTickable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x81fe4e8*/ bool MoveNext();
            /*0x81fe76c*/ void Dispose();
        }

        class AsyncStartableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IEnumerable<VContainer.Unity.IAsyncStartable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ System.Threading.CancellationTokenSource cts;
            /*0x28*/ bool disposed;

            /*0x81f816c*/ AsyncStartableLoopItem(System.Collections.Generic.IEnumerable<VContainer.Unity.IAsyncStartable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x81fe778*/ bool MoveNext();
            /*0x81feb90*/ void Dispose();
            /*0x81fec9c*/ void <MoveNext>b__5_0(System.Exception ex);
        }

        interface IPlayerLoopItem
        {
            /*0x380b128*/ bool MoveNext();
        }

        class PlayerLoopRunner
        {
            /*0x10*/ System.Collections.Generic.Queue<VContainer.Unity.IPlayerLoopItem> runningQueue;
            /*0x18*/ System.Collections.Generic.Queue<VContainer.Unity.IPlayerLoopItem> waitingQueue;
            /*0x20*/ object runningGate;
            /*0x28*/ object waitingGate;
            /*0x30*/ int running;

            /*0x81fc7fc*/ PlayerLoopRunner();
            /*0x81fcd64*/ void Dispatch(VContainer.Unity.IPlayerLoopItem item);
            /*0x81fecc8*/ void Run();
        }

        class UnityEngineObjectListBuffer<T>
        {
            static int DefaultCapacity = 32;
            [ThreadStatic] static System.Collections.Generic.Stack<System.Collections.Generic.List<T>> _pool;

            static /*0x38358cc*/ UnityEngineObjectListBuffer();
            static /*0x382dee4*/ System.Collections.Generic.List<T> Get();
            static /*0x3907c14*/ VContainer.Unity.UnityEngineObjectListBuffer.BufferScope<T> Get(ref System.Collections.Generic.List<T> buffer);
            static /*0x3837da0*/ void Release(System.Collections.Generic.List<T> buffer);

            struct BufferScope<T> : System.IDisposable
            {
                /*0x0*/ System.Collections.Generic.List<T> _buffer;

                /*0x380d83c*/ BufferScope(System.Collections.Generic.List<T> buffer);
                /*0x380cb08*/ void Dispose();
            }
        }

        class VContainerSettings : UnityEngine.ScriptableObject
        {
            static /*0x0*/ VContainer.Unity.VContainerSettings <Instance>k__BackingField;
            /*0x18*/ VContainer.Unity.LifetimeScope RootLifetimeScope;
            /*0x20*/ bool EnableDiagnostics;
            /*0x21*/ bool DisableScriptModifier;
            /*0x22*/ bool RemoveClonePostfix;

            static /*0x81ff284*/ VContainer.Unity.VContainerSettings get_Instance();
            static /*0x81ff2cc*/ void set_Instance(VContainer.Unity.VContainerSettings value);
            static /*0x81faa90*/ bool get_DiagnosticsEnabled();
            /*0x81ff7ac*/ VContainerSettings();
            /*0x81ff324*/ void OnEnable();
            /*0x81ff584*/ void OnFirstSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            /*0x81ff67c*/ void OnApplicationQuit();
            /*0x81ff7b4*/ void <OnApplicationQuit>b__12_0();
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 13250F70B0956417A82A64BDC1B278C1ACD5CC4E8BB2D5FC6124E79A33EF7B19;
    static /*0x1d49*/ <PrivateImplementationDetails> 8E84F57E41D3CFAD00295D0D5E28965F11C30920D959DE405277D87CA888B0AE;

    struct __StaticArrayInitTypeSize=4603
    {
    }

    struct __StaticArrayInitTypeSize=7497
    {
    }
}
