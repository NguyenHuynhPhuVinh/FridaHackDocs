class <Module>
{
}

namespace Unity
{
    namespace Properties
    {
        class CreatePropertyAttribute : System.Attribute
        {
        }

        class DontCreatePropertyAttribute : System.Attribute
        {
        }

        class PropertyGetter<TContainer, TValue> : System.MulticastDelegate
        {
            PropertyGetter(object object, nint method);
            /*0x2a5510*/ TValue Invoke(ref TContainer container);
        }

        class PropertySetter<TContainer, TValue> : System.MulticastDelegate
        {
            PropertySetter(object object, nint method);
            /*0x2a5510*/ void Invoke(ref TContainer container, TValue value);
        }

        class DelegateProperty<TContainer, TValue> : Unity.Properties.Property<TContainer, TValue>
        {
            /*0x0*/ Unity.Properties.PropertyGetter<TContainer, TValue> m_Getter;
            /*0x0*/ Unity.Properties.PropertySetter<TContainer, TValue> m_Setter;
            /*0x0*/ string <Name>k__BackingField;

            /*0x183830*/ DelegateProperty(string name, Unity.Properties.PropertyGetter<TContainer, TValue> getter, Unity.Properties.PropertySetter<TContainer, TValue> setter);
            /*0x1803b0*/ string get_Name();
        }

        interface IProperty
        {
            /*0x1803b0*/ System.Type DeclaredValueType();
        }

        interface IProperty<TContainer> : Unity.Properties.IProperty
        {
        }

        class Property<TContainer, TValue> : Unity.Properties.IProperty<TContainer>, Unity.Properties.IProperty, Unity.Properties.Internal.IAttributes
        {
            /*0x0*/ System.Collections.Generic.List<System.Attribute> m_Attributes;

