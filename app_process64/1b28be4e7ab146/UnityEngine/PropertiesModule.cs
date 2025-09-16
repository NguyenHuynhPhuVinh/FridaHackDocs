class <Module>
{
}

namespace Unity
{
    namespace Properties
    {
        enum VisitExceptionKind
        {
            None = 0,
            Internal = 1,
            Visitor = 2,
            All = 3,
        }

        struct VisitParameters
        {
            /*0x10*/ Unity.Properties.VisitExceptionKind <IgnoreExceptions>k__BackingField;

            /*0x7f17dd4*/ Unity.Properties.VisitExceptionKind get_IgnoreExceptions();
        }

        class PropertyContainer
        {
            static /*0x3910ae8*/ void Accept<TContainer>(Unity.Properties.IPropertyBagVisitor visitor, ref TContainer container, Unity.Properties.VisitParameters parameters);
            static /*0x3910ae8*/ bool TryAccept<TContainer>(Unity.Properties.IPropertyBagVisitor visitor, ref TContainer container, Unity.Properties.VisitParameters parameters);
            static /*0x3910ae8*/ bool TryAccept<TContainer>(Unity.Properties.IPropertyBagVisitor visitor, ref TContainer container, ref Unity.Properties.VisitReturnCode returnCode, Unity.Properties.VisitParameters parameters);
            static /*0x3825c3c*/ bool TryGetProperty<TContainer>(ref TContainer container, ref Unity.Properties.PropertyPath path, ref Unity.Properties.IProperty property);
            static /*0x3825cc0*/ bool TryGetProperty<TContainer>(ref TContainer container, ref Unity.Properties.PropertyPath path, ref Unity.Properties.IProperty property, ref Unity.Properties.VisitReturnCode returnCode);
            static /*0x3825c3c*/ bool TryGetValue<TContainer, TValue>(ref TContainer container, string name, ref TValue value);
            static /*0x3825cc0*/ bool TryGetValue<TContainer, TValue>(ref TContainer container, ref Unity.Properties.PropertyPath path, ref TValue value, ref Unity.Properties.VisitReturnCode returnCode);

            class GetPropertyVisitor : Unity.Properties.PathVisitor
            {
                static /*0x0*/ UnityEngine.Pool.ObjectPool<Unity.Properties.PropertyContainer.GetPropertyVisitor> Pool;
                /*0xb8*/ Unity.Properties.IProperty Property;

                static /*0x7f17e74*/ GetPropertyVisitor();
                /*0x7f17e64*/ GetPropertyVisitor();
                /*0x7f17ddc*/ void Reset();
                /*0x3816920*/ void VisitPath<TContainer, TValue>(Unity.Properties.Property<TContainer, TValue> property, ref TContainer container, ref TValue value);

                class <>c
                {
                    static /*0x0*/ Unity.Properties.PropertyContainer.GetPropertyVisitor.<> <>9;

                    static /*0x7f18008*/ <>c();
                    /*0x7f18070*/ <>c();
                    /*0x7f18078*/ Unity.Properties.PropertyContainer.GetPropertyVisitor <.cctor>b__5_0();
                    /*0x7f180cc*/ void <.cctor>b__5_1(Unity.Properties.PropertyContainer.GetPropertyVisitor v);
                }
            }

            class GetValueVisitor<TSrcValue> : Unity.Properties.PathVisitor
            {
                static /*0x0*/ UnityEngine.Pool.ObjectPool<Unity.Properties.PropertyContainer.GetValueVisitor<TSrcValue>> Pool;
                /*0x0*/ TSrcValue Value;

                static /*0x383e7a0*/ GetValueVisitor();
                /*0x38159dc*/ GetValueVisitor();
                /*0x38159dc*/ void Reset();
                /*0x3816920*/ void VisitPath<TContainer, TValue>(Unity.Properties.Property<TContainer, TValue> property, ref TContainer container, ref TValue value);

                class <>c<TSrcValue>
                {
                    static /*0x0*/ Unity.Properties.PropertyContainer.GetValueVisitor.<>c<TSrcValue> <>9;

                    static /*0x383e7a0*/ <>c();
                    /*0x38159dc*/ <>c();
                    /*0x38148bc*/ Unity.Properties.PropertyContainer.GetValueVisitor<TSrcValue> <.cctor>b__5_0();
                    /*0x3816710*/ void <.cctor>b__5_1(Unity.Properties.PropertyContainer.GetValueVisitor<TSrcValue> v);
                }
            }
        }

        enum VisitReturnCode
        {
            Ok = 0,
            NullContainer = 1,
            InvalidContainerType = 2,
            MissingPropertyBag = 3,
            InvalidPath = 4,
            InvalidCast = 5,
            AccessViolation = 6,
        }

        class CreatePropertyAttribute : UnityEngine.Scripting.RequiredMemberAttribute
        {
            /*0x10*/ bool <ReadOnly>k__BackingField;

            /*0x7f18104*/ CreatePropertyAttribute();
            /*0x7f180f0*/ bool get_ReadOnly();
            /*0x7f180f8*/ void set_ReadOnly(bool value);
        }

        class DontCreatePropertyAttribute : System.Attribute
        {
            /*0x7f18110*/ DontCreatePropertyAttribute();
        }

        enum TypeGenerationOptions
        {
            None = 0,
            ValueType = 2,
            ReferenceType = 4,
            Default = 6,
        }

        class GeneratePropertyBagsForTypesQualifiedWithAttribute : System.Attribute
        {
            /*0x10*/ System.Type <Type>k__BackingField;
            /*0x18*/ Unity.Properties.TypeGenerationOptions <Options>k__BackingField;

            /*0x7f18118*/ GeneratePropertyBagsForTypesQualifiedWithAttribute(System.Type type, Unity.Properties.TypeGenerationOptions options);
        }

        class MissingPropertyBagException : System.Exception
        {
            /*0x90*/ System.Type <Type>k__BackingField;

            static /*0x7f18288*/ string GetMessageForType(System.Type type);
            /*0x7f18200*/ MissingPropertyBagException(System.Type type);
        }

        struct AttributesScope : System.IDisposable
        {
            /*0x10*/ Unity.Properties.Internal.IAttributes m_Target;
            /*0x18*/ System.Collections.Generic.List<System.Attribute> m_Previous;

            /*0x7f1830c*/ AttributesScope(Unity.Properties.IProperty target, Unity.Properties.IProperty source);
            /*0x7f18514*/ AttributesScope(Unity.Properties.Internal.IAttributes target, System.Collections.Generic.List<System.Attribute> attributes);
            /*0x7f18640*/ void Dispose();
        }

        class PropertyGetter<TContainer, TValue> : System.MulticastDelegate
        {
            PropertyGetter(object object, nint method);
            /*0x3910ae8*/ TValue Invoke(ref TContainer container);
        }

        class PropertySetter<TContainer, TValue> : System.MulticastDelegate
        {
            PropertySetter(object object, nint method);
            /*0x3910ae8*/ void Invoke(ref TContainer container, TValue value);
        }

        class DelegateProperty<TContainer, TValue> : Unity.Properties.Property<TContainer, TValue>
        {
            /*0x0*/ Unity.Properties.PropertyGetter<TContainer, TValue> m_Getter;
            /*0x0*/ Unity.Properties.PropertySetter<TContainer, TValue> m_Setter;
            /*0x0*/ string <Name>k__BackingField;

            /*0x3816920*/ DelegateProperty(string name, Unity.Properties.PropertyGetter<TContainer, TValue> getter, Unity.Properties.PropertySetter<TContainer, TValue> setter);
            /*0x38148bc*/ string get_Name();
            /*0x3813ffc*/ bool get_IsReadOnly();
            /*0x3910ae8*/ TValue GetValue(ref TContainer container);
            /*0x3910ae8*/ void SetValue(ref TContainer container, TValue value);
        }

        interface IListElementProperty
        {
            /*0x3814574*/ int get_Index();
        }

        interface ISetElementProperty
        {
            /*0x38148bc*/ object get_ObjectKey();
        }

        interface IDictionaryElementProperty
        {
            /*0x38148bc*/ object get_ObjectKey();
        }

        interface IProperty
        {
            /*0x38148bc*/ string get_Name();
            /*0x38148bc*/ System.Type DeclaredValueType();
        }

        interface IProperty<TContainer> : Unity.Properties.IProperty, Unity.Properties.IPropertyAccept<TContainer>
        {
        }

        class Property<TContainer, TValue> : Unity.Properties.IProperty<TContainer>, Unity.Properties.IProperty, Unity.Properties.IPropertyAccept<TContainer>, Unity.Properties.Internal.IAttributes
        {
            /*0x0*/ System.Collections.Generic.List<System.Attribute> m_Attributes;

