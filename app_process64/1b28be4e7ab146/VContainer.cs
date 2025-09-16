class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x81fe89c*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x81fe990*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

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
        /*0x81fe998*/ PreserveAttribute();
    }

    class InjectAttribute : VContainer.PreserveAttribute
    {
        /*0x81fe9a0*/ InjectAttribute();
    }

    class InjectIgnoreAttribute : System.Attribute
    {
        /*0x81fe9a8*/ InjectIgnoreAttribute();
    }

    interface IObjectResolver : System.IDisposable
    {
        /*0x38148bc*/ object get_ApplicationOrigin();
        /*0x38148bc*/ VContainer.Diagnostics.DiagnosticsCollector get_Diagnostics();
        /*0x3816710*/ void set_Diagnostics(VContainer.Diagnostics.DiagnosticsCollector value);
        /*0x3814a3c*/ object Resolve(System.Type type);
        /*0x3814a3c*/ object Resolve(VContainer.Registration registration);
        /*0x3814a3c*/ VContainer.IScopedObjectResolver CreateScope(System.Action<VContainer.IContainerBuilder> installation);
        /*0x3816710*/ void Inject(object instance);
    }

    interface IScopedObjectResolver : VContainer.IObjectResolver, System.IDisposable
    {
        /*0x38148bc*/ VContainer.IObjectResolver get_Root();
        /*0x38148bc*/ VContainer.IScopedObjectResolver get_Parent();
        /*0x3814200*/ bool TryGetRegistration(System.Type type, ref VContainer.Registration registration);
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

        /*0x81fe9d8*/ ScopedContainer(VContainer.Internal.Registry registry, VContainer.IObjectResolver root, VContainer.IScopedObjectResolver parent, object applicationOrigin);
        /*0x81fe9b0*/ VContainer.IObjectResolver get_Root();
        /*0x81fe9b8*/ VContainer.IScopedObjectResolver get_Parent();
        /*0x81fe9c0*/ object get_ApplicationOrigin();
        /*0x81fe9c8*/ VContainer.Diagnostics.DiagnosticsCollector get_Diagnostics();
        /*0x81fe9d0*/ void set_Diagnostics(VContainer.Diagnostics.DiagnosticsCollector value);
        /*0x81febd8*/ object Resolve(System.Type type);
        /*0x81fec8c*/ object Resolve(VContainer.Registration registration);
        /*0x81ff0e4*/ VContainer.IScopedObjectResolver CreateScope(System.Action<VContainer.IContainerBuilder> installation);
        /*0x81ff1c4*/ void Inject(object instance);
        /*0x81ff3f0*/ bool TryGetRegistration(System.Type type, ref VContainer.Registration registration);
        /*0x81ff548*/ void Dispose();
        /*0x81ff88c*/ object ResolveCore(VContainer.Registration registration);
        /*0x81ffb38*/ object CreateTrackedInstance(VContainer.Registration registration);
        /*0x81ffc5c*/ VContainer.Registration FindRegistration(System.Type type);
        /*0x81ffe50*/ System.Lazy<object> <.ctor>b__17_0(VContainer.Registration registration);

        class <>c__DisplayClass17_0
        {
            /*0x10*/ VContainer.Registration registration;
            /*0x18*/ VContainer.ScopedContainer <>4__this;

            /*0x81fff68*/ <>c__DisplayClass17_0();
            /*0x81fff70*/ object <.ctor>b__1();
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

        /*0x8200034*/ Container(VContainer.Internal.Registry registry, object applicationOrigin);
        /*0x820001c*/ object get_ApplicationOrigin();
        /*0x8200024*/ VContainer.Diagnostics.DiagnosticsCollector get_Diagnostics();
        /*0x820002c*/ void set_Diagnostics(VContainer.Diagnostics.DiagnosticsCollector value);
        /*0x82001c8*/ object Resolve(System.Type type);
        /*0x82002e4*/ object Resolve(VContainer.Registration registration);
        /*0x8200390*/ VContainer.IScopedObjectResolver CreateScope(System.Action<VContainer.IContainerBuilder> installation);
        /*0x820043c*/ void Inject(object instance);
        /*0x8200530*/ void Dispose();
        /*0x820060c*/ object ResolveCore(VContainer.Registration registration);
        /*0x820084c*/ System.Lazy<object> <.ctor>b__12_0(VContainer.Registration registration);

        class <>c__DisplayClass12_0
        {
            /*0x10*/ VContainer.Registration registration;
            /*0x18*/ VContainer.Container <>4__this;

            /*0x8200964*/ <>c__DisplayClass12_0();
            /*0x820096c*/ object <.ctor>b__1();
        }
    }

    interface IContainerBuilder
    {
        /*0x38148bc*/ object get_ApplicationOrigin();
        /*0x3816710*/ void set_ApplicationOrigin(object value);
        /*0x38148bc*/ VContainer.Diagnostics.DiagnosticsCollector get_Diagnostics();
        /*0x3816710*/ void set_Diagnostics(VContainer.Diagnostics.DiagnosticsCollector value);
        /*0x3814574*/ int get_Count();
        /*0x3814964*/ VContainer.RegistrationBuilder get_Item(int index);
        /*0x3816044*/ void set_Item(int index, VContainer.RegistrationBuilder value);
        /*0x3910ae8*/ T Register<T>(T registrationBuilder);
        /*0x3816710*/ void RegisterBuildCallback(System.Action<VContainer.IObjectResolver> container);
        bool Exists(System.Type type, bool includeInterfaceTypes);
    }

    class ScopedContainerBuilder : VContainer.ContainerBuilder
    {
        /*0x30*/ VContainer.IObjectResolver root;
        /*0x38*/ VContainer.IScopedObjectResolver parent;

        /*0x81ff184*/ ScopedContainerBuilder(VContainer.IObjectResolver root, VContainer.IScopedObjectResolver parent);
        /*0x8200aa0*/ VContainer.IScopedObjectResolver BuildScope();
        /*0x8200b74*/ VContainer.IObjectResolver Build();
    }

    class ContainerBuilder : VContainer.IContainerBuilder
    {
        /*0x10*/ object <ApplicationOrigin>k__BackingField;
        /*0x18*/ System.Collections.Generic.List<VContainer.RegistrationBuilder> registrationBuilders;
        /*0x20*/ System.Action<VContainer.IObjectResolver> buildCallback;
        /*0x28*/ VContainer.Diagnostics.DiagnosticsCollector diagnostics;

        /*0x8200a18*/ ContainerBuilder();
        /*0x8200b7c*/ object get_ApplicationOrigin();
        /*0x8200b84*/ void set_ApplicationOrigin(object value);
        /*0x8200b8c*/ int get_Count();
        /*0x8200bd4*/ VContainer.RegistrationBuilder get_Item(int index);
        /*0x8200c2c*/ void set_Item(int index, VContainer.RegistrationBuilder value);
        /*0x8200c94*/ VContainer.Diagnostics.DiagnosticsCollector get_Diagnostics();
        /*0x8200c9c*/ void set_Diagnostics(VContainer.Diagnostics.DiagnosticsCollector value);
        /*0x3910ae8*/ T Register<T>(T registrationBuilder);
        /*0x8200cc8*/ void RegisterBuildCallback(System.Action<VContainer.IObjectResolver> callback);
        /*0x8200d70*/ bool Exists(System.Type type, bool includeInterfaceTypes);
        /*0x8200f8c*/ VContainer.IObjectResolver Build();
        /*0x820104c*/ VContainer.Internal.Registry BuildRegistry();
        /*0x8201c94*/ void EmitCallbacks(VContainer.IObjectResolver container);
    }

    class ContainerBuilderExtensions
    {
        static /*0x8201d38*/ VContainer.RegistrationBuilder Register(VContainer.IContainerBuilder builder, System.Type type, VContainer.Lifetime lifetime);
        static /*0x8201f98*/ VContainer.RegistrationBuilder Register(VContainer.IContainerBuilder builder, System.Type interfacetType, System.Type implementationType, VContainer.Lifetime lifetime);
        static /*0x38390c0*/ VContainer.RegistrationBuilder Register<T>(VContainer.IContainerBuilder builder, VContainer.Lifetime lifetime);
        static /*0x38390c0*/ VContainer.RegistrationBuilder Register<TInterface, TImplement>(VContainer.IContainerBuilder builder, VContainer.Lifetime lifetime);
        static /*0x38390c0*/ VContainer.RegistrationBuilder Register<TInterface1, TInterface2, TImplement>(VContainer.IContainerBuilder builder, VContainer.Lifetime lifetime);
        static /*0x38390c0*/ VContainer.RegistrationBuilder Register<TInterface1, TInterface2, TInterface3, TImplement>(VContainer.IContainerBuilder builder, VContainer.Lifetime lifetime);
        static /*0x3839820*/ VContainer.RegistrationBuilder Register<TInterface>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, TInterface> implementationConfiguration, VContainer.Lifetime lifetime);
        static /*0x3910ae8*/ VContainer.RegistrationBuilder RegisterInstance<TInterface>(VContainer.IContainerBuilder builder, TInterface instance);
        static /*0x3910ae8*/ VContainer.RegistrationBuilder RegisterInstance<TInterface1, TInterface2>(VContainer.IContainerBuilder builder, TInterface1 instance);
        static /*0x3910ae8*/ VContainer.RegistrationBuilder RegisterInstance<TInterface1, TInterface2, TInterface3>(VContainer.IContainerBuilder builder, TInterface1 instance);
        static /*0x38395d4*/ VContainer.RegistrationBuilder RegisterFactory<T>(VContainer.IContainerBuilder builder, System.Func<T> factory);
        static /*0x38395d4*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, T>(VContainer.IContainerBuilder builder, System.Func<TParam1, T> factory);
        static /*0x38395d4*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, TParam2, T>(VContainer.IContainerBuilder builder, System.Func<TParam1, TParam2, T> factory);
        static /*0x38395d4*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, TParam2, TParam3, T>(VContainer.IContainerBuilder builder, System.Func<TParam1, TParam2, TParam3, T> factory);
        static /*0x38395d4*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, TParam2, TParam3, TParam4, T>(VContainer.IContainerBuilder builder, System.Func<TParam1, TParam2, TParam3, TParam4, T> factory);
        static /*0x3839820*/ VContainer.RegistrationBuilder RegisterFactory<T>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, System.Func<T>> factoryFactory, VContainer.Lifetime lifetime);
        static /*0x3839820*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, T>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, System.Func<TParam1, T>> factoryFactory, VContainer.Lifetime lifetime);
        static /*0x3839820*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, TParam2, T>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, System.Func<TParam1, TParam2, T>> factoryFactory, VContainer.Lifetime lifetime);
        static /*0x3839820*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, TParam2, TParam3, T>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, System.Func<TParam1, TParam2, TParam3, T>> factoryFactory, VContainer.Lifetime lifetime);
        static /*0x3839820*/ VContainer.RegistrationBuilder RegisterFactory<TParam1, TParam2, TParam3, TParam4, T>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, System.Func<TParam1, TParam2, TParam3, TParam4, T>> factoryFactory, VContainer.Lifetime lifetime);
        static /*0x8202000*/ void RegisterDisposeCallback(VContainer.IContainerBuilder builder, System.Action<VContainer.IObjectResolver> callback);
        static /*0x820220c*/ void RegisterContainer(VContainer.IContainerBuilder builder);

        class <>c
        {
            static /*0x0*/ VContainer.ContainerBuilderExtensions.<> <>9;
            static /*0x8*/ System.Action<VContainer.IObjectResolver> <>9__20_1;

            static /*0x8202210*/ <>c();
            /*0x8202278*/ <>c();
            /*0x8202280*/ void <RegisterDisposeCallback>b__20_1(VContainer.IObjectResolver container);
        }

        class <>c__DisplayClass20_0
        {
            /*0x10*/ System.Action<VContainer.IObjectResolver> callback;

            /*0x8202204*/ <>c__DisplayClass20_0();
            /*0x82022c8*/ VContainer.Internal.BuilderCallbackDisposable <RegisterDisposeCallback>b__0(VContainer.IObjectResolver container);
        }

        class <>c__DisplayClass6_0<TInterface>
        {
            /*0x0*/ System.Func<VContainer.IObjectResolver, TInterface> implementationConfiguration;

            /*0x38159dc*/ <>c__DisplayClass6_0();
            /*0x3814a3c*/ object <Register>b__0(VContainer.IObjectResolver container);
        }
    }

    interface IInjector
    {
        /*0x3816920*/ void Inject(object instance, VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
        /*0x3814b90*/ object CreateInstance(VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
    }

    interface IInjectParameter
    {
        /*0x3814200*/ bool Match(System.Type parameterType, string parameterName);
        /*0x38148bc*/ object get_Value();
    }

    interface IInstanceProvider
    {
        /*0x3814a3c*/ object SpawnInstance(VContainer.IObjectResolver resolver);
    }

    class IObjectResolverExtensions
    {
        static /*0x3910ae8*/ T Resolve<T>(VContainer.IObjectResolver resolver);
        static /*0x8202344*/ object ResolveNonGeneric(VContainer.IObjectResolver resolve, System.Type type);
        static /*0x82023ec*/ object ResolveOrParameter(VContainer.IObjectResolver resolver, System.Type parameterType, string parameterName, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
    }

    class Registration
    {
        /*0x10*/ System.Type ImplementationType;
        /*0x18*/ System.Collections.Generic.IReadOnlyList<System.Type> InterfaceTypes;
        /*0x20*/ VContainer.Lifetime Lifetime;
        /*0x28*/ VContainer.IInstanceProvider Provider;

        /*0x8201514*/ Registration(System.Type implementationType, VContainer.Lifetime lifetime, System.Collections.Generic.IReadOnlyList<System.Type> interfaceTypes, VContainer.IInstanceProvider provider);
        /*0x8202694*/ string ToString();
        /*0x820289c*/ object SpawnInstance(VContainer.IObjectResolver resolver);
    }

    class RegistrationBuilder
    {
        /*0x10*/ System.Type ImplementationType;
        /*0x18*/ VContainer.Lifetime Lifetime;
        /*0x20*/ System.Collections.Generic.List<System.Type> InterfaceTypes;
        /*0x28*/ System.Collections.Generic.List<VContainer.IInjectParameter> Parameters;

        /*0x8201ea0*/ RegistrationBuilder(System.Type implementationType, VContainer.Lifetime lifetime);
        /*0x8202944*/ VContainer.Registration Build();
        /*0x38148bc*/ VContainer.RegistrationBuilder As<TInterface>();
        /*0x38148bc*/ VContainer.RegistrationBuilder As<TInterface1, TInterface2>();
        /*0x38148bc*/ VContainer.RegistrationBuilder As<TInterface1, TInterface2, TInterface3>();
        /*0x38148bc*/ VContainer.RegistrationBuilder As<TInterface1, TInterface2, TInterface3, TInterface4>();
        /*0x8202a68*/ VContainer.RegistrationBuilder AsSelf();
        /*0x8202a8c*/ VContainer.RegistrationBuilder AsImplementedInterfaces();
        /*0x8201fe0*/ VContainer.RegistrationBuilder As(System.Type interfaceType);
        /*0x8202b5c*/ VContainer.RegistrationBuilder As(System.Type interfaceType1, System.Type interfaceType2);
        /*0x8202b9c*/ VContainer.RegistrationBuilder As(System.Type interfaceType1, System.Type interfaceType2, System.Type interfaceType3);
        /*0x8202bf4*/ VContainer.RegistrationBuilder As(System.Type[] interfaceTypes);
        /*0x8202c6c*/ VContainer.RegistrationBuilder WithParameter(string name, object value);
        /*0x8202df8*/ VContainer.RegistrationBuilder WithParameter(System.Type type, object value);
        /*0x3910ae8*/ VContainer.RegistrationBuilder WithParameter<TParam>(TParam value);
        /*0x8202f84*/ void AddInterfaceType(System.Type interfaceType);
    }

    class VContainerException : System.Exception
    {
        /*0x90*/ System.Type InvalidType;

        /*0x81ffdd4*/ VContainerException(System.Type invalidType, string message);
    }

    namespace Internal
    {
        struct BuilderCallbackDisposable : System.IDisposable
        {
            /*0x10*/ System.Action<VContainer.IObjectResolver> callback;
            /*0x18*/ VContainer.IObjectResolver container;

            /*0x8202314*/ BuilderCallbackDisposable(System.Action<VContainer.IObjectResolver> callback, VContainer.IObjectResolver container);
            /*0x8203138*/ void Dispose();
        }

        class CappedArrayPool<T>
        {
            static int InitialBucketSize = 4;
            static /*0x0*/ VContainer.Internal.CappedArrayPool<T> Shared8Limit;
            /*0x0*/ T[][][] buckets;
            /*0x0*/ object syncRoot;
            /*0x0*/ int[] tails;

            static /*0x383e7a0*/ CappedArrayPool();
            /*0x3815ed0*/ CappedArrayPool(int maxLength);
            /*0x3814964*/ T[] Rent(int length);
            /*0x3816710*/ void Return(T[] array);
        }

        class CompositeDisposable : System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.Stack<System.IDisposable> disposables;

            /*0x81feb50*/ CompositeDisposable();
            /*0x81ff6c4*/ void Dispose();
            /*0x8203160*/ void Add(System.IDisposable disposable);
        }

        class ContainerLocal<T>
        {
            /*0x0*/ T Value;

            /*0x3910ae8*/ ContainerLocal(T value);
        }

        class FixedTypeKeyHashtable<TValue>
        {
            /*0x0*/ VContainer.Internal.FixedTypeKeyHashtable.HashEntry<TValue> table;
            /*0x0*/ int indexFor;

            FixedTypeKeyHashtable(System.Collections.Generic.KeyValuePair<System.Type, TValue> values, float loadFactor);
            /*0x3910ae8*/ TValue Get(System.Type type);
            /*0x3814200*/ bool TryGet(System.Type type, ref TValue value);

            struct HashEntry<TValue>
            {
                /*0x0*/ System.Type Type;
                /*0x0*/ TValue Value;

                /*0x3910ae8*/ HashEntry(System.Type key, TValue value);
            }
        }

        class FuncRegistrationBuilder : VContainer.RegistrationBuilder
        {
            /*0x30*/ System.Func<VContainer.IObjectResolver, object> implementationProvider;

            /*0x8203260*/ FuncRegistrationBuilder(System.Func<VContainer.IObjectResolver, object> implementationProvider, System.Type implementationType, VContainer.Lifetime lifetime);
            /*0x82032b4*/ VContainer.Registration Build();
        }

        class InjectorCache
        {
            static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, VContainer.IInjector> Injectors;

            static /*0x8203398*/ InjectorCache();
            static /*0x81ff2b8*/ VContainer.IInjector GetOrBuild(System.Type type);

            class <>c
            {
                static /*0x0*/ VContainer.Internal.InjectorCache.<> <>9;
                static /*0x8*/ System.Func<System.Type, VContainer.IInjector> <>9__1_0;

                static /*0x8203430*/ <>c();
                /*0x8203498*/ <>c();
                /*0x82034a0*/ VContainer.IInjector <GetOrBuild>b__1_0(System.Type key);
            }
        }

        class TypedParameter : VContainer.IInjectParameter
        {
            /*0x10*/ System.Type Type;
            /*0x18*/ object <Value>k__BackingField;

            /*0x8202f40*/ TypedParameter(System.Type type, object value);
            /*0x82036a0*/ object get_Value();
            /*0x82036a8*/ bool Match(System.Type parameterType, string _);
        }

        class NamedParameter : VContainer.IInjectParameter
        {
            /*0x10*/ string Name;
            /*0x18*/ object <Value>k__BackingField;

            /*0x8202db4*/ NamedParameter(string name, object value);
            /*0x82036ec*/ object get_Value();
            /*0x82036f4*/ bool Match(System.Type _, string parameterName);
        }

        class CollectionInstanceProvider : VContainer.IInstanceProvider, System.Collections.Generic.IEnumerable<VContainer.Registration>, System.Collections.IEnumerable
        {
            /*0x10*/ System.Type <ImplementationType>k__BackingField;
            /*0x18*/ System.Type <ElementType>k__BackingField;
            /*0x20*/ System.Collections.Generic.List<System.Type> interfaceTypes;
            /*0x28*/ System.Collections.Generic.List<VContainer.Registration> registrations;

            static /*0x8203704*/ bool Match(System.Type openGenericType);
            /*0x8203944*/ CollectionInstanceProvider(System.Type elementType);
            /*0x82037d0*/ System.Collections.Generic.List.Enumerator<VContainer.Registration> GetEnumerator();
            /*0x8203844*/ System.Collections.Generic.IEnumerator<VContainer.Registration> System.Collections.Generic.IEnumerable<VContainer.Registration>.GetEnumerator();
            /*0x82038b4*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x8203924*/ System.Type get_ImplementationType();
            /*0x820392c*/ System.Collections.Generic.IReadOnlyList<System.Type> get_InterfaceTypes();
            /*0x8203934*/ VContainer.Lifetime get_Lifetime();
            /*0x820393c*/ System.Type get_ElementType();
            /*0x8203b5c*/ string ToString();
            /*0x8203c44*/ void Add(VContainer.Registration registration);
            /*0x8203ec8*/ object SpawnInstance(VContainer.IObjectResolver resolver);
            /*0x8204444*/ object SpawnInstance(VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.Registration> registrations);
            /*0x8203f48*/ System.Collections.Generic.List<VContainer.Registration> CollectFromParentScopes(VContainer.IScopedObjectResolver scope, bool localScopeOnly);
        }

        class ContainerInstanceProvider : VContainer.IInstanceProvider
        {
            static /*0x0*/ VContainer.Internal.ContainerInstanceProvider Default;

            static /*0x82046a0*/ ContainerInstanceProvider();
            /*0x8204698*/ ContainerInstanceProvider();
            /*0x8204690*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class ContainerLocalInstanceProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ System.Type wrappedType;
            /*0x18*/ VContainer.Registration valueRegistration;

            /*0x8204708*/ ContainerLocalInstanceProvider(System.Type wrappedType, VContainer.Registration valueRegistration);
            /*0x820474c*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class ExistingInstanceProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ object implementationInstance;

            /*0x8204a08*/ ExistingInstanceProvider(object implementationInstance);
            /*0x8204a38*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class FuncInstanceProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ System.Func<VContainer.IObjectResolver, object> implementationProvider;

            /*0x8203368*/ FuncInstanceProvider(System.Func<VContainer.IObjectResolver, object> implementationProvider);
            /*0x8204a40*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class InstanceProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ VContainer.IInjector injector;
            /*0x18*/ System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters;

            /*0x8202a24*/ InstanceProvider(VContainer.IInjector injector, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters);
            /*0x8204a64*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class OpenGenericInstanceProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ VContainer.Lifetime lifetime;
            /*0x18*/ System.Type implementationType;
            /*0x20*/ System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters;
            /*0x28*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type[], VContainer.Registration> constructedRegistrations;
            /*0x30*/ System.Func<System.Type[], VContainer.Registration> createRegistrationFunc;

            /*0x8204b18*/ OpenGenericInstanceProvider(System.Type implementationType, VContainer.Lifetime lifetime, System.Collections.Generic.List<VContainer.IInjectParameter> injectParameters);
            /*0x8204c70*/ VContainer.Registration GetClosedRegistration(System.Type closedInterfaceType, System.Type[] typeParameters);
            /*0x8204ccc*/ VContainer.Registration CreateRegistration(System.Type[] typeParameters);
            /*0x8204e88*/ object SpawnInstance(VContainer.IObjectResolver resolver);

            class TypeParametersEqualityComparer : System.Collections.Generic.IEqualityComparer<System.Type[]>
            {
                /*0x8204c68*/ TypeParametersEqualityComparer();
                /*0x8204ec0*/ bool Equals(System.Type[] x, System.Type[] y);
                /*0x8204fa4*/ int GetHashCode(System.Type[] typeParameters);
            }
        }

        class InstanceRegistrationBuilder : VContainer.RegistrationBuilder
        {
            /*0x30*/ object implementationInstance;

            /*0x8205020*/ InstanceRegistrationBuilder(object implementationInstance);
            /*0x8205084*/ VContainer.Registration Build();
        }

        class OpenGenericRegistrationBuilder : VContainer.RegistrationBuilder
        {
            /*0x8201edc*/ OpenGenericRegistrationBuilder(System.Type implementationType, VContainer.Lifetime lifetime);
            /*0x8205138*/ VContainer.Registration Build();
            /*0x82051f4*/ VContainer.RegistrationBuilder AsImplementedInterfaces();
            /*0x8205388*/ void AddInterfaceType(System.Type interfaceType);
        }

        class ReflectionInjector : VContainer.IInjector
        {
            /*0x10*/ VContainer.Internal.InjectTypeInfo injectTypeInfo;

            static /*0x8205618*/ VContainer.Internal.ReflectionInjector Build(System.Type type);
            /*0x8205738*/ ReflectionInjector(VContainer.Internal.InjectTypeInfo injectTypeInfo);
            /*0x8205768*/ void Inject(object instance, VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
            /*0x8206558*/ object CreateInstance(VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
            /*0x82057bc*/ void InjectFields(object obj, VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
            /*0x8205b18*/ void InjectProperties(object obj, VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
            /*0x8205e74*/ void InjectMethods(object obj, VContainer.IObjectResolver resolver, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> parameters);
        }

        class RuntimeTypeCache
        {
            static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Type> OpenGenericTypes;
            static /*0x8*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Type[]> GenericTypeParameters;
            static /*0x10*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Type> ArrayTypes;
            static /*0x18*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Type> EnumerableTypes;
            static /*0x20*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, System.Type> ReadOnlyListTypes;

            static /*0x8206f88*/ RuntimeTypeCache();
            static /*0x8206970*/ System.Type OpenGenericTypeOf(System.Type closedGenericType);
            static /*0x8206aa8*/ System.Type[] GenericTypeParametersOf(System.Type closedGenericType);
            static /*0x8206be0*/ System.Type ArrayTypeOf(System.Type elementType);
            static /*0x8206d18*/ System.Type EnumerableTypeOf(System.Type elementType);
            static /*0x8206e50*/ System.Type ReadOnlyListTypeOf(System.Type elementType);

            class <>c
            {
                static /*0x0*/ VContainer.Internal.RuntimeTypeCache.<> <>9;
                static /*0x8*/ System.Func<System.Type, System.Type> <>9__5_0;
                static /*0x10*/ System.Func<System.Type, System.Type[]> <>9__6_0;
                static /*0x18*/ System.Func<System.Type, System.Type> <>9__7_0;
                static /*0x20*/ System.Func<System.Type, System.Type> <>9__8_0;
                static /*0x28*/ System.Func<System.Type, System.Type> <>9__9_0;

                static /*0x82070f0*/ <>c();
                /*0x8207158*/ <>c();
                /*0x8207160*/ System.Type <OpenGenericTypeOf>b__5_0(System.Type key);
                /*0x8207188*/ System.Type[] <GenericTypeParametersOf>b__6_0(System.Type key);
                /*0x82071b0*/ System.Type <ArrayTypeOf>b__7_0(System.Type key);
                /*0x82071d8*/ System.Type <EnumerableTypeOf>b__8_0(System.Type key);
                /*0x82072cc*/ System.Type <ReadOnlyListTypeOf>b__9_0(System.Type key);
            }
        }

        class InjectConstructorInfo
        {
            /*0x10*/ System.Reflection.ConstructorInfo ConstructorInfo;
            /*0x18*/ System.Reflection.ParameterInfo[] ParameterInfos;

            /*0x82073c0*/ InjectConstructorInfo(System.Reflection.ConstructorInfo constructorInfo);
            /*0x820741c*/ InjectConstructorInfo(System.Reflection.ConstructorInfo constructorInfo, System.Reflection.ParameterInfo[] parameterInfos);
        }

        class InjectMethodInfo
        {
            /*0x10*/ System.Reflection.MethodInfo MethodInfo;
            /*0x18*/ System.Reflection.ParameterInfo[] ParameterInfos;

            /*0x8207460*/ InjectMethodInfo(System.Reflection.MethodInfo methodInfo);
        }

        class InjectTypeInfo
        {
            /*0x10*/ System.Type Type;
            /*0x18*/ VContainer.Internal.InjectConstructorInfo InjectConstructor;
            /*0x20*/ System.Collections.Generic.IReadOnlyList<VContainer.Internal.InjectMethodInfo> InjectMethods;
            /*0x28*/ System.Collections.Generic.IReadOnlyList<System.Reflection.FieldInfo> InjectFields;
            /*0x30*/ System.Collections.Generic.IReadOnlyList<System.Reflection.PropertyInfo> InjectProperties;

            /*0x82074bc*/ InjectTypeInfo(System.Type type, VContainer.Internal.InjectConstructorInfo injectConstructor, System.Collections.Generic.IReadOnlyList<VContainer.Internal.InjectMethodInfo> injectMethods, System.Collections.Generic.IReadOnlyList<System.Reflection.FieldInfo> injectFields, System.Collections.Generic.IReadOnlyList<System.Reflection.PropertyInfo> injectProperties);
        }

        struct DependencyInfo
        {
            /*0x10*/ VContainer.Registration Dependency;
            /*0x18*/ VContainer.Registration owner;
            /*0x20*/ object method;
            /*0x28*/ System.Reflection.ParameterInfo param;

            /*0x8207584*/ DependencyInfo(VContainer.Registration dependency);
            /*0x82075c8*/ DependencyInfo(VContainer.Registration dependency, VContainer.Registration owner, System.Reflection.ConstructorInfo ctor, System.Reflection.ParameterInfo param);
            /*0x8207628*/ DependencyInfo(VContainer.Registration dependency, VContainer.Registration owner, System.Reflection.MethodInfo method, System.Reflection.ParameterInfo param);
            /*0x8207688*/ DependencyInfo(VContainer.Registration dependency, VContainer.Registration owner, System.Reflection.FieldInfo field);
            /*0x82076dc*/ DependencyInfo(VContainer.Registration dependency, VContainer.Registration owner, System.Reflection.PropertyInfo prop);
            /*0x820754c*/ System.Type get_ImplementationType();
            /*0x8207568*/ VContainer.IInstanceProvider get_Provider();
            /*0x8207730*/ string ToString();
        }

        class TypeAnalyzer
        {
            static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, VContainer.Internal.InjectTypeInfo> Cache;
            static /*0x8*/ System.Func<System.Type, VContainer.Internal.InjectTypeInfo> AnalyzeFunc;
            [ThreadStatic] static System.Collections.Generic.Stack<VContainer.Internal.DependencyInfo> circularDependencyChecker;

            static /*0x8209700*/ TypeAnalyzer();
            static /*0x82056b4*/ VContainer.Internal.InjectTypeInfo AnalyzeWithCache(System.Type type);
            static /*0x8207a9c*/ VContainer.Internal.InjectTypeInfo Analyze(System.Type type);
            static /*0x8201a48*/ void CheckCircularDependency(System.Collections.Generic.IReadOnlyList<VContainer.Registration> registrations, VContainer.Internal.Registry registry);
            static /*0x8208774*/ void CheckCircularDependencyRecursive(VContainer.Internal.DependencyInfo current, VContainer.Internal.Registry registry, System.Collections.Generic.Stack<VContainer.Internal.DependencyInfo> stack);

            class <>c
            {
                static /*0x0*/ VContainer.Internal.TypeAnalyzer.<> <>9;
                static /*0x8*/ System.Func<VContainer.Internal.DependencyInfo, int, string> <>9__6_0;

                static /*0x82097f8*/ <>c();
                /*0x8209860*/ <>c();
                /*0x8209868*/ string <CheckCircularDependencyRecursive>b__6_0(VContainer.Internal.DependencyInfo item, int itemIndex);
            }

            class <>c__DisplayClass4_0
            {
                /*0x10*/ System.Reflection.FieldInfo fieldInfo;

                /*0x820876c*/ <>c__DisplayClass4_0();
                /*0x8209948*/ bool <Analyze>b__0(System.Reflection.FieldInfo x);
            }
        }

        class TypeKeyHashTable2<TValue>
        {
            /*0x0*/ VContainer.Internal.TypeKeyHashTable2.Bucket<TValue> buckets;
            /*0x0*/ System.Collections.Generic.KeyValuePair<System.Type, TValue> entries;
            /*0x0*/ int indexFor;
            /*0x0*/ int insertedEntryLength;

            TypeKeyHashTable2(System.Collections.Generic.KeyValuePair<System.Type, TValue> values, float loadFactor);
            /*0x3814200*/ bool TryGet(System.Type key, ref TValue value);
            /*0x3910ae8*/ void Insert(System.Collections.Generic.KeyValuePair<System.Type, TValue> entry, int entryIndex);
            /*0x3910ae8*/ void SetBucketAt(int i, VContainer.Internal.TypeKeyHashTable2.Bucket<TValue> bucket);
            /*0x38145a0*/ int NextBucketIndex(int i);

            struct Bucket<TValue>
            {
                static uint DistOne = 256;
                static uint FingerPrintMask = 255;
                /*0x0*/ uint DistAndFingerPrint;
                /*0x0*/ int EntryIndex;

                static /*0x383cf14*/ uint DistAndFingerPrintFromHash(int hash);
            }
        }

        class Registry
        {
            [ThreadStatic] static System.Collections.Generic.IDictionary<System.Type, VContainer.Registration> buildBuffer;
            /*0x10*/ VContainer.Internal.FixedTypeKeyHashtable<VContainer.Registration> hashTable;

            static /*0x820a658*/ Registry();
            static /*0x820157c*/ VContainer.Internal.Registry Build(VContainer.Registration[] registrations);
            static /*0x820999c*/ void AddToBuildBuffer(System.Collections.Generic.IDictionary<System.Type, VContainer.Registration> buf, System.Type service, VContainer.Registration registration);
            static /*0x8209e00*/ void AddCollectionToBuildBuffer(System.Collections.Generic.IDictionary<System.Type, VContainer.Registration> buf, VContainer.Registration collectionRegistration);
            /*0x8209dd0*/ Registry(VContainer.Internal.FixedTypeKeyHashtable<VContainer.Registration> hashTable);
            /*0x81ff408*/ bool TryGet(System.Type interfaceType, ref VContainer.Registration registration);
            /*0x820a094*/ bool TryGetClosedGenericRegistration(System.Type interfaceType, System.Type openGenericType, System.Type[] typeParameters, ref VContainer.Registration registration);
            /*0x81ffa54*/ bool Exists(System.Type type);
            /*0x820a494*/ bool TryFallbackToContainerLocal(System.Type closedGenericType, System.Type openGenericType, System.Collections.Generic.IReadOnlyList<System.Type> typeParameters, ref VContainer.Registration newRegistration);
            /*0x820a198*/ bool TryFallbackToSingleElementCollection(System.Type closedGenericType, System.Type openGenericType, System.Collections.Generic.IReadOnlyList<System.Type> typeParameters, ref VContainer.Registration newRegistration);
        }
    }

    namespace Diagnostics
    {
        class DiagnosticsCollector
        {
            /*0x10*/ string <ScopeName>k__BackingField;
            /*0x18*/ System.Collections.Generic.List<VContainer.Diagnostics.DiagnosticsInfo> diagnosticsInfos;
            /*0x20*/ System.Threading.ThreadLocal<System.Collections.Generic.Stack<VContainer.Diagnostics.DiagnosticsInfo>> resolveCallStack;

            /*0x820a6fc*/ DiagnosticsCollector(string scopeName);
            /*0x820a6f4*/ string get_ScopeName();
            /*0x820a894*/ System.Collections.Generic.IReadOnlyList<VContainer.Diagnostics.DiagnosticsInfo> GetDiagnosticsInfos();
            /*0x81ff5b0*/ void Clear();
            /*0x820a89c*/ void TraceRegister(VContainer.Diagnostics.RegisterInfo registerInfo);
            /*0x82012c4*/ void TraceBuild(VContainer.RegistrationBuilder registrationBuilder, VContainer.Registration registration);
            /*0x81fed38*/ object TraceResolve(VContainer.Registration registration, System.Func<VContainer.Registration, object> resolving);
            /*0x8201ce4*/ void NotifyContainerBuilt(VContainer.IObjectResolver container);

            class <>c
            {
                static /*0x0*/ VContainer.Diagnostics.DiagnosticsCollector.<> <>9;
                static /*0x8*/ System.Func<System.Collections.Generic.Stack<VContainer.Diagnostics.DiagnosticsInfo>> <>9__5_0;

                static /*0x820ad0c*/ <>c();
                /*0x820ad74*/ <>c();
                /*0x820ad7c*/ System.Collections.Generic.Stack<VContainer.Diagnostics.DiagnosticsInfo> <.ctor>b__5_0();
            }
        }

        class DiagnositcsContext
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<string, VContainer.Diagnostics.DiagnosticsCollector> collectors;
            static /*0x8*/ System.Action<VContainer.IObjectResolver> OnContainerBuilt;

            static /*0x820b75c*/ DiagnositcsContext();
            static /*0x820ade4*/ void add_OnContainerBuilt(System.Action<VContainer.IObjectResolver> value);
            static /*0x820aed8*/ void remove_OnContainerBuilt(System.Action<VContainer.IObjectResolver> value);
            static /*0x820afcc*/ VContainer.Diagnostics.DiagnosticsCollector GetCollector(string name);
            static /*0x820b1ac*/ System.Linq.ILookup<string, VContainer.Diagnostics.DiagnosticsInfo> GetGroupedDiagnosticsInfos();
            static /*0x820b54c*/ System.Collections.Generic.IEnumerable<VContainer.Diagnostics.DiagnosticsInfo> GetDiagnosticsInfos();
            static /*0x820ac90*/ void NotifyContainerBuilt(VContainer.IObjectResolver container);
            static /*0x820ab80*/ VContainer.Diagnostics.DiagnosticsInfo FindByRegistration(VContainer.Registration registration);

            class <>c
            {
                static /*0x0*/ VContainer.Diagnostics.DiagnositcsContext.<> <>9;
                static /*0x8*/ System.Func<System.Collections.Generic.KeyValuePair<string, VContainer.Diagnostics.DiagnosticsCollector>, System.Collections.Generic.IEnumerable<VContainer.Diagnostics.DiagnosticsInfo>> <>9__5_0;
                static /*0x10*/ System.Func<VContainer.Diagnostics.DiagnosticsInfo, bool> <>9__5_1;
                static /*0x18*/ System.Func<VContainer.Diagnostics.DiagnosticsInfo, string> <>9__5_2;
                static /*0x20*/ System.Func<System.Collections.Generic.KeyValuePair<string, VContainer.Diagnostics.DiagnosticsCollector>, System.Collections.Generic.IEnumerable<VContainer.Diagnostics.DiagnosticsInfo>> <>9__6_0;

                static /*0x820b7f4*/ <>c();
                /*0x820b85c*/ <>c();
                /*0x820b864*/ System.Collections.Generic.IEnumerable<VContainer.Diagnostics.DiagnosticsInfo> <GetGroupedDiagnosticsInfos>b__5_0(System.Collections.Generic.KeyValuePair<string, VContainer.Diagnostics.DiagnosticsCollector> x);
                /*0x820b8a8*/ bool <GetGroupedDiagnosticsInfos>b__5_1(VContainer.Diagnostics.DiagnosticsInfo x);
                /*0x820b8d0*/ string <GetGroupedDiagnosticsInfos>b__5_2(VContainer.Diagnostics.DiagnosticsInfo x);
                /*0x820b8e8*/ System.Collections.Generic.IEnumerable<VContainer.Diagnostics.DiagnosticsInfo> <GetDiagnosticsInfos>b__6_0(System.Collections.Generic.KeyValuePair<string, VContainer.Diagnostics.DiagnosticsCollector> x);
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ VContainer.Registration registration;

                /*0x820b754*/ <>c__DisplayClass8_0();
                /*0x820b92c*/ bool <FindByRegistration>b__0(VContainer.Diagnostics.DiagnosticsInfo x);
            }
        }

        class DiagnosticsInfo
        {
            /*0x10*/ string <ScopeName>k__BackingField;
            /*0x18*/ VContainer.Diagnostics.RegisterInfo <RegisterInfo>k__BackingField;
            /*0x20*/ VContainer.Diagnostics.ResolveInfo <ResolveInfo>k__BackingField;
            /*0x28*/ System.Collections.Generic.List<VContainer.Diagnostics.DiagnosticsInfo> <Dependencies>k__BackingField;

            /*0x820aa24*/ DiagnosticsInfo(string scopeName, VContainer.Diagnostics.RegisterInfo registerInfo);
            /*0x820b958*/ string get_ScopeName();
            /*0x820b960*/ VContainer.Diagnostics.RegisterInfo get_RegisterInfo();
            /*0x820b968*/ VContainer.Diagnostics.ResolveInfo get_ResolveInfo();
            /*0x820b970*/ void set_ResolveInfo(VContainer.Diagnostics.ResolveInfo value);
            /*0x820b978*/ System.Collections.Generic.List<VContainer.Diagnostics.DiagnosticsInfo> get_Dependencies();
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

            static /*0x820c30c*/ RegisterInfo();
            /*0x820b998*/ RegisterInfo(VContainer.RegistrationBuilder registrationBuilder);
            /*0x820b980*/ int get_Id();
            /*0x820b988*/ VContainer.RegistrationBuilder get_RegistrationBuilder();
            /*0x820b990*/ System.Diagnostics.StackTrace get_StackTrace();
            /*0x820bc34*/ string GetFilename();
            /*0x820bda0*/ int GetFileLineNumber();
            /*0x820bf00*/ string GetScriptAssetPath();
            /*0x820bf94*/ string GetHeadline();
            /*0x820ba7c*/ System.Diagnostics.StackFrame GetHeadlineFrame(System.Diagnostics.StackTrace stackTrace);
        }

        class ResolveInfo
        {
            /*0x10*/ VContainer.Registration <Registration>k__BackingField;
            /*0x18*/ System.Collections.Generic.List<object> <Instances>k__BackingField;
            /*0x20*/ int <MaxDepth>k__BackingField;
            /*0x24*/ int <RefCount>k__BackingField;

            /*0x820aadc*/ ResolveInfo(VContainer.Registration registration);
            /*0x820c358*/ VContainer.Registration get_Registration();
            /*0x820c360*/ System.Collections.Generic.List<object> get_Instances();
            /*0x820c368*/ int get_MaxDepth();
            /*0x820c370*/ void set_MaxDepth(int value);
            /*0x820c378*/ int get_RefCount();
            /*0x820c380*/ void set_RefCount(int value);
        }
    }

    namespace Unity
    {
        interface IAsyncStartable
        {
            /*0x38158a8*/ Cysharp.Threading.Tasks.UniTask StartAsync(System.Threading.CancellationToken cancellation);
        }

        interface IFixedTickable
        {
            /*0x38159dc*/ void FixedTick();
        }

        interface IInitializable
        {
            /*0x38159dc*/ void Initialize();
        }

        interface ILateTickable
        {
            /*0x38159dc*/ void LateTick();
        }

        interface IPostFixedTickable
        {
            /*0x38159dc*/ void PostFixedTick();
        }

        interface IPostInitializable
        {
            /*0x38159dc*/ void PostInitialize();
        }

        interface IPostLateTickable
        {
            /*0x38159dc*/ void PostLateTick();
        }

        interface IPostStartable
        {
            /*0x38159dc*/ void PostStart();
        }

        interface IPostTickable
        {
            /*0x38159dc*/ void PostTick();
        }

        interface IStartable
        {
            /*0x38159dc*/ void Start();
        }

        interface ITickable
        {
            /*0x38159dc*/ void Tick();
        }

        class ActionInstaller : VContainer.Unity.IInstaller
        {
            /*0x10*/ System.Action<VContainer.IContainerBuilder> configuration;

            static /*0x820c388*/ VContainer.Unity.ActionInstaller op_Implicit(System.Action<VContainer.IContainerBuilder> installation);
            /*0x820c3f0*/ ActionInstaller(System.Action<VContainer.IContainerBuilder> configuration);
            /*0x820c420*/ void Install(VContainer.IContainerBuilder builder);
        }

        struct ComponentDestination
        {
            /*0x10*/ UnityEngine.Transform Parent;
            /*0x18*/ System.Func<VContainer.IObjectResolver, UnityEngine.Transform> ParentFinder;
            /*0x20*/ bool DontDestroyOnLoad;

            /*0x820c444*/ UnityEngine.Transform GetParent(VContainer.IObjectResolver resolver);
            /*0x820c4ec*/ void ApplyDontDestroyOnLoadIfNeeded(UnityEngine.Component component);
        }

        class ComponentRegistrationBuilder : VContainer.RegistrationBuilder
        {
            /*0x30*/ object instance;
            /*0x38*/ System.Func<VContainer.IObjectResolver, UnityEngine.Component> prefabFinder;
            /*0x40*/ string gameObjectName;
            /*0x48*/ VContainer.Unity.ComponentDestination destination;
            /*0x60*/ UnityEngine.SceneManagement.Scene scene;

            /*0x820c55c*/ ComponentRegistrationBuilder(object instance);
            /*0x820c5c0*/ ComponentRegistrationBuilder(ref UnityEngine.SceneManagement.Scene scene, System.Type implementationType);
            /*0x820c608*/ ComponentRegistrationBuilder(System.Func<VContainer.IObjectResolver, UnityEngine.Component> prefabFinder, System.Type implementationType, VContainer.Lifetime lifetime);
            /*0x820c65c*/ ComponentRegistrationBuilder(string gameObjectName, System.Type implementationType, VContainer.Lifetime lifetime);
            /*0x820c6b0*/ VContainer.Registration Build();
            /*0x820cac4*/ VContainer.Unity.ComponentRegistrationBuilder UnderTransform(UnityEngine.Transform parent);
            /*0x820cae0*/ VContainer.Unity.ComponentRegistrationBuilder UnderTransform(System.Func<UnityEngine.Transform> parentFinder);
            /*0x820cbb8*/ VContainer.Unity.ComponentRegistrationBuilder UnderTransform(System.Func<VContainer.IObjectResolver, UnityEngine.Transform> parentFinder);
            /*0x820cbd4*/ VContainer.Unity.ComponentRegistrationBuilder DontDestroyOnLoad();

            class <>c__DisplayClass11_0
            {
                /*0x10*/ System.Func<UnityEngine.Transform> parentFinder;

                /*0x820cbb0*/ <>c__DisplayClass11_0();
                /*0x820cbe0*/ UnityEngine.Transform <UnderTransform>b__0(VContainer.IObjectResolver _);
            }
        }

        struct EntryPointsBuilder
        {
            /*0x10*/ VContainer.IContainerBuilder containerBuilder;
            /*0x18*/ VContainer.Lifetime lifetime;

            static /*0x820cc04*/ void EnsureDispatcherRegistered(VContainer.IContainerBuilder containerBuilder);
            /*0x820ce6c*/ EntryPointsBuilder(VContainer.IContainerBuilder containerBuilder, VContainer.Lifetime lifetime);
            /*0x38148bc*/ VContainer.RegistrationBuilder Add<T>();
            /*0x820ce94*/ void OnException(System.Action<System.Exception> exceptionHandler);

            class <>c
            {
                static /*0x0*/ VContainer.Unity.EntryPointsBuilder.<> <>9;
                static /*0x8*/ System.Action<VContainer.IObjectResolver> <>9__0_0;

                static /*0x820cf2c*/ <>c();
                /*0x820cf94*/ <>c();
                /*0x820cf9c*/ void <EnsureDispatcherRegistered>b__0_0(VContainer.IObjectResolver container);
            }
        }

        struct ComponentsBuilder
        {
            /*0x10*/ VContainer.IContainerBuilder containerBuilder;
            /*0x18*/ UnityEngine.Transform parentTransform;

            /*0x820df90*/ ComponentsBuilder(VContainer.IContainerBuilder containerBuilder, UnityEngine.Transform parentTransform);
            /*0x3910ae8*/ VContainer.RegistrationBuilder AddInstance<TInterface>(TInterface component);
            /*0x38148bc*/ VContainer.Unity.ComponentRegistrationBuilder AddInHierarchy<T>();
            VContainer.Unity.ComponentRegistrationBuilder AddOnNewGameObject<T>(VContainer.Lifetime lifetime, string newGameObjectName);
            /*0x3910ae8*/ VContainer.Unity.ComponentRegistrationBuilder AddInNewPrefab<T>(T prefab, VContainer.Lifetime lifetime);
        }

        class ContainerBuilderUnityExtensions
        {
            static /*0x820dfc0*/ void UseEntryPoints(VContainer.IContainerBuilder builder, System.Action<VContainer.Unity.EntryPointsBuilder> configuration);
            static /*0x820dfcc*/ void UseEntryPoints(VContainer.IContainerBuilder builder, VContainer.Lifetime lifetime, System.Action<VContainer.Unity.EntryPointsBuilder> configuration);
            static /*0x820e028*/ void UseComponents(VContainer.IContainerBuilder builder, System.Action<VContainer.Unity.ComponentsBuilder> configuration);
            static /*0x820e08c*/ void UseComponents(VContainer.IContainerBuilder builder, UnityEngine.Transform root, System.Action<VContainer.Unity.ComponentsBuilder> configuration);
            static /*0x38390c0*/ VContainer.RegistrationBuilder RegisterEntryPoint<T>(VContainer.IContainerBuilder builder, VContainer.Lifetime lifetime);
            static /*0x820ce9c*/ void RegisterEntryPointExceptionHandler(VContainer.IContainerBuilder builder, System.Action<System.Exception> exceptionHandler);
            static /*0x3910ae8*/ VContainer.RegistrationBuilder RegisterComponent<TInterface>(VContainer.IContainerBuilder builder, TInterface component);
            static /*0x820e124*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentInHierarchy(VContainer.IContainerBuilder builder, System.Type type);
            static /*0x38379c4*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentInHierarchy<T>(VContainer.IContainerBuilder builder);
            static /*0x820e3fc*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentOnNewGameObject(VContainer.IContainerBuilder builder, System.Type type, VContainer.Lifetime lifetime, string newGameObjectName);
            static /*0x38391e0*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentOnNewGameObject<T>(VContainer.IContainerBuilder builder, VContainer.Lifetime lifetime, string newGameObjectName);
            static /*0x820e500*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentInNewPrefab(VContainer.IContainerBuilder builder, System.Type interfaceType, UnityEngine.Component prefab, VContainer.Lifetime lifetime);
            static /*0x3910ae8*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentInNewPrefab<T>(VContainer.IContainerBuilder builder, T prefab, VContainer.Lifetime lifetime);
            static /*0x3839820*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentInNewPrefab<T>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, T> prefab, VContainer.Lifetime lifetime);
            static /*0x3839820*/ VContainer.Unity.ComponentRegistrationBuilder RegisterComponentInNewPrefab<TInterface, TImplement>(VContainer.IContainerBuilder builder, System.Func<VContainer.IObjectResolver, TImplement> prefab, VContainer.Lifetime lifetime);

            class <>c__6<TInterface>
            {
                static /*0x0*/ VContainer.Unity.ContainerBuilderUnityExtensions.<>c__6<TInterface> <>9;
                static /*0x0*/ System.Action<VContainer.IObjectResolver> <>9__6_0;

                static /*0x383e7a0*/ <>c__6();
                /*0x38159dc*/ <>c__6();
                /*0x3816710*/ void <RegisterComponent>b__6_0(VContainer.IObjectResolver container);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ UnityEngine.Component prefab;

                /*0x820e6c8*/ <>c__DisplayClass11_0();
                /*0x820e6d0*/ UnityEngine.Component <RegisterComponentInNewPrefab>b__0(VContainer.IObjectResolver _);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ VContainer.Unity.ComponentRegistrationBuilder registrationBuilder;

                /*0x820e3f4*/ <>c__DisplayClass7_0();
                /*0x820e6d8*/ void <RegisterComponentInHierarchy>b__0(VContainer.IObjectResolver container);
            }
        }

        class AsyncLoopItem : VContainer.Unity.IPlayerLoopItem
        {
            /*0x10*/ System.Action action;

            /*0x820e7bc*/ AsyncLoopItem(System.Action action);
            /*0x820e7ec*/ bool MoveNext();
        }

        class EntryPointDispatcher : System.IDisposable
        {
            /*0x10*/ VContainer.IObjectResolver container;
            /*0x18*/ VContainer.Internal.CompositeDisposable disposable;

            /*0x820e818*/ EntryPointDispatcher(VContainer.IObjectResolver container);
            /*0x820cff0*/ void Dispatch();
            /*0x820f638*/ void Dispose();
        }

        class EntryPointExceptionHandler
        {
            /*0x10*/ System.Action<System.Exception> handler;

            /*0x820e0f4*/ EntryPointExceptionHandler(System.Action<System.Exception> handler);
            /*0x820f2c4*/ void Publish(System.Exception ex);
        }

        interface IInstaller
        {
            /*0x3816710*/ void Install(VContainer.IContainerBuilder builder);
        }

        class ExistingComponentProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ object instance;
            /*0x18*/ VContainer.IInjector injector;
            /*0x20*/ System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters;
            /*0x28*/ bool dontDestroyOnLoad;

            /*0x820c8c4*/ ExistingComponentProvider(object instance, VContainer.IInjector injector, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters, bool dontDestroyOnLoad);
            /*0x820f650*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class FindComponentProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ System.Type componentType;
            /*0x18*/ System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters;
            /*0x20*/ VContainer.Unity.ComponentDestination destination;
            /*0x38*/ UnityEngine.SceneManagement.Scene scene;

            /*0x820c930*/ FindComponentProvider(System.Type componentType, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters, ref UnityEngine.SceneManagement.Scene scene, ref VContainer.Unity.ComponentDestination destination);
            /*0x820f838*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class NewGameObjectProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ System.Type componentType;
            /*0x18*/ VContainer.IInjector injector;
            /*0x20*/ System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters;
            /*0x28*/ string newGameObjectName;
            /*0x30*/ VContainer.Unity.ComponentDestination destination;

            /*0x820ca28*/ NewGameObjectProvider(System.Type componentType, VContainer.IInjector injector, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters, ref VContainer.Unity.ComponentDestination destination, string newGameObjectName);
            /*0x820fcec*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class PrefabComponentProvider : VContainer.IInstanceProvider
        {
            /*0x10*/ VContainer.IInjector injector;
            /*0x18*/ System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters;
            /*0x20*/ System.Func<VContainer.IObjectResolver, UnityEngine.Component> prefabFinder;
            /*0x28*/ VContainer.Unity.ComponentDestination destination;

            /*0x820c9a8*/ PrefabComponentProvider(System.Func<VContainer.IObjectResolver, UnityEngine.Component> prefabFinder, VContainer.IInjector injector, System.Collections.Generic.IReadOnlyList<VContainer.IInjectParameter> customParameters, ref VContainer.Unity.ComponentDestination destination);
            /*0x820fecc*/ object SpawnInstance(VContainer.IObjectResolver resolver);
        }

        class VContainerParentTypeReferenceNotFound : System.Exception
        {
            /*0x90*/ System.Type ParentType;

            /*0x82101ec*/ VContainerParentTypeReferenceNotFound(System.Type parentType, string message);
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

            static /*0x82127d8*/ LifetimeScope();
            static /*0x8210268*/ void SubscribeSceneEvents();
            static /*0x8210330*/ void EnqueueAwake(VContainer.Unity.LifetimeScope lifetimeScope);
            static /*0x8210404*/ void CancelAwake(VContainer.Unity.LifetimeScope lifetimeScope);
            static /*0x8210484*/ void AwakeWaitingChildren(VContainer.Unity.LifetimeScope awakenParent);
            static /*0x8210800*/ void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            static /*0x8210b48*/ VContainer.Unity.LifetimeScope Create(VContainer.Unity.IInstaller installer);
            static /*0x8210c8c*/ VContainer.Unity.LifetimeScope Create(System.Action<VContainer.IContainerBuilder> configuration);
            static /*0x8210d20*/ VContainer.Unity.LifetimeScope.ParentOverrideScope EnqueueParent(VContainer.Unity.LifetimeScope parent);
            static /*0x8210e78*/ VContainer.Unity.LifetimeScope.ExtraInstallationScope Enqueue(System.Action<VContainer.IContainerBuilder> installing);
            static /*0x8211028*/ VContainer.Unity.LifetimeScope.ExtraInstallationScope Enqueue(VContainer.Unity.IInstaller installer);
            static /*0x8211040*/ VContainer.Unity.LifetimeScope.ParentOverrideScope PushParent(VContainer.Unity.LifetimeScope parent);
            static /*0x8211058*/ VContainer.Unity.LifetimeScope.ExtraInstallationScope Push(System.Action<VContainer.IContainerBuilder> installing);
            static /*0x82110b4*/ VContainer.Unity.LifetimeScope.ExtraInstallationScope Push(VContainer.Unity.IInstaller installer);
            static /*0x3910ae8*/ VContainer.Unity.LifetimeScope Find<T>(UnityEngine.SceneManagement.Scene scene);
            static /*0x3836db8*/ VContainer.Unity.LifetimeScope Find<T>();
            static /*0x8211110*/ VContainer.Unity.LifetimeScope Find(System.Type type, UnityEngine.SceneManagement.Scene scene);
            static /*0x821135c*/ VContainer.Unity.LifetimeScope Find(System.Type type);
            /*0x8212748*/ LifetimeScope();
            /*0x8211400*/ VContainer.IObjectResolver get_Container();
            /*0x8211408*/ void set_Container(VContainer.IObjectResolver value);
            /*0x8211410*/ VContainer.Unity.LifetimeScope get_Parent();
            /*0x8211418*/ void set_Parent(VContainer.Unity.LifetimeScope value);
            /*0x8211420*/ bool get_IsRoot();
            /*0x8211428*/ void set_IsRoot(bool value);
            /*0x8211434*/ void Awake();
            /*0x8211d30*/ void OnDestroy();
            /*0x8211e18*/ void Configure(VContainer.IContainerBuilder builder);
            /*0x8211e1c*/ void Dispose();
            /*0x8211d34*/ void DisposeCore();
            /*0x821193c*/ void Build();
            /*0x8212488*/ void SetContainer(VContainer.IObjectResolver container);
            /*0x3910ae8*/ TScope CreateChild<TScope>(VContainer.Unity.IInstaller installer);
            /*0x821262c*/ VContainer.Unity.LifetimeScope CreateChild(VContainer.Unity.IInstaller installer);
            /*0x3910ae8*/ TScope CreateChild<TScope>(System.Action<VContainer.IContainerBuilder> installation);
            /*0x8212684*/ VContainer.Unity.LifetimeScope CreateChild(System.Action<VContainer.IContainerBuilder> installation);
            /*0x3910ae8*/ TScope CreateChildFromPrefab<TScope>(TScope prefab, VContainer.Unity.IInstaller installer);
            /*0x3910ae8*/ TScope CreateChildFromPrefab<TScope>(TScope prefab, System.Action<VContainer.IContainerBuilder> installation);
            /*0x8211f98*/ void InstallTo(VContainer.IContainerBuilder builder);
            /*0x8211564*/ VContainer.Unity.LifetimeScope GetRuntimeParent();
            /*0x82124a4*/ void AutoInjectAll();
            /*0x821295c*/ void <Build>b__44_0(VContainer.IContainerBuilder builder);

            struct ParentOverrideScope : System.IDisposable
            {
                /*0x8210d38*/ ParentOverrideScope(VContainer.Unity.LifetimeScope nextParent);
                /*0x8212b70*/ void Dispose();
            }

            struct ExtraInstallationScope : System.IDisposable
            {
                /*0x8210ee8*/ ExtraInstallationScope(VContainer.Unity.IInstaller installer);
                /*0x8212cac*/ void System.IDisposable.Dispose();
            }
        }

        class ObjectResolverUnityExtensions
        {
            static /*0x8212714*/ void InjectGameObject(VContainer.IObjectResolver resolver, UnityEngine.GameObject gameObject);
            static /*0x3910ae8*/ T Instantiate<T>(VContainer.IObjectResolver resolver, T prefab);
            static /*0x3910ae8*/ T Instantiate<T>(VContainer.IObjectResolver resolver, T prefab, UnityEngine.Transform parent, bool worldPositionStays);
            static /*0x3910ae8*/ T Instantiate<T>(VContainer.IObjectResolver resolver, T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
            static /*0x3910ae8*/ T Instantiate<T>(VContainer.IObjectResolver resolver, T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
            static /*0x3910ae8*/ T Instantiate<T>(VContainer.Unity.LifetimeScope scope, T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
            static /*0x82131fc*/ UnityEngine.GameObject Instantiate(VContainer.Unity.LifetimeScope scope, UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
            static /*0x8213574*/ UnityEngine.GameObject Instantiate(VContainer.IObjectResolver resolver, UnityEngine.GameObject prefab);
            static /*0x82137a0*/ UnityEngine.GameObject Instantiate(VContainer.IObjectResolver resolver, UnityEngine.GameObject prefab, UnityEngine.Transform parent, bool worldPositionStays);
            static /*0x8213618*/ UnityEngine.GameObject Instantiate(VContainer.IObjectResolver resolver, UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation);
            static /*0x82138b8*/ UnityEngine.GameObject Instantiate(VContainer.IObjectResolver resolver, UnityEngine.GameObject prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, UnityEngine.Transform parent);
            static /*0x8213468*/ void SetName(UnityEngine.Object instance, UnityEngine.Object prefab);
            static /*0x8212de8*/ void <InjectGameObject>g__InjectGameObjectRecursive|0_0(UnityEngine.GameObject current, ref VContainer.Unity.ObjectResolverUnityExtensions.<> );

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

            static /*0x3910ae8*/ VContainer.Unity.ParentReference Create<T>();
            /*0x8213aac*/ ParentReference(System.Type type);
            /*0x8213a9c*/ System.Type get_Type();
            /*0x8213aa4*/ void set_Type(System.Type value);
            /*0x8213b08*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x8213b44*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
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

            static /*0x821437c*/ PlayerLoopHelper();
            static /*0x820e89c*/ void EnsureInitialized();
            static /*0x820f32c*/ void Dispatch(VContainer.Unity.PlayerLoopTiming timing, VContainer.Unity.IPlayerLoopItem item);
            static /*0x8213d34*/ ref UnityEngine.LowLevel.PlayerLoopSystem FindSubSystem(System.Type targetType, UnityEngine.LowLevel.PlayerLoopSystem[] systems);
            static /*0x8213e58*/ void InsertSubsystem(ref UnityEngine.LowLevel.PlayerLoopSystem parentSystem, System.Type beforeType, UnityEngine.LowLevel.PlayerLoopSystem newSystem, UnityEngine.LowLevel.PlayerLoopSystem newPostSystem);
        }

        class StartableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IEnumerable<VContainer.Unity.IStartable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x820f2e8*/ StartableLoopItem(System.Collections.Generic.IEnumerable<VContainer.Unity.IStartable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x82143f0*/ bool MoveNext();
            /*0x8214810*/ void Dispose();
        }

        class PostStartableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IEnumerable<VContainer.Unity.IPostStartable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x820f3c0*/ PostStartableLoopItem(System.Collections.Generic.IEnumerable<VContainer.Unity.IPostStartable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x821481c*/ bool MoveNext();
            /*0x8214c3c*/ void Dispose();
        }

        class FixedTickableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IReadOnlyList<VContainer.Unity.IFixedTickable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x820f404*/ FixedTickableLoopItem(System.Collections.Generic.IReadOnlyList<VContainer.Unity.IFixedTickable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x8214c48*/ bool MoveNext();
            /*0x8214ecc*/ void Dispose();
        }

        class PostFixedTickableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IReadOnlyList<VContainer.Unity.IPostFixedTickable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x820f448*/ PostFixedTickableLoopItem(System.Collections.Generic.IReadOnlyList<VContainer.Unity.IPostFixedTickable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x8214ed8*/ bool MoveNext();
            /*0x821515c*/ void Dispose();
        }

        class TickableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IReadOnlyList<VContainer.Unity.ITickable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x820f48c*/ TickableLoopItem(System.Collections.Generic.IReadOnlyList<VContainer.Unity.ITickable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x8215168*/ bool MoveNext();
            /*0x82153ec*/ void Dispose();
        }

        class PostTickableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IReadOnlyList<VContainer.Unity.IPostTickable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x820f4d0*/ PostTickableLoopItem(System.Collections.Generic.IReadOnlyList<VContainer.Unity.IPostTickable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x82153f8*/ bool MoveNext();
            /*0x821567c*/ void Dispose();
        }

        class LateTickableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IReadOnlyList<VContainer.Unity.ILateTickable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x820f514*/ LateTickableLoopItem(System.Collections.Generic.IReadOnlyList<VContainer.Unity.ILateTickable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x8215688*/ bool MoveNext();
            /*0x821590c*/ void Dispose();
        }

        class PostLateTickableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IReadOnlyList<VContainer.Unity.IPostLateTickable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ bool disposed;

            /*0x820f558*/ PostLateTickableLoopItem(System.Collections.Generic.IReadOnlyList<VContainer.Unity.IPostLateTickable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x8215918*/ bool MoveNext();
            /*0x8215b9c*/ void Dispose();
        }

        class AsyncStartableLoopItem : VContainer.Unity.IPlayerLoopItem, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.IEnumerable<VContainer.Unity.IAsyncStartable> entries;
            /*0x18*/ VContainer.Unity.EntryPointExceptionHandler exceptionHandler;
            /*0x20*/ System.Threading.CancellationTokenSource cts;
            /*0x28*/ bool disposed;

            /*0x820f59c*/ AsyncStartableLoopItem(System.Collections.Generic.IEnumerable<VContainer.Unity.IAsyncStartable> entries, VContainer.Unity.EntryPointExceptionHandler exceptionHandler);
            /*0x8215ba8*/ bool MoveNext();
            /*0x8215fc0*/ void Dispose();
            /*0x82160cc*/ void <MoveNext>b__5_0(System.Exception ex);
        }

        interface IPlayerLoopItem
        {
            /*0x3813ffc*/ bool MoveNext();
        }

        class PlayerLoopRunner
        {
            /*0x10*/ System.Collections.Generic.Queue<VContainer.Unity.IPlayerLoopItem> runningQueue;
            /*0x18*/ System.Collections.Generic.Queue<VContainer.Unity.IPlayerLoopItem> waitingQueue;
            /*0x20*/ object runningGate;
            /*0x28*/ object waitingGate;
            /*0x30*/ int running;

            /*0x8213c2c*/ PlayerLoopRunner();
            /*0x8214194*/ void Dispatch(VContainer.Unity.IPlayerLoopItem item);
            /*0x82160f8*/ void Run();
        }

        class UnityEngineObjectListBuffer<T>
        {
            static int DefaultCapacity = 32;
            [ThreadStatic] static System.Collections.Generic.Stack<System.Collections.Generic.List<T>> _pool;

            static /*0x383e7a0*/ UnityEngineObjectListBuffer();
            static /*0x3836db8*/ System.Collections.Generic.List<T> Get();
            static /*0x3910ae8*/ VContainer.Unity.UnityEngineObjectListBuffer.BufferScope<T> Get(ref System.Collections.Generic.List<T> buffer);
            static /*0x3840c74*/ void Release(System.Collections.Generic.List<T> buffer);

            struct BufferScope<T> : System.IDisposable
            {
                /*0x0*/ System.Collections.Generic.List<T> _buffer;

                /*0x3816710*/ BufferScope(System.Collections.Generic.List<T> buffer);
                /*0x38159dc*/ void Dispose();
            }
        }

        class VContainerSettings : UnityEngine.ScriptableObject
        {
            static /*0x0*/ VContainer.Unity.VContainerSettings <Instance>k__BackingField;
            /*0x18*/ VContainer.Unity.LifetimeScope RootLifetimeScope;
            /*0x20*/ bool EnableDiagnostics;
            /*0x21*/ bool DisableScriptModifier;
            /*0x22*/ bool RemoveClonePostfix;

            static /*0x82166b4*/ VContainer.Unity.VContainerSettings get_Instance();
            static /*0x82166fc*/ void set_Instance(VContainer.Unity.VContainerSettings value);
            static /*0x8211ec0*/ bool get_DiagnosticsEnabled();
            /*0x8216bdc*/ VContainerSettings();
            /*0x8216754*/ void OnEnable();
            /*0x82169b4*/ void OnFirstSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode);
            /*0x8216aac*/ void OnApplicationQuit();
            /*0x8216be4*/ void <OnApplicationQuit>b__12_0();
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
