class <Module>
{
}

class UnitySourceGeneratedAssemblyMonoScriptTypes_v1
{
    static /*0x14d71d0*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get();
    /*0x32f970*/ UnitySourceGeneratedAssemblyMonoScriptTypes_v1();

    struct MonoScriptData
    {
        /*0x10*/ byte[] FilePathsData;
        /*0x18*/ byte[] TypesData;
        /*0x20*/ int TotalTypes;
        /*0x24*/ int TotalFiles;
        /*0x28*/ bool IsEditorOnly;
    }
}

namespace Unity
{
    namespace VisualScripting
    {
        class VisualScriptingHelpURLAttribute : System.Attribute
        {
            /*0x534220*/ VisualScriptingHelpURLAttribute(System.Type type);
        }

        class Cloner<T> : Unity.VisualScripting.ICloner
        {
            /*0x180fc0*/ Cloner();
            /*0x17e620*/ bool Handles(System.Type type);
            /*0x183150*/ void Unity.VisualScripting.ICloner.BeforeClone(System.Type type, object original);
            /*0x2a5510*/ void BeforeClone(System.Type type, T original);
            /*0x177730*/ object Unity.VisualScripting.ICloner.ConstructClone(System.Type type, object original);
            /*0x2a5510*/ T ConstructClone(System.Type type, T original);
            /*0x183b40*/ void Unity.VisualScripting.ICloner.FillClone(System.Type type, ref object clone, object original, Unity.VisualScripting.CloningContext context);
            /*0x2a5510*/ void FillClone(System.Type type, ref T clone, T original, Unity.VisualScripting.CloningContext context);
            /*0x183150*/ void Unity.VisualScripting.ICloner.AfterClone(System.Type type, object clone);
            /*0x2a5510*/ void AfterClone(System.Type type, T clone);
        }

        class AnimationCurveCloner : Unity.VisualScripting.Cloner<UnityEngine.AnimationCurve>
        {
            /*0x14b08b0*/ AnimationCurveCloner();
            /*0x14b0830*/ bool Handles(System.Type type);
            /*0x14b06f0*/ UnityEngine.AnimationCurve ConstructClone(System.Type type, UnityEngine.AnimationCurve original);
            /*0x14b0740*/ void FillClone(System.Type type, ref UnityEngine.AnimationCurve clone, UnityEngine.AnimationCurve original, Unity.VisualScripting.CloningContext context);
        }

        class ArrayCloner : Unity.VisualScripting.Cloner<System.Array>
        {
            /*0x14b0de0*/ ArrayCloner();
            /*0x14b0dc0*/ bool Handles(System.Type type);
            /*0x14b0c10*/ System.Array ConstructClone(System.Type type, System.Array original);
            /*0x14b0c50*/ void FillClone(System.Type type, ref System.Array clone, System.Array original, Unity.VisualScripting.CloningContext context);
        }

        class DictionaryCloner : Unity.VisualScripting.Cloner<System.Collections.IDictionary>
        {
            /*0x14ba120*/ DictionaryCloner();
            /*0x14ba090*/ bool Handles(System.Type type);
            /*0x14b9d00*/ void FillClone(System.Type type, ref System.Collections.IDictionary clone, System.Collections.IDictionary original, Unity.VisualScripting.CloningContext context);
        }

        class EnumerableCloner : Unity.VisualScripting.Cloner<System.Collections.IEnumerable>
        {
            /*0x10*/ System.Collections.Generic.Dictionary<System.Type, Unity.VisualScripting.IOptimizedInvoker> addMethods;

            /*0x14bd2d0*/ EnumerableCloner();
            /*0x14bd1b0*/ bool Handles(System.Type type);
            /*0x14bcc10*/ void FillClone(System.Type type, ref System.Collections.IEnumerable clone, System.Collections.IEnumerable original, Unity.VisualScripting.CloningContext context);
            /*0x14bcf60*/ Unity.VisualScripting.IOptimizedInvoker GetAddMethod(System.Type type);
        }

        class FakeSerializationCloner : Unity.VisualScripting.ReflectedCloner
        {
            /*0x20*/ Unity.VisualScripting.FullSerializer.fsConfig <config>k__BackingField;

            /*0x14bf410*/ FakeSerializationCloner();
            /*0x61a260*/ Unity.VisualScripting.FullSerializer.fsConfig get_config();
            /*0x7965a0*/ void set_config(Unity.VisualScripting.FullSerializer.fsConfig value);
            /*0x14bf250*/ void BeforeClone(System.Type type, object original);
            /*0x14bf1f0*/ void AfterClone(System.Type type, object clone);
            /*0x14bf2b0*/ System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetMembers(System.Type type);

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.FakeSerializationCloner.<> <>9;
                static /*0x8*/ System.Func<Unity.VisualScripting.FullSerializer.fsMetaProperty, System.Reflection.MemberInfo> <>9__6_0;

                static /*0x14d30b0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x10daaf0*/ System.Reflection.MemberInfo <GetMembers>b__6_0(Unity.VisualScripting.FullSerializer.fsMetaProperty p);
            }
        }

        class FieldsCloner : Unity.VisualScripting.ReflectedCloner
        {
            /*0x14bf480*/ FieldsCloner();
            /*0x3ce290*/ bool IncludeField(System.Reflection.FieldInfo field);
            /*0x348b00*/ bool IncludeProperty(System.Reflection.PropertyInfo property);
        }

        class GradientCloner : Unity.VisualScripting.Cloner<UnityEngine.Gradient>
        {
            /*0x14bfaf0*/ GradientCloner();
            /*0x14bfa70*/ bool Handles(System.Type type);
            /*0x14bf9a0*/ UnityEngine.Gradient ConstructClone(System.Type type, UnityEngine.Gradient original);
            /*0x14bf9f0*/ void FillClone(System.Type type, ref UnityEngine.Gradient clone, UnityEngine.Gradient original, Unity.VisualScripting.CloningContext context);
        }

        class ListCloner : Unity.VisualScripting.Cloner<System.Collections.IList>
        {
            /*0x14c9af0*/ ListCloner();
            /*0x14c9a60*/ bool Handles(System.Type type);
            /*0x14c9510*/ void FillClone(System.Type type, ref System.Collections.IList clone, System.Collections.IList original, Unity.VisualScripting.CloningContext context);
        }

        class ReflectedCloner : Unity.VisualScripting.Cloner<object>
        {
            /*0x10*/ System.Collections.Generic.Dictionary<System.Type, System.Reflection.MemberInfo[]> accessors;
            /*0x18*/ System.Collections.Generic.Dictionary<System.Type, Unity.VisualScripting.IOptimizedAccessor[]> optimizedAccessors;

            /*0x14d1eb0*/ ReflectedCloner();
            /*0x348b00*/ bool Handles(System.Type type);
            /*0x14d1170*/ void FillClone(System.Type type, ref object clone, object original, Unity.VisualScripting.CloningContext context);
            /*0x14d1740*/ System.Reflection.MemberInfo[] GetAccessors(System.Type type);
            /*0x14d1a50*/ Unity.VisualScripting.IOptimizedAccessor[] GetOptimizedAccessors(System.Type type);
            /*0x14d1830*/ System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> GetMembers(System.Type type);
            /*0x348b00*/ bool IncludeField(System.Reflection.FieldInfo field);
            /*0x348b00*/ bool IncludeProperty(System.Reflection.PropertyInfo property);
        }

        class Cloning
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, bool> skippable;
            static /*0x8*/ System.Collections.Generic.HashSet<Unity.VisualScripting.ICloner> <cloners>k__BackingField;
            static /*0x10*/ Unity.VisualScripting.ArrayCloner <arrayCloner>k__BackingField;
            static /*0x18*/ Unity.VisualScripting.DictionaryCloner <dictionaryCloner>k__BackingField;
            static /*0x20*/ Unity.VisualScripting.EnumerableCloner <enumerableCloner>k__BackingField;
            static /*0x28*/ Unity.VisualScripting.ListCloner <listCloner>k__BackingField;
            static /*0x30*/ Unity.VisualScripting.AnimationCurveCloner <animationCurveCloner>k__BackingField;
            static /*0x38*/ Unity.VisualScripting.GradientCloner <gradientCloner>k__BackingField;
            static /*0x40*/ Unity.VisualScripting.FieldsCloner <fieldsCloner>k__BackingField;
            static /*0x48*/ Unity.VisualScripting.FakeSerializationCloner <fakeSerializationCloner>k__BackingField;

            static /*0x14b4790*/ Cloning();
            static /*0x14b50f0*/ System.Collections.Generic.HashSet<Unity.VisualScripting.ICloner> get_cloners();
            static /*0x14b50a0*/ Unity.VisualScripting.ArrayCloner get_arrayCloner();
            static /*0x14b5140*/ Unity.VisualScripting.DictionaryCloner get_dictionaryCloner();
            static /*0x14b5190*/ Unity.VisualScripting.EnumerableCloner get_enumerableCloner();
            static /*0x14b52d0*/ Unity.VisualScripting.ListCloner get_listCloner();
            static /*0x14b5050*/ Unity.VisualScripting.AnimationCurveCloner get_animationCurveCloner();
            static /*0x14b5280*/ Unity.VisualScripting.GradientCloner get_gradientCloner();
            static /*0x14b5230*/ Unity.VisualScripting.FieldsCloner get_fieldsCloner();
            static /*0x14b51e0*/ Unity.VisualScripting.FakeSerializationCloner get_fakeSerializationCloner();
            static /*0x14b3f00*/ object Clone(object original, Unity.VisualScripting.ICloner fallbackCloner, bool tryPreserveInstances);
            static /*0x2a5510*/ T Clone<T>(T original, Unity.VisualScripting.ICloner fallbackCloner, bool tryPreserveInstances);
            static /*0x14b3e70*/ object CloneViaFakeSerialization(object original);
            static /*0x2a5510*/ T CloneViaFakeSerialization<T>(T original);
            static /*0x14b4170*/ object Clone(Unity.VisualScripting.CloningContext context, object original);
            static /*0x14b3b30*/ void CloneInto(Unity.VisualScripting.CloningContext context, ref object clone, object original);
            static /*0x14b41e0*/ Unity.VisualScripting.ICloner GetCloner(object original, System.Type type);
            static /*0x14b4360*/ Unity.VisualScripting.ICloner GetCloner(object original, System.Type type, Unity.VisualScripting.ICloner fallbackCloner);
            static /*0x14b4570*/ bool Skippable(System.Type type);

            class <>c__DisplayClass35_0
            {
                /*0x10*/ System.Type type;

                /*0x32f970*/ <>c__DisplayClass35_0();
                /*0x14d2dc0*/ bool <GetCloner>b__0(Unity.VisualScripting.ICloner cloner);
            }
        }

        class CloningContext : Unity.VisualScripting.IPoolable, System.IDisposable
        {
            /*0x10*/ System.Collections.Generic.Dictionary<object, object> <clonings>k__BackingField;
            /*0x18*/ Unity.VisualScripting.ICloner <fallbackCloner>k__BackingField;
            /*0x20*/ bool <tryPreserveInstances>k__BackingField;
            /*0x21*/ bool disposed;

            static /*0x14b38b0*/ Unity.VisualScripting.CloningContext New(Unity.VisualScripting.ICloner fallbackCloner, bool tryPreserveInstances);
            /*0x14b3a70*/ CloningContext();
            /*0x73d3e0*/ System.Collections.Generic.Dictionary<object, object> get_clonings();
            /*0x32f410*/ Unity.VisualScripting.ICloner get_fallbackCloner();
            /*0x7963c0*/ void set_fallbackCloner(Unity.VisualScripting.ICloner value);
            /*0x796120*/ bool get_tryPreserveInstances();
            /*0x7963b0*/ void set_tryPreserveInstances(bool value);
            /*0x14b3a60*/ void Unity.VisualScripting.IPoolable.New();
            /*0x14b3a10*/ void Unity.VisualScripting.IPoolable.Free();
            /*0x14b37f0*/ void Dispose();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.CloningContext.<> <>9;
                static /*0x8*/ System.Func<Unity.VisualScripting.CloningContext> <>9__15_0;

                static /*0x14d3040*/ <>c();
                /*0x32f970*/ <>c();
                /*0x14d2510*/ Unity.VisualScripting.CloningContext <New>b__15_0();
            }
        }

        interface ICloner
        {
            /*0x17e620*/ bool Handles(System.Type type);
            /*0x177730*/ object ConstructClone(System.Type type, object original);
            /*0x183150*/ void BeforeClone(System.Type type, object original);
            /*0x183b40*/ void FillClone(System.Type type, ref object clone, object original, Unity.VisualScripting.CloningContext context);
            /*0x183150*/ void AfterClone(System.Type type, object clone);
        }

        interface ISpecifiesCloner
        {
            /*0x1803b0*/ Unity.VisualScripting.ICloner get_cloner();
        }

        class AotDictionary : System.Collections.Specialized.OrderedDictionary
        {
            static /*0x14b09f0*/ void AotStubs();
            /*0x14b0aa0*/ AotDictionary();
            /*0x14b0ad0*/ AotDictionary(System.Collections.IEqualityComparer comparer);
            /*0x14b0ab0*/ AotDictionary(int capacity);
            /*0x14b0ac0*/ AotDictionary(int capacity, System.Collections.IEqualityComparer comparer);
        }

        class AotList : System.Collections.ArrayList
        {
            static /*0x14b0ae0*/ void AotStubs();
            /*0x14b0bf0*/ AotList();
            /*0x14b0c00*/ AotList(int capacity);
            /*0x14b0be0*/ AotList(System.Collections.ICollection c);
        }

        class DebugDictionary<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection
        {
            /*0x0*/ System.Collections.Generic.Dictionary<TKey, TValue> dictionary;
            /*0x0*/ string <label>k__BackingField;
            /*0x0*/ bool <debug>k__BackingField;

            /*0x180fc0*/ DebugDictionary();
            /*0x2a5510*/ TValue get_Item(TKey key);
            /*0x2a5510*/ void set_Item(TKey key, TValue value);
            /*0x1858d0*/ object System.Collections.IDictionary.get_Item(object key);
            /*0x183150*/ void System.Collections.IDictionary.set_Item(object key, object value);
            /*0x1803b0*/ string get_label();
            /*0x17aec0*/ void set_label(string value);
            /*0x17cb40*/ bool get_debug();
            /*0x181190*/ void set_debug(bool value);
            /*0x180980*/ int get_Count();
            /*0x1803b0*/ object System.Collections.ICollection.get_SyncRoot();
            /*0x17cb40*/ bool System.Collections.ICollection.get_IsSynchronized();
            /*0x1803b0*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
            /*0x17cb40*/ bool System.Collections.IDictionary.get_IsReadOnly();
            /*0x17cb40*/ bool System.Collections.IDictionary.get_IsFixedSize();
            /*0x17cb40*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly();
            /*0x1803b0*/ System.Collections.Generic.ICollection<TKey> get_Keys();
            /*0x1803b0*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
            /*0x1803b0*/ System.Collections.Generic.ICollection<TValue> get_Values();
            /*0x182a70*/ void System.Collections.ICollection.CopyTo(System.Array array, int index);
            /*0x17aec0*/ void Debug(string message);
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x17aec0*/ void System.Collections.IDictionary.Remove(object key);
            /*0x17e620*/ bool System.Collections.IDictionary.Contains(object key);
            /*0x183150*/ void System.Collections.IDictionary.Add(object key, object value);
            /*0x180fc0*/ void Clear();
            /*0x1803b0*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
            /*0x2a5510*/ bool Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
            /*0x2a5510*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
            /*0x182a70*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
            /*0x2a5510*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
            /*0x2a5510*/ bool ContainsKey(TKey key);
            /*0x2a5510*/ void Add(TKey key, TValue value);
            /*0x2a5510*/ bool Remove(TKey key);
            /*0x2a5510*/ bool TryGetValue(TKey key, ref TValue value);
        }

        class FlexibleDictionary<TKey, TValue> : System.Collections.Generic.Dictionary<TKey, TValue>
        {
            /*0x180fc0*/ FlexibleDictionary();
            /*0x2a5510*/ TValue get_Item(TKey key);
            /*0x2a5510*/ void set_Item(TKey key, TValue value);
        }

        class GuidCollection<T> : System.Collections.ObjectModel.KeyedCollection<System.Guid, T>, Unity.VisualScripting.IKeyedCollection<System.Guid, T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            /*0x180fc0*/ GuidCollection();
            /*0x2a5510*/ System.Guid GetKeyForItem(T item);
            /*0x2a5510*/ void InsertItem(int index, T item);
            /*0x2a5510*/ void SetItem(int index, T item);
            bool TryGetValue(System.Guid key, ref T value);
            /*0x2a5510*/ T Unity.VisualScripting.IKeyedCollection<System.Guid,T>.get_Item(System.Guid key);
            bool Unity.VisualScripting.IKeyedCollection<System.Guid,T>.Contains(System.Guid key);
            bool Unity.VisualScripting.IKeyedCollection<System.Guid,T>.Remove(System.Guid key);
        }

        interface IKeyedCollection<TKey, TItem> : System.Collections.Generic.ICollection<TItem>, System.Collections.Generic.IEnumerable<TItem>, System.Collections.IEnumerable
        {
            /*0x2a5510*/ TItem get_Item(TKey key);
            /*0x2a5510*/ TItem get_Item(int index);
            /*0x2a5510*/ bool TryGetValue(TKey key, ref TItem value);
            /*0x2a5510*/ bool Contains(TKey key);
            /*0x2a5510*/ bool Remove(TKey key);
        }

        interface IMergedCollection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            /*0x17cb40*/ bool Includes<TI>();
            /*0x17e620*/ bool Includes(System.Type elementType);
        }

        interface INotifiedCollectionItem
        {
            /*0x180fc0*/ void BeforeAdd();
            /*0x180fc0*/ void AfterAdd();
            /*0x180fc0*/ void BeforeRemove();
            /*0x180fc0*/ void AfterRemove();
        }

        interface INotifyCollectionChanged<T>
        {
            /*0x17aec0*/ void add_ItemAdded(System.Action<T> value);
            /*0x17aec0*/ void remove_ItemAdded(System.Action<T> value);
            /*0x17aec0*/ void add_ItemRemoved(System.Action<T> value);
            /*0x17aec0*/ void remove_ItemRemoved(System.Action<T> value);
            /*0x17aec0*/ void add_CollectionChanged(System.Action value);
            /*0x17aec0*/ void remove_CollectionChanged(System.Action value);
        }

        interface IProxyableNotifyCollectionChanged<T>
        {
            /*0x17cb40*/ bool get_ProxyCollectionChange();
            /*0x181190*/ void set_ProxyCollectionChange(bool value);
            /*0x2a5510*/ void BeforeAdd(T item);
            /*0x2a5510*/ void AfterAdd(T item);
            /*0x2a5510*/ void BeforeRemove(T item);
            /*0x2a5510*/ void AfterRemove(T item);
        }

        interface ISet<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            /*0x2a5510*/ bool Add(T item);
            /*0x17aec0*/ void UnionWith(System.Collections.Generic.IEnumerable<T> other);
            /*0x17aec0*/ void IntersectWith(System.Collections.Generic.IEnumerable<T> other);
            /*0x17aec0*/ void ExceptWith(System.Collections.Generic.IEnumerable<T> other);
            /*0x17aec0*/ void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> other);
            /*0x17e620*/ bool IsSubsetOf(System.Collections.Generic.IEnumerable<T> other);
            /*0x17e620*/ bool IsSupersetOf(System.Collections.Generic.IEnumerable<T> other);
            /*0x17e620*/ bool IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other);
            /*0x17e620*/ bool IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other);
            /*0x17e620*/ bool Overlaps(System.Collections.Generic.IEnumerable<T> other);
            /*0x17e620*/ bool SetEquals(System.Collections.Generic.IEnumerable<T> other);
        }

        class MergedCollection<T> : Unity.VisualScripting.IMergedCollection<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.ICollection<T>> collections;

            /*0x180fc0*/ MergedCollection();
            /*0x180980*/ int get_Count();
            /*0x17cb40*/ bool get_IsReadOnly();
            /*0x17aec0*/ void Include<TI>(System.Collections.Generic.ICollection<TI> collection);
            /*0x17cb40*/ bool Includes<TI>();
            /*0x17e620*/ bool Includes(System.Type implementationType);
            /*0x1803b0*/ System.Collections.Generic.ICollection<TI> ForType<TI>();
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
            /*0x2a5510*/ System.Collections.Generic.ICollection<T> GetCollectionForItem(T item);
            /*0x185960*/ System.Collections.Generic.ICollection<T> GetCollectionForType(System.Type type, bool throwOnFail);
            /*0x2a5510*/ bool Contains(T item);
            /*0x2a5510*/ void Add(T item);
            /*0x180fc0*/ void Clear();
            /*0x2a5510*/ bool Remove(T item);
            /*0x182a70*/ void CopyTo(T[] array, int arrayIndex);

            class <GetEnumerator>d__<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ Unity.VisualScripting.MergedCollection<T> <>4__this;
                /*0x0*/ System.Collections.Generic.Dictionary.ValueCollection.Enumerator<System.Type, System.Collections.Generic.ICollection<T>> <>7__wrap1;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap2;

                /*0x17aa40*/ <GetEnumerator>d__(int <>1__state);
                /*0x180fc0*/ void System.IDisposable.Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void <>m__Finally1();
                /*0x180fc0*/ void <>m__Finally2();
                /*0x2a5510*/ T System.Collections.Generic.IEnumerator<T>.get_Current();
                /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class MergedKeyedCollection<TKey, TItem> : Unity.VisualScripting.IMergedCollection<TItem>, System.Collections.Generic.ICollection<TItem>, System.Collections.Generic.IEnumerable<TItem>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.Dictionary<System.Type, Unity.VisualScripting.IKeyedCollection<TKey, TItem>> collections;
            /*0x0*/ System.Collections.Generic.Dictionary<System.Type, Unity.VisualScripting.IKeyedCollection<TKey, TItem>> collectionsLookup;

            /*0x180fc0*/ MergedKeyedCollection();
            /*0x2a5510*/ TItem get_Item(TKey key);
            /*0x180980*/ int get_Count();
            /*0x17cb40*/ bool get_IsReadOnly();
            /*0x17cb40*/ bool Includes<TSubItem>();
            /*0x17e620*/ bool Includes(System.Type elementType);
            /*0x1803b0*/ Unity.VisualScripting.IKeyedCollection<TKey, TSubItem> ForType<TSubItem>();
            /*0x17aec0*/ void Include<TSubItem>(Unity.VisualScripting.IKeyedCollection<TKey, TSubItem> collection);
            /*0x2a5510*/ Unity.VisualScripting.IKeyedCollection<TKey, TItem> GetCollectionForItem(TItem item);
            /*0x185960*/ Unity.VisualScripting.IKeyedCollection<TKey, TItem> GetCollectionForType(System.Type type, bool throwOnFail);
            /*0x2a5510*/ Unity.VisualScripting.IKeyedCollection<TKey, TItem> GetCollectionForKey(TKey key, bool throwOnFail);
            /*0x2a5510*/ bool TryGetValue(TKey key, ref TItem value);
            /*0x2a5510*/ void Add(TItem item);
            /*0x180fc0*/ void Clear();
            /*0x2a5510*/ bool Contains(TItem item);
            /*0x2a5510*/ bool Remove(TItem item);
            /*0x182a70*/ void CopyTo(TItem[] array, int arrayIndex);
            /*0x2a5510*/ bool Contains(TKey key);
            /*0x2a5510*/ bool Remove(TKey key);
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<TItem> System.Collections.Generic.IEnumerable<TItem>.GetEnumerator();
            /*0x2a5510*/ Unity.VisualScripting.MergedKeyedCollection.Enumerator<TKey, TItem> GetEnumerator();

            struct Enumerator<TKey, TItem> : System.Collections.Generic.IEnumerator<TItem>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ System.Collections.Generic.Dictionary.Enumerator<System.Type, Unity.VisualScripting.IKeyedCollection<TKey, TItem>> collectionsEnumerator;
                /*0x0*/ TItem currentItem;
                /*0x0*/ Unity.VisualScripting.IKeyedCollection<TKey, TItem> currentCollection;
                /*0x0*/ int indexInCurrentCollection;
                /*0x0*/ bool exceeded;

                /*0x17aec0*/ Enumerator(Unity.VisualScripting.MergedKeyedCollection<TKey, TItem> merged);
                /*0x180fc0*/ void Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x2a5510*/ TItem get_Current();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
            }
        }

        class MergedList<T> : Unity.VisualScripting.IMergedCollection<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.IList<T>> lists;

            /*0x180fc0*/ MergedList();
            /*0x180980*/ int get_Count();
            /*0x17cb40*/ bool get_IsReadOnly();
            /*0x17aec0*/ void Include<TI>(System.Collections.Generic.IList<TI> list);
            /*0x17cb40*/ bool Includes<TI>();
            /*0x17e620*/ bool Includes(System.Type elementType);
            /*0x1803b0*/ System.Collections.Generic.IList<TI> ForType<TI>();
            /*0x2a5510*/ System.Collections.Generic.IList<T> GetListForItem(T item);
            /*0x185960*/ System.Collections.Generic.IList<T> GetListForType(System.Type type, bool throwOnFail);
            /*0x2a5510*/ bool Contains(T item);
            /*0x2a5510*/ void Add(T item);
            /*0x180fc0*/ void Clear();
            /*0x2a5510*/ bool Remove(T item);
            /*0x182a70*/ void CopyTo(T[] array, int arrayIndex);
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
            /*0x2a5510*/ Unity.VisualScripting.MergedList.Enumerator<T> GetEnumerator();

            struct Enumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ System.Collections.Generic.Dictionary.Enumerator<System.Type, System.Collections.Generic.IList<T>> listsEnumerator;
                /*0x0*/ T currentItem;
                /*0x0*/ System.Collections.Generic.IList<T> currentList;
                /*0x0*/ int indexInCurrentList;
                /*0x0*/ bool exceeded;

                /*0x17aec0*/ Enumerator(Unity.VisualScripting.MergedList<T> merged);
                /*0x180fc0*/ void Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x2a5510*/ T get_Current();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
            }
        }

        struct NoAllocEnumerator<T> : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
        {
            /*0x0*/ System.Collections.Generic.IList<T> list;
            /*0x0*/ int index;
            /*0x0*/ T current;
            /*0x0*/ bool exceeded;

            /*0x17aec0*/ NoAllocEnumerator(System.Collections.Generic.IList<T> list);
            /*0x180fc0*/ void Dispose();
            /*0x17cb40*/ bool MoveNext();
            /*0x2a5510*/ T get_Current();
            /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
            /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
        }

        class NonNullableCollection<T> : System.Collections.ObjectModel.Collection<T>
        {
            /*0x180fc0*/ NonNullableCollection();
            /*0x2a5510*/ void InsertItem(int index, T item);
            /*0x2a5510*/ void SetItem(int index, T item);
            /*0x17aec0*/ void AddRange(System.Collections.Generic.IEnumerable<T> collection);
        }

        class NonNullableDictionary<TKey, TValue> : System.Collections.Generic.IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, System.Collections.IDictionary, System.Collections.ICollection
        {
            /*0x0*/ System.Collections.Generic.Dictionary<TKey, TValue> dictionary;

            /*0x180fc0*/ NonNullableDictionary();
            /*0x17aa40*/ NonNullableDictionary(int capacity);
            /*0x17aec0*/ NonNullableDictionary(System.Collections.Generic.IEqualityComparer<TKey> comparer);
            /*0x17aec0*/ NonNullableDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary);
            NonNullableDictionary(int capacity, System.Collections.Generic.IEqualityComparer<TKey> comparer);
            /*0x183150*/ NonNullableDictionary(System.Collections.Generic.IDictionary<TKey, TValue> dictionary, System.Collections.Generic.IEqualityComparer<TKey> comparer);
            /*0x2a5510*/ TValue get_Item(TKey key);
            /*0x2a5510*/ void set_Item(TKey key, TValue value);
            /*0x1858d0*/ object System.Collections.IDictionary.get_Item(object key);
            /*0x183150*/ void System.Collections.IDictionary.set_Item(object key, object value);
            /*0x180980*/ int get_Count();
            /*0x17cb40*/ bool get_IsSynchronized();
            /*0x1803b0*/ object get_SyncRoot();
            /*0x17cb40*/ bool get_IsReadOnly();
            /*0x1803b0*/ System.Collections.Generic.ICollection<TKey> get_Keys();
            /*0x1803b0*/ System.Collections.ICollection System.Collections.IDictionary.get_Values();
            /*0x1803b0*/ System.Collections.ICollection System.Collections.IDictionary.get_Keys();
            /*0x1803b0*/ System.Collections.Generic.ICollection<TValue> get_Values();
            /*0x17cb40*/ bool get_IsFixedSize();
            /*0x182a70*/ void CopyTo(System.Array array, int index);
            /*0x2a5510*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
            /*0x2a5510*/ void Add(TKey key, TValue value);
            /*0x183150*/ void Add(object key, object value);
            /*0x180fc0*/ void Clear();
            /*0x17e620*/ bool Contains(object key);
            /*0x1803b0*/ System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator();
            /*0x17aec0*/ void Remove(object key);
            /*0x2a5510*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
            /*0x2a5510*/ bool ContainsKey(TKey key);
            /*0x182a70*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue> array, int arrayIndex);
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> GetEnumerator();
            /*0x2a5510*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item);
            /*0x2a5510*/ bool Remove(TKey key);
            /*0x2a5510*/ bool TryGetValue(TKey key, ref TValue value);
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class NonNullableHashSet<T> : Unity.VisualScripting.ISet<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.HashSet<T> set;

            /*0x180fc0*/ NonNullableHashSet();
            /*0x17aec0*/ NonNullableHashSet(System.Collections.Generic.IEqualityComparer<T> comparer);
            /*0x17aec0*/ NonNullableHashSet(System.Collections.Generic.IEnumerable<T> collection);
            /*0x183150*/ NonNullableHashSet(System.Collections.Generic.IEnumerable<T> collection, System.Collections.Generic.IEqualityComparer<T> comparer);
            /*0x180980*/ int get_Count();
            /*0x17cb40*/ bool get_IsReadOnly();
            /*0x2a5510*/ bool Add(T item);
            /*0x180fc0*/ void Clear();
            /*0x2a5510*/ bool Contains(T item);
            /*0x182a70*/ void CopyTo(T[] array, int arrayIndex);
            /*0x17aec0*/ void ExceptWith(System.Collections.Generic.IEnumerable<T> other);
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
            /*0x17aec0*/ void IntersectWith(System.Collections.Generic.IEnumerable<T> other);
            /*0x17e620*/ bool IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other);
            /*0x17e620*/ bool IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other);
            /*0x17e620*/ bool IsSubsetOf(System.Collections.Generic.IEnumerable<T> other);
            /*0x17e620*/ bool IsSupersetOf(System.Collections.Generic.IEnumerable<T> other);
            /*0x17e620*/ bool Overlaps(System.Collections.Generic.IEnumerable<T> other);
            /*0x2a5510*/ bool Remove(T item);
            /*0x17e620*/ bool SetEquals(System.Collections.Generic.IEnumerable<T> other);
            /*0x17aec0*/ void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> other);
            /*0x17aec0*/ void UnionWith(System.Collections.Generic.IEnumerable<T> other);
            /*0x2a5510*/ void System.Collections.Generic.ICollection<T>.Add(T item);
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
        }

        class NonNullableList<T> : System.Collections.Generic.IList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.IList, System.Collections.ICollection
        {
            /*0x0*/ System.Collections.Generic.List<T> list;

            /*0x180fc0*/ NonNullableList();
            /*0x17aa40*/ NonNullableList(int capacity);
            /*0x17aec0*/ NonNullableList(System.Collections.Generic.IEnumerable<T> collection);
            /*0x2a5510*/ T get_Item(int index);
            /*0x2a5510*/ void set_Item(int index, T value);
            /*0x184ab0*/ object System.Collections.IList.get_Item(int index);
            void System.Collections.IList.set_Item(int index, object value);
            /*0x180980*/ int get_Count();
            /*0x17cb40*/ bool get_IsSynchronized();
            /*0x1803b0*/ object get_SyncRoot();
            /*0x17cb40*/ bool get_IsReadOnly();
            /*0x17cb40*/ bool get_IsFixedSize();
            /*0x182a70*/ void CopyTo(System.Array array, int index);
            /*0x2a5510*/ void Add(T item);
            /*0x17b580*/ int Add(object value);
            /*0x180fc0*/ void Clear();
            /*0x17e620*/ bool Contains(object value);
            /*0x17b580*/ int IndexOf(object value);
            void Insert(int index, object value);
            /*0x17aec0*/ void Remove(object value);
            /*0x2a5510*/ bool Contains(T item);
            /*0x182a70*/ void CopyTo(T[] array, int arrayIndex);
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> GetEnumerator();
            /*0x2a5510*/ int IndexOf(T item);
            /*0x2a5510*/ void Insert(int index, T item);
            /*0x2a5510*/ bool Remove(T item);
            /*0x17aa40*/ void RemoveAt(int index);
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x17aec0*/ void AddRange(System.Collections.Generic.IEnumerable<T> collection);
        }

        class VariantCollection<TBase, TImplementation> : System.Collections.Generic.ICollection<TBase>, System.Collections.Generic.IEnumerable<TBase>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.ICollection<TImplementation> <implementation>k__BackingField;

            /*0x17aec0*/ VariantCollection(System.Collections.Generic.ICollection<TImplementation> implementation);
            /*0x1803b0*/ System.Collections.Generic.ICollection<TImplementation> get_implementation();
            /*0x17aec0*/ void set_implementation(System.Collections.Generic.ICollection<TImplementation> value);
            /*0x180980*/ int get_Count();
            /*0x17cb40*/ bool get_IsReadOnly();
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<TBase> GetEnumerator();
            /*0x2a5510*/ void Add(TBase item);
            /*0x180fc0*/ void Clear();
            /*0x2a5510*/ bool Contains(TBase item);
            /*0x2a5510*/ bool Remove(TBase item);
            /*0x182a70*/ void CopyTo(TBase[] array, int arrayIndex);

            class <GetEnumerator>d__10<TBase, TImplementation> : System.Collections.Generic.IEnumerator<TBase>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ TBase <>2__current;
                /*0x0*/ Unity.VisualScripting.VariantCollection<TBase, TImplementation> <>4__this;
                /*0x0*/ System.Collections.Generic.IEnumerator<TImplementation> <>7__wrap1;

                /*0x17aa40*/ <GetEnumerator>d__10(int <>1__state);
                /*0x180fc0*/ void System.IDisposable.Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void <>m__Finally1();
                /*0x2a5510*/ TBase System.Collections.Generic.IEnumerator<TBase>.get_Current();
                /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
            }
        }

        class VariantKeyedCollection<TBase, TImplementation, TKey> : Unity.VisualScripting.VariantCollection<TBase, TImplementation>, Unity.VisualScripting.IKeyedCollection<TKey, TBase>, System.Collections.Generic.ICollection<TBase>, System.Collections.Generic.IEnumerable<TBase>, System.Collections.IEnumerable
        {
            /*0x0*/ Unity.VisualScripting.IKeyedCollection<TKey, TImplementation> <implementation>k__BackingField;

            /*0x17aec0*/ VariantKeyedCollection(Unity.VisualScripting.IKeyedCollection<TKey, TImplementation> implementation);
            /*0x2a5510*/ TBase get_Item(TKey key);
            /*0x1803b0*/ Unity.VisualScripting.IKeyedCollection<TKey, TImplementation> get_implementation();
            /*0x17aec0*/ void set_implementation(Unity.VisualScripting.IKeyedCollection<TKey, TImplementation> value);
            /*0x2a5510*/ bool TryGetValue(TKey key, ref TBase value);
            /*0x2a5510*/ bool Contains(TKey key);
            /*0x2a5510*/ bool Remove(TKey key);
            /*0x2a5510*/ TBase Unity.VisualScripting.IKeyedCollection<TKey,TBase>.get_Item(int index);
        }

        class VariantList<TBase, TImplementation> : System.Collections.Generic.IList<TBase>, System.Collections.Generic.ICollection<TBase>, System.Collections.Generic.IEnumerable<TBase>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.IList<TImplementation> <implementation>k__BackingField;

            /*0x17aec0*/ VariantList(System.Collections.Generic.IList<TImplementation> implementation);
            /*0x2a5510*/ TBase get_Item(int index);
            /*0x2a5510*/ void set_Item(int index, TBase value);
            /*0x1803b0*/ System.Collections.Generic.IList<TImplementation> get_implementation();
            /*0x17aec0*/ void set_implementation(System.Collections.Generic.IList<TImplementation> value);
            /*0x180980*/ int get_Count();
            /*0x17cb40*/ bool get_IsReadOnly();
            /*0x2a5510*/ void Add(TBase item);
            /*0x180fc0*/ void Clear();
            /*0x2a5510*/ bool Contains(TBase item);
            /*0x2a5510*/ bool Remove(TBase item);
            /*0x182a70*/ void CopyTo(TBase[] array, int arrayIndex);
            /*0x2a5510*/ int IndexOf(TBase item);
            /*0x2a5510*/ void Insert(int index, TBase item);
            /*0x17aa40*/ void RemoveAt(int index);
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<TBase> System.Collections.Generic.IEnumerable<TBase>.GetEnumerator();
            /*0x2a5510*/ Unity.VisualScripting.NoAllocEnumerator<TBase> GetEnumerator();
        }

        class WatchedList<T> : System.Collections.ObjectModel.Collection<T>, Unity.VisualScripting.INotifyCollectionChanged<T>
        {
            /*0x0*/ System.Action<T> ItemAdded;
            /*0x0*/ System.Action<T> ItemRemoved;
            /*0x0*/ System.Action CollectionChanged;

            /*0x180fc0*/ WatchedList();
            /*0x17aec0*/ void add_ItemAdded(System.Action<T> value);
            /*0x17aec0*/ void remove_ItemAdded(System.Action<T> value);
            /*0x17aec0*/ void add_ItemRemoved(System.Action<T> value);
            /*0x17aec0*/ void remove_ItemRemoved(System.Action<T> value);
            /*0x17aec0*/ void add_CollectionChanged(System.Action value);
            /*0x17aec0*/ void remove_CollectionChanged(System.Action value);
            /*0x2a5510*/ void InsertItem(int index, T item);
            /*0x17aa40*/ void RemoveItem(int index);
            /*0x180fc0*/ void ClearItems();
        }

        class ConnectionCollection<TConnection, TSource, TDestination> : Unity.VisualScripting.ConnectionCollectionBase<TConnection, TSource, TDestination, System.Collections.Generic.List<TConnection>>
        {
            /*0x180fc0*/ ConnectionCollection();
        }

        class ConnectionCollectionBase<TConnection, TSource, TDestination, TCollection> : Unity.VisualScripting.IConnectionCollection<TConnection, TSource, TDestination>, System.Collections.Generic.ICollection<TConnection>, System.Collections.Generic.IEnumerable<TConnection>, System.Collections.IEnumerable
        {
            /*0x0*/ System.Collections.Generic.Dictionary<TDestination, System.Collections.Generic.List<TConnection>> byDestination;
            /*0x0*/ System.Collections.Generic.Dictionary<TSource, System.Collections.Generic.List<TConnection>> bySource;
            /*0x0*/ TCollection collection;

            /*0x2a5510*/ ConnectionCollectionBase(TCollection collection);
            /*0x2a5510*/ System.Collections.Generic.IEnumerable<TConnection> get_Item(TSource source);
            /*0x2a5510*/ System.Collections.Generic.IEnumerable<TConnection> get_Item(TDestination destination);
            /*0x180980*/ int get_Count();
            /*0x17cb40*/ bool get_IsReadOnly();
            /*0x1803b0*/ System.Collections.Generic.IEnumerator<TConnection> GetEnumerator();
            /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x2a5510*/ System.Collections.Generic.IEnumerable<TConnection> WithSource(TSource source);
            /*0x2a5510*/ System.Collections.Generic.List<TConnection> WithSourceNoAlloc(TSource source);
            /*0x2a5510*/ TConnection SingleOrDefaultWithSource(TSource source);
            /*0x2a5510*/ System.Collections.Generic.IEnumerable<TConnection> WithDestination(TDestination destination);
            /*0x2a5510*/ System.Collections.Generic.List<TConnection> WithDestinationNoAlloc(TDestination destination);
            /*0x2a5510*/ TConnection SingleOrDefaultWithDestination(TDestination destination);
            /*0x2a5510*/ void Add(TConnection item);
            /*0x180fc0*/ void Clear();
            /*0x2a5510*/ bool Contains(TConnection item);
            /*0x182a70*/ void CopyTo(TConnection[] array, int arrayIndex);
            /*0x2a5510*/ bool Remove(TConnection item);
            /*0x2a5510*/ void BeforeAdd(TConnection item);
            /*0x2a5510*/ void AfterAdd(TConnection item);
            /*0x2a5510*/ void BeforeRemove(TConnection item);
            /*0x2a5510*/ void AfterRemove(TConnection item);
            /*0x2a5510*/ void AddToDictionaries(TConnection item);
            /*0x2a5510*/ void RemoveFromDictionaries(TConnection item);
        }

        class GraphConnectionCollection<TConnection, TSource, TDestination> : Unity.VisualScripting.ConnectionCollectionBase<TConnection, TSource, TDestination, Unity.VisualScripting.GraphElementCollection<TConnection>>, Unity.VisualScripting.IGraphElementCollection<TConnection>, Unity.VisualScripting.IKeyedCollection<System.Guid, TConnection>, System.Collections.Generic.ICollection<TConnection>, System.Collections.Generic.IEnumerable<TConnection>, System.Collections.IEnumerable, Unity.VisualScripting.INotifyCollectionChanged<TConnection>
        {
            /*0x17aec0*/ GraphConnectionCollection(Unity.VisualScripting.IGraph graph);
            /*0x2a5510*/ TConnection Unity.VisualScripting.IKeyedCollection<System.Guid,TConnection>.get_Item(System.Guid key);
            /*0x2a5510*/ TConnection Unity.VisualScripting.IKeyedCollection<System.Guid,TConnection>.get_Item(int index);
            bool TryGetValue(System.Guid key, ref TConnection value);
            bool Contains(System.Guid key);
            bool Remove(System.Guid key);
            /*0x17aec0*/ void add_ItemAdded(System.Action<TConnection> value);
            /*0x17aec0*/ void remove_ItemAdded(System.Action<TConnection> value);
            /*0x17aec0*/ void add_ItemRemoved(System.Action<TConnection> value);
            /*0x17aec0*/ void remove_ItemRemoved(System.Action<TConnection> value);
            /*0x17aec0*/ void add_CollectionChanged(System.Action value);
            /*0x17aec0*/ void remove_CollectionChanged(System.Action value);
            /*0x2a5510*/ void BeforeAdd(TConnection item);
            /*0x2a5510*/ void AfterAdd(TConnection item);
            /*0x2a5510*/ void BeforeRemove(TConnection item);
            /*0x2a5510*/ void AfterRemove(TConnection item);
        }

        interface IConnection<TSource, TDestination>
        {
            /*0x2a5510*/ TSource get_source();
            /*0x2a5510*/ TDestination get_destination();
        }

        interface IConnectionCollection<TConnection, TSource, TDestination> : System.Collections.Generic.ICollection<TConnection>, System.Collections.Generic.IEnumerable<TConnection>, System.Collections.IEnumerable
        {
            /*0x2a5510*/ System.Collections.Generic.IEnumerable<TConnection> get_Item(TSource source);
            /*0x2a5510*/ System.Collections.Generic.IEnumerable<TConnection> get_Item(TDestination destination);
            /*0x2a5510*/ System.Collections.Generic.IEnumerable<TConnection> WithSource(TSource source);
            /*0x2a5510*/ System.Collections.Generic.IEnumerable<TConnection> WithDestination(TDestination destination);
        }

        class InvalidConnectionException : System.Exception
        {
            /*0x14c9370*/ InvalidConnectionException();
            /*0x14c93d0*/ InvalidConnectionException(string message);
        }

        interface IDecoratorAttribute
        {
            /*0x1803b0*/ System.Type get_type();
        }

        class ValueAttribute : System.Attribute
        {
            /*0x534220*/ ValueAttribute();
        }

        class AllowsNullAttribute : System.Attribute
        {
            /*0x534220*/ AllowsNullAttribute();
        }

        class DisableAnnotationAttribute : System.Attribute
        {
            /*0x10*/ bool <disableIcon>k__BackingField;
            /*0x11*/ bool <disableGizmo>k__BackingField;

            /*0x14ba160*/ DisableAnnotationAttribute();
            /*0x793eb0*/ bool get_disableIcon();
            /*0x793ec0*/ void set_disableIcon(bool value);
            /*0xf26f80*/ bool get_disableGizmo();
            /*0xf26f90*/ void set_disableGizmo(bool value);
        }

        class EditorBindingUtility
        {
            static string FactoryMethodWarning = "This parameterless factory method is only made public for the editor. Use the constructor instead.";
        }

        class EditorTimeBinding
        {
            static /*0x0*/ System.Func<int> frameBinding;
            static /*0x8*/ System.Func<float> timeBinding;

            static /*0x14ba170*/ EditorTimeBinding();
            static /*0x14ba2c0*/ int get_frame();
            static /*0x14ba390*/ float get_time();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.EditorTimeBinding.<> <>9;

                static /*0x14d3120*/ <>c();
                /*0x32f970*/ <>c();
                /*0x10d7fd0*/ int <.cctor>b__6_0();
                /*0x14d2730*/ float <.cctor>b__6_1();
            }
        }

        class ExpectedTypeAttribute : System.Attribute
        {
            /*0x10*/ System.Type <type>k__BackingField;

            /*0x14bf140*/ ExpectedTypeAttribute(System.Type type);
            /*0x73d3e0*/ System.Type get_type();
        }

        interface IInspectableAttribute
        {
            /*0x180980*/ int get_order();
        }

        class IncludeInSettingsAttribute : System.Attribute
        {
            /*0x10*/ bool <include>k__BackingField;

            /*0xe2bcb0*/ IncludeInSettingsAttribute(bool include);
            /*0x793eb0*/ bool get_include();
            /*0x793ec0*/ void set_include(bool value);
        }

        class InspectableAttribute : System.Attribute, Unity.VisualScripting.IInspectableAttribute
        {
            /*0x10*/ int <order>k__BackingField;

            /*0x534220*/ InspectableAttribute();
            /*0x417e30*/ int get_order();
            /*0xdcd9c0*/ void set_order(int value);
        }

        class InspectableIfAttribute : System.Attribute, Unity.VisualScripting.IInspectableAttribute
        {
            /*0x10*/ int <order>k__BackingField;
            /*0x18*/ string <conditionMember>k__BackingField;

            /*0x14c9100*/ InspectableIfAttribute(string conditionMember);
            /*0x417e30*/ int get_order();
            /*0xdcd9c0*/ void set_order(int value);
            /*0x32f410*/ string get_conditionMember();
        }

        class InspectorActionDirectionAttribute : System.Attribute
        {
            /*0x10*/ Unity.VisualScripting.ActionDirection <direction>k__BackingField;

            /*0xea4040*/ InspectorActionDirectionAttribute(Unity.VisualScripting.ActionDirection direction);
            /*0x417e30*/ Unity.VisualScripting.ActionDirection get_direction();
            /*0xdcd9c0*/ void set_direction(Unity.VisualScripting.ActionDirection value);
        }

        class InspectorAdaptiveWidthAttribute : System.Attribute
        {
            /*0x10*/ float <width>k__BackingField;

            /*0x14c9140*/ InspectorAdaptiveWidthAttribute(float width);
            /*0x8c2b50*/ float get_width();
            /*0x10e91a0*/ void set_width(float value);
        }

        class InspectorDelayedAttribute : System.Attribute
        {
            /*0x534220*/ InspectorDelayedAttribute();
        }

        class InspectorExpandTooltipAttribute : System.Attribute
        {
            /*0x534220*/ InspectorExpandTooltipAttribute();
        }

        class InspectorLabelAttribute : System.Attribute
        {
            /*0x10*/ string <text>k__BackingField;
            /*0x18*/ string <tooltip>k__BackingField;
            /*0x20*/ UnityEngine.Texture <image>k__BackingField;

            /*0xa32e30*/ InspectorLabelAttribute(string text);
            /*0xea2f90*/ InspectorLabelAttribute(string text, string tooltip);
            /*0x73d3e0*/ string get_text();
            /*0x9f12f0*/ void set_text(string value);
            /*0x32f410*/ string get_tooltip();
            /*0x7963c0*/ void set_tooltip(string value);
            /*0x61a260*/ UnityEngine.Texture get_image();
            /*0x7965a0*/ void set_image(UnityEngine.Texture value);
        }

        class InspectorRangeAttribute : System.Attribute
        {
            /*0x10*/ float <min>k__BackingField;
            /*0x14*/ float <max>k__BackingField;

            /*0x14c9170*/ InspectorRangeAttribute(float min, float max);
            /*0x8c2b50*/ float get_min();
            /*0x10e91a0*/ void set_min(float value);
            /*0x8c1b90*/ float get_max();
            /*0x10e9190*/ void set_max(float value);
        }

        class InspectorTextAreaAttribute : System.Attribute
        {
            /*0x10*/ System.Nullable<float> _minLines;
            /*0x18*/ System.Nullable<float> _maxLines;

            /*0x534220*/ InspectorTextAreaAttribute();
            /*0x14c9270*/ float get_minLines();
            /*0x14c9310*/ void set_minLines(float value);
            /*0x14c91f0*/ bool get_hasMinLines();
            /*0x14c9230*/ float get_maxLines();
            /*0x14c92b0*/ void set_maxLines(float value);
            /*0x14c91b0*/ bool get_hasMaxLines();
        }

        class InspectorToggleLeftAttribute : System.Attribute
        {
            /*0x534220*/ InspectorToggleLeftAttribute();
        }

        class InspectorWideAttribute : System.Attribute
        {
            /*0x10*/ bool <toEdge>k__BackingField;

            /*0x534220*/ InspectorWideAttribute();
            /*0xe2bcb0*/ InspectorWideAttribute(bool toEdge);
            /*0x793eb0*/ bool get_toEdge();
            /*0x793ec0*/ void set_toEdge(bool value);
        }

        class InspectViaImplementationsAttribute : System.Attribute
        {
            /*0x534220*/ InspectViaImplementationsAttribute();
        }

        class NullMeansSelfAttribute : System.Attribute
        {
            /*0x534220*/ NullMeansSelfAttribute();
        }

        class PredictableAttribute : System.Attribute
        {
            /*0x534220*/ PredictableAttribute();
        }

        class TypeIconAttribute : System.Attribute
        {
            /*0x10*/ System.Type <type>k__BackingField;

            /*0x14d1f80*/ TypeIconAttribute(System.Type type);
            /*0x73d3e0*/ System.Type get_type();
        }

        class TypeIconPriorityAttribute : System.Attribute
        {
            /*0x10*/ int <priority>k__BackingField;

            /*0xea4040*/ TypeIconPriorityAttribute(int priority);
            /*0x14d2030*/ TypeIconPriorityAttribute();
            /*0x417e30*/ int get_priority();
        }

        enum TypeSet
        {
            AllTypes = 0,
            RuntimeTypes = 1,
            SettingsTypes = 2,
            SettingsAssembliesTypes = 3,
        }

        class TypeSetAttribute : System.Attribute
        {
            /*0x10*/ Unity.VisualScripting.TypeSet <typeSet>k__BackingField;

            /*0xea4040*/ TypeSetAttribute(Unity.VisualScripting.TypeSet typeSet);
            /*0x417e30*/ Unity.VisualScripting.TypeSet get_typeSet();
        }

        class WarnBeforeEditingAttribute : System.Attribute
        {
            /*0x10*/ string <warningTitle>k__BackingField;
            /*0x18*/ string <warningMessage>k__BackingField;
            /*0x20*/ object[] <emptyValues>k__BackingField;

            /*0xea2f90*/ WarnBeforeEditingAttribute(string warningTitle, string warningMessage);
            /*0x14d72b0*/ WarnBeforeEditingAttribute(string warningTitle, string warningMessage, object[] emptyValues);
            /*0x73d3e0*/ string get_warningTitle();
            /*0x32f410*/ string get_warningMessage();
            /*0x61a260*/ object[] get_emptyValues();
        }

        class WarnBeforeRemovingAttribute : System.Attribute
        {
            /*0x10*/ string <warningTitle>k__BackingField;
            /*0x18*/ string <warningMessage>k__BackingField;

            /*0xea2f90*/ WarnBeforeRemovingAttribute(string warningTitle, string warningMessage);
            /*0x73d3e0*/ string get_warningTitle();
            /*0x32f410*/ string get_warningMessage();
        }

        class Ensure
        {
            static /*0x0*/ Unity.VisualScripting.EnsureThat instance;
            static /*0x8*/ bool <IsActive>k__BackingField;

            static /*0x14bcae0*/ Ensure();
            static /*0x14bcb60*/ bool get_IsActive();
            static /*0x14bcbb0*/ void set_IsActive(bool value);
            static /*0x14bc840*/ void Off();
            static /*0x14bc9d0*/ void On();
            static /*0x14bca60*/ Unity.VisualScripting.EnsureThat That(string paramName);
            static /*0x14bc8d0*/ void OnRuntimeMethodLoad();
        }

        class EnsureThat
        {
            /*0x10*/ string paramName;

            /*0x32f970*/ EnsureThat();
            /*0x14bc050*/ void IsTrue(bool value);
            /*0x14bb120*/ void IsFalse(bool value);
            /*0x2a5510*/ void HasItems<T>(T value);
            /*0x17aec0*/ void HasItems<T>(System.Collections.Generic.ICollection<T> value);
            /*0x17aec0*/ void HasItems<T>(T[] value);
            /*0x2a5510*/ void HasNoNullItem<T>(T value);
            /*0x17aec0*/ void HasItems<T>(System.Collections.Generic.IList<T> value);
            /*0x17aec0*/ void HasItems<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> value);
            /*0x182a70*/ void SizeIs<T>(T[] value, int expected);
            void SizeIs<T>(T[] value, long expected);
            /*0x2a5510*/ void SizeIs<T>(T value, int expected);
            /*0x2a5510*/ void SizeIs<T>(T value, long expected);
            /*0x182a70*/ void SizeIs<T>(System.Collections.Generic.ICollection<T> value, int expected);
            void SizeIs<T>(System.Collections.Generic.ICollection<T> value, long expected);
            /*0x182a70*/ void SizeIs<T>(System.Collections.Generic.IList<T> value, int expected);
            void SizeIs<T>(System.Collections.Generic.IList<T> value, long expected);
            /*0x182a70*/ void SizeIs<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> value, int expected);
            void SizeIs<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> value, long expected);
            /*0x2a5510*/ void IsKeyOf<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> value, TKey expectedKey, string keyLabel);
            /*0x183150*/ void Any<T>(System.Collections.Generic.IList<T> value, System.Func<T, bool> predicate);
            /*0x183150*/ void Any<T>(System.Collections.Generic.ICollection<T> value, System.Func<T, bool> predicate);
            /*0x183150*/ void Any<T>(T[] value, System.Func<T, bool> predicate);
            /*0x2a5510*/ void Is<T>(T param, T expected);
            /*0x2a5510*/ void IsNot<T>(T param, T expected);
            /*0x2a5510*/ void IsLt<T>(T param, T limit);
            /*0x2a5510*/ void IsLte<T>(T param, T limit);
            /*0x2a5510*/ void IsGt<T>(T param, T limit);
            /*0x2a5510*/ void IsGte<T>(T param, T limit);
            /*0x2a5510*/ void IsInRange<T>(T param, T min, T max);
            /*0x14bb4e0*/ void IsNotEmpty(System.Guid value);
            /*0x2a5510*/ void IsNotNull<T>(System.Nullable<T> value);
            /*0x2a5510*/ void IsNull<T>(T value);
            /*0x2a5510*/ void IsNotNull<T>(T value);
            /*0x14ba460*/ void HasAttribute(System.Type param, System.Type attributeType);
            /*0x17aec0*/ void HasAttribute<TAttribute>(System.Type param);
            /*0x14ba6f0*/ void HasConstructorAccepting(System.Type param, System.Type[] parameterTypes, bool nonPublic);
            /*0x14ba910*/ void HasConstructorAccepting(System.Type param, System.Type[] parameterTypes);
            /*0x14badb0*/ void HasPublicConstructorAccepting(System.Type param, System.Type[] parameterTypes);
            /*0x14bbb60*/ void IsNotNullOrWhiteSpace(string value);
            /*0x14bb970*/ void IsNotNullOrEmpty(string value);
            /*0x14bbd70*/ void IsNotNull(string value);
            /*0x14bb3a0*/ void IsNotEmpty(string value);
            /*0x14ba930*/ void HasLengthBetween(string value, int minLength, int maxLength);
            /*0x14bc300*/ void Matches(string value, string match);
            /*0x14bc150*/ void Matches(string value, System.Text.RegularExpressions.Regex match);
            /*0x14bc4e0*/ void SizeIs(string value, int expected);
            /*0x14badd0*/ void IsEqualTo(string value, string expected);
            /*0x14baf60*/ void IsEqualTo(string value, string expected, System.StringComparison comparison);
            /*0x14bb7e0*/ void IsNotEqualTo(string value, string expected);
            /*0x14bb620*/ void IsNotEqualTo(string value, string expected, System.StringComparison comparison);
            /*0x14bb220*/ void IsGuid(string value);
            /*0x14bc7b0*/ bool StringEquals(string x, string y, System.Nullable<System.StringComparison> comparison);
            /*0x2a5510*/ void IsOfType<T>(T param, System.Type expectedType);
            /*0x14bbe80*/ void IsOfType(System.Type param, System.Type expectedType);
            /*0x17aec0*/ void IsOfType<T>(object param);
            /*0x17aec0*/ void IsOfType<T>(System.Type param);
            /*0x2a5510*/ void IsNotDefault<T>(T param);
        }

        class ExceptionMessages
        {
            static /*0x0*/ string <Common_IsNull_Failed>k__BackingField;
            static /*0x8*/ string <Common_IsNotNull_Failed>k__BackingField;
            static /*0x10*/ string <Booleans_IsTrueFailed>k__BackingField;
            static /*0x18*/ string <Booleans_IsFalseFailed>k__BackingField;
            static /*0x20*/ string <Collections_Any_Failed>k__BackingField;
            static /*0x28*/ string <Collections_ContainsKey_Failed>k__BackingField;
            static /*0x30*/ string <Collections_HasItemsFailed>k__BackingField;
            static /*0x38*/ string <Collections_HasNoNullItemFailed>k__BackingField;
            static /*0x40*/ string <Collections_SizeIs_Failed>k__BackingField;
            static /*0x48*/ string <Comp_Is_Failed>k__BackingField;
            static /*0x50*/ string <Comp_IsNot_Failed>k__BackingField;
            static /*0x58*/ string <Comp_IsNotLt>k__BackingField;
            static /*0x60*/ string <Comp_IsNotLte>k__BackingField;
            static /*0x68*/ string <Comp_IsNotGt>k__BackingField;
            static /*0x70*/ string <Comp_IsNotGte>k__BackingField;
            static /*0x78*/ string <Comp_IsNotInRange_ToLow>k__BackingField;
            static /*0x80*/ string <Comp_IsNotInRange_ToHigh>k__BackingField;
            static /*0x88*/ string <Guids_IsNotEmpty_Failed>k__BackingField;
            static /*0x90*/ string <Strings_IsEqualTo_Failed>k__BackingField;
            static /*0x98*/ string <Strings_IsNotEqualTo_Failed>k__BackingField;
            static /*0xa0*/ string <Strings_SizeIs_Failed>k__BackingField;
            static /*0xa8*/ string <Strings_IsNotNullOrWhiteSpace_Failed>k__BackingField;
            static /*0xb0*/ string <Strings_IsNotNullOrEmpty_Failed>k__BackingField;
            static /*0xb8*/ string <Strings_HasLengthBetween_Failed_ToShort>k__BackingField;
            static /*0xc0*/ string <Strings_HasLengthBetween_Failed_ToLong>k__BackingField;
            static /*0xc8*/ string <Strings_Matches_Failed>k__BackingField;
            static /*0xd0*/ string <Strings_IsNotEmpty_Failed>k__BackingField;
            static /*0xd8*/ string <Strings_IsGuid_Failed>k__BackingField;
            static /*0xe0*/ string <Types_IsOfType_Failed>k__BackingField;
            static /*0xe8*/ string <Reflection_HasAttribute_Failed>k__BackingField;
            static /*0xf0*/ string <Reflection_HasConstructor_Failed>k__BackingField;
            static /*0xf8*/ string <Reflection_HasPublicConstructor_Failed>k__BackingField;
            static /*0x100*/ string <ValueTypes_IsNotDefault_Failed>k__BackingField;

            static /*0x14bdcc0*/ ExceptionMessages();
            static /*0x14be860*/ string get_Common_IsNull_Failed();
            static /*0x14be810*/ string get_Common_IsNotNull_Failed();
            static /*0x14be630*/ string get_Booleans_IsTrueFailed();
            static /*0x14be5e0*/ string get_Booleans_IsFalseFailed();
            static /*0x14be680*/ string get_Collections_Any_Failed();
            static /*0x14be6d0*/ string get_Collections_ContainsKey_Failed();
            static /*0x14be720*/ string get_Collections_HasItemsFailed();
            static /*0x14be770*/ string get_Collections_HasNoNullItemFailed();
            static /*0x14be7c0*/ string get_Collections_SizeIs_Failed();
            static /*0x14beaf0*/ string get_Comp_Is_Failed();
            static /*0x14beaa0*/ string get_Comp_IsNot_Failed();
            static /*0x14bea00*/ string get_Comp_IsNotLt();
            static /*0x14bea50*/ string get_Comp_IsNotLte();
            static /*0x14be8b0*/ string get_Comp_IsNotGt();
            static /*0x14be900*/ string get_Comp_IsNotGte();
            static /*0x14be9b0*/ string get_Comp_IsNotInRange_ToLow();
            static /*0x14be950*/ string get_Comp_IsNotInRange_ToHigh();
            static /*0x14beb40*/ string get_Guids_IsNotEmpty_Failed();
            static /*0x14bed80*/ string get_Strings_IsEqualTo_Failed();
            static /*0x14beea0*/ string get_Strings_IsNotEqualTo_Failed();
            static /*0x14bf020*/ string get_Strings_SizeIs_Failed();
            static /*0x14bef60*/ string get_Strings_IsNotNullOrWhiteSpace_Failed();
            static /*0x14bef00*/ string get_Strings_IsNotNullOrEmpty_Failed();
            static /*0x14bed20*/ string get_Strings_HasLengthBetween_Failed_ToShort();
            static /*0x14becc0*/ string get_Strings_HasLengthBetween_Failed_ToLong();
            static /*0x14befc0*/ string get_Strings_Matches_Failed();
            static /*0x14bee40*/ string get_Strings_IsNotEmpty_Failed();
            static /*0x14bede0*/ string get_Strings_IsGuid_Failed();
            static /*0x14bf080*/ string get_Types_IsOfType_Failed();
            static /*0x14beba0*/ string get_Reflection_HasAttribute_Failed();
            static /*0x14bec00*/ string get_Reflection_HasConstructor_Failed();
            static /*0x14bec60*/ string get_Reflection_HasPublicConstructor_Failed();
            static /*0x14bf0e0*/ string get_ValueTypes_IsNotDefault_Failed();
        }

        class XComparable
        {
            static /*0x2a5510*/ bool IsLt<T>(System.IComparable<T> x, T y);
            static /*0x2a5510*/ bool IsEq<T>(System.IComparable<T> x, T y);
            static /*0x2a5510*/ bool IsGt<T>(System.IComparable<T> x, T y);
        }

        class XString
        {
            static /*0x14d77a0*/ string Inject(string format, object[] formattingArgs);
            static /*0x14d77b0*/ string Inject(string format, string[] formattingArgs);

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.XString.<> <>9;
                static /*0x8*/ System.Func<string, object> <>9__1_0;

                static /*0x14d2ef0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x718e40*/ object <Inject>b__1_0(string a);
            }
        }

        struct EmptyEventArgs
        {
        }

        class EventBus
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.EventHook, System.Collections.Generic.HashSet<System.Delegate>> events;

            static /*0x14bd640*/ EventBus();
            static /*0x14bd700*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.EventHook, System.Collections.Generic.HashSet<System.Delegate>> get_testAccessEvents();
            static void Register<TArgs>(Unity.VisualScripting.EventHook hook, System.Action<TArgs> handler);
            static /*0x14bd4e0*/ void Unregister(Unity.VisualScripting.EventHook hook, System.Delegate handler);
            static /*0x2a5510*/ void Trigger<TArgs>(Unity.VisualScripting.EventHook hook, TArgs args);
            static /*0x2a5510*/ void Trigger<TArgs>(string name, UnityEngine.GameObject target, TArgs args);
            static /*0x14bd460*/ void Trigger(Unity.VisualScripting.EventHook hook);
            static /*0x14bd360*/ void Trigger(string name, UnityEngine.GameObject target);
        }

        struct EventHook
        {
            /*0x10*/ string name;
            /*0x18*/ object target;
            /*0x20*/ object tag;

            static /*0x14bdb80*/ bool op_Equality(Unity.VisualScripting.EventHook a, Unity.VisualScripting.EventHook b);
            static /*0x14bdc30*/ bool op_Inequality(Unity.VisualScripting.EventHook a, Unity.VisualScripting.EventHook b);
            static /*0x14bdc00*/ Unity.VisualScripting.EventHook op_Implicit(string name);
            /*0x14bd9d0*/ EventHook(string name, object target, object tag);
            /*0x14bd8a0*/ bool Equals(object obj);
            /*0x14bd820*/ bool Equals(Unity.VisualScripting.EventHook other);
            /*0x14bd980*/ int GetHashCode();
        }

        class EventHookComparer : System.Collections.Generic.IEqualityComparer<Unity.VisualScripting.EventHook>
        {
            /*0x32f970*/ EventHookComparer();
            /*0x14bd750*/ bool Equals(Unity.VisualScripting.EventHook x, Unity.VisualScripting.EventHook y);
            /*0x14bd7d0*/ int GetHashCode(Unity.VisualScripting.EventHook obj);
        }

        class EventHooks
        {
            static string Custom = "Custom";
            static string OnGUI = "OnGUI";
            static string OnApplicationFocus = "OnApplicationFocus";
            static string OnApplicationLostFocus = "OnApplicationLostFocus";
            static string OnApplicationPause = "OnApplicationPause";
            static string OnApplicationResume = "OnApplicationResume";
            static string OnApplicationQuit = "OnApplicationQuit";
            static string OnEnable = "OnEnable";
            static string Start = "Start";
            static string Update = "Update";
            static string FixedUpdate = "FixedUpdate";
            static string LateUpdate = "LateUpdate";
            static string OnDisable = "OnDisable";
            static string OnDestroy = "OnDestroy";
            static string AnimationEvent = "AnimationEvent";
            static string UnityEvent = "UnityEvent";
            static string OnDrawGizmos = "OnDrawGizmos";
            static string OnDrawGizmosSelected = "OnDrawGizmosSelected";
            static string OnPointerEnter = "OnPointerEnter";
            static string OnPointerExit = "OnPointerExit";
            static string OnPointerDown = "OnPointerDown";
            static string OnPointerUp = "OnPointerUp";
            static string OnPointerClick = "OnPointerClick";
            static string OnBeginDrag = "OnBeginDrag";
            static string OnDrag = "OnDrag";
            static string OnEndDrag = "OnEndDrag";
            static string OnDrop = "OnDrop";
            static string OnScroll = "OnScroll";
            static string OnSelect = "OnSelect";
            static string OnDeselect = "OnDeselect";
            static string OnSubmit = "OnSubmit";
            static string OnCancel = "OnCancel";
            static string OnMove = "OnMove";
            static string OnBecameInvisible = "OnBecameInvisible";
            static string OnBecameVisible = "OnBecameVisible";
            static string OnCollisionEnter = "OnCollisionEnter";
            static string OnCollisionExit = "OnCollisionExit";
            static string OnCollisionStay = "OnCollisionStay";
            static string OnCollisionEnter2D = "OnCollisionEnter2D";
            static string OnCollisionExit2D = "OnCollisionExit2D";
            static string OnCollisionStay2D = "OnCollisionStay2D";
            static string OnControllerColliderHit = "OnControllerColliderHit";
            static string OnJointBreak = "OnJointBreak";
            static string OnJointBreak2D = "OnJointBreak2D";
            static string OnMouseDown = "OnMouseDown";
            static string OnMouseDrag = "OnMouseDrag";
            static string OnMouseEnter = "OnMouseEnter";
            static string OnMouseExit = "OnMouseExit";
            static string OnMouseOver = "OnMouseOver";
            static string OnMouseUp = "OnMouseUp";
            static string OnMouseUpAsButton = "OnMouseUpAsButton";
            static string OnParticleCollision = "OnParticleCollision";
            static string OnTransformChildrenChanged = "OnTransformChildrenChanged";
            static string OnTransformParentChanged = "OnTransformParentChanged";
            static string OnTriggerEnter = "OnTriggerEnter";
            static string OnTriggerExit = "OnTriggerExit";
            static string OnTriggerStay = "OnTriggerStay";
            static string OnTriggerEnter2D = "OnTriggerEnter2D";
            static string OnTriggerExit2D = "OnTriggerExit2D";
            static string OnTriggerStay2D = "OnTriggerStay2D";
            static string OnAnimatorMove = "OnAnimatorMove";
            static string OnAnimatorIK = "OnAnimatorIK";
            static string OnButtonClick = "OnButtonClick";
            static string OnToggleValueChanged = "OnToggleValueChanged";
            static string OnSliderValueChanged = "OnSliderValueChanged";
            static string OnScrollbarValueChanged = "OnScrollbarValueChanged";
            static string OnDropdownValueChanged = "OnDropdownValueChanged";
            static string OnInputFieldValueChanged = "OnInputFieldValueChanged";
            static string OnInputFieldEndEdit = "OnInputFieldEndEdit";
            static string OnScrollRectValueChanged = "OnScrollRectValueChanged";
        }

        class EventMachine<TGraph, TMacro> : Unity.VisualScripting.Machine<TGraph, TMacro>, Unity.VisualScripting.IEventMachine, Unity.VisualScripting.IMachine, Unity.VisualScripting.IGraphRoot, Unity.VisualScripting.IGraphParent, Unity.VisualScripting.IGraphNester, Unity.VisualScripting.IAotStubbable
        {
            /*0x180fc0*/ EventMachine();
            /*0x17aec0*/ void TriggerEvent(string name);
            /*0x2a5510*/ void TriggerEvent<TArgs>(string name, TArgs args);
            /*0x17aec0*/ void TriggerUnregisteredEvent(string name);
            /*0x2a5510*/ void TriggerRegisteredEvent<TArgs>(Unity.VisualScripting.EventHook hook, TArgs args);
            /*0x2a5510*/ void TriggerUnregisteredEvent<TArgs>(Unity.VisualScripting.EventHook hook, TArgs args);
            /*0x180fc0*/ void Awake();
            /*0x180fc0*/ void OnEnable();
            /*0x180fc0*/ void Start();
            /*0x180fc0*/ void OnInstantiateWhileEnabled();
            /*0x180fc0*/ void Update();
            /*0x180fc0*/ void FixedUpdate();
            /*0x180fc0*/ void LateUpdate();
            /*0x180fc0*/ void OnUninstantiateWhileEnabled();
            /*0x180fc0*/ void OnDisable();
            /*0x180fc0*/ void OnDestroy();
            /*0x17aec0*/ void TriggerAnimationEvent(UnityEngine.AnimationEvent animationEvent);
            /*0x17aec0*/ void TriggerUnityEvent(string name);
            /*0x180fc0*/ void OnDrawGizmos();
            /*0x180fc0*/ void OnDrawGizmosSelected();

            class <>c__4`1<TGraph, TMacro, TArgs>
            {
                static /*0x0*/ Unity.VisualScripting.EventMachine.<>c__4<TGraph, TMacro, TArgs> <>9;
                static /*0x0*/ System.Func<Unity.VisualScripting.IGraphParentElement, bool> <>9__4_1;

                static /*0x180ff0*/ <>c__4`1();
                /*0x180fc0*/ <>c__4`1();
                /*0x17e620*/ bool <TriggerUnregisteredEvent>b__4_1(Unity.VisualScripting.IGraphParentElement parent);
            }

            class <>c__DisplayClass4_0`1<TGraph, TMacro, TArgs>
            {
                /*0x0*/ Unity.VisualScripting.EventHook hook;

                /*0x180fc0*/ <>c__DisplayClass4_0`1();
                bool <TriggerUnregisteredEvent>b__0(Unity.VisualScripting.EventHook _hook);
            }
        }

        class XEventGraph
        {
            static /*0x2a5510*/ void TriggerEventHandler<TArgs>(Unity.VisualScripting.GraphReference reference, System.Func<Unity.VisualScripting.EventHook, bool> predicate, TArgs args, System.Func<Unity.VisualScripting.IGraphParentElement, bool> recurse, bool force);
            static /*0x2a5510*/ void TriggerEventHandler<TArgs>(Unity.VisualScripting.GraphStack stack, System.Func<Unity.VisualScripting.EventHook, bool> predicate, TArgs args, System.Func<Unity.VisualScripting.IGraphParentElement, bool> recurse, bool force);
        }

        interface IEventMachine : Unity.VisualScripting.IMachine, Unity.VisualScripting.IGraphRoot, Unity.VisualScripting.IGraphParent, Unity.VisualScripting.IGraphNester, Unity.VisualScripting.IAotStubbable
        {
            /*0x17aec0*/ void TriggerAnimationEvent(UnityEngine.AnimationEvent animationEvent);
            /*0x17aec0*/ void TriggerUnityEvent(string name);
        }

        interface IGraphEventHandler<TArgs>
        {
            Unity.VisualScripting.EventHook GetHook(Unity.VisualScripting.GraphReference reference);
            /*0x2a5510*/ void Trigger(Unity.VisualScripting.GraphReference reference, TArgs args);
            /*0x17e620*/ bool IsListening(Unity.VisualScripting.GraphPointer pointer);
        }

        class DebugUtility
        {
            static /*0x14b9c90*/ string get_logPath();
            static /*0x14b9bf0*/ void LogToFile(string message);
        }

        class InvalidConversionException : System.InvalidCastException
        {
            /*0x14c9430*/ InvalidConversionException();
            /*0x14c9440*/ InvalidConversionException(string message);
            /*0x14c9450*/ InvalidConversionException(string message, System.Exception innerException);
        }

        class InvalidImplementationException : System.Exception
        {
            /*0x14c9460*/ InvalidImplementationException();
            /*0x14c94b0*/ InvalidImplementationException(string message);
        }

        class UnexpectedEnumValueException<T> : System.Exception
        {
            /*0x0*/ T <Value>k__BackingField;

            /*0x2a5510*/ UnexpectedEnumValueException(T value);
            /*0x2a5510*/ T get_Value();
            /*0x2a5510*/ void set_Value(T value);
        }

        class Graph : Unity.VisualScripting.IGraph, System.IDisposable, Unity.VisualScripting.IPrewarmable, Unity.VisualScripting.IAotStubbable, Unity.VisualScripting.ISerializationDepender, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x10*/ System.Collections.Generic.List<Unity.VisualScripting.IGraphElement> _elements;
            /*0x18*/ Unity.VisualScripting.MergedGraphElementCollection <elements>k__BackingField;
            /*0x20*/ string <title>k__BackingField;
            /*0x28*/ string <summary>k__BackingField;
            /*0x30*/ UnityEngine.Vector2 <pan>k__BackingField;
            /*0x38*/ float <zoom>k__BackingField;
            /*0x3c*/ bool prewarmed;

            /*0x14c86b0*/ Graph();
            /*0x14c8460*/ string ToString();
            /*0x1803b0*/ Unity.VisualScripting.IGraphData CreateData();
            /*0x14c7760*/ Unity.VisualScripting.IGraphDebugData CreateDebugData();
            /*0x14c7b10*/ void Instantiate(Unity.VisualScripting.GraphReference instance);
            /*0x14c84d0*/ void Uninstantiate(Unity.VisualScripting.GraphReference instance);
            /*0x32f410*/ Unity.VisualScripting.MergedGraphElementCollection get_elements();
            /*0x61a260*/ string get_title();
            /*0x7965a0*/ void set_title(string value);
            /*0x79a150*/ string get_summary();
            /*0x98b030*/ void set_summary(string value);
            /*0x14c88b0*/ UnityEngine.Vector2 get_pan();
            /*0x12a1090*/ void set_pan(UnityEngine.Vector2 value);
            /*0x136e840*/ float get_zoom();
            /*0x14c88d0*/ void set_zoom(float value);
            /*0x14c8790*/ System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency> get_deserializationDependencies();
            /*0x14c81f0*/ void OnBeforeSerialize();
            /*0x14c81a0*/ void OnAfterDeserialize();
            /*0x14c7cf0*/ void OnAfterDependenciesDeserialized();
            /*0x14c7980*/ System.Collections.Generic.IEnumerable<object> GetAotStubs(System.Collections.Generic.HashSet<object> visited);
            /*0x14c8270*/ void Prewarm();
            /*0x14c77c0*/ void Dispose();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.Graph.<> <>9;
                static /*0x8*/ System.Func<Unity.VisualScripting.IGraphElement, System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency>> <>9__27_0;
                static /*0x10*/ System.Comparison<Unity.VisualScripting.IGraphElement> <>9__30_0;

                static /*0x14d2fd0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x14d2740*/ System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency> <get_deserializationDependencies>b__27_0(Unity.VisualScripting.IGraphElement e);
                /*0x14d26a0*/ int <OnAfterDependenciesDeserialized>b__30_0(Unity.VisualScripting.IGraphElement a, Unity.VisualScripting.IGraphElement b);
            }

            class <>c__DisplayClass31_0
            {
                /*0x10*/ System.Collections.Generic.HashSet<object> visited;

                /*0x32f970*/ <>c__DisplayClass31_0();
                /*0x14d2c40*/ bool <GetAotStubs>b__0(Unity.VisualScripting.IGraphElement element);
                /*0x14d2ca0*/ Unity.VisualScripting.IGraphElement <GetAotStubs>b__1(Unity.VisualScripting.IGraphElement element);
                /*0x14d2d00*/ System.Collections.Generic.IEnumerable<object> <GetAotStubs>b__2(Unity.VisualScripting.IGraphElement element);
            }
        }

        class GraphData<TGraph> : Unity.VisualScripting.IGraphData
        {
            /*0x0*/ TGraph <definition>k__BackingField;
            /*0x0*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.IGraphElementWithData, Unity.VisualScripting.IGraphElementData> <elementsData>k__BackingField;
            /*0x0*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.IGraphParentElement, Unity.VisualScripting.IGraphData> <childrenGraphsData>k__BackingField;
            /*0x0*/ System.Collections.Generic.Dictionary<System.Guid, Unity.VisualScripting.IGraphElementData> <phantomElementsData>k__BackingField;
            /*0x0*/ System.Collections.Generic.Dictionary<System.Guid, Unity.VisualScripting.IGraphData> <phantomChildrenGraphsData>k__BackingField;

            /*0x2a5510*/ GraphData(TGraph definition);
            /*0x2a5510*/ TGraph get_definition();
            /*0x1803b0*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.IGraphElementWithData, Unity.VisualScripting.IGraphElementData> get_elementsData();
            /*0x1803b0*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.IGraphParentElement, Unity.VisualScripting.IGraphData> get_childrenGraphsData();
            /*0x1803b0*/ System.Collections.Generic.Dictionary<System.Guid, Unity.VisualScripting.IGraphElementData> get_phantomElementsData();
            /*0x1803b0*/ System.Collections.Generic.Dictionary<System.Guid, Unity.VisualScripting.IGraphData> get_phantomChildrenGraphsData();
            bool TryGetElementData(Unity.VisualScripting.IGraphElementWithData element, ref Unity.VisualScripting.IGraphElementData data);
            bool TryGetChildGraphData(Unity.VisualScripting.IGraphParentElement element, ref Unity.VisualScripting.IGraphData data);
            /*0x1858d0*/ Unity.VisualScripting.IGraphElementData CreateElementData(Unity.VisualScripting.IGraphElementWithData element);
            /*0x17aec0*/ void FreeElementData(Unity.VisualScripting.IGraphElementWithData element);
            /*0x1858d0*/ Unity.VisualScripting.IGraphData CreateChildGraphData(Unity.VisualScripting.IGraphParentElement element);
            /*0x17aec0*/ void FreeChildGraphData(Unity.VisualScripting.IGraphParentElement element);
        }

        class GraphDebugData : Unity.VisualScripting.IGraphDebugData
        {
            /*0x10*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.IGraphElementWithDebugData, Unity.VisualScripting.IGraphElementDebugData> <elementsData>k__BackingField;
            /*0x18*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.IGraphParentElement, Unity.VisualScripting.IGraphDebugData> <childrenGraphsData>k__BackingField;

            /*0x14bfd40*/ GraphDebugData(Unity.VisualScripting.IGraph definition);
            /*0x73d3e0*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.IGraphElementWithDebugData, Unity.VisualScripting.IGraphElementDebugData> get_elementsData();
            /*0x32f410*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.IGraphParentElement, Unity.VisualScripting.IGraphDebugData> get_childrenGraphsData();
            /*0x14bfcf0*/ System.Collections.Generic.IEnumerable<Unity.VisualScripting.IGraphElementDebugData> Unity.VisualScripting.IGraphDebugData.get_elementsData();
            /*0x14bfc30*/ Unity.VisualScripting.IGraphElementDebugData GetOrCreateElementData(Unity.VisualScripting.IGraphElementWithDebugData element);
            /*0x14bfb30*/ Unity.VisualScripting.IGraphDebugData GetOrCreateChildGraphData(Unity.VisualScripting.IGraphParentElement element);
        }

        class GraphElement<TGraph> : Unity.VisualScripting.IGraphElement, Unity.VisualScripting.IGraphItem, Unity.VisualScripting.INotifiedCollectionItem, System.IDisposable, Unity.VisualScripting.IPrewarmable, Unity.VisualScripting.IAotStubbable, Unity.VisualScripting.IIdentifiable, Unity.VisualScripting.IAnalyticsIdentifiable
        {
            /*0x0*/ System.Guid <guid>k__BackingField;
            /*0x0*/ TGraph <graph>k__BackingField;

            /*0x180fc0*/ GraphElement();
            /*0x180e40*/ System.Guid get_guid();
            void set_guid(System.Guid value);
            /*0x17aec0*/ void Instantiate(Unity.VisualScripting.GraphReference instance);
            /*0x17aec0*/ void Uninstantiate(Unity.VisualScripting.GraphReference instance);
            /*0x180fc0*/ void BeforeAdd();
            /*0x180fc0*/ void AfterAdd();
            /*0x180fc0*/ void BeforeRemove();
            /*0x180fc0*/ void AfterRemove();
            /*0x180fc0*/ void Dispose();
            /*0x180fc0*/ void InstantiateNest();
            /*0x180fc0*/ void UninstantiateNest();
            /*0x180980*/ int get_dependencyOrder();
            /*0x17cb40*/ bool HandleDependencies();
            /*0x2a5510*/ TGraph get_graph();
            /*0x2a5510*/ void set_graph(TGraph value);
            /*0x1803b0*/ Unity.VisualScripting.IGraph Unity.VisualScripting.IGraphElement.get_graph();
            /*0x17aec0*/ void Unity.VisualScripting.IGraphElement.set_graph(Unity.VisualScripting.IGraph value);
            /*0x1803b0*/ Unity.VisualScripting.IGraph Unity.VisualScripting.IGraphItem.get_graph();
            /*0x1803b0*/ System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency> get_deserializationDependencies();
            /*0x1858d0*/ System.Collections.Generic.IEnumerable<object> GetAotStubs(System.Collections.Generic.HashSet<object> visited);
            /*0x180fc0*/ void Prewarm();
            /*0x17aec0*/ void CopyFrom(Unity.VisualScripting.GraphElement<TGraph> source);
            /*0x1803b0*/ string ToString();
            /*0x1803b0*/ Unity.VisualScripting.AnalyticsIdentifier GetAnalyticsIdentifier();
        }

        class GraphElementCollection<TElement> : Unity.VisualScripting.GuidCollection<TElement>, Unity.VisualScripting.IGraphElementCollection<TElement>, Unity.VisualScripting.IKeyedCollection<System.Guid, TElement>, System.Collections.Generic.ICollection<TElement>, System.Collections.Generic.IEnumerable<TElement>, System.Collections.IEnumerable, Unity.VisualScripting.INotifyCollectionChanged<TElement>, Unity.VisualScripting.IProxyableNotifyCollectionChanged<TElement>
        {
            /*0x0*/ Unity.VisualScripting.IGraph <graph>k__BackingField;
            /*0x0*/ System.Action<TElement> ItemAdded;
            /*0x0*/ System.Action<TElement> ItemRemoved;
            /*0x0*/ System.Action CollectionChanged;
            /*0x0*/ bool <ProxyCollectionChange>k__BackingField;

            /*0x17aec0*/ GraphElementCollection(Unity.VisualScripting.IGraph graph);
            /*0x1803b0*/ Unity.VisualScripting.IGraph get_graph();
            /*0x17aec0*/ void add_ItemAdded(System.Action<TElement> value);
            /*0x17aec0*/ void remove_ItemAdded(System.Action<TElement> value);
            /*0x17aec0*/ void add_ItemRemoved(System.Action<TElement> value);
            /*0x17aec0*/ void remove_ItemRemoved(System.Action<TElement> value);
            /*0x17aec0*/ void add_CollectionChanged(System.Action value);
            /*0x17aec0*/ void remove_CollectionChanged(System.Action value);
            /*0x17cb40*/ bool get_ProxyCollectionChange();
            /*0x181190*/ void set_ProxyCollectionChange(bool value);
            /*0x2a5510*/ void BeforeAdd(TElement element);
            /*0x2a5510*/ void AfterAdd(TElement element);
            /*0x2a5510*/ void BeforeRemove(TElement element);
            /*0x2a5510*/ void AfterRemove(TElement element);
            /*0x2a5510*/ void InsertItem(int index, TElement element);
            /*0x17aa40*/ void RemoveItem(int index);
            /*0x180fc0*/ void ClearItems();
            /*0x2a5510*/ void SetItem(int index, TElement item);
            /*0x2a5510*/ Unity.VisualScripting.NoAllocEnumerator<TElement> GetEnumerator();
            /*0x2a5510*/ TElement Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.get_Item(System.Guid key);
            bool Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.Contains(System.Guid key);
            bool Unity.VisualScripting.IKeyedCollection<System.Guid,TElement>.Remove(System.Guid key);

            class <>c<TElement>
            {
                static /*0x0*/ Unity.VisualScripting.GraphElementCollection.<>c<TElement> <>9;
                static /*0x0*/ System.Comparison<TElement> <>9__23_0;

                static /*0x180ff0*/ <>c();
                /*0x180fc0*/ <>c();
                /*0x2a5510*/ int <ClearItems>b__23_0(TElement a, TElement b);
            }
        }

        class GraphInstances
        {
            static /*0x0*/ object lock;
            static /*0x8*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.IGraph, System.Collections.Generic.HashSet<Unity.VisualScripting.GraphReference>> byGraph;
            static /*0x10*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.IGraphParent, System.Collections.Generic.HashSet<Unity.VisualScripting.GraphReference>> byParent;

            static /*0x14c0fb0*/ GraphInstances();
            static /*0x14c0120*/ void Instantiate(Unity.VisualScripting.GraphReference instance);
            static /*0x14c09e0*/ void Uninstantiate(Unity.VisualScripting.GraphReference instance);
            static /*0x14c07c0*/ System.Collections.Generic.HashSet<Unity.VisualScripting.GraphReference> OfPooled(Unity.VisualScripting.IGraph graph);
            static /*0x14bff00*/ System.Collections.Generic.HashSet<Unity.VisualScripting.GraphReference> ChildrenOfPooled(Unity.VisualScripting.IGraphParent parent);
        }

        class GraphNest<TGraph, TMacro> : Unity.VisualScripting.IGraphNest, Unity.VisualScripting.IAotStubbable
        {
            /*0x0*/ Unity.VisualScripting.IGraphNester <nester>k__BackingField;
            /*0x0*/ Unity.VisualScripting.GraphSource _source;
            /*0x0*/ TMacro _macro;
            /*0x0*/ TGraph _embed;
            /*0x0*/ System.Action beforeGraphChange;
            /*0x0*/ System.Action afterGraphChange;

            /*0x180fc0*/ GraphNest();
            /*0x1803b0*/ Unity.VisualScripting.IGraphNester get_nester();
            /*0x17aec0*/ void set_nester(Unity.VisualScripting.IGraphNester value);
            /*0x180980*/ Unity.VisualScripting.GraphSource get_source();
            /*0x17aa40*/ void set_source(Unity.VisualScripting.GraphSource value);
            /*0x2a5510*/ TMacro get_macro();
            /*0x2a5510*/ void set_macro(TMacro value);
            /*0x2a5510*/ TGraph get_embed();
            /*0x2a5510*/ void set_embed(TGraph value);
            /*0x2a5510*/ TGraph get_graph();
            /*0x1803b0*/ Unity.VisualScripting.IMacro Unity.VisualScripting.IGraphNest.get_macro();
            /*0x17aec0*/ void Unity.VisualScripting.IGraphNest.set_macro(Unity.VisualScripting.IMacro value);
            /*0x1803b0*/ Unity.VisualScripting.IGraph Unity.VisualScripting.IGraphNest.get_embed();
            /*0x17aec0*/ void Unity.VisualScripting.IGraphNest.set_embed(Unity.VisualScripting.IGraph value);
            /*0x1803b0*/ Unity.VisualScripting.IGraph Unity.VisualScripting.IGraphNest.get_graph();
            /*0x1803b0*/ System.Type Unity.VisualScripting.IGraphNest.get_graphType();
            /*0x1803b0*/ System.Type Unity.VisualScripting.IGraphNest.get_macroType();
            /*0x2a5510*/ void SwitchToEmbed(TGraph embed);
            /*0x2a5510*/ void SwitchToMacro(TMacro macro);
            /*0x17aec0*/ void add_beforeGraphChange(System.Action value);
            /*0x17aec0*/ void remove_beforeGraphChange(System.Action value);
            /*0x17aec0*/ void add_afterGraphChange(System.Action value);
            /*0x17aec0*/ void remove_afterGraphChange(System.Action value);
            /*0x180fc0*/ void BeforeGraphChange();
            /*0x180fc0*/ void AfterGraphChange();
            /*0x1803b0*/ System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency> get_deserializationDependencies();
            /*0x1858d0*/ System.Collections.Generic.IEnumerable<object> GetAotStubs(System.Collections.Generic.HashSet<object> visited);
            /*0x17cb40*/ bool get_hasBackgroundEmbed();

            class <get_deserializationDependencies>d__41<TGraph, TMacro> : System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Unity.VisualScripting.ISerializationDependency>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ Unity.VisualScripting.ISerializationDependency <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ Unity.VisualScripting.GraphNest<TGraph, TMacro> <>4__this;

                /*0x17aa40*/ <get_deserializationDependencies>d__41(int <>1__state);
                /*0x180fc0*/ void System.IDisposable.Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x1803b0*/ Unity.VisualScripting.ISerializationDependency System.Collections.Generic.IEnumerator<Unity.VisualScripting.ISerializationDependency>.get_Current();
                /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                /*0x1803b0*/ System.Collections.Generic.IEnumerator<Unity.VisualScripting.ISerializationDependency> System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency>.GetEnumerator();
                /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class GraphPointer
        {
            static /*0x0*/ System.Func<Unity.VisualScripting.IGraphRoot, Unity.VisualScripting.IGraphDebugData> <fetchRootDebugDataBinding>k__BackingField;
            static /*0x8*/ System.Action<Unity.VisualScripting.IGraphRoot> releaseDebugDataBinding;
            /*0x10*/ Unity.VisualScripting.IGraphRoot <root>k__BackingField;
            /*0x18*/ UnityEngine.GameObject <gameObject>k__BackingField;
            /*0x20*/ System.Collections.Generic.List<Unity.VisualScripting.IGraphParent> parentStack;
            /*0x28*/ System.Collections.Generic.List<Unity.VisualScripting.IGraphParentElement> parentElementStack;
            /*0x30*/ System.Collections.Generic.List<Unity.VisualScripting.IGraph> graphStack;
            /*0x38*/ System.Collections.Generic.List<Unity.VisualScripting.IGraphData> dataStack;
            /*0x40*/ System.Collections.Generic.List<Unity.VisualScripting.IGraphDebugData> debugDataStack;

            static /*0x14c3680*/ bool IsValidRoot(Unity.VisualScripting.IGraphRoot root);
            static /*0x14c35d0*/ bool IsValidRoot(UnityEngine.Object rootObject);
            static /*0x14c4460*/ System.Func<Unity.VisualScripting.IGraphRoot, Unity.VisualScripting.IGraphDebugData> get_fetchRootDebugDataBinding();
            static /*0x14c51c0*/ void set_fetchRootDebugDataBinding(System.Func<Unity.VisualScripting.IGraphRoot, Unity.VisualScripting.IGraphDebugData> value);
            /*0x14c3ef0*/ GraphPointer();
            /*0x14c2c20*/ void Initialize(Unity.VisualScripting.IGraphRoot root);
            /*0x14c3130*/ void Initialize(Unity.VisualScripting.IGraphRoot root, System.Collections.Generic.IEnumerable<Unity.VisualScripting.IGraphParentElement> parentElements, bool ensureValid);
            /*0x14c2950*/ void Initialize(UnityEngine.Object rootObject, System.Collections.Generic.IEnumerable<System.Guid> parentElementGuids, bool ensureValid);
            /*0x1803b0*/ Unity.VisualScripting.GraphReference AsReference();
            /*0x14c13f0*/ void CopyFrom(Unity.VisualScripting.GraphPointer other);
            /*0x73d3e0*/ Unity.VisualScripting.IGraphRoot get_root();
            /*0x9f12f0*/ void set_root(Unity.VisualScripting.IGraphRoot value);
            /*0x14c4df0*/ UnityEngine.Object get_rootObject();
            /*0x14c4ac0*/ Unity.VisualScripting.IMachine get_machine();
            /*0x14c4b00*/ Unity.VisualScripting.IMacro get_macro();
            /*0x14c41a0*/ UnityEngine.MonoBehaviour get_component();
            /*0x32f410*/ UnityEngine.GameObject get_gameObject();
            /*0x7963c0*/ void set_gameObject(UnityEngine.GameObject value);
            /*0x32f410*/ UnityEngine.GameObject get_self();
            /*0x14c4f40*/ UnityEngine.ScriptableObject get_scriptableObject();
            /*0x14c4e70*/ System.Nullable<UnityEngine.SceneManagement.Scene> get_scene();
            /*0x14c4fc0*/ UnityEngine.Object get_serializedObject();
            /*0x14c4b40*/ System.Collections.Generic.IEnumerable<System.Guid> get_parentElementGuids();
            /*0x14c4420*/ int get_depth();
            /*0x14c4630*/ bool get_isRoot();
            /*0x14c45e0*/ bool get_isChild();
            /*0x14c2060*/ void EnsureDepthValid(int depth);
            /*0x14c1e40*/ void EnsureChild();
            /*0x17cb40*/ bool IsWithin<T>();
            /*0x180fc0*/ void EnsureWithin<T>();
            /*0x14c4d40*/ Unity.VisualScripting.IGraphParent get_parent();
            /*0x2a5510*/ T GetParent<T>();
            /*0x14c4c60*/ Unity.VisualScripting.IGraphParentElement get_parentElement();
            /*0x14c4da0*/ Unity.VisualScripting.IGraph get_rootGraph();
            /*0x14c44a0*/ Unity.VisualScripting.IGraph get_graph();
            /*0x14c4080*/ Unity.VisualScripting.IGraphData get__data();
            /*0x14c50e0*/ void set__data(Unity.VisualScripting.IGraphData value);
            /*0x14c4220*/ Unity.VisualScripting.IGraphData get_data();
            /*0x14c4140*/ Unity.VisualScripting.IGraphData get__parentData();
            /*0x14c4500*/ bool get_hasData();
            /*0x14c1ee0*/ void EnsureDataAvailable();
            /*0x2a5510*/ T GetGraphData<T>();
            /*0x2a5510*/ T GetElementData<T>(Unity.VisualScripting.IGraphElementWithData element);
            /*0x14c4570*/ bool get_hasDebugData();
            /*0x14c1fa0*/ void EnsureDebugDataAvailable();
            /*0x14c40e0*/ Unity.VisualScripting.IGraphDebugData get__debugData();
            /*0x14c5150*/ void set__debugData(Unity.VisualScripting.IGraphDebugData value);
            /*0x14c4320*/ Unity.VisualScripting.IGraphDebugData get_debugData();
            /*0x2a5510*/ T GetGraphDebugData<T>();
            /*0x2a5510*/ T GetElementDebugData<T>(Unity.VisualScripting.IGraphElementWithDebugData element);
            /*0x14c3d00*/ bool TryEnterParentElement(System.Guid parentElementGuid, ref string error, System.Nullable<int> maxRecursionDepth);
            /*0x14c38e0*/ bool TryEnterParentElement(Unity.VisualScripting.IGraphParentElement parentElement, ref string error, System.Nullable<int> maxRecursionDepth, bool skipContainsCheck);
            /*0x14c2250*/ void EnterParentElement(Unity.VisualScripting.IGraphParentElement parentElement);
            /*0x14c22e0*/ void EnterParentElement(System.Guid parentElementGuid);
            /*0x14c2370*/ void EnterValidParentElement(Unity.VisualScripting.IGraphParentElement parentElement);
            /*0x14c27a0*/ void ExitParentElement();
            /*0x14c4680*/ bool get_isValid();
            /*0x14c21e0*/ void EnsureValid();
            /*0x14c3360*/ bool InstanceEquals(Unity.VisualScripting.GraphPointer other);
            /*0x14c1cb0*/ bool DefinitionEquals(Unity.VisualScripting.GraphPointer other);
            /*0x14c11c0*/ int ComputeHashCode();
            /*0x14c3740*/ string ToString();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.GraphPointer.<> <>9;
                static /*0x8*/ System.Func<Unity.VisualScripting.IGraphParentElement, System.Guid> <>9__38_0;

                static /*0x14d2e80*/ <>c();
                /*0x32f970*/ <>c();
                /*0x14d28b0*/ System.Guid <get_parentElementGuids>b__38_0(Unity.VisualScripting.IGraphParentElement parentElement);
            }
        }

        class GraphPointerException : System.Exception
        {
            /*0x90*/ Unity.VisualScripting.GraphPointer <pointer>k__BackingField;

            /*0x14c10f0*/ GraphPointerException(string message, Unity.VisualScripting.GraphPointer pointer);
            /*0x7378b0*/ Unity.VisualScripting.GraphPointer get_pointer();
        }

        class GraphReference : Unity.VisualScripting.GraphPointer
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<Unity.VisualScripting.GraphReference>> internPool;
            /*0x48*/ int hashCode;

            static /*0x14c6cc0*/ GraphReference();
            static /*0x14c6710*/ Unity.VisualScripting.GraphReference New(Unity.VisualScripting.IGraphRoot root, bool ensureValid);
            static /*0x14c6500*/ Unity.VisualScripting.GraphReference New(Unity.VisualScripting.IGraphRoot root, System.Collections.Generic.IEnumerable<Unity.VisualScripting.IGraphParentElement> parentElements, bool ensureValid);
            static /*0x14c65d0*/ Unity.VisualScripting.GraphReference New(UnityEngine.Object rootObject, System.Collections.Generic.IEnumerable<System.Guid> parentElementGuids, bool ensureValid);
            static /*0x14c67b0*/ Unity.VisualScripting.GraphReference New(Unity.VisualScripting.GraphPointer model);
            static /*0xea41d0*/ bool op_Equality(Unity.VisualScripting.GraphReference x, Unity.VisualScripting.GraphReference y);
            static /*0x14c6da0*/ bool op_Inequality(Unity.VisualScripting.GraphReference x, Unity.VisualScripting.GraphReference y);
            static /*0x14c6210*/ Unity.VisualScripting.GraphReference Intern(Unity.VisualScripting.GraphPointer pointer);
            static /*0x14c5330*/ void ClearIntern(Unity.VisualScripting.GraphPointer pointer);
            static /*0x14c5b70*/ void FreeInvalidInterns();
            /*0x14c6d90*/ GraphReference();
            /*0x14c5530*/ void CopyFrom(Unity.VisualScripting.GraphPointer other);
            /*0x14c54e0*/ Unity.VisualScripting.GraphReference Clone();
            /*0x621ca0*/ Unity.VisualScripting.GraphReference AsReference();
            /*0x14c6cb0*/ Unity.VisualScripting.GraphStack ToStackPooled();
            /*0x14c6940*/ void Release();
            /*0x14c55b0*/ void CreateGraphData();
            /*0x14c58f0*/ void FreeGraphData();
            /*0x14c5880*/ bool Equals(object obj);
            /*0x14c61f0*/ void Hash();
            /*0x12f47d0*/ int GetHashCode();
            /*0x14c6830*/ Unity.VisualScripting.GraphReference ParentReference(bool ensureValid);
            /*0x14c5220*/ Unity.VisualScripting.GraphReference ChildReference(Unity.VisualScripting.IGraphParentElement parentElement, bool ensureValid, System.Nullable<int> maxRecursionDepth);
            /*0x14c69a0*/ Unity.VisualScripting.GraphReference Revalidate(bool ensureValid);
            /*0x14c6170*/ System.Collections.Generic.IEnumerable<Unity.VisualScripting.GraphReference> GetBreadcrumbs();

            class <GetBreadcrumbs>d__22 : System.Collections.Generic.IEnumerable<Unity.VisualScripting.GraphReference>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Unity.VisualScripting.GraphReference>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Unity.VisualScripting.GraphReference <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ Unity.VisualScripting.GraphReference <>4__this;
                /*0x30*/ int <depth>5__2;

                /*0x70aad0*/ <GetBreadcrumbs>d__22(int <>1__state);
                /*0x32d010*/ void System.IDisposable.Dispose();
                /*0x14d2220*/ bool MoveNext();
                /*0x32f410*/ Unity.VisualScripting.GraphReference System.Collections.Generic.IEnumerator<Unity.VisualScripting.GraphReference>.get_Current();
                /*0x14d2430*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
                /*0x14d2390*/ System.Collections.Generic.IEnumerator<Unity.VisualScripting.GraphReference> System.Collections.Generic.IEnumerable<Unity.VisualScripting.GraphReference>.GetEnumerator();
                /*0x14d2390*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class GraphsExceptionUtility
        {
            static string handledKey = "Bolt.Core.Handled";

            static /*0x14c88e0*/ System.Exception GetException(Unity.VisualScripting.IGraphElementWithDebugData element, Unity.VisualScripting.GraphPointer pointer);
            static /*0x14c8fb0*/ void SetException(Unity.VisualScripting.IGraphElementWithDebugData element, Unity.VisualScripting.GraphPointer pointer, System.Exception ex);
            static /*0x14c8a20*/ void HandleException(Unity.VisualScripting.IGraphElementWithDebugData element, Unity.VisualScripting.GraphPointer pointer, System.Exception ex);
            static /*0x14c8d00*/ bool HandledIn(System.Exception ex, Unity.VisualScripting.GraphReference reference);
        }

        enum GraphSource
        {
            Embed = 0,
            Macro = 1,
        }

        class GraphStack : Unity.VisualScripting.GraphPointer, Unity.VisualScripting.IPoolable, System.IDisposable
        {
            static /*0x14c72e0*/ Unity.VisualScripting.GraphStack New(Unity.VisualScripting.IGraphRoot root, System.Collections.Generic.List<Unity.VisualScripting.IGraphParentElement> parentElements);
            static /*0x14c7450*/ Unity.VisualScripting.GraphStack New(Unity.VisualScripting.GraphPointer model);
            /*0x14c6d90*/ GraphStack();
            /*0x14c70e0*/ void InitializeNoAlloc(Unity.VisualScripting.IGraphRoot root, System.Collections.Generic.List<Unity.VisualScripting.IGraphParentElement> parentElements, bool ensureValid);
            /*0x14c6cb0*/ Unity.VisualScripting.GraphStack Clone();
            /*0x14c7070*/ void Dispose();
            /*0x32d010*/ void Unity.VisualScripting.IPoolable.New();
            /*0x14c7610*/ void Unity.VisualScripting.IPoolable.Free();
            /*0x14c6e40*/ Unity.VisualScripting.GraphReference AsReference();
            /*0x14c6e40*/ Unity.VisualScripting.GraphReference ToReference();
            /*0x14c6e90*/ void ClearReference();
            /*0x14c2250*/ void EnterParentElement(Unity.VisualScripting.IGraphParentElement parentElement);
            /*0x14c75e0*/ bool TryEnterParentElement(Unity.VisualScripting.IGraphParentElement parentElement);
            /*0x14c75b0*/ bool TryEnterParentElementUnsafe(Unity.VisualScripting.IGraphParentElement parentElement);
            /*0x14c70d0*/ void ExitParentElement();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.GraphStack.<> <>9;
                static /*0x8*/ System.Func<Unity.VisualScripting.GraphStack> <>9__2_0;
                static /*0x10*/ System.Func<Unity.VisualScripting.GraphStack> <>9__3_0;

                static /*0x14d2f60*/ <>c();
                /*0x32f970*/ <>c();
                /*0x14d2600*/ Unity.VisualScripting.GraphStack <New>b__2_0();
                /*0x14d2650*/ Unity.VisualScripting.GraphStack <New>b__3_0();
            }
        }

        interface IGraph : System.IDisposable, Unity.VisualScripting.IPrewarmable, Unity.VisualScripting.IAotStubbable, Unity.VisualScripting.ISerializationDepender, UnityEngine.ISerializationCallbackReceiver
        {
            UnityEngine.Vector2 get_pan();
            /*0x17aca0*/ void set_pan(UnityEngine.Vector2 value);
            /*0x17fc30*/ float get_zoom();
            /*0x178d00*/ void set_zoom(float value);
            /*0x1803b0*/ Unity.VisualScripting.MergedGraphElementCollection get_elements();
            /*0x1803b0*/ string get_title();
            /*0x1803b0*/ string get_summary();
            /*0x1803b0*/ Unity.VisualScripting.IGraphData CreateData();
            /*0x1803b0*/ Unity.VisualScripting.IGraphDebugData CreateDebugData();
            /*0x17aec0*/ void Instantiate(Unity.VisualScripting.GraphReference instance);
            /*0x17aec0*/ void Uninstantiate(Unity.VisualScripting.GraphReference instance);
        }

        interface IGraphData
        {
            bool TryGetElementData(Unity.VisualScripting.IGraphElementWithData element, ref Unity.VisualScripting.IGraphElementData data);
            bool TryGetChildGraphData(Unity.VisualScripting.IGraphParentElement element, ref Unity.VisualScripting.IGraphData data);
            /*0x1858d0*/ Unity.VisualScripting.IGraphElementData CreateElementData(Unity.VisualScripting.IGraphElementWithData element);
            /*0x17aec0*/ void FreeElementData(Unity.VisualScripting.IGraphElementWithData element);
            /*0x1858d0*/ Unity.VisualScripting.IGraphData CreateChildGraphData(Unity.VisualScripting.IGraphParentElement element);
            /*0x17aec0*/ void FreeChildGraphData(Unity.VisualScripting.IGraphParentElement element);
        }

        interface IGraphDebugData
        {
            /*0x1858d0*/ Unity.VisualScripting.IGraphElementDebugData GetOrCreateElementData(Unity.VisualScripting.IGraphElementWithDebugData element);
            /*0x1858d0*/ Unity.VisualScripting.IGraphDebugData GetOrCreateChildGraphData(Unity.VisualScripting.IGraphParentElement element);
            /*0x1803b0*/ System.Collections.Generic.IEnumerable<Unity.VisualScripting.IGraphElementDebugData> get_elementsData();
        }

        interface IGraphElement : Unity.VisualScripting.IGraphItem, Unity.VisualScripting.INotifiedCollectionItem, System.IDisposable, Unity.VisualScripting.IPrewarmable, Unity.VisualScripting.IAotStubbable, Unity.VisualScripting.IIdentifiable, Unity.VisualScripting.IAnalyticsIdentifiable
        {
            /*0x1803b0*/ Unity.VisualScripting.IGraph get_graph();
            /*0x17aec0*/ void set_graph(Unity.VisualScripting.IGraph value);
            /*0x17cb40*/ bool HandleDependencies();
            /*0x180980*/ int get_dependencyOrder();
            /*0x180e40*/ System.Guid get_guid();
            void set_guid(System.Guid value);
            /*0x17aec0*/ void Instantiate(Unity.VisualScripting.GraphReference instance);
            /*0x17aec0*/ void Uninstantiate(Unity.VisualScripting.GraphReference instance);
            /*0x1803b0*/ System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency> get_deserializationDependencies();
        }

        interface IGraphElementCollection<T> : Unity.VisualScripting.IKeyedCollection<System.Guid, T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, Unity.VisualScripting.INotifyCollectionChanged<T>
        {
        }

        interface IGraphElementData
        {
        }

        interface IGraphElementDebugData
        {
            /*0x1803b0*/ System.Exception get_runtimeException();
            /*0x17aec0*/ void set_runtimeException(System.Exception value);
        }

        interface IGraphElementWithData : Unity.VisualScripting.IGraphElement, Unity.VisualScripting.IGraphItem, Unity.VisualScripting.INotifiedCollectionItem, System.IDisposable, Unity.VisualScripting.IPrewarmable, Unity.VisualScripting.IAotStubbable, Unity.VisualScripting.IIdentifiable, Unity.VisualScripting.IAnalyticsIdentifiable
        {
            /*0x1803b0*/ Unity.VisualScripting.IGraphElementData CreateData();
        }

        interface IGraphElementWithDebugData : Unity.VisualScripting.IGraphElement, Unity.VisualScripting.IGraphItem, Unity.VisualScripting.INotifiedCollectionItem, System.IDisposable, Unity.VisualScripting.IPrewarmable, Unity.VisualScripting.IAotStubbable, Unity.VisualScripting.IIdentifiable, Unity.VisualScripting.IAnalyticsIdentifiable
        {
            /*0x1803b0*/ Unity.VisualScripting.IGraphElementDebugData CreateDebugData();
        }

        interface IGraphItem
        {
            /*0x1803b0*/ Unity.VisualScripting.IGraph get_graph();
        }

        interface IGraphNest : Unity.VisualScripting.IAotStubbable
        {
            /*0x1803b0*/ Unity.VisualScripting.IGraphNester get_nester();
            /*0x17aec0*/ void set_nester(Unity.VisualScripting.IGraphNester value);
            /*0x180980*/ Unity.VisualScripting.GraphSource get_source();
            /*0x17aa40*/ void set_source(Unity.VisualScripting.GraphSource value);
            /*0x1803b0*/ Unity.VisualScripting.IGraph get_embed();
            /*0x17aec0*/ void set_embed(Unity.VisualScripting.IGraph value);
            /*0x1803b0*/ Unity.VisualScripting.IMacro get_macro();
            /*0x17aec0*/ void set_macro(Unity.VisualScripting.IMacro value);
            /*0x1803b0*/ Unity.VisualScripting.IGraph get_graph();
            /*0x1803b0*/ System.Type get_graphType();
            /*0x1803b0*/ System.Type get_macroType();
            /*0x17cb40*/ bool get_hasBackgroundEmbed();
        }

        interface IGraphNester : Unity.VisualScripting.IGraphParent
        {
            /*0x1803b0*/ Unity.VisualScripting.IGraphNest get_nest();
            /*0x180fc0*/ void InstantiateNest();
            /*0x180fc0*/ void UninstantiateNest();
        }

        interface IGraphNesterElement : Unity.VisualScripting.IGraphParentElement, Unity.VisualScripting.IGraphElement, Unity.VisualScripting.IGraphItem, Unity.VisualScripting.INotifiedCollectionItem, System.IDisposable, Unity.VisualScripting.IPrewarmable, Unity.VisualScripting.IAotStubbable, Unity.VisualScripting.IIdentifiable, Unity.VisualScripting.IAnalyticsIdentifiable, Unity.VisualScripting.IGraphParent, Unity.VisualScripting.IGraphNester
        {
        }

        interface IGraphParent
        {
            /*0x1803b0*/ Unity.VisualScripting.IGraph get_childGraph();
            /*0x17cb40*/ bool get_isSerializationRoot();
            /*0x1803b0*/ UnityEngine.Object get_serializedObject();
            /*0x1803b0*/ Unity.VisualScripting.IGraph DefaultGraph();
        }

        interface IGraphParentElement : Unity.VisualScripting.IGraphElement, Unity.VisualScripting.IGraphItem, Unity.VisualScripting.INotifiedCollectionItem, System.IDisposable, Unity.VisualScripting.IPrewarmable, Unity.VisualScripting.IAotStubbable, Unity.VisualScripting.IIdentifiable, Unity.VisualScripting.IAnalyticsIdentifiable, Unity.VisualScripting.IGraphParent
        {
        }

        interface IGraphRoot : Unity.VisualScripting.IGraphParent
        {
            /*0x1803b0*/ Unity.VisualScripting.GraphPointer GetReference();
        }

        class MergedGraphElementCollection : Unity.VisualScripting.MergedKeyedCollection<System.Guid, Unity.VisualScripting.IGraphElement>, Unity.VisualScripting.INotifyCollectionChanged<Unity.VisualScripting.IGraphElement>
        {
            /*0x20*/ System.Action<Unity.VisualScripting.IGraphElement> ItemAdded;
            /*0x28*/ System.Action<Unity.VisualScripting.IGraphElement> ItemRemoved;
            /*0x30*/ System.Action CollectionChanged;

            /*0x14cfcf0*/ MergedGraphElementCollection();
            /*0x14cfdd0*/ void add_ItemAdded(System.Action<Unity.VisualScripting.IGraphElement> value);
            /*0x14cffd0*/ void remove_ItemAdded(System.Action<Unity.VisualScripting.IGraphElement> value);
            /*0x14cfe80*/ void add_ItemRemoved(System.Action<Unity.VisualScripting.IGraphElement> value);
            /*0x14d0080*/ void remove_ItemRemoved(System.Action<Unity.VisualScripting.IGraphElement> value);
            /*0x14cfd30*/ void add_CollectionChanged(System.Action value);
            /*0x14cff30*/ void remove_CollectionChanged(System.Action value);
            /*0x17aec0*/ void Include<TSubItem>(Unity.VisualScripting.IKeyedCollection<System.Guid, TSubItem> collection);
            /*0x2a5510*/ void <Include>b__9_0<TSubItem>(TSubItem element);
            /*0x2a5510*/ void <Include>b__9_1<TSubItem>(TSubItem element);
            /*0x180fc0*/ void <Include>b__9_2<TSubItem>();
        }

        class GraphGroup : Unity.VisualScripting.GraphElement<Unity.VisualScripting.IGraph>
        {
            static /*0x0*/ UnityEngine.Color defaultColor;
            /*0x28*/ UnityEngine.Rect <position>k__BackingField;
            /*0x38*/ string <label>k__BackingField;
            /*0x40*/ string <comment>k__BackingField;
            /*0x48*/ UnityEngine.Color <color>k__BackingField;

            static /*0x14bfe00*/ GraphGroup();
            /*0x14bfe40*/ GraphGroup();
            /*0xa75be0*/ UnityEngine.Rect get_position();
            /*0xf2b440*/ void set_position(UnityEngine.Rect value);
            /*0x995140*/ string get_label();
            /*0xe5a080*/ void set_label(string value);
            /*0xb61870*/ string get_comment();
            /*0xcf6cd0*/ void set_comment(string value);
            /*0x14bfee0*/ UnityEngine.Color get_color();
            /*0x14bfef0*/ void set_color(UnityEngine.Color value);
        }

        enum MouseButton
        {
            Left = 0,
            Right = 1,
            Middle = 2,
        }

        enum PressState
        {
            Hold = 0,
            Down = 1,
            Up = 2,
        }

        class AnimatorMessageListener : UnityEngine.MonoBehaviour
        {
            /*0x31c640*/ AnimatorMessageListener();
            /*0x14b0980*/ void OnAnimatorMove();
            /*0x14b08f0*/ void OnAnimatorIK(int layerIndex);
        }

        class GlobalMessageListener : UnityEngine.MonoBehaviour, Unity.VisualScripting.ISingleton
        {
            static /*0x14bf940*/ void Require();
            /*0x31c640*/ GlobalMessageListener();
            /*0x14bf860*/ void OnGUI();
            /*0x14bf580*/ void OnApplicationFocus(bool focus);
            /*0x14bf680*/ void OnApplicationPause(bool paused);
            /*0x14bf780*/ void OnApplicationQuit();
        }

        interface IGraphEventListener
        {
            /*0x17aec0*/ void StartListening(Unity.VisualScripting.GraphStack stack);
            /*0x17aec0*/ void StopListening(Unity.VisualScripting.GraphStack stack);
            /*0x17e620*/ bool IsListening(Unity.VisualScripting.GraphPointer pointer);
        }

        class XGraphEventListener
        {
            static /*0x14d75e0*/ void StartListening(Unity.VisualScripting.IGraphEventListener listener, Unity.VisualScripting.GraphReference reference);
            static /*0x14d76c0*/ void StopListening(Unity.VisualScripting.IGraphEventListener listener, Unity.VisualScripting.GraphReference reference);
            static /*0x14d7320*/ bool IsHierarchyListening(Unity.VisualScripting.GraphReference reference);
        }

        interface IGraphEventListenerData : Unity.VisualScripting.IGraphData
        {
            /*0x17cb40*/ bool get_isListening();
        }

        class MessageListener : UnityEngine.MonoBehaviour
        {
            static /*0x0*/ System.Type[] _listenerTypes;

            static /*0x14d0430*/ System.Type[] get_listenerTypes();
            static /*0x14d0130*/ void AddTo(UnityEngine.GameObject gameObject);
            static /*0x14d03d0*/ void AddTo(System.Type messageListenerType, UnityEngine.GameObject gameObject);
            /*0x31c640*/ MessageListener();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.MessageListener.<> <>9;
                static /*0x8*/ System.Func<System.Type, bool> <>9__2_0;

                static /*0x14d3190*/ <>c();
                /*0x32f970*/ <>c();
                /*0x14d2790*/ bool <get_listenerTypes>b__2_0(System.Type t);
            }
        }

        class UnityOnBecameInvisibleMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnBecameInvisibleMessageListener();
            /*0x14d5140*/ void OnBecameInvisible();
        }

        class UnityOnBecameVisibleMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnBecameVisibleMessageListener();
            /*0x14d51b0*/ void OnBecameVisible();
        }

        class UnityOnCollisionEnter2DMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnCollisionEnter2DMessageListener();
            /*0x14d5460*/ void OnCollisionEnter2D(UnityEngine.Collision2D collision);
        }

        class UnityOnCollisionEnterMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnCollisionEnterMessageListener();
            /*0x14d54f0*/ void OnCollisionEnter(UnityEngine.Collision collision);
        }

        class UnityOnCollisionExit2DMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnCollisionExit2DMessageListener();
            /*0x14d5580*/ void OnCollisionExit2D(UnityEngine.Collision2D collision);
        }

        class UnityOnCollisionExitMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnCollisionExitMessageListener();
            /*0x14d5610*/ void OnCollisionExit(UnityEngine.Collision collision);
        }

        class UnityOnCollisionStay2DMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnCollisionStay2DMessageListener();
            /*0x14d56a0*/ void OnCollisionStay2D(UnityEngine.Collision2D collision);
        }

        class UnityOnCollisionStayMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnCollisionStayMessageListener();
            /*0x14d5730*/ void OnCollisionStay(UnityEngine.Collision collision);
        }

        class UnityOnControllerColliderHitMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnControllerColliderHitMessageListener();
            /*0x14d57c0*/ void OnControllerColliderHit(UnityEngine.ControllerColliderHit hit);
        }

        class UnityOnJointBreak2DMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnJointBreak2DMessageListener();
            /*0x14d5e80*/ void OnJointBreak2D(UnityEngine.Joint2D brokenJoint);
        }

        class UnityOnJointBreakMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnJointBreakMessageListener();
            /*0x14d5f10*/ void OnJointBreak(float breakForce);
        }

        class UnityOnMouseDownMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnMouseDownMessageListener();
            /*0x14d5fa0*/ void OnMouseDown();
        }

        class UnityOnMouseDragMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnMouseDragMessageListener();
            /*0x14d6010*/ void OnMouseDrag();
        }

        class UnityOnMouseEnterMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnMouseEnterMessageListener();
            /*0x14d6080*/ void OnMouseEnter();
        }

        class UnityOnMouseExitMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnMouseExitMessageListener();
            /*0x14d60f0*/ void OnMouseExit();
        }

        class UnityOnMouseOverMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnMouseOverMessageListener();
            /*0x14d6160*/ void OnMouseOver();
        }

        class UnityOnMouseUpAsButtonMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnMouseUpAsButtonMessageListener();
            /*0x14d61d0*/ void OnMouseUpAsButton();
        }

        class UnityOnMouseUpMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnMouseUpMessageListener();
            /*0x14d6240*/ void OnMouseUp();
        }

        class UnityOnParticleCollisionMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnParticleCollisionMessageListener();
            /*0x14d6340*/ void OnParticleCollision(UnityEngine.GameObject other);
        }

        class UnityOnTransformChildrenChangedMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnTransformChildrenChangedMessageListener();
            /*0x14d6d90*/ void OnTransformChildrenChanged();
        }

        class UnityOnTransformParentChangedMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnTransformParentChangedMessageListener();
            /*0x14d6e00*/ void OnTransformParentChanged();
        }

        class UnityOnTriggerEnter2DMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnTriggerEnter2DMessageListener();
            /*0x14d6e70*/ void OnTriggerEnter2D(UnityEngine.Collider2D other);
        }

        class UnityOnTriggerEnterMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnTriggerEnterMessageListener();
            /*0x14d6f00*/ void OnTriggerEnter(UnityEngine.Collider other);
        }

        class UnityOnTriggerExit2DMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnTriggerExit2DMessageListener();
            /*0x14d6f90*/ void OnTriggerExit2D(UnityEngine.Collider2D other);
        }

        class UnityOnTriggerExitMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnTriggerExitMessageListener();
            /*0x14d7020*/ void OnTriggerExit(UnityEngine.Collider other);
        }

        class UnityOnTriggerStay2DMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnTriggerStay2DMessageListener();
            /*0x14d70b0*/ void OnTriggerStay2D(UnityEngine.Collider2D other);
        }

        class UnityOnTriggerStayMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnTriggerStayMessageListener();
            /*0x14d7140*/ void OnTriggerStay(UnityEngine.Collider other);
        }

        class UnityOnButtonClickMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnButtonClickMessageListener();
            /*0x14d52b0*/ void Start();
            /*0x14d5360*/ void <Start>b__0_0();
        }

        class UnityOnDropdownValueChangedMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnDropdownValueChangedMessageListener();
            /*0x14d5a00*/ void Start();
            /*0x14d5ac0*/ void <Start>b__0_0(int value);
        }

        class UnityOnInputFieldEndEditMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnInputFieldEndEditMessageListener();
            /*0x14d5be0*/ void Start();
            /*0x14d5ca0*/ void <Start>b__0_0(string value);
        }

        class UnityOnInputFieldValueChangedMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnInputFieldValueChangedMessageListener();
            /*0x14d5d30*/ void Start();
            /*0x14d5df0*/ void <Start>b__0_0(string value);
        }

        class UnityOnScrollbarValueChangedMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnScrollbarValueChangedMessageListener();
            /*0x14d6880*/ void Start();
            /*0x14d6940*/ void <Start>b__0_0(float value);
        }

        class UnityOnScrollRectValueChangedMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnScrollRectValueChangedMessageListener();
            /*0x14d6730*/ void Start();
            /*0x14d67f0*/ void <Start>b__0_0(UnityEngine.Vector2 value);
        }

        class UnityOnSliderValueChangedMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnSliderValueChangedMessageListener();
            /*0x14d6a60*/ void Start();
            /*0x14d6b20*/ void <Start>b__0_0(float value);
        }

        class UnityOnToggleValueChangedMessageListener : Unity.VisualScripting.MessageListener
        {
            /*0x31c640*/ UnityOnToggleValueChangedMessageListener();
            /*0x14d6c40*/ void Start();
            /*0x14d6d00*/ void <Start>b__0_0(bool value);
        }

        class UnityOnBeginDragMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x31c640*/ UnityOnBeginDragMessageListener();
            /*0x14d5220*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        class UnityOnCancelMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.ICancelHandler, UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x31c640*/ UnityOnCancelMessageListener();
            /*0x14d53d0*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
        }

        class UnityOnDeselectMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x31c640*/ UnityOnDeselectMessageListener();
            /*0x14d5850*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
        }

        class UnityOnDragMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x31c640*/ UnityOnDragMessageListener();
            /*0x14d58e0*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        class UnityOnDropMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x31c640*/ UnityOnDropMessageListener();
            /*0x14d5970*/ void OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
        }

        class UnityOnEndDragMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x31c640*/ UnityOnEndDragMessageListener();
            /*0x14d5b50*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
        }

        class UnityOnMoveMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.IMoveHandler, UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x31c640*/ UnityOnMoveMessageListener();
            /*0x14d62b0*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
        }

        class UnityOnPointerClickMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x31c640*/ UnityOnPointerClickMessageListener();
            /*0x14d63d0*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
        }

        class UnityOnPointerDownMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x31c640*/ UnityOnPointerDownMessageListener();
            /*0x14d6460*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
        }

        class UnityOnPointerEnterMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x31c640*/ UnityOnPointerEnterMessageListener();
            /*0x14d64f0*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
        }

        class UnityOnPointerExitMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x31c640*/ UnityOnPointerExitMessageListener();
            /*0x14d6580*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
        }

        class UnityOnPointerUpMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x31c640*/ UnityOnPointerUpMessageListener();
            /*0x14d6610*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
        }

        class UnityOnScrollMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x31c640*/ UnityOnScrollMessageListener();
            /*0x14d66a0*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
        }

        class UnityOnSelectMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x31c640*/ UnityOnSelectMessageListener();
            /*0x14d69d0*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
        }

        class UnityOnSubmitMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.IEventSystemHandler
        {
            /*0x31c640*/ UnityOnSubmitMessageListener();
            /*0x14d6bb0*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
        }

        class UnityMessageListener : Unity.VisualScripting.MessageListener, UnityEngine.EventSystems.IPointerEnterHandler, UnityEngine.EventSystems.IEventSystemHandler, UnityEngine.EventSystems.IPointerExitHandler, UnityEngine.EventSystems.IPointerDownHandler, UnityEngine.EventSystems.IPointerUpHandler, UnityEngine.EventSystems.IPointerClickHandler, UnityEngine.EventSystems.IBeginDragHandler, UnityEngine.EventSystems.IDragHandler, UnityEngine.EventSystems.IEndDragHandler, UnityEngine.EventSystems.IDropHandler, UnityEngine.EventSystems.IScrollHandler, UnityEngine.EventSystems.ISelectHandler, UnityEngine.EventSystems.IDeselectHandler, UnityEngine.EventSystems.ISubmitHandler, UnityEngine.EventSystems.ICancelHandler, UnityEngine.EventSystems.IMoveHandler
        {
            /*0x31c640*/ UnityMessageListener();
            /*0x14d4cd0*/ void Start();
            /*0x14d3270*/ void AddGUIListeners();
            /*0x14d4530*/ void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x14d45c0*/ void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x14d44a0*/ void OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x14d4650*/ void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x14d4410*/ void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x14d3770*/ void OnBeginDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x14d3d10*/ void OnDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x14d3e30*/ void OnEndDrag(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x14d3da0*/ void OnDrop(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x14d46e0*/ void OnScroll(UnityEngine.EventSystems.PointerEventData eventData);
            /*0x14d4770*/ void OnSelect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x14d3c80*/ void OnDeselect(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x14d4800*/ void OnSubmit(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x14d3800*/ void OnCancel(UnityEngine.EventSystems.BaseEventData eventData);
            /*0x14d42f0*/ void OnMove(UnityEngine.EventSystems.AxisEventData eventData);
            /*0x14d3690*/ void OnBecameInvisible();
            /*0x14d3700*/ void OnBecameVisible();
            /*0x14d3920*/ void OnCollisionEnter(UnityEngine.Collision collision);
            /*0x14d3a40*/ void OnCollisionExit(UnityEngine.Collision collision);
            /*0x14d3b60*/ void OnCollisionStay(UnityEngine.Collision collision);
            /*0x14d3890*/ void OnCollisionEnter2D(UnityEngine.Collision2D collision);
            /*0x14d39b0*/ void OnCollisionExit2D(UnityEngine.Collision2D collision);
            /*0x14d3ad0*/ void OnCollisionStay2D(UnityEngine.Collision2D collision);
            /*0x14d3bf0*/ void OnControllerColliderHit(UnityEngine.ControllerColliderHit hit);
            /*0x14d3f50*/ void OnJointBreak(float breakForce);
            /*0x14d3ec0*/ void OnJointBreak2D(UnityEngine.Joint2D brokenJoint);
            /*0x14d3fe0*/ void OnMouseDown();
            /*0x14d4050*/ void OnMouseDrag();
            /*0x14d40c0*/ void OnMouseEnter();
            /*0x14d4130*/ void OnMouseExit();
            /*0x14d41a0*/ void OnMouseOver();
            /*0x14d4280*/ void OnMouseUp();
            /*0x14d4210*/ void OnMouseUpAsButton();
            /*0x14d4380*/ void OnParticleCollision(UnityEngine.GameObject other);
            /*0x14d4890*/ void OnTransformChildrenChanged();
            /*0x14d4900*/ void OnTransformParentChanged();
            /*0x14d4a00*/ void OnTriggerEnter(UnityEngine.Collider other);
            /*0x14d4b20*/ void OnTriggerExit(UnityEngine.Collider other);
            /*0x14d4c40*/ void OnTriggerStay(UnityEngine.Collider other);
            /*0x14d4970*/ void OnTriggerEnter2D(UnityEngine.Collider2D other);
            /*0x14d4a90*/ void OnTriggerExit2D(UnityEngine.Collider2D other);
            /*0x14d4bb0*/ void OnTriggerStay2D(UnityEngine.Collider2D other);
            /*0x14d4ce0*/ void <AddGUIListeners>b__1_0();
            /*0x14d4d50*/ void <AddGUIListeners>b__1_1(bool value);
            /*0x14d4de0*/ void <AddGUIListeners>b__1_2(float value);
            /*0x14d4e70*/ void <AddGUIListeners>b__1_3(float value);
            /*0x14d4f00*/ void <AddGUIListeners>b__1_4(int value);
            /*0x14d4f90*/ void <AddGUIListeners>b__1_5(string value);
            /*0x14d5020*/ void <AddGUIListeners>b__1_6(string value);
            /*0x14d50b0*/ void <AddGUIListeners>b__1_7(UnityEngine.Vector2 value);
        }

        interface IMachine : Unity.VisualScripting.IGraphRoot, Unity.VisualScripting.IGraphParent, Unity.VisualScripting.IGraphNester, Unity.VisualScripting.IAotStubbable
        {
            /*0x1803b0*/ Unity.VisualScripting.IGraphData get_graphData();
            /*0x17aec0*/ void set_graphData(Unity.VisualScripting.IGraphData value);
            /*0x1803b0*/ UnityEngine.GameObject get_threadSafeGameObject();
        }

        class Machine<TGraph, TMacro> : Unity.VisualScripting.LudiqBehaviour, Unity.VisualScripting.IMachine, Unity.VisualScripting.IGraphRoot, Unity.VisualScripting.IGraphParent, Unity.VisualScripting.IGraphNester, Unity.VisualScripting.IAotStubbable
        {
            /*0x0*/ Unity.VisualScripting.GraphNest<TGraph, TMacro> <nest>k__BackingField;
            /*0x0*/ bool _alive;
            /*0x0*/ bool _enabled;
            /*0x0*/ UnityEngine.GameObject threadSafeGameObject;
            /*0x0*/ bool isReferenceCached;
            /*0x0*/ Unity.VisualScripting.GraphReference _reference;
            /*0x0*/ Unity.VisualScripting.IGraphData <graphData>k__BackingField;

            /*0x180fc0*/ Machine();
            /*0x1803b0*/ Unity.VisualScripting.GraphNest<TGraph, TMacro> get_nest();
            /*0x17aec0*/ void set_nest(Unity.VisualScripting.GraphNest<TGraph, TMacro> value);
            /*0x1803b0*/ Unity.VisualScripting.IGraphNest Unity.VisualScripting.IGraphNester.get_nest();
            /*0x1803b0*/ UnityEngine.GameObject Unity.VisualScripting.IMachine.get_threadSafeGameObject();
            /*0x1803b0*/ Unity.VisualScripting.GraphReference get_reference();
            /*0x17cb40*/ bool get_hasGraph();
            /*0x2a5510*/ TGraph get_graph();
            /*0x1803b0*/ Unity.VisualScripting.IGraphData get_graphData();
            /*0x17aec0*/ void set_graphData(Unity.VisualScripting.IGraphData value);
            /*0x17cb40*/ bool Unity.VisualScripting.IGraphParent.get_isSerializationRoot();
            /*0x1803b0*/ UnityEngine.Object Unity.VisualScripting.IGraphParent.get_serializedObject();
            /*0x1803b0*/ Unity.VisualScripting.IGraph Unity.VisualScripting.IGraphParent.get_childGraph();
            /*0x1858d0*/ System.Collections.Generic.IEnumerable<object> GetAotStubs(System.Collections.Generic.HashSet<object> visited);
            /*0x17cb40*/ bool get_isDescriptionValid();
            /*0x181190*/ void set_isDescriptionValid(bool value);
            /*0x180fc0*/ void Awake();
            /*0x180fc0*/ void OnEnable();
            /*0x180fc0*/ void OnInstantiateWhileEnabled();
            /*0x180fc0*/ void OnUninstantiateWhileEnabled();
            /*0x180fc0*/ void OnDisable();
            /*0x180fc0*/ void OnDestroy();
            /*0x180fc0*/ void OnValidate();
            /*0x1803b0*/ Unity.VisualScripting.GraphPointer GetReference();
            /*0x180fc0*/ void CacheReference();
            /*0x180fc0*/ void ClearCachedReference();
            /*0x180fc0*/ void InstantiateNest();
            /*0x180fc0*/ void UninstantiateNest();
            /*0x17aec0*/ void TriggerAnimationEvent(UnityEngine.AnimationEvent animationEvent);
            /*0x17aec0*/ void TriggerUnityEvent(string name);
            /*0x2a5510*/ TGraph DefaultGraph();
            /*0x1803b0*/ Unity.VisualScripting.IGraph Unity.VisualScripting.IGraphParent.DefaultGraph();
        }

        interface IMacro : Unity.VisualScripting.IGraphRoot, Unity.VisualScripting.IGraphParent, Unity.VisualScripting.ISerializationDependency, UnityEngine.ISerializationCallbackReceiver, Unity.VisualScripting.IAotStubbable
        {
            /*0x1803b0*/ Unity.VisualScripting.IGraph get_graph();
            /*0x17aec0*/ void set_graph(Unity.VisualScripting.IGraph value);
        }

        class Macro<TGraph> : Unity.VisualScripting.MacroScriptableObject, Unity.VisualScripting.IMacro, Unity.VisualScripting.IGraphRoot, Unity.VisualScripting.IGraphParent, Unity.VisualScripting.ISerializationDependency, UnityEngine.ISerializationCallbackReceiver, Unity.VisualScripting.IAotStubbable
        {
            /*0x0*/ TGraph _graph;
            /*0x0*/ Unity.VisualScripting.GraphReference _reference;
            /*0x0*/ bool <Unity.VisualScripting.ISerializationDependency.IsDeserialized>k__BackingField;

            /*0x180fc0*/ Macro();
            /*0x2a5510*/ TGraph get_graph();
            /*0x2a5510*/ void set_graph(TGraph value);
            /*0x1803b0*/ Unity.VisualScripting.IGraph Unity.VisualScripting.IMacro.get_graph();
            /*0x17aec0*/ void Unity.VisualScripting.IMacro.set_graph(Unity.VisualScripting.IGraph value);
            /*0x1803b0*/ Unity.VisualScripting.IGraph Unity.VisualScripting.IGraphParent.get_childGraph();
            /*0x1858d0*/ System.Collections.Generic.IEnumerable<object> GetAotStubs(System.Collections.Generic.HashSet<object> visited);
            /*0x17cb40*/ bool Unity.VisualScripting.IGraphParent.get_isSerializationRoot();
            /*0x1803b0*/ UnityEngine.Object Unity.VisualScripting.IGraphParent.get_serializedObject();
            /*0x1803b0*/ Unity.VisualScripting.GraphReference get_reference();
            /*0x17cb40*/ bool get_isDescriptionValid();
            /*0x181190*/ void set_isDescriptionValid(bool value);
            /*0x180fc0*/ void OnBeforeDeserialize();
            /*0x180fc0*/ void OnAfterDeserialize();
            /*0x2a5510*/ TGraph DefaultGraph();
            /*0x1803b0*/ Unity.VisualScripting.IGraph Unity.VisualScripting.IGraphParent.DefaultGraph();
            /*0x180fc0*/ void OnEnable();
            /*0x180fc0*/ void OnDisable();
            /*0x1803b0*/ Unity.VisualScripting.GraphPointer GetReference();
            /*0x17cb40*/ bool Unity.VisualScripting.ISerializationDependency.get_IsDeserialized();
            /*0x181190*/ void Unity.VisualScripting.ISerializationDependency.set_IsDeserialized(bool value);
        }

        class AotIncompatibleAttribute : System.Attribute
        {
            /*0x534220*/ AotIncompatibleAttribute();
        }

        interface IAotStubbable
        {
            /*0x1858d0*/ System.Collections.Generic.IEnumerable<object> GetAotStubs(System.Collections.Generic.HashSet<object> visited);
        }

        class PlatformUtility
        {
            static /*0x0*/ bool supportsJit;

            static /*0x14d0660*/ PlatformUtility();
            static /*0x348b00*/ bool CheckJitSupport();
            static /*0x14d0620*/ bool IsEditor(UnityEngine.RuntimePlatform platform);
            static /*0x14d0640*/ bool IsStandalone(UnityEngine.RuntimePlatform platform);
        }

        class ArrayPool<T>
        {
            static /*0x0*/ object lock;
            static /*0x0*/ System.Collections.Generic.Dictionary<int, System.Collections.Generic.Stack<T[]>> free;
            static /*0x0*/ System.Collections.Generic.HashSet<T[]> busy;

            static /*0x180ff0*/ ArrayPool();
            static /*0x17e6a0*/ T[] New(int length);
            static /*0x177be0*/ void Free(T[] array);
        }

        class XArrayPool
        {
            static /*0x17e030*/ T[] ToArrayPooled<T>(System.Collections.Generic.IEnumerable<T> source);
            static /*0x177be0*/ void Free<T>(T[] array);
        }

        class DictionaryPool<TKey, TValue>
        {
            static /*0x0*/ object lock;
            static /*0x0*/ System.Collections.Generic.Stack<System.Collections.Generic.Dictionary<TKey, TValue>> free;
            static /*0x0*/ System.Collections.Generic.HashSet<System.Collections.Generic.Dictionary<TKey, TValue>> busy;

            static /*0x180ff0*/ DictionaryPool();
            static /*0x17e030*/ System.Collections.Generic.Dictionary<TKey, TValue> New(System.Collections.Generic.Dictionary<TKey, TValue> source);
            static /*0x177be0*/ void Free(System.Collections.Generic.Dictionary<TKey, TValue> dictionary);
        }

        class GenericPool<T>
        {
            static /*0x0*/ object lock;
            static /*0x0*/ System.Collections.Generic.Stack<T> free;
            static /*0x0*/ System.Collections.Generic.HashSet<T> busy;

            static /*0x180ff0*/ GenericPool();
            static /*0x2a5510*/ T New(System.Func<T> constructor);
            static /*0x2a5510*/ void Free(T item);
        }

        class HashSetPool<T>
        {
            static /*0x0*/ object lock;
            static /*0x0*/ System.Collections.Generic.Stack<System.Collections.Generic.HashSet<T>> free;
            static /*0x0*/ System.Collections.Generic.HashSet<System.Collections.Generic.HashSet<T>> busy;

            static /*0x180ff0*/ HashSetPool();
            static /*0x180cf0*/ System.Collections.Generic.HashSet<T> New();
            static /*0x177be0*/ void Free(System.Collections.Generic.HashSet<T> hashSet);
        }

        class XHashSetPool
        {
            static /*0x17e030*/ System.Collections.Generic.HashSet<T> ToHashSetPooled<T>(System.Collections.Generic.IEnumerable<T> source);
            static /*0x177be0*/ void Free<T>(System.Collections.Generic.HashSet<T> hashSet);
        }

        interface IPoolable
        {
            /*0x180fc0*/ void New();
            /*0x180fc0*/ void Free();
        }

        class ListPool<T>
        {
            static /*0x0*/ object lock;
            static /*0x0*/ System.Collections.Generic.Stack<System.Collections.Generic.List<T>> free;
            static /*0x0*/ System.Collections.Generic.HashSet<System.Collections.Generic.List<T>> busy;

            static /*0x180ff0*/ ListPool();
            static /*0x180cf0*/ System.Collections.Generic.List<T> New();
            static /*0x177be0*/ void Free(System.Collections.Generic.List<T> list);
        }

        class XListPool
        {
            static /*0x17e030*/ System.Collections.Generic.List<T> ToListPooled<T>(System.Collections.Generic.IEnumerable<T> source);
            static /*0x177be0*/ void Free<T>(System.Collections.Generic.List<T> list);
        }

        class ManualPool<T>
        {
            static /*0x0*/ object lock;
            static /*0x0*/ System.Collections.Generic.Stack<T> free;
            static /*0x0*/ System.Collections.Generic.HashSet<T> busy;

            static /*0x180ff0*/ ManualPool();
            static /*0x2a5510*/ T New(System.Func<T> constructor);
            static /*0x2a5510*/ void Free(T item);
        }

        class ProfiledSegment
        {
            /*0x10*/ string <name>k__BackingField;
            /*0x18*/ System.Diagnostics.Stopwatch <stopwatch>k__BackingField;
            /*0x20*/ long <calls>k__BackingField;
            /*0x28*/ Unity.VisualScripting.ProfiledSegment <parent>k__BackingField;
            /*0x30*/ Unity.VisualScripting.ProfiledSegmentCollection <children>k__BackingField;

            /*0x14d06e0*/ ProfiledSegment(Unity.VisualScripting.ProfiledSegment parent, string name);
            /*0x73d3e0*/ string get_name();
            /*0x9f12f0*/ void set_name(string value);
            /*0x32f410*/ System.Diagnostics.Stopwatch get_stopwatch();
            /*0x7963c0*/ void set_stopwatch(System.Diagnostics.Stopwatch value);
            /*0x61a260*/ long get_calls();
            /*0x10cb140*/ void set_calls(long value);
            /*0x79a150*/ Unity.VisualScripting.ProfiledSegment get_parent();
            /*0x98b030*/ void set_parent(Unity.VisualScripting.ProfiledSegment value);
            /*0x997630*/ Unity.VisualScripting.ProfiledSegmentCollection get_children();
            /*0x997640*/ void set_children(Unity.VisualScripting.ProfiledSegmentCollection value);
        }

        class ProfiledSegmentCollection : System.Collections.ObjectModel.KeyedCollection<string, Unity.VisualScripting.ProfiledSegment>
        {
            /*0x14d06a0*/ ProfiledSegmentCollection();
            /*0x10daaf0*/ string GetKeyForItem(Unity.VisualScripting.ProfiledSegment item);
        }

        struct ProfilingScope : System.IDisposable
        {
            /*0x32d010*/ ProfilingScope(string name);
            /*0x32d010*/ void Dispose();
        }

        class ProfilingUtility
        {
            static /*0x0*/ object lock;
            static /*0x8*/ Unity.VisualScripting.ProfiledSegment <rootSegment>k__BackingField;
            static /*0x10*/ Unity.VisualScripting.ProfiledSegment <currentSegment>k__BackingField;

            static /*0x14d0e80*/ ProfilingUtility();
            static /*0x14d1040*/ Unity.VisualScripting.ProfiledSegment get_rootSegment();
            static /*0x14d1100*/ void set_rootSegment(Unity.VisualScripting.ProfiledSegment value);
            static /*0x14d0ff0*/ Unity.VisualScripting.ProfiledSegment get_currentSegment();
            static /*0x14d1090*/ void set_currentSegment(Unity.VisualScripting.ProfiledSegment value);
            static /*0x14d0b90*/ void Clear();
            static /*0x348b00*/ Unity.VisualScripting.ProfilingScope SampleBlock(string name);
            static /*0x14d07d0*/ void BeginSample(string name);
            static /*0x14d0cd0*/ void EndSample();
        }

        enum ActionDirection
        {
            Any = 0,
            Get = 1,
            Set = 2,
        }

        class AttributeUtility
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<object, Unity.VisualScripting.AttributeUtility.AttributeCache> optimizedCaches;

            static /*0x14b3760*/ AttributeUtility();
            static /*0x14b25c0*/ Unity.VisualScripting.AttributeUtility.AttributeCache GetAttributeCache(System.Reflection.MemberInfo element);
            static /*0x14b2a20*/ Unity.VisualScripting.AttributeUtility.AttributeCache GetAttributeCache(System.Reflection.ParameterInfo element);
            static /*0x14b27f0*/ Unity.VisualScripting.AttributeUtility.AttributeCache GetAttributeCache(Unity.VisualScripting.IAttributeProvider element);
            static /*0x14b2230*/ void CacheAttributes(System.Reflection.MemberInfo element);
            static /*0x17e030*/ System.Collections.Generic.IEnumerable<T> GetAttributeOfEnumMember<T>(System.Enum enumVal);
            static /*0x14b3440*/ bool HasAttribute(System.Reflection.MemberInfo element, System.Type attributeType, bool inherit);
            static /*0x14b2c50*/ System.Attribute GetAttribute(System.Reflection.MemberInfo element, System.Type attributeType, bool inherit);
            static /*0x14b3100*/ System.Collections.Generic.IEnumerable<System.Attribute> GetAttributes(System.Reflection.MemberInfo element, System.Type attributeType, bool inherit);
            static /*0x17ec30*/ bool HasAttribute<TAttribute>(System.Reflection.MemberInfo element, bool inherit);
            static /*0x2a5510*/ TAttribute GetAttribute<TAttribute>(System.Reflection.MemberInfo element, bool inherit);
            static /*0x17ac50*/ System.Collections.Generic.IEnumerable<TAttribute> GetAttributes<TAttribute>(System.Reflection.MemberInfo element, bool inherit);
            static /*0x14b2280*/ void CacheAttributes(System.Reflection.ParameterInfo element);
            static /*0x14b35d0*/ bool HasAttribute(System.Reflection.ParameterInfo element, System.Type attributeType, bool inherit);
            static /*0x14b2de0*/ System.Attribute GetAttribute(System.Reflection.ParameterInfo element, System.Type attributeType, bool inherit);
            static /*0x14b3190*/ System.Collections.Generic.IEnumerable<System.Attribute> GetAttributes(System.Reflection.ParameterInfo element, System.Type attributeType, bool inherit);
            static /*0x17ec30*/ bool HasAttribute<TAttribute>(System.Reflection.ParameterInfo element, bool inherit);
            static /*0x2a5510*/ TAttribute GetAttribute<TAttribute>(System.Reflection.ParameterInfo element, bool inherit);
            static /*0x17ac50*/ System.Collections.Generic.IEnumerable<TAttribute> GetAttributes<TAttribute>(System.Reflection.ParameterInfo element, bool inherit);
            static /*0x14b21e0*/ void CacheAttributes(Unity.VisualScripting.IAttributeProvider element);
            static /*0x14b32b0*/ bool HasAttribute(Unity.VisualScripting.IAttributeProvider element, System.Type attributeType, bool inherit);
            static /*0x14b2f70*/ System.Attribute GetAttribute(Unity.VisualScripting.IAttributeProvider element, System.Type attributeType, bool inherit);
            static /*0x14b3220*/ System.Collections.Generic.IEnumerable<System.Attribute> GetAttributes(Unity.VisualScripting.IAttributeProvider element, System.Type attributeType, bool inherit);
            static /*0x17ec30*/ bool HasAttribute<TAttribute>(Unity.VisualScripting.IAttributeProvider element, bool inherit);
            static /*0x2a5510*/ TAttribute GetAttribute<TAttribute>(Unity.VisualScripting.IAttributeProvider element, bool inherit);
            static /*0x17ac50*/ System.Collections.Generic.IEnumerable<TAttribute> GetAttributes<TAttribute>(Unity.VisualScripting.IAttributeProvider element, bool inherit);
            static /*0x14b22d0*/ bool CheckCondition(System.Type type, object target, string conditionMemberName, bool fallback);
            static /*0x2a5510*/ bool CheckCondition<T>(T target, string conditionMemberName, bool fallback);

            class AttributeCache
            {
                /*0x10*/ System.Collections.Generic.List<System.Attribute> <inheritedAttributes>k__BackingField;
                /*0x18*/ System.Collections.Generic.List<System.Attribute> <definedAttributes>k__BackingField;

                /*0x14b1cc0*/ AttributeCache(System.Reflection.MemberInfo element);
                /*0x14b17a0*/ AttributeCache(System.Reflection.ParameterInfo element);
                /*0x14b13c0*/ AttributeCache(Unity.VisualScripting.IAttributeProvider element);
                /*0x73d3e0*/ System.Collections.Generic.List<System.Attribute> get_inheritedAttributes();
                /*0x32f410*/ System.Collections.Generic.List<System.Attribute> get_definedAttributes();
                /*0x14b0e20*/ void Cache(System.Attribute[] attributeObjects, System.Collections.Generic.List<System.Attribute> cache);
                /*0x14b1310*/ bool HasAttribute(System.Type attributeType, System.Collections.Generic.List<System.Attribute> cache);
                /*0x14b1060*/ System.Attribute GetAttribute(System.Type attributeType, System.Collections.Generic.List<System.Attribute> cache);
                /*0x14b1140*/ System.Collections.Generic.IEnumerable<System.Attribute> GetAttributes(System.Type attributeType, System.Collections.Generic.List<System.Attribute> cache);
                /*0x14b11d0*/ bool HasAttribute(System.Type attributeType, bool inherit);
                /*0x14b0f10*/ System.Attribute GetAttribute(System.Type attributeType, bool inherit);
                /*0x14b1120*/ System.Collections.Generic.IEnumerable<System.Attribute> GetAttributes(System.Type attributeType, bool inherit);
                /*0x179c60*/ bool HasAttribute<TAttribute>(bool inherit);
                /*0x2a5510*/ TAttribute GetAttribute<TAttribute>(bool inherit);
                System.Collections.Generic.IEnumerable<TAttribute> GetAttributes<TAttribute>(bool inherit);

                class <GetAttributes>d__12 : System.Collections.Generic.IEnumerable<System.Attribute>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Attribute>, System.Collections.IEnumerator, System.IDisposable
                {
                    /*0x10*/ int <>1__state;
                    /*0x18*/ System.Attribute <>2__current;
                    /*0x20*/ int <>l__initialThreadId;
                    /*0x28*/ System.Collections.Generic.List<System.Attribute> cache;
                    /*0x30*/ System.Collections.Generic.List<System.Attribute> <>3__cache;
                    /*0x38*/ System.Type attributeType;
                    /*0x40*/ System.Type <>3__attributeType;
                    /*0x48*/ int <i>5__2;

                    /*0x70aad0*/ <GetAttributes>d__12(int <>1__state);
                    /*0x32d010*/ void System.IDisposable.Dispose();
                    /*0x14d2050*/ bool MoveNext();
                    /*0x32f410*/ System.Attribute System.Collections.Generic.IEnumerator<System.Attribute>.get_Current();
                    /*0x14d21e0*/ void System.Collections.IEnumerator.Reset();
                    /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
                    /*0x14d2130*/ System.Collections.Generic.IEnumerator<System.Attribute> System.Collections.Generic.IEnumerable<System.Attribute>.GetEnumerator();
                    /*0x14d2130*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                }
            }
        }

        class ConversionUtility
        {
            static System.Reflection.BindingFlags UserDefinedBindingFlags = 24;
            static /*0x0*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.ConversionUtility.ConversionQuery, Unity.VisualScripting.ConversionUtility.ConversionType> conversionTypesCache;
            static /*0x8*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.ConversionUtility.ConversionQuery, System.Reflection.MethodInfo[]> userConversionMethodsCache;
            static /*0x10*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.HashSet<System.Type>> implicitNumericConversions;
            static /*0x18*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.HashSet<System.Type>> explicitNumericConversions;

            static /*0x14b81e0*/ ConversionUtility();
            static /*0x14b7b20*/ bool RespectsIdentity(System.Type source, System.Type destination);
            static /*0x1078bd0*/ bool IsUpcast(System.Type source, System.Type destination);
            static /*0x14b7a70*/ bool IsDowncast(System.Type source, System.Type destination);
            static /*0x14b66f0*/ bool ExpectsString(System.Type source, System.Type destination);
            static /*0x14b75b0*/ bool HasImplicitNumericConversion(System.Type source, System.Type destination);
            static /*0x14b74a0*/ bool HasExplicitNumericConversion(System.Type source, System.Type destination);
            static /*0x14b76c0*/ bool HasNumericConversion(System.Type source, System.Type destination);
            static /*0x14b6770*/ System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> FindUserDefinedConversionMethods(Unity.VisualScripting.ConversionUtility.ConversionQuery query);
            static /*0x14b6c90*/ System.Reflection.MethodInfo[] GetUserDefinedConversionMethods(System.Type source, System.Type destination);
            static /*0x14b6e50*/ Unity.VisualScripting.ConversionUtility.ConversionType GetUserDefinedConversionType(System.Type source, System.Type destination);
            static /*0x14b71f0*/ bool HasEnumerableToArrayConversion(System.Type source, System.Type destination);
            static /*0x14b7320*/ bool HasEnumerableToListConversion(System.Type source, System.Type destination);
            static /*0x14b7750*/ bool HasUnityHierarchyConversion(System.Type source, System.Type destination);
            static /*0x14b7aa0*/ bool IsValidConversion(Unity.VisualScripting.ConversionUtility.ConversionType conversionType, bool guaranteed);
            static /*0x14b56a0*/ bool CanConvert(object value, System.Type type, bool guaranteed);
            static /*0x14b5610*/ bool CanConvert(System.Type source, System.Type destination, bool guaranteed);
            static /*0x14b57d0*/ object Convert(object value, System.Type type);
            static /*0x2a5510*/ T Convert<T>(object value);
            static /*0x14b7b80*/ bool TryConvert(object value, System.Type type, ref object result, bool guaranteed);
            static /*0x2a5510*/ bool TryConvert<T>(object value, ref T result, bool guaranteed);
            static /*0x14b79b0*/ bool IsConvertibleTo(System.Type source, System.Type destination, bool guaranteed);
            static /*0x14b78f0*/ bool IsConvertibleTo(object source, System.Type type, bool guaranteed);
            static /*0x17ec30*/ bool IsConvertibleTo<T>(object source, bool guaranteed);
            static /*0x14b5730*/ object ConvertTo(object source, System.Type type);
            static /*0x2a5510*/ T ConvertTo<T>(object source);
            static /*0x14b6b30*/ Unity.VisualScripting.ConversionUtility.ConversionType GetRequiredConversion(System.Type source, System.Type destination);
            static /*0x14b5d60*/ Unity.VisualScripting.ConversionUtility.ConversionType DetermineConversionType(Unity.VisualScripting.ConversionUtility.ConversionQuery query);
            static /*0x14b6a60*/ Unity.VisualScripting.ConversionUtility.ConversionType GetRequiredConversion(object value, System.Type type);
            static /*0x14b7ac0*/ object NumericConversion(object value, System.Type type);
            static /*0x14b7f10*/ object UserDefinedConversion(Unity.VisualScripting.ConversionUtility.ConversionType conversion, object value, System.Type type);
            static /*0x14b6300*/ object EnumerableToArrayConversion(object value, System.Type arrayType);
            static /*0x14b6470*/ object EnumerableToListConversion(object value, System.Type listType);
            static /*0x14b7c60*/ object UnityHierarchyConversion(object value, System.Type type);
            static /*0x14b5840*/ object Convert(object value, System.Type type, Unity.VisualScripting.ConversionUtility.ConversionType conversionType);

            enum ConversionType
            {
                Impossible = 0,
                Identity = 1,
                Upcast = 2,
                Downcast = 3,
                NumericImplicit = 4,
                NumericExplicit = 5,
                UserDefinedImplicit = 6,
                UserDefinedExplicit = 7,
                UserDefinedThenNumericImplicit = 8,
                UserDefinedThenNumericExplicit = 9,
                UnityHierarchy = 10,
                EnumerableToArray = 11,
                EnumerableToList = 12,
                ToString = 13,
            }

            struct ConversionQuery : System.IEquatable<Unity.VisualScripting.ConversionUtility.ConversionQuery>
            {
                /*0x10*/ System.Type source;
                /*0x18*/ System.Type destination;

                /*0xa59de0*/ ConversionQuery(System.Type source, System.Type destination);
                /*0x14b5410*/ bool Equals(Unity.VisualScripting.ConversionUtility.ConversionQuery other);
                /*0x14b54c0*/ bool Equals(object obj);
                /*0x14b55d0*/ int GetHashCode();
            }

            struct ConversionQueryComparer : System.Collections.Generic.IEqualityComparer<Unity.VisualScripting.ConversionUtility.ConversionQuery>
            {
                /*0x14b5320*/ bool Equals(Unity.VisualScripting.ConversionUtility.ConversionQuery x, Unity.VisualScripting.ConversionUtility.ConversionQuery y);
                /*0x14b53d0*/ int GetHashCode(Unity.VisualScripting.ConversionUtility.ConversionQuery obj);
            }

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.ConversionUtility.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.MethodInfo, bool> <>9__11_0;
                static /*0x10*/ System.Func<System.Reflection.MethodInfo, bool> <>9__11_1;

                static /*0x14d3200*/ <>c();
                /*0x32f970*/ <>c();
                /*0x14d2470*/ bool <FindUserDefinedConversionMethods>b__11_0(System.Reflection.MethodInfo m);
                /*0x14d24c0*/ bool <FindUserDefinedConversionMethods>b__11_1(System.Reflection.MethodInfo m);
            }

            class <>c__DisplayClass11_0
            {
                /*0x10*/ System.Type source;

                /*0x32f970*/ <>c__DisplayClass11_0();
                /*0x14d2980*/ bool <FindUserDefinedConversionMethods>b__2(System.Reflection.MethodInfo m);
            }

            class <>c__DisplayClass13_0
            {
                /*0x10*/ System.Type destination;

                /*0x32f970*/ <>c__DisplayClass13_0();
                /*0x14d2a90*/ bool <GetUserDefinedConversionType>b__0(System.Reflection.MethodInfo m);
                /*0x14d2b20*/ bool <GetUserDefinedConversionType>b__1(System.Reflection.MethodInfo m);
                /*0x14d2bb0*/ bool <GetUserDefinedConversionType>b__2(System.Reflection.MethodInfo m);
            }
        }

        class GenericClosingException : System.Exception
        {
            /*0x14bf520*/ GenericClosingException(string message);
            /*0x14bf490*/ GenericClosingException(System.Type open, System.Type closed);
        }

        interface IAttributeProvider
        {
            System.Attribute[] GetCustomAttributes(bool inherit);
        }

        interface IPrewarmable
        {
            /*0x180fc0*/ void Prewarm();
        }

        struct LooseAssemblyName
        {
            /*0x10*/ string name;

            static /*0x14c9c70*/ bool op_Equality(Unity.VisualScripting.LooseAssemblyName a, Unity.VisualScripting.LooseAssemblyName b);
            static /*0x14c9e40*/ bool op_Inequality(Unity.VisualScripting.LooseAssemblyName a, Unity.VisualScripting.LooseAssemblyName b);
            static /*0x14c9dc0*/ Unity.VisualScripting.LooseAssemblyName op_Implicit(string name);
            static /*0x621ca0*/ string op_Implicit(Unity.VisualScripting.LooseAssemblyName name);
            static /*0x14c9d30*/ Unity.VisualScripting.LooseAssemblyName op_Explicit(System.Reflection.AssemblyName strongAssemblyName);
            /*0x14c9c00*/ LooseAssemblyName(string name);
            /*0x14c9b30*/ bool Equals(object obj);
            /*0x14c9bc0*/ int GetHashCode();
            /*0x6937d0*/ string ToString();
        }

        class Member : UnityEngine.ISerializationCallbackReceiver
        {
            static System.Reflection.MemberTypes SupportedMemberTypes = 29;
            static System.Reflection.BindingFlags SupportedBindingFlags = 124;
            static /*0x0*/ object[] EmptyObjects;
            /*0x10*/ string _name;
            /*0x18*/ System.Type[] _parameterTypes;
            /*0x20*/ System.Type _targetType;
            /*0x28*/ string _targetTypeName;
            /*0x30*/ Unity.VisualScripting.Member.Source _source;
            /*0x38*/ System.Reflection.FieldInfo _fieldInfo;
            /*0x40*/ System.Reflection.PropertyInfo _propertyInfo;
            /*0x48*/ System.Reflection.MethodInfo _methodInfo;
            /*0x50*/ System.Reflection.ConstructorInfo _constructorInfo;
            /*0x58*/ bool _isExtension;
            /*0x59*/ bool _isInvokedAsExtension;
            /*0x60*/ Unity.VisualScripting.IOptimizedAccessor fieldAccessor;
            /*0x68*/ Unity.VisualScripting.IOptimizedAccessor propertyAccessor;
            /*0x70*/ Unity.VisualScripting.IOptimizedInvoker methodInvoker;
            /*0x78*/ bool <isReflected>k__BackingField;

            static /*0x14cdcb0*/ Member();
            static /*0xea41d0*/ bool op_Equality(Unity.VisualScripting.Member a, Unity.VisualScripting.Member b);
            static /*0x14cfaf0*/ bool op_Inequality(Unity.VisualScripting.Member a, Unity.VisualScripting.Member b);
            /*0x32f970*/ Member();
            /*0x14cde90*/ Member(System.Type targetType, string name, System.Type[] parameterTypes);
            /*0x14cdd20*/ Member(System.Type targetType, System.Reflection.FieldInfo fieldInfo);
            /*0x14ce1a0*/ Member(System.Type targetType, System.Reflection.PropertyInfo propertyInfo);
            /*0x14ce5a0*/ Member(System.Type targetType, System.Reflection.MethodInfo methodInfo);
            /*0x14ce310*/ Member(System.Type targetType, System.Reflection.ConstructorInfo constructorInfo);
            /*0x61a260*/ System.Type get_targetType();
            /*0x14cfc00*/ void set_targetType(System.Type value);
            /*0x79a150*/ string get_targetTypeName();
            /*0x73d3e0*/ string get_name();
            /*0x14cfb90*/ void set_name(string value);
            /*0x13f1720*/ bool get_isReflected();
            /*0x13f17c0*/ void set_isReflected(bool value);
            /*0x14cf950*/ Unity.VisualScripting.Member.Source get_source();
            /*0xa79cd0*/ void set_source(Unity.VisualScripting.Member.Source value);
            /*0x14ceb00*/ System.Reflection.FieldInfo get_fieldInfo();
            /*0xe5a080*/ void set_fieldInfo(System.Reflection.FieldInfo value);
            /*0x14cf470*/ System.Reflection.PropertyInfo get_propertyInfo();
            /*0xcf6cd0*/ void set_propertyInfo(System.Reflection.PropertyInfo value);
            /*0x14cf400*/ System.Reflection.MethodInfo get_methodInfo();
            /*0x4e4360*/ void set_methodInfo(System.Reflection.MethodInfo value);
            /*0x14cea50*/ System.Reflection.ConstructorInfo get_constructorInfo();
            /*0x4e4370*/ void set_constructorInfo(System.Reflection.ConstructorInfo value);
            /*0x14cee20*/ bool get_isExtension();
            /*0x13db610*/ void set_isExtension(bool value);
            /*0x14cf010*/ bool get_isInvokedAsExtension();
            /*0x13db580*/ void set_isInvokedAsExtension(bool value);
            /*0x32f410*/ System.Type[] get_parameterTypes();
            /*0x14cfbe0*/ void set_parameterTypes(System.Type[] value);
            /*0x14cf3a0*/ System.Reflection.MethodBase get_methodBase();
            /*0x14ce870*/ System.Reflection.MemberInfo get__info();
            /*0x14ceb30*/ System.Reflection.MemberInfo get_info();
            /*0x14cf980*/ System.Type get_type();
            /*0x14ced80*/ bool get_isCoroutine();
            /*0x14cf2e0*/ bool get_isYieldInstruction();
            /*0x14cee80*/ bool get_isGettable();
            /*0x14cf2a0*/ bool get_isPubliclyGettable();
            /*0x14cf2d0*/ bool get_isSettable();
            /*0x14cf2c0*/ bool get_isPubliclySettable();
            /*0x14cef70*/ bool get_isInvocable();
            /*0x14cf2b0*/ bool get_isPubliclyInvocable();
            /*0x14cec30*/ bool get_isAccessor();
            /*0x14cee50*/ bool get_isField();
            /*0x14cf180*/ bool get_isProperty();
            /*0x14cf040*/ bool get_isMethod();
            /*0x14cecd0*/ bool get_isConstructor();
            /*0x14cf7c0*/ bool get_requiresTarget();
            /*0x14cf070*/ bool get_isOperator();
            /*0x14ced00*/ bool get_isConversion();
            /*0x14cf430*/ int get_order();
            /*0x14cea80*/ System.Type get_declaringType();
            /*0x14cef00*/ bool get_isInherited();
            /*0x14cf4a0*/ System.Type get_pseudoDeclaringType();
            /*0x14cf1b0*/ bool get_isPseudoInherited();
            /*0x14cee90*/ bool get_isIndexer();
            /*0x14cf0f0*/ bool get_isPredictable();
            /*0x14ce930*/ bool get_allowsNull();
            /*0x32d010*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x14cdbc0*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x14cb910*/ bool IsGettable(bool nonPublic);
            /*0x14cbc90*/ bool IsSettable(bool nonPublic);
            /*0x14cbb90*/ bool IsInvocable(bool nonPublic);
            /*0x14c9f00*/ void EnsureExplicitParameterTypes();
            /*0x14ccbc0*/ void Reflect();
            /*0x14cc3f0*/ void ReflectField(System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> candidates);
            /*0x14cc9e0*/ void ReflectProperty(System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> candidates);
            /*0x14cbf90*/ void ReflectConstructor(System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> candidates);
            /*0x14cc5d0*/ void ReflectMethod(System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo> candidates);
            /*0x14cbe50*/ void Prewarm();
            /*0x14ca390*/ void EnsureReflected();
            /*0x14ca250*/ void EnsureReady(object target);
            /*0x14ca730*/ object Get(object target);
            /*0x2a5510*/ T Get<T>(object target);
            /*0x14cd6a0*/ object Set(object target, object value);
            /*0x14c9f70*/ void EnsureInvocable(object target);
            /*0x14ca660*/ System.Collections.Generic.IEnumerable<System.Reflection.ParameterInfo> GetParameterInfos();
            /*0x14cb5d0*/ object Invoke(object target);
            /*0x14cafe0*/ object Invoke(object target, object arg0);
            /*0x14cb170*/ object Invoke(object target, object arg0, object arg1);
            /*0x14cb6f0*/ object Invoke(object target, object arg0, object arg1, object arg2);
            /*0x14cb330*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3);
            /*0x14ca970*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4);
            /*0x14cae50*/ object Invoke(object target, object[] arguments);
            /*0x2a5510*/ T Invoke<T>(object target);
            /*0x2a5510*/ T Invoke<T>(object target, object arg0);
            /*0x2a5510*/ T Invoke<T>(object target, object arg0, object arg1);
            /*0x2a5510*/ T Invoke<T>(object target, object arg0, object arg1, object arg2);
            /*0x2a5510*/ T Invoke<T>(object target, object arg0, object arg1, object arg2, object arg3);
            /*0x2a5510*/ T Invoke<T>(object target, object arg0, object arg1, object arg2, object arg3, object arg4);
            /*0x2a5510*/ T Invoke<T>(object target, object[] arguments);
            /*0x14ca3a0*/ bool Equals(object obj);
            /*0x14ca590*/ int GetHashCode();
            /*0x14cda90*/ string ToUniqueString();
            /*0x14cda10*/ string ToString();
            /*0x14cd8f0*/ Unity.VisualScripting.Member ToDeclarer();
            /*0x14cd980*/ Unity.VisualScripting.Member ToPseudoDeclarer();

            enum Source
            {
                Unknown = 0,
                Field = 1,
                Property = 2,
                Method = 3,
                Constructor = 4,
            }

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.Member.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__5_0;
                static /*0x10*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__6_0;
                static /*0x18*/ System.Func<System.Reflection.ConstructorInfo, bool> <>9__122_0;
                static /*0x20*/ System.Func<System.Type, string> <>9__122_1;
                static /*0x28*/ System.Func<System.Type, string> <>9__123_0;

                static /*0x14fcc10*/ <>c();
                /*0x32f970*/ <>c();
                /*0x14f5370*/ System.Type <.ctor>b__5_0(System.Reflection.ParameterInfo pi);
                /*0x14f5370*/ System.Type <.ctor>b__6_0(System.Reflection.ParameterInfo pi);
                /*0x14f53a0*/ bool <ReflectConstructor>b__122_0(System.Reflection.ConstructorInfo c);
                /*0x718ca0*/ string <ReflectConstructor>b__122_1(System.Type t);
                /*0x718ca0*/ string <ReflectMethod>b__123_0(System.Type t);
            }
        }

        class MemberFilter : System.Attribute, System.ICloneable
        {
            /*0x10*/ bool <Fields>k__BackingField;
            /*0x11*/ bool <Properties>k__BackingField;
            /*0x12*/ bool <Methods>k__BackingField;
            /*0x13*/ bool <Constructors>k__BackingField;
            /*0x14*/ bool <Gettable>k__BackingField;
            /*0x15*/ bool <Settable>k__BackingField;
            /*0x16*/ bool <Inherited>k__BackingField;
            /*0x17*/ bool <Targeted>k__BackingField;
            /*0x18*/ bool <NonTargeted>k__BackingField;
            /*0x19*/ bool <Public>k__BackingField;
            /*0x1a*/ bool <NonPublic>k__BackingField;
            /*0x1b*/ bool <ReadOnly>k__BackingField;
            /*0x1c*/ bool <WriteOnly>k__BackingField;
            /*0x1d*/ bool <Extensions>k__BackingField;
            /*0x1e*/ bool <Operators>k__BackingField;
            /*0x1f*/ bool <Conversions>k__BackingField;
            /*0x20*/ bool <Setters>k__BackingField;
            /*0x21*/ bool <Parameters>k__BackingField;
            /*0x22*/ bool <Obsolete>k__BackingField;
            /*0x23*/ bool <OpenConstructedGeneric>k__BackingField;
            /*0x24*/ bool <TypeInitializers>k__BackingField;
            /*0x25*/ bool <ClsNonCompliant>k__BackingField;

            static /*0x14efa40*/ Unity.VisualScripting.MemberFilter get_Any();
            /*0x14efa00*/ MemberFilter();
            /*0x793eb0*/ bool get_Fields();
            /*0x793ec0*/ void set_Fields(bool value);
            /*0xf26f80*/ bool get_Properties();
            /*0xf26f90*/ void set_Properties(bool value);
            /*0x1119db0*/ bool get_Methods();
            /*0x14efc00*/ void set_Methods(bool value);
            /*0x1119dc0*/ bool get_Constructors();
            /*0x14efbd0*/ void set_Constructors(bool value);
            /*0x8b9820*/ bool get_Gettable();
            /*0xe29380*/ void set_Gettable(bool value);
            /*0xe29370*/ bool get_Settable();
            /*0xe29390*/ void set_Settable(bool value);
            /*0x1119e40*/ bool get_Inherited();
            /*0x140b9d0*/ void set_Inherited(bool value);
            /*0x140b8d0*/ bool get_Targeted();
            /*0x140b9e0*/ void set_Targeted(bool value);
            /*0xdd36a0*/ bool get_NonTargeted();
            /*0xdd5230*/ void set_NonTargeted(bool value);
            /*0x10a65f0*/ bool get_Public();
            /*0x10a6600*/ void set_Public(bool value);
            /*0x140b6e0*/ bool get_NonPublic();
            /*0x140b9c0*/ void set_NonPublic(bool value);
            /*0x14efaf0*/ bool get_ReadOnly();
            /*0x14efc20*/ void set_ReadOnly(bool value);
            /*0x14efb00*/ bool get_WriteOnly();
            /*0x14efc30*/ void set_WriteOnly(bool value);
            /*0x14efad0*/ bool get_Extensions();
            /*0x14efbf0*/ void set_Extensions(bool value);
            /*0x14efae0*/ bool get_Operators();
            /*0x14efc10*/ void set_Operators(bool value);
            /*0x14efac0*/ bool get_Conversions();
            /*0x14efbe0*/ void set_Conversions(bool value);
            /*0x796120*/ bool get_Setters();
            /*0x7963b0*/ void set_Setters(bool value);
            /*0xff2e20*/ bool get_Parameters();
            /*0xff32d0*/ void set_Parameters(bool value);
            /*0x12a0b50*/ bool get_Obsolete();
            /*0x12a0b60*/ void set_Obsolete(bool value);
            /*0x12a0b70*/ bool get_OpenConstructedGeneric();
            /*0x12a0b80*/ void set_OpenConstructedGeneric(bool value);
            /*0xed9100*/ bool get_TypeInitializers();
            /*0x117be00*/ void set_TypeInitializers(bool value);
            /*0x14efab0*/ bool get_ClsNonCompliant();
            /*0x14efbc0*/ void set_ClsNonCompliant(bool value);
            /*0x14efb10*/ System.Reflection.BindingFlags get_validBindingFlags();
            /*0x14efb70*/ System.Reflection.MemberTypes get_validMemberTypes();
            /*0x14ee3e0*/ object System.ICloneable.Clone();
            /*0x14ee3e0*/ Unity.VisualScripting.MemberFilter Clone();
            /*0x14ee4f0*/ bool Equals(object obj);
            /*0x14ee650*/ int GetHashCode();
            /*0x14eef30*/ bool ValidateMember(System.Reflection.MemberInfo member, Unity.VisualScripting.TypeFilter typeFilter);
            /*0x14ee920*/ string ToString();
        }

        class MemberInfoComparer : System.Collections.Generic.EqualityComparer<System.Reflection.MemberInfo>
        {
            /*0x14efd30*/ MemberInfoComparer();
            /*0x14efc40*/ bool Equals(System.Reflection.MemberInfo x, System.Reflection.MemberInfo y);
            /*0x7190b0*/ int GetHashCode(System.Reflection.MemberInfo obj);
        }

        class MemberUtility
        {
            static /*0x0*/ System.Lazy<Unity.VisualScripting.ExtensionMethodCache> ExtensionMethodsCache;
            static /*0x8*/ System.Lazy<System.Collections.Generic.Dictionary<System.Type, System.Reflection.MethodInfo[]>> InheritedExtensionMethodsCache;
            static /*0x10*/ System.Lazy<System.Collections.Generic.HashSet<System.Reflection.MethodInfo>> GenericExtensionMethods;

            static /*0x14f3cc0*/ MemberUtility();
            static /*0x14f2460*/ bool IsOperator(System.Reflection.MethodInfo method);
            static /*0x14f2a40*/ bool IsUserDefinedConversion(System.Reflection.MethodInfo method);
            static /*0x14f2b00*/ System.Reflection.MethodInfo MakeGenericMethodVia(System.Reflection.MethodInfo openConstructedMethod, System.Type[] closedConstructedParameterTypes);
            static /*0x14f2300*/ bool IsGenericExtension(System.Reflection.MethodInfo methodInfo);
            static /*0x14f19b0*/ System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetInheritedExtensionMethods(System.Type thisArgumentType);
            static /*0x14f14b0*/ System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetExtensionMethods(System.Type thisArgumentType, bool inherited);
            static /*0x14f22a0*/ bool IsExtension(System.Reflection.MethodInfo methodInfo);
            static /*0x14f21c0*/ bool IsExtensionMethod(System.Reflection.MemberInfo memberInfo);
            static /*0xed4410*/ System.Delegate CreateDelegate(System.Reflection.MethodInfo methodInfo, System.Type delegateType);
            static /*0x14f2100*/ bool IsAccessor(System.Reflection.MemberInfo memberInfo);
            static /*0x14f0d20*/ System.Type GetAccessorType(System.Reflection.MemberInfo memberInfo);
            static /*0x14f2520*/ bool IsPubliclyGettable(System.Reflection.MemberInfo memberInfo);
            static /*0x14f0950*/ System.Type ExtendedDeclaringType(System.Reflection.MemberInfo memberInfo);
            static /*0x14f0a90*/ System.Type ExtendedDeclaringType(System.Reflection.MemberInfo memberInfo, bool invokeAsExtension);
            static /*0x14f2780*/ bool IsStatic(System.Reflection.PropertyInfo propertyInfo);
            static /*0x14f2800*/ bool IsStatic(System.Reflection.MemberInfo memberInfo);
            static /*0x14f1d00*/ System.Collections.Generic.IEnumerable<System.Reflection.ParameterInfo> GetParametersWithoutThis(System.Reflection.MethodBase methodBase);
            static /*0x14f23a0*/ bool IsInvokedAsExtension(System.Reflection.MethodBase methodBase, System.Type targetType);
            static /*0x14f1aa0*/ System.Collections.Generic.IEnumerable<System.Reflection.ParameterInfo> GetInvocationParameters(System.Reflection.MethodBase methodBase, bool invokeAsExtension);
            static /*0x14f1a30*/ System.Collections.Generic.IEnumerable<System.Reflection.ParameterInfo> GetInvocationParameters(System.Reflection.MethodBase methodBase, System.Type targetType);
            static /*0x14f3c40*/ System.Type UnderlyingParameterType(System.Reflection.ParameterInfo parameterInfo);
            static /*0x14f2010*/ bool HasDefaultValue(System.Reflection.ParameterInfo parameterInfo);
            static /*0x14efec0*/ object DefaultValue(System.Reflection.ParameterInfo parameterInfo);
            static /*0x14f31a0*/ object PseudoDefaultValue(System.Reflection.ParameterInfo parameterInfo);
            static /*0x14efd70*/ bool AllowsNull(System.Reflection.ParameterInfo parameterInfo);
            static /*0x14f2040*/ bool HasOutModifier(System.Reflection.ParameterInfo parameterInfo);
            static /*0x14efe80*/ bool CanWrite(System.Reflection.FieldInfo fieldInfo);
            static /*0x14f3ae0*/ Unity.VisualScripting.Member ToManipulator(System.Reflection.MemberInfo memberInfo);
            static /*0x14f3720*/ Unity.VisualScripting.Member ToManipulator(System.Reflection.MemberInfo memberInfo, System.Type targetType);
            static /*0x14f3bd0*/ Unity.VisualScripting.Member ToManipulator(System.Reflection.FieldInfo fieldInfo, System.Type targetType);
            static /*0x14f3a70*/ Unity.VisualScripting.Member ToManipulator(System.Reflection.PropertyInfo propertyInfo, System.Type targetType);
            static /*0x14f3b60*/ Unity.VisualScripting.Member ToManipulator(System.Reflection.MethodInfo methodInfo, System.Type targetType);
            static /*0x14f3a00*/ Unity.VisualScripting.Member ToManipulator(System.Reflection.ConstructorInfo constructorInfo, System.Type targetType);
            static /*0x14f0e50*/ System.Reflection.ConstructorInfo GetConstructorAccepting(System.Type type, System.Type[] paramTypes, bool nonPublic);
            static /*0x14f0f60*/ System.Reflection.ConstructorInfo GetConstructorAccepting(System.Type type, System.Type[] paramTypes);
            static /*0x14f1f00*/ System.Reflection.ConstructorInfo GetPublicConstructorAccepting(System.Type type, System.Type[] paramTypes);
            static /*0x14f0fc0*/ System.Reflection.ConstructorInfo GetDefaultConstructor(System.Type type);
            static /*0x14f1f60*/ System.Reflection.ConstructorInfo GetPublicDefaultConstructor(System.Type type);
            static /*0x14f1070*/ System.Reflection.MemberInfo[] GetExtendedMember(System.Type type, string name, System.Reflection.MemberTypes types, System.Reflection.BindingFlags flags);
            static /*0x14f1250*/ System.Reflection.MemberInfo[] GetExtendedMembers(System.Type type, System.Reflection.BindingFlags flags);
            static /*0x14f2f80*/ bool NameMatches(System.Reflection.MemberInfo member, string name);
            static /*0x14f2fc0*/ bool ParametersMatch(System.Reflection.MethodBase methodBase, System.Collections.Generic.IEnumerable<System.Type> parameterTypes, bool invokeAsExtension);
            static /*0x14f0c30*/ bool GenericArgumentsMatch(System.Reflection.MethodInfo method, System.Collections.Generic.IEnumerable<System.Type> genericArgumentTypes);
            static /*0x14f33e0*/ bool SignatureMatches(System.Reflection.FieldInfo field, string name);
            static /*0x14f3360*/ bool SignatureMatches(System.Reflection.PropertyInfo property, string name);
            static /*0x14f3560*/ bool SignatureMatches(System.Reflection.ConstructorInfo constructor, string name, System.Collections.Generic.IEnumerable<System.Type> parameterTypes);
            static /*0x14f3630*/ bool SignatureMatches(System.Reflection.MethodInfo method, string name, System.Collections.Generic.IEnumerable<System.Type> parameterTypes, bool invokeAsExtension);
            static /*0x14f3460*/ bool SignatureMatches(System.Reflection.MethodInfo method, string name, System.Collections.Generic.IEnumerable<System.Type> parameterTypes, System.Collections.Generic.IEnumerable<System.Type> genericArgumentTypes, bool invokeAsExtension);
            static /*0x14f1840*/ System.Reflection.FieldInfo GetFieldUnambiguous(System.Type type, string name, System.Reflection.BindingFlags flags);
            static /*0x14f1da0*/ System.Reflection.PropertyInfo GetPropertyUnambiguous(System.Type type, string name, System.Reflection.BindingFlags flags);
            static /*0x14f1ba0*/ System.Reflection.MethodInfo GetMethodUnambiguous(System.Type type, string name, System.Reflection.BindingFlags flags);
            static /*0x2a5510*/ TMemberInfo DisambiguateHierarchy<TMemberInfo>(System.Collections.Generic.IEnumerable<TMemberInfo> members, System.Type type);
            static /*0x14f0080*/ System.Reflection.FieldInfo Disambiguate(System.Collections.Generic.IEnumerable<System.Reflection.FieldInfo> fields, System.Type type);
            static /*0x14f0410*/ System.Reflection.PropertyInfo Disambiguate(System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> properties, System.Type type);
            static /*0x14f0520*/ System.Reflection.ConstructorInfo Disambiguate(System.Collections.Generic.IEnumerable<System.Reflection.ConstructorInfo> constructors, System.Type type, System.Collections.Generic.IEnumerable<System.Type> parameterTypes);
            static /*0x14f0730*/ System.Reflection.MethodInfo Disambiguate(System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> methods, System.Type type, System.Collections.Generic.IEnumerable<System.Type> parameterTypes);
            static /*0x14f0190*/ System.Reflection.MethodInfo Disambiguate(System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> methods, System.Type type, System.Collections.Generic.IEnumerable<System.Type> parameterTypes, System.Collections.Generic.IEnumerable<System.Type> genericArgumentTypes);

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.MemberUtility.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__6_0;
                static /*0x10*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__8_0;
                static /*0x18*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__45_0;

                static /*0x14fca50*/ <>c();
                /*0x32f970*/ <>c();
                /*0x14f53d0*/ Unity.VisualScripting.ExtensionMethodCache <.cctor>b__0_0();
                /*0x14f5420*/ System.Collections.Generic.Dictionary<System.Type, System.Reflection.MethodInfo[]> <.cctor>b__0_1();
                /*0x14f5480*/ System.Collections.Generic.HashSet<System.Reflection.MethodInfo> <.cctor>b__0_2();
                /*0x14f5370*/ System.Type <MakeGenericMethodVia>b__6_0(System.Reflection.ParameterInfo p);
                /*0x14f5370*/ System.Type <GetInheritedExtensionMethods>b__8_0(System.Reflection.ParameterInfo p);
                /*0x14f5370*/ System.Type <ParametersMatch>b__45_0(System.Reflection.ParameterInfo paramInfo);
            }

            class <>c__DisplayClass37_0
            {
                /*0x10*/ System.Type[] paramTypes;

                /*0x32f970*/ <>c__DisplayClass37_0();
                /*0x14fc4e0*/ bool <GetConstructorAccepting>b__0(System.Reflection.ConstructorInfo constructor);
            }

            class <>c__DisplayClass42_0
            {
                /*0x10*/ string name;

                /*0x32f970*/ <>c__DisplayClass42_0();
                /*0x14fc6a0*/ bool <GetExtendedMember>b__0(System.Reflection.MethodInfo extension);
            }

            class <>c__DisplayClass58_0
            {
                /*0x10*/ System.Collections.Generic.IEnumerable<System.Type> parameterTypes;

                /*0x32f970*/ <>c__DisplayClass58_0();
                /*0x14fc6f0*/ bool <Disambiguate>b__0(System.Reflection.ConstructorInfo m);
            }

            class <>c__DisplayClass59_0
            {
                /*0x10*/ System.Collections.Generic.IEnumerable<System.Type> parameterTypes;
                /*0x18*/ System.Type type;

                /*0x32f970*/ <>c__DisplayClass59_0();
                /*0x14fc790*/ bool <Disambiguate>b__0(System.Reflection.MethodInfo m);
            }

            class <>c__DisplayClass60_0
            {
                /*0x10*/ System.Collections.Generic.IEnumerable<System.Type> parameterTypes;
                /*0x18*/ System.Type type;
                /*0x20*/ System.Collections.Generic.IEnumerable<System.Type> genericArgumentTypes;

                /*0x32f970*/ <>c__DisplayClass60_0();
                /*0x14fc850*/ bool <Disambiguate>b__0(System.Reflection.MethodInfo m);
            }

            class <>c__DisplayClass6_0
            {
                /*0x10*/ System.Collections.Generic.Dictionary<System.Type, System.Type> resolvedGenericParameters;

                /*0x32f970*/ <>c__DisplayClass6_0();
                /*0x14fc910*/ System.Type <MakeGenericMethodVia>b__1(System.Type openConstructedGenericArgument);
            }

            class <>c__DisplayClass9_0
            {
                /*0x10*/ System.Type thisArgumentType;

                /*0x32f970*/ <>c__DisplayClass9_0();
                /*0x14fc9a0*/ bool <GetExtensionMethods>b__0(System.Reflection.MethodInfo method);
            }

            class <GetInheritedExtensionMethods>d__8 : System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.MethodInfo>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Reflection.MethodInfo <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Type thisArgumentType;
                /*0x30*/ System.Type <>3__thisArgumentType;
                /*0x38*/ System.Reflection.MethodInfo[] <>7__wrap1;
                /*0x40*/ int <>7__wrap2;

                /*0x70aad0*/ <GetInheritedExtensionMethods>d__8(int <>1__state);
                /*0x32d010*/ void System.IDisposable.Dispose();
                /*0x14f4e90*/ bool MoveNext();
                /*0x32f410*/ System.Reflection.MethodInfo System.Collections.Generic.IEnumerator<System.Reflection.MethodInfo>.get_Current();
                /*0x14f5330*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
                /*0x14f5290*/ System.Collections.Generic.IEnumerator<System.Reflection.MethodInfo> System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>.GetEnumerator();
                /*0x14f5290*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class ExtensionMethodCache
        {
            /*0x10*/ System.Reflection.MethodInfo[] Cache;

            /*0x14ee060*/ ExtensionMethodCache();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.ExtensionMethodCache.<> <>9;
                static /*0x8*/ System.Func<System.Type, bool> <>9__0_0;
                static /*0x10*/ System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> <>9__0_1;
                static /*0x18*/ System.Func<System.Reflection.MethodInfo, bool> <>9__0_2;

                static /*0x14fcb30*/ <>c();
                /*0x32f970*/ <>c();
                /*0x14f55d0*/ bool <.ctor>b__0_0(System.Type type);
                /*0x14f6a20*/ System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> <.ctor>b__0_1(System.Type type);
                /*0x14f75e0*/ bool <.ctor>b__0_2(System.Reflection.MethodInfo method);
            }
        }

        class Namespace
        {
            static /*0x0*/ Unity.VisualScripting.Namespace.Collection collection;
            static /*0x8*/ Unity.VisualScripting.Namespace <Global>k__BackingField;
            /*0x10*/ Unity.VisualScripting.Namespace <Root>k__BackingField;
            /*0x18*/ Unity.VisualScripting.Namespace <Parent>k__BackingField;
            /*0x20*/ string <FullName>k__BackingField;
            /*0x28*/ string <Name>k__BackingField;
            /*0x30*/ bool <IsRoot>k__BackingField;
            /*0x31*/ bool <IsGlobal>k__BackingField;

            static /*0x14f42a0*/ Namespace();
            static /*0x14f4670*/ Unity.VisualScripting.Namespace get_Global();
            static /*0x14f4050*/ Unity.VisualScripting.Namespace FromFullName(string fullName);
            static /*0x14f46d0*/ Unity.VisualScripting.Namespace op_Implicit(string fullName);
            static /*0x14f4720*/ string op_Implicit(Unity.VisualScripting.Namespace namespace);
            static /*0xea41d0*/ bool op_Equality(Unity.VisualScripting.Namespace a, Unity.VisualScripting.Namespace b);
            static /*0x14f4740*/ bool op_Inequality(Unity.VisualScripting.Namespace a, Unity.VisualScripting.Namespace b);
            /*0x14f43c0*/ Namespace(string fullName);
            /*0x73d3e0*/ Unity.VisualScripting.Namespace get_Root();
            /*0x32f410*/ Unity.VisualScripting.Namespace get_Parent();
            /*0x61a260*/ string get_FullName();
            /*0x79a150*/ string get_Name();
            /*0x995050*/ bool get_IsRoot();
            /*0x14f46c0*/ bool get_IsGlobal();
            /*0x14f45f0*/ System.Collections.Generic.IEnumerable<Unity.VisualScripting.Namespace> get_Ancestors();
            /*0x14f3f40*/ System.Collections.Generic.IEnumerable<Unity.VisualScripting.Namespace> AndAncestors();
            /*0x14f4270*/ int GetHashCode();
            /*0x61a260*/ string ToString();
            /*0x14f3fc0*/ bool Equals(object obj);

            class Collection : System.Collections.ObjectModel.KeyedCollection<string, Unity.VisualScripting.Namespace>, Unity.VisualScripting.IKeyedCollection<string, Unity.VisualScripting.Namespace>, System.Collections.Generic.ICollection<Unity.VisualScripting.Namespace>, System.Collections.Generic.IEnumerable<Unity.VisualScripting.Namespace>, System.Collections.IEnumerable
            {
                /*0x14e19e0*/ Collection();
                /*0x1061c30*/ string GetKeyForItem(Unity.VisualScripting.Namespace item);
                /*0x14e17f0*/ bool TryGetValue(string key, ref Unity.VisualScripting.Namespace value);
                /*0x14e1990*/ Unity.VisualScripting.Namespace Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.Namespace>.get_Item(string key);
                /*0x14e18f0*/ bool Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.Namespace>.Contains(string key);
                /*0x14e1940*/ bool Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.Namespace>.Remove(string key);
            }

            class <AndAncestors>d__21 : System.Collections.Generic.IEnumerable<Unity.VisualScripting.Namespace>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Unity.VisualScripting.Namespace>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Unity.VisualScripting.Namespace <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ Unity.VisualScripting.Namespace <>4__this;
                /*0x30*/ System.Collections.Generic.IEnumerator<Unity.VisualScripting.Namespace> <>7__wrap1;

                /*0x70aad0*/ <AndAncestors>d__21(int <>1__state);
                /*0x14f4db0*/ void System.IDisposable.Dispose();
                /*0x14f49e0*/ bool MoveNext();
                /*0x14f4e40*/ void <>m__Finally1();
                /*0x32f410*/ Unity.VisualScripting.Namespace System.Collections.Generic.IEnumerator<Unity.VisualScripting.Namespace>.get_Current();
                /*0x14f4d70*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
                /*0x14f4cd0*/ System.Collections.Generic.IEnumerator<Unity.VisualScripting.Namespace> System.Collections.Generic.IEnumerable<Unity.VisualScripting.Namespace>.GetEnumerator();
                /*0x14f4cd0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <get_Ancestors>d__20 : System.Collections.Generic.IEnumerable<Unity.VisualScripting.Namespace>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<Unity.VisualScripting.Namespace>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ Unity.VisualScripting.Namespace <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ Unity.VisualScripting.Namespace <>4__this;
                /*0x30*/ Unity.VisualScripting.Namespace <ancestor>5__2;

                /*0x70aad0*/ <get_Ancestors>d__20(int <>1__state);
                /*0x32d010*/ void System.IDisposable.Dispose();
                /*0x14fcd60*/ bool MoveNext();
                /*0x32f410*/ Unity.VisualScripting.Namespace System.Collections.Generic.IEnumerator<Unity.VisualScripting.Namespace>.get_Current();
                /*0x14fcef0*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
                /*0x14fce50*/ System.Collections.Generic.IEnumerator<Unity.VisualScripting.Namespace> System.Collections.Generic.IEnumerable<Unity.VisualScripting.Namespace>.GetEnumerator();
                /*0x14fce50*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class AdditionHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x14d7a00*/ AdditionHandler();
            /*0x14d7970*/ object CustomHandling(object leftOperand, object rightOperand);

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.AdditionHandler.<> <>9;
                static /*0x8*/ System.Func<byte, byte, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, short, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, int, object> <>9__0_4;
                static /*0x30*/ System.Func<byte, uint, object> <>9__0_5;
                static /*0x38*/ System.Func<byte, long, object> <>9__0_6;
                static /*0x40*/ System.Func<byte, ulong, object> <>9__0_7;
                static /*0x48*/ System.Func<byte, float, object> <>9__0_8;
                static /*0x50*/ System.Func<byte, decimal, object> <>9__0_9;
                static /*0x58*/ System.Func<byte, double, object> <>9__0_10;
                static /*0x60*/ System.Func<sbyte, byte, object> <>9__0_11;
                static /*0x68*/ System.Func<sbyte, sbyte, object> <>9__0_12;
                static /*0x70*/ System.Func<sbyte, short, object> <>9__0_13;
                static /*0x78*/ System.Func<sbyte, ushort, object> <>9__0_14;
                static /*0x80*/ System.Func<sbyte, int, object> <>9__0_15;
                static /*0x88*/ System.Func<sbyte, uint, object> <>9__0_16;
                static /*0x90*/ System.Func<sbyte, long, object> <>9__0_17;
                static /*0x98*/ System.Func<sbyte, float, object> <>9__0_18;
                static /*0xa0*/ System.Func<sbyte, decimal, object> <>9__0_19;
                static /*0xa8*/ System.Func<sbyte, double, object> <>9__0_20;
                static /*0xb0*/ System.Func<short, byte, object> <>9__0_21;
                static /*0xb8*/ System.Func<short, sbyte, object> <>9__0_22;
                static /*0xc0*/ System.Func<short, short, object> <>9__0_23;
                static /*0xc8*/ System.Func<short, ushort, object> <>9__0_24;
                static /*0xd0*/ System.Func<short, int, object> <>9__0_25;
                static /*0xd8*/ System.Func<short, uint, object> <>9__0_26;
                static /*0xe0*/ System.Func<short, long, object> <>9__0_27;
                static /*0xe8*/ System.Func<short, float, object> <>9__0_28;
                static /*0xf0*/ System.Func<short, decimal, object> <>9__0_29;
                static /*0xf8*/ System.Func<short, double, object> <>9__0_30;
                static /*0x100*/ System.Func<ushort, byte, object> <>9__0_31;
                static /*0x108*/ System.Func<ushort, sbyte, object> <>9__0_32;
                static /*0x110*/ System.Func<ushort, short, object> <>9__0_33;
                static /*0x118*/ System.Func<ushort, ushort, object> <>9__0_34;
                static /*0x120*/ System.Func<ushort, int, object> <>9__0_35;
                static /*0x128*/ System.Func<ushort, uint, object> <>9__0_36;
                static /*0x130*/ System.Func<ushort, long, object> <>9__0_37;
                static /*0x138*/ System.Func<ushort, ulong, object> <>9__0_38;
                static /*0x140*/ System.Func<ushort, float, object> <>9__0_39;
                static /*0x148*/ System.Func<ushort, decimal, object> <>9__0_40;
                static /*0x150*/ System.Func<ushort, double, object> <>9__0_41;
                static /*0x158*/ System.Func<int, byte, object> <>9__0_42;
                static /*0x160*/ System.Func<int, sbyte, object> <>9__0_43;
                static /*0x168*/ System.Func<int, short, object> <>9__0_44;
                static /*0x170*/ System.Func<int, ushort, object> <>9__0_45;
                static /*0x178*/ System.Func<int, int, object> <>9__0_46;
                static /*0x180*/ System.Func<int, uint, object> <>9__0_47;
                static /*0x188*/ System.Func<int, long, object> <>9__0_48;
                static /*0x190*/ System.Func<int, float, object> <>9__0_49;
                static /*0x198*/ System.Func<int, decimal, object> <>9__0_50;
                static /*0x1a0*/ System.Func<int, double, object> <>9__0_51;
                static /*0x1a8*/ System.Func<uint, byte, object> <>9__0_52;
                static /*0x1b0*/ System.Func<uint, sbyte, object> <>9__0_53;
                static /*0x1b8*/ System.Func<uint, short, object> <>9__0_54;
                static /*0x1c0*/ System.Func<uint, ushort, object> <>9__0_55;
                static /*0x1c8*/ System.Func<uint, int, object> <>9__0_56;
                static /*0x1d0*/ System.Func<uint, uint, object> <>9__0_57;
                static /*0x1d8*/ System.Func<uint, long, object> <>9__0_58;
                static /*0x1e0*/ System.Func<uint, ulong, object> <>9__0_59;
                static /*0x1e8*/ System.Func<uint, float, object> <>9__0_60;
                static /*0x1f0*/ System.Func<uint, decimal, object> <>9__0_61;
                static /*0x1f8*/ System.Func<uint, double, object> <>9__0_62;
                static /*0x200*/ System.Func<long, byte, object> <>9__0_63;
                static /*0x208*/ System.Func<long, sbyte, object> <>9__0_64;
                static /*0x210*/ System.Func<long, short, object> <>9__0_65;
                static /*0x218*/ System.Func<long, ushort, object> <>9__0_66;
                static /*0x220*/ System.Func<long, int, object> <>9__0_67;
                static /*0x228*/ System.Func<long, uint, object> <>9__0_68;
                static /*0x230*/ System.Func<long, long, object> <>9__0_69;
                static /*0x238*/ System.Func<long, float, object> <>9__0_70;
                static /*0x240*/ System.Func<long, decimal, object> <>9__0_71;
                static /*0x248*/ System.Func<long, double, object> <>9__0_72;
                static /*0x250*/ System.Func<ulong, byte, object> <>9__0_73;
                static /*0x258*/ System.Func<ulong, ushort, object> <>9__0_74;
                static /*0x260*/ System.Func<ulong, uint, object> <>9__0_75;
                static /*0x268*/ System.Func<ulong, ulong, object> <>9__0_76;
                static /*0x270*/ System.Func<ulong, float, object> <>9__0_77;
                static /*0x278*/ System.Func<ulong, decimal, object> <>9__0_78;
                static /*0x280*/ System.Func<ulong, double, object> <>9__0_79;
                static /*0x288*/ System.Func<float, byte, object> <>9__0_80;
                static /*0x290*/ System.Func<float, sbyte, object> <>9__0_81;
                static /*0x298*/ System.Func<float, short, object> <>9__0_82;
                static /*0x2a0*/ System.Func<float, ushort, object> <>9__0_83;
                static /*0x2a8*/ System.Func<float, int, object> <>9__0_84;
                static /*0x2b0*/ System.Func<float, uint, object> <>9__0_85;
                static /*0x2b8*/ System.Func<float, long, object> <>9__0_86;
                static /*0x2c0*/ System.Func<float, ulong, object> <>9__0_87;
                static /*0x2c8*/ System.Func<float, float, object> <>9__0_88;
                static /*0x2d0*/ System.Func<float, double, object> <>9__0_89;
                static /*0x2d8*/ System.Func<decimal, byte, object> <>9__0_90;
                static /*0x2e0*/ System.Func<decimal, sbyte, object> <>9__0_91;
                static /*0x2e8*/ System.Func<decimal, short, object> <>9__0_92;
                static /*0x2f0*/ System.Func<decimal, ushort, object> <>9__0_93;
                static /*0x2f8*/ System.Func<decimal, int, object> <>9__0_94;
                static /*0x300*/ System.Func<decimal, uint, object> <>9__0_95;
                static /*0x308*/ System.Func<decimal, long, object> <>9__0_96;
                static /*0x310*/ System.Func<decimal, ulong, object> <>9__0_97;
                static /*0x318*/ System.Func<decimal, decimal, object> <>9__0_98;
                static /*0x320*/ System.Func<double, byte, object> <>9__0_99;
                static /*0x328*/ System.Func<double, sbyte, object> <>9__0_100;
                static /*0x330*/ System.Func<double, short, object> <>9__0_101;
                static /*0x338*/ System.Func<double, ushort, object> <>9__0_102;
                static /*0x340*/ System.Func<double, int, object> <>9__0_103;
                static /*0x348*/ System.Func<double, uint, object> <>9__0_104;
                static /*0x350*/ System.Func<double, long, object> <>9__0_105;
                static /*0x358*/ System.Func<double, ulong, object> <>9__0_106;
                static /*0x360*/ System.Func<double, float, object> <>9__0_107;
                static /*0x368*/ System.Func<double, double, object> <>9__0_108;

                static /*0x14fcac0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x14f54e0*/ object <.ctor>b__0_0(byte a, byte b);
                /*0x14f69d0*/ object <.ctor>b__0_1(byte a, sbyte b);
                /*0x14f7670*/ object <.ctor>b__0_2(byte a, short b);
                /*0x14f8240*/ object <.ctor>b__0_3(byte a, ushort b);
                /*0x14f8ec0*/ object <.ctor>b__0_4(byte a, int b);
                /*0x14f98e0*/ object <.ctor>b__0_5(byte a, uint b);
                /*0x14fa2c0*/ object <.ctor>b__0_6(byte a, long b);
                /*0x14fac50*/ object <.ctor>b__0_7(byte a, ulong b);
                /*0x14fb640*/ object <.ctor>b__0_8(byte a, float b);
                /*0x14fc2d0*/ object <.ctor>b__0_9(byte a, decimal b);
                /*0x14f5e90*/ object <.ctor>b__0_10(byte a, double b);
                /*0x14f5fb0*/ object <.ctor>b__0_11(sbyte a, byte b);
                /*0x14f6050*/ object <.ctor>b__0_12(sbyte a, sbyte b);
                /*0x14f6150*/ object <.ctor>b__0_13(sbyte a, short b);
                /*0x14f6250*/ object <.ctor>b__0_14(sbyte a, ushort b);
                /*0x14f6360*/ object <.ctor>b__0_15(sbyte a, int b);
                /*0x14f6520*/ object <.ctor>b__0_16(sbyte a, uint b);
                /*0x14f6630*/ object <.ctor>b__0_17(sbyte a, long b);
                /*0x14f6740*/ object <.ctor>b__0_18(sbyte a, float b);
                /*0x14f67a0*/ object <.ctor>b__0_19(sbyte a, decimal b);
                /*0x14f6b00*/ object <.ctor>b__0_20(sbyte a, double b);
                /*0x14f6bb0*/ object <.ctor>b__0_21(short a, byte b);
                /*0x14f6d80*/ object <.ctor>b__0_22(short a, sbyte b);
                /*0x14f6e20*/ object <.ctor>b__0_23(short a, short b);
                /*0x14f6f80*/ object <.ctor>b__0_24(short a, ushort b);
                /*0x14f7080*/ object <.ctor>b__0_25(short a, int b);
                /*0x14f70d0*/ object <.ctor>b__0_26(short a, uint b);
                /*0x14f7290*/ object <.ctor>b__0_27(short a, long b);
                /*0x14f73a0*/ object <.ctor>b__0_28(short a, float b);
                /*0x14f7400*/ object <.ctor>b__0_29(short a, decimal b);
                /*0x14f7820*/ object <.ctor>b__0_30(short a, double b);
                /*0x14f7930*/ object <.ctor>b__0_31(ushort a, byte b);
                /*0x14f79d0*/ object <.ctor>b__0_32(ushort a, sbyte b);
                /*0x14f7b30*/ object <.ctor>b__0_33(ushort a, short b);
                /*0x14f7c30*/ object <.ctor>b__0_34(ushort a, ushort b);
                /*0x14f7cd0*/ object <.ctor>b__0_35(ushort a, int b);
                /*0x14f7de0*/ object <.ctor>b__0_36(ushort a, uint b);
                /*0x14f7e80*/ object <.ctor>b__0_37(ushort a, long b);
                /*0x14f8030*/ object <.ctor>b__0_38(ushort a, ulong b);
                /*0x14f8130*/ object <.ctor>b__0_39(ushort a, float b);
                /*0x14f83d0*/ object <.ctor>b__0_40(ushort a, decimal b);
                /*0x14f8520*/ object <.ctor>b__0_41(ushort a, double b);
                /*0x14f85e0*/ object <.ctor>b__0_42(int a, byte b);
                /*0x14f86d0*/ object <.ctor>b__0_43(int a, sbyte b);
                /*0x14f87d0*/ object <.ctor>b__0_44(int a, short b);
                /*0x14f88d0*/ object <.ctor>b__0_45(int a, ushort b);
                /*0x14f8980*/ object <.ctor>b__0_46(int a, int b);
                /*0x14f8a80*/ object <.ctor>b__0_47(int a, uint b);
                /*0x14f8bf0*/ object <.ctor>b__0_48(int a, long b);
                /*0x14f8d00*/ object <.ctor>b__0_49(int a, float b);
                /*0x14f8f10*/ object <.ctor>b__0_50(int a, decimal b);
                /*0x14f90a0*/ object <.ctor>b__0_51(int a, double b);
                /*0x14f9200*/ object <.ctor>b__0_52(uint a, byte b);
                /*0x14f9370*/ object <.ctor>b__0_53(uint a, sbyte b);
                /*0x14f9420*/ object <.ctor>b__0_54(uint a, short b);
                /*0x14f9530*/ object <.ctor>b__0_55(uint a, ushort b);
                /*0x14f9630*/ object <.ctor>b__0_56(uint a, int b);
                /*0x14f96d0*/ object <.ctor>b__0_57(uint a, uint b);
                /*0x14f97e0*/ object <.ctor>b__0_58(uint a, long b);
                /*0x14f9890*/ object <.ctor>b__0_59(uint a, ulong b);
                /*0x14f9a90*/ object <.ctor>b__0_60(uint a, float b);
                /*0x14f9af0*/ object <.ctor>b__0_61(uint a, decimal b);
                /*0x14f9c90*/ object <.ctor>b__0_62(uint a, double b);
                /*0x14f9cf0*/ object <.ctor>b__0_63(long a, byte b);
                /*0x14f9db0*/ object <.ctor>b__0_64(long a, sbyte b);
                /*0x14f9e70*/ object <.ctor>b__0_65(long a, short b);
                /*0x14f9f90*/ object <.ctor>b__0_66(long a, ushort b);
                /*0x14fa050*/ object <.ctor>b__0_67(long a, int b);
                /*0x14fa0a0*/ object <.ctor>b__0_68(long a, uint b);
                /*0x14fa1b0*/ object <.ctor>b__0_69(long a, long b);
                /*0x14fa360*/ object <.ctor>b__0_70(long a, float b);
                /*0x14fa4c0*/ object <.ctor>b__0_71(long a, decimal b);
                /*0x14fa560*/ object <.ctor>b__0_72(long a, double b);
                /*0x14fa680*/ object <.ctor>b__0_73(ulong a, byte b);
                /*0x14fa6e0*/ object <.ctor>b__0_74(ulong a, ushort b);
                /*0x14fa7a0*/ object <.ctor>b__0_75(ulong a, uint b);
                /*0x14fa8b0*/ object <.ctor>b__0_76(ulong a, ulong b);
                /*0x14fa990*/ object <.ctor>b__0_77(ulong a, float b);
                /*0x14faab0*/ object <.ctor>b__0_78(ulong a, decimal b);
                /*0x14fabd0*/ object <.ctor>b__0_79(ulong a, double b);
                /*0x14fae00*/ object <.ctor>b__0_80(float a, byte b);
                /*0x14fae60*/ object <.ctor>b__0_81(float a, sbyte b);
                /*0x14faf80*/ object <.ctor>b__0_82(float a, short b);
                /*0x14fb040*/ object <.ctor>b__0_83(float a, ushort b);
                /*0x14fb100*/ object <.ctor>b__0_84(float a, int b);
                /*0x14fb1c0*/ object <.ctor>b__0_85(float a, uint b);
                /*0x14fb220*/ object <.ctor>b__0_86(float a, long b);
                /*0x14fb360*/ object <.ctor>b__0_87(float a, ulong b);
                /*0x14fb440*/ object <.ctor>b__0_88(float a, float b);
                /*0x14fb4a0*/ object <.ctor>b__0_89(float a, double b);
                /*0x14fb6f0*/ object <.ctor>b__0_90(decimal a, byte b);
                /*0x14fb8d0*/ object <.ctor>b__0_91(decimal a, sbyte b);
                /*0x14fb970*/ object <.ctor>b__0_92(decimal a, short b);
                /*0x14fbb50*/ object <.ctor>b__0_93(decimal a, ushort b);
                /*0x14fbc90*/ object <.ctor>b__0_94(decimal a, int b);
                /*0x14fbd30*/ object <.ctor>b__0_95(decimal a, uint b);
                /*0x14fbe70*/ object <.ctor>b__0_96(decimal a, long b);
                /*0x14fc050*/ object <.ctor>b__0_97(decimal a, ulong b);
                /*0x14fc0f0*/ object <.ctor>b__0_98(decimal a, decimal b);
                /*0x14fc210*/ object <.ctor>b__0_99(double a, byte b);
                /*0x14f56c0*/ object <.ctor>b__0_100(double a, sbyte b);
                /*0x14f5780*/ object <.ctor>b__0_101(double a, short b);
                /*0x14f58a0*/ object <.ctor>b__0_102(double a, ushort b);
                /*0x14f5900*/ object <.ctor>b__0_103(double a, int b);
                /*0x14f59c0*/ object <.ctor>b__0_104(double a, uint b);
                /*0x14f5a80*/ object <.ctor>b__0_105(double a, long b);
                /*0x14f5bc0*/ object <.ctor>b__0_106(double a, ulong b);
                /*0x14f5c40*/ object <.ctor>b__0_107(double a, float b);
                /*0x14f5d80*/ object <.ctor>b__0_108(double a, double b);
            }
        }

        class AmbiguousOperatorException : Unity.VisualScripting.OperatorException
        {
            /*0x14dd7e0*/ AmbiguousOperatorException(string symbol, System.Type leftType, System.Type rightType);
        }

        class AndHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x14dd9d0*/ AndHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.AndHandler.<> <>9;
                static /*0x8*/ System.Func<bool, bool, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, byte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, sbyte, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, short, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, ushort, object> <>9__0_4;
                static /*0x30*/ System.Func<byte, int, object> <>9__0_5;
                static /*0x38*/ System.Func<byte, uint, object> <>9__0_6;
                static /*0x40*/ System.Func<byte, long, object> <>9__0_7;
                static /*0x48*/ System.Func<byte, ulong, object> <>9__0_8;
                static /*0x50*/ System.Func<sbyte, byte, object> <>9__0_9;
                static /*0x58*/ System.Func<sbyte, sbyte, object> <>9__0_10;
                static /*0x60*/ System.Func<sbyte, short, object> <>9__0_11;
                static /*0x68*/ System.Func<sbyte, ushort, object> <>9__0_12;
                static /*0x70*/ System.Func<sbyte, int, object> <>9__0_13;
                static /*0x78*/ System.Func<sbyte, uint, object> <>9__0_14;
                static /*0x80*/ System.Func<sbyte, long, object> <>9__0_15;
                static /*0x88*/ System.Func<short, byte, object> <>9__0_16;
                static /*0x90*/ System.Func<short, sbyte, object> <>9__0_17;
                static /*0x98*/ System.Func<short, short, object> <>9__0_18;
                static /*0xa0*/ System.Func<short, ushort, object> <>9__0_19;
                static /*0xa8*/ System.Func<short, int, object> <>9__0_20;
                static /*0xb0*/ System.Func<short, uint, object> <>9__0_21;
                static /*0xb8*/ System.Func<short, long, object> <>9__0_22;
                static /*0xc0*/ System.Func<ushort, byte, object> <>9__0_23;
                static /*0xc8*/ System.Func<ushort, sbyte, object> <>9__0_24;
                static /*0xd0*/ System.Func<ushort, short, object> <>9__0_25;
                static /*0xd8*/ System.Func<ushort, ushort, object> <>9__0_26;
                static /*0xe0*/ System.Func<ushort, int, object> <>9__0_27;
                static /*0xe8*/ System.Func<ushort, uint, object> <>9__0_28;
                static /*0xf0*/ System.Func<ushort, long, object> <>9__0_29;
                static /*0xf8*/ System.Func<ushort, ulong, object> <>9__0_30;
                static /*0x100*/ System.Func<int, byte, object> <>9__0_31;
                static /*0x108*/ System.Func<int, sbyte, object> <>9__0_32;
                static /*0x110*/ System.Func<int, short, object> <>9__0_33;
                static /*0x118*/ System.Func<int, ushort, object> <>9__0_34;
                static /*0x120*/ System.Func<int, int, object> <>9__0_35;
                static /*0x128*/ System.Func<int, uint, object> <>9__0_36;
                static /*0x130*/ System.Func<int, long, object> <>9__0_37;
                static /*0x138*/ System.Func<uint, byte, object> <>9__0_38;
                static /*0x140*/ System.Func<uint, sbyte, object> <>9__0_39;
                static /*0x148*/ System.Func<uint, short, object> <>9__0_40;
                static /*0x150*/ System.Func<uint, ushort, object> <>9__0_41;
                static /*0x158*/ System.Func<uint, int, object> <>9__0_42;
                static /*0x160*/ System.Func<uint, uint, object> <>9__0_43;
                static /*0x168*/ System.Func<uint, long, object> <>9__0_44;
                static /*0x170*/ System.Func<uint, ulong, object> <>9__0_45;
                static /*0x178*/ System.Func<long, byte, object> <>9__0_46;
                static /*0x180*/ System.Func<long, sbyte, object> <>9__0_47;
                static /*0x188*/ System.Func<long, short, object> <>9__0_48;
                static /*0x190*/ System.Func<long, ushort, object> <>9__0_49;
                static /*0x198*/ System.Func<long, int, object> <>9__0_50;
                static /*0x1a0*/ System.Func<long, uint, object> <>9__0_51;
                static /*0x1a8*/ System.Func<long, long, object> <>9__0_52;
                static /*0x1b0*/ System.Func<ulong, byte, object> <>9__0_53;
                static /*0x1b8*/ System.Func<ulong, ushort, object> <>9__0_54;
                static /*0x1c0*/ System.Func<ulong, uint, object> <>9__0_55;
                static /*0x1c8*/ System.Func<ulong, ulong, object> <>9__0_56;

                static /*0x14fcc80*/ <>c();
                /*0x32f970*/ <>c();
                /*0x14f5530*/ object <.ctor>b__0_0(bool a, bool b);
                /*0x14f6930*/ object <.ctor>b__0_1(byte a, byte b);
                /*0x14f7590*/ object <.ctor>b__0_2(byte a, sbyte b);
                /*0x14f8290*/ object <.ctor>b__0_3(byte a, short b);
                /*0x14f8dc0*/ object <.ctor>b__0_4(byte a, ushort b);
                /*0x14f9980*/ object <.ctor>b__0_5(byte a, int b);
                /*0x14fa310*/ object <.ctor>b__0_6(byte a, uint b);
                /*0x14fad50*/ object <.ctor>b__0_7(byte a, long b);
                /*0x14fb6a0*/ object <.ctor>b__0_8(byte a, ulong b);
                /*0x14fc3f0*/ object <.ctor>b__0_9(sbyte a, byte b);
                /*0x14f5de0*/ object <.ctor>b__0_10(sbyte a, sbyte b);
                /*0x14f6000*/ object <.ctor>b__0_11(sbyte a, short b);
                /*0x14f60a0*/ object <.ctor>b__0_12(sbyte a, ushort b);
                /*0x14f61a0*/ object <.ctor>b__0_13(sbyte a, int b);
                /*0x14f6300*/ object <.ctor>b__0_14(sbyte a, uint b);
                /*0x14f63b0*/ object <.ctor>b__0_15(sbyte a, long b);
                /*0x14f6470*/ object <.ctor>b__0_16(short a, byte b);
                /*0x14f65e0*/ object <.ctor>b__0_17(short a, sbyte b);
                /*0x14f6690*/ object <.ctor>b__0_18(short a, short b);
                /*0x14f68e0*/ object <.ctor>b__0_19(short a, ushort b);
                /*0x14f6b60*/ object <.ctor>b__0_20(short a, int b);
                /*0x14f6c60*/ object <.ctor>b__0_21(short a, uint b);
                /*0x14f6d20*/ object <.ctor>b__0_22(short a, long b);
                /*0x14f6dd0*/ object <.ctor>b__0_23(ushort a, byte b);
                /*0x14f6f30*/ object <.ctor>b__0_24(ushort a, sbyte b);
                /*0x14f6fd0*/ object <.ctor>b__0_25(ushort a, short b);
                /*0x14f7190*/ object <.ctor>b__0_26(ushort a, ushort b);
                /*0x14f7240*/ object <.ctor>b__0_27(ushort a, int b);
                /*0x14f72f0*/ object <.ctor>b__0_28(ushort a, uint b);
                /*0x14f74a0*/ object <.ctor>b__0_29(ushort a, long b);
                /*0x14f7770*/ object <.ctor>b__0_30(ushort a, ulong b);
                /*0x14f78e0*/ object <.ctor>b__0_31(int a, byte b);
                /*0x14f7980*/ object <.ctor>b__0_32(int a, sbyte b);
                /*0x14f7ae0*/ object <.ctor>b__0_33(int a, short b);
                /*0x14f7be0*/ object <.ctor>b__0_34(int a, ushort b);
                /*0x14f7c80*/ object <.ctor>b__0_35(int a, int b);
                /*0x14f7e30*/ object <.ctor>b__0_36(int a, uint b);
                /*0x14f7f30*/ object <.ctor>b__0_37(int a, long b);
                /*0x14f7f80*/ object <.ctor>b__0_38(uint a, byte b);
                /*0x14f8080*/ object <.ctor>b__0_39(uint a, sbyte b);
                /*0x14f82e0*/ object <.ctor>b__0_40(uint a, short b);
                /*0x14f8470*/ object <.ctor>b__0_41(uint a, ushort b);
                /*0x14f8630*/ object <.ctor>b__0_42(uint a, int b);
                /*0x14f8680*/ object <.ctor>b__0_43(uint a, uint b);
                /*0x14f8780*/ object <.ctor>b__0_44(uint a, long b);
                /*0x14f8880*/ object <.ctor>b__0_45(uint a, ulong b);
                /*0x14f89d0*/ object <.ctor>b__0_46(long a, byte b);
                /*0x14f8b30*/ object <.ctor>b__0_47(long a, sbyte b);
                /*0x14f8c40*/ object <.ctor>b__0_48(long a, short b);
                /*0x14f8ca0*/ object <.ctor>b__0_49(long a, ushort b);
                /*0x14f9050*/ object <.ctor>b__0_50(long a, int b);
                /*0x14f9100*/ object <.ctor>b__0_51(long a, uint b);
                /*0x14f91b0*/ object <.ctor>b__0_52(long a, long b);
                /*0x14f9310*/ object <.ctor>b__0_53(ulong a, byte b);
                /*0x14f9470*/ object <.ctor>b__0_54(ulong a, ushort b);
                /*0x14f9580*/ object <.ctor>b__0_55(ulong a, uint b);
                /*0x14f9680*/ object <.ctor>b__0_56(ulong a, ulong b);
            }
        }

        enum BinaryOperator
        {
            Addition = 0,
            Subtraction = 1,
            Multiplication = 2,
            Division = 3,
            Modulo = 4,
            And = 5,
            Or = 6,
            ExclusiveOr = 7,
            Equality = 8,
            Inequality = 9,
            GreaterThan = 10,
            LessThan = 11,
            GreaterThanOrEqual = 12,
            LessThanOrEqual = 13,
            LeftShift = 14,
            RightShift = 15,
        }

        class BinaryOperatorHandler : Unity.VisualScripting.OperatorHandler
        {
            /*0x30*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.BinaryOperatorHandler.OperatorQuery, System.Func<object, object, object>> handlers;
            /*0x38*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.BinaryOperatorHandler.OperatorQuery, Unity.VisualScripting.IOptimizedInvoker> userDefinedOperators;
            /*0x40*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.BinaryOperatorHandler.OperatorQuery, Unity.VisualScripting.BinaryOperatorHandler.OperatorQuery> userDefinedOperandTypes;

            static /*0x14e1570*/ Unity.VisualScripting.BinaryOperatorHandler.OperatorQuery ResolveUserDefinedOperandTypes(System.Reflection.MethodInfo userDefinedOperator);
            /*0x14e16b0*/ BinaryOperatorHandler(string name, string verb, string symbol, string customMethodName);
            /*0x14e0c00*/ object Operate(object leftOperand, object rightOperand);
            /*0x14e0b50*/ object CustomHandling(object leftOperand, object rightOperand);
            /*0x14e0af0*/ object BothNullHandling();
            /*0x14e1650*/ object SingleNullHandling();
            void Handle<TLeft, TRight>(System.Func<TLeft, TRight, object> handler, bool reverse);

            struct OperatorQuery : System.IEquatable<Unity.VisualScripting.BinaryOperatorHandler.OperatorQuery>
            {
                /*0x10*/ System.Type leftType;
                /*0x18*/ System.Type rightType;

                /*0xa59de0*/ OperatorQuery(System.Type leftType, System.Type rightType);
                /*0x14f48f0*/ bool Equals(Unity.VisualScripting.BinaryOperatorHandler.OperatorQuery other);
                /*0x14f47e0*/ bool Equals(object obj);
                /*0x14f49a0*/ int GetHashCode();
            }

            class <>c__DisplayClass8_0<TLeft, TRight>
            {
                /*0x0*/ System.Func<TLeft, TRight, object> handler;

                /*0x180fc0*/ <>c__DisplayClass8_0();
                /*0x177730*/ object <Handle>b__0(object left, object right);
                /*0x177730*/ object <Handle>b__1(object left, object right);
            }
        }

        class DecrementHandler : Unity.VisualScripting.UnaryOperatorHandler
        {
            /*0x14e1a20*/ DecrementHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.DecrementHandler.<> <>9;
                static /*0x8*/ System.Func<byte, object> <>9__0_0;
                static /*0x10*/ System.Func<sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<short, object> <>9__0_2;
                static /*0x20*/ System.Func<ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<int, object> <>9__0_4;
                static /*0x30*/ System.Func<uint, object> <>9__0_5;
                static /*0x38*/ System.Func<long, object> <>9__0_6;
                static /*0x40*/ System.Func<ulong, object> <>9__0_7;
                static /*0x48*/ System.Func<float, object> <>9__0_8;
                static /*0x50*/ System.Func<decimal, object> <>9__0_9;
                static /*0x58*/ System.Func<double, object> <>9__0_10;

                static /*0x14fccf0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x14f5580*/ object <.ctor>b__0_0(byte a);
                /*0x14f6980*/ object <.ctor>b__0_1(sbyte a);
                /*0x14f7720*/ object <.ctor>b__0_2(short a);
                /*0x14f81f0*/ object <.ctor>b__0_3(ushort a);
                /*0x14f8e10*/ object <.ctor>b__0_4(int a);
                /*0x14f9930*/ object <.ctor>b__0_5(uint a);
                /*0x14fa270*/ object <.ctor>b__0_6(long a);
                /*0x14fad00*/ object <.ctor>b__0_7(ulong a);
                /*0x14fb580*/ object <.ctor>b__0_8(float a);
                /*0x14fc370*/ object <.ctor>b__0_9(decimal a);
                /*0x14f5e30*/ object <.ctor>b__0_10(double a);
            }
        }

        class DivisionHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x14e23c0*/ DivisionHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.DivisionHandler.<> <>9;
                static /*0x8*/ System.Func<byte, byte, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, short, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, int, object> <>9__0_4;
                static /*0x30*/ System.Func<byte, uint, object> <>9__0_5;
                static /*0x38*/ System.Func<byte, long, object> <>9__0_6;
                static /*0x40*/ System.Func<byte, ulong, object> <>9__0_7;
                static /*0x48*/ System.Func<byte, float, object> <>9__0_8;
                static /*0x50*/ System.Func<byte, decimal, object> <>9__0_9;
                static /*0x58*/ System.Func<byte, double, object> <>9__0_10;
                static /*0x60*/ System.Func<sbyte, byte, object> <>9__0_11;
                static /*0x68*/ System.Func<sbyte, sbyte, object> <>9__0_12;
                static /*0x70*/ System.Func<sbyte, short, object> <>9__0_13;
                static /*0x78*/ System.Func<sbyte, ushort, object> <>9__0_14;
                static /*0x80*/ System.Func<sbyte, int, object> <>9__0_15;
                static /*0x88*/ System.Func<sbyte, uint, object> <>9__0_16;
                static /*0x90*/ System.Func<sbyte, long, object> <>9__0_17;
                static /*0x98*/ System.Func<sbyte, float, object> <>9__0_18;
                static /*0xa0*/ System.Func<sbyte, decimal, object> <>9__0_19;
                static /*0xa8*/ System.Func<sbyte, double, object> <>9__0_20;
                static /*0xb0*/ System.Func<short, byte, object> <>9__0_21;
                static /*0xb8*/ System.Func<short, sbyte, object> <>9__0_22;
                static /*0xc0*/ System.Func<short, short, object> <>9__0_23;
                static /*0xc8*/ System.Func<short, ushort, object> <>9__0_24;
                static /*0xd0*/ System.Func<short, int, object> <>9__0_25;
                static /*0xd8*/ System.Func<short, uint, object> <>9__0_26;
                static /*0xe0*/ System.Func<short, long, object> <>9__0_27;
                static /*0xe8*/ System.Func<short, float, object> <>9__0_28;
                static /*0xf0*/ System.Func<short, decimal, object> <>9__0_29;
                static /*0xf8*/ System.Func<short, double, object> <>9__0_30;
                static /*0x100*/ System.Func<ushort, byte, object> <>9__0_31;
                static /*0x108*/ System.Func<ushort, sbyte, object> <>9__0_32;
                static /*0x110*/ System.Func<ushort, short, object> <>9__0_33;
                static /*0x118*/ System.Func<ushort, ushort, object> <>9__0_34;
                static /*0x120*/ System.Func<ushort, int, object> <>9__0_35;
                static /*0x128*/ System.Func<ushort, uint, object> <>9__0_36;
                static /*0x130*/ System.Func<ushort, long, object> <>9__0_37;
                static /*0x138*/ System.Func<ushort, ulong, object> <>9__0_38;
                static /*0x140*/ System.Func<ushort, float, object> <>9__0_39;
                static /*0x148*/ System.Func<ushort, decimal, object> <>9__0_40;
                static /*0x150*/ System.Func<ushort, double, object> <>9__0_41;
                static /*0x158*/ System.Func<int, byte, object> <>9__0_42;
                static /*0x160*/ System.Func<int, sbyte, object> <>9__0_43;
                static /*0x168*/ System.Func<int, short, object> <>9__0_44;
                static /*0x170*/ System.Func<int, ushort, object> <>9__0_45;
                static /*0x178*/ System.Func<int, int, object> <>9__0_46;
                static /*0x180*/ System.Func<int, uint, object> <>9__0_47;
                static /*0x188*/ System.Func<int, long, object> <>9__0_48;
                static /*0x190*/ System.Func<int, float, object> <>9__0_49;
                static /*0x198*/ System.Func<int, decimal, object> <>9__0_50;
                static /*0x1a0*/ System.Func<int, double, object> <>9__0_51;
                static /*0x1a8*/ System.Func<uint, byte, object> <>9__0_52;
                static /*0x1b0*/ System.Func<uint, sbyte, object> <>9__0_53;
                static /*0x1b8*/ System.Func<uint, short, object> <>9__0_54;
                static /*0x1c0*/ System.Func<uint, ushort, object> <>9__0_55;
                static /*0x1c8*/ System.Func<uint, int, object> <>9__0_56;
                static /*0x1d0*/ System.Func<uint, uint, object> <>9__0_57;
                static /*0x1d8*/ System.Func<uint, long, object> <>9__0_58;
                static /*0x1e0*/ System.Func<uint, ulong, object> <>9__0_59;
                static /*0x1e8*/ System.Func<uint, float, object> <>9__0_60;
                static /*0x1f0*/ System.Func<uint, decimal, object> <>9__0_61;
                static /*0x1f8*/ System.Func<uint, double, object> <>9__0_62;
                static /*0x200*/ System.Func<long, byte, object> <>9__0_63;
                static /*0x208*/ System.Func<long, sbyte, object> <>9__0_64;
                static /*0x210*/ System.Func<long, short, object> <>9__0_65;
                static /*0x218*/ System.Func<long, ushort, object> <>9__0_66;
                static /*0x220*/ System.Func<long, int, object> <>9__0_67;
                static /*0x228*/ System.Func<long, uint, object> <>9__0_68;
                static /*0x230*/ System.Func<long, long, object> <>9__0_69;
                static /*0x238*/ System.Func<long, float, object> <>9__0_70;
                static /*0x240*/ System.Func<long, decimal, object> <>9__0_71;
                static /*0x248*/ System.Func<long, double, object> <>9__0_72;
                static /*0x250*/ System.Func<ulong, byte, object> <>9__0_73;
                static /*0x258*/ System.Func<ulong, ushort, object> <>9__0_74;
                static /*0x260*/ System.Func<ulong, uint, object> <>9__0_75;
                static /*0x268*/ System.Func<ulong, ulong, object> <>9__0_76;
                static /*0x270*/ System.Func<ulong, float, object> <>9__0_77;
                static /*0x278*/ System.Func<ulong, decimal, object> <>9__0_78;
                static /*0x280*/ System.Func<ulong, double, object> <>9__0_79;
                static /*0x288*/ System.Func<float, byte, object> <>9__0_80;
                static /*0x290*/ System.Func<float, sbyte, object> <>9__0_81;
                static /*0x298*/ System.Func<float, short, object> <>9__0_82;
                static /*0x2a0*/ System.Func<float, ushort, object> <>9__0_83;
                static /*0x2a8*/ System.Func<float, int, object> <>9__0_84;
                static /*0x2b0*/ System.Func<float, uint, object> <>9__0_85;
                static /*0x2b8*/ System.Func<float, long, object> <>9__0_86;
                static /*0x2c0*/ System.Func<float, ulong, object> <>9__0_87;
                static /*0x2c8*/ System.Func<float, float, object> <>9__0_88;
                static /*0x2d0*/ System.Func<float, double, object> <>9__0_89;
                static /*0x2d8*/ System.Func<decimal, byte, object> <>9__0_90;
                static /*0x2e0*/ System.Func<decimal, sbyte, object> <>9__0_91;
                static /*0x2e8*/ System.Func<decimal, short, object> <>9__0_92;
                static /*0x2f0*/ System.Func<decimal, ushort, object> <>9__0_93;
                static /*0x2f8*/ System.Func<decimal, int, object> <>9__0_94;
                static /*0x300*/ System.Func<decimal, uint, object> <>9__0_95;
                static /*0x308*/ System.Func<decimal, long, object> <>9__0_96;
                static /*0x310*/ System.Func<decimal, ulong, object> <>9__0_97;
                static /*0x318*/ System.Func<decimal, decimal, object> <>9__0_98;
                static /*0x320*/ System.Func<double, byte, object> <>9__0_99;
                static /*0x328*/ System.Func<double, sbyte, object> <>9__0_100;
                static /*0x330*/ System.Func<double, short, object> <>9__0_101;
                static /*0x338*/ System.Func<double, ushort, object> <>9__0_102;
                static /*0x340*/ System.Func<double, int, object> <>9__0_103;
                static /*0x348*/ System.Func<double, uint, object> <>9__0_104;
                static /*0x350*/ System.Func<double, long, object> <>9__0_105;
                static /*0x358*/ System.Func<double, ulong, object> <>9__0_106;
                static /*0x360*/ System.Func<double, float, object> <>9__0_107;
                static /*0x368*/ System.Func<double, double, object> <>9__0_108;

                static /*0x14fcba0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x14f5660*/ object <.ctor>b__0_0(byte a, byte b);
                /*0x14f6a40*/ object <.ctor>b__0_1(byte a, sbyte b);
                /*0x14f76c0*/ object <.ctor>b__0_2(byte a, short b);
                /*0x14f8190*/ object <.ctor>b__0_3(byte a, ushort b);
                /*0x14f8e60*/ object <.ctor>b__0_4(byte a, int b);
                /*0x14f99d0*/ object <.ctor>b__0_5(byte a, uint b);
                /*0x14fa210*/ object <.ctor>b__0_6(byte a, long b);
                /*0x14faca0*/ object <.ctor>b__0_7(byte a, ulong b);
                /*0x14fb5e0*/ object <.ctor>b__0_8(byte a, float b);
                /*0x14fc440*/ object <.ctor>b__0_9(byte a, decimal b);
                /*0x14f5ef0*/ object <.ctor>b__0_10(byte a, double b);
                /*0x14f5f50*/ object <.ctor>b__0_11(sbyte a, byte b);
                /*0x14f60f0*/ object <.ctor>b__0_12(sbyte a, sbyte b);
                /*0x14f61f0*/ object <.ctor>b__0_13(sbyte a, short b);
                /*0x14f62a0*/ object <.ctor>b__0_14(sbyte a, ushort b);
                /*0x14f6410*/ object <.ctor>b__0_15(sbyte a, int b);
                /*0x14f64c0*/ object <.ctor>b__0_16(sbyte a, uint b);
                /*0x14f6580*/ object <.ctor>b__0_17(sbyte a, long b);
                /*0x14f66e0*/ object <.ctor>b__0_18(sbyte a, float b);
                /*0x14f6840*/ object <.ctor>b__0_19(sbyte a, decimal b);
                /*0x14f6aa0*/ object <.ctor>b__0_20(sbyte a, double b);
                /*0x14f6c00*/ object <.ctor>b__0_21(short a, byte b);
                /*0x14f6cc0*/ object <.ctor>b__0_22(short a, sbyte b);
                /*0x14f6e70*/ object <.ctor>b__0_23(short a, short b);
                /*0x14f6ed0*/ object <.ctor>b__0_24(short a, ushort b);
                /*0x14f7020*/ object <.ctor>b__0_25(short a, int b);
                /*0x14f7130*/ object <.ctor>b__0_26(short a, uint b);
                /*0x14f71e0*/ object <.ctor>b__0_27(short a, long b);
                /*0x14f7340*/ object <.ctor>b__0_28(short a, float b);
                /*0x14f74f0*/ object <.ctor>b__0_29(short a, decimal b);
                /*0x14f77c0*/ object <.ctor>b__0_30(short a, double b);
                /*0x14f7880*/ object <.ctor>b__0_31(ushort a, byte b);
                /*0x14f7a20*/ object <.ctor>b__0_32(ushort a, sbyte b);
                /*0x14f7a80*/ object <.ctor>b__0_33(ushort a, short b);
                /*0x14f7b80*/ object <.ctor>b__0_34(ushort a, ushort b);
                /*0x14f7d20*/ object <.ctor>b__0_35(ushort a, int b);
                /*0x14f7d80*/ object <.ctor>b__0_36(ushort a, uint b);
                /*0x14f7ed0*/ object <.ctor>b__0_37(ushort a, long b);
                /*0x14f7fd0*/ object <.ctor>b__0_38(ushort a, ulong b);
                /*0x14f80d0*/ object <.ctor>b__0_39(ushort a, float b);
                /*0x14f8330*/ object <.ctor>b__0_40(ushort a, decimal b);
                /*0x14f84c0*/ object <.ctor>b__0_41(ushort a, double b);
                /*0x14f8580*/ object <.ctor>b__0_42(int a, byte b);
                /*0x14f8720*/ object <.ctor>b__0_43(int a, sbyte b);
                /*0x14f8820*/ object <.ctor>b__0_44(int a, short b);
                /*0x14f8920*/ object <.ctor>b__0_45(int a, ushort b);
                /*0x14f8a30*/ object <.ctor>b__0_46(int a, int b);
                /*0x14f8ad0*/ object <.ctor>b__0_47(int a, uint b);
                /*0x14f8b90*/ object <.ctor>b__0_48(int a, long b);
                /*0x14f8d60*/ object <.ctor>b__0_49(int a, float b);
                /*0x14f8fb0*/ object <.ctor>b__0_50(int a, decimal b);
                /*0x14f9150*/ object <.ctor>b__0_51(int a, double b);
                /*0x14f9250*/ object <.ctor>b__0_52(uint a, byte b);
                /*0x14f92b0*/ object <.ctor>b__0_53(uint a, sbyte b);
                /*0x14f93c0*/ object <.ctor>b__0_54(uint a, short b);
                /*0x14f94d0*/ object <.ctor>b__0_55(uint a, ushort b);
                /*0x14f95d0*/ object <.ctor>b__0_56(uint a, int b);
                /*0x14f9720*/ object <.ctor>b__0_57(uint a, uint b);
                /*0x14f9780*/ object <.ctor>b__0_58(uint a, long b);
                /*0x14f9830*/ object <.ctor>b__0_59(uint a, ulong b);
                /*0x14f9a30*/ object <.ctor>b__0_60(uint a, float b);
                /*0x14f9b90*/ object <.ctor>b__0_61(uint a, decimal b);
                /*0x14f9c30*/ object <.ctor>b__0_62(uint a, double b);
                /*0x14f9d50*/ object <.ctor>b__0_63(long a, byte b);
                /*0x14f9e10*/ object <.ctor>b__0_64(long a, sbyte b);
                /*0x14f9ed0*/ object <.ctor>b__0_65(long a, short b);
                /*0x14f9f30*/ object <.ctor>b__0_66(long a, ushort b);
                /*0x14f9ff0*/ object <.ctor>b__0_67(long a, int b);
                /*0x14fa0f0*/ object <.ctor>b__0_68(long a, uint b);
                /*0x14fa150*/ object <.ctor>b__0_69(long a, long b);
                /*0x14fa3c0*/ object <.ctor>b__0_70(long a, float b);
                /*0x14fa420*/ object <.ctor>b__0_71(long a, decimal b);
                /*0x14fa5c0*/ object <.ctor>b__0_72(long a, double b);
                /*0x14fa620*/ object <.ctor>b__0_73(ulong a, byte b);
                /*0x14fa740*/ object <.ctor>b__0_74(ulong a, ushort b);
                /*0x14fa7f0*/ object <.ctor>b__0_75(ulong a, uint b);
                /*0x14fa850*/ object <.ctor>b__0_76(ulong a, ulong b);
                /*0x14fa910*/ object <.ctor>b__0_77(ulong a, float b);
                /*0x14faa10*/ object <.ctor>b__0_78(ulong a, decimal b);
                /*0x14fab50*/ object <.ctor>b__0_79(ulong a, double b);
                /*0x14fada0*/ object <.ctor>b__0_80(float a, byte b);
                /*0x14faec0*/ object <.ctor>b__0_81(float a, sbyte b);
                /*0x14faf20*/ object <.ctor>b__0_82(float a, short b);
                /*0x14fafe0*/ object <.ctor>b__0_83(float a, ushort b);
                /*0x14fb0a0*/ object <.ctor>b__0_84(float a, int b);
                /*0x14fb160*/ object <.ctor>b__0_85(float a, uint b);
                /*0x14fb280*/ object <.ctor>b__0_86(float a, long b);
                /*0x14fb2e0*/ object <.ctor>b__0_87(float a, ulong b);
                /*0x14fb3e0*/ object <.ctor>b__0_88(float a, float b);
                /*0x14fb510*/ object <.ctor>b__0_89(float a, double b);
                /*0x14fb790*/ object <.ctor>b__0_90(decimal a, byte b);
                /*0x14fb830*/ object <.ctor>b__0_91(decimal a, sbyte b);
                /*0x14fba10*/ object <.ctor>b__0_92(decimal a, short b);
                /*0x14fbab0*/ object <.ctor>b__0_93(decimal a, ushort b);
                /*0x14fbbf0*/ object <.ctor>b__0_94(decimal a, int b);
                /*0x14fbdd0*/ object <.ctor>b__0_95(decimal a, uint b);
                /*0x14fbf10*/ object <.ctor>b__0_96(decimal a, long b);
                /*0x14fbfb0*/ object <.ctor>b__0_97(decimal a, ulong b);
                /*0x14fc180*/ object <.ctor>b__0_98(decimal a, decimal b);
                /*0x14fc270*/ object <.ctor>b__0_99(double a, byte b);
                /*0x14f5720*/ object <.ctor>b__0_100(double a, sbyte b);
                /*0x14f57e0*/ object <.ctor>b__0_101(double a, short b);
                /*0x14f5840*/ object <.ctor>b__0_102(double a, ushort b);
                /*0x14f5960*/ object <.ctor>b__0_103(double a, int b);
                /*0x14f5a20*/ object <.ctor>b__0_104(double a, uint b);
                /*0x14f5ae0*/ object <.ctor>b__0_105(double a, long b);
                /*0x14f5b40*/ object <.ctor>b__0_106(double a, ulong b);
                /*0x14f5cb0*/ object <.ctor>b__0_107(double a, float b);
                /*0x14f5d20*/ object <.ctor>b__0_108(double a, double b);
            }
        }

        class EqualityHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x14e8280*/ EqualityHandler();
            /*0x14e81a0*/ object BothNullHandling();
            /*0x14e8240*/ object SingleNullHandling();
            /*0x14e81e0*/ object CustomHandling(object leftOperand, object rightOperand);

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.EqualityHandler.<> <>9;
                static /*0x8*/ System.Func<byte, byte, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, short, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, int, object> <>9__0_4;
                static /*0x30*/ System.Func<byte, uint, object> <>9__0_5;
                static /*0x38*/ System.Func<byte, long, object> <>9__0_6;
                static /*0x40*/ System.Func<byte, ulong, object> <>9__0_7;
                static /*0x48*/ System.Func<byte, float, object> <>9__0_8;
                static /*0x50*/ System.Func<byte, decimal, object> <>9__0_9;
                static /*0x58*/ System.Func<byte, double, object> <>9__0_10;
                static /*0x60*/ System.Func<sbyte, byte, object> <>9__0_11;
                static /*0x68*/ System.Func<sbyte, sbyte, object> <>9__0_12;
                static /*0x70*/ System.Func<sbyte, short, object> <>9__0_13;
                static /*0x78*/ System.Func<sbyte, ushort, object> <>9__0_14;
                static /*0x80*/ System.Func<sbyte, int, object> <>9__0_15;
                static /*0x88*/ System.Func<sbyte, uint, object> <>9__0_16;
                static /*0x90*/ System.Func<sbyte, long, object> <>9__0_17;
                static /*0x98*/ System.Func<sbyte, float, object> <>9__0_18;
                static /*0xa0*/ System.Func<sbyte, decimal, object> <>9__0_19;
                static /*0xa8*/ System.Func<sbyte, double, object> <>9__0_20;
                static /*0xb0*/ System.Func<short, byte, object> <>9__0_21;
                static /*0xb8*/ System.Func<short, sbyte, object> <>9__0_22;
                static /*0xc0*/ System.Func<short, short, object> <>9__0_23;
                static /*0xc8*/ System.Func<short, ushort, object> <>9__0_24;
                static /*0xd0*/ System.Func<short, int, object> <>9__0_25;
                static /*0xd8*/ System.Func<short, uint, object> <>9__0_26;
                static /*0xe0*/ System.Func<short, long, object> <>9__0_27;
                static /*0xe8*/ System.Func<short, float, object> <>9__0_28;
                static /*0xf0*/ System.Func<short, decimal, object> <>9__0_29;
                static /*0xf8*/ System.Func<short, double, object> <>9__0_30;
                static /*0x100*/ System.Func<ushort, byte, object> <>9__0_31;
                static /*0x108*/ System.Func<ushort, sbyte, object> <>9__0_32;
                static /*0x110*/ System.Func<ushort, short, object> <>9__0_33;
                static /*0x118*/ System.Func<ushort, ushort, object> <>9__0_34;
                static /*0x120*/ System.Func<ushort, int, object> <>9__0_35;
                static /*0x128*/ System.Func<ushort, uint, object> <>9__0_36;
                static /*0x130*/ System.Func<ushort, long, object> <>9__0_37;
                static /*0x138*/ System.Func<ushort, ulong, object> <>9__0_38;
                static /*0x140*/ System.Func<ushort, float, object> <>9__0_39;
                static /*0x148*/ System.Func<ushort, decimal, object> <>9__0_40;
                static /*0x150*/ System.Func<ushort, double, object> <>9__0_41;
                static /*0x158*/ System.Func<int, byte, object> <>9__0_42;
                static /*0x160*/ System.Func<int, sbyte, object> <>9__0_43;
                static /*0x168*/ System.Func<int, short, object> <>9__0_44;
                static /*0x170*/ System.Func<int, ushort, object> <>9__0_45;
                static /*0x178*/ System.Func<int, int, object> <>9__0_46;
                static /*0x180*/ System.Func<int, uint, object> <>9__0_47;
                static /*0x188*/ System.Func<int, long, object> <>9__0_48;
                static /*0x190*/ System.Func<int, float, object> <>9__0_49;
                static /*0x198*/ System.Func<int, decimal, object> <>9__0_50;
                static /*0x1a0*/ System.Func<int, double, object> <>9__0_51;
                static /*0x1a8*/ System.Func<uint, byte, object> <>9__0_52;
                static /*0x1b0*/ System.Func<uint, sbyte, object> <>9__0_53;
                static /*0x1b8*/ System.Func<uint, short, object> <>9__0_54;
                static /*0x1c0*/ System.Func<uint, ushort, object> <>9__0_55;
                static /*0x1c8*/ System.Func<uint, int, object> <>9__0_56;
                static /*0x1d0*/ System.Func<uint, uint, object> <>9__0_57;
                static /*0x1d8*/ System.Func<uint, long, object> <>9__0_58;
                static /*0x1e0*/ System.Func<uint, ulong, object> <>9__0_59;
                static /*0x1e8*/ System.Func<uint, float, object> <>9__0_60;
                static /*0x1f0*/ System.Func<uint, decimal, object> <>9__0_61;
                static /*0x1f8*/ System.Func<uint, double, object> <>9__0_62;
                static /*0x200*/ System.Func<long, byte, object> <>9__0_63;
                static /*0x208*/ System.Func<long, sbyte, object> <>9__0_64;
                static /*0x210*/ System.Func<long, short, object> <>9__0_65;
                static /*0x218*/ System.Func<long, ushort, object> <>9__0_66;
                static /*0x220*/ System.Func<long, int, object> <>9__0_67;
                static /*0x228*/ System.Func<long, uint, object> <>9__0_68;
                static /*0x230*/ System.Func<long, long, object> <>9__0_69;
                static /*0x238*/ System.Func<long, float, object> <>9__0_70;
                static /*0x240*/ System.Func<long, decimal, object> <>9__0_71;
                static /*0x248*/ System.Func<long, double, object> <>9__0_72;
                static /*0x250*/ System.Func<ulong, byte, object> <>9__0_73;
                static /*0x258*/ System.Func<ulong, ushort, object> <>9__0_74;
                static /*0x260*/ System.Func<ulong, uint, object> <>9__0_75;
                static /*0x268*/ System.Func<ulong, ulong, object> <>9__0_76;
                static /*0x270*/ System.Func<ulong, float, object> <>9__0_77;
                static /*0x278*/ System.Func<ulong, decimal, object> <>9__0_78;
                static /*0x280*/ System.Func<ulong, double, object> <>9__0_79;
                static /*0x288*/ System.Func<float, byte, object> <>9__0_80;
                static /*0x290*/ System.Func<float, sbyte, object> <>9__0_81;
                static /*0x298*/ System.Func<float, short, object> <>9__0_82;
                static /*0x2a0*/ System.Func<float, ushort, object> <>9__0_83;
                static /*0x2a8*/ System.Func<float, int, object> <>9__0_84;
                static /*0x2b0*/ System.Func<float, uint, object> <>9__0_85;
                static /*0x2b8*/ System.Func<float, long, object> <>9__0_86;
                static /*0x2c0*/ System.Func<float, ulong, object> <>9__0_87;
                static /*0x2c8*/ System.Func<float, float, object> <>9__0_88;
                static /*0x2d0*/ System.Func<float, double, object> <>9__0_89;
                static /*0x2d8*/ System.Func<decimal, byte, object> <>9__0_90;
                static /*0x2e0*/ System.Func<decimal, sbyte, object> <>9__0_91;
                static /*0x2e8*/ System.Func<decimal, short, object> <>9__0_92;
                static /*0x2f0*/ System.Func<decimal, ushort, object> <>9__0_93;
                static /*0x2f8*/ System.Func<decimal, int, object> <>9__0_94;
                static /*0x300*/ System.Func<decimal, uint, object> <>9__0_95;
                static /*0x308*/ System.Func<decimal, long, object> <>9__0_96;
                static /*0x310*/ System.Func<decimal, ulong, object> <>9__0_97;
                static /*0x318*/ System.Func<decimal, decimal, object> <>9__0_98;
                static /*0x320*/ System.Func<double, byte, object> <>9__0_99;
                static /*0x328*/ System.Func<double, sbyte, object> <>9__0_100;
                static /*0x330*/ System.Func<double, short, object> <>9__0_101;
                static /*0x338*/ System.Func<double, ushort, object> <>9__0_102;
                static /*0x340*/ System.Func<double, int, object> <>9__0_103;
                static /*0x348*/ System.Func<double, uint, object> <>9__0_104;
                static /*0x350*/ System.Func<double, long, object> <>9__0_105;
                static /*0x358*/ System.Func<double, ulong, object> <>9__0_106;
                static /*0x360*/ System.Func<double, float, object> <>9__0_107;
                static /*0x368*/ System.Func<double, double, object> <>9__0_108;

                static /*0x1527ff0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x151a9c0*/ object <.ctor>b__0_0(byte a, byte b);
                /*0x151d110*/ object <.ctor>b__0_1(byte a, sbyte b);
                /*0x151eb20*/ object <.ctor>b__0_2(byte a, short b);
                /*0x1520190*/ object <.ctor>b__0_3(byte a, ushort b);
                /*0x15215b0*/ object <.ctor>b__0_4(byte a, int b);
                /*0x1522770*/ object <.ctor>b__0_5(byte a, uint b);
                /*0x1523ad0*/ object <.ctor>b__0_6(byte a, long b);
                /*0x1524d50*/ object <.ctor>b__0_7(byte a, ulong b);
                /*0x15260c0*/ object <.ctor>b__0_8(byte a, float b);
                /*0x1527af0*/ object <.ctor>b__0_9(byte a, decimal b);
                /*0x151bb50*/ object <.ctor>b__0_10(byte a, double b);
                /*0x151bd20*/ object <.ctor>b__0_11(sbyte a, byte b);
                /*0x151bf90*/ object <.ctor>b__0_12(sbyte a, sbyte b);
                /*0x151c050*/ object <.ctor>b__0_13(sbyte a, short b);
                /*0x151c390*/ object <.ctor>b__0_14(sbyte a, ushort b);
                /*0x151c5d0*/ object <.ctor>b__0_15(sbyte a, int b);
                /*0x151c7a0*/ object <.ctor>b__0_16(sbyte a, uint b);
                /*0x151ca80*/ object <.ctor>b__0_17(sbyte a, long b);
                /*0x151cc50*/ object <.ctor>b__0_18(sbyte a, float b);
                /*0x151ce80*/ object <.ctor>b__0_19(sbyte a, decimal b);
                /*0x151d480*/ object <.ctor>b__0_20(sbyte a, double b);
                /*0x151d550*/ object <.ctor>b__0_21(short a, byte b);
                /*0x151d910*/ object <.ctor>b__0_22(short a, sbyte b);
                /*0x151da90*/ object <.ctor>b__0_23(short a, short b);
                /*0x151dc40*/ object <.ctor>b__0_24(short a, ushort b);
                /*0x151de80*/ object <.ctor>b__0_25(short a, int b);
                /*0x151e150*/ object <.ctor>b__0_26(short a, uint b);
                /*0x151e260*/ object <.ctor>b__0_27(short a, long b);
                /*0x151e560*/ object <.ctor>b__0_28(short a, float b);
                /*0x151e630*/ object <.ctor>b__0_29(short a, decimal b);
                /*0x151ec40*/ object <.ctor>b__0_30(short a, double b);
                /*0x151f000*/ object <.ctor>b__0_31(ushort a, byte b);
                /*0x151f0b0*/ object <.ctor>b__0_32(ushort a, sbyte b);
                /*0x151f2f0*/ object <.ctor>b__0_33(ushort a, short b);
                /*0x151f440*/ object <.ctor>b__0_34(ushort a, ushort b);
                /*0x151f760*/ object <.ctor>b__0_35(ushort a, int b);
                /*0x151f960*/ object <.ctor>b__0_36(ushort a, uint b);
                /*0x151fbf0*/ object <.ctor>b__0_37(ushort a, long b);
                /*0x151fd40*/ object <.ctor>b__0_38(ushort a, ulong b);
                /*0x151fe80*/ object <.ctor>b__0_39(ushort a, float b);
                /*0x15203a0*/ object <.ctor>b__0_40(ushort a, decimal b);
                /*0x1520750*/ object <.ctor>b__0_41(ushort a, double b);
                /*0x1520900*/ object <.ctor>b__0_42(int a, byte b);
                /*0x1520a40*/ object <.ctor>b__0_43(int a, sbyte b);
                /*0x1520ae0*/ object <.ctor>b__0_44(int a, short b);
                /*0x1520db0*/ object <.ctor>b__0_45(int a, ushort b);
                /*0x1520f00*/ object <.ctor>b__0_46(int a, int b);
                /*0x1520fa0*/ object <.ctor>b__0_47(int a, uint b);
                /*0x1521290*/ object <.ctor>b__0_48(int a, long b);
                /*0x1521340*/ object <.ctor>b__0_49(int a, float b);
                /*0x1521700*/ object <.ctor>b__0_50(int a, decimal b);
                /*0x1521a30*/ object <.ctor>b__0_51(int a, double b);
                /*0x1521c60*/ object <.ctor>b__0_52(uint a, byte b);
                /*0x1521d50*/ object <.ctor>b__0_53(uint a, sbyte b);
                /*0x1521ef0*/ object <.ctor>b__0_54(uint a, short b);
                /*0x15221d0*/ object <.ctor>b__0_55(uint a, ushort b);
                /*0x1522220*/ object <.ctor>b__0_56(uint a, int b);
                /*0x15223b0*/ object <.ctor>b__0_57(uint a, uint b);
                /*0x15225e0*/ object <.ctor>b__0_58(uint a, long b);
                /*0x15226d0*/ object <.ctor>b__0_59(uint a, ulong b);
                /*0x15229b0*/ object <.ctor>b__0_60(uint a, float b);
                /*0x1522d30*/ object <.ctor>b__0_61(uint a, decimal b);
                /*0x1522ea0*/ object <.ctor>b__0_62(uint a, double b);
                /*0x1523030*/ object <.ctor>b__0_63(long a, byte b);
                /*0x15231b0*/ object <.ctor>b__0_64(long a, sbyte b);
                /*0x15232d0*/ object <.ctor>b__0_65(long a, short b);
                /*0x1523450*/ object <.ctor>b__0_66(long a, ushort b);
                /*0x15235c0*/ object <.ctor>b__0_67(long a, int b);
                /*0x15237a0*/ object <.ctor>b__0_68(long a, uint b);
                /*0x15238e0*/ object <.ctor>b__0_69(long a, long b);
                /*0x1523bd0*/ object <.ctor>b__0_70(long a, float b);
                /*0x1523db0*/ object <.ctor>b__0_71(long a, decimal b);
                /*0x1523ff0*/ object <.ctor>b__0_72(long a, double b);
                /*0x1524130*/ object <.ctor>b__0_73(ulong a, byte b);
                /*0x1524370*/ object <.ctor>b__0_74(ulong a, ushort b);
                /*0x1524480*/ object <.ctor>b__0_75(ulong a, uint b);
                /*0x15245c0*/ object <.ctor>b__0_76(ulong a, ulong b);
                /*0x15247c0*/ object <.ctor>b__0_77(ulong a, float b);
                /*0x1524970*/ object <.ctor>b__0_78(ulong a, decimal b);
                /*0x1524b50*/ object <.ctor>b__0_79(ulong a, double b);
                /*0x1525050*/ object <.ctor>b__0_80(float a, byte b);
                /*0x1525200*/ object <.ctor>b__0_81(float a, sbyte b);
                /*0x15252d0*/ object <.ctor>b__0_82(float a, short b);
                /*0x15255a0*/ object <.ctor>b__0_83(float a, ushort b);
                /*0x1525740*/ object <.ctor>b__0_84(float a, int b);
                /*0x1525820*/ object <.ctor>b__0_85(float a, uint b);
                /*0x1525a10*/ object <.ctor>b__0_86(float a, long b);
                /*0x1525b80*/ object <.ctor>b__0_87(float a, ulong b);
                /*0x1525d70*/ object <.ctor>b__0_88(float a, float b);
                /*0x1525ec0*/ object <.ctor>b__0_89(float a, double b);
                /*0x1526450*/ object <.ctor>b__0_90(decimal a, byte b);
                /*0x1526590*/ object <.ctor>b__0_91(decimal a, sbyte b);
                /*0x1526950*/ object <.ctor>b__0_92(decimal a, short b);
                /*0x1526b30*/ object <.ctor>b__0_93(decimal a, ushort b);
                /*0x1526ef0*/ object <.ctor>b__0_94(decimal a, int b);
                /*0x15270d0*/ object <.ctor>b__0_95(decimal a, uint b);
                /*0x1527210*/ object <.ctor>b__0_96(decimal a, long b);
                /*0x15275d0*/ object <.ctor>b__0_97(decimal a, ulong b);
                /*0x1527710*/ object <.ctor>b__0_98(decimal a, decimal b);
                /*0x1527950*/ object <.ctor>b__0_99(double a, byte b);
                /*0x151abb0*/ object <.ctor>b__0_100(double a, sbyte b);
                /*0x151ad50*/ object <.ctor>b__0_101(double a, short b);
                /*0x151aef0*/ object <.ctor>b__0_102(double a, ushort b);
                /*0x151b020*/ object <.ctor>b__0_103(double a, int b);
                /*0x151b100*/ object <.ctor>b__0_104(double a, uint b);
                /*0x151b300*/ object <.ctor>b__0_105(double a, long b);
                /*0x151b5c0*/ object <.ctor>b__0_106(double a, ulong b);
                /*0x151b770*/ object <.ctor>b__0_107(double a, float b);
                /*0x151b7e0*/ object <.ctor>b__0_108(double a, double b);
            }
        }

        class ExclusiveOrHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x14fcf30*/ ExclusiveOrHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.ExclusiveOrHandler.<> <>9;
                static /*0x8*/ System.Func<bool, bool, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, byte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, sbyte, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, short, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, ushort, object> <>9__0_4;
                static /*0x30*/ System.Func<byte, int, object> <>9__0_5;
                static /*0x38*/ System.Func<byte, uint, object> <>9__0_6;
                static /*0x40*/ System.Func<byte, long, object> <>9__0_7;
                static /*0x48*/ System.Func<byte, ulong, object> <>9__0_8;
                static /*0x50*/ System.Func<sbyte, byte, object> <>9__0_9;
                static /*0x58*/ System.Func<sbyte, sbyte, object> <>9__0_10;
                static /*0x60*/ System.Func<sbyte, short, object> <>9__0_11;
                static /*0x68*/ System.Func<sbyte, ushort, object> <>9__0_12;
                static /*0x70*/ System.Func<sbyte, int, object> <>9__0_13;
                static /*0x78*/ System.Func<sbyte, uint, object> <>9__0_14;
                static /*0x80*/ System.Func<sbyte, long, object> <>9__0_15;
                static /*0x88*/ System.Func<short, byte, object> <>9__0_16;
                static /*0x90*/ System.Func<short, sbyte, object> <>9__0_17;
                static /*0x98*/ System.Func<short, short, object> <>9__0_18;
                static /*0xa0*/ System.Func<short, ushort, object> <>9__0_19;
                static /*0xa8*/ System.Func<short, int, object> <>9__0_20;
                static /*0xb0*/ System.Func<short, uint, object> <>9__0_21;
                static /*0xb8*/ System.Func<short, long, object> <>9__0_22;
                static /*0xc0*/ System.Func<ushort, byte, object> <>9__0_23;
                static /*0xc8*/ System.Func<ushort, sbyte, object> <>9__0_24;
                static /*0xd0*/ System.Func<ushort, short, object> <>9__0_25;
                static /*0xd8*/ System.Func<ushort, ushort, object> <>9__0_26;
                static /*0xe0*/ System.Func<ushort, int, object> <>9__0_27;
                static /*0xe8*/ System.Func<ushort, uint, object> <>9__0_28;
                static /*0xf0*/ System.Func<ushort, long, object> <>9__0_29;
                static /*0xf8*/ System.Func<ushort, ulong, object> <>9__0_30;
                static /*0x100*/ System.Func<int, byte, object> <>9__0_31;
                static /*0x108*/ System.Func<int, sbyte, object> <>9__0_32;
                static /*0x110*/ System.Func<int, short, object> <>9__0_33;
                static /*0x118*/ System.Func<int, ushort, object> <>9__0_34;
                static /*0x120*/ System.Func<int, int, object> <>9__0_35;
                static /*0x128*/ System.Func<int, uint, object> <>9__0_36;
                static /*0x130*/ System.Func<int, long, object> <>9__0_37;
                static /*0x138*/ System.Func<uint, byte, object> <>9__0_38;
                static /*0x140*/ System.Func<uint, sbyte, object> <>9__0_39;
                static /*0x148*/ System.Func<uint, short, object> <>9__0_40;
                static /*0x150*/ System.Func<uint, ushort, object> <>9__0_41;
                static /*0x158*/ System.Func<uint, int, object> <>9__0_42;
                static /*0x160*/ System.Func<uint, uint, object> <>9__0_43;
                static /*0x168*/ System.Func<uint, long, object> <>9__0_44;
                static /*0x170*/ System.Func<uint, ulong, object> <>9__0_45;
                static /*0x178*/ System.Func<long, byte, object> <>9__0_46;
                static /*0x180*/ System.Func<long, sbyte, object> <>9__0_47;
                static /*0x188*/ System.Func<long, short, object> <>9__0_48;
                static /*0x190*/ System.Func<long, ushort, object> <>9__0_49;
                static /*0x198*/ System.Func<long, int, object> <>9__0_50;
                static /*0x1a0*/ System.Func<long, uint, object> <>9__0_51;
                static /*0x1a8*/ System.Func<long, long, object> <>9__0_52;
                static /*0x1b0*/ System.Func<ulong, byte, object> <>9__0_53;
                static /*0x1b8*/ System.Func<ulong, ushort, object> <>9__0_54;
                static /*0x1c0*/ System.Func<ulong, uint, object> <>9__0_55;
                static /*0x1c8*/ System.Func<ulong, ulong, object> <>9__0_56;

                static /*0x15280d0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x151a8c0*/ object <.ctor>b__0_0(bool a, bool b);
                /*0x151d1b0*/ object <.ctor>b__0_1(byte a, byte b);
                /*0x151e9c0*/ object <.ctor>b__0_2(byte a, sbyte b);
                /*0x1520250*/ object <.ctor>b__0_3(byte a, short b);
                /*0x15214c0*/ object <.ctor>b__0_4(byte a, ushort b);
                /*0x1522860*/ object <.ctor>b__0_5(byte a, int b);
                /*0x1523b20*/ object <.ctor>b__0_6(byte a, uint b);
                /*0x1524df0*/ object <.ctor>b__0_7(byte a, long b);
                /*0x1526200*/ object <.ctor>b__0_8(byte a, ulong b);
                /*0x1527e50*/ object <.ctor>b__0_9(sbyte a, byte b);
                /*0x151b980*/ object <.ctor>b__0_10(sbyte a, sbyte b);
                /*0x151bcd0*/ object <.ctor>b__0_11(sbyte a, short b);
                /*0x151be80*/ object <.ctor>b__0_12(sbyte a, ushort b);
                /*0x151c170*/ object <.ctor>b__0_13(sbyte a, int b);
                /*0x151c2e0*/ object <.ctor>b__0_14(sbyte a, uint b);
                /*0x151c620*/ object <.ctor>b__0_15(sbyte a, long b);
                /*0x151c860*/ object <.ctor>b__0_16(short a, byte b);
                /*0x151c9d0*/ object <.ctor>b__0_17(short a, sbyte b);
                /*0x151cc00*/ object <.ctor>b__0_18(short a, short b);
                /*0x151ce30*/ object <.ctor>b__0_19(short a, ushort b);
                /*0x151d430*/ object <.ctor>b__0_20(short a, int b);
                /*0x151d670*/ object <.ctor>b__0_21(short a, uint b);
                /*0x151d790*/ object <.ctor>b__0_22(short a, long b);
                /*0x151daf0*/ object <.ctor>b__0_23(ushort a, byte b);
                /*0x151dba0*/ object <.ctor>b__0_24(ushort a, sbyte b);
                /*0x151df30*/ object <.ctor>b__0_25(ushort a, short b);
                /*0x151df80*/ object <.ctor>b__0_26(ushort a, ushort b);
                /*0x151e210*/ object <.ctor>b__0_27(ushort a, int b);
                /*0x151e440*/ object <.ctor>b__0_28(ushort a, uint b);
                /*0x151e770*/ object <.ctor>b__0_29(ushort a, long b);
                /*0x151ed70*/ object <.ctor>b__0_30(ushort a, ulong b);
                /*0x151efb0*/ object <.ctor>b__0_31(int a, byte b);
                /*0x151f200*/ object <.ctor>b__0_32(int a, sbyte b);
                /*0x151f3f0*/ object <.ctor>b__0_33(int a, short b);
                /*0x151f4a0*/ object <.ctor>b__0_34(int a, ushort b);
                /*0x151f710*/ object <.ctor>b__0_35(int a, int b);
                /*0x151f9b0*/ object <.ctor>b__0_36(int a, uint b);
                /*0x151fa50*/ object <.ctor>b__0_37(int a, long b);
                /*0x151fd90*/ object <.ctor>b__0_38(uint a, byte b);
                /*0x151fe30*/ object <.ctor>b__0_39(uint a, sbyte b);
                /*0x1520440*/ object <.ctor>b__0_40(uint a, short b);
                /*0x1520640*/ object <.ctor>b__0_41(uint a, ushort b);
                /*0x1520810*/ object <.ctor>b__0_42(uint a, int b);
                /*0x15209a0*/ object <.ctor>b__0_43(uint a, uint b);
                /*0x1520b30*/ object <.ctor>b__0_44(uint a, long b);
                /*0x1520d10*/ object <.ctor>b__0_45(uint a, ulong b);
                /*0x1520e00*/ object <.ctor>b__0_46(long a, byte b);
                /*0x1521090*/ object <.ctor>b__0_47(long a, sbyte b);
                /*0x1521190*/ object <.ctor>b__0_48(long a, short b);
                /*0x1521460*/ object <.ctor>b__0_49(long a, ushort b);
                /*0x15217a0*/ object <.ctor>b__0_50(long a, int b);
                /*0x1521b10*/ object <.ctor>b__0_51(long a, uint b);
                /*0x1521bc0*/ object <.ctor>b__0_52(long a, long b);
                /*0x1521df0*/ object <.ctor>b__0_53(ulong a, byte b);
                /*0x1521f90*/ object <.ctor>b__0_54(ulong a, ushort b);
                /*0x1522090*/ object <.ctor>b__0_55(ulong a, uint b);
                /*0x1522310*/ object <.ctor>b__0_56(ulong a, ulong b);
            }
        }

        class GreaterThanHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x1500050*/ GreaterThanHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.GreaterThanHandler.<> <>9;
                static /*0x8*/ System.Func<byte, byte, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, short, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, int, object> <>9__0_4;
                static /*0x30*/ System.Func<byte, uint, object> <>9__0_5;
                static /*0x38*/ System.Func<byte, long, object> <>9__0_6;
                static /*0x40*/ System.Func<byte, ulong, object> <>9__0_7;
                static /*0x48*/ System.Func<byte, float, object> <>9__0_8;
                static /*0x50*/ System.Func<byte, decimal, object> <>9__0_9;
                static /*0x58*/ System.Func<byte, double, object> <>9__0_10;
                static /*0x60*/ System.Func<sbyte, byte, object> <>9__0_11;
                static /*0x68*/ System.Func<sbyte, sbyte, object> <>9__0_12;
                static /*0x70*/ System.Func<sbyte, short, object> <>9__0_13;
                static /*0x78*/ System.Func<sbyte, ushort, object> <>9__0_14;
                static /*0x80*/ System.Func<sbyte, int, object> <>9__0_15;
                static /*0x88*/ System.Func<sbyte, uint, object> <>9__0_16;
                static /*0x90*/ System.Func<sbyte, long, object> <>9__0_17;
                static /*0x98*/ System.Func<sbyte, float, object> <>9__0_18;
                static /*0xa0*/ System.Func<sbyte, decimal, object> <>9__0_19;
                static /*0xa8*/ System.Func<sbyte, double, object> <>9__0_20;
                static /*0xb0*/ System.Func<short, byte, object> <>9__0_21;
                static /*0xb8*/ System.Func<short, sbyte, object> <>9__0_22;
                static /*0xc0*/ System.Func<short, short, object> <>9__0_23;
                static /*0xc8*/ System.Func<short, ushort, object> <>9__0_24;
                static /*0xd0*/ System.Func<short, int, object> <>9__0_25;
                static /*0xd8*/ System.Func<short, uint, object> <>9__0_26;
                static /*0xe0*/ System.Func<short, long, object> <>9__0_27;
                static /*0xe8*/ System.Func<short, float, object> <>9__0_28;
                static /*0xf0*/ System.Func<short, decimal, object> <>9__0_29;
                static /*0xf8*/ System.Func<short, double, object> <>9__0_30;
                static /*0x100*/ System.Func<ushort, byte, object> <>9__0_31;
                static /*0x108*/ System.Func<ushort, sbyte, object> <>9__0_32;
                static /*0x110*/ System.Func<ushort, short, object> <>9__0_33;
                static /*0x118*/ System.Func<ushort, ushort, object> <>9__0_34;
                static /*0x120*/ System.Func<ushort, int, object> <>9__0_35;
                static /*0x128*/ System.Func<ushort, uint, object> <>9__0_36;
                static /*0x130*/ System.Func<ushort, long, object> <>9__0_37;
                static /*0x138*/ System.Func<ushort, ulong, object> <>9__0_38;
                static /*0x140*/ System.Func<ushort, float, object> <>9__0_39;
                static /*0x148*/ System.Func<ushort, decimal, object> <>9__0_40;
                static /*0x150*/ System.Func<ushort, double, object> <>9__0_41;
                static /*0x158*/ System.Func<int, byte, object> <>9__0_42;
                static /*0x160*/ System.Func<int, sbyte, object> <>9__0_43;
                static /*0x168*/ System.Func<int, short, object> <>9__0_44;
                static /*0x170*/ System.Func<int, ushort, object> <>9__0_45;
                static /*0x178*/ System.Func<int, int, object> <>9__0_46;
                static /*0x180*/ System.Func<int, uint, object> <>9__0_47;
                static /*0x188*/ System.Func<int, long, object> <>9__0_48;
                static /*0x190*/ System.Func<int, float, object> <>9__0_49;
                static /*0x198*/ System.Func<int, decimal, object> <>9__0_50;
                static /*0x1a0*/ System.Func<int, double, object> <>9__0_51;
                static /*0x1a8*/ System.Func<uint, byte, object> <>9__0_52;
                static /*0x1b0*/ System.Func<uint, sbyte, object> <>9__0_53;
                static /*0x1b8*/ System.Func<uint, short, object> <>9__0_54;
                static /*0x1c0*/ System.Func<uint, ushort, object> <>9__0_55;
                static /*0x1c8*/ System.Func<uint, int, object> <>9__0_56;
                static /*0x1d0*/ System.Func<uint, uint, object> <>9__0_57;
                static /*0x1d8*/ System.Func<uint, long, object> <>9__0_58;
                static /*0x1e0*/ System.Func<uint, ulong, object> <>9__0_59;
                static /*0x1e8*/ System.Func<uint, float, object> <>9__0_60;
                static /*0x1f0*/ System.Func<uint, decimal, object> <>9__0_61;
                static /*0x1f8*/ System.Func<uint, double, object> <>9__0_62;
                static /*0x200*/ System.Func<long, byte, object> <>9__0_63;
                static /*0x208*/ System.Func<long, sbyte, object> <>9__0_64;
                static /*0x210*/ System.Func<long, short, object> <>9__0_65;
                static /*0x218*/ System.Func<long, ushort, object> <>9__0_66;
                static /*0x220*/ System.Func<long, int, object> <>9__0_67;
                static /*0x228*/ System.Func<long, uint, object> <>9__0_68;
                static /*0x230*/ System.Func<long, long, object> <>9__0_69;
                static /*0x238*/ System.Func<long, float, object> <>9__0_70;
                static /*0x240*/ System.Func<long, decimal, object> <>9__0_71;
                static /*0x248*/ System.Func<long, double, object> <>9__0_72;
                static /*0x250*/ System.Func<ulong, byte, object> <>9__0_73;
                static /*0x258*/ System.Func<ulong, ushort, object> <>9__0_74;
                static /*0x260*/ System.Func<ulong, uint, object> <>9__0_75;
                static /*0x268*/ System.Func<ulong, ulong, object> <>9__0_76;
                static /*0x270*/ System.Func<ulong, float, object> <>9__0_77;
                static /*0x278*/ System.Func<ulong, decimal, object> <>9__0_78;
                static /*0x280*/ System.Func<ulong, double, object> <>9__0_79;
                static /*0x288*/ System.Func<float, byte, object> <>9__0_80;
                static /*0x290*/ System.Func<float, sbyte, object> <>9__0_81;
                static /*0x298*/ System.Func<float, short, object> <>9__0_82;
                static /*0x2a0*/ System.Func<float, ushort, object> <>9__0_83;
                static /*0x2a8*/ System.Func<float, int, object> <>9__0_84;
                static /*0x2b0*/ System.Func<float, uint, object> <>9__0_85;
                static /*0x2b8*/ System.Func<float, long, object> <>9__0_86;
                static /*0x2c0*/ System.Func<float, ulong, object> <>9__0_87;
                static /*0x2c8*/ System.Func<float, float, object> <>9__0_88;
                static /*0x2d0*/ System.Func<float, double, object> <>9__0_89;
                static /*0x2d8*/ System.Func<decimal, byte, object> <>9__0_90;
                static /*0x2e0*/ System.Func<decimal, sbyte, object> <>9__0_91;
                static /*0x2e8*/ System.Func<decimal, short, object> <>9__0_92;
                static /*0x2f0*/ System.Func<decimal, ushort, object> <>9__0_93;
                static /*0x2f8*/ System.Func<decimal, int, object> <>9__0_94;
                static /*0x300*/ System.Func<decimal, uint, object> <>9__0_95;
                static /*0x308*/ System.Func<decimal, long, object> <>9__0_96;
                static /*0x310*/ System.Func<decimal, ulong, object> <>9__0_97;
                static /*0x318*/ System.Func<decimal, decimal, object> <>9__0_98;
                static /*0x320*/ System.Func<double, byte, object> <>9__0_99;
                static /*0x328*/ System.Func<double, sbyte, object> <>9__0_100;
                static /*0x330*/ System.Func<double, short, object> <>9__0_101;
                static /*0x338*/ System.Func<double, ushort, object> <>9__0_102;
                static /*0x340*/ System.Func<double, int, object> <>9__0_103;
                static /*0x348*/ System.Func<double, uint, object> <>9__0_104;
                static /*0x350*/ System.Func<double, long, object> <>9__0_105;
                static /*0x358*/ System.Func<double, ulong, object> <>9__0_106;
                static /*0x360*/ System.Func<double, float, object> <>9__0_107;
                static /*0x368*/ System.Func<double, double, object> <>9__0_108;

                static /*0x1528140*/ <>c();
                /*0x32f970*/ <>c();
                /*0x151a910*/ object <.ctor>b__0_0(byte a, byte b);
                /*0x151d250*/ object <.ctor>b__0_1(byte a, sbyte b);
                /*0x151eb80*/ object <.ctor>b__0_2(byte a, short b);
                /*0x15200d0*/ object <.ctor>b__0_3(byte a, ushort b);
                /*0x1521600*/ object <.ctor>b__0_4(byte a, int b);
                /*0x15227c0*/ object <.ctor>b__0_5(byte a, uint b);
                /*0x1523930*/ object <.ctor>b__0_6(byte a, long b);
                /*0x1524f40*/ object <.ctor>b__0_7(byte a, ulong b);
                /*0x1526250*/ object <.ctor>b__0_8(byte a, float b);
                /*0x1527db0*/ object <.ctor>b__0_9(byte a, decimal b);
                /*0x151ba90*/ object <.ctor>b__0_10(byte a, double b);
                /*0x151bdd0*/ object <.ctor>b__0_11(sbyte a, byte b);
                /*0x151bff0*/ object <.ctor>b__0_12(sbyte a, sbyte b);
                /*0x151c1c0*/ object <.ctor>b__0_13(sbyte a, short b);
                /*0x151c430*/ object <.ctor>b__0_14(sbyte a, ushort b);
                /*0x151c530*/ object <.ctor>b__0_15(sbyte a, int b);
                /*0x151c740*/ object <.ctor>b__0_16(sbyte a, uint b);
                /*0x151c8b0*/ object <.ctor>b__0_17(sbyte a, long b);
                /*0x151cb40*/ object <.ctor>b__0_18(sbyte a, float b);
                /*0x151cd30*/ object <.ctor>b__0_19(sbyte a, decimal b);
                /*0x151d3d0*/ object <.ctor>b__0_20(sbyte a, double b);
                /*0x151d4f0*/ object <.ctor>b__0_21(short a, byte b);
                /*0x151d730*/ object <.ctor>b__0_22(short a, sbyte b);
                /*0x151da30*/ object <.ctor>b__0_23(short a, short b);
                /*0x151dc90*/ object <.ctor>b__0_24(short a, ushort b);
                /*0x151dd90*/ object <.ctor>b__0_25(short a, int b);
                /*0x151e030*/ object <.ctor>b__0_26(short a, uint b);
                /*0x151e2c0*/ object <.ctor>b__0_27(short a, long b);
                /*0x151e490*/ object <.ctor>b__0_28(short a, float b);
                /*0x151e6d0*/ object <.ctor>b__0_29(short a, decimal b);
                /*0x151ebe0*/ object <.ctor>b__0_30(short a, double b);
                /*0x151ee90*/ object <.ctor>b__0_31(ushort a, byte b);
                /*0x151f150*/ object <.ctor>b__0_32(ushort a, sbyte b);
                /*0x151f340*/ object <.ctor>b__0_33(ushort a, short b);
                /*0x151f5b0*/ object <.ctor>b__0_34(ushort a, ushort b);
                /*0x151f810*/ object <.ctor>b__0_35(ushort a, int b);
                /*0x151fa00*/ object <.ctor>b__0_36(ushort a, uint b);
                /*0x151fba0*/ object <.ctor>b__0_37(ushort a, long b);
                /*0x151fc40*/ object <.ctor>b__0_38(ushort a, ulong b);
                /*0x1520020*/ object <.ctor>b__0_39(ushort a, float b);
                /*0x1520490*/ object <.ctor>b__0_40(ushort a, decimal b);
                /*0x1520690*/ object <.ctor>b__0_41(ushort a, double b);
                /*0x15207c0*/ object <.ctor>b__0_42(int a, byte b);
                /*0x15209f0*/ object <.ctor>b__0_43(int a, sbyte b);
                /*0x1520c20*/ object <.ctor>b__0_44(int a, short b);
                /*0x1520c70*/ object <.ctor>b__0_45(int a, ushort b);
                /*0x1520eb0*/ object <.ctor>b__0_46(int a, int b);
                /*0x1521040*/ object <.ctor>b__0_47(int a, uint b);
                /*0x1521240*/ object <.ctor>b__0_48(int a, long b);
                /*0x15213a0*/ object <.ctor>b__0_49(int a, float b);
                /*0x1521890*/ object <.ctor>b__0_50(int a, decimal b);
                /*0x1521b60*/ object <.ctor>b__0_51(int a, double b);
                /*0x1521d00*/ object <.ctor>b__0_52(uint a, byte b);
                /*0x1521e50*/ object <.ctor>b__0_53(uint a, sbyte b);
                /*0x1521f40*/ object <.ctor>b__0_54(uint a, short b);
                /*0x1522180*/ object <.ctor>b__0_55(uint a, ushort b);
                /*0x1522270*/ object <.ctor>b__0_56(uint a, int b);
                /*0x1522450*/ object <.ctor>b__0_57(uint a, uint b);
                /*0x1522590*/ object <.ctor>b__0_58(uint a, long b);
                /*0x1522720*/ object <.ctor>b__0_59(uint a, ulong b);
                /*0x1522af0*/ object <.ctor>b__0_60(uint a, float b);
                /*0x1522c90*/ object <.ctor>b__0_61(uint a, decimal b);
                /*0x1522f10*/ object <.ctor>b__0_62(uint a, double b);
                /*0x1522f70*/ object <.ctor>b__0_63(long a, byte b);
                /*0x15230f0*/ object <.ctor>b__0_64(long a, sbyte b);
                /*0x1523390*/ object <.ctor>b__0_65(long a, short b);
                /*0x1523510*/ object <.ctor>b__0_66(long a, ushort b);
                /*0x1523570*/ object <.ctor>b__0_67(long a, int b);
                /*0x1523750*/ object <.ctor>b__0_68(long a, uint b);
                /*0x1523840*/ object <.ctor>b__0_69(long a, long b);
                /*0x1523cb0*/ object <.ctor>b__0_70(long a, float b);
                /*0x1523d10*/ object <.ctor>b__0_71(long a, decimal b);
                /*0x1523f90*/ object <.ctor>b__0_72(long a, double b);
                /*0x1524250*/ object <.ctor>b__0_73(ulong a, byte b);
                /*0x15243d0*/ object <.ctor>b__0_74(ulong a, ushort b);
                /*0x1524430*/ object <.ctor>b__0_75(ulong a, uint b);
                /*0x1524610*/ object <.ctor>b__0_76(ulong a, ulong b);
                /*0x15246b0*/ object <.ctor>b__0_77(ulong a, float b);
                /*0x1524a10*/ object <.ctor>b__0_78(ulong a, decimal b);
                /*0x1524bd0*/ object <.ctor>b__0_79(ulong a, double b);
                /*0x1524f90*/ object <.ctor>b__0_80(float a, byte b);
                /*0x1525270*/ object <.ctor>b__0_81(float a, sbyte b);
                /*0x1525410*/ object <.ctor>b__0_82(float a, short b);
                /*0x1525540*/ object <.ctor>b__0_83(float a, ushort b);
                /*0x1525680*/ object <.ctor>b__0_84(float a, int b);
                /*0x1525890*/ object <.ctor>b__0_85(float a, uint b);
                /*0x15259b0*/ object <.ctor>b__0_86(float a, long b);
                /*0x1525c10*/ object <.ctor>b__0_87(float a, ulong b);
                /*0x1525d10*/ object <.ctor>b__0_88(float a, float b);
                /*0x1525f30*/ object <.ctor>b__0_89(float a, double b);
                /*0x15263b0*/ object <.ctor>b__0_90(decimal a, byte b);
                /*0x1526630*/ object <.ctor>b__0_91(decimal a, sbyte b);
                /*0x15269f0*/ object <.ctor>b__0_92(decimal a, short b);
                /*0x1526a90*/ object <.ctor>b__0_93(decimal a, ushort b);
                /*0x1526d10*/ object <.ctor>b__0_94(decimal a, int b);
                /*0x1526f90*/ object <.ctor>b__0_95(decimal a, uint b);
                /*0x1527350*/ object <.ctor>b__0_96(decimal a, long b);
                /*0x1527530*/ object <.ctor>b__0_97(decimal a, ulong b);
                /*0x15277a0*/ object <.ctor>b__0_98(decimal a, decimal b);
                /*0x1527a90*/ object <.ctor>b__0_99(double a, byte b);
                /*0x151aa80*/ object <.ctor>b__0_100(double a, sbyte b);
                /*0x151ac90*/ object <.ctor>b__0_101(double a, short b);
                /*0x151ae90*/ object <.ctor>b__0_102(double a, ushort b);
                /*0x151af60*/ object <.ctor>b__0_103(double a, int b);
                /*0x151b240*/ object <.ctor>b__0_104(double a, uint b);
                /*0x151b370*/ object <.ctor>b__0_105(double a, long b);
                /*0x151b4c0*/ object <.ctor>b__0_106(double a, ulong b);
                /*0x151b710*/ object <.ctor>b__0_107(double a, float b);
                /*0x151b8b0*/ object <.ctor>b__0_108(double a, double b);
            }
        }

        class GreaterThanOrEqualHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x1505e20*/ GreaterThanOrEqualHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.GreaterThanOrEqualHandler.<> <>9;
                static /*0x8*/ System.Func<byte, byte, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, short, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, int, object> <>9__0_4;
                static /*0x30*/ System.Func<byte, uint, object> <>9__0_5;
                static /*0x38*/ System.Func<byte, long, object> <>9__0_6;
                static /*0x40*/ System.Func<byte, ulong, object> <>9__0_7;
                static /*0x48*/ System.Func<byte, float, object> <>9__0_8;
                static /*0x50*/ System.Func<byte, decimal, object> <>9__0_9;
                static /*0x58*/ System.Func<byte, double, object> <>9__0_10;
                static /*0x60*/ System.Func<sbyte, byte, object> <>9__0_11;
                static /*0x68*/ System.Func<sbyte, sbyte, object> <>9__0_12;
                static /*0x70*/ System.Func<sbyte, short, object> <>9__0_13;
                static /*0x78*/ System.Func<sbyte, ushort, object> <>9__0_14;
                static /*0x80*/ System.Func<sbyte, int, object> <>9__0_15;
                static /*0x88*/ System.Func<sbyte, uint, object> <>9__0_16;
                static /*0x90*/ System.Func<sbyte, long, object> <>9__0_17;
                static /*0x98*/ System.Func<sbyte, float, object> <>9__0_18;
                static /*0xa0*/ System.Func<sbyte, decimal, object> <>9__0_19;
                static /*0xa8*/ System.Func<sbyte, double, object> <>9__0_20;
                static /*0xb0*/ System.Func<short, byte, object> <>9__0_21;
                static /*0xb8*/ System.Func<short, sbyte, object> <>9__0_22;
                static /*0xc0*/ System.Func<short, short, object> <>9__0_23;
                static /*0xc8*/ System.Func<short, ushort, object> <>9__0_24;
                static /*0xd0*/ System.Func<short, int, object> <>9__0_25;
                static /*0xd8*/ System.Func<short, uint, object> <>9__0_26;
                static /*0xe0*/ System.Func<short, long, object> <>9__0_27;
                static /*0xe8*/ System.Func<short, float, object> <>9__0_28;
                static /*0xf0*/ System.Func<short, decimal, object> <>9__0_29;
                static /*0xf8*/ System.Func<short, double, object> <>9__0_30;
                static /*0x100*/ System.Func<ushort, byte, object> <>9__0_31;
                static /*0x108*/ System.Func<ushort, sbyte, object> <>9__0_32;
                static /*0x110*/ System.Func<ushort, short, object> <>9__0_33;
                static /*0x118*/ System.Func<ushort, ushort, object> <>9__0_34;
                static /*0x120*/ System.Func<ushort, int, object> <>9__0_35;
                static /*0x128*/ System.Func<ushort, uint, object> <>9__0_36;
                static /*0x130*/ System.Func<ushort, long, object> <>9__0_37;
                static /*0x138*/ System.Func<ushort, ulong, object> <>9__0_38;
                static /*0x140*/ System.Func<ushort, float, object> <>9__0_39;
                static /*0x148*/ System.Func<ushort, decimal, object> <>9__0_40;
                static /*0x150*/ System.Func<ushort, double, object> <>9__0_41;
                static /*0x158*/ System.Func<int, byte, object> <>9__0_42;
                static /*0x160*/ System.Func<int, sbyte, object> <>9__0_43;
                static /*0x168*/ System.Func<int, short, object> <>9__0_44;
                static /*0x170*/ System.Func<int, ushort, object> <>9__0_45;
                static /*0x178*/ System.Func<int, int, object> <>9__0_46;
                static /*0x180*/ System.Func<int, uint, object> <>9__0_47;
                static /*0x188*/ System.Func<int, long, object> <>9__0_48;
                static /*0x190*/ System.Func<int, float, object> <>9__0_49;
                static /*0x198*/ System.Func<int, decimal, object> <>9__0_50;
                static /*0x1a0*/ System.Func<int, double, object> <>9__0_51;
                static /*0x1a8*/ System.Func<uint, byte, object> <>9__0_52;
                static /*0x1b0*/ System.Func<uint, sbyte, object> <>9__0_53;
                static /*0x1b8*/ System.Func<uint, short, object> <>9__0_54;
                static /*0x1c0*/ System.Func<uint, ushort, object> <>9__0_55;
                static /*0x1c8*/ System.Func<uint, int, object> <>9__0_56;
                static /*0x1d0*/ System.Func<uint, uint, object> <>9__0_57;
                static /*0x1d8*/ System.Func<uint, long, object> <>9__0_58;
                static /*0x1e0*/ System.Func<uint, ulong, object> <>9__0_59;
                static /*0x1e8*/ System.Func<uint, float, object> <>9__0_60;
                static /*0x1f0*/ System.Func<uint, decimal, object> <>9__0_61;
                static /*0x1f8*/ System.Func<uint, double, object> <>9__0_62;
                static /*0x200*/ System.Func<long, byte, object> <>9__0_63;
                static /*0x208*/ System.Func<long, sbyte, object> <>9__0_64;
                static /*0x210*/ System.Func<long, short, object> <>9__0_65;
                static /*0x218*/ System.Func<long, ushort, object> <>9__0_66;
                static /*0x220*/ System.Func<long, int, object> <>9__0_67;
                static /*0x228*/ System.Func<long, uint, object> <>9__0_68;
                static /*0x230*/ System.Func<long, long, object> <>9__0_69;
                static /*0x238*/ System.Func<long, float, object> <>9__0_70;
                static /*0x240*/ System.Func<long, decimal, object> <>9__0_71;
                static /*0x248*/ System.Func<long, double, object> <>9__0_72;
                static /*0x250*/ System.Func<ulong, byte, object> <>9__0_73;
                static /*0x258*/ System.Func<ulong, ushort, object> <>9__0_74;
                static /*0x260*/ System.Func<ulong, uint, object> <>9__0_75;
                static /*0x268*/ System.Func<ulong, ulong, object> <>9__0_76;
                static /*0x270*/ System.Func<ulong, float, object> <>9__0_77;
                static /*0x278*/ System.Func<ulong, decimal, object> <>9__0_78;
                static /*0x280*/ System.Func<ulong, double, object> <>9__0_79;
                static /*0x288*/ System.Func<float, byte, object> <>9__0_80;
                static /*0x290*/ System.Func<float, sbyte, object> <>9__0_81;
                static /*0x298*/ System.Func<float, short, object> <>9__0_82;
                static /*0x2a0*/ System.Func<float, ushort, object> <>9__0_83;
                static /*0x2a8*/ System.Func<float, int, object> <>9__0_84;
                static /*0x2b0*/ System.Func<float, uint, object> <>9__0_85;
                static /*0x2b8*/ System.Func<float, long, object> <>9__0_86;
                static /*0x2c0*/ System.Func<float, ulong, object> <>9__0_87;
                static /*0x2c8*/ System.Func<float, float, object> <>9__0_88;
                static /*0x2d0*/ System.Func<float, double, object> <>9__0_89;
                static /*0x2d8*/ System.Func<decimal, byte, object> <>9__0_90;
                static /*0x2e0*/ System.Func<decimal, sbyte, object> <>9__0_91;
                static /*0x2e8*/ System.Func<decimal, short, object> <>9__0_92;
                static /*0x2f0*/ System.Func<decimal, ushort, object> <>9__0_93;
                static /*0x2f8*/ System.Func<decimal, int, object> <>9__0_94;
                static /*0x300*/ System.Func<decimal, uint, object> <>9__0_95;
                static /*0x308*/ System.Func<decimal, long, object> <>9__0_96;
                static /*0x310*/ System.Func<decimal, ulong, object> <>9__0_97;
                static /*0x318*/ System.Func<decimal, decimal, object> <>9__0_98;
                static /*0x320*/ System.Func<double, byte, object> <>9__0_99;
                static /*0x328*/ System.Func<double, sbyte, object> <>9__0_100;
                static /*0x330*/ System.Func<double, short, object> <>9__0_101;
                static /*0x338*/ System.Func<double, ushort, object> <>9__0_102;
                static /*0x340*/ System.Func<double, int, object> <>9__0_103;
                static /*0x348*/ System.Func<double, uint, object> <>9__0_104;
                static /*0x350*/ System.Func<double, long, object> <>9__0_105;
                static /*0x358*/ System.Func<double, ulong, object> <>9__0_106;
                static /*0x360*/ System.Func<double, float, object> <>9__0_107;
                static /*0x368*/ System.Func<double, double, object> <>9__0_108;

                static /*0x1528060*/ <>c();
                /*0x32f970*/ <>c();
                /*0x151a860*/ object <.ctor>b__0_0(byte a, byte b);
                /*0x151d200*/ object <.ctor>b__0_1(byte a, sbyte b);
                /*0x151ea10*/ object <.ctor>b__0_2(byte a, short b);
                /*0x15202a0*/ object <.ctor>b__0_3(byte a, ushort b);
                /*0x1521510*/ object <.ctor>b__0_4(byte a, int b);
                /*0x1522960*/ object <.ctor>b__0_5(byte a, uint b);
                /*0x1523a80*/ object <.ctor>b__0_6(byte a, long b);
                /*0x1524da0*/ object <.ctor>b__0_7(byte a, ulong b);
                /*0x15262b0*/ object <.ctor>b__0_8(byte a, float b);
                /*0x1527c90*/ object <.ctor>b__0_9(byte a, decimal b);
                /*0x151b9d0*/ object <.ctor>b__0_10(byte a, double b);
                /*0x151bc30*/ object <.ctor>b__0_11(sbyte a, byte b);
                /*0x151bf30*/ object <.ctor>b__0_12(sbyte a, sbyte b);
                /*0x151c220*/ object <.ctor>b__0_13(sbyte a, short b);
                /*0x151c3e0*/ object <.ctor>b__0_14(sbyte a, ushort b);
                /*0x151c480*/ object <.ctor>b__0_15(sbyte a, int b);
                /*0x151c6e0*/ object <.ctor>b__0_16(sbyte a, uint b);
                /*0x151c970*/ object <.ctor>b__0_17(sbyte a, long b);
                /*0x151cae0*/ object <.ctor>b__0_18(sbyte a, float b);
                /*0x151cfc0*/ object <.ctor>b__0_19(sbyte a, decimal b);
                /*0x151d300*/ object <.ctor>b__0_20(sbyte a, double b);
                /*0x151d5b0*/ object <.ctor>b__0_21(short a, byte b);
                /*0x151d850*/ object <.ctor>b__0_22(short a, sbyte b);
                /*0x151d9d0*/ object <.ctor>b__0_23(short a, short b);
                /*0x151dce0*/ object <.ctor>b__0_24(short a, ushort b);
                /*0x151de30*/ object <.ctor>b__0_25(short a, int b);
                /*0x151e090*/ object <.ctor>b__0_26(short a, uint b);
                /*0x151e1b0*/ object <.ctor>b__0_27(short a, long b);
                /*0x151e5d0*/ object <.ctor>b__0_28(short a, float b);
                /*0x151e8c0*/ object <.ctor>b__0_29(short a, decimal b);
                /*0x151ecb0*/ object <.ctor>b__0_30(short a, double b);
                /*0x151eef0*/ object <.ctor>b__0_31(ushort a, byte b);
                /*0x151f060*/ object <.ctor>b__0_32(ushort a, sbyte b);
                /*0x151f2a0*/ object <.ctor>b__0_33(ushort a, short b);
                /*0x151f550*/ object <.ctor>b__0_34(ushort a, ushort b);
                /*0x151f6c0*/ object <.ctor>b__0_35(ushort a, int b);
                /*0x151f8b0*/ object <.ctor>b__0_36(ushort a, uint b);
                /*0x151fb50*/ object <.ctor>b__0_37(ushort a, long b);
                /*0x151fc90*/ object <.ctor>b__0_38(ushort a, ulong b);
                /*0x151ffc0*/ object <.ctor>b__0_39(ushort a, float b);
                /*0x1520300*/ object <.ctor>b__0_40(ushort a, decimal b);
                /*0x15206f0*/ object <.ctor>b__0_41(ushort a, double b);
                /*0x1520860*/ object <.ctor>b__0_42(int a, byte b);
                /*0x1520a90*/ object <.ctor>b__0_43(int a, sbyte b);
                /*0x1520b80*/ object <.ctor>b__0_44(int a, short b);
                /*0x1520d60*/ object <.ctor>b__0_45(int a, ushort b);
                /*0x1520e60*/ object <.ctor>b__0_46(int a, int b);
                /*0x15210f0*/ object <.ctor>b__0_47(int a, uint b);
                /*0x15211f0*/ object <.ctor>b__0_48(int a, long b);
                /*0x15212e0*/ object <.ctor>b__0_49(int a, float b);
                /*0x1521930*/ object <.ctor>b__0_50(int a, decimal b);
                /*0x15219d0*/ object <.ctor>b__0_51(int a, double b);
                /*0x1521c10*/ object <.ctor>b__0_52(uint a, byte b);
                /*0x1521da0*/ object <.ctor>b__0_53(uint a, sbyte b);
                /*0x1521ff0*/ object <.ctor>b__0_54(uint a, short b);
                /*0x1522130*/ object <.ctor>b__0_55(uint a, ushort b);
                /*0x15222c0*/ object <.ctor>b__0_56(uint a, int b);
                /*0x1522400*/ object <.ctor>b__0_57(uint a, uint b);
                /*0x15224f0*/ object <.ctor>b__0_58(uint a, long b);
                /*0x1522630*/ object <.ctor>b__0_59(uint a, ulong b);
                /*0x1522a20*/ object <.ctor>b__0_60(uint a, float b);
                /*0x1522b50*/ object <.ctor>b__0_61(uint a, decimal b);
                /*0x1522e40*/ object <.ctor>b__0_62(uint a, double b);
                /*0x1522fd0*/ object <.ctor>b__0_63(long a, byte b);
                /*0x1523210*/ object <.ctor>b__0_64(long a, sbyte b);
                /*0x1523330*/ object <.ctor>b__0_65(long a, short b);
                /*0x15233f0*/ object <.ctor>b__0_66(long a, ushort b);
                /*0x1523610*/ object <.ctor>b__0_67(long a, int b);
                /*0x15236b0*/ object <.ctor>b__0_68(long a, uint b);
                /*0x1523890*/ object <.ctor>b__0_69(long a, long b);
                /*0x1523b70*/ object <.ctor>b__0_70(long a, float b);
                /*0x1523ef0*/ object <.ctor>b__0_71(long a, decimal b);
                /*0x15240d0*/ object <.ctor>b__0_72(long a, double b);
                /*0x15241f0*/ object <.ctor>b__0_73(ulong a, byte b);
                /*0x1524310*/ object <.ctor>b__0_74(ulong a, ushort b);
                /*0x1524520*/ object <.ctor>b__0_75(ulong a, uint b);
                /*0x1524570*/ object <.ctor>b__0_76(ulong a, ulong b);
                /*0x1524850*/ object <.ctor>b__0_77(ulong a, float b);
                /*0x15248d0*/ object <.ctor>b__0_78(ulong a, decimal b);
                /*0x1524c50*/ object <.ctor>b__0_79(ulong a, double b);
                /*0x1524ff0*/ object <.ctor>b__0_80(float a, byte b);
                /*0x15251a0*/ object <.ctor>b__0_81(float a, sbyte b);
                /*0x15253b0*/ object <.ctor>b__0_82(float a, short b);
                /*0x15254e0*/ object <.ctor>b__0_83(float a, ushort b);
                /*0x15256e0*/ object <.ctor>b__0_84(float a, int b);
                /*0x15258f0*/ object <.ctor>b__0_85(float a, uint b);
                /*0x1525950*/ object <.ctor>b__0_86(float a, long b);
                /*0x1525c90*/ object <.ctor>b__0_87(float a, ulong b);
                /*0x1525de0*/ object <.ctor>b__0_88(float a, float b);
                /*0x1526000*/ object <.ctor>b__0_89(float a, double b);
                /*0x15264f0*/ object <.ctor>b__0_90(decimal a, byte b);
                /*0x15266d0*/ object <.ctor>b__0_91(decimal a, sbyte b);
                /*0x15268b0*/ object <.ctor>b__0_92(decimal a, short b);
                /*0x1526c70*/ object <.ctor>b__0_93(decimal a, ushort b);
                /*0x1526db0*/ object <.ctor>b__0_94(decimal a, int b);
                /*0x1527030*/ object <.ctor>b__0_95(decimal a, uint b);
                /*0x15272b0*/ object <.ctor>b__0_96(decimal a, long b);
                /*0x1527490*/ object <.ctor>b__0_97(decimal a, ulong b);
                /*0x1527830*/ object <.ctor>b__0_98(decimal a, decimal b);
                /*0x15279c0*/ object <.ctor>b__0_99(double a, byte b);
                /*0x151aae0*/ object <.ctor>b__0_100(double a, sbyte b);
                /*0x151acf0*/ object <.ctor>b__0_101(double a, short b);
                /*0x151ae30*/ object <.ctor>b__0_102(double a, ushort b);
                /*0x151afc0*/ object <.ctor>b__0_103(double a, int b);
                /*0x151b1e0*/ object <.ctor>b__0_104(double a, uint b);
                /*0x151b2a0*/ object <.ctor>b__0_105(double a, long b);
                /*0x151b440*/ object <.ctor>b__0_106(double a, ulong b);
                /*0x151b640*/ object <.ctor>b__0_107(double a, float b);
                /*0x151b850*/ object <.ctor>b__0_108(double a, double b);
            }
        }

        class IncrementHandler : Unity.VisualScripting.UnaryOperatorHandler
        {
            /*0x150bbf0*/ IncrementHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.IncrementHandler.<> <>9;
                static /*0x8*/ System.Func<byte, object> <>9__0_0;
                static /*0x10*/ System.Func<sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<short, object> <>9__0_2;
                static /*0x20*/ System.Func<ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<int, object> <>9__0_4;
                static /*0x30*/ System.Func<uint, object> <>9__0_5;
                static /*0x38*/ System.Func<long, object> <>9__0_6;
                static /*0x40*/ System.Func<ulong, object> <>9__0_7;
                static /*0x48*/ System.Func<float, object> <>9__0_8;
                static /*0x50*/ System.Func<decimal, object> <>9__0_9;
                static /*0x58*/ System.Func<double, object> <>9__0_10;

                static /*0x1527f80*/ <>c();
                /*0x32f970*/ <>c();
                /*0x151a970*/ object <.ctor>b__0_0(byte a);
                /*0x151d160*/ object <.ctor>b__0_1(sbyte a);
                /*0x151ea70*/ object <.ctor>b__0_2(short a);
                /*0x1520080*/ object <.ctor>b__0_3(ushort a);
                /*0x1521650*/ object <.ctor>b__0_4(int a);
                /*0x1522910*/ object <.ctor>b__0_5(uint a);
                /*0x1523a30*/ object <.ctor>b__0_6(long a);
                /*0x1524e40*/ object <.ctor>b__0_7(ulong a);
                /*0x15261a0*/ object <.ctor>b__0_8(float a);
                /*0x1527d30*/ object <.ctor>b__0_9(decimal a);
                /*0x151baf0*/ object <.ctor>b__0_10(double a);
            }
        }

        class InequalityHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x150c670*/ InequalityHandler();
            /*0x150c590*/ object BothNullHandling();
            /*0x150c630*/ object SingleNullHandling();
            /*0x150c5d0*/ object CustomHandling(object leftOperand, object rightOperand);

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.InequalityHandler.<> <>9;
                static /*0x8*/ System.Func<byte, byte, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, short, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, int, object> <>9__0_4;
                static /*0x30*/ System.Func<byte, uint, object> <>9__0_5;
                static /*0x38*/ System.Func<byte, long, object> <>9__0_6;
                static /*0x40*/ System.Func<byte, ulong, object> <>9__0_7;
                static /*0x48*/ System.Func<byte, float, object> <>9__0_8;
                static /*0x50*/ System.Func<byte, decimal, object> <>9__0_9;
                static /*0x58*/ System.Func<byte, double, object> <>9__0_10;
                static /*0x60*/ System.Func<sbyte, byte, object> <>9__0_11;
                static /*0x68*/ System.Func<sbyte, sbyte, object> <>9__0_12;
                static /*0x70*/ System.Func<sbyte, short, object> <>9__0_13;
                static /*0x78*/ System.Func<sbyte, ushort, object> <>9__0_14;
                static /*0x80*/ System.Func<sbyte, int, object> <>9__0_15;
                static /*0x88*/ System.Func<sbyte, uint, object> <>9__0_16;
                static /*0x90*/ System.Func<sbyte, long, object> <>9__0_17;
                static /*0x98*/ System.Func<sbyte, float, object> <>9__0_18;
                static /*0xa0*/ System.Func<sbyte, decimal, object> <>9__0_19;
                static /*0xa8*/ System.Func<sbyte, double, object> <>9__0_20;
                static /*0xb0*/ System.Func<short, byte, object> <>9__0_21;
                static /*0xb8*/ System.Func<short, sbyte, object> <>9__0_22;
                static /*0xc0*/ System.Func<short, short, object> <>9__0_23;
                static /*0xc8*/ System.Func<short, ushort, object> <>9__0_24;
                static /*0xd0*/ System.Func<short, int, object> <>9__0_25;
                static /*0xd8*/ System.Func<short, uint, object> <>9__0_26;
                static /*0xe0*/ System.Func<short, long, object> <>9__0_27;
                static /*0xe8*/ System.Func<short, float, object> <>9__0_28;
                static /*0xf0*/ System.Func<short, decimal, object> <>9__0_29;
                static /*0xf8*/ System.Func<short, double, object> <>9__0_30;
                static /*0x100*/ System.Func<ushort, byte, object> <>9__0_31;
                static /*0x108*/ System.Func<ushort, sbyte, object> <>9__0_32;
                static /*0x110*/ System.Func<ushort, short, object> <>9__0_33;
                static /*0x118*/ System.Func<ushort, ushort, object> <>9__0_34;
                static /*0x120*/ System.Func<ushort, int, object> <>9__0_35;
                static /*0x128*/ System.Func<ushort, uint, object> <>9__0_36;
                static /*0x130*/ System.Func<ushort, long, object> <>9__0_37;
                static /*0x138*/ System.Func<ushort, ulong, object> <>9__0_38;
                static /*0x140*/ System.Func<ushort, float, object> <>9__0_39;
                static /*0x148*/ System.Func<ushort, decimal, object> <>9__0_40;
                static /*0x150*/ System.Func<ushort, double, object> <>9__0_41;
                static /*0x158*/ System.Func<int, byte, object> <>9__0_42;
                static /*0x160*/ System.Func<int, sbyte, object> <>9__0_43;
                static /*0x168*/ System.Func<int, short, object> <>9__0_44;
                static /*0x170*/ System.Func<int, ushort, object> <>9__0_45;
                static /*0x178*/ System.Func<int, int, object> <>9__0_46;
                static /*0x180*/ System.Func<int, uint, object> <>9__0_47;
                static /*0x188*/ System.Func<int, long, object> <>9__0_48;
                static /*0x190*/ System.Func<int, float, object> <>9__0_49;
                static /*0x198*/ System.Func<int, decimal, object> <>9__0_50;
                static /*0x1a0*/ System.Func<int, double, object> <>9__0_51;
                static /*0x1a8*/ System.Func<uint, byte, object> <>9__0_52;
                static /*0x1b0*/ System.Func<uint, sbyte, object> <>9__0_53;
                static /*0x1b8*/ System.Func<uint, short, object> <>9__0_54;
                static /*0x1c0*/ System.Func<uint, ushort, object> <>9__0_55;
                static /*0x1c8*/ System.Func<uint, int, object> <>9__0_56;
                static /*0x1d0*/ System.Func<uint, uint, object> <>9__0_57;
                static /*0x1d8*/ System.Func<uint, long, object> <>9__0_58;
                static /*0x1e0*/ System.Func<uint, ulong, object> <>9__0_59;
                static /*0x1e8*/ System.Func<uint, float, object> <>9__0_60;
                static /*0x1f0*/ System.Func<uint, decimal, object> <>9__0_61;
                static /*0x1f8*/ System.Func<uint, double, object> <>9__0_62;
                static /*0x200*/ System.Func<long, byte, object> <>9__0_63;
                static /*0x208*/ System.Func<long, sbyte, object> <>9__0_64;
                static /*0x210*/ System.Func<long, short, object> <>9__0_65;
                static /*0x218*/ System.Func<long, ushort, object> <>9__0_66;
                static /*0x220*/ System.Func<long, int, object> <>9__0_67;
                static /*0x228*/ System.Func<long, uint, object> <>9__0_68;
                static /*0x230*/ System.Func<long, long, object> <>9__0_69;
                static /*0x238*/ System.Func<long, float, object> <>9__0_70;
                static /*0x240*/ System.Func<long, decimal, object> <>9__0_71;
                static /*0x248*/ System.Func<long, double, object> <>9__0_72;
                static /*0x250*/ System.Func<ulong, byte, object> <>9__0_73;
                static /*0x258*/ System.Func<ulong, ushort, object> <>9__0_74;
                static /*0x260*/ System.Func<ulong, uint, object> <>9__0_75;
                static /*0x268*/ System.Func<ulong, ulong, object> <>9__0_76;
                static /*0x270*/ System.Func<ulong, float, object> <>9__0_77;
                static /*0x278*/ System.Func<ulong, decimal, object> <>9__0_78;
                static /*0x280*/ System.Func<ulong, double, object> <>9__0_79;
                static /*0x288*/ System.Func<float, byte, object> <>9__0_80;
                static /*0x290*/ System.Func<float, sbyte, object> <>9__0_81;
                static /*0x298*/ System.Func<float, short, object> <>9__0_82;
                static /*0x2a0*/ System.Func<float, ushort, object> <>9__0_83;
                static /*0x2a8*/ System.Func<float, int, object> <>9__0_84;
                static /*0x2b0*/ System.Func<float, uint, object> <>9__0_85;
                static /*0x2b8*/ System.Func<float, long, object> <>9__0_86;
                static /*0x2c0*/ System.Func<float, ulong, object> <>9__0_87;
                static /*0x2c8*/ System.Func<float, float, object> <>9__0_88;
                static /*0x2d0*/ System.Func<float, double, object> <>9__0_89;
                static /*0x2d8*/ System.Func<decimal, byte, object> <>9__0_90;
                static /*0x2e0*/ System.Func<decimal, sbyte, object> <>9__0_91;
                static /*0x2e8*/ System.Func<decimal, short, object> <>9__0_92;
                static /*0x2f0*/ System.Func<decimal, ushort, object> <>9__0_93;
                static /*0x2f8*/ System.Func<decimal, int, object> <>9__0_94;
                static /*0x300*/ System.Func<decimal, uint, object> <>9__0_95;
                static /*0x308*/ System.Func<decimal, long, object> <>9__0_96;
                static /*0x310*/ System.Func<decimal, ulong, object> <>9__0_97;
                static /*0x318*/ System.Func<decimal, decimal, object> <>9__0_98;
                static /*0x320*/ System.Func<double, byte, object> <>9__0_99;
                static /*0x328*/ System.Func<double, sbyte, object> <>9__0_100;
                static /*0x330*/ System.Func<double, short, object> <>9__0_101;
                static /*0x338*/ System.Func<double, ushort, object> <>9__0_102;
                static /*0x340*/ System.Func<double, int, object> <>9__0_103;
                static /*0x348*/ System.Func<double, uint, object> <>9__0_104;
                static /*0x350*/ System.Func<double, long, object> <>9__0_105;
                static /*0x358*/ System.Func<double, ulong, object> <>9__0_106;
                static /*0x360*/ System.Func<double, float, object> <>9__0_107;
                static /*0x368*/ System.Func<double, double, object> <>9__0_108;

                static /*0x1527f10*/ <>c();
                /*0x32f970*/ <>c();
                /*0x151aa20*/ object <.ctor>b__0_0(byte a, byte b);
                /*0x151d0c0*/ object <.ctor>b__0_1(byte a, sbyte b);
                /*0x151eac0*/ object <.ctor>b__0_2(byte a, short b);
                /*0x15201f0*/ object <.ctor>b__0_3(byte a, ushort b);
                /*0x1521560*/ object <.ctor>b__0_4(byte a, int b);
                /*0x1522810*/ object <.ctor>b__0_5(byte a, uint b);
                /*0x15239e0*/ object <.ctor>b__0_6(byte a, long b);
                /*0x1524e90*/ object <.ctor>b__0_7(byte a, ulong b);
                /*0x1526130*/ object <.ctor>b__0_8(byte a, float b);
                /*0x1527bf0*/ object <.ctor>b__0_9(byte a, decimal b);
                /*0x151bbc0*/ object <.ctor>b__0_10(byte a, double b);
                /*0x151bc80*/ object <.ctor>b__0_11(sbyte a, byte b);
                /*0x151be20*/ object <.ctor>b__0_12(sbyte a, sbyte b);
                /*0x151c110*/ object <.ctor>b__0_13(sbyte a, short b);
                /*0x151c340*/ object <.ctor>b__0_14(sbyte a, ushort b);
                /*0x151c580*/ object <.ctor>b__0_15(sbyte a, int b);
                /*0x151c800*/ object <.ctor>b__0_16(sbyte a, uint b);
                /*0x151c910*/ object <.ctor>b__0_17(sbyte a, long b);
                /*0x151ccc0*/ object <.ctor>b__0_18(sbyte a, float b);
                /*0x151cf20*/ object <.ctor>b__0_19(sbyte a, decimal b);
                /*0x151d360*/ object <.ctor>b__0_20(sbyte a, double b);
                /*0x151d610*/ object <.ctor>b__0_21(short a, byte b);
                /*0x151d7f0*/ object <.ctor>b__0_22(short a, sbyte b);
                /*0x151db40*/ object <.ctor>b__0_23(short a, short b);
                /*0x151dbf0*/ object <.ctor>b__0_24(short a, ushort b);
                /*0x151dde0*/ object <.ctor>b__0_25(short a, int b);
                /*0x151dfd0*/ object <.ctor>b__0_26(short a, uint b);
                /*0x151e380*/ object <.ctor>b__0_27(short a, long b);
                /*0x151e4f0*/ object <.ctor>b__0_28(short a, float b);
                /*0x151e820*/ object <.ctor>b__0_29(short a, decimal b);
                /*0x151edc0*/ object <.ctor>b__0_30(short a, double b);
                /*0x151ee30*/ object <.ctor>b__0_31(ushort a, byte b);
                /*0x151f100*/ object <.ctor>b__0_32(ushort a, sbyte b);
                /*0x151f250*/ object <.ctor>b__0_33(ushort a, short b);
                /*0x151f610*/ object <.ctor>b__0_34(ushort a, ushort b);
                /*0x151f670*/ object <.ctor>b__0_35(ushort a, int b);
                /*0x151f860*/ object <.ctor>b__0_36(ushort a, uint b);
                /*0x151fb00*/ object <.ctor>b__0_37(ushort a, long b);
                /*0x151fde0*/ object <.ctor>b__0_38(ushort a, ulong b);
                /*0x151ff50*/ object <.ctor>b__0_39(ushort a, float b);
                /*0x1520530*/ object <.ctor>b__0_40(ushort a, decimal b);
                /*0x15205d0*/ object <.ctor>b__0_41(ushort a, double b);
                /*0x15208b0*/ object <.ctor>b__0_42(int a, byte b);
                /*0x1520950*/ object <.ctor>b__0_43(int a, sbyte b);
                /*0x1520bd0*/ object <.ctor>b__0_44(int a, short b);
                /*0x1520cc0*/ object <.ctor>b__0_45(int a, ushort b);
                /*0x1520f50*/ object <.ctor>b__0_46(int a, int b);
                /*0x1520ff0*/ object <.ctor>b__0_47(int a, uint b);
                /*0x1521140*/ object <.ctor>b__0_48(int a, long b);
                /*0x1521400*/ object <.ctor>b__0_49(int a, float b);
                /*0x15217f0*/ object <.ctor>b__0_50(int a, decimal b);
                /*0x1521aa0*/ object <.ctor>b__0_51(int a, double b);
                /*0x1521cb0*/ object <.ctor>b__0_52(uint a, byte b);
                /*0x1521ea0*/ object <.ctor>b__0_53(uint a, sbyte b);
                /*0x1522040*/ object <.ctor>b__0_54(uint a, short b);
                /*0x15220e0*/ object <.ctor>b__0_55(uint a, ushort b);
                /*0x1522360*/ object <.ctor>b__0_56(uint a, int b);
                /*0x15224a0*/ object <.ctor>b__0_57(uint a, uint b);
                /*0x1522540*/ object <.ctor>b__0_58(uint a, long b);
                /*0x1522680*/ object <.ctor>b__0_59(uint a, ulong b);
                /*0x1522a80*/ object <.ctor>b__0_60(uint a, float b);
                /*0x1522bf0*/ object <.ctor>b__0_61(uint a, decimal b);
                /*0x1522dd0*/ object <.ctor>b__0_62(uint a, double b);
                /*0x1523090*/ object <.ctor>b__0_63(long a, byte b);
                /*0x1523150*/ object <.ctor>b__0_64(long a, sbyte b);
                /*0x1523270*/ object <.ctor>b__0_65(long a, short b);
                /*0x15234b0*/ object <.ctor>b__0_66(long a, ushort b);
                /*0x1523660*/ object <.ctor>b__0_67(long a, int b);
                /*0x1523700*/ object <.ctor>b__0_68(long a, uint b);
                /*0x15237f0*/ object <.ctor>b__0_69(long a, long b);
                /*0x1523c40*/ object <.ctor>b__0_70(long a, float b);
                /*0x1523e50*/ object <.ctor>b__0_71(long a, decimal b);
                /*0x1524060*/ object <.ctor>b__0_72(long a, double b);
                /*0x1524190*/ object <.ctor>b__0_73(ulong a, byte b);
                /*0x15242b0*/ object <.ctor>b__0_74(ulong a, ushort b);
                /*0x15244d0*/ object <.ctor>b__0_75(ulong a, uint b);
                /*0x1524660*/ object <.ctor>b__0_76(ulong a, ulong b);
                /*0x1524730*/ object <.ctor>b__0_77(ulong a, float b);
                /*0x1524ab0*/ object <.ctor>b__0_78(ulong a, decimal b);
                /*0x1524cd0*/ object <.ctor>b__0_79(ulong a, double b);
                /*0x15250c0*/ object <.ctor>b__0_80(float a, byte b);
                /*0x1525130*/ object <.ctor>b__0_81(float a, sbyte b);
                /*0x1525340*/ object <.ctor>b__0_82(float a, short b);
                /*0x1525470*/ object <.ctor>b__0_83(float a, ushort b);
                /*0x1525610*/ object <.ctor>b__0_84(float a, int b);
                /*0x15257b0*/ object <.ctor>b__0_85(float a, uint b);
                /*0x1525a80*/ object <.ctor>b__0_86(float a, long b);
                /*0x1525af0*/ object <.ctor>b__0_87(float a, ulong b);
                /*0x1525e50*/ object <.ctor>b__0_88(float a, float b);
                /*0x1525f90*/ object <.ctor>b__0_89(float a, double b);
                /*0x1526310*/ object <.ctor>b__0_90(decimal a, byte b);
                /*0x1526770*/ object <.ctor>b__0_91(decimal a, sbyte b);
                /*0x1526810*/ object <.ctor>b__0_92(decimal a, short b);
                /*0x1526bd0*/ object <.ctor>b__0_93(decimal a, ushort b);
                /*0x1526e50*/ object <.ctor>b__0_94(decimal a, int b);
                /*0x1527170*/ object <.ctor>b__0_95(decimal a, uint b);
                /*0x15273f0*/ object <.ctor>b__0_96(decimal a, long b);
                /*0x1527670*/ object <.ctor>b__0_97(decimal a, ulong b);
                /*0x15278c0*/ object <.ctor>b__0_98(decimal a, decimal b);
                /*0x1527a20*/ object <.ctor>b__0_99(double a, byte b);
                /*0x151ab40*/ object <.ctor>b__0_100(double a, sbyte b);
                /*0x151ac20*/ object <.ctor>b__0_101(double a, short b);
                /*0x151adc0*/ object <.ctor>b__0_102(double a, ushort b);
                /*0x151b090*/ object <.ctor>b__0_103(double a, int b);
                /*0x151b170*/ object <.ctor>b__0_104(double a, uint b);
                /*0x151b3d0*/ object <.ctor>b__0_105(double a, long b);
                /*0x151b540*/ object <.ctor>b__0_106(double a, ulong b);
                /*0x151b6a0*/ object <.ctor>b__0_107(double a, float b);
                /*0x151b910*/ object <.ctor>b__0_108(double a, double b);
            }
        }

        class InvalidOperatorException : Unity.VisualScripting.OperatorException
        {
            /*0x1512450*/ InvalidOperatorException(string symbol, System.Type type);
            /*0x15125c0*/ InvalidOperatorException(string symbol, System.Type leftType, System.Type rightType);
        }

        class LeftShiftHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x15127b0*/ LeftShiftHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.LeftShiftHandler.<> <>9;
                static /*0x8*/ System.Func<byte, byte, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, short, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, int, object> <>9__0_4;
                static /*0x30*/ System.Func<sbyte, byte, object> <>9__0_5;
                static /*0x38*/ System.Func<sbyte, sbyte, object> <>9__0_6;
                static /*0x40*/ System.Func<sbyte, short, object> <>9__0_7;
                static /*0x48*/ System.Func<sbyte, ushort, object> <>9__0_8;
                static /*0x50*/ System.Func<sbyte, int, object> <>9__0_9;
                static /*0x58*/ System.Func<short, byte, object> <>9__0_10;
                static /*0x60*/ System.Func<short, sbyte, object> <>9__0_11;
                static /*0x68*/ System.Func<short, short, object> <>9__0_12;
                static /*0x70*/ System.Func<short, ushort, object> <>9__0_13;
                static /*0x78*/ System.Func<short, int, object> <>9__0_14;
                static /*0x80*/ System.Func<ushort, byte, object> <>9__0_15;
                static /*0x88*/ System.Func<ushort, sbyte, object> <>9__0_16;
                static /*0x90*/ System.Func<ushort, short, object> <>9__0_17;
                static /*0x98*/ System.Func<ushort, ushort, object> <>9__0_18;
                static /*0xa0*/ System.Func<ushort, int, object> <>9__0_19;
                static /*0xa8*/ System.Func<int, byte, object> <>9__0_20;
                static /*0xb0*/ System.Func<int, sbyte, object> <>9__0_21;
                static /*0xb8*/ System.Func<int, short, object> <>9__0_22;
                static /*0xc0*/ System.Func<int, ushort, object> <>9__0_23;
                static /*0xc8*/ System.Func<int, int, object> <>9__0_24;
                static /*0xd0*/ System.Func<uint, byte, object> <>9__0_25;
                static /*0xd8*/ System.Func<uint, sbyte, object> <>9__0_26;
                static /*0xe0*/ System.Func<uint, short, object> <>9__0_27;
                static /*0xe8*/ System.Func<uint, ushort, object> <>9__0_28;
                static /*0xf0*/ System.Func<uint, int, object> <>9__0_29;
                static /*0xf8*/ System.Func<long, byte, object> <>9__0_30;
                static /*0x100*/ System.Func<long, sbyte, object> <>9__0_31;
                static /*0x108*/ System.Func<long, short, object> <>9__0_32;
                static /*0x110*/ System.Func<long, ushort, object> <>9__0_33;
                static /*0x118*/ System.Func<long, int, object> <>9__0_34;
                static /*0x120*/ System.Func<ulong, byte, object> <>9__0_35;
                static /*0x128*/ System.Func<ulong, sbyte, object> <>9__0_36;
                static /*0x130*/ System.Func<ulong, short, object> <>9__0_37;
                static /*0x138*/ System.Func<ulong, ushort, object> <>9__0_38;
                static /*0x140*/ System.Func<ulong, int, object> <>9__0_39;

                static /*0x1527ea0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x151a800*/ object <.ctor>b__0_0(byte a, byte b);
                /*0x151d060*/ object <.ctor>b__0_1(byte a, sbyte b);
                /*0x151e960*/ object <.ctor>b__0_2(byte a, short b);
                /*0x1520130*/ object <.ctor>b__0_3(byte a, ushort b);
                /*0x15216a0*/ object <.ctor>b__0_4(byte a, int b);
                /*0x15228b0*/ object <.ctor>b__0_5(sbyte a, byte b);
                /*0x1523980*/ object <.ctor>b__0_6(sbyte a, sbyte b);
                /*0x1524ee0*/ object <.ctor>b__0_7(sbyte a, short b);
                /*0x1526060*/ object <.ctor>b__0_8(sbyte a, ushort b);
                /*0x1527b90*/ object <.ctor>b__0_9(sbyte a, int b);
                /*0x151ba30*/ object <.ctor>b__0_10(short a, byte b);
                /*0x151bd70*/ object <.ctor>b__0_11(short a, sbyte b);
                /*0x151bed0*/ object <.ctor>b__0_12(short a, short b);
                /*0x151c0b0*/ object <.ctor>b__0_13(short a, ushort b);
                /*0x151c280*/ object <.ctor>b__0_14(short a, int b);
                /*0x151c4d0*/ object <.ctor>b__0_15(ushort a, byte b);
                /*0x151c680*/ object <.ctor>b__0_16(ushort a, sbyte b);
                /*0x151ca20*/ object <.ctor>b__0_17(ushort a, short b);
                /*0x151cba0*/ object <.ctor>b__0_18(ushort a, ushort b);
                /*0x151cdd0*/ object <.ctor>b__0_19(ushort a, int b);
                /*0x151d2a0*/ object <.ctor>b__0_20(int a, byte b);
                /*0x151d6d0*/ object <.ctor>b__0_21(int a, sbyte b);
                /*0x151d8b0*/ object <.ctor>b__0_22(int a, short b);
                /*0x151d970*/ object <.ctor>b__0_23(int a, ushort b);
                /*0x151dd30*/ object <.ctor>b__0_24(int a, int b);
                /*0x151ded0*/ object <.ctor>b__0_25(uint a, byte b);
                /*0x151e0f0*/ object <.ctor>b__0_26(uint a, sbyte b);
                /*0x151e320*/ object <.ctor>b__0_27(uint a, short b);
                /*0x151e3e0*/ object <.ctor>b__0_28(uint a, ushort b);
                /*0x151e7c0*/ object <.ctor>b__0_29(uint a, int b);
                /*0x151ed10*/ object <.ctor>b__0_30(long a, byte b);
                /*0x151ef50*/ object <.ctor>b__0_31(long a, sbyte b);
                /*0x151f1a0*/ object <.ctor>b__0_32(long a, short b);
                /*0x151f390*/ object <.ctor>b__0_33(long a, ushort b);
                /*0x151f4f0*/ object <.ctor>b__0_34(long a, int b);
                /*0x151f7b0*/ object <.ctor>b__0_35(ulong a, byte b);
                /*0x151f900*/ object <.ctor>b__0_36(ulong a, sbyte b);
                /*0x151faa0*/ object <.ctor>b__0_37(ulong a, short b);
                /*0x151fce0*/ object <.ctor>b__0_38(ulong a, ushort b);
                /*0x151fef0*/ object <.ctor>b__0_39(ulong a, int b);
            }
        }

        class LessThanHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x1514a30*/ LessThanHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.LessThanHandler.<> <>9;
                static /*0x8*/ System.Func<byte, byte, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, short, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, int, object> <>9__0_4;
                static /*0x30*/ System.Func<byte, uint, object> <>9__0_5;
                static /*0x38*/ System.Func<byte, long, object> <>9__0_6;
                static /*0x40*/ System.Func<byte, ulong, object> <>9__0_7;
                static /*0x48*/ System.Func<byte, float, object> <>9__0_8;
                static /*0x50*/ System.Func<byte, decimal, object> <>9__0_9;
                static /*0x58*/ System.Func<byte, double, object> <>9__0_10;
                static /*0x60*/ System.Func<sbyte, byte, object> <>9__0_11;
                static /*0x68*/ System.Func<sbyte, sbyte, object> <>9__0_12;
                static /*0x70*/ System.Func<sbyte, short, object> <>9__0_13;
                static /*0x78*/ System.Func<sbyte, ushort, object> <>9__0_14;
                static /*0x80*/ System.Func<sbyte, int, object> <>9__0_15;
                static /*0x88*/ System.Func<sbyte, uint, object> <>9__0_16;
                static /*0x90*/ System.Func<sbyte, long, object> <>9__0_17;
                static /*0x98*/ System.Func<sbyte, float, object> <>9__0_18;
                static /*0xa0*/ System.Func<sbyte, decimal, object> <>9__0_19;
                static /*0xa8*/ System.Func<sbyte, double, object> <>9__0_20;
                static /*0xb0*/ System.Func<short, byte, object> <>9__0_21;
                static /*0xb8*/ System.Func<short, sbyte, object> <>9__0_22;
                static /*0xc0*/ System.Func<short, short, object> <>9__0_23;
                static /*0xc8*/ System.Func<short, ushort, object> <>9__0_24;
                static /*0xd0*/ System.Func<short, int, object> <>9__0_25;
                static /*0xd8*/ System.Func<short, uint, object> <>9__0_26;
                static /*0xe0*/ System.Func<short, long, object> <>9__0_27;
                static /*0xe8*/ System.Func<short, float, object> <>9__0_28;
                static /*0xf0*/ System.Func<short, decimal, object> <>9__0_29;
                static /*0xf8*/ System.Func<short, double, object> <>9__0_30;
                static /*0x100*/ System.Func<ushort, byte, object> <>9__0_31;
                static /*0x108*/ System.Func<ushort, sbyte, object> <>9__0_32;
                static /*0x110*/ System.Func<ushort, short, object> <>9__0_33;
                static /*0x118*/ System.Func<ushort, ushort, object> <>9__0_34;
                static /*0x120*/ System.Func<ushort, int, object> <>9__0_35;
                static /*0x128*/ System.Func<ushort, uint, object> <>9__0_36;
                static /*0x130*/ System.Func<ushort, long, object> <>9__0_37;
                static /*0x138*/ System.Func<ushort, ulong, object> <>9__0_38;
                static /*0x140*/ System.Func<ushort, float, object> <>9__0_39;
                static /*0x148*/ System.Func<ushort, decimal, object> <>9__0_40;
                static /*0x150*/ System.Func<ushort, double, object> <>9__0_41;
                static /*0x158*/ System.Func<int, byte, object> <>9__0_42;
                static /*0x160*/ System.Func<int, sbyte, object> <>9__0_43;
                static /*0x168*/ System.Func<int, short, object> <>9__0_44;
                static /*0x170*/ System.Func<int, ushort, object> <>9__0_45;
                static /*0x178*/ System.Func<int, int, object> <>9__0_46;
                static /*0x180*/ System.Func<int, uint, object> <>9__0_47;
                static /*0x188*/ System.Func<int, long, object> <>9__0_48;
                static /*0x190*/ System.Func<int, float, object> <>9__0_49;
                static /*0x198*/ System.Func<int, decimal, object> <>9__0_50;
                static /*0x1a0*/ System.Func<int, double, object> <>9__0_51;
                static /*0x1a8*/ System.Func<uint, byte, object> <>9__0_52;
                static /*0x1b0*/ System.Func<uint, sbyte, object> <>9__0_53;
                static /*0x1b8*/ System.Func<uint, short, object> <>9__0_54;
                static /*0x1c0*/ System.Func<uint, ushort, object> <>9__0_55;
                static /*0x1c8*/ System.Func<uint, int, object> <>9__0_56;
                static /*0x1d0*/ System.Func<uint, uint, object> <>9__0_57;
                static /*0x1d8*/ System.Func<uint, long, object> <>9__0_58;
                static /*0x1e0*/ System.Func<uint, ulong, object> <>9__0_59;
                static /*0x1e8*/ System.Func<uint, float, object> <>9__0_60;
                static /*0x1f0*/ System.Func<uint, decimal, object> <>9__0_61;
                static /*0x1f8*/ System.Func<uint, double, object> <>9__0_62;
                static /*0x200*/ System.Func<long, byte, object> <>9__0_63;
                static /*0x208*/ System.Func<long, sbyte, object> <>9__0_64;
                static /*0x210*/ System.Func<long, short, object> <>9__0_65;
                static /*0x218*/ System.Func<long, ushort, object> <>9__0_66;
                static /*0x220*/ System.Func<long, int, object> <>9__0_67;
                static /*0x228*/ System.Func<long, uint, object> <>9__0_68;
                static /*0x230*/ System.Func<long, long, object> <>9__0_69;
                static /*0x238*/ System.Func<long, float, object> <>9__0_70;
                static /*0x240*/ System.Func<long, decimal, object> <>9__0_71;
                static /*0x248*/ System.Func<long, double, object> <>9__0_72;
                static /*0x250*/ System.Func<ulong, byte, object> <>9__0_73;
                static /*0x258*/ System.Func<ulong, ushort, object> <>9__0_74;
                static /*0x260*/ System.Func<ulong, uint, object> <>9__0_75;
                static /*0x268*/ System.Func<ulong, ulong, object> <>9__0_76;
                static /*0x270*/ System.Func<ulong, float, object> <>9__0_77;
                static /*0x278*/ System.Func<ulong, decimal, object> <>9__0_78;
                static /*0x280*/ System.Func<ulong, double, object> <>9__0_79;
                static /*0x288*/ System.Func<float, byte, object> <>9__0_80;
                static /*0x290*/ System.Func<float, sbyte, object> <>9__0_81;
                static /*0x298*/ System.Func<float, short, object> <>9__0_82;
                static /*0x2a0*/ System.Func<float, ushort, object> <>9__0_83;
                static /*0x2a8*/ System.Func<float, int, object> <>9__0_84;
                static /*0x2b0*/ System.Func<float, uint, object> <>9__0_85;
                static /*0x2b8*/ System.Func<float, long, object> <>9__0_86;
                static /*0x2c0*/ System.Func<float, ulong, object> <>9__0_87;
                static /*0x2c8*/ System.Func<float, float, object> <>9__0_88;
                static /*0x2d0*/ System.Func<float, double, object> <>9__0_89;
                static /*0x2d8*/ System.Func<decimal, byte, object> <>9__0_90;
                static /*0x2e0*/ System.Func<decimal, sbyte, object> <>9__0_91;
                static /*0x2e8*/ System.Func<decimal, short, object> <>9__0_92;
                static /*0x2f0*/ System.Func<decimal, ushort, object> <>9__0_93;
                static /*0x2f8*/ System.Func<decimal, int, object> <>9__0_94;
                static /*0x300*/ System.Func<decimal, uint, object> <>9__0_95;
                static /*0x308*/ System.Func<decimal, long, object> <>9__0_96;
                static /*0x310*/ System.Func<decimal, ulong, object> <>9__0_97;
                static /*0x318*/ System.Func<decimal, decimal, object> <>9__0_98;
                static /*0x320*/ System.Func<double, byte, object> <>9__0_99;
                static /*0x328*/ System.Func<double, sbyte, object> <>9__0_100;
                static /*0x330*/ System.Func<double, short, object> <>9__0_101;
                static /*0x338*/ System.Func<double, ushort, object> <>9__0_102;
                static /*0x340*/ System.Func<double, int, object> <>9__0_103;
                static /*0x348*/ System.Func<double, uint, object> <>9__0_104;
                static /*0x350*/ System.Func<double, long, object> <>9__0_105;
                static /*0x358*/ System.Func<double, ulong, object> <>9__0_106;
                static /*0x360*/ System.Func<double, float, object> <>9__0_107;
                static /*0x368*/ System.Func<double, double, object> <>9__0_108;

                static /*0x15513b0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1543690*/ object <.ctor>b__0_0(byte a, byte b);
                /*0x1545e00*/ object <.ctor>b__0_1(byte a, sbyte b);
                /*0x1547900*/ object <.ctor>b__0_2(byte a, short b);
                /*0x1548f60*/ object <.ctor>b__0_3(byte a, ushort b);
                /*0x154a580*/ object <.ctor>b__0_4(byte a, int b);
                /*0x154b9a0*/ object <.ctor>b__0_5(byte a, uint b);
                /*0x154cc40*/ object <.ctor>b__0_6(byte a, long b);
                /*0x154e1b0*/ object <.ctor>b__0_7(byte a, ulong b);
                /*0x154f230*/ object <.ctor>b__0_8(byte a, float b);
                /*0x1550f30*/ object <.ctor>b__0_9(byte a, decimal b);
                /*0x1544930*/ object <.ctor>b__0_10(byte a, double b);
                /*0x1544a90*/ object <.ctor>b__0_11(sbyte a, byte b);
                /*0x1544ca0*/ object <.ctor>b__0_12(sbyte a, sbyte b);
                /*0x1544ec0*/ object <.ctor>b__0_13(sbyte a, short b);
                /*0x1545020*/ object <.ctor>b__0_14(sbyte a, ushort b);
                /*0x15451e0*/ object <.ctor>b__0_15(sbyte a, int b);
                /*0x15455c0*/ object <.ctor>b__0_16(sbyte a, uint b);
                /*0x15457a0*/ object <.ctor>b__0_17(sbyte a, long b);
                /*0x15458b0*/ object <.ctor>b__0_18(sbyte a, float b);
                /*0x1545a80*/ object <.ctor>b__0_19(sbyte a, decimal b);
                /*0x15461a0*/ object <.ctor>b__0_20(sbyte a, double b);
                /*0x15463d0*/ object <.ctor>b__0_21(short a, byte b);
                /*0x1546660*/ object <.ctor>b__0_22(short a, sbyte b);
                /*0x15467e0*/ object <.ctor>b__0_23(short a, short b);
                /*0x1546a40*/ object <.ctor>b__0_24(short a, ushort b);
                /*0x1546b90*/ object <.ctor>b__0_25(short a, int b);
                /*0x1546e50*/ object <.ctor>b__0_26(short a, uint b);
                /*0x1547080*/ object <.ctor>b__0_27(short a, long b);
                /*0x15471a0*/ object <.ctor>b__0_28(short a, float b);
                /*0x1547660*/ object <.ctor>b__0_29(short a, decimal b);
                /*0x1547b20*/ object <.ctor>b__0_30(short a, double b);
                /*0x1547ce0*/ object <.ctor>b__0_31(ushort a, byte b);
                /*0x1547f50*/ object <.ctor>b__0_32(ushort a, sbyte b);
                /*0x15480f0*/ object <.ctor>b__0_33(ushort a, short b);
                /*0x15482b0*/ object <.ctor>b__0_34(ushort a, ushort b);
                /*0x1548560*/ object <.ctor>b__0_35(ushort a, int b);
                /*0x1548770*/ object <.ctor>b__0_36(ushort a, uint b);
                /*0x1548a30*/ object <.ctor>b__0_37(ushort a, long b);
                /*0x1548b90*/ object <.ctor>b__0_38(ushort a, ulong b);
                /*0x1548da0*/ object <.ctor>b__0_39(ushort a, float b);
                /*0x15493f0*/ object <.ctor>b__0_40(ushort a, decimal b);
                /*0x15495a0*/ object <.ctor>b__0_41(ushort a, double b);
                /*0x1549660*/ object <.ctor>b__0_42(int a, byte b);
                /*0x15498a0*/ object <.ctor>b__0_43(int a, sbyte b);
                /*0x1549af0*/ object <.ctor>b__0_44(int a, short b);
                /*0x1549c40*/ object <.ctor>b__0_45(int a, ushort b);
                /*0x1549d90*/ object <.ctor>b__0_46(int a, int b);
                /*0x1549e80*/ object <.ctor>b__0_47(int a, uint b);
                /*0x154a100*/ object <.ctor>b__0_48(int a, long b);
                /*0x154a260*/ object <.ctor>b__0_49(int a, float b);
                /*0x154a8f0*/ object <.ctor>b__0_50(int a, decimal b);
                /*0x154ab00*/ object <.ctor>b__0_51(int a, double b);
                /*0x154acb0*/ object <.ctor>b__0_52(uint a, byte b);
                /*0x154ae70*/ object <.ctor>b__0_53(uint a, sbyte b);
                /*0x154afd0*/ object <.ctor>b__0_54(uint a, short b);
                /*0x154b080*/ object <.ctor>b__0_55(uint a, ushort b);
                /*0x154b2c0*/ object <.ctor>b__0_56(uint a, int b);
                /*0x154b420*/ object <.ctor>b__0_57(uint a, uint b);
                /*0x154b510*/ object <.ctor>b__0_58(uint a, long b);
                /*0x154b760*/ object <.ctor>b__0_59(uint a, ulong b);
                /*0x154bbc0*/ object <.ctor>b__0_60(uint a, float b);
                /*0x154bc20*/ object <.ctor>b__0_61(uint a, decimal b);
                /*0x154bf00*/ object <.ctor>b__0_62(uint a, double b);
                /*0x154c020*/ object <.ctor>b__0_63(long a, byte b);
                /*0x154c200*/ object <.ctor>b__0_64(long a, sbyte b);
                /*0x154c3e0*/ object <.ctor>b__0_65(long a, short b);
                /*0x154c4a0*/ object <.ctor>b__0_66(long a, ushort b);
                /*0x154c730*/ object <.ctor>b__0_67(long a, int b);
                /*0x154c7e0*/ object <.ctor>b__0_68(long a, uint b);
                /*0x154c9f0*/ object <.ctor>b__0_69(long a, long b);
                /*0x154cd40*/ object <.ctor>b__0_70(long a, float b);
                /*0x154d0a0*/ object <.ctor>b__0_71(long a, decimal b);
                /*0x154d200*/ object <.ctor>b__0_72(long a, double b);
                /*0x154d3e0*/ object <.ctor>b__0_73(ulong a, byte b);
                /*0x154d440*/ object <.ctor>b__0_74(ulong a, ushort b);
                /*0x154d5c0*/ object <.ctor>b__0_75(ulong a, uint b);
                /*0x154d770*/ object <.ctor>b__0_76(ulong a, ulong b);
                /*0x154da00*/ object <.ctor>b__0_77(ulong a, float b);
                /*0x154db20*/ object <.ctor>b__0_78(ulong a, decimal b);
                /*0x154dd00*/ object <.ctor>b__0_79(ulong a, double b);
                /*0x154e2c0*/ object <.ctor>b__0_80(float a, byte b);
                /*0x154e380*/ object <.ctor>b__0_81(float a, sbyte b);
                /*0x154e5c0*/ object <.ctor>b__0_82(float a, short b);
                /*0x154e680*/ object <.ctor>b__0_83(float a, ushort b);
                /*0x154e920*/ object <.ctor>b__0_84(float a, int b);
                /*0x154e980*/ object <.ctor>b__0_85(float a, uint b);
                /*0x154ebd0*/ object <.ctor>b__0_86(float a, long b);
                /*0x154ed10*/ object <.ctor>b__0_87(float a, ulong b);
                /*0x154ef00*/ object <.ctor>b__0_88(float a, float b);
                /*0x154f0f0*/ object <.ctor>b__0_89(float a, double b);
                /*0x154f580*/ object <.ctor>b__0_90(decimal a, byte b);
                /*0x154f800*/ object <.ctor>b__0_91(decimal a, sbyte b);
                /*0x154fc60*/ object <.ctor>b__0_92(decimal a, short b);
                /*0x154fd00*/ object <.ctor>b__0_93(decimal a, ushort b);
                /*0x1550160*/ object <.ctor>b__0_94(decimal a, int b);
                /*0x15503e0*/ object <.ctor>b__0_95(decimal a, uint b);
                /*0x1550480*/ object <.ctor>b__0_96(decimal a, long b);
                /*0x15507a0*/ object <.ctor>b__0_97(decimal a, ulong b);
                /*0x1550a10*/ object <.ctor>b__0_98(decimal a, decimal b);
                /*0x1550ce0*/ object <.ctor>b__0_99(double a, byte b);
                /*0x15438e0*/ object <.ctor>b__0_100(double a, sbyte b);
                /*0x1543b80*/ object <.ctor>b__0_101(double a, short b);
                /*0x1543be0*/ object <.ctor>b__0_102(double a, ushort b);
                /*0x1543e20*/ object <.ctor>b__0_103(double a, int b);
                /*0x1543fa0*/ object <.ctor>b__0_104(double a, uint b);
                /*0x1544120*/ object <.ctor>b__0_105(double a, long b);
                /*0x15442e0*/ object <.ctor>b__0_106(double a, ulong b);
                /*0x1544520*/ object <.ctor>b__0_107(double a, float b);
                /*0x15446b0*/ object <.ctor>b__0_108(double a, double b);
            }
        }

        class LessThanOrEqualHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x15281b0*/ LessThanOrEqualHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.LessThanOrEqualHandler.<> <>9;
                static /*0x8*/ System.Func<byte, byte, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, short, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, int, object> <>9__0_4;
                static /*0x30*/ System.Func<byte, uint, object> <>9__0_5;
                static /*0x38*/ System.Func<byte, long, object> <>9__0_6;
                static /*0x40*/ System.Func<byte, ulong, object> <>9__0_7;
                static /*0x48*/ System.Func<byte, float, object> <>9__0_8;
                static /*0x50*/ System.Func<byte, decimal, object> <>9__0_9;
                static /*0x58*/ System.Func<byte, double, object> <>9__0_10;
                static /*0x60*/ System.Func<sbyte, byte, object> <>9__0_11;
                static /*0x68*/ System.Func<sbyte, sbyte, object> <>9__0_12;
                static /*0x70*/ System.Func<sbyte, short, object> <>9__0_13;
                static /*0x78*/ System.Func<sbyte, ushort, object> <>9__0_14;
                static /*0x80*/ System.Func<sbyte, int, object> <>9__0_15;
                static /*0x88*/ System.Func<sbyte, uint, object> <>9__0_16;
                static /*0x90*/ System.Func<sbyte, long, object> <>9__0_17;
                static /*0x98*/ System.Func<sbyte, float, object> <>9__0_18;
                static /*0xa0*/ System.Func<sbyte, decimal, object> <>9__0_19;
                static /*0xa8*/ System.Func<sbyte, double, object> <>9__0_20;
                static /*0xb0*/ System.Func<short, byte, object> <>9__0_21;
                static /*0xb8*/ System.Func<short, sbyte, object> <>9__0_22;
                static /*0xc0*/ System.Func<short, short, object> <>9__0_23;
                static /*0xc8*/ System.Func<short, ushort, object> <>9__0_24;
                static /*0xd0*/ System.Func<short, int, object> <>9__0_25;
                static /*0xd8*/ System.Func<short, uint, object> <>9__0_26;
                static /*0xe0*/ System.Func<short, long, object> <>9__0_27;
                static /*0xe8*/ System.Func<short, float, object> <>9__0_28;
                static /*0xf0*/ System.Func<short, decimal, object> <>9__0_29;
                static /*0xf8*/ System.Func<short, double, object> <>9__0_30;
                static /*0x100*/ System.Func<ushort, byte, object> <>9__0_31;
                static /*0x108*/ System.Func<ushort, sbyte, object> <>9__0_32;
                static /*0x110*/ System.Func<ushort, short, object> <>9__0_33;
                static /*0x118*/ System.Func<ushort, ushort, object> <>9__0_34;
                static /*0x120*/ System.Func<ushort, int, object> <>9__0_35;
                static /*0x128*/ System.Func<ushort, uint, object> <>9__0_36;
                static /*0x130*/ System.Func<ushort, long, object> <>9__0_37;
                static /*0x138*/ System.Func<ushort, ulong, object> <>9__0_38;
                static /*0x140*/ System.Func<ushort, float, object> <>9__0_39;
                static /*0x148*/ System.Func<ushort, decimal, object> <>9__0_40;
                static /*0x150*/ System.Func<ushort, double, object> <>9__0_41;
                static /*0x158*/ System.Func<int, byte, object> <>9__0_42;
                static /*0x160*/ System.Func<int, sbyte, object> <>9__0_43;
                static /*0x168*/ System.Func<int, short, object> <>9__0_44;
                static /*0x170*/ System.Func<int, ushort, object> <>9__0_45;
                static /*0x178*/ System.Func<int, int, object> <>9__0_46;
                static /*0x180*/ System.Func<int, uint, object> <>9__0_47;
                static /*0x188*/ System.Func<int, long, object> <>9__0_48;
                static /*0x190*/ System.Func<int, float, object> <>9__0_49;
                static /*0x198*/ System.Func<int, decimal, object> <>9__0_50;
                static /*0x1a0*/ System.Func<int, double, object> <>9__0_51;
                static /*0x1a8*/ System.Func<uint, byte, object> <>9__0_52;
                static /*0x1b0*/ System.Func<uint, sbyte, object> <>9__0_53;
                static /*0x1b8*/ System.Func<uint, short, object> <>9__0_54;
                static /*0x1c0*/ System.Func<uint, ushort, object> <>9__0_55;
                static /*0x1c8*/ System.Func<uint, int, object> <>9__0_56;
                static /*0x1d0*/ System.Func<uint, uint, object> <>9__0_57;
                static /*0x1d8*/ System.Func<uint, long, object> <>9__0_58;
                static /*0x1e0*/ System.Func<uint, ulong, object> <>9__0_59;
                static /*0x1e8*/ System.Func<uint, float, object> <>9__0_60;
                static /*0x1f0*/ System.Func<uint, decimal, object> <>9__0_61;
                static /*0x1f8*/ System.Func<uint, double, object> <>9__0_62;
                static /*0x200*/ System.Func<long, byte, object> <>9__0_63;
                static /*0x208*/ System.Func<long, sbyte, object> <>9__0_64;
                static /*0x210*/ System.Func<long, short, object> <>9__0_65;
                static /*0x218*/ System.Func<long, ushort, object> <>9__0_66;
                static /*0x220*/ System.Func<long, int, object> <>9__0_67;
                static /*0x228*/ System.Func<long, uint, object> <>9__0_68;
                static /*0x230*/ System.Func<long, long, object> <>9__0_69;
                static /*0x238*/ System.Func<long, float, object> <>9__0_70;
                static /*0x240*/ System.Func<long, decimal, object> <>9__0_71;
                static /*0x248*/ System.Func<long, double, object> <>9__0_72;
                static /*0x250*/ System.Func<ulong, byte, object> <>9__0_73;
                static /*0x258*/ System.Func<ulong, ushort, object> <>9__0_74;
                static /*0x260*/ System.Func<ulong, uint, object> <>9__0_75;
                static /*0x268*/ System.Func<ulong, ulong, object> <>9__0_76;
                static /*0x270*/ System.Func<ulong, float, object> <>9__0_77;
                static /*0x278*/ System.Func<ulong, decimal, object> <>9__0_78;
                static /*0x280*/ System.Func<ulong, double, object> <>9__0_79;
                static /*0x288*/ System.Func<float, byte, object> <>9__0_80;
                static /*0x290*/ System.Func<float, sbyte, object> <>9__0_81;
                static /*0x298*/ System.Func<float, short, object> <>9__0_82;
                static /*0x2a0*/ System.Func<float, ushort, object> <>9__0_83;
                static /*0x2a8*/ System.Func<float, int, object> <>9__0_84;
                static /*0x2b0*/ System.Func<float, uint, object> <>9__0_85;
                static /*0x2b8*/ System.Func<float, long, object> <>9__0_86;
                static /*0x2c0*/ System.Func<float, ulong, object> <>9__0_87;
                static /*0x2c8*/ System.Func<float, float, object> <>9__0_88;
                static /*0x2d0*/ System.Func<float, double, object> <>9__0_89;
                static /*0x2d8*/ System.Func<decimal, byte, object> <>9__0_90;
                static /*0x2e0*/ System.Func<decimal, sbyte, object> <>9__0_91;
                static /*0x2e8*/ System.Func<decimal, short, object> <>9__0_92;
                static /*0x2f0*/ System.Func<decimal, ushort, object> <>9__0_93;
                static /*0x2f8*/ System.Func<decimal, int, object> <>9__0_94;
                static /*0x300*/ System.Func<decimal, uint, object> <>9__0_95;
                static /*0x308*/ System.Func<decimal, long, object> <>9__0_96;
                static /*0x310*/ System.Func<decimal, ulong, object> <>9__0_97;
                static /*0x318*/ System.Func<decimal, decimal, object> <>9__0_98;
                static /*0x320*/ System.Func<double, byte, object> <>9__0_99;
                static /*0x328*/ System.Func<double, sbyte, object> <>9__0_100;
                static /*0x330*/ System.Func<double, short, object> <>9__0_101;
                static /*0x338*/ System.Func<double, ushort, object> <>9__0_102;
                static /*0x340*/ System.Func<double, int, object> <>9__0_103;
                static /*0x348*/ System.Func<double, uint, object> <>9__0_104;
                static /*0x350*/ System.Func<double, long, object> <>9__0_105;
                static /*0x358*/ System.Func<double, ulong, object> <>9__0_106;
                static /*0x360*/ System.Func<double, float, object> <>9__0_107;
                static /*0x368*/ System.Func<double, double, object> <>9__0_108;

                static /*0x15511f0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x15435e0*/ object <.ctor>b__0_0(byte a, byte b);
                /*0x1545eb0*/ object <.ctor>b__0_1(byte a, sbyte b);
                /*0x1547700*/ object <.ctor>b__0_2(byte a, short b);
                /*0x1548fc0*/ object <.ctor>b__0_3(byte a, ushort b);
                /*0x154a3e0*/ object <.ctor>b__0_4(byte a, int b);
                /*0x154b8a0*/ object <.ctor>b__0_5(byte a, uint b);
                /*0x154cb40*/ object <.ctor>b__0_6(byte a, long b);
                /*0x154e050*/ object <.ctor>b__0_7(byte a, ulong b);
                /*0x154f3c0*/ object <.ctor>b__0_8(byte a, float b);
                /*0x1550da0*/ object <.ctor>b__0_9(byte a, decimal b);
                /*0x15448d0*/ object <.ctor>b__0_10(byte a, double b);
                /*0x1544a40*/ object <.ctor>b__0_11(sbyte a, byte b);
                /*0x1544b90*/ object <.ctor>b__0_12(sbyte a, sbyte b);
                /*0x1544f20*/ object <.ctor>b__0_13(sbyte a, short b);
                /*0x1545070*/ object <.ctor>b__0_14(sbyte a, ushort b);
                /*0x1545280*/ object <.ctor>b__0_15(sbyte a, int b);
                /*0x15454a0*/ object <.ctor>b__0_16(sbyte a, uint b);
                /*0x1545680*/ object <.ctor>b__0_17(sbyte a, long b);
                /*0x1545910*/ object <.ctor>b__0_18(sbyte a, float b);
                /*0x1545b20*/ object <.ctor>b__0_19(sbyte a, decimal b);
                /*0x1546200*/ object <.ctor>b__0_20(sbyte a, double b);
                /*0x1546310*/ object <.ctor>b__0_21(short a, byte b);
                /*0x15464f0*/ object <.ctor>b__0_22(short a, sbyte b);
                /*0x1546780*/ object <.ctor>b__0_23(short a, short b);
                /*0x15469a0*/ object <.ctor>b__0_24(short a, ushort b);
                /*0x1546be0*/ object <.ctor>b__0_25(short a, int b);
                /*0x1546da0*/ object <.ctor>b__0_26(short a, uint b);
                /*0x1547140*/ object <.ctor>b__0_27(short a, long b);
                /*0x1547320*/ object <.ctor>b__0_28(short a, float b);
                /*0x15473d0*/ object <.ctor>b__0_29(short a, decimal b);
                /*0x1547ac0*/ object <.ctor>b__0_30(short a, double b);
                /*0x1547c30*/ object <.ctor>b__0_31(ushort a, byte b);
                /*0x1547eb0*/ object <.ctor>b__0_32(ushort a, sbyte b);
                /*0x1548050*/ object <.ctor>b__0_33(ushort a, short b);
                /*0x1548360*/ object <.ctor>b__0_34(ushort a, ushort b);
                /*0x1548470*/ object <.ctor>b__0_35(ushort a, int b);
                /*0x1548670*/ object <.ctor>b__0_36(ushort a, uint b);
                /*0x1548870*/ object <.ctor>b__0_37(ushort a, long b);
                /*0x1548be0*/ object <.ctor>b__0_38(ushort a, ulong b);
                /*0x1548d40*/ object <.ctor>b__0_39(ushort a, float b);
                /*0x15491c0*/ object <.ctor>b__0_40(ushort a, decimal b);
                /*0x1549540*/ object <.ctor>b__0_41(ushort a, double b);
                /*0x1549700*/ object <.ctor>b__0_42(int a, byte b);
                /*0x1549800*/ object <.ctor>b__0_43(int a, sbyte b);
                /*0x1549aa0*/ object <.ctor>b__0_44(int a, short b);
                /*0x1549c90*/ object <.ctor>b__0_45(int a, ushort b);
                /*0x1549e30*/ object <.ctor>b__0_46(int a, int b);
                /*0x1549ed0*/ object <.ctor>b__0_47(int a, uint b);
                /*0x154a150*/ object <.ctor>b__0_48(int a, long b);
                /*0x154a200*/ object <.ctor>b__0_49(int a, float b);
                /*0x154a7b0*/ object <.ctor>b__0_50(int a, decimal b);
                /*0x154a9f0*/ object <.ctor>b__0_51(int a, double b);
                /*0x154ac60*/ object <.ctor>b__0_52(uint a, byte b);
                /*0x154ae20*/ object <.ctor>b__0_53(uint a, sbyte b);
                /*0x154aec0*/ object <.ctor>b__0_54(uint a, short b);
                /*0x154b120*/ object <.ctor>b__0_55(uint a, ushort b);
                /*0x154b270*/ object <.ctor>b__0_56(uint a, int b);
                /*0x154b470*/ object <.ctor>b__0_57(uint a, uint b);
                /*0x154b5b0*/ object <.ctor>b__0_58(uint a, long b);
                /*0x154b6c0*/ object <.ctor>b__0_59(uint a, ulong b);
                /*0x154bb60*/ object <.ctor>b__0_60(uint a, float b);
                /*0x154bd60*/ object <.ctor>b__0_61(uint a, decimal b);
                /*0x154bea0*/ object <.ctor>b__0_62(uint a, double b);
                /*0x154c080*/ object <.ctor>b__0_63(long a, byte b);
                /*0x154c1a0*/ object <.ctor>b__0_64(long a, sbyte b);
                /*0x154c380*/ object <.ctor>b__0_65(long a, short b);
                /*0x154c560*/ object <.ctor>b__0_66(long a, ushort b);
                /*0x154c620*/ object <.ctor>b__0_67(long a, int b);
                /*0x154c830*/ object <.ctor>b__0_68(long a, uint b);
                /*0x154c940*/ object <.ctor>b__0_69(long a, long b);
                /*0x154ce60*/ object <.ctor>b__0_70(long a, float b);
                /*0x154cec0*/ object <.ctor>b__0_71(long a, decimal b);
                /*0x154d260*/ object <.ctor>b__0_72(long a, double b);
                /*0x154d2c0*/ object <.ctor>b__0_73(ulong a, byte b);
                /*0x154d4a0*/ object <.ctor>b__0_74(ulong a, ushort b);
                /*0x154d610*/ object <.ctor>b__0_75(ulong a, uint b);
                /*0x154d720*/ object <.ctor>b__0_76(ulong a, ulong b);
                /*0x154d900*/ object <.ctor>b__0_77(ulong a, float b);
                /*0x154dbc0*/ object <.ctor>b__0_78(ulong a, decimal b);
                /*0x154dd80*/ object <.ctor>b__0_79(ulong a, double b);
                /*0x154e260*/ object <.ctor>b__0_80(float a, byte b);
                /*0x154e4a0*/ object <.ctor>b__0_81(float a, sbyte b);
                /*0x154e560*/ object <.ctor>b__0_82(float a, short b);
                /*0x154e6e0*/ object <.ctor>b__0_83(float a, ushort b);
                /*0x154e860*/ object <.ctor>b__0_84(float a, int b);
                /*0x154ea50*/ object <.ctor>b__0_85(float a, uint b);
                /*0x154eb70*/ object <.ctor>b__0_86(float a, long b);
                /*0x154ed90*/ object <.ctor>b__0_87(float a, ulong b);
                /*0x154ef60*/ object <.ctor>b__0_88(float a, float b);
                /*0x154f090*/ object <.ctor>b__0_89(float a, double b);
                /*0x154f760*/ object <.ctor>b__0_90(decimal a, byte b);
                /*0x154f9e0*/ object <.ctor>b__0_91(decimal a, sbyte b);
                /*0x154fb20*/ object <.ctor>b__0_92(decimal a, short b);
                /*0x154fda0*/ object <.ctor>b__0_93(decimal a, ushort b);
                /*0x154ff80*/ object <.ctor>b__0_94(decimal a, int b);
                /*0x1550200*/ object <.ctor>b__0_95(decimal a, uint b);
                /*0x1550660*/ object <.ctor>b__0_96(decimal a, long b);
                /*0x15508e0*/ object <.ctor>b__0_97(decimal a, ulong b);
                /*0x1550aa0*/ object <.ctor>b__0_98(decimal a, decimal b);
                /*0x1550bc0*/ object <.ctor>b__0_99(double a, byte b);
                /*0x1543a00*/ object <.ctor>b__0_100(double a, sbyte b);
                /*0x1543ac0*/ object <.ctor>b__0_101(double a, short b);
                /*0x1543ca0*/ object <.ctor>b__0_102(double a, ushort b);
                /*0x1543d60*/ object <.ctor>b__0_103(double a, int b);
                /*0x1543f40*/ object <.ctor>b__0_104(double a, uint b);
                /*0x1544060*/ object <.ctor>b__0_105(double a, long b);
                /*0x15441e0*/ object <.ctor>b__0_106(double a, ulong b);
                /*0x1544450*/ object <.ctor>b__0_107(double a, float b);
                /*0x1544580*/ object <.ctor>b__0_108(double a, double b);
            }
        }

        class LogicalNegationHandler : Unity.VisualScripting.UnaryOperatorHandler
        {
            /*0x152df80*/ LogicalNegationHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.LogicalNegationHandler.<> <>9;
                static /*0x8*/ System.Func<bool, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, object> <>9__0_1;
                static /*0x18*/ System.Func<sbyte, object> <>9__0_2;
                static /*0x20*/ System.Func<short, object> <>9__0_3;
                static /*0x28*/ System.Func<ushort, object> <>9__0_4;
                static /*0x30*/ System.Func<int, object> <>9__0_5;
                static /*0x38*/ System.Func<uint, object> <>9__0_6;
                static /*0x40*/ System.Func<long, object> <>9__0_7;
                static /*0x48*/ System.Func<ulong, object> <>9__0_8;

                static /*0x1551490*/ <>c();
                /*0x32f970*/ <>c();
                /*0x15437f0*/ object <.ctor>b__0_0(bool a);
                /*0x1545f50*/ object <.ctor>b__0_1(byte a);
                /*0x1547960*/ object <.ctor>b__0_2(sbyte a);
                /*0x1549080*/ object <.ctor>b__0_3(short a);
                /*0x154a530*/ object <.ctor>b__0_4(ushort a);
                /*0x154b800*/ object <.ctor>b__0_5(int a);
                /*0x154ccf0*/ object <.ctor>b__0_6(uint a);
                /*0x154df00*/ object <.ctor>b__0_7(long a);
                /*0x154f480*/ object <.ctor>b__0_8(ulong a);
            }
        }

        class ModuloHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x152e790*/ ModuloHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.ModuloHandler.<> <>9;
                static /*0x8*/ System.Func<byte, byte, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, short, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, int, object> <>9__0_4;
                static /*0x30*/ System.Func<byte, uint, object> <>9__0_5;
                static /*0x38*/ System.Func<byte, long, object> <>9__0_6;
                static /*0x40*/ System.Func<byte, ulong, object> <>9__0_7;
                static /*0x48*/ System.Func<byte, float, object> <>9__0_8;
                static /*0x50*/ System.Func<byte, decimal, object> <>9__0_9;
                static /*0x58*/ System.Func<byte, double, object> <>9__0_10;
                static /*0x60*/ System.Func<sbyte, byte, object> <>9__0_11;
                static /*0x68*/ System.Func<sbyte, sbyte, object> <>9__0_12;
                static /*0x70*/ System.Func<sbyte, short, object> <>9__0_13;
                static /*0x78*/ System.Func<sbyte, ushort, object> <>9__0_14;
                static /*0x80*/ System.Func<sbyte, int, object> <>9__0_15;
                static /*0x88*/ System.Func<sbyte, uint, object> <>9__0_16;
                static /*0x90*/ System.Func<sbyte, long, object> <>9__0_17;
                static /*0x98*/ System.Func<sbyte, float, object> <>9__0_18;
                static /*0xa0*/ System.Func<sbyte, decimal, object> <>9__0_19;
                static /*0xa8*/ System.Func<sbyte, double, object> <>9__0_20;
                static /*0xb0*/ System.Func<short, byte, object> <>9__0_21;
                static /*0xb8*/ System.Func<short, sbyte, object> <>9__0_22;
                static /*0xc0*/ System.Func<short, short, object> <>9__0_23;
                static /*0xc8*/ System.Func<short, ushort, object> <>9__0_24;
                static /*0xd0*/ System.Func<short, int, object> <>9__0_25;
                static /*0xd8*/ System.Func<short, uint, object> <>9__0_26;
                static /*0xe0*/ System.Func<short, long, object> <>9__0_27;
                static /*0xe8*/ System.Func<short, float, object> <>9__0_28;
                static /*0xf0*/ System.Func<short, decimal, object> <>9__0_29;
                static /*0xf8*/ System.Func<short, double, object> <>9__0_30;
                static /*0x100*/ System.Func<ushort, byte, object> <>9__0_31;
                static /*0x108*/ System.Func<ushort, sbyte, object> <>9__0_32;
                static /*0x110*/ System.Func<ushort, short, object> <>9__0_33;
                static /*0x118*/ System.Func<ushort, ushort, object> <>9__0_34;
                static /*0x120*/ System.Func<ushort, int, object> <>9__0_35;
                static /*0x128*/ System.Func<ushort, uint, object> <>9__0_36;
                static /*0x130*/ System.Func<ushort, long, object> <>9__0_37;
                static /*0x138*/ System.Func<ushort, ulong, object> <>9__0_38;
                static /*0x140*/ System.Func<ushort, float, object> <>9__0_39;
                static /*0x148*/ System.Func<ushort, decimal, object> <>9__0_40;
                static /*0x150*/ System.Func<ushort, double, object> <>9__0_41;
                static /*0x158*/ System.Func<int, byte, object> <>9__0_42;
                static /*0x160*/ System.Func<int, sbyte, object> <>9__0_43;
                static /*0x168*/ System.Func<int, short, object> <>9__0_44;
                static /*0x170*/ System.Func<int, ushort, object> <>9__0_45;
                static /*0x178*/ System.Func<int, int, object> <>9__0_46;
                static /*0x180*/ System.Func<int, uint, object> <>9__0_47;
                static /*0x188*/ System.Func<int, long, object> <>9__0_48;
                static /*0x190*/ System.Func<int, float, object> <>9__0_49;
                static /*0x198*/ System.Func<int, decimal, object> <>9__0_50;
                static /*0x1a0*/ System.Func<int, double, object> <>9__0_51;
                static /*0x1a8*/ System.Func<uint, byte, object> <>9__0_52;
                static /*0x1b0*/ System.Func<uint, sbyte, object> <>9__0_53;
                static /*0x1b8*/ System.Func<uint, short, object> <>9__0_54;
                static /*0x1c0*/ System.Func<uint, ushort, object> <>9__0_55;
                static /*0x1c8*/ System.Func<uint, int, object> <>9__0_56;
                static /*0x1d0*/ System.Func<uint, uint, object> <>9__0_57;
                static /*0x1d8*/ System.Func<uint, long, object> <>9__0_58;
                static /*0x1e0*/ System.Func<uint, ulong, object> <>9__0_59;
                static /*0x1e8*/ System.Func<uint, float, object> <>9__0_60;
                static /*0x1f0*/ System.Func<uint, decimal, object> <>9__0_61;
                static /*0x1f8*/ System.Func<uint, double, object> <>9__0_62;
                static /*0x200*/ System.Func<long, byte, object> <>9__0_63;
                static /*0x208*/ System.Func<long, sbyte, object> <>9__0_64;
                static /*0x210*/ System.Func<long, short, object> <>9__0_65;
                static /*0x218*/ System.Func<long, ushort, object> <>9__0_66;
                static /*0x220*/ System.Func<long, int, object> <>9__0_67;
                static /*0x228*/ System.Func<long, uint, object> <>9__0_68;
                static /*0x230*/ System.Func<long, long, object> <>9__0_69;
                static /*0x238*/ System.Func<long, float, object> <>9__0_70;
                static /*0x240*/ System.Func<long, decimal, object> <>9__0_71;
                static /*0x248*/ System.Func<long, double, object> <>9__0_72;
                static /*0x250*/ System.Func<ulong, byte, object> <>9__0_73;
                static /*0x258*/ System.Func<ulong, ushort, object> <>9__0_74;
                static /*0x260*/ System.Func<ulong, uint, object> <>9__0_75;
                static /*0x268*/ System.Func<ulong, ulong, object> <>9__0_76;
                static /*0x270*/ System.Func<ulong, float, object> <>9__0_77;
                static /*0x278*/ System.Func<ulong, decimal, object> <>9__0_78;
                static /*0x280*/ System.Func<ulong, double, object> <>9__0_79;
                static /*0x288*/ System.Func<float, byte, object> <>9__0_80;
                static /*0x290*/ System.Func<float, sbyte, object> <>9__0_81;
                static /*0x298*/ System.Func<float, short, object> <>9__0_82;
                static /*0x2a0*/ System.Func<float, ushort, object> <>9__0_83;
                static /*0x2a8*/ System.Func<float, int, object> <>9__0_84;
                static /*0x2b0*/ System.Func<float, uint, object> <>9__0_85;
                static /*0x2b8*/ System.Func<float, long, object> <>9__0_86;
                static /*0x2c0*/ System.Func<float, ulong, object> <>9__0_87;
                static /*0x2c8*/ System.Func<float, float, object> <>9__0_88;
                static /*0x2d0*/ System.Func<float, double, object> <>9__0_89;
                static /*0x2d8*/ System.Func<decimal, byte, object> <>9__0_90;
                static /*0x2e0*/ System.Func<decimal, sbyte, object> <>9__0_91;
                static /*0x2e8*/ System.Func<decimal, short, object> <>9__0_92;
                static /*0x2f0*/ System.Func<decimal, ushort, object> <>9__0_93;
                static /*0x2f8*/ System.Func<decimal, int, object> <>9__0_94;
                static /*0x300*/ System.Func<decimal, uint, object> <>9__0_95;
                static /*0x308*/ System.Func<decimal, long, object> <>9__0_96;
                static /*0x310*/ System.Func<decimal, ulong, object> <>9__0_97;
                static /*0x318*/ System.Func<decimal, decimal, object> <>9__0_98;
                static /*0x320*/ System.Func<double, byte, object> <>9__0_99;
                static /*0x328*/ System.Func<double, sbyte, object> <>9__0_100;
                static /*0x330*/ System.Func<double, short, object> <>9__0_101;
                static /*0x338*/ System.Func<double, ushort, object> <>9__0_102;
                static /*0x340*/ System.Func<double, int, object> <>9__0_103;
                static /*0x348*/ System.Func<double, uint, object> <>9__0_104;
                static /*0x350*/ System.Func<double, long, object> <>9__0_105;
                static /*0x358*/ System.Func<double, ulong, object> <>9__0_106;
                static /*0x360*/ System.Func<double, float, object> <>9__0_107;
                static /*0x368*/ System.Func<double, double, object> <>9__0_108;

                static /*0x1551340*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1543880*/ object <.ctor>b__0_0(byte a, byte b);
                /*0x1545e50*/ object <.ctor>b__0_1(byte a, sbyte b);
                /*0x1547850*/ object <.ctor>b__0_2(byte a, short b);
                /*0x1548f00*/ object <.ctor>b__0_3(byte a, ushort b);
                /*0x154a660*/ object <.ctor>b__0_4(byte a, int b);
                /*0x154b9f0*/ object <.ctor>b__0_5(byte a, uint b);
                /*0x154cc90*/ object <.ctor>b__0_6(byte a, long b);
                /*0x154e0f0*/ object <.ctor>b__0_7(byte a, ulong b);
                /*0x154f420*/ object <.ctor>b__0_8(byte a, float b);
                /*0x1550fd0*/ object <.ctor>b__0_9(byte a, decimal b);
                /*0x1544710*/ object <.ctor>b__0_10(byte a, double b);
                /*0x1544ae0*/ object <.ctor>b__0_11(sbyte a, byte b);
                /*0x1544bf0*/ object <.ctor>b__0_12(sbyte a, sbyte b);
                /*0x1544e60*/ object <.ctor>b__0_13(sbyte a, short b);
                /*0x15450c0*/ object <.ctor>b__0_14(sbyte a, ushort b);
                /*0x15452d0*/ object <.ctor>b__0_15(sbyte a, int b);
                /*0x1545500*/ object <.ctor>b__0_16(sbyte a, uint b);
                /*0x1545740*/ object <.ctor>b__0_17(sbyte a, long b);
                /*0x1545a20*/ object <.ctor>b__0_18(sbyte a, float b);
                /*0x1545c70*/ object <.ctor>b__0_19(sbyte a, decimal b);
                /*0x15460f0*/ object <.ctor>b__0_20(sbyte a, double b);
                /*0x1546430*/ object <.ctor>b__0_21(short a, byte b);
                /*0x15466c0*/ object <.ctor>b__0_22(short a, sbyte b);
                /*0x1546720*/ object <.ctor>b__0_23(short a, short b);
                /*0x1546940*/ object <.ctor>b__0_24(short a, ushort b);
                /*0x1546ce0*/ object <.ctor>b__0_25(short a, int b);
                /*0x1546eb0*/ object <.ctor>b__0_26(short a, uint b);
                /*0x1547020*/ object <.ctor>b__0_27(short a, long b);
                /*0x1547200*/ object <.ctor>b__0_28(short a, float b);
                /*0x1547570*/ object <.ctor>b__0_29(short a, decimal b);
                /*0x1547a60*/ object <.ctor>b__0_30(short a, double b);
                /*0x1547da0*/ object <.ctor>b__0_31(ushort a, byte b);
                /*0x1547fa0*/ object <.ctor>b__0_32(ushort a, sbyte b);
                /*0x15481f0*/ object <.ctor>b__0_33(ushort a, short b);
                /*0x1548410*/ object <.ctor>b__0_34(ushort a, ushort b);
                /*0x1548610*/ object <.ctor>b__0_35(ushort a, int b);
                /*0x1548710*/ object <.ctor>b__0_36(ushort a, uint b);
                /*0x15488c0*/ object <.ctor>b__0_37(ushort a, long b);
                /*0x1548c30*/ object <.ctor>b__0_38(ushort a, ulong b);
                /*0x1548e60*/ object <.ctor>b__0_39(ushort a, float b);
                /*0x1549260*/ object <.ctor>b__0_40(ushort a, decimal b);
                /*0x1549600*/ object <.ctor>b__0_41(ushort a, double b);
                /*0x15497a0*/ object <.ctor>b__0_42(int a, byte b);
                /*0x1549940*/ object <.ctor>b__0_43(int a, sbyte b);
                /*0x15499f0*/ object <.ctor>b__0_44(int a, short b);
                /*0x1549be0*/ object <.ctor>b__0_45(int a, ushort b);
                /*0x1549de0*/ object <.ctor>b__0_46(int a, int b);
                /*0x1549f80*/ object <.ctor>b__0_47(int a, uint b);
                /*0x154a040*/ object <.ctor>b__0_48(int a, long b);
                /*0x154a320*/ object <.ctor>b__0_49(int a, float b);
                /*0x154a850*/ object <.ctor>b__0_50(int a, decimal b);
                /*0x154a990*/ object <.ctor>b__0_51(int a, double b);
                /*0x154ac00*/ object <.ctor>b__0_52(uint a, byte b);
                /*0x154adc0*/ object <.ctor>b__0_53(uint a, sbyte b);
                /*0x154af10*/ object <.ctor>b__0_54(uint a, short b);
                /*0x154b1c0*/ object <.ctor>b__0_55(uint a, ushort b);
                /*0x154b310*/ object <.ctor>b__0_56(uint a, int b);
                /*0x154b3c0*/ object <.ctor>b__0_57(uint a, uint b);
                /*0x154b600*/ object <.ctor>b__0_58(uint a, long b);
                /*0x154b660*/ object <.ctor>b__0_59(uint a, ulong b);
                /*0x154ba90*/ object <.ctor>b__0_60(uint a, float b);
                /*0x154be00*/ object <.ctor>b__0_61(uint a, decimal b);
                /*0x154bfc0*/ object <.ctor>b__0_62(uint a, double b);
                /*0x154c0e0*/ object <.ctor>b__0_63(long a, byte b);
                /*0x154c260*/ object <.ctor>b__0_64(long a, sbyte b);
                /*0x154c320*/ object <.ctor>b__0_65(long a, short b);
                /*0x154c5c0*/ object <.ctor>b__0_66(long a, ushort b);
                /*0x154c670*/ object <.ctor>b__0_67(long a, int b);
                /*0x154c880*/ object <.ctor>b__0_68(long a, uint b);
                /*0x154c990*/ object <.ctor>b__0_69(long a, long b);
                /*0x154ce00*/ object <.ctor>b__0_70(long a, float b);
                /*0x154cf60*/ object <.ctor>b__0_71(long a, decimal b);
                /*0x154d1a0*/ object <.ctor>b__0_72(long a, double b);
                /*0x154d380*/ object <.ctor>b__0_73(ulong a, byte b);
                /*0x154d560*/ object <.ctor>b__0_74(ulong a, ushort b);
                /*0x154d6c0*/ object <.ctor>b__0_75(ulong a, uint b);
                /*0x154d7c0*/ object <.ctor>b__0_76(ulong a, ulong b);
                /*0x154d880*/ object <.ctor>b__0_77(ulong a, float b);
                /*0x154da80*/ object <.ctor>b__0_78(ulong a, decimal b);
                /*0x154de00*/ object <.ctor>b__0_79(ulong a, double b);
                /*0x154e200*/ object <.ctor>b__0_80(float a, byte b);
                /*0x154e440*/ object <.ctor>b__0_81(float a, sbyte b);
                /*0x154e620*/ object <.ctor>b__0_82(float a, short b);
                /*0x154e740*/ object <.ctor>b__0_83(float a, ushort b);
                /*0x154e8c0*/ object <.ctor>b__0_84(float a, int b);
                /*0x154e9e0*/ object <.ctor>b__0_85(float a, uint b);
                /*0x154eb10*/ object <.ctor>b__0_86(float a, long b);
                /*0x154ee10*/ object <.ctor>b__0_87(float a, ulong b);
                /*0x154ee90*/ object <.ctor>b__0_88(float a, float b);
                /*0x154f150*/ object <.ctor>b__0_89(float a, double b);
                /*0x154f6c0*/ object <.ctor>b__0_90(decimal a, byte b);
                /*0x154f940*/ object <.ctor>b__0_91(decimal a, sbyte b);
                /*0x154fbc0*/ object <.ctor>b__0_92(decimal a, short b);
                /*0x154fee0*/ object <.ctor>b__0_93(decimal a, ushort b);
                /*0x1550020*/ object <.ctor>b__0_94(decimal a, int b);
                /*0x1550340*/ object <.ctor>b__0_95(decimal a, uint b);
                /*0x1550520*/ object <.ctor>b__0_96(decimal a, long b);
                /*0x1550700*/ object <.ctor>b__0_97(decimal a, ulong b);
                /*0x1550b30*/ object <.ctor>b__0_98(decimal a, decimal b);
                /*0x1550c20*/ object <.ctor>b__0_99(double a, byte b);
                /*0x1543940*/ object <.ctor>b__0_100(double a, sbyte b);
                /*0x1543b20*/ object <.ctor>b__0_101(double a, short b);
                /*0x1543c40*/ object <.ctor>b__0_102(double a, ushort b);
                /*0x1543dc0*/ object <.ctor>b__0_103(double a, int b);
                /*0x1544000*/ object <.ctor>b__0_104(double a, uint b);
                /*0x15440c0*/ object <.ctor>b__0_105(double a, long b);
                /*0x1544260*/ object <.ctor>b__0_106(double a, ulong b);
                /*0x15444b0*/ object <.ctor>b__0_107(double a, float b);
                /*0x15445e0*/ object <.ctor>b__0_108(double a, double b);
            }
        }

        class MultiplicationHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x1534560*/ MultiplicationHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.MultiplicationHandler.<> <>9;
                static /*0x8*/ System.Func<byte, byte, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, short, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, int, object> <>9__0_4;
                static /*0x30*/ System.Func<byte, uint, object> <>9__0_5;
                static /*0x38*/ System.Func<byte, long, object> <>9__0_6;
                static /*0x40*/ System.Func<byte, ulong, object> <>9__0_7;
                static /*0x48*/ System.Func<byte, float, object> <>9__0_8;
                static /*0x50*/ System.Func<byte, decimal, object> <>9__0_9;
                static /*0x58*/ System.Func<byte, double, object> <>9__0_10;
                static /*0x60*/ System.Func<sbyte, byte, object> <>9__0_11;
                static /*0x68*/ System.Func<sbyte, sbyte, object> <>9__0_12;
                static /*0x70*/ System.Func<sbyte, short, object> <>9__0_13;
                static /*0x78*/ System.Func<sbyte, ushort, object> <>9__0_14;
                static /*0x80*/ System.Func<sbyte, int, object> <>9__0_15;
                static /*0x88*/ System.Func<sbyte, uint, object> <>9__0_16;
                static /*0x90*/ System.Func<sbyte, long, object> <>9__0_17;
                static /*0x98*/ System.Func<sbyte, float, object> <>9__0_18;
                static /*0xa0*/ System.Func<sbyte, decimal, object> <>9__0_19;
                static /*0xa8*/ System.Func<sbyte, double, object> <>9__0_20;
                static /*0xb0*/ System.Func<short, byte, object> <>9__0_21;
                static /*0xb8*/ System.Func<short, sbyte, object> <>9__0_22;
                static /*0xc0*/ System.Func<short, short, object> <>9__0_23;
                static /*0xc8*/ System.Func<short, ushort, object> <>9__0_24;
                static /*0xd0*/ System.Func<short, int, object> <>9__0_25;
                static /*0xd8*/ System.Func<short, uint, object> <>9__0_26;
                static /*0xe0*/ System.Func<short, long, object> <>9__0_27;
                static /*0xe8*/ System.Func<short, float, object> <>9__0_28;
                static /*0xf0*/ System.Func<short, decimal, object> <>9__0_29;
                static /*0xf8*/ System.Func<short, double, object> <>9__0_30;
                static /*0x100*/ System.Func<ushort, byte, object> <>9__0_31;
                static /*0x108*/ System.Func<ushort, sbyte, object> <>9__0_32;
                static /*0x110*/ System.Func<ushort, short, object> <>9__0_33;
                static /*0x118*/ System.Func<ushort, ushort, object> <>9__0_34;
                static /*0x120*/ System.Func<ushort, int, object> <>9__0_35;
                static /*0x128*/ System.Func<ushort, uint, object> <>9__0_36;
                static /*0x130*/ System.Func<ushort, long, object> <>9__0_37;
                static /*0x138*/ System.Func<ushort, ulong, object> <>9__0_38;
                static /*0x140*/ System.Func<ushort, float, object> <>9__0_39;
                static /*0x148*/ System.Func<ushort, decimal, object> <>9__0_40;
                static /*0x150*/ System.Func<ushort, double, object> <>9__0_41;
                static /*0x158*/ System.Func<int, byte, object> <>9__0_42;
                static /*0x160*/ System.Func<int, sbyte, object> <>9__0_43;
                static /*0x168*/ System.Func<int, short, object> <>9__0_44;
                static /*0x170*/ System.Func<int, ushort, object> <>9__0_45;
                static /*0x178*/ System.Func<int, int, object> <>9__0_46;
                static /*0x180*/ System.Func<int, uint, object> <>9__0_47;
                static /*0x188*/ System.Func<int, long, object> <>9__0_48;
                static /*0x190*/ System.Func<int, float, object> <>9__0_49;
                static /*0x198*/ System.Func<int, decimal, object> <>9__0_50;
                static /*0x1a0*/ System.Func<int, double, object> <>9__0_51;
                static /*0x1a8*/ System.Func<uint, byte, object> <>9__0_52;
                static /*0x1b0*/ System.Func<uint, sbyte, object> <>9__0_53;
                static /*0x1b8*/ System.Func<uint, short, object> <>9__0_54;
                static /*0x1c0*/ System.Func<uint, ushort, object> <>9__0_55;
                static /*0x1c8*/ System.Func<uint, int, object> <>9__0_56;
                static /*0x1d0*/ System.Func<uint, uint, object> <>9__0_57;
                static /*0x1d8*/ System.Func<uint, long, object> <>9__0_58;
                static /*0x1e0*/ System.Func<uint, ulong, object> <>9__0_59;
                static /*0x1e8*/ System.Func<uint, float, object> <>9__0_60;
                static /*0x1f0*/ System.Func<uint, decimal, object> <>9__0_61;
                static /*0x1f8*/ System.Func<uint, double, object> <>9__0_62;
                static /*0x200*/ System.Func<long, byte, object> <>9__0_63;
                static /*0x208*/ System.Func<long, sbyte, object> <>9__0_64;
                static /*0x210*/ System.Func<long, short, object> <>9__0_65;
                static /*0x218*/ System.Func<long, ushort, object> <>9__0_66;
                static /*0x220*/ System.Func<long, int, object> <>9__0_67;
                static /*0x228*/ System.Func<long, uint, object> <>9__0_68;
                static /*0x230*/ System.Func<long, long, object> <>9__0_69;
                static /*0x238*/ System.Func<long, float, object> <>9__0_70;
                static /*0x240*/ System.Func<long, decimal, object> <>9__0_71;
                static /*0x248*/ System.Func<long, double, object> <>9__0_72;
                static /*0x250*/ System.Func<ulong, byte, object> <>9__0_73;
                static /*0x258*/ System.Func<ulong, ushort, object> <>9__0_74;
                static /*0x260*/ System.Func<ulong, uint, object> <>9__0_75;
                static /*0x268*/ System.Func<ulong, ulong, object> <>9__0_76;
                static /*0x270*/ System.Func<ulong, float, object> <>9__0_77;
                static /*0x278*/ System.Func<ulong, decimal, object> <>9__0_78;
                static /*0x280*/ System.Func<ulong, double, object> <>9__0_79;
                static /*0x288*/ System.Func<float, byte, object> <>9__0_80;
                static /*0x290*/ System.Func<float, sbyte, object> <>9__0_81;
                static /*0x298*/ System.Func<float, short, object> <>9__0_82;
                static /*0x2a0*/ System.Func<float, ushort, object> <>9__0_83;
                static /*0x2a8*/ System.Func<float, int, object> <>9__0_84;
                static /*0x2b0*/ System.Func<float, uint, object> <>9__0_85;
                static /*0x2b8*/ System.Func<float, long, object> <>9__0_86;
                static /*0x2c0*/ System.Func<float, ulong, object> <>9__0_87;
                static /*0x2c8*/ System.Func<float, float, object> <>9__0_88;
                static /*0x2d0*/ System.Func<float, double, object> <>9__0_89;
                static /*0x2d8*/ System.Func<decimal, byte, object> <>9__0_90;
                static /*0x2e0*/ System.Func<decimal, sbyte, object> <>9__0_91;
                static /*0x2e8*/ System.Func<decimal, short, object> <>9__0_92;
                static /*0x2f0*/ System.Func<decimal, ushort, object> <>9__0_93;
                static /*0x2f8*/ System.Func<decimal, int, object> <>9__0_94;
                static /*0x300*/ System.Func<decimal, uint, object> <>9__0_95;
                static /*0x308*/ System.Func<decimal, long, object> <>9__0_96;
                static /*0x310*/ System.Func<decimal, ulong, object> <>9__0_97;
                static /*0x318*/ System.Func<decimal, decimal, object> <>9__0_98;
                static /*0x320*/ System.Func<double, byte, object> <>9__0_99;
                static /*0x328*/ System.Func<double, sbyte, object> <>9__0_100;
                static /*0x330*/ System.Func<double, short, object> <>9__0_101;
                static /*0x338*/ System.Func<double, ushort, object> <>9__0_102;
                static /*0x340*/ System.Func<double, int, object> <>9__0_103;
                static /*0x348*/ System.Func<double, uint, object> <>9__0_104;
                static /*0x350*/ System.Func<double, long, object> <>9__0_105;
                static /*0x358*/ System.Func<double, ulong, object> <>9__0_106;
                static /*0x360*/ System.Func<double, float, object> <>9__0_107;
                static /*0x368*/ System.Func<double, double, object> <>9__0_108;

                static /*0x1551180*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1543640*/ object <.ctor>b__0_0(byte a, byte b);
                /*0x1545db0*/ object <.ctor>b__0_1(byte a, sbyte b);
                /*0x1547760*/ object <.ctor>b__0_2(byte a, short b);
                /*0x15490d0*/ object <.ctor>b__0_3(byte a, ushort b);
                /*0x154a5d0*/ object <.ctor>b__0_4(byte a, int b);
                /*0x154b950*/ object <.ctor>b__0_5(byte a, uint b);
                /*0x154cbe0*/ object <.ctor>b__0_6(byte a, long b);
                /*0x154e150*/ object <.ctor>b__0_7(byte a, ulong b);
                /*0x154f290*/ object <.ctor>b__0_8(byte a, float b);
                /*0x1550e40*/ object <.ctor>b__0_9(byte a, decimal b);
                /*0x15447c0*/ object <.ctor>b__0_10(byte a, double b);
                /*0x1544b40*/ object <.ctor>b__0_11(sbyte a, byte b);
                /*0x1544c50*/ object <.ctor>b__0_12(sbyte a, sbyte b);
                /*0x1544f80*/ object <.ctor>b__0_13(sbyte a, short b);
                /*0x1544fd0*/ object <.ctor>b__0_14(sbyte a, ushort b);
                /*0x1545230*/ object <.ctor>b__0_15(sbyte a, int b);
                /*0x1545560*/ object <.ctor>b__0_16(sbyte a, uint b);
                /*0x15456e0*/ object <.ctor>b__0_17(sbyte a, long b);
                /*0x15459c0*/ object <.ctor>b__0_18(sbyte a, float b);
                /*0x1545d10*/ object <.ctor>b__0_19(sbyte a, decimal b);
                /*0x1546260*/ object <.ctor>b__0_20(sbyte a, double b);
                /*0x15462c0*/ object <.ctor>b__0_21(short a, byte b);
                /*0x1546550*/ object <.ctor>b__0_22(short a, sbyte b);
                /*0x15468f0*/ object <.ctor>b__0_23(short a, short b);
                /*0x1546af0*/ object <.ctor>b__0_24(short a, ushort b);
                /*0x1546c30*/ object <.ctor>b__0_25(short a, int b);
                /*0x1546f10*/ object <.ctor>b__0_26(short a, uint b);
                /*0x1546f70*/ object <.ctor>b__0_27(short a, long b);
                /*0x1547260*/ object <.ctor>b__0_28(short a, float b);
                /*0x1547470*/ object <.ctor>b__0_29(short a, decimal b);
                /*0x1547bd0*/ object <.ctor>b__0_30(short a, double b);
                /*0x1547c90*/ object <.ctor>b__0_31(ushort a, byte b);
                /*0x1548000*/ object <.ctor>b__0_32(ushort a, sbyte b);
                /*0x15480a0*/ object <.ctor>b__0_33(ushort a, short b);
                /*0x15483c0*/ object <.ctor>b__0_34(ushort a, ushort b);
                /*0x1548510*/ object <.ctor>b__0_35(ushort a, int b);
                /*0x1548820*/ object <.ctor>b__0_36(ushort a, uint b);
                /*0x1548920*/ object <.ctor>b__0_37(ushort a, long b);
                /*0x1548ae0*/ object <.ctor>b__0_38(ushort a, ulong b);
                /*0x1548c90*/ object <.ctor>b__0_39(ushort a, float b);
                /*0x1549300*/ object <.ctor>b__0_40(ushort a, decimal b);
                /*0x15494e0*/ object <.ctor>b__0_41(ushort a, double b);
                /*0x15496b0*/ object <.ctor>b__0_42(int a, byte b);
                /*0x1549850*/ object <.ctor>b__0_43(int a, sbyte b);
                /*0x15499a0*/ object <.ctor>b__0_44(int a, short b);
                /*0x1549b90*/ object <.ctor>b__0_45(int a, ushort b);
                /*0x1549ce0*/ object <.ctor>b__0_46(int a, int b);
                /*0x1549f20*/ object <.ctor>b__0_47(int a, uint b);
                /*0x154a1a0*/ object <.ctor>b__0_48(int a, long b);
                /*0x154a380*/ object <.ctor>b__0_49(int a, float b);
                /*0x154a710*/ object <.ctor>b__0_50(int a, decimal b);
                /*0x154aaa0*/ object <.ctor>b__0_51(int a, double b);
                /*0x154abb0*/ object <.ctor>b__0_52(uint a, byte b);
                /*0x154ad60*/ object <.ctor>b__0_53(uint a, sbyte b);
                /*0x154b020*/ object <.ctor>b__0_54(uint a, short b);
                /*0x154b0d0*/ object <.ctor>b__0_55(uint a, ushort b);
                /*0x154b370*/ object <.ctor>b__0_56(uint a, int b);
                /*0x154b4c0*/ object <.ctor>b__0_57(uint a, uint b);
                /*0x154b560*/ object <.ctor>b__0_58(uint a, long b);
                /*0x154b710*/ object <.ctor>b__0_59(uint a, ulong b);
                /*0x154bb00*/ object <.ctor>b__0_60(uint a, float b);
                /*0x154bcc0*/ object <.ctor>b__0_61(uint a, decimal b);
                /*0x154bf60*/ object <.ctor>b__0_62(uint a, double b);
                /*0x154c140*/ object <.ctor>b__0_63(long a, byte b);
                /*0x154c2c0*/ object <.ctor>b__0_64(long a, sbyte b);
                /*0x154c440*/ object <.ctor>b__0_65(long a, short b);
                /*0x154c500*/ object <.ctor>b__0_66(long a, ushort b);
                /*0x154c6d0*/ object <.ctor>b__0_67(long a, int b);
                /*0x154c780*/ object <.ctor>b__0_68(long a, uint b);
                /*0x154c8e0*/ object <.ctor>b__0_69(long a, long b);
                /*0x154cda0*/ object <.ctor>b__0_70(long a, float b);
                /*0x154d000*/ object <.ctor>b__0_71(long a, decimal b);
                /*0x154d140*/ object <.ctor>b__0_72(long a, double b);
                /*0x154d320*/ object <.ctor>b__0_73(ulong a, byte b);
                /*0x154d500*/ object <.ctor>b__0_74(ulong a, ushort b);
                /*0x154d660*/ object <.ctor>b__0_75(ulong a, uint b);
                /*0x154d820*/ object <.ctor>b__0_76(ulong a, ulong b);
                /*0x154d980*/ object <.ctor>b__0_77(ulong a, float b);
                /*0x154dc60*/ object <.ctor>b__0_78(ulong a, decimal b);
                /*0x154de80*/ object <.ctor>b__0_79(ulong a, double b);
                /*0x154e320*/ object <.ctor>b__0_80(float a, byte b);
                /*0x154e3e0*/ object <.ctor>b__0_81(float a, sbyte b);
                /*0x154e500*/ object <.ctor>b__0_82(float a, short b);
                /*0x154e7a0*/ object <.ctor>b__0_83(float a, ushort b);
                /*0x154e800*/ object <.ctor>b__0_84(float a, int b);
                /*0x154eab0*/ object <.ctor>b__0_85(float a, uint b);
                /*0x154ec30*/ object <.ctor>b__0_86(float a, long b);
                /*0x154ec90*/ object <.ctor>b__0_87(float a, ulong b);
                /*0x154f030*/ object <.ctor>b__0_88(float a, float b);
                /*0x154f1c0*/ object <.ctor>b__0_89(float a, double b);
                /*0x154f620*/ object <.ctor>b__0_90(decimal a, byte b);
                /*0x154f8a0*/ object <.ctor>b__0_91(decimal a, sbyte b);
                /*0x154fa80*/ object <.ctor>b__0_92(decimal a, short b);
                /*0x154fe40*/ object <.ctor>b__0_93(decimal a, ushort b);
                /*0x15500c0*/ object <.ctor>b__0_94(decimal a, int b);
                /*0x15502a0*/ object <.ctor>b__0_95(decimal a, uint b);
                /*0x15505c0*/ object <.ctor>b__0_96(decimal a, long b);
                /*0x1550840*/ object <.ctor>b__0_97(decimal a, ulong b);
                /*0x1550980*/ object <.ctor>b__0_98(decimal a, decimal b);
                /*0x1550c80*/ object <.ctor>b__0_99(double a, byte b);
                /*0x15439a0*/ object <.ctor>b__0_100(double a, sbyte b);
                /*0x1543a60*/ object <.ctor>b__0_101(double a, short b);
                /*0x1543d00*/ object <.ctor>b__0_102(double a, ushort b);
                /*0x1543e80*/ object <.ctor>b__0_103(double a, int b);
                /*0x1543ee0*/ object <.ctor>b__0_104(double a, uint b);
                /*0x1544180*/ object <.ctor>b__0_105(double a, long b);
                /*0x1544360*/ object <.ctor>b__0_106(double a, ulong b);
                /*0x15443e0*/ object <.ctor>b__0_107(double a, float b);
                /*0x1544650*/ object <.ctor>b__0_108(double a, double b);
            }
        }

        class NumericNegationHandler : Unity.VisualScripting.UnaryOperatorHandler
        {
            /*0x153a340*/ NumericNegationHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.NumericNegationHandler.<> <>9;
                static /*0x8*/ System.Func<byte, object> <>9__0_0;
                static /*0x10*/ System.Func<sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<short, object> <>9__0_2;
                static /*0x20*/ System.Func<ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<int, object> <>9__0_4;
                static /*0x30*/ System.Func<uint, object> <>9__0_5;
                static /*0x38*/ System.Func<long, object> <>9__0_6;
                static /*0x40*/ System.Func<float, object> <>9__0_7;
                static /*0x48*/ System.Func<decimal, object> <>9__0_8;
                static /*0x50*/ System.Func<double, object> <>9__0_9;

                static /*0x1551110*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1543750*/ object <.ctor>b__0_0(byte a);
                /*0x1545f00*/ object <.ctor>b__0_1(sbyte a);
                /*0x15478b0*/ object <.ctor>b__0_2(short a);
                /*0x1549170*/ object <.ctor>b__0_3(ushort a);
                /*0x154a4e0*/ object <.ctor>b__0_4(int a);
                /*0x154b7b0*/ object <.ctor>b__0_5(uint a);
                /*0x154caa0*/ object <.ctor>b__0_6(long a);
                /*0x154df50*/ object <.ctor>b__0_7(float a);
                /*0x154f340*/ object <.ctor>b__0_8(decimal a);
                /*0x1551070*/ object <.ctor>b__0_9(double a);
            }
        }

        class OperatorException : System.InvalidCastException
        {
            /*0x14c9430*/ OperatorException();
            /*0x14c9440*/ OperatorException(string message);
            /*0x14c9450*/ OperatorException(string message, System.Exception innerException);
        }

        class OperatorHandler
        {
            /*0x10*/ string <name>k__BackingField;
            /*0x18*/ string <verb>k__BackingField;
            /*0x20*/ string <symbol>k__BackingField;
            /*0x28*/ string <customMethodName>k__BackingField;

            /*0x153ac20*/ OperatorHandler(string name, string verb, string symbol, string customMethodName);
            /*0x73d3e0*/ string get_name();
            /*0x32f410*/ string get_verb();
            /*0x61a260*/ string get_symbol();
            /*0x79a150*/ string get_customMethodName();
        }

        class OperatorUtility
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<string, string> operatorNames;
            static /*0x8*/ System.Collections.Generic.Dictionary<string, int> operatorRanks;
            static /*0x10*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.UnaryOperator, Unity.VisualScripting.UnaryOperatorHandler> unaryOperatorHandlers;
            static /*0x18*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.BinaryOperator, Unity.VisualScripting.BinaryOperatorHandler> binaryOpeatorHandlers;
            static /*0x20*/ Unity.VisualScripting.LogicalNegationHandler logicalNegationHandler;
            static /*0x28*/ Unity.VisualScripting.NumericNegationHandler numericNegationHandler;
            static /*0x30*/ Unity.VisualScripting.IncrementHandler incrementHandler;
            static /*0x38*/ Unity.VisualScripting.DecrementHandler decrementHandler;
            static /*0x40*/ Unity.VisualScripting.PlusHandler plusHandler;
            static /*0x48*/ Unity.VisualScripting.AdditionHandler additionHandler;
            static /*0x50*/ Unity.VisualScripting.SubtractionHandler subtractionHandler;
            static /*0x58*/ Unity.VisualScripting.MultiplicationHandler multiplicationHandler;
            static /*0x60*/ Unity.VisualScripting.DivisionHandler divisionHandler;
            static /*0x68*/ Unity.VisualScripting.ModuloHandler moduloHandler;
            static /*0x70*/ Unity.VisualScripting.AndHandler andHandler;
            static /*0x78*/ Unity.VisualScripting.OrHandler orHandler;
            static /*0x80*/ Unity.VisualScripting.ExclusiveOrHandler exclusiveOrHandler;
            static /*0x88*/ Unity.VisualScripting.EqualityHandler equalityHandler;
            static /*0x90*/ Unity.VisualScripting.InequalityHandler inequalityHandler;
            static /*0x98*/ Unity.VisualScripting.GreaterThanHandler greaterThanHandler;
            static /*0xa0*/ Unity.VisualScripting.LessThanHandler lessThanHandler;
            static /*0xa8*/ Unity.VisualScripting.GreaterThanOrEqualHandler greaterThanOrEqualHandler;
            static /*0xb0*/ Unity.VisualScripting.LessThanOrEqualHandler lessThanOrEqualHandler;
            static /*0xb8*/ Unity.VisualScripting.LeftShiftHandler leftShiftHandler;
            static /*0xc0*/ Unity.VisualScripting.RightShiftHandler rightShiftHandler;

            static /*0x153c120*/ OperatorUtility();
            static /*0x153b210*/ Unity.VisualScripting.UnaryOperatorHandler GetHandler(Unity.VisualScripting.UnaryOperator operator);
            static /*0x153b0f0*/ Unity.VisualScripting.BinaryOperatorHandler GetHandler(Unity.VisualScripting.BinaryOperator operator);
            static /*0x153bf30*/ string Symbol(Unity.VisualScripting.UnaryOperator operator);
            static /*0x153bf90*/ string Symbol(Unity.VisualScripting.BinaryOperator operator);
            static /*0x153b890*/ string Name(Unity.VisualScripting.UnaryOperator operator);
            static /*0x153b8f0*/ string Name(Unity.VisualScripting.BinaryOperator operator);
            static /*0x153c0c0*/ string Verb(Unity.VisualScripting.UnaryOperator operator);
            static /*0x153c060*/ string Verb(Unity.VisualScripting.BinaryOperator operator);
            static /*0x153bb00*/ object Operate(Unity.VisualScripting.UnaryOperator operator, object x);
            static /*0x153bc30*/ object Operate(Unity.VisualScripting.BinaryOperator operator, object a, object b);
            static /*0x153b950*/ object Negate(object x);
            static /*0x153ba90*/ object Not(object x);
            static /*0x153bff0*/ object UnaryPlus(object x);
            static /*0x153b4d0*/ object Increment(object x);
            static /*0x153ae90*/ object Decrement(object x);
            static /*0x153ae00*/ object And(object a, object b);
            static /*0x153bd80*/ object Or(object a, object b);
            static /*0x153b060*/ object ExclusiveOr(object a, object b);
            static /*0x153ad70*/ object Add(object a, object b);
            static /*0x153bea0*/ object Subtract(object a, object b);
            static /*0x153b800*/ object Multiply(object a, object b);
            static /*0x153af00*/ object Divide(object a, object b);
            static /*0x153b770*/ object Modulo(object a, object b);
            static /*0x153af90*/ bool Equal(object a, object b);
            static /*0x153b9c0*/ bool NotEqual(object a, object b);
            static /*0x153b400*/ bool GreaterThan(object a, object b);
            static /*0x153b6a0*/ bool LessThan(object a, object b);
            static /*0x153b330*/ bool GreaterThanOrEqual(object a, object b);
            static /*0x153b5d0*/ bool LessThanOrEqual(object a, object b);
            static /*0x153b540*/ object LeftShift(object a, object b);
            static /*0x153be10*/ object RightShift(object a, object b);
        }

        class OrHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x153d8a0*/ OrHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.OrHandler.<> <>9;
                static /*0x8*/ System.Func<bool, bool, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, byte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, sbyte, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, short, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, ushort, object> <>9__0_4;
                static /*0x30*/ System.Func<byte, int, object> <>9__0_5;
                static /*0x38*/ System.Func<byte, uint, object> <>9__0_6;
                static /*0x40*/ System.Func<byte, long, object> <>9__0_7;
                static /*0x48*/ System.Func<byte, ulong, object> <>9__0_8;
                static /*0x50*/ System.Func<sbyte, byte, object> <>9__0_9;
                static /*0x58*/ System.Func<sbyte, sbyte, object> <>9__0_10;
                static /*0x60*/ System.Func<sbyte, short, object> <>9__0_11;
                static /*0x68*/ System.Func<sbyte, ushort, object> <>9__0_12;
                static /*0x70*/ System.Func<sbyte, int, object> <>9__0_13;
                static /*0x78*/ System.Func<sbyte, uint, object> <>9__0_14;
                static /*0x80*/ System.Func<sbyte, long, object> <>9__0_15;
                static /*0x88*/ System.Func<short, byte, object> <>9__0_16;
                static /*0x90*/ System.Func<short, sbyte, object> <>9__0_17;
                static /*0x98*/ System.Func<short, short, object> <>9__0_18;
                static /*0xa0*/ System.Func<short, ushort, object> <>9__0_19;
                static /*0xa8*/ System.Func<short, int, object> <>9__0_20;
                static /*0xb0*/ System.Func<short, uint, object> <>9__0_21;
                static /*0xb8*/ System.Func<short, long, object> <>9__0_22;
                static /*0xc0*/ System.Func<ushort, byte, object> <>9__0_23;
                static /*0xc8*/ System.Func<ushort, sbyte, object> <>9__0_24;
                static /*0xd0*/ System.Func<ushort, short, object> <>9__0_25;
                static /*0xd8*/ System.Func<ushort, ushort, object> <>9__0_26;
                static /*0xe0*/ System.Func<ushort, int, object> <>9__0_27;
                static /*0xe8*/ System.Func<ushort, uint, object> <>9__0_28;
                static /*0xf0*/ System.Func<ushort, long, object> <>9__0_29;
                static /*0xf8*/ System.Func<ushort, ulong, object> <>9__0_30;
                static /*0x100*/ System.Func<int, byte, object> <>9__0_31;
                static /*0x108*/ System.Func<int, sbyte, object> <>9__0_32;
                static /*0x110*/ System.Func<int, short, object> <>9__0_33;
                static /*0x118*/ System.Func<int, ushort, object> <>9__0_34;
                static /*0x120*/ System.Func<int, int, object> <>9__0_35;
                static /*0x128*/ System.Func<int, uint, object> <>9__0_36;
                static /*0x130*/ System.Func<int, long, object> <>9__0_37;
                static /*0x138*/ System.Func<uint, byte, object> <>9__0_38;
                static /*0x140*/ System.Func<uint, sbyte, object> <>9__0_39;
                static /*0x148*/ System.Func<uint, short, object> <>9__0_40;
                static /*0x150*/ System.Func<uint, ushort, object> <>9__0_41;
                static /*0x158*/ System.Func<uint, int, object> <>9__0_42;
                static /*0x160*/ System.Func<uint, uint, object> <>9__0_43;
                static /*0x168*/ System.Func<uint, long, object> <>9__0_44;
                static /*0x170*/ System.Func<uint, ulong, object> <>9__0_45;
                static /*0x178*/ System.Func<long, byte, object> <>9__0_46;
                static /*0x180*/ System.Func<long, sbyte, object> <>9__0_47;
                static /*0x188*/ System.Func<long, short, object> <>9__0_48;
                static /*0x190*/ System.Func<long, ushort, object> <>9__0_49;
                static /*0x198*/ System.Func<long, int, object> <>9__0_50;
                static /*0x1a0*/ System.Func<long, uint, object> <>9__0_51;
                static /*0x1a8*/ System.Func<long, long, object> <>9__0_52;
                static /*0x1b0*/ System.Func<ulong, byte, object> <>9__0_53;
                static /*0x1b8*/ System.Func<ulong, ushort, object> <>9__0_54;
                static /*0x1c0*/ System.Func<ulong, uint, object> <>9__0_55;
                static /*0x1c8*/ System.Func<ulong, ulong, object> <>9__0_56;

                static /*0x1551420*/ <>c();
                /*0x32f970*/ <>c();
                /*0x15437a0*/ object <.ctor>b__0_0(bool a, bool b);
                /*0x1545fa0*/ object <.ctor>b__0_1(byte a, byte b);
                /*0x15479b0*/ object <.ctor>b__0_2(byte a, sbyte b);
                /*0x1549120*/ object <.ctor>b__0_3(byte a, short b);
                /*0x154a490*/ object <.ctor>b__0_4(byte a, ushort b);
                /*0x154b850*/ object <.ctor>b__0_5(byte a, int b);
                /*0x154cb90*/ object <.ctor>b__0_6(byte a, uint b);
                /*0x154dfa0*/ object <.ctor>b__0_7(byte a, long b);
                /*0x154f4d0*/ object <.ctor>b__0_8(byte a, ulong b);
                /*0x15510c0*/ object <.ctor>b__0_9(sbyte a, byte b);
                /*0x1544770*/ object <.ctor>b__0_10(sbyte a, sbyte b);
                /*0x15449f0*/ object <.ctor>b__0_11(sbyte a, short b);
                /*0x1544d00*/ object <.ctor>b__0_12(sbyte a, ushort b);
                /*0x1544e10*/ object <.ctor>b__0_13(sbyte a, int b);
                /*0x1545180*/ object <.ctor>b__0_14(sbyte a, uint b);
                /*0x1545390*/ object <.ctor>b__0_15(sbyte a, long b);
                /*0x1545450*/ object <.ctor>b__0_16(short a, byte b);
                /*0x1545800*/ object <.ctor>b__0_17(short a, sbyte b);
                /*0x1545970*/ object <.ctor>b__0_18(short a, short b);
                /*0x1545bc0*/ object <.ctor>b__0_19(short a, ushort b);
                /*0x1546150*/ object <.ctor>b__0_20(short a, int b);
                /*0x1546490*/ object <.ctor>b__0_21(short a, uint b);
                /*0x1546600*/ object <.ctor>b__0_22(short a, long b);
                /*0x1546840*/ object <.ctor>b__0_23(ushort a, byte b);
                /*0x15469f0*/ object <.ctor>b__0_24(ushort a, sbyte b);
                /*0x1546b40*/ object <.ctor>b__0_25(ushort a, short b);
                /*0x1546e00*/ object <.ctor>b__0_26(ushort a, ushort b);
                /*0x1546fd0*/ object <.ctor>b__0_27(ushort a, int b);
                /*0x1547380*/ object <.ctor>b__0_28(ushort a, uint b);
                /*0x1547610*/ object <.ctor>b__0_29(ushort a, long b);
                /*0x1547b80*/ object <.ctor>b__0_30(ushort a, ulong b);
                /*0x1547e00*/ object <.ctor>b__0_31(int a, byte b);
                /*0x1547f00*/ object <.ctor>b__0_32(int a, sbyte b);
                /*0x15481a0*/ object <.ctor>b__0_33(int a, short b);
                /*0x1548310*/ object <.ctor>b__0_34(int a, ushort b);
                /*0x15484c0*/ object <.ctor>b__0_35(int a, int b);
                /*0x15486c0*/ object <.ctor>b__0_36(int a, uint b);
                /*0x15489e0*/ object <.ctor>b__0_37(int a, long b);
                /*0x1548b40*/ object <.ctor>b__0_38(uint a, byte b);
                /*0x1548cf0*/ object <.ctor>b__0_39(uint a, sbyte b);
                /*0x15493a0*/ object <.ctor>b__0_40(uint a, short b);
                /*0x1549490*/ object <.ctor>b__0_41(uint a, ushort b);
                /*0x1549750*/ object <.ctor>b__0_42(uint a, int b);
                /*0x15498f0*/ object <.ctor>b__0_43(uint a, uint b);
                /*0x1549a50*/ object <.ctor>b__0_44(uint a, long b);
                /*0x1549b40*/ object <.ctor>b__0_45(uint a, ulong b);
                /*0x1549d30*/ object <.ctor>b__0_46(long a, byte b);
                /*0x1549fe0*/ object <.ctor>b__0_47(long a, sbyte b);
                /*0x154a0a0*/ object <.ctor>b__0_48(long a, short b);
                /*0x154a2c0*/ object <.ctor>b__0_49(long a, ushort b);
                /*0x154a6c0*/ object <.ctor>b__0_50(long a, int b);
                /*0x154aa50*/ object <.ctor>b__0_51(long a, uint b);
                /*0x154ab60*/ object <.ctor>b__0_52(long a, long b);
                /*0x154ad00*/ object <.ctor>b__0_53(ulong a, byte b);
                /*0x154af70*/ object <.ctor>b__0_54(ulong a, ushort b);
                /*0x154b170*/ object <.ctor>b__0_55(ulong a, uint b);
                /*0x154b220*/ object <.ctor>b__0_56(ulong a, ulong b);
            }
        }

        class PlusHandler : Unity.VisualScripting.UnaryOperatorHandler
        {
            /*0x15409c0*/ PlusHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.PlusHandler.<> <>9;
                static /*0x8*/ System.Func<byte, object> <>9__0_0;
                static /*0x10*/ System.Func<sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<short, object> <>9__0_2;
                static /*0x20*/ System.Func<ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<int, object> <>9__0_4;
                static /*0x30*/ System.Func<uint, object> <>9__0_5;
                static /*0x38*/ System.Func<long, object> <>9__0_6;
                static /*0x40*/ System.Func<ulong, object> <>9__0_7;
                static /*0x48*/ System.Func<float, object> <>9__0_8;
                static /*0x50*/ System.Func<decimal, object> <>9__0_9;
                static /*0x58*/ System.Func<double, object> <>9__0_10;

                static /*0x15512d0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1543840*/ object <.ctor>b__0_0(byte a);
                /*0x1546050*/ object <.ctor>b__0_1(sbyte a);
                /*0x1547810*/ object <.ctor>b__0_2(short a);
                /*0x1548ec0*/ object <.ctor>b__0_3(ushort a);
                /*0x154a620*/ object <.ctor>b__0_4(int a);
                /*0x154ba50*/ object <.ctor>b__0_5(uint a);
                /*0x154caf0*/ object <.ctor>b__0_6(long a);
                /*0x154e0a0*/ object <.ctor>b__0_7(ulong a);
                /*0x154f2f0*/ object <.ctor>b__0_8(float a);
                /*0x1550ee0*/ object <.ctor>b__0_9(decimal a);
                /*0x1544820*/ object <.ctor>b__0_10(double a);
            }
        }

        class RightShiftHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x1541360*/ RightShiftHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.RightShiftHandler.<> <>9;
                static /*0x8*/ System.Func<byte, byte, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, short, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, int, object> <>9__0_4;
                static /*0x30*/ System.Func<sbyte, byte, object> <>9__0_5;
                static /*0x38*/ System.Func<sbyte, sbyte, object> <>9__0_6;
                static /*0x40*/ System.Func<sbyte, short, object> <>9__0_7;
                static /*0x48*/ System.Func<sbyte, ushort, object> <>9__0_8;
                static /*0x50*/ System.Func<sbyte, int, object> <>9__0_9;
                static /*0x58*/ System.Func<short, byte, object> <>9__0_10;
                static /*0x60*/ System.Func<short, sbyte, object> <>9__0_11;
                static /*0x68*/ System.Func<short, short, object> <>9__0_12;
                static /*0x70*/ System.Func<short, ushort, object> <>9__0_13;
                static /*0x78*/ System.Func<short, int, object> <>9__0_14;
                static /*0x80*/ System.Func<ushort, byte, object> <>9__0_15;
                static /*0x88*/ System.Func<ushort, sbyte, object> <>9__0_16;
                static /*0x90*/ System.Func<ushort, short, object> <>9__0_17;
                static /*0x98*/ System.Func<ushort, ushort, object> <>9__0_18;
                static /*0xa0*/ System.Func<ushort, int, object> <>9__0_19;
                static /*0xa8*/ System.Func<int, byte, object> <>9__0_20;
                static /*0xb0*/ System.Func<int, sbyte, object> <>9__0_21;
                static /*0xb8*/ System.Func<int, short, object> <>9__0_22;
                static /*0xc0*/ System.Func<int, ushort, object> <>9__0_23;
                static /*0xc8*/ System.Func<int, int, object> <>9__0_24;
                static /*0xd0*/ System.Func<uint, byte, object> <>9__0_25;
                static /*0xd8*/ System.Func<uint, sbyte, object> <>9__0_26;
                static /*0xe0*/ System.Func<uint, short, object> <>9__0_27;
                static /*0xe8*/ System.Func<uint, ushort, object> <>9__0_28;
                static /*0xf0*/ System.Func<uint, int, object> <>9__0_29;
                static /*0xf8*/ System.Func<long, byte, object> <>9__0_30;
                static /*0x100*/ System.Func<long, sbyte, object> <>9__0_31;
                static /*0x108*/ System.Func<long, short, object> <>9__0_32;
                static /*0x110*/ System.Func<long, ushort, object> <>9__0_33;
                static /*0x118*/ System.Func<long, int, object> <>9__0_34;
                static /*0x120*/ System.Func<ulong, byte, object> <>9__0_35;
                static /*0x128*/ System.Func<ulong, sbyte, object> <>9__0_36;
                static /*0x130*/ System.Func<ulong, short, object> <>9__0_37;
                static /*0x138*/ System.Func<ulong, ushort, object> <>9__0_38;
                static /*0x140*/ System.Func<ulong, int, object> <>9__0_39;

                static /*0x1551260*/ <>c();
                /*0x32f970*/ <>c();
                /*0x15436f0*/ object <.ctor>b__0_0(byte a, byte b);
                /*0x1545ff0*/ object <.ctor>b__0_1(byte a, sbyte b);
                /*0x15477b0*/ object <.ctor>b__0_2(byte a, short b);
                /*0x1549020*/ object <.ctor>b__0_3(byte a, ushort b);
                /*0x154a430*/ object <.ctor>b__0_4(byte a, int b);
                /*0x154b8f0*/ object <.ctor>b__0_5(sbyte a, byte b);
                /*0x154ca40*/ object <.ctor>b__0_6(sbyte a, sbyte b);
                /*0x154dff0*/ object <.ctor>b__0_7(sbyte a, short b);
                /*0x154f520*/ object <.ctor>b__0_8(sbyte a, ushort b);
                /*0x1550d40*/ object <.ctor>b__0_9(sbyte a, int b);
                /*0x1544870*/ object <.ctor>b__0_10(short a, byte b);
                /*0x1544990*/ object <.ctor>b__0_11(short a, sbyte b);
                /*0x1544d50*/ object <.ctor>b__0_12(short a, short b);
                /*0x1544db0*/ object <.ctor>b__0_13(short a, ushort b);
                /*0x1545120*/ object <.ctor>b__0_14(short a, int b);
                /*0x1545330*/ object <.ctor>b__0_15(ushort a, byte b);
                /*0x15453f0*/ object <.ctor>b__0_16(ushort a, sbyte b);
                /*0x1545620*/ object <.ctor>b__0_17(ushort a, short b);
                /*0x1545850*/ object <.ctor>b__0_18(ushort a, ushort b);
                /*0x1545c10*/ object <.ctor>b__0_19(ushort a, int b);
                /*0x1546090*/ object <.ctor>b__0_20(int a, byte b);
                /*0x1546370*/ object <.ctor>b__0_21(int a, sbyte b);
                /*0x15465a0*/ object <.ctor>b__0_22(int a, short b);
                /*0x1546890*/ object <.ctor>b__0_23(int a, ushort b);
                /*0x1546a90*/ object <.ctor>b__0_24(int a, int b);
                /*0x1546c80*/ object <.ctor>b__0_25(uint a, byte b);
                /*0x1546d40*/ object <.ctor>b__0_26(uint a, sbyte b);
                /*0x15470e0*/ object <.ctor>b__0_27(uint a, short b);
                /*0x15472c0*/ object <.ctor>b__0_28(uint a, ushort b);
                /*0x1547510*/ object <.ctor>b__0_29(uint a, int b);
                /*0x1547a00*/ object <.ctor>b__0_30(long a, byte b);
                /*0x1547d40*/ object <.ctor>b__0_31(long a, sbyte b);
                /*0x1547e50*/ object <.ctor>b__0_32(long a, short b);
                /*0x1548140*/ object <.ctor>b__0_33(long a, ushort b);
                /*0x1548250*/ object <.ctor>b__0_34(long a, int b);
                /*0x15485b0*/ object <.ctor>b__0_35(ulong a, byte b);
                /*0x15487c0*/ object <.ctor>b__0_36(ulong a, sbyte b);
                /*0x1548980*/ object <.ctor>b__0_37(ulong a, short b);
                /*0x1548a80*/ object <.ctor>b__0_38(ulong a, ushort b);
                /*0x1548e00*/ object <.ctor>b__0_39(ulong a, int b);
            }
        }

        class SubtractionHandler : Unity.VisualScripting.BinaryOperatorHandler
        {
            /*0x1562690*/ SubtractionHandler();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.SubtractionHandler.<> <>9;
                static /*0x8*/ System.Func<byte, byte, object> <>9__0_0;
                static /*0x10*/ System.Func<byte, sbyte, object> <>9__0_1;
                static /*0x18*/ System.Func<byte, short, object> <>9__0_2;
                static /*0x20*/ System.Func<byte, ushort, object> <>9__0_3;
                static /*0x28*/ System.Func<byte, int, object> <>9__0_4;
                static /*0x30*/ System.Func<byte, uint, object> <>9__0_5;
                static /*0x38*/ System.Func<byte, long, object> <>9__0_6;
                static /*0x40*/ System.Func<byte, ulong, object> <>9__0_7;
                static /*0x48*/ System.Func<byte, float, object> <>9__0_8;
                static /*0x50*/ System.Func<byte, decimal, object> <>9__0_9;
                static /*0x58*/ System.Func<byte, double, object> <>9__0_10;
                static /*0x60*/ System.Func<sbyte, byte, object> <>9__0_11;
                static /*0x68*/ System.Func<sbyte, sbyte, object> <>9__0_12;
                static /*0x70*/ System.Func<sbyte, short, object> <>9__0_13;
                static /*0x78*/ System.Func<sbyte, ushort, object> <>9__0_14;
                static /*0x80*/ System.Func<sbyte, int, object> <>9__0_15;
                static /*0x88*/ System.Func<sbyte, uint, object> <>9__0_16;
                static /*0x90*/ System.Func<sbyte, long, object> <>9__0_17;
                static /*0x98*/ System.Func<sbyte, float, object> <>9__0_18;
                static /*0xa0*/ System.Func<sbyte, decimal, object> <>9__0_19;
                static /*0xa8*/ System.Func<sbyte, double, object> <>9__0_20;
                static /*0xb0*/ System.Func<short, byte, object> <>9__0_21;
                static /*0xb8*/ System.Func<short, sbyte, object> <>9__0_22;
                static /*0xc0*/ System.Func<short, short, object> <>9__0_23;
                static /*0xc8*/ System.Func<short, ushort, object> <>9__0_24;
                static /*0xd0*/ System.Func<short, int, object> <>9__0_25;
                static /*0xd8*/ System.Func<short, uint, object> <>9__0_26;
                static /*0xe0*/ System.Func<short, long, object> <>9__0_27;
                static /*0xe8*/ System.Func<short, float, object> <>9__0_28;
                static /*0xf0*/ System.Func<short, decimal, object> <>9__0_29;
                static /*0xf8*/ System.Func<short, double, object> <>9__0_30;
                static /*0x100*/ System.Func<ushort, byte, object> <>9__0_31;
                static /*0x108*/ System.Func<ushort, sbyte, object> <>9__0_32;
                static /*0x110*/ System.Func<ushort, short, object> <>9__0_33;
                static /*0x118*/ System.Func<ushort, ushort, object> <>9__0_34;
                static /*0x120*/ System.Func<ushort, int, object> <>9__0_35;
                static /*0x128*/ System.Func<ushort, uint, object> <>9__0_36;
                static /*0x130*/ System.Func<ushort, long, object> <>9__0_37;
                static /*0x138*/ System.Func<ushort, ulong, object> <>9__0_38;
                static /*0x140*/ System.Func<ushort, float, object> <>9__0_39;
                static /*0x148*/ System.Func<ushort, decimal, object> <>9__0_40;
                static /*0x150*/ System.Func<ushort, double, object> <>9__0_41;
                static /*0x158*/ System.Func<int, byte, object> <>9__0_42;
                static /*0x160*/ System.Func<int, sbyte, object> <>9__0_43;
                static /*0x168*/ System.Func<int, short, object> <>9__0_44;
                static /*0x170*/ System.Func<int, ushort, object> <>9__0_45;
                static /*0x178*/ System.Func<int, int, object> <>9__0_46;
                static /*0x180*/ System.Func<int, uint, object> <>9__0_47;
                static /*0x188*/ System.Func<int, long, object> <>9__0_48;
                static /*0x190*/ System.Func<int, float, object> <>9__0_49;
                static /*0x198*/ System.Func<int, decimal, object> <>9__0_50;
                static /*0x1a0*/ System.Func<int, double, object> <>9__0_51;
                static /*0x1a8*/ System.Func<uint, byte, object> <>9__0_52;
                static /*0x1b0*/ System.Func<uint, sbyte, object> <>9__0_53;
                static /*0x1b8*/ System.Func<uint, short, object> <>9__0_54;
                static /*0x1c0*/ System.Func<uint, ushort, object> <>9__0_55;
                static /*0x1c8*/ System.Func<uint, int, object> <>9__0_56;
                static /*0x1d0*/ System.Func<uint, uint, object> <>9__0_57;
                static /*0x1d8*/ System.Func<uint, long, object> <>9__0_58;
                static /*0x1e0*/ System.Func<uint, ulong, object> <>9__0_59;
                static /*0x1e8*/ System.Func<uint, float, object> <>9__0_60;
                static /*0x1f0*/ System.Func<uint, decimal, object> <>9__0_61;
                static /*0x1f8*/ System.Func<uint, double, object> <>9__0_62;
                static /*0x200*/ System.Func<long, byte, object> <>9__0_63;
                static /*0x208*/ System.Func<long, sbyte, object> <>9__0_64;
                static /*0x210*/ System.Func<long, short, object> <>9__0_65;
                static /*0x218*/ System.Func<long, ushort, object> <>9__0_66;
                static /*0x220*/ System.Func<long, int, object> <>9__0_67;
                static /*0x228*/ System.Func<long, uint, object> <>9__0_68;
                static /*0x230*/ System.Func<long, long, object> <>9__0_69;
                static /*0x238*/ System.Func<long, float, object> <>9__0_70;
                static /*0x240*/ System.Func<long, decimal, object> <>9__0_71;
                static /*0x248*/ System.Func<long, double, object> <>9__0_72;
                static /*0x250*/ System.Func<ulong, byte, object> <>9__0_73;
                static /*0x258*/ System.Func<ulong, ushort, object> <>9__0_74;
                static /*0x260*/ System.Func<ulong, uint, object> <>9__0_75;
                static /*0x268*/ System.Func<ulong, ulong, object> <>9__0_76;
                static /*0x270*/ System.Func<ulong, float, object> <>9__0_77;
                static /*0x278*/ System.Func<ulong, decimal, object> <>9__0_78;
                static /*0x280*/ System.Func<ulong, double, object> <>9__0_79;
                static /*0x288*/ System.Func<float, byte, object> <>9__0_80;
                static /*0x290*/ System.Func<float, sbyte, object> <>9__0_81;
                static /*0x298*/ System.Func<float, short, object> <>9__0_82;
                static /*0x2a0*/ System.Func<float, ushort, object> <>9__0_83;
                static /*0x2a8*/ System.Func<float, int, object> <>9__0_84;
                static /*0x2b0*/ System.Func<float, uint, object> <>9__0_85;
                static /*0x2b8*/ System.Func<float, long, object> <>9__0_86;
                static /*0x2c0*/ System.Func<float, ulong, object> <>9__0_87;
                static /*0x2c8*/ System.Func<float, float, object> <>9__0_88;
                static /*0x2d0*/ System.Func<float, double, object> <>9__0_89;
                static /*0x2d8*/ System.Func<decimal, byte, object> <>9__0_90;
                static /*0x2e0*/ System.Func<decimal, sbyte, object> <>9__0_91;
                static /*0x2e8*/ System.Func<decimal, short, object> <>9__0_92;
                static /*0x2f0*/ System.Func<decimal, ushort, object> <>9__0_93;
                static /*0x2f8*/ System.Func<decimal, int, object> <>9__0_94;
                static /*0x300*/ System.Func<decimal, uint, object> <>9__0_95;
                static /*0x308*/ System.Func<decimal, long, object> <>9__0_96;
                static /*0x310*/ System.Func<decimal, ulong, object> <>9__0_97;
                static /*0x318*/ System.Func<decimal, decimal, object> <>9__0_98;
                static /*0x320*/ System.Func<double, byte, object> <>9__0_99;
                static /*0x328*/ System.Func<double, sbyte, object> <>9__0_100;
                static /*0x330*/ System.Func<double, short, object> <>9__0_101;
                static /*0x338*/ System.Func<double, ushort, object> <>9__0_102;
                static /*0x340*/ System.Func<double, int, object> <>9__0_103;
                static /*0x348*/ System.Func<double, uint, object> <>9__0_104;
                static /*0x350*/ System.Func<double, long, object> <>9__0_105;
                static /*0x358*/ System.Func<double, ulong, object> <>9__0_106;
                static /*0x360*/ System.Func<double, float, object> <>9__0_107;
                static /*0x368*/ System.Func<double, double, object> <>9__0_108;

                static /*0x1573bf0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1570e70*/ object <.ctor>b__0_0(byte a, byte b);
                /*0x1571600*/ object <.ctor>b__0_1(byte a, sbyte b);
                /*0x1571a00*/ object <.ctor>b__0_2(byte a, short b);
                /*0x1571d90*/ object <.ctor>b__0_3(byte a, ushort b);
                /*0x1572170*/ object <.ctor>b__0_4(byte a, int b);
                /*0x1572540*/ object <.ctor>b__0_5(byte a, uint b);
                /*0x1572960*/ object <.ctor>b__0_6(byte a, long b);
                /*0x1572e10*/ object <.ctor>b__0_7(byte a, ulong b);
                /*0x1573250*/ object <.ctor>b__0_8(byte a, float b);
                /*0x15738a0*/ object <.ctor>b__0_9(byte a, decimal b);
                /*0x1571250*/ object <.ctor>b__0_10(byte a, double b);
                /*0x15712b0*/ object <.ctor>b__0_11(sbyte a, byte b);
                /*0x1571300*/ object <.ctor>b__0_12(sbyte a, sbyte b);
                /*0x1571350*/ object <.ctor>b__0_13(sbyte a, short b);
                /*0x15713a0*/ object <.ctor>b__0_14(sbyte a, ushort b);
                /*0x15713f0*/ object <.ctor>b__0_15(sbyte a, int b);
                /*0x1571440*/ object <.ctor>b__0_16(sbyte a, uint b);
                /*0x15714a0*/ object <.ctor>b__0_17(sbyte a, long b);
                /*0x1571500*/ object <.ctor>b__0_18(sbyte a, float b);
                /*0x1571560*/ object <.ctor>b__0_19(sbyte a, decimal b);
                /*0x1571650*/ object <.ctor>b__0_20(sbyte a, double b);
                /*0x15716b0*/ object <.ctor>b__0_21(short a, byte b);
                /*0x1571700*/ object <.ctor>b__0_22(short a, sbyte b);
                /*0x1571750*/ object <.ctor>b__0_23(short a, short b);
                /*0x15717a0*/ object <.ctor>b__0_24(short a, ushort b);
                /*0x15717f0*/ object <.ctor>b__0_25(short a, int b);
                /*0x1571840*/ object <.ctor>b__0_26(short a, uint b);
                /*0x15718a0*/ object <.ctor>b__0_27(short a, long b);
                /*0x1571900*/ object <.ctor>b__0_28(short a, float b);
                /*0x1571960*/ object <.ctor>b__0_29(short a, decimal b);
                /*0x1571a50*/ object <.ctor>b__0_30(short a, double b);
                /*0x1571ab0*/ object <.ctor>b__0_31(ushort a, byte b);
                /*0x1571b00*/ object <.ctor>b__0_32(ushort a, sbyte b);
                /*0x1571b50*/ object <.ctor>b__0_33(ushort a, short b);
                /*0x1571ba0*/ object <.ctor>b__0_34(ushort a, ushort b);
                /*0x1571bf0*/ object <.ctor>b__0_35(ushort a, int b);
                /*0x1571c40*/ object <.ctor>b__0_36(ushort a, uint b);
                /*0x1571c90*/ object <.ctor>b__0_37(ushort a, long b);
                /*0x1571ce0*/ object <.ctor>b__0_38(ushort a, ulong b);
                /*0x1571d30*/ object <.ctor>b__0_39(ushort a, float b);
                /*0x1571de0*/ object <.ctor>b__0_40(ushort a, decimal b);
                /*0x1571e80*/ object <.ctor>b__0_41(ushort a, double b);
                /*0x1571ee0*/ object <.ctor>b__0_42(int a, byte b);
                /*0x1571f30*/ object <.ctor>b__0_43(int a, sbyte b);
                /*0x1571f80*/ object <.ctor>b__0_44(int a, short b);
                /*0x1571fd0*/ object <.ctor>b__0_45(int a, ushort b);
                /*0x1572020*/ object <.ctor>b__0_46(int a, int b);
                /*0x1572070*/ object <.ctor>b__0_47(int a, uint b);
                /*0x15720c0*/ object <.ctor>b__0_48(int a, long b);
                /*0x1572110*/ object <.ctor>b__0_49(int a, float b);
                /*0x15721c0*/ object <.ctor>b__0_50(int a, decimal b);
                /*0x1572260*/ object <.ctor>b__0_51(int a, double b);
                /*0x15722c0*/ object <.ctor>b__0_52(uint a, byte b);
                /*0x1572310*/ object <.ctor>b__0_53(uint a, sbyte b);
                /*0x1572360*/ object <.ctor>b__0_54(uint a, short b);
                /*0x15723b0*/ object <.ctor>b__0_55(uint a, ushort b);
                /*0x1572400*/ object <.ctor>b__0_56(uint a, int b);
                /*0x1572450*/ object <.ctor>b__0_57(uint a, uint b);
                /*0x15724a0*/ object <.ctor>b__0_58(uint a, long b);
                /*0x15724f0*/ object <.ctor>b__0_59(uint a, ulong b);
                /*0x1572590*/ object <.ctor>b__0_60(uint a, float b);
                /*0x15725f0*/ object <.ctor>b__0_61(uint a, decimal b);
                /*0x1572690*/ object <.ctor>b__0_62(uint a, double b);
                /*0x15726f0*/ object <.ctor>b__0_63(long a, byte b);
                /*0x1572750*/ object <.ctor>b__0_64(long a, sbyte b);
                /*0x15727b0*/ object <.ctor>b__0_65(long a, short b);
                /*0x1572810*/ object <.ctor>b__0_66(long a, ushort b);
                /*0x1572870*/ object <.ctor>b__0_67(long a, int b);
                /*0x15728c0*/ object <.ctor>b__0_68(long a, uint b);
                /*0x1572910*/ object <.ctor>b__0_69(long a, long b);
                /*0x15729b0*/ object <.ctor>b__0_70(long a, float b);
                /*0x1572a10*/ object <.ctor>b__0_71(long a, decimal b);
                /*0x1572ab0*/ object <.ctor>b__0_72(long a, double b);
                /*0x1572b10*/ object <.ctor>b__0_73(ulong a, byte b);
                /*0x1572b70*/ object <.ctor>b__0_74(ulong a, ushort b);
                /*0x1572bd0*/ object <.ctor>b__0_75(ulong a, uint b);
                /*0x1572c20*/ object <.ctor>b__0_76(ulong a, ulong b);
                /*0x1572c70*/ object <.ctor>b__0_77(ulong a, float b);
                /*0x1572cf0*/ object <.ctor>b__0_78(ulong a, decimal b);
                /*0x1572d90*/ object <.ctor>b__0_79(ulong a, double b);
                /*0x1572e60*/ object <.ctor>b__0_80(float a, byte b);
                /*0x1572ec0*/ object <.ctor>b__0_81(float a, sbyte b);
                /*0x1572f20*/ object <.ctor>b__0_82(float a, short b);
                /*0x1572f80*/ object <.ctor>b__0_83(float a, ushort b);
                /*0x1572fe0*/ object <.ctor>b__0_84(float a, int b);
                /*0x1573040*/ object <.ctor>b__0_85(float a, uint b);
                /*0x15730a0*/ object <.ctor>b__0_86(float a, long b);
                /*0x1573100*/ object <.ctor>b__0_87(float a, ulong b);
                /*0x1573180*/ object <.ctor>b__0_88(float a, float b);
                /*0x15731e0*/ object <.ctor>b__0_89(float a, double b);
                /*0x15732b0*/ object <.ctor>b__0_90(decimal a, byte b);
                /*0x1573350*/ object <.ctor>b__0_91(decimal a, sbyte b);
                /*0x15733f0*/ object <.ctor>b__0_92(decimal a, short b);
                /*0x1573490*/ object <.ctor>b__0_93(decimal a, ushort b);
                /*0x1573530*/ object <.ctor>b__0_94(decimal a, int b);
                /*0x15735d0*/ object <.ctor>b__0_95(decimal a, uint b);
                /*0x1573670*/ object <.ctor>b__0_96(decimal a, long b);
                /*0x1573710*/ object <.ctor>b__0_97(decimal a, ulong b);
                /*0x15737b0*/ object <.ctor>b__0_98(decimal a, decimal b);
                /*0x1573840*/ object <.ctor>b__0_99(double a, byte b);
                /*0x1570ec0*/ object <.ctor>b__0_100(double a, sbyte b);
                /*0x1570f20*/ object <.ctor>b__0_101(double a, short b);
                /*0x1570f80*/ object <.ctor>b__0_102(double a, ushort b);
                /*0x1570fe0*/ object <.ctor>b__0_103(double a, int b);
                /*0x1571040*/ object <.ctor>b__0_104(double a, uint b);
                /*0x15710a0*/ object <.ctor>b__0_105(double a, long b);
                /*0x1571100*/ object <.ctor>b__0_106(double a, ulong b);
                /*0x1571180*/ object <.ctor>b__0_107(double a, float b);
                /*0x15711f0*/ object <.ctor>b__0_108(double a, double b);
            }
        }

        enum UnaryOperator
        {
            LogicalNegation = 0,
            NumericNegation = 1,
            Increment = 2,
            Decrement = 3,
            Plus = 4,
        }

        class UnaryOperatorHandler : Unity.VisualScripting.OperatorHandler
        {
            /*0x30*/ System.Collections.Generic.Dictionary<System.Type, System.Func<object, object>> manualHandlers;
            /*0x38*/ System.Collections.Generic.Dictionary<System.Type, Unity.VisualScripting.IOptimizedInvoker> userDefinedOperators;
            /*0x40*/ System.Collections.Generic.Dictionary<System.Type, System.Type> userDefinedOperandTypes;

            static /*0x1574110*/ System.Type ResolveUserDefinedOperandType(System.Reflection.MethodInfo userDefinedOperator);
            /*0x1574170*/ UnaryOperatorHandler(string name, string verb, string symbol, string customMethodName);
            /*0x1573d50*/ object Operate(object operand);
            /*0x1573cd0*/ object CustomHandling(object operand);
            /*0x17aec0*/ void Handle<T>(System.Func<T, object> handler);

            class <>c__DisplayClass6_0<T>
            {
                /*0x0*/ System.Func<T, object> handler;

                /*0x180fc0*/ <>c__DisplayClass6_0();
                /*0x1858d0*/ object <Handle>b__0(object operand);
            }
        }

        class Action<T1, T2, T3, T4, T5> : System.MulticastDelegate
        {
            Action(object object, nint method);
            /*0x2a5510*/ void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
            /*0x2a5510*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, System.AsyncCallback callback, object object);
            /*0x17aec0*/ void EndInvoke(System.IAsyncResult result);
        }

        class Action<T1, T2, T3, T4, T5, T6> : System.MulticastDelegate
        {
            Action(object object, nint method);
            /*0x2a5510*/ void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
            /*0x2a5510*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, System.AsyncCallback callback, object object);
            /*0x17aec0*/ void EndInvoke(System.IAsyncResult result);
        }

        class Func<T1, T2, T3, T4, T5, TResult> : System.MulticastDelegate
        {
            Func(object object, nint method);
            /*0x2a5510*/ TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);
            /*0x2a5510*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, System.AsyncCallback callback, object object);
            /*0x2a5510*/ TResult EndInvoke(System.IAsyncResult result);
        }

        class Func<T1, T2, T3, T4, T5, T6, TResult> : System.MulticastDelegate
        {
            Func(object object, nint method);
            /*0x2a5510*/ TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);
            /*0x2a5510*/ System.IAsyncResult BeginInvoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, System.AsyncCallback callback, object object);
            /*0x2a5510*/ TResult EndInvoke(System.IAsyncResult result);
        }

        class InstanceActionInvokerBase<TTarget> : Unity.VisualScripting.InstanceInvokerBase<TTarget>
        {
            /*0x17aec0*/ InstanceActionInvokerBase(System.Reflection.MethodInfo methodInfo);
        }

        class InstanceActionInvoker<TTarget> : Unity.VisualScripting.InstanceActionInvokerBase<TTarget>
        {
            /*0x0*/ System.Action<TTarget> invoke;

            /*0x17aec0*/ InstanceActionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x1858d0*/ object Invoke(object target);
            /*0x1858d0*/ object InvokeUnsafe(object target);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
        }

        class InstanceActionInvoker<TTarget, TParam0> : Unity.VisualScripting.InstanceActionInvokerBase<TTarget>
        {
            /*0x0*/ System.Action<TTarget, TParam0> invoke;

            /*0x17aec0*/ InstanceActionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x177730*/ object Invoke(object target, object arg0);
            /*0x177730*/ object InvokeUnsafe(object target, object arg0);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
        }

        class InstanceActionInvoker<TTarget, TParam0, TParam1> : Unity.VisualScripting.InstanceActionInvokerBase<TTarget>
        {
            /*0x0*/ System.Action<TTarget, TParam0, TParam1> invoke;

            /*0x17aec0*/ InstanceActionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x177dc0*/ object Invoke(object target, object arg0, object arg1);
            /*0x177dc0*/ object InvokeUnsafe(object target, object arg0, object arg1);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
        }

        class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2> : Unity.VisualScripting.InstanceActionInvokerBase<TTarget>
        {
            /*0x0*/ System.Action<TTarget, TParam0, TParam1, TParam2> invoke;

            /*0x17aec0*/ InstanceActionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x177ff0*/ object Invoke(object target, object arg0, object arg1, object arg2);
            /*0x177ff0*/ object InvokeUnsafe(object target, object arg0, object arg1, object arg2);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
        }

        class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3> : Unity.VisualScripting.InstanceActionInvokerBase<TTarget>
        {
            /*0x0*/ Unity.VisualScripting.Action<TTarget, TParam0, TParam1, TParam2, TParam3> invoke;

            /*0x17aec0*/ InstanceActionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x178140*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3);
            /*0x178140*/ object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
        }

        class InstanceActionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4> : Unity.VisualScripting.InstanceActionInvokerBase<TTarget>
        {
            /*0x0*/ Unity.VisualScripting.Action<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4> invoke;

            /*0x17aec0*/ InstanceActionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x1782f0*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4);
            /*0x1782f0*/ object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3, object arg4);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
        }

        class InstanceFieldAccessor<TTarget, TField> : Unity.VisualScripting.IOptimizedAccessor
        {
            /*0x0*/ System.Reflection.FieldInfo fieldInfo;
            /*0x0*/ System.Func<TTarget, TField> getter;
            /*0x0*/ System.Action<TTarget, TField> setter;

            /*0x17aec0*/ InstanceFieldAccessor(System.Reflection.FieldInfo fieldInfo);
            /*0x180fc0*/ void Compile();
            /*0x1858d0*/ object GetValue(object target);
            /*0x1858d0*/ object GetValueUnsafe(object target);
            /*0x183150*/ void SetValue(object target, object value);
            /*0x183150*/ void SetValueUnsafe(object target, object value);
            /*0x2a5510*/ TField <Compile>b__4_0(TTarget instance);
            /*0x2a5510*/ void <Compile>b__4_1(TTarget instance, TField value);
        }

        class InstanceFunctionInvokerBase<TTarget, TResult> : Unity.VisualScripting.InstanceInvokerBase<TTarget>
        {
            /*0x17aec0*/ InstanceFunctionInvokerBase(System.Reflection.MethodInfo methodInfo);
        }

        class InstanceFunctionInvoker<TTarget, TResult> : Unity.VisualScripting.InstanceFunctionInvokerBase<TTarget, TResult>
        {
            /*0x0*/ System.Func<TTarget, TResult> invoke;

            /*0x17aec0*/ InstanceFunctionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x1858d0*/ object Invoke(object target);
            /*0x1858d0*/ object InvokeUnsafe(object target);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
        }

        class InstanceFunctionInvoker<TTarget, TParam0, TResult> : Unity.VisualScripting.InstanceFunctionInvokerBase<TTarget, TResult>
        {
            /*0x0*/ System.Func<TTarget, TParam0, TResult> invoke;

            /*0x17aec0*/ InstanceFunctionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x177730*/ object Invoke(object target, object arg0);
            /*0x177730*/ object InvokeUnsafe(object target, object arg0);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
        }

        class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TResult> : Unity.VisualScripting.InstanceFunctionInvokerBase<TTarget, TResult>
        {
            /*0x0*/ System.Func<TTarget, TParam0, TParam1, TResult> invoke;

            /*0x17aec0*/ InstanceFunctionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x177dc0*/ object Invoke(object target, object arg0, object arg1);
            /*0x177dc0*/ object InvokeUnsafe(object target, object arg0, object arg1);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
        }

        class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TResult> : Unity.VisualScripting.InstanceFunctionInvokerBase<TTarget, TResult>
        {
            /*0x0*/ System.Func<TTarget, TParam0, TParam1, TParam2, TResult> invoke;

            /*0x17aec0*/ InstanceFunctionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x177ff0*/ object Invoke(object target, object arg0, object arg1, object arg2);
            /*0x177ff0*/ object InvokeUnsafe(object target, object arg0, object arg1, object arg2);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
        }

        class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TResult> : Unity.VisualScripting.InstanceFunctionInvokerBase<TTarget, TResult>
        {
            /*0x0*/ Unity.VisualScripting.Func<TTarget, TParam0, TParam1, TParam2, TParam3, TResult> invoke;

            /*0x17aec0*/ InstanceFunctionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x178140*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3);
            /*0x178140*/ object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
        }

        class InstanceFunctionInvoker<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4, TResult> : Unity.VisualScripting.InstanceFunctionInvokerBase<TTarget, TResult>
        {
            /*0x0*/ Unity.VisualScripting.Func<TTarget, TParam0, TParam1, TParam2, TParam3, TParam4, TResult> invoke;

            /*0x17aec0*/ InstanceFunctionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x1782f0*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4);
            /*0x1782f0*/ object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3, object arg4);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
        }

        class InstanceInvokerBase<TTarget> : Unity.VisualScripting.InvokerBase
        {
            /*0x17aec0*/ InstanceInvokerBase(System.Reflection.MethodInfo methodInfo);
            /*0x180fc0*/ void CompileExpression();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x17aec0*/ void VerifyTarget(object target);
        }

        class InstancePropertyAccessor<TTarget, TProperty> : Unity.VisualScripting.IOptimizedAccessor
        {
            /*0x0*/ System.Reflection.PropertyInfo propertyInfo;
            /*0x0*/ System.Func<TTarget, TProperty> getter;
            /*0x0*/ System.Action<TTarget, TProperty> setter;

            /*0x17aec0*/ InstancePropertyAccessor(System.Reflection.PropertyInfo propertyInfo);
            /*0x180fc0*/ void Compile();
            /*0x1858d0*/ object GetValue(object target);
            /*0x1858d0*/ object GetValueUnsafe(object target);
            /*0x183150*/ void SetValue(object target, object value);
            /*0x183150*/ void SetValueUnsafe(object target, object value);
        }

        class InvokerBase : Unity.VisualScripting.IOptimizedInvoker
        {
            /*0x10*/ System.Type targetType;
            /*0x18*/ System.Reflection.MethodInfo methodInfo;

            /*0x1553300*/ InvokerBase(System.Reflection.MethodInfo methodInfo);
            /*0x182bb0*/ void VerifyArgument<TParam>(System.Reflection.MethodInfo methodInfo, int argIndex, object arg);
            /*0x1552d30*/ void Compile();
            /*0x1552e60*/ System.Linq.Expressions.ParameterExpression[] GetParameterExpressions();
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x1553240*/ object Invoke(object target);
            /*0x15532c0*/ object Invoke(object target, object arg0);
            /*0x1553280*/ object Invoke(object target, object arg0, object arg1);
            /*0x15531c0*/ object Invoke(object target, object arg0, object arg1, object arg2);
            /*0x1553200*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3);
            /*0x1553180*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4);
            /*0x180fc0*/ void CompileExpression();
            /*0x180fc0*/ void CreateDelegate();
            /*0x17aec0*/ void VerifyTarget(object target);
        }

        interface IOptimizedAccessor
        {
            /*0x180fc0*/ void Compile();
            /*0x1858d0*/ object GetValue(object target);
            /*0x183150*/ void SetValue(object target, object value);
        }

        interface IOptimizedInvoker
        {
            /*0x180fc0*/ void Compile();
            /*0x1858d0*/ object Invoke(object target);
            /*0x177730*/ object Invoke(object target, object arg0);
            /*0x177dc0*/ object Invoke(object target, object arg0, object arg1);
            /*0x177ff0*/ object Invoke(object target, object arg0, object arg1, object arg2);
            /*0x178140*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3);
            /*0x1782f0*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4);
            /*0x177730*/ object Invoke(object target, object[] args);
        }

        class OptimizedReflection
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Reflection.FieldInfo, Unity.VisualScripting.IOptimizedAccessor> fieldAccessors;
            static /*0x8*/ System.Collections.Generic.Dictionary<System.Reflection.PropertyInfo, Unity.VisualScripting.IOptimizedAccessor> propertyAccessors;
            static /*0x10*/ System.Collections.Generic.Dictionary<System.Reflection.MethodInfo, Unity.VisualScripting.IOptimizedInvoker> methodInvokers;
            static /*0x18*/ bool jitAvailable;
            static /*0x19*/ bool _useJitIfAvailable;
            static /*0x1a*/ bool <safeMode>k__BackingField;

            static /*0x1559d50*/ OptimizedReflection();
            static /*0x1559fa0*/ bool get_useJit();
            static /*0x1559f50*/ bool get_useJitIfAvailable();
            static /*0x155a0b0*/ void set_useJitIfAvailable(bool value);
            static /*0x1559f00*/ bool get_safeMode();
            static /*0x155a050*/ void set_safeMode(bool value);
            static /*0x1559340*/ void OnRuntimeMethodLoad();
            static /*0x15543c0*/ void ClearCache();
            static /*0x1559ae0*/ void VerifyStaticTarget(System.Type targetType, object target);
            static /*0x177be0*/ void VerifyInstanceTarget<TTArget>(object target);
            static /*0x1559b40*/ void VerifyTarget(System.Type targetType, object target, bool static);
            static /*0x1559670*/ bool SupportsOptimization(System.Reflection.MemberInfo memberInfo);
            static /*0x1559440*/ Unity.VisualScripting.IOptimizedAccessor Prewarm(System.Reflection.FieldInfo fieldInfo);
            static /*0x1558bb0*/ object GetValueOptimized(System.Reflection.FieldInfo fieldInfo, object target);
            static /*0x1559530*/ void SetValueOptimized(System.Reflection.FieldInfo fieldInfo, object target, object value);
            static /*0x1559a20*/ bool SupportsOptimization(System.Reflection.FieldInfo fieldInfo);
            static /*0x1554490*/ Unity.VisualScripting.IOptimizedAccessor GetFieldAccessor(System.Reflection.FieldInfo fieldInfo);
            static /*0x1559490*/ Unity.VisualScripting.IOptimizedAccessor Prewarm(System.Reflection.PropertyInfo propertyInfo);
            static /*0x1558c40*/ object GetValueOptimized(System.Reflection.PropertyInfo propertyInfo, object target);
            static /*0x15595d0*/ void SetValueOptimized(System.Reflection.PropertyInfo propertyInfo, object target, object value);
            static /*0x1559960*/ bool SupportsOptimization(System.Reflection.PropertyInfo propertyInfo);
            static /*0x1558420*/ Unity.VisualScripting.IOptimizedAccessor GetPropertyAccessor(System.Reflection.PropertyInfo propertyInfo);
            static /*0x15594e0*/ Unity.VisualScripting.IOptimizedInvoker Prewarm(System.Reflection.MethodInfo methodInfo);
            static /*0x1558f10*/ object InvokeOptimized(System.Reflection.MethodInfo methodInfo, object target, object[] args);
            static /*0x1558e80*/ object InvokeOptimized(System.Reflection.MethodInfo methodInfo, object target);
            static /*0x1558de0*/ object InvokeOptimized(System.Reflection.MethodInfo methodInfo, object target, object arg0);
            static /*0x1558cd0*/ object InvokeOptimized(System.Reflection.MethodInfo methodInfo, object target, object arg0, object arg1);
            static /*0x1559120*/ object InvokeOptimized(System.Reflection.MethodInfo methodInfo, object target, object arg0, object arg1, object arg2);
            static /*0x1559230*/ object InvokeOptimized(System.Reflection.MethodInfo methodInfo, object target, object arg0, object arg1, object arg2, object arg3);
            static /*0x1559010*/ object InvokeOptimized(System.Reflection.MethodInfo methodInfo, object target, object arg0, object arg1, object arg2, object arg3, object arg4);
            static /*0x1559700*/ bool SupportsOptimization(System.Reflection.MethodInfo methodInfo);
            static /*0x1554bf0*/ Unity.VisualScripting.IOptimizedInvoker GetMethodInvoker(System.Reflection.MethodInfo methodInfo);

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.OptimizedReflection.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.ParameterInfo, bool> <>9__39_0;

                static /*0x1573c60*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1570e30*/ bool <SupportsOptimization>b__39_0(System.Reflection.ParameterInfo parameter);
            }
        }

        class ReflectionFieldAccessor : Unity.VisualScripting.IOptimizedAccessor
        {
            /*0x10*/ System.Reflection.FieldInfo fieldInfo;

            /*0x155ab60*/ ReflectionFieldAccessor(System.Reflection.FieldInfo fieldInfo);
            /*0x32d010*/ void Compile();
            /*0xe9aa40*/ object GetValue(object target);
            /*0x155ab40*/ void SetValue(object target, object value);
        }

        class ReflectionInvoker : Unity.VisualScripting.IOptimizedInvoker
        {
            static /*0x0*/ object[] EmptyObjects;
            /*0x10*/ System.Reflection.MethodInfo methodInfo;

            static /*0x155b5e0*/ ReflectionInvoker();
            /*0x155b650*/ ReflectionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x32d010*/ void Compile();
            /*0x155b120*/ object Invoke(object target, object[] args);
            /*0x155b560*/ object Invoke(object target);
            /*0x155b490*/ object Invoke(object target, object arg0);
            /*0x155add0*/ object Invoke(object target, object arg0, object arg1);
            /*0x155b140*/ object Invoke(object target, object arg0, object arg1, object arg2);
            /*0x155b2c0*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3);
            /*0x155af00*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4);
            /*0x155ac70*/ System.Type[] GetParameterTypes();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.ReflectionInvoker.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.ParameterInfo, System.Type> <>9__10_0;

                static /*0x1573b10*/ <>c();
                /*0x32f970*/ <>c();
                /*0x14f5370*/ System.Type <GetParameterTypes>b__10_0(System.Reflection.ParameterInfo pi);
            }
        }

        class ReflectionPropertyAccessor : Unity.VisualScripting.IOptimizedAccessor
        {
            /*0x10*/ System.Reflection.PropertyInfo propertyInfo;

            /*0x155b7d0*/ ReflectionPropertyAccessor(System.Reflection.PropertyInfo propertyInfo);
            /*0x32d010*/ void Compile();
            /*0x155b760*/ object GetValue(object target);
            /*0x155b790*/ void SetValue(object target, object value);
        }

        class StaticActionInvokerBase : Unity.VisualScripting.StaticInvokerBase
        {
            /*0x1561ca0*/ StaticActionInvokerBase(System.Reflection.MethodInfo methodInfo);
        }

        class StaticActionInvoker : Unity.VisualScripting.StaticActionInvokerBase
        {
            /*0x20*/ System.Action invoke;

            /*0x1561ca0*/ StaticActionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x1561e60*/ object Invoke(object target, object[] args);
            /*0x1561ed0*/ object Invoke(object target);
            /*0x1561e30*/ object InvokeUnsafe(object target);
            /*0x1561de0*/ System.Type[] GetParameterTypes();
            /*0x1561cb0*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x1561d60*/ void CreateDelegate();
            /*0x1562030*/ void <CreateDelegate>b__7_0();
        }

        class StaticActionInvoker<TParam0> : Unity.VisualScripting.StaticActionInvokerBase
        {
            /*0x0*/ System.Action<TParam0> invoke;

            /*0x17aec0*/ StaticActionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x177730*/ object Invoke(object target, object arg0);
            /*0x177730*/ object InvokeUnsafe(object target, object arg0);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
            /*0x2a5510*/ void <CreateDelegate>b__7_0(TParam0 param0);
        }

        class StaticActionInvoker<TParam0, TParam1> : Unity.VisualScripting.StaticActionInvokerBase
        {
            /*0x0*/ System.Action<TParam0, TParam1> invoke;

            /*0x17aec0*/ StaticActionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x177dc0*/ object Invoke(object target, object arg0, object arg1);
            /*0x177dc0*/ object InvokeUnsafe(object target, object arg0, object arg1);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
            /*0x2a5510*/ void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1);
        }

        class StaticActionInvoker<TParam0, TParam1, TParam2> : Unity.VisualScripting.StaticActionInvokerBase
        {
            /*0x0*/ System.Action<TParam0, TParam1, TParam2> invoke;

            /*0x17aec0*/ StaticActionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x177ff0*/ object Invoke(object target, object arg0, object arg1, object arg2);
            /*0x177ff0*/ object InvokeUnsafe(object target, object arg0, object arg1, object arg2);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
            /*0x2a5510*/ void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2);
        }

        class StaticActionInvoker<TParam0, TParam1, TParam2, TParam3> : Unity.VisualScripting.StaticActionInvokerBase
        {
            /*0x0*/ System.Action<TParam0, TParam1, TParam2, TParam3> invoke;

            /*0x17aec0*/ StaticActionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x178140*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3);
            /*0x178140*/ object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
            /*0x2a5510*/ void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3);
        }

        class StaticActionInvoker<TParam0, TParam1, TParam2, TParam3, TParam4> : Unity.VisualScripting.StaticActionInvokerBase
        {
            /*0x0*/ Unity.VisualScripting.Action<TParam0, TParam1, TParam2, TParam3, TParam4> invoke;

            /*0x17aec0*/ StaticActionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x1782f0*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4);
            /*0x1782f0*/ object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3, object arg4);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
            /*0x2a5510*/ void <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
        }

        class StaticFieldAccessor<TField> : Unity.VisualScripting.IOptimizedAccessor
        {
            /*0x0*/ System.Reflection.FieldInfo fieldInfo;
            /*0x0*/ System.Func<TField> getter;
            /*0x0*/ System.Action<TField> setter;
            /*0x0*/ System.Type targetType;

            /*0x17aec0*/ StaticFieldAccessor(System.Reflection.FieldInfo fieldInfo);
            /*0x180fc0*/ void Compile();
            /*0x1858d0*/ object GetValue(object target);
            /*0x1858d0*/ object GetValueUnsafe(object target);
            /*0x183150*/ void SetValue(object target, object value);
            /*0x183150*/ void SetValueUnsafe(object target, object value);
            /*0x2a5510*/ TField <Compile>b__5_0();
            /*0x2a5510*/ void <Compile>b__5_1(TField value);

            class <>c__DisplayClass5_0<TField>
            {
                /*0x0*/ TField constant;

                /*0x180fc0*/ <>c__DisplayClass5_0();
                /*0x2a5510*/ TField <Compile>b__2();
            }
        }

        class StaticFunctionInvokerBase<TResult> : Unity.VisualScripting.StaticInvokerBase
        {
            /*0x17aec0*/ StaticFunctionInvokerBase(System.Reflection.MethodInfo methodInfo);
        }

        class StaticFunctionInvoker<TResult> : Unity.VisualScripting.StaticFunctionInvokerBase<TResult>
        {
            /*0x0*/ System.Func<TResult> invoke;

            /*0x17aec0*/ StaticFunctionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x1858d0*/ object Invoke(object target);
            /*0x1858d0*/ object InvokeUnsafe(object target);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
            /*0x2a5510*/ TResult <CreateDelegate>b__7_0();
        }

        class StaticFunctionInvoker<TParam0, TResult> : Unity.VisualScripting.StaticFunctionInvokerBase<TResult>
        {
            /*0x0*/ System.Func<TParam0, TResult> invoke;

            /*0x17aec0*/ StaticFunctionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x177730*/ object Invoke(object target, object arg0);
            /*0x177730*/ object InvokeUnsafe(object target, object arg0);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
            /*0x2a5510*/ TResult <CreateDelegate>b__7_0(TParam0 param0);
        }

        class StaticFunctionInvoker<TParam0, TParam1, TResult> : Unity.VisualScripting.StaticFunctionInvokerBase<TResult>
        {
            /*0x0*/ System.Func<TParam0, TParam1, TResult> invoke;

            /*0x17aec0*/ StaticFunctionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x177dc0*/ object Invoke(object target, object arg0, object arg1);
            /*0x177dc0*/ object InvokeUnsafe(object target, object arg0, object arg1);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
            /*0x2a5510*/ TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1);
        }

        class StaticFunctionInvoker<TParam0, TParam1, TParam2, TResult> : Unity.VisualScripting.StaticFunctionInvokerBase<TResult>
        {
            /*0x0*/ System.Func<TParam0, TParam1, TParam2, TResult> invoke;

            /*0x17aec0*/ StaticFunctionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x177ff0*/ object Invoke(object target, object arg0, object arg1, object arg2);
            /*0x177ff0*/ object InvokeUnsafe(object target, object arg0, object arg1, object arg2);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
            /*0x2a5510*/ TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2);
        }

        class StaticFunctionInvoker<TParam0, TParam1, TParam2, TParam3, TResult> : Unity.VisualScripting.StaticFunctionInvokerBase<TResult>
        {
            /*0x0*/ System.Func<TParam0, TParam1, TParam2, TParam3, TResult> invoke;

            /*0x17aec0*/ StaticFunctionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x178140*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3);
            /*0x178140*/ object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
            /*0x2a5510*/ TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3);
        }

        class StaticFunctionInvoker<TParam0, TParam1, TParam2, TParam3, TParam4, TResult> : Unity.VisualScripting.StaticFunctionInvokerBase<TResult>
        {
            /*0x0*/ Unity.VisualScripting.Func<TParam0, TParam1, TParam2, TParam3, TParam4, TResult> invoke;

            /*0x17aec0*/ StaticFunctionInvoker(System.Reflection.MethodInfo methodInfo);
            /*0x177730*/ object Invoke(object target, object[] args);
            /*0x1782f0*/ object Invoke(object target, object arg0, object arg1, object arg2, object arg3, object arg4);
            /*0x1782f0*/ object InvokeUnsafe(object target, object arg0, object arg1, object arg2, object arg3, object arg4);
            /*0x1803b0*/ System.Type[] GetParameterTypes();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x180fc0*/ void CreateDelegate();
            /*0x2a5510*/ TResult <CreateDelegate>b__7_0(TParam0 param0, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
        }

        class StaticInvokerBase : Unity.VisualScripting.InvokerBase
        {
            /*0x1562240*/ StaticInvokerBase(System.Reflection.MethodInfo methodInfo);
            /*0x1562110*/ void CompileExpression();
            /*0x183150*/ void CompileExpression(System.Linq.Expressions.MethodCallExpression callExpression, System.Linq.Expressions.ParameterExpression[] parameterExpressions);
            /*0x15621a0*/ void VerifyTarget(object target);
        }

        class StaticPropertyAccessor<TProperty> : Unity.VisualScripting.IOptimizedAccessor
        {
            /*0x0*/ System.Reflection.PropertyInfo propertyInfo;
            /*0x0*/ System.Func<TProperty> getter;
            /*0x0*/ System.Action<TProperty> setter;
            /*0x0*/ System.Type targetType;

            /*0x17aec0*/ StaticPropertyAccessor(System.Reflection.PropertyInfo propertyInfo);
            /*0x180fc0*/ void Compile();
            /*0x1858d0*/ object GetValue(object target);
            /*0x1858d0*/ object GetValueUnsafe(object target);
            /*0x183150*/ void SetValue(object target, object value);
            /*0x183150*/ void SetValueUnsafe(object target, object value);
        }

        class RenamedAssemblyAttribute : System.Attribute
        {
            /*0x10*/ string <previousName>k__BackingField;
            /*0x18*/ string <newName>k__BackingField;

            /*0xea2f90*/ RenamedAssemblyAttribute(string previousName, string newName);
            /*0x73d3e0*/ string get_previousName();
            /*0x32f410*/ string get_newName();
        }

        class RenamedFromAttribute : System.Attribute
        {
            /*0x10*/ string <previousName>k__BackingField;

            /*0xa32e30*/ RenamedFromAttribute(string previousName);
            /*0x73d3e0*/ string get_previousName();
        }

        class RenamedNamespaceAttribute : System.Attribute
        {
            /*0x10*/ string <previousName>k__BackingField;
            /*0x18*/ string <newName>k__BackingField;

            /*0xea2f90*/ RenamedNamespaceAttribute(string previousName, string newName);
            /*0x73d3e0*/ string get_previousName();
            /*0x32f410*/ string get_newName();
        }

        class RuntimeCodebase
        {
            static /*0x0*/ object lock;
            static /*0x8*/ System.Collections.Generic.List<System.Type> _types;
            static /*0x10*/ System.Collections.Generic.List<System.Reflection.Assembly> _assemblies;
            static /*0x18*/ System.Collections.Generic.HashSet<string> disallowedAssemblies;
            static /*0x20*/ System.Collections.Generic.Dictionary<string, System.Type> typeSerializations;
            static /*0x28*/ System.Collections.Generic.Dictionary<string, System.Type> _renamedTypes;
            static /*0x30*/ System.Collections.Generic.Dictionary<string, string> _renamedNamespaces;
            static /*0x38*/ System.Collections.Generic.Dictionary<string, string> _renamedAssemblies;
            static /*0x40*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.Dictionary<string, string>> _renamedMembers;

            static /*0x155e2b0*/ RuntimeCodebase();
            static /*0x155eba0*/ System.Collections.Generic.IEnumerable<System.Type> get_types();
            static /*0x155e8e0*/ System.Collections.Generic.IEnumerable<System.Reflection.Assembly> get_assemblies();
            static /*0x155cca0*/ System.Collections.Generic.IEnumerable<System.Attribute> GetAssemblyAttributes(System.Type attributeType);
            static /*0x155cc10*/ System.Collections.Generic.IEnumerable<System.Attribute> GetAssemblyAttributes(System.Type attributeType, System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies);
            static /*0x17e030*/ System.Collections.Generic.IEnumerable<TAttribute> GetAssemblyAttributes<TAttribute>(System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies);
            static /*0x180cf0*/ System.Collections.Generic.IEnumerable<TAttribute> GetAssemblyAttributes<TAttribute>();
            static /*0x155cda0*/ void PrewarmTypeDeserialization(System.Type type);
            static /*0x155d060*/ string SerializeType(System.Type type);
            static /*0x155d1a0*/ bool TryDeserializeType(string typeName, ref System.Type type);
            static /*0x155b960*/ System.Type DeserializeType(string typeName);
            static /*0x155b8e0*/ void ClearCachedTypes();
            static /*0x155d110*/ bool TryCachedTypeLookup(string typeName, ref System.Type type);
            static /*0x155dad0*/ bool TrySystemTypeLookup(string typeName, ref System.Type type);
            static /*0x155ded0*/ bool TrySystemTypeLookup(Unity.VisualScripting.TypeName typeName, ref System.Type type);
            static /*0x155d410*/ bool TryRenamedTypeLookup(string previousTypeName, ref System.Type type);
            static /*0x155ea00*/ System.Collections.Generic.Dictionary<string, string> get_renamedNamespaces();
            static /*0x155e930*/ System.Collections.Generic.Dictionary<string, string> get_renamedAssemblies();
            static /*0x155ead0*/ System.Collections.Generic.Dictionary<string, System.Type> get_renamedTypes();
            static /*0x155cf70*/ System.Collections.Generic.Dictionary<string, string> RenamedMembers(System.Type type);
            static /*0x155be10*/ System.Collections.Generic.Dictionary<string, string> FetchRenamedMembers(System.Type type);
            static /*0x155c260*/ System.Collections.Generic.Dictionary<string, string> FetchRenamedNamespaces();
            static /*0x155ba50*/ System.Collections.Generic.Dictionary<string, string> FetchRenamedAssemblies();
            static /*0x155c620*/ System.Collections.Generic.Dictionary<string, System.Type> FetchRenamedTypes();

            class <>c__DisplayClass25_0
            {
                /*0x10*/ Unity.VisualScripting.TypeName typeName;
                /*0x18*/ System.Func<System.Reflection.Assembly, bool> <>9__0;

                /*0x32f970*/ <>c__DisplayClass25_0();
                /*0x1573960*/ bool <TrySystemTypeLookup>b__0(System.Reflection.Assembly a);
            }

            class <GetAssemblyAttributes>d__15 : System.Collections.Generic.IEnumerable<System.Attribute>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Attribute>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Attribute <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Type attributeType;
                /*0x30*/ System.Type <>3__attributeType;
                /*0x38*/ System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assemblies;
                /*0x40*/ System.Collections.Generic.IEnumerable<System.Reflection.Assembly> <>3__assemblies;
                /*0x48*/ System.Collections.Generic.IEnumerator<System.Reflection.Assembly> <>7__wrap1;
                /*0x50*/ System.Collections.Generic.IEnumerator<System.Attribute> <>7__wrap2;

                /*0x70aad0*/ <GetAssemblyAttributes>d__15(int <>1__state);
                /*0x156ff20*/ void System.IDisposable.Dispose();
                /*0x156f9d0*/ bool MoveNext();
                /*0x1570070*/ void <>m__Finally1();
                /*0x15700c0*/ void <>m__Finally2();
                /*0x32f410*/ System.Attribute System.Collections.Generic.IEnumerator<System.Attribute>.get_Current();
                /*0x156fee0*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
                /*0x156fe30*/ System.Collections.Generic.IEnumerator<System.Attribute> System.Collections.Generic.IEnumerable<System.Attribute>.GetEnumerator();
                /*0x156fe30*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class TypeFilter : System.Attribute, System.ICloneable
        {
            /*0x10*/ System.Collections.Generic.HashSet<System.Type> types;
            /*0x18*/ Unity.VisualScripting.TypesMatching <Matching>k__BackingField;
            /*0x1c*/ bool <Value>k__BackingField;
            /*0x1d*/ bool <Reference>k__BackingField;
            /*0x1e*/ bool <Classes>k__BackingField;
            /*0x1f*/ bool <Interfaces>k__BackingField;
            /*0x20*/ bool <Structs>k__BackingField;
            /*0x21*/ bool <Enums>k__BackingField;
            /*0x22*/ bool <Public>k__BackingField;
            /*0x23*/ bool <NonPublic>k__BackingField;
            /*0x24*/ bool <Abstract>k__BackingField;
            /*0x25*/ bool <Generic>k__BackingField;
            /*0x26*/ bool <OpenConstructedGeneric>k__BackingField;
            /*0x27*/ bool <Static>k__BackingField;
            /*0x28*/ bool <Sealed>k__BackingField;
            /*0x29*/ bool <Nested>k__BackingField;
            /*0x2a*/ bool <Primitives>k__BackingField;
            /*0x2b*/ bool <Object>k__BackingField;
            /*0x2c*/ bool <NonSerializable>k__BackingField;
            /*0x2d*/ bool <Obsolete>k__BackingField;

            static /*0x1569900*/ Unity.VisualScripting.TypeFilter get_Any();
            /*0x15697d0*/ TypeFilter(Unity.VisualScripting.TypesMatching matching, System.Collections.Generic.IEnumerable<System.Type> types);
            /*0x15698f0*/ TypeFilter(Unity.VisualScripting.TypesMatching matching, System.Type[] types);
            /*0x15697c0*/ TypeFilter(System.Collections.Generic.IEnumerable<System.Type> types);
            /*0x15697c0*/ TypeFilter(System.Type[] types);
            /*0x8a5c20*/ Unity.VisualScripting.TypesMatching get_Matching();
            /*0x8a5c50*/ void set_Matching(Unity.VisualScripting.TypesMatching value);
            /*0x73d3e0*/ System.Collections.Generic.HashSet<System.Type> get_Types();
            /*0x14efb00*/ bool get_Value();
            /*0x14efc30*/ void set_Value(bool value);
            /*0x14efad0*/ bool get_Reference();
            /*0x14efbf0*/ void set_Reference(bool value);
            /*0x14efae0*/ bool get_Classes();
            /*0x14efc10*/ void set_Classes(bool value);
            /*0x14efac0*/ bool get_Interfaces();
            /*0x14efbe0*/ void set_Interfaces(bool value);
            /*0x796120*/ bool get_Structs();
            /*0x7963b0*/ void set_Structs(bool value);
            /*0xff2e20*/ bool get_Enums();
            /*0xff32d0*/ void set_Enums(bool value);
            /*0x12a0b50*/ bool get_Public();
            /*0x12a0b60*/ void set_Public(bool value);
            /*0x12a0b70*/ bool get_NonPublic();
            /*0x12a0b80*/ void set_NonPublic(bool value);
            /*0xed9100*/ bool get_Abstract();
            /*0x117be00*/ void set_Abstract(bool value);
            /*0x14efab0*/ bool get_Generic();
            /*0x14efbc0*/ void set_Generic(bool value);
            /*0x1569ac0*/ bool get_OpenConstructedGeneric();
            /*0x1569b20*/ void set_OpenConstructedGeneric(bool value);
            /*0x1569ae0*/ bool get_Static();
            /*0x1569b40*/ void set_Static(bool value);
            /*0x4ba480*/ bool get_Sealed();
            /*0xd18990*/ void set_Sealed(bool value);
            /*0x12a2930*/ bool get_Nested();
            /*0x12a21f0*/ void set_Nested(bool value);
            /*0x1569ad0*/ bool get_Primitives();
            /*0x1569b30*/ void set_Primitives(bool value);
            /*0x1569aa0*/ bool get_Object();
            /*0x1569b00*/ void set_Object(bool value);
            /*0x1569a90*/ bool get_NonSerializable();
            /*0x1569af0*/ void set_NonSerializable(bool value);
            /*0x1569ab0*/ bool get_Obsolete();
            /*0x1569b10*/ void set_Obsolete(bool value);
            /*0x15699d0*/ bool get_ExpectsBoolean();
            /*0x1568470*/ object System.ICloneable.Clone();
            /*0x1568470*/ Unity.VisualScripting.TypeFilter Clone();
            /*0x1568590*/ bool Equals(object obj);
            /*0x1568700*/ int GetHashCode();
            /*0x1569110*/ bool ValidateType(System.Type type);
            /*0x1568b10*/ string ToString();
        }

        class TypeName
        {
            /*0x10*/ string <AssemblyDescription>k__BackingField;
            /*0x18*/ string <AssemblyName>k__BackingField;
            /*0x20*/ string <AssemblyVersion>k__BackingField;
            /*0x28*/ string <AssemblyCulture>k__BackingField;
            /*0x30*/ string <AssemblyPublicKeyToken>k__BackingField;
            /*0x38*/ System.Collections.Generic.List<Unity.VisualScripting.TypeName> <GenericParameters>k__BackingField;
            /*0x40*/ System.Collections.Generic.List<string> names;
            /*0x48*/ System.Collections.Generic.List<int> genericarities;
            /*0x50*/ string <Name>k__BackingField;

            static /*0x1569c40*/ Unity.VisualScripting.TypeName Parse(string s);
            static /*0x1569b50*/ string LookForPairThenRemove(System.Collections.Generic.List<string> strings, string Name);
            static /*0x156a710*/ string ToElementTypeName(string s);
            static /*0x156a6a0*/ string ToArrayOrType(string oldType, string newType);
            static /*0x156a620*/ string Simplify(string typeName);
            static /*0x156a570*/ string SimplifyFast(string typeName);
            /*0x156ac50*/ TypeName(string s, ref int index);
            /*0x73d3e0*/ string get_AssemblyDescription();
            /*0x9f12f0*/ void set_AssemblyDescription(string value);
            /*0x32f410*/ string get_AssemblyName();
            /*0x7963c0*/ void set_AssemblyName(string value);
            /*0x61a260*/ string get_AssemblyVersion();
            /*0x7965a0*/ void set_AssemblyVersion(string value);
            /*0x79a150*/ string get_AssemblyCulture();
            /*0x98b030*/ void set_AssemblyCulture(string value);
            /*0x997630*/ string get_AssemblyPublicKeyToken();
            /*0x997640*/ void set_AssemblyPublicKeyToken(string value);
            /*0x995140*/ System.Collections.Generic.List<Unity.VisualScripting.TypeName> get_GenericParameters();
            /*0x4e40e0*/ string get_Name();
            /*0x4e4370*/ void set_Name(string value);
            /*0x156b660*/ bool get_IsArray();
            /*0x156b6b0*/ string get_LastName();
            /*0x156a200*/ void ReplaceNamespace(string oldNamespace, string newNamespace);
            /*0x1569cb0*/ void ReplaceAssembly(string oldAssembly, string newAssembly);
            /*0x156a150*/ void ReplaceName(string oldTypeName, System.Type newType);
            /*0x1569e50*/ void ReplaceName(string oldTypeName, string newTypeName, System.Reflection.AssemblyName newAssemblyName);
            /*0x156a450*/ void SetAssemblyName(System.Reflection.AssemblyName newAssemblyName);
            /*0x156aad0*/ void UpdateName();
            /*0x156a7b0*/ string ToString(Unity.VisualScripting.TypeNameDetail specification, Unity.VisualScripting.TypeNameDetail genericsSpecification);
            /*0x156aac0*/ string ToString();
            /*0x156a7a0*/ string ToLooseString();

            enum ParseState
            {
                Name = 0,
                Array = 1,
                Generics = 2,
                Assembly = 3,
            }

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.TypeName.<> <>9;
                static /*0x8*/ System.Func<string, string> <>9__35_0;

                static /*0x1573aa0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1573940*/ string <.ctor>b__35_0(string x);
            }
        }

        enum TypeNameDetail
        {
            Name = 0,
            NameAndAssembly = 1,
            Full = 2,
        }

        enum TypeQualifier
        {
            Name = 0,
            Namespace = 1,
            GlobalNamespace = 2,
        }

        enum TypesMatching
        {
            ConvertibleToAny = 0,
            AssignableToAll = 1,
            Any = 2,
        }

        class TypeUtility
        {
            static /*0x0*/ System.Collections.Generic.HashSet<System.Type> _numericTypes;
            static /*0x8*/ System.Collections.Generic.HashSet<System.Type> _numericConstructTypes;
            static /*0x10*/ System.Collections.Generic.HashSet<System.Type> typesWithShortStrings;
            static /*0x18*/ System.Collections.Generic.Dictionary<System.Type, object> defaultPrimitives;

            static /*0x156f030*/ TypeUtility();
            static /*0x156d6c0*/ bool IsBasic(System.Type type);
            static /*0x156dab0*/ bool IsNumeric(System.Type type);
            static /*0x156d9d0*/ bool IsNumericConstruct(System.Type type);
            static /*0x156e560*/ Unity.VisualScripting.Namespace Namespace(System.Type type);
            static /*0x156d440*/ System.Func<object> Instantiator(System.Type type, bool nonPublic);
            static /*0x156d200*/ System.Func<System.Object[], object> Instantiator(System.Type type, bool nonPublic, System.Type[] parameterTypes);
            static /*0x156ee20*/ object TryInstantiate(System.Type type, bool nonPublic, object[] args);
            static /*0x156cf60*/ object Instantiate(System.Type type, bool nonPublic, object[] args);
            static /*0x156c170*/ object Default(System.Type type);
            static /*0x156e5d0*/ object PseudoDefault(System.Type type);
            static /*0x156dbb0*/ bool IsStatic(System.Type type);
            static /*0x156d570*/ bool IsAbstract(System.Type type);
            static /*0x156d8d0*/ bool IsConcrete(System.Type type);
            static /*0x156ca10*/ System.Collections.Generic.IEnumerable<System.Type> GetInterfaces(System.Type type, bool includeInherited);
            static /*0x156b930*/ System.Collections.Generic.IEnumerable<System.Type> BaseTypeAndInterfaces(System.Type type, bool inheritedInterfaces);
            static /*0x156cee0*/ System.Collections.Generic.IEnumerable<System.Type> Hierarchy(System.Type type);
            static /*0x156b710*/ System.Collections.Generic.IEnumerable<System.Type> AndBaseTypeAndInterfaces(System.Type type);
            static /*0x156b8a0*/ System.Collections.Generic.IEnumerable<System.Type> AndInterfaces(System.Type type);
            static /*0x156b7b0*/ System.Collections.Generic.IEnumerable<System.Type> AndHierarchy(System.Type type);
            static /*0x156cb30*/ System.Type GetListElementType(System.Type listType, bool allowNonGeneric);
            static /*0x156c6c0*/ System.Type GetEnumerableElementType(System.Type enumerableType, bool allowNonGeneric);
            static /*0x156c2b0*/ System.Type GetDictionaryItemType(System.Type dictionaryType, bool allowNonGeneric, int genericArgumentIndex);
            static /*0x156c600*/ System.Type GetDictionaryKeyType(System.Type dictionaryType, bool allowNonGeneric);
            static /*0x156c660*/ System.Type GetDictionaryValueType(System.Type dictionaryType, bool allowNonGeneric);
            static /*0x156d930*/ bool IsNullable(System.Type type);
            static /*0x156db90*/ bool IsReferenceType(System.Type type);
            static /*0x156dbf0*/ bool IsStruct(System.Type type);
            static /*0x156d5b0*/ bool IsAssignableFrom(System.Type type, object value);
            static /*0x156bad0*/ bool CanMakeGenericTypeVia(System.Type openConstructedType, System.Type closedConstructedType);
            static /*0x156dc50*/ System.Type MakeGenericTypeVia(System.Type openConstructedType, System.Type closedConstructedType, System.Collections.Generic.Dictionary<System.Type, System.Type> resolvedGenericParameters, bool safe);
            static /*0x156e990*/ string ToShortString(object o, int maxLength);
            static /*0x156ce60*/ System.Collections.Generic.IEnumerable<System.Type> GetTypesSafely(System.Reflection.Assembly assembly);

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.TypeUtility.<> <>9;
                static /*0x8*/ System.Func<object, System.Type> <>9__9_0;
                static /*0x10*/ System.Func<object, System.Type> <>9__10_0;
                static /*0x18*/ System.Func<System.Type, bool> <>9__23_0;
                static /*0x20*/ System.Func<System.Type, bool> <>9__24_0;
                static /*0x28*/ System.Func<System.Type, bool> <>9__25_0;
                static /*0x30*/ System.Func<System.Type, bool> <>9__35_0;
                static /*0x38*/ System.Func<System.Type, bool> <>9__35_1;

                static /*0x1573b80*/ <>c();
                /*0x32f970*/ <>c();
                /*0xe93ff0*/ System.Type <TryInstantiate>b__9_0(object arg);
                /*0xe93ff0*/ System.Type <Instantiate>b__10_0(object arg);
                /*0x1570cd0*/ bool <GetListElementType>b__23_0(System.Type i);
                /*0x1570c10*/ bool <GetEnumerableElementType>b__24_0(System.Type i);
                /*0x1570b50*/ bool <GetDictionaryItemType>b__25_0(System.Type i);
                /*0x1570d90*/ bool <GetTypesSafely>b__35_0(System.Type t);
                /*0x1570de0*/ bool <GetTypesSafely>b__35_1(System.Type t);
            }

            class <>c__DisplayClass7_0
            {
                /*0x10*/ System.Func<System.Object[], object> instantiator;

                /*0x32f970*/ <>c__DisplayClass7_0();
                /*0x15739b0*/ object <Instantiator>b__0();
            }

            class <>c__DisplayClass8_0
            {
                /*0x10*/ System.Type type;
                /*0x18*/ System.Reflection.ConstructorInfo constructor;

                /*0x32f970*/ <>c__DisplayClass8_0();
                /*0x1573a30*/ object <Instantiator>b__0(object[] args);
                /*0x1573a80*/ object <Instantiator>b__1(object[] args);
            }

            class <GetTypesSafely>d__35 : System.Collections.Generic.IEnumerable<System.Type>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Type>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Type <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Reflection.Assembly assembly;
                /*0x30*/ System.Reflection.Assembly <>3__assembly;
                /*0x38*/ System.Type[] <>7__wrap1;
                /*0x40*/ int <>7__wrap2;

                /*0x70aad0*/ <GetTypesSafely>d__35(int <>1__state);
                /*0x32d010*/ void System.IDisposable.Dispose();
                /*0x1570110*/ bool MoveNext();
                /*0x32f410*/ System.Type System.Collections.Generic.IEnumerator<System.Type>.get_Current();
                /*0x1570630*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
                /*0x1570590*/ System.Collections.Generic.IEnumerator<System.Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator();
                /*0x1570590*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <Hierarchy>d__19 : System.Collections.Generic.IEnumerable<System.Type>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Type>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ System.Type <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ System.Type type;
                /*0x30*/ System.Type <>3__type;
                /*0x38*/ System.Type <baseType>5__2;
                /*0x40*/ System.Collections.Generic.IEnumerator<System.Type> <>7__wrap2;

                /*0x70aad0*/ <Hierarchy>d__19(int <>1__state);
                /*0x1570a70*/ void System.IDisposable.Dispose();
                /*0x1570670*/ bool MoveNext();
                /*0x1570b00*/ void <>m__Finally1();
                /*0x32f410*/ System.Type System.Collections.Generic.IEnumerator<System.Type>.get_Current();
                /*0x1570a30*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
                /*0x1570990*/ System.Collections.Generic.IEnumerator<System.Type> System.Collections.Generic.IEnumerable<System.Type>.GetEnumerator();
                /*0x1570990*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class LooseAssemblyNameConverter : Unity.VisualScripting.FullSerializer.fsDirectConverter
        {
            /*0x534220*/ LooseAssemblyNameConverter();
            /*0x15536e0*/ System.Type get_ModelType();
            /*0x1553440*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            /*0x15535e0*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
            /*0x1553490*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance, System.Type storageType);
        }

        class NamespaceConverter : Unity.VisualScripting.FullSerializer.fsDirectConverter
        {
            /*0x534220*/ NamespaceConverter();
            /*0x1554360*/ System.Type get_ModelType();
            /*0x15540c0*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            /*0x1554250*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
            /*0x1554110*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance, System.Type storageType);
        }

        class Ray2DConverter : Unity.VisualScripting.FullSerializer.fsDirectConverter<UnityEngine.Ray2D>
        {
            /*0x155a620*/ Ray2DConverter();
            /*0x155a490*/ Unity.VisualScripting.FullSerializer.fsResult DoSerialize(UnityEngine.Ray2D model, System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> serialized);
            /*0x155a210*/ Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> data, ref UnityEngine.Ray2D model);
            /*0x155a1d0*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
        }

        class RayConverter : Unity.VisualScripting.FullSerializer.fsDirectConverter<UnityEngine.Ray>
        {
            /*0x155ab00*/ RayConverter();
            /*0x155a960*/ Unity.VisualScripting.FullSerializer.fsResult DoSerialize(UnityEngine.Ray model, System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> serialized);
            /*0x155a6c0*/ Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> data, ref UnityEngine.Ray model);
            /*0x155a660*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
        }

        class UnityObjectConverter : Unity.VisualScripting.FullSerializer.fsConverter
        {
            /*0x534220*/ UnityObjectConverter();
            /*0x1574850*/ System.Collections.Generic.List<UnityEngine.Object> get_objectReferences();
            /*0x15742b0*/ bool CanProcess(System.Type type);
            /*0x348b00*/ bool RequestCycleSupport(System.Type storageType);
            /*0x348b00*/ bool RequestInheritanceSupport(System.Type storageType);
            /*0x1574620*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
            /*0x1574340*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData storage, ref object instance, System.Type storageType);
            /*0x1128190*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
        }

        class DictionaryAsset : Unity.VisualScripting.LudiqScriptableObject, System.Collections.Generic.IDictionary<string, object>, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable
        {
            /*0x30*/ System.Collections.Generic.Dictionary<string, object> <dictionary>k__BackingField;

            /*0x1552af0*/ DictionaryAsset();
            /*0x1552bc0*/ object get_Item(string key);
            /*0x1552cc0*/ void set_Item(string key, object value);
            /*0x997630*/ System.Collections.Generic.Dictionary<string, object> get_dictionary();
            /*0x997640*/ void set_dictionary(System.Collections.Generic.Dictionary<string, object> value);
            /*0x1552b70*/ int get_Count();
            /*0x1552c20*/ System.Collections.Generic.ICollection<string> get_Keys();
            /*0x1552c70*/ System.Collections.Generic.ICollection<object> get_Values();
            /*0x15529e0*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_IsReadOnly();
            /*0x1552510*/ void OnAfterDeserialize();
            /*0x1552100*/ void Clear();
            /*0x1552150*/ bool ContainsKey(string key);
            /*0x1552090*/ void Add(string key, object value);
            /*0x1552240*/ void Merge(Unity.VisualScripting.DictionaryAsset other, bool overwriteExisting);
            /*0x1552590*/ bool Remove(string key);
            /*0x1552a80*/ bool TryGetValue(string key, ref object value);
            /*0x15521b0*/ System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator();
            /*0x1552a30*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x15526a0*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(System.Collections.Generic.KeyValuePair<string, object> item);
            /*0x1552770*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(System.Collections.Generic.KeyValuePair<string, object> item);
            /*0x1552840*/ void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(System.Collections.Generic.KeyValuePair<string, object> array, int arrayIndex);
            /*0x1552910*/ bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(System.Collections.Generic.KeyValuePair<string, object> item);
            /*0x15525f0*/ void ShowData();
        }

        class DoNotSerializeAttribute : System.Attribute
        {
            /*0x534220*/ DoNotSerializeAttribute();
        }

        interface ISerializationDependency : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x181190*/ void set_IsDeserialized(bool value);
            /*0x17cb40*/ bool get_IsDeserialized();
        }

        interface ISerializationDepender : UnityEngine.ISerializationCallbackReceiver
        {
            /*0x1803b0*/ System.Collections.Generic.IEnumerable<Unity.VisualScripting.ISerializationDependency> get_deserializationDependencies();
            /*0x180fc0*/ void OnAfterDependenciesDeserialized();
        }

        struct SerializableType : System.IEquatable<Unity.VisualScripting.SerializableType>, System.IComparable<Unity.VisualScripting.SerializableType>
        {
            /*0x10*/ string Identification;

            static /*0x155ecd0*/ bool op_Equality(Unity.VisualScripting.SerializableType left, Unity.VisualScripting.SerializableType right);
            static /*0x155ece0*/ bool op_Inequality(Unity.VisualScripting.SerializableType left, Unity.VisualScripting.SerializableType right);
            /*0x792990*/ SerializableType(string identification);
            /*0x155eca0*/ bool Equals(Unity.VisualScripting.SerializableType other);
            /*0x155ec10*/ bool Equals(object obj);
            /*0x155ecb0*/ int GetHashCode();
            /*0x155ebf0*/ int CompareTo(Unity.VisualScripting.SerializableType other);
        }

        class Unknown
        {
            static string Identification = "__UNKNOWN";

            /*0x32f970*/ Unknown();
        }

        class Serialization
        {
            static string ConstructorWarning = "This parameterless constructor is only made public for serialization. Use another constructor instead.";
            static /*0x0*/ System.Collections.Generic.HashSet<Unity.VisualScripting.SerializationOperation> freeOperations;
            static /*0x8*/ System.Collections.Generic.HashSet<Unity.VisualScripting.SerializationOperation> busyOperations;
            static /*0x10*/ object lock;
            static /*0x18*/ bool <isUnitySerializing>k__BackingField;
            static /*0x20*/ System.Collections.Generic.HashSet<Unity.VisualScripting.ISerializationDepender> awaitingDependers;

            static /*0x1561910*/ Serialization();
            static /*0x1561bc0*/ bool get_isUnitySerializing();
            static /*0x1561c10*/ void set_isUnitySerializing(bool value);
            static /*0x1561aa0*/ bool get_isCustomSerializing();
            static /*0x1561b10*/ bool get_isSerializing();
            static /*0x15616d0*/ Unity.VisualScripting.SerializationOperation StartOperation();
            static /*0x1560320*/ void EndOperation(Unity.VisualScripting.SerializationOperation operation);
            static /*0x2a5510*/ T CloneViaSerialization<T>(T value, bool forceReflected);
            static /*0x2a5510*/ void CloneViaSerializationInto<TSource, TDestination>(TSource value, ref TDestination instance, bool forceReflected);
            static /*0x15613d0*/ Unity.VisualScripting.SerializationData Serialize(object value, bool forceReflected);
            static /*0x155fb80*/ void DeserializeInto(Unity.VisualScripting.SerializationData data, ref object instance, bool forceReflected);
            static /*0x15602a0*/ object Deserialize(Unity.VisualScripting.SerializationData data, bool forceReflected);
            static /*0x1561160*/ string SerializeJson(Unity.VisualScripting.FullSerializer.fsSerializer serializer, object instance, bool forceReflected);
            static /*0x155ff10*/ Unity.VisualScripting.FullSerializer.fsResult DeserializeJsonUtil(Unity.VisualScripting.FullSerializer.fsSerializer serializer, string json, ref object instance, bool forceReflected);
            static /*0x1560040*/ void DeserializeJson(Unity.VisualScripting.FullSerializer.fsSerializer serializer, string json, ref object instance, bool forceReflected);
            static /*0x1560570*/ void HandleResult(string label, Unity.VisualScripting.FullSerializer.fsResult result, UnityEngine.Object context);
            static /*0x1561140*/ string PrettyPrint(string json);
            static /*0x155f8c0*/ void AwaitDependencies(Unity.VisualScripting.ISerializationDepender depender);
            static /*0x1561070*/ void NotifyDependencyDeserializing(Unity.VisualScripting.ISerializationDependency dependency);
            static /*0x1560ee0*/ void NotifyDependencyDeserialized(Unity.VisualScripting.ISerializationDependency dependency);
            static /*0x15610f0*/ void NotifyDependencyUnavailable(Unity.VisualScripting.ISerializationDependency dependency);
            static /*0x1560d80*/ void NotifyDependencyAvailable(Unity.VisualScripting.ISerializationDependency dependency);
            static /*0x155f950*/ void CheckIfDependenciesMet(Unity.VisualScripting.ISerializationDepender depender);
            static /*0x15608c0*/ void LogStuckDependers();
        }

        struct SerializationData
        {
            /*0x10*/ string _json;
            /*0x18*/ UnityEngine.Object[] _objectReferences;

            /*0x155f530*/ SerializationData(string json, System.Collections.Generic.IEnumerable<UnityEngine.Object> objectReferences);
            /*0x155f520*/ SerializationData(string json, UnityEngine.Object[] objectReferences);
            /*0x6937d0*/ string get_json();
            /*0xa5a7f0*/ UnityEngine.Object[] get_objectReferences();
            /*0x155ed00*/ void Clear();
            /*0x155ee10*/ string ToString(string title);
            /*0x155f510*/ string ToString();
            /*0x155ed30*/ void ShowString(string title);
        }

        class SerializationOperation
        {
            /*0x10*/ Unity.VisualScripting.FullSerializer.fsSerializer <serializer>k__BackingField;
            /*0x18*/ System.Collections.Generic.List<UnityEngine.Object> <objectReferences>k__BackingField;

            /*0x155f640*/ SerializationOperation();
            /*0x73d3e0*/ Unity.VisualScripting.FullSerializer.fsSerializer get_serializer();
            /*0x9f12f0*/ void set_serializer(Unity.VisualScripting.FullSerializer.fsSerializer value);
            /*0x32f410*/ System.Collections.Generic.List<UnityEngine.Object> get_objectReferences();
            /*0x7963c0*/ void set_objectReferences(System.Collections.Generic.List<UnityEngine.Object> value);
            /*0x155f5e0*/ void Reset();
        }

        class SerializationVersionAttribute : Unity.VisualScripting.FullSerializer.fsObjectAttribute
        {
            /*0x155f8b0*/ SerializationVersionAttribute(string versionString, System.Type[] previousModels);
        }

        class SerializeAsAttribute : Unity.VisualScripting.FullSerializer.fsPropertyAttribute
        {
            /*0x1561c70*/ SerializeAsAttribute(string name);
        }

        class SerializeAttribute : System.Attribute
        {
            /*0x534220*/ SerializeAttribute();
        }

        interface ISerializedPropertyProvider
        {
            /*0x1803b0*/ object get_item();
            /*0x17aec0*/ void set_item(object value);
        }

        class SerializedPropertyProvider<T> : UnityEngine.ScriptableObject, Unity.VisualScripting.ISerializedPropertyProvider
        {
            /*0x0*/ T item;

            /*0x180fc0*/ SerializedPropertyProvider();
            /*0x1803b0*/ object Unity.VisualScripting.ISerializedPropertyProvider.get_item();
            /*0x17aec0*/ void Unity.VisualScripting.ISerializedPropertyProvider.set_item(object value);
        }

        class SerializedPropertyProviderAttribute : System.Attribute, Unity.VisualScripting.IDecoratorAttribute
        {
            /*0x10*/ System.Type <type>k__BackingField;

            /*0xa32e30*/ SerializedPropertyProviderAttribute(System.Type type);
            /*0x73d3e0*/ System.Type get_type();
            /*0x9f12f0*/ void set_type(System.Type value);
        }

        class StickyNote : Unity.VisualScripting.GraphElement<Unity.VisualScripting.IGraph>
        {
            static /*0x0*/ UnityEngine.Color defaultColor;
            /*0x28*/ UnityEngine.Rect <position>k__BackingField;
            /*0x38*/ string <title>k__BackingField;
            /*0x40*/ string <body>k__BackingField;
            /*0x48*/ Unity.VisualScripting.StickyNote.ColorEnum <colorTheme>k__BackingField;

            static /*0x15625f0*/ StickyNote();
            static /*0x1562490*/ UnityEngine.Color GetStickyColor(Unity.VisualScripting.StickyNote.ColorEnum enumValue);
            static /*0x1562460*/ UnityEngine.Color GetFontColor(Unity.VisualScripting.StickyNote.ColorEnum enumValue);
            /*0x1562630*/ StickyNote();
            /*0xa75be0*/ UnityEngine.Rect get_position();
            /*0xf2b440*/ void set_position(UnityEngine.Rect value);
            /*0x995140*/ string get_title();
            /*0xe5a080*/ void set_title(string value);
            /*0xb61870*/ string get_body();
            /*0xcf6cd0*/ void set_body(string value);
            /*0x12f47d0*/ Unity.VisualScripting.StickyNote.ColorEnum get_colorTheme();
            /*0x136a110*/ void set_colorTheme(Unity.VisualScripting.StickyNote.ColorEnum value);

            enum ColorEnum
            {
                Classic = 0,
                Black = 1,
                Dark = 2,
                Orange = 3,
                Green = 4,
                Blue = 5,
                Red = 6,
                Purple = 7,
                Teal = 8,
            }
        }

        interface IGizmoDrawer
        {
            /*0x180fc0*/ void OnDrawGizmos();
            /*0x180fc0*/ void OnDrawGizmosSelected();
        }

        interface ISingleton
        {
        }

        interface IUnityObjectOwnable
        {
            /*0x1803b0*/ UnityEngine.Object get_owner();
            /*0x17aec0*/ void set_owner(UnityEngine.Object value);
        }

        class LudiqBehaviour : UnityEngine.MonoBehaviour, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x20*/ Unity.VisualScripting.SerializationData _data;

            /*0x31c640*/ LudiqBehaviour();
            /*0x15539f0*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x1553800*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x32d010*/ void OnBeforeSerialize();
            /*0x32d010*/ void OnAfterSerialize();
            /*0x32d010*/ void OnBeforeDeserialize();
            /*0x32d010*/ void OnAfterDeserialize();
            /*0x1553740*/ void ShowData();
            /*0x15537f0*/ string ToString();
        }

        class LudiqScriptableObject : UnityEngine.ScriptableObject, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x18*/ Unity.VisualScripting.SerializationData _data;
            /*0x28*/ System.Action OnDestroyActions;

            /*0x533ec0*/ LudiqScriptableObject();
            /*0x1553f80*/ void add_OnDestroyActions(System.Action value);
            /*0x1554020*/ void remove_OnDestroyActions(System.Action value);
            /*0x1553dc0*/ void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize();
            /*0x1553bd0*/ void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize();
            /*0x32d010*/ void OnBeforeSerialize();
            /*0x32d010*/ void OnAfterSerialize();
            /*0x32d010*/ void OnBeforeDeserialize();
            /*0x32d010*/ void OnAfterDeserialize();
            /*0x32d010*/ void OnPostDeserializeInEditor();
            /*0x1553bb0*/ void OnDestroy();
            /*0x15525f0*/ void ShowData();
            /*0x15537f0*/ string ToString();
        }

        class MacroScriptableObject : Unity.VisualScripting.LudiqScriptableObject
        {
            /*0x533ec0*/ MacroScriptableObject();
        }

        class RequiresUnityAPIAttribute : System.Attribute
        {
            /*0x534220*/ RequiresUnityAPIAttribute();
        }

        class SceneSingleton<T>
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<UnityEngine.SceneManagement.Scene, T> instances;
            static /*0x0*/ Unity.VisualScripting.SingletonAttribute attribute;

            static /*0x180ff0*/ SceneSingleton();
            static /*0x17cb70*/ bool get_persistent();
            static /*0x17cb70*/ bool get_automatic();
            static /*0x180cf0*/ string get_name();
            static /*0x1809b0*/ UnityEngine.HideFlags get_hideFlags();
            static /*0x1784c0*/ void EnsureSceneValid(UnityEngine.SceneManagement.Scene scene);
            static /*0x2a5510*/ bool InstantiatedIn(UnityEngine.SceneManagement.Scene scene);
            static /*0x2a5510*/ T InstanceIn(UnityEngine.SceneManagement.Scene scene);
            static /*0x180cf0*/ T[] FindObjectsOfType();
            static /*0x2a5510*/ T[] FindInstances(UnityEngine.SceneManagement.Scene scene);
            static /*0x2a5510*/ T FindOrCreateInstance(UnityEngine.SceneManagement.Scene scene);
            static /*0x2a5510*/ void Awake(T instance);
            static /*0x2a5510*/ void OnDestroy(T instance);

            class <>c__DisplayClass15_0<T>
            {
                /*0x0*/ UnityEngine.SceneManagement.Scene scene;

                /*0x180fc0*/ <>c__DisplayClass15_0();
                /*0x2a5510*/ bool <FindInstances>b__0(T o);
            }
        }

        class Singleton<T>
        {
            static /*0x0*/ Unity.VisualScripting.SingletonAttribute attribute;
            static /*0x0*/ object _lock;
            static /*0x0*/ System.Collections.Generic.HashSet<T> awoken;
            static /*0x0*/ T _instance;

            static /*0x180ff0*/ Singleton();
            static /*0x17cb70*/ bool get_persistent();
            static /*0x17cb70*/ bool get_automatic();
            static /*0x180cf0*/ string get_name();
            static /*0x1809b0*/ UnityEngine.HideFlags get_hideFlags();
            static /*0x17cb70*/ bool get_instantiated();
            static /*0x2a5510*/ T get_instance();
            static /*0x180cf0*/ T[] FindObjectsOfType();
            static /*0x180cf0*/ T[] FindInstances();
            static /*0x2a5510*/ T Instantiate();
            static /*0x2a5510*/ void Awake(T instance);
            static /*0x2a5510*/ void OnDestroy(T instance);
        }

        class SingletonAttribute : System.Attribute
        {
            /*0x10*/ bool <Persistent>k__BackingField;
            /*0x11*/ bool <Automatic>k__BackingField;
            /*0x14*/ UnityEngine.HideFlags <HideFlags>k__BackingField;
            /*0x18*/ string <Name>k__BackingField;

            /*0x1561c80*/ SingletonAttribute();
            /*0x793eb0*/ bool get_Persistent();
            /*0x793ec0*/ void set_Persistent(bool value);
            /*0xf26f80*/ bool get_Automatic();
            /*0xf26f90*/ void set_Automatic(bool value);
            /*0x70a440*/ UnityEngine.HideFlags get_HideFlags();
            /*0xc70b20*/ void set_HideFlags(UnityEngine.HideFlags value);
            /*0x32f410*/ string get_Name();
            /*0x7963c0*/ void set_Name(string value);
        }

        class UnityObjectOwnershipUtility
        {
            static /*0x15748a0*/ void CopyOwner(object source, object destination);
            static /*0x1574b20*/ void RemoveOwner(object o);
            static /*0x1574a00*/ UnityEngine.Object GetOwner(object o);
        }

        class UnityThread
        {
            static /*0x0*/ System.Threading.Thread thread;
            static /*0x8*/ System.Action<System.Action> editorAsync;
            static /*0x10*/ System.Collections.Concurrent.ConcurrentQueue<System.Action> pendingQueue;

            static /*0x1574cd0*/ UnityThread();
            static /*0x1574d90*/ bool get_allowsAPI();
            static /*0x1574c60*/ void RuntimeInitialize();
            static /*0x1574b80*/ void EditorAsync(System.Action action);
        }

        class ComponentHolderProtocol
        {
            static /*0x1551ea0*/ bool IsComponentHolderType(System.Type type);
            static /*0x1551ff0*/ bool IsComponentHolder(UnityEngine.Object uo);
            static /*0x1551640*/ UnityEngine.GameObject GameObject(UnityEngine.Object uo);
            static /*0x2a5510*/ T AddComponent<T>(UnityEngine.Object uo);
            static /*0x2a5510*/ T GetOrAddComponent<T>(UnityEngine.Object uo);
            static /*0x2a5510*/ T GetComponent<T>(UnityEngine.Object uo);
            static /*0x2a5510*/ T GetComponentInChildren<T>(UnityEngine.Object uo);
            static /*0x2a5510*/ T GetComponentInParent<T>(UnityEngine.Object uo);
            static /*0x17e030*/ T[] GetComponents<T>(UnityEngine.Object uo);
            static /*0x17e030*/ T[] GetComponentsInChildren<T>(UnityEngine.Object uo);
            static /*0x17e030*/ T[] GetComponentsInParent<T>(UnityEngine.Object uo);
            static /*0x15519a0*/ UnityEngine.Component GetComponent(UnityEngine.Object uo, System.Type type);
            static /*0x1551720*/ UnityEngine.Component GetComponentInChildren(UnityEngine.Object uo, System.Type type);
            static /*0x1551860*/ UnityEngine.Component GetComponentInParent(UnityEngine.Object uo, System.Type type);
            static /*0x1551d60*/ UnityEngine.Component[] GetComponents(UnityEngine.Object uo, System.Type type);
            static /*0x1551ae0*/ UnityEngine.Component[] GetComponentsInChildren(UnityEngine.Object uo, System.Type type);
            static /*0x1551c20*/ UnityEngine.Component[] GetComponentsInParent(UnityEngine.Object uo, System.Type type);
        }

        class CoroutineRunner : UnityEngine.MonoBehaviour, Unity.VisualScripting.ISingleton
        {
            static /*0x1578150*/ Unity.VisualScripting.CoroutineRunner get_instance();
            /*0x31c640*/ CoroutineRunner();
            /*0x1578080*/ void Awake();
            /*0x15780e0*/ void OnDestroy();
        }

        class CSharpNameUtility
        {
            static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, string> primitives;
            static /*0x8*/ System.Collections.Generic.Dictionary<string, string> operators;
            static /*0x10*/ System.Collections.Generic.HashSet<char> illegalTypeFileNameCharacters;

            static /*0x1577360*/ CSharpNameUtility();
            static /*0x1576f80*/ string CSharpName(System.Reflection.MemberInfo member, Unity.VisualScripting.ActionDirection direction);
            static /*0x1576940*/ string CSharpName(System.Type type, bool includeGenericParameters);
            static /*0x15768e0*/ string CSharpFullName(System.Type type, bool includeGenericParameters);
            static /*0x1577300*/ string CSharpUniqueName(System.Type type, bool includeGenericParameters);
            static /*0x15765b0*/ string CSharpFileName(System.Type type, bool includeNamespace, bool includeGenericParameters);
            static /*0x15769a0*/ string CSharpName(System.Type type, Unity.VisualScripting.TypeQualifier qualifier, bool includeGenericParameters);

            class <>c__DisplayClass8_0
            {
                /*0x10*/ Unity.VisualScripting.TypeQualifier qualifier;
                /*0x14*/ bool includeGenericParameters;

                /*0x32f970*/ <>c__DisplayClass8_0();
                /*0x15863b0*/ string <CSharpName>b__0(System.Type t);
            }
        }

        class Empty<T>
        {
            static /*0x0*/ T[] array;
            static /*0x0*/ System.Collections.Generic.List<T> list;
            static /*0x0*/ System.Collections.Generic.HashSet<T> hashSet;

            static /*0x180ff0*/ Empty();
        }

        class EnumUtility
        {
            static /*0x15781b0*/ bool HasFlag(System.Enum value, System.Enum flag);
            static /*0x1578220*/ System.Collections.Generic.Dictionary<string, System.Enum> ValuesByNames(System.Type enumType, bool obsolete);
            static /*0x17cea0*/ System.Collections.Generic.Dictionary<string, T> ValuesByNames<T>(bool obsolete);

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.EnumUtility.<> <>9;
                static /*0x8*/ System.Func<System.Reflection.FieldInfo, bool> <>9__1_0;
                static /*0x10*/ System.Func<System.Reflection.FieldInfo, string> <>9__1_1;
                static /*0x18*/ System.Func<System.Reflection.FieldInfo, System.Enum> <>9__1_2;

                static /*0x15866c0*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1586210*/ bool <ValuesByNames>b__1_0(System.Reflection.FieldInfo f);
                /*0x718ca0*/ string <ValuesByNames>b__1_1(System.Reflection.FieldInfo f);
                /*0x15862b0*/ System.Enum <ValuesByNames>b__1_2(System.Reflection.FieldInfo f);
            }

            class <>c__2<T>
            {
                static /*0x0*/ Unity.VisualScripting.EnumUtility.<>c__2<T> <>9;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, bool> <>9__2_0;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, string> <>9__2_1;
                static /*0x0*/ System.Func<System.Reflection.FieldInfo, T> <>9__2_2;

                static /*0x180ff0*/ <>c__2();
                /*0x180fc0*/ <>c__2();
                /*0x17e620*/ bool <ValuesByNames>b__2_0(System.Reflection.FieldInfo f);
                /*0x1858d0*/ string <ValuesByNames>b__2_1(System.Reflection.FieldInfo f);
                /*0x2a5510*/ T <ValuesByNames>b__2_2(System.Reflection.FieldInfo f);
            }
        }

        class ExceptionUtility
        {
            static /*0x1578570*/ System.Exception Relevant(System.Exception ex);
        }

        class HashUtility
        {
            static /*0x2a5510*/ int GetHashCode<T>(T a);
            static /*0x2a5510*/ int GetHashCode<T1, T2>(T1 a, T2 b);
            static /*0x2a5510*/ int GetHashCode<T1, T2, T3>(T1 a, T2 b, T3 c);
            static /*0x2a5510*/ int GetHashCode<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d);
            static /*0x2a5510*/ int GetHashCode<T1, T2, T3, T4, T5>(T1 a, T2 b, T3 c, T4 d, T5 e);
            static /*0x157e230*/ int GetHashCodeAlloc(object[] values);
        }

        interface IAnalyticsIdentifiable
        {
            /*0x1803b0*/ Unity.VisualScripting.AnalyticsIdentifier GetAnalyticsIdentifier();
        }

        class AnalyticsIdentifier
        {
            /*0x10*/ string Identifier;
            /*0x18*/ string Namespace;
            /*0x20*/ int Hashcode;

            /*0x32f970*/ AnalyticsIdentifier();
        }

        interface IGettable
        {
            /*0x1803b0*/ object GetValue();
        }

        class XGettable
        {
            static /*0x15889b0*/ object GetValue(Unity.VisualScripting.IGettable gettable, System.Type type);
            static /*0x2a5510*/ T GetValue<T>(Unity.VisualScripting.IGettable gettable);
        }

        interface IIdentifiable
        {
            /*0x180e40*/ System.Guid get_guid();
        }

        interface IInitializable
        {
            /*0x180fc0*/ void Initialize();
        }

        class LinqUtility
        {
            static /*0x17e030*/ System.Collections.Generic.IEnumerable<T> Concat<T>(System.Collections.IEnumerable[] enumerables);
            static /*0x177800*/ System.Collections.Generic.IEnumerable<T> DistinctBy<T, TKey>(System.Collections.Generic.IEnumerable<T> items, System.Func<T, TKey> property);
            static /*0x17e030*/ System.Collections.Generic.IEnumerable<T> NotNull<T>(System.Collections.Generic.IEnumerable<T> enumerable);
            static /*0x2a5510*/ System.Collections.Generic.IEnumerable<T> Yield<T>(T t);
            static /*0x17e030*/ System.Collections.Generic.HashSet<T> ToHashSet<T>(System.Collections.Generic.IEnumerable<T> enumerable);
            static /*0x177670*/ void AddRange<T>(System.Collections.Generic.ICollection<T> collection, System.Collections.Generic.IEnumerable<T> items);
            static /*0x157f5e0*/ void AddRange(System.Collections.IList list, System.Collections.IEnumerable items);
            static /*0x17e030*/ System.Collections.Generic.ICollection<T> AsReadOnlyCollection<T>(System.Collections.Generic.IEnumerable<T> enumerable);
            static /*0x17e030*/ System.Collections.Generic.IList<T> AsReadOnlyList<T>(System.Collections.Generic.IEnumerable<T> enumerable);
            static /*0x177800*/ System.Collections.Generic.IEnumerable<T> Flatten<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, System.Collections.Generic.IEnumerable<T>> childrenSelector);
            static /*0x17e030*/ System.Collections.Generic.IEnumerable<T> IntersectAll<T>(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<T>> groups);
            static /*0x177950*/ System.Collections.Generic.IEnumerable<T> OrderByDependencies<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, System.Collections.Generic.IEnumerable<T>> getDependencies, bool throwOnCycle);
            static /*0x2a5510*/ void OrderByDependenciesVisit<T>(T item, System.Collections.Generic.HashSet<T> visited, System.Collections.Generic.List<T> sorted, System.Func<T, System.Collections.Generic.IEnumerable<T>> getDependencies, bool throwOnCycle);
            static /*0x177950*/ System.Collections.Generic.IEnumerable<T> OrderByDependers<T>(System.Collections.Generic.IEnumerable<T> source, System.Func<T, System.Collections.Generic.IEnumerable<T>> getDependers, bool throwOnCycle);
            static /*0x177800*/ System.Collections.Generic.IEnumerable<T> Catch<T>(System.Collections.Generic.IEnumerable<T> source, System.Action<System.Exception> catch);
            static /*0x177800*/ System.Collections.Generic.IEnumerable<T> Catch<T>(System.Collections.Generic.IEnumerable<T> source, System.Collections.Generic.ICollection<System.Exception> exceptions);
            static /*0x177800*/ System.Collections.Generic.IEnumerable<T> CatchAsLogError<T>(System.Collections.Generic.IEnumerable<T> source, string message);
            static /*0x177800*/ System.Collections.Generic.IEnumerable<T> CatchAsLogWarning<T>(System.Collections.Generic.IEnumerable<T> source, string message);

            class <>c__1<T, TKey>
            {
                static /*0x0*/ Unity.VisualScripting.LinqUtility.<>c__1<T, TKey> <>9;
                static /*0x0*/ System.Func<System.Linq.IGrouping<TKey, T>, T> <>9__1_0;

                static /*0x180ff0*/ <>c__1();
                /*0x180fc0*/ <>c__1();
                /*0x2a5510*/ T <DistinctBy>b__1_0(System.Linq.IGrouping<TKey, T> x);
            }

            class <>c__2<T>
            {
                static /*0x0*/ Unity.VisualScripting.LinqUtility.<>c__2<T> <>9;
                static /*0x0*/ System.Func<T, bool> <>9__2_0;

                static /*0x180ff0*/ <>c__2();
                /*0x180fc0*/ <>c__2();
                /*0x2a5510*/ bool <NotNull>b__2_0(T i);
            }

            class <>c__DisplayClass13_0<T>
            {
                /*0x0*/ System.Collections.Generic.Dictionary<T, System.Collections.Generic.HashSet<T>> dependencies;

                /*0x180fc0*/ <>c__DisplayClass13_0();
                /*0x2a5510*/ System.Collections.Generic.IEnumerable<T> <OrderByDependers>b__0(T depender);
            }

            class <>c__DisplayClass16_0<T>
            {
                /*0x0*/ string message;

                /*0x180fc0*/ <>c__DisplayClass16_0();
                /*0x17aec0*/ void <CatchAsLogError>b__0(System.Exception ex);
            }

            class <>c__DisplayClass17_0<T>
            {
                /*0x0*/ string message;

                /*0x180fc0*/ <>c__DisplayClass17_0();
                /*0x17aec0*/ void <CatchAsLogWarning>b__0(System.Exception ex);
            }

            class <Catch>d__14<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> source;
                /*0x0*/ System.Collections.Generic.IEnumerable<T> <>3__source;
                /*0x0*/ System.Action<System.Exception> catch;
                /*0x0*/ System.Action<System.Exception> <>3__catch;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <enumerator>5__2;
                /*0x0*/ bool <success>5__3;

                /*0x17aa40*/ <Catch>d__14(int <>1__state);
                /*0x180fc0*/ void System.IDisposable.Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void <>m__Finally1();
                /*0x2a5510*/ T System.Collections.Generic.IEnumerator<T>.get_Current();
                /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <Concat>d__0<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ System.Collections.IEnumerable[] enumerables;
                /*0x0*/ System.Collections.IEnumerable[] <>3__enumerables;
                /*0x0*/ System.Collections.Generic.IEnumerator<System.Collections.IEnumerable> <>7__wrap1;
                /*0x0*/ System.Collections.Generic.IEnumerator<T> <>7__wrap2;

                /*0x17aa40*/ <Concat>d__0(int <>1__state);
                /*0x180fc0*/ void System.IDisposable.Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x180fc0*/ void <>m__Finally1();
                /*0x180fc0*/ void <>m__Finally2();
                /*0x2a5510*/ T System.Collections.Generic.IEnumerator<T>.get_Current();
                /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }

            class <Yield>d__3<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ T t;
                /*0x0*/ T <>3__t;

                /*0x17aa40*/ <Yield>d__3(int <>1__state);
                /*0x180fc0*/ void System.IDisposable.Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x2a5510*/ T System.Collections.Generic.IEnumerator<T>.get_Current();
                /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class OverrideStack<T>
        {
            /*0x0*/ System.Func<T> getValue;
            /*0x0*/ System.Action<T> setValue;
            /*0x0*/ System.Action clearValue;
            /*0x0*/ T _value;
            /*0x0*/ System.Collections.Generic.Stack<T> previous;

            static /*0x2a5510*/ T op_Implicit(Unity.VisualScripting.OverrideStack<T> stack);
            /*0x2a5510*/ OverrideStack(T defaultValue);
            /*0x183150*/ OverrideStack(System.Func<T> getValue, System.Action<T> setValue);
            /*0x183830*/ OverrideStack(System.Func<T> getValue, System.Action<T> setValue, System.Action clearValue);
            /*0x2a5510*/ T get_value();
            /*0x2a5510*/ void set_value(T value);
            /*0x2a5510*/ Unity.VisualScripting.OverrideLayer<T> Override(T item);
            /*0x2a5510*/ void BeginOverride(T item);
            /*0x180fc0*/ void EndOverride();
            /*0x2a5510*/ T <.ctor>b__0_0();
            /*0x2a5510*/ void <.ctor>b__0_1(T value);
        }

        struct OverrideLayer<T> : System.IDisposable
        {
            /*0x0*/ Unity.VisualScripting.OverrideStack<T> <stack>k__BackingField;

            /*0x2a5510*/ OverrideLayer(Unity.VisualScripting.OverrideStack<T> stack, T item);
            /*0x1803b0*/ Unity.VisualScripting.OverrideStack<T> get_stack();
            /*0x180fc0*/ void Dispose();
        }

        class Recursion<T> : Unity.VisualScripting.IPoolable, System.IDisposable
        {
            /*0x0*/ System.Collections.Generic.Stack<T> traversedOrder;
            /*0x0*/ System.Collections.Generic.Dictionary<T, int> traversedCount;
            /*0x0*/ bool disposed;
            /*0x0*/ int maxDepth;

            static /*0x180cf0*/ Unity.VisualScripting.Recursion<T> New();
            static /*0x17e6a0*/ Unity.VisualScripting.Recursion<T> New(int maxDepth);
            /*0x180fc0*/ Recursion();
            /*0x2a5510*/ void Enter(T o);
            /*0x2a5510*/ bool TryEnter(T o);
            /*0x2a5510*/ void Exit(T o);
            /*0x180fc0*/ void Dispose();
            /*0x180fc0*/ void Free();
            /*0x180fc0*/ void Unity.VisualScripting.IPoolable.New();
            /*0x180fc0*/ void Unity.VisualScripting.IPoolable.Free();

            class <>c<T>
            {
                static /*0x0*/ Unity.VisualScripting.Recursion.<>c<T> <>9;
                static /*0x0*/ System.Func<Unity.VisualScripting.Recursion<T>> <>9__13_0;

                static /*0x180ff0*/ <>c();
                /*0x180fc0*/ <>c();
                /*0x1803b0*/ Unity.VisualScripting.Recursion<T> <New>b__13_0();
            }
        }

        class Recursion : Unity.VisualScripting.Recursion<object>
        {
            static /*0x0*/ int <defaultMaxDepth>k__BackingField;
            static /*0x4*/ bool <safeMode>k__BackingField;

            static /*0x15816b0*/ Recursion();
            static /*0x1581730*/ int get_defaultMaxDepth();
            static /*0x15817d0*/ void set_defaultMaxDepth(int value);
            static /*0x1581780*/ bool get_safeMode();
            static /*0x1581830*/ void set_safeMode(bool value);
            static /*0x15815b0*/ void OnRuntimeMethodLoad();
            static /*0x1581310*/ Unity.VisualScripting.Recursion New();
            static /*0x15813a0*/ Unity.VisualScripting.Recursion New(int maxDepth);
            /*0x15816f0*/ Recursion();
            /*0x15812b0*/ void Free();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.Recursion.<> <>9;
                static /*0x8*/ System.Func<Unity.VisualScripting.Recursion> <>9__12_0;

                static /*0x1586420*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1585f20*/ Unity.VisualScripting.Recursion <New>b__12_0();
            }
        }

        class ReferenceCollector
        {
            static /*0x0*/ System.Action onSceneUnloaded;

            static /*0x15819a0*/ void add_onSceneUnloaded(System.Action value);
            static /*0x1581a60*/ void remove_onSceneUnloaded(System.Action value);
            static /*0x1581890*/ void Initialize();

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.ReferenceCollector.<> <>9;
                static /*0x8*/ UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene> <>9__3_0;

                static /*0x1586730*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1585ed0*/ void <Initialize>b__3_0(UnityEngine.SceneManagement.Scene scene);
            }
        }

        class ReferenceEqualityComparer : System.Collections.Generic.IEqualityComparer<object>
        {
            static /*0x0*/ Unity.VisualScripting.ReferenceEqualityComparer Instance;

            static /*0x1581b70*/ ReferenceEqualityComparer();
            static /*0xc44ca0*/ int GetHashCode(object a);
            /*0x32f970*/ ReferenceEqualityComparer();
            /*0xc44d90*/ bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object a, object b);
            /*0x1581b20*/ int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object a);
        }

        class ReferenceEqualityComparer<T> : System.Collections.Generic.IEqualityComparer<T>
        {
            static /*0x0*/ Unity.VisualScripting.ReferenceEqualityComparer<T> Instance;

            static /*0x180ff0*/ ReferenceEqualityComparer();
            static /*0x2a5510*/ int GetHashCode(T a);
            /*0x180fc0*/ ReferenceEqualityComparer();
            /*0x2a5510*/ bool System.Collections.Generic.IEqualityComparer<T>.Equals(T a, T b);
            /*0x2a5510*/ int System.Collections.Generic.IEqualityComparer<T>.GetHashCode(T a);
        }

        class RuntimeVSUsageUtility
        {
            static /*0x1581be0*/ void RuntimeInitializeOnLoadBeforeSceneLoad();
        }

        class StringUtility
        {
            static /*0x0*/ System.Text.RegularExpressions.Regex guidRegex;

            static /*0x15857c0*/ StringUtility();
            static /*0x1584260*/ bool IsNullOrWhiteSpace(string s);
            static /*0x1583b60*/ string FallbackEmpty(string s, string fallback);
            static /*0x1583b90*/ string FallbackWhitespace(string s, string fallback);
            static /*0x1583920*/ void AppendLineFormat(System.Text.StringBuilder sb, string format, object[] args);
            static /*0x1585540*/ string ToSeparatedString(System.Collections.IEnumerable enumerable, string separator);
            static /*0x1585410*/ string ToCommaSeparatedString(System.Collections.IEnumerable enumerable);
            static /*0x15854e0*/ string ToLineSeparatedString(System.Collections.IEnumerable enumerable);
            static /*0x1583950*/ bool ContainsInsensitive(string haystack, string needle);
            static /*0x1583890*/ System.Collections.Generic.IEnumerable<int> AllIndexesOf(string haystack, string needle);
            static /*0x1583e40*/ string Filter(string s, bool letters, bool numbers, bool whitespace, bool symbols, bool punctuation);
            static /*0x1583c30*/ string FilterReplace(string s, char replacement, bool merge, bool letters, bool numbers, bool whitespace, bool symbols, bool punctuation);
            static /*0x1584ca0*/ string Prettify(string s);
            static /*0x1584770*/ bool IsWordDelimiter(char c);
            static /*0x1584470*/ bool IsWordBeginning(System.Nullable<char> previous, char current, System.Nullable<char> next);
            static /*0x15842c0*/ bool IsWordBeginning(string s, int index);
            static /*0x15850f0*/ string SplitWords(string s, char separator);
            static /*0x1584eb0*/ string RemoveConsecutiveCharacters(string s, char c);
            static /*0x1584f90*/ string ReplaceMultiple(string s, System.Collections.Generic.HashSet<char> haystacks, char replacement);
            static /*0x1585770*/ string Truncate(string value, int maxLength, string suffix);
            static /*0x15856b0*/ string TrimEnd(string source, string value);
            static /*0x1585710*/ string TrimStart(string source, string value);
            static /*0x1584010*/ string FirstCharacterToLower(string s);
            static /*0x1584100*/ string FirstCharacterToUpper(string s);
            static /*0x1584930*/ string PartBefore(string s, char c);
            static /*0x1584870*/ string PartAfter(string s, char c);
            static /*0x15849f0*/ void PartsAround(string s, char c, ref string before, ref string after);
            static /*0x1583ac0*/ bool EndsWith(string s, char c);
            static /*0x1585210*/ bool StartsWith(string s, char c);
            static /*0x1583980*/ bool Contains(string s, char c);
            static /*0x1584810*/ string NullIfEmpty(string s);
            static /*0x1585320*/ string ToBinaryString(int value);
            static /*0x15852b0*/ string ToBinaryString(long value);
            static /*0x1585390*/ string ToBinaryString(System.Enum value);
            static /*0x1583a50*/ int CountIndices(string s, char c);
            static /*0x15841f0*/ bool IsGuid(string value);
            static /*0x1584b00*/ string PathEllipsis(string s, int maxLength);
            static /*0x1585470*/ string ToHexString(byte[] bytes);

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.StringUtility.<> <>9;
                static /*0x8*/ System.Func<object, string> <>9__4_0;

                static /*0x1586570*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1586080*/ string <ToSeparatedString>b__4_0(object o);
            }

            class <AllIndexesOf>d__8 : System.Collections.Generic.IEnumerable<int>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<int>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x14*/ int <>2__current;
                /*0x18*/ int <>l__initialThreadId;
                /*0x20*/ string needle;
                /*0x28*/ string <>3__needle;
                /*0x30*/ string haystack;
                /*0x38*/ string <>3__haystack;
                /*0x40*/ int <index>5__2;

                /*0x70abc0*/ <AllIndexesOf>d__8(int <>1__state);
                /*0x32d010*/ void System.IDisposable.Dispose();
                /*0x1585850*/ bool MoveNext();
                /*0x70a440*/ int System.Collections.Generic.IEnumerator<System.Int32>.get_Current();
                /*0x15859a0*/ void System.Collections.IEnumerator.Reset();
                /*0x15859e0*/ object System.Collections.IEnumerator.get_Current();
                /*0x15858f0*/ System.Collections.Generic.IEnumerator<int> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator();
                /*0x15858f0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class UnityObjectUtility
        {
            static /*0x15867a0*/ bool IsDestroyed(UnityEngine.Object target);
            static /*0x1586800*/ bool IsUnityNull(object obj);
            static /*0x15868c0*/ string ToSafeString(UnityEngine.Object uo);
            static /*0x1586b00*/ string ToSafeString(object obj);
            static /*0x2a5510*/ T AsUnityNull<T>(T obj);
            static /*0x1586ce0*/ bool TrulyEqual(UnityEngine.Object a, UnityEngine.Object b);
            static /*0x17e030*/ System.Collections.Generic.IEnumerable<T> NotUnityNull<T>(System.Collections.Generic.IEnumerable<T> enumerable);
            static /*0x180cf0*/ System.Collections.Generic.IEnumerable<T> FindObjectsOfTypeIncludingInactive<T>();

            class <>c__6<T>
            {
                static /*0x0*/ Unity.VisualScripting.UnityObjectUtility.<>c__6<T> <>9;
                static /*0x0*/ System.Func<T, bool> <>9__6_0;

                static /*0x180ff0*/ <>c__6();
                /*0x180fc0*/ <>c__6();
                /*0x2a5510*/ bool <NotUnityNull>b__6_0(T i);
            }

            class <FindObjectsOfTypeIncludingInactive>d__7<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x0*/ int <>1__state;
                /*0x0*/ T <>2__current;
                /*0x0*/ int <>l__initialThreadId;
                /*0x0*/ int <i>5__2;
                /*0x0*/ UnityEngine.GameObject[] <>7__wrap2;
                /*0x0*/ int <>7__wrap3;
                /*0x0*/ T[] <>7__wrap4;
                /*0x0*/ int <>7__wrap5;

                /*0x17aa40*/ <FindObjectsOfTypeIncludingInactive>d__7(int <>1__state);
                /*0x180fc0*/ void System.IDisposable.Dispose();
                /*0x17cb40*/ bool MoveNext();
                /*0x2a5510*/ T System.Collections.Generic.IEnumerator<T>.get_Current();
                /*0x180fc0*/ void System.Collections.IEnumerator.Reset();
                /*0x1803b0*/ object System.Collections.IEnumerator.get_Current();
                /*0x1803b0*/ System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator();
                /*0x1803b0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class XColor
        {
            static /*0x1588890*/ string ToHexString(UnityEngine.Color color);
        }

        class ApplicationVariables
        {
            static string assetPath = "ApplicationVariables";
            static /*0x0*/ Unity.VisualScripting.VariablesAsset _asset;
            static /*0x8*/ Unity.VisualScripting.VariableDeclarations <runtime>k__BackingField;

            static /*0x1575bc0*/ Unity.VisualScripting.VariablesAsset get_asset();
            static /*0x1575b20*/ void Load();
            static /*0x1575d80*/ Unity.VisualScripting.VariableDeclarations get_runtime();
            static /*0x1575dc0*/ void set_runtime(Unity.VisualScripting.VariableDeclarations value);
            static /*0x1575d60*/ Unity.VisualScripting.VariableDeclarations get_initial();
            static /*0x1575cd0*/ Unity.VisualScripting.VariableDeclarations get_current();
            static /*0x1575ac0*/ void OnEnterEditMode();
            static /*0x32d010*/ void OnExitEditMode();
            static /*0x15759f0*/ void OnEnterPlayMode();
            static /*0x32d010*/ void OnExitPlayMode();
            static /*0x15759f0*/ void CreateRuntimeDeclarations();
            static /*0x1575ac0*/ void DestroyRuntimeDeclarations();
        }

        interface IGraphDataWithVariables : Unity.VisualScripting.IGraphData
        {
            /*0x1803b0*/ Unity.VisualScripting.VariableDeclarations get_variables();
        }

        interface IGraphWithVariables : Unity.VisualScripting.IGraph, System.IDisposable, Unity.VisualScripting.IPrewarmable, Unity.VisualScripting.IAotStubbable, Unity.VisualScripting.ISerializationDepender, UnityEngine.ISerializationCallbackReceiver
        {
            /*0x1803b0*/ Unity.VisualScripting.VariableDeclarations get_variables();
            System.Collections.Generic.IEnumerable<string> GetDynamicVariableNames(Unity.VisualScripting.VariableKind kind, Unity.VisualScripting.GraphReference reference);
        }

        class InspectorVariableNameAttribute : System.Attribute
        {
            /*0x10*/ Unity.VisualScripting.ActionDirection <direction>k__BackingField;

            /*0xea4040*/ InspectorVariableNameAttribute(Unity.VisualScripting.ActionDirection direction);
            /*0x417e30*/ Unity.VisualScripting.ActionDirection get_direction();
            /*0xdcd9c0*/ void set_direction(Unity.VisualScripting.ActionDirection value);
        }

        class ObjectVariables
        {
            static /*0x157f840*/ Unity.VisualScripting.VariableDeclarations Declarations(UnityEngine.GameObject source, bool autoAddComponent, bool throwOnMissing);
        }

        class SavedVariables
        {
            static string assetPath = "SavedVariables";
            static string playerPrefsKey = "LudiqSavedVariables";
            static /*0x0*/ Unity.VisualScripting.VariablesAsset _asset;
            static /*0x8*/ Unity.VisualScripting.VariableDeclarations <saved>k__BackingField;
            static /*0x10*/ Unity.VisualScripting.VariableDeclarations <merged>k__BackingField;

            static /*0x15830e0*/ Unity.VisualScripting.VariablesAsset get_asset();
            static /*0x1582200*/ void Load();
            static /*0x1582a00*/ void OnEnterEditMode();
            static /*0x1582c20*/ void OnExitEditMode();
            static /*0x1582a60*/ void OnEnterPlayMode();
            static /*0x1582c60*/ void OnExitPlayMode();
            static /*0x1583270*/ Unity.VisualScripting.VariableDeclarations get_initial();
            static /*0x15833d0*/ Unity.VisualScripting.VariableDeclarations get_saved();
            static /*0x1583470*/ void set_saved(Unity.VisualScripting.VariableDeclarations value);
            static /*0x1583390*/ Unity.VisualScripting.VariableDeclarations get_merged();
            static /*0x1583410*/ void set_merged(Unity.VisualScripting.VariableDeclarations value);
            static /*0x15831f0*/ Unity.VisualScripting.VariableDeclarations get_current();
            static /*0x1582ca0*/ void SaveDeclarations(Unity.VisualScripting.VariableDeclarations declarations);
            static /*0x1581f80*/ void FetchSavedDeclarations();
            static /*0x15822a0*/ void MergeInitialAndSavedDeclarations();
            static /*0x1581f20*/ void DestroyMergedDeclarations();
            static /*0x1582de0*/ void WarnAndNullifyUnityObjectReferences(Unity.VisualScripting.VariableDeclarations declarations);

            class <>c
            {
                static /*0x0*/ Unity.VisualScripting.SavedVariables.<> <>9;
                static /*0x8*/ System.Action <>9__8_0;
                static /*0x10*/ System.Func<Unity.VisualScripting.VariableDeclaration, string> <>9__24_0;

                static /*0x1586490*/ <>c();
                /*0x32f970*/ <>c();
                /*0x1585f90*/ void <OnEnterPlayMode>b__8_0();
                /*0x10daaf0*/ string <MergeInitialAndSavedDeclarations>b__24_0(Unity.VisualScripting.VariableDeclaration vd);
            }
        }

        class SceneVariables : UnityEngine.MonoBehaviour, Unity.VisualScripting.ISingleton
        {
            /*0x20*/ Unity.VisualScripting.Variables _variables;

            static /*0x15836d0*/ Unity.VisualScripting.SceneVariables Instance(UnityEngine.SceneManagement.Scene scene);
            static /*0x1583730*/ bool InstantiatedIn(UnityEngine.SceneManagement.Scene scene);
            static /*0x1583530*/ Unity.VisualScripting.VariableDeclarations For(System.Nullable<UnityEngine.SceneManagement.Scene> scene);
            /*0x31c640*/ SceneVariables();
            /*0x15834d0*/ void Awake();
            /*0x1583790*/ void OnDestroy();
            /*0x15837f0*/ Unity.VisualScripting.Variables get_variables();
        }

        class VariableDeclaration
        {
            /*0x10*/ string <name>k__BackingField;
            /*0x18*/ object <value>k__BackingField;
            /*0x20*/ Unity.VisualScripting.SerializableType <typeHandle>k__BackingField;

            /*0x32f970*/ VariableDeclaration();
            /*0xce3b90*/ VariableDeclaration(string name, object value);
            /*0x73d3e0*/ string get_name();
            /*0x9f12f0*/ void set_name(string value);
            /*0x32f410*/ object get_value();
            /*0x7963c0*/ void set_value(object value);
            /*0x61a260*/ Unity.VisualScripting.SerializableType get_typeHandle();
            /*0x1587020*/ void set_typeHandle(Unity.VisualScripting.SerializableType value);
        }

        class VariableDeclarationCollection : System.Collections.ObjectModel.KeyedCollection<string, Unity.VisualScripting.VariableDeclaration>, Unity.VisualScripting.IKeyedCollection<string, Unity.VisualScripting.VariableDeclaration>, System.Collections.Generic.ICollection<Unity.VisualScripting.VariableDeclaration>, System.Collections.Generic.IEnumerable<Unity.VisualScripting.VariableDeclaration>, System.Collections.IEnumerable
        {
            /*0x1586fe0*/ VariableDeclarationCollection();
            /*0x10daaf0*/ string GetKeyForItem(Unity.VisualScripting.VariableDeclaration item);
            /*0x1586d90*/ void EditorRename(Unity.VisualScripting.VariableDeclaration item, string newName);
            /*0x1586df0*/ bool TryGetValue(string key, ref Unity.VisualScripting.VariableDeclaration value);
            /*0x1586f90*/ Unity.VisualScripting.VariableDeclaration Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.VariableDeclaration>.get_Item(string key);
            /*0x1586ef0*/ bool Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.VariableDeclaration>.Contains(string key);
            /*0x1586f40*/ bool Unity.VisualScripting.IKeyedCollection<System.String,Unity.VisualScripting.VariableDeclaration>.Remove(string key);
        }

        class VariableDeclarations : System.Collections.Generic.IEnumerable<Unity.VisualScripting.VariableDeclaration>, System.Collections.IEnumerable, Unity.VisualScripting.ISpecifiesCloner
        {
            /*0x10*/ Unity.VisualScripting.VariableKind Kind;
            /*0x18*/ Unity.VisualScripting.VariableDeclarationCollection collection;
            /*0x20*/ System.Action OnVariableChanged;

            /*0x15879c0*/ VariableDeclarations();
            /*0x1587a50*/ object get_Item(string variable);
            /*0x15877f0*/ void set_Item(string variable, object value);
            /*0x15877f0*/ void Set(string variable, object value);
            /*0x1587570*/ object Get(string variable);
            /*0x2a5510*/ T Get<T>(string variable);
            /*0x15876b0*/ object Get(string variable, System.Type expectedType);
            /*0x1587410*/ void Clear();
            /*0x1587730*/ bool IsDefined(string variable);
            /*0x1587460*/ Unity.VisualScripting.VariableDeclaration GetDeclaration(string variable);
            /*0x1587520*/ System.Collections.Generic.IEnumerator<Unity.VisualScripting.VariableDeclaration> GetEnumerator();
            /*0x1587920*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            /*0x1587970*/ Unity.VisualScripting.ICloner Unity.VisualScripting.ISpecifiesCloner.get_cloner();
        }

        class VariableDeclarationsCloner : Unity.VisualScripting.Cloner<Unity.VisualScripting.VariableDeclarations>
        {
            static /*0x0*/ Unity.VisualScripting.VariableDeclarationsCloner instance;

            static /*0x1587340*/ VariableDeclarationsCloner();
            /*0x15873d0*/ VariableDeclarationsCloner();
            /*0x15872c0*/ bool Handles(System.Type type);
            /*0x1587030*/ Unity.VisualScripting.VariableDeclarations ConstructClone(System.Type type, Unity.VisualScripting.VariableDeclarations original);
            /*0x1587080*/ void FillClone(System.Type type, ref Unity.VisualScripting.VariableDeclarations clone, Unity.VisualScripting.VariableDeclarations original, Unity.VisualScripting.CloningContext context);
        }

        enum VariableKind
        {
            Flow = 0,
            Graph = 1,
            Object = 2,
            Scene = 3,
            Application = 4,
            Saved = 5,
        }

        class VariableKindAttribute : System.Attribute
        {
            /*0x10*/ Unity.VisualScripting.VariableKind <kind>k__BackingField;

            /*0xea4040*/ VariableKindAttribute(Unity.VisualScripting.VariableKind kind);
            /*0x417e30*/ Unity.VisualScripting.VariableKind get_kind();
        }

        class Variables : Unity.VisualScripting.LudiqBehaviour, Unity.VisualScripting.IAotStubbable
        {
            /*0x30*/ Unity.VisualScripting.VariableDeclarations <declarations>k__BackingField;

            static /*0x1588070*/ Unity.VisualScripting.VariableDeclarations Graph(Unity.VisualScripting.GraphPointer pointer);
            static /*0x1588000*/ Unity.VisualScripting.VariableDeclarations GraphInstance(Unity.VisualScripting.GraphPointer pointer);
            static /*0x1587ef0*/ Unity.VisualScripting.VariableDeclarations GraphDefinition(Unity.VisualScripting.GraphPointer pointer);
            static /*0x1587fb0*/ Unity.VisualScripting.VariableDeclarations GraphDefinition(Unity.VisualScripting.IGraphWithVariables graph);
            static /*0x1588200*/ Unity.VisualScripting.VariableDeclarations Object(UnityEngine.GameObject go);
            static /*0x1588250*/ Unity.VisualScripting.VariableDeclarations Object(UnityEngine.Component component);
            static /*0x15883b0*/ Unity.VisualScripting.VariableDeclarations Scene(System.Nullable<UnityEngine.SceneManagement.Scene> scene);
            static /*0x15882b0*/ Unity.VisualScripting.VariableDeclarations Scene(UnityEngine.GameObject go);
            static /*0x1588320*/ Unity.VisualScripting.VariableDeclarations Scene(UnityEngine.Component component);
            static /*0x15885e0*/ Unity.VisualScripting.VariableDeclarations get_ActiveScene();
            static /*0x1588660*/ Unity.VisualScripting.VariableDeclarations get_Application();
            static /*0x1588810*/ Unity.VisualScripting.VariableDeclarations get_Saved();
            static /*0x1587d60*/ bool ExistOnObject(UnityEngine.GameObject go);
            static /*0x1587de0*/ bool ExistOnObject(UnityEngine.Component component);
            static /*0x1587cb0*/ bool ExistInScene(System.Nullable<UnityEngine.SceneManagement.Scene> scene);
            static /*0x15886f0*/ bool get_ExistInActiveScene();
            /*0x1588560*/ Variables();
            /*0x997630*/ Unity.VisualScripting.VariableDeclarations get_declarations();
            /*0x997640*/ void set_declarations(Unity.VisualScripting.VariableDeclarations value);
            /*0x1588550*/ void ShowData();
            /*0x1587e70*/ System.Collections.Generic.IEnumerable<object> GetAotStubs(System.Collections.Generic.HashSet<object> visited);

            class <GetAotStubs>d__25 : System.Collections.Generic.IEnumerable<object>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<object>, System.Collections.IEnumerator, System.IDisposable
            {
                /*0x10*/ int <>1__state;
                /*0x18*/ object <>2__current;
                /*0x20*/ int <>l__initialThreadId;
                /*0x28*/ Unity.VisualScripting.Variables <>4__this;
                /*0x30*/ System.Collections.Generic.IEnumerator<Unity.VisualScripting.VariableDeclaration> <>7__wrap1;

                /*0x70aad0*/ <GetAotStubs>d__25(int <>1__state);
                /*0x1585da0*/ void System.IDisposable.Dispose();
                /*0x1585a30*/ bool MoveNext();
                /*0x1585e30*/ void <>m__Finally1();
                /*0x32f410*/ object System.Collections.Generic.IEnumerator<System.Object>.get_Current();
                /*0x1585d60*/ void System.Collections.IEnumerator.Reset();
                /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
                /*0x1585cc0*/ System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
                /*0x1585cc0*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
            }
        }

        class VariablesAsset : Unity.VisualScripting.LudiqScriptableObject
        {
            /*0x30*/ Unity.VisualScripting.VariableDeclarations <declarations>k__BackingField;

            /*0x1587a70*/ VariablesAsset();
            /*0x997630*/ Unity.VisualScripting.VariableDeclarations get_declarations();
            /*0x997640*/ void set_declarations(Unity.VisualScripting.VariableDeclarations value);
            /*0x1587a60*/ void ShowData();
        }

        class VariablesSaver : UnityEngine.MonoBehaviour, Unity.VisualScripting.ISingleton
        {
            static /*0x1587c50*/ Unity.VisualScripting.VariablesSaver get_instance();
            static /*0x1587b40*/ void Instantiate();
            /*0x31c640*/ VariablesSaver();
            /*0x1587ae0*/ void Awake();
            /*0x1587bf0*/ void OnDestroy();
            /*0x1582c60*/ void OnApplicationQuit();
            /*0x1587ba0*/ void OnApplicationPause(bool isPaused);
        }

        namespace FullSerializer
        {
            class fsArrayConverter : Unity.VisualScripting.FullSerializer.fsConverter
            {
                /*0x32f970*/ fsArrayConverter();
                /*0x14b0dc0*/ bool CanProcess(System.Type type);
                /*0x348b00*/ bool RequestCycleSupport(System.Type storageType);
                /*0x348b00*/ bool RequestInheritanceSupport(System.Type storageType);
                /*0x158a1e0*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
                /*0x1589df0*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance, System.Type storageType);
                /*0x1589d70*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class fsDateConverter : Unity.VisualScripting.FullSerializer.fsConverter
            {
                static string DefaultDateTimeFormatString = "o";
                static string DateTimeOffsetFormatString = "o";

                /*0x32f970*/ fsDateConverter();
                /*0x158d7a0*/ string get_DateTimeFormatString();
                /*0x158ccf0*/ bool CanProcess(System.Type type);
                /*0x158d4d0*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
                /*0x158ce00*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance, System.Type storageType);
            }

            class fsDictionaryConverter : Unity.VisualScripting.FullSerializer.fsConverter
            {
                static /*0x158dd10*/ void GetKeyValueTypes(System.Type dictionaryType, ref System.Type keyStorageType, ref System.Type valueStorageType);
                /*0x32f970*/ fsDictionaryConverter();
                /*0x158dc00*/ bool CanProcess(System.Type type);
                /*0x158dc90*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
                /*0x158de60*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance_, System.Type storageType);
                /*0x158e8e0*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance_, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
                /*0x158d800*/ Unity.VisualScripting.FullSerializer.fsResult AddItemToDictionary(System.Collections.IDictionary dictionary, object key, object value);
            }

            class fsEnumConverter : Unity.VisualScripting.FullSerializer.fsConverter
            {
                static /*0x2a5510*/ bool ArrayContains<T>(T[] values, T value);
                /*0x32f970*/ fsEnumConverter();
                /*0x158f2c0*/ bool CanProcess(System.Type type);
                /*0x348b00*/ bool RequestCycleSupport(System.Type storageType);
                /*0x348b00*/ bool RequestInheritanceSupport(System.Type storageType);
                /*0x158f330*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
                /*0x158fde0*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
                /*0x158f3b0*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance, System.Type storageType);

                class <>c
                {
                    static /*0x0*/ Unity.VisualScripting.FullSerializer.fsEnumConverter.<> <>9;
                    static /*0x8*/ System.Func<System.Enum, System.Collections.Generic.IEnumerable<System.ValueTuple<System.Enum, string>>> <>9__5_0;
                    static /*0x10*/ System.Func<System.ValueTuple<System.Enum, string>, string> <>9__5_1;
                    static /*0x18*/ System.Func<System.ValueTuple<System.Enum, string>, System.Enum> <>9__5_2;

                    static /*0x1586500*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x15860e0*/ System.Collections.Generic.IEnumerable<System.ValueTuple<System.Enum, string>> <TryDeserialize>b__5_0(System.Enum x);
                    /*0x1586200*/ string <TryDeserialize>b__5_1(System.ValueTuple<System.Enum, string> x);
                    /*0x132f7f0*/ System.Enum <TryDeserialize>b__5_2(System.ValueTuple<System.Enum, string> x);
                }

                class <>c__DisplayClass5_0
                {
                    /*0x10*/ System.Enum x;

                    /*0x32f970*/ <>c__DisplayClass5_0();
                    /*0x1586340*/ System.ValueTuple<System.Enum, string> <TryDeserialize>b__3(Unity.VisualScripting.RenamedFromAttribute attr);
                }
            }

            class fsForwardAttribute : System.Attribute
            {
                /*0x10*/ string MemberName;

                /*0xa32e30*/ fsForwardAttribute(string memberName);
            }

            class fsForwardConverter : Unity.VisualScripting.FullSerializer.fsConverter
            {
                /*0x18*/ string _memberName;

                /*0x1590b90*/ fsForwardConverter(Unity.VisualScripting.FullSerializer.fsForwardAttribute attribute);
                /*0x15902c0*/ bool CanProcess(System.Type type);
                /*0x1590390*/ Unity.VisualScripting.FullSerializer.fsResult GetProperty(object instance, ref Unity.VisualScripting.FullSerializer.fsMetaProperty property);
                /*0x1590910*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
                /*0x15905a0*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance, System.Type storageType);
                /*0x1590310*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class fsGuidConverter : Unity.VisualScripting.FullSerializer.fsConverter
            {
                /*0x32f970*/ fsGuidConverter();
                /*0x1590c60*/ bool CanProcess(System.Type type);
                /*0x348b00*/ bool RequestCycleSupport(System.Type storageType);
                /*0x348b00*/ bool RequestInheritanceSupport(System.Type storageType);
                /*0x1590ea0*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
                /*0x1590d20*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance, System.Type storageType);
                /*0x1590ce0*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class fsIEnumerableConverter : Unity.VisualScripting.FullSerializer.fsConverter
            {
                static /*0x15913d0*/ int HintSize(System.Collections.IEnumerable collection);
                static /*0x1591290*/ System.Type GetElementType(System.Type objectType);
                static /*0x1591590*/ void TryClear(System.Type type, object instance);
                static /*0x1591b30*/ int TryGetExistingSize(System.Type type, object instance);
                static /*0x1591110*/ System.Reflection.MethodInfo GetAddMethod(System.Type type);
                /*0x32f970*/ fsIEnumerableConverter();
                /*0x1590fd0*/ bool CanProcess(System.Type type);
                /*0x1591090*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
                /*0x1591c20*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance_, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
                /*0x1591480*/ bool IsStack(System.Type type);
                /*0x1591630*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance_, System.Type storageType);
            }

            class fsKeyValuePairConverter : Unity.VisualScripting.FullSerializer.fsConverter
            {
                /*0x32f970*/ fsKeyValuePairConverter();
                /*0x1596570*/ bool CanProcess(System.Type type);
                /*0x348b00*/ bool RequestCycleSupport(System.Type storageType);
                /*0x348b00*/ bool RequestInheritanceSupport(System.Type storageType);
                /*0x1596660*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance, System.Type storageType);
                /*0x1596bf0*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
            }

            class fsNullableConverter : Unity.VisualScripting.FullSerializer.fsConverter
            {
                /*0x32f970*/ fsNullableConverter();
                /*0x15970f0*/ bool CanProcess(System.Type type);
                /*0x1597260*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
                /*0x15971e0*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance, System.Type storageType);
                /*0x1128190*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class fsPrimitiveConverter : Unity.VisualScripting.FullSerializer.fsConverter
            {
                static /*0x15984c0*/ bool UseBool(System.Type type);
                static /*0x1598650*/ bool UseInt64(System.Type type);
                static /*0x1598540*/ bool UseDouble(System.Type type);
                static /*0x15988c0*/ bool UseString(System.Type type);
                /*0x32f970*/ fsPrimitiveConverter();
                /*0x1597390*/ bool CanProcess(System.Type type);
                /*0x348b00*/ bool RequestCycleSupport(System.Type storageType);
                /*0x348b00*/ bool RequestInheritanceSupport(System.Type storageType);
                /*0x1597d60*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
                /*0x15974a0*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData storage, ref object instance, System.Type storageType);
            }

            class fsReflectedConverter : Unity.VisualScripting.FullSerializer.fsConverter
            {
                /*0x32f970*/ fsReflectedConverter();
                /*0x15989f0*/ bool CanProcess(System.Type type);
                /*0x1598ee0*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
                /*0x1598b50*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance, System.Type storageType);
                /*0x1598ad0*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class fsTypeConverter : Unity.VisualScripting.FullSerializer.fsConverter
            {
                /*0x32f970*/ fsTypeConverter();
                /*0x15a15d0*/ bool CanProcess(System.Type type);
                /*0x348b00*/ bool RequestCycleSupport(System.Type type);
                /*0x348b00*/ bool RequestInheritanceSupport(System.Type type);
                /*0x15a1880*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
                /*0x15a1660*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance, System.Type storageType);
                /*0x1128190*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class fsWeakReferenceConverter : Unity.VisualScripting.FullSerializer.fsConverter
            {
                /*0x32f970*/ fsWeakReferenceConverter();
                /*0x15a19c0*/ bool CanProcess(System.Type type);
                /*0x348b00*/ bool RequestCycleSupport(System.Type storageType);
                /*0x348b00*/ bool RequestInheritanceSupport(System.Type storageType);
                /*0x15a2050*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
                /*0x15a1a90*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance, System.Type storageType);
                /*0x15a1a40*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class fsConverterRegistrar
            {
                static /*0x0*/ Unity.VisualScripting.FullSerializer.AnimationCurve_DirectConverter Register_AnimationCurve_DirectConverter;
                static /*0x8*/ Unity.VisualScripting.FullSerializer.Bounds_DirectConverter Register_Bounds_DirectConverter;
                static /*0x10*/ Unity.VisualScripting.FullSerializer.Gradient_DirectConverter Register_Gradient_DirectConverter;
                static /*0x18*/ Unity.VisualScripting.FullSerializer.GUIStyleState_DirectConverter Register_GUIStyleState_DirectConverter;
                static /*0x20*/ Unity.VisualScripting.FullSerializer.GUIStyle_DirectConverter Register_GUIStyle_DirectConverter;
                static /*0x28*/ Unity.VisualScripting.FullSerializer.Keyframe_DirectConverter Register_Keyframe_DirectConverter;
                static /*0x30*/ Unity.VisualScripting.FullSerializer.LayerMask_DirectConverter Register_LayerMask_DirectConverter;
                static /*0x38*/ Unity.VisualScripting.FullSerializer.RectOffset_DirectConverter Register_RectOffset_DirectConverter;
                static /*0x40*/ Unity.VisualScripting.FullSerializer.Rect_DirectConverter Register_Rect_DirectConverter;
                static /*0x48*/ System.Collections.Generic.List<System.Type> Converters;

                static /*0x158b730*/ fsConverterRegistrar();
                /*0x32f970*/ fsConverterRegistrar();
            }

            class AnimationCurve_DirectConverter : Unity.VisualScripting.FullSerializer.fsDirectConverter<UnityEngine.AnimationCurve>
            {
                /*0x15759b0*/ AnimationCurve_DirectConverter();
                /*0x1575540*/ Unity.VisualScripting.FullSerializer.fsResult DoSerialize(UnityEngine.AnimationCurve model, System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> serialized);
                /*0x1575050*/ Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> data, ref UnityEngine.AnimationCurve model);
                /*0x1575000*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class Bounds_DirectConverter : Unity.VisualScripting.FullSerializer.fsDirectConverter<UnityEngine.Bounds>
            {
                /*0x1576570*/ Bounds_DirectConverter();
                /*0x1576220*/ Unity.VisualScripting.FullSerializer.fsResult DoSerialize(UnityEngine.Bounds model, System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> serialized);
                /*0x1575e80*/ Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> data, ref UnityEngine.Bounds model);
                /*0x1575e20*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class Gradient_DirectConverter : Unity.VisualScripting.FullSerializer.fsDirectConverter<UnityEngine.Gradient>
            {
                static /*0x157e080*/ void LogWarning(string phase);
                /*0x157e1f0*/ Gradient_DirectConverter();
                /*0x157dc00*/ Unity.VisualScripting.FullSerializer.fsResult DoSerialize(UnityEngine.Gradient model, System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> serialized);
                /*0x157d6e0*/ Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> data, ref UnityEngine.Gradient model);
                /*0x157d690*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class GUIStyleState_DirectConverter : Unity.VisualScripting.FullSerializer.fsDirectConverter<UnityEngine.GUIStyleState>
            {
                /*0x1578cf0*/ GUIStyleState_DirectConverter();
                /*0x15789b0*/ Unity.VisualScripting.FullSerializer.fsResult DoSerialize(UnityEngine.GUIStyleState model, System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> serialized);
                /*0x1578620*/ Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> data, ref UnityEngine.GUIStyleState model);
                /*0x15785d0*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class GUIStyle_DirectConverter : Unity.VisualScripting.FullSerializer.fsDirectConverter<UnityEngine.GUIStyle>
            {
                /*0x157d650*/ GUIStyle_DirectConverter();
                /*0x157b500*/ Unity.VisualScripting.FullSerializer.fsResult DoSerialize(UnityEngine.GUIStyle model, System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> serialized);
                /*0x1578d80*/ Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> data, ref UnityEngine.GUIStyle model);
                /*0x1578d30*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class Keyframe_DirectConverter : Unity.VisualScripting.FullSerializer.fsDirectConverter<UnityEngine.Keyframe>
            {
                /*0x157f180*/ Keyframe_DirectConverter();
                /*0x157ea90*/ Unity.VisualScripting.FullSerializer.fsResult DoSerialize(UnityEngine.Keyframe model, System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> serialized);
                /*0x157e330*/ Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> data, ref UnityEngine.Keyframe model);
                /*0x157e2d0*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class LayerMask_DirectConverter : Unity.VisualScripting.FullSerializer.fsDirectConverter<UnityEngine.LayerMask>
            {
                /*0x157f5a0*/ LayerMask_DirectConverter();
                /*0x157f3e0*/ Unity.VisualScripting.FullSerializer.fsResult DoSerialize(UnityEngine.LayerMask model, System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> serialized);
                /*0x157f200*/ Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> data, ref UnityEngine.LayerMask model);
                /*0x157f1c0*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class RectOffset_DirectConverter : Unity.VisualScripting.FullSerializer.fsDirectConverter<UnityEngine.RectOffset>
            {
                /*0x1580650*/ RectOffset_DirectConverter();
                /*0x15800b0*/ Unity.VisualScripting.FullSerializer.fsResult DoSerialize(UnityEngine.RectOffset model, System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> serialized);
                /*0x157fa70*/ Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> data, ref UnityEngine.RectOffset model);
                /*0x157fa20*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class Rect_DirectConverter : Unity.VisualScripting.FullSerializer.fsDirectConverter<UnityEngine.Rect>
            {
                /*0x1581270*/ Rect_DirectConverter();
                /*0x1580cd0*/ Unity.VisualScripting.FullSerializer.fsResult DoSerialize(UnityEngine.Rect model, System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> serialized);
                /*0x15806d0*/ Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> data, ref UnityEngine.Rect model);
                /*0x1580690*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
            }

            class fsAotCompilationManager
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, string> _computedAotCompilations;
                static /*0x8*/ System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsAotCompilationManager.AotCompilation> _uncomputedAotCompilations;

                static /*0x1589ae0*/ fsAotCompilationManager();
                static /*0x1589bd0*/ System.Collections.Generic.Dictionary<System.Type, string> get_AvailableAotCompilations();
                static /*0x1589850*/ bool TryToPerformAotCompilation(Unity.VisualScripting.FullSerializer.fsConfig config, System.Type type, ref string aotCompiledClassInCSharp);
                static /*0x1588a40*/ void AddAotCompilation(System.Type type, Unity.VisualScripting.FullSerializer.fsMetaProperty[] members, bool isConstructorPublic);
                static /*0x1589780*/ string GetConverterString(Unity.VisualScripting.FullSerializer.fsMetaProperty member);
                static /*0x1588bd0*/ string GenerateDirectConverterForTypeInCSharp(System.Type type, Unity.VisualScripting.FullSerializer.fsMetaProperty[] members, bool isConstructorPublic);
                /*0x32f970*/ fsAotCompilationManager();

                struct AotCompilation
                {
                    /*0x10*/ System.Type Type;
                    /*0x18*/ Unity.VisualScripting.FullSerializer.fsMetaProperty[] Members;
                    /*0x20*/ bool IsConstructorPublic;
                }
            }

            class fsBaseConverter
            {
                /*0x10*/ Unity.VisualScripting.FullSerializer.fsSerializer Serializer;

                /*0x32f970*/ fsBaseConverter();
                /*0x158ab60*/ object CreateInstance(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType);
                /*0x158b070*/ bool RequestCycleSupport(System.Type storageType);
                /*0x158b180*/ bool RequestInheritanceSupport(System.Type storageType);
                Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
                Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance, System.Type storageType);
                /*0x158ad00*/ Unity.VisualScripting.FullSerializer.fsResult FailExpectedType(Unity.VisualScripting.FullSerializer.fsData data, Unity.VisualScripting.FullSerializer.fsDataType[] types);
                /*0x158a8b0*/ Unity.VisualScripting.FullSerializer.fsResult CheckType(Unity.VisualScripting.FullSerializer.fsData data, Unity.VisualScripting.FullSerializer.fsDataType type);
                /*0x158a600*/ Unity.VisualScripting.FullSerializer.fsResult CheckKey(Unity.VisualScripting.FullSerializer.fsData data, string key, ref Unity.VisualScripting.FullSerializer.fsData subitem);
                /*0x158a6a0*/ Unity.VisualScripting.FullSerializer.fsResult CheckKey(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> data, string key, ref Unity.VisualScripting.FullSerializer.fsData subitem);
                /*0x2a5510*/ Unity.VisualScripting.FullSerializer.fsResult SerializeMember<T>(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> data, System.Type overrideConverterType, string name, T value);
                /*0x2a5510*/ Unity.VisualScripting.FullSerializer.fsResult DeserializeMember<T>(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> data, System.Type overrideConverterType, string name, ref T value);

                class <>c
                {
                    static /*0x0*/ Unity.VisualScripting.FullSerializer.fsBaseConverter.<> <>9;
                    static /*0x8*/ System.Func<Unity.VisualScripting.FullSerializer.fsDataType, string> <>9__6_0;

                    static /*0x15865e0*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x1585e80*/ string <FailExpectedType>b__6_0(Unity.VisualScripting.FullSerializer.fsDataType t);
                }
            }

            class fsGlobalConfig
            {
                static /*0x0*/ bool IsCaseSensitive;
                static /*0x1*/ bool AllowInternalExceptions;
                static /*0x8*/ string InternalFieldPrefix;

                static /*0x1590bd0*/ fsGlobalConfig();
            }

            class fsConfig
            {
                /*0x10*/ System.Type[] SerializeAttributes;
                /*0x18*/ System.Type[] IgnoreSerializeAttributes;
                /*0x20*/ Unity.VisualScripting.FullSerializer.fsMemberSerialization DefaultMemberSerialization;
                /*0x28*/ System.Func<string, System.Reflection.MemberInfo, string> GetJsonNameFromMemberName;
                /*0x30*/ bool EnablePropertySerialization;
                /*0x31*/ bool SerializeNonAutoProperties;
                /*0x32*/ bool SerializeNonPublicSetProperties;
                /*0x38*/ string CustomDateTimeFormatString;
                /*0x40*/ bool Serialize64BitIntegerAsString;
                /*0x41*/ bool SerializeEnumsAsInteger;

                /*0x158b1f0*/ fsConfig();

                class <>c
                {
                    static /*0x0*/ Unity.VisualScripting.FullSerializer.fsConfig.<> <>9;
                    static /*0x8*/ System.Func<string, System.Reflection.MemberInfo, string> <>9__10_0;

                    static /*0x1586650*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x718e40*/ string <.ctor>b__10_0(string name, System.Reflection.MemberInfo info);
                }
            }

            class fsContext
            {
                /*0x10*/ System.Collections.Generic.Dictionary<System.Type, object> _contextObjects;

                /*0x158b6b0*/ fsContext();
                /*0x158b660*/ void Reset();
                /*0x2a5510*/ void Set<T>(T obj);
                /*0x17cb40*/ bool Has<T>();
                /*0x2a5510*/ T Get<T>();
            }

            class fsConverter : Unity.VisualScripting.FullSerializer.fsBaseConverter
            {
                /*0x32f970*/ fsConverter();
                /*0x17e620*/ bool CanProcess(System.Type type);
            }

            enum fsDataType
            {
                Array = 0,
                Object = 1,
                Double = 2,
                Int64 = 3,
                Boolean = 4,
                String = 5,
                Null = 6,
            }

            class fsData
            {
                static /*0x0*/ Unity.VisualScripting.FullSerializer.fsData True;
                static /*0x8*/ Unity.VisualScripting.FullSerializer.fsData False;
                static /*0x10*/ Unity.VisualScripting.FullSerializer.fsData Null;
                /*0x10*/ object _value;

                static /*0x158c2f0*/ fsData();
                static /*0x158bad0*/ Unity.VisualScripting.FullSerializer.fsData CreateDictionary();
                static /*0x158bc60*/ Unity.VisualScripting.FullSerializer.fsData CreateList();
                static /*0x158bd00*/ Unity.VisualScripting.FullSerializer.fsData CreateList(int capacity);
                static /*0x158cb90*/ bool op_Equality(Unity.VisualScripting.FullSerializer.fsData a, Unity.VisualScripting.FullSerializer.fsData b);
                static /*0x158cc90*/ bool op_Inequality(Unity.VisualScripting.FullSerializer.fsData a, Unity.VisualScripting.FullSerializer.fsData b);
                /*0x158c560*/ fsData();
                /*0x158c480*/ fsData(bool boolean);
                /*0x158c4f0*/ fsData(double f);
                /*0x158c590*/ fsData(long i);
                /*0x49b490*/ fsData(string str);
                /*0x49b490*/ fsData(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> dict);
                /*0x49b490*/ fsData(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsData> list);
                /*0x158c2e0*/ string ToString();
                /*0x158b9e0*/ void BecomeDictionary();
                /*0x158ba50*/ Unity.VisualScripting.FullSerializer.fsData Clone();
                /*0x158c9c0*/ Unity.VisualScripting.FullSerializer.fsDataType get_Type();
                /*0x10ac720*/ bool get_IsNull();
                /*0x158c850*/ bool get_IsDouble();
                /*0x158c8a0*/ bool get_IsInt64();
                /*0x158c780*/ bool get_IsBool();
                /*0x158c970*/ bool get_IsString();
                /*0x158c7d0*/ bool get_IsDictionary();
                /*0x158c8f0*/ bool get_IsList();
                /*0x158c680*/ double get_AsDouble();
                /*0x158c6c0*/ long get_AsInt64();
                /*0x158c600*/ bool get_AsBool();
                /*0x158c740*/ string get_AsString();
                /*0x158c640*/ System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> get_AsDictionary();
                /*0x158c700*/ System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsData> get_AsList();
                /*0x2a5510*/ T Cast<T>();
                /*0x158bda0*/ bool Equals(object obj);
                /*0x158be00*/ bool Equals(Unity.VisualScripting.FullSerializer.fsData other);
                /*0xe77c60*/ int GetHashCode();
            }

            class fsDirectConverter : Unity.VisualScripting.FullSerializer.fsBaseConverter
            {
                /*0x32f970*/ fsDirectConverter();
                /*0x1803b0*/ System.Type get_ModelType();
            }

            class fsDirectConverter<TModel> : Unity.VisualScripting.FullSerializer.fsDirectConverter
            {
                /*0x180fc0*/ fsDirectConverter();
                /*0x1803b0*/ System.Type get_ModelType();
                Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
                Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance, System.Type storageType);
                /*0x2a5510*/ Unity.VisualScripting.FullSerializer.fsResult DoSerialize(TModel model, System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> serialized);
                Unity.VisualScripting.FullSerializer.fsResult DoDeserialize(System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> data, ref TModel model);
            }

            class fsMissingVersionConstructorException : System.Exception
            {
                /*0x1597000*/ fsMissingVersionConstructorException(System.Type versionedType, System.Type constructorType);
            }

            class fsDuplicateVersionNameException : System.Exception
            {
                /*0x158f0f0*/ fsDuplicateVersionNameException(System.Type typeA, System.Type typeB, string version);
            }

            class fsIgnoreAttribute : System.Attribute
            {
                /*0x534220*/ fsIgnoreAttribute();
            }

            interface fsISerializationCallbacks
            {
                /*0x17aec0*/ void OnBeforeSerialize(System.Type storageType);
                /*0x183150*/ void OnAfterSerialize(System.Type storageType, ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x183150*/ void OnBeforeDeserialize(System.Type storageType, ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x17aec0*/ void OnAfterDeserialize(System.Type storageType);
            }

            class fsSerializationCallbackProcessor : Unity.VisualScripting.FullSerializer.fsObjectProcessor
            {
                /*0x32f970*/ fsSerializationCallbackProcessor();
                /*0x1599cd0*/ bool CanProcess(System.Type type);
                /*0x159a080*/ void OnBeforeSerialize(System.Type storageType, object instance);
                /*0x1599e00*/ void OnAfterSerialize(System.Type storageType, object instance, ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x1599ec0*/ void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x1599d60*/ void OnAfterDeserialize(System.Type storageType, object instance);
            }

            class fsSerializationCallbackReceiverProcessor : Unity.VisualScripting.FullSerializer.fsObjectProcessor
            {
                /*0x32f970*/ fsSerializationCallbackReceiverProcessor();
                /*0x159a120*/ bool CanProcess(System.Type type);
                /*0x159a280*/ void OnBeforeSerialize(System.Type storageType, object instance);
                /*0x159a1b0*/ void OnAfterDeserialize(System.Type storageType, object instance);
            }

            class fsJsonParser
            {
                /*0x10*/ System.Text.StringBuilder _cachedStringBuilder;
                /*0x18*/ int _start;
                /*0x20*/ string _input;

                static /*0x15928e0*/ Unity.VisualScripting.FullSerializer.fsResult Parse(string input, ref Unity.VisualScripting.FullSerializer.fsData data);
                static /*0x15926e0*/ Unity.VisualScripting.FullSerializer.fsData Parse(string input);
                /*0x1594f20*/ fsJsonParser(string input);
                /*0x15923a0*/ Unity.VisualScripting.FullSerializer.fsResult MakeFailure(string message);
                /*0x1593260*/ bool TryMoveNext();
                /*0x1592290*/ bool HasValue();
                /*0x15922c0*/ bool HasValue(int offset);
                /*0x1592230*/ char Character();
                /*0x1592260*/ char Character(int offset);
                /*0x1592fa0*/ void SkipSpace();
                /*0x15935f0*/ Unity.VisualScripting.FullSerializer.fsResult TryParseExact(string content);
                /*0x1594610*/ Unity.VisualScripting.FullSerializer.fsResult TryParseTrue(ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x1593770*/ Unity.VisualScripting.FullSerializer.fsResult TryParseFalse(ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x15938d0*/ Unity.VisualScripting.FullSerializer.fsResult TryParseNull(ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x1592330*/ bool IsSeparator(char c);
                /*0x15939f0*/ Unity.VisualScripting.FullSerializer.fsResult TryParseNumber(ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x15942f0*/ Unity.VisualScripting.FullSerializer.fsResult TryParseString(ref string str);
                /*0x1593290*/ Unity.VisualScripting.FullSerializer.fsResult TryParseArray(ref Unity.VisualScripting.FullSerializer.fsData arr);
                /*0x1593dc0*/ Unity.VisualScripting.FullSerializer.fsResult TryParseObject(ref Unity.VisualScripting.FullSerializer.fsData obj);
                /*0x1592a40*/ Unity.VisualScripting.FullSerializer.fsResult RunParse(ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x1592300*/ bool IsHex(char c);
                /*0x1592590*/ uint ParseSingleChar(char c1, uint multipliyer);
                /*0x15925d0*/ uint ParseUnicode(char c1, char c2, char c3, char c4);
                /*0x1594770*/ Unity.VisualScripting.FullSerializer.fsResult TryUnescapeChar(ref char escaped);
            }

            class fsJsonPrinter
            {
                static /*0x15963a0*/ void InsertSpacing(System.IO.TextWriter stream, int count);
                static /*0x1595fa0*/ string EscapeString(string str);
                static /*0x1594fc0*/ void BuildCompressedString(Unity.VisualScripting.FullSerializer.fsData data, System.IO.TextWriter stream);
                static /*0x1595540*/ void BuildPrettyString(Unity.VisualScripting.FullSerializer.fsData data, System.IO.TextWriter stream, int depth);
                static /*0x1596420*/ void PrettyJson(Unity.VisualScripting.FullSerializer.fsData data, System.IO.TextWriter outputStream);
                static /*0x1596430*/ string PrettyJson(Unity.VisualScripting.FullSerializer.fsData data);
                static /*0x1595cf0*/ void CompressedJson(Unity.VisualScripting.FullSerializer.fsData data, System.IO.StreamWriter outputStream);
                static /*0x1595d00*/ string CompressedJson(Unity.VisualScripting.FullSerializer.fsData data);
                static /*0x1595e30*/ string ConvertDoubleToString(double d);
            }

            enum fsMemberSerialization
            {
                OptIn = 0,
                OptOut = 1,
                Default = 2,
            }

            class fsObjectAttribute : System.Attribute
            {
                /*0x10*/ System.Type[] PreviousModels;
                /*0x18*/ string VersionString;
                /*0x20*/ Unity.VisualScripting.FullSerializer.fsMemberSerialization MemberSerialization;
                /*0x28*/ System.Type Converter;
                /*0x30*/ System.Type Processor;

                /*0x1597340*/ fsObjectAttribute();
                /*0x15972e0*/ fsObjectAttribute(string versionString, System.Type[] previousModels);
            }

            class fsObjectProcessor
            {
                /*0x32f970*/ fsObjectProcessor();
                /*0x1597350*/ bool CanProcess(System.Type type);
                /*0x32d010*/ void OnBeforeSerialize(System.Type storageType, object instance);
                /*0x32d010*/ void OnAfterSerialize(System.Type storageType, object instance, ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x32d010*/ void OnBeforeDeserialize(System.Type storageType, ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x32d010*/ void OnBeforeDeserializeAfterInstanceCreation(System.Type storageType, object instance, ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x32d010*/ void OnAfterDeserialize(System.Type storageType, object instance);
            }

            class fsPropertyAttribute : System.Attribute
            {
                /*0x10*/ string Name;
                /*0x18*/ System.Type Converter;

                /*0x1598990*/ fsPropertyAttribute();
                /*0xa32e30*/ fsPropertyAttribute(string name);
            }

            struct fsResult
            {
                static /*0x0*/ string[] EmptyStringArray;
                static /*0x8*/ Unity.VisualScripting.FullSerializer.fsResult Success;
                /*0x10*/ bool _success;
                /*0x18*/ System.Collections.Generic.List<string> _messages;

                static /*0x1599810*/ fsResult();
                static /*0x1599710*/ Unity.VisualScripting.FullSerializer.fsResult Warn(string warning);
                static /*0x1599530*/ Unity.VisualScripting.FullSerializer.fsResult Fail(string warning);
                static /*0x1599bc0*/ Unity.VisualScripting.FullSerializer.fsResult op_Addition(Unity.VisualScripting.FullSerializer.fsResult a, Unity.VisualScripting.FullSerializer.fsResult b);
                /*0x15991b0*/ void AddMessage(string message);
                /*0x15992b0*/ void AddMessages(Unity.VisualScripting.FullSerializer.fsResult result);
                /*0x1599630*/ Unity.VisualScripting.FullSerializer.fsResult Merge(Unity.VisualScripting.FullSerializer.fsResult other);
                /*0xe04730*/ bool get_Failed();
                /*0xbad660*/ bool get_Succeeded();
                /*0x1599b00*/ bool get_HasWarnings();
                /*0x1599490*/ Unity.VisualScripting.FullSerializer.fsResult AssertSuccess();
                /*0x1599370*/ Unity.VisualScripting.FullSerializer.fsResult AssertSuccessWithoutWarnings();
                /*0x15998c0*/ System.Exception get_AsException();
                /*0x1599b50*/ System.Collections.Generic.IEnumerable<string> get_RawMessages();
                /*0x1599a30*/ string get_FormattedMessages();
            }

            class fsSerializer
            {
                static /*0x0*/ System.Collections.Generic.HashSet<string> _reservedKeywords;
                static /*0x8*/ string Key_ObjectReference;
                static /*0x10*/ string Key_ObjectDefinition;
                static /*0x18*/ string Key_InstanceType;
                static /*0x20*/ string Key_Version;
                static /*0x28*/ string Key_Content;
                static /*0x30*/ string Key_UnitDefault;
                static /*0x38*/ string Key_UnitPosition;
                static /*0x40*/ string Key_UnitGuid;
                static /*0x48*/ string Key_UnitFormerType;
                static /*0x50*/ string Key_UnitFormerValue;
                static /*0x58*/ string TypeName_Unit;
                static /*0x60*/ System.Type Type_Unit;
                static /*0x68*/ string TypeName_MissingType;
                static /*0x70*/ System.Type Type_MissingType;
                /*0x10*/ System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsConverter> _availableConverters;
                /*0x18*/ System.Collections.Generic.Dictionary<System.Type, Unity.VisualScripting.FullSerializer.fsDirectConverter> _availableDirectConverters;
                /*0x20*/ System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> _processors;
                /*0x28*/ Unity.VisualScripting.FullSerializer.Internal.fsCyclicReferenceManager _references;
                /*0x30*/ Unity.VisualScripting.FullSerializer.fsSerializer.fsLazyCycleDefinitionWriter _lazyReferenceWriter;
                /*0x38*/ System.Collections.Generic.Dictionary<System.Type, System.Type> _abstractTypeRemap;
                /*0x40*/ System.Collections.Generic.Dictionary<System.Type, Unity.VisualScripting.FullSerializer.fsBaseConverter> _cachedConverterTypeInstances;
                /*0x48*/ System.Collections.Generic.Dictionary<System.Type, Unity.VisualScripting.FullSerializer.fsBaseConverter> _cachedConverters;
                /*0x50*/ System.Collections.Generic.Dictionary<System.Type, System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor>> _cachedProcessors;
                /*0x58*/ Unity.VisualScripting.FullSerializer.fsContext Context;
                /*0x60*/ Unity.VisualScripting.FullSerializer.fsConfig Config;

                static /*0x15a01e0*/ fsSerializer();
                static /*0x159b130*/ System.Type GetDataType(ref Unity.VisualScripting.FullSerializer.fsData data, System.Type defaultType, ref Unity.VisualScripting.FullSerializer.fsResult deserializeResult);
                static /*0x159aad0*/ void EnsureDictionary(Unity.VisualScripting.FullSerializer.fsData data);
                static /*0x159ee20*/ bool IsReservedKeyword(string key);
                static /*0x159ed50*/ bool IsObjectReference(Unity.VisualScripting.FullSerializer.fsData data);
                static /*0x159ec80*/ bool IsObjectDefinition(Unity.VisualScripting.FullSerializer.fsData data);
                static /*0x159ef70*/ bool IsVersioned(Unity.VisualScripting.FullSerializer.fsData data);
                static /*0x159eea0*/ bool IsTypeSpecified(Unity.VisualScripting.FullSerializer.fsData data);
                static /*0x159f290*/ bool IsWrappedData(Unity.VisualScripting.FullSerializer.fsData data);
                static /*0x159f040*/ bool IsVisualScriptingUnit(Unity.VisualScripting.FullSerializer.fsData data);
                static /*0x159f6a0*/ void StripDeserializationMetadata(ref Unity.VisualScripting.FullSerializer.fsData data);
                static /*0x159a720*/ void ConvertLegacyData(ref Unity.VisualScripting.FullSerializer.fsData data);
                static /*0x159ebd0*/ void Invoke_OnBeforeSerialize(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors, System.Type storageType, object instance);
                static /*0x159e990*/ void Invoke_OnAfterSerialize(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors, System.Type storageType, object instance, ref Unity.VisualScripting.FullSerializer.fsData data);
                static /*0x159eb20*/ void Invoke_OnBeforeDeserialize(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors, System.Type storageType, ref Unity.VisualScripting.FullSerializer.fsData data);
                static /*0x159ea60*/ void Invoke_OnBeforeDeserializeAfterInstanceCreation(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors, System.Type storageType, object instance, ref Unity.VisualScripting.FullSerializer.fsData data);
                static /*0x159e8e0*/ void Invoke_OnAfterDeserialize(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors, System.Type storageType, object instance);
                /*0x15a0790*/ fsSerializer();
                /*0x159f360*/ void RemapAbstractStorageTypeToDefaultType(ref System.Type storageType);
                /*0x159a630*/ void AddProcessor(Unity.VisualScripting.FullSerializer.fsObjectProcessor processor);
                /*0x180fc0*/ void RemoveProcessor<TProcessor>();
                /*0x159f580*/ void SetDefaultStorageType(System.Type abstractType, System.Type defaultStorageType);
                /*0x159c4f0*/ System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> GetProcessors(System.Type type);
                /*0x159a350*/ void AddConverter(Unity.VisualScripting.FullSerializer.fsBaseConverter converter);
                /*0x159ac60*/ Unity.VisualScripting.FullSerializer.fsBaseConverter GetConverter(System.Type type, System.Type overrideConverterType);
                /*0x2a5510*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize<T>(T instance, ref Unity.VisualScripting.FullSerializer.fsData data);
                Unity.VisualScripting.FullSerializer.fsResult TryDeserialize<T>(Unity.VisualScripting.FullSerializer.fsData data, ref T instance);
                /*0x15a01a0*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Type storageType, object instance, ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x159fde0*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(System.Type storageType, System.Type overrideConverterType, object instance, ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x159dd50*/ Unity.VisualScripting.FullSerializer.fsResult InternalSerialize_1_ProcessCycles(System.Type storageType, System.Type overrideConverterType, object instance, ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x159e1e0*/ Unity.VisualScripting.FullSerializer.fsResult InternalSerialize_2_Inheritance(System.Type storageType, System.Type overrideConverterType, object instance, ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x159e550*/ Unity.VisualScripting.FullSerializer.fsResult InternalSerialize_3_ProcessVersioning(System.Type overrideConverterType, object instance, ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x159e830*/ Unity.VisualScripting.FullSerializer.fsResult InternalSerialize_4_Converter(System.Type overrideConverterType, object instance, ref Unity.VisualScripting.FullSerializer.fsData data);
                /*0x159fda0*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType, ref object result);
                /*0x159f920*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType, System.Type overrideConverterType, ref object result);
                /*0x159c790*/ Unity.VisualScripting.FullSerializer.fsResult InternalDeserialize_1_CycleReference(System.Type overrideConverterType, Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType, ref object result, ref System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors);
                /*0x159ca60*/ Unity.VisualScripting.FullSerializer.fsResult InternalDeserialize_2_Version(System.Type overrideConverterType, Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType, ref object result, ref System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors);
                /*0x159d1b0*/ Unity.VisualScripting.FullSerializer.fsResult InternalDeserialize_3_Inheritance(System.Type overrideConverterType, Unity.VisualScripting.FullSerializer.fsData data, System.Type storageType, ref object result, ref System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsObjectProcessor> processors);
                /*0x159d830*/ Unity.VisualScripting.FullSerializer.fsResult InternalDeserialize_4_Cycles(System.Type overrideConverterType, Unity.VisualScripting.FullSerializer.fsData data, System.Type resultType, ref object result);
                /*0x159db50*/ Unity.VisualScripting.FullSerializer.fsResult InternalDeserialize_5_Converter(System.Type overrideConverterType, Unity.VisualScripting.FullSerializer.fsData data, System.Type resultType, ref object result);

                class fsLazyCycleDefinitionWriter
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<int, Unity.VisualScripting.FullSerializer.fsData> _pendingDefinitions;
                    /*0x18*/ System.Collections.Generic.HashSet<int> _references;

                    /*0x15a43a0*/ fsLazyCycleDefinitionWriter();
                    /*0x15a4010*/ void WriteDefinition(int id, Unity.VisualScripting.FullSerializer.fsData data);
                    /*0x15a4170*/ void WriteReference(int id, System.Collections.Generic.Dictionary<string, Unity.VisualScripting.FullSerializer.fsData> dict);
                    /*0x15a3fa0*/ void Clear();
                }
            }

            class fsMetaProperty
            {
                /*0x10*/ System.Reflection.MemberInfo _memberInfo;
                /*0x18*/ System.Type <StorageType>k__BackingField;
                /*0x20*/ System.Type <OverrideConverterType>k__BackingField;
                /*0x28*/ bool <CanRead>k__BackingField;
                /*0x29*/ bool <CanWrite>k__BackingField;
                /*0x30*/ string <JsonName>k__BackingField;
                /*0x38*/ string <MemberName>k__BackingField;
                /*0x40*/ bool <IsPublic>k__BackingField;
                /*0x41*/ bool <IsReadOnly>k__BackingField;

                /*0x15a4ad0*/ fsMetaProperty(Unity.VisualScripting.FullSerializer.fsConfig config, System.Reflection.FieldInfo field);
                /*0x15a4970*/ fsMetaProperty(Unity.VisualScripting.FullSerializer.fsConfig config, System.Reflection.PropertyInfo property);
                /*0x32f410*/ System.Type get_StorageType();
                /*0x7963c0*/ void set_StorageType(System.Type value);
                /*0x61a260*/ System.Type get_OverrideConverterType();
                /*0x7965a0*/ void set_OverrideConverterType(System.Type value);
                /*0x4ba480*/ bool get_CanRead();
                /*0xd18990*/ void set_CanRead(bool value);
                /*0x12a2930*/ bool get_CanWrite();
                /*0x12a21f0*/ void set_CanWrite(bool value);
                /*0x997630*/ string get_JsonName();
                /*0x997640*/ void set_JsonName(string value);
                /*0x995140*/ string get_MemberName();
                /*0xe5a080*/ void set_MemberName(string value);
                /*0xb61dd0*/ bool get_IsPublic();
                /*0xb61de0*/ void set_IsPublic(bool value);
                /*0xf17ee0*/ bool get_IsReadOnly();
                /*0x138e4c0*/ void set_IsReadOnly(bool value);
                /*0x15a4460*/ void CommonInitialize(Unity.VisualScripting.FullSerializer.fsConfig config);
                /*0x15a4690*/ void Write(object context, object value);
                /*0x15a4550*/ object Read(object context);
            }

            class fsMetaType
            {
                static /*0x0*/ System.Collections.Generic.Dictionary<Unity.VisualScripting.FullSerializer.fsConfig, System.Collections.Generic.Dictionary<System.Type, Unity.VisualScripting.FullSerializer.fsMetaType>> _configMetaTypes;
                /*0x10*/ System.Type ReflectedType;
                /*0x18*/ bool _hasEmittedAotData;
                /*0x19*/ System.Nullable<bool> _hasDefaultConstructorCache;
                /*0x1b*/ bool _isDefaultConstructorPublic;
                /*0x20*/ Unity.VisualScripting.FullSerializer.fsMetaProperty[] <Properties>k__BackingField;

                static /*0x15a6320*/ fsMetaType();
                static /*0x15a5ec0*/ Unity.VisualScripting.FullSerializer.fsMetaType Get(Unity.VisualScripting.FullSerializer.fsConfig config, System.Type type);
                static /*0x15a51b0*/ void ClearCache();
                static /*0x15a5300*/ void CollectProperties(Unity.VisualScripting.FullSerializer.fsConfig config, System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.fsMetaProperty> properties, System.Type reflectedType);
                static /*0x15a6220*/ bool IsAutoProperty(System.Reflection.PropertyInfo property, System.Reflection.MemberInfo[] members);
                static /*0x15a4db0*/ bool CanSerializeProperty(Unity.VisualScripting.FullSerializer.fsConfig config, System.Reflection.PropertyInfo property, System.Reflection.MemberInfo[] members, bool annotationFreeValue);
                static /*0x15a4ba0*/ bool CanSerializeField(Unity.VisualScripting.FullSerializer.fsConfig config, System.Reflection.FieldInfo field, bool annotationFreeValue);
                /*0x15a63b0*/ fsMetaType(Unity.VisualScripting.FullSerializer.fsConfig config, System.Type reflectedType);
                /*0x61a260*/ Unity.VisualScripting.FullSerializer.fsMetaProperty[] get_Properties();
                /*0x7965a0*/ void set_Properties(Unity.VisualScripting.FullSerializer.fsMetaProperty[] value);
                /*0x15a64b0*/ bool get_HasDefaultConstructor();
                /*0x15a5dd0*/ bool EmitAotData();
                /*0x15a58e0*/ object CreateInstance();

                class <>c__DisplayClass16_0
                {
                    /*0x10*/ System.Reflection.MemberInfo member;

                    /*0x32f970*/ <>c__DisplayClass16_0();
                    /*0x15a3340*/ bool <CollectProperties>b__0(System.Type t);
                    /*0x15a33e0*/ bool <CollectProperties>b__1(System.Type t);
                    /*0x15a3480*/ bool <CollectProperties>b__2(System.Type t);
                }

                class <>c__DisplayClass18_0
                {
                    /*0x10*/ System.Reflection.PropertyInfo property;

                    /*0x32f970*/ <>c__DisplayClass18_0();
                    /*0x15a3520*/ bool <CanSerializeProperty>b__0(System.Type t);
                }

                class <>c__DisplayClass19_0
                {
                    /*0x10*/ System.Reflection.FieldInfo field;

                    /*0x32f970*/ <>c__DisplayClass19_0();
                    /*0x15a35c0*/ bool <CanSerializeField>b__0(System.Type t);
                }
            }

            class fsReflectionUtility
            {
                static /*0x15a79f0*/ System.Type GetInterface(System.Type type, System.Type interfaceType);
            }

            class fsTypeCache
            {
            }

            namespace Internal
            {
                class fsCyclicReferenceManager
                {
                    /*0x10*/ System.Collections.Generic.Dictionary<object, int> _objectIds;
                    /*0x18*/ int _nextId;
                    /*0x20*/ System.Collections.Generic.Dictionary<int, object> _marked;
                    /*0x28*/ int _depth;

                    /*0x15a3ea0*/ fsCyclicReferenceManager();
                    /*0x3c2a30*/ void Enter();
                    /*0x15a39f0*/ bool Exit();
                    /*0x15a3c00*/ object GetReferenceObject(int id);
                    /*0x15a3980*/ void AddReferenceWithId(int id, object reference);
                    /*0x15a3b60*/ int GetReferenceId(object item);
                    /*0x15a3d00*/ bool IsReference(object item);
                    /*0x15a3d70*/ void MarkSerialized(object item);

                    class ObjectReferenceEqualityComparator : System.Collections.Generic.IEqualityComparer<object>
                    {
                        static /*0x0*/ System.Collections.Generic.IEqualityComparer<object> Instance;

                        static /*0x15a25a0*/ ObjectReferenceEqualityComparator();
                        /*0x32f970*/ ObjectReferenceEqualityComparator();
                        /*0xc44d90*/ bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y);
                        /*0x15a2590*/ int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj);
                    }
                }

                struct fsOption<T>
                {
                    static /*0x0*/ Unity.VisualScripting.FullSerializer.Internal.fsOption<T> Empty;
                    /*0x0*/ bool _hasValue;
                    /*0x0*/ T _value;

                    /*0x2a5510*/ fsOption(T value);
                    /*0x17cb40*/ bool get_HasValue();
                    /*0x17cb40*/ bool get_IsEmpty();
                    /*0x2a5510*/ T get_Value();
                }

                class fsOption
                {
                    static /*0x2a5510*/ Unity.VisualScripting.FullSerializer.Internal.fsOption<T> Just<T>(T value);
                }

                class fsPortableReflection
                {
                    static /*0x0*/ System.Type[] EmptyTypes;
                    static /*0x8*/ System.Collections.Generic.IDictionary<Unity.VisualScripting.FullSerializer.Internal.fsPortableReflection.AttributeQuery, System.Attribute> _cachedAttributeQueries;
                    static /*0x10*/ System.Reflection.BindingFlags DeclaredFlags;

                    static /*0x15a78d0*/ fsPortableReflection();
                    static /*0x177700*/ bool HasAttribute<TAttribute>(System.Reflection.MemberInfo element);
                    static /*0x17ec30*/ bool HasAttribute<TAttribute>(System.Reflection.MemberInfo element, bool shouldCache);
                    static /*0x15a77f0*/ bool HasAttribute(System.Reflection.MemberInfo element, System.Type attributeType);
                    static /*0xf6bea0*/ bool HasAttribute(System.Reflection.MemberInfo element, System.Type attributeType, bool shouldCache);
                    static /*0x15a66f0*/ System.Attribute GetAttribute(System.Reflection.MemberInfo element, System.Type attributeType, bool shouldCache);
                    static /*0x2a5510*/ TAttribute GetAttribute<TAttribute>(System.Reflection.MemberInfo element, bool shouldCache);
                    static /*0x2a5510*/ TAttribute GetAttribute<TAttribute>(System.Reflection.MemberInfo element);
                    static /*0x15a7060*/ System.Reflection.PropertyInfo GetDeclaredProperty(System.Type type, string propertyName);
                    static /*0x15a6e20*/ System.Reflection.MethodInfo GetDeclaredMethod(System.Type type, string methodName);
                    static /*0x15a6960*/ System.Reflection.ConstructorInfo GetDeclaredConstructor(System.Type type, System.Type[] parameters);
                    static /*0x15a6b60*/ System.Reflection.ConstructorInfo[] GetDeclaredConstructors(System.Type type);
                    static /*0x15a71a0*/ System.Reflection.MemberInfo[] GetFlattenedMember(System.Type type, string memberName);
                    static /*0x15a73e0*/ System.Reflection.MethodInfo GetFlattenedMethod(System.Type type, string methodName);
                    static /*0x15a75a0*/ System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo> GetFlattenedMethods(System.Type type, string methodName);
                    static /*0x15a7630*/ System.Reflection.PropertyInfo GetFlattenedProperty(System.Type type, string propertyName);
                    static /*0x15a6c60*/ System.Reflection.MemberInfo GetDeclaredMember(System.Type type, string memberName);
                    static /*0x15a6f60*/ System.Reflection.MethodInfo[] GetDeclaredMethods(System.Type type);
                    static /*0x15a6fe0*/ System.Reflection.PropertyInfo[] GetDeclaredProperties(System.Type type);
                    static /*0x15a6be0*/ System.Reflection.FieldInfo[] GetDeclaredFields(System.Type type);
                    static /*0x15a6da0*/ System.Reflection.MemberInfo[] GetDeclaredMembers(System.Type type);
                    static /*0x621ca0*/ System.Reflection.MemberInfo AsMemberInfo(System.Type type);
                    static /*0x15a7850*/ bool IsType(System.Reflection.MemberInfo member);
                    static /*0x15a6670*/ System.Type AsType(System.Reflection.MemberInfo member);
                    static /*0x621ca0*/ System.Type Resolve(System.Type type);

                    struct AttributeQuery
                    {
                        /*0x10*/ System.Reflection.MemberInfo MemberInfo;
                        /*0x18*/ System.Type AttributeType;
                    }

                    class AttributeQueryComparator : System.Collections.Generic.IEqualityComparer<Unity.VisualScripting.FullSerializer.Internal.fsPortableReflection.AttributeQuery>
                    {
                        /*0x32f970*/ AttributeQueryComparator();
                        /*0x15a2430*/ bool Equals(Unity.VisualScripting.FullSerializer.Internal.fsPortableReflection.AttributeQuery x, Unity.VisualScripting.FullSerializer.Internal.fsPortableReflection.AttributeQuery y);
                        /*0x15a24b0*/ int GetHashCode(Unity.VisualScripting.FullSerializer.Internal.fsPortableReflection.AttributeQuery obj);
                    }

                    class <GetFlattenedMethods>d__18 : System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>, System.Collections.IEnumerable, System.Collections.Generic.IEnumerator<System.Reflection.MethodInfo>, System.Collections.IEnumerator, System.IDisposable
                    {
                        /*0x10*/ int <>1__state;
                        /*0x18*/ System.Reflection.MethodInfo <>2__current;
                        /*0x20*/ int <>l__initialThreadId;
                        /*0x28*/ System.Type type;
                        /*0x30*/ System.Type <>3__type;
                        /*0x38*/ string methodName;
                        /*0x40*/ string <>3__methodName;
                        /*0x48*/ System.Reflection.MethodInfo[] <methods>5__2;
                        /*0x50*/ int <i>5__3;

                        /*0x70aad0*/ <GetFlattenedMethods>d__18(int <>1__state);
                        /*0x32d010*/ void System.IDisposable.Dispose();
                        /*0x15a3010*/ bool MoveNext();
                        /*0x32f410*/ System.Reflection.MethodInfo System.Collections.Generic.IEnumerator<System.Reflection.MethodInfo>.get_Current();
                        /*0x15a3300*/ void System.Collections.IEnumerator.Reset();
                        /*0x32f410*/ object System.Collections.IEnumerator.get_Current();
                        /*0x15a3250*/ System.Collections.Generic.IEnumerator<System.Reflection.MethodInfo> System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>.GetEnumerator();
                        /*0x15a3250*/ System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator();
                    }
                }

                class fsTypeExtensions
                {
                    static /*0x15a82f0*/ string CSharpName(System.Type type);
                    static /*0x15a7c80*/ string CSharpName(System.Type type, bool includeNamespace, bool ensureSafeDeclarationName);
                    static /*0x15a7d00*/ string CSharpName(System.Type type, bool includeNamespace);

                    class <>c__DisplayClass2_0
                    {
                        /*0x10*/ bool includeNamespace;

                        /*0x32f970*/ <>c__DisplayClass2_0();
                        /*0x15a3660*/ string <CSharpName>b__0(System.Type t);
                    }
                }

                struct fsVersionedType
                {
                    /*0x10*/ Unity.VisualScripting.FullSerializer.Internal.fsVersionedType[] Ancestors;
                    /*0x18*/ string VersionString;
                    /*0x20*/ System.Type ModelType;

                    static /*0x15a9570*/ bool op_Equality(Unity.VisualScripting.FullSerializer.Internal.fsVersionedType a, Unity.VisualScripting.FullSerializer.Internal.fsVersionedType b);
                    static /*0x15a95f0*/ bool op_Inequality(Unity.VisualScripting.FullSerializer.Internal.fsVersionedType a, Unity.VisualScripting.FullSerializer.Internal.fsVersionedType b);
                    /*0x15a9320*/ object Migrate(object ancestorInstance);
                    /*0x15a93e0*/ string ToString();
                    /*0x15a9270*/ bool Equals(object obj);
                    /*0xe77c60*/ int GetHashCode();
                }

                class fsVersionManager
                {
                    static /*0x0*/ System.Collections.Generic.Dictionary<System.Type, Unity.VisualScripting.FullSerializer.Internal.fsOption<Unity.VisualScripting.FullSerializer.Internal.fsVersionedType>> _cache;

                    static /*0x15a91e0*/ fsVersionManager();
                    static /*0x15a8480*/ Unity.VisualScripting.FullSerializer.fsResult GetVersionImportPath(string currentVersion, Unity.VisualScripting.FullSerializer.Internal.fsVersionedType targetVersion, ref System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.Internal.fsVersionedType> path);
                    static /*0x15a8300*/ bool GetVersionImportPathRecursive(System.Collections.Generic.List<Unity.VisualScripting.FullSerializer.Internal.fsVersionedType> path, string currentVersion, Unity.VisualScripting.FullSerializer.Internal.fsVersionedType current);
                    static /*0x15a8780*/ Unity.VisualScripting.FullSerializer.Internal.fsOption<Unity.VisualScripting.FullSerializer.Internal.fsVersionedType> GetVersionedType(System.Type type);
                    static /*0x15a8ca0*/ void VerifyConstructors(Unity.VisualScripting.FullSerializer.Internal.fsVersionedType type);
                    static /*0x15a8f30*/ void VerifyUniqueVersionStrings(Unity.VisualScripting.FullSerializer.Internal.fsVersionedType type);
                }

                namespace Converters
                {
                    class UnityEvent_Converter : Unity.VisualScripting.FullSerializer.fsConverter
                    {
                        /*0x534220*/ UnityEvent_Converter();
                        /*0x15a36f0*/ bool CanProcess(System.Type type);
                        /*0x348b00*/ bool RequestCycleSupport(System.Type storageType);
                        /*0x15a37f0*/ Unity.VisualScripting.FullSerializer.fsResult TryDeserialize(Unity.VisualScripting.FullSerializer.fsData data, ref object instance, System.Type storageType);
                        /*0x15a38e0*/ Unity.VisualScripting.FullSerializer.fsResult TrySerialize(object instance, ref Unity.VisualScripting.FullSerializer.fsData serialized, System.Type storageType);
                    }
                }
            }
        }

        namespace AssemblyQualifiedNameParser
        {
            class ParsedAssemblyQualifiedName
            {
                /*0x10*/ string <AssemblyDescriptionString>k__BackingField;
                /*0x18*/ string <TypeName>k__BackingField;
                /*0x20*/ string <ShortAssemblyName>k__BackingField;
                /*0x28*/ string <Version>k__BackingField;
                /*0x30*/ string <Culture>k__BackingField;
                /*0x38*/ string <PublicKeyToken>k__BackingField;
                /*0x40*/ System.Collections.Generic.List<Unity.VisualScripting.AssemblyQualifiedNameParser.ParsedAssemblyQualifiedName> <GenericParameters>k__BackingField;
                /*0x48*/ int <GenericParameterCount>k__BackingField;

                static /*0x15a2610*/ string LookForPairThenRemove(System.Collections.Generic.List<string> strings, string Name);
                /*0x15a2ad0*/ ParsedAssemblyQualifiedName(string AssemblyQualifiedName);
                /*0x73d3e0*/ string get_AssemblyDescriptionString();
                /*0x32f410*/ string get_TypeName();
                /*0x7963c0*/ void set_TypeName(string value);
                /*0x61a260*/ string get_ShortAssemblyName();
                /*0x79a150*/ string get_Version();
                /*0x997630*/ string get_Culture();
                /*0x995140*/ string get_PublicKeyToken();
                /*0xb61870*/ System.Collections.Generic.List<Unity.VisualScripting.AssemblyQualifiedNameParser.ParsedAssemblyQualifiedName> get_GenericParameters();
                /*0x12f47d0*/ int get_GenericParameterCount();
                /*0x15a2700*/ void Replace(string oldTypeName, string newTypeName);
                /*0x15a2840*/ string ToString(bool includeAssemblyDescription);
                /*0x15a2ac0*/ string ToString();

                class Block
                {
                    /*0x10*/ int startIndex;
                    /*0x14*/ int endIndex;
                    /*0x18*/ int level;
                    /*0x20*/ Unity.VisualScripting.AssemblyQualifiedNameParser.ParsedAssemblyQualifiedName.Block parentBlock;
                    /*0x28*/ System.Collections.Generic.List<Unity.VisualScripting.AssemblyQualifiedNameParser.ParsedAssemblyQualifiedName.Block> innerBlocks;
                    /*0x30*/ Unity.VisualScripting.AssemblyQualifiedNameParser.ParsedAssemblyQualifiedName parsedAssemblyQualifiedName;

                    /*0x15a2510*/ Block();
                }

                class <>c
                {
                    static /*0x0*/ Unity.VisualScripting.AssemblyQualifiedNameParser.ParsedAssemblyQualifiedName.<> <>9;
                    static /*0x8*/ System.Func<string, string> <>9__25_0;

                    static /*0x15a3680*/ <>c();
                    /*0x32f970*/ <>c();
                    /*0x1573940*/ string <.ctor>b__25_0(string x);
                }
            }
        }
    }
}

class <PrivateImplementationDetails>
{
    static /*0x0*/ <PrivateImplementationDetails> 18F40D6E31DB1AE781A23220CE0911CF9FAAA096402AF8471ED2A3EDD2252089;
    static /*0xd25a*/ <PrivateImplementationDetails> D0AD1B26A590721C9872D0C0A45A74E1F5016FC4408D39DAFE274DBC658FA833;

    struct __StaticArrayInitTypeSize=22425
    {
    }

    struct __StaticArrayInitTypeSize=53850
    {
    }
}