            /*0x180fc0*/ Property();
            /*0x1803b0*/ string get_Name();
            /*0x1803b0*/ System.Type DeclaredValueType();
            /*0x17aec0*/ void AddAttribute(System.Attribute attribute);
            /*0x17aec0*/ void AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes);
            /*0x17aec0*/ void Unity.Properties.Internal.IAttributes.AddAttribute(System.Attribute attribute);
            /*0x17aec0*/ void Unity.Properties.Internal.IAttributes.AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes);
            /*0x17cb40*/ bool HasAttribute<TAttribute>();
        }

        interface IMemberInfo
        {
            /*0x1803b0*/ string get_Name();
            /*0x17cb40*/ bool get_IsReadOnly();
            /*0x1803b0*/ System.Type get_ValueType();
            /*0x1803b0*/ System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes();
        }

        struct FieldMember : Unity.Properties.IMemberInfo
        {
            /*0x10*/ System.Reflection.FieldInfo m_FieldInfo;
            /*0x18*/ string <Name>k__BackingField;

            /*0x164fda0*/ FieldMember(System.Reflection.FieldInfo fieldInfo);
            /*0xa5a7f0*/ string get_Name();
            /*0x164fdd0*/ bool get_IsReadOnly();
            /*0x164fdf0*/ System.Type get_ValueType();
            /*0x164fd90*/ System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes();
        }

        struct PropertyMember : Unity.Properties.IMemberInfo
        {
            /*0x10*/ System.Reflection.PropertyInfo m_PropertyInfo;
            /*0x18*/ string <Name>k__BackingField;

            /*0x164fda0*/ PropertyMember(System.Reflection.PropertyInfo propertyInfo);
            /*0xa5a7f0*/ string get_Name();
            /*0x16507a0*/ bool get_IsReadOnly();
            /*0x16507d0*/ System.Type get_ValueType();
            /*0x164fd90*/ System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes();
        }

        class ReflectedMemberProperty<TContainer, TValue> : Unity.Properties.Property<TContainer, TValue>
        {
            /*0x0*/ Unity.Properties.IMemberInfo m_Info;
            /*0x0*/ bool m_IsStructContainerType;
            /*0x0*/ Unity.Properties.ReflectedMemberProperty.GetStructValueAction<TContainer, TValue> m_GetStructValueAction;
            /*0x0*/ Unity.Properties.ReflectedMemberProperty.SetStructValueAction<TContainer, TValue> m_SetStructValueAction;
            /*0x0*/ Unity.Properties.ReflectedMemberProperty.GetClassValueAction<TContainer, TValue> m_GetClassValueAction;
            /*0x0*/ Unity.Properties.ReflectedMemberProperty.SetClassValueAction<TContainer, TValue> m_SetClassValueAction;
            /*0x0*/ string <Name>k__BackingField;
            /*0x0*/ bool <IsReadOnly>k__BackingField;

            /*0x183150*/ ReflectedMemberProperty(Unity.Properties.IMemberInfo info, string name);
            /*0x1803b0*/ string get_Name();

            class GetStructValueAction<TContainer, TValue> : System.MulticastDelegate
            {
                GetStructValueAction(object object, nint method);
                /*0x2a5510*/ TValue Invoke(ref TContainer container);
            }

            class SetStructValueAction<TContainer, TValue> : System.MulticastDelegate
            {
                SetStructValueAction(object object, nint method);
                /*0x2a5510*/ void Invoke(ref TContainer container, TValue value);
            }

            class GetClassValueAction<TContainer, TValue> : System.MulticastDelegate
            {
                GetClassValueAction(object object, nint method);
                /*0x2a5510*/ TValue Invoke(TContainer container);
            }

            class SetClassValueAction<TContainer, TValue> : System.MulticastDelegate
            {
                SetClassValueAction(object object, nint method);
                /*0x2a5510*/ void Invoke(TContainer container, TValue value);
            }
        }

        class ArrayPropertyBag<TElement> : Unity.Properties.IndexedCollectionPropertyBag<TElement[], TElement>
        {
            /*0x180fc0*/ ArrayPropertyBag();
            /*0x180980*/ Unity.Properties.InstantiationKind get_InstantiationKind();
            /*0x184ab0*/ TElement[] InstantiateWithCount(int count);
            /*0x1803b0*/ TElement[] Instantiate();
        }

        class ContainerPropertyBag<TContainer> : Unity.Properties.PropertyBag<TContainer>
        {
            /*0x0*/ System.Collections.Generic.List<Unity.Properties.IProperty<TContainer>> m_PropertiesList;
            /*0x0*/ System.Collections.Generic.Dictionary<string, Unity.Properties.IProperty<TContainer>> m_PropertiesHash;

            static /*0x180ff0*/ ContainerPropertyBag();
            /*0x180fc0*/ ContainerPropertyBag();
            /*0x17aec0*/ void AddProperty<TValue>(Unity.Properties.Property<TContainer, TValue> property);
            bool TryGetProperty(ref TContainer container, string name, ref Unity.Properties.IProperty<TContainer> property);
        }

        class DictionaryPropertyBag<TKey, TValue> : Unity.Properties.KeyValueCollectionPropertyBag<System.Collections.Generic.Dictionary<TKey, TValue>, TKey, TValue>
        {
            /*0x180fc0*/ DictionaryPropertyBag();
            /*0x180980*/ Unity.Properties.InstantiationKind get_InstantiationKind();
            /*0x1803b0*/ System.Collections.Generic.Dictionary<TKey, TValue> Instantiate();
        }

        class HashSetPropertyBag<TElement> : Unity.Properties.SetPropertyBagBase<System.Collections.Generic.HashSet<TElement>, TElement>
        {
            /*0x180fc0*/ HashSetPropertyBag();
            /*0x180980*/ Unity.Properties.InstantiationKind get_InstantiationKind();
            /*0x1803b0*/ System.Collections.Generic.HashSet<TElement> Instantiate();
        }

        class IndexedCollectionPropertyBag<TList, TElement> : Unity.Properties.PropertyBag<TList>, Unity.Properties.IPropertyBag<TList>, Unity.Properties.IPropertyBag, Unity.Properties.IConstructorWithCount<TList>, Unity.Properties.IConstructor
        {
            /*0x0*/ Unity.Properties.IndexedCollectionPropertyBag.ListElementProperty<TList, TElement> m_Property;

            /*0x180fc0*/ IndexedCollectionPropertyBag();
            /*0x2a5510*/ TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count);
            /*0x2a5510*/ TList InstantiateWithCount(int count);

            class ListElementProperty<TList, TElement> : Unity.Properties.Property<TList, TElement>
            {
                /*0x0*/ int m_Index;

                /*0x180fc0*/ ListElementProperty();
                /*0x180980*/ int get_Index();
                /*0x1803b0*/ string get_Name();
            }
        }

        interface IPropertyBag
        {
            /*0x17aec0*/ void Accept(Unity.Properties.ITypeVisitor visitor);
        }

        interface IPropertyBag<TContainer> : Unity.Properties.IPropertyBag
        {
        }

        class KeyValueCollectionPropertyBag<TDictionary, TKey, TValue> : Unity.Properties.PropertyBag<TDictionary>, Unity.Properties.IPropertyBag<TDictionary>, Unity.Properties.IPropertyBag
        {
            /*0x0*/ Unity.Properties.KeyValueCollectionPropertyBag.KeyValuePairProperty<TDictionary, TKey, TValue> m_KeyValuePairProperty;

            /*0x180fc0*/ KeyValueCollectionPropertyBag();

            class KeyValuePairProperty<TDictionary, TKey, TValue> : Unity.Properties.Property<TDictionary, System.Collections.Generic.KeyValuePair<TKey, TValue>>
            {
                /*0x0*/ TKey <Key>k__BackingField;

                /*0x180fc0*/ KeyValuePairProperty();
                /*0x1803b0*/ string get_Name();
                /*0x2a5510*/ TKey get_Key();
            }
        }

        class KeyValuePairPropertyBag<TKey, TValue> : Unity.Properties.PropertyBag<System.Collections.Generic.KeyValuePair<TKey, TValue>>
        {
            static /*0x0*/ Unity.Properties.DelegateProperty<System.Collections.Generic.KeyValuePair<TKey, TValue>, TKey> s_KeyProperty;
            static /*0x0*/ Unity.Properties.DelegateProperty<System.Collections.Generic.KeyValuePair<TKey, TValue>, TValue> s_ValueProperty;

            static /*0x180ff0*/ KeyValuePairPropertyBag();
            /*0x180fc0*/ KeyValuePairPropertyBag();

            class <>c<TKey, TValue>
            {
                static /*0x0*/ Unity.Properties.KeyValuePairPropertyBag.<>c<TKey, TValue> <>9;

                static /*0x180ff0*/ <>c();
                /*0x180fc0*/ <>c();
                /*0x2a5510*/ TKey <.cctor>b__7_0(ref System.Collections.Generic.KeyValuePair<TKey, TValue> container);
                /*0x2a5510*/ TValue <.cctor>b__7_1(ref System.Collections.Generic.KeyValuePair<TKey, TValue> container);
            }
        }

        class ListPropertyBag<TElement> : Unity.Properties.IndexedCollectionPropertyBag<System.Collections.Generic.List<TElement>, TElement>
        {
            /*0x180fc0*/ ListPropertyBag();
            /*0x180980*/ Unity.Properties.InstantiationKind get_InstantiationKind();
            /*0x184ab0*/ System.Collections.Generic.List<TElement> InstantiateWithCount(int count);
            /*0x1803b0*/ System.Collections.Generic.List<TElement> Instantiate();
        }

        class PropertyBag
        {
            static /*0x177be0*/ void Register<TContainer>(Unity.Properties.PropertyBag<TContainer> propertyBag);
        }

        class PropertyBag<TContainer> : Unity.Properties.IPropertyBag<TContainer>, Unity.Properties.IPropertyBag, Unity.Properties.Internal.IPropertyBagRegister, Unity.Properties.IConstructor<TContainer>, Unity.Properties.IConstructor
        {
            /*0x0*/ Unity.Properties.InstantiationKind <InstantiationKind>k__BackingField;

            static /*0x180ff0*/ PropertyBag();
            /*0x180fc0*/ PropertyBag();
            /*0x180fc0*/ void Unity.Properties.Internal.IPropertyBagRegister.Register();
            /*0x17aec0*/ void Accept(Unity.Properties.ITypeVisitor visitor);
            /*0x180980*/ Unity.Properties.InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind();
            /*0x2a5510*/ TContainer Unity.Properties.IConstructor<TContainer>.Instantiate();
            /*0x180980*/ Unity.Properties.InstantiationKind get_InstantiationKind();
            /*0x2a5510*/ TContainer Instantiate();
        }

        class SetPropertyBagBase<TSet, TElement> : Unity.Properties.PropertyBag<TSet>, Unity.Properties.IPropertyBag<TSet>, Unity.Properties.IPropertyBag
        {
            /*0x0*/ Unity.Properties.SetPropertyBagBase.SetElementProperty<TSet, TElement> m_Property;

            /*0x180fc0*/ SetPropertyBagBase();

            class SetElementProperty<TSet, TElement> : Unity.Properties.Property<TSet, TElement>
            {
                /*0x0*/ TElement m_Value;

                /*0x180fc0*/ SetElementProperty();
                /*0x1803b0*/ string get_Name();
            }
        }

        interface ITypeVisitor
        {
            /*0x180fc0*/ void Visit<TContainer>();
        }

        class TypeTraits
        {
            static /*0x16519a0*/ bool IsContainer(System.Type type);
        }

        class TypeTraits<T>
        {
            static /*0x0*/ bool <IsValueType>k__BackingField;
            static /*0x0*/ bool <IsPrimitive>k__BackingField;
            static /*0x0*/ bool <IsInterface>k__BackingField;
            static /*0x0*/ bool <IsAbstract>k__BackingField;
            static /*0x0*/ bool <IsArray>k__BackingField;
            static /*0x0*/ bool <IsMultidimensionalArray>k__BackingField;
            static /*0x0*/ bool <IsEnum>k__BackingField;
            static /*0x0*/ bool <IsEnumFlags>k__BackingField;
            static /*0x0*/ bool <IsNullable>k__BackingField;
            static /*0x0*/ bool <IsObject>k__BackingField;
            static /*0x0*/ bool <IsString>k__BackingField;
            static /*0x0*/ bool <IsContainer>k__BackingField;
            static /*0x0*/ bool <CanBeNull>k__BackingField;
            static /*0x0*/ bool <IsPrimitiveOrString>k__BackingField;
            static /*0x0*/ bool <IsAbstractOrInterface>k__BackingField;
            static /*0x0*/ bool <IsUnityObject>k__BackingField;
            static /*0x0*/ bool <IsLazyLoadReference>k__BackingField;

            static /*0x180ff0*/ TypeTraits();
            static /*0x17cb70*/ bool get_IsValueType();
            static /*0x17cb70*/ bool get_IsPrimitive();
            static /*0x17cb70*/ bool get_IsInterface();
            static /*0x17cb70*/ bool get_IsAbstract();
            static /*0x17cb70*/ bool get_IsArray();
            static /*0x17cb70*/ bool get_IsEnum();
            static /*0x17cb70*/ bool get_IsNullable();
            static /*0x17cb70*/ bool get_IsObject();
            static /*0x17cb70*/ bool get_IsString();
            static /*0x17cb70*/ bool get_IsContainer();
            static /*0x17cb70*/ bool get_CanBeNull();
            static /*0x17cb70*/ bool get_IsAbstractOrInterface();
        }

        enum InstantiationKind
        {
            Activator = 0,
            PropertyBagOverride = 1,
            NotInstantiatable = 2,
        }

        interface IConstructor
        {
            /*0x180980*/ Unity.Properties.InstantiationKind get_InstantiationKind();
        }

        interface IConstructor<T> : Unity.Properties.IConstructor
        {
            /*0x2a5510*/ T Instantiate();
        }

        interface IConstructorWithCount<T> : Unity.Properties.IConstructor
        {
            /*0x2a5510*/ T InstantiateWithCount(int count);
        }

        class TypeUtility
        {
            static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, Unity.Properties.TypeUtility.ITypeConstructor> s_TypeConstructors;
            static /*0x8*/ System.Reflection.MethodInfo s_CreateTypeConstructor;
            static /*0x10*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, string> s_CachedResolvedName;
            static /*0x18*/ UnityEngine.Pool.ObjectPool<System.Text.StringBuilder> s_Builders;
            static /*0x20*/ object syncedPoolObject;

            static /*0x1652db0*/ TypeUtility();
            static /*0x1652310*/ string GetTypeDisplayName(System.Type type);
            static /*0x1652430*/ string GetTypeDisplayName(System.Type type, System.Collections.Generic.IReadOnlyList<System.Type> args, ref int argIndex);
            static /*0x1652130*/ System.Type GetRootType(System.Type type);
            static /*0x1651e50*/ Unity.Properties.TypeUtility.ITypeConstructor CreateTypeConstructor(System.Type type);
            static /*0x180cf0*/ Unity.Properties.TypeUtility.ITypeConstructor<T> CreateTypeConstructor<T>();
            static /*0x1652250*/ Unity.Properties.TypeUtility.ITypeConstructor GetTypeConstructor(System.Type type);
            static /*0x180cf0*/ Unity.Properties.TypeUtility.ITypeConstructor<T> GetTypeConstructor<T>();
            static /*0x1651ae0*/ bool CanBeInstantiated(System.Type type);
            static /*0x17cb70*/ bool CanBeInstantiated<T>();
            static /*0x177be0*/ void SetExplicitInstantiationMethod<T>(System.Func<T> constructor);
            static /*0x2a5510*/ T Instantiate<T>();
            static /*0x177700*/ bool TryInstantiate<T>(ref T instance);
            static /*0x2a5510*/ T Instantiate<T>(System.Type derivedType);
            static /*0x1794f0*/ bool TryInstantiate<T>(System.Type derivedType, ref T value);
            static /*0x2a5510*/ TArray InstantiateArray<TArray>(int count);
            static bool TryInstantiateArray<TArray>(int count, ref TArray instance);
            static /*0x2a5510*/ TArray InstantiateArray<TArray>(System.Type derivedType, int count);
            static /*0x1651cd0*/ void CheckIsAssignableFrom(System.Type type, System.Type derivedType);
            static /*0x177be0*/ void CheckCanBeInstantiated<T>(Unity.Properties.TypeUtility.ITypeConstructor<T> constructor);
            static /*0x1651bf0*/ void CheckCanBeInstantiated(Unity.Properties.TypeUtility.ITypeConstructor constructor, System.Type type);

            interface ITypeConstructor
            {
                /*0x17cb40*/ bool get_CanBeInstantiated();
                /*0x1803b0*/ object Instantiate();
            }

            interface ITypeConstructor<T> : Unity.Properties.TypeUtility.ITypeConstructor
            {
                /*0x2a5510*/ T Instantiate();
                /*0x17aec0*/ void SetExplicitConstructor(System.Func<T> constructor);
            }

            class TypeConstructor<T> : Unity.Properties.TypeUtility.ITypeConstructor<T>, Unity.Properties.TypeUtility.ITypeConstructor
            {
                /*0x0*/ System.Func<T> m_ExplicitConstructor;
                /*0x0*/ System.Func<T> m_ImplicitConstructor;
                /*0x0*/ Unity.Properties.IConstructor<T> m_OverrideConstructor;

                static /*0x2a5510*/ T CreateValueTypeInstance();
                static /*0x2a5510*/ T CreateScriptableObjectInstance();
                static /*0x2a5510*/ T CreateClassInstance();
                /*0x180fc0*/ TypeConstructor();
                /*0x17cb40*/ bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated();
                /*0x180fc0*/ void SetImplicitConstructor();
                /*0x17aec0*/ void SetExplicitConstructor(System.Func<T> constructor);
                /*0x2a5510*/ T Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate();
                /*0x1803b0*/ object Unity.Properties.TypeUtility.ITypeConstructor.Instantiate();
            }

            class NonConstructable : Unity.Properties.TypeUtility.ITypeConstructor
            {
                /*0x32f970*/ NonConstructable();
                /*0x348b00*/ bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated();
                /*0x16500f0*/ object Instantiate();
            }

            struct Cache<T>
            {
                static /*0x0*/ Unity.Properties.TypeUtility.ITypeConstructor<T> TypeConstructor;
            }

            class TypeConstructorVisitor : Unity.Properties.ITypeVisitor
            {
                /*0x10*/ Unity.Properties.TypeUtility.ITypeConstructor TypeConstructor;

                /*0x32f970*/ TypeConstructorVisitor();
                /*0x180fc0*/ void Visit<TContainer>();
            }

            class <>c
            {
                static /*0x0*/ Unity.Properties.TypeUtility.<> <>9;

                static /*0x1653e00*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1653cc0*/ System.Text.StringBuilder <.cctor>b__11_0();
                /*0x1653d10*/ void <.cctor>b__11_1(System.Text.StringBuilder sb);
                /*0x1653d30*/ string <.cctor>b__11_2();
            }
        }

        namespace Internal
        {
            interface IAttributes
            {
                /*0x17aec0*/ void AddAttribute(System.Attribute attribute);
                /*0x17aec0*/ void AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes);
            }

            class DefaultPropertyBagInitializer
            {
                static /*0x164ecd0*/ void Initialize();
            }

            class ColorPropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Color>
            {
                /*0x164eb00*/ ColorPropertyBag();

                class RProperty : Unity.Properties.Property<UnityEngine.Color, float>
                {
                    /*0x1650800*/ RProperty();
                    /*0x1650840*/ string get_Name();
                }

                class GProperty : Unity.Properties.Property<UnityEngine.Color, float>
                {
                    /*0x164fe20*/ GProperty();
                    /*0x164fe60*/ string get_Name();
                }

                class BProperty : Unity.Properties.Property<UnityEngine.Color, float>
                {
                    /*0x164e720*/ BProperty();
                    /*0x164e760*/ string get_Name();
                }

                class AProperty : Unity.Properties.Property<UnityEngine.Color, float>
                {
                    /*0x164e6b0*/ AProperty();
                    /*0x164e6f0*/ string get_Name();
                }
            }

            class Vector2PropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Vector2>
            {
                /*0x1654000*/ Vector2PropertyBag();

                class XProperty : Unity.Properties.Property<UnityEngine.Vector2, float>
                {
                    /*0x1654740*/ XProperty();
                    /*0x1654900*/ string get_Name();
                }

                class YProperty : Unity.Properties.Property<UnityEngine.Vector2, float>
                {
                    /*0x1654b90*/ YProperty();
                    /*0x1654d00*/ string get_Name();
                }
            }

            class Vector3PropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Vector3>
            {
                /*0x16542a0*/ Vector3PropertyBag();

                class XProperty : Unity.Properties.Property<UnityEngine.Vector3, float>
                {
                    /*0x1654780*/ XProperty();
                    /*0x16549c0*/ string get_Name();
                }

                class YProperty : Unity.Properties.Property<UnityEngine.Vector3, float>
                {
                    /*0x1654b10*/ YProperty();
                    /*0x1654d30*/ string get_Name();
                }

                class ZProperty : Unity.Properties.Property<UnityEngine.Vector3, float>
                {
                    /*0x1654de0*/ ZProperty();
                    /*0x1654e50*/ string get_Name();
                }
            }

            class Vector4PropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Vector4>
            {
                /*0x1654420*/ Vector4PropertyBag();

                class XProperty : Unity.Properties.Property<UnityEngine.Vector4, float>
                {
                    /*0x1654880*/ XProperty();
                    /*0x1654930*/ string get_Name();
                }

                class YProperty : Unity.Properties.Property<UnityEngine.Vector4, float>
                {
                    /*0x1654ad0*/ YProperty();
                    /*0x1654c10*/ string get_Name();
                }

                class ZProperty : Unity.Properties.Property<UnityEngine.Vector4, float>
                {
                    /*0x1654d60*/ ZProperty();
                    /*0x1654e80*/ string get_Name();
                }

                class WProperty : Unity.Properties.Property<UnityEngine.Vector4, float>
                {
                    /*0x16545f0*/ WProperty();
                    /*0x1654630*/ string get_Name();
                }
            }

            class Vector2IntPropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Vector2Int>
            {
                /*0x1653ee0*/ Vector2IntPropertyBag();

                class XProperty : Unity.Properties.Property<UnityEngine.Vector2Int, int>
                {
                    /*0x16547c0*/ XProperty();
                    /*0x16549f0*/ string get_Name();
                }

                class YProperty : Unity.Properties.Property<UnityEngine.Vector2Int, int>
                {
                    /*0x1654bd0*/ YProperty();
                    /*0x1654c40*/ string get_Name();
                }
            }

            class Vector3IntPropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Vector3Int>
            {
                /*0x1654120*/ Vector3IntPropertyBag();

                class XProperty : Unity.Properties.Property<UnityEngine.Vector3Int, int>
                {
                    /*0x1654800*/ XProperty();
                    /*0x1654960*/ string get_Name();
                }

                class YProperty : Unity.Properties.Property<UnityEngine.Vector3Int, int>
                {
                    /*0x1654a90*/ YProperty();
                    /*0x1654ca0*/ string get_Name();
                }

                class ZProperty : Unity.Properties.Property<UnityEngine.Vector3Int, int>
                {
                    /*0x1654da0*/ ZProperty();
                    /*0x1654e20*/ string get_Name();
                }
            }

            class RectPropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Rect>
            {
                /*0x1650a40*/ RectPropertyBag();

                class XProperty : Unity.Properties.Property<UnityEngine.Rect, float>
                {
                    /*0x1654840*/ XProperty();
                    /*0x1654990*/ string get_Name();
                }

                class YProperty : Unity.Properties.Property<UnityEngine.Rect, float>
                {
                    /*0x1654a50*/ YProperty();
                    /*0x1654cd0*/ string get_Name();
                }

                class WidthProperty : Unity.Properties.Property<UnityEngine.Rect, float>
                {
                    /*0x16546a0*/ WidthProperty();
                    /*0x16546e0*/ string get_Name();
                }

                class HeightProperty : Unity.Properties.Property<UnityEngine.Rect, float>
                {
                    /*0x164fe90*/ HeightProperty();
                    /*0x164ff40*/ string get_Name();
                }
            }

            class RectIntPropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.RectInt>
            {
                /*0x1650870*/ RectIntPropertyBag();

                class XProperty : Unity.Properties.Property<UnityEngine.RectInt, int>
                {
                    /*0x16548c0*/ XProperty();
                    /*0x1654a20*/ string get_Name();
                }

                class YProperty : Unity.Properties.Property<UnityEngine.RectInt, int>
                {
                    /*0x1654b50*/ YProperty();
                    /*0x1654c70*/ string get_Name();
                }

                class WidthProperty : Unity.Properties.Property<UnityEngine.RectInt, int>
                {
                    /*0x1654660*/ WidthProperty();
                    /*0x1654710*/ string get_Name();
                }

                class HeightProperty : Unity.Properties.Property<UnityEngine.RectInt, int>
                {
                    /*0x164fed0*/ HeightProperty();
                    /*0x164ff10*/ string get_Name();
                }
            }

            class BoundsPropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Bounds>
            {
                /*0x164e8b0*/ BoundsPropertyBag();

                class CenterProperty : Unity.Properties.Property<UnityEngine.Bounds, UnityEngine.Vector3>
                {
                    /*0x164ea90*/ CenterProperty();
                    /*0x164ead0*/ string get_Name();
                }

                class ExtentsProperty : Unity.Properties.Property<UnityEngine.Bounds, UnityEngine.Vector3>
                {
                    /*0x164fd20*/ ExtentsProperty();
                    /*0x164fd60*/ string get_Name();
                }
            }

            class BoundsIntPropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.BoundsInt>
            {
                /*0x164e790*/ BoundsIntPropertyBag();

                class PositionProperty : Unity.Properties.Property<UnityEngine.BoundsInt, UnityEngine.Vector3Int>
                {
                    /*0x1650140*/ PositionProperty();
                    /*0x1650180*/ string get_Name();
                }

                class SizeProperty : Unity.Properties.Property<UnityEngine.BoundsInt, UnityEngine.Vector3Int>
                {
                    /*0x1651630*/ SizeProperty();
                    /*0x1651670*/ string get_Name();
                }
            }

            class SystemVersionPropertyBag : Unity.Properties.ContainerPropertyBag<System.Version>
            {
                /*0x16516a0*/ SystemVersionPropertyBag();

                class MajorProperty : Unity.Properties.Property<System.Version, int>
                {
                    /*0x164ff70*/ MajorProperty();
                    /*0x1650000*/ string get_Name();
                }

                class MinorProperty : Unity.Properties.Property<System.Version, int>
                {
                    /*0x1650030*/ MinorProperty();
                    /*0x16500c0*/ string get_Name();
                }

                class BuildProperty : Unity.Properties.Property<System.Version, int>
                {
                    /*0x164e9d0*/ BuildProperty();
                    /*0x164ea60*/ string get_Name();
                }

                class RevisionProperty : Unity.Properties.Property<System.Version, int>
                {
                    /*0x1651570*/ RevisionProperty();
                    /*0x1651600*/ string get_Name();
                }
            }

            interface IPropertyBagRegister
            {
                /*0x180fc0*/ void Register();
            }

            class PropertyBagStore
            {
                static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, Unity.Properties.IPropertyBag> s_PropertyBags;
                static /*0x8*/ System.Collections.Generic.List<System.Type> s_RegisteredTypes;
                static /*0x10*/ System.Action<System.Type, Unity.Properties.IPropertyBag> NewTypeRegistered;
                static /*0x18*/ Unity.Properties.Internal.ReflectedPropertyBagProvider s_PropertyBagProvider;

                static /*0x1650630*/ PropertyBagStore();
                static /*0x177be0*/ void AddPropertyBag<TContainer>(Unity.Properties.IPropertyBag<TContainer> propertyBag);
                static /*0x180cf0*/ Unity.Properties.IPropertyBag<TContainer> GetPropertyBag<TContainer>();
                static /*0x16501b0*/ Unity.Properties.IPropertyBag GetPropertyBag(System.Type type);

                struct TypedStore<TContainer>
                {
                    static /*0x0*/ Unity.Properties.IPropertyBag<TContainer> PropertyBag;
                }
            }

            class ReflectedPropertyBagAttribute : System.Attribute
            {
                /*0x534220*/ ReflectedPropertyBagAttribute();
            }

            class ReflectedPropertyBag<TContainer> : Unity.Properties.ContainerPropertyBag<TContainer>
            {
                /*0x180fc0*/ ReflectedPropertyBag();
                /*0x17aec0*/ void AddProperty<TValue>(Unity.Properties.Property<TContainer, TValue> property);
            }

            class ReflectedPropertyBagProvider
            {
                /*0x10*/ System.Reflection.MethodInfo m_CreatePropertyMethod;
                /*0x18*/ System.Reflection.MethodInfo m_CreatePropertyBagMethod;
                /*0x20*/ System.Reflection.MethodInfo m_CreateIndexedCollectionPropertyBagMethod;
                /*0x28*/ System.Reflection.MethodInfo m_CreateSetPropertyBagMethod;
                /*0x30*/ System.Reflection.MethodInfo m_CreateKeyValueCollectionPropertyBagMethod;
                /*0x38*/ System.Reflection.MethodInfo m_CreateKeyValuePairPropertyBagMethod;
                /*0x40*/ System.Reflection.MethodInfo m_CreateArrayPropertyBagMethod;
                /*0x48*/ System.Reflection.MethodInfo m_CreateListPropertyBagMethod;
                /*0x50*/ System.Reflection.MethodInfo m_CreateHashSetPropertyBagMethod;
                /*0x58*/ System.Reflection.MethodInfo m_CreateDictionaryPropertyBagMethod;

                static /*0x1650d60*/ System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetPropertyMembers(System.Type type);
                static /*0x1650de0*/ bool IsValidMember(System.Reflection.MemberInfo memberInfo);
                static /*0x1650f20*/ bool IsValidPropertyType(System.Type type);
                /*0x1651010*/ ReflectedPropertyBagProvider();
                /*0x1650c10*/ Unity.Properties.IPropertyBag CreatePropertyBag(System.Type type);
                /*0x1803b0*/ Unity.Properties.IPropertyBag<TContainer> CreatePropertyBag<TContainer>();
                /*0x183150*/ void CreateProperty<TContainer, TValue>(Unity.Properties.IMemberInfo member, Unity.Properties.Internal.ReflectedPropertyBag<TContainer> propertyBag);
                /*0x1803b0*/ Unity.Properties.IPropertyBag<TList> CreateIndexedCollectionPropertyBag<TList, TElement>();
                /*0x1803b0*/ Unity.Properties.IPropertyBag<TSet> CreateSetPropertyBag<TSet, TValue>();
                /*0x1803b0*/ Unity.Properties.IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag<TDictionary, TKey, TValue>();
                /*0x1803b0*/ Unity.Properties.IPropertyBag<System.Collections.Generic.KeyValuePair<TKey, TValue>> CreateKeyValuePairPropertyBag<TKey, TValue>();
                /*0x1803b0*/ Unity.Properties.IPropertyBag<TElement[]> CreateArrayPropertyBag<TElement>();
                /*0x1803b0*/ Unity.Properties.IPropertyBag<System.Collections.Generic.List<TElement>> CreateListPropertyBag<TElement>();
                /*0x1803b0*/ Unity.Properties.IPropertyBag<System.Collections.Generic.HashSet<TElement>> CreateHashSetPropertyBag<TElement>();
                /*0x1803b0*/ Unity.Properties.IPropertyBag<System.Collections.Generic.Dictionary<TKey, TValue>> CreateDictionaryPropertyBag<TKey, TValue>();

                class <>c
                {
                    static /*0x0*/ Unity.Properties.Internal.ReflectedPropertyBagProvider.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.MethodInfo, bool> <>9__10_0;
                    static /*0x10*/ System.Func<System.Reflection.MemberInfo, int> <>9__22_0;

                    static /*0x1653e70*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x1653d70*/ bool <.ctor>b__10_0(System.Reflection.MethodInfo x);
                    /*0x7190b0*/ int <GetPropertyMembers>b__22_0(System.Reflection.MemberInfo x);
                }

                class <GetPropertyMembers>d__22 : System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Reflection.MemberInfo <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Type type;
                    /*0x30*/ System.Type <>3__type;
                    /*0x38*/ System.Linq.IOrderedEnumerable<System.Reflection.MemberInfo> <members>5__1;
                    /*0x40*/ System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> <>s__2;
                    /*0x48*/ System.Reflection.MemberInfo <member>5__3;
                    /*0x50*/ bool <hasDontCreatePropertyAttribute>5__4;
                    /*0x51*/ bool <hasCreatePropertyAttribute>5__5;
                    /*0x52*/ bool <hasNonSerializedAttribute>5__6;
                    /*0x53*/ bool <hasSerializedFieldAttribute>5__7;
                    /*0x58*/ System.Reflection.FieldInfo <field>5__8;

                    /*0x70aad0*/ <GetPropertyMembers>d__22(int <>1__state);
                    /*0x1653be0*/ void System.IDisposable.Dispose();
                    /*0x1653240*/ bool MoveNext();
                    /*0x1653c70*/ void <>m__Finally1();
                    /*0x32f410*/ System.Reflection.MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current();
                    /*0x1653ba0*/ void System.Collections.IEnumerator.Reset();
                    /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
                    /*0x1653b00*/ System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator();
                    /*0x1653b00*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class ReflectionUtilities
            {
                static /*0x1651470*/ string SanitizeMemberName(System.Reflection.MemberInfo info);
            }
        }
    }
}