            /*0x38159dc*/ Property();
            /*0x38148bc*/ System.Collections.Generic.List<System.Attribute> Unity.Properties.Internal.IAttributes.get_Attributes();
            /*0x3816710*/ void Unity.Properties.Internal.IAttributes.set_Attributes(System.Collections.Generic.List<System.Attribute> value);
            /*0x38148bc*/ string get_Name();
            /*0x3813ffc*/ bool get_IsReadOnly();
            /*0x38148bc*/ System.Type DeclaredValueType();
            /*0x3816810*/ void Accept(Unity.Properties.IPropertyVisitor visitor, ref TContainer container);
            /*0x3910ae8*/ TValue GetValue(ref TContainer container);
            /*0x3910ae8*/ void SetValue(ref TContainer container, TValue value);
            /*0x3816710*/ void AddAttribute(System.Attribute attribute);
            /*0x3816710*/ void AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes);
            /*0x3816710*/ void Unity.Properties.Internal.IAttributes.AddAttribute(System.Attribute attribute);
            /*0x3816710*/ void Unity.Properties.Internal.IAttributes.AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes);
            /*0x3813ffc*/ bool HasAttribute<TAttribute>();
            /*0x3910ae8*/ TAttribute GetAttribute<TAttribute>();
            Unity.Properties.AttributesScope Unity.Properties.Internal.IAttributes.CreateAttributesScope(Unity.Properties.Internal.IAttributes attributes);
        }

        enum PropertyPathPartKind
        {
            Name = 0,
            Index = 1,
            Key = 2,
        }

        struct PropertyPathPart : System.IEquatable<Unity.Properties.PropertyPathPart>
        {
            /*0x10*/ Unity.Properties.PropertyPathPartKind m_Kind;
            /*0x18*/ string m_Name;
            /*0x20*/ int m_Index;
            /*0x28*/ object m_Key;

            /*0x7f18808*/ PropertyPathPart(string name);
            /*0x7f18838*/ PropertyPathPart(int index);
            /*0x7f18888*/ PropertyPathPart(object key);
            /*0x7f186f4*/ bool get_IsName();
            /*0x7f18704*/ bool get_IsIndex();
            /*0x7f18714*/ Unity.Properties.PropertyPathPartKind get_Kind();
            /*0x7f1871c*/ string get_Name();
            /*0x7f18768*/ int get_Index();
            /*0x7f187b8*/ object get_Key();
            /*0x7f188dc*/ void CheckKind(Unity.Properties.PropertyPathPartKind type);
            /*0x7f18928*/ string ToString();
            /*0x7f18a50*/ bool Equals(Unity.Properties.PropertyPathPart other);
            /*0x7f18abc*/ bool Equals(object obj);
            /*0x7f18b44*/ int GetHashCode();
        }

        struct PropertyPath : System.IEquatable<Unity.Properties.PropertyPath>
        {
            static int k_InlineCount = 4;
            /*0x10*/ Unity.Properties.PropertyPathPart m_Part0;
            /*0x30*/ Unity.Properties.PropertyPathPart m_Part1;
            /*0x50*/ Unity.Properties.PropertyPathPart m_Part2;
            /*0x70*/ Unity.Properties.PropertyPathPart m_Part3;
            /*0x90*/ Unity.Properties.PropertyPathPart[] m_AdditionalParts;
            /*0x98*/ int <Length>k__BackingField;

            static /*0x7f1a3e0*/ Unity.Properties.PropertyPath FromIndex(int index);
            static /*0x7f1a4a4*/ Unity.Properties.PropertyPath Combine(ref Unity.Properties.PropertyPath path, ref Unity.Properties.PropertyPath pathToAppend);
            static /*0x7f1a908*/ Unity.Properties.PropertyPath AppendPart(ref Unity.Properties.PropertyPath path, ref Unity.Properties.PropertyPathPart part);
            static /*0x7f1ac60*/ Unity.Properties.PropertyPath AppendIndex(ref Unity.Properties.PropertyPath path, int index);
            static /*0x7f1ad04*/ Unity.Properties.PropertyPath AppendProperty(ref Unity.Properties.PropertyPath path, Unity.Properties.IProperty property);
            static /*0x7f1b028*/ Unity.Properties.PropertyPath Pop(ref Unity.Properties.PropertyPath path);
            static /*0x7f1b064*/ Unity.Properties.PropertyPath SubPath(ref Unity.Properties.PropertyPath path, int startIndex, int length);
            static /*0x7f1b6cc*/ void AppendToBuilder(ref Unity.Properties.PropertyPathPart part, System.Text.StringBuilder builder);
            static /*0x7f1a80c*/ void GetParts(ref Unity.Properties.PropertyPath path, System.Collections.Generic.List<Unity.Properties.PropertyPathPart> parts);
            static /*0x7f18df0*/ Unity.Properties.PropertyPath ConstructFromPath(string path);
            static /*0x7f1b910*/ bool op_Equality(Unity.Properties.PropertyPath lhs, Unity.Properties.PropertyPath rhs);
            static /*0x7f1b9e0*/ bool op_Inequality(Unity.Properties.PropertyPath lhs, Unity.Properties.PropertyPath rhs);
            static /*0x7f1b780*/ void <ConstructFromPath>g__TrimStart|36_0(ref Unity.Properties.PropertyPath.<> );
            static /*0x7f1b7d0*/ void <ConstructFromPath>g__ReadNext|36_1(ref Unity.Properties.PropertyPath.<> );
            /*0x7f18cfc*/ PropertyPath(string path);
            /*0x7f19fc8*/ PropertyPath(ref Unity.Properties.PropertyPathPart part);
            /*0x7f1a014*/ PropertyPath(ref Unity.Properties.PropertyPathPart part0, ref Unity.Properties.PropertyPathPart part1);
            /*0x7f1a07c*/ PropertyPath(ref Unity.Properties.PropertyPathPart part0, ref Unity.Properties.PropertyPathPart part1, ref Unity.Properties.PropertyPathPart part2);
            /*0x7f1a0f8*/ PropertyPath(ref Unity.Properties.PropertyPathPart part0, ref Unity.Properties.PropertyPathPart part1, ref Unity.Properties.PropertyPathPart part2, ref Unity.Properties.PropertyPathPart part3);
            /*0x7f1a18c*/ PropertyPath(System.Collections.Generic.List<Unity.Properties.PropertyPathPart> parts);
            /*0x7f18bec*/ int get_Length();
            /*0x7f18bf4*/ bool get_IsEmpty();
            /*0x7f18c04*/ Unity.Properties.PropertyPathPart get_Item(int index);
            /*0x7f1b54c*/ string ToString();
            /*0x7f1b944*/ bool Equals(Unity.Properties.PropertyPath other);
            /*0x7f1ba34*/ bool Equals(object obj);
            /*0x7f1bac4*/ int GetHashCode();

            struct <>c__DisplayClass36_0
            {
                /*0x10*/ int index;
                /*0x14*/ int length;
                /*0x18*/ string path;
                /*0x20*/ int state;
            }
        }

        interface IMemberInfo
        {
            /*0x38148bc*/ string get_Name();
            /*0x3813ffc*/ bool get_IsReadOnly();
            /*0x38148bc*/ System.Type get_ValueType();
            /*0x3814a3c*/ object GetValue(object obj);
            /*0x3816810*/ void SetValue(object obj, object value);
            /*0x38148bc*/ System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes();
        }

        struct FieldMember : Unity.Properties.IMemberInfo
        {
            /*0x10*/ System.Reflection.FieldInfo m_FieldInfo;
            /*0x18*/ string <Name>k__BackingField;

            /*0x7f1bbcc*/ FieldMember(System.Reflection.FieldInfo fieldInfo);
            /*0x7f1bcec*/ string get_Name();
            /*0x7f1bcf4*/ bool get_IsReadOnly();
            /*0x7f1bd10*/ System.Type get_ValueType();
            /*0x7f1bd34*/ object GetValue(object obj);
            /*0x7f1bd58*/ void SetValue(object obj, object value);
            /*0x7f1bd74*/ System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes();
        }

        struct PropertyMember : Unity.Properties.IMemberInfo
        {
            /*0x10*/ System.Reflection.PropertyInfo m_PropertyInfo;
            /*0x18*/ string <Name>k__BackingField;

            /*0x7f1bddc*/ PropertyMember(System.Reflection.PropertyInfo propertyInfo);
            /*0x7f1bd80*/ string get_Name();
            /*0x7f1bd88*/ bool get_IsReadOnly();
            /*0x7f1bdb8*/ System.Type get_ValueType();
            /*0x7f1be08*/ object GetValue(object obj);
            /*0x7f1be24*/ void SetValue(object obj, object value);
            /*0x7f1be40*/ System.Collections.Generic.IEnumerable<System.Attribute> GetCustomAttributes();
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

            /*0x3816810*/ ReflectedMemberProperty(Unity.Properties.IMemberInfo info, string name);
            /*0x38148bc*/ string get_Name();
            /*0x3813ffc*/ bool get_IsReadOnly();
            /*0x3910ae8*/ TValue GetValue(ref TContainer container);
            /*0x3910ae8*/ void SetValue(ref TContainer container, TValue value);

            class GetStructValueAction<TContainer, TValue> : System.MulticastDelegate
            {
                GetStructValueAction(object object, nint method);
                /*0x3910ae8*/ TValue Invoke(ref TContainer container);
            }

            class SetStructValueAction<TContainer, TValue> : System.MulticastDelegate
            {
                SetStructValueAction(object object, nint method);
                /*0x3910ae8*/ void Invoke(ref TContainer container, TValue value);
            }

            class GetClassValueAction<TContainer, TValue> : System.MulticastDelegate
            {
                GetClassValueAction(object object, nint method);
                /*0x3910ae8*/ TValue Invoke(TContainer container);
            }

            class SetClassValueAction<TContainer, TValue> : System.MulticastDelegate
            {
                SetClassValueAction(object object, nint method);
                /*0x3910ae8*/ void Invoke(TContainer container, TValue value);
            }
        }

        class ArrayPropertyBag<TElement> : Unity.Properties.IndexedCollectionPropertyBag<TElement[], TElement>
        {
            /*0x38159dc*/ ArrayPropertyBag();
            /*0x3814574*/ Unity.Properties.InstantiationKind get_InstantiationKind();
            /*0x3814964*/ TElement[] InstantiateWithCount(int count);
            /*0x38148bc*/ TElement[] Instantiate();
        }

        class ContainerPropertyBag<TContainer> : Unity.Properties.PropertyBag<TContainer>, Unity.Properties.INamedProperties<TContainer>
        {
            /*0x0*/ System.Collections.Generic.List<Unity.Properties.IProperty<TContainer>> m_PropertiesList;
            /*0x0*/ System.Collections.Generic.Dictionary<string, Unity.Properties.IProperty<TContainer>> m_PropertiesHash;

            static /*0x383e7a0*/ ContainerPropertyBag();
            /*0x38159dc*/ ContainerPropertyBag();
            /*0x3816710*/ void AddProperty<TValue>(Unity.Properties.Property<TContainer, TValue> property);
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<TContainer> GetProperties();
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<TContainer> GetProperties(ref TContainer container);
            bool TryGetProperty(ref TContainer container, string name, ref Unity.Properties.IProperty<TContainer> property);
        }

        class DictionaryPropertyBag<TKey, TValue> : Unity.Properties.KeyValueCollectionPropertyBag<System.Collections.Generic.Dictionary<TKey, TValue>, TKey, TValue>
        {
            /*0x38159dc*/ DictionaryPropertyBag();
            /*0x3814574*/ Unity.Properties.InstantiationKind get_InstantiationKind();
            /*0x38148bc*/ System.Collections.Generic.Dictionary<TKey, TValue> Instantiate();
        }

        class HashSetPropertyBag<TElement> : Unity.Properties.SetPropertyBagBase<System.Collections.Generic.HashSet<TElement>, TElement>
        {
            /*0x38159dc*/ HashSetPropertyBag();
            /*0x3814574*/ Unity.Properties.InstantiationKind get_InstantiationKind();
            /*0x38148bc*/ System.Collections.Generic.HashSet<TElement> Instantiate();
        }

        interface IIndexedProperties<TContainer>
        {
            bool TryGetProperty(ref TContainer container, int index, ref Unity.Properties.IProperty<TContainer> property);
        }

        interface INamedProperties<TContainer>
        {
            bool TryGetProperty(ref TContainer container, string name, ref Unity.Properties.IProperty<TContainer> property);
        }

        interface IKeyedProperties<TContainer, TKey>
        {
            /*0x3910ae8*/ bool TryGetProperty(ref TContainer container, TKey key, ref Unity.Properties.IProperty<TContainer> property);
        }

        interface IPropertyBag
        {
            /*0x3816710*/ void Accept(Unity.Properties.ITypeVisitor visitor);
            /*0x3816810*/ void Accept(Unity.Properties.IPropertyBagVisitor visitor, ref object container);
        }

        interface IPropertyBag<TContainer> : Unity.Properties.IPropertyBag
        {
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<TContainer> GetProperties();
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<TContainer> GetProperties(ref TContainer container);
            /*0x3816810*/ void Accept(Unity.Properties.IPropertyBagVisitor visitor, ref TContainer container);
        }

        interface ICollectionPropertyBag<TCollection, TElement> : Unity.Properties.IPropertyBag<TCollection>, Unity.Properties.IPropertyBag, Unity.Properties.ICollectionPropertyBagAccept<TCollection>
        {
        }

        interface IListPropertyBag<TList, TElement> : Unity.Properties.ICollectionPropertyBag<TList, TElement>, Unity.Properties.IPropertyBag<TList>, Unity.Properties.IPropertyBag, Unity.Properties.ICollectionPropertyBagAccept<TList>, Unity.Properties.IListPropertyBagAccept<TList>, Unity.Properties.IListPropertyAccept<TList>, Unity.Properties.IIndexedProperties<TList>
        {
        }

        interface ISetPropertyBag<TSet, TElement> : Unity.Properties.ICollectionPropertyBag<TSet, TElement>, Unity.Properties.IPropertyBag<TSet>, Unity.Properties.IPropertyBag, Unity.Properties.ICollectionPropertyBagAccept<TSet>, Unity.Properties.ISetPropertyBagAccept<TSet>, Unity.Properties.IKeyedProperties<TSet, object>
        {
        }

        interface IDictionaryPropertyBag<TDictionary, TKey, TValue> : Unity.Properties.ICollectionPropertyBag<TDictionary, System.Collections.Generic.KeyValuePair<TKey, TValue>>, Unity.Properties.IPropertyBag<TDictionary>, Unity.Properties.IPropertyBag, Unity.Properties.ICollectionPropertyBagAccept<TDictionary>, Unity.Properties.IDictionaryPropertyBagAccept<TDictionary>, Unity.Properties.IKeyedProperties<TDictionary, object>
        {
        }

        struct IndexedCollectionPropertyBagEnumerable<TContainer>
        {
            /*0x0*/ Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl;
            /*0x0*/ TContainer m_Container;

            /*0x3910ae8*/ IndexedCollectionPropertyBagEnumerable(Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container);
            /*0x3910ae8*/ Unity.Properties.IndexedCollectionPropertyBagEnumerator<TContainer> GetEnumerator();
        }

        struct IndexedCollectionPropertyBagEnumerator<TContainer> : System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TContainer>>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl;
            /*0x0*/ Unity.Properties.IndexedCollectionSharedPropertyState m_Previous;
            /*0x0*/ TContainer m_Container;
            /*0x0*/ int m_Position;

            /*0x3910ae8*/ IndexedCollectionPropertyBagEnumerator(Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container);
            /*0x38148bc*/ Unity.Properties.IProperty<TContainer> get_Current();
            /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
            /*0x3813ffc*/ bool MoveNext();
            /*0x38159dc*/ void Reset();
            /*0x38159dc*/ void Dispose();
        }

        interface IIndexedCollectionPropertyBagEnumerator<TContainer>
        {
            /*0x381467c*/ int GetCount(ref TContainer container);
            /*0x38148bc*/ Unity.Properties.IProperty<TContainer> GetSharedProperty();
            Unity.Properties.IndexedCollectionSharedPropertyState GetSharedPropertyState();
            void SetSharedPropertyState(Unity.Properties.IndexedCollectionSharedPropertyState state);
        }

        struct IndexedCollectionSharedPropertyState
        {
            /*0x10*/ int Index;
            /*0x14*/ bool IsReadOnly;
        }

        class IndexedCollectionPropertyBag<TList, TElement> : Unity.Properties.PropertyBag<TList>, Unity.Properties.IListPropertyBag<TList, TElement>, Unity.Properties.ICollectionPropertyBag<TList, TElement>, Unity.Properties.IPropertyBag<TList>, Unity.Properties.IPropertyBag, Unity.Properties.ICollectionPropertyBagAccept<TList>, Unity.Properties.IListPropertyBagAccept<TList>, Unity.Properties.IListPropertyAccept<TList>, Unity.Properties.IIndexedProperties<TList>, Unity.Properties.IConstructorWithCount<TList>, Unity.Properties.IConstructor, Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>
        {
            /*0x0*/ Unity.Properties.IndexedCollectionPropertyBag.ListElementProperty<TList, TElement> m_Property;

            /*0x38159dc*/ IndexedCollectionPropertyBag();
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<TList> GetProperties();
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<TList> GetProperties(ref TList container);
            bool TryGetProperty(ref TList container, int index, ref Unity.Properties.IProperty<TList> property);
            /*0x3816810*/ void Unity.Properties.ICollectionPropertyBagAccept<TList>.Accept(Unity.Properties.ICollectionPropertyBagVisitor visitor, ref TList container);
            /*0x3816810*/ void Unity.Properties.IListPropertyBagAccept<TList>.Accept(Unity.Properties.IListPropertyBagVisitor visitor, ref TList list);
            /*0x3816958*/ void Unity.Properties.IListPropertyAccept<TList>.Accept<TContainer>(Unity.Properties.IListPropertyVisitor visitor, Unity.Properties.Property<TContainer, TList> property, ref TContainer container, ref TList list);
            /*0x3910ae8*/ TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count);
            /*0x3910ae8*/ TList InstantiateWithCount(int count);
            /*0x381467c*/ int Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetCount(ref TList container);
            /*0x38148bc*/ Unity.Properties.IProperty<TList> Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedProperty();
            Unity.Properties.IndexedCollectionSharedPropertyState Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.GetSharedPropertyState();
            void Unity.Properties.IIndexedCollectionPropertyBagEnumerator<TList>.SetSharedPropertyState(Unity.Properties.IndexedCollectionSharedPropertyState state);

            class ListElementProperty<TList, TElement> : Unity.Properties.Property<TList, TElement>, Unity.Properties.IListElementProperty
            {
                /*0x0*/ int m_Index;
                /*0x0*/ bool m_IsReadOnly;

                /*0x38159dc*/ ListElementProperty();
                /*0x3814574*/ int get_Index();
                /*0x38148bc*/ string get_Name();
                /*0x3813ffc*/ bool get_IsReadOnly();
                /*0x3910ae8*/ TElement GetValue(ref TList container);
                /*0x3910ae8*/ void SetValue(ref TList container, TElement value);
            }
        }

        class KeyValueCollectionPropertyBag<TDictionary, TKey, TValue> : Unity.Properties.PropertyBag<TDictionary>, Unity.Properties.IDictionaryPropertyBag<TDictionary, TKey, TValue>, Unity.Properties.ICollectionPropertyBag<TDictionary, System.Collections.Generic.KeyValuePair<TKey, TValue>>, Unity.Properties.IPropertyBag<TDictionary>, Unity.Properties.IPropertyBag, Unity.Properties.ICollectionPropertyBagAccept<TDictionary>, Unity.Properties.IDictionaryPropertyBagAccept<TDictionary>, Unity.Properties.IKeyedProperties<TDictionary, object>
        {
            /*0x0*/ Unity.Properties.KeyValueCollectionPropertyBag.KeyValuePairProperty<TDictionary, TKey, TValue> m_KeyValuePairProperty;

            /*0x38159dc*/ KeyValueCollectionPropertyBag();
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<TDictionary> GetProperties();
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<TDictionary> GetProperties(ref TDictionary container);
            /*0x3816810*/ void Unity.Properties.ICollectionPropertyBagAccept<TDictionary>.Accept(Unity.Properties.ICollectionPropertyBagVisitor visitor, ref TDictionary container);
            /*0x3816810*/ void Unity.Properties.IDictionaryPropertyBagAccept<TDictionary>.Accept(Unity.Properties.IDictionaryPropertyBagVisitor visitor, ref TDictionary container);
            bool Unity.Properties.IKeyedProperties<TDictionary,System.Object>.TryGetProperty(ref TDictionary container, object key, ref Unity.Properties.IProperty<TDictionary> property);

            class KeyValuePairProperty<TDictionary, TKey, TValue> : Unity.Properties.Property<TDictionary, System.Collections.Generic.KeyValuePair<TKey, TValue>>, Unity.Properties.IDictionaryElementProperty
            {
                /*0x0*/ TKey <Key>k__BackingField;

                /*0x38159dc*/ KeyValuePairProperty();
                /*0x38148bc*/ string get_Name();
                /*0x3813ffc*/ bool get_IsReadOnly();
                /*0x3910ae8*/ System.Collections.Generic.KeyValuePair<TKey, TValue> GetValue(ref TDictionary container);
                /*0x3910ae8*/ void SetValue(ref TDictionary container, System.Collections.Generic.KeyValuePair<TKey, TValue> value);
                /*0x3910ae8*/ TKey get_Key();
                /*0x3910ae8*/ void set_Key(TKey value);
                /*0x38148bc*/ object get_ObjectKey();
            }

            struct Enumerable<TDictionary, TKey, TValue> : System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TDictionary>>, System.Collections.IEnumerable
            {
                /*0x0*/ TDictionary m_Dictionary;
                /*0x0*/ Unity.Properties.KeyValueCollectionPropertyBag.KeyValuePairProperty<TDictionary, TKey, TValue> m_Property;

                /*0x3910ae8*/ Enumerable(TDictionary dictionary, Unity.Properties.KeyValueCollectionPropertyBag.KeyValuePairProperty<TDictionary, TKey, TValue> property);
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TDictionary>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TDictionary>>.GetEnumerator();

                class Enumerator<TDictionary, TKey, TValue> : System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TDictionary>>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x0*/ TDictionary m_Dictionary;
                    /*0x0*/ Unity.Properties.KeyValueCollectionPropertyBag.KeyValuePairProperty<TDictionary, TKey, TValue> m_Property;
                    /*0x0*/ TKey m_Previous;
                    /*0x0*/ System.Collections.Generic.List<TKey> m_Keys;
                    /*0x0*/ int m_Position;

                    /*0x3910ae8*/ Enumerator(TDictionary dictionary, Unity.Properties.KeyValueCollectionPropertyBag.KeyValuePairProperty<TDictionary, TKey, TValue> property);
                    /*0x38148bc*/ Unity.Properties.IProperty<TDictionary> get_Current();
                    /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                    /*0x3813ffc*/ bool MoveNext();
                    /*0x38159dc*/ void Reset();
                    /*0x38159dc*/ void Dispose();
                }
            }
        }

        class KeyValuePairPropertyBag<TKey, TValue> : Unity.Properties.PropertyBag<System.Collections.Generic.KeyValuePair<TKey, TValue>>, Unity.Properties.INamedProperties<System.Collections.Generic.KeyValuePair<TKey, TValue>>
        {
            static /*0x0*/ Unity.Properties.DelegateProperty<System.Collections.Generic.KeyValuePair<TKey, TValue>, TKey> s_KeyProperty;
            static /*0x0*/ Unity.Properties.DelegateProperty<System.Collections.Generic.KeyValuePair<TKey, TValue>, TValue> s_ValueProperty;

            static /*0x383e7a0*/ KeyValuePairPropertyBag();
            static /*0x3836db8*/ System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey, TValue>>> GetPropertiesEnumerable();
            /*0x38159dc*/ KeyValuePairPropertyBag();
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetProperties();
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetProperties(ref System.Collections.Generic.KeyValuePair<TKey, TValue> container);
            bool TryGetProperty(ref System.Collections.Generic.KeyValuePair<TKey, TValue> container, string name, ref Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey, TValue>> property);

            class <>c<TKey, TValue>
            {
                static /*0x0*/ Unity.Properties.KeyValuePairPropertyBag.<>c<TKey, TValue> <>9;

                static /*0x383e7a0*/ <>c();
                /*0x38159dc*/ <>c();
                /*0x3910ae8*/ TKey <.cctor>b__7_0(ref System.Collections.Generic.KeyValuePair<TKey, TValue> container);
                /*0x3910ae8*/ TValue <.cctor>b__7_1(ref System.Collections.Generic.KeyValuePair<TKey, TValue> container);
            }

            class <GetPropertiesEnumerable>d__4<TKey, TValue> : System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey, TValue>>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey, TValue>>>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey, TValue>> <>2__current;
                /*0x0*/ int <>l__initialThreadId;

                /*0x3815ed0*/ <GetPropertiesEnumerable>d__4(int <>1__state);
                /*0x38159dc*/ void System.IDisposable.Dispose();
                /*0x3813ffc*/ bool MoveNext();
                /*0x38148bc*/ Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>>>.get_Current();
                /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey, TValue>>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<System.Collections.Generic.KeyValuePair<TKey,TValue>>>.GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class ListPropertyBag<TElement> : Unity.Properties.IndexedCollectionPropertyBag<System.Collections.Generic.List<TElement>, TElement>
        {
            /*0x38159dc*/ ListPropertyBag();
            /*0x3814574*/ Unity.Properties.InstantiationKind get_InstantiationKind();
            /*0x3814964*/ System.Collections.Generic.List<TElement> InstantiateWithCount(int count);
            /*0x38148bc*/ System.Collections.Generic.List<TElement> Instantiate();
        }

        class PropertyBag
        {
            static /*0x3844b58*/ void AcceptWithSpecializedVisitor<TContainer>(Unity.Properties.IPropertyBag<TContainer> properties, Unity.Properties.IPropertyBagVisitor visitor, ref TContainer container);
            static /*0x3840c74*/ void Register<TContainer>(Unity.Properties.PropertyBag<TContainer> propertyBag);
            static /*0x383e7a0*/ void RegisterList<TElement>();
            static /*0x383e7a0*/ void RegisterList<TContainer, TElement>();
            static /*0x7f1be4c*/ Unity.Properties.IPropertyBag GetPropertyBag(System.Type type);
            static /*0x3836db8*/ Unity.Properties.IPropertyBag<TContainer> GetPropertyBag<TContainer>();
            static /*0x3825b78*/ bool TryGetPropertyBagForValue<TValue>(ref TValue value, ref Unity.Properties.IPropertyBag propertyBag);
        }

        class PropertyBag<TContainer> : Unity.Properties.IPropertyBag<TContainer>, Unity.Properties.IPropertyBag, Unity.Properties.Internal.IPropertyBagRegister, Unity.Properties.IConstructor<TContainer>, Unity.Properties.IConstructor
        {
            /*0x0*/ Unity.Properties.InstantiationKind <InstantiationKind>k__BackingField;

            static /*0x383e7a0*/ PropertyBag();
            /*0x38159dc*/ PropertyBag();
            /*0x38159dc*/ void Unity.Properties.Internal.IPropertyBagRegister.Register();
            /*0x3816710*/ void Accept(Unity.Properties.ITypeVisitor visitor);
            /*0x3816810*/ void Unity.Properties.IPropertyBag.Accept(Unity.Properties.IPropertyBagVisitor visitor, ref object container);
            /*0x3816810*/ void Unity.Properties.IPropertyBag<TContainer>.Accept(Unity.Properties.IPropertyBagVisitor visitor, ref TContainer container);
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<TContainer> Unity.Properties.IPropertyBag<TContainer>.GetProperties();
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<TContainer> Unity.Properties.IPropertyBag<TContainer>.GetProperties(ref TContainer container);
            /*0x3814574*/ Unity.Properties.InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind();
            /*0x3910ae8*/ TContainer Unity.Properties.IConstructor<TContainer>.Instantiate();
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<TContainer> GetProperties();
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<TContainer> GetProperties(ref TContainer container);
            /*0x3814574*/ Unity.Properties.InstantiationKind get_InstantiationKind();
            /*0x3910ae8*/ TContainer Instantiate();
        }

        struct PropertyCollection<TContainer> : System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>, System.Collections.IEnumerable
        {
            static /*0x0*/ Unity.Properties.PropertyCollection<TContainer> <Empty>k__BackingField;
            /*0x0*/ Unity.Properties.PropertyCollection.EnumeratorType<TContainer> m_Type;
            /*0x0*/ System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>> m_Enumerable;
            /*0x0*/ System.Collections.Generic.List<Unity.Properties.IProperty<TContainer>> m_Properties;
            /*0x0*/ Unity.Properties.IndexedCollectionPropertyBagEnumerable<TContainer> m_IndexedCollectionPropertyBag;

            static /*0x383e7a0*/ PropertyCollection();
            static /*0x3910ae8*/ Unity.Properties.PropertyCollection<TContainer> get_Empty();
            /*0x3816710*/ PropertyCollection(System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>> enumerable);
            /*0x3816710*/ PropertyCollection(System.Collections.Generic.List<Unity.Properties.IProperty<TContainer>> properties);
            /*0x3910ae8*/ PropertyCollection(Unity.Properties.IndexedCollectionPropertyBagEnumerable<TContainer> enumerable);
            /*0x3910ae8*/ Unity.Properties.PropertyCollection.Enumerator<TContainer> GetEnumerator();
            /*0x38148bc*/ System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TContainer>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TContainer>>.GetEnumerator();
            /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();

            enum EnumeratorType<TContainer>
            {
                Empty = 0,
                Enumerable = 1,
                List = 2,
                IndexedCollectionPropertyBag = 3,
            }

            struct Enumerator<TContainer> : System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TContainer>>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ Unity.Properties.PropertyCollection.EnumeratorType<TContainer> m_Type;
                /*0x0*/ System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TContainer>> m_Enumerator;
                /*0x0*/ System.Collections.Generic.List.Enumerator<Unity.Properties.IProperty<TContainer>> m_Properties;
                /*0x0*/ Unity.Properties.IndexedCollectionPropertyBagEnumerator<TContainer> m_IndexedCollectionPropertyBag;
                /*0x0*/ Unity.Properties.IProperty<TContainer> <Current>k__BackingField;

                /*0x3816710*/ Enumerator(System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TContainer>> enumerator);
                /*0x3910ae8*/ Enumerator(System.Collections.Generic.List.Enumerator<Unity.Properties.IProperty<TContainer>> properties);
                /*0x3910ae8*/ Enumerator(Unity.Properties.IndexedCollectionPropertyBagEnumerator<TContainer> enumerator);
                /*0x38148bc*/ Unity.Properties.IProperty<TContainer> get_Current();
                /*0x3816710*/ void set_Current(Unity.Properties.IProperty<TContainer> value);
                /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                /*0x3813ffc*/ bool MoveNext();
                /*0x38159dc*/ void Reset();
                /*0x38159dc*/ void Dispose();
            }
        }

        class SetPropertyBagBase<TSet, TElement> : Unity.Properties.PropertyBag<TSet>, Unity.Properties.ISetPropertyBag<TSet, TElement>, Unity.Properties.ICollectionPropertyBag<TSet, TElement>, Unity.Properties.IPropertyBag<TSet>, Unity.Properties.IPropertyBag, Unity.Properties.ICollectionPropertyBagAccept<TSet>, Unity.Properties.ISetPropertyBagAccept<TSet>, Unity.Properties.IKeyedProperties<TSet, object>
        {
            /*0x0*/ Unity.Properties.SetPropertyBagBase.SetElementProperty<TSet, TElement> m_Property;

            /*0x38159dc*/ SetPropertyBagBase();
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<TSet> GetProperties();
            /*0x3910ae8*/ Unity.Properties.PropertyCollection<TSet> GetProperties(ref TSet container);
            /*0x3910ae8*/ System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TSet>> GetPropertiesEnumerable(TSet container);
            /*0x3816810*/ void Unity.Properties.ICollectionPropertyBagAccept<TSet>.Accept(Unity.Properties.ICollectionPropertyBagVisitor visitor, ref TSet container);
            /*0x3816810*/ void Unity.Properties.ISetPropertyBagAccept<TSet>.Accept(Unity.Properties.ISetPropertyBagVisitor visitor, ref TSet container);
            bool TryGetProperty(ref TSet container, object key, ref Unity.Properties.IProperty<TSet> property);

            class SetElementProperty<TSet, TElement> : Unity.Properties.Property<TSet, TElement>, Unity.Properties.ISetElementProperty
            {
                /*0x0*/ TElement m_Value;

                /*0x38159dc*/ SetElementProperty();
                /*0x38148bc*/ string get_Name();
                /*0x3813ffc*/ bool get_IsReadOnly();
                /*0x3910ae8*/ TElement GetValue(ref TSet container);
                /*0x3910ae8*/ void SetValue(ref TSet container, TElement value);
                /*0x38148bc*/ object get_ObjectKey();
            }

            class <GetPropertiesEnumerable>d__4<TSet, TElement> : System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TSet>>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TSet>>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ Unity.Properties.IProperty<TSet> <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ TSet container;
                /*0x0*/ TSet <>3__container;
                /*0x0*/ Unity.Properties.SetPropertyBagBase<TSet, TElement> <>4__this;
                /*0x0*/ System.Collections.Generic.IEnumerator<TElement> <>s__1;
                /*0x0*/ TElement <element>5__2;

                /*0x3815ed0*/ <GetPropertiesEnumerable>d__4(int <>1__state);
                /*0x38159dc*/ void System.IDisposable.Dispose();
                /*0x3813ffc*/ bool MoveNext();
                /*0x38159dc*/ void <>m__Finally1();
                /*0x38148bc*/ Unity.Properties.IProperty<TSet> System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TSet>>.get_Current();
                /*0x38159dc*/ void System.Collections.IEnumerator.Reset();
                /*0x38148bc*/ object System.Collections.IEnumerator.get_Current();
                /*0x38148bc*/ System.Collections.Generic.IEnumerator<Unity.Properties.IProperty<TSet>> System.Collections.Generic.IEnumerable<Unity.Properties.IProperty<TSet>>.GetEnumerator();
                /*0x38148bc*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class ConcreteTypeVisitor : Unity.Properties.IPropertyBagVisitor
        {
            /*0x7f1c0e4*/ ConcreteTypeVisitor();
            /*0x3816710*/ void VisitContainer<TContainer>(ref TContainer container);
            /*0x3816810*/ void Unity.Properties.IPropertyBagVisitor.Visit<TContainer>(Unity.Properties.IPropertyBag<TContainer> properties, ref TContainer container);
        }

        interface ICollectionPropertyBagAccept<TContainer>
        {
            /*0x3816810*/ void Accept(Unity.Properties.ICollectionPropertyBagVisitor visitor, ref TContainer container);
        }

        interface IListPropertyBagAccept<TContainer>
        {
            /*0x3816810*/ void Accept(Unity.Properties.IListPropertyBagVisitor visitor, ref TContainer container);
        }

        interface ISetPropertyBagAccept<TContainer>
        {
            /*0x3816810*/ void Accept(Unity.Properties.ISetPropertyBagVisitor visitor, ref TContainer container);
        }

        interface IDictionaryPropertyBagAccept<TContainer>
        {
            /*0x3816810*/ void Accept(Unity.Properties.IDictionaryPropertyBagVisitor visitor, ref TContainer container);
        }

        interface IPropertyAccept<TContainer>
        {
            /*0x3816810*/ void Accept(Unity.Properties.IPropertyVisitor visitor, ref TContainer container);
        }

        interface IListPropertyAccept<TList>
        {
            /*0x3816958*/ void Accept<TContainer>(Unity.Properties.IListPropertyVisitor visitor, Unity.Properties.Property<TContainer, TList> property, ref TContainer container, ref TList list);
        }

        interface ITypeVisitor
        {
            /*0x38159dc*/ void Visit<TContainer>();
        }

        interface IPropertyBagVisitor
        {
            /*0x3816810*/ void Visit<TContainer>(Unity.Properties.IPropertyBag<TContainer> properties, ref TContainer container);
        }

        interface ICollectionPropertyBagVisitor
        {
            /*0x3816810*/ void Visit<TCollection, TElement>(Unity.Properties.ICollectionPropertyBag<TCollection, TElement> properties, ref TCollection container);
        }

        interface IListPropertyBagVisitor
        {
            /*0x3816810*/ void Visit<TList, TElement>(Unity.Properties.IListPropertyBag<TList, TElement> properties, ref TList container);
        }

        interface ISetPropertyBagVisitor
        {
            /*0x3816810*/ void Visit<TSet, TValue>(Unity.Properties.ISetPropertyBag<TSet, TValue> properties, ref TSet container);
        }

        interface IDictionaryPropertyBagVisitor
        {
            /*0x3816810*/ void Visit<TDictionary, TKey, TValue>(Unity.Properties.IDictionaryPropertyBag<TDictionary, TKey, TValue> properties, ref TDictionary container);
        }

        interface IPropertyVisitor
        {
            /*0x3816810*/ void Visit<TContainer, TValue>(Unity.Properties.Property<TContainer, TValue> property, ref TContainer container);
        }

        interface IListPropertyVisitor
        {
            /*0x3816920*/ void Visit<TContainer, TList, TElement>(Unity.Properties.Property<TContainer, TList> property, ref TContainer container, ref TList list);
        }

        class PathVisitor : Unity.Properties.IPropertyBagVisitor, Unity.Properties.IPropertyVisitor
        {
            /*0x10*/ int m_PathIndex;
            /*0x18*/ Unity.Properties.PropertyPath <Path>k__BackingField;
            /*0xa8*/ Unity.Properties.IProperty <Property>k__BackingField;
            /*0xb0*/ bool <ReadonlyVisit>k__BackingField;
            /*0xb4*/ Unity.Properties.VisitReturnCode <ReturnCode>k__BackingField;

            /*0x7f17e6c*/ PathVisitor();
            /*0x7f1c0ec*/ Unity.Properties.PropertyPath get_Path();
            /*0x7f1c0fc*/ void set_Path(Unity.Properties.PropertyPath value);
            /*0x7f17e2c*/ void Reset();
            /*0x7f1c120*/ Unity.Properties.IProperty get_Property();
            /*0x7f1c128*/ void set_Property(Unity.Properties.IProperty value);
            /*0x7f1c130*/ bool get_ReadonlyVisit();
            /*0x7f1c138*/ void set_ReadonlyVisit(bool value);
            /*0x7f1c144*/ Unity.Properties.VisitReturnCode get_ReturnCode();
            /*0x7f1c14c*/ void set_ReturnCode(Unity.Properties.VisitReturnCode value);
            /*0x3816810*/ void Unity.Properties.IPropertyBagVisitor.Visit<TContainer>(Unity.Properties.IPropertyBag<TContainer> properties, ref TContainer container);
            /*0x3816810*/ void Unity.Properties.IPropertyVisitor.Visit<TContainer, TValue>(Unity.Properties.Property<TContainer, TValue> property, ref TContainer container);
            /*0x3816920*/ void VisitPath<TContainer, TValue>(Unity.Properties.Property<TContainer, TValue> property, ref TContainer container, ref TValue value);

            struct PropertyScope : System.IDisposable
            {
                /*0x10*/ Unity.Properties.PathVisitor m_Visitor;
                /*0x18*/ Unity.Properties.IProperty m_Property;

                /*0x7f1c154*/ PropertyScope(Unity.Properties.PathVisitor visitor, Unity.Properties.IProperty property);
                /*0x7f1c1a4*/ void Dispose();
            }
        }

        struct ConversionRegistry : System.Collections.Generic.IEqualityComparer<Unity.Properties.ConversionRegistry>
        {
            static /*0x0*/ Unity.Properties.ConversionRegistry.ConverterKeyComparer Comparer;
            /*0x10*/ System.Collections.Generic.Dictionary<Unity.Properties.ConversionRegistry.ConverterKey, System.Delegate> m_Converters;

            static /*0x7f1c514*/ ConversionRegistry();
            static /*0x7f1c1d0*/ Unity.Properties.ConversionRegistry Create();
            /*0x7f1c1c8*/ ConversionRegistry(System.Collections.Generic.Dictionary<Unity.Properties.ConversionRegistry.ConverterKey, System.Delegate> storage);
            /*0x7f1c284*/ void Register(System.Type source, System.Type destination, System.Delegate converter);
            /*0x7f1c3a4*/ System.Delegate GetConverter(System.Type source, System.Type destination);
            /*0x7f1c450*/ bool TryGetConverter(System.Type source, System.Type destination, ref System.Delegate converter);
            /*0x7f1c4e8*/ bool Equals(Unity.Properties.ConversionRegistry x, Unity.Properties.ConversionRegistry y);
            /*0x7f1c4f4*/ int GetHashCode(Unity.Properties.ConversionRegistry obj);

            class ConverterKeyComparer : System.Collections.Generic.IEqualityComparer<Unity.Properties.ConversionRegistry.ConverterKey>
            {
                /*0x7f1c590*/ ConverterKeyComparer();
                /*0x7f1c598*/ bool Equals(Unity.Properties.ConversionRegistry.ConverterKey x, Unity.Properties.ConversionRegistry.ConverterKey y);
                /*0x7f1c620*/ int GetHashCode(Unity.Properties.ConversionRegistry.ConverterKey obj);
            }

            struct ConverterKey
            {
                /*0x10*/ System.Type SourceType;
                /*0x18*/ System.Type DestinationType;

                /*0x7f1c374*/ ConverterKey(System.Type source, System.Type destination);
            }
        }

        class TypeConverter<TSource, TDestination> : System.MulticastDelegate
        {
            TypeConverter(object object, nint method);
            /*0x3910ae8*/ TDestination Invoke(ref TSource value);
        }

        class TypeConversion
        {
            static /*0x0*/ Unity.Properties.ConversionRegistry s_GlobalConverters;

            static /*0x7f1c6d4*/ TypeConversion();
            static /*0x3840c74*/ void Register<TSource, TDestination>(Unity.Properties.TypeConverter<TSource, TDestination> converter);
            static /*0x3910ae8*/ TDestination Convert<TSource, TDestination>(ref TSource value);
            static /*0x3825b78*/ bool TryConvert<TSource, TDestination>(ref TSource source, ref TDestination destination);
            static /*0x3910ae8*/ bool TryConvertToUnityEngineObject<TSource, TDestination>(TSource source, ref TDestination destination);
            static /*0x7f1c928*/ bool IsNumericType(System.Type t);

            class PrimitiveConverters
            {
                static /*0x7f1c754*/ void Register();
                static /*0x7f1c96c*/ void RegisterInt8Converters();
                static /*0x7f1d6ac*/ void RegisterInt16Converters();
                static /*0x7f1e3ec*/ void RegisterInt32Converters();
                static /*0x7f1f144*/ void RegisterInt64Converters();
                static /*0x7f1feb4*/ void RegisterUInt8Converters();
                static /*0x7f20c24*/ void RegisterUInt16Converters();
                static /*0x7f21994*/ void RegisterUInt32Converters();
                static /*0x7f22704*/ void RegisterUInt64Converters();
                static /*0x7f23474*/ void RegisterFloat32Converters();
                static /*0x7f241e4*/ void RegisterFloat64Converters();
                static /*0x7f24f54*/ void RegisterBooleanConverters();
                static /*0x7f25cc4*/ void RegisterCharConverters();
                static /*0x7f26c5c*/ void RegisterStringConverters();
                static /*0x7f286bc*/ void RegisterObjectConverters();

                class <>c
                {
                    static /*0x0*/ Unity.Properties.TypeConversion.PrimitiveConverters.<> <>9;
                    static /*0x8*/ Unity.Properties.TypeConverter<string, System.Guid> <>9__0_0;
                    static /*0x10*/ Unity.Properties.TypeConverter<sbyte, char> <>9__1_0;
                    static /*0x18*/ Unity.Properties.TypeConverter<sbyte, bool> <>9__1_1;
                    static /*0x20*/ Unity.Properties.TypeConverter<sbyte, short> <>9__1_2;
                    static /*0x28*/ Unity.Properties.TypeConverter<sbyte, int> <>9__1_3;
                    static /*0x30*/ Unity.Properties.TypeConverter<sbyte, long> <>9__1_4;
                    static /*0x38*/ Unity.Properties.TypeConverter<sbyte, byte> <>9__1_5;
                    static /*0x40*/ Unity.Properties.TypeConverter<sbyte, ushort> <>9__1_6;
                    static /*0x48*/ Unity.Properties.TypeConverter<sbyte, uint> <>9__1_7;
                    static /*0x50*/ Unity.Properties.TypeConverter<sbyte, ulong> <>9__1_8;
                    static /*0x58*/ Unity.Properties.TypeConverter<sbyte, float> <>9__1_9;
                    static /*0x60*/ Unity.Properties.TypeConverter<sbyte, double> <>9__1_10;
                    static /*0x68*/ Unity.Properties.TypeConverter<sbyte, object> <>9__1_11;
                    static /*0x70*/ Unity.Properties.TypeConverter<short, sbyte> <>9__2_0;
                    static /*0x78*/ Unity.Properties.TypeConverter<short, char> <>9__2_1;
                    static /*0x80*/ Unity.Properties.TypeConverter<short, bool> <>9__2_2;
                    static /*0x88*/ Unity.Properties.TypeConverter<short, int> <>9__2_3;
                    static /*0x90*/ Unity.Properties.TypeConverter<short, long> <>9__2_4;
                    static /*0x98*/ Unity.Properties.TypeConverter<short, byte> <>9__2_5;
                    static /*0xa0*/ Unity.Properties.TypeConverter<short, ushort> <>9__2_6;
                    static /*0xa8*/ Unity.Properties.TypeConverter<short, uint> <>9__2_7;
                    static /*0xb0*/ Unity.Properties.TypeConverter<short, ulong> <>9__2_8;
                    static /*0xb8*/ Unity.Properties.TypeConverter<short, float> <>9__2_9;
                    static /*0xc0*/ Unity.Properties.TypeConverter<short, double> <>9__2_10;
                    static /*0xc8*/ Unity.Properties.TypeConverter<short, object> <>9__2_11;
                    static /*0xd0*/ Unity.Properties.TypeConverter<int, sbyte> <>9__3_0;
                    static /*0xd8*/ Unity.Properties.TypeConverter<int, char> <>9__3_1;
                    static /*0xe0*/ Unity.Properties.TypeConverter<int, bool> <>9__3_2;
                    static /*0xe8*/ Unity.Properties.TypeConverter<int, short> <>9__3_3;
                    static /*0xf0*/ Unity.Properties.TypeConverter<int, long> <>9__3_4;
                    static /*0xf8*/ Unity.Properties.TypeConverter<int, byte> <>9__3_5;
                    static /*0x100*/ Unity.Properties.TypeConverter<int, ushort> <>9__3_6;
                    static /*0x108*/ Unity.Properties.TypeConverter<int, uint> <>9__3_7;
                    static /*0x110*/ Unity.Properties.TypeConverter<int, ulong> <>9__3_8;
                    static /*0x118*/ Unity.Properties.TypeConverter<int, float> <>9__3_9;
                    static /*0x120*/ Unity.Properties.TypeConverter<int, double> <>9__3_10;
                    static /*0x128*/ Unity.Properties.TypeConverter<int, object> <>9__3_11;
                    static /*0x130*/ Unity.Properties.TypeConverter<long, sbyte> <>9__4_0;
                    static /*0x138*/ Unity.Properties.TypeConverter<long, char> <>9__4_1;
                    static /*0x140*/ Unity.Properties.TypeConverter<long, bool> <>9__4_2;
                    static /*0x148*/ Unity.Properties.TypeConverter<long, short> <>9__4_3;
                    static /*0x150*/ Unity.Properties.TypeConverter<long, int> <>9__4_4;
                    static /*0x158*/ Unity.Properties.TypeConverter<long, byte> <>9__4_5;
                    static /*0x160*/ Unity.Properties.TypeConverter<long, ushort> <>9__4_6;
                    static /*0x168*/ Unity.Properties.TypeConverter<long, uint> <>9__4_7;
                    static /*0x170*/ Unity.Properties.TypeConverter<long, ulong> <>9__4_8;
                    static /*0x178*/ Unity.Properties.TypeConverter<long, float> <>9__4_9;
                    static /*0x180*/ Unity.Properties.TypeConverter<long, double> <>9__4_10;
                    static /*0x188*/ Unity.Properties.TypeConverter<long, object> <>9__4_11;
                    static /*0x190*/ Unity.Properties.TypeConverter<byte, sbyte> <>9__5_0;
                    static /*0x198*/ Unity.Properties.TypeConverter<byte, char> <>9__5_1;
                    static /*0x1a0*/ Unity.Properties.TypeConverter<byte, bool> <>9__5_2;
                    static /*0x1a8*/ Unity.Properties.TypeConverter<byte, short> <>9__5_3;
                    static /*0x1b0*/ Unity.Properties.TypeConverter<byte, int> <>9__5_4;
                    static /*0x1b8*/ Unity.Properties.TypeConverter<byte, long> <>9__5_5;
                    static /*0x1c0*/ Unity.Properties.TypeConverter<byte, ushort> <>9__5_6;
                    static /*0x1c8*/ Unity.Properties.TypeConverter<byte, uint> <>9__5_7;
                    static /*0x1d0*/ Unity.Properties.TypeConverter<byte, ulong> <>9__5_8;
                    static /*0x1d8*/ Unity.Properties.TypeConverter<byte, float> <>9__5_9;
                    static /*0x1e0*/ Unity.Properties.TypeConverter<byte, double> <>9__5_10;
                    static /*0x1e8*/ Unity.Properties.TypeConverter<byte, object> <>9__5_11;
                    static /*0x1f0*/ Unity.Properties.TypeConverter<ushort, sbyte> <>9__6_0;
                    static /*0x1f8*/ Unity.Properties.TypeConverter<ushort, char> <>9__6_1;
                    static /*0x200*/ Unity.Properties.TypeConverter<ushort, bool> <>9__6_2;
                    static /*0x208*/ Unity.Properties.TypeConverter<ushort, short> <>9__6_3;
                    static /*0x210*/ Unity.Properties.TypeConverter<ushort, int> <>9__6_4;
                    static /*0x218*/ Unity.Properties.TypeConverter<ushort, long> <>9__6_5;
                    static /*0x220*/ Unity.Properties.TypeConverter<ushort, byte> <>9__6_6;
                    static /*0x228*/ Unity.Properties.TypeConverter<ushort, uint> <>9__6_7;
                    static /*0x230*/ Unity.Properties.TypeConverter<ushort, ulong> <>9__6_8;
                    static /*0x238*/ Unity.Properties.TypeConverter<ushort, float> <>9__6_9;
                    static /*0x240*/ Unity.Properties.TypeConverter<ushort, double> <>9__6_10;
                    static /*0x248*/ Unity.Properties.TypeConverter<ushort, object> <>9__6_11;
                    static /*0x250*/ Unity.Properties.TypeConverter<uint, sbyte> <>9__7_0;
                    static /*0x258*/ Unity.Properties.TypeConverter<uint, char> <>9__7_1;
                    static /*0x260*/ Unity.Properties.TypeConverter<uint, bool> <>9__7_2;
                    static /*0x268*/ Unity.Properties.TypeConverter<uint, short> <>9__7_3;
                    static /*0x270*/ Unity.Properties.TypeConverter<uint, int> <>9__7_4;
                    static /*0x278*/ Unity.Properties.TypeConverter<uint, long> <>9__7_5;
                    static /*0x280*/ Unity.Properties.TypeConverter<uint, byte> <>9__7_6;
                    static /*0x288*/ Unity.Properties.TypeConverter<uint, ushort> <>9__7_7;
                    static /*0x290*/ Unity.Properties.TypeConverter<uint, ulong> <>9__7_8;
                    static /*0x298*/ Unity.Properties.TypeConverter<uint, float> <>9__7_9;
                    static /*0x2a0*/ Unity.Properties.TypeConverter<uint, double> <>9__7_10;
                    static /*0x2a8*/ Unity.Properties.TypeConverter<uint, object> <>9__7_11;
                    static /*0x2b0*/ Unity.Properties.TypeConverter<ulong, sbyte> <>9__8_0;
                    static /*0x2b8*/ Unity.Properties.TypeConverter<ulong, char> <>9__8_1;
                    static /*0x2c0*/ Unity.Properties.TypeConverter<ulong, bool> <>9__8_2;
                    static /*0x2c8*/ Unity.Properties.TypeConverter<ulong, short> <>9__8_3;
                    static /*0x2d0*/ Unity.Properties.TypeConverter<ulong, int> <>9__8_4;
                    static /*0x2d8*/ Unity.Properties.TypeConverter<ulong, long> <>9__8_5;
                    static /*0x2e0*/ Unity.Properties.TypeConverter<ulong, byte> <>9__8_6;
                    static /*0x2e8*/ Unity.Properties.TypeConverter<ulong, ushort> <>9__8_7;
                    static /*0x2f0*/ Unity.Properties.TypeConverter<ulong, uint> <>9__8_8;
                    static /*0x2f8*/ Unity.Properties.TypeConverter<ulong, float> <>9__8_9;
                    static /*0x300*/ Unity.Properties.TypeConverter<ulong, double> <>9__8_10;
                    static /*0x308*/ Unity.Properties.TypeConverter<ulong, object> <>9__8_11;
                    static /*0x310*/ Unity.Properties.TypeConverter<float, sbyte> <>9__9_0;
                    static /*0x318*/ Unity.Properties.TypeConverter<float, char> <>9__9_1;
                    static /*0x320*/ Unity.Properties.TypeConverter<float, bool> <>9__9_2;
                    static /*0x328*/ Unity.Properties.TypeConverter<float, short> <>9__9_3;
                    static /*0x330*/ Unity.Properties.TypeConverter<float, int> <>9__9_4;
                    static /*0x338*/ Unity.Properties.TypeConverter<float, long> <>9__9_5;
                    static /*0x340*/ Unity.Properties.TypeConverter<float, byte> <>9__9_6;
                    static /*0x348*/ Unity.Properties.TypeConverter<float, ushort> <>9__9_7;
                    static /*0x350*/ Unity.Properties.TypeConverter<float, uint> <>9__9_8;
                    static /*0x358*/ Unity.Properties.TypeConverter<float, ulong> <>9__9_9;
                    static /*0x360*/ Unity.Properties.TypeConverter<float, double> <>9__9_10;
                    static /*0x368*/ Unity.Properties.TypeConverter<float, object> <>9__9_11;
                    static /*0x370*/ Unity.Properties.TypeConverter<double, sbyte> <>9__10_0;
                    static /*0x378*/ Unity.Properties.TypeConverter<double, char> <>9__10_1;
                    static /*0x380*/ Unity.Properties.TypeConverter<double, bool> <>9__10_2;
                    static /*0x388*/ Unity.Properties.TypeConverter<double, short> <>9__10_3;
                    static /*0x390*/ Unity.Properties.TypeConverter<double, int> <>9__10_4;
                    static /*0x398*/ Unity.Properties.TypeConverter<double, long> <>9__10_5;
                    static /*0x3a0*/ Unity.Properties.TypeConverter<double, byte> <>9__10_6;
                    static /*0x3a8*/ Unity.Properties.TypeConverter<double, ushort> <>9__10_7;
                    static /*0x3b0*/ Unity.Properties.TypeConverter<double, uint> <>9__10_8;
                    static /*0x3b8*/ Unity.Properties.TypeConverter<double, ulong> <>9__10_9;
                    static /*0x3c0*/ Unity.Properties.TypeConverter<double, float> <>9__10_10;
                    static /*0x3c8*/ Unity.Properties.TypeConverter<double, object> <>9__10_11;
                    static /*0x3d0*/ Unity.Properties.TypeConverter<bool, char> <>9__11_0;
                    static /*0x3d8*/ Unity.Properties.TypeConverter<bool, sbyte> <>9__11_1;
                    static /*0x3e0*/ Unity.Properties.TypeConverter<bool, short> <>9__11_2;
                    static /*0x3e8*/ Unity.Properties.TypeConverter<bool, int> <>9__11_3;
                    static /*0x3f0*/ Unity.Properties.TypeConverter<bool, long> <>9__11_4;
                    static /*0x3f8*/ Unity.Properties.TypeConverter<bool, byte> <>9__11_5;
                    static /*0x400*/ Unity.Properties.TypeConverter<bool, ushort> <>9__11_6;
                    static /*0x408*/ Unity.Properties.TypeConverter<bool, uint> <>9__11_7;
                    static /*0x410*/ Unity.Properties.TypeConverter<bool, ulong> <>9__11_8;
                    static /*0x418*/ Unity.Properties.TypeConverter<bool, float> <>9__11_9;
                    static /*0x420*/ Unity.Properties.TypeConverter<bool, double> <>9__11_10;
                    static /*0x428*/ Unity.Properties.TypeConverter<bool, object> <>9__11_11;
                    static /*0x430*/ Unity.Properties.TypeConverter<string, char> <>9__12_0;
                    static /*0x438*/ Unity.Properties.TypeConverter<char, bool> <>9__12_1;
                    static /*0x440*/ Unity.Properties.TypeConverter<char, sbyte> <>9__12_2;
                    static /*0x448*/ Unity.Properties.TypeConverter<char, short> <>9__12_3;
                    static /*0x450*/ Unity.Properties.TypeConverter<char, int> <>9__12_4;
                    static /*0x458*/ Unity.Properties.TypeConverter<char, long> <>9__12_5;
                    static /*0x460*/ Unity.Properties.TypeConverter<char, byte> <>9__12_6;
                    static /*0x468*/ Unity.Properties.TypeConverter<char, ushort> <>9__12_7;
                    static /*0x470*/ Unity.Properties.TypeConverter<char, uint> <>9__12_8;
                    static /*0x478*/ Unity.Properties.TypeConverter<char, ulong> <>9__12_9;
                    static /*0x480*/ Unity.Properties.TypeConverter<char, float> <>9__12_10;
                    static /*0x488*/ Unity.Properties.TypeConverter<char, double> <>9__12_11;
                    static /*0x490*/ Unity.Properties.TypeConverter<char, object> <>9__12_12;
                    static /*0x498*/ Unity.Properties.TypeConverter<char, string> <>9__12_13;
                    static /*0x4a0*/ Unity.Properties.TypeConverter<string, char> <>9__13_0;
                    static /*0x4a8*/ Unity.Properties.TypeConverter<char, string> <>9__13_1;
                    static /*0x4b0*/ Unity.Properties.TypeConverter<string, bool> <>9__13_2;
                    static /*0x4b8*/ Unity.Properties.TypeConverter<bool, string> <>9__13_3;
                    static /*0x4c0*/ Unity.Properties.TypeConverter<string, sbyte> <>9__13_4;
                    static /*0x4c8*/ Unity.Properties.TypeConverter<sbyte, string> <>9__13_5;
                    static /*0x4d0*/ Unity.Properties.TypeConverter<string, short> <>9__13_6;
                    static /*0x4d8*/ Unity.Properties.TypeConverter<short, string> <>9__13_7;
                    static /*0x4e0*/ Unity.Properties.TypeConverter<string, int> <>9__13_8;
                    static /*0x4e8*/ Unity.Properties.TypeConverter<int, string> <>9__13_9;
                    static /*0x4f0*/ Unity.Properties.TypeConverter<string, long> <>9__13_10;
                    static /*0x4f8*/ Unity.Properties.TypeConverter<long, string> <>9__13_11;
                    static /*0x500*/ Unity.Properties.TypeConverter<string, byte> <>9__13_12;
                    static /*0x508*/ Unity.Properties.TypeConverter<byte, string> <>9__13_13;
                    static /*0x510*/ Unity.Properties.TypeConverter<string, ushort> <>9__13_14;
                    static /*0x518*/ Unity.Properties.TypeConverter<ushort, string> <>9__13_15;
                    static /*0x520*/ Unity.Properties.TypeConverter<string, uint> <>9__13_16;
                    static /*0x528*/ Unity.Properties.TypeConverter<uint, string> <>9__13_17;
                    static /*0x530*/ Unity.Properties.TypeConverter<string, ulong> <>9__13_18;
                    static /*0x538*/ Unity.Properties.TypeConverter<ulong, string> <>9__13_19;
                    static /*0x540*/ Unity.Properties.TypeConverter<string, float> <>9__13_20;
                    static /*0x548*/ Unity.Properties.TypeConverter<float, string> <>9__13_21;
                    static /*0x550*/ Unity.Properties.TypeConverter<string, double> <>9__13_22;
                    static /*0x558*/ Unity.Properties.TypeConverter<double, string> <>9__13_23;
                    static /*0x560*/ Unity.Properties.TypeConverter<object, char> <>9__14_0;
                    static /*0x568*/ Unity.Properties.TypeConverter<object, bool> <>9__14_1;
                    static /*0x570*/ Unity.Properties.TypeConverter<object, sbyte> <>9__14_2;
                    static /*0x578*/ Unity.Properties.TypeConverter<object, short> <>9__14_3;
                    static /*0x580*/ Unity.Properties.TypeConverter<object, int> <>9__14_4;
                    static /*0x588*/ Unity.Properties.TypeConverter<object, long> <>9__14_5;
                    static /*0x590*/ Unity.Properties.TypeConverter<object, byte> <>9__14_6;
                    static /*0x598*/ Unity.Properties.TypeConverter<object, ushort> <>9__14_7;
                    static /*0x5a0*/ Unity.Properties.TypeConverter<object, uint> <>9__14_8;
                    static /*0x5a8*/ Unity.Properties.TypeConverter<object, ulong> <>9__14_9;
                    static /*0x5b0*/ Unity.Properties.TypeConverter<object, float> <>9__14_10;
                    static /*0x5b8*/ Unity.Properties.TypeConverter<object, double> <>9__14_11;

                    static /*0x7f2942c*/ <>c();
                    /*0x7f29494*/ <>c();
                    /*0x7f2949c*/ System.Guid <Register>b__0_0(ref string g);
                    /*0x7f294c8*/ char <RegisterInt8Converters>b__1_0(ref sbyte v);
                    /*0x7f294d0*/ bool <RegisterInt8Converters>b__1_1(ref sbyte v);
                    /*0x7f294e0*/ short <RegisterInt8Converters>b__1_2(ref sbyte v);
                    /*0x7f294e8*/ int <RegisterInt8Converters>b__1_3(ref sbyte v);
                    /*0x7f294f0*/ long <RegisterInt8Converters>b__1_4(ref sbyte v);
                    /*0x7f294f8*/ byte <RegisterInt8Converters>b__1_5(ref sbyte v);
                    /*0x7f29500*/ ushort <RegisterInt8Converters>b__1_6(ref sbyte v);
                    /*0x7f29508*/ uint <RegisterInt8Converters>b__1_7(ref sbyte v);
                    /*0x7f29510*/ ulong <RegisterInt8Converters>b__1_8(ref sbyte v);
                    /*0x7f29518*/ float <RegisterInt8Converters>b__1_9(ref sbyte v);
                    /*0x7f29524*/ double <RegisterInt8Converters>b__1_10(ref sbyte v);
                    /*0x7f29530*/ object <RegisterInt8Converters>b__1_11(ref sbyte v);
                    /*0x7f29558*/ sbyte <RegisterInt16Converters>b__2_0(ref short v);
                    /*0x7f29560*/ char <RegisterInt16Converters>b__2_1(ref short v);
                    /*0x7f29568*/ bool <RegisterInt16Converters>b__2_2(ref short v);
                    /*0x7f29578*/ int <RegisterInt16Converters>b__2_3(ref short v);
                    /*0x7f29580*/ long <RegisterInt16Converters>b__2_4(ref short v);
                    /*0x7f29588*/ byte <RegisterInt16Converters>b__2_5(ref short v);
                    /*0x7f29590*/ ushort <RegisterInt16Converters>b__2_6(ref short v);
                    /*0x7f29598*/ uint <RegisterInt16Converters>b__2_7(ref short v);
                    /*0x7f295a0*/ ulong <RegisterInt16Converters>b__2_8(ref short v);
                    /*0x7f295a8*/ float <RegisterInt16Converters>b__2_9(ref short v);
                    /*0x7f295b4*/ double <RegisterInt16Converters>b__2_10(ref short v);
                    /*0x7f295c0*/ object <RegisterInt16Converters>b__2_11(ref short v);
                    /*0x7f295e8*/ sbyte <RegisterInt32Converters>b__3_0(ref int v);
                    /*0x7f295f0*/ char <RegisterInt32Converters>b__3_1(ref int v);
                    /*0x7f295f8*/ bool <RegisterInt32Converters>b__3_2(ref int v);
                    /*0x7f29608*/ short <RegisterInt32Converters>b__3_3(ref int v);
                    /*0x7f29610*/ long <RegisterInt32Converters>b__3_4(ref int v);
                    /*0x7f29618*/ byte <RegisterInt32Converters>b__3_5(ref int v);
                    /*0x7f29620*/ ushort <RegisterInt32Converters>b__3_6(ref int v);
                    /*0x7f29628*/ uint <RegisterInt32Converters>b__3_7(ref int v);
                    /*0x7f29630*/ ulong <RegisterInt32Converters>b__3_8(ref int v);
                    /*0x7f29638*/ float <RegisterInt32Converters>b__3_9(ref int v);
                    /*0x7f29644*/ double <RegisterInt32Converters>b__3_10(ref int v);
                    /*0x7f29650*/ object <RegisterInt32Converters>b__3_11(ref int v);
                    /*0x7f29678*/ sbyte <RegisterInt64Converters>b__4_0(ref long v);
                    /*0x7f29680*/ char <RegisterInt64Converters>b__4_1(ref long v);
                    /*0x7f29688*/ bool <RegisterInt64Converters>b__4_2(ref long v);
                    /*0x7f29698*/ short <RegisterInt64Converters>b__4_3(ref long v);
                    /*0x7f296a0*/ int <RegisterInt64Converters>b__4_4(ref long v);
                    /*0x7f296a8*/ byte <RegisterInt64Converters>b__4_5(ref long v);
                    /*0x7f296b0*/ ushort <RegisterInt64Converters>b__4_6(ref long v);
                    /*0x7f296b8*/ uint <RegisterInt64Converters>b__4_7(ref long v);
                    /*0x7f296c0*/ ulong <RegisterInt64Converters>b__4_8(ref long v);
                    /*0x7f296c8*/ float <RegisterInt64Converters>b__4_9(ref long v);
                    /*0x7f296d4*/ double <RegisterInt64Converters>b__4_10(ref long v);
                    /*0x7f296e0*/ object <RegisterInt64Converters>b__4_11(ref long v);
                    /*0x7f29708*/ sbyte <RegisterUInt8Converters>b__5_0(ref byte v);
                    /*0x7f29710*/ char <RegisterUInt8Converters>b__5_1(ref byte v);
                    /*0x7f29718*/ bool <RegisterUInt8Converters>b__5_2(ref byte v);
                    /*0x7f29728*/ short <RegisterUInt8Converters>b__5_3(ref byte v);
                    /*0x7f29730*/ int <RegisterUInt8Converters>b__5_4(ref byte v);
                    /*0x7f29738*/ long <RegisterUInt8Converters>b__5_5(ref byte v);
                    /*0x7f29740*/ ushort <RegisterUInt8Converters>b__5_6(ref byte v);
                    /*0x7f29748*/ uint <RegisterUInt8Converters>b__5_7(ref byte v);
                    /*0x7f29750*/ ulong <RegisterUInt8Converters>b__5_8(ref byte v);
                    /*0x7f29758*/ float <RegisterUInt8Converters>b__5_9(ref byte v);
                    /*0x7f29764*/ double <RegisterUInt8Converters>b__5_10(ref byte v);
                    /*0x7f29770*/ object <RegisterUInt8Converters>b__5_11(ref byte v);
                    /*0x7f29798*/ sbyte <RegisterUInt16Converters>b__6_0(ref ushort v);
                    /*0x7f297a0*/ char <RegisterUInt16Converters>b__6_1(ref ushort v);
                    /*0x7f297a8*/ bool <RegisterUInt16Converters>b__6_2(ref ushort v);
                    /*0x7f297b8*/ short <RegisterUInt16Converters>b__6_3(ref ushort v);
                    /*0x7f297c0*/ int <RegisterUInt16Converters>b__6_4(ref ushort v);
                    /*0x7f297c8*/ long <RegisterUInt16Converters>b__6_5(ref ushort v);
                    /*0x7f297d0*/ byte <RegisterUInt16Converters>b__6_6(ref ushort v);
                    /*0x7f297d8*/ uint <RegisterUInt16Converters>b__6_7(ref ushort v);
                    /*0x7f297e0*/ ulong <RegisterUInt16Converters>b__6_8(ref ushort v);
                    /*0x7f297e8*/ float <RegisterUInt16Converters>b__6_9(ref ushort v);
                    /*0x7f297f4*/ double <RegisterUInt16Converters>b__6_10(ref ushort v);
                    /*0x7f29800*/ object <RegisterUInt16Converters>b__6_11(ref ushort v);
                    /*0x7f29828*/ sbyte <RegisterUInt32Converters>b__7_0(ref uint v);
                    /*0x7f29830*/ char <RegisterUInt32Converters>b__7_1(ref uint v);
                    /*0x7f29838*/ bool <RegisterUInt32Converters>b__7_2(ref uint v);
                    /*0x7f29848*/ short <RegisterUInt32Converters>b__7_3(ref uint v);
                    /*0x7f29850*/ int <RegisterUInt32Converters>b__7_4(ref uint v);
                    /*0x7f29858*/ long <RegisterUInt32Converters>b__7_5(ref uint v);
                    /*0x7f29860*/ byte <RegisterUInt32Converters>b__7_6(ref uint v);
                    /*0x7f29868*/ ushort <RegisterUInt32Converters>b__7_7(ref uint v);
                    /*0x7f29870*/ ulong <RegisterUInt32Converters>b__7_8(ref uint v);
                    /*0x7f29878*/ float <RegisterUInt32Converters>b__7_9(ref uint v);
                    /*0x7f29884*/ double <RegisterUInt32Converters>b__7_10(ref uint v);
                    /*0x7f29890*/ object <RegisterUInt32Converters>b__7_11(ref uint v);
                    /*0x7f298b8*/ sbyte <RegisterUInt64Converters>b__8_0(ref ulong v);
                    /*0x7f298c0*/ char <RegisterUInt64Converters>b__8_1(ref ulong v);
                    /*0x7f298c8*/ bool <RegisterUInt64Converters>b__8_2(ref ulong v);
                    /*0x7f298d8*/ short <RegisterUInt64Converters>b__8_3(ref ulong v);
                    /*0x7f298e0*/ int <RegisterUInt64Converters>b__8_4(ref ulong v);
                    /*0x7f298e8*/ long <RegisterUInt64Converters>b__8_5(ref ulong v);
                    /*0x7f298f0*/ byte <RegisterUInt64Converters>b__8_6(ref ulong v);
                    /*0x7f298f8*/ ushort <RegisterUInt64Converters>b__8_7(ref ulong v);
                    /*0x7f29900*/ uint <RegisterUInt64Converters>b__8_8(ref ulong v);
                    /*0x7f29908*/ float <RegisterUInt64Converters>b__8_9(ref ulong v);
                    /*0x7f29918*/ double <RegisterUInt64Converters>b__8_10(ref ulong v);
                    /*0x7f29924*/ object <RegisterUInt64Converters>b__8_11(ref ulong v);
                    /*0x7f2994c*/ sbyte <RegisterFloat32Converters>b__9_0(ref float v);
                    /*0x7f29968*/ char <RegisterFloat32Converters>b__9_1(ref float v);
                    /*0x7f2997c*/ bool <RegisterFloat32Converters>b__9_2(ref float v);
                    /*0x7f299ec*/ short <RegisterFloat32Converters>b__9_3(ref float v);
                    /*0x7f29a08*/ int <RegisterFloat32Converters>b__9_4(ref float v);
                    /*0x7f29a28*/ long <RegisterFloat32Converters>b__9_5(ref float v);
                    /*0x7f29a48*/ byte <RegisterFloat32Converters>b__9_6(ref float v);
                    /*0x7f29a5c*/ ushort <RegisterFloat32Converters>b__9_7(ref float v);
                    /*0x7f29a70*/ uint <RegisterFloat32Converters>b__9_8(ref float v);
                    /*0x7f29a88*/ ulong <RegisterFloat32Converters>b__9_9(ref float v);
                    /*0x7f29aa0*/ double <RegisterFloat32Converters>b__9_10(ref float v);
                    /*0x7f29aac*/ object <RegisterFloat32Converters>b__9_11(ref float v);
                    /*0x7f29ad4*/ sbyte <RegisterFloat64Converters>b__10_0(ref double v);
                    /*0x7f29af0*/ char <RegisterFloat64Converters>b__10_1(ref double v);
                    /*0x7f29b04*/ bool <RegisterFloat64Converters>b__10_2(ref double v);
                    /*0x7f29b74*/ short <RegisterFloat64Converters>b__10_3(ref double v);
                    /*0x7f29b90*/ int <RegisterFloat64Converters>b__10_4(ref double v);
                    /*0x7f29bb0*/ long <RegisterFloat64Converters>b__10_5(ref double v);
                    /*0x7f29bd0*/ byte <RegisterFloat64Converters>b__10_6(ref double v);
                    /*0x7f29be4*/ ushort <RegisterFloat64Converters>b__10_7(ref double v);
                    /*0x7f29bf8*/ uint <RegisterFloat64Converters>b__10_8(ref double v);
                    /*0x7f29c10*/ ulong <RegisterFloat64Converters>b__10_9(ref double v);
                    /*0x7f29c28*/ float <RegisterFloat64Converters>b__10_10(ref double v);
                    /*0x7f29c34*/ object <RegisterFloat64Converters>b__10_11(ref double v);
                    /*0x7f29c5c*/ char <RegisterBooleanConverters>b__11_0(ref bool v);
                    /*0x7f29c6c*/ sbyte <RegisterBooleanConverters>b__11_1(ref bool v);
                    /*0x7f29c7c*/ short <RegisterBooleanConverters>b__11_2(ref bool v);
                    /*0x7f29c8c*/ int <RegisterBooleanConverters>b__11_3(ref bool v);
                    /*0x7f29c9c*/ long <RegisterBooleanConverters>b__11_4(ref bool v);
                    /*0x7f29cac*/ byte <RegisterBooleanConverters>b__11_5(ref bool v);
                    /*0x7f29cbc*/ ushort <RegisterBooleanConverters>b__11_6(ref bool v);
                    /*0x7f29ccc*/ uint <RegisterBooleanConverters>b__11_7(ref bool v);
                    /*0x7f29cdc*/ ulong <RegisterBooleanConverters>b__11_8(ref bool v);
                    /*0x7f29cec*/ float <RegisterBooleanConverters>b__11_9(ref bool v);
                    /*0x7f29d04*/ double <RegisterBooleanConverters>b__11_10(ref bool v);
                    /*0x7f29d1c*/ object <RegisterBooleanConverters>b__11_11(ref bool v);
                    /*0x7f29d4c*/ char <RegisterCharConverters>b__12_0(ref string v);
                    /*0x7f29dc0*/ bool <RegisterCharConverters>b__12_1(ref char v);
                    /*0x7f29dd0*/ sbyte <RegisterCharConverters>b__12_2(ref char v);
                    /*0x7f29dd8*/ short <RegisterCharConverters>b__12_3(ref char v);
                    /*0x7f29de0*/ int <RegisterCharConverters>b__12_4(ref char v);
                    /*0x7f29de8*/ long <RegisterCharConverters>b__12_5(ref char v);
                    /*0x7f29df0*/ byte <RegisterCharConverters>b__12_6(ref char v);
                    /*0x7f29df8*/ ushort <RegisterCharConverters>b__12_7(ref char v);
                    /*0x7f29e00*/ uint <RegisterCharConverters>b__12_8(ref char v);
                    /*0x7f29e08*/ ulong <RegisterCharConverters>b__12_9(ref char v);
                    /*0x7f29e10*/ float <RegisterCharConverters>b__12_10(ref char v);
                    /*0x7f29e1c*/ double <RegisterCharConverters>b__12_11(ref char v);
                    /*0x7f29e28*/ object <RegisterCharConverters>b__12_12(ref char v);
                    /*0x7f29e50*/ string <RegisterCharConverters>b__12_13(ref char v);
                    /*0x7f29e80*/ char <RegisterStringConverters>b__13_0(ref string v);
                    /*0x7f29ec0*/ string <RegisterStringConverters>b__13_1(ref char v);
                    /*0x7f29ef0*/ bool <RegisterStringConverters>b__13_2(ref string v);
                    /*0x7f29fd0*/ string <RegisterStringConverters>b__13_3(ref bool v);
                    /*0x7f2a000*/ sbyte <RegisterStringConverters>b__13_4(ref string v);
                    /*0x7f2a0b8*/ string <RegisterStringConverters>b__13_5(ref sbyte v);
                    /*0x7f2a0c4*/ short <RegisterStringConverters>b__13_6(ref string v);
                    /*0x7f2a17c*/ string <RegisterStringConverters>b__13_7(ref short v);
                    /*0x7f2a188*/ int <RegisterStringConverters>b__13_8(ref string v);
                    /*0x7f2a240*/ string <RegisterStringConverters>b__13_9(ref int v);
                    /*0x7f2a24c*/ long <RegisterStringConverters>b__13_10(ref string v);
                    /*0x7f2a304*/ string <RegisterStringConverters>b__13_11(ref long v);
                    /*0x7f2a310*/ byte <RegisterStringConverters>b__13_12(ref string v);
                    /*0x7f2a3c8*/ string <RegisterStringConverters>b__13_13(ref byte v);
                    /*0x7f2a3d4*/ ushort <RegisterStringConverters>b__13_14(ref string v);
                    /*0x7f2a48c*/ string <RegisterStringConverters>b__13_15(ref ushort v);
                    /*0x7f2a498*/ uint <RegisterStringConverters>b__13_16(ref string v);
                    /*0x7f2a550*/ string <RegisterStringConverters>b__13_17(ref uint v);
                    /*0x7f2a55c*/ ulong <RegisterStringConverters>b__13_18(ref string v);
                    /*0x7f2a614*/ string <RegisterStringConverters>b__13_19(ref ulong v);
                    /*0x7f2a620*/ float <RegisterStringConverters>b__13_20(ref string v);
                    /*0x7f2a6d4*/ string <RegisterStringConverters>b__13_21(ref float v);
                    /*0x7f2a738*/ double <RegisterStringConverters>b__13_22(ref string v);
                    /*0x7f2a75c*/ string <RegisterStringConverters>b__13_23(ref double v);
                    /*0x7f2a7c0*/ char <RegisterObjectConverters>b__14_0(ref object v);
                    /*0x7f2a7fc*/ bool <RegisterObjectConverters>b__14_1(ref object v);
                    /*0x7f2a840*/ sbyte <RegisterObjectConverters>b__14_2(ref object v);
                    /*0x7f2a87c*/ short <RegisterObjectConverters>b__14_3(ref object v);
                    /*0x7f2a8b8*/ int <RegisterObjectConverters>b__14_4(ref object v);
                    /*0x7f2a8f4*/ long <RegisterObjectConverters>b__14_5(ref object v);
                    /*0x7f2a930*/ byte <RegisterObjectConverters>b__14_6(ref object v);
                    /*0x7f2a96c*/ ushort <RegisterObjectConverters>b__14_7(ref object v);
                    /*0x7f2a9a8*/ uint <RegisterObjectConverters>b__14_8(ref object v);
                    /*0x7f2a9e4*/ ulong <RegisterObjectConverters>b__14_9(ref object v);
                    /*0x7f2aa20*/ float <RegisterObjectConverters>b__14_10(ref object v);
                    /*0x7f2aa58*/ double <RegisterObjectConverters>b__14_11(ref object v);
                }
            }
        }

        class TypeTraits
        {
            static /*0x7f2aa90*/ bool IsContainer(System.Type type);
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

            static /*0x383e7a0*/ TypeTraits();
            static /*0x3821564*/ bool get_IsValueType();
            static /*0x3821564*/ bool get_IsPrimitive();
            static /*0x3821564*/ bool get_IsInterface();
            static /*0x3821564*/ bool get_IsAbstract();
            static /*0x3821564*/ bool get_IsArray();
            static /*0x3821564*/ bool get_IsEnum();
            static /*0x3821564*/ bool get_IsNullable();
            static /*0x3821564*/ bool get_IsObject();
            static /*0x3821564*/ bool get_IsString();
            static /*0x3821564*/ bool get_IsContainer();
            static /*0x3821564*/ bool get_CanBeNull();
            static /*0x3821564*/ bool get_IsAbstractOrInterface();
            static /*0x3821564*/ bool get_IsUnityObject();
        }

        enum InstantiationKind
        {
            Activator = 0,
            PropertyBagOverride = 1,
            NotInstantiatable = 2,
        }

        interface IConstructor
        {
            /*0x3814574*/ Unity.Properties.InstantiationKind get_InstantiationKind();
        }

        interface IConstructor<T> : Unity.Properties.IConstructor
        {
            /*0x3910ae8*/ T Instantiate();
        }

        interface IConstructorWithCount<T> : Unity.Properties.IConstructor
        {
            /*0x3910ae8*/ T InstantiateWithCount(int count);
        }

        class TypeUtility
        {
            static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, Unity.Properties.TypeUtility.ITypeConstructor> s_TypeConstructors;
            static /*0x8*/ System.Reflection.MethodInfo s_CreateTypeConstructor;
            static /*0x10*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, string> s_CachedResolvedName;
            static /*0x18*/ UnityEngine.Pool.ObjectPool<System.Text.StringBuilder> s_Builders;
            static /*0x20*/ object syncedPoolObject;

            static /*0x7f2aba4*/ TypeUtility();
            static /*0x7f2afdc*/ string GetTypeDisplayName(System.Type type);
            static /*0x7f2b0f8*/ string GetTypeDisplayName(System.Type type, System.Collections.Generic.IReadOnlyList<System.Type> args, ref int argIndex);
            static /*0x7f2b9d0*/ System.Type GetRootType(System.Type type);
            static /*0x7f2bab8*/ Unity.Properties.TypeUtility.ITypeConstructor CreateTypeConstructor(System.Type type);
            static /*0x3836db8*/ Unity.Properties.TypeUtility.ITypeConstructor<T> CreateTypeConstructor<T>();
            static /*0x7f2bd4c*/ Unity.Properties.TypeUtility.ITypeConstructor GetTypeConstructor(System.Type type);
            static /*0x3836db8*/ Unity.Properties.TypeUtility.ITypeConstructor<T> GetTypeConstructor<T>();
            static /*0x7f2be04*/ bool CanBeInstantiated(System.Type type);
            static /*0x3821564*/ bool CanBeInstantiated<T>();
            static /*0x3840c74*/ void SetExplicitInstantiationMethod<T>(System.Func<T> constructor);
            static /*0x3910ae8*/ T Instantiate<T>();
            static /*0x3823ae0*/ bool TryInstantiate<T>(ref T instance);
            static /*0x3910ae8*/ T Instantiate<T>(System.Type derivedType);
            static /*0x3825b78*/ bool TryInstantiate<T>(System.Type derivedType, ref T value);
            static /*0x3910ae8*/ TArray InstantiateArray<TArray>(int count);
            static /*0x38234b0*/ bool TryInstantiateArray<TArray>(int count, ref TArray instance);
            static /*0x3910ae8*/ TArray InstantiateArray<TArray>(System.Type derivedType, int count);
            static /*0x7f2bed0*/ void CheckIsAssignableFrom(System.Type type, System.Type derivedType);
            static /*0x3840c74*/ void CheckCanBeInstantiated<T>(Unity.Properties.TypeUtility.ITypeConstructor<T> constructor);
            static /*0x7f2c038*/ void CheckCanBeInstantiated(Unity.Properties.TypeUtility.ITypeConstructor constructor, System.Type type);

            interface ITypeConstructor
            {
                /*0x3813ffc*/ bool get_CanBeInstantiated();
                /*0x38148bc*/ object Instantiate();
            }

            interface ITypeConstructor<T> : Unity.Properties.TypeUtility.ITypeConstructor
            {
                /*0x3910ae8*/ T Instantiate();
                /*0x3816710*/ void SetExplicitConstructor(System.Func<T> constructor);
            }

            class TypeConstructor<T> : Unity.Properties.TypeUtility.ITypeConstructor<T>, Unity.Properties.TypeUtility.ITypeConstructor
            {
                /*0x0*/ System.Func<T> m_ExplicitConstructor;
                /*0x0*/ System.Func<T> m_ImplicitConstructor;
                /*0x0*/ Unity.Properties.IConstructor<T> m_OverrideConstructor;

                static /*0x3910ae8*/ T CreateValueTypeInstance();
                static /*0x3910ae8*/ T CreateScriptableObjectInstance();
                static /*0x3910ae8*/ T CreateClassInstance();
                /*0x38159dc*/ TypeConstructor();
                /*0x3813ffc*/ bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated();
                /*0x38159dc*/ void SetImplicitConstructor();
                /*0x3816710*/ void SetExplicitConstructor(System.Func<T> constructor);
                /*0x3910ae8*/ T Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate();
                /*0x38148bc*/ object Unity.Properties.TypeUtility.ITypeConstructor.Instantiate();
            }

            class NonConstructable : Unity.Properties.TypeUtility.ITypeConstructor
            {
                /*0x7f2bd44*/ NonConstructable();
                /*0x7f2c168*/ bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated();
                /*0x7f2c170*/ object Instantiate();
            }

            struct Cache<T>
            {
                static /*0x0*/ Unity.Properties.TypeUtility.ITypeConstructor<T> TypeConstructor;
            }

            class TypeConstructorVisitor : Unity.Properties.ITypeVisitor
            {
                /*0x10*/ Unity.Properties.TypeUtility.ITypeConstructor TypeConstructor;

                /*0x7f2bd3c*/ TypeConstructorVisitor();
                /*0x38159dc*/ void Visit<TContainer>();
            }

            class <>c
            {
                static /*0x0*/ Unity.Properties.TypeUtility.<> <>9;

                static /*0x7f2c1bc*/ <>c();
                /*0x7f2c224*/ <>c();
                /*0x7f2c22c*/ System.Text.StringBuilder <.cctor>b__11_0();
                /*0x7f2c280*/ void <.cctor>b__11_1(System.Text.StringBuilder sb);
                /*0x7f2c298*/ string <.cctor>b__11_2();
            }
        }

        namespace Internal
        {
            interface IAttributes
            {
                /*0x38148bc*/ System.Collections.Generic.List<System.Attribute> get_Attributes();
                /*0x3816710*/ void set_Attributes(System.Collections.Generic.List<System.Attribute> value);
                /*0x3816710*/ void AddAttribute(System.Attribute attribute);
                /*0x3816710*/ void AddAttributes(System.Collections.Generic.IEnumerable<System.Attribute> attributes);
                Unity.Properties.AttributesScope CreateAttributesScope(Unity.Properties.Internal.IAttributes attributes);
            }

            class PropertiesInitialization
            {
                static /*0x7f2c2b0*/ void InitializeProperties();
            }

            class ColorPropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Color>
            {
                /*0x7f2c690*/ ColorPropertyBag();

                class RProperty : Unity.Properties.Property<UnityEngine.Color, float>
                {
                    /*0x7f2d388*/ RProperty();
                    /*0x7f2d4a8*/ string get_Name();
                    /*0x7f2d4e8*/ bool get_IsReadOnly();
                    /*0x7f2d4f0*/ float GetValue(ref UnityEngine.Color container);
                    /*0x7f2d4f8*/ void SetValue(ref UnityEngine.Color container, float value);
                }

                class GProperty : Unity.Properties.Property<UnityEngine.Color, float>
                {
                    /*0x7f2d3d0*/ GProperty();
                    /*0x7f2d500*/ string get_Name();
                    /*0x7f2d540*/ bool get_IsReadOnly();
                    /*0x7f2d548*/ float GetValue(ref UnityEngine.Color container);
                    /*0x7f2d550*/ void SetValue(ref UnityEngine.Color container, float value);
                }

                class BProperty : Unity.Properties.Property<UnityEngine.Color, float>
                {
                    /*0x7f2d418*/ BProperty();
                    /*0x7f2d558*/ string get_Name();
                    /*0x7f2d598*/ bool get_IsReadOnly();
                    /*0x7f2d5a0*/ float GetValue(ref UnityEngine.Color container);
                    /*0x7f2d5a8*/ void SetValue(ref UnityEngine.Color container, float value);
                }

                class AProperty : Unity.Properties.Property<UnityEngine.Color, float>
                {
                    /*0x7f2d460*/ AProperty();
                    /*0x7f2d5b0*/ string get_Name();
                    /*0x7f2d5f0*/ bool get_IsReadOnly();
                    /*0x7f2d5f8*/ float GetValue(ref UnityEngine.Color container);
                    /*0x7f2d600*/ void SetValue(ref UnityEngine.Color container, float value);
                }
            }

            class Vector2PropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Vector2>
            {
                /*0x7f2c7f0*/ Vector2PropertyBag();

                class XProperty : Unity.Properties.Property<UnityEngine.Vector2, float>
                {
                    /*0x7f2d608*/ XProperty();
                    /*0x7f2d698*/ string get_Name();
                    /*0x7f2d6d8*/ bool get_IsReadOnly();
                    /*0x7f2d6e0*/ float GetValue(ref UnityEngine.Vector2 container);
                    /*0x7f2d6e8*/ void SetValue(ref UnityEngine.Vector2 container, float value);
                }

                class YProperty : Unity.Properties.Property<UnityEngine.Vector2, float>
                {
                    /*0x7f2d650*/ YProperty();
                    /*0x7f2d6f0*/ string get_Name();
                    /*0x7f2d730*/ bool get_IsReadOnly();
                    /*0x7f2d738*/ float GetValue(ref UnityEngine.Vector2 container);
                    /*0x7f2d740*/ void SetValue(ref UnityEngine.Vector2 container, float value);
                }
            }

            class Vector3PropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Vector3>
            {
                /*0x7f2c8e0*/ Vector3PropertyBag();

                class XProperty : Unity.Properties.Property<UnityEngine.Vector3, float>
                {
                    /*0x7f2d748*/ XProperty();
                    /*0x7f2d820*/ string get_Name();
                    /*0x7f2d860*/ bool get_IsReadOnly();
                    /*0x7f2d868*/ float GetValue(ref UnityEngine.Vector3 container);
                    /*0x7f2d870*/ void SetValue(ref UnityEngine.Vector3 container, float value);
                }

                class YProperty : Unity.Properties.Property<UnityEngine.Vector3, float>
                {
                    /*0x7f2d790*/ YProperty();
                    /*0x7f2d878*/ string get_Name();
                    /*0x7f2d8b8*/ bool get_IsReadOnly();
                    /*0x7f2d8c0*/ float GetValue(ref UnityEngine.Vector3 container);
                    /*0x7f2d8c8*/ void SetValue(ref UnityEngine.Vector3 container, float value);
                }

                class ZProperty : Unity.Properties.Property<UnityEngine.Vector3, float>
                {
                    /*0x7f2d7d8*/ ZProperty();
                    /*0x7f2d8d0*/ string get_Name();
                    /*0x7f2d910*/ bool get_IsReadOnly();
                    /*0x7f2d918*/ float GetValue(ref UnityEngine.Vector3 container);
                    /*0x7f2d920*/ void SetValue(ref UnityEngine.Vector3 container, float value);
                }
            }

            class Vector4PropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Vector4>
            {
                /*0x7f2ca0c*/ Vector4PropertyBag();

                class XProperty : Unity.Properties.Property<UnityEngine.Vector4, float>
                {
                    /*0x7f2d928*/ XProperty();
                    /*0x7f2da48*/ string get_Name();
                    /*0x7f2da88*/ bool get_IsReadOnly();
                    /*0x7f2da90*/ float GetValue(ref UnityEngine.Vector4 container);
                    /*0x7f2da98*/ void SetValue(ref UnityEngine.Vector4 container, float value);
                }

                class YProperty : Unity.Properties.Property<UnityEngine.Vector4, float>
                {
                    /*0x7f2d970*/ YProperty();
                    /*0x7f2daa0*/ string get_Name();
                    /*0x7f2dae0*/ bool get_IsReadOnly();
                    /*0x7f2dae8*/ float GetValue(ref UnityEngine.Vector4 container);
                    /*0x7f2daf0*/ void SetValue(ref UnityEngine.Vector4 container, float value);
                }

                class ZProperty : Unity.Properties.Property<UnityEngine.Vector4, float>
                {
                    /*0x7f2d9b8*/ ZProperty();
                    /*0x7f2daf8*/ string get_Name();
                    /*0x7f2db38*/ bool get_IsReadOnly();
                    /*0x7f2db40*/ float GetValue(ref UnityEngine.Vector4 container);
                    /*0x7f2db48*/ void SetValue(ref UnityEngine.Vector4 container, float value);
                }

                class WProperty : Unity.Properties.Property<UnityEngine.Vector4, float>
                {
                    /*0x7f2da00*/ WProperty();
                    /*0x7f2db50*/ string get_Name();
                    /*0x7f2db90*/ bool get_IsReadOnly();
                    /*0x7f2db98*/ float GetValue(ref UnityEngine.Vector4 container);
                    /*0x7f2dba0*/ void SetValue(ref UnityEngine.Vector4 container, float value);
                }
            }

            class Vector2IntPropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Vector2Int>
            {
                /*0x7f2cb6c*/ Vector2IntPropertyBag();

                class XProperty : Unity.Properties.Property<UnityEngine.Vector2Int, int>
                {
                    /*0x7f2dba8*/ XProperty();
                    /*0x7f2dc38*/ string get_Name();
                    /*0x7f2dc78*/ bool get_IsReadOnly();
                    /*0x7f2dc80*/ int GetValue(ref UnityEngine.Vector2Int container);
                    /*0x7f2dc88*/ void SetValue(ref UnityEngine.Vector2Int container, int value);
                }

                class YProperty : Unity.Properties.Property<UnityEngine.Vector2Int, int>
                {
                    /*0x7f2dbf0*/ YProperty();
                    /*0x7f2dc90*/ string get_Name();
                    /*0x7f2dcd0*/ bool get_IsReadOnly();
                    /*0x7f2dcd8*/ int GetValue(ref UnityEngine.Vector2Int container);
                    /*0x7f2dce0*/ void SetValue(ref UnityEngine.Vector2Int container, int value);
                }
            }

            class Vector3IntPropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Vector3Int>
            {
                /*0x7f2cc5c*/ Vector3IntPropertyBag();

                class XProperty : Unity.Properties.Property<UnityEngine.Vector3Int, int>
                {
                    /*0x7f2dce8*/ XProperty();
                    /*0x7f2ddc0*/ string get_Name();
                    /*0x7f2de00*/ bool get_IsReadOnly();
                    /*0x7f2de08*/ int GetValue(ref UnityEngine.Vector3Int container);
                    /*0x7f2de10*/ void SetValue(ref UnityEngine.Vector3Int container, int value);
                }

                class YProperty : Unity.Properties.Property<UnityEngine.Vector3Int, int>
                {
                    /*0x7f2dd30*/ YProperty();
                    /*0x7f2de18*/ string get_Name();
                    /*0x7f2de58*/ bool get_IsReadOnly();
                    /*0x7f2de60*/ int GetValue(ref UnityEngine.Vector3Int container);
                    /*0x7f2de68*/ void SetValue(ref UnityEngine.Vector3Int container, int value);
                }

                class ZProperty : Unity.Properties.Property<UnityEngine.Vector3Int, int>
                {
                    /*0x7f2dd78*/ ZProperty();
                    /*0x7f2de70*/ string get_Name();
                    /*0x7f2deb0*/ bool get_IsReadOnly();
                    /*0x7f2deb8*/ int GetValue(ref UnityEngine.Vector3Int container);
                    /*0x7f2dec0*/ void SetValue(ref UnityEngine.Vector3Int container, int value);
                }
            }

            class RectPropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Rect>
            {
                /*0x7f2cd88*/ RectPropertyBag();

                class XProperty : Unity.Properties.Property<UnityEngine.Rect, float>
                {
                    /*0x7f2dec8*/ XProperty();
                    /*0x7f2dfe8*/ string get_Name();
                    /*0x7f2e028*/ bool get_IsReadOnly();
                    /*0x7f2e030*/ float GetValue(ref UnityEngine.Rect container);
                    /*0x7f2e038*/ void SetValue(ref UnityEngine.Rect container, float value);
                }

                class YProperty : Unity.Properties.Property<UnityEngine.Rect, float>
                {
                    /*0x7f2df10*/ YProperty();
                    /*0x7f2e040*/ string get_Name();
                    /*0x7f2e080*/ bool get_IsReadOnly();
                    /*0x7f2e088*/ float GetValue(ref UnityEngine.Rect container);
                    /*0x7f2e090*/ void SetValue(ref UnityEngine.Rect container, float value);
                }

                class WidthProperty : Unity.Properties.Property<UnityEngine.Rect, float>
                {
                    /*0x7f2df58*/ WidthProperty();
                    /*0x7f2e098*/ string get_Name();
                    /*0x7f2e0d8*/ bool get_IsReadOnly();
                    /*0x7f2e0e0*/ float GetValue(ref UnityEngine.Rect container);
                    /*0x7f2e0e8*/ void SetValue(ref UnityEngine.Rect container, float value);
                }

                class HeightProperty : Unity.Properties.Property<UnityEngine.Rect, float>
                {
                    /*0x7f2dfa0*/ HeightProperty();
                    /*0x7f2e0f0*/ string get_Name();
                    /*0x7f2e130*/ bool get_IsReadOnly();
                    /*0x7f2e138*/ float GetValue(ref UnityEngine.Rect container);
                    /*0x7f2e140*/ void SetValue(ref UnityEngine.Rect container, float value);
                }
            }

            class RectIntPropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.RectInt>
            {
                /*0x7f2cee8*/ RectIntPropertyBag();

                class XProperty : Unity.Properties.Property<UnityEngine.RectInt, int>
                {
                    /*0x7f2e148*/ XProperty();
                    /*0x7f2e268*/ string get_Name();
                    /*0x7f2e2a8*/ bool get_IsReadOnly();
                    /*0x7f2e2b0*/ int GetValue(ref UnityEngine.RectInt container);
                    /*0x7f2e2b8*/ void SetValue(ref UnityEngine.RectInt container, int value);
                }

                class YProperty : Unity.Properties.Property<UnityEngine.RectInt, int>
                {
                    /*0x7f2e190*/ YProperty();
                    /*0x7f2e2c0*/ string get_Name();
                    /*0x7f2e300*/ bool get_IsReadOnly();
                    /*0x7f2e308*/ int GetValue(ref UnityEngine.RectInt container);
                    /*0x7f2e310*/ void SetValue(ref UnityEngine.RectInt container, int value);
                }

                class WidthProperty : Unity.Properties.Property<UnityEngine.RectInt, int>
                {
                    /*0x7f2e1d8*/ WidthProperty();
                    /*0x7f2e318*/ string get_Name();
                    /*0x7f2e358*/ bool get_IsReadOnly();
                    /*0x7f2e360*/ int GetValue(ref UnityEngine.RectInt container);
                    /*0x7f2e368*/ void SetValue(ref UnityEngine.RectInt container, int value);
                }

                class HeightProperty : Unity.Properties.Property<UnityEngine.RectInt, int>
                {
                    /*0x7f2e220*/ HeightProperty();
                    /*0x7f2e370*/ string get_Name();
                    /*0x7f2e3b0*/ bool get_IsReadOnly();
                    /*0x7f2e3b8*/ int GetValue(ref UnityEngine.RectInt container);
                    /*0x7f2e3c0*/ void SetValue(ref UnityEngine.RectInt container, int value);
                }
            }

            class BoundsPropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.Bounds>
            {
                /*0x7f2d048*/ BoundsPropertyBag();

                class CenterProperty : Unity.Properties.Property<UnityEngine.Bounds, UnityEngine.Vector3>
                {
                    /*0x7f2e3c8*/ CenterProperty();
                    /*0x7f2e458*/ string get_Name();
                    /*0x7f2e498*/ bool get_IsReadOnly();
                    /*0x7f2e4a0*/ UnityEngine.Vector3 GetValue(ref UnityEngine.Bounds container);
                    /*0x7f2e4ac*/ void SetValue(ref UnityEngine.Bounds container, UnityEngine.Vector3 value);
                }

                class ExtentsProperty : Unity.Properties.Property<UnityEngine.Bounds, UnityEngine.Vector3>
                {
                    /*0x7f2e410*/ ExtentsProperty();
                    /*0x7f2e4b8*/ string get_Name();
                    /*0x7f2e4f8*/ bool get_IsReadOnly();
                    /*0x7f2e500*/ UnityEngine.Vector3 GetValue(ref UnityEngine.Bounds container);
                    /*0x7f2e50c*/ void SetValue(ref UnityEngine.Bounds container, UnityEngine.Vector3 value);
                }
            }

            class BoundsIntPropertyBag : Unity.Properties.ContainerPropertyBag<UnityEngine.BoundsInt>
            {
                /*0x7f2d138*/ BoundsIntPropertyBag();

                class PositionProperty : Unity.Properties.Property<UnityEngine.BoundsInt, UnityEngine.Vector3Int>
                {
                    /*0x7f2e518*/ PositionProperty();
                    /*0x7f2e5a8*/ string get_Name();
                    /*0x7f2e5e8*/ bool get_IsReadOnly();
                    /*0x7f2e5f0*/ UnityEngine.Vector3Int GetValue(ref UnityEngine.BoundsInt container);
                    /*0x7f2e5fc*/ void SetValue(ref UnityEngine.BoundsInt container, UnityEngine.Vector3Int value);
                }

                class SizeProperty : Unity.Properties.Property<UnityEngine.BoundsInt, UnityEngine.Vector3Int>
                {
                    /*0x7f2e560*/ SizeProperty();
                    /*0x7f2e608*/ string get_Name();
                    /*0x7f2e648*/ bool get_IsReadOnly();
                    /*0x7f2e650*/ UnityEngine.Vector3Int GetValue(ref UnityEngine.BoundsInt container);
                    /*0x7f2e65c*/ void SetValue(ref UnityEngine.BoundsInt container, UnityEngine.Vector3Int value);
                }
            }

            class SystemVersionPropertyBag : Unity.Properties.ContainerPropertyBag<System.Version>
            {
                /*0x7f2d228*/ SystemVersionPropertyBag();

                class MajorProperty : Unity.Properties.Property<System.Version, int>
                {
                    /*0x7f2e668*/ MajorProperty();
                    /*0x7f2e8e8*/ string get_Name();
                    /*0x7f2e928*/ bool get_IsReadOnly();
                    /*0x7f2e930*/ int GetValue(ref System.Version container);
                    /*0x7f2e94c*/ void SetValue(ref System.Version container, int value);
                }

                class MinorProperty : Unity.Properties.Property<System.Version, int>
                {
                    /*0x7f2e708*/ MinorProperty();
                    /*0x7f2e950*/ string get_Name();
                    /*0x7f2e990*/ bool get_IsReadOnly();
                    /*0x7f2e998*/ int GetValue(ref System.Version container);
                    /*0x7f2e9b4*/ void SetValue(ref System.Version container, int value);
                }

                class BuildProperty : Unity.Properties.Property<System.Version, int>
                {
                    /*0x7f2e7a8*/ BuildProperty();
                    /*0x7f2e9b8*/ string get_Name();
                    /*0x7f2e9f8*/ bool get_IsReadOnly();
                    /*0x7f2ea00*/ int GetValue(ref System.Version container);
                    /*0x7f2ea1c*/ void SetValue(ref System.Version container, int value);
                }

                class RevisionProperty : Unity.Properties.Property<System.Version, int>
                {
                    /*0x7f2e848*/ RevisionProperty();
                    /*0x7f2ea20*/ string get_Name();
                    /*0x7f2ea60*/ bool get_IsReadOnly();
                    /*0x7f2ea68*/ int GetValue(ref System.Version container);
                    /*0x7f2ea84*/ void SetValue(ref System.Version container, int value);
                }
            }

            interface IPropertyBagRegister
            {
                /*0x38159dc*/ void Register();
            }

            class PropertyBagStore
            {
                static /*0x0*/ System.Collections.Concurrent.ConcurrentDictionary<System.Type, Unity.Properties.IPropertyBag> s_PropertyBags;
                static /*0x8*/ System.Collections.Generic.List<System.Type> s_RegisteredTypes;
                static /*0x10*/ Unity.Properties.Internal.ReflectedPropertyBagProvider s_PropertyBagProvider;

                static /*0x7f2f060*/ PropertyBagStore();
                static /*0x7f2ea88*/ Unity.Properties.Internal.ReflectedPropertyBagProvider get_ReflectedPropertyBagProvider();
                static /*0x7f2c610*/ void CreatePropertyBagProvider();
                static /*0x3840c74*/ void AddPropertyBag<TContainer>(Unity.Properties.IPropertyBag<TContainer> propertyBag);
                static /*0x3836db8*/ Unity.Properties.IPropertyBag<TContainer> GetPropertyBag<TContainer>();
                static /*0x7f1bea0*/ Unity.Properties.IPropertyBag GetPropertyBag(System.Type type);
                static /*0x3825b78*/ bool TryGetPropertyBagForValue<TValue>(ref TValue value, ref Unity.Properties.IPropertyBag propertyBag);

                struct TypedStore<TContainer>
                {
                    static /*0x0*/ Unity.Properties.IPropertyBag<TContainer> PropertyBag;
                }
            }

            class ReflectedPropertyBagAttribute : System.Attribute
            {
                /*0x7f2f164*/ ReflectedPropertyBagAttribute();
            }

            class ReflectedPropertyBag<TContainer> : Unity.Properties.ContainerPropertyBag<TContainer>
            {
                /*0x38159dc*/ ReflectedPropertyBag();
                /*0x3816710*/ void AddProperty<TValue>(Unity.Properties.Property<TContainer, TValue> property);
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

                static /*0x7f2f16c*/ System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetPropertyMembers(System.Type type);
                static /*0x7f2f21c*/ bool IsValidMember(System.Reflection.MemberInfo memberInfo);
                static /*0x7f2f354*/ bool IsValidPropertyType(System.Type type);
                /*0x7f2eb30*/ ReflectedPropertyBagProvider();
                /*0x7f2ef30*/ Unity.Properties.IPropertyBag CreatePropertyBag(System.Type type);
                /*0x38148bc*/ Unity.Properties.IPropertyBag<TContainer> CreatePropertyBag<TContainer>();
                /*0x3816810*/ void CreateProperty<TContainer, TValue>(Unity.Properties.IMemberInfo member, Unity.Properties.Internal.ReflectedPropertyBag<TContainer> propertyBag);
                /*0x38148bc*/ Unity.Properties.IPropertyBag<TList> CreateIndexedCollectionPropertyBag<TList, TElement>();
                /*0x38148bc*/ Unity.Properties.IPropertyBag<TSet> CreateSetPropertyBag<TSet, TValue>();
                /*0x38148bc*/ Unity.Properties.IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag<TDictionary, TKey, TValue>();
                /*0x38148bc*/ Unity.Properties.IPropertyBag<System.Collections.Generic.KeyValuePair<TKey, TValue>> CreateKeyValuePairPropertyBag<TKey, TValue>();
                /*0x38148bc*/ Unity.Properties.IPropertyBag<TElement[]> CreateArrayPropertyBag<TElement>();
                /*0x38148bc*/ Unity.Properties.IPropertyBag<System.Collections.Generic.List<TElement>> CreateListPropertyBag<TElement>();
                /*0x38148bc*/ Unity.Properties.IPropertyBag<System.Collections.Generic.HashSet<TElement>> CreateHashSetPropertyBag<TElement>();
                /*0x38148bc*/ Unity.Properties.IPropertyBag<System.Collections.Generic.Dictionary<TKey, TValue>> CreateDictionaryPropertyBag<TKey, TValue>();

                class <>c
                {
                    static /*0x0*/ Unity.Properties.Internal.ReflectedPropertyBagProvider.<> <>9;
                    static /*0x8*/ System.Func<System.Reflection.MethodInfo, bool> <>9__10_0;
                    static /*0x10*/ System.Func<System.Reflection.MemberInfo, int> <>9__22_0;

                    static /*0x7f2f448*/ <>c();
                    /*0x7f2f4b0*/ <>c();
                    /*0x7f2f4b8*/ bool <.ctor>b__10_0(System.Reflection.MethodInfo x);
                    /*0x7f2f540*/ int <GetPropertyMembers>b__22_0(System.Reflection.MemberInfo x);
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
                    /*0x54*/ bool <hasSerializeReferenceAttribute>5__8;
                    /*0x58*/ System.Reflection.FieldInfo <field>5__9;

                    /*0x7f2f1e8*/ <GetPropertyMembers>d__22(int <>1__state);
                    /*0x7f2f568*/ void System.IDisposable.Dispose();
                    /*0x7f2f588*/ bool MoveNext();
                    /*0x7f2fdac*/ void <>m__Finally1();
                    /*0x7f2fe5c*/ System.Reflection.MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current();
                    /*0x7f2fe64*/ void System.Collections.IEnumerator.Reset();
                    /*0x7f2fe9c*/ object System.Collections.IEnumerator.get_Current();
                    /*0x7f2fea4*/ System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator();
                    /*0x7f2ff48*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }

            class ReflectionUtilities
            {
                static /*0x7f1bbf8*/ string SanitizeMemberName(System.Reflection.MemberInfo info);
            }
        }
    }
}
